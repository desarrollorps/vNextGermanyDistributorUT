    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.BankReconciliation
{
    //RPS VERSION 1.0.0.0
    public partial class BankReconciliation:Screen
    {
        public BankReconciliation():base()
        {
            this.URL = "generalledger.bankreconciliation";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            BankReconciliationVMQueryView  = new BankReconciliationVMQueryView(this); 
            BankReconciliationVMEntityView  = new BankReconciliationVMEntityView(this); 
            BankRecoAnalyticsView  = new BankRecoAnalyticsView(this); 
            ImportCSBDialogView  = new ImportCSBDialogView(this); 
            ImportExcelDialogView  = new ImportExcelDialogView(this); 
            MassiveChangeChildDialogView  = new MassiveChangeChildDialogView(this); 
            BankRecoDetailView  = new BankRecoDetailView(this); 
            AddRemittanceChidDialogView  = new AddRemittanceChidDialogView(this); 
            ExecuteActionsChildDialogView  = new ExecuteActionsChildDialogView(this); 
            AccTransactionsGridChildDialogView  = new AccTransactionsGridChildDialogView(this); 
            ExecuteActionOneBankReconciliationChildDialogView  = new ExecuteActionOneBankReconciliationChildDialogView(this); 
            AccTransactionsGridOneBankReconciliationChildDialogView  = new AccTransactionsGridOneBankReconciliationChildDialogView(this); 
            AddDraftChildDialogView  = new AddDraftChildDialogView(this); 
            BankReconciliationVMQueryView.InitializeControls(); 
            BankReconciliationVMEntityView.InitializeControls(); 
            BankRecoAnalyticsView.InitializeControls(); 
            ImportCSBDialogView.InitializeControls(); 
            ImportExcelDialogView.InitializeControls(); 
            MassiveChangeChildDialogView.InitializeControls(); 
            BankRecoDetailView.InitializeControls(); 
            AddRemittanceChidDialogView.InitializeControls(); 
            ExecuteActionsChildDialogView.InitializeControls(); 
            AccTransactionsGridChildDialogView.InitializeControls(); 
            ExecuteActionOneBankReconciliationChildDialogView.InitializeControls(); 
            AccTransactionsGridOneBankReconciliationChildDialogView.InitializeControls(); 
            AddDraftChildDialogView.InitializeControls(); 
           
        }
      
            public BankReconciliationVMQueryView BankReconciliationVMQueryView {get; set; } 
            public BankReconciliationVMEntityView BankReconciliationVMEntityView {get; set; } 
            public BankRecoAnalyticsView BankRecoAnalyticsView {get; set; } 
            public ImportCSBDialogView ImportCSBDialogView {get; set; } 
            public ImportExcelDialogView ImportExcelDialogView {get; set; } 
            public MassiveChangeChildDialogView MassiveChangeChildDialogView {get; set; } 
            public BankRecoDetailView BankRecoDetailView {get; set; } 
            public AddRemittanceChidDialogView AddRemittanceChidDialogView {get; set; } 
            public ExecuteActionsChildDialogView ExecuteActionsChildDialogView {get; set; } 
            public AccTransactionsGridChildDialogView AccTransactionsGridChildDialogView {get; set; } 
            public ExecuteActionOneBankReconciliationChildDialogView ExecuteActionOneBankReconciliationChildDialogView {get; set; } 
            public AccTransactionsGridOneBankReconciliationChildDialogView AccTransactionsGridOneBankReconciliationChildDialogView {get; set; } 
            public AddDraftChildDialogView AddDraftChildDialogView {get; set; } 
    }
            
    public partial class BankReconciliationVMQueryView : View
    {
        public BankReconciliationVMQueryView(BankReconciliation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<BankReconciliationVMQueryView,BankReconciliationVMEntityView>( this,Screen.BankReconciliationVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<BankReconciliationVMQueryView>( this);
 
            IDBankAccountCompany = RPSControlFactory.CreateRPSComboBox<BankReconciliationVMQueryView>("82bd9a40-1825-4cba-a66a-5f70e391bc2a","","",false, this);
 
            StatementNumber = RPSControlFactory.CreateRPSEnumComboBox<BankReconciliationVMQueryView>("62673ef3-92dc-4207-b0be-63ef96f01448","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<BankReconciliationVMQueryView>("7012ac04-fcd6-47f7-b3fc-b4244c6dbca4","","",false, this);
 
            InitialDate = RPSControlFactory.CreateRPSTextBox<BankReconciliationVMQueryView>("244d630f-4615-4a2c-9501-19326626212b","","",false, this);
 
            InitialBalance = RPSControlFactory.CreateRPSFormattedTextBox<BankReconciliationVMQueryView>("44b10d4b-7250-4862-88f3-1a25886193cb","","",false, this);
 
            InitialAmount = RPSControlFactory.CreateRPSFormattedTextBox<BankReconciliationVMQueryView>("408cb8f2-a058-4a07-8e33-aefb42d7083e","","",false, this);
 
            EndAmount = RPSControlFactory.CreateRPSFormattedTextBox<BankReconciliationVMQueryView>("90271a39-80b2-4df1-a787-15273e99f9bb","","",false, this);
 
            NewReconciliationCommandButton = RPSControlFactory.CreateRPSButton<BankReconciliationVMQueryView>( "185d84d2-2da7-4360-ae58-350f58b48b82","","",this);
 
            DeleteEntireStatementNumberReconciliationsCommandButton = RPSControlFactory.CreateRPSButton<BankReconciliationVMQueryView>( "a4550c07-155e-48a1-9023-4e748b772a5e","","",this);
 
            PrintCommandButton = RPSControlFactory.CreateRPSButton<BankReconciliationVMQueryView>( "bd1e9000-b943-4223-a56c-2fb5f2bd523a","","",this);
 
            ImportCSBNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<BankReconciliationVMQueryView,ImportCSBDialogView>("09e74af8-8aec-4bc6-9991-240fbb072ee5","","", this,Screen.ImportCSBDialogView);
 
            ImportExcelNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<BankReconciliationVMQueryView,ImportExcelDialogView>("d5b3d91b-64ab-469d-a7a1-90701fdc0115","","", this,Screen.ImportExcelDialogView);
 
            MassiveChangeChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<BankReconciliationVMQueryView,MassiveChangeChildDialogView>("d692d95b-9835-4b5f-93e0-049f82fc7211","","", this,Screen.MassiveChangeChildDialogView);
 
            ExecuteActionCommandButton = RPSControlFactory.CreateRPSButton<BankReconciliationVMQueryView>( "ae08d837-2dd7-44b0-9e15-767aa3d93436","","",this);
 
            CollectionInit params_BankReconciliationbyNumberBankPayment = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3fbaa956-1089-4c83-8460-b60cc64f73e6",CSSSelectorGrid="",XPathGrid=""};
            BankReconciliationbyNumberBankPayment = RPSControlFactory.RPSCreateCollectionWithGrid<BankReconciliationbyNumberBankPaymentCollectionEditor<BankReconciliationVMQueryView,BankReconciliationVMEntityView>,BankReconciliationVMQueryView,BankReconciliationVMEntityView>( params_BankReconciliationbyNumberBankPayment,this,Screen.BankReconciliationVMEntityView);
 
            CollectionInit params_TransactionsDetailReconciled = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="15d0c7d0-9d9e-4390-9a88-f2092e5eb650",CSSSelectorGrid="",XPathGrid=""};
            TransactionsDetailReconciled = RPSControlFactory.RPSCreateCollectionWithGrid<TransactionsDetailReconciledCollectionEditor<BankReconciliationVMQueryView,BankReconciliationVMEntityView>,BankReconciliationVMQueryView,BankReconciliationVMEntityView>( params_TransactionsDetailReconciled,this,Screen.BankReconciliationVMEntityView);
 
            SectionBankReconciliation = RPSControlFactory.CreateRPSSection<BankReconciliationVMQueryView>( "","ul li[rpsid='40031b2a-ca94-424c-821f-7eb00e8eb666']","",this);
 
            SectionVouchers = RPSControlFactory.CreateRPSSection<BankReconciliationVMQueryView>( "","ul li[rpsid='d1fa567b-407c-46e6-a8ef-0ca120196463']","",this);
 

        }
        public IRPSButton<BankReconciliationVMQueryView,BankReconciliationVMEntityView> NewButton { get; set; } 
        public IRPSButton<BankReconciliationVMQueryView> ConsultButton { get; set; } 
        public IRPSComboBox<BankReconciliationVMQueryView> IDBankAccountCompany { get; set; } 
        public IRPSComboBox<BankReconciliationVMQueryView> StatementNumber { get; set; } 
        public IRPSComboBox<BankReconciliationVMQueryView> IDCurrency { get; set; } 
        public IRPSTextBox<BankReconciliationVMQueryView> InitialDate { get; set; } 
        public IRPSTextBox<BankReconciliationVMQueryView> InitialBalance { get; set; } 
        public IRPSTextBox<BankReconciliationVMQueryView> InitialAmount { get; set; } 
        public IRPSTextBox<BankReconciliationVMQueryView> EndAmount { get; set; } 
        public IRPSButton<BankReconciliationVMQueryView> NewReconciliationCommandButton { get; set; } 
        public IRPSButton<BankReconciliationVMQueryView> DeleteEntireStatementNumberReconciliationsCommandButton { get; set; } 
        public IRPSButton<BankReconciliationVMQueryView> PrintCommandButton { get; set; } 
        public IRPSButton<BankReconciliationVMQueryView,ImportCSBDialogView> ImportCSBNavigationCommandButton { get; set; } 
        public IRPSButton<BankReconciliationVMQueryView,ImportExcelDialogView> ImportExcelNavigationCommandButton { get; set; } 
        public IRPSButton<BankReconciliationVMQueryView,MassiveChangeChildDialogView> MassiveChangeChildNavigationCommandButton { get; set; } 
        public IRPSButton<BankReconciliationVMQueryView> ExecuteActionCommandButton { get; set; } 
        public BankReconciliationbyNumberBankPaymentCollectionEditor<BankReconciliationVMQueryView,BankReconciliationVMEntityView> BankReconciliationbyNumberBankPayment { get; set; } 
        public TransactionsDetailReconciledCollectionEditor<BankReconciliationVMQueryView,BankReconciliationVMEntityView> TransactionsDetailReconciled { get; set; } 
        public IRPSSection<BankReconciliationVMQueryView> SectionBankReconciliation { get; set; } 
        public IRPSSection<BankReconciliationVMQueryView> SectionVouchers { get; set; } 
        public BankReconciliation Screen { get; set; }
        public BankReconciliationVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class BankReconciliationbyNumberBankPaymentCollectionEditor<BankReconciliationVMQueryView,BankReconciliationVMEntityView>:RPSCollectionEditor<BankReconciliationVMQueryView,BankReconciliationVMEntityView> where BankReconciliationVMQueryView : class, IView where BankReconciliationVMEntityView : class, IView
    {
        public  BankReconciliationbyNumberBankPaymentGridView<BankReconciliationVMQueryView,BankReconciliationVMEntityView> GridView {get;set;}
    }
    public partial class BankReconciliationbyNumberBankPaymentGridView <BankReconciliationVMQueryView,BankReconciliationVMEntityView> :  RPSGridView<BankReconciliationVMQueryView,BankReconciliationVMEntityView> where BankReconciliationVMQueryView : class, IView where BankReconciliationVMEntityView : class, IView
    {
        public BankReconciliationbyNumberBankPaymentGridView(BankReconciliationVMQueryView currentView,BankReconciliationVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeleteBankreconciliationFromResultsGridCommand = RPSControlFactory.CreateRPSGridButton<BankReconciliationVMQueryView>( "","#3fbaa956-1089-4c83-8460-b60cc64f73e6 .ag-row[role='row']@ROWINDEX [col-id='cDeleteBankreconciliationFromResultsGridCommand']","",this.CurrentView);
 
            Status = RPSControlFactory.CreateRPSGridTextBox<BankReconciliationVMQueryView>("","#3fbaa956-1089-4c83-8460-b60cc64f73e6 .ag-row[role='row']@ROWINDEX [col-id='cStatus']","",false, this.CurrentView);
 
            Action = RPSControlFactory.CreateRPSGridTextBox<BankReconciliationVMQueryView>("","#3fbaa956-1089-4c83-8460-b60cc64f73e6 .ag-row[role='row']@ROWINDEX [col-id='cAction']","",false, this.CurrentView);
 
            MovementDate = RPSControlFactory.CreateRPSGridTextBox<BankReconciliationVMQueryView>("","#3fbaa956-1089-4c83-8460-b60cc64f73e6 .ag-row[role='row']@ROWINDEX [col-id='cMovementDate']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<BankReconciliationVMQueryView>("","#3fbaa956-1089-4c83-8460-b60cc64f73e6 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Change = RPSControlFactory.CreateRPSGridFormattedTextBox<BankReconciliationVMQueryView>("","#3fbaa956-1089-4c83-8460-b60cc64f73e6 .ag-row[role='row']@ROWINDEX [col-id='cChange']","",false, this.CurrentView);
 

        }
        public IRPSGridButton<BankReconciliationVMQueryView> DeleteBankreconciliationFromResultsGridCommand { get; set; } 
        public IRPSGridTextBox<BankReconciliationVMQueryView> Status { get; set; } 
        public IRPSGridTextBox<BankReconciliationVMQueryView> Action { get; set; } 
        public IRPSGridTextBox<BankReconciliationVMQueryView> MovementDate { get; set; } 
        public IRPSGridTextBox<BankReconciliationVMQueryView> Description { get; set; } 
        public IRPSGridTextBox<BankReconciliationVMQueryView> Change { get; set; } 
                     
    }
 
        public partial class TransactionsDetailReconciledCollectionEditor<BankReconciliationVMQueryView,BankReconciliationVMEntityView>:RPSCollectionEditor<BankReconciliationVMQueryView,BankReconciliationVMEntityView> where BankReconciliationVMQueryView : class, IView where BankReconciliationVMEntityView : class, IView
    {
        public  TransactionsDetailReconciledGridView<BankReconciliationVMQueryView,BankReconciliationVMEntityView> GridView {get;set;}
    }
    public partial class TransactionsDetailReconciledGridView <BankReconciliationVMQueryView,BankReconciliationVMEntityView> :  RPSGridView<BankReconciliationVMQueryView,BankReconciliationVMEntityView> where BankReconciliationVMQueryView : class, IView where BankReconciliationVMEntityView : class, IView
    {
        public TransactionsDetailReconciledGridView(BankReconciliationVMQueryView currentView,BankReconciliationVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ACCTransactionsDetail_SignType = RPSControlFactory.CreateRPSGridTextBox<BankReconciliationVMQueryView>("","#15d0c7d0-9d9e-4390-9a88-f2092e5eb650 .ag-row[role='row']@ROWINDEX [col-id='cACCTransactionsDetail_SignType']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<BankReconciliationVMQueryView> ACCTransactionsDetail_SignType { get; set; } 
                     
    }
 
    }
  
            
    public partial class BankReconciliationVMEntityView : View
    {
        public BankReconciliationVMEntityView(BankReconciliation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<BankReconciliationVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<BankReconciliationVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<BankReconciliationVMEntityView,BankReconciliationVMQueryView>( this,Screen.BankReconciliationVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<BankReconciliationVMEntityView,BankReconciliationVMQueryView>( this,Screen.BankReconciliationVMQueryView);
 
            IDBankAccountCompany = RPSControlFactory.CreateRPSComboBox<BankReconciliationVMEntityView>("b49dbe60-b127-46b8-877c-126b9d668f60","","",true, this);
 
            NumberBankPayment = RPSControlFactory.CreateRPSTextBox<BankReconciliationVMEntityView>("627ce1e1-31dd-44eb-ab6e-9228bc7ed75c","","",false, this);
 
            Status = RPSControlFactory.CreateRPSEnumComboBox<BankReconciliationVMEntityView>("95ddc637-aced-4fa7-b708-6e6d296b5d5b","","",true, this);
 
            MovementDate = RPSControlFactory.CreateRPSTextBox<BankReconciliationVMEntityView>("f5aa8bdc-20ee-4dc3-af81-4686e4fbbed5","","",true, this);
 
            AmountWithSign = RPSControlFactory.CreateRPSFormattedTextBox<BankReconciliationVMEntityView>("f6c87bf4-f967-4954-a0a0-8e58c9d54981","","",false, this);
 
            Change = RPSControlFactory.CreateRPSFormattedTextBox<BankReconciliationVMEntityView>("90ebd6d8-6407-495d-8e5e-ece716080707","","",true, this);
 
            AmountCurrencyWithSign = RPSControlFactory.CreateRPSFormattedTextBox<BankReconciliationVMEntityView>("3ad52741-e9b6-42ff-ab2f-f7491a06e49f","","",true, this);
 
            Action = RPSControlFactory.CreateRPSEnumComboBox<BankReconciliationVMEntityView>("05780f53-610c-4aab-8d08-6b72e6282cc3","","",true, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<BankReconciliationVMEntityView>("b6678a9b-12d9-429d-8a7a-37895d163b2a","","",false, this);
 
            CodInvoice = RPSControlFactory.CreateRPSTextBox<BankReconciliationVMEntityView>("c1d6be06-af48-4856-a1d2-e060ad0c85e8","","",false, this);
 
            IDAccount = RPSControlFactory.CreateRPSComboBox<BankReconciliationVMEntityView>("48ee832a-dd29-41fc-ac00-3b361e4e9f18","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<BankReconciliationVMEntityView>("2f3732f7-f39a-4480-9163-8a7c43cc6c8e","","",false, this);
 
            CheckNumber = RPSControlFactory.CreateRPSTextBox<BankReconciliationVMEntityView>("83144f7d-bba2-42db-adc0-f7793ce73c67","","",false, this);
 
            Key = RPSControlFactory.CreateRPSTextBox<BankReconciliationVMEntityView>("dc331817-0cdc-4b7b-8a51-e80379640f59","","",false, this);
 
            RecoKey = RPSControlFactory.CreateRPSTextBox<BankReconciliationVMEntityView>("6bed17a5-351f-444f-9d3a-cbc9dff38e1e","","",false, this);
 
            TextReference1 = RPSControlFactory.CreateRPSTextBox<BankReconciliationVMEntityView>("febb2c3f-712a-4cd5-80b1-59b1dda8f6bb","","",false, this);
 
            TextReference2 = RPSControlFactory.CreateRPSTextBox<BankReconciliationVMEntityView>("0aca082c-27aa-46e4-b791-7babb286ca41","","",false, this);
 
            ValueDate = RPSControlFactory.CreateRPSTextBox<BankReconciliationVMEntityView>("44f6e95c-a356-498f-9d40-ce348b89ac47","","",true, this);
 
            UITotalAmountCurrencyDrafts = RPSControlFactory.CreateRPSFormattedTextBox<BankReconciliationVMEntityView>("c1d3da5c-986d-4417-af12-7bcfa7677b85","","",true, this);
 
            UITotalAmountDrafts = RPSControlFactory.CreateRPSFormattedTextBox<BankReconciliationVMEntityView>("3ebd903f-2afc-4b9f-ad3e-eb8494971e41","","",true, this);
 
            UITotalAmountPaidDrafts = RPSControlFactory.CreateRPSFormattedTextBox<BankReconciliationVMEntityView>("51dcb0b6-c0ce-4d8d-81b2-eea7f52f9856","","",true, this);
 
            AddDraftCommandButton = RPSControlFactory.CreateRPSButton<BankReconciliationVMEntityView>( "f63ca1e6-bed1-4ee4-828c-68a7ed3143b1","","",this);
 
            UIRemittanceDate = RPSControlFactory.CreateRPSTextBox<BankReconciliationVMEntityView>("2063372a-cf3a-4f98-8ff6-3e19a18ce45a","","",false, this);
 
            RemittanceNumber = RPSControlFactory.CreateRPSTextBox<BankReconciliationVMEntityView>("e024310c-f490-424b-9bdb-bd5a849b0fa1","","",false, this);
 
            UITotalAmountRemittanceCurrency = RPSControlFactory.CreateRPSFormattedTextBox<BankReconciliationVMEntityView>("14dfc5d3-72d6-4f60-9f27-d67324beda74","","",true, this);
 
            UITotalAmountRemittance = RPSControlFactory.CreateRPSFormattedTextBox<BankReconciliationVMEntityView>("886ff7c7-9e99-4f46-a765-1c7221f05780","","",true, this);
 
            AddRemittanceChidNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<BankReconciliationVMEntityView,AddRemittanceChidDialogView>("d99ae4f8-7a7b-456d-8caf-bf35b572d11b","","", this,Screen.AddRemittanceChidDialogView);
 
            ExecuteActionOneReconciliationCommandButton = RPSControlFactory.CreateRPSButton<BankReconciliationVMEntityView>( "e4eac6c5-91c3-40b0-9109-39fedf3e5f6e","","",this);
 
            CollectionInit params_BankRecoAnalytics = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3635309e-b128-426b-90ef-e41479c0165c",CSSSelectorGrid="",XPathGrid=""};
            BankRecoAnalytics = RPSControlFactory.RPSCreateCollectionWithGrid<BankRecoAnalyticsCollectionEditor<BankReconciliationVMEntityView,BankRecoDetailView>,BankReconciliationVMEntityView,BankRecoDetailView>( params_BankRecoAnalytics,this,Screen.BankRecoDetailView);
 
            CollectionInit params_BankRecoDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f70a018b-0784-423a-8bbc-86c8d3d6900a",CSSSelectorGrid="",XPathGrid=""};
            BankRecoDetails = RPSControlFactory.RPSCreateCollectionWithGrid<BankRecoDetailsCollectionEditor<BankReconciliationVMEntityView,BankRecoDetailView>,BankReconciliationVMEntityView,BankRecoDetailView>( params_BankRecoDetails,this,Screen.BankRecoDetailView);
 
            CollectionInit params_GetRPTransactionsRemittanceNumber = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="2b6082b5-60f0-490e-b123-25703fa0a802",CSSSelectorGrid="",XPathGrid=""};
            GetRPTransactionsRemittanceNumber = RPSControlFactory.RPSCreateCollectionWithGrid<GetRPTransactionsRemittanceNumberCollectionEditor<BankReconciliationVMEntityView,BankRecoDetailView>,BankReconciliationVMEntityView,BankRecoDetailView>( params_GetRPTransactionsRemittanceNumber,this,Screen.BankRecoDetailView);
 
            CollectionInit params_TransactionsDetailReconciled = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4ab31d88-c914-40ff-8aae-bf978d7111b2",CSSSelectorGrid="",XPathGrid=""};
            TransactionsDetailReconciled = RPSControlFactory.RPSCreateCollectionWithGrid<TransactionsDetailReconciledCollectionEditor<BankReconciliationVMEntityView,BankRecoDetailView>,BankReconciliationVMEntityView,BankRecoDetailView>( params_TransactionsDetailReconciled,this,Screen.BankRecoDetailView);
 
            SectionGeneral = RPSControlFactory.CreateRPSSection<BankReconciliationVMEntityView>( "","ul li[rpsid='9c3c5a2f-703b-48d8-bf15-a7c111650b82']","",this);
 
            SectionAnalytics = RPSControlFactory.CreateRPSSection<BankReconciliationVMEntityView>( "","ul li[rpsid='e1856572-01d7-4374-902c-207e126b0586']","",this);
 
            SectionRecoDetails = RPSControlFactory.CreateRPSSection<BankReconciliationVMEntityView>( "","ul li[rpsid='313dc533-2571-4672-8704-443a0165362a']","",this);
 
            SectionRemittance = RPSControlFactory.CreateRPSSection<BankReconciliationVMEntityView>( "","ul li[rpsid='b6a86d71-bef3-4373-87a0-512130ef0455']","",this);
 
            SectionVouchers = RPSControlFactory.CreateRPSSection<BankReconciliationVMEntityView>( "","ul li[rpsid='56bf70e6-cb5c-4280-bfeb-97ace779055c']","",this);
 

        }
        public IRPSSaveButton<BankReconciliationVMEntityView> SaveButton { get; set; } 
        public IRPSButton<BankReconciliationVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<BankReconciliationVMEntityView,BankReconciliationVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<BankReconciliationVMEntityView,BankReconciliationVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<BankReconciliationVMEntityView> IDBankAccountCompany { get; set; } 
        public IRPSTextBox<BankReconciliationVMEntityView> NumberBankPayment { get; set; } 
        public IRPSComboBox<BankReconciliationVMEntityView> Status { get; set; } 
        public IRPSTextBox<BankReconciliationVMEntityView> MovementDate { get; set; } 
        public IRPSTextBox<BankReconciliationVMEntityView> AmountWithSign { get; set; } 
        public IRPSTextBox<BankReconciliationVMEntityView> Change { get; set; } 
        public IRPSTextBox<BankReconciliationVMEntityView> AmountCurrencyWithSign { get; set; } 
        public IRPSComboBox<BankReconciliationVMEntityView> Action { get; set; } 
        public IRPSComboBox<BankReconciliationVMEntityView> IDSupplier { get; set; } 
        public IRPSTextBox<BankReconciliationVMEntityView> CodInvoice { get; set; } 
        public IRPSComboBox<BankReconciliationVMEntityView> IDAccount { get; set; } 
        public IRPSTextBox<BankReconciliationVMEntityView> Description { get; set; } 
        public IRPSTextBox<BankReconciliationVMEntityView> CheckNumber { get; set; } 
        public IRPSTextBox<BankReconciliationVMEntityView> Key { get; set; } 
        public IRPSTextBox<BankReconciliationVMEntityView> RecoKey { get; set; } 
        public IRPSTextBox<BankReconciliationVMEntityView> TextReference1 { get; set; } 
        public IRPSTextBox<BankReconciliationVMEntityView> TextReference2 { get; set; } 
        public IRPSTextBox<BankReconciliationVMEntityView> ValueDate { get; set; } 
        public IRPSTextBox<BankReconciliationVMEntityView> UITotalAmountCurrencyDrafts { get; set; } 
        public IRPSTextBox<BankReconciliationVMEntityView> UITotalAmountDrafts { get; set; } 
        public IRPSTextBox<BankReconciliationVMEntityView> UITotalAmountPaidDrafts { get; set; } 
        public IRPSButton<BankReconciliationVMEntityView> AddDraftCommandButton { get; set; } 
        public IRPSTextBox<BankReconciliationVMEntityView> UIRemittanceDate { get; set; } 
        public IRPSTextBox<BankReconciliationVMEntityView> RemittanceNumber { get; set; } 
        public IRPSTextBox<BankReconciliationVMEntityView> UITotalAmountRemittanceCurrency { get; set; } 
        public IRPSTextBox<BankReconciliationVMEntityView> UITotalAmountRemittance { get; set; } 
        public IRPSButton<BankReconciliationVMEntityView,AddRemittanceChidDialogView> AddRemittanceChidNavigationCommandButton { get; set; } 
        public IRPSButton<BankReconciliationVMEntityView> ExecuteActionOneReconciliationCommandButton { get; set; } 
        public BankRecoAnalyticsCollectionEditor<BankReconciliationVMEntityView,BankRecoDetailView> BankRecoAnalytics { get; set; } 
        public BankRecoDetailsCollectionEditor<BankReconciliationVMEntityView,BankRecoDetailView> BankRecoDetails { get; set; } 
        public GetRPTransactionsRemittanceNumberCollectionEditor<BankReconciliationVMEntityView,BankRecoDetailView> GetRPTransactionsRemittanceNumber { get; set; } 
        public TransactionsDetailReconciledCollectionEditor<BankReconciliationVMEntityView,BankRecoDetailView> TransactionsDetailReconciled { get; set; } 
        public IRPSSection<BankReconciliationVMEntityView> SectionGeneral { get; set; } 
        public IRPSSection<BankReconciliationVMEntityView> SectionAnalytics { get; set; } 
        public IRPSSection<BankReconciliationVMEntityView> SectionRecoDetails { get; set; } 
        public IRPSSection<BankReconciliationVMEntityView> SectionRemittance { get; set; } 
        public IRPSSection<BankReconciliationVMEntityView> SectionVouchers { get; set; } 
        public BankReconciliation Screen { get; set; }
        public BankReconciliationVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class BankRecoAnalyticsCollectionEditor<BankReconciliationVMEntityView,BankRecoDetailView>:RPSCollectionEditor<BankReconciliationVMEntityView,BankRecoDetailView> where BankReconciliationVMEntityView : class, IView where BankRecoDetailView : class, IView
    {
        public  BankRecoAnalyticsGridView<BankReconciliationVMEntityView,BankRecoDetailView> GridView {get;set;}
    }
    public partial class BankRecoAnalyticsGridView <BankReconciliationVMEntityView,BankRecoDetailView> :  RPSGridView<BankReconciliationVMEntityView,BankRecoDetailView> where BankReconciliationVMEntityView : class, IView where BankRecoDetailView : class, IView
    {
        public BankRecoAnalyticsGridView(BankReconciliationVMEntityView currentView,BankRecoDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDDimension = RPSControlFactory.CreateRPSGridComboBox<BankReconciliationVMEntityView>("","#3635309e-b128-426b-90ef-e41479c0165c .ag-row[role='row']@ROWINDEX [col-id='cIDDimension']","",true, this.CurrentView);
 
            IDDimValue = RPSControlFactory.CreateRPSGridComboBox<BankReconciliationVMEntityView>("","#3635309e-b128-426b-90ef-e41479c0165c .ag-row[role='row']@ROWINDEX [col-id='cIDDimValue']","",true, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<BankReconciliationVMEntityView>("","#3635309e-b128-426b-90ef-e41479c0165c .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<BankReconciliationVMEntityView> IDDimension { get; set; } 
        public IRPSGridComboBox<BankReconciliationVMEntityView> IDDimValue { get; set; } 
        public IRPSGridTextBox<BankReconciliationVMEntityView> Percentage { get; set; } 
                     
    }
 
        public partial class BankRecoDetailsCollectionEditor<BankReconciliationVMEntityView,BankRecoDetailView>:RPSCollectionEditor<BankReconciliationVMEntityView,BankRecoDetailView> where BankReconciliationVMEntityView : class, IView where BankRecoDetailView : class, IView
    {
        public  BankRecoDetailsGridView<BankReconciliationVMEntityView,BankRecoDetailView> GridView {get;set;}
    }
    public partial class BankRecoDetailsGridView <BankReconciliationVMEntityView,BankRecoDetailView> :  RPSGridView<BankReconciliationVMEntityView,BankRecoDetailView> where BankReconciliationVMEntityView : class, IView where BankRecoDetailView : class, IView
    {
        public BankRecoDetailsGridView(BankReconciliationVMEntityView currentView,BankRecoDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDRPTransaction = RPSControlFactory.CreateRPSGridComboBox<BankReconciliationVMEntityView>("","#f70a018b-0784-423a-8bbc-86c8d3d6900a .ag-row[role='row']@ROWINDEX [col-id='cIDRPTransaction']","",true, this.CurrentView);
 
            UIIDThird = RPSControlFactory.CreateRPSGridComboBox<BankReconciliationVMEntityView>("","#f70a018b-0784-423a-8bbc-86c8d3d6900a .ag-row[role='row']@ROWINDEX [col-id='cUIIDThird']","",false, this.CurrentView);
 
            UIAmountNominalCurrency = RPSControlFactory.CreateRPSGridFormattedTextBox<BankReconciliationVMEntityView>("","#f70a018b-0784-423a-8bbc-86c8d3d6900a .ag-row[role='row']@ROWINDEX [col-id='cUIAmountNominalCurrency']","",false, this.CurrentView);
 
            UIAmountNominal = RPSControlFactory.CreateRPSGridFormattedTextBox<BankReconciliationVMEntityView>("","#f70a018b-0784-423a-8bbc-86c8d3d6900a .ag-row[role='row']@ROWINDEX [col-id='cUIAmountNominal']","",false, this.CurrentView);
 
            UIIDPaymentType = RPSControlFactory.CreateRPSGridComboBox<BankReconciliationVMEntityView>("","#f70a018b-0784-423a-8bbc-86c8d3d6900a .ag-row[role='row']@ROWINDEX [col-id='cUIIDPaymentType']","",false, this.CurrentView);
 
            UIIDPaymentStatus = RPSControlFactory.CreateRPSGridComboBox<BankReconciliationVMEntityView>("","#f70a018b-0784-423a-8bbc-86c8d3d6900a .ag-row[role='row']@ROWINDEX [col-id='cUIIDPaymentStatus']","",false, this.CurrentView);
 
            PaidAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<BankReconciliationVMEntityView>("","#f70a018b-0784-423a-8bbc-86c8d3d6900a .ag-row[role='row']@ROWINDEX [col-id='cPaidAmount']","",true, this.CurrentView);
 
            IDPaymentStatus = RPSControlFactory.CreateRPSGridComboBox<BankReconciliationVMEntityView>("","#f70a018b-0784-423a-8bbc-86c8d3d6900a .ag-row[role='row']@ROWINDEX [col-id='cIDPaymentStatus']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<BankReconciliationVMEntityView> IDRPTransaction { get; set; } 
        public IRPSGridComboBox<BankReconciliationVMEntityView> UIIDThird { get; set; } 
        public IRPSGridTextBox<BankReconciliationVMEntityView> UIAmountNominalCurrency { get; set; } 
        public IRPSGridTextBox<BankReconciliationVMEntityView> UIAmountNominal { get; set; } 
        public IRPSGridComboBox<BankReconciliationVMEntityView> UIIDPaymentType { get; set; } 
        public IRPSGridComboBox<BankReconciliationVMEntityView> UIIDPaymentStatus { get; set; } 
        public IRPSGridTextBox<BankReconciliationVMEntityView> PaidAmount { get; set; } 
        public IRPSGridComboBox<BankReconciliationVMEntityView> IDPaymentStatus { get; set; } 
                     
    }
 
        public partial class GetRPTransactionsRemittanceNumberCollectionEditor<BankReconciliationVMEntityView,BankRecoDetailView>:RPSCollectionEditor<BankReconciliationVMEntityView,BankRecoDetailView> where BankReconciliationVMEntityView : class, IView where BankRecoDetailView : class, IView
    {
        public  GetRPTransactionsRemittanceNumberGridView<BankReconciliationVMEntityView,BankRecoDetailView> GridView {get;set;}
    }
    public partial class GetRPTransactionsRemittanceNumberGridView <BankReconciliationVMEntityView,BankRecoDetailView> :  RPSGridView<BankReconciliationVMEntityView,BankRecoDetailView> where BankReconciliationVMEntityView : class, IView where BankRecoDetailView : class, IView
    {
        public GetRPTransactionsRemittanceNumberGridView(BankReconciliationVMEntityView currentView,BankRecoDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {

        }
                     
    }
 
        public partial class TransactionsDetailReconciledCollectionEditor<BankReconciliationVMEntityView,BankRecoDetailView>:RPSCollectionEditor<BankReconciliationVMEntityView,BankRecoDetailView> where BankReconciliationVMEntityView : class, IView where BankRecoDetailView : class, IView
    {
        public  TransactionsDetailReconciledGridView<BankReconciliationVMEntityView,BankRecoDetailView> GridView {get;set;}
    }
    public partial class TransactionsDetailReconciledGridView <BankReconciliationVMEntityView,BankRecoDetailView> :  RPSGridView<BankReconciliationVMEntityView,BankRecoDetailView> where BankReconciliationVMEntityView : class, IView where BankRecoDetailView : class, IView
    {
        public TransactionsDetailReconciledGridView(BankReconciliationVMEntityView currentView,BankRecoDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ACCTransactionsDetail_SignType = RPSControlFactory.CreateRPSGridTextBox<BankReconciliationVMEntityView>("","#4ab31d88-c914-40ff-8aae-bf978d7111b2 .ag-row[role='row']@ROWINDEX [col-id='cACCTransactionsDetail_SignType']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<BankReconciliationVMEntityView> ACCTransactionsDetail_SignType { get; set; } 
                     
    }
 
    }
  
            
    public partial class BankRecoAnalyticsView : View
    {
        public BankRecoAnalyticsView(BankReconciliation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<BankRecoAnalyticsView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<BankRecoAnalyticsView,BankReconciliationVMEntityView>( this,Screen.BankReconciliationVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<BankRecoAnalyticsView,BankReconciliationVMEntityView>( this,Screen.BankReconciliationVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<BankRecoAnalyticsView,BankReconciliationVMEntityView>( this,Screen.BankReconciliationVMEntityView);
 
            IDDimension = RPSControlFactory.CreateRPSComboBox<BankRecoAnalyticsView>("82f72ad7-a0dc-4cb8-b7a5-ad42fff4b605","","",true, this);
 
            IDDimValue = RPSControlFactory.CreateRPSComboBox<BankRecoAnalyticsView>("4f18a31a-1773-4502-ac25-a1f44510ec2f","","",true, this);
 
            Percentage = RPSControlFactory.CreateRPSFormattedTextBox<BankRecoAnalyticsView>("a9f6ef73-fa7c-4635-b0b5-201e0d347941","","",true, this);
 

        }
        public IRPSButton<BankRecoAnalyticsView> DeleteButton { get; set; } 
        public IRPSButton<BankRecoAnalyticsView,BankReconciliationVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<BankRecoAnalyticsView,BankReconciliationVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<BankRecoAnalyticsView,BankReconciliationVMEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<BankRecoAnalyticsView> IDDimension { get; set; } 
        public IRPSComboBox<BankRecoAnalyticsView> IDDimValue { get; set; } 
        public IRPSTextBox<BankRecoAnalyticsView> Percentage { get; set; } 
        public BankReconciliation Screen { get; set; }
        public BankRecoAnalyticsView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ImportCSBDialogView : View
    {
        public ImportCSBDialogView(BankReconciliation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDBankAccountCompany = RPSControlFactory.CreateRPSComboBox<ImportCSBDialogView>("11ab71af-0e70-4fdd-b1f9-074e760a4897","","",true, this);
 
            NEW = RPSControlFactory.CreateRPSOption<ImportCSBDialogView>( "a782c408-7371-4df4-9e4d-4f03f4d8afec","","",this);
 
            EXISTING = RPSControlFactory.CreateRPSOption<ImportCSBDialogView>( "225f1304-6460-4b80-9896-9ffa0d33babf","","",this);
 
            NewNumberBankPaymentForExcellImport = RPSControlFactory.CreateRPSTextBox<ImportCSBDialogView>("57728c64-d213-4386-8f67-81d34f91d23d","","",false, this);
 
            NumberBankPaymentForExcellImport = RPSControlFactory.CreateRPSEnumComboBox<ImportCSBDialogView>("5676c22e-284b-4328-882a-b3dd97cf5f9e","","",false, this);
 

        }
        public IRPSComboBox<ImportCSBDialogView> IDBankAccountCompany { get; set; } 
        public IRPSOption<ImportCSBDialogView> NEW { get; set; } 
        public IRPSOption<ImportCSBDialogView> EXISTING { get; set; } 
        public IRPSTextBox<ImportCSBDialogView> NewNumberBankPaymentForExcellImport { get; set; } 
        public IRPSComboBox<ImportCSBDialogView> NumberBankPaymentForExcellImport { get; set; } 
        public BankReconciliation Screen { get; set; }
        public ImportCSBDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ImportExcelDialogView : View
    {
        public ImportExcelDialogView(BankReconciliation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDBankAccountCompany = RPSControlFactory.CreateRPSComboBox<ImportExcelDialogView>("307560fc-f748-4594-9136-68472b25772b","","",true, this);
 
            NEW = RPSControlFactory.CreateRPSOption<ImportExcelDialogView>( "9c4802b3-782f-4573-bf6f-f49acfabaf36","","",this);
 
            EXISTING = RPSControlFactory.CreateRPSOption<ImportExcelDialogView>( "5c5835ec-9991-4875-9767-9f720d19ebbc","","",this);
 
            NewNumberBankPaymentForExcellImport = RPSControlFactory.CreateRPSTextBox<ImportExcelDialogView>("e08c2736-e7a6-4b95-971e-56cffcb9535d","","",false, this);
 
            NumberBankPaymentForExcellImport = RPSControlFactory.CreateRPSEnumComboBox<ImportExcelDialogView>("c19c5354-a20a-4b5e-94d8-5e8ee3604c8a","","",false, this);
 

        }
        public IRPSComboBox<ImportExcelDialogView> IDBankAccountCompany { get; set; } 
        public IRPSOption<ImportExcelDialogView> NEW { get; set; } 
        public IRPSOption<ImportExcelDialogView> EXISTING { get; set; } 
        public IRPSTextBox<ImportExcelDialogView> NewNumberBankPaymentForExcellImport { get; set; } 
        public IRPSComboBox<ImportExcelDialogView> NumberBankPaymentForExcellImport { get; set; } 
        public BankReconciliation Screen { get; set; }
        public ImportExcelDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MassiveChangeChildDialogView : View
    {
        public MassiveChangeChildDialogView(BankReconciliation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            PaymentStatusAR = RPSControlFactory.CreateRPSComboBox<MassiveChangeChildDialogView>("6307bed9-6ddd-4f68-a0d1-1523f291ad38","","",false, this);
 
            PaymentStatusAP = RPSControlFactory.CreateRPSComboBox<MassiveChangeChildDialogView>("93a8234b-5971-479b-9480-3c203f5586ce","","",false, this);
 
            IDAccount = RPSControlFactory.CreateRPSComboBox<MassiveChangeChildDialogView>("3204e33f-abaa-441d-b475-2fcd4cb19b1c","","",false, this);
 

        }
        public IRPSComboBox<MassiveChangeChildDialogView> PaymentStatusAR { get; set; } 
        public IRPSComboBox<MassiveChangeChildDialogView> PaymentStatusAP { get; set; } 
        public IRPSComboBox<MassiveChangeChildDialogView> IDAccount { get; set; } 
        public BankReconciliation Screen { get; set; }
        public MassiveChangeChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class BankRecoDetailView : View
    {
        public BankRecoDetailView(BankReconciliation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<BankRecoDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<BankRecoDetailView,BankReconciliationVMEntityView>( this,Screen.BankReconciliationVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<BankRecoDetailView,BankReconciliationVMEntityView>( this,Screen.BankReconciliationVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<BankRecoDetailView,BankReconciliationVMEntityView>( this,Screen.BankReconciliationVMEntityView);
 
            IDRPTransaction = RPSControlFactory.CreateRPSComboBox<BankRecoDetailView>("d2e49fef-40b6-4ddc-ac2b-873fa4f241e2","","",true, this);
 
            UIIDThird = RPSControlFactory.CreateRPSComboBox<BankRecoDetailView>("e42d0f24-6b17-4dc8-b648-5d664153a757","","",false, this);
 
            UIAmountNominal = RPSControlFactory.CreateRPSFormattedTextBox<BankRecoDetailView>("d671b6b4-2249-412b-b778-da063894e9c6","","",false, this);
 
            UIAmountNominalCurrency = RPSControlFactory.CreateRPSFormattedTextBox<BankRecoDetailView>("23b07345-c074-4dae-9121-9ea2adc2de53","","",false, this);
 
            UIIDPaymentType = RPSControlFactory.CreateRPSComboBox<BankRecoDetailView>("5b739cee-36c7-4772-b572-ac0470910628","","",false, this);
 
            UIIDPaymentStatus = RPSControlFactory.CreateRPSComboBox<BankRecoDetailView>("1990bc22-505c-4552-91e5-bc547031c9ae","","",false, this);
 
            PaidAmount = RPSControlFactory.CreateRPSFormattedTextBox<BankRecoDetailView>("631edaf0-51de-4f8a-9f8f-acfb1e3fcd4f","","",true, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<BankRecoDetailView>("969c3016-b98b-4438-b97a-791782764631","","",true, this);
 
            IDPaymentStatus = RPSControlFactory.CreateRPSComboBox<BankRecoDetailView>("803f8025-d115-499d-8c25-9a2d3545930a","","",true, this);
 

        }
        public IRPSButton<BankRecoDetailView> DeleteButton { get; set; } 
        public IRPSButton<BankRecoDetailView,BankReconciliationVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<BankRecoDetailView,BankReconciliationVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<BankRecoDetailView,BankReconciliationVMEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<BankRecoDetailView> IDRPTransaction { get; set; } 
        public IRPSComboBox<BankRecoDetailView> UIIDThird { get; set; } 
        public IRPSTextBox<BankRecoDetailView> UIAmountNominal { get; set; } 
        public IRPSTextBox<BankRecoDetailView> UIAmountNominalCurrency { get; set; } 
        public IRPSComboBox<BankRecoDetailView> UIIDPaymentType { get; set; } 
        public IRPSComboBox<BankRecoDetailView> UIIDPaymentStatus { get; set; } 
        public IRPSTextBox<BankRecoDetailView> PaidAmount { get; set; } 
        public IRPSComboBox<BankRecoDetailView> IDCurrency { get; set; } 
        public IRPSComboBox<BankRecoDetailView> IDPaymentStatus { get; set; } 
        public BankReconciliation Screen { get; set; }
        public BankRecoDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class AddRemittanceChidDialogView : View
    {
        public AddRemittanceChidDialogView(BankReconciliation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DateFrom = RPSControlFactory.CreateRPSTextBox<AddRemittanceChidDialogView>("a578c490-426f-4940-b20b-246353eef2da","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<AddRemittanceChidDialogView>("b0986722-9eff-4c45-8f32-5aeb4385c63a","","",false, this);
 
            bExcludeFinal = RPSControlFactory.CreateRPSCheckBox<AddRemittanceChidDialogView>("d2bef543-6654-413f-b30c-e0f138d4206a","","",false, this);
 
            ExecuteGetBankAccountCompanyRemittanceNumbers = RPSControlFactory.CreateRPSButton<AddRemittanceChidDialogView>( "64fbc5b9-2412-49ad-a3ba-8459fc8ee9fe","","",this);
 
            CollectionInit params_GetBankAccountCompanyRemittanceNumbers = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="9042d1a7-08e1-4938-8938-d13b1aa41815",CSSSelectorGrid="",XPathGrid=""};
            GetBankAccountCompanyRemittanceNumbers = RPSControlFactory.RPSCreateCollectionWithGrid<GetBankAccountCompanyRemittanceNumbersCollectionEditor<AddRemittanceChidDialogView>,AddRemittanceChidDialogView>( params_GetBankAccountCompanyRemittanceNumbers,this);
 

        }
        public IRPSTextBox<AddRemittanceChidDialogView> DateFrom { get; set; } 
        public IRPSTextBox<AddRemittanceChidDialogView> DateTo { get; set; } 
        public IRPSCheckbox<AddRemittanceChidDialogView> bExcludeFinal { get; set; } 
        public IRPSButton<AddRemittanceChidDialogView> ExecuteGetBankAccountCompanyRemittanceNumbers { get; set; } 
        public GetBankAccountCompanyRemittanceNumbersCollectionEditor<AddRemittanceChidDialogView> GetBankAccountCompanyRemittanceNumbers { get; set; } 
        public BankReconciliation Screen { get; set; }
        public AddRemittanceChidDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetBankAccountCompanyRemittanceNumbersCollectionEditor<AddRemittanceChidDialogView>:RPSCollectionEditor<AddRemittanceChidDialogView> where AddRemittanceChidDialogView : class, IView
    {
        public  GetBankAccountCompanyRemittanceNumbersGridView<AddRemittanceChidDialogView> GridView {get;set;}
    }
    public partial class GetBankAccountCompanyRemittanceNumbersGridView <AddRemittanceChidDialogView> :  RPSGridView<AddRemittanceChidDialogView> where AddRemittanceChidDialogView : class, IView
    {
        public GetBankAccountCompanyRemittanceNumbersGridView(AddRemittanceChidDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            RemittanceNumber = RPSControlFactory.CreateRPSGridTextBox<AddRemittanceChidDialogView>("","#9042d1a7-08e1-4938-8938-d13b1aa41815 .ag-row[role='row']@ROWINDEX [col-id='cRemittanceNumber']","",false, this.CurrentView);
 
            RemittanceDate = RPSControlFactory.CreateRPSGridTextBox<AddRemittanceChidDialogView>("","#9042d1a7-08e1-4938-8938-d13b1aa41815 .ag-row[role='row']@ROWINDEX [col-id='cRemittanceDate']","",false, this.CurrentView);
 
            CustomerSupplier = RPSControlFactory.CreateRPSGridEnumComboBox<AddRemittanceChidDialogView>("","#9042d1a7-08e1-4938-8938-d13b1aa41815 .ag-row[role='row']@ROWINDEX [col-id='cCustomerSupplier']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<AddRemittanceChidDialogView> RemittanceNumber { get; set; } 
        public IRPSGridTextBox<AddRemittanceChidDialogView> RemittanceDate { get; set; } 
        public IRPSGridComboBox<AddRemittanceChidDialogView> CustomerSupplier { get; set; } 
                     
    }
 
    }
  
            
    public partial class ExecuteActionsChildDialogView : View
    {
        public ExecuteActionsChildDialogView(BankReconciliation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDVoucherType = RPSControlFactory.CreateRPSComboBox<ExecuteActionsChildDialogView>("777c8422-2557-4984-acd4-d8c5665be288","","",true, this);
 
            IDVoucherSeriesBook = RPSControlFactory.CreateRPSComboBox<ExecuteActionsChildDialogView>("1e791469-719f-429e-ab25-2ae83b73c057","","",true, this);
 
            UIARPaymentStatus = RPSControlFactory.CreateRPSComboBox<ExecuteActionsChildDialogView>("42272fcf-a654-4174-a640-cdd929b4401d","","",false, this);
 
            UIAPPaymentStatus = RPSControlFactory.CreateRPSComboBox<ExecuteActionsChildDialogView>("05d1b5d2-820f-4824-94e1-81d19161b9ef","","",false, this);
 

        }
        public IRPSComboBox<ExecuteActionsChildDialogView> IDVoucherType { get; set; } 
        public IRPSComboBox<ExecuteActionsChildDialogView> IDVoucherSeriesBook { get; set; } 
        public IRPSComboBox<ExecuteActionsChildDialogView> UIARPaymentStatus { get; set; } 
        public IRPSComboBox<ExecuteActionsChildDialogView> UIAPPaymentStatus { get; set; } 
        public BankReconciliation Screen { get; set; }
        public ExecuteActionsChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class AccTransactionsGridChildDialogView : View
    {
        public AccTransactionsGridChildDialogView(BankReconciliation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_GetACCTransactionsFromStorageKey = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="cccf4da1-d0b9-46bf-b44d-a8be0126fa22",CSSSelectorGrid="",XPathGrid=""};
            GetACCTransactionsFromStorageKey = RPSControlFactory.RPSCreateCollectionWithGrid<GetACCTransactionsFromStorageKeyCollectionEditor<AccTransactionsGridChildDialogView>,AccTransactionsGridChildDialogView>( params_GetACCTransactionsFromStorageKey,this);
 

        }
        public GetACCTransactionsFromStorageKeyCollectionEditor<AccTransactionsGridChildDialogView> GetACCTransactionsFromStorageKey { get; set; } 
        public BankReconciliation Screen { get; set; }
        public AccTransactionsGridChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetACCTransactionsFromStorageKeyCollectionEditor<AccTransactionsGridChildDialogView>:RPSCollectionEditor<AccTransactionsGridChildDialogView> where AccTransactionsGridChildDialogView : class, IView
    {
        public  GetACCTransactionsFromStorageKeyGridView<AccTransactionsGridChildDialogView> GridView {get;set;}
    }
    public partial class GetACCTransactionsFromStorageKeyGridView <AccTransactionsGridChildDialogView> :  RPSGridView<AccTransactionsGridChildDialogView> where AccTransactionsGridChildDialogView : class, IView
    {
        public GetACCTransactionsFromStorageKeyGridView(AccTransactionsGridChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            AccountingDate = RPSControlFactory.CreateRPSGridTextBox<AccTransactionsGridChildDialogView>("","#cccf4da1-d0b9-46bf-b44d-a8be0126fa22 .ag-row[role='row']@ROWINDEX [col-id='cAccountingDate']","",false, this.CurrentView);
 
            JournalNumber = RPSControlFactory.CreateRPSGridFormattedTextBox<AccTransactionsGridChildDialogView>("","#cccf4da1-d0b9-46bf-b44d-a8be0126fa22 .ag-row[role='row']@ROWINDEX [col-id='cJournalNumber']","",false, this.CurrentView);
 
            VoucherNumberLine = RPSControlFactory.CreateRPSGridFormattedTextBox<AccTransactionsGridChildDialogView>("","#cccf4da1-d0b9-46bf-b44d-a8be0126fa22 .ag-row[role='row']@ROWINDEX [col-id='cVoucherNumberLine']","",false, this.CurrentView);
 
            Extension = RPSControlFactory.CreateRPSGridTextBox<AccTransactionsGridChildDialogView>("","#cccf4da1-d0b9-46bf-b44d-a8be0126fa22 .ag-row[role='row']@ROWINDEX [col-id='cExtension']","",false, this.CurrentView);
 
            SignType = RPSControlFactory.CreateRPSGridEnumComboBox<AccTransactionsGridChildDialogView>("","#cccf4da1-d0b9-46bf-b44d-a8be0126fa22 .ag-row[role='row']@ROWINDEX [col-id='cSignType']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<AccTransactionsGridChildDialogView> AccountingDate { get; set; } 
        public IRPSGridTextBox<AccTransactionsGridChildDialogView> JournalNumber { get; set; } 
        public IRPSGridTextBox<AccTransactionsGridChildDialogView> VoucherNumberLine { get; set; } 
        public IRPSGridTextBox<AccTransactionsGridChildDialogView> Extension { get; set; } 
        public IRPSGridComboBox<AccTransactionsGridChildDialogView> SignType { get; set; } 
                     
    }
 
    }
  
            
    public partial class ExecuteActionOneBankReconciliationChildDialogView : View
    {
        public ExecuteActionOneBankReconciliationChildDialogView(BankReconciliation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDVoucherType = RPSControlFactory.CreateRPSComboBox<ExecuteActionOneBankReconciliationChildDialogView>("e81510b4-ec92-4ee9-aa5b-8c7c663a8559","","",true, this);
 
            IDVoucherSeriesBook = RPSControlFactory.CreateRPSComboBox<ExecuteActionOneBankReconciliationChildDialogView>("101ff3ca-dd39-4589-b374-b99478c53e04","","",true, this);
 
            UIARPaymentStatus = RPSControlFactory.CreateRPSComboBox<ExecuteActionOneBankReconciliationChildDialogView>("3b6056fb-fd70-49a5-857f-a75819c62e13","","",false, this);
 
            UIAPPaymentStatus = RPSControlFactory.CreateRPSComboBox<ExecuteActionOneBankReconciliationChildDialogView>("6792e6ae-446e-48cf-a621-0dde3f3b3a3f","","",false, this);
 

        }
        public IRPSComboBox<ExecuteActionOneBankReconciliationChildDialogView> IDVoucherType { get; set; } 
        public IRPSComboBox<ExecuteActionOneBankReconciliationChildDialogView> IDVoucherSeriesBook { get; set; } 
        public IRPSComboBox<ExecuteActionOneBankReconciliationChildDialogView> UIARPaymentStatus { get; set; } 
        public IRPSComboBox<ExecuteActionOneBankReconciliationChildDialogView> UIAPPaymentStatus { get; set; } 
        public BankReconciliation Screen { get; set; }
        public ExecuteActionOneBankReconciliationChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class AccTransactionsGridOneBankReconciliationChildDialogView : View
    {
        public AccTransactionsGridOneBankReconciliationChildDialogView(BankReconciliation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_GetACCTransactionsFromStorageKey = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b28067a1-5c5b-485e-a0e6-e3e10796ff1c",CSSSelectorGrid="",XPathGrid=""};
            GetACCTransactionsFromStorageKey = RPSControlFactory.RPSCreateCollectionWithGrid<GetACCTransactionsFromStorageKeyCollectionEditor<AccTransactionsGridOneBankReconciliationChildDialogView>,AccTransactionsGridOneBankReconciliationChildDialogView>( params_GetACCTransactionsFromStorageKey,this);
 

        }
        public GetACCTransactionsFromStorageKeyCollectionEditor<AccTransactionsGridOneBankReconciliationChildDialogView> GetACCTransactionsFromStorageKey { get; set; } 
        public BankReconciliation Screen { get; set; }
        public AccTransactionsGridOneBankReconciliationChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetACCTransactionsFromStorageKeyCollectionEditor<AccTransactionsGridOneBankReconciliationChildDialogView>:RPSCollectionEditor<AccTransactionsGridOneBankReconciliationChildDialogView> where AccTransactionsGridOneBankReconciliationChildDialogView : class, IView
    {
        public  GetACCTransactionsFromStorageKeyGridView<AccTransactionsGridOneBankReconciliationChildDialogView> GridView {get;set;}
    }
    public partial class GetACCTransactionsFromStorageKeyGridView <AccTransactionsGridOneBankReconciliationChildDialogView> :  RPSGridView<AccTransactionsGridOneBankReconciliationChildDialogView> where AccTransactionsGridOneBankReconciliationChildDialogView : class, IView
    {
        public GetACCTransactionsFromStorageKeyGridView(AccTransactionsGridOneBankReconciliationChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            AccountingDate = RPSControlFactory.CreateRPSGridTextBox<AccTransactionsGridOneBankReconciliationChildDialogView>("","#b28067a1-5c5b-485e-a0e6-e3e10796ff1c .ag-row[role='row']@ROWINDEX [col-id='cAccountingDate']","",false, this.CurrentView);
 
            JournalNumber = RPSControlFactory.CreateRPSGridFormattedTextBox<AccTransactionsGridOneBankReconciliationChildDialogView>("","#b28067a1-5c5b-485e-a0e6-e3e10796ff1c .ag-row[role='row']@ROWINDEX [col-id='cJournalNumber']","",false, this.CurrentView);
 
            VoucherNumberLine = RPSControlFactory.CreateRPSGridFormattedTextBox<AccTransactionsGridOneBankReconciliationChildDialogView>("","#b28067a1-5c5b-485e-a0e6-e3e10796ff1c .ag-row[role='row']@ROWINDEX [col-id='cVoucherNumberLine']","",false, this.CurrentView);
 
            Extension = RPSControlFactory.CreateRPSGridTextBox<AccTransactionsGridOneBankReconciliationChildDialogView>("","#b28067a1-5c5b-485e-a0e6-e3e10796ff1c .ag-row[role='row']@ROWINDEX [col-id='cExtension']","",false, this.CurrentView);
 
            SignType = RPSControlFactory.CreateRPSGridEnumComboBox<AccTransactionsGridOneBankReconciliationChildDialogView>("","#b28067a1-5c5b-485e-a0e6-e3e10796ff1c .ag-row[role='row']@ROWINDEX [col-id='cSignType']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<AccTransactionsGridOneBankReconciliationChildDialogView> AccountingDate { get; set; } 
        public IRPSGridTextBox<AccTransactionsGridOneBankReconciliationChildDialogView> JournalNumber { get; set; } 
        public IRPSGridTextBox<AccTransactionsGridOneBankReconciliationChildDialogView> VoucherNumberLine { get; set; } 
        public IRPSGridTextBox<AccTransactionsGridOneBankReconciliationChildDialogView> Extension { get; set; } 
        public IRPSGridComboBox<AccTransactionsGridOneBankReconciliationChildDialogView> SignType { get; set; } 
                     
    }
 
    }
  
            
    public partial class AddDraftChildDialogView : View
    {
        public AddDraftChildDialogView(BankReconciliation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIARPaymentStatusReal = RPSControlFactory.CreateRPSComboBox<AddDraftChildDialogView>("d2db1162-b28c-4d86-8386-2c78aae2797e","","",false, this);
 
            UIAPPaymentStatusReal = RPSControlFactory.CreateRPSComboBox<AddDraftChildDialogView>("f9ee7bf1-7169-4b83-be8b-9318677eff8b","","",false, this);
 

        }
        public IRPSComboBox<AddDraftChildDialogView> UIARPaymentStatusReal { get; set; } 
        public IRPSComboBox<AddDraftChildDialogView> UIAPPaymentStatusReal { get; set; } 
        public BankReconciliation Screen { get; set; }
        public AddDraftChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}