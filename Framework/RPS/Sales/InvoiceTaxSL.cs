    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.InvoiceTaxSL
{
    //RPS VERSION 1.0.0.0
    public partial class InvoiceTaxSL:Screen
    {
        public InvoiceTaxSL():base()
        {
            this.URL = "sales.invoicetaxsl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            InvoiceTaxSLQueryView  = new InvoiceTaxSLQueryView(this); 
            InvoiceTaxSLQueryView.InitializeControls(); 
           
        }
      
            public InvoiceTaxSLQueryView InvoiceTaxSLQueryView {get; set; } 
    }
            
    public partial class InvoiceTaxSLQueryView : View
    {
        public InvoiceTaxSLQueryView(InvoiceTaxSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Tax = RPSControlFactory.CreateRPSComboBox<InvoiceTaxSLQueryView>("1cb1347c-65a2-4679-84ce-051d787df88c","","",false, this);
 
            TaxValue = RPSControlFactory.CreateRPSCollectionComboBox<InvoiceTaxSLQueryView>("0f6d6c4b-3404-41aa-8d17-da335930acb3","","",false, this);
 
            InvoiceSL = RPSControlFactory.CreateRPSCollectionComboBox<InvoiceTaxSLQueryView>("bb8b2a39-6156-406e-b94d-ab3b53f6b5bb","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<InvoiceTaxSLQueryView>("aa9e5cc3-b710-4ede-aead-39f07ee104be","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<InvoiceTaxSLQueryView>("ce32b37c-c0f9-4b2e-a7de-96a716d0fbb2","","",false, this);
 
            InvoiceSL_InvoiceDate = RPSControlFactory.CreateRPSTextBox<InvoiceTaxSLQueryView>("7e3b7338-69e0-47c9-8789-342bdef089af","","",false, this);
 
            Base = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceTaxSLQueryView>("46d23409-8b2a-4738-9907-771a096173b2","","",false, this);
 
            VATAmount = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceTaxSLQueryView>("31541193-c393-4f56-b2c6-6d87e35cf824","","",false, this);
 
            SurchargeAmount = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceTaxSLQueryView>("6f67e1be-7263-4fa6-85ed-77cb2401f58f","","",false, this);
 
            Retention = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceTaxSLQueryView>("3c5a64d7-dd04-46bd-b087-24e84effb38f","","",false, this);
 
            TotalAdvanceInvoiced = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceTaxSLQueryView>("c3edf504-de39-4cd4-a387-c3504ae64f1e","","",false, this);
 
            TotalInvoice = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceTaxSLQueryView>("07b57133-aa44-44a6-a680-a1493c5f05fb","","",false, this);
 
            TaxValue_Description = RPSControlFactory.CreateRPSTextBox<InvoiceTaxSLQueryView>("aa329779-04c6-4fec-a042-7a41c9f27cb3","","",false, this);
 
            InvoiceTaxSL_Value = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceTaxSLQueryView>("66fcfe1c-3915-400e-81a1-070b54992236","","",false, this);
 
            TaxAmount = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceTaxSLQueryView>("5fc7d993-8f9c-43fc-886e-92da031f1b5a","","",false, this);
 
            CollectionInit params_InvoiceTaxSLQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="19d5058d-5e9a-408e-ae42-976f15784a9c",CSSSelectorGrid="",XPathGrid=""};
            InvoiceTaxSLQuery = RPSControlFactory.RPSCreateCollectionWithGrid<InvoiceTaxSLQueryCollectionEditor<InvoiceTaxSLQueryView>,InvoiceTaxSLQueryView>( params_InvoiceTaxSLQuery,this);
 

        }
        public IRPSComboBox<InvoiceTaxSLQueryView> Tax { get; set; } 
        public IRPSCollectionComboBox<InvoiceTaxSLQueryView> TaxValue { get; set; } 
        public IRPSCollectionComboBox<InvoiceTaxSLQueryView> InvoiceSL { get; set; } 
        public IRPSTextBox<InvoiceTaxSLQueryView> DateFrom { get; set; } 
        public IRPSTextBox<InvoiceTaxSLQueryView> DateTo { get; set; } 
        public IRPSTextBox<InvoiceTaxSLQueryView> InvoiceSL_InvoiceDate { get; set; } 
        public IRPSTextBox<InvoiceTaxSLQueryView> Base { get; set; } 
        public IRPSTextBox<InvoiceTaxSLQueryView> VATAmount { get; set; } 
        public IRPSTextBox<InvoiceTaxSLQueryView> SurchargeAmount { get; set; } 
        public IRPSTextBox<InvoiceTaxSLQueryView> Retention { get; set; } 
        public IRPSTextBox<InvoiceTaxSLQueryView> TotalAdvanceInvoiced { get; set; } 
        public IRPSTextBox<InvoiceTaxSLQueryView> TotalInvoice { get; set; } 
        public IRPSTextBox<InvoiceTaxSLQueryView> TaxValue_Description { get; set; } 
        public IRPSTextBox<InvoiceTaxSLQueryView> InvoiceTaxSL_Value { get; set; } 
        public IRPSTextBox<InvoiceTaxSLQueryView> TaxAmount { get; set; } 
        public InvoiceTaxSLQueryCollectionEditor<InvoiceTaxSLQueryView> InvoiceTaxSLQuery { get; set; } 
        public InvoiceTaxSL Screen { get; set; }
        public InvoiceTaxSLQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class InvoiceTaxSLQueryCollectionEditor<InvoiceTaxSLQueryView>:RPSCollectionEditor<InvoiceTaxSLQueryView> where InvoiceTaxSLQueryView : class, IView
    {
        public  InvoiceTaxSLQueryGridView<InvoiceTaxSLQueryView> GridView {get;set;}
    }
    public partial class InvoiceTaxSLQueryGridView <InvoiceTaxSLQueryView> :  RPSGridView<InvoiceTaxSLQueryView> where InvoiceTaxSLQueryView : class, IView
    {
        public InvoiceTaxSLQueryGridView(InvoiceTaxSLQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            InvoiceSL_InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<InvoiceTaxSLQueryView>("","#19d5058d-5e9a-408e-ae42-976f15784a9c .ag-row[role='row']@ROWINDEX [col-id='cInvoiceSL_InvoiceDate']","",false, this.CurrentView);
 
            TotalInvoice = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceTaxSLQueryView>("","#19d5058d-5e9a-408e-ae42-976f15784a9c .ag-row[role='row']@ROWINDEX [col-id='cTotalInvoice']","",false, this.CurrentView);
 
            TaxValue_Description = RPSControlFactory.CreateRPSGridTextBox<InvoiceTaxSLQueryView>("","#19d5058d-5e9a-408e-ae42-976f15784a9c .ag-row[role='row']@ROWINDEX [col-id='cTaxValue_Description']","",false, this.CurrentView);
 
            Base = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceTaxSLQueryView>("","#19d5058d-5e9a-408e-ae42-976f15784a9c .ag-row[role='row']@ROWINDEX [col-id='cBase']","",false, this.CurrentView);
 
            InvoiceTaxSL_Value = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceTaxSLQueryView>("","#19d5058d-5e9a-408e-ae42-976f15784a9c .ag-row[role='row']@ROWINDEX [col-id='cInvoiceTaxSL_Value']","",false, this.CurrentView);
 
            TaxAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceTaxSLQueryView>("","#19d5058d-5e9a-408e-ae42-976f15784a9c .ag-row[role='row']@ROWINDEX [col-id='cTaxAmount']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<InvoiceTaxSLQueryView> InvoiceSL_InvoiceDate { get; set; } 
        public IRPSGridTextBox<InvoiceTaxSLQueryView> TotalInvoice { get; set; } 
        public IRPSGridTextBox<InvoiceTaxSLQueryView> TaxValue_Description { get; set; } 
        public IRPSGridTextBox<InvoiceTaxSLQueryView> Base { get; set; } 
        public IRPSGridTextBox<InvoiceTaxSLQueryView> InvoiceTaxSL_Value { get; set; } 
        public IRPSGridTextBox<InvoiceTaxSLQueryView> TaxAmount { get; set; } 
                     
    }
 
    }
  
    

}