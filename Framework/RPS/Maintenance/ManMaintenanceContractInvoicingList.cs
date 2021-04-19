    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.ManMaintenanceContractInvoicingList
{
    //RPS VERSION 1.0.0.0
    public partial class ManMaintenanceContractInvoicingList:Screen
    {
        public ManMaintenanceContractInvoicingList():base()
        {
            this.URL = "maintenance.manmaintenancecontractinvoicinglist";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ManMaintenanceContractInvoicingListView  = new ManMaintenanceContractInvoicingListView(this); 
            ManMaintenanceContractInvoicingListView.InitializeControls(); 
           
        }
      
            public ManMaintenanceContractInvoicingListView ManMaintenanceContractInvoicingListView {get; set; } 
    }
            
    public partial class ManMaintenanceContractInvoicingListView : View
    {
        public ManMaintenanceContractInvoicingListView(ManMaintenanceContractInvoicingList screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<ManMaintenanceContractInvoicingListView>("78875600-8120-41d0-8808-7af9d930f495","","",false, this);
 
            MaintenanceContract = RPSControlFactory.CreateRPSCollectionComboBox<ManMaintenanceContractInvoicingListView>("d7d97ad2-f43b-4167-8804-5b253ff208f1","","",false, this);
 
            SalesType = RPSControlFactory.CreateRPSCheckBox<ManMaintenanceContractInvoicingListView>("967be88f-7687-4726-93ca-2d317a8889e4","","",false, this);
 
            Customer = RPSControlFactory.CreateRPSCollectionComboBox<ManMaintenanceContractInvoicingListView>("a6fd320a-90ab-42e7-ac28-a707501bfa97","","",false, this);
 
            PurchaseType = RPSControlFactory.CreateRPSCheckBox<ManMaintenanceContractInvoicingListView>("c2c0a542-6cc5-47b8-8db3-2f96088895df","","",false, this);
 
            Supplier = RPSControlFactory.CreateRPSCollectionComboBox<ManMaintenanceContractInvoicingListView>("469bee3c-9bd6-4305-a21a-1e21ef43b63f","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<ManMaintenanceContractInvoicingListView>("f396f35a-e46e-4878-b53e-c99651fe865a","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<ManMaintenanceContractInvoicingListView>("ef1731f0-1b7a-4f9a-8d6f-e5b875a240e5","","",false, this);
 
            TopOfPeriod = RPSControlFactory.CreateRPSOption<ManMaintenanceContractInvoicingListView>( "b51f10a7-db2d-4f0b-b65e-ab21d6b7a965","","",this);
 
            EndOfPeriod = RPSControlFactory.CreateRPSOption<ManMaintenanceContractInvoicingListView>( "7b260dee-a3eb-480a-b4a7-9606dcd79f67","","",this);
 
            ExecuteMaintenanceContractInvoicing = RPSControlFactory.CreateRPSButton<ManMaintenanceContractInvoicingListView>( "9e0fb601-8000-4677-bffc-c100921869e7","","",this);
 

        }
        public IRPSComboBox<ManMaintenanceContractInvoicingListView> Site { get; set; } 
        public IRPSCollectionComboBox<ManMaintenanceContractInvoicingListView> MaintenanceContract { get; set; } 
        public IRPSCheckbox<ManMaintenanceContractInvoicingListView> SalesType { get; set; } 
        public IRPSCollectionComboBox<ManMaintenanceContractInvoicingListView> Customer { get; set; } 
        public IRPSCheckbox<ManMaintenanceContractInvoicingListView> PurchaseType { get; set; } 
        public IRPSCollectionComboBox<ManMaintenanceContractInvoicingListView> Supplier { get; set; } 
        public IRPSTextBox<ManMaintenanceContractInvoicingListView> DateFrom { get; set; } 
        public IRPSTextBox<ManMaintenanceContractInvoicingListView> DateTo { get; set; } 
        public IRPSOption<ManMaintenanceContractInvoicingListView> TopOfPeriod { get; set; } 
        public IRPSOption<ManMaintenanceContractInvoicingListView> EndOfPeriod { get; set; } 
        public IRPSButton<ManMaintenanceContractInvoicingListView> ExecuteMaintenanceContractInvoicing { get; set; } 
        public ManMaintenanceContractInvoicingList Screen { get; set; }
        public ManMaintenanceContractInvoicingListView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}