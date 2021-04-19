    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.Customer
{
    //RPS VERSION 1.0.0.0
    public partial class Customer:Screen
    {
        public Customer():base()
        {
            this.URL = "sales.customer";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CustomerQueryView  = new CustomerQueryView(this); 
            CustomerEntityView  = new CustomerEntityView(this); 
            CustomerDeliveryAddressView  = new CustomerDeliveryAddressView(this); 
            CustomerContactView  = new CustomerContactView(this); 
            CustomerPaymentAddressView  = new CustomerPaymentAddressView(this); 
            CustomerBankAccountView  = new CustomerBankAccountView(this); 
            CustomerReportView  = new CustomerReportView(this); 
            CustomerDetailView  = new CustomerDetailView(this); 
            CustomerCommercialAgentView  = new CustomerCommercialAgentView(this); 
            NewCustomerFromCopyChildDialogView  = new NewCustomerFromCopyChildDialogView(this); 
            CustomerQueryView.InitializeControls(); 
            CustomerEntityView.InitializeControls(); 
            CustomerDeliveryAddressView.InitializeControls(); 
            CustomerContactView.InitializeControls(); 
            CustomerPaymentAddressView.InitializeControls(); 
            CustomerBankAccountView.InitializeControls(); 
            CustomerReportView.InitializeControls(); 
            CustomerDetailView.InitializeControls(); 
            CustomerCommercialAgentView.InitializeControls(); 
            NewCustomerFromCopyChildDialogView.InitializeControls(); 
           
        }
      
            public CustomerQueryView CustomerQueryView {get; set; } 
            public CustomerEntityView CustomerEntityView {get; set; } 
            public CustomerDeliveryAddressView CustomerDeliveryAddressView {get; set; } 
            public CustomerContactView CustomerContactView {get; set; } 
            public CustomerPaymentAddressView CustomerPaymentAddressView {get; set; } 
            public CustomerBankAccountView CustomerBankAccountView {get; set; } 
            public CustomerReportView CustomerReportView {get; set; } 
            public CustomerDetailView CustomerDetailView {get; set; } 
            public CustomerCommercialAgentView CustomerCommercialAgentView {get; set; } 
            public NewCustomerFromCopyChildDialogView NewCustomerFromCopyChildDialogView {get; set; } 
    }
            
    public partial class CustomerQueryView : View
    {
        public CustomerQueryView(Customer screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CustomerQueryView,CustomerEntityView>( this,Screen.CustomerEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "1a640fdd-9678-4da2-9687-162e1682ecb7",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CustomerQueryView,CustomerEntityView>( params_MainConsult,this,Screen.CustomerEntityView);
 

        }
        public IRPSButton<CustomerQueryView,CustomerEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CustomerQueryView,CustomerEntityView> MainConsult { get; set; } 
        public Customer Screen { get; set; }
        public CustomerQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CustomerEntityView : View
    {
        public CustomerEntityView(Customer screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CustomerEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CustomerEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CustomerEntityView,CustomerQueryView>( this,Screen.CustomerQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<CustomerEntityView,CustomerQueryView>( this,Screen.CustomerQueryView);
 
            CodCustomer = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("4e907e93-379f-420b-a623-9892efe915d6","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("c256e04d-0b30-4ca5-a13a-171e5171d2b9","","",false, this);
 
            CompanyName = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("7bd11032-40fb-4bf3-a76e-fbe0a18dbf05","","",false, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("31a7f4d6-a2ba-4345-a876-0f2330282a82","","",false, this);
 
            ThirdType = RPSControlFactory.CreateRPSEnumComboBox<CustomerEntityView>("eaaf6f36-f655-4c9b-9e82-2de6a9698706","","",true, this);
 
            InactiveDate = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("88ef62d7-f15a-400e-958a-cd579d7cde17","","",false, this);
 
            IDCustomerClassification = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("dbdde71e-8e07-4878-9db6-7eb4ad0ebf77","","",false, this);
 
            IDBusinessUnit = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("ac675c90-dd53-4063-b52d-f291d6035aea","","",false, this);
 
            IDSector = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("7bfec271-f40f-492b-9305-682a63561b19","","",false, this);
 
            IDZone = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("7847d442-ebf6-4bc9-a05d-deff0a368cd7","","",false, this);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("e0a8bb84-b5a1-447b-955d-3cb3f706fb7e","","",false, this);
 
            Ean13 = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("58d0df36-9559-4328-b370-d71457b0fff6","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("aab1590e-9d05-4303-9429-8ce3e0917e9b","","",false, this);
 
            CustomerSupplierINFO = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("3240ad1f-be49-482f-ba7b-76bf1682215f","","",false, this);
 
            Miscellaneous = RPSControlFactory.CreateRPSCheckBox<CustomerEntityView>("6875e59c-df6a-4d4d-92c2-f6f0bdcd329b","","",true, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("2bfb6856-5ae9-4f9d-b57d-245eab7b9dab","","",false, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("436f86cb-6c8d-47a5-8256-77bf29edc0be","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("1f8a4eb5-084e-4905-8602-5e0758dd7446","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("1cd63fa3-9015-495a-9e76-f36ca5ce0d30","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("ab540460-40dc-49f6-9b05-be706f4db16f","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("8729b826-44fb-4fe9-bc1b-6c22b35ea36d","","",false, this);
 
            Position = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("c283b092-4421-47af-adeb-626e08405c23","","",false, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("23bdb659-549e-4c91-a2ff-20fa36694bdf","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("8cc4c119-9203-4f7b-b5c4-684743e5f35b","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("140a721f-19fe-4534-aa0e-54d810090643","","",false, this);
 
            Email = RPSControlFactory.CreateRPSEmailTextBox<CustomerEntityView>("8098ec7c-f098-4acb-abf6-888a747aaa8b","","",false, this);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("f9130c26-1f35-4d73-89bd-e855605f81f6","","",false, this);
 
            RiskLimit = RPSControlFactory.CreateRPSFormattedTextBox<CustomerEntityView>("4e95c0c3-9981-44e3-a886-1d210951d244","","",true, this);
 
            RiskType = RPSControlFactory.CreateRPSEnumComboBox<CustomerEntityView>("3d19c229-393f-4098-b4e8-a071bd9e888c","","",true, this);
 
            OrderRisk = RPSControlFactory.CreateRPSFormattedTextBox<CustomerEntityView>("c7066022-ded4-40ff-a896-ac5118389dd2","","",true, this);
 
            UnPaidRisk = RPSControlFactory.CreateRPSFormattedTextBox<CustomerEntityView>("5da46116-241e-4db5-829e-0baaf92ac2d6","","",true, this);
 
            ReceivableRisk = RPSControlFactory.CreateRPSFormattedTextBox<CustomerEntityView>("c4203a5a-e4a6-4c7d-9f56-3c677536ab4c","","",true, this);
 
            IDCustomerGroup1 = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("48790b03-2cc8-4364-a4bc-c0a7a99a0542","","",false, this);
 
            IDCustomerGroup1Value = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("114777b9-6793-4b10-9c53-21b2add88649","","",false, this);
 
            IDCustomerGroup2 = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("3770c71f-3863-41e8-9ad7-86f26f5c282c","","",false, this);
 
            IDCustomerGroup2Value = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("29ed7bdc-3b13-46dd-942e-9cf987a85fd1","","",false, this);
 
            IDCustomerGroup3 = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("e777ddbe-024e-4968-ab45-b4ed106699ef","","",false, this);
 
            IDCustomerGroup3Value = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("f2024a37-5e01-4b6c-9808-8e8bf5a00657","","",false, this);
 
            IDCustomerGroup4 = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("5d717d31-4fec-4f84-a949-de853820c59f","","",false, this);
 
            IDCustomerGroup4Value = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("9b273c08-f2b2-4bda-974e-ba490c2efee7","","",false, this);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("d295a704-5bb9-4159-bc7e-13da2c5b842a","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("79c0bfa0-a12f-4b79-ae14-c2cd38eb77ac","","",true, this);
 
            Revaluation = RPSControlFactory.CreateRPSCheckBox<CustomerEntityView>("2270597f-3dfa-4ea8-9c6c-2d93d3633dcc","","",true, this);
 
            DiscountCreditInvoice = RPSControlFactory.CreateRPSCheckBox<CustomerEntityView>("6558c0f0-21d4-4f6e-930e-22ea59754b71","","",true, this);
 
            IDInvoicingType = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("3d35dd60-6bb6-487f-a27b-23b4c46e729e","","",false, this);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("78f5100e-b9f4-49e3-8eac-25928d36bd57","","",false, this);
 
            IDDeliveryNoteTypeGroup = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("af418293-ab38-46ef-b244-fecd58af4f8a","","",false, this);
 
            IDInvoiceTypeGroup = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("757d911a-b3f1-4fde-8147-59105a78e80a","","",false, this);
 
            TypeDigitalInvoice = RPSControlFactory.CreateRPSEnumComboBox<CustomerEntityView>("d0e31b20-f476-433c-8f05-2ce549654b57","","",true, this);
 
            IDBankAccountCompany = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("b905a7de-557b-4b3e-ab90-628b666d33bd","","",false, this);
 
            IDCashCollector = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("bc66c03f-cf74-4a87-969b-4d0699265c75","","",false, this);
 
            IDThirdAccType = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("5244875d-ba55-4581-9458-2c1ec189e1b2","","",false, this);
 
            IDVoucherType = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("5e59df26-1a14-4a49-8cce-6fd328088f81","","",false, this);
 
            IDVATType = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("9b216aa1-b59e-4f9e-9485-7cf0bdb8a894","","",true, this);
 
            IDSurchargeVATType = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("c12ed070-4d88-4172-bbeb-69a4110bd765","","",false, this);
 
            IDTaxGroup = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("dac5ef71-b0e8-455b-a2d1-d67c16b3f06c","","",false, this);
 
            IDPaymentMethodRappel = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("7ddd983c-ad7f-48d8-a878-eb53002e170a","","",false, this);
 
            IDPriceList = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("c4fc055b-b50e-4e44-8b9b-14b7868b3b4a","","",false, this);
 
            IDDiscountGroup = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("5e779f09-2b63-44b5-a4c7-64f7305a4d1f","","",false, this);
 
            IDCustomerCommissionGroup = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("6e543c7c-c4cd-4001-b413-753f031bf5e2","","",false, this);
 
            RetentionPercent = RPSControlFactory.CreateRPSFormattedTextBox<CustomerEntityView>("2819e408-7789-4ab9-9684-97930805dead","","",true, this);
 
            RetentionType = RPSControlFactory.CreateRPSEnumComboBox<CustomerEntityView>("7f1bbc6a-5902-41e4-b518-a47d41517dfb","","",true, this);
 
            DiscountCondition = RPSControlFactory.CreateRPSEnumComboBox<CustomerEntityView>("b1a3d1a2-b407-4090-b4c0-a3a35c48a1b8","","",true, this);
 
            Discount1 = RPSControlFactory.CreateRPSFormattedTextBox<CustomerEntityView>("c97e328e-4e32-4db1-98ac-61948f41ce45","","",true, this);
 
            Discount2 = RPSControlFactory.CreateRPSFormattedTextBox<CustomerEntityView>("a154d8f1-3b4d-4f48-9ae9-e8df287ecb2f","","",true, this);
 
            Discount3 = RPSControlFactory.CreateRPSFormattedTextBox<CustomerEntityView>("600b3d65-164e-4c24-b002-d1e6b44b64e0","","",true, this);
 
            CashDiscount = RPSControlFactory.CreateRPSFormattedTextBox<CustomerEntityView>("eaa64ece-0499-4cad-92f6-b043d21b211b","","",true, this);
 
            FinancialSurcharge = RPSControlFactory.CreateRPSFormattedTextBox<CustomerEntityView>("a8c129cd-f7f0-46dc-9336-5612c7c9c55d","","",true, this);
 
            IDCommercialConditionGroup = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("9dfa04c5-9184-462c-88f2-35717cf06a56","","",false, this);
 
            ConditionsAffectDocument = RPSControlFactory.CreateRPSCheckBox<CustomerEntityView>("c4f7d69b-96eb-4a16-868e-547dd8a8486b","","",true, this);
 
            ConditionsNotAffectDocument = RPSControlFactory.CreateRPSCheckBox<CustomerEntityView>("086c1987-40be-474c-8053-9d8ebb365ec1","","",true, this);
 
            IDCodingSerieSalesQuote = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("2b961b77-77df-47c2-95e1-e94a980d84af","","",false, this);
 
            IDCodingSerieOrder = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("25a72178-b5a1-4df5-a840-4769e67eb475","","",false, this);
 
            IDCodingSerieFrameworkContract = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("3ad350f0-7b0f-463c-b3b4-0079c5189438","","",false, this);
 
            IDCodingSerieDeliveryNote = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("c6044cb3-4ed3-4c55-8ef4-cfb03934a79a","","",false, this);
 
            IDCodingSerieInvoice = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("f70657c0-6bae-4ef8-8c9a-572da1e42013","","",false, this);
 
            IDCodingSerieCreditInvoice = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("ce4f5b5e-7a4b-4979-85a4-e47a6e7db2f7","","",false, this);
 
            IDCodingSerieDebitNote = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("f8305111-10b8-4861-b40c-783b23e3678c","","",false, this);
 
            IDCodingSerieDeliveryNoteB = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("2d8b1908-fbca-4f30-b905-2524e4068907","","",false, this);
 
            IDCodingSerieInvoiceB = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("25a09ab2-6b80-419e-a0d0-9a891e25987a","","",false, this);
 
            IDCodingSerieCreditInvoiceB = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("b0d7f17d-8ef3-4920-98b8-e8674ebe92ee","","",false, this);
 
            IDCodingSerieDebitNoteB = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("1a2836f5-e5a7-4f4a-b7de-496bd1698091","","",false, this);
 
            IDCodingSerieAdvanceInvoice = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("0c4d6511-2902-4beb-ade3-41ed285f5832","","",false, this);
 
            IDCodingSerieAdvanceInvoiceB = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("2f96f771-4076-4f90-9db5-a30ad4651648","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("21203b82-9417-4640-b801-a8c328338819","","",false, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("6fbdb381-8128-408a-975c-3f3e4b77d304","","",false, this);
 
            DeliveryDays = RPSControlFactory.CreateRPSFormattedTextBox<CustomerEntityView>("1097a84c-38f8-4c29-bb5f-4c0fa53d593f","","",true, this);
 
            OrderPriority = RPSControlFactory.CreateRPSFormattedTextBox<CustomerEntityView>("ce999840-c8a4-4484-9921-0aa15b9bd2f3","","",true, this);
 
            IDShippingAgent = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("3a8c064a-dee7-4cd4-9cd2-e8eab1dde27f","","",false, this);
 
            CodTransportMethod = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("d3b73941-b40e-49a3-b48a-5b1fd36ff1a2","","",false, this);
 
            CodDeliveryTerm = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("2a40b52d-7f57-4b08-9ffd-99a36b3a5c84","","",false, this);
 
            ReprintOrder = RPSControlFactory.CreateRPSFormattedTextBox<CustomerEntityView>("0abd6931-401f-4925-b389-98915f7b9bf9","","",true, this);
 
            DeliveryNoteCopies = RPSControlFactory.CreateRPSFormattedTextBox<CustomerEntityView>("bb26e636-526d-49fe-b4c7-598d6fff60b9","","",true, this);
 
            InvoiceCopies = RPSControlFactory.CreateRPSFormattedTextBox<CustomerEntityView>("101adda9-d602-49a6-b36e-4aa97974657c","","",true, this);
 
            DeliveryNoteValued = RPSControlFactory.CreateRPSCheckBox<CustomerEntityView>("b293dac3-075b-4b0c-9c94-c4109751a5a6","","",true, this);
 
            NewOrderRest = RPSControlFactory.CreateRPSCheckBox<CustomerEntityView>("960b8a16-0c7b-411f-89c3-995feb786cbe","","",true, this);
 
            SalesQuoteEffectiveDays = RPSControlFactory.CreateRPSFormattedTextBox<CustomerEntityView>("140488fd-643b-4199-9654-76288c219c35","","",true, this);
 
            Blocked = RPSControlFactory.CreateRPSCheckBox<CustomerEntityView>("4b3ebd59-97ae-440d-b9f2-8736300fb2d8","","",true, this);
 
            BlockedCRM = RPSControlFactory.CreateRPSCheckBox<CustomerEntityView>("dd7d856b-e02b-450b-920e-f7e28b54aacd","","",true, this);
 
            BlockedMaintenance = RPSControlFactory.CreateRPSCheckBox<CustomerEntityView>("0af8fde2-8dcc-418c-bfb7-c1b8309e1574","","",true, this);
 
            DayFixedPayment = RPSControlFactory.CreateRPSEnumComboBox<CustomerEntityView>("eeccb861-3e0d-4639-9b25-82954cab229d","","",true, this);
 
            FirstDayPayment = RPSControlFactory.CreateRPSEnumComboBox<CustomerEntityView>("7bf31ed3-4efb-46f6-ab27-7d9e96ec9553","","",true, this);
 
            SecondDayPayment = RPSControlFactory.CreateRPSEnumComboBox<CustomerEntityView>("6acd6c69-b998-46ce-90a5-7cf7800a0c70","","",true, this);
 
            ThirdDayPayment = RPSControlFactory.CreateRPSEnumComboBox<CustomerEntityView>("d2ea6b3a-4616-432b-a9fa-9a2d93267da9","","",true, this);
 
            PeriodNotPaymet = RPSControlFactory.CreateRPSEnumComboBox<CustomerEntityView>("61dea386-de6c-46ef-8206-30729d8e8d82","","",true, this);
 
            KeyNotPayment = RPSControlFactory.CreateRPSEnumComboBox<CustomerEntityView>("57754ba7-ec41-4b19-b4f7-90e60ea40c81","","",true, this);
 
            FixedDayPayment = RPSControlFactory.CreateRPSEnumComboBox<CustomerEntityView>("e7435424-b9fc-4952-838a-682d27486950","","",true, this);
 
            FixedMonthPayment = RPSControlFactory.CreateRPSEnumComboBox<CustomerEntityView>("521d2106-6541-4217-b993-5e5a8ebb16d0","","",true, this);
 
            AdvancePercentage = RPSControlFactory.CreateRPSFormattedTextBox<CustomerEntityView>("31634ad7-d7dc-4ea3-8c32-33e5f596a4f5","","",true, this);
 
            DayNotPaymentFrom1 = RPSControlFactory.CreateRPSEnumComboBox<CustomerEntityView>("4d9da042-9f34-4552-bb07-9828a5cc46be","","",true, this);
 
            MonthNotPaymentFrom1 = RPSControlFactory.CreateRPSEnumComboBox<CustomerEntityView>("55349231-dbc7-48a0-95f6-3cf271ab0067","","",true, this);
 
            DayNotPaymentTo1 = RPSControlFactory.CreateRPSEnumComboBox<CustomerEntityView>("f603276e-db6f-4257-8a75-7696811a33a2","","",true, this);
 
            MonthNotPaymentTo1 = RPSControlFactory.CreateRPSEnumComboBox<CustomerEntityView>("7aa0a90b-6d47-4c95-b810-30d4ba835283","","",true, this);
 
            DayNotPaymentFrom2 = RPSControlFactory.CreateRPSEnumComboBox<CustomerEntityView>("9a2224ce-b48b-44a9-8014-ca2541a1427a","","",true, this);
 
            MonthNotPaymentFrom2 = RPSControlFactory.CreateRPSEnumComboBox<CustomerEntityView>("d95003c1-aaca-4158-9157-f2edcbcc7a9b","","",true, this);
 
            DayNotPaymentTo2 = RPSControlFactory.CreateRPSEnumComboBox<CustomerEntityView>("b322377c-faab-4a9d-a353-f6942011f365","","",true, this);
 
            MonthNotPaymentTo2 = RPSControlFactory.CreateRPSEnumComboBox<CustomerEntityView>("96525fae-3d00-499c-98d6-279533de777d","","",true, this);
 
            DayNotPaymentFrom3 = RPSControlFactory.CreateRPSEnumComboBox<CustomerEntityView>("67099c48-c721-4bc3-9b96-b955006da545","","",true, this);
 
            MonthNotPaymentFrom3 = RPSControlFactory.CreateRPSEnumComboBox<CustomerEntityView>("6fc11495-8fbe-4da6-91de-2fa49be97b03","","",true, this);
 
            DayNotPaymentTo3 = RPSControlFactory.CreateRPSEnumComboBox<CustomerEntityView>("089d60cb-3da2-4107-af0c-0eeffe289ae1","","",true, this);
 
            MonthNotPaymentTo3 = RPSControlFactory.CreateRPSEnumComboBox<CustomerEntityView>("b69aedbd-8e06-4459-99e2-6c19e696add9","","",true, this);
 
            RpnMax = RPSControlFactory.CreateRPSFormattedTextBox<CustomerEntityView>("6e70a834-ba4e-4802-98ad-533987ba46bc","","",true, this);
 
            CommentCustomer = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("3f3b6ab5-1fcf-4c0c-a0a2-fd10c359fce5","","",false, this);
 
            CommentOrder = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("21a4f558-37fe-48bb-adc3-c642a65a0551","","",false, this);
 
            CommentDeliveryNote = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("831a11fe-bacd-4460-99e7-ce376441b39f","","",false, this);
 
            CommentInvoice = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("206c50f5-9f64-4f66-ab8e-8fdae5aa6bfd","","",false, this);
 
            IDTextLineOfferPre = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("8b392c9c-3eeb-4ddd-a536-134d94062079","","",false, this);
 
            IDTextLineFContractPre = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("c852ec1c-5250-441c-8ee9-be48be9fe22f","","",false, this);
 
            IDTextLineOrderPre = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("ee3d5de5-7d6f-49ce-a159-b4bcd96dc76a","","",false, this);
 
            IDTextLineDNotePre = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("acd0ad27-86aa-4356-818b-81a50c4f90bb","","",false, this);
 
            IDTextLineInvoicePre = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("b56e4cfa-2094-444a-bef4-7fb4ada0925d","","",false, this);
 
            IDTextLineCreditPre = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("377081fb-c030-44d3-b29e-a91bbcdba6e4","","",false, this);
 
            IDTextLineAdvancePre = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("ca7f93a3-3941-4de7-9067-6a7a1b69ea81","","",false, this);
 
            IDTextLineOfferPost = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("76a10e0a-7a4a-4690-9a15-9379a7510cd1","","",false, this);
 
            IDTextLineFContractPost = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("88b8a70f-74d4-4584-af3a-fe80629c892b","","",false, this);
 
            IDTextLineOrderPost = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("d05865b9-2292-46b5-87d6-10fa10cbd51b","","",false, this);
 
            IDTextLineDNotePost = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("be0d81a7-313f-4ddc-8e77-95096b226e8e","","",false, this);
 
            IDTextLineInvoicePost = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("d01ca06b-604c-4e36-a664-5b8c44573984","","",false, this);
 
            IDTextLineCreditPost = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("3a146762-3328-45d6-8f99-f9dfeae2fc76","","",false, this);
 
            IDTextLineAdvancePost = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("8697115e-f24c-4a22-a004-5fc827d952cc","","",false, this);
 
            TextNoticeOrder = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("aad4e7da-c0bd-4552-b9cd-253309b0ee27","","",false, this);
 
            TextNoticeSalesQuote = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("73d38b22-87c0-4ac4-8340-b7282ba638d0","","",false, this);
 
            TextNoticeMaintenance = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("50e21887-c927-45ec-90a9-ee8b8ed874fa","","",false, this);
 
            btnCalculateCustomerRiskButton = RPSControlFactory.CreateRPSButton<CustomerEntityView>( "bf564abb-b3b6-45ef-bb8e-64e987f12a86","","",this);
 
            NewCustomerFromCopyChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<CustomerEntityView,NewCustomerFromCopyChildDialogView>("451c3b2a-6b44-46fa-b629-29600e7d2787","","", this,Screen.NewCustomerFromCopyChildDialogView);
 
            ValidNIFCommandButton = RPSControlFactory.CreateRPSButton<CustomerEntityView>( "54503893-9849-4afc-9e7c-aa708b39e49b","","",this);
 
            CollectionInit params_DeliveryAddresss = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="44ebd70b-dfd8-43f8-96bb-0dddb480967f",CSSSelectorGrid="",XPathGrid=""};
            DeliveryAddresss = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryAddresssCollectionEditor<CustomerEntityView,CustomerDeliveryAddressView>,CustomerEntityView,CustomerDeliveryAddressView>( params_DeliveryAddresss,this,Screen.CustomerDeliveryAddressView);
 
            CollectionInit params_CustomerContacts = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c09cb5ae-64bb-4cd7-8368-5a59371fc3f1",CSSSelectorGrid="",XPathGrid=""};
            CustomerContacts = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerContactsCollectionEditor<CustomerEntityView,CustomerDeliveryAddressView>,CustomerEntityView,CustomerDeliveryAddressView>( params_CustomerContacts,this,Screen.CustomerDeliveryAddressView);
 
            CollectionInit params_CustomerCommercialAgents = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="aaff6231-2221-445e-a48f-39b361f5b9e4",CSSSelectorGrid="",XPathGrid=""};
            CustomerCommercialAgents = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerCommercialAgentsCollectionEditor<CustomerEntityView,CustomerDeliveryAddressView>,CustomerEntityView,CustomerDeliveryAddressView>( params_CustomerCommercialAgents,this,Screen.CustomerDeliveryAddressView);
 
            CollectionInit params_CustomerBankAccounts = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="02f965ab-e6a1-4488-9c63-91b9e3001deb",CSSSelectorGrid="",XPathGrid=""};
            CustomerBankAccounts = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerBankAccountsCollectionEditor<CustomerEntityView,CustomerDeliveryAddressView>,CustomerEntityView,CustomerDeliveryAddressView>( params_CustomerBankAccounts,this,Screen.CustomerDeliveryAddressView);
 
            CollectionInit params_CustomerPaymentAddresss = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b398d975-526e-407c-b737-674843c6e0d5",CSSSelectorGrid="",XPathGrid=""};
            CustomerPaymentAddresss = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerPaymentAddresssCollectionEditor<CustomerEntityView,CustomerDeliveryAddressView>,CustomerEntityView,CustomerDeliveryAddressView>( params_CustomerPaymentAddresss,this,Screen.CustomerDeliveryAddressView);
 
            CollectionInit params_CustomerReports = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b8fd0b7e-5ee0-4111-96c6-59994ed4fe61",CSSSelectorGrid="",XPathGrid=""};
            CustomerReports = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerReportsCollectionEditor<CustomerEntityView,CustomerDeliveryAddressView>,CustomerEntityView,CustomerDeliveryAddressView>( params_CustomerReports,this,Screen.CustomerDeliveryAddressView);
 
            CollectionInit params_CustomerDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ababa980-1306-46ec-b0d9-dd226f42ee74",CSSSelectorGrid="",XPathGrid=""};
            CustomerDetails = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerDetailsCollectionEditor<CustomerEntityView,CustomerDeliveryAddressView>,CustomerEntityView,CustomerDeliveryAddressView>( params_CustomerDetails,this,Screen.CustomerDeliveryAddressView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<CustomerEntityView>( "","ul li[rpsid='578dc67d-8873-4fee-8a10-16e2a763982c']","",this);
 
            InvoiceData = RPSControlFactory.CreateRPSSection<CustomerEntityView>( "","ul li[rpsid='7a78e3b8-5ce6-4768-9e03-3355558b3450']","",this);
 
            DeliveryAddress = RPSControlFactory.CreateRPSSection<CustomerEntityView>( "","ul li[rpsid='e06d46ec-eb8e-4df5-bc9b-aa58f8ebad71']","",this);
 
            Contacts = RPSControlFactory.CreateRPSSection<CustomerEntityView>( "","ul li[rpsid='e3844e5d-ef15-4477-98d8-56d32f8d3ab5']","",this);
 
            CommercialAgents = RPSControlFactory.CreateRPSSection<CustomerEntityView>( "","ul li[rpsid='00a1098f-ebea-4462-bcad-59d42d2b8f71']","",this);
 
            BankAccount = RPSControlFactory.CreateRPSSection<CustomerEntityView>( "","ul li[rpsid='85a851b4-1462-47ae-a896-1681d67b3418']","",this);
 
            PaymentAddress = RPSControlFactory.CreateRPSSection<CustomerEntityView>( "","ul li[rpsid='7bf4cc07-91f1-46b1-b597-c91f987ff48c']","",this);
 
            Reports = RPSControlFactory.CreateRPSSection<CustomerEntityView>( "","ul li[rpsid='fd56df14-07da-40aa-bf9d-c9280621d614']","",this);
 
            SubsidiaryCompanies = RPSControlFactory.CreateRPSSection<CustomerEntityView>( "","ul li[rpsid='006e1334-ae92-4cad-ac77-b76bbe2100fc']","",this);
 
            Comment = RPSControlFactory.CreateRPSSection<CustomerEntityView>( "","ul li[rpsid='d77b533b-0090-4266-a3f2-69fcbd525ca2']","",this);
 

        }
        public IRPSSaveButton<CustomerEntityView> SaveButton { get; set; } 
        public IRPSButton<CustomerEntityView> DeleteButton { get; set; } 
        public IRPSButton<CustomerEntityView,CustomerQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerEntityView,CustomerQueryView> BackButton { get; set; } 
        public IRPSTextBox<CustomerEntityView> CodCustomer { get; set; } 
        public IRPSTextBox<CustomerEntityView> Description { get; set; } 
        public IRPSTextBox<CustomerEntityView> CompanyName { get; set; } 
        public IRPSTextBox<CustomerEntityView> VATNumber { get; set; } 
        public IRPSComboBox<CustomerEntityView> ThirdType { get; set; } 
        public IRPSTextBox<CustomerEntityView> InactiveDate { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDCustomerClassification { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDBusinessUnit { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDSector { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDZone { get; set; } 
        public IRPSComboBox<CustomerEntityView> CodUser { get; set; } 
        public IRPSTextBox<CustomerEntityView> Ean13 { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDSupplier { get; set; } 
        public IRPSTextBox<CustomerEntityView> CustomerSupplierINFO { get; set; } 
        public IRPSCheckbox<CustomerEntityView> Miscellaneous { get; set; } 
        public IRPSComboBox<CustomerEntityView> CodCountry { get; set; } 
        public IRPSTextBox<CustomerEntityView> ZipCode { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDState { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDCounty { get; set; } 
        public IRPSTextBox<CustomerEntityView> Address { get; set; } 
        public IRPSTextBox<CustomerEntityView> City { get; set; } 
        public IRPSTextBox<CustomerEntityView> Position { get; set; } 
        public IRPSTextBox<CustomerEntityView> Phone1 { get; set; } 
        public IRPSTextBox<CustomerEntityView> Phone2 { get; set; } 
        public IRPSTextBox<CustomerEntityView> Fax { get; set; } 
        public IRPSTextBox<CustomerEntityView> Email { get; set; } 
        public IRPSComboBox<CustomerEntityView> CodLanguage { get; set; } 
        public IRPSTextBox<CustomerEntityView> RiskLimit { get; set; } 
        public IRPSComboBox<CustomerEntityView> RiskType { get; set; } 
        public IRPSTextBox<CustomerEntityView> OrderRisk { get; set; } 
        public IRPSTextBox<CustomerEntityView> UnPaidRisk { get; set; } 
        public IRPSTextBox<CustomerEntityView> ReceivableRisk { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDCustomerGroup1 { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDCustomerGroup1Value { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDCustomerGroup2 { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDCustomerGroup2Value { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDCustomerGroup3 { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDCustomerGroup3Value { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDCustomerGroup4 { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDCustomerGroup4Value { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDPaymentMethod { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDCurrency { get; set; } 
        public IRPSCheckbox<CustomerEntityView> Revaluation { get; set; } 
        public IRPSCheckbox<CustomerEntityView> DiscountCreditInvoice { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDInvoicingType { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDDeliveryNoteType { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDDeliveryNoteTypeGroup { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDInvoiceTypeGroup { get; set; } 
        public IRPSComboBox<CustomerEntityView> TypeDigitalInvoice { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDBankAccountCompany { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDCashCollector { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDThirdAccType { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDVoucherType { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDVATType { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDSurchargeVATType { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDTaxGroup { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDPaymentMethodRappel { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDPriceList { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDDiscountGroup { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDCustomerCommissionGroup { get; set; } 
        public IRPSTextBox<CustomerEntityView> RetentionPercent { get; set; } 
        public IRPSComboBox<CustomerEntityView> RetentionType { get; set; } 
        public IRPSComboBox<CustomerEntityView> DiscountCondition { get; set; } 
        public IRPSTextBox<CustomerEntityView> Discount1 { get; set; } 
        public IRPSTextBox<CustomerEntityView> Discount2 { get; set; } 
        public IRPSTextBox<CustomerEntityView> Discount3 { get; set; } 
        public IRPSTextBox<CustomerEntityView> CashDiscount { get; set; } 
        public IRPSTextBox<CustomerEntityView> FinancialSurcharge { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDCommercialConditionGroup { get; set; } 
        public IRPSCheckbox<CustomerEntityView> ConditionsAffectDocument { get; set; } 
        public IRPSCheckbox<CustomerEntityView> ConditionsNotAffectDocument { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDCodingSerieSalesQuote { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDCodingSerieOrder { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDCodingSerieFrameworkContract { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDCodingSerieDeliveryNote { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDCodingSerieInvoice { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDCodingSerieCreditInvoice { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDCodingSerieDebitNote { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDCodingSerieDeliveryNoteB { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDCodingSerieInvoiceB { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDCodingSerieCreditInvoiceB { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDCodingSerieDebitNoteB { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDCodingSerieAdvanceInvoice { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDCodingSerieAdvanceInvoiceB { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDSite { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDWarehouse { get; set; } 
        public IRPSTextBox<CustomerEntityView> DeliveryDays { get; set; } 
        public IRPSTextBox<CustomerEntityView> OrderPriority { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDShippingAgent { get; set; } 
        public IRPSComboBox<CustomerEntityView> CodTransportMethod { get; set; } 
        public IRPSComboBox<CustomerEntityView> CodDeliveryTerm { get; set; } 
        public IRPSTextBox<CustomerEntityView> ReprintOrder { get; set; } 
        public IRPSTextBox<CustomerEntityView> DeliveryNoteCopies { get; set; } 
        public IRPSTextBox<CustomerEntityView> InvoiceCopies { get; set; } 
        public IRPSCheckbox<CustomerEntityView> DeliveryNoteValued { get; set; } 
        public IRPSCheckbox<CustomerEntityView> NewOrderRest { get; set; } 
        public IRPSTextBox<CustomerEntityView> SalesQuoteEffectiveDays { get; set; } 
        public IRPSCheckbox<CustomerEntityView> Blocked { get; set; } 
        public IRPSCheckbox<CustomerEntityView> BlockedCRM { get; set; } 
        public IRPSCheckbox<CustomerEntityView> BlockedMaintenance { get; set; } 
        public IRPSComboBox<CustomerEntityView> DayFixedPayment { get; set; } 
        public IRPSComboBox<CustomerEntityView> FirstDayPayment { get; set; } 
        public IRPSComboBox<CustomerEntityView> SecondDayPayment { get; set; } 
        public IRPSComboBox<CustomerEntityView> ThirdDayPayment { get; set; } 
        public IRPSComboBox<CustomerEntityView> PeriodNotPaymet { get; set; } 
        public IRPSComboBox<CustomerEntityView> KeyNotPayment { get; set; } 
        public IRPSComboBox<CustomerEntityView> FixedDayPayment { get; set; } 
        public IRPSComboBox<CustomerEntityView> FixedMonthPayment { get; set; } 
        public IRPSTextBox<CustomerEntityView> AdvancePercentage { get; set; } 
        public IRPSComboBox<CustomerEntityView> DayNotPaymentFrom1 { get; set; } 
        public IRPSComboBox<CustomerEntityView> MonthNotPaymentFrom1 { get; set; } 
        public IRPSComboBox<CustomerEntityView> DayNotPaymentTo1 { get; set; } 
        public IRPSComboBox<CustomerEntityView> MonthNotPaymentTo1 { get; set; } 
        public IRPSComboBox<CustomerEntityView> DayNotPaymentFrom2 { get; set; } 
        public IRPSComboBox<CustomerEntityView> MonthNotPaymentFrom2 { get; set; } 
        public IRPSComboBox<CustomerEntityView> DayNotPaymentTo2 { get; set; } 
        public IRPSComboBox<CustomerEntityView> MonthNotPaymentTo2 { get; set; } 
        public IRPSComboBox<CustomerEntityView> DayNotPaymentFrom3 { get; set; } 
        public IRPSComboBox<CustomerEntityView> MonthNotPaymentFrom3 { get; set; } 
        public IRPSComboBox<CustomerEntityView> DayNotPaymentTo3 { get; set; } 
        public IRPSComboBox<CustomerEntityView> MonthNotPaymentTo3 { get; set; } 
        public IRPSTextBox<CustomerEntityView> RpnMax { get; set; } 
        public IRPSTextBox<CustomerEntityView> CommentCustomer { get; set; } 
        public IRPSTextBox<CustomerEntityView> CommentOrder { get; set; } 
        public IRPSTextBox<CustomerEntityView> CommentDeliveryNote { get; set; } 
        public IRPSTextBox<CustomerEntityView> CommentInvoice { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDTextLineOfferPre { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDTextLineFContractPre { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDTextLineOrderPre { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDTextLineDNotePre { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDTextLineInvoicePre { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDTextLineCreditPre { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDTextLineAdvancePre { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDTextLineOfferPost { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDTextLineFContractPost { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDTextLineOrderPost { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDTextLineDNotePost { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDTextLineInvoicePost { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDTextLineCreditPost { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDTextLineAdvancePost { get; set; } 
        public IRPSTextBox<CustomerEntityView> TextNoticeOrder { get; set; } 
        public IRPSTextBox<CustomerEntityView> TextNoticeSalesQuote { get; set; } 
        public IRPSTextBox<CustomerEntityView> TextNoticeMaintenance { get; set; } 
        public IRPSButton<CustomerEntityView> btnCalculateCustomerRiskButton { get; set; } 
        public IRPSButton<CustomerEntityView,NewCustomerFromCopyChildDialogView> NewCustomerFromCopyChildNavigationCommandButton { get; set; } 
        public IRPSButton<CustomerEntityView> ValidNIFCommandButton { get; set; } 
        public DeliveryAddresssCollectionEditor<CustomerEntityView,CustomerDeliveryAddressView> DeliveryAddresss { get; set; } 
        public CustomerContactsCollectionEditor<CustomerEntityView,CustomerDeliveryAddressView> CustomerContacts { get; set; } 
        public CustomerCommercialAgentsCollectionEditor<CustomerEntityView,CustomerDeliveryAddressView> CustomerCommercialAgents { get; set; } 
        public CustomerBankAccountsCollectionEditor<CustomerEntityView,CustomerDeliveryAddressView> CustomerBankAccounts { get; set; } 
        public CustomerPaymentAddresssCollectionEditor<CustomerEntityView,CustomerDeliveryAddressView> CustomerPaymentAddresss { get; set; } 
        public CustomerReportsCollectionEditor<CustomerEntityView,CustomerDeliveryAddressView> CustomerReports { get; set; } 
        public CustomerDetailsCollectionEditor<CustomerEntityView,CustomerDeliveryAddressView> CustomerDetails { get; set; } 
        public IRPSSection<CustomerEntityView> GeneralData { get; set; } 
        public IRPSSection<CustomerEntityView> InvoiceData { get; set; } 
        public IRPSSection<CustomerEntityView> DeliveryAddress { get; set; } 
        public IRPSSection<CustomerEntityView> Contacts { get; set; } 
        public IRPSSection<CustomerEntityView> CommercialAgents { get; set; } 
        public IRPSSection<CustomerEntityView> BankAccount { get; set; } 
        public IRPSSection<CustomerEntityView> PaymentAddress { get; set; } 
        public IRPSSection<CustomerEntityView> Reports { get; set; } 
        public IRPSSection<CustomerEntityView> SubsidiaryCompanies { get; set; } 
        public IRPSSection<CustomerEntityView> Comment { get; set; } 
        public Customer Screen { get; set; }
        public CustomerEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DeliveryAddresssCollectionEditor<CustomerEntityView,CustomerDeliveryAddressView>:RPSCollectionEditor<CustomerEntityView,CustomerDeliveryAddressView> where CustomerEntityView : class, IView where CustomerDeliveryAddressView : class, IView
    {
        public  DeliveryAddresssGridView<CustomerEntityView,CustomerDeliveryAddressView> GridView {get;set;}
    }
    public partial class DeliveryAddresssGridView <CustomerEntityView,CustomerDeliveryAddressView> :  RPSGridView<CustomerEntityView,CustomerDeliveryAddressView> where CustomerEntityView : class, IView where CustomerDeliveryAddressView : class, IView
    {
        public DeliveryAddresssGridView(CustomerEntityView currentView,CustomerDeliveryAddressView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodCustomerDeliveryAddress = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#44ebd70b-dfd8-43f8-96bb-0dddb480967f .ag-row[role='row']@ROWINDEX [col-id='cCodCustomerDeliveryAddress']","",true, this.CurrentView);
 
            DefaultAddress = RPSControlFactory.CreateRPSGridCheckBox<CustomerEntityView>("","#44ebd70b-dfd8-43f8-96bb-0dddb480967f .ag-row[role='row']@ROWINDEX [col-id='cDefaultAddress']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#44ebd70b-dfd8-43f8-96bb-0dddb480967f .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Address = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#44ebd70b-dfd8-43f8-96bb-0dddb480967f .ag-row[role='row']@ROWINDEX [col-id='cAddress']","",false, this.CurrentView);
 
            Phone1 = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#44ebd70b-dfd8-43f8-96bb-0dddb480967f .ag-row[role='row']@ROWINDEX [col-id='cPhone1']","",false, this.CurrentView);
 
            Email = RPSControlFactory.CreateRPSGridEmailTextBox<CustomerEntityView>("","#44ebd70b-dfd8-43f8-96bb-0dddb480967f .ag-row[role='row']@ROWINDEX [col-id='cEmail']","",false, this.CurrentView);
 
            ContactPerson = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#44ebd70b-dfd8-43f8-96bb-0dddb480967f .ag-row[role='row']@ROWINDEX [col-id='cContactPerson']","",false, this.CurrentView);
 
            IDShippingAgent = RPSControlFactory.CreateRPSGridComboBox<CustomerEntityView>("","#44ebd70b-dfd8-43f8-96bb-0dddb480967f .ag-row[role='row']@ROWINDEX [col-id='cIDShippingAgent']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CustomerEntityView> CodCustomerDeliveryAddress { get; set; } 
        public IRPSGridCheckbox<CustomerEntityView> DefaultAddress { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> Description { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> Address { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> Phone1 { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> Email { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> ContactPerson { get; set; } 
        public IRPSGridComboBox<CustomerEntityView> IDShippingAgent { get; set; } 
                     
    }
 
        public partial class CustomerContactsCollectionEditor<CustomerEntityView,CustomerDeliveryAddressView>:RPSCollectionEditor<CustomerEntityView,CustomerDeliveryAddressView> where CustomerEntityView : class, IView where CustomerDeliveryAddressView : class, IView
    {
        public  CustomerContactsGridView<CustomerEntityView,CustomerDeliveryAddressView> GridView {get;set;}
    }
    public partial class CustomerContactsGridView <CustomerEntityView,CustomerDeliveryAddressView> :  RPSGridView<CustomerEntityView,CustomerDeliveryAddressView> where CustomerEntityView : class, IView where CustomerDeliveryAddressView : class, IView
    {
        public CustomerContactsGridView(CustomerEntityView currentView,CustomerDeliveryAddressView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDContactType = RPSControlFactory.CreateRPSGridComboBox<CustomerEntityView>("","#c09cb5ae-64bb-4cd7-8368-5a59371fc3f1 .ag-row[role='row']@ROWINDEX [col-id='cIDContactType']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#c09cb5ae-64bb-4cd7-8368-5a59371fc3f1 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",true, this.CurrentView);
 
            Commercial = RPSControlFactory.CreateRPSGridCheckBox<CustomerEntityView>("","#c09cb5ae-64bb-4cd7-8368-5a59371fc3f1 .ag-row[role='row']@ROWINDEX [col-id='cCommercial']","",true, this.CurrentView);
 
            DefaultCommercial = RPSControlFactory.CreateRPSGridCheckBox<CustomerEntityView>("","#c09cb5ae-64bb-4cd7-8368-5a59371fc3f1 .ag-row[role='row']@ROWINDEX [col-id='cDefaultCommercial']","",true, this.CurrentView);
 
            DefaultAdministration = RPSControlFactory.CreateRPSGridCheckBox<CustomerEntityView>("","#c09cb5ae-64bb-4cd7-8368-5a59371fc3f1 .ag-row[role='row']@ROWINDEX [col-id='cDefaultAdministration']","",true, this.CurrentView);
 
            DefaultFinancial = RPSControlFactory.CreateRPSGridCheckBox<CustomerEntityView>("","#c09cb5ae-64bb-4cd7-8368-5a59371fc3f1 .ag-row[role='row']@ROWINDEX [col-id='cDefaultFinancial']","",true, this.CurrentView);
 
            Technical = RPSControlFactory.CreateRPSGridCheckBox<CustomerEntityView>("","#c09cb5ae-64bb-4cd7-8368-5a59371fc3f1 .ag-row[role='row']@ROWINDEX [col-id='cTechnical']","",true, this.CurrentView);
 
            Phone1 = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#c09cb5ae-64bb-4cd7-8368-5a59371fc3f1 .ag-row[role='row']@ROWINDEX [col-id='cPhone1']","",false, this.CurrentView);
 
            Email = RPSControlFactory.CreateRPSGridEmailTextBox<CustomerEntityView>("","#c09cb5ae-64bb-4cd7-8368-5a59371fc3f1 .ag-row[role='row']@ROWINDEX [col-id='cEmail']","",false, this.CurrentView);
 
            InactiveDate = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#c09cb5ae-64bb-4cd7-8368-5a59371fc3f1 .ag-row[role='row']@ROWINDEX [col-id='cInactiveDate']","",false, this.CurrentView);
 
            FirstName = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#c09cb5ae-64bb-4cd7-8368-5a59371fc3f1 .ag-row[role='row']@ROWINDEX [col-id='cFirstName']","",false, this.CurrentView);
 
            LastName = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#c09cb5ae-64bb-4cd7-8368-5a59371fc3f1 .ag-row[role='row']@ROWINDEX [col-id='cLastName']","",false, this.CurrentView);
 
            Gender = RPSControlFactory.CreateRPSGridEnumComboBox<CustomerEntityView>("","#c09cb5ae-64bb-4cd7-8368-5a59371fc3f1 .ag-row[role='row']@ROWINDEX [col-id='cGender']","",true, this.CurrentView);
 
            Title = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#c09cb5ae-64bb-4cd7-8368-5a59371fc3f1 .ag-row[role='row']@ROWINDEX [col-id='cTitle']","",false, this.CurrentView);
 
            Position = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#c09cb5ae-64bb-4cd7-8368-5a59371fc3f1 .ag-row[role='row']@ROWINDEX [col-id='cPosition']","",false, this.CurrentView);
 
            Mobile = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#c09cb5ae-64bb-4cd7-8368-5a59371fc3f1 .ag-row[role='row']@ROWINDEX [col-id='cMobile']","",false, this.CurrentView);
 
            Location = RPSControlFactory.CreateRPSGridMemoTextBox<CustomerEntityView>("","#c09cb5ae-64bb-4cd7-8368-5a59371fc3f1 .ag-row[role='row']@ROWINDEX [col-id='cLocation']","",false, this.CurrentView);
 
            SkypeName = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#c09cb5ae-64bb-4cd7-8368-5a59371fc3f1 .ag-row[role='row']@ROWINDEX [col-id='cSkypeName']","",false, this.CurrentView);
 
            Newsletter = RPSControlFactory.CreateRPSGridCheckBox<CustomerEntityView>("","#c09cb5ae-64bb-4cd7-8368-5a59371fc3f1 .ag-row[role='row']@ROWINDEX [col-id='cNewsletter']","",true, this.CurrentView);
 
            DateOfBirth = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#c09cb5ae-64bb-4cd7-8368-5a59371fc3f1 .ag-row[role='row']@ROWINDEX [col-id='cDateOfBirth']","",false, this.CurrentView);
 
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<CustomerEntityView>("","#c09cb5ae-64bb-4cd7-8368-5a59371fc3f1 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",false, this.CurrentView);
 
            Department = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#c09cb5ae-64bb-4cd7-8368-5a59371fc3f1 .ag-row[role='row']@ROWINDEX [col-id='cDepartment']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<CustomerEntityView> IDContactType { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> Description { get; set; } 
        public IRPSGridCheckbox<CustomerEntityView> Commercial { get; set; } 
        public IRPSGridCheckbox<CustomerEntityView> DefaultCommercial { get; set; } 
        public IRPSGridCheckbox<CustomerEntityView> DefaultAdministration { get; set; } 
        public IRPSGridCheckbox<CustomerEntityView> DefaultFinancial { get; set; } 
        public IRPSGridCheckbox<CustomerEntityView> Technical { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> Phone1 { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> Email { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> InactiveDate { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> FirstName { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> LastName { get; set; } 
        public IRPSGridComboBox<CustomerEntityView> Gender { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> Title { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> Position { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> Mobile { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> Location { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> SkypeName { get; set; } 
        public IRPSGridCheckbox<CustomerEntityView> Newsletter { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> DateOfBirth { get; set; } 
        public IRPSGridComboBox<CustomerEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> Department { get; set; } 
                     
    }
 
        public partial class CustomerCommercialAgentsCollectionEditor<CustomerEntityView,CustomerDeliveryAddressView>:RPSCollectionEditor<CustomerEntityView,CustomerDeliveryAddressView> where CustomerEntityView : class, IView where CustomerDeliveryAddressView : class, IView
    {
        public  CustomerCommercialAgentsGridView<CustomerEntityView,CustomerDeliveryAddressView> GridView {get;set;}
    }
    public partial class CustomerCommercialAgentsGridView <CustomerEntityView,CustomerDeliveryAddressView> :  RPSGridView<CustomerEntityView,CustomerDeliveryAddressView> where CustomerEntityView : class, IView where CustomerDeliveryAddressView : class, IView
    {
        public CustomerCommercialAgentsGridView(CustomerEntityView currentView,CustomerDeliveryAddressView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDCommercialAgent = RPSControlFactory.CreateRPSGridComboBox<CustomerEntityView>("","#aaff6231-2221-445e-a48f-39b361f5b9e4 .ag-row[role='row']@ROWINDEX [col-id='cIDCommercialAgent']","",true, this.CurrentView);
 
            IDCommercialAgentClassification = RPSControlFactory.CreateRPSGridComboBox<CustomerEntityView>("","#aaff6231-2221-445e-a48f-39b361f5b9e4 .ag-row[role='row']@ROWINDEX [col-id='cIDCommercialAgentClassification']","",true, this.CurrentView);
 
            InactiveDate = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#aaff6231-2221-445e-a48f-39b361f5b9e4 .ag-row[role='row']@ROWINDEX [col-id='cInactiveDate']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<CustomerEntityView> IDCommercialAgent { get; set; } 
        public IRPSGridComboBox<CustomerEntityView> IDCommercialAgentClassification { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> InactiveDate { get; set; } 
                     
    }
 
        public partial class CustomerBankAccountsCollectionEditor<CustomerEntityView,CustomerDeliveryAddressView>:RPSCollectionEditor<CustomerEntityView,CustomerDeliveryAddressView> where CustomerEntityView : class, IView where CustomerDeliveryAddressView : class, IView
    {
        public  CustomerBankAccountsGridView<CustomerEntityView,CustomerDeliveryAddressView> GridView {get;set;}
    }
    public partial class CustomerBankAccountsGridView <CustomerEntityView,CustomerDeliveryAddressView> :  RPSGridView<CustomerEntityView,CustomerDeliveryAddressView> where CustomerEntityView : class, IView where CustomerDeliveryAddressView : class, IView
    {
        public CustomerBankAccountsGridView(CustomerEntityView currentView,CustomerDeliveryAddressView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Default = RPSControlFactory.CreateRPSGridCheckBox<CustomerEntityView>("","#02f965ab-e6a1-4488-9c63-91b9e3001deb .ag-row[role='row']@ROWINDEX [col-id='cDefault']","",true, this.CurrentView);
 
            CodCustomerBankAccount = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#02f965ab-e6a1-4488-9c63-91b9e3001deb .ag-row[role='row']@ROWINDEX [col-id='cCodCustomerBankAccount']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#02f965ab-e6a1-4488-9c63-91b9e3001deb .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            CodBank = RPSControlFactory.CreateRPSGridComboBox<CustomerEntityView>("","#02f965ab-e6a1-4488-9c63-91b9e3001deb .ag-row[role='row']@ROWINDEX [col-id='cCodBank']","",false, this.CurrentView);
 
            BankAccount = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#02f965ab-e6a1-4488-9c63-91b9e3001deb .ag-row[role='row']@ROWINDEX [col-id='cBankAccount']","",false, this.CurrentView);
 
            IBAN = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#02f965ab-e6a1-4488-9c63-91b9e3001deb .ag-row[role='row']@ROWINDEX [col-id='cIBAN']","",false, this.CurrentView);
 

        }
        public IRPSGridCheckbox<CustomerEntityView> Default { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> CodCustomerBankAccount { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> Description { get; set; } 
        public IRPSGridComboBox<CustomerEntityView> CodBank { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> BankAccount { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> IBAN { get; set; } 
                     
    }
 
        public partial class CustomerPaymentAddresssCollectionEditor<CustomerEntityView,CustomerDeliveryAddressView>:RPSCollectionEditor<CustomerEntityView,CustomerDeliveryAddressView> where CustomerEntityView : class, IView where CustomerDeliveryAddressView : class, IView
    {
        public  CustomerPaymentAddresssGridView<CustomerEntityView,CustomerDeliveryAddressView> GridView {get;set;}
    }
    public partial class CustomerPaymentAddresssGridView <CustomerEntityView,CustomerDeliveryAddressView> :  RPSGridView<CustomerEntityView,CustomerDeliveryAddressView> where CustomerEntityView : class, IView where CustomerDeliveryAddressView : class, IView
    {
        public CustomerPaymentAddresssGridView(CustomerEntityView currentView,CustomerDeliveryAddressView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodCustomerPaymentAddress = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#b398d975-526e-407c-b737-674843c6e0d5 .ag-row[role='row']@ROWINDEX [col-id='cCodCustomerPaymentAddress']","",true, this.CurrentView);
 
            DefaultAddress = RPSControlFactory.CreateRPSGridCheckBox<CustomerEntityView>("","#b398d975-526e-407c-b737-674843c6e0d5 .ag-row[role='row']@ROWINDEX [col-id='cDefaultAddress']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#b398d975-526e-407c-b737-674843c6e0d5 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Address = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#b398d975-526e-407c-b737-674843c6e0d5 .ag-row[role='row']@ROWINDEX [col-id='cAddress']","",false, this.CurrentView);
 
            Phone1 = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#b398d975-526e-407c-b737-674843c6e0d5 .ag-row[role='row']@ROWINDEX [col-id='cPhone1']","",false, this.CurrentView);
 
            Email = RPSControlFactory.CreateRPSGridEmailTextBox<CustomerEntityView>("","#b398d975-526e-407c-b737-674843c6e0d5 .ag-row[role='row']@ROWINDEX [col-id='cEmail']","",false, this.CurrentView);
 
            ContactPerson = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#b398d975-526e-407c-b737-674843c6e0d5 .ag-row[role='row']@ROWINDEX [col-id='cContactPerson']","",false, this.CurrentView);
 
            IDCustomerPayer = RPSControlFactory.CreateRPSGridComboBox<CustomerEntityView>("","#b398d975-526e-407c-b737-674843c6e0d5 .ag-row[role='row']@ROWINDEX [col-id='cIDCustomerPayer']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CustomerEntityView> CodCustomerPaymentAddress { get; set; } 
        public IRPSGridCheckbox<CustomerEntityView> DefaultAddress { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> Description { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> Address { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> Phone1 { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> Email { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> ContactPerson { get; set; } 
        public IRPSGridComboBox<CustomerEntityView> IDCustomerPayer { get; set; } 
                     
    }
 
        public partial class CustomerReportsCollectionEditor<CustomerEntityView,CustomerDeliveryAddressView>:RPSCollectionEditor<CustomerEntityView,CustomerDeliveryAddressView> where CustomerEntityView : class, IView where CustomerDeliveryAddressView : class, IView
    {
        public  CustomerReportsGridView<CustomerEntityView,CustomerDeliveryAddressView> GridView {get;set;}
    }
    public partial class CustomerReportsGridView <CustomerEntityView,CustomerDeliveryAddressView> :  RPSGridView<CustomerEntityView,CustomerDeliveryAddressView> where CustomerEntityView : class, IView where CustomerDeliveryAddressView : class, IView
    {
        public CustomerReportsGridView(CustomerEntityView currentView,CustomerDeliveryAddressView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            FormatType = RPSControlFactory.CreateRPSGridEnumComboBox<CustomerEntityView>("","#b8fd0b7e-5ee0-4111-96c6-59994ed4fe61 .ag-row[role='row']@ROWINDEX [col-id='cFormatType']","",true, this.CurrentView);
 
            DefaultReport = RPSControlFactory.CreateRPSGridCheckBox<CustomerEntityView>("","#b8fd0b7e-5ee0-4111-96c6-59994ed4fe61 .ag-row[role='row']@ROWINDEX [col-id='cDefaultReport']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#b8fd0b7e-5ee0-4111-96c6-59994ed4fe61 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            IDCustomReport = RPSControlFactory.CreateRPSGridComboBox<CustomerEntityView>("","#b8fd0b7e-5ee0-4111-96c6-59994ed4fe61 .ag-row[role='row']@ROWINDEX [col-id='cIDCustomReport']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<CustomerEntityView> FormatType { get; set; } 
        public IRPSGridCheckbox<CustomerEntityView> DefaultReport { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> Description { get; set; } 
        public IRPSGridComboBox<CustomerEntityView> IDCustomReport { get; set; } 
                     
    }
 
        public partial class CustomerDetailsCollectionEditor<CustomerEntityView,CustomerDeliveryAddressView>:RPSCollectionEditor<CustomerEntityView,CustomerDeliveryAddressView> where CustomerEntityView : class, IView where CustomerDeliveryAddressView : class, IView
    {
        public  CustomerDetailsGridView<CustomerEntityView,CustomerDeliveryAddressView> GridView {get;set;}
    }
    public partial class CustomerDetailsGridView <CustomerEntityView,CustomerDeliveryAddressView> :  RPSGridView<CustomerEntityView,CustomerDeliveryAddressView> where CustomerEntityView : class, IView where CustomerDeliveryAddressView : class, IView
    {
        public CustomerDetailsGridView(CustomerEntityView currentView,CustomerDeliveryAddressView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodCompany = RPSControlFactory.CreateRPSGridComboBox<CustomerEntityView>("","#ababa980-1306-46ec-b0d9-dd226f42ee74 .ag-row[role='row']@ROWINDEX [col-id='cCodCompany']","",true, this.CurrentView);
 
            IDBusinessUnit = RPSControlFactory.CreateRPSGridComboBox<CustomerEntityView>("","#ababa980-1306-46ec-b0d9-dd226f42ee74 .ag-row[role='row']@ROWINDEX [col-id='cIDBusinessUnit']","",false, this.CurrentView);
 
            IDCurrency = RPSControlFactory.CreateRPSGridComboBox<CustomerEntityView>("","#ababa980-1306-46ec-b0d9-dd226f42ee74 .ag-row[role='row']@ROWINDEX [col-id='cIDCurrency']","",true, this.CurrentView);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSGridComboBox<CustomerEntityView>("","#ababa980-1306-46ec-b0d9-dd226f42ee74 .ag-row[role='row']@ROWINDEX [col-id='cIDPaymentMethod']","",false, this.CurrentView);
 
            IDPaymentMethodRappel = RPSControlFactory.CreateRPSGridComboBox<CustomerEntityView>("","#ababa980-1306-46ec-b0d9-dd226f42ee74 .ag-row[role='row']@ROWINDEX [col-id='cIDPaymentMethodRappel']","",false, this.CurrentView);
 
            IDVATType = RPSControlFactory.CreateRPSGridComboBox<CustomerEntityView>("","#ababa980-1306-46ec-b0d9-dd226f42ee74 .ag-row[role='row']@ROWINDEX [col-id='cIDVATType']","",true, this.CurrentView);
 
            IDPriceList = RPSControlFactory.CreateRPSGridComboBox<CustomerEntityView>("","#ababa980-1306-46ec-b0d9-dd226f42ee74 .ag-row[role='row']@ROWINDEX [col-id='cIDPriceList']","",false, this.CurrentView);
 
            SalesQuoteEffectiveDays = RPSControlFactory.CreateRPSGridFormattedTextBox<CustomerEntityView>("","#ababa980-1306-46ec-b0d9-dd226f42ee74 .ag-row[role='row']@ROWINDEX [col-id='cSalesQuoteEffectiveDays']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<CustomerEntityView> CodCompany { get; set; } 
        public IRPSGridComboBox<CustomerEntityView> IDBusinessUnit { get; set; } 
        public IRPSGridComboBox<CustomerEntityView> IDCurrency { get; set; } 
        public IRPSGridComboBox<CustomerEntityView> IDPaymentMethod { get; set; } 
        public IRPSGridComboBox<CustomerEntityView> IDPaymentMethodRappel { get; set; } 
        public IRPSGridComboBox<CustomerEntityView> IDVATType { get; set; } 
        public IRPSGridComboBox<CustomerEntityView> IDPriceList { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> SalesQuoteEffectiveDays { get; set; } 
                     
    }
 
    }
  
            
    public partial class CustomerDeliveryAddressView : View
    {
        public CustomerDeliveryAddressView(Customer screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CustomerDeliveryAddressView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CustomerDeliveryAddressView,CustomerEntityView>( this,Screen.CustomerEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<CustomerDeliveryAddressView,CustomerEntityView>( this,Screen.CustomerEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CustomerDeliveryAddressView,CustomerEntityView>( this,Screen.CustomerEntityView);
 
            CodCustomerDeliveryAddress = RPSControlFactory.CreateRPSTextBox<CustomerDeliveryAddressView>("0d1d0511-4c43-4513-8ab3-ec372668686b","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CustomerDeliveryAddressView>("5d0e082c-8f5b-41cd-a7bd-4c432a29f293","","",false, this);
 
            DefaultAddress = RPSControlFactory.CreateRPSCheckBox<CustomerDeliveryAddressView>("9a839b9f-e980-474f-9e66-06bcd4d4e5f0","","",true, this);
 
            Ean13 = RPSControlFactory.CreateRPSTextBox<CustomerDeliveryAddressView>("402a745d-432c-47c7-9043-e64c986315a6","","",false, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<CustomerDeliveryAddressView>("c79a34de-1c7d-40f8-9b0c-a02054935425","","",false, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<CustomerDeliveryAddressView>("850af7da-4e65-49db-b244-e798d906fb1b","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<CustomerDeliveryAddressView>("fc30e3ad-0e56-41ca-9349-b7b8fb774885","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<CustomerDeliveryAddressView>("5c33919b-9770-47d4-bf62-849ff5fc2e3e","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<CustomerDeliveryAddressView>("fc3c9b7d-cfb4-4e26-b789-9cfbc4f20b43","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<CustomerDeliveryAddressView>("b61d4363-be99-40f2-8c13-c47097d37c7f","","",false, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<CustomerDeliveryAddressView>("5dfe558e-ae90-4081-bd1f-0b0d43022255","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<CustomerDeliveryAddressView>("6198613f-705e-4a8c-8663-461bc45853ed","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<CustomerDeliveryAddressView>("87bdb222-60a5-44ad-9f0e-f5a9cddf92b5","","",false, this);
 
            Email = RPSControlFactory.CreateRPSEmailTextBox<CustomerDeliveryAddressView>("5cbe9260-1930-49f9-bb43-79bfa77a13f9","","",false, this);
 
            IDCustomerContact = RPSControlFactory.CreateRPSComboBox<CustomerDeliveryAddressView>("e7aa1e7c-7ed0-4235-a3d1-329650c0bf21","","",false, this);
 
            ContactPerson = RPSControlFactory.CreateRPSTextBox<CustomerDeliveryAddressView>("ff71531c-93a4-4786-85ca-901061b0ad2e","","",false, this);
 
            IDVATType = RPSControlFactory.CreateRPSComboBox<CustomerDeliveryAddressView>("24a66898-6204-4d05-b5b2-b4f673f89e51","","",false, this);
 
            IDSurchargeVATType = RPSControlFactory.CreateRPSComboBox<CustomerDeliveryAddressView>("7ecf3efb-ed81-4bc3-8de0-fd5ee2c6d7f3","","",false, this);
 
            IDTaxGroup = RPSControlFactory.CreateRPSComboBox<CustomerDeliveryAddressView>("6ad2b9ae-c54c-4d36-8722-c248bcf3130e","","",false, this);
 
            IDVoucherType = RPSControlFactory.CreateRPSComboBox<CustomerDeliveryAddressView>("cba35059-e6da-41bc-b0d0-92ba2e4b4a75","","",false, this);
 
            CodDeliveryTerm = RPSControlFactory.CreateRPSComboBox<CustomerDeliveryAddressView>("83df4fea-b453-4a44-99b7-1c99cef4d672","","",false, this);
 
            CodTransportMethod = RPSControlFactory.CreateRPSComboBox<CustomerDeliveryAddressView>("de342af0-ee70-4539-9cd5-41f7c9944ef9","","",false, this);
 
            IDShippingAgent = RPSControlFactory.CreateRPSComboBox<CustomerDeliveryAddressView>("695cb192-7b7e-4122-8b7c-824ccbb64705","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<CustomerDeliveryAddressView>("4fb841fc-d4c7-4a2e-80f1-9f5e65730c39","","",false, this);
 
            GeneralData = RPSControlFactory.CreateRPSSection<CustomerDeliveryAddressView>( "","ul li[rpsid='cf2a7375-b6cc-47b0-bf6b-62bcf457b4cc']","",this);
 
            Comment1 = RPSControlFactory.CreateRPSSection<CustomerDeliveryAddressView>( "","ul li[rpsid='5f8a2b6f-2dab-41d1-82cf-7bf23f039b4f']","",this);
 

        }
        public IRPSButton<CustomerDeliveryAddressView> DeleteButton { get; set; } 
        public IRPSButton<CustomerDeliveryAddressView,CustomerEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerDeliveryAddressView,CustomerEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CustomerDeliveryAddressView,CustomerEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<CustomerDeliveryAddressView> CodCustomerDeliveryAddress { get; set; } 
        public IRPSTextBox<CustomerDeliveryAddressView> Description { get; set; } 
        public IRPSCheckbox<CustomerDeliveryAddressView> DefaultAddress { get; set; } 
        public IRPSTextBox<CustomerDeliveryAddressView> Ean13 { get; set; } 
        public IRPSComboBox<CustomerDeliveryAddressView> CodCountry { get; set; } 
        public IRPSTextBox<CustomerDeliveryAddressView> ZipCode { get; set; } 
        public IRPSComboBox<CustomerDeliveryAddressView> IDState { get; set; } 
        public IRPSComboBox<CustomerDeliveryAddressView> IDCounty { get; set; } 
        public IRPSTextBox<CustomerDeliveryAddressView> Address { get; set; } 
        public IRPSTextBox<CustomerDeliveryAddressView> City { get; set; } 
        public IRPSTextBox<CustomerDeliveryAddressView> Phone1 { get; set; } 
        public IRPSTextBox<CustomerDeliveryAddressView> Phone2 { get; set; } 
        public IRPSTextBox<CustomerDeliveryAddressView> Fax { get; set; } 
        public IRPSTextBox<CustomerDeliveryAddressView> Email { get; set; } 
        public IRPSComboBox<CustomerDeliveryAddressView> IDCustomerContact { get; set; } 
        public IRPSTextBox<CustomerDeliveryAddressView> ContactPerson { get; set; } 
        public IRPSComboBox<CustomerDeliveryAddressView> IDVATType { get; set; } 
        public IRPSComboBox<CustomerDeliveryAddressView> IDSurchargeVATType { get; set; } 
        public IRPSComboBox<CustomerDeliveryAddressView> IDTaxGroup { get; set; } 
        public IRPSComboBox<CustomerDeliveryAddressView> IDVoucherType { get; set; } 
        public IRPSComboBox<CustomerDeliveryAddressView> CodDeliveryTerm { get; set; } 
        public IRPSComboBox<CustomerDeliveryAddressView> CodTransportMethod { get; set; } 
        public IRPSComboBox<CustomerDeliveryAddressView> IDShippingAgent { get; set; } 
        public IRPSTextBox<CustomerDeliveryAddressView> Comment { get; set; } 
        public IRPSSection<CustomerDeliveryAddressView> GeneralData { get; set; } 
        public IRPSSection<CustomerDeliveryAddressView> Comment1 { get; set; } 
        public Customer Screen { get; set; }
        public CustomerDeliveryAddressView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CustomerContactView : View
    {
        public CustomerContactView(Customer screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CustomerContactView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CustomerContactView,CustomerEntityView>( this,Screen.CustomerEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<CustomerContactView,CustomerEntityView>( this,Screen.CustomerEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CustomerContactView,CustomerEntityView>( this,Screen.CustomerEntityView);
 
            IDContactType = RPSControlFactory.CreateRPSComboBox<CustomerContactView>("07c95fb9-23c8-4fbb-b8ea-47ab2ca2dfd2","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CustomerContactView>("a45145b7-a438-4980-8d46-44507a02eaf1","","",true, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<CustomerContactView>("8bfb5aa9-7e4d-492a-932f-21bdd3411b8a","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<CustomerContactView>("8110ce4a-8bef-4a7a-a555-d6c4037b3531","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<CustomerContactView>("a436c9d6-81e5-4818-8130-f10b74376327","","",false, this);
 
            Email = RPSControlFactory.CreateRPSEmailTextBox<CustomerContactView>("2aa3f810-1858-423d-be1e-766aeac18240","","",false, this);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<CustomerContactView>("3387abd3-1f64-4dc5-b133-97f3701ee325","","",false, this);
 
            InactiveDate = RPSControlFactory.CreateRPSTextBox<CustomerContactView>("5bad2c00-1833-4676-9a3f-646489db7f1e","","",false, this);
 
            Commercial = RPSControlFactory.CreateRPSCheckBox<CustomerContactView>("9f97adc9-86de-4ab2-a03e-296e916961db","","",true, this);
 
            DefaultCommercial = RPSControlFactory.CreateRPSCheckBox<CustomerContactView>("897f6e4a-ab5a-4ab3-a829-a39c4e4ac3bf","","",true, this);
 
            DefaultAdministration = RPSControlFactory.CreateRPSCheckBox<CustomerContactView>("12efb7c8-a666-4371-922f-1dce76102b6a","","",true, this);
 
            DefaultFinancial = RPSControlFactory.CreateRPSCheckBox<CustomerContactView>("ff08f9e7-a5d0-4623-a8ce-b3d2fdfdeccf","","",true, this);
 
            Technical = RPSControlFactory.CreateRPSCheckBox<CustomerContactView>("21bf9f0d-11e6-49f3-8eb7-f35d58db9fc8","","",true, this);
 
            FirstName = RPSControlFactory.CreateRPSTextBox<CustomerContactView>("d76934ab-653c-4f64-8817-fcdb8261decd","","",false, this);
 
            LastName = RPSControlFactory.CreateRPSTextBox<CustomerContactView>("e77f66ce-c450-46ce-88bd-3545ce1a76cd","","",false, this);
 
            Gender = RPSControlFactory.CreateRPSEnumComboBox<CustomerContactView>("c5addd45-08fc-405b-a842-7c1baefb3988","","",true, this);
 
            Title = RPSControlFactory.CreateRPSTextBox<CustomerContactView>("54026371-0580-4183-ba8b-e7ccbd24f4e2","","",false, this);
 
            Newsletter = RPSControlFactory.CreateRPSCheckBox<CustomerContactView>("675895c2-16a0-403c-a526-a7b6e9acba55","","",true, this);
 
            Position = RPSControlFactory.CreateRPSTextBox<CustomerContactView>("c254bb52-64b7-4295-8ee7-3747fbe06005","","",false, this);
 
            Mobile = RPSControlFactory.CreateRPSTextBox<CustomerContactView>("1aae3d97-c423-4109-beb4-15bde921db3c","","",false, this);
 
            SkypeName = RPSControlFactory.CreateRPSTextBox<CustomerContactView>("927cd00a-0bb0-4f53-8a22-a61b23ed859a","","",false, this);
 
            DateOfBirth = RPSControlFactory.CreateRPSTextBox<CustomerContactView>("77b7ef8f-0e55-483d-af23-f48eb7676154","","",false, this);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<CustomerContactView>("a7e1e9d9-bcb2-4712-8800-0bd901bd4618","","",false, this);
 
            Department = RPSControlFactory.CreateRPSTextBox<CustomerContactView>("f1110ea7-2fee-418d-9a62-3ed37c9a7882","","",false, this);
 
            InactiveDate1 = RPSControlFactory.CreateRPSTextBox<CustomerContactView>("80765ee4-c77f-4544-9d73-7690daae10fd","","",false, this);
 
            Location = RPSControlFactory.CreateRPSTextBox<CustomerContactView>("ff9311a3-2710-41d8-96a1-70247e3b0d89","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<CustomerContactView>("7b6f3718-5ea6-405e-9f22-636a56a4d167","","",false, this);
 
            GenaralDataSection = RPSControlFactory.CreateRPSSection<CustomerContactView>( "","ul li[rpsid='4ccdaffa-ef90-4818-b9fc-f8daf5f9c5ec']","",this);
 
            CommentSection = RPSControlFactory.CreateRPSSection<CustomerContactView>( "","ul li[rpsid='1c9b27c0-0cf8-42d7-95fd-69d0e99ab447']","",this);
 

        }
        public IRPSButton<CustomerContactView> DeleteButton { get; set; } 
        public IRPSButton<CustomerContactView,CustomerEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerContactView,CustomerEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CustomerContactView,CustomerEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<CustomerContactView> IDContactType { get; set; } 
        public IRPSTextBox<CustomerContactView> Description { get; set; } 
        public IRPSTextBox<CustomerContactView> Phone1 { get; set; } 
        public IRPSTextBox<CustomerContactView> Phone2 { get; set; } 
        public IRPSTextBox<CustomerContactView> Fax { get; set; } 
        public IRPSTextBox<CustomerContactView> Email { get; set; } 
        public IRPSComboBox<CustomerContactView> CodUser { get; set; } 
        public IRPSTextBox<CustomerContactView> InactiveDate { get; set; } 
        public IRPSCheckbox<CustomerContactView> Commercial { get; set; } 
        public IRPSCheckbox<CustomerContactView> DefaultCommercial { get; set; } 
        public IRPSCheckbox<CustomerContactView> DefaultAdministration { get; set; } 
        public IRPSCheckbox<CustomerContactView> DefaultFinancial { get; set; } 
        public IRPSCheckbox<CustomerContactView> Technical { get; set; } 
        public IRPSTextBox<CustomerContactView> FirstName { get; set; } 
        public IRPSTextBox<CustomerContactView> LastName { get; set; } 
        public IRPSComboBox<CustomerContactView> Gender { get; set; } 
        public IRPSTextBox<CustomerContactView> Title { get; set; } 
        public IRPSCheckbox<CustomerContactView> Newsletter { get; set; } 
        public IRPSTextBox<CustomerContactView> Position { get; set; } 
        public IRPSTextBox<CustomerContactView> Mobile { get; set; } 
        public IRPSTextBox<CustomerContactView> SkypeName { get; set; } 
        public IRPSTextBox<CustomerContactView> DateOfBirth { get; set; } 
        public IRPSComboBox<CustomerContactView> CodLanguage { get; set; } 
        public IRPSTextBox<CustomerContactView> Department { get; set; } 
        public IRPSTextBox<CustomerContactView> InactiveDate1 { get; set; } 
        public IRPSTextBox<CustomerContactView> Location { get; set; } 
        public IRPSTextBox<CustomerContactView> Comment { get; set; } 
        public IRPSSection<CustomerContactView> GenaralDataSection { get; set; } 
        public IRPSSection<CustomerContactView> CommentSection { get; set; } 
        public Customer Screen { get; set; }
        public CustomerContactView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CustomerPaymentAddressView : View
    {
        public CustomerPaymentAddressView(Customer screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CustomerPaymentAddressView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CustomerPaymentAddressView,CustomerEntityView>( this,Screen.CustomerEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<CustomerPaymentAddressView,CustomerEntityView>( this,Screen.CustomerEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CustomerPaymentAddressView,CustomerEntityView>( this,Screen.CustomerEntityView);
 
            CodCustomerPaymentAddress = RPSControlFactory.CreateRPSTextBox<CustomerPaymentAddressView>("ac772426-66b5-43e3-b846-1dfb7587cb18","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CustomerPaymentAddressView>("ad50284b-409d-445b-ae10-82cecb671ddd","","",false, this);
 
            DefaultAddress = RPSControlFactory.CreateRPSCheckBox<CustomerPaymentAddressView>("2b05104e-31c3-4647-b30a-38e278182d06","","",true, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<CustomerPaymentAddressView>("116cdcc1-ddeb-4974-bb83-292db560fd7c","","",false, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<CustomerPaymentAddressView>("e1ae50d2-06a3-41ef-b024-647194d66777","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<CustomerPaymentAddressView>("a1082d0d-0974-437e-864b-ec0b07f2b15c","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<CustomerPaymentAddressView>("a5757f5d-4205-4da9-8213-a2621f4e315d","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<CustomerPaymentAddressView>("156b8867-b848-4356-9aaa-8e77945e6f05","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<CustomerPaymentAddressView>("c3ef3c94-373a-4b62-a398-12687533150e","","",false, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<CustomerPaymentAddressView>("d1578683-4add-4785-8461-c300b27d94e6","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<CustomerPaymentAddressView>("b7835658-4506-462f-9d91-0af27a1ada24","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<CustomerPaymentAddressView>("728397e6-40a6-4603-afee-9b89a8dd0de9","","",false, this);
 
            Email = RPSControlFactory.CreateRPSEmailTextBox<CustomerPaymentAddressView>("e191dc8b-5cb0-4c01-9759-95e010624127","","",false, this);
 
            IDCustomerContact = RPSControlFactory.CreateRPSComboBox<CustomerPaymentAddressView>("e04e2298-e68e-4756-801b-d49a5acb4d87","","",false, this);
 
            ContactPerson = RPSControlFactory.CreateRPSTextBox<CustomerPaymentAddressView>("64b6140b-1c77-40e1-8f5e-59240b73857f","","",false, this);
 
            IDCustomerPayer = RPSControlFactory.CreateRPSComboBox<CustomerPaymentAddressView>("00cf3bcf-912f-4c08-80d5-c5c4616085e6","","",false, this);
 
            UseDataCustomerPayer = RPSControlFactory.CreateRPSCheckBox<CustomerPaymentAddressView>("12ad74fc-dc00-4e91-a07d-db099b5ef950","","",true, this);
 
            AccountingOffice = RPSControlFactory.CreateRPSTextBox<CustomerPaymentAddressView>("891dae43-88a8-4735-af42-af02e65e5952","","",false, this);
 
            ManagerEntity = RPSControlFactory.CreateRPSTextBox<CustomerPaymentAddressView>("5302f5b0-b16b-4939-b097-eb3536087728","","",false, this);
 
            UnitProcess = RPSControlFactory.CreateRPSTextBox<CustomerPaymentAddressView>("ae72e49f-9cfb-4b70-8abc-b2ab1cb07514","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<CustomerPaymentAddressView>("ac69b7ca-7e3f-4cc1-b0ee-99df72640626","","",false, this);
 
            GeneralData = RPSControlFactory.CreateRPSSection<CustomerPaymentAddressView>( "","ul li[rpsid='1ca06d46-7242-455f-9926-181ed83a5b49']","",this);
 
            Comment1 = RPSControlFactory.CreateRPSSection<CustomerPaymentAddressView>( "","ul li[rpsid='51238897-d19b-4857-9118-697e9c37ddfc']","",this);
 

        }
        public IRPSButton<CustomerPaymentAddressView> DeleteButton { get; set; } 
        public IRPSButton<CustomerPaymentAddressView,CustomerEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerPaymentAddressView,CustomerEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CustomerPaymentAddressView,CustomerEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<CustomerPaymentAddressView> CodCustomerPaymentAddress { get; set; } 
        public IRPSTextBox<CustomerPaymentAddressView> Description { get; set; } 
        public IRPSCheckbox<CustomerPaymentAddressView> DefaultAddress { get; set; } 
        public IRPSComboBox<CustomerPaymentAddressView> CodCountry { get; set; } 
        public IRPSTextBox<CustomerPaymentAddressView> ZipCode { get; set; } 
        public IRPSComboBox<CustomerPaymentAddressView> IDState { get; set; } 
        public IRPSComboBox<CustomerPaymentAddressView> IDCounty { get; set; } 
        public IRPSTextBox<CustomerPaymentAddressView> Address { get; set; } 
        public IRPSTextBox<CustomerPaymentAddressView> City { get; set; } 
        public IRPSTextBox<CustomerPaymentAddressView> Phone1 { get; set; } 
        public IRPSTextBox<CustomerPaymentAddressView> Phone2 { get; set; } 
        public IRPSTextBox<CustomerPaymentAddressView> Fax { get; set; } 
        public IRPSTextBox<CustomerPaymentAddressView> Email { get; set; } 
        public IRPSComboBox<CustomerPaymentAddressView> IDCustomerContact { get; set; } 
        public IRPSTextBox<CustomerPaymentAddressView> ContactPerson { get; set; } 
        public IRPSComboBox<CustomerPaymentAddressView> IDCustomerPayer { get; set; } 
        public IRPSCheckbox<CustomerPaymentAddressView> UseDataCustomerPayer { get; set; } 
        public IRPSTextBox<CustomerPaymentAddressView> AccountingOffice { get; set; } 
        public IRPSTextBox<CustomerPaymentAddressView> ManagerEntity { get; set; } 
        public IRPSTextBox<CustomerPaymentAddressView> UnitProcess { get; set; } 
        public IRPSTextBox<CustomerPaymentAddressView> Comment { get; set; } 
        public IRPSSection<CustomerPaymentAddressView> GeneralData { get; set; } 
        public IRPSSection<CustomerPaymentAddressView> Comment1 { get; set; } 
        public Customer Screen { get; set; }
        public CustomerPaymentAddressView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CustomerBankAccountView : View
    {
        public CustomerBankAccountView(Customer screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CustomerBankAccountView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CustomerBankAccountView,CustomerEntityView>( this,Screen.CustomerEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<CustomerBankAccountView,CustomerEntityView>( this,Screen.CustomerEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CustomerBankAccountView,CustomerEntityView>( this,Screen.CustomerEntityView);
 
            CodCustomerBankAccount = RPSControlFactory.CreateRPSTextBox<CustomerBankAccountView>("e8073af0-e2aa-4a53-9680-77589bd3fb4b","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CustomerBankAccountView>("818cd55a-9e6b-47e9-9718-789f7e253629","","",false, this);
 
            Default = RPSControlFactory.CreateRPSCheckBox<CustomerBankAccountView>("55d01769-1da8-4367-91ce-2e572e58ed39","","",true, this);
 
            CodBank = RPSControlFactory.CreateRPSComboBox<CustomerBankAccountView>("4f2033a5-5887-4cde-b43d-212721f962bb","","",false, this);
 
            CodBankBranch = RPSControlFactory.CreateRPSEnumComboBox<CustomerBankAccountView>("3ed3e817-dabd-4434-98a0-3059b4f3d53d","","",false, this);
 
            DigitControl = RPSControlFactory.CreateRPSTextBox<CustomerBankAccountView>("1c8d7f3f-f1d6-461f-bc77-c35fedcf182f","","",false, this);
 
            BankAccount = RPSControlFactory.CreateRPSTextBox<CustomerBankAccountView>("d7474d72-546f-4c7b-9107-84215b64b4f1","","",false, this);
 
            BankAccNumber = RPSControlFactory.CreateRPSTextBox<CustomerBankAccountView>("0ad1a882-daf7-4260-9e1b-cc464ecc0c60","","",false, this);
 
            IBAN = RPSControlFactory.CreateRPSTextBox<CustomerBankAccountView>("5a139549-72ff-4332-9066-aaf2f4ddd13a","","",false, this);
 
            TypeBankAcc = RPSControlFactory.CreateRPSEnumComboBox<CustomerBankAccountView>("5cd1ffdc-2f26-4804-8f01-ce64a49681d9","","",true, this);
 
            SWIFTCode = RPSControlFactory.CreateRPSTextBox<CustomerBankAccountView>("bc34c5d2-d75a-4187-a542-c89a316ae5d0","","",false, this);
 

        }
        public IRPSButton<CustomerBankAccountView> DeleteButton { get; set; } 
        public IRPSButton<CustomerBankAccountView,CustomerEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerBankAccountView,CustomerEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CustomerBankAccountView,CustomerEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<CustomerBankAccountView> CodCustomerBankAccount { get; set; } 
        public IRPSTextBox<CustomerBankAccountView> Description { get; set; } 
        public IRPSCheckbox<CustomerBankAccountView> Default { get; set; } 
        public IRPSComboBox<CustomerBankAccountView> CodBank { get; set; } 
        public IRPSComboBox<CustomerBankAccountView> CodBankBranch { get; set; } 
        public IRPSTextBox<CustomerBankAccountView> DigitControl { get; set; } 
        public IRPSTextBox<CustomerBankAccountView> BankAccount { get; set; } 
        public IRPSTextBox<CustomerBankAccountView> BankAccNumber { get; set; } 
        public IRPSTextBox<CustomerBankAccountView> IBAN { get; set; } 
        public IRPSComboBox<CustomerBankAccountView> TypeBankAcc { get; set; } 
        public IRPSTextBox<CustomerBankAccountView> SWIFTCode { get; set; } 
        public Customer Screen { get; set; }
        public CustomerBankAccountView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CustomerReportView : View
    {
        public CustomerReportView(Customer screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CustomerReportView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CustomerReportView,CustomerEntityView>( this,Screen.CustomerEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<CustomerReportView,CustomerEntityView>( this,Screen.CustomerEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CustomerReportView,CustomerEntityView>( this,Screen.CustomerEntityView);
 
            FormatType = RPSControlFactory.CreateRPSEnumComboBox<CustomerReportView>("39d7c0b8-376c-4a03-92d3-e1c97748afd9","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CustomerReportView>("3afdfb44-e96a-44e2-aa8c-1b9793ef6042","","",false, this);
 
            IDCustomReport = RPSControlFactory.CreateRPSComboBox<CustomerReportView>("a6f18b10-b102-4134-9778-6d4762806edd","","",false, this);
 
            DefaultReport = RPSControlFactory.CreateRPSCheckBox<CustomerReportView>("7181591a-07b4-4160-8743-62c6c0d7b409","","",true, this);
 

        }
        public IRPSButton<CustomerReportView> DeleteButton { get; set; } 
        public IRPSButton<CustomerReportView,CustomerEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerReportView,CustomerEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CustomerReportView,CustomerEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<CustomerReportView> FormatType { get; set; } 
        public IRPSTextBox<CustomerReportView> Description { get; set; } 
        public IRPSComboBox<CustomerReportView> IDCustomReport { get; set; } 
        public IRPSCheckbox<CustomerReportView> DefaultReport { get; set; } 
        public Customer Screen { get; set; }
        public CustomerReportView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CustomerDetailView : View
    {
        public CustomerDetailView(Customer screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CustomerDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CustomerDetailView,CustomerEntityView>( this,Screen.CustomerEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<CustomerDetailView,CustomerEntityView>( this,Screen.CustomerEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CustomerDetailView,CustomerEntityView>( this,Screen.CustomerEntityView);
 
            CodCompany = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("f988f01b-77ce-40d3-a1cf-87bc6a4bf3ba","","",true, this);
 
            IDBusinessUnit = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("cd6fb04b-3219-442a-83b9-377eca46e418","","",false, this);
 
            IDZone = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("adce550f-e9b2-4f2c-8b19-c041e00874f0","","",false, this);
 
            DeliveryDays = RPSControlFactory.CreateRPSFormattedTextBox<CustomerDetailView>("d91c73bc-2935-401c-b236-4497fd42e739","","",true, this);
 
            Blocked = RPSControlFactory.CreateRPSCheckBox<CustomerDetailView>("8c8205ad-4bf2-454b-be56-d570bdfac5d2","","",true, this);
 
            BlockedCRM = RPSControlFactory.CreateRPSCheckBox<CustomerDetailView>("a317efeb-6a61-493e-9728-539aa7a61de4","","",true, this);
 
            BlockedMaintenance = RPSControlFactory.CreateRPSCheckBox<CustomerDetailView>("1cb94916-ca80-497b-a078-036e3f6fb3af","","",true, this);
 
            RiskLimit = RPSControlFactory.CreateRPSFormattedTextBox<CustomerDetailView>("7901b2a2-c1c7-40da-8221-e4cd010e787e","","",true, this);
 
            OrderRisk = RPSControlFactory.CreateRPSFormattedTextBox<CustomerDetailView>("1b579214-6d6b-4a3e-a39d-1634c9cf4622","","",true, this);
 
            UnPaidRisk = RPSControlFactory.CreateRPSFormattedTextBox<CustomerDetailView>("5c7e93b3-adcf-406d-878c-ab173e835728","","",true, this);
 
            ReceivableRisk = RPSControlFactory.CreateRPSFormattedTextBox<CustomerDetailView>("8e91a24f-6928-49c5-b15c-f9a0414dac23","","",true, this);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("a15f0eee-072e-4cc1-bbb5-68e672a66c8b","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("59584175-6447-4050-8d5a-36797b7d3e2b","","",true, this);
 
            Revaluation = RPSControlFactory.CreateRPSCheckBox<CustomerDetailView>("c0de9426-1178-4879-a79b-507d05d83278","","",true, this);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("bc4996fa-8796-49a6-a2fe-956e7ad7f73b","","",false, this);
 
            IDInvoicingType = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("0e1de514-35ec-46b8-b93b-ba8912064a81","","",false, this);
 
            IDBankAccountCompany = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("c055ca15-ffc1-4d8d-bc1d-e13b9bc47388","","",false, this);
 
            IDCashCollector = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("0ff1ee63-692a-4d46-9618-f61bdb084780","","",false, this);
 
            IDThirdAccType = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("2b2432f0-cc90-4f1c-88a7-03b345a55370","","",false, this);
 
            IDVoucherType = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("66ff1b0b-6065-4ddd-a52e-6e5ccf14130a","","",false, this);
 
            IDVATType = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("d12f2ded-0946-4c1d-85c9-2448a568fa8f","","",true, this);
 
            IDSurchargeVATType = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("4acc30cf-f883-45e1-95fd-d549f8eeb2f4","","",false, this);
 
            IDTaxGroup = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("f5fdc294-4459-4c86-986b-edf5d627276f","","",false, this);
 
            IDPaymentMethodRappel = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("663c61a1-00a3-4709-9a19-2a31c96840c0","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("1de30f99-dffb-4f94-9c59-dec57fab4655","","",false, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("d0eaf53b-a33c-4e0f-9b8b-120e9dce3d44","","",false, this);
 
            IDShippingAgent = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("2a914536-e143-4174-b068-58b1d8cba65f","","",false, this);
 
            SalesQuoteEffectiveDays = RPSControlFactory.CreateRPSFormattedTextBox<CustomerDetailView>("50270c67-02f4-40a1-b3cc-9eb1e041b163","","",true, this);
 
            IDPriceList = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("60993000-67ce-4430-b83b-150648cc4213","","",false, this);
 
            IDDiscountGroup = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("3b3fbccc-98c6-4b0d-a27e-ab59ab43ecbd","","",false, this);
 
            IDCommercialConditionGroup = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("fef57ebe-ecfb-4bbf-9c75-8bb08646a3f8","","",false, this);
 
            IDCustomerCommissionGroup = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("878000e2-94d8-4249-bb97-3e561067b071","","",false, this);
 
            IDCodingSerieSalesQuote = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("f7670791-686b-43f3-8e88-f604d7cdb0d1","","",false, this);
 
            IDCodingSerieOrder = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("0e94d0a0-74b6-459a-b97e-12c4e925dd48","","",false, this);
 
            IDCodingSerieDeliveryNote = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("33f91a93-a536-4bbb-a171-468fec213e2c","","",false, this);
 
            IDCodingSerieInvoice = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("19a84b4d-6ad3-4489-afbf-57fdc59fde74","","",false, this);
 
            IDCodingSerieCreditInvoice = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("be9d2d8a-cb10-43dd-b9b0-5cbd2e989854","","",false, this);
 
            IDCodingSerieDebitNote = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("b875a37b-5ea0-4102-8520-05d9af27a0ee","","",false, this);
 
            IDCodingSerieDeliveryNoteB = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("186eb99a-c948-4ccb-8ebd-a1d9a4a557d1","","",false, this);
 
            IDCodingSerieInvoiceB = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("c706d3ae-0da1-4987-8189-caff7dc9462d","","",false, this);
 
            IDCodingSerieCreditInvoiceB = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("04d20868-ffda-41a4-b742-d4b2e84ce42a","","",false, this);
 
            IDCodingSerieDebitNoteB = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("8767b480-7b04-4275-be19-8d5608c11f62","","",false, this);
 
            IDCodingSerieAdvanceInvoice = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("1bebfd3d-8d51-4610-a431-6c1cf3caccf7","","",false, this);
 
            IDCodingSerieAdvanceInvoiceB = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("2a658f77-96b4-4cc7-a85d-44798d7e3f28","","",false, this);
 
            IDTextLineOfferPre = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("793bb232-c69c-4e3a-aa13-21fbf48dcb96","","",false, this);
 
            IDTextLineFContractPre = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("15dd6535-1877-45c7-9c24-dc2296e32566","","",false, this);
 
            IDTextLineOrderPre = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("fa24f637-cbf5-4a8a-b7e5-55c34df8d7e2","","",false, this);
 
            IDTextLineDNotePre = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("88b1881c-9ca3-4c8b-a657-5f576b7a246c","","",false, this);
 
            IDTextLineInvoicePre = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("11dbf6b7-9367-468c-9676-9512d842b0be","","",false, this);
 
            IDTextLineAdvancePre = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("0130e16d-f34c-4342-baf0-c235420c8abd","","",false, this);
 
            IDTextLineOfferPost = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("f3882b6e-cc57-4e52-9981-573ebda90e12","","",false, this);
 
            IDTextLineFContractPost = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("30d2cb6b-a084-42cf-943c-1474cae68148","","",false, this);
 
            IDTextLineOrderPost = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("fd6f5fc5-8a78-4c80-bad0-25268e6bfff6","","",false, this);
 
            IDTextLineDNotePost = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("38364fa3-9e08-4988-857b-4486c1ce8062","","",false, this);
 
            IDTextLineInvoicePost = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("9f56d783-b9cc-485d-abad-01c63cdadbfc","","",false, this);
 
            IDTextLineAdvancePost = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("d0deaacb-41e1-4623-aad2-faef03325d3b","","",false, this);
 

        }
        public IRPSButton<CustomerDetailView> DeleteButton { get; set; } 
        public IRPSButton<CustomerDetailView,CustomerEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerDetailView,CustomerEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CustomerDetailView,CustomerEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<CustomerDetailView> CodCompany { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDBusinessUnit { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDZone { get; set; } 
        public IRPSTextBox<CustomerDetailView> DeliveryDays { get; set; } 
        public IRPSCheckbox<CustomerDetailView> Blocked { get; set; } 
        public IRPSCheckbox<CustomerDetailView> BlockedCRM { get; set; } 
        public IRPSCheckbox<CustomerDetailView> BlockedMaintenance { get; set; } 
        public IRPSTextBox<CustomerDetailView> RiskLimit { get; set; } 
        public IRPSTextBox<CustomerDetailView> OrderRisk { get; set; } 
        public IRPSTextBox<CustomerDetailView> UnPaidRisk { get; set; } 
        public IRPSTextBox<CustomerDetailView> ReceivableRisk { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDPaymentMethod { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDCurrency { get; set; } 
        public IRPSCheckbox<CustomerDetailView> Revaluation { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDDeliveryNoteType { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDInvoicingType { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDBankAccountCompany { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDCashCollector { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDThirdAccType { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDVoucherType { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDVATType { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDSurchargeVATType { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDTaxGroup { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDPaymentMethodRappel { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDSite { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDWarehouse { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDShippingAgent { get; set; } 
        public IRPSTextBox<CustomerDetailView> SalesQuoteEffectiveDays { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDPriceList { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDDiscountGroup { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDCommercialConditionGroup { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDCustomerCommissionGroup { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDCodingSerieSalesQuote { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDCodingSerieOrder { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDCodingSerieDeliveryNote { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDCodingSerieInvoice { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDCodingSerieCreditInvoice { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDCodingSerieDebitNote { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDCodingSerieDeliveryNoteB { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDCodingSerieInvoiceB { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDCodingSerieCreditInvoiceB { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDCodingSerieDebitNoteB { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDCodingSerieAdvanceInvoice { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDCodingSerieAdvanceInvoiceB { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDTextLineOfferPre { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDTextLineFContractPre { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDTextLineOrderPre { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDTextLineDNotePre { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDTextLineInvoicePre { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDTextLineAdvancePre { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDTextLineOfferPost { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDTextLineFContractPost { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDTextLineOrderPost { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDTextLineDNotePost { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDTextLineInvoicePost { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDTextLineAdvancePost { get; set; } 
        public Customer Screen { get; set; }
        public CustomerDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CustomerCommercialAgentView : View
    {
        public CustomerCommercialAgentView(Customer screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CustomerCommercialAgentView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CustomerCommercialAgentView,CustomerEntityView>( this,Screen.CustomerEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<CustomerCommercialAgentView,CustomerEntityView>( this,Screen.CustomerEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CustomerCommercialAgentView,CustomerEntityView>( this,Screen.CustomerEntityView);
 
            IDCommercialAgent = RPSControlFactory.CreateRPSComboBox<CustomerCommercialAgentView>("772a4e93-ff4e-4162-8784-488630caa110","","",true, this);
 
            IDCommercialAgentClassification = RPSControlFactory.CreateRPSComboBox<CustomerCommercialAgentView>("87cd09c6-2a7c-426d-98d2-4ed8c95b9c6b","","",true, this);
 
            InactiveDate = RPSControlFactory.CreateRPSTextBox<CustomerCommercialAgentView>("f546ea65-9c49-439a-bb54-8e81c1b90c76","","",false, this);
 

        }
        public IRPSButton<CustomerCommercialAgentView> DeleteButton { get; set; } 
        public IRPSButton<CustomerCommercialAgentView,CustomerEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerCommercialAgentView,CustomerEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CustomerCommercialAgentView,CustomerEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<CustomerCommercialAgentView> IDCommercialAgent { get; set; } 
        public IRPSComboBox<CustomerCommercialAgentView> IDCommercialAgentClassification { get; set; } 
        public IRPSTextBox<CustomerCommercialAgentView> InactiveDate { get; set; } 
        public Customer Screen { get; set; }
        public CustomerCommercialAgentView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NewCustomerFromCopyChildDialogView : View
    {
        public NewCustomerFromCopyChildDialogView(Customer screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewCode = RPSControlFactory.CreateRPSTextBox<NewCustomerFromCopyChildDialogView>("470ed902-7bfc-446a-9a76-fb933370a76b","","",false, this);
 
            UINewCustomerVATNumber = RPSControlFactory.CreateRPSTextBox<NewCustomerFromCopyChildDialogView>("86fd657b-4eba-469a-8dfe-d43959f14269","","",false, this);
 
            UINewCustomerDescription = RPSControlFactory.CreateRPSTextBox<NewCustomerFromCopyChildDialogView>("46cbfdc5-e28e-462e-927c-df8863569c1e","","",false, this);
 
            UINewCustomerBusinessName = RPSControlFactory.CreateRPSTextBox<NewCustomerFromCopyChildDialogView>("53f8bb27-7c65-49af-b696-49547da286f5","","",false, this);
 
            bDcouments = RPSControlFactory.CreateRPSCheckBox<NewCustomerFromCopyChildDialogView>("eb42985f-f5b1-447c-9d62-59a5d7cee5d1","","",false, this);
 
            bComercialAgents = RPSControlFactory.CreateRPSCheckBox<NewCustomerFromCopyChildDialogView>("81cbe761-fc5c-4b98-8ed2-9f8aba08019f","","",false, this);
 
            bPaymentAddress = RPSControlFactory.CreateRPSCheckBox<NewCustomerFromCopyChildDialogView>("eda323c7-242b-48d7-8098-99f8a8e645db","","",false, this);
 
            bContacts = RPSControlFactory.CreateRPSCheckBox<NewCustomerFromCopyChildDialogView>("1d7f3967-9c91-4034-ad6e-6eaf2b51ee94","","",false, this);
 
            bDirectBankDebit = RPSControlFactory.CreateRPSCheckBox<NewCustomerFromCopyChildDialogView>("a35cba94-3408-4f7f-b41b-f287caecd05c","","",false, this);
 
            bDeliveryAddress = RPSControlFactory.CreateRPSCheckBox<NewCustomerFromCopyChildDialogView>("5654a65f-636d-48ce-8671-939f0c137673","","",false, this);
 
            bReports = RPSControlFactory.CreateRPSCheckBox<NewCustomerFromCopyChildDialogView>("0ec45832-ef54-4714-a419-b2e0f46a80da","","",false, this);
 

        }
        public IRPSTextBox<NewCustomerFromCopyChildDialogView> NewCode { get; set; } 
        public IRPSTextBox<NewCustomerFromCopyChildDialogView> UINewCustomerVATNumber { get; set; } 
        public IRPSTextBox<NewCustomerFromCopyChildDialogView> UINewCustomerDescription { get; set; } 
        public IRPSTextBox<NewCustomerFromCopyChildDialogView> UINewCustomerBusinessName { get; set; } 
        public IRPSCheckbox<NewCustomerFromCopyChildDialogView> bDcouments { get; set; } 
        public IRPSCheckbox<NewCustomerFromCopyChildDialogView> bComercialAgents { get; set; } 
        public IRPSCheckbox<NewCustomerFromCopyChildDialogView> bPaymentAddress { get; set; } 
        public IRPSCheckbox<NewCustomerFromCopyChildDialogView> bContacts { get; set; } 
        public IRPSCheckbox<NewCustomerFromCopyChildDialogView> bDirectBankDebit { get; set; } 
        public IRPSCheckbox<NewCustomerFromCopyChildDialogView> bDeliveryAddress { get; set; } 
        public IRPSCheckbox<NewCustomerFromCopyChildDialogView> bReports { get; set; } 
        public Customer Screen { get; set; }
        public NewCustomerFromCopyChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}