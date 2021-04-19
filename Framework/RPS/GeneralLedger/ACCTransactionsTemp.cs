    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.ACCTransactionsTemp
{
    //RPS VERSION 1.0.0.0
    public partial class ACCTransactionsTemp:Screen
    {
        public ACCTransactionsTemp():base()
        {
            this.URL = "generalledger.acctransactionstemp";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ACCTransactionsTempVMQueryView  = new ACCTransactionsTempVMQueryView(this); 
            ACCTransactionsTempVMEntityView  = new ACCTransactionsTempVMEntityView(this); 
            ACCTransactionsTempDetailView  = new ACCTransactionsTempDetailView(this); 
            ACCTransactionsTempAnalyticView  = new ACCTransactionsTempAnalyticView(this); 
            GenerateChildDialogView  = new GenerateChildDialogView(this); 
            TransferChildDialogView  = new TransferChildDialogView(this); 
            TrasnferChildSmallDialogView  = new TrasnferChildSmallDialogView(this); 
            ACCTransactionsTempVMQueryView.InitializeControls(); 
            ACCTransactionsTempVMEntityView.InitializeControls(); 
            ACCTransactionsTempDetailView.InitializeControls(); 
            ACCTransactionsTempAnalyticView.InitializeControls(); 
            GenerateChildDialogView.InitializeControls(); 
            TransferChildDialogView.InitializeControls(); 
            TrasnferChildSmallDialogView.InitializeControls(); 
           
        }
      
            public ACCTransactionsTempVMQueryView ACCTransactionsTempVMQueryView {get; set; } 
            public ACCTransactionsTempVMEntityView ACCTransactionsTempVMEntityView {get; set; } 
            public ACCTransactionsTempDetailView ACCTransactionsTempDetailView {get; set; } 
            public ACCTransactionsTempAnalyticView ACCTransactionsTempAnalyticView {get; set; } 
            public GenerateChildDialogView GenerateChildDialogView {get; set; } 
            public TransferChildDialogView TransferChildDialogView {get; set; } 
            public TrasnferChildSmallDialogView TrasnferChildSmallDialogView {get; set; } 
    }
            
    public partial class ACCTransactionsTempVMQueryView : View
    {
        public ACCTransactionsTempVMQueryView(ACCTransactionsTemp screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ACCTransactionsTempVMQueryView,ACCTransactionsTempVMEntityView>( this,Screen.ACCTransactionsTempVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<ACCTransactionsTempVMQueryView>( this);
 
            eService = RPSControlFactory.CreateRPSEnumComboBox<ACCTransactionsTempVMQueryView>("82d7b14d-e911-49b4-a967-00521949dcc5","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<ACCTransactionsTempVMQueryView>("f4112f3e-ab48-4ca1-876e-801b9f6b6741","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<ACCTransactionsTempVMQueryView>("e9be9e01-a28e-4e1e-8dc3-9ff04a76f491","","",false, this);
 
            CodInvoice = RPSControlFactory.CreateRPSTextBox<ACCTransactionsTempVMQueryView>("01f73bca-7ea4-4e1b-88c6-056a324e7f16","","",false, this);
 
            AccountingDate = RPSControlFactory.CreateRPSTextBox<ACCTransactionsTempVMQueryView>("ff5299b4-7e20-4fee-94e3-092ba4df6a97","","",false, this);
 
            TransferCommandButton = RPSControlFactory.CreateRPSButton<ACCTransactionsTempVMQueryView>( "1f6bb5d2-6b3d-41e4-a94d-a47c2193fcbf","","",this);
 
            GenerateChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ACCTransactionsTempVMQueryView,GenerateChildDialogView>("4abc27a2-ba72-483c-820e-0ab6d7784017","","", this,Screen.GenerateChildDialogView);
 
            CollectionInit params_ACCTransactionsTempConsult = new CollectionInit(){IDDescriptor = "50f8eeb2-f71a-49a5-9c7b-331023446b17",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="141075f5-5ed0-46a6-bafa-6f34bf8a3e43",CSSSelectorGrid="",XPathGrid=""};
            ACCTransactionsTempConsult = RPSControlFactory.RPSCreateCollectionWithGrid<ACCTransactionsTempConsultCollectionEditor<ACCTransactionsTempVMQueryView,ACCTransactionsTempVMEntityView>,ACCTransactionsTempVMQueryView,ACCTransactionsTempVMEntityView>( params_ACCTransactionsTempConsult,this,Screen.ACCTransactionsTempVMEntityView);
 

        }
        public IRPSButton<ACCTransactionsTempVMQueryView,ACCTransactionsTempVMEntityView> NewButton { get; set; } 
        public IRPSButton<ACCTransactionsTempVMQueryView> ConsultButton { get; set; } 
        public IRPSComboBox<ACCTransactionsTempVMQueryView> eService { get; set; } 
        public IRPSTextBox<ACCTransactionsTempVMQueryView> DateFrom { get; set; } 
        public IRPSTextBox<ACCTransactionsTempVMQueryView> DateTo { get; set; } 
        public IRPSTextBox<ACCTransactionsTempVMQueryView> CodInvoice { get; set; } 
        public IRPSTextBox<ACCTransactionsTempVMQueryView> AccountingDate { get; set; } 
        public IRPSButton<ACCTransactionsTempVMQueryView> TransferCommandButton { get; set; } 
        public IRPSButton<ACCTransactionsTempVMQueryView,GenerateChildDialogView> GenerateChildNavigationCommandButton { get; set; } 
        public ACCTransactionsTempConsultCollectionEditor<ACCTransactionsTempVMQueryView,ACCTransactionsTempVMEntityView> ACCTransactionsTempConsult { get; set; } 
        public ACCTransactionsTemp Screen { get; set; }
        public ACCTransactionsTempVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ACCTransactionsTempConsultCollectionEditor<ACCTransactionsTempVMQueryView,ACCTransactionsTempVMEntityView>:RPSCollectionEditor<ACCTransactionsTempVMQueryView,ACCTransactionsTempVMEntityView> where ACCTransactionsTempVMQueryView : class, IView where ACCTransactionsTempVMEntityView : class, IView
    {
        public  ACCTransactionsTempConsultGridView<ACCTransactionsTempVMQueryView,ACCTransactionsTempVMEntityView> GridView {get;set;}
    }
    public partial class ACCTransactionsTempConsultGridView <ACCTransactionsTempVMQueryView,ACCTransactionsTempVMEntityView> :  RPSGridView<ACCTransactionsTempVMQueryView,ACCTransactionsTempVMEntityView> where ACCTransactionsTempVMQueryView : class, IView where ACCTransactionsTempVMEntityView : class, IView
    {
        public ACCTransactionsTempConsultGridView(ACCTransactionsTempVMQueryView currentView,ACCTransactionsTempVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            AccountingDate = RPSControlFactory.CreateRPSGridTextBox<ACCTransactionsTempVMQueryView>("","#141075f5-5ed0-46a6-bafa-6f34bf8a3e43 .ag-row[role='row']@ROWINDEX [col-id='cAccountingDate']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<ACCTransactionsTempVMQueryView>("","#141075f5-5ed0-46a6-bafa-6f34bf8a3e43 .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 
            VATRegister = RPSControlFactory.CreateRPSGridFormattedTextBox<ACCTransactionsTempVMQueryView>("","#141075f5-5ed0-46a6-bafa-6f34bf8a3e43 .ag-row[role='row']@ROWINDEX [col-id='cVATRegister']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ACCTransactionsTempVMQueryView> AccountingDate { get; set; } 
        public IRPSGridTextBox<ACCTransactionsTempVMQueryView> InvoiceDate { get; set; } 
        public IRPSGridTextBox<ACCTransactionsTempVMQueryView> VATRegister { get; set; } 
                     
    }
 
    }
  
            
    public partial class ACCTransactionsTempVMEntityView : View
    {
        public ACCTransactionsTempVMEntityView(ACCTransactionsTemp screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ACCTransactionsTempVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ACCTransactionsTempVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ACCTransactionsTempVMEntityView,ACCTransactionsTempVMQueryView>( this,Screen.ACCTransactionsTempVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<ACCTransactionsTempVMEntityView,ACCTransactionsTempVMQueryView>( this,Screen.ACCTransactionsTempVMQueryView);
 
            IDVoucherType = RPSControlFactory.CreateRPSComboBox<ACCTransactionsTempVMEntityView>("1874756f-d6eb-4c4f-86fe-5997e2235d1d","","",true, this);
 
            AccountingDate = RPSControlFactory.CreateRPSTextBox<ACCTransactionsTempVMEntityView>("ee9ada87-b3e4-4c09-99e7-6fd009883376","","",true, this);
 
            Service = RPSControlFactory.CreateRPSEnumComboBox<ACCTransactionsTempVMEntityView>("151ee2c7-f42b-4b60-b2f3-b3c92822ecaf","","",false, this);
 
            NumberDocument = RPSControlFactory.CreateRPSTextBox<ACCTransactionsTempVMEntityView>("1c7df7d6-09f1-4ad8-a704-e70fbf1e69c6","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<ACCTransactionsTempVMEntityView>("02ad0508-f4cc-47ff-afc0-2c3f366d43d2","","",false, this);
 
            IDSupplierMiscellaneous = RPSControlFactory.CreateRPSComboBox<ACCTransactionsTempVMEntityView>("9ec0d23b-7f0f-4944-b710-27635b6bc89e","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<ACCTransactionsTempVMEntityView>("f3545876-bb63-40b2-b1ee-bbfa4044a429","","",false, this);
 
            IDCustomerMiscellaneous = RPSControlFactory.CreateRPSComboBox<ACCTransactionsTempVMEntityView>("a3b50e0f-e494-4a5b-b0aa-dcd59720dcd0","","",false, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<ACCTransactionsTempVMEntityView>("ca98970c-22a7-43a9-acfd-87cd0726bee3","","",false, this);
 
            CompanyName = RPSControlFactory.CreateRPSTextBox<ACCTransactionsTempVMEntityView>("ea9b61d2-a694-45a4-9e8c-47601dcf3582","","",false, this);
 
            CodCountryFrom = RPSControlFactory.CreateRPSComboBox<ACCTransactionsTempVMEntityView>("ed941672-294d-4ca2-b9d9-d4886ab9fa2a","","",false, this);
 
            IDStateFrom = RPSControlFactory.CreateRPSComboBox<ACCTransactionsTempVMEntityView>("b520eab6-aae9-45a1-b8fd-7a63e179ecf9","","",false, this);
 
            CodCountryTo = RPSControlFactory.CreateRPSComboBox<ACCTransactionsTempVMEntityView>("8a30cdbe-749a-443c-8c38-51561eb93911","","",false, this);
 
            IDStateTo = RPSControlFactory.CreateRPSComboBox<ACCTransactionsTempVMEntityView>("6df94ba2-0c21-477a-a0b2-b830eb5d071d","","",false, this);
 
            InvoiceDate = RPSControlFactory.CreateRPSTextBox<ACCTransactionsTempVMEntityView>("043b0efe-b751-4967-96a9-23078cbb7ee7","","",false, this);
 
            CodInvoice = RPSControlFactory.CreateRPSTextBox<ACCTransactionsTempVMEntityView>("adf1bf8a-6214-40ca-81a1-fa05ba727fe2","","",false, this);
 
            UIIDInvoice = RPSControlFactory.CreateRPSComboBox<ACCTransactionsTempVMEntityView>("c54d68c7-45ce-4fb4-9289-869e4c38eb6d","","",false, this);
 
            UIIDInvoiceSL = RPSControlFactory.CreateRPSComboBox<ACCTransactionsTempVMEntityView>("0415bf6b-e0b6-4627-9f4c-622e59531558","","",false, this);
 
            VATAPRegisterNumber = RPSControlFactory.CreateRPSFormattedTextBox<ACCTransactionsTempVMEntityView>("3d8ae0b2-c657-4b48-a8d1-eb676641c758","","",true, this);
 
            VATARRegisterNumber = RPSControlFactory.CreateRPSFormattedTextBox<ACCTransactionsTempVMEntityView>("5d135137-71c3-474b-ae53-977eacada7cc","","",true, this);
 
            IDEUInvoice = RPSControlFactory.CreateRPSComboBox<ACCTransactionsTempVMEntityView>("b1365024-9337-43d5-8620-2ba213c05d25","","",false, this);
 
            DeliveryNoteDate = RPSControlFactory.CreateRPSTextBox<ACCTransactionsTempVMEntityView>("84811b70-6133-4a61-aa8d-489066c4a85b","","",false, this);
 
            CodDeliveryNote = RPSControlFactory.CreateRPSTextBox<ACCTransactionsTempVMEntityView>("65eac19d-58db-4592-be5f-d3b5553a9650","","",false, this);
 
            DocumentType = RPSControlFactory.CreateRPSEnumComboBox<ACCTransactionsTempVMEntityView>("0d7db6b8-98e6-41ad-8d01-f05678650148","","",true, this);
 
            CodFromInvoice = RPSControlFactory.CreateRPSTextBox<ACCTransactionsTempVMEntityView>("4aff98c5-9559-461b-89d0-95d435aaa836","","",false, this);
 
            DUAGroup = RPSControlFactory.CreateRPSTextBox<ACCTransactionsTempVMEntityView>("a90fed25-a686-4a0f-aa81-d7d6ef39bd6c","","",false, this);
 
            Renting = RPSControlFactory.CreateRPSCheckBox<ACCTransactionsTempVMEntityView>("43f276cb-416f-4175-8cc4-aaa2d6830a86","","",true, this);
 
            IDFixedAsset = RPSControlFactory.CreateRPSComboBox<ACCTransactionsTempVMEntityView>("b741188b-45a2-48ba-9ef0-ea2e4cde2477","","",false, this);
 
            TotalCredit = RPSControlFactory.CreateRPSFormattedTextBox<ACCTransactionsTempVMEntityView>("c389753b-2c64-43c0-8e2c-65fb12e25303","","",false, this);
 
            TotalDebit = RPSControlFactory.CreateRPSFormattedTextBox<ACCTransactionsTempVMEntityView>("26ac3be6-98c0-4653-9963-70c180246b31","","",false, this);
 
            Diff = RPSControlFactory.CreateRPSFormattedTextBox<ACCTransactionsTempVMEntityView>("c0ee76e6-b9b8-4ff3-9f66-73bc1283f755","","",false, this);
 
            CollectionInit params_ACCTransactionsDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d4fa0b87-0a60-4aea-b9dc-6149d5cdc050",CSSSelectorGrid="",XPathGrid=""};
            ACCTransactionsDetails = RPSControlFactory.RPSCreateCollectionWithGrid<ACCTransactionsDetailsCollectionEditor<ACCTransactionsTempVMEntityView,ACCTransactionsTempDetailView>,ACCTransactionsTempVMEntityView,ACCTransactionsTempDetailView>( params_ACCTransactionsDetails,this,Screen.ACCTransactionsTempDetailView);
 
            SectionGeneral = RPSControlFactory.CreateRPSSection<ACCTransactionsTempVMEntityView>( "","ul li[rpsid='db198bff-a626-466e-831f-cb707e21c047']","",this);
 
            SectionDetails = RPSControlFactory.CreateRPSSection<ACCTransactionsTempVMEntityView>( "","ul li[rpsid='eac1855d-06b1-4c69-9da5-188772cbc0ea']","",this);
 

        }
        public IRPSSaveButton<ACCTransactionsTempVMEntityView> SaveButton { get; set; } 
        public IRPSButton<ACCTransactionsTempVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<ACCTransactionsTempVMEntityView,ACCTransactionsTempVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ACCTransactionsTempVMEntityView,ACCTransactionsTempVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<ACCTransactionsTempVMEntityView> IDVoucherType { get; set; } 
        public IRPSTextBox<ACCTransactionsTempVMEntityView> AccountingDate { get; set; } 
        public IRPSComboBox<ACCTransactionsTempVMEntityView> Service { get; set; } 
        public IRPSTextBox<ACCTransactionsTempVMEntityView> NumberDocument { get; set; } 
        public IRPSComboBox<ACCTransactionsTempVMEntityView> IDSupplier { get; set; } 
        public IRPSComboBox<ACCTransactionsTempVMEntityView> IDSupplierMiscellaneous { get; set; } 
        public IRPSComboBox<ACCTransactionsTempVMEntityView> IDCustomer { get; set; } 
        public IRPSComboBox<ACCTransactionsTempVMEntityView> IDCustomerMiscellaneous { get; set; } 
        public IRPSTextBox<ACCTransactionsTempVMEntityView> VATNumber { get; set; } 
        public IRPSTextBox<ACCTransactionsTempVMEntityView> CompanyName { get; set; } 
        public IRPSComboBox<ACCTransactionsTempVMEntityView> CodCountryFrom { get; set; } 
        public IRPSComboBox<ACCTransactionsTempVMEntityView> IDStateFrom { get; set; } 
        public IRPSComboBox<ACCTransactionsTempVMEntityView> CodCountryTo { get; set; } 
        public IRPSComboBox<ACCTransactionsTempVMEntityView> IDStateTo { get; set; } 
        public IRPSTextBox<ACCTransactionsTempVMEntityView> InvoiceDate { get; set; } 
        public IRPSTextBox<ACCTransactionsTempVMEntityView> CodInvoice { get; set; } 
        public IRPSComboBox<ACCTransactionsTempVMEntityView> UIIDInvoice { get; set; } 
        public IRPSComboBox<ACCTransactionsTempVMEntityView> UIIDInvoiceSL { get; set; } 
        public IRPSTextBox<ACCTransactionsTempVMEntityView> VATAPRegisterNumber { get; set; } 
        public IRPSTextBox<ACCTransactionsTempVMEntityView> VATARRegisterNumber { get; set; } 
        public IRPSComboBox<ACCTransactionsTempVMEntityView> IDEUInvoice { get; set; } 
        public IRPSTextBox<ACCTransactionsTempVMEntityView> DeliveryNoteDate { get; set; } 
        public IRPSTextBox<ACCTransactionsTempVMEntityView> CodDeliveryNote { get; set; } 
        public IRPSComboBox<ACCTransactionsTempVMEntityView> DocumentType { get; set; } 
        public IRPSTextBox<ACCTransactionsTempVMEntityView> CodFromInvoice { get; set; } 
        public IRPSTextBox<ACCTransactionsTempVMEntityView> DUAGroup { get; set; } 
        public IRPSCheckbox<ACCTransactionsTempVMEntityView> Renting { get; set; } 
        public IRPSComboBox<ACCTransactionsTempVMEntityView> IDFixedAsset { get; set; } 
        public IRPSTextBox<ACCTransactionsTempVMEntityView> TotalCredit { get; set; } 
        public IRPSTextBox<ACCTransactionsTempVMEntityView> TotalDebit { get; set; } 
        public IRPSTextBox<ACCTransactionsTempVMEntityView> Diff { get; set; } 
        public ACCTransactionsDetailsCollectionEditor<ACCTransactionsTempVMEntityView,ACCTransactionsTempDetailView> ACCTransactionsDetails { get; set; } 
        public IRPSSection<ACCTransactionsTempVMEntityView> SectionGeneral { get; set; } 
        public IRPSSection<ACCTransactionsTempVMEntityView> SectionDetails { get; set; } 
        public ACCTransactionsTemp Screen { get; set; }
        public ACCTransactionsTempVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ACCTransactionsDetailsCollectionEditor<ACCTransactionsTempVMEntityView,ACCTransactionsTempDetailView>:RPSCollectionEditor<ACCTransactionsTempVMEntityView,ACCTransactionsTempDetailView> where ACCTransactionsTempVMEntityView : class, IView where ACCTransactionsTempDetailView : class, IView
    {
        public  ACCTransactionsDetailsGridView<ACCTransactionsTempVMEntityView,ACCTransactionsTempDetailView> GridView {get;set;}
    }
    public partial class ACCTransactionsDetailsGridView <ACCTransactionsTempVMEntityView,ACCTransactionsTempDetailView> :  RPSGridView<ACCTransactionsTempVMEntityView,ACCTransactionsTempDetailView> where ACCTransactionsTempVMEntityView : class, IView where ACCTransactionsTempDetailView : class, IView
    {
        public ACCTransactionsDetailsGridView(ACCTransactionsTempVMEntityView currentView,ACCTransactionsTempDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            VoucherNumberLine = RPSControlFactory.CreateRPSGridFormattedTextBox<ACCTransactionsTempVMEntityView>("","#d4fa0b87-0a60-4aea-b9dc-6149d5cdc050 .ag-row[role='row']@ROWINDEX [col-id='cVoucherNumberLine']","",true, this.CurrentView);
 
            MovementType = RPSControlFactory.CreateRPSGridEnumComboBox<ACCTransactionsTempVMEntityView>("","#d4fa0b87-0a60-4aea-b9dc-6149d5cdc050 .ag-row[role='row']@ROWINDEX [col-id='cMovementType']","",true, this.CurrentView);
 
            IDItemSelector = RPSControlFactory.CreateRPSGridComboBox<ACCTransactionsTempVMEntityView>("","#d4fa0b87-0a60-4aea-b9dc-6149d5cdc050 .ag-row[role='row']@ROWINDEX [col-id='cIDItemSelector']","",false, this.CurrentView);
 
            IDAccount = RPSControlFactory.CreateRPSGridComboBox<ACCTransactionsTempVMEntityView>("","#d4fa0b87-0a60-4aea-b9dc-6149d5cdc050 .ag-row[role='row']@ROWINDEX [col-id='cIDAccount']","",false, this.CurrentView);
 
            AmountDebit = RPSControlFactory.CreateRPSGridFormattedTextBox<ACCTransactionsTempVMEntityView>("","#d4fa0b87-0a60-4aea-b9dc-6149d5cdc050 .ag-row[role='row']@ROWINDEX [col-id='cAmountDebit']","",false, this.CurrentView);
 
            AmountCredit = RPSControlFactory.CreateRPSGridFormattedTextBox<ACCTransactionsTempVMEntityView>("","#d4fa0b87-0a60-4aea-b9dc-6149d5cdc050 .ag-row[role='row']@ROWINDEX [col-id='cAmountCredit']","",false, this.CurrentView);
 
            AmountCurrency = RPSControlFactory.CreateRPSGridFormattedTextBox<ACCTransactionsTempVMEntityView>("","#d4fa0b87-0a60-4aea-b9dc-6149d5cdc050 .ag-row[role='row']@ROWINDEX [col-id='cAmountCurrency']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<ACCTransactionsTempVMEntityView> VoucherNumberLine { get; set; } 
        public IRPSGridComboBox<ACCTransactionsTempVMEntityView> MovementType { get; set; } 
        public IRPSGridComboBox<ACCTransactionsTempVMEntityView> IDItemSelector { get; set; } 
        public IRPSGridComboBox<ACCTransactionsTempVMEntityView> IDAccount { get; set; } 
        public IRPSGridTextBox<ACCTransactionsTempVMEntityView> AmountDebit { get; set; } 
        public IRPSGridTextBox<ACCTransactionsTempVMEntityView> AmountCredit { get; set; } 
        public IRPSGridTextBox<ACCTransactionsTempVMEntityView> AmountCurrency { get; set; } 
                     
    }
 
    }
  
            
    public partial class ACCTransactionsTempDetailView : View
    {
        public ACCTransactionsTempDetailView(ACCTransactionsTemp screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ACCTransactionsTempDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ACCTransactionsTempDetailView,ACCTransactionsTempVMEntityView>( this,Screen.ACCTransactionsTempVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ACCTransactionsTempDetailView,ACCTransactionsTempVMEntityView>( this,Screen.ACCTransactionsTempVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ACCTransactionsTempDetailView,ACCTransactionsTempVMEntityView>( this,Screen.ACCTransactionsTempVMEntityView);
 
            VoucherNumberLine = RPSControlFactory.CreateRPSFormattedTextBox<ACCTransactionsTempDetailView>("71f0da0c-fb9e-4a9d-81cb-7722a4d9d977","","",true, this);
 
            MovementType = RPSControlFactory.CreateRPSEnumComboBox<ACCTransactionsTempDetailView>("e2d799b3-4557-4ea6-ae77-b80e21ae232b","","",true, this);
 
            IDItemBankAccountCompany = RPSControlFactory.CreateRPSComboBox<ACCTransactionsTempDetailView>("101cf77f-793e-4dec-be6b-ddf8e2da0d5d","","",false, this);
 
            IDItemVAT = RPSControlFactory.CreateRPSComboBox<ACCTransactionsTempDetailView>("30b5ef28-fbb1-4477-b88e-a7e194a4cf50","","",false, this);
 
            IDItemTaxValue = RPSControlFactory.CreateRPSComboBox<ACCTransactionsTempDetailView>("1e44169c-0bb8-42d1-9fc7-b0513c3eb510","","",false, this);
 
            IDItemSupplierMiscellaneous = RPSControlFactory.CreateRPSComboBox<ACCTransactionsTempDetailView>("0a31a4b8-f7f3-4c84-bffa-b3a8a5177c9e","","",false, this);
 
            IDItemSupplier = RPSControlFactory.CreateRPSComboBox<ACCTransactionsTempDetailView>("8b2e822f-40e8-43f3-8c03-931d1f4b363e","","",false, this);
 
            IDItemCustomerMiscellaneous = RPSControlFactory.CreateRPSComboBox<ACCTransactionsTempDetailView>("98ae82ef-2e50-49c0-b99b-cb1d3bb8f95c","","",false, this);
 
            IDItemCustomer = RPSControlFactory.CreateRPSComboBox<ACCTransactionsTempDetailView>("065ad4e7-4958-4ce9-ac39-86eaaa247493","","",false, this);
 
            IDAccount = RPSControlFactory.CreateRPSComboBox<ACCTransactionsTempDetailView>("fd588fd1-b130-433d-ac2b-1fef0c7b0fae","","",false, this);
 
            SignType = RPSControlFactory.CreateRPSEnumComboBox<ACCTransactionsTempDetailView>("d2d3a8de-6cd2-4a11-9338-3ada6f400909","","",true, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<ACCTransactionsTempDetailView>("374f7678-5628-4f51-a7ca-9e15728060a4","","",true, this);
 
            AmountCurrency = RPSControlFactory.CreateRPSFormattedTextBox<ACCTransactionsTempDetailView>("3150427b-6019-411b-a3d8-b997c66c4995","","",true, this);
 
            Change = RPSControlFactory.CreateRPSFormattedTextBox<ACCTransactionsTempDetailView>("eeb41d76-6720-41a6-9254-b80aa58f6637","","",true, this);
 
            VATPercentage = RPSControlFactory.CreateRPSFormattedTextBox<ACCTransactionsTempDetailView>("c1b6f1fc-ac24-4835-aa85-eb409d9d130a","","",true, this);
 
            VATBase = RPSControlFactory.CreateRPSFormattedTextBox<ACCTransactionsTempDetailView>("a28050c9-7321-4e26-9732-5f43a5a0e6e7","","",true, this);
 
            PercentDeductible = RPSControlFactory.CreateRPSFormattedTextBox<ACCTransactionsTempDetailView>("94502281-6dd2-4b26-852f-b443626e2a33","","",true, this);
 
            ExcludedFromRC = RPSControlFactory.CreateRPSCheckBox<ACCTransactionsTempDetailView>("80d3eca2-bf68-4f9e-b638-263055abee97","","",true, this);
 
            IDAccConcept = RPSControlFactory.CreateRPSComboBox<ACCTransactionsTempDetailView>("29c140f0-325d-4316-9613-277c73c86a81","","",false, this);
 
            Extension = RPSControlFactory.CreateRPSTextBox<ACCTransactionsTempDetailView>("c9c1143a-bdb8-481f-82fa-819999f00062","","",false, this);
 
            CodInvoice = RPSControlFactory.CreateRPSTextBox<ACCTransactionsTempDetailView>("db41daa2-8f47-4737-a08d-af29e901bd34","","",false, this);
 
            UIIDInvoice = RPSControlFactory.CreateRPSComboBox<ACCTransactionsTempDetailView>("eed1de09-2450-483c-933a-7566ecb1ec73","","",false, this);
 
            UIIDInvoiceSL = RPSControlFactory.CreateRPSComboBox<ACCTransactionsTempDetailView>("ee1acecd-6e47-4917-8cbc-8e5864923889","","",false, this);
 
            CheckNumber = RPSControlFactory.CreateRPSTextBox<ACCTransactionsTempDetailView>("bd7c3fc1-5849-4a65-b33c-fbbed6c141df","","",false, this);
 
            IDLeasing = RPSControlFactory.CreateRPSComboBox<ACCTransactionsTempDetailView>("e3dd3b27-ff0b-40a6-9c0a-653c4e554c8c","","",false, this);
 
            UIAccTransactionsTemp = RPSControlFactory.CreateRPSTextBox<ACCTransactionsTempDetailView>("89fabedf-ca14-4373-ac2d-9b47c599af6e","","",false, this);
 
            IDACCTransInvoiceTaxPurchase = RPSControlFactory.CreateRPSComboBox<ACCTransactionsTempDetailView>("847be195-580b-4757-8e8e-24c679ea54d7","","",false, this);
 
            IDACCTransInvoiceTaxSales = RPSControlFactory.CreateRPSComboBox<ACCTransactionsTempDetailView>("6ca55f67-88af-4739-b6d4-e973c163cb99","","",false, this);
 
            IDACCTransInvoiceVATPurchase = RPSControlFactory.CreateRPSComboBox<ACCTransactionsTempDetailView>("7b8c58eb-8772-4176-9a33-d35af90f1f19","","",false, this);
 
            IDACCTransInvoiceVATSales = RPSControlFactory.CreateRPSComboBox<ACCTransactionsTempDetailView>("11fcf94e-4295-424f-aca3-d702763d942d","","",false, this);
 
            PaidAmount = RPSControlFactory.CreateRPSFormattedTextBox<ACCTransactionsTempDetailView>("594381a0-4d83-43c8-8f5d-abbb71f535bf","","",true, this);
 
            PaidType = RPSControlFactory.CreateRPSEnumComboBox<ACCTransactionsTempDetailView>("ccb3e3fc-55cd-4aaf-9a00-abbf33683607","","",true, this);
 
            PaidExtension = RPSControlFactory.CreateRPSTextBox<ACCTransactionsTempDetailView>("569aaef9-f3bb-4370-8859-c1c2533cd268","","",false, this);
 
            CollectionInit params_ACCTransactionsAnalytics = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="287bea47-8576-4b55-9d0c-cc3b60bb374a",CSSSelectorGrid="",XPathGrid=""};
            ACCTransactionsAnalytics = RPSControlFactory.RPSCreateCollectionWithGrid<ACCTransactionsAnalyticsCollectionEditor<ACCTransactionsTempDetailView,ACCTransactionsTempAnalyticView>,ACCTransactionsTempDetailView,ACCTransactionsTempAnalyticView>( params_ACCTransactionsAnalytics,this,Screen.ACCTransactionsTempAnalyticView);
 
            SectionGeneral = RPSControlFactory.CreateRPSSection<ACCTransactionsTempDetailView>( "","ul li[rpsid='f6126ec0-18d2-4b88-92dc-01e46f525a70']","",this);
 
            SectionAnalitic = RPSControlFactory.CreateRPSSection<ACCTransactionsTempDetailView>( "","ul li[rpsid='f17ebe22-a635-47d5-b264-ed687a379eaf']","",this);
 

        }
        public IRPSButton<ACCTransactionsTempDetailView> DeleteButton { get; set; } 
        public IRPSButton<ACCTransactionsTempDetailView,ACCTransactionsTempVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ACCTransactionsTempDetailView,ACCTransactionsTempVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ACCTransactionsTempDetailView,ACCTransactionsTempVMEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<ACCTransactionsTempDetailView> VoucherNumberLine { get; set; } 
        public IRPSComboBox<ACCTransactionsTempDetailView> MovementType { get; set; } 
        public IRPSComboBox<ACCTransactionsTempDetailView> IDItemBankAccountCompany { get; set; } 
        public IRPSComboBox<ACCTransactionsTempDetailView> IDItemVAT { get; set; } 
        public IRPSComboBox<ACCTransactionsTempDetailView> IDItemTaxValue { get; set; } 
        public IRPSComboBox<ACCTransactionsTempDetailView> IDItemSupplierMiscellaneous { get; set; } 
        public IRPSComboBox<ACCTransactionsTempDetailView> IDItemSupplier { get; set; } 
        public IRPSComboBox<ACCTransactionsTempDetailView> IDItemCustomerMiscellaneous { get; set; } 
        public IRPSComboBox<ACCTransactionsTempDetailView> IDItemCustomer { get; set; } 
        public IRPSComboBox<ACCTransactionsTempDetailView> IDAccount { get; set; } 
        public IRPSComboBox<ACCTransactionsTempDetailView> SignType { get; set; } 
        public IRPSTextBox<ACCTransactionsTempDetailView> Amount { get; set; } 
        public IRPSTextBox<ACCTransactionsTempDetailView> AmountCurrency { get; set; } 
        public IRPSTextBox<ACCTransactionsTempDetailView> Change { get; set; } 
        public IRPSTextBox<ACCTransactionsTempDetailView> VATPercentage { get; set; } 
        public IRPSTextBox<ACCTransactionsTempDetailView> VATBase { get; set; } 
        public IRPSTextBox<ACCTransactionsTempDetailView> PercentDeductible { get; set; } 
        public IRPSCheckbox<ACCTransactionsTempDetailView> ExcludedFromRC { get; set; } 
        public IRPSComboBox<ACCTransactionsTempDetailView> IDAccConcept { get; set; } 
        public IRPSTextBox<ACCTransactionsTempDetailView> Extension { get; set; } 
        public IRPSTextBox<ACCTransactionsTempDetailView> CodInvoice { get; set; } 
        public IRPSComboBox<ACCTransactionsTempDetailView> UIIDInvoice { get; set; } 
        public IRPSComboBox<ACCTransactionsTempDetailView> UIIDInvoiceSL { get; set; } 
        public IRPSTextBox<ACCTransactionsTempDetailView> CheckNumber { get; set; } 
        public IRPSComboBox<ACCTransactionsTempDetailView> IDLeasing { get; set; } 
        public IRPSTextBox<ACCTransactionsTempDetailView> UIAccTransactionsTemp { get; set; } 
        public IRPSComboBox<ACCTransactionsTempDetailView> IDACCTransInvoiceTaxPurchase { get; set; } 
        public IRPSComboBox<ACCTransactionsTempDetailView> IDACCTransInvoiceTaxSales { get; set; } 
        public IRPSComboBox<ACCTransactionsTempDetailView> IDACCTransInvoiceVATPurchase { get; set; } 
        public IRPSComboBox<ACCTransactionsTempDetailView> IDACCTransInvoiceVATSales { get; set; } 
        public IRPSTextBox<ACCTransactionsTempDetailView> PaidAmount { get; set; } 
        public IRPSComboBox<ACCTransactionsTempDetailView> PaidType { get; set; } 
        public IRPSTextBox<ACCTransactionsTempDetailView> PaidExtension { get; set; } 
        public ACCTransactionsAnalyticsCollectionEditor<ACCTransactionsTempDetailView,ACCTransactionsTempAnalyticView> ACCTransactionsAnalytics { get; set; } 
        public IRPSSection<ACCTransactionsTempDetailView> SectionGeneral { get; set; } 
        public IRPSSection<ACCTransactionsTempDetailView> SectionAnalitic { get; set; } 
        public ACCTransactionsTemp Screen { get; set; }
        public ACCTransactionsTempDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ACCTransactionsAnalyticsCollectionEditor<ACCTransactionsTempDetailView,ACCTransactionsTempAnalyticView>:RPSCollectionEditor<ACCTransactionsTempDetailView,ACCTransactionsTempAnalyticView> where ACCTransactionsTempDetailView : class, IView where ACCTransactionsTempAnalyticView : class, IView
    {
        public  ACCTransactionsAnalyticsGridView<ACCTransactionsTempDetailView,ACCTransactionsTempAnalyticView> GridView {get;set;}
    }
    public partial class ACCTransactionsAnalyticsGridView <ACCTransactionsTempDetailView,ACCTransactionsTempAnalyticView> :  RPSGridView<ACCTransactionsTempDetailView,ACCTransactionsTempAnalyticView> where ACCTransactionsTempDetailView : class, IView where ACCTransactionsTempAnalyticView : class, IView
    {
        public ACCTransactionsAnalyticsGridView(ACCTransactionsTempDetailView currentView,ACCTransactionsTempAnalyticView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDDimension = RPSControlFactory.CreateRPSGridComboBox<ACCTransactionsTempDetailView>("","#287bea47-8576-4b55-9d0c-cc3b60bb374a .ag-row[role='row']@ROWINDEX [col-id='cIDDimension']","",true, this.CurrentView);
 
            IDDimValue = RPSControlFactory.CreateRPSGridComboBox<ACCTransactionsTempDetailView>("","#287bea47-8576-4b55-9d0c-cc3b60bb374a .ag-row[role='row']@ROWINDEX [col-id='cIDDimValue']","",true, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<ACCTransactionsTempDetailView>("","#287bea47-8576-4b55-9d0c-cc3b60bb374a .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<ACCTransactionsTempDetailView>("","#287bea47-8576-4b55-9d0c-cc3b60bb374a .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            UIAmountCurrency = RPSControlFactory.CreateRPSGridFormattedTextBox<ACCTransactionsTempDetailView>("","#287bea47-8576-4b55-9d0c-cc3b60bb374a .ag-row[role='row']@ROWINDEX [col-id='cUIAmountCurrency']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ACCTransactionsTempDetailView> IDDimension { get; set; } 
        public IRPSGridComboBox<ACCTransactionsTempDetailView> IDDimValue { get; set; } 
        public IRPSGridTextBox<ACCTransactionsTempDetailView> Percentage { get; set; } 
        public IRPSGridTextBox<ACCTransactionsTempDetailView> Amount { get; set; } 
        public IRPSGridTextBox<ACCTransactionsTempDetailView> UIAmountCurrency { get; set; } 
                     
    }
 
    }
  
            
    public partial class ACCTransactionsTempAnalyticView : View
    {
        public ACCTransactionsTempAnalyticView(ACCTransactionsTemp screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ACCTransactionsTempAnalyticView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ACCTransactionsTempAnalyticView,ACCTransactionsTempDetailView>( this,Screen.ACCTransactionsTempDetailView);
 
            BackButton = RPSControlFactory.RPSBackButton<ACCTransactionsTempAnalyticView,ACCTransactionsTempDetailView>( this,Screen.ACCTransactionsTempDetailView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ACCTransactionsTempAnalyticView,ACCTransactionsTempDetailView>( this,Screen.ACCTransactionsTempDetailView);
 
            IDDimension = RPSControlFactory.CreateRPSComboBox<ACCTransactionsTempAnalyticView>("38f801db-ce14-4cf9-95a8-10bbb66a9345","","",true, this);
 
            IDDimValue = RPSControlFactory.CreateRPSComboBox<ACCTransactionsTempAnalyticView>("838bc86b-fcc3-457b-a0db-1f07f649434d","","",true, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<ACCTransactionsTempAnalyticView>("ff896824-9719-4921-8557-09d6f36d2729","","",true, this);
 
            Percentage = RPSControlFactory.CreateRPSFormattedTextBox<ACCTransactionsTempAnalyticView>("45dfaf37-2d4f-443b-886a-1411e5a7331e","","",true, this);
 
            UIAmountCurrency = RPSControlFactory.CreateRPSFormattedTextBox<ACCTransactionsTempAnalyticView>("014bbfc3-131a-4cce-8c35-6746e01ad486","","",false, this);
 

        }
        public IRPSButton<ACCTransactionsTempAnalyticView> DeleteButton { get; set; } 
        public IRPSButton<ACCTransactionsTempAnalyticView,ACCTransactionsTempDetailView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ACCTransactionsTempAnalyticView,ACCTransactionsTempDetailView> BackButton { get; set; } 
        public IRPSAcceptButton<ACCTransactionsTempAnalyticView,ACCTransactionsTempDetailView> AcceptButton { get; set; } 
        public IRPSComboBox<ACCTransactionsTempAnalyticView> IDDimension { get; set; } 
        public IRPSComboBox<ACCTransactionsTempAnalyticView> IDDimValue { get; set; } 
        public IRPSTextBox<ACCTransactionsTempAnalyticView> Amount { get; set; } 
        public IRPSTextBox<ACCTransactionsTempAnalyticView> Percentage { get; set; } 
        public IRPSTextBox<ACCTransactionsTempAnalyticView> UIAmountCurrency { get; set; } 
        public ACCTransactionsTemp Screen { get; set; }
        public ACCTransactionsTempAnalyticView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class GenerateChildDialogView : View
    {
        public GenerateChildDialogView(ACCTransactionsTemp screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ManufacturingOrder = RPSControlFactory.CreateRPSOption<GenerateChildDialogView>( "09df4c3c-7136-4d4f-aeae-f41a7e96219e","","",this);
 
            Project = RPSControlFactory.CreateRPSOption<GenerateChildDialogView>( "4d52942d-d4ad-4dd6-b545-6beffc6706b6","","",this);
 
            Maintenance = RPSControlFactory.CreateRPSOption<GenerateChildDialogView>( "da7082e6-3e35-4d80-bbbd-941b23207cb0","","",this);
 
            DateFromChild = RPSControlFactory.CreateRPSTextBox<GenerateChildDialogView>("4580362c-d8be-4d8a-a66d-f5ceb4bdddf8","","",false, this);
 
            DateToChild = RPSControlFactory.CreateRPSTextBox<GenerateChildDialogView>("8b4b9718-e4fb-4a26-aedb-a1641805acad","","",false, this);
 

        }
        public IRPSOption<GenerateChildDialogView> ManufacturingOrder { get; set; } 
        public IRPSOption<GenerateChildDialogView> Project { get; set; } 
        public IRPSOption<GenerateChildDialogView> Maintenance { get; set; } 
        public IRPSTextBox<GenerateChildDialogView> DateFromChild { get; set; } 
        public IRPSTextBox<GenerateChildDialogView> DateToChild { get; set; } 
        public ACCTransactionsTemp Screen { get; set; }
        public GenerateChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class TransferChildDialogView : View
    {
        public TransferChildDialogView(ACCTransactionsTemp screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            GroupingByDocument = RPSControlFactory.CreateRPSOption<TransferChildDialogView>( "f4656f02-948e-4de3-afef-3106c4ac95b6","","",this);
 
            GroupingByDay = RPSControlFactory.CreateRPSOption<TransferChildDialogView>( "9baf80e5-ff23-4e49-a0a1-f606b6dc0c2b","","",this);
 
            GroupingDayFixed = RPSControlFactory.CreateRPSOption<TransferChildDialogView>( "41fba573-58cf-46a1-95d7-f39fc04e0da1","","",this);
 
            Date = RPSControlFactory.CreateRPSTextBox<TransferChildDialogView>("75b86bc4-a68b-481d-86a2-75fdcb2e4a3b","","",false, this);
 
            NoGrouping = RPSControlFactory.CreateRPSOption<TransferChildDialogView>( "73141584-f516-468e-83cd-8a9856c50c9c","","",this);
 
            IDVoucherSeriesBook = RPSControlFactory.CreateRPSComboBox<TransferChildDialogView>("43c6c51f-60bd-4eb3-a660-7158cca12dfb","","",false, this);
 

        }
        public IRPSOption<TransferChildDialogView> GroupingByDocument { get; set; } 
        public IRPSOption<TransferChildDialogView> GroupingByDay { get; set; } 
        public IRPSOption<TransferChildDialogView> GroupingDayFixed { get; set; } 
        public IRPSTextBox<TransferChildDialogView> Date { get; set; } 
        public IRPSOption<TransferChildDialogView> NoGrouping { get; set; } 
        public IRPSComboBox<TransferChildDialogView> IDVoucherSeriesBook { get; set; } 
        public ACCTransactionsTemp Screen { get; set; }
        public TransferChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class TrasnferChildSmallDialogView : View
    {
        public TrasnferChildSmallDialogView(ACCTransactionsTemp screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDVoucherSeriesBook = RPSControlFactory.CreateRPSComboBox<TrasnferChildSmallDialogView>("a2dd0078-023e-4305-a2e1-052249e9b170","","",false, this);
 

        }
        public IRPSComboBox<TrasnferChildSmallDialogView> IDVoucherSeriesBook { get; set; } 
        public ACCTransactionsTemp Screen { get; set; }
        public TrasnferChildSmallDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}