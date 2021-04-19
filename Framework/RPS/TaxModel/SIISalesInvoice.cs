    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.TaxModel.SIISalesInvoice
{
    //RPS VERSION 1.0.0.0
    public partial class SIISalesInvoice:Screen
    {
        public SIISalesInvoice():base()
        {
            this.URL = "taxmodel.siisalesinvoice";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            TaxSalesInvoiceVMQueryView  = new TaxSalesInvoiceVMQueryView(this); 
            TaxSalesInvoiceVMEntityView  = new TaxSalesInvoiceVMEntityView(this); 
            SIISalesInvoiceSendDialogView  = new SIISalesInvoiceSendDialogView(this); 
            TaxSalesInvoiceVMQueryView.InitializeControls(); 
            TaxSalesInvoiceVMEntityView.InitializeControls(); 
            SIISalesInvoiceSendDialogView.InitializeControls(); 
           
        }
      
            public TaxSalesInvoiceVMQueryView TaxSalesInvoiceVMQueryView {get; set; } 
            public TaxSalesInvoiceVMEntityView TaxSalesInvoiceVMEntityView {get; set; } 
            public SIISalesInvoiceSendDialogView SIISalesInvoiceSendDialogView {get; set; } 
    }
            
    public partial class TaxSalesInvoiceVMQueryView : View
    {
        public TaxSalesInvoiceVMQueryView(SIISalesInvoice screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<TaxSalesInvoiceVMQueryView,TaxSalesInvoiceVMEntityView>( this,Screen.TaxSalesInvoiceVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<TaxSalesInvoiceVMQueryView>( this);
 
            DeclarationYear = RPSControlFactory.CreateRPSFormattedTextBox<TaxSalesInvoiceVMQueryView>("9c83d4e5-3480-4d9a-9407-4661128191d1","","",false, this);
 
            eMonth = RPSControlFactory.CreateRPSEnumComboBox<TaxSalesInvoiceVMQueryView>("a1f68560-7f41-49d5-97cd-348104c36983","","",false, this);
 
            AccountingDateFrom = RPSControlFactory.CreateRPSTextBox<TaxSalesInvoiceVMQueryView>("d5e71dfd-3568-42e2-aaae-c8a2c5aa3b06","","",false, this);
 
            AccountingDateTo = RPSControlFactory.CreateRPSTextBox<TaxSalesInvoiceVMQueryView>("055c81cf-70d8-4425-a843-156ee7dbccdf","","",false, this);
 
            InvoiceDateFrom = RPSControlFactory.CreateRPSTextBox<TaxSalesInvoiceVMQueryView>("1451fa03-503f-441f-8a1d-ac323951368d","","",false, this);
 
            InvoiceDateTo = RPSControlFactory.CreateRPSTextBox<TaxSalesInvoiceVMQueryView>("cfde2e51-e9ae-4527-a3c0-e38732573ec7","","",false, this);
 
            FrozenInvoices = RPSControlFactory.CreateRPSCheckBox<TaxSalesInvoiceVMQueryView>("da31b28e-73d4-44c4-8ad5-bbdcf81cde52","","",false, this);
 
            Sent = RPSControlFactory.CreateRPSCheckBox<TaxSalesInvoiceVMQueryView>("77fecdc8-d214-4650-b1ec-e83cdc11f43f","","",false, this);
 
            PendingCorrection = RPSControlFactory.CreateRPSCheckBox<TaxSalesInvoiceVMQueryView>("0bf5b416-4d0e-428e-ad7f-36f450ef3ee0","","",false, this);
 
            ToBeCreated = RPSControlFactory.CreateRPSCheckBox<TaxSalesInvoiceVMQueryView>("185004d9-2bb3-46c4-8a0d-5790e49454e6","","",false, this);
 
            ToBeChanged = RPSControlFactory.CreateRPSCheckBox<TaxSalesInvoiceVMQueryView>("abaabd53-6d42-4959-87aa-3f62722433f9","","",false, this);
 
            ToBeDeleted = RPSControlFactory.CreateRPSCheckBox<TaxSalesInvoiceVMQueryView>("6183d92d-0342-44f1-afdc-168db6699cb6","","",false, this);
 
            NoSend = RPSControlFactory.CreateRPSCheckBox<TaxSalesInvoiceVMQueryView>("f86c3234-ab7a-4b63-9bac-74d129e542c4","","",false, this);
 
            Deleted = RPSControlFactory.CreateRPSCheckBox<TaxSalesInvoiceVMQueryView>("75afb827-9080-4fbf-87c1-4a7f44829062","","",false, this);
 
            SIILoadDataCommandButton = RPSControlFactory.CreateRPSButton<TaxSalesInvoiceVMQueryView>( "363c9f7a-eb32-4d63-a8fc-89c4e2e4490f","","",this);
 
            SIISalesInvoiceSendNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<TaxSalesInvoiceVMQueryView,SIISalesInvoiceSendDialogView>("12f73a32-0d8d-46a5-a5d6-86bc1fdb8883","","", this,Screen.SIISalesInvoiceSendDialogView);
 
            IncludeSalesInvoiceCommandButton = RPSControlFactory.CreateRPSButton<TaxSalesInvoiceVMQueryView>( "4a580d3c-db93-410d-9a54-adbcf0aa7276","","",this);
 
            ExcludeSalesInvoiceCommandButton = RPSControlFactory.CreateRPSButton<TaxSalesInvoiceVMQueryView>( "33f7fd8b-61ef-479f-9d56-eccb970fe4c0","","",this);
 
            SendOKSalesInvoiceCommandButton = RPSControlFactory.CreateRPSButton<TaxSalesInvoiceVMQueryView>( "d8d78700-dbc3-4088-a584-908fe69d5a27","","",this);
 
            DeleteOKSalesInvoiceCommandButton = RPSControlFactory.CreateRPSButton<TaxSalesInvoiceVMQueryView>( "4c30bf43-6569-4167-b169-6f1171d6550e","","",this);
 
            ReplaceSalesInvoiceCommandButton = RPSControlFactory.CreateRPSButton<TaxSalesInvoiceVMQueryView>( "d60698e2-e85b-4f58-bc26-65e02fc052e1","","",this);
 
            DeleteInvoiceCommandButton = RPSControlFactory.CreateRPSButton<TaxSalesInvoiceVMQueryView>( "1485bed4-1c13-43a2-98ea-91fcf4e0b3d6","","",this);
 
            FreezeListTaxSalesInvoicesCommandButton = RPSControlFactory.CreateRPSButton<TaxSalesInvoiceVMQueryView>( "77e9317f-fec0-4670-851b-f03e3184de6f","","",this);
 
            CollectionInit params_SIISalesInvoice = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="20052178-4ee9-4d2a-9bed-fb815c581711",CSSSelectorGrid="",XPathGrid=""};
            SIISalesInvoice = RPSControlFactory.RPSCreateCollectionWithGrid<SIISalesInvoiceCollectionEditor<TaxSalesInvoiceVMQueryView,TaxSalesInvoiceVMEntityView>,TaxSalesInvoiceVMQueryView,TaxSalesInvoiceVMEntityView>( params_SIISalesInvoice,this,Screen.TaxSalesInvoiceVMEntityView);
 

        }
        public IRPSButton<TaxSalesInvoiceVMQueryView,TaxSalesInvoiceVMEntityView> NewButton { get; set; } 
        public IRPSButton<TaxSalesInvoiceVMQueryView> ConsultButton { get; set; } 
        public IRPSTextBox<TaxSalesInvoiceVMQueryView> DeclarationYear { get; set; } 
        public IRPSComboBox<TaxSalesInvoiceVMQueryView> eMonth { get; set; } 
        public IRPSTextBox<TaxSalesInvoiceVMQueryView> AccountingDateFrom { get; set; } 
        public IRPSTextBox<TaxSalesInvoiceVMQueryView> AccountingDateTo { get; set; } 
        public IRPSTextBox<TaxSalesInvoiceVMQueryView> InvoiceDateFrom { get; set; } 
        public IRPSTextBox<TaxSalesInvoiceVMQueryView> InvoiceDateTo { get; set; } 
        public IRPSCheckbox<TaxSalesInvoiceVMQueryView> FrozenInvoices { get; set; } 
        public IRPSCheckbox<TaxSalesInvoiceVMQueryView> Sent { get; set; } 
        public IRPSCheckbox<TaxSalesInvoiceVMQueryView> PendingCorrection { get; set; } 
        public IRPSCheckbox<TaxSalesInvoiceVMQueryView> ToBeCreated { get; set; } 
        public IRPSCheckbox<TaxSalesInvoiceVMQueryView> ToBeChanged { get; set; } 
        public IRPSCheckbox<TaxSalesInvoiceVMQueryView> ToBeDeleted { get; set; } 
        public IRPSCheckbox<TaxSalesInvoiceVMQueryView> NoSend { get; set; } 
        public IRPSCheckbox<TaxSalesInvoiceVMQueryView> Deleted { get; set; } 
        public IRPSButton<TaxSalesInvoiceVMQueryView> SIILoadDataCommandButton { get; set; } 
        public IRPSButton<TaxSalesInvoiceVMQueryView,SIISalesInvoiceSendDialogView> SIISalesInvoiceSendNavigationCommandButton { get; set; } 
        public IRPSButton<TaxSalesInvoiceVMQueryView> IncludeSalesInvoiceCommandButton { get; set; } 
        public IRPSButton<TaxSalesInvoiceVMQueryView> ExcludeSalesInvoiceCommandButton { get; set; } 
        public IRPSButton<TaxSalesInvoiceVMQueryView> SendOKSalesInvoiceCommandButton { get; set; } 
        public IRPSButton<TaxSalesInvoiceVMQueryView> DeleteOKSalesInvoiceCommandButton { get; set; } 
        public IRPSButton<TaxSalesInvoiceVMQueryView> ReplaceSalesInvoiceCommandButton { get; set; } 
        public IRPSButton<TaxSalesInvoiceVMQueryView> DeleteInvoiceCommandButton { get; set; } 
        public IRPSButton<TaxSalesInvoiceVMQueryView> FreezeListTaxSalesInvoicesCommandButton { get; set; } 
        public SIISalesInvoiceCollectionEditor<TaxSalesInvoiceVMQueryView,TaxSalesInvoiceVMEntityView> SIISalesInvoice { get; set; } 
        public SIISalesInvoice Screen { get; set; }
        public TaxSalesInvoiceVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SIISalesInvoiceCollectionEditor<TaxSalesInvoiceVMQueryView,TaxSalesInvoiceVMEntityView>:RPSCollectionEditor<TaxSalesInvoiceVMQueryView,TaxSalesInvoiceVMEntityView> where TaxSalesInvoiceVMQueryView : class, IView where TaxSalesInvoiceVMEntityView : class, IView
    {
        public  SIISalesInvoiceGridView<TaxSalesInvoiceVMQueryView,TaxSalesInvoiceVMEntityView> GridView {get;set;}
    }
    public partial class SIISalesInvoiceGridView <TaxSalesInvoiceVMQueryView,TaxSalesInvoiceVMEntityView> :  RPSGridView<TaxSalesInvoiceVMQueryView,TaxSalesInvoiceVMEntityView> where TaxSalesInvoiceVMQueryView : class, IView where TaxSalesInvoiceVMEntityView : class, IView
    {
        public SIISalesInvoiceGridView(TaxSalesInvoiceVMQueryView currentView,TaxSalesInvoiceVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            TaxSalesInvoice_CodInvoice = RPSControlFactory.CreateRPSGridTextBox<TaxSalesInvoiceVMQueryView>("","#20052178-4ee9-4d2a-9bed-fb815c581711 .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesInvoice_CodInvoice']","",false, this.CurrentView);
 
            TaxSalesInvoice_ActionStatus = RPSControlFactory.CreateRPSGridTextBox<TaxSalesInvoiceVMQueryView>("","#20052178-4ee9-4d2a-9bed-fb815c581711 .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesInvoice_ActionStatus']","",false, this.CurrentView);
 
            TaxSalesInvoice_InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<TaxSalesInvoiceVMQueryView>("","#20052178-4ee9-4d2a-9bed-fb815c581711 .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesInvoice_InvoiceDate']","",false, this.CurrentView);
 
            TaxSalesInvoice_CustomerVATNumber = RPSControlFactory.CreateRPSGridTextBox<TaxSalesInvoiceVMQueryView>("","#20052178-4ee9-4d2a-9bed-fb815c581711 .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesInvoice_CustomerVATNumber']","",false, this.CurrentView);
 
            TaxSalesInvoice_CountryFrom = RPSControlFactory.CreateRPSGridTextBox<TaxSalesInvoiceVMQueryView>("","#20052178-4ee9-4d2a-9bed-fb815c581711 .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesInvoice_CountryFrom']","",false, this.CurrentView);
 
            TaxSalesInvoice_CustomerName = RPSControlFactory.CreateRPSGridTextBox<TaxSalesInvoiceVMQueryView>("","#20052178-4ee9-4d2a-9bed-fb815c581711 .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesInvoice_CustomerName']","",false, this.CurrentView);
 
            TaxSalesInvoice_AccountingDate = RPSControlFactory.CreateRPSGridTextBox<TaxSalesInvoiceVMQueryView>("","#20052178-4ee9-4d2a-9bed-fb815c581711 .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesInvoice_AccountingDate']","",false, this.CurrentView);
 
            TaxSalesInvoice_OperationDate = RPSControlFactory.CreateRPSGridTextBox<TaxSalesInvoiceVMQueryView>("","#20052178-4ee9-4d2a-9bed-fb815c581711 .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesInvoice_OperationDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<TaxSalesInvoiceVMQueryView> TaxSalesInvoice_CodInvoice { get; set; } 
        public IRPSGridTextBox<TaxSalesInvoiceVMQueryView> TaxSalesInvoice_ActionStatus { get; set; } 
        public IRPSGridTextBox<TaxSalesInvoiceVMQueryView> TaxSalesInvoice_InvoiceDate { get; set; } 
        public IRPSGridTextBox<TaxSalesInvoiceVMQueryView> TaxSalesInvoice_CustomerVATNumber { get; set; } 
        public IRPSGridTextBox<TaxSalesInvoiceVMQueryView> TaxSalesInvoice_CountryFrom { get; set; } 
        public IRPSGridTextBox<TaxSalesInvoiceVMQueryView> TaxSalesInvoice_CustomerName { get; set; } 
        public IRPSGridTextBox<TaxSalesInvoiceVMQueryView> TaxSalesInvoice_AccountingDate { get; set; } 
        public IRPSGridTextBox<TaxSalesInvoiceVMQueryView> TaxSalesInvoice_OperationDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class TaxSalesInvoiceVMEntityView : View
    {
        public TaxSalesInvoiceVMEntityView(SIISalesInvoice screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<TaxSalesInvoiceVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<TaxSalesInvoiceVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<TaxSalesInvoiceVMEntityView,TaxSalesInvoiceVMQueryView>( this,Screen.TaxSalesInvoiceVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<TaxSalesInvoiceVMEntityView,TaxSalesInvoiceVMQueryView>( this,Screen.TaxSalesInvoiceVMQueryView);
 
            CodInvoice = RPSControlFactory.CreateRPSTextBox<TaxSalesInvoiceVMEntityView>("33d38ad0-69e7-456a-842a-7caac365ae94","","",true, this);
 
            InvoiceDate = RPSControlFactory.CreateRPSTextBox<TaxSalesInvoiceVMEntityView>("5aa43866-ede2-472c-8fcf-e1b07aa6b84e","","",true, this);
 
            OperationDate = RPSControlFactory.CreateRPSTextBox<TaxSalesInvoiceVMEntityView>("0aece537-1468-47f8-8cc1-fdabd111156f","","",false, this);
 
            DeclarationYear = RPSControlFactory.CreateRPSFormattedTextBox<TaxSalesInvoiceVMEntityView>("9a320f7d-86cc-45d3-b218-957476d6b4b3","","",true, this);
 
            DeclarationMonth = RPSControlFactory.CreateRPSEnumComboBox<TaxSalesInvoiceVMEntityView>("86274f48-c91e-4e8e-af4b-71d0d6b1d23a","","",true, this);
 
            CustomerName = RPSControlFactory.CreateRPSTextBox<TaxSalesInvoiceVMEntityView>("3d07b44c-db84-4387-b7af-2c604087d936","","",true, this);
 
            CustomerCountry = RPSControlFactory.CreateRPSTextBox<TaxSalesInvoiceVMEntityView>("cb06a361-a8ae-485d-a322-66404edf1174","","",true, this);
 
            CustomerVATNumber = RPSControlFactory.CreateRPSTextBox<TaxSalesInvoiceVMEntityView>("21b04de8-3b6c-4823-a0fe-193821861c95","","",false, this);
 
            CustomerUnregistered = RPSControlFactory.CreateRPSCheckBox<TaxSalesInvoiceVMEntityView>("b036cda3-baf8-4404-b59f-c0adb6e0591c","","",false, this);
 
            ActionStatus = RPSControlFactory.CreateRPSEnumComboBox<TaxSalesInvoiceVMEntityView>("f9a1e1e1-3a9c-4235-b88a-4b74f0ffdb04","","",true, this);
 
            LastModifiedTime = RPSControlFactory.CreateRPSTextBox<TaxSalesInvoiceVMEntityView>("290892ac-68e2-452b-ab65-c41e449633e7","","",false, this);
 
            SentTime = RPSControlFactory.CreateRPSTextBox<TaxSalesInvoiceVMEntityView>("aeae59fe-b5d6-43f6-a7f7-1fad455dd8d7","","",false, this);
 
            Frozen = RPSControlFactory.CreateRPSCheckBox<TaxSalesInvoiceVMEntityView>("0a386df6-aa43-43c2-8ecb-dec202bb2096","","",true, this);
 
            CreatedStatus = RPSControlFactory.CreateRPSEnumComboBox<TaxSalesInvoiceVMEntityView>("7c8d1543-6a10-49cf-ab84-951fef004674","","",true, this);
 
            ChangedStatus = RPSControlFactory.CreateRPSEnumComboBox<TaxSalesInvoiceVMEntityView>("95a0a65c-93a4-44f3-9c40-0d25d1010c7a","","",true, this);
 
            DeletedStatus = RPSControlFactory.CreateRPSEnumComboBox<TaxSalesInvoiceVMEntityView>("8bdeed78-f739-43e3-adee-ddff7c658368","","",true, this);
 
            Deletion = RPSControlFactory.CreateRPSEnumComboBox<TaxSalesInvoiceVMEntityView>("9f7e6634-66b5-44e5-925a-a7d951abc988","","",true, this);
 
            ErrorInfo = RPSControlFactory.CreateRPSTextBox<TaxSalesInvoiceVMEntityView>("aaf4307a-3869-4cd9-a00e-cea8750cad87","","",false, this);
 
            OperationType = RPSControlFactory.CreateRPSTextBox<TaxSalesInvoiceVMEntityView>("f988396a-4ee9-41b4-a53c-1cbaaa1008c9","","",false, this);
 
            IsAutoInvoice = RPSControlFactory.CreateRPSCheckBox<TaxSalesInvoiceVMEntityView>("d10c144a-4343-444a-814e-6a0f9a64bcd7","","",true, this);
 
            IsATicket = RPSControlFactory.CreateRPSCheckBox<TaxSalesInvoiceVMEntityView>("abc6c76c-80b5-4dbf-bd5c-b79ae66efb43","","",true, this);
 
            FirstTicket = RPSControlFactory.CreateRPSTextBox<TaxSalesInvoiceVMEntityView>("ec89fb79-7e92-4241-89d5-cc69fd86aa57","","",false, this);
 
            LastTicket = RPSControlFactory.CreateRPSTextBox<TaxSalesInvoiceVMEntityView>("07abc06a-1ad1-4887-b304-859873f0f0b1","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<TaxSalesInvoiceVMEntityView>("ef6f26e1-d3cb-443a-a6d6-76b243b8f9e3","","",true, this);
 
            IDACCTransactions = RPSControlFactory.CreateRPSComboBox<TaxSalesInvoiceVMEntityView>("bb36b66f-277c-45d2-942f-d1fc3e310309","","",true, this);
 
            AccountingDate = RPSControlFactory.CreateRPSTextBox<TaxSalesInvoiceVMEntityView>("af32e45a-9134-4c00-b0a9-60cafc5fcbc0","","",true, this);
 
            CountryFrom = RPSControlFactory.CreateRPSTextBox<TaxSalesInvoiceVMEntityView>("5f0997b1-a380-47cc-a966-ae6b49a9f50e","","",true, this);
 
            CountryTo = RPSControlFactory.CreateRPSTextBox<TaxSalesInvoiceVMEntityView>("9391059e-1099-4d05-9cd7-b78ba006897f","","",true, this);
 
            VoucherType = RPSControlFactory.CreateRPSComboBox<TaxSalesInvoiceVMEntityView>("7fcd2718-d7af-44a5-a917-d550af6da68f","","",false, this);
 
            IsAmendment = RPSControlFactory.CreateRPSCheckBox<TaxSalesInvoiceVMEntityView>("41b8365e-27fa-4eff-aaf4-8a9b8d1edb17","","",true, this);
 
            FromCodInvoice = RPSControlFactory.CreateRPSTextBox<TaxSalesInvoiceVMEntityView>("8d837382-a3cb-4be5-9357-45c6b5ed3f8d","","",false, this);
 
            FromInvoiceDate = RPSControlFactory.CreateRPSTextBox<TaxSalesInvoiceVMEntityView>("8f67d339-b36f-447d-899c-adbcd529ed7a","","",false, this);
 
            AmendmentType = RPSControlFactory.CreateRPSEnumComboBox<TaxSalesInvoiceVMEntityView>("3efaf9ec-8aa0-4720-93a4-d4311d7a85d4","","",true, this);
 
            Situation = RPSControlFactory.CreateRPSEnumComboBox<TaxSalesInvoiceVMEntityView>("63d985f5-cba9-4cfb-acd4-81a171ce5a7e","","",false, this);
 
            CadastralReference = RPSControlFactory.CreateRPSTextBox<TaxSalesInvoiceVMEntityView>("c8e53b8d-b64d-4217-803b-a1fa38b4301f","","",false, this);
 
            TotalBase = RPSControlFactory.CreateRPSFormattedTextBox<TaxSalesInvoiceVMEntityView>("2199e1e8-7a01-4195-b131-7e67b174743b","","",true, this);
 
            TotalAmount = RPSControlFactory.CreateRPSFormattedTextBox<TaxSalesInvoiceVMEntityView>("300a328f-ac53-4887-9ee2-ed6711e8dd36","","",true, this);
 
            Total = RPSControlFactory.CreateRPSFormattedTextBox<TaxSalesInvoiceVMEntityView>("c29cdc32-9b5f-4149-84a7-18911a9bf93e","","",true, this);
 
            IDACCTransactionsDetail = RPSControlFactory.CreateRPSComboBox<TaxSalesInvoiceVMEntityView>("8cf1f8f9-b243-4077-9008-31a99a2ee093","","",true, this);
 
            IDVAT = RPSControlFactory.CreateRPSComboBox<TaxSalesInvoiceVMEntityView>("5e39e74e-00e0-4611-a894-59d092816c5d","","",false, this);
 
            Exclude = RPSControlFactory.CreateRPSCheckBox<TaxSalesInvoiceVMEntityView>("30b109be-85c3-4e00-9866-238ca9c2c885","","",true, this);
 
            IsPending = RPSControlFactory.CreateRPSCheckBox<TaxSalesInvoiceVMEntityView>("bb5f7fe2-218d-495e-ab42-4c065bf02146","","",true, this);
 
            IsSurchage = RPSControlFactory.CreateRPSCheckBox<TaxSalesInvoiceVMEntityView>("e24ba7ed-62d7-455d-a22c-6d4cc1e0f496","","",true, this);
 
            VATBase = RPSControlFactory.CreateRPSFormattedTextBox<TaxSalesInvoiceVMEntityView>("f475ddb8-fefa-4b46-ae5e-bf637a483064","","",true, this);
 
            VATPercentage = RPSControlFactory.CreateRPSFormattedTextBox<TaxSalesInvoiceVMEntityView>("5d52fc84-0d3f-411a-8edc-8f249a7766b6","","",true, this);
 
            VATAmount = RPSControlFactory.CreateRPSFormattedTextBox<TaxSalesInvoiceVMEntityView>("87559f39-8df2-4f6e-919e-25038a9f7c56","","",true, this);
 
            SurchagePercentage = RPSControlFactory.CreateRPSFormattedTextBox<TaxSalesInvoiceVMEntityView>("9d8dddb2-f91a-41aa-a4b8-e4a77218524e","","",true, this);
 
            SurchageAmount = RPSControlFactory.CreateRPSFormattedTextBox<TaxSalesInvoiceVMEntityView>("6232eee7-ee36-4bf7-b39c-bc0bc8b516ab","","",true, this);
 
            GoodsServices = RPSControlFactory.CreateRPSEnumComboBox<TaxSalesInvoiceVMEntityView>("86c2d874-f407-4c6c-a4bb-217c2b8659f2","","",true, this);
 
            VATType = RPSControlFactory.CreateRPSEnumComboBox<TaxSalesInvoiceVMEntityView>("9a71a06c-8cc6-4e57-8b81-d80aed9f5aa0","","",true, this);
 
            NotDeductible = RPSControlFactory.CreateRPSCheckBox<TaxSalesInvoiceVMEntityView>("7738e106-ff25-488f-8d46-ea7b8174113e","","",true, this);
 
            Usage303 = RPSControlFactory.CreateRPSEnumComboBox<TaxSalesInvoiceVMEntityView>("11c0106f-8c53-496d-adea-645d3905ff41","","",true, this);
 
            IncludeCommandButton = RPSControlFactory.CreateRPSButton<TaxSalesInvoiceVMEntityView>( "05e3693e-77b3-4175-bb3f-b31714dafcec","","",this);
 
            ExcludeCommandButton = RPSControlFactory.CreateRPSButton<TaxSalesInvoiceVMEntityView>( "f43a40ee-e7d5-4cd8-9fde-0d7f235eedcd","","",this);
 
            SentInvoice = RPSControlFactory.CreateRPSTextBox<TaxSalesInvoiceVMEntityView>("bda497a2-90ef-4a85-aa63-f814b27b5641","","",false, this);
 
            SentInvoiceTo = RPSControlFactory.CreateRPSTextBox<TaxSalesInvoiceVMEntityView>("2bedd1cb-5fab-40e1-acac-44fd82adfec0","","",false, this);
 
            SentType = RPSControlFactory.CreateRPSTextBox<TaxSalesInvoiceVMEntityView>("42d9af8e-7d9e-4cc9-bec3-ded5dec56163","","",false, this);
 
            SentKeys = RPSControlFactory.CreateRPSTextBox<TaxSalesInvoiceVMEntityView>("7ecd8624-6062-4441-abb6-cf61d94b9499","","",false, this);
 
            SentVAT = RPSControlFactory.CreateRPSTextBox<TaxSalesInvoiceVMEntityView>("8b6dca13-9f70-4eb8-a76d-87df43dd3422","","",false, this);
 
            SentText = RPSControlFactory.CreateRPSTextBox<TaxSalesInvoiceVMEntityView>("6aa3973a-5022-4b12-b7bc-b9c69df21e27","","",false, this);
 
            RefreshInvoiceCommandButton = RPSControlFactory.CreateRPSButton<TaxSalesInvoiceVMEntityView>( "ec455092-70b3-48c3-9623-bd75a9f5c06f","","",this);
 
            SendOneCommandButton = RPSControlFactory.CreateRPSButton<TaxSalesInvoiceVMEntityView>( "8610421c-2917-416e-a55a-7f570f84344b","","",this);
 
            IncludeSalesInvoiceCommandButton = RPSControlFactory.CreateRPSButton<TaxSalesInvoiceVMEntityView>( "c22e1b92-d414-421a-8c28-f06ce840ef41","","",this);
 
            ExcludeSalesInvoiceCommandButton = RPSControlFactory.CreateRPSButton<TaxSalesInvoiceVMEntityView>( "5b31f4cf-b4ba-42f4-be4d-919da65a74ba","","",this);
 
            SendOKSalesInvoiceCommandButton = RPSControlFactory.CreateRPSButton<TaxSalesInvoiceVMEntityView>( "7a5cc849-c8e7-40b5-8922-7ea66a991684","","",this);
 
            DeleteOKSalesInvoiceCommandButton = RPSControlFactory.CreateRPSButton<TaxSalesInvoiceVMEntityView>( "6f027218-6186-4c36-a12e-7c3d584a0d16","","",this);
 
            ReplaceSalesInvoiceCommandButton = RPSControlFactory.CreateRPSButton<TaxSalesInvoiceVMEntityView>( "4b47ff06-cc7a-42df-a9e8-8e84249c0823","","",this);
 
            FreezeTaxSalesInvoiceCommandButton = RPSControlFactory.CreateRPSButton<TaxSalesInvoiceVMEntityView>( "17a44f3c-766e-4f22-b48d-9306e410a1cd","","",this);
 
            CollectionInit params_TaxSalesVATs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="e013287f-8d97-40d8-a7e1-74a1bbac2d18",CSSSelectorGrid="",XPathGrid=""};
            TaxSalesVATs = RPSControlFactory.RPSCreateCollectionWithGrid<TaxSalesVATsCollectionEditor<TaxSalesInvoiceVMEntityView>,TaxSalesInvoiceVMEntityView>( params_TaxSalesVATs,this);
 
            CollectionInit params_SIISalesPaymentByID = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="cc995f1e-57e3-40ce-b947-fd9573e5d987",CSSSelectorGrid="",XPathGrid=""};
            SIISalesPaymentByID = RPSControlFactory.RPSCreateCollectionWithGrid<SIISalesPaymentByIDCollectionEditor<TaxSalesInvoiceVMEntityView>,TaxSalesInvoiceVMEntityView>( params_SIISalesPaymentByID,this);
 
            GeneralSection = RPSControlFactory.CreateRPSSection<TaxSalesInvoiceVMEntityView>( "","ul li[rpsid='de8d1c02-dbcb-4e31-ad85-6251144d9ed0']","",this);
 
            SectionDatosAdicionales = RPSControlFactory.CreateRPSSection<TaxSalesInvoiceVMEntityView>( "","ul li[rpsid='89761338-a245-4c7a-81f4-8aedd1fb189d']","",this);
 
            TaxSection = RPSControlFactory.CreateRPSSection<TaxSalesInvoiceVMEntityView>( "","ul li[rpsid='4c35e3a6-0286-44ba-bf95-d6bc7123deb3']","",this);
 
            SalesPaymentsSection = RPSControlFactory.CreateRPSSection<TaxSalesInvoiceVMEntityView>( "","ul li[rpsid='b7fec14d-faa2-47a3-89c8-6502d8d72df0']","",this);
 
            SentDataSection = RPSControlFactory.CreateRPSSection<TaxSalesInvoiceVMEntityView>( "","ul li[rpsid='3a05df9e-cfe8-4e9b-9161-be6ed9019c47']","",this);
 

        }
        public IRPSSaveButton<TaxSalesInvoiceVMEntityView> SaveButton { get; set; } 
        public IRPSButton<TaxSalesInvoiceVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<TaxSalesInvoiceVMEntityView,TaxSalesInvoiceVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<TaxSalesInvoiceVMEntityView,TaxSalesInvoiceVMQueryView> BackButton { get; set; } 
        public IRPSTextBox<TaxSalesInvoiceVMEntityView> CodInvoice { get; set; } 
        public IRPSTextBox<TaxSalesInvoiceVMEntityView> InvoiceDate { get; set; } 
        public IRPSTextBox<TaxSalesInvoiceVMEntityView> OperationDate { get; set; } 
        public IRPSTextBox<TaxSalesInvoiceVMEntityView> DeclarationYear { get; set; } 
        public IRPSComboBox<TaxSalesInvoiceVMEntityView> DeclarationMonth { get; set; } 
        public IRPSTextBox<TaxSalesInvoiceVMEntityView> CustomerName { get; set; } 
        public IRPSTextBox<TaxSalesInvoiceVMEntityView> CustomerCountry { get; set; } 
        public IRPSTextBox<TaxSalesInvoiceVMEntityView> CustomerVATNumber { get; set; } 
        public IRPSCheckbox<TaxSalesInvoiceVMEntityView> CustomerUnregistered { get; set; } 
        public IRPSComboBox<TaxSalesInvoiceVMEntityView> ActionStatus { get; set; } 
        public IRPSTextBox<TaxSalesInvoiceVMEntityView> LastModifiedTime { get; set; } 
        public IRPSTextBox<TaxSalesInvoiceVMEntityView> SentTime { get; set; } 
        public IRPSCheckbox<TaxSalesInvoiceVMEntityView> Frozen { get; set; } 
        public IRPSComboBox<TaxSalesInvoiceVMEntityView> CreatedStatus { get; set; } 
        public IRPSComboBox<TaxSalesInvoiceVMEntityView> ChangedStatus { get; set; } 
        public IRPSComboBox<TaxSalesInvoiceVMEntityView> DeletedStatus { get; set; } 
        public IRPSComboBox<TaxSalesInvoiceVMEntityView> Deletion { get; set; } 
        public IRPSTextBox<TaxSalesInvoiceVMEntityView> ErrorInfo { get; set; } 
        public IRPSTextBox<TaxSalesInvoiceVMEntityView> OperationType { get; set; } 
        public IRPSCheckbox<TaxSalesInvoiceVMEntityView> IsAutoInvoice { get; set; } 
        public IRPSCheckbox<TaxSalesInvoiceVMEntityView> IsATicket { get; set; } 
        public IRPSTextBox<TaxSalesInvoiceVMEntityView> FirstTicket { get; set; } 
        public IRPSTextBox<TaxSalesInvoiceVMEntityView> LastTicket { get; set; } 
        public IRPSTextBox<TaxSalesInvoiceVMEntityView> Description { get; set; } 
        public IRPSComboBox<TaxSalesInvoiceVMEntityView> IDACCTransactions { get; set; } 
        public IRPSTextBox<TaxSalesInvoiceVMEntityView> AccountingDate { get; set; } 
        public IRPSTextBox<TaxSalesInvoiceVMEntityView> CountryFrom { get; set; } 
        public IRPSTextBox<TaxSalesInvoiceVMEntityView> CountryTo { get; set; } 
        public IRPSComboBox<TaxSalesInvoiceVMEntityView> VoucherType { get; set; } 
        public IRPSCheckbox<TaxSalesInvoiceVMEntityView> IsAmendment { get; set; } 
        public IRPSTextBox<TaxSalesInvoiceVMEntityView> FromCodInvoice { get; set; } 
        public IRPSTextBox<TaxSalesInvoiceVMEntityView> FromInvoiceDate { get; set; } 
        public IRPSComboBox<TaxSalesInvoiceVMEntityView> AmendmentType { get; set; } 
        public IRPSComboBox<TaxSalesInvoiceVMEntityView> Situation { get; set; } 
        public IRPSTextBox<TaxSalesInvoiceVMEntityView> CadastralReference { get; set; } 
        public IRPSTextBox<TaxSalesInvoiceVMEntityView> TotalBase { get; set; } 
        public IRPSTextBox<TaxSalesInvoiceVMEntityView> TotalAmount { get; set; } 
        public IRPSTextBox<TaxSalesInvoiceVMEntityView> Total { get; set; } 
        public IRPSComboBox<TaxSalesInvoiceVMEntityView> IDACCTransactionsDetail { get; set; } 
        public IRPSComboBox<TaxSalesInvoiceVMEntityView> IDVAT { get; set; } 
        public IRPSCheckbox<TaxSalesInvoiceVMEntityView> Exclude { get; set; } 
        public IRPSCheckbox<TaxSalesInvoiceVMEntityView> IsPending { get; set; } 
        public IRPSCheckbox<TaxSalesInvoiceVMEntityView> IsSurchage { get; set; } 
        public IRPSTextBox<TaxSalesInvoiceVMEntityView> VATBase { get; set; } 
        public IRPSTextBox<TaxSalesInvoiceVMEntityView> VATPercentage { get; set; } 
        public IRPSTextBox<TaxSalesInvoiceVMEntityView> VATAmount { get; set; } 
        public IRPSTextBox<TaxSalesInvoiceVMEntityView> SurchagePercentage { get; set; } 
        public IRPSTextBox<TaxSalesInvoiceVMEntityView> SurchageAmount { get; set; } 
        public IRPSComboBox<TaxSalesInvoiceVMEntityView> GoodsServices { get; set; } 
        public IRPSComboBox<TaxSalesInvoiceVMEntityView> VATType { get; set; } 
        public IRPSCheckbox<TaxSalesInvoiceVMEntityView> NotDeductible { get; set; } 
        public IRPSComboBox<TaxSalesInvoiceVMEntityView> Usage303 { get; set; } 
        public IRPSButton<TaxSalesInvoiceVMEntityView> IncludeCommandButton { get; set; } 
        public IRPSButton<TaxSalesInvoiceVMEntityView> ExcludeCommandButton { get; set; } 
        public IRPSTextBox<TaxSalesInvoiceVMEntityView> SentInvoice { get; set; } 
        public IRPSTextBox<TaxSalesInvoiceVMEntityView> SentInvoiceTo { get; set; } 
        public IRPSTextBox<TaxSalesInvoiceVMEntityView> SentType { get; set; } 
        public IRPSTextBox<TaxSalesInvoiceVMEntityView> SentKeys { get; set; } 
        public IRPSTextBox<TaxSalesInvoiceVMEntityView> SentVAT { get; set; } 
        public IRPSTextBox<TaxSalesInvoiceVMEntityView> SentText { get; set; } 
        public IRPSButton<TaxSalesInvoiceVMEntityView> RefreshInvoiceCommandButton { get; set; } 
        public IRPSButton<TaxSalesInvoiceVMEntityView> SendOneCommandButton { get; set; } 
        public IRPSButton<TaxSalesInvoiceVMEntityView> IncludeSalesInvoiceCommandButton { get; set; } 
        public IRPSButton<TaxSalesInvoiceVMEntityView> ExcludeSalesInvoiceCommandButton { get; set; } 
        public IRPSButton<TaxSalesInvoiceVMEntityView> SendOKSalesInvoiceCommandButton { get; set; } 
        public IRPSButton<TaxSalesInvoiceVMEntityView> DeleteOKSalesInvoiceCommandButton { get; set; } 
        public IRPSButton<TaxSalesInvoiceVMEntityView> ReplaceSalesInvoiceCommandButton { get; set; } 
        public IRPSButton<TaxSalesInvoiceVMEntityView> FreezeTaxSalesInvoiceCommandButton { get; set; } 
        public TaxSalesVATsCollectionEditor<TaxSalesInvoiceVMEntityView> TaxSalesVATs { get; set; } 
        public SIISalesPaymentByIDCollectionEditor<TaxSalesInvoiceVMEntityView> SIISalesPaymentByID { get; set; } 
        public IRPSSection<TaxSalesInvoiceVMEntityView> GeneralSection { get; set; } 
        public IRPSSection<TaxSalesInvoiceVMEntityView> SectionDatosAdicionales { get; set; } 
        public IRPSSection<TaxSalesInvoiceVMEntityView> TaxSection { get; set; } 
        public IRPSSection<TaxSalesInvoiceVMEntityView> SalesPaymentsSection { get; set; } 
        public IRPSSection<TaxSalesInvoiceVMEntityView> SentDataSection { get; set; } 
        public SIISalesInvoice Screen { get; set; }
        public TaxSalesInvoiceVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class TaxSalesVATsCollectionEditor<TaxSalesInvoiceVMEntityView>:RPSCollectionEditor<TaxSalesInvoiceVMEntityView> where TaxSalesInvoiceVMEntityView : class, IView
    {
        public  TaxSalesVATsGridView<TaxSalesInvoiceVMEntityView> GridView {get;set;}
    }
    public partial class TaxSalesVATsGridView <TaxSalesInvoiceVMEntityView> :  RPSGridView<TaxSalesInvoiceVMEntityView> where TaxSalesInvoiceVMEntityView : class, IView
    {
        public TaxSalesVATsGridView(TaxSalesInvoiceVMEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Exclude = RPSControlFactory.CreateRPSGridCheckBox<TaxSalesInvoiceVMEntityView>("","#e013287f-8d97-40d8-a7e1-74a1bbac2d18 .ag-row[role='row']@ROWINDEX [col-id='cExclude']","",true, this.CurrentView);
 
            IsPending = RPSControlFactory.CreateRPSGridCheckBox<TaxSalesInvoiceVMEntityView>("","#e013287f-8d97-40d8-a7e1-74a1bbac2d18 .ag-row[role='row']@ROWINDEX [col-id='cIsPending']","",true, this.CurrentView);
 
            IsSurchage = RPSControlFactory.CreateRPSGridCheckBox<TaxSalesInvoiceVMEntityView>("","#e013287f-8d97-40d8-a7e1-74a1bbac2d18 .ag-row[role='row']@ROWINDEX [col-id='cIsSurchage']","",true, this.CurrentView);
 
            GoodsServices = RPSControlFactory.CreateRPSGridEnumComboBox<TaxSalesInvoiceVMEntityView>("","#e013287f-8d97-40d8-a7e1-74a1bbac2d18 .ag-row[role='row']@ROWINDEX [col-id='cGoodsServices']","",true, this.CurrentView);
 
            VATType = RPSControlFactory.CreateRPSGridEnumComboBox<TaxSalesInvoiceVMEntityView>("","#e013287f-8d97-40d8-a7e1-74a1bbac2d18 .ag-row[role='row']@ROWINDEX [col-id='cVATType']","",true, this.CurrentView);
 
            VATBase = RPSControlFactory.CreateRPSGridFormattedTextBox<TaxSalesInvoiceVMEntityView>("","#e013287f-8d97-40d8-a7e1-74a1bbac2d18 .ag-row[role='row']@ROWINDEX [col-id='cVATBase']","",true, this.CurrentView);
 
            VATPercentage = RPSControlFactory.CreateRPSGridFormattedTextBox<TaxSalesInvoiceVMEntityView>("","#e013287f-8d97-40d8-a7e1-74a1bbac2d18 .ag-row[role='row']@ROWINDEX [col-id='cVATPercentage']","",true, this.CurrentView);
 
            VATAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<TaxSalesInvoiceVMEntityView>("","#e013287f-8d97-40d8-a7e1-74a1bbac2d18 .ag-row[role='row']@ROWINDEX [col-id='cVATAmount']","",true, this.CurrentView);
 
            NotDeductible = RPSControlFactory.CreateRPSGridCheckBox<TaxSalesInvoiceVMEntityView>("","#e013287f-8d97-40d8-a7e1-74a1bbac2d18 .ag-row[role='row']@ROWINDEX [col-id='cNotDeductible']","",true, this.CurrentView);
 
            Usage303 = RPSControlFactory.CreateRPSGridEnumComboBox<TaxSalesInvoiceVMEntityView>("","#e013287f-8d97-40d8-a7e1-74a1bbac2d18 .ag-row[role='row']@ROWINDEX [col-id='cUsage303']","",true, this.CurrentView);
 

        }
        public IRPSGridCheckbox<TaxSalesInvoiceVMEntityView> Exclude { get; set; } 
        public IRPSGridCheckbox<TaxSalesInvoiceVMEntityView> IsPending { get; set; } 
        public IRPSGridCheckbox<TaxSalesInvoiceVMEntityView> IsSurchage { get; set; } 
        public IRPSGridComboBox<TaxSalesInvoiceVMEntityView> GoodsServices { get; set; } 
        public IRPSGridComboBox<TaxSalesInvoiceVMEntityView> VATType { get; set; } 
        public IRPSGridTextBox<TaxSalesInvoiceVMEntityView> VATBase { get; set; } 
        public IRPSGridTextBox<TaxSalesInvoiceVMEntityView> VATPercentage { get; set; } 
        public IRPSGridTextBox<TaxSalesInvoiceVMEntityView> VATAmount { get; set; } 
        public IRPSGridCheckbox<TaxSalesInvoiceVMEntityView> NotDeductible { get; set; } 
        public IRPSGridComboBox<TaxSalesInvoiceVMEntityView> Usage303 { get; set; } 
                     
    }
 
        public partial class SIISalesPaymentByIDCollectionEditor<TaxSalesInvoiceVMEntityView>:RPSCollectionEditor<TaxSalesInvoiceVMEntityView> where TaxSalesInvoiceVMEntityView : class, IView
    {
        public  SIISalesPaymentByIDGridView<TaxSalesInvoiceVMEntityView> GridView {get;set;}
    }
    public partial class SIISalesPaymentByIDGridView <TaxSalesInvoiceVMEntityView> :  RPSGridView<TaxSalesInvoiceVMEntityView> where TaxSalesInvoiceVMEntityView : class, IView
    {
        public SIISalesPaymentByIDGridView(TaxSalesInvoiceVMEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDACCTransactions = RPSControlFactory.CreateRPSGridComboBox<TaxSalesInvoiceVMEntityView>("","#cc995f1e-57e3-40ce-b947-fd9573e5d987 .ag-row[role='row']@ROWINDEX [col-id='cIDACCTransactions']","",false, this.CurrentView);
 
            TaxSalesPayment_AccountingDate = RPSControlFactory.CreateRPSGridTextBox<TaxSalesInvoiceVMEntityView>("","#cc995f1e-57e3-40ce-b947-fd9573e5d987 .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesPayment_AccountingDate']","",false, this.CurrentView);
 
            TaxSalesPayment_PaidType = RPSControlFactory.CreateRPSGridTextBox<TaxSalesInvoiceVMEntityView>("","#cc995f1e-57e3-40ce-b947-fd9573e5d987 .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesPayment_PaidType']","",false, this.CurrentView);
 
            TaxSalesPayment_PaidExtension = RPSControlFactory.CreateRPSGridTextBox<TaxSalesInvoiceVMEntityView>("","#cc995f1e-57e3-40ce-b947-fd9573e5d987 .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesPayment_PaidExtension']","",false, this.CurrentView);
 
            TaxSalesPayment_SentTime = RPSControlFactory.CreateRPSGridTextBox<TaxSalesInvoiceVMEntityView>("","#cc995f1e-57e3-40ce-b947-fd9573e5d987 .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesPayment_SentTime']","",false, this.CurrentView);
 
            TaxSalesPayment_SentStatus = RPSControlFactory.CreateRPSGridTextBox<TaxSalesInvoiceVMEntityView>("","#cc995f1e-57e3-40ce-b947-fd9573e5d987 .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesPayment_SentStatus']","",false, this.CurrentView);
 
            TaxSalesPayment_ErrorInfo = RPSControlFactory.CreateRPSGridMemoTextBox<TaxSalesInvoiceVMEntityView>("","#cc995f1e-57e3-40ce-b947-fd9573e5d987 .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesPayment_ErrorInfo']","",false, this.CurrentView);
 
            TaxSalesPayment_Deletion = RPSControlFactory.CreateRPSGridTextBox<TaxSalesInvoiceVMEntityView>("","#cc995f1e-57e3-40ce-b947-fd9573e5d987 .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesPayment_Deletion']","",false, this.CurrentView);
 
            TaxSalesPayment_ActionStatus = RPSControlFactory.CreateRPSGridTextBox<TaxSalesInvoiceVMEntityView>("","#cc995f1e-57e3-40ce-b947-fd9573e5d987 .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesPayment_ActionStatus']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<TaxSalesInvoiceVMEntityView> IDACCTransactions { get; set; } 
        public IRPSGridTextBox<TaxSalesInvoiceVMEntityView> TaxSalesPayment_AccountingDate { get; set; } 
        public IRPSGridTextBox<TaxSalesInvoiceVMEntityView> TaxSalesPayment_PaidType { get; set; } 
        public IRPSGridTextBox<TaxSalesInvoiceVMEntityView> TaxSalesPayment_PaidExtension { get; set; } 
        public IRPSGridTextBox<TaxSalesInvoiceVMEntityView> TaxSalesPayment_SentTime { get; set; } 
        public IRPSGridTextBox<TaxSalesInvoiceVMEntityView> TaxSalesPayment_SentStatus { get; set; } 
        public IRPSGridTextBox<TaxSalesInvoiceVMEntityView> TaxSalesPayment_ErrorInfo { get; set; } 
        public IRPSGridTextBox<TaxSalesInvoiceVMEntityView> TaxSalesPayment_Deletion { get; set; } 
        public IRPSGridTextBox<TaxSalesInvoiceVMEntityView> TaxSalesPayment_ActionStatus { get; set; } 
                     
    }
 
    }
  
            
    public partial class SIISalesInvoiceSendDialogView : View
    {
        public SIISalesInvoiceSendDialogView(SIISalesInvoice screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SelectedCreated = RPSControlFactory.CreateRPSTextBox<SIISalesInvoiceSendDialogView>("5b6fc377-28e1-4f3c-a364-7d341c76c45f","","",false, this);
 
            SelectedChanged = RPSControlFactory.CreateRPSTextBox<SIISalesInvoiceSendDialogView>("9f5aae55-c2e0-4039-bdcf-92f85155b55f","","",false, this);
 
            SelectedDeleted = RPSControlFactory.CreateRPSTextBox<SIISalesInvoiceSendDialogView>("b13410c6-0383-4871-9364-87dd1bac95c5","","",false, this);
 
            SendCommandButton = RPSControlFactory.CreateRPSButton<SIISalesInvoiceSendDialogView>( "3a06ec7c-7068-49c3-a1df-d7e6fb016238","","",this);
 
            CollectionInit params_SIISalesInvoiceToBeCreated = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7af30655-f8fa-4f1f-a8e6-3ee25691d833",CSSSelectorGrid="",XPathGrid=""};
            SIISalesInvoiceToBeCreated = RPSControlFactory.RPSCreateCollectionWithGrid<SIISalesInvoiceToBeCreatedCollectionEditor<SIISalesInvoiceSendDialogView>,SIISalesInvoiceSendDialogView>( params_SIISalesInvoiceToBeCreated,this);
 
            CollectionInit params_SIISalesInvoiceToBeChanged = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5976d25c-e3e4-4551-94c1-21d1447097f2",CSSSelectorGrid="",XPathGrid=""};
            SIISalesInvoiceToBeChanged = RPSControlFactory.RPSCreateCollectionWithGrid<SIISalesInvoiceToBeChangedCollectionEditor<SIISalesInvoiceSendDialogView>,SIISalesInvoiceSendDialogView>( params_SIISalesInvoiceToBeChanged,this);
 
            CollectionInit params_SIISalesInvoiceToBeDeleted = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4f05133f-4aee-4249-8d8e-d9d6e63537df",CSSSelectorGrid="",XPathGrid=""};
            SIISalesInvoiceToBeDeleted = RPSControlFactory.RPSCreateCollectionWithGrid<SIISalesInvoiceToBeDeletedCollectionEditor<SIISalesInvoiceSendDialogView>,SIISalesInvoiceSendDialogView>( params_SIISalesInvoiceToBeDeleted,this);
 
            ToBeCreated = RPSControlFactory.CreateRPSSection<SIISalesInvoiceSendDialogView>( "","ul li[rpsid='b076e4e4-6f8a-4b53-b519-852735ee2fbf']","",this);
 
            ToBeChanged = RPSControlFactory.CreateRPSSection<SIISalesInvoiceSendDialogView>( "","ul li[rpsid='c96eacb8-54b6-42b3-a4ca-b84f10bc523a']","",this);
 
            ToBeDeleted = RPSControlFactory.CreateRPSSection<SIISalesInvoiceSendDialogView>( "","ul li[rpsid='92f20a60-6aa2-4add-891f-7b1aca557b7b']","",this);
 

        }
        public IRPSTextBox<SIISalesInvoiceSendDialogView> SelectedCreated { get; set; } 
        public IRPSTextBox<SIISalesInvoiceSendDialogView> SelectedChanged { get; set; } 
        public IRPSTextBox<SIISalesInvoiceSendDialogView> SelectedDeleted { get; set; } 
        public IRPSButton<SIISalesInvoiceSendDialogView> SendCommandButton { get; set; } 
        public SIISalesInvoiceToBeCreatedCollectionEditor<SIISalesInvoiceSendDialogView> SIISalesInvoiceToBeCreated { get; set; } 
        public SIISalesInvoiceToBeChangedCollectionEditor<SIISalesInvoiceSendDialogView> SIISalesInvoiceToBeChanged { get; set; } 
        public SIISalesInvoiceToBeDeletedCollectionEditor<SIISalesInvoiceSendDialogView> SIISalesInvoiceToBeDeleted { get; set; } 
        public IRPSSection<SIISalesInvoiceSendDialogView> ToBeCreated { get; set; } 
        public IRPSSection<SIISalesInvoiceSendDialogView> ToBeChanged { get; set; } 
        public IRPSSection<SIISalesInvoiceSendDialogView> ToBeDeleted { get; set; } 
        public SIISalesInvoice Screen { get; set; }
        public SIISalesInvoiceSendDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SIISalesInvoiceToBeCreatedCollectionEditor<SIISalesInvoiceSendDialogView>:RPSCollectionEditor<SIISalesInvoiceSendDialogView> where SIISalesInvoiceSendDialogView : class, IView
    {
        public  SIISalesInvoiceToBeCreatedGridView<SIISalesInvoiceSendDialogView> GridView {get;set;}
    }
    public partial class SIISalesInvoiceToBeCreatedGridView <SIISalesInvoiceSendDialogView> :  RPSGridView<SIISalesInvoiceSendDialogView> where SIISalesInvoiceSendDialogView : class, IView
    {
        public SIISalesInvoiceToBeCreatedGridView(SIISalesInvoiceSendDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            TaxSalesInvoice_CodInvoice = RPSControlFactory.CreateRPSGridTextBox<SIISalesInvoiceSendDialogView>("","#7af30655-f8fa-4f1f-a8e6-3ee25691d833 .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesInvoice_CodInvoice']","",false, this.CurrentView);
 
            TaxSalesInvoice_InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<SIISalesInvoiceSendDialogView>("","#7af30655-f8fa-4f1f-a8e6-3ee25691d833 .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesInvoice_InvoiceDate']","",false, this.CurrentView);
 
            TaxSalesInvoice_CustomerVATNumber = RPSControlFactory.CreateRPSGridTextBox<SIISalesInvoiceSendDialogView>("","#7af30655-f8fa-4f1f-a8e6-3ee25691d833 .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesInvoice_CustomerVATNumber']","",false, this.CurrentView);
 
            TaxSalesInvoice_CountryFrom = RPSControlFactory.CreateRPSGridTextBox<SIISalesInvoiceSendDialogView>("","#7af30655-f8fa-4f1f-a8e6-3ee25691d833 .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesInvoice_CountryFrom']","",false, this.CurrentView);
 
            TaxSalesInvoice_CustomerName = RPSControlFactory.CreateRPSGridTextBox<SIISalesInvoiceSendDialogView>("","#7af30655-f8fa-4f1f-a8e6-3ee25691d833 .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesInvoice_CustomerName']","",false, this.CurrentView);
 
            TaxSalesInvoice_AccountingDate = RPSControlFactory.CreateRPSGridTextBox<SIISalesInvoiceSendDialogView>("","#7af30655-f8fa-4f1f-a8e6-3ee25691d833 .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesInvoice_AccountingDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SIISalesInvoiceSendDialogView> TaxSalesInvoice_CodInvoice { get; set; } 
        public IRPSGridTextBox<SIISalesInvoiceSendDialogView> TaxSalesInvoice_InvoiceDate { get; set; } 
        public IRPSGridTextBox<SIISalesInvoiceSendDialogView> TaxSalesInvoice_CustomerVATNumber { get; set; } 
        public IRPSGridTextBox<SIISalesInvoiceSendDialogView> TaxSalesInvoice_CountryFrom { get; set; } 
        public IRPSGridTextBox<SIISalesInvoiceSendDialogView> TaxSalesInvoice_CustomerName { get; set; } 
        public IRPSGridTextBox<SIISalesInvoiceSendDialogView> TaxSalesInvoice_AccountingDate { get; set; } 
                     
    }
 
        public partial class SIISalesInvoiceToBeChangedCollectionEditor<SIISalesInvoiceSendDialogView>:RPSCollectionEditor<SIISalesInvoiceSendDialogView> where SIISalesInvoiceSendDialogView : class, IView
    {
        public  SIISalesInvoiceToBeChangedGridView<SIISalesInvoiceSendDialogView> GridView {get;set;}
    }
    public partial class SIISalesInvoiceToBeChangedGridView <SIISalesInvoiceSendDialogView> :  RPSGridView<SIISalesInvoiceSendDialogView> where SIISalesInvoiceSendDialogView : class, IView
    {
        public SIISalesInvoiceToBeChangedGridView(SIISalesInvoiceSendDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            TaxSalesInvoice_CodInvoice = RPSControlFactory.CreateRPSGridTextBox<SIISalesInvoiceSendDialogView>("","#5976d25c-e3e4-4551-94c1-21d1447097f2 .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesInvoice_CodInvoice']","",false, this.CurrentView);
 
            TaxSalesInvoice_InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<SIISalesInvoiceSendDialogView>("","#5976d25c-e3e4-4551-94c1-21d1447097f2 .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesInvoice_InvoiceDate']","",false, this.CurrentView);
 
            TaxSalesInvoice_CustomerVATNumber = RPSControlFactory.CreateRPSGridTextBox<SIISalesInvoiceSendDialogView>("","#5976d25c-e3e4-4551-94c1-21d1447097f2 .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesInvoice_CustomerVATNumber']","",false, this.CurrentView);
 
            TaxSalesInvoice_CountryFrom = RPSControlFactory.CreateRPSGridTextBox<SIISalesInvoiceSendDialogView>("","#5976d25c-e3e4-4551-94c1-21d1447097f2 .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesInvoice_CountryFrom']","",false, this.CurrentView);
 
            TaxSalesInvoice_CustomerName = RPSControlFactory.CreateRPSGridTextBox<SIISalesInvoiceSendDialogView>("","#5976d25c-e3e4-4551-94c1-21d1447097f2 .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesInvoice_CustomerName']","",false, this.CurrentView);
 
            TaxSalesInvoice_AccountingDate = RPSControlFactory.CreateRPSGridTextBox<SIISalesInvoiceSendDialogView>("","#5976d25c-e3e4-4551-94c1-21d1447097f2 .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesInvoice_AccountingDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SIISalesInvoiceSendDialogView> TaxSalesInvoice_CodInvoice { get; set; } 
        public IRPSGridTextBox<SIISalesInvoiceSendDialogView> TaxSalesInvoice_InvoiceDate { get; set; } 
        public IRPSGridTextBox<SIISalesInvoiceSendDialogView> TaxSalesInvoice_CustomerVATNumber { get; set; } 
        public IRPSGridTextBox<SIISalesInvoiceSendDialogView> TaxSalesInvoice_CountryFrom { get; set; } 
        public IRPSGridTextBox<SIISalesInvoiceSendDialogView> TaxSalesInvoice_CustomerName { get; set; } 
        public IRPSGridTextBox<SIISalesInvoiceSendDialogView> TaxSalesInvoice_AccountingDate { get; set; } 
                     
    }
 
        public partial class SIISalesInvoiceToBeDeletedCollectionEditor<SIISalesInvoiceSendDialogView>:RPSCollectionEditor<SIISalesInvoiceSendDialogView> where SIISalesInvoiceSendDialogView : class, IView
    {
        public  SIISalesInvoiceToBeDeletedGridView<SIISalesInvoiceSendDialogView> GridView {get;set;}
    }
    public partial class SIISalesInvoiceToBeDeletedGridView <SIISalesInvoiceSendDialogView> :  RPSGridView<SIISalesInvoiceSendDialogView> where SIISalesInvoiceSendDialogView : class, IView
    {
        public SIISalesInvoiceToBeDeletedGridView(SIISalesInvoiceSendDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            TaxSalesInvoice_CodInvoice = RPSControlFactory.CreateRPSGridTextBox<SIISalesInvoiceSendDialogView>("","#4f05133f-4aee-4249-8d8e-d9d6e63537df .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesInvoice_CodInvoice']","",false, this.CurrentView);
 
            TaxSalesInvoice_InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<SIISalesInvoiceSendDialogView>("","#4f05133f-4aee-4249-8d8e-d9d6e63537df .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesInvoice_InvoiceDate']","",false, this.CurrentView);
 
            TaxSalesInvoice_CustomerVATNumber = RPSControlFactory.CreateRPSGridTextBox<SIISalesInvoiceSendDialogView>("","#4f05133f-4aee-4249-8d8e-d9d6e63537df .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesInvoice_CustomerVATNumber']","",false, this.CurrentView);
 
            TaxSalesInvoice_CountryFrom = RPSControlFactory.CreateRPSGridTextBox<SIISalesInvoiceSendDialogView>("","#4f05133f-4aee-4249-8d8e-d9d6e63537df .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesInvoice_CountryFrom']","",false, this.CurrentView);
 
            TaxSalesInvoice_CustomerName = RPSControlFactory.CreateRPSGridTextBox<SIISalesInvoiceSendDialogView>("","#4f05133f-4aee-4249-8d8e-d9d6e63537df .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesInvoice_CustomerName']","",false, this.CurrentView);
 
            TaxSalesInvoice_AccountingDate = RPSControlFactory.CreateRPSGridTextBox<SIISalesInvoiceSendDialogView>("","#4f05133f-4aee-4249-8d8e-d9d6e63537df .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesInvoice_AccountingDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SIISalesInvoiceSendDialogView> TaxSalesInvoice_CodInvoice { get; set; } 
        public IRPSGridTextBox<SIISalesInvoiceSendDialogView> TaxSalesInvoice_InvoiceDate { get; set; } 
        public IRPSGridTextBox<SIISalesInvoiceSendDialogView> TaxSalesInvoice_CustomerVATNumber { get; set; } 
        public IRPSGridTextBox<SIISalesInvoiceSendDialogView> TaxSalesInvoice_CountryFrom { get; set; } 
        public IRPSGridTextBox<SIISalesInvoiceSendDialogView> TaxSalesInvoice_CustomerName { get; set; } 
        public IRPSGridTextBox<SIISalesInvoiceSendDialogView> TaxSalesInvoice_AccountingDate { get; set; } 
                     
    }
 
    }
  
    

}