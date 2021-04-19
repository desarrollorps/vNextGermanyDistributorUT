    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.ACCTransactions
{
    //RPS VERSION 1.0.0.0
    public partial class ACCTransactions:Screen
    {
        public ACCTransactions():base()
        {
            this.URL = "generalledger.acctransactions";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ACCTransactionsCollectionView  = new ACCTransactionsCollectionView(this); 
            ACCTransactionsEntityView  = new ACCTransactionsEntityView(this); 
            ACCTransactionsDetailView  = new ACCTransactionsDetailView(this); 
            ACCTransactionsAnalyticView  = new ACCTransactionsAnalyticView(this); 
            DraftsChildDialogView  = new DraftsChildDialogView(this); 
            DUAChildDialogView  = new DUAChildDialogView(this); 
            AccTransacionsDUAChildDialogView  = new AccTransacionsDUAChildDialogView(this); 
            VoucherTemplateChildDialogView  = new VoucherTemplateChildDialogView(this); 
            AnalyticChildDialogView  = new AnalyticChildDialogView(this); 
            NewPurchaseInvoiceDialogView  = new NewPurchaseInvoiceDialogView(this); 
            ACCTransactionsCollectionView.InitializeControls(); 
            ACCTransactionsEntityView.InitializeControls(); 
            ACCTransactionsDetailView.InitializeControls(); 
            ACCTransactionsAnalyticView.InitializeControls(); 
            DraftsChildDialogView.InitializeControls(); 
            DUAChildDialogView.InitializeControls(); 
            AccTransacionsDUAChildDialogView.InitializeControls(); 
            VoucherTemplateChildDialogView.InitializeControls(); 
            AnalyticChildDialogView.InitializeControls(); 
            NewPurchaseInvoiceDialogView.InitializeControls(); 
           
        }
      
            public ACCTransactionsCollectionView ACCTransactionsCollectionView {get; set; } 
            public ACCTransactionsEntityView ACCTransactionsEntityView {get; set; } 
            public ACCTransactionsDetailView ACCTransactionsDetailView {get; set; } 
            public ACCTransactionsAnalyticView ACCTransactionsAnalyticView {get; set; } 
            public DraftsChildDialogView DraftsChildDialogView {get; set; } 
            public DUAChildDialogView DUAChildDialogView {get; set; } 
            public AccTransacionsDUAChildDialogView AccTransacionsDUAChildDialogView {get; set; } 
            public VoucherTemplateChildDialogView VoucherTemplateChildDialogView {get; set; } 
            public AnalyticChildDialogView AnalyticChildDialogView {get; set; } 
            public NewPurchaseInvoiceDialogView NewPurchaseInvoiceDialogView {get; set; } 
    }
            
    public partial class ACCTransactionsCollectionView : View
    {
        public ACCTransactionsCollectionView(ACCTransactions screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ACCTransactionsCollectionView,ACCTransactionsEntityView>( this,Screen.ACCTransactionsEntityView);
 
            DUAChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ACCTransactionsCollectionView,DUAChildDialogView>("f9e1b38a-d79f-45d9-b3db-0f5aed57b981","","", this,Screen.DUAChildDialogView);
 
            VoucherTemplateChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ACCTransactionsCollectionView,VoucherTemplateChildDialogView>("fcdb990e-849b-4e82-9046-7d072e2ff23f","","", this,Screen.VoucherTemplateChildDialogView);
 
            NewPurchaseInvoiceNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ACCTransactionsCollectionView,NewPurchaseInvoiceDialogView>("47932713-1f8b-486b-87f2-209e50afea7f","","", this,Screen.NewPurchaseInvoiceDialogView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "78aaf90b-8743-4c2e-9538-4cae6ae3174f",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ACCTransactionsCollectionView,ACCTransactionsEntityView>( params_MainConsult,this,Screen.ACCTransactionsEntityView);
 

        }
        public IRPSButton<ACCTransactionsCollectionView,ACCTransactionsEntityView> NewButton { get; set; } 
        public IRPSButton<ACCTransactionsCollectionView,DUAChildDialogView> DUAChildNavigationCommandButton { get; set; } 
        public IRPSButton<ACCTransactionsCollectionView,VoucherTemplateChildDialogView> VoucherTemplateChildNavigationCommandButton { get; set; } 
        public IRPSButton<ACCTransactionsCollectionView,NewPurchaseInvoiceDialogView> NewPurchaseInvoiceNavigationCommandButton { get; set; } 
        public IRPSCollectionEditor<ACCTransactionsCollectionView,ACCTransactionsEntityView> MainConsult { get; set; } 
        public ACCTransactions Screen { get; set; }
        public ACCTransactionsCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ACCTransactionsEntityView : View
    {
        public ACCTransactionsEntityView(ACCTransactions screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ACCTransactionsEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ACCTransactionsEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ACCTransactionsEntityView,ACCTransactionsCollectionView>( this,Screen.ACCTransactionsCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ACCTransactionsEntityView,ACCTransactionsCollectionView>( this,Screen.ACCTransactionsCollectionView);
 
            TotalCredit = RPSControlFactory.CreateRPSFormattedTextBox<ACCTransactionsEntityView>("45d74ff8-d849-40e4-b025-545db62f1d82","","",false, this);
 
            TotalDebit = RPSControlFactory.CreateRPSFormattedTextBox<ACCTransactionsEntityView>("9cafe215-02a4-4042-aceb-2d3e254b1d70","","",false, this);
 
            Diff = RPSControlFactory.CreateRPSFormattedTextBox<ACCTransactionsEntityView>("d43c8a61-06cb-46c9-99bc-59b537646a72","","",false, this);
 
            UIIDACCYear = RPSControlFactory.CreateRPSComboBox<ACCTransactionsEntityView>("aa7e9659-9a72-4fc1-b754-6caec5937636","","",false, this);
 
            JournalNumber = RPSControlFactory.CreateRPSFormattedTextBox<ACCTransactionsEntityView>("7140bdbb-6594-4683-9602-027f58e80018","","",true, this);
 
            IDVoucherType = RPSControlFactory.CreateRPSComboBox<ACCTransactionsEntityView>("d1d65903-fc34-4f4e-8915-8e412ae418bf","","",true, this);
 
            AccountingDate = RPSControlFactory.CreateRPSTextBox<ACCTransactionsEntityView>("9bdf9aba-43c3-4383-b687-97f42153ef19","","",true, this);
 
            Nullified = RPSControlFactory.CreateRPSCheckBox<ACCTransactionsEntityView>("5addfeaf-e71b-4d27-9567-b44fcb1a2d4e","","",false, this);
 
            Blocked = RPSControlFactory.CreateRPSCheckBox<ACCTransactionsEntityView>("f92f297c-25ea-45b1-bde0-4e40623ed9cd","","",true, this);
 
            Service = RPSControlFactory.CreateRPSEnumComboBox<ACCTransactionsEntityView>("6f4723e0-69eb-4f88-bed5-aa21c07b97d9","","",true, this);
 
            NumberDocument = RPSControlFactory.CreateRPSTextBox<ACCTransactionsEntityView>("3e1c0625-78dc-4110-b430-79c674527235","","",false, this);
 
            IDVoucherSeriesBook = RPSControlFactory.CreateRPSComboBox<ACCTransactionsEntityView>("b11f5a29-72a0-45a2-bf9a-8c38db14b99d","","",true, this);
 
            VoucherNumber = RPSControlFactory.CreateRPSFormattedTextBox<ACCTransactionsEntityView>("9a2493cf-5730-49d6-bcca-916ccdbed254","","",true, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<ACCTransactionsEntityView>("0e6230f1-63a6-4b1e-b2f7-2aab1d5848f9","","",false, this);
 
            IDSupplierMiscellaneous = RPSControlFactory.CreateRPSComboBox<ACCTransactionsEntityView>("49375726-51b9-49cc-9d3a-04764222c6df","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<ACCTransactionsEntityView>("35a9ff51-61d7-40fa-90d8-e313363690ae","","",false, this);
 
            IDCustomerMiscellaneous = RPSControlFactory.CreateRPSComboBox<ACCTransactionsEntityView>("efa1af41-02c0-41f7-b0fd-ecb7f01b2b2e","","",false, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<ACCTransactionsEntityView>("5cf77b56-f0da-41b6-88e2-c1e400c9e20a","","",false, this);
 
            CompanyName = RPSControlFactory.CreateRPSTextBox<ACCTransactionsEntityView>("df968deb-3748-4bcd-a605-114c3e2230c1","","",false, this);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSComboBox<ACCTransactionsEntityView>("d289de5a-7282-47c8-9f1a-86c0a1278c93","","",false, this);
 
            IDPaymentMethodSL = RPSControlFactory.CreateRPSComboBox<ACCTransactionsEntityView>("2449f46f-3d09-4733-8c3f-b34e7b732804","","",false, this);
 
            CodCountryFrom = RPSControlFactory.CreateRPSComboBox<ACCTransactionsEntityView>("c6c7213c-4f57-4a72-8957-3f89202d4ff6","","",false, this);
 
            IDStateFrom = RPSControlFactory.CreateRPSComboBox<ACCTransactionsEntityView>("97b7f223-6c0b-4ed8-b0e9-9501f0a4a9d8","","",false, this);
 
            CodCountryTo = RPSControlFactory.CreateRPSComboBox<ACCTransactionsEntityView>("d7c69141-25d8-4ba2-ab37-e2cf9f8f4a52","","",false, this);
 
            IDStateTo = RPSControlFactory.CreateRPSComboBox<ACCTransactionsEntityView>("2d61687c-37b5-404d-b671-4eeece0326ee","","",false, this);
 
            InvoiceDate = RPSControlFactory.CreateRPSTextBox<ACCTransactionsEntityView>("02404976-ef91-4b38-b8f3-a9c3b8424e45","","",false, this);
 
            CodInvoice = RPSControlFactory.CreateRPSTextBox<ACCTransactionsEntityView>("e635cefb-96f2-4d76-ae9a-6f4a89e74c16","","",false, this);
 
            UIIDInvoice = RPSControlFactory.CreateRPSComboBox<ACCTransactionsEntityView>("ce34d169-ace3-4915-ad4a-063dc28ed007","","",false, this);
 
            UIIDInvoiceSL = RPSControlFactory.CreateRPSComboBox<ACCTransactionsEntityView>("74aab9d7-3e4d-496d-8c53-985b09564342","","",false, this);
 
            VATAPRegisterNumber = RPSControlFactory.CreateRPSFormattedTextBox<ACCTransactionsEntityView>("5869dfae-0713-438b-890e-b52756649bea","","",true, this);
 
            VATARRegisterNumber = RPSControlFactory.CreateRPSFormattedTextBox<ACCTransactionsEntityView>("e6db665a-9419-4f4b-87ee-329a48099bb7","","",true, this);
 
            GenerateAutoInvoice = RPSControlFactory.CreateRPSCheckBox<ACCTransactionsEntityView>("afe9cb10-adf6-4efc-8a4b-50fb5f4c7a25","","",false, this);
 
            IDEUInvoice = RPSControlFactory.CreateRPSComboBox<ACCTransactionsEntityView>("650b2523-4f86-47a4-b836-cc67b235029c","","",false, this);
 
            IDAutoInvoice = RPSControlFactory.CreateRPSComboBox<ACCTransactionsEntityView>("75f4a624-b49f-4f4c-8251-caaafd17c989","","",false, this);
 
            DeliveryNoteDate = RPSControlFactory.CreateRPSTextBox<ACCTransactionsEntityView>("e51afcac-0c78-4e79-b86a-c5fea3d8a7dd","","",false, this);
 
            CodDeliveryNote = RPSControlFactory.CreateRPSTextBox<ACCTransactionsEntityView>("3ad008f6-6d80-4fa8-9e4e-124d9da66e48","","",false, this);
 
            DocumentType = RPSControlFactory.CreateRPSEnumComboBox<ACCTransactionsEntityView>("1b2d2e6f-6d28-476d-b6a0-d7aab3bf821f","","",true, this);
 
            CodFromInvoice = RPSControlFactory.CreateRPSTextBox<ACCTransactionsEntityView>("1cda8ddb-cd15-45a1-b8aa-3da9e0d97918","","",false, this);
 
            DUAGroup = RPSControlFactory.CreateRPSTextBox<ACCTransactionsEntityView>("7b25d152-a475-4f85-b007-7058d96129b2","","",false, this);
 
            Renting = RPSControlFactory.CreateRPSCheckBox<ACCTransactionsEntityView>("120ad7d4-b071-4631-991e-d4928fb894c5","","",true, this);
 
            IDFixedAsset = RPSControlFactory.CreateRPSComboBox<ACCTransactionsEntityView>("f11a20ff-d5b3-43d9-a680-a4e004bd21ac","","",false, this);
 
            DuplicateAccTransactionsCommandButton = RPSControlFactory.CreateRPSButton<ACCTransactionsEntityView>( "f4d15c66-59e1-47f0-8144-0987a9278d4a","","",this);
 
            InverseCommandButton = RPSControlFactory.CreateRPSButton<ACCTransactionsEntityView>( "cc41cdb9-c3d6-4a68-93a6-1846cbe98dc5","","",this);
 
            CommandNullifyVoucherButton = RPSControlFactory.CreateRPSButton<ACCTransactionsEntityView>( "5e071821-260d-42c0-9cb4-ec8463d8e53b","","",this);
 
            ReportCommandButton = RPSControlFactory.CreateRPSButton<ACCTransactionsEntityView>( "b725f5fa-d5c3-41fb-9003-1ea0e5560dc8","","",this);
 
            DraftsChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ACCTransactionsEntityView,DraftsChildDialogView>("ffce4e08-7d70-4c30-aef6-507efbc907dc","","", this,Screen.DraftsChildDialogView);
 
            AccTransacionsDUAChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ACCTransactionsEntityView,AccTransacionsDUAChildDialogView>("c751afe5-cd77-44fd-af60-ba7384927ee8","","", this,Screen.AccTransacionsDUAChildDialogView);
 
            ExecuteBlockACCTransactionsButton = RPSControlFactory.CreateRPSButton<ACCTransactionsEntityView>( "d467f66d-45b3-45ef-87d9-667aacba1461","","",this);
 
            ExecuteUnlockACCTransactionsButton = RPSControlFactory.CreateRPSButton<ACCTransactionsEntityView>( "c4505f7c-5dab-4711-b408-2b197cd67343","","",this);
 
            CollectionInit params_ACCTransactionsDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="39e00f7b-05f5-44c0-9a3c-f19166700610",CSSSelectorGrid="",XPathGrid=""};
            ACCTransactionsDetails = RPSControlFactory.RPSCreateCollectionWithGrid<ACCTransactionsDetailsCollectionEditor<ACCTransactionsEntityView,ACCTransactionsDetailView>,ACCTransactionsEntityView,ACCTransactionsDetailView>( params_ACCTransactionsDetails,this,Screen.ACCTransactionsDetailView);
 
            SectionDetails = RPSControlFactory.CreateRPSSection<ACCTransactionsEntityView>( "","ul li[rpsid='f00ae891-1a7b-4a62-823d-b3b3bd3ad776']","",this);
 
            SectionGeneral = RPSControlFactory.CreateRPSSection<ACCTransactionsEntityView>( "","ul li[rpsid='de50860e-78a0-42d3-81ea-80eed7b22844']","",this);
 

        }
        public IRPSSaveButton<ACCTransactionsEntityView> SaveButton { get; set; } 
        public IRPSButton<ACCTransactionsEntityView> DeleteButton { get; set; } 
        public IRPSButton<ACCTransactionsEntityView,ACCTransactionsCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ACCTransactionsEntityView,ACCTransactionsCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ACCTransactionsEntityView> TotalCredit { get; set; } 
        public IRPSTextBox<ACCTransactionsEntityView> TotalDebit { get; set; } 
        public IRPSTextBox<ACCTransactionsEntityView> Diff { get; set; } 
        public IRPSComboBox<ACCTransactionsEntityView> UIIDACCYear { get; set; } 
        public IRPSTextBox<ACCTransactionsEntityView> JournalNumber { get; set; } 
        public IRPSComboBox<ACCTransactionsEntityView> IDVoucherType { get; set; } 
        public IRPSTextBox<ACCTransactionsEntityView> AccountingDate { get; set; } 
        public IRPSCheckbox<ACCTransactionsEntityView> Nullified { get; set; } 
        public IRPSCheckbox<ACCTransactionsEntityView> Blocked { get; set; } 
        public IRPSComboBox<ACCTransactionsEntityView> Service { get; set; } 
        public IRPSTextBox<ACCTransactionsEntityView> NumberDocument { get; set; } 
        public IRPSComboBox<ACCTransactionsEntityView> IDVoucherSeriesBook { get; set; } 
        public IRPSTextBox<ACCTransactionsEntityView> VoucherNumber { get; set; } 
        public IRPSComboBox<ACCTransactionsEntityView> IDSupplier { get; set; } 
        public IRPSComboBox<ACCTransactionsEntityView> IDSupplierMiscellaneous { get; set; } 
        public IRPSComboBox<ACCTransactionsEntityView> IDCustomer { get; set; } 
        public IRPSComboBox<ACCTransactionsEntityView> IDCustomerMiscellaneous { get; set; } 
        public IRPSTextBox<ACCTransactionsEntityView> VATNumber { get; set; } 
        public IRPSTextBox<ACCTransactionsEntityView> CompanyName { get; set; } 
        public IRPSComboBox<ACCTransactionsEntityView> IDPaymentMethod { get; set; } 
        public IRPSComboBox<ACCTransactionsEntityView> IDPaymentMethodSL { get; set; } 
        public IRPSComboBox<ACCTransactionsEntityView> CodCountryFrom { get; set; } 
        public IRPSComboBox<ACCTransactionsEntityView> IDStateFrom { get; set; } 
        public IRPSComboBox<ACCTransactionsEntityView> CodCountryTo { get; set; } 
        public IRPSComboBox<ACCTransactionsEntityView> IDStateTo { get; set; } 
        public IRPSTextBox<ACCTransactionsEntityView> InvoiceDate { get; set; } 
        public IRPSTextBox<ACCTransactionsEntityView> CodInvoice { get; set; } 
        public IRPSComboBox<ACCTransactionsEntityView> UIIDInvoice { get; set; } 
        public IRPSComboBox<ACCTransactionsEntityView> UIIDInvoiceSL { get; set; } 
        public IRPSTextBox<ACCTransactionsEntityView> VATAPRegisterNumber { get; set; } 
        public IRPSTextBox<ACCTransactionsEntityView> VATARRegisterNumber { get; set; } 
        public IRPSCheckbox<ACCTransactionsEntityView> GenerateAutoInvoice { get; set; } 
        public IRPSComboBox<ACCTransactionsEntityView> IDEUInvoice { get; set; } 
        public IRPSComboBox<ACCTransactionsEntityView> IDAutoInvoice { get; set; } 
        public IRPSTextBox<ACCTransactionsEntityView> DeliveryNoteDate { get; set; } 
        public IRPSTextBox<ACCTransactionsEntityView> CodDeliveryNote { get; set; } 
        public IRPSComboBox<ACCTransactionsEntityView> DocumentType { get; set; } 
        public IRPSTextBox<ACCTransactionsEntityView> CodFromInvoice { get; set; } 
        public IRPSTextBox<ACCTransactionsEntityView> DUAGroup { get; set; } 
        public IRPSCheckbox<ACCTransactionsEntityView> Renting { get; set; } 
        public IRPSComboBox<ACCTransactionsEntityView> IDFixedAsset { get; set; } 
        public IRPSButton<ACCTransactionsEntityView> DuplicateAccTransactionsCommandButton { get; set; } 
        public IRPSButton<ACCTransactionsEntityView> InverseCommandButton { get; set; } 
        public IRPSButton<ACCTransactionsEntityView> CommandNullifyVoucherButton { get; set; } 
        public IRPSButton<ACCTransactionsEntityView> ReportCommandButton { get; set; } 
        public IRPSButton<ACCTransactionsEntityView,DraftsChildDialogView> DraftsChildNavigationCommandButton { get; set; } 
        public IRPSButton<ACCTransactionsEntityView,AccTransacionsDUAChildDialogView> AccTransacionsDUAChildNavigationCommandButton { get; set; } 
        public IRPSButton<ACCTransactionsEntityView> ExecuteBlockACCTransactionsButton { get; set; } 
        public IRPSButton<ACCTransactionsEntityView> ExecuteUnlockACCTransactionsButton { get; set; } 
        public ACCTransactionsDetailsCollectionEditor<ACCTransactionsEntityView,ACCTransactionsDetailView> ACCTransactionsDetails { get; set; } 
        public IRPSSection<ACCTransactionsEntityView> SectionDetails { get; set; } 
        public IRPSSection<ACCTransactionsEntityView> SectionGeneral { get; set; } 
        public ACCTransactions Screen { get; set; }
        public ACCTransactionsEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ACCTransactionsDetailsCollectionEditor<ACCTransactionsEntityView,ACCTransactionsDetailView>:RPSCollectionEditor<ACCTransactionsEntityView,ACCTransactionsDetailView> where ACCTransactionsEntityView : class, IView where ACCTransactionsDetailView : class, IView
    {
        public  ACCTransactionsDetailsGridView<ACCTransactionsEntityView,ACCTransactionsDetailView> GridView {get;set;}
    }
    public partial class ACCTransactionsDetailsGridView <ACCTransactionsEntityView,ACCTransactionsDetailView> :  RPSGridView<ACCTransactionsEntityView,ACCTransactionsDetailView> where ACCTransactionsEntityView : class, IView where ACCTransactionsDetailView : class, IView
    {
        public ACCTransactionsDetailsGridView(ACCTransactionsEntityView currentView,ACCTransactionsDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            VoucherNumberLine = RPSControlFactory.CreateRPSGridFormattedTextBox<ACCTransactionsEntityView>("","#39e00f7b-05f5-44c0-9a3c-f19166700610 .ag-row[role='row']@ROWINDEX [col-id='cVoucherNumberLine']","",true, this.CurrentView);
 
            MovementType = RPSControlFactory.CreateRPSGridEnumComboBox<ACCTransactionsEntityView>("","#39e00f7b-05f5-44c0-9a3c-f19166700610 .ag-row[role='row']@ROWINDEX [col-id='cMovementType']","",true, this.CurrentView);
 
            IDItemSelector = RPSControlFactory.CreateRPSGridComboBox<ACCTransactionsEntityView>("","#39e00f7b-05f5-44c0-9a3c-f19166700610 .ag-row[role='row']@ROWINDEX [col-id='cIDItemSelector']","",false, this.CurrentView);
 
            IDAccount = RPSControlFactory.CreateRPSGridComboBox<ACCTransactionsEntityView>("","#39e00f7b-05f5-44c0-9a3c-f19166700610 .ag-row[role='row']@ROWINDEX [col-id='cIDAccount']","",true, this.CurrentView);
 
            AmountDebit = RPSControlFactory.CreateRPSGridFormattedTextBox<ACCTransactionsEntityView>("","#39e00f7b-05f5-44c0-9a3c-f19166700610 .ag-row[role='row']@ROWINDEX [col-id='cAmountDebit']","",false, this.CurrentView);
 
            AmountCredit = RPSControlFactory.CreateRPSGridFormattedTextBox<ACCTransactionsEntityView>("","#39e00f7b-05f5-44c0-9a3c-f19166700610 .ag-row[role='row']@ROWINDEX [col-id='cAmountCredit']","",false, this.CurrentView);
 
            AmountCurrency = RPSControlFactory.CreateRPSGridFormattedTextBox<ACCTransactionsEntityView>("","#39e00f7b-05f5-44c0-9a3c-f19166700610 .ag-row[role='row']@ROWINDEX [col-id='cAmountCurrency']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<ACCTransactionsEntityView> VoucherNumberLine { get; set; } 
        public IRPSGridComboBox<ACCTransactionsEntityView> MovementType { get; set; } 
        public IRPSGridComboBox<ACCTransactionsEntityView> IDItemSelector { get; set; } 
        public IRPSGridComboBox<ACCTransactionsEntityView> IDAccount { get; set; } 
        public IRPSGridTextBox<ACCTransactionsEntityView> AmountDebit { get; set; } 
        public IRPSGridTextBox<ACCTransactionsEntityView> AmountCredit { get; set; } 
        public IRPSGridTextBox<ACCTransactionsEntityView> AmountCurrency { get; set; } 
                     
    }
 
    }
  
            
    public partial class ACCTransactionsDetailView : View
    {
        public ACCTransactionsDetailView(ACCTransactions screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ACCTransactionsDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ACCTransactionsDetailView,ACCTransactionsEntityView>( this,Screen.ACCTransactionsEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ACCTransactionsDetailView,ACCTransactionsEntityView>( this,Screen.ACCTransactionsEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ACCTransactionsDetailView,ACCTransactionsEntityView>( this,Screen.ACCTransactionsEntityView);
 
            VoucherNumberLine = RPSControlFactory.CreateRPSFormattedTextBox<ACCTransactionsDetailView>("c8a9fdc6-23f6-4ec1-9dd7-3c4b93d4a10d","","",true, this);
 
            MovementType = RPSControlFactory.CreateRPSEnumComboBox<ACCTransactionsDetailView>("42f42f2a-bcc0-42ff-8ab5-04dd993f6e81","","",true, this);
 
            IDItemBankAccountCompany = RPSControlFactory.CreateRPSComboBox<ACCTransactionsDetailView>("101cf77f-793e-4dec-be6b-ddf8e2da0d5d","","",false, this);
 
            IDItemCustomer = RPSControlFactory.CreateRPSComboBox<ACCTransactionsDetailView>("065ad4e7-4958-4ce9-ac39-86eaaa247493","","",false, this);
 
            IDItemCustomerMiscellaneous = RPSControlFactory.CreateRPSComboBox<ACCTransactionsDetailView>("98ae82ef-2e50-49c0-b99b-cb1d3bb8f95c","","",false, this);
 
            IDItemSupplier = RPSControlFactory.CreateRPSComboBox<ACCTransactionsDetailView>("8b2e822f-40e8-43f3-8c03-931d1f4b363e","","",false, this);
 
            IDItemSupplierMiscellaneous = RPSControlFactory.CreateRPSComboBox<ACCTransactionsDetailView>("0a31a4b8-f7f3-4c84-bffa-b3a8a5177c9e","","",false, this);
 
            IDItemTaxValue = RPSControlFactory.CreateRPSComboBox<ACCTransactionsDetailView>("1e44169c-0bb8-42d1-9fc7-b0513c3eb510","","",false, this);
 
            IDItemVAT = RPSControlFactory.CreateRPSComboBox<ACCTransactionsDetailView>("30b5ef28-fbb1-4477-b88e-a7e194a4cf50","","",false, this);
 
            IDAccount = RPSControlFactory.CreateRPSComboBox<ACCTransactionsDetailView>("7ab50385-4636-4240-8f47-9b423d03d2dc","","",true, this);
 
            SignType = RPSControlFactory.CreateRPSEnumComboBox<ACCTransactionsDetailView>("9fc679ef-ded9-4668-954e-801893f0291e","","",true, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<ACCTransactionsDetailView>("40917075-1626-4735-9d04-d04b646e9828","","",true, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<ACCTransactionsDetailView>("c967979b-e8b3-4e59-8195-cd13b24cd0e9","","",true, this);
 
            AmountCurrency = RPSControlFactory.CreateRPSFormattedTextBox<ACCTransactionsDetailView>("ab78fea7-9cc2-41f5-a155-8c6c79099bd2","","",true, this);
 
            Change = RPSControlFactory.CreateRPSFormattedTextBox<ACCTransactionsDetailView>("6d762776-d984-455e-9f63-50ae7361e3ab","","",true, this);
 
            Reviewed = RPSControlFactory.CreateRPSCheckBox<ACCTransactionsDetailView>("bff3e093-5551-4b02-ae6e-ef503e2bcfa9","","",true, this);
 
            VATPercentage = RPSControlFactory.CreateRPSFormattedTextBox<ACCTransactionsDetailView>("6bb98c01-fc03-4890-abc4-cfefc1834e23","","",true, this);
 
            VATBase = RPSControlFactory.CreateRPSFormattedTextBox<ACCTransactionsDetailView>("d851a37e-6f89-44e2-970c-987cee911a2b","","",true, this);
 
            PercentDeductible = RPSControlFactory.CreateRPSFormattedTextBox<ACCTransactionsDetailView>("d3191838-74a4-4f79-85bb-da0625ee211b","","",true, this);
 
            ExcludedFromRC = RPSControlFactory.CreateRPSCheckBox<ACCTransactionsDetailView>("1fcab2bd-be8c-48ab-8f35-661b59f0a69c","","",true, this);
 
            IDAccConcept = RPSControlFactory.CreateRPSComboBox<ACCTransactionsDetailView>("3b520e6c-f829-44e1-aa85-244f58f6c791","","",false, this);
 
            Extension = RPSControlFactory.CreateRPSTextBox<ACCTransactionsDetailView>("6ea514aa-acb6-4668-ba06-1ec22687dbe3","","",false, this);
 
            CodInvoice = RPSControlFactory.CreateRPSTextBox<ACCTransactionsDetailView>("5559f5c4-c4b5-4586-8bf6-3acbed937a3e","","",false, this);
 
            UIIDInvoice = RPSControlFactory.CreateRPSComboBox<ACCTransactionsDetailView>("ae27547b-ad3c-4eeb-acf7-f54b2b63e48f","","",false, this);
 
            UIIDInvoiceSL = RPSControlFactory.CreateRPSComboBox<ACCTransactionsDetailView>("2241992e-6c21-414c-b99a-23f714588c8d","","",false, this);
 
            CheckNumber = RPSControlFactory.CreateRPSTextBox<ACCTransactionsDetailView>("d1890841-49c7-4607-932a-5fc2c1644d23","","",false, this);
 
            IDLeasing = RPSControlFactory.CreateRPSComboBox<ACCTransactionsDetailView>("2939540a-9f43-4818-bd3c-930241e8039d","","",false, this);
 
            UIAccTransactionsTemp = RPSControlFactory.CreateRPSTextBox<ACCTransactionsDetailView>("89fabedf-ca14-4373-ac2d-9b47c599af6e","","",false, this);
 
            IDACCTransInvoiceTaxPurchase = RPSControlFactory.CreateRPSComboBox<ACCTransactionsDetailView>("847be195-580b-4757-8e8e-24c679ea54d7","","",false, this);
 
            IDACCTransInvoiceTaxSales = RPSControlFactory.CreateRPSComboBox<ACCTransactionsDetailView>("6ca55f67-88af-4739-b6d4-e973c163cb99","","",false, this);
 
            IDACCTransInvoiceVATPurchase = RPSControlFactory.CreateRPSComboBox<ACCTransactionsDetailView>("7b8c58eb-8772-4176-9a33-d35af90f1f19","","",false, this);
 
            IDACCTransInvoiceVATSales = RPSControlFactory.CreateRPSComboBox<ACCTransactionsDetailView>("11fcf94e-4295-424f-aca3-d702763d942d","","",false, this);
 
            PaidAmount = RPSControlFactory.CreateRPSFormattedTextBox<ACCTransactionsDetailView>("594381a0-4d83-43c8-8f5d-abbb71f535bf","","",true, this);
 
            PaidType = RPSControlFactory.CreateRPSEnumComboBox<ACCTransactionsDetailView>("ccb3e3fc-55cd-4aaf-9a00-abbf33683607","","",true, this);
 
            PaidExtension = RPSControlFactory.CreateRPSTextBox<ACCTransactionsDetailView>("569aaef9-f3bb-4370-8859-c1c2533cd268","","",false, this);
 
            ReconciliationStatus = RPSControlFactory.CreateRPSEnumComboBox<ACCTransactionsDetailView>("590c4fb0-1c50-4bd5-988d-1795696e169f","","",false, this);
 
            CodCompanyCON = RPSControlFactory.CreateRPSEnumComboBox<ACCTransactionsDetailView>("19eed8f5-6231-4ae3-9705-9a41d13745f3","","",false, this);
 
            CodCompanyGR = RPSControlFactory.CreateRPSEnumComboBox<ACCTransactionsDetailView>("40570243-a8e9-4a8b-8ef7-a81b5e55bff5","","",false, this);
 
            IntegrationService = RPSControlFactory.CreateRPSEnumComboBox<ACCTransactionsDetailView>("3a2a0998-35d2-471e-9c23-ec6807c106e0","","",false, this);
 
            Source = RPSControlFactory.CreateRPSEnumComboBox<ACCTransactionsDetailView>("3c6c54f5-7447-41e4-b45b-bdf40a8d6e57","","",false, this);
 
            ViewDraftsParentCommandButton = RPSControlFactory.CreateRPSButton<ACCTransactionsDetailView>( "d80e16ac-1876-4838-b29e-b21c5c26bf1b","","",this);
 
            AnalyticChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ACCTransactionsDetailView,AnalyticChildDialogView>("4050fc2f-68d9-42ae-8e5e-164b474fc9a7","","", this,Screen.AnalyticChildDialogView);
 
            CollectionInit params_ACCTransactionsAnalytics = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="807d58a4-b8c5-454d-a914-077d4e85b2e7",CSSSelectorGrid="",XPathGrid=""};
            ACCTransactionsAnalytics = RPSControlFactory.RPSCreateCollectionWithGrid<ACCTransactionsAnalyticsCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView>,ACCTransactionsDetailView,ACCTransactionsAnalyticView>( params_ACCTransactionsAnalytics,this,Screen.ACCTransactionsAnalyticView);
 
            CollectionInit params_ACCTransactionsDetailServiceCloseProjectConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d69c2e1c-a35a-4b88-9f60-c3567cdac3d3",CSSSelectorGrid="",XPathGrid=""};
            ACCTransactionsDetailServiceCloseProjectConsult = RPSControlFactory.RPSCreateCollectionWithGrid<ACCTransactionsDetailServiceCloseProjectConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView>,ACCTransactionsDetailView,ACCTransactionsAnalyticView>( params_ACCTransactionsDetailServiceCloseProjectConsult,this,Screen.ACCTransactionsAnalyticView);
 
            CollectionInit params_ACCTransactionsDetailServiceDeliveryNoteLineConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="bc7d5be0-aa18-43c7-aa5d-61c0b9af5f5d",CSSSelectorGrid="",XPathGrid=""};
            ACCTransactionsDetailServiceDeliveryNoteLineConsult = RPSControlFactory.RPSCreateCollectionWithGrid<ACCTransactionsDetailServiceDeliveryNoteLineConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView>,ACCTransactionsDetailView,ACCTransactionsAnalyticView>( params_ACCTransactionsDetailServiceDeliveryNoteLineConsult,this,Screen.ACCTransactionsAnalyticView);
 
            CollectionInit params_ACCTransactionsDetailServiceDeliveryNoteLineSLConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="cd8482f5-4426-4366-b74e-539345005ff5",CSSSelectorGrid="",XPathGrid=""};
            ACCTransactionsDetailServiceDeliveryNoteLineSLConsult = RPSControlFactory.RPSCreateCollectionWithGrid<ACCTransactionsDetailServiceDeliveryNoteLineSLConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView>,ACCTransactionsDetailView,ACCTransactionsAnalyticView>( params_ACCTransactionsDetailServiceDeliveryNoteLineSLConsult,this,Screen.ACCTransactionsAnalyticView);
 
            CollectionInit params_ACCTransactionsDetailServiceDraftChangeStatusConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d8417355-d63c-4157-93f3-e0e9f1f77980",CSSSelectorGrid="",XPathGrid=""};
            ACCTransactionsDetailServiceDraftChangeStatusConsult = RPSControlFactory.RPSCreateCollectionWithGrid<ACCTransactionsDetailServiceDraftChangeStatusConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView>,ACCTransactionsDetailView,ACCTransactionsAnalyticView>( params_ACCTransactionsDetailServiceDraftChangeStatusConsult,this,Screen.ACCTransactionsAnalyticView);
 
            CollectionInit params_ACCTransactionsDetailServiceImputationCostConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="83c4ecd9-bcb6-4e42-9811-2defdb616143",CSSSelectorGrid="",XPathGrid=""};
            ACCTransactionsDetailServiceImputationCostConsult = RPSControlFactory.RPSCreateCollectionWithGrid<ACCTransactionsDetailServiceImputationCostConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView>,ACCTransactionsDetailView,ACCTransactionsAnalyticView>( params_ACCTransactionsDetailServiceImputationCostConsult,this,Screen.ACCTransactionsAnalyticView);
 
            CollectionInit params_ACCTransactionsDetailServiceImputationCostMOConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5eb3b067-344a-4f49-b337-a32a4e9cb935",CSSSelectorGrid="",XPathGrid=""};
            ACCTransactionsDetailServiceImputationCostMOConsult = RPSControlFactory.RPSCreateCollectionWithGrid<ACCTransactionsDetailServiceImputationCostMOConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView>,ACCTransactionsDetailView,ACCTransactionsAnalyticView>( params_ACCTransactionsDetailServiceImputationCostMOConsult,this,Screen.ACCTransactionsAnalyticView);
 
            CollectionInit params_ACCTransactionsDetailServiceImputationMaterialConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="30fd77be-92d6-49a8-a994-22ffc5c48d5c",CSSSelectorGrid="",XPathGrid=""};
            ACCTransactionsDetailServiceImputationMaterialConsult = RPSControlFactory.RPSCreateCollectionWithGrid<ACCTransactionsDetailServiceImputationMaterialConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView>,ACCTransactionsDetailView,ACCTransactionsAnalyticView>( params_ACCTransactionsDetailServiceImputationMaterialConsult,this,Screen.ACCTransactionsAnalyticView);
 
            CollectionInit params_ACCTransactionsDetailServiceImputationMaterialMOConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d3585bb4-6b35-49c3-831a-87f328c13c6c",CSSSelectorGrid="",XPathGrid=""};
            ACCTransactionsDetailServiceImputationMaterialMOConsult = RPSControlFactory.RPSCreateCollectionWithGrid<ACCTransactionsDetailServiceImputationMaterialMOConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView>,ACCTransactionsDetailView,ACCTransactionsAnalyticView>( params_ACCTransactionsDetailServiceImputationMaterialMOConsult,this,Screen.ACCTransactionsAnalyticView);
 
            CollectionInit params_ACCTransactionsDetailServiceImputationTimeConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="169b20f9-33c5-4284-8a3d-61ea6a39d190",CSSSelectorGrid="",XPathGrid=""};
            ACCTransactionsDetailServiceImputationTimeConsult = RPSControlFactory.RPSCreateCollectionWithGrid<ACCTransactionsDetailServiceImputationTimeConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView>,ACCTransactionsDetailView,ACCTransactionsAnalyticView>( params_ACCTransactionsDetailServiceImputationTimeConsult,this,Screen.ACCTransactionsAnalyticView);
 
            CollectionInit params_ACCTransactionsDetailServiceImputationTimeMOConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="280dc93d-cb7b-427e-a8c7-909448e85edb",CSSSelectorGrid="",XPathGrid=""};
            ACCTransactionsDetailServiceImputationTimeMOConsult = RPSControlFactory.RPSCreateCollectionWithGrid<ACCTransactionsDetailServiceImputationTimeMOConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView>,ACCTransactionsDetailView,ACCTransactionsAnalyticView>( params_ACCTransactionsDetailServiceImputationTimeMOConsult,this,Screen.ACCTransactionsAnalyticView);
 
            CollectionInit params_ACCTransactionsDetailServiceMaintenanceConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8d1fb71a-fa4e-4c3a-936f-f437e8a9156b",CSSSelectorGrid="",XPathGrid=""};
            ACCTransactionsDetailServiceMaintenanceConsult = RPSControlFactory.RPSCreateCollectionWithGrid<ACCTransactionsDetailServiceMaintenanceConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView>,ACCTransactionsDetailView,ACCTransactionsAnalyticView>( params_ACCTransactionsDetailServiceMaintenanceConsult,this,Screen.ACCTransactionsAnalyticView);
 
            CollectionInit params_ACCTransactionsDetailServiceWarehouseMovementConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="092d8dfa-ec34-4e4a-9335-5af80de9229f",CSSSelectorGrid="",XPathGrid=""};
            ACCTransactionsDetailServiceWarehouseMovementConsult = RPSControlFactory.RPSCreateCollectionWithGrid<ACCTransactionsDetailServiceWarehouseMovementConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView>,ACCTransactionsDetailView,ACCTransactionsAnalyticView>( params_ACCTransactionsDetailServiceWarehouseMovementConsult,this,Screen.ACCTransactionsAnalyticView);
 
            CollectionInit params_ACCTransactionsDetailServiceFADepreciationConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="49687212-cdab-4c0b-9b3d-507e23d5459d",CSSSelectorGrid="",XPathGrid=""};
            ACCTransactionsDetailServiceFADepreciationConsult = RPSControlFactory.RPSCreateCollectionWithGrid<ACCTransactionsDetailServiceFADepreciationConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView>,ACCTransactionsDetailView,ACCTransactionsAnalyticView>( params_ACCTransactionsDetailServiceFADepreciationConsult,this,Screen.ACCTransactionsAnalyticView);
 
            CollectionInit params_ACCTransactionsDetailServiceFADisposalConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1733c66a-44e2-4dbf-b353-51de0beef732",CSSSelectorGrid="",XPathGrid=""};
            ACCTransactionsDetailServiceFADisposalConsult = RPSControlFactory.RPSCreateCollectionWithGrid<ACCTransactionsDetailServiceFADisposalConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView>,ACCTransactionsDetailView,ACCTransactionsAnalyticView>( params_ACCTransactionsDetailServiceFADisposalConsult,this,Screen.ACCTransactionsAnalyticView);
 
            CollectionInit params_ACCTransactionsDetailServiceTRASheetConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="36469e7a-9175-48af-993b-4afaec8ef1e4",CSSSelectorGrid="",XPathGrid=""};
            ACCTransactionsDetailServiceTRASheetConsult = RPSControlFactory.RPSCreateCollectionWithGrid<ACCTransactionsDetailServiceTRASheetConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView>,ACCTransactionsDetailView,ACCTransactionsAnalyticView>( params_ACCTransactionsDetailServiceTRASheetConsult,this,Screen.ACCTransactionsAnalyticView);
 
            CollectionInit params_ACCTransactionsDetailServiceTRAPaymentConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8def41d0-659a-4d7a-9ddb-5be693bb63ba",CSSSelectorGrid="",XPathGrid=""};
            ACCTransactionsDetailServiceTRAPaymentConsult = RPSControlFactory.RPSCreateCollectionWithGrid<ACCTransactionsDetailServiceTRAPaymentConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView>,ACCTransactionsDetailView,ACCTransactionsAnalyticView>( params_ACCTransactionsDetailServiceTRAPaymentConsult,this,Screen.ACCTransactionsAnalyticView);
 
            SectionGeneral = RPSControlFactory.CreateRPSSection<ACCTransactionsDetailView>( "","ul li[rpsid='e41fec8f-5b48-4b8a-b5bd-6bb1a5659bb3']","",this);
 
            SectionAnalitic = RPSControlFactory.CreateRPSSection<ACCTransactionsDetailView>( "","ul li[rpsid='54ba7dd7-eeec-43ca-bde3-eb2117a33fd6']","",this);
 
            SectionDetailService = RPSControlFactory.CreateRPSSection<ACCTransactionsDetailView>( "","ul li[rpsid='ff85c414-6be5-454e-8336-aa457936b4f1']","",this);
 

        }
        public IRPSButton<ACCTransactionsDetailView> DeleteButton { get; set; } 
        public IRPSButton<ACCTransactionsDetailView,ACCTransactionsEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ACCTransactionsDetailView,ACCTransactionsEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ACCTransactionsDetailView,ACCTransactionsEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<ACCTransactionsDetailView> VoucherNumberLine { get; set; } 
        public IRPSComboBox<ACCTransactionsDetailView> MovementType { get; set; } 
        public IRPSComboBox<ACCTransactionsDetailView> IDItemBankAccountCompany { get; set; } 
        public IRPSComboBox<ACCTransactionsDetailView> IDItemCustomer { get; set; } 
        public IRPSComboBox<ACCTransactionsDetailView> IDItemCustomerMiscellaneous { get; set; } 
        public IRPSComboBox<ACCTransactionsDetailView> IDItemSupplier { get; set; } 
        public IRPSComboBox<ACCTransactionsDetailView> IDItemSupplierMiscellaneous { get; set; } 
        public IRPSComboBox<ACCTransactionsDetailView> IDItemTaxValue { get; set; } 
        public IRPSComboBox<ACCTransactionsDetailView> IDItemVAT { get; set; } 
        public IRPSComboBox<ACCTransactionsDetailView> IDAccount { get; set; } 
        public IRPSComboBox<ACCTransactionsDetailView> SignType { get; set; } 
        public IRPSTextBox<ACCTransactionsDetailView> Amount { get; set; } 
        public IRPSComboBox<ACCTransactionsDetailView> IDCurrency { get; set; } 
        public IRPSTextBox<ACCTransactionsDetailView> AmountCurrency { get; set; } 
        public IRPSTextBox<ACCTransactionsDetailView> Change { get; set; } 
        public IRPSCheckbox<ACCTransactionsDetailView> Reviewed { get; set; } 
        public IRPSTextBox<ACCTransactionsDetailView> VATPercentage { get; set; } 
        public IRPSTextBox<ACCTransactionsDetailView> VATBase { get; set; } 
        public IRPSTextBox<ACCTransactionsDetailView> PercentDeductible { get; set; } 
        public IRPSCheckbox<ACCTransactionsDetailView> ExcludedFromRC { get; set; } 
        public IRPSComboBox<ACCTransactionsDetailView> IDAccConcept { get; set; } 
        public IRPSTextBox<ACCTransactionsDetailView> Extension { get; set; } 
        public IRPSTextBox<ACCTransactionsDetailView> CodInvoice { get; set; } 
        public IRPSComboBox<ACCTransactionsDetailView> UIIDInvoice { get; set; } 
        public IRPSComboBox<ACCTransactionsDetailView> UIIDInvoiceSL { get; set; } 
        public IRPSTextBox<ACCTransactionsDetailView> CheckNumber { get; set; } 
        public IRPSComboBox<ACCTransactionsDetailView> IDLeasing { get; set; } 
        public IRPSTextBox<ACCTransactionsDetailView> UIAccTransactionsTemp { get; set; } 
        public IRPSComboBox<ACCTransactionsDetailView> IDACCTransInvoiceTaxPurchase { get; set; } 
        public IRPSComboBox<ACCTransactionsDetailView> IDACCTransInvoiceTaxSales { get; set; } 
        public IRPSComboBox<ACCTransactionsDetailView> IDACCTransInvoiceVATPurchase { get; set; } 
        public IRPSComboBox<ACCTransactionsDetailView> IDACCTransInvoiceVATSales { get; set; } 
        public IRPSTextBox<ACCTransactionsDetailView> PaidAmount { get; set; } 
        public IRPSComboBox<ACCTransactionsDetailView> PaidType { get; set; } 
        public IRPSTextBox<ACCTransactionsDetailView> PaidExtension { get; set; } 
        public IRPSComboBox<ACCTransactionsDetailView> ReconciliationStatus { get; set; } 
        public IRPSComboBox<ACCTransactionsDetailView> CodCompanyCON { get; set; } 
        public IRPSComboBox<ACCTransactionsDetailView> CodCompanyGR { get; set; } 
        public IRPSComboBox<ACCTransactionsDetailView> IntegrationService { get; set; } 
        public IRPSComboBox<ACCTransactionsDetailView> Source { get; set; } 
        public IRPSButton<ACCTransactionsDetailView> ViewDraftsParentCommandButton { get; set; } 
        public IRPSButton<ACCTransactionsDetailView,AnalyticChildDialogView> AnalyticChildNavigationCommandButton { get; set; } 
        public ACCTransactionsAnalyticsCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView> ACCTransactionsAnalytics { get; set; } 
        public ACCTransactionsDetailServiceCloseProjectConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView> ACCTransactionsDetailServiceCloseProjectConsult { get; set; } 
        public ACCTransactionsDetailServiceDeliveryNoteLineConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView> ACCTransactionsDetailServiceDeliveryNoteLineConsult { get; set; } 
        public ACCTransactionsDetailServiceDeliveryNoteLineSLConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView> ACCTransactionsDetailServiceDeliveryNoteLineSLConsult { get; set; } 
        public ACCTransactionsDetailServiceDraftChangeStatusConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView> ACCTransactionsDetailServiceDraftChangeStatusConsult { get; set; } 
        public ACCTransactionsDetailServiceImputationCostConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView> ACCTransactionsDetailServiceImputationCostConsult { get; set; } 
        public ACCTransactionsDetailServiceImputationCostMOConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView> ACCTransactionsDetailServiceImputationCostMOConsult { get; set; } 
        public ACCTransactionsDetailServiceImputationMaterialConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView> ACCTransactionsDetailServiceImputationMaterialConsult { get; set; } 
        public ACCTransactionsDetailServiceImputationMaterialMOConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView> ACCTransactionsDetailServiceImputationMaterialMOConsult { get; set; } 
        public ACCTransactionsDetailServiceImputationTimeConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView> ACCTransactionsDetailServiceImputationTimeConsult { get; set; } 
        public ACCTransactionsDetailServiceImputationTimeMOConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView> ACCTransactionsDetailServiceImputationTimeMOConsult { get; set; } 
        public ACCTransactionsDetailServiceMaintenanceConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView> ACCTransactionsDetailServiceMaintenanceConsult { get; set; } 
        public ACCTransactionsDetailServiceWarehouseMovementConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView> ACCTransactionsDetailServiceWarehouseMovementConsult { get; set; } 
        public ACCTransactionsDetailServiceFADepreciationConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView> ACCTransactionsDetailServiceFADepreciationConsult { get; set; } 
        public ACCTransactionsDetailServiceFADisposalConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView> ACCTransactionsDetailServiceFADisposalConsult { get; set; } 
        public ACCTransactionsDetailServiceTRASheetConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView> ACCTransactionsDetailServiceTRASheetConsult { get; set; } 
        public ACCTransactionsDetailServiceTRAPaymentConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView> ACCTransactionsDetailServiceTRAPaymentConsult { get; set; } 
        public IRPSSection<ACCTransactionsDetailView> SectionGeneral { get; set; } 
        public IRPSSection<ACCTransactionsDetailView> SectionAnalitic { get; set; } 
        public IRPSSection<ACCTransactionsDetailView> SectionDetailService { get; set; } 
        public ACCTransactions Screen { get; set; }
        public ACCTransactionsDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ACCTransactionsAnalyticsCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView>:RPSCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView> where ACCTransactionsDetailView : class, IView where ACCTransactionsAnalyticView : class, IView
    {
        public  ACCTransactionsAnalyticsGridView<ACCTransactionsDetailView,ACCTransactionsAnalyticView> GridView {get;set;}
    }
    public partial class ACCTransactionsAnalyticsGridView <ACCTransactionsDetailView,ACCTransactionsAnalyticView> :  RPSGridView<ACCTransactionsDetailView,ACCTransactionsAnalyticView> where ACCTransactionsDetailView : class, IView where ACCTransactionsAnalyticView : class, IView
    {
        public ACCTransactionsAnalyticsGridView(ACCTransactionsDetailView currentView,ACCTransactionsAnalyticView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDDimension = RPSControlFactory.CreateRPSGridComboBox<ACCTransactionsDetailView>("","#807d58a4-b8c5-454d-a914-077d4e85b2e7 .ag-row[role='row']@ROWINDEX [col-id='cIDDimension']","",true, this.CurrentView);
 
            IDDimValue = RPSControlFactory.CreateRPSGridComboBox<ACCTransactionsDetailView>("","#807d58a4-b8c5-454d-a914-077d4e85b2e7 .ag-row[role='row']@ROWINDEX [col-id='cIDDimValue']","",true, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<ACCTransactionsDetailView>("","#807d58a4-b8c5-454d-a914-077d4e85b2e7 .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<ACCTransactionsDetailView>("","#807d58a4-b8c5-454d-a914-077d4e85b2e7 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            UIAmountCurrency = RPSControlFactory.CreateRPSGridFormattedTextBox<ACCTransactionsDetailView>("","#807d58a4-b8c5-454d-a914-077d4e85b2e7 .ag-row[role='row']@ROWINDEX [col-id='cUIAmountCurrency']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ACCTransactionsDetailView> IDDimension { get; set; } 
        public IRPSGridComboBox<ACCTransactionsDetailView> IDDimValue { get; set; } 
        public IRPSGridTextBox<ACCTransactionsDetailView> Percentage { get; set; } 
        public IRPSGridTextBox<ACCTransactionsDetailView> Amount { get; set; } 
        public IRPSGridTextBox<ACCTransactionsDetailView> UIAmountCurrency { get; set; } 
                     
    }
 
        public partial class ACCTransactionsDetailServiceCloseProjectConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView>:RPSCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView> where ACCTransactionsDetailView : class, IView where ACCTransactionsAnalyticView : class, IView
    {
        public  ACCTransactionsDetailServiceCloseProjectConsultGridView<ACCTransactionsDetailView,ACCTransactionsAnalyticView> GridView {get;set;}
    }
    public partial class ACCTransactionsDetailServiceCloseProjectConsultGridView <ACCTransactionsDetailView,ACCTransactionsAnalyticView> :  RPSGridView<ACCTransactionsDetailView,ACCTransactionsAnalyticView> where ACCTransactionsDetailView : class, IView where ACCTransactionsAnalyticView : class, IView
    {
        public ACCTransactionsDetailServiceCloseProjectConsultGridView(ACCTransactionsDetailView currentView,ACCTransactionsAnalyticView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Project_RealEndDate = RPSControlFactory.CreateRPSGridTextBox<ACCTransactionsDetailView>("","#d69c2e1c-a35a-4b88-9f60-c3567cdac3d3 .ag-row[role='row']@ROWINDEX [col-id='cProject_RealEndDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ACCTransactionsDetailView> Project_RealEndDate { get; set; } 
                     
    }
 
        public partial class ACCTransactionsDetailServiceDeliveryNoteLineConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView>:RPSCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView> where ACCTransactionsDetailView : class, IView where ACCTransactionsAnalyticView : class, IView
    {
        public  ACCTransactionsDetailServiceDeliveryNoteLineConsultGridView<ACCTransactionsDetailView,ACCTransactionsAnalyticView> GridView {get;set;}
    }
    public partial class ACCTransactionsDetailServiceDeliveryNoteLineConsultGridView <ACCTransactionsDetailView,ACCTransactionsAnalyticView> :  RPSGridView<ACCTransactionsDetailView,ACCTransactionsAnalyticView> where ACCTransactionsDetailView : class, IView where ACCTransactionsAnalyticView : class, IView
    {
        public ACCTransactionsDetailServiceDeliveryNoteLineConsultGridView(ACCTransactionsDetailView currentView,ACCTransactionsAnalyticView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeliveryNote_DeliveryNoteDate = RPSControlFactory.CreateRPSGridTextBox<ACCTransactionsDetailView>("","#bc7d5be0-aa18-43c7-aa5d-61c0b9af5f5d .ag-row[role='row']@ROWINDEX [col-id='cDeliveryNote_DeliveryNoteDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ACCTransactionsDetailView> DeliveryNote_DeliveryNoteDate { get; set; } 
                     
    }
 
        public partial class ACCTransactionsDetailServiceDeliveryNoteLineSLConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView>:RPSCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView> where ACCTransactionsDetailView : class, IView where ACCTransactionsAnalyticView : class, IView
    {
        public  ACCTransactionsDetailServiceDeliveryNoteLineSLConsultGridView<ACCTransactionsDetailView,ACCTransactionsAnalyticView> GridView {get;set;}
    }
    public partial class ACCTransactionsDetailServiceDeliveryNoteLineSLConsultGridView <ACCTransactionsDetailView,ACCTransactionsAnalyticView> :  RPSGridView<ACCTransactionsDetailView,ACCTransactionsAnalyticView> where ACCTransactionsDetailView : class, IView where ACCTransactionsAnalyticView : class, IView
    {
        public ACCTransactionsDetailServiceDeliveryNoteLineSLConsultGridView(ACCTransactionsDetailView currentView,ACCTransactionsAnalyticView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeliveryNoteSL_DeliveryNoteDate = RPSControlFactory.CreateRPSGridTextBox<ACCTransactionsDetailView>("","#cd8482f5-4426-4366-b74e-539345005ff5 .ag-row[role='row']@ROWINDEX [col-id='cDeliveryNoteSL_DeliveryNoteDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ACCTransactionsDetailView> DeliveryNoteSL_DeliveryNoteDate { get; set; } 
                     
    }
 
        public partial class ACCTransactionsDetailServiceDraftChangeStatusConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView>:RPSCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView> where ACCTransactionsDetailView : class, IView where ACCTransactionsAnalyticView : class, IView
    {
        public  ACCTransactionsDetailServiceDraftChangeStatusConsultGridView<ACCTransactionsDetailView,ACCTransactionsAnalyticView> GridView {get;set;}
    }
    public partial class ACCTransactionsDetailServiceDraftChangeStatusConsultGridView <ACCTransactionsDetailView,ACCTransactionsAnalyticView> :  RPSGridView<ACCTransactionsDetailView,ACCTransactionsAnalyticView> where ACCTransactionsDetailView : class, IView where ACCTransactionsAnalyticView : class, IView
    {
        public ACCTransactionsDetailServiceDraftChangeStatusConsultGridView(ACCTransactionsDetailView currentView,ACCTransactionsAnalyticView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            RPTransactions_InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<ACCTransactionsDetailView>("","#d8417355-d63c-4157-93f3-e0e9f1f77980 .ag-row[role='row']@ROWINDEX [col-id='cRPTransactions_InvoiceDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ACCTransactionsDetailView> RPTransactions_InvoiceDate { get; set; } 
                     
    }
 
        public partial class ACCTransactionsDetailServiceImputationCostConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView>:RPSCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView> where ACCTransactionsDetailView : class, IView where ACCTransactionsAnalyticView : class, IView
    {
        public  ACCTransactionsDetailServiceImputationCostConsultGridView<ACCTransactionsDetailView,ACCTransactionsAnalyticView> GridView {get;set;}
    }
    public partial class ACCTransactionsDetailServiceImputationCostConsultGridView <ACCTransactionsDetailView,ACCTransactionsAnalyticView> :  RPSGridView<ACCTransactionsDetailView,ACCTransactionsAnalyticView> where ACCTransactionsDetailView : class, IView where ACCTransactionsAnalyticView : class, IView
    {
        public ACCTransactionsDetailServiceImputationCostConsultGridView(ACCTransactionsDetailView currentView,ACCTransactionsAnalyticView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ImputationCost_ImputationDate = RPSControlFactory.CreateRPSGridTextBox<ACCTransactionsDetailView>("","#83c4ecd9-bcb6-4e42-9811-2defdb616143 .ag-row[role='row']@ROWINDEX [col-id='cImputationCost_ImputationDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ACCTransactionsDetailView> ImputationCost_ImputationDate { get; set; } 
                     
    }
 
        public partial class ACCTransactionsDetailServiceImputationCostMOConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView>:RPSCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView> where ACCTransactionsDetailView : class, IView where ACCTransactionsAnalyticView : class, IView
    {
        public  ACCTransactionsDetailServiceImputationCostMOConsultGridView<ACCTransactionsDetailView,ACCTransactionsAnalyticView> GridView {get;set;}
    }
    public partial class ACCTransactionsDetailServiceImputationCostMOConsultGridView <ACCTransactionsDetailView,ACCTransactionsAnalyticView> :  RPSGridView<ACCTransactionsDetailView,ACCTransactionsAnalyticView> where ACCTransactionsDetailView : class, IView where ACCTransactionsAnalyticView : class, IView
    {
        public ACCTransactionsDetailServiceImputationCostMOConsultGridView(ACCTransactionsDetailView currentView,ACCTransactionsAnalyticView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ImputationCostMO_ImputationDate = RPSControlFactory.CreateRPSGridTextBox<ACCTransactionsDetailView>("","#5eb3b067-344a-4f49-b337-a32a4e9cb935 .ag-row[role='row']@ROWINDEX [col-id='cImputationCostMO_ImputationDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ACCTransactionsDetailView> ImputationCostMO_ImputationDate { get; set; } 
                     
    }
 
        public partial class ACCTransactionsDetailServiceImputationMaterialConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView>:RPSCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView> where ACCTransactionsDetailView : class, IView where ACCTransactionsAnalyticView : class, IView
    {
        public  ACCTransactionsDetailServiceImputationMaterialConsultGridView<ACCTransactionsDetailView,ACCTransactionsAnalyticView> GridView {get;set;}
    }
    public partial class ACCTransactionsDetailServiceImputationMaterialConsultGridView <ACCTransactionsDetailView,ACCTransactionsAnalyticView> :  RPSGridView<ACCTransactionsDetailView,ACCTransactionsAnalyticView> where ACCTransactionsDetailView : class, IView where ACCTransactionsAnalyticView : class, IView
    {
        public ACCTransactionsDetailServiceImputationMaterialConsultGridView(ACCTransactionsDetailView currentView,ACCTransactionsAnalyticView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ImputationMaterial_ImputationDate = RPSControlFactory.CreateRPSGridTextBox<ACCTransactionsDetailView>("","#30fd77be-92d6-49a8-a994-22ffc5c48d5c .ag-row[role='row']@ROWINDEX [col-id='cImputationMaterial_ImputationDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ACCTransactionsDetailView> ImputationMaterial_ImputationDate { get; set; } 
                     
    }
 
        public partial class ACCTransactionsDetailServiceImputationMaterialMOConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView>:RPSCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView> where ACCTransactionsDetailView : class, IView where ACCTransactionsAnalyticView : class, IView
    {
        public  ACCTransactionsDetailServiceImputationMaterialMOConsultGridView<ACCTransactionsDetailView,ACCTransactionsAnalyticView> GridView {get;set;}
    }
    public partial class ACCTransactionsDetailServiceImputationMaterialMOConsultGridView <ACCTransactionsDetailView,ACCTransactionsAnalyticView> :  RPSGridView<ACCTransactionsDetailView,ACCTransactionsAnalyticView> where ACCTransactionsDetailView : class, IView where ACCTransactionsAnalyticView : class, IView
    {
        public ACCTransactionsDetailServiceImputationMaterialMOConsultGridView(ACCTransactionsDetailView currentView,ACCTransactionsAnalyticView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ImputationMaterialMO_ImputationDate = RPSControlFactory.CreateRPSGridTextBox<ACCTransactionsDetailView>("","#d3585bb4-6b35-49c3-831a-87f328c13c6c .ag-row[role='row']@ROWINDEX [col-id='cImputationMaterialMO_ImputationDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ACCTransactionsDetailView> ImputationMaterialMO_ImputationDate { get; set; } 
                     
    }
 
        public partial class ACCTransactionsDetailServiceImputationTimeConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView>:RPSCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView> where ACCTransactionsDetailView : class, IView where ACCTransactionsAnalyticView : class, IView
    {
        public  ACCTransactionsDetailServiceImputationTimeConsultGridView<ACCTransactionsDetailView,ACCTransactionsAnalyticView> GridView {get;set;}
    }
    public partial class ACCTransactionsDetailServiceImputationTimeConsultGridView <ACCTransactionsDetailView,ACCTransactionsAnalyticView> :  RPSGridView<ACCTransactionsDetailView,ACCTransactionsAnalyticView> where ACCTransactionsDetailView : class, IView where ACCTransactionsAnalyticView : class, IView
    {
        public ACCTransactionsDetailServiceImputationTimeConsultGridView(ACCTransactionsDetailView currentView,ACCTransactionsAnalyticView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Imputation_ResourceType = RPSControlFactory.CreateRPSGridTextBox<ACCTransactionsDetailView>("","#169b20f9-33c5-4284-8a3d-61ea6a39d190 .ag-row[role='row']@ROWINDEX [col-id='cImputation_ResourceType']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ACCTransactionsDetailView> Imputation_ResourceType { get; set; } 
                     
    }
 
        public partial class ACCTransactionsDetailServiceImputationTimeMOConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView>:RPSCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView> where ACCTransactionsDetailView : class, IView where ACCTransactionsAnalyticView : class, IView
    {
        public  ACCTransactionsDetailServiceImputationTimeMOConsultGridView<ACCTransactionsDetailView,ACCTransactionsAnalyticView> GridView {get;set;}
    }
    public partial class ACCTransactionsDetailServiceImputationTimeMOConsultGridView <ACCTransactionsDetailView,ACCTransactionsAnalyticView> :  RPSGridView<ACCTransactionsDetailView,ACCTransactionsAnalyticView> where ACCTransactionsDetailView : class, IView where ACCTransactionsAnalyticView : class, IView
    {
        public ACCTransactionsDetailServiceImputationTimeMOConsultGridView(ACCTransactionsDetailView currentView,ACCTransactionsAnalyticView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ImputationMO_ResourceType = RPSControlFactory.CreateRPSGridTextBox<ACCTransactionsDetailView>("","#280dc93d-cb7b-427e-a8c7-909448e85edb .ag-row[role='row']@ROWINDEX [col-id='cImputationMO_ResourceType']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ACCTransactionsDetailView> ImputationMO_ResourceType { get; set; } 
                     
    }
 
        public partial class ACCTransactionsDetailServiceMaintenanceConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView>:RPSCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView> where ACCTransactionsDetailView : class, IView where ACCTransactionsAnalyticView : class, IView
    {
        public  ACCTransactionsDetailServiceMaintenanceConsultGridView<ACCTransactionsDetailView,ACCTransactionsAnalyticView> GridView {get;set;}
    }
    public partial class ACCTransactionsDetailServiceMaintenanceConsultGridView <ACCTransactionsDetailView,ACCTransactionsAnalyticView> :  RPSGridView<ACCTransactionsDetailView,ACCTransactionsAnalyticView> where ACCTransactionsDetailView : class, IView where ACCTransactionsAnalyticView : class, IView
    {
        public ACCTransactionsDetailServiceMaintenanceConsultGridView(ACCTransactionsDetailView currentView,ACCTransactionsAnalyticView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MaintenanceOrder_ClosingDate = RPSControlFactory.CreateRPSGridTextBox<ACCTransactionsDetailView>("","#8d1fb71a-fa4e-4c3a-936f-f437e8a9156b .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceOrder_ClosingDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ACCTransactionsDetailView> MaintenanceOrder_ClosingDate { get; set; } 
                     
    }
 
        public partial class ACCTransactionsDetailServiceWarehouseMovementConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView>:RPSCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView> where ACCTransactionsDetailView : class, IView where ACCTransactionsAnalyticView : class, IView
    {
        public  ACCTransactionsDetailServiceWarehouseMovementConsultGridView<ACCTransactionsDetailView,ACCTransactionsAnalyticView> GridView {get;set;}
    }
    public partial class ACCTransactionsDetailServiceWarehouseMovementConsultGridView <ACCTransactionsDetailView,ACCTransactionsAnalyticView> :  RPSGridView<ACCTransactionsDetailView,ACCTransactionsAnalyticView> where ACCTransactionsDetailView : class, IView where ACCTransactionsAnalyticView : class, IView
    {
        public ACCTransactionsDetailServiceWarehouseMovementConsultGridView(ACCTransactionsDetailView currentView,ACCTransactionsAnalyticView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            WarehouseMovement_MovementDate = RPSControlFactory.CreateRPSGridTextBox<ACCTransactionsDetailView>("","#092d8dfa-ec34-4e4a-9335-5af80de9229f .ag-row[role='row']@ROWINDEX [col-id='cWarehouseMovement_MovementDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ACCTransactionsDetailView> WarehouseMovement_MovementDate { get; set; } 
                     
    }
 
        public partial class ACCTransactionsDetailServiceFADepreciationConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView>:RPSCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView> where ACCTransactionsDetailView : class, IView where ACCTransactionsAnalyticView : class, IView
    {
        public  ACCTransactionsDetailServiceFADepreciationConsultGridView<ACCTransactionsDetailView,ACCTransactionsAnalyticView> GridView {get;set;}
    }
    public partial class ACCTransactionsDetailServiceFADepreciationConsultGridView <ACCTransactionsDetailView,ACCTransactionsAnalyticView> :  RPSGridView<ACCTransactionsDetailView,ACCTransactionsAnalyticView> where ACCTransactionsDetailView : class, IView where ACCTransactionsAnalyticView : class, IView
    {
        public ACCTransactionsDetailServiceFADepreciationConsultGridView(ACCTransactionsDetailView currentView,ACCTransactionsAnalyticView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            FADepPlan_DepreciationDate = RPSControlFactory.CreateRPSGridTextBox<ACCTransactionsDetailView>("","#49687212-cdab-4c0b-9b3d-507e23d5459d .ag-row[role='row']@ROWINDEX [col-id='cFADepPlan_DepreciationDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ACCTransactionsDetailView> FADepPlan_DepreciationDate { get; set; } 
                     
    }
 
        public partial class ACCTransactionsDetailServiceFADisposalConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView>:RPSCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView> where ACCTransactionsDetailView : class, IView where ACCTransactionsAnalyticView : class, IView
    {
        public  ACCTransactionsDetailServiceFADisposalConsultGridView<ACCTransactionsDetailView,ACCTransactionsAnalyticView> GridView {get;set;}
    }
    public partial class ACCTransactionsDetailServiceFADisposalConsultGridView <ACCTransactionsDetailView,ACCTransactionsAnalyticView> :  RPSGridView<ACCTransactionsDetailView,ACCTransactionsAnalyticView> where ACCTransactionsDetailView : class, IView where ACCTransactionsAnalyticView : class, IView
    {
        public ACCTransactionsDetailServiceFADisposalConsultGridView(ACCTransactionsDetailView currentView,ACCTransactionsAnalyticView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            FixedAsset_FADisposeDate = RPSControlFactory.CreateRPSGridTextBox<ACCTransactionsDetailView>("","#1733c66a-44e2-4dbf-b353-51de0beef732 .ag-row[role='row']@ROWINDEX [col-id='cFixedAsset_FADisposeDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ACCTransactionsDetailView> FixedAsset_FADisposeDate { get; set; } 
                     
    }
 
        public partial class ACCTransactionsDetailServiceTRASheetConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView>:RPSCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView> where ACCTransactionsDetailView : class, IView where ACCTransactionsAnalyticView : class, IView
    {
        public  ACCTransactionsDetailServiceTRASheetConsultGridView<ACCTransactionsDetailView,ACCTransactionsAnalyticView> GridView {get;set;}
    }
    public partial class ACCTransactionsDetailServiceTRASheetConsultGridView <ACCTransactionsDetailView,ACCTransactionsAnalyticView> :  RPSGridView<ACCTransactionsDetailView,ACCTransactionsAnalyticView> where ACCTransactionsDetailView : class, IView where ACCTransactionsAnalyticView : class, IView
    {
        public ACCTransactionsDetailServiceTRASheetConsultGridView(ACCTransactionsDetailView currentView,ACCTransactionsAnalyticView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Line = RPSControlFactory.CreateRPSGridFormattedTextBox<ACCTransactionsDetailView>("","#36469e7a-9175-48af-993b-4afaec8ef1e4 .ag-row[role='row']@ROWINDEX [col-id='cLine']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ACCTransactionsDetailView> Line { get; set; } 
                     
    }
 
        public partial class ACCTransactionsDetailServiceTRAPaymentConsultCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView>:RPSCollectionEditor<ACCTransactionsDetailView,ACCTransactionsAnalyticView> where ACCTransactionsDetailView : class, IView where ACCTransactionsAnalyticView : class, IView
    {
        public  ACCTransactionsDetailServiceTRAPaymentConsultGridView<ACCTransactionsDetailView,ACCTransactionsAnalyticView> GridView {get;set;}
    }
    public partial class ACCTransactionsDetailServiceTRAPaymentConsultGridView <ACCTransactionsDetailView,ACCTransactionsAnalyticView> :  RPSGridView<ACCTransactionsDetailView,ACCTransactionsAnalyticView> where ACCTransactionsDetailView : class, IView where ACCTransactionsAnalyticView : class, IView
    {
        public ACCTransactionsDetailServiceTRAPaymentConsultGridView(ACCTransactionsDetailView currentView,ACCTransactionsAnalyticView newView)
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
 
    }
  
            
    public partial class ACCTransactionsAnalyticView : View
    {
        public ACCTransactionsAnalyticView(ACCTransactions screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ACCTransactionsAnalyticView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ACCTransactionsAnalyticView,ACCTransactionsDetailView>( this,Screen.ACCTransactionsDetailView);
 
            BackButton = RPSControlFactory.RPSBackButton<ACCTransactionsAnalyticView,ACCTransactionsDetailView>( this,Screen.ACCTransactionsDetailView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ACCTransactionsAnalyticView,ACCTransactionsDetailView>( this,Screen.ACCTransactionsDetailView);
 
            IDDimension = RPSControlFactory.CreateRPSComboBox<ACCTransactionsAnalyticView>("ca1b18e0-82a1-4158-acd1-f87404777c2a","","",true, this);
 
            IDDimValue = RPSControlFactory.CreateRPSComboBox<ACCTransactionsAnalyticView>("c5ebddc0-a5ba-4cb1-92ce-944c596e30ca","","",true, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<ACCTransactionsAnalyticView>("f7e9055c-0f27-4070-93ce-dc3ace3a533f","","",true, this);
 
            Percentage = RPSControlFactory.CreateRPSFormattedTextBox<ACCTransactionsAnalyticView>("9d4e87bf-07c6-4d70-bf00-d32b968ee342","","",true, this);
 
            UIAmountCurrency = RPSControlFactory.CreateRPSFormattedTextBox<ACCTransactionsAnalyticView>("fcdc98fc-e66f-41e8-b578-7bd659e15733","","",false, this);
 

        }
        public IRPSButton<ACCTransactionsAnalyticView> DeleteButton { get; set; } 
        public IRPSButton<ACCTransactionsAnalyticView,ACCTransactionsDetailView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ACCTransactionsAnalyticView,ACCTransactionsDetailView> BackButton { get; set; } 
        public IRPSAcceptButton<ACCTransactionsAnalyticView,ACCTransactionsDetailView> AcceptButton { get; set; } 
        public IRPSComboBox<ACCTransactionsAnalyticView> IDDimension { get; set; } 
        public IRPSComboBox<ACCTransactionsAnalyticView> IDDimValue { get; set; } 
        public IRPSTextBox<ACCTransactionsAnalyticView> Amount { get; set; } 
        public IRPSTextBox<ACCTransactionsAnalyticView> Percentage { get; set; } 
        public IRPSTextBox<ACCTransactionsAnalyticView> UIAmountCurrency { get; set; } 
        public ACCTransactions Screen { get; set; }
        public ACCTransactionsAnalyticView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DraftsChildDialogView : View
    {
        public DraftsChildDialogView(ACCTransactions screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CodInvoice = RPSControlFactory.CreateRPSTextBox<DraftsChildDialogView>("2c461236-25e5-4157-b873-13752ecd29f8","","",false, this);
 
            InvoiceDate = RPSControlFactory.CreateRPSTextBox<DraftsChildDialogView>("36a4ad9f-8c43-4d85-82eb-d61e44854698","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<DraftsChildDialogView>("59e0f758-1f93-4956-9ac8-82590bec0c2b","","",false, this);
 
            IDSupplierMiscellaneous = RPSControlFactory.CreateRPSComboBox<DraftsChildDialogView>("989325dd-18c7-45f6-9074-1d80bc5dbb2e","","",false, this);
 
            CodInvoice1 = RPSControlFactory.CreateRPSTextBox<DraftsChildDialogView>("6279a235-1887-4fb7-b87c-77b677caae65","","",false, this);
 
            InvoiceDate1 = RPSControlFactory.CreateRPSTextBox<DraftsChildDialogView>("25db7ea1-9cd7-45f5-b6b1-71faf204ed7e","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<DraftsChildDialogView>("bf90c072-cbba-45b4-afa4-0d820b397474","","",false, this);
 
            IDCustomerMiscellaneous = RPSControlFactory.CreateRPSComboBox<DraftsChildDialogView>("9734017d-aa6c-44b6-860c-403736c7552b","","",false, this);
 
            UITotalAmount = RPSControlFactory.CreateRPSFormattedTextBox<DraftsChildDialogView>("fbd9efc1-def3-4d7b-b160-3f34e3826078","","",false, this);
 
            UITotalSumAmount = RPSControlFactory.CreateRPSFormattedTextBox<DraftsChildDialogView>("d7fe46d5-763c-40d1-b65a-88612cd10354","","",false, this);
 
            CollectionInit params_RPTransactionsDataItemCollection = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1a00b99a-907e-426a-b4d7-ac755d15102d",CSSSelectorGrid="",XPathGrid=""};
            RPTransactionsDataItemCollection = RPSControlFactory.RPSCreateCollectionWithGrid<RPTransactionsDataItemCollectionCollectionEditor<DraftsChildDialogView>,DraftsChildDialogView>( params_RPTransactionsDataItemCollection,this);
 

        }
        public IRPSTextBox<DraftsChildDialogView> CodInvoice { get; set; } 
        public IRPSTextBox<DraftsChildDialogView> InvoiceDate { get; set; } 
        public IRPSComboBox<DraftsChildDialogView> IDSupplier { get; set; } 
        public IRPSComboBox<DraftsChildDialogView> IDSupplierMiscellaneous { get; set; } 
        public IRPSTextBox<DraftsChildDialogView> CodInvoice1 { get; set; } 
        public IRPSTextBox<DraftsChildDialogView> InvoiceDate1 { get; set; } 
        public IRPSComboBox<DraftsChildDialogView> IDCustomer { get; set; } 
        public IRPSComboBox<DraftsChildDialogView> IDCustomerMiscellaneous { get; set; } 
        public IRPSTextBox<DraftsChildDialogView> UITotalAmount { get; set; } 
        public IRPSTextBox<DraftsChildDialogView> UITotalSumAmount { get; set; } 
        public RPTransactionsDataItemCollectionCollectionEditor<DraftsChildDialogView> RPTransactionsDataItemCollection { get; set; } 
        public ACCTransactions Screen { get; set; }
        public DraftsChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class RPTransactionsDataItemCollectionCollectionEditor<DraftsChildDialogView>:RPSCollectionEditor<DraftsChildDialogView> where DraftsChildDialogView : class, IView
    {
        public  RPTransactionsDataItemCollectionGridView<DraftsChildDialogView> GridView {get;set;}
    }
    public partial class RPTransactionsDataItemCollectionGridView <DraftsChildDialogView> :  RPSGridView<DraftsChildDialogView> where DraftsChildDialogView : class, IView
    {
        public RPTransactionsDataItemCollectionGridView(DraftsChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDRPTransactions = RPSControlFactory.CreateRPSGridComboBox<DraftsChildDialogView>("","#1a00b99a-907e-426a-b4d7-ac755d15102d .ag-row[role='row']@ROWINDEX [col-id='cIDRPTransactions']","",false, this.CurrentView);
 
            DueDate = RPSControlFactory.CreateRPSGridTextBox<DraftsChildDialogView>("","#1a00b99a-907e-426a-b4d7-ac755d15102d .ag-row[role='row']@ROWINDEX [col-id='cDueDate']","",false, this.CurrentView);
 
            IDPaymentType = RPSControlFactory.CreateRPSGridComboBox<DraftsChildDialogView>("","#1a00b99a-907e-426a-b4d7-ac755d15102d .ag-row[role='row']@ROWINDEX [col-id='cIDPaymentType']","",false, this.CurrentView);
 
            IDPaymentStatus = RPSControlFactory.CreateRPSGridComboBox<DraftsChildDialogView>("","#1a00b99a-907e-426a-b4d7-ac755d15102d .ag-row[role='row']@ROWINDEX [col-id='cIDPaymentStatus']","",false, this.CurrentView);
 
            AmountNominal = RPSControlFactory.CreateRPSGridFormattedTextBox<DraftsChildDialogView>("","#1a00b99a-907e-426a-b4d7-ac755d15102d .ag-row[role='row']@ROWINDEX [col-id='cAmountNominal']","",false, this.CurrentView);
 
            AmountNominalCurrency = RPSControlFactory.CreateRPSGridFormattedTextBox<DraftsChildDialogView>("","#1a00b99a-907e-426a-b4d7-ac755d15102d .ag-row[role='row']@ROWINDEX [col-id='cAmountNominalCurrency']","",false, this.CurrentView);
 
            Nullified = RPSControlFactory.CreateRPSGridCheckBox<DraftsChildDialogView>("","#1a00b99a-907e-426a-b4d7-ac755d15102d .ag-row[role='row']@ROWINDEX [col-id='cNullified']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<DraftsChildDialogView> IDRPTransactions { get; set; } 
        public IRPSGridTextBox<DraftsChildDialogView> DueDate { get; set; } 
        public IRPSGridComboBox<DraftsChildDialogView> IDPaymentType { get; set; } 
        public IRPSGridComboBox<DraftsChildDialogView> IDPaymentStatus { get; set; } 
        public IRPSGridTextBox<DraftsChildDialogView> AmountNominal { get; set; } 
        public IRPSGridTextBox<DraftsChildDialogView> AmountNominalCurrency { get; set; } 
        public IRPSGridCheckbox<DraftsChildDialogView> Nullified { get; set; } 
                     
    }
 
    }
  
            
    public partial class DUAChildDialogView : View
    {
        public DUAChildDialogView(ACCTransactions screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDSupplier = RPSControlFactory.CreateRPSComboBox<DUAChildDialogView>("88c5ad40-90d4-4e9f-aa57-e12c00f3f2da","","",true, this);
 
            DUADate = RPSControlFactory.CreateRPSTextBox<DUAChildDialogView>("f37b6373-8965-4302-9d40-2b6b28b4985f","","",true, this);
 
            DUANumber = RPSControlFactory.CreateRPSTextBox<DUAChildDialogView>("1f4fe1a1-642a-4be8-b520-ff491dc40c75","","",true, this);
 
            DUAGroup = RPSControlFactory.CreateRPSTextBox<DUAChildDialogView>("d31b6120-70ed-4269-a2e6-ba6d5eadc741","","",true, this);
 
            DUAVATBase = RPSControlFactory.CreateRPSFormattedTextBox<DUAChildDialogView>("3113c3b9-faf4-4ea2-9b9d-81bead472f82","","",true, this);
 
            DUAIDVAT = RPSControlFactory.CreateRPSComboBox<DUAChildDialogView>("ae0c2f72-608d-430c-a276-145361d44608","","",true, this);
 
            Cuota = RPSControlFactory.CreateRPSFormattedTextBox<DUAChildDialogView>("a45e6a0a-64ab-4535-a926-fc5cb10fc2e2","","",false, this);
 
            IDVoucherType = RPSControlFactory.CreateRPSComboBox<DUAChildDialogView>("e1d070f3-a5a1-4023-b693-e2833c5e329c","","",true, this);
 
            IDVoucherSeriesBook = RPSControlFactory.CreateRPSComboBox<DUAChildDialogView>("8debc1f6-58c9-4b67-af9e-4c776e52736e","","",true, this);
 
            DUAIDAccount = RPSControlFactory.CreateRPSComboBox<DUAChildDialogView>("082fe575-8bdf-4476-9c8a-c437df8fb732","","",true, this);
 
            DUAAccountingDate = RPSControlFactory.CreateRPSTextBox<DUAChildDialogView>("7113725d-30d2-4bb0-bdab-249ca959e9c9","","",true, this);
 

        }
        public IRPSComboBox<DUAChildDialogView> IDSupplier { get; set; } 
        public IRPSTextBox<DUAChildDialogView> DUADate { get; set; } 
        public IRPSTextBox<DUAChildDialogView> DUANumber { get; set; } 
        public IRPSTextBox<DUAChildDialogView> DUAGroup { get; set; } 
        public IRPSTextBox<DUAChildDialogView> DUAVATBase { get; set; } 
        public IRPSComboBox<DUAChildDialogView> DUAIDVAT { get; set; } 
        public IRPSTextBox<DUAChildDialogView> Cuota { get; set; } 
        public IRPSComboBox<DUAChildDialogView> IDVoucherType { get; set; } 
        public IRPSComboBox<DUAChildDialogView> IDVoucherSeriesBook { get; set; } 
        public IRPSComboBox<DUAChildDialogView> DUAIDAccount { get; set; } 
        public IRPSTextBox<DUAChildDialogView> DUAAccountingDate { get; set; } 
        public ACCTransactions Screen { get; set; }
        public DUAChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class AccTransacionsDUAChildDialogView : View
    {
        public AccTransacionsDUAChildDialogView(ACCTransactions screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDSupplier = RPSControlFactory.CreateRPSComboBox<AccTransacionsDUAChildDialogView>("9b02dd99-e7cb-4e3d-87a2-b8a5a89c4ef2","","",true, this);
 
            DUADate = RPSControlFactory.CreateRPSTextBox<AccTransacionsDUAChildDialogView>("833a3511-d4f8-4048-890d-2656d780bc6b","","",true, this);
 
            DUANumber = RPSControlFactory.CreateRPSTextBox<AccTransacionsDUAChildDialogView>("c6509ce6-bc0e-41bc-9cef-28fe935808e5","","",true, this);
 
            DUAGroup = RPSControlFactory.CreateRPSTextBox<AccTransacionsDUAChildDialogView>("1ae4e85a-0711-41f7-ad30-9e6bf01dde79","","",true, this);
 
            DUAVATBase = RPSControlFactory.CreateRPSFormattedTextBox<AccTransacionsDUAChildDialogView>("095758a4-d3bb-4338-8d35-77e15ea379bc","","",true, this);
 
            DUAIDVAT = RPSControlFactory.CreateRPSComboBox<AccTransacionsDUAChildDialogView>("cba687e8-2142-455c-ba9f-dcf784661add","","",true, this);
 
            Cuota = RPSControlFactory.CreateRPSFormattedTextBox<AccTransacionsDUAChildDialogView>("c9a85afb-f0af-4684-baa9-295f1be2b439","","",false, this);
 
            IDVoucherType = RPSControlFactory.CreateRPSComboBox<AccTransacionsDUAChildDialogView>("60fd34b9-6a9c-41d5-9eb2-1888ac19b6cc","","",true, this);
 
            IDVoucherSeriesBook = RPSControlFactory.CreateRPSComboBox<AccTransacionsDUAChildDialogView>("682888b7-cfd2-489b-a5f3-e845221d9e9b","","",true, this);
 
            DUAIDAccount = RPSControlFactory.CreateRPSComboBox<AccTransacionsDUAChildDialogView>("6e76db58-e2dd-417d-b8b0-50054d0f7592","","",true, this);
 
            DUAAccountingDate = RPSControlFactory.CreateRPSTextBox<AccTransacionsDUAChildDialogView>("1dcb2e9f-c673-4272-a16f-4b3d35929136","","",true, this);
 

        }
        public IRPSComboBox<AccTransacionsDUAChildDialogView> IDSupplier { get; set; } 
        public IRPSTextBox<AccTransacionsDUAChildDialogView> DUADate { get; set; } 
        public IRPSTextBox<AccTransacionsDUAChildDialogView> DUANumber { get; set; } 
        public IRPSTextBox<AccTransacionsDUAChildDialogView> DUAGroup { get; set; } 
        public IRPSTextBox<AccTransacionsDUAChildDialogView> DUAVATBase { get; set; } 
        public IRPSComboBox<AccTransacionsDUAChildDialogView> DUAIDVAT { get; set; } 
        public IRPSTextBox<AccTransacionsDUAChildDialogView> Cuota { get; set; } 
        public IRPSComboBox<AccTransacionsDUAChildDialogView> IDVoucherType { get; set; } 
        public IRPSComboBox<AccTransacionsDUAChildDialogView> IDVoucherSeriesBook { get; set; } 
        public IRPSComboBox<AccTransacionsDUAChildDialogView> DUAIDAccount { get; set; } 
        public IRPSTextBox<AccTransacionsDUAChildDialogView> DUAAccountingDate { get; set; } 
        public ACCTransactions Screen { get; set; }
        public AccTransacionsDUAChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class VoucherTemplateChildDialogView : View
    {
        public VoucherTemplateChildDialogView(ACCTransactions screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDVoucherTemplate = RPSControlFactory.CreateRPSComboBox<VoucherTemplateChildDialogView>("a4f5f4a7-7511-4b74-be36-e170195a840c","","",false, this);
 
            IDVoucherType = RPSControlFactory.CreateRPSComboBox<VoucherTemplateChildDialogView>("970ebf69-cae7-4157-b5d0-72d5ab86fafe","","",true, this);
 
            IDVoucherSeriesBook = RPSControlFactory.CreateRPSComboBox<VoucherTemplateChildDialogView>("b079d54d-6434-41d9-8a9a-9bc62fcd081b","","",true, this);
 
            AccountingDate = RPSControlFactory.CreateRPSTextBox<VoucherTemplateChildDialogView>("872276c6-b423-4dcf-b31f-64a1ca489757","","",true, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<VoucherTemplateChildDialogView>("4019987f-5f93-46d2-b1c0-e25f74670e55","","",false, this);
 
            IDSupplierMiscellaneous = RPSControlFactory.CreateRPSComboBox<VoucherTemplateChildDialogView>("44f32e8f-ac8c-4e25-8861-43d4d57cdf91","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<VoucherTemplateChildDialogView>("ed8099c8-6fc3-42e2-ac8e-72e211454f69","","",false, this);
 
            IDCustomerMiscellaneousSL = RPSControlFactory.CreateRPSComboBox<VoucherTemplateChildDialogView>("29f0275e-8ed3-4700-acd4-a4506cbca822","","",false, this);
 
            InvoiceDate = RPSControlFactory.CreateRPSTextBox<VoucherTemplateChildDialogView>("7710a65e-de36-4d1c-8738-7839362b9f1f","","",false, this);
 
            CodInvoice = RPSControlFactory.CreateRPSTextBox<VoucherTemplateChildDialogView>("4fb5600a-d297-4239-9f33-5197f2fab627","","",false, this);
 
            DeliveryNoteDate = RPSControlFactory.CreateRPSTextBox<VoucherTemplateChildDialogView>("a563b213-bb11-41cf-8540-030f16cc88be","","",false, this);
 
            CodDeliveryNote = RPSControlFactory.CreateRPSTextBox<VoucherTemplateChildDialogView>("d7b5d8c0-67e4-43a5-a1db-6c191fdd1212","","",false, this);
 
            Renting = RPSControlFactory.CreateRPSCheckBox<VoucherTemplateChildDialogView>("c71dbd83-1d01-411e-b6d2-623a04dc9ccd","","",false, this);
 
            IDFixedAsset = RPSControlFactory.CreateRPSComboBox<VoucherTemplateChildDialogView>("469237be-b5a4-4544-b285-9497388775ae","","",false, this);
 
            IDEUInvoice = RPSControlFactory.CreateRPSComboBox<VoucherTemplateChildDialogView>("2f086b3a-2de5-4dd5-b301-0106a6c2a7cf","","",false, this);
 
            RecalculateCommand = RPSControlFactory.CreateRPSButton<VoucherTemplateChildDialogView>( "31bd6741-16db-4459-8cdd-cee1c4f188b8","","",this);
 
            IDPostingBankDef = RPSControlFactory.CreateRPSComboBox<VoucherTemplateChildDialogView>("93fd063e-2221-4e33-88ec-16c8f5f51298","","",false, this);
 
            IDPostingVATDef = RPSControlFactory.CreateRPSComboBox<VoucherTemplateChildDialogView>("d35d7c9d-e75a-4adc-89fd-46f77f08936e","","",false, this);
 
            IDPostingCustomerDef = RPSControlFactory.CreateRPSComboBox<VoucherTemplateChildDialogView>("86cd8c48-02de-4f0a-bf66-0dbbbe4a6280","","",false, this);
 
            IDPostingCustomerMiscellaneousDef = RPSControlFactory.CreateRPSComboBox<VoucherTemplateChildDialogView>("bb2b22ec-aa1b-4ec9-b44f-eb26e96b244b","","",false, this);
 
            IDPostingSupplierDef = RPSControlFactory.CreateRPSComboBox<VoucherTemplateChildDialogView>("d3f355b9-6300-48bd-a04a-33c5672d5ddd","","",false, this);
 
            IDPostingSupplierMiscellaneousDef = RPSControlFactory.CreateRPSComboBox<VoucherTemplateChildDialogView>("74c41680-0964-432c-af78-65723451365f","","",false, this);
 
            IDPostingTAXDef = RPSControlFactory.CreateRPSComboBox<VoucherTemplateChildDialogView>("82c3ed77-f792-4601-9227-fb5ac02243e5","","",false, this);
 
            IDAccountDef = RPSControlFactory.CreateRPSComboBox<VoucherTemplateChildDialogView>("47c19588-c48f-414d-ad40-6ec33ca05727","","",false, this);
 
            AmountFormulaRes = RPSControlFactory.CreateRPSFormattedTextBox<VoucherTemplateChildDialogView>("883e6028-cada-4777-9d20-3c083ee67a6a","","",false, this);
 
            IDAccConceptDef = RPSControlFactory.CreateRPSComboBox<VoucherTemplateChildDialogView>("1690e9e9-07ac-4b1d-97c3-e42ad1aa92b3","","",false, this);
 
            ExtensionFormulaDef = RPSControlFactory.CreateRPSTextBox<VoucherTemplateChildDialogView>("5bf782bb-abfa-41de-ba92-cc6fc869aa82","","",false, this);
 
            CollectionInit params_VoucherTemplateDetailConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a712dd86-2620-4bfd-b71b-c061007ffe0e",CSSSelectorGrid="",XPathGrid=""};
            VoucherTemplateDetailConsult = RPSControlFactory.RPSCreateCollectionWithGrid<VoucherTemplateDetailConsultCollectionEditor<VoucherTemplateChildDialogView>,VoucherTemplateChildDialogView>( params_VoucherTemplateDetailConsult,this);
 
            CollectionInit params_VoucherTemplateDetailConsult1 = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f25364b4-4704-4cc5-ab4b-4215bf3fd710",CSSSelectorGrid="",XPathGrid=""};
            VoucherTemplateDetailConsult1 = RPSControlFactory.RPSCreateCollectionWithGrid<VoucherTemplateDetailConsultCollectionEditor<VoucherTemplateChildDialogView>,VoucherTemplateChildDialogView>( params_VoucherTemplateDetailConsult1,this);
 

        }
        public IRPSComboBox<VoucherTemplateChildDialogView> IDVoucherTemplate { get; set; } 
        public IRPSComboBox<VoucherTemplateChildDialogView> IDVoucherType { get; set; } 
        public IRPSComboBox<VoucherTemplateChildDialogView> IDVoucherSeriesBook { get; set; } 
        public IRPSTextBox<VoucherTemplateChildDialogView> AccountingDate { get; set; } 
        public IRPSComboBox<VoucherTemplateChildDialogView> IDSupplier { get; set; } 
        public IRPSComboBox<VoucherTemplateChildDialogView> IDSupplierMiscellaneous { get; set; } 
        public IRPSComboBox<VoucherTemplateChildDialogView> IDCustomer { get; set; } 
        public IRPSComboBox<VoucherTemplateChildDialogView> IDCustomerMiscellaneousSL { get; set; } 
        public IRPSTextBox<VoucherTemplateChildDialogView> InvoiceDate { get; set; } 
        public IRPSTextBox<VoucherTemplateChildDialogView> CodInvoice { get; set; } 
        public IRPSTextBox<VoucherTemplateChildDialogView> DeliveryNoteDate { get; set; } 
        public IRPSTextBox<VoucherTemplateChildDialogView> CodDeliveryNote { get; set; } 
        public IRPSCheckbox<VoucherTemplateChildDialogView> Renting { get; set; } 
        public IRPSComboBox<VoucherTemplateChildDialogView> IDFixedAsset { get; set; } 
        public IRPSComboBox<VoucherTemplateChildDialogView> IDEUInvoice { get; set; } 
        public IRPSButton<VoucherTemplateChildDialogView> RecalculateCommand { get; set; } 
        public IRPSComboBox<VoucherTemplateChildDialogView> IDPostingBankDef { get; set; } 
        public IRPSComboBox<VoucherTemplateChildDialogView> IDPostingVATDef { get; set; } 
        public IRPSComboBox<VoucherTemplateChildDialogView> IDPostingCustomerDef { get; set; } 
        public IRPSComboBox<VoucherTemplateChildDialogView> IDPostingCustomerMiscellaneousDef { get; set; } 
        public IRPSComboBox<VoucherTemplateChildDialogView> IDPostingSupplierDef { get; set; } 
        public IRPSComboBox<VoucherTemplateChildDialogView> IDPostingSupplierMiscellaneousDef { get; set; } 
        public IRPSComboBox<VoucherTemplateChildDialogView> IDPostingTAXDef { get; set; } 
        public IRPSComboBox<VoucherTemplateChildDialogView> IDAccountDef { get; set; } 
        public IRPSTextBox<VoucherTemplateChildDialogView> AmountFormulaRes { get; set; } 
        public IRPSComboBox<VoucherTemplateChildDialogView> IDAccConceptDef { get; set; } 
        public IRPSTextBox<VoucherTemplateChildDialogView> ExtensionFormulaDef { get; set; } 
        public VoucherTemplateDetailConsultCollectionEditor<VoucherTemplateChildDialogView> VoucherTemplateDetailConsult { get; set; } 
        public VoucherTemplateDetailConsultCollectionEditor<VoucherTemplateChildDialogView> VoucherTemplateDetailConsult1 { get; set; } 
        public ACCTransactions Screen { get; set; }
        public VoucherTemplateChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class VoucherTemplateDetailConsultCollectionEditor<VoucherTemplateChildDialogView>:RPSCollectionEditor<VoucherTemplateChildDialogView> where VoucherTemplateChildDialogView : class, IView
    {
        public  VoucherTemplateDetailConsultGridView<VoucherTemplateChildDialogView> GridView {get;set;}
    }
    public partial class VoucherTemplateDetailConsultGridView <VoucherTemplateChildDialogView> :  RPSGridView<VoucherTemplateChildDialogView> where VoucherTemplateChildDialogView : class, IView
    {
        public VoucherTemplateDetailConsultGridView(VoucherTemplateChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            VoucherTemplateNumberLineString = RPSControlFactory.CreateRPSGridTextBox<VoucherTemplateChildDialogView>("","#a712dd86-2620-4bfd-b71b-c061007ffe0e .ag-row[role='row']@ROWINDEX [col-id='cVoucherTemplateNumberLineString']","",false, this.CurrentView);
 
            MovementType = RPSControlFactory.CreateRPSGridTextBox<VoucherTemplateChildDialogView>("","#a712dd86-2620-4bfd-b71b-c061007ffe0e .ag-row[role='row']@ROWINDEX [col-id='cMovementType']","",false, this.CurrentView);
 
            AmountResGrid = RPSControlFactory.CreateRPSGridFormattedTextBox<VoucherTemplateChildDialogView>("","#a712dd86-2620-4bfd-b71b-c061007ffe0e .ag-row[role='row']@ROWINDEX [col-id='cAmountResGrid']","",false, this.CurrentView);
 
            SignType = RPSControlFactory.CreateRPSGridTextBox<VoucherTemplateChildDialogView>("","#a712dd86-2620-4bfd-b71b-c061007ffe0e .ag-row[role='row']@ROWINDEX [col-id='cSignType']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<VoucherTemplateChildDialogView> VoucherTemplateNumberLineString { get; set; } 
        public IRPSGridTextBox<VoucherTemplateChildDialogView> MovementType { get; set; } 
        public IRPSGridTextBox<VoucherTemplateChildDialogView> AmountResGrid { get; set; } 
        public IRPSGridTextBox<VoucherTemplateChildDialogView> SignType { get; set; } 
                     
    }
 
    }
  
            
    public partial class AnalyticChildDialogView : View
    {
        public AnalyticChildDialogView(ACCTransactions screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDAccount = RPSControlFactory.CreateRPSComboBox<AnalyticChildDialogView>("41bc0574-7736-4fd4-bc60-b4877d068e47","","",true, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<AnalyticChildDialogView>("882fe9a6-2106-47b0-987a-656d70d0ca42","","",true, this);
 
            CollectionInit params_ACCTransactionsAnalytics = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="380e9e38-0e42-43ff-8213-ec4a808cae01",CSSSelectorGrid="",XPathGrid=""};
            ACCTransactionsAnalytics = RPSControlFactory.RPSCreateCollectionWithGrid<ACCTransactionsAnalyticsCollectionEditor<AnalyticChildDialogView>,AnalyticChildDialogView>( params_ACCTransactionsAnalytics,this);
 

        }
        public IRPSComboBox<AnalyticChildDialogView> IDAccount { get; set; } 
        public IRPSTextBox<AnalyticChildDialogView> Amount { get; set; } 
        public ACCTransactionsAnalyticsCollectionEditor<AnalyticChildDialogView> ACCTransactionsAnalytics { get; set; } 
        public ACCTransactions Screen { get; set; }
        public AnalyticChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ACCTransactionsAnalyticsCollectionEditor<AnalyticChildDialogView>:RPSCollectionEditor<AnalyticChildDialogView> where AnalyticChildDialogView : class, IView
    {
        public  ACCTransactionsAnalyticsGridView<AnalyticChildDialogView> GridView {get;set;}
    }
    public partial class ACCTransactionsAnalyticsGridView <AnalyticChildDialogView> :  RPSGridView<AnalyticChildDialogView> where AnalyticChildDialogView : class, IView
    {
        public ACCTransactionsAnalyticsGridView(AnalyticChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDDimension = RPSControlFactory.CreateRPSGridComboBox<AnalyticChildDialogView>("","#380e9e38-0e42-43ff-8213-ec4a808cae01 .ag-row[role='row']@ROWINDEX [col-id='cIDDimension']","",true, this.CurrentView);
 
            IDDimValue = RPSControlFactory.CreateRPSGridComboBox<AnalyticChildDialogView>("","#380e9e38-0e42-43ff-8213-ec4a808cae01 .ag-row[role='row']@ROWINDEX [col-id='cIDDimValue']","",true, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<AnalyticChildDialogView>("","#380e9e38-0e42-43ff-8213-ec4a808cae01 .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<AnalyticChildDialogView>("","#380e9e38-0e42-43ff-8213-ec4a808cae01 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<AnalyticChildDialogView> IDDimension { get; set; } 
        public IRPSGridComboBox<AnalyticChildDialogView> IDDimValue { get; set; } 
        public IRPSGridTextBox<AnalyticChildDialogView> Percentage { get; set; } 
        public IRPSGridTextBox<AnalyticChildDialogView> Amount { get; set; } 
                     
    }
 
    }
  
            
    public partial class NewPurchaseInvoiceDialogView : View
    {
        public NewPurchaseInvoiceDialogView(ACCTransactions screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UISupplier = RPSControlFactory.CreateRPSComboBox<NewPurchaseInvoiceDialogView>("249972b0-9433-4ea1-be18-8f9c8e6e769d","","",true, this);
 
            UISupplierMiscellaneous = RPSControlFactory.CreateRPSComboBox<NewPurchaseInvoiceDialogView>("64a1563f-73d1-40d2-bb67-95b128dd59f7","","",true, this);
 
            UICodInvoice = RPSControlFactory.CreateRPSTextBox<NewPurchaseInvoiceDialogView>("4161f93f-8217-4be8-aace-6d58ac94205c","","",true, this);
 
            UIInvoiceDate = RPSControlFactory.CreateRPSTextBox<NewPurchaseInvoiceDialogView>("cf66cc2a-99b9-45a0-838d-c66a0cd01c63","","",true, this);
 
            UIAccountingDate = RPSControlFactory.CreateRPSTextBox<NewPurchaseInvoiceDialogView>("c9acae2d-1625-44f9-8331-bedf2a1959a8","","",true, this);
 
            UITotalAmount = RPSControlFactory.CreateRPSFormattedTextBox<NewPurchaseInvoiceDialogView>("3e2f8ecd-c4cf-4443-a1f8-fb7c46e7eee7","","",false, this);
 
            UICurrency = RPSControlFactory.CreateRPSComboBox<NewPurchaseInvoiceDialogView>("b79c5f51-ab9c-461c-8aec-e0792f86f0e8","","",true, this);
 
            UIVAT = RPSControlFactory.CreateRPSComboBox<NewPurchaseInvoiceDialogView>("374240f9-43d0-46d2-bdc4-9cbc7598722c","","",true, this);
 
            UIAccount = RPSControlFactory.CreateRPSComboBox<NewPurchaseInvoiceDialogView>("334a4e15-e5d4-423f-be3e-d8dbfd8a28f3","","",true, this);
 
            UIVoucherType = RPSControlFactory.CreateRPSComboBox<NewPurchaseInvoiceDialogView>("79caf469-bed8-4319-9d0a-0b99ca578a3e","","",true, this);
 
            UIVoucherSeriesBook = RPSControlFactory.CreateRPSComboBox<NewPurchaseInvoiceDialogView>("04b93a45-6dcc-4379-8e2e-0e5ab3773168","","",true, this);
 
            UIEUInvoice = RPSControlFactory.CreateRPSComboBox<NewPurchaseInvoiceDialogView>("8d719a37-7a68-43b4-a554-8a1e724974b6","","",false, this);
 
            UIPaymentMethod = RPSControlFactory.CreateRPSComboBox<NewPurchaseInvoiceDialogView>("75ba036c-b0ac-404a-870f-5e8563042729","","",true, this);
 

        }
        public IRPSComboBox<NewPurchaseInvoiceDialogView> UISupplier { get; set; } 
        public IRPSComboBox<NewPurchaseInvoiceDialogView> UISupplierMiscellaneous { get; set; } 
        public IRPSTextBox<NewPurchaseInvoiceDialogView> UICodInvoice { get; set; } 
        public IRPSTextBox<NewPurchaseInvoiceDialogView> UIInvoiceDate { get; set; } 
        public IRPSTextBox<NewPurchaseInvoiceDialogView> UIAccountingDate { get; set; } 
        public IRPSTextBox<NewPurchaseInvoiceDialogView> UITotalAmount { get; set; } 
        public IRPSComboBox<NewPurchaseInvoiceDialogView> UICurrency { get; set; } 
        public IRPSComboBox<NewPurchaseInvoiceDialogView> UIVAT { get; set; } 
        public IRPSComboBox<NewPurchaseInvoiceDialogView> UIAccount { get; set; } 
        public IRPSComboBox<NewPurchaseInvoiceDialogView> UIVoucherType { get; set; } 
        public IRPSComboBox<NewPurchaseInvoiceDialogView> UIVoucherSeriesBook { get; set; } 
        public IRPSComboBox<NewPurchaseInvoiceDialogView> UIEUInvoice { get; set; } 
        public IRPSComboBox<NewPurchaseInvoiceDialogView> UIPaymentMethod { get; set; } 
        public ACCTransactions Screen { get; set; }
        public NewPurchaseInvoiceDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}