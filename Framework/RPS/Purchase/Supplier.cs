    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.Supplier
{
    //RPS VERSION 1.0.0.0
    public partial class Supplier:Screen
    {
        public Supplier():base()
        {
            this.URL = "purchase.supplier";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SupplierCollectionView  = new SupplierCollectionView(this); 
            SupplierEntityView  = new SupplierEntityView(this); 
            SupplierContactView  = new SupplierContactView(this); 
            SupplierOrderAddressView  = new SupplierOrderAddressView(this); 
            SupplierBankAccountView  = new SupplierBankAccountView(this); 
            SupplierReportView  = new SupplierReportView(this); 
            SupplierDetailView  = new SupplierDetailView(this); 
            SupplierAuditView  = new SupplierAuditView(this); 
            SupplierCertificateView  = new SupplierCertificateView(this); 
            SupplierAccreditationView  = new SupplierAccreditationView(this); 
            NewSupplierFromCopyChildDialogView  = new NewSupplierFromCopyChildDialogView(this); 
            SupplierEmployeeView  = new SupplierEmployeeView(this); 
            SupplierPaymentView  = new SupplierPaymentView(this); 
            SupplierCollectionView.InitializeControls(); 
            SupplierEntityView.InitializeControls(); 
            SupplierContactView.InitializeControls(); 
            SupplierOrderAddressView.InitializeControls(); 
            SupplierBankAccountView.InitializeControls(); 
            SupplierReportView.InitializeControls(); 
            SupplierDetailView.InitializeControls(); 
            SupplierAuditView.InitializeControls(); 
            SupplierCertificateView.InitializeControls(); 
            SupplierAccreditationView.InitializeControls(); 
            NewSupplierFromCopyChildDialogView.InitializeControls(); 
            SupplierEmployeeView.InitializeControls(); 
            SupplierPaymentView.InitializeControls(); 
           
        }
      
            public SupplierCollectionView SupplierCollectionView {get; set; } 
            public SupplierEntityView SupplierEntityView {get; set; } 
            public SupplierContactView SupplierContactView {get; set; } 
            public SupplierOrderAddressView SupplierOrderAddressView {get; set; } 
            public SupplierBankAccountView SupplierBankAccountView {get; set; } 
            public SupplierReportView SupplierReportView {get; set; } 
            public SupplierDetailView SupplierDetailView {get; set; } 
            public SupplierAuditView SupplierAuditView {get; set; } 
            public SupplierCertificateView SupplierCertificateView {get; set; } 
            public SupplierAccreditationView SupplierAccreditationView {get; set; } 
            public NewSupplierFromCopyChildDialogView NewSupplierFromCopyChildDialogView {get; set; } 
            public SupplierEmployeeView SupplierEmployeeView {get; set; } 
            public SupplierPaymentView SupplierPaymentView {get; set; } 
    }
            
    public partial class SupplierCollectionView : View
    {
        public SupplierCollectionView(Supplier screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<SupplierCollectionView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "90e562d0-6864-4b0b-839e-9d8b29e12cd7",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<SupplierCollectionView,SupplierEntityView>( params_MainConsult,this,Screen.SupplierEntityView);
 

        }
        public IRPSButton<SupplierCollectionView,SupplierEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<SupplierCollectionView,SupplierEntityView> MainConsult { get; set; } 
        public Supplier Screen { get; set; }
        public SupplierCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SupplierEntityView : View
    {
        public SupplierEntityView(Supplier screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<SupplierEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierEntityView,SupplierCollectionView>( this,Screen.SupplierCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierEntityView,SupplierCollectionView>( this,Screen.SupplierCollectionView);
 
            CodSupplier = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("1f5cccd2-6aa5-4c79-a4bf-415bfaae5ee7","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("7fba3636-603a-452e-960c-e5df8ebefc78","","",false, this);
 
            CompanyName = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("f23b1388-9978-44db-80a6-5cbc66cb2fc9","","",false, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("43517e28-53d4-4c75-8009-abb10ca25b7e","","",false, this);
 
            ThirdType = RPSControlFactory.CreateRPSEnumComboBox<SupplierEntityView>("a8414f34-c771-4ada-b81d-3677139b8cc1","","",true, this);
 
            InactiveDate = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("ebaef574-f26c-4890-8a02-106692ba5110","","",false, this);
 
            IDSupplierClassification = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("6911f569-bbe7-4e2b-8ce1-1cf0d95f7e5d","","",false, this);
 
            IDSupplierType = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("41ec689f-bddf-47b2-8b02-115e6ba69e1f","","",false, this);
 
            IDBusinessUnit = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("8107fef2-cbcf-44fa-a068-b8c3159f3da9","","",false, this);
 
            IDSector = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("038a006c-5066-4792-aeba-92e92b719a4b","","",false, this);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("93d611c6-59c8-450b-a2c4-6b2937ce5666","","",false, this);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("41ae8ec9-a90a-4083-b7bc-5ea73bc07784","","",false, this);
 
            Ean13 = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("d991f17c-7480-4912-baa3-b5deafd94faf","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("5073b529-7ebf-4859-9491-3d9103ee0fdd","","",false, this);
 
            SupplierCustomerINFO = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("1c8e3a48-f1ff-4a53-aa09-8850b2e88d1d","","",false, this);
 
            Blocked = RPSControlFactory.CreateRPSCheckBox<SupplierEntityView>("e2ce7777-8178-4b01-a91e-3f9cbf51141f","","",true, this);
 
            Miscellaneous = RPSControlFactory.CreateRPSCheckBox<SupplierEntityView>("75e5e2ba-0050-47ef-9fdd-fd5bb48beabc","","",true, this);
 
            PurchaseManager = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("f75116a4-82d4-415d-874b-a3635aa220fd","","",false, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("8963df69-98dd-4222-9dcd-f852c3c75340","","",false, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("b8beb1c0-1971-4274-8c84-a7f708c53919","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("4202b833-dd9d-4fa7-b6db-3f26c3c926fe","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("cf8a5ab6-409b-4c7c-b015-d56b81c0cea8","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("304bfad7-22aa-4f05-88ac-c6042d9bffbf","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("61e8e06c-c1cb-4041-b2c2-0befee56ab74","","",false, this);
 
            Position = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("f9cca75f-82e0-495e-b5d8-69b92376ec19","","",false, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("f254eacd-c228-471a-9826-1f7398fb460b","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("38fc4054-388c-4088-9807-6b0a0cbc7b1a","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("c7b8e91b-81d1-417e-b569-0b05c9a746fa","","",false, this);
 
            Email = RPSControlFactory.CreateRPSEmailTextBox<SupplierEntityView>("8d71d50c-24d1-48f5-9fa5-3f0265b865ae","","",false, this);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("6b25ed67-3b2e-40e6-8b55-43eb4590e3e8","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("4a0d1581-951b-468d-b72b-c8bc33ad9f7c","","",true, this);
 
            Revaluation = RPSControlFactory.CreateRPSCheckBox<SupplierEntityView>("29018ab9-85a0-45d4-ad1d-6753e2f96e4b","","",true, this);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("bcfeac87-8f60-4efd-ac33-2acf10dc2af9","","",true, this);
 
            InvoiceType = RPSControlFactory.CreateRPSEnumComboBox<SupplierEntityView>("83ea4f17-e9f5-43d0-9c11-f9eb6ba48b92","","",false, this);
 
            TypeAdvanceInvoice = RPSControlFactory.CreateRPSEnumComboBox<SupplierEntityView>("c01d6b41-661d-44e5-b75b-aeae79e3b6d7","","",false, this);
 
            IDInvoicingType = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("ec169c50-51a1-4a02-8403-5f8ec9f55f80","","",false, this);
 
            IDBankAccountCompany = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("8f7faa41-b290-4a37-b580-59f7a8f0d608","","",false, this);
 
            IDThirdAccType = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("50e28380-e280-4977-ab0c-59bc3d43b705","","",false, this);
 
            IDVoucherType = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("f82e3521-eddb-4f20-82fb-d868c87aa24f","","",false, this);
 
            IDEUInvoice = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("ffd5ea72-b395-4772-a6b5-13353463a603","","",false, this);
 
            IDVATType = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("f069c73d-ee82-4055-a74d-6e256374d1fc","","",true, this);
 
            IDSurchargeVATType = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("c0be0931-9cd7-4c94-865b-401d924666d3","","",false, this);
 
            IDTaxGroup = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("c0693bca-6ad9-41ca-84f9-c4d61532be75","","",false, this);
 
            IDPaymentMethodRappel = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("181f545e-430c-4884-9645-0bd3d181c091","","",false, this);
 
            Discount1 = RPSControlFactory.CreateRPSFormattedTextBox<SupplierEntityView>("e7c79792-72fb-40b4-8a25-ce859c2674a2","","",true, this);
 
            Discount2 = RPSControlFactory.CreateRPSFormattedTextBox<SupplierEntityView>("4a8ad217-9a08-44a0-8719-bb21c18065b4","","",true, this);
 
            Discount3 = RPSControlFactory.CreateRPSFormattedTextBox<SupplierEntityView>("09588c5e-c92f-40d7-9739-40af35815fd7","","",true, this);
 
            CashDiscount = RPSControlFactory.CreateRPSFormattedTextBox<SupplierEntityView>("a7fc83d0-dbb9-413f-81aa-170b7aacdab9","","",true, this);
 
            FinancialSurcharge = RPSControlFactory.CreateRPSFormattedTextBox<SupplierEntityView>("5560436b-9961-492d-a5fd-02b1a3f89bd9","","",true, this);
 
            CommercialCondition = RPSControlFactory.CreateRPSEnumComboBox<SupplierEntityView>("ce544cc8-b404-4125-8c83-b869f6d5dc51","","",true, this);
 
            ConditionsAffectDocument = RPSControlFactory.CreateRPSCheckBox<SupplierEntityView>("45a56742-6d44-42c0-b142-52e520434282","","",true, this);
 
            ConditionsNotAffectDocument = RPSControlFactory.CreateRPSCheckBox<SupplierEntityView>("1dcac653-dee2-4853-a29e-6aed44b50600","","",true, this);
 
            MinAmountOrder = RPSControlFactory.CreateRPSFormattedTextBox<SupplierEntityView>("43852472-a88f-4135-a025-acdcf3ffd6b8","","",true, this);
 
            RetentionPercent = RPSControlFactory.CreateRPSFormattedTextBox<SupplierEntityView>("e8e5dcaa-f676-4a91-b824-dcfb6ce03ba1","","",true, this);
 
            RetentionType = RPSControlFactory.CreateRPSEnumComboBox<SupplierEntityView>("6c7781e1-329e-45f3-bd82-4da638c7bddb","","",true, this);
 
            Key = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("198dcb60-72e7-44b7-aafb-c164d37bd7be","","",false, this);
 
            SubKey = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("dc25460c-b51e-4797-9771-0c6bf1c98f6d","","",false, this);
 
            IDCodingSerieRetentionVoucher = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("7e508158-a6d7-43f4-a9c7-9a4ff0c2b7ae","","",false, this);
 
            IDCodingSerieOrder = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("4939b631-e775-4985-84ff-b2d5cf2944f7","","",false, this);
 
            IDCodingSerieDeliveryNote = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("d775cf27-4645-4b23-b9f7-5dcff4fc9057","","",false, this);
 
            IDCodingSerieFrameworkContract = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("4b511d0b-3bd7-4201-b7a5-bdff25d1840f","","",false, this);
 
            AutoLiquidate = RPSControlFactory.CreateRPSCheckBox<SupplierEntityView>("f81d901f-60f4-425e-96bf-9c3599efa959","","",true, this);
 
            IDCodingSerieInvoice = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("302fcf7f-7887-4c9c-b408-ed6de9250702","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("4030e757-f42f-4b95-9166-da88968987ca","","",false, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("1bdceea5-213d-4235-ba68-1e6a4040d4d3","","",false, this);
 
            DeliveryDays = RPSControlFactory.CreateRPSFormattedTextBox<SupplierEntityView>("cdbc5e48-563d-469c-ae42-97cf391a4e92","","",true, this);
 
            CodTransportMethod = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("fc7b336c-8fc6-4dec-be55-473ac512e396","","",false, this);
 
            CodDeliveryTerm = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("c0c77502-c64c-478e-abfc-1437bb9ddab6","","",false, this);
 
            IDShippingAgent = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("3c7e5912-12cc-45bd-9646-40d86f10659c","","",false, this);
 
            DayFixedPayment = RPSControlFactory.CreateRPSEnumComboBox<SupplierEntityView>("102a5231-7cad-4359-8669-6999f0c2c6ee","","",true, this);
 
            FirstDayPayment = RPSControlFactory.CreateRPSEnumComboBox<SupplierEntityView>("3d9a1b6a-3c1b-4c8a-9841-a331b0f8b679","","",true, this);
 
            SecondDayPayment = RPSControlFactory.CreateRPSEnumComboBox<SupplierEntityView>("a93cf924-6d6a-46ee-a898-c80e61002851","","",true, this);
 
            ThirdDayPayment = RPSControlFactory.CreateRPSEnumComboBox<SupplierEntityView>("0f081cbb-105d-4cb0-b00f-4f82a23ec61e","","",true, this);
 
            RGSA = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("5b6f22c5-5a73-43c8-a0b0-7e0ba6510e7d","","",false, this);
 
            ROESP = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("d8afe369-4c2f-4b42-8a16-4db5dde2c135","","",false, this);
 
            IDImportOrderType = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("4d49d64c-e729-49dd-a0a6-88cb3dab24ea","","",false, this);
 
            IDVatGL = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("e53fb68a-74bb-47c9-833f-0f56226fda78","","",false, this);
 
            IDAccountGL = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("af837d1a-d59f-4f63-972f-106a3c67d7b3","","",false, this);
 
            CommentSupplier = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("69a6422f-dadd-4be3-a76e-7c1d127962ed","","",false, this);
 
            CommentOrder = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("f8fb58f8-ec3f-4ad5-9344-6b769ca7da31","","",false, this);
 
            CommentDeliveryNote = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("20294770-997f-4162-900d-16ac86640594","","",false, this);
 
            CommentInvoice = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("efa82d62-7fcf-4758-b0db-508d4d1a6397","","",false, this);
 
            IDTextLineSRQuotationPre = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("a1e854a4-7a60-4a99-a098-8ca799f37140","","",false, this);
 
            IDTextLineFContractPre = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("45fd2392-9b96-42e5-aa2c-2b4b943adfa5","","",false, this);
 
            IDTextLineOrderPre = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("04881915-586c-4893-a682-eb24ef5c3ec7","","",false, this);
 
            IDTextLineSRQuotationPost = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("267dc6cc-8474-46e8-b7d2-797f47570c49","","",false, this);
 
            IDTextLineFContractPost = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("b3973b51-8e24-4f3a-9e4d-f407aeb3c9e9","","",false, this);
 
            IDTextLineOrderPost = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("cc835d81-ed95-4432-8c97-8df67a6cdb14","","",false, this);
 
            TextNoticeOrder = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("cb3f4f04-707f-498c-ba1c-3406c92bb078","","",false, this);
 
            TextNoticeOffer = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("cd2fad73-574f-420d-ba67-99f559edf34c","","",false, this);
 
            NewSupplierFromCopyChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<SupplierEntityView,NewSupplierFromCopyChildDialogView>("2515ddd2-d8c1-4cf2-ad9a-16ac045e3abf","","", this,Screen.NewSupplierFromCopyChildDialogView);
 
            ValidNIFCommandButton = RPSControlFactory.CreateRPSButton<SupplierEntityView>( "376fa96a-dcca-46e6-beef-c0410768ee01","","",this);
 
            CollectionInit params_SupplierContacts = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0ae8c7d8-f3cd-412e-b650-b853160fea58",CSSSelectorGrid="",XPathGrid=""};
            SupplierContacts = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierContactsCollectionEditor<SupplierEntityView,SupplierContactView>,SupplierEntityView,SupplierContactView>( params_SupplierContacts,this,Screen.SupplierContactView);
 
            CollectionInit params_SupplierOrderAddresss = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="03b8fe5c-ebf8-4641-bef1-e4bf4b571edb",CSSSelectorGrid="",XPathGrid=""};
            SupplierOrderAddresss = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierOrderAddresssCollectionEditor<SupplierEntityView,SupplierContactView>,SupplierEntityView,SupplierContactView>( params_SupplierOrderAddresss,this,Screen.SupplierContactView);
 
            CollectionInit params_SupplierBankAccounts = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ddfb5e71-6e0f-4ca6-939d-0450d40f0f86",CSSSelectorGrid="",XPathGrid=""};
            SupplierBankAccounts = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierBankAccountsCollectionEditor<SupplierEntityView,SupplierContactView>,SupplierEntityView,SupplierContactView>( params_SupplierBankAccounts,this,Screen.SupplierContactView);
 
            CollectionInit params_SupplierEmployees = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="224e243a-6171-4eb1-898a-4d37aefd1587",CSSSelectorGrid="",XPathGrid=""};
            SupplierEmployees = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierEmployeesCollectionEditor<SupplierEntityView,SupplierContactView>,SupplierEntityView,SupplierContactView>( params_SupplierEmployees,this,Screen.SupplierContactView);
 
            CollectionInit params_SupplierReports = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4bc9e0c5-92b8-45f8-95ae-6eac05105219",CSSSelectorGrid="",XPathGrid=""};
            SupplierReports = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierReportsCollectionEditor<SupplierEntityView,SupplierContactView>,SupplierEntityView,SupplierContactView>( params_SupplierReports,this,Screen.SupplierContactView);
 
            CollectionInit params_SupplierDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5834ea9f-3a36-443c-b15e-79a28d036f18",CSSSelectorGrid="",XPathGrid=""};
            SupplierDetails = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierDetailsCollectionEditor<SupplierEntityView,SupplierContactView>,SupplierEntityView,SupplierContactView>( params_SupplierDetails,this,Screen.SupplierContactView);
 
            CollectionInit params_SupplierAccreditations = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0dbc140a-b722-430b-a577-4bf24d9d3348",CSSSelectorGrid="",XPathGrid=""};
            SupplierAccreditations = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierAccreditationsCollectionEditor<SupplierEntityView,SupplierContactView>,SupplierEntityView,SupplierContactView>( params_SupplierAccreditations,this,Screen.SupplierContactView);
 
            CollectionInit params_SupplierCertificates = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8635d864-0cd3-4fcd-8392-1692c470762e",CSSSelectorGrid="",XPathGrid=""};
            SupplierCertificates = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierCertificatesCollectionEditor<SupplierEntityView,SupplierContactView>,SupplierEntityView,SupplierContactView>( params_SupplierCertificates,this,Screen.SupplierContactView);
 
            CollectionInit params_SupplierAudits = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c01ce737-019f-45dd-9875-4495be854095",CSSSelectorGrid="",XPathGrid=""};
            SupplierAudits = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierAuditsCollectionEditor<SupplierEntityView,SupplierContactView>,SupplierEntityView,SupplierContactView>( params_SupplierAudits,this,Screen.SupplierContactView);
 
            CollectionInit params_SupplierPayments = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5e5b62f3-7755-4668-811a-e9945c2eeae5",CSSSelectorGrid="",XPathGrid=""};
            SupplierPayments = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierPaymentsCollectionEditor<SupplierEntityView,SupplierContactView>,SupplierEntityView,SupplierContactView>( params_SupplierPayments,this,Screen.SupplierContactView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<SupplierEntityView>( "","ul li[rpsid='b60f3198-66a3-4829-a47c-5567c0f3e8d1']","",this);
 
            Configuration = RPSControlFactory.CreateRPSSection<SupplierEntityView>( "","ul li[rpsid='9480abf5-2921-4f85-8dd9-d740c8d5a4d3']","",this);
 
            Contact = RPSControlFactory.CreateRPSSection<SupplierEntityView>( "","ul li[rpsid='de02b137-16d0-4c36-8e68-b7cd5267c0d8']","",this);
 
            OrderAddresses = RPSControlFactory.CreateRPSSection<SupplierEntityView>( "","ul li[rpsid='9783f57f-eb05-4915-a3fe-03ed1a05aa06']","",this);
 
            SupplierBank = RPSControlFactory.CreateRPSSection<SupplierEntityView>( "","ul li[rpsid='a1342e35-28c2-4287-a4c3-e6317b506d3f']","",this);
 
            Employees = RPSControlFactory.CreateRPSSection<SupplierEntityView>( "","ul li[rpsid='12f4ff64-7c37-4dde-ac85-6be75c6c5b4b']","",this);
 
            Reports = RPSControlFactory.CreateRPSSection<SupplierEntityView>( "","ul li[rpsid='252b9cdb-058f-4de4-8fab-3993ebc88435']","",this);
 
            Subsidiaries = RPSControlFactory.CreateRPSSection<SupplierEntityView>( "","ul li[rpsid='3a312727-09e9-40b8-bcfa-6bc89fbe1357']","",this);
 
            Accreditations = RPSControlFactory.CreateRPSSection<SupplierEntityView>( "","ul li[rpsid='b0bfc7ec-4b3e-402c-956b-3e19290e2e0c']","",this);
 
            Certificates = RPSControlFactory.CreateRPSSection<SupplierEntityView>( "","ul li[rpsid='f5cb99b8-4d5e-44fd-9549-2f57b9546b4d']","",this);
 
            Audits = RPSControlFactory.CreateRPSSection<SupplierEntityView>( "","ul li[rpsid='932123f7-2cba-4ab8-954b-312e535701d9']","",this);
 
            SupplierPayments1 = RPSControlFactory.CreateRPSSection<SupplierEntityView>( "","ul li[rpsid='8cac21d4-718e-4eec-9d03-511d4de857cf']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<SupplierEntityView>( "","ul li[rpsid='c38b50c5-b66d-4cee-a1bd-2787bde9f05a']","",this);
 

        }
        public IRPSSaveButton<SupplierEntityView> SaveButton { get; set; } 
        public IRPSButton<SupplierEntityView> DeleteButton { get; set; } 
        public IRPSButton<SupplierEntityView,SupplierCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierEntityView,SupplierCollectionView> BackButton { get; set; } 
        public IRPSTextBox<SupplierEntityView> CodSupplier { get; set; } 
        public IRPSTextBox<SupplierEntityView> Description { get; set; } 
        public IRPSTextBox<SupplierEntityView> CompanyName { get; set; } 
        public IRPSTextBox<SupplierEntityView> VATNumber { get; set; } 
        public IRPSComboBox<SupplierEntityView> ThirdType { get; set; } 
        public IRPSTextBox<SupplierEntityView> InactiveDate { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDSupplierClassification { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDSupplierType { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDBusinessUnit { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDSector { get; set; } 
        public IRPSComboBox<SupplierEntityView> CodLanguage { get; set; } 
        public IRPSComboBox<SupplierEntityView> CodUser { get; set; } 
        public IRPSTextBox<SupplierEntityView> Ean13 { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDCustomer { get; set; } 
        public IRPSTextBox<SupplierEntityView> SupplierCustomerINFO { get; set; } 
        public IRPSCheckbox<SupplierEntityView> Blocked { get; set; } 
        public IRPSCheckbox<SupplierEntityView> Miscellaneous { get; set; } 
        public IRPSComboBox<SupplierEntityView> PurchaseManager { get; set; } 
        public IRPSComboBox<SupplierEntityView> CodCountry { get; set; } 
        public IRPSTextBox<SupplierEntityView> ZipCode { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDState { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDCounty { get; set; } 
        public IRPSTextBox<SupplierEntityView> Address { get; set; } 
        public IRPSTextBox<SupplierEntityView> City { get; set; } 
        public IRPSTextBox<SupplierEntityView> Position { get; set; } 
        public IRPSTextBox<SupplierEntityView> Phone1 { get; set; } 
        public IRPSTextBox<SupplierEntityView> Phone2 { get; set; } 
        public IRPSTextBox<SupplierEntityView> Fax { get; set; } 
        public IRPSTextBox<SupplierEntityView> Email { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDPaymentMethod { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDCurrency { get; set; } 
        public IRPSCheckbox<SupplierEntityView> Revaluation { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDDeliveryNoteType { get; set; } 
        public IRPSComboBox<SupplierEntityView> InvoiceType { get; set; } 
        public IRPSComboBox<SupplierEntityView> TypeAdvanceInvoice { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDInvoicingType { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDBankAccountCompany { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDThirdAccType { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDVoucherType { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDEUInvoice { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDVATType { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDSurchargeVATType { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDTaxGroup { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDPaymentMethodRappel { get; set; } 
        public IRPSTextBox<SupplierEntityView> Discount1 { get; set; } 
        public IRPSTextBox<SupplierEntityView> Discount2 { get; set; } 
        public IRPSTextBox<SupplierEntityView> Discount3 { get; set; } 
        public IRPSTextBox<SupplierEntityView> CashDiscount { get; set; } 
        public IRPSTextBox<SupplierEntityView> FinancialSurcharge { get; set; } 
        public IRPSComboBox<SupplierEntityView> CommercialCondition { get; set; } 
        public IRPSCheckbox<SupplierEntityView> ConditionsAffectDocument { get; set; } 
        public IRPSCheckbox<SupplierEntityView> ConditionsNotAffectDocument { get; set; } 
        public IRPSTextBox<SupplierEntityView> MinAmountOrder { get; set; } 
        public IRPSTextBox<SupplierEntityView> RetentionPercent { get; set; } 
        public IRPSComboBox<SupplierEntityView> RetentionType { get; set; } 
        public IRPSTextBox<SupplierEntityView> Key { get; set; } 
        public IRPSTextBox<SupplierEntityView> SubKey { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDCodingSerieRetentionVoucher { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDCodingSerieOrder { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDCodingSerieDeliveryNote { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDCodingSerieFrameworkContract { get; set; } 
        public IRPSCheckbox<SupplierEntityView> AutoLiquidate { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDCodingSerieInvoice { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDSite { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDWarehouse { get; set; } 
        public IRPSTextBox<SupplierEntityView> DeliveryDays { get; set; } 
        public IRPSComboBox<SupplierEntityView> CodTransportMethod { get; set; } 
        public IRPSComboBox<SupplierEntityView> CodDeliveryTerm { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDShippingAgent { get; set; } 
        public IRPSComboBox<SupplierEntityView> DayFixedPayment { get; set; } 
        public IRPSComboBox<SupplierEntityView> FirstDayPayment { get; set; } 
        public IRPSComboBox<SupplierEntityView> SecondDayPayment { get; set; } 
        public IRPSComboBox<SupplierEntityView> ThirdDayPayment { get; set; } 
        public IRPSTextBox<SupplierEntityView> RGSA { get; set; } 
        public IRPSTextBox<SupplierEntityView> ROESP { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDImportOrderType { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDVatGL { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDAccountGL { get; set; } 
        public IRPSTextBox<SupplierEntityView> CommentSupplier { get; set; } 
        public IRPSTextBox<SupplierEntityView> CommentOrder { get; set; } 
        public IRPSTextBox<SupplierEntityView> CommentDeliveryNote { get; set; } 
        public IRPSTextBox<SupplierEntityView> CommentInvoice { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDTextLineSRQuotationPre { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDTextLineFContractPre { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDTextLineOrderPre { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDTextLineSRQuotationPost { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDTextLineFContractPost { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDTextLineOrderPost { get; set; } 
        public IRPSTextBox<SupplierEntityView> TextNoticeOrder { get; set; } 
        public IRPSTextBox<SupplierEntityView> TextNoticeOffer { get; set; } 
        public IRPSButton<SupplierEntityView,NewSupplierFromCopyChildDialogView> NewSupplierFromCopyChildNavigationCommandButton { get; set; } 
        public IRPSButton<SupplierEntityView> ValidNIFCommandButton { get; set; } 
        public SupplierContactsCollectionEditor<SupplierEntityView,SupplierContactView> SupplierContacts { get; set; } 
        public SupplierOrderAddresssCollectionEditor<SupplierEntityView,SupplierContactView> SupplierOrderAddresss { get; set; } 
        public SupplierBankAccountsCollectionEditor<SupplierEntityView,SupplierContactView> SupplierBankAccounts { get; set; } 
        public SupplierEmployeesCollectionEditor<SupplierEntityView,SupplierContactView> SupplierEmployees { get; set; } 
        public SupplierReportsCollectionEditor<SupplierEntityView,SupplierContactView> SupplierReports { get; set; } 
        public SupplierDetailsCollectionEditor<SupplierEntityView,SupplierContactView> SupplierDetails { get; set; } 
        public SupplierAccreditationsCollectionEditor<SupplierEntityView,SupplierContactView> SupplierAccreditations { get; set; } 
        public SupplierCertificatesCollectionEditor<SupplierEntityView,SupplierContactView> SupplierCertificates { get; set; } 
        public SupplierAuditsCollectionEditor<SupplierEntityView,SupplierContactView> SupplierAudits { get; set; } 
        public SupplierPaymentsCollectionEditor<SupplierEntityView,SupplierContactView> SupplierPayments { get; set; } 
        public IRPSSection<SupplierEntityView> GeneralData { get; set; } 
        public IRPSSection<SupplierEntityView> Configuration { get; set; } 
        public IRPSSection<SupplierEntityView> Contact { get; set; } 
        public IRPSSection<SupplierEntityView> OrderAddresses { get; set; } 
        public IRPSSection<SupplierEntityView> SupplierBank { get; set; } 
        public IRPSSection<SupplierEntityView> Employees { get; set; } 
        public IRPSSection<SupplierEntityView> Reports { get; set; } 
        public IRPSSection<SupplierEntityView> Subsidiaries { get; set; } 
        public IRPSSection<SupplierEntityView> Accreditations { get; set; } 
        public IRPSSection<SupplierEntityView> Certificates { get; set; } 
        public IRPSSection<SupplierEntityView> Audits { get; set; } 
        public IRPSSection<SupplierEntityView> SupplierPayments1 { get; set; } 
        public IRPSSection<SupplierEntityView> Comments { get; set; } 
        public Supplier Screen { get; set; }
        public SupplierEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SupplierContactsCollectionEditor<SupplierEntityView,SupplierContactView>:RPSCollectionEditor<SupplierEntityView,SupplierContactView> where SupplierEntityView : class, IView where SupplierContactView : class, IView
    {
        public  SupplierContactsGridView<SupplierEntityView,SupplierContactView> GridView {get;set;}
    }
    public partial class SupplierContactsGridView <SupplierEntityView,SupplierContactView> :  RPSGridView<SupplierEntityView,SupplierContactView> where SupplierEntityView : class, IView where SupplierContactView : class, IView
    {
        public SupplierContactsGridView(SupplierEntityView currentView,SupplierContactView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Description = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#0ae8c7d8-f3cd-412e-b650-b853160fea58 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",true, this.CurrentView);
 
            Phone1 = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#0ae8c7d8-f3cd-412e-b650-b853160fea58 .ag-row[role='row']@ROWINDEX [col-id='cPhone1']","",false, this.CurrentView);
 
            Phone2 = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#0ae8c7d8-f3cd-412e-b650-b853160fea58 .ag-row[role='row']@ROWINDEX [col-id='cPhone2']","",false, this.CurrentView);
 
            DefaultCommercial = RPSControlFactory.CreateRPSGridCheckBox<SupplierEntityView>("","#0ae8c7d8-f3cd-412e-b650-b853160fea58 .ag-row[role='row']@ROWINDEX [col-id='cDefaultCommercial']","",true, this.CurrentView);
 
            DefaultAdministration = RPSControlFactory.CreateRPSGridCheckBox<SupplierEntityView>("","#0ae8c7d8-f3cd-412e-b650-b853160fea58 .ag-row[role='row']@ROWINDEX [col-id='cDefaultAdministration']","",true, this.CurrentView);
 
            DefaultFinancial = RPSControlFactory.CreateRPSGridCheckBox<SupplierEntityView>("","#0ae8c7d8-f3cd-412e-b650-b853160fea58 .ag-row[role='row']@ROWINDEX [col-id='cDefaultFinancial']","",true, this.CurrentView);
 
            Email = RPSControlFactory.CreateRPSGridEmailTextBox<SupplierEntityView>("","#0ae8c7d8-f3cd-412e-b650-b853160fea58 .ag-row[role='row']@ROWINDEX [col-id='cEmail']","",false, this.CurrentView);
 
            CodUser = RPSControlFactory.CreateRPSGridComboBox<SupplierEntityView>("","#0ae8c7d8-f3cd-412e-b650-b853160fea58 .ag-row[role='row']@ROWINDEX [col-id='cCodUser']","",false, this.CurrentView);
 
            InactiveDate = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#0ae8c7d8-f3cd-412e-b650-b853160fea58 .ag-row[role='row']@ROWINDEX [col-id='cInactiveDate']","",false, this.CurrentView);
 
            FirstName = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#0ae8c7d8-f3cd-412e-b650-b853160fea58 .ag-row[role='row']@ROWINDEX [col-id='cFirstName']","",false, this.CurrentView);
 
            LastName = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#0ae8c7d8-f3cd-412e-b650-b853160fea58 .ag-row[role='row']@ROWINDEX [col-id='cLastName']","",false, this.CurrentView);
 
            Gender = RPSControlFactory.CreateRPSGridEnumComboBox<SupplierEntityView>("","#0ae8c7d8-f3cd-412e-b650-b853160fea58 .ag-row[role='row']@ROWINDEX [col-id='cGender']","",true, this.CurrentView);
 
            Title = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#0ae8c7d8-f3cd-412e-b650-b853160fea58 .ag-row[role='row']@ROWINDEX [col-id='cTitle']","",false, this.CurrentView);
 
            Position = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#0ae8c7d8-f3cd-412e-b650-b853160fea58 .ag-row[role='row']@ROWINDEX [col-id='cPosition']","",false, this.CurrentView);
 
            Mobile = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#0ae8c7d8-f3cd-412e-b650-b853160fea58 .ag-row[role='row']@ROWINDEX [col-id='cMobile']","",false, this.CurrentView);
 
            Location = RPSControlFactory.CreateRPSGridMemoTextBox<SupplierEntityView>("","#0ae8c7d8-f3cd-412e-b650-b853160fea58 .ag-row[role='row']@ROWINDEX [col-id='cLocation']","",false, this.CurrentView);
 
            SkypeName = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#0ae8c7d8-f3cd-412e-b650-b853160fea58 .ag-row[role='row']@ROWINDEX [col-id='cSkypeName']","",false, this.CurrentView);
 
            Newsletter = RPSControlFactory.CreateRPSGridCheckBox<SupplierEntityView>("","#0ae8c7d8-f3cd-412e-b650-b853160fea58 .ag-row[role='row']@ROWINDEX [col-id='cNewsletter']","",true, this.CurrentView);
 
            DateOfBirth = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#0ae8c7d8-f3cd-412e-b650-b853160fea58 .ag-row[role='row']@ROWINDEX [col-id='cDateOfBirth']","",false, this.CurrentView);
 
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<SupplierEntityView>("","#0ae8c7d8-f3cd-412e-b650-b853160fea58 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",false, this.CurrentView);
 
            Department = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#0ae8c7d8-f3cd-412e-b650-b853160fea58 .ag-row[role='row']@ROWINDEX [col-id='cDepartment']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SupplierEntityView> Description { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Phone1 { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Phone2 { get; set; } 
        public IRPSGridCheckbox<SupplierEntityView> DefaultCommercial { get; set; } 
        public IRPSGridCheckbox<SupplierEntityView> DefaultAdministration { get; set; } 
        public IRPSGridCheckbox<SupplierEntityView> DefaultFinancial { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Email { get; set; } 
        public IRPSGridComboBox<SupplierEntityView> CodUser { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> InactiveDate { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> FirstName { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> LastName { get; set; } 
        public IRPSGridComboBox<SupplierEntityView> Gender { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Title { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Position { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Mobile { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Location { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> SkypeName { get; set; } 
        public IRPSGridCheckbox<SupplierEntityView> Newsletter { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> DateOfBirth { get; set; } 
        public IRPSGridComboBox<SupplierEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Department { get; set; } 
                     
    }
 
        public partial class SupplierOrderAddresssCollectionEditor<SupplierEntityView,SupplierContactView>:RPSCollectionEditor<SupplierEntityView,SupplierContactView> where SupplierEntityView : class, IView where SupplierContactView : class, IView
    {
        public  SupplierOrderAddresssGridView<SupplierEntityView,SupplierContactView> GridView {get;set;}
    }
    public partial class SupplierOrderAddresssGridView <SupplierEntityView,SupplierContactView> :  RPSGridView<SupplierEntityView,SupplierContactView> where SupplierEntityView : class, IView where SupplierContactView : class, IView
    {
        public SupplierOrderAddresssGridView(SupplierEntityView currentView,SupplierContactView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodSupplierOrderAddress = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#03b8fe5c-ebf8-4641-bef1-e4bf4b571edb .ag-row[role='row']@ROWINDEX [col-id='cCodSupplierOrderAddress']","",true, this.CurrentView);
 
            DefaultAddress = RPSControlFactory.CreateRPSGridCheckBox<SupplierEntityView>("","#03b8fe5c-ebf8-4641-bef1-e4bf4b571edb .ag-row[role='row']@ROWINDEX [col-id='cDefaultAddress']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#03b8fe5c-ebf8-4641-bef1-e4bf4b571edb .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Phone1 = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#03b8fe5c-ebf8-4641-bef1-e4bf4b571edb .ag-row[role='row']@ROWINDEX [col-id='cPhone1']","",false, this.CurrentView);
 
            Email = RPSControlFactory.CreateRPSGridEmailTextBox<SupplierEntityView>("","#03b8fe5c-ebf8-4641-bef1-e4bf4b571edb .ag-row[role='row']@ROWINDEX [col-id='cEmail']","",false, this.CurrentView);
 
            ContactPerson = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#03b8fe5c-ebf8-4641-bef1-e4bf4b571edb .ag-row[role='row']@ROWINDEX [col-id='cContactPerson']","",false, this.CurrentView);
 
            IDShippingAgent = RPSControlFactory.CreateRPSGridComboBox<SupplierEntityView>("","#03b8fe5c-ebf8-4641-bef1-e4bf4b571edb .ag-row[role='row']@ROWINDEX [col-id='cIDShippingAgent']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SupplierEntityView> CodSupplierOrderAddress { get; set; } 
        public IRPSGridCheckbox<SupplierEntityView> DefaultAddress { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Description { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Phone1 { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Email { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> ContactPerson { get; set; } 
        public IRPSGridComboBox<SupplierEntityView> IDShippingAgent { get; set; } 
                     
    }
 
        public partial class SupplierBankAccountsCollectionEditor<SupplierEntityView,SupplierContactView>:RPSCollectionEditor<SupplierEntityView,SupplierContactView> where SupplierEntityView : class, IView where SupplierContactView : class, IView
    {
        public  SupplierBankAccountsGridView<SupplierEntityView,SupplierContactView> GridView {get;set;}
    }
    public partial class SupplierBankAccountsGridView <SupplierEntityView,SupplierContactView> :  RPSGridView<SupplierEntityView,SupplierContactView> where SupplierEntityView : class, IView where SupplierContactView : class, IView
    {
        public SupplierBankAccountsGridView(SupplierEntityView currentView,SupplierContactView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodSupplierBankAccount = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#ddfb5e71-6e0f-4ca6-939d-0450d40f0f86 .ag-row[role='row']@ROWINDEX [col-id='cCodSupplierBankAccount']","",true, this.CurrentView);
 
            Default = RPSControlFactory.CreateRPSGridCheckBox<SupplierEntityView>("","#ddfb5e71-6e0f-4ca6-939d-0450d40f0f86 .ag-row[role='row']@ROWINDEX [col-id='cDefault']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#ddfb5e71-6e0f-4ca6-939d-0450d40f0f86 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            CodBank = RPSControlFactory.CreateRPSGridComboBox<SupplierEntityView>("","#ddfb5e71-6e0f-4ca6-939d-0450d40f0f86 .ag-row[role='row']@ROWINDEX [col-id='cCodBank']","",false, this.CurrentView);
 
            BankAccount = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#ddfb5e71-6e0f-4ca6-939d-0450d40f0f86 .ag-row[role='row']@ROWINDEX [col-id='cBankAccount']","",false, this.CurrentView);
 
            IBAN = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#ddfb5e71-6e0f-4ca6-939d-0450d40f0f86 .ag-row[role='row']@ROWINDEX [col-id='cIBAN']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SupplierEntityView> CodSupplierBankAccount { get; set; } 
        public IRPSGridCheckbox<SupplierEntityView> Default { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Description { get; set; } 
        public IRPSGridComboBox<SupplierEntityView> CodBank { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> BankAccount { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> IBAN { get; set; } 
                     
    }
 
        public partial class SupplierEmployeesCollectionEditor<SupplierEntityView,SupplierContactView>:RPSCollectionEditor<SupplierEntityView,SupplierContactView> where SupplierEntityView : class, IView where SupplierContactView : class, IView
    {
        public  SupplierEmployeesGridView<SupplierEntityView,SupplierContactView> GridView {get;set;}
    }
    public partial class SupplierEmployeesGridView <SupplierEntityView,SupplierContactView> :  RPSGridView<SupplierEntityView,SupplierContactView> where SupplierEntityView : class, IView where SupplierContactView : class, IView
    {
        public SupplierEmployeesGridView(SupplierEntityView currentView,SupplierContactView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDEmployee = RPSControlFactory.CreateRPSGridComboBox<SupplierEntityView>("","#224e243a-6171-4eb1-898a-4d37aefd1587 .ag-row[role='row']@ROWINDEX [col-id='cIDEmployee']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<SupplierEntityView> IDEmployee { get; set; } 
                     
    }
 
        public partial class SupplierReportsCollectionEditor<SupplierEntityView,SupplierContactView>:RPSCollectionEditor<SupplierEntityView,SupplierContactView> where SupplierEntityView : class, IView where SupplierContactView : class, IView
    {
        public  SupplierReportsGridView<SupplierEntityView,SupplierContactView> GridView {get;set;}
    }
    public partial class SupplierReportsGridView <SupplierEntityView,SupplierContactView> :  RPSGridView<SupplierEntityView,SupplierContactView> where SupplierEntityView : class, IView where SupplierContactView : class, IView
    {
        public SupplierReportsGridView(SupplierEntityView currentView,SupplierContactView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            FormatType = RPSControlFactory.CreateRPSGridEnumComboBox<SupplierEntityView>("","#4bc9e0c5-92b8-45f8-95ae-6eac05105219 .ag-row[role='row']@ROWINDEX [col-id='cFormatType']","",true, this.CurrentView);
 
            DefaultReport = RPSControlFactory.CreateRPSGridCheckBox<SupplierEntityView>("","#4bc9e0c5-92b8-45f8-95ae-6eac05105219 .ag-row[role='row']@ROWINDEX [col-id='cDefaultReport']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#4bc9e0c5-92b8-45f8-95ae-6eac05105219 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            IDCustomReport = RPSControlFactory.CreateRPSGridComboBox<SupplierEntityView>("","#4bc9e0c5-92b8-45f8-95ae-6eac05105219 .ag-row[role='row']@ROWINDEX [col-id='cIDCustomReport']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<SupplierEntityView> FormatType { get; set; } 
        public IRPSGridCheckbox<SupplierEntityView> DefaultReport { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Description { get; set; } 
        public IRPSGridComboBox<SupplierEntityView> IDCustomReport { get; set; } 
                     
    }
 
        public partial class SupplierDetailsCollectionEditor<SupplierEntityView,SupplierContactView>:RPSCollectionEditor<SupplierEntityView,SupplierContactView> where SupplierEntityView : class, IView where SupplierContactView : class, IView
    {
        public  SupplierDetailsGridView<SupplierEntityView,SupplierContactView> GridView {get;set;}
    }
    public partial class SupplierDetailsGridView <SupplierEntityView,SupplierContactView> :  RPSGridView<SupplierEntityView,SupplierContactView> where SupplierEntityView : class, IView where SupplierContactView : class, IView
    {
        public SupplierDetailsGridView(SupplierEntityView currentView,SupplierContactView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodCompany = RPSControlFactory.CreateRPSGridComboBox<SupplierEntityView>("","#5834ea9f-3a36-443c-b15e-79a28d036f18 .ag-row[role='row']@ROWINDEX [col-id='cCodCompany']","",true, this.CurrentView);
 
            IDBusinessUnit = RPSControlFactory.CreateRPSGridComboBox<SupplierEntityView>("","#5834ea9f-3a36-443c-b15e-79a28d036f18 .ag-row[role='row']@ROWINDEX [col-id='cIDBusinessUnit']","",false, this.CurrentView);
 
            IDCurrency = RPSControlFactory.CreateRPSGridComboBox<SupplierEntityView>("","#5834ea9f-3a36-443c-b15e-79a28d036f18 .ag-row[role='row']@ROWINDEX [col-id='cIDCurrency']","",true, this.CurrentView);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSGridComboBox<SupplierEntityView>("","#5834ea9f-3a36-443c-b15e-79a28d036f18 .ag-row[role='row']@ROWINDEX [col-id='cIDPaymentMethod']","",false, this.CurrentView);
 
            IDPaymentMethodRappel = RPSControlFactory.CreateRPSGridComboBox<SupplierEntityView>("","#5834ea9f-3a36-443c-b15e-79a28d036f18 .ag-row[role='row']@ROWINDEX [col-id='cIDPaymentMethodRappel']","",false, this.CurrentView);
 
            IDVATType = RPSControlFactory.CreateRPSGridComboBox<SupplierEntityView>("","#5834ea9f-3a36-443c-b15e-79a28d036f18 .ag-row[role='row']@ROWINDEX [col-id='cIDVATType']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<SupplierEntityView> CodCompany { get; set; } 
        public IRPSGridComboBox<SupplierEntityView> IDBusinessUnit { get; set; } 
        public IRPSGridComboBox<SupplierEntityView> IDCurrency { get; set; } 
        public IRPSGridComboBox<SupplierEntityView> IDPaymentMethod { get; set; } 
        public IRPSGridComboBox<SupplierEntityView> IDPaymentMethodRappel { get; set; } 
        public IRPSGridComboBox<SupplierEntityView> IDVATType { get; set; } 
                     
    }
 
        public partial class SupplierAccreditationsCollectionEditor<SupplierEntityView,SupplierContactView>:RPSCollectionEditor<SupplierEntityView,SupplierContactView> where SupplierEntityView : class, IView where SupplierContactView : class, IView
    {
        public  SupplierAccreditationsGridView<SupplierEntityView,SupplierContactView> GridView {get;set;}
    }
    public partial class SupplierAccreditationsGridView <SupplierEntityView,SupplierContactView> :  RPSGridView<SupplierEntityView,SupplierContactView> where SupplierEntityView : class, IView where SupplierContactView : class, IView
    {
        public SupplierAccreditationsGridView(SupplierEntityView currentView,SupplierContactView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDAccreditation = RPSControlFactory.CreateRPSGridComboBox<SupplierEntityView>("","#0dbc140a-b722-430b-a577-4bf24d9d3348 .ag-row[role='row']@ROWINDEX [col-id='cIDAccreditation']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<SupplierEntityView> IDAccreditation { get; set; } 
                     
    }
 
        public partial class SupplierCertificatesCollectionEditor<SupplierEntityView,SupplierContactView>:RPSCollectionEditor<SupplierEntityView,SupplierContactView> where SupplierEntityView : class, IView where SupplierContactView : class, IView
    {
        public  SupplierCertificatesGridView<SupplierEntityView,SupplierContactView> GridView {get;set;}
    }
    public partial class SupplierCertificatesGridView <SupplierEntityView,SupplierContactView> :  RPSGridView<SupplierEntityView,SupplierContactView> where SupplierEntityView : class, IView where SupplierContactView : class, IView
    {
        public SupplierCertificatesGridView(SupplierEntityView currentView,SupplierContactView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodCertificate = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#8635d864-0cd3-4fcd-8392-1692c470762e .ag-row[role='row']@ROWINDEX [col-id='cCodCertificate']","",true, this.CurrentView);
 
            Certificate = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#8635d864-0cd3-4fcd-8392-1692c470762e .ag-row[role='row']@ROWINDEX [col-id='cCertificate']","",false, this.CurrentView);
 
            DeliveredBy = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#8635d864-0cd3-4fcd-8392-1692c470762e .ag-row[role='row']@ROWINDEX [col-id='cDeliveredBy']","",false, this.CurrentView);
 
            Date = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#8635d864-0cd3-4fcd-8392-1692c470762e .ag-row[role='row']@ROWINDEX [col-id='cDate']","",false, this.CurrentView);
 
            ExpiryDate = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#8635d864-0cd3-4fcd-8392-1692c470762e .ag-row[role='row']@ROWINDEX [col-id='cExpiryDate']","",false, this.CurrentView);
 
            Note = RPSControlFactory.CreateRPSGridMemoTextBox<SupplierEntityView>("","#8635d864-0cd3-4fcd-8392-1692c470762e .ag-row[role='row']@ROWINDEX [col-id='cNote']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SupplierEntityView> CodCertificate { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Certificate { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> DeliveredBy { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Date { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> ExpiryDate { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Note { get; set; } 
                     
    }
 
        public partial class SupplierAuditsCollectionEditor<SupplierEntityView,SupplierContactView>:RPSCollectionEditor<SupplierEntityView,SupplierContactView> where SupplierEntityView : class, IView where SupplierContactView : class, IView
    {
        public  SupplierAuditsGridView<SupplierEntityView,SupplierContactView> GridView {get;set;}
    }
    public partial class SupplierAuditsGridView <SupplierEntityView,SupplierContactView> :  RPSGridView<SupplierEntityView,SupplierContactView> where SupplierEntityView : class, IView where SupplierContactView : class, IView
    {
        public SupplierAuditsGridView(SupplierEntityView currentView,SupplierContactView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Type = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#c01ce737-019f-45dd-9875-4495be854095 .ag-row[role='row']@ROWINDEX [col-id='cType']","",false, this.CurrentView);
 
            CodAudit = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#c01ce737-019f-45dd-9875-4495be854095 .ag-row[role='row']@ROWINDEX [col-id='cCodAudit']","",true, this.CurrentView);
 
            Date = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#c01ce737-019f-45dd-9875-4495be854095 .ag-row[role='row']@ROWINDEX [col-id='cDate']","",false, this.CurrentView);
 
            Report = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#c01ce737-019f-45dd-9875-4495be854095 .ag-row[role='row']@ROWINDEX [col-id='cReport']","",false, this.CurrentView);
 
            Valoration = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#c01ce737-019f-45dd-9875-4495be854095 .ag-row[role='row']@ROWINDEX [col-id='cValoration']","",false, this.CurrentView);
 
            Punctuation = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#c01ce737-019f-45dd-9875-4495be854095 .ag-row[role='row']@ROWINDEX [col-id='cPunctuation']","",false, this.CurrentView);
 
            Observation = RPSControlFactory.CreateRPSGridMemoTextBox<SupplierEntityView>("","#c01ce737-019f-45dd-9875-4495be854095 .ag-row[role='row']@ROWINDEX [col-id='cObservation']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SupplierEntityView> Type { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> CodAudit { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Date { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Report { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Valoration { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Punctuation { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Observation { get; set; } 
                     
    }
 
        public partial class SupplierPaymentsCollectionEditor<SupplierEntityView,SupplierContactView>:RPSCollectionEditor<SupplierEntityView,SupplierContactView> where SupplierEntityView : class, IView where SupplierContactView : class, IView
    {
        public  SupplierPaymentsGridView<SupplierEntityView,SupplierContactView> GridView {get;set;}
    }
    public partial class SupplierPaymentsGridView <SupplierEntityView,SupplierContactView> :  RPSGridView<SupplierEntityView,SupplierContactView> where SupplierEntityView : class, IView where SupplierContactView : class, IView
    {
        public SupplierPaymentsGridView(SupplierEntityView currentView,SupplierContactView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDSupplierPayer = RPSControlFactory.CreateRPSGridComboBox<SupplierEntityView>("","#5e5b62f3-7755-4668-811a-e9945c2eeae5 .ag-row[role='row']@ROWINDEX [col-id='cIDSupplierPayer']","",true, this.CurrentView);
 
            CodSupplierPayment = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#5e5b62f3-7755-4668-811a-e9945c2eeae5 .ag-row[role='row']@ROWINDEX [col-id='cCodSupplierPayment']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#5e5b62f3-7755-4668-811a-e9945c2eeae5 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Default = RPSControlFactory.CreateRPSGridCheckBox<SupplierEntityView>("","#5e5b62f3-7755-4668-811a-e9945c2eeae5 .ag-row[role='row']@ROWINDEX [col-id='cDefault']","",true, this.CurrentView);
 
            ContactPerson = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#5e5b62f3-7755-4668-811a-e9945c2eeae5 .ag-row[role='row']@ROWINDEX [col-id='cContactPerson']","",false, this.CurrentView);
 
            Phone1 = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#5e5b62f3-7755-4668-811a-e9945c2eeae5 .ag-row[role='row']@ROWINDEX [col-id='cPhone1']","",false, this.CurrentView);
 
            Email = RPSControlFactory.CreateRPSGridEmailTextBox<SupplierEntityView>("","#5e5b62f3-7755-4668-811a-e9945c2eeae5 .ag-row[role='row']@ROWINDEX [col-id='cEmail']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<SupplierEntityView> IDSupplierPayer { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> CodSupplierPayment { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Description { get; set; } 
        public IRPSGridCheckbox<SupplierEntityView> Default { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> ContactPerson { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Phone1 { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Email { get; set; } 
                     
    }
 
    }
  
            
    public partial class SupplierContactView : View
    {
        public SupplierContactView(Supplier screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierContactView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierContactView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierContactView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SupplierContactView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            InactiveDate = RPSControlFactory.CreateRPSTextBox<SupplierContactView>("cac85d21-cd80-4567-a19c-7eb7fe43261c","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SupplierContactView>("41a18ce0-7854-4fd0-85f7-696acc941afe","","",true, this);
 
            DefaultAdministration = RPSControlFactory.CreateRPSCheckBox<SupplierContactView>("74e19b74-6fd6-4df8-a90c-323fa9197adb","","",true, this);
 
            DefaultCommercial = RPSControlFactory.CreateRPSCheckBox<SupplierContactView>("cb9ee5de-1435-41ba-b240-7bc6ef0c6666","","",true, this);
 
            DefaultFinancial = RPSControlFactory.CreateRPSCheckBox<SupplierContactView>("0846cf18-3218-4d6c-bc3c-7bc5f3b54b35","","",true, this);
 
            IDContactType = RPSControlFactory.CreateRPSComboBox<SupplierContactView>("9671d754-db2a-4eae-8f9d-9fcdd5a13af8","","",false, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<SupplierContactView>("77e6a72b-9648-4a7a-8896-79319658f500","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<SupplierContactView>("3c144174-9bd1-4c4e-a2b3-ddad474d9be3","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<SupplierContactView>("c66d22d3-f4d3-4599-91e4-69a0c6713c0f","","",false, this);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<SupplierContactView>("e9267c89-f217-4c59-9d9c-3a0c50b52020","","",false, this);
 
            Email = RPSControlFactory.CreateRPSEmailTextBox<SupplierContactView>("32b48626-ec5d-4710-a159-4b6431962267","","",false, this);
 
            FirstName = RPSControlFactory.CreateRPSTextBox<SupplierContactView>("821e7834-296e-4fae-a0ba-403637e101f7","","",false, this);
 
            LastName = RPSControlFactory.CreateRPSTextBox<SupplierContactView>("e3d7deb4-6d07-4a34-a5bc-e1498f808cf0","","",false, this);
 
            Gender = RPSControlFactory.CreateRPSEnumComboBox<SupplierContactView>("f4264f34-18a9-4d31-b73a-f6458b808706","","",true, this);
 
            Title = RPSControlFactory.CreateRPSTextBox<SupplierContactView>("00dc980f-9c2a-4882-8f38-fdd25d19ef63","","",false, this);
 
            Position = RPSControlFactory.CreateRPSTextBox<SupplierContactView>("93b71091-7f43-4c89-9b16-bd851e1fc1f5","","",false, this);
 
            Mobile = RPSControlFactory.CreateRPSTextBox<SupplierContactView>("816f4045-9b1c-4b35-8d9b-e6eb1df6d101","","",false, this);
 
            DateOfBirth = RPSControlFactory.CreateRPSTextBox<SupplierContactView>("d73643d2-badf-415a-b188-eb12131c46d0","","",false, this);
 
            SkypeName = RPSControlFactory.CreateRPSTextBox<SupplierContactView>("37e6485b-b5b9-4c2c-a3d6-139bb4e0d2bc","","",false, this);
 
            Department = RPSControlFactory.CreateRPSTextBox<SupplierContactView>("c9b78e06-d884-4d16-b899-076108220176","","",false, this);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<SupplierContactView>("e4dafb82-58ac-45e9-9f25-59a09ca07112","","",false, this);
 
            Newsletter = RPSControlFactory.CreateRPSCheckBox<SupplierContactView>("b5c4c27a-ce96-4d6e-8dcd-f76afbd4f201","","",true, this);
 
            InactiveDate1 = RPSControlFactory.CreateRPSTextBox<SupplierContactView>("fa4f668e-f49d-4e84-9a1e-544b02e64b21","","",false, this);
 
            Location = RPSControlFactory.CreateRPSTextBox<SupplierContactView>("22c2b2f5-68cb-4e44-b6e9-a4af91e2f715","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<SupplierContactView>("579f754b-7c6c-46a1-be2d-00b5b60a77ea","","",false, this);
 
            GeneralData = RPSControlFactory.CreateRPSSection<SupplierContactView>( "","ul li[rpsid='d9e2d57a-d81f-4a37-b0d5-8c52af3bc190']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<SupplierContactView>( "","ul li[rpsid='d245cd65-9358-46d3-ad74-41cf92d76d5c']","",this);
 

        }
        public IRPSButton<SupplierContactView> DeleteButton { get; set; } 
        public IRPSButton<SupplierContactView,SupplierEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierContactView,SupplierEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<SupplierContactView,SupplierEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<SupplierContactView> InactiveDate { get; set; } 
        public IRPSTextBox<SupplierContactView> Description { get; set; } 
        public IRPSCheckbox<SupplierContactView> DefaultAdministration { get; set; } 
        public IRPSCheckbox<SupplierContactView> DefaultCommercial { get; set; } 
        public IRPSCheckbox<SupplierContactView> DefaultFinancial { get; set; } 
        public IRPSComboBox<SupplierContactView> IDContactType { get; set; } 
        public IRPSTextBox<SupplierContactView> Phone1 { get; set; } 
        public IRPSTextBox<SupplierContactView> Phone2 { get; set; } 
        public IRPSTextBox<SupplierContactView> Fax { get; set; } 
        public IRPSComboBox<SupplierContactView> CodUser { get; set; } 
        public IRPSTextBox<SupplierContactView> Email { get; set; } 
        public IRPSTextBox<SupplierContactView> FirstName { get; set; } 
        public IRPSTextBox<SupplierContactView> LastName { get; set; } 
        public IRPSComboBox<SupplierContactView> Gender { get; set; } 
        public IRPSTextBox<SupplierContactView> Title { get; set; } 
        public IRPSTextBox<SupplierContactView> Position { get; set; } 
        public IRPSTextBox<SupplierContactView> Mobile { get; set; } 
        public IRPSTextBox<SupplierContactView> DateOfBirth { get; set; } 
        public IRPSTextBox<SupplierContactView> SkypeName { get; set; } 
        public IRPSTextBox<SupplierContactView> Department { get; set; } 
        public IRPSComboBox<SupplierContactView> CodLanguage { get; set; } 
        public IRPSCheckbox<SupplierContactView> Newsletter { get; set; } 
        public IRPSTextBox<SupplierContactView> InactiveDate1 { get; set; } 
        public IRPSTextBox<SupplierContactView> Location { get; set; } 
        public IRPSTextBox<SupplierContactView> Comment { get; set; } 
        public IRPSSection<SupplierContactView> GeneralData { get; set; } 
        public IRPSSection<SupplierContactView> Comments { get; set; } 
        public Supplier Screen { get; set; }
        public SupplierContactView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SupplierOrderAddressView : View
    {
        public SupplierOrderAddressView(Supplier screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierOrderAddressView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierOrderAddressView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierOrderAddressView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SupplierOrderAddressView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            CodSupplierOrderAddress = RPSControlFactory.CreateRPSTextBox<SupplierOrderAddressView>("c004c044-8d67-4ce9-9078-57084d5e143f","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SupplierOrderAddressView>("fe1c698b-e1a2-4e17-b68d-7b7246560887","","",false, this);
 
            DefaultAddress = RPSControlFactory.CreateRPSCheckBox<SupplierOrderAddressView>("2051a634-5cfd-4929-b038-5a19ebb90edd","","",false, this);
 
            Ean13 = RPSControlFactory.CreateRPSTextBox<SupplierOrderAddressView>("ae5ccf1b-c096-45c3-b7a1-c6f7b15fb1ac","","",false, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<SupplierOrderAddressView>("6e7cd39f-925d-4187-8fda-821b69e065df","","",false, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<SupplierOrderAddressView>("67525f22-49c2-4034-99dd-3bf701d622a9","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<SupplierOrderAddressView>("6bb334fb-3488-451e-b72c-62560d13e511","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<SupplierOrderAddressView>("3603f98c-e208-4f19-9c24-1ce5720a1e0e","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<SupplierOrderAddressView>("e56c2a5b-45b5-4260-affe-2e0dbc6580e0","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<SupplierOrderAddressView>("dc85f499-3f21-4748-85dd-549aa8d5f75a","","",false, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<SupplierOrderAddressView>("59aa6ba1-c36a-4d14-8ff4-c5b04ac11c4e","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<SupplierOrderAddressView>("fd5c641a-6fac-408f-ac34-710e6dc507a8","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<SupplierOrderAddressView>("726a1d92-7569-4cb9-9b77-db005a5fd25b","","",false, this);
 
            Email = RPSControlFactory.CreateRPSEmailTextBox<SupplierOrderAddressView>("062aa5ae-7bf0-491a-b428-1e71d8dd2ad8","","",false, this);
 
            IDSupplierContact = RPSControlFactory.CreateRPSComboBox<SupplierOrderAddressView>("605eaccc-d23b-4763-becf-1aef06b106aa","","",false, this);
 
            ContactPerson = RPSControlFactory.CreateRPSTextBox<SupplierOrderAddressView>("660e9a3b-d2ea-45e3-becd-a56230ee8623","","",false, this);
 
            IDVATType = RPSControlFactory.CreateRPSComboBox<SupplierOrderAddressView>("f082a25d-1588-4c76-8d00-fa6708f70c64","","",false, this);
 
            IDSurchargeVATType = RPSControlFactory.CreateRPSComboBox<SupplierOrderAddressView>("686640b5-bc52-4a77-8b66-8cd0114f9b74","","",false, this);
 
            IDTaxGroup = RPSControlFactory.CreateRPSComboBox<SupplierOrderAddressView>("3f03500a-8ba5-41f1-b958-0c44710266bc","","",false, this);
 
            IDVoucherType = RPSControlFactory.CreateRPSComboBox<SupplierOrderAddressView>("bfd3d20e-48de-44dc-8ec9-756c43688082","","",false, this);
 
            IDEUInvoice = RPSControlFactory.CreateRPSComboBox<SupplierOrderAddressView>("94f76aca-c152-4fcf-82bb-ddfa9ce4cf79","","",false, this);
 
            CodTransportMethod = RPSControlFactory.CreateRPSComboBox<SupplierOrderAddressView>("037b2b1c-f7db-4720-9612-9fa23554ce56","","",false, this);
 
            CodDeliveryTerm = RPSControlFactory.CreateRPSComboBox<SupplierOrderAddressView>("1b37f15a-bc30-4273-bd38-e2bdd716f4fe","","",false, this);
 
            IDShippingAgent = RPSControlFactory.CreateRPSComboBox<SupplierOrderAddressView>("0a908807-56f7-4d41-914c-ae8c2dcbf42f","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<SupplierOrderAddressView>("860037d0-d73c-4153-a4dd-28e4d14e195b","","",false, this);
 
            GeneralData = RPSControlFactory.CreateRPSSection<SupplierOrderAddressView>( "","ul li[rpsid='8d8b31f2-e246-482a-a8a6-249ec432219e']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<SupplierOrderAddressView>( "","ul li[rpsid='dbf7eb42-8d92-4a52-9514-1b518b75dee4']","",this);
 

        }
        public IRPSButton<SupplierOrderAddressView> DeleteButton { get; set; } 
        public IRPSButton<SupplierOrderAddressView,SupplierEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierOrderAddressView,SupplierEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<SupplierOrderAddressView,SupplierEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<SupplierOrderAddressView> CodSupplierOrderAddress { get; set; } 
        public IRPSTextBox<SupplierOrderAddressView> Description { get; set; } 
        public IRPSCheckbox<SupplierOrderAddressView> DefaultAddress { get; set; } 
        public IRPSTextBox<SupplierOrderAddressView> Ean13 { get; set; } 
        public IRPSComboBox<SupplierOrderAddressView> CodCountry { get; set; } 
        public IRPSTextBox<SupplierOrderAddressView> ZipCode { get; set; } 
        public IRPSComboBox<SupplierOrderAddressView> IDState { get; set; } 
        public IRPSComboBox<SupplierOrderAddressView> IDCounty { get; set; } 
        public IRPSTextBox<SupplierOrderAddressView> Address { get; set; } 
        public IRPSTextBox<SupplierOrderAddressView> City { get; set; } 
        public IRPSTextBox<SupplierOrderAddressView> Phone1 { get; set; } 
        public IRPSTextBox<SupplierOrderAddressView> Phone2 { get; set; } 
        public IRPSTextBox<SupplierOrderAddressView> Fax { get; set; } 
        public IRPSTextBox<SupplierOrderAddressView> Email { get; set; } 
        public IRPSComboBox<SupplierOrderAddressView> IDSupplierContact { get; set; } 
        public IRPSTextBox<SupplierOrderAddressView> ContactPerson { get; set; } 
        public IRPSComboBox<SupplierOrderAddressView> IDVATType { get; set; } 
        public IRPSComboBox<SupplierOrderAddressView> IDSurchargeVATType { get; set; } 
        public IRPSComboBox<SupplierOrderAddressView> IDTaxGroup { get; set; } 
        public IRPSComboBox<SupplierOrderAddressView> IDVoucherType { get; set; } 
        public IRPSComboBox<SupplierOrderAddressView> IDEUInvoice { get; set; } 
        public IRPSComboBox<SupplierOrderAddressView> CodTransportMethod { get; set; } 
        public IRPSComboBox<SupplierOrderAddressView> CodDeliveryTerm { get; set; } 
        public IRPSComboBox<SupplierOrderAddressView> IDShippingAgent { get; set; } 
        public IRPSTextBox<SupplierOrderAddressView> Comment { get; set; } 
        public IRPSSection<SupplierOrderAddressView> GeneralData { get; set; } 
        public IRPSSection<SupplierOrderAddressView> Comments { get; set; } 
        public Supplier Screen { get; set; }
        public SupplierOrderAddressView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SupplierBankAccountView : View
    {
        public SupplierBankAccountView(Supplier screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierBankAccountView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierBankAccountView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierBankAccountView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SupplierBankAccountView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            CodSupplierBankAccount = RPSControlFactory.CreateRPSTextBox<SupplierBankAccountView>("e358a351-8833-468d-81dd-7e7eb21ceaa7","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SupplierBankAccountView>("93964ad5-f024-4ff0-9263-98762b2b4251","","",false, this);
 
            Default = RPSControlFactory.CreateRPSCheckBox<SupplierBankAccountView>("0349445f-1b65-4241-b47f-355a372db0fb","","",true, this);
 
            CodBank = RPSControlFactory.CreateRPSComboBox<SupplierBankAccountView>("2ef6cbb9-69af-423d-bc9a-9cc461c1acc2","","",false, this);
 
            CodBankBranch = RPSControlFactory.CreateRPSEnumComboBox<SupplierBankAccountView>("84bc2d27-a52c-4090-88fe-85f80d89f74d","","",false, this);
 
            DigitControl = RPSControlFactory.CreateRPSTextBox<SupplierBankAccountView>("c75fa66c-17de-4e4d-aadc-88a636df0a09","","",false, this);
 
            BankAccount = RPSControlFactory.CreateRPSTextBox<SupplierBankAccountView>("1e4499ad-fbc2-45ec-bbf5-6753b2450005","","",false, this);
 
            BankAccNumber = RPSControlFactory.CreateRPSTextBox<SupplierBankAccountView>("588c1080-10f8-4084-a414-e4826bfadd75","","",false, this);
 
            IBAN = RPSControlFactory.CreateRPSTextBox<SupplierBankAccountView>("0c12c47d-56db-4540-99f8-d0412362f7ca","","",false, this);
 
            TypeBankAcc = RPSControlFactory.CreateRPSEnumComboBox<SupplierBankAccountView>("54986d06-8bb7-43ac-a74c-5b0c7aea2845","","",true, this);
 
            SWIFTCode = RPSControlFactory.CreateRPSTextBox<SupplierBankAccountView>("b6daf790-780d-4d1c-aeed-7999a84edc8e","","",false, this);
 

        }
        public IRPSButton<SupplierBankAccountView> DeleteButton { get; set; } 
        public IRPSButton<SupplierBankAccountView,SupplierEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierBankAccountView,SupplierEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<SupplierBankAccountView,SupplierEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<SupplierBankAccountView> CodSupplierBankAccount { get; set; } 
        public IRPSTextBox<SupplierBankAccountView> Description { get; set; } 
        public IRPSCheckbox<SupplierBankAccountView> Default { get; set; } 
        public IRPSComboBox<SupplierBankAccountView> CodBank { get; set; } 
        public IRPSComboBox<SupplierBankAccountView> CodBankBranch { get; set; } 
        public IRPSTextBox<SupplierBankAccountView> DigitControl { get; set; } 
        public IRPSTextBox<SupplierBankAccountView> BankAccount { get; set; } 
        public IRPSTextBox<SupplierBankAccountView> BankAccNumber { get; set; } 
        public IRPSTextBox<SupplierBankAccountView> IBAN { get; set; } 
        public IRPSComboBox<SupplierBankAccountView> TypeBankAcc { get; set; } 
        public IRPSTextBox<SupplierBankAccountView> SWIFTCode { get; set; } 
        public Supplier Screen { get; set; }
        public SupplierBankAccountView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SupplierReportView : View
    {
        public SupplierReportView(Supplier screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierReportView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierReportView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierReportView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SupplierReportView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            FormatType = RPSControlFactory.CreateRPSEnumComboBox<SupplierReportView>("5a679a13-f8f4-4f77-978d-aa5030b25091","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SupplierReportView>("49195b56-23af-459d-b4e1-d35f42163a17","","",false, this);
 
            IDCustomReport = RPSControlFactory.CreateRPSComboBox<SupplierReportView>("23cbe9d3-14b9-448f-8cf6-f32aea8ac736","","",true, this);
 
            DefaultReport = RPSControlFactory.CreateRPSCheckBox<SupplierReportView>("b12edaab-7570-42e8-8c73-d7ff054dc1f0","","",true, this);
 

        }
        public IRPSButton<SupplierReportView> DeleteButton { get; set; } 
        public IRPSButton<SupplierReportView,SupplierEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierReportView,SupplierEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<SupplierReportView,SupplierEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<SupplierReportView> FormatType { get; set; } 
        public IRPSTextBox<SupplierReportView> Description { get; set; } 
        public IRPSComboBox<SupplierReportView> IDCustomReport { get; set; } 
        public IRPSCheckbox<SupplierReportView> DefaultReport { get; set; } 
        public Supplier Screen { get; set; }
        public SupplierReportView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SupplierDetailView : View
    {
        public SupplierDetailView(Supplier screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierDetailView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierDetailView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SupplierDetailView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            CodCompany = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("2541be42-d63f-41bf-8165-2625d36ff850","","",true, this);
 
            Blocked = RPSControlFactory.CreateRPSCheckBox<SupplierDetailView>("14225ce5-4641-44d7-a116-b259b4037d77","","",true, this);
 
            IDBusinessUnit = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("b78ed9c0-76e5-442f-a4c7-47321bad3ff9","","",false, this);
 
            PurchaseManager = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("29400b61-bcf3-4240-8c7f-11866ad94f77","","",false, this);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("6234b821-0b53-4c02-871c-f49026e320a0","","",false, this);
 
            IDPaymentMethodRappel = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("e36a6f9d-c365-4349-945e-7be4a4422a80","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("b64fb2e8-abc6-4d71-bb90-39d81d04d38f","","",true, this);
 
            Revaluation = RPSControlFactory.CreateRPSCheckBox<SupplierDetailView>("c01ad174-3c07-4393-adaa-00c1eda732a3","","",true, this);
 
            IDInvoicingType = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("9a1c6e81-843c-42f8-a028-4a23fd14893c","","",false, this);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("49ce956d-f854-4cde-9980-433e7f890790","","",true, this);
 
            IDBankAccountCompany = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("c5728e61-c5db-4817-94ae-2d48df08aa26","","",false, this);
 
            IDThirdAccType = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("8fd57f60-202a-4049-bb82-fd97c4bdad1b","","",false, this);
 
            IDVoucherType = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("53ecb66b-33b0-45d8-b291-5c6c4d505be7","","",false, this);
 
            IDEUInvoice = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("bbbea9e2-bcf4-4f70-b37d-6f269a1f6108","","",false, this);
 
            IDVATType = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("91be1115-2bf4-4034-9ce9-484f7e1fe59b","","",true, this);
 
            IDSurchargeVATType = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("a3fa9bc1-55c4-44db-b754-1f2c0107df29","","",false, this);
 
            IDTaxGroup = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("9bc010e0-d0f6-42a7-b0e9-400655e0e52c","","",false, this);
 
            IDCodingSerieRetentionVoucher = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("7200e7c8-6fce-4414-bfb4-87cc14f617b6","","",false, this);
 
            IDCodingSerieOrder = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("dcb2009a-1059-45e5-98c9-911545aa11fe","","",false, this);
 
            IDCodingSerieDeliveryNote = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("e73e7f33-896b-4348-9eb2-bbd30293f1b8","","",false, this);
 
            AutoLiquidate = RPSControlFactory.CreateRPSCheckBox<SupplierDetailView>("3c2ee5d0-1a44-4568-86d8-890c9541260d","","",true, this);
 
            IDCodingSerieInvoice = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("68bb4620-47e3-482d-b349-94fe68ea4f8d","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("79c10209-b2ef-4f9f-bbcd-710ddb47de66","","",false, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("aee4d17e-9e91-4a3d-84ce-591e38329ccf","","",false, this);
 
            DeliveryDays = RPSControlFactory.CreateRPSFormattedTextBox<SupplierDetailView>("93d03260-d575-493d-b806-1c4596ecf872","","",true, this);
 
            MinAmountOrder = RPSControlFactory.CreateRPSFormattedTextBox<SupplierDetailView>("699848a0-c7a9-4753-8e9c-486d3060dafc","","",true, this);
 
            IDShippingAgent = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("c11b13b9-2356-4030-a370-c7374fceb07b","","",false, this);
 
            IDImportOrderType = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("30d2b41c-26da-4b23-a898-d8084b93071a","","",false, this);
 
            IDTextLineSRQuotationPre = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("0bc2b789-78b1-44d5-bd74-6c5a0c94f677","","",false, this);
 
            IDTextLineFContractPre = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("c77ce170-2876-4686-8f87-257c1eff84a0","","",false, this);
 
            IDTextLineOrderPre = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("2c716207-3e19-492c-bcaa-b28367089018","","",false, this);
 
            IDTextLineSRQuotationPost = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("3907c633-0928-4155-8d2b-eb87bc8af230","","",false, this);
 
            IDTextLineFContractPost = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("f9bab2d8-f87d-4356-860d-218b9d4eff16","","",false, this);
 
            IDTextLineOrderPost = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("4cac8e90-7094-48af-8d70-10639ca12f4c","","",false, this);
 
            IDVatGL = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("2cd0a5cb-6e13-475c-bc2e-16390b138ddb","","",false, this);
 
            IDAccountGL = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("d54e2ca0-e11a-468e-9204-419429311e7a","","",false, this);
 

        }
        public IRPSButton<SupplierDetailView> DeleteButton { get; set; } 
        public IRPSButton<SupplierDetailView,SupplierEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierDetailView,SupplierEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<SupplierDetailView,SupplierEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<SupplierDetailView> CodCompany { get; set; } 
        public IRPSCheckbox<SupplierDetailView> Blocked { get; set; } 
        public IRPSComboBox<SupplierDetailView> IDBusinessUnit { get; set; } 
        public IRPSComboBox<SupplierDetailView> PurchaseManager { get; set; } 
        public IRPSComboBox<SupplierDetailView> IDPaymentMethod { get; set; } 
        public IRPSComboBox<SupplierDetailView> IDPaymentMethodRappel { get; set; } 
        public IRPSComboBox<SupplierDetailView> IDCurrency { get; set; } 
        public IRPSCheckbox<SupplierDetailView> Revaluation { get; set; } 
        public IRPSComboBox<SupplierDetailView> IDInvoicingType { get; set; } 
        public IRPSComboBox<SupplierDetailView> IDDeliveryNoteType { get; set; } 
        public IRPSComboBox<SupplierDetailView> IDBankAccountCompany { get; set; } 
        public IRPSComboBox<SupplierDetailView> IDThirdAccType { get; set; } 
        public IRPSComboBox<SupplierDetailView> IDVoucherType { get; set; } 
        public IRPSComboBox<SupplierDetailView> IDEUInvoice { get; set; } 
        public IRPSComboBox<SupplierDetailView> IDVATType { get; set; } 
        public IRPSComboBox<SupplierDetailView> IDSurchargeVATType { get; set; } 
        public IRPSComboBox<SupplierDetailView> IDTaxGroup { get; set; } 
        public IRPSComboBox<SupplierDetailView> IDCodingSerieRetentionVoucher { get; set; } 
        public IRPSComboBox<SupplierDetailView> IDCodingSerieOrder { get; set; } 
        public IRPSComboBox<SupplierDetailView> IDCodingSerieDeliveryNote { get; set; } 
        public IRPSCheckbox<SupplierDetailView> AutoLiquidate { get; set; } 
        public IRPSComboBox<SupplierDetailView> IDCodingSerieInvoice { get; set; } 
        public IRPSComboBox<SupplierDetailView> IDSite { get; set; } 
        public IRPSComboBox<SupplierDetailView> IDWarehouse { get; set; } 
        public IRPSTextBox<SupplierDetailView> DeliveryDays { get; set; } 
        public IRPSTextBox<SupplierDetailView> MinAmountOrder { get; set; } 
        public IRPSComboBox<SupplierDetailView> IDShippingAgent { get; set; } 
        public IRPSComboBox<SupplierDetailView> IDImportOrderType { get; set; } 
        public IRPSComboBox<SupplierDetailView> IDTextLineSRQuotationPre { get; set; } 
        public IRPSComboBox<SupplierDetailView> IDTextLineFContractPre { get; set; } 
        public IRPSComboBox<SupplierDetailView> IDTextLineOrderPre { get; set; } 
        public IRPSComboBox<SupplierDetailView> IDTextLineSRQuotationPost { get; set; } 
        public IRPSComboBox<SupplierDetailView> IDTextLineFContractPost { get; set; } 
        public IRPSComboBox<SupplierDetailView> IDTextLineOrderPost { get; set; } 
        public IRPSComboBox<SupplierDetailView> IDVatGL { get; set; } 
        public IRPSComboBox<SupplierDetailView> IDAccountGL { get; set; } 
        public Supplier Screen { get; set; }
        public SupplierDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SupplierAuditView : View
    {
        public SupplierAuditView(Supplier screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierAuditView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierAuditView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierAuditView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SupplierAuditView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            Type = RPSControlFactory.CreateRPSTextBox<SupplierAuditView>("1bedd3a4-69e7-4d06-ab75-65de801418a3","","",false, this);
 
            CodAudit = RPSControlFactory.CreateRPSTextBox<SupplierAuditView>("6218cdf5-7487-4651-b130-10f3f9408877","","",true, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<SupplierAuditView>("af23f4e8-3713-4eaa-8289-3e3956c3b965","","",false, this);
 
            Report = RPSControlFactory.CreateRPSTextBox<SupplierAuditView>("ef2b3e2d-bd97-4421-bca9-399f6c501c4d","","",false, this);
 
            Valoration = RPSControlFactory.CreateRPSTextBox<SupplierAuditView>("270c8a86-3387-4808-becf-8857e7d93701","","",false, this);
 
            Punctuation = RPSControlFactory.CreateRPSTextBox<SupplierAuditView>("b7543b22-8acf-4901-b816-34a836239c49","","",false, this);
 
            Observation = RPSControlFactory.CreateRPSTextBox<SupplierAuditView>("3e644699-3dab-4855-bb93-2c645251b63d","","",false, this);
 

        }
        public IRPSButton<SupplierAuditView> DeleteButton { get; set; } 
        public IRPSButton<SupplierAuditView,SupplierEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierAuditView,SupplierEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<SupplierAuditView,SupplierEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<SupplierAuditView> Type { get; set; } 
        public IRPSTextBox<SupplierAuditView> CodAudit { get; set; } 
        public IRPSTextBox<SupplierAuditView> Date { get; set; } 
        public IRPSTextBox<SupplierAuditView> Report { get; set; } 
        public IRPSTextBox<SupplierAuditView> Valoration { get; set; } 
        public IRPSTextBox<SupplierAuditView> Punctuation { get; set; } 
        public IRPSTextBox<SupplierAuditView> Observation { get; set; } 
        public Supplier Screen { get; set; }
        public SupplierAuditView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SupplierCertificateView : View
    {
        public SupplierCertificateView(Supplier screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierCertificateView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierCertificateView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierCertificateView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SupplierCertificateView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            CodCertificate = RPSControlFactory.CreateRPSTextBox<SupplierCertificateView>("6913b26a-976a-4fa8-b72c-e017fd98eb1e","","",true, this);
 
            Certificate = RPSControlFactory.CreateRPSTextBox<SupplierCertificateView>("55f55dc9-5764-44d1-bc49-d6ffe222681c","","",false, this);
 
            DeliveredBy = RPSControlFactory.CreateRPSTextBox<SupplierCertificateView>("38a886e9-c61e-4e98-accb-a111d3683a89","","",false, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<SupplierCertificateView>("6f19a379-e5c1-453b-9b3d-aafa96a10c80","","",false, this);
 
            ExpiryDate = RPSControlFactory.CreateRPSTextBox<SupplierCertificateView>("44e188cf-7236-448e-a4be-fc2a26b48f55","","",false, this);
 
            Note = RPSControlFactory.CreateRPSTextBox<SupplierCertificateView>("587cf129-0cb2-47e0-9c56-0a6e027841fd","","",false, this);
 

        }
        public IRPSButton<SupplierCertificateView> DeleteButton { get; set; } 
        public IRPSButton<SupplierCertificateView,SupplierEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierCertificateView,SupplierEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<SupplierCertificateView,SupplierEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<SupplierCertificateView> CodCertificate { get; set; } 
        public IRPSTextBox<SupplierCertificateView> Certificate { get; set; } 
        public IRPSTextBox<SupplierCertificateView> DeliveredBy { get; set; } 
        public IRPSTextBox<SupplierCertificateView> Date { get; set; } 
        public IRPSTextBox<SupplierCertificateView> ExpiryDate { get; set; } 
        public IRPSTextBox<SupplierCertificateView> Note { get; set; } 
        public Supplier Screen { get; set; }
        public SupplierCertificateView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SupplierAccreditationView : View
    {
        public SupplierAccreditationView(Supplier screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierAccreditationView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierAccreditationView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierAccreditationView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SupplierAccreditationView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            IDAccreditation = RPSControlFactory.CreateRPSComboBox<SupplierAccreditationView>("2dbbf40a-a111-4b81-9791-58109e5687ee","","",true, this);
 

        }
        public IRPSButton<SupplierAccreditationView> DeleteButton { get; set; } 
        public IRPSButton<SupplierAccreditationView,SupplierEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierAccreditationView,SupplierEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<SupplierAccreditationView,SupplierEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<SupplierAccreditationView> IDAccreditation { get; set; } 
        public Supplier Screen { get; set; }
        public SupplierAccreditationView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NewSupplierFromCopyChildDialogView : View
    {
        public NewSupplierFromCopyChildDialogView(Supplier screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewCode = RPSControlFactory.CreateRPSTextBox<NewSupplierFromCopyChildDialogView>("71809c2a-e6b6-40ea-b33a-8747eb056e51","","",false, this);
 
            UINewSupplierVATNumber = RPSControlFactory.CreateRPSTextBox<NewSupplierFromCopyChildDialogView>("17a3cfe2-e08f-4c1c-afde-d422e49c4363","","",false, this);
 
            UINewSupplierDescription = RPSControlFactory.CreateRPSTextBox<NewSupplierFromCopyChildDialogView>("1134b7ab-08b8-40a5-b7b4-be4d9e58d4fe","","",false, this);
 
            UINewSupplierBusinessName = RPSControlFactory.CreateRPSTextBox<NewSupplierFromCopyChildDialogView>("a8bac07d-7182-4767-8cd7-ad613b487bdb","","",false, this);
 
            bContacts = RPSControlFactory.CreateRPSCheckBox<NewSupplierFromCopyChildDialogView>("69d774e2-bc71-4314-b84e-d33ba5c4bdff","","",false, this);
 
            bOrderAddress = RPSControlFactory.CreateRPSCheckBox<NewSupplierFromCopyChildDialogView>("b3c6d952-4185-438d-920c-2b56646c0332","","",false, this);
 
            bBankAccounts = RPSControlFactory.CreateRPSCheckBox<NewSupplierFromCopyChildDialogView>("43e2d6a2-f072-4d26-8f22-b906d1f7f5b4","","",false, this);
 
            bAccreditations = RPSControlFactory.CreateRPSCheckBox<NewSupplierFromCopyChildDialogView>("7981b2c6-51e3-4e92-be8e-1281e19c0a00","","",false, this);
 
            bReports = RPSControlFactory.CreateRPSCheckBox<NewSupplierFromCopyChildDialogView>("244de180-94b9-4fe7-8abe-cd18df17bbea","","",false, this);
 
            bCertificates = RPSControlFactory.CreateRPSCheckBox<NewSupplierFromCopyChildDialogView>("0ee86269-8ff9-41e4-a46e-897c7db3a742","","",false, this);
 
            bAudits = RPSControlFactory.CreateRPSCheckBox<NewSupplierFromCopyChildDialogView>("984902b2-4c0f-4859-8730-82ed05ae7d2d","","",false, this);
 

        }
        public IRPSTextBox<NewSupplierFromCopyChildDialogView> NewCode { get; set; } 
        public IRPSTextBox<NewSupplierFromCopyChildDialogView> UINewSupplierVATNumber { get; set; } 
        public IRPSTextBox<NewSupplierFromCopyChildDialogView> UINewSupplierDescription { get; set; } 
        public IRPSTextBox<NewSupplierFromCopyChildDialogView> UINewSupplierBusinessName { get; set; } 
        public IRPSCheckbox<NewSupplierFromCopyChildDialogView> bContacts { get; set; } 
        public IRPSCheckbox<NewSupplierFromCopyChildDialogView> bOrderAddress { get; set; } 
        public IRPSCheckbox<NewSupplierFromCopyChildDialogView> bBankAccounts { get; set; } 
        public IRPSCheckbox<NewSupplierFromCopyChildDialogView> bAccreditations { get; set; } 
        public IRPSCheckbox<NewSupplierFromCopyChildDialogView> bReports { get; set; } 
        public IRPSCheckbox<NewSupplierFromCopyChildDialogView> bCertificates { get; set; } 
        public IRPSCheckbox<NewSupplierFromCopyChildDialogView> bAudits { get; set; } 
        public Supplier Screen { get; set; }
        public NewSupplierFromCopyChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SupplierEmployeeView : View
    {
        public SupplierEmployeeView(Supplier screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierEmployeeView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierEmployeeView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierEmployeeView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SupplierEmployeeView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<SupplierEmployeeView>("11d56137-d9fb-4769-9468-e211333962aa","","",true, this);
 

        }
        public IRPSButton<SupplierEmployeeView> DeleteButton { get; set; } 
        public IRPSButton<SupplierEmployeeView,SupplierEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierEmployeeView,SupplierEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<SupplierEmployeeView,SupplierEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<SupplierEmployeeView> IDEmployee { get; set; } 
        public Supplier Screen { get; set; }
        public SupplierEmployeeView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SupplierPaymentView : View
    {
        public SupplierPaymentView(Supplier screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierPaymentView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierPaymentView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierPaymentView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SupplierPaymentView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            IDSupplierPayer = RPSControlFactory.CreateRPSComboBox<SupplierPaymentView>("50fb0d9b-2d04-4577-bb49-709ea410a53b","","",true, this);
 
            CodSupplierPayment = RPSControlFactory.CreateRPSTextBox<SupplierPaymentView>("5aa9efc6-04f0-4ab8-ab26-a4999b5a9d90","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SupplierPaymentView>("69916589-85d3-4de8-80a8-514829614cf4","","",false, this);
 
            Default = RPSControlFactory.CreateRPSCheckBox<SupplierPaymentView>("6b4a2e91-eab2-4893-9b43-59ab26c8dd59","","",true, this);
 
            UseDataSupplierPayer = RPSControlFactory.CreateRPSCheckBox<SupplierPaymentView>("6d62700b-e8b0-436e-ab18-9aff8b64b5ec","","",true, this);
 
            IDSupplierContact = RPSControlFactory.CreateRPSComboBox<SupplierPaymentView>("2ad03e83-e8eb-47b9-9793-80ccfd716745","","",false, this);
 
            ContactPerson = RPSControlFactory.CreateRPSTextBox<SupplierPaymentView>("96e25022-f0ca-4347-8d68-1d7cf698d9f1","","",false, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<SupplierPaymentView>("99f1dedf-cb81-4267-9387-0af9011ab66f","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<SupplierPaymentView>("99bbf70e-8869-449f-8cc2-7399f1494913","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<SupplierPaymentView>("c6651f73-c29c-40fd-91b0-65f87933327d","","",false, this);
 
            Email = RPSControlFactory.CreateRPSEmailTextBox<SupplierPaymentView>("1cdb7b4d-cd5d-478d-8d18-9c80e50a5747","","",false, this);
 

        }
        public IRPSButton<SupplierPaymentView> DeleteButton { get; set; } 
        public IRPSButton<SupplierPaymentView,SupplierEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierPaymentView,SupplierEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<SupplierPaymentView,SupplierEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<SupplierPaymentView> IDSupplierPayer { get; set; } 
        public IRPSTextBox<SupplierPaymentView> CodSupplierPayment { get; set; } 
        public IRPSTextBox<SupplierPaymentView> Description { get; set; } 
        public IRPSCheckbox<SupplierPaymentView> Default { get; set; } 
        public IRPSCheckbox<SupplierPaymentView> UseDataSupplierPayer { get; set; } 
        public IRPSComboBox<SupplierPaymentView> IDSupplierContact { get; set; } 
        public IRPSTextBox<SupplierPaymentView> ContactPerson { get; set; } 
        public IRPSTextBox<SupplierPaymentView> Phone1 { get; set; } 
        public IRPSTextBox<SupplierPaymentView> Phone2 { get; set; } 
        public IRPSTextBox<SupplierPaymentView> Fax { get; set; } 
        public IRPSTextBox<SupplierPaymentView> Email { get; set; } 
        public Supplier Screen { get; set; }
        public SupplierPaymentView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}