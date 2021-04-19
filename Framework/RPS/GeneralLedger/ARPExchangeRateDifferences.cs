    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.ARPExchangeRateDifferences
{
    //RPS VERSION 1.0.0.0
    public partial class ARPExchangeRateDifferences:Screen
    {
        public ARPExchangeRateDifferences():base()
        {
            this.URL = "generalledger.arpexchangeratedifferences";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ARPExchangeRateDifferencesView  = new ARPExchangeRateDifferencesView(this); 
            ARPExchangeRateDifferencesView.InitializeControls(); 
           
        }
      
            public ARPExchangeRateDifferencesView ARPExchangeRateDifferencesView {get; set; } 
    }
            
    public partial class ARPExchangeRateDifferencesView : View
    {
        public ARPExchangeRateDifferencesView(ARPExchangeRateDifferences screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DateTo = RPSControlFactory.CreateRPSTextBox<ARPExchangeRateDifferencesView>("4aaaee4d-8889-4e24-9f31-606506762ee1","","",false, this);
 
            Currency = RPSControlFactory.CreateRPSComboBox<ARPExchangeRateDifferencesView>("dad67b33-5710-45e4-abca-256f25d2077d","","",true, this);
 
            CheckCustomers = RPSControlFactory.CreateRPSCheckBox<ARPExchangeRateDifferencesView>("d552f86e-2fab-473e-8be7-2dc9e1505d1f","","",false, this);
 
            SalesCurrencyExchangeRate = RPSControlFactory.CreateRPSFormattedTextBox<ARPExchangeRateDifferencesView>("6f652beb-54cb-423d-a1b9-6d0feb9ad431","","",false, this);
 
            CheckSuppliers = RPSControlFactory.CreateRPSCheckBox<ARPExchangeRateDifferencesView>("b4d5a0d9-fbe8-4107-8e2f-73c07ca97a0f","","",false, this);
 
            PurchaseCurrencyExchangeRate = RPSControlFactory.CreateRPSFormattedTextBox<ARPExchangeRateDifferencesView>("1114414f-afc8-4132-bd67-4cc7b8883a66","","",false, this);
 
            DifferenceAmount = RPSControlFactory.CreateRPSFormattedTextBox<ARPExchangeRateDifferencesView>("06163a37-a967-401d-b2c6-0bd4d176aaac","","",false, this);
 
            LossAccount = RPSControlFactory.CreateRPSComboBox<ARPExchangeRateDifferencesView>("f09fd8cd-d0f3-4b79-bc67-40a90151cd03","","",true, this);
 
            ProfitAccount = RPSControlFactory.CreateRPSComboBox<ARPExchangeRateDifferencesView>("a00b1d18-10c4-496a-9d93-92a3dcfe954b","","",true, this);
 
            VoucherType = RPSControlFactory.CreateRPSComboBox<ARPExchangeRateDifferencesView>("1b8555b5-47d1-4452-86ab-65a213542f7a","","",true, this);
 
            VoucherSeriesBook = RPSControlFactory.CreateRPSComboBox<ARPExchangeRateDifferencesView>("23ade3a4-6163-4743-816e-062b83966366","","",true, this);
 
            AccConcept = RPSControlFactory.CreateRPSComboBox<ARPExchangeRateDifferencesView>("36b3965c-6162-4be6-93a7-9959c738b193","","",true, this);
 
            Extension = RPSControlFactory.CreateRPSTextBox<ARPExchangeRateDifferencesView>("f1fea469-248d-4109-9de1-8fad436139e3","","",false, this);
 
            VoucherDate = RPSControlFactory.CreateRPSTextBox<ARPExchangeRateDifferencesView>("01a2d97a-4e12-4c74-be22-8f14d2744da3","","",false, this);
 
            CheckReverseVoucher = RPSControlFactory.CreateRPSCheckBox<ARPExchangeRateDifferencesView>("da354de9-13bc-4421-89a2-8de3dea9ccb3","","",false, this);
 
            ReverseDate = RPSControlFactory.CreateRPSTextBox<ARPExchangeRateDifferencesView>("bd54a7b7-3bc8-4887-be6d-ea4624251ac5","","",false, this);
 
            CollectionInit params_RetrieveCustomerTransactionsDetail = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="39a85570-a5f7-4974-95a9-45b69b015670",CSSSelectorGrid="",XPathGrid=""};
            RetrieveCustomerTransactionsDetail = RPSControlFactory.RPSCreateCollectionWithGrid<RetrieveCustomerTransactionsDetailCollectionEditor<ARPExchangeRateDifferencesView>,ARPExchangeRateDifferencesView>( params_RetrieveCustomerTransactionsDetail,this);
 
            CollectionInit params_RetrieveSupplierTransactionsDetail = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1cc192fa-9b68-4d74-8de6-9577420f20ce",CSSSelectorGrid="",XPathGrid=""};
            RetrieveSupplierTransactionsDetail = RPSControlFactory.RPSCreateCollectionWithGrid<RetrieveSupplierTransactionsDetailCollectionEditor<ARPExchangeRateDifferencesView>,ARPExchangeRateDifferencesView>( params_RetrieveSupplierTransactionsDetail,this);
 

        }
        public IRPSTextBox<ARPExchangeRateDifferencesView> DateTo { get; set; } 
        public IRPSComboBox<ARPExchangeRateDifferencesView> Currency { get; set; } 
        public IRPSCheckbox<ARPExchangeRateDifferencesView> CheckCustomers { get; set; } 
        public IRPSTextBox<ARPExchangeRateDifferencesView> SalesCurrencyExchangeRate { get; set; } 
        public IRPSCheckbox<ARPExchangeRateDifferencesView> CheckSuppliers { get; set; } 
        public IRPSTextBox<ARPExchangeRateDifferencesView> PurchaseCurrencyExchangeRate { get; set; } 
        public IRPSTextBox<ARPExchangeRateDifferencesView> DifferenceAmount { get; set; } 
        public IRPSComboBox<ARPExchangeRateDifferencesView> LossAccount { get; set; } 
        public IRPSComboBox<ARPExchangeRateDifferencesView> ProfitAccount { get; set; } 
        public IRPSComboBox<ARPExchangeRateDifferencesView> VoucherType { get; set; } 
        public IRPSComboBox<ARPExchangeRateDifferencesView> VoucherSeriesBook { get; set; } 
        public IRPSComboBox<ARPExchangeRateDifferencesView> AccConcept { get; set; } 
        public IRPSTextBox<ARPExchangeRateDifferencesView> Extension { get; set; } 
        public IRPSTextBox<ARPExchangeRateDifferencesView> VoucherDate { get; set; } 
        public IRPSCheckbox<ARPExchangeRateDifferencesView> CheckReverseVoucher { get; set; } 
        public IRPSTextBox<ARPExchangeRateDifferencesView> ReverseDate { get; set; } 
        public RetrieveCustomerTransactionsDetailCollectionEditor<ARPExchangeRateDifferencesView> RetrieveCustomerTransactionsDetail { get; set; } 
        public RetrieveSupplierTransactionsDetailCollectionEditor<ARPExchangeRateDifferencesView> RetrieveSupplierTransactionsDetail { get; set; } 
        public ARPExchangeRateDifferences Screen { get; set; }
        public ARPExchangeRateDifferencesView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class RetrieveCustomerTransactionsDetailCollectionEditor<ARPExchangeRateDifferencesView>:RPSCollectionEditor<ARPExchangeRateDifferencesView> where ARPExchangeRateDifferencesView : class, IView
    {
        public  RetrieveCustomerTransactionsDetailGridView<ARPExchangeRateDifferencesView> GridView {get;set;}
    }
    public partial class RetrieveCustomerTransactionsDetailGridView <ARPExchangeRateDifferencesView> :  RPSGridView<ARPExchangeRateDifferencesView> where ARPExchangeRateDifferencesView : class, IView
    {
        public RetrieveCustomerTransactionsDetailGridView(ARPExchangeRateDifferencesView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {

        }
                     
    }
 
        public partial class RetrieveSupplierTransactionsDetailCollectionEditor<ARPExchangeRateDifferencesView>:RPSCollectionEditor<ARPExchangeRateDifferencesView> where ARPExchangeRateDifferencesView : class, IView
    {
        public  RetrieveSupplierTransactionsDetailGridView<ARPExchangeRateDifferencesView> GridView {get;set;}
    }
    public partial class RetrieveSupplierTransactionsDetailGridView <ARPExchangeRateDifferencesView> :  RPSGridView<ARPExchangeRateDifferencesView> where ARPExchangeRateDifferencesView : class, IView
    {
        public RetrieveSupplierTransactionsDetailGridView(ARPExchangeRateDifferencesView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {

        }
                     
    }
 
    }
  
    

}