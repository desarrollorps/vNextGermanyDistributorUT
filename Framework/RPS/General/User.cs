    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.User
{
    //RPS VERSION 1.0.0.0
    public partial class User:Screen
    {
        public User():base()
        {
            this.URL = "general.user";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            UserCollectionView  = new UserCollectionView(this); 
            UserEntityView  = new UserEntityView(this); 
            UserCollectionView.InitializeControls(); 
            UserEntityView.InitializeControls(); 
           
        }
      
            public UserCollectionView UserCollectionView {get; set; } 
            public UserEntityView UserEntityView {get; set; } 
    }
            
    public partial class UserCollectionView : View
    {
        public UserCollectionView(User screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<UserCollectionView,UserEntityView>( this,Screen.UserEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "2a4a5ea7-680d-4188-86bd-356d4c54aac2",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<UserCollectionView,UserEntityView>( params_MainConsult,this,Screen.UserEntityView);
 

        }
        public IRPSButton<UserCollectionView,UserEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<UserCollectionView,UserEntityView> MainConsult { get; set; } 
        public User Screen { get; set; }
        public UserCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class UserEntityView : View
    {
        public UserEntityView(User screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<UserEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<UserEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<UserEntityView,UserCollectionView>( this,Screen.UserCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<UserEntityView,UserCollectionView>( this,Screen.UserCollectionView);
 
            CodUser = RPSControlFactory.CreateRPSTextBox<UserEntityView>("3022482a-aff9-43d9-8a35-6c37f7326270","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<UserEntityView>("8f62c315-93e1-4242-84b2-d4a2749462c8","","",true, this);
 
            UIBlockedUser = RPSControlFactory.CreateRPSTextBox<UserEntityView>("9e9e9443-33a4-478b-b79c-668347eb5da4","","",false, this);
 
            Password = RPSControlFactory.CreateRPSTextBox<UserEntityView>("1c8fbd24-37bc-412a-8132-c0c91696b85c","","",false, this);
 
            ConfirmPassword = RPSControlFactory.CreateRPSTextBox<UserEntityView>("b46948c3-411c-4bd1-8952-c5dc3a2f0c7c","","",false, this);
 
            PolicyPassword = RPSControlFactory.CreateRPSCheckBox<UserEntityView>("53fd1380-6c0e-4dac-9d42-31fcb22b9cee","","",true, this);
 
            ExpirationPassword = RPSControlFactory.CreateRPSCheckBox<UserEntityView>("65d2606c-321b-4bbc-8cc0-5f9654512a0d","","",true, this);
 
            WindowsIdentity = RPSControlFactory.CreateRPSTextBox<UserEntityView>("234abf65-d62d-4710-a3f0-9bf4273ebbdd","","",false, this);
 
            ExpirationDatePassword = RPSControlFactory.CreateRPSTextBox<UserEntityView>("94a8393f-8fc1-450a-bfa8-e7832b08ed4d","","",false, this);
 
            Email = RPSControlFactory.CreateRPSEmailTextBox<UserEntityView>("115886e0-296b-4222-8f6d-02e15254e9b7","","",false, this);
 
            InactivateDate = RPSControlFactory.CreateRPSTextBox<UserEntityView>("882b6867-5eb1-4b44-91ae-87188d901557","","",false, this);
 
            CodRole = RPSControlFactory.CreateRPSComboBox<UserEntityView>("34dcaf0f-666b-4206-85ab-95ff98d65fa2","","",true, this);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<UserEntityView>("536bd1c9-fb29-4c14-ab4b-c1c8899e0003","","",true, this);
 
            CodCompany = RPSControlFactory.CreateRPSComboBox<UserEntityView>("5f4d10f7-4442-44b8-802f-dce0aae3cc88","","",true, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<UserEntityView>("059e1955-71ba-427c-ad4f-d56c81e08a85","","",false, this);
 
            ConfigCommonAllCompanies = RPSControlFactory.CreateRPSCheckBox<UserEntityView>("99d78e98-f722-417f-a484-3c239e2c59ae","","",true, this);
 
            AllowChangeAccType = RPSControlFactory.CreateRPSCheckBox<UserEntityView>("1fa42fc7-9a8c-41d4-925b-7b2af371817c","","",true, this);
 
            DenyExportGrid = RPSControlFactory.CreateRPSCheckBox<UserEntityView>("68749c84-1ae9-4b3c-bd46-659ac3151ef1","","",true, this);
 
            DenyConfGrid = RPSControlFactory.CreateRPSCheckBox<UserEntityView>("8d1ceb31-9699-4f1c-ad5e-45a4216d700c","","",true, this);
 
            RoleCommercialAgent = RPSControlFactory.CreateRPSCheckBox<UserEntityView>("c87554cf-e5f9-4f4d-a480-8e9e9f0e37e1","","",true, this);
 
            RoleEmployee = RPSControlFactory.CreateRPSCheckBox<UserEntityView>("348eb324-5c67-4afa-a313-6f99b96db87d","","",true, this);
 
            RoleCustomer = RPSControlFactory.CreateRPSCheckBox<UserEntityView>("921fa977-2944-41a8-917d-27909803a645","","",true, this);
 
            RoleSupplier = RPSControlFactory.CreateRPSCheckBox<UserEntityView>("06feaa82-79ae-47b9-972a-7f50c12529df","","",true, this);
 
            RoleAdministrator = RPSControlFactory.CreateRPSCheckBox<UserEntityView>("c60b8208-c4fa-41c3-8d67-1a8f83e11177","","",true, this);
 
            RoleAdministratorProject = RPSControlFactory.CreateRPSCheckBox<UserEntityView>("5dd96ec3-8313-4871-b36f-5bae695be47c","","",true, this);
 
            RoleAdministratorPurchase = RPSControlFactory.CreateRPSCheckBox<UserEntityView>("c7bdff26-accd-4de0-a36a-b9aff17ca6ab","","",true, this);
 
            RoleAdministratorSales = RPSControlFactory.CreateRPSCheckBox<UserEntityView>("af553205-8260-4932-a366-fa05ed5e8fe1","","",true, this);
 
            RoleAdministratorManufacturing = RPSControlFactory.CreateRPSCheckBox<UserEntityView>("ffd3d31d-27fa-4c4c-9fc3-26f922cc0c70","","",true, this);
 
            RoleAdministratorStructure = RPSControlFactory.CreateRPSCheckBox<UserEntityView>("6c34cc4b-d446-4967-951b-c51eb8967783","","",true, this);
 
            RoleAdministratorAPQDefinition = RPSControlFactory.CreateRPSCheckBox<UserEntityView>("35ecb944-dd33-4c2f-a7ff-5ad22d5fb94e","","",true, this);
 
            RoleAdministratorAPQRegister = RPSControlFactory.CreateRPSCheckBox<UserEntityView>("3175f623-1a34-4c6c-819b-8a76810eac01","","",true, this);
 
            RoleAdministratorMaintenance = RPSControlFactory.CreateRPSCheckBox<UserEntityView>("034de86b-0c5b-41a9-af81-602e8ab3b156","","",true, this);
 
            RoleAdministratorBI = RPSControlFactory.CreateRPSCheckBox<UserEntityView>("e02035a7-8618-49b0-8dea-4c69b2aa0236","","",true, this);
 
            RoleAdministratorTRA = RPSControlFactory.CreateRPSCheckBox<UserEntityView>("2e2521aa-9407-496e-b89d-7770f84028b8","","",true, this);
 
            RoleAgentType = RPSControlFactory.CreateRPSEnumComboBox<UserEntityView>("79a514c6-dbf9-4398-9a53-b929f2cde3cd","","",true, this);
 
            UserType = RPSControlFactory.CreateRPSEnumComboBox<UserEntityView>("441c2fc2-5b44-4542-908d-e9a86e6f683c","","",true, this);
 
            AuthorizationType = RPSControlFactory.CreateRPSEnumComboBox<UserEntityView>("b9fb97f4-f900-4cf4-9d3e-4c277613535f","","",true, this);
 
            Filter = RPSControlFactory.CreateRPSTextBox<UserEntityView>("c3f71e0c-0c9a-4732-baf1-da97df8ca15e","","",false, this);
 
            AddAllPrivilegesButton = RPSControlFactory.CreateRPSButton<UserEntityView>( "1174a96e-58c7-4ff1-9d8a-25ddefd8ee02","","",this);
 
            RemoveAllPrivilegesButton = RPSControlFactory.CreateRPSButton<UserEntityView>( "b22c2c0b-f6c4-411c-8bee-a6b88a820fe3","","",this);
 
            All = RPSControlFactory.CreateRPSOption<UserEntityView>( "01a259ea-8baf-4c2a-a2fb-e3548e174229","","",this);
 
            Restrict = RPSControlFactory.CreateRPSOption<UserEntityView>( "63c879d1-af28-47da-96fb-08ce0786b782","","",this);
 
            RestrictToUserCompanies = RPSControlFactory.CreateRPSCheckBox<UserEntityView>("5ce2e1be-5c9c-4dfa-b5e7-0bff6f8de4bd","","",true, this);
 
            IDMachine = RPSControlFactory.CreateRPSComboBox<UserEntityView>("acd23c15-4a8c-4bcc-b865-07b3594db945","","",false, this);
 
            ExecuteUnlockUserButton = RPSControlFactory.CreateRPSButton<UserEntityView>( "785bf2a7-f3b0-4c08-9c38-46585890669f","","",this);
 
            CollectionInit params_UserPrivilege = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="55b2175d-8f3d-45d2-add2-b7547b9ea3cc",CSSSelectorGrid="",XPathGrid=""};
            UserPrivilege = RPSControlFactory.RPSCreateCollectionWithGrid<UserPrivilegeCollectionEditor<UserEntityView>,UserEntityView>( params_UserPrivilege,this);
 
            CollectionInit params_UserCompanys = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="cc5d8632-d5bf-4d81-9a5d-d82611026644",CSSSelectorGrid="",XPathGrid=""};
            UserCompanys = RPSControlFactory.RPSCreateCollectionWithGrid<UserCompanysCollectionEditor<UserEntityView>,UserEntityView>( params_UserCompanys,this);
 
            CollectionInit params_UserInvoicingPoints = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="77bdb3d4-df4c-464c-bb3c-6dda5b5196d9",CSSSelectorGrid="",XPathGrid=""};
            UserInvoicingPoints = RPSControlFactory.RPSCreateCollectionWithGrid<UserInvoicingPointsCollectionEditor<UserEntityView>,UserEntityView>( params_UserInvoicingPoints,this);
 
            CollectionInit params_UserBusinessUnits = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="efc401ca-287e-47dd-bb41-47bda47843fe",CSSSelectorGrid="",XPathGrid=""};
            UserBusinessUnits = RPSControlFactory.RPSCreateCollectionWithGrid<UserBusinessUnitsCollectionEditor<UserEntityView>,UserEntityView>( params_UserBusinessUnits,this);
 
            General = RPSControlFactory.CreateRPSSection<UserEntityView>( "","ul li[rpsid='473f8042-7fff-4815-b2cf-6a6ec9702e5c']","",this);
 
            Role = RPSControlFactory.CreateRPSSection<UserEntityView>( "","ul li[rpsid='492b6b51-aa7e-422d-b638-27235cfc0ef8']","",this);
 
            Authorization = RPSControlFactory.CreateRPSSection<UserEntityView>( "","ul li[rpsid='686ae7fb-3540-4981-8bef-43d20431eccf']","",this);
 
            Companies = RPSControlFactory.CreateRPSSection<UserEntityView>( "","ul li[rpsid='dc0e0954-a6ae-4cfe-a6d0-1c737d41fc7c']","",this);
 
            InvoicingPoints = RPSControlFactory.CreateRPSSection<UserEntityView>( "","ul li[rpsid='e6f72c57-e88b-45ed-ba7d-7e8c36954677']","",this);
 
            BusinessUnits = RPSControlFactory.CreateRPSSection<UserEntityView>( "","ul li[rpsid='9f765491-46e2-4fb4-b007-d258126cf59e']","",this);
 
            DPSSection = RPSControlFactory.CreateRPSSection<UserEntityView>( "","ul li[rpsid='985a3204-a5ac-4a17-8ebe-1a0d04f4669b']","",this);
 

        }
        public IRPSSaveButton<UserEntityView> SaveButton { get; set; } 
        public IRPSButton<UserEntityView> DeleteButton { get; set; } 
        public IRPSButton<UserEntityView,UserCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<UserEntityView,UserCollectionView> BackButton { get; set; } 
        public IRPSTextBox<UserEntityView> CodUser { get; set; } 
        public IRPSTextBox<UserEntityView> Description { get; set; } 
        public IRPSTextBox<UserEntityView> UIBlockedUser { get; set; } 
        public IRPSTextBox<UserEntityView> Password { get; set; } 
        public IRPSTextBox<UserEntityView> ConfirmPassword { get; set; } 
        public IRPSCheckbox<UserEntityView> PolicyPassword { get; set; } 
        public IRPSCheckbox<UserEntityView> ExpirationPassword { get; set; } 
        public IRPSTextBox<UserEntityView> WindowsIdentity { get; set; } 
        public IRPSTextBox<UserEntityView> ExpirationDatePassword { get; set; } 
        public IRPSTextBox<UserEntityView> Email { get; set; } 
        public IRPSTextBox<UserEntityView> InactivateDate { get; set; } 
        public IRPSComboBox<UserEntityView> CodRole { get; set; } 
        public IRPSComboBox<UserEntityView> CodLanguage { get; set; } 
        public IRPSComboBox<UserEntityView> CodCompany { get; set; } 
        public IRPSComboBox<UserEntityView> IDSite { get; set; } 
        public IRPSCheckbox<UserEntityView> ConfigCommonAllCompanies { get; set; } 
        public IRPSCheckbox<UserEntityView> AllowChangeAccType { get; set; } 
        public IRPSCheckbox<UserEntityView> DenyExportGrid { get; set; } 
        public IRPSCheckbox<UserEntityView> DenyConfGrid { get; set; } 
        public IRPSCheckbox<UserEntityView> RoleCommercialAgent { get; set; } 
        public IRPSCheckbox<UserEntityView> RoleEmployee { get; set; } 
        public IRPSCheckbox<UserEntityView> RoleCustomer { get; set; } 
        public IRPSCheckbox<UserEntityView> RoleSupplier { get; set; } 
        public IRPSCheckbox<UserEntityView> RoleAdministrator { get; set; } 
        public IRPSCheckbox<UserEntityView> RoleAdministratorProject { get; set; } 
        public IRPSCheckbox<UserEntityView> RoleAdministratorPurchase { get; set; } 
        public IRPSCheckbox<UserEntityView> RoleAdministratorSales { get; set; } 
        public IRPSCheckbox<UserEntityView> RoleAdministratorManufacturing { get; set; } 
        public IRPSCheckbox<UserEntityView> RoleAdministratorStructure { get; set; } 
        public IRPSCheckbox<UserEntityView> RoleAdministratorAPQDefinition { get; set; } 
        public IRPSCheckbox<UserEntityView> RoleAdministratorAPQRegister { get; set; } 
        public IRPSCheckbox<UserEntityView> RoleAdministratorMaintenance { get; set; } 
        public IRPSCheckbox<UserEntityView> RoleAdministratorBI { get; set; } 
        public IRPSCheckbox<UserEntityView> RoleAdministratorTRA { get; set; } 
        public IRPSComboBox<UserEntityView> RoleAgentType { get; set; } 
        public IRPSComboBox<UserEntityView> UserType { get; set; } 
        public IRPSComboBox<UserEntityView> AuthorizationType { get; set; } 
        public IRPSTextBox<UserEntityView> Filter { get; set; } 
        public IRPSButton<UserEntityView> AddAllPrivilegesButton { get; set; } 
        public IRPSButton<UserEntityView> RemoveAllPrivilegesButton { get; set; } 
        public IRPSOption<UserEntityView> All { get; set; } 
        public IRPSOption<UserEntityView> Restrict { get; set; } 
        public IRPSCheckbox<UserEntityView> RestrictToUserCompanies { get; set; } 
        public IRPSComboBox<UserEntityView> IDMachine { get; set; } 
        public IRPSButton<UserEntityView> ExecuteUnlockUserButton { get; set; } 
        public UserPrivilegeCollectionEditor<UserEntityView> UserPrivilege { get; set; } 
        public UserCompanysCollectionEditor<UserEntityView> UserCompanys { get; set; } 
        public UserInvoicingPointsCollectionEditor<UserEntityView> UserInvoicingPoints { get; set; } 
        public UserBusinessUnitsCollectionEditor<UserEntityView> UserBusinessUnits { get; set; } 
        public IRPSSection<UserEntityView> General { get; set; } 
        public IRPSSection<UserEntityView> Role { get; set; } 
        public IRPSSection<UserEntityView> Authorization { get; set; } 
        public IRPSSection<UserEntityView> Companies { get; set; } 
        public IRPSSection<UserEntityView> InvoicingPoints { get; set; } 
        public IRPSSection<UserEntityView> BusinessUnits { get; set; } 
        public IRPSSection<UserEntityView> DPSSection { get; set; } 
        public User Screen { get; set; }
        public UserEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class UserPrivilegeCollectionEditor<UserEntityView>:RPSCollectionEditor<UserEntityView> where UserEntityView : class, IView
    {
        public  UserPrivilegeGridView<UserEntityView> GridView {get;set;}
    }
    public partial class UserPrivilegeGridView <UserEntityView> :  RPSGridView<UserEntityView> where UserEntityView : class, IView
    {
        public UserPrivilegeGridView(UserEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Check = RPSControlFactory.CreateRPSGridCheckBox<UserEntityView>("","#55b2175d-8f3d-45d2-add2-b7547b9ea3cc .ag-row[role='row']@ROWINDEX [col-id='cCheck']","",false, this.CurrentView);
 
            Privilege = RPSControlFactory.CreateRPSGridTextBox<UserEntityView>("","#55b2175d-8f3d-45d2-add2-b7547b9ea3cc .ag-row[role='row']@ROWINDEX [col-id='cPrivilege']","",false, this.CurrentView);
 

        }
        public IRPSGridCheckbox<UserEntityView> Check { get; set; } 
        public IRPSGridTextBox<UserEntityView> Privilege { get; set; } 
                     
    }
 
        public partial class UserCompanysCollectionEditor<UserEntityView>:RPSCollectionEditor<UserEntityView> where UserEntityView : class, IView
    {
        public  UserCompanysGridView<UserEntityView> GridView {get;set;}
    }
    public partial class UserCompanysGridView <UserEntityView> :  RPSGridView<UserEntityView> where UserEntityView : class, IView
    {
        public UserCompanysGridView(UserEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodCompany = RPSControlFactory.CreateRPSGridComboBox<UserEntityView>("","#cc5d8632-d5bf-4d81-9a5d-d82611026644 .ag-row[role='row']@ROWINDEX [col-id='cCodCompany']","",true, this.CurrentView);
 
            IDSite = RPSControlFactory.CreateRPSGridComboBox<UserEntityView>("","#cc5d8632-d5bf-4d81-9a5d-d82611026644 .ag-row[role='row']@ROWINDEX [col-id='cIDSite']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<UserEntityView> CodCompany { get; set; } 
        public IRPSGridComboBox<UserEntityView> IDSite { get; set; } 
                     
    }
 
        public partial class UserInvoicingPointsCollectionEditor<UserEntityView>:RPSCollectionEditor<UserEntityView> where UserEntityView : class, IView
    {
        public  UserInvoicingPointsGridView<UserEntityView> GridView {get;set;}
    }
    public partial class UserInvoicingPointsGridView <UserEntityView> :  RPSGridView<UserEntityView> where UserEntityView : class, IView
    {
        public UserInvoicingPointsGridView(UserEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodCompany = RPSControlFactory.CreateRPSGridComboBox<UserEntityView>("","#77bdb3d4-df4c-464c-bb3c-6dda5b5196d9 .ag-row[role='row']@ROWINDEX [col-id='cCodCompany']","",true, this.CurrentView);
 
            IDInvoicingPoint = RPSControlFactory.CreateRPSGridComboBox<UserEntityView>("","#77bdb3d4-df4c-464c-bb3c-6dda5b5196d9 .ag-row[role='row']@ROWINDEX [col-id='cIDInvoicingPoint']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<UserEntityView> CodCompany { get; set; } 
        public IRPSGridComboBox<UserEntityView> IDInvoicingPoint { get; set; } 
                     
    }
 
        public partial class UserBusinessUnitsCollectionEditor<UserEntityView>:RPSCollectionEditor<UserEntityView> where UserEntityView : class, IView
    {
        public  UserBusinessUnitsGridView<UserEntityView> GridView {get;set;}
    }
    public partial class UserBusinessUnitsGridView <UserEntityView> :  RPSGridView<UserEntityView> where UserEntityView : class, IView
    {
        public UserBusinessUnitsGridView(UserEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodCompany = RPSControlFactory.CreateRPSGridComboBox<UserEntityView>("","#efc401ca-287e-47dd-bb41-47bda47843fe .ag-row[role='row']@ROWINDEX [col-id='cCodCompany']","",false, this.CurrentView);
 
            IDBusinessUnit = RPSControlFactory.CreateRPSGridComboBox<UserEntityView>("","#efc401ca-287e-47dd-bb41-47bda47843fe .ag-row[role='row']@ROWINDEX [col-id='cIDBusinessUnit']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<UserEntityView> CodCompany { get; set; } 
        public IRPSGridComboBox<UserEntityView> IDBusinessUnit { get; set; } 
                     
    }
 
    }
  
    

}