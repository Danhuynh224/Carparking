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

namespace Carparking
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="UserData")]
	public partial class qlyticketDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTicketDb(TicketDb instance);
    partial void UpdateTicketDb(TicketDb instance);
    partial void DeleteTicketDb(TicketDb instance);
    #endregion
		
		public qlyticketDataContext() : 
				base(global::Carparking.Properties.Settings.Default.UserDataConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public qlyticketDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public qlyticketDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public qlyticketDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public qlyticketDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TicketDb> TicketDbs
		{
			get
			{
				return this.GetTable<TicketDb>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TicketDb")]
	public partial class TicketDb : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _TicketID;
		
		private int _UserID;
		
		private string _NameCustomer;
		
		private string _CarID;
		
		private string _Brand;
		
		private string _Color;
		
		private int _IDPark;
		
		private string _AreaPark;
		
		private System.DateTime _DateIn;
		
		private double _Price;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTicketIDChanging(int value);
    partial void OnTicketIDChanged();
    partial void OnUserIDChanging(int value);
    partial void OnUserIDChanged();
    partial void OnNameCustomerChanging(string value);
    partial void OnNameCustomerChanged();
    partial void OnCarIDChanging(string value);
    partial void OnCarIDChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnColorChanging(string value);
    partial void OnColorChanged();
    partial void OnIDParkChanging(int value);
    partial void OnIDParkChanged();
    partial void OnAreaParkChanging(string value);
    partial void OnAreaParkChanged();
    partial void OnDateInChanging(System.DateTime value);
    partial void OnDateInChanged();
    partial void OnPriceChanging(double value);
    partial void OnPriceChanged();
    #endregion
		
		public TicketDb()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TicketID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int TicketID
		{
			get
			{
				return this._TicketID;
			}
			set
			{
				if ((this._TicketID != value))
				{
					this.OnTicketIDChanging(value);
					this.SendPropertyChanging();
					this._TicketID = value;
					this.SendPropertyChanged("TicketID");
					this.OnTicketIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int NOT NULL")]
		public int UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NameCustomer", DbType="NVarChar(50)")]
		public string NameCustomer
		{
			get
			{
				return this._NameCustomer;
			}
			set
			{
				if ((this._NameCustomer != value))
				{
					this.OnNameCustomerChanging(value);
					this.SendPropertyChanging();
					this._NameCustomer = value;
					this.SendPropertyChanged("NameCustomer");
					this.OnNameCustomerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CarID", DbType="NVarChar(50)")]
		public string CarID
		{
			get
			{
				return this._CarID;
			}
			set
			{
				if ((this._CarID != value))
				{
					this.OnCarIDChanging(value);
					this.SendPropertyChanging();
					this._CarID = value;
					this.SendPropertyChanged("CarID");
					this.OnCarIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="NVarChar(50)")]
		public string Brand
		{
			get
			{
				return this._Brand;
			}
			set
			{
				if ((this._Brand != value))
				{
					this.OnBrandChanging(value);
					this.SendPropertyChanging();
					this._Brand = value;
					this.SendPropertyChanged("Brand");
					this.OnBrandChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Color", DbType="NVarChar(50)")]
		public string Color
		{
			get
			{
				return this._Color;
			}
			set
			{
				if ((this._Color != value))
				{
					this.OnColorChanging(value);
					this.SendPropertyChanging();
					this._Color = value;
					this.SendPropertyChanged("Color");
					this.OnColorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDPark", DbType="Int NOT NULL")]
		public int IDPark
		{
			get
			{
				return this._IDPark;
			}
			set
			{
				if ((this._IDPark != value))
				{
					this.OnIDParkChanging(value);
					this.SendPropertyChanging();
					this._IDPark = value;
					this.SendPropertyChanged("IDPark");
					this.OnIDParkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AreaPark", DbType="NVarChar(50)")]
		public string AreaPark
		{
			get
			{
				return this._AreaPark;
			}
			set
			{
				if ((this._AreaPark != value))
				{
					this.OnAreaParkChanging(value);
					this.SendPropertyChanging();
					this._AreaPark = value;
					this.SendPropertyChanged("AreaPark");
					this.OnAreaParkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateIn", DbType="DateTime NOT NULL")]
		public System.DateTime DateIn
		{
			get
			{
				return this._DateIn;
			}
			set
			{
				if ((this._DateIn != value))
				{
					this.OnDateInChanging(value);
					this.SendPropertyChanging();
					this._DateIn = value;
					this.SendPropertyChanged("DateIn");
					this.OnDateInChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Float NOT NULL")]
		public double Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
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
