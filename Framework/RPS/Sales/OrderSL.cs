    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.OrderSL
{
    //RPS VERSION 1.0.0.0
    public partial class OrderSL:Screen
    {
        public OrderSL():base()
        {
            this.URL = "sales.ordersl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            OrderSLCollectionView  = new OrderSLCollectionView(this); 
            OrderSLEntityView  = new OrderSLEntityView(this); 
            OrderLineSLView  = new OrderLineSLView(this); 
            OrderAdvanceSLView  = new OrderAdvanceSLView(this); 
            OrderVariablePaymentSLView  = new OrderVariablePaymentSLView(this); 
            OrderMilestoneSLView  = new OrderMilestoneSLView(this); 
            OrderComAgentSLView  = new OrderComAgentSLView(this); 
            OrderAdvanceTaxSLView  = new OrderAdvanceTaxSLView(this); 
            OrderLineTaxSLView  = new OrderLineTaxSLView(this); 
            OrderLineAnalyticSLView  = new OrderLineAnalyticSLView(this); 
            OrderChangesChildDialogView  = new OrderChangesChildDialogView(this); 
            ArticleGenericChildDialogView  = new ArticleGenericChildDialogView(this); 
            PrintOrderChildDialogView  = new PrintOrderChildDialogView(this); 
            NewOrderChildDialogView  = new NewOrderChildDialogView(this); 
            OrderRestDialogView  = new OrderRestDialogView(this); 
            ArticleAlternativeChildDialogView  = new ArticleAlternativeChildDialogView(this); 
            OrderLineCommercialAgentSLView  = new OrderLineCommercialAgentSLView(this); 
            OrderLineProposalSLView  = new OrderLineProposalSLView(this); 
            GenerateDeliveryNoteChildDialogView  = new GenerateDeliveryNoteChildDialogView(this); 
            OrderComAgentNewChildDialogView  = new OrderComAgentNewChildDialogView(this); 
            ChangeOrderCustomerChildDialogView  = new ChangeOrderCustomerChildDialogView(this); 
            OrderAdvanceSLChildDialogView  = new OrderAdvanceSLChildDialogView(this); 
            DueDateCalculationDialogView  = new DueDateCalculationDialogView(this); 
            RelatedFWCManagementChildDialogView  = new RelatedFWCManagementChildDialogView(this); 
            ModifyOrderSituationSLDialogView  = new ModifyOrderSituationSLDialogView(this); 
            OrderIncidenceSLView  = new OrderIncidenceSLView(this); 
            OrderSLToRoadMapChildDialogView  = new OrderSLToRoadMapChildDialogView(this); 
            AnalyticChildDialogView  = new AnalyticChildDialogView(this); 
            ReserveChildDialogView  = new ReserveChildDialogView(this); 
            OrderSLCollectionView.InitializeControls(); 
            OrderSLEntityView.InitializeControls(); 
            OrderLineSLView.InitializeControls(); 
            OrderAdvanceSLView.InitializeControls(); 
            OrderVariablePaymentSLView.InitializeControls(); 
            OrderMilestoneSLView.InitializeControls(); 
            OrderComAgentSLView.InitializeControls(); 
            OrderAdvanceTaxSLView.InitializeControls(); 
            OrderLineTaxSLView.InitializeControls(); 
            OrderLineAnalyticSLView.InitializeControls(); 
            OrderChangesChildDialogView.InitializeControls(); 
            ArticleGenericChildDialogView.InitializeControls(); 
            PrintOrderChildDialogView.InitializeControls(); 
            NewOrderChildDialogView.InitializeControls(); 
            OrderRestDialogView.InitializeControls(); 
            ArticleAlternativeChildDialogView.InitializeControls(); 
            OrderLineCommercialAgentSLView.InitializeControls(); 
            OrderLineProposalSLView.InitializeControls(); 
            GenerateDeliveryNoteChildDialogView.InitializeControls(); 
            OrderComAgentNewChildDialogView.InitializeControls(); 
            ChangeOrderCustomerChildDialogView.InitializeControls(); 
            OrderAdvanceSLChildDialogView.InitializeControls(); 
            DueDateCalculationDialogView.InitializeControls(); 
            RelatedFWCManagementChildDialogView.InitializeControls(); 
            ModifyOrderSituationSLDialogView.InitializeControls(); 
            OrderIncidenceSLView.InitializeControls(); 
            OrderSLToRoadMapChildDialogView.InitializeControls(); 
            AnalyticChildDialogView.InitializeControls(); 
            ReserveChildDialogView.InitializeControls(); 
           
        }
      
            public OrderSLCollectionView OrderSLCollectionView {get; set; } 
            public OrderSLEntityView OrderSLEntityView {get; set; } 
            public OrderLineSLView OrderLineSLView {get; set; } 
            public OrderAdvanceSLView OrderAdvanceSLView {get; set; } 
            public OrderVariablePaymentSLView OrderVariablePaymentSLView {get; set; } 
            public OrderMilestoneSLView OrderMilestoneSLView {get; set; } 
            public OrderComAgentSLView OrderComAgentSLView {get; set; } 
            public OrderAdvanceTaxSLView OrderAdvanceTaxSLView {get; set; } 
            public OrderLineTaxSLView OrderLineTaxSLView {get; set; } 
            public OrderLineAnalyticSLView OrderLineAnalyticSLView {get; set; } 
            public OrderChangesChildDialogView OrderChangesChildDialogView {get; set; } 
            public ArticleGenericChildDialogView ArticleGenericChildDialogView {get; set; } 
            public PrintOrderChildDialogView PrintOrderChildDialogView {get; set; } 
            public NewOrderChildDialogView NewOrderChildDialogView {get; set; } 
            public OrderRestDialogView OrderRestDialogView {get; set; } 
            public ArticleAlternativeChildDialogView ArticleAlternativeChildDialogView {get; set; } 
            public OrderLineCommercialAgentSLView OrderLineCommercialAgentSLView {get; set; } 
            public OrderLineProposalSLView OrderLineProposalSLView {get; set; } 
            public GenerateDeliveryNoteChildDialogView GenerateDeliveryNoteChildDialogView {get; set; } 
            public OrderComAgentNewChildDialogView OrderComAgentNewChildDialogView {get; set; } 
            public ChangeOrderCustomerChildDialogView ChangeOrderCustomerChildDialogView {get; set; } 
            public OrderAdvanceSLChildDialogView OrderAdvanceSLChildDialogView {get; set; } 
            public DueDateCalculationDialogView DueDateCalculationDialogView {get; set; } 
            public RelatedFWCManagementChildDialogView RelatedFWCManagementChildDialogView {get; set; } 
            public ModifyOrderSituationSLDialogView ModifyOrderSituationSLDialogView {get; set; } 
            public OrderIncidenceSLView OrderIncidenceSLView {get; set; } 
            public OrderSLToRoadMapChildDialogView OrderSLToRoadMapChildDialogView {get; set; } 
            public AnalyticChildDialogView AnalyticChildDialogView {get; set; } 
            public ReserveChildDialogView ReserveChildDialogView {get; set; } 
    }
            
    public partial class OrderSLCollectionView : View
    {
        public OrderSLCollectionView(OrderSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<OrderSLCollectionView,OrderSLEntityView>( this,Screen.OrderSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "7c46ef09-6f15-4d04-83ce-9f2bcc9f9d4e",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<OrderSLCollectionView,OrderSLEntityView>( params_MainConsult,this,Screen.OrderSLEntityView);
 

        }
        public IRPSButton<OrderSLCollectionView,OrderSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<OrderSLCollectionView,OrderSLEntityView> MainConsult { get; set; } 
        public OrderSL Screen { get; set; }
        public OrderSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OrderSLEntityView : View
    {
        public OrderSLEntityView(OrderSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<OrderSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<OrderSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<OrderSLEntityView,OrderSLCollectionView>( this,Screen.OrderSLCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<OrderSLEntityView,OrderSLCollectionView>( this,Screen.OrderSLCollectionView);
 
            TotalLinesAmount = RPSControlFactory.CreateRPSFormattedTextBox<OrderSLEntityView>("b05070df-4ce0-4005-95b2-5a5dae146ccb","","",false, this);
 
            TotalBase = RPSControlFactory.CreateRPSFormattedTextBox<OrderSLEntityView>("61b97f66-835a-41ee-bd85-676d49216284","","",false, this);
 
            TotalVAT = RPSControlFactory.CreateRPSFormattedTextBox<OrderSLEntityView>("fe733642-9aeb-48d4-b699-97e049ebeab7","","",false, this);
 
            TotalTax = RPSControlFactory.CreateRPSFormattedTextBox<OrderSLEntityView>("8441c964-0c2c-42fd-8b2e-eb34aa144d04","","",false, this);
 
            TotalOrder = RPSControlFactory.CreateRPSFormattedTextBox<OrderSLEntityView>("576ac0f8-01d5-44ff-a22f-d843fe689dde","","",false, this);
 
            UITotalCost = RPSControlFactory.CreateRPSFormattedTextBox<OrderSLEntityView>("4b427411-27d4-4aa6-bc71-09f1d3235839","","",false, this);
 
            UIMargin = RPSControlFactory.CreateRPSFormattedTextBox<OrderSLEntityView>("5c9a90f6-7c6c-4971-b7dd-6403bc26df63","","",false, this);
 
            UITotalAdvances = RPSControlFactory.CreateRPSFormattedTextBox<OrderSLEntityView>("ded4f14a-76a7-45ad-8040-ba2162642ad7","","",false, this);
 
            Transport = RPSControlFactory.CreateRPSFormattedTextBox<OrderSLEntityView>("087be670-9e61-4efe-afdd-69a04246565c","","",true, this);
 
            UICustomerRisk = RPSControlFactory.CreateRPSFormattedTextBox<OrderSLEntityView>("65ebeff1-9f91-4102-8465-1eacb003f19e","","",false, this);
 
            InsertCustomerArticleCommandButton = RPSControlFactory.CreateRPSButton<OrderSLEntityView>( "6abd0ab1-9545-4bf7-985a-1b4e9a07a765","","",this);
 
            CreateManufacturingOrderfromSalesCommandButton = RPSControlFactory.CreateRPSButton<OrderSLEntityView>( "1360286b-9573-42af-8d74-363206458054","","",this);
 
            OrderChangesChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<OrderSLEntityView,OrderChangesChildDialogView>("4a08f591-aa15-45e1-9b47-ee9a190fc93a","","", this,Screen.OrderChangesChildDialogView);
 
            CodOrder = RPSControlFactory.CreateRPSTextBox<OrderSLEntityView>("5c9c23e4-47b8-4b2e-a479-11bfd5bdfd22","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<OrderSLEntityView>("bbe4b30e-b518-4451-9784-60b8d89e2e76","","",true, this);
 
            IDCustomerMiscellaneous = RPSControlFactory.CreateRPSComboBox<OrderSLEntityView>("751a6399-14a2-49e4-8cd2-531cb881498c","","",false, this);
 
            IDCustomerContact = RPSControlFactory.CreateRPSComboBox<OrderSLEntityView>("0454bd00-2417-472a-94fb-6b7802e7de7b","","",false, this);
 
            NewOrderRest = RPSControlFactory.CreateRPSCheckBox<OrderSLEntityView>("7ff6b9f9-1476-4e40-abe9-325ddd08841c","","",true, this);
 
            OrderPriority = RPSControlFactory.CreateRPSFormattedTextBox<OrderSLEntityView>("094a4f71-84d2-4885-b0e6-ff00727cba72","","",true, this);
 
            IDContactAdministration = RPSControlFactory.CreateRPSComboBox<OrderSLEntityView>("ed02078f-d24c-4a3c-9e5a-ddfe8552f212","","",false, this);
 
            IDOrderSituation = RPSControlFactory.CreateRPSComboBox<OrderSLEntityView>("fbe68c0e-9818-4b4c-8eae-c96eb943712a","","",true, this);
 
            OrderDate = RPSControlFactory.CreateRPSTextBox<OrderSLEntityView>("f313c235-4a07-4166-ab6c-1bfc08cc7271","","",true, this);
 
            ReceptionDate = RPSControlFactory.CreateRPSTextBox<OrderSLEntityView>("293ff736-03af-4a71-894d-7bcbf275f9b6","","",true, this);
 
            ReceptionDemandDate = RPSControlFactory.CreateRPSTextBox<OrderSLEntityView>("ee56f510-8af4-465f-9356-cdf0e3afc732","","",true, this);
 
            OrderNumberCustomer = RPSControlFactory.CreateRPSTextBox<OrderSLEntityView>("0852a6a3-0bd0-4050-968e-051507b5cca6","","",false, this);
 
            UICodCompanyPurchase = RPSControlFactory.CreateRPSTextBox<OrderSLEntityView>("3e2dba45-a202-4484-b532-17753d4d36e7","","",false, this);
 
            IDIntOrderPurchase = RPSControlFactory.CreateRPSComboBox<OrderSLEntityView>("a7152395-c782-4d15-862d-d5a6f5b0904e","","",false, this);
 
            IDSitePurchase = RPSControlFactory.CreateRPSComboBox<OrderSLEntityView>("78505c6c-c76c-45cf-8595-310f1104e8fb","","",false, this);
 
            IDCodingSerieOrder = RPSControlFactory.CreateRPSComboBox<OrderSLEntityView>("68d7260b-19a1-4bfa-b511-12326f4b94b7","","",false, this);
 
            IDCodingSerieDeliveryNote = RPSControlFactory.CreateRPSComboBox<OrderSLEntityView>("75ac9cdd-d0ce-4bf1-8fea-8e32fb68c981","","",false, this);
 
            IDCodingSerieInvoice = RPSControlFactory.CreateRPSComboBox<OrderSLEntityView>("5b8ff809-9ce4-4a1a-b73e-5e6ac1b4db86","","",false, this);
 
            IDBusinessUnit = RPSControlFactory.CreateRPSComboBox<OrderSLEntityView>("bbbf0618-140c-4de0-9902-91b4139b295f","","",false, this);
 
            IDDeliveryNoteTypeGroup = RPSControlFactory.CreateRPSComboBox<OrderSLEntityView>("ee33b465-5ac0-4eb8-beb5-c7d33ef54edf","","",true, this);
 
            IDInvoiceTypeGroup = RPSControlFactory.CreateRPSComboBox<OrderSLEntityView>("46a941d9-4a03-415d-8747-f754e204f344","","",true, this);
 
            IDInvoicingType = RPSControlFactory.CreateRPSComboBox<OrderSLEntityView>("659d8d0c-c79d-4abb-b89d-bca6a7a70920","","",true, this);
 
            ReprintOrder = RPSControlFactory.CreateRPSFormattedTextBox<OrderSLEntityView>("5e61b47e-6841-4c42-ba1f-9881def1bfe7","","",true, this);
 
            IDCustomerPaymentAddress = RPSControlFactory.CreateRPSComboBox<OrderSLEntityView>("0d6c06e2-b056-4864-9dca-d3d72eabd6f8","","",false, this);
 
            IDCustomerBankAccount = RPSControlFactory.CreateRPSComboBox<OrderSLEntityView>("041d0c03-1d2f-4176-823c-791b499eca28","","",false, this);
 
            IDVoucherType = RPSControlFactory.CreateRPSComboBox<OrderSLEntityView>("5c5660e9-47b8-492b-9ab5-babdfa2e7ece","","",false, this);
 
            IDBankAccountCompany = RPSControlFactory.CreateRPSComboBox<OrderSLEntityView>("c154158b-ff1c-4fc7-a0fe-b33394ee3449","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<OrderSLEntityView>("d315e0f9-f886-4d10-a8d9-025122a08670","","",false, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<OrderSLEntityView>("c10d35e8-e7c2-438a-9820-36f9ee591a55","","",false, this);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<OrderSLEntityView>("bc1bf989-6e09-45ee-99f8-6552313094f4","","",false, this);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSComboBox<OrderSLEntityView>("1702c08d-5325-4844-8fdc-3ce0d23c9098","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<OrderSLEntityView>("87ef37a6-37be-4210-b774-1a46aa7714b8","","",true, this);
 
            Change = RPSControlFactory.CreateRPSFormattedTextBox<OrderSLEntityView>("0182374d-46de-4cc4-84fb-fa7b2638c0d8","","",true, this);
 
            FixedChange = RPSControlFactory.CreateRPSCheckBox<OrderSLEntityView>("51e2fb3f-4d69-4953-a0c2-0f1aa27325f3","","",true, this);
 
            IDPriceList = RPSControlFactory.CreateRPSComboBox<OrderSLEntityView>("c8f91546-ceda-4e7a-93f2-b50225188e5b","","",false, this);
 
            IDVATType = RPSControlFactory.CreateRPSComboBox<OrderSLEntityView>("b9e803a1-d112-4598-930d-e712b9b282d3","","",true, this);
 
            IDSurchargeVATType = RPSControlFactory.CreateRPSComboBox<OrderSLEntityView>("1fc3e4cf-3e6d-4365-90f7-7855b6803352","","",false, this);
 
            IDTaxGroup = RPSControlFactory.CreateRPSComboBox<OrderSLEntityView>("0aa4c229-9353-4983-a13e-91bc07ca65e3","","",false, this);
 
            Transport1 = RPSControlFactory.CreateRPSFormattedTextBox<OrderSLEntityView>("3fef6a70-fe90-4dd7-bf01-09e790f0817c","","",true, this);
 
            Discount1 = RPSControlFactory.CreateRPSFormattedTextBox<OrderSLEntityView>("e2d4dbda-aad3-4ad5-9f6b-1d43cd448b1e","","",true, this);
 
            Discount2 = RPSControlFactory.CreateRPSFormattedTextBox<OrderSLEntityView>("8217f46a-2320-4ccd-b205-0f89e839ad3c","","",true, this);
 
            Discount3 = RPSControlFactory.CreateRPSFormattedTextBox<OrderSLEntityView>("32c76afc-c782-4a03-a3c2-6a6422fbcb1c","","",true, this);
 
            CashDiscount = RPSControlFactory.CreateRPSFormattedTextBox<OrderSLEntityView>("6927191b-32f6-4278-82bf-749763a9622f","","",true, this);
 
            FinancialSurcharge = RPSControlFactory.CreateRPSFormattedTextBox<OrderSLEntityView>("c9433c33-6e59-4289-9e5f-862d091d3f64","","",true, this);
 
            RetentionPercent = RPSControlFactory.CreateRPSFormattedTextBox<OrderSLEntityView>("8cd61e56-3809-4b23-970b-aea01644573d","","",true, this);
 
            IDCustomerDeliveryAddress = RPSControlFactory.CreateRPSComboBox<OrderSLEntityView>("7d14947b-0724-4c91-a1c9-7237d4189895","","",false, this);
 
            CodCountryDelivery = RPSControlFactory.CreateRPSComboBox<OrderSLEntityView>("421ccf83-aa75-48c9-a0c3-88b155b9e7ab","","",false, this);
 
            ZipCodeDelivery = RPSControlFactory.CreateRPSTextBox<OrderSLEntityView>("de118178-ef9c-4e57-b322-c67cdca592dd","","",false, this);
 
            IDStateDelivery = RPSControlFactory.CreateRPSComboBox<OrderSLEntityView>("5505c213-b4c7-445e-adef-ed318fa8c564","","",false, this);
 
            IDCountyDelivery = RPSControlFactory.CreateRPSComboBox<OrderSLEntityView>("3b9cd9e0-8bfe-484e-bf90-1e51a5c8107c","","",false, this);
 
            AddressDelivery = RPSControlFactory.CreateRPSTextBox<OrderSLEntityView>("c4a67970-3ba6-4d12-94bc-7fef55961078","","",false, this);
 
            CityDelivery = RPSControlFactory.CreateRPSTextBox<OrderSLEntityView>("be529be7-ac9b-4ca3-a837-1089834bb73e","","",false, this);
 
            Phone1Delivery = RPSControlFactory.CreateRPSTextBox<OrderSLEntityView>("dcf975f9-fbaf-459f-9cd2-1318b76e6dce","","",false, this);
 
            Phone2Delivery = RPSControlFactory.CreateRPSTextBox<OrderSLEntityView>("5c290680-603d-41e8-9c98-a1bf33a169cb","","",false, this);
 
            FaxDelivery = RPSControlFactory.CreateRPSTextBox<OrderSLEntityView>("3fb8ef8f-a97c-4098-87c3-916b1c2b413c","","",false, this);
 
            ContactPersonDelivery = RPSControlFactory.CreateRPSTextBox<OrderSLEntityView>("4300e1c0-37d3-4e1a-86a2-dfeb85f0c83a","","",false, this);
 
            IDShippingAgent = RPSControlFactory.CreateRPSComboBox<OrderSLEntityView>("a74f52a1-c6fe-47d5-8ee2-c0bfb521702a","","",false, this);
 
            AddressDescription = RPSControlFactory.CreateRPSTextBox<OrderSLEntityView>("4f03059b-29f8-4385-9060-39cf50260ba4","","",false, this);
 
            CodBusinessType = RPSControlFactory.CreateRPSComboBox<OrderSLEntityView>("e9b03815-656d-42a6-bfea-a37c3936ddf3","","",false, this);
 
            CodTransportMethod = RPSControlFactory.CreateRPSComboBox<OrderSLEntityView>("5685ed0b-c04c-486e-b717-ca0fba1be8cf","","",false, this);
 
            CodHarborAirport = RPSControlFactory.CreateRPSComboBox<OrderSLEntityView>("a82c1895-6b5b-434f-8208-d41c389a70f2","","",false, this);
 
            CodDeliveryTerm = RPSControlFactory.CreateRPSComboBox<OrderSLEntityView>("74d78037-3c82-4343-b9c0-6601088772d3","","",false, this);
 
            StatisticRegime = RPSControlFactory.CreateRPSEnumComboBox<OrderSLEntityView>("a152ab45-61c9-4309-a30b-49f47ac64b05","","",true, this);
 
            PercentSales = RPSControlFactory.CreateRPSFormattedTextBox<OrderSLEntityView>("e210519c-cbc6-474e-8879-5206305875e4","","",true, this);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<OrderSLEntityView>("9a91e83c-ba78-4b45-bc47-78b21859d1a7","","",false, this);
 
            IDSalesQuote = RPSControlFactory.CreateRPSComboBox<OrderSLEntityView>("309f17a6-5df7-4b51-b7f8-baff49ca543f","","",false, this);
 
            CodFromOrder = RPSControlFactory.CreateRPSTextBox<OrderSLEntityView>("103540b4-9acf-44c2-8341-45cdede8e12b","","",false, this);
 
            PackingProject = RPSControlFactory.CreateRPSCheckBox<OrderSLEntityView>("f5c3f4d9-6075-4856-9a30-1ebad7f8ce23","","",false, this);
 
            ProductReference = RPSControlFactory.CreateRPSTextBox<OrderSLEntityView>("4ba3907b-622a-4be1-a589-27e0053966b5","","",false, this);
 
            IDMaintenanceOrder = RPSControlFactory.CreateRPSComboBox<OrderSLEntityView>("244818ea-95bc-4360-a97d-6a8f358d0e1c","","",false, this);
 
            UICodMaintenanceContract = RPSControlFactory.CreateRPSTextBox<OrderSLEntityView>("2256a2c3-b11c-485f-ab6a-2b96da729fe8","","",false, this);
 
            OrderComAgentNewChildNavigationCommand = RPSControlFactory.CreateRPSButtonToView<OrderSLEntityView,OrderComAgentNewChildDialogView>("0438a862-4b14-480b-a83d-247765ff7e26","","", this,Screen.OrderComAgentNewChildDialogView);
 
            PreTextIDTextLine = RPSControlFactory.CreateRPSComboBox<OrderSLEntityView>("61e06244-8a6e-4787-84a6-01efba746de3","","",false, this);
 
            PreText = RPSControlFactory.CreateRPSTextBox<OrderSLEntityView>("71acf956-a42e-4a2c-8cc7-d9cf0510f583","","",false, this);
 
            PostTextIDTextLine = RPSControlFactory.CreateRPSComboBox<OrderSLEntityView>("68c62774-2b37-46c2-bddb-1249a7aa6a40","","",false, this);
 
            PostText = RPSControlFactory.CreateRPSTextBox<OrderSLEntityView>("18707fcd-1f02-4f3b-afdf-2f1939cfa8a0","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<OrderSLEntityView>("82197916-7162-4c59-be2c-b1cae8cf1afd","","",false, this);
 
            CommentSend = RPSControlFactory.CreateRPSTextBox<OrderSLEntityView>("b18eebaa-b10d-4b98-b17b-2b4380b79bc3","","",false, this);
 
            IDCPQModel = RPSControlFactory.CreateRPSComboBox<OrderSLEntityView>("256ce78b-650c-4380-869d-067a482474b4","","",false, this);
 
            NewCPQProduct = RPSControlFactory.CreateRPSButton<OrderSLEntityView>( "1bcf744f-91fa-41be-ab41-65f2b62ff31a","","",this);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<OrderSLEntityView>("73dc7ddd-18da-4b0e-bb41-cd6e5b2676a0","","",false, this);
 
            PrintOrderChildNavigationCommandButton = RPSControlFactory.CreateRPSButton<OrderSLEntityView>( "7ad95248-131c-41cd-bf86-4befb1d793aa","","",this);
 
            PrintProFormaOrderChildNavigationCommandButton = RPSControlFactory.CreateRPSButton<OrderSLEntityView>( "a610d70d-de7f-49d7-934a-cd0e869eae96","","",this);
 
            ExecuteOrderSLGetTotalsButton = RPSControlFactory.CreateRPSButton<OrderSLEntityView>( "92aff11f-e8d3-4c01-8c04-839dbed408bf","","",this);
 
            GenerateDeliveryNoteChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<OrderSLEntityView,GenerateDeliveryNoteChildDialogView>("1a67cbca-1512-4c42-9d85-15908e8f4d0c","","", this,Screen.GenerateDeliveryNoteChildDialogView);
 
            NewOrderChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<OrderSLEntityView,NewOrderChildDialogView>("1571ec6f-2fac-4165-9109-a0deed2fe488","","", this,Screen.NewOrderChildDialogView);
 
            RecalculatePromotionButton = RPSControlFactory.CreateRPSButton<OrderSLEntityView>( "4dfc3928-b8e3-4bea-bc6e-bee2c40abc69","","",this);
 
            ChangeOrderCustomerChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<OrderSLEntityView,ChangeOrderCustomerChildDialogView>("111da28d-3210-4303-b2e7-05729b4929ec","","", this,Screen.ChangeOrderCustomerChildDialogView);
 
            ModifyOrderSituationSLNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<OrderSLEntityView,ModifyOrderSituationSLDialogView>("094ca503-a53e-4fc3-80e0-4bf260729db2","","", this,Screen.ModifyOrderSituationSLDialogView);
 
            OrderSLToRoadMapChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<OrderSLEntityView,OrderSLToRoadMapChildDialogView>("0afdbdf1-b651-4c97-8588-62e624950f5c","","", this,Screen.OrderSLToRoadMapChildDialogView);
 
            OrderRestNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<OrderSLEntityView,OrderRestDialogView>("71212920-7304-4f7d-8ed6-9abd75156341","","", this,Screen.OrderRestDialogView);
 
            PrintOrderAdvanceSLCommandButton = RPSControlFactory.CreateRPSButton<OrderSLEntityView>( "b35876eb-4a1a-4887-a44e-a33d71743352","","",this);
 
            CreateProjectFromOrderNavigationCommandButton = RPSControlFactory.CreateRPSButton<OrderSLEntityView>( "52b41c67-d84d-46d5-925e-fe3cc0104a44","","",this);
 
            ProMRPNavigationCommandButton = RPSControlFactory.CreateRPSButton<OrderSLEntityView>( "74eaafde-4b22-4657-aab2-e13f614c122b","","",this);
 
            CollectionInit params_OrderLineSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="260246b8-61ac-413d-a428-c87692874dcb",CSSSelectorGrid="",XPathGrid=""};
            OrderLineSLs = RPSControlFactory.RPSCreateCollectionWithGrid<OrderLineSLsCollectionEditor<OrderSLEntityView,OrderAdvanceSLView>,OrderSLEntityView,OrderAdvanceSLView>( params_OrderLineSLs,this,Screen.OrderAdvanceSLView);
 
            CollectionInit params_OrderAdvanceSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="046a1ebe-b35b-4836-909c-7af3c38a8c8c",CSSSelectorGrid="",XPathGrid=""};
            OrderAdvanceSLs = RPSControlFactory.RPSCreateCollectionWithGrid<OrderAdvanceSLsCollectionEditor<OrderSLEntityView,OrderAdvanceSLView>,OrderSLEntityView,OrderAdvanceSLView>( params_OrderAdvanceSLs,this,Screen.OrderAdvanceSLView);
 
            CollectionInit params_OrderVariablePaymentSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7392cf0f-35ae-4d7a-be10-df6d25bde43e",CSSSelectorGrid="",XPathGrid=""};
            OrderVariablePaymentSLs = RPSControlFactory.RPSCreateCollectionWithGrid<OrderVariablePaymentSLsCollectionEditor<OrderSLEntityView,OrderAdvanceSLView>,OrderSLEntityView,OrderAdvanceSLView>( params_OrderVariablePaymentSLs,this,Screen.OrderAdvanceSLView);
 
            CollectionInit params_OrderComAgentSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="9a072840-d6ce-47ce-a721-817743eb4818",CSSSelectorGrid="",XPathGrid=""};
            OrderComAgentSLs = RPSControlFactory.RPSCreateCollectionWithGrid<OrderComAgentSLsCollectionEditor<OrderSLEntityView,OrderAdvanceSLView>,OrderSLEntityView,OrderAdvanceSLView>( params_OrderComAgentSLs,this,Screen.OrderAdvanceSLView);
 
            CollectionInit params_OrderMilestoneSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="254d2b1b-7b41-4b60-9f09-5a27868af723",CSSSelectorGrid="",XPathGrid=""};
            OrderMilestoneSLs = RPSControlFactory.RPSCreateCollectionWithGrid<OrderMilestoneSLsCollectionEditor<OrderSLEntityView,OrderAdvanceSLView>,OrderSLEntityView,OrderAdvanceSLView>( params_OrderMilestoneSLs,this,Screen.OrderAdvanceSLView);
 
            CollectionInit params_OrderIncidenceSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8e9a4de3-34eb-4b99-b0a7-aedc9987dbfe",CSSSelectorGrid="",XPathGrid=""};
            OrderIncidenceSLs = RPSControlFactory.RPSCreateCollectionWithGrid<OrderIncidenceSLsCollectionEditor<OrderSLEntityView,OrderAdvanceSLView>,OrderSLEntityView,OrderAdvanceSLView>( params_OrderIncidenceSLs,this,Screen.OrderAdvanceSLView);
 
            CollectionInit params_CPQProduct = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0af6b490-43fa-4f45-ab99-6cca715a71a3",CSSSelectorGrid="",XPathGrid=""};
            CPQProduct = RPSControlFactory.RPSCreateCollectionWithGrid<CPQProductCollectionEditor<OrderSLEntityView,OrderAdvanceSLView>,OrderSLEntityView,OrderAdvanceSLView>( params_CPQProduct,this,Screen.OrderAdvanceSLView);
 
            LinesSection = RPSControlFactory.CreateRPSSection<OrderSLEntityView>( "","ul li[rpsid='0a1436a8-e2eb-4a60-bc44-396b9af3ba60']","",this);
 
            GeneralDataSection = RPSControlFactory.CreateRPSSection<OrderSLEntityView>( "","ul li[rpsid='f849b328-90f8-45a8-823e-c3e9fb7549ff']","",this);
 
            AdvanceSection = RPSControlFactory.CreateRPSSection<OrderSLEntityView>( "","ul li[rpsid='909d1ee6-3094-4677-afc7-7f1f71cfdd7f']","",this);
 
            VariablePaymentSection = RPSControlFactory.CreateRPSSection<OrderSLEntityView>( "","ul li[rpsid='9796789d-6b4e-45ed-81f1-2e5409c3e5bd']","",this);
 
            CommercialAgentSection = RPSControlFactory.CreateRPSSection<OrderSLEntityView>( "","ul li[rpsid='ba935be0-f33d-41dc-b588-25105ab1e8e3']","",this);
 
            MillestoneSection = RPSControlFactory.CreateRPSSection<OrderSLEntityView>( "","ul li[rpsid='6705df20-f1b2-46d8-8330-7ad05a7f292c']","",this);
 
            TextLine = RPSControlFactory.CreateRPSSection<OrderSLEntityView>( "","ul li[rpsid='1a507eea-934b-422f-a4db-90b1553764e5']","",this);
 
            Incidences = RPSControlFactory.CreateRPSSection<OrderSLEntityView>( "","ul li[rpsid='fc2c3152-cbed-45e1-8db2-af462a9abfde']","",this);
 
            CommentSection = RPSControlFactory.CreateRPSSection<OrderSLEntityView>( "","ul li[rpsid='07d78547-d3f6-45f9-a7fb-530cfb52053c']","",this);
 
            Configurator = RPSControlFactory.CreateRPSSection<OrderSLEntityView>( "","ul li[rpsid='381307cb-b86f-468a-a7fe-801441824ecc']","",this);
 
            DPS = RPSControlFactory.CreateRPSSection<OrderSLEntityView>( "","ul li[rpsid='f8091b00-20dd-41a5-8555-ddce26450fc3']","",this);
 

        }
        public IRPSSaveButton<OrderSLEntityView> SaveButton { get; set; } 
        public IRPSButton<OrderSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<OrderSLEntityView,OrderSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<OrderSLEntityView,OrderSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<OrderSLEntityView> TotalLinesAmount { get; set; } 
        public IRPSTextBox<OrderSLEntityView> TotalBase { get; set; } 
        public IRPSTextBox<OrderSLEntityView> TotalVAT { get; set; } 
        public IRPSTextBox<OrderSLEntityView> TotalTax { get; set; } 
        public IRPSTextBox<OrderSLEntityView> TotalOrder { get; set; } 
        public IRPSTextBox<OrderSLEntityView> UITotalCost { get; set; } 
        public IRPSTextBox<OrderSLEntityView> UIMargin { get; set; } 
        public IRPSTextBox<OrderSLEntityView> UITotalAdvances { get; set; } 
        public IRPSTextBox<OrderSLEntityView> Transport { get; set; } 
        public IRPSTextBox<OrderSLEntityView> UICustomerRisk { get; set; } 
        public IRPSButton<OrderSLEntityView> InsertCustomerArticleCommandButton { get; set; } 
        public IRPSButton<OrderSLEntityView> CreateManufacturingOrderfromSalesCommandButton { get; set; } 
        public IRPSButton<OrderSLEntityView,OrderChangesChildDialogView> OrderChangesChildNavigationCommandButton { get; set; } 
        public IRPSTextBox<OrderSLEntityView> CodOrder { get; set; } 
        public IRPSComboBox<OrderSLEntityView> IDCustomer { get; set; } 
        public IRPSComboBox<OrderSLEntityView> IDCustomerMiscellaneous { get; set; } 
        public IRPSComboBox<OrderSLEntityView> IDCustomerContact { get; set; } 
        public IRPSCheckbox<OrderSLEntityView> NewOrderRest { get; set; } 
        public IRPSTextBox<OrderSLEntityView> OrderPriority { get; set; } 
        public IRPSComboBox<OrderSLEntityView> IDContactAdministration { get; set; } 
        public IRPSComboBox<OrderSLEntityView> IDOrderSituation { get; set; } 
        public IRPSTextBox<OrderSLEntityView> OrderDate { get; set; } 
        public IRPSTextBox<OrderSLEntityView> ReceptionDate { get; set; } 
        public IRPSTextBox<OrderSLEntityView> ReceptionDemandDate { get; set; } 
        public IRPSTextBox<OrderSLEntityView> OrderNumberCustomer { get; set; } 
        public IRPSTextBox<OrderSLEntityView> UICodCompanyPurchase { get; set; } 
        public IRPSComboBox<OrderSLEntityView> IDIntOrderPurchase { get; set; } 
        public IRPSComboBox<OrderSLEntityView> IDSitePurchase { get; set; } 
        public IRPSComboBox<OrderSLEntityView> IDCodingSerieOrder { get; set; } 
        public IRPSComboBox<OrderSLEntityView> IDCodingSerieDeliveryNote { get; set; } 
        public IRPSComboBox<OrderSLEntityView> IDCodingSerieInvoice { get; set; } 
        public IRPSComboBox<OrderSLEntityView> IDBusinessUnit { get; set; } 
        public IRPSComboBox<OrderSLEntityView> IDDeliveryNoteTypeGroup { get; set; } 
        public IRPSComboBox<OrderSLEntityView> IDInvoiceTypeGroup { get; set; } 
        public IRPSComboBox<OrderSLEntityView> IDInvoicingType { get; set; } 
        public IRPSTextBox<OrderSLEntityView> ReprintOrder { get; set; } 
        public IRPSComboBox<OrderSLEntityView> IDCustomerPaymentAddress { get; set; } 
        public IRPSComboBox<OrderSLEntityView> IDCustomerBankAccount { get; set; } 
        public IRPSComboBox<OrderSLEntityView> IDVoucherType { get; set; } 
        public IRPSComboBox<OrderSLEntityView> IDBankAccountCompany { get; set; } 
        public IRPSComboBox<OrderSLEntityView> IDSite { get; set; } 
        public IRPSComboBox<OrderSLEntityView> IDWarehouse { get; set; } 
        public IRPSComboBox<OrderSLEntityView> IDDeliveryNoteType { get; set; } 
        public IRPSComboBox<OrderSLEntityView> IDPaymentMethod { get; set; } 
        public IRPSComboBox<OrderSLEntityView> IDCurrency { get; set; } 
        public IRPSTextBox<OrderSLEntityView> Change { get; set; } 
        public IRPSCheckbox<OrderSLEntityView> FixedChange { get; set; } 
        public IRPSComboBox<OrderSLEntityView> IDPriceList { get; set; } 
        public IRPSComboBox<OrderSLEntityView> IDVATType { get; set; } 
        public IRPSComboBox<OrderSLEntityView> IDSurchargeVATType { get; set; } 
        public IRPSComboBox<OrderSLEntityView> IDTaxGroup { get; set; } 
        public IRPSTextBox<OrderSLEntityView> Transport1 { get; set; } 
        public IRPSTextBox<OrderSLEntityView> Discount1 { get; set; } 
        public IRPSTextBox<OrderSLEntityView> Discount2 { get; set; } 
        public IRPSTextBox<OrderSLEntityView> Discount3 { get; set; } 
        public IRPSTextBox<OrderSLEntityView> CashDiscount { get; set; } 
        public IRPSTextBox<OrderSLEntityView> FinancialSurcharge { get; set; } 
        public IRPSTextBox<OrderSLEntityView> RetentionPercent { get; set; } 
        public IRPSComboBox<OrderSLEntityView> IDCustomerDeliveryAddress { get; set; } 
        public IRPSComboBox<OrderSLEntityView> CodCountryDelivery { get; set; } 
        public IRPSTextBox<OrderSLEntityView> ZipCodeDelivery { get; set; } 
        public IRPSComboBox<OrderSLEntityView> IDStateDelivery { get; set; } 
        public IRPSComboBox<OrderSLEntityView> IDCountyDelivery { get; set; } 
        public IRPSTextBox<OrderSLEntityView> AddressDelivery { get; set; } 
        public IRPSTextBox<OrderSLEntityView> CityDelivery { get; set; } 
        public IRPSTextBox<OrderSLEntityView> Phone1Delivery { get; set; } 
        public IRPSTextBox<OrderSLEntityView> Phone2Delivery { get; set; } 
        public IRPSTextBox<OrderSLEntityView> FaxDelivery { get; set; } 
        public IRPSTextBox<OrderSLEntityView> ContactPersonDelivery { get; set; } 
        public IRPSComboBox<OrderSLEntityView> IDShippingAgent { get; set; } 
        public IRPSTextBox<OrderSLEntityView> AddressDescription { get; set; } 
        public IRPSComboBox<OrderSLEntityView> CodBusinessType { get; set; } 
        public IRPSComboBox<OrderSLEntityView> CodTransportMethod { get; set; } 
        public IRPSComboBox<OrderSLEntityView> CodHarborAirport { get; set; } 
        public IRPSComboBox<OrderSLEntityView> CodDeliveryTerm { get; set; } 
        public IRPSComboBox<OrderSLEntityView> StatisticRegime { get; set; } 
        public IRPSTextBox<OrderSLEntityView> PercentSales { get; set; } 
        public IRPSComboBox<OrderSLEntityView> IDProject { get; set; } 
        public IRPSComboBox<OrderSLEntityView> IDSalesQuote { get; set; } 
        public IRPSTextBox<OrderSLEntityView> CodFromOrder { get; set; } 
        public IRPSCheckbox<OrderSLEntityView> PackingProject { get; set; } 
        public IRPSTextBox<OrderSLEntityView> ProductReference { get; set; } 
        public IRPSComboBox<OrderSLEntityView> IDMaintenanceOrder { get; set; } 
        public IRPSTextBox<OrderSLEntityView> UICodMaintenanceContract { get; set; } 
        public IRPSButton<OrderSLEntityView,OrderComAgentNewChildDialogView> OrderComAgentNewChildNavigationCommand { get; set; } 
        public IRPSComboBox<OrderSLEntityView> PreTextIDTextLine { get; set; } 
        public IRPSTextBox<OrderSLEntityView> PreText { get; set; } 
        public IRPSComboBox<OrderSLEntityView> PostTextIDTextLine { get; set; } 
        public IRPSTextBox<OrderSLEntityView> PostText { get; set; } 
        public IRPSTextBox<OrderSLEntityView> Comment { get; set; } 
        public IRPSTextBox<OrderSLEntityView> CommentSend { get; set; } 
        public IRPSComboBox<OrderSLEntityView> IDCPQModel { get; set; } 
        public IRPSButton<OrderSLEntityView> NewCPQProduct { get; set; } 
        public IRPSComboBox<OrderSLEntityView> IDEmployee { get; set; } 
        public IRPSButton<OrderSLEntityView> PrintOrderChildNavigationCommandButton { get; set; } 
        public IRPSButton<OrderSLEntityView> PrintProFormaOrderChildNavigationCommandButton { get; set; } 
        public IRPSButton<OrderSLEntityView> ExecuteOrderSLGetTotalsButton { get; set; } 
        public IRPSButton<OrderSLEntityView,GenerateDeliveryNoteChildDialogView> GenerateDeliveryNoteChildNavigationCommandButton { get; set; } 
        public IRPSButton<OrderSLEntityView,NewOrderChildDialogView> NewOrderChildNavigationCommandButton { get; set; } 
        public IRPSButton<OrderSLEntityView> RecalculatePromotionButton { get; set; } 
        public IRPSButton<OrderSLEntityView,ChangeOrderCustomerChildDialogView> ChangeOrderCustomerChildNavigationCommandButton { get; set; } 
        public IRPSButton<OrderSLEntityView,ModifyOrderSituationSLDialogView> ModifyOrderSituationSLNavigationCommandButton { get; set; } 
        public IRPSButton<OrderSLEntityView,OrderSLToRoadMapChildDialogView> OrderSLToRoadMapChildNavigationCommandButton { get; set; } 
        public IRPSButton<OrderSLEntityView,OrderRestDialogView> OrderRestNavigationCommandButton { get; set; } 
        public IRPSButton<OrderSLEntityView> PrintOrderAdvanceSLCommandButton { get; set; } 
        public IRPSButton<OrderSLEntityView> CreateProjectFromOrderNavigationCommandButton { get; set; } 
        public IRPSButton<OrderSLEntityView> ProMRPNavigationCommandButton { get; set; } 
        public OrderLineSLsCollectionEditor<OrderSLEntityView,OrderAdvanceSLView> OrderLineSLs { get; set; } 
        public OrderAdvanceSLsCollectionEditor<OrderSLEntityView,OrderAdvanceSLView> OrderAdvanceSLs { get; set; } 
        public OrderVariablePaymentSLsCollectionEditor<OrderSLEntityView,OrderAdvanceSLView> OrderVariablePaymentSLs { get; set; } 
        public OrderComAgentSLsCollectionEditor<OrderSLEntityView,OrderAdvanceSLView> OrderComAgentSLs { get; set; } 
        public OrderMilestoneSLsCollectionEditor<OrderSLEntityView,OrderAdvanceSLView> OrderMilestoneSLs { get; set; } 
        public OrderIncidenceSLsCollectionEditor<OrderSLEntityView,OrderAdvanceSLView> OrderIncidenceSLs { get; set; } 
        public CPQProductCollectionEditor<OrderSLEntityView,OrderAdvanceSLView> CPQProduct { get; set; } 
        public IRPSSection<OrderSLEntityView> LinesSection { get; set; } 
        public IRPSSection<OrderSLEntityView> GeneralDataSection { get; set; } 
        public IRPSSection<OrderSLEntityView> AdvanceSection { get; set; } 
        public IRPSSection<OrderSLEntityView> VariablePaymentSection { get; set; } 
        public IRPSSection<OrderSLEntityView> CommercialAgentSection { get; set; } 
        public IRPSSection<OrderSLEntityView> MillestoneSection { get; set; } 
        public IRPSSection<OrderSLEntityView> TextLine { get; set; } 
        public IRPSSection<OrderSLEntityView> Incidences { get; set; } 
        public IRPSSection<OrderSLEntityView> CommentSection { get; set; } 
        public IRPSSection<OrderSLEntityView> Configurator { get; set; } 
        public IRPSSection<OrderSLEntityView> DPS { get; set; } 
        public OrderSL Screen { get; set; }
        public OrderSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class OrderLineSLsCollectionEditor<OrderSLEntityView,OrderAdvanceSLView>:RPSCollectionEditor<OrderSLEntityView,OrderAdvanceSLView> where OrderSLEntityView : class, IView where OrderAdvanceSLView : class, IView
    {
        public  OrderLineSLsGridView<OrderSLEntityView,OrderAdvanceSLView> GridView {get;set;}
    }
    public partial class OrderLineSLsGridView <OrderSLEntityView,OrderAdvanceSLView> :  RPSGridView<OrderSLEntityView,OrderAdvanceSLView> where OrderSLEntityView : class, IView where OrderAdvanceSLView : class, IView
    {
        public OrderLineSLsGridView(OrderSLEntityView currentView,OrderAdvanceSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Ordenation = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderSLEntityView>("","#260246b8-61ac-413d-a428-c87692874dcb .ag-row[role='row']@ROWINDEX [col-id='cOrdenation']","",true, this.CurrentView);
 
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<OrderSLEntityView>("","#260246b8-61ac-413d-a428-c87692874dcb .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<OrderSLEntityView>("","#260246b8-61ac-413d-a428-c87692874dcb .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            PlanNumber = RPSControlFactory.CreateRPSGridTextBox<OrderSLEntityView>("","#260246b8-61ac-413d-a428-c87692874dcb .ag-row[role='row']@ROWINDEX [col-id='cPlanNumber']","",false, this.CurrentView);
 
            ReceptionDate = RPSControlFactory.CreateRPSGridTextBox<OrderSLEntityView>("","#260246b8-61ac-413d-a428-c87692874dcb .ag-row[role='row']@ROWINDEX [col-id='cReceptionDate']","",true, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderSLEntityView>("","#260246b8-61ac-413d-a428-c87692874dcb .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            Price = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderSLEntityView>("","#260246b8-61ac-413d-a428-c87692874dcb .ag-row[role='row']@ROWINDEX [col-id='cPrice']","",true, this.CurrentView);
 
            Discount1 = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderSLEntityView>("","#260246b8-61ac-413d-a428-c87692874dcb .ag-row[role='row']@ROWINDEX [col-id='cDiscount1']","",true, this.CurrentView);
 
            PercentVAT = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderSLEntityView>("","#260246b8-61ac-413d-a428-c87692874dcb .ag-row[role='row']@ROWINDEX [col-id='cPercentVAT']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderSLEntityView>("","#260246b8-61ac-413d-a428-c87692874dcb .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            AmountWithVAT = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderSLEntityView>("","#260246b8-61ac-413d-a428-c87692874dcb .ag-row[role='row']@ROWINDEX [col-id='cAmountWithVAT']","",true, this.CurrentView);
 
            AddressDescription = RPSControlFactory.CreateRPSGridTextBox<OrderSLEntityView>("","#260246b8-61ac-413d-a428-c87692874dcb .ag-row[role='row']@ROWINDEX [col-id='cAddressDescription']","",false, this.CurrentView);
 
            BlockedMRP = RPSControlFactory.CreateRPSGridCheckBox<OrderSLEntityView>("","#260246b8-61ac-413d-a428-c87692874dcb .ag-row[role='row']@ROWINDEX [col-id='cBlockedMRP']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<OrderSLEntityView> Ordenation { get; set; } 
        public IRPSGridComboBox<OrderSLEntityView> IDArticle { get; set; } 
        public IRPSGridTextBox<OrderSLEntityView> Description { get; set; } 
        public IRPSGridTextBox<OrderSLEntityView> PlanNumber { get; set; } 
        public IRPSGridTextBox<OrderSLEntityView> ReceptionDate { get; set; } 
        public IRPSGridTextBox<OrderSLEntityView> Quantity { get; set; } 
        public IRPSGridTextBox<OrderSLEntityView> Price { get; set; } 
        public IRPSGridTextBox<OrderSLEntityView> Discount1 { get; set; } 
        public IRPSGridTextBox<OrderSLEntityView> PercentVAT { get; set; } 
        public IRPSGridTextBox<OrderSLEntityView> Amount { get; set; } 
        public IRPSGridTextBox<OrderSLEntityView> AmountWithVAT { get; set; } 
        public IRPSGridTextBox<OrderSLEntityView> AddressDescription { get; set; } 
        public IRPSGridCheckbox<OrderSLEntityView> BlockedMRP { get; set; } 
                     
    }
 
        public partial class OrderAdvanceSLsCollectionEditor<OrderSLEntityView,OrderAdvanceSLView>:RPSCollectionEditor<OrderSLEntityView,OrderAdvanceSLView> where OrderSLEntityView : class, IView where OrderAdvanceSLView : class, IView
    {
        public  OrderAdvanceSLsGridView<OrderSLEntityView,OrderAdvanceSLView> GridView {get;set;}
    }
    public partial class OrderAdvanceSLsGridView <OrderSLEntityView,OrderAdvanceSLView> :  RPSGridView<OrderSLEntityView,OrderAdvanceSLView> where OrderSLEntityView : class, IView where OrderAdvanceSLView : class, IView
    {
        public OrderAdvanceSLsGridView(OrderSLEntityView currentView,OrderAdvanceSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NumAdvance = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderSLEntityView>("","#046a1ebe-b35b-4836-909c-7af3c38a8c8c .ag-row[role='row']@ROWINDEX [col-id='cNumAdvance']","",true, this.CurrentView);
 
            AdvanceDate = RPSControlFactory.CreateRPSGridTextBox<OrderSLEntityView>("","#046a1ebe-b35b-4836-909c-7af3c38a8c8c .ag-row[role='row']@ROWINDEX [col-id='cAdvanceDate']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<OrderSLEntityView>("","#046a1ebe-b35b-4836-909c-7af3c38a8c8c .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderSLEntityView>("","#046a1ebe-b35b-4836-909c-7af3c38a8c8c .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            IDVATType = RPSControlFactory.CreateRPSGridComboBox<OrderSLEntityView>("","#046a1ebe-b35b-4836-909c-7af3c38a8c8c .ag-row[role='row']@ROWINDEX [col-id='cIDVATType']","",false, this.CurrentView);
 
            VAT = RPSControlFactory.CreateRPSGridCheckBox<OrderSLEntityView>("","#046a1ebe-b35b-4836-909c-7af3c38a8c8c .ag-row[role='row']@ROWINDEX [col-id='cVAT']","",true, this.CurrentView);
 
            Invoice = RPSControlFactory.CreateRPSGridCheckBox<OrderSLEntityView>("","#046a1ebe-b35b-4836-909c-7af3c38a8c8c .ag-row[role='row']@ROWINDEX [col-id='cInvoice']","",true, this.CurrentView);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSGridComboBox<OrderSLEntityView>("","#046a1ebe-b35b-4836-909c-7af3c38a8c8c .ag-row[role='row']@ROWINDEX [col-id='cIDPaymentMethod']","",false, this.CurrentView);
 
            Invoiced = RPSControlFactory.CreateRPSGridCheckBox<OrderSLEntityView>("","#046a1ebe-b35b-4836-909c-7af3c38a8c8c .ag-row[role='row']@ROWINDEX [col-id='cInvoiced']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<OrderSLEntityView> NumAdvance { get; set; } 
        public IRPSGridTextBox<OrderSLEntityView> AdvanceDate { get; set; } 
        public IRPSGridTextBox<OrderSLEntityView> Description { get; set; } 
        public IRPSGridTextBox<OrderSLEntityView> Amount { get; set; } 
        public IRPSGridComboBox<OrderSLEntityView> IDVATType { get; set; } 
        public IRPSGridCheckbox<OrderSLEntityView> VAT { get; set; } 
        public IRPSGridCheckbox<OrderSLEntityView> Invoice { get; set; } 
        public IRPSGridComboBox<OrderSLEntityView> IDPaymentMethod { get; set; } 
        public IRPSGridCheckbox<OrderSLEntityView> Invoiced { get; set; } 
                     
    }
 
        public partial class OrderVariablePaymentSLsCollectionEditor<OrderSLEntityView,OrderAdvanceSLView>:RPSCollectionEditor<OrderSLEntityView,OrderAdvanceSLView> where OrderSLEntityView : class, IView where OrderAdvanceSLView : class, IView
    {
        public  OrderVariablePaymentSLsGridView<OrderSLEntityView,OrderAdvanceSLView> GridView {get;set;}
    }
    public partial class OrderVariablePaymentSLsGridView <OrderSLEntityView,OrderAdvanceSLView> :  RPSGridView<OrderSLEntityView,OrderAdvanceSLView> where OrderSLEntityView : class, IView where OrderAdvanceSLView : class, IView
    {
        public OrderVariablePaymentSLsGridView(OrderSLEntityView currentView,OrderAdvanceSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NumPayment = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderSLEntityView>("","#7392cf0f-35ae-4d7a-be10-df6d25bde43e .ag-row[role='row']@ROWINDEX [col-id='cNumPayment']","",true, this.CurrentView);
 
            DatePayment = RPSControlFactory.CreateRPSGridTextBox<OrderSLEntityView>("","#7392cf0f-35ae-4d7a-be10-df6d25bde43e .ag-row[role='row']@ROWINDEX [col-id='cDatePayment']","",false, this.CurrentView);
 
            DayPayment = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderSLEntityView>("","#7392cf0f-35ae-4d7a-be10-df6d25bde43e .ag-row[role='row']@ROWINDEX [col-id='cDayPayment']","",false, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderSLEntityView>("","#7392cf0f-35ae-4d7a-be10-df6d25bde43e .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderSLEntityView>("","#7392cf0f-35ae-4d7a-be10-df6d25bde43e .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",true, this.CurrentView);
 
            Rest = RPSControlFactory.CreateRPSGridCheckBox<OrderSLEntityView>("","#7392cf0f-35ae-4d7a-be10-df6d25bde43e .ag-row[role='row']@ROWINDEX [col-id='cRest']","",false, this.CurrentView);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSGridComboBox<OrderSLEntityView>("","#7392cf0f-35ae-4d7a-be10-df6d25bde43e .ag-row[role='row']@ROWINDEX [col-id='cIDPaymentMethod']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<OrderSLEntityView> NumPayment { get; set; } 
        public IRPSGridTextBox<OrderSLEntityView> DatePayment { get; set; } 
        public IRPSGridTextBox<OrderSLEntityView> DayPayment { get; set; } 
        public IRPSGridTextBox<OrderSLEntityView> Amount { get; set; } 
        public IRPSGridTextBox<OrderSLEntityView> Percentage { get; set; } 
        public IRPSGridCheckbox<OrderSLEntityView> Rest { get; set; } 
        public IRPSGridComboBox<OrderSLEntityView> IDPaymentMethod { get; set; } 
                     
    }
 
        public partial class OrderComAgentSLsCollectionEditor<OrderSLEntityView,OrderAdvanceSLView>:RPSCollectionEditor<OrderSLEntityView,OrderAdvanceSLView> where OrderSLEntityView : class, IView where OrderAdvanceSLView : class, IView
    {
        public  OrderComAgentSLsGridView<OrderSLEntityView,OrderAdvanceSLView> GridView {get;set;}
    }
    public partial class OrderComAgentSLsGridView <OrderSLEntityView,OrderAdvanceSLView> :  RPSGridView<OrderSLEntityView,OrderAdvanceSLView> where OrderSLEntityView : class, IView where OrderAdvanceSLView : class, IView
    {
        public OrderComAgentSLsGridView(OrderSLEntityView currentView,OrderAdvanceSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeleteAgentCommand = RPSControlFactory.CreateRPSGridButton<OrderSLEntityView>( "","#9a072840-d6ce-47ce-a721-817743eb4818 .ag-row[role='row']@ROWINDEX [col-id='cDeleteAgentCommand']","",this.CurrentView);
 
            IDCommercialAgent = RPSControlFactory.CreateRPSGridComboBox<OrderSLEntityView>("","#9a072840-d6ce-47ce-a721-817743eb4818 .ag-row[role='row']@ROWINDEX [col-id='cIDCommercialAgent']","",true, this.CurrentView);
 
            IDCommercialAgentClassification = RPSControlFactory.CreateRPSGridComboBox<OrderSLEntityView>("","#9a072840-d6ce-47ce-a721-817743eb4818 .ag-row[role='row']@ROWINDEX [col-id='cIDCommercialAgentClassification']","",true, this.CurrentView);
 
            Comision = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderSLEntityView>("","#9a072840-d6ce-47ce-a721-817743eb4818 .ag-row[role='row']@ROWINDEX [col-id='cCommission']","",false, this.CurrentView);
 
            ComisionTypeString = RPSControlFactory.CreateRPSGridTextBox<OrderSLEntityView>("","#9a072840-d6ce-47ce-a721-817743eb4818 .ag-row[role='row']@ROWINDEX [col-id='cComisionTypeString']","",false, this.CurrentView);
 
            ComisionHead = RPSControlFactory.CreateRPSGridCheckBox<OrderSLEntityView>("","#9a072840-d6ce-47ce-a721-817743eb4818 .ag-row[role='row']@ROWINDEX [col-id='cComisionHead']","",false, this.CurrentView);
 

        }
        public IRPSGridButton<OrderSLEntityView> DeleteAgentCommand { get; set; } 
        public IRPSGridComboBox<OrderSLEntityView> IDCommercialAgent { get; set; } 
        public IRPSGridComboBox<OrderSLEntityView> IDCommercialAgentClassification { get; set; } 
        public IRPSGridTextBox<OrderSLEntityView> Comision { get; set; } 
        public IRPSGridTextBox<OrderSLEntityView> ComisionTypeString { get; set; } 
        public IRPSGridCheckbox<OrderSLEntityView> ComisionHead { get; set; } 
                     
    }
 
        public partial class OrderMilestoneSLsCollectionEditor<OrderSLEntityView,OrderAdvanceSLView>:RPSCollectionEditor<OrderSLEntityView,OrderAdvanceSLView> where OrderSLEntityView : class, IView where OrderAdvanceSLView : class, IView
    {
        public  OrderMilestoneSLsGridView<OrderSLEntityView,OrderAdvanceSLView> GridView {get;set;}
    }
    public partial class OrderMilestoneSLsGridView <OrderSLEntityView,OrderAdvanceSLView> :  RPSGridView<OrderSLEntityView,OrderAdvanceSLView> where OrderSLEntityView : class, IView where OrderAdvanceSLView : class, IView
    {
        public OrderMilestoneSLsGridView(OrderSLEntityView currentView,OrderAdvanceSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDTask = RPSControlFactory.CreateRPSGridComboBox<OrderSLEntityView>("","#254d2b1b-7b41-4b60-9f09-5a27868af723 .ag-row[role='row']@ROWINDEX [col-id='cIDTask']","",true, this.CurrentView);
 
            UIFinal = RPSControlFactory.CreateRPSGridCheckBox<OrderSLEntityView>("","#254d2b1b-7b41-4b60-9f09-5a27868af723 .ag-row[role='row']@ROWINDEX [col-id='cUIFinal']","",false, this.CurrentView);
 
            UIPlannedDate = RPSControlFactory.CreateRPSGridTextBox<OrderSLEntityView>("","#254d2b1b-7b41-4b60-9f09-5a27868af723 .ag-row[role='row']@ROWINDEX [col-id='cUIPlannedDate']","",true, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderSLEntityView>("","#254d2b1b-7b41-4b60-9f09-5a27868af723 .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",true, this.CurrentView);
 
            GenerateAdvance = RPSControlFactory.CreateRPSGridCheckBox<OrderSLEntityView>("","#254d2b1b-7b41-4b60-9f09-5a27868af723 .ag-row[role='row']@ROWINDEX [col-id='cGenerateAdvance']","",true, this.CurrentView);
 
            Invoiced = RPSControlFactory.CreateRPSGridCheckBox<OrderSLEntityView>("","#254d2b1b-7b41-4b60-9f09-5a27868af723 .ag-row[role='row']@ROWINDEX [col-id='cInvoiced']","",true, this.CurrentView);
 
            IDOrderAdvance = RPSControlFactory.CreateRPSGridComboBox<OrderSLEntityView>("","#254d2b1b-7b41-4b60-9f09-5a27868af723 .ag-row[role='row']@ROWINDEX [col-id='cIDOrderAdvance']","",false, this.CurrentView);
 
            IDDeliveryNoteLine = RPSControlFactory.CreateRPSGridComboBox<OrderSLEntityView>("","#254d2b1b-7b41-4b60-9f09-5a27868af723 .ag-row[role='row']@ROWINDEX [col-id='cIDDeliveryNoteLine']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<OrderSLEntityView> IDTask { get; set; } 
        public IRPSGridCheckbox<OrderSLEntityView> UIFinal { get; set; } 
        public IRPSGridTextBox<OrderSLEntityView> UIPlannedDate { get; set; } 
        public IRPSGridTextBox<OrderSLEntityView> Percentage { get; set; } 
        public IRPSGridCheckbox<OrderSLEntityView> GenerateAdvance { get; set; } 
        public IRPSGridCheckbox<OrderSLEntityView> Invoiced { get; set; } 
        public IRPSGridComboBox<OrderSLEntityView> IDOrderAdvance { get; set; } 
        public IRPSGridComboBox<OrderSLEntityView> IDDeliveryNoteLine { get; set; } 
                     
    }
 
        public partial class OrderIncidenceSLsCollectionEditor<OrderSLEntityView,OrderAdvanceSLView>:RPSCollectionEditor<OrderSLEntityView,OrderAdvanceSLView> where OrderSLEntityView : class, IView where OrderAdvanceSLView : class, IView
    {
        public  OrderIncidenceSLsGridView<OrderSLEntityView,OrderAdvanceSLView> GridView {get;set;}
    }
    public partial class OrderIncidenceSLsGridView <OrderSLEntityView,OrderAdvanceSLView> :  RPSGridView<OrderSLEntityView,OrderAdvanceSLView> where OrderSLEntityView : class, IView where OrderAdvanceSLView : class, IView
    {
        public OrderIncidenceSLsGridView(OrderSLEntityView currentView,OrderAdvanceSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NumIncidence = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderSLEntityView>("","#8e9a4de3-34eb-4b99-b0a7-aedc9987dbfe .ag-row[role='row']@ROWINDEX [col-id='cNumIncidence']","",true, this.CurrentView);
 
            Date = RPSControlFactory.CreateRPSGridTextBox<OrderSLEntityView>("","#8e9a4de3-34eb-4b99-b0a7-aedc9987dbfe .ag-row[role='row']@ROWINDEX [col-id='cDate']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<OrderSLEntityView>("","#8e9a4de3-34eb-4b99-b0a7-aedc9987dbfe .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            IDIncidenceType = RPSControlFactory.CreateRPSGridComboBox<OrderSLEntityView>("","#8e9a4de3-34eb-4b99-b0a7-aedc9987dbfe .ag-row[role='row']@ROWINDEX [col-id='cIDIncidenceType']","",true, this.CurrentView);
 
            IDIncidenceSituation = RPSControlFactory.CreateRPSGridComboBox<OrderSLEntityView>("","#8e9a4de3-34eb-4b99-b0a7-aedc9987dbfe .ag-row[role='row']@ROWINDEX [col-id='cIDIncidenceSituation']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<OrderSLEntityView> NumIncidence { get; set; } 
        public IRPSGridTextBox<OrderSLEntityView> Date { get; set; } 
        public IRPSGridTextBox<OrderSLEntityView> Description { get; set; } 
        public IRPSGridComboBox<OrderSLEntityView> IDIncidenceType { get; set; } 
        public IRPSGridComboBox<OrderSLEntityView> IDIncidenceSituation { get; set; } 
                     
    }
 
        public partial class CPQProductCollectionEditor<OrderSLEntityView,OrderAdvanceSLView>:RPSCollectionEditor<OrderSLEntityView,OrderAdvanceSLView> where OrderSLEntityView : class, IView where OrderAdvanceSLView : class, IView
    {
        public  CPQProductGridView<OrderSLEntityView,OrderAdvanceSLView> GridView {get;set;}
    }
    public partial class CPQProductGridView <OrderSLEntityView,OrderAdvanceSLView> :  RPSGridView<OrderSLEntityView,OrderAdvanceSLView> where OrderSLEntityView : class, IView where OrderAdvanceSLView : class, IView
    {
        public CPQProductGridView(OrderSLEntityView currentView,OrderAdvanceSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Date = RPSControlFactory.CreateRPSGridTextBox<OrderSLEntityView>("","#0af6b490-43fa-4f45-ab99-6cca715a71a3 .ag-row[role='row']@ROWINDEX [col-id='cDate']","",false, this.CurrentView);
 
            CPQProduct_DescriptionExtended = RPSControlFactory.CreateRPSGridMemoTextBox<OrderSLEntityView>("","#0af6b490-43fa-4f45-ab99-6cca715a71a3 .ag-row[role='row']@ROWINDEX [col-id='cCPQProduct_DescriptionExtended']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<OrderSLEntityView> Date { get; set; } 
        public IRPSGridTextBox<OrderSLEntityView> CPQProduct_DescriptionExtended { get; set; } 
                     
    }
 
    }
  
            
    public partial class OrderLineSLView : View
    {
        public OrderLineSLView(OrderSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<OrderLineSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<OrderLineSLView,OrderSLEntityView>( this,Screen.OrderSLEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<OrderLineSLView,OrderSLEntityView>( this,Screen.OrderSLEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<OrderLineSLView,OrderSLEntityView>( this,Screen.OrderSLEntityView);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<OrderLineSLView>("1d0ff8ff-3229-41c2-b059-0a06fb4026e6","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineSLView>("2ef090eb-0fc4-4576-bb38-0004d6ee36f8","","",true, this);
 
            Price = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineSLView>("309ac35f-2864-40ca-80e0-4b68531e9c0a","","",true, this);
 
            VAT = RPSControlFactory.CreateRPSCheckBox<OrderLineSLView>("996a2b0f-088a-4d1a-89e7-89f8ccbcd3a6","","",true, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineSLView>("458721e4-02b6-4c8d-96a5-e7cd6bb7eaf7","","",true, this);
 
            AmountWithVAT = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineSLView>("b78326df-ea99-4b77-8d30-1c186e025cb2","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<OrderLineSLView>("b416955c-6236-4903-a0cc-cf8cdbd21db7","","",false, this);
 
            ReferenceCustomer = RPSControlFactory.CreateRPSEnumComboBox<OrderLineSLView>("ef7d3761-76e1-46ef-b5d0-783fb9bcf066","","",false, this);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSComboBox<OrderLineSLView>("50a569bd-c14b-472a-8f9c-ad11539af3e3","","",true, this);
 
            ConversionFactorQuantity = RPSControlFactory.CreateRPSTextBox<OrderLineSLView>("a550c1c0-afe8-4c2d-898e-fdc918ceb956","","",true, this);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineSLView>("015b956f-fabb-4b60-8392-4e9748071ebd","","",true, this);
 
            Dimension1 = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineSLView>("1a7641b0-af86-48dd-ab70-ee2acbdf12e9","","",true, this);
 
            Dimension2 = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineSLView>("d43a91b2-449e-4639-bd87-16018367f249","","",true, this);
 
            Dimension3 = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineSLView>("9e523882-91ec-4d5d-9ad3-b25759b864f9","","",true, this);
 
            IDUnitPrice = RPSControlFactory.CreateRPSComboBox<OrderLineSLView>("fd383b2f-f737-434a-8935-5d6fa4d42045","","",true, this);
 
            ConversionFactorPrice = RPSControlFactory.CreateRPSTextBox<OrderLineSLView>("358728d7-6a20-449b-935c-9daf0117dd25","","",true, this);
 
            Cost = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineSLView>("a69fb522-6d7c-47c1-9e16-b468800c0c3e","","",true, this);
 
            Series = RPSControlFactory.CreateRPSEnumComboBox<OrderLineSLView>("18b6bb3f-c406-4d8e-9d4a-38b8eea18ba9","","",false, this);
 
            Ordenation = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineSLView>("58defaae-00ba-4358-beb1-afc702f989a2","","",true, this);
 
            Index = RPSControlFactory.CreateRPSTextBox<OrderLineSLView>("9118b7e1-bb93-44ad-8594-a4d8d977e112","","",false, this);
 
            Delivered = RPSControlFactory.CreateRPSCheckBox<OrderLineSLView>("9f086257-3835-4e68-a571-9c92d6f3edd2","","",true, this);
 
            PendingDelivery = RPSControlFactory.CreateRPSCheckBox<OrderLineSLView>("7086c74b-f325-4b4e-81d9-f67096973d04","","",true, this);
 
            DeliveredQuantity = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineSLView>("95ac0c20-9221-40bc-995b-5aded3b1e500","","",true, this);
 
            DeliveredQuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineSLView>("cb835547-7c7b-44f1-8616-3395b10abe59","","",true, this);
 
            ReceptionDate = RPSControlFactory.CreateRPSTextBox<OrderLineSLView>("21be98a4-fcfd-4ee3-a73e-4c6d1d022a62","","",true, this);
 
            IDArticleVersion = RPSControlFactory.CreateRPSComboBox<OrderLineSLView>("74ea1d52-081f-4741-bac7-b9e2bcc1bd80","","",false, this);
 
            Invoice = RPSControlFactory.CreateRPSCheckBox<OrderLineSLView>("0439c590-a606-454a-aafc-a4cabfb51148","","",true, this);
 
            Invoiced = RPSControlFactory.CreateRPSCheckBox<OrderLineSLView>("b2d4360d-c17b-40a2-bd1b-d0368631ed80","","",true, this);
 
            InvoicedQuantity = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineSLView>("53678803-83af-4e5a-bdd4-2500bad5bc3e","","",true, this);
 
            InvoicedQuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineSLView>("05592b81-0c21-4fdb-99a5-c2e2327b6c38","","",true, this);
 
            ReceptionDemandDate = RPSControlFactory.CreateRPSTextBox<OrderLineSLView>("9e874fb8-229f-4937-bc02-6f30ebf262a5","","",true, this);
 
            Queue = RPSControlFactory.CreateRPSCheckBox<OrderLineSLView>("c54a3e6b-d6ce-4c44-a3a9-680b200b368b","","",true, this);
 
            Discount1 = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineSLView>("f6d43600-1e00-4c4c-8328-2392c3a8b767","","",true, this);
 
            CascadeDiscount1 = RPSControlFactory.CreateRPSCheckBox<OrderLineSLView>("0adfafa9-af0b-4a16-a5c4-e8b5e1d99c42","","",true, this);
 
            Discount2 = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineSLView>("c989a3df-91ef-4fce-9f9c-7b545b5a06e5","","",true, this);
 
            CascadeDiscount2 = RPSControlFactory.CreateRPSCheckBox<OrderLineSLView>("993e17e9-bf8b-44a2-bbfe-e758261fb909","","",true, this);
 
            Discount3 = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineSLView>("e9b07439-4b45-46cb-baf7-6cd906f95bd0","","",true, this);
 
            CascadeDiscount3 = RPSControlFactory.CreateRPSCheckBox<OrderLineSLView>("e4c398e8-3595-4c0d-a4ad-f677834b9141","","",true, this);
 
            Discount4 = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineSLView>("ff8b147f-2257-4146-865b-2687a98021bb","","",true, this);
 
            CascadeDiscount4 = RPSControlFactory.CreateRPSCheckBox<OrderLineSLView>("d27f3ba0-600e-4d42-b678-412a55f71200","","",true, this);
 
            Discount5 = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineSLView>("797bbce7-98df-403d-b703-d112778b5c03","","",true, this);
 
            CascadeDiscount5 = RPSControlFactory.CreateRPSCheckBox<OrderLineSLView>("6ea57e48-4520-467e-8a75-b77103ba1a60","","",true, this);
 
            AmountDiscount = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineSLView>("d21c321d-7d32-4ac7-9586-f50003a73735","","",true, this);
 
            PositionAmountDiscount = RPSControlFactory.CreateRPSEnumComboBox<OrderLineSLView>("22941bd2-4646-4bcd-9347-912003319e37","","",true, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<OrderLineSLView>("0cdb02e9-69f5-48c6-8ada-4206f8b56035","","",true, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<OrderLineSLView>("24c2a1bc-8248-4709-b9b6-5be161b38bb6","","",true, this);
 
            IDSiteTransfer = RPSControlFactory.CreateRPSComboBox<OrderLineSLView>("c9b5ffb0-9167-4bf6-9eca-a4d2df9eb116","","",false, this);
 
            IDWarehouseTransfer = RPSControlFactory.CreateRPSComboBox<OrderLineSLView>("419d588d-5148-41f9-b5a9-d2cbd70802f7","","",false, this);
 
            IDVAT = RPSControlFactory.CreateRPSComboBox<OrderLineSLView>("0c19bd93-ea90-4d34-8587-48561377d174","","",true, this);
 
            PercentVAT = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineSLView>("fe4b12cc-c007-4e56-ab7d-8ffc84c7ac8a","","",true, this);
 
            IDVATSurcharge = RPSControlFactory.CreateRPSComboBox<OrderLineSLView>("efabb079-abcd-4770-b65c-366095e1a683","","",false, this);
 
            PercentSurcharge = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineSLView>("cced6249-43c3-48cb-a022-5079a2cf3110","","",true, this);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<OrderLineSLView>("b059b4e0-2e15-46d0-a4a5-c7438ba5bc4c","","",true, this);
 
            IDAccount = RPSControlFactory.CreateRPSComboBox<OrderLineSLView>("723953ae-d3c8-4aef-96ea-4696ff12af2a","","",false, this);
 
            IDReturnCause = RPSControlFactory.CreateRPSComboBox<OrderLineSLView>("21279ab8-e033-40ca-8281-eab49ae1d34e","","",false, this);
 
            GeneratedPurchase = RPSControlFactory.CreateRPSCheckBox<OrderLineSLView>("7d5658d0-54fa-4685-8384-c222a3f5e4f3","","",true, this);
 
            IDOrderLineKit = RPSControlFactory.CreateRPSComboBox<OrderLineSLView>("2c18d7e8-9d67-4480-b684-5a0bc352b97b","","",false, this);
 
            CostPercentage = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineSLView>("9c3efa32-4c69-4c0e-aacc-c30ee38cfec1","","",false, this);
 
            NumProm = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineSLView>("000a2b06-5746-4b2e-a65a-2aaa05b25379","","",true, this);
 
            Rappel = RPSControlFactory.CreateRPSCheckBox<OrderLineSLView>("d9429f7b-8575-4565-912d-1521e4913bed","","",true, this);
 
            InternalCode = RPSControlFactory.CreateRPSTextBox<OrderLineSLView>("4efdb149-66f6-4104-a577-b1f0b802ade1","","",false, this);
 
            IDMaintenanceComponent = RPSControlFactory.CreateRPSComboBox<OrderLineSLView>("4656dc3a-ca88-4ac3-9660-cc01da5d8908","","",false, this);
 
            SerialNumber = RPSControlFactory.CreateRPSTextBox<OrderLineSLView>("a54de1f9-1712-4a59-b16b-764f0f7b6517","","",false, this);
 
            IDManufacturingOrder = RPSControlFactory.CreateRPSComboBox<OrderLineSLView>("6a02de1b-f006-46bf-b0e9-da67afaa90bc","","",false, this);
 
            UICodSalesQuoteAndOrdenation = RPSControlFactory.CreateRPSTextBox<OrderLineSLView>("f6ea702d-838e-4222-ba2e-abe1401f0415","","",false, this);
 
            IDFrameworkContractSL = RPSControlFactory.CreateRPSComboBox<OrderLineSLView>("dbb1845d-69b6-4e5f-9d4d-7098d5cdb34a","","",false, this);
 
            FrameworkContractLineNumber = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineSLView>("75500b02-7952-4d7c-836e-7d3869ef9ab5","","",false, this);
 
            IDDeliveryAdress = RPSControlFactory.CreateRPSComboBox<OrderLineSLView>("e022a711-cd97-487d-88fb-f87e546f4218","","",false, this);
 
            CodCountryDelivery = RPSControlFactory.CreateRPSComboBox<OrderLineSLView>("a59836b9-9bed-4c56-90d4-c0493d6e0650","","",false, this);
 
            IDStateDelivery = RPSControlFactory.CreateRPSComboBox<OrderLineSLView>("929ca771-3d16-4d44-9618-81f975ff2ed9","","",false, this);
 
            ZipCodeDelivery = RPSControlFactory.CreateRPSTextBox<OrderLineSLView>("2304dcb8-e254-4cf8-a848-0bcb301f7b01","","",false, this);
 
            IDCountyDelivery = RPSControlFactory.CreateRPSComboBox<OrderLineSLView>("be0684ff-b8d3-408a-8aaa-e0de06664f39","","",false, this);
 
            AddressDelivery = RPSControlFactory.CreateRPSTextBox<OrderLineSLView>("2564c3d0-c21b-4eba-9e22-3bedc3eb3246","","",false, this);
 
            AddressDescription = RPSControlFactory.CreateRPSTextBox<OrderLineSLView>("e6d28ac5-59e6-4b26-a0ad-023fc70a0eb5","","",false, this);
 
            CityDelivery = RPSControlFactory.CreateRPSTextBox<OrderLineSLView>("9219bbba-eac4-4b14-8a4e-e86c5312c3e9","","",false, this);
 
            ContactPersonDelivery = RPSControlFactory.CreateRPSTextBox<OrderLineSLView>("e7bd9232-9fb1-4132-9a32-5bc715af65c9","","",false, this);
 
            Phone1Delivery = RPSControlFactory.CreateRPSTextBox<OrderLineSLView>("915b92bf-3276-4b63-a769-75b03be3c472","","",false, this);
 
            Phone2Delivery = RPSControlFactory.CreateRPSTextBox<OrderLineSLView>("4808a991-6458-411c-a3ad-41fde8b01220","","",false, this);
 
            FaxDelivery = RPSControlFactory.CreateRPSTextBox<OrderLineSLView>("94c43bab-930a-4a08-8390-91c7a34464ee","","",false, this);
 
            PriceBase = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineSLView>("f38f9be6-ab99-4214-a85f-c8b02911b6f4","","",true, this);
 
            UIconditionPrice = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineSLView>("a6ce964f-f39a-4106-9054-45d4ed5e81d4","","",false, this);
 
            OrderLineSLGetDimensionsCommandButton = RPSControlFactory.CreateRPSButton<OrderLineSLView>( "266efe6d-6e1b-4d83-a1bf-9a7519b48fa1","","",this);
 
            UpdateTechnicalDescriptionCommand = RPSControlFactory.CreateRPSButton<OrderLineSLView>( "e08893fc-8312-4127-bd00-af342c6a8431","","",this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<OrderLineSLView>("8166dc22-c1f1-4c83-a925-28802614ebc0","","",false, this);
 
            PlanNumber = RPSControlFactory.CreateRPSTextBox<OrderLineSLView>("1f2823d0-740b-4a2a-a251-6cd43966c87d","","",false, this);
 
            BlockedMRP = RPSControlFactory.CreateRPSCheckBox<OrderLineSLView>("5bdb02cf-5418-4b04-9cea-8096db18ecf4","","",true, this);
 
            ArticleAlternativeChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<OrderLineSLView,ArticleAlternativeChildDialogView>("47882e1b-e7c3-442e-ab97-ef3449409473","","", this,Screen.ArticleAlternativeChildDialogView);
 
            CopyLineCommandButton = RPSControlFactory.CreateRPSButton<OrderLineSLView>( "184af494-18cf-488b-b3e0-c3e90b4ac95b","","",this);
 
            ExecuteOrderLineCreateManufacturingOrderFromSalesButton = RPSControlFactory.CreateRPSButton<OrderLineSLView>( "e37aed13-f442-4f9c-a104-eddedf16abd8","","",this);
 
            DueDateCalculationNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<OrderLineSLView,DueDateCalculationDialogView>("139bf07c-9a37-44ee-b83e-a83e90e5819a","","", this,Screen.DueDateCalculationDialogView);
 
            RelatedFWCManagementChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<OrderLineSLView,RelatedFWCManagementChildDialogView>("a584875c-566b-4c0c-990b-bfeb0ebb3b2f","","", this,Screen.RelatedFWCManagementChildDialogView);
 
            AnalyticChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<OrderLineSLView,AnalyticChildDialogView>("b244c76f-9860-43a7-be1a-c40e5ca26468","","", this,Screen.AnalyticChildDialogView);
 
            ReserveChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<OrderLineSLView,ReserveChildDialogView>("5573f19c-890d-492b-a72d-4d4a0e330a9c","","", this,Screen.ReserveChildDialogView);
 
            CollectionInit params_OrderLineTaxSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f793b871-f104-40e7-9a1f-dcbfd254c6a2",CSSSelectorGrid="",XPathGrid=""};
            OrderLineTaxSLs = RPSControlFactory.RPSCreateCollectionWithGrid<OrderLineTaxSLsCollectionEditor<OrderLineSLView,OrderLineCommercialAgentSLView>,OrderLineSLView,OrderLineCommercialAgentSLView>( params_OrderLineTaxSLs,this,Screen.OrderLineCommercialAgentSLView);
 
            CollectionInit params_OrderLineConditionSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="be7e995a-c260-4a4f-88ac-1096fbc45b83",CSSSelectorGrid="",XPathGrid=""};
            OrderLineConditionSLs = RPSControlFactory.RPSCreateCollectionWithGrid<OrderLineConditionSLsCollectionEditor<OrderLineSLView,OrderLineCommercialAgentSLView>,OrderLineSLView,OrderLineCommercialAgentSLView>( params_OrderLineConditionSLs,this,Screen.OrderLineCommercialAgentSLView);
 
            CollectionInit params_OrderLineAnalyticSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="49d793a4-6d35-4910-a962-268ceb0f2f18",CSSSelectorGrid="",XPathGrid=""};
            OrderLineAnalyticSLs = RPSControlFactory.RPSCreateCollectionWithGrid<OrderLineAnalyticSLsCollectionEditor<OrderLineSLView,OrderLineCommercialAgentSLView>,OrderLineSLView,OrderLineCommercialAgentSLView>( params_OrderLineAnalyticSLs,this,Screen.OrderLineCommercialAgentSLView);
 
            CollectionInit params_OrderLineCommercialAgentSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="9094aa79-8bc7-443a-b0b1-21cbbde47790",CSSSelectorGrid="",XPathGrid=""};
            OrderLineCommercialAgentSLs = RPSControlFactory.RPSCreateCollectionWithGrid<OrderLineCommercialAgentSLsCollectionEditor<OrderLineSLView,OrderLineCommercialAgentSLView>,OrderLineSLView,OrderLineCommercialAgentSLView>( params_OrderLineCommercialAgentSLs,this,Screen.OrderLineCommercialAgentSLView);
 
            CollectionInit params_OrderLineProposalSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1f9c34f1-7743-4ab9-a7a0-5d105938b2e3",CSSSelectorGrid="",XPathGrid=""};
            OrderLineProposalSLs = RPSControlFactory.RPSCreateCollectionWithGrid<OrderLineProposalSLsCollectionEditor<OrderLineSLView,OrderLineCommercialAgentSLView>,OrderLineSLView,OrderLineCommercialAgentSLView>( params_OrderLineProposalSLs,this,Screen.OrderLineCommercialAgentSLView);
 
            GeneralDataSection = RPSControlFactory.CreateRPSSection<OrderLineSLView>( "","ul li[rpsid='9bbf1ab6-9ea7-48c4-b4f4-e144bbe42460']","",this);
 
            TaxSection = RPSControlFactory.CreateRPSSection<OrderLineSLView>( "","ul li[rpsid='dcbc7b72-94b7-4901-977f-34717d6c2726']","",this);
 
            SpecialConditionsSection = RPSControlFactory.CreateRPSSection<OrderLineSLView>( "","ul li[rpsid='a26732f3-2909-4757-9074-cacec134b7e5']","",this);
 
            AnalyticSection = RPSControlFactory.CreateRPSSection<OrderLineSLView>( "","ul li[rpsid='0b25858a-cd86-4c3d-ba71-cf6ada03e8e0']","",this);
 
            CommercialAgent = RPSControlFactory.CreateRPSSection<OrderLineSLView>( "","ul li[rpsid='31281213-ee2a-4056-be86-d09764b00b27']","",this);
 
            Proposals = RPSControlFactory.CreateRPSSection<OrderLineSLView>( "","ul li[rpsid='9b197d69-132d-496d-8fa9-c44c40730d89']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<OrderLineSLView>( "","ul li[rpsid='e2aaae4d-639a-4370-9fe8-18045d6de65b']","",this);
 
            DPS = RPSControlFactory.CreateRPSSection<OrderLineSLView>( "","ul li[rpsid='e4234416-d451-440f-80d1-83f2a7f3835a']","",this);
 

        }
        public IRPSButton<OrderLineSLView> DeleteButton { get; set; } 
        public IRPSButton<OrderLineSLView,OrderSLEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<OrderLineSLView,OrderSLEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<OrderLineSLView,OrderSLEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<OrderLineSLView> IDArticle { get; set; } 
        public IRPSTextBox<OrderLineSLView> Quantity { get; set; } 
        public IRPSTextBox<OrderLineSLView> Price { get; set; } 
        public IRPSCheckbox<OrderLineSLView> VAT { get; set; } 
        public IRPSTextBox<OrderLineSLView> Amount { get; set; } 
        public IRPSTextBox<OrderLineSLView> AmountWithVAT { get; set; } 
        public IRPSTextBox<OrderLineSLView> Description { get; set; } 
        public IRPSComboBox<OrderLineSLView> ReferenceCustomer { get; set; } 
        public IRPSComboBox<OrderLineSLView> IDUnitQuantity { get; set; } 
        public IRPSTextBox<OrderLineSLView> ConversionFactorQuantity { get; set; } 
        public IRPSTextBox<OrderLineSLView> QuantitySecondUnit { get; set; } 
        public IRPSTextBox<OrderLineSLView> Dimension1 { get; set; } 
        public IRPSTextBox<OrderLineSLView> Dimension2 { get; set; } 
        public IRPSTextBox<OrderLineSLView> Dimension3 { get; set; } 
        public IRPSComboBox<OrderLineSLView> IDUnitPrice { get; set; } 
        public IRPSTextBox<OrderLineSLView> ConversionFactorPrice { get; set; } 
        public IRPSTextBox<OrderLineSLView> Cost { get; set; } 
        public IRPSComboBox<OrderLineSLView> Series { get; set; } 
        public IRPSTextBox<OrderLineSLView> Ordenation { get; set; } 
        public IRPSTextBox<OrderLineSLView> Index { get; set; } 
        public IRPSCheckbox<OrderLineSLView> Delivered { get; set; } 
        public IRPSCheckbox<OrderLineSLView> PendingDelivery { get; set; } 
        public IRPSTextBox<OrderLineSLView> DeliveredQuantity { get; set; } 
        public IRPSTextBox<OrderLineSLView> DeliveredQuantitySecondUnit { get; set; } 
        public IRPSTextBox<OrderLineSLView> ReceptionDate { get; set; } 
        public IRPSComboBox<OrderLineSLView> IDArticleVersion { get; set; } 
        public IRPSCheckbox<OrderLineSLView> Invoice { get; set; } 
        public IRPSCheckbox<OrderLineSLView> Invoiced { get; set; } 
        public IRPSTextBox<OrderLineSLView> InvoicedQuantity { get; set; } 
        public IRPSTextBox<OrderLineSLView> InvoicedQuantitySecondUnit { get; set; } 
        public IRPSTextBox<OrderLineSLView> ReceptionDemandDate { get; set; } 
        public IRPSCheckbox<OrderLineSLView> Queue { get; set; } 
        public IRPSTextBox<OrderLineSLView> Discount1 { get; set; } 
        public IRPSCheckbox<OrderLineSLView> CascadeDiscount1 { get; set; } 
        public IRPSTextBox<OrderLineSLView> Discount2 { get; set; } 
        public IRPSCheckbox<OrderLineSLView> CascadeDiscount2 { get; set; } 
        public IRPSTextBox<OrderLineSLView> Discount3 { get; set; } 
        public IRPSCheckbox<OrderLineSLView> CascadeDiscount3 { get; set; } 
        public IRPSTextBox<OrderLineSLView> Discount4 { get; set; } 
        public IRPSCheckbox<OrderLineSLView> CascadeDiscount4 { get; set; } 
        public IRPSTextBox<OrderLineSLView> Discount5 { get; set; } 
        public IRPSCheckbox<OrderLineSLView> CascadeDiscount5 { get; set; } 
        public IRPSTextBox<OrderLineSLView> AmountDiscount { get; set; } 
        public IRPSComboBox<OrderLineSLView> PositionAmountDiscount { get; set; } 
        public IRPSComboBox<OrderLineSLView> IDSite { get; set; } 
        public IRPSComboBox<OrderLineSLView> IDWarehouse { get; set; } 
        public IRPSComboBox<OrderLineSLView> IDSiteTransfer { get; set; } 
        public IRPSComboBox<OrderLineSLView> IDWarehouseTransfer { get; set; } 
        public IRPSComboBox<OrderLineSLView> IDVAT { get; set; } 
        public IRPSTextBox<OrderLineSLView> PercentVAT { get; set; } 
        public IRPSComboBox<OrderLineSLView> IDVATSurcharge { get; set; } 
        public IRPSTextBox<OrderLineSLView> PercentSurcharge { get; set; } 
        public IRPSComboBox<OrderLineSLView> IDDeliveryNoteType { get; set; } 
        public IRPSComboBox<OrderLineSLView> IDAccount { get; set; } 
        public IRPSComboBox<OrderLineSLView> IDReturnCause { get; set; } 
        public IRPSCheckbox<OrderLineSLView> GeneratedPurchase { get; set; } 
        public IRPSComboBox<OrderLineSLView> IDOrderLineKit { get; set; } 
        public IRPSTextBox<OrderLineSLView> CostPercentage { get; set; } 
        public IRPSTextBox<OrderLineSLView> NumProm { get; set; } 
        public IRPSCheckbox<OrderLineSLView> Rappel { get; set; } 
        public IRPSTextBox<OrderLineSLView> InternalCode { get; set; } 
        public IRPSComboBox<OrderLineSLView> IDMaintenanceComponent { get; set; } 
        public IRPSTextBox<OrderLineSLView> SerialNumber { get; set; } 
        public IRPSComboBox<OrderLineSLView> IDManufacturingOrder { get; set; } 
        public IRPSTextBox<OrderLineSLView> UICodSalesQuoteAndOrdenation { get; set; } 
        public IRPSComboBox<OrderLineSLView> IDFrameworkContractSL { get; set; } 
        public IRPSTextBox<OrderLineSLView> FrameworkContractLineNumber { get; set; } 
        public IRPSComboBox<OrderLineSLView> IDDeliveryAdress { get; set; } 
        public IRPSComboBox<OrderLineSLView> CodCountryDelivery { get; set; } 
        public IRPSComboBox<OrderLineSLView> IDStateDelivery { get; set; } 
        public IRPSTextBox<OrderLineSLView> ZipCodeDelivery { get; set; } 
        public IRPSComboBox<OrderLineSLView> IDCountyDelivery { get; set; } 
        public IRPSTextBox<OrderLineSLView> AddressDelivery { get; set; } 
        public IRPSTextBox<OrderLineSLView> AddressDescription { get; set; } 
        public IRPSTextBox<OrderLineSLView> CityDelivery { get; set; } 
        public IRPSTextBox<OrderLineSLView> ContactPersonDelivery { get; set; } 
        public IRPSTextBox<OrderLineSLView> Phone1Delivery { get; set; } 
        public IRPSTextBox<OrderLineSLView> Phone2Delivery { get; set; } 
        public IRPSTextBox<OrderLineSLView> FaxDelivery { get; set; } 
        public IRPSTextBox<OrderLineSLView> PriceBase { get; set; } 
        public IRPSTextBox<OrderLineSLView> UIconditionPrice { get; set; } 
        public IRPSButton<OrderLineSLView> OrderLineSLGetDimensionsCommandButton { get; set; } 
        public IRPSButton<OrderLineSLView> UpdateTechnicalDescriptionCommand { get; set; } 
        public IRPSTextBox<OrderLineSLView> Comment { get; set; } 
        public IRPSTextBox<OrderLineSLView> PlanNumber { get; set; } 
        public IRPSCheckbox<OrderLineSLView> BlockedMRP { get; set; } 
        public IRPSButton<OrderLineSLView,ArticleAlternativeChildDialogView> ArticleAlternativeChildNavigationCommandButton { get; set; } 
        public IRPSButton<OrderLineSLView> CopyLineCommandButton { get; set; } 
        public IRPSButton<OrderLineSLView> ExecuteOrderLineCreateManufacturingOrderFromSalesButton { get; set; } 
        public IRPSButton<OrderLineSLView,DueDateCalculationDialogView> DueDateCalculationNavigationCommandButton { get; set; } 
        public IRPSButton<OrderLineSLView,RelatedFWCManagementChildDialogView> RelatedFWCManagementChildNavigationCommandButton { get; set; } 
        public IRPSButton<OrderLineSLView,AnalyticChildDialogView> AnalyticChildNavigationCommandButton { get; set; } 
        public IRPSButton<OrderLineSLView,ReserveChildDialogView> ReserveChildNavigationCommandButton { get; set; } 
        public OrderLineTaxSLsCollectionEditor<OrderLineSLView,OrderLineCommercialAgentSLView> OrderLineTaxSLs { get; set; } 
        public OrderLineConditionSLsCollectionEditor<OrderLineSLView,OrderLineCommercialAgentSLView> OrderLineConditionSLs { get; set; } 
        public OrderLineAnalyticSLsCollectionEditor<OrderLineSLView,OrderLineCommercialAgentSLView> OrderLineAnalyticSLs { get; set; } 
        public OrderLineCommercialAgentSLsCollectionEditor<OrderLineSLView,OrderLineCommercialAgentSLView> OrderLineCommercialAgentSLs { get; set; } 
        public OrderLineProposalSLsCollectionEditor<OrderLineSLView,OrderLineCommercialAgentSLView> OrderLineProposalSLs { get; set; } 
        public IRPSSection<OrderLineSLView> GeneralDataSection { get; set; } 
        public IRPSSection<OrderLineSLView> TaxSection { get; set; } 
        public IRPSSection<OrderLineSLView> SpecialConditionsSection { get; set; } 
        public IRPSSection<OrderLineSLView> AnalyticSection { get; set; } 
        public IRPSSection<OrderLineSLView> CommercialAgent { get; set; } 
        public IRPSSection<OrderLineSLView> Proposals { get; set; } 
        public IRPSSection<OrderLineSLView> Comments { get; set; } 
        public IRPSSection<OrderLineSLView> DPS { get; set; } 
        public OrderSL Screen { get; set; }
        public OrderLineSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class OrderLineTaxSLsCollectionEditor<OrderLineSLView,OrderLineCommercialAgentSLView>:RPSCollectionEditor<OrderLineSLView,OrderLineCommercialAgentSLView> where OrderLineSLView : class, IView where OrderLineCommercialAgentSLView : class, IView
    {
        public  OrderLineTaxSLsGridView<OrderLineSLView,OrderLineCommercialAgentSLView> GridView {get;set;}
    }
    public partial class OrderLineTaxSLsGridView <OrderLineSLView,OrderLineCommercialAgentSLView> :  RPSGridView<OrderLineSLView,OrderLineCommercialAgentSLView> where OrderLineSLView : class, IView where OrderLineCommercialAgentSLView : class, IView
    {
        public OrderLineTaxSLsGridView(OrderLineSLView currentView,OrderLineCommercialAgentSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDTaxValue = RPSControlFactory.CreateRPSGridComboBox<OrderLineSLView>("","#f793b871-f104-40e7-9a1f-dcbfd254c6a2 .ag-row[role='row']@ROWINDEX [col-id='cIDTaxValue']","",true, this.CurrentView);
 
            ApplicationType = RPSControlFactory.CreateRPSGridEnumComboBox<OrderLineSLView>("","#f793b871-f104-40e7-9a1f-dcbfd254c6a2 .ag-row[role='row']@ROWINDEX [col-id='cApplicationType']","",true, this.CurrentView);
 
            BaseType = RPSControlFactory.CreateRPSGridEnumComboBox<OrderLineSLView>("","#f793b871-f104-40e7-9a1f-dcbfd254c6a2 .ag-row[role='row']@ROWINDEX [col-id='cBaseType']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<OrderLineSLView>("","#f793b871-f104-40e7-9a1f-dcbfd254c6a2 .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            Value = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderLineSLView>("","#f793b871-f104-40e7-9a1f-dcbfd254c6a2 .ag-row[role='row']@ROWINDEX [col-id='cValue']","",true, this.CurrentView);
 
            VAT = RPSControlFactory.CreateRPSGridCheckBox<OrderLineSLView>("","#f793b871-f104-40e7-9a1f-dcbfd254c6a2 .ag-row[role='row']@ROWINDEX [col-id='cVAT']","",true, this.CurrentView);
 
            PriceIncluded = RPSControlFactory.CreateRPSGridCheckBox<OrderLineSLView>("","#f793b871-f104-40e7-9a1f-dcbfd254c6a2 .ag-row[role='row']@ROWINDEX [col-id='cPriceIncluded']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<OrderLineSLView> IDTaxValue { get; set; } 
        public IRPSGridComboBox<OrderLineSLView> ApplicationType { get; set; } 
        public IRPSGridComboBox<OrderLineSLView> BaseType { get; set; } 
        public IRPSGridComboBox<OrderLineSLView> Type { get; set; } 
        public IRPSGridTextBox<OrderLineSLView> Value { get; set; } 
        public IRPSGridCheckbox<OrderLineSLView> VAT { get; set; } 
        public IRPSGridCheckbox<OrderLineSLView> PriceIncluded { get; set; } 
                     
    }
 
        public partial class OrderLineConditionSLsCollectionEditor<OrderLineSLView,OrderLineCommercialAgentSLView>:RPSCollectionEditor<OrderLineSLView,OrderLineCommercialAgentSLView> where OrderLineSLView : class, IView where OrderLineCommercialAgentSLView : class, IView
    {
        public  OrderLineConditionSLsGridView<OrderLineSLView,OrderLineCommercialAgentSLView> GridView {get;set;}
    }
    public partial class OrderLineConditionSLsGridView <OrderLineSLView,OrderLineCommercialAgentSLView> :  RPSGridView<OrderLineSLView,OrderLineCommercialAgentSLView> where OrderLineSLView : class, IView where OrderLineCommercialAgentSLView : class, IView
    {
        public OrderLineConditionSLsGridView(OrderLineSLView currentView,OrderLineCommercialAgentSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<OrderLineSLView>("","#be7e995a-c260-4a4f-88ac-1096fbc45b83 .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            ConditionValueOriginal = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderLineSLView>("","#be7e995a-c260-4a4f-88ac-1096fbc45b83 .ag-row[role='row']@ROWINDEX [col-id='cConditionValueOriginal']","",true, this.CurrentView);
 
            ConditionValue = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderLineSLView>("","#be7e995a-c260-4a4f-88ac-1096fbc45b83 .ag-row[role='row']@ROWINDEX [col-id='cConditionValue']","",true, this.CurrentView);
 
            Base = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderLineSLView>("","#be7e995a-c260-4a4f-88ac-1096fbc45b83 .ag-row[role='row']@ROWINDEX [col-id='cBase']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderLineSLView>("","#be7e995a-c260-4a4f-88ac-1096fbc45b83 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            ConditionType = RPSControlFactory.CreateRPSGridEnumComboBox<OrderLineSLView>("","#be7e995a-c260-4a4f-88ac-1096fbc45b83 .ag-row[role='row']@ROWINDEX [col-id='cConditionType']","",true, this.CurrentView);
 
            BaseApply = RPSControlFactory.CreateRPSGridEnumComboBox<OrderLineSLView>("","#be7e995a-c260-4a4f-88ac-1096fbc45b83 .ag-row[role='row']@ROWINDEX [col-id='cBaseApply']","",true, this.CurrentView);
 
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<OrderLineSLView>("","#be7e995a-c260-4a4f-88ac-1096fbc45b83 .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",true, this.CurrentView);
 
            DateTo = RPSControlFactory.CreateRPSGridTextBox<OrderLineSLView>("","#be7e995a-c260-4a4f-88ac-1096fbc45b83 .ag-row[role='row']@ROWINDEX [col-id='cDateTo']","",true, this.CurrentView);
 
            AffectsPrice = RPSControlFactory.CreateRPSGridCheckBox<OrderLineSLView>("","#be7e995a-c260-4a4f-88ac-1096fbc45b83 .ag-row[role='row']@ROWINDEX [col-id='cAffectsPrice']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<OrderLineSLView> Type { get; set; } 
        public IRPSGridTextBox<OrderLineSLView> ConditionValueOriginal { get; set; } 
        public IRPSGridTextBox<OrderLineSLView> ConditionValue { get; set; } 
        public IRPSGridTextBox<OrderLineSLView> Base { get; set; } 
        public IRPSGridTextBox<OrderLineSLView> Amount { get; set; } 
        public IRPSGridComboBox<OrderLineSLView> ConditionType { get; set; } 
        public IRPSGridComboBox<OrderLineSLView> BaseApply { get; set; } 
        public IRPSGridTextBox<OrderLineSLView> DateFrom { get; set; } 
        public IRPSGridTextBox<OrderLineSLView> DateTo { get; set; } 
        public IRPSGridCheckbox<OrderLineSLView> AffectsPrice { get; set; } 
                     
    }
 
        public partial class OrderLineAnalyticSLsCollectionEditor<OrderLineSLView,OrderLineCommercialAgentSLView>:RPSCollectionEditor<OrderLineSLView,OrderLineCommercialAgentSLView> where OrderLineSLView : class, IView where OrderLineCommercialAgentSLView : class, IView
    {
        public  OrderLineAnalyticSLsGridView<OrderLineSLView,OrderLineCommercialAgentSLView> GridView {get;set;}
    }
    public partial class OrderLineAnalyticSLsGridView <OrderLineSLView,OrderLineCommercialAgentSLView> :  RPSGridView<OrderLineSLView,OrderLineCommercialAgentSLView> where OrderLineSLView : class, IView where OrderLineCommercialAgentSLView : class, IView
    {
        public OrderLineAnalyticSLsGridView(OrderLineSLView currentView,OrderLineCommercialAgentSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDDimension = RPSControlFactory.CreateRPSGridComboBox<OrderLineSLView>("","#49d793a4-6d35-4910-a962-268ceb0f2f18 .ag-row[role='row']@ROWINDEX [col-id='cIDDimension']","",true, this.CurrentView);
 
            IDDimValue = RPSControlFactory.CreateRPSGridComboBox<OrderLineSLView>("","#49d793a4-6d35-4910-a962-268ceb0f2f18 .ag-row[role='row']@ROWINDEX [col-id='cIDDimValue']","",true, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderLineSLView>("","#49d793a4-6d35-4910-a962-268ceb0f2f18 .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderLineSLView>("","#49d793a4-6d35-4910-a962-268ceb0f2f18 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<OrderLineSLView> IDDimension { get; set; } 
        public IRPSGridComboBox<OrderLineSLView> IDDimValue { get; set; } 
        public IRPSGridTextBox<OrderLineSLView> Percentage { get; set; } 
        public IRPSGridTextBox<OrderLineSLView> Amount { get; set; } 
                     
    }
 
        public partial class OrderLineCommercialAgentSLsCollectionEditor<OrderLineSLView,OrderLineCommercialAgentSLView>:RPSCollectionEditor<OrderLineSLView,OrderLineCommercialAgentSLView> where OrderLineSLView : class, IView where OrderLineCommercialAgentSLView : class, IView
    {
        public  OrderLineCommercialAgentSLsGridView<OrderLineSLView,OrderLineCommercialAgentSLView> GridView {get;set;}
    }
    public partial class OrderLineCommercialAgentSLsGridView <OrderLineSLView,OrderLineCommercialAgentSLView> :  RPSGridView<OrderLineSLView,OrderLineCommercialAgentSLView> where OrderLineSLView : class, IView where OrderLineCommercialAgentSLView : class, IView
    {
        public OrderLineCommercialAgentSLsGridView(OrderLineSLView currentView,OrderLineCommercialAgentSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDCommercialAgent = RPSControlFactory.CreateRPSGridComboBox<OrderLineSLView>("","#9094aa79-8bc7-443a-b0b1-21cbbde47790 .ag-row[role='row']@ROWINDEX [col-id='cIDCommercialAgent']","",true, this.CurrentView);
 
            IDCommercialAgentClassification = RPSControlFactory.CreateRPSGridComboBox<OrderLineSLView>("","#9094aa79-8bc7-443a-b0b1-21cbbde47790 .ag-row[role='row']@ROWINDEX [col-id='cIDCommercialAgentClassification']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<OrderLineSLView>("","#9094aa79-8bc7-443a-b0b1-21cbbde47790 .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            Commission = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderLineSLView>("","#9094aa79-8bc7-443a-b0b1-21cbbde47790 .ag-row[role='row']@ROWINDEX [col-id='cCommission']","",true, this.CurrentView);
 
            CommissionAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderLineSLView>("","#9094aa79-8bc7-443a-b0b1-21cbbde47790 .ag-row[role='row']@ROWINDEX [col-id='cCommissionAmount']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<OrderLineSLView> IDCommercialAgent { get; set; } 
        public IRPSGridComboBox<OrderLineSLView> IDCommercialAgentClassification { get; set; } 
        public IRPSGridComboBox<OrderLineSLView> Type { get; set; } 
        public IRPSGridTextBox<OrderLineSLView> Commission { get; set; } 
        public IRPSGridTextBox<OrderLineSLView> CommissionAmount { get; set; } 
                     
    }
 
        public partial class OrderLineProposalSLsCollectionEditor<OrderLineSLView,OrderLineCommercialAgentSLView>:RPSCollectionEditor<OrderLineSLView,OrderLineCommercialAgentSLView> where OrderLineSLView : class, IView where OrderLineCommercialAgentSLView : class, IView
    {
        public  OrderLineProposalSLsGridView<OrderLineSLView,OrderLineCommercialAgentSLView> GridView {get;set;}
    }
    public partial class OrderLineProposalSLsGridView <OrderLineSLView,OrderLineCommercialAgentSLView> :  RPSGridView<OrderLineSLView,OrderLineCommercialAgentSLView> where OrderLineSLView : class, IView where OrderLineCommercialAgentSLView : class, IView
    {
        public OrderLineProposalSLsGridView(OrderLineSLView currentView,OrderLineCommercialAgentSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDSite = RPSControlFactory.CreateRPSGridComboBox<OrderLineSLView>("","#1f9c34f1-7743-4ab9-a7a0-5d105938b2e3 .ag-row[role='row']@ROWINDEX [col-id='cIDSite']","",true, this.CurrentView);
 
            IDWarehouse = RPSControlFactory.CreateRPSGridComboBox<OrderLineSLView>("","#1f9c34f1-7743-4ab9-a7a0-5d105938b2e3 .ag-row[role='row']@ROWINDEX [col-id='cIDWarehouse']","",true, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderLineSLView>("","#1f9c34f1-7743-4ab9-a7a0-5d105938b2e3 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderLineSLView>("","#1f9c34f1-7743-4ab9-a7a0-5d105938b2e3 .ag-row[role='row']@ROWINDEX [col-id='cQuantitySecondUnit']","",true, this.CurrentView);
 
            IDLocationWarehouse = RPSControlFactory.CreateRPSGridComboBox<OrderLineSLView>("","#1f9c34f1-7743-4ab9-a7a0-5d105938b2e3 .ag-row[role='row']@ROWINDEX [col-id='cIDLocationWarehouse']","",false, this.CurrentView);
 
            Series = RPSControlFactory.CreateRPSGridEnumComboBox<OrderLineSLView>("","#1f9c34f1-7743-4ab9-a7a0-5d105938b2e3 .ag-row[role='row']@ROWINDEX [col-id='cSeries']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<OrderLineSLView> IDSite { get; set; } 
        public IRPSGridComboBox<OrderLineSLView> IDWarehouse { get; set; } 
        public IRPSGridTextBox<OrderLineSLView> Quantity { get; set; } 
        public IRPSGridTextBox<OrderLineSLView> QuantitySecondUnit { get; set; } 
        public IRPSGridComboBox<OrderLineSLView> IDLocationWarehouse { get; set; } 
        public IRPSGridComboBox<OrderLineSLView> Series { get; set; } 
                     
    }
 
    }
  
            
    public partial class OrderAdvanceSLView : View
    {
        public OrderAdvanceSLView(OrderSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<OrderAdvanceSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<OrderAdvanceSLView,OrderSLEntityView>( this,Screen.OrderSLEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<OrderAdvanceSLView,OrderSLEntityView>( this,Screen.OrderSLEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<OrderAdvanceSLView,OrderSLEntityView>( this,Screen.OrderSLEntityView);
 
            NumAdvance = RPSControlFactory.CreateRPSFormattedTextBox<OrderAdvanceSLView>("e2c37804-f560-49b1-91e5-a13853d16f72","","",true, this);
 
            AdvanceDate = RPSControlFactory.CreateRPSTextBox<OrderAdvanceSLView>("2b61b86b-adaf-45e6-aa6e-b8e9864a6c6c","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<OrderAdvanceSLView>("18e63fcd-8670-4c09-98d7-b8839490e74b","","",false, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<OrderAdvanceSLView>("af115cd5-76c0-4f89-9e74-9c732d75c845","","",true, this);
 
            VAT = RPSControlFactory.CreateRPSCheckBox<OrderAdvanceSLView>("d399292f-7f74-4716-9aff-cdffa17dfe36","","",true, this);
 
            AmountRecalculated = RPSControlFactory.CreateRPSFormattedTextBox<OrderAdvanceSLView>("914ae280-a5d5-4608-86dd-e2261b322c04","","",true, this);
 
            Invoice = RPSControlFactory.CreateRPSCheckBox<OrderAdvanceSLView>("ede22034-8053-4bce-938a-785acb511164","","",true, this);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSComboBox<OrderAdvanceSLView>("1083e988-d47f-43ba-8a6f-26f634a682f9","","",false, this);
 
            Invoiced = RPSControlFactory.CreateRPSCheckBox<OrderAdvanceSLView>("c054d6e3-7293-4aa8-b17d-3ec9e1cbd33e","","",true, this);
 
            IDCodingSerieInvoice = RPSControlFactory.CreateRPSComboBox<OrderAdvanceSLView>("3b1299c0-ba3b-4033-915d-a9e76b845fd4","","",false, this);
 
            IDVATType = RPSControlFactory.CreateRPSComboBox<OrderAdvanceSLView>("801eff35-1798-4258-bfa3-a876133a5705","","",false, this);
 
            IDVAT = RPSControlFactory.CreateRPSComboBox<OrderAdvanceSLView>("f0239e2a-eae3-4b8e-b07f-8cdf9a120e89","","",false, this);
 
            PercentVAT = RPSControlFactory.CreateRPSFormattedTextBox<OrderAdvanceSLView>("c68e0004-dbc4-4a0b-906a-ae215385d21f","","",true, this);
 
            PercentSurcharge = RPSControlFactory.CreateRPSFormattedTextBox<OrderAdvanceSLView>("a9ee53ec-6aea-459f-90c9-d2f894d55f54","","",true, this);
 
            TaxType = RPSControlFactory.CreateRPSEnumComboBox<OrderAdvanceSLView>("219546e3-2822-4540-8ddb-2de59188a8bf","","",true, this);
 
            IDTaxGroup = RPSControlFactory.CreateRPSComboBox<OrderAdvanceSLView>("9b39e156-5111-4f88-984a-3f89a06c40b0","","",false, this);
 
            PreTextIDTextLine = RPSControlFactory.CreateRPSComboBox<OrderAdvanceSLView>("76a2961f-d8a2-4786-af1c-b9a86a2d5ef7","","",false, this);
 
            PreText = RPSControlFactory.CreateRPSTextBox<OrderAdvanceSLView>("77113aac-574d-4bbb-b278-19fbb9bb333a","","",false, this);
 
            PostTextIDTextLine = RPSControlFactory.CreateRPSComboBox<OrderAdvanceSLView>("4ad4c920-520b-4eef-ba42-4ef0b85f77a5","","",false, this);
 
            PostText = RPSControlFactory.CreateRPSTextBox<OrderAdvanceSLView>("58c4382a-4b13-4456-872f-c056567c949c","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<OrderAdvanceSLView>("67a23191-0b6c-44c1-99e3-0c9c9641eaf5","","",false, this);
 
            InvoiceAdvanceCommandButton = RPSControlFactory.CreateRPSButton<OrderAdvanceSLView>( "b70d7581-2f56-4a9e-8aeb-7c4e89904fc7","","",this);
 
            OrderAdvanceSLChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<OrderAdvanceSLView,OrderAdvanceSLChildDialogView>("99cc6eae-dafe-4deb-97d0-c613eea19f92","","", this,Screen.OrderAdvanceSLChildDialogView);
 
            CollectionInit params_OrderAdvanceTaxSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1be480cb-4b06-40f4-90c0-e5d99a1eb0f4",CSSSelectorGrid="",XPathGrid=""};
            OrderAdvanceTaxSLs = RPSControlFactory.RPSCreateCollectionWithGrid<OrderAdvanceTaxSLsCollectionEditor<OrderAdvanceSLView,OrderAdvanceTaxSLView>,OrderAdvanceSLView,OrderAdvanceTaxSLView>( params_OrderAdvanceTaxSLs,this,Screen.OrderAdvanceTaxSLView);
 
            GeneralDataSection = RPSControlFactory.CreateRPSSection<OrderAdvanceSLView>( "","ul li[rpsid='c927af82-6602-4908-9a5c-de23577eed1a']","",this);
 
            TaxSection = RPSControlFactory.CreateRPSSection<OrderAdvanceSLView>( "","ul li[rpsid='25775d27-40f0-4eee-a4ac-404318536cb3']","",this);
 
            TextLineSection = RPSControlFactory.CreateRPSSection<OrderAdvanceSLView>( "","ul li[rpsid='7f2ad739-083f-400c-900b-460b51ef7b41']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<OrderAdvanceSLView>( "","ul li[rpsid='3c5e9e99-052e-4469-b798-3b1fec63ba4c']","",this);
 

        }
        public IRPSButton<OrderAdvanceSLView> DeleteButton { get; set; } 
        public IRPSButton<OrderAdvanceSLView,OrderSLEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<OrderAdvanceSLView,OrderSLEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<OrderAdvanceSLView,OrderSLEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<OrderAdvanceSLView> NumAdvance { get; set; } 
        public IRPSTextBox<OrderAdvanceSLView> AdvanceDate { get; set; } 
        public IRPSTextBox<OrderAdvanceSLView> Description { get; set; } 
        public IRPSTextBox<OrderAdvanceSLView> Amount { get; set; } 
        public IRPSCheckbox<OrderAdvanceSLView> VAT { get; set; } 
        public IRPSTextBox<OrderAdvanceSLView> AmountRecalculated { get; set; } 
        public IRPSCheckbox<OrderAdvanceSLView> Invoice { get; set; } 
        public IRPSComboBox<OrderAdvanceSLView> IDPaymentMethod { get; set; } 
        public IRPSCheckbox<OrderAdvanceSLView> Invoiced { get; set; } 
        public IRPSComboBox<OrderAdvanceSLView> IDCodingSerieInvoice { get; set; } 
        public IRPSComboBox<OrderAdvanceSLView> IDVATType { get; set; } 
        public IRPSComboBox<OrderAdvanceSLView> IDVAT { get; set; } 
        public IRPSTextBox<OrderAdvanceSLView> PercentVAT { get; set; } 
        public IRPSTextBox<OrderAdvanceSLView> PercentSurcharge { get; set; } 
        public IRPSComboBox<OrderAdvanceSLView> TaxType { get; set; } 
        public IRPSComboBox<OrderAdvanceSLView> IDTaxGroup { get; set; } 
        public IRPSComboBox<OrderAdvanceSLView> PreTextIDTextLine { get; set; } 
        public IRPSTextBox<OrderAdvanceSLView> PreText { get; set; } 
        public IRPSComboBox<OrderAdvanceSLView> PostTextIDTextLine { get; set; } 
        public IRPSTextBox<OrderAdvanceSLView> PostText { get; set; } 
        public IRPSTextBox<OrderAdvanceSLView> Comment { get; set; } 
        public IRPSButton<OrderAdvanceSLView> InvoiceAdvanceCommandButton { get; set; } 
        public IRPSButton<OrderAdvanceSLView,OrderAdvanceSLChildDialogView> OrderAdvanceSLChildNavigationCommandButton { get; set; } 
        public OrderAdvanceTaxSLsCollectionEditor<OrderAdvanceSLView,OrderAdvanceTaxSLView> OrderAdvanceTaxSLs { get; set; } 
        public IRPSSection<OrderAdvanceSLView> GeneralDataSection { get; set; } 
        public IRPSSection<OrderAdvanceSLView> TaxSection { get; set; } 
        public IRPSSection<OrderAdvanceSLView> TextLineSection { get; set; } 
        public IRPSSection<OrderAdvanceSLView> Comments { get; set; } 
        public OrderSL Screen { get; set; }
        public OrderAdvanceSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class OrderAdvanceTaxSLsCollectionEditor<OrderAdvanceSLView,OrderAdvanceTaxSLView>:RPSCollectionEditor<OrderAdvanceSLView,OrderAdvanceTaxSLView> where OrderAdvanceSLView : class, IView where OrderAdvanceTaxSLView : class, IView
    {
        public  OrderAdvanceTaxSLsGridView<OrderAdvanceSLView,OrderAdvanceTaxSLView> GridView {get;set;}
    }
    public partial class OrderAdvanceTaxSLsGridView <OrderAdvanceSLView,OrderAdvanceTaxSLView> :  RPSGridView<OrderAdvanceSLView,OrderAdvanceTaxSLView> where OrderAdvanceSLView : class, IView where OrderAdvanceTaxSLView : class, IView
    {
        public OrderAdvanceTaxSLsGridView(OrderAdvanceSLView currentView,OrderAdvanceTaxSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDTaxValue = RPSControlFactory.CreateRPSGridComboBox<OrderAdvanceSLView>("","#1be480cb-4b06-40f4-90c0-e5d99a1eb0f4 .ag-row[role='row']@ROWINDEX [col-id='cIDTaxValue']","",true, this.CurrentView);
 
            ApplicationType = RPSControlFactory.CreateRPSGridEnumComboBox<OrderAdvanceSLView>("","#1be480cb-4b06-40f4-90c0-e5d99a1eb0f4 .ag-row[role='row']@ROWINDEX [col-id='cApplicationType']","",true, this.CurrentView);
 
            BaseType = RPSControlFactory.CreateRPSGridEnumComboBox<OrderAdvanceSLView>("","#1be480cb-4b06-40f4-90c0-e5d99a1eb0f4 .ag-row[role='row']@ROWINDEX [col-id='cBaseType']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<OrderAdvanceSLView>("","#1be480cb-4b06-40f4-90c0-e5d99a1eb0f4 .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            Value = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderAdvanceSLView>("","#1be480cb-4b06-40f4-90c0-e5d99a1eb0f4 .ag-row[role='row']@ROWINDEX [col-id='cValue']","",true, this.CurrentView);
 
            VAT = RPSControlFactory.CreateRPSGridCheckBox<OrderAdvanceSLView>("","#1be480cb-4b06-40f4-90c0-e5d99a1eb0f4 .ag-row[role='row']@ROWINDEX [col-id='cVAT']","",true, this.CurrentView);
 
            PriceIncluded = RPSControlFactory.CreateRPSGridCheckBox<OrderAdvanceSLView>("","#1be480cb-4b06-40f4-90c0-e5d99a1eb0f4 .ag-row[role='row']@ROWINDEX [col-id='cPriceIncluded']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<OrderAdvanceSLView> IDTaxValue { get; set; } 
        public IRPSGridComboBox<OrderAdvanceSLView> ApplicationType { get; set; } 
        public IRPSGridComboBox<OrderAdvanceSLView> BaseType { get; set; } 
        public IRPSGridComboBox<OrderAdvanceSLView> Type { get; set; } 
        public IRPSGridTextBox<OrderAdvanceSLView> Value { get; set; } 
        public IRPSGridCheckbox<OrderAdvanceSLView> VAT { get; set; } 
        public IRPSGridCheckbox<OrderAdvanceSLView> PriceIncluded { get; set; } 
                     
    }
 
    }
  
            
    public partial class OrderVariablePaymentSLView : View
    {
        public OrderVariablePaymentSLView(OrderSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<OrderVariablePaymentSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<OrderVariablePaymentSLView,OrderLineSLView>( this,Screen.OrderLineSLView);
 
            BackButton = RPSControlFactory.RPSBackButton<OrderVariablePaymentSLView,OrderLineSLView>( this,Screen.OrderLineSLView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<OrderVariablePaymentSLView,OrderLineSLView>( this,Screen.OrderLineSLView);
 
            NumPayment = RPSControlFactory.CreateRPSFormattedTextBox<OrderVariablePaymentSLView>("6bc3fe53-e61d-4eb6-ab27-9dc91401b343","","",true, this);
 
            DatePayment = RPSControlFactory.CreateRPSTextBox<OrderVariablePaymentSLView>("07f843e8-bccd-4e07-acbf-faab0cd60d72","","",false, this);
 
            DayPayment = RPSControlFactory.CreateRPSFormattedTextBox<OrderVariablePaymentSLView>("c7743924-3ce9-42c6-a05a-c513c832b2a5","","",false, this);
 
            Percentage = RPSControlFactory.CreateRPSFormattedTextBox<OrderVariablePaymentSLView>("46c91f52-9afd-4f97-9a7a-0ce1468371c1","","",true, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<OrderVariablePaymentSLView>("6f903e9c-5e61-47b2-9d24-813c9d9af4cd","","",true, this);
 
            Rest = RPSControlFactory.CreateRPSCheckBox<OrderVariablePaymentSLView>("ca7c2293-a860-4f59-b0aa-93cedd177abe","","",false, this);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSComboBox<OrderVariablePaymentSLView>("2c916e7f-e71d-43dc-bedd-87b6ea329c30","","",false, this);
 

        }
        public IRPSButton<OrderVariablePaymentSLView> DeleteButton { get; set; } 
        public IRPSButton<OrderVariablePaymentSLView,OrderLineSLView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<OrderVariablePaymentSLView,OrderLineSLView> BackButton { get; set; } 
        public IRPSAcceptButton<OrderVariablePaymentSLView,OrderLineSLView> AcceptButton { get; set; } 
        public IRPSTextBox<OrderVariablePaymentSLView> NumPayment { get; set; } 
        public IRPSTextBox<OrderVariablePaymentSLView> DatePayment { get; set; } 
        public IRPSTextBox<OrderVariablePaymentSLView> DayPayment { get; set; } 
        public IRPSTextBox<OrderVariablePaymentSLView> Percentage { get; set; } 
        public IRPSTextBox<OrderVariablePaymentSLView> Amount { get; set; } 
        public IRPSCheckbox<OrderVariablePaymentSLView> Rest { get; set; } 
        public IRPSComboBox<OrderVariablePaymentSLView> IDPaymentMethod { get; set; } 
        public OrderSL Screen { get; set; }
        public OrderVariablePaymentSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OrderMilestoneSLView : View
    {
        public OrderMilestoneSLView(OrderSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<OrderMilestoneSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<OrderMilestoneSLView,OrderLineSLView>( this,Screen.OrderLineSLView);
 
            BackButton = RPSControlFactory.RPSBackButton<OrderMilestoneSLView,OrderLineSLView>( this,Screen.OrderLineSLView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<OrderMilestoneSLView,OrderLineSLView>( this,Screen.OrderLineSLView);
 
            IDTask = RPSControlFactory.CreateRPSComboBox<OrderMilestoneSLView>("c4c3fa81-b501-4100-85b7-0f916d06c90e","","",true, this);
 
            UIFinal = RPSControlFactory.CreateRPSCheckBox<OrderMilestoneSLView>("7cf2b0ab-e6dc-45a6-b867-f7a5bf9066ff","","",false, this);
 
            UIPlannedDate = RPSControlFactory.CreateRPSTextBox<OrderMilestoneSLView>("11291ed1-147d-489d-b853-d1514902dd85","","",true, this);
 
            Percentage = RPSControlFactory.CreateRPSFormattedTextBox<OrderMilestoneSLView>("c49d19be-c374-4e1c-bc94-a3cfaa37c109","","",true, this);
 
            GenerateAdvance = RPSControlFactory.CreateRPSCheckBox<OrderMilestoneSLView>("2a721b98-2e62-4865-9658-312bfbfe9994","","",true, this);
 
            Invoiced = RPSControlFactory.CreateRPSCheckBox<OrderMilestoneSLView>("7f3c9636-9901-492f-99b4-6e69c6f02a97","","",true, this);
 
            IDDeliveryNoteLine = RPSControlFactory.CreateRPSComboBox<OrderMilestoneSLView>("da8a6f8b-da96-42f8-bcfb-3b04233a6094","","",false, this);
 
            IDOrderAdvance = RPSControlFactory.CreateRPSComboBox<OrderMilestoneSLView>("9a2a8610-c996-47e2-a789-07867154c30d","","",false, this);
 
            InvoiceProjectCommandButton = RPSControlFactory.CreateRPSButton<OrderMilestoneSLView>( "0fbee629-bf54-4237-a2fb-37528dc39a9c","","",this);
 

        }
        public IRPSButton<OrderMilestoneSLView> DeleteButton { get; set; } 
        public IRPSButton<OrderMilestoneSLView,OrderLineSLView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<OrderMilestoneSLView,OrderLineSLView> BackButton { get; set; } 
        public IRPSAcceptButton<OrderMilestoneSLView,OrderLineSLView> AcceptButton { get; set; } 
        public IRPSComboBox<OrderMilestoneSLView> IDTask { get; set; } 
        public IRPSCheckbox<OrderMilestoneSLView> UIFinal { get; set; } 
        public IRPSTextBox<OrderMilestoneSLView> UIPlannedDate { get; set; } 
        public IRPSTextBox<OrderMilestoneSLView> Percentage { get; set; } 
        public IRPSCheckbox<OrderMilestoneSLView> GenerateAdvance { get; set; } 
        public IRPSCheckbox<OrderMilestoneSLView> Invoiced { get; set; } 
        public IRPSComboBox<OrderMilestoneSLView> IDDeliveryNoteLine { get; set; } 
        public IRPSComboBox<OrderMilestoneSLView> IDOrderAdvance { get; set; } 
        public IRPSButton<OrderMilestoneSLView> InvoiceProjectCommandButton { get; set; } 
        public OrderSL Screen { get; set; }
        public OrderMilestoneSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OrderComAgentSLView : View
    {
        public OrderComAgentSLView(OrderSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<OrderComAgentSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<OrderComAgentSLView,OrderLineSLView>( this,Screen.OrderLineSLView);
 
            BackButton = RPSControlFactory.RPSBackButton<OrderComAgentSLView,OrderLineSLView>( this,Screen.OrderLineSLView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<OrderComAgentSLView,OrderLineSLView>( this,Screen.OrderLineSLView);
 
            IDCommercialAgent = RPSControlFactory.CreateRPSComboBox<OrderComAgentSLView>("b50f3f5d-82a4-410c-a386-505fb0e68d2d","","",true, this);
 
            IDCommercialAgentClassification = RPSControlFactory.CreateRPSComboBox<OrderComAgentSLView>("9b3ca530-b20d-49e6-9c32-4c2a2f5b0635","","",true, this);
 
            Commission = RPSControlFactory.CreateRPSFormattedTextBox<OrderComAgentSLView>("980bc933-56ba-46d3-9a8a-21e185fccfc9","","",false, this);
 
            ComisionTypeString = RPSControlFactory.CreateRPSTextBox<OrderComAgentSLView>("084851a5-6966-4dd5-bcd7-66d00837a313","","",false, this);
 
            ComisionHead = RPSControlFactory.CreateRPSCheckBox<OrderComAgentSLView>("49479195-abc4-4697-9ef7-a730d7107b82","","",false, this);
 
            ChangeCommisionCommand = RPSControlFactory.CreateRPSButton<OrderComAgentSLView>( "98955900-2516-4d6f-9048-ed01a6877bed","","",this);
 
            CollectionInit params_OrderCommisions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1cfc34ec-e568-4b1c-835d-11e1f41d819b",CSSSelectorGrid="",XPathGrid=""};
            OrderCommisions = RPSControlFactory.RPSCreateCollectionWithGrid<OrderCommisionsCollectionEditor<OrderComAgentSLView>,OrderComAgentSLView>( params_OrderCommisions,this);
 

        }
        public IRPSButton<OrderComAgentSLView> DeleteButton { get; set; } 
        public IRPSButton<OrderComAgentSLView,OrderLineSLView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<OrderComAgentSLView,OrderLineSLView> BackButton { get; set; } 
        public IRPSAcceptButton<OrderComAgentSLView,OrderLineSLView> AcceptButton { get; set; } 
        public IRPSComboBox<OrderComAgentSLView> IDCommercialAgent { get; set; } 
        public IRPSComboBox<OrderComAgentSLView> IDCommercialAgentClassification { get; set; } 
        public IRPSTextBox<OrderComAgentSLView> Commission { get; set; } 
        public IRPSTextBox<OrderComAgentSLView> ComisionTypeString { get; set; } 
        public IRPSCheckbox<OrderComAgentSLView> ComisionHead { get; set; } 
        public IRPSButton<OrderComAgentSLView> ChangeCommisionCommand { get; set; } 
        public OrderCommisionsCollectionEditor<OrderComAgentSLView> OrderCommisions { get; set; } 
        public OrderSL Screen { get; set; }
        public OrderComAgentSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class OrderCommisionsCollectionEditor<OrderComAgentSLView>:RPSCollectionEditor<OrderComAgentSLView> where OrderComAgentSLView : class, IView
    {
        public  OrderCommisionsGridView<OrderComAgentSLView> GridView {get;set;}
    }
    public partial class OrderCommisionsGridView <OrderComAgentSLView> :  RPSGridView<OrderComAgentSLView> where OrderComAgentSLView : class, IView
    {
        public OrderCommisionsGridView(OrderComAgentSLView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Ordenation = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderComAgentSLView>("","#1cfc34ec-e568-4b1c-835d-11e1f41d819b .ag-row[role='row']@ROWINDEX [col-id='cOrdenation']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<OrderComAgentSLView>("","#1cfc34ec-e568-4b1c-835d-11e1f41d819b .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            IDCommercialAgent = RPSControlFactory.CreateRPSGridComboBox<OrderComAgentSLView>("","#1cfc34ec-e568-4b1c-835d-11e1f41d819b .ag-row[role='row']@ROWINDEX [col-id='cIDCommercialAgent']","",true, this.CurrentView);
 
            IDCommercialAgentClassification = RPSControlFactory.CreateRPSGridComboBox<OrderComAgentSLView>("","#1cfc34ec-e568-4b1c-835d-11e1f41d819b .ag-row[role='row']@ROWINDEX [col-id='cIDCommercialAgentClassification']","",true, this.CurrentView);
 
            Commission = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderComAgentSLView>("","#1cfc34ec-e568-4b1c-835d-11e1f41d819b .ag-row[role='row']@ROWINDEX [col-id='cCommission']","",false, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridTextBox<OrderComAgentSLView>("","#1cfc34ec-e568-4b1c-835d-11e1f41d819b .ag-row[role='row']@ROWINDEX [col-id='cType']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<OrderComAgentSLView> Ordenation { get; set; } 
        public IRPSGridTextBox<OrderComAgentSLView> Description { get; set; } 
        public IRPSGridComboBox<OrderComAgentSLView> IDCommercialAgent { get; set; } 
        public IRPSGridComboBox<OrderComAgentSLView> IDCommercialAgentClassification { get; set; } 
        public IRPSGridTextBox<OrderComAgentSLView> Commission { get; set; } 
        public IRPSGridTextBox<OrderComAgentSLView> Type { get; set; } 
                     
    }
 
    }
  
            
    public partial class OrderAdvanceTaxSLView : View
    {
        public OrderAdvanceTaxSLView(OrderSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<OrderAdvanceTaxSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<OrderAdvanceTaxSLView,OrderAdvanceSLView>( this,Screen.OrderAdvanceSLView);
 
            BackButton = RPSControlFactory.RPSBackButton<OrderAdvanceTaxSLView,OrderAdvanceSLView>( this,Screen.OrderAdvanceSLView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<OrderAdvanceTaxSLView,OrderAdvanceSLView>( this,Screen.OrderAdvanceSLView);
 
            IDTaxValue = RPSControlFactory.CreateRPSComboBox<OrderAdvanceTaxSLView>("3da01f68-84d4-408b-91c3-d7720ab290d4","","",true, this);
 
            ApplicationType = RPSControlFactory.CreateRPSEnumComboBox<OrderAdvanceTaxSLView>("ea772e7b-15ce-4357-9540-520f6797e5cc","","",true, this);
 
            BaseType = RPSControlFactory.CreateRPSEnumComboBox<OrderAdvanceTaxSLView>("770da764-f48c-47a2-8e44-6e19b046992d","","",true, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<OrderAdvanceTaxSLView>("dd57965e-04d0-4dbb-9722-7dd1bf79b66d","","",true, this);
 
            Value = RPSControlFactory.CreateRPSFormattedTextBox<OrderAdvanceTaxSLView>("74725b14-713f-4d68-8385-57beddd7c34f","","",true, this);
 
            VAT = RPSControlFactory.CreateRPSCheckBox<OrderAdvanceTaxSLView>("de621359-604d-42aa-9010-fc619f7312ef","","",true, this);
 
            PriceIncluded = RPSControlFactory.CreateRPSCheckBox<OrderAdvanceTaxSLView>("0be00e07-7989-4120-b7ca-6ba7887c9f8e","","",true, this);
 

        }
        public IRPSButton<OrderAdvanceTaxSLView> DeleteButton { get; set; } 
        public IRPSButton<OrderAdvanceTaxSLView,OrderAdvanceSLView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<OrderAdvanceTaxSLView,OrderAdvanceSLView> BackButton { get; set; } 
        public IRPSAcceptButton<OrderAdvanceTaxSLView,OrderAdvanceSLView> AcceptButton { get; set; } 
        public IRPSComboBox<OrderAdvanceTaxSLView> IDTaxValue { get; set; } 
        public IRPSComboBox<OrderAdvanceTaxSLView> ApplicationType { get; set; } 
        public IRPSComboBox<OrderAdvanceTaxSLView> BaseType { get; set; } 
        public IRPSComboBox<OrderAdvanceTaxSLView> Type { get; set; } 
        public IRPSTextBox<OrderAdvanceTaxSLView> Value { get; set; } 
        public IRPSCheckbox<OrderAdvanceTaxSLView> VAT { get; set; } 
        public IRPSCheckbox<OrderAdvanceTaxSLView> PriceIncluded { get; set; } 
        public OrderSL Screen { get; set; }
        public OrderAdvanceTaxSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OrderLineTaxSLView : View
    {
        public OrderLineTaxSLView(OrderSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<OrderLineTaxSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<OrderLineTaxSLView,OrderLineSLView>( this,Screen.OrderLineSLView);
 
            BackButton = RPSControlFactory.RPSBackButton<OrderLineTaxSLView,OrderLineSLView>( this,Screen.OrderLineSLView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<OrderLineTaxSLView,OrderLineSLView>( this,Screen.OrderLineSLView);
 
            IDTaxValue = RPSControlFactory.CreateRPSComboBox<OrderLineTaxSLView>("9597629e-83f4-4eb3-9f7d-511cfe840d04","","",true, this);
 
            ApplicationType = RPSControlFactory.CreateRPSEnumComboBox<OrderLineTaxSLView>("b49e98de-dc8b-4aa5-9cf8-92a560201f93","","",true, this);
 
            BaseType = RPSControlFactory.CreateRPSEnumComboBox<OrderLineTaxSLView>("bf9e8317-3484-4e81-8304-bb69dbb88be6","","",true, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<OrderLineTaxSLView>("aabd5a4c-0805-4b41-adc4-955fb281bbe9","","",true, this);
 
            Value = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineTaxSLView>("72826b4b-57c0-44d7-9d0a-0c187eed9c5a","","",true, this);
 
            PriceIncluded = RPSControlFactory.CreateRPSCheckBox<OrderLineTaxSLView>("55a3217b-5f8c-4290-8040-74192a8f6959","","",true, this);
 
            VAT = RPSControlFactory.CreateRPSCheckBox<OrderLineTaxSLView>("d2958609-20a8-4fe5-ac6a-8635678e559f","","",true, this);
 

        }
        public IRPSButton<OrderLineTaxSLView> DeleteButton { get; set; } 
        public IRPSButton<OrderLineTaxSLView,OrderLineSLView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<OrderLineTaxSLView,OrderLineSLView> BackButton { get; set; } 
        public IRPSAcceptButton<OrderLineTaxSLView,OrderLineSLView> AcceptButton { get; set; } 
        public IRPSComboBox<OrderLineTaxSLView> IDTaxValue { get; set; } 
        public IRPSComboBox<OrderLineTaxSLView> ApplicationType { get; set; } 
        public IRPSComboBox<OrderLineTaxSLView> BaseType { get; set; } 
        public IRPSComboBox<OrderLineTaxSLView> Type { get; set; } 
        public IRPSTextBox<OrderLineTaxSLView> Value { get; set; } 
        public IRPSCheckbox<OrderLineTaxSLView> PriceIncluded { get; set; } 
        public IRPSCheckbox<OrderLineTaxSLView> VAT { get; set; } 
        public OrderSL Screen { get; set; }
        public OrderLineTaxSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OrderLineAnalyticSLView : View
    {
        public OrderLineAnalyticSLView(OrderSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<OrderLineAnalyticSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<OrderLineAnalyticSLView,OrderLineSLView>( this,Screen.OrderLineSLView);
 
            BackButton = RPSControlFactory.RPSBackButton<OrderLineAnalyticSLView,OrderLineSLView>( this,Screen.OrderLineSLView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<OrderLineAnalyticSLView,OrderLineSLView>( this,Screen.OrderLineSLView);
 
            IDDimension = RPSControlFactory.CreateRPSComboBox<OrderLineAnalyticSLView>("befb6471-71c9-4a16-ad5b-b8f846de39ee","","",true, this);
 
            IDDimValue = RPSControlFactory.CreateRPSComboBox<OrderLineAnalyticSLView>("a82f32f5-a89d-4ba8-83ef-61cd7e64e019","","",true, this);
 
            Percentage = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineAnalyticSLView>("1423a353-5b18-4645-9b2a-f1f2be9bc8ed","","",true, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineAnalyticSLView>("3f1d5fe2-bccc-4ba0-970c-66e5581b27b8","","",true, this);
 

        }
        public IRPSButton<OrderLineAnalyticSLView> DeleteButton { get; set; } 
        public IRPSButton<OrderLineAnalyticSLView,OrderLineSLView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<OrderLineAnalyticSLView,OrderLineSLView> BackButton { get; set; } 
        public IRPSAcceptButton<OrderLineAnalyticSLView,OrderLineSLView> AcceptButton { get; set; } 
        public IRPSComboBox<OrderLineAnalyticSLView> IDDimension { get; set; } 
        public IRPSComboBox<OrderLineAnalyticSLView> IDDimValue { get; set; } 
        public IRPSTextBox<OrderLineAnalyticSLView> Percentage { get; set; } 
        public IRPSTextBox<OrderLineAnalyticSLView> Amount { get; set; } 
        public OrderSL Screen { get; set; }
        public OrderLineAnalyticSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OrderChangesChildDialogView : View
    {
        public OrderChangesChildDialogView(OrderSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ReceptionDate = RPSControlFactory.CreateRPSTextBox<OrderChangesChildDialogView>("d5091aaa-cc32-494f-be4a-062866cc7b75","","",false, this);
 
            ReceptionDemandDate = RPSControlFactory.CreateRPSTextBox<OrderChangesChildDialogView>("5b69550e-c916-48ac-b6b6-336a1aa1cad3","","",false, this);
 
            IDDeliveryNoteTypeSL = RPSControlFactory.CreateRPSComboBox<OrderChangesChildDialogView>("57e0623d-2a5b-406b-8dd9-920e20ce4423","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<OrderChangesChildDialogView>("fcfff32f-2e8f-4b16-8867-b0a65e3d949b","","",false, this);
 
            IDWareHouse = RPSControlFactory.CreateRPSComboBox<OrderChangesChildDialogView>("4f5e246f-80f3-4c0c-a3b7-a3095ea26359","","",false, this);
 

        }
        public IRPSTextBox<OrderChangesChildDialogView> ReceptionDate { get; set; } 
        public IRPSTextBox<OrderChangesChildDialogView> ReceptionDemandDate { get; set; } 
        public IRPSComboBox<OrderChangesChildDialogView> IDDeliveryNoteTypeSL { get; set; } 
        public IRPSComboBox<OrderChangesChildDialogView> IDSite { get; set; } 
        public IRPSComboBox<OrderChangesChildDialogView> IDWareHouse { get; set; } 
        public OrderSL Screen { get; set; }
        public OrderChangesChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ArticleGenericChildDialogView : View
    {
        public ArticleGenericChildDialogView(OrderSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            StockCommandButton = RPSControlFactory.CreateRPSButton<ArticleGenericChildDialogView>( "9f42883b-2618-44d6-ab80-5373bef0df12","","",this);
 
            CollectionInit params_ArticleGetAttributeValues = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b8ea25f2-e763-44b3-bc72-36f51efb6b1c",CSSSelectorGrid="",XPathGrid=""};
            ArticleGetAttributeValues = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleGetAttributeValuesCollectionEditor<ArticleGenericChildDialogView>,ArticleGenericChildDialogView>( params_ArticleGetAttributeValues,this);
 

        }
        public IRPSButton<ArticleGenericChildDialogView> StockCommandButton { get; set; } 
        public ArticleGetAttributeValuesCollectionEditor<ArticleGenericChildDialogView> ArticleGetAttributeValues { get; set; } 
        public OrderSL Screen { get; set; }
        public ArticleGenericChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ArticleGetAttributeValuesCollectionEditor<ArticleGenericChildDialogView>:RPSCollectionEditor<ArticleGenericChildDialogView> where ArticleGenericChildDialogView : class, IView
    {
        public  ArticleGetAttributeValuesGridView<ArticleGenericChildDialogView> GridView {get;set;}
    }
    public partial class ArticleGetAttributeValuesGridView <ArticleGenericChildDialogView> :  RPSGridView<ArticleGenericChildDialogView> where ArticleGenericChildDialogView : class, IView
    {
        public ArticleGetAttributeValuesGridView(ArticleGenericChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Attribute1 = RPSControlFactory.CreateRPSGridTextBox<ArticleGenericChildDialogView>("","#b8ea25f2-e763-44b3-bc72-36f51efb6b1c .ag-row[role='row']@ROWINDEX [col-id='cAttribute1']","",false, this.CurrentView);
 
            Attribute2 = RPSControlFactory.CreateRPSGridTextBox<ArticleGenericChildDialogView>("","#b8ea25f2-e763-44b3-bc72-36f51efb6b1c .ag-row[role='row']@ROWINDEX [col-id='cAttribute2']","",false, this.CurrentView);
 
            Attribute3 = RPSControlFactory.CreateRPSGridTextBox<ArticleGenericChildDialogView>("","#b8ea25f2-e763-44b3-bc72-36f51efb6b1c .ag-row[role='row']@ROWINDEX [col-id='cAttribute3']","",false, this.CurrentView);
 
            quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<ArticleGenericChildDialogView>("","#b8ea25f2-e763-44b3-bc72-36f51efb6b1c .ag-row[role='row']@ROWINDEX [col-id='cquantity']","",false, this.CurrentView);
 
            stock = RPSControlFactory.CreateRPSGridFormattedTextBox<ArticleGenericChildDialogView>("","#b8ea25f2-e763-44b3-bc72-36f51efb6b1c .ag-row[role='row']@ROWINDEX [col-id='cstock']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ArticleGenericChildDialogView> Attribute1 { get; set; } 
        public IRPSGridTextBox<ArticleGenericChildDialogView> Attribute2 { get; set; } 
        public IRPSGridTextBox<ArticleGenericChildDialogView> Attribute3 { get; set; } 
        public IRPSGridTextBox<ArticleGenericChildDialogView> quantity { get; set; } 
        public IRPSGridTextBox<ArticleGenericChildDialogView> stock { get; set; } 
                     
    }
 
    }
  
            
    public partial class PrintOrderChildDialogView : View
    {
        public PrintOrderChildDialogView(OrderSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CustomerLanguage = RPSControlFactory.CreateRPSOption<PrintOrderChildDialogView>( "93a3b69d-99b4-49c4-bf4a-f95ac203af5a","","",this);
 
            SelectedLanguage = RPSControlFactory.CreateRPSOption<PrintOrderChildDialogView>( "3b99e97c-6694-4af0-89ed-fe70b0061c7a","","",this);
 
            UIPrintOptionsIDLanguage = RPSControlFactory.CreateRPSComboBox<PrintOrderChildDialogView>("fecbc01e-eec2-4c82-9d1b-a6e55095af43","","",false, this);
 
            CustomerCopy = RPSControlFactory.CreateRPSOption<PrintOrderChildDialogView>( "3884df1c-5049-4602-9808-afa9d25c478f","","",this);
 
            SelectedCopy = RPSControlFactory.CreateRPSOption<PrintOrderChildDialogView>( "5a549762-2aaf-4f7e-ab3f-2294e3248e89","","",this);
 
            NCopy = RPSControlFactory.CreateRPSFormattedTextBox<PrintOrderChildDialogView>("d085d5c8-ddd3-4c83-921c-df815965cf75","","",false, this);
 
            UIPrintSpecificReport = RPSControlFactory.CreateRPSCheckBox<PrintOrderChildDialogView>("c20e1889-adf0-4d27-a4b8-f1c528316e17","","",false, this);
 
            UICodOrderReport = RPSControlFactory.CreateRPSComboBox<PrintOrderChildDialogView>("4ad6f202-76a7-488a-a0ce-dba1954e4f67","","",false, this);
 
            DescriptionArticles = RPSControlFactory.CreateRPSCheckBox<PrintOrderChildDialogView>("14987a4d-aac4-489a-9acc-7328cdf8d571","","",false, this);
 
            UIDocumentsArticle = RPSControlFactory.CreateRPSCheckBox<PrintOrderChildDialogView>("cb6ebc1a-f945-4bd6-9c29-b5a0394c5098","","",false, this);
 
            UIOptAllDocuments = RPSControlFactory.CreateRPSOption<PrintOrderChildDialogView>( "43aac03c-d25b-4033-92f7-2094a4ff7a0e","","",this);
 
            UIOptByDocument = RPSControlFactory.CreateRPSOption<PrintOrderChildDialogView>( "d846cb7c-1244-4d29-8946-418c4ef4b1c3","","",this);
 
            UIDocumentsOrder = RPSControlFactory.CreateRPSCheckBox<PrintOrderChildDialogView>("7d398149-a6fa-4182-8cdb-851774aab6b6","","",false, this);
 
            UIOptAllDocuments1 = RPSControlFactory.CreateRPSOption<PrintOrderChildDialogView>( "30e5ceaf-8e6b-4144-8840-a1cf27ee5e39","","",this);
 
            UIOptByDocument1 = RPSControlFactory.CreateRPSOption<PrintOrderChildDialogView>( "8623a8cb-ec6d-4fdb-9c5f-55a22692e4dd","","",this);
 
            UIPrintSpecificProformaReport = RPSControlFactory.CreateRPSCheckBox<PrintOrderChildDialogView>("c8771ccc-ebf2-4fe2-b3c8-9d37c91666e3","","",false, this);
 
            UICodOrderProformaReport = RPSControlFactory.CreateRPSComboBox<PrintOrderChildDialogView>("4c0aa35f-3742-4a07-a2de-e938d0e7ea02","","",false, this);
 
            UIProFormaDate = RPSControlFactory.CreateRPSTextBox<PrintOrderChildDialogView>("a40f5e58-1c98-45a4-8f62-74e2c730f807","","",false, this);
 
            UIPrintSpecificAdvanceReport = RPSControlFactory.CreateRPSCheckBox<PrintOrderChildDialogView>("55824a92-256f-43a8-b7dc-cffbe165a234","","",false, this);
 
            UICodOrderAdvanceReport = RPSControlFactory.CreateRPSComboBox<PrintOrderChildDialogView>("d12c7358-200e-4ac4-8079-b781c62c316c","","",false, this);
 
            PrintRegularOrderCommandButton = RPSControlFactory.CreateRPSButton<PrintOrderChildDialogView>( "1608d107-519a-43ed-b69c-bd43ca7d3f6b","","",this);
 
            SendRegularOrderByEmailCommandButton = RPSControlFactory.CreateRPSButton<PrintOrderChildDialogView>( "d5221bac-3a86-4586-87cf-8f819efa549c","","",this);
 
            SendRegularOrderToCustomerEmailCommandButton = RPSControlFactory.CreateRPSButton<PrintOrderChildDialogView>( "d504d92c-808a-447d-808a-af3a43a1e800","","",this);
 
            PrintProFormaCommandButton = RPSControlFactory.CreateRPSButton<PrintOrderChildDialogView>( "e45d86c1-d7ab-4076-9bac-0a521f33d83d","","",this);
 
            SendProFormaByEmailCommandButton = RPSControlFactory.CreateRPSButton<PrintOrderChildDialogView>( "419f6b57-ba72-4251-9bab-b45f49a4a80f","","",this);
 
            SendProFormaToCustomerEmailCommandButton = RPSControlFactory.CreateRPSButton<PrintOrderChildDialogView>( "d22ebd0a-f72e-42c8-bf3a-2ebf559d407e","","",this);
 
            PrintFakeAdvanceReportCommandButton = RPSControlFactory.CreateRPSButton<PrintOrderChildDialogView>( "a638d303-d774-425a-a210-7ce20d94f1e1","","",this);
 
            SendAdvanceReportByEmailFakeCommandButton = RPSControlFactory.CreateRPSButton<PrintOrderChildDialogView>( "da76c4c0-624c-4f04-8cd5-2e57f5fdcfcc","","",this);
 
            SendAdvanceReportToCustomerEmailFakeCommandButton = RPSControlFactory.CreateRPSButton<PrintOrderChildDialogView>( "8801e804-d484-47d5-ba1e-78ac53cca774","","",this);
 

        }
        public IRPSOption<PrintOrderChildDialogView> CustomerLanguage { get; set; } 
        public IRPSOption<PrintOrderChildDialogView> SelectedLanguage { get; set; } 
        public IRPSComboBox<PrintOrderChildDialogView> UIPrintOptionsIDLanguage { get; set; } 
        public IRPSOption<PrintOrderChildDialogView> CustomerCopy { get; set; } 
        public IRPSOption<PrintOrderChildDialogView> SelectedCopy { get; set; } 
        public IRPSTextBox<PrintOrderChildDialogView> NCopy { get; set; } 
        public IRPSCheckbox<PrintOrderChildDialogView> UIPrintSpecificReport { get; set; } 
        public IRPSComboBox<PrintOrderChildDialogView> UICodOrderReport { get; set; } 
        public IRPSCheckbox<PrintOrderChildDialogView> DescriptionArticles { get; set; } 
        public IRPSCheckbox<PrintOrderChildDialogView> UIDocumentsArticle { get; set; } 
        public IRPSOption<PrintOrderChildDialogView> UIOptAllDocuments { get; set; } 
        public IRPSOption<PrintOrderChildDialogView> UIOptByDocument { get; set; } 
        public IRPSCheckbox<PrintOrderChildDialogView> UIDocumentsOrder { get; set; } 
        public IRPSOption<PrintOrderChildDialogView> UIOptAllDocuments1 { get; set; } 
        public IRPSOption<PrintOrderChildDialogView> UIOptByDocument1 { get; set; } 
        public IRPSCheckbox<PrintOrderChildDialogView> UIPrintSpecificProformaReport { get; set; } 
        public IRPSComboBox<PrintOrderChildDialogView> UICodOrderProformaReport { get; set; } 
        public IRPSTextBox<PrintOrderChildDialogView> UIProFormaDate { get; set; } 
        public IRPSCheckbox<PrintOrderChildDialogView> UIPrintSpecificAdvanceReport { get; set; } 
        public IRPSComboBox<PrintOrderChildDialogView> UICodOrderAdvanceReport { get; set; } 
        public IRPSButton<PrintOrderChildDialogView> PrintRegularOrderCommandButton { get; set; } 
        public IRPSButton<PrintOrderChildDialogView> SendRegularOrderByEmailCommandButton { get; set; } 
        public IRPSButton<PrintOrderChildDialogView> SendRegularOrderToCustomerEmailCommandButton { get; set; } 
        public IRPSButton<PrintOrderChildDialogView> PrintProFormaCommandButton { get; set; } 
        public IRPSButton<PrintOrderChildDialogView> SendProFormaByEmailCommandButton { get; set; } 
        public IRPSButton<PrintOrderChildDialogView> SendProFormaToCustomerEmailCommandButton { get; set; } 
        public IRPSButton<PrintOrderChildDialogView> PrintFakeAdvanceReportCommandButton { get; set; } 
        public IRPSButton<PrintOrderChildDialogView> SendAdvanceReportByEmailFakeCommandButton { get; set; } 
        public IRPSButton<PrintOrderChildDialogView> SendAdvanceReportToCustomerEmailFakeCommandButton { get; set; } 
        public OrderSL Screen { get; set; }
        public PrintOrderChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NewOrderChildDialogView : View
    {
        public NewOrderChildDialogView(OrderSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewCodOrder = RPSControlFactory.CreateRPSTextBox<NewOrderChildDialogView>("0138355a-c513-4f95-a103-62c25c8f2c4c","","",false, this);
 
            NewIDCustomer = RPSControlFactory.CreateRPSComboBox<NewOrderChildDialogView>("081aa90d-1161-413f-87d7-37d6fae0987e","","",false, this);
 
            IDNewCustomerMiscellaneousSL = RPSControlFactory.CreateRPSComboBox<NewOrderChildDialogView>("dff143ed-8537-46e7-9f78-06790786e5b5","","",false, this);
 
            NewOrderDate = RPSControlFactory.CreateRPSTextBox<NewOrderChildDialogView>("c8ca5be7-f654-440a-8091-d07a9a802d33","","",false, this);
 
            bHeaderRecalc = RPSControlFactory.CreateRPSCheckBox<NewOrderChildDialogView>("934e211a-c1ac-498f-bf0a-904b36894f73","","",false, this);
 
            bRecalcLines = RPSControlFactory.CreateRPSCheckBox<NewOrderChildDialogView>("68cdc645-05bc-4e48-a518-49ed0b2fbfd0","","",false, this);
 
            CopyDocuments = RPSControlFactory.CreateRPSCheckBox<NewOrderChildDialogView>("d6ca8116-1f8f-403e-ae74-6b647f74597b","","",false, this);
 
            VariablePayment = RPSControlFactory.CreateRPSCheckBox<NewOrderChildDialogView>("483179da-6b95-439f-8d5c-e44d7c1f73a2","","",false, this);
 
            Advance = RPSControlFactory.CreateRPSCheckBox<NewOrderChildDialogView>("d4205256-68fc-408f-aea8-e04a8a381d10","","",false, this);
 

        }
        public IRPSTextBox<NewOrderChildDialogView> NewCodOrder { get; set; } 
        public IRPSComboBox<NewOrderChildDialogView> NewIDCustomer { get; set; } 
        public IRPSComboBox<NewOrderChildDialogView> IDNewCustomerMiscellaneousSL { get; set; } 
        public IRPSTextBox<NewOrderChildDialogView> NewOrderDate { get; set; } 
        public IRPSCheckbox<NewOrderChildDialogView> bHeaderRecalc { get; set; } 
        public IRPSCheckbox<NewOrderChildDialogView> bRecalcLines { get; set; } 
        public IRPSCheckbox<NewOrderChildDialogView> CopyDocuments { get; set; } 
        public IRPSCheckbox<NewOrderChildDialogView> VariablePayment { get; set; } 
        public IRPSCheckbox<NewOrderChildDialogView> Advance { get; set; } 
        public OrderSL Screen { get; set; }
        public NewOrderChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OrderRestDialogView : View
    {
        public OrderRestDialogView(OrderSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewCodOrder = RPSControlFactory.CreateRPSTextBox<OrderRestDialogView>("2a144a7a-51be-4c52-9bb2-ff701f6931dc","","",false, this);
 
            NewOrderDate = RPSControlFactory.CreateRPSTextBox<OrderRestDialogView>("5bfd1659-c424-41fc-a308-57a59ef34f2c","","",false, this);
 

        }
        public IRPSTextBox<OrderRestDialogView> NewCodOrder { get; set; } 
        public IRPSTextBox<OrderRestDialogView> NewOrderDate { get; set; } 
        public OrderSL Screen { get; set; }
        public OrderRestDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ArticleAlternativeChildDialogView : View
    {
        public ArticleAlternativeChildDialogView(OrderSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_ArticleAlternativeSalesSL = new CollectionInit(){IDDescriptor = "11b75403-3b4d-4bb9-8dfc-e0f9b6bcc2b0",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            ArticleAlternativeSalesSL = RPSControlFactory.RPSCreateCollection<ArticleAlternativeChildDialogView>( params_ArticleAlternativeSalesSL,this);
 

        }
        public IRPSCollectionEditor<ArticleAlternativeChildDialogView> ArticleAlternativeSalesSL { get; set; } 
        public OrderSL Screen { get; set; }
        public ArticleAlternativeChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OrderLineCommercialAgentSLView : View
    {
        public OrderLineCommercialAgentSLView(OrderSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<OrderLineCommercialAgentSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<OrderLineCommercialAgentSLView,OrderLineSLView>( this,Screen.OrderLineSLView);
 
            BackButton = RPSControlFactory.RPSBackButton<OrderLineCommercialAgentSLView,OrderLineSLView>( this,Screen.OrderLineSLView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<OrderLineCommercialAgentSLView,OrderLineSLView>( this,Screen.OrderLineSLView);
 
            IDCommercialAgent = RPSControlFactory.CreateRPSComboBox<OrderLineCommercialAgentSLView>("b9f73c49-56bf-4781-92ee-3dfb6fdda24e","","",true, this);
 
            IDCommercialAgentClassification = RPSControlFactory.CreateRPSComboBox<OrderLineCommercialAgentSLView>("9f0cc433-c86e-4b55-a6f4-aa427ba225e7","","",true, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<OrderLineCommercialAgentSLView>("502cd306-e2b1-4fc3-8f0c-ea0a98826bdc","","",true, this);
 
            Commission = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineCommercialAgentSLView>("22ce4670-1b44-4978-bdf8-476fc5772b33","","",true, this);
 
            CommissionAmount = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineCommercialAgentSLView>("8ec13199-4867-45f2-a2e2-e947f117fca0","","",true, this);
 

        }
        public IRPSButton<OrderLineCommercialAgentSLView> DeleteButton { get; set; } 
        public IRPSButton<OrderLineCommercialAgentSLView,OrderLineSLView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<OrderLineCommercialAgentSLView,OrderLineSLView> BackButton { get; set; } 
        public IRPSAcceptButton<OrderLineCommercialAgentSLView,OrderLineSLView> AcceptButton { get; set; } 
        public IRPSComboBox<OrderLineCommercialAgentSLView> IDCommercialAgent { get; set; } 
        public IRPSComboBox<OrderLineCommercialAgentSLView> IDCommercialAgentClassification { get; set; } 
        public IRPSComboBox<OrderLineCommercialAgentSLView> Type { get; set; } 
        public IRPSTextBox<OrderLineCommercialAgentSLView> Commission { get; set; } 
        public IRPSTextBox<OrderLineCommercialAgentSLView> CommissionAmount { get; set; } 
        public OrderSL Screen { get; set; }
        public OrderLineCommercialAgentSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OrderLineProposalSLView : View
    {
        public OrderLineProposalSLView(OrderSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<OrderLineProposalSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<OrderLineProposalSLView,OrderLineSLView>( this,Screen.OrderLineSLView);
 
            BackButton = RPSControlFactory.RPSBackButton<OrderLineProposalSLView,OrderLineSLView>( this,Screen.OrderLineSLView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<OrderLineProposalSLView,OrderLineSLView>( this,Screen.OrderLineSLView);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<OrderLineProposalSLView>("0fe98894-8f09-4f90-b004-ec98196e983c","","",true, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<OrderLineProposalSLView>("9dc6489f-c723-47a3-baff-ae8110f42deb","","",true, this);
 
            Series = RPSControlFactory.CreateRPSEnumComboBox<OrderLineProposalSLView>("2a939508-9de1-4298-b64d-155079f5cecd","","",false, this);
 
            IDLocationWarehouse = RPSControlFactory.CreateRPSComboBox<OrderLineProposalSLView>("09e6d583-0f61-4bef-b274-a14c6bb30414","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineProposalSLView>("63b2cef5-eb60-4f32-ae63-78cd200f2341","","",true, this);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineProposalSLView>("ea8c8dbc-4c9e-489a-988b-614b6113dc4f","","",true, this);
 

        }
        public IRPSButton<OrderLineProposalSLView> DeleteButton { get; set; } 
        public IRPSButton<OrderLineProposalSLView,OrderLineSLView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<OrderLineProposalSLView,OrderLineSLView> BackButton { get; set; } 
        public IRPSAcceptButton<OrderLineProposalSLView,OrderLineSLView> AcceptButton { get; set; } 
        public IRPSComboBox<OrderLineProposalSLView> IDSite { get; set; } 
        public IRPSComboBox<OrderLineProposalSLView> IDWarehouse { get; set; } 
        public IRPSComboBox<OrderLineProposalSLView> Series { get; set; } 
        public IRPSComboBox<OrderLineProposalSLView> IDLocationWarehouse { get; set; } 
        public IRPSTextBox<OrderLineProposalSLView> Quantity { get; set; } 
        public IRPSTextBox<OrderLineProposalSLView> QuantitySecondUnit { get; set; } 
        public OrderSL Screen { get; set; }
        public OrderLineProposalSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class GenerateDeliveryNoteChildDialogView : View
    {
        public GenerateDeliveryNoteChildDialogView(OrderSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewDeliveryNote = RPSControlFactory.CreateRPSOption<GenerateDeliveryNoteChildDialogView>( "0462c2b5-23cd-4887-a81b-27fc8312fd8b","","",this);
 
            DeliveryNoteDate = RPSControlFactory.CreateRPSTextBox<GenerateDeliveryNoteChildDialogView>("3d1a43ee-be02-415e-8600-152f13c08b10","","",false, this);
 
            ExistDeliveryNote = RPSControlFactory.CreateRPSOption<GenerateDeliveryNoteChildDialogView>( "834e2197-8aa4-4dbe-ace7-f663dfe8cd75","","",this);
 
            IDDeliveryNote = RPSControlFactory.CreateRPSComboBox<GenerateDeliveryNoteChildDialogView>("61a7c8a3-b95f-4e4a-99f8-0f4723d55979","","",false, this);
 
            WithoutExistenceControl = RPSControlFactory.CreateRPSCheckBox<GenerateDeliveryNoteChildDialogView>("d33bac81-8b20-4be3-9dad-809229837b4b","","",false, this);
 

        }
        public IRPSOption<GenerateDeliveryNoteChildDialogView> NewDeliveryNote { get; set; } 
        public IRPSTextBox<GenerateDeliveryNoteChildDialogView> DeliveryNoteDate { get; set; } 
        public IRPSOption<GenerateDeliveryNoteChildDialogView> ExistDeliveryNote { get; set; } 
        public IRPSComboBox<GenerateDeliveryNoteChildDialogView> IDDeliveryNote { get; set; } 
        public IRPSCheckbox<GenerateDeliveryNoteChildDialogView> WithoutExistenceControl { get; set; } 
        public OrderSL Screen { get; set; }
        public GenerateDeliveryNoteChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OrderComAgentNewChildDialogView : View
    {
        public OrderComAgentNewChildDialogView(OrderSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDCommercialAgent = RPSControlFactory.CreateRPSComboBox<OrderComAgentNewChildDialogView>("17750c90-8ceb-427c-b784-dd0df848ae80","","",true, this);
 
            IDCommercialAgentClassification = RPSControlFactory.CreateRPSComboBox<OrderComAgentNewChildDialogView>("03637123-989e-47e0-b363-37558b735dd1","","",true, this);
 

        }
        public IRPSComboBox<OrderComAgentNewChildDialogView> IDCommercialAgent { get; set; } 
        public IRPSComboBox<OrderComAgentNewChildDialogView> IDCommercialAgentClassification { get; set; } 
        public OrderSL Screen { get; set; }
        public OrderComAgentNewChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ChangeOrderCustomerChildDialogView : View
    {
        public ChangeOrderCustomerChildDialogView(OrderSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDCustomer = RPSControlFactory.CreateRPSComboBox<ChangeOrderCustomerChildDialogView>("20e9a7d0-657e-4057-8821-cbbca04c39c4","","",true, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<ChangeOrderCustomerChildDialogView>("49dfb6fe-0a1b-4420-8851-0a14a51b2ace","","",false, this);
 
            IDCustomerMiscellaneous = RPSControlFactory.CreateRPSComboBox<ChangeOrderCustomerChildDialogView>("5b03fb4a-397c-4274-934e-8cb25443ed41","","",false, this);
 
            NewCustomer = RPSControlFactory.CreateRPSComboBox<ChangeOrderCustomerChildDialogView>("341cd66e-2a79-4769-905b-b6556fdc8d6c","","",true, this);
 
            NewVATNumber = RPSControlFactory.CreateRPSTextBox<ChangeOrderCustomerChildDialogView>("f567f5c7-bd5d-4b31-87f0-1d580a2f9805","","",false, this);
 
            IDCustomerMiscellaneousNew = RPSControlFactory.CreateRPSComboBox<ChangeOrderCustomerChildDialogView>("b2ab8a75-6d98-4a30-95fe-25d277f5feaa","","",true, this);
 
            bChangeHeader = RPSControlFactory.CreateRPSCheckBox<ChangeOrderCustomerChildDialogView>("37163c36-c097-441b-8675-ef4d15e609c6","","",false, this);
 

        }
        public IRPSComboBox<ChangeOrderCustomerChildDialogView> IDCustomer { get; set; } 
        public IRPSTextBox<ChangeOrderCustomerChildDialogView> VATNumber { get; set; } 
        public IRPSComboBox<ChangeOrderCustomerChildDialogView> IDCustomerMiscellaneous { get; set; } 
        public IRPSComboBox<ChangeOrderCustomerChildDialogView> NewCustomer { get; set; } 
        public IRPSTextBox<ChangeOrderCustomerChildDialogView> NewVATNumber { get; set; } 
        public IRPSComboBox<ChangeOrderCustomerChildDialogView> IDCustomerMiscellaneousNew { get; set; } 
        public IRPSCheckbox<ChangeOrderCustomerChildDialogView> bChangeHeader { get; set; } 
        public OrderSL Screen { get; set; }
        public ChangeOrderCustomerChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OrderAdvanceSLChildDialogView : View
    {
        public OrderAdvanceSLChildDialogView(OrderSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            InvoiceSL = RPSControlFactory.CreateRPSComboBox<OrderAdvanceSLChildDialogView>("9a637084-e816-4680-bd25-587f7e93a990","","",false, this);
 
            CollectionInit params_GetInvoiceOrderAdvancedList = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1c3b0a51-5c37-448f-8d76-8900983f022f",CSSSelectorGrid="",XPathGrid=""};
            GetInvoiceOrderAdvancedList = RPSControlFactory.RPSCreateCollectionWithGrid<GetInvoiceOrderAdvancedListCollectionEditor<OrderAdvanceSLChildDialogView>,OrderAdvanceSLChildDialogView>( params_GetInvoiceOrderAdvancedList,this);
 

        }
        public IRPSComboBox<OrderAdvanceSLChildDialogView> InvoiceSL { get; set; } 
        public GetInvoiceOrderAdvancedListCollectionEditor<OrderAdvanceSLChildDialogView> GetInvoiceOrderAdvancedList { get; set; } 
        public OrderSL Screen { get; set; }
        public OrderAdvanceSLChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetInvoiceOrderAdvancedListCollectionEditor<OrderAdvanceSLChildDialogView>:RPSCollectionEditor<OrderAdvanceSLChildDialogView> where OrderAdvanceSLChildDialogView : class, IView
    {
        public  GetInvoiceOrderAdvancedListGridView<OrderAdvanceSLChildDialogView> GridView {get;set;}
    }
    public partial class GetInvoiceOrderAdvancedListGridView <OrderAdvanceSLChildDialogView> :  RPSGridView<OrderAdvanceSLChildDialogView> where OrderAdvanceSLChildDialogView : class, IView
    {
        public GetInvoiceOrderAdvancedListGridView(OrderAdvanceSLChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodInvoice = RPSControlFactory.CreateRPSGridTextBox<OrderAdvanceSLChildDialogView>("","#1c3b0a51-5c37-448f-8d76-8900983f022f .ag-row[role='row']@ROWINDEX [col-id='cCodInvoice']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<OrderAdvanceSLChildDialogView>("","#1c3b0a51-5c37-448f-8d76-8900983f022f .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderAdvanceSLChildDialogView>("","#1c3b0a51-5c37-448f-8d76-8900983f022f .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<OrderAdvanceSLChildDialogView> CodInvoice { get; set; } 
        public IRPSGridTextBox<OrderAdvanceSLChildDialogView> InvoiceDate { get; set; } 
        public IRPSGridTextBox<OrderAdvanceSLChildDialogView> Amount { get; set; } 
                     
    }
 
    }
  
            
    public partial class DueDateCalculationDialogView : View
    {
        public DueDateCalculationDialogView(OrderSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSComboBox<DueDateCalculationDialogView>("6ab9e221-b30c-458f-ba0c-d4fc5e791a48","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<DueDateCalculationDialogView>("ad628fce-5c50-44ed-a0b1-2becc72bf39a","","",false, this);
 
            DeliveredQuantity = RPSControlFactory.CreateRPSFormattedTextBox<DueDateCalculationDialogView>("357d1bb3-25b5-4ea3-9d6a-74c528b7d1f0","","",false, this);
 
            PendingQuantity = RPSControlFactory.CreateRPSFormattedTextBox<DueDateCalculationDialogView>("62fcf639-4c56-4ba6-bc80-d53c2861e1b6","","",false, this);
 
            ReceptionDate = RPSControlFactory.CreateRPSTextBox<DueDateCalculationDialogView>("7bf78bbc-a5b9-4aa3-aa72-e597e1fcdb03","","",false, this);
 
            CalculatedDate = RPSControlFactory.CreateRPSTextBox<DueDateCalculationDialogView>("a82179cd-5caf-4c8a-9913-ac91a19cf348","","",false, this);
 
            LastCalculatedDate = RPSControlFactory.CreateRPSTextBox<DueDateCalculationDialogView>("b109e65c-a7db-48ff-9820-aa6217ce3639","","",false, this);
 
            Message = RPSControlFactory.CreateRPSTextBox<DueDateCalculationDialogView>("0a67a15a-ad8d-4434-9d1c-bfb380a7ce73","","",false, this);
 
            CalculateDateCommand = RPSControlFactory.CreateRPSButton<DueDateCalculationDialogView>( "1d45bfb9-d0eb-4869-898e-411ebcb0dcbf","","",this);
 
            ExecuteSaveOrderLineDueDateCalculation = RPSControlFactory.CreateRPSButton<DueDateCalculationDialogView>( "a16fd60f-8f5f-4698-ad75-34bdcfee3296","","",this);
 
            CancelCommand = RPSControlFactory.CreateRPSButton<DueDateCalculationDialogView>( "f1b37baa-7df7-40a5-b889-d65bfc2493a7","","",this);
 

        }
        public IRPSComboBox<DueDateCalculationDialogView> IDArticle { get; set; } 
        public IRPSTextBox<DueDateCalculationDialogView> Quantity { get; set; } 
        public IRPSTextBox<DueDateCalculationDialogView> DeliveredQuantity { get; set; } 
        public IRPSTextBox<DueDateCalculationDialogView> PendingQuantity { get; set; } 
        public IRPSTextBox<DueDateCalculationDialogView> ReceptionDate { get; set; } 
        public IRPSTextBox<DueDateCalculationDialogView> CalculatedDate { get; set; } 
        public IRPSTextBox<DueDateCalculationDialogView> LastCalculatedDate { get; set; } 
        public IRPSTextBox<DueDateCalculationDialogView> Message { get; set; } 
        public IRPSButton<DueDateCalculationDialogView> CalculateDateCommand { get; set; } 
        public IRPSButton<DueDateCalculationDialogView> ExecuteSaveOrderLineDueDateCalculation { get; set; } 
        public IRPSButton<DueDateCalculationDialogView> CancelCommand { get; set; } 
        public OrderSL Screen { get; set; }
        public DueDateCalculationDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class RelatedFWCManagementChildDialogView : View
    {
        public RelatedFWCManagementChildDialogView(OrderSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_GetFrameworkContractDatas = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="537db07e-ca9a-4227-a4ec-2f39dfbe063c",CSSSelectorGrid="",XPathGrid=""};
            GetFrameworkContractDatas = RPSControlFactory.RPSCreateCollectionWithGrid<GetFrameworkContractDatasCollectionEditor<RelatedFWCManagementChildDialogView>,RelatedFWCManagementChildDialogView>( params_GetFrameworkContractDatas,this);
 

        }
        public GetFrameworkContractDatasCollectionEditor<RelatedFWCManagementChildDialogView> GetFrameworkContractDatas { get; set; } 
        public OrderSL Screen { get; set; }
        public RelatedFWCManagementChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetFrameworkContractDatasCollectionEditor<RelatedFWCManagementChildDialogView>:RPSCollectionEditor<RelatedFWCManagementChildDialogView> where RelatedFWCManagementChildDialogView : class, IView
    {
        public  GetFrameworkContractDatasGridView<RelatedFWCManagementChildDialogView> GridView {get;set;}
    }
    public partial class GetFrameworkContractDatasGridView <RelatedFWCManagementChildDialogView> :  RPSGridView<RelatedFWCManagementChildDialogView> where RelatedFWCManagementChildDialogView : class, IView
    {
        public GetFrameworkContractDatasGridView(RelatedFWCManagementChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<RelatedFWCManagementChildDialogView>("","#537db07e-ca9a-4227-a4ec-2f39dfbe063c .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",false, this.CurrentView);
 
            DateTo = RPSControlFactory.CreateRPSGridTextBox<RelatedFWCManagementChildDialogView>("","#537db07e-ca9a-4227-a4ec-2f39dfbe063c .ag-row[role='row']@ROWINDEX [col-id='cDateTo']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<RelatedFWCManagementChildDialogView> DateFrom { get; set; } 
        public IRPSGridTextBox<RelatedFWCManagementChildDialogView> DateTo { get; set; } 
                     
    }
 
    }
  
            
    public partial class ModifyOrderSituationSLDialogView : View
    {
        public ModifyOrderSituationSLDialogView(OrderSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDOrderSituation = RPSControlFactory.CreateRPSComboBox<ModifyOrderSituationSLDialogView>("41fbe8c7-6939-4075-b122-c12af1092116","","",true, this);
 

        }
        public IRPSComboBox<ModifyOrderSituationSLDialogView> IDOrderSituation { get; set; } 
        public OrderSL Screen { get; set; }
        public ModifyOrderSituationSLDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OrderIncidenceSLView : View
    {
        public OrderIncidenceSLView(OrderSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<OrderIncidenceSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<OrderIncidenceSLView,OrderLineSLView>( this,Screen.OrderLineSLView);
 
            BackButton = RPSControlFactory.RPSBackButton<OrderIncidenceSLView,OrderLineSLView>( this,Screen.OrderLineSLView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<OrderIncidenceSLView,OrderLineSLView>( this,Screen.OrderLineSLView);
 
            NumIncidence = RPSControlFactory.CreateRPSFormattedTextBox<OrderIncidenceSLView>("1603b8b9-db27-4098-a8a5-f5a11070a5d6","","",true, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<OrderIncidenceSLView>("695cfae7-da6b-43bb-872b-d497275ab86c","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<OrderIncidenceSLView>("6393080e-9cd5-41f3-80f0-1a9d7ba13407","","",false, this);
 
            IDIncidenceType = RPSControlFactory.CreateRPSComboBox<OrderIncidenceSLView>("646086b0-040e-4a7a-a5d1-d4185aed6f73","","",true, this);
 
            IDIncidenceSituation = RPSControlFactory.CreateRPSComboBox<OrderIncidenceSLView>("b3549931-6324-4311-a8c9-d3d0bcc74759","","",true, this);
 
            IDResponsibleEmployee = RPSControlFactory.CreateRPSComboBox<OrderIncidenceSLView>("4edb649a-b5b6-4556-915f-5c0df809970d","","",false, this);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<OrderIncidenceSLView>("819bf61f-e9dd-45f4-baaa-581c6938c6f1","","",true, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<OrderIncidenceSLView>("d40a8217-913d-47d8-a1cc-d06970d097de","","",false, this);
 
            SectionGeneral = RPSControlFactory.CreateRPSSection<OrderIncidenceSLView>( "","ul li[rpsid='81ad8587-50f2-434f-8661-8bad21e77fc3']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<OrderIncidenceSLView>( "","ul li[rpsid='c3efc7d0-4471-4fae-8b70-06b911de91d6']","",this);
 

        }
        public IRPSButton<OrderIncidenceSLView> DeleteButton { get; set; } 
        public IRPSButton<OrderIncidenceSLView,OrderLineSLView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<OrderIncidenceSLView,OrderLineSLView> BackButton { get; set; } 
        public IRPSAcceptButton<OrderIncidenceSLView,OrderLineSLView> AcceptButton { get; set; } 
        public IRPSTextBox<OrderIncidenceSLView> NumIncidence { get; set; } 
        public IRPSTextBox<OrderIncidenceSLView> Date { get; set; } 
        public IRPSTextBox<OrderIncidenceSLView> Description { get; set; } 
        public IRPSComboBox<OrderIncidenceSLView> IDIncidenceType { get; set; } 
        public IRPSComboBox<OrderIncidenceSLView> IDIncidenceSituation { get; set; } 
        public IRPSComboBox<OrderIncidenceSLView> IDResponsibleEmployee { get; set; } 
        public IRPSComboBox<OrderIncidenceSLView> CodUser { get; set; } 
        public IRPSTextBox<OrderIncidenceSLView> Comment { get; set; } 
        public IRPSSection<OrderIncidenceSLView> SectionGeneral { get; set; } 
        public IRPSSection<OrderIncidenceSLView> Comments { get; set; } 
        public OrderSL Screen { get; set; }
        public OrderIncidenceSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OrderSLToRoadMapChildDialogView : View
    {
        public OrderSLToRoadMapChildDialogView(OrderSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDRoadMapSL = RPSControlFactory.CreateRPSComboBox<OrderSLToRoadMapChildDialogView>("6ac9f00e-88ac-4350-9f94-b86cd7482090","","",true, this);
 
            AddRoadMapCommand = RPSControlFactory.CreateRPSButton<OrderSLToRoadMapChildDialogView>( "73353701-8656-4b57-a172-574bcbd5134f","","",this);
 
            DeleteRoadMapCommand = RPSControlFactory.CreateRPSButton<OrderSLToRoadMapChildDialogView>( "5265cf09-6b2f-4d93-aa9e-361223f41c00","","",this);
 
            CollectionInit params_GetOrderRoadMaps = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3a313c87-fe9b-48ff-87d0-8b08eb533a61",CSSSelectorGrid="",XPathGrid=""};
            GetOrderRoadMaps = RPSControlFactory.RPSCreateCollectionWithGrid<GetOrderRoadMapsCollectionEditor<OrderSLToRoadMapChildDialogView>,OrderSLToRoadMapChildDialogView>( params_GetOrderRoadMaps,this);
 

        }
        public IRPSComboBox<OrderSLToRoadMapChildDialogView> IDRoadMapSL { get; set; } 
        public IRPSButton<OrderSLToRoadMapChildDialogView> AddRoadMapCommand { get; set; } 
        public IRPSButton<OrderSLToRoadMapChildDialogView> DeleteRoadMapCommand { get; set; } 
        public GetOrderRoadMapsCollectionEditor<OrderSLToRoadMapChildDialogView> GetOrderRoadMaps { get; set; } 
        public OrderSL Screen { get; set; }
        public OrderSLToRoadMapChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetOrderRoadMapsCollectionEditor<OrderSLToRoadMapChildDialogView>:RPSCollectionEditor<OrderSLToRoadMapChildDialogView> where OrderSLToRoadMapChildDialogView : class, IView
    {
        public  GetOrderRoadMapsGridView<OrderSLToRoadMapChildDialogView> GridView {get;set;}
    }
    public partial class GetOrderRoadMapsGridView <OrderSLToRoadMapChildDialogView> :  RPSGridView<OrderSLToRoadMapChildDialogView> where OrderSLToRoadMapChildDialogView : class, IView
    {
        public GetOrderRoadMapsGridView(OrderSLToRoadMapChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ExpeditionDate = RPSControlFactory.CreateRPSGridTextBox<OrderSLToRoadMapChildDialogView>("","#3a313c87-fe9b-48ff-87d0-8b08eb533a61 .ag-row[role='row']@ROWINDEX [col-id='cExpeditionDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<OrderSLToRoadMapChildDialogView> ExpeditionDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class AnalyticChildDialogView : View
    {
        public AnalyticChildDialogView(OrderSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDAccount = RPSControlFactory.CreateRPSComboBox<AnalyticChildDialogView>("4772b427-ef8d-410e-859d-3c76f24d1ac9","","",false, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<AnalyticChildDialogView>("64e217e6-b7d6-43b7-885a-d3d958ba452a","","",true, this);
 
            GetDimensionChildCommandButton = RPSControlFactory.CreateRPSButton<AnalyticChildDialogView>( "159e6a3a-2ce4-44b4-9992-e99f2129a019","","",this);
 
            CollectionInit params_OrderLineAnalyticSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7d208490-fb7a-418e-b382-fd5b617b051e",CSSSelectorGrid="",XPathGrid=""};
            OrderLineAnalyticSLs = RPSControlFactory.RPSCreateCollectionWithGrid<OrderLineAnalyticSLsCollectionEditor<AnalyticChildDialogView>,AnalyticChildDialogView>( params_OrderLineAnalyticSLs,this);
 

        }
        public IRPSComboBox<AnalyticChildDialogView> IDAccount { get; set; } 
        public IRPSTextBox<AnalyticChildDialogView> Amount { get; set; } 
        public IRPSButton<AnalyticChildDialogView> GetDimensionChildCommandButton { get; set; } 
        public OrderLineAnalyticSLsCollectionEditor<AnalyticChildDialogView> OrderLineAnalyticSLs { get; set; } 
        public OrderSL Screen { get; set; }
        public AnalyticChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class OrderLineAnalyticSLsCollectionEditor<AnalyticChildDialogView>:RPSCollectionEditor<AnalyticChildDialogView> where AnalyticChildDialogView : class, IView
    {
        public  OrderLineAnalyticSLsGridView<AnalyticChildDialogView> GridView {get;set;}
    }
    public partial class OrderLineAnalyticSLsGridView <AnalyticChildDialogView> :  RPSGridView<AnalyticChildDialogView> where AnalyticChildDialogView : class, IView
    {
        public OrderLineAnalyticSLsGridView(AnalyticChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDDimension = RPSControlFactory.CreateRPSGridComboBox<AnalyticChildDialogView>("","#7d208490-fb7a-418e-b382-fd5b617b051e .ag-row[role='row']@ROWINDEX [col-id='cIDDimension']","",true, this.CurrentView);
 
            IDDimValue = RPSControlFactory.CreateRPSGridComboBox<AnalyticChildDialogView>("","#7d208490-fb7a-418e-b382-fd5b617b051e .ag-row[role='row']@ROWINDEX [col-id='cIDDimValue']","",true, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<AnalyticChildDialogView>("","#7d208490-fb7a-418e-b382-fd5b617b051e .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<AnalyticChildDialogView>("","#7d208490-fb7a-418e-b382-fd5b617b051e .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<AnalyticChildDialogView> IDDimension { get; set; } 
        public IRPSGridComboBox<AnalyticChildDialogView> IDDimValue { get; set; } 
        public IRPSGridTextBox<AnalyticChildDialogView> Percentage { get; set; } 
        public IRPSGridTextBox<AnalyticChildDialogView> Amount { get; set; } 
                     
    }
 
    }
  
            
    public partial class ReserveChildDialogView : View
    {
        public ReserveChildDialogView(OrderSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSComboBox<ReserveChildDialogView>("68a275dd-07ea-4dda-9f9c-147ff7b10a40","","",true, this);
 
            Price = RPSControlFactory.CreateRPSFormattedTextBox<ReserveChildDialogView>("30ea5d85-a534-4dca-9f57-d1f57296ecdf","","",true, this);
 
            QuantityWarehouse = RPSControlFactory.CreateRPSFormattedTextBox<ReserveChildDialogView>("d1239614-f659-4e57-9944-8f127a24753d","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<ReserveChildDialogView>("93a70349-5d15-4688-8075-96cc2fad52be","","",true, this);
 
            CollectionInit params_OrderLineReservesConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="13507e67-fbdd-4cc8-90a3-1d59b7159982",CSSSelectorGrid="",XPathGrid=""};
            OrderLineReservesConsult = RPSControlFactory.RPSCreateCollectionWithGrid<OrderLineReservesConsultCollectionEditor<ReserveChildDialogView>,ReserveChildDialogView>( params_OrderLineReservesConsult,this);
 
            CollectionInit params_OrderLineReservesConsultSerie = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ce47f360-41d7-4282-aa31-d0ab12749252",CSSSelectorGrid="",XPathGrid=""};
            OrderLineReservesConsultSerie = RPSControlFactory.RPSCreateCollectionWithGrid<OrderLineReservesConsultSerieCollectionEditor<ReserveChildDialogView>,ReserveChildDialogView>( params_OrderLineReservesConsultSerie,this);
 

        }
        public IRPSComboBox<ReserveChildDialogView> IDArticle { get; set; } 
        public IRPSTextBox<ReserveChildDialogView> Price { get; set; } 
        public IRPSTextBox<ReserveChildDialogView> QuantityWarehouse { get; set; } 
        public IRPSTextBox<ReserveChildDialogView> Quantity { get; set; } 
        public OrderLineReservesConsultCollectionEditor<ReserveChildDialogView> OrderLineReservesConsult { get; set; } 
        public OrderLineReservesConsultSerieCollectionEditor<ReserveChildDialogView> OrderLineReservesConsultSerie { get; set; } 
        public OrderSL Screen { get; set; }
        public ReserveChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class OrderLineReservesConsultCollectionEditor<ReserveChildDialogView>:RPSCollectionEditor<ReserveChildDialogView> where ReserveChildDialogView : class, IView
    {
        public  OrderLineReservesConsultGridView<ReserveChildDialogView> GridView {get;set;}
    }
    public partial class OrderLineReservesConsultGridView <ReserveChildDialogView> :  RPSGridView<ReserveChildDialogView> where ReserveChildDialogView : class, IView
    {
        public OrderLineReservesConsultGridView(ReserveChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Alert = RPSControlFactory.CreateRPSGridCheckBox<ReserveChildDialogView>("","#13507e67-fbdd-4cc8-90a3-1d59b7159982 .ag-row[role='row']@ROWINDEX [col-id='cAlert']","",false, this.CurrentView);
 
            QuantityReserved = RPSControlFactory.CreateRPSGridFormattedTextBox<ReserveChildDialogView>("","#13507e67-fbdd-4cc8-90a3-1d59b7159982 .ag-row[role='row']@ROWINDEX [col-id='cQuantityReserved']","",false, this.CurrentView);
 
            QuantitySecondUnitReserved = RPSControlFactory.CreateRPSGridFormattedTextBox<ReserveChildDialogView>("","#13507e67-fbdd-4cc8-90a3-1d59b7159982 .ag-row[role='row']@ROWINDEX [col-id='cQuantitySecondUnitReserved']","",false, this.CurrentView);
 

        }
        public IRPSGridCheckbox<ReserveChildDialogView> Alert { get; set; } 
        public IRPSGridTextBox<ReserveChildDialogView> QuantityReserved { get; set; } 
        public IRPSGridTextBox<ReserveChildDialogView> QuantitySecondUnitReserved { get; set; } 
                     
    }
 
        public partial class OrderLineReservesConsultSerieCollectionEditor<ReserveChildDialogView>:RPSCollectionEditor<ReserveChildDialogView> where ReserveChildDialogView : class, IView
    {
        public  OrderLineReservesConsultSerieGridView<ReserveChildDialogView> GridView {get;set;}
    }
    public partial class OrderLineReservesConsultSerieGridView <ReserveChildDialogView> :  RPSGridView<ReserveChildDialogView> where ReserveChildDialogView : class, IView
    {
        public OrderLineReservesConsultSerieGridView(ReserveChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Series = RPSControlFactory.CreateRPSGridTextBox<ReserveChildDialogView>("","#ce47f360-41d7-4282-aa31-d0ab12749252 .ag-row[role='row']@ROWINDEX [col-id='cSeries']","",false, this.CurrentView);
 
            ExpiryDate = RPSControlFactory.CreateRPSGridTextBox<ReserveChildDialogView>("","#ce47f360-41d7-4282-aa31-d0ab12749252 .ag-row[role='row']@ROWINDEX [col-id='cExpiryDate']","",false, this.CurrentView);
 
            Alert = RPSControlFactory.CreateRPSGridCheckBox<ReserveChildDialogView>("","#ce47f360-41d7-4282-aa31-d0ab12749252 .ag-row[role='row']@ROWINDEX [col-id='cAlert']","",false, this.CurrentView);
 
            QuantityReserved = RPSControlFactory.CreateRPSGridFormattedTextBox<ReserveChildDialogView>("","#ce47f360-41d7-4282-aa31-d0ab12749252 .ag-row[role='row']@ROWINDEX [col-id='cQuantityReserved']","",false, this.CurrentView);
 
            QuantitySecondUnitReserved = RPSControlFactory.CreateRPSGridFormattedTextBox<ReserveChildDialogView>("","#ce47f360-41d7-4282-aa31-d0ab12749252 .ag-row[role='row']@ROWINDEX [col-id='cQuantitySecondUnitReserved']","",false, this.CurrentView);
 
            Priority = RPSControlFactory.CreateRPSGridFormattedTextBox<ReserveChildDialogView>("","#ce47f360-41d7-4282-aa31-d0ab12749252 .ag-row[role='row']@ROWINDEX [col-id='cPriority']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ReserveChildDialogView> Series { get; set; } 
        public IRPSGridTextBox<ReserveChildDialogView> ExpiryDate { get; set; } 
        public IRPSGridCheckbox<ReserveChildDialogView> Alert { get; set; } 
        public IRPSGridTextBox<ReserveChildDialogView> QuantityReserved { get; set; } 
        public IRPSGridTextBox<ReserveChildDialogView> QuantitySecondUnitReserved { get; set; } 
        public IRPSGridTextBox<ReserveChildDialogView> Priority { get; set; } 
                     
    }
 
    }
  
    

}