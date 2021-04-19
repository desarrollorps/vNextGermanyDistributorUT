    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.MaintenanceOrderGeneration
{
    //RPS VERSION 1.0.0.0
    public partial class MaintenanceOrderGeneration:Screen
    {
        public MaintenanceOrderGeneration():base()
        {
            this.URL = "maintenance.maintenanceordergeneration";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MaintenanceOrderGenerationView  = new MaintenanceOrderGenerationView(this); 
            MaintenanceOrderGenerationView.InitializeControls(); 
           
        }
      
            public MaintenanceOrderGenerationView MaintenanceOrderGenerationView {get; set; } 
    }
            
    public partial class MaintenanceOrderGenerationView : View
    {
        public MaintenanceOrderGenerationView(MaintenanceOrderGeneration screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UISite = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderGenerationView>("742dec3c-aa37-4825-a41d-f9f42ac12b99","","",false, this);
 
            UILstMaintenancePlan = RPSControlFactory.CreateRPSCollectionComboBox<MaintenanceOrderGenerationView>("e976034f-9821-4dee-957d-e44e13916df9","","",false, this);
 
            UILstMaintenanceComponent = RPSControlFactory.CreateRPSCollectionComboBox<MaintenanceOrderGenerationView>("19bf2e94-163c-4df6-b53a-d9117da8ee10","","",false, this);
 
            SerialNumber = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderGenerationView>("6be30a60-6893-43ca-bb5c-1d0077a01644","","",false, this);
 
            UIDateFrom = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderGenerationView>("f9de881b-06e1-48db-809f-af3ce93a443c","","",true, this);
 
            UIDateTo = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderGenerationView>("293c7412-96bd-4b38-8987-8eb94fe937d8","","",true, this);
 
            UIUser = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderGenerationView>("bcab60ce-7cef-4af9-9600-01f2f0f7a597","","",false, this);
 
            LoadOrdersCommand = RPSControlFactory.CreateRPSButton<MaintenanceOrderGenerationView>( "ab6db4cf-abfc-4df8-9542-5c86b999421c","","",this);
 
            GenerateOrders = RPSControlFactory.CreateRPSButton<MaintenanceOrderGenerationView>( "a5bc5bf1-c810-40b1-8be7-706d53aaaad2","","",this);
 
            CollectionInit params_MaintenancePlansForOrderGeneration = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="2746082b-3447-47f5-8ede-37138a4d726c",CSSSelectorGrid="",XPathGrid=""};
            MaintenancePlansForOrderGeneration = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenancePlansForOrderGenerationCollectionEditor<MaintenanceOrderGenerationView>,MaintenanceOrderGenerationView>( params_MaintenancePlansForOrderGeneration,this);
 

        }
        public IRPSComboBox<MaintenanceOrderGenerationView> UISite { get; set; } 
        public IRPSCollectionComboBox<MaintenanceOrderGenerationView> UILstMaintenancePlan { get; set; } 
        public IRPSCollectionComboBox<MaintenanceOrderGenerationView> UILstMaintenanceComponent { get; set; } 
        public IRPSTextBox<MaintenanceOrderGenerationView> SerialNumber { get; set; } 
        public IRPSTextBox<MaintenanceOrderGenerationView> UIDateFrom { get; set; } 
        public IRPSTextBox<MaintenanceOrderGenerationView> UIDateTo { get; set; } 
        public IRPSComboBox<MaintenanceOrderGenerationView> UIUser { get; set; } 
        public IRPSButton<MaintenanceOrderGenerationView> LoadOrdersCommand { get; set; } 
        public IRPSButton<MaintenanceOrderGenerationView> GenerateOrders { get; set; } 
        public MaintenancePlansForOrderGenerationCollectionEditor<MaintenanceOrderGenerationView> MaintenancePlansForOrderGeneration { get; set; } 
        public MaintenanceOrderGeneration Screen { get; set; }
        public MaintenanceOrderGenerationView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaintenancePlansForOrderGenerationCollectionEditor<MaintenanceOrderGenerationView>:RPSCollectionEditor<MaintenanceOrderGenerationView> where MaintenanceOrderGenerationView : class, IView
    {
        public  MaintenancePlansForOrderGenerationGridView<MaintenanceOrderGenerationView> GridView {get;set;}
    }
    public partial class MaintenancePlansForOrderGenerationGridView <MaintenanceOrderGenerationView> :  RPSGridView<MaintenanceOrderGenerationView> where MaintenanceOrderGenerationView : class, IView
    {
        public MaintenancePlansForOrderGenerationGridView(MaintenanceOrderGenerationView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ExecutionDate = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderGenerationView>("","#2746082b-3447-47f5-8ede-37138a4d726c .ag-row[role='row']@ROWINDEX [col-id='cExecutionDate']","",false, this.CurrentView);
 
            ExecutionTime = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderGenerationView>("","#2746082b-3447-47f5-8ede-37138a4d726c .ag-row[role='row']@ROWINDEX [col-id='cExecutionTime']","",false, this.CurrentView);
 
            TypeOfAction = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenanceOrderGenerationView>("","#2746082b-3447-47f5-8ede-37138a4d726c .ag-row[role='row']@ROWINDEX [col-id='cTypeOfAction']","",false, this.CurrentView);
 
            ResponsibleType = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenanceOrderGenerationView>("","#2746082b-3447-47f5-8ede-37138a4d726c .ag-row[role='row']@ROWINDEX [col-id='cResponsibleType']","",false, this.CurrentView);
 
            Observations = RPSControlFactory.CreateRPSGridMemoTextBox<MaintenanceOrderGenerationView>("","#2746082b-3447-47f5-8ede-37138a4d726c .ag-row[role='row']@ROWINDEX [col-id='cObservations']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MaintenanceOrderGenerationView> ExecutionDate { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderGenerationView> ExecutionTime { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderGenerationView> TypeOfAction { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderGenerationView> ResponsibleType { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderGenerationView> Observations { get; set; } 
                     
    }
 
    }
  
    

}