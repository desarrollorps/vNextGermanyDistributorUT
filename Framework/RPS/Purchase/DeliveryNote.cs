    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.DeliveryNote
{
    //RPS VERSION 1.0.0.0
    public partial class DeliveryNote:Screen
    {
        public DeliveryNote():base()
        {
            this.URL = "purchase.deliverynote";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DeliveryNoteCollectionView  = new DeliveryNoteCollectionView(this); 
            DeliveryNoteEntityView  = new DeliveryNoteEntityView(this); 
            DeliveryNoteLineView  = new DeliveryNoteLineView(this); 
            DeliveryNoteLineMovementView  = new DeliveryNoteLineMovementView(this); 
            DeliveryNoteLineTaxView  = new DeliveryNoteLineTaxView(this); 
            DeliveryNoteLineConditionView  = new DeliveryNoteLineConditionView(this); 
            DeliveryNoteVariablePaymentView  = new DeliveryNoteVariablePaymentView(this); 
            OrderLineAnalyticView  = new OrderLineAnalyticView(this); 
            NewConsumptionChildDialogView  = new NewConsumptionChildDialogView(this); 
            DeliveryFromOrderHeaderChildDialogView  = new DeliveryFromOrderHeaderChildDialogView(this); 
            RecalculateIntrastatChildDialogView  = new RecalculateIntrastatChildDialogView(this); 
            DeliveryNoteChangesChildDialogView  = new DeliveryNoteChangesChildDialogView(this); 
            PrintDeliveryNoteChildDialogView  = new PrintDeliveryNoteChildDialogView(this); 
            DeliveryFromOrderChildDialogView  = new DeliveryFromOrderChildDialogView(this); 
            ArticleGenericChildDialogView  = new ArticleGenericChildDialogView(this); 
            RecalculateCostChildDialogView  = new RecalculateCostChildDialogView(this); 
            NewFromSalesDialogView  = new NewFromSalesDialogView(this); 
            SeriesDataChildDialogView  = new SeriesDataChildDialogView(this); 
            InvoiceChildDialogView  = new InvoiceChildDialogView(this); 
            InvoiceView  = new InvoiceView(this); 
            ContainerChildDialogView  = new ContainerChildDialogView(this); 
            AutomaticMaterialImputationDialogView  = new AutomaticMaterialImputationDialogView(this); 
            DirectSeriesDataChildDialogView  = new DirectSeriesDataChildDialogView(this); 
            AnalyticChildDialogView  = new AnalyticChildDialogView(this); 
            LocationChildDialogView  = new LocationChildDialogView(this); 
            DeliveryNoteCollectionView.InitializeControls(); 
            DeliveryNoteEntityView.InitializeControls(); 
            DeliveryNoteLineView.InitializeControls(); 
            DeliveryNoteLineMovementView.InitializeControls(); 
            DeliveryNoteLineTaxView.InitializeControls(); 
            DeliveryNoteLineConditionView.InitializeControls(); 
            DeliveryNoteVariablePaymentView.InitializeControls(); 
            OrderLineAnalyticView.InitializeControls(); 
            NewConsumptionChildDialogView.InitializeControls(); 
            DeliveryFromOrderHeaderChildDialogView.InitializeControls(); 
            RecalculateIntrastatChildDialogView.InitializeControls(); 
            DeliveryNoteChangesChildDialogView.InitializeControls(); 
            PrintDeliveryNoteChildDialogView.InitializeControls(); 
            DeliveryFromOrderChildDialogView.InitializeControls(); 
            ArticleGenericChildDialogView.InitializeControls(); 
            RecalculateCostChildDialogView.InitializeControls(); 
            NewFromSalesDialogView.InitializeControls(); 
            SeriesDataChildDialogView.InitializeControls(); 
            InvoiceChildDialogView.InitializeControls(); 
            InvoiceView.InitializeControls(); 
            ContainerChildDialogView.InitializeControls(); 
            AutomaticMaterialImputationDialogView.InitializeControls(); 
            DirectSeriesDataChildDialogView.InitializeControls(); 
            AnalyticChildDialogView.InitializeControls(); 
            LocationChildDialogView.InitializeControls(); 
           
        }
      
            public DeliveryNoteCollectionView DeliveryNoteCollectionView {get; set; } 
            public DeliveryNoteEntityView DeliveryNoteEntityView {get; set; } 
            public DeliveryNoteLineView DeliveryNoteLineView {get; set; } 
            public DeliveryNoteLineMovementView DeliveryNoteLineMovementView {get; set; } 
            public DeliveryNoteLineTaxView DeliveryNoteLineTaxView {get; set; } 
            public DeliveryNoteLineConditionView DeliveryNoteLineConditionView {get; set; } 
            public DeliveryNoteVariablePaymentView DeliveryNoteVariablePaymentView {get; set; } 
            public OrderLineAnalyticView OrderLineAnalyticView {get; set; } 
            public NewConsumptionChildDialogView NewConsumptionChildDialogView {get; set; } 
            public DeliveryFromOrderHeaderChildDialogView DeliveryFromOrderHeaderChildDialogView {get; set; } 
            public RecalculateIntrastatChildDialogView RecalculateIntrastatChildDialogView {get; set; } 
            public DeliveryNoteChangesChildDialogView DeliveryNoteChangesChildDialogView {get; set; } 
            public PrintDeliveryNoteChildDialogView PrintDeliveryNoteChildDialogView {get; set; } 
            public DeliveryFromOrderChildDialogView DeliveryFromOrderChildDialogView {get; set; } 
            public ArticleGenericChildDialogView ArticleGenericChildDialogView {get; set; } 
            public RecalculateCostChildDialogView RecalculateCostChildDialogView {get; set; } 
            public NewFromSalesDialogView NewFromSalesDialogView {get; set; } 
            public SeriesDataChildDialogView SeriesDataChildDialogView {get; set; } 
            public InvoiceChildDialogView InvoiceChildDialogView {get; set; } 
            public InvoiceView InvoiceView {get; set; } 
            public ContainerChildDialogView ContainerChildDialogView {get; set; } 
            public AutomaticMaterialImputationDialogView AutomaticMaterialImputationDialogView {get; set; } 
            public DirectSeriesDataChildDialogView DirectSeriesDataChildDialogView {get; set; } 
            public AnalyticChildDialogView AnalyticChildDialogView {get; set; } 
            public LocationChildDialogView LocationChildDialogView {get; set; } 
    }
            
    public partial class DeliveryNoteCollectionView : View
    {
        public DeliveryNoteCollectionView(DeliveryNote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<DeliveryNoteCollectionView,DeliveryNoteEntityView>( this,Screen.DeliveryNoteEntityView);
 
            DeliveryFromOrderHeaderChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryNoteCollectionView,DeliveryFromOrderHeaderChildDialogView>("82a6db9c-5d16-4fab-bb10-566597d9d981","","", this,Screen.DeliveryFromOrderHeaderChildDialogView);
 
            NewConsumptionChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryNoteCollectionView,NewConsumptionChildDialogView>("26c33098-40d2-4b20-a526-72c5eb50b906","","", this,Screen.NewConsumptionChildDialogView);
 
            NewFromSalesNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryNoteCollectionView,NewFromSalesDialogView>("2fd3ca70-adbb-449c-b32f-689da37ffa6a","","", this,Screen.NewFromSalesDialogView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "0633d6f8-6188-4dd8-9120-9367f40c3746",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<DeliveryNoteCollectionView,DeliveryNoteEntityView>( params_MainConsult,this,Screen.DeliveryNoteEntityView);
 

        }
        public IRPSButton<DeliveryNoteCollectionView,DeliveryNoteEntityView> NewButton { get; set; } 
        public IRPSButton<DeliveryNoteCollectionView,DeliveryFromOrderHeaderChildDialogView> DeliveryFromOrderHeaderChildNavigationCommandButton { get; set; } 
        public IRPSButton<DeliveryNoteCollectionView,NewConsumptionChildDialogView> NewConsumptionChildNavigationCommandButton { get; set; } 
        public IRPSButton<DeliveryNoteCollectionView,NewFromSalesDialogView> NewFromSalesNavigationCommandButton { get; set; } 
        public IRPSCollectionEditor<DeliveryNoteCollectionView,DeliveryNoteEntityView> MainConsult { get; set; } 
        public DeliveryNote Screen { get; set; }
        public DeliveryNoteCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DeliveryNoteEntityView : View
    {
        public DeliveryNoteEntityView(DeliveryNote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<DeliveryNoteEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<DeliveryNoteEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DeliveryNoteEntityView,DeliveryNoteCollectionView>( this,Screen.DeliveryNoteCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<DeliveryNoteEntityView,DeliveryNoteCollectionView>( this,Screen.DeliveryNoteCollectionView);
 
            UITotalLinesAmount = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteEntityView>("431a7061-cd06-4244-a319-2005934533bf","","",false, this);
 
            UITotalBase = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteEntityView>("2b2cd0d8-44fe-4037-9b4a-1a2f34281b24","","",false, this);
 
            UITotalVAT = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteEntityView>("0c955e7b-e3f2-4f07-944b-9aff9e4aeb1b","","",false, this);
 
            UITotalTax = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteEntityView>("ae68ac61-fa01-41cc-8a51-cd6e22fa6a59","","",false, this);
 
            UITotalDeliveryNote = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteEntityView>("c7bd20fc-25aa-4c7f-beaf-7d4ffba49d37","","",false, this);
 
            Transport = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteEntityView>("79a4d459-d018-4298-9871-ebf3a8fb5d34","","",true, this);
 
            AddDeliveryNoteLineFromSupplierArticleCommandButton = RPSControlFactory.CreateRPSButton<DeliveryNoteEntityView>( "9070414b-7808-4cad-839c-8ac408cc1f53","","",this);
 
            DeliveryNoteChangesChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryNoteEntityView,DeliveryNoteChangesChildDialogView>("a57c9448-8c53-47ae-98b3-2d0b437ecab6","","", this,Screen.DeliveryNoteChangesChildDialogView);
 
            CodDeliveryNote = RPSControlFactory.CreateRPSTextBox<DeliveryNoteEntityView>("ec4729bb-03d7-4a1b-b78e-7c5c4d493f81","","",true, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<DeliveryNoteEntityView>("559b9dcf-feff-40f8-8d5a-5020a5ca9d38","","",true, this);
 
            IDSupplierMiscellaneous = RPSControlFactory.CreateRPSComboBox<DeliveryNoteEntityView>("4f924557-0b12-4aaa-a3eb-8b6860df2e37","","",false, this);
 
            IDContactAdministration = RPSControlFactory.CreateRPSComboBox<DeliveryNoteEntityView>("add1bf4d-55da-446b-98c2-bf5b41035f0a","","",false, this);
 
            CodDeliveryNoteInt = RPSControlFactory.CreateRPSTextBox<DeliveryNoteEntityView>("36b06fc7-16c5-403c-a8fb-303a5f2ee2fe","","",true, this);
 
            CodOrder = RPSControlFactory.CreateRPSTextBox<DeliveryNoteEntityView>("04fe5f57-6bec-4f6d-ad6c-96b336b0e143","","",false, this);
 
            OrderNumberSupplier = RPSControlFactory.CreateRPSTextBox<DeliveryNoteEntityView>("08be8aff-7b00-4135-87a3-33264058f99e","","",false, this);
 
            Transport1 = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteEntityView>("45f037f8-38fe-4e2e-a2b8-4bae866471db","","",true, this);
 
            DeliveryNoteDate = RPSControlFactory.CreateRPSTextBox<DeliveryNoteEntityView>("956690d4-7283-4f98-95c5-a07179853e72","","",true, this);
 
            Situation = RPSControlFactory.CreateRPSEnumComboBox<DeliveryNoteEntityView>("da96d32b-6223-4f3f-ae4e-23392766eed8","","",true, this);
 
            DocumentType = RPSControlFactory.CreateRPSEnumComboBox<DeliveryNoteEntityView>("63ccd709-c6da-4bb9-90d8-36d7d9084cc9","","",true, this);
 
            CodFromInvoice = RPSControlFactory.CreateRPSEnumComboBox<DeliveryNoteEntityView>("56d08cde-6705-435f-92a3-e121c0174fb2","","",false, this);
 
            Blocked = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteEntityView>("e7d0464a-b1a7-41f3-8043-42c70c26f36a","","",true, this);
 
            Direct = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteEntityView>("45b98c41-6f4e-4f9f-8474-1d4d7aab3c36","","",true, this);
 
            UICodCompanySales = RPSControlFactory.CreateRPSTextBox<DeliveryNoteEntityView>("89ecf9d0-40cb-4612-b8ef-dbb8d7b62115","","",false, this);
 
            IDIntDeliveryNoteSales = RPSControlFactory.CreateRPSComboBox<DeliveryNoteEntityView>("ee9e5da9-fc77-439a-a3cc-8b9b0f5027e1","","",false, this);
 
            IDBusinessUnit = RPSControlFactory.CreateRPSComboBox<DeliveryNoteEntityView>("c908b189-b4e3-4ad4-80b3-5e02d06e00cc","","",false, this);
 
            PurchaseManager = RPSControlFactory.CreateRPSComboBox<DeliveryNoteEntityView>("0b92b770-8591-46c2-be05-1f15b4463845","","",false, this);
 
            IDInvoicingType = RPSControlFactory.CreateRPSComboBox<DeliveryNoteEntityView>("ee4f704a-aab9-4078-8d5b-f4fa10c19cd1","","",true, this);
 
            IDSupplierPayment = RPSControlFactory.CreateRPSComboBox<DeliveryNoteEntityView>("83ae60ca-9854-4ffd-8654-75cc208447e3","","",false, this);
 
            IDSupplierBankAccount = RPSControlFactory.CreateRPSComboBox<DeliveryNoteEntityView>("2fcb74aa-a3f5-4c65-94c9-89110232bd3f","","",false, this);
 
            IDVoucherType = RPSControlFactory.CreateRPSComboBox<DeliveryNoteEntityView>("99d4c695-559c-4f0a-adcf-5adf5da05df7","","",false, this);
 
            IDBankAccountCompany = RPSControlFactory.CreateRPSComboBox<DeliveryNoteEntityView>("6a6d9d93-dd7f-4989-820d-14d140802af2","","",false, this);
 
            IDEUInvoice = RPSControlFactory.CreateRPSComboBox<DeliveryNoteEntityView>("27cea609-8878-4f01-ba16-c1d683b5a8c0","","",false, this);
 
            RentingInvoice = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteEntityView>("e54d526e-9816-486d-a5c4-e6f33e7868c8","","",false, this);
 
            IDFixedAsset = RPSControlFactory.CreateRPSComboBox<DeliveryNoteEntityView>("e2b6c34e-0e73-415a-ba66-a4d43c13af86","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<DeliveryNoteEntityView>("86b7637a-9346-44e5-b67e-f0a5e065da18","","",false, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<DeliveryNoteEntityView>("76c4fc18-e197-4d04-b3a2-fb0d1f634f9f","","",false, this);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<DeliveryNoteEntityView>("4e94f40b-3f04-4c57-9772-d9c0530b59ce","","",false, this);
 
            IDSupplierOrderAddress = RPSControlFactory.CreateRPSComboBox<DeliveryNoteEntityView>("72e50654-c44d-483a-9b00-53751af986ec","","",false, this);
 
            IDShippingAgent = RPSControlFactory.CreateRPSComboBox<DeliveryNoteEntityView>("210cc4f5-d311-420c-a6ef-75916dd6dbcb","","",false, this);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSComboBox<DeliveryNoteEntityView>("d65d47e9-7430-4f0e-8c25-9b62c722faf0","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<DeliveryNoteEntityView>("8417dd7b-d409-413b-bc3d-d4cc46b571b5","","",true, this);
 
            Change = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteEntityView>("3a65b36d-8cea-4c15-a0da-803e4df22115","","",true, this);
 
            FixedChange = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteEntityView>("d766863b-2547-4ac6-b8de-44a542e9316a","","",true, this);
 
            IDVATType = RPSControlFactory.CreateRPSComboBox<DeliveryNoteEntityView>("f24d6d60-3227-4953-8659-e0f49d21ee17","","",true, this);
 
            IDSurchargeVATType = RPSControlFactory.CreateRPSComboBox<DeliveryNoteEntityView>("fee86a7e-a211-421f-9ce0-f7c5dda8d892","","",false, this);
 
            IDTaxGroup = RPSControlFactory.CreateRPSComboBox<DeliveryNoteEntityView>("08c35c64-fd9e-4ff9-b19a-7b48ca59a7b9","","",false, this);
 
            Discount1 = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteEntityView>("cd56b88b-1a40-46a5-bec7-4391d5aa282c","","",true, this);
 
            Discount2 = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteEntityView>("2fb022ab-450a-4daa-8690-7e852c79bdfe","","",true, this);
 
            Discount3 = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteEntityView>("21f3043d-5bf8-4832-aca1-e3629be3191a","","",true, this);
 
            CashDiscount = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteEntityView>("7641cc55-ebd8-4b34-9ff7-51a564773c5f","","",true, this);
 
            FinancialSurcharge = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteEntityView>("3a34ff04-7e05-4c36-954c-eea9b2de9762","","",true, this);
 
            RetentionPercent = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteEntityView>("b7c67e2c-67c7-4ffb-a4d7-e0a64fb40529","","",true, this);
 
            CodDeliveryTerm = RPSControlFactory.CreateRPSComboBox<DeliveryNoteEntityView>("9eebf688-fa83-4650-bfc4-ccc8579a302f","","",false, this);
 
            CodTransportMethod = RPSControlFactory.CreateRPSComboBox<DeliveryNoteEntityView>("8f7e3480-387e-4863-b1b1-ae120eca99ee","","",false, this);
 
            CodHarborAirport = RPSControlFactory.CreateRPSComboBox<DeliveryNoteEntityView>("ba4dbac5-329c-4c07-a04f-e49be71b28a4","","",false, this);
 
            CodBusinessType = RPSControlFactory.CreateRPSComboBox<DeliveryNoteEntityView>("2df44bc1-1ffa-4fe7-b7ee-aed06ff56431","","",false, this);
 
            StatisticRegime = RPSControlFactory.CreateRPSEnumComboBox<DeliveryNoteEntityView>("5e513f56-a910-4746-b336-c1fe8b2420b5","","",true, this);
 
            PercentPurchase = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteEntityView>("0a649579-1a53-428f-b7ae-797c6f78bb9f","","",true, this);
 
            IDMaintenanceOrder = RPSControlFactory.CreateRPSComboBox<DeliveryNoteEntityView>("680ebb8b-8318-4071-bce8-56b78f0eccb5","","",false, this);
 
            UICodmaintenanceContractCode = RPSControlFactory.CreateRPSTextBox<DeliveryNoteEntityView>("f54a197a-c19d-434e-a21f-2bba5786b724","","",false, this);
 
            IDImportOrderType = RPSControlFactory.CreateRPSComboBox<DeliveryNoteEntityView>("24bc3843-51a7-408a-a090-df5e61285936","","",false, this);
 
            IDOrderImport = RPSControlFactory.CreateRPSComboBox<DeliveryNoteEntityView>("75981b9c-a859-4a0d-b1e8-aa776cb4f908","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<DeliveryNoteEntityView>("ad4bbffb-ff25-47b3-a484-8d4c0c72ef3a","","",false, this);
 
            CommentInvoice = RPSControlFactory.CreateRPSTextBox<DeliveryNoteEntityView>("7585d9d2-1a6c-4fed-9133-2004ea099bfc","","",false, this);
 
            PrintDeliveryNoteChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryNoteEntityView,PrintDeliveryNoteChildDialogView>("a04ea707-ea8c-41ae-b956-45b0b3a000a5","","", this,Screen.PrintDeliveryNoteChildDialogView);
 
            TotalsUpdateButton = RPSControlFactory.CreateRPSButton<DeliveryNoteEntityView>( "367891b1-5cb3-4533-bbbc-5979393807cf","","",this);
 
            DeliveryFromOrderChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryNoteEntityView,DeliveryFromOrderChildDialogView>("bf9358e7-5392-41e4-a39c-fad0398b63ef","","", this,Screen.DeliveryFromOrderChildDialogView);
 
            InvoiceChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryNoteEntityView,InvoiceChildDialogView>("c9c343a9-9688-4388-ab93-2da80d2a074f","","", this,Screen.InvoiceChildDialogView);
 
            FinalizedCommandButton = RPSControlFactory.CreateRPSButton<DeliveryNoteEntityView>( "8578126f-3b2f-4838-b2f3-4a2f61e38542","","",this);
 
            ExecuteUnFinalizedButton = RPSControlFactory.CreateRPSButton<DeliveryNoteEntityView>( "0e17ead7-1a15-458e-88a0-b73d8dacce87","","",this);
 
            RecalculateCostChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryNoteEntityView,RecalculateCostChildDialogView>("59fdec06-6456-4baa-aa3d-0f0b8c2963ed","","", this,Screen.RecalculateCostChildDialogView);
 
            RecalculateCostAndSaveChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryNoteEntityView,RecalculateCostChildDialogView>("42f98d64-624b-45c1-ad45-02478ef7edc8","","", this,Screen.RecalculateCostChildDialogView);
 
            RecalculatePromotionButton = RPSControlFactory.CreateRPSButton<DeliveryNoteEntityView>( "0111a5b2-2a00-4614-baff-ae3543bb8821","","",this);
 
            ExecuteUpdateTransportAmountButton = RPSControlFactory.CreateRPSButton<DeliveryNoteEntityView>( "ffe0fd20-83a2-40cf-8c32-431993f3563b","","",this);
 
            RecalculateIntrastatChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryNoteEntityView,RecalculateIntrastatChildDialogView>("9fe3d9e1-97e8-449f-ac12-d83751303a7c","","", this,Screen.RecalculateIntrastatChildDialogView);
 
            CollectionInit params_DeliveryNoteLines = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a88183ff-af36-4f42-96d9-d262db2a7687",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNoteLines = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNoteLinesCollectionEditor<DeliveryNoteEntityView,DeliveryNoteLineView>,DeliveryNoteEntityView,DeliveryNoteLineView>( params_DeliveryNoteLines,this,Screen.DeliveryNoteLineView);
 
            CollectionInit params_DeliveryNoteVariablePayments = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="10bbe02a-5d34-4d88-b2f8-e96c59a70e09",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNoteVariablePayments = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNoteVariablePaymentsCollectionEditor<DeliveryNoteEntityView,DeliveryNoteLineView>,DeliveryNoteEntityView,DeliveryNoteLineView>( params_DeliveryNoteVariablePayments,this,Screen.DeliveryNoteLineView);
 
            LineSection = RPSControlFactory.CreateRPSSection<DeliveryNoteEntityView>( "","ul li[rpsid='4b8ee57a-fd4d-428f-a6fb-37f2bc104010']","",this);
 
            GeneralDataSection = RPSControlFactory.CreateRPSSection<DeliveryNoteEntityView>( "","ul li[rpsid='1a1caca3-43ff-4a84-819b-4bc27aff0d2d']","",this);
 
            VariablePayementSection = RPSControlFactory.CreateRPSSection<DeliveryNoteEntityView>( "","ul li[rpsid='880a1bf6-6053-49e5-ad86-8b02fd577a06']","",this);
 
            CommentSection = RPSControlFactory.CreateRPSSection<DeliveryNoteEntityView>( "","ul li[rpsid='efa885e7-dec8-468d-85fa-363bda1683e7']","",this);
 

        }
        public IRPSSaveButton<DeliveryNoteEntityView> SaveButton { get; set; } 
        public IRPSButton<DeliveryNoteEntityView> DeleteButton { get; set; } 
        public IRPSButton<DeliveryNoteEntityView,DeliveryNoteCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DeliveryNoteEntityView,DeliveryNoteCollectionView> BackButton { get; set; } 
        public IRPSTextBox<DeliveryNoteEntityView> UITotalLinesAmount { get; set; } 
        public IRPSTextBox<DeliveryNoteEntityView> UITotalBase { get; set; } 
        public IRPSTextBox<DeliveryNoteEntityView> UITotalVAT { get; set; } 
        public IRPSTextBox<DeliveryNoteEntityView> UITotalTax { get; set; } 
        public IRPSTextBox<DeliveryNoteEntityView> UITotalDeliveryNote { get; set; } 
        public IRPSTextBox<DeliveryNoteEntityView> Transport { get; set; } 
        public IRPSButton<DeliveryNoteEntityView> AddDeliveryNoteLineFromSupplierArticleCommandButton { get; set; } 
        public IRPSButton<DeliveryNoteEntityView,DeliveryNoteChangesChildDialogView> DeliveryNoteChangesChildNavigationCommandButton { get; set; } 
        public IRPSTextBox<DeliveryNoteEntityView> CodDeliveryNote { get; set; } 
        public IRPSComboBox<DeliveryNoteEntityView> IDSupplier { get; set; } 
        public IRPSComboBox<DeliveryNoteEntityView> IDSupplierMiscellaneous { get; set; } 
        public IRPSComboBox<DeliveryNoteEntityView> IDContactAdministration { get; set; } 
        public IRPSTextBox<DeliveryNoteEntityView> CodDeliveryNoteInt { get; set; } 
        public IRPSTextBox<DeliveryNoteEntityView> CodOrder { get; set; } 
        public IRPSTextBox<DeliveryNoteEntityView> OrderNumberSupplier { get; set; } 
        public IRPSTextBox<DeliveryNoteEntityView> Transport1 { get; set; } 
        public IRPSTextBox<DeliveryNoteEntityView> DeliveryNoteDate { get; set; } 
        public IRPSComboBox<DeliveryNoteEntityView> Situation { get; set; } 
        public IRPSComboBox<DeliveryNoteEntityView> DocumentType { get; set; } 
        public IRPSComboBox<DeliveryNoteEntityView> CodFromInvoice { get; set; } 
        public IRPSCheckbox<DeliveryNoteEntityView> Blocked { get; set; } 
        public IRPSCheckbox<DeliveryNoteEntityView> Direct { get; set; } 
        public IRPSTextBox<DeliveryNoteEntityView> UICodCompanySales { get; set; } 
        public IRPSComboBox<DeliveryNoteEntityView> IDIntDeliveryNoteSales { get; set; } 
        public IRPSComboBox<DeliveryNoteEntityView> IDBusinessUnit { get; set; } 
        public IRPSComboBox<DeliveryNoteEntityView> PurchaseManager { get; set; } 
        public IRPSComboBox<DeliveryNoteEntityView> IDInvoicingType { get; set; } 
        public IRPSComboBox<DeliveryNoteEntityView> IDSupplierPayment { get; set; } 
        public IRPSComboBox<DeliveryNoteEntityView> IDSupplierBankAccount { get; set; } 
        public IRPSComboBox<DeliveryNoteEntityView> IDVoucherType { get; set; } 
        public IRPSComboBox<DeliveryNoteEntityView> IDBankAccountCompany { get; set; } 
        public IRPSComboBox<DeliveryNoteEntityView> IDEUInvoice { get; set; } 
        public IRPSCheckbox<DeliveryNoteEntityView> RentingInvoice { get; set; } 
        public IRPSComboBox<DeliveryNoteEntityView> IDFixedAsset { get; set; } 
        public IRPSComboBox<DeliveryNoteEntityView> IDSite { get; set; } 
        public IRPSComboBox<DeliveryNoteEntityView> IDWarehouse { get; set; } 
        public IRPSComboBox<DeliveryNoteEntityView> IDDeliveryNoteType { get; set; } 
        public IRPSComboBox<DeliveryNoteEntityView> IDSupplierOrderAddress { get; set; } 
        public IRPSComboBox<DeliveryNoteEntityView> IDShippingAgent { get; set; } 
        public IRPSComboBox<DeliveryNoteEntityView> IDPaymentMethod { get; set; } 
        public IRPSComboBox<DeliveryNoteEntityView> IDCurrency { get; set; } 
        public IRPSTextBox<DeliveryNoteEntityView> Change { get; set; } 
        public IRPSCheckbox<DeliveryNoteEntityView> FixedChange { get; set; } 
        public IRPSComboBox<DeliveryNoteEntityView> IDVATType { get; set; } 
        public IRPSComboBox<DeliveryNoteEntityView> IDSurchargeVATType { get; set; } 
        public IRPSComboBox<DeliveryNoteEntityView> IDTaxGroup { get; set; } 
        public IRPSTextBox<DeliveryNoteEntityView> Discount1 { get; set; } 
        public IRPSTextBox<DeliveryNoteEntityView> Discount2 { get; set; } 
        public IRPSTextBox<DeliveryNoteEntityView> Discount3 { get; set; } 
        public IRPSTextBox<DeliveryNoteEntityView> CashDiscount { get; set; } 
        public IRPSTextBox<DeliveryNoteEntityView> FinancialSurcharge { get; set; } 
        public IRPSTextBox<DeliveryNoteEntityView> RetentionPercent { get; set; } 
        public IRPSComboBox<DeliveryNoteEntityView> CodDeliveryTerm { get; set; } 
        public IRPSComboBox<DeliveryNoteEntityView> CodTransportMethod { get; set; } 
        public IRPSComboBox<DeliveryNoteEntityView> CodHarborAirport { get; set; } 
        public IRPSComboBox<DeliveryNoteEntityView> CodBusinessType { get; set; } 
        public IRPSComboBox<DeliveryNoteEntityView> StatisticRegime { get; set; } 
        public IRPSTextBox<DeliveryNoteEntityView> PercentPurchase { get; set; } 
        public IRPSComboBox<DeliveryNoteEntityView> IDMaintenanceOrder { get; set; } 
        public IRPSTextBox<DeliveryNoteEntityView> UICodmaintenanceContractCode { get; set; } 
        public IRPSComboBox<DeliveryNoteEntityView> IDImportOrderType { get; set; } 
        public IRPSComboBox<DeliveryNoteEntityView> IDOrderImport { get; set; } 
        public IRPSTextBox<DeliveryNoteEntityView> Comment { get; set; } 
        public IRPSTextBox<DeliveryNoteEntityView> CommentInvoice { get; set; } 
        public IRPSButton<DeliveryNoteEntityView,PrintDeliveryNoteChildDialogView> PrintDeliveryNoteChildNavigationCommandButton { get; set; } 
        public IRPSButton<DeliveryNoteEntityView> TotalsUpdateButton { get; set; } 
        public IRPSButton<DeliveryNoteEntityView,DeliveryFromOrderChildDialogView> DeliveryFromOrderChildNavigationCommandButton { get; set; } 
        public IRPSButton<DeliveryNoteEntityView,InvoiceChildDialogView> InvoiceChildNavigationCommandButton { get; set; } 
        public IRPSButton<DeliveryNoteEntityView> FinalizedCommandButton { get; set; } 
        public IRPSButton<DeliveryNoteEntityView> ExecuteUnFinalizedButton { get; set; } 
        public IRPSButton<DeliveryNoteEntityView,RecalculateCostChildDialogView> RecalculateCostChildNavigationCommandButton { get; set; } 
        public IRPSButton<DeliveryNoteEntityView,RecalculateCostChildDialogView> RecalculateCostAndSaveChildNavigationCommandButton { get; set; } 
        public IRPSButton<DeliveryNoteEntityView> RecalculatePromotionButton { get; set; } 
        public IRPSButton<DeliveryNoteEntityView> ExecuteUpdateTransportAmountButton { get; set; } 
        public IRPSButton<DeliveryNoteEntityView,RecalculateIntrastatChildDialogView> RecalculateIntrastatChildNavigationCommandButton { get; set; } 
        public DeliveryNoteLinesCollectionEditor<DeliveryNoteEntityView,DeliveryNoteLineView> DeliveryNoteLines { get; set; } 
        public DeliveryNoteVariablePaymentsCollectionEditor<DeliveryNoteEntityView,DeliveryNoteLineView> DeliveryNoteVariablePayments { get; set; } 
        public IRPSSection<DeliveryNoteEntityView> LineSection { get; set; } 
        public IRPSSection<DeliveryNoteEntityView> GeneralDataSection { get; set; } 
        public IRPSSection<DeliveryNoteEntityView> VariablePayementSection { get; set; } 
        public IRPSSection<DeliveryNoteEntityView> CommentSection { get; set; } 
        public DeliveryNote Screen { get; set; }
        public DeliveryNoteEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DeliveryNoteLinesCollectionEditor<DeliveryNoteEntityView,DeliveryNoteLineView>:RPSCollectionEditor<DeliveryNoteEntityView,DeliveryNoteLineView> where DeliveryNoteEntityView : class, IView where DeliveryNoteLineView : class, IView
    {
        public  DeliveryNoteLinesGridView<DeliveryNoteEntityView,DeliveryNoteLineView> GridView {get;set;}
    }
    public partial class DeliveryNoteLinesGridView <DeliveryNoteEntityView,DeliveryNoteLineView> :  RPSGridView<DeliveryNoteEntityView,DeliveryNoteLineView> where DeliveryNoteEntityView : class, IView where DeliveryNoteLineView : class, IView
    {
        public DeliveryNoteLinesGridView(DeliveryNoteEntityView currentView,DeliveryNoteLineView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDOrderLine = RPSControlFactory.CreateRPSGridComboBox<DeliveryNoteEntityView>("","#a88183ff-af36-4f42-96d9-d262db2a7687 .ag-row[role='row']@ROWINDEX [col-id='cIDOrderLine']","",true, this.CurrentView);
 
            Ordenation = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteEntityView>("","#a88183ff-af36-4f42-96d9-d262db2a7687 .ag-row[role='row']@ROWINDEX [col-id='cOrdenation']","",true, this.CurrentView);
 
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<DeliveryNoteEntityView>("","#a88183ff-af36-4f42-96d9-d262db2a7687 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            UIDescription = RPSControlFactory.CreateRPSGridTextBox<DeliveryNoteEntityView>("","#a88183ff-af36-4f42-96d9-d262db2a7687 .ag-row[role='row']@ROWINDEX [col-id='cUIDescription']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteEntityView>("","#a88183ff-af36-4f42-96d9-d262db2a7687 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            Price = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteEntityView>("","#a88183ff-af36-4f42-96d9-d262db2a7687 .ag-row[role='row']@ROWINDEX [col-id='cPrice']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteEntityView>("","#a88183ff-af36-4f42-96d9-d262db2a7687 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            DeliveryCost = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteEntityView>("","#a88183ff-af36-4f42-96d9-d262db2a7687 .ag-row[role='row']@ROWINDEX [col-id='cDeliveryCost']","",true, this.CurrentView);
 
            ImportCost = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteEntityView>("","#a88183ff-af36-4f42-96d9-d262db2a7687 .ag-row[role='row']@ROWINDEX [col-id='cImportCost']","",true, this.CurrentView);
 
            TariffCost = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteEntityView>("","#a88183ff-af36-4f42-96d9-d262db2a7687 .ag-row[role='row']@ROWINDEX [col-id='cTariffCost']","",true, this.CurrentView);
 
            Matchcode = RPSControlFactory.CreateRPSGridTextBox<DeliveryNoteEntityView>("","#a88183ff-af36-4f42-96d9-d262db2a7687 .ag-row[role='row']@ROWINDEX [col-id='cMatchcode']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<DeliveryNoteEntityView> IDOrderLine { get; set; } 
        public IRPSGridTextBox<DeliveryNoteEntityView> Ordenation { get; set; } 
        public IRPSGridComboBox<DeliveryNoteEntityView> IDArticle { get; set; } 
        public IRPSGridTextBox<DeliveryNoteEntityView> UIDescription { get; set; } 
        public IRPSGridTextBox<DeliveryNoteEntityView> Quantity { get; set; } 
        public IRPSGridTextBox<DeliveryNoteEntityView> Price { get; set; } 
        public IRPSGridTextBox<DeliveryNoteEntityView> Amount { get; set; } 
        public IRPSGridTextBox<DeliveryNoteEntityView> DeliveryCost { get; set; } 
        public IRPSGridTextBox<DeliveryNoteEntityView> ImportCost { get; set; } 
        public IRPSGridTextBox<DeliveryNoteEntityView> TariffCost { get; set; } 
        public IRPSGridTextBox<DeliveryNoteEntityView> Matchcode { get; set; } 
                     
    }
 
        public partial class DeliveryNoteVariablePaymentsCollectionEditor<DeliveryNoteEntityView,DeliveryNoteLineView>:RPSCollectionEditor<DeliveryNoteEntityView,DeliveryNoteLineView> where DeliveryNoteEntityView : class, IView where DeliveryNoteLineView : class, IView
    {
        public  DeliveryNoteVariablePaymentsGridView<DeliveryNoteEntityView,DeliveryNoteLineView> GridView {get;set;}
    }
    public partial class DeliveryNoteVariablePaymentsGridView <DeliveryNoteEntityView,DeliveryNoteLineView> :  RPSGridView<DeliveryNoteEntityView,DeliveryNoteLineView> where DeliveryNoteEntityView : class, IView where DeliveryNoteLineView : class, IView
    {
        public DeliveryNoteVariablePaymentsGridView(DeliveryNoteEntityView currentView,DeliveryNoteLineView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NumPayment = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteEntityView>("","#10bbe02a-5d34-4d88-b2f8-e96c59a70e09 .ag-row[role='row']@ROWINDEX [col-id='cNumPayment']","",true, this.CurrentView);
 
            DatePayment = RPSControlFactory.CreateRPSGridTextBox<DeliveryNoteEntityView>("","#10bbe02a-5d34-4d88-b2f8-e96c59a70e09 .ag-row[role='row']@ROWINDEX [col-id='cDatePayment']","",false, this.CurrentView);
 
            DayPayment = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteEntityView>("","#10bbe02a-5d34-4d88-b2f8-e96c59a70e09 .ag-row[role='row']@ROWINDEX [col-id='cDayPayment']","",false, this.CurrentView);
 
            Rest = RPSControlFactory.CreateRPSGridCheckBox<DeliveryNoteEntityView>("","#10bbe02a-5d34-4d88-b2f8-e96c59a70e09 .ag-row[role='row']@ROWINDEX [col-id='cRest']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteEntityView>("","#10bbe02a-5d34-4d88-b2f8-e96c59a70e09 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",false, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteEntityView>("","#10bbe02a-5d34-4d88-b2f8-e96c59a70e09 .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",false, this.CurrentView);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSGridComboBox<DeliveryNoteEntityView>("","#10bbe02a-5d34-4d88-b2f8-e96c59a70e09 .ag-row[role='row']@ROWINDEX [col-id='cIDPaymentMethod']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<DeliveryNoteEntityView> NumPayment { get; set; } 
        public IRPSGridTextBox<DeliveryNoteEntityView> DatePayment { get; set; } 
        public IRPSGridTextBox<DeliveryNoteEntityView> DayPayment { get; set; } 
        public IRPSGridCheckbox<DeliveryNoteEntityView> Rest { get; set; } 
        public IRPSGridTextBox<DeliveryNoteEntityView> Amount { get; set; } 
        public IRPSGridTextBox<DeliveryNoteEntityView> Percentage { get; set; } 
        public IRPSGridComboBox<DeliveryNoteEntityView> IDPaymentMethod { get; set; } 
                     
    }
 
    }
  
            
    public partial class DeliveryNoteLineView : View
    {
        public DeliveryNoteLineView(DeliveryNote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<DeliveryNoteLineView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DeliveryNoteLineView,DeliveryNoteEntityView>( this,Screen.DeliveryNoteEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<DeliveryNoteLineView,DeliveryNoteEntityView>( this,Screen.DeliveryNoteEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<DeliveryNoteLineView,DeliveryNoteEntityView>( this,Screen.DeliveryNoteEntityView);
 
            IDOrderLine = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineView>("8a1b7f06-2ed8-47ff-9950-8fe4e2c27611","","",true, this);
 
            Ordenation = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineView>("1c7df4ce-b5b6-4592-8972-63549feab225","","",true, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineView>("9ac2887f-6466-4b82-b3af-6bd5415c1327","","",true, this);
 
            UIDescription = RPSControlFactory.CreateRPSTextBox<DeliveryNoteLineView>("bfdba76f-0861-422e-b1fc-b2b653151c3c","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineView>("d857674b-77b7-4448-8cd8-f988308b0dc1","","",true, this);
 
            Price = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineView>("9384513e-ff4c-4b43-99be-6b9438408e54","","",true, this);
 
            VAT = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteLineView>("2651ac36-8e17-47cb-a59d-6a18a9ed47df","","",true, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineView>("e23b7b99-57f0-4f83-9f1d-1814bc5bb591","","",true, this);
 
            AmountWithVAT = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineView>("232e0640-bfa1-4062-8501-00839c84558b","","",true, this);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineView>("5991a8ea-4405-46e1-ac62-e96bd1870c0e","","",true, this);
 
            ReferenceSupplier = RPSControlFactory.CreateRPSEnumComboBox<DeliveryNoteLineView>("5efef7be-f354-4606-bf5c-a2bc5729196b","","",false, this);
 
            UIIDUnitQuantity = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineView>("d6c6d408-0bad-4ca5-b134-7e25dda3f4f7","","",false, this);
 
            UIConversionFactorQuantity = RPSControlFactory.CreateRPSTextBox<DeliveryNoteLineView>("0d5769b7-c097-408a-8619-439a56aa9749","","",false, this);
 
            nArticleDimensions = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineView>("7811e635-98f4-405b-ad3f-05d21a22e7a9","","",false, this);
 
            Dimension1 = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineView>("da6e1e3b-9778-4275-bde6-118b92d6464b","","",true, this);
 
            Dimension2 = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineView>("f8ccf0f8-42bf-4c43-952c-0733dcfbcf60","","",true, this);
 
            Dimension3 = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineView>("b3dfcaf5-7906-4941-8b8c-2f22ca585db6","","",true, this);
 
            UIIDUnitPrice = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineView>("9bda6c1c-8acc-444d-8616-8ad3e3d551f2","","",false, this);
 
            UIConversionFactorPrice = RPSControlFactory.CreateRPSTextBox<DeliveryNoteLineView>("7c532d17-c230-40a3-8a8a-7b2e4260e73a","","",false, this);
 
            Invoice = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteLineView>("afbdee45-b6a6-4e1b-85d5-59048c44963d","","",true, this);
 
            PendingInvoice = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteLineView>("6d2a097d-b0c0-4dd9-a432-29dcb6fa270d","","",true, this);
 
            InvoicedQuantity = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineView>("1583fff7-3d25-4be5-9fb7-c475f925d744","","",true, this);
 
            InvoicedQuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineView>("eb98448b-0931-4a84-847b-3492357a5e74","","",false, this);
 
            PriceWihoutConditions = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineView>("922ae815-6762-4e1a-a40d-ce2508c5a07b","","",true, this);
 
            UIIDEmployee = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineView>("4c7b4f40-0480-41b3-8970-ab9ab3b59050","","",false, this);
 
            Discount1 = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineView>("15ffd414-8ee9-473d-a43c-e94cbfc40a94","","",true, this);
 
            CascadeDiscount1 = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteLineView>("06429a11-9d71-48c2-8fae-083ab5314aa8","","",true, this);
 
            Discount2 = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineView>("8442de70-e009-449a-8b72-25578cf88476","","",true, this);
 
            CascadeDiscount2 = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteLineView>("ce211889-03da-47bc-a94a-23b7adb2a348","","",true, this);
 
            Discount3 = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineView>("6bbf0e16-a184-4c29-84ea-cbae8a4f5e24","","",true, this);
 
            CascadeDiscount3 = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteLineView>("862b66e9-102f-4c2c-bc9c-e5f2af9bb018","","",true, this);
 
            Discount4 = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineView>("5aefa035-8f37-49f6-b809-f1f92443724c","","",true, this);
 
            CascadeDiscount4 = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteLineView>("54fdd068-7261-4900-b319-a0eb07e81c49","","",true, this);
 
            Discount5 = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineView>("28493750-468a-4e3b-a745-30747f53b79f","","",true, this);
 
            CascadeDiscount5 = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteLineView>("b5387e18-9b91-46f1-9380-494bef9d8d98","","",true, this);
 
            AmountDiscount = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineView>("a8874063-052f-4049-b14e-77f866a34f17","","",true, this);
 
            PositionAmountDiscount = RPSControlFactory.CreateRPSEnumComboBox<DeliveryNoteLineView>("0e2f9ba3-b773-4057-8b28-4568628e842e","","",true, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineView>("a08289bf-96cc-499a-acf8-4e5244a30ff4","","",true, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineView>("9173e408-4ed4-419a-ae9f-25dc81ab6c1c","","",true, this);
 
            Series = RPSControlFactory.CreateRPSTextBox<DeliveryNoteLineView>("ab87d6de-0ec4-4ee5-b0b7-18a1b99992dd","","",false, this);
 
            Series1 = RPSControlFactory.CreateRPSEnumComboBox<DeliveryNoteLineView>("a004482a-d9f1-4088-9801-918e68412cf7","","",false, this);
 
            ExpiryDate = RPSControlFactory.CreateRPSTextBox<DeliveryNoteLineView>("a0844dfe-e2e5-4364-b760-d0c51a15dab5","","",false, this);
 
            PotencyValue = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineView>("95453265-b23b-413e-ade6-fac8d6e67e43","","",true, this);
 
            IDSiteTransfer = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineView>("ea931029-744f-471c-a59d-fd7d738a0973","","",false, this);
 
            IDWarehouseTransfer = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineView>("e8f545e9-9071-4b93-8ed4-2fe5d90e85b4","","",false, this);
 
            Inspectionated = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteLineView>("0cf266bc-d1d1-4edf-be50-2087afb5c2c0","","",true, this);
 
            InspectionDate = RPSControlFactory.CreateRPSTextBox<DeliveryNoteLineView>("72d92ea0-47c6-4db5-bd23-384717849fb3","","",false, this);
 
            QuantityRejected = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineView>("93c1e0e3-63f5-4067-8494-a79a34f537b3","","",false, this);
 
            QuantityRejectedSecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineView>("1efda28c-26dd-446a-9549-734a195c2c32","","",false, this);
 
            PendingQuality = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteLineView>("1fc8b4ea-d389-4036-a62f-f6dd380231aa","","",true, this);
 
            ExcludeForEvaluation = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteLineView>("9cca2f58-7b25-48eb-aa5d-6388e56607ba","","",false, this);
 
            IDVAT = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineView>("026774cc-7677-4a1c-b785-b2bb8bdc3e6c","","",true, this);
 
            PercentVAT = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineView>("32612628-4596-454f-b267-370ce4762966","","",true, this);
 
            IDVATSurcharge = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineView>("8251083d-aa25-4da1-83f0-a97530bebffc","","",false, this);
 
            PercentSurcharge = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineView>("7b7e575b-f2ce-4174-a366-2e942cd6802b","","",true, this);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineView>("a492f844-8570-4ba7-8010-42199b310d5d","","",true, this);
 
            IDReturnCause = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineView>("dc0daf31-d42f-41e6-88e1-1cf549f89852","","",false, this);
 
            UIIDAccount = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineView>("55f8f712-c329-4bae-b283-3ff90875c3ce","","",false, this);
 
            UIInvestementExpense = RPSControlFactory.CreateRPSEnumComboBox<DeliveryNoteLineView>("ec804cc1-751d-4fd3-b8e7-ce696a56751b","","",false, this);
 
            AutoInvoice = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteLineView>("e06dc84a-e84f-4032-9ad5-ee1e11268a38","","",false, this);
 
            UIIDOrderLineKit = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineView>("849fab70-6702-4dab-8459-253d3dd7dc36","","",false, this);
 
            UICostPercentage = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineView>("35c917db-ea0f-4707-b119-9e454c73bd08","","",false, this);
 
            UINumProm = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineView>("3e749547-0e65-460b-998d-f4db2aff6b07","","",false, this);
 
            UIRappel = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteLineView>("48426ae4-c7ac-43a2-8b6c-d314eee72742","","",false, this);
 
            UIInternalCode = RPSControlFactory.CreateRPSTextBox<DeliveryNoteLineView>("be785431-a4c8-47fa-be05-b6534ac04350","","",false, this);
 
            UIIDMaintenanceComponent = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineView>("a686a41d-97a2-4815-9b32-0694f7d59371","","",false, this);
 
            UISerialNumber = RPSControlFactory.CreateRPSTextBox<DeliveryNoteLineView>("75f4e9de-8589-42dc-9dbd-6d516b0fb828","","",false, this);
 
            UIIDProject = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineView>("b0dfca1c-bb90-4204-9a5f-b5864602d952","","",false, this);
 
            UIIDProTask = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineView>("f95fe8b1-f8a6-4d16-bcf3-79354ac12f22","","",false, this);
 
            UIIDProMaterial = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineView>("189cc0e0-d530-4cd9-88a0-74574a11cb4a","","",false, this);
 
            UIIDManufacturingOrder = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineView>("32748113-d350-4a25-b839-b43e9752d7fe","","",false, this);
 
            UIIDMOTask = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineView>("77d968ab-9801-4db5-83ec-7f95394652b5","","",false, this);
 
            UIIDMOMaterial = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineView>("c5ee7f8f-6850-471e-8bbd-457e1321036a","","",false, this);
 
            StructureQuantity = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineView>("10922f3e-26ad-4ad0-8d28-2b931adb1dcc","","",false, this);
 
            UIIDMaintenanceOrder = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineView>("80aea427-7d68-4069-ab4b-7750e74584e1","","",false, this);
 
            UIIDOrderMaterialPrevision = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineView>("bcb5a333-dc44-497f-a5b1-54c498d284d8","","",false, this);
 
            UIIDOrderSL = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineView>("400056ec-ef35-484f-ac1b-145517c5b05f","","",false, this);
 
            IDOrderLineSales = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineView>("55ddbe71-e33a-40df-b960-40bf56543a4b","","",false, this);
 
            IDArticleVersion = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineView>("836e0cac-9c7f-4f68-8de2-b4850419b5d8","","",false, this);
 
            UIIDArticleStructure = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineView>("719ea047-e60c-4523-9c34-05a2cb1ce6de","","",false, this);
 
            DeliveryCost = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineView>("ff37bb7c-1f4b-4bde-844c-90f64e293fc5","","",true, this);
 
            ImportCost = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineView>("2b0d5396-8897-436f-89d6-faa8a3b54f5e","","",true, this);
 
            TariffCost = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineView>("f7d71a3c-fa82-4ee6-b197-533a41e58e8b","","",true, this);
 
            PermissionsCost = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineView>("12b0b12d-bdc2-442a-824f-6186035f6677","","",false, this);
 
            BankingCost = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineView>("1c5cf512-f427-4e01-b1c6-11b4170ab202","","",false, this);
 
            OthersCost = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineView>("f9b41301-9b49-40c6-a47e-cd1260aa1a4a","","",false, this);
 
            ExternalCost = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineView>("e9f2398f-9c2c-435b-aa50-7da2780421f5","","",false, this);
 
            BaseIntrastat = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineView>("4af67c93-562d-4a2a-8b9d-1858ad6caaaa","","",true, this);
 
            NetMass = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineView>("5ece4c0f-c27d-47dc-8d0c-1687829d3190","","",true, this);
 
            SupplemetUnit = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineView>("2efe1932-764b-4310-bcf1-f94b39c29c3d","","",true, this);
 
            Cassation = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteLineView>("6442b0f7-542a-47e2-9e09-f51cde5b409b","","",true, this);
 
            IDCommercialConcept = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineView>("e9b464cd-a74b-47fb-a8c1-5ffc95a1d08a","","",false, this);
 
            IDSupplierCommercialCondition = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineView>("e9852f1c-bb46-4e10-97e0-266f0cc47fad","","",false, this);
 
            PriceBase = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineView>("7ecb6a32-566c-4651-99a5-a7e7da94d670","","",true, this);
 
            UIConditionsPrice = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineView>("1bb17a86-be51-4d08-8596-95c88ceaa14f","","",false, this);
 
            UIPriceWihoutConditionsBase = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineView>("eb0cc386-e37e-4609-8ad7-82bd90b7308e","","",true, this);
 
            PriceWihoutConditions1 = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineView>("5c1f6fb8-1227-4ec2-b702-4673b56cf4aa","","",true, this);
 
            OrderLineGetDimensionCommandButton = RPSControlFactory.CreateRPSButton<DeliveryNoteLineView>( "2858a389-a117-4609-a76b-7b23364a183c","","",this);
 
            ExecuteDeliveryNoteLineCommentAddArticleTechnicalDescription = RPSControlFactory.CreateRPSButton<DeliveryNoteLineView>( "4ad3a510-3b7b-4d1b-a4db-fcbfe7b7bcaf","","",this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<DeliveryNoteLineView>("50a65d05-d150-4184-8b33-51e68673ff22","","",false, this);
 
            ExecuteDeliveryNoteLineCommentInvoiceAddArticleTechnicalDescription = RPSControlFactory.CreateRPSButton<DeliveryNoteLineView>( "fe7bc0a4-cff7-47cf-a2b6-520d6189cb65","","",this);
 
            CommentInvoice = RPSControlFactory.CreateRPSTextBox<DeliveryNoteLineView>("67296033-9fb0-4a6f-8036-788c1f1e32f5","","",false, this);
 
            Matchcode = RPSControlFactory.CreateRPSTextBox<DeliveryNoteLineView>("e0b1830c-8675-4761-986d-645d9e1c3b59","","",false, this);
 
            DirectSeriesDataChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryNoteLineView,DirectSeriesDataChildDialogView>("145a61e1-5e3a-4456-b5db-dff7da76dd8b","","", this,Screen.DirectSeriesDataChildDialogView);
 
            ContainerChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryNoteLineView,ContainerChildDialogView>("70d0b2f2-a3b5-49bd-a250-c78cbf87b48f","","", this,Screen.ContainerChildDialogView);
 
            ImputationMaterialNavigationCommandButton = RPSControlFactory.CreateRPSButton<DeliveryNoteLineView>( "f3715f05-8c7a-40ab-a6c1-1d4c28dcdae3","","",this);
 
            AnalyticChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryNoteLineView,AnalyticChildDialogView>("4a160287-5923-4cc9-8386-a5d7ad6f6135","","", this,Screen.AnalyticChildDialogView);
 
            LocationChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryNoteLineView,LocationChildDialogView>("045ed2a2-b3a8-4901-aa71-9e70562de5da","","", this,Screen.LocationChildDialogView);
 
            CollectionInit params_DeliveryNoteLineMovements = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b3f2844f-c67f-4165-b97e-0913bafb813f",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNoteLineMovements = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNoteLineMovementsCollectionEditor<DeliveryNoteLineView,DeliveryNoteLineMovementView>,DeliveryNoteLineView,DeliveryNoteLineMovementView>( params_DeliveryNoteLineMovements,this,Screen.DeliveryNoteLineMovementView);
 
            CollectionInit params_DeliveryNoteLineTaxs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7f987f14-1615-463c-ae24-2e09d93d2008",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNoteLineTaxs = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNoteLineTaxsCollectionEditor<DeliveryNoteLineView,DeliveryNoteLineMovementView>,DeliveryNoteLineView,DeliveryNoteLineMovementView>( params_DeliveryNoteLineTaxs,this,Screen.DeliveryNoteLineMovementView);
 
            CollectionInit params_DeliveryNoteLineConditionsAffect = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3c8bbe28-4e10-4993-8395-a23658b734e9",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNoteLineConditionsAffect = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNoteLineConditionsAffectCollectionEditor<DeliveryNoteLineView,DeliveryNoteLineMovementView>,DeliveryNoteLineView,DeliveryNoteLineMovementView>( params_DeliveryNoteLineConditionsAffect,this,Screen.DeliveryNoteLineMovementView);
 
            CollectionInit params_DeliveryNoteLineConditionSLsNoAffect = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="393f6cda-ae92-4bfe-83ae-b445c1f4787e",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNoteLineConditionSLsNoAffect = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNoteLineConditionSLsNoAffectCollectionEditor<DeliveryNoteLineView,DeliveryNoteLineMovementView>,DeliveryNoteLineView,DeliveryNoteLineMovementView>( params_DeliveryNoteLineConditionSLsNoAffect,this,Screen.DeliveryNoteLineMovementView);
 
            CollectionInit params_OrderLineAnalytics = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6f293a19-d8b9-4852-8f2a-355f1fc66219",CSSSelectorGrid="",XPathGrid=""};
            OrderLineAnalytics = RPSControlFactory.RPSCreateCollectionWithGrid<OrderLineAnalyticsCollectionEditor<DeliveryNoteLineView,DeliveryNoteLineMovementView>,DeliveryNoteLineView,DeliveryNoteLineMovementView>( params_OrderLineAnalytics,this,Screen.DeliveryNoteLineMovementView);
 
            GeneralDataSection = RPSControlFactory.CreateRPSSection<DeliveryNoteLineView>( "","ul li[rpsid='fb971f05-2f79-403f-abb9-0b7ab2002271']","",this);
 
            LocationSection = RPSControlFactory.CreateRPSSection<DeliveryNoteLineView>( "","ul li[rpsid='e83b3673-290e-44d3-a588-4a70276269a4']","",this);
 
            TaxSection = RPSControlFactory.CreateRPSSection<DeliveryNoteLineView>( "","ul li[rpsid='2787f958-775c-489f-b7da-7a00c9b88352']","",this);
 
            ConditionSectionAffect = RPSControlFactory.CreateRPSSection<DeliveryNoteLineView>( "","ul li[rpsid='a5a32732-58cf-4fe7-a8ff-96b623e4c257']","",this);
 
            ConditionSectionNoAffect = RPSControlFactory.CreateRPSSection<DeliveryNoteLineView>( "","ul li[rpsid='4390fa9a-0439-4d8c-b4ab-faf40cc8b7b2']","",this);
 
            AnalitycSection = RPSControlFactory.CreateRPSSection<DeliveryNoteLineView>( "","ul li[rpsid='f58605f2-cec3-443c-86ce-b360a8642dec']","",this);
 
            CommentSection = RPSControlFactory.CreateRPSSection<DeliveryNoteLineView>( "","ul li[rpsid='6505bcb0-1867-480e-9e65-bbfcd46edc1d']","",this);
 
            DPS = RPSControlFactory.CreateRPSSection<DeliveryNoteLineView>( "","ul li[rpsid='9220b974-8787-40c5-8a7a-f3c2433b83c1']","",this);
 

        }
        public IRPSButton<DeliveryNoteLineView> DeleteButton { get; set; } 
        public IRPSButton<DeliveryNoteLineView,DeliveryNoteEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DeliveryNoteLineView,DeliveryNoteEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<DeliveryNoteLineView,DeliveryNoteEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<DeliveryNoteLineView> IDOrderLine { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> Ordenation { get; set; } 
        public IRPSComboBox<DeliveryNoteLineView> IDArticle { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> UIDescription { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> Quantity { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> Price { get; set; } 
        public IRPSCheckbox<DeliveryNoteLineView> VAT { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> Amount { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> AmountWithVAT { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> QuantitySecondUnit { get; set; } 
        public IRPSComboBox<DeliveryNoteLineView> ReferenceSupplier { get; set; } 
        public IRPSComboBox<DeliveryNoteLineView> UIIDUnitQuantity { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> UIConversionFactorQuantity { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> nArticleDimensions { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> Dimension1 { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> Dimension2 { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> Dimension3 { get; set; } 
        public IRPSComboBox<DeliveryNoteLineView> UIIDUnitPrice { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> UIConversionFactorPrice { get; set; } 
        public IRPSCheckbox<DeliveryNoteLineView> Invoice { get; set; } 
        public IRPSCheckbox<DeliveryNoteLineView> PendingInvoice { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> InvoicedQuantity { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> InvoicedQuantitySecondUnit { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> PriceWihoutConditions { get; set; } 
        public IRPSComboBox<DeliveryNoteLineView> UIIDEmployee { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> Discount1 { get; set; } 
        public IRPSCheckbox<DeliveryNoteLineView> CascadeDiscount1 { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> Discount2 { get; set; } 
        public IRPSCheckbox<DeliveryNoteLineView> CascadeDiscount2 { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> Discount3 { get; set; } 
        public IRPSCheckbox<DeliveryNoteLineView> CascadeDiscount3 { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> Discount4 { get; set; } 
        public IRPSCheckbox<DeliveryNoteLineView> CascadeDiscount4 { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> Discount5 { get; set; } 
        public IRPSCheckbox<DeliveryNoteLineView> CascadeDiscount5 { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> AmountDiscount { get; set; } 
        public IRPSComboBox<DeliveryNoteLineView> PositionAmountDiscount { get; set; } 
        public IRPSComboBox<DeliveryNoteLineView> IDSite { get; set; } 
        public IRPSComboBox<DeliveryNoteLineView> IDWarehouse { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> Series { get; set; } 
        public IRPSComboBox<DeliveryNoteLineView> Series1 { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> ExpiryDate { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> PotencyValue { get; set; } 
        public IRPSComboBox<DeliveryNoteLineView> IDSiteTransfer { get; set; } 
        public IRPSComboBox<DeliveryNoteLineView> IDWarehouseTransfer { get; set; } 
        public IRPSCheckbox<DeliveryNoteLineView> Inspectionated { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> InspectionDate { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> QuantityRejected { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> QuantityRejectedSecondUnit { get; set; } 
        public IRPSCheckbox<DeliveryNoteLineView> PendingQuality { get; set; } 
        public IRPSCheckbox<DeliveryNoteLineView> ExcludeForEvaluation { get; set; } 
        public IRPSComboBox<DeliveryNoteLineView> IDVAT { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> PercentVAT { get; set; } 
        public IRPSComboBox<DeliveryNoteLineView> IDVATSurcharge { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> PercentSurcharge { get; set; } 
        public IRPSComboBox<DeliveryNoteLineView> IDDeliveryNoteType { get; set; } 
        public IRPSComboBox<DeliveryNoteLineView> IDReturnCause { get; set; } 
        public IRPSComboBox<DeliveryNoteLineView> UIIDAccount { get; set; } 
        public IRPSComboBox<DeliveryNoteLineView> UIInvestementExpense { get; set; } 
        public IRPSCheckbox<DeliveryNoteLineView> AutoInvoice { get; set; } 
        public IRPSComboBox<DeliveryNoteLineView> UIIDOrderLineKit { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> UICostPercentage { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> UINumProm { get; set; } 
        public IRPSCheckbox<DeliveryNoteLineView> UIRappel { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> UIInternalCode { get; set; } 
        public IRPSComboBox<DeliveryNoteLineView> UIIDMaintenanceComponent { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> UISerialNumber { get; set; } 
        public IRPSComboBox<DeliveryNoteLineView> UIIDProject { get; set; } 
        public IRPSComboBox<DeliveryNoteLineView> UIIDProTask { get; set; } 
        public IRPSComboBox<DeliveryNoteLineView> UIIDProMaterial { get; set; } 
        public IRPSComboBox<DeliveryNoteLineView> UIIDManufacturingOrder { get; set; } 
        public IRPSComboBox<DeliveryNoteLineView> UIIDMOTask { get; set; } 
        public IRPSComboBox<DeliveryNoteLineView> UIIDMOMaterial { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> StructureQuantity { get; set; } 
        public IRPSComboBox<DeliveryNoteLineView> UIIDMaintenanceOrder { get; set; } 
        public IRPSComboBox<DeliveryNoteLineView> UIIDOrderMaterialPrevision { get; set; } 
        public IRPSComboBox<DeliveryNoteLineView> UIIDOrderSL { get; set; } 
        public IRPSComboBox<DeliveryNoteLineView> IDOrderLineSales { get; set; } 
        public IRPSComboBox<DeliveryNoteLineView> IDArticleVersion { get; set; } 
        public IRPSComboBox<DeliveryNoteLineView> UIIDArticleStructure { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> DeliveryCost { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> ImportCost { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> TariffCost { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> PermissionsCost { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> BankingCost { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> OthersCost { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> ExternalCost { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> BaseIntrastat { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> NetMass { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> SupplemetUnit { get; set; } 
        public IRPSCheckbox<DeliveryNoteLineView> Cassation { get; set; } 
        public IRPSComboBox<DeliveryNoteLineView> IDCommercialConcept { get; set; } 
        public IRPSComboBox<DeliveryNoteLineView> IDSupplierCommercialCondition { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> PriceBase { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> UIConditionsPrice { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> UIPriceWihoutConditionsBase { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> PriceWihoutConditions1 { get; set; } 
        public IRPSButton<DeliveryNoteLineView> OrderLineGetDimensionCommandButton { get; set; } 
        public IRPSButton<DeliveryNoteLineView> ExecuteDeliveryNoteLineCommentAddArticleTechnicalDescription { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> Comment { get; set; } 
        public IRPSButton<DeliveryNoteLineView> ExecuteDeliveryNoteLineCommentInvoiceAddArticleTechnicalDescription { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> CommentInvoice { get; set; } 
        public IRPSTextBox<DeliveryNoteLineView> Matchcode { get; set; } 
        public IRPSButton<DeliveryNoteLineView,DirectSeriesDataChildDialogView> DirectSeriesDataChildNavigationCommandButton { get; set; } 
        public IRPSButton<DeliveryNoteLineView,ContainerChildDialogView> ContainerChildNavigationCommandButton { get; set; } 
        public IRPSButton<DeliveryNoteLineView> ImputationMaterialNavigationCommandButton { get; set; } 
        public IRPSButton<DeliveryNoteLineView,AnalyticChildDialogView> AnalyticChildNavigationCommandButton { get; set; } 
        public IRPSButton<DeliveryNoteLineView,LocationChildDialogView> LocationChildNavigationCommandButton { get; set; } 
        public DeliveryNoteLineMovementsCollectionEditor<DeliveryNoteLineView,DeliveryNoteLineMovementView> DeliveryNoteLineMovements { get; set; } 
        public DeliveryNoteLineTaxsCollectionEditor<DeliveryNoteLineView,DeliveryNoteLineMovementView> DeliveryNoteLineTaxs { get; set; } 
        public DeliveryNoteLineConditionsAffectCollectionEditor<DeliveryNoteLineView,DeliveryNoteLineMovementView> DeliveryNoteLineConditionsAffect { get; set; } 
        public DeliveryNoteLineConditionSLsNoAffectCollectionEditor<DeliveryNoteLineView,DeliveryNoteLineMovementView> DeliveryNoteLineConditionSLsNoAffect { get; set; } 
        public OrderLineAnalyticsCollectionEditor<DeliveryNoteLineView,DeliveryNoteLineMovementView> OrderLineAnalytics { get; set; } 
        public IRPSSection<DeliveryNoteLineView> GeneralDataSection { get; set; } 
        public IRPSSection<DeliveryNoteLineView> LocationSection { get; set; } 
        public IRPSSection<DeliveryNoteLineView> TaxSection { get; set; } 
        public IRPSSection<DeliveryNoteLineView> ConditionSectionAffect { get; set; } 
        public IRPSSection<DeliveryNoteLineView> ConditionSectionNoAffect { get; set; } 
        public IRPSSection<DeliveryNoteLineView> AnalitycSection { get; set; } 
        public IRPSSection<DeliveryNoteLineView> CommentSection { get; set; } 
        public IRPSSection<DeliveryNoteLineView> DPS { get; set; } 
        public DeliveryNote Screen { get; set; }
        public DeliveryNoteLineView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DeliveryNoteLineMovementsCollectionEditor<DeliveryNoteLineView,DeliveryNoteLineMovementView>:RPSCollectionEditor<DeliveryNoteLineView,DeliveryNoteLineMovementView> where DeliveryNoteLineView : class, IView where DeliveryNoteLineMovementView : class, IView
    {
        public  DeliveryNoteLineMovementsGridView<DeliveryNoteLineView,DeliveryNoteLineMovementView> GridView {get;set;}
    }
    public partial class DeliveryNoteLineMovementsGridView <DeliveryNoteLineView,DeliveryNoteLineMovementView> :  RPSGridView<DeliveryNoteLineView,DeliveryNoteLineMovementView> where DeliveryNoteLineView : class, IView where DeliveryNoteLineMovementView : class, IView
    {
        public DeliveryNoteLineMovementsGridView(DeliveryNoteLineView currentView,DeliveryNoteLineMovementView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDLocationWarehouse = RPSControlFactory.CreateRPSGridComboBox<DeliveryNoteLineView>("","#b3f2844f-c67f-4165-b97e-0913bafb813f .ag-row[role='row']@ROWINDEX [col-id='cIDLocationWarehouse']","",false, this.CurrentView);
 
            IDLocationWarehouseTrans = RPSControlFactory.CreateRPSGridComboBox<DeliveryNoteLineView>("","#b3f2844f-c67f-4165-b97e-0913bafb813f .ag-row[role='row']@ROWINDEX [col-id='cIDLocationWarehouseTrans']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineView>("","#b3f2844f-c67f-4165-b97e-0913bafb813f .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineView>("","#b3f2844f-c67f-4165-b97e-0913bafb813f .ag-row[role='row']@ROWINDEX [col-id='cQuantitySecondUnit']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<DeliveryNoteLineView> IDLocationWarehouse { get; set; } 
        public IRPSGridComboBox<DeliveryNoteLineView> IDLocationWarehouseTrans { get; set; } 
        public IRPSGridTextBox<DeliveryNoteLineView> Quantity { get; set; } 
        public IRPSGridTextBox<DeliveryNoteLineView> QuantitySecondUnit { get; set; } 
                     
    }
 
        public partial class DeliveryNoteLineTaxsCollectionEditor<DeliveryNoteLineView,DeliveryNoteLineMovementView>:RPSCollectionEditor<DeliveryNoteLineView,DeliveryNoteLineMovementView> where DeliveryNoteLineView : class, IView where DeliveryNoteLineMovementView : class, IView
    {
        public  DeliveryNoteLineTaxsGridView<DeliveryNoteLineView,DeliveryNoteLineMovementView> GridView {get;set;}
    }
    public partial class DeliveryNoteLineTaxsGridView <DeliveryNoteLineView,DeliveryNoteLineMovementView> :  RPSGridView<DeliveryNoteLineView,DeliveryNoteLineMovementView> where DeliveryNoteLineView : class, IView where DeliveryNoteLineMovementView : class, IView
    {
        public DeliveryNoteLineTaxsGridView(DeliveryNoteLineView currentView,DeliveryNoteLineMovementView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDTaxValue = RPSControlFactory.CreateRPSGridComboBox<DeliveryNoteLineView>("","#7f987f14-1615-463c-ae24-2e09d93d2008 .ag-row[role='row']@ROWINDEX [col-id='cIDTaxValue']","",true, this.CurrentView);
 
            ApplicationType = RPSControlFactory.CreateRPSGridEnumComboBox<DeliveryNoteLineView>("","#7f987f14-1615-463c-ae24-2e09d93d2008 .ag-row[role='row']@ROWINDEX [col-id='cApplicationType']","",true, this.CurrentView);
 
            BaseType = RPSControlFactory.CreateRPSGridEnumComboBox<DeliveryNoteLineView>("","#7f987f14-1615-463c-ae24-2e09d93d2008 .ag-row[role='row']@ROWINDEX [col-id='cBaseType']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<DeliveryNoteLineView>("","#7f987f14-1615-463c-ae24-2e09d93d2008 .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            Value = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineView>("","#7f987f14-1615-463c-ae24-2e09d93d2008 .ag-row[role='row']@ROWINDEX [col-id='cValue']","",true, this.CurrentView);
 
            VAT = RPSControlFactory.CreateRPSGridCheckBox<DeliveryNoteLineView>("","#7f987f14-1615-463c-ae24-2e09d93d2008 .ag-row[role='row']@ROWINDEX [col-id='cVAT']","",true, this.CurrentView);
 
            PriceIncluded = RPSControlFactory.CreateRPSGridCheckBox<DeliveryNoteLineView>("","#7f987f14-1615-463c-ae24-2e09d93d2008 .ag-row[role='row']@ROWINDEX [col-id='cPriceIncluded']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<DeliveryNoteLineView> IDTaxValue { get; set; } 
        public IRPSGridComboBox<DeliveryNoteLineView> ApplicationType { get; set; } 
        public IRPSGridComboBox<DeliveryNoteLineView> BaseType { get; set; } 
        public IRPSGridComboBox<DeliveryNoteLineView> Type { get; set; } 
        public IRPSGridTextBox<DeliveryNoteLineView> Value { get; set; } 
        public IRPSGridCheckbox<DeliveryNoteLineView> VAT { get; set; } 
        public IRPSGridCheckbox<DeliveryNoteLineView> PriceIncluded { get; set; } 
                     
    }
 
        public partial class DeliveryNoteLineConditionsAffectCollectionEditor<DeliveryNoteLineView,DeliveryNoteLineMovementView>:RPSCollectionEditor<DeliveryNoteLineView,DeliveryNoteLineMovementView> where DeliveryNoteLineView : class, IView where DeliveryNoteLineMovementView : class, IView
    {
        public  DeliveryNoteLineConditionsAffectGridView<DeliveryNoteLineView,DeliveryNoteLineMovementView> GridView {get;set;}
    }
    public partial class DeliveryNoteLineConditionsAffectGridView <DeliveryNoteLineView,DeliveryNoteLineMovementView> :  RPSGridView<DeliveryNoteLineView,DeliveryNoteLineMovementView> where DeliveryNoteLineView : class, IView where DeliveryNoteLineMovementView : class, IView
    {
        public DeliveryNoteLineConditionsAffectGridView(DeliveryNoteLineView currentView,DeliveryNoteLineMovementView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<DeliveryNoteLineView>("","#3c8bbe28-4e10-4993-8395-a23658b734e9 .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            ConditionValueOriginal = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineView>("","#3c8bbe28-4e10-4993-8395-a23658b734e9 .ag-row[role='row']@ROWINDEX [col-id='cConditionValueOriginal']","",true, this.CurrentView);
 
            ConditionValue = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineView>("","#3c8bbe28-4e10-4993-8395-a23658b734e9 .ag-row[role='row']@ROWINDEX [col-id='cConditionValue']","",true, this.CurrentView);
 
            Base = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineView>("","#3c8bbe28-4e10-4993-8395-a23658b734e9 .ag-row[role='row']@ROWINDEX [col-id='cBase']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineView>("","#3c8bbe28-4e10-4993-8395-a23658b734e9 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            ConditionType = RPSControlFactory.CreateRPSGridEnumComboBox<DeliveryNoteLineView>("","#3c8bbe28-4e10-4993-8395-a23658b734e9 .ag-row[role='row']@ROWINDEX [col-id='cConditionType']","",true, this.CurrentView);
 
            BaseApply = RPSControlFactory.CreateRPSGridEnumComboBox<DeliveryNoteLineView>("","#3c8bbe28-4e10-4993-8395-a23658b734e9 .ag-row[role='row']@ROWINDEX [col-id='cBaseApply']","",true, this.CurrentView);
 
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<DeliveryNoteLineView>("","#3c8bbe28-4e10-4993-8395-a23658b734e9 .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",true, this.CurrentView);
 
            DateTo = RPSControlFactory.CreateRPSGridTextBox<DeliveryNoteLineView>("","#3c8bbe28-4e10-4993-8395-a23658b734e9 .ag-row[role='row']@ROWINDEX [col-id='cDateTo']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<DeliveryNoteLineView> Type { get; set; } 
        public IRPSGridTextBox<DeliveryNoteLineView> ConditionValueOriginal { get; set; } 
        public IRPSGridTextBox<DeliveryNoteLineView> ConditionValue { get; set; } 
        public IRPSGridTextBox<DeliveryNoteLineView> Base { get; set; } 
        public IRPSGridTextBox<DeliveryNoteLineView> Amount { get; set; } 
        public IRPSGridComboBox<DeliveryNoteLineView> ConditionType { get; set; } 
        public IRPSGridComboBox<DeliveryNoteLineView> BaseApply { get; set; } 
        public IRPSGridTextBox<DeliveryNoteLineView> DateFrom { get; set; } 
        public IRPSGridTextBox<DeliveryNoteLineView> DateTo { get; set; } 
                     
    }
 
        public partial class DeliveryNoteLineConditionSLsNoAffectCollectionEditor<DeliveryNoteLineView,DeliveryNoteLineMovementView>:RPSCollectionEditor<DeliveryNoteLineView,DeliveryNoteLineMovementView> where DeliveryNoteLineView : class, IView where DeliveryNoteLineMovementView : class, IView
    {
        public  DeliveryNoteLineConditionSLsNoAffectGridView<DeliveryNoteLineView,DeliveryNoteLineMovementView> GridView {get;set;}
    }
    public partial class DeliveryNoteLineConditionSLsNoAffectGridView <DeliveryNoteLineView,DeliveryNoteLineMovementView> :  RPSGridView<DeliveryNoteLineView,DeliveryNoteLineMovementView> where DeliveryNoteLineView : class, IView where DeliveryNoteLineMovementView : class, IView
    {
        public DeliveryNoteLineConditionSLsNoAffectGridView(DeliveryNoteLineView currentView,DeliveryNoteLineMovementView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<DeliveryNoteLineView>("","#393f6cda-ae92-4bfe-83ae-b445c1f4787e .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            ConditionValueOriginal = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineView>("","#393f6cda-ae92-4bfe-83ae-b445c1f4787e .ag-row[role='row']@ROWINDEX [col-id='cConditionValueOriginal']","",true, this.CurrentView);
 
            ConditionValue = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineView>("","#393f6cda-ae92-4bfe-83ae-b445c1f4787e .ag-row[role='row']@ROWINDEX [col-id='cConditionValue']","",true, this.CurrentView);
 
            Base = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineView>("","#393f6cda-ae92-4bfe-83ae-b445c1f4787e .ag-row[role='row']@ROWINDEX [col-id='cBase']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineView>("","#393f6cda-ae92-4bfe-83ae-b445c1f4787e .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            ConditionType = RPSControlFactory.CreateRPSGridEnumComboBox<DeliveryNoteLineView>("","#393f6cda-ae92-4bfe-83ae-b445c1f4787e .ag-row[role='row']@ROWINDEX [col-id='cConditionType']","",true, this.CurrentView);
 
            BaseApply = RPSControlFactory.CreateRPSGridEnumComboBox<DeliveryNoteLineView>("","#393f6cda-ae92-4bfe-83ae-b445c1f4787e .ag-row[role='row']@ROWINDEX [col-id='cBaseApply']","",true, this.CurrentView);
 
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<DeliveryNoteLineView>("","#393f6cda-ae92-4bfe-83ae-b445c1f4787e .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",true, this.CurrentView);
 
            DateTo = RPSControlFactory.CreateRPSGridTextBox<DeliveryNoteLineView>("","#393f6cda-ae92-4bfe-83ae-b445c1f4787e .ag-row[role='row']@ROWINDEX [col-id='cDateTo']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<DeliveryNoteLineView> Type { get; set; } 
        public IRPSGridTextBox<DeliveryNoteLineView> ConditionValueOriginal { get; set; } 
        public IRPSGridTextBox<DeliveryNoteLineView> ConditionValue { get; set; } 
        public IRPSGridTextBox<DeliveryNoteLineView> Base { get; set; } 
        public IRPSGridTextBox<DeliveryNoteLineView> Amount { get; set; } 
        public IRPSGridComboBox<DeliveryNoteLineView> ConditionType { get; set; } 
        public IRPSGridComboBox<DeliveryNoteLineView> BaseApply { get; set; } 
        public IRPSGridTextBox<DeliveryNoteLineView> DateFrom { get; set; } 
        public IRPSGridTextBox<DeliveryNoteLineView> DateTo { get; set; } 
                     
    }
 
        public partial class OrderLineAnalyticsCollectionEditor<DeliveryNoteLineView,DeliveryNoteLineMovementView>:RPSCollectionEditor<DeliveryNoteLineView,DeliveryNoteLineMovementView> where DeliveryNoteLineView : class, IView where DeliveryNoteLineMovementView : class, IView
    {
        public  OrderLineAnalyticsGridView<DeliveryNoteLineView,DeliveryNoteLineMovementView> GridView {get;set;}
    }
    public partial class OrderLineAnalyticsGridView <DeliveryNoteLineView,DeliveryNoteLineMovementView> :  RPSGridView<DeliveryNoteLineView,DeliveryNoteLineMovementView> where DeliveryNoteLineView : class, IView where DeliveryNoteLineMovementView : class, IView
    {
        public OrderLineAnalyticsGridView(DeliveryNoteLineView currentView,DeliveryNoteLineMovementView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDDimension = RPSControlFactory.CreateRPSGridComboBox<DeliveryNoteLineView>("","#6f293a19-d8b9-4852-8f2a-355f1fc66219 .ag-row[role='row']@ROWINDEX [col-id='cIDDimension']","",true, this.CurrentView);
 
            IDDimValue = RPSControlFactory.CreateRPSGridComboBox<DeliveryNoteLineView>("","#6f293a19-d8b9-4852-8f2a-355f1fc66219 .ag-row[role='row']@ROWINDEX [col-id='cIDDimValue']","",true, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineView>("","#6f293a19-d8b9-4852-8f2a-355f1fc66219 .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineView>("","#6f293a19-d8b9-4852-8f2a-355f1fc66219 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<DeliveryNoteLineView> IDDimension { get; set; } 
        public IRPSGridComboBox<DeliveryNoteLineView> IDDimValue { get; set; } 
        public IRPSGridTextBox<DeliveryNoteLineView> Percentage { get; set; } 
        public IRPSGridTextBox<DeliveryNoteLineView> Amount { get; set; } 
                     
    }
 
    }
  
            
    public partial class DeliveryNoteLineMovementView : View
    {
        public DeliveryNoteLineMovementView(DeliveryNote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<DeliveryNoteLineMovementView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DeliveryNoteLineMovementView,DeliveryNoteLineView>( this,Screen.DeliveryNoteLineView);
 
            BackButton = RPSControlFactory.RPSBackButton<DeliveryNoteLineMovementView,DeliveryNoteLineView>( this,Screen.DeliveryNoteLineView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<DeliveryNoteLineMovementView,DeliveryNoteLineView>( this,Screen.DeliveryNoteLineView);
 
            IDLocationWarehouse = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineMovementView>("8154b2bf-c16d-4f81-b74b-c9b4f45eadb1","","",false, this);
 
            IDLocationWarehouseTrans = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineMovementView>("e1677b43-4b3d-45b1-9d92-3e9dfb98e8e3","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineMovementView>("118e81a2-aed7-4b9d-adae-cc6d6d02a93e","","",true, this);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineMovementView>("f00b68a0-f9c6-4510-97ab-25756b7554dd","","",true, this);
 

        }
        public IRPSButton<DeliveryNoteLineMovementView> DeleteButton { get; set; } 
        public IRPSButton<DeliveryNoteLineMovementView,DeliveryNoteLineView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DeliveryNoteLineMovementView,DeliveryNoteLineView> BackButton { get; set; } 
        public IRPSAcceptButton<DeliveryNoteLineMovementView,DeliveryNoteLineView> AcceptButton { get; set; } 
        public IRPSComboBox<DeliveryNoteLineMovementView> IDLocationWarehouse { get; set; } 
        public IRPSComboBox<DeliveryNoteLineMovementView> IDLocationWarehouseTrans { get; set; } 
        public IRPSTextBox<DeliveryNoteLineMovementView> Quantity { get; set; } 
        public IRPSTextBox<DeliveryNoteLineMovementView> QuantitySecondUnit { get; set; } 
        public DeliveryNote Screen { get; set; }
        public DeliveryNoteLineMovementView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DeliveryNoteLineTaxView : View
    {
        public DeliveryNoteLineTaxView(DeliveryNote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<DeliveryNoteLineTaxView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DeliveryNoteLineTaxView,DeliveryNoteLineView>( this,Screen.DeliveryNoteLineView);
 
            BackButton = RPSControlFactory.RPSBackButton<DeliveryNoteLineTaxView,DeliveryNoteLineView>( this,Screen.DeliveryNoteLineView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<DeliveryNoteLineTaxView,DeliveryNoteLineView>( this,Screen.DeliveryNoteLineView);
 
            IDTaxValue = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineTaxView>("df2426b1-59aa-48c0-b919-758c615887cd","","",true, this);
 
            ApplicationType = RPSControlFactory.CreateRPSEnumComboBox<DeliveryNoteLineTaxView>("178c8d97-7848-411e-83b7-3f6d73a59751","","",true, this);
 
            BaseType = RPSControlFactory.CreateRPSEnumComboBox<DeliveryNoteLineTaxView>("7b54cd6e-f85c-4488-bc09-b632e7c4c321","","",true, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<DeliveryNoteLineTaxView>("d88b8352-765f-4c26-8f32-fdc9a25525ee","","",true, this);
 
            Value = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineTaxView>("811d56ba-9fc8-4ecb-a976-1ffd24450d8b","","",true, this);
 
            PriceIncluded = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteLineTaxView>("6c80ff65-28d5-481b-b2ac-d4da2c497ca1","","",true, this);
 
            VAT = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteLineTaxView>("a0367025-e763-4760-861d-117aebb44d7e","","",true, this);
 

        }
        public IRPSButton<DeliveryNoteLineTaxView> DeleteButton { get; set; } 
        public IRPSButton<DeliveryNoteLineTaxView,DeliveryNoteLineView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DeliveryNoteLineTaxView,DeliveryNoteLineView> BackButton { get; set; } 
        public IRPSAcceptButton<DeliveryNoteLineTaxView,DeliveryNoteLineView> AcceptButton { get; set; } 
        public IRPSComboBox<DeliveryNoteLineTaxView> IDTaxValue { get; set; } 
        public IRPSComboBox<DeliveryNoteLineTaxView> ApplicationType { get; set; } 
        public IRPSComboBox<DeliveryNoteLineTaxView> BaseType { get; set; } 
        public IRPSComboBox<DeliveryNoteLineTaxView> Type { get; set; } 
        public IRPSTextBox<DeliveryNoteLineTaxView> Value { get; set; } 
        public IRPSCheckbox<DeliveryNoteLineTaxView> PriceIncluded { get; set; } 
        public IRPSCheckbox<DeliveryNoteLineTaxView> VAT { get; set; } 
        public DeliveryNote Screen { get; set; }
        public DeliveryNoteLineTaxView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DeliveryNoteLineConditionView : View
    {
        public DeliveryNoteLineConditionView(DeliveryNote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<DeliveryNoteLineConditionView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DeliveryNoteLineConditionView,DeliveryNoteLineView>( this,Screen.DeliveryNoteLineView);
 
            BackButton = RPSControlFactory.RPSBackButton<DeliveryNoteLineConditionView,DeliveryNoteLineView>( this,Screen.DeliveryNoteLineView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<DeliveryNoteLineConditionView,DeliveryNoteLineView>( this,Screen.DeliveryNoteLineView);
 
            ConditionType = RPSControlFactory.CreateRPSEnumComboBox<DeliveryNoteLineConditionView>("30d2b427-ede1-4dfd-91f1-6271c02b6109","","",true, this);
 
            IDSupplierCommercialCondition = RPSControlFactory.CreateRPSComboBox<DeliveryNoteLineConditionView>("e8a56292-fed8-45ad-ab8a-61b2e451f10e","","",true, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<DeliveryNoteLineConditionView>("fd221c9c-0301-44a0-8b2b-9e15dee7c473","","",true, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<DeliveryNoteLineConditionView>("cb062522-c062-4948-b897-506f9fae7af2","","",true, this);
 
            ConditionType1 = RPSControlFactory.CreateRPSEnumComboBox<DeliveryNoteLineConditionView>("891e0b21-8c04-4794-88c4-112616474309","","",true, this);
 
            BaseApply = RPSControlFactory.CreateRPSEnumComboBox<DeliveryNoteLineConditionView>("24e209aa-2bdc-4ea9-9f48-645f225aa0c7","","",true, this);
 
            AffectsPrice = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteLineConditionView>("12a7832a-5ae8-465f-8393-d64800cf508c","","",true, this);
 
            ConditionValueOriginal = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineConditionView>("5d06a1dd-8044-4f5a-9e76-e98a80ab5740","","",true, this);
 
            ConditionValue = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineConditionView>("708eea37-9c4c-4000-b8af-784a2050d678","","",true, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineConditionView>("b1fe7e78-62f3-4d71-8e56-03e72c6cd3de","","",true, this);
 

        }
        public IRPSButton<DeliveryNoteLineConditionView> DeleteButton { get; set; } 
        public IRPSButton<DeliveryNoteLineConditionView,DeliveryNoteLineView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DeliveryNoteLineConditionView,DeliveryNoteLineView> BackButton { get; set; } 
        public IRPSAcceptButton<DeliveryNoteLineConditionView,DeliveryNoteLineView> AcceptButton { get; set; } 
        public IRPSComboBox<DeliveryNoteLineConditionView> ConditionType { get; set; } 
        public IRPSComboBox<DeliveryNoteLineConditionView> IDSupplierCommercialCondition { get; set; } 
        public IRPSTextBox<DeliveryNoteLineConditionView> DateFrom { get; set; } 
        public IRPSTextBox<DeliveryNoteLineConditionView> DateTo { get; set; } 
        public IRPSComboBox<DeliveryNoteLineConditionView> ConditionType1 { get; set; } 
        public IRPSComboBox<DeliveryNoteLineConditionView> BaseApply { get; set; } 
        public IRPSCheckbox<DeliveryNoteLineConditionView> AffectsPrice { get; set; } 
        public IRPSTextBox<DeliveryNoteLineConditionView> ConditionValueOriginal { get; set; } 
        public IRPSTextBox<DeliveryNoteLineConditionView> ConditionValue { get; set; } 
        public IRPSTextBox<DeliveryNoteLineConditionView> Amount { get; set; } 
        public DeliveryNote Screen { get; set; }
        public DeliveryNoteLineConditionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DeliveryNoteVariablePaymentView : View
    {
        public DeliveryNoteVariablePaymentView(DeliveryNote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<DeliveryNoteVariablePaymentView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DeliveryNoteVariablePaymentView,DeliveryNoteLineView>( this,Screen.DeliveryNoteLineView);
 
            BackButton = RPSControlFactory.RPSBackButton<DeliveryNoteVariablePaymentView,DeliveryNoteLineView>( this,Screen.DeliveryNoteLineView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<DeliveryNoteVariablePaymentView,DeliveryNoteLineView>( this,Screen.DeliveryNoteLineView);
 
            NumPayment = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteVariablePaymentView>("aed30da5-56a7-41ad-ad51-94956bf982f9","","",true, this);
 
            DatePayment = RPSControlFactory.CreateRPSTextBox<DeliveryNoteVariablePaymentView>("a9dce4dd-bc17-4f39-97e5-1117c6ecd4bb","","",false, this);
 
            DayPayment = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteVariablePaymentView>("51de1388-bd11-43f0-b43e-4ac5e2a1e5c9","","",false, this);
 
            Percentage = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteVariablePaymentView>("3d68b096-a89c-439e-af85-b7849abf5870","","",false, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteVariablePaymentView>("0bf606ee-a7c8-44d2-a4cc-359c0578a6bd","","",false, this);
 
            Rest = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteVariablePaymentView>("27d39a65-2777-4c0d-ae65-45a207acdeb8","","",true, this);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSComboBox<DeliveryNoteVariablePaymentView>("71aae049-20d3-47d1-9cb7-7a2e08855ec0","","",false, this);
 

        }
        public IRPSButton<DeliveryNoteVariablePaymentView> DeleteButton { get; set; } 
        public IRPSButton<DeliveryNoteVariablePaymentView,DeliveryNoteLineView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DeliveryNoteVariablePaymentView,DeliveryNoteLineView> BackButton { get; set; } 
        public IRPSAcceptButton<DeliveryNoteVariablePaymentView,DeliveryNoteLineView> AcceptButton { get; set; } 
        public IRPSTextBox<DeliveryNoteVariablePaymentView> NumPayment { get; set; } 
        public IRPSTextBox<DeliveryNoteVariablePaymentView> DatePayment { get; set; } 
        public IRPSTextBox<DeliveryNoteVariablePaymentView> DayPayment { get; set; } 
        public IRPSTextBox<DeliveryNoteVariablePaymentView> Percentage { get; set; } 
        public IRPSTextBox<DeliveryNoteVariablePaymentView> Amount { get; set; } 
        public IRPSCheckbox<DeliveryNoteVariablePaymentView> Rest { get; set; } 
        public IRPSComboBox<DeliveryNoteVariablePaymentView> IDPaymentMethod { get; set; } 
        public DeliveryNote Screen { get; set; }
        public DeliveryNoteVariablePaymentView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OrderLineAnalyticView : View
    {
        public OrderLineAnalyticView(DeliveryNote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<OrderLineAnalyticView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<OrderLineAnalyticView,DeliveryNoteLineView>( this,Screen.DeliveryNoteLineView);
 
            BackButton = RPSControlFactory.RPSBackButton<OrderLineAnalyticView,DeliveryNoteLineView>( this,Screen.DeliveryNoteLineView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<OrderLineAnalyticView,DeliveryNoteLineView>( this,Screen.DeliveryNoteLineView);
 
            IDDimension = RPSControlFactory.CreateRPSComboBox<OrderLineAnalyticView>("7fdec94d-8d3f-4626-9554-894c5d5dff79","","",true, this);
 
            IDDimValue = RPSControlFactory.CreateRPSComboBox<OrderLineAnalyticView>("c61a0e82-585f-4702-96d5-b84e92d36803","","",true, this);
 
            Percentage = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineAnalyticView>("1606e8da-d3e0-4a36-a52d-8e143f44da72","","",true, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineAnalyticView>("b80274af-a1de-485f-b793-56626e7b82af","","",true, this);
 

        }
        public IRPSButton<OrderLineAnalyticView> DeleteButton { get; set; } 
        public IRPSButton<OrderLineAnalyticView,DeliveryNoteLineView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<OrderLineAnalyticView,DeliveryNoteLineView> BackButton { get; set; } 
        public IRPSAcceptButton<OrderLineAnalyticView,DeliveryNoteLineView> AcceptButton { get; set; } 
        public IRPSComboBox<OrderLineAnalyticView> IDDimension { get; set; } 
        public IRPSComboBox<OrderLineAnalyticView> IDDimValue { get; set; } 
        public IRPSTextBox<OrderLineAnalyticView> Percentage { get; set; } 
        public IRPSTextBox<OrderLineAnalyticView> Amount { get; set; } 
        public DeliveryNote Screen { get; set; }
        public OrderLineAnalyticView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NewConsumptionChildDialogView : View
    {
        public NewConsumptionChildDialogView(DeliveryNote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDSupplier = RPSControlFactory.CreateRPSComboBox<NewConsumptionChildDialogView>("149bb253-a408-4500-b134-8888e4c9d544","","",true, this);
 
            CodDeliveryNote = RPSControlFactory.CreateRPSTextBox<NewConsumptionChildDialogView>("7fac55e5-5845-44d5-8c59-f18d5999aa8b","","",true, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<NewConsumptionChildDialogView>("f8ee7b0f-dc39-45e8-8d9b-775dbfbbb2d6","","",true, this);
 
            IDWareHouse = RPSControlFactory.CreateRPSComboBox<NewConsumptionChildDialogView>("e1f9360f-2566-45af-8761-00796cfe3370","","",true, this);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<NewConsumptionChildDialogView>("fa5bb26b-16f1-4760-8825-808f34d8539e","","",true, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<NewConsumptionChildDialogView>("6989b4d1-0383-45bb-accd-9341f9c2d08a","","",true, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<NewConsumptionChildDialogView>("a3f4fa0a-1391-440b-9833-0495c061a74e","","",true, this);
 
            DeliveryNoteLastDate = RPSControlFactory.CreateRPSTextBox<NewConsumptionChildDialogView>("dfd9467a-ab11-459c-9f60-53ff8aecdbca","","",false, this);
 
            WarehouseQuantity = RPSControlFactory.CreateRPSOption<NewConsumptionChildDialogView>( "2e7c3267-476e-4d6e-85a4-710f2b76f2c6","","",this);
 
            PurchaseQuantity = RPSControlFactory.CreateRPSOption<NewConsumptionChildDialogView>( "b3aa2c57-65a9-4dbe-9211-bbe969e8d844","","",this);
 

        }
        public IRPSComboBox<NewConsumptionChildDialogView> IDSupplier { get; set; } 
        public IRPSTextBox<NewConsumptionChildDialogView> CodDeliveryNote { get; set; } 
        public IRPSComboBox<NewConsumptionChildDialogView> IDSite { get; set; } 
        public IRPSComboBox<NewConsumptionChildDialogView> IDWareHouse { get; set; } 
        public IRPSComboBox<NewConsumptionChildDialogView> IDDeliveryNoteType { get; set; } 
        public IRPSTextBox<NewConsumptionChildDialogView> DateFrom { get; set; } 
        public IRPSTextBox<NewConsumptionChildDialogView> DateTo { get; set; } 
        public IRPSTextBox<NewConsumptionChildDialogView> DeliveryNoteLastDate { get; set; } 
        public IRPSOption<NewConsumptionChildDialogView> WarehouseQuantity { get; set; } 
        public IRPSOption<NewConsumptionChildDialogView> PurchaseQuantity { get; set; } 
        public DeliveryNote Screen { get; set; }
        public NewConsumptionChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DeliveryFromOrderHeaderChildDialogView : View
    {
        public DeliveryFromOrderHeaderChildDialogView(DeliveryNote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDSupplier = RPSControlFactory.CreateRPSComboBox<DeliveryFromOrderHeaderChildDialogView>("e272ce70-0675-48d3-98dc-eff6b8081065","","",false, this);
 
            CodDeliveryNote = RPSControlFactory.CreateRPSTextBox<DeliveryFromOrderHeaderChildDialogView>("4b4a8425-c560-49de-a295-7968ec12b2e9","","",false, this);
 
            CreateHeader = RPSControlFactory.CreateRPSCheckBox<DeliveryFromOrderHeaderChildDialogView>("18732e9c-7902-456f-b4e7-5f0565bfcce8","","",false, this);
 
            OrderDate = RPSControlFactory.CreateRPSOption<DeliveryFromOrderHeaderChildDialogView>( "5c7f8435-4875-48ef-8036-da582168249e","","",this);
 
            NewDate = RPSControlFactory.CreateRPSOption<DeliveryFromOrderHeaderChildDialogView>( "0d37f45e-57c9-4cf3-9951-a0ac262a468b","","",this);
 
            Date = RPSControlFactory.CreateRPSTextBox<DeliveryFromOrderHeaderChildDialogView>("fd7c7c71-7614-4baa-93e5-fd85bd0b7086","","",false, this);
 

        }
        public IRPSComboBox<DeliveryFromOrderHeaderChildDialogView> IDSupplier { get; set; } 
        public IRPSTextBox<DeliveryFromOrderHeaderChildDialogView> CodDeliveryNote { get; set; } 
        public IRPSCheckbox<DeliveryFromOrderHeaderChildDialogView> CreateHeader { get; set; } 
        public IRPSOption<DeliveryFromOrderHeaderChildDialogView> OrderDate { get; set; } 
        public IRPSOption<DeliveryFromOrderHeaderChildDialogView> NewDate { get; set; } 
        public IRPSTextBox<DeliveryFromOrderHeaderChildDialogView> Date { get; set; } 
        public DeliveryNote Screen { get; set; }
        public DeliveryFromOrderHeaderChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class RecalculateIntrastatChildDialogView : View
    {
        public RecalculateIntrastatChildDialogView(DeliveryNote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<RecalculateIntrastatChildDialogView>("16be7dd6-8588-468f-a3f3-834e210442eb","","",false, this);
 

        }
        public IRPSTextBox<RecalculateIntrastatChildDialogView> Amount { get; set; } 
        public DeliveryNote Screen { get; set; }
        public RecalculateIntrastatChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DeliveryNoteChangesChildDialogView : View
    {
        public DeliveryNoteChangesChildDialogView(DeliveryNote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<DeliveryNoteChangesChildDialogView>("a0f2007e-8122-4b50-bf27-94faebc4d420","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<DeliveryNoteChangesChildDialogView>("ed527045-03d6-404a-afd1-ea6092e468e6","","",false, this);
 
            IDWareHouse = RPSControlFactory.CreateRPSComboBox<DeliveryNoteChangesChildDialogView>("1d1a555d-6c3d-4d04-9c77-0eb50aa539f8","","",false, this);
 
            IDLocationWarehouse = RPSControlFactory.CreateRPSComboBox<DeliveryNoteChangesChildDialogView>("1831de21-d55b-476c-8850-a7dec71196d7","","",false, this);
 
            ChangeWarehouseWithoutLocation = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteChangesChildDialogView>("fc51a8d0-0f8f-4990-ad05-571bd60f4b9c","","",false, this);
 

        }
        public IRPSComboBox<DeliveryNoteChangesChildDialogView> IDDeliveryNoteType { get; set; } 
        public IRPSComboBox<DeliveryNoteChangesChildDialogView> IDSite { get; set; } 
        public IRPSComboBox<DeliveryNoteChangesChildDialogView> IDWareHouse { get; set; } 
        public IRPSComboBox<DeliveryNoteChangesChildDialogView> IDLocationWarehouse { get; set; } 
        public IRPSCheckbox<DeliveryNoteChangesChildDialogView> ChangeWarehouseWithoutLocation { get; set; } 
        public DeliveryNote Screen { get; set; }
        public DeliveryNoteChangesChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PrintDeliveryNoteChildDialogView : View
    {
        public PrintDeliveryNoteChildDialogView(DeliveryNote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIOptSupplier = RPSControlFactory.CreateRPSOption<PrintDeliveryNoteChildDialogView>( "eef9df8a-111d-4685-a47c-31ee2fd2ca61","","",this);
 
            UIOptSelected = RPSControlFactory.CreateRPSOption<PrintDeliveryNoteChildDialogView>( "6050501c-1e67-4063-9fde-b618f994162a","","",this);
 
            UIPrintOptionsIDLanguage = RPSControlFactory.CreateRPSComboBox<PrintDeliveryNoteChildDialogView>("b2565ef9-4d2f-4e70-bf5c-e3b1c00c4a35","","",false, this);
 
            UIPrintSpecificReport = RPSControlFactory.CreateRPSCheckBox<PrintDeliveryNoteChildDialogView>("76e7e36a-206b-4252-9f3b-32de71935b11","","",false, this);
 
            UICodDeliveryNoteReport = RPSControlFactory.CreateRPSComboBox<PrintDeliveryNoteChildDialogView>("9506bad2-9d01-46ed-81da-b07b3269d1f1","","",false, this);
 
            PrintDeliverynoteCommandButton = RPSControlFactory.CreateRPSButton<PrintDeliveryNoteChildDialogView>( "49887e02-35a0-4f95-8f69-fa792592ad4c","","",this);
 
            SendDeliveryNoteByEmailCommandButton = RPSControlFactory.CreateRPSButton<PrintDeliveryNoteChildDialogView>( "2bbe4991-c5cf-4e91-b561-cf690f4e4558","","",this);
 
            SendDeliveryNoteToCustomerEmailCommandButton = RPSControlFactory.CreateRPSButton<PrintDeliveryNoteChildDialogView>( "953de144-0047-491b-8bd5-3380cf49776e","","",this);
 

        }
        public IRPSOption<PrintDeliveryNoteChildDialogView> UIOptSupplier { get; set; } 
        public IRPSOption<PrintDeliveryNoteChildDialogView> UIOptSelected { get; set; } 
        public IRPSComboBox<PrintDeliveryNoteChildDialogView> UIPrintOptionsIDLanguage { get; set; } 
        public IRPSCheckbox<PrintDeliveryNoteChildDialogView> UIPrintSpecificReport { get; set; } 
        public IRPSComboBox<PrintDeliveryNoteChildDialogView> UICodDeliveryNoteReport { get; set; } 
        public IRPSButton<PrintDeliveryNoteChildDialogView> PrintDeliverynoteCommandButton { get; set; } 
        public IRPSButton<PrintDeliveryNoteChildDialogView> SendDeliveryNoteByEmailCommandButton { get; set; } 
        public IRPSButton<PrintDeliveryNoteChildDialogView> SendDeliveryNoteToCustomerEmailCommandButton { get; set; } 
        public DeliveryNote Screen { get; set; }
        public PrintDeliveryNoteChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DeliveryFromOrderChildDialogView : View
    {
        public DeliveryFromOrderChildDialogView(DeliveryNote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SupplierDescription = RPSControlFactory.CreateRPSTextBox<DeliveryFromOrderChildDialogView>("e93e63f1-3464-4e1e-af46-8200678c3e9c","","",false, this);
 
            AllDeliveryNote = RPSControlFactory.CreateRPSOption<DeliveryFromOrderChildDialogView>( "a7bdac82-072d-4f77-aa9f-388e477d1628","","",this);
 
            Manual = RPSControlFactory.CreateRPSOption<DeliveryFromOrderChildDialogView>( "5179da65-9f8d-41e2-86f7-339cc5161da3","","",this);
 
            IDOrder = RPSControlFactory.CreateRPSComboBox<DeliveryFromOrderChildDialogView>("e0235b41-41b3-4916-98e6-bb914e16b4df","","",false, this);
 
            OnlyPendingLines = RPSControlFactory.CreateRPSCheckBox<DeliveryFromOrderChildDialogView>("f5994dd5-4ced-495e-b680-beedab153f77","","",false, this);
 
            CollectionInit params_OrderLinesForDeliveryNote = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5e5120c2-670a-4fb4-b456-9591accba8e8",CSSSelectorGrid="",XPathGrid=""};
            OrderLinesForDeliveryNote = RPSControlFactory.RPSCreateCollectionWithGrid<OrderLinesForDeliveryNoteCollectionEditor<DeliveryFromOrderChildDialogView,SeriesDataChildDialogView>,DeliveryFromOrderChildDialogView,SeriesDataChildDialogView>( params_OrderLinesForDeliveryNote,this,Screen.SeriesDataChildDialogView);
 

        }
        public IRPSTextBox<DeliveryFromOrderChildDialogView> SupplierDescription { get; set; } 
        public IRPSOption<DeliveryFromOrderChildDialogView> AllDeliveryNote { get; set; } 
        public IRPSOption<DeliveryFromOrderChildDialogView> Manual { get; set; } 
        public IRPSComboBox<DeliveryFromOrderChildDialogView> IDOrder { get; set; } 
        public IRPSCheckbox<DeliveryFromOrderChildDialogView> OnlyPendingLines { get; set; } 
        public OrderLinesForDeliveryNoteCollectionEditor<DeliveryFromOrderChildDialogView,SeriesDataChildDialogView> OrderLinesForDeliveryNote { get; set; } 
        public DeliveryNote Screen { get; set; }
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
            OrderLine_Ordenation = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryFromOrderChildDialogView>("","#5e5120c2-670a-4fb4-b456-9591accba8e8 .ag-row[role='row']@ROWINDEX [col-id='cOrderLine_Ordenation']","",false, this.CurrentView);
 
            OrderLine_Description = RPSControlFactory.CreateRPSGridTextBox<DeliveryFromOrderChildDialogView>("","#5e5120c2-670a-4fb4-b456-9591accba8e8 .ag-row[role='row']@ROWINDEX [col-id='cOrderLine_Description']","",false, this.CurrentView);
 
            QuantityPending = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryFromOrderChildDialogView>("","#5e5120c2-670a-4fb4-b456-9591accba8e8 .ag-row[role='row']@ROWINDEX [col-id='cQuantityPending']","",false, this.CurrentView);
 
            QuantityToReceived = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryFromOrderChildDialogView>("","#5e5120c2-670a-4fb4-b456-9591accba8e8 .ag-row[role='row']@ROWINDEX [col-id='cQuantityToReceived']","",false, this.CurrentView);
 
            QuantityPendingStructure = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryFromOrderChildDialogView>("","#5e5120c2-670a-4fb4-b456-9591accba8e8 .ag-row[role='row']@ROWINDEX [col-id='cQuantityPendingStructure']","",false, this.CurrentView);
 
            QuantityToReceivedStructure = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryFromOrderChildDialogView>("","#5e5120c2-670a-4fb4-b456-9591accba8e8 .ag-row[role='row']@ROWINDEX [col-id='cQuantityToReceivedStructure']","",false, this.CurrentView);
 
            DeliveryNoteLineManualCommand = RPSControlFactory.CreateRPSGridButton<DeliveryFromOrderChildDialogView>( "","#5e5120c2-670a-4fb4-b456-9591accba8e8 .ag-row[role='row']@ROWINDEX [col-id='cDeliveryNoteLineManualCommand']","",this.CurrentView);
 
            QuantityDelivery = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryFromOrderChildDialogView>("","#5e5120c2-670a-4fb4-b456-9591accba8e8 .ag-row[role='row']@ROWINDEX [col-id='cQuantityDelivery']","",false, this.CurrentView);
 
            eCompleted = RPSControlFactory.CreateRPSGridEnumComboBox<DeliveryFromOrderChildDialogView>("","#5e5120c2-670a-4fb4-b456-9591accba8e8 .ag-row[role='row']@ROWINDEX [col-id='ceCompleted']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<DeliveryFromOrderChildDialogView> OrderLine_Ordenation { get; set; } 
        public IRPSGridTextBox<DeliveryFromOrderChildDialogView> OrderLine_Description { get; set; } 
        public IRPSGridTextBox<DeliveryFromOrderChildDialogView> QuantityPending { get; set; } 
        public IRPSGridTextBox<DeliveryFromOrderChildDialogView> QuantityToReceived { get; set; } 
        public IRPSGridTextBox<DeliveryFromOrderChildDialogView> QuantityPendingStructure { get; set; } 
        public IRPSGridTextBox<DeliveryFromOrderChildDialogView> QuantityToReceivedStructure { get; set; } 
        public IRPSGridButton<DeliveryFromOrderChildDialogView> DeliveryNoteLineManualCommand { get; set; } 
        public IRPSGridTextBox<DeliveryFromOrderChildDialogView> QuantityDelivery { get; set; } 
        public IRPSGridComboBox<DeliveryFromOrderChildDialogView> eCompleted { get; set; } 
                     
    }
 
    }
  
            
    public partial class ArticleGenericChildDialogView : View
    {
        public ArticleGenericChildDialogView(DeliveryNote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_ArticleGetAttributeValues = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1aa2d9ee-42bd-4337-bbe5-1cfc4f800c2c",CSSSelectorGrid="",XPathGrid=""};
            ArticleGetAttributeValues = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleGetAttributeValuesCollectionEditor<ArticleGenericChildDialogView>,ArticleGenericChildDialogView>( params_ArticleGetAttributeValues,this);
 

        }
        public ArticleGetAttributeValuesCollectionEditor<ArticleGenericChildDialogView> ArticleGetAttributeValues { get; set; } 
        public DeliveryNote Screen { get; set; }
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
            Attribute1 = RPSControlFactory.CreateRPSGridTextBox<ArticleGenericChildDialogView>("","#1aa2d9ee-42bd-4337-bbe5-1cfc4f800c2c .ag-row[role='row']@ROWINDEX [col-id='cAttribute1']","",false, this.CurrentView);
 
            Attribute2 = RPSControlFactory.CreateRPSGridTextBox<ArticleGenericChildDialogView>("","#1aa2d9ee-42bd-4337-bbe5-1cfc4f800c2c .ag-row[role='row']@ROWINDEX [col-id='cAttribute2']","",false, this.CurrentView);
 
            Attribute3 = RPSControlFactory.CreateRPSGridTextBox<ArticleGenericChildDialogView>("","#1aa2d9ee-42bd-4337-bbe5-1cfc4f800c2c .ag-row[role='row']@ROWINDEX [col-id='cAttribute3']","",false, this.CurrentView);
 
            quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<ArticleGenericChildDialogView>("","#1aa2d9ee-42bd-4337-bbe5-1cfc4f800c2c .ag-row[role='row']@ROWINDEX [col-id='cquantity']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ArticleGenericChildDialogView> Attribute1 { get; set; } 
        public IRPSGridTextBox<ArticleGenericChildDialogView> Attribute2 { get; set; } 
        public IRPSGridTextBox<ArticleGenericChildDialogView> Attribute3 { get; set; } 
        public IRPSGridTextBox<ArticleGenericChildDialogView> quantity { get; set; } 
                     
    }
 
    }
  
            
    public partial class RecalculateCostChildDialogView : View
    {
        public RecalculateCostChildDialogView(DeliveryNote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ChkDeliveryCost = RPSControlFactory.CreateRPSCheckBox<RecalculateCostChildDialogView>("f4e32204-16ac-4bb9-bdeb-dc4fdb2c77ff","","",false, this);
 
            Porcent = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "d3f5744a-2e52-4bcf-9816-96a1dc5d0ac6","","",this);
 
            Amount = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "05585c30-323f-463a-a7c3-2fd30fa77827","","",this);
 
            DeliveryCostQuantity = RPSControlFactory.CreateRPSFormattedTextBox<RecalculateCostChildDialogView>("bcd56ee6-2c4d-4af2-9f3d-fbfe14740edf","","",false, this);
 
            LineAmount = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "191db912-b2d3-4cad-bafe-24a88e64ebe7","","",this);
 
            Quantity = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "0fd5f0ee-618f-4d78-9f1f-3eb1c5fddee6","","",this);
 
            NetWeight = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "4eae9b24-5aa0-4ff6-87dd-c07ffbf8a605","","",this);
 
            GrossWeight = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "07cd4b4f-6ad3-486c-a9a5-d1a8ade2fff0","","",this);
 
            PositiveAmountPor = RPSControlFactory.CreateRPSCheckBox<RecalculateCostChildDialogView>("14f5fd0b-5052-4f65-8c2f-d0a56bf22ffa","","",false, this);
 
            OnlyArticlesPor = RPSControlFactory.CreateRPSCheckBox<RecalculateCostChildDialogView>("2d21e592-0e5a-4909-a48f-a6590aa82b3d","","",false, this);
 
            ChkImportCost = RPSControlFactory.CreateRPSCheckBox<RecalculateCostChildDialogView>("1c5dfc6c-d225-4129-ad1e-fce4c317f88c","","",false, this);
 
            Porcent1 = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "733189b5-7be4-4c9f-bc96-328b72b1640f","","",this);
 
            Amount1 = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "b88a29b6-dbbf-4ec2-b81f-748d3e0c0ac7","","",this);
 
            ImportCostQuantity = RPSControlFactory.CreateRPSFormattedTextBox<RecalculateCostChildDialogView>("7d879283-ce35-45eb-8577-3f1616e77617","","",false, this);
 
            LineAmount1 = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "1d72da56-243a-4bec-acb3-0b99458a4b70","","",this);
 
            Quantity1 = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "9897343c-a4d4-4d67-8c89-91db3856496c","","",this);
 
            NetWeight1 = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "ec5dfbac-d01c-413a-aac2-64cf3339b06e","","",this);
 
            GrossWeight1 = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "4055ae83-253d-48e1-9c6f-6c15e46c9b8c","","",this);
 
            PositiveAmountImpor = RPSControlFactory.CreateRPSCheckBox<RecalculateCostChildDialogView>("942ecb70-8754-44c8-b7e6-ca109e344a15","","",false, this);
 
            OnlyArticlesImpor = RPSControlFactory.CreateRPSCheckBox<RecalculateCostChildDialogView>("d0ec98e1-245a-4d21-b101-20dafe8181df","","",false, this);
 
            ChkTariffCost = RPSControlFactory.CreateRPSCheckBox<RecalculateCostChildDialogView>("94f97770-335c-40e1-8adf-f2ef7770620c","","",false, this);
 
            Porcent2 = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "ec9aaa42-be31-48a5-b8cc-4bb5cff6584b","","",this);
 
            Amount2 = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "ec62ef2c-2d77-4b11-baf7-39016dce2738","","",this);
 
            TariffCostQuantity = RPSControlFactory.CreateRPSFormattedTextBox<RecalculateCostChildDialogView>("001e9c6e-8cb1-4477-be29-838c76360684","","",false, this);
 
            LineAmount2 = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "0deb2cb6-f6f7-46f1-8bbc-6bb4e0e33595","","",this);
 
            Quantity2 = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "14e4f4bd-7dba-4b63-91f4-5ecad6277326","","",this);
 
            NetWeight2 = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "de4d1e36-5ec7-46ad-a771-1794ea706b78","","",this);
 
            GrossWeight2 = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "7c5902fc-cdee-40f1-8d07-d084fc1e3784","","",this);
 
            PositiveAmountTarif = RPSControlFactory.CreateRPSCheckBox<RecalculateCostChildDialogView>("0e204504-1d91-4d30-9ff1-19beb7375edc","","",false, this);
 
            OnlyArticlesTarif = RPSControlFactory.CreateRPSCheckBox<RecalculateCostChildDialogView>("6f2f409d-d421-4558-88aa-8d341495d569","","",false, this);
 

        }
        public IRPSCheckbox<RecalculateCostChildDialogView> ChkDeliveryCost { get; set; } 
        public IRPSOption<RecalculateCostChildDialogView> Porcent { get; set; } 
        public IRPSOption<RecalculateCostChildDialogView> Amount { get; set; } 
        public IRPSTextBox<RecalculateCostChildDialogView> DeliveryCostQuantity { get; set; } 
        public IRPSOption<RecalculateCostChildDialogView> LineAmount { get; set; } 
        public IRPSOption<RecalculateCostChildDialogView> Quantity { get; set; } 
        public IRPSOption<RecalculateCostChildDialogView> NetWeight { get; set; } 
        public IRPSOption<RecalculateCostChildDialogView> GrossWeight { get; set; } 
        public IRPSCheckbox<RecalculateCostChildDialogView> PositiveAmountPor { get; set; } 
        public IRPSCheckbox<RecalculateCostChildDialogView> OnlyArticlesPor { get; set; } 
        public IRPSCheckbox<RecalculateCostChildDialogView> ChkImportCost { get; set; } 
        public IRPSOption<RecalculateCostChildDialogView> Porcent1 { get; set; } 
        public IRPSOption<RecalculateCostChildDialogView> Amount1 { get; set; } 
        public IRPSTextBox<RecalculateCostChildDialogView> ImportCostQuantity { get; set; } 
        public IRPSOption<RecalculateCostChildDialogView> LineAmount1 { get; set; } 
        public IRPSOption<RecalculateCostChildDialogView> Quantity1 { get; set; } 
        public IRPSOption<RecalculateCostChildDialogView> NetWeight1 { get; set; } 
        public IRPSOption<RecalculateCostChildDialogView> GrossWeight1 { get; set; } 
        public IRPSCheckbox<RecalculateCostChildDialogView> PositiveAmountImpor { get; set; } 
        public IRPSCheckbox<RecalculateCostChildDialogView> OnlyArticlesImpor { get; set; } 
        public IRPSCheckbox<RecalculateCostChildDialogView> ChkTariffCost { get; set; } 
        public IRPSOption<RecalculateCostChildDialogView> Porcent2 { get; set; } 
        public IRPSOption<RecalculateCostChildDialogView> Amount2 { get; set; } 
        public IRPSTextBox<RecalculateCostChildDialogView> TariffCostQuantity { get; set; } 
        public IRPSOption<RecalculateCostChildDialogView> LineAmount2 { get; set; } 
        public IRPSOption<RecalculateCostChildDialogView> Quantity2 { get; set; } 
        public IRPSOption<RecalculateCostChildDialogView> NetWeight2 { get; set; } 
        public IRPSOption<RecalculateCostChildDialogView> GrossWeight2 { get; set; } 
        public IRPSCheckbox<RecalculateCostChildDialogView> PositiveAmountTarif { get; set; } 
        public IRPSCheckbox<RecalculateCostChildDialogView> OnlyArticlesTarif { get; set; } 
        public DeliveryNote Screen { get; set; }
        public RecalculateCostChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NewFromSalesDialogView : View
    {
        public NewFromSalesDialogView(DeliveryNote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CodCompanySales = RPSControlFactory.CreateRPSComboBox<NewFromSalesDialogView>("2f6e7020-a877-4897-88a5-fb23529abbd1","","",false, this);
 
            IDDeliveryNoteSL = RPSControlFactory.CreateRPSComboBox<NewFromSalesDialogView>("41299df6-1d96-4c72-aaf4-b86677734fe2","","",false, this);
 
            CodDeliveryNote = RPSControlFactory.CreateRPSTextBox<NewFromSalesDialogView>("14613246-81f8-48c4-8d1f-6fe6a874fae3","","",false, this);
 
            DeliveryNoteDate = RPSControlFactory.CreateRPSTextBox<NewFromSalesDialogView>("69d0d2f6-9283-4a90-a4c5-b847438d049f","","",false, this);
 

        }
        public IRPSComboBox<NewFromSalesDialogView> CodCompanySales { get; set; } 
        public IRPSComboBox<NewFromSalesDialogView> IDDeliveryNoteSL { get; set; } 
        public IRPSTextBox<NewFromSalesDialogView> CodDeliveryNote { get; set; } 
        public IRPSTextBox<NewFromSalesDialogView> DeliveryNoteDate { get; set; } 
        public DeliveryNote Screen { get; set; }
        public NewFromSalesDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SeriesDataChildDialogView : View
    {
        public SeriesDataChildDialogView(DeliveryNote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSComboBox<SeriesDataChildDialogView>("23f783f9-7188-4d5a-b1e2-5edb6a693cda","","",false, this);
 
            Prefix = RPSControlFactory.CreateRPSTextBox<SeriesDataChildDialogView>("90b619f6-039f-43e1-9de6-40254abe55a7","","",false, this);
 
            StartNumberString = RPSControlFactory.CreateRPSTextBox<SeriesDataChildDialogView>("0c283d4a-cf1c-442c-a893-fea508d47d36","","",false, this);
 
            Suffix = RPSControlFactory.CreateRPSTextBox<SeriesDataChildDialogView>("a7a28917-e177-46f2-b389-0c0b57110003","","",false, this);
 
            EndNumberString = RPSControlFactory.CreateRPSTextBox<SeriesDataChildDialogView>("ed5e38e1-05cd-44ca-bffa-2ee561dbe4e1","","",false, this);
 
            GenerateSeriesCommand = RPSControlFactory.CreateRPSButton<SeriesDataChildDialogView>( "a662cc2b-8cb0-4dd0-b020-7a84c4ccf9e1","","",this);
 
            CollectionInit params_SeriesDataItemlCollection = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="439af28a-090a-481b-9602-722dd2b76722",CSSSelectorGrid="",XPathGrid=""};
            SeriesDataItemlCollection = RPSControlFactory.RPSCreateCollectionWithGrid<SeriesDataItemlCollectionCollectionEditor<SeriesDataChildDialogView>,SeriesDataChildDialogView>( params_SeriesDataItemlCollection,this);
 

        }
        public IRPSComboBox<SeriesDataChildDialogView> IDArticle { get; set; } 
        public IRPSTextBox<SeriesDataChildDialogView> Prefix { get; set; } 
        public IRPSTextBox<SeriesDataChildDialogView> StartNumberString { get; set; } 
        public IRPSTextBox<SeriesDataChildDialogView> Suffix { get; set; } 
        public IRPSTextBox<SeriesDataChildDialogView> EndNumberString { get; set; } 
        public IRPSButton<SeriesDataChildDialogView> GenerateSeriesCommand { get; set; } 
        public SeriesDataItemlCollectionCollectionEditor<SeriesDataChildDialogView> SeriesDataItemlCollection { get; set; } 
        public DeliveryNote Screen { get; set; }
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
            Series = RPSControlFactory.CreateRPSGridTextBox<SeriesDataChildDialogView>("","#439af28a-090a-481b-9602-722dd2b76722 .ag-row[role='row']@ROWINDEX [col-id='cSeries']","",false, this.CurrentView);
 
            SeriesCombo = RPSControlFactory.CreateRPSGridEnumComboBox<SeriesDataChildDialogView>("","#439af28a-090a-481b-9602-722dd2b76722 .ag-row[role='row']@ROWINDEX [col-id='cSeriesCombo']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<SeriesDataChildDialogView>("","#439af28a-090a-481b-9602-722dd2b76722 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSGridFormattedTextBox<SeriesDataChildDialogView>("","#439af28a-090a-481b-9602-722dd2b76722 .ag-row[role='row']@ROWINDEX [col-id='cQuantitySecondUnit']","",false, this.CurrentView);
 
            ExpiryDate = RPSControlFactory.CreateRPSGridTextBox<SeriesDataChildDialogView>("","#439af28a-090a-481b-9602-722dd2b76722 .ag-row[role='row']@ROWINDEX [col-id='cExpiryDate']","",false, this.CurrentView);
 
            IDArticleContainer = RPSControlFactory.CreateRPSGridComboBox<SeriesDataChildDialogView>("","#439af28a-090a-481b-9602-722dd2b76722 .ag-row[role='row']@ROWINDEX [col-id='cIDArticleContainer']","",false, this.CurrentView);
 
            QuantityContainer = RPSControlFactory.CreateRPSGridFormattedTextBox<SeriesDataChildDialogView>("","#439af28a-090a-481b-9602-722dd2b76722 .ag-row[role='row']@ROWINDEX [col-id='cQuantityContainer']","",false, this.CurrentView);
 
            QuantitySecondUnitContainer = RPSControlFactory.CreateRPSGridFormattedTextBox<SeriesDataChildDialogView>("","#439af28a-090a-481b-9602-722dd2b76722 .ag-row[role='row']@ROWINDEX [col-id='cQuantitySecondUnitContainer']","",false, this.CurrentView);
 
            PotencyValue = RPSControlFactory.CreateRPSGridFormattedTextBox<SeriesDataChildDialogView>("","#439af28a-090a-481b-9602-722dd2b76722 .ag-row[role='row']@ROWINDEX [col-id='cPotencyValue']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SeriesDataChildDialogView> Series { get; set; } 
        public IRPSGridComboBox<SeriesDataChildDialogView> SeriesCombo { get; set; } 
        public IRPSGridTextBox<SeriesDataChildDialogView> Quantity { get; set; } 
        public IRPSGridTextBox<SeriesDataChildDialogView> QuantitySecondUnit { get; set; } 
        public IRPSGridTextBox<SeriesDataChildDialogView> ExpiryDate { get; set; } 
        public IRPSGridComboBox<SeriesDataChildDialogView> IDArticleContainer { get; set; } 
        public IRPSGridTextBox<SeriesDataChildDialogView> QuantityContainer { get; set; } 
        public IRPSGridTextBox<SeriesDataChildDialogView> QuantitySecondUnitContainer { get; set; } 
        public IRPSGridTextBox<SeriesDataChildDialogView> PotencyValue { get; set; } 
                     
    }
 
    }
  
            
    public partial class InvoiceChildDialogView : View
    {
        public InvoiceChildDialogView(DeliveryNote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CodInvoice = RPSControlFactory.CreateRPSTextBox<InvoiceChildDialogView>("ff3d9adf-a1e0-4511-9972-b6073b894ff5","","",false, this);
 
            InvoiceDate = RPSControlFactory.CreateRPSTextBox<InvoiceChildDialogView>("0f0253db-0142-4e81-a52c-f4d56e6aac93","","",false, this);
 
            AccountingDate = RPSControlFactory.CreateRPSTextBox<InvoiceChildDialogView>("4ebca108-76d4-4450-807e-d6cd253cb77e","","",false, this);
 
            DUA = RPSControlFactory.CreateRPSCheckBox<InvoiceChildDialogView>("1fb24340-5528-4bca-82b3-636e4e8adb52","","",false, this);
 
            DUADate = RPSControlFactory.CreateRPSTextBox<InvoiceChildDialogView>("c6b4678a-2ee5-4d28-ac6e-8f752f35f0d0","","",false, this);
 
            DUANumber = RPSControlFactory.CreateRPSTextBox<InvoiceChildDialogView>("aee066df-0610-4074-95a9-6164897e39fa","","",false, this);
 
            DUAVATBase = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceChildDialogView>("aa671a38-0f2a-4d06-8f4b-78d9e401ba0b","","",false, this);
 
            DUAIDVAT = RPSControlFactory.CreateRPSComboBox<InvoiceChildDialogView>("fa200e40-4df8-4290-8858-4d682a9bd16e","","",false, this);
 
            DUAIDAccount = RPSControlFactory.CreateRPSComboBox<InvoiceChildDialogView>("7f8cde80-7929-47bd-b69b-db0fc3d4789a","","",false, this);
 

        }
        public IRPSTextBox<InvoiceChildDialogView> CodInvoice { get; set; } 
        public IRPSTextBox<InvoiceChildDialogView> InvoiceDate { get; set; } 
        public IRPSTextBox<InvoiceChildDialogView> AccountingDate { get; set; } 
        public IRPSCheckbox<InvoiceChildDialogView> DUA { get; set; } 
        public IRPSTextBox<InvoiceChildDialogView> DUADate { get; set; } 
        public IRPSTextBox<InvoiceChildDialogView> DUANumber { get; set; } 
        public IRPSTextBox<InvoiceChildDialogView> DUAVATBase { get; set; } 
        public IRPSComboBox<InvoiceChildDialogView> DUAIDVAT { get; set; } 
        public IRPSComboBox<InvoiceChildDialogView> DUAIDAccount { get; set; } 
        public DeliveryNote Screen { get; set; }
        public InvoiceChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class InvoiceView : View
    {
        public InvoiceView(DeliveryNote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<InvoiceView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<InvoiceView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<InvoiceView,InvoiceChildDialogView>( this,Screen.InvoiceChildDialogView);
 
            BackButton = RPSControlFactory.RPSBackButton<InvoiceView,InvoiceChildDialogView>( this,Screen.InvoiceChildDialogView);
 
            CompanyName = RPSControlFactory.CreateRPSTextBox<InvoiceView>("5321109a-27a8-41c4-bb2e-142e826de6b3","","",false, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<InvoiceView>("40ed3beb-cf1f-4b60-808c-14cb896cdff0","","",false, this);
 
            TotalCalc = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("5ad6be59-2337-4fdd-b009-d10f7accefb3","","",false, this);
 
            PrintInvoice = RPSControlFactory.CreateRPSCheckBox<InvoiceView>("5527fd32-1d7d-499d-9f5e-72d49e285db0","","",false, this);
 
            TotalInvoice = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("d4f8a9ad-5dcc-4990-bc51-ef57b53df7c9","","",true, this);
 
            TotalBase = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("97437cfa-36fd-4ebb-8ea2-77e54379906b","","",false, this);
 
            VATAmount = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("b8d1e8aa-b3cf-452d-aa93-508e9148110d","","",true, this);
 
            SurchargeAmount = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("2f80f2bf-8c15-4c0f-9f96-e8ef300a0a18","","",true, this);
 
            TotalTaxInvoice = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("f5f1efd1-b457-4748-928c-4b55c42c19e0","","",false, this);
 
            FinancialSurchargeAmount = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("bfe2cb21-9dfe-4ff6-b72b-531802c67dd0","","",true, this);
 
            Discount1 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("cd4c8c22-306a-4f99-ad48-e53ada245bbb","","",true, this);
 
            Discount2 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("73c34e23-186a-45ba-bcc2-9cd94f7c78b0","","",true, this);
 
            Discount3 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("5d5f2031-4200-4808-adbe-8cf7a6270091","","",true, this);
 
            FinancialSurcharge = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("fd7460f6-e3fb-4d9c-b8d5-9db07caa1042","","",true, this);
 
            CashDiscount = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("d166852c-9873-489a-8c55-301400124d1d","","",true, this);
 
            Transport = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("469e4efb-2eac-46dc-a141-58a9a09cba06","","",true, this);
 
            RetentionPercent = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("952f9557-6dee-4cd9-bbaf-4f707a477c24","","",true, this);
 
            Retention = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("33a3a276-63af-4eee-a2e1-c3da57584d91","","",true, this);
 
            NotNotUpdateMovements = RPSControlFactory.CreateRPSCheckBox<InvoiceView>("a774fe2c-0d58-40eb-91e2-d061b55ee59e","","",false, this);
 
            TotalLinesInvoiceCompany = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("e7662105-d796-40fc-9ffe-79c81fc42948","","",false, this);
 
            TotalLinesDeliveyCompany = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("a51d4809-ac6a-4d56-9fd2-e08872a6e843","","",false, this);
 
            TotalLinesBalance = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("085f5be7-9a11-4250-8a03-de389456f996","","",false, this);
 
            VATBase1 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("793e730f-5151-4b89-8939-ecec4986d09f","","",true, this);
 
            VATBase2 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("5565fae3-d946-4a12-9a96-32a67ce438ea","","",true, this);
 
            VATBase3 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("df26f2cb-7f75-4491-a3d9-0ac3ef653c48","","",true, this);
 
            VATBase4 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("3599344b-64b0-47f7-a7d9-81ff0d4002b4","","",true, this);
 
            VATBase5 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("5b207dc9-7ec4-4086-820b-05a4cd17a21f","","",true, this);
 
            VATBase6 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("8dd4b4cd-131c-448a-9160-767abcf46405","","",true, this);
 
            VATAmount1 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("b826348b-6e8d-4902-acba-c72a162ce384","","",true, this);
 
            VATAmount2 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("95cd8f8d-a711-49eb-8885-357c660675ae","","",true, this);
 
            VATAmount3 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("9031e1a8-fe2f-4fd3-aa5b-ec2612cf5d71","","",true, this);
 
            VATAmount4 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("be90a161-4d84-4a12-9a8e-f5cce1e6cba7","","",true, this);
 
            VATAmount5 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("989b1140-601c-49a5-a30a-168dc9f0582e","","",true, this);
 
            VATAmount6 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("92f2666f-e082-4ae2-961d-06dabaa8bb03","","",true, this);
 
            SurchargeAmount1 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("83b168bf-5216-4f18-9927-5719c2a9e85c","","",true, this);
 
            SurchargeAmount2 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("4070b448-6081-4ad3-9c6a-94f470dbaca6","","",true, this);
 
            SurchargeAmount3 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("57c8d6f3-2032-49ef-bb38-f1260b808eed","","",true, this);
 
            SurchargeAmount4 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("be56f611-c25b-4bd3-b6e1-b39b0153939c","","",true, this);
 
            SurchargeAmount5 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("b786cbc1-ad38-4123-a749-d69fd2a4497e","","",true, this);
 
            SurchargeAmount6 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceView>("ef61be4d-fd60-4306-b8b5-afc4e2169f1a","","",true, this);
 
            Optionscreen = RPSControlFactory.CreateRPSOption<InvoiceView>( "430805bf-c62b-49fe-81e5-878f79326970","","",this);
 
            OptionMail = RPSControlFactory.CreateRPSOption<InvoiceView>( "5bf91a9c-b5d9-46d1-b6d9-e71083a405ab","","",this);
 
            UIOptSupplier = RPSControlFactory.CreateRPSOption<InvoiceView>( "491cedba-737c-430d-8eea-a2ac5aea83b6","","",this);
 
            UIOptSelected = RPSControlFactory.CreateRPSOption<InvoiceView>( "711dbc25-4981-4bcc-b004-e27393fefc27","","",this);
 
            UIPrintOptionsIDLanguage = RPSControlFactory.CreateRPSComboBox<InvoiceView>("d85bd4c7-7853-4ce1-b089-f08f2d7d13a6","","",false, this);
 
            UIPrintSpecificReport = RPSControlFactory.CreateRPSCheckBox<InvoiceView>("85c5ece1-88bc-4594-8065-fda9dda74a4f","","",false, this);
 
            IDCustomReport = RPSControlFactory.CreateRPSComboBox<InvoiceView>("0db9aaf2-fcbc-4773-b52a-44b720f3edf5","","",false, this);
 
            CollectionInit params_InvoicePayments = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="274d3912-1d5a-4f56-abf0-075aca0dd6a7",CSSSelectorGrid="",XPathGrid=""};
            InvoicePayments = RPSControlFactory.RPSCreateCollectionWithGrid<InvoicePaymentsCollectionEditor<InvoiceView>,InvoiceView>( params_InvoicePayments,this);
 
            CollectionInit params_GetACCTransactionsTempFromPurchase = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="33ef81af-01c2-4ff2-96f7-5e08fa39a64e",CSSSelectorGrid="",XPathGrid=""};
            GetACCTransactionsTempFromPurchase = RPSControlFactory.RPSCreateCollectionWithGrid<GetACCTransactionsTempFromPurchaseCollectionEditor<InvoiceView>,InvoiceView>( params_GetACCTransactionsTempFromPurchase,this);
 
            CollectionInit params_GetACCTransactionsTempAnalyticFromPurchase = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="90f71e07-06e8-4bdc-9a4e-9d795c9916de",CSSSelectorGrid="",XPathGrid=""};
            GetACCTransactionsTempAnalyticFromPurchase = RPSControlFactory.RPSCreateCollectionWithGrid<GetACCTransactionsTempAnalyticFromPurchaseCollectionEditor<InvoiceView>,InvoiceView>( params_GetACCTransactionsTempAnalyticFromPurchase,this);
 
            Section = RPSControlFactory.CreateRPSSection<InvoiceView>( "","ul li[rpsid='9eb21e0b-1d90-4972-894a-cf16f31f36f7']","",this);
 
            SectionPayment = RPSControlFactory.CreateRPSSection<InvoiceView>( "","ul li[rpsid='4ff0a422-9a84-408d-8f38-f811c0afdf71']","",this);
 
            SectionGeneralLedger = RPSControlFactory.CreateRPSSection<InvoiceView>( "","ul li[rpsid='da12bb0f-8ae0-494e-bfa5-4e3da58b19a0']","",this);
 
            Section3 = RPSControlFactory.CreateRPSSection<InvoiceView>( "","ul li[rpsid='46dc88ec-a543-4cbd-b439-5392c14b82a4']","",this);
 
            PrintOptions = RPSControlFactory.CreateRPSSection<InvoiceView>( "","ul li[rpsid='5c9c0536-9192-4c81-ba15-0f381dd02b5b']","",this);
 

        }
        public IRPSSaveButton<InvoiceView> SaveButton { get; set; } 
        public IRPSButton<InvoiceView> DeleteButton { get; set; } 
        public IRPSButton<InvoiceView,InvoiceChildDialogView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<InvoiceView,InvoiceChildDialogView> BackButton { get; set; } 
        public IRPSTextBox<InvoiceView> CompanyName { get; set; } 
        public IRPSTextBox<InvoiceView> VATNumber { get; set; } 
        public IRPSTextBox<InvoiceView> TotalCalc { get; set; } 
        public IRPSCheckbox<InvoiceView> PrintInvoice { get; set; } 
        public IRPSTextBox<InvoiceView> TotalInvoice { get; set; } 
        public IRPSTextBox<InvoiceView> TotalBase { get; set; } 
        public IRPSTextBox<InvoiceView> VATAmount { get; set; } 
        public IRPSTextBox<InvoiceView> SurchargeAmount { get; set; } 
        public IRPSTextBox<InvoiceView> TotalTaxInvoice { get; set; } 
        public IRPSTextBox<InvoiceView> FinancialSurchargeAmount { get; set; } 
        public IRPSTextBox<InvoiceView> Discount1 { get; set; } 
        public IRPSTextBox<InvoiceView> Discount2 { get; set; } 
        public IRPSTextBox<InvoiceView> Discount3 { get; set; } 
        public IRPSTextBox<InvoiceView> FinancialSurcharge { get; set; } 
        public IRPSTextBox<InvoiceView> CashDiscount { get; set; } 
        public IRPSTextBox<InvoiceView> Transport { get; set; } 
        public IRPSTextBox<InvoiceView> RetentionPercent { get; set; } 
        public IRPSTextBox<InvoiceView> Retention { get; set; } 
        public IRPSCheckbox<InvoiceView> NotNotUpdateMovements { get; set; } 
        public IRPSTextBox<InvoiceView> TotalLinesInvoiceCompany { get; set; } 
        public IRPSTextBox<InvoiceView> TotalLinesDeliveyCompany { get; set; } 
        public IRPSTextBox<InvoiceView> TotalLinesBalance { get; set; } 
        public IRPSTextBox<InvoiceView> VATBase1 { get; set; } 
        public IRPSTextBox<InvoiceView> VATBase2 { get; set; } 
        public IRPSTextBox<InvoiceView> VATBase3 { get; set; } 
        public IRPSTextBox<InvoiceView> VATBase4 { get; set; } 
        public IRPSTextBox<InvoiceView> VATBase5 { get; set; } 
        public IRPSTextBox<InvoiceView> VATBase6 { get; set; } 
        public IRPSTextBox<InvoiceView> VATAmount1 { get; set; } 
        public IRPSTextBox<InvoiceView> VATAmount2 { get; set; } 
        public IRPSTextBox<InvoiceView> VATAmount3 { get; set; } 
        public IRPSTextBox<InvoiceView> VATAmount4 { get; set; } 
        public IRPSTextBox<InvoiceView> VATAmount5 { get; set; } 
        public IRPSTextBox<InvoiceView> VATAmount6 { get; set; } 
        public IRPSTextBox<InvoiceView> SurchargeAmount1 { get; set; } 
        public IRPSTextBox<InvoiceView> SurchargeAmount2 { get; set; } 
        public IRPSTextBox<InvoiceView> SurchargeAmount3 { get; set; } 
        public IRPSTextBox<InvoiceView> SurchargeAmount4 { get; set; } 
        public IRPSTextBox<InvoiceView> SurchargeAmount5 { get; set; } 
        public IRPSTextBox<InvoiceView> SurchargeAmount6 { get; set; } 
        public IRPSOption<InvoiceView> Optionscreen { get; set; } 
        public IRPSOption<InvoiceView> OptionMail { get; set; } 
        public IRPSOption<InvoiceView> UIOptSupplier { get; set; } 
        public IRPSOption<InvoiceView> UIOptSelected { get; set; } 
        public IRPSComboBox<InvoiceView> UIPrintOptionsIDLanguage { get; set; } 
        public IRPSCheckbox<InvoiceView> UIPrintSpecificReport { get; set; } 
        public IRPSComboBox<InvoiceView> IDCustomReport { get; set; } 
        public InvoicePaymentsCollectionEditor<InvoiceView> InvoicePayments { get; set; } 
        public GetACCTransactionsTempFromPurchaseCollectionEditor<InvoiceView> GetACCTransactionsTempFromPurchase { get; set; } 
        public GetACCTransactionsTempAnalyticFromPurchaseCollectionEditor<InvoiceView> GetACCTransactionsTempAnalyticFromPurchase { get; set; } 
        public IRPSSection<InvoiceView> Section { get; set; } 
        public IRPSSection<InvoiceView> SectionPayment { get; set; } 
        public IRPSSection<InvoiceView> SectionGeneralLedger { get; set; } 
        public IRPSSection<InvoiceView> Section3 { get; set; } 
        public IRPSSection<InvoiceView> PrintOptions { get; set; } 
        public DeliveryNote Screen { get; set; }
        public InvoiceView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class InvoicePaymentsCollectionEditor<InvoiceView>:RPSCollectionEditor<InvoiceView> where InvoiceView : class, IView
    {
        public  InvoicePaymentsGridView<InvoiceView> GridView {get;set;}
    }
    public partial class InvoicePaymentsGridView <InvoiceView> :  RPSGridView<InvoiceView> where InvoiceView : class, IView
    {
        public InvoicePaymentsGridView(InvoiceView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDPaymentMethod = RPSControlFactory.CreateRPSGridComboBox<InvoiceView>("","#274d3912-1d5a-4f56-abf0-075aca0dd6a7 .ag-row[role='row']@ROWINDEX [col-id='cIDPaymentMethod']","",false, this.CurrentView);
 
            NumPayment = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceView>("","#274d3912-1d5a-4f56-abf0-075aca0dd6a7 .ag-row[role='row']@ROWINDEX [col-id='cNumPayment']","",true, this.CurrentView);
 
            Date = RPSControlFactory.CreateRPSGridTextBox<InvoiceView>("","#274d3912-1d5a-4f56-abf0-075aca0dd6a7 .ag-row[role='row']@ROWINDEX [col-id='cDate']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceView>("","#274d3912-1d5a-4f56-abf0-075aca0dd6a7 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            CDDate = RPSControlFactory.CreateRPSGridTextBox<InvoiceView>("","#274d3912-1d5a-4f56-abf0-075aca0dd6a7 .ag-row[role='row']@ROWINDEX [col-id='cCDDate']","",false, this.CurrentView);
 
            CDToleranceDate = RPSControlFactory.CreateRPSGridTextBox<InvoiceView>("","#274d3912-1d5a-4f56-abf0-075aca0dd6a7 .ag-row[role='row']@ROWINDEX [col-id='cCDToleranceDate']","",false, this.CurrentView);
 
            CDAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceView>("","#274d3912-1d5a-4f56-abf0-075aca0dd6a7 .ag-row[role='row']@ROWINDEX [col-id='cCDAmount']","",true, this.CurrentView);
 
            CDToleranceAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceView>("","#274d3912-1d5a-4f56-abf0-075aca0dd6a7 .ag-row[role='row']@ROWINDEX [col-id='cCDToleranceAmount']","",true, this.CurrentView);
 
            CDPercentage = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceView>("","#274d3912-1d5a-4f56-abf0-075aca0dd6a7 .ag-row[role='row']@ROWINDEX [col-id='cCDPercentage']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<InvoiceView> IDPaymentMethod { get; set; } 
        public IRPSGridTextBox<InvoiceView> NumPayment { get; set; } 
        public IRPSGridTextBox<InvoiceView> Date { get; set; } 
        public IRPSGridTextBox<InvoiceView> Amount { get; set; } 
        public IRPSGridTextBox<InvoiceView> CDDate { get; set; } 
        public IRPSGridTextBox<InvoiceView> CDToleranceDate { get; set; } 
        public IRPSGridTextBox<InvoiceView> CDAmount { get; set; } 
        public IRPSGridTextBox<InvoiceView> CDToleranceAmount { get; set; } 
        public IRPSGridTextBox<InvoiceView> CDPercentage { get; set; } 
                     
    }
 
        public partial class GetACCTransactionsTempFromPurchaseCollectionEditor<InvoiceView>:RPSCollectionEditor<InvoiceView> where InvoiceView : class, IView
    {
        public  GetACCTransactionsTempFromPurchaseGridView<InvoiceView> GridView {get;set;}
    }
    public partial class GetACCTransactionsTempFromPurchaseGridView <InvoiceView> :  RPSGridView<InvoiceView> where InvoiceView : class, IView
    {
        public GetACCTransactionsTempFromPurchaseGridView(InvoiceView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            SignType = RPSControlFactory.CreateRPSGridTextBox<InvoiceView>("","#33ef81af-01c2-4ff2-96f7-5e08fa39a64e .ag-row[role='row']@ROWINDEX [col-id='cSignType']","",false, this.CurrentView);
 
            Extension = RPSControlFactory.CreateRPSGridTextBox<InvoiceView>("","#33ef81af-01c2-4ff2-96f7-5e08fa39a64e .ag-row[role='row']@ROWINDEX [col-id='cExtension']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<InvoiceView> SignType { get; set; } 
        public IRPSGridTextBox<InvoiceView> Extension { get; set; } 
                     
    }
 
        public partial class GetACCTransactionsTempAnalyticFromPurchaseCollectionEditor<InvoiceView>:RPSCollectionEditor<InvoiceView> where InvoiceView : class, IView
    {
        public  GetACCTransactionsTempAnalyticFromPurchaseGridView<InvoiceView> GridView {get;set;}
    }
    public partial class GetACCTransactionsTempAnalyticFromPurchaseGridView <InvoiceView> :  RPSGridView<InvoiceView> where InvoiceView : class, IView
    {
        public GetACCTransactionsTempAnalyticFromPurchaseGridView(InvoiceView currentView)
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
  
            
    public partial class ContainerChildDialogView : View
    {
        public ContainerChildDialogView(DeliveryNote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDArticleContainer = RPSControlFactory.CreateRPSComboBox<ContainerChildDialogView>("6d29a4c1-42fc-45c7-919f-48492d78ac01","","",false, this);
 
            QuantityContainer = RPSControlFactory.CreateRPSFormattedTextBox<ContainerChildDialogView>("8f33ee2d-7cd7-4a66-aee9-95fe399afc61","","",false, this);
 
            QuantityContainerSecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<ContainerChildDialogView>("d2f012d7-f102-4569-8881-0a0fe615c000","","",false, this);
 

        }
        public IRPSComboBox<ContainerChildDialogView> IDArticleContainer { get; set; } 
        public IRPSTextBox<ContainerChildDialogView> QuantityContainer { get; set; } 
        public IRPSTextBox<ContainerChildDialogView> QuantityContainerSecondUnit { get; set; } 
        public DeliveryNote Screen { get; set; }
        public ContainerChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class AutomaticMaterialImputationDialogView : View
    {
        public AutomaticMaterialImputationDialogView(DeliveryNote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            AddNewButton = RPSControlFactory.CreateRPSButton<AutomaticMaterialImputationDialogView>( "aec8bacd-47dd-4483-9bda-66e90b7fbf76","","",this);
 
            GenerateCommandButton = RPSControlFactory.CreateRPSButton<AutomaticMaterialImputationDialogView>( "3e95aad0-3544-41fe-afc9-e82b56638936","","",this);
 
            CollectionInit params_MaterialImputations = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="48d983cb-931e-4e43-8b6f-08e53cf81a16",CSSSelectorGrid="",XPathGrid=""};
            MaterialImputations = RPSControlFactory.RPSCreateCollectionWithGrid<MaterialImputationsCollectionEditor<AutomaticMaterialImputationDialogView>,AutomaticMaterialImputationDialogView>( params_MaterialImputations,this);
 

        }
        public IRPSButton<AutomaticMaterialImputationDialogView> AddNewButton { get; set; } 
        public IRPSButton<AutomaticMaterialImputationDialogView> GenerateCommandButton { get; set; } 
        public MaterialImputationsCollectionEditor<AutomaticMaterialImputationDialogView> MaterialImputations { get; set; } 
        public DeliveryNote Screen { get; set; }
        public AutomaticMaterialImputationDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaterialImputationsCollectionEditor<AutomaticMaterialImputationDialogView>:RPSCollectionEditor<AutomaticMaterialImputationDialogView> where AutomaticMaterialImputationDialogView : class, IView
    {
        public  MaterialImputationsGridView<AutomaticMaterialImputationDialogView> GridView {get;set;}
    }
    public partial class MaterialImputationsGridView <AutomaticMaterialImputationDialogView> :  RPSGridView<AutomaticMaterialImputationDialogView> where AutomaticMaterialImputationDialogView : class, IView
    {
        public MaterialImputationsGridView(AutomaticMaterialImputationDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            RemoveCommand = RPSControlFactory.CreateRPSGridButton<AutomaticMaterialImputationDialogView>( "","#48d983cb-931e-4e43-8b6f-08e53cf81a16 .ag-row[role='row']@ROWINDEX [col-id='cRemoveCommand']","",this.CurrentView);
 
            IDProject = RPSControlFactory.CreateRPSGridComboBox<AutomaticMaterialImputationDialogView>("","#48d983cb-931e-4e43-8b6f-08e53cf81a16 .ag-row[role='row']@ROWINDEX [col-id='cIDProject']","",false, this.CurrentView);
 
            IDArticleMaterial = RPSControlFactory.CreateRPSGridComboBox<AutomaticMaterialImputationDialogView>("","#48d983cb-931e-4e43-8b6f-08e53cf81a16 .ag-row[role='row']@ROWINDEX [col-id='cIDArticleMaterial']","",false, this.CurrentView);
 
            ImputedQtty = RPSControlFactory.CreateRPSGridFormattedTextBox<AutomaticMaterialImputationDialogView>("","#48d983cb-931e-4e43-8b6f-08e53cf81a16 .ag-row[role='row']@ROWINDEX [col-id='cImputedQtty']","",false, this.CurrentView);
 
            CurrentQtty = RPSControlFactory.CreateRPSGridFormattedTextBox<AutomaticMaterialImputationDialogView>("","#48d983cb-931e-4e43-8b6f-08e53cf81a16 .ag-row[role='row']@ROWINDEX [col-id='cCurrentQtty']","",false, this.CurrentView);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSGridFormattedTextBox<AutomaticMaterialImputationDialogView>("","#48d983cb-931e-4e43-8b6f-08e53cf81a16 .ag-row[role='row']@ROWINDEX [col-id='cQuantitySecondUnit']","",false, this.CurrentView);
 
            IDSite = RPSControlFactory.CreateRPSGridComboBox<AutomaticMaterialImputationDialogView>("","#48d983cb-931e-4e43-8b6f-08e53cf81a16 .ag-row[role='row']@ROWINDEX [col-id='cIDSite']","",false, this.CurrentView);
 
            IDWareHouse = RPSControlFactory.CreateRPSGridComboBox<AutomaticMaterialImputationDialogView>("","#48d983cb-931e-4e43-8b6f-08e53cf81a16 .ag-row[role='row']@ROWINDEX [col-id='cIDWarehouse']","",false, this.CurrentView);
 
            Series = RPSControlFactory.CreateRPSGridEnumComboBox<AutomaticMaterialImputationDialogView>("","#48d983cb-931e-4e43-8b6f-08e53cf81a16 .ag-row[role='row']@ROWINDEX [col-id='cSeries']","",false, this.CurrentView);
 
            IDLocationWarehouse = RPSControlFactory.CreateRPSGridComboBox<AutomaticMaterialImputationDialogView>("","#48d983cb-931e-4e43-8b6f-08e53cf81a16 .ag-row[role='row']@ROWINDEX [col-id='cIDLocationWarehouse']","",false, this.CurrentView);
 
            IDProjectTask = RPSControlFactory.CreateRPSGridComboBox<AutomaticMaterialImputationDialogView>("","#48d983cb-931e-4e43-8b6f-08e53cf81a16 .ag-row[role='row']@ROWINDEX [col-id='cIDProjectTask']","",false, this.CurrentView);
 
            IDProMaterial = RPSControlFactory.CreateRPSGridComboBox<AutomaticMaterialImputationDialogView>("","#48d983cb-931e-4e43-8b6f-08e53cf81a16 .ag-row[role='row']@ROWINDEX [col-id='cIDProMaterial']","",false, this.CurrentView);
 

        }
        public IRPSGridButton<AutomaticMaterialImputationDialogView> RemoveCommand { get; set; } 
        public IRPSGridComboBox<AutomaticMaterialImputationDialogView> IDProject { get; set; } 
        public IRPSGridComboBox<AutomaticMaterialImputationDialogView> IDArticleMaterial { get; set; } 
        public IRPSGridTextBox<AutomaticMaterialImputationDialogView> ImputedQtty { get; set; } 
        public IRPSGridTextBox<AutomaticMaterialImputationDialogView> CurrentQtty { get; set; } 
        public IRPSGridTextBox<AutomaticMaterialImputationDialogView> QuantitySecondUnit { get; set; } 
        public IRPSGridComboBox<AutomaticMaterialImputationDialogView> IDSite { get; set; } 
        public IRPSGridComboBox<AutomaticMaterialImputationDialogView> IDWareHouse { get; set; } 
        public IRPSGridComboBox<AutomaticMaterialImputationDialogView> Series { get; set; } 
        public IRPSGridComboBox<AutomaticMaterialImputationDialogView> IDLocationWarehouse { get; set; } 
        public IRPSGridComboBox<AutomaticMaterialImputationDialogView> IDProjectTask { get; set; } 
        public IRPSGridComboBox<AutomaticMaterialImputationDialogView> IDProMaterial { get; set; } 
                     
    }
 
    }
  
            
    public partial class DirectSeriesDataChildDialogView : View
    {
        public DirectSeriesDataChildDialogView(DeliveryNote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSComboBox<DirectSeriesDataChildDialogView>("8a4dcdc5-0297-4ef2-bf06-64bb5f15600b","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<DirectSeriesDataChildDialogView>("30964a2a-9ac5-47ee-90b4-3040d15d40b1","","",true, this);
 
            CollectionInit params_DirectSeriesDataItemlCollection = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7aa1cc1e-b80e-4ca6-9cb6-406c971d4122",CSSSelectorGrid="",XPathGrid=""};
            DirectSeriesDataItemlCollection = RPSControlFactory.RPSCreateCollectionWithGrid<DirectSeriesDataItemlCollectionCollectionEditor<DirectSeriesDataChildDialogView>,DirectSeriesDataChildDialogView>( params_DirectSeriesDataItemlCollection,this);
 

        }
        public IRPSComboBox<DirectSeriesDataChildDialogView> IDArticle { get; set; } 
        public IRPSTextBox<DirectSeriesDataChildDialogView> Quantity { get; set; } 
        public DirectSeriesDataItemlCollectionCollectionEditor<DirectSeriesDataChildDialogView> DirectSeriesDataItemlCollection { get; set; } 
        public DeliveryNote Screen { get; set; }
        public DirectSeriesDataChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DirectSeriesDataItemlCollectionCollectionEditor<DirectSeriesDataChildDialogView>:RPSCollectionEditor<DirectSeriesDataChildDialogView> where DirectSeriesDataChildDialogView : class, IView
    {
        public  DirectSeriesDataItemlCollectionGridView<DirectSeriesDataChildDialogView> GridView {get;set;}
    }
    public partial class DirectSeriesDataItemlCollectionGridView <DirectSeriesDataChildDialogView> :  RPSGridView<DirectSeriesDataChildDialogView> where DirectSeriesDataChildDialogView : class, IView
    {
        public DirectSeriesDataItemlCollectionGridView(DirectSeriesDataChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Series = RPSControlFactory.CreateRPSGridTextBox<DirectSeriesDataChildDialogView>("","#7aa1cc1e-b80e-4ca6-9cb6-406c971d4122 .ag-row[role='row']@ROWINDEX [col-id='cSeries']","",false, this.CurrentView);
 
            SeriesCombo = RPSControlFactory.CreateRPSGridEnumComboBox<DirectSeriesDataChildDialogView>("","#7aa1cc1e-b80e-4ca6-9cb6-406c971d4122 .ag-row[role='row']@ROWINDEX [col-id='cSeriesCombo']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<DirectSeriesDataChildDialogView>("","#7aa1cc1e-b80e-4ca6-9cb6-406c971d4122 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSGridFormattedTextBox<DirectSeriesDataChildDialogView>("","#7aa1cc1e-b80e-4ca6-9cb6-406c971d4122 .ag-row[role='row']@ROWINDEX [col-id='cQuantitySecondUnit']","",false, this.CurrentView);
 
            ExpiryDate = RPSControlFactory.CreateRPSGridTextBox<DirectSeriesDataChildDialogView>("","#7aa1cc1e-b80e-4ca6-9cb6-406c971d4122 .ag-row[role='row']@ROWINDEX [col-id='cExpiryDate']","",false, this.CurrentView);
 
            IDArticleContainer = RPSControlFactory.CreateRPSGridComboBox<DirectSeriesDataChildDialogView>("","#7aa1cc1e-b80e-4ca6-9cb6-406c971d4122 .ag-row[role='row']@ROWINDEX [col-id='cIDArticleContainer']","",false, this.CurrentView);
 
            QuantityContainer = RPSControlFactory.CreateRPSGridFormattedTextBox<DirectSeriesDataChildDialogView>("","#7aa1cc1e-b80e-4ca6-9cb6-406c971d4122 .ag-row[role='row']@ROWINDEX [col-id='cQuantityContainer']","",false, this.CurrentView);
 
            QuantitySecondUnitContainer = RPSControlFactory.CreateRPSGridFormattedTextBox<DirectSeriesDataChildDialogView>("","#7aa1cc1e-b80e-4ca6-9cb6-406c971d4122 .ag-row[role='row']@ROWINDEX [col-id='cQuantitySecondUnitContainer']","",false, this.CurrentView);
 
            PotencyValue = RPSControlFactory.CreateRPSGridFormattedTextBox<DirectSeriesDataChildDialogView>("","#7aa1cc1e-b80e-4ca6-9cb6-406c971d4122 .ag-row[role='row']@ROWINDEX [col-id='cPotencyValue']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<DirectSeriesDataChildDialogView> Series { get; set; } 
        public IRPSGridComboBox<DirectSeriesDataChildDialogView> SeriesCombo { get; set; } 
        public IRPSGridTextBox<DirectSeriesDataChildDialogView> Quantity { get; set; } 
        public IRPSGridTextBox<DirectSeriesDataChildDialogView> QuantitySecondUnit { get; set; } 
        public IRPSGridTextBox<DirectSeriesDataChildDialogView> ExpiryDate { get; set; } 
        public IRPSGridComboBox<DirectSeriesDataChildDialogView> IDArticleContainer { get; set; } 
        public IRPSGridTextBox<DirectSeriesDataChildDialogView> QuantityContainer { get; set; } 
        public IRPSGridTextBox<DirectSeriesDataChildDialogView> QuantitySecondUnitContainer { get; set; } 
        public IRPSGridTextBox<DirectSeriesDataChildDialogView> PotencyValue { get; set; } 
                     
    }
 
    }
  
            
    public partial class AnalyticChildDialogView : View
    {
        public AnalyticChildDialogView(DeliveryNote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIIDAccount = RPSControlFactory.CreateRPSComboBox<AnalyticChildDialogView>("0233c538-589a-47e8-a2a5-466a62b13121","","",false, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<AnalyticChildDialogView>("ceda45b1-b0b1-46ed-9ad3-2365851bfd5f","","",true, this);
 
            GetDimensionChildCommandButton = RPSControlFactory.CreateRPSButton<AnalyticChildDialogView>( "29959c7e-b346-47fb-9e01-506596c301fd","","",this);
 
            CollectionInit params_OrderLineAnalytics = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="bb649561-0096-4ca2-bc7e-40900b2ff3eb",CSSSelectorGrid="",XPathGrid=""};
            OrderLineAnalytics = RPSControlFactory.RPSCreateCollectionWithGrid<OrderLineAnalyticsCollectionEditor<AnalyticChildDialogView>,AnalyticChildDialogView>( params_OrderLineAnalytics,this);
 

        }
        public IRPSComboBox<AnalyticChildDialogView> UIIDAccount { get; set; } 
        public IRPSTextBox<AnalyticChildDialogView> Amount { get; set; } 
        public IRPSButton<AnalyticChildDialogView> GetDimensionChildCommandButton { get; set; } 
        public OrderLineAnalyticsCollectionEditor<AnalyticChildDialogView> OrderLineAnalytics { get; set; } 
        public DeliveryNote Screen { get; set; }
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
            IDDimension = RPSControlFactory.CreateRPSGridComboBox<AnalyticChildDialogView>("","#bb649561-0096-4ca2-bc7e-40900b2ff3eb .ag-row[role='row']@ROWINDEX [col-id='cIDDimension']","",true, this.CurrentView);
 
            IDDimValue = RPSControlFactory.CreateRPSGridComboBox<AnalyticChildDialogView>("","#bb649561-0096-4ca2-bc7e-40900b2ff3eb .ag-row[role='row']@ROWINDEX [col-id='cIDDimValue']","",true, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<AnalyticChildDialogView>("","#bb649561-0096-4ca2-bc7e-40900b2ff3eb .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<AnalyticChildDialogView>("","#bb649561-0096-4ca2-bc7e-40900b2ff3eb .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<AnalyticChildDialogView> IDDimension { get; set; } 
        public IRPSGridComboBox<AnalyticChildDialogView> IDDimValue { get; set; } 
        public IRPSGridTextBox<AnalyticChildDialogView> Percentage { get; set; } 
        public IRPSGridTextBox<AnalyticChildDialogView> Amount { get; set; } 
                     
    }
 
    }
  
            
    public partial class LocationChildDialogView : View
    {
        public LocationChildDialogView(DeliveryNote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSComboBox<LocationChildDialogView>("2cfc37e5-f8e7-4ccd-9785-4ee334392122","","",false, this);
 
            CollectionInit params_DeliveryNoteLineMovements = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="9158870e-74aa-4351-85f0-7dd658200dad",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNoteLineMovements = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNoteLineMovementsCollectionEditor<LocationChildDialogView>,LocationChildDialogView>( params_DeliveryNoteLineMovements,this);
 

        }
        public IRPSComboBox<LocationChildDialogView> IDArticle { get; set; } 
        public DeliveryNoteLineMovementsCollectionEditor<LocationChildDialogView> DeliveryNoteLineMovements { get; set; } 
        public DeliveryNote Screen { get; set; }
        public LocationChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DeliveryNoteLineMovementsCollectionEditor<LocationChildDialogView>:RPSCollectionEditor<LocationChildDialogView> where LocationChildDialogView : class, IView
    {
        public  DeliveryNoteLineMovementsGridView<LocationChildDialogView> GridView {get;set;}
    }
    public partial class DeliveryNoteLineMovementsGridView <LocationChildDialogView> :  RPSGridView<LocationChildDialogView> where LocationChildDialogView : class, IView
    {
        public DeliveryNoteLineMovementsGridView(LocationChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDLocationWarehouse = RPSControlFactory.CreateRPSGridComboBox<LocationChildDialogView>("","#9158870e-74aa-4351-85f0-7dd658200dad .ag-row[role='row']@ROWINDEX [col-id='cIDLocationWarehouse']","",false, this.CurrentView);
 
            IDLocationWarehouseTrans = RPSControlFactory.CreateRPSGridComboBox<LocationChildDialogView>("","#9158870e-74aa-4351-85f0-7dd658200dad .ag-row[role='row']@ROWINDEX [col-id='cIDLocationWarehouseTrans']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<LocationChildDialogView>("","#9158870e-74aa-4351-85f0-7dd658200dad .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSGridFormattedTextBox<LocationChildDialogView>("","#9158870e-74aa-4351-85f0-7dd658200dad .ag-row[role='row']@ROWINDEX [col-id='cQuantitySecondUnit']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<LocationChildDialogView> IDLocationWarehouse { get; set; } 
        public IRPSGridComboBox<LocationChildDialogView> IDLocationWarehouseTrans { get; set; } 
        public IRPSGridTextBox<LocationChildDialogView> Quantity { get; set; } 
        public IRPSGridTextBox<LocationChildDialogView> QuantitySecondUnit { get; set; } 
                     
    }
 
    }
  
    

}