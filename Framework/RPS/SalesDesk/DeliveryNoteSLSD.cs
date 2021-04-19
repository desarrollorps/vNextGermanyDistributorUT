    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.SalesDesk.DeliveryNoteSLSD
{
    //RPS VERSION 1.0.0.0
    public partial class DeliveryNoteSLSD:Screen
    {
        public DeliveryNoteSLSD():base()
        {
            this.URL = "salesdesk.deliverynoteslsd";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DeliveryNoteSLCollectionView  = new DeliveryNoteSLCollectionView(this); 
            DeliveryNoteSLEntityView  = new DeliveryNoteSLEntityView(this); 
            DeliveryNoteLineSLView  = new DeliveryNoteLineSLView(this); 
            DeliveryNoteComAgentSLView  = new DeliveryNoteComAgentSLView(this); 
            DeliveryNoteLineCommercialAgentSLView  = new DeliveryNoteLineCommercialAgentSLView(this); 
            DeliveryNoteLineMovementSLView  = new DeliveryNoteLineMovementSLView(this); 
            OrderLineAnalyticSLView  = new OrderLineAnalyticSLView(this); 
            DeliveryNoteLineTaxSLView  = new DeliveryNoteLineTaxSLView(this); 
            DeliveryNoteChangesChildDialogView  = new DeliveryNoteChangesChildDialogView(this); 
            PrintDeliveryNoteChildDialogView  = new PrintDeliveryNoteChildDialogView(this); 
            ArticleGenericChildDialogView  = new ArticleGenericChildDialogView(this); 
            PrintInvoiceChildDialogView  = new PrintInvoiceChildDialogView(this); 
            RecalculateIntrastatChildDialogView  = new RecalculateIntrastatChildDialogView(this); 
            DeliveryNoteLabelPrintDialogView  = new DeliveryNoteLabelPrintDialogView(this); 
            DeliveryNoteComAgentNewChildDialogView  = new DeliveryNoteComAgentNewChildDialogView(this); 
            DirectSeriesDataChildDialogView  = new DirectSeriesDataChildDialogView(this); 
            CreditChildDialogView  = new CreditChildDialogView(this); 
            ChangesChildDialogView  = new ChangesChildDialogView(this); 
            ChangeCustomerChildDialogView  = new ChangeCustomerChildDialogView(this); 
            AnalyticChildDialogView  = new AnalyticChildDialogView(this); 
            DeliveryNoteSLCollectionView.InitializeControls(); 
            DeliveryNoteSLEntityView.InitializeControls(); 
            DeliveryNoteLineSLView.InitializeControls(); 
            DeliveryNoteComAgentSLView.InitializeControls(); 
            DeliveryNoteLineCommercialAgentSLView.InitializeControls(); 
            DeliveryNoteLineMovementSLView.InitializeControls(); 
            OrderLineAnalyticSLView.InitializeControls(); 
            DeliveryNoteLineTaxSLView.InitializeControls(); 
            DeliveryNoteChangesChildDialogView.InitializeControls(); 
            PrintDeliveryNoteChildDialogView.InitializeControls(); 
            ArticleGenericChildDialogView.InitializeControls(); 
            PrintInvoiceChildDialogView.InitializeControls(); 
            RecalculateIntrastatChildDialogView.InitializeControls(); 
            DeliveryNoteLabelPrintDialogView.InitializeControls(); 
            DeliveryNoteComAgentNewChildDialogView.InitializeControls(); 
            DirectSeriesDataChildDialogView.InitializeControls(); 
            CreditChildDialogView.InitializeControls(); 
            ChangesChildDialogView.InitializeControls(); 
            ChangeCustomerChildDialogView.InitializeControls(); 
            AnalyticChildDialogView.InitializeControls(); 
           
        }
      
            public DeliveryNoteSLCollectionView DeliveryNoteSLCollectionView {get; set; } 
            public DeliveryNoteSLEntityView DeliveryNoteSLEntityView {get; set; } 
            public DeliveryNoteLineSLView DeliveryNoteLineSLView {get; set; } 
            public DeliveryNoteComAgentSLView DeliveryNoteComAgentSLView {get; set; } 
            public DeliveryNoteLineCommercialAgentSLView DeliveryNoteLineCommercialAgentSLView {get; set; } 
            public DeliveryNoteLineMovementSLView DeliveryNoteLineMovementSLView {get; set; } 
            public OrderLineAnalyticSLView OrderLineAnalyticSLView {get; set; } 
            public DeliveryNoteLineTaxSLView DeliveryNoteLineTaxSLView {get; set; } 
            public DeliveryNoteChangesChildDialogView DeliveryNoteChangesChildDialogView {get; set; } 
            public PrintDeliveryNoteChildDialogView PrintDeliveryNoteChildDialogView {get; set; } 
            public ArticleGenericChildDialogView ArticleGenericChildDialogView {get; set; } 
            public PrintInvoiceChildDialogView PrintInvoiceChildDialogView {get; set; } 
            public RecalculateIntrastatChildDialogView RecalculateIntrastatChildDialogView {get; set; } 
            public DeliveryNoteLabelPrintDialogView DeliveryNoteLabelPrintDialogView {get; set; } 
            public DeliveryNoteComAgentNewChildDialogView DeliveryNoteComAgentNewChildDialogView {get; set; } 
            public DirectSeriesDataChildDialogView DirectSeriesDataChildDialogView {get; set; } 
            public CreditChildDialogView CreditChildDialogView {get; set; } 
            public ChangesChildDialogView ChangesChildDialogView {get; set; } 
            public ChangeCustomerChildDialogView ChangeCustomerChildDialogView {get; set; } 
            public AnalyticChildDialogView AnalyticChildDialogView {get; set; } 
    }
            
    public partial class DeliveryNoteSLCollectionView : View
    {
        public DeliveryNoteSLCollectionView(DeliveryNoteSLSD screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<DeliveryNoteSLCollectionView,DeliveryNoteSLEntityView>( this,Screen.DeliveryNoteSLEntityView);
 
            NewTicketCommandButton = RPSControlFactory.CreateRPSButton<DeliveryNoteSLCollectionView>( "0bb04c5e-9391-4e50-a05d-f6cb0008e25c","","",this);
 
            NewInvoiceCommandButton = RPSControlFactory.CreateRPSButton<DeliveryNoteSLCollectionView>( "6d6ed477-f6fc-4ed5-abf2-60d158da5ff9","","",this);
 
            CreditChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryNoteSLCollectionView,CreditChildDialogView>("7ea357fe-fdee-460c-9d9d-7a6d2e6ea9cd","","", this,Screen.CreditChildDialogView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "5b7f111d-63b6-4cdd-98a4-ffb5b384e2c6",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<DeliveryNoteSLCollectionView,DeliveryNoteSLEntityView>( params_MainConsult,this,Screen.DeliveryNoteSLEntityView);
 

        }
        public IRPSButton<DeliveryNoteSLCollectionView,DeliveryNoteSLEntityView> NewButton { get; set; } 
        public IRPSButton<DeliveryNoteSLCollectionView> NewTicketCommandButton { get; set; } 
        public IRPSButton<DeliveryNoteSLCollectionView> NewInvoiceCommandButton { get; set; } 
        public IRPSButton<DeliveryNoteSLCollectionView,CreditChildDialogView> CreditChildNavigationCommandButton { get; set; } 
        public IRPSCollectionEditor<DeliveryNoteSLCollectionView,DeliveryNoteSLEntityView> MainConsult { get; set; } 
        public DeliveryNoteSLSD Screen { get; set; }
        public DeliveryNoteSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DeliveryNoteSLEntityView : View
    {
        public DeliveryNoteSLEntityView(DeliveryNoteSLSD screen) : base()
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
 
            Transport = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteSLEntityView>("82aaffa6-8917-460b-a6cf-c502c3617342","","",true, this);
 
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
 
            PrintDeliveryNoteChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryNoteSLEntityView,PrintDeliveryNoteChildDialogView>("86034a29-0326-430e-a313-b6007442955b","","", this,Screen.PrintDeliveryNoteChildDialogView);
 
            TotalsUpdateButton = RPSControlFactory.CreateRPSButton<DeliveryNoteSLEntityView>( "ca522779-27d5-4d51-a630-e8de354b8ca1","","",this);
 
            InvoiceCommandButton = RPSControlFactory.CreateRPSButton<DeliveryNoteSLEntityView>( "b1fca03e-6706-4384-8054-30db31cf2505","","",this);
 
            FinalizedCommandButton = RPSControlFactory.CreateRPSButton<DeliveryNoteSLEntityView>( "674709b2-5f0c-463c-971d-4b86198f71b6","","",this);
 
            ExecuteUnFinalizedButton = RPSControlFactory.CreateRPSButton<DeliveryNoteSLEntityView>( "3597c9df-c74c-4bdd-85b5-f47467da72ec","","",this);
 
            RecalculatePromotionButton = RPSControlFactory.CreateRPSButton<DeliveryNoteSLEntityView>( "e46d37d3-ad15-4fab-9b60-a88a3d3d2a45","","",this);
 
            ExecuteCalculateWeightButton = RPSControlFactory.CreateRPSButton<DeliveryNoteSLEntityView>( "0793855d-a08c-4aa5-994b-f1607eea4402","","",this);
 
            ChangeCustomerChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryNoteSLEntityView,ChangeCustomerChildDialogView>("4bc53734-30c3-4d50-97aa-c87e79ca5910","","", this,Screen.ChangeCustomerChildDialogView);
 
            DeliveryNoteLabelPrintNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryNoteSLEntityView,DeliveryNoteLabelPrintDialogView>("f3636d77-9142-4f4f-a75b-adc9e9f9639c","","", this,Screen.DeliveryNoteLabelPrintDialogView);
 
            RecalculateIntrastatChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryNoteSLEntityView,RecalculateIntrastatChildDialogView>("8db43373-84a9-43c4-8cf5-ef4dc8582a58","","", this,Screen.RecalculateIntrastatChildDialogView);
 
            CollectionInit params_DeliveryNoteLineSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="96c3634a-7879-427e-974d-a38a6bb341SD",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNoteLineSLs = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNoteLineSLsCollectionEditor<DeliveryNoteSLEntityView,DeliveryNoteLineSLView>,DeliveryNoteSLEntityView,DeliveryNoteLineSLView>( params_DeliveryNoteLineSLs,this,Screen.DeliveryNoteLineSLView);
 
            CollectionInit params_DeliveryNoteComAgentSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="75add846-02d6-424f-bed0-46abc56f41SD",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNoteComAgentSLs = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNoteComAgentSLsCollectionEditor<DeliveryNoteSLEntityView,DeliveryNoteLineSLView>,DeliveryNoteSLEntityView,DeliveryNoteLineSLView>( params_DeliveryNoteComAgentSLs,this,Screen.DeliveryNoteLineSLView);
 
            LinesSection = RPSControlFactory.CreateRPSSection<DeliveryNoteSLEntityView>( "","ul li[rpsid='7bab9c00-cc14-4630-bc9e-0715a0d7173e']","",this);
 
            GeneralDataSection = RPSControlFactory.CreateRPSSection<DeliveryNoteSLEntityView>( "","ul li[rpsid='03f43cca-bc4f-488f-9812-ebc3951620fd']","",this);
 
            CommercialAgentSection = RPSControlFactory.CreateRPSSection<DeliveryNoteSLEntityView>( "","ul li[rpsid='a92a482c-d89b-4469-8e64-5d19f87860d9']","",this);
 
            CommentSection = RPSControlFactory.CreateRPSSection<DeliveryNoteSLEntityView>( "","ul li[rpsid='1244ef3e-c365-485d-bb96-e9a69071d1e0']","",this);
 
            TextLine = RPSControlFactory.CreateRPSSection<DeliveryNoteSLEntityView>( "","ul li[rpsid='d0ff027d-889c-42d8-8f93-25c64ad92973']","",this);
 
            Section = RPSControlFactory.CreateRPSSection<DeliveryNoteSLEntityView>( "","ul li[rpsid='f5e7d807-3967-4c0c-b5ae-3ac07d24e67d']","",this);
 

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
        public IRPSButton<DeliveryNoteSLEntityView,PrintDeliveryNoteChildDialogView> PrintDeliveryNoteChildNavigationCommandButton { get; set; } 
        public IRPSButton<DeliveryNoteSLEntityView> TotalsUpdateButton { get; set; } 
        public IRPSButton<DeliveryNoteSLEntityView> InvoiceCommandButton { get; set; } 
        public IRPSButton<DeliveryNoteSLEntityView> FinalizedCommandButton { get; set; } 
        public IRPSButton<DeliveryNoteSLEntityView> ExecuteUnFinalizedButton { get; set; } 
        public IRPSButton<DeliveryNoteSLEntityView> RecalculatePromotionButton { get; set; } 
        public IRPSButton<DeliveryNoteSLEntityView> ExecuteCalculateWeightButton { get; set; } 
        public IRPSButton<DeliveryNoteSLEntityView,ChangeCustomerChildDialogView> ChangeCustomerChildNavigationCommandButton { get; set; } 
        public IRPSButton<DeliveryNoteSLEntityView,DeliveryNoteLabelPrintDialogView> DeliveryNoteLabelPrintNavigationCommandButton { get; set; } 
        public IRPSButton<DeliveryNoteSLEntityView,RecalculateIntrastatChildDialogView> RecalculateIntrastatChildNavigationCommandButton { get; set; } 
        public DeliveryNoteLineSLsCollectionEditor<DeliveryNoteSLEntityView,DeliveryNoteLineSLView> DeliveryNoteLineSLs { get; set; } 
        public DeliveryNoteComAgentSLsCollectionEditor<DeliveryNoteSLEntityView,DeliveryNoteLineSLView> DeliveryNoteComAgentSLs { get; set; } 
        public IRPSSection<DeliveryNoteSLEntityView> LinesSection { get; set; } 
        public IRPSSection<DeliveryNoteSLEntityView> GeneralDataSection { get; set; } 
        public IRPSSection<DeliveryNoteSLEntityView> CommercialAgentSection { get; set; } 
        public IRPSSection<DeliveryNoteSLEntityView> CommentSection { get; set; } 
        public IRPSSection<DeliveryNoteSLEntityView> TextLine { get; set; } 
        public IRPSSection<DeliveryNoteSLEntityView> Section { get; set; } 
        public DeliveryNoteSLSD Screen { get; set; }
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
            IDOrderLine = RPSControlFactory.CreateRPSGridComboBox<DeliveryNoteSLEntityView>("","#96c3634a-7879-427e-974d-a38a6bb341SD .ag-row[role='row']@ROWINDEX [col-id='cIDOrderLine']","",true, this.CurrentView);
 
            Ordenation = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteSLEntityView>("","#96c3634a-7879-427e-974d-a38a6bb341SD .ag-row[role='row']@ROWINDEX [col-id='cOrdenation']","",true, this.CurrentView);
 
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<DeliveryNoteSLEntityView>("","#96c3634a-7879-427e-974d-a38a6bb341SD .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            UIDescription = RPSControlFactory.CreateRPSGridTextBox<DeliveryNoteSLEntityView>("","#96c3634a-7879-427e-974d-a38a6bb341SD .ag-row[role='row']@ROWINDEX [col-id='cUIDescription']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteSLEntityView>("","#96c3634a-7879-427e-974d-a38a6bb341SD .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            Price = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteSLEntityView>("","#96c3634a-7879-427e-974d-a38a6bb341SD .ag-row[role='row']@ROWINDEX [col-id='cPrice']","",true, this.CurrentView);
 
            PercentVAT = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteSLEntityView>("","#96c3634a-7879-427e-974d-a38a6bb341SD .ag-row[role='row']@ROWINDEX [col-id='cPercentVAT']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteSLEntityView>("","#96c3634a-7879-427e-974d-a38a6bb341SD .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            AmountWithVAT = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteSLEntityView>("","#96c3634a-7879-427e-974d-a38a6bb341SD .ag-row[role='row']@ROWINDEX [col-id='cAmountWithVAT']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<DeliveryNoteSLEntityView> IDOrderLine { get; set; } 
        public IRPSGridTextBox<DeliveryNoteSLEntityView> Ordenation { get; set; } 
        public IRPSGridComboBox<DeliveryNoteSLEntityView> IDArticle { get; set; } 
        public IRPSGridTextBox<DeliveryNoteSLEntityView> UIDescription { get; set; } 
        public IRPSGridTextBox<DeliveryNoteSLEntityView> Quantity { get; set; } 
        public IRPSGridTextBox<DeliveryNoteSLEntityView> Price { get; set; } 
        public IRPSGridTextBox<DeliveryNoteSLEntityView> PercentVAT { get; set; } 
        public IRPSGridTextBox<DeliveryNoteSLEntityView> Amount { get; set; } 
        public IRPSGridTextBox<DeliveryNoteSLEntityView> AmountWithVAT { get; set; } 
                     
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
            DeleteAgentCommand = RPSControlFactory.CreateRPSGridButton<DeliveryNoteSLEntityView>( "","#75add846-02d6-424f-bed0-46abc56f41SD .ag-row[role='row']@ROWINDEX [col-id='cDeleteAgentCommand']","",this.CurrentView);
 
            IDCommercialAgent = RPSControlFactory.CreateRPSGridComboBox<DeliveryNoteSLEntityView>("","#75add846-02d6-424f-bed0-46abc56f41SD .ag-row[role='row']@ROWINDEX [col-id='cIDCommercialAgent']","",true, this.CurrentView);
 
            IDCommercialAgentClassification = RPSControlFactory.CreateRPSGridComboBox<DeliveryNoteSLEntityView>("","#75add846-02d6-424f-bed0-46abc56f41SD .ag-row[role='row']@ROWINDEX [col-id='cIDCommercialAgentClassification']","",true, this.CurrentView);
 
            Commission = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteSLEntityView>("","#75add846-02d6-424f-bed0-46abc56f41SD .ag-row[role='row']@ROWINDEX [col-id='cCommission']","",false, this.CurrentView);
 
            ComisionTypeString = RPSControlFactory.CreateRPSGridTextBox<DeliveryNoteSLEntityView>("","#75add846-02d6-424f-bed0-46abc56f41SD .ag-row[role='row']@ROWINDEX [col-id='cComisionTypeString']","",false, this.CurrentView);
 
            ComisionHead = RPSControlFactory.CreateRPSGridCheckBox<DeliveryNoteSLEntityView>("","#75add846-02d6-424f-bed0-46abc56f41SD .ag-row[role='row']@ROWINDEX [col-id='cComisionHead']","",false, this.CurrentView);
 

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
        public DeliveryNoteLineSLView(DeliveryNoteSLSD screen) : base()
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
 
            OrderLineGetDimensionCommandButton = RPSControlFactory.CreateRPSButton<DeliveryNoteLineSLView>( "4f54274f-87c3-4c1d-a998-604500919bc5","","",this);
 
            PriceBase = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineSLView>("672d1fe7-dac6-43f9-bdb0-a706d70be00e","","",true, this);
 
            UIconditionPrice = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineSLView>("f547ca7f-cad7-469a-afa6-393042f4f3ae","","",false, this);
 
            UIPriceWihoutConditionsBase = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineSLView>("77cd7740-0912-4a40-a110-b9cc17a4a885","","",true, this);
 
            PriceWihoutConditions1 = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteLineSLView>("3cc5770d-cbb8-48d2-84fb-ed32130acbf7","","",true, this);
 
            ExecuteDeliveryNoteLineCommentAddArticleTechnicalDescription = RPSControlFactory.CreateRPSButton<DeliveryNoteLineSLView>( "963f0586-cd3a-4d94-8972-43b11f360343","","",this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<DeliveryNoteLineSLView>("00f87208-68b2-4aac-9f68-65e28c48e493","","",false, this);
 
            ExecuteDeliveryNoteLineCommentInvoiceAddArticleTechnicalDescription = RPSControlFactory.CreateRPSButton<DeliveryNoteLineSLView>( "f4a6c70a-f69f-45cf-9d67-ce73aee72c24","","",this);
 
            CommentInvoice = RPSControlFactory.CreateRPSTextBox<DeliveryNoteLineSLView>("5525b3a2-60c0-40b3-ae3e-1112a3c84150","","",false, this);
 
            DirectSeriesDataChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryNoteLineSLView,DirectSeriesDataChildDialogView>("4991619c-1a58-4b3a-b28f-6d86c1d81981","","", this,Screen.DirectSeriesDataChildDialogView);
 
            AnalyticChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryNoteLineSLView,AnalyticChildDialogView>("f4a1a2d7-0bbd-4f2b-b498-573d95c6548d","","", this,Screen.AnalyticChildDialogView);
 
            CollectionInit params_DeliveryNoteLineMovementSLOutputs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="278c7810-2a3f-48e2-83a0-b19f04bb71SD",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNoteLineMovementSLOutputs = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNoteLineMovementSLOutputsCollectionEditor<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView>,DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView>( params_DeliveryNoteLineMovementSLOutputs,this,Screen.DeliveryNoteLineMovementSLView);
 
            CollectionInit params_DeliveryNoteLineMovementSLEntrys = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="617098bb-5fc6-473f-9904-96ec360f2aSD",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNoteLineMovementSLEntrys = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNoteLineMovementSLEntrysCollectionEditor<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView>,DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView>( params_DeliveryNoteLineMovementSLEntrys,this,Screen.DeliveryNoteLineMovementSLView);
 
            CollectionInit params_OrderLineAnalyticSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4e8c5f60-207c-4089-b2a6-8db79763f9SD",CSSSelectorGrid="",XPathGrid=""};
            OrderLineAnalyticSLs = RPSControlFactory.RPSCreateCollectionWithGrid<OrderLineAnalyticSLsCollectionEditor<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView>,DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView>( params_OrderLineAnalyticSLs,this,Screen.DeliveryNoteLineMovementSLView);
 
            CollectionInit params_DeliveryNoteLineTaxSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="fe9d424b-188b-40a2-b35e-6e5e67f433SD",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNoteLineTaxSLs = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNoteLineTaxSLsCollectionEditor<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView>,DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView>( params_DeliveryNoteLineTaxSLs,this,Screen.DeliveryNoteLineMovementSLView);
 
            CollectionInit params_DeliveryNoteLineConditionSLsAffect = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1d079157-174c-4819-a826-1e68371c1aSD",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNoteLineConditionSLsAffect = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNoteLineConditionSLsAffectCollectionEditor<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView>,DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView>( params_DeliveryNoteLineConditionSLsAffect,this,Screen.DeliveryNoteLineMovementSLView);
 
            CollectionInit params_DeliveryNoteLineConditionSLsNoAffect = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="690191df-2fb7-423e-b013-3d3b0cb17bSD",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNoteLineConditionSLsNoAffect = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNoteLineConditionSLsNoAffectCollectionEditor<DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView>,DeliveryNoteLineSLView,DeliveryNoteLineMovementSLView>( params_DeliveryNoteLineConditionSLsNoAffect,this,Screen.DeliveryNoteLineMovementSLView);
 
            CollectionInit params_DeliveryNoteLineCommercialAgentSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="cae96c8d-3e3b-4bc6-9342-23ce2908a2SD",CSSSelectorGrid="",XPathGrid=""};
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
        public IRPSButton<DeliveryNoteLineSLView,DirectSeriesDataChildDialogView> DirectSeriesDataChildNavigationCommandButton { get; set; } 
        public IRPSButton<DeliveryNoteLineSLView,AnalyticChildDialogView> AnalyticChildNavigationCommandButton { get; set; } 
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
        public DeliveryNoteSLSD Screen { get; set; }
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
            IDLocationWarehouseOutput = RPSControlFactory.CreateRPSGridComboBox<DeliveryNoteLineSLView>("","#278c7810-2a3f-48e2-83a0-b19f04bb71SD .ag-row[role='row']@ROWINDEX [col-id='cIDLocationWarehouseOutput']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineSLView>("","#278c7810-2a3f-48e2-83a0-b19f04bb71SD .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineSLView>("","#278c7810-2a3f-48e2-83a0-b19f04bb71SD .ag-row[role='row']@ROWINDEX [col-id='cQuantitySecondUnit']","",true, this.CurrentView);
 

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
            EntryDate = RPSControlFactory.CreateRPSGridTextBox<DeliveryNoteLineSLView>("","#617098bb-5fc6-473f-9904-96ec360f2aSD .ag-row[role='row']@ROWINDEX [col-id='cEntryDate']","",false, this.CurrentView);
 
            IDLocationWarehouseEntry = RPSControlFactory.CreateRPSGridComboBox<DeliveryNoteLineSLView>("","#617098bb-5fc6-473f-9904-96ec360f2aSD .ag-row[role='row']@ROWINDEX [col-id='cIDLocationWarehouseEntry']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineSLView>("","#617098bb-5fc6-473f-9904-96ec360f2aSD .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineSLView>("","#617098bb-5fc6-473f-9904-96ec360f2aSD .ag-row[role='row']@ROWINDEX [col-id='cQuantitySecondUnit']","",true, this.CurrentView);
 

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
            IDDimension = RPSControlFactory.CreateRPSGridComboBox<DeliveryNoteLineSLView>("","#4e8c5f60-207c-4089-b2a6-8db79763f9SD .ag-row[role='row']@ROWINDEX [col-id='cIDDimension']","",true, this.CurrentView);
 
            IDDimValue = RPSControlFactory.CreateRPSGridComboBox<DeliveryNoteLineSLView>("","#4e8c5f60-207c-4089-b2a6-8db79763f9SD .ag-row[role='row']@ROWINDEX [col-id='cIDDimValue']","",true, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineSLView>("","#4e8c5f60-207c-4089-b2a6-8db79763f9SD .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineSLView>("","#4e8c5f60-207c-4089-b2a6-8db79763f9SD .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 

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
            IDTaxValue = RPSControlFactory.CreateRPSGridComboBox<DeliveryNoteLineSLView>("","#fe9d424b-188b-40a2-b35e-6e5e67f433SD .ag-row[role='row']@ROWINDEX [col-id='cIDTaxValue']","",true, this.CurrentView);
 
            ApplicationType = RPSControlFactory.CreateRPSGridEnumComboBox<DeliveryNoteLineSLView>("","#fe9d424b-188b-40a2-b35e-6e5e67f433SD .ag-row[role='row']@ROWINDEX [col-id='cApplicationType']","",true, this.CurrentView);
 
            BaseType = RPSControlFactory.CreateRPSGridEnumComboBox<DeliveryNoteLineSLView>("","#fe9d424b-188b-40a2-b35e-6e5e67f433SD .ag-row[role='row']@ROWINDEX [col-id='cBaseType']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<DeliveryNoteLineSLView>("","#fe9d424b-188b-40a2-b35e-6e5e67f433SD .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            Value = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineSLView>("","#fe9d424b-188b-40a2-b35e-6e5e67f433SD .ag-row[role='row']@ROWINDEX [col-id='cValue']","",true, this.CurrentView);
 
            VAT = RPSControlFactory.CreateRPSGridCheckBox<DeliveryNoteLineSLView>("","#fe9d424b-188b-40a2-b35e-6e5e67f433SD .ag-row[role='row']@ROWINDEX [col-id='cVAT']","",true, this.CurrentView);
 
            PriceIncluded = RPSControlFactory.CreateRPSGridCheckBox<DeliveryNoteLineSLView>("","#fe9d424b-188b-40a2-b35e-6e5e67f433SD .ag-row[role='row']@ROWINDEX [col-id='cPriceIncluded']","",true, this.CurrentView);
 

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
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<DeliveryNoteLineSLView>("","#1d079157-174c-4819-a826-1e68371c1aSD .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            ConditionValueOriginal = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineSLView>("","#1d079157-174c-4819-a826-1e68371c1aSD .ag-row[role='row']@ROWINDEX [col-id='cConditionValueOriginal']","",true, this.CurrentView);
 
            ConditionValue = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineSLView>("","#1d079157-174c-4819-a826-1e68371c1aSD .ag-row[role='row']@ROWINDEX [col-id='cConditionValue']","",true, this.CurrentView);
 
            Base = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineSLView>("","#1d079157-174c-4819-a826-1e68371c1aSD .ag-row[role='row']@ROWINDEX [col-id='cBase']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineSLView>("","#1d079157-174c-4819-a826-1e68371c1aSD .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            ConditionType = RPSControlFactory.CreateRPSGridEnumComboBox<DeliveryNoteLineSLView>("","#1d079157-174c-4819-a826-1e68371c1aSD .ag-row[role='row']@ROWINDEX [col-id='cConditionType']","",true, this.CurrentView);
 
            BaseApply = RPSControlFactory.CreateRPSGridEnumComboBox<DeliveryNoteLineSLView>("","#1d079157-174c-4819-a826-1e68371c1aSD .ag-row[role='row']@ROWINDEX [col-id='cBaseApply']","",true, this.CurrentView);
 
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<DeliveryNoteLineSLView>("","#1d079157-174c-4819-a826-1e68371c1aSD .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",true, this.CurrentView);
 
            DateTo = RPSControlFactory.CreateRPSGridTextBox<DeliveryNoteLineSLView>("","#1d079157-174c-4819-a826-1e68371c1aSD .ag-row[role='row']@ROWINDEX [col-id='cDateTo']","",true, this.CurrentView);
 

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
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<DeliveryNoteLineSLView>("","#690191df-2fb7-423e-b013-3d3b0cb17bSD .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            ConditionValueOriginal = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineSLView>("","#690191df-2fb7-423e-b013-3d3b0cb17bSD .ag-row[role='row']@ROWINDEX [col-id='cConditionValueOriginal']","",true, this.CurrentView);
 
            ConditionValue = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineSLView>("","#690191df-2fb7-423e-b013-3d3b0cb17bSD .ag-row[role='row']@ROWINDEX [col-id='cConditionValue']","",true, this.CurrentView);
 
            Base = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineSLView>("","#690191df-2fb7-423e-b013-3d3b0cb17bSD .ag-row[role='row']@ROWINDEX [col-id='cBase']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineSLView>("","#690191df-2fb7-423e-b013-3d3b0cb17bSD .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            ConditionType = RPSControlFactory.CreateRPSGridEnumComboBox<DeliveryNoteLineSLView>("","#690191df-2fb7-423e-b013-3d3b0cb17bSD .ag-row[role='row']@ROWINDEX [col-id='cConditionType']","",true, this.CurrentView);
 
            BaseApply = RPSControlFactory.CreateRPSGridEnumComboBox<DeliveryNoteLineSLView>("","#690191df-2fb7-423e-b013-3d3b0cb17bSD .ag-row[role='row']@ROWINDEX [col-id='cBaseApply']","",true, this.CurrentView);
 
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<DeliveryNoteLineSLView>("","#690191df-2fb7-423e-b013-3d3b0cb17bSD .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",true, this.CurrentView);
 
            DateTo = RPSControlFactory.CreateRPSGridTextBox<DeliveryNoteLineSLView>("","#690191df-2fb7-423e-b013-3d3b0cb17bSD .ag-row[role='row']@ROWINDEX [col-id='cDateTo']","",true, this.CurrentView);
 

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
            IDCommercialAgent = RPSControlFactory.CreateRPSGridComboBox<DeliveryNoteLineSLView>("","#cae96c8d-3e3b-4bc6-9342-23ce2908a2SD .ag-row[role='row']@ROWINDEX [col-id='cIDCommercialAgent']","",true, this.CurrentView);
 
            IDCommercialAgentClassification = RPSControlFactory.CreateRPSGridComboBox<DeliveryNoteLineSLView>("","#cae96c8d-3e3b-4bc6-9342-23ce2908a2SD .ag-row[role='row']@ROWINDEX [col-id='cIDCommercialAgentClassification']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<DeliveryNoteLineSLView>("","#cae96c8d-3e3b-4bc6-9342-23ce2908a2SD .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            Commission = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineSLView>("","#cae96c8d-3e3b-4bc6-9342-23ce2908a2SD .ag-row[role='row']@ROWINDEX [col-id='cCommission']","",true, this.CurrentView);
 
            CommissionAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteLineSLView>("","#cae96c8d-3e3b-4bc6-9342-23ce2908a2SD .ag-row[role='row']@ROWINDEX [col-id='cCommissionAmount']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<DeliveryNoteLineSLView> IDCommercialAgent { get; set; } 
        public IRPSGridComboBox<DeliveryNoteLineSLView> IDCommercialAgentClassification { get; set; } 
        public IRPSGridComboBox<DeliveryNoteLineSLView> Type { get; set; } 
        public IRPSGridTextBox<DeliveryNoteLineSLView> Commission { get; set; } 
        public IRPSGridTextBox<DeliveryNoteLineSLView> CommissionAmount { get; set; } 
                     
    }
 
    }
  
            
    public partial class DeliveryNoteComAgentSLView : View
    {
        public DeliveryNoteComAgentSLView(DeliveryNoteSLSD screen) : base()
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
 
            CollectionInit params_DeliveryNoteCommisions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a5643e7d-a0cf-42c1-9e47-7797358c5bSD",CSSSelectorGrid="",XPathGrid=""};
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
        public DeliveryNoteSLSD Screen { get; set; }
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
            Ordenation = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteComAgentSLView>("","#a5643e7d-a0cf-42c1-9e47-7797358c5bSD .ag-row[role='row']@ROWINDEX [col-id='cOrdenation']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<DeliveryNoteComAgentSLView>("","#a5643e7d-a0cf-42c1-9e47-7797358c5bSD .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            IDCommercialAgent = RPSControlFactory.CreateRPSGridComboBox<DeliveryNoteComAgentSLView>("","#a5643e7d-a0cf-42c1-9e47-7797358c5bSD .ag-row[role='row']@ROWINDEX [col-id='cIDCommercialAgent']","",true, this.CurrentView);
 
            IDCommercialAgentClassification = RPSControlFactory.CreateRPSGridComboBox<DeliveryNoteComAgentSLView>("","#a5643e7d-a0cf-42c1-9e47-7797358c5bSD .ag-row[role='row']@ROWINDEX [col-id='cIDCommercialAgentClassification']","",true, this.CurrentView);
 
            Commission = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteComAgentSLView>("","#a5643e7d-a0cf-42c1-9e47-7797358c5bSD .ag-row[role='row']@ROWINDEX [col-id='cCommission']","",false, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridTextBox<DeliveryNoteComAgentSLView>("","#a5643e7d-a0cf-42c1-9e47-7797358c5bSD .ag-row[role='row']@ROWINDEX [col-id='cType']","",false, this.CurrentView);
 

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
        public DeliveryNoteLineCommercialAgentSLView(DeliveryNoteSLSD screen) : base()
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
        public DeliveryNoteSLSD Screen { get; set; }
        public DeliveryNoteLineCommercialAgentSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DeliveryNoteLineMovementSLView : View
    {
        public DeliveryNoteLineMovementSLView(DeliveryNoteSLSD screen) : base()
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
        public DeliveryNoteSLSD Screen { get; set; }
        public DeliveryNoteLineMovementSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OrderLineAnalyticSLView : View
    {
        public OrderLineAnalyticSLView(DeliveryNoteSLSD screen) : base()
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
        public DeliveryNoteSLSD Screen { get; set; }
        public OrderLineAnalyticSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DeliveryNoteLineTaxSLView : View
    {
        public DeliveryNoteLineTaxSLView(DeliveryNoteSLSD screen) : base()
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
        public DeliveryNoteSLSD Screen { get; set; }
        public DeliveryNoteLineTaxSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DeliveryNoteChangesChildDialogView : View
    {
        public DeliveryNoteChangesChildDialogView(DeliveryNoteSLSD screen) : base()
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
        public DeliveryNoteSLSD Screen { get; set; }
        public DeliveryNoteChangesChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PrintDeliveryNoteChildDialogView : View
    {
        public PrintDeliveryNoteChildDialogView(DeliveryNoteSLSD screen) : base()
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
        public DeliveryNoteSLSD Screen { get; set; }
        public PrintDeliveryNoteChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ArticleGenericChildDialogView : View
    {
        public ArticleGenericChildDialogView(DeliveryNoteSLSD screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_ArticleGetAttributeValues = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b8ea25f2-e763-44b3-bc72-36f51efb6bSD",CSSSelectorGrid="",XPathGrid=""};
            ArticleGetAttributeValues = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleGetAttributeValuesCollectionEditor<ArticleGenericChildDialogView>,ArticleGenericChildDialogView>( params_ArticleGetAttributeValues,this);
 

        }
        public ArticleGetAttributeValuesCollectionEditor<ArticleGenericChildDialogView> ArticleGetAttributeValues { get; set; } 
        public DeliveryNoteSLSD Screen { get; set; }
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
            Attribute1 = RPSControlFactory.CreateRPSGridTextBox<ArticleGenericChildDialogView>("","#b8ea25f2-e763-44b3-bc72-36f51efb6bSD .ag-row[role='row']@ROWINDEX [col-id='cAttribute1']","",false, this.CurrentView);
 
            Attribute2 = RPSControlFactory.CreateRPSGridTextBox<ArticleGenericChildDialogView>("","#b8ea25f2-e763-44b3-bc72-36f51efb6bSD .ag-row[role='row']@ROWINDEX [col-id='cAttribute2']","",false, this.CurrentView);
 
            Attribute3 = RPSControlFactory.CreateRPSGridTextBox<ArticleGenericChildDialogView>("","#b8ea25f2-e763-44b3-bc72-36f51efb6bSD .ag-row[role='row']@ROWINDEX [col-id='cAttribute3']","",false, this.CurrentView);
 
            quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<ArticleGenericChildDialogView>("","#b8ea25f2-e763-44b3-bc72-36f51efb6bSD .ag-row[role='row']@ROWINDEX [col-id='cquantity']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ArticleGenericChildDialogView> Attribute1 { get; set; } 
        public IRPSGridTextBox<ArticleGenericChildDialogView> Attribute2 { get; set; } 
        public IRPSGridTextBox<ArticleGenericChildDialogView> Attribute3 { get; set; } 
        public IRPSGridTextBox<ArticleGenericChildDialogView> quantity { get; set; } 
                     
    }
 
    }
  
            
    public partial class PrintInvoiceChildDialogView : View
    {
        public PrintInvoiceChildDialogView(DeliveryNoteSLSD screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            InvoiceDate = RPSControlFactory.CreateRPSTextBox<PrintInvoiceChildDialogView>("881c5197-8b2e-465d-98e2-f403568d6b61","","",false, this);
 
            Ticket = RPSControlFactory.CreateRPSOption<PrintInvoiceChildDialogView>( "8c841f7c-0a38-4152-b9f9-4ab5aef234a8","","",this);
 
            Invoice = RPSControlFactory.CreateRPSOption<PrintInvoiceChildDialogView>( "2be2de98-0cc6-48d7-8a3d-d075d84ce440","","",this);
 
            TotalAmountInvoice = RPSControlFactory.CreateRPSFormattedTextBox<PrintInvoiceChildDialogView>("ccfebc28-4c47-4eb1-847d-0e8ef0dce91c","","",false, this);
 
            CashAmount = RPSControlFactory.CreateRPSFormattedTextBox<PrintInvoiceChildDialogView>("ab7a38ad-c962-4729-a630-51202866fd61","","",false, this);
 
            DefferedAmount = RPSControlFactory.CreateRPSFormattedTextBox<PrintInvoiceChildDialogView>("720a0eb6-7157-4be9-9f86-a16ddbf57e72","","",false, this);
 
            DeliveredAmount = RPSControlFactory.CreateRPSFormattedTextBox<PrintInvoiceChildDialogView>("84f747b4-5fb0-423f-8d85-1be895701157","","",false, this);
 
            ReturnAmount = RPSControlFactory.CreateRPSFormattedTextBox<PrintInvoiceChildDialogView>("6f4ab3ac-1919-43b4-80e4-d2646d762d8e","","",false, this);
 
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
 
            ChangesChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<PrintInvoiceChildDialogView,ChangesChildDialogView>("9940fe27-0ceb-4321-9340-161c78afb0b0","","", this,Screen.ChangesChildDialogView);
 
            CollectionInit params_PaymentMethodModelCollection = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6c91987f-607e-4f81-af89-e73c439d2bSD",CSSSelectorGrid="",XPathGrid=""};
            PaymentMethodModelCollection = RPSControlFactory.RPSCreateCollectionWithGrid<PaymentMethodModelCollectionCollectionEditor<PrintInvoiceChildDialogView,ChangesChildDialogView>,PrintInvoiceChildDialogView,ChangesChildDialogView>( params_PaymentMethodModelCollection,this,Screen.ChangesChildDialogView);
 

        }
        public IRPSTextBox<PrintInvoiceChildDialogView> InvoiceDate { get; set; } 
        public IRPSOption<PrintInvoiceChildDialogView> Ticket { get; set; } 
        public IRPSOption<PrintInvoiceChildDialogView> Invoice { get; set; } 
        public IRPSTextBox<PrintInvoiceChildDialogView> TotalAmountInvoice { get; set; } 
        public IRPSTextBox<PrintInvoiceChildDialogView> CashAmount { get; set; } 
        public IRPSTextBox<PrintInvoiceChildDialogView> DefferedAmount { get; set; } 
        public IRPSTextBox<PrintInvoiceChildDialogView> DeliveredAmount { get; set; } 
        public IRPSTextBox<PrintInvoiceChildDialogView> ReturnAmount { get; set; } 
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
        public IRPSButton<PrintInvoiceChildDialogView,ChangesChildDialogView> ChangesChildNavigationCommandButton { get; set; } 
        public PaymentMethodModelCollectionCollectionEditor<PrintInvoiceChildDialogView,ChangesChildDialogView> PaymentMethodModelCollection { get; set; } 
        public DeliveryNoteSLSD Screen { get; set; }
        public PrintInvoiceChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class PaymentMethodModelCollectionCollectionEditor<PrintInvoiceChildDialogView,ChangesChildDialogView>:RPSCollectionEditor<PrintInvoiceChildDialogView,ChangesChildDialogView> where PrintInvoiceChildDialogView : class, IView where ChangesChildDialogView : class, IView
    {
        public  PaymentMethodModelCollectionGridView<PrintInvoiceChildDialogView,ChangesChildDialogView> GridView {get;set;}
    }
    public partial class PaymentMethodModelCollectionGridView <PrintInvoiceChildDialogView,ChangesChildDialogView> :  RPSGridView<PrintInvoiceChildDialogView,ChangesChildDialogView> where PrintInvoiceChildDialogView : class, IView where ChangesChildDialogView : class, IView
    {
        public PaymentMethodModelCollectionGridView(PrintInvoiceChildDialogView currentView,ChangesChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDPaymentMethodSL = RPSControlFactory.CreateRPSGridComboBox<PrintInvoiceChildDialogView>("","#6c91987f-607e-4f81-af89-e73c439d2bSD .ag-row[role='row']@ROWINDEX [col-id='cIDPaymentMethodSL']","",false, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<PrintInvoiceChildDialogView>("","#6c91987f-607e-4f81-af89-e73c439d2bSD .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<PrintInvoiceChildDialogView> IDPaymentMethodSL { get; set; } 
        public IRPSGridTextBox<PrintInvoiceChildDialogView> Amount { get; set; } 
                     
    }
 
    }
  
            
    public partial class RecalculateIntrastatChildDialogView : View
    {
        public RecalculateIntrastatChildDialogView(DeliveryNoteSLSD screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<RecalculateIntrastatChildDialogView>("7fb3a654-f062-4fc1-ad7b-5df253c9b113","","",false, this);
 

        }
        public IRPSTextBox<RecalculateIntrastatChildDialogView> Amount { get; set; } 
        public DeliveryNoteSLSD Screen { get; set; }
        public RecalculateIntrastatChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DeliveryNoteLabelPrintDialogView : View
    {
        public DeliveryNoteLabelPrintDialogView(DeliveryNoteSLSD screen) : base()
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
        public DeliveryNoteSLSD Screen { get; set; }
        public DeliveryNoteLabelPrintDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DeliveryNoteComAgentNewChildDialogView : View
    {
        public DeliveryNoteComAgentNewChildDialogView(DeliveryNoteSLSD screen) : base()
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
        public DeliveryNoteSLSD Screen { get; set; }
        public DeliveryNoteComAgentNewChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DirectSeriesDataChildDialogView : View
    {
        public DirectSeriesDataChildDialogView(DeliveryNoteSLSD screen) : base()
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
 
            CollectionInit params_DirectSeriesDataItemlCollection1 = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="68c29519-c00f-43fe-8627-bc7572287fSD",CSSSelectorGrid="",XPathGrid=""};
            DirectSeriesDataItemlCollection1 = RPSControlFactory.RPSCreateCollectionWithGrid<DirectSeriesDataItemlCollection1CollectionEditor<DirectSeriesDataChildDialogView>,DirectSeriesDataChildDialogView>( params_DirectSeriesDataItemlCollection1,this);
 

        }
        public IRPSComboBox<DirectSeriesDataChildDialogView> IDArticle { get; set; } 
        public IRPSTextBox<DirectSeriesDataChildDialogView> Quantity { get; set; } 
        public IRPSComboBox<DirectSeriesDataChildDialogView> SerieUnitariaInitial { get; set; } 
        public IRPSButton<DirectSeriesDataChildDialogView> UnitarianSeriesCommand { get; set; } 
        public DirectSeriesDataItemlCollection1CollectionEditor<DirectSeriesDataChildDialogView> DirectSeriesDataItemlCollection1 { get; set; } 
        public DeliveryNoteSLSD Screen { get; set; }
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
            Series = RPSControlFactory.CreateRPSGridEnumComboBox<DirectSeriesDataChildDialogView>("","#68c29519-c00f-43fe-8627-bc7572287fSD .ag-row[role='row']@ROWINDEX [col-id='cSeries']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<DirectSeriesDataChildDialogView>("","#68c29519-c00f-43fe-8627-bc7572287fSD .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSGridFormattedTextBox<DirectSeriesDataChildDialogView>("","#68c29519-c00f-43fe-8627-bc7572287fSD .ag-row[role='row']@ROWINDEX [col-id='cQuantitySecondUnit']","",false, this.CurrentView);
 
            ExpiryDate = RPSControlFactory.CreateRPSGridTextBox<DirectSeriesDataChildDialogView>("","#68c29519-c00f-43fe-8627-bc7572287fSD .ag-row[role='row']@ROWINDEX [col-id='cExpiryDate']","",false, this.CurrentView);
 
            IDArticleContainer = RPSControlFactory.CreateRPSGridComboBox<DirectSeriesDataChildDialogView>("","#68c29519-c00f-43fe-8627-bc7572287fSD .ag-row[role='row']@ROWINDEX [col-id='cIDArticleContainer']","",false, this.CurrentView);
 
            QuantityContainer = RPSControlFactory.CreateRPSGridFormattedTextBox<DirectSeriesDataChildDialogView>("","#68c29519-c00f-43fe-8627-bc7572287fSD .ag-row[role='row']@ROWINDEX [col-id='cQuantityContainer']","",false, this.CurrentView);
 
            QuantitySecondUnitContainer = RPSControlFactory.CreateRPSGridFormattedTextBox<DirectSeriesDataChildDialogView>("","#68c29519-c00f-43fe-8627-bc7572287fSD .ag-row[role='row']@ROWINDEX [col-id='cQuantitySecondUnitContainer']","",false, this.CurrentView);
 
            PotencyValue = RPSControlFactory.CreateRPSGridFormattedTextBox<DirectSeriesDataChildDialogView>("","#68c29519-c00f-43fe-8627-bc7572287fSD .ag-row[role='row']@ROWINDEX [col-id='cPotencyValue']","",false, this.CurrentView);
 

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
  
            
    public partial class CreditChildDialogView : View
    {
        public CreditChildDialogView(DeliveryNoteSLSD screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeliveryNote = RPSControlFactory.CreateRPSOption<CreditChildDialogView>( "5cf7755b-4831-4a20-8683-7fa9913a4ed1","","",this);
 
            Invoice = RPSControlFactory.CreateRPSOption<CreditChildDialogView>( "728f596b-4cc2-4dc7-a7fa-47fc3fc9dad8","","",this);
 
            IDReturnCauseSL = RPSControlFactory.CreateRPSComboBox<CreditChildDialogView>("3d053a26-6bd6-4bb5-b2a0-8437f4a99c1c","","",false, this);
 
            IDInvoiceSL = RPSControlFactory.CreateRPSComboBox<CreditChildDialogView>("c18a7295-9759-4c6b-aed0-65f5dedcf5bd","","",false, this);
 
            IDReturnCauseSLDeliveryNote = RPSControlFactory.CreateRPSComboBox<CreditChildDialogView>("ecaa5978-b6b0-441e-b54b-8a2b43cc25c3","","",false, this);
 
            IDDeliveryNoteSL = RPSControlFactory.CreateRPSComboBox<CreditChildDialogView>("9d7c869b-ea08-4fdc-b2d4-38dea851eb23","","",false, this);
 
            TransportAmount = RPSControlFactory.CreateRPSFormattedTextBox<CreditChildDialogView>("67d293d2-0e58-499f-9281-ab9e0ee65eea","","",false, this);
 

        }
        public IRPSOption<CreditChildDialogView> DeliveryNote { get; set; } 
        public IRPSOption<CreditChildDialogView> Invoice { get; set; } 
        public IRPSComboBox<CreditChildDialogView> IDReturnCauseSL { get; set; } 
        public IRPSComboBox<CreditChildDialogView> IDInvoiceSL { get; set; } 
        public IRPSComboBox<CreditChildDialogView> IDReturnCauseSLDeliveryNote { get; set; } 
        public IRPSComboBox<CreditChildDialogView> IDDeliveryNoteSL { get; set; } 
        public IRPSTextBox<CreditChildDialogView> TransportAmount { get; set; } 
        public DeliveryNoteSLSD Screen { get; set; }
        public CreditChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ChangesChildDialogView : View
    {
        public ChangesChildDialogView(DeliveryNoteSLSD screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_GetChanges = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="9a0abbf1-170e-4543-9d73-67c70f4f8eSD",CSSSelectorGrid="",XPathGrid=""};
            GetChanges = RPSControlFactory.RPSCreateCollectionWithGrid<GetChangesCollectionEditor<ChangesChildDialogView>,ChangesChildDialogView>( params_GetChanges,this);
 

        }
        public GetChangesCollectionEditor<ChangesChildDialogView> GetChanges { get; set; } 
        public DeliveryNoteSLSD Screen { get; set; }
        public ChangesChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetChangesCollectionEditor<ChangesChildDialogView>:RPSCollectionEditor<ChangesChildDialogView> where ChangesChildDialogView : class, IView
    {
        public  GetChangesGridView<ChangesChildDialogView> GridView {get;set;}
    }
    public partial class GetChangesGridView <ChangesChildDialogView> :  RPSGridView<ChangesChildDialogView> where ChangesChildDialogView : class, IView
    {
        public GetChangesGridView(ChangesChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CashCurrencyAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<ChangesChildDialogView>("","#9a0abbf1-170e-4543-9d73-67c70f4f8eSD .ag-row[role='row']@ROWINDEX [col-id='cCashCurrencyAmount']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<ChangesChildDialogView>("","#9a0abbf1-170e-4543-9d73-67c70f4f8eSD .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ChangesChildDialogView> CashCurrencyAmount { get; set; } 
        public IRPSGridTextBox<ChangesChildDialogView> Quantity { get; set; } 
                     
    }
 
    }
  
            
    public partial class ChangeCustomerChildDialogView : View
    {
        public ChangeCustomerChildDialogView(DeliveryNoteSLSD screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDCustomer = RPSControlFactory.CreateRPSComboBox<ChangeCustomerChildDialogView>("06bff31a-9c5e-4879-bbde-7db06023f385","","",false, this);
 
            IDCustomerMiscellaneousSL = RPSControlFactory.CreateRPSComboBox<ChangeCustomerChildDialogView>("fdb5edae-1d2d-47ff-84ad-f7499a121e74","","",false, this);
 
            VatNumber = RPSControlFactory.CreateRPSTextBox<ChangeCustomerChildDialogView>("26ecad2a-f76a-4bba-aed2-4bbba283a5c2","","",false, this);
 
            bChangeHeaderConditions = RPSControlFactory.CreateRPSCheckBox<ChangeCustomerChildDialogView>("f8b5d213-9300-436e-9162-6970e73ba081","","",false, this);
 

        }
        public IRPSComboBox<ChangeCustomerChildDialogView> IDCustomer { get; set; } 
        public IRPSComboBox<ChangeCustomerChildDialogView> IDCustomerMiscellaneousSL { get; set; } 
        public IRPSTextBox<ChangeCustomerChildDialogView> VatNumber { get; set; } 
        public IRPSCheckbox<ChangeCustomerChildDialogView> bChangeHeaderConditions { get; set; } 
        public DeliveryNoteSLSD Screen { get; set; }
        public ChangeCustomerChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class AnalyticChildDialogView : View
    {
        public AnalyticChildDialogView(DeliveryNoteSLSD screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIIDAccount = RPSControlFactory.CreateRPSComboBox<AnalyticChildDialogView>("a2aa4b16-a5bf-4724-8701-1b64d88c8411","","",false, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<AnalyticChildDialogView>("a0a04c76-2757-436e-ab1a-8f25efdc1cb1","","",true, this);
 
            GetDimensionChildCommandButton = RPSControlFactory.CreateRPSButton<AnalyticChildDialogView>( "9f22f77b-7913-43f6-a8f5-3d0d54087ce7","","",this);
 
            CollectionInit params_OrderLineAnalyticSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5cb7cb70-0073-444d-a39d-66c8e8c88bSD",CSSSelectorGrid="",XPathGrid=""};
            OrderLineAnalyticSLs = RPSControlFactory.RPSCreateCollectionWithGrid<OrderLineAnalyticSLsCollectionEditor<AnalyticChildDialogView>,AnalyticChildDialogView>( params_OrderLineAnalyticSLs,this);
 

        }
        public IRPSComboBox<AnalyticChildDialogView> UIIDAccount { get; set; } 
        public IRPSTextBox<AnalyticChildDialogView> Amount { get; set; } 
        public IRPSButton<AnalyticChildDialogView> GetDimensionChildCommandButton { get; set; } 
        public OrderLineAnalyticSLsCollectionEditor<AnalyticChildDialogView> OrderLineAnalyticSLs { get; set; } 
        public DeliveryNoteSLSD Screen { get; set; }
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
            IDDimension = RPSControlFactory.CreateRPSGridComboBox<AnalyticChildDialogView>("","#5cb7cb70-0073-444d-a39d-66c8e8c88bSD .ag-row[role='row']@ROWINDEX [col-id='cIDDimension']","",true, this.CurrentView);
 
            IDDimValue = RPSControlFactory.CreateRPSGridComboBox<AnalyticChildDialogView>("","#5cb7cb70-0073-444d-a39d-66c8e8c88bSD .ag-row[role='row']@ROWINDEX [col-id='cIDDimValue']","",true, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<AnalyticChildDialogView>("","#5cb7cb70-0073-444d-a39d-66c8e8c88bSD .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<AnalyticChildDialogView>("","#5cb7cb70-0073-444d-a39d-66c8e8c88bSD .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<AnalyticChildDialogView> IDDimension { get; set; } 
        public IRPSGridComboBox<AnalyticChildDialogView> IDDimValue { get; set; } 
        public IRPSGridTextBox<AnalyticChildDialogView> Percentage { get; set; } 
        public IRPSGridTextBox<AnalyticChildDialogView> Amount { get; set; } 
                     
    }
 
    }
  
    

}