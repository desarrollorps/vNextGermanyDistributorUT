    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.ReceivablePayable.DraftManagement
{
    //RPS VERSION 1.0.0.0
    public partial class DraftManagement:Screen
    {
        public DraftManagement():base()
        {
            this.URL = "receivablepayable.draftmanagement";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            RPTransactionsCollectionView  = new RPTransactionsCollectionView(this); 
            RPTransactionsEntityView  = new RPTransactionsEntityView(this); 
            DraftSplitChildDialogView  = new DraftSplitChildDialogView(this); 
            RPTransactionsCollectionView.InitializeControls(); 
            RPTransactionsEntityView.InitializeControls(); 
            DraftSplitChildDialogView.InitializeControls(); 
           
        }
      
            public RPTransactionsCollectionView RPTransactionsCollectionView {get; set; } 
            public RPTransactionsEntityView RPTransactionsEntityView {get; set; } 
            public DraftSplitChildDialogView DraftSplitChildDialogView {get; set; } 
    }
            
    public partial class RPTransactionsCollectionView : View
    {
        public RPTransactionsCollectionView(DraftManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<RPTransactionsCollectionView,RPTransactionsEntityView>( this,Screen.RPTransactionsEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "3482c4e2-1c0d-42d0-8ff4-ff88633d114b",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<RPTransactionsCollectionView,RPTransactionsEntityView>( params_MainConsult,this,Screen.RPTransactionsEntityView);
 

        }
        public IRPSButton<RPTransactionsCollectionView,RPTransactionsEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<RPTransactionsCollectionView,RPTransactionsEntityView> MainConsult { get; set; } 
        public DraftManagement Screen { get; set; }
        public RPTransactionsCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class RPTransactionsEntityView : View
    {
        public RPTransactionsEntityView(DraftManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<RPTransactionsEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<RPTransactionsEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<RPTransactionsEntityView,RPTransactionsCollectionView>( this,Screen.RPTransactionsCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<RPTransactionsEntityView,RPTransactionsCollectionView>( this,Screen.RPTransactionsCollectionView);
 
            CustomerSupplier = RPSControlFactory.CreateRPSEnumComboBox<RPTransactionsEntityView>("52db58c8-2c55-4d2e-8c4d-4e29ae90c193","","",true, this);
 
            CodInvoice = RPSControlFactory.CreateRPSTextBox<RPTransactionsEntityView>("1dc1411a-f9d7-40d9-9ceb-5d986d8d4d42","","",true, this);
 
            IDUIInvoice = RPSControlFactory.CreateRPSComboBox<RPTransactionsEntityView>("bc2a7e25-457e-44d5-a02e-b7831e3e8c52","","",false, this);
 
            IDUIInvoiceSL = RPSControlFactory.CreateRPSComboBox<RPTransactionsEntityView>("63a0396b-2751-41f6-9fa5-a15523daa595","","",false, this);
 
            InvoiceDate = RPSControlFactory.CreateRPSTextBox<RPTransactionsEntityView>("bf6f0b58-ff7f-494a-9e72-ab88ad69ed21","","",true, this);
 
            DraftNumber = RPSControlFactory.CreateRPSFormattedTextBox<RPTransactionsEntityView>("b6e027bc-fb82-4546-8169-8a481e8ba0e6","","",true, this);
 
            DueDate = RPSControlFactory.CreateRPSTextBox<RPTransactionsEntityView>("714674c1-bce1-4804-8feb-e58b646799c4","","",true, this);
 
            IDACCTransactions = RPSControlFactory.CreateRPSComboBox<RPTransactionsEntityView>("13420f02-a8a0-4a21-a7d7-77cc5bbd3ba2","","",false, this);
 
            Nullified = RPSControlFactory.CreateRPSCheckBox<RPTransactionsEntityView>("95b915bf-6771-47da-ad1d-19ea38d9e160","","",true, this);
 
            Advance = RPSControlFactory.CreateRPSCheckBox<RPTransactionsEntityView>("e139684f-3227-48fb-a10f-6c5a22031087","","",true, this);
 
            IDPaymentType = RPSControlFactory.CreateRPSComboBox<RPTransactionsEntityView>("9937d56d-c8f5-4539-9d09-8f717e73e070","","",true, this);
 
            IDPaymentStatus = RPSControlFactory.CreateRPSComboBox<RPTransactionsEntityView>("2f5d898c-0fe1-4807-b897-82e6e6c571ff","","",true, this);
 
            CodFromInvoice = RPSControlFactory.CreateRPSTextBox<RPTransactionsEntityView>("5f990d1e-cdb3-4310-b1b7-07696566900d","","",false, this);
 
            RefNumber = RPSControlFactory.CreateRPSTextBox<RPTransactionsEntityView>("32292057-c61f-45bf-b92d-fae142a17df6","","",false, this);
 
            RefDate = RPSControlFactory.CreateRPSTextBox<RPTransactionsEntityView>("dc8cc2ba-5bb2-4c0c-9336-dc64060300fa","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<RPTransactionsEntityView>("0a2372fd-2b45-4c14-941d-4d7dfc88e7ca","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<RPTransactionsEntityView>("d69bb7a7-5a66-4f1b-99aa-3b2f3b2da774","","",false, this);
 
            IDCustomerMiscellaneous = RPSControlFactory.CreateRPSComboBox<RPTransactionsEntityView>("5c167aa6-0d2e-46b6-a0d8-d3fa0e928920","","",false, this);
 
            IDSupplierMiscellaneous = RPSControlFactory.CreateRPSComboBox<RPTransactionsEntityView>("922288f5-9927-4872-9134-0ded9ce315d2","","",false, this);
 
            IDCustomerBankAccount = RPSControlFactory.CreateRPSComboBox<RPTransactionsEntityView>("47543e48-97dd-4a8a-8fc4-aab76bcf146b","","",false, this);
 
            IDSupplierBankAccount = RPSControlFactory.CreateRPSComboBox<RPTransactionsEntityView>("a9aac78a-e616-4a2c-b357-db2a8078e0c6","","",false, this);
 
            AmountNominal = RPSControlFactory.CreateRPSFormattedTextBox<RPTransactionsEntityView>("ec10d4b0-7c52-4d42-ad5e-891be0a6c13f","","",true, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<RPTransactionsEntityView>("264b3cea-0477-48ac-94e1-63b9b1e69382","","",true, this);
 
            AmountNominalCurrency = RPSControlFactory.CreateRPSFormattedTextBox<RPTransactionsEntityView>("9a347788-1e91-47b2-9adc-c5aff4422ea4","","",true, this);
 
            Change = RPSControlFactory.CreateRPSFormattedTextBox<RPTransactionsEntityView>("9f4a3ebc-9c41-4e1d-8400-63cf56e0c023","","",true, this);
 
            FixedChange = RPSControlFactory.CreateRPSCheckBox<RPTransactionsEntityView>("050ff200-b878-464f-991c-d5b245d1f27d","","",true, this);
 
            AmountNominalInitial = RPSControlFactory.CreateRPSFormattedTextBox<RPTransactionsEntityView>("071fd123-e454-4836-9b14-d253684e6325","","",true, this);
 
            IDBankAccountCompany = RPSControlFactory.CreateRPSComboBox<RPTransactionsEntityView>("f5712037-3890-4b1a-bed3-33d6745f3780","","",false, this);
 
            IDCashCollector = RPSControlFactory.CreateRPSComboBox<RPTransactionsEntityView>("e175278f-4d82-4e94-9709-f1df66d337e2","","",false, this);
 
            CollectionDate = RPSControlFactory.CreateRPSTextBox<RPTransactionsEntityView>("a1e45b9a-6d8c-4e86-bc17-9823f262a809","","",false, this);
 
            IDPaymentMethodSales = RPSControlFactory.CreateRPSComboBox<RPTransactionsEntityView>("b6b64416-3780-4b2e-bdfb-5f3bc3d2e7fd","","",false, this);
 
            IDPaymentMethodPurchase = RPSControlFactory.CreateRPSComboBox<RPTransactionsEntityView>("3b0dcb17-062c-4220-ba6f-17bb86ac7022","","",false, this);
 
            RemittanceNumber = RPSControlFactory.CreateRPSTextBox<RPTransactionsEntityView>("a265f6cf-de10-4446-ba73-33c7b8850eaa","","",false, this);
 
            RemittanceNavigationCommand = RPSControlFactory.CreateRPSButton<RPTransactionsEntityView>( "1fe142d7-ce01-4095-9dae-4ddb80224bc1","","",this);
 
            RemittanceDate = RPSControlFactory.CreateRPSTextBox<RPTransactionsEntityView>("33c9bce9-26f0-4db9-b2d4-2b196bf5c0e5","","",false, this);
 
            SentNumber = RPSControlFactory.CreateRPSFormattedTextBox<RPTransactionsEntityView>("4277ef4c-8393-45b4-9509-7a00c6cadecd","","",false, this);
 
            SentDate = RPSControlFactory.CreateRPSTextBox<RPTransactionsEntityView>("81bca885-ea60-436c-a38b-a83b6ad7f89d","","",false, this);
 
            CDDueDate = RPSControlFactory.CreateRPSTextBox<RPTransactionsEntityView>("115a0ebe-7baa-4cb0-8fe7-6ba8b5c7ff14","","",false, this);
 
            CDAmount = RPSControlFactory.CreateRPSFormattedTextBox<RPTransactionsEntityView>("34407156-2ff8-4c3a-a441-916de333a970","","",true, this);
 
            CDToleranceDueDate = RPSControlFactory.CreateRPSTextBox<RPTransactionsEntityView>("1f94c604-a44c-4e52-8d5b-b06f43aa5469","","",false, this);
 
            CDToleranceAmount = RPSControlFactory.CreateRPSFormattedTextBox<RPTransactionsEntityView>("b9629fd4-cb74-4f87-af24-5390f6777e72","","",true, this);
 
            CDUsed = RPSControlFactory.CreateRPSFormattedTextBox<RPTransactionsEntityView>("65884f78-4fea-4823-b033-83cd249c5591","","",true, this);
 
            SEPAMessage = RPSControlFactory.CreateRPSTextBox<RPTransactionsEntityView>("0b693fe2-c421-4a93-b3f1-2b44c83a1774","","",false, this);
 
            SEPAPrintNavigationCommand = RPSControlFactory.CreateRPSButton<RPTransactionsEntityView>( "68c7bf7e-6f94-4eb2-9f6d-2024212febac","","",this);
 
            SEPAFileDate = RPSControlFactory.CreateRPSTextBox<RPTransactionsEntityView>("75981376-8364-44eb-a7ab-84815afd23f0","","",false, this);
 
            SEPAPaymentDate = RPSControlFactory.CreateRPSTextBox<RPTransactionsEntityView>("2f9168c3-37cb-4a64-a7d7-c51f3fcd3cfb","","",false, this);
 
            DDTypeSeq = RPSControlFactory.CreateRPSEnumComboBox<RPTransactionsEntityView>("fd61f20b-060c-40ef-b727-5f363eba3f84","","",true, this);
 
            IDAgreementDD = RPSControlFactory.CreateRPSComboBox<RPTransactionsEntityView>("3b717edc-dc9f-4984-b3c9-096fe8567b4e","","",false, this);
 
            CheckNumber = RPSControlFactory.CreateRPSTextBox<RPTransactionsEntityView>("e6fce8ab-cb90-4465-bd7d-79e74d7446ff","","",false, this);
 
            CheckDate = RPSControlFactory.CreateRPSTextBox<RPTransactionsEntityView>("1d1b648d-96f3-449c-9840-ad763d0b83b9","","",false, this);
 
            CheckDueDate = RPSControlFactory.CreateRPSTextBox<RPTransactionsEntityView>("d9fbcec6-74f8-42fc-aa63-8de8b1fcc10f","","",false, this);
 
            CodInvoiceBank = RPSControlFactory.CreateRPSTextBox<RPTransactionsEntityView>("ff8bc0d2-f6c7-4aaf-9329-3bc8c53bfb31","","",false, this);
 
            InterestAmount = RPSControlFactory.CreateRPSFormattedTextBox<RPTransactionsEntityView>("87a9d94b-e2b4-46fe-838b-4b0d44e23dc1","","",true, this);
 
            CommissionAmount = RPSControlFactory.CreateRPSFormattedTextBox<RPTransactionsEntityView>("dfbb9b52-68d8-4f89-9741-d94ff3a5e6df","","",true, this);
 
            Expenses1Amount = RPSControlFactory.CreateRPSFormattedTextBox<RPTransactionsEntityView>("f72b4930-bd14-4df5-b801-ba3d9c1f0b7f","","",true, this);
 
            Expenses2Amount = RPSControlFactory.CreateRPSFormattedTextBox<RPTransactionsEntityView>("67d3b7e2-a368-4efa-9e77-46e56f32553e","","",true, this);
 
            Expenses3Amount = RPSControlFactory.CreateRPSFormattedTextBox<RPTransactionsEntityView>("e5e587ef-30b7-4e2a-b8c1-11c8a8869c20","","",true, this);
 
            IDUnpaidCause = RPSControlFactory.CreateRPSComboBox<RPTransactionsEntityView>("9ef695b9-ff5d-4f83-b4b8-49f75d5202b4","","",false, this);
 
            ReturnExpenses = RPSControlFactory.CreateRPSFormattedTextBox<RPTransactionsEntityView>("710f4dd1-399a-436c-9892-1d98b8865588","","",true, this);
 
            ReturnDate = RPSControlFactory.CreateRPSTextBox<RPTransactionsEntityView>("01f17d42-758c-435c-af4a-0b3f6245b25b","","",false, this);
 
            ClaimNumber = RPSControlFactory.CreateRPSFormattedTextBox<RPTransactionsEntityView>("ad272ed1-4351-4143-8a51-7e7e7da24da1","","",true, this);
 
            LastClaimDate = RPSControlFactory.CreateRPSTextBox<RPTransactionsEntityView>("72a1c80a-d683-4f8b-93ce-ba74b9d9b189","","",false, this);
 
            BillNumber = RPSControlFactory.CreateRPSFormattedTextBox<RPTransactionsEntityView>("4f2937af-53df-4a70-a2cb-7fd30a68cefa","","",true, this);
 
            StatementNumber = RPSControlFactory.CreateRPSTextBox<RPTransactionsEntityView>("b007c965-df75-4cf7-9af7-2b7c8e726c41","","",false, this);
 
            BankReconciliationNavigationCommand = RPSControlFactory.CreateRPSButton<RPTransactionsEntityView>( "4b3ecc7f-282d-4e24-b316-082a52b9f1b0","","",this);
 
            GroupedNumber = RPSControlFactory.CreateRPSTextBox<RPTransactionsEntityView>("263e620a-3d7a-4586-b34d-ffe769814d54","","",false, this);
 
            CodGroup = RPSControlFactory.CreateRPSTextBox<RPTransactionsEntityView>("941f4de1-4ed0-4acc-bab8-177c1b4a157d","","",false, this);
 
            DomiciledPaymentNumber = RPSControlFactory.CreateRPSFormattedTextBox<RPTransactionsEntityView>("44193d0e-1ff4-46c7-884d-92fd0f35953e","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<RPTransactionsEntityView>("37a9b0e4-c9b8-4eef-94e6-4569b95eaed6","","",false, this);
 
            DraftSplitChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<RPTransactionsEntityView,DraftSplitChildDialogView>("2873313a-5fef-4e10-80a5-871c17c66607","","", this,Screen.DraftSplitChildDialogView);
 
            DraftQueryManagementCommandButton = RPSControlFactory.CreateRPSButton<RPTransactionsEntityView>( "36b4acfc-0c6a-4b06-9db9-19b6c30471b7","","",this);
 
            LastTransactionCommandButton = RPSControlFactory.CreateRPSButton<RPTransactionsEntityView>( "253691fb-5a15-4db4-afe4-fc1bf6def776","","",this);
 
            GeneralData = RPSControlFactory.CreateRPSSection<RPTransactionsEntityView>( "","ul li[rpsid='95e7a7f4-1c63-4166-a393-67362be0ed12']","",this);
 
            Adicional = RPSControlFactory.CreateRPSSection<RPTransactionsEntityView>( "","ul li[rpsid='24b76f8f-1737-46b8-aaed-9b143f946bbe']","",this);
 
            Comment1 = RPSControlFactory.CreateRPSSection<RPTransactionsEntityView>( "","ul li[rpsid='6b4b6c02-da97-4fc1-a515-4b55fe30e6d1']","",this);
 

        }
        public IRPSSaveButton<RPTransactionsEntityView> SaveButton { get; set; } 
        public IRPSButton<RPTransactionsEntityView> DeleteButton { get; set; } 
        public IRPSButton<RPTransactionsEntityView,RPTransactionsCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<RPTransactionsEntityView,RPTransactionsCollectionView> BackButton { get; set; } 
        public IRPSComboBox<RPTransactionsEntityView> CustomerSupplier { get; set; } 
        public IRPSTextBox<RPTransactionsEntityView> CodInvoice { get; set; } 
        public IRPSComboBox<RPTransactionsEntityView> IDUIInvoice { get; set; } 
        public IRPSComboBox<RPTransactionsEntityView> IDUIInvoiceSL { get; set; } 
        public IRPSTextBox<RPTransactionsEntityView> InvoiceDate { get; set; } 
        public IRPSTextBox<RPTransactionsEntityView> DraftNumber { get; set; } 
        public IRPSTextBox<RPTransactionsEntityView> DueDate { get; set; } 
        public IRPSComboBox<RPTransactionsEntityView> IDACCTransactions { get; set; } 
        public IRPSCheckbox<RPTransactionsEntityView> Nullified { get; set; } 
        public IRPSCheckbox<RPTransactionsEntityView> Advance { get; set; } 
        public IRPSComboBox<RPTransactionsEntityView> IDPaymentType { get; set; } 
        public IRPSComboBox<RPTransactionsEntityView> IDPaymentStatus { get; set; } 
        public IRPSTextBox<RPTransactionsEntityView> CodFromInvoice { get; set; } 
        public IRPSTextBox<RPTransactionsEntityView> RefNumber { get; set; } 
        public IRPSTextBox<RPTransactionsEntityView> RefDate { get; set; } 
        public IRPSComboBox<RPTransactionsEntityView> IDSupplier { get; set; } 
        public IRPSComboBox<RPTransactionsEntityView> IDCustomer { get; set; } 
        public IRPSComboBox<RPTransactionsEntityView> IDCustomerMiscellaneous { get; set; } 
        public IRPSComboBox<RPTransactionsEntityView> IDSupplierMiscellaneous { get; set; } 
        public IRPSComboBox<RPTransactionsEntityView> IDCustomerBankAccount { get; set; } 
        public IRPSComboBox<RPTransactionsEntityView> IDSupplierBankAccount { get; set; } 
        public IRPSTextBox<RPTransactionsEntityView> AmountNominal { get; set; } 
        public IRPSComboBox<RPTransactionsEntityView> IDCurrency { get; set; } 
        public IRPSTextBox<RPTransactionsEntityView> AmountNominalCurrency { get; set; } 
        public IRPSTextBox<RPTransactionsEntityView> Change { get; set; } 
        public IRPSCheckbox<RPTransactionsEntityView> FixedChange { get; set; } 
        public IRPSTextBox<RPTransactionsEntityView> AmountNominalInitial { get; set; } 
        public IRPSComboBox<RPTransactionsEntityView> IDBankAccountCompany { get; set; } 
        public IRPSComboBox<RPTransactionsEntityView> IDCashCollector { get; set; } 
        public IRPSTextBox<RPTransactionsEntityView> CollectionDate { get; set; } 
        public IRPSComboBox<RPTransactionsEntityView> IDPaymentMethodSales { get; set; } 
        public IRPSComboBox<RPTransactionsEntityView> IDPaymentMethodPurchase { get; set; } 
        public IRPSTextBox<RPTransactionsEntityView> RemittanceNumber { get; set; } 
        public IRPSButton<RPTransactionsEntityView> RemittanceNavigationCommand { get; set; } 
        public IRPSTextBox<RPTransactionsEntityView> RemittanceDate { get; set; } 
        public IRPSTextBox<RPTransactionsEntityView> SentNumber { get; set; } 
        public IRPSTextBox<RPTransactionsEntityView> SentDate { get; set; } 
        public IRPSTextBox<RPTransactionsEntityView> CDDueDate { get; set; } 
        public IRPSTextBox<RPTransactionsEntityView> CDAmount { get; set; } 
        public IRPSTextBox<RPTransactionsEntityView> CDToleranceDueDate { get; set; } 
        public IRPSTextBox<RPTransactionsEntityView> CDToleranceAmount { get; set; } 
        public IRPSTextBox<RPTransactionsEntityView> CDUsed { get; set; } 
        public IRPSTextBox<RPTransactionsEntityView> SEPAMessage { get; set; } 
        public IRPSButton<RPTransactionsEntityView> SEPAPrintNavigationCommand { get; set; } 
        public IRPSTextBox<RPTransactionsEntityView> SEPAFileDate { get; set; } 
        public IRPSTextBox<RPTransactionsEntityView> SEPAPaymentDate { get; set; } 
        public IRPSComboBox<RPTransactionsEntityView> DDTypeSeq { get; set; } 
        public IRPSComboBox<RPTransactionsEntityView> IDAgreementDD { get; set; } 
        public IRPSTextBox<RPTransactionsEntityView> CheckNumber { get; set; } 
        public IRPSTextBox<RPTransactionsEntityView> CheckDate { get; set; } 
        public IRPSTextBox<RPTransactionsEntityView> CheckDueDate { get; set; } 
        public IRPSTextBox<RPTransactionsEntityView> CodInvoiceBank { get; set; } 
        public IRPSTextBox<RPTransactionsEntityView> InterestAmount { get; set; } 
        public IRPSTextBox<RPTransactionsEntityView> CommissionAmount { get; set; } 
        public IRPSTextBox<RPTransactionsEntityView> Expenses1Amount { get; set; } 
        public IRPSTextBox<RPTransactionsEntityView> Expenses2Amount { get; set; } 
        public IRPSTextBox<RPTransactionsEntityView> Expenses3Amount { get; set; } 
        public IRPSComboBox<RPTransactionsEntityView> IDUnpaidCause { get; set; } 
        public IRPSTextBox<RPTransactionsEntityView> ReturnExpenses { get; set; } 
        public IRPSTextBox<RPTransactionsEntityView> ReturnDate { get; set; } 
        public IRPSTextBox<RPTransactionsEntityView> ClaimNumber { get; set; } 
        public IRPSTextBox<RPTransactionsEntityView> LastClaimDate { get; set; } 
        public IRPSTextBox<RPTransactionsEntityView> BillNumber { get; set; } 
        public IRPSTextBox<RPTransactionsEntityView> StatementNumber { get; set; } 
        public IRPSButton<RPTransactionsEntityView> BankReconciliationNavigationCommand { get; set; } 
        public IRPSTextBox<RPTransactionsEntityView> GroupedNumber { get; set; } 
        public IRPSTextBox<RPTransactionsEntityView> CodGroup { get; set; } 
        public IRPSTextBox<RPTransactionsEntityView> DomiciledPaymentNumber { get; set; } 
        public IRPSTextBox<RPTransactionsEntityView> Comment { get; set; } 
        public IRPSButton<RPTransactionsEntityView,DraftSplitChildDialogView> DraftSplitChildNavigationCommandButton { get; set; } 
        public IRPSButton<RPTransactionsEntityView> DraftQueryManagementCommandButton { get; set; } 
        public IRPSButton<RPTransactionsEntityView> LastTransactionCommandButton { get; set; } 
        public IRPSSection<RPTransactionsEntityView> GeneralData { get; set; } 
        public IRPSSection<RPTransactionsEntityView> Adicional { get; set; } 
        public IRPSSection<RPTransactionsEntityView> Comment1 { get; set; } 
        public DraftManagement Screen { get; set; }
        public RPTransactionsEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DraftSplitChildDialogView : View
    {
        public DraftSplitChildDialogView(DraftManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NumberOfDrafts = RPSControlFactory.CreateRPSFormattedTextBox<DraftSplitChildDialogView>("0876810e-6c8b-4c48-8291-2b85f7fd6c27","","",true, this);
 
            AmountNominal = RPSControlFactory.CreateRPSFormattedTextBox<DraftSplitChildDialogView>("3e911ee1-4c21-4a19-b366-d9fa48ce06b4","","",true, this);
 
            TotalAmountNominal = RPSControlFactory.CreateRPSFormattedTextBox<DraftSplitChildDialogView>("67b38e92-7c69-4ed8-a1e5-6e00e2cc4e23","","",false, this);
 
            AmountNominalCurrency = RPSControlFactory.CreateRPSFormattedTextBox<DraftSplitChildDialogView>("07f6791c-a04a-410e-ad7e-7ab8f1712579","","",true, this);
 
            TotalAmountNominalCurrency = RPSControlFactory.CreateRPSFormattedTextBox<DraftSplitChildDialogView>("05808094-7f7d-4fab-a09f-a94e5b858ee1","","",false, this);
 
            ExecuteDraftManagementSplitDraft = RPSControlFactory.CreateRPSButton<DraftSplitChildDialogView>( "7a8b76bf-f176-4fcf-97f0-173dc3d1d503","","",this);
 
            CollectionInit params_SplitDrafts = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4d928cae-cf74-4d8b-9571-39fe04f4c2f1",CSSSelectorGrid="",XPathGrid=""};
            SplitDrafts = RPSControlFactory.RPSCreateCollectionWithGrid<SplitDraftsCollectionEditor<DraftSplitChildDialogView>,DraftSplitChildDialogView>( params_SplitDrafts,this);
 

        }
        public IRPSTextBox<DraftSplitChildDialogView> NumberOfDrafts { get; set; } 
        public IRPSTextBox<DraftSplitChildDialogView> AmountNominal { get; set; } 
        public IRPSTextBox<DraftSplitChildDialogView> TotalAmountNominal { get; set; } 
        public IRPSTextBox<DraftSplitChildDialogView> AmountNominalCurrency { get; set; } 
        public IRPSTextBox<DraftSplitChildDialogView> TotalAmountNominalCurrency { get; set; } 
        public IRPSButton<DraftSplitChildDialogView> ExecuteDraftManagementSplitDraft { get; set; } 
        public SplitDraftsCollectionEditor<DraftSplitChildDialogView> SplitDrafts { get; set; } 
        public DraftManagement Screen { get; set; }
        public DraftSplitChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SplitDraftsCollectionEditor<DraftSplitChildDialogView>:RPSCollectionEditor<DraftSplitChildDialogView> where DraftSplitChildDialogView : class, IView
    {
        public  SplitDraftsGridView<DraftSplitChildDialogView> GridView {get;set;}
    }
    public partial class SplitDraftsGridView <DraftSplitChildDialogView> :  RPSGridView<DraftSplitChildDialogView> where DraftSplitChildDialogView : class, IView
    {
        public SplitDraftsGridView(DraftSplitChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DraftNumber = RPSControlFactory.CreateRPSGridFormattedTextBox<DraftSplitChildDialogView>("","#4d928cae-cf74-4d8b-9571-39fe04f4c2f1 .ag-row[role='row']@ROWINDEX [col-id='cDraftNumber']","",false, this.CurrentView);
 
            DueDate = RPSControlFactory.CreateRPSGridTextBox<DraftSplitChildDialogView>("","#4d928cae-cf74-4d8b-9571-39fe04f4c2f1 .ag-row[role='row']@ROWINDEX [col-id='cDueDate']","",false, this.CurrentView);
 
            AmountNominal = RPSControlFactory.CreateRPSGridFormattedTextBox<DraftSplitChildDialogView>("","#4d928cae-cf74-4d8b-9571-39fe04f4c2f1 .ag-row[role='row']@ROWINDEX [col-id='cAmountNominal']","",false, this.CurrentView);
 
            AmountNominalCurrency = RPSControlFactory.CreateRPSGridFormattedTextBox<DraftSplitChildDialogView>("","#4d928cae-cf74-4d8b-9571-39fe04f4c2f1 .ag-row[role='row']@ROWINDEX [col-id='cAmountNominalCurrency']","",false, this.CurrentView);
 
            CDAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<DraftSplitChildDialogView>("","#4d928cae-cf74-4d8b-9571-39fe04f4c2f1 .ag-row[role='row']@ROWINDEX [col-id='cCDAmount']","",false, this.CurrentView);
 
            CDDueDate = RPSControlFactory.CreateRPSGridTextBox<DraftSplitChildDialogView>("","#4d928cae-cf74-4d8b-9571-39fe04f4c2f1 .ag-row[role='row']@ROWINDEX [col-id='cCDDueDate']","",false, this.CurrentView);
 
            CDToleranceAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<DraftSplitChildDialogView>("","#4d928cae-cf74-4d8b-9571-39fe04f4c2f1 .ag-row[role='row']@ROWINDEX [col-id='cCDToleranceAmount']","",false, this.CurrentView);
 
            CDToleranceDueDate = RPSControlFactory.CreateRPSGridTextBox<DraftSplitChildDialogView>("","#4d928cae-cf74-4d8b-9571-39fe04f4c2f1 .ag-row[role='row']@ROWINDEX [col-id='cCDToleranceDueDate']","",false, this.CurrentView);
 
            RefDate = RPSControlFactory.CreateRPSGridTextBox<DraftSplitChildDialogView>("","#4d928cae-cf74-4d8b-9571-39fe04f4c2f1 .ag-row[role='row']@ROWINDEX [col-id='cRefDate']","",false, this.CurrentView);
 
            RefNumber = RPSControlFactory.CreateRPSGridTextBox<DraftSplitChildDialogView>("","#4d928cae-cf74-4d8b-9571-39fe04f4c2f1 .ag-row[role='row']@ROWINDEX [col-id='cRefNumber']","",false, this.CurrentView);
 
            Comment = RPSControlFactory.CreateRPSGridTextBox<DraftSplitChildDialogView>("","#4d928cae-cf74-4d8b-9571-39fe04f4c2f1 .ag-row[role='row']@ROWINDEX [col-id='cComment']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<DraftSplitChildDialogView> DraftNumber { get; set; } 
        public IRPSGridTextBox<DraftSplitChildDialogView> DueDate { get; set; } 
        public IRPSGridTextBox<DraftSplitChildDialogView> AmountNominal { get; set; } 
        public IRPSGridTextBox<DraftSplitChildDialogView> AmountNominalCurrency { get; set; } 
        public IRPSGridTextBox<DraftSplitChildDialogView> CDAmount { get; set; } 
        public IRPSGridTextBox<DraftSplitChildDialogView> CDDueDate { get; set; } 
        public IRPSGridTextBox<DraftSplitChildDialogView> CDToleranceAmount { get; set; } 
        public IRPSGridTextBox<DraftSplitChildDialogView> CDToleranceDueDate { get; set; } 
        public IRPSGridTextBox<DraftSplitChildDialogView> RefDate { get; set; } 
        public IRPSGridTextBox<DraftSplitChildDialogView> RefNumber { get; set; } 
        public IRPSGridTextBox<DraftSplitChildDialogView> Comment { get; set; } 
                     
    }
 
    }
  
    

}