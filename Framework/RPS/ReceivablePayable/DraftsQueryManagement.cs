    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.ReceivablePayable.DraftsQueryManagement
{
    //RPS VERSION 1.0.0.0
    public partial class DraftsQueryManagement:Screen
    {
        public DraftsQueryManagement():base()
        {
            this.URL = "receivablepayable.draftsquerymanagement";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DraftsQueryManagementQueryView  = new DraftsQueryManagementQueryView(this); 
            SituationChangeChildDialogView  = new SituationChangeChildDialogView(this); 
            UpdateReferenceChildDialogView  = new UpdateReferenceChildDialogView(this); 
            RemittanceChildDialogView  = new RemittanceChildDialogView(this); 
            DraftGroupChildDialogView  = new DraftGroupChildDialogView(this); 
            ChecksChildDialogView  = new ChecksChildDialogView(this); 
            DraftRelationGenerationChildDialogView  = new DraftRelationGenerationChildDialogView(this); 
            GenerateFileChildDialogView  = new GenerateFileChildDialogView(this); 
            UnpaidChidDialogView  = new UnpaidChidDialogView(this); 
            ClaimChildDialogView  = new ClaimChildDialogView(this); 
            GenerateFileOptionalDataChildDialogView  = new GenerateFileOptionalDataChildDialogView(this); 
            GenerateFileTextChildDialogView  = new GenerateFileTextChildDialogView(this); 
            AccTransactionsResultChildDialogView  = new AccTransactionsResultChildDialogView(this); 
            ClaimPrintChildDialogView  = new ClaimPrintChildDialogView(this); 
            PrintChildDialogView  = new PrintChildDialogView(this); 
            NettingChildDialogView  = new NettingChildDialogView(this); 
            DraftsQueryManagementQueryView.InitializeControls(); 
            SituationChangeChildDialogView.InitializeControls(); 
            UpdateReferenceChildDialogView.InitializeControls(); 
            RemittanceChildDialogView.InitializeControls(); 
            DraftGroupChildDialogView.InitializeControls(); 
            ChecksChildDialogView.InitializeControls(); 
            DraftRelationGenerationChildDialogView.InitializeControls(); 
            GenerateFileChildDialogView.InitializeControls(); 
            UnpaidChidDialogView.InitializeControls(); 
            ClaimChildDialogView.InitializeControls(); 
            GenerateFileOptionalDataChildDialogView.InitializeControls(); 
            GenerateFileTextChildDialogView.InitializeControls(); 
            AccTransactionsResultChildDialogView.InitializeControls(); 
            ClaimPrintChildDialogView.InitializeControls(); 
            PrintChildDialogView.InitializeControls(); 
            NettingChildDialogView.InitializeControls(); 
           
        }
      
            public DraftsQueryManagementQueryView DraftsQueryManagementQueryView {get; set; } 
            public SituationChangeChildDialogView SituationChangeChildDialogView {get; set; } 
            public UpdateReferenceChildDialogView UpdateReferenceChildDialogView {get; set; } 
            public RemittanceChildDialogView RemittanceChildDialogView {get; set; } 
            public DraftGroupChildDialogView DraftGroupChildDialogView {get; set; } 
            public ChecksChildDialogView ChecksChildDialogView {get; set; } 
            public DraftRelationGenerationChildDialogView DraftRelationGenerationChildDialogView {get; set; } 
            public GenerateFileChildDialogView GenerateFileChildDialogView {get; set; } 
            public UnpaidChidDialogView UnpaidChidDialogView {get; set; } 
            public ClaimChildDialogView ClaimChildDialogView {get; set; } 
            public GenerateFileOptionalDataChildDialogView GenerateFileOptionalDataChildDialogView {get; set; } 
            public GenerateFileTextChildDialogView GenerateFileTextChildDialogView {get; set; } 
            public AccTransactionsResultChildDialogView AccTransactionsResultChildDialogView {get; set; } 
            public ClaimPrintChildDialogView ClaimPrintChildDialogView {get; set; } 
            public PrintChildDialogView PrintChildDialogView {get; set; } 
            public NettingChildDialogView NettingChildDialogView {get; set; } 
    }
            
    public partial class DraftsQueryManagementQueryView : View
    {
        public DraftsQueryManagementQueryView(DraftsQueryManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IsSale = RPSControlFactory.CreateRPSCheckBox<DraftsQueryManagementQueryView>("5f75721e-14e8-4858-b1c5-b0ac74cb10fe","","",false, this);
 
            IsPurchase = RPSControlFactory.CreateRPSCheckBox<DraftsQueryManagementQueryView>("6ba55d73-07cc-4b54-8da2-e39a169fb5f8","","",false, this);
 
            Customer = RPSControlFactory.CreateRPSComboBox<DraftsQueryManagementQueryView>("886079a8-ed1a-46d4-a7c6-e31ccdfac81d","","",false, this);
 
            Supplier = RPSControlFactory.CreateRPSComboBox<DraftsQueryManagementQueryView>("df26d6c1-fd7a-45f6-9a97-b87ce9b51b15","","",false, this);
 
            ThirdReference = RPSControlFactory.CreateRPSTextBox<DraftsQueryManagementQueryView>("87347087-acd4-441e-a2e7-33ff039e941b","","",false, this);
 
            Currency = RPSControlFactory.CreateRPSComboBox<DraftsQueryManagementQueryView>("f7328bb2-d916-4dfc-8484-35040abdbf57","","",false, this);
 
            IDPaymentTypeList = RPSControlFactory.CreateRPSCollectionComboBox<DraftsQueryManagementQueryView>("383a9500-2c5a-4555-ba73-6a04b6740d9c","","",false, this);
 
            bNoFinalStatus = RPSControlFactory.CreateRPSCheckBox<DraftsQueryManagementQueryView>("7c9212ab-60f1-4a7e-a61f-9b9eff5017aa","","",false, this);
 
            IDPaymentStatusList = RPSControlFactory.CreateRPSCollectionComboBox<DraftsQueryManagementQueryView>("1f76e557-3885-478f-8b4a-00773bc85cb8","","",false, this);
 
            CodInvoice = RPSControlFactory.CreateRPSTextBox<DraftsQueryManagementQueryView>("0067eadc-43d2-4d10-84c2-8d2b016c8a14","","",false, this);
 
            RefNumber = RPSControlFactory.CreateRPSTextBox<DraftsQueryManagementQueryView>("543291b9-1cbd-48db-a8e2-72a315d32792","","",false, this);
 
            DateFromInvoice = RPSControlFactory.CreateRPSTextBox<DraftsQueryManagementQueryView>("67b07444-84b2-4f98-bba2-402ef56db221","","",false, this);
 
            DateToInvoice = RPSControlFactory.CreateRPSTextBox<DraftsQueryManagementQueryView>("f570c2fb-2364-4f69-993a-ca77a76bd0d9","","",false, this);
 
            DateFromDue = RPSControlFactory.CreateRPSTextBox<DraftsQueryManagementQueryView>("5e33c14f-0205-453d-ab1c-8d8526ca007f","","",false, this);
 
            DateToDue = RPSControlFactory.CreateRPSTextBox<DraftsQueryManagementQueryView>("4a3b44bd-2c8d-41ec-949d-8ae956ea9e3c","","",false, this);
 
            bBank = RPSControlFactory.CreateRPSCheckBox<DraftsQueryManagementQueryView>("416f9ad6-7c50-4b5b-928e-3118267965f2","","",false, this);
 
            IDBankAccountCompany = RPSControlFactory.CreateRPSComboBox<DraftsQueryManagementQueryView>("2cc6ff23-7cea-449a-8a18-23f72b755663","","",false, this);
 
            bCashCol = RPSControlFactory.CreateRPSCheckBox<DraftsQueryManagementQueryView>("9b5e2478-8a37-4be0-9321-b1a0eb98e24b","","",false, this);
 
            IDCashCollector = RPSControlFactory.CreateRPSComboBox<DraftsQueryManagementQueryView>("7c1d53e9-f40d-493d-93ac-d0a9d6423185","","",false, this);
 
            bRemittance = RPSControlFactory.CreateRPSCheckBox<DraftsQueryManagementQueryView>("f14e9b0b-a329-417a-af8e-819760feab27","","",false, this);
 
            RemittanceNumber = RPSControlFactory.CreateRPSTextBox<DraftsQueryManagementQueryView>("d1a6573a-9b3d-494a-bca6-f00c05672fb6","","",false, this);
 
            IDCommercialAgentSL = RPSControlFactory.CreateRPSComboBox<DraftsQueryManagementQueryView>("61a1f162-3d45-4966-9f0f-a3732ccb77b3","","",false, this);
 
            FilterDateCD = RPSControlFactory.CreateRPSTextBox<DraftsQueryManagementQueryView>("0bb1811e-d326-4821-aabd-a9368d5dfeeb","","",false, this);
 
            FilterDateCDTolerance = RPSControlFactory.CreateRPSTextBox<DraftsQueryManagementQueryView>("6fd505d8-2f1f-4d04-b176-9c07abde6762","","",false, this);
 
            CountSelected = RPSControlFactory.CreateRPSTextBox<DraftsQueryManagementQueryView>("de206df8-6108-4318-95fb-6f3e2f57b8f9","","",false, this);
 
            SumAmountNominalCustomer = RPSControlFactory.CreateRPSFormattedTextBox<DraftsQueryManagementQueryView>("c70ff0ac-edd3-4fe0-8421-1312b20f95a7","","",false, this);
 
            SumAmountNominalCurrencyCustomer = RPSControlFactory.CreateRPSFormattedTextBox<DraftsQueryManagementQueryView>("6108d9c2-bfd2-4796-89cd-f662fada2178","","",false, this);
 
            SumAmountNominalSupplier = RPSControlFactory.CreateRPSFormattedTextBox<DraftsQueryManagementQueryView>("8fb2da84-e548-4447-b59b-1dfbf779fb7f","","",false, this);
 
            SumAmountNominalCurrencySupplier = RPSControlFactory.CreateRPSFormattedTextBox<DraftsQueryManagementQueryView>("de0f7569-a4f1-47f1-bd49-f127b0648895","","",false, this);
 
            RPTransactions_CustomerSupplier = RPSControlFactory.CreateRPSTextBox<DraftsQueryManagementQueryView>("6563b805-aad0-48d6-8e8d-5e6387c7f74a","","",false, this);
 
            RPTransactions_InvoiceDate = RPSControlFactory.CreateRPSTextBox<DraftsQueryManagementQueryView>("87437d88-3633-4a00-9be0-bf1faddef260","","",false, this);
 
            RPTransactions_DraftNumber = RPSControlFactory.CreateRPSFormattedTextBox<DraftsQueryManagementQueryView>("7387a5f0-7762-4863-856a-f0d3292b5940","","",false, this);
 
            RPTransactions_DueDate = RPSControlFactory.CreateRPSTextBox<DraftsQueryManagementQueryView>("94a357f8-9eb0-4693-b465-841c840fdec0","","",false, this);
 
            RPTransactions_CodFromInvoice = RPSControlFactory.CreateRPSTextBox<DraftsQueryManagementQueryView>("c6b07b04-45f7-4718-9e20-1520a3725cf2","","",false, this);
 
            RPTransactions_Nullified = RPSControlFactory.CreateRPSCheckBox<DraftsQueryManagementQueryView>("197d4495-35a5-4c1e-a71d-193197039141","","",false, this);
 
            RPTransactions_Advance = RPSControlFactory.CreateRPSCheckBox<DraftsQueryManagementQueryView>("9c9698a9-bd8d-41ac-becf-1ab58b4ea46b","","",false, this);
 
            RPTransactions_StatementNumber = RPSControlFactory.CreateRPSTextBox<DraftsQueryManagementQueryView>("2612590c-3c0b-410d-abb7-50e3c287cff9","","",false, this);
 
            RPTransactions_RefNumber = RPSControlFactory.CreateRPSTextBox<DraftsQueryManagementQueryView>("57d390f2-c33a-4a61-b275-6181738f7da5","","",false, this);
 
            RPTransactions_RefDate = RPSControlFactory.CreateRPSTextBox<DraftsQueryManagementQueryView>("028aca88-4f97-47ab-99e6-bcd4825a6108","","",false, this);
 
            ThirdVATNumber = RPSControlFactory.CreateRPSTextBox<DraftsQueryManagementQueryView>("82a9e062-fecc-4897-a9c9-79089add4713","","",false, this);
 
            ThirdCompanyName = RPSControlFactory.CreateRPSTextBox<DraftsQueryManagementQueryView>("2afbb2d5-d13b-4e6c-b80d-5593792c3072","","",false, this);
 
            RPTransactions_Change = RPSControlFactory.CreateRPSFormattedTextBox<DraftsQueryManagementQueryView>("7324a637-a2a7-4175-826f-873a1a96b51c","","",false, this);
 
            RPTransactions_FixedChange = RPSControlFactory.CreateRPSCheckBox<DraftsQueryManagementQueryView>("f4249a27-c3ba-4330-9d1d-64aae755a892","","",false, this);
 
            RPTransactions_CollectionDate = RPSControlFactory.CreateRPSTextBox<DraftsQueryManagementQueryView>("6050e210-2181-4893-a4b1-1728c11382f2","","",false, this);
 
            RPTransactions_RemittanceNumber = RPSControlFactory.CreateRPSTextBox<DraftsQueryManagementQueryView>("e2e37b79-b96e-445c-9d74-bb26520fbff4","","",false, this);
 
            RPTransactions_RemittanceDate = RPSControlFactory.CreateRPSTextBox<DraftsQueryManagementQueryView>("4c43c231-d6cb-40a8-ba89-3ddb72eeef60","","",false, this);
 
            RPTransactions_SentNumber = RPSControlFactory.CreateRPSFormattedTextBox<DraftsQueryManagementQueryView>("98db66d3-d29d-4c86-8cc9-59353b3a760d","","",false, this);
 
            RPTransactions_SentDate = RPSControlFactory.CreateRPSTextBox<DraftsQueryManagementQueryView>("99244c55-35f5-4705-8c59-184161d6c64a","","",false, this);
 
            RPTransactions_CDDueDate = RPSControlFactory.CreateRPSTextBox<DraftsQueryManagementQueryView>("242d4222-f0b4-4c9a-9103-52536f738aa8","","",false, this);
 
            RPTransactions_CDToleranceDueDate = RPSControlFactory.CreateRPSTextBox<DraftsQueryManagementQueryView>("4da8a022-cecd-4e5d-8436-05db7d239dd4","","",false, this);
 
            UpdateReferenceChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DraftsQueryManagementQueryView,UpdateReferenceChildDialogView>("ea0343b4-6e24-4e5f-af47-9443434cf4d7","","", this,Screen.UpdateReferenceChildDialogView);
 
            StatusChangeButton = RPSControlFactory.CreateRPSButton<DraftsQueryManagementQueryView>( "833dea32-3889-4377-8391-1a89e55e340b","","",this);
 
            RemittanceCommandButton = RPSControlFactory.CreateRPSButton<DraftsQueryManagementQueryView>( "48af62dd-6eb6-46a0-8738-7ae33d9ae8ea","","",this);
 
            GenerateFileCommandButton = RPSControlFactory.CreateRPSButton<DraftsQueryManagementQueryView>( "8dc002a0-c40f-4f00-9f8f-e55a45daf9e6","","",this);
 
            CheckCommandButton = RPSControlFactory.CreateRPSButton<DraftsQueryManagementQueryView>( "5b1a3c78-b3f2-4ecd-be88-cd7fd4980da2","","",this);
 
            DraftRelationCommandButton = RPSControlFactory.CreateRPSButton<DraftsQueryManagementQueryView>( "d7ee0407-855d-46e3-b2c2-d088cf91206b","","",this);
 
            UnpaidCommandButton = RPSControlFactory.CreateRPSButton<DraftsQueryManagementQueryView>( "33713d08-4a6b-4b0d-83ea-552c697f29f3","","",this);
 
            NettingCommandButton = RPSControlFactory.CreateRPSButton<DraftsQueryManagementQueryView>( "41a2e058-3a38-4204-8861-2ec21ec8f49c","","",this);
 
            ClaimCommandButton = RPSControlFactory.CreateRPSButton<DraftsQueryManagementQueryView>( "2b5e4eb2-5c81-46bc-a190-6a1652ebcf63","","",this);
 
            ClaimPrintChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DraftsQueryManagementQueryView,ClaimPrintChildDialogView>("16f3fba1-5867-4d85-b582-07c46a702fea","","", this,Screen.ClaimPrintChildDialogView);
 
            DraftGroupCommandButton = RPSControlFactory.CreateRPSButton<DraftsQueryManagementQueryView>( "18bbc12b-694b-4ee0-8aa6-8ed2481f7a1e","","",this);
 
            PrintChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DraftsQueryManagementQueryView,PrintChildDialogView>("09201dfc-3ff7-4aeb-b9d6-93781257af24","","", this,Screen.PrintChildDialogView);
 
            CollectionInit params_DraftsQueryManagement = new CollectionInit(){IDDescriptor = "40077334-4047-4998-8aee-8f5b51f1ea2c",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="e66f2607-1eba-4984-9bc7-af31788ef58f",CSSSelectorGrid="",XPathGrid=""};
            DraftsQueryManagement = RPSControlFactory.RPSCreateCollectionWithGrid<DraftsQueryManagementCollectionEditor<DraftsQueryManagementQueryView,SituationChangeChildDialogView>,DraftsQueryManagementQueryView,SituationChangeChildDialogView>( params_DraftsQueryManagement,this,Screen.SituationChangeChildDialogView);
 

        }
        public IRPSCheckbox<DraftsQueryManagementQueryView> IsSale { get; set; } 
        public IRPSCheckbox<DraftsQueryManagementQueryView> IsPurchase { get; set; } 
        public IRPSComboBox<DraftsQueryManagementQueryView> Customer { get; set; } 
        public IRPSComboBox<DraftsQueryManagementQueryView> Supplier { get; set; } 
        public IRPSTextBox<DraftsQueryManagementQueryView> ThirdReference { get; set; } 
        public IRPSComboBox<DraftsQueryManagementQueryView> Currency { get; set; } 
        public IRPSCollectionComboBox<DraftsQueryManagementQueryView> IDPaymentTypeList { get; set; } 
        public IRPSCheckbox<DraftsQueryManagementQueryView> bNoFinalStatus { get; set; } 
        public IRPSCollectionComboBox<DraftsQueryManagementQueryView> IDPaymentStatusList { get; set; } 
        public IRPSTextBox<DraftsQueryManagementQueryView> CodInvoice { get; set; } 
        public IRPSTextBox<DraftsQueryManagementQueryView> RefNumber { get; set; } 
        public IRPSTextBox<DraftsQueryManagementQueryView> DateFromInvoice { get; set; } 
        public IRPSTextBox<DraftsQueryManagementQueryView> DateToInvoice { get; set; } 
        public IRPSTextBox<DraftsQueryManagementQueryView> DateFromDue { get; set; } 
        public IRPSTextBox<DraftsQueryManagementQueryView> DateToDue { get; set; } 
        public IRPSCheckbox<DraftsQueryManagementQueryView> bBank { get; set; } 
        public IRPSComboBox<DraftsQueryManagementQueryView> IDBankAccountCompany { get; set; } 
        public IRPSCheckbox<DraftsQueryManagementQueryView> bCashCol { get; set; } 
        public IRPSComboBox<DraftsQueryManagementQueryView> IDCashCollector { get; set; } 
        public IRPSCheckbox<DraftsQueryManagementQueryView> bRemittance { get; set; } 
        public IRPSTextBox<DraftsQueryManagementQueryView> RemittanceNumber { get; set; } 
        public IRPSComboBox<DraftsQueryManagementQueryView> IDCommercialAgentSL { get; set; } 
        public IRPSTextBox<DraftsQueryManagementQueryView> FilterDateCD { get; set; } 
        public IRPSTextBox<DraftsQueryManagementQueryView> FilterDateCDTolerance { get; set; } 
        public IRPSTextBox<DraftsQueryManagementQueryView> CountSelected { get; set; } 
        public IRPSTextBox<DraftsQueryManagementQueryView> SumAmountNominalCustomer { get; set; } 
        public IRPSTextBox<DraftsQueryManagementQueryView> SumAmountNominalCurrencyCustomer { get; set; } 
        public IRPSTextBox<DraftsQueryManagementQueryView> SumAmountNominalSupplier { get; set; } 
        public IRPSTextBox<DraftsQueryManagementQueryView> SumAmountNominalCurrencySupplier { get; set; } 
        public IRPSTextBox<DraftsQueryManagementQueryView> RPTransactions_CustomerSupplier { get; set; } 
        public IRPSTextBox<DraftsQueryManagementQueryView> RPTransactions_InvoiceDate { get; set; } 
        public IRPSTextBox<DraftsQueryManagementQueryView> RPTransactions_DraftNumber { get; set; } 
        public IRPSTextBox<DraftsQueryManagementQueryView> RPTransactions_DueDate { get; set; } 
        public IRPSTextBox<DraftsQueryManagementQueryView> RPTransactions_CodFromInvoice { get; set; } 
        public IRPSCheckbox<DraftsQueryManagementQueryView> RPTransactions_Nullified { get; set; } 
        public IRPSCheckbox<DraftsQueryManagementQueryView> RPTransactions_Advance { get; set; } 
        public IRPSTextBox<DraftsQueryManagementQueryView> RPTransactions_StatementNumber { get; set; } 
        public IRPSTextBox<DraftsQueryManagementQueryView> RPTransactions_RefNumber { get; set; } 
        public IRPSTextBox<DraftsQueryManagementQueryView> RPTransactions_RefDate { get; set; } 
        public IRPSTextBox<DraftsQueryManagementQueryView> ThirdVATNumber { get; set; } 
        public IRPSTextBox<DraftsQueryManagementQueryView> ThirdCompanyName { get; set; } 
        public IRPSTextBox<DraftsQueryManagementQueryView> RPTransactions_Change { get; set; } 
        public IRPSCheckbox<DraftsQueryManagementQueryView> RPTransactions_FixedChange { get; set; } 
        public IRPSTextBox<DraftsQueryManagementQueryView> RPTransactions_CollectionDate { get; set; } 
        public IRPSTextBox<DraftsQueryManagementQueryView> RPTransactions_RemittanceNumber { get; set; } 
        public IRPSTextBox<DraftsQueryManagementQueryView> RPTransactions_RemittanceDate { get; set; } 
        public IRPSTextBox<DraftsQueryManagementQueryView> RPTransactions_SentNumber { get; set; } 
        public IRPSTextBox<DraftsQueryManagementQueryView> RPTransactions_SentDate { get; set; } 
        public IRPSTextBox<DraftsQueryManagementQueryView> RPTransactions_CDDueDate { get; set; } 
        public IRPSTextBox<DraftsQueryManagementQueryView> RPTransactions_CDToleranceDueDate { get; set; } 
        public IRPSButton<DraftsQueryManagementQueryView,UpdateReferenceChildDialogView> UpdateReferenceChildNavigationCommandButton { get; set; } 
        public IRPSButton<DraftsQueryManagementQueryView> StatusChangeButton { get; set; } 
        public IRPSButton<DraftsQueryManagementQueryView> RemittanceCommandButton { get; set; } 
        public IRPSButton<DraftsQueryManagementQueryView> GenerateFileCommandButton { get; set; } 
        public IRPSButton<DraftsQueryManagementQueryView> CheckCommandButton { get; set; } 
        public IRPSButton<DraftsQueryManagementQueryView> DraftRelationCommandButton { get; set; } 
        public IRPSButton<DraftsQueryManagementQueryView> UnpaidCommandButton { get; set; } 
        public IRPSButton<DraftsQueryManagementQueryView> NettingCommandButton { get; set; } 
        public IRPSButton<DraftsQueryManagementQueryView> ClaimCommandButton { get; set; } 
        public IRPSButton<DraftsQueryManagementQueryView,ClaimPrintChildDialogView> ClaimPrintChildNavigationCommandButton { get; set; } 
        public IRPSButton<DraftsQueryManagementQueryView> DraftGroupCommandButton { get; set; } 
        public IRPSButton<DraftsQueryManagementQueryView,PrintChildDialogView> PrintChildNavigationCommandButton { get; set; } 
        public DraftsQueryManagementCollectionEditor<DraftsQueryManagementQueryView,SituationChangeChildDialogView> DraftsQueryManagement { get; set; } 
        public DraftsQueryManagement Screen { get; set; }
        public DraftsQueryManagementQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DraftsQueryManagementCollectionEditor<DraftsQueryManagementQueryView,SituationChangeChildDialogView>:RPSCollectionEditor<DraftsQueryManagementQueryView,SituationChangeChildDialogView> where DraftsQueryManagementQueryView : class, IView where SituationChangeChildDialogView : class, IView
    {
        public  DraftsQueryManagementGridView<DraftsQueryManagementQueryView,SituationChangeChildDialogView> GridView {get;set;}
    }
    public partial class DraftsQueryManagementGridView <DraftsQueryManagementQueryView,SituationChangeChildDialogView> :  RPSGridView<DraftsQueryManagementQueryView,SituationChangeChildDialogView> where DraftsQueryManagementQueryView : class, IView where SituationChangeChildDialogView : class, IView
    {
        public DraftsQueryManagementGridView(DraftsQueryManagementQueryView currentView,SituationChangeChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            AmountNominalCurrencyGrid = RPSControlFactory.CreateRPSGridFormattedTextBox<DraftsQueryManagementQueryView>("","#e66f2607-1eba-4984-9bc7-af31788ef58f .ag-row[role='row']@ROWINDEX [col-id='cAmountNominalCurrencyGrid']","",false, this.CurrentView);
 
            RPTransactions_FixedChange = RPSControlFactory.CreateRPSGridCheckBox<DraftsQueryManagementQueryView>("","#e66f2607-1eba-4984-9bc7-af31788ef58f .ag-row[role='row']@ROWINDEX [col-id='cRPTransactions_FixedChange']","",false, this.CurrentView);
 
            RPTransactions_InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<DraftsQueryManagementQueryView>("","#e66f2607-1eba-4984-9bc7-af31788ef58f .ag-row[role='row']@ROWINDEX [col-id='cRPTransactions_InvoiceDate']","",false, this.CurrentView);
 
            RPTransactions_RemittanceNumber = RPSControlFactory.CreateRPSGridTextBox<DraftsQueryManagementQueryView>("","#e66f2607-1eba-4984-9bc7-af31788ef58f .ag-row[role='row']@ROWINDEX [col-id='cRPTransactions_RemittanceNumber']","",false, this.CurrentView);
 
            RPTransactions_RefNumber = RPSControlFactory.CreateRPSGridTextBox<DraftsQueryManagementQueryView>("","#e66f2607-1eba-4984-9bc7-af31788ef58f .ag-row[role='row']@ROWINDEX [col-id='cRPTransactions_RefNumber']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<DraftsQueryManagementQueryView> AmountNominalCurrencyGrid { get; set; } 
        public IRPSGridCheckbox<DraftsQueryManagementQueryView> RPTransactions_FixedChange { get; set; } 
        public IRPSGridTextBox<DraftsQueryManagementQueryView> RPTransactions_InvoiceDate { get; set; } 
        public IRPSGridTextBox<DraftsQueryManagementQueryView> RPTransactions_RemittanceNumber { get; set; } 
        public IRPSGridTextBox<DraftsQueryManagementQueryView> RPTransactions_RefNumber { get; set; } 
                     
    }
 
    }
  
            
    public partial class SituationChangeChildDialogView : View
    {
        public SituationChangeChildDialogView(DraftsQueryManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CHTotalAmount = RPSControlFactory.CreateRPSFormattedTextBox<SituationChangeChildDialogView>("b06b6f7e-fd95-4d05-ae69-69b3b37452dd","","",false, this);
 
            CHTotalCDAmount = RPSControlFactory.CreateRPSFormattedTextBox<SituationChangeChildDialogView>("99812c35-1120-4a87-8c8b-37553dba8d7a","","",false, this);
 
            CHToPay = RPSControlFactory.CreateRPSFormattedTextBox<SituationChangeChildDialogView>("8ca7055a-7a88-4c03-ab9f-e88b1feaaee9","","",false, this);
 
            CHTotalCDToleranceAmount = RPSControlFactory.CreateRPSFormattedTextBox<SituationChangeChildDialogView>("269ddda6-4e0d-448c-a1f9-16c445a95bc6","","",false, this);
 
            CHTotalAmountCurrency = RPSControlFactory.CreateRPSFormattedTextBox<SituationChangeChildDialogView>("13c5fa58-1ccd-4e8a-8994-66f32e5c607a","","",false, this);
 
            CHTotalCDAmountCurrency = RPSControlFactory.CreateRPSFormattedTextBox<SituationChangeChildDialogView>("3d16d551-52c3-44c8-a529-4021a544c2f4","","",false, this);
 
            CHToPayCurrency = RPSControlFactory.CreateRPSFormattedTextBox<SituationChangeChildDialogView>("23a1c1b6-c7f9-4de6-9d9a-8292c16ff87e","","",false, this);
 
            CHTotalCDToleranceAmountCurrency = RPSControlFactory.CreateRPSFormattedTextBox<SituationChangeChildDialogView>("6bb6a085-512a-434b-8cd0-e60c07de0be9","","",false, this);
 
            CHAccountingDate = RPSControlFactory.CreateRPSTextBox<SituationChangeChildDialogView>("635ca18d-b814-4e8b-bb70-f10c65382890","","",false, this);
 
            ProposedCompany = RPSControlFactory.CreateRPSOption<SituationChangeChildDialogView>( "9db920e4-64f0-4baa-8771-fb9496caff73","","",this);
 
            CHIDCurrency = RPSControlFactory.CreateRPSComboBox<SituationChangeChildDialogView>("9e511d57-d09f-4904-bc46-f948a636209b","","",false, this);
 
            Change1 = RPSControlFactory.CreateRPSFormattedTextBox<SituationChangeChildDialogView>("5aa50f5f-49dc-4b02-a2ee-74ea7ae0b421","","",false, this);
 
            CHToPay1 = RPSControlFactory.CreateRPSFormattedTextBox<SituationChangeChildDialogView>("8bce7769-9ab7-4736-88ae-094cdd660381","","",false, this);
 
            Payed = RPSControlFactory.CreateRPSFormattedTextBox<SituationChangeChildDialogView>("3f5ecea6-88ab-48c5-a2e8-870090cb60be","","",false, this);
 
            ProposedCurrency = RPSControlFactory.CreateRPSOption<SituationChangeChildDialogView>( "8c65eb66-168b-464b-8a40-906d0614cbe8","","",this);
 
            CHIDCurrency1 = RPSControlFactory.CreateRPSComboBox<SituationChangeChildDialogView>("8916f093-0ff8-463b-a501-fb210ab48db3","","",false, this);
 
            Change = RPSControlFactory.CreateRPSFormattedTextBox<SituationChangeChildDialogView>("f0537b6b-4f24-428b-b18d-125bc0686249","","",false, this);
 
            CHToPayCurrency1 = RPSControlFactory.CreateRPSFormattedTextBox<SituationChangeChildDialogView>("7b794d22-5d71-4aa8-b698-88c9f656246b","","",false, this);
 
            PayedCurrency = RPSControlFactory.CreateRPSFormattedTextBox<SituationChangeChildDialogView>("e8fc6239-64c5-4442-ae12-ac95b8ab83a8","","",false, this);
 
            CompanyCurrency = RPSControlFactory.CreateRPSOption<SituationChangeChildDialogView>( "2e2ddd18-8cf1-4f17-b402-677cfac614e9","","",this);
 
            IDCompanyCurrency = RPSControlFactory.CreateRPSComboBox<SituationChangeChildDialogView>("5476ef37-74f6-4488-8adb-c1c4e69840ff","","",false, this);
 
            ChangeCompanyCurrency = RPSControlFactory.CreateRPSFormattedTextBox<SituationChangeChildDialogView>("34e981e9-b98b-4038-8162-f4f370a9dba4","","",false, this);
 
            ToPayCompanyCurrency = RPSControlFactory.CreateRPSFormattedTextBox<SituationChangeChildDialogView>("da6a805f-146e-4a3b-a6e8-08b7a9c858e6","","",false, this);
 
            PayedCompanyCurrency = RPSControlFactory.CreateRPSFormattedTextBox<SituationChangeChildDialogView>("0ed94d48-ffed-47ca-bb97-a2e0035c6104","","",false, this);
 
            AnotherCurrency = RPSControlFactory.CreateRPSOption<SituationChangeChildDialogView>( "f501fdad-f2bc-4d7a-a645-1323762a91c4","","",this);
 
            IDAnotherCurrency = RPSControlFactory.CreateRPSComboBox<SituationChangeChildDialogView>("869e0bac-32ff-4219-b6db-843fdd5e66d1","","",false, this);
 
            ChangeAnotherCurrency = RPSControlFactory.CreateRPSFormattedTextBox<SituationChangeChildDialogView>("0713bfce-aba5-4cee-9b8a-4f7c3a9fb3ce","","",false, this);
 
            ToPayAnotherCurrency = RPSControlFactory.CreateRPSFormattedTextBox<SituationChangeChildDialogView>("a5ebd1eb-8436-4fdd-8956-a1bae61908b9","","",false, this);
 
            PayedAnotherCurrency = RPSControlFactory.CreateRPSFormattedTextBox<SituationChangeChildDialogView>("5c19922e-53ba-4a52-8d62-1ae658fbf0a9","","",false, this);
 
            PayedResult = RPSControlFactory.CreateRPSFormattedTextBox<SituationChangeChildDialogView>("d2db2056-9bda-4bd6-a1e7-dff035b91521","","",false, this);
 
            TolUsedResult = RPSControlFactory.CreateRPSFormattedTextBox<SituationChangeChildDialogView>("c991e590-d22d-46b4-b9d3-e97d94c9e677","","",false, this);
 
            DiffResult = RPSControlFactory.CreateRPSFormattedTextBox<SituationChangeChildDialogView>("75fd56f0-38b2-45ab-8a4a-d7a10fd48caf","","",false, this);
 
            PayedCurrencyResult = RPSControlFactory.CreateRPSFormattedTextBox<SituationChangeChildDialogView>("a7c22668-950b-4380-8ee2-251995be78db","","",false, this);
 
            TolUsedCurrencyResult = RPSControlFactory.CreateRPSFormattedTextBox<SituationChangeChildDialogView>("0315a76b-5e89-4981-9038-943d612c7fcb","","",false, this);
 
            DiffCurrencyResult = RPSControlFactory.CreateRPSFormattedTextBox<SituationChangeChildDialogView>("b60f9bfa-ed71-4111-826b-e26d8846fcde","","",false, this);
 
            IDPaymentTypeTo = RPSControlFactory.CreateRPSComboBox<SituationChangeChildDialogView>("ee54ff94-767a-4023-ac32-b41c1e829af3","","",false, this);
 
            IDPaymentStatusTo = RPSControlFactory.CreateRPSComboBox<SituationChangeChildDialogView>("7e54bd3c-f205-4d26-b3b2-97da07598093","","",false, this);
 
            AccountingDate = RPSControlFactory.CreateRPSTextBox<SituationChangeChildDialogView>("6c1c2c79-d1e6-4562-ad19-f8128ec31357","","",false, this);
 
            Bank = RPSControlFactory.CreateRPSOption<SituationChangeChildDialogView>( "496aaead-fa62-4ebe-96ee-436b279cd7cc","","",this);
 
            IDBankAccountCompany = RPSControlFactory.CreateRPSComboBox<SituationChangeChildDialogView>("2e641a52-5373-46aa-a1cc-5288ab04d7f8","","",false, this);
 
            CashCollector = RPSControlFactory.CreateRPSOption<SituationChangeChildDialogView>( "99181be7-4f1b-40f1-9466-4c150629e263","","",this);
 
            IDCashCollector = RPSControlFactory.CreateRPSComboBox<SituationChangeChildDialogView>("a4a20774-1a36-4316-9d42-b5081581efcc","","",false, this);
 
            CodInvoiceBank = RPSControlFactory.CreateRPSTextBox<SituationChangeChildDialogView>("6395fbb3-ec8a-4d05-8f43-63e853493714","","",false, this);
 
            NewRefNumber = RPSControlFactory.CreateRPSTextBox<SituationChangeChildDialogView>("98443f6a-c64d-4591-978b-5686a2350edb","","",false, this);
 
            NewRefDate = RPSControlFactory.CreateRPSTextBox<SituationChangeChildDialogView>("0bedabd6-0608-4057-9815-29ce9accb3aa","","",false, this);
 
            NewComment = RPSControlFactory.CreateRPSTextBox<SituationChangeChildDialogView>("fee40736-c21c-4b1b-bd0d-ac0126fad042","","",false, this);
 
            ResumenToPay = RPSControlFactory.CreateRPSFormattedTextBox<SituationChangeChildDialogView>("452a8cc6-34d1-4ab2-aede-16427954dbec","","",false, this);
 
            ResumenPayed = RPSControlFactory.CreateRPSFormattedTextBox<SituationChangeChildDialogView>("d9fcaf79-cae6-4af4-8752-73290ad81071","","",false, this);
 
            ResumenTolUsed = RPSControlFactory.CreateRPSFormattedTextBox<SituationChangeChildDialogView>("33b44065-e177-4969-9b1d-04c19f499fb8","","",false, this);
 
            ResumenDif = RPSControlFactory.CreateRPSFormattedTextBox<SituationChangeChildDialogView>("74f71b77-ae91-46f7-bce5-bb1dc581f4cf","","",false, this);
 
            TotalSelected = RPSControlFactory.CreateRPSOption<SituationChangeChildDialogView>( "4bad87d0-e9cb-494f-ba14-21965a9a970f","","",this);
 
            NewDraftDiff = RPSControlFactory.CreateRPSOption<SituationChangeChildDialogView>( "c8a87bff-66c6-450c-80f9-2b929a84a2e3","","",this);
 
            TotalWithNewDrafts = RPSControlFactory.CreateRPSOption<SituationChangeChildDialogView>( "9cc03af5-a9a7-498a-9e28-034ca6414cb0","","",this);
 
            ResumenToPay1 = RPSControlFactory.CreateRPSFormattedTextBox<SituationChangeChildDialogView>("516a7bc5-b211-495a-89e1-1d84a861f3f3","","",false, this);
 
            ResumenPayed1 = RPSControlFactory.CreateRPSFormattedTextBox<SituationChangeChildDialogView>("72292543-83a0-46fe-97f6-7e3a093842b4","","",false, this);
 
            ResumenTolUsed1 = RPSControlFactory.CreateRPSFormattedTextBox<SituationChangeChildDialogView>("b62d2e20-5609-46b8-a657-5f6056196605","","",false, this);
 
            ResumenDif1 = RPSControlFactory.CreateRPSFormattedTextBox<SituationChangeChildDialogView>("88b9cf4f-a37a-4288-bcfb-7c7725bfc52b","","",false, this);
 
            ResumenSumDif = RPSControlFactory.CreateRPSFormattedTextBox<SituationChangeChildDialogView>("6300e45e-395e-42fa-8b04-cff96df1129d","","",false, this);
 
            NewCollectionDraftDiffAmountCommandButton = RPSControlFactory.CreateRPSButton<SituationChangeChildDialogView>( "0c93508c-0117-4362-a050-845a5be4d7b6","","",this);
 
            IDACCTransactionsResult = RPSControlFactory.CreateRPSComboBox<SituationChangeChildDialogView>("59a0a5f4-6b71-4f49-be02-2643a7ea77f1","","",false, this);
 
            CollectionInit params_GetLastDraft = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3645f3a7-9ede-4876-a552-724e23ed96d2",CSSSelectorGrid="",XPathGrid=""};
            GetLastDraft = RPSControlFactory.RPSCreateCollectionWithGrid<GetLastDraftCollectionEditor<SituationChangeChildDialogView>,SituationChangeChildDialogView>( params_GetLastDraft,this);
 
            CollectionInit params_CollectionDraftsDiffAmounts = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="aeb71757-178d-4d8d-a54f-cae9572bacce",CSSSelectorGrid="",XPathGrid=""};
            CollectionDraftsDiffAmounts = RPSControlFactory.RPSCreateCollectionWithGrid<CollectionDraftsDiffAmountsCollectionEditor<SituationChangeChildDialogView>,SituationChangeChildDialogView>( params_CollectionDraftsDiffAmounts,this);
 

        }
        public IRPSTextBox<SituationChangeChildDialogView> CHTotalAmount { get; set; } 
        public IRPSTextBox<SituationChangeChildDialogView> CHTotalCDAmount { get; set; } 
        public IRPSTextBox<SituationChangeChildDialogView> CHToPay { get; set; } 
        public IRPSTextBox<SituationChangeChildDialogView> CHTotalCDToleranceAmount { get; set; } 
        public IRPSTextBox<SituationChangeChildDialogView> CHTotalAmountCurrency { get; set; } 
        public IRPSTextBox<SituationChangeChildDialogView> CHTotalCDAmountCurrency { get; set; } 
        public IRPSTextBox<SituationChangeChildDialogView> CHToPayCurrency { get; set; } 
        public IRPSTextBox<SituationChangeChildDialogView> CHTotalCDToleranceAmountCurrency { get; set; } 
        public IRPSTextBox<SituationChangeChildDialogView> CHAccountingDate { get; set; } 
        public IRPSOption<SituationChangeChildDialogView> ProposedCompany { get; set; } 
        public IRPSComboBox<SituationChangeChildDialogView> CHIDCurrency { get; set; } 
        public IRPSTextBox<SituationChangeChildDialogView> Change1 { get; set; } 
        public IRPSTextBox<SituationChangeChildDialogView> CHToPay1 { get; set; } 
        public IRPSTextBox<SituationChangeChildDialogView> Payed { get; set; } 
        public IRPSOption<SituationChangeChildDialogView> ProposedCurrency { get; set; } 
        public IRPSComboBox<SituationChangeChildDialogView> CHIDCurrency1 { get; set; } 
        public IRPSTextBox<SituationChangeChildDialogView> Change { get; set; } 
        public IRPSTextBox<SituationChangeChildDialogView> CHToPayCurrency1 { get; set; } 
        public IRPSTextBox<SituationChangeChildDialogView> PayedCurrency { get; set; } 
        public IRPSOption<SituationChangeChildDialogView> CompanyCurrency { get; set; } 
        public IRPSComboBox<SituationChangeChildDialogView> IDCompanyCurrency { get; set; } 
        public IRPSTextBox<SituationChangeChildDialogView> ChangeCompanyCurrency { get; set; } 
        public IRPSTextBox<SituationChangeChildDialogView> ToPayCompanyCurrency { get; set; } 
        public IRPSTextBox<SituationChangeChildDialogView> PayedCompanyCurrency { get; set; } 
        public IRPSOption<SituationChangeChildDialogView> AnotherCurrency { get; set; } 
        public IRPSComboBox<SituationChangeChildDialogView> IDAnotherCurrency { get; set; } 
        public IRPSTextBox<SituationChangeChildDialogView> ChangeAnotherCurrency { get; set; } 
        public IRPSTextBox<SituationChangeChildDialogView> ToPayAnotherCurrency { get; set; } 
        public IRPSTextBox<SituationChangeChildDialogView> PayedAnotherCurrency { get; set; } 
        public IRPSTextBox<SituationChangeChildDialogView> PayedResult { get; set; } 
        public IRPSTextBox<SituationChangeChildDialogView> TolUsedResult { get; set; } 
        public IRPSTextBox<SituationChangeChildDialogView> DiffResult { get; set; } 
        public IRPSTextBox<SituationChangeChildDialogView> PayedCurrencyResult { get; set; } 
        public IRPSTextBox<SituationChangeChildDialogView> TolUsedCurrencyResult { get; set; } 
        public IRPSTextBox<SituationChangeChildDialogView> DiffCurrencyResult { get; set; } 
        public IRPSComboBox<SituationChangeChildDialogView> IDPaymentTypeTo { get; set; } 
        public IRPSComboBox<SituationChangeChildDialogView> IDPaymentStatusTo { get; set; } 
        public IRPSTextBox<SituationChangeChildDialogView> AccountingDate { get; set; } 
        public IRPSOption<SituationChangeChildDialogView> Bank { get; set; } 
        public IRPSComboBox<SituationChangeChildDialogView> IDBankAccountCompany { get; set; } 
        public IRPSOption<SituationChangeChildDialogView> CashCollector { get; set; } 
        public IRPSComboBox<SituationChangeChildDialogView> IDCashCollector { get; set; } 
        public IRPSTextBox<SituationChangeChildDialogView> CodInvoiceBank { get; set; } 
        public IRPSTextBox<SituationChangeChildDialogView> NewRefNumber { get; set; } 
        public IRPSTextBox<SituationChangeChildDialogView> NewRefDate { get; set; } 
        public IRPSTextBox<SituationChangeChildDialogView> NewComment { get; set; } 
        public IRPSTextBox<SituationChangeChildDialogView> ResumenToPay { get; set; } 
        public IRPSTextBox<SituationChangeChildDialogView> ResumenPayed { get; set; } 
        public IRPSTextBox<SituationChangeChildDialogView> ResumenTolUsed { get; set; } 
        public IRPSTextBox<SituationChangeChildDialogView> ResumenDif { get; set; } 
        public IRPSOption<SituationChangeChildDialogView> TotalSelected { get; set; } 
        public IRPSOption<SituationChangeChildDialogView> NewDraftDiff { get; set; } 
        public IRPSOption<SituationChangeChildDialogView> TotalWithNewDrafts { get; set; } 
        public IRPSTextBox<SituationChangeChildDialogView> ResumenToPay1 { get; set; } 
        public IRPSTextBox<SituationChangeChildDialogView> ResumenPayed1 { get; set; } 
        public IRPSTextBox<SituationChangeChildDialogView> ResumenTolUsed1 { get; set; } 
        public IRPSTextBox<SituationChangeChildDialogView> ResumenDif1 { get; set; } 
        public IRPSTextBox<SituationChangeChildDialogView> ResumenSumDif { get; set; } 
        public IRPSButton<SituationChangeChildDialogView> NewCollectionDraftDiffAmountCommandButton { get; set; } 
        public IRPSComboBox<SituationChangeChildDialogView> IDACCTransactionsResult { get; set; } 
        public GetLastDraftCollectionEditor<SituationChangeChildDialogView> GetLastDraft { get; set; } 
        public CollectionDraftsDiffAmountsCollectionEditor<SituationChangeChildDialogView> CollectionDraftsDiffAmounts { get; set; } 
        public DraftsQueryManagement Screen { get; set; }
        public SituationChangeChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetLastDraftCollectionEditor<SituationChangeChildDialogView>:RPSCollectionEditor<SituationChangeChildDialogView> where SituationChangeChildDialogView : class, IView
    {
        public  GetLastDraftGridView<SituationChangeChildDialogView> GridView {get;set;}
    }
    public partial class GetLastDraftGridView <SituationChangeChildDialogView> :  RPSGridView<SituationChangeChildDialogView> where SituationChangeChildDialogView : class, IView
    {
        public GetLastDraftGridView(SituationChangeChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {

        }
                     
    }
 
        public partial class CollectionDraftsDiffAmountsCollectionEditor<SituationChangeChildDialogView>:RPSCollectionEditor<SituationChangeChildDialogView> where SituationChangeChildDialogView : class, IView
    {
        public  CollectionDraftsDiffAmountsGridView<SituationChangeChildDialogView> GridView {get;set;}
    }
    public partial class CollectionDraftsDiffAmountsGridView <SituationChangeChildDialogView> :  RPSGridView<SituationChangeChildDialogView> where SituationChangeChildDialogView : class, IView
    {
        public CollectionDraftsDiffAmountsGridView(SituationChangeChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDPaymentType = RPSControlFactory.CreateRPSGridComboBox<SituationChangeChildDialogView>("","#aeb71757-178d-4d8d-a54f-cae9572bacce .ag-row[role='row']@ROWINDEX [col-id='cIDPaymentType']","",false, this.CurrentView);
 
            IDPaymentStatus = RPSControlFactory.CreateRPSGridComboBox<SituationChangeChildDialogView>("","#aeb71757-178d-4d8d-a54f-cae9572bacce .ag-row[role='row']@ROWINDEX [col-id='cIDPaymentStatus']","",false, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<SituationChangeChildDialogView>("","#aeb71757-178d-4d8d-a54f-cae9572bacce .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<SituationChangeChildDialogView> IDPaymentType { get; set; } 
        public IRPSGridComboBox<SituationChangeChildDialogView> IDPaymentStatus { get; set; } 
        public IRPSGridTextBox<SituationChangeChildDialogView> Amount { get; set; } 
                     
    }
 
    }
  
            
    public partial class UpdateReferenceChildDialogView : View
    {
        public UpdateReferenceChildDialogView(DraftsQueryManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NumRef = RPSControlFactory.CreateRPSTextBox<UpdateReferenceChildDialogView>("ef80e330-ddec-4d3a-a84d-96f786fddce0","","",false, this);
 
            ReferenceDate = RPSControlFactory.CreateRPSTextBox<UpdateReferenceChildDialogView>("7a952883-15c4-4711-b578-77785d7df2ce","","",false, this);
 
            Override = RPSControlFactory.CreateRPSCheckBox<UpdateReferenceChildDialogView>("f1fb49a9-ace2-4033-81e6-5b3017964404","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<UpdateReferenceChildDialogView>("8d06b945-232f-4190-901a-3bd1e33b5ec4","","",false, this);
 

        }
        public IRPSTextBox<UpdateReferenceChildDialogView> NumRef { get; set; } 
        public IRPSTextBox<UpdateReferenceChildDialogView> ReferenceDate { get; set; } 
        public IRPSCheckbox<UpdateReferenceChildDialogView> Override { get; set; } 
        public IRPSTextBox<UpdateReferenceChildDialogView> Comment { get; set; } 
        public DraftsQueryManagement Screen { get; set; }
        public UpdateReferenceChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class RemittanceChildDialogView : View
    {
        public RemittanceChildDialogView(DraftsQueryManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            eCustomerSupplier = RPSControlFactory.CreateRPSEnumComboBox<RemittanceChildDialogView>("8dfca046-34cd-46b3-af0b-225b88a3df96","","",false, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<RemittanceChildDialogView>("ecb557fd-8f75-445e-bae6-323211c02d7f","","",false, this);
 
            AmountCurrency = RPSControlFactory.CreateRPSFormattedTextBox<RemittanceChildDialogView>("1d99bc57-db75-4348-a677-c57deb7f06af","","",false, this);
 
            Remitted = RPSControlFactory.CreateRPSCheckBox<RemittanceChildDialogView>("e7dc3a5e-90ff-4873-9cbf-13220967e3fb","","",false, this);
 
            RemittanceNumberInfo = RPSControlFactory.CreateRPSTextBox<RemittanceChildDialogView>("987ce083-4ec3-4ecf-8442-012fe027d778","","",false, this);
 
            IDPaymentType = RPSControlFactory.CreateRPSComboBox<RemittanceChildDialogView>("027531ee-5a31-4567-b6c4-0d2da6f01f86","","",false, this);
 
            IDPaymentStatus = RPSControlFactory.CreateRPSComboBox<RemittanceChildDialogView>("d585d8ff-43bd-4733-b141-98c4cada8ddd","","",false, this);
 
            NotRemitted = RPSControlFactory.CreateRPSCheckBox<RemittanceChildDialogView>("7b2cb7f0-020a-4c16-b919-443f6a17ad85","","",false, this);
 
            OptionNew = RPSControlFactory.CreateRPSOption<RemittanceChildDialogView>( "03a4139c-027b-48f5-8e88-41f706d60dd0","","",this);
 
            OptionAdd = RPSControlFactory.CreateRPSOption<RemittanceChildDialogView>( "cd772880-41ff-4872-8ad5-a2845539c2b6","","",this);
 
            OptionExclude = RPSControlFactory.CreateRPSOption<RemittanceChildDialogView>( "8e6867a2-d3c9-46cb-86c9-532bdd8d6bd1","","",this);
 
            IDBankAccountCompany = RPSControlFactory.CreateRPSComboBox<RemittanceChildDialogView>("a2fdddcb-33c4-4855-bc33-06a8c8e95f91","","",false, this);
 
            IDPaymentStatusEnd = RPSControlFactory.CreateRPSComboBox<RemittanceChildDialogView>("8be034f7-267a-4e16-9427-9a7bf13285a3","","",true, this);
 
            RemittanceDate = RPSControlFactory.CreateRPSTextBox<RemittanceChildDialogView>("b769399c-cae9-4f64-94f9-fab8f0aa29a9","","",true, this);
 
            AccountingDate = RPSControlFactory.CreateRPSTextBox<RemittanceChildDialogView>("35e0b140-e8ad-4f18-9598-83b600c0f6c7","","",true, this);
 
            IDCodingSeries = RPSControlFactory.CreateRPSComboBox<RemittanceChildDialogView>("f81c8185-5559-449f-b35d-154fbd6afed1","","",false, this);
 
            RiskLim = RPSControlFactory.CreateRPSFormattedTextBox<RemittanceChildDialogView>("41b4151d-732f-453b-af46-f49737d666f5","","",false, this);
 
            CurrentRisk = RPSControlFactory.CreateRPSFormattedTextBox<RemittanceChildDialogView>("e31f2a31-04f8-475a-b2d4-72bcadd26f28","","",false, this);
 
            Available = RPSControlFactory.CreateRPSFormattedTextBox<RemittanceChildDialogView>("b066ff39-0cc3-4b02-998b-05c51ce128b3","","",false, this);
 
            RemittanceNumber = RPSControlFactory.CreateRPSTextBox<RemittanceChildDialogView>("51e3897d-be93-4c68-809f-6543ec75000d","","",false, this);
 
            IDBankAccountCompany1 = RPSControlFactory.CreateRPSComboBox<RemittanceChildDialogView>("cc78cc4f-5781-41a5-a744-957fc96b075d","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<RemittanceChildDialogView>("a578c490-426f-4940-b20b-246353eef2da","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<RemittanceChildDialogView>("b0986722-9eff-4c45-8f32-5aeb4385c63a","","",false, this);
 
            bExcludeFinal = RPSControlFactory.CreateRPSCheckBox<RemittanceChildDialogView>("d2bef543-6654-413f-b30c-e0f138d4206a","","",false, this);
 
            ExecuteGetRemittanceNumbers = RPSControlFactory.CreateRPSButton<RemittanceChildDialogView>( "0bd27487-5eb0-48ff-a520-d1a766bf7b60","","",this);
 
            eCustomerSupplier1 = RPSControlFactory.CreateRPSEnumComboBox<RemittanceChildDialogView>("b05be56a-f573-46b7-8132-88df9d2ee343","","",false, this);
 
            Amount1 = RPSControlFactory.CreateRPSFormattedTextBox<RemittanceChildDialogView>("75cd2cf1-fa2f-4e79-a439-bb30325d1452","","",false, this);
 
            AmountCurrency1 = RPSControlFactory.CreateRPSFormattedTextBox<RemittanceChildDialogView>("6f8fefe0-114f-49b5-9025-023a68d6a896","","",false, this);
 
            eCustomerSupplierRemittanceSelected = RPSControlFactory.CreateRPSEnumComboBox<RemittanceChildDialogView>("ee7b79c8-ab50-4992-ac27-8846ce599b71","","",false, this);
 
            AmountRemittanceSelected = RPSControlFactory.CreateRPSFormattedTextBox<RemittanceChildDialogView>("93a349d4-ce36-4718-99a1-16607d3a8ba1","","",false, this);
 
            AmountCurrencyRemittanceSelected = RPSControlFactory.CreateRPSFormattedTextBox<RemittanceChildDialogView>("bb3ab71d-5d40-4bf2-b0df-e5678428aff2","","",false, this);
 
            eCustomerSupplierResult = RPSControlFactory.CreateRPSEnumComboBox<RemittanceChildDialogView>("8b2f3a15-6560-496e-ba87-902a126454fe","","",false, this);
 
            AmountResult = RPSControlFactory.CreateRPSFormattedTextBox<RemittanceChildDialogView>("bab98e5e-eb83-4fe4-bb78-053095d42b7e","","",false, this);
 
            AmountCurrencyResult = RPSControlFactory.CreateRPSFormattedTextBox<RemittanceChildDialogView>("455bed19-e468-4193-9a1f-59c8f88f20e3","","",false, this);
 
            AccountingDate1 = RPSControlFactory.CreateRPSTextBox<RemittanceChildDialogView>("db080450-520e-4356-929f-0dac80c393af","","",true, this);
 
            IDPaymentStatusEnd1 = RPSControlFactory.CreateRPSComboBox<RemittanceChildDialogView>("3b429a6c-e7ed-479d-aadf-ed18fb50d41b","","",true, this);
 
            AccountingDate2 = RPSControlFactory.CreateRPSTextBox<RemittanceChildDialogView>("cc85520e-73a0-41de-8b73-481a27c43512","","",true, this);
 
            IDPaymentStatusEndExclude = RPSControlFactory.CreateRPSComboBox<RemittanceChildDialogView>("cb3024cb-7d70-4e81-8d17-c09a0702411c","","",true, this);
 
            ReturnDate = RPSControlFactory.CreateRPSTextBox<RemittanceChildDialogView>("8eccb292-8c00-4223-aa6f-92fe604921dc","","",false, this);
 
            IDUnpaidCause = RPSControlFactory.CreateRPSComboBox<RemittanceChildDialogView>("97589fd0-817a-4380-b9ab-d85b296945db","","",false, this);
 
            returnExpenses = RPSControlFactory.CreateRPSFormattedTextBox<RemittanceChildDialogView>("47568d9a-8f5f-429a-90df-91cbd93bf04e","","",false, this);
 
            AccountingDate3 = RPSControlFactory.CreateRPSTextBox<RemittanceChildDialogView>("1978bd61-732e-4284-9588-896b538cf823","","",true, this);
 
            IDPaymentStatusEndExclude1 = RPSControlFactory.CreateRPSComboBox<RemittanceChildDialogView>("b2a38623-8c8d-4e30-aa26-84b651b25191","","",true, this);
 
            ReturnDate1 = RPSControlFactory.CreateRPSTextBox<RemittanceChildDialogView>("d9cc3c1a-f9d1-49b4-9fd8-89233ef55e1c","","",false, this);
 
            IDUnpaidCause1 = RPSControlFactory.CreateRPSComboBox<RemittanceChildDialogView>("cdd68356-265d-43ae-a515-9e6276152b68","","",false, this);
 
            returnExpenses1 = RPSControlFactory.CreateRPSFormattedTextBox<RemittanceChildDialogView>("56ee3bc2-bd93-4eca-a510-ec5ec2272969","","",false, this);
 
            NewRemittanceNumber = RPSControlFactory.CreateRPSTextBox<RemittanceChildDialogView>("12901184-d390-44ec-966b-33027e42a6a8","","",false, this);
 
            NewRemittanceCommand = RPSControlFactory.CreateRPSButton<RemittanceChildDialogView>( "47b00a06-d527-48f2-826d-ee4061186656","","",this);
 
            IDACCTransactionsResult = RPSControlFactory.CreateRPSComboBox<RemittanceChildDialogView>("90bf3464-25f1-47c2-b066-976e71b65541","","",false, this);
 
            ErrorDescriptions = RPSControlFactory.CreateRPSTextBox<RemittanceChildDialogView>("a3ac3956-dda7-4285-b6fb-e592111cdd80","","",false, this);
 
            CollectionInit params_GetRemittanceNumbers = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d04132ee-3382-4bc9-b2c2-b21d8be9f215",CSSSelectorGrid="",XPathGrid=""};
            GetRemittanceNumbers = RPSControlFactory.RPSCreateCollectionWithGrid<GetRemittanceNumbersCollectionEditor<RemittanceChildDialogView>,RemittanceChildDialogView>( params_GetRemittanceNumbers,this);
 

        }
        public IRPSComboBox<RemittanceChildDialogView> eCustomerSupplier { get; set; } 
        public IRPSTextBox<RemittanceChildDialogView> Amount { get; set; } 
        public IRPSTextBox<RemittanceChildDialogView> AmountCurrency { get; set; } 
        public IRPSCheckbox<RemittanceChildDialogView> Remitted { get; set; } 
        public IRPSTextBox<RemittanceChildDialogView> RemittanceNumberInfo { get; set; } 
        public IRPSComboBox<RemittanceChildDialogView> IDPaymentType { get; set; } 
        public IRPSComboBox<RemittanceChildDialogView> IDPaymentStatus { get; set; } 
        public IRPSCheckbox<RemittanceChildDialogView> NotRemitted { get; set; } 
        public IRPSOption<RemittanceChildDialogView> OptionNew { get; set; } 
        public IRPSOption<RemittanceChildDialogView> OptionAdd { get; set; } 
        public IRPSOption<RemittanceChildDialogView> OptionExclude { get; set; } 
        public IRPSComboBox<RemittanceChildDialogView> IDBankAccountCompany { get; set; } 
        public IRPSComboBox<RemittanceChildDialogView> IDPaymentStatusEnd { get; set; } 
        public IRPSTextBox<RemittanceChildDialogView> RemittanceDate { get; set; } 
        public IRPSTextBox<RemittanceChildDialogView> AccountingDate { get; set; } 
        public IRPSComboBox<RemittanceChildDialogView> IDCodingSeries { get; set; } 
        public IRPSTextBox<RemittanceChildDialogView> RiskLim { get; set; } 
        public IRPSTextBox<RemittanceChildDialogView> CurrentRisk { get; set; } 
        public IRPSTextBox<RemittanceChildDialogView> Available { get; set; } 
        public IRPSTextBox<RemittanceChildDialogView> RemittanceNumber { get; set; } 
        public IRPSComboBox<RemittanceChildDialogView> IDBankAccountCompany1 { get; set; } 
        public IRPSTextBox<RemittanceChildDialogView> DateFrom { get; set; } 
        public IRPSTextBox<RemittanceChildDialogView> DateTo { get; set; } 
        public IRPSCheckbox<RemittanceChildDialogView> bExcludeFinal { get; set; } 
        public IRPSButton<RemittanceChildDialogView> ExecuteGetRemittanceNumbers { get; set; } 
        public IRPSComboBox<RemittanceChildDialogView> eCustomerSupplier1 { get; set; } 
        public IRPSTextBox<RemittanceChildDialogView> Amount1 { get; set; } 
        public IRPSTextBox<RemittanceChildDialogView> AmountCurrency1 { get; set; } 
        public IRPSComboBox<RemittanceChildDialogView> eCustomerSupplierRemittanceSelected { get; set; } 
        public IRPSTextBox<RemittanceChildDialogView> AmountRemittanceSelected { get; set; } 
        public IRPSTextBox<RemittanceChildDialogView> AmountCurrencyRemittanceSelected { get; set; } 
        public IRPSComboBox<RemittanceChildDialogView> eCustomerSupplierResult { get; set; } 
        public IRPSTextBox<RemittanceChildDialogView> AmountResult { get; set; } 
        public IRPSTextBox<RemittanceChildDialogView> AmountCurrencyResult { get; set; } 
        public IRPSTextBox<RemittanceChildDialogView> AccountingDate1 { get; set; } 
        public IRPSComboBox<RemittanceChildDialogView> IDPaymentStatusEnd1 { get; set; } 
        public IRPSTextBox<RemittanceChildDialogView> AccountingDate2 { get; set; } 
        public IRPSComboBox<RemittanceChildDialogView> IDPaymentStatusEndExclude { get; set; } 
        public IRPSTextBox<RemittanceChildDialogView> ReturnDate { get; set; } 
        public IRPSComboBox<RemittanceChildDialogView> IDUnpaidCause { get; set; } 
        public IRPSTextBox<RemittanceChildDialogView> returnExpenses { get; set; } 
        public IRPSTextBox<RemittanceChildDialogView> AccountingDate3 { get; set; } 
        public IRPSComboBox<RemittanceChildDialogView> IDPaymentStatusEndExclude1 { get; set; } 
        public IRPSTextBox<RemittanceChildDialogView> ReturnDate1 { get; set; } 
        public IRPSComboBox<RemittanceChildDialogView> IDUnpaidCause1 { get; set; } 
        public IRPSTextBox<RemittanceChildDialogView> returnExpenses1 { get; set; } 
        public IRPSTextBox<RemittanceChildDialogView> NewRemittanceNumber { get; set; } 
        public IRPSButton<RemittanceChildDialogView> NewRemittanceCommand { get; set; } 
        public IRPSComboBox<RemittanceChildDialogView> IDACCTransactionsResult { get; set; } 
        public IRPSTextBox<RemittanceChildDialogView> ErrorDescriptions { get; set; } 
        public GetRemittanceNumbersCollectionEditor<RemittanceChildDialogView> GetRemittanceNumbers { get; set; } 
        public DraftsQueryManagement Screen { get; set; }
        public RemittanceChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetRemittanceNumbersCollectionEditor<RemittanceChildDialogView>:RPSCollectionEditor<RemittanceChildDialogView> where RemittanceChildDialogView : class, IView
    {
        public  GetRemittanceNumbersGridView<RemittanceChildDialogView> GridView {get;set;}
    }
    public partial class GetRemittanceNumbersGridView <RemittanceChildDialogView> :  RPSGridView<RemittanceChildDialogView> where RemittanceChildDialogView : class, IView
    {
        public GetRemittanceNumbersGridView(RemittanceChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            RemittanceNumber = RPSControlFactory.CreateRPSGridTextBox<RemittanceChildDialogView>("","#d04132ee-3382-4bc9-b2c2-b21d8be9f215 .ag-row[role='row']@ROWINDEX [col-id='cRemittanceNumber']","",false, this.CurrentView);
 
            RemittanceDate = RPSControlFactory.CreateRPSGridTextBox<RemittanceChildDialogView>("","#d04132ee-3382-4bc9-b2c2-b21d8be9f215 .ag-row[role='row']@ROWINDEX [col-id='cRemittanceDate']","",false, this.CurrentView);
 
            CustomerSupplier = RPSControlFactory.CreateRPSGridEnumComboBox<RemittanceChildDialogView>("","#d04132ee-3382-4bc9-b2c2-b21d8be9f215 .ag-row[role='row']@ROWINDEX [col-id='cCustomerSupplier']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<RemittanceChildDialogView> RemittanceNumber { get; set; } 
        public IRPSGridTextBox<RemittanceChildDialogView> RemittanceDate { get; set; } 
        public IRPSGridComboBox<RemittanceChildDialogView> CustomerSupplier { get; set; } 
                     
    }
 
    }
  
            
    public partial class DraftGroupChildDialogView : View
    {
        public DraftGroupChildDialogView(DraftsQueryManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Customer = RPSControlFactory.CreateRPSOption<DraftGroupChildDialogView>( "41a18743-dd8b-4fa5-8d85-274991546345","","",this);
 
            Supplier = RPSControlFactory.CreateRPSOption<DraftGroupChildDialogView>( "a5ed8b8e-2cc6-43d1-a9bd-bb2193934324","","",this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<DraftGroupChildDialogView>("e4d7cd62-a644-47f9-a406-0198604b3c85","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<DraftGroupChildDialogView>("493395c6-8871-46d4-abd5-846b16332f9b","","",false, this);
 
            IDPaymentType = RPSControlFactory.CreateRPSComboBox<DraftGroupChildDialogView>("c88eb406-f295-46fe-8ace-a90195096827","","",false, this);
 
            CodInvoice = RPSControlFactory.CreateRPSTextBox<DraftGroupChildDialogView>("61ec6911-6a2c-4acf-acea-5f89583d84d3","","",true, this);
 
            DraftNumber = RPSControlFactory.CreateRPSTextBox<DraftGroupChildDialogView>("bf4b9f2e-5930-4021-89b5-df9446892ac3","","",true, this);
 
            InvoiceDate = RPSControlFactory.CreateRPSTextBox<DraftGroupChildDialogView>("2d214b54-4422-4a5b-a572-7aa6d68f98cf","","",true, this);
 
            DueDate = RPSControlFactory.CreateRPSTextBox<DraftGroupChildDialogView>("41eada2b-2e00-41ba-a8d7-506108a51827","","",false, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<DraftGroupChildDialogView>("7047e11d-4550-48f9-a4f3-575fcb788964","","",false, this);
 
            AmountCurrency = RPSControlFactory.CreateRPSFormattedTextBox<DraftGroupChildDialogView>("47c90e0e-42c3-4012-91ca-40440a0bab1b","","",false, this);
 
            Change = RPSControlFactory.CreateRPSFormattedTextBox<DraftGroupChildDialogView>("a90aba9c-8aba-4970-99e6-6a2b2de8aae8","","",false, this);
 
            CDDueDate = RPSControlFactory.CreateRPSTextBox<DraftGroupChildDialogView>("76cf53c1-bb76-4d48-8555-3357ed890fdf","","",false, this);
 
            CDAmount = RPSControlFactory.CreateRPSFormattedTextBox<DraftGroupChildDialogView>("9fa212fc-bc20-498e-a637-6bbfaab4a95f","","",false, this);
 
            CDToleranceDueDate = RPSControlFactory.CreateRPSTextBox<DraftGroupChildDialogView>("6d943419-ef7c-4bea-9674-b73c853b3a49","","",false, this);
 
            CDToleranceAmount = RPSControlFactory.CreateRPSFormattedTextBox<DraftGroupChildDialogView>("dd603144-c09d-46b7-88b6-72a33a8d56fb","","",false, this);
 
            IDCashCollector = RPSControlFactory.CreateRPSComboBox<DraftGroupChildDialogView>("88e1912a-7422-421e-afc8-69fb0fce2bf6","","",false, this);
 
            OptionNo = RPSControlFactory.CreateRPSOption<DraftGroupChildDialogView>( "ed49bfad-d8b6-48de-a0fa-81979579b45d","","",this);
 
            OptionYes = RPSControlFactory.CreateRPSOption<DraftGroupChildDialogView>( "24b26c9a-424f-4f15-b369-dcd540063490","","",this);
 
            AccountingDate = RPSControlFactory.CreateRPSTextBox<DraftGroupChildDialogView>("3493b13c-f592-4988-84c5-d73e74c14924","","",false, this);
 

        }
        public IRPSOption<DraftGroupChildDialogView> Customer { get; set; } 
        public IRPSOption<DraftGroupChildDialogView> Supplier { get; set; } 
        public IRPSComboBox<DraftGroupChildDialogView> IDCustomer { get; set; } 
        public IRPSComboBox<DraftGroupChildDialogView> IDSupplier { get; set; } 
        public IRPSComboBox<DraftGroupChildDialogView> IDPaymentType { get; set; } 
        public IRPSTextBox<DraftGroupChildDialogView> CodInvoice { get; set; } 
        public IRPSTextBox<DraftGroupChildDialogView> DraftNumber { get; set; } 
        public IRPSTextBox<DraftGroupChildDialogView> InvoiceDate { get; set; } 
        public IRPSTextBox<DraftGroupChildDialogView> DueDate { get; set; } 
        public IRPSTextBox<DraftGroupChildDialogView> Amount { get; set; } 
        public IRPSTextBox<DraftGroupChildDialogView> AmountCurrency { get; set; } 
        public IRPSTextBox<DraftGroupChildDialogView> Change { get; set; } 
        public IRPSTextBox<DraftGroupChildDialogView> CDDueDate { get; set; } 
        public IRPSTextBox<DraftGroupChildDialogView> CDAmount { get; set; } 
        public IRPSTextBox<DraftGroupChildDialogView> CDToleranceDueDate { get; set; } 
        public IRPSTextBox<DraftGroupChildDialogView> CDToleranceAmount { get; set; } 
        public IRPSComboBox<DraftGroupChildDialogView> IDCashCollector { get; set; } 
        public IRPSOption<DraftGroupChildDialogView> OptionNo { get; set; } 
        public IRPSOption<DraftGroupChildDialogView> OptionYes { get; set; } 
        public IRPSTextBox<DraftGroupChildDialogView> AccountingDate { get; set; } 
        public DraftsQueryManagement Screen { get; set; }
        public DraftGroupChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ChecksChildDialogView : View
    {
        public ChecksChildDialogView(DraftsQueryManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Check = RPSControlFactory.CreateRPSOption<ChecksChildDialogView>( "9ff7034a-3c64-4f59-83d6-34916fc01a70","","",this);
 
            PromissoryNote = RPSControlFactory.CreateRPSOption<ChecksChildDialogView>( "511c43e1-f2f5-4b79-a3b3-398e597f2145","","",this);
 
            IDBankAccountCompany = RPSControlFactory.CreateRPSComboBox<ChecksChildDialogView>("7a3a3272-79a8-4b00-805e-49fd7eb32c45","","",false, this);
 
            IDCodingSeriesCheck = RPSControlFactory.CreateRPSComboBox<ChecksChildDialogView>("1f25720e-e953-45d1-aea6-5b003facde5e","","",false, this);
 
            IDCodingSeriesPromissoryNote = RPSControlFactory.CreateRPSComboBox<ChecksChildDialogView>("73e0e524-6a6d-4422-bb09-4bdf8e4cc3f4","","",false, this);
 
            IDPaymentType = RPSControlFactory.CreateRPSComboBox<ChecksChildDialogView>("6abf7b0c-eb85-40ad-b2dc-22cdf165f2fc","","",false, this);
 
            IDPaymentStatus = RPSControlFactory.CreateRPSComboBox<ChecksChildDialogView>("8f2a5384-6316-4f01-8bdf-efcfa7f5414c","","",false, this);
 
            AccountingDate = RPSControlFactory.CreateRPSTextBox<ChecksChildDialogView>("941fc145-fdcc-48b8-a567-c383189cf8c2","","",false, this);
 
            CheckDate = RPSControlFactory.CreateRPSTextBox<ChecksChildDialogView>("db7520f1-ad5e-4814-a638-664f1f583e50","","",false, this);
 
            FixedDate = RPSControlFactory.CreateRPSOption<ChecksChildDialogView>( "96ab3ffd-2c19-4831-8e12-22263c4b87d2","","",this);
 
            DocumentDueDateFixed = RPSControlFactory.CreateRPSTextBox<ChecksChildDialogView>("d3ca7cb3-443c-46d4-8c35-fbd3b84c2dd0","","",false, this);
 
            MaxDate = RPSControlFactory.CreateRPSOption<ChecksChildDialogView>( "3e797a52-b232-4582-93db-6678d86c9603","","",this);
 
            bGroup = RPSControlFactory.CreateRPSCheckBox<ChecksChildDialogView>("725925e0-a307-437a-8944-0f59587f0763","","",false, this);
 
            bGroup1 = RPSControlFactory.CreateRPSCheckBox<ChecksChildDialogView>("292214d6-37e7-44a3-9674-9b894afd9ee8","","",false, this);
 
            Place = RPSControlFactory.CreateRPSTextBox<ChecksChildDialogView>("ae62d532-a20c-43d6-a2cd-a1fd839821f5","","",true, this);
 
            Nothing = RPSControlFactory.CreateRPSOption<ChecksChildDialogView>( "799dc971-ab6b-4476-a2d0-3b1da041fadb","","",this);
 
            OnlyCheckOne = RPSControlFactory.CreateRPSOption<ChecksChildDialogView>( "b8699122-ae5d-4807-ac60-9e07573490d2","","",this);
 
            OnlyCheckMult = RPSControlFactory.CreateRPSOption<ChecksChildDialogView>( "f2fa6062-0166-46df-9982-a793a20b52c8","","",this);
 
            CheckWithletter = RPSControlFactory.CreateRPSOption<ChecksChildDialogView>( "84f2cbac-a83d-4ccc-b67a-caed1589b9f8","","",this);
 
            UseBank = RPSControlFactory.CreateRPSOption<ChecksChildDialogView>( "d1e9e5e5-0a28-454a-9e5b-e1f8b1dd37d7","","",this);
 
            OtherReport = RPSControlFactory.CreateRPSOption<ChecksChildDialogView>( "7c768f5c-6991-4ac2-8f80-3fbe452a75c3","","",this);
 
            CodCustomReportCheck = RPSControlFactory.CreateRPSComboBox<ChecksChildDialogView>("df32412e-f805-477b-aa58-f6bc0675648d","","",false, this);
 
            CodCustomReportPrommissoryNote = RPSControlFactory.CreateRPSComboBox<ChecksChildDialogView>("4cb2c6cd-ee04-439a-bbf0-1da87c9f750d","","",false, this);
 
            LanguageThird = RPSControlFactory.CreateRPSOption<ChecksChildDialogView>( "4f7d5b5b-524f-4665-877b-65278d0a4e19","","",this);
 
            OtherLanguage = RPSControlFactory.CreateRPSOption<ChecksChildDialogView>( "1607dfc9-58ee-480c-bd21-945ee670e13e","","",this);
 
            CodLanguagePrint = RPSControlFactory.CreateRPSComboBox<ChecksChildDialogView>("c0947dfa-9853-4261-9652-bfd242f25d3f","","",false, this);
 
            Draft = RPSControlFactory.CreateRPSOption<ChecksChildDialogView>( "4c24bc6e-5d04-4d49-b6fe-4ea1d1e51193","","",this);
 
            Company = RPSControlFactory.CreateRPSOption<ChecksChildDialogView>( "594b4f89-fbf6-471a-ab0f-a294e4b0ba80","","",this);
 
            IDACCTransactionsResult = RPSControlFactory.CreateRPSComboBox<ChecksChildDialogView>("c293e75c-01b5-40c9-8c0e-b035b2511241","","",false, this);
 
            CollectionInit params_GetCheckForGroup = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c9c1cb1e-eae5-4fc1-bcc4-922f272ef132",CSSSelectorGrid="",XPathGrid=""};
            GetCheckForGroup = RPSControlFactory.RPSCreateCollectionWithGrid<GetCheckForGroupCollectionEditor<ChecksChildDialogView>,ChecksChildDialogView>( params_GetCheckForGroup,this);
 
            CollectionInit params_ResultCollection = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="e643c9da-2838-404f-ad47-009cacdb6fdd",CSSSelectorGrid="",XPathGrid=""};
            ResultCollection = RPSControlFactory.RPSCreateCollectionWithGrid<ResultCollectionCollectionEditor<ChecksChildDialogView>,ChecksChildDialogView>( params_ResultCollection,this);
 

        }
        public IRPSOption<ChecksChildDialogView> Check { get; set; } 
        public IRPSOption<ChecksChildDialogView> PromissoryNote { get; set; } 
        public IRPSComboBox<ChecksChildDialogView> IDBankAccountCompany { get; set; } 
        public IRPSComboBox<ChecksChildDialogView> IDCodingSeriesCheck { get; set; } 
        public IRPSComboBox<ChecksChildDialogView> IDCodingSeriesPromissoryNote { get; set; } 
        public IRPSComboBox<ChecksChildDialogView> IDPaymentType { get; set; } 
        public IRPSComboBox<ChecksChildDialogView> IDPaymentStatus { get; set; } 
        public IRPSTextBox<ChecksChildDialogView> AccountingDate { get; set; } 
        public IRPSTextBox<ChecksChildDialogView> CheckDate { get; set; } 
        public IRPSOption<ChecksChildDialogView> FixedDate { get; set; } 
        public IRPSTextBox<ChecksChildDialogView> DocumentDueDateFixed { get; set; } 
        public IRPSOption<ChecksChildDialogView> MaxDate { get; set; } 
        public IRPSCheckbox<ChecksChildDialogView> bGroup { get; set; } 
        public IRPSCheckbox<ChecksChildDialogView> bGroup1 { get; set; } 
        public IRPSTextBox<ChecksChildDialogView> Place { get; set; } 
        public IRPSOption<ChecksChildDialogView> Nothing { get; set; } 
        public IRPSOption<ChecksChildDialogView> OnlyCheckOne { get; set; } 
        public IRPSOption<ChecksChildDialogView> OnlyCheckMult { get; set; } 
        public IRPSOption<ChecksChildDialogView> CheckWithletter { get; set; } 
        public IRPSOption<ChecksChildDialogView> UseBank { get; set; } 
        public IRPSOption<ChecksChildDialogView> OtherReport { get; set; } 
        public IRPSComboBox<ChecksChildDialogView> CodCustomReportCheck { get; set; } 
        public IRPSComboBox<ChecksChildDialogView> CodCustomReportPrommissoryNote { get; set; } 
        public IRPSOption<ChecksChildDialogView> LanguageThird { get; set; } 
        public IRPSOption<ChecksChildDialogView> OtherLanguage { get; set; } 
        public IRPSComboBox<ChecksChildDialogView> CodLanguagePrint { get; set; } 
        public IRPSOption<ChecksChildDialogView> Draft { get; set; } 
        public IRPSOption<ChecksChildDialogView> Company { get; set; } 
        public IRPSComboBox<ChecksChildDialogView> IDACCTransactionsResult { get; set; } 
        public GetCheckForGroupCollectionEditor<ChecksChildDialogView> GetCheckForGroup { get; set; } 
        public ResultCollectionCollectionEditor<ChecksChildDialogView> ResultCollection { get; set; } 
        public DraftsQueryManagement Screen { get; set; }
        public ChecksChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetCheckForGroupCollectionEditor<ChecksChildDialogView>:RPSCollectionEditor<ChecksChildDialogView> where ChecksChildDialogView : class, IView
    {
        public  GetCheckForGroupGridView<ChecksChildDialogView> GridView {get;set;}
    }
    public partial class GetCheckForGroupGridView <ChecksChildDialogView> :  RPSGridView<ChecksChildDialogView> where ChecksChildDialogView : class, IView
    {
        public GetCheckForGroupGridView(ChecksChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Group = RPSControlFactory.CreateRPSGridTextBox<ChecksChildDialogView>("","#c9c1cb1e-eae5-4fc1-bcc4-922f272ef132 .ag-row[role='row']@ROWINDEX [col-id='cGroup']","",false, this.CurrentView);
 
            CustomerSupplier = RPSControlFactory.CreateRPSGridTextBox<ChecksChildDialogView>("","#c9c1cb1e-eae5-4fc1-bcc4-922f272ef132 .ag-row[role='row']@ROWINDEX [col-id='cCustomerSupplier']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ChecksChildDialogView> Group { get; set; } 
        public IRPSGridTextBox<ChecksChildDialogView> CustomerSupplier { get; set; } 
                     
    }
 
        public partial class ResultCollectionCollectionEditor<ChecksChildDialogView>:RPSCollectionEditor<ChecksChildDialogView> where ChecksChildDialogView : class, IView
    {
        public  ResultCollectionGridView<ChecksChildDialogView> GridView {get;set;}
    }
    public partial class ResultCollectionGridView <ChecksChildDialogView> :  RPSGridView<ChecksChildDialogView> where ChecksChildDialogView : class, IView
    {
        public ResultCollectionGridView(ChecksChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CheckDate = RPSControlFactory.CreateRPSGridTextBox<ChecksChildDialogView>("","#e643c9da-2838-404f-ad47-009cacdb6fdd .ag-row[role='row']@ROWINDEX [col-id='cCheckDate']","",false, this.CurrentView);
 
            CheckNumber = RPSControlFactory.CreateRPSGridTextBox<ChecksChildDialogView>("","#e643c9da-2838-404f-ad47-009cacdb6fdd .ag-row[role='row']@ROWINDEX [col-id='cCheckNumber']","",false, this.CurrentView);
 
            IDThird = RPSControlFactory.CreateRPSGridComboBox<ChecksChildDialogView>("","#e643c9da-2838-404f-ad47-009cacdb6fdd .ag-row[role='row']@ROWINDEX [col-id='cIDThird']","",false, this.CurrentView);
 
            AmountCurrency = RPSControlFactory.CreateRPSGridFormattedTextBox<ChecksChildDialogView>("","#e643c9da-2838-404f-ad47-009cacdb6fdd .ag-row[role='row']@ROWINDEX [col-id='cAmountCurrency']","",false, this.CurrentView);
 
            DocumentDueDate = RPSControlFactory.CreateRPSGridTextBox<ChecksChildDialogView>("","#e643c9da-2838-404f-ad47-009cacdb6fdd .ag-row[role='row']@ROWINDEX [col-id='cDocumentDueDate']","",false, this.CurrentView);
 
            Group = RPSControlFactory.CreateRPSGridTextBox<ChecksChildDialogView>("","#e643c9da-2838-404f-ad47-009cacdb6fdd .ag-row[role='row']@ROWINDEX [col-id='cGroup']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ChecksChildDialogView> CheckDate { get; set; } 
        public IRPSGridTextBox<ChecksChildDialogView> CheckNumber { get; set; } 
        public IRPSGridComboBox<ChecksChildDialogView> IDThird { get; set; } 
        public IRPSGridTextBox<ChecksChildDialogView> AmountCurrency { get; set; } 
        public IRPSGridTextBox<ChecksChildDialogView> DocumentDueDate { get; set; } 
        public IRPSGridTextBox<ChecksChildDialogView> Group { get; set; } 
                     
    }
 
    }
  
            
    public partial class DraftRelationGenerationChildDialogView : View
    {
        public DraftRelationGenerationChildDialogView(DraftsQueryManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<DraftRelationGenerationChildDialogView>("d7f835cd-22af-45d3-847b-0e879f779fff","","",false, this);
 
            AmountCurrency = RPSControlFactory.CreateRPSFormattedTextBox<DraftRelationGenerationChildDialogView>("c5e5c525-6647-4b79-a8c3-42dd7783e584","","",false, this);
 
            IDCashCollector = RPSControlFactory.CreateRPSComboBox<DraftRelationGenerationChildDialogView>("37af0eed-108f-4b2b-a603-28a40fedd7ff","","",true, this);
 
            SentNumber = RPSControlFactory.CreateRPSFormattedTextBox<DraftRelationGenerationChildDialogView>("2b335b22-12aa-45e5-9a3b-70a89f2c0c68","","",false, this);
 
            SentDate = RPSControlFactory.CreateRPSTextBox<DraftRelationGenerationChildDialogView>("b77c3417-3f8e-4e0d-9d73-c819fc1e229f","","",true, this);
 
            IDPaymentStatusTo = RPSControlFactory.CreateRPSComboBox<DraftRelationGenerationChildDialogView>("77cfff98-fdad-404f-8c49-e7bc65e983c4","","",true, this);
 
            AccountingDate = RPSControlFactory.CreateRPSTextBox<DraftRelationGenerationChildDialogView>("241a5353-1ef8-4943-8915-1bbbebd5f66b","","",true, this);
 

        }
        public IRPSTextBox<DraftRelationGenerationChildDialogView> Amount { get; set; } 
        public IRPSTextBox<DraftRelationGenerationChildDialogView> AmountCurrency { get; set; } 
        public IRPSComboBox<DraftRelationGenerationChildDialogView> IDCashCollector { get; set; } 
        public IRPSTextBox<DraftRelationGenerationChildDialogView> SentNumber { get; set; } 
        public IRPSTextBox<DraftRelationGenerationChildDialogView> SentDate { get; set; } 
        public IRPSComboBox<DraftRelationGenerationChildDialogView> IDPaymentStatusTo { get; set; } 
        public IRPSTextBox<DraftRelationGenerationChildDialogView> AccountingDate { get; set; } 
        public DraftsQueryManagement Screen { get; set; }
        public DraftRelationGenerationChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class GenerateFileChildDialogView : View
    {
        public GenerateFileChildDialogView(DraftsQueryManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            MensBank = RPSControlFactory.CreateRPSTextBox<GenerateFileChildDialogView>("60c93780-dddd-4e6b-aa10-53b3ed3ae856","","",false, this);
 
            eCustomerSupplier = RPSControlFactory.CreateRPSEnumComboBox<GenerateFileChildDialogView>("4d1f4983-9ac1-4ebf-b919-1f0dc820671d","","",false, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<GenerateFileChildDialogView>("edd51df9-abcb-418d-8885-014a7e73bd1f","","",false, this);
 
            IDBankAccountCompany = RPSControlFactory.CreateRPSComboBox<GenerateFileChildDialogView>("9fa30e11-38b7-4b76-9461-730ceb4bb0ed","","",true, this);
 
            BankRule = RPSControlFactory.CreateRPSEnumComboBox<GenerateFileChildDialogView>("5149182f-4bd9-47c7-931c-e074b73e6ddb","","",true, this);
 
            BankRuleName = RPSControlFactory.CreateRPSTextBox<GenerateFileChildDialogView>("a517669f-ad62-4062-88e5-19b4c008c147","","",false, this);
 
            GenerateFileDate = RPSControlFactory.CreateRPSTextBox<GenerateFileChildDialogView>("a20217be-6a7d-4afa-b999-1c2eab96579c","","",true, this);
 
            MensCurrencies = RPSControlFactory.CreateRPSTextBox<GenerateFileChildDialogView>("71125f2b-403b-47f4-beda-37758b8d5f33","","",false, this);
 
            IDPaymentStatus = RPSControlFactory.CreateRPSComboBox<GenerateFileChildDialogView>("7a3b6037-bacc-4f03-9382-3da5aa950f8e","","",false, this);
 
            AccountingDate = RPSControlFactory.CreateRPSTextBox<GenerateFileChildDialogView>("52ec7da9-5316-4f3b-92ee-b96761b5ebd0","","",true, this);
 
            CSBGroupByThrid = RPSControlFactory.CreateRPSCheckBox<GenerateFileChildDialogView>("540fecff-19d1-4e1b-9c33-632e9fb36a9a","","",false, this);
 
            Requester = RPSControlFactory.CreateRPSOption<GenerateFileChildDialogView>( "a024e163-738a-4a40-81ac-c4dd5e49f7bd","","",this);
 
            Payee = RPSControlFactory.CreateRPSOption<GenerateFileChildDialogView>( "f0d011ce-6bfd-4c01-b0b6-797de1903588","","",this);
 
            BankTransfer = RPSControlFactory.CreateRPSOption<GenerateFileChildDialogView>( "f07af396-194f-4266-b85a-072200288e00","","",this);
 
            BankCheck = RPSControlFactory.CreateRPSOption<GenerateFileChildDialogView>( "19827a09-05b8-470b-bddd-22bf529c2c14","","",this);
 
            CSBSufijoOrdenante341String = RPSControlFactory.CreateRPSTextBox<GenerateFileChildDialogView>("69e95e6f-edb0-45de-afd3-9dd16e860d40","","",false, this);
 
            Shared = RPSControlFactory.CreateRPSOption<GenerateFileChildDialogView>( "19f5f982-e519-47db-90e8-a9db754fc6b1","","",this);
 
            Requester1 = RPSControlFactory.CreateRPSOption<GenerateFileChildDialogView>( "a424b978-9fb0-45a9-a892-a1296fff6550","","",this);
 
            Payee1 = RPSControlFactory.CreateRPSOption<GenerateFileChildDialogView>( "3b4fddc7-7150-420f-bb55-869bdb31d66d","","",this);
 
            BankTransfer1 = RPSControlFactory.CreateRPSOption<GenerateFileChildDialogView>( "3efa5e5a-d898-484c-af94-a3c394024e9b","","",this);
 
            BankTransferNotDirect = RPSControlFactory.CreateRPSOption<GenerateFileChildDialogView>( "f1de480c-c97a-404e-be27-8f5bc1069c5e","","",this);
 
            BankCheck1 = RPSControlFactory.CreateRPSOption<GenerateFileChildDialogView>( "575b97af-f4be-408f-ba96-3cf4c402614d","","",this);
 
            CSBGroupByThrid1 = RPSControlFactory.CreateRPSCheckBox<GenerateFileChildDialogView>("f4e8a3e8-887b-4400-86c1-2ef71eb84ba4","","",false, this);
 
            CSB68Concept = RPSControlFactory.CreateRPSTextBox<GenerateFileChildDialogView>("a41e3918-aab2-412f-a63c-cd92cb2ec3e1","","",false, this);
 
            CSBSufijoOrdenante = RPSControlFactory.CreateRPSFormattedTextBox<GenerateFileChildDialogView>("b9b47b84-8bcb-4791-8a1c-b2d28ec0845e","","",false, this);
 
            GenerateFileTextChildNavigationCommand = RPSControlFactory.CreateRPSButtonToView<GenerateFileChildDialogView,GenerateFileTextChildDialogView>("bffed354-1014-49c8-b1a3-0fd7c7ad08a1","","", this,Screen.GenerateFileTextChildDialogView);
 
            CSBSufijoPresentador = RPSControlFactory.CreateRPSFormattedTextBox<GenerateFileChildDialogView>("2bbafd82-7911-4535-8d5f-df9d3332010d","","",false, this);
 
            Name = RPSControlFactory.CreateRPSTextBox<GenerateFileChildDialogView>("14a800d4-ac48-4bb2-877d-a49627f2f59f","","",false, this);
 
            VatNumber = RPSControlFactory.CreateRPSTextBox<GenerateFileChildDialogView>("7ba40b26-f899-47a7-9560-5cdef7a61e8a","","",false, this);
 
            CSBSufijoOrdenante1 = RPSControlFactory.CreateRPSFormattedTextBox<GenerateFileChildDialogView>("258057bc-abb8-4a6c-92d9-416565273abc","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<GenerateFileChildDialogView>("783bde14-ae64-455c-a576-d074825513c6","","",true, this);
 
            County = RPSControlFactory.CreateRPSComboBox<GenerateFileChildDialogView>("05b9ea50-38ef-4dc1-bf11-a965059f7966","","",false, this);
 
            GrantorNo = RPSControlFactory.CreateRPSTextBox<GenerateFileChildDialogView>("a742526b-4597-48dd-8ed1-cc1f1a9d0637","","",true, this);
 
            CheckDocuments = RPSControlFactory.CreateRPSCheckBox<GenerateFileChildDialogView>("08f99abb-3e54-40ab-9efc-6a26e2bd596b","","",false, this);
 
            BollOfExchange = RPSControlFactory.CreateRPSOption<GenerateFileChildDialogView>( "0ff7b283-9a21-4a6e-a9cf-b4667a828527","","",this);
 
            Receipt = RPSControlFactory.CreateRPSOption<GenerateFileChildDialogView>( "b6fa66d4-c523-439a-b905-6d877b8911ce","","",this);
 
            PromissoryNote = RPSControlFactory.CreateRPSOption<GenerateFileChildDialogView>( "627b2fe3-c2f8-4325-9f1f-a6d3129696e4","","",this);
 
            NotaryProtest = RPSControlFactory.CreateRPSOption<GenerateFileChildDialogView>( "d939b91c-a2ea-45f3-b468-18f565f305d6","","",this);
 
            WithExpenses = RPSControlFactory.CreateRPSOption<GenerateFileChildDialogView>( "4b8db27d-dc7a-428a-98b2-e02eca4a3042","","",this);
 
            WithoutExpenses = RPSControlFactory.CreateRPSOption<GenerateFileChildDialogView>( "9c127447-bd9c-4cdc-9584-a5a20a2c44b0","","",this);
 
            Accepted = RPSControlFactory.CreateRPSOption<GenerateFileChildDialogView>( "dbb1cbc2-ed68-450d-a279-0fee86afccf4","","",this);
 
            NotAccepted = RPSControlFactory.CreateRPSOption<GenerateFileChildDialogView>( "2574975d-8166-4557-9bd0-4aafc0095992","","",this);
 
            GenerateFileOptionalDataChildNavigationCommand = RPSControlFactory.CreateRPSButtonToView<GenerateFileChildDialogView,GenerateFileOptionalDataChildDialogView>("d9b1b6e8-98e7-48b4-a598-4415d3ef4b31","","", this,Screen.GenerateFileOptionalDataChildDialogView);
 
            GenerateFileTextChildNavigationCommand1 = RPSControlFactory.CreateRPSButtonToView<GenerateFileChildDialogView,GenerateFileTextChildDialogView>("def067d0-bdec-4816-a70f-a60fc1b27e32","","", this,Screen.GenerateFileTextChildDialogView);
 
            CSBSufijoPresentador1 = RPSControlFactory.CreateRPSFormattedTextBox<GenerateFileChildDialogView>("adb6b540-bd93-4dd0-8493-aa91cba4adce","","",false, this);
 
            VatNumber1 = RPSControlFactory.CreateRPSTextBox<GenerateFileChildDialogView>("73a90084-0acc-4bb7-af4e-e037b48c6ee0","","",false, this);
 
            Name1 = RPSControlFactory.CreateRPSTextBox<GenerateFileChildDialogView>("daae4ca1-6739-469f-bedb-64af295c88aa","","",false, this);
 
            CSBSufijoOrdenante2 = RPSControlFactory.CreateRPSFormattedTextBox<GenerateFileChildDialogView>("2f7edd76-8849-4a3d-97b6-7c45da043f8a","","",false, this);
 
            Alphanumeric = RPSControlFactory.CreateRPSTextBox<GenerateFileChildDialogView>("b798227d-f6db-44bc-9ac4-08f0810394ea","","",false, this);
 
            City1 = RPSControlFactory.CreateRPSTextBox<GenerateFileChildDialogView>("58c636dd-8fa1-4215-b274-f2f0cba3215b","","",true, this);
 
            County1 = RPSControlFactory.CreateRPSComboBox<GenerateFileChildDialogView>("5092324a-991b-42ad-bec2-55eb9c6421a5","","",false, this);
 
            DueDate = RPSControlFactory.CreateRPSOption<GenerateFileChildDialogView>( "87483617-d1c5-4e01-9e3b-6f339c53ab3b","","",this);
 
            CollectionDate = RPSControlFactory.CreateRPSOption<GenerateFileChildDialogView>( "31749cd3-f368-4b5f-933d-fd49206e6d0a","","",this);
 
            SEPAPaymentDate = RPSControlFactory.CreateRPSTextBox<GenerateFileChildDialogView>("e6ca87c4-e9ed-4244-bed6-e206ad1cf6b1","","",false, this);
 
            CreditorSuffix = RPSControlFactory.CreateRPSTextBox<GenerateFileChildDialogView>("719e7717-cc93-489f-b33b-59d4f92cdec4","","",false, this);
 
            SEPACreditorIdentifier = RPSControlFactory.CreateRPSTextBox<GenerateFileChildDialogView>("936b5c69-bdbb-47aa-a8fe-d8adce2d4b4a","","",false, this);
 
            SEPASuffix = RPSControlFactory.CreateRPSTextBox<GenerateFileChildDialogView>("38ba72e8-7631-4816-82c9-d2e84cdb225e","","",true, this);
 
            SEPAVATNumber = RPSControlFactory.CreateRPSTextBox<GenerateFileChildDialogView>("152c96f7-4395-4bd9-9413-9c46790d1bdb","","",true, this);
 
            SEPAName = RPSControlFactory.CreateRPSTextBox<GenerateFileChildDialogView>("034e9012-7320-4bc1-bc40-d8864bb911e2","","",true, this);
 
            NotDetailed = RPSControlFactory.CreateRPSOption<GenerateFileChildDialogView>( "c71aa2ad-58ef-45a2-8ed2-6b56c8bbf3f1","","",this);
 
            Detailed = RPSControlFactory.CreateRPSOption<GenerateFileChildDialogView>( "3fba99b3-8c47-49a1-9208-46cd28c480a0","","",this);
 
            SEPAIDMessage = RPSControlFactory.CreateRPSComboBox<GenerateFileChildDialogView>("19293d7e-a4f1-441b-8b66-ce726f7d916a","","",true, this);
 
            SEPAIDPayment = RPSControlFactory.CreateRPSComboBox<GenerateFileChildDialogView>("111dfda2-da62-4afd-8c01-6866ef275621","","",true, this);
 
            bPrintDD = RPSControlFactory.CreateRPSCheckBox<GenerateFileChildDialogView>("437d8d28-8c68-41c2-be56-77ecda752771","","",false, this);
 
            DueDate1 = RPSControlFactory.CreateRPSOption<GenerateFileChildDialogView>( "a88233e0-1917-4161-8c91-358628c36268","","",this);
 
            CollectionDate1 = RPSControlFactory.CreateRPSOption<GenerateFileChildDialogView>( "d3f1e275-a5fb-41b0-a930-48f189e0f603","","",this);
 
            SEPAPaymentDate1 = RPSControlFactory.CreateRPSTextBox<GenerateFileChildDialogView>("daf42c3b-183e-4382-97cc-4efb80153b93","","",false, this);
 
            SEPASuffix1 = RPSControlFactory.CreateRPSTextBox<GenerateFileChildDialogView>("046726bf-762c-421d-9375-702bbc896865","","",true, this);
 
            SEPAVATNumber1 = RPSControlFactory.CreateRPSTextBox<GenerateFileChildDialogView>("46b6c7dd-20c0-44f2-847b-13ba16166a35","","",true, this);
 
            SEPAName1 = RPSControlFactory.CreateRPSTextBox<GenerateFileChildDialogView>("19c238c9-2900-4b52-afc9-c4a9b1dd6441","","",true, this);
 
            NotDetailed1 = RPSControlFactory.CreateRPSOption<GenerateFileChildDialogView>( "4132f05f-b926-41a2-9c00-ab0751e64e99","","",this);
 
            Detailed1 = RPSControlFactory.CreateRPSOption<GenerateFileChildDialogView>( "d0fac83c-47f9-4aeb-ba61-6ebf03915cb7","","",this);
 
            SEPAIDMessage1 = RPSControlFactory.CreateRPSComboBox<GenerateFileChildDialogView>("e64939d2-c6d8-4e55-a00c-92954a477fbf","","",true, this);
 
            SEPAIDPayment1 = RPSControlFactory.CreateRPSComboBox<GenerateFileChildDialogView>("7427184b-8abc-4454-9767-20c40153ec39","","",true, this);
 
            Transfer = RPSControlFactory.CreateRPSOption<GenerateFileChildDialogView>( "6f0e581f-c161-475a-b62b-8d4bd11f5a78","","",this);
 
            OtherTransfer = RPSControlFactory.CreateRPSOption<GenerateFileChildDialogView>( "ada7650e-7b3d-403d-a76b-8d83830d790d","","",this);
 
            Check = RPSControlFactory.CreateRPSOption<GenerateFileChildDialogView>( "bc2c7ee4-4f71-43b3-a887-682a2987afc4","","",this);
 
            Roster = RPSControlFactory.CreateRPSOption<GenerateFileChildDialogView>( "629a1ff1-db43-450b-919c-3d67484a376f","","",this);
 
            Pension = RPSControlFactory.CreateRPSOption<GenerateFileChildDialogView>( "a6e0253c-176e-46f8-8f42-8612b60bb087","","",this);
 
            Other = RPSControlFactory.CreateRPSOption<GenerateFileChildDialogView>( "e63caac5-7e09-433d-b538-1646aab2c6eb","","",this);
 
            Supplier = RPSControlFactory.CreateRPSOption<GenerateFileChildDialogView>( "1e9467e0-f839-4010-bbb4-43e12e3ec727","","",this);
 
            RealOther = RPSControlFactory.CreateRPSOption<GenerateFileChildDialogView>( "83fbb3e0-3de7-4e1d-8515-201cab462154","","",this);
 
            Payer = RPSControlFactory.CreateRPSOption<GenerateFileChildDialogView>( "c50c4c96-9ce6-4a23-9c21-95910281d225","","",this);
 
            Beneficiary = RPSControlFactory.CreateRPSOption<GenerateFileChildDialogView>( "c33893b1-7216-4e21-8010-8b61460f2be9","","",this);
 
            Shared1 = RPSControlFactory.CreateRPSOption<GenerateFileChildDialogView>( "59f0baa3-779b-4206-aa55-cfc5ede201b7","","",this);
 
            bPrintCT = RPSControlFactory.CreateRPSCheckBox<GenerateFileChildDialogView>("0c592eec-2414-4220-a401-7e0cab94e7fa","","",false, this);
 
            CustomReportAR = RPSControlFactory.CreateRPSEnumComboBox<GenerateFileChildDialogView>("5e9c0e31-a749-43f8-beeb-8220157b71b6","","",false, this);
 
            CustomReportAP = RPSControlFactory.CreateRPSEnumComboBox<GenerateFileChildDialogView>("3bd1165d-ca60-44b1-bcb6-847a518f137a","","",false, this);
 
            OptionThirdLanguage = RPSControlFactory.CreateRPSOption<GenerateFileChildDialogView>( "6b8437b3-c408-4360-a93e-652142875415","","",this);
 
            OtherLanguage = RPSControlFactory.CreateRPSOption<GenerateFileChildDialogView>( "f7b45c7c-3a73-4e28-9d05-c716cf6e1a42","","",this);
 
            CodOtherLanguage = RPSControlFactory.CreateRPSComboBox<GenerateFileChildDialogView>("555965d2-63c8-4308-8e3e-2cc9a910e248","","",false, this);
 
            screen = RPSControlFactory.CreateRPSOption<GenerateFileChildDialogView>( "34a2ee34-2326-4aed-ac82-ec42c5905f29","","",this);
 
            mail = RPSControlFactory.CreateRPSOption<GenerateFileChildDialogView>( "69b3eeb3-bd28-47b3-b010-eaed270cdef3","","",this);
 
            MyEmail = RPSControlFactory.CreateRPSCheckBox<GenerateFileChildDialogView>("bf6e9125-1038-47cf-9cce-2404bfbab0de","","",false, this);
 
            BankRuleName1 = RPSControlFactory.CreateRPSTextBox<GenerateFileChildDialogView>("f799bcac-9634-44c0-a34c-2a8ab1a895ca","","",false, this);
 
            PayDate = RPSControlFactory.CreateRPSTextBox<GenerateFileChildDialogView>("36c41e72-d59d-47ed-8d63-2e39ba634ac0","","",false, this);
 
            Value_CONTRATO = RPSControlFactory.CreateRPSTextBox<GenerateFileChildDialogView>("50830063-6434-4f42-a761-fc73ec537d78","","",false, this);
 
            Options_MODALIDAD = RPSControlFactory.CreateRPSEnumComboBox<GenerateFileChildDialogView>("2d599b86-b254-43fb-91ed-223faee640d8","","",false, this);
 
            Value_CLIENTE = RPSControlFactory.CreateRPSTextBox<GenerateFileChildDialogView>("4a89bdf0-6ed0-48f5-811a-2d372f2b6fc2","","",false, this);
 
            Value_N_OPERACION = RPSControlFactory.CreateRPSTextBox<GenerateFileChildDialogView>("634c2e0b-8581-462f-be87-9f3cebbd148e","","",false, this);
 
            Value_MNEMO = RPSControlFactory.CreateRPSTextBox<GenerateFileChildDialogView>("8ab46d4a-f70a-4008-bc34-bb521e021c08","","",false, this);
 
            Value_SUFIJO = RPSControlFactory.CreateRPSTextBox<GenerateFileChildDialogView>("b1241759-6a6e-406a-958c-6fae27ea09e2","","",false, this);
 
            Options_TIPO_LOTE = RPSControlFactory.CreateRPSEnumComboBox<GenerateFileChildDialogView>("b9d59957-43de-4257-83a8-7b466f22769f","","",false, this);
 
            Options_FORMA_ENVIO = RPSControlFactory.CreateRPSEnumComboBox<GenerateFileChildDialogView>("94283ce7-d6fb-45bc-b1d4-efd01f219800","","",false, this);
 
            Options_TIPO_ENVIO = RPSControlFactory.CreateRPSEnumComboBox<GenerateFileChildDialogView>("e3ac2901-ad5a-4db1-afe1-a86ff25354d3","","",false, this);
 
            GenerationErrorResult = RPSControlFactory.CreateRPSTextBox<GenerateFileChildDialogView>("e902a5e1-8e5e-4511-9cd3-c1cf3e6ae510","","",false, this);
 
            SpecificValuesErrorMsg = RPSControlFactory.CreateRPSTextBox<GenerateFileChildDialogView>("00397a32-27a4-4906-9f84-86ae43fcb606","","",false, this);
 
            IDACCTransactionsResult = RPSControlFactory.CreateRPSComboBox<GenerateFileChildDialogView>("4f29315f-35d9-459a-a47e-7c6afb59abed","","",false, this);
 

        }
        public IRPSTextBox<GenerateFileChildDialogView> MensBank { get; set; } 
        public IRPSComboBox<GenerateFileChildDialogView> eCustomerSupplier { get; set; } 
        public IRPSTextBox<GenerateFileChildDialogView> Amount { get; set; } 
        public IRPSComboBox<GenerateFileChildDialogView> IDBankAccountCompany { get; set; } 
        public IRPSComboBox<GenerateFileChildDialogView> BankRule { get; set; } 
        public IRPSTextBox<GenerateFileChildDialogView> BankRuleName { get; set; } 
        public IRPSTextBox<GenerateFileChildDialogView> GenerateFileDate { get; set; } 
        public IRPSTextBox<GenerateFileChildDialogView> MensCurrencies { get; set; } 
        public IRPSComboBox<GenerateFileChildDialogView> IDPaymentStatus { get; set; } 
        public IRPSTextBox<GenerateFileChildDialogView> AccountingDate { get; set; } 
        public IRPSCheckbox<GenerateFileChildDialogView> CSBGroupByThrid { get; set; } 
        public IRPSOption<GenerateFileChildDialogView> Requester { get; set; } 
        public IRPSOption<GenerateFileChildDialogView> Payee { get; set; } 
        public IRPSOption<GenerateFileChildDialogView> BankTransfer { get; set; } 
        public IRPSOption<GenerateFileChildDialogView> BankCheck { get; set; } 
        public IRPSTextBox<GenerateFileChildDialogView> CSBSufijoOrdenante341String { get; set; } 
        public IRPSOption<GenerateFileChildDialogView> Shared { get; set; } 
        public IRPSOption<GenerateFileChildDialogView> Requester1 { get; set; } 
        public IRPSOption<GenerateFileChildDialogView> Payee1 { get; set; } 
        public IRPSOption<GenerateFileChildDialogView> BankTransfer1 { get; set; } 
        public IRPSOption<GenerateFileChildDialogView> BankTransferNotDirect { get; set; } 
        public IRPSOption<GenerateFileChildDialogView> BankCheck1 { get; set; } 
        public IRPSCheckbox<GenerateFileChildDialogView> CSBGroupByThrid1 { get; set; } 
        public IRPSTextBox<GenerateFileChildDialogView> CSB68Concept { get; set; } 
        public IRPSTextBox<GenerateFileChildDialogView> CSBSufijoOrdenante { get; set; } 
        public IRPSButton<GenerateFileChildDialogView,GenerateFileTextChildDialogView> GenerateFileTextChildNavigationCommand { get; set; } 
        public IRPSTextBox<GenerateFileChildDialogView> CSBSufijoPresentador { get; set; } 
        public IRPSTextBox<GenerateFileChildDialogView> Name { get; set; } 
        public IRPSTextBox<GenerateFileChildDialogView> VatNumber { get; set; } 
        public IRPSTextBox<GenerateFileChildDialogView> CSBSufijoOrdenante1 { get; set; } 
        public IRPSTextBox<GenerateFileChildDialogView> City { get; set; } 
        public IRPSComboBox<GenerateFileChildDialogView> County { get; set; } 
        public IRPSTextBox<GenerateFileChildDialogView> GrantorNo { get; set; } 
        public IRPSCheckbox<GenerateFileChildDialogView> CheckDocuments { get; set; } 
        public IRPSOption<GenerateFileChildDialogView> BollOfExchange { get; set; } 
        public IRPSOption<GenerateFileChildDialogView> Receipt { get; set; } 
        public IRPSOption<GenerateFileChildDialogView> PromissoryNote { get; set; } 
        public IRPSOption<GenerateFileChildDialogView> NotaryProtest { get; set; } 
        public IRPSOption<GenerateFileChildDialogView> WithExpenses { get; set; } 
        public IRPSOption<GenerateFileChildDialogView> WithoutExpenses { get; set; } 
        public IRPSOption<GenerateFileChildDialogView> Accepted { get; set; } 
        public IRPSOption<GenerateFileChildDialogView> NotAccepted { get; set; } 
        public IRPSButton<GenerateFileChildDialogView,GenerateFileOptionalDataChildDialogView> GenerateFileOptionalDataChildNavigationCommand { get; set; } 
        public IRPSButton<GenerateFileChildDialogView,GenerateFileTextChildDialogView> GenerateFileTextChildNavigationCommand1 { get; set; } 
        public IRPSTextBox<GenerateFileChildDialogView> CSBSufijoPresentador1 { get; set; } 
        public IRPSTextBox<GenerateFileChildDialogView> VatNumber1 { get; set; } 
        public IRPSTextBox<GenerateFileChildDialogView> Name1 { get; set; } 
        public IRPSTextBox<GenerateFileChildDialogView> CSBSufijoOrdenante2 { get; set; } 
        public IRPSTextBox<GenerateFileChildDialogView> Alphanumeric { get; set; } 
        public IRPSTextBox<GenerateFileChildDialogView> City1 { get; set; } 
        public IRPSComboBox<GenerateFileChildDialogView> County1 { get; set; } 
        public IRPSOption<GenerateFileChildDialogView> DueDate { get; set; } 
        public IRPSOption<GenerateFileChildDialogView> CollectionDate { get; set; } 
        public IRPSTextBox<GenerateFileChildDialogView> SEPAPaymentDate { get; set; } 
        public IRPSTextBox<GenerateFileChildDialogView> CreditorSuffix { get; set; } 
        public IRPSTextBox<GenerateFileChildDialogView> SEPACreditorIdentifier { get; set; } 
        public IRPSTextBox<GenerateFileChildDialogView> SEPASuffix { get; set; } 
        public IRPSTextBox<GenerateFileChildDialogView> SEPAVATNumber { get; set; } 
        public IRPSTextBox<GenerateFileChildDialogView> SEPAName { get; set; } 
        public IRPSOption<GenerateFileChildDialogView> NotDetailed { get; set; } 
        public IRPSOption<GenerateFileChildDialogView> Detailed { get; set; } 
        public IRPSComboBox<GenerateFileChildDialogView> SEPAIDMessage { get; set; } 
        public IRPSComboBox<GenerateFileChildDialogView> SEPAIDPayment { get; set; } 
        public IRPSCheckbox<GenerateFileChildDialogView> bPrintDD { get; set; } 
        public IRPSOption<GenerateFileChildDialogView> DueDate1 { get; set; } 
        public IRPSOption<GenerateFileChildDialogView> CollectionDate1 { get; set; } 
        public IRPSTextBox<GenerateFileChildDialogView> SEPAPaymentDate1 { get; set; } 
        public IRPSTextBox<GenerateFileChildDialogView> SEPASuffix1 { get; set; } 
        public IRPSTextBox<GenerateFileChildDialogView> SEPAVATNumber1 { get; set; } 
        public IRPSTextBox<GenerateFileChildDialogView> SEPAName1 { get; set; } 
        public IRPSOption<GenerateFileChildDialogView> NotDetailed1 { get; set; } 
        public IRPSOption<GenerateFileChildDialogView> Detailed1 { get; set; } 
        public IRPSComboBox<GenerateFileChildDialogView> SEPAIDMessage1 { get; set; } 
        public IRPSComboBox<GenerateFileChildDialogView> SEPAIDPayment1 { get; set; } 
        public IRPSOption<GenerateFileChildDialogView> Transfer { get; set; } 
        public IRPSOption<GenerateFileChildDialogView> OtherTransfer { get; set; } 
        public IRPSOption<GenerateFileChildDialogView> Check { get; set; } 
        public IRPSOption<GenerateFileChildDialogView> Roster { get; set; } 
        public IRPSOption<GenerateFileChildDialogView> Pension { get; set; } 
        public IRPSOption<GenerateFileChildDialogView> Other { get; set; } 
        public IRPSOption<GenerateFileChildDialogView> Supplier { get; set; } 
        public IRPSOption<GenerateFileChildDialogView> RealOther { get; set; } 
        public IRPSOption<GenerateFileChildDialogView> Payer { get; set; } 
        public IRPSOption<GenerateFileChildDialogView> Beneficiary { get; set; } 
        public IRPSOption<GenerateFileChildDialogView> Shared1 { get; set; } 
        public IRPSCheckbox<GenerateFileChildDialogView> bPrintCT { get; set; } 
        public IRPSComboBox<GenerateFileChildDialogView> CustomReportAR { get; set; } 
        public IRPSComboBox<GenerateFileChildDialogView> CustomReportAP { get; set; } 
        public IRPSOption<GenerateFileChildDialogView> OptionThirdLanguage { get; set; } 
        public IRPSOption<GenerateFileChildDialogView> OtherLanguage { get; set; } 
        public IRPSComboBox<GenerateFileChildDialogView> CodOtherLanguage { get; set; } 
        public IRPSOption<GenerateFileChildDialogView> screen { get; set; } 
        public IRPSOption<GenerateFileChildDialogView> mail { get; set; } 
        public IRPSCheckbox<GenerateFileChildDialogView> MyEmail { get; set; } 
        public IRPSTextBox<GenerateFileChildDialogView> BankRuleName1 { get; set; } 
        public IRPSTextBox<GenerateFileChildDialogView> PayDate { get; set; } 
        public IRPSTextBox<GenerateFileChildDialogView> Value_CONTRATO { get; set; } 
        public IRPSComboBox<GenerateFileChildDialogView> Options_MODALIDAD { get; set; } 
        public IRPSTextBox<GenerateFileChildDialogView> Value_CLIENTE { get; set; } 
        public IRPSTextBox<GenerateFileChildDialogView> Value_N_OPERACION { get; set; } 
        public IRPSTextBox<GenerateFileChildDialogView> Value_MNEMO { get; set; } 
        public IRPSTextBox<GenerateFileChildDialogView> Value_SUFIJO { get; set; } 
        public IRPSComboBox<GenerateFileChildDialogView> Options_TIPO_LOTE { get; set; } 
        public IRPSComboBox<GenerateFileChildDialogView> Options_FORMA_ENVIO { get; set; } 
        public IRPSComboBox<GenerateFileChildDialogView> Options_TIPO_ENVIO { get; set; } 
        public IRPSTextBox<GenerateFileChildDialogView> GenerationErrorResult { get; set; } 
        public IRPSTextBox<GenerateFileChildDialogView> SpecificValuesErrorMsg { get; set; } 
        public IRPSComboBox<GenerateFileChildDialogView> IDACCTransactionsResult { get; set; } 
        public DraftsQueryManagement Screen { get; set; }
        public GenerateFileChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class UnpaidChidDialogView : View
    {
        public UnpaidChidDialogView(DraftsQueryManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            eCustomerSupplier = RPSControlFactory.CreateRPSEnumComboBox<UnpaidChidDialogView>("2f14dc18-b2f9-4dfe-83f1-0052641175de","","",false, this);
 
            TotalAmount = RPSControlFactory.CreateRPSFormattedTextBox<UnpaidChidDialogView>("236d260f-4ef7-4492-ada5-285d66090d1e","","",false, this);
 
            TotalAmountCurrency = RPSControlFactory.CreateRPSFormattedTextBox<UnpaidChidDialogView>("6049768a-289b-4891-a64d-402dbfeeb90d","","",false, this);
 
            AccountingDate = RPSControlFactory.CreateRPSTextBox<UnpaidChidDialogView>("5e40f9a9-326f-4ee6-96be-8ae987699217","","",true, this);
 
            ReturnDate = RPSControlFactory.CreateRPSTextBox<UnpaidChidDialogView>("a1ffa8fe-c75c-4e95-961e-29882e341396","","",true, this);
 
            IDUnpaidCause = RPSControlFactory.CreateRPSComboBox<UnpaidChidDialogView>("6dd95426-f4cc-43f6-8f81-acccc5147b0f","","",true, this);
 
            ReturnExpenses = RPSControlFactory.CreateRPSFormattedTextBox<UnpaidChidDialogView>("c509a182-a3c5-4ea9-ae45-16117e7e191b","","",true, this);
 
            IDPaymentStatusTo = RPSControlFactory.CreateRPSComboBox<UnpaidChidDialogView>("eb37e039-3db9-4e27-8c0e-ecfca4221e69","","",true, this);
 

        }
        public IRPSComboBox<UnpaidChidDialogView> eCustomerSupplier { get; set; } 
        public IRPSTextBox<UnpaidChidDialogView> TotalAmount { get; set; } 
        public IRPSTextBox<UnpaidChidDialogView> TotalAmountCurrency { get; set; } 
        public IRPSTextBox<UnpaidChidDialogView> AccountingDate { get; set; } 
        public IRPSTextBox<UnpaidChidDialogView> ReturnDate { get; set; } 
        public IRPSComboBox<UnpaidChidDialogView> IDUnpaidCause { get; set; } 
        public IRPSTextBox<UnpaidChidDialogView> ReturnExpenses { get; set; } 
        public IRPSComboBox<UnpaidChidDialogView> IDPaymentStatusTo { get; set; } 
        public DraftsQueryManagement Screen { get; set; }
        public UnpaidChidDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ClaimChildDialogView : View
    {
        public ClaimChildDialogView(DraftsQueryManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            AccountingDate = RPSControlFactory.CreateRPSTextBox<ClaimChildDialogView>("667873c0-721d-4b88-9d70-6d2b5b29b4e4","","",true, this);
 
            ClaimDate = RPSControlFactory.CreateRPSTextBox<ClaimChildDialogView>("ef3e81bb-413b-48e1-953a-15216f699769","","",true, this);
 
            IDPaymentStatus = RPSControlFactory.CreateRPSComboBox<ClaimChildDialogView>("b3f9e5c2-fadb-4344-a2b1-95d8faf1f4f9","","",true, this);
 

        }
        public IRPSTextBox<ClaimChildDialogView> AccountingDate { get; set; } 
        public IRPSTextBox<ClaimChildDialogView> ClaimDate { get; set; } 
        public IRPSComboBox<ClaimChildDialogView> IDPaymentStatus { get; set; } 
        public DraftsQueryManagement Screen { get; set; }
        public ClaimChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class GenerateFileOptionalDataChildDialogView : View
    {
        public GenerateFileOptionalDataChildDialogView(DraftsQueryManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SubmittingField1 = RPSControlFactory.CreateRPSTextBox<GenerateFileOptionalDataChildDialogView>("084201ae-b9f7-4288-9b6d-abdbebac2399","","",false, this);
 
            SubmittingField2 = RPSControlFactory.CreateRPSTextBox<GenerateFileOptionalDataChildDialogView>("c534e12e-9adf-41eb-9aaf-4856b8ada220","","",false, this);
 
            SubmittingField3 = RPSControlFactory.CreateRPSTextBox<GenerateFileOptionalDataChildDialogView>("b16404d0-b41f-4516-bb5f-48c70e046f27","","",false, this);
 
            SubmittingField4 = RPSControlFactory.CreateRPSTextBox<GenerateFileOptionalDataChildDialogView>("cfbae6fa-74fb-4cff-8c4c-eff3dad63395","","",false, this);
 
            SubmittingField5 = RPSControlFactory.CreateRPSTextBox<GenerateFileOptionalDataChildDialogView>("a922803e-a7e9-4280-bdef-94605dddbc78","","",false, this);
 
            RequesterField1 = RPSControlFactory.CreateRPSTextBox<GenerateFileOptionalDataChildDialogView>("961bc55a-3bce-4844-8270-f7d9157f5666","","",false, this);
 
            RequesterField2 = RPSControlFactory.CreateRPSTextBox<GenerateFileOptionalDataChildDialogView>("9ab98cbd-556c-421a-b9c2-bd2f867a5d82","","",false, this);
 
            RequesterField3 = RPSControlFactory.CreateRPSTextBox<GenerateFileOptionalDataChildDialogView>("9e7a7a3b-d54f-482f-84bc-63bb548b0432","","",false, this);
 
            RequesterField4 = RPSControlFactory.CreateRPSTextBox<GenerateFileOptionalDataChildDialogView>("a8f44e77-33e2-499b-a87b-79b54bf67381","","",false, this);
 
            RequesterField5 = RPSControlFactory.CreateRPSTextBox<GenerateFileOptionalDataChildDialogView>("af215ab4-c6af-41ac-8d51-9c2a8a926b95","","",false, this);
 

        }
        public IRPSTextBox<GenerateFileOptionalDataChildDialogView> SubmittingField1 { get; set; } 
        public IRPSTextBox<GenerateFileOptionalDataChildDialogView> SubmittingField2 { get; set; } 
        public IRPSTextBox<GenerateFileOptionalDataChildDialogView> SubmittingField3 { get; set; } 
        public IRPSTextBox<GenerateFileOptionalDataChildDialogView> SubmittingField4 { get; set; } 
        public IRPSTextBox<GenerateFileOptionalDataChildDialogView> SubmittingField5 { get; set; } 
        public IRPSTextBox<GenerateFileOptionalDataChildDialogView> RequesterField1 { get; set; } 
        public IRPSTextBox<GenerateFileOptionalDataChildDialogView> RequesterField2 { get; set; } 
        public IRPSTextBox<GenerateFileOptionalDataChildDialogView> RequesterField3 { get; set; } 
        public IRPSTextBox<GenerateFileOptionalDataChildDialogView> RequesterField4 { get; set; } 
        public IRPSTextBox<GenerateFileOptionalDataChildDialogView> RequesterField5 { get; set; } 
        public DraftsQueryManagement Screen { get; set; }
        public GenerateFileOptionalDataChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class GenerateFileTextChildDialogView : View
    {
        public GenerateFileTextChildDialogView(DraftsQueryManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Line2 = RPSControlFactory.CreateRPSTextBox<GenerateFileTextChildDialogView>("92dfe438-e73e-4d7a-b780-da0d647abd37","","",false, this);
 
            Line21 = RPSControlFactory.CreateRPSTextBox<GenerateFileTextChildDialogView>("80f40149-7bf1-44fc-81a0-786f406f678d","","",false, this);
 
            Line3 = RPSControlFactory.CreateRPSTextBox<GenerateFileTextChildDialogView>("b9694d61-f4ff-4417-8934-1a2834126dd4","","",false, this);
 
            Line31 = RPSControlFactory.CreateRPSTextBox<GenerateFileTextChildDialogView>("1117f464-4129-4f37-93a8-2e3acde3fd03","","",false, this);
 
            Line4 = RPSControlFactory.CreateRPSTextBox<GenerateFileTextChildDialogView>("0f6cc62b-c5b4-4a9d-bab1-c78f17715467","","",false, this);
 
            Line41 = RPSControlFactory.CreateRPSTextBox<GenerateFileTextChildDialogView>("f9df7a18-3cb0-4dd4-9d1f-4d8c6d1fdeae","","",false, this);
 
            Line5 = RPSControlFactory.CreateRPSTextBox<GenerateFileTextChildDialogView>("c61dfd85-5b77-4e65-b5e7-448bf72bee87","","",false, this);
 
            Line51 = RPSControlFactory.CreateRPSTextBox<GenerateFileTextChildDialogView>("5d66be4d-51ca-46f5-b135-14c304daa647","","",false, this);
 
            Line6 = RPSControlFactory.CreateRPSTextBox<GenerateFileTextChildDialogView>("8552174b-e7cc-4d42-a05f-b11edb524391","","",false, this);
 
            Line61 = RPSControlFactory.CreateRPSTextBox<GenerateFileTextChildDialogView>("78149376-48bb-4624-a250-90ddf1a1222b","","",false, this);
 
            Line7 = RPSControlFactory.CreateRPSTextBox<GenerateFileTextChildDialogView>("ad27713f-afc9-4fe4-88d7-392c473c1674","","",false, this);
 
            Line71 = RPSControlFactory.CreateRPSTextBox<GenerateFileTextChildDialogView>("787cf8a8-d594-46fc-9ad5-792008e1e443","","",false, this);
 
            Line8 = RPSControlFactory.CreateRPSTextBox<GenerateFileTextChildDialogView>("939f675f-43ee-4985-af32-f8f4c5a080d5","","",false, this);
 
            Line81 = RPSControlFactory.CreateRPSTextBox<GenerateFileTextChildDialogView>("bff1f2ff-5746-4abe-bcc7-92b6ecae497f","","",false, this);
 

        }
        public IRPSTextBox<GenerateFileTextChildDialogView> Line2 { get; set; } 
        public IRPSTextBox<GenerateFileTextChildDialogView> Line21 { get; set; } 
        public IRPSTextBox<GenerateFileTextChildDialogView> Line3 { get; set; } 
        public IRPSTextBox<GenerateFileTextChildDialogView> Line31 { get; set; } 
        public IRPSTextBox<GenerateFileTextChildDialogView> Line4 { get; set; } 
        public IRPSTextBox<GenerateFileTextChildDialogView> Line41 { get; set; } 
        public IRPSTextBox<GenerateFileTextChildDialogView> Line5 { get; set; } 
        public IRPSTextBox<GenerateFileTextChildDialogView> Line51 { get; set; } 
        public IRPSTextBox<GenerateFileTextChildDialogView> Line6 { get; set; } 
        public IRPSTextBox<GenerateFileTextChildDialogView> Line61 { get; set; } 
        public IRPSTextBox<GenerateFileTextChildDialogView> Line7 { get; set; } 
        public IRPSTextBox<GenerateFileTextChildDialogView> Line71 { get; set; } 
        public IRPSTextBox<GenerateFileTextChildDialogView> Line8 { get; set; } 
        public IRPSTextBox<GenerateFileTextChildDialogView> Line81 { get; set; } 
        public DraftsQueryManagement Screen { get; set; }
        public GenerateFileTextChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class AccTransactionsResultChildDialogView : View
    {
        public AccTransactionsResultChildDialogView(DraftsQueryManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDACCTransactionsResult = RPSControlFactory.CreateRPSComboBox<AccTransactionsResultChildDialogView>("90fc938d-a5db-4156-9653-2e8908325347","","",false, this);
 

        }
        public IRPSComboBox<AccTransactionsResultChildDialogView> IDACCTransactionsResult { get; set; } 
        public DraftsQueryManagement Screen { get; set; }
        public AccTransactionsResultChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ClaimPrintChildDialogView : View
    {
        public ClaimPrintChildDialogView(DraftsQueryManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CodCustomReportClaim = RPSControlFactory.CreateRPSEnumComboBox<ClaimPrintChildDialogView>("6ad487c8-a5fb-437f-96d2-0da7b8e8cc4d","","",false, this);
 
            LanguageThird = RPSControlFactory.CreateRPSOption<ClaimPrintChildDialogView>( "0d35226c-9213-45f8-98c6-b7c449845cad","","",this);
 
            OtherLanguage = RPSControlFactory.CreateRPSOption<ClaimPrintChildDialogView>( "e11c45bb-3fa7-42d2-83c5-b4a113f5ef81","","",this);
 
            CodLanguagePrint = RPSControlFactory.CreateRPSComboBox<ClaimPrintChildDialogView>("de3957d2-5469-485d-974d-2a9c8661ea17","","",false, this);
 
            MyEmail = RPSControlFactory.CreateRPSCheckBox<ClaimPrintChildDialogView>("c6d58a9d-27b9-41e2-8acc-893f61ec24fc","","",false, this);
 
            PrintCommand = RPSControlFactory.CreateRPSButton<ClaimPrintChildDialogView>( "7be262af-0c6b-449f-823f-18b8e653ed1a","","",this);
 
            MailCommand = RPSControlFactory.CreateRPSButton<ClaimPrintChildDialogView>( "791e9e49-0e24-41d0-8935-b61ad4e4c750","","",this);
 
            CancelCommand = RPSControlFactory.CreateRPSButton<ClaimPrintChildDialogView>( "b020a41f-3042-4562-ab61-2870ca236547","","",this);
 

        }
        public IRPSComboBox<ClaimPrintChildDialogView> CodCustomReportClaim { get; set; } 
        public IRPSOption<ClaimPrintChildDialogView> LanguageThird { get; set; } 
        public IRPSOption<ClaimPrintChildDialogView> OtherLanguage { get; set; } 
        public IRPSComboBox<ClaimPrintChildDialogView> CodLanguagePrint { get; set; } 
        public IRPSCheckbox<ClaimPrintChildDialogView> MyEmail { get; set; } 
        public IRPSButton<ClaimPrintChildDialogView> PrintCommand { get; set; } 
        public IRPSButton<ClaimPrintChildDialogView> MailCommand { get; set; } 
        public IRPSButton<ClaimPrintChildDialogView> CancelCommand { get; set; } 
        public DraftsQueryManagement Screen { get; set; }
        public ClaimPrintChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PrintChildDialogView : View
    {
        public PrintChildDialogView(DraftsQueryManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CodCustomReport = RPSControlFactory.CreateRPSEnumComboBox<PrintChildDialogView>("ab414414-b314-461e-9c1d-3a75c1501c50","","",false, this);
 

        }
        public IRPSComboBox<PrintChildDialogView> CodCustomReport { get; set; } 
        public DraftsQueryManagement Screen { get; set; }
        public PrintChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NettingChildDialogView : View
    {
        public NettingChildDialogView(DraftsQueryManagement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DraftsSupplierNumber = RPSControlFactory.CreateRPSFormattedTextBox<NettingChildDialogView>("a904ccdd-d6f2-4c17-a8b6-7ce62197474b","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<NettingChildDialogView>("969ada3d-6763-4553-8990-af1a89c9ce55","","",false, this);
 
            IDCustomerMiscellaneousSL = RPSControlFactory.CreateRPSComboBox<NettingChildDialogView>("5de219d8-c695-459e-be5d-b20c4b2a1f11","","",false, this);
 
            AmountCustomer = RPSControlFactory.CreateRPSFormattedTextBox<NettingChildDialogView>("102a3383-c8be-4b13-8473-bf78c03d6060","","",false, this);
 
            AmountCustomerCurrency = RPSControlFactory.CreateRPSFormattedTextBox<NettingChildDialogView>("de78dcaa-a28d-4993-b130-49c161276ed2","","",false, this);
 
            DraftsSupplierNumber1 = RPSControlFactory.CreateRPSFormattedTextBox<NettingChildDialogView>("88989b72-aef4-4030-8371-93df31b0d223","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<NettingChildDialogView>("4ac96cd8-66c0-42cb-a871-1c0a4b2b462b","","",false, this);
 
            IDSupplierMiscellaneous = RPSControlFactory.CreateRPSComboBox<NettingChildDialogView>("c154cf71-d813-4eef-9072-43260422d937","","",false, this);
 
            AmountSupplier = RPSControlFactory.CreateRPSFormattedTextBox<NettingChildDialogView>("b8320539-8886-484d-904a-6349a45e2de5","","",false, this);
 
            AmountSupplierCurrency = RPSControlFactory.CreateRPSFormattedTextBox<NettingChildDialogView>("cc8ae3e8-efde-4cfd-9722-be42adc99be9","","",false, this);
 
            AmountTotal = RPSControlFactory.CreateRPSFormattedTextBox<NettingChildDialogView>("e1fcaf54-b948-4c23-95d3-ff33009bc9b5","","",false, this);
 
            AmountTotalCurrency = RPSControlFactory.CreateRPSFormattedTextBox<NettingChildDialogView>("59ec455d-9eb2-4e56-9f06-550d67506255","","",false, this);
 
            IDPaymentStatus = RPSControlFactory.CreateRPSComboBox<NettingChildDialogView>("8d473c33-ec0d-4196-98fd-3b78d79df04f","","",false, this);
 
            AccountingDate = RPSControlFactory.CreateRPSTextBox<NettingChildDialogView>("013f233f-1fda-4a5a-bfe7-a3c52e60f90d","","",false, this);
 
            NoFinal = RPSControlFactory.CreateRPSOption<NettingChildDialogView>( "2ee7a1c8-f37d-458a-b2e9-975812fb9603","","",this);
 
            FinalNoChange = RPSControlFactory.CreateRPSOption<NettingChildDialogView>( "910565ac-c51b-4712-917d-701cac52a16d","","",this);
 
            Final_Change = RPSControlFactory.CreateRPSOption<NettingChildDialogView>( "0080ace9-85a9-4d09-9417-f2f81c2f2288","","",this);
 
            Initial = RPSControlFactory.CreateRPSOption<NettingChildDialogView>( "e7f31cbb-8c8d-48eb-a47c-6f50545d60b8","","",this);
 
            Idem = RPSControlFactory.CreateRPSOption<NettingChildDialogView>( "71f36598-2720-426a-a99e-6053bde260fe","","",this);
 
            IDACCTransactions = RPSControlFactory.CreateRPSComboBox<NettingChildDialogView>("daf576ab-2688-416a-ae44-55bd822459a5","","",false, this);
 
            MessError = RPSControlFactory.CreateRPSTextBox<NettingChildDialogView>("a6eba61f-a57d-4100-99f4-4e553d2bdc29","","",false, this);
 
            PrintReport = RPSControlFactory.CreateRPSCheckBox<NettingChildDialogView>("5152629f-cf60-4470-8a05-c2023daee0bd","","",false, this);
 
            CustomReportList = RPSControlFactory.CreateRPSEnumComboBox<NettingChildDialogView>("d014549c-8090-4bfb-a93f-8e8a9916b867","","",false, this);
 
            CustomReportLetter = RPSControlFactory.CreateRPSEnumComboBox<NettingChildDialogView>("9709f058-2aa4-416a-a13b-047a50e3678f","","",false, this);
 
            None = RPSControlFactory.CreateRPSOption<NettingChildDialogView>( "6315839b-597d-46b6-91eb-60b3ce86bd5d","","",this);
 
            All = RPSControlFactory.CreateRPSOption<NettingChildDialogView>( "50495df8-cdc9-40e6-af92-f368da16fd6c","","",this);
 
            OnlyCustomer = RPSControlFactory.CreateRPSOption<NettingChildDialogView>( "ac2b1ad4-77ca-4524-91b8-899d65f5f87a","","",this);
 
            OnlySupplier = RPSControlFactory.CreateRPSOption<NettingChildDialogView>( "2e4e846c-828c-41db-8c8a-fee44814f786","","",this);
 
            OnlyPending = RPSControlFactory.CreateRPSOption<NettingChildDialogView>( "24c8885a-b69d-4668-b964-b7265d7e77ef","","",this);
 
            UseLanguageThird = RPSControlFactory.CreateRPSCheckBox<NettingChildDialogView>("96795a56-bf02-41a5-ad15-f44621b78965","","",false, this);
 
            IDOtherLanguage = RPSControlFactory.CreateRPSComboBox<NettingChildDialogView>("a6cfe8ef-f91e-4126-be2a-5c2cbfd58e61","","",false, this);
 
            _Screen = RPSControlFactory.CreateRPSOption<NettingChildDialogView>( "14e5012a-e416-4156-828d-85f55d404723","","",this);
 
            mail = RPSControlFactory.CreateRPSOption<NettingChildDialogView>( "43f03a50-906e-4c42-85d4-0cdb22f7f6d6","","",this);
 
            CollectionInit params_GetLastDraft = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1754978d-b51a-4441-a345-3643498500f8",CSSSelectorGrid="",XPathGrid=""};
            GetLastDraft = RPSControlFactory.RPSCreateCollectionWithGrid<GetLastDraftCollectionEditor<NettingChildDialogView>,NettingChildDialogView>( params_GetLastDraft,this);
 

        }
        public IRPSTextBox<NettingChildDialogView> DraftsSupplierNumber { get; set; } 
        public IRPSComboBox<NettingChildDialogView> IDCustomer { get; set; } 
        public IRPSComboBox<NettingChildDialogView> IDCustomerMiscellaneousSL { get; set; } 
        public IRPSTextBox<NettingChildDialogView> AmountCustomer { get; set; } 
        public IRPSTextBox<NettingChildDialogView> AmountCustomerCurrency { get; set; } 
        public IRPSTextBox<NettingChildDialogView> DraftsSupplierNumber1 { get; set; } 
        public IRPSComboBox<NettingChildDialogView> IDSupplier { get; set; } 
        public IRPSComboBox<NettingChildDialogView> IDSupplierMiscellaneous { get; set; } 
        public IRPSTextBox<NettingChildDialogView> AmountSupplier { get; set; } 
        public IRPSTextBox<NettingChildDialogView> AmountSupplierCurrency { get; set; } 
        public IRPSTextBox<NettingChildDialogView> AmountTotal { get; set; } 
        public IRPSTextBox<NettingChildDialogView> AmountTotalCurrency { get; set; } 
        public IRPSComboBox<NettingChildDialogView> IDPaymentStatus { get; set; } 
        public IRPSTextBox<NettingChildDialogView> AccountingDate { get; set; } 
        public IRPSOption<NettingChildDialogView> NoFinal { get; set; } 
        public IRPSOption<NettingChildDialogView> FinalNoChange { get; set; } 
        public IRPSOption<NettingChildDialogView> Final_Change { get; set; } 
        public IRPSOption<NettingChildDialogView> Initial { get; set; } 
        public IRPSOption<NettingChildDialogView> Idem { get; set; } 
        public IRPSComboBox<NettingChildDialogView> IDACCTransactions { get; set; } 
        public IRPSTextBox<NettingChildDialogView> MessError { get; set; } 
        public IRPSCheckbox<NettingChildDialogView> PrintReport { get; set; } 
        public IRPSComboBox<NettingChildDialogView> CustomReportList { get; set; } 
        public IRPSComboBox<NettingChildDialogView> CustomReportLetter { get; set; } 
        public IRPSOption<NettingChildDialogView> None { get; set; } 
        public IRPSOption<NettingChildDialogView> All { get; set; } 
        public IRPSOption<NettingChildDialogView> OnlyCustomer { get; set; } 
        public IRPSOption<NettingChildDialogView> OnlySupplier { get; set; } 
        public IRPSOption<NettingChildDialogView> OnlyPending { get; set; } 
        public IRPSCheckbox<NettingChildDialogView> UseLanguageThird { get; set; } 
        public IRPSComboBox<NettingChildDialogView> IDOtherLanguage { get; set; } 
        public IRPSOption<NettingChildDialogView> _Screen { get; set; } 
        public IRPSOption<NettingChildDialogView> mail { get; set; } 
        public GetLastDraftCollectionEditor<NettingChildDialogView> GetLastDraft { get; set; } 
        public DraftsQueryManagement Screen { get; set; }
        public NettingChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetLastDraftCollectionEditor<NettingChildDialogView>:RPSCollectionEditor<NettingChildDialogView> where NettingChildDialogView : class, IView
    {
        public  GetLastDraftGridView<NettingChildDialogView> GridView {get;set;}
    }
    public partial class GetLastDraftGridView <NettingChildDialogView> :  RPSGridView<NettingChildDialogView> where NettingChildDialogView : class, IView
    {
        public GetLastDraftGridView(NettingChildDialogView currentView)
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