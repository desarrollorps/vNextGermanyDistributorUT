    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.MaintenanceOrderInvoicing
{
    //RPS VERSION 1.0.0.0
    public partial class MaintenanceOrderInvoicing:Screen
    {
        public MaintenanceOrderInvoicing():base()
        {
            this.URL = "maintenance.maintenanceorderinvoicing";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MaintenanceOrderInvoicingView  = new MaintenanceOrderInvoicingView(this); 
            MaintenanceOrderInvoicingView.InitializeControls(); 
           
        }
      
            public MaintenanceOrderInvoicingView MaintenanceOrderInvoicingView {get; set; } 
    }
            
    public partial class MaintenanceOrderInvoicingView : View
    {
        public MaintenanceOrderInvoicingView(MaintenanceOrderInvoicing screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UISite = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderInvoicingView>("7f978064-29dd-4365-8afd-86661edbae9d","","",false, this);
 
            UILStMaintenanceOrder = RPSControlFactory.CreateRPSCollectionComboBox<MaintenanceOrderInvoicingView>("3fd937bc-ab18-4c73-a29d-2d0318fa7de2","","",false, this);
 
            UILstMaintenanceComponent = RPSControlFactory.CreateRPSCollectionComboBox<MaintenanceOrderInvoicingView>("0f6135e1-9855-4229-89f3-326c8c85f0ea","","",false, this);
 
            SerialNumber = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderInvoicingView>("ddb9a459-16ce-480e-a963-fe4eedf560c0","","",false, this);
 
            UIHasInvoicingTypeSL = RPSControlFactory.CreateRPSCheckBox<MaintenanceOrderInvoicingView>("bc4d71c9-7748-4191-8311-7b6ddfd001f9","","",false, this);
 
            UIInvoicingTypeSL = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderInvoicingView>("b5a7480a-1199-420f-a0a2-93cb8a8f13ed","","",false, this);
 
            UILstCustomer = RPSControlFactory.CreateRPSCollectionComboBox<MaintenanceOrderInvoicingView>("a18ec959-69bd-4af9-975b-6c22e5af9c55","","",false, this);
 
            UIHasInvoicingType = RPSControlFactory.CreateRPSCheckBox<MaintenanceOrderInvoicingView>("82ba67b6-b15e-43d5-96fd-e20cad7923e3","","",false, this);
 
            UIInvoicingType = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderInvoicingView>("178dceae-b437-44bc-a1f1-966a25670433","","",false, this);
 
            UILstSupplier = RPSControlFactory.CreateRPSCollectionComboBox<MaintenanceOrderInvoicingView>("7a9e6adc-79fb-4209-af7a-edc7582a020a","","",false, this);
 
            UIDateFrom = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderInvoicingView>("30e5af01-18de-4467-a42c-3b0c831ede97","","",false, this);
 
            UIDateTo = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderInvoicingView>("87193a47-9c60-4476-9bf9-136bee424130","","",false, this);
 
            UIDateTimeGeneration = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderInvoicingView>("613b001d-ae44-47bc-a338-41bc018efb1f","","",true, this);
 
            ExecuteMaintenanceOrderInvoicing = RPSControlFactory.CreateRPSButton<MaintenanceOrderInvoicingView>( "92523f6d-0f14-46cf-8064-e221e2ae5617","","",this);
 

        }
        public IRPSComboBox<MaintenanceOrderInvoicingView> UISite { get; set; } 
        public IRPSCollectionComboBox<MaintenanceOrderInvoicingView> UILStMaintenanceOrder { get; set; } 
        public IRPSCollectionComboBox<MaintenanceOrderInvoicingView> UILstMaintenanceComponent { get; set; } 
        public IRPSTextBox<MaintenanceOrderInvoicingView> SerialNumber { get; set; } 
        public IRPSCheckbox<MaintenanceOrderInvoicingView> UIHasInvoicingTypeSL { get; set; } 
        public IRPSComboBox<MaintenanceOrderInvoicingView> UIInvoicingTypeSL { get; set; } 
        public IRPSCollectionComboBox<MaintenanceOrderInvoicingView> UILstCustomer { get; set; } 
        public IRPSCheckbox<MaintenanceOrderInvoicingView> UIHasInvoicingType { get; set; } 
        public IRPSComboBox<MaintenanceOrderInvoicingView> UIInvoicingType { get; set; } 
        public IRPSCollectionComboBox<MaintenanceOrderInvoicingView> UILstSupplier { get; set; } 
        public IRPSTextBox<MaintenanceOrderInvoicingView> UIDateFrom { get; set; } 
        public IRPSTextBox<MaintenanceOrderInvoicingView> UIDateTo { get; set; } 
        public IRPSTextBox<MaintenanceOrderInvoicingView> UIDateTimeGeneration { get; set; } 
        public IRPSButton<MaintenanceOrderInvoicingView> ExecuteMaintenanceOrderInvoicing { get; set; } 
        public MaintenanceOrderInvoicing Screen { get; set; }
        public MaintenanceOrderInvoicingView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}