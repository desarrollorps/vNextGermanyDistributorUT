    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.MANCONKnowledgeDatabase
{
    //RPS VERSION 1.0.0.0
    public partial class MANCONKnowledgeDatabase:Screen
    {
        public MANCONKnowledgeDatabase():base()
        {
            this.URL = "maintenance.manconknowledgedatabase";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MANCONKnowledgeDatabaseQueryView  = new MANCONKnowledgeDatabaseQueryView(this); 
            MANCONKnowledgeDatabaseQueryView.InitializeControls(); 
           
        }
      
            public MANCONKnowledgeDatabaseQueryView MANCONKnowledgeDatabaseQueryView {get; set; } 
    }
            
    public partial class MANCONKnowledgeDatabaseQueryView : View
    {
        public MANCONKnowledgeDatabaseQueryView(MANCONKnowledgeDatabase screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Sites = RPSControlFactory.CreateRPSCollectionComboBox<MANCONKnowledgeDatabaseQueryView>("34501a92-3e91-499a-965b-acbb7e23c8d0","","",false, this);
 
            MaintenanceWarnings = RPSControlFactory.CreateRPSCollectionComboBox<MANCONKnowledgeDatabaseQueryView>("3432cf84-cfbe-45b0-ac29-989a897e1dd2","","",false, this);
 
            Customers = RPSControlFactory.CreateRPSCollectionComboBox<MANCONKnowledgeDatabaseQueryView>("9822aa5b-d024-4bc3-9e27-7635ffb6e184","","",false, this);
 
            MaintenanceComponents = RPSControlFactory.CreateRPSCollectionComboBox<MANCONKnowledgeDatabaseQueryView>("2ec095b7-974e-4f3d-8117-5bdeaa9124e7","","",false, this);
 
            SerialNumber = RPSControlFactory.CreateRPSTextBox<MANCONKnowledgeDatabaseQueryView>("b6a2d8cb-e10b-4d3c-ab40-ae664b50f3cc","","",false, this);
 
            EntryDateFrom = RPSControlFactory.CreateRPSTextBox<MANCONKnowledgeDatabaseQueryView>("340052b4-3fd6-48a2-84dd-aac118018e8b","","",false, this);
 
            EntryDateTo = RPSControlFactory.CreateRPSTextBox<MANCONKnowledgeDatabaseQueryView>("e7c43934-3629-4ae7-be75-6ff5b60fa316","","",false, this);
 
            Exact = RPSControlFactory.CreateRPSOption<MANCONKnowledgeDatabaseQueryView>( "2294ad32-1af8-41d0-8fce-1ab9e46bd72d","","",this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MANCONKnowledgeDatabaseQueryView>("323d6f19-72fa-4586-8c80-ca036b81e900","","",false, this);
 
            Any = RPSControlFactory.CreateRPSOption<MANCONKnowledgeDatabaseQueryView>( "b897a8df-d91d-4e4a-97ca-b7e8f9f35144","","",this);
 
            CollectionInit params_MaintenanceWarningKnowledgeDatabase = new CollectionInit(){IDDescriptor = "9a7d8091-6e16-47b6-855b-fed289e02afa",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d2e229ee-5013-47d8-8088-59bd30b8e929",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceWarningKnowledgeDatabase = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceWarningKnowledgeDatabaseCollectionEditor<MANCONKnowledgeDatabaseQueryView>,MANCONKnowledgeDatabaseQueryView>( params_MaintenanceWarningKnowledgeDatabase,this);
 
            CollectionInit params_MaintenanceWarningHistorySolution = new CollectionInit(){IDDescriptor = "9a7d8091-6e16-47b6-855b-fed289e02afa",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="2cf562a9-7a84-4028-baa6-382596543120",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceWarningHistorySolution = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceWarningHistorySolutionCollectionEditor<MANCONKnowledgeDatabaseQueryView>,MANCONKnowledgeDatabaseQueryView>( params_MaintenanceWarningHistorySolution,this);
 

        }
        public IRPSCollectionComboBox<MANCONKnowledgeDatabaseQueryView> Sites { get; set; } 
        public IRPSCollectionComboBox<MANCONKnowledgeDatabaseQueryView> MaintenanceWarnings { get; set; } 
        public IRPSCollectionComboBox<MANCONKnowledgeDatabaseQueryView> Customers { get; set; } 
        public IRPSCollectionComboBox<MANCONKnowledgeDatabaseQueryView> MaintenanceComponents { get; set; } 
        public IRPSTextBox<MANCONKnowledgeDatabaseQueryView> SerialNumber { get; set; } 
        public IRPSTextBox<MANCONKnowledgeDatabaseQueryView> EntryDateFrom { get; set; } 
        public IRPSTextBox<MANCONKnowledgeDatabaseQueryView> EntryDateTo { get; set; } 
        public IRPSOption<MANCONKnowledgeDatabaseQueryView> Exact { get; set; } 
        public IRPSTextBox<MANCONKnowledgeDatabaseQueryView> Description { get; set; } 
        public IRPSOption<MANCONKnowledgeDatabaseQueryView> Any { get; set; } 
        public MaintenanceWarningKnowledgeDatabaseCollectionEditor<MANCONKnowledgeDatabaseQueryView> MaintenanceWarningKnowledgeDatabase { get; set; } 
        public MaintenanceWarningHistorySolutionCollectionEditor<MANCONKnowledgeDatabaseQueryView> MaintenanceWarningHistorySolution { get; set; } 
        public MANCONKnowledgeDatabase Screen { get; set; }
        public MANCONKnowledgeDatabaseQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaintenanceWarningKnowledgeDatabaseCollectionEditor<MANCONKnowledgeDatabaseQueryView>:RPSCollectionEditor<MANCONKnowledgeDatabaseQueryView> where MANCONKnowledgeDatabaseQueryView : class, IView
    {
        public  MaintenanceWarningKnowledgeDatabaseGridView<MANCONKnowledgeDatabaseQueryView> GridView {get;set;}
    }
    public partial class MaintenanceWarningKnowledgeDatabaseGridView <MANCONKnowledgeDatabaseQueryView> :  RPSGridView<MANCONKnowledgeDatabaseQueryView> where MANCONKnowledgeDatabaseQueryView : class, IView
    {
        public MaintenanceWarningKnowledgeDatabaseGridView(MANCONKnowledgeDatabaseQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MaintenanceWarning_EntryDate = RPSControlFactory.CreateRPSGridTextBox<MANCONKnowledgeDatabaseQueryView>("","#d2e229ee-5013-47d8-8088-59bd30b8e929 .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceWarning_EntryDate']","",false, this.CurrentView);
 
            MaintenanceWarning_ClosingDate = RPSControlFactory.CreateRPSGridTextBox<MANCONKnowledgeDatabaseQueryView>("","#d2e229ee-5013-47d8-8088-59bd30b8e929 .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceWarning_ClosingDate']","",false, this.CurrentView);
 
            MaintenanceWarning_Description = RPSControlFactory.CreateRPSGridMemoTextBox<MANCONKnowledgeDatabaseQueryView>("","#d2e229ee-5013-47d8-8088-59bd30b8e929 .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceWarning_Description']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MANCONKnowledgeDatabaseQueryView> MaintenanceWarning_EntryDate { get; set; } 
        public IRPSGridTextBox<MANCONKnowledgeDatabaseQueryView> MaintenanceWarning_ClosingDate { get; set; } 
        public IRPSGridTextBox<MANCONKnowledgeDatabaseQueryView> MaintenanceWarning_Description { get; set; } 
                     
    }
 
        public partial class MaintenanceWarningHistorySolutionCollectionEditor<MANCONKnowledgeDatabaseQueryView>:RPSCollectionEditor<MANCONKnowledgeDatabaseQueryView> where MANCONKnowledgeDatabaseQueryView : class, IView
    {
        public  MaintenanceWarningHistorySolutionGridView<MANCONKnowledgeDatabaseQueryView> GridView {get;set;}
    }
    public partial class MaintenanceWarningHistorySolutionGridView <MANCONKnowledgeDatabaseQueryView> :  RPSGridView<MANCONKnowledgeDatabaseQueryView> where MANCONKnowledgeDatabaseQueryView : class, IView
    {
        public MaintenanceWarningHistorySolutionGridView(MANCONKnowledgeDatabaseQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MaintenanceWarningSolution_NumMaintenanceWarningSolution = RPSControlFactory.CreateRPSGridFormattedTextBox<MANCONKnowledgeDatabaseQueryView>("","#2cf562a9-7a84-4028-baa6-382596543120 .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceWarningSolution_NumMaintenanceWarningSolution']","",false, this.CurrentView);
 
            MaintenanceWarningSolution_EntryDate = RPSControlFactory.CreateRPSGridTextBox<MANCONKnowledgeDatabaseQueryView>("","#2cf562a9-7a84-4028-baa6-382596543120 .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceWarningSolution_EntryDate']","",false, this.CurrentView);
 
            MaintenanceWarningSolution_EntryTime = RPSControlFactory.CreateRPSGridTextBox<MANCONKnowledgeDatabaseQueryView>("","#2cf562a9-7a84-4028-baa6-382596543120 .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceWarningSolution_EntryTime']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MANCONKnowledgeDatabaseQueryView> MaintenanceWarningSolution_NumMaintenanceWarningSolution { get; set; } 
        public IRPSGridTextBox<MANCONKnowledgeDatabaseQueryView> MaintenanceWarningSolution_EntryDate { get; set; } 
        public IRPSGridTextBox<MANCONKnowledgeDatabaseQueryView> MaintenanceWarningSolution_EntryTime { get; set; } 
                     
    }
 
    }
  
    

}