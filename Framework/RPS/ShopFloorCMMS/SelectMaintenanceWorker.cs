    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.ShopFloorCMMS.SelectMaintenanceWorker
{
    //RPS VERSION 1.0.0.0
    public partial class SelectMaintenanceWorker:Screen
    {
        public SelectMaintenanceWorker():base()
        {
            this.URL = "shopfloorcmms.selectmaintenanceworker";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SelectMaintenanceWorkerView  = new SelectMaintenanceWorkerView(this); 
            EnterEmployeePasswordDialogView  = new EnterEmployeePasswordDialogView(this); 
            SelectMaintenanceWorkerView.InitializeControls(); 
            EnterEmployeePasswordDialogView.InitializeControls(); 
           
        }
      
            public SelectMaintenanceWorkerView SelectMaintenanceWorkerView {get; set; } 
            public EnterEmployeePasswordDialogView EnterEmployeePasswordDialogView {get; set; } 
    }
            
    public partial class SelectMaintenanceWorkerView : View
    {
        public SelectMaintenanceWorkerView(SelectMaintenanceWorker screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SetWorkerCommandButton = RPSControlFactory.CreateRPSButton<SelectMaintenanceWorkerView>( "30f19624-1477-41aa-b313-99361457dfff","","",this);
 
            TicketRequestNavigationCommandButton = RPSControlFactory.CreateRPSButton<SelectMaintenanceWorkerView>( "3a2a44ee-33a4-4bc8-a224-1b9e81d4afd4","","",this);
 
            WorkOrdersFollowUpNavigationCommandButton = RPSControlFactory.CreateRPSButton<SelectMaintenanceWorkerView>( "bfd1c9ea-f49d-4304-a0ba-da6154bdb5ce","","",this);
 
            MOHistoricNavigationCommandButton = RPSControlFactory.CreateRPSButton<SelectMaintenanceWorkerView>( "7dd67141-2398-47db-adc2-bcc555edc8d9","","",this);
 
            MaterialStockLocatorNavigationCommandButton = RPSControlFactory.CreateRPSButton<SelectMaintenanceWorkerView>( "50718003-74a9-43f4-a39a-3558a4c5e05c","","",this);
 
            ShopfloorDocumentationNavigationCommandButton = RPSControlFactory.CreateRPSButton<SelectMaintenanceWorkerView>( "57052414-5dc7-4c0b-9bed-fc84bfd0b384","","",this);
 
            GoBackCommandButton = RPSControlFactory.CreateRPSButton<SelectMaintenanceWorkerView>( "89e2332d-4765-45bd-933e-d2245fab384f","","",this);
 
            CollectionInit params_MaintenanceWorkers = new CollectionInit(){IDDescriptor = "be77283c-5010-44ab-be86-e83806feac12",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MaintenanceWorkers = RPSControlFactory.RPSCreateCollection<SelectMaintenanceWorkerView,EnterEmployeePasswordDialogView>( params_MaintenanceWorkers,this,Screen.EnterEmployeePasswordDialogView);
 

        }
        public IRPSButton<SelectMaintenanceWorkerView> SetWorkerCommandButton { get; set; } 
        public IRPSButton<SelectMaintenanceWorkerView> TicketRequestNavigationCommandButton { get; set; } 
        public IRPSButton<SelectMaintenanceWorkerView> WorkOrdersFollowUpNavigationCommandButton { get; set; } 
        public IRPSButton<SelectMaintenanceWorkerView> MOHistoricNavigationCommandButton { get; set; } 
        public IRPSButton<SelectMaintenanceWorkerView> MaterialStockLocatorNavigationCommandButton { get; set; } 
        public IRPSButton<SelectMaintenanceWorkerView> ShopfloorDocumentationNavigationCommandButton { get; set; } 
        public IRPSButton<SelectMaintenanceWorkerView> GoBackCommandButton { get; set; } 
        public IRPSCollectionEditor<SelectMaintenanceWorkerView,EnterEmployeePasswordDialogView> MaintenanceWorkers { get; set; } 
        public SelectMaintenanceWorker Screen { get; set; }
        public SelectMaintenanceWorkerView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class EnterEmployeePasswordDialogView : View
    {
        public EnterEmployeePasswordDialogView(SelectMaintenanceWorker screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            PassWord = RPSControlFactory.CreateRPSTextBox<EnterEmployeePasswordDialogView>("24007462-8047-450c-b7d2-e4b239f8354f","","",true, this);
 

        }
        public IRPSTextBox<EnterEmployeePasswordDialogView> PassWord { get; set; } 
        public SelectMaintenanceWorker Screen { get; set; }
        public EnterEmployeePasswordDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}