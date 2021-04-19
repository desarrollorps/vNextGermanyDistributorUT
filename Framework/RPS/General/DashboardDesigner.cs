    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.DashboardDesigner
{
    //RPS VERSION 1.0.0.0
    public partial class DashboardDesigner:Screen
    {
        public DashboardDesigner():base()
        {
            this.URL = "general.dashboarddesigner";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DashboardCollectionView  = new DashboardCollectionView(this); 
            DashboardEntityView  = new DashboardEntityView(this); 
            CreateNewDashboardDialogView  = new CreateNewDashboardDialogView(this); 
            DashboardCollectionView.InitializeControls(); 
            DashboardEntityView.InitializeControls(); 
            CreateNewDashboardDialogView.InitializeControls(); 
           
        }
      
            public DashboardCollectionView DashboardCollectionView {get; set; } 
            public DashboardEntityView DashboardEntityView {get; set; } 
            public CreateNewDashboardDialogView CreateNewDashboardDialogView {get; set; } 
    }
            
    public partial class DashboardCollectionView : View
    {
        public DashboardCollectionView(DashboardDesigner screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<DashboardCollectionView,DashboardEntityView>( this,Screen.DashboardEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "6b6e1fd7-793c-43f9-99ba-a1c0aa989638",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<DashboardCollectionView,DashboardEntityView>( params_MainConsult,this,Screen.DashboardEntityView);
 

        }
        public IRPSButton<DashboardCollectionView,DashboardEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<DashboardCollectionView,DashboardEntityView> MainConsult { get; set; } 
        public DashboardDesigner Screen { get; set; }
        public DashboardCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DashboardEntityView : View
    {
        public DashboardEntityView(DashboardDesigner screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<DashboardEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<DashboardEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DashboardEntityView,DashboardCollectionView>( this,Screen.DashboardCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<DashboardEntityView,DashboardCollectionView>( this,Screen.DashboardCollectionView);
 
            Description = RPSControlFactory.CreateRPSTextBox<DashboardEntityView>("ad838944-b2f7-4b03-a1df-bb293668ca1e","","",true, this);
 
            EntityName = RPSControlFactory.CreateRPSTextBox<DashboardEntityView>("2c03bc03-9d90-491d-a984-0529fa3c5708","","",false, this);
 
            AllCompanies = RPSControlFactory.CreateRPSCheckBox<DashboardEntityView>("d425a89b-6b09-4cfe-b6f2-2f799d8cf06b","","",true, this);
 
            AllUsers = RPSControlFactory.CreateRPSCheckBox<DashboardEntityView>("c42e3490-63f4-4b9d-9f25-746f71ae917b","","",true, this);
 
            ExecuteActivateDashboardButton = RPSControlFactory.CreateRPSButton<DashboardEntityView>( "a5e0e493-ab63-4060-8c20-f106fe44553e","","",this);
 
            ExecuteDeactivateDashboardButton = RPSControlFactory.CreateRPSButton<DashboardEntityView>( "7190a781-1dd7-4205-aedd-f950307fc038","","",this);
 
            CollectionInit params_Company = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a73372b8-f029-4331-81b8-a8df5e7ba908",CSSSelectorGrid="",XPathGrid=""};
            Company = RPSControlFactory.RPSCreateCollectionWithGrid<CompanyCollectionEditor<DashboardEntityView>,DashboardEntityView>( params_Company,this);
 
            CollectionInit params_Role = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ae2436d1-1718-4ca4-bb7d-70c3ef62844a",CSSSelectorGrid="",XPathGrid=""};
            Role = RPSControlFactory.RPSCreateCollectionWithGrid<RoleCollectionEditor<DashboardEntityView>,DashboardEntityView>( params_Role,this);
 
            CollectionInit params_User = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="93303fce-148e-486e-899b-ceddadbb7c2e",CSSSelectorGrid="",XPathGrid=""};
            User = RPSControlFactory.RPSCreateCollectionWithGrid<UserCollectionEditor<DashboardEntityView>,DashboardEntityView>( params_User,this);
 
            Section = RPSControlFactory.CreateRPSSection<DashboardEntityView>( "","ul li[rpsid='96cea1bf-1035-4eff-8711-b75d2b983fd2']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<DashboardEntityView>( "","ul li[rpsid='7d69db60-92ff-49ec-9f3d-88b8cf0f3bb5']","",this);
 

        }
        public IRPSSaveButton<DashboardEntityView> SaveButton { get; set; } 
        public IRPSButton<DashboardEntityView> DeleteButton { get; set; } 
        public IRPSButton<DashboardEntityView,DashboardCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DashboardEntityView,DashboardCollectionView> BackButton { get; set; } 
        public IRPSTextBox<DashboardEntityView> Description { get; set; } 
        public IRPSTextBox<DashboardEntityView> EntityName { get; set; } 
        public IRPSCheckbox<DashboardEntityView> AllCompanies { get; set; } 
        public IRPSCheckbox<DashboardEntityView> AllUsers { get; set; } 
        public IRPSButton<DashboardEntityView> ExecuteActivateDashboardButton { get; set; } 
        public IRPSButton<DashboardEntityView> ExecuteDeactivateDashboardButton { get; set; } 
        public CompanyCollectionEditor<DashboardEntityView> Company { get; set; } 
        public RoleCollectionEditor<DashboardEntityView> Role { get; set; } 
        public UserCollectionEditor<DashboardEntityView> User { get; set; } 
        public IRPSSection<DashboardEntityView> Section { get; set; } 
        public IRPSSection<DashboardEntityView> Section1 { get; set; } 
        public DashboardDesigner Screen { get; set; }
        public DashboardEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CompanyCollectionEditor<DashboardEntityView>:RPSCollectionEditor<DashboardEntityView> where DashboardEntityView : class, IView
    {
        public  CompanyGridView<DashboardEntityView> GridView {get;set;}
    }
    public partial class CompanyGridView <DashboardEntityView> :  RPSGridView<DashboardEntityView> where DashboardEntityView : class, IView
    {
        public CompanyGridView(DashboardEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {

        }
                     
    }
 
        public partial class RoleCollectionEditor<DashboardEntityView>:RPSCollectionEditor<DashboardEntityView> where DashboardEntityView : class, IView
    {
        public  RoleGridView<DashboardEntityView> GridView {get;set;}
    }
    public partial class RoleGridView <DashboardEntityView> :  RPSGridView<DashboardEntityView> where DashboardEntityView : class, IView
    {
        public RoleGridView(DashboardEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {

        }
                     
    }
 
        public partial class UserCollectionEditor<DashboardEntityView>:RPSCollectionEditor<DashboardEntityView> where DashboardEntityView : class, IView
    {
        public  UserGridView<DashboardEntityView> GridView {get;set;}
    }
    public partial class UserGridView <DashboardEntityView> :  RPSGridView<DashboardEntityView> where DashboardEntityView : class, IView
    {
        public UserGridView(DashboardEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {

        }
                     
    }
 
    }
  
            
    public partial class CreateNewDashboardDialogView : View
    {
        public CreateNewDashboardDialogView(DashboardDesigner screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DashboardDescription = RPSControlFactory.CreateRPSTextBox<CreateNewDashboardDialogView>("301e3c70-40b1-44a3-a912-64e4108cf74a","","",true, this);
 
            General = RPSControlFactory.CreateRPSOption<CreateNewDashboardDialogView>( "95d2aba0-9f69-4f4b-a23d-802f536f243c","","",this);
 
            Entity = RPSControlFactory.CreateRPSOption<CreateNewDashboardDialogView>( "9d8972a2-246d-4bbc-a347-95aae252b24d","","",this);
 
            CollectionInit params_AvailableEntityServices = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="9b38ae61-54b6-48db-a834-e6eb850c1e4e",CSSSelectorGrid="",XPathGrid=""};
            AvailableEntityServices = RPSControlFactory.RPSCreateCollectionWithGrid<AvailableEntityServicesCollectionEditor<CreateNewDashboardDialogView>,CreateNewDashboardDialogView>( params_AvailableEntityServices,this);
 
            CollectionInit params_EntitiesInService = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="040344f6-1a76-410f-a5a6-a4595617a6d4",CSSSelectorGrid="",XPathGrid=""};
            EntitiesInService = RPSControlFactory.RPSCreateCollectionWithGrid<EntitiesInServiceCollectionEditor<CreateNewDashboardDialogView>,CreateNewDashboardDialogView>( params_EntitiesInService,this);
 

        }
        public IRPSTextBox<CreateNewDashboardDialogView> DashboardDescription { get; set; } 
        public IRPSOption<CreateNewDashboardDialogView> General { get; set; } 
        public IRPSOption<CreateNewDashboardDialogView> Entity { get; set; } 
        public AvailableEntityServicesCollectionEditor<CreateNewDashboardDialogView> AvailableEntityServices { get; set; } 
        public EntitiesInServiceCollectionEditor<CreateNewDashboardDialogView> EntitiesInService { get; set; } 
        public DashboardDesigner Screen { get; set; }
        public CreateNewDashboardDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class AvailableEntityServicesCollectionEditor<CreateNewDashboardDialogView>:RPSCollectionEditor<CreateNewDashboardDialogView> where CreateNewDashboardDialogView : class, IView
    {
        public  AvailableEntityServicesGridView<CreateNewDashboardDialogView> GridView {get;set;}
    }
    public partial class AvailableEntityServicesGridView <CreateNewDashboardDialogView> :  RPSGridView<CreateNewDashboardDialogView> where CreateNewDashboardDialogView : class, IView
    {
        public AvailableEntityServicesGridView(CreateNewDashboardDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MainField = RPSControlFactory.CreateRPSGridTextBox<CreateNewDashboardDialogView>("","#9b38ae61-54b6-48db-a834-e6eb850c1e4e .ag-row[role='row']@ROWINDEX [col-id='cMainField']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CreateNewDashboardDialogView> MainField { get; set; } 
                     
    }
 
        public partial class EntitiesInServiceCollectionEditor<CreateNewDashboardDialogView>:RPSCollectionEditor<CreateNewDashboardDialogView> where CreateNewDashboardDialogView : class, IView
    {
        public  EntitiesInServiceGridView<CreateNewDashboardDialogView> GridView {get;set;}
    }
    public partial class EntitiesInServiceGridView <CreateNewDashboardDialogView> :  RPSGridView<CreateNewDashboardDialogView> where CreateNewDashboardDialogView : class, IView
    {
        public EntitiesInServiceGridView(CreateNewDashboardDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MainField = RPSControlFactory.CreateRPSGridTextBox<CreateNewDashboardDialogView>("","#040344f6-1a76-410f-a5a6-a4595617a6d4 .ag-row[role='row']@ROWINDEX [col-id='cMainField']","",false, this.CurrentView);
 
            SecondaryField = RPSControlFactory.CreateRPSGridTextBox<CreateNewDashboardDialogView>("","#040344f6-1a76-410f-a5a6-a4595617a6d4 .ag-row[role='row']@ROWINDEX [col-id='cSecondaryField']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CreateNewDashboardDialogView> MainField { get; set; } 
        public IRPSGridTextBox<CreateNewDashboardDialogView> SecondaryField { get; set; } 
                     
    }
 
    }
  
    

}