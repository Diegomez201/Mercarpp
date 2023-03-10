#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mercarpp
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="appmercar")]
	public partial class ModelDataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertCliente(Cliente instance);
    partial void UpdateCliente(Cliente instance);
    partial void DeleteCliente(Cliente instance);
    partial void InsertCompra(Compra instance);
    partial void UpdateCompra(Compra instance);
    partial void DeleteCompra(Compra instance);
    partial void InsertSueldoQuincena(SueldoQuincena instance);
    partial void UpdateSueldoQuincena(SueldoQuincena instance);
    partial void DeleteSueldoQuincena(SueldoQuincena instance);
    #endregion
		
		public ModelDataDataContext() : 
				base(global::Mercarpp.Properties.Settings.Default.appmercarConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ModelDataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ModelDataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ModelDataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ModelDataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Cliente> Cliente
		{
			get
			{
				return this.GetTable<Cliente>();
			}
		}
		
		public System.Data.Linq.Table<Compra> Compra
		{
			get
			{
				return this.GetTable<Compra>();
			}
		}
		
		public System.Data.Linq.Table<SueldoQuincena> SueldoQuincena
		{
			get
			{
				return this.GetTable<SueldoQuincena>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Cliente")]
	public partial class Cliente : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private int _Cedula;
		
		private string _Nombre;
		
		private bool _EsCliente;
		
		private string _Loggin;
		
		private string _Clave;
		
		private string _Tipo;
		
		private EntitySet<Compra> _Compra;
		
		private EntitySet<SueldoQuincena> _SueldoQuincena;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnCedulaChanging(int value);
    partial void OnCedulaChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnEsClienteChanging(bool value);
    partial void OnEsClienteChanged();
    partial void OnLogginChanging(string value);
    partial void OnLogginChanged();
    partial void OnClaveChanging(string value);
    partial void OnClaveChanged();
    partial void OnTipoChanging(string value);
    partial void OnTipoChanged();
    #endregion
		
		public Cliente()
		{
			this._Compra = new EntitySet<Compra>(new Action<Compra>(this.attach_Compra), new Action<Compra>(this.detach_Compra));
			this._SueldoQuincena = new EntitySet<SueldoQuincena>(new Action<SueldoQuincena>(this.attach_SueldoQuincena), new Action<SueldoQuincena>(this.detach_SueldoQuincena));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cedula", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Cedula
		{
			get
			{
				return this._Cedula;
			}
			set
			{
				if ((this._Cedula != value))
				{
					this.OnCedulaChanging(value);
					this.SendPropertyChanging();
					this._Cedula = value;
					this.SendPropertyChanged("Cedula");
					this.OnCedulaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EsCliente", DbType="Bit NOT NULL")]
		public bool EsCliente
		{
			get
			{
				return this._EsCliente;
			}
			set
			{
				if ((this._EsCliente != value))
				{
					this.OnEsClienteChanging(value);
					this.SendPropertyChanging();
					this._EsCliente = value;
					this.SendPropertyChanged("EsCliente");
					this.OnEsClienteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Loggin", DbType="VarChar(30)")]
		public string Loggin
		{
			get
			{
				return this._Loggin;
			}
			set
			{
				if ((this._Loggin != value))
				{
					this.OnLogginChanging(value);
					this.SendPropertyChanging();
					this._Loggin = value;
					this.SendPropertyChanged("Loggin");
					this.OnLogginChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Clave", DbType="VarChar(10)")]
		public string Clave
		{
			get
			{
				return this._Clave;
			}
			set
			{
				if ((this._Clave != value))
				{
					this.OnClaveChanging(value);
					this.SendPropertyChanging();
					this._Clave = value;
					this.SendPropertyChanged("Clave");
					this.OnClaveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tipo", DbType="VarChar(40)")]
		public string Tipo
		{
			get
			{
				return this._Tipo;
			}
			set
			{
				if ((this._Tipo != value))
				{
					this.OnTipoChanging(value);
					this.SendPropertyChanging();
					this._Tipo = value;
					this.SendPropertyChanged("Tipo");
					this.OnTipoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Cliente_Compra", Storage="_Compra", ThisKey="Cedula", OtherKey="Cedula")]
		public EntitySet<Compra> Compra
		{
			get
			{
				return this._Compra;
			}
			set
			{
				this._Compra.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Cliente_SueldoQuincena", Storage="_SueldoQuincena", ThisKey="Cedula", OtherKey="Cedula")]
		public EntitySet<SueldoQuincena> SueldoQuincena
		{
			get
			{
				return this._SueldoQuincena;
			}
			set
			{
				this._SueldoQuincena.Assign(value);
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
		
		private void attach_Compra(Compra entity)
		{
			this.SendPropertyChanging();
			entity.Cliente = this;
		}
		
		private void detach_Compra(Compra entity)
		{
			this.SendPropertyChanging();
			entity.Cliente = null;
		}
		
		private void attach_SueldoQuincena(SueldoQuincena entity)
		{
			this.SendPropertyChanging();
			entity.Cliente = this;
		}
		
		private void detach_SueldoQuincena(SueldoQuincena entity)
		{
			this.SendPropertyChanging();
			entity.Cliente = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Compra")]
	public partial class Compra : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idProducto;
		
		private int _Cedula;
		
		private string _NombreProducto;
		
		private string _Cantidad;
		
		private string _Decuento;
		
		private System.Nullable<int> _Precio;
		
		private string _Lugar;
		
		private System.DateTime _fecha_De_Compra;
		
		private string _Tipo_Producto;
		
		private string _Observaciones;
		
		private EntityRef<Cliente> _Cliente;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidProductoChanging(int value);
    partial void OnidProductoChanged();
    partial void OnCedulaChanging(int value);
    partial void OnCedulaChanged();
    partial void OnNombreProductoChanging(string value);
    partial void OnNombreProductoChanged();
    partial void OnCantidadChanging(string value);
    partial void OnCantidadChanged();
    partial void OnDecuentoChanging(string value);
    partial void OnDecuentoChanged();
    partial void OnPrecioChanging(System.Nullable<int> value);
    partial void OnPrecioChanged();
    partial void OnLugarChanging(string value);
    partial void OnLugarChanged();
    partial void Onfecha_De_CompraChanging(System.DateTime value);
    partial void Onfecha_De_CompraChanged();
    partial void OnTipo_ProductoChanging(string value);
    partial void OnTipo_ProductoChanged();
    partial void OnObservacionesChanging(string value);
    partial void OnObservacionesChanged();
    #endregion
		
		public Compra()
		{
			this._Cliente = default(EntityRef<Cliente>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idProducto", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int idProducto
		{
			get
			{
				return this._idProducto;
			}
			set
			{
				if ((this._idProducto != value))
				{
					this.OnidProductoChanging(value);
					this.SendPropertyChanging();
					this._idProducto = value;
					this.SendPropertyChanged("idProducto");
					this.OnidProductoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cedula", DbType="Int NOT NULL")]
		public int Cedula
		{
			get
			{
				return this._Cedula;
			}
			set
			{
				if ((this._Cedula != value))
				{
					if (this._Cliente.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCedulaChanging(value);
					this.SendPropertyChanging();
					this._Cedula = value;
					this.SendPropertyChanged("Cedula");
					this.OnCedulaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreProducto", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string NombreProducto
		{
			get
			{
				return this._NombreProducto;
			}
			set
			{
				if ((this._NombreProducto != value))
				{
					this.OnNombreProductoChanging(value);
					this.SendPropertyChanging();
					this._NombreProducto = value;
					this.SendPropertyChanged("NombreProducto");
					this.OnNombreProductoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cantidad", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Cantidad
		{
			get
			{
				return this._Cantidad;
			}
			set
			{
				if ((this._Cantidad != value))
				{
					this.OnCantidadChanging(value);
					this.SendPropertyChanging();
					this._Cantidad = value;
					this.SendPropertyChanged("Cantidad");
					this.OnCantidadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Decuento", DbType="VarChar(50)")]
		public string Decuento
		{
			get
			{
				return this._Decuento;
			}
			set
			{
				if ((this._Decuento != value))
				{
					this.OnDecuentoChanging(value);
					this.SendPropertyChanging();
					this._Decuento = value;
					this.SendPropertyChanged("Decuento");
					this.OnDecuentoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Precio", DbType="Int")]
		public System.Nullable<int> Precio
		{
			get
			{
				return this._Precio;
			}
			set
			{
				if ((this._Precio != value))
				{
					this.OnPrecioChanging(value);
					this.SendPropertyChanging();
					this._Precio = value;
					this.SendPropertyChanged("Precio");
					this.OnPrecioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Lugar", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Lugar
		{
			get
			{
				return this._Lugar;
			}
			set
			{
				if ((this._Lugar != value))
				{
					this.OnLugarChanging(value);
					this.SendPropertyChanging();
					this._Lugar = value;
					this.SendPropertyChanged("Lugar");
					this.OnLugarChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fecha_De_Compra", DbType="Date NOT NULL")]
		public System.DateTime fecha_De_Compra
		{
			get
			{
				return this._fecha_De_Compra;
			}
			set
			{
				if ((this._fecha_De_Compra != value))
				{
					this.Onfecha_De_CompraChanging(value);
					this.SendPropertyChanging();
					this._fecha_De_Compra = value;
					this.SendPropertyChanged("fecha_De_Compra");
					this.Onfecha_De_CompraChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tipo_Producto", DbType="VarChar(40)")]
		public string Tipo_Producto
		{
			get
			{
				return this._Tipo_Producto;
			}
			set
			{
				if ((this._Tipo_Producto != value))
				{
					this.OnTipo_ProductoChanging(value);
					this.SendPropertyChanging();
					this._Tipo_Producto = value;
					this.SendPropertyChanged("Tipo_Producto");
					this.OnTipo_ProductoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Observaciones", DbType="VarChar(80)")]
		public string Observaciones
		{
			get
			{
				return this._Observaciones;
			}
			set
			{
				if ((this._Observaciones != value))
				{
					this.OnObservacionesChanging(value);
					this.SendPropertyChanging();
					this._Observaciones = value;
					this.SendPropertyChanged("Observaciones");
					this.OnObservacionesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Cliente_Compra", Storage="_Cliente", ThisKey="Cedula", OtherKey="Cedula", IsForeignKey=true)]
		public Cliente Cliente
		{
			get
			{
				return this._Cliente.Entity;
			}
			set
			{
				Cliente previousValue = this._Cliente.Entity;
				if (((previousValue != value) 
							|| (this._Cliente.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Cliente.Entity = null;
						previousValue.Compra.Remove(this);
					}
					this._Cliente.Entity = value;
					if ((value != null))
					{
						value.Compra.Add(this);
						this._Cedula = value.Cedula;
					}
					else
					{
						this._Cedula = default(int);
					}
					this.SendPropertyChanged("Cliente");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SueldoQuincena")]
	public partial class SueldoQuincena : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IDQUINCENA;
		
		private int _Cedula;
		
		private int _Sueldo;
		
		private System.DateTime _fecha_De_Pago;
		
		private EntityRef<Cliente> _Cliente;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDQUINCENAChanging(int value);
    partial void OnIDQUINCENAChanged();
    partial void OnCedulaChanging(int value);
    partial void OnCedulaChanged();
    partial void OnSueldoChanging(int value);
    partial void OnSueldoChanged();
    partial void Onfecha_De_PagoChanging(System.DateTime value);
    partial void Onfecha_De_PagoChanged();
    #endregion
		
		public SueldoQuincena()
		{
			this._Cliente = default(EntityRef<Cliente>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDQUINCENA", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IDQUINCENA
		{
			get
			{
				return this._IDQUINCENA;
			}
			set
			{
				if ((this._IDQUINCENA != value))
				{
					this.OnIDQUINCENAChanging(value);
					this.SendPropertyChanging();
					this._IDQUINCENA = value;
					this.SendPropertyChanged("IDQUINCENA");
					this.OnIDQUINCENAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cedula", DbType="Int NOT NULL")]
		public int Cedula
		{
			get
			{
				return this._Cedula;
			}
			set
			{
				if ((this._Cedula != value))
				{
					if (this._Cliente.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCedulaChanging(value);
					this.SendPropertyChanging();
					this._Cedula = value;
					this.SendPropertyChanged("Cedula");
					this.OnCedulaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sueldo", DbType="Int NOT NULL")]
		public int Sueldo
		{
			get
			{
				return this._Sueldo;
			}
			set
			{
				if ((this._Sueldo != value))
				{
					this.OnSueldoChanging(value);
					this.SendPropertyChanging();
					this._Sueldo = value;
					this.SendPropertyChanged("Sueldo");
					this.OnSueldoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fecha_De_Pago", DbType="Date NOT NULL")]
		public System.DateTime fecha_De_Pago
		{
			get
			{
				return this._fecha_De_Pago;
			}
			set
			{
				if ((this._fecha_De_Pago != value))
				{
					this.Onfecha_De_PagoChanging(value);
					this.SendPropertyChanging();
					this._fecha_De_Pago = value;
					this.SendPropertyChanged("fecha_De_Pago");
					this.Onfecha_De_PagoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Cliente_SueldoQuincena", Storage="_Cliente", ThisKey="Cedula", OtherKey="Cedula", IsForeignKey=true)]
		public Cliente Cliente
		{
			get
			{
				return this._Cliente.Entity;
			}
			set
			{
				Cliente previousValue = this._Cliente.Entity;
				if (((previousValue != value) 
							|| (this._Cliente.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Cliente.Entity = null;
						previousValue.SueldoQuincena.Remove(this);
					}
					this._Cliente.Entity = value;
					if ((value != null))
					{
						value.SueldoQuincena.Add(this);
						this._Cedula = value.Cedula;
					}
					else
					{
						this._Cedula = default(int);
					}
					this.SendPropertyChanged("Cliente");
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
