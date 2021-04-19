    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.BankReconciliationManual
{
    //RPS VERSION 1.0.0.0
    public partial class BankReconciliationManual:Screen
    {
        public BankReconciliationManual():base()
        {
            this.URL = "generalledger.bankreconciliationmanual";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            BankReconciliationManualView  = new BankReconciliationManualView(this); 
            BankReconciliationManualView.InitializeControls(); 
           
        }
      
            public BankReconciliationManualView BankReconciliationManualView {get; set; } 
    }
            
    public partial class BankReconciliationManualView : View
    {
        public BankReconciliationManualView(BankReconciliationManual screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDBankAccountCompany = RPSControlFactory.CreateRPSComboBox<BankReconciliationManualView>("5816abfa-22eb-4d9b-bb4e-70dd6dc1d2f1","","",true, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<BankReconciliationManualView>("d928f8f4-1a4e-46bb-a37a-aff1a10b5b23","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<BankReconciliationManualView>("57ef0b97-8da9-4e2b-a742-55898f612e58","","",false, this);
 
            StatementNumber = RPSControlFactory.CreateRPSEnumComboBox<BankReconciliationManualView>("cb966153-935d-4bc5-9eba-c083d5f3ffc8","","",false, this);
 
            ConsultCommand = RPSControlFactory.CreateRPSButton<BankReconciliationManualView>( "ceb8eabb-af06-422e-8b69-d53fb2016cc0","","",this);
 
            SelectConciliatedVouchersCommandButton = RPSControlFactory.CreateRPSButton<BankReconciliationManualView>( "80aa5530-f9a5-4d33-b1e3-eea57272b5d5","","",this);
 
            BankReconciliation_Status = RPSControlFactory.CreateRPSTextBox<BankReconciliationManualView>("6aec1248-30a6-4d5c-9790-e1b522b4584d","","",false, this);
 
            BankReconciliation_NumberBankPayment = RPSControlFactory.CreateRPSTextBox<BankReconciliationManualView>("0a7d2764-cee7-4a9e-95b3-3d9e9c8a0925","","",false, this);
 
            BankReconciliation_MovementDate = RPSControlFactory.CreateRPSTextBox<BankReconciliationManualView>("2d08a896-1ae3-448d-848a-d38aaa52b1cc","","",false, this);
 
            BankReconciliation_SignType = RPSControlFactory.CreateRPSTextBox<BankReconciliationManualView>("b0f9291b-8faf-4943-9acb-4066d2c62170","","",false, this);
 
            BankReconciliation_Description = RPSControlFactory.CreateRPSTextBox<BankReconciliationManualView>("95ab626c-65fe-4596-95fa-fd2420250a3b","","",false, this);
 
            BankReconciliation_Key = RPSControlFactory.CreateRPSTextBox<BankReconciliationManualView>("345fe177-6d46-4808-953d-52c374147796","","",false, this);
 
            BankReconciliation_RecoKey = RPSControlFactory.CreateRPSTextBox<BankReconciliationManualView>("7196da5c-9773-4d86-900f-92d7437989d4","","",false, this);
 
            BankReconciliation_CheckNumber = RPSControlFactory.CreateRPSTextBox<BankReconciliationManualView>("a1c3163e-e665-4ffb-b7b0-1f18ff5a70e8","","",false, this);
 
            BankReconciliation_TextReference1 = RPSControlFactory.CreateRPSTextBox<BankReconciliationManualView>("40e8efd5-5877-4404-8b9a-1eb4077e9d40","","",false, this);
 
            BankReconciliation_TextReference2 = RPSControlFactory.CreateRPSTextBox<BankReconciliationManualView>("7b8d4ce5-bce7-48d2-bf59-247ff45457be","","",false, this);
 
            BankReconciliation_ValueDate = RPSControlFactory.CreateRPSTextBox<BankReconciliationManualView>("e31cda14-01d9-45e9-b6eb-75b8c75a51be","","",false, this);
 
            SelectConciliatedMovementsCommandButton = RPSControlFactory.CreateRPSButton<BankReconciliationManualView>( "084164de-58fb-42ce-b728-0ad7139dde67","","",this);
 
            Status = RPSControlFactory.CreateRPSTextBox<BankReconciliationManualView>("8ffa1f52-d41f-46dd-b589-7c182c05c7b8","","",false, this);
 
            AccountingDate = RPSControlFactory.CreateRPSTextBox<BankReconciliationManualView>("1456becb-bac0-40eb-b546-5fc5a1bc947d","","",false, this);
 
            JournalNumber = RPSControlFactory.CreateRPSFormattedTextBox<BankReconciliationManualView>("25dd72a4-9829-47b1-9489-845b3cd011aa","","",false, this);
 
            VoucherNumberLine = RPSControlFactory.CreateRPSFormattedTextBox<BankReconciliationManualView>("ab3e5a93-a255-4779-bfb7-3c35dc3689bb","","",false, this);
 
            SignType = RPSControlFactory.CreateRPSTextBox<BankReconciliationManualView>("8567c3f6-9e42-4197-8b29-3a2a1dde947d","","",false, this);
 
            Extension = RPSControlFactory.CreateRPSTextBox<BankReconciliationManualView>("1bc8e128-908d-4159-8e98-c9a2a528319f","","",false, this);
 
            ReconciliationCommandButton = RPSControlFactory.CreateRPSButton<BankReconciliationManualView>( "5a518cda-dff3-4c8c-b5ba-c467fbe6985f","","",this);
 
            UndoReconciliationCommandButton = RPSControlFactory.CreateRPSButton<BankReconciliationManualView>( "603da2ff-2586-4212-97f8-1a0bfe018201","","",this);
 
            CollectionInit params_BankReconciliationConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="30ec08b1-acf4-4afd-b73b-224990225118",CSSSelectorGrid="",XPathGrid=""};
            BankReconciliationConsult = RPSControlFactory.RPSCreateCollectionWithGrid<BankReconciliationConsultCollectionEditor<BankReconciliationManualView>,BankReconciliationManualView>( params_BankReconciliationConsult,this);
 
            CollectionInit params_TransactionsDetailConciliation = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="9d87caa6-6c92-469a-b40f-4a0a1d438347",CSSSelectorGrid="",XPathGrid=""};
            TransactionsDetailConciliation = RPSControlFactory.RPSCreateCollectionWithGrid<TransactionsDetailConciliationCollectionEditor<BankReconciliationManualView>,BankReconciliationManualView>( params_TransactionsDetailConciliation,this);
 

        }
        public IRPSComboBox<BankReconciliationManualView> IDBankAccountCompany { get; set; } 
        public IRPSTextBox<BankReconciliationManualView> DateFrom { get; set; } 
        public IRPSTextBox<BankReconciliationManualView> DateTo { get; set; } 
        public IRPSComboBox<BankReconciliationManualView> StatementNumber { get; set; } 
        public IRPSButton<BankReconciliationManualView> ConsultCommand { get; set; } 
        public IRPSButton<BankReconciliationManualView> SelectConciliatedVouchersCommandButton { get; set; } 
        public IRPSTextBox<BankReconciliationManualView> BankReconciliation_Status { get; set; } 
        public IRPSTextBox<BankReconciliationManualView> BankReconciliation_NumberBankPayment { get; set; } 
        public IRPSTextBox<BankReconciliationManualView> BankReconciliation_MovementDate { get; set; } 
        public IRPSTextBox<BankReconciliationManualView> BankReconciliation_SignType { get; set; } 
        public IRPSTextBox<BankReconciliationManualView> BankReconciliation_Description { get; set; } 
        public IRPSTextBox<BankReconciliationManualView> BankReconciliation_Key { get; set; } 
        public IRPSTextBox<BankReconciliationManualView> BankReconciliation_RecoKey { get; set; } 
        public IRPSTextBox<BankReconciliationManualView> BankReconciliation_CheckNumber { get; set; } 
        public IRPSTextBox<BankReconciliationManualView> BankReconciliation_TextReference1 { get; set; } 
        public IRPSTextBox<BankReconciliationManualView> BankReconciliation_TextReference2 { get; set; } 
        public IRPSTextBox<BankReconciliationManualView> BankReconciliation_ValueDate { get; set; } 
        public IRPSButton<BankReconciliationManualView> SelectConciliatedMovementsCommandButton { get; set; } 
        public IRPSTextBox<BankReconciliationManualView> Status { get; set; } 
        public IRPSTextBox<BankReconciliationManualView> AccountingDate { get; set; } 
        public IRPSTextBox<BankReconciliationManualView> JournalNumber { get; set; } 
        public IRPSTextBox<BankReconciliationManualView> VoucherNumberLine { get; set; } 
        public IRPSTextBox<BankReconciliationManualView> SignType { get; set; } 
        public IRPSTextBox<BankReconciliationManualView> Extension { get; set; } 
        public IRPSButton<BankReconciliationManualView> ReconciliationCommandButton { get; set; } 
        public IRPSButton<BankReconciliationManualView> UndoReconciliationCommandButton { get; set; } 
        public BankReconciliationConsultCollectionEditor<BankReconciliationManualView> BankReconciliationConsult { get; set; } 
        public TransactionsDetailConciliationCollectionEditor<BankReconciliationManualView> TransactionsDetailConciliation { get; set; } 
        public BankReconciliationManual Screen { get; set; }
        public BankReconciliationManualView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class BankReconciliationConsultCollectionEditor<BankReconciliationManualView>:RPSCollectionEditor<BankReconciliationManualView> where BankReconciliationManualView : class, IView
    {
        public  BankReconciliationConsultGridView<BankReconciliationManualView> GridView {get;set;}
    }
    public partial class BankReconciliationConsultGridView <BankReconciliationManualView> :  RPSGridView<BankReconciliationManualView> where BankReconciliationManualView : class, IView
    {
        public BankReconciliationConsultGridView(BankReconciliationManualView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            BankReconciliation_Status = RPSControlFactory.CreateRPSGridTextBox<BankReconciliationManualView>("","#30ec08b1-acf4-4afd-b73b-224990225118 .ag-row[role='row']@ROWINDEX [col-id='cBankReconciliation_Status']","",false, this.CurrentView);
 
            BankReconciliation_SignType = RPSControlFactory.CreateRPSGridTextBox<BankReconciliationManualView>("","#30ec08b1-acf4-4afd-b73b-224990225118 .ag-row[role='row']@ROWINDEX [col-id='cBankReconciliation_SignType']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<BankReconciliationManualView> BankReconciliation_Status { get; set; } 
        public IRPSGridTextBox<BankReconciliationManualView> BankReconciliation_SignType { get; set; } 
                     
    }
 
        public partial class TransactionsDetailConciliationCollectionEditor<BankReconciliationManualView>:RPSCollectionEditor<BankReconciliationManualView> where BankReconciliationManualView : class, IView
    {
        public  TransactionsDetailConciliationGridView<BankReconciliationManualView> GridView {get;set;}
    }
    public partial class TransactionsDetailConciliationGridView <BankReconciliationManualView> :  RPSGridView<BankReconciliationManualView> where BankReconciliationManualView : class, IView
    {
        public TransactionsDetailConciliationGridView(BankReconciliationManualView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Status = RPSControlFactory.CreateRPSGridTextBox<BankReconciliationManualView>("","#9d87caa6-6c92-469a-b40f-4a0a1d438347 .ag-row[role='row']@ROWINDEX [col-id='cStatus']","",false, this.CurrentView);
 
            SignType = RPSControlFactory.CreateRPSGridTextBox<BankReconciliationManualView>("","#9d87caa6-6c92-469a-b40f-4a0a1d438347 .ag-row[role='row']@ROWINDEX [col-id='cSignType']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<BankReconciliationManualView> Status { get; set; } 
        public IRPSGridTextBox<BankReconciliationManualView> SignType { get; set; } 
                     
    }
 
    }
  
    

}