    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.CurrentBalances
{
    //RPS VERSION 1.0.0.0
    public partial class CurrentBalances:Screen
    {
        public CurrentBalances():base()
        {
            this.URL = "generalledger.currentbalances";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CurrentBalancesQueryView  = new CurrentBalancesQueryView(this); 
            CurrentBalancesQueryView.InitializeControls(); 
           
        }
      
            public CurrentBalancesQueryView CurrentBalancesQueryView {get; set; } 
    }
            
    public partial class CurrentBalancesQueryView : View
    {
        public CurrentBalancesQueryView(CurrentBalances screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            bSales = RPSControlFactory.CreateRPSCheckBox<CurrentBalancesQueryView>("cfaaaf82-b23f-43b8-bb03-933f79cd5245","","",false, this);
 
            bPurchase = RPSControlFactory.CreateRPSCheckBox<CurrentBalancesQueryView>("094ca18d-26e8-43b7-bd63-bda569e0a3b2","","",false, this);
 
            CodInvoice = RPSControlFactory.CreateRPSTextBox<CurrentBalancesQueryView>("d35d6249-6a90-4c15-a5fd-2f297283a508","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<CurrentBalancesQueryView>("72fd0478-8afe-4543-af9c-ee7c3cfef30c","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<CurrentBalancesQueryView>("36dabe7e-f4c2-4c17-a2b0-dc8a218ac7d5","","",false, this);
 
            IDCustomers = RPSControlFactory.CreateRPSCollectionComboBox<CurrentBalancesQueryView>("6510852f-2bb4-4e32-8c7e-248d2bc8550f","","",false, this);
 
            IDSuppliers = RPSControlFactory.CreateRPSCollectionComboBox<CurrentBalancesQueryView>("b4462c43-fec9-44b7-8326-7d97c45d5351","","",false, this);
 
            Nullified = RPSControlFactory.CreateRPSCheckBox<CurrentBalancesQueryView>("67a9e682-58c4-4c93-9267-c8a35594eedc","","",false, this);
 
            OnlyPendingInvoices = RPSControlFactory.CreateRPSCheckBox<CurrentBalancesQueryView>("a9d7867e-df91-4813-aa89-dd6fe53f3e0d","","",false, this);
 
            IDAccountList = RPSControlFactory.CreateRPSCollectionComboBox<CurrentBalancesQueryView>("2f7ce677-5134-4b96-8299-a2a89ed18b87","","",false, this);
 
            IDAccountGroupList = RPSControlFactory.CreateRPSCollectionComboBox<CurrentBalancesQueryView>("51e6bec3-e901-4dc6-93e4-cf72b7306b7b","","",false, this);
 
            IDAccountClusterList = RPSControlFactory.CreateRPSCollectionComboBox<CurrentBalancesQueryView>("aa5dfa59-5eb7-4657-856a-53aee9ab4798","","",false, this);
 
            CustomerSupplier = RPSControlFactory.CreateRPSTextBox<CurrentBalancesQueryView>("82bece1f-20c7-4dc5-be91-d9f96b3a6a3e","","",false, this);
 
            InvoiceDate = RPSControlFactory.CreateRPSTextBox<CurrentBalancesQueryView>("1030227b-ccdb-41b6-b68c-20879084e106","","",false, this);
 
            IsNullified = RPSControlFactory.CreateRPSCheckBox<CurrentBalancesQueryView>("75862570-0843-4e90-bf83-c89f86d88f1a","","",false, this);
 
            CollectionInit params_CurrentBalances = new CollectionInit(){IDDescriptor = "44badaf5-dcc1-4ab3-a406-7c9e6c8fa741",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="01a787af-2287-4b39-adc0-ef22441af65f",CSSSelectorGrid="",XPathGrid=""};
            CurrentBalances = RPSControlFactory.RPSCreateCollectionWithGrid<CurrentBalancesCollectionEditor<CurrentBalancesQueryView>,CurrentBalancesQueryView>( params_CurrentBalances,this);
 
            CollectionInit params_GetDraftsFromInvoice = new CollectionInit(){IDDescriptor = "44badaf5-dcc1-4ab3-a406-7c9e6c8fa741",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5f118fd7-bd3a-488f-8c82-f7513671a2e8",CSSSelectorGrid="",XPathGrid=""};
            GetDraftsFromInvoice = RPSControlFactory.RPSCreateCollectionWithGrid<GetDraftsFromInvoiceCollectionEditor<CurrentBalancesQueryView>,CurrentBalancesQueryView>( params_GetDraftsFromInvoice,this);
 
            CollectionInit params_TransactionsInformation = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="2c60d5e9-1c01-4534-8d58-b29a9b557b3f",CSSSelectorGrid="",XPathGrid=""};
            TransactionsInformation = RPSControlFactory.RPSCreateCollectionWithGrid<TransactionsInformationCollectionEditor<CurrentBalancesQueryView>,CurrentBalancesQueryView>( params_TransactionsInformation,this);
 
            SectionDrafts = RPSControlFactory.CreateRPSSection<CurrentBalancesQueryView>( "","ul li[rpsid='f18906fe-34f8-4756-aab5-03b4af56422b']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<CurrentBalancesQueryView>( "","ul li[rpsid='90e604e4-c5a4-4c89-a028-e6343c5f49e8']","",this);
 

        }
        public IRPSCheckbox<CurrentBalancesQueryView> bSales { get; set; } 
        public IRPSCheckbox<CurrentBalancesQueryView> bPurchase { get; set; } 
        public IRPSTextBox<CurrentBalancesQueryView> CodInvoice { get; set; } 
        public IRPSTextBox<CurrentBalancesQueryView> DateFrom { get; set; } 
        public IRPSTextBox<CurrentBalancesQueryView> DateTo { get; set; } 
        public IRPSCollectionComboBox<CurrentBalancesQueryView> IDCustomers { get; set; } 
        public IRPSCollectionComboBox<CurrentBalancesQueryView> IDSuppliers { get; set; } 
        public IRPSCheckbox<CurrentBalancesQueryView> Nullified { get; set; } 
        public IRPSCheckbox<CurrentBalancesQueryView> OnlyPendingInvoices { get; set; } 
        public IRPSCollectionComboBox<CurrentBalancesQueryView> IDAccountList { get; set; } 
        public IRPSCollectionComboBox<CurrentBalancesQueryView> IDAccountGroupList { get; set; } 
        public IRPSCollectionComboBox<CurrentBalancesQueryView> IDAccountClusterList { get; set; } 
        public IRPSTextBox<CurrentBalancesQueryView> CustomerSupplier { get; set; } 
        public IRPSTextBox<CurrentBalancesQueryView> InvoiceDate { get; set; } 
        public IRPSCheckbox<CurrentBalancesQueryView> IsNullified { get; set; } 
        public CurrentBalancesCollectionEditor<CurrentBalancesQueryView> CurrentBalances { get; set; } 
        public GetDraftsFromInvoiceCollectionEditor<CurrentBalancesQueryView> GetDraftsFromInvoice { get; set; } 
        public TransactionsInformationCollectionEditor<CurrentBalancesQueryView> TransactionsInformation { get; set; } 
        public IRPSSection<CurrentBalancesQueryView> SectionDrafts { get; set; } 
        public IRPSSection<CurrentBalancesQueryView> Section1 { get; set; } 
        public CurrentBalances Screen { get; set; }
        public CurrentBalancesQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CurrentBalancesCollectionEditor<CurrentBalancesQueryView>:RPSCollectionEditor<CurrentBalancesQueryView> where CurrentBalancesQueryView : class, IView
    {
        public  CurrentBalancesGridView<CurrentBalancesQueryView> GridView {get;set;}
    }
    public partial class CurrentBalancesGridView <CurrentBalancesQueryView> :  RPSGridView<CurrentBalancesQueryView> where CurrentBalancesQueryView : class, IView
    {
        public CurrentBalancesGridView(CurrentBalancesQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CustomerSupplier = RPSControlFactory.CreateRPSGridTextBox<CurrentBalancesQueryView>("","#01a787af-2287-4b39-adc0-ef22441af65f .ag-row[role='row']@ROWINDEX [col-id='cCustomerSupplier']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<CurrentBalancesQueryView>("","#01a787af-2287-4b39-adc0-ef22441af65f .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 
            IsNullified = RPSControlFactory.CreateRPSGridCheckBox<CurrentBalancesQueryView>("","#01a787af-2287-4b39-adc0-ef22441af65f .ag-row[role='row']@ROWINDEX [col-id='cIsNullified']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CurrentBalancesQueryView> CustomerSupplier { get; set; } 
        public IRPSGridTextBox<CurrentBalancesQueryView> InvoiceDate { get; set; } 
        public IRPSGridCheckbox<CurrentBalancesQueryView> IsNullified { get; set; } 
                     
    }
 
        public partial class GetDraftsFromInvoiceCollectionEditor<CurrentBalancesQueryView>:RPSCollectionEditor<CurrentBalancesQueryView> where CurrentBalancesQueryView : class, IView
    {
        public  GetDraftsFromInvoiceGridView<CurrentBalancesQueryView> GridView {get;set;}
    }
    public partial class GetDraftsFromInvoiceGridView <CurrentBalancesQueryView> :  RPSGridView<CurrentBalancesQueryView> where CurrentBalancesQueryView : class, IView
    {
        public GetDraftsFromInvoiceGridView(CurrentBalancesQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            RPTransactions_CustomerSupplier = RPSControlFactory.CreateRPSGridTextBox<CurrentBalancesQueryView>("","#5f118fd7-bd3a-488f-8c82-f7513671a2e8 .ag-row[role='row']@ROWINDEX [col-id='cRPTransactions_CustomerSupplier']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CurrentBalancesQueryView> RPTransactions_CustomerSupplier { get; set; } 
                     
    }
 
        public partial class TransactionsInformationCollectionEditor<CurrentBalancesQueryView>:RPSCollectionEditor<CurrentBalancesQueryView> where CurrentBalancesQueryView : class, IView
    {
        public  TransactionsInformationGridView<CurrentBalancesQueryView> GridView {get;set;}
    }
    public partial class TransactionsInformationGridView <CurrentBalancesQueryView> :  RPSGridView<CurrentBalancesQueryView> where CurrentBalancesQueryView : class, IView
    {
        public TransactionsInformationGridView(CurrentBalancesQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ACCTransactionsDetail_SignType = RPSControlFactory.CreateRPSGridTextBox<CurrentBalancesQueryView>("","#2c60d5e9-1c01-4534-8d58-b29a9b557b3f .ag-row[role='row']@ROWINDEX [col-id='cACCTransactionsDetail_SignType']","",false, this.CurrentView);
 
            ACCTransactionsDetail_Extension = RPSControlFactory.CreateRPSGridTextBox<CurrentBalancesQueryView>("","#2c60d5e9-1c01-4534-8d58-b29a9b557b3f .ag-row[role='row']@ROWINDEX [col-id='cACCTransactionsDetail_Extension']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CurrentBalancesQueryView> ACCTransactionsDetail_SignType { get; set; } 
        public IRPSGridTextBox<CurrentBalancesQueryView> ACCTransactionsDetail_Extension { get; set; } 
                     
    }
 
    }
  
    

}