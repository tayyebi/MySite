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

namespace MyMVC.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MySite")]
	public partial class DcDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAdmin(Admin instance);
    partial void UpdateAdmin(Admin instance);
    partial void DeleteAdmin(Admin instance);
    partial void InsertGroup(Group instance);
    partial void UpdateGroup(Group instance);
    partial void DeleteGroup(Group instance);
    partial void InsertPost(Post instance);
    partial void UpdatePost(Post instance);
    partial void DeletePost(Post instance);
    #endregion
		
		public DcDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["MySiteConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DcDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DcDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DcDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DcDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Admin> Admins
		{
			get
			{
				return this.GetTable<Admin>();
			}
		}
		
		public System.Data.Linq.Table<Group> Groups
		{
			get
			{
				return this.GetTable<Group>();
			}
		}
		
		public System.Data.Linq.Table<Post> Posts
		{
			get
			{
				return this.GetTable<Post>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Login")]
		public ISingleResult<LoginResult> Login([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Username", DbType="NVarChar(50)")] string username, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Password", DbType="NVarChar(300)")] string password)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), username, password);
			return ((ISingleResult<LoginResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AdminDeleteCommand")]
		public int AdminDeleteCommand([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Original_Username", DbType="NVarChar(50)")] string original_Username)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), original_Username);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AdminInsertCommand")]
		public ISingleResult<AdminInsertCommandResult> AdminInsertCommand([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Username", DbType="NVarChar(50)")] string username, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Password", DbType="NVarChar(300)")] string password, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Fullname", DbType="NVarChar(500)")] string fullname)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), username, password, fullname);
			return ((ISingleResult<AdminInsertCommandResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AdminSelectCommand")]
		public ISingleResult<AdminSelectCommandResult> AdminSelectCommand()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<AdminSelectCommandResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AdminUpdateCommand")]
		public ISingleResult<AdminUpdateCommandResult> AdminUpdateCommand([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Username", DbType="NVarChar(50)")] string username, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Password", DbType="NVarChar(300)")] string password, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Fullname", DbType="NVarChar(500)")] string fullname, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Original_Username", DbType="NVarChar(50)")] string original_Username)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), username, password, fullname, original_Username);
			return ((ISingleResult<AdminUpdateCommandResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GroupDeleteCommand")]
		public int GroupDeleteCommand([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Original_Id", DbType="UniqueIdentifier")] System.Nullable<System.Guid> original_Id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), original_Id);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GroupInsertCommand")]
		public ISingleResult<GroupInsertCommandResult> GroupInsertCommand([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="UniqueIdentifier")] System.Nullable<System.Guid> id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Title", DbType="NVarChar(50)")] string title)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, title);
			return ((ISingleResult<GroupInsertCommandResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GroupSelectCommand")]
		public ISingleResult<GroupSelectCommandResult> GroupSelectCommand()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<GroupSelectCommandResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GroupUpdateCommand")]
		public ISingleResult<GroupUpdateCommandResult> GroupUpdateCommand([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="UniqueIdentifier")] System.Nullable<System.Guid> id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Title", DbType="NVarChar(50)")] string title, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Original_Id", DbType="UniqueIdentifier")] System.Nullable<System.Guid> original_Id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, title, original_Id);
			return ((ISingleResult<GroupUpdateCommandResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.PostDeleteCommand")]
		public int PostDeleteCommand([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Original_Id", DbType="Int")] System.Nullable<int> original_Id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), original_Id);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.PostInsertCommand")]
		public ISingleResult<PostInsertCommandResult> PostInsertCommand([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Title", DbType="NVarChar(100)")] string title, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Date", DbType="DateTime")] System.Nullable<System.DateTime> date, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Abstract", DbType="NVarChar(3000)")] string @abstract, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Body", DbType="NVarChar(MAX)")] string body, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="AdminUsername", DbType="NVarChar(50)")] string adminUsername, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="GroupId", DbType="UniqueIdentifier")] System.Nullable<System.Guid> groupId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), title, date, @abstract, body, adminUsername, groupId);
			return ((ISingleResult<PostInsertCommandResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.PostSelectCommand")]
		public ISingleResult<PostSelectCommandResult> PostSelectCommand()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<PostSelectCommandResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.PostUpdateCommand")]
		public ISingleResult<PostUpdateCommandResult> PostUpdateCommand([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Title", DbType="NVarChar(100)")] string title, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Date", DbType="DateTime")] System.Nullable<System.DateTime> date, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Abstract", DbType="NVarChar(3000)")] string @abstract, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Body", DbType="NVarChar(MAX)")] string body, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="AdminUsername", DbType="NVarChar(50)")] string adminUsername, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="GroupId", DbType="UniqueIdentifier")] System.Nullable<System.Guid> groupId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Original_Id", DbType="Int")] System.Nullable<int> original_Id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="Int")] System.Nullable<int> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), title, date, @abstract, body, adminUsername, groupId, original_Id, id);
			return ((ISingleResult<PostUpdateCommandResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Admin")]
	public partial class Admin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Username;
		
		private string _Password;
		
		private string _Fullname;
		
		private EntitySet<Post> _Posts;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnFullnameChanging(string value);
    partial void OnFullnameChanged();
    #endregion
		
		public Admin()
		{
			this._Posts = new EntitySet<Post>(new Action<Post>(this.attach_Posts), new Action<Post>(this.detach_Posts));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(300) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fullname", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string Fullname
		{
			get
			{
				return this._Fullname;
			}
			set
			{
				if ((this._Fullname != value))
				{
					this.OnFullnameChanging(value);
					this.SendPropertyChanging();
					this._Fullname = value;
					this.SendPropertyChanged("Fullname");
					this.OnFullnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Admin_Post", Storage="_Posts", ThisKey="Username", OtherKey="AdminUsername")]
		public EntitySet<Post> Posts
		{
			get
			{
				return this._Posts;
			}
			set
			{
				this._Posts.Assign(value);
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
		
		private void attach_Posts(Post entity)
		{
			this.SendPropertyChanging();
			entity.Admin = this;
		}
		
		private void detach_Posts(Post entity)
		{
			this.SendPropertyChanging();
			entity.Admin = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Group]")]
	public partial class Group : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _Id;
		
		private string _Title;
		
		private EntitySet<Post> _Posts;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(System.Guid value);
    partial void OnIdChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    #endregion
		
		public Group()
		{
			this._Posts = new EntitySet<Post>(new Action<Post>(this.attach_Posts), new Action<Post>(this.detach_Posts));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid Id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Group_Post", Storage="_Posts", ThisKey="Id", OtherKey="GroupId")]
		public EntitySet<Post> Posts
		{
			get
			{
				return this._Posts;
			}
			set
			{
				this._Posts.Assign(value);
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
		
		private void attach_Posts(Post entity)
		{
			this.SendPropertyChanging();
			entity.Group = this;
		}
		
		private void detach_Posts(Post entity)
		{
			this.SendPropertyChanging();
			entity.Group = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Post")]
	public partial class Post : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Title;
		
		private System.DateTime _Date;
		
		private string _Abstract;
		
		private string _Body;
		
		private string _AdminUsername;
		
		private System.Guid _GroupId;
		
		private EntityRef<Admin> _Admin;
		
		private EntityRef<Group> _Group;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnDateChanging(System.DateTime value);
    partial void OnDateChanged();
    partial void OnAbstractChanging(string value);
    partial void OnAbstractChanged();
    partial void OnBodyChanging(string value);
    partial void OnBodyChanged();
    partial void OnAdminUsernameChanging(string value);
    partial void OnAdminUsernameChanged();
    partial void OnGroupIdChanging(System.Guid value);
    partial void OnGroupIdChanged();
    #endregion
		
		public Post()
		{
			this._Admin = default(EntityRef<Admin>);
			this._Group = default(EntityRef<Group>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="DateTime NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Abstract", DbType="NVarChar(3000)")]
		public string Abstract
		{
			get
			{
				return this._Abstract;
			}
			set
			{
				if ((this._Abstract != value))
				{
					this.OnAbstractChanging(value);
					this.SendPropertyChanging();
					this._Abstract = value;
					this.SendPropertyChanged("Abstract");
					this.OnAbstractChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Body", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Body
		{
			get
			{
				return this._Body;
			}
			set
			{
				if ((this._Body != value))
				{
					this.OnBodyChanging(value);
					this.SendPropertyChanging();
					this._Body = value;
					this.SendPropertyChanged("Body");
					this.OnBodyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdminUsername", DbType="NVarChar(50)")]
		public string AdminUsername
		{
			get
			{
				return this._AdminUsername;
			}
			set
			{
				if ((this._AdminUsername != value))
				{
					if (this._Admin.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAdminUsernameChanging(value);
					this.SendPropertyChanging();
					this._AdminUsername = value;
					this.SendPropertyChanged("AdminUsername");
					this.OnAdminUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GroupId", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid GroupId
		{
			get
			{
				return this._GroupId;
			}
			set
			{
				if ((this._GroupId != value))
				{
					if (this._Group.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnGroupIdChanging(value);
					this.SendPropertyChanging();
					this._GroupId = value;
					this.SendPropertyChanged("GroupId");
					this.OnGroupIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Admin_Post", Storage="_Admin", ThisKey="AdminUsername", OtherKey="Username", IsForeignKey=true)]
		public Admin Admin
		{
			get
			{
				return this._Admin.Entity;
			}
			set
			{
				Admin previousValue = this._Admin.Entity;
				if (((previousValue != value) 
							|| (this._Admin.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Admin.Entity = null;
						previousValue.Posts.Remove(this);
					}
					this._Admin.Entity = value;
					if ((value != null))
					{
						value.Posts.Add(this);
						this._AdminUsername = value.Username;
					}
					else
					{
						this._AdminUsername = default(string);
					}
					this.SendPropertyChanged("Admin");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Group_Post", Storage="_Group", ThisKey="GroupId", OtherKey="Id", IsForeignKey=true)]
		public Group Group
		{
			get
			{
				return this._Group.Entity;
			}
			set
			{
				Group previousValue = this._Group.Entity;
				if (((previousValue != value) 
							|| (this._Group.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Group.Entity = null;
						previousValue.Posts.Remove(this);
					}
					this._Group.Entity = value;
					if ((value != null))
					{
						value.Posts.Add(this);
						this._GroupId = value.Id;
					}
					else
					{
						this._GroupId = default(System.Guid);
					}
					this.SendPropertyChanged("Group");
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
	
	public partial class LoginResult
	{
		
		private string _Response;
		
		public LoginResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Response", DbType="VarChar(7) NOT NULL", CanBeNull=false)]
		public string Response
		{
			get
			{
				return this._Response;
			}
			set
			{
				if ((this._Response != value))
				{
					this._Response = value;
				}
			}
		}
	}
	
	public partial class AdminInsertCommandResult
	{
		
		private string _Username;
		
		private string _Password;
		
		private string _Fullname;
		
		public AdminInsertCommandResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this._Username = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(300) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this._Password = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fullname", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string Fullname
		{
			get
			{
				return this._Fullname;
			}
			set
			{
				if ((this._Fullname != value))
				{
					this._Fullname = value;
				}
			}
		}
	}
	
	public partial class AdminSelectCommandResult
	{
		
		private string _Username;
		
		private string _Password;
		
		private string _Fullname;
		
		public AdminSelectCommandResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this._Username = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(300) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this._Password = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fullname", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string Fullname
		{
			get
			{
				return this._Fullname;
			}
			set
			{
				if ((this._Fullname != value))
				{
					this._Fullname = value;
				}
			}
		}
	}
	
	public partial class AdminUpdateCommandResult
	{
		
		private string _Username;
		
		private string _Password;
		
		private string _Fullname;
		
		public AdminUpdateCommandResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this._Username = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(300) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this._Password = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fullname", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string Fullname
		{
			get
			{
				return this._Fullname;
			}
			set
			{
				if ((this._Fullname != value))
				{
					this._Fullname = value;
				}
			}
		}
	}
	
	public partial class GroupInsertCommandResult
	{
		
		private System.Guid _Id;
		
		private string _Title;
		
		public GroupInsertCommandResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this._Title = value;
				}
			}
		}
	}
	
	public partial class GroupSelectCommandResult
	{
		
		private System.Guid _Id;
		
		private string _Title;
		
		public GroupSelectCommandResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this._Title = value;
				}
			}
		}
	}
	
	public partial class GroupUpdateCommandResult
	{
		
		private System.Guid _Id;
		
		private string _Title;
		
		public GroupUpdateCommandResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this._Title = value;
				}
			}
		}
	}
	
	public partial class PostInsertCommandResult
	{
		
		private int _Id;
		
		private string _Title;
		
		private System.DateTime _Date;
		
		private string _Abstract;
		
		private string _Body;
		
		private string _AdminUsername;
		
		private System.Guid _GroupId;
		
		public PostInsertCommandResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL")]
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
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this._Title = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="DateTime NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this._Date = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Abstract", DbType="NVarChar(3000)")]
		public string Abstract
		{
			get
			{
				return this._Abstract;
			}
			set
			{
				if ((this._Abstract != value))
				{
					this._Abstract = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Body", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Body
		{
			get
			{
				return this._Body;
			}
			set
			{
				if ((this._Body != value))
				{
					this._Body = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdminUsername", DbType="NVarChar(50)")]
		public string AdminUsername
		{
			get
			{
				return this._AdminUsername;
			}
			set
			{
				if ((this._AdminUsername != value))
				{
					this._AdminUsername = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GroupId", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid GroupId
		{
			get
			{
				return this._GroupId;
			}
			set
			{
				if ((this._GroupId != value))
				{
					this._GroupId = value;
				}
			}
		}
	}
	
	public partial class PostSelectCommandResult
	{
		
		private int _Id;
		
		private string _Title;
		
		private System.DateTime _Date;
		
		private string _Abstract;
		
		private string _Body;
		
		private string _AdminUsername;
		
		private System.Guid _GroupId;
		
		public PostSelectCommandResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL")]
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
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this._Title = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="DateTime NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this._Date = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Abstract", DbType="NVarChar(3000)")]
		public string Abstract
		{
			get
			{
				return this._Abstract;
			}
			set
			{
				if ((this._Abstract != value))
				{
					this._Abstract = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Body", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Body
		{
			get
			{
				return this._Body;
			}
			set
			{
				if ((this._Body != value))
				{
					this._Body = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdminUsername", DbType="NVarChar(50)")]
		public string AdminUsername
		{
			get
			{
				return this._AdminUsername;
			}
			set
			{
				if ((this._AdminUsername != value))
				{
					this._AdminUsername = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GroupId", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid GroupId
		{
			get
			{
				return this._GroupId;
			}
			set
			{
				if ((this._GroupId != value))
				{
					this._GroupId = value;
				}
			}
		}
	}
	
	public partial class PostUpdateCommandResult
	{
		
		private int _Id;
		
		private string _Title;
		
		private System.DateTime _Date;
		
		private string _Abstract;
		
		private string _Body;
		
		private string _AdminUsername;
		
		private System.Guid _GroupId;
		
		public PostUpdateCommandResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL")]
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
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this._Title = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="DateTime NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this._Date = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Abstract", DbType="NVarChar(3000)")]
		public string Abstract
		{
			get
			{
				return this._Abstract;
			}
			set
			{
				if ((this._Abstract != value))
				{
					this._Abstract = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Body", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Body
		{
			get
			{
				return this._Body;
			}
			set
			{
				if ((this._Body != value))
				{
					this._Body = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdminUsername", DbType="NVarChar(50)")]
		public string AdminUsername
		{
			get
			{
				return this._AdminUsername;
			}
			set
			{
				if ((this._AdminUsername != value))
				{
					this._AdminUsername = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GroupId", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid GroupId
		{
			get
			{
				return this._GroupId;
			}
			set
			{
				if ((this._GroupId != value))
				{
					this._GroupId = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
