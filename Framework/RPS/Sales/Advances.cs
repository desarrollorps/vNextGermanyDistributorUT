    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.Advances
{
    //RPS VERSION 1.0.0.0
    public partial class Advances:Screen
    {
        public Advances():base()
        {
            this.URL = "sales.advances";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            AdvancesView  = new AdvancesView(this); 
            AdvancesView.InitializeControls(); 
           
        }
      
            public AdvancesView AdvancesView {get; set; } 
    }
            
    public partial class AdvancesView : View
    {
        public AdvancesView(Advances screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UILstCustomer = RPSControlFactory.CreateRPSCollectionComboBox<AdvancesView>("fe8f49c9-8e86-4d6f-9b82-af128fed68ee","","",false, this);
 
            UILstInvoicingTypeSL = RPSControlFactory.CreateRPSCollectionComboBox<AdvancesView>("19b292a8-46fa-41ad-be2b-8b869e6ffdcc","","",false, this);
 
            UILstCurrency = RPSControlFactory.CreateRPSCollectionComboBox<AdvancesView>("38a27394-5394-4ded-ad96-f987ea5b0233","","",false, this);
 
            UILstOrderSL = RPSControlFactory.CreateRPSCollectionComboBox<AdvancesView>("f96606bf-9bf2-4e9b-9899-5f30ceb2eed0","","",false, this);
 
            UIOrderPrepaymentFrom = RPSControlFactory.CreateRPSFormattedTextBox<AdvancesView>("a38b87fb-5785-4199-9354-aac3bcd60bce","","",false, this);
 
            UIOrderPrepaymentTo = RPSControlFactory.CreateRPSFormattedTextBox<AdvancesView>("f3f0821b-185c-4775-a15f-39bc83c01b0a","","",false, this);
 
            UIPrepaymentDateFrom = RPSControlFactory.CreateRPSTextBox<AdvancesView>("6063859a-175e-4339-97c4-d1527eaaec60","","",false, this);
 
            UIPrepaymentDateTo = RPSControlFactory.CreateRPSTextBox<AdvancesView>("850416ae-045b-4d18-aac0-51a5e7852f11","","",false, this);
 
            UIInvoiceDate = RPSControlFactory.CreateRPSTextBox<AdvancesView>("42ee77ae-235d-4145-bf03-8a1ce3739da2","","",false, this);
 
            UIUpdateInvoices = RPSControlFactory.CreateRPSCheckBox<AdvancesView>("612ed49c-013d-4f84-96a3-6fa7fa76ed08","","",false, this);
 
            ShowPrintOptionsCommand = RPSControlFactory.CreateRPSButton<AdvancesView>( "51be8116-da33-4961-bfdd-bde925b15495","","",this);
 
            ShowPrintOptionsFinalCommand = RPSControlFactory.CreateRPSButton<AdvancesView>( "aceec521-5fc5-4f82-b4b9-f9b47c4fa2ef","","",this);
 
            CollectionInit params_InvoiceTempForAdvances = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="30950791-87ca-4fe5-9ad5-71d44952410d",CSSSelectorGrid="",XPathGrid=""};
            InvoiceTempForAdvances = RPSControlFactory.RPSCreateCollectionWithGrid<InvoiceTempForAdvancesCollectionEditor<AdvancesView>,AdvancesView>( params_InvoiceTempForAdvances,this);
 
            CollectionInit params_InvoiceTempForAdvancesSaved = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="effed1c1-72a6-4eff-bb42-501913358dd9",CSSSelectorGrid="",XPathGrid=""};
            InvoiceTempForAdvancesSaved = RPSControlFactory.RPSCreateCollectionWithGrid<InvoiceTempForAdvancesSavedCollectionEditor<AdvancesView>,AdvancesView>( params_InvoiceTempForAdvancesSaved,this);
 

        }
        public IRPSCollectionComboBox<AdvancesView> UILstCustomer { get; set; } 
        public IRPSCollectionComboBox<AdvancesView> UILstInvoicingTypeSL { get; set; } 
        public IRPSCollectionComboBox<AdvancesView> UILstCurrency { get; set; } 
        public IRPSCollectionComboBox<AdvancesView> UILstOrderSL { get; set; } 
        public IRPSTextBox<AdvancesView> UIOrderPrepaymentFrom { get; set; } 
        public IRPSTextBox<AdvancesView> UIOrderPrepaymentTo { get; set; } 
        public IRPSTextBox<AdvancesView> UIPrepaymentDateFrom { get; set; } 
        public IRPSTextBox<AdvancesView> UIPrepaymentDateTo { get; set; } 
        public IRPSTextBox<AdvancesView> UIInvoiceDate { get; set; } 
        public IRPSCheckbox<AdvancesView> UIUpdateInvoices { get; set; } 
        public IRPSButton<AdvancesView> ShowPrintOptionsCommand { get; set; } 
        public IRPSButton<AdvancesView> ShowPrintOptionsFinalCommand { get; set; } 
        public InvoiceTempForAdvancesCollectionEditor<AdvancesView> InvoiceTempForAdvances { get; set; } 
        public InvoiceTempForAdvancesSavedCollectionEditor<AdvancesView> InvoiceTempForAdvancesSaved { get; set; } 
        public Advances Screen { get; set; }
        public AdvancesView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class InvoiceTempForAdvancesCollectionEditor<AdvancesView>:RPSCollectionEditor<AdvancesView> where AdvancesView : class, IView
    {
        public  InvoiceTempForAdvancesGridView<AdvancesView> GridView {get;set;}
    }
    public partial class InvoiceTempForAdvancesGridView <AdvancesView> :  RPSGridView<AdvancesView> where AdvancesView : class, IView
    {
        public InvoiceTempForAdvancesGridView(AdvancesView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodInvoice = RPSControlFactory.CreateRPSGridTextBox<AdvancesView>("","#30950791-87ca-4fe5-9ad5-71d44952410d .ag-row[role='row']@ROWINDEX [col-id='cCodInvoice']","",false, this.CurrentView);
 
            DecriptionCustomer = RPSControlFactory.CreateRPSGridTextBox<AdvancesView>("","#30950791-87ca-4fe5-9ad5-71d44952410d .ag-row[role='row']@ROWINDEX [col-id='cDecriptionCustomer']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<AdvancesView>("","#30950791-87ca-4fe5-9ad5-71d44952410d .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 
            Base = RPSControlFactory.CreateRPSGridFormattedTextBox<AdvancesView>("","#30950791-87ca-4fe5-9ad5-71d44952410d .ag-row[role='row']@ROWINDEX [col-id='cBase']","",false, this.CurrentView);
 
            VAT = RPSControlFactory.CreateRPSGridFormattedTextBox<AdvancesView>("","#30950791-87ca-4fe5-9ad5-71d44952410d .ag-row[role='row']@ROWINDEX [col-id='cVAT']","",false, this.CurrentView);
 
            Total = RPSControlFactory.CreateRPSGridFormattedTextBox<AdvancesView>("","#30950791-87ca-4fe5-9ad5-71d44952410d .ag-row[role='row']@ROWINDEX [col-id='cTotal']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<AdvancesView> CodInvoice { get; set; } 
        public IRPSGridTextBox<AdvancesView> DecriptionCustomer { get; set; } 
        public IRPSGridTextBox<AdvancesView> InvoiceDate { get; set; } 
        public IRPSGridTextBox<AdvancesView> Base { get; set; } 
        public IRPSGridTextBox<AdvancesView> VAT { get; set; } 
        public IRPSGridTextBox<AdvancesView> Total { get; set; } 
                     
    }
 
        public partial class InvoiceTempForAdvancesSavedCollectionEditor<AdvancesView>:RPSCollectionEditor<AdvancesView> where AdvancesView : class, IView
    {
        public  InvoiceTempForAdvancesSavedGridView<AdvancesView> GridView {get;set;}
    }
    public partial class InvoiceTempForAdvancesSavedGridView <AdvancesView> :  RPSGridView<AdvancesView> where AdvancesView : class, IView
    {
        public InvoiceTempForAdvancesSavedGridView(AdvancesView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DecriptionCustomer = RPSControlFactory.CreateRPSGridTextBox<AdvancesView>("","#effed1c1-72a6-4eff-bb42-501913358dd9 .ag-row[role='row']@ROWINDEX [col-id='cDecriptionCustomer']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<AdvancesView>("","#effed1c1-72a6-4eff-bb42-501913358dd9 .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 
            Base = RPSControlFactory.CreateRPSGridFormattedTextBox<AdvancesView>("","#effed1c1-72a6-4eff-bb42-501913358dd9 .ag-row[role='row']@ROWINDEX [col-id='cBase']","",false, this.CurrentView);
 
            VAT = RPSControlFactory.CreateRPSGridFormattedTextBox<AdvancesView>("","#effed1c1-72a6-4eff-bb42-501913358dd9 .ag-row[role='row']@ROWINDEX [col-id='cVAT']","",false, this.CurrentView);
 
            Total = RPSControlFactory.CreateRPSGridFormattedTextBox<AdvancesView>("","#effed1c1-72a6-4eff-bb42-501913358dd9 .ag-row[role='row']@ROWINDEX [col-id='cTotal']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<AdvancesView> DecriptionCustomer { get; set; } 
        public IRPSGridTextBox<AdvancesView> InvoiceDate { get; set; } 
        public IRPSGridTextBox<AdvancesView> Base { get; set; } 
        public IRPSGridTextBox<AdvancesView> VAT { get; set; } 
        public IRPSGridTextBox<AdvancesView> Total { get; set; } 
                     
    }
 
    }
  
    

}