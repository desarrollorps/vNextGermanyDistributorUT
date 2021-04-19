    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.MaintenanceStaffManagement
{
    //RPS VERSION 1.0.0.0
    public partial class MaintenanceStaffManagement:Screen
    {
        public MaintenanceStaffManagement():base()
        {
            this.URL = "maintenance.maintenancestaffmanagement";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MaintenanceStaffManagementView  = new MaintenanceStaffManagementView(this); 
            MaintenanceStaffManagementView.InitializeControls(); 
           
        }
      
            public MaintenanceStaffManagementView MaintenanceStaffManagementView {get; set; } 
    }
            
    public partial class MaintenanceStaffManagementView : View
    {
        public MaintenanceStaffManagementView(MaintenanceStaffManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UISite = RPSControlFactory.CreateRPSComboBox<MaintenanceStaffManagementView>("dff552ca-481e-42c2-b040-7e1a5da97899","","",false, this);
 
            UIOptAll = RPSControlFactory.CreateRPSOption<MaintenanceStaffManagementView>( "3e550327-19bc-4f4d-9adc-8a78e7a984af","","",this);
 
            UIOptQualification = RPSControlFactory.CreateRPSOption<MaintenanceStaffManagementView>( "c80e72a2-ce08-4fc3-8b36-c6160a73ae12","","",this);
 
            UIQualify = RPSControlFactory.CreateRPSComboBox<MaintenanceStaffManagementView>("a47e32a5-d600-4b9f-b389-90d6099b726d","","",false, this);
 
            UIOptEmployee = RPSControlFactory.CreateRPSOption<MaintenanceStaffManagementView>( "40291805-aff9-44ea-addf-e6e5af8ec90b","","",this);
 
            UIEmployee = RPSControlFactory.CreateRPSComboBox<MaintenanceStaffManagementView>("a1745a47-ec64-4087-a5c5-bc8b59d0a0eb","","",false, this);
 
            UIDateFrom = RPSControlFactory.CreateRPSTextBox<MaintenanceStaffManagementView>("ae323b8c-f029-4f87-93c2-c33acdc7c718","","",false, this);
 
            UIDateTo = RPSControlFactory.CreateRPSTextBox<MaintenanceStaffManagementView>("b9b21fd4-f976-4a5c-ba5a-14c1380d13d2","","",false, this);
 
            ConsultCommand = RPSControlFactory.CreateRPSButton<MaintenanceStaffManagementView>( "9402168a-e900-4916-bdb5-a3e2b16b72fd","","",this);
 
            CollectionInit params_MaintenanceStaffManagement = new CollectionInit(){IDDescriptor = "f570ed96-6a22-4486-9910-71b50f1ca4ca",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6c3b0477-b773-40f0-b470-ac4a4b735772",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceStaffManagement = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceStaffManagementCollectionEditor<MaintenanceStaffManagementView>,MaintenanceStaffManagementView>( params_MaintenanceStaffManagement,this);
 
            CollectionInit params_MaintenanceOrderForStaffManagement = new CollectionInit(){IDDescriptor = "f570ed96-6a22-4486-9910-71b50f1ca4ca",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f9003f46-87a2-4725-96ae-6e41fdf29d28",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceOrderForStaffManagement = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceOrderForStaffManagementCollectionEditor<MaintenanceStaffManagementView>,MaintenanceStaffManagementView>( params_MaintenanceOrderForStaffManagement,this);
 

        }
        public IRPSComboBox<MaintenanceStaffManagementView> UISite { get; set; } 
        public IRPSOption<MaintenanceStaffManagementView> UIOptAll { get; set; } 
        public IRPSOption<MaintenanceStaffManagementView> UIOptQualification { get; set; } 
        public IRPSComboBox<MaintenanceStaffManagementView> UIQualify { get; set; } 
        public IRPSOption<MaintenanceStaffManagementView> UIOptEmployee { get; set; } 
        public IRPSComboBox<MaintenanceStaffManagementView> UIEmployee { get; set; } 
        public IRPSTextBox<MaintenanceStaffManagementView> UIDateFrom { get; set; } 
        public IRPSTextBox<MaintenanceStaffManagementView> UIDateTo { get; set; } 
        public IRPSButton<MaintenanceStaffManagementView> ConsultCommand { get; set; } 
        public MaintenanceStaffManagementCollectionEditor<MaintenanceStaffManagementView> MaintenanceStaffManagement { get; set; } 
        public MaintenanceOrderForStaffManagementCollectionEditor<MaintenanceStaffManagementView> MaintenanceOrderForStaffManagement { get; set; } 
        public MaintenanceStaffManagement Screen { get; set; }
        public MaintenanceStaffManagementView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaintenanceStaffManagementCollectionEditor<MaintenanceStaffManagementView>:RPSCollectionEditor<MaintenanceStaffManagementView> where MaintenanceStaffManagementView : class, IView
    {
        public  MaintenanceStaffManagementGridView<MaintenanceStaffManagementView> GridView {get;set;}
    }
    public partial class MaintenanceStaffManagementGridView <MaintenanceStaffManagementView> :  RPSGridView<MaintenanceStaffManagementView> where MaintenanceStaffManagementView : class, IView
    {
        public MaintenanceStaffManagementGridView(MaintenanceStaffManagementView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            TechnicianType = RPSControlFactory.CreateRPSGridTextBox<MaintenanceStaffManagementView>("","#6c3b0477-b773-40f0-b470-ac4a4b735772 .ag-row[role='row']@ROWINDEX [col-id='cTechnicianType']","",false, this.CurrentView);
 
            Date = RPSControlFactory.CreateRPSGridTextBox<MaintenanceStaffManagementView>("","#6c3b0477-b773-40f0-b470-ac4a4b735772 .ag-row[role='row']@ROWINDEX [col-id='cDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MaintenanceStaffManagementView> TechnicianType { get; set; } 
        public IRPSGridTextBox<MaintenanceStaffManagementView> Date { get; set; } 
                     
    }
 
        public partial class MaintenanceOrderForStaffManagementCollectionEditor<MaintenanceStaffManagementView>:RPSCollectionEditor<MaintenanceStaffManagementView> where MaintenanceStaffManagementView : class, IView
    {
        public  MaintenanceOrderForStaffManagementGridView<MaintenanceStaffManagementView> GridView {get;set;}
    }
    public partial class MaintenanceOrderForStaffManagementGridView <MaintenanceStaffManagementView> :  RPSGridView<MaintenanceStaffManagementView> where MaintenanceStaffManagementView : class, IView
    {
        public MaintenanceOrderForStaffManagementGridView(MaintenanceStaffManagementView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MaintenanceOrder_ExecutionDate = RPSControlFactory.CreateRPSGridTextBox<MaintenanceStaffManagementView>("","#f9003f46-87a2-4725-96ae-6e41fdf29d28 .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceOrder_ExecutionDate']","",false, this.CurrentView);
 
            MaintenanceOrder_ExecutionTime = RPSControlFactory.CreateRPSGridTextBox<MaintenanceStaffManagementView>("","#f9003f46-87a2-4725-96ae-6e41fdf29d28 .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceOrder_ExecutionTime']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MaintenanceStaffManagementView> MaintenanceOrder_ExecutionDate { get; set; } 
        public IRPSGridTextBox<MaintenanceStaffManagementView> MaintenanceOrder_ExecutionTime { get; set; } 
                     
    }
 
    }
  
    

}