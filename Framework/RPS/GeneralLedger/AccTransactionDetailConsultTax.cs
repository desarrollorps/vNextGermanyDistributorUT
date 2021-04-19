    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.AccTransactionDetailConsultTax
{
    //RPS VERSION 1.0.0.0
    public partial class AccTransactionDetailConsultTax:Screen
    {
        public AccTransactionDetailConsultTax():base()
        {
            this.URL = "generalledger.acctransactiondetailconsulttax";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            AccTransactionDetailConsultTaxQueryView  = new AccTransactionDetailConsultTaxQueryView(this); 
            AccTransactionDetailConsultTaxQueryView.InitializeControls(); 
           
        }
      
            public AccTransactionDetailConsultTaxQueryView AccTransactionDetailConsultTaxQueryView {get; set; } 
    }
            
    public partial class AccTransactionDetailConsultTaxQueryView : View
    {
        public AccTransactionDetailConsultTaxQueryView(AccTransactionDetailConsultTax screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            AccountingDateFrom = RPSControlFactory.CreateRPSTextBox<AccTransactionDetailConsultTaxQueryView>("06fb8bf0-1e03-4335-8859-e9aba8ce0682","","",false, this);
 
            AccountingDateTo = RPSControlFactory.CreateRPSTextBox<AccTransactionDetailConsultTaxQueryView>("4f5d17fe-74d7-476e-9583-8f5d3e13fe2a","","",false, this);
 
            InvoiceDateFrom = RPSControlFactory.CreateRPSTextBox<AccTransactionDetailConsultTaxQueryView>("63c12a5a-e5a4-46b1-8d33-c9cd01c13ba9","","",false, this);
 
            InvoiceDateTo = RPSControlFactory.CreateRPSTextBox<AccTransactionDetailConsultTaxQueryView>("85671e6d-2645-489a-911c-3b2d96cd749f","","",false, this);
 
            IDTax = RPSControlFactory.CreateRPSComboBox<AccTransactionDetailConsultTaxQueryView>("b2957010-f101-4c5e-b154-18b6921dca16","","",false, this);
 
            IDTaxValue = RPSControlFactory.CreateRPSComboBox<AccTransactionDetailConsultTaxQueryView>("58aaab02-bee8-44e9-8c5b-cf0872cf2ccc","","",false, this);
 
            RetentionSupplier = RPSControlFactory.CreateRPSCheckBox<AccTransactionDetailConsultTaxQueryView>("2e9ffe5f-ca2b-4898-9681-a66e0e453087","","",false, this);
 
            PurchaseTax = RPSControlFactory.CreateRPSCheckBox<AccTransactionDetailConsultTaxQueryView>("297caec9-0f0e-4760-88f1-4c00f42cae12","","",false, this);
 
            PurchasePenTax = RPSControlFactory.CreateRPSCheckBox<AccTransactionDetailConsultTaxQueryView>("ae85176c-dd73-47d6-9b1f-8d0189b560c1","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<AccTransactionDetailConsultTaxQueryView>("d7fc1fe9-d049-43c3-ba99-31a56d60f405","","",false, this);
 
            RetentionCustomer = RPSControlFactory.CreateRPSCheckBox<AccTransactionDetailConsultTaxQueryView>("5a3a6161-6b2c-47d5-979c-f93779c71c1b","","",false, this);
 
            SalesTax = RPSControlFactory.CreateRPSCheckBox<AccTransactionDetailConsultTaxQueryView>("934de047-9883-4165-a3b0-c7cf1225b8a9","","",false, this);
 
            SalesPenTax = RPSControlFactory.CreateRPSCheckBox<AccTransactionDetailConsultTaxQueryView>("7d09a460-9099-43d3-89fd-d4eecfdb5863","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<AccTransactionDetailConsultTaxQueryView>("34c98361-5951-46ed-b161-e99b36027211","","",false, this);
 
            AllRenting = RPSControlFactory.CreateRPSOption<AccTransactionDetailConsultTaxQueryView>( "26db5cbc-3097-4195-9310-b2d4fac09989","","",this);
 
            NoRenting = RPSControlFactory.CreateRPSOption<AccTransactionDetailConsultTaxQueryView>( "00e3fdcb-9e6b-4da3-b094-48967d9a6a65","","",this);
 
            OnlyRenting = RPSControlFactory.CreateRPSOption<AccTransactionDetailConsultTaxQueryView>( "e2ef7ac2-1a1f-43b5-bb7d-8f63d59980f5","","",this);
 
            SelRenting = RPSControlFactory.CreateRPSOption<AccTransactionDetailConsultTaxQueryView>( "4b490c4d-82ea-4e98-92ed-cdca4ed06d6c","","",this);
 
            IDFixedAsset = RPSControlFactory.CreateRPSComboBox<AccTransactionDetailConsultTaxQueryView>("c14f6828-5755-4a04-b308-d7ff3df4f2d2","","",false, this);
 
            InvoiceDate = RPSControlFactory.CreateRPSTextBox<AccTransactionDetailConsultTaxQueryView>("1ad5e0e0-45e5-436c-b8a0-53a2e5c50d1d","","",false, this);
 
            ACCTransactionsDetail_MovementType = RPSControlFactory.CreateRPSTextBox<AccTransactionDetailConsultTaxQueryView>("c1b74619-b544-4aaa-a61a-b203769ff7ec","","",false, this);
 
            ACCTransactionsDetail_SignType = RPSControlFactory.CreateRPSTextBox<AccTransactionDetailConsultTaxQueryView>("f2f1a0bf-d0d3-4291-974a-737a0eeead9b","","",false, this);
 
            ACCTransactionsDetail_Extension = RPSControlFactory.CreateRPSTextBox<AccTransactionDetailConsultTaxQueryView>("868aebbb-dc03-4b2a-ac93-34cc0100d546","","",false, this);
 
            ACCTransactions_Key = RPSControlFactory.CreateRPSTextBox<AccTransactionDetailConsultTaxQueryView>("b05ee590-eeda-408d-b5ed-9628f75caa94","","",false, this);
 
            ACCTransactions_SubKey = RPSControlFactory.CreateRPSTextBox<AccTransactionDetailConsultTaxQueryView>("afbf2b29-ce4c-4b82-ab47-b7e469242989","","",false, this);
 
            ACCTransactions_Renting = RPSControlFactory.CreateRPSCheckBox<AccTransactionDetailConsultTaxQueryView>("b4b416a7-d58a-423d-8158-893767f78266","","",false, this);
 
            CollectionInit params_TransactionsDetailConsultTax = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="2f9f3a14-671f-4216-ae8d-a69f0afbcffa",CSSSelectorGrid="",XPathGrid=""};
            TransactionsDetailConsultTax = RPSControlFactory.RPSCreateCollectionWithGrid<TransactionsDetailConsultTaxCollectionEditor<AccTransactionDetailConsultTaxQueryView>,AccTransactionDetailConsultTaxQueryView>( params_TransactionsDetailConsultTax,this);
 

        }
        public IRPSTextBox<AccTransactionDetailConsultTaxQueryView> AccountingDateFrom { get; set; } 
        public IRPSTextBox<AccTransactionDetailConsultTaxQueryView> AccountingDateTo { get; set; } 
        public IRPSTextBox<AccTransactionDetailConsultTaxQueryView> InvoiceDateFrom { get; set; } 
        public IRPSTextBox<AccTransactionDetailConsultTaxQueryView> InvoiceDateTo { get; set; } 
        public IRPSComboBox<AccTransactionDetailConsultTaxQueryView> IDTax { get; set; } 
        public IRPSComboBox<AccTransactionDetailConsultTaxQueryView> IDTaxValue { get; set; } 
        public IRPSCheckbox<AccTransactionDetailConsultTaxQueryView> RetentionSupplier { get; set; } 
        public IRPSCheckbox<AccTransactionDetailConsultTaxQueryView> PurchaseTax { get; set; } 
        public IRPSCheckbox<AccTransactionDetailConsultTaxQueryView> PurchasePenTax { get; set; } 
        public IRPSComboBox<AccTransactionDetailConsultTaxQueryView> IDSupplier { get; set; } 
        public IRPSCheckbox<AccTransactionDetailConsultTaxQueryView> RetentionCustomer { get; set; } 
        public IRPSCheckbox<AccTransactionDetailConsultTaxQueryView> SalesTax { get; set; } 
        public IRPSCheckbox<AccTransactionDetailConsultTaxQueryView> SalesPenTax { get; set; } 
        public IRPSComboBox<AccTransactionDetailConsultTaxQueryView> IDCustomer { get; set; } 
        public IRPSOption<AccTransactionDetailConsultTaxQueryView> AllRenting { get; set; } 
        public IRPSOption<AccTransactionDetailConsultTaxQueryView> NoRenting { get; set; } 
        public IRPSOption<AccTransactionDetailConsultTaxQueryView> OnlyRenting { get; set; } 
        public IRPSOption<AccTransactionDetailConsultTaxQueryView> SelRenting { get; set; } 
        public IRPSComboBox<AccTransactionDetailConsultTaxQueryView> IDFixedAsset { get; set; } 
        public IRPSTextBox<AccTransactionDetailConsultTaxQueryView> InvoiceDate { get; set; } 
        public IRPSTextBox<AccTransactionDetailConsultTaxQueryView> ACCTransactionsDetail_MovementType { get; set; } 
        public IRPSTextBox<AccTransactionDetailConsultTaxQueryView> ACCTransactionsDetail_SignType { get; set; } 
        public IRPSTextBox<AccTransactionDetailConsultTaxQueryView> ACCTransactionsDetail_Extension { get; set; } 
        public IRPSTextBox<AccTransactionDetailConsultTaxQueryView> ACCTransactions_Key { get; set; } 
        public IRPSTextBox<AccTransactionDetailConsultTaxQueryView> ACCTransactions_SubKey { get; set; } 
        public IRPSCheckbox<AccTransactionDetailConsultTaxQueryView> ACCTransactions_Renting { get; set; } 
        public TransactionsDetailConsultTaxCollectionEditor<AccTransactionDetailConsultTaxQueryView> TransactionsDetailConsultTax { get; set; } 
        public AccTransactionDetailConsultTax Screen { get; set; }
        public AccTransactionDetailConsultTaxQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class TransactionsDetailConsultTaxCollectionEditor<AccTransactionDetailConsultTaxQueryView>:RPSCollectionEditor<AccTransactionDetailConsultTaxQueryView> where AccTransactionDetailConsultTaxQueryView : class, IView
    {
        public  TransactionsDetailConsultTaxGridView<AccTransactionDetailConsultTaxQueryView> GridView {get;set;}
    }
    public partial class TransactionsDetailConsultTaxGridView <AccTransactionDetailConsultTaxQueryView> :  RPSGridView<AccTransactionDetailConsultTaxQueryView> where AccTransactionDetailConsultTaxQueryView : class, IView
    {
        public TransactionsDetailConsultTaxGridView(AccTransactionDetailConsultTaxQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ACCTransactionsDetail_MovementType = RPSControlFactory.CreateRPSGridTextBox<AccTransactionDetailConsultTaxQueryView>("","#2f9f3a14-671f-4216-ae8d-a69f0afbcffa .ag-row[role='row']@ROWINDEX [col-id='cACCTransactionsDetail_MovementType']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<AccTransactionDetailConsultTaxQueryView>("","#2f9f3a14-671f-4216-ae8d-a69f0afbcffa .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 
            ACCTransactionsDetail_SignType = RPSControlFactory.CreateRPSGridTextBox<AccTransactionDetailConsultTaxQueryView>("","#2f9f3a14-671f-4216-ae8d-a69f0afbcffa .ag-row[role='row']@ROWINDEX [col-id='cACCTransactionsDetail_SignType']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<AccTransactionDetailConsultTaxQueryView> ACCTransactionsDetail_MovementType { get; set; } 
        public IRPSGridTextBox<AccTransactionDetailConsultTaxQueryView> InvoiceDate { get; set; } 
        public IRPSGridTextBox<AccTransactionDetailConsultTaxQueryView> ACCTransactionsDetail_SignType { get; set; } 
                     
    }
 
    }
  
    

}