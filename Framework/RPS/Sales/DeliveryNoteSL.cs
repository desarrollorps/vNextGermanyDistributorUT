    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.DeliveryNoteSL
{
    //RPS VERSION 1.0.0.0
    public partial class DeliveryNoteSL:Screen
    {
        public DeliveryNoteSL():base()
        {
            this.URL = "sales.deliverynotesl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DeliveryNoteSLCollectionView  = new DeliveryNoteSLCollectionView(this); 
            DeliveryNoteSLEntityView  = new DeliveryNoteSLEntityView(this); 
            DeliveryNoteLineSLView  = new DeliveryNoteLineSLView(this); 
            DeliveryNoteVariablePaymentSLView  = new DeliveryNoteVariablePaymentSLView(this); 
            DeliveryNoteComAgentSLView  = new DeliveryNoteComAgentSLView(this); 
            DeliveryNoteLineCommercialAgentSLView  = new DeliveryNoteLineCommercialAgentSLView(this); 
            DeliveryNoteLineMovementSLView  = new DeliveryNoteLineMovementSLView(this); 
            OrderLineAnalyticSLView  = new OrderLineAnalyticSLView(this); 
            DeliveryNoteLineTaxSLView  = new DeliveryNoteLineTaxSLView(this); 
            DeliveryNoteChangesChildDialogView  = new DeliveryNoteChangesChildDialogView(this); 
            PrintDeliveryNoteChildDialogView  = new PrintDeliveryNoteChildDialogView(this); 
            ArticleGenericChildDialogView  = new ArticleGenericChildDialogView(this); 
            PrintInvoiceChildDialogView  = new PrintInvoiceChildDialogView(this); 
            NewConsumptionChildDialogView  = new NewConsumptionChildDialogView(this); 
            RecalculateIntrastatChildDialogView  = new RecalculateIntrastatChildDialogView(this); 
            DeliveryFromOrderChildDialogView  = new DeliveryFromOrderChildDialogView(this); 
            DeliveryFromOrderHeaderChildDialogView  = new DeliveryFromOrderHeaderChildDialogView(this); 
            SeriesDataChildDialogView  = new SeriesDataChildDialogView(this); 
            InvoiceAssignmentChildDialogView  = new InvoiceAssignmentChildDialogView(this); 
            DeliveryNoteLabelPrintDialogView  = new DeliveryNoteLabelPrintDialogView(this); 
            DeliveryNoteComAgentNewChildDialogView  = new DeliveryNoteComAgentNewChildDialogView(this); 
            DeliveryFromOrderChildByArticleChildDialogView  = new DeliveryFromOrderChildByArticleChildDialogView(this); 
            DirectSeriesDataChildDialogView  = new DirectSeriesDataChildDialogView(this); 
            DeliveryNoteSLToRoadMapChildDialogView  = new DeliveryNoteSLToRoadMapChildDialogView(this); 
            AnalyticChildDialogView  = new AnalyticChildDialogView(this); 
            DepositChildDialogView  = new DepositChildDialogView(this); 
            LocationChildDialogView  = new LocationChildDialogView(this); 
            TransferChildDialogView  = new TransferChildDialogView(this); 
            CuDistDeliveryNoteFromPackingListPopUpDialogView  = new CuDistDeliveryNoteFromPackingListPopUpDialogView(this); 
            DeliveryNoteSLCollectionView.InitializeControls(); 
            DeliveryNoteSLEntityView.InitializeControls(); 
            DeliveryNoteLineSLView.InitializeControls(); 
            DeliveryNoteVariablePaymentSLView.InitializeControls(); 
            DeliveryNoteComAgentSLView.InitializeControls(); 
            DeliveryNoteLineCommercialAgentSLView.InitializeControls(); 
            DeliveryNoteLineMovementSLView.InitializeControls(); 
            OrderLineAnalyticSLView.InitializeControls(); 
            DeliveryNoteLineTaxSLView.InitializeControls(); 
            DeliveryNoteChangesChildDialogView.InitializeControls(); 
            PrintDeliveryNoteChildDialogView.InitializeControls(); 
            ArticleGenericChildDialogView.InitializeControls(); 
            PrintInvoiceChildDialogView.InitializeControls(); 
            NewConsumptionChildDialogView.InitializeControls(); 
            RecalculateIntrastatChildDialogView.InitializeControls(); 
            DeliveryFromOrderChildDialogView.InitializeControls(); 
            DeliveryFromOrderHeaderChildDialogView.InitializeControls(); 
            SeriesDataChildDialogView.InitializeControls(); 
            InvoiceAssignmentChildDialogView.InitializeControls(); 
            DeliveryNoteLabelPrintDialogView.InitializeControls(); 
            DeliveryNoteComAgentNewChildDialogView.InitializeControls(); 
            DeliveryFromOrderChildByArticleChildDialogView.InitializeControls(); 
            DirectSeriesDataChildDialogView.InitializeControls(); 
            DeliveryNoteSLToRoadMapChildDialogView.InitializeControls(); 
            AnalyticChildDialogView.InitializeControls(); 
            DepositChildDialogView.InitializeControls(); 
            LocationChildDialogView.InitializeControls(); 
            TransferChildDialogView.InitializeControls(); 
            CuDistDeliveryNoteFromPackingListPopUpDialogView.InitializeControls(); 
           
        }
      
            public DeliveryNoteSLCollectionView DeliveryNoteSLCollectionView {get; set; } 
            public DeliveryNoteSLEntityView DeliveryNoteSLEntityView {get; set; } 
            public DeliveryNoteLineSLView DeliveryNoteLineSLView {get; set; } 
            public DeliveryNoteVariablePaymentSLView DeliveryNoteVariablePaymentSLView {get; set; } 
            public DeliveryNoteComAgentSLView DeliveryNoteComAgentSLView {get; set; } 
            public DeliveryNoteLineCommercialAgentSLView DeliveryNoteLineCommercialAgentSLView {get; set; } 
            public DeliveryNoteLineMovementSLView DeliveryNoteLineMovementSLView {get; set; } 
            public OrderLineAnalyticSLView OrderLineAnalyticSLView {get; set; } 
            public DeliveryNoteLineTaxSLView DeliveryNoteLineTaxSLView {get; set; } 
            public DeliveryNoteChangesChildDialogView DeliveryNoteChangesChildDialogView {get; set; } 
            public PrintDeliveryNoteChildDialogView PrintDeliveryNoteChildDialogView {get; set; } 
            public ArticleGenericChildDialogView ArticleGenericChildDialogView {get; set; } 
            public PrintInvoiceChildDialogView PrintInvoiceChildDialogView {get; set; } 
            public NewConsumptionChildDialogView NewConsumptionChildDialogView {get; set; } 
            public RecalculateIntrastatChildDialogView RecalculateIntrastatChildDialogView {get; set; } 
            public DeliveryFromOrderChildDialogView DeliveryFromOrderChildDialogView {get; set; } 
            public DeliveryFromOrderHeaderChildDialogView DeliveryFromOrderHeaderChildDialogView {get; set; } 
            public SeriesDataChildDialogView SeriesDataChildDialogView {get; set; } 
            public InvoiceAssignmentChildDialogView InvoiceAssignmentChildDialogView {get; set; } 
            public DeliveryNoteLabelPrintDialogView DeliveryNoteLabelPrintDialogView {get; set; } 
            public DeliveryNoteComAgentNewChildDialogView DeliveryNoteComAgentNewChildDialogView {get; set; } 
            public DeliveryFromOrderChildByArticleChildDialogView DeliveryFromOrderChildByArticleChildDialogView {get; set; } 
            public DirectSeriesDataChildDialogView DirectSeriesDataChildDialogView {get; set; } 
            public DeliveryNoteSLToRoadMapChildDialogView DeliveryNoteSLToRoadMapChildDialogView {get; set; } 
            public AnalyticChildDialogView AnalyticChildDialogView {get; set; } 
            public DepositChildDialogView DepositChildDialogView {get; set; } 
            public LocationChildDialogView LocationChildDialogView {get; set; } 
            public TransferChildDialogView TransferChildDialogView {get; set; } 
            public CuDistDeliveryNoteFromPackingListPopUpDialogView CuDistDeliveryNoteFromPackingListPopUpDialogView {get; set; } 
    }
            
    public partial class DeliveryNoteSLCollectionView : View
    {
        public DeliveryNoteSLCollectionView(DeliveryNoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<DeliveryNoteSLCollectionView,DeliveryNoteSLEntityView>( this,Screen.DeliveryNoteSLEntityView);
 
            DeliveryFromOrderHeaderChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryNoteSLCollectionView,DeliveryFromOrderHeaderChildDialogView>("f745b0d1-c9f4-4dc8-a393-7ddc25aec526","","", this,Screen.DeliveryFromOrderHeaderChildDialogView);
 
            NewConsumptionChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryNoteSLCollectionView,NewConsumptionChildDialogView>("06e8af8f-8959-4cba-8f5a-059a9f64d947","","", this,Screen.NewConsumptionChildDialogView);
 
            CuDistDeliveryNoteFromPackingListPopUpNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryNoteSLCollectionView,CuDistDeliveryNoteFromPackingListPopUpDialogView>("88150668-9430-42e7-aaee-d41113efc583","","", this,Screen.CuDistDeliveryNoteFromPackingListPopUpDialogView);
 
            DepositChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryNoteSLCollectionView,DepositChildDialogView>("65a27619-802b-473a-b9b7-66ecc3f6e0b1","","", this,Screen.DepositChildDialogView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "5b7f111d-63b6-4cdd-98a4-ffb5b384e2c6",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<DeliveryNoteSLCollectionView,DeliveryNoteSLEntityView>( params_MainConsult,this,Screen.DeliveryNoteSLEntityView);
 

        }
        public IRPSButton<DeliveryNoteSLCollectionView,DeliveryNoteSLEntityView> NewButton { get; set; } 
        public IRPSButton<DeliveryNoteSLCollectionView,DeliveryFromOrderHeaderChildDialogView> DeliveryFromOrderHeaderChildNavigationCommandButton { get; set; } 
        public IRPSButton<DeliveryNoteSLCollectionView,NewConsumptionChildDialogView> NewConsumptionChildNavigationCommandButton { get; set; } 
        public IRPSButton<DeliveryNoteSLCollectionView,CuDistDeliveryNoteFromPackingListPopUpDialogView> CuDistDeliveryNoteFromPackingListPopUpNavigationCommandButton { get; set; } 
        public IRPSButton<DeliveryNoteSLCollectionView,DepositChildDialogView> DepositChildNavigationCommandButton { get; set; } 
        public IRPSCollectionEditor<DeliveryNoteSLCollectionView,DeliveryNoteSLEntityView> MainConsult { get; set; } 
        public DeliveryNoteSL Screen { get; set; }
        public DeliveryNoteSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DeliveryNoteSLEntityView : View
    {
        public DeliveryNoteSLEntityView(DeliveryNoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<DeliveryNoteSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<DeliveryNoteSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DeliveryNoteSLEntityView,DeliveryNoteSLCollectionView>( this,Screen.DeliveryNoteSLCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<DeliveryNoteSLEntityView,DeliveryNoteSLCollectionView>( this,Screen.DeliveryNoteSLCollectionView);
 
            UITotalLinesAmount = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteSLEntityView>("7aeeb1e8-e85a-4373-9c6c-24c55ef96a04","","",false, this);
 
            UITotalBase = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteSLEntityView>("6f07a093-9ede-4850-87d0-fdd0445e9db5","","",false, this);
 
            UIVATAmount = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteSLEntityView>("2c894e79-a088-4c34-9174-b9be5181cce1","","",false, this);
 
            UITotalTax = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteSLEntityView>("e9ec733a-6b90-4aec-ab45-b5b726ea5f48","","",false, this);
 
            UITotalDeliveryNote = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteSLEntityView>("4d50ba97-b384-434d-a3c7-462fbd009e64","","",false, this);
 
            Transport = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteSLEntityView>("14fd1bef-bfc9-4581-bc2a-0fd3dfca815f","","",true, this);
 
            AddDeliveryNoteLineSLFromCustomerArticleCommandButton = RPSControlFactory.CreateRPSButton<DeliveryNoteSLEntityView>( "aeb4d347-d976-4903-8f7f-454d7296d783","","",this);
 
            DeliveryNoteChangesChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryNoteSLEntityView,DeliveryNoteChangesChildDialogView>("87d67185-806a-4ad7-a18c-35c77ab2c20d","","", this,Screen.DeliveryNoteChangesChildDialogView);
 
            CodDeliveryNote = RPSControlFactory.CreateRPSTextBox<DeliveryNoteSLEntityView>("e1da910d-ecf0-46fd-85c1-81fd2e4cb2c2","","",true, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("170c6756-dc24-49eb-a132-9bfffd7ef38c","","",true, this);
 
            IDCustomerMiscellaneous = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("125ed955-3e7f-412d-a8a4-c9ced3328409","","",false, this);
 
            IDContactAdministration = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("6b8a753c-5843-443c-bced-720bba2a0cee","","",false, this);
 
            CodOrder = RPSControlFactory.CreateRPSTextBox<DeliveryNoteSLEntityView>("54fc9533-639a-43c9-a23d-94694ec578fe","","",false, this);
 
            DeliveryNoteDate = RPSControlFactory.CreateRPSTextBox<DeliveryNoteSLEntityView>("c46cea17-263c-419a-8881-c43ad2ebf0b2","","",true, this);
 
            OrderNumberCustomer = RPSControlFactory.CreateRPSTextBox<DeliveryNoteSLEntityView>("c5fc9125-5d22-4436-a25c-cc461853ee5e","","",false, this);
 
            Situation = RPSControlFactory.CreateRPSEnumComboBox<DeliveryNoteSLEntityView>("dea7e59d-bb04-4ef0-8db7-f081882ea213","","",true, this);
 
            DocumentType = RPSControlFactory.CreateRPSEnumComboBox<DeliveryNoteSLEntityView>("9c034297-997c-4f86-8cea-b0be0b37c030","","",false, this);
 
            CodFromInvoice = RPSControlFactory.CreateRPSTextBox<DeliveryNoteSLEntityView>("e995ad7b-76a5-4786-845e-ddd9a6e0153d","","",false, this);
 
            Blocked = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteSLEntityView>("d27afd9a-2e34-457d-91c5-3ba73074a3aa","","",true, this);
 
            Direct = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteSLEntityView>("3b6a1067-a9e6-41cf-8500-451c49c11eb4","","",true, this);
 
            RequiredPrinted = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteSLEntityView>("0952aafb-5f86-4240-ab81-14f004bcdc91","","",true, this);
 
            Consumption = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteSLEntityView>("8a1ea6a2-043a-41ba-9b8b-6b27fc4fe0f6","","",true, this);
 
            ExternalTask = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteSLEntityView>("03f5cb28-29dc-48e3-b348-dae0c9ff5004","","",true, this);
 
            IsFromPacking = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteSLEntityView>("36f2c728-a24a-4f62-b5ea-d99eb4d46c49","","",true, this);
 
            UICodCompanyPurchase = RPSControlFactory.CreateRPSTextBox<DeliveryNoteSLEntityView>("e1853786-8435-41c9-9c89-8b37981e6341","","",false, this);
 
            IDIntDeliveryNotePurchase = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("ac415b8a-22a4-45fc-b9a0-16f27179542a","","",false, this);
 
            IDCodingSerieOrder = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("57532808-9e76-4630-937e-07872b02d586","","",false, this);
 
            IDCodingSerieDeliveryNote = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("aa6f1eb5-7da1-4ff7-a2fd-3e037dc2ded4","","",false, this);
 
            IDCodingSerieInvoice = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("72ce3f40-e111-43b1-a18a-d00462c6019c","","",false, this);
 
            IDBusinessUnit = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("1cf11ee3-f7f1-4559-a72d-53ebfa616d56","","",false, this);
 
            IDDeliveryNoteTypeGroup = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("ad1293b3-b48e-47e7-909b-88790481f477","","",true, this);
 
            IDInvoiceTypeGroup = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("17d16f59-83a8-4d7b-a275-d0c5bb0424fc","","",true, this);
 
            IDInvoicingType = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("483fc7cc-7e6b-4f88-8d39-5a3135ef1f6c","","",true, this);
 
            ReprintOrder = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteSLEntityView>("500be958-344a-4bf2-a0b6-6c82030ecadb","","",true, this);
 
            IDCustomerPaymentAddress = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("aa6f7eff-81b8-48de-832b-90ff916333f9","","",false, this);
 
            IDCustomerBankAccount = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("42e1efcc-4da9-4a9c-ae86-b8e1782e614e","","",false, this);
 
            IDVoucherType = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("dd8328e5-e35a-4e0c-ad9c-41172ecb62cc","","",false, this);
 
            IDBankAccountCompany = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("bf466f1b-682f-4508-b0c2-e9d268dcc790","","",false, this);
 
            RentingInvoice = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteSLEntityView>("f6b2806c-15d4-483e-a86d-9b02d497b81f","","",false, this);
 
            IDFixedAsset = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("bbc3a1e2-fc54-466d-acbf-e3639bfafc2c","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("95791ff6-11e0-49f2-97d3-03e841631ac9","","",false, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("55566cd3-4d90-4100-889d-f256d177518d","","",false, this);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("21c24086-fadf-45cd-97d1-67076d5c870c","","",false, this);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("43489c0a-5a71-4031-a8db-9895c84c0139","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("e9e2b853-e2eb-4cb4-aade-0a8106ddaaf8","","",true, this);
 
            Change = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteSLEntityView>("2d6cd853-6030-4714-8824-691bcc587abf","","",true, this);
 
            FixedChange = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteSLEntityView>("220c1e07-d122-44e0-b444-7563169f1418","","",true, this);
 
            IDPriceList = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("63fe93f5-da37-43fd-93e0-0fd6e651c65b","","",false, this);
 
            IDVATType = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("c98e75e0-87eb-48ec-8dbb-b51c2d7f11f4","","",true, this);
 
            IDSurchargeVATType = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("870b3c11-dc3b-451b-8319-f9021255b54f","","",false, this);
 
            IDTaxGroup = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("10a03357-7695-4990-ba13-f1fd30be3647","","",false, this);
 
            Transport1 = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteSLEntityView>("938459b1-daae-4a25-9280-bbf14c67644f","","",true, this);
 
            Discount1 = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteSLEntityView>("6e19bf1b-3add-480f-97ad-14756cb26345","","",true, this);
 
            Discount2 = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteSLEntityView>("42e73489-6eac-4f89-83b8-c61cf2dcb053","","",true, this);
 
            Discount3 = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteSLEntityView>("c918a148-45a4-462a-b8f0-b6d493804938","","",true, this);
 
            CashDiscount = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteSLEntityView>("62012b49-c571-4233-922b-03857c9eb1fc","","",true, this);
 
            FinancialSurcharge = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteSLEntityView>("c47aed44-39a6-4741-baa7-39f199d90f1d","","",true, this);
 
            RetentionPercent = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteSLEntityView>("f97deccd-e855-4ce3-bd01-3515df158cc4","","",true, this);
 
            IDCustomerDeliveryAddress = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("46ca8318-c021-46eb-a8a5-bf5097ff20e4","","",false, this);
 
            CodCountryDelivery = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("7effc0b3-b792-441e-96f1-c950520bda5e","","",false, this);
 
            ZipCodeDelivery = RPSControlFactory.CreateRPSTextBox<DeliveryNoteSLEntityView>("2ee40251-2f79-4693-a01c-ed62afb65288","","",false, this);
 
            IDStateDelivery = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("559816ce-a27f-4342-8498-f3dbd7ac9d30","","",false, this);
 
            IDCountyDelivery = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("0117b8bc-ee91-4520-bbaa-d86cfd69a650","","",false, this);
 
            AddressDelivery = RPSControlFactory.CreateRPSTextBox<DeliveryNoteSLEntityView>("0ac2e503-698b-4213-aa02-4be752deaddb","","",false, this);
 
            CityDelivery = RPSControlFactory.CreateRPSTextBox<DeliveryNoteSLEntityView>("c6ac010c-5108-4f8f-be74-b2dab0ea02b2","","",false, this);
 
            Phone1Delivery = RPSControlFactory.CreateRPSTextBox<DeliveryNoteSLEntityView>("cb3250ca-4e2b-44cf-8bff-b2cf3641ab2a","","",false, this);
 
            Phone2Delivery = RPSControlFactory.CreateRPSTextBox<DeliveryNoteSLEntityView>("c2e6ac62-abec-4ea8-a2dd-70b1d3c8b568","","",false, this);
 
            FaxDelivery = RPSControlFactory.CreateRPSTextBox<DeliveryNoteSLEntityView>("3abc87de-e18f-40b6-bc64-07c9d346c47e","","",false, this);
 
            ContactPersonDelivery = RPSControlFactory.CreateRPSTextBox<DeliveryNoteSLEntityView>("1a596324-f05f-41f3-a72f-ad48badb5845","","",false, this);
 
            IDShippingAgent = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("7cbcbb28-4b9c-44f0-83ae-114a8c7553c7","","",false, this);
 
            ManualWeight = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteSLEntityView>("f9ac77b1-f191-4768-a7bb-410ba0c76062","","",true, this);
 
            IDPackingList = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("0ff35b3b-3f46-4c49-8d71-78c072e5897b","","",false, this);
 
            NetWeight = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteSLEntityView>("4998af65-27f4-4545-9419-840b9fd662aa","","",true, this);
 
            GrossWeight = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteSLEntityView>("8b1e6a17-5201-420c-89ed-c1fbda8b5404","","",true, this);
 
            NumBoxes = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteSLEntityView>("382c6404-dbb1-4558-9c27-451301a40d51","","",true, this);
 
            Volume = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteSLEntityView>("2c09804c-e7a6-4f81-9f80-8bb81b19574c","","",true, this);
 
            AddressDescription = RPSControlFactory.CreateRPSTextBox<DeliveryNoteSLEntityView>("d2fbd789-f590-4b92-b1ba-db1494290580","","",false, this);
 
            CodBusinessType = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("031f59f8-085d-4b07-858c-b74e8e44c500","","",false, this);
 
            CodTransportMethod = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("fb0ae5ed-7c18-4026-bd73-a13020bbb923","","",false, this);
 
            CodHarborAirport = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("d0448804-b0b8-4a7d-84f0-572a2bc0f027","","",false, this);
 
            CodDeliveryTerm = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("9ee8a217-ad88-4c19-b696-9d49c709999f","","",false, this);
 
            StatisticRegime = RPSControlFactory.CreateRPSEnumComboBox<DeliveryNoteSLEntityView>("9bf9efd3-4d0c-4a14-a12a-0c6f6dd4f0db","","",false, this);
 
            PercentSales = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteSLEntityView>("7de8beb8-709d-4f9b-86f6-51ef660172a2","","",true, this);
 
            IDMaintenanceOrder = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("33dc1efa-2a87-4298-a07b-42bf3b8ee271","","",false, this);
 
            UICodMaintenanceContract = RPSControlFactory.CreateRPSTextBox<DeliveryNoteSLEntityView>("040cf6c3-3086-43cc-a90d-b038da8a093e","","",false, this);
 
            DeliveryNoteComAgentNewChildNavigationCommand = RPSControlFactory.CreateRPSButtonToView<DeliveryNoteSLEntityView,DeliveryNoteComAgentNewChildDialogView>("101842df-9045-4680-b6af-53f9e6d1e27e","","", this,Screen.DeliveryNoteComAgentNewChildDialogView);
 
            Comment = RPSControlFactory.CreateRPSTextBox<DeliveryNoteSLEntityView>("b5254e0c-50aa-478e-88d7-44f3a81b6734","","",false, this);
 
            CommentInvoice = RPSControlFactory.CreateRPSTextBox<DeliveryNoteSLEntityView>("fef3f4fa-a0d1-4d4a-b969-d35ea5af50f4","","",false, this);
 
            PreTextIDTextLine = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("0cc188df-fa78-44d3-a88e-620c3758124c","","",false, this);
 
            PreText = RPSControlFactory.CreateRPSTextBox<DeliveryNoteSLEntityView>("dbf62712-078c-4215-924a-78b82a7bcd5c","","",false, this);
 
            PostTextIDTextLine = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("ed4e543a-7341-4f27-8bf8-54cd9f274be5","","",false, this);
 
            PostText = RPSControlFactory.CreateRPSTextBox<DeliveryNoteSLEntityView>("27ec3dec-c4de-4569-8183-5023d80a2dfc","","",false, this);
 
            PreTextIDTextLineInvoice = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("ffca4dca-8097-463c-bb12-bf3fe7f83857","","",false, this);
 
            PreTextInvoice = RPSControlFactory.CreateRPSTextBox<DeliveryNoteSLEntityView>("eebe07a4-b4d2-4de4-99e0-09fb5557acf1","","",false, this);
 
            PostTextIDTextLineInvoice = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("cd774a3d-c094-4353-a326-bd20b7e463b9","","",false, this);
 
            PostTextInvoice = RPSControlFactory.CreateRPSTextBox<DeliveryNoteSLEntityView>("8b107895-9950-428c-9ae4-2a009a194478","","",false, this);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("430e2e0c-4d66-4094-9e20-2fb7a3242f4f","","",false, this);
 
            IDReceptionAddress = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("40129f7e-a16b-4df5-a7ab-c47855d36da3","","",false, this);
 
            RACodCountry = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("10fe661a-9dff-419b-a398-716e92864a17","","",false, this);
 
            IDRAState = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("89f5ba4f-d3d0-4abf-a635-74a91854c627","","",false, this);
 
            IDRACounty = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLEntityView>("38b53819-e9e3-43d4-ad3a-e9b92a5504b3","","",false, this);
 
            RAZipCode = RPSControlFactory.CreateRPSEnumComboBox<DeliveryNoteSLEntityView>("09e7bf2e-d1b4-4fa2-9937-127c5a25ca32","","",false, this);
 
            RACity = RPSControlFactory.CreateRPSTextBox<DeliveryNoteSLEntityView>("f8f23315-520c-492e-acde-49f02739d3df","","",false, this);
 
            RAContactPerson = RPSControlFactory.CreateRPSTextBox<DeliveryNoteSLEntityView>("c152218f-f35d-4cb0-9066-e4dbea51eed7","","",false, this);
 
            RAPhone1 = RPSControlFactory.CreateRPSTextBox<DeliveryNoteSLEntityView>("0c3fe267-60e0-4fc7-8d6c-a2d68ecdd831","","",false, this);
 
            RAPhone2 = RPSControlFactory.CreateRPSTextBox<DeliveryNoteSLEntityView>("c3eb1fb8-572d-4e32-b526-86a474cb06ce","","",false, this);
 
            RAFax = RPSControlFactory.CreateRPSTextBox<DeliveryNoteSLEntityView>("a94f9906-2bf1-474f-b0e6-5f1561a6b786","","",false, this);
 
            RAAddressDelivery = RPSControlFactory.CreateRPSTextBox<DeliveryNoteSLEntityView>("362b6e52-0133-438f-803c-46e7d8f151c5","","",false, this);
 
            PrintDeliveryNoteChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryNoteSLEntityView,PrintDeliveryNoteChildDialogView>("86034a29-0326-430e-a313-b6007442955b","","", this,Screen.PrintDeliveryNoteChildDialogView);
 
            TotalsUpdateButton = RPSControlFactory.CreateRPSButton<DeliveryNoteSLEntityView>( "ca522779-27d5-4d51-a630-e8de354b8ca1","","",this);
 
            DeliveryFromOrderChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryNoteSLEntityView,DeliveryFromOrderChildDialogView>("de300339-36eb-4fc8-805e-16d7889604f2","","", this,Screen.DeliveryFromOrderChildDialogView);
 
            PrintInvoiceChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryNoteSLEntityView,PrintInvoiceChildDialogView>("b9280793-16e1-4fbf-a9a6-0e11935dd173","","", this,Screen.PrintInvoiceChildDialogView);
 
            FinalizedCommandButton = RPSControlFactory.CreateRPSButton<DeliveryNoteSLEntityView>( "674709b2-5f0c-463c-971d-4b86198f71b6","","",this);
 
            ExecuteUnFinalizedButton = RPSControlFactory.CreateRPSButton<DeliveryNoteSLEntityView>( "3597c9df-c74c-4bdd-85b5-f47467da72ec","","",this);
 
            RecalculatePromotionButton = RPSControlFactory.CreateRPSButton<DeliveryNoteSLEntityView>( "e46d37d3-ad15-4fab-9b60-a88a3d3d2a45","","",this);
 
            ExecuteCalculateWeightButton = RPSControlFactory.CreateRPSButton<DeliveryNoteSLEntityView>( "0793855d-a08c-4aa5-994b-f1607eea4402","","",this);
 
            ExecuteUpdateTransportAmountButton = RPSControlFactory.CreateRPSButton<DeliveryNoteSLEntityView>( "be5d1c04-f14b-44a5-b734-653a51f15030","","",this);
 
            DeliveryNoteSLToRoadMapChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryNoteSLEntityView,DeliveryNoteSLToRoadMapChildDialogView>("551b1408-46f6-4ddc-8f48-358258726853","","", this,Screen.DeliveryNoteSLToRoadMapChildDialogView);
 
            InvoiceAssignmentChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryNoteSLEntityView,InvoiceAssignmentChildDialogView>("862ac501-89c7-4e90-ba6e-b49e894cac82","","", this,Screen.InvoiceAssignmentChildDialogView);
 
            DeliveryNoteLabelPrintNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryNoteSLEntityView,DeliveryNoteLabelPrintDialogView>("f3636d77-9142-4f4f-a75b-adc9e9f9639c","","", this,Screen.DeliveryNoteLabelPrintDialogView);
 
            RecalculateIntrastatChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryNoteSLEntityView,RecalculateIntrastatChildDialogView>("8db43373-84a9-43c4-8cf5-ef4dc8582a58","","", this,Screen.RecalculateIntrastatChildDialogView);
 
            CollectionInit params_DeliveryNoteLineSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="96c3634a-7879-427e-974d-a38a6bb34187",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNoteLineSLs = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNoteLineSLsCollectionEditor<DeliveryNoteSLEntityView,DeliveryNoteLineSLView>,DeliveryNoteSLEntityView,DeliveryNoteLineSLView>( params_DeliveryNoteLineSLs,this,Screen.DeliveryNoteLineSLView);
 
            CollectionInit params_DeliveryNoteVariablePaymentSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="42b69389-6e2b-4531-97de-a4e96d112ed3",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNoteVariablePaymentSLs = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNoteVariablePaymentSLsCollectionEditor<DeliveryNoteSLEntityView,DeliveryNoteLineSLView>,DeliveryNoteSLEntityView,DeliveryNoteLineSLView>( params_DeliveryNoteVariablePaymentSLs,this,Screen.DeliveryNoteLineSLView);
 
            CollectionInit params_DeliveryNoteComAgentSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="75add846-02d6-424f-bed0-46abc56f416e",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNoteComAgentSLs = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNoteComAgentSLsCollectionEditor<DeliveryNoteSLEntityView,DeliveryNoteLineSLView>,DeliveryNoteSLEntityView,DeliveryNoteLineSLView>( params_DeliveryNoteComAgentSLs,this,Screen.DeliveryNoteLineSLView);
 
            LinesSection = RPSControlFactory.CreateRPSSection<DeliveryNoteSLEntityView>( "","ul li[rpsid='7bab9c00-cc14-4630-bc9e-0715a0d7173e']","",this);
 
            GeneralDataSection = RPSControlFactory.CreateRPSSection<DeliveryNoteSLEntityView>( "","ul li[rpsid='03f43cca-bc4f-488f-9812-ebc3951620fd']","",this);
 
            VariablePaymentsSection = RPSControlFactory.CreateRPSSection<DeliveryNoteSLEntityView>( "","ul li[rpsid='d597be9c-89ab-4bb2-8c22-7b0950ddfb18']","",this);
 
            CommercialAgentSection = RPSControlFactory.CreateRPSSection<DeliveryNoteSLEntityView>( "","ul li[rpsid='a92a482c-d89b-4469-8e64-5d19f87860d9']","",this);
 
            CommentSection = RPSControlFactory.CreateRPSSection<DeliveryNoteSLEntityView>( "","ul li[rpsid='1244ef3e-c365-485d-bb96-e9a69071d1e0']","",this);
 
            TextLine = RPSControlFactory.CreateRPSSection<DeliveryNoteSLEntityView>( "","ul li[rpsid='d0ff027d-889c-42d8-8f93-25c64ad92973']","",this);
 
            Section = RPSControlFactory.CreateRPSSection<DeliveryNoteSLEntityView>( "","ul li[rpsid='f5e7d807-3967-4c0c-b5ae-3ac07d24e67d']","",this);
 
            DPS = RPSControlFactory.CreateRPSSection<DeliveryNoteSLEntityView>( "","ul li[rpsid='fe3a8043-5992-4ebf-b10c-404e8c48366d']","",this);
 
            ReceptionAddress = RPSControlFactory.CreateRPSSection<DeliveryNoteSLEntityView>( "","ul li[rpsid='21bd5b31-d20b-41e7-8726-3cf13a5cab0b']","",this);
 

        }
        public IRPSSaveButton<DeliveryNoteSLEntityView> SaveButton { get; set; } 
        public IRPSButton<DeliveryNoteSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<DeliveryNoteSLEntityView,DeliveryNoteSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DeliveryNoteSLEntityView,DeliveryNoteSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> UITotalLinesAmount { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> UITotalBase { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> UIVATAmount { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> UITotalTax { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> UITotalDeliveryNote { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> Transport { get; set; } 
        public IRPSButton<DeliveryNoteSLEntityView> AddDeliveryNoteLineSLFromCustomerArticleCommandButton { get; set; } 
        public IRPSButton<DeliveryNoteSLEntityView,DeliveryNoteChangesChildDialogView> DeliveryNoteChangesChildNavigationCommandButton { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> CodDeliveryNote { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> IDCustomer { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> IDCustomerMiscellaneous { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> IDContactAdministration { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> CodOrder { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> DeliveryNoteDate { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> OrderNumberCustomer { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> Situation { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> DocumentType { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> CodFromInvoice { get; set; } 
        public IRPSCheckbox<DeliveryNoteSLEntityView> Blocked { get; set; } 
        public IRPSCheckbox<DeliveryNoteSLEntityView> Direct { get; set; } 
        public IRPSCheckbox<DeliveryNoteSLEntityView> RequiredPrinted { get; set; } 
        public IRPSCheckbox<DeliveryNoteSLEntityView> Consumption { get; set; } 
        public IRPSCheckbox<DeliveryNoteSLEntityView> ExternalTask { get; set; } 
        public IRPSCheckbox<DeliveryNoteSLEntityView> IsFromPacking { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> UICodCompanyPurchase { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> IDIntDeliveryNotePurchase { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> IDCodingSerieOrder { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> IDCodingSerieDeliveryNote { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> IDCodingSerieInvoice { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> IDBusinessUnit { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> IDDeliveryNoteTypeGroup { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> IDInvoiceTypeGroup { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> IDInvoicingType { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> ReprintOrder { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> IDCustomerPaymentAddress { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> IDCustomerBankAccount { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> IDVoucherType { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> IDBankAccountCompany { get; set; } 
        public IRPSCheckbox<DeliveryNoteSLEntityView> RentingInvoice { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> IDFixedAsset { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> IDSite { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> IDWarehouse { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> IDDeliveryNoteType { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> IDPaymentMethod { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> IDCurrency { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> Change { get; set; } 
        public IRPSCheckbox<DeliveryNoteSLEntityView> FixedChange { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> IDPriceList { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> IDVATType { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> IDSurchargeVATType { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> IDTaxGroup { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> Transport1 { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> Discount1 { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> Discount2 { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> Discount3 { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> CashDiscount { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> FinancialSurcharge { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> RetentionPercent { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> IDCustomerDeliveryAddress { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> CodCountryDelivery { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> ZipCodeDelivery { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> IDStateDelivery { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> IDCountyDelivery { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> AddressDelivery { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> CityDelivery { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> Phone1Delivery { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> Phone2Delivery { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> FaxDelivery { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> ContactPersonDelivery { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> IDShippingAgent { get; set; } 
        public IRPSCheckbox<DeliveryNoteSLEntityView> ManualWeight { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> IDPackingList { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> NetWeight { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> GrossWeight { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> NumBoxes { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> Volume { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> AddressDescription { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> CodBusinessType { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> CodTransportMethod { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> CodHarborAirport { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> CodDeliveryTerm { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> StatisticRegime { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> PercentSales { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> IDMaintenanceOrder { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> UICodMaintenanceContract { get; set; } 
        public IRPSButton<DeliveryNoteSLEntityView,DeliveryNoteComAgentNewChildDialogView> DeliveryNoteComAgentNewChildNavigationCommand { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> Comment { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> CommentInvoice { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> PreTextIDTextLine { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> PreText { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> PostTextIDTextLine { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> PostText { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> PreTextIDTextLineInvoice { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> PreTextInvoice { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> PostTextIDTextLineInvoice { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> PostTextInvoice { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> IDEmployee { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> IDReceptionAddress { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> RACodCountry { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> IDRAState { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> IDRACounty { get; set; } 
        public IRPSComboBox<DeliveryNoteSLEntityView> RAZipCode { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> RACity { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> RAContactPerson { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> RAPhone1 { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> RAPhone2 { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> RAFax { get; set; } 
        public IRPSTextBox<DeliveryNoteSLEntityView> RAAddressDelivery { get; set; } 
        public IRPSButton<DeliveryNoteSLEntityView,PrintDeliveryNoteChildDialogView> PrintDeliveryNoteChildNavigationCommandButton { get; set; } 
        public IRPSButton<DeliveryNoteSLEntityView> TotalsUpdateButton { get; set; } 
        public IRPSButton<DeliveryNoteSLEntityView,DeliveryFromOrderChildDialogView> DeliveryFromOrderChildNavigationCommandButton { get; set; } 
        public IRPSButton<DeliveryNoteSLEntityView,PrintInvoiceChildDialogView> PrintInvoiceChildNavigationCommandButton { get; set; } 
        public IRPSButton<DeliveryNoteSLEntityView> FinalizedCommandButton { get; set; } 
        public IRPSButton<DeliveryNoteSLEntityView> ExecuteUnFinalizedButton { get; set; } 
        public IRPSButton<DeliveryNoteSLEntityView> RecalculatePromotionButton { get; set; } 
        public IRPSButton<DeliveryNoteSLEntityView> ExecuteCalculateWeightButton { get; set; } 
        public IRPSButton<DeliveryNoteSLEntityView> ExecuteUpdateTransportAmountButton { get; set; } 
        public IRPSButton<DeliveryNoteSLEntityView,DeliveryNoteSLToRoadMapChildDialogView> DeliveryNoteSLToRoadMapChildNavigationCommandButton { get; set; } 
        public IRPSButton<DeliveryNoteSLEntityView,InvoiceAssignmentChildDialogView> InvoiceAssignmentChildNavigationCommandButton { get; set; } 
        public IRPSButton<DeliveryNoteSLEntityView,DeliveryNoteLabelPrintDialogView> DeliveryNoteLabelPrintNavigationCommandButton { get; set; } 
        public IRPSButton<DeliveryNoteSLEntityView,RecalculateIntrastatChildDialogView> RecalculateIntrastatChildNavigationCommandButton { get; set; } 
        public DeliveryNoteLineSLsCollectionEditor<DeliveryNoteSLEntityView,DeliveryNoteLineSLView> DeliveryNoteLineSLs { get; set; } 
        public DeliveryNoteVariablePaymentSLsCollectionEditor<DeliveryNoteSLEntityView,DeliveryNoteLineSLView> DeliveryNoteVariablePaymentSLs { get; set; } 
        public DeliveryNoteComAgentSLsCollectionEditor<DeliveryNoteSLEntityView,DeliveryNoteLineSLView> DeliveryNoteComAgentSLs { get; set; } 
        public IRPSSection<DeliveryNoteSLEntityView> LinesSection { get; set; } 
        public IRPSSection<DeliveryNoteSLEntityView> GeneralDataSection { get; set; } 
        public IRPSSection<DeliveryNoteSLEntityView> VariablePaymentsSection { get; set; } 
        public IRPSSection<DeliveryNoteSLEntityView> CommercialAgentSection { get; set; } 
        public IRPSSection<DeliveryNoteSLEntityView> CommentSection { get; set; } 
        public IRPSSection<DeliveryNoteSLEntityView> TextLine { get; set; } 
        public IRPSSection<DeliveryNoteSLEntityView> Section { get; set; } 
        public IRPSSection<DeliveryNoteSLEntityView> DPS { get; set; } 
        public IRPSSection<DeliveryNoteSLEntityView> ReceptionAddress { get; set; } 
        public DeliveryNoteSL Screen { get; set; }
        public DeliveryNoteSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DeliveryNoteLineSLsCollectionEditor<DeliveryNoteSLEntityView,DeliveryNoteLineSLView>:RPSCollectionEditor<DeliveryNoteSLEntityView,DeliveryNoteLineSLView> where DeliveryNoteSLEntityView : class, IView where DeliveryNoteLineSLView : class, IView
    {
        public  DeliveryNoteLineSLsGridView<DeliveryNoteSLEntityView,DeliveryNoteLineSLView> GridView {get;set;}
    }
    public partial class DeliveryNoteLineSLsGridView <DeliveryNoteSLEntityView,DeliveryNoteLineSLView> :  RPSGridView<DeliveryNoteSLEntityView,DeliveryNoteLineSLView> where DeliveryNoteSLEntityView : class, IView where DeliveryNoteLineSLView : class, IView
    {
        public DeliveryNoteLineSLsGridView(DeliveryNoteSLEntityView currentView,DeliveryNoteLineSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDOrderLine = RPSControlFactory.CreateRPSGridComboBox<DeliveryNoteSLEntityView>("","#96c3634a-7879-427e-974d-a38a6bb34187 .ag-row[role='row']@ROWINDEX [col-id='cIDOrderLine']","",true, this.CurrentView);
 
            Ordenation = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteSLEntityView>("","#96c3634a-7879-427e-974d-a38a6bb34187 .ag-row[role='row']@ROWINDEX [col-id='cOrdenation']","",true, this.CurrentView);
 
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<DeliveryNoteSLEntityView>("","#96c3634a-7879-427e-974d-a38a6bb34187 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            UIDescription = RPSControlFactory.CreateRPSGridTextBox<DeliveryNoteSLEntityView>("","#96c3634a-7879-427e-974d-a38a6bb34187 .ag-row[role='row']@ROWINDEX [col-id='cUIDescription']","",false, this.CurrentView);
 
            PlanNumber = RPSControlFactory.CreateRPSGridTextBox<DeliveryNoteSLEntityView>("","#96c3634a-7879-427e-974d-a38a6bb34187 .ag-row[role='row']@ROWINDEX [col-id='cPlanNumber']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteSLEntityView>("","#96c3634a-7879-427e-974d-a38a6bb34187 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            Price = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteSLEntityView>("","#96c3634a-7879-427e-974d-a38a6bb34187 .ag-row[role='row']@ROWINDEX [col-id='cPrice']","",true, this.CurrentView);
 
            Discount1 = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteSLEntityView>("","#96c3634a-7879-427e-974d-a38a6bb34187 .ag-row[role='row']@ROWINDEX [col-id='cDiscount1']","",true, this.CurrentView);
 
            PercentVAT = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteSLEntityView>("","#96c3634a-7879-427e-974d-a38a6bb34187 .ag-row[role='row']@ROWINDEX [col-id='cPercentVAT']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteSLEntityView>("","#96c3634a-7879-427e-974d-a38a6bb34187 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            AmountWithVAT = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteSLEntityView>("","#96c3634a-7879-427e-974d-a38a6bb34187 .ag-row[role='row']@ROWINDEX [col-id='cAmountWithVAT']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<DeliveryNoteSLEntityView> IDOrderLine { get; set; } 
        public IRPSGridTextBox<DeliveryNoteSLEntityView> Ordenation { get; set; } 
        public IRPSGridComboBox<DeliveryNoteSLEntityView> IDArticle { get; set; } 
        public IRPSGridTextBox<DeliveryNoteSLEntityView> UIDescription { get; set; } 
        public IRPSGridTextBox<DeliveryNoteSLEntityView> PlanNumber { get; set; } 
        public IRPSGridTextBox<DeliveryNoteSLEntityView> Quantity { get; set; } 
        public IRPSGridTextBox<DeliveryNoteSLEntityView> Price { get; set; } 
        public IRPSGridTextBox<DeliveryNoteSLEntityView> Discount1 { get; set; } 
        public IRPSGridTextBox<DeliveryNoteSLEntityView> PercentVAT { get; set; } 
        public IRPSGridTextBox<DeliveryNoteSLEntityView> Amount { get; set; } 
        public IRPSGridTextBox<DeliveryNoteSLEntityView> AmountWithVAT { get; set; } 
                     
    }
 
        public partial class DeliveryNoteVariablePaymentSLsCollectionEditor<DeliveryNoteSLEntityView,DeliveryNoteLineSLView>:RPSCollectionEditor<DeliveryNoteSLEntityView,DeliveryNoteLineSLView> where DeliveryNoteSLEntityView : class, IView where DeliveryNoteLineSLView : class, IView
    {
        public  DeliveryNoteVariablePaymentSLsGridView<DeliveryNoteSLEntityView,DeliveryNoteLineSLView> GridView {get;set;}
    }
    public partial class DeliveryNoteVariablePaymentSLsGridView <DeliveryNoteSLEntityView,DeliveryNoteLineSLView> :  RPSGridView<DeliveryNoteSLEntityView,DeliveryNoteLineSLView> where DeliveryNoteSLEntityView : class, IView where DeliveryNoteLineSLView : class, IView
    {
        public DeliveryNoteVariablePaymentSLsGridView(DeliveryNoteSLEntityView currentView,DeliveryNoteLineSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NumPayment = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteSLEntityView>("","#42b69389-6e2b-4531-97de-a4e96d112ed3 .ag-row[role='row']@ROWINDEX [col-id='cNumPayment']","",true, this.CurrentView);
 
            DatePayment = RPSControlFactory.CreateRPSGridTextBox<DeliveryNoteSLEntityView>("","#42b69389-6e2b-4531-97de-a4e96d112ed3 .ag-row[role='row']@ROWINDEX [col-id='cDatePayment']","",false, this.CurrentView);
 
            DayPayment = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteSLEntityView>("","#42b69389-6e2b-4531-97de-a4e96d112ed3 .ag-row[role='row']@ROWINDEX [col-id='cDayPayment']","",false, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteSLEntityView>("","#42b69389-6e2b-4531-97de-a4e96d112ed3 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteSLEntityView>("","#42b69389-6e2b-4531-97de-a4e96d112ed3 .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",true, this.CurrentView);
 
            Rest = RPSControlFactory.CreateRPSGridCheckBox<DeliveryNoteSLEntityView>("","#42b69389-6e2b-4531-97de-a4e96d112ed3 .ag-row[role='row']@ROWINDEX [col-id='cRest']","",true, this.CurrentView);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSGridComboBox<DeliveryNoteSLEntityView>("","#42b69389-6e2b-4531-97de-a4e96d112ed3 .ag-row[role='row']@ROWINDEX [col-id='cIDPaymentMethod']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<DeliveryNoteSLEntityView> NumPayment { get; set; } 
        public IRPSGridTextBox<DeliveryNoteSLEntityView> DatePayment { get; set; } 
        public IRPSGridTextBox<DeliveryNoteSLEntityView> DayPayment { get; set; } 
        public IRPSGridTextBox<DeliveryNoteSLEntityView> Amount { get; set; } 
        public IRPSGridTextBox<DeliveryNoteSLEntityView> Percentage { get; set; } 
        public IRPSGridCheckbox<DeliveryNoteSLEntityView> Rest { get; set; } 
        public IRPSGridComboBox<DeliveryNoteSLEntityView> IDPaymentMethod { get; set; } 
                     
    }
 
        public partial class DeliveryNoteComAgentSLsCollectionEditor<DeliveryNoteSLEntityView,DeliveryNoteLineSLView>:RPSCollectionEditor<DeliveryNoteSLEntityView,DeliveryNoteLineSLView> where DeliveryNoteSLEntityView : class, IView where DeliveryNoteLineSLView : class, IView
    {
        public  DeliveryNoteComAgentSLsGridView<DeliveryNoteSLEntityView,DeliveryNoteLineSLView> GridView {get;set;}
    }
    public partial class DeliveryNoteComAgentSLsGridView <DeliveryNoteSLEntityView,DeliveryNoteLineSLView> :  RPSGridView<DeliveryNoteSLEntityView,DeliveryNoteLineSLView> where DeliveryNoteSLEntityView : class, IView where DeliveryNoteLineSLView : class, IView
    {
        public DeliveryNoteComAgentSLsGridView(DeliveryNoteSLEntityView currentView,DeliveryNoteLineSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeleteAgentCommand = RPSControlFactory.CreateRPSGridButton<DeliveryNoteSLEntityView>( "","#75add846-02d6-424f-bed0-46abc56f416e .ag-row[role='row']@ROWINDEX [col-id='cDeleteAgentCommand']","",this.CurrentView);
 
            IDCommercialAgent = RPSControlFactory.CreateRPSGridComboBox<DeliveryNoteSLEntityView>("","#75add846-02d6-424f-bed0-46abc56f416e .ag-row[role='row']@ROWINDEX [col-id='cIDCommercialAgent']","",true, this.CurrentView);
 
            IDCommercialAgentClassification = RPSControlFactory.CreateRPSGridComboBox<DeliveryNoteSLEntityView>("","#75add846-02d6-424f-bed0-46abc56f416e .ag-row[role='row']@ROWINDEX [col-id='cIDCommercialAgentClassification']","",true, this.CurrentView);
 
            Commission = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteSLEntityView>("","#75add846-02d6-424f-bed0-46abc56f416e .ag-row[role='row']@ROWINDEX [col-id='cCommission']","",false, this.CurrentView);
 
            ComisionTypeString = RPSControlFactory.CreateRPSGridTextBox<DeliveryNoteSLEntityView>("","#75add846-02d6-424f-bed0-46abc56f416e .ag-row[role='row']@ROWINDEX [col-id='cComisionTypeString']","",false, this.CurrentView);
 
            ComisionHead = RPSControlFactory.CreateRPSGridCheckBox<DeliveryNoteSLEntityView>("","#75add846-02d6-424f-bed0-46abc56f416e .ag-row[role='row']@ROWINDEX [col-id='cComisionHead']","",false, this.CurrentView);
 

        }
        public IRPSGridButton<DeliveryNoteSLEntityView> DeleteAgentCommand { get; set; } 
        public IRPSGridComboBox<DeliveryNoteSLEntityView> IDCommercialAgent { get; set; } 
        public IRPSGridComboBox<DeliveryNoteSLEntityView> IDCommercialAgentClassification { get; set; } 
        public IRPSGridTextBox<DeliveryNoteSLEntityView> Commission { get; set; } 
        public IRPSGridTextBox<DeliveryNoteSLEntityView> ComisionTypeString { get; set; } 
        public IRPSGridCheckbox<DeliveryNoteSLEntityView> ComisionHead { get; set; } 
                     
    }
 
    }
  
            
    public partial class DeliveryNoteLineSLView : View
    {
        public DeliveryNoteLineSLView(DeliveryNoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<DeliveryNoteLineSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DeliveryNoteLineSLView,DeliveryNoteSLEntityView>( this,Screen.DeliveryNoteSLEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<DeliveryNoteLineSLView,DeliveryNoteSLEntityView>( this,Screen.DeliveryNoteSLEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<DeliveryNoteLineSLView,DeliveryNoteSLEntityView>( this,Screen.DeliveryNoteSLEntityView);
 
            IDOrderLine = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineSLView>("beb8140b-b830-46eb-a4c9-8edc64a78276","","",true, this);
 
            Ordenation = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineSLView>("820e7402-cc13-4e14-8fe8-ecc881db5bbf","","",true, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineSLView>("98709304-d99d-4a1a-bc6a-702afdbd05ab","","",true, this);
 
            UIDescription = RPSControlFactory.CreateRPSTextBox<DeliveryNoteLineSLView>("e36119db-a14d-446b-ab3c-dc54f34b80f8","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineSLView>("7eaa0acc-d278-40a0-9079-f2acd4ff8a1b","","",true, this);
 
            Price = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineSLView>("ffe1e221-f637-40be-95ba-21a59a573707","","",true, this);
 
            VAT = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteLineSLView>("3e3b5816-7fd8-43af-bc14-ce85a6a577b0","","",true, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineSLView>("7f937999-a192-4458-acd8-56790fdd9813","","",true, this);
 
            AmountWithVAT = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineSLView>("dc5a6727-c417-4bcf-bbba-cd6ef5a421da","","",true, this);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineSLView>("4cc988c1-6a7a-4f32-8f6f-cfd146672caa","","",true, this);
 
            ReferenceCustomer = RPSControlFactory.CreateRPSEnumComboBox<DeliveryNoteLineSLView>("2a833b0f-1555-4503-8b7e-b25c85775dc3","","",false, this);
 
            UIIDUnitQuantity = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineSLView>("d56de319-6a9b-4644-b650-e0638cac962c","","",false, this);
 
            ConversionFactorQuantity = RPSControlFactory.CreateRPSTextBox<DeliveryNoteLineSLView>("293a199b-cf6a-43cd-81e7-e9ae4c255fc6","","",true, this);
 
            Dimension1 = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineSLView>("ca6d7921-bb24-4264-abd5-895bc37abf7c","","",true, this);
 
            Dimension3 = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineSLView>("0cf9ebb6-2950-4404-bb03-a177375e2b49","","",true, this);
 
            Dimension2 = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineSLView>("cb62bc09-7d91-4063-9393-71a495653551","","",true, this);
 
            UIIDUnitPrice = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineSLView>("a1315fe6-46a1-4837-928c-d4a9b91e9a02","","",false, this);
 
            ConversionFactorPrice = RPSControlFactory.CreateRPSTextBox<DeliveryNoteLineSLView>("cfbdca63-fb85-4455-8bcc-22e4b6559966","","",true, this);
 
            Invoice = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteLineSLView>("0a9e88cc-80cd-4c9a-9ce5-3d9a90044176","","",true, this);
 
            Invoiced = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteLineSLView>("e28403d1-2918-480b-827f-5a22ae67b110","","",true, this);
 
            InvoicedQuantity = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineSLView>("aa901d36-febc-47e3-9086-30859bc2b9d6","","",true, this);
 
            PriceWihoutConditions = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineSLView>("68904e1c-05ee-424d-8586-5abb856d385c","","",true, this);
 
            InvoicedQuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineSLView>("a9f7da97-cce5-4b2c-9804-4e8337680bfb","","",false, this);
 
            Cost = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineSLView>("87a7c874-0fdd-4d7d-a302-58ebec26ba95","","",true, this);
 
            CostIndirect = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineSLView>("547323bf-42c6-4419-88f2-d82ce4b38e3d","","",true, this);
 
            IDArticleVersion = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineSLView>("badb7d29-28e1-45bf-a329-28cadde83ff1","","",false, this);
 
            Discount1 = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineSLView>("aaf3c16c-ba1e-43b5-80c5-3979130fe112","","",true, this);
 
            CascadeDiscount1 = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteLineSLView>("7ac4dd97-db6c-449c-82cc-08f64e8322d0","","",true, this);
 
            Discount2 = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineSLView>("1bb89830-2dbb-4f80-9b3c-f7aeb01bb760","","",true, this);
 
            CascadeDiscount2 = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteLineSLView>("7bc68127-845a-4aa3-9c01-f1f13906b147","","",true, this);
 
            Discount3 = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineSLView>("8ed26038-dc20-43c2-bca7-16a6fb5e9844","","",true, this);
 
            CascadeDiscount3 = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteLineSLView>("39266625-8d6d-4f25-9358-a545c42a383d","","",true, this);
 
            Discount4 = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineSLView>("4db96ba2-4bc4-4c2b-a9cf-c532c14f64ee","","",true, this);
 
            CascadeDiscount4 = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteLineSLView>("cf6ee8b6-3053-4897-a2d3-48ab779ddccc","","",true, this);
 
            Discount5 = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineSLView>("b8a4968e-cd3d-457a-a109-01ccbbec7c8b","","",true, this);
 
            CascadeDiscount5 = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteLineSLView>("02b0d429-3a8f-427a-9146-33d9c72341a8","","",true, this);
 
            AmountDiscount = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineSLView>("6f73fb10-5447-4d8b-9191-c4075a3328ec","","",true, this);
 
            PositionAmountDiscount = RPSControlFactory.CreateRPSEnumComboBox<DeliveryNoteLineSLView>("a274da1a-972c-4212-b234-360fc3a098bb","","",true, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineSLView>("24fce177-ef02-4302-a087-6a4f2e6090a8","","",true, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineSLView>("740a25e6-413d-4e7e-bfd5-acf7a8d99984","","",true, this);
 
            Series = RPSControlFactory.CreateRPSEnumComboBox<DeliveryNoteLineSLView>("4d05fc5b-12ea-4581-8881-81eefe571039","","",false, this);
 
            ExpiryDate = RPSControlFactory.CreateRPSTextBox<DeliveryNoteLineSLView>("18f11ddf-4a3b-422e-94f5-a201225f2ad7","","",false, this);
 
            PotencyValue = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineSLView>("39ce5d0e-6f05-4f28-b14d-2617ceb53b6f","","",true, this);
 
            IDArticleContainer = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineSLView>("7348bc58-1342-406a-9656-e943c66f3e1d","","",false, this);
 
            QuantityContainer = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineSLView>("f738c528-a4bb-4fa4-a437-7c1cd3121707","","",false, this);
 
            QuantityContainerSecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineSLView>("8fe3a4fc-5191-4c48-be1c-1c45152eba73","","",false, this);
 
            IDSiteTransfer = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineSLView>("2fd87c18-f478-4080-a8a6-2fc10ee01aa8","","",false, this);
 
            IDWarehouseTransfer = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineSLView>("189c0797-0660-40d2-b656-f9fd58be00df","","",false, this);
 
            TransferFinalized = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteLineSLView>("3fb8af29-af54-49a7-86a3-6adafe2dd2d5","","",true, this);
 
            IDVAT = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineSLView>("45881d4c-e9f1-4409-afe5-eff737dab286","","",true, this);
 
            PercentVAT = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineSLView>("0bfeda4a-5dcf-4b73-8586-6ec4ab281324","","",true, this);
 
            IDVATSurcharge = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineSLView>("5a7b06f7-6b90-4d88-b5eb-267e619f7128","","",false, this);
 
            PercentSurcharge = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineSLView>("4da3d497-0815-4506-b1c0-7743f0643062","","",true, this);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineSLView>("5b341dee-25ca-477f-a874-a38799124c6a","","",true, this);
 
            IDReturnCause = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineSLView>("ade23c50-6cc8-4048-b855-9f18a7dd276c","","",false, this);
 
            UIIDAccount = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineSLView>("f4b411a2-64f8-4b95-9f38-0388ffa5b0b7","","",false, this);
 
            UIIDOrderLineKit = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineSLView>("fb77f794-a10a-4b14-8116-c8005125325b","","",false, this);
 
            UICostPercentage = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineSLView>("0ff119c2-96f0-42c2-8e09-1f2804f57045","","",false, this);
 
            UINumProm = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineSLView>("817f3956-bb27-4b91-a1f5-3f3f3b122af9","","",false, this);
 
            UIRappel = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteLineSLView>("05bf7d93-dd0b-40d9-a349-e320481e1e14","","",false, this);
 
            InternalCode = RPSControlFactory.CreateRPSTextBox<DeliveryNoteLineSLView>("83373651-f5f1-4d93-bd80-6b92d98e8d32","","",false, this);
 
            UIIDManufacturingOrder = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineSLView>("764d60aa-571d-47b2-9739-6dd42e55d1fc","","",false, this);
 
            UIIDMaintenanceComponent = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineSLView>("33b92a2e-faab-4af9-b9f1-8dad14baf144","","",false, this);
 
            UISerialNumber = RPSControlFactory.CreateRPSTextBox<DeliveryNoteLineSLView>("023b8759-a625-4400-8cd1-14b07482cb04","","",false, this);
 
            BaseIntrastat = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineSLView>("3270c257-d804-4c68-89d6-5ff578c2c244","","",true, this);
 
            NetMass = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineSLView>("9c77d837-0f4d-4a06-a1f3-fea9a5ce349f","","",true, this);
 
            SupplemetUnit = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineSLView>("422af91b-4f9a-468b-b558-c6becdeda72a","","",true, this);
 
            Cassation = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteLineSLView>("952581f0-39fd-4acc-ac7d-74819df369a7","","",true, this);
 
            IDCommercialConcept = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineSLView>("3217f86f-dc50-40f3-acf1-94af3ad8988c","","",false, this);
 
            IDCustomerCommercialCondition = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineSLView>("c3fd2995-57a0-4338-a3a3-93ebd74bdf8e","","",false, this);
 
            IDCommercialCondition = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineSLView>("71bd4f33-cbc9-42dd-ac7a-337162c5ca22","","",false, this);
 
            IDCommercialConditionGroupDetail = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineSLView>("89a4e426-182b-45e3-bf15-0a51bb7db41f","","",false, this);
 
            NewDeliveryNoteLineMovementSLOutputs = RPSControlFactory.CreateRPSButton<DeliveryNoteLineSLView>( "dc34ae36-163b-4461-b25f-50ee084f2343","","",this);
 
            NewDeliveryNoteLineMovementSLEntry = RPSControlFactory.CreateRPSButton<DeliveryNoteLineSLView>( "d3bf08a4-74d0-420b-98db-a3f6199b70e0","","",this);
 
            OrderLineGetDimensionCommandButton = RPSControlFactory.CreateRPSButton<DeliveryNoteLineSLView>( "9e6c73b4-f71d-445e-869e-121aac8399c3","","",this);
 
            PriceBase = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineSLView>("672d1fe7-dac6-43f9-bdb0-a706d70be00e","","",true, this);
 
            UIconditionPrice = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineSLView>("f547ca7f-cad7-469a-afa6-393042f4f3ae","","",false, this);
 
            UIPriceWihoutConditionsBase = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineSLView>("77cd7740-0912-4a40-a110-b9cc17a4a885","","",true, this);
 
            PriceWihoutConditions1 = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineSLView>("3cc5770d-cbb8-48d2-84fb-ed32130acbf7","","",true, this);
 
            ExecuteDeliveryNoteLineCommentAddArticleTechnicalDescription = RPSControlFactory.CreateRPSButton<DeliveryNoteLineSLView>( "963f0586-cd3a-4d94-8972-43b11f360343","","",this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<DeliveryNoteLineSLView>("00f87208-68b2-4aac-9f68-65e28c48e493","","",false, this);
 
            ExecuteDeliveryNoteLineCommentInvoiceAddArticleTechnicalDescription = RPSControlFactory.CreateRPSButton<DeliveryNoteLineSLView>( "f4a6c70a-f69f-45cf-9d67-ce73aee72c24","","",this);
 
            CommentInvoice = RPSControlFactory.CreateRPSTextBox<DeliveryNoteLineSLView>("5525b3a2-60c0-40b3-ae3e-1112a3c84150","","",false, this);
 
            PlanNumber = RPSControlFactory.CreateRPSTextBox<DeliveryNoteLineSLView>("44da254a-fbc0-47cd-8ad1-b4168b523c4a","","",false, this);
 
            DirectSeriesDataChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryNoteLineSLView,DirectSeriesDataChildDialogView>("4991619c-1a58-4b3a-b28f-6d86c1d81981","","", this,Screen.DirectSeriesDataChildDialogView);
 
            AnalyticChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryNoteLineSLView,AnalyticChildDialogView>("a1cf2e7f-21ed-4ebe-b219-8b2c9af1ebe9","","", this,Screen.AnalyticChildDialogView);
 
            LocationChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryNoteLineSLView,LocationChildDialogView>("dca514fd-29bc-498a-84e9-dc3895b2aaf6","","", this,Screen.LocationChildDialogView);
 
            TransferChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryNoteLineSLView,TransferChildDialogView>("d5abd4f2-99dd-4514-97ac-d77a1759c1c7","","", this,Screen.TransferChildDialogView);
 
            CollectionInit params_DeliveryNoteLineMovementSLOutputs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="278c7810-2a3f-48e2-83a0-b19f04bb7138",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNoteLineMovementSLOutputs = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNoteLineMovementSLOutputsCollectionEditor<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView>,DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView>( params_DeliveryNoteLineMovementSLOutputs,this,Screen.DeliveryNoteLineMovementSLView);
 
            CollectionInit params_DeliveryNoteLineMovementSLEntrys = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="617098bb-5fc6-473f-9904-96ec360f2a4c",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNoteLineMovementSLEntrys = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNoteLineMovementSLEntrysCollectionEditor<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView>,DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView>( params_DeliveryNoteLineMovementSLEntrys,this,Screen.DeliveryNoteLineMovementSLView);
 
            CollectionInit params_OrderLineAnalyticSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4e8c5f60-207c-4089-b2a6-8db79763f96a",CSSSelectorGrid="",XPathGrid=""};
            OrderLineAnalyticSLs = RPSControlFactory.RPSCreateCollectionWithGrid<OrderLineAnalyticSLsCollectionEditor<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView>,DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView>( params_OrderLineAnalyticSLs,this,Screen.DeliveryNoteLineMovementSLView);
 
            CollectionInit params_DeliveryNoteLineTaxSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="fe9d424b-188b-40a2-b35e-6e5e67f4338c",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNoteLineTaxSLs = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNoteLineTaxSLsCollectionEditor<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView>,DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView>( params_DeliveryNoteLineTaxSLs,this,Screen.DeliveryNoteLineMovementSLView);
 
            CollectionInit params_DeliveryNoteLineConditionSLsAffect = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1d079157-174c-4819-a826-1e68371c1a3e",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNoteLineConditionSLsAffect = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNoteLineConditionSLsAffectCollectionEditor<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView>,DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView>( params_DeliveryNoteLineConditionSLsAffect,this,Screen.DeliveryNoteLineMovementSLView);
 
            CollectionInit params_DeliveryNoteLineConditionSLsNoAffect = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="690191df-2fb7-423e-b013-3d3b0cb17bac",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNoteLineConditionSLsNoAffect = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNoteLineConditionSLsNoAffectCollectionEditor<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView>,DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView>( params_DeliveryNoteLineConditionSLsNoAffect,this,Screen.DeliveryNoteLineMovementSLView);
 
            CollectionInit params_DeliveryNoteLineCommercialAgentSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="cae96c8d-3e3b-4bc6-9342-23ce2908a2d2",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNoteLineCommercialAgentSLs = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNoteLineCommercialAgentSLsCollectionEditor<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView>,DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView>( params_DeliveryNoteLineCommercialAgentSLs,this,Screen.DeliveryNoteLineMovementSLView);
 
            GeneralDataSection = RPSControlFactory.CreateRPSSection<DeliveryNoteLineSLView>( "","ul li[rpsid='4dd31c8b-575a-4385-8c6d-404e5efb605f']","",this);
 
            LocationSection = RPSControlFactory.CreateRPSSection<DeliveryNoteLineSLView>( "","ul li[rpsid='2cf3130e-6b1f-466f-9e88-fe020409efa0']","",this);
 
            TransferSection = RPSControlFactory.CreateRPSSection<DeliveryNoteLineSLView>( "","ul li[rpsid='b52decb0-933a-450d-88e6-5331411debae']","",this);
 
            AnalitycSection = RPSControlFactory.CreateRPSSection<DeliveryNoteLineSLView>( "","ul li[rpsid='4edf5ce9-0135-48e7-95b6-1d40a6f1cad0']","",this);
 
            TaxSection = RPSControlFactory.CreateRPSSection<DeliveryNoteLineSLView>( "","ul li[rpsid='077dc90b-6b28-48ba-9769-77e383848520']","",this);
 
            ConditionSectionAffect = RPSControlFactory.CreateRPSSection<DeliveryNoteLineSLView>( "","ul li[rpsid='11d0b51d-8032-4ce5-ace1-e39a0a6c5704']","",this);
 
            ConditionSectionNoAffect = RPSControlFactory.CreateRPSSection<DeliveryNoteLineSLView>( "","ul li[rpsid='20ae892b-d338-487e-89bd-10c685f9dcef']","",this);
 
            CommercialAgent = RPSControlFactory.CreateRPSSection<DeliveryNoteLineSLView>( "","ul li[rpsid='1e956137-4942-4e4f-bd22-04cb3773d370']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<DeliveryNoteLineSLView>( "","ul li[rpsid='4a665eb3-2d5c-4bc0-8f19-871e7df9fbc4']","",this);
 
            DPS = RPSControlFactory.CreateRPSSection<DeliveryNoteLineSLView>( "","ul li[rpsid='03b07437-21a6-4d93-a81a-fd6eccebdcf6']","",this);
 

        }
        public IRPSButton<DeliveryNoteLineSLView> DeleteButton { get; set; } 
        public IRPSButton<DeliveryNoteLineSLView,DeliveryNoteSLEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DeliveryNoteLineSLView,DeliveryNoteSLEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<DeliveryNoteLineSLView,DeliveryNoteSLEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<DeliveryNoteLineSLView> IDOrderLine { get; set; } 
        public IRPSTextBox<DeliveryNoteLineSLView> Ordenation { get; set; } 
        public IRPSComboBox<DeliveryNoteLineSLView> IDArticle { get; set; } 
        public IRPSTextBox<DeliveryNoteLineSLView> UIDescription { get; set; } 
        public IRPSTextBox<DeliveryNoteLineSLView> Quantity { get; set; } 
        public IRPSTextBox<DeliveryNoteLineSLView> Price { get; set; } 
        public IRPSCheckbox<DeliveryNoteLineSLView> VAT { get; set; } 
        public IRPSTextBox<DeliveryNoteLineSLView> Amount { get; set; } 
        public IRPSTextBox<DeliveryNoteLineSLView> AmountWithVAT { get; set; } 
        public IRPSTextBox<DeliveryNoteLineSLView> QuantitySecondUnit { get; set; } 
        public IRPSComboBox<DeliveryNoteLineSLView> ReferenceCustomer { get; set; } 
        public IRPSComboBox<DeliveryNoteLineSLView> UIIDUnitQuantity { get; set; } 
        public IRPSTextBox<DeliveryNoteLineSLView> ConversionFactorQuantity { get; set; } 
        public IRPSTextBox<DeliveryNoteLineSLView> Dimension1 { get; set; } 
        public IRPSTextBox<DeliveryNoteLineSLView> Dimension3 { get; set; } 
        public IRPSTextBox<DeliveryNoteLineSLView> Dimension2 { get; set; } 
        public IRPSComboBox<DeliveryNoteLineSLView> UIIDUnitPrice { get; set; } 
        public IRPSTextBox<DeliveryNoteLineSLView> ConversionFactorPrice { get; set; } 
        public IRPSCheckbox<DeliveryNoteLineSLView> Invoice { get; set; } 
        public IRPSCheckbox<DeliveryNoteLineSLView> Invoiced { get; set; } 
        public IRPSTextBox<DeliveryNoteLineSLView> InvoicedQuantity { get; set; } 
        public IRPSTextBox<DeliveryNoteLineSLView> PriceWihoutConditions { get; set; } 
        public IRPSTextBox<DeliveryNoteLineSLView> InvoicedQuantitySecondUnit { get; set; } 
        public IRPSTextBox<DeliveryNoteLineSLView> Cost { get; set; } 
        public IRPSTextBox<DeliveryNoteLineSLView> CostIndirect { get; set; } 
        public IRPSComboBox<DeliveryNoteLineSLView> IDArticleVersion { get; set; } 
        public IRPSTextBox<DeliveryNoteLineSLView> Discount1 { get; set; } 
        public IRPSCheckbox<DeliveryNoteLineSLView> CascadeDiscount1 { get; set; } 
        public IRPSTextBox<DeliveryNoteLineSLView> Discount2 { get; set; } 
        public IRPSCheckbox<DeliveryNoteLineSLView> CascadeDiscount2 { get; set; } 
        public IRPSTextBox<DeliveryNoteLineSLView> Discount3 { get; set; } 
        public IRPSCheckbox<DeliveryNoteLineSLView> CascadeDiscount3 { get; set; } 
        public IRPSTextBox<DeliveryNoteLineSLView> Discount4 { get; set; } 
        public IRPSCheckbox<DeliveryNoteLineSLView> CascadeDiscount4 { get; set; } 
        public IRPSTextBox<DeliveryNoteLineSLView> Discount5 { get; set; } 
        public IRPSCheckbox<DeliveryNoteLineSLView> CascadeDiscount5 { get; set; } 
        public IRPSTextBox<DeliveryNoteLineSLView> AmountDiscount { get; set; } 
        public IRPSComboBox<DeliveryNoteLineSLView> PositionAmountDiscount { get; set; } 
        public IRPSComboBox<DeliveryNoteLineSLView> IDSite { get; set; } 
        public IRPSComboBox<DeliveryNoteLineSLView> IDWarehouse { get; set; } 
        public IRPSComboBox<DeliveryNoteLineSLView> Series { get; set; } 
        public IRPSTextBox<DeliveryNoteLineSLView> ExpiryDate { get; set; } 
        public IRPSTextBox<DeliveryNoteLineSLView> PotencyValue { get; set; } 
        public IRPSComboBox<DeliveryNoteLineSLView> IDArticleContainer { get; set; } 
        public IRPSTextBox<DeliveryNoteLineSLView> QuantityContainer { get; set; } 
        public IRPSTextBox<DeliveryNoteLineSLView> QuantityContainerSecondUnit { get; set; } 
        public IRPSComboBox<DeliveryNoteLineSLView> IDSiteTransfer { get; set; } 
        public IRPSComboBox<DeliveryNoteLineSLView> IDWarehouseTransfer { get; set; } 
        public IRPSCheckbox<DeliveryNoteLineSLView> TransferFinalized { get; set; } 
        public IRPSComboBox<DeliveryNoteLineSLView> IDVAT { get; set; } 
        public IRPSTextBox<DeliveryNoteLineSLView> PercentVAT { get; set; } 
        public IRPSComboBox<DeliveryNoteLineSLView> IDVATSurcharge { get; set; } 
        public IRPSTextBox<DeliveryNoteLineSLView> PercentSurcharge { get; set; } 
        public IRPSComboBox<DeliveryNoteLineSLView> IDDeliveryNoteType { get; set; } 
        public IRPSComboBox<DeliveryNoteLineSLView> IDReturnCause { get; set; } 
        public IRPSComboBox<DeliveryNoteLineSLView> UIIDAccount { get; set; } 
        public IRPSComboBox<DeliveryNoteLineSLView> UIIDOrderLineKit { get; set; } 
        public IRPSTextBox<DeliveryNoteLineSLView> UICostPercentage { get; set; } 
        public IRPSTextBox<DeliveryNoteLineSLView> UINumProm { get; set; } 
        public IRPSCheckbox<DeliveryNoteLineSLView> UIRappel { get; set; } 
        public IRPSTextBox<DeliveryNoteLineSLView> InternalCode { get; set; } 
        public IRPSComboBox<DeliveryNoteLineSLView> UIIDManufacturingOrder { get; set; } 
        public IRPSComboBox<DeliveryNoteLineSLView> UIIDMaintenanceComponent { get; set; } 
        public IRPSTextBox<DeliveryNoteLineSLView> UISerialNumber { get; set; } 
        public IRPSTextBox<DeliveryNoteLineSLView> BaseIntrastat { get; set; } 
        public IRPSTextBox<DeliveryNoteLineSLView> NetMass { get; set; } 
        public IRPSTextBox<DeliveryNoteLineSLView> SupplemetUnit { get; set; } 
        public IRPSCheckbox<DeliveryNoteLineSLView> Cassation { get; set; } 
        public IRPSComboBox<DeliveryNoteLineSLView> IDCommercialConcept { get; set; } 
        public IRPSComboBox<DeliveryNoteLineSLView> IDCustomerCommercialCondition { get; set; } 
        public IRPSComboBox<DeliveryNoteLineSLView> IDCommercialCondition { get; set; } 
        public IRPSComboBox<DeliveryNoteLineSLView> IDCommercialConditionGroupDetail { get; set; } 
        public IRPSButton<DeliveryNoteLineSLView> NewDeliveryNoteLineMovementSLOutputs { get; set; } 
        public IRPSButton<DeliveryNoteLineSLView> NewDeliveryNoteLineMovementSLEntry { get; set; } 
        public IRPSButton<DeliveryNoteLineSLView> OrderLineGetDimensionCommandButton { get; set; } 
        public IRPSTextBox<DeliveryNoteLineSLView> PriceBase { get; set; } 
        public IRPSTextBox<DeliveryNoteLineSLView> UIconditionPrice { get; set; } 
        public IRPSTextBox<DeliveryNoteLineSLView> UIPriceWihoutConditionsBase { get; set; } 
        public IRPSTextBox<DeliveryNoteLineSLView> PriceWihoutConditions1 { get; set; } 
        public IRPSButton<DeliveryNoteLineSLView> ExecuteDeliveryNoteLineCommentAddArticleTechnicalDescription { get; set; } 
        public IRPSTextBox<DeliveryNoteLineSLView> Comment { get; set; } 
        public IRPSButton<DeliveryNoteLineSLView> ExecuteDeliveryNoteLineCommentInvoiceAddArticleTechnicalDescription { get; set; } 
        public IRPSTextBox<DeliveryNoteLineSLView> CommentInvoice { get; set; } 
        public IRPSTextBox<DeliveryNoteLineSLView> PlanNumber { get; set; } 
        public IRPSButton<DeliveryNoteLineSLView,DirectSeriesDataChildDialogView> DirectSeriesDataChildNavigationCommandButton { get; set; } 
        public IRPSButton<DeliveryNoteLineSLView,AnalyticChildDialogView> AnalyticChildNavigationCommandButton { get; set; } 
        public IRPSButton<DeliveryNoteLineSLView,LocationChildDialogView> LocationChildNavigationCommandButton { get; set; } 
        public IRPSButton<DeliveryNoteLineSLView,TransferChildDialogView> TransferChildNavigationCommandButton { get; set; } 
        public DeliveryNoteLineMovementSLOutputsCollectionEditor<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView> DeliveryNoteLineMovementSLOutputs { get; set; } 
        public DeliveryNoteLineMovementSLEntrysCollectionEditor<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView> DeliveryNoteLineMovementSLEntrys { get; set; } 
        public OrderLineAnalyticSLsCollectionEditor<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView> OrderLineAnalyticSLs { get; set; } 
        public DeliveryNoteLineTaxSLsCollectionEditor<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView> DeliveryNoteLineTaxSLs { get; set; } 
        public DeliveryNoteLineConditionSLsAffectCollectionEditor<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView> DeliveryNoteLineConditionSLsAffect { get; set; } 
        public DeliveryNoteLineConditionSLsNoAffectCollectionEditor<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView> DeliveryNoteLineConditionSLsNoAffect { get; set; } 
        public DeliveryNoteLineCommercialAgentSLsCollectionEditor<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView> DeliveryNoteLineCommercialAgentSLs { get; set; } 
        public IRPSSection<DeliveryNoteLineSLView> GeneralDataSection { get; set; } 
        public IRPSSection<DeliveryNoteLineSLView> LocationSection { get; set; } 
        public IRPSSection<DeliveryNoteLineSLView> TransferSection { get; set; } 
        public IRPSSection<DeliveryNoteLineSLView> AnalitycSection { get; set; } 
        public IRPSSection<DeliveryNoteLineSLView> TaxSection { get; set; } 
        public IRPSSection<DeliveryNoteLineSLView> ConditionSectionAffect { get; set; } 
        public IRPSSection<DeliveryNoteLineSLView> ConditionSectionNoAffect { get; set; } 
        public IRPSSection<DeliveryNoteLineSLView> CommercialAgent { get; set; } 
        public IRPSSection<DeliveryNoteLineSLView> Comments { get; set; } 
        public IRPSSection<DeliveryNoteLineSLView> DPS { get; set; } 
        public DeliveryNoteSL Screen { get; set; }
        public DeliveryNoteLineSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DeliveryNoteLineMovementSLOutputsCollectionEditor<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView>:RPSCollectionEditor<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView> where DeliveryNoteLineSLView : class, IView where DeliveryNoteLineMovementSLView : class, IView
    {
        public  DeliveryNoteLineMovementSLOutputsGridView<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView> GridView {get;set;}
    }
    public partial class DeliveryNoteLineMovementSLOutputsGridView <DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView> :  RPSGridView<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView> where DeliveryNoteLineSLView : class, IView where DeliveryNoteLineMovementSLView : class, IView
    {
        public DeliveryNoteLineMovementSLOutputsGridView(DeliveryNoteLineSLView currentView,DeliveryNoteLineMovementSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDLocationWarehouseOutput = RPSControlFactory.CreateRPSGridComboBox<DeliveryNoteLineSLView>("","#278c7810-2a3f-48e2-83a0-b19f04bb7138 .ag-row[role='row']@ROWINDEX [col-id='cIDLocationWarehouseOutput']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineSLView>("","#278c7810-2a3f-48e2-83a0-b19f04bb7138 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineSLView>("","#278c7810-2a3f-48e2-83a0-b19f04bb7138 .ag-row[role='row']@ROWINDEX [col-id='cQuantitySecondUnit']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<DeliveryNoteLineSLView> IDLocationWarehouseOutput { get; set; } 
        public IRPSGridTextBox<DeliveryNoteLineSLView> Quantity { get; set; } 
        public IRPSGridTextBox<DeliveryNoteLineSLView> QuantitySecondUnit { get; set; } 
                     
    }
 
        public partial class DeliveryNoteLineMovementSLEntrysCollectionEditor<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView>:RPSCollectionEditor<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView> where DeliveryNoteLineSLView : class, IView where DeliveryNoteLineMovementSLView : class, IView
    {
        public  DeliveryNoteLineMovementSLEntrysGridView<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView> GridView {get;set;}
    }
    public partial class DeliveryNoteLineMovementSLEntrysGridView <DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView> :  RPSGridView<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView> where DeliveryNoteLineSLView : class, IView where DeliveryNoteLineMovementSLView : class, IView
    {
        public DeliveryNoteLineMovementSLEntrysGridView(DeliveryNoteLineSLView currentView,DeliveryNoteLineMovementSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            EntryDate = RPSControlFactory.CreateRPSGridTextBox<DeliveryNoteLineSLView>("","#617098bb-5fc6-473f-9904-96ec360f2a4c .ag-row[role='row']@ROWINDEX [col-id='cEntryDate']","",false, this.CurrentView);
 
            IDLocationWarehouseEntry = RPSControlFactory.CreateRPSGridComboBox<DeliveryNoteLineSLView>("","#617098bb-5fc6-473f-9904-96ec360f2a4c .ag-row[role='row']@ROWINDEX [col-id='cIDLocationWarehouseEntry']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineSLView>("","#617098bb-5fc6-473f-9904-96ec360f2a4c .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineSLView>("","#617098bb-5fc6-473f-9904-96ec360f2a4c .ag-row[role='row']@ROWINDEX [col-id='cQuantitySecondUnit']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<DeliveryNoteLineSLView> EntryDate { get; set; } 
        public IRPSGridComboBox<DeliveryNoteLineSLView> IDLocationWarehouseEntry { get; set; } 
        public IRPSGridTextBox<DeliveryNoteLineSLView> Quantity { get; set; } 
        public IRPSGridTextBox<DeliveryNoteLineSLView> QuantitySecondUnit { get; set; } 
                     
    }
 
        public partial class OrderLineAnalyticSLsCollectionEditor<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView>:RPSCollectionEditor<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView> where DeliveryNoteLineSLView : class, IView where DeliveryNoteLineMovementSLView : class, IView
    {
        public  OrderLineAnalyticSLsGridView<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView> GridView {get;set;}
    }
    public partial class OrderLineAnalyticSLsGridView <DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView> :  RPSGridView<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView> where DeliveryNoteLineSLView : class, IView where DeliveryNoteLineMovementSLView : class, IView
    {
        public OrderLineAnalyticSLsGridView(DeliveryNoteLineSLView currentView,DeliveryNoteLineMovementSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDDimension = RPSControlFactory.CreateRPSGridComboBox<DeliveryNoteLineSLView>("","#4e8c5f60-207c-4089-b2a6-8db79763f96a .ag-row[role='row']@ROWINDEX [col-id='cIDDimension']","",true, this.CurrentView);
 
            IDDimValue = RPSControlFactory.CreateRPSGridComboBox<DeliveryNoteLineSLView>("","#4e8c5f60-207c-4089-b2a6-8db79763f96a .ag-row[role='row']@ROWINDEX [col-id='cIDDimValue']","",true, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineSLView>("","#4e8c5f60-207c-4089-b2a6-8db79763f96a .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineSLView>("","#4e8c5f60-207c-4089-b2a6-8db79763f96a .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<DeliveryNoteLineSLView> IDDimension { get; set; } 
        public IRPSGridComboBox<DeliveryNoteLineSLView> IDDimValue { get; set; } 
        public IRPSGridTextBox<DeliveryNoteLineSLView> Percentage { get; set; } 
        public IRPSGridTextBox<DeliveryNoteLineSLView> Amount { get; set; } 
                     
    }
 
        public partial class DeliveryNoteLineTaxSLsCollectionEditor<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView>:RPSCollectionEditor<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView> where DeliveryNoteLineSLView : class, IView where DeliveryNoteLineMovementSLView : class, IView
    {
        public  DeliveryNoteLineTaxSLsGridView<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView> GridView {get;set;}
    }
    public partial class DeliveryNoteLineTaxSLsGridView <DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView> :  RPSGridView<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView> where DeliveryNoteLineSLView : class, IView where DeliveryNoteLineMovementSLView : class, IView
    {
        public DeliveryNoteLineTaxSLsGridView(DeliveryNoteLineSLView currentView,DeliveryNoteLineMovementSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDTaxValue = RPSControlFactory.CreateRPSGridComboBox<DeliveryNoteLineSLView>("","#fe9d424b-188b-40a2-b35e-6e5e67f4338c .ag-row[role='row']@ROWINDEX [col-id='cIDTaxValue']","",true, this.CurrentView);
 
            ApplicationType = RPSControlFactory.CreateRPSGridEnumComboBox<DeliveryNoteLineSLView>("","#fe9d424b-188b-40a2-b35e-6e5e67f4338c .ag-row[role='row']@ROWINDEX [col-id='cApplicationType']","",true, this.CurrentView);
 
            BaseType = RPSControlFactory.CreateRPSGridEnumComboBox<DeliveryNoteLineSLView>("","#fe9d424b-188b-40a2-b35e-6e5e67f4338c .ag-row[role='row']@ROWINDEX [col-id='cBaseType']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<DeliveryNoteLineSLView>("","#fe9d424b-188b-40a2-b35e-6e5e67f4338c .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            Value = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineSLView>("","#fe9d424b-188b-40a2-b35e-6e5e67f4338c .ag-row[role='row']@ROWINDEX [col-id='cValue']","",true, this.CurrentView);
 
            VAT = RPSControlFactory.CreateRPSGridCheckBox<DeliveryNoteLineSLView>("","#fe9d424b-188b-40a2-b35e-6e5e67f4338c .ag-row[role='row']@ROWINDEX [col-id='cVAT']","",true, this.CurrentView);
 
            PriceIncluded = RPSControlFactory.CreateRPSGridCheckBox<DeliveryNoteLineSLView>("","#fe9d424b-188b-40a2-b35e-6e5e67f4338c .ag-row[role='row']@ROWINDEX [col-id='cPriceIncluded']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<DeliveryNoteLineSLView> IDTaxValue { get; set; } 
        public IRPSGridComboBox<DeliveryNoteLineSLView> ApplicationType { get; set; } 
        public IRPSGridComboBox<DeliveryNoteLineSLView> BaseType { get; set; } 
        public IRPSGridComboBox<DeliveryNoteLineSLView> Type { get; set; } 
        public IRPSGridTextBox<DeliveryNoteLineSLView> Value { get; set; } 
        public IRPSGridCheckbox<DeliveryNoteLineSLView> VAT { get; set; } 
        public IRPSGridCheckbox<DeliveryNoteLineSLView> PriceIncluded { get; set; } 
                     
    }
 
        public partial class DeliveryNoteLineConditionSLsAffectCollectionEditor<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView>:RPSCollectionEditor<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView> where DeliveryNoteLineSLView : class, IView where DeliveryNoteLineMovementSLView : class, IView
    {
        public  DeliveryNoteLineConditionSLsAffectGridView<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView> GridView {get;set;}
    }
    public partial class DeliveryNoteLineConditionSLsAffectGridView <DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView> :  RPSGridView<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView> where DeliveryNoteLineSLView : class, IView where DeliveryNoteLineMovementSLView : class, IView
    {
        public DeliveryNoteLineConditionSLsAffectGridView(DeliveryNoteLineSLView currentView,DeliveryNoteLineMovementSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<DeliveryNoteLineSLView>("","#1d079157-174c-4819-a826-1e68371c1a3e .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            ConditionValueOriginal = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineSLView>("","#1d079157-174c-4819-a826-1e68371c1a3e .ag-row[role='row']@ROWINDEX [col-id='cConditionValueOriginal']","",true, this.CurrentView);
 
            ConditionValue = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineSLView>("","#1d079157-174c-4819-a826-1e68371c1a3e .ag-row[role='row']@ROWINDEX [col-id='cConditionValue']","",true, this.CurrentView);
 
            Base = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineSLView>("","#1d079157-174c-4819-a826-1e68371c1a3e .ag-row[role='row']@ROWINDEX [col-id='cBase']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineSLView>("","#1d079157-174c-4819-a826-1e68371c1a3e .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            ConditionType = RPSControlFactory.CreateRPSGridEnumComboBox<DeliveryNoteLineSLView>("","#1d079157-174c-4819-a826-1e68371c1a3e .ag-row[role='row']@ROWINDEX [col-id='cConditionType']","",true, this.CurrentView);
 
            BaseApply = RPSControlFactory.CreateRPSGridEnumComboBox<DeliveryNoteLineSLView>("","#1d079157-174c-4819-a826-1e68371c1a3e .ag-row[role='row']@ROWINDEX [col-id='cBaseApply']","",true, this.CurrentView);
 
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<DeliveryNoteLineSLView>("","#1d079157-174c-4819-a826-1e68371c1a3e .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",true, this.CurrentView);
 
            DateTo = RPSControlFactory.CreateRPSGridTextBox<DeliveryNoteLineSLView>("","#1d079157-174c-4819-a826-1e68371c1a3e .ag-row[role='row']@ROWINDEX [col-id='cDateTo']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<DeliveryNoteLineSLView> Type { get; set; } 
        public IRPSGridTextBox<DeliveryNoteLineSLView> ConditionValueOriginal { get; set; } 
        public IRPSGridTextBox<DeliveryNoteLineSLView> ConditionValue { get; set; } 
        public IRPSGridTextBox<DeliveryNoteLineSLView> Base { get; set; } 
        public IRPSGridTextBox<DeliveryNoteLineSLView> Amount { get; set; } 
        public IRPSGridComboBox<DeliveryNoteLineSLView> ConditionType { get; set; } 
        public IRPSGridComboBox<DeliveryNoteLineSLView> BaseApply { get; set; } 
        public IRPSGridTextBox<DeliveryNoteLineSLView> DateFrom { get; set; } 
        public IRPSGridTextBox<DeliveryNoteLineSLView> DateTo { get; set; } 
                     
    }
 
        public partial class DeliveryNoteLineConditionSLsNoAffectCollectionEditor<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView>:RPSCollectionEditor<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView> where DeliveryNoteLineSLView : class, IView where DeliveryNoteLineMovementSLView : class, IView
    {
        public  DeliveryNoteLineConditionSLsNoAffectGridView<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView> GridView {get;set;}
    }
    public partial class DeliveryNoteLineConditionSLsNoAffectGridView <DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView> :  RPSGridView<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView> where DeliveryNoteLineSLView : class, IView where DeliveryNoteLineMovementSLView : class, IView
    {
        public DeliveryNoteLineConditionSLsNoAffectGridView(DeliveryNoteLineSLView currentView,DeliveryNoteLineMovementSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<DeliveryNoteLineSLView>("","#690191df-2fb7-423e-b013-3d3b0cb17bac .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            ConditionValueOriginal = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineSLView>("","#690191df-2fb7-423e-b013-3d3b0cb17bac .ag-row[role='row']@ROWINDEX [col-id='cConditionValueOriginal']","",true, this.CurrentView);
 
            ConditionValue = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineSLView>("","#690191df-2fb7-423e-b013-3d3b0cb17bac .ag-row[role='row']@ROWINDEX [col-id='cConditionValue']","",true, this.CurrentView);
 
            Base = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineSLView>("","#690191df-2fb7-423e-b013-3d3b0cb17bac .ag-row[role='row']@ROWINDEX [col-id='cBase']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineSLView>("","#690191df-2fb7-423e-b013-3d3b0cb17bac .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            ConditionType = RPSControlFactory.CreateRPSGridEnumComboBox<DeliveryNoteLineSLView>("","#690191df-2fb7-423e-b013-3d3b0cb17bac .ag-row[role='row']@ROWINDEX [col-id='cConditionType']","",true, this.CurrentView);
 
            BaseApply = RPSControlFactory.CreateRPSGridEnumComboBox<DeliveryNoteLineSLView>("","#690191df-2fb7-423e-b013-3d3b0cb17bac .ag-row[role='row']@ROWINDEX [col-id='cBaseApply']","",true, this.CurrentView);
 
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<DeliveryNoteLineSLView>("","#690191df-2fb7-423e-b013-3d3b0cb17bac .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",true, this.CurrentView);
 
            DateTo = RPSControlFactory.CreateRPSGridTextBox<DeliveryNoteLineSLView>("","#690191df-2fb7-423e-b013-3d3b0cb17bac .ag-row[role='row']@ROWINDEX [col-id='cDateTo']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<DeliveryNoteLineSLView> Type { get; set; } 
        public IRPSGridTextBox<DeliveryNoteLineSLView> ConditionValueOriginal { get; set; } 
        public IRPSGridTextBox<DeliveryNoteLineSLView> ConditionValue { get; set; } 
        public IRPSGridTextBox<DeliveryNoteLineSLView> Base { get; set; } 
        public IRPSGridTextBox<DeliveryNoteLineSLView> Amount { get; set; } 
        public IRPSGridComboBox<DeliveryNoteLineSLView> ConditionType { get; set; } 
        public IRPSGridComboBox<DeliveryNoteLineSLView> BaseApply { get; set; } 
        public IRPSGridTextBox<DeliveryNoteLineSLView> DateFrom { get; set; } 
        public IRPSGridTextBox<DeliveryNoteLineSLView> DateTo { get; set; } 
                     
    }
 
        public partial class DeliveryNoteLineCommercialAgentSLsCollectionEditor<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView>:RPSCollectionEditor<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView> where DeliveryNoteLineSLView : class, IView where DeliveryNoteLineMovementSLView : class, IView
    {
        public  DeliveryNoteLineCommercialAgentSLsGridView<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView> GridView {get;set;}
    }
    public partial class DeliveryNoteLineCommercialAgentSLsGridView <DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView> :  RPSGridView<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView> where DeliveryNoteLineSLView : class, IView where DeliveryNoteLineMovementSLView : class, IView
    {
        public DeliveryNoteLineCommercialAgentSLsGridView(DeliveryNoteLineSLView currentView,DeliveryNoteLineMovementSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDCommercialAgent = RPSControlFactory.CreateRPSGridComboBox<DeliveryNoteLineSLView>("","#cae96c8d-3e3b-4bc6-9342-23ce2908a2d2 .ag-row[role='row']@ROWINDEX [col-id='cIDCommercialAgent']","",true, this.CurrentView);
 
            IDCommercialAgentClassification = RPSControlFactory.CreateRPSGridComboBox<DeliveryNoteLineSLView>("","#cae96c8d-3e3b-4bc6-9342-23ce2908a2d2 .ag-row[role='row']@ROWINDEX [col-id='cIDCommercialAgentClassification']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<DeliveryNoteLineSLView>("","#cae96c8d-3e3b-4bc6-9342-23ce2908a2d2 .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            Commission = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineSLView>("","#cae96c8d-3e3b-4bc6-9342-23ce2908a2d2 .ag-row[role='row']@ROWINDEX [col-id='cCommission']","",true, this.CurrentView);
 
            CommissionAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineSLView>("","#cae96c8d-3e3b-4bc6-9342-23ce2908a2d2 .ag-row[role='row']@ROWINDEX [col-id='cCommissionAmount']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<DeliveryNoteLineSLView> IDCommercialAgent { get; set; } 
        public IRPSGridComboBox<DeliveryNoteLineSLView> IDCommercialAgentClassification { get; set; } 
        public IRPSGridComboBox<DeliveryNoteLineSLView> Type { get; set; } 
        public IRPSGridTextBox<DeliveryNoteLineSLView> Commission { get; set; } 
        public IRPSGridTextBox<DeliveryNoteLineSLView> CommissionAmount { get; set; } 
                     
    }
 
    }
  
            
    public partial class DeliveryNoteVariablePaymentSLView : View
    {
        public DeliveryNoteVariablePaymentSLView(DeliveryNoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<DeliveryNoteVariablePaymentSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DeliveryNoteVariablePaymentSLView,DeliveryNoteLineSLView>( this,Screen.DeliveryNoteLineSLView);
 
            BackButton = RPSControlFactory.RPSBackButton<DeliveryNoteVariablePaymentSLView,DeliveryNoteLineSLView>( this,Screen.DeliveryNoteLineSLView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<DeliveryNoteVariablePaymentSLView,DeliveryNoteLineSLView>( this,Screen.DeliveryNoteLineSLView);
 
            NumPayment = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteVariablePaymentSLView>("95fce962-9ca0-44c1-89e9-86000e082c09","","",true, this);
 
            DatePayment = RPSControlFactory.CreateRPSTextBox<DeliveryNoteVariablePaymentSLView>("65d4f29b-51db-4036-a4f3-7b999cc48579","","",false, this);
 
            DayPayment = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteVariablePaymentSLView>("102362c5-3291-4124-9dd6-baa4d41a5083","","",false, this);
 
            Percentage = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteVariablePaymentSLView>("adb0f1be-71bc-4300-916e-a5315cb7499e","","",true, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteVariablePaymentSLView>("1c6ba548-07cb-49f9-93bb-0914fcb2031f","","",true, this);
 
            Rest = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteVariablePaymentSLView>("c26a64a7-3a07-4ece-a5f8-b866b42c47a3","","",true, this);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSComboBox<DeliveryNoteVariablePaymentSLView>("1ae52f35-a206-4e4e-8f07-9af7f481fafc","","",false, this);
 

        }
        public IRPSButton<DeliveryNoteVariablePaymentSLView> DeleteButton { get; set; } 
        public IRPSButton<DeliveryNoteVariablePaymentSLView,DeliveryNoteLineSLView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DeliveryNoteVariablePaymentSLView,DeliveryNoteLineSLView> BackButton { get; set; } 
        public IRPSAcceptButton<DeliveryNoteVariablePaymentSLView,DeliveryNoteLineSLView> AcceptButton { get; set; } 
        public IRPSTextBox<DeliveryNoteVariablePaymentSLView> NumPayment { get; set; } 
        public IRPSTextBox<DeliveryNoteVariablePaymentSLView> DatePayment { get; set; } 
        public IRPSTextBox<DeliveryNoteVariablePaymentSLView> DayPayment { get; set; } 
        public IRPSTextBox<DeliveryNoteVariablePaymentSLView> Percentage { get; set; } 
        public IRPSTextBox<DeliveryNoteVariablePaymentSLView> Amount { get; set; } 
        public IRPSCheckbox<DeliveryNoteVariablePaymentSLView> Rest { get; set; } 
        public IRPSComboBox<DeliveryNoteVariablePaymentSLView> IDPaymentMethod { get; set; } 
        public DeliveryNoteSL Screen { get; set; }
        public DeliveryNoteVariablePaymentSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DeliveryNoteComAgentSLView : View
    {
        public DeliveryNoteComAgentSLView(DeliveryNoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<DeliveryNoteComAgentSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DeliveryNoteComAgentSLView,DeliveryNoteLineSLView>( this,Screen.DeliveryNoteLineSLView);
 
            BackButton = RPSControlFactory.RPSBackButton<DeliveryNoteComAgentSLView,DeliveryNoteLineSLView>( this,Screen.DeliveryNoteLineSLView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<DeliveryNoteComAgentSLView,DeliveryNoteLineSLView>( this,Screen.DeliveryNoteLineSLView);
 
            IDCommercialAgent = RPSControlFactory.CreateRPSComboBox<DeliveryNoteComAgentSLView>("0a7a3e52-86b2-4d44-b49b-e0ce5e770174","","",true, this);
 
            IDCommercialAgentClassification = RPSControlFactory.CreateRPSComboBox<DeliveryNoteComAgentSLView>("2b5537a9-b7bd-477d-ac1b-0dab2e5d901b","","",true, this);
 
            Commission = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteComAgentSLView>("e0e4ac04-5edd-46da-a46f-536193117b91","","",false, this);
 
            ComisionTypeString = RPSControlFactory.CreateRPSTextBox<DeliveryNoteComAgentSLView>("889302bf-3324-4bd7-bdd0-d652205a30d7","","",false, this);
 
            ComisionHead = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteComAgentSLView>("a526e265-8302-4601-93a0-2501337dbe3e","","",false, this);
 
            ChangeCommisionCommand = RPSControlFactory.CreateRPSButton<DeliveryNoteComAgentSLView>( "b5914c84-086a-4565-bed3-17a66ff4a100","","",this);
 
            CollectionInit params_DeliveryNoteCommisions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a5643e7d-a0cf-42c1-9e47-7797358c5bba",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNoteCommisions = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNoteCommisionsCollectionEditor<DeliveryNoteComAgentSLView>,DeliveryNoteComAgentSLView>( params_DeliveryNoteCommisions,this);
 

        }
        public IRPSButton<DeliveryNoteComAgentSLView> DeleteButton { get; set; } 
        public IRPSButton<DeliveryNoteComAgentSLView,DeliveryNoteLineSLView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DeliveryNoteComAgentSLView,DeliveryNoteLineSLView> BackButton { get; set; } 
        public IRPSAcceptButton<DeliveryNoteComAgentSLView,DeliveryNoteLineSLView> AcceptButton { get; set; } 
        public IRPSComboBox<DeliveryNoteComAgentSLView> IDCommercialAgent { get; set; } 
        public IRPSComboBox<DeliveryNoteComAgentSLView> IDCommercialAgentClassification { get; set; } 
        public IRPSTextBox<DeliveryNoteComAgentSLView> Commission { get; set; } 
        public IRPSTextBox<DeliveryNoteComAgentSLView> ComisionTypeString { get; set; } 
        public IRPSCheckbox<DeliveryNoteComAgentSLView> ComisionHead { get; set; } 
        public IRPSButton<DeliveryNoteComAgentSLView> ChangeCommisionCommand { get; set; } 
        public DeliveryNoteCommisionsCollectionEditor<DeliveryNoteComAgentSLView> DeliveryNoteCommisions { get; set; } 
        public DeliveryNoteSL Screen { get; set; }
        public DeliveryNoteComAgentSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DeliveryNoteCommisionsCollectionEditor<DeliveryNoteComAgentSLView>:RPSCollectionEditor<DeliveryNoteComAgentSLView> where DeliveryNoteComAgentSLView : class, IView
    {
        public  DeliveryNoteCommisionsGridView<DeliveryNoteComAgentSLView> GridView {get;set;}
    }
    public partial class DeliveryNoteCommisionsGridView <DeliveryNoteComAgentSLView> :  RPSGridView<DeliveryNoteComAgentSLView> where DeliveryNoteComAgentSLView : class, IView
    {
        public DeliveryNoteCommisionsGridView(DeliveryNoteComAgentSLView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Ordenation = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteComAgentSLView>("","#a5643e7d-a0cf-42c1-9e47-7797358c5bba .ag-row[role='row']@ROWINDEX [col-id='cOrdenation']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<DeliveryNoteComAgentSLView>("","#a5643e7d-a0cf-42c1-9e47-7797358c5bba .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            IDCommercialAgent = RPSControlFactory.CreateRPSGridComboBox<DeliveryNoteComAgentSLView>("","#a5643e7d-a0cf-42c1-9e47-7797358c5bba .ag-row[role='row']@ROWINDEX [col-id='cIDCommercialAgent']","",true, this.CurrentView);
 
            IDCommercialAgentClassification = RPSControlFactory.CreateRPSGridComboBox<DeliveryNoteComAgentSLView>("","#a5643e7d-a0cf-42c1-9e47-7797358c5bba .ag-row[role='row']@ROWINDEX [col-id='cIDCommercialAgentClassification']","",true, this.CurrentView);
 
            Commission = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteComAgentSLView>("","#a5643e7d-a0cf-42c1-9e47-7797358c5bba .ag-row[role='row']@ROWINDEX [col-id='cCommission']","",false, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridTextBox<DeliveryNoteComAgentSLView>("","#a5643e7d-a0cf-42c1-9e47-7797358c5bba .ag-row[role='row']@ROWINDEX [col-id='cType']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<DeliveryNoteComAgentSLView> Ordenation { get; set; } 
        public IRPSGridTextBox<DeliveryNoteComAgentSLView> Description { get; set; } 
        public IRPSGridComboBox<DeliveryNoteComAgentSLView> IDCommercialAgent { get; set; } 
        public IRPSGridComboBox<DeliveryNoteComAgentSLView> IDCommercialAgentClassification { get; set; } 
        public IRPSGridTextBox<DeliveryNoteComAgentSLView> Commission { get; set; } 
        public IRPSGridTextBox<DeliveryNoteComAgentSLView> Type { get; set; } 
                     
    }
 
    }
  
            
    public partial class DeliveryNoteLineCommercialAgentSLView : View
    {
        public DeliveryNoteLineCommercialAgentSLView(DeliveryNoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<DeliveryNoteLineCommercialAgentSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DeliveryNoteLineCommercialAgentSLView,DeliveryNoteLineSLView>( this,Screen.DeliveryNoteLineSLView);
 
            BackButton = RPSControlFactory.RPSBackButton<DeliveryNoteLineCommercialAgentSLView,DeliveryNoteLineSLView>( this,Screen.DeliveryNoteLineSLView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<DeliveryNoteLineCommercialAgentSLView,DeliveryNoteLineSLView>( this,Screen.DeliveryNoteLineSLView);
 
            IDCommercialAgent = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineCommercialAgentSLView>("7099f595-8950-4f16-bbf4-e083105ecb5a","","",true, this);
 
            IDCommercialAgentClassification = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineCommercialAgentSLView>("51ffaf59-87aa-45f7-aa9a-11f3550b7089","","",true, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<DeliveryNoteLineCommercialAgentSLView>("96f35238-f087-4830-918f-04d152f4cb32","","",true, this);
 
            Commission = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineCommercialAgentSLView>("27dfad8b-bb45-459e-86ad-c99cd4c2a616","","",true, this);
 
            CommissionAmount = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineCommercialAgentSLView>("4f181d8f-bd02-4254-a71f-149ecc795a65","","",true, this);
 

        }
        public IRPSButton<DeliveryNoteLineCommercialAgentSLView> DeleteButton { get; set; } 
        public IRPSButton<DeliveryNoteLineCommercialAgentSLView,DeliveryNoteLineSLView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DeliveryNoteLineCommercialAgentSLView,DeliveryNoteLineSLView> BackButton { get; set; } 
        public IRPSAcceptButton<DeliveryNoteLineCommercialAgentSLView,DeliveryNoteLineSLView> AcceptButton { get; set; } 
        public IRPSComboBox<DeliveryNoteLineCommercialAgentSLView> IDCommercialAgent { get; set; } 
        public IRPSComboBox<DeliveryNoteLineCommercialAgentSLView> IDCommercialAgentClassification { get; set; } 
        public IRPSComboBox<DeliveryNoteLineCommercialAgentSLView> Type { get; set; } 
        public IRPSTextBox<DeliveryNoteLineCommercialAgentSLView> Commission { get; set; } 
        public IRPSTextBox<DeliveryNoteLineCommercialAgentSLView> CommissionAmount { get; set; } 
        public DeliveryNoteSL Screen { get; set; }
        public DeliveryNoteLineCommercialAgentSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DeliveryNoteLineMovementSLView : View
    {
        public DeliveryNoteLineMovementSLView(DeliveryNoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<DeliveryNoteLineMovementSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DeliveryNoteLineMovementSLView,DeliveryNoteLineSLView>( this,Screen.DeliveryNoteLineSLView);
 
            BackButton = RPSControlFactory.RPSBackButton<DeliveryNoteLineMovementSLView,DeliveryNoteLineSLView>( this,Screen.DeliveryNoteLineSLView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<DeliveryNoteLineMovementSLView,DeliveryNoteLineSLView>( this,Screen.DeliveryNoteLineSLView);
 
            IDLocationWarehouseOutput = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineMovementSLView>("775e66d7-ec05-4ad6-8eb1-0bef1da0d7cd","","",false, this);
 
            IDLocationWarehouseEntry = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineMovementSLView>("1aef6154-9cd8-4a15-aa7a-558a1fd601b8","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineMovementSLView>("77716b66-5730-4dc1-8be5-f80991c54c2d","","",true, this);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineMovementSLView>("591e05ef-7fef-4e5a-b662-712211136633","","",true, this);
 
            EntryDate = RPSControlFactory.CreateRPSTextBox<DeliveryNoteLineMovementSLView>("e9a9425e-9db4-4c6b-9191-426becdd5ff5","","",false, this);
 

        }
        public IRPSButton<DeliveryNoteLineMovementSLView> DeleteButton { get; set; } 
        public IRPSButton<DeliveryNoteLineMovementSLView,DeliveryNoteLineSLView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DeliveryNoteLineMovementSLView,DeliveryNoteLineSLView> BackButton { get; set; } 
        public IRPSAcceptButton<DeliveryNoteLineMovementSLView,DeliveryNoteLineSLView> AcceptButton { get; set; } 
        public IRPSComboBox<DeliveryNoteLineMovementSLView> IDLocationWarehouseOutput { get; set; } 
        public IRPSComboBox<DeliveryNoteLineMovementSLView> IDLocationWarehouseEntry { get; set; } 
        public IRPSTextBox<DeliveryNoteLineMovementSLView> Quantity { get; set; } 
        public IRPSTextBox<DeliveryNoteLineMovementSLView> QuantitySecondUnit { get; set; } 
        public IRPSTextBox<DeliveryNoteLineMovementSLView> EntryDate { get; set; } 
        public DeliveryNoteSL Screen { get; set; }
        public DeliveryNoteLineMovementSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OrderLineAnalyticSLView : View
    {
        public OrderLineAnalyticSLView(DeliveryNoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<OrderLineAnalyticSLView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<OrderLineAnalyticSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<OrderLineAnalyticSLView,DeliveryNoteLineSLView>( this,Screen.DeliveryNoteLineSLView);
 
            BackButton = RPSControlFactory.RPSBackButton<OrderLineAnalyticSLView,DeliveryNoteLineSLView>( this,Screen.DeliveryNoteLineSLView);
 
            IDDimension = RPSControlFactory.CreateRPSComboBox<OrderLineAnalyticSLView>("fb4e493c-4ffa-4e41-a59b-acdc4361b24e","","",true, this);
 
            IDDimValue = RPSControlFactory.CreateRPSComboBox<OrderLineAnalyticSLView>("79cbc183-15db-4f79-a49d-4e182189b422","","",true, this);
 
            Percentage = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineAnalyticSLView>("77356cae-3f7b-4617-9d78-e23ecc783412","","",true, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineAnalyticSLView>("f044910e-bab1-4191-bf69-681be3be91d5","","",true, this);
 

        }
        public IRPSSaveButton<OrderLineAnalyticSLView> SaveButton { get; set; } 
        public IRPSButton<OrderLineAnalyticSLView> DeleteButton { get; set; } 
        public IRPSButton<OrderLineAnalyticSLView,DeliveryNoteLineSLView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<OrderLineAnalyticSLView,DeliveryNoteLineSLView> BackButton { get; set; } 
        public IRPSComboBox<OrderLineAnalyticSLView> IDDimension { get; set; } 
        public IRPSComboBox<OrderLineAnalyticSLView> IDDimValue { get; set; } 
        public IRPSTextBox<OrderLineAnalyticSLView> Percentage { get; set; } 
        public IRPSTextBox<OrderLineAnalyticSLView> Amount { get; set; } 
        public DeliveryNoteSL Screen { get; set; }
        public OrderLineAnalyticSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DeliveryNoteLineTaxSLView : View
    {
        public DeliveryNoteLineTaxSLView(DeliveryNoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<DeliveryNoteLineTaxSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DeliveryNoteLineTaxSLView,DeliveryNoteLineSLView>( this,Screen.DeliveryNoteLineSLView);
 
            BackButton = RPSControlFactory.RPSBackButton<DeliveryNoteLineTaxSLView,DeliveryNoteLineSLView>( this,Screen.DeliveryNoteLineSLView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<DeliveryNoteLineTaxSLView,DeliveryNoteLineSLView>( this,Screen.DeliveryNoteLineSLView);
 
            IDTaxValue = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineTaxSLView>("5993d4bc-f33b-447b-8341-bc6b26891b16","","",true, this);
 
            ApplicationType = RPSControlFactory.CreateRPSEnumComboBox<DeliveryNoteLineTaxSLView>("7d777891-51e8-4554-8f68-0830d45d6196","","",true, this);
 
            BaseType = RPSControlFactory.CreateRPSEnumComboBox<DeliveryNoteLineTaxSLView>("f878dcc8-6f6d-4219-a4bc-1cfc885770d0","","",true, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<DeliveryNoteLineTaxSLView>("5509e0e7-7175-41e6-a933-2fa67328b2e4","","",true, this);
 
            Value = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineTaxSLView>("95d7233e-4bd4-4f20-a1d6-4cf948399699","","",true, this);
 
            PriceIncluded = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteLineTaxSLView>("fea2ed9c-770d-4dae-9aad-a3f2361df462","","",true, this);
 
            VAT = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteLineTaxSLView>("1a28a69d-4573-4a0f-8734-1a8d09a2d690","","",true, this);
 

        }
        public IRPSButton<DeliveryNoteLineTaxSLView> DeleteButton { get; set; } 
        public IRPSButton<DeliveryNoteLineTaxSLView,DeliveryNoteLineSLView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DeliveryNoteLineTaxSLView,DeliveryNoteLineSLView> BackButton { get; set; } 
        public IRPSAcceptButton<DeliveryNoteLineTaxSLView,DeliveryNoteLineSLView> AcceptButton { get; set; } 
        public IRPSComboBox<DeliveryNoteLineTaxSLView> IDTaxValue { get; set; } 
        public IRPSComboBox<DeliveryNoteLineTaxSLView> ApplicationType { get; set; } 
        public IRPSComboBox<DeliveryNoteLineTaxSLView> BaseType { get; set; } 
        public IRPSComboBox<DeliveryNoteLineTaxSLView> Type { get; set; } 
        public IRPSTextBox<DeliveryNoteLineTaxSLView> Value { get; set; } 
        public IRPSCheckbox<DeliveryNoteLineTaxSLView> PriceIncluded { get; set; } 
        public IRPSCheckbox<DeliveryNoteLineTaxSLView> VAT { get; set; } 
        public DeliveryNoteSL Screen { get; set; }
        public DeliveryNoteLineTaxSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DeliveryNoteChangesChildDialogView : View
    {
        public DeliveryNoteChangesChildDialogView(DeliveryNoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDDeliveryNoteTypeSL = RPSControlFactory.CreateRPSComboBox<DeliveryNoteChangesChildDialogView>("05e1a7c7-692b-4a89-9f55-9d9954b1e71e","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<DeliveryNoteChangesChildDialogView>("df6cbf07-9ca5-4c1a-94a2-1a407a5ddd03","","",false, this);
 
            IDWareHouse = RPSControlFactory.CreateRPSComboBox<DeliveryNoteChangesChildDialogView>("8ff30e3c-4562-40e2-9648-3e1679dc104b","","",false, this);
 
            IDLocationWarehouse = RPSControlFactory.CreateRPSComboBox<DeliveryNoteChangesChildDialogView>("62172b9b-afe3-46dc-bd22-d2e0c357a0c3","","",false, this);
 
            ChangeWarehouseWithoutLocation = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteChangesChildDialogView>("69d1ecc5-8718-4e9f-8bb5-9eaae41e8ebf","","",false, this);
 

        }
        public IRPSComboBox<DeliveryNoteChangesChildDialogView> IDDeliveryNoteTypeSL { get; set; } 
        public IRPSComboBox<DeliveryNoteChangesChildDialogView> IDSite { get; set; } 
        public IRPSComboBox<DeliveryNoteChangesChildDialogView> IDWareHouse { get; set; } 
        public IRPSComboBox<DeliveryNoteChangesChildDialogView> IDLocationWarehouse { get; set; } 
        public IRPSCheckbox<DeliveryNoteChangesChildDialogView> ChangeWarehouseWithoutLocation { get; set; } 
        public DeliveryNoteSL Screen { get; set; }
        public DeliveryNoteChangesChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PrintDeliveryNoteChildDialogView : View
    {
        public PrintDeliveryNoteChildDialogView(DeliveryNoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CustomerLanguage = RPSControlFactory.CreateRPSOption<PrintDeliveryNoteChildDialogView>( "93a3b69d-99b4-49c4-bf4a-f95ac203af5a","","",this);
 
            SelectedLanguage = RPSControlFactory.CreateRPSOption<PrintDeliveryNoteChildDialogView>( "3b99e97c-6694-4af0-89ed-fe70b0061c7a","","",this);
 
            UIPrintOptionsIDLanguage = RPSControlFactory.CreateRPSComboBox<PrintDeliveryNoteChildDialogView>("fecbc01e-eec2-4c82-9d1b-a6e55095af43","","",false, this);
 
            CustomerCopy = RPSControlFactory.CreateRPSOption<PrintDeliveryNoteChildDialogView>( "856edbc8-4766-4af7-8249-1eb2bb9df6aa","","",this);
 
            SelectedCopy = RPSControlFactory.CreateRPSOption<PrintDeliveryNoteChildDialogView>( "bfbe519e-3f99-4a94-a3bb-473294b489e3","","",this);
 
            NCopy = RPSControlFactory.CreateRPSFormattedTextBox<PrintDeliveryNoteChildDialogView>("0d6a8ad2-3cf0-42c8-889e-3d64c15d1f1f","","",false, this);
 
            UIPrintSpecificReport = RPSControlFactory.CreateRPSCheckBox<PrintDeliveryNoteChildDialogView>("db1a23ea-a032-4d60-a993-510407986c9e","","",false, this);
 
            UICodDeliveryNoteReport = RPSControlFactory.CreateRPSComboBox<PrintDeliveryNoteChildDialogView>("df31ef36-b994-4415-bb63-d54c30606a3e","","",false, this);
 
            UIPrintQualityCerts = RPSControlFactory.CreateRPSCheckBox<PrintDeliveryNoteChildDialogView>("b4ca79b7-e575-473f-86d2-7b810461a96c","","",false, this);
 
            UICodQualityCertReport = RPSControlFactory.CreateRPSComboBox<PrintDeliveryNoteChildDialogView>("a5b2b97c-17ca-454e-8c4b-a7a75e1d62cf","","",false, this);
 
            PrintDeliveryNoteCommandButton = RPSControlFactory.CreateRPSButton<PrintDeliveryNoteChildDialogView>( "93611f9b-9366-4367-b068-b49afe11bf4f","","",this);
 
            ExecuteDeliveryNoteEmailButton = RPSControlFactory.CreateRPSButton<PrintDeliveryNoteChildDialogView>( "d3949fb4-bd82-437b-9b63-26cc8518a091","","",this);
 
            SendDeliveryNoteToCustomerEmailCommandButton = RPSControlFactory.CreateRPSButton<PrintDeliveryNoteChildDialogView>( "7fd69e43-06ac-4a43-9a57-e630456255bd","","",this);
 

        }
        public IRPSOption<PrintDeliveryNoteChildDialogView> CustomerLanguage { get; set; } 
        public IRPSOption<PrintDeliveryNoteChildDialogView> SelectedLanguage { get; set; } 
        public IRPSComboBox<PrintDeliveryNoteChildDialogView> UIPrintOptionsIDLanguage { get; set; } 
        public IRPSOption<PrintDeliveryNoteChildDialogView> CustomerCopy { get; set; } 
        public IRPSOption<PrintDeliveryNoteChildDialogView> SelectedCopy { get; set; } 
        public IRPSTextBox<PrintDeliveryNoteChildDialogView> NCopy { get; set; } 
        public IRPSCheckbox<PrintDeliveryNoteChildDialogView> UIPrintSpecificReport { get; set; } 
        public IRPSComboBox<PrintDeliveryNoteChildDialogView> UICodDeliveryNoteReport { get; set; } 
        public IRPSCheckbox<PrintDeliveryNoteChildDialogView> UIPrintQualityCerts { get; set; } 
        public IRPSComboBox<PrintDeliveryNoteChildDialogView> UICodQualityCertReport { get; set; } 
        public IRPSButton<PrintDeliveryNoteChildDialogView> PrintDeliveryNoteCommandButton { get; set; } 
        public IRPSButton<PrintDeliveryNoteChildDialogView> ExecuteDeliveryNoteEmailButton { get; set; } 
        public IRPSButton<PrintDeliveryNoteChildDialogView> SendDeliveryNoteToCustomerEmailCommandButton { get; set; } 
        public DeliveryNoteSL Screen { get; set; }
        public PrintDeliveryNoteChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ArticleGenericChildDialogView : View
    {
        public ArticleGenericChildDialogView(DeliveryNoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_ArticleGetAttributeValues = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b8ea25f2-e763-44b3-bc72-36f51efb6b1c",CSSSelectorGrid="",XPathGrid=""};
            ArticleGetAttributeValues = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleGetAttributeValuesCollectionEditor<ArticleGenericChildDialogView>,ArticleGenericChildDialogView>( params_ArticleGetAttributeValues,this);
 

        }
        public ArticleGetAttributeValuesCollectionEditor<ArticleGenericChildDialogView> ArticleGetAttributeValues { get; set; } 
        public DeliveryNoteSL Screen { get; set; }
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
 

        }
        public IRPSGridTextBox<ArticleGenericChildDialogView> Attribute1 { get; set; } 
        public IRPSGridTextBox<ArticleGenericChildDialogView> Attribute2 { get; set; } 
        public IRPSGridTextBox<ArticleGenericChildDialogView> Attribute3 { get; set; } 
        public IRPSGridTextBox<ArticleGenericChildDialogView> quantity { get; set; } 
                     
    }
 
    }
  
            
    public partial class PrintInvoiceChildDialogView : View
    {
        public PrintInvoiceChildDialogView(DeliveryNoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            InvoiceDate = RPSControlFactory.CreateRPSTextBox<PrintInvoiceChildDialogView>("881c5197-8b2e-465d-98e2-f403568d6b61","","",false, this);
 
            NoPrint = RPSControlFactory.CreateRPSCheckBox<PrintInvoiceChildDialogView>("cf260a1f-cdc2-4af8-ad59-c4889ee8343b","","",false, this);
 
            UIOptPrint = RPSControlFactory.CreateRPSOption<PrintInvoiceChildDialogView>( "bb40b5af-a24e-4a16-8109-c593be04dd60","","",this);
 
            UIOptEmail = RPSControlFactory.CreateRPSOption<PrintInvoiceChildDialogView>( "f2fa9186-c3e7-4fdc-890e-cee501fc6f58","","",this);
 
            UIOptClientEmail = RPSControlFactory.CreateRPSOption<PrintInvoiceChildDialogView>( "de090e3d-f015-4d8d-8bdb-16a342b103e8","","",this);
 
            CustomerLanguage = RPSControlFactory.CreateRPSOption<PrintInvoiceChildDialogView>( "3c30570f-70cf-4b60-b10c-b0c7dd4a60f6","","",this);
 
            SelectedLanguage = RPSControlFactory.CreateRPSOption<PrintInvoiceChildDialogView>( "81e5f919-326c-4f5f-a730-dc2e15bedac5","","",this);
 
            UIPrintOptionsIDLanguage = RPSControlFactory.CreateRPSComboBox<PrintInvoiceChildDialogView>("6248ba28-895e-45b6-b7aa-036b515c3815","","",false, this);
 
            CustomerCopy = RPSControlFactory.CreateRPSOption<PrintInvoiceChildDialogView>( "b716583f-76d0-4794-8dfa-d0fb3a05b2d4","","",this);
 
            SelectedCopy = RPSControlFactory.CreateRPSOption<PrintInvoiceChildDialogView>( "82223bfc-d286-4c42-a772-6b470e6c1816","","",this);
 
            NCopy = RPSControlFactory.CreateRPSFormattedTextBox<PrintInvoiceChildDialogView>("d0182b6e-42b9-42f7-b22d-fb75430cbf7e","","",false, this);
 
            UIPrintSpecificReport = RPSControlFactory.CreateRPSCheckBox<PrintInvoiceChildDialogView>("9f6d92d5-713a-4823-b3cb-7958befc0ada","","",false, this);
 
            UICodInvoiceReport = RPSControlFactory.CreateRPSComboBox<PrintInvoiceChildDialogView>("27c70249-11c2-4a31-b5f9-410a7110b64f","","",false, this);
 

        }
        public IRPSTextBox<PrintInvoiceChildDialogView> InvoiceDate { get; set; } 
        public IRPSCheckbox<PrintInvoiceChildDialogView> NoPrint { get; set; } 
        public IRPSOption<PrintInvoiceChildDialogView> UIOptPrint { get; set; } 
        public IRPSOption<PrintInvoiceChildDialogView> UIOptEmail { get; set; } 
        public IRPSOption<PrintInvoiceChildDialogView> UIOptClientEmail { get; set; } 
        public IRPSOption<PrintInvoiceChildDialogView> CustomerLanguage { get; set; } 
        public IRPSOption<PrintInvoiceChildDialogView> SelectedLanguage { get; set; } 
        public IRPSComboBox<PrintInvoiceChildDialogView> UIPrintOptionsIDLanguage { get; set; } 
        public IRPSOption<PrintInvoiceChildDialogView> CustomerCopy { get; set; } 
        public IRPSOption<PrintInvoiceChildDialogView> SelectedCopy { get; set; } 
        public IRPSTextBox<PrintInvoiceChildDialogView> NCopy { get; set; } 
        public IRPSCheckbox<PrintInvoiceChildDialogView> UIPrintSpecificReport { get; set; } 
        public IRPSComboBox<PrintInvoiceChildDialogView> UICodInvoiceReport { get; set; } 
        public DeliveryNoteSL Screen { get; set; }
        public PrintInvoiceChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NewConsumptionChildDialogView : View
    {
        public NewConsumptionChildDialogView(DeliveryNoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDCustomer = RPSControlFactory.CreateRPSComboBox<NewConsumptionChildDialogView>("c5f36605-be05-463d-a1bf-ca3bd84bdd88","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<NewConsumptionChildDialogView>("8dd05926-8df3-47e1-8dbe-9a828948bd16","","",false, this);
 
            IDWareHouse = RPSControlFactory.CreateRPSComboBox<NewConsumptionChildDialogView>("30082881-778a-4f9a-b81c-67ffef3624a1","","",false, this);
 
            IDDeliveryNoteTypeSL = RPSControlFactory.CreateRPSComboBox<NewConsumptionChildDialogView>("996931bf-455c-4f50-8100-02ea15ea8dd2","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<NewConsumptionChildDialogView>("eda7f32d-a6bb-4370-b9d3-5a287c1ffdf0","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<NewConsumptionChildDialogView>("f532ea91-e6a9-4438-aba6-e5dc5b260b09","","",false, this);
 
            DeliveryNoteLastDate = RPSControlFactory.CreateRPSTextBox<NewConsumptionChildDialogView>("1e20132e-2556-4c5c-8584-fce6bd2838dd","","",false, this);
 
            WarehouseQuantity = RPSControlFactory.CreateRPSOption<NewConsumptionChildDialogView>( "49b6bb83-c561-4ac3-af05-81d3c82febf8","","",this);
 
            SalesQuantity = RPSControlFactory.CreateRPSOption<NewConsumptionChildDialogView>( "1aa7e046-117e-4728-a83f-5c7906dc5041","","",this);
 

        }
        public IRPSComboBox<NewConsumptionChildDialogView> IDCustomer { get; set; } 
        public IRPSComboBox<NewConsumptionChildDialogView> IDSite { get; set; } 
        public IRPSComboBox<NewConsumptionChildDialogView> IDWareHouse { get; set; } 
        public IRPSComboBox<NewConsumptionChildDialogView> IDDeliveryNoteTypeSL { get; set; } 
        public IRPSTextBox<NewConsumptionChildDialogView> DateFrom { get; set; } 
        public IRPSTextBox<NewConsumptionChildDialogView> DateTo { get; set; } 
        public IRPSTextBox<NewConsumptionChildDialogView> DeliveryNoteLastDate { get; set; } 
        public IRPSOption<NewConsumptionChildDialogView> WarehouseQuantity { get; set; } 
        public IRPSOption<NewConsumptionChildDialogView> SalesQuantity { get; set; } 
        public DeliveryNoteSL Screen { get; set; }
        public NewConsumptionChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class RecalculateIntrastatChildDialogView : View
    {
        public RecalculateIntrastatChildDialogView(DeliveryNoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<RecalculateIntrastatChildDialogView>("7fb3a654-f062-4fc1-ad7b-5df253c9b113","","",false, this);
 

        }
        public IRPSTextBox<RecalculateIntrastatChildDialogView> Amount { get; set; } 
        public DeliveryNoteSL Screen { get; set; }
        public RecalculateIntrastatChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DeliveryFromOrderChildDialogView : View
    {
        public DeliveryFromOrderChildDialogView(DeliveryNoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CustomerDescription = RPSControlFactory.CreateRPSTextBox<DeliveryFromOrderChildDialogView>("47a6dfcc-5506-4830-8c40-43537719a14b","","",false, this);
 
            Control = RPSControlFactory.CreateRPSOption<DeliveryFromOrderChildDialogView>( "06a1cac1-9f99-4127-b528-7fd56ae0d3a1","","",this);
 
            WithoutControl = RPSControlFactory.CreateRPSOption<DeliveryFromOrderChildDialogView>( "409b861c-a3c2-47cf-aeef-f756debaf79c","","",this);
 
            Manual = RPSControlFactory.CreateRPSOption<DeliveryFromOrderChildDialogView>( "78346476-283b-4ea6-b5e0-0f9236d35951","","",this);
 
            IDOrderSL = RPSControlFactory.CreateRPSComboBox<DeliveryFromOrderChildDialogView>("0eb9cf13-38d4-452f-beb9-3dcc11fca582","","",false, this);
 
            OnlyPendingLines = RPSControlFactory.CreateRPSCheckBox<DeliveryFromOrderChildDialogView>("89c5f009-c95c-43ed-a02b-22209c029d7f","","",false, this);
 
            IDOrderSLList = RPSControlFactory.CreateRPSCollectionComboBox<DeliveryFromOrderChildDialogView>("11b72e3f-907c-4bda-9ccb-cd3ee530ca5a","","",false, this);
 
            DeliveryFromOrderChildByArticleChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryFromOrderChildDialogView,DeliveryFromOrderChildByArticleChildDialogView>("90420708-f3b6-43eb-9848-cec454973b64","","", this,Screen.DeliveryFromOrderChildByArticleChildDialogView);
 
            CollectionInit params_OrderLinesForDeliveryNote = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f9023ea1-7dd6-4425-aa01-7f59822406c8",CSSSelectorGrid="",XPathGrid=""};
            OrderLinesForDeliveryNote = RPSControlFactory.RPSCreateCollectionWithGrid<OrderLinesForDeliveryNoteCollectionEditor<DeliveryFromOrderChildDialogView,SeriesDataChildDialogView>,DeliveryFromOrderChildDialogView,SeriesDataChildDialogView>( params_OrderLinesForDeliveryNote,this,Screen.SeriesDataChildDialogView);
 

        }
        public IRPSTextBox<DeliveryFromOrderChildDialogView> CustomerDescription { get; set; } 
        public IRPSOption<DeliveryFromOrderChildDialogView> Control { get; set; } 
        public IRPSOption<DeliveryFromOrderChildDialogView> WithoutControl { get; set; } 
        public IRPSOption<DeliveryFromOrderChildDialogView> Manual { get; set; } 
        public IRPSComboBox<DeliveryFromOrderChildDialogView> IDOrderSL { get; set; } 
        public IRPSCheckbox<DeliveryFromOrderChildDialogView> OnlyPendingLines { get; set; } 
        public IRPSCollectionComboBox<DeliveryFromOrderChildDialogView> IDOrderSLList { get; set; } 
        public IRPSButton<DeliveryFromOrderChildDialogView,DeliveryFromOrderChildByArticleChildDialogView> DeliveryFromOrderChildByArticleChildNavigationCommandButton { get; set; } 
        public OrderLinesForDeliveryNoteCollectionEditor<DeliveryFromOrderChildDialogView,SeriesDataChildDialogView> OrderLinesForDeliveryNote { get; set; } 
        public DeliveryNoteSL Screen { get; set; }
        public DeliveryFromOrderChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class OrderLinesForDeliveryNoteCollectionEditor<DeliveryFromOrderChildDialogView,SeriesDataChildDialogView>:RPSCollectionEditor<DeliveryFromOrderChildDialogView,SeriesDataChildDialogView> where DeliveryFromOrderChildDialogView : class, IView where SeriesDataChildDialogView : class, IView
    {
        public  OrderLinesForDeliveryNoteGridView<DeliveryFromOrderChildDialogView,SeriesDataChildDialogView> GridView {get;set;}
    }
    public partial class OrderLinesForDeliveryNoteGridView <DeliveryFromOrderChildDialogView,SeriesDataChildDialogView> :  RPSGridView<DeliveryFromOrderChildDialogView,SeriesDataChildDialogView> where DeliveryFromOrderChildDialogView : class, IView where SeriesDataChildDialogView : class, IView
    {
        public OrderLinesForDeliveryNoteGridView(DeliveryFromOrderChildDialogView currentView,SeriesDataChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            OrderLineSL_Ordenation = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryFromOrderChildDialogView>("","#f9023ea1-7dd6-4425-aa01-7f59822406c8 .ag-row[role='row']@ROWINDEX [col-id='cOrderLineSL_Ordenation']","",false, this.CurrentView);
 
            OrderLineSL_Description = RPSControlFactory.CreateRPSGridTextBox<DeliveryFromOrderChildDialogView>("","#f9023ea1-7dd6-4425-aa01-7f59822406c8 .ag-row[role='row']@ROWINDEX [col-id='cOrderLineSL_Description']","",false, this.CurrentView);
 
            QuantityPending = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryFromOrderChildDialogView>("","#f9023ea1-7dd6-4425-aa01-7f59822406c8 .ag-row[role='row']@ROWINDEX [col-id='cQuantityPending']","",false, this.CurrentView);
 
            QuantityToSend = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryFromOrderChildDialogView>("","#f9023ea1-7dd6-4425-aa01-7f59822406c8 .ag-row[role='row']@ROWINDEX [col-id='cQuantityToSend']","",false, this.CurrentView);
 
            DeliveryNoteLineManualCommand = RPSControlFactory.CreateRPSGridButton<DeliveryFromOrderChildDialogView>( "","#f9023ea1-7dd6-4425-aa01-7f59822406c8 .ag-row[role='row']@ROWINDEX [col-id='cDeliveryNoteLineManualCommand']","",this.CurrentView);
 
            QuantityDelivery = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryFromOrderChildDialogView>("","#f9023ea1-7dd6-4425-aa01-7f59822406c8 .ag-row[role='row']@ROWINDEX [col-id='cQuantityDelivery']","",false, this.CurrentView);
 
            eCompleted = RPSControlFactory.CreateRPSGridEnumComboBox<DeliveryFromOrderChildDialogView>("","#f9023ea1-7dd6-4425-aa01-7f59822406c8 .ag-row[role='row']@ROWINDEX [col-id='ceCompleted']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<DeliveryFromOrderChildDialogView> OrderLineSL_Ordenation { get; set; } 
        public IRPSGridTextBox<DeliveryFromOrderChildDialogView> OrderLineSL_Description { get; set; } 
        public IRPSGridTextBox<DeliveryFromOrderChildDialogView> QuantityPending { get; set; } 
        public IRPSGridTextBox<DeliveryFromOrderChildDialogView> QuantityToSend { get; set; } 
        public IRPSGridButton<DeliveryFromOrderChildDialogView> DeliveryNoteLineManualCommand { get; set; } 
        public IRPSGridTextBox<DeliveryFromOrderChildDialogView> QuantityDelivery { get; set; } 
        public IRPSGridComboBox<DeliveryFromOrderChildDialogView> eCompleted { get; set; } 
                     
    }
 
    }
  
            
    public partial class DeliveryFromOrderHeaderChildDialogView : View
    {
        public DeliveryFromOrderHeaderChildDialogView(DeliveryNoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CreateHeader = RPSControlFactory.CreateRPSCheckBox<DeliveryFromOrderHeaderChildDialogView>("3dabc14e-8fa6-4849-a87d-08e004a773bb","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<DeliveryFromOrderHeaderChildDialogView>("c5b8aa53-b5c7-4eaa-b2cc-10c252b8f02a","","",false, this);
 
            OrderDate = RPSControlFactory.CreateRPSOption<DeliveryFromOrderHeaderChildDialogView>( "26f641c4-7247-4624-ab47-9f33e1bfa64b","","",this);
 
            NewDate = RPSControlFactory.CreateRPSOption<DeliveryFromOrderHeaderChildDialogView>( "a4ec8375-bcc9-44b2-b9bc-9723efa2404b","","",this);
 
            IDCustomerDeliveryAddress = RPSControlFactory.CreateRPSComboBox<DeliveryFromOrderHeaderChildDialogView>("90c882f4-b850-4947-9a48-667ff50f65bc","","",false, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<DeliveryFromOrderHeaderChildDialogView>("05deb01d-849e-4584-9adb-2583581d6458","","",false, this);
 

        }
        public IRPSCheckbox<DeliveryFromOrderHeaderChildDialogView> CreateHeader { get; set; } 
        public IRPSComboBox<DeliveryFromOrderHeaderChildDialogView> IDCustomer { get; set; } 
        public IRPSOption<DeliveryFromOrderHeaderChildDialogView> OrderDate { get; set; } 
        public IRPSOption<DeliveryFromOrderHeaderChildDialogView> NewDate { get; set; } 
        public IRPSComboBox<DeliveryFromOrderHeaderChildDialogView> IDCustomerDeliveryAddress { get; set; } 
        public IRPSTextBox<DeliveryFromOrderHeaderChildDialogView> Date { get; set; } 
        public DeliveryNoteSL Screen { get; set; }
        public DeliveryFromOrderHeaderChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SeriesDataChildDialogView : View
    {
        public SeriesDataChildDialogView(DeliveryNoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSComboBox<SeriesDataChildDialogView>("f4e552b4-9222-46a0-8ca1-dd85070dc2c1","","",false, this);
 
            SerieUnitariaInitial = RPSControlFactory.CreateRPSEnumComboBox<SeriesDataChildDialogView>("8f5b0b88-0808-49b8-a2d3-0301b640ae26","","",false, this);
 
            UnitarianSeriesCommand = RPSControlFactory.CreateRPSButton<SeriesDataChildDialogView>( "424941b1-41a1-4c66-95a0-d459ddf679ae","","",this);
 
            CollectionInit params_SeriesDataItemlCollection = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1f21acaa-0d70-4029-b470-838f8266ef81",CSSSelectorGrid="",XPathGrid=""};
            SeriesDataItemlCollection = RPSControlFactory.RPSCreateCollectionWithGrid<SeriesDataItemlCollectionCollectionEditor<SeriesDataChildDialogView>,SeriesDataChildDialogView>( params_SeriesDataItemlCollection,this);
 

        }
        public IRPSComboBox<SeriesDataChildDialogView> IDArticle { get; set; } 
        public IRPSComboBox<SeriesDataChildDialogView> SerieUnitariaInitial { get; set; } 
        public IRPSButton<SeriesDataChildDialogView> UnitarianSeriesCommand { get; set; } 
        public SeriesDataItemlCollectionCollectionEditor<SeriesDataChildDialogView> SeriesDataItemlCollection { get; set; } 
        public DeliveryNoteSL Screen { get; set; }
        public SeriesDataChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SeriesDataItemlCollectionCollectionEditor<SeriesDataChildDialogView>:RPSCollectionEditor<SeriesDataChildDialogView> where SeriesDataChildDialogView : class, IView
    {
        public  SeriesDataItemlCollectionGridView<SeriesDataChildDialogView> GridView {get;set;}
    }
    public partial class SeriesDataItemlCollectionGridView <SeriesDataChildDialogView> :  RPSGridView<SeriesDataChildDialogView> where SeriesDataChildDialogView : class, IView
    {
        public SeriesDataItemlCollectionGridView(SeriesDataChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Series = RPSControlFactory.CreateRPSGridEnumComboBox<SeriesDataChildDialogView>("","#1f21acaa-0d70-4029-b470-838f8266ef81 .ag-row[role='row']@ROWINDEX [col-id='cSeries']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<SeriesDataChildDialogView>("","#1f21acaa-0d70-4029-b470-838f8266ef81 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSGridFormattedTextBox<SeriesDataChildDialogView>("","#1f21acaa-0d70-4029-b470-838f8266ef81 .ag-row[role='row']@ROWINDEX [col-id='cQuantitySecondUnit']","",false, this.CurrentView);
 
            ExpiryDate = RPSControlFactory.CreateRPSGridTextBox<SeriesDataChildDialogView>("","#1f21acaa-0d70-4029-b470-838f8266ef81 .ag-row[role='row']@ROWINDEX [col-id='cExpiryDate']","",false, this.CurrentView);
 
            IDArticleContainer = RPSControlFactory.CreateRPSGridComboBox<SeriesDataChildDialogView>("","#1f21acaa-0d70-4029-b470-838f8266ef81 .ag-row[role='row']@ROWINDEX [col-id='cIDArticleContainer']","",false, this.CurrentView);
 
            QuantityContainer = RPSControlFactory.CreateRPSGridFormattedTextBox<SeriesDataChildDialogView>("","#1f21acaa-0d70-4029-b470-838f8266ef81 .ag-row[role='row']@ROWINDEX [col-id='cQuantityContainer']","",false, this.CurrentView);
 
            QuantitySecondUnitContainer = RPSControlFactory.CreateRPSGridFormattedTextBox<SeriesDataChildDialogView>("","#1f21acaa-0d70-4029-b470-838f8266ef81 .ag-row[role='row']@ROWINDEX [col-id='cQuantitySecondUnitContainer']","",false, this.CurrentView);
 
            PotencyValue = RPSControlFactory.CreateRPSGridFormattedTextBox<SeriesDataChildDialogView>("","#1f21acaa-0d70-4029-b470-838f8266ef81 .ag-row[role='row']@ROWINDEX [col-id='cPotencyValue']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<SeriesDataChildDialogView> Series { get; set; } 
        public IRPSGridTextBox<SeriesDataChildDialogView> Quantity { get; set; } 
        public IRPSGridTextBox<SeriesDataChildDialogView> QuantitySecondUnit { get; set; } 
        public IRPSGridTextBox<SeriesDataChildDialogView> ExpiryDate { get; set; } 
        public IRPSGridComboBox<SeriesDataChildDialogView> IDArticleContainer { get; set; } 
        public IRPSGridTextBox<SeriesDataChildDialogView> QuantityContainer { get; set; } 
        public IRPSGridTextBox<SeriesDataChildDialogView> QuantitySecondUnitContainer { get; set; } 
        public IRPSGridTextBox<SeriesDataChildDialogView> PotencyValue { get; set; } 
                     
    }
 
    }
  
            
    public partial class InvoiceAssignmentChildDialogView : View
    {
        public InvoiceAssignmentChildDialogView(DeliveryNoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            InvoiceNumber = RPSControlFactory.CreateRPSTextBox<InvoiceAssignmentChildDialogView>("233c1165-a10a-4784-a80b-1de1c4852c3f","","",true, this);
 

        }
        public IRPSTextBox<InvoiceAssignmentChildDialogView> InvoiceNumber { get; set; } 
        public DeliveryNoteSL Screen { get; set; }
        public InvoiceAssignmentChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DeliveryNoteLabelPrintDialogView : View
    {
        public DeliveryNoteLabelPrintDialogView(DeliveryNoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UILabels = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLabelPrintDialogView>("e1b00684-1ed3-414b-9812-a8bcf9c08e6b","","",false, this);
 
            UIGrossWeight = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLabelPrintDialogView>("357782c5-69f1-4672-8032-b24c48833254","","",false, this);
 
            UINetWeight = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLabelPrintDialogView>("16848ba0-51ab-4f2b-a251-7229370a0244","","",false, this);
 
            UIVolume = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLabelPrintDialogView>("95e31aab-5a5e-41c9-84a2-ba7e4d5cf823","","",false, this);
 
            UIDeliveryNoteText1 = RPSControlFactory.CreateRPSTextBox<DeliveryNoteLabelPrintDialogView>("32d393ea-64a0-4eb0-b3ce-e081b0018be7","","",false, this);
 
            UIDeliveryNoteText2 = RPSControlFactory.CreateRPSTextBox<DeliveryNoteLabelPrintDialogView>("5e2d3346-9378-4fd2-9a8b-5d0605e4d45e","","",false, this);
 
            UIDeliveryNoteText3 = RPSControlFactory.CreateRPSTextBox<DeliveryNoteLabelPrintDialogView>("1c5fd62f-5d03-4fe5-8ed1-7fa90d95e94d","","",false, this);
 
            UIDeliveryNoteText4 = RPSControlFactory.CreateRPSTextBox<DeliveryNoteLabelPrintDialogView>("e051f08f-e59e-46f0-bfea-b4f04f1e1cea","","",false, this);
 

        }
        public IRPSTextBox<DeliveryNoteLabelPrintDialogView> UILabels { get; set; } 
        public IRPSTextBox<DeliveryNoteLabelPrintDialogView> UIGrossWeight { get; set; } 
        public IRPSTextBox<DeliveryNoteLabelPrintDialogView> UINetWeight { get; set; } 
        public IRPSTextBox<DeliveryNoteLabelPrintDialogView> UIVolume { get; set; } 
        public IRPSTextBox<DeliveryNoteLabelPrintDialogView> UIDeliveryNoteText1 { get; set; } 
        public IRPSTextBox<DeliveryNoteLabelPrintDialogView> UIDeliveryNoteText2 { get; set; } 
        public IRPSTextBox<DeliveryNoteLabelPrintDialogView> UIDeliveryNoteText3 { get; set; } 
        public IRPSTextBox<DeliveryNoteLabelPrintDialogView> UIDeliveryNoteText4 { get; set; } 
        public DeliveryNoteSL Screen { get; set; }
        public DeliveryNoteLabelPrintDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DeliveryNoteComAgentNewChildDialogView : View
    {
        public DeliveryNoteComAgentNewChildDialogView(DeliveryNoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDCommercialAgent = RPSControlFactory.CreateRPSComboBox<DeliveryNoteComAgentNewChildDialogView>("e1efbaf9-69db-40a7-a08d-771299e85e10","","",true, this);
 
            IDCommercialAgentClassification = RPSControlFactory.CreateRPSComboBox<DeliveryNoteComAgentNewChildDialogView>("79db3c80-a05e-48ff-9f87-5ba73ee0491b","","",true, this);
 

        }
        public IRPSComboBox<DeliveryNoteComAgentNewChildDialogView> IDCommercialAgent { get; set; } 
        public IRPSComboBox<DeliveryNoteComAgentNewChildDialogView> IDCommercialAgentClassification { get; set; } 
        public DeliveryNoteSL Screen { get; set; }
        public DeliveryNoteComAgentNewChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DeliveryFromOrderChildByArticleChildDialogView : View
    {
        public DeliveryFromOrderChildByArticleChildDialogView(DeliveryNoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSComboBox<DeliveryFromOrderChildByArticleChildDialogView>("6ee6eace-0197-4bd2-b32f-a871b2f5cd4d","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryFromOrderChildByArticleChildDialogView>("916c2ace-ccc9-4f90-8a8c-be966edd5cce","","",false, this);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryFromOrderChildByArticleChildDialogView>("90e6692c-47e9-4db0-83a8-1d8b3476fbd2","","",false, this);
 

        }
        public IRPSComboBox<DeliveryFromOrderChildByArticleChildDialogView> IDArticle { get; set; } 
        public IRPSTextBox<DeliveryFromOrderChildByArticleChildDialogView> Quantity { get; set; } 
        public IRPSTextBox<DeliveryFromOrderChildByArticleChildDialogView> QuantitySecondUnit { get; set; } 
        public DeliveryNoteSL Screen { get; set; }
        public DeliveryFromOrderChildByArticleChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DirectSeriesDataChildDialogView : View
    {
        public DirectSeriesDataChildDialogView(DeliveryNoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSComboBox<DirectSeriesDataChildDialogView>("3fdd4bcb-1858-44a3-bb35-fa68fe44265f","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<DirectSeriesDataChildDialogView>("f446461d-d1d9-4123-bc6f-631c39051c3c","","",true, this);
 
            SerieUnitariaInitial = RPSControlFactory.CreateRPSEnumComboBox<DirectSeriesDataChildDialogView>("64aef0ff-16e7-45b8-a2c6-a9eb879b5f74","","",false, this);
 
            UnitarianSeriesCommand = RPSControlFactory.CreateRPSButton<DirectSeriesDataChildDialogView>( "b6ec344f-f444-474d-ba24-36259c77132c","","",this);
 
            CollectionInit params_DirectSeriesDataItemlCollection1 = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="68c29519-c00f-43fe-8627-bc7572287ff9",CSSSelectorGrid="",XPathGrid=""};
            DirectSeriesDataItemlCollection1 = RPSControlFactory.RPSCreateCollectionWithGrid<DirectSeriesDataItemlCollection1CollectionEditor<DirectSeriesDataChildDialogView>,DirectSeriesDataChildDialogView>( params_DirectSeriesDataItemlCollection1,this);
 

        }
        public IRPSComboBox<DirectSeriesDataChildDialogView> IDArticle { get; set; } 
        public IRPSTextBox<DirectSeriesDataChildDialogView> Quantity { get; set; } 
        public IRPSComboBox<DirectSeriesDataChildDialogView> SerieUnitariaInitial { get; set; } 
        public IRPSButton<DirectSeriesDataChildDialogView> UnitarianSeriesCommand { get; set; } 
        public DirectSeriesDataItemlCollection1CollectionEditor<DirectSeriesDataChildDialogView> DirectSeriesDataItemlCollection1 { get; set; } 
        public DeliveryNoteSL Screen { get; set; }
        public DirectSeriesDataChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DirectSeriesDataItemlCollection1CollectionEditor<DirectSeriesDataChildDialogView>:RPSCollectionEditor<DirectSeriesDataChildDialogView> where DirectSeriesDataChildDialogView : class, IView
    {
        public  DirectSeriesDataItemlCollection1GridView<DirectSeriesDataChildDialogView> GridView {get;set;}
    }
    public partial class DirectSeriesDataItemlCollection1GridView <DirectSeriesDataChildDialogView> :  RPSGridView<DirectSeriesDataChildDialogView> where DirectSeriesDataChildDialogView : class, IView
    {
        public DirectSeriesDataItemlCollection1GridView(DirectSeriesDataChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Series = RPSControlFactory.CreateRPSGridEnumComboBox<DirectSeriesDataChildDialogView>("","#68c29519-c00f-43fe-8627-bc7572287ff9 .ag-row[role='row']@ROWINDEX [col-id='cSeries']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<DirectSeriesDataChildDialogView>("","#68c29519-c00f-43fe-8627-bc7572287ff9 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSGridFormattedTextBox<DirectSeriesDataChildDialogView>("","#68c29519-c00f-43fe-8627-bc7572287ff9 .ag-row[role='row']@ROWINDEX [col-id='cQuantitySecondUnit']","",false, this.CurrentView);
 
            ExpiryDate = RPSControlFactory.CreateRPSGridTextBox<DirectSeriesDataChildDialogView>("","#68c29519-c00f-43fe-8627-bc7572287ff9 .ag-row[role='row']@ROWINDEX [col-id='cExpiryDate']","",false, this.CurrentView);
 
            IDArticleContainer = RPSControlFactory.CreateRPSGridComboBox<DirectSeriesDataChildDialogView>("","#68c29519-c00f-43fe-8627-bc7572287ff9 .ag-row[role='row']@ROWINDEX [col-id='cIDArticleContainer']","",false, this.CurrentView);
 
            QuantityContainer = RPSControlFactory.CreateRPSGridFormattedTextBox<DirectSeriesDataChildDialogView>("","#68c29519-c00f-43fe-8627-bc7572287ff9 .ag-row[role='row']@ROWINDEX [col-id='cQuantityContainer']","",false, this.CurrentView);
 
            QuantitySecondUnitContainer = RPSControlFactory.CreateRPSGridFormattedTextBox<DirectSeriesDataChildDialogView>("","#68c29519-c00f-43fe-8627-bc7572287ff9 .ag-row[role='row']@ROWINDEX [col-id='cQuantitySecondUnitContainer']","",false, this.CurrentView);
 
            PotencyValue = RPSControlFactory.CreateRPSGridFormattedTextBox<DirectSeriesDataChildDialogView>("","#68c29519-c00f-43fe-8627-bc7572287ff9 .ag-row[role='row']@ROWINDEX [col-id='cPotencyValue']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<DirectSeriesDataChildDialogView> Series { get; set; } 
        public IRPSGridTextBox<DirectSeriesDataChildDialogView> Quantity { get; set; } 
        public IRPSGridTextBox<DirectSeriesDataChildDialogView> QuantitySecondUnit { get; set; } 
        public IRPSGridTextBox<DirectSeriesDataChildDialogView> ExpiryDate { get; set; } 
        public IRPSGridComboBox<DirectSeriesDataChildDialogView> IDArticleContainer { get; set; } 
        public IRPSGridTextBox<DirectSeriesDataChildDialogView> QuantityContainer { get; set; } 
        public IRPSGridTextBox<DirectSeriesDataChildDialogView> QuantitySecondUnitContainer { get; set; } 
        public IRPSGridTextBox<DirectSeriesDataChildDialogView> PotencyValue { get; set; } 
                     
    }
 
    }
  
            
    public partial class DeliveryNoteSLToRoadMapChildDialogView : View
    {
        public DeliveryNoteSLToRoadMapChildDialogView(DeliveryNoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDRoadMapSL = RPSControlFactory.CreateRPSComboBox<DeliveryNoteSLToRoadMapChildDialogView>("d19d8d4b-f234-4847-b443-a62457a09045","","",true, this);
 
            AddRoadMapCommand = RPSControlFactory.CreateRPSButton<DeliveryNoteSLToRoadMapChildDialogView>( "14088d8e-c6d8-466d-ac42-260808bef7f2","","",this);
 
            DeleteRoadMapCommand = RPSControlFactory.CreateRPSButton<DeliveryNoteSLToRoadMapChildDialogView>( "d956b506-9d89-4a82-aa84-3a64981c6259","","",this);
 
            CollectionInit params_GetDeliveryNoteRoadMaps = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d6c3ac6b-b39f-4be0-8658-579d7e18d340",CSSSelectorGrid="",XPathGrid=""};
            GetDeliveryNoteRoadMaps = RPSControlFactory.RPSCreateCollectionWithGrid<GetDeliveryNoteRoadMapsCollectionEditor<DeliveryNoteSLToRoadMapChildDialogView>,DeliveryNoteSLToRoadMapChildDialogView>( params_GetDeliveryNoteRoadMaps,this);
 

        }
        public IRPSComboBox<DeliveryNoteSLToRoadMapChildDialogView> IDRoadMapSL { get; set; } 
        public IRPSButton<DeliveryNoteSLToRoadMapChildDialogView> AddRoadMapCommand { get; set; } 
        public IRPSButton<DeliveryNoteSLToRoadMapChildDialogView> DeleteRoadMapCommand { get; set; } 
        public GetDeliveryNoteRoadMapsCollectionEditor<DeliveryNoteSLToRoadMapChildDialogView> GetDeliveryNoteRoadMaps { get; set; } 
        public DeliveryNoteSL Screen { get; set; }
        public DeliveryNoteSLToRoadMapChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetDeliveryNoteRoadMapsCollectionEditor<DeliveryNoteSLToRoadMapChildDialogView>:RPSCollectionEditor<DeliveryNoteSLToRoadMapChildDialogView> where DeliveryNoteSLToRoadMapChildDialogView : class, IView
    {
        public  GetDeliveryNoteRoadMapsGridView<DeliveryNoteSLToRoadMapChildDialogView> GridView {get;set;}
    }
    public partial class GetDeliveryNoteRoadMapsGridView <DeliveryNoteSLToRoadMapChildDialogView> :  RPSGridView<DeliveryNoteSLToRoadMapChildDialogView> where DeliveryNoteSLToRoadMapChildDialogView : class, IView
    {
        public GetDeliveryNoteRoadMapsGridView(DeliveryNoteSLToRoadMapChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ExpeditionDate = RPSControlFactory.CreateRPSGridTextBox<DeliveryNoteSLToRoadMapChildDialogView>("","#d6c3ac6b-b39f-4be0-8658-579d7e18d340 .ag-row[role='row']@ROWINDEX [col-id='cExpeditionDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<DeliveryNoteSLToRoadMapChildDialogView> ExpeditionDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class AnalyticChildDialogView : View
    {
        public AnalyticChildDialogView(DeliveryNoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIIDAccount = RPSControlFactory.CreateRPSComboBox<AnalyticChildDialogView>("96849d4e-bdbf-4157-94be-456b30053a76","","",false, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<AnalyticChildDialogView>("77bbbd57-973e-45ee-939e-653d4ba7f721","","",true, this);
 
            GetDimensionChildCommandButton = RPSControlFactory.CreateRPSButton<AnalyticChildDialogView>( "18ac4fa8-c966-4f32-92ce-44d34def72d3","","",this);
 
            CollectionInit params_OrderLineAnalyticSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c6fdc1ff-c7f4-485f-aae0-b830323b10b7",CSSSelectorGrid="",XPathGrid=""};
            OrderLineAnalyticSLs = RPSControlFactory.RPSCreateCollectionWithGrid<OrderLineAnalyticSLsCollectionEditor<AnalyticChildDialogView>,AnalyticChildDialogView>( params_OrderLineAnalyticSLs,this);
 

        }
        public IRPSComboBox<AnalyticChildDialogView> UIIDAccount { get; set; } 
        public IRPSTextBox<AnalyticChildDialogView> Amount { get; set; } 
        public IRPSButton<AnalyticChildDialogView> GetDimensionChildCommandButton { get; set; } 
        public OrderLineAnalyticSLsCollectionEditor<AnalyticChildDialogView> OrderLineAnalyticSLs { get; set; } 
        public DeliveryNoteSL Screen { get; set; }
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
            IDDimension = RPSControlFactory.CreateRPSGridComboBox<AnalyticChildDialogView>("","#c6fdc1ff-c7f4-485f-aae0-b830323b10b7 .ag-row[role='row']@ROWINDEX [col-id='cIDDimension']","",true, this.CurrentView);
 
            IDDimValue = RPSControlFactory.CreateRPSGridComboBox<AnalyticChildDialogView>("","#c6fdc1ff-c7f4-485f-aae0-b830323b10b7 .ag-row[role='row']@ROWINDEX [col-id='cIDDimValue']","",true, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<AnalyticChildDialogView>("","#c6fdc1ff-c7f4-485f-aae0-b830323b10b7 .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<AnalyticChildDialogView>("","#c6fdc1ff-c7f4-485f-aae0-b830323b10b7 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<AnalyticChildDialogView> IDDimension { get; set; } 
        public IRPSGridComboBox<AnalyticChildDialogView> IDDimValue { get; set; } 
        public IRPSGridTextBox<AnalyticChildDialogView> Percentage { get; set; } 
        public IRPSGridTextBox<AnalyticChildDialogView> Amount { get; set; } 
                     
    }
 
    }
  
            
    public partial class DepositChildDialogView : View
    {
        public DepositChildDialogView(DeliveryNoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDCustomer = RPSControlFactory.CreateRPSComboBox<DepositChildDialogView>("3ee033a6-2a25-45c3-838e-e1d965f859be","","",true, this);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<DepositChildDialogView>("cf38e3dd-d610-450b-a936-e14888a55436","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<DepositChildDialogView>("938bc1a5-bdcf-4714-808d-565afdaf7a49","","",false, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<DepositChildDialogView>("ba966ce9-6f85-47bf-a656-b183421bd309","","",false, this);
 

        }
        public IRPSComboBox<DepositChildDialogView> IDCustomer { get; set; } 
        public IRPSComboBox<DepositChildDialogView> IDDeliveryNoteType { get; set; } 
        public IRPSComboBox<DepositChildDialogView> IDSite { get; set; } 
        public IRPSComboBox<DepositChildDialogView> IDWarehouse { get; set; } 
        public DeliveryNoteSL Screen { get; set; }
        public DepositChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class LocationChildDialogView : View
    {
        public LocationChildDialogView(DeliveryNoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSComboBox<LocationChildDialogView>("05fb48ef-ac45-45d5-a612-47a028e53af6","","",false, this);
 
            NewDeliveryNoteLineMovementSLOutputsButton = RPSControlFactory.CreateRPSButton<LocationChildDialogView>( "f46dcd55-c054-4845-9b16-9dd75b73183e","","",this);
 
            CollectionInit params_DeliveryNoteLineMovementSLOutputs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5ba68885-a1f8-4c69-b987-a799c24155b2",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNoteLineMovementSLOutputs = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNoteLineMovementSLOutputsCollectionEditor<LocationChildDialogView>,LocationChildDialogView>( params_DeliveryNoteLineMovementSLOutputs,this);
 

        }
        public IRPSComboBox<LocationChildDialogView> IDArticle { get; set; } 
        public IRPSButton<LocationChildDialogView> NewDeliveryNoteLineMovementSLOutputsButton { get; set; } 
        public DeliveryNoteLineMovementSLOutputsCollectionEditor<LocationChildDialogView> DeliveryNoteLineMovementSLOutputs { get; set; } 
        public DeliveryNoteSL Screen { get; set; }
        public LocationChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DeliveryNoteLineMovementSLOutputsCollectionEditor<LocationChildDialogView>:RPSCollectionEditor<LocationChildDialogView> where LocationChildDialogView : class, IView
    {
        public  DeliveryNoteLineMovementSLOutputsGridView<LocationChildDialogView> GridView {get;set;}
    }
    public partial class DeliveryNoteLineMovementSLOutputsGridView <LocationChildDialogView> :  RPSGridView<LocationChildDialogView> where LocationChildDialogView : class, IView
    {
        public DeliveryNoteLineMovementSLOutputsGridView(LocationChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDLocationWarehouseOutput = RPSControlFactory.CreateRPSGridComboBox<LocationChildDialogView>("","#5ba68885-a1f8-4c69-b987-a799c24155b2 .ag-row[role='row']@ROWINDEX [col-id='cIDLocationWarehouseOutput']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<LocationChildDialogView>("","#5ba68885-a1f8-4c69-b987-a799c24155b2 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSGridFormattedTextBox<LocationChildDialogView>("","#5ba68885-a1f8-4c69-b987-a799c24155b2 .ag-row[role='row']@ROWINDEX [col-id='cQuantitySecondUnit']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<LocationChildDialogView> IDLocationWarehouseOutput { get; set; } 
        public IRPSGridTextBox<LocationChildDialogView> Quantity { get; set; } 
        public IRPSGridTextBox<LocationChildDialogView> QuantitySecondUnit { get; set; } 
                     
    }
 
    }
  
            
    public partial class TransferChildDialogView : View
    {
        public TransferChildDialogView(DeliveryNoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSComboBox<TransferChildDialogView>("4dc9f933-889b-46aa-8b60-3d73dd13297e","","",false, this);
 
            NewDeliveryNoteLineMovementSLEntryButton = RPSControlFactory.CreateRPSButton<TransferChildDialogView>( "0347e83c-74a1-460f-952b-5acd4e2387f5","","",this);
 
            CollectionInit params_DeliveryNoteLineMovementSLEntrys = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c2fdfc1e-ea44-4b0e-9c17-3cd754455e14",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNoteLineMovementSLEntrys = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNoteLineMovementSLEntrysCollectionEditor<TransferChildDialogView>,TransferChildDialogView>( params_DeliveryNoteLineMovementSLEntrys,this);
 

        }
        public IRPSComboBox<TransferChildDialogView> IDArticle { get; set; } 
        public IRPSButton<TransferChildDialogView> NewDeliveryNoteLineMovementSLEntryButton { get; set; } 
        public DeliveryNoteLineMovementSLEntrysCollectionEditor<TransferChildDialogView> DeliveryNoteLineMovementSLEntrys { get; set; } 
        public DeliveryNoteSL Screen { get; set; }
        public TransferChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DeliveryNoteLineMovementSLEntrysCollectionEditor<TransferChildDialogView>:RPSCollectionEditor<TransferChildDialogView> where TransferChildDialogView : class, IView
    {
        public  DeliveryNoteLineMovementSLEntrysGridView<TransferChildDialogView> GridView {get;set;}
    }
    public partial class DeliveryNoteLineMovementSLEntrysGridView <TransferChildDialogView> :  RPSGridView<TransferChildDialogView> where TransferChildDialogView : class, IView
    {
        public DeliveryNoteLineMovementSLEntrysGridView(TransferChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            EntryDate = RPSControlFactory.CreateRPSGridTextBox<TransferChildDialogView>("","#c2fdfc1e-ea44-4b0e-9c17-3cd754455e14 .ag-row[role='row']@ROWINDEX [col-id='cEntryDate']","",false, this.CurrentView);
 
            IDLocationWarehouseEntry = RPSControlFactory.CreateRPSGridComboBox<TransferChildDialogView>("","#c2fdfc1e-ea44-4b0e-9c17-3cd754455e14 .ag-row[role='row']@ROWINDEX [col-id='cIDLocationWarehouseEntry']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<TransferChildDialogView>("","#c2fdfc1e-ea44-4b0e-9c17-3cd754455e14 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSGridFormattedTextBox<TransferChildDialogView>("","#c2fdfc1e-ea44-4b0e-9c17-3cd754455e14 .ag-row[role='row']@ROWINDEX [col-id='cQuantitySecondUnit']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<TransferChildDialogView> EntryDate { get; set; } 
        public IRPSGridComboBox<TransferChildDialogView> IDLocationWarehouseEntry { get; set; } 
        public IRPSGridTextBox<TransferChildDialogView> Quantity { get; set; } 
        public IRPSGridTextBox<TransferChildDialogView> QuantitySecondUnit { get; set; } 
                     
    }
 
    }
  
            
    public partial class CuDistDeliveryNoteFromPackingListPopUpDialogView : View
    {
        public CuDistDeliveryNoteFromPackingListPopUpDialogView(DeliveryNoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDCustomer = RPSControlFactory.CreateRPSComboBox<CuDistDeliveryNoteFromPackingListPopUpDialogView>("0d4cb5f9-1508-4965-b75b-ef16864ce1ec","","",false, this);
 
            LoadPackingListsCommand = RPSControlFactory.CreateRPSButton<CuDistDeliveryNoteFromPackingListPopUpDialogView>( "cc4d0206-9e72-440a-8ebb-cf3d2367cd76","","",this);
 
            CreateDeliveryNoteCommand = RPSControlFactory.CreateRPSButton<CuDistDeliveryNoteFromPackingListPopUpDialogView>( "cb744eeb-13ff-4379-a917-e2683ad32b62","","",this);
 
            CloseCommand = RPSControlFactory.CreateRPSButton<CuDistDeliveryNoteFromPackingListPopUpDialogView>( "41194570-9d9b-43aa-a393-947cebbdde30","","",this);
 
            TransferCommand = RPSControlFactory.CreateRPSButton<CuDistDeliveryNoteFromPackingListPopUpDialogView>( "cd5ac58f-38f3-4862-b700-d4943cf6d6e5","","",this);
 
            ClearTransferLinesCommand = RPSControlFactory.CreateRPSButton<CuDistDeliveryNoteFromPackingListPopUpDialogView>( "754a5af4-47fb-4972-a2d9-ea2bb00476ae","","",this);
 
            CollectionInit params_PackingListCollection = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="474f9a2b-a05b-4e4e-82dc-8b36eddfd6d6",CSSSelectorGrid="",XPathGrid=""};
            PackingListCollection = RPSControlFactory.RPSCreateCollectionWithGrid<PackingListCollectionCollectionEditor<CuDistDeliveryNoteFromPackingListPopUpDialogView>,CuDistDeliveryNoteFromPackingListPopUpDialogView>( params_PackingListCollection,this);
 
            CollectionInit params_PackingListBoxCollection = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="2c899204-8e8b-4b3c-be30-dcff1589e4fe",CSSSelectorGrid="",XPathGrid=""};
            PackingListBoxCollection = RPSControlFactory.RPSCreateCollectionWithGrid<PackingListBoxCollectionCollectionEditor<CuDistDeliveryNoteFromPackingListPopUpDialogView>,CuDistDeliveryNoteFromPackingListPopUpDialogView>( params_PackingListBoxCollection,this);
 
            CollectionInit params_DeliveryNoteLinesToGenerateCollection = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ec7e830f-68c8-4aad-b152-63f7c88907ea",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNoteLinesToGenerateCollection = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNoteLinesToGenerateCollectionCollectionEditor<CuDistDeliveryNoteFromPackingListPopUpDialogView>,CuDistDeliveryNoteFromPackingListPopUpDialogView>( params_DeliveryNoteLinesToGenerateCollection,this);
 

        }
        public IRPSComboBox<CuDistDeliveryNoteFromPackingListPopUpDialogView> IDCustomer { get; set; } 
        public IRPSButton<CuDistDeliveryNoteFromPackingListPopUpDialogView> LoadPackingListsCommand { get; set; } 
        public IRPSButton<CuDistDeliveryNoteFromPackingListPopUpDialogView> CreateDeliveryNoteCommand { get; set; } 
        public IRPSButton<CuDistDeliveryNoteFromPackingListPopUpDialogView> CloseCommand { get; set; } 
        public IRPSButton<CuDistDeliveryNoteFromPackingListPopUpDialogView> TransferCommand { get; set; } 
        public IRPSButton<CuDistDeliveryNoteFromPackingListPopUpDialogView> ClearTransferLinesCommand { get; set; } 
        public PackingListCollectionCollectionEditor<CuDistDeliveryNoteFromPackingListPopUpDialogView> PackingListCollection { get; set; } 
        public PackingListBoxCollectionCollectionEditor<CuDistDeliveryNoteFromPackingListPopUpDialogView> PackingListBoxCollection { get; set; } 
        public DeliveryNoteLinesToGenerateCollectionCollectionEditor<CuDistDeliveryNoteFromPackingListPopUpDialogView> DeliveryNoteLinesToGenerateCollection { get; set; } 
        public DeliveryNoteSL Screen { get; set; }
        public CuDistDeliveryNoteFromPackingListPopUpDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class PackingListCollectionCollectionEditor<CuDistDeliveryNoteFromPackingListPopUpDialogView>:RPSCollectionEditor<CuDistDeliveryNoteFromPackingListPopUpDialogView> where CuDistDeliveryNoteFromPackingListPopUpDialogView : class, IView
    {
        public  PackingListCollectionGridView<CuDistDeliveryNoteFromPackingListPopUpDialogView> GridView {get;set;}
    }
    public partial class PackingListCollectionGridView <CuDistDeliveryNoteFromPackingListPopUpDialogView> :  RPSGridView<CuDistDeliveryNoteFromPackingListPopUpDialogView> where CuDistDeliveryNoteFromPackingListPopUpDialogView : class, IView
    {
        public PackingListCollectionGridView(CuDistDeliveryNoteFromPackingListPopUpDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodPackingList = RPSControlFactory.CreateRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView>("","#474f9a2b-a05b-4e4e-82dc-8b36eddfd6d6 .ag-row[role='row']@ROWINDEX [col-id='cCodPackingList']","",false, this.CurrentView);
 
            IDCustomer = RPSControlFactory.CreateRPSGridComboBox<CuDistDeliveryNoteFromPackingListPopUpDialogView>("","#474f9a2b-a05b-4e4e-82dc-8b36eddfd6d6 .ag-row[role='row']@ROWINDEX [col-id='cIDCustomer']","",false, this.CurrentView);
 
            DescCustomer = RPSControlFactory.CreateRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView>("","#474f9a2b-a05b-4e4e-82dc-8b36eddfd6d6 .ag-row[role='row']@ROWINDEX [col-id='cDescCustomer']","",false, this.CurrentView);
 
            Comment = RPSControlFactory.CreateRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView>("","#474f9a2b-a05b-4e4e-82dc-8b36eddfd6d6 .ag-row[role='row']@ROWINDEX [col-id='cComment']","",false, this.CurrentView);
 
            Finished = RPSControlFactory.CreateRPSGridCheckBox<CuDistDeliveryNoteFromPackingListPopUpDialogView>("","#474f9a2b-a05b-4e4e-82dc-8b36eddfd6d6 .ag-row[role='row']@ROWINDEX [col-id='cFinished']","",false, this.CurrentView);
 
            PackingDate = RPSControlFactory.CreateRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView>("","#474f9a2b-a05b-4e4e-82dc-8b36eddfd6d6 .ag-row[role='row']@ROWINDEX [col-id='cPackingDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView> CodPackingList { get; set; } 
        public IRPSGridComboBox<CuDistDeliveryNoteFromPackingListPopUpDialogView> IDCustomer { get; set; } 
        public IRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView> DescCustomer { get; set; } 
        public IRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView> Comment { get; set; } 
        public IRPSGridCheckbox<CuDistDeliveryNoteFromPackingListPopUpDialogView> Finished { get; set; } 
        public IRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView> PackingDate { get; set; } 
                     
    }
 
        public partial class PackingListBoxCollectionCollectionEditor<CuDistDeliveryNoteFromPackingListPopUpDialogView>:RPSCollectionEditor<CuDistDeliveryNoteFromPackingListPopUpDialogView> where CuDistDeliveryNoteFromPackingListPopUpDialogView : class, IView
    {
        public  PackingListBoxCollectionGridView<CuDistDeliveryNoteFromPackingListPopUpDialogView> GridView {get;set;}
    }
    public partial class PackingListBoxCollectionGridView <CuDistDeliveryNoteFromPackingListPopUpDialogView> :  RPSGridView<CuDistDeliveryNoteFromPackingListPopUpDialogView> where CuDistDeliveryNoteFromPackingListPopUpDialogView : class, IView
    {
        public PackingListBoxCollectionGridView(CuDistDeliveryNoteFromPackingListPopUpDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodArticle = RPSControlFactory.CreateRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView>("","#2c899204-8e8b-4b3c-be30-dcff1589e4fe .ag-row[role='row']@ROWINDEX [col-id='cCodArticle']","",false, this.CurrentView);
 
            DescArticle = RPSControlFactory.CreateRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView>("","#2c899204-8e8b-4b3c-be30-dcff1589e4fe .ag-row[role='row']@ROWINDEX [col-id='cDescArticle']","",false, this.CurrentView);
 
            NumLine = RPSControlFactory.CreateRPSGridFormattedTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView>("","#2c899204-8e8b-4b3c-be30-dcff1589e4fe .ag-row[role='row']@ROWINDEX [col-id='cNumLine']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView>("","#2c899204-8e8b-4b3c-be30-dcff1589e4fe .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            CodMeasureUnit = RPSControlFactory.CreateRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView>("","#2c899204-8e8b-4b3c-be30-dcff1589e4fe .ag-row[role='row']@ROWINDEX [col-id='cCodMeasureUnit']","",false, this.CurrentView);
 
            CodOrder = RPSControlFactory.CreateRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView>("","#2c899204-8e8b-4b3c-be30-dcff1589e4fe .ag-row[role='row']@ROWINDEX [col-id='cCodOrder']","",false, this.CurrentView);
 
            OrderNumberCustomer = RPSControlFactory.CreateRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView>("","#2c899204-8e8b-4b3c-be30-dcff1589e4fe .ag-row[role='row']@ROWINDEX [col-id='cOrderNumberCustomer']","",false, this.CurrentView);
 
            CodManufacturingOrder = RPSControlFactory.CreateRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView>("","#2c899204-8e8b-4b3c-be30-dcff1589e4fe .ag-row[role='row']@ROWINDEX [col-id='cCodManufacturingOrder']","",false, this.CurrentView);
 
            DescManOrder = RPSControlFactory.CreateRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView>("","#2c899204-8e8b-4b3c-be30-dcff1589e4fe .ag-row[role='row']@ROWINDEX [col-id='cDescManOrder']","",false, this.CurrentView);
 
            CodProject = RPSControlFactory.CreateRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView>("","#2c899204-8e8b-4b3c-be30-dcff1589e4fe .ag-row[role='row']@ROWINDEX [col-id='cCodProject']","",false, this.CurrentView);
 
            DescProject = RPSControlFactory.CreateRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView>("","#2c899204-8e8b-4b3c-be30-dcff1589e4fe .ag-row[role='row']@ROWINDEX [col-id='cDescProject']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView> CodArticle { get; set; } 
        public IRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView> DescArticle { get; set; } 
        public IRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView> NumLine { get; set; } 
        public IRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView> Quantity { get; set; } 
        public IRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView> CodMeasureUnit { get; set; } 
        public IRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView> CodOrder { get; set; } 
        public IRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView> OrderNumberCustomer { get; set; } 
        public IRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView> CodManufacturingOrder { get; set; } 
        public IRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView> DescManOrder { get; set; } 
        public IRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView> CodProject { get; set; } 
        public IRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView> DescProject { get; set; } 
                     
    }
 
        public partial class DeliveryNoteLinesToGenerateCollectionCollectionEditor<CuDistDeliveryNoteFromPackingListPopUpDialogView>:RPSCollectionEditor<CuDistDeliveryNoteFromPackingListPopUpDialogView> where CuDistDeliveryNoteFromPackingListPopUpDialogView : class, IView
    {
        public  DeliveryNoteLinesToGenerateCollectionGridView<CuDistDeliveryNoteFromPackingListPopUpDialogView> GridView {get;set;}
    }
    public partial class DeliveryNoteLinesToGenerateCollectionGridView <CuDistDeliveryNoteFromPackingListPopUpDialogView> :  RPSGridView<CuDistDeliveryNoteFromPackingListPopUpDialogView> where CuDistDeliveryNoteFromPackingListPopUpDialogView : class, IView
    {
        public DeliveryNoteLinesToGenerateCollectionGridView(CuDistDeliveryNoteFromPackingListPopUpDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodPackingList = RPSControlFactory.CreateRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView>("","#ec7e830f-68c8-4aad-b152-63f7c88907ea .ag-row[role='row']@ROWINDEX [col-id='cCodPackingList']","",false, this.CurrentView);
 
            CodArticle = RPSControlFactory.CreateRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView>("","#ec7e830f-68c8-4aad-b152-63f7c88907ea .ag-row[role='row']@ROWINDEX [col-id='cCodArticle']","",false, this.CurrentView);
 
            DescArticle = RPSControlFactory.CreateRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView>("","#ec7e830f-68c8-4aad-b152-63f7c88907ea .ag-row[role='row']@ROWINDEX [col-id='cDescArticle']","",false, this.CurrentView);
 
            NumLine = RPSControlFactory.CreateRPSGridFormattedTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView>("","#ec7e830f-68c8-4aad-b152-63f7c88907ea .ag-row[role='row']@ROWINDEX [col-id='cNumLine']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView>("","#ec7e830f-68c8-4aad-b152-63f7c88907ea .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            CodMeasureUnit = RPSControlFactory.CreateRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView>("","#ec7e830f-68c8-4aad-b152-63f7c88907ea .ag-row[role='row']@ROWINDEX [col-id='cCodMeasureUnit']","",false, this.CurrentView);
 
            CodOrder = RPSControlFactory.CreateRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView>("","#ec7e830f-68c8-4aad-b152-63f7c88907ea .ag-row[role='row']@ROWINDEX [col-id='cCodOrder']","",false, this.CurrentView);
 
            OrderNumberCustomer = RPSControlFactory.CreateRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView>("","#ec7e830f-68c8-4aad-b152-63f7c88907ea .ag-row[role='row']@ROWINDEX [col-id='cOrderNumberCustomer']","",false, this.CurrentView);
 
            CodManufacturingOrder = RPSControlFactory.CreateRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView>("","#ec7e830f-68c8-4aad-b152-63f7c88907ea .ag-row[role='row']@ROWINDEX [col-id='cCodManufacturingOrder']","",false, this.CurrentView);
 
            DescManOrder = RPSControlFactory.CreateRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView>("","#ec7e830f-68c8-4aad-b152-63f7c88907ea .ag-row[role='row']@ROWINDEX [col-id='cDescManOrder']","",false, this.CurrentView);
 
            CodProject = RPSControlFactory.CreateRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView>("","#ec7e830f-68c8-4aad-b152-63f7c88907ea .ag-row[role='row']@ROWINDEX [col-id='cCodProject']","",false, this.CurrentView);
 
            DescProject = RPSControlFactory.CreateRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView>("","#ec7e830f-68c8-4aad-b152-63f7c88907ea .ag-row[role='row']@ROWINDEX [col-id='cDescProject']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView> CodPackingList { get; set; } 
        public IRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView> CodArticle { get; set; } 
        public IRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView> DescArticle { get; set; } 
        public IRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView> NumLine { get; set; } 
        public IRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView> Quantity { get; set; } 
        public IRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView> CodMeasureUnit { get; set; } 
        public IRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView> CodOrder { get; set; } 
        public IRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView> OrderNumberCustomer { get; set; } 
        public IRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView> CodManufacturingOrder { get; set; } 
        public IRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView> DescManOrder { get; set; } 
        public IRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView> CodProject { get; set; } 
        public IRPSGridTextBox<CuDistDeliveryNoteFromPackingListPopUpDialogView> DescProject { get; set; } 
                     
    }
 
    }
  
    

}