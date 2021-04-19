    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.ChangeInvoicingPoint
{
    //RPS VERSION 1.0.0.0
    public partial class ChangeInvoicingPoint:Screen
    {
        public ChangeInvoicingPoint():base()
        {
            this.URL = "general.changeinvoicingpoint";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ChangeInvoicingPointView  = new ChangeInvoicingPointView(this); 
            ChangeInvoicingPointView.InitializeControls(); 
           
        }
      
            public ChangeInvoicingPointView ChangeInvoicingPointView {get; set; } 
    }
            
    public partial class ChangeInvoicingPointView : View
    {
        public ChangeInvoicingPointView(ChangeInvoicingPoint screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDInvoicingPoint = RPSControlFactory.CreateRPSComboBox<ChangeInvoicingPointView>("d15ffb0d-17c5-4d18-bc70-db698967f00e","","",false, this);
 
            SalesQuote = RPSControlFactory.CreateRPSFormattedTextBox<ChangeInvoicingPointView>("27785f50-a443-4261-9636-f1c5b874dd39","","",false, this);
 
            OrderS = RPSControlFactory.CreateRPSFormattedTextBox<ChangeInvoicingPointView>("a3ce4b93-8448-4516-87b7-ddd9b9ddee6d","","",false, this);
 
            DeliveryNoteS = RPSControlFactory.CreateRPSFormattedTextBox<ChangeInvoicingPointView>("6da362a1-8cd9-4735-9590-e5fe71bc6130","","",false, this);
 
            InvoiceS = RPSControlFactory.CreateRPSFormattedTextBox<ChangeInvoicingPointView>("8a6e90dd-466a-45da-b1f3-e0134d733a29","","",false, this);
 
            CreditInvoiceS = RPSControlFactory.CreateRPSFormattedTextBox<ChangeInvoicingPointView>("8223b3c8-934d-4702-9fd7-682b73dcfbde","","",false, this);
 
            DebitNoteS = RPSControlFactory.CreateRPSFormattedTextBox<ChangeInvoicingPointView>("efe7e9ec-97b2-42c5-8fc6-c4d32a1bf490","","",false, this);
 
            DeliveryNoteNoPrint = RPSControlFactory.CreateRPSFormattedTextBox<ChangeInvoicingPointView>("ee7d0b39-a2c7-4a55-a756-463f1b334a57","","",false, this);
 
            FrameworkContractS = RPSControlFactory.CreateRPSFormattedTextBox<ChangeInvoicingPointView>("57de4fff-e5a9-4b30-9663-e47b3d78eed0","","",false, this);
 
            AdvanceInvoice = RPSControlFactory.CreateRPSFormattedTextBox<ChangeInvoicingPointView>("90b07fe1-a01e-4a59-9c12-d433c93ec5bb","","",false, this);
 
            RetentionVoucher = RPSControlFactory.CreateRPSFormattedTextBox<ChangeInvoicingPointView>("c581d9a2-036e-4f3b-89f2-139d7d9e450a","","",false, this);
 
            InvoiceP = RPSControlFactory.CreateRPSFormattedTextBox<ChangeInvoicingPointView>("8f7add12-595c-4128-bbb0-c3d96a88cb78","","",false, this);
 
            ExecuteUpdateInvoicingPointCounters = RPSControlFactory.CreateRPSButton<ChangeInvoicingPointView>( "daaf9a08-6f7e-45ea-95cd-90e0986b65d5","","",this);
 

        }
        public IRPSComboBox<ChangeInvoicingPointView> IDInvoicingPoint { get; set; } 
        public IRPSTextBox<ChangeInvoicingPointView> SalesQuote { get; set; } 
        public IRPSTextBox<ChangeInvoicingPointView> OrderS { get; set; } 
        public IRPSTextBox<ChangeInvoicingPointView> DeliveryNoteS { get; set; } 
        public IRPSTextBox<ChangeInvoicingPointView> InvoiceS { get; set; } 
        public IRPSTextBox<ChangeInvoicingPointView> CreditInvoiceS { get; set; } 
        public IRPSTextBox<ChangeInvoicingPointView> DebitNoteS { get; set; } 
        public IRPSTextBox<ChangeInvoicingPointView> DeliveryNoteNoPrint { get; set; } 
        public IRPSTextBox<ChangeInvoicingPointView> FrameworkContractS { get; set; } 
        public IRPSTextBox<ChangeInvoicingPointView> AdvanceInvoice { get; set; } 
        public IRPSTextBox<ChangeInvoicingPointView> RetentionVoucher { get; set; } 
        public IRPSTextBox<ChangeInvoicingPointView> InvoiceP { get; set; } 
        public IRPSButton<ChangeInvoicingPointView> ExecuteUpdateInvoicingPointCounters { get; set; } 
        public ChangeInvoicingPoint Screen { get; set; }
        public ChangeInvoicingPointView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}