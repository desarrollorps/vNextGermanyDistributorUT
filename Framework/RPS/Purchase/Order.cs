    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.Order
{
    //RPS VERSION 1.0.0.0
    public partial class Order:Screen
    {
        public Order():base()
        {
            this.URL = "purchase.order";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            OrderCollectionView  = new OrderCollectionView(this); 
            OrderEntityView  = new OrderEntityView(this); 
            OrderLineView  = new OrderLineView(this); 
            OrderLineTaxView  = new OrderLineTaxView(this); 
            OrderLineAnalyticView  = new OrderLineAnalyticView(this); 
            OrderAdvanceView  = new OrderAdvanceView(this); 
            OrderAdvanceTaxView  = new OrderAdvanceTaxView(this); 
            OrderVariablePaymentView  = new OrderVariablePaymentView(this); 
            OrderChangesChildDialogView  = new OrderChangesChildDialogView(this); 
            NewOrderChildDialogView  = new NewOrderChildDialogView(this); 
            ArticleGenericChildDialogView  = new ArticleGenericChildDialogView(this); 
            ArticleAlternativeChildDialogView  = new ArticleAlternativeChildDialogView(this); 
            OrderPrintDialogView  = new OrderPrintDialogView(this); 
            GenerateDeliveryNoteChildDialogView  = new GenerateDeliveryNoteChildDialogView(this); 
            ChangeOrderSupplierChildDialogView  = new ChangeOrderSupplierChildDialogView(this); 
            OrderAdvanceChildDialogView  = new OrderAdvanceChildDialogView(this); 
            RelatedFWCManagementChildDialogView  = new RelatedFWCManagementChildDialogView(this); 
            AutomaticMaterialInputationDialogView  = new AutomaticMaterialInputationDialogView(this); 
            ModifyOrderSituationDialogView  = new ModifyOrderSituationDialogView(this); 
            OrderIncidenceView  = new OrderIncidenceView(this); 
            AnalyticChildDialogView  = new AnalyticChildDialogView(this); 
            OrderCollectionView.InitializeControls(); 
            OrderEntityView.InitializeControls(); 
            OrderLineView.InitializeControls(); 
            OrderLineTaxView.InitializeControls(); 
            OrderLineAnalyticView.InitializeControls(); 
            OrderAdvanceView.InitializeControls(); 
            OrderAdvanceTaxView.InitializeControls(); 
            OrderVariablePaymentView.InitializeControls(); 
            OrderChangesChildDialogView.InitializeControls(); 
            NewOrderChildDialogView.InitializeControls(); 
            ArticleGenericChildDialogView.InitializeControls(); 
            ArticleAlternativeChildDialogView.InitializeControls(); 
            OrderPrintDialogView.InitializeControls(); 
            GenerateDeliveryNoteChildDialogView.InitializeControls(); 
            ChangeOrderSupplierChildDialogView.InitializeControls(); 
            OrderAdvanceChildDialogView.InitializeControls(); 
            RelatedFWCManagementChildDialogView.InitializeControls(); 
            AutomaticMaterialInputationDialogView.InitializeControls(); 
            ModifyOrderSituationDialogView.InitializeControls(); 
            OrderIncidenceView.InitializeControls(); 
            AnalyticChildDialogView.InitializeControls(); 
           
        }
      
            public OrderCollectionView OrderCollectionView {get; set; } 
            public OrderEntityView OrderEntityView {get; set; } 
            public OrderLineView OrderLineView {get; set; } 
            public OrderLineTaxView OrderLineTaxView {get; set; } 
            public OrderLineAnalyticView OrderLineAnalyticView {get; set; } 
            public OrderAdvanceView OrderAdvanceView {get; set; } 
            public OrderAdvanceTaxView OrderAdvanceTaxView {get; set; } 
            public OrderVariablePaymentView OrderVariablePaymentView {get; set; } 
            public OrderChangesChildDialogView OrderChangesChildDialogView {get; set; } 
            public NewOrderChildDialogView NewOrderChildDialogView {get; set; } 
            public ArticleGenericChildDialogView ArticleGenericChildDialogView {get; set; } 
            public ArticleAlternativeChildDialogView ArticleAlternativeChildDialogView {get; set; } 
            public OrderPrintDialogView OrderPrintDialogView {get; set; } 
            public GenerateDeliveryNoteChildDialogView GenerateDeliveryNoteChildDialogView {get; set; } 
            public ChangeOrderSupplierChildDialogView ChangeOrderSupplierChildDialogView {get; set; } 
            public OrderAdvanceChildDialogView OrderAdvanceChildDialogView {get; set; } 
            public RelatedFWCManagementChildDialogView RelatedFWCManagementChildDialogView {get; set; } 
            public AutomaticMaterialInputationDialogView AutomaticMaterialInputationDialogView {get; set; } 
            public ModifyOrderSituationDialogView ModifyOrderSituationDialogView {get; set; } 
            public OrderIncidenceView OrderIncidenceView {get; set; } 
            public AnalyticChildDialogView AnalyticChildDialogView {get; set; } 
    }
            
    public partial class OrderCollectionView : View
    {
        public OrderCollectionView(Order screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<OrderCollectionView,OrderEntityView>( this,Screen.OrderEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "ac5ba1b7-dcd2-4eaa-8135-18ddb2b80b25",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<OrderCollectionView,OrderEntityView>( params_MainConsult,this,Screen.OrderEntityView);
 

        }
        public IRPSButton<OrderCollectionView,OrderEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<OrderCollectionView,OrderEntityView> MainConsult { get; set; } 
        public Order Screen { get; set; }
        public OrderCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OrderEntityView : View
    {
        public OrderEntityView(Order screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<OrderEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<OrderEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<OrderEntityView,OrderCollectionView>( this,Screen.OrderCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<OrderEntityView,OrderCollectionView>( this,Screen.OrderCollectionView);
 
            TotalLines = RPSControlFactory.CreateRPSFormattedTextBox<OrderEntityView>("a9d0538b-82d3-46d7-90f1-d1cbddbf5a7a","","",false, this);
 
            TotalBase = RPSControlFactory.CreateRPSFormattedTextBox<OrderEntityView>("880e11d6-5348-4616-b4de-0bf10a53b155","","",false, this);
 
            TotalVAT = RPSControlFactory.CreateRPSFormattedTextBox<OrderEntityView>("1dd09890-4f0a-454a-9067-f17fe98e58a1","","",false, this);
 
            TotalTax = RPSControlFactory.CreateRPSFormattedTextBox<OrderEntityView>("3790f805-b743-41c0-ad0b-8d18c99dcb9e","","",false, this);
 
            TotalAmount = RPSControlFactory.CreateRPSFormattedTextBox<OrderEntityView>("2ba553dc-1316-4f3d-9a1f-e62a6d7b222e","","",false, this);
 
            TotalAdvances = RPSControlFactory.CreateRPSFormattedTextBox<OrderEntityView>("d0b6d856-c7fd-4ae0-9e84-6c03ae703e6e","","",false, this);
 
            Transport = RPSControlFactory.CreateRPSFormattedTextBox<OrderEntityView>("69ee3c5f-0ca3-48d9-ab3c-b28cd38c9c31","","",true, this);
 
            InsertPurchaseProposalCommandButton = RPSControlFactory.CreateRPSButton<OrderEntityView>( "46c6ab14-548e-4b44-8fe4-1c7a92903d0e","","",this);
 
            InsertSupplierArticleCommandButton = RPSControlFactory.CreateRPSButton<OrderEntityView>( "6313a89b-1525-4bdd-b297-0c2f14d84b5d","","",this);
 
            OrderChangesChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<OrderEntityView,OrderChangesChildDialogView>("bf707b9c-bcb5-41ae-84ba-8afaf0fb4afe","","", this,Screen.OrderChangesChildDialogView);
 
            CodOrder = RPSControlFactory.CreateRPSTextBox<OrderEntityView>("fa12bcfd-38b5-4c9a-a269-a316c6eb8cbb","","",true, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<OrderEntityView>("8de8ab5f-c593-45b1-be30-a1b6cb547aa4","","",true, this);
 
            IDSupplierMiscellaneous = RPSControlFactory.CreateRPSComboBox<OrderEntityView>("772adbda-e1c2-40e0-b1a0-02fddabb21d7","","",false, this);
 
            IDSupplierContact = RPSControlFactory.CreateRPSComboBox<OrderEntityView>("79514682-1186-46cd-a06e-34e7d82b1f92","","",false, this);
 
            OrderNumberSupplier = RPSControlFactory.CreateRPSTextBox<OrderEntityView>("e031b45c-c308-45ff-bc3d-b8361e3eae38","","",false, this);
 
            IDContactAdministration = RPSControlFactory.CreateRPSComboBox<OrderEntityView>("8e2e93ae-e226-4aca-8aff-94ee4db1ebbf","","",false, this);
 
            IDOrderSituation = RPSControlFactory.CreateRPSComboBox<OrderEntityView>("38222342-9602-46b2-86c9-65145733e75f","","",true, this);
 
            OrderDate = RPSControlFactory.CreateRPSTextBox<OrderEntityView>("cb1e4918-e42c-4b35-a087-5fb18ce8a8cb","","",true, this);
 
            ReceptionDate = RPSControlFactory.CreateRPSTextBox<OrderEntityView>("4bd5416b-538c-40b7-9e94-634b08556795","","",true, this);
 
            ReceptionDemandDate = RPSControlFactory.CreateRPSTextBox<OrderEntityView>("412ff507-0d32-4cf9-817e-1df5f246ad92","","",true, this);
 
            Status = RPSControlFactory.CreateRPSFormattedTextBox<OrderEntityView>("09f01660-3940-492e-9768-23b64ad8cf23","","",true, this);
 
            UICodCompanySales = RPSControlFactory.CreateRPSTextBox<OrderEntityView>("537143f2-7ca0-4a2a-a590-ee39c413a4ae","","",false, this);
 
            IDIntOrderSales = RPSControlFactory.CreateRPSComboBox<OrderEntityView>("d3e07ee5-dc0e-41d8-9d5d-a9415ee8b56c","","",false, this);
 
            IDSiteSales = RPSControlFactory.CreateRPSComboBox<OrderEntityView>("bb98b06c-11fe-42dd-aa12-9a101cd75def","","",false, this);
 
            ClaimsNumber = RPSControlFactory.CreateRPSFormattedTextBox<OrderEntityView>("e3713026-14cb-42d0-92c9-7e07c394c3ac","","",true, this);
 
            LastPrintDate = RPSControlFactory.CreateRPSTextBox<OrderEntityView>("3cf0676a-8f17-471c-8831-d5d4ecd7835a","","",false, this);
 
            LastPrintUser = RPSControlFactory.CreateRPSComboBox<OrderEntityView>("57f68eeb-dd2c-4811-95bf-d56f80c85005","","",false, this);
 
            IDBusinessUnit = RPSControlFactory.CreateRPSComboBox<OrderEntityView>("a25f7e14-2d55-4537-bcac-90421faa8890","","",false, this);
 
            PurchaseManager = RPSControlFactory.CreateRPSComboBox<OrderEntityView>("bdbb1949-1ec1-4f37-bae5-ea719228808b","","",false, this);
 
            IDInvoicingType = RPSControlFactory.CreateRPSComboBox<OrderEntityView>("b16e2563-6dc1-4d4e-85a7-18eccc561a95","","",true, this);
 
            IDSupplierPayment = RPSControlFactory.CreateRPSComboBox<OrderEntityView>("d6e6667d-973e-4e14-8f9e-bc40cb29e216","","",false, this);
 
            IDSupplierBankAccount = RPSControlFactory.CreateRPSComboBox<OrderEntityView>("d25e6c7e-8eb0-4b5d-919b-d058f0f7d336","","",false, this);
 
            IDVoucherType = RPSControlFactory.CreateRPSComboBox<OrderEntityView>("48bc37e7-0765-4666-b6bd-b34e34dc66a1","","",false, this);
 
            IDBankAccountCompany = RPSControlFactory.CreateRPSComboBox<OrderEntityView>("e1ff5189-9dc3-4db7-9139-2100b715a3c5","","",false, this);
 
            IDEUInvoice = RPSControlFactory.CreateRPSComboBox<OrderEntityView>("67c84dcd-5429-481e-88aa-99c400d0d3a4","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<OrderEntityView>("533b2079-c927-491e-9f35-46008845a1d1","","",false, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<OrderEntityView>("7ef5b59b-1dc8-4295-9ee1-57f94ddc3c6f","","",false, this);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<OrderEntityView>("0a894668-670c-426f-b3e5-9b87eabb51f8","","",false, this);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSComboBox<OrderEntityView>("f6d8cf45-4039-442f-b42e-edb7e41f8247","","",true, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<OrderEntityView>("2151be00-4d22-4958-a729-39d2f4b98c8a","","",true, this);
 
            Change = RPSControlFactory.CreateRPSFormattedTextBox<OrderEntityView>("1b21d6b2-775c-4a66-9364-22bce5448ef0","","",true, this);
 
            FixedChange = RPSControlFactory.CreateRPSCheckBox<OrderEntityView>("df60c751-8981-4e7f-a69e-54a004d1e7a8","","",true, this);
 
            Transport1 = RPSControlFactory.CreateRPSFormattedTextBox<OrderEntityView>("651d234d-9c73-411e-b260-d9407e7b5d2a","","",true, this);
 
            IDVATType = RPSControlFactory.CreateRPSComboBox<OrderEntityView>("13a8b9ed-f462-4f44-8de7-04c90ce1871b","","",true, this);
 
            IDSurchargeVATType = RPSControlFactory.CreateRPSComboBox<OrderEntityView>("27c5ef13-ad68-464d-ab06-a3ee4a291f8d","","",false, this);
 
            IDTaxGroup = RPSControlFactory.CreateRPSComboBox<OrderEntityView>("ce32cccd-6f85-48a9-9a40-d1353fcb5b02","","",false, this);
 
            Discount1 = RPSControlFactory.CreateRPSFormattedTextBox<OrderEntityView>("44de16fe-1992-4cf8-84f3-fa7945b536b7","","",true, this);
 
            Discount2 = RPSControlFactory.CreateRPSFormattedTextBox<OrderEntityView>("e306caac-0aaa-4606-a39b-4aa8cceda87d","","",true, this);
 
            Discount3 = RPSControlFactory.CreateRPSFormattedTextBox<OrderEntityView>("78e5c33f-b639-4b39-bf37-6a14786d25ff","","",true, this);
 
            CashDiscount = RPSControlFactory.CreateRPSFormattedTextBox<OrderEntityView>("132d63d5-e5bb-479e-a43d-2edc7b9f0515","","",true, this);
 
            FinancialSurcharge = RPSControlFactory.CreateRPSFormattedTextBox<OrderEntityView>("f56ef51a-1a1c-493f-a47d-1978ba386920","","",true, this);
 
            RetentionPercent = RPSControlFactory.CreateRPSFormattedTextBox<OrderEntityView>("4f2ed14e-6024-4c8f-abb5-487396909fb2","","",true, this);
 
            IDSupplierOrderAddress = RPSControlFactory.CreateRPSComboBox<OrderEntityView>("2b80807e-8fce-4e96-9f12-80065a082076","","",false, this);
 
            IDDeliveryAddress = RPSControlFactory.CreateRPSComboBox<OrderEntityView>("0bb324ee-2c8d-430e-8570-0198952ccf80","","",false, this);
 
            IDShippingAgent = RPSControlFactory.CreateRPSComboBox<OrderEntityView>("c2ac8f12-b07c-42b6-8b99-5288ef978c09","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<OrderEntityView>("c2808fb6-82c3-4bc0-b7f4-066951b1865f","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<OrderEntityView>("30976f53-dff7-4632-acf5-f88eb7f05c78","","",false, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<OrderEntityView>("b5be6c3d-3131-4993-806b-7fe2405565a6","","",false, this);
 
            ContactPerson = RPSControlFactory.CreateRPSTextBox<OrderEntityView>("04cd664b-7b9f-425b-b6b8-33a5986812a3","","",false, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<OrderEntityView>("bdef39ce-2ded-46d6-94cc-8ee133a60903","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<OrderEntityView>("25da53e7-c1c6-46ae-af71-ee1bf9c0d116","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<OrderEntityView>("4305495a-80a4-4742-b3bd-63481bd81675","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<OrderEntityView>("5fae4ff6-9dc2-4d99-94ab-97b52347db66","","",false, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<OrderEntityView>("6bcfd0d4-31c6-4f50-8393-bd0e1b64c0f3","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<OrderEntityView>("19c04da1-4f91-41ba-baf3-5be82388f883","","",false, this);
 
            CodBusinessType = RPSControlFactory.CreateRPSComboBox<OrderEntityView>("1b1b9b62-e25e-418a-bc29-e55b030f80a2","","",false, this);
 
            CodTransportMethod = RPSControlFactory.CreateRPSComboBox<OrderEntityView>("8f9add29-b08c-4191-8ce5-3a84222e6166","","",false, this);
 
            CodHarborAirport = RPSControlFactory.CreateRPSComboBox<OrderEntityView>("48750212-a0a1-4e06-9262-a7b3953af332","","",false, this);
 
            CodDeliveryTerm = RPSControlFactory.CreateRPSComboBox<OrderEntityView>("9ce087e8-52d3-4a07-afcf-91a26dafc4d0","","",false, this);
 
            StatisticRegime = RPSControlFactory.CreateRPSEnumComboBox<OrderEntityView>("6f8feecc-f744-49c3-bdc6-3216d2c787eb","","",true, this);
 
            PercentPurchase = RPSControlFactory.CreateRPSFormattedTextBox<OrderEntityView>("f0cf8f40-c298-48e4-9479-158fa25c3c59","","",true, this);
 
            IDMaintenanceOrder = RPSControlFactory.CreateRPSComboBox<OrderEntityView>("574542c8-54d6-4372-890f-448a6998abd7","","",false, this);
 
            UICodMaintenanceContract = RPSControlFactory.CreateRPSTextBox<OrderEntityView>("609c57b7-ee43-447a-ad22-d028e1e3f21c","","",false, this);
 
            IDImportOrderType = RPSControlFactory.CreateRPSComboBox<OrderEntityView>("90fe2a44-47ef-45ea-8638-8435986ae7b6","","",false, this);
 
            PreTextIDTextLine = RPSControlFactory.CreateRPSComboBox<OrderEntityView>("a6c5f564-a0ac-423d-a1e3-59671472cac2","","",false, this);
 
            PreText = RPSControlFactory.CreateRPSTextBox<OrderEntityView>("1783be0f-c9f8-40f4-99aa-47716d82ce09","","",false, this);
 
            PostTextIDTextLine = RPSControlFactory.CreateRPSComboBox<OrderEntityView>("815d554b-3f7a-4ad6-9a8a-e8e5049f6b29","","",false, this);
 
            PostText = RPSControlFactory.CreateRPSTextBox<OrderEntityView>("db5b29cd-44e9-43f7-8abe-fdf85d04b917","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<OrderEntityView>("30eb925b-f46f-4fa8-bede-fc4e6dd2fd10","","",false, this);
 
            CommentSend = RPSControlFactory.CreateRPSTextBox<OrderEntityView>("d008f61b-412b-406b-860f-dab07978113b","","",false, this);
 
            QuoteNumberSupplier = RPSControlFactory.CreateRPSTextBox<OrderEntityView>("c3a3efaa-9154-40b8-99d6-4462f089338a","","",false, this);
 
            IDRequester = RPSControlFactory.CreateRPSComboBox<OrderEntityView>("bf93ffb2-2742-48dc-a8c2-470f289c42c9","","",false, this);
 
            RequestDescription = RPSControlFactory.CreateRPSTextBox<OrderEntityView>("cef936a7-3233-4acd-93dc-975cea5a132a","","",false, this);
 
            PrintOptionsCommandButton = RPSControlFactory.CreateRPSButtonToView<OrderEntityView,OrderPrintDialogView>("36645d6f-3dc3-42ee-b8c3-8f42467c1040","","", this,Screen.OrderPrintDialogView);
 
            TotalsUpdateButton = RPSControlFactory.CreateRPSButton<OrderEntityView>( "f81fcc66-a14a-4b8f-aa8a-3405e25a2b54","","",this);
 
            GenerateDeliveryNoteChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<OrderEntityView,GenerateDeliveryNoteChildDialogView>("6c7a2b65-49dc-4c79-afa8-9bff6b12f6c0","","", this,Screen.GenerateDeliveryNoteChildDialogView);
 
            NewOrderChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<OrderEntityView,NewOrderChildDialogView>("d3306861-a688-4255-b863-23a4a8c85ca4","","", this,Screen.NewOrderChildDialogView);
 
            RecalculatePromotionButton = RPSControlFactory.CreateRPSButton<OrderEntityView>( "9635e1e0-9b03-4b3a-8baa-c511da2623af","","",this);
 
            ChangeOrderSupplierChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<OrderEntityView,ChangeOrderSupplierChildDialogView>("c567b64e-331a-4884-a1fa-7a4df6b70213","","", this,Screen.ChangeOrderSupplierChildDialogView);
 
            ModifyOrderSituationNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<OrderEntityView,ModifyOrderSituationDialogView>("d4433014-aac6-4074-9b5f-2e4a3b9154ea","","", this,Screen.ModifyOrderSituationDialogView);
 
            CollectionInit params_OrderLines = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="80809f1b-d667-4f1d-be47-28d3df223c35",CSSSelectorGrid="",XPathGrid=""};
            OrderLines = RPSControlFactory.RPSCreateCollectionWithGrid<OrderLinesCollectionEditor<OrderEntityView,OrderAdvanceView>,OrderEntityView,OrderAdvanceView>( params_OrderLines,this,Screen.OrderAdvanceView);
 
            CollectionInit params_OrderAdvances = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="499b91cf-f094-4b4f-95d2-2a01bd97a206",CSSSelectorGrid="",XPathGrid=""};
            OrderAdvances = RPSControlFactory.RPSCreateCollectionWithGrid<OrderAdvancesCollectionEditor<OrderEntityView,OrderAdvanceView>,OrderEntityView,OrderAdvanceView>( params_OrderAdvances,this,Screen.OrderAdvanceView);
 
            CollectionInit params_OrderVariablePayments = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b035837a-7f67-4ae8-8aef-18134ba7caf1",CSSSelectorGrid="",XPathGrid=""};
            OrderVariablePayments = RPSControlFactory.RPSCreateCollectionWithGrid<OrderVariablePaymentsCollectionEditor<OrderEntityView,OrderAdvanceView>,OrderEntityView,OrderAdvanceView>( params_OrderVariablePayments,this,Screen.OrderAdvanceView);
 
            CollectionInit params_OrderIncidences = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="9204c361-2e22-4ae8-a0d4-cbd732516712",CSSSelectorGrid="",XPathGrid=""};
            OrderIncidences = RPSControlFactory.RPSCreateCollectionWithGrid<OrderIncidencesCollectionEditor<OrderEntityView,OrderAdvanceView>,OrderEntityView,OrderAdvanceView>( params_OrderIncidences,this,Screen.OrderAdvanceView);
 
            LinesSection = RPSControlFactory.CreateRPSSection<OrderEntityView>( "","ul li[rpsid='47cd5583-0e85-44cd-a4a8-f132189b2764']","",this);
 
            GeneralDataSection = RPSControlFactory.CreateRPSSection<OrderEntityView>( "","ul li[rpsid='2ee3ba36-2f0c-4e73-a510-7d877ed631a7']","",this);
 
            AdvanceSection = RPSControlFactory.CreateRPSSection<OrderEntityView>( "","ul li[rpsid='8d1e44fd-2e0c-413d-8b61-cae582b56376']","",this);
 
            VariablePaymentSection = RPSControlFactory.CreateRPSSection<OrderEntityView>( "","ul li[rpsid='806d1d10-82d5-44c3-9918-3427b06c223e']","",this);
 
            TextLine = RPSControlFactory.CreateRPSSection<OrderEntityView>( "","ul li[rpsid='6778af68-1bd1-479f-9b75-ed1dc265886f']","",this);
 
            Incidences = RPSControlFactory.CreateRPSSection<OrderEntityView>( "","ul li[rpsid='9ef630f9-50a4-4348-abb4-efbfb167df30']","",this);
 
            CommentsSection = RPSControlFactory.CreateRPSSection<OrderEntityView>( "","ul li[rpsid='0340706d-e584-4734-979e-eb757b687953']","",this);
 
            DPS = RPSControlFactory.CreateRPSSection<OrderEntityView>( "","ul li[rpsid='74691fd5-34cc-43c7-af46-3d94e9ca64f4']","",this);
 

        }
        public IRPSSaveButton<OrderEntityView> SaveButton { get; set; } 
        public IRPSButton<OrderEntityView> DeleteButton { get; set; } 
        public IRPSButton<OrderEntityView,OrderCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<OrderEntityView,OrderCollectionView> BackButton { get; set; } 
        public IRPSTextBox<OrderEntityView> TotalLines { get; set; } 
        public IRPSTextBox<OrderEntityView> TotalBase { get; set; } 
        public IRPSTextBox<OrderEntityView> TotalVAT { get; set; } 
        public IRPSTextBox<OrderEntityView> TotalTax { get; set; } 
        public IRPSTextBox<OrderEntityView> TotalAmount { get; set; } 
        public IRPSTextBox<OrderEntityView> TotalAdvances { get; set; } 
        public IRPSTextBox<OrderEntityView> Transport { get; set; } 
        public IRPSButton<OrderEntityView> InsertPurchaseProposalCommandButton { get; set; } 
        public IRPSButton<OrderEntityView> InsertSupplierArticleCommandButton { get; set; } 
        public IRPSButton<OrderEntityView,OrderChangesChildDialogView> OrderChangesChildNavigationCommandButton { get; set; } 
        public IRPSTextBox<OrderEntityView> CodOrder { get; set; } 
        public IRPSComboBox<OrderEntityView> IDSupplier { get; set; } 
        public IRPSComboBox<OrderEntityView> IDSupplierMiscellaneous { get; set; } 
        public IRPSComboBox<OrderEntityView> IDSupplierContact { get; set; } 
        public IRPSTextBox<OrderEntityView> OrderNumberSupplier { get; set; } 
        public IRPSComboBox<OrderEntityView> IDContactAdministration { get; set; } 
        public IRPSComboBox<OrderEntityView> IDOrderSituation { get; set; } 
        public IRPSTextBox<OrderEntityView> OrderDate { get; set; } 
        public IRPSTextBox<OrderEntityView> ReceptionDate { get; set; } 
        public IRPSTextBox<OrderEntityView> ReceptionDemandDate { get; set; } 
        public IRPSTextBox<OrderEntityView> Status { get; set; } 
        public IRPSTextBox<OrderEntityView> UICodCompanySales { get; set; } 
        public IRPSComboBox<OrderEntityView> IDIntOrderSales { get; set; } 
        public IRPSComboBox<OrderEntityView> IDSiteSales { get; set; } 
        public IRPSTextBox<OrderEntityView> ClaimsNumber { get; set; } 
        public IRPSTextBox<OrderEntityView> LastPrintDate { get; set; } 
        public IRPSComboBox<OrderEntityView> LastPrintUser { get; set; } 
        public IRPSComboBox<OrderEntityView> IDBusinessUnit { get; set; } 
        public IRPSComboBox<OrderEntityView> PurchaseManager { get; set; } 
        public IRPSComboBox<OrderEntityView> IDInvoicingType { get; set; } 
        public IRPSComboBox<OrderEntityView> IDSupplierPayment { get; set; } 
        public IRPSComboBox<OrderEntityView> IDSupplierBankAccount { get; set; } 
        public IRPSComboBox<OrderEntityView> IDVoucherType { get; set; } 
        public IRPSComboBox<OrderEntityView> IDBankAccountCompany { get; set; } 
        public IRPSComboBox<OrderEntityView> IDEUInvoice { get; set; } 
        public IRPSComboBox<OrderEntityView> IDSite { get; set; } 
        public IRPSComboBox<OrderEntityView> IDWarehouse { get; set; } 
        public IRPSComboBox<OrderEntityView> IDDeliveryNoteType { get; set; } 
        public IRPSComboBox<OrderEntityView> IDPaymentMethod { get; set; } 
        public IRPSComboBox<OrderEntityView> IDCurrency { get; set; } 
        public IRPSTextBox<OrderEntityView> Change { get; set; } 
        public IRPSCheckbox<OrderEntityView> FixedChange { get; set; } 
        public IRPSTextBox<OrderEntityView> Transport1 { get; set; } 
        public IRPSComboBox<OrderEntityView> IDVATType { get; set; } 
        public IRPSComboBox<OrderEntityView> IDSurchargeVATType { get; set; } 
        public IRPSComboBox<OrderEntityView> IDTaxGroup { get; set; } 
        public IRPSTextBox<OrderEntityView> Discount1 { get; set; } 
        public IRPSTextBox<OrderEntityView> Discount2 { get; set; } 
        public IRPSTextBox<OrderEntityView> Discount3 { get; set; } 
        public IRPSTextBox<OrderEntityView> CashDiscount { get; set; } 
        public IRPSTextBox<OrderEntityView> FinancialSurcharge { get; set; } 
        public IRPSTextBox<OrderEntityView> RetentionPercent { get; set; } 
        public IRPSComboBox<OrderEntityView> IDSupplierOrderAddress { get; set; } 
        public IRPSComboBox<OrderEntityView> IDDeliveryAddress { get; set; } 
        public IRPSComboBox<OrderEntityView> IDShippingAgent { get; set; } 
        public IRPSTextBox<OrderEntityView> Address { get; set; } 
        public IRPSTextBox<OrderEntityView> City { get; set; } 
        public IRPSTextBox<OrderEntityView> ZipCode { get; set; } 
        public IRPSTextBox<OrderEntityView> ContactPerson { get; set; } 
        public IRPSComboBox<OrderEntityView> CodCountry { get; set; } 
        public IRPSComboBox<OrderEntityView> IDState { get; set; } 
        public IRPSComboBox<OrderEntityView> IDCounty { get; set; } 
        public IRPSTextBox<OrderEntityView> Phone2 { get; set; } 
        public IRPSTextBox<OrderEntityView> Phone1 { get; set; } 
        public IRPSTextBox<OrderEntityView> Fax { get; set; } 
        public IRPSComboBox<OrderEntityView> CodBusinessType { get; set; } 
        public IRPSComboBox<OrderEntityView> CodTransportMethod { get; set; } 
        public IRPSComboBox<OrderEntityView> CodHarborAirport { get; set; } 
        public IRPSComboBox<OrderEntityView> CodDeliveryTerm { get; set; } 
        public IRPSComboBox<OrderEntityView> StatisticRegime { get; set; } 
        public IRPSTextBox<OrderEntityView> PercentPurchase { get; set; } 
        public IRPSComboBox<OrderEntityView> IDMaintenanceOrder { get; set; } 
        public IRPSTextBox<OrderEntityView> UICodMaintenanceContract { get; set; } 
        public IRPSComboBox<OrderEntityView> IDImportOrderType { get; set; } 
        public IRPSComboBox<OrderEntityView> PreTextIDTextLine { get; set; } 
        public IRPSTextBox<OrderEntityView> PreText { get; set; } 
        public IRPSComboBox<OrderEntityView> PostTextIDTextLine { get; set; } 
        public IRPSTextBox<OrderEntityView> PostText { get; set; } 
        public IRPSTextBox<OrderEntityView> Comment { get; set; } 
        public IRPSTextBox<OrderEntityView> CommentSend { get; set; } 
        public IRPSTextBox<OrderEntityView> QuoteNumberSupplier { get; set; } 
        public IRPSComboBox<OrderEntityView> IDRequester { get; set; } 
        public IRPSTextBox<OrderEntityView> RequestDescription { get; set; } 
        public IRPSButton<OrderEntityView,OrderPrintDialogView> PrintOptionsCommandButton { get; set; } 
        public IRPSButton<OrderEntityView> TotalsUpdateButton { get; set; } 
        public IRPSButton<OrderEntityView,GenerateDeliveryNoteChildDialogView> GenerateDeliveryNoteChildNavigationCommandButton { get; set; } 
        public IRPSButton<OrderEntityView,NewOrderChildDialogView> NewOrderChildNavigationCommandButton { get; set; } 
        public IRPSButton<OrderEntityView> RecalculatePromotionButton { get; set; } 
        public IRPSButton<OrderEntityView,ChangeOrderSupplierChildDialogView> ChangeOrderSupplierChildNavigationCommandButton { get; set; } 
        public IRPSButton<OrderEntityView,ModifyOrderSituationDialogView> ModifyOrderSituationNavigationCommandButton { get; set; } 
        public OrderLinesCollectionEditor<OrderEntityView,OrderAdvanceView> OrderLines { get; set; } 
        public OrderAdvancesCollectionEditor<OrderEntityView,OrderAdvanceView> OrderAdvances { get; set; } 
        public OrderVariablePaymentsCollectionEditor<OrderEntityView,OrderAdvanceView> OrderVariablePayments { get; set; } 
        public OrderIncidencesCollectionEditor<OrderEntityView,OrderAdvanceView> OrderIncidences { get; set; } 
        public IRPSSection<OrderEntityView> LinesSection { get; set; } 
        public IRPSSection<OrderEntityView> GeneralDataSection { get; set; } 
        public IRPSSection<OrderEntityView> AdvanceSection { get; set; } 
        public IRPSSection<OrderEntityView> VariablePaymentSection { get; set; } 
        public IRPSSection<OrderEntityView> TextLine { get; set; } 
        public IRPSSection<OrderEntityView> Incidences { get; set; } 
        public IRPSSection<OrderEntityView> CommentsSection { get; set; } 
        public IRPSSection<OrderEntityView> DPS { get; set; } 
        public Order Screen { get; set; }
        public OrderEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class OrderLinesCollectionEditor<OrderEntityView,OrderAdvanceView>:RPSCollectionEditor<OrderEntityView,OrderAdvanceView> where OrderEntityView : class, IView where OrderAdvanceView : class, IView
    {
        public  OrderLinesGridView<OrderEntityView,OrderAdvanceView> GridView {get;set;}
    }
    public partial class OrderLinesGridView <OrderEntityView,OrderAdvanceView> :  RPSGridView<OrderEntityView,OrderAdvanceView> where OrderEntityView : class, IView where OrderAdvanceView : class, IView
    {
        public OrderLinesGridView(OrderEntityView currentView,OrderAdvanceView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Ordenation = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderEntityView>("","#80809f1b-d667-4f1d-be47-28d3df223c35 .ag-row[role='row']@ROWINDEX [col-id='cOrdenation']","",true, this.CurrentView);
 
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<OrderEntityView>("","#80809f1b-d667-4f1d-be47-28d3df223c35 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<OrderEntityView>("","#80809f1b-d667-4f1d-be47-28d3df223c35 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Matchcode = RPSControlFactory.CreateRPSGridTextBox<OrderEntityView>("","#80809f1b-d667-4f1d-be47-28d3df223c35 .ag-row[role='row']@ROWINDEX [col-id='cMatchcode']","",false, this.CurrentView);
 
            ReceptionDate = RPSControlFactory.CreateRPSGridTextBox<OrderEntityView>("","#80809f1b-d667-4f1d-be47-28d3df223c35 .ag-row[role='row']@ROWINDEX [col-id='cReceptionDate']","",true, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderEntityView>("","#80809f1b-d667-4f1d-be47-28d3df223c35 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            Price = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderEntityView>("","#80809f1b-d667-4f1d-be47-28d3df223c35 .ag-row[role='row']@ROWINDEX [col-id='cPrice']","",true, this.CurrentView);
 
            PercentVAT = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderEntityView>("","#80809f1b-d667-4f1d-be47-28d3df223c35 .ag-row[role='row']@ROWINDEX [col-id='cPercentVAT']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderEntityView>("","#80809f1b-d667-4f1d-be47-28d3df223c35 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            AmountWithVAT = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderEntityView>("","#80809f1b-d667-4f1d-be47-28d3df223c35 .ag-row[role='row']@ROWINDEX [col-id='cAmountWithVAT']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<OrderEntityView> Ordenation { get; set; } 
        public IRPSGridComboBox<OrderEntityView> IDArticle { get; set; } 
        public IRPSGridTextBox<OrderEntityView> Description { get; set; } 
        public IRPSGridTextBox<OrderEntityView> Matchcode { get; set; } 
        public IRPSGridTextBox<OrderEntityView> ReceptionDate { get; set; } 
        public IRPSGridTextBox<OrderEntityView> Quantity { get; set; } 
        public IRPSGridTextBox<OrderEntityView> Price { get; set; } 
        public IRPSGridTextBox<OrderEntityView> PercentVAT { get; set; } 
        public IRPSGridTextBox<OrderEntityView> Amount { get; set; } 
        public IRPSGridTextBox<OrderEntityView> AmountWithVAT { get; set; } 
                     
    }
 
        public partial class OrderAdvancesCollectionEditor<OrderEntityView,OrderAdvanceView>:RPSCollectionEditor<OrderEntityView,OrderAdvanceView> where OrderEntityView : class, IView where OrderAdvanceView : class, IView
    {
        public  OrderAdvancesGridView<OrderEntityView,OrderAdvanceView> GridView {get;set;}
    }
    public partial class OrderAdvancesGridView <OrderEntityView,OrderAdvanceView> :  RPSGridView<OrderEntityView,OrderAdvanceView> where OrderEntityView : class, IView where OrderAdvanceView : class, IView
    {
        public OrderAdvancesGridView(OrderEntityView currentView,OrderAdvanceView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NumAdvance = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderEntityView>("","#499b91cf-f094-4b4f-95d2-2a01bd97a206 .ag-row[role='row']@ROWINDEX [col-id='cNumAdvance']","",true, this.CurrentView);
 
            AdvanceDate = RPSControlFactory.CreateRPSGridTextBox<OrderEntityView>("","#499b91cf-f094-4b4f-95d2-2a01bd97a206 .ag-row[role='row']@ROWINDEX [col-id='cAdvanceDate']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<OrderEntityView>("","#499b91cf-f094-4b4f-95d2-2a01bd97a206 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderEntityView>("","#499b91cf-f094-4b4f-95d2-2a01bd97a206 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            IDVATType = RPSControlFactory.CreateRPSGridComboBox<OrderEntityView>("","#499b91cf-f094-4b4f-95d2-2a01bd97a206 .ag-row[role='row']@ROWINDEX [col-id='cIDVATType']","",false, this.CurrentView);
 
            VAT = RPSControlFactory.CreateRPSGridCheckBox<OrderEntityView>("","#499b91cf-f094-4b4f-95d2-2a01bd97a206 .ag-row[role='row']@ROWINDEX [col-id='cVAT']","",true, this.CurrentView);
 
            Invoice = RPSControlFactory.CreateRPSGridCheckBox<OrderEntityView>("","#499b91cf-f094-4b4f-95d2-2a01bd97a206 .ag-row[role='row']@ROWINDEX [col-id='cInvoice']","",true, this.CurrentView);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSGridComboBox<OrderEntityView>("","#499b91cf-f094-4b4f-95d2-2a01bd97a206 .ag-row[role='row']@ROWINDEX [col-id='cIDPaymentMethod']","",false, this.CurrentView);
 
            Invoiced = RPSControlFactory.CreateRPSGridCheckBox<OrderEntityView>("","#499b91cf-f094-4b4f-95d2-2a01bd97a206 .ag-row[role='row']@ROWINDEX [col-id='cInvoiced']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<OrderEntityView> NumAdvance { get; set; } 
        public IRPSGridTextBox<OrderEntityView> AdvanceDate { get; set; } 
        public IRPSGridTextBox<OrderEntityView> Description { get; set; } 
        public IRPSGridTextBox<OrderEntityView> Amount { get; set; } 
        public IRPSGridComboBox<OrderEntityView> IDVATType { get; set; } 
        public IRPSGridCheckbox<OrderEntityView> VAT { get; set; } 
        public IRPSGridCheckbox<OrderEntityView> Invoice { get; set; } 
        public IRPSGridComboBox<OrderEntityView> IDPaymentMethod { get; set; } 
        public IRPSGridCheckbox<OrderEntityView> Invoiced { get; set; } 
                     
    }
 
        public partial class OrderVariablePaymentsCollectionEditor<OrderEntityView,OrderAdvanceView>:RPSCollectionEditor<OrderEntityView,OrderAdvanceView> where OrderEntityView : class, IView where OrderAdvanceView : class, IView
    {
        public  OrderVariablePaymentsGridView<OrderEntityView,OrderAdvanceView> GridView {get;set;}
    }
    public partial class OrderVariablePaymentsGridView <OrderEntityView,OrderAdvanceView> :  RPSGridView<OrderEntityView,OrderAdvanceView> where OrderEntityView : class, IView where OrderAdvanceView : class, IView
    {
        public OrderVariablePaymentsGridView(OrderEntityView currentView,OrderAdvanceView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NumPayment = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderEntityView>("","#b035837a-7f67-4ae8-8aef-18134ba7caf1 .ag-row[role='row']@ROWINDEX [col-id='cNumPayment']","",true, this.CurrentView);
 
            DatePayment = RPSControlFactory.CreateRPSGridTextBox<OrderEntityView>("","#b035837a-7f67-4ae8-8aef-18134ba7caf1 .ag-row[role='row']@ROWINDEX [col-id='cDatePayment']","",false, this.CurrentView);
 
            DayPayment = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderEntityView>("","#b035837a-7f67-4ae8-8aef-18134ba7caf1 .ag-row[role='row']@ROWINDEX [col-id='cDayPayment']","",false, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderEntityView>("","#b035837a-7f67-4ae8-8aef-18134ba7caf1 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",false, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderEntityView>("","#b035837a-7f67-4ae8-8aef-18134ba7caf1 .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",false, this.CurrentView);
 
            Rest = RPSControlFactory.CreateRPSGridCheckBox<OrderEntityView>("","#b035837a-7f67-4ae8-8aef-18134ba7caf1 .ag-row[role='row']@ROWINDEX [col-id='cRest']","",true, this.CurrentView);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSGridComboBox<OrderEntityView>("","#b035837a-7f67-4ae8-8aef-18134ba7caf1 .ag-row[role='row']@ROWINDEX [col-id='cIDPaymentMethod']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<OrderEntityView> NumPayment { get; set; } 
        public IRPSGridTextBox<OrderEntityView> DatePayment { get; set; } 
        public IRPSGridTextBox<OrderEntityView> DayPayment { get; set; } 
        public IRPSGridTextBox<OrderEntityView> Amount { get; set; } 
        public IRPSGridTextBox<OrderEntityView> Percentage { get; set; } 
        public IRPSGridCheckbox<OrderEntityView> Rest { get; set; } 
        public IRPSGridComboBox<OrderEntityView> IDPaymentMethod { get; set; } 
                     
    }
 
        public partial class OrderIncidencesCollectionEditor<OrderEntityView,OrderAdvanceView>:RPSCollectionEditor<OrderEntityView,OrderAdvanceView> where OrderEntityView : class, IView where OrderAdvanceView : class, IView
    {
        public  OrderIncidencesGridView<OrderEntityView,OrderAdvanceView> GridView {get;set;}
    }
    public partial class OrderIncidencesGridView <OrderEntityView,OrderAdvanceView> :  RPSGridView<OrderEntityView,OrderAdvanceView> where OrderEntityView : class, IView where OrderAdvanceView : class, IView
    {
        public OrderIncidencesGridView(OrderEntityView currentView,OrderAdvanceView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NumIncidence = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderEntityView>("","#9204c361-2e22-4ae8-a0d4-cbd732516712 .ag-row[role='row']@ROWINDEX [col-id='cNumIncidence']","",true, this.CurrentView);
 
            Date = RPSControlFactory.CreateRPSGridTextBox<OrderEntityView>("","#9204c361-2e22-4ae8-a0d4-cbd732516712 .ag-row[role='row']@ROWINDEX [col-id='cDate']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<OrderEntityView>("","#9204c361-2e22-4ae8-a0d4-cbd732516712 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            IDIncidenceType = RPSControlFactory.CreateRPSGridComboBox<OrderEntityView>("","#9204c361-2e22-4ae8-a0d4-cbd732516712 .ag-row[role='row']@ROWINDEX [col-id='cIDIncidenceType']","",true, this.CurrentView);
 
            IDIncidenceSituation = RPSControlFactory.CreateRPSGridComboBox<OrderEntityView>("","#9204c361-2e22-4ae8-a0d4-cbd732516712 .ag-row[role='row']@ROWINDEX [col-id='cIDIncidenceSituation']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<OrderEntityView> NumIncidence { get; set; } 
        public IRPSGridTextBox<OrderEntityView> Date { get; set; } 
        public IRPSGridTextBox<OrderEntityView> Description { get; set; } 
        public IRPSGridComboBox<OrderEntityView> IDIncidenceType { get; set; } 
        public IRPSGridComboBox<OrderEntityView> IDIncidenceSituation { get; set; } 
                     
    }
 
    }
  
            
    public partial class OrderLineView : View
    {
        public OrderLineView(Order screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<OrderLineView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<OrderLineView,OrderEntityView>( this,Screen.OrderEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<OrderLineView,OrderEntityView>( this,Screen.OrderEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<OrderLineView,OrderEntityView>( this,Screen.OrderEntityView);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<OrderLineView>("24a0c84f-f6a7-4967-83e8-d32a24a32cfb","","",false, this);
 
            ReferenceSupplier = RPSControlFactory.CreateRPSEnumComboBox<OrderLineView>("4a9e6c33-0ce5-43cd-be35-978e7d60e9cd","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineView>("c476b990-509a-409f-8f57-14f13c102105","","",true, this);
 
            Price = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineView>("2f773c25-5757-4caf-85d8-fab02a34559e","","",true, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineView>("b8ca3d9e-44f5-4184-8698-3bcc827aba34","","",true, this);
 
            VAT = RPSControlFactory.CreateRPSCheckBox<OrderLineView>("24f18735-1638-4d78-879d-c96320d85910","","",true, this);
 
            AmountWithVAT = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineView>("1f2e208b-ad27-490c-9880-7c13d39fb5b4","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<OrderLineView>("1c0c6dad-c051-4a5f-8c43-9405b33f722b","","",false, this);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSComboBox<OrderLineView>("8322fa50-e529-4644-831a-964f9978864e","","",true, this);
 
            ConversionFactorQuantity = RPSControlFactory.CreateRPSTextBox<OrderLineView>("3593d708-b148-4446-aca6-557b6a0f96ab","","",true, this);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineView>("a4e567f0-864a-4661-a249-a43b093faf62","","",true, this);
 
            Dimension1 = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineView>("f3761561-65a0-4937-8d2e-dbb6dae9a19f","","",true, this);
 
            Dimension2 = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineView>("ce05740e-f46f-4439-9437-ce200123b7f7","","",true, this);
 
            Dimension3 = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineView>("809f045b-e86c-4680-b0b7-2fc04e4a9d7d","","",true, this);
 
            Ordenation = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineView>("4f3b607b-a783-4557-b353-a137cf4ef4e8","","",true, this);
 
            IDUnitPrice = RPSControlFactory.CreateRPSComboBox<OrderLineView>("039449b5-cd96-4f25-af24-d2a9f2231266","","",true, this);
 
            ConversionFactorPrice = RPSControlFactory.CreateRPSTextBox<OrderLineView>("3cb247c6-fcaa-42d5-8a36-d5c6091b8591","","",true, this);
 
            ReceptionDemandDate = RPSControlFactory.CreateRPSTextBox<OrderLineView>("9157d44e-6020-4ca0-bd4b-5bfada1b3462","","",true, this);
 
            ReceptionDate = RPSControlFactory.CreateRPSTextBox<OrderLineView>("c6bae021-9e05-4918-91bf-512396624ddb","","",true, this);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<OrderLineView>("252e6ee3-9c4f-4997-8568-42cf1de198ad","","",false, this);
 
            Received = RPSControlFactory.CreateRPSCheckBox<OrderLineView>("5a23ceae-50d8-421b-a68f-5bb74bbb7d79","","",true, this);
 
            PendingReceive = RPSControlFactory.CreateRPSCheckBox<OrderLineView>("65e9da37-710f-49c5-bce8-de1fb5c0603d","","",true, this);
 
            ReceivedQuantity = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineView>("5a9fec15-b33a-492c-bee6-e0b7dff9f907","","",true, this);
 
            ReceivedQuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineView>("5acf7e98-1013-45af-a6d8-48d0a266ebcd","","",true, this);
 
            Invoice = RPSControlFactory.CreateRPSCheckBox<OrderLineView>("177d5e78-f581-4d85-9d14-24c35844b421","","",true, this);
 
            Invoiced = RPSControlFactory.CreateRPSCheckBox<OrderLineView>("87b6ae0d-879c-40e8-b2ba-987c792ca80b","","",true, this);
 
            InvoicedQuantity = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineView>("3507d177-71c1-48a7-8017-47e07cfb75c3","","",true, this);
 
            InvoicedQuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineView>("72b09274-50dc-40d2-99e6-2fea41614d53","","",true, this);
 
            Discount1 = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineView>("6b140cdc-296e-4b71-8971-db2ec1e72f27","","",true, this);
 
            CascadeDiscount1 = RPSControlFactory.CreateRPSCheckBox<OrderLineView>("4d73d86f-0d2a-49a4-8abb-624a62d3a843","","",true, this);
 
            Discount2 = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineView>("0a03c59e-c72f-4466-b2e9-691523f9e836","","",true, this);
 
            CascadeDiscount2 = RPSControlFactory.CreateRPSCheckBox<OrderLineView>("fb911de8-6daa-42c1-93df-1a3b4d7712eb","","",true, this);
 
            Discount3 = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineView>("c5cf08d4-6346-425e-95bd-0b3c6aec2d2a","","",true, this);
 
            CascadeDiscount3 = RPSControlFactory.CreateRPSCheckBox<OrderLineView>("be02432c-adb2-4cbb-8569-0e0bca9dbd9f","","",true, this);
 
            Discount4 = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineView>("d29a0fb0-08a3-480f-b36f-96360544b583","","",true, this);
 
            CascadeDiscount4 = RPSControlFactory.CreateRPSCheckBox<OrderLineView>("972e04fb-2b0d-4d6c-a7ed-99bbab0517c0","","",true, this);
 
            Discount5 = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineView>("a314b689-065b-4e49-8c39-46552b57391f","","",true, this);
 
            CascadeDiscount5 = RPSControlFactory.CreateRPSCheckBox<OrderLineView>("6e26b000-2917-48ba-9ca9-2e5271d34c8a","","",true, this);
 
            AmountDiscount = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineView>("eff64866-096d-4106-a752-3d3041548f1a","","",true, this);
 
            PositionAmountDiscount = RPSControlFactory.CreateRPSEnumComboBox<OrderLineView>("a61b1eb8-d494-4fae-929d-9fd56a15456f","","",true, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<OrderLineView>("191d9b6e-da67-45de-a2d0-954ae1be5300","","",true, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<OrderLineView>("e7f66180-741e-458f-929b-9b5e4466060c","","",true, this);
 
            IDSiteTransfer = RPSControlFactory.CreateRPSComboBox<OrderLineView>("15250aea-34bd-43fb-a322-b456f891e79c","","",false, this);
 
            IDWarehouseTransfer = RPSControlFactory.CreateRPSComboBox<OrderLineView>("9f8b2cf4-2568-4d58-9e3c-fc4914c49414","","",false, this);
 
            IDVAT = RPSControlFactory.CreateRPSComboBox<OrderLineView>("8145023d-22e4-4a6f-9838-7ac02954a368","","",true, this);
 
            PercentVAT = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineView>("36ea3733-8ac4-4d90-8af0-832aa81323db","","",true, this);
 
            IDVATSurcharge = RPSControlFactory.CreateRPSComboBox<OrderLineView>("4982f901-b0fc-4a99-bbbf-113903901f18","","",false, this);
 
            PercentSurcharge = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineView>("9f103fc6-34e8-4942-9b12-56cc7fdbb8b3","","",true, this);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<OrderLineView>("2a9b64a4-b8be-4bef-9107-daaf8e4e64ea","","",true, this);
 
            IDAccount = RPSControlFactory.CreateRPSComboBox<OrderLineView>("d53a5dc8-7e20-4129-857a-1b3ce176e32a","","",false, this);
 
            InvestementExpense = RPSControlFactory.CreateRPSEnumComboBox<OrderLineView>("90d471fd-29c5-4a6b-b672-4d4326819072","","",true, this);
 
            IDReturnCause = RPSControlFactory.CreateRPSComboBox<OrderLineView>("33371e62-f8a3-4f18-bfe5-2e88eedc9caa","","",false, this);
 
            IDOrderLineKit = RPSControlFactory.CreateRPSComboBox<OrderLineView>("6af1c8d4-24fd-4d08-a6df-a698972af6c9","","",false, this);
 
            CostPercentage = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineView>("9d8ade29-ac15-4f85-81ab-00aca28245ed","","",false, this);
 
            NumProm = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineView>("c6f67bbe-86dd-4f12-8e56-5e870d33b669","","",true, this);
 
            Rappel = RPSControlFactory.CreateRPSCheckBox<OrderLineView>("3e88d9bf-3e3a-4f2e-b0d6-2d625c3370bc","","",true, this);
 
            IDArticleStructure = RPSControlFactory.CreateRPSComboBox<OrderLineView>("d51c6cab-34ea-4e35-bd6e-d52714763ca4","","",false, this);
 
            ExternalTask = RPSControlFactory.CreateRPSCheckBox<OrderLineView>("50ceb332-a20b-4e5f-930c-d5ea23112dc9","","",true, this);
 
            ExternalMaterialsDelivered = RPSControlFactory.CreateRPSCheckBox<OrderLineView>("6b5365e0-4634-4ea1-bc6a-f3acd3ea280a","","",true, this);
 
            InternalCode = RPSControlFactory.CreateRPSTextBox<OrderLineView>("0dd56ed7-17e1-40c3-af34-fa1f6048b344","","",false, this);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<OrderLineView>("c164d505-27d9-4b12-a5e6-c5311e527547","","",false, this);
 
            IDProTask = RPSControlFactory.CreateRPSComboBox<OrderLineView>("25118f93-a655-4f4e-839b-8d2507bfc912","","",false, this);
 
            IDProMaterial = RPSControlFactory.CreateRPSComboBox<OrderLineView>("1063ee80-8ada-4d8d-8902-9c2b14f96103","","",false, this);
 
            IDManufacturingOrder = RPSControlFactory.CreateRPSComboBox<OrderLineView>("2c3216f5-f6ac-421d-8e21-7e9b509c74d9","","",false, this);
 
            IDMOTask = RPSControlFactory.CreateRPSComboBox<OrderLineView>("efe35703-aa15-472a-a3af-efaf4195e9c3","","",false, this);
 
            IDMOMaterial = RPSControlFactory.CreateRPSComboBox<OrderLineView>("d21f99a8-b085-4321-a52e-69c77757066f","","",false, this);
 
            StructureQuantity = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineView>("0a83df61-7459-47fd-a0bf-0bc054229a70","","",false, this);
 
            IDMaintenanceOrder = RPSControlFactory.CreateRPSComboBox<OrderLineView>("ef50f830-7415-4af4-bda5-de99f1f0904a","","",false, this);
 
            IDOrderMaterialPrevision = RPSControlFactory.CreateRPSComboBox<OrderLineView>("622d2f8b-cb57-4a54-b59b-2824c53e6bef","","",false, this);
 
            CodSupplierRequestQuotation = RPSControlFactory.CreateRPSTextBox<OrderLineView>("f6f3fb9c-7b6b-4f9a-a18a-44c55cb33691","","",false, this);
 
            OrdenationSupplierRequestQuotationLine = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineView>("8707bc59-8cf9-4715-89be-61fc74352cd0","","",false, this);
 
            UIIDOrderSL = RPSControlFactory.CreateRPSComboBox<OrderLineView>("6354ed5b-dfb0-45db-a54f-1581bd8599f9","","",false, this);
 
            IDOrderLineSales = RPSControlFactory.CreateRPSComboBox<OrderLineView>("1464bbb3-20da-4755-a01d-ec284b5d5c06","","",false, this);
 
            IDMaintenanceComponent = RPSControlFactory.CreateRPSComboBox<OrderLineView>("7c64c6d7-708d-44ba-be33-420247dee1e8","","",false, this);
 
            SerialNumber = RPSControlFactory.CreateRPSTextBox<OrderLineView>("b9c41585-c4af-40f9-a61f-f3cbefc05fa2","","",false, this);
 
            IDArticleVersion = RPSControlFactory.CreateRPSComboBox<OrderLineView>("8f703b7d-cd71-41b1-91df-11b7230ea5a9","","",false, this);
 
            IDFrameworkContract = RPSControlFactory.CreateRPSComboBox<OrderLineView>("9be572c0-1612-4795-8b16-f1782335271b","","",false, this);
 
            FrameworkContractLineNumber = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineView>("cac569f1-98fb-4585-9e1b-2070fbae5e43","","",false, this);
 
            IDImportTariffType = RPSControlFactory.CreateRPSComboBox<OrderLineView>("8b35964f-c1ed-4e1e-b9fc-961090341c4a","","",false, this);
 
            NetMass = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineView>("48170a98-3198-4031-a6e7-3f334ba62a19","","",false, this);
 
            PriceBase = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineView>("88a6f641-fde2-4313-8be5-07bbb58ed432","","",true, this);
 
            UIconditionPrice = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineView>("f03dfda1-439c-42f1-9c0f-8590380a9130","","",false, this);
 
            OrderLineGetDimensionCommandButton = RPSControlFactory.CreateRPSButton<OrderLineView>( "c39b086d-df3a-4205-ab13-78bd2d7ef4d5","","",this);
 
            UpdateTechnicalDescriptionCommand = RPSControlFactory.CreateRPSButton<OrderLineView>( "0502a84b-ba0f-4537-8e7a-c3f081ec3432","","",this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<OrderLineView>("793bb5b2-78b3-45e9-9aff-0a20b8422d7c","","",false, this);
 
            Matchcode = RPSControlFactory.CreateRPSTextBox<OrderLineView>("a70f785a-fdf6-4b71-8054-d1da7c9e92f8","","",false, this);
 
            DeliveryDate = RPSControlFactory.CreateRPSTextBox<OrderLineView>("837e16e1-01b0-4e03-892f-4fda8b1bcea6","","",false, this);
 
            IsDelivered = RPSControlFactory.CreateRPSCheckBox<OrderLineView>("08c88038-bed6-409b-966b-f6da9c9e3de6","","",true, this);
 
            ArticleAlternativeChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<OrderLineView,ArticleAlternativeChildDialogView>("7b0bdab5-71f0-480f-b6f7-0a828e93a882","","", this,Screen.ArticleAlternativeChildDialogView);
 
            CopyLineCommandButton = RPSControlFactory.CreateRPSButton<OrderLineView>( "cc5468dd-6046-4603-86b9-2edef5caa648","","",this);
 
            ImputationMaterialNavigationCommandButton = RPSControlFactory.CreateRPSButton<OrderLineView>( "6150ed3a-198f-436a-9eb6-8aae7267b86a","","",this);
 
            RelatedFWCManagementChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<OrderLineView,RelatedFWCManagementChildDialogView>("8d784a4a-f717-418d-8d08-8a4ce0cba371","","", this,Screen.RelatedFWCManagementChildDialogView);
 
            AnalyticChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<OrderLineView,AnalyticChildDialogView>("e1b55304-3551-4dfc-8beb-803f717b2838","","", this,Screen.AnalyticChildDialogView);
 
            CollectionInit params_OrderLineTaxs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="10f2f109-2223-40c3-8082-7cf26011b634",CSSSelectorGrid="",XPathGrid=""};
            OrderLineTaxs = RPSControlFactory.RPSCreateCollectionWithGrid<OrderLineTaxsCollectionEditor<OrderLineView,OrderLineAnalyticView>,OrderLineView,OrderLineAnalyticView>( params_OrderLineTaxs,this,Screen.OrderLineAnalyticView);
 
            CollectionInit params_OrderLineConditions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d0b22952-5827-4187-b031-4e8a8163af42",CSSSelectorGrid="",XPathGrid=""};
            OrderLineConditions = RPSControlFactory.RPSCreateCollectionWithGrid<OrderLineConditionsCollectionEditor<OrderLineView,OrderLineAnalyticView>,OrderLineView,OrderLineAnalyticView>( params_OrderLineConditions,this,Screen.OrderLineAnalyticView);
 
            CollectionInit params_OrderLineAnalytics = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6dd6e282-20ef-4a58-a392-e33388918edd",CSSSelectorGrid="",XPathGrid=""};
            OrderLineAnalytics = RPSControlFactory.RPSCreateCollectionWithGrid<OrderLineAnalyticsCollectionEditor<OrderLineView,OrderLineAnalyticView>,OrderLineView,OrderLineAnalyticView>( params_OrderLineAnalytics,this,Screen.OrderLineAnalyticView);
 
            GeneralDataSection = RPSControlFactory.CreateRPSSection<OrderLineView>( "","ul li[rpsid='50f5ef05-089c-491c-8736-b029f6897c38']","",this);
 
            TaxSection = RPSControlFactory.CreateRPSSection<OrderLineView>( "","ul li[rpsid='27b93a67-60e2-4eb0-a766-4da06ee2a7b2']","",this);
 
            SpecialConditionsSection = RPSControlFactory.CreateRPSSection<OrderLineView>( "","ul li[rpsid='5b9b8ab5-b6dc-4464-9941-fbcb1d5c4c06']","",this);
 
            AnalyticSection = RPSControlFactory.CreateRPSSection<OrderLineView>( "","ul li[rpsid='a43a64c7-df49-476f-a253-a41d1124ceaa']","",this);
 
            CommentsSection = RPSControlFactory.CreateRPSSection<OrderLineView>( "","ul li[rpsid='b637b4bd-588d-4d29-887c-7f4be629532c']","",this);
 
            DPS = RPSControlFactory.CreateRPSSection<OrderLineView>( "","ul li[rpsid='ea174a97-9442-4da0-bce0-0d94ba7d1a6d']","",this);
 

        }
        public IRPSButton<OrderLineView> DeleteButton { get; set; } 
        public IRPSButton<OrderLineView,OrderEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<OrderLineView,OrderEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<OrderLineView,OrderEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<OrderLineView> IDArticle { get; set; } 
        public IRPSComboBox<OrderLineView> ReferenceSupplier { get; set; } 
        public IRPSTextBox<OrderLineView> Quantity { get; set; } 
        public IRPSTextBox<OrderLineView> Price { get; set; } 
        public IRPSTextBox<OrderLineView> Amount { get; set; } 
        public IRPSCheckbox<OrderLineView> VAT { get; set; } 
        public IRPSTextBox<OrderLineView> AmountWithVAT { get; set; } 
        public IRPSTextBox<OrderLineView> Description { get; set; } 
        public IRPSComboBox<OrderLineView> IDUnitQuantity { get; set; } 
        public IRPSTextBox<OrderLineView> ConversionFactorQuantity { get; set; } 
        public IRPSTextBox<OrderLineView> QuantitySecondUnit { get; set; } 
        public IRPSTextBox<OrderLineView> Dimension1 { get; set; } 
        public IRPSTextBox<OrderLineView> Dimension2 { get; set; } 
        public IRPSTextBox<OrderLineView> Dimension3 { get; set; } 
        public IRPSTextBox<OrderLineView> Ordenation { get; set; } 
        public IRPSComboBox<OrderLineView> IDUnitPrice { get; set; } 
        public IRPSTextBox<OrderLineView> ConversionFactorPrice { get; set; } 
        public IRPSTextBox<OrderLineView> ReceptionDemandDate { get; set; } 
        public IRPSTextBox<OrderLineView> ReceptionDate { get; set; } 
        public IRPSComboBox<OrderLineView> IDEmployee { get; set; } 
        public IRPSCheckbox<OrderLineView> Received { get; set; } 
        public IRPSCheckbox<OrderLineView> PendingReceive { get; set; } 
        public IRPSTextBox<OrderLineView> ReceivedQuantity { get; set; } 
        public IRPSTextBox<OrderLineView> ReceivedQuantitySecondUnit { get; set; } 
        public IRPSCheckbox<OrderLineView> Invoice { get; set; } 
        public IRPSCheckbox<OrderLineView> Invoiced { get; set; } 
        public IRPSTextBox<OrderLineView> InvoicedQuantity { get; set; } 
        public IRPSTextBox<OrderLineView> InvoicedQuantitySecondUnit { get; set; } 
        public IRPSTextBox<OrderLineView> Discount1 { get; set; } 
        public IRPSCheckbox<OrderLineView> CascadeDiscount1 { get; set; } 
        public IRPSTextBox<OrderLineView> Discount2 { get; set; } 
        public IRPSCheckbox<OrderLineView> CascadeDiscount2 { get; set; } 
        public IRPSTextBox<OrderLineView> Discount3 { get; set; } 
        public IRPSCheckbox<OrderLineView> CascadeDiscount3 { get; set; } 
        public IRPSTextBox<OrderLineView> Discount4 { get; set; } 
        public IRPSCheckbox<OrderLineView> CascadeDiscount4 { get; set; } 
        public IRPSTextBox<OrderLineView> Discount5 { get; set; } 
        public IRPSCheckbox<OrderLineView> CascadeDiscount5 { get; set; } 
        public IRPSTextBox<OrderLineView> AmountDiscount { get; set; } 
        public IRPSComboBox<OrderLineView> PositionAmountDiscount { get; set; } 
        public IRPSComboBox<OrderLineView> IDSite { get; set; } 
        public IRPSComboBox<OrderLineView> IDWarehouse { get; set; } 
        public IRPSComboBox<OrderLineView> IDSiteTransfer { get; set; } 
        public IRPSComboBox<OrderLineView> IDWarehouseTransfer { get; set; } 
        public IRPSComboBox<OrderLineView> IDVAT { get; set; } 
        public IRPSTextBox<OrderLineView> PercentVAT { get; set; } 
        public IRPSComboBox<OrderLineView> IDVATSurcharge { get; set; } 
        public IRPSTextBox<OrderLineView> PercentSurcharge { get; set; } 
        public IRPSComboBox<OrderLineView> IDDeliveryNoteType { get; set; } 
        public IRPSComboBox<OrderLineView> IDAccount { get; set; } 
        public IRPSComboBox<OrderLineView> InvestementExpense { get; set; } 
        public IRPSComboBox<OrderLineView> IDReturnCause { get; set; } 
        public IRPSComboBox<OrderLineView> IDOrderLineKit { get; set; } 
        public IRPSTextBox<OrderLineView> CostPercentage { get; set; } 
        public IRPSTextBox<OrderLineView> NumProm { get; set; } 
        public IRPSCheckbox<OrderLineView> Rappel { get; set; } 
        public IRPSComboBox<OrderLineView> IDArticleStructure { get; set; } 
        public IRPSCheckbox<OrderLineView> ExternalTask { get; set; } 
        public IRPSCheckbox<OrderLineView> ExternalMaterialsDelivered { get; set; } 
        public IRPSTextBox<OrderLineView> InternalCode { get; set; } 
        public IRPSComboBox<OrderLineView> IDProject { get; set; } 
        public IRPSComboBox<OrderLineView> IDProTask { get; set; } 
        public IRPSComboBox<OrderLineView> IDProMaterial { get; set; } 
        public IRPSComboBox<OrderLineView> IDManufacturingOrder { get; set; } 
        public IRPSComboBox<OrderLineView> IDMOTask { get; set; } 
        public IRPSComboBox<OrderLineView> IDMOMaterial { get; set; } 
        public IRPSTextBox<OrderLineView> StructureQuantity { get; set; } 
        public IRPSComboBox<OrderLineView> IDMaintenanceOrder { get; set; } 
        public IRPSComboBox<OrderLineView> IDOrderMaterialPrevision { get; set; } 
        public IRPSTextBox<OrderLineView> CodSupplierRequestQuotation { get; set; } 
        public IRPSTextBox<OrderLineView> OrdenationSupplierRequestQuotationLine { get; set; } 
        public IRPSComboBox<OrderLineView> UIIDOrderSL { get; set; } 
        public IRPSComboBox<OrderLineView> IDOrderLineSales { get; set; } 
        public IRPSComboBox<OrderLineView> IDMaintenanceComponent { get; set; } 
        public IRPSTextBox<OrderLineView> SerialNumber { get; set; } 
        public IRPSComboBox<OrderLineView> IDArticleVersion { get; set; } 
        public IRPSComboBox<OrderLineView> IDFrameworkContract { get; set; } 
        public IRPSTextBox<OrderLineView> FrameworkContractLineNumber { get; set; } 
        public IRPSComboBox<OrderLineView> IDImportTariffType { get; set; } 
        public IRPSTextBox<OrderLineView> NetMass { get; set; } 
        public IRPSTextBox<OrderLineView> PriceBase { get; set; } 
        public IRPSTextBox<OrderLineView> UIconditionPrice { get; set; } 
        public IRPSButton<OrderLineView> OrderLineGetDimensionCommandButton { get; set; } 
        public IRPSButton<OrderLineView> UpdateTechnicalDescriptionCommand { get; set; } 
        public IRPSTextBox<OrderLineView> Comment { get; set; } 
        public IRPSTextBox<OrderLineView> Matchcode { get; set; } 
        public IRPSTextBox<OrderLineView> DeliveryDate { get; set; } 
        public IRPSCheckbox<OrderLineView> IsDelivered { get; set; } 
        public IRPSButton<OrderLineView,ArticleAlternativeChildDialogView> ArticleAlternativeChildNavigationCommandButton { get; set; } 
        public IRPSButton<OrderLineView> CopyLineCommandButton { get; set; } 
        public IRPSButton<OrderLineView> ImputationMaterialNavigationCommandButton { get; set; } 
        public IRPSButton<OrderLineView,RelatedFWCManagementChildDialogView> RelatedFWCManagementChildNavigationCommandButton { get; set; } 
        public IRPSButton<OrderLineView,AnalyticChildDialogView> AnalyticChildNavigationCommandButton { get; set; } 
        public OrderLineTaxsCollectionEditor<OrderLineView,OrderLineAnalyticView> OrderLineTaxs { get; set; } 
        public OrderLineConditionsCollectionEditor<OrderLineView,OrderLineAnalyticView> OrderLineConditions { get; set; } 
        public OrderLineAnalyticsCollectionEditor<OrderLineView,OrderLineAnalyticView> OrderLineAnalytics { get; set; } 
        public IRPSSection<OrderLineView> GeneralDataSection { get; set; } 
        public IRPSSection<OrderLineView> TaxSection { get; set; } 
        public IRPSSection<OrderLineView> SpecialConditionsSection { get; set; } 
        public IRPSSection<OrderLineView> AnalyticSection { get; set; } 
        public IRPSSection<OrderLineView> CommentsSection { get; set; } 
        public IRPSSection<OrderLineView> DPS { get; set; } 
        public Order Screen { get; set; }
        public OrderLineView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class OrderLineTaxsCollectionEditor<OrderLineView,OrderLineAnalyticView>:RPSCollectionEditor<OrderLineView,OrderLineAnalyticView> where OrderLineView : class, IView where OrderLineAnalyticView : class, IView
    {
        public  OrderLineTaxsGridView<OrderLineView,OrderLineAnalyticView> GridView {get;set;}
    }
    public partial class OrderLineTaxsGridView <OrderLineView,OrderLineAnalyticView> :  RPSGridView<OrderLineView,OrderLineAnalyticView> where OrderLineView : class, IView where OrderLineAnalyticView : class, IView
    {
        public OrderLineTaxsGridView(OrderLineView currentView,OrderLineAnalyticView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDTaxValue = RPSControlFactory.CreateRPSGridComboBox<OrderLineView>("","#10f2f109-2223-40c3-8082-7cf26011b634 .ag-row[role='row']@ROWINDEX [col-id='cIDTaxValue']","",true, this.CurrentView);
 
            ApplicationType = RPSControlFactory.CreateRPSGridEnumComboBox<OrderLineView>("","#10f2f109-2223-40c3-8082-7cf26011b634 .ag-row[role='row']@ROWINDEX [col-id='cApplicationType']","",true, this.CurrentView);
 
            BaseType = RPSControlFactory.CreateRPSGridEnumComboBox<OrderLineView>("","#10f2f109-2223-40c3-8082-7cf26011b634 .ag-row[role='row']@ROWINDEX [col-id='cBaseType']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<OrderLineView>("","#10f2f109-2223-40c3-8082-7cf26011b634 .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            Value = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderLineView>("","#10f2f109-2223-40c3-8082-7cf26011b634 .ag-row[role='row']@ROWINDEX [col-id='cValue']","",true, this.CurrentView);
 
            VAT = RPSControlFactory.CreateRPSGridCheckBox<OrderLineView>("","#10f2f109-2223-40c3-8082-7cf26011b634 .ag-row[role='row']@ROWINDEX [col-id='cVAT']","",true, this.CurrentView);
 
            PriceIncluded = RPSControlFactory.CreateRPSGridCheckBox<OrderLineView>("","#10f2f109-2223-40c3-8082-7cf26011b634 .ag-row[role='row']@ROWINDEX [col-id='cPriceIncluded']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<OrderLineView> IDTaxValue { get; set; } 
        public IRPSGridComboBox<OrderLineView> ApplicationType { get; set; } 
        public IRPSGridComboBox<OrderLineView> BaseType { get; set; } 
        public IRPSGridComboBox<OrderLineView> Type { get; set; } 
        public IRPSGridTextBox<OrderLineView> Value { get; set; } 
        public IRPSGridCheckbox<OrderLineView> VAT { get; set; } 
        public IRPSGridCheckbox<OrderLineView> PriceIncluded { get; set; } 
                     
    }
 
        public partial class OrderLineConditionsCollectionEditor<OrderLineView,OrderLineAnalyticView>:RPSCollectionEditor<OrderLineView,OrderLineAnalyticView> where OrderLineView : class, IView where OrderLineAnalyticView : class, IView
    {
        public  OrderLineConditionsGridView<OrderLineView,OrderLineAnalyticView> GridView {get;set;}
    }
    public partial class OrderLineConditionsGridView <OrderLineView,OrderLineAnalyticView> :  RPSGridView<OrderLineView,OrderLineAnalyticView> where OrderLineView : class, IView where OrderLineAnalyticView : class, IView
    {
        public OrderLineConditionsGridView(OrderLineView currentView,OrderLineAnalyticView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<OrderLineView>("","#d0b22952-5827-4187-b031-4e8a8163af42 .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            ConditionValueOriginal = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderLineView>("","#d0b22952-5827-4187-b031-4e8a8163af42 .ag-row[role='row']@ROWINDEX [col-id='cConditionValueOriginal']","",true, this.CurrentView);
 
            ConditionValue = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderLineView>("","#d0b22952-5827-4187-b031-4e8a8163af42 .ag-row[role='row']@ROWINDEX [col-id='cConditionValue']","",true, this.CurrentView);
 
            Base = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderLineView>("","#d0b22952-5827-4187-b031-4e8a8163af42 .ag-row[role='row']@ROWINDEX [col-id='cBase']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderLineView>("","#d0b22952-5827-4187-b031-4e8a8163af42 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            ConditionType = RPSControlFactory.CreateRPSGridEnumComboBox<OrderLineView>("","#d0b22952-5827-4187-b031-4e8a8163af42 .ag-row[role='row']@ROWINDEX [col-id='cConditionType']","",true, this.CurrentView);
 
            BaseApply = RPSControlFactory.CreateRPSGridEnumComboBox<OrderLineView>("","#d0b22952-5827-4187-b031-4e8a8163af42 .ag-row[role='row']@ROWINDEX [col-id='cBaseApply']","",true, this.CurrentView);
 
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<OrderLineView>("","#d0b22952-5827-4187-b031-4e8a8163af42 .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",true, this.CurrentView);
 
            DateTo = RPSControlFactory.CreateRPSGridTextBox<OrderLineView>("","#d0b22952-5827-4187-b031-4e8a8163af42 .ag-row[role='row']@ROWINDEX [col-id='cDateTo']","",true, this.CurrentView);
 
            AffectsPrice = RPSControlFactory.CreateRPSGridCheckBox<OrderLineView>("","#d0b22952-5827-4187-b031-4e8a8163af42 .ag-row[role='row']@ROWINDEX [col-id='cAffectsPrice']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<OrderLineView> Type { get; set; } 
        public IRPSGridTextBox<OrderLineView> ConditionValueOriginal { get; set; } 
        public IRPSGridTextBox<OrderLineView> ConditionValue { get; set; } 
        public IRPSGridTextBox<OrderLineView> Base { get; set; } 
        public IRPSGridTextBox<OrderLineView> Amount { get; set; } 
        public IRPSGridComboBox<OrderLineView> ConditionType { get; set; } 
        public IRPSGridComboBox<OrderLineView> BaseApply { get; set; } 
        public IRPSGridTextBox<OrderLineView> DateFrom { get; set; } 
        public IRPSGridTextBox<OrderLineView> DateTo { get; set; } 
        public IRPSGridCheckbox<OrderLineView> AffectsPrice { get; set; } 
                     
    }
 
        public partial class OrderLineAnalyticsCollectionEditor<OrderLineView,OrderLineAnalyticView>:RPSCollectionEditor<OrderLineView,OrderLineAnalyticView> where OrderLineView : class, IView where OrderLineAnalyticView : class, IView
    {
        public  OrderLineAnalyticsGridView<OrderLineView,OrderLineAnalyticView> GridView {get;set;}
    }
    public partial class OrderLineAnalyticsGridView <OrderLineView,OrderLineAnalyticView> :  RPSGridView<OrderLineView,OrderLineAnalyticView> where OrderLineView : class, IView where OrderLineAnalyticView : class, IView
    {
        public OrderLineAnalyticsGridView(OrderLineView currentView,OrderLineAnalyticView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDDimension = RPSControlFactory.CreateRPSGridComboBox<OrderLineView>("","#6dd6e282-20ef-4a58-a392-e33388918edd .ag-row[role='row']@ROWINDEX [col-id='cIDDimension']","",true, this.CurrentView);
 
            IDDimValue = RPSControlFactory.CreateRPSGridComboBox<OrderLineView>("","#6dd6e282-20ef-4a58-a392-e33388918edd .ag-row[role='row']@ROWINDEX [col-id='cIDDimValue']","",true, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderLineView>("","#6dd6e282-20ef-4a58-a392-e33388918edd .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderLineView>("","#6dd6e282-20ef-4a58-a392-e33388918edd .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<OrderLineView> IDDimension { get; set; } 
        public IRPSGridComboBox<OrderLineView> IDDimValue { get; set; } 
        public IRPSGridTextBox<OrderLineView> Percentage { get; set; } 
        public IRPSGridTextBox<OrderLineView> Amount { get; set; } 
                     
    }
 
    }
  
            
    public partial class OrderLineTaxView : View
    {
        public OrderLineTaxView(Order screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<OrderLineTaxView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<OrderLineTaxView,OrderLineView>( this,Screen.OrderLineView);
 
            BackButton = RPSControlFactory.RPSBackButton<OrderLineTaxView,OrderLineView>( this,Screen.OrderLineView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<OrderLineTaxView,OrderLineView>( this,Screen.OrderLineView);
 
            IDTaxValue = RPSControlFactory.CreateRPSComboBox<OrderLineTaxView>("cbdce325-8def-4372-ab55-f69752a860ba","","",true, this);
 
            ApplicationType = RPSControlFactory.CreateRPSEnumComboBox<OrderLineTaxView>("a44fc54a-a1b7-4563-9dc3-00a98cbc5a1b","","",true, this);
 
            BaseType = RPSControlFactory.CreateRPSEnumComboBox<OrderLineTaxView>("3652db61-fa56-4a55-8444-880e137e2343","","",true, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<OrderLineTaxView>("f1df1f7c-90c9-41e3-b7e2-8032f21c84e0","","",true, this);
 
            Value = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineTaxView>("0431ed98-f8dd-4bd3-b6e4-0af542d7f26e","","",true, this);
 
            PriceIncluded = RPSControlFactory.CreateRPSCheckBox<OrderLineTaxView>("9d079884-92c2-46e8-a68d-b1a6b0e13f2c","","",true, this);
 
            VAT = RPSControlFactory.CreateRPSCheckBox<OrderLineTaxView>("4d414e0b-18be-472f-ae12-5fc144af0854","","",true, this);
 

        }
        public IRPSButton<OrderLineTaxView> DeleteButton { get; set; } 
        public IRPSButton<OrderLineTaxView,OrderLineView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<OrderLineTaxView,OrderLineView> BackButton { get; set; } 
        public IRPSAcceptButton<OrderLineTaxView,OrderLineView> AcceptButton { get; set; } 
        public IRPSComboBox<OrderLineTaxView> IDTaxValue { get; set; } 
        public IRPSComboBox<OrderLineTaxView> ApplicationType { get; set; } 
        public IRPSComboBox<OrderLineTaxView> BaseType { get; set; } 
        public IRPSComboBox<OrderLineTaxView> Type { get; set; } 
        public IRPSTextBox<OrderLineTaxView> Value { get; set; } 
        public IRPSCheckbox<OrderLineTaxView> PriceIncluded { get; set; } 
        public IRPSCheckbox<OrderLineTaxView> VAT { get; set; } 
        public Order Screen { get; set; }
        public OrderLineTaxView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OrderLineAnalyticView : View
    {
        public OrderLineAnalyticView(Order screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<OrderLineAnalyticView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<OrderLineAnalyticView,OrderLineView>( this,Screen.OrderLineView);
 
            BackButton = RPSControlFactory.RPSBackButton<OrderLineAnalyticView,OrderLineView>( this,Screen.OrderLineView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<OrderLineAnalyticView,OrderLineView>( this,Screen.OrderLineView);
 
            IDDimension = RPSControlFactory.CreateRPSComboBox<OrderLineAnalyticView>("ba37b2df-b132-41ba-b474-d3339cf02707","","",true, this);
 
            IDDimValue = RPSControlFactory.CreateRPSComboBox<OrderLineAnalyticView>("419e9afa-5c6a-4c85-bafb-ede5b260e8ea","","",true, this);
 
            Percentage = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineAnalyticView>("ec397012-3257-4dd2-81ad-7e1c56c6447a","","",true, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineAnalyticView>("9c9dbeda-b08d-4d7d-86ad-3827395731be","","",true, this);
 

        }
        public IRPSButton<OrderLineAnalyticView> DeleteButton { get; set; } 
        public IRPSButton<OrderLineAnalyticView,OrderLineView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<OrderLineAnalyticView,OrderLineView> BackButton { get; set; } 
        public IRPSAcceptButton<OrderLineAnalyticView,OrderLineView> AcceptButton { get; set; } 
        public IRPSComboBox<OrderLineAnalyticView> IDDimension { get; set; } 
        public IRPSComboBox<OrderLineAnalyticView> IDDimValue { get; set; } 
        public IRPSTextBox<OrderLineAnalyticView> Percentage { get; set; } 
        public IRPSTextBox<OrderLineAnalyticView> Amount { get; set; } 
        public Order Screen { get; set; }
        public OrderLineAnalyticView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OrderAdvanceView : View
    {
        public OrderAdvanceView(Order screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<OrderAdvanceView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<OrderAdvanceView,OrderEntityView>( this,Screen.OrderEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<OrderAdvanceView,OrderEntityView>( this,Screen.OrderEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<OrderAdvanceView,OrderEntityView>( this,Screen.OrderEntityView);
 
            NumAdvance = RPSControlFactory.CreateRPSFormattedTextBox<OrderAdvanceView>("65d6a35b-8136-418e-b4fb-cdc56d1b24e0","","",true, this);
 
            AdvanceDate = RPSControlFactory.CreateRPSTextBox<OrderAdvanceView>("52643774-2032-42d5-8ec3-eaa76f3d55e2","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<OrderAdvanceView>("4fb12afd-9065-4039-9295-d9173befdfda","","",false, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<OrderAdvanceView>("fda967fe-3043-434b-b904-cdc5586e3ce6","","",true, this);
 
            VAT = RPSControlFactory.CreateRPSCheckBox<OrderAdvanceView>("1b12e557-19e1-4305-9e6f-62865b9946ab","","",true, this);
 
            AmountRecalculated = RPSControlFactory.CreateRPSFormattedTextBox<OrderAdvanceView>("a378a00f-5baa-4a4e-bc30-a2410833b888","","",true, this);
 
            Invoice = RPSControlFactory.CreateRPSCheckBox<OrderAdvanceView>("316e5304-7c12-4f50-a09d-c957e137f157","","",true, this);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSComboBox<OrderAdvanceView>("6ad0c684-fa6d-4228-b401-92facd26ea79","","",false, this);
 
            Invoiced = RPSControlFactory.CreateRPSCheckBox<OrderAdvanceView>("8a0841d6-2030-4383-97dd-75e47541a053","","",true, this);
 
            IDVATType = RPSControlFactory.CreateRPSComboBox<OrderAdvanceView>("1bbeabb7-cf19-4a0f-b11e-69ed7dec80de","","",false, this);
 
            IDVAT = RPSControlFactory.CreateRPSComboBox<OrderAdvanceView>("41d46f67-812d-414d-a7a8-769a9430407d","","",false, this);
 
            PercentVAT = RPSControlFactory.CreateRPSFormattedTextBox<OrderAdvanceView>("a45a06cb-f7d8-483f-8ef9-97d0f3cac70e","","",true, this);
 
            PercentSurcharge = RPSControlFactory.CreateRPSFormattedTextBox<OrderAdvanceView>("a849b46f-374c-4ec2-9c92-53c9b95f9acd","","",true, this);
 
            TaxType = RPSControlFactory.CreateRPSEnumComboBox<OrderAdvanceView>("869eeb48-34c9-4346-88a5-a77b4383da77","","",true, this);
 
            IDTaxGroup = RPSControlFactory.CreateRPSComboBox<OrderAdvanceView>("8a7c8bd1-c211-4fe0-bb6a-37cb75fe9c92","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<OrderAdvanceView>("2edf0242-3309-45e7-bda2-58547357f5b6","","",false, this);
 
            AdvanceInvoiceCommandButton = RPSControlFactory.CreateRPSButton<OrderAdvanceView>( "eb359bc9-50f3-4d79-a248-adc34e3292bb","","",this);
 
            OrderAdvanceChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<OrderAdvanceView,OrderAdvanceChildDialogView>("3ac07dda-3a4d-45bf-9d26-7177e56d239f","","", this,Screen.OrderAdvanceChildDialogView);
 
            CollectionInit params_OrderAdvanceTaxs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1afebd7b-ffe2-4a63-a27d-2938e1d4d46c",CSSSelectorGrid="",XPathGrid=""};
            OrderAdvanceTaxs = RPSControlFactory.RPSCreateCollectionWithGrid<OrderAdvanceTaxsCollectionEditor<OrderAdvanceView,OrderAdvanceTaxView>,OrderAdvanceView,OrderAdvanceTaxView>( params_OrderAdvanceTaxs,this,Screen.OrderAdvanceTaxView);
 
            GeneralDataSection = RPSControlFactory.CreateRPSSection<OrderAdvanceView>( "","ul li[rpsid='f4d708de-2786-4011-8acb-2c404dd00f7f']","",this);
 
            TaxSection = RPSControlFactory.CreateRPSSection<OrderAdvanceView>( "","ul li[rpsid='000bb975-e033-495e-8bc9-36b19eefb004']","",this);
 
            Comment1 = RPSControlFactory.CreateRPSSection<OrderAdvanceView>( "","ul li[rpsid='73342753-a035-4a8f-9415-08fef4d34889']","",this);
 

        }
        public IRPSButton<OrderAdvanceView> DeleteButton { get; set; } 
        public IRPSButton<OrderAdvanceView,OrderEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<OrderAdvanceView,OrderEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<OrderAdvanceView,OrderEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<OrderAdvanceView> NumAdvance { get; set; } 
        public IRPSTextBox<OrderAdvanceView> AdvanceDate { get; set; } 
        public IRPSTextBox<OrderAdvanceView> Description { get; set; } 
        public IRPSTextBox<OrderAdvanceView> Amount { get; set; } 
        public IRPSCheckbox<OrderAdvanceView> VAT { get; set; } 
        public IRPSTextBox<OrderAdvanceView> AmountRecalculated { get; set; } 
        public IRPSCheckbox<OrderAdvanceView> Invoice { get; set; } 
        public IRPSComboBox<OrderAdvanceView> IDPaymentMethod { get; set; } 
        public IRPSCheckbox<OrderAdvanceView> Invoiced { get; set; } 
        public IRPSComboBox<OrderAdvanceView> IDVATType { get; set; } 
        public IRPSComboBox<OrderAdvanceView> IDVAT { get; set; } 
        public IRPSTextBox<OrderAdvanceView> PercentVAT { get; set; } 
        public IRPSTextBox<OrderAdvanceView> PercentSurcharge { get; set; } 
        public IRPSComboBox<OrderAdvanceView> TaxType { get; set; } 
        public IRPSComboBox<OrderAdvanceView> IDTaxGroup { get; set; } 
        public IRPSTextBox<OrderAdvanceView> Comment { get; set; } 
        public IRPSButton<OrderAdvanceView> AdvanceInvoiceCommandButton { get; set; } 
        public IRPSButton<OrderAdvanceView,OrderAdvanceChildDialogView> OrderAdvanceChildNavigationCommandButton { get; set; } 
        public OrderAdvanceTaxsCollectionEditor<OrderAdvanceView,OrderAdvanceTaxView> OrderAdvanceTaxs { get; set; } 
        public IRPSSection<OrderAdvanceView> GeneralDataSection { get; set; } 
        public IRPSSection<OrderAdvanceView> TaxSection { get; set; } 
        public IRPSSection<OrderAdvanceView> Comment1 { get; set; } 
        public Order Screen { get; set; }
        public OrderAdvanceView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class OrderAdvanceTaxsCollectionEditor<OrderAdvanceView,OrderAdvanceTaxView>:RPSCollectionEditor<OrderAdvanceView,OrderAdvanceTaxView> where OrderAdvanceView : class, IView where OrderAdvanceTaxView : class, IView
    {
        public  OrderAdvanceTaxsGridView<OrderAdvanceView,OrderAdvanceTaxView> GridView {get;set;}
    }
    public partial class OrderAdvanceTaxsGridView <OrderAdvanceView,OrderAdvanceTaxView> :  RPSGridView<OrderAdvanceView,OrderAdvanceTaxView> where OrderAdvanceView : class, IView where OrderAdvanceTaxView : class, IView
    {
        public OrderAdvanceTaxsGridView(OrderAdvanceView currentView,OrderAdvanceTaxView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDTaxValue = RPSControlFactory.CreateRPSGridComboBox<OrderAdvanceView>("","#1afebd7b-ffe2-4a63-a27d-2938e1d4d46c .ag-row[role='row']@ROWINDEX [col-id='cIDTaxValue']","",true, this.CurrentView);
 
            ApplicationType = RPSControlFactory.CreateRPSGridEnumComboBox<OrderAdvanceView>("","#1afebd7b-ffe2-4a63-a27d-2938e1d4d46c .ag-row[role='row']@ROWINDEX [col-id='cApplicationType']","",true, this.CurrentView);
 
            BaseType = RPSControlFactory.CreateRPSGridEnumComboBox<OrderAdvanceView>("","#1afebd7b-ffe2-4a63-a27d-2938e1d4d46c .ag-row[role='row']@ROWINDEX [col-id='cBaseType']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<OrderAdvanceView>("","#1afebd7b-ffe2-4a63-a27d-2938e1d4d46c .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            Value = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderAdvanceView>("","#1afebd7b-ffe2-4a63-a27d-2938e1d4d46c .ag-row[role='row']@ROWINDEX [col-id='cValue']","",true, this.CurrentView);
 
            VAT = RPSControlFactory.CreateRPSGridCheckBox<OrderAdvanceView>("","#1afebd7b-ffe2-4a63-a27d-2938e1d4d46c .ag-row[role='row']@ROWINDEX [col-id='cVAT']","",true, this.CurrentView);
 
            PriceIncluded = RPSControlFactory.CreateRPSGridCheckBox<OrderAdvanceView>("","#1afebd7b-ffe2-4a63-a27d-2938e1d4d46c .ag-row[role='row']@ROWINDEX [col-id='cPriceIncluded']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<OrderAdvanceView> IDTaxValue { get; set; } 
        public IRPSGridComboBox<OrderAdvanceView> ApplicationType { get; set; } 
        public IRPSGridComboBox<OrderAdvanceView> BaseType { get; set; } 
        public IRPSGridComboBox<OrderAdvanceView> Type { get; set; } 
        public IRPSGridTextBox<OrderAdvanceView> Value { get; set; } 
        public IRPSGridCheckbox<OrderAdvanceView> VAT { get; set; } 
        public IRPSGridCheckbox<OrderAdvanceView> PriceIncluded { get; set; } 
                     
    }
 
    }
  
            
    public partial class OrderAdvanceTaxView : View
    {
        public OrderAdvanceTaxView(Order screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<OrderAdvanceTaxView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<OrderAdvanceTaxView,OrderAdvanceView>( this,Screen.OrderAdvanceView);
 
            BackButton = RPSControlFactory.RPSBackButton<OrderAdvanceTaxView,OrderAdvanceView>( this,Screen.OrderAdvanceView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<OrderAdvanceTaxView,OrderAdvanceView>( this,Screen.OrderAdvanceView);
 
            IDTaxValue = RPSControlFactory.CreateRPSComboBox<OrderAdvanceTaxView>("0f4d55a6-3e37-4d51-9d29-04c87311d803","","",true, this);
 
            ApplicationType = RPSControlFactory.CreateRPSEnumComboBox<OrderAdvanceTaxView>("7e479635-971b-41ae-b82b-0918c89ab2c8","","",true, this);
 
            BaseType = RPSControlFactory.CreateRPSEnumComboBox<OrderAdvanceTaxView>("4c2bc7c1-99b9-497c-b7bb-2ac5edc1fab3","","",true, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<OrderAdvanceTaxView>("6adf34c8-6d72-4d95-90c4-1a93402b614e","","",true, this);
 
            Value = RPSControlFactory.CreateRPSFormattedTextBox<OrderAdvanceTaxView>("c8201f88-2687-40df-a792-4d108b70d614","","",true, this);
 
            VAT = RPSControlFactory.CreateRPSCheckBox<OrderAdvanceTaxView>("403384d8-04be-43e7-b921-5970292da8ce","","",true, this);
 
            PriceIncluded = RPSControlFactory.CreateRPSCheckBox<OrderAdvanceTaxView>("b83d3c52-9a4a-4c64-b8fb-2d4804ca1465","","",true, this);
 

        }
        public IRPSButton<OrderAdvanceTaxView> DeleteButton { get; set; } 
        public IRPSButton<OrderAdvanceTaxView,OrderAdvanceView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<OrderAdvanceTaxView,OrderAdvanceView> BackButton { get; set; } 
        public IRPSAcceptButton<OrderAdvanceTaxView,OrderAdvanceView> AcceptButton { get; set; } 
        public IRPSComboBox<OrderAdvanceTaxView> IDTaxValue { get; set; } 
        public IRPSComboBox<OrderAdvanceTaxView> ApplicationType { get; set; } 
        public IRPSComboBox<OrderAdvanceTaxView> BaseType { get; set; } 
        public IRPSComboBox<OrderAdvanceTaxView> Type { get; set; } 
        public IRPSTextBox<OrderAdvanceTaxView> Value { get; set; } 
        public IRPSCheckbox<OrderAdvanceTaxView> VAT { get; set; } 
        public IRPSCheckbox<OrderAdvanceTaxView> PriceIncluded { get; set; } 
        public Order Screen { get; set; }
        public OrderAdvanceTaxView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OrderVariablePaymentView : View
    {
        public OrderVariablePaymentView(Order screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<OrderVariablePaymentView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<OrderVariablePaymentView,OrderLineView>( this,Screen.OrderLineView);
 
            BackButton = RPSControlFactory.RPSBackButton<OrderVariablePaymentView,OrderLineView>( this,Screen.OrderLineView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<OrderVariablePaymentView,OrderLineView>( this,Screen.OrderLineView);
 
            NumPayment = RPSControlFactory.CreateRPSFormattedTextBox<OrderVariablePaymentView>("c3b58898-b500-450b-8f4c-9a250868cded","","",true, this);
 
            DatePayment = RPSControlFactory.CreateRPSTextBox<OrderVariablePaymentView>("70ca3a47-f8b4-4809-aec8-9569b20f2584","","",false, this);
 
            DayPayment = RPSControlFactory.CreateRPSFormattedTextBox<OrderVariablePaymentView>("596a6e21-d0ba-44d9-a974-600d51ed4441","","",false, this);
 
            Percentage = RPSControlFactory.CreateRPSFormattedTextBox<OrderVariablePaymentView>("695925a5-0823-45e8-a3bc-e2c043d803ef","","",false, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<OrderVariablePaymentView>("11898f0f-5109-4d9b-a50e-928acf3f19f7","","",false, this);
 
            Rest = RPSControlFactory.CreateRPSCheckBox<OrderVariablePaymentView>("913fd119-7f1f-4ae0-9f39-3d57cad8e2bc","","",true, this);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSComboBox<OrderVariablePaymentView>("aca86d4c-2183-476a-954d-6a5b00de6f4e","","",false, this);
 

        }
        public IRPSButton<OrderVariablePaymentView> DeleteButton { get; set; } 
        public IRPSButton<OrderVariablePaymentView,OrderLineView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<OrderVariablePaymentView,OrderLineView> BackButton { get; set; } 
        public IRPSAcceptButton<OrderVariablePaymentView,OrderLineView> AcceptButton { get; set; } 
        public IRPSTextBox<OrderVariablePaymentView> NumPayment { get; set; } 
        public IRPSTextBox<OrderVariablePaymentView> DatePayment { get; set; } 
        public IRPSTextBox<OrderVariablePaymentView> DayPayment { get; set; } 
        public IRPSTextBox<OrderVariablePaymentView> Percentage { get; set; } 
        public IRPSTextBox<OrderVariablePaymentView> Amount { get; set; } 
        public IRPSCheckbox<OrderVariablePaymentView> Rest { get; set; } 
        public IRPSComboBox<OrderVariablePaymentView> IDPaymentMethod { get; set; } 
        public Order Screen { get; set; }
        public OrderVariablePaymentView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OrderChangesChildDialogView : View
    {
        public OrderChangesChildDialogView(Order screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ReceptionDate = RPSControlFactory.CreateRPSTextBox<OrderChangesChildDialogView>("6baf1aa1-c0b2-426e-bdd5-928c37e8d12a","","",false, this);
 
            ReceptionDemandDate = RPSControlFactory.CreateRPSTextBox<OrderChangesChildDialogView>("62b2190a-a611-4800-824b-eaf6d3391ab8","","",false, this);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<OrderChangesChildDialogView>("5c917e80-4031-4db6-a64e-b6a9e1d78bd5","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<OrderChangesChildDialogView>("a429b292-898b-4f5a-9aba-6463fc52a991","","",false, this);
 
            IDWareHouse = RPSControlFactory.CreateRPSComboBox<OrderChangesChildDialogView>("7c4617ff-a2b4-42f7-ae8d-f1f772778749","","",false, this);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<OrderChangesChildDialogView>("0685d01e-159d-487e-8f50-e5c913067bd0","","",false, this);
 

        }
        public IRPSTextBox<OrderChangesChildDialogView> ReceptionDate { get; set; } 
        public IRPSTextBox<OrderChangesChildDialogView> ReceptionDemandDate { get; set; } 
        public IRPSComboBox<OrderChangesChildDialogView> IDDeliveryNoteType { get; set; } 
        public IRPSComboBox<OrderChangesChildDialogView> IDSite { get; set; } 
        public IRPSComboBox<OrderChangesChildDialogView> IDWareHouse { get; set; } 
        public IRPSComboBox<OrderChangesChildDialogView> IDEmployee { get; set; } 
        public Order Screen { get; set; }
        public OrderChangesChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NewOrderChildDialogView : View
    {
        public NewOrderChildDialogView(Order screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewCodOrder = RPSControlFactory.CreateRPSTextBox<NewOrderChildDialogView>("0138355a-c513-4f95-a103-62c25c8f2c4c","","",false, this);
 
            NewIDSupplier = RPSControlFactory.CreateRPSComboBox<NewOrderChildDialogView>("817f81bc-2ff3-4987-8c00-ceea4b0635f9","","",false, this);
 
            NewOrderDate = RPSControlFactory.CreateRPSTextBox<NewOrderChildDialogView>("c8ca5be7-f654-440a-8091-d07a9a802d33","","",false, this);
 
            bRecalcHeader = RPSControlFactory.CreateRPSCheckBox<NewOrderChildDialogView>("934e211a-c1ac-498f-bf0a-904b36894f73","","",false, this);
 
            bRecalcLines = RPSControlFactory.CreateRPSCheckBox<NewOrderChildDialogView>("be9f95a6-8435-435d-ad0b-ce0b61db0ca1","","",false, this);
 
            CopyDocuments = RPSControlFactory.CreateRPSCheckBox<NewOrderChildDialogView>("d6ca8116-1f8f-403e-ae74-6b647f74597b","","",false, this);
 
            VariablePayment = RPSControlFactory.CreateRPSCheckBox<NewOrderChildDialogView>("483179da-6b95-439f-8d5c-e44d7c1f73a2","","",false, this);
 
            Advance = RPSControlFactory.CreateRPSCheckBox<NewOrderChildDialogView>("d4205256-68fc-408f-aea8-e04a8a381d10","","",false, this);
 

        }
        public IRPSTextBox<NewOrderChildDialogView> NewCodOrder { get; set; } 
        public IRPSComboBox<NewOrderChildDialogView> NewIDSupplier { get; set; } 
        public IRPSTextBox<NewOrderChildDialogView> NewOrderDate { get; set; } 
        public IRPSCheckbox<NewOrderChildDialogView> bRecalcHeader { get; set; } 
        public IRPSCheckbox<NewOrderChildDialogView> bRecalcLines { get; set; } 
        public IRPSCheckbox<NewOrderChildDialogView> CopyDocuments { get; set; } 
        public IRPSCheckbox<NewOrderChildDialogView> VariablePayment { get; set; } 
        public IRPSCheckbox<NewOrderChildDialogView> Advance { get; set; } 
        public Order Screen { get; set; }
        public NewOrderChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ArticleGenericChildDialogView : View
    {
        public ArticleGenericChildDialogView(Order screen) : base()
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
        public Order Screen { get; set; }
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
  
            
    public partial class ArticleAlternativeChildDialogView : View
    {
        public ArticleAlternativeChildDialogView(Order screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_ArticleAlternativePurchase = new CollectionInit(){IDDescriptor = "b3132412-ff76-49a7-b538-be20cc7d9732",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            ArticleAlternativePurchase = RPSControlFactory.RPSCreateCollection<ArticleAlternativeChildDialogView>( params_ArticleAlternativePurchase,this);
 

        }
        public IRPSCollectionEditor<ArticleAlternativeChildDialogView> ArticleAlternativePurchase { get; set; } 
        public Order Screen { get; set; }
        public ArticleAlternativeChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OrderPrintDialogView : View
    {
        public OrderPrintDialogView(Order screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIOptSupplier = RPSControlFactory.CreateRPSOption<OrderPrintDialogView>( "487d5fb8-853d-4fc3-987c-301a25177f28","","",this);
 
            UIOptSelected = RPSControlFactory.CreateRPSOption<OrderPrintDialogView>( "8b12961e-cb7c-4591-ac02-bbca26843961","","",this);
 
            UIPrintOptionsIDLanguage = RPSControlFactory.CreateRPSComboBox<OrderPrintDialogView>("bad798a5-0838-429c-937b-414d127fa987","","",false, this);
 
            UIPrintOptOrderDocuments = RPSControlFactory.CreateRPSCheckBox<OrderPrintDialogView>("ac3a5624-fb3e-431a-9416-3f8bfb65e596","","",false, this);
 
            UIOptAllDocuments = RPSControlFactory.CreateRPSOption<OrderPrintDialogView>( "56ce3147-861b-4c6c-8601-ecd1922963fb","","",this);
 
            UIOptByDocument = RPSControlFactory.CreateRPSOption<OrderPrintDialogView>( "ce43fb7b-03d8-4b22-96e4-17d70f95786b","","",this);
 
            UIPrintOptArticleDocuments = RPSControlFactory.CreateRPSCheckBox<OrderPrintDialogView>("0903140c-f426-4016-a4e0-d95d8ea2f0ee","","",false, this);
 
            UIOptAllDocuments1 = RPSControlFactory.CreateRPSOption<OrderPrintDialogView>( "1db0d2e9-d4b8-4d38-9a82-e5dcf65ffbd0","","",this);
 
            UIOptByDocument1 = RPSControlFactory.CreateRPSOption<OrderPrintDialogView>( "53eb332e-d657-46d5-b997-f8bdfb156040","","",this);
 
            UIDocumentsMaterial = RPSControlFactory.CreateRPSCheckBox<OrderPrintDialogView>("ffd3e359-0fc6-4b39-a8f1-ff25a27e2d96","","",false, this);
 
            UIOptAllDocuments2 = RPSControlFactory.CreateRPSOption<OrderPrintDialogView>( "0260bb4a-8dc4-4338-8025-5b201cc58fa2","","",this);
 
            UIOptByDocument2 = RPSControlFactory.CreateRPSOption<OrderPrintDialogView>( "011e3842-8689-436c-a2fe-ffc297a988e1","","",this);
 
            UIPrintSpecificReport = RPSControlFactory.CreateRPSCheckBox<OrderPrintDialogView>("23f50b0e-8b8c-48a2-bc74-cfc27bf5ac6e","","",false, this);
 
            UICodOrderReport = RPSControlFactory.CreateRPSComboBox<OrderPrintDialogView>("604969fe-5c2c-49d7-b576-bc510400f99d","","",false, this);
 
            bClaim = RPSControlFactory.CreateRPSCheckBox<OrderPrintDialogView>("031038ac-7a7b-45e8-81ad-bf26ff69d1ac","","",false, this);
 
            LaunchPrintedReportButton = RPSControlFactory.CreateRPSButton<OrderPrintDialogView>( "03d8fc03-48aa-4e81-b391-7bd5d14a6181","","",this);
 
            LaunchByEmailCommandButton = RPSControlFactory.CreateRPSButton<OrderPrintDialogView>( "1c293056-e62a-4f92-bdac-14b0f008fcd9","","",this);
 
            LaunchToCustomerEmailCommandButton = RPSControlFactory.CreateRPSButton<OrderPrintDialogView>( "a660442a-a6ef-4e4e-af7b-f986e5087fdd","","",this);
 

        }
        public IRPSOption<OrderPrintDialogView> UIOptSupplier { get; set; } 
        public IRPSOption<OrderPrintDialogView> UIOptSelected { get; set; } 
        public IRPSComboBox<OrderPrintDialogView> UIPrintOptionsIDLanguage { get; set; } 
        public IRPSCheckbox<OrderPrintDialogView> UIPrintOptOrderDocuments { get; set; } 
        public IRPSOption<OrderPrintDialogView> UIOptAllDocuments { get; set; } 
        public IRPSOption<OrderPrintDialogView> UIOptByDocument { get; set; } 
        public IRPSCheckbox<OrderPrintDialogView> UIPrintOptArticleDocuments { get; set; } 
        public IRPSOption<OrderPrintDialogView> UIOptAllDocuments1 { get; set; } 
        public IRPSOption<OrderPrintDialogView> UIOptByDocument1 { get; set; } 
        public IRPSCheckbox<OrderPrintDialogView> UIDocumentsMaterial { get; set; } 
        public IRPSOption<OrderPrintDialogView> UIOptAllDocuments2 { get; set; } 
        public IRPSOption<OrderPrintDialogView> UIOptByDocument2 { get; set; } 
        public IRPSCheckbox<OrderPrintDialogView> UIPrintSpecificReport { get; set; } 
        public IRPSComboBox<OrderPrintDialogView> UICodOrderReport { get; set; } 
        public IRPSCheckbox<OrderPrintDialogView> bClaim { get; set; } 
        public IRPSButton<OrderPrintDialogView> LaunchPrintedReportButton { get; set; } 
        public IRPSButton<OrderPrintDialogView> LaunchByEmailCommandButton { get; set; } 
        public IRPSButton<OrderPrintDialogView> LaunchToCustomerEmailCommandButton { get; set; } 
        public Order Screen { get; set; }
        public OrderPrintDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class GenerateDeliveryNoteChildDialogView : View
    {
        public GenerateDeliveryNoteChildDialogView(Order screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewDeliveryNote = RPSControlFactory.CreateRPSOption<GenerateDeliveryNoteChildDialogView>( "cb95cff7-09f3-49b0-8b49-155358b205bc","","",this);
 
            CodDeliveryNote = RPSControlFactory.CreateRPSTextBox<GenerateDeliveryNoteChildDialogView>("26c655f0-4235-45a9-bea2-b1bb1b026708","","",false, this);
 
            DeliveryNoteDate = RPSControlFactory.CreateRPSTextBox<GenerateDeliveryNoteChildDialogView>("efd29d2c-3188-4cc8-93e2-75c51e98383d","","",false, this);
 
            ExistDeliveryNote = RPSControlFactory.CreateRPSOption<GenerateDeliveryNoteChildDialogView>( "c22b4a5d-c279-40cd-8437-93563a356f93","","",this);
 
            IDDeliveryNote = RPSControlFactory.CreateRPSComboBox<GenerateDeliveryNoteChildDialogView>("b4aa8461-a742-40d4-94ed-0e7790984382","","",false, this);
 

        }
        public IRPSOption<GenerateDeliveryNoteChildDialogView> NewDeliveryNote { get; set; } 
        public IRPSTextBox<GenerateDeliveryNoteChildDialogView> CodDeliveryNote { get; set; } 
        public IRPSTextBox<GenerateDeliveryNoteChildDialogView> DeliveryNoteDate { get; set; } 
        public IRPSOption<GenerateDeliveryNoteChildDialogView> ExistDeliveryNote { get; set; } 
        public IRPSComboBox<GenerateDeliveryNoteChildDialogView> IDDeliveryNote { get; set; } 
        public Order Screen { get; set; }
        public GenerateDeliveryNoteChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ChangeOrderSupplierChildDialogView : View
    {
        public ChangeOrderSupplierChildDialogView(Order screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Supplier = RPSControlFactory.CreateRPSComboBox<ChangeOrderSupplierChildDialogView>("e15e7626-78e0-4d86-bbd8-843064576e80","","",false, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<ChangeOrderSupplierChildDialogView>("49dfb6fe-0a1b-4420-8851-0a14a51b2ace","","",false, this);
 
            NewSupplier = RPSControlFactory.CreateRPSComboBox<ChangeOrderSupplierChildDialogView>("1e10d422-37fc-4083-a340-53b19bd1a479","","",true, this);
 
            NewVATNumber = RPSControlFactory.CreateRPSTextBox<ChangeOrderSupplierChildDialogView>("f567f5c7-bd5d-4b31-87f0-1d580a2f9805","","",false, this);
 
            SupplierMiscellaneous1 = RPSControlFactory.CreateRPSComboBox<ChangeOrderSupplierChildDialogView>("49da3b7a-8b4c-40ca-9fff-fe196a55ba80","","",true, this);
 
            bChangeHeader = RPSControlFactory.CreateRPSCheckBox<ChangeOrderSupplierChildDialogView>("5ae89bfc-ffab-4015-90d9-f42ae0606043","","",false, this);
 

        }
        public IRPSComboBox<ChangeOrderSupplierChildDialogView> Supplier { get; set; } 
        public IRPSTextBox<ChangeOrderSupplierChildDialogView> VATNumber { get; set; } 
        public IRPSComboBox<ChangeOrderSupplierChildDialogView> NewSupplier { get; set; } 
        public IRPSTextBox<ChangeOrderSupplierChildDialogView> NewVATNumber { get; set; } 
        public IRPSComboBox<ChangeOrderSupplierChildDialogView> SupplierMiscellaneous1 { get; set; } 
        public IRPSCheckbox<ChangeOrderSupplierChildDialogView> bChangeHeader { get; set; } 
        public Order Screen { get; set; }
        public ChangeOrderSupplierChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OrderAdvanceChildDialogView : View
    {
        public OrderAdvanceChildDialogView(Order screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Invoice = RPSControlFactory.CreateRPSComboBox<OrderAdvanceChildDialogView>("445d9bd9-44d1-4975-9790-4842bc6526e2","","",false, this);
 
            CollectionInit params_GetInvoiceOrderAdvancedListPurchase = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f930e8bd-ff01-4719-bf28-41c9728a6de1",CSSSelectorGrid="",XPathGrid=""};
            GetInvoiceOrderAdvancedListPurchase = RPSControlFactory.RPSCreateCollectionWithGrid<GetInvoiceOrderAdvancedListPurchaseCollectionEditor<OrderAdvanceChildDialogView>,OrderAdvanceChildDialogView>( params_GetInvoiceOrderAdvancedListPurchase,this);
 

        }
        public IRPSComboBox<OrderAdvanceChildDialogView> Invoice { get; set; } 
        public GetInvoiceOrderAdvancedListPurchaseCollectionEditor<OrderAdvanceChildDialogView> GetInvoiceOrderAdvancedListPurchase { get; set; } 
        public Order Screen { get; set; }
        public OrderAdvanceChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetInvoiceOrderAdvancedListPurchaseCollectionEditor<OrderAdvanceChildDialogView>:RPSCollectionEditor<OrderAdvanceChildDialogView> where OrderAdvanceChildDialogView : class, IView
    {
        public  GetInvoiceOrderAdvancedListPurchaseGridView<OrderAdvanceChildDialogView> GridView {get;set;}
    }
    public partial class GetInvoiceOrderAdvancedListPurchaseGridView <OrderAdvanceChildDialogView> :  RPSGridView<OrderAdvanceChildDialogView> where OrderAdvanceChildDialogView : class, IView
    {
        public GetInvoiceOrderAdvancedListPurchaseGridView(OrderAdvanceChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodInvoice = RPSControlFactory.CreateRPSGridTextBox<OrderAdvanceChildDialogView>("","#f930e8bd-ff01-4719-bf28-41c9728a6de1 .ag-row[role='row']@ROWINDEX [col-id='cCodInvoice']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<OrderAdvanceChildDialogView>("","#f930e8bd-ff01-4719-bf28-41c9728a6de1 .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderAdvanceChildDialogView>("","#f930e8bd-ff01-4719-bf28-41c9728a6de1 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<OrderAdvanceChildDialogView> CodInvoice { get; set; } 
        public IRPSGridTextBox<OrderAdvanceChildDialogView> InvoiceDate { get; set; } 
        public IRPSGridTextBox<OrderAdvanceChildDialogView> Amount { get; set; } 
                     
    }
 
    }
  
            
    public partial class RelatedFWCManagementChildDialogView : View
    {
        public RelatedFWCManagementChildDialogView(Order screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_GetFrameworkContractDatas = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="60dc4230-5ee7-4fcc-9339-906e88b5a4d3",CSSSelectorGrid="",XPathGrid=""};
            GetFrameworkContractDatas = RPSControlFactory.RPSCreateCollectionWithGrid<GetFrameworkContractDatasCollectionEditor<RelatedFWCManagementChildDialogView>,RelatedFWCManagementChildDialogView>( params_GetFrameworkContractDatas,this);
 

        }
        public GetFrameworkContractDatasCollectionEditor<RelatedFWCManagementChildDialogView> GetFrameworkContractDatas { get; set; } 
        public Order Screen { get; set; }
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
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<RelatedFWCManagementChildDialogView>("","#60dc4230-5ee7-4fcc-9339-906e88b5a4d3 .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",false, this.CurrentView);
 
            DateTo = RPSControlFactory.CreateRPSGridTextBox<RelatedFWCManagementChildDialogView>("","#60dc4230-5ee7-4fcc-9339-906e88b5a4d3 .ag-row[role='row']@ROWINDEX [col-id='cDateTo']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<RelatedFWCManagementChildDialogView> DateFrom { get; set; } 
        public IRPSGridTextBox<RelatedFWCManagementChildDialogView> DateTo { get; set; } 
                     
    }
 
    }
  
            
    public partial class AutomaticMaterialInputationDialogView : View
    {
        public AutomaticMaterialInputationDialogView(Order screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            AddNewButton = RPSControlFactory.CreateRPSButton<AutomaticMaterialInputationDialogView>( "54a4fd61-93b9-44f5-b9d9-7829bd447ebd","","",this);
 
            GenerateCommandButton = RPSControlFactory.CreateRPSButton<AutomaticMaterialInputationDialogView>( "84547c2f-49f2-4faa-bf44-4f7195752300","","",this);
 
            CollectionInit params_MaterialImputations = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c3b1d973-a81a-4311-bbd1-41d8b06c16f7",CSSSelectorGrid="",XPathGrid=""};
            MaterialImputations = RPSControlFactory.RPSCreateCollectionWithGrid<MaterialImputationsCollectionEditor<AutomaticMaterialInputationDialogView>,AutomaticMaterialInputationDialogView>( params_MaterialImputations,this);
 

        }
        public IRPSButton<AutomaticMaterialInputationDialogView> AddNewButton { get; set; } 
        public IRPSButton<AutomaticMaterialInputationDialogView> GenerateCommandButton { get; set; } 
        public MaterialImputationsCollectionEditor<AutomaticMaterialInputationDialogView> MaterialImputations { get; set; } 
        public Order Screen { get; set; }
        public AutomaticMaterialInputationDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaterialImputationsCollectionEditor<AutomaticMaterialInputationDialogView>:RPSCollectionEditor<AutomaticMaterialInputationDialogView> where AutomaticMaterialInputationDialogView : class, IView
    {
        public  MaterialImputationsGridView<AutomaticMaterialInputationDialogView> GridView {get;set;}
    }
    public partial class MaterialImputationsGridView <AutomaticMaterialInputationDialogView> :  RPSGridView<AutomaticMaterialInputationDialogView> where AutomaticMaterialInputationDialogView : class, IView
    {
        public MaterialImputationsGridView(AutomaticMaterialInputationDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            RemoveCommand = RPSControlFactory.CreateRPSGridButton<AutomaticMaterialInputationDialogView>( "","#c3b1d973-a81a-4311-bbd1-41d8b06c16f7 .ag-row[role='row']@ROWINDEX [col-id='cRemoveCommand']","",this.CurrentView);
 
            IDProject = RPSControlFactory.CreateRPSGridComboBox<AutomaticMaterialInputationDialogView>("","#c3b1d973-a81a-4311-bbd1-41d8b06c16f7 .ag-row[role='row']@ROWINDEX [col-id='cIDProject']","",false, this.CurrentView);
 
            IDArticleMaterial = RPSControlFactory.CreateRPSGridComboBox<AutomaticMaterialInputationDialogView>("","#c3b1d973-a81a-4311-bbd1-41d8b06c16f7 .ag-row[role='row']@ROWINDEX [col-id='cIDArticleMaterial']","",false, this.CurrentView);
 
            ImputedQtty = RPSControlFactory.CreateRPSGridFormattedTextBox<AutomaticMaterialInputationDialogView>("","#c3b1d973-a81a-4311-bbd1-41d8b06c16f7 .ag-row[role='row']@ROWINDEX [col-id='cImputedQtty']","",false, this.CurrentView);
 
            CurrentQtty = RPSControlFactory.CreateRPSGridFormattedTextBox<AutomaticMaterialInputationDialogView>("","#c3b1d973-a81a-4311-bbd1-41d8b06c16f7 .ag-row[role='row']@ROWINDEX [col-id='cCurrentQtty']","",false, this.CurrentView);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSGridFormattedTextBox<AutomaticMaterialInputationDialogView>("","#c3b1d973-a81a-4311-bbd1-41d8b06c16f7 .ag-row[role='row']@ROWINDEX [col-id='cQuantitySecondUnit']","",false, this.CurrentView);
 
            IDSite = RPSControlFactory.CreateRPSGridComboBox<AutomaticMaterialInputationDialogView>("","#c3b1d973-a81a-4311-bbd1-41d8b06c16f7 .ag-row[role='row']@ROWINDEX [col-id='cIDSite']","",false, this.CurrentView);
 
            IDWareHouse = RPSControlFactory.CreateRPSGridComboBox<AutomaticMaterialInputationDialogView>("","#c3b1d973-a81a-4311-bbd1-41d8b06c16f7 .ag-row[role='row']@ROWINDEX [col-id='cIDWarehouse']","",false, this.CurrentView);
 
            Series = RPSControlFactory.CreateRPSGridEnumComboBox<AutomaticMaterialInputationDialogView>("","#c3b1d973-a81a-4311-bbd1-41d8b06c16f7 .ag-row[role='row']@ROWINDEX [col-id='cSeries']","",false, this.CurrentView);
 
            IDLocationWarehouse = RPSControlFactory.CreateRPSGridComboBox<AutomaticMaterialInputationDialogView>("","#c3b1d973-a81a-4311-bbd1-41d8b06c16f7 .ag-row[role='row']@ROWINDEX [col-id='cIDLocationWarehouse']","",false, this.CurrentView);
 
            IDProjectTask = RPSControlFactory.CreateRPSGridComboBox<AutomaticMaterialInputationDialogView>("","#c3b1d973-a81a-4311-bbd1-41d8b06c16f7 .ag-row[role='row']@ROWINDEX [col-id='cIDProjectTask']","",false, this.CurrentView);
 
            IDProMaterial = RPSControlFactory.CreateRPSGridComboBox<AutomaticMaterialInputationDialogView>("","#c3b1d973-a81a-4311-bbd1-41d8b06c16f7 .ag-row[role='row']@ROWINDEX [col-id='cIDProMaterial']","",false, this.CurrentView);
 

        }
        public IRPSGridButton<AutomaticMaterialInputationDialogView> RemoveCommand { get; set; } 
        public IRPSGridComboBox<AutomaticMaterialInputationDialogView> IDProject { get; set; } 
        public IRPSGridComboBox<AutomaticMaterialInputationDialogView> IDArticleMaterial { get; set; } 
        public IRPSGridTextBox<AutomaticMaterialInputationDialogView> ImputedQtty { get; set; } 
        public IRPSGridTextBox<AutomaticMaterialInputationDialogView> CurrentQtty { get; set; } 
        public IRPSGridTextBox<AutomaticMaterialInputationDialogView> QuantitySecondUnit { get; set; } 
        public IRPSGridComboBox<AutomaticMaterialInputationDialogView> IDSite { get; set; } 
        public IRPSGridComboBox<AutomaticMaterialInputationDialogView> IDWareHouse { get; set; } 
        public IRPSGridComboBox<AutomaticMaterialInputationDialogView> Series { get; set; } 
        public IRPSGridComboBox<AutomaticMaterialInputationDialogView> IDLocationWarehouse { get; set; } 
        public IRPSGridComboBox<AutomaticMaterialInputationDialogView> IDProjectTask { get; set; } 
        public IRPSGridComboBox<AutomaticMaterialInputationDialogView> IDProMaterial { get; set; } 
                     
    }
 
    }
  
            
    public partial class ModifyOrderSituationDialogView : View
    {
        public ModifyOrderSituationDialogView(Order screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDOrderSituation = RPSControlFactory.CreateRPSComboBox<ModifyOrderSituationDialogView>("b3e819c8-237a-4818-b87e-ca7acdecae6e","","",true, this);
 

        }
        public IRPSComboBox<ModifyOrderSituationDialogView> IDOrderSituation { get; set; } 
        public Order Screen { get; set; }
        public ModifyOrderSituationDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OrderIncidenceView : View
    {
        public OrderIncidenceView(Order screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<OrderIncidenceView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<OrderIncidenceView,OrderLineView>( this,Screen.OrderLineView);
 
            BackButton = RPSControlFactory.RPSBackButton<OrderIncidenceView,OrderLineView>( this,Screen.OrderLineView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<OrderIncidenceView,OrderLineView>( this,Screen.OrderLineView);
 
            NumIncidence = RPSControlFactory.CreateRPSFormattedTextBox<OrderIncidenceView>("1227f94d-6721-44b7-8b79-b4b09e6ebba8","","",true, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<OrderIncidenceView>("60f1e611-2f0f-4f7f-a99b-9f8497c782f9","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<OrderIncidenceView>("07d8b09f-89e6-46df-bd9c-d4182118d2f5","","",false, this);
 
            IDIncidenceType = RPSControlFactory.CreateRPSComboBox<OrderIncidenceView>("064fce96-c430-4c1f-863d-748b2d100ac8","","",true, this);
 
            IDIncidenceSituation = RPSControlFactory.CreateRPSComboBox<OrderIncidenceView>("f16ff859-5baf-4138-aa01-206df8b15ba0","","",true, this);
 
            IDResponsibleEmployee = RPSControlFactory.CreateRPSComboBox<OrderIncidenceView>("7c04d6ea-9470-45dd-a527-eea1f9ad1952","","",false, this);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<OrderIncidenceView>("46e742d7-1280-4b93-ab0b-78cd8cf13d85","","",true, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<OrderIncidenceView>("25b9d1f5-ff53-4ff5-8471-eed10dff33a2","","",false, this);
 
            SectionGeneral = RPSControlFactory.CreateRPSSection<OrderIncidenceView>( "","ul li[rpsid='ff4f49be-ed1e-488c-b3c5-6f5ea9142553']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<OrderIncidenceView>( "","ul li[rpsid='816c49d9-88c7-4ce0-9751-792bd22cad95']","",this);
 

        }
        public IRPSButton<OrderIncidenceView> DeleteButton { get; set; } 
        public IRPSButton<OrderIncidenceView,OrderLineView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<OrderIncidenceView,OrderLineView> BackButton { get; set; } 
        public IRPSAcceptButton<OrderIncidenceView,OrderLineView> AcceptButton { get; set; } 
        public IRPSTextBox<OrderIncidenceView> NumIncidence { get; set; } 
        public IRPSTextBox<OrderIncidenceView> Date { get; set; } 
        public IRPSTextBox<OrderIncidenceView> Description { get; set; } 
        public IRPSComboBox<OrderIncidenceView> IDIncidenceType { get; set; } 
        public IRPSComboBox<OrderIncidenceView> IDIncidenceSituation { get; set; } 
        public IRPSComboBox<OrderIncidenceView> IDResponsibleEmployee { get; set; } 
        public IRPSComboBox<OrderIncidenceView> CodUser { get; set; } 
        public IRPSTextBox<OrderIncidenceView> Comment { get; set; } 
        public IRPSSection<OrderIncidenceView> SectionGeneral { get; set; } 
        public IRPSSection<OrderIncidenceView> Comments { get; set; } 
        public Order Screen { get; set; }
        public OrderIncidenceView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class AnalyticChildDialogView : View
    {
        public AnalyticChildDialogView(Order screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDAccount = RPSControlFactory.CreateRPSComboBox<AnalyticChildDialogView>("46cd2d70-748c-455b-82c7-1933f2e21ddf","","",false, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<AnalyticChildDialogView>("2c5f2bd3-6b42-43cf-80b4-345b09995c6b","","",true, this);
 
            GetDimensionChildCommandButton = RPSControlFactory.CreateRPSButton<AnalyticChildDialogView>( "44a58b11-9a81-4e12-92d8-b06ccf4700cc","","",this);
 
            CollectionInit params_OrderLineAnalytics = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b6184159-379a-46d7-bf30-a1569803ac3f",CSSSelectorGrid="",XPathGrid=""};
            OrderLineAnalytics = RPSControlFactory.RPSCreateCollectionWithGrid<OrderLineAnalyticsCollectionEditor<AnalyticChildDialogView>,AnalyticChildDialogView>( params_OrderLineAnalytics,this);
 

        }
        public IRPSComboBox<AnalyticChildDialogView> IDAccount { get; set; } 
        public IRPSTextBox<AnalyticChildDialogView> Amount { get; set; } 
        public IRPSButton<AnalyticChildDialogView> GetDimensionChildCommandButton { get; set; } 
        public OrderLineAnalyticsCollectionEditor<AnalyticChildDialogView> OrderLineAnalytics { get; set; } 
        public Order Screen { get; set; }
        public AnalyticChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class OrderLineAnalyticsCollectionEditor<AnalyticChildDialogView>:RPSCollectionEditor<AnalyticChildDialogView> where AnalyticChildDialogView : class, IView
    {
        public  OrderLineAnalyticsGridView<AnalyticChildDialogView> GridView {get;set;}
    }
    public partial class OrderLineAnalyticsGridView <AnalyticChildDialogView> :  RPSGridView<AnalyticChildDialogView> where AnalyticChildDialogView : class, IView
    {
        public OrderLineAnalyticsGridView(AnalyticChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDDimension = RPSControlFactory.CreateRPSGridComboBox<AnalyticChildDialogView>("","#b6184159-379a-46d7-bf30-a1569803ac3f .ag-row[role='row']@ROWINDEX [col-id='cIDDimension']","",true, this.CurrentView);
 
            IDDimValue = RPSControlFactory.CreateRPSGridComboBox<AnalyticChildDialogView>("","#b6184159-379a-46d7-bf30-a1569803ac3f .ag-row[role='row']@ROWINDEX [col-id='cIDDimValue']","",true, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<AnalyticChildDialogView>("","#b6184159-379a-46d7-bf30-a1569803ac3f .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<AnalyticChildDialogView>("","#b6184159-379a-46d7-bf30-a1569803ac3f .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<AnalyticChildDialogView> IDDimension { get; set; } 
        public IRPSGridComboBox<AnalyticChildDialogView> IDDimValue { get; set; } 
        public IRPSGridTextBox<AnalyticChildDialogView> Percentage { get; set; } 
        public IRPSGridTextBox<AnalyticChildDialogView> Amount { get; set; } 
                     
    }
 
    }
  
    

}