﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRM_Migracion
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SISEC")]
	public partial class SISECDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertBrokersAltaEjecutivoSISEC(BrokersAltaEjecutivoSISEC instance);
    partial void UpdateBrokersAltaEjecutivoSISEC(BrokersAltaEjecutivoSISEC instance);
    partial void DeleteBrokersAltaEjecutivoSISEC(BrokersAltaEjecutivoSISEC instance);
    partial void InsertBrokersReferidosSISEC(BrokersReferidosSISEC instance);
    partial void UpdateBrokersReferidosSISEC(BrokersReferidosSISEC instance);
    partial void DeleteBrokersReferidosSISEC(BrokersReferidosSISEC instance);
    #endregion
		
		public SISECDataContext() : 
				base(global::CRM_Migracion.Properties.Settings.Default.SISECConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SISECDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SISECDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SISECDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SISECDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<BrokersAltaEjecutivoSISEC> BrokersAltaEjecutivoSISEC
		{
			get
			{
				return this.GetTable<BrokersAltaEjecutivoSISEC>();
			}
		}
		
		public System.Data.Linq.Table<BrokersReferidosSISEC> BrokersReferidosSISEC
		{
			get
			{
				return this.GetTable<BrokersReferidosSISEC>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BrokersAltaEjecutivo")]
	public partial class BrokersAltaEjecutivoSISEC : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _IdInmobiliaria;
		
		private string _Nombre;
		
		private string _SegundoNombre;
		
		private string _ApellidoPaterno;
		
		private string _ApellidoMaterno;
		
		private System.DateTime _FechaRegistro;
		
		private System.Nullable<System.Guid> _UserIdRegistro;
		
		private bool _activo;
		
		private string _Telefono;
		
		private string _Correo;
		
		private string _Curp;
		
		private System.Nullable<int> _IdBrokerEmpleado;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnIdInmobiliariaChanging(int value);
    partial void OnIdInmobiliariaChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnSegundoNombreChanging(string value);
    partial void OnSegundoNombreChanged();
    partial void OnApellidoPaternoChanging(string value);
    partial void OnApellidoPaternoChanged();
    partial void OnApellidoMaternoChanging(string value);
    partial void OnApellidoMaternoChanged();
    partial void OnFechaRegistroChanging(System.DateTime value);
    partial void OnFechaRegistroChanged();
    partial void OnUserIdRegistroChanging(System.Nullable<System.Guid> value);
    partial void OnUserIdRegistroChanged();
    partial void OnactivoChanging(bool value);
    partial void OnactivoChanged();
    partial void OnTelefonoChanging(string value);
    partial void OnTelefonoChanged();
    partial void OnCorreoChanging(string value);
    partial void OnCorreoChanged();
    partial void OnCurpChanging(string value);
    partial void OnCurpChanged();
    partial void OnIdBrokerEmpleadoChanging(System.Nullable<int> value);
    partial void OnIdBrokerEmpleadoChanged();
    #endregion
		
		public BrokersAltaEjecutivoSISEC()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdInmobiliaria", DbType="Int NOT NULL")]
		public int IdInmobiliaria
		{
			get
			{
				return this._IdInmobiliaria;
			}
			set
			{
				if ((this._IdInmobiliaria != value))
				{
					this.OnIdInmobiliariaChanging(value);
					this.SendPropertyChanging();
					this._IdInmobiliaria = value;
					this.SendPropertyChanged("IdInmobiliaria");
					this.OnIdInmobiliariaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SegundoNombre", DbType="NVarChar(50)")]
		public string SegundoNombre
		{
			get
			{
				return this._SegundoNombre;
			}
			set
			{
				if ((this._SegundoNombre != value))
				{
					this.OnSegundoNombreChanging(value);
					this.SendPropertyChanging();
					this._SegundoNombre = value;
					this.SendPropertyChanged("SegundoNombre");
					this.OnSegundoNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ApellidoPaterno", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string ApellidoPaterno
		{
			get
			{
				return this._ApellidoPaterno;
			}
			set
			{
				if ((this._ApellidoPaterno != value))
				{
					this.OnApellidoPaternoChanging(value);
					this.SendPropertyChanging();
					this._ApellidoPaterno = value;
					this.SendPropertyChanged("ApellidoPaterno");
					this.OnApellidoPaternoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ApellidoMaterno", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string ApellidoMaterno
		{
			get
			{
				return this._ApellidoMaterno;
			}
			set
			{
				if ((this._ApellidoMaterno != value))
				{
					this.OnApellidoMaternoChanging(value);
					this.SendPropertyChanging();
					this._ApellidoMaterno = value;
					this.SendPropertyChanged("ApellidoMaterno");
					this.OnApellidoMaternoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaRegistro", DbType="DateTime NOT NULL")]
		public System.DateTime FechaRegistro
		{
			get
			{
				return this._FechaRegistro;
			}
			set
			{
				if ((this._FechaRegistro != value))
				{
					this.OnFechaRegistroChanging(value);
					this.SendPropertyChanging();
					this._FechaRegistro = value;
					this.SendPropertyChanged("FechaRegistro");
					this.OnFechaRegistroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserIdRegistro", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> UserIdRegistro
		{
			get
			{
				return this._UserIdRegistro;
			}
			set
			{
				if ((this._UserIdRegistro != value))
				{
					this.OnUserIdRegistroChanging(value);
					this.SendPropertyChanging();
					this._UserIdRegistro = value;
					this.SendPropertyChanged("UserIdRegistro");
					this.OnUserIdRegistroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_activo", DbType="Bit NOT NULL")]
		public bool activo
		{
			get
			{
				return this._activo;
			}
			set
			{
				if ((this._activo != value))
				{
					this.OnactivoChanging(value);
					this.SendPropertyChanging();
					this._activo = value;
					this.SendPropertyChanged("activo");
					this.OnactivoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telefono", DbType="NVarChar(50)")]
		public string Telefono
		{
			get
			{
				return this._Telefono;
			}
			set
			{
				if ((this._Telefono != value))
				{
					this.OnTelefonoChanging(value);
					this.SendPropertyChanging();
					this._Telefono = value;
					this.SendPropertyChanged("Telefono");
					this.OnTelefonoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Correo", DbType="NVarChar(70)")]
		public string Correo
		{
			get
			{
				return this._Correo;
			}
			set
			{
				if ((this._Correo != value))
				{
					this.OnCorreoChanging(value);
					this.SendPropertyChanging();
					this._Correo = value;
					this.SendPropertyChanged("Correo");
					this.OnCorreoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Curp", DbType="NVarChar(18)")]
		public string Curp
		{
			get
			{
				return this._Curp;
			}
			set
			{
				if ((this._Curp != value))
				{
					this.OnCurpChanging(value);
					this.SendPropertyChanging();
					this._Curp = value;
					this.SendPropertyChanged("Curp");
					this.OnCurpChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdBrokerEmpleado", DbType="Int")]
		public System.Nullable<int> IdBrokerEmpleado
		{
			get
			{
				return this._IdBrokerEmpleado;
			}
			set
			{
				if ((this._IdBrokerEmpleado != value))
				{
					this.OnIdBrokerEmpleadoChanging(value);
					this.SendPropertyChanging();
					this._IdBrokerEmpleado = value;
					this.SendPropertyChanged("IdBrokerEmpleado");
					this.OnIdBrokerEmpleadoChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BrokersReferidos")]
	public partial class BrokersReferidosSISEC : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _IdBroker;
		
		private string _Nombre;
		
		private System.Nullable<int> _IdTipoReferido;
		
		private System.Nullable<System.Guid> _IdRegistro;
		
		private System.Nullable<System.DateTime> _FechaRegistro;
		
		private System.Nullable<bool> _Activo;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnIdBrokerChanging(System.Nullable<int> value);
    partial void OnIdBrokerChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnIdTipoReferidoChanging(System.Nullable<int> value);
    partial void OnIdTipoReferidoChanged();
    partial void OnIdRegistroChanging(System.Nullable<System.Guid> value);
    partial void OnIdRegistroChanged();
    partial void OnFechaRegistroChanging(System.Nullable<System.DateTime> value);
    partial void OnFechaRegistroChanged();
    partial void OnActivoChanging(System.Nullable<bool> value);
    partial void OnActivoChanged();
    #endregion
		
		public BrokersReferidosSISEC()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdBroker", DbType="Int")]
		public System.Nullable<int> IdBroker
		{
			get
			{
				return this._IdBroker;
			}
			set
			{
				if ((this._IdBroker != value))
				{
					this.OnIdBrokerChanging(value);
					this.SendPropertyChanging();
					this._IdBroker = value;
					this.SendPropertyChanged("IdBroker");
					this.OnIdBrokerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="NVarChar(200)")]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdTipoReferido", DbType="Int")]
		public System.Nullable<int> IdTipoReferido
		{
			get
			{
				return this._IdTipoReferido;
			}
			set
			{
				if ((this._IdTipoReferido != value))
				{
					this.OnIdTipoReferidoChanging(value);
					this.SendPropertyChanging();
					this._IdTipoReferido = value;
					this.SendPropertyChanged("IdTipoReferido");
					this.OnIdTipoReferidoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdRegistro", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> IdRegistro
		{
			get
			{
				return this._IdRegistro;
			}
			set
			{
				if ((this._IdRegistro != value))
				{
					this.OnIdRegistroChanging(value);
					this.SendPropertyChanging();
					this._IdRegistro = value;
					this.SendPropertyChanged("IdRegistro");
					this.OnIdRegistroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaRegistro", DbType="DateTime")]
		public System.Nullable<System.DateTime> FechaRegistro
		{
			get
			{
				return this._FechaRegistro;
			}
			set
			{
				if ((this._FechaRegistro != value))
				{
					this.OnFechaRegistroChanging(value);
					this.SendPropertyChanging();
					this._FechaRegistro = value;
					this.SendPropertyChanged("FechaRegistro");
					this.OnFechaRegistroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Activo", DbType="Bit")]
		public System.Nullable<bool> Activo
		{
			get
			{
				return this._Activo;
			}
			set
			{
				if ((this._Activo != value))
				{
					this.OnActivoChanging(value);
					this.SendPropertyChanging();
					this._Activo = value;
					this.SendPropertyChanged("Activo");
					this.OnActivoChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
