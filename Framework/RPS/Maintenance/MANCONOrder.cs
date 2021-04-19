    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.MANCONOrder
{
    //RPS VERSION 1.0.0.0
    public partial class MANCONOrder:Screen
    {
        public MANCONOrder():base()
        {
            this.URL = "maintenance.manconorder";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MANCONOrderQueryView  = new MANCONOrderQueryView(this); 
            MANCONOrderQueryView.InitializeControls(); 
           
        }
      
            public MANCONOrderQueryView MANCONOrderQueryView {get; set; } 
    }
            
    public partial class MANCONOrderQueryView : View
    {
        public MANCONOrderQueryView(MANCONOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDSite = RPSControlFactory.CreateRPSComboBox<MANCONOrderQueryView>("e0e2ac19-a4da-4c11-92af-da0f7220171e","","",false, this);
 
            MaintenanceOrder = RPSControlFactory.CreateRPSComboBox<MANCONOrderQueryView>("abe9948d-50a6-4366-a0a1-8bedc7f9cea4","","",false, this);
 
            IDMaintenanceType = RPSControlFactory.CreateRPSComboBox<MANCONOrderQueryView>("8988a9c0-8e4d-490b-9aba-5f2c650222f2","","",false, this);
 
            IDMaintenanceComponent = RPSControlFactory.CreateRPSComboBox<MANCONOrderQueryView>("85ca2a5c-d890-464c-b00d-19087fb1041f","","",false, this);
 
            SerialNumber = RPSControlFactory.CreateRPSTextBox<MANCONOrderQueryView>("97ac3574-e8e1-4361-b682-fdce6c908928","","",false, this);
 
            Open = RPSControlFactory.CreateRPSOption<MANCONOrderQueryView>( "de87f28e-b2a2-4dd1-ab65-ecac84a0fc79","","",this);
 
            All = RPSControlFactory.CreateRPSOption<MANCONOrderQueryView>( "5881148a-ace6-43a5-a14d-5f2ae17d8226","","",this);
 
            Selection = RPSControlFactory.CreateRPSOption<MANCONOrderQueryView>( "e1b28592-0b21-44b0-bdc0-c89c72ebe2c7","","",this);
 
            MaintenanceOrderStatus = RPSControlFactory.CreateRPSComboBox<MANCONOrderQueryView>("8d97e3ed-a933-4960-9637-c38bb20b0ef2","","",false, this);
 
            All1 = RPSControlFactory.CreateRPSOption<MANCONOrderQueryView>( "307ac925-fa02-4898-b696-18ffc25ba3fb","","",this);
 
            Qualify = RPSControlFactory.CreateRPSOption<MANCONOrderQueryView>( "c72d97ad-7590-49cc-9fbc-4d36548f29b4","","",this);
 
            Qualify1 = RPSControlFactory.CreateRPSComboBox<MANCONOrderQueryView>("8634734c-47e0-44cd-aa52-5f1912d69b5f","","",false, this);
 
            Employee = RPSControlFactory.CreateRPSOption<MANCONOrderQueryView>( "733474ab-73e7-412a-8cf3-c6e905b850f4","","",this);
 
            Employee1 = RPSControlFactory.CreateRPSComboBox<MANCONOrderQueryView>("1f89c600-8e9b-48c5-9c64-091fc063ced6","","",false, this);
 
            Supplier = RPSControlFactory.CreateRPSOption<MANCONOrderQueryView>( "9a9e0deb-95c8-42ea-a313-e87e055066e3","","",this);
 
            Supplier1 = RPSControlFactory.CreateRPSComboBox<MANCONOrderQueryView>("30a473b8-118d-4ccc-94ff-e7ba1a3b5000","","",false, this);
 
            ExecutionDateFrom = RPSControlFactory.CreateRPSTextBox<MANCONOrderQueryView>("9d00c8c6-39eb-4d19-8c92-6d4fa0db69b4","","",false, this);
 
            ExecutionDateTo = RPSControlFactory.CreateRPSTextBox<MANCONOrderQueryView>("01b8cbf1-b7ab-40ba-8036-329f6a6aebc0","","",false, this);
 
            CollectionInit params_MaintenanceOrderHistoricConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="301fff61-60d8-4ba3-853c-0f6160661db1",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceOrderHistoricConsult = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceOrderHistoricConsultCollectionEditor<MANCONOrderQueryView>,MANCONOrderQueryView>( params_MaintenanceOrderHistoricConsult,this);
 

        }
        public IRPSComboBox<MANCONOrderQueryView> IDSite { get; set; } 
        public IRPSComboBox<MANCONOrderQueryView> MaintenanceOrder { get; set; } 
        public IRPSComboBox<MANCONOrderQueryView> IDMaintenanceType { get; set; } 
        public IRPSComboBox<MANCONOrderQueryView> IDMaintenanceComponent { get; set; } 
        public IRPSTextBox<MANCONOrderQueryView> SerialNumber { get; set; } 
        public IRPSOption<MANCONOrderQueryView> Open { get; set; } 
        public IRPSOption<MANCONOrderQueryView> All { get; set; } 
        public IRPSOption<MANCONOrderQueryView> Selection { get; set; } 
        public IRPSComboBox<MANCONOrderQueryView> MaintenanceOrderStatus { get; set; } 
        public IRPSOption<MANCONOrderQueryView> All1 { get; set; } 
        public IRPSOption<MANCONOrderQueryView> Qualify { get; set; } 
        public IRPSComboBox<MANCONOrderQueryView> Qualify1 { get; set; } 
        public IRPSOption<MANCONOrderQueryView> Employee { get; set; } 
        public IRPSComboBox<MANCONOrderQueryView> Employee1 { get; set; } 
        public IRPSOption<MANCONOrderQueryView> Supplier { get; set; } 
        public IRPSComboBox<MANCONOrderQueryView> Supplier1 { get; set; } 
        public IRPSTextBox<MANCONOrderQueryView> ExecutionDateFrom { get; set; } 
        public IRPSTextBox<MANCONOrderQueryView> ExecutionDateTo { get; set; } 
        public MaintenanceOrderHistoricConsultCollectionEditor<MANCONOrderQueryView> MaintenanceOrderHistoricConsult { get; set; } 
        public MANCONOrder Screen { get; set; }
        public MANCONOrderQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaintenanceOrderHistoricConsultCollectionEditor<MANCONOrderQueryView>:RPSCollectionEditor<MANCONOrderQueryView> where MANCONOrderQueryView : class, IView
    {
        public  MaintenanceOrderHistoricConsultGridView<MANCONOrderQueryView> GridView {get;set;}
    }
    public partial class MaintenanceOrderHistoricConsultGridView <MANCONOrderQueryView> :  RPSGridView<MANCONOrderQueryView> where MANCONOrderQueryView : class, IView
    {
        public MaintenanceOrderHistoricConsultGridView(MANCONOrderQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MaintenanceOrder_ExecutionDate = RPSControlFactory.CreateRPSGridTextBox<MANCONOrderQueryView>("","#301fff61-60d8-4ba3-853c-0f6160661db1 .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceOrder_ExecutionDate']","",false, this.CurrentView);
 
            MaintenanceOrder_ResponsibleType = RPSControlFactory.CreateRPSGridTextBox<MANCONOrderQueryView>("","#301fff61-60d8-4ba3-853c-0f6160661db1 .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceOrder_ResponsibleType']","",false, this.CurrentView);
 
            MaintenanceOrder_Observations = RPSControlFactory.CreateRPSGridMemoTextBox<MANCONOrderQueryView>("","#301fff61-60d8-4ba3-853c-0f6160661db1 .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceOrder_Observations']","",false, this.CurrentView);
 
            MaintenanceOrder_Notes = RPSControlFactory.CreateRPSGridMemoTextBox<MANCONOrderQueryView>("","#301fff61-60d8-4ba3-853c-0f6160661db1 .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceOrder_Notes']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MANCONOrderQueryView> MaintenanceOrder_ExecutionDate { get; set; } 
        public IRPSGridTextBox<MANCONOrderQueryView> MaintenanceOrder_ResponsibleType { get; set; } 
        public IRPSGridTextBox<MANCONOrderQueryView> MaintenanceOrder_Observations { get; set; } 
        public IRPSGridTextBox<MANCONOrderQueryView> MaintenanceOrder_Notes { get; set; } 
                     
    }
 
    }
  
    

}