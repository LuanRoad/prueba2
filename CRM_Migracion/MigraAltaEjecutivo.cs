using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_Migracion
{
    class MigraAltaEjecutivo
    {
        public void Migra(int idReferido)
        {
            SAAPADataContext saapa = new SAAPADataContext();
            SISECDataContext sisec = new SISECDataContext();
            var query = saapa.BrokersAltaEjecutivo.Where(x => x.IdInmobiliaria == idReferido);
            foreach (var EjecutivoSAAPA in query)
            {
                var EjecutivoSISEC = sisec.BrokersAltaEjecutivoSISEC.Where(x => x.Id == EjecutivoSAAPA.Id).FirstOrDefault();
                if (EjecutivoSISEC == null)
                {
                    saapa.InsertarAltaEjecutivo(EjecutivoSAAPA.Id);
                }
                else if (EjecutivoSISEC.Equals(EjecutivoSAAPA))
                {
                    //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('este pinche wey es igual... no se hace nada')", true);
                }
                else if (EjecutivoSISEC.Id == EjecutivoSAAPA.Id &&
                        (EjecutivoSISEC.Curp == EjecutivoSAAPA.Curp) &&
                        (EjecutivoSISEC.Nombre == EjecutivoSAAPA.Nombre ||
                        EjecutivoSISEC.SegundoNombre == EjecutivoSAAPA.SegundoNombre ||
                        EjecutivoSISEC.ApellidoPaterno == EjecutivoSAAPA.ApellidoPaterno ||
                        EjecutivoSISEC.ApellidoMaterno == EjecutivoSAAPA.ApellidoMaterno))
                {
                    try
                    {
                        saapa.ActualizarAltaEjecutivo(EjecutivoSAAPA.Id);
                    }
                    catch (Exception ex)
                    {
                        throw ex.InnerException;
                    }
                }
                else
                {
                    saapa.InsertarAlFinalAltaEjecutivo(EjecutivoSAAPA.Id);
                    var ultimoRegistro = sisec.BrokersReferidosSISEC.OrderByDescending(x => x.Id).FirstOrDefault();
                }

                //Funcion para migrar Alta Ejecutivos.//////////////////////

            }
        }
    }
}
