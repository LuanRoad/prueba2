using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_Migracion
{
    class Program
    {

        static void Main(string[] args)
        {
            
            SAAPADataContext saapa = new SAAPADataContext();
            SISECDataContext sisec = new SISECDataContext();
            var Migrar = saapa.BrokersMigrar.Where(x=> x.Migracion == false);
            foreach(var idbroker in Migrar) { 
                var query = saapa.BrokersReferido.Where(x => x.IdBroker == idbroker.Idbroker);
                foreach (var referidosaapa in query)
                {
                    var referidosisec = sisec.BrokersReferidosSISEC.Where(x => x.Id == referidosaapa.Id).FirstOrDefault();
                    if (referidosisec == null)
                    {
                        saapa.InsertarReferido(referidosaapa.Id);
                    }
                    else if (referidosisec.Equals(referidosaapa))
                    {
                        //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('este pinche wey es igual... no se hace nada')", true);
                    }
                    else if (referidosisec.Id == referidosaapa.Id &&
                            (referidosisec.Nombre == referidosaapa.Nombre) &&
                            (referidosisec.IdTipoReferido == referidosaapa.IdTipoReferido ||
                            referidosisec.IdRegistro == referidosaapa.UserIdRegistro ||
                            referidosisec.FechaRegistro == referidosaapa.FechaRegistro ||
                            referidosisec.Activo == referidosaapa.Activo))
                    {
                        try
                        {
                            saapa.ActualizarReferido(referidosaapa.Id);
                        }
                        catch (Exception ex)
                        {
                            throw ex.InnerException;
                        }
                    }
                    else
                    {
                        saapa.InsertarAlFinalBrokersReferido(referidosaapa.Id);
                        var ultimoRegistro = sisec.BrokersReferidosSISEC.OrderByDescending(x => x.Id).FirstOrDefault();
                        try
                        {
                            var x = saapa.ActualizarTablasRelacinadasReferidos(ultimoRegistro.Id, referidosaapa.Id);
                        }
                        catch (Exception ex)
                        {
                            throw ex.InnerException;
                        }
                    }
                    //Funcion para migrar Alta Ejecutivos.//////////////////////
                    MigraAltaEjecutivo alta = new MigraAltaEjecutivo();
                    alta.Migra(referidosaapa.Id);
                }
            }
            Console.WriteLine("el proceso termino");
            Console.ReadLine();
        }
    }
}
