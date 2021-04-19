    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.ReceivablePayable.UnpaidManagement
{
    //RPS VERSION 1.0.0.0
    public partial class UnpaidManagement:Screen
    {
        public UnpaidManagement():base()
        {
            this.URL = "receivablepayable.unpaidmanagement";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            UnpaidManagementQueryView  = new UnpaidManagementQueryView(this); 
            ResolveUnpaidChildDialogView  = new ResolveUnpaidChildDialogView(this); 
            AccTransactionsChildDialogView  = new AccTransactionsChildDialogView(this); 
            UnpaidManagementQueryView.InitializeControls(); 
            ResolveUnpaidChildDialogView.InitializeControls(); 
            AccTransactionsChildDialogView.InitializeControls(); 
           
        }
      
            public UnpaidManagementQueryView UnpaidManagementQueryView {get; set; } 
            public ResolveUnpaidChildDialogView ResolveUnpaidChildDialogView {get; set; } 
            public AccTransactionsChildDialogView AccTransactionsChildDialogView {get; set; } 
    }
            
    public partial class UnpaidManagementQueryView : View
    {
        public UnpaidManagementQueryView(UnpaidManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IsSale = RPSControlFactory.CreateRPSCheckBox<UnpaidManagementQueryView>("5f75721e-14e8-4858-b1c5-b0ac74cb10fe","","",false, this);
 
            IsPurchase = RPSControlFactory.CreateRPSCheckBox<UnpaidManagementQueryView>("6ba55d73-07cc-4b54-8da2-e39a169fb5f8","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<UnpaidManagementQueryView>("886079a8-ed1a-46d4-a7c6-e31ccdfac81d","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<UnpaidManagementQueryView>("df26d6c1-fd7a-45f6-9a97-b87ce9b51b15","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<UnpaidManagementQueryView>("f7328bb2-d916-4dfc-8484-35040abdbf57","","",false, this);
 
            CodInvoice = RPSControlFactory.CreateRPSTextBox<UnpaidManagementQueryView>("0067eadc-43d2-4d10-84c2-8d2b016c8a14","","",false, this);
 
            RefNumber = RPSControlFactory.CreateRPSTextBox<UnpaidManagementQueryView>("b951c510-4604-42ff-baaa-e9b0be2a795d","","",false, this);
 
            DateFromInvoice = RPSControlFactory.CreateRPSTextBox<UnpaidManagementQueryView>("67b07444-84b2-4f98-bba2-402ef56db221","","",false, this);
 
            DateToInvoice = RPSControlFactory.CreateRPSTextBox<UnpaidManagementQueryView>("f570c2fb-2364-4f69-993a-ca77a76bd0d9","","",false, this);
 
            DateFromDue = RPSControlFactory.CreateRPSTextBox<UnpaidManagementQueryView>("5e33c14f-0205-453d-ab1c-8d8526ca007f","","",false, this);
 
            DateToDue = RPSControlFactory.CreateRPSTextBox<UnpaidManagementQueryView>("4a3b44bd-2c8d-41ec-949d-8ae956ea9e3c","","",false, this);
 
            IDBankAccountCompany = RPSControlFactory.CreateRPSComboBox<UnpaidManagementQueryView>("2c4182b2-a736-40ec-b3ee-17cee8317dd9","","",false, this);
 
            IDUnpaidCause = RPSControlFactory.CreateRPSComboBox<UnpaidManagementQueryView>("c451a430-6bd9-40c3-b143-ec833486140c","","",false, this);
 
            ReturnDateFrom = RPSControlFactory.CreateRPSTextBox<UnpaidManagementQueryView>("005a5cd6-dc59-4a88-ac37-2af1cbb30e53","","",false, this);
 
            ReturnDateTo = RPSControlFactory.CreateRPSTextBox<UnpaidManagementQueryView>("be911bf0-baf5-4f0d-92d4-76b4acf68897","","",false, this);
 
            ResolveUnpaidChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<UnpaidManagementQueryView,ResolveUnpaidChildDialogView>("7f196525-8ee0-470c-bd83-75e9768bd050","","", this,Screen.ResolveUnpaidChildDialogView);
 
            CollectionInit params_GetUnpaidDraftsQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b175d766-4e5a-4077-b771-3a33d1e286bf",CSSSelectorGrid="",XPathGrid=""};
            GetUnpaidDraftsQuery = RPSControlFactory.RPSCreateCollectionWithGrid<GetUnpaidDraftsQueryCollectionEditor<UnpaidManagementQueryView,ResolveUnpaidChildDialogView>,UnpaidManagementQueryView,ResolveUnpaidChildDialogView>( params_GetUnpaidDraftsQuery,this,Screen.ResolveUnpaidChildDialogView);
 

        }
        public IRPSCheckbox<UnpaidManagementQueryView> IsSale { get; set; } 
        public IRPSCheckbox<UnpaidManagementQueryView> IsPurchase { get; set; } 
        public IRPSComboBox<UnpaidManagementQueryView> IDCustomer { get; set; } 
        public IRPSComboBox<UnpaidManagementQueryView> IDSupplier { get; set; } 
        public IRPSComboBox<UnpaidManagementQueryView> IDCurrency { get; set; } 
        public IRPSTextBox<UnpaidManagementQueryView> CodInvoice { get; set; } 
        public IRPSTextBox<UnpaidManagementQueryView> RefNumber { get; set; } 
        public IRPSTextBox<UnpaidManagementQueryView> DateFromInvoice { get; set; } 
        public IRPSTextBox<UnpaidManagementQueryView> DateToInvoice { get; set; } 
        public IRPSTextBox<UnpaidManagementQueryView> DateFromDue { get; set; } 
        public IRPSTextBox<UnpaidManagementQueryView> DateToDue { get; set; } 
        public IRPSComboBox<UnpaidManagementQueryView> IDBankAccountCompany { get; set; } 
        public IRPSComboBox<UnpaidManagementQueryView> IDUnpaidCause { get; set; } 
        public IRPSTextBox<UnpaidManagementQueryView> ReturnDateFrom { get; set; } 
        public IRPSTextBox<UnpaidManagementQueryView> ReturnDateTo { get; set; } 
        public IRPSButton<UnpaidManagementQueryView,ResolveUnpaidChildDialogView> ResolveUnpaidChildNavigationCommandButton { get; set; } 
        public GetUnpaidDraftsQueryCollectionEditor<UnpaidManagementQueryView,ResolveUnpaidChildDialogView> GetUnpaidDraftsQuery { get; set; } 
        public UnpaidManagement Screen { get; set; }
        public UnpaidManagementQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetUnpaidDraftsQueryCollectionEditor<UnpaidManagementQueryView,ResolveUnpaidChildDialogView>:RPSCollectionEditor<UnpaidManagementQueryView,ResolveUnpaidChildDialogView> where UnpaidManagementQueryView : class, IView where ResolveUnpaidChildDialogView : class, IView
    {
        public  GetUnpaidDraftsQueryGridView<UnpaidManagementQueryView,ResolveUnpaidChildDialogView> GridView {get;set;}
    }
    public partial class GetUnpaidDraftsQueryGridView <UnpaidManagementQueryView,ResolveUnpaidChildDialogView> :  RPSGridView<UnpaidManagementQueryView,ResolveUnpaidChildDialogView> where UnpaidManagementQueryView : class, IView where ResolveUnpaidChildDialogView : class, IView
    {
        public GetUnpaidDraftsQueryGridView(UnpaidManagementQueryView currentView,ResolveUnpaidChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            RPTransactions_ReturnDate = RPSControlFactory.CreateRPSGridTextBox<UnpaidManagementQueryView>("","#b175d766-4e5a-4077-b771-3a33d1e286bf .ag-row[role='row']@ROWINDEX [col-id='cRPTransactions_ReturnDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<UnpaidManagementQueryView> RPTransactions_ReturnDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class ResolveUnpaidChildDialogView : View
    {
        public ResolveUnpaidChildDialogView(UnpaidManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NoModifi = RPSControlFactory.CreateRPSOption<ResolveUnpaidChildDialogView>( "c6391252-e5a9-476b-9016-9ad541f58ff3","","",this);
 
            Add = RPSControlFactory.CreateRPSOption<ResolveUnpaidChildDialogView>( "106c7e71-8f4b-40f7-a82d-111eb43ae7db","","",this);
 
            OptionNo = RPSControlFactory.CreateRPSOption<ResolveUnpaidChildDialogView>( "4efeac16-240f-4878-b98b-52d6771679a8","","",this);
 
            OptionYes = RPSControlFactory.CreateRPSOption<ResolveUnpaidChildDialogView>( "be50741c-3f48-414d-a091-2d243ae686ca","","",this);
 
            AccountingDate = RPSControlFactory.CreateRPSTextBox<ResolveUnpaidChildDialogView>("a9a360e3-f3af-45c8-9092-a39d8ba52418","","",false, this);
 

        }
        public IRPSOption<ResolveUnpaidChildDialogView> NoModifi { get; set; } 
        public IRPSOption<ResolveUnpaidChildDialogView> Add { get; set; } 
        public IRPSOption<ResolveUnpaidChildDialogView> OptionNo { get; set; } 
        public IRPSOption<ResolveUnpaidChildDialogView> OptionYes { get; set; } 
        public IRPSTextBox<ResolveUnpaidChildDialogView> AccountingDate { get; set; } 
        public UnpaidManagement Screen { get; set; }
        public ResolveUnpaidChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class AccTransactionsChildDialogView : View
    {
        public AccTransactionsChildDialogView(UnpaidManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDACCTransactions = RPSControlFactory.CreateRPSComboBox<AccTransactionsChildDialogView>("37575a11-43de-4f5d-a2aa-cc39c138911b","","",false, this);
 

        }
        public IRPSComboBox<AccTransactionsChildDialogView> IDACCTransactions { get; set; } 
        public UnpaidManagement Screen { get; set; }
        public AccTransactionsChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}