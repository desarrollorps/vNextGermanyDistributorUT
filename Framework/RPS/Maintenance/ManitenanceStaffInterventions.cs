    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.ManitenanceStaffInterventions
{
    //RPS VERSION 1.0.0.0
    public partial class ManitenanceStaffInterventions:Screen
    {
        public ManitenanceStaffInterventions():base()
        {
            this.URL = "maintenance.manitenancestaffinterventions";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ManitenanceStaffInterventionsQueryView  = new ManitenanceStaffInterventionsQueryView(this); 
            ManitenanceStaffInterventionsQueryView.InitializeControls(); 
           
        }
      
            public ManitenanceStaffInterventionsQueryView ManitenanceStaffInterventionsQueryView {get; set; } 
    }
            
    public partial class ManitenanceStaffInterventionsQueryView : View
    {
        public ManitenanceStaffInterventionsQueryView(ManitenanceStaffInterventions screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UISite = RPSControlFactory.CreateRPSComboBox<ManitenanceStaffInterventionsQueryView>("cb4ef1e0-696d-4299-8304-c30cd76096c4","","",false, this);
 
            UIEmployee = RPSControlFactory.CreateRPSComboBox<ManitenanceStaffInterventionsQueryView>("741f077b-ff9a-4803-8a7d-c70716da639c","","",false, this);
 
            UIMaintenanceComponent = RPSControlFactory.CreateRPSComboBox<ManitenanceStaffInterventionsQueryView>("e7abd249-6897-4f96-84a7-7f6daa103182","","",false, this);
 
            SerialNumber = RPSControlFactory.CreateRPSTextBox<ManitenanceStaffInterventionsQueryView>("a805af00-4bff-4e40-9cef-7e40b6ad9338","","",false, this);
 
            UIDateFrom = RPSControlFactory.CreateRPSTextBox<ManitenanceStaffInterventionsQueryView>("e7117bfc-3c7b-4940-b38e-c49855d8faf9","","",false, this);
 
            UIDateTo = RPSControlFactory.CreateRPSTextBox<ManitenanceStaffInterventionsQueryView>("16b11cc0-66ee-4ac1-8f37-5eb6307d7ed3","","",false, this);
 
            CollectionInit params_MaintenanceStaffInterventions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6d905f13-dbb8-438e-93c2-44c1cb0a427a",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceStaffInterventions = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceStaffInterventionsCollectionEditor<ManitenanceStaffInterventionsQueryView>,ManitenanceStaffInterventionsQueryView>( params_MaintenanceStaffInterventions,this);
 

        }
        public IRPSComboBox<ManitenanceStaffInterventionsQueryView> UISite { get; set; } 
        public IRPSComboBox<ManitenanceStaffInterventionsQueryView> UIEmployee { get; set; } 
        public IRPSComboBox<ManitenanceStaffInterventionsQueryView> UIMaintenanceComponent { get; set; } 
        public IRPSTextBox<ManitenanceStaffInterventionsQueryView> SerialNumber { get; set; } 
        public IRPSTextBox<ManitenanceStaffInterventionsQueryView> UIDateFrom { get; set; } 
        public IRPSTextBox<ManitenanceStaffInterventionsQueryView> UIDateTo { get; set; } 
        public MaintenanceStaffInterventionsCollectionEditor<ManitenanceStaffInterventionsQueryView> MaintenanceStaffInterventions { get; set; } 
        public ManitenanceStaffInterventions Screen { get; set; }
        public ManitenanceStaffInterventionsQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaintenanceStaffInterventionsCollectionEditor<ManitenanceStaffInterventionsQueryView>:RPSCollectionEditor<ManitenanceStaffInterventionsQueryView> where ManitenanceStaffInterventionsQueryView : class, IView
    {
        public  MaintenanceStaffInterventionsGridView<ManitenanceStaffInterventionsQueryView> GridView {get;set;}
    }
    public partial class MaintenanceStaffInterventionsGridView <ManitenanceStaffInterventionsQueryView> :  RPSGridView<ManitenanceStaffInterventionsQueryView> where ManitenanceStaffInterventionsQueryView : class, IView
    {
        public MaintenanceStaffInterventionsGridView(ManitenanceStaffInterventionsQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MaintenanceOrder_CreationDate = RPSControlFactory.CreateRPSGridTextBox<ManitenanceStaffInterventionsQueryView>("","#6d905f13-dbb8-438e-93c2-44c1cb0a427a .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceOrder_CreationDate']","",false, this.CurrentView);
 
            MaintenanceOrder_ClosingDate = RPSControlFactory.CreateRPSGridTextBox<ManitenanceStaffInterventionsQueryView>("","#6d905f13-dbb8-438e-93c2-44c1cb0a427a .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceOrder_ClosingDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ManitenanceStaffInterventionsQueryView> MaintenanceOrder_CreationDate { get; set; } 
        public IRPSGridTextBox<ManitenanceStaffInterventionsQueryView> MaintenanceOrder_ClosingDate { get; set; } 
                     
    }
 
    }
  
    

}