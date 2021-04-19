    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.MANCONContract
{
    //RPS VERSION 1.0.0.0
    public partial class MANCONContract:Screen
    {
        public MANCONContract():base()
        {
            this.URL = "maintenance.manconcontract";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MANCONContractQueryView  = new MANCONContractQueryView(this); 
            MANCONContractQueryView.InitializeControls(); 
           
        }
      
            public MANCONContractQueryView MANCONContractQueryView {get; set; } 
    }
            
    public partial class MANCONContractQueryView : View
    {
        public MANCONContractQueryView(MANCONContract screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<MANCONContractQueryView>("dc60b041-bcf0-4752-a4c0-4ba9396350b2","","",false, this);
 
            MaintenanceContract = RPSControlFactory.CreateRPSCollectionComboBox<MANCONContractQueryView>("b8fe9a80-8087-49bd-a806-39c1994cba23","","",false, this);
 
            Customer = RPSControlFactory.CreateRPSCollectionComboBox<MANCONContractQueryView>("d6af0faa-863c-41bf-9944-1393c8b44eb3","","",false, this);
 
            Supplier = RPSControlFactory.CreateRPSCollectionComboBox<MANCONContractQueryView>("d8135696-fc02-419b-8f58-98abf644c7d1","","",false, this);
 
            Valid = RPSControlFactory.CreateRPSOption<MANCONContractQueryView>( "9ca5127c-4c60-48bb-a81f-4cf544095377","","",this);
 
            All = RPSControlFactory.CreateRPSOption<MANCONContractQueryView>( "09a692e1-4744-4d6e-9591-5ee332d4ea07","","",this);
 
            Cancelled = RPSControlFactory.CreateRPSOption<MANCONContractQueryView>( "4e9e94af-1da5-4cb3-8e89-ce4356816530","","",this);
 
            CollectionInit params_MaintenanceContractHistoricConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c1a98c58-5059-4247-81fd-3434016365de",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceContractHistoricConsult = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceContractHistoricConsultCollectionEditor<MANCONContractQueryView>,MANCONContractQueryView>( params_MaintenanceContractHistoricConsult,this);
 

        }
        public IRPSComboBox<MANCONContractQueryView> Site { get; set; } 
        public IRPSCollectionComboBox<MANCONContractQueryView> MaintenanceContract { get; set; } 
        public IRPSCollectionComboBox<MANCONContractQueryView> Customer { get; set; } 
        public IRPSCollectionComboBox<MANCONContractQueryView> Supplier { get; set; } 
        public IRPSOption<MANCONContractQueryView> Valid { get; set; } 
        public IRPSOption<MANCONContractQueryView> All { get; set; } 
        public IRPSOption<MANCONContractQueryView> Cancelled { get; set; } 
        public MaintenanceContractHistoricConsultCollectionEditor<MANCONContractQueryView> MaintenanceContractHistoricConsult { get; set; } 
        public MANCONContract Screen { get; set; }
        public MANCONContractQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaintenanceContractHistoricConsultCollectionEditor<MANCONContractQueryView>:RPSCollectionEditor<MANCONContractQueryView> where MANCONContractQueryView : class, IView
    {
        public  MaintenanceContractHistoricConsultGridView<MANCONContractQueryView> GridView {get;set;}
    }
    public partial class MaintenanceContractHistoricConsultGridView <MANCONContractQueryView> :  RPSGridView<MANCONContractQueryView> where MANCONContractQueryView : class, IView
    {
        public MaintenanceContractHistoricConsultGridView(MANCONContractQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MaintenanceContract_MaintenanceContractType = RPSControlFactory.CreateRPSGridTextBox<MANCONContractQueryView>("","#c1a98c58-5059-4247-81fd-3434016365de .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceContract_MaintenanceContractType']","",false, this.CurrentView);
 
            MaintenanceContract_FormalizationDate = RPSControlFactory.CreateRPSGridTextBox<MANCONContractQueryView>("","#c1a98c58-5059-4247-81fd-3434016365de .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceContract_FormalizationDate']","",false, this.CurrentView);
 
            MaintenanceContract_DateFrom = RPSControlFactory.CreateRPSGridTextBox<MANCONContractQueryView>("","#c1a98c58-5059-4247-81fd-3434016365de .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceContract_DateFrom']","",false, this.CurrentView);
 
            MaintenanceContract_DateTo = RPSControlFactory.CreateRPSGridTextBox<MANCONContractQueryView>("","#c1a98c58-5059-4247-81fd-3434016365de .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceContract_DateTo']","",false, this.CurrentView);
 
            MaintenanceContract_LastInvoiceDate = RPSControlFactory.CreateRPSGridTextBox<MANCONContractQueryView>("","#c1a98c58-5059-4247-81fd-3434016365de .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceContract_LastInvoiceDate']","",false, this.CurrentView);
 
            MaintenanceContract_AutomaticRenovation = RPSControlFactory.CreateRPSGridCheckBox<MANCONContractQueryView>("","#c1a98c58-5059-4247-81fd-3434016365de .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceContract_AutomaticRenovation']","",false, this.CurrentView);
 
            MaintenanceContract_CoverageExtensionText = RPSControlFactory.CreateRPSGridMemoTextBox<MANCONContractQueryView>("","#c1a98c58-5059-4247-81fd-3434016365de .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceContract_CoverageExtensionText']","",false, this.CurrentView);
 
            MaintenanceContract_ConditionExtensionText = RPSControlFactory.CreateRPSGridMemoTextBox<MANCONContractQueryView>("","#c1a98c58-5059-4247-81fd-3434016365de .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceContract_ConditionExtensionText']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MANCONContractQueryView> MaintenanceContract_MaintenanceContractType { get; set; } 
        public IRPSGridTextBox<MANCONContractQueryView> MaintenanceContract_FormalizationDate { get; set; } 
        public IRPSGridTextBox<MANCONContractQueryView> MaintenanceContract_DateFrom { get; set; } 
        public IRPSGridTextBox<MANCONContractQueryView> MaintenanceContract_DateTo { get; set; } 
        public IRPSGridTextBox<MANCONContractQueryView> MaintenanceContract_LastInvoiceDate { get; set; } 
        public IRPSGridCheckbox<MANCONContractQueryView> MaintenanceContract_AutomaticRenovation { get; set; } 
        public IRPSGridTextBox<MANCONContractQueryView> MaintenanceContract_CoverageExtensionText { get; set; } 
        public IRPSGridTextBox<MANCONContractQueryView> MaintenanceContract_ConditionExtensionText { get; set; } 
                     
    }
 
    }
  
    

}