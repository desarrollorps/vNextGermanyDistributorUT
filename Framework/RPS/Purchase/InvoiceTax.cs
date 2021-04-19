    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.InvoiceTax
{
    //RPS VERSION 1.0.0.0
    public partial class InvoiceTax:Screen
    {
        public InvoiceTax():base()
        {
            this.URL = "purchase.invoicetax";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            InvoiceTaxQueryView  = new InvoiceTaxQueryView(this); 
            InvoiceTaxQueryView.InitializeControls(); 
           
        }
      
            public InvoiceTaxQueryView InvoiceTaxQueryView {get; set; } 
    }
            
    public partial class InvoiceTaxQueryView : View
    {
        public InvoiceTaxQueryView(InvoiceTax screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Tax = RPSControlFactory.CreateRPSComboBox<InvoiceTaxQueryView>("3e23b59e-e4f4-4b46-9bdb-fe21e1e537b7","","",false, this);
 
            TaxValue = RPSControlFactory.CreateRPSCollectionComboBox<InvoiceTaxQueryView>("c7184a11-a968-4a24-8e03-1909bea55d05","","",false, this);
 
            Invoice = RPSControlFactory.CreateRPSCollectionComboBox<InvoiceTaxQueryView>("7249dd5c-d131-4708-93fb-394d7cdc1b46","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<InvoiceTaxQueryView>("ac28d332-b9d0-42cf-9579-31b321d6b91b","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<InvoiceTaxQueryView>("fffbd36c-f2db-4a2e-9eff-d0040f7eed76","","",false, this);
 
            Invoice_InvoiceDate = RPSControlFactory.CreateRPSTextBox<InvoiceTaxQueryView>("b2108d36-a57b-43d6-af5c-54e029d6480c","","",false, this);
 
            InvoiceTax_Value = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceTaxQueryView>("a6a3f6de-9b39-489e-9f70-5eb4448dec84","","",false, this);
 
            CollectionInit params_InvoiceTaxQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d02556bb-198b-42b5-8c1a-4117a66543d8",CSSSelectorGrid="",XPathGrid=""};
            InvoiceTaxQuery = RPSControlFactory.RPSCreateCollectionWithGrid<InvoiceTaxQueryCollectionEditor<InvoiceTaxQueryView>,InvoiceTaxQueryView>( params_InvoiceTaxQuery,this);
 

        }
        public IRPSComboBox<InvoiceTaxQueryView> Tax { get; set; } 
        public IRPSCollectionComboBox<InvoiceTaxQueryView> TaxValue { get; set; } 
        public IRPSCollectionComboBox<InvoiceTaxQueryView> Invoice { get; set; } 
        public IRPSTextBox<InvoiceTaxQueryView> DateFrom { get; set; } 
        public IRPSTextBox<InvoiceTaxQueryView> DateTo { get; set; } 
        public IRPSTextBox<InvoiceTaxQueryView> Invoice_InvoiceDate { get; set; } 
        public IRPSTextBox<InvoiceTaxQueryView> InvoiceTax_Value { get; set; } 
        public InvoiceTaxQueryCollectionEditor<InvoiceTaxQueryView> InvoiceTaxQuery { get; set; } 
        public InvoiceTax Screen { get; set; }
        public InvoiceTaxQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class InvoiceTaxQueryCollectionEditor<InvoiceTaxQueryView>:RPSCollectionEditor<InvoiceTaxQueryView> where InvoiceTaxQueryView : class, IView
    {
        public  InvoiceTaxQueryGridView<InvoiceTaxQueryView> GridView {get;set;}
    }
    public partial class InvoiceTaxQueryGridView <InvoiceTaxQueryView> :  RPSGridView<InvoiceTaxQueryView> where InvoiceTaxQueryView : class, IView
    {
        public InvoiceTaxQueryGridView(InvoiceTaxQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Invoice_InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<InvoiceTaxQueryView>("","#d02556bb-198b-42b5-8c1a-4117a66543d8 .ag-row[role='row']@ROWINDEX [col-id='cInvoice_InvoiceDate']","",false, this.CurrentView);
 
            TaxValue_Description = RPSControlFactory.CreateRPSGridTextBox<InvoiceTaxQueryView>("","#d02556bb-198b-42b5-8c1a-4117a66543d8 .ag-row[role='row']@ROWINDEX [col-id='cTaxValue_Description']","",false, this.CurrentView);
 
            InvoiceTax_Value = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceTaxQueryView>("","#d02556bb-198b-42b5-8c1a-4117a66543d8 .ag-row[role='row']@ROWINDEX [col-id='cInvoiceTax_Value']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<InvoiceTaxQueryView> Invoice_InvoiceDate { get; set; } 
        public IRPSGridTextBox<InvoiceTaxQueryView> TaxValue_Description { get; set; } 
        public IRPSGridTextBox<InvoiceTaxQueryView> InvoiceTax_Value { get; set; } 
                     
    }
 
    }
  
    

}