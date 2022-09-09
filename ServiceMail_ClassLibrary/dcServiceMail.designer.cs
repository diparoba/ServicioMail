﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceMail_ClassLibrary
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ServicioEmail")]
	public partial class dcServiceMailDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDBO_SERVER(DBO_SERVER instance);
    partial void UpdateDBO_SERVER(DBO_SERVER instance);
    partial void DeleteDBO_SERVER(DBO_SERVER instance);
    #endregion
		
		public dcServiceMailDataContext() : 
				base(global::ServiceMail_ClassLibrary.Properties.Settings.Default.ServicioEmailConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public dcServiceMailDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dcServiceMailDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dcServiceMailDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dcServiceMailDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DBO_EMAIL> DBO_EMAILs
		{
			get
			{
				return this.GetTable<DBO_EMAIL>();
			}
		}
		
		public System.Data.Linq.Table<DBO_SERVER> DBO_SERVERs
		{
			get
			{
				return this.GetTable<DBO_SERVER>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DBO_EMAIL")]
	public partial class DBO_EMAIL
	{
		
		private int _ID;
		
		private System.Nullable<System.DateTime> _FECHA;
		
		private string _CORREO;
		
		private System.Nullable<bool> _STATUSSEND;
		
		private System.Nullable<bool> _STATUSERROR;
		
		private string _MESSAGEERROR;
		
		private System.Nullable<char> _STATUS;
		
		public DBO_EMAIL()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FECHA", DbType="Date")]
		public System.Nullable<System.DateTime> FECHA
		{
			get
			{
				return this._FECHA;
			}
			set
			{
				if ((this._FECHA != value))
				{
					this._FECHA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CORREO", DbType="VarChar(100)")]
		public string CORREO
		{
			get
			{
				return this._CORREO;
			}
			set
			{
				if ((this._CORREO != value))
				{
					this._CORREO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_STATUSSEND", DbType="Bit")]
		public System.Nullable<bool> STATUSSEND
		{
			get
			{
				return this._STATUSSEND;
			}
			set
			{
				if ((this._STATUSSEND != value))
				{
					this._STATUSSEND = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_STATUSERROR", DbType="Bit")]
		public System.Nullable<bool> STATUSERROR
		{
			get
			{
				return this._STATUSERROR;
			}
			set
			{
				if ((this._STATUSERROR != value))
				{
					this._STATUSERROR = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MESSAGEERROR", DbType="VarChar(200)")]
		public string MESSAGEERROR
		{
			get
			{
				return this._MESSAGEERROR;
			}
			set
			{
				if ((this._MESSAGEERROR != value))
				{
					this._MESSAGEERROR = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_STATUS", DbType="Char(1)")]
		public System.Nullable<char> STATUS
		{
			get
			{
				return this._STATUS;
			}
			set
			{
				if ((this._STATUS != value))
				{
					this._STATUS = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DBO_SERVER")]
	public partial class DBO_SERVER : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _SMTP;
		
		private string _USERNAME;
		
		private string _PASSWORD;
		
		private System.Nullable<int> _PORT;
		
		private System.Nullable<char> _STATUS;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnSMTPChanging(string value);
    partial void OnSMTPChanged();
    partial void OnUSERNAMEChanging(string value);
    partial void OnUSERNAMEChanged();
    partial void OnPASSWORDChanging(string value);
    partial void OnPASSWORDChanged();
    partial void OnPORTChanging(System.Nullable<int> value);
    partial void OnPORTChanged();
    partial void OnSTATUSChanging(System.Nullable<char> value);
    partial void OnSTATUSChanged();
    #endregion
		
		public DBO_SERVER()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SMTP", DbType="VarChar(200)")]
		public string SMTP
		{
			get
			{
				return this._SMTP;
			}
			set
			{
				if ((this._SMTP != value))
				{
					this.OnSMTPChanging(value);
					this.SendPropertyChanging();
					this._SMTP = value;
					this.SendPropertyChanged("SMTP");
					this.OnSMTPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_USERNAME", DbType="VarChar(150)")]
		public string USERNAME
		{
			get
			{
				return this._USERNAME;
			}
			set
			{
				if ((this._USERNAME != value))
				{
					this.OnUSERNAMEChanging(value);
					this.SendPropertyChanging();
					this._USERNAME = value;
					this.SendPropertyChanged("USERNAME");
					this.OnUSERNAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PASSWORD", DbType="VarChar(100)")]
		public string PASSWORD
		{
			get
			{
				return this._PASSWORD;
			}
			set
			{
				if ((this._PASSWORD != value))
				{
					this.OnPASSWORDChanging(value);
					this.SendPropertyChanging();
					this._PASSWORD = value;
					this.SendPropertyChanged("PASSWORD");
					this.OnPASSWORDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PORT", DbType="Int")]
		public System.Nullable<int> PORT
		{
			get
			{
				return this._PORT;
			}
			set
			{
				if ((this._PORT != value))
				{
					this.OnPORTChanging(value);
					this.SendPropertyChanging();
					this._PORT = value;
					this.SendPropertyChanged("PORT");
					this.OnPORTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_STATUS", DbType="Char(1)")]
		public System.Nullable<char> STATUS
		{
			get
			{
				return this._STATUS;
			}
			set
			{
				if ((this._STATUS != value))
				{
					this.OnSTATUSChanging(value);
					this.SendPropertyChanging();
					this._STATUS = value;
					this.SendPropertyChanged("STATUS");
					this.OnSTATUSChanged();
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