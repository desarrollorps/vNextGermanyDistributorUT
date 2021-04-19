    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.Role
{
    //RPS VERSION 1.0.0.0
    public partial class Role:Screen
    {
        public Role():base()
        {
            this.URL = "general.role";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            RoleCollectionView  = new RoleCollectionView(this); 
            RoleEntityView  = new RoleEntityView(this); 
            RoleCollectionView.InitializeControls(); 
            RoleEntityView.InitializeControls(); 
           
        }
      
            public RoleCollectionView RoleCollectionView {get; set; } 
            public RoleEntityView RoleEntityView {get; set; } 
    }
            
    public partial class RoleCollectionView : View
    {
        public RoleCollectionView(Role screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<RoleCollectionView,RoleEntityView>( this,Screen.RoleEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "63951b4e-c726-4ef8-b7c9-6d3b9d27f96b",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<RoleCollectionView,RoleEntityView>( params_MainConsult,this,Screen.RoleEntityView);
 

        }
        public IRPSButton<RoleCollectionView,RoleEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<RoleCollectionView,RoleEntityView> MainConsult { get; set; } 
        public Role Screen { get; set; }
        public RoleCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class RoleEntityView : View
    {
        public RoleEntityView(Role screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<RoleEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<RoleEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<RoleEntityView,RoleCollectionView>( this,Screen.RoleCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<RoleEntityView,RoleCollectionView>( this,Screen.RoleCollectionView);
 
            CodRole = RPSControlFactory.CreateRPSTextBox<RoleEntityView>("1d314c59-056a-4ab8-a579-e96fe36f9a4a","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<RoleEntityView>("9eb12a55-7b17-4147-8cba-652e858c5ae0","","",false, this);
 
            RoleAgentType = RPSControlFactory.CreateRPSEnumComboBox<RoleEntityView>("aee2e84d-8312-4a7a-84fd-55b75a0e05a7","","",true, this);
 
            RoleCommercialAgent = RPSControlFactory.CreateRPSCheckBox<RoleEntityView>("2840b33f-609a-4bbd-910c-465327d0a5e4","","",true, this);
 
            RoleEmployee = RPSControlFactory.CreateRPSCheckBox<RoleEntityView>("04e2ee63-2f36-4b73-b8bb-596fdf56282e","","",true, this);
 
            RoleCustomer = RPSControlFactory.CreateRPSCheckBox<RoleEntityView>("f7cf0b50-ffe9-41d9-88ab-6594e349096a","","",true, this);
 
            RoleSupplier = RPSControlFactory.CreateRPSCheckBox<RoleEntityView>("2099487a-7f14-405f-a448-b2bbedebea55","","",true, this);
 
            RoleAdministrator = RPSControlFactory.CreateRPSCheckBox<RoleEntityView>("5b0edaae-6a87-433b-94f7-e30f6eb12b16","","",true, this);
 
            RoleAdministratorProject = RPSControlFactory.CreateRPSCheckBox<RoleEntityView>("e07943fe-c27b-4d82-a9d0-351e7f345e22","","",true, this);
 
            RoleAdministratorPurchase = RPSControlFactory.CreateRPSCheckBox<RoleEntityView>("301a9c38-62aa-4711-8bb3-6c0a0f2e6503","","",true, this);
 
            RoleAdministratorSales = RPSControlFactory.CreateRPSCheckBox<RoleEntityView>("143e5354-257f-4e46-819a-3c755f0a8eda","","",true, this);
 
            RoleAdministratorManufacturing = RPSControlFactory.CreateRPSCheckBox<RoleEntityView>("26fe092f-79d5-4db1-a947-d47f7cfcf633","","",true, this);
 
            RoleAdministratorStructure = RPSControlFactory.CreateRPSCheckBox<RoleEntityView>("fba8cd29-4aa8-4e61-bf70-d0c3152d8459","","",true, this);
 
            RoleAdministratorAPQDefinition = RPSControlFactory.CreateRPSCheckBox<RoleEntityView>("898962dd-4913-4560-bf88-bc4044251ba6","","",true, this);
 
            RoleAdministratorAPQRegister = RPSControlFactory.CreateRPSCheckBox<RoleEntityView>("a8a00a26-22ed-469e-9276-095a01274432","","",true, this);
 
            RoleAdministratorMaintenance = RPSControlFactory.CreateRPSCheckBox<RoleEntityView>("4c5aa446-aab6-451a-96b6-cd1d9b13a081","","",true, this);
 
            RoleAdministratorBI = RPSControlFactory.CreateRPSCheckBox<RoleEntityView>("e2ba74b5-9fbf-42a2-81bb-c103bc5b2189","","",true, this);
 
            RoleAdministratorTRA = RPSControlFactory.CreateRPSCheckBox<RoleEntityView>("d0c14322-2f2f-424d-a976-7f7a29040712","","",true, this);
 
            AllCompanies = RPSControlFactory.CreateRPSCheckBox<RoleEntityView>("330b5138-14b9-49c7-a3ee-5c82f0f82055","","",true, this);
 
            AuthorizationType = RPSControlFactory.CreateRPSEnumComboBox<RoleEntityView>("f3f014da-a73e-43a9-87ec-1c122a0fd061","","",true, this);
 
            Filter = RPSControlFactory.CreateRPSTextBox<RoleEntityView>("a2448263-39ec-41af-8516-79e0c17c4429","","",false, this);
 
            SelectAllButton = RPSControlFactory.CreateRPSButton<RoleEntityView>( "73385cdb-c614-41f1-b39e-2d531a029136","","",this);
 
            DeselectAllButton = RPSControlFactory.CreateRPSButton<RoleEntityView>( "fbeedd54-7242-4831-83f5-79fd180591a3","","",this);
 
            CollectionInit params_RolePrivilege = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0ee04269-7d86-436d-85b0-6cd2f789e538",CSSSelectorGrid="",XPathGrid=""};
            RolePrivilege = RPSControlFactory.RPSCreateCollectionWithGrid<RolePrivilegeCollectionEditor<RoleEntityView>,RoleEntityView>( params_RolePrivilege,this);
 
            Section = RPSControlFactory.CreateRPSSection<RoleEntityView>( "","ul li[rpsid='7354b956-fd1a-486c-8281-010aa8c387c7']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<RoleEntityView>( "","ul li[rpsid='bacd7ba4-ef95-46f6-a6cb-c99c869ebe9a']","",this);
 

        }
        public IRPSSaveButton<RoleEntityView> SaveButton { get; set; } 
        public IRPSButton<RoleEntityView> DeleteButton { get; set; } 
        public IRPSButton<RoleEntityView,RoleCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<RoleEntityView,RoleCollectionView> BackButton { get; set; } 
        public IRPSTextBox<RoleEntityView> CodRole { get; set; } 
        public IRPSTextBox<RoleEntityView> Description { get; set; } 
        public IRPSComboBox<RoleEntityView> RoleAgentType { get; set; } 
        public IRPSCheckbox<RoleEntityView> RoleCommercialAgent { get; set; } 
        public IRPSCheckbox<RoleEntityView> RoleEmployee { get; set; } 
        public IRPSCheckbox<RoleEntityView> RoleCustomer { get; set; } 
        public IRPSCheckbox<RoleEntityView> RoleSupplier { get; set; } 
        public IRPSCheckbox<RoleEntityView> RoleAdministrator { get; set; } 
        public IRPSCheckbox<RoleEntityView> RoleAdministratorProject { get; set; } 
        public IRPSCheckbox<RoleEntityView> RoleAdministratorPurchase { get; set; } 
        public IRPSCheckbox<RoleEntityView> RoleAdministratorSales { get; set; } 
        public IRPSCheckbox<RoleEntityView> RoleAdministratorManufacturing { get; set; } 
        public IRPSCheckbox<RoleEntityView> RoleAdministratorStructure { get; set; } 
        public IRPSCheckbox<RoleEntityView> RoleAdministratorAPQDefinition { get; set; } 
        public IRPSCheckbox<RoleEntityView> RoleAdministratorAPQRegister { get; set; } 
        public IRPSCheckbox<RoleEntityView> RoleAdministratorMaintenance { get; set; } 
        public IRPSCheckbox<RoleEntityView> RoleAdministratorBI { get; set; } 
        public IRPSCheckbox<RoleEntityView> RoleAdministratorTRA { get; set; } 
        public IRPSCheckbox<RoleEntityView> AllCompanies { get; set; } 
        public IRPSComboBox<RoleEntityView> AuthorizationType { get; set; } 
        public IRPSTextBox<RoleEntityView> Filter { get; set; } 
        public IRPSButton<RoleEntityView> SelectAllButton { get; set; } 
        public IRPSButton<RoleEntityView> DeselectAllButton { get; set; } 
        public RolePrivilegeCollectionEditor<RoleEntityView> RolePrivilege { get; set; } 
        public IRPSSection<RoleEntityView> Section { get; set; } 
        public IRPSSection<RoleEntityView> Section1 { get; set; } 
        public Role Screen { get; set; }
        public RoleEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class RolePrivilegeCollectionEditor<RoleEntityView>:RPSCollectionEditor<RoleEntityView> where RoleEntityView : class, IView
    {
        public  RolePrivilegeGridView<RoleEntityView> GridView {get;set;}
    }
    public partial class RolePrivilegeGridView <RoleEntityView> :  RPSGridView<RoleEntityView> where RoleEntityView : class, IView
    {
        public RolePrivilegeGridView(RoleEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Check = RPSControlFactory.CreateRPSGridCheckBox<RoleEntityView>("","#0ee04269-7d86-436d-85b0-6cd2f789e538 .ag-row[role='row']@ROWINDEX [col-id='cCheck']","",false, this.CurrentView);
 
            Privilege = RPSControlFactory.CreateRPSGridTextBox<RoleEntityView>("","#0ee04269-7d86-436d-85b0-6cd2f789e538 .ag-row[role='row']@ROWINDEX [col-id='cPrivilege']","",false, this.CurrentView);
 

        }
        public IRPSGridCheckbox<RoleEntityView> Check { get; set; } 
        public IRPSGridTextBox<RoleEntityView> Privilege { get; set; } 
                     
    }
 
    }
  
    

}