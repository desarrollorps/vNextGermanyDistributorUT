    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.SalesCRM.SalesQuoteSL
{
    //RPS VERSION 1.0.0.0
    public partial class SalesQuoteSL:Screen
    {
        public SalesQuoteSL():base()
        {
            this.URL = "salescrm.salesquotesl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SalesQuoteSLQueryView  = new SalesQuoteSLQueryView(this); 
            SalesQuoteSLEntityView  = new SalesQuoteSLEntityView(this); 
            SalesQuoteLineSLView  = new SalesQuoteLineSLView(this); 
            SalesQuoteAdvanceSLView  = new SalesQuoteAdvanceSLView(this); 
            SalesQuoteVariablePaymentSLView  = new SalesQuoteVariablePaymentSLView(this); 
            SalesQuoteAdvanceTaxSLView  = new SalesQuoteAdvanceTaxSLView(this); 
            SalesQuoteLineTaxSLView  = new SalesQuoteLineTaxSLView(this); 
            SalesQuoteIncidenceSLView  = new SalesQuoteIncidenceSLView(this); 
            SalesQuoteMilestoneSLView  = new SalesQuoteMilestoneSLView(this); 
            SalesQuoteComAgentSLView  = new SalesQuoteComAgentSLView(this); 
            SalesQuotePrintDialogView  = new SalesQuotePrintDialogView(this); 
            NewArticleChildDialogView  = new NewArticleChildDialogView(this); 
            SalesQuoteLineCommercialAgentSLView  = new SalesQuoteLineCommercialAgentSLView(this); 
            OptionChildDialogView  = new OptionChildDialogView(this); 
            SalesQuoteComAgentNewChildDialogView  = new SalesQuoteComAgentNewChildDialogView(this); 
            SalesQuoteChangesChildDialogView  = new SalesQuoteChangesChildDialogView(this); 
            SalesQuoteOptionSLView  = new SalesQuoteOptionSLView(this); 
            OrderDataChildDialogView  = new OrderDataChildDialogView(this); 
            GenerateCustomerArticleChildDialogView  = new GenerateCustomerArticleChildDialogView(this); 
            ChangeCustomerChildDialogView  = new ChangeCustomerChildDialogView(this); 
            FrameworkContractFromSalesQuoteChildDialogView  = new FrameworkContractFromSalesQuoteChildDialogView(this); 
            DueDateCalculationDialogView  = new DueDateCalculationDialogView(this); 
            AddToCompositionExistingDocumentDialogView  = new AddToCompositionExistingDocumentDialogView(this); 
            AddToCompositionSalesQuoteHeaderDialogView  = new AddToCompositionSalesQuoteHeaderDialogView(this); 
            AddToCompositionArticleDocumentDialogView  = new AddToCompositionArticleDocumentDialogView(this); 
            AddToCompositionReportDialogView  = new AddToCompositionReportDialogView(this); 
            SalesQuoteProFormaPrintDialogView  = new SalesQuoteProFormaPrintDialogView(this); 
            NewVersionChildDialogView  = new NewVersionChildDialogView(this); 
            NewFromCopyChildDialogView  = new NewFromCopyChildDialogView(this); 
            ArticleGenericChildDialogView  = new ArticleGenericChildDialogView(this); 
            SalesQuoteSLQueryView.InitializeControls(); 
            SalesQuoteSLEntityView.InitializeControls(); 
            SalesQuoteLineSLView.InitializeControls(); 
            SalesQuoteAdvanceSLView.InitializeControls(); 
            SalesQuoteVariablePaymentSLView.InitializeControls(); 
            SalesQuoteAdvanceTaxSLView.InitializeControls(); 
            SalesQuoteLineTaxSLView.InitializeControls(); 
            SalesQuoteIncidenceSLView.InitializeControls(); 
            SalesQuoteMilestoneSLView.InitializeControls(); 
            SalesQuoteComAgentSLView.InitializeControls(); 
            SalesQuotePrintDialogView.InitializeControls(); 
            NewArticleChildDialogView.InitializeControls(); 
            SalesQuoteLineCommercialAgentSLView.InitializeControls(); 
            OptionChildDialogView.InitializeControls(); 
            SalesQuoteComAgentNewChildDialogView.InitializeControls(); 
            SalesQuoteChangesChildDialogView.InitializeControls(); 
            SalesQuoteOptionSLView.InitializeControls(); 
            OrderDataChildDialogView.InitializeControls(); 
            GenerateCustomerArticleChildDialogView.InitializeControls(); 
            ChangeCustomerChildDialogView.InitializeControls(); 
            FrameworkContractFromSalesQuoteChildDialogView.InitializeControls(); 
            DueDateCalculationDialogView.InitializeControls(); 
            AddToCompositionExistingDocumentDialogView.InitializeControls(); 
            AddToCompositionSalesQuoteHeaderDialogView.InitializeControls(); 
            AddToCompositionArticleDocumentDialogView.InitializeControls(); 
            AddToCompositionReportDialogView.InitializeControls(); 
            SalesQuoteProFormaPrintDialogView.InitializeControls(); 
            NewVersionChildDialogView.InitializeControls(); 
            NewFromCopyChildDialogView.InitializeControls(); 
            ArticleGenericChildDialogView.InitializeControls(); 
           
        }
      
            public SalesQuoteSLQueryView SalesQuoteSLQueryView {get; set; } 
            public SalesQuoteSLEntityView SalesQuoteSLEntityView {get; set; } 
            public SalesQuoteLineSLView SalesQuoteLineSLView {get; set; } 
            public SalesQuoteAdvanceSLView SalesQuoteAdvanceSLView {get; set; } 
            public SalesQuoteVariablePaymentSLView SalesQuoteVariablePaymentSLView {get; set; } 
            public SalesQuoteAdvanceTaxSLView SalesQuoteAdvanceTaxSLView {get; set; } 
            public SalesQuoteLineTaxSLView SalesQuoteLineTaxSLView {get; set; } 
            public SalesQuoteIncidenceSLView SalesQuoteIncidenceSLView {get; set; } 
            public SalesQuoteMilestoneSLView SalesQuoteMilestoneSLView {get; set; } 
            public SalesQuoteComAgentSLView SalesQuoteComAgentSLView {get; set; } 
            public SalesQuotePrintDialogView SalesQuotePrintDialogView {get; set; } 
            public NewArticleChildDialogView NewArticleChildDialogView {get; set; } 
            public SalesQuoteLineCommercialAgentSLView SalesQuoteLineCommercialAgentSLView {get; set; } 
            public OptionChildDialogView OptionChildDialogView {get; set; } 
            public SalesQuoteComAgentNewChildDialogView SalesQuoteComAgentNewChildDialogView {get; set; } 
            public SalesQuoteChangesChildDialogView SalesQuoteChangesChildDialogView {get; set; } 
            public SalesQuoteOptionSLView SalesQuoteOptionSLView {get; set; } 
            public OrderDataChildDialogView OrderDataChildDialogView {get; set; } 
            public GenerateCustomerArticleChildDialogView GenerateCustomerArticleChildDialogView {get; set; } 
            public ChangeCustomerChildDialogView ChangeCustomerChildDialogView {get; set; } 
            public FrameworkContractFromSalesQuoteChildDialogView FrameworkContractFromSalesQuoteChildDialogView {get; set; } 
            public DueDateCalculationDialogView DueDateCalculationDialogView {get; set; } 
            public AddToCompositionExistingDocumentDialogView AddToCompositionExistingDocumentDialogView {get; set; } 
            public AddToCompositionSalesQuoteHeaderDialogView AddToCompositionSalesQuoteHeaderDialogView {get; set; } 
            public AddToCompositionArticleDocumentDialogView AddToCompositionArticleDocumentDialogView {get; set; } 
            public AddToCompositionReportDialogView AddToCompositionReportDialogView {get; set; } 
            public SalesQuoteProFormaPrintDialogView SalesQuoteProFormaPrintDialogView {get; set; } 
            public NewVersionChildDialogView NewVersionChildDialogView {get; set; } 
            public NewFromCopyChildDialogView NewFromCopyChildDialogView {get; set; } 
            public ArticleGenericChildDialogView ArticleGenericChildDialogView {get; set; } 
    }
            
    public partial class SalesQuoteSLQueryView : View
    {
        public SalesQuoteSLQueryView(SalesQuoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<SalesQuoteSLQueryView,SalesQuoteSLEntityView>( this,Screen.SalesQuoteSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "5affc1cc-84a6-409b-ad9b-8da6ee79547e",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<SalesQuoteSLQueryView,SalesQuoteSLEntityView>( params_MainConsult,this,Screen.SalesQuoteSLEntityView);
 

        }
        public IRPSButton<SalesQuoteSLQueryView,SalesQuoteSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<SalesQuoteSLQueryView,SalesQuoteSLEntityView> MainConsult { get; set; } 
        public SalesQuoteSL Screen { get; set; }
        public SalesQuoteSLQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SalesQuoteSLEntityView : View
    {
        public SalesQuoteSLEntityView(SalesQuoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<SalesQuoteSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<SalesQuoteSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SalesQuoteSLEntityView,SalesQuoteSLQueryView>( this,Screen.SalesQuoteSLQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<SalesQuoteSLEntityView,SalesQuoteSLQueryView>( this,Screen.SalesQuoteSLQueryView);
 
            UITotalLinesAmount = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteSLEntityView>("0deac0af-a0f2-46a1-84bc-a65925fb4529","","",false, this);
 
            TotalBase = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteSLEntityView>("599c96a5-d54e-4274-af8d-40725ea29989","","",false, this);
 
            TotalVAT = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteSLEntityView>("e93def56-7261-45a7-abf3-d3e54a0ca504","","",false, this);
 
            UITotalTax = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteSLEntityView>("bc4f90af-38c6-4ca2-84d7-b7fcb081caa4","","",false, this);
 
            UITotalSalesQuote = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteSLEntityView>("658b386f-ae8c-4766-b8ac-89e236eac939","","",false, this);
 
            UITotalCost = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteSLEntityView>("11f455ff-a7ad-40b1-bc51-f4e703707a44","","",false, this);
 
            UIMargin = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteSLEntityView>("0bb1b5a5-3227-4b09-8a1c-58ce41812f8e","","",false, this);
 
            UITotalAdvances = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteSLEntityView>("381f9ef4-e67c-404a-9e21-acb791920558","","",false, this);
 
            UICustomerRisk = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteSLEntityView>("79870f2c-f5fa-4f2f-afc2-da9e00aea46e","","",false, this);
 
            AddSalesQuoteLineFromCustomerArticleCommandButton = RPSControlFactory.CreateRPSButton<SalesQuoteSLEntityView>( "87711209-4d83-45c8-8232-d26ce6fb3317","","",this);
 
            InsertSalesQuoteLineFromQuotationCommandButton = RPSControlFactory.CreateRPSButton<SalesQuoteSLEntityView>( "7a632e13-e172-424e-8844-bd762fe98d4a","","",this);
 
            SalesQuoteChangesChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<SalesQuoteSLEntityView,SalesQuoteChangesChildDialogView>("8d62681c-1b51-487b-9c39-2ac60860e842","","", this,Screen.SalesQuoteChangesChildDialogView);
 
            CodSalesQuote = RPSControlFactory.CreateRPSTextBox<SalesQuoteSLEntityView>("42be107b-2192-498e-b943-2786606743f9","","",true, this);
 
            Version = RPSControlFactory.CreateRPSTextBox<SalesQuoteSLEntityView>("0ed0bc79-c418-4685-9413-710697e29c55","","",true, this);
 
            SalesQuoteDate = RPSControlFactory.CreateRPSTextBox<SalesQuoteSLEntityView>("9ebce4fa-8fb2-4150-bd74-1c4cb954c4ae","","",true, this);
 
            IDSalesQuoteStatus = RPSControlFactory.CreateRPSComboBox<SalesQuoteSLEntityView>("37d00b7b-3014-4d34-8993-62b545ee52cc","","",true, this);
 
            Probability = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteSLEntityView>("e42b8aa4-9d77-4443-9b0a-4c7fcdea7eec","","",true, this);
 
            Blocked = RPSControlFactory.CreateRPSCheckBox<SalesQuoteSLEntityView>("bfd83b22-eb2d-4195-9386-17de497659fb","","",true, this);
 
            Customer = RPSControlFactory.CreateRPSOption<SalesQuoteSLEntityView>( "41f6db4a-1a87-431c-a6de-95f81e64d3bf","","",this);
 
            PotentialCustomer = RPSControlFactory.CreateRPSOption<SalesQuoteSLEntityView>( "271cd2d1-3428-4a11-b93d-f00e0cba7826","","",this);
 
            EffectiveDate = RPSControlFactory.CreateRPSTextBox<SalesQuoteSLEntityView>("bcdf2e6d-f372-47af-9895-d66ba23677f9","","",true, this);
 
            ReceptionDate = RPSControlFactory.CreateRPSTextBox<SalesQuoteSLEntityView>("1c7c4312-e22d-4f9f-9d8f-6319a1cc68b6","","",true, this);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<SalesQuoteSLEntityView>("aa0e4a53-af05-4e7d-8b8e-fe71ee6c9336","","",false, this);
 
            FrameworkContract = RPSControlFactory.CreateRPSCheckBox<SalesQuoteSLEntityView>("9d746412-cb5f-434d-acfd-558fc2e26de4","","",true, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<SalesQuoteSLEntityView>("6bd7d2c5-0651-4118-b102-b79556c3a48f","","",false, this);
 
            IDCustomerMiscellaneous = RPSControlFactory.CreateRPSComboBox<SalesQuoteSLEntityView>("fba0a0d1-2bd6-4446-ac7f-0169c6531ecb","","",false, this);
 
            IDCustomerContact = RPSControlFactory.CreateRPSComboBox<SalesQuoteSLEntityView>("4e05dc48-7fbd-4619-9758-3efc00c0dd3a","","",false, this);
 
            IDCustomerDeliveryAddress = RPSControlFactory.CreateRPSComboBox<SalesQuoteSLEntityView>("6bf3b8cb-21e1-469b-b0ea-824a28b2992f","","",false, this);
 
            IDPotentialCustomer = RPSControlFactory.CreateRPSComboBox<SalesQuoteSLEntityView>("aae1594b-9a0b-4c44-a2dc-848ccef118eb","","",false, this);
 
            IDPotentialCustomerContact = RPSControlFactory.CreateRPSComboBox<SalesQuoteSLEntityView>("c0e3f961-a44f-4e01-aa2c-012c04f936f0","","",false, this);
 
            IDPotentialCustomerDeliveryAddress = RPSControlFactory.CreateRPSComboBox<SalesQuoteSLEntityView>("8bcbb0aa-783a-4d89-bfdc-3f66c22a00b6","","",false, this);
 
            UIOrderStatus = RPSControlFactory.CreateRPSTextBox<SalesQuoteSLEntityView>("7d4e5e97-57db-4a3f-9a51-38260c6226ec","","",false, this);
 
            IDSalesQuoteType = RPSControlFactory.CreateRPSComboBox<SalesQuoteSLEntityView>("6b430bbb-ae10-4d83-9c9d-491a5f9fe71f","","",true, this);
 
            IDCodingSerieOrder = RPSControlFactory.CreateRPSComboBox<SalesQuoteSLEntityView>("ff2ef0ae-cbd9-4c01-8066-562e547a6dd1","","",false, this);
 
            IDCodingSerieSalesQuote = RPSControlFactory.CreateRPSComboBox<SalesQuoteSLEntityView>("34060863-8e69-496b-a342-ae3b23d7ff4b","","",false, this);
 
            IDOportunity = RPSControlFactory.CreateRPSComboBox<SalesQuoteSLEntityView>("65615b87-5c20-488d-964f-687337a9cf37","","",false, this);
 
            IDCustomerPaymentAddress = RPSControlFactory.CreateRPSComboBox<SalesQuoteSLEntityView>("3b203d82-4fea-45b2-a8df-52a42616440f","","",false, this);
 
            IDInvoicingType = RPSControlFactory.CreateRPSComboBox<SalesQuoteSLEntityView>("ac65e200-cbb7-41d9-92f3-ba9dfd112a47","","",true, this);
 
            IDBusinessUnit = RPSControlFactory.CreateRPSComboBox<SalesQuoteSLEntityView>("4a4d0555-3938-42eb-972a-9f3854c4f7ee","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<SalesQuoteSLEntityView>("58668ec2-0a0c-4306-a656-158e9499670c","","",false, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<SalesQuoteSLEntityView>("dd0ddeb6-9164-4d19-abd8-cba24aa7090d","","",false, this);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<SalesQuoteSLEntityView>("b0f749e2-9b93-42c2-8b8f-984cc4d1223e","","",false, this);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSComboBox<SalesQuoteSLEntityView>("03f620c8-9617-447b-bf94-c53000b63a9d","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<SalesQuoteSLEntityView>("768bef89-79c8-4b51-a8e0-b7cd6337e9b3","","",true, this);
 
            Change = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteSLEntityView>("00c78e65-07fd-4aef-968f-65536ba24431","","",true, this);
 
            FixedChange = RPSControlFactory.CreateRPSCheckBox<SalesQuoteSLEntityView>("48731c7a-1bdf-4fd4-8bc0-84889a621128","","",false, this);
 
            IDPriceList = RPSControlFactory.CreateRPSComboBox<SalesQuoteSLEntityView>("88e4654c-7eff-42a5-a26e-0e2e53bd7b2e","","",false, this);
 
            IDVATType = RPSControlFactory.CreateRPSComboBox<SalesQuoteSLEntityView>("2eaa2e80-a96a-4403-8017-ed1ec5030b1c","","",true, this);
 
            IDSurchargeVATType = RPSControlFactory.CreateRPSComboBox<SalesQuoteSLEntityView>("8b0cbdea-e7b1-4801-b348-3399efb4f765","","",false, this);
 
            IDTaxGroup = RPSControlFactory.CreateRPSComboBox<SalesQuoteSLEntityView>("afbca65b-6455-42c4-88ed-5ff86b17e8bc","","",false, this);
 
            Discount1 = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteSLEntityView>("013da0bd-acdc-41be-b838-7251c65f7f49","","",true, this);
 
            Discount2 = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteSLEntityView>("3f087c98-9017-40f6-8140-66a4d65c8105","","",true, this);
 
            Discount3 = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteSLEntityView>("4c754992-1c00-4f1a-b33e-56475216eba2","","",true, this);
 
            CashDiscount = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteSLEntityView>("5934c1b3-4390-4ed3-bbf6-175dbcd23841","","",true, this);
 
            FinancialSurcharge = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteSLEntityView>("9fdcd62f-172b-46bb-b5d0-4267725da5c7","","",true, this);
 
            CodCountryDelivery = RPSControlFactory.CreateRPSComboBox<SalesQuoteSLEntityView>("7cee33d3-1b51-451f-ad3c-137cfc591df7","","",false, this);
 
            ZipCodeDelivery = RPSControlFactory.CreateRPSTextBox<SalesQuoteSLEntityView>("cc22b5f2-03f6-432a-aba8-85f6822ef59e","","",false, this);
 
            IDStateDelivery = RPSControlFactory.CreateRPSComboBox<SalesQuoteSLEntityView>("5b96e50c-15dd-453a-ad40-4e38eb1c242f","","",false, this);
 
            IDCountyDelivery = RPSControlFactory.CreateRPSComboBox<SalesQuoteSLEntityView>("98d707ab-697e-4a0c-af5a-56f88cb11e22","","",false, this);
 
            AddressDelivery = RPSControlFactory.CreateRPSTextBox<SalesQuoteSLEntityView>("79d83968-9988-476f-9dff-4cf4e25aea2e","","",false, this);
 
            AddressDescription = RPSControlFactory.CreateRPSTextBox<SalesQuoteSLEntityView>("d5333201-84f4-4e9d-b8be-72a2280a88f6","","",false, this);
 
            CityDelivery = RPSControlFactory.CreateRPSTextBox<SalesQuoteSLEntityView>("39923848-a555-4f10-aeb9-6d0d4c4c9203","","",false, this);
 
            Phone1Delivery = RPSControlFactory.CreateRPSTextBox<SalesQuoteSLEntityView>("63a15ebf-fa5f-436f-a513-4b20c715211b","","",false, this);
 
            Phone2Delivery = RPSControlFactory.CreateRPSTextBox<SalesQuoteSLEntityView>("62eb12f4-b8f3-44be-b265-dd3d9245aecc","","",false, this);
 
            FaxDelivery = RPSControlFactory.CreateRPSTextBox<SalesQuoteSLEntityView>("ad1ebd58-cbf4-4cf9-90dc-69e652d2e00e","","",false, this);
 
            ContactPersonDelivery = RPSControlFactory.CreateRPSTextBox<SalesQuoteSLEntityView>("b2a137a5-07c9-4845-ade2-e2f8117b32fb","","",false, this);
 
            CodBusinessType = RPSControlFactory.CreateRPSComboBox<SalesQuoteSLEntityView>("97a765f7-8ad1-4973-9c0c-fb30e4c11a99","","",false, this);
 
            CodTransportMethod = RPSControlFactory.CreateRPSComboBox<SalesQuoteSLEntityView>("c21096fb-d4ac-451e-9d5f-65dee8a7a1f5","","",false, this);
 
            CodHarborAirport = RPSControlFactory.CreateRPSComboBox<SalesQuoteSLEntityView>("28031775-132c-4469-81b7-9bb2153f1172","","",false, this);
 
            CodDeliveryTerm = RPSControlFactory.CreateRPSComboBox<SalesQuoteSLEntityView>("863bb916-9f97-4882-936c-bc89f886242d","","",false, this);
 
            StatisticRegime = RPSControlFactory.CreateRPSEnumComboBox<SalesQuoteSLEntityView>("dcf63248-c0cd-478f-8a0c-240a5a017ae1","","",true, this);
 
            ProductReference = RPSControlFactory.CreateRPSTextBox<SalesQuoteSLEntityView>("070e81be-e81e-4c30-97ad-6356cd564324","","",false, this);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<SalesQuoteSLEntityView>("9944d0cf-7f33-4cd5-a928-c3ca9264ccfc","","",false, this);
 
            IDCompositionTemplate = RPSControlFactory.CreateRPSComboBox<SalesQuoteSLEntityView>("2456faec-0702-47e3-9633-ed46814cc711","","",false, this);
 
            ExecuteGenerateSalesQuoteComposition = RPSControlFactory.CreateRPSButton<SalesQuoteSLEntityView>( "9ea85bfb-cb5d-4172-a5db-e7dce6df44f3","","",this);
 
            AddToCompositionExistingDocumentNavigationCommand = RPSControlFactory.CreateRPSButtonToView<SalesQuoteSLEntityView,AddToCompositionExistingDocumentDialogView>("41e81491-b749-4b5d-bc22-bb1ae69e2f43","","", this,Screen.AddToCompositionExistingDocumentDialogView);
 
            AddToCompositionSalesQuoteHeaderNavigationCommand = RPSControlFactory.CreateRPSButtonToView<SalesQuoteSLEntityView,AddToCompositionSalesQuoteHeaderDialogView>("6ed29381-ee24-409b-a126-b04656fe0d49","","", this,Screen.AddToCompositionSalesQuoteHeaderDialogView);
 
            AddToCompositionArticleDocumentNavigationCommand = RPSControlFactory.CreateRPSButtonToView<SalesQuoteSLEntityView,AddToCompositionArticleDocumentDialogView>("a213b67a-a271-4f61-a108-04e9edbd659b","","", this,Screen.AddToCompositionArticleDocumentDialogView);
 
            AddToCompositionReportNavigationCommand = RPSControlFactory.CreateRPSButtonToView<SalesQuoteSLEntityView,AddToCompositionReportDialogView>("683804dc-aca4-4289-9a61-5b7876a12b62","","", this,Screen.AddToCompositionReportDialogView);
 
            SalesQuoteComAgentNewChildNavigationCommand = RPSControlFactory.CreateRPSButtonToView<SalesQuoteSLEntityView,SalesQuoteComAgentNewChildDialogView>("eba027b1-cb12-4501-a74a-29d64b1fe111","","", this,Screen.SalesQuoteComAgentNewChildDialogView);
 
            UITotalLinesFixed = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteSLEntityView>("6c1007eb-2f00-4f80-b0b8-f20e157737d9","","",false, this);
 
            UITotalCostFixed = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteSLEntityView>("c5a1dd9b-bf5a-4c2b-85c4-fadc9f9b7a71","","",false, this);
 
            UIMarginFixed = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteSLEntityView>("ff2adddd-29b7-4a0d-a477-9e65fac8bbf0","","",false, this);
 
            UITotalLinesAmount1 = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteSLEntityView>("e9596cc9-b023-4c52-86a8-958b2fa4179b","","",false, this);
 
            UITotalCost1 = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteSLEntityView>("4a1603ab-f1ab-4efd-bf9e-f5c6bb28cb72","","",false, this);
 
            UIMargin1 = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteSLEntityView>("ac7629d0-5811-4a44-90e0-f9a7ff4b8b5b","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<SalesQuoteSLEntityView>("f3c1943a-d09c-46ee-89bc-1e16537fc3da","","",false, this);
 
            PreTextIDTextLine = RPSControlFactory.CreateRPSComboBox<SalesQuoteSLEntityView>("6b02f427-3458-4d90-9776-36b79e1b0e14","","",false, this);
 
            PreText = RPSControlFactory.CreateRPSTextBox<SalesQuoteSLEntityView>("7e4b95cf-bf35-4c2d-9c39-ff231d388f42","","",false, this);
 
            PostTextIDTextLine = RPSControlFactory.CreateRPSComboBox<SalesQuoteSLEntityView>("66695419-bf76-4f15-a2bf-9d38fa0abb5b","","",false, this);
 
            PostText = RPSControlFactory.CreateRPSTextBox<SalesQuoteSLEntityView>("5b9555a7-3396-4d36-bbd5-c3e9df571bb8","","",false, this);
 
            IDCPQModel = RPSControlFactory.CreateRPSComboBox<SalesQuoteSLEntityView>("256ce78b-650c-4380-869d-067a482474b4","","",false, this);
 
            NewCPQProduct = RPSControlFactory.CreateRPSButton<SalesQuoteSLEntityView>( "1bcf744f-91fa-41be-ab41-65f2b62ff31a","","",this);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<SalesQuoteSLEntityView>("8c1d1b44-b307-4520-8b3f-a956851c21f6","","",false, this);
 
            SalesQuotePrintNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<SalesQuoteSLEntityView,SalesQuotePrintDialogView>("69dd0c11-f30f-4eb0-b354-33773931c59a","","", this,Screen.SalesQuotePrintDialogView);
 
            SalesQuoteProformaPrintNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<SalesQuoteSLEntityView,SalesQuoteProFormaPrintDialogView>("6c4e6d7f-253e-4b3b-9e0a-15347bf1cb72","","", this,Screen.SalesQuoteProFormaPrintDialogView);
 
            TotalsUpdateButton = RPSControlFactory.CreateRPSButton<SalesQuoteSLEntityView>( "b0ec4e7d-c1a9-44af-bd2e-f25bbb10d3ab","","",this);
 
            NewVersionChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<SalesQuoteSLEntityView,NewVersionChildDialogView>("f6d30d6c-f866-40c6-ab80-229eebf0cb28","","", this,Screen.NewVersionChildDialogView);
 
            OrderDataChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<SalesQuoteSLEntityView,OrderDataChildDialogView>("bf677548-01f2-4cc2-ae67-bb1d3260d29e","","", this,Screen.OrderDataChildDialogView);
 
            GenerateCustomerArticleChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<SalesQuoteSLEntityView,GenerateCustomerArticleChildDialogView>("8368bdd3-eb77-4e67-ac06-ef3a651b91fc","","", this,Screen.GenerateCustomerArticleChildDialogView);
 
            NewActivityButton = RPSControlFactory.CreateRPSButton<SalesQuoteSLEntityView>( "70bda7df-bd2b-4a44-8bb4-7a7dd270095c","","",this);
 
            FrameworkContractFromSalesQuoteChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<SalesQuoteSLEntityView,FrameworkContractFromSalesQuoteChildDialogView>("6a377c6d-04d1-437d-b697-74ef788cbba5","","", this,Screen.FrameworkContractFromSalesQuoteChildDialogView);
 
            OptionChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<SalesQuoteSLEntityView,OptionChildDialogView>("22d0d47f-ea2c-4899-8253-322c570a1820","","", this,Screen.OptionChildDialogView);
 
            NewFromCopyChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<SalesQuoteSLEntityView,NewFromCopyChildDialogView>("6af05639-d73f-4911-864a-b22531312d0e","","", this,Screen.NewFromCopyChildDialogView);
 
            ExecuteRecalculateSalesQuoteCostsButton = RPSControlFactory.CreateRPSButton<SalesQuoteSLEntityView>( "c81319ed-e8f8-4779-aa1a-6cad4d6e575f","","",this);
 
            RecalculatePromotionButton = RPSControlFactory.CreateRPSButton<SalesQuoteSLEntityView>( "04531acd-51a2-479c-ab31-6d845fcfe345","","",this);
 
            RealCustomerReassignButton = RPSControlFactory.CreateRPSButton<SalesQuoteSLEntityView>( "2ed47dbd-4137-42ef-8647-24d9b1634d71","","",this);
 
            ChangeCustomerChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<SalesQuoteSLEntityView,ChangeCustomerChildDialogView>("d36ac6ae-617a-4b77-a805-e5a183888028","","", this,Screen.ChangeCustomerChildDialogView);
 
            RecalculateIndexButton = RPSControlFactory.CreateRPSButton<SalesQuoteSLEntityView>( "843d6e44-ef5a-439c-ade6-92fbffbbc725","","",this);
 
            CuDistCalculateGroupsAmountCommandButton = RPSControlFactory.CreateRPSButton<SalesQuoteSLEntityView>( "6e95bae6-606c-4456-8722-8ac717406281","","",this);
 
            UICompositionDocument = RPSControlFactory.CreateRPSComboBox<SalesQuoteSLEntityView>("9eb8795c-86ae-4ed7-8c67-b525bf596109","","",false, this);
 
            CollectionInit params_SalesQuoteLineSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="9537a1b1-8e42-4f2f-a499-1dd00832d10a",CSSSelectorGrid="",XPathGrid=""};
            SalesQuoteLineSLs = RPSControlFactory.RPSCreateCollectionWithGrid<SalesQuoteLineSLsCollectionEditor<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView>,SalesQuoteSLEntityView,SalesQuoteIncidenceSLView>( params_SalesQuoteLineSLs,this,Screen.SalesQuoteIncidenceSLView);
 
            CollectionInit params_SalesQuoteAdvanceSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a41585d5-2b08-4ca4-a278-dd42e879e530",CSSSelectorGrid="",XPathGrid=""};
            SalesQuoteAdvanceSLs = RPSControlFactory.RPSCreateCollectionWithGrid<SalesQuoteAdvanceSLsCollectionEditor<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView>,SalesQuoteSLEntityView,SalesQuoteIncidenceSLView>( params_SalesQuoteAdvanceSLs,this,Screen.SalesQuoteIncidenceSLView);
 
            CollectionInit params_SalesQuoteVariablePaymentSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5fc5231a-b3e5-4a30-b183-1d08f5c72b83",CSSSelectorGrid="",XPathGrid=""};
            SalesQuoteVariablePaymentSLs = RPSControlFactory.RPSCreateCollectionWithGrid<SalesQuoteVariablePaymentSLsCollectionEditor<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView>,SalesQuoteSLEntityView,SalesQuoteIncidenceSLView>( params_SalesQuoteVariablePaymentSLs,this,Screen.SalesQuoteIncidenceSLView);
 
            CollectionInit params_SalesQuoteIncidenceSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b824dbae-397a-4157-bf62-e5b1418ff5ac",CSSSelectorGrid="",XPathGrid=""};
            SalesQuoteIncidenceSLs = RPSControlFactory.RPSCreateCollectionWithGrid<SalesQuoteIncidenceSLsCollectionEditor<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView>,SalesQuoteSLEntityView,SalesQuoteIncidenceSLView>( params_SalesQuoteIncidenceSLs,this,Screen.SalesQuoteIncidenceSLView);
 
            CollectionInit params_SalesQuoteMilestoneSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="37a5f34e-39cf-4f17-b779-5657940c9a73",CSSSelectorGrid="",XPathGrid=""};
            SalesQuoteMilestoneSLs = RPSControlFactory.RPSCreateCollectionWithGrid<SalesQuoteMilestoneSLsCollectionEditor<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView>,SalesQuoteSLEntityView,SalesQuoteIncidenceSLView>( params_SalesQuoteMilestoneSLs,this,Screen.SalesQuoteIncidenceSLView);
 
            CollectionInit params_SalesQuoteCompositionSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="89547da9-57bc-422d-885f-d449428c80dd",CSSSelectorGrid="",XPathGrid=""};
            SalesQuoteCompositionSLs = RPSControlFactory.RPSCreateCollectionWithGrid<SalesQuoteCompositionSLsCollectionEditor<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView>,SalesQuoteSLEntityView,SalesQuoteIncidenceSLView>( params_SalesQuoteCompositionSLs,this,Screen.SalesQuoteIncidenceSLView);
 
            CollectionInit params_SalesQuoteComAgentSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c2f6af7b-aa03-4d58-be00-5ecc65df1222",CSSSelectorGrid="",XPathGrid=""};
            SalesQuoteComAgentSLs = RPSControlFactory.RPSCreateCollectionWithGrid<SalesQuoteComAgentSLsCollectionEditor<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView>,SalesQuoteSLEntityView,SalesQuoteIncidenceSLView>( params_SalesQuoteComAgentSLs,this,Screen.SalesQuoteIncidenceSLView);
 
            CollectionInit params_SalesQuoteOptionSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6cd53d4f-720e-489e-bcec-1df538b82fdf",CSSSelectorGrid="",XPathGrid=""};
            SalesQuoteOptionSLs = RPSControlFactory.RPSCreateCollectionWithGrid<SalesQuoteOptionSLsCollectionEditor<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView>,SalesQuoteSLEntityView,SalesQuoteIncidenceSLView>( params_SalesQuoteOptionSLs,this,Screen.SalesQuoteIncidenceSLView);
 
            CollectionInit params_CPQProduct = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="2c5275b1-19e5-492e-9fbe-6e4223d08ef1",CSSSelectorGrid="",XPathGrid=""};
            CPQProduct = RPSControlFactory.RPSCreateCollectionWithGrid<CPQProductCollectionEditor<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView>,SalesQuoteSLEntityView,SalesQuoteIncidenceSLView>( params_CPQProduct,this,Screen.SalesQuoteIncidenceSLView);
 
            CollectionInit params_CuDistSalesQuoteGroups = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7d777cb6-a30e-4d98-a1df-84cdd46e1fa8",CSSSelectorGrid="",XPathGrid=""};
            CuDistSalesQuoteGroups = RPSControlFactory.RPSCreateCollectionWithGrid<CuDistSalesQuoteGroupsCollectionEditor<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView>,SalesQuoteSLEntityView,SalesQuoteIncidenceSLView>( params_CuDistSalesQuoteGroups,this,Screen.SalesQuoteIncidenceSLView);
 
            CollectionInit params_EntityDocuments = new CollectionInit(){IDDescriptor = "11730e96-e83f-48f5-adf0-d645daf264c3",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            EntityDocuments = RPSControlFactory.RPSCreateCollection<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView>( params_EntityDocuments,this,Screen.SalesQuoteIncidenceSLView);
 
            Lines = RPSControlFactory.CreateRPSSection<SalesQuoteSLEntityView>( "","ul li[rpsid='ed13021c-39ab-4ddb-81f6-c4279b5ea8dd']","",this);
 
            GeneralData = RPSControlFactory.CreateRPSSection<SalesQuoteSLEntityView>( "","ul li[rpsid='07c02993-3551-4c25-a190-df649c8d70d3']","",this);
 
            Advances = RPSControlFactory.CreateRPSSection<SalesQuoteSLEntityView>( "","ul li[rpsid='6a8a398b-f11d-4ad1-9345-647f389cb61c']","",this);
 
            VariablePaymentMethods = RPSControlFactory.CreateRPSSection<SalesQuoteSLEntityView>( "","ul li[rpsid='620a31ec-1d08-4282-964d-56c7e12c0719']","",this);
 
            Incidences = RPSControlFactory.CreateRPSSection<SalesQuoteSLEntityView>( "","ul li[rpsid='59c0dba0-8f63-4d52-af0b-d262f4abe506']","",this);
 
            Milestones = RPSControlFactory.CreateRPSSection<SalesQuoteSLEntityView>( "","ul li[rpsid='cf9f2fd4-27df-4901-94e5-eaba0eecc15b']","",this);
 
            SalesQuoteComposition = RPSControlFactory.CreateRPSSection<SalesQuoteSLEntityView>( "","ul li[rpsid='8426b570-1af0-421b-a14d-2b28bab51b36']","",this);
 
            Commissions = RPSControlFactory.CreateRPSSection<SalesQuoteSLEntityView>( "","ul li[rpsid='2ce98493-80af-4c1f-bd6d-57c88aee3913']","",this);
 
            Options = RPSControlFactory.CreateRPSSection<SalesQuoteSLEntityView>( "","ul li[rpsid='1d4ec139-830c-478f-961b-df26ffd4f68a']","",this);
 
            Comment1 = RPSControlFactory.CreateRPSSection<SalesQuoteSLEntityView>( "","ul li[rpsid='f943d48e-ed56-4d2f-adde-16ed08e86141']","",this);
 
            TextLine = RPSControlFactory.CreateRPSSection<SalesQuoteSLEntityView>( "","ul li[rpsid='277ceb99-4eda-4a3f-8024-9fd412274d03']","",this);
 
            Configurator = RPSControlFactory.CreateRPSSection<SalesQuoteSLEntityView>( "","ul li[rpsid='381307cb-b86f-468a-a7fe-801441824ecc']","",this);
 
            DPS = RPSControlFactory.CreateRPSSection<SalesQuoteSLEntityView>( "","ul li[rpsid='53e8bb9f-2d57-47c9-a50a-494444460c59']","",this);
 
            SalesQuoteGroup = RPSControlFactory.CreateRPSSection<SalesQuoteSLEntityView>( "","ul li[rpsid='06cb0b3e-a65b-41c6-b6d4-de8ba51d5572']","",this);
 

        }
        public IRPSSaveButton<SalesQuoteSLEntityView> SaveButton { get; set; } 
        public IRPSButton<SalesQuoteSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<SalesQuoteSLEntityView,SalesQuoteSLQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SalesQuoteSLEntityView,SalesQuoteSLQueryView> BackButton { get; set; } 
        public IRPSTextBox<SalesQuoteSLEntityView> UITotalLinesAmount { get; set; } 
        public IRPSTextBox<SalesQuoteSLEntityView> TotalBase { get; set; } 
        public IRPSTextBox<SalesQuoteSLEntityView> TotalVAT { get; set; } 
        public IRPSTextBox<SalesQuoteSLEntityView> UITotalTax { get; set; } 
        public IRPSTextBox<SalesQuoteSLEntityView> UITotalSalesQuote { get; set; } 
        public IRPSTextBox<SalesQuoteSLEntityView> UITotalCost { get; set; } 
        public IRPSTextBox<SalesQuoteSLEntityView> UIMargin { get; set; } 
        public IRPSTextBox<SalesQuoteSLEntityView> UITotalAdvances { get; set; } 
        public IRPSTextBox<SalesQuoteSLEntityView> UICustomerRisk { get; set; } 
        public IRPSButton<SalesQuoteSLEntityView> AddSalesQuoteLineFromCustomerArticleCommandButton { get; set; } 
        public IRPSButton<SalesQuoteSLEntityView> InsertSalesQuoteLineFromQuotationCommandButton { get; set; } 
        public IRPSButton<SalesQuoteSLEntityView,SalesQuoteChangesChildDialogView> SalesQuoteChangesChildNavigationCommandButton { get; set; } 
        public IRPSTextBox<SalesQuoteSLEntityView> CodSalesQuote { get; set; } 
        public IRPSTextBox<SalesQuoteSLEntityView> Version { get; set; } 
        public IRPSTextBox<SalesQuoteSLEntityView> SalesQuoteDate { get; set; } 
        public IRPSComboBox<SalesQuoteSLEntityView> IDSalesQuoteStatus { get; set; } 
        public IRPSTextBox<SalesQuoteSLEntityView> Probability { get; set; } 
        public IRPSCheckbox<SalesQuoteSLEntityView> Blocked { get; set; } 
        public IRPSOption<SalesQuoteSLEntityView> Customer { get; set; } 
        public IRPSOption<SalesQuoteSLEntityView> PotentialCustomer { get; set; } 
        public IRPSTextBox<SalesQuoteSLEntityView> EffectiveDate { get; set; } 
        public IRPSTextBox<SalesQuoteSLEntityView> ReceptionDate { get; set; } 
        public IRPSComboBox<SalesQuoteSLEntityView> CodUser { get; set; } 
        public IRPSCheckbox<SalesQuoteSLEntityView> FrameworkContract { get; set; } 
        public IRPSComboBox<SalesQuoteSLEntityView> IDCustomer { get; set; } 
        public IRPSComboBox<SalesQuoteSLEntityView> IDCustomerMiscellaneous { get; set; } 
        public IRPSComboBox<SalesQuoteSLEntityView> IDCustomerContact { get; set; } 
        public IRPSComboBox<SalesQuoteSLEntityView> IDCustomerDeliveryAddress { get; set; } 
        public IRPSComboBox<SalesQuoteSLEntityView> IDPotentialCustomer { get; set; } 
        public IRPSComboBox<SalesQuoteSLEntityView> IDPotentialCustomerContact { get; set; } 
        public IRPSComboBox<SalesQuoteSLEntityView> IDPotentialCustomerDeliveryAddress { get; set; } 
        public IRPSTextBox<SalesQuoteSLEntityView> UIOrderStatus { get; set; } 
        public IRPSComboBox<SalesQuoteSLEntityView> IDSalesQuoteType { get; set; } 
        public IRPSComboBox<SalesQuoteSLEntityView> IDCodingSerieOrder { get; set; } 
        public IRPSComboBox<SalesQuoteSLEntityView> IDCodingSerieSalesQuote { get; set; } 
        public IRPSComboBox<SalesQuoteSLEntityView> IDOportunity { get; set; } 
        public IRPSComboBox<SalesQuoteSLEntityView> IDCustomerPaymentAddress { get; set; } 
        public IRPSComboBox<SalesQuoteSLEntityView> IDInvoicingType { get; set; } 
        public IRPSComboBox<SalesQuoteSLEntityView> IDBusinessUnit { get; set; } 
        public IRPSComboBox<SalesQuoteSLEntityView> IDSite { get; set; } 
        public IRPSComboBox<SalesQuoteSLEntityView> IDWarehouse { get; set; } 
        public IRPSComboBox<SalesQuoteSLEntityView> IDDeliveryNoteType { get; set; } 
        public IRPSComboBox<SalesQuoteSLEntityView> IDPaymentMethod { get; set; } 
        public IRPSComboBox<SalesQuoteSLEntityView> IDCurrency { get; set; } 
        public IRPSTextBox<SalesQuoteSLEntityView> Change { get; set; } 
        public IRPSCheckbox<SalesQuoteSLEntityView> FixedChange { get; set; } 
        public IRPSComboBox<SalesQuoteSLEntityView> IDPriceList { get; set; } 
        public IRPSComboBox<SalesQuoteSLEntityView> IDVATType { get; set; } 
        public IRPSComboBox<SalesQuoteSLEntityView> IDSurchargeVATType { get; set; } 
        public IRPSComboBox<SalesQuoteSLEntityView> IDTaxGroup { get; set; } 
        public IRPSTextBox<SalesQuoteSLEntityView> Discount1 { get; set; } 
        public IRPSTextBox<SalesQuoteSLEntityView> Discount2 { get; set; } 
        public IRPSTextBox<SalesQuoteSLEntityView> Discount3 { get; set; } 
        public IRPSTextBox<SalesQuoteSLEntityView> CashDiscount { get; set; } 
        public IRPSTextBox<SalesQuoteSLEntityView> FinancialSurcharge { get; set; } 
        public IRPSComboBox<SalesQuoteSLEntityView> CodCountryDelivery { get; set; } 
        public IRPSTextBox<SalesQuoteSLEntityView> ZipCodeDelivery { get; set; } 
        public IRPSComboBox<SalesQuoteSLEntityView> IDStateDelivery { get; set; } 
        public IRPSComboBox<SalesQuoteSLEntityView> IDCountyDelivery { get; set; } 
        public IRPSTextBox<SalesQuoteSLEntityView> AddressDelivery { get; set; } 
        public IRPSTextBox<SalesQuoteSLEntityView> AddressDescription { get; set; } 
        public IRPSTextBox<SalesQuoteSLEntityView> CityDelivery { get; set; } 
        public IRPSTextBox<SalesQuoteSLEntityView> Phone1Delivery { get; set; } 
        public IRPSTextBox<SalesQuoteSLEntityView> Phone2Delivery { get; set; } 
        public IRPSTextBox<SalesQuoteSLEntityView> FaxDelivery { get; set; } 
        public IRPSTextBox<SalesQuoteSLEntityView> ContactPersonDelivery { get; set; } 
        public IRPSComboBox<SalesQuoteSLEntityView> CodBusinessType { get; set; } 
        public IRPSComboBox<SalesQuoteSLEntityView> CodTransportMethod { get; set; } 
        public IRPSComboBox<SalesQuoteSLEntityView> CodHarborAirport { get; set; } 
        public IRPSComboBox<SalesQuoteSLEntityView> CodDeliveryTerm { get; set; } 
        public IRPSComboBox<SalesQuoteSLEntityView> StatisticRegime { get; set; } 
        public IRPSTextBox<SalesQuoteSLEntityView> ProductReference { get; set; } 
        public IRPSComboBox<SalesQuoteSLEntityView> IDProject { get; set; } 
        public IRPSComboBox<SalesQuoteSLEntityView> IDCompositionTemplate { get; set; } 
        public IRPSButton<SalesQuoteSLEntityView> ExecuteGenerateSalesQuoteComposition { get; set; } 
        public IRPSButton<SalesQuoteSLEntityView,AddToCompositionExistingDocumentDialogView> AddToCompositionExistingDocumentNavigationCommand { get; set; } 
        public IRPSButton<SalesQuoteSLEntityView,AddToCompositionSalesQuoteHeaderDialogView> AddToCompositionSalesQuoteHeaderNavigationCommand { get; set; } 
        public IRPSButton<SalesQuoteSLEntityView,AddToCompositionArticleDocumentDialogView> AddToCompositionArticleDocumentNavigationCommand { get; set; } 
        public IRPSButton<SalesQuoteSLEntityView,AddToCompositionReportDialogView> AddToCompositionReportNavigationCommand { get; set; } 
        public IRPSButton<SalesQuoteSLEntityView,SalesQuoteComAgentNewChildDialogView> SalesQuoteComAgentNewChildNavigationCommand { get; set; } 
        public IRPSTextBox<SalesQuoteSLEntityView> UITotalLinesFixed { get; set; } 
        public IRPSTextBox<SalesQuoteSLEntityView> UITotalCostFixed { get; set; } 
        public IRPSTextBox<SalesQuoteSLEntityView> UIMarginFixed { get; set; } 
        public IRPSTextBox<SalesQuoteSLEntityView> UITotalLinesAmount1 { get; set; } 
        public IRPSTextBox<SalesQuoteSLEntityView> UITotalCost1 { get; set; } 
        public IRPSTextBox<SalesQuoteSLEntityView> UIMargin1 { get; set; } 
        public IRPSTextBox<SalesQuoteSLEntityView> Comment { get; set; } 
        public IRPSComboBox<SalesQuoteSLEntityView> PreTextIDTextLine { get; set; } 
        public IRPSTextBox<SalesQuoteSLEntityView> PreText { get; set; } 
        public IRPSComboBox<SalesQuoteSLEntityView> PostTextIDTextLine { get; set; } 
        public IRPSTextBox<SalesQuoteSLEntityView> PostText { get; set; } 
        public IRPSComboBox<SalesQuoteSLEntityView> IDCPQModel { get; set; } 
        public IRPSButton<SalesQuoteSLEntityView> NewCPQProduct { get; set; } 
        public IRPSComboBox<SalesQuoteSLEntityView> IDEmployee { get; set; } 
        public IRPSButton<SalesQuoteSLEntityView,SalesQuotePrintDialogView> SalesQuotePrintNavigationCommandButton { get; set; } 
        public IRPSButton<SalesQuoteSLEntityView,SalesQuoteProFormaPrintDialogView> SalesQuoteProformaPrintNavigationCommandButton { get; set; } 
        public IRPSButton<SalesQuoteSLEntityView> TotalsUpdateButton { get; set; } 
        public IRPSButton<SalesQuoteSLEntityView,NewVersionChildDialogView> NewVersionChildNavigationCommandButton { get; set; } 
        public IRPSButton<SalesQuoteSLEntityView,OrderDataChildDialogView> OrderDataChildNavigationCommandButton { get; set; } 
        public IRPSButton<SalesQuoteSLEntityView,GenerateCustomerArticleChildDialogView> GenerateCustomerArticleChildNavigationCommandButton { get; set; } 
        public IRPSButton<SalesQuoteSLEntityView> NewActivityButton { get; set; } 
        public IRPSButton<SalesQuoteSLEntityView,FrameworkContractFromSalesQuoteChildDialogView> FrameworkContractFromSalesQuoteChildNavigationCommandButton { get; set; } 
        public IRPSButton<SalesQuoteSLEntityView,OptionChildDialogView> OptionChildNavigationCommandButton { get; set; } 
        public IRPSButton<SalesQuoteSLEntityView,NewFromCopyChildDialogView> NewFromCopyChildNavigationCommandButton { get; set; } 
        public IRPSButton<SalesQuoteSLEntityView> ExecuteRecalculateSalesQuoteCostsButton { get; set; } 
        public IRPSButton<SalesQuoteSLEntityView> RecalculatePromotionButton { get; set; } 
        public IRPSButton<SalesQuoteSLEntityView> RealCustomerReassignButton { get; set; } 
        public IRPSButton<SalesQuoteSLEntityView,ChangeCustomerChildDialogView> ChangeCustomerChildNavigationCommandButton { get; set; } 
        public IRPSButton<SalesQuoteSLEntityView> RecalculateIndexButton { get; set; } 
        public IRPSButton<SalesQuoteSLEntityView> CuDistCalculateGroupsAmountCommandButton { get; set; } 
        public IRPSComboBox<SalesQuoteSLEntityView> UICompositionDocument { get; set; } 
        public SalesQuoteLineSLsCollectionEditor<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> SalesQuoteLineSLs { get; set; } 
        public SalesQuoteAdvanceSLsCollectionEditor<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> SalesQuoteAdvanceSLs { get; set; } 
        public SalesQuoteVariablePaymentSLsCollectionEditor<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> SalesQuoteVariablePaymentSLs { get; set; } 
        public SalesQuoteIncidenceSLsCollectionEditor<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> SalesQuoteIncidenceSLs { get; set; } 
        public SalesQuoteMilestoneSLsCollectionEditor<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> SalesQuoteMilestoneSLs { get; set; } 
        public SalesQuoteCompositionSLsCollectionEditor<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> SalesQuoteCompositionSLs { get; set; } 
        public SalesQuoteComAgentSLsCollectionEditor<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> SalesQuoteComAgentSLs { get; set; } 
        public SalesQuoteOptionSLsCollectionEditor<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> SalesQuoteOptionSLs { get; set; } 
        public CPQProductCollectionEditor<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> CPQProduct { get; set; } 
        public CuDistSalesQuoteGroupsCollectionEditor<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> CuDistSalesQuoteGroups { get; set; } 
        public IRPSCollectionEditor<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> EntityDocuments { get; set; } 
        public IRPSSection<SalesQuoteSLEntityView> Lines { get; set; } 
        public IRPSSection<SalesQuoteSLEntityView> GeneralData { get; set; } 
        public IRPSSection<SalesQuoteSLEntityView> Advances { get; set; } 
        public IRPSSection<SalesQuoteSLEntityView> VariablePaymentMethods { get; set; } 
        public IRPSSection<SalesQuoteSLEntityView> Incidences { get; set; } 
        public IRPSSection<SalesQuoteSLEntityView> Milestones { get; set; } 
        public IRPSSection<SalesQuoteSLEntityView> SalesQuoteComposition { get; set; } 
        public IRPSSection<SalesQuoteSLEntityView> Commissions { get; set; } 
        public IRPSSection<SalesQuoteSLEntityView> Options { get; set; } 
        public IRPSSection<SalesQuoteSLEntityView> Comment1 { get; set; } 
        public IRPSSection<SalesQuoteSLEntityView> TextLine { get; set; } 
        public IRPSSection<SalesQuoteSLEntityView> Configurator { get; set; } 
        public IRPSSection<SalesQuoteSLEntityView> DPS { get; set; } 
        public IRPSSection<SalesQuoteSLEntityView> SalesQuoteGroup { get; set; } 
        public SalesQuoteSL Screen { get; set; }
        public SalesQuoteSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SalesQuoteLineSLsCollectionEditor<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView>:RPSCollectionEditor<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> where SalesQuoteSLEntityView : class, IView where SalesQuoteIncidenceSLView : class, IView
    {
        public  SalesQuoteLineSLsGridView<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> GridView {get;set;}
    }
    public partial class SalesQuoteLineSLsGridView <SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> :  RPSGridView<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> where SalesQuoteSLEntityView : class, IView where SalesQuoteIncidenceSLView : class, IView
    {
        public SalesQuoteLineSLsGridView(SalesQuoteSLEntityView currentView,SalesQuoteIncidenceSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Ordenation = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesQuoteSLEntityView>("","#9537a1b1-8e42-4f2f-a499-1dd00832d10a .ag-row[role='row']@ROWINDEX [col-id='cOrdenation']","",true, this.CurrentView);
 
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<SalesQuoteSLEntityView>("","#9537a1b1-8e42-4f2f-a499-1dd00832d10a .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<SalesQuoteSLEntityView>("","#9537a1b1-8e42-4f2f-a499-1dd00832d10a .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            PlanNumber = RPSControlFactory.CreateRPSGridTextBox<SalesQuoteSLEntityView>("","#9537a1b1-8e42-4f2f-a499-1dd00832d10a .ag-row[role='row']@ROWINDEX [col-id='cPlanNumber']","",false, this.CurrentView);
 
            IDSalesQuoteGroup = RPSControlFactory.CreateRPSGridComboBox<SalesQuoteSLEntityView>("","#9537a1b1-8e42-4f2f-a499-1dd00832d10a .ag-row[role='row']@ROWINDEX [col-id='cIDSalesQuoteGroup']","",false, this.CurrentView);
 
            ReceptionDate = RPSControlFactory.CreateRPSGridTextBox<SalesQuoteSLEntityView>("","#9537a1b1-8e42-4f2f-a499-1dd00832d10a .ag-row[role='row']@ROWINDEX [col-id='cReceptionDate']","",true, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesQuoteSLEntityView>("","#9537a1b1-8e42-4f2f-a499-1dd00832d10a .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            Discount1 = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesQuoteSLEntityView>("","#9537a1b1-8e42-4f2f-a499-1dd00832d10a .ag-row[role='row']@ROWINDEX [col-id='cDiscount1']","",true, this.CurrentView);
 
            AcceptedQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesQuoteSLEntityView>("","#9537a1b1-8e42-4f2f-a499-1dd00832d10a .ag-row[role='row']@ROWINDEX [col-id='cAcceptedQuantity']","",true, this.CurrentView);
 
            Price = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesQuoteSLEntityView>("","#9537a1b1-8e42-4f2f-a499-1dd00832d10a .ag-row[role='row']@ROWINDEX [col-id='cPrice']","",true, this.CurrentView);
 
            PercentVAT = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesQuoteSLEntityView>("","#9537a1b1-8e42-4f2f-a499-1dd00832d10a .ag-row[role='row']@ROWINDEX [col-id='cPercentVAT']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesQuoteSLEntityView>("","#9537a1b1-8e42-4f2f-a499-1dd00832d10a .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",false, this.CurrentView);
 
            AmountWithVAT = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesQuoteSLEntityView>("","#9537a1b1-8e42-4f2f-a499-1dd00832d10a .ag-row[role='row']@ROWINDEX [col-id='cAmountWithVAT']","",true, this.CurrentView);
 
            Index = RPSControlFactory.CreateRPSGridTextBox<SalesQuoteSLEntityView>("","#9537a1b1-8e42-4f2f-a499-1dd00832d10a .ag-row[role='row']@ROWINDEX [col-id='cIndex']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SalesQuoteSLEntityView> Ordenation { get; set; } 
        public IRPSGridComboBox<SalesQuoteSLEntityView> IDArticle { get; set; } 
        public IRPSGridTextBox<SalesQuoteSLEntityView> Description { get; set; } 
        public IRPSGridTextBox<SalesQuoteSLEntityView> PlanNumber { get; set; } 
        public IRPSGridComboBox<SalesQuoteSLEntityView> IDSalesQuoteGroup { get; set; } 
        public IRPSGridTextBox<SalesQuoteSLEntityView> ReceptionDate { get; set; } 
        public IRPSGridTextBox<SalesQuoteSLEntityView> Quantity { get; set; } 
        public IRPSGridTextBox<SalesQuoteSLEntityView> Discount1 { get; set; } 
        public IRPSGridTextBox<SalesQuoteSLEntityView> AcceptedQuantity { get; set; } 
        public IRPSGridTextBox<SalesQuoteSLEntityView> Price { get; set; } 
        public IRPSGridTextBox<SalesQuoteSLEntityView> PercentVAT { get; set; } 
        public IRPSGridTextBox<SalesQuoteSLEntityView> Amount { get; set; } 
        public IRPSGridTextBox<SalesQuoteSLEntityView> AmountWithVAT { get; set; } 
        public IRPSGridTextBox<SalesQuoteSLEntityView> Index { get; set; } 
                     
    }
 
        public partial class SalesQuoteAdvanceSLsCollectionEditor<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView>:RPSCollectionEditor<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> where SalesQuoteSLEntityView : class, IView where SalesQuoteIncidenceSLView : class, IView
    {
        public  SalesQuoteAdvanceSLsGridView<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> GridView {get;set;}
    }
    public partial class SalesQuoteAdvanceSLsGridView <SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> :  RPSGridView<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> where SalesQuoteSLEntityView : class, IView where SalesQuoteIncidenceSLView : class, IView
    {
        public SalesQuoteAdvanceSLsGridView(SalesQuoteSLEntityView currentView,SalesQuoteIncidenceSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NumAdvance = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesQuoteSLEntityView>("","#a41585d5-2b08-4ca4-a278-dd42e879e530 .ag-row[role='row']@ROWINDEX [col-id='cNumAdvance']","",true, this.CurrentView);
 
            AdvanceDate = RPSControlFactory.CreateRPSGridTextBox<SalesQuoteSLEntityView>("","#a41585d5-2b08-4ca4-a278-dd42e879e530 .ag-row[role='row']@ROWINDEX [col-id='cAdvanceDate']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<SalesQuoteSLEntityView>("","#a41585d5-2b08-4ca4-a278-dd42e879e530 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesQuoteSLEntityView>("","#a41585d5-2b08-4ca4-a278-dd42e879e530 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            VAT = RPSControlFactory.CreateRPSGridCheckBox<SalesQuoteSLEntityView>("","#a41585d5-2b08-4ca4-a278-dd42e879e530 .ag-row[role='row']@ROWINDEX [col-id='cVAT']","",true, this.CurrentView);
 
            Invoice = RPSControlFactory.CreateRPSGridCheckBox<SalesQuoteSLEntityView>("","#a41585d5-2b08-4ca4-a278-dd42e879e530 .ag-row[role='row']@ROWINDEX [col-id='cInvoice']","",true, this.CurrentView);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSGridComboBox<SalesQuoteSLEntityView>("","#a41585d5-2b08-4ca4-a278-dd42e879e530 .ag-row[role='row']@ROWINDEX [col-id='cIDPaymentMethod']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SalesQuoteSLEntityView> NumAdvance { get; set; } 
        public IRPSGridTextBox<SalesQuoteSLEntityView> AdvanceDate { get; set; } 
        public IRPSGridTextBox<SalesQuoteSLEntityView> Description { get; set; } 
        public IRPSGridTextBox<SalesQuoteSLEntityView> Amount { get; set; } 
        public IRPSGridCheckbox<SalesQuoteSLEntityView> VAT { get; set; } 
        public IRPSGridCheckbox<SalesQuoteSLEntityView> Invoice { get; set; } 
        public IRPSGridComboBox<SalesQuoteSLEntityView> IDPaymentMethod { get; set; } 
                     
    }
 
        public partial class SalesQuoteVariablePaymentSLsCollectionEditor<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView>:RPSCollectionEditor<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> where SalesQuoteSLEntityView : class, IView where SalesQuoteIncidenceSLView : class, IView
    {
        public  SalesQuoteVariablePaymentSLsGridView<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> GridView {get;set;}
    }
    public partial class SalesQuoteVariablePaymentSLsGridView <SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> :  RPSGridView<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> where SalesQuoteSLEntityView : class, IView where SalesQuoteIncidenceSLView : class, IView
    {
        public SalesQuoteVariablePaymentSLsGridView(SalesQuoteSLEntityView currentView,SalesQuoteIncidenceSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NumPayment = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesQuoteSLEntityView>("","#5fc5231a-b3e5-4a30-b183-1d08f5c72b83 .ag-row[role='row']@ROWINDEX [col-id='cNumPayment']","",true, this.CurrentView);
 
            DatePayment = RPSControlFactory.CreateRPSGridTextBox<SalesQuoteSLEntityView>("","#5fc5231a-b3e5-4a30-b183-1d08f5c72b83 .ag-row[role='row']@ROWINDEX [col-id='cDatePayment']","",false, this.CurrentView);
 
            DayPayment = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesQuoteSLEntityView>("","#5fc5231a-b3e5-4a30-b183-1d08f5c72b83 .ag-row[role='row']@ROWINDEX [col-id='cDayPayment']","",false, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesQuoteSLEntityView>("","#5fc5231a-b3e5-4a30-b183-1d08f5c72b83 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesQuoteSLEntityView>("","#5fc5231a-b3e5-4a30-b183-1d08f5c72b83 .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",true, this.CurrentView);
 
            Rest = RPSControlFactory.CreateRPSGridCheckBox<SalesQuoteSLEntityView>("","#5fc5231a-b3e5-4a30-b183-1d08f5c72b83 .ag-row[role='row']@ROWINDEX [col-id='cRest']","",false, this.CurrentView);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSGridComboBox<SalesQuoteSLEntityView>("","#5fc5231a-b3e5-4a30-b183-1d08f5c72b83 .ag-row[role='row']@ROWINDEX [col-id='cIDPaymentMethod']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SalesQuoteSLEntityView> NumPayment { get; set; } 
        public IRPSGridTextBox<SalesQuoteSLEntityView> DatePayment { get; set; } 
        public IRPSGridTextBox<SalesQuoteSLEntityView> DayPayment { get; set; } 
        public IRPSGridTextBox<SalesQuoteSLEntityView> Amount { get; set; } 
        public IRPSGridTextBox<SalesQuoteSLEntityView> Percentage { get; set; } 
        public IRPSGridCheckbox<SalesQuoteSLEntityView> Rest { get; set; } 
        public IRPSGridComboBox<SalesQuoteSLEntityView> IDPaymentMethod { get; set; } 
                     
    }
 
        public partial class SalesQuoteIncidenceSLsCollectionEditor<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView>:RPSCollectionEditor<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> where SalesQuoteSLEntityView : class, IView where SalesQuoteIncidenceSLView : class, IView
    {
        public  SalesQuoteIncidenceSLsGridView<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> GridView {get;set;}
    }
    public partial class SalesQuoteIncidenceSLsGridView <SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> :  RPSGridView<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> where SalesQuoteSLEntityView : class, IView where SalesQuoteIncidenceSLView : class, IView
    {
        public SalesQuoteIncidenceSLsGridView(SalesQuoteSLEntityView currentView,SalesQuoteIncidenceSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NumIncidence = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesQuoteSLEntityView>("","#b824dbae-397a-4157-bf62-e5b1418ff5ac .ag-row[role='row']@ROWINDEX [col-id='cNumIncidence']","",true, this.CurrentView);
 
            Date = RPSControlFactory.CreateRPSGridTextBox<SalesQuoteSLEntityView>("","#b824dbae-397a-4157-bf62-e5b1418ff5ac .ag-row[role='row']@ROWINDEX [col-id='cDate']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<SalesQuoteSLEntityView>("","#b824dbae-397a-4157-bf62-e5b1418ff5ac .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SalesQuoteSLEntityView> NumIncidence { get; set; } 
        public IRPSGridTextBox<SalesQuoteSLEntityView> Date { get; set; } 
        public IRPSGridTextBox<SalesQuoteSLEntityView> Description { get; set; } 
                     
    }
 
        public partial class SalesQuoteMilestoneSLsCollectionEditor<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView>:RPSCollectionEditor<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> where SalesQuoteSLEntityView : class, IView where SalesQuoteIncidenceSLView : class, IView
    {
        public  SalesQuoteMilestoneSLsGridView<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> GridView {get;set;}
    }
    public partial class SalesQuoteMilestoneSLsGridView <SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> :  RPSGridView<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> where SalesQuoteSLEntityView : class, IView where SalesQuoteIncidenceSLView : class, IView
    {
        public SalesQuoteMilestoneSLsGridView(SalesQuoteSLEntityView currentView,SalesQuoteIncidenceSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDTask = RPSControlFactory.CreateRPSGridComboBox<SalesQuoteSLEntityView>("","#37a5f34e-39cf-4f17-b779-5657940c9a73 .ag-row[role='row']@ROWINDEX [col-id='cIDTask']","",true, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesQuoteSLEntityView>("","#37a5f34e-39cf-4f17-b779-5657940c9a73 .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",true, this.CurrentView);
 
            GenerateAdvance = RPSControlFactory.CreateRPSGridCheckBox<SalesQuoteSLEntityView>("","#37a5f34e-39cf-4f17-b779-5657940c9a73 .ag-row[role='row']@ROWINDEX [col-id='cGenerateAdvance']","",true, this.CurrentView);
 
            Final = RPSControlFactory.CreateRPSGridCheckBox<SalesQuoteSLEntityView>("","#37a5f34e-39cf-4f17-b779-5657940c9a73 .ag-row[role='row']@ROWINDEX [col-id='cFinal']","",false, this.CurrentView);
 
            PlannedDate = RPSControlFactory.CreateRPSGridTextBox<SalesQuoteSLEntityView>("","#37a5f34e-39cf-4f17-b779-5657940c9a73 .ag-row[role='row']@ROWINDEX [col-id='cPlannedDate']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<SalesQuoteSLEntityView> IDTask { get; set; } 
        public IRPSGridTextBox<SalesQuoteSLEntityView> Percentage { get; set; } 
        public IRPSGridCheckbox<SalesQuoteSLEntityView> GenerateAdvance { get; set; } 
        public IRPSGridCheckbox<SalesQuoteSLEntityView> Final { get; set; } 
        public IRPSGridTextBox<SalesQuoteSLEntityView> PlannedDate { get; set; } 
                     
    }
 
        public partial class SalesQuoteCompositionSLsCollectionEditor<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView>:RPSCollectionEditor<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> where SalesQuoteSLEntityView : class, IView where SalesQuoteIncidenceSLView : class, IView
    {
        public  SalesQuoteCompositionSLsGridView<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> GridView {get;set;}
    }
    public partial class SalesQuoteCompositionSLsGridView <SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> :  RPSGridView<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> where SalesQuoteSLEntityView : class, IView where SalesQuoteIncidenceSLView : class, IView
    {
        public SalesQuoteCompositionSLsGridView(SalesQuoteSLEntityView currentView,SalesQuoteIncidenceSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDItemSelector = RPSControlFactory.CreateRPSGridComboBox<SalesQuoteSLEntityView>("","#89547da9-57bc-422d-885f-d449428c80dd .ag-row[role='row']@ROWINDEX [col-id='cIDItemSelector']","",false, this.CurrentView);
 
            Order = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesQuoteSLEntityView>("","#89547da9-57bc-422d-885f-d449428c80dd .ag-row[role='row']@ROWINDEX [col-id='cOrder']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<SalesQuoteSLEntityView> IDItemSelector { get; set; } 
        public IRPSGridTextBox<SalesQuoteSLEntityView> Order { get; set; } 
                     
    }
 
        public partial class SalesQuoteComAgentSLsCollectionEditor<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView>:RPSCollectionEditor<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> where SalesQuoteSLEntityView : class, IView where SalesQuoteIncidenceSLView : class, IView
    {
        public  SalesQuoteComAgentSLsGridView<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> GridView {get;set;}
    }
    public partial class SalesQuoteComAgentSLsGridView <SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> :  RPSGridView<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> where SalesQuoteSLEntityView : class, IView where SalesQuoteIncidenceSLView : class, IView
    {
        public SalesQuoteComAgentSLsGridView(SalesQuoteSLEntityView currentView,SalesQuoteIncidenceSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeleteAgentCommand = RPSControlFactory.CreateRPSGridButton<SalesQuoteSLEntityView>( "","#c2f6af7b-aa03-4d58-be00-5ecc65df1222 .ag-row[role='row']@ROWINDEX [col-id='cDeleteAgentCommand']","",this.CurrentView);
 
            IDCommercialAgent = RPSControlFactory.CreateRPSGridComboBox<SalesQuoteSLEntityView>("","#c2f6af7b-aa03-4d58-be00-5ecc65df1222 .ag-row[role='row']@ROWINDEX [col-id='cIDCommercialAgent']","",true, this.CurrentView);
 
            IDCommercialAgentClassification = RPSControlFactory.CreateRPSGridComboBox<SalesQuoteSLEntityView>("","#c2f6af7b-aa03-4d58-be00-5ecc65df1222 .ag-row[role='row']@ROWINDEX [col-id='cIDCommercialAgentClassification']","",true, this.CurrentView);
 
            Commission = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesQuoteSLEntityView>("","#c2f6af7b-aa03-4d58-be00-5ecc65df1222 .ag-row[role='row']@ROWINDEX [col-id='cCommission']","",false, this.CurrentView);
 
            ComisionTypeString = RPSControlFactory.CreateRPSGridTextBox<SalesQuoteSLEntityView>("","#c2f6af7b-aa03-4d58-be00-5ecc65df1222 .ag-row[role='row']@ROWINDEX [col-id='cComisionTypeString']","",false, this.CurrentView);
 
            ComisionHead = RPSControlFactory.CreateRPSGridCheckBox<SalesQuoteSLEntityView>("","#c2f6af7b-aa03-4d58-be00-5ecc65df1222 .ag-row[role='row']@ROWINDEX [col-id='cComisionHead']","",false, this.CurrentView);
 

        }
        public IRPSGridButton<SalesQuoteSLEntityView> DeleteAgentCommand { get; set; } 
        public IRPSGridComboBox<SalesQuoteSLEntityView> IDCommercialAgent { get; set; } 
        public IRPSGridComboBox<SalesQuoteSLEntityView> IDCommercialAgentClassification { get; set; } 
        public IRPSGridTextBox<SalesQuoteSLEntityView> Commission { get; set; } 
        public IRPSGridTextBox<SalesQuoteSLEntityView> ComisionTypeString { get; set; } 
        public IRPSGridCheckbox<SalesQuoteSLEntityView> ComisionHead { get; set; } 
                     
    }
 
        public partial class SalesQuoteOptionSLsCollectionEditor<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView>:RPSCollectionEditor<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> where SalesQuoteSLEntityView : class, IView where SalesQuoteIncidenceSLView : class, IView
    {
        public  SalesQuoteOptionSLsGridView<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> GridView {get;set;}
    }
    public partial class SalesQuoteOptionSLsGridView <SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> :  RPSGridView<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> where SalesQuoteSLEntityView : class, IView where SalesQuoteIncidenceSLView : class, IView
    {
        public SalesQuoteOptionSLsGridView(SalesQuoteSLEntityView currentView,SalesQuoteIncidenceSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodOption = RPSControlFactory.CreateRPSGridTextBox<SalesQuoteSLEntityView>("","#6cd53d4f-720e-489e-bcec-1df538b82fdf .ag-row[role='row']@ROWINDEX [col-id='cCodOption']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<SalesQuoteSLEntityView>("","#6cd53d4f-720e-489e-bcec-1df538b82fdf .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Total = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesQuoteSLEntityView>("","#6cd53d4f-720e-489e-bcec-1df538b82fdf .ag-row[role='row']@ROWINDEX [col-id='cTotal']","",false, this.CurrentView);
 
            Comment = RPSControlFactory.CreateRPSGridMemoTextBox<SalesQuoteSLEntityView>("","#6cd53d4f-720e-489e-bcec-1df538b82fdf .ag-row[role='row']@ROWINDEX [col-id='cComment']","",false, this.CurrentView);
 
            TotalCost = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesQuoteSLEntityView>("","#6cd53d4f-720e-489e-bcec-1df538b82fdf .ag-row[role='row']@ROWINDEX [col-id='cTotalCost']","",false, this.CurrentView);
 
            Margin = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesQuoteSLEntityView>("","#6cd53d4f-720e-489e-bcec-1df538b82fdf .ag-row[role='row']@ROWINDEX [col-id='cMargin']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SalesQuoteSLEntityView> CodOption { get; set; } 
        public IRPSGridTextBox<SalesQuoteSLEntityView> Description { get; set; } 
        public IRPSGridTextBox<SalesQuoteSLEntityView> Total { get; set; } 
        public IRPSGridTextBox<SalesQuoteSLEntityView> Comment { get; set; } 
        public IRPSGridTextBox<SalesQuoteSLEntityView> TotalCost { get; set; } 
        public IRPSGridTextBox<SalesQuoteSLEntityView> Margin { get; set; } 
                     
    }
 
        public partial class CPQProductCollectionEditor<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView>:RPSCollectionEditor<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> where SalesQuoteSLEntityView : class, IView where SalesQuoteIncidenceSLView : class, IView
    {
        public  CPQProductGridView<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> GridView {get;set;}
    }
    public partial class CPQProductGridView <SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> :  RPSGridView<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> where SalesQuoteSLEntityView : class, IView where SalesQuoteIncidenceSLView : class, IView
    {
        public CPQProductGridView(SalesQuoteSLEntityView currentView,SalesQuoteIncidenceSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Date = RPSControlFactory.CreateRPSGridTextBox<SalesQuoteSLEntityView>("","#2c5275b1-19e5-492e-9fbe-6e4223d08ef1 .ag-row[role='row']@ROWINDEX [col-id='cDate']","",false, this.CurrentView);
 
            CPQProduct_DescriptionExtended = RPSControlFactory.CreateRPSGridMemoTextBox<SalesQuoteSLEntityView>("","#2c5275b1-19e5-492e-9fbe-6e4223d08ef1 .ag-row[role='row']@ROWINDEX [col-id='cCPQProduct_DescriptionExtended']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SalesQuoteSLEntityView> Date { get; set; } 
        public IRPSGridTextBox<SalesQuoteSLEntityView> CPQProduct_DescriptionExtended { get; set; } 
                     
    }
 
        public partial class CuDistSalesQuoteGroupsCollectionEditor<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView>:RPSCollectionEditor<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> where SalesQuoteSLEntityView : class, IView where SalesQuoteIncidenceSLView : class, IView
    {
        public  CuDistSalesQuoteGroupsGridView<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> GridView {get;set;}
    }
    public partial class CuDistSalesQuoteGroupsGridView <SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> :  RPSGridView<SalesQuoteSLEntityView,SalesQuoteIncidenceSLView> where SalesQuoteSLEntityView : class, IView where SalesQuoteIncidenceSLView : class, IView
    {
        public CuDistSalesQuoteGroupsGridView(SalesQuoteSLEntityView currentView,SalesQuoteIncidenceSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodGroup = RPSControlFactory.CreateRPSGridTextBox<SalesQuoteSLEntityView>("","#7d777cb6-a30e-4d98-a1df-84cdd46e1fa8 .ag-row[role='row']@ROWINDEX [col-id='cCodGroup']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<SalesQuoteSLEntityView>("","#7d777cb6-a30e-4d98-a1df-84cdd46e1fa8 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Comment = RPSControlFactory.CreateRPSGridMemoTextBox<SalesQuoteSLEntityView>("","#7d777cb6-a30e-4d98-a1df-84cdd46e1fa8 .ag-row[role='row']@ROWINDEX [col-id='cComment']","",false, this.CurrentView);
 
            Total = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesQuoteSLEntityView>("","#7d777cb6-a30e-4d98-a1df-84cdd46e1fa8 .ag-row[role='row']@ROWINDEX [col-id='cTotal']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<SalesQuoteSLEntityView> CodGroup { get; set; } 
        public IRPSGridTextBox<SalesQuoteSLEntityView> Description { get; set; } 
        public IRPSGridTextBox<SalesQuoteSLEntityView> Comment { get; set; } 
        public IRPSGridTextBox<SalesQuoteSLEntityView> Total { get; set; } 
                     
    }
 
    }
  
            
    public partial class SalesQuoteLineSLView : View
    {
        public SalesQuoteLineSLView(SalesQuoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SalesQuoteLineSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SalesQuoteLineSLView,SalesQuoteSLEntityView>( this,Screen.SalesQuoteSLEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<SalesQuoteLineSLView,SalesQuoteSLEntityView>( this,Screen.SalesQuoteSLEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SalesQuoteLineSLView,SalesQuoteSLEntityView>( this,Screen.SalesQuoteSLEntityView);
 
            TypeLine = RPSControlFactory.CreateRPSEnumComboBox<SalesQuoteLineSLView>("e43c9ee6-89af-44ba-97b6-785eaf1e0de6","","",true, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<SalesQuoteLineSLView>("06055ed6-2f85-43ab-a89f-05d2a23d3c3a","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteLineSLView>("713317b2-1e58-499a-ae3f-0bc783c99074","","",true, this);
 
            Price = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteLineSLView>("3b2c3a62-4614-4850-9496-ffae854e0782","","",true, this);
 
            VAT = RPSControlFactory.CreateRPSCheckBox<SalesQuoteLineSLView>("76a708b1-f606-4764-a962-56b63826b181","","",true, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteLineSLView>("5f194672-485e-42f3-a735-a20000dfc169","","",false, this);
 
            AmountWithVAT = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteLineSLView>("9a054884-8292-4cc9-9719-77fb9eb6b5fc","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SalesQuoteLineSLView>("2a3cabd3-84f4-4c4e-b87a-da61f92de23c","","",false, this);
 
            ReferenceCustomer = RPSControlFactory.CreateRPSEnumComboBox<SalesQuoteLineSLView>("253e4e42-40f7-411d-b4cb-390cac6edc88","","",false, this);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSComboBox<SalesQuoteLineSLView>("40c59abe-a543-43ce-91b0-6be6635812cc","","",true, this);
 
            ConversionFactorQuantity = RPSControlFactory.CreateRPSTextBox<SalesQuoteLineSLView>("1ff03e25-5fe2-415d-9689-4c805b74de92","","",true, this);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteLineSLView>("748d57bb-d603-4012-a352-1ffd6ce69242","","",true, this);
 
            IDUnitPrice = RPSControlFactory.CreateRPSComboBox<SalesQuoteLineSLView>("a4b76f90-ccd6-4f8b-ad77-5b88ed09cd2a","","",true, this);
 
            ConversionFactorPrice = RPSControlFactory.CreateRPSTextBox<SalesQuoteLineSLView>("4082c8ed-e39c-4605-b780-4c1fa8a6f07c","","",true, this);
 
            AcceptedQuantity = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteLineSLView>("76f7ae7e-71e2-4279-86d7-e71384009a02","","",true, this);
 
            AcceptedQuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteLineSLView>("42d344a3-5a86-4827-8f68-888b42ec6298","","",true, this);
 
            Dimension1 = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteLineSLView>("e5aed1fd-9a8d-4d28-966a-c5f3b06ab4bc","","",true, this);
 
            Dimension2 = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteLineSLView>("2f3f2f33-d895-48ed-93b0-f67d6a49c3d6","","",true, this);
 
            Dimension3 = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteLineSLView>("a78be036-933d-4828-9a90-6e03a8987de8","","",true, this);
 
            Ordenation = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteLineSLView>("021c3923-63b6-461d-a5d0-ac981919085e","","",true, this);
 
            OrderQuantity = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteLineSLView>("daab6c7f-98ca-461b-b149-be2875a9ccb8","","",true, this);
 
            Index = RPSControlFactory.CreateRPSTextBox<SalesQuoteLineSLView>("6bc9b48a-658d-4536-bfa5-1c7d0b954c80","","",false, this);
 
            GeneratedPurchase = RPSControlFactory.CreateRPSCheckBox<SalesQuoteLineSLView>("d3a9867e-2230-4a73-bb40-42c22917fc8f","","",true, this);
 
            SalesLot = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteLineSLView>("f808ddc0-261c-40b3-95db-305e1d6f215d","","",true, this);
 
            MinimumLot = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteLineSLView>("ed324f34-f7e6-4846-9e4a-619e304cc4f3","","",true, this);
 
            Discount1 = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteLineSLView>("430d0f3a-1a7c-4321-ac76-8de5f5a3bde0","","",true, this);
 
            CascadeDiscount1 = RPSControlFactory.CreateRPSCheckBox<SalesQuoteLineSLView>("0894fd35-2ebf-40a3-b1e4-26799eb70909","","",true, this);
 
            Discount2 = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteLineSLView>("6a1e7d95-32ac-4fdb-afde-080c8114cd74","","",true, this);
 
            CascadeDiscount2 = RPSControlFactory.CreateRPSCheckBox<SalesQuoteLineSLView>("dbbb88ce-a71b-4c9e-b603-0eff4f3f25c8","","",true, this);
 
            Discount3 = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteLineSLView>("8ed8e000-662a-4747-a178-d13f557a9518","","",true, this);
 
            CascadeDiscount3 = RPSControlFactory.CreateRPSCheckBox<SalesQuoteLineSLView>("3d6a7de1-2c6f-4bb0-9c0b-6287a2a7e3d5","","",true, this);
 
            Discount4 = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteLineSLView>("3ff0f6c1-a127-4a65-9a84-75e6086ab678","","",true, this);
 
            CascadeDiscount4 = RPSControlFactory.CreateRPSCheckBox<SalesQuoteLineSLView>("7f81eea4-1c64-4b6d-b775-8938346ce683","","",true, this);
 
            Discount5 = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteLineSLView>("d1bd7444-ed68-4fd8-95d8-8d10f054a293","","",true, this);
 
            CascadeDiscount5 = RPSControlFactory.CreateRPSCheckBox<SalesQuoteLineSLView>("59166b88-003b-491a-8bf4-3eee21a05803","","",true, this);
 
            AmountDiscount = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteLineSLView>("1292a234-3ae0-4d5a-995c-9addcc2f3ea4","","",true, this);
 
            PositionAmountDiscount = RPSControlFactory.CreateRPSEnumComboBox<SalesQuoteLineSLView>("f7f71fd7-e2aa-4478-ae23-619a467ad545","","",true, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<SalesQuoteLineSLView>("372fd81f-6c22-4763-99f1-e9156fffe86e","","",true, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<SalesQuoteLineSLView>("89ca67ef-a1e1-468e-be6d-a408ac93babd","","",true, this);
 
            IDSiteTransfer = RPSControlFactory.CreateRPSComboBox<SalesQuoteLineSLView>("11cb8b87-238e-42ef-8378-2e1449c06b34","","",false, this);
 
            IDWarehouseTransfer = RPSControlFactory.CreateRPSComboBox<SalesQuoteLineSLView>("57af39d9-c581-45d7-ab82-b22679b31454","","",false, this);
 
            IDVAT = RPSControlFactory.CreateRPSComboBox<SalesQuoteLineSLView>("745e910a-6494-43d5-a268-c4814e0770f2","","",true, this);
 
            PercentVAT = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteLineSLView>("c5a4197a-31a3-4cca-b2fb-c12e8e0eb37d","","",true, this);
 
            IDVATSurcharge = RPSControlFactory.CreateRPSComboBox<SalesQuoteLineSLView>("38c16e03-54a2-4e61-bd06-4a0a9a9bdeb5","","",false, this);
 
            PercentSurcharge = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteLineSLView>("25f1b294-360f-4213-a638-368406c7157a","","",true, this);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<SalesQuoteLineSLView>("6183642f-9cda-41cf-bbd3-4a8eb6c909a0","","",true, this);
 
            Invoice = RPSControlFactory.CreateRPSCheckBox<SalesQuoteLineSLView>("e3f5d5f1-0d59-4497-b618-b19a29d997f5","","",true, this);
 
            ReceptionDate = RPSControlFactory.CreateRPSTextBox<SalesQuoteLineSLView>("587d4cac-8647-4f02-835a-67cad57dfd28","","",true, this);
 
            Cost = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteLineSLView>("7352b793-38a3-4617-90c2-16b806c1a61a","","",true, this);
 
            IDSalesQuoteLineKit = RPSControlFactory.CreateRPSComboBox<SalesQuoteLineSLView>("cb33add1-ceaa-4988-bdce-ae4d68f647df","","",false, this);
 
            CostPercentage = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteLineSLView>("eb173a87-7730-4598-9d2a-b8fe519ade7c","","",false, this);
 
            NumProm = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteLineSLView>("fdfa5397-e5e2-469f-ba65-f4902b96e74b","","",true, this);
 
            IDQuotationLot = RPSControlFactory.CreateRPSComboBox<SalesQuoteLineSLView>("41def745-b385-477d-9c48-2292fcf727f0","","",false, this);
 
            PriceBase = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteLineSLView>("0bc3204b-da9b-4bec-b64c-89753993ca75","","",false, this);
 
            UIconditionPrice = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteLineSLView>("f26c3259-8c5d-49c4-b270-676dc1f08225","","",false, this);
 
            UpdateTechnicalDescriptionCommand = RPSControlFactory.CreateRPSButton<SalesQuoteLineSLView>( "b1905f81-0ea1-4f0f-8e3d-f5a0f3c9cfab","","",this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<SalesQuoteLineSLView>("022450e7-71aa-4dbb-b263-c9ffb987f03b","","",false, this);
 
            PlanNumber = RPSControlFactory.CreateRPSTextBox<SalesQuoteLineSLView>("7c1a6aa5-16de-4295-b26d-360dc4a09f1c","","",false, this);
 
            IDSalesQuoteGroup = RPSControlFactory.CreateRPSComboBox<SalesQuoteLineSLView>("088bcc24-fee9-4f9d-ae8c-940880571830","","",false, this);
 
            opendlgArticleAlternativeButton = RPSControlFactory.CreateRPSButton<SalesQuoteLineSLView>( "8154984d-2f3c-47d3-977b-941e631aea9e","","",this);
 
            CopyLineCommandButton = RPSControlFactory.CreateRPSButton<SalesQuoteLineSLView>( "d436bae2-b6fe-43c2-ace0-2d967bed7253","","",this);
 
            NewArticleChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<SalesQuoteLineSLView,NewArticleChildDialogView>("48f343cc-9e73-42b3-bde6-3a5ef1b4caa7","","", this,Screen.NewArticleChildDialogView);
 
            DueDateCalculationNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<SalesQuoteLineSLView,DueDateCalculationDialogView>("9bf009f5-a9a6-4750-867e-adb676a8cd3c","","", this,Screen.DueDateCalculationDialogView);
 
            CollectionInit params_SalesQuoteLineConditionSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3aac742b-9f89-4d8d-ab4e-ab734df9a207",CSSSelectorGrid="",XPathGrid=""};
            SalesQuoteLineConditionSLs = RPSControlFactory.RPSCreateCollectionWithGrid<SalesQuoteLineConditionSLsCollectionEditor<SalesQuoteLineSLView,SalesQuoteLineCommercialAgentSLView>,SalesQuoteLineSLView,SalesQuoteLineCommercialAgentSLView>( params_SalesQuoteLineConditionSLs,this,Screen.SalesQuoteLineCommercialAgentSLView);
 
            CollectionInit params_SalesQuoteLineTaxSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="029d2a63-7c72-425c-93e6-28e7035b7640",CSSSelectorGrid="",XPathGrid=""};
            SalesQuoteLineTaxSLs = RPSControlFactory.RPSCreateCollectionWithGrid<SalesQuoteLineTaxSLsCollectionEditor<SalesQuoteLineSLView,SalesQuoteLineCommercialAgentSLView>,SalesQuoteLineSLView,SalesQuoteLineCommercialAgentSLView>( params_SalesQuoteLineTaxSLs,this,Screen.SalesQuoteLineCommercialAgentSLView);
 
            CollectionInit params_SalesQuoteLineCommercialAgentSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1d284eeb-cf59-45bf-858d-de6c495a9e23",CSSSelectorGrid="",XPathGrid=""};
            SalesQuoteLineCommercialAgentSLs = RPSControlFactory.RPSCreateCollectionWithGrid<SalesQuoteLineCommercialAgentSLsCollectionEditor<SalesQuoteLineSLView,SalesQuoteLineCommercialAgentSLView>,SalesQuoteLineSLView,SalesQuoteLineCommercialAgentSLView>( params_SalesQuoteLineCommercialAgentSLs,this,Screen.SalesQuoteLineCommercialAgentSLView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<SalesQuoteLineSLView>( "","ul li[rpsid='58593dfb-4bd4-4b6a-aa1d-d5517ebf0d70']","",this);
 
            SpecialConditions = RPSControlFactory.CreateRPSSection<SalesQuoteLineSLView>( "","ul li[rpsid='b83c93c8-4c86-41cb-8b77-0c6907a5b52e']","",this);
 
            Taxes = RPSControlFactory.CreateRPSSection<SalesQuoteLineSLView>( "","ul li[rpsid='cbe3e202-8170-4d6c-817f-0345b9d7d4ad']","",this);
 
            CommercialAgent = RPSControlFactory.CreateRPSSection<SalesQuoteLineSLView>( "","ul li[rpsid='4efc6f16-cfbe-48a6-a058-8c41b59537a6']","",this);
 
            Comment1 = RPSControlFactory.CreateRPSSection<SalesQuoteLineSLView>( "","ul li[rpsid='aa4a5a53-73d1-4433-9d96-d4e974a6bddd']","",this);
 
            DPS = RPSControlFactory.CreateRPSSection<SalesQuoteLineSLView>( "","ul li[rpsid='af5c2a46-b72b-448d-b053-1c5adeff008e']","",this);
 

        }
        public IRPSButton<SalesQuoteLineSLView> DeleteButton { get; set; } 
        public IRPSButton<SalesQuoteLineSLView,SalesQuoteSLEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SalesQuoteLineSLView,SalesQuoteSLEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<SalesQuoteLineSLView,SalesQuoteSLEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<SalesQuoteLineSLView> TypeLine { get; set; } 
        public IRPSComboBox<SalesQuoteLineSLView> IDArticle { get; set; } 
        public IRPSTextBox<SalesQuoteLineSLView> Quantity { get; set; } 
        public IRPSTextBox<SalesQuoteLineSLView> Price { get; set; } 
        public IRPSCheckbox<SalesQuoteLineSLView> VAT { get; set; } 
        public IRPSTextBox<SalesQuoteLineSLView> Amount { get; set; } 
        public IRPSTextBox<SalesQuoteLineSLView> AmountWithVAT { get; set; } 
        public IRPSTextBox<SalesQuoteLineSLView> Description { get; set; } 
        public IRPSComboBox<SalesQuoteLineSLView> ReferenceCustomer { get; set; } 
        public IRPSComboBox<SalesQuoteLineSLView> IDUnitQuantity { get; set; } 
        public IRPSTextBox<SalesQuoteLineSLView> ConversionFactorQuantity { get; set; } 
        public IRPSTextBox<SalesQuoteLineSLView> QuantitySecondUnit { get; set; } 
        public IRPSComboBox<SalesQuoteLineSLView> IDUnitPrice { get; set; } 
        public IRPSTextBox<SalesQuoteLineSLView> ConversionFactorPrice { get; set; } 
        public IRPSTextBox<SalesQuoteLineSLView> AcceptedQuantity { get; set; } 
        public IRPSTextBox<SalesQuoteLineSLView> AcceptedQuantitySecondUnit { get; set; } 
        public IRPSTextBox<SalesQuoteLineSLView> Dimension1 { get; set; } 
        public IRPSTextBox<SalesQuoteLineSLView> Dimension2 { get; set; } 
        public IRPSTextBox<SalesQuoteLineSLView> Dimension3 { get; set; } 
        public IRPSTextBox<SalesQuoteLineSLView> Ordenation { get; set; } 
        public IRPSTextBox<SalesQuoteLineSLView> OrderQuantity { get; set; } 
        public IRPSTextBox<SalesQuoteLineSLView> Index { get; set; } 
        public IRPSCheckbox<SalesQuoteLineSLView> GeneratedPurchase { get; set; } 
        public IRPSTextBox<SalesQuoteLineSLView> SalesLot { get; set; } 
        public IRPSTextBox<SalesQuoteLineSLView> MinimumLot { get; set; } 
        public IRPSTextBox<SalesQuoteLineSLView> Discount1 { get; set; } 
        public IRPSCheckbox<SalesQuoteLineSLView> CascadeDiscount1 { get; set; } 
        public IRPSTextBox<SalesQuoteLineSLView> Discount2 { get; set; } 
        public IRPSCheckbox<SalesQuoteLineSLView> CascadeDiscount2 { get; set; } 
        public IRPSTextBox<SalesQuoteLineSLView> Discount3 { get; set; } 
        public IRPSCheckbox<SalesQuoteLineSLView> CascadeDiscount3 { get; set; } 
        public IRPSTextBox<SalesQuoteLineSLView> Discount4 { get; set; } 
        public IRPSCheckbox<SalesQuoteLineSLView> CascadeDiscount4 { get; set; } 
        public IRPSTextBox<SalesQuoteLineSLView> Discount5 { get; set; } 
        public IRPSCheckbox<SalesQuoteLineSLView> CascadeDiscount5 { get; set; } 
        public IRPSTextBox<SalesQuoteLineSLView> AmountDiscount { get; set; } 
        public IRPSComboBox<SalesQuoteLineSLView> PositionAmountDiscount { get; set; } 
        public IRPSComboBox<SalesQuoteLineSLView> IDSite { get; set; } 
        public IRPSComboBox<SalesQuoteLineSLView> IDWarehouse { get; set; } 
        public IRPSComboBox<SalesQuoteLineSLView> IDSiteTransfer { get; set; } 
        public IRPSComboBox<SalesQuoteLineSLView> IDWarehouseTransfer { get; set; } 
        public IRPSComboBox<SalesQuoteLineSLView> IDVAT { get; set; } 
        public IRPSTextBox<SalesQuoteLineSLView> PercentVAT { get; set; } 
        public IRPSComboBox<SalesQuoteLineSLView> IDVATSurcharge { get; set; } 
        public IRPSTextBox<SalesQuoteLineSLView> PercentSurcharge { get; set; } 
        public IRPSComboBox<SalesQuoteLineSLView> IDDeliveryNoteType { get; set; } 
        public IRPSCheckbox<SalesQuoteLineSLView> Invoice { get; set; } 
        public IRPSTextBox<SalesQuoteLineSLView> ReceptionDate { get; set; } 
        public IRPSTextBox<SalesQuoteLineSLView> Cost { get; set; } 
        public IRPSComboBox<SalesQuoteLineSLView> IDSalesQuoteLineKit { get; set; } 
        public IRPSTextBox<SalesQuoteLineSLView> CostPercentage { get; set; } 
        public IRPSTextBox<SalesQuoteLineSLView> NumProm { get; set; } 
        public IRPSComboBox<SalesQuoteLineSLView> IDQuotationLot { get; set; } 
        public IRPSTextBox<SalesQuoteLineSLView> PriceBase { get; set; } 
        public IRPSTextBox<SalesQuoteLineSLView> UIconditionPrice { get; set; } 
        public IRPSButton<SalesQuoteLineSLView> UpdateTechnicalDescriptionCommand { get; set; } 
        public IRPSTextBox<SalesQuoteLineSLView> Comment { get; set; } 
        public IRPSTextBox<SalesQuoteLineSLView> PlanNumber { get; set; } 
        public IRPSComboBox<SalesQuoteLineSLView> IDSalesQuoteGroup { get; set; } 
        public IRPSButton<SalesQuoteLineSLView> opendlgArticleAlternativeButton { get; set; } 
        public IRPSButton<SalesQuoteLineSLView> CopyLineCommandButton { get; set; } 
        public IRPSButton<SalesQuoteLineSLView,NewArticleChildDialogView> NewArticleChildNavigationCommandButton { get; set; } 
        public IRPSButton<SalesQuoteLineSLView,DueDateCalculationDialogView> DueDateCalculationNavigationCommandButton { get; set; } 
        public SalesQuoteLineConditionSLsCollectionEditor<SalesQuoteLineSLView,SalesQuoteLineCommercialAgentSLView> SalesQuoteLineConditionSLs { get; set; } 
        public SalesQuoteLineTaxSLsCollectionEditor<SalesQuoteLineSLView,SalesQuoteLineCommercialAgentSLView> SalesQuoteLineTaxSLs { get; set; } 
        public SalesQuoteLineCommercialAgentSLsCollectionEditor<SalesQuoteLineSLView,SalesQuoteLineCommercialAgentSLView> SalesQuoteLineCommercialAgentSLs { get; set; } 
        public IRPSSection<SalesQuoteLineSLView> GeneralData { get; set; } 
        public IRPSSection<SalesQuoteLineSLView> SpecialConditions { get; set; } 
        public IRPSSection<SalesQuoteLineSLView> Taxes { get; set; } 
        public IRPSSection<SalesQuoteLineSLView> CommercialAgent { get; set; } 
        public IRPSSection<SalesQuoteLineSLView> Comment1 { get; set; } 
        public IRPSSection<SalesQuoteLineSLView> DPS { get; set; } 
        public SalesQuoteSL Screen { get; set; }
        public SalesQuoteLineSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SalesQuoteLineConditionSLsCollectionEditor<SalesQuoteLineSLView,SalesQuoteLineCommercialAgentSLView>:RPSCollectionEditor<SalesQuoteLineSLView,SalesQuoteLineCommercialAgentSLView> where SalesQuoteLineSLView : class, IView where SalesQuoteLineCommercialAgentSLView : class, IView
    {
        public  SalesQuoteLineConditionSLsGridView<SalesQuoteLineSLView,SalesQuoteLineCommercialAgentSLView> GridView {get;set;}
    }
    public partial class SalesQuoteLineConditionSLsGridView <SalesQuoteLineSLView,SalesQuoteLineCommercialAgentSLView> :  RPSGridView<SalesQuoteLineSLView,SalesQuoteLineCommercialAgentSLView> where SalesQuoteLineSLView : class, IView where SalesQuoteLineCommercialAgentSLView : class, IView
    {
        public SalesQuoteLineConditionSLsGridView(SalesQuoteLineSLView currentView,SalesQuoteLineCommercialAgentSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<SalesQuoteLineSLView>("","#3aac742b-9f89-4d8d-ab4e-ab734df9a207 .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            ConditionValueOriginal = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesQuoteLineSLView>("","#3aac742b-9f89-4d8d-ab4e-ab734df9a207 .ag-row[role='row']@ROWINDEX [col-id='cConditionValueOriginal']","",true, this.CurrentView);
 
            ConditionValue = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesQuoteLineSLView>("","#3aac742b-9f89-4d8d-ab4e-ab734df9a207 .ag-row[role='row']@ROWINDEX [col-id='cConditionValue']","",true, this.CurrentView);
 
            Base = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesQuoteLineSLView>("","#3aac742b-9f89-4d8d-ab4e-ab734df9a207 .ag-row[role='row']@ROWINDEX [col-id='cBase']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesQuoteLineSLView>("","#3aac742b-9f89-4d8d-ab4e-ab734df9a207 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            ConditionType = RPSControlFactory.CreateRPSGridEnumComboBox<SalesQuoteLineSLView>("","#3aac742b-9f89-4d8d-ab4e-ab734df9a207 .ag-row[role='row']@ROWINDEX [col-id='cConditionType']","",true, this.CurrentView);
 
            BaseApply = RPSControlFactory.CreateRPSGridEnumComboBox<SalesQuoteLineSLView>("","#3aac742b-9f89-4d8d-ab4e-ab734df9a207 .ag-row[role='row']@ROWINDEX [col-id='cBaseApply']","",true, this.CurrentView);
 
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<SalesQuoteLineSLView>("","#3aac742b-9f89-4d8d-ab4e-ab734df9a207 .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",true, this.CurrentView);
 
            DateTo = RPSControlFactory.CreateRPSGridTextBox<SalesQuoteLineSLView>("","#3aac742b-9f89-4d8d-ab4e-ab734df9a207 .ag-row[role='row']@ROWINDEX [col-id='cDateTo']","",true, this.CurrentView);
 
            AffectsPrice = RPSControlFactory.CreateRPSGridCheckBox<SalesQuoteLineSLView>("","#3aac742b-9f89-4d8d-ab4e-ab734df9a207 .ag-row[role='row']@ROWINDEX [col-id='cAffectsPrice']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<SalesQuoteLineSLView> Type { get; set; } 
        public IRPSGridTextBox<SalesQuoteLineSLView> ConditionValueOriginal { get; set; } 
        public IRPSGridTextBox<SalesQuoteLineSLView> ConditionValue { get; set; } 
        public IRPSGridTextBox<SalesQuoteLineSLView> Base { get; set; } 
        public IRPSGridTextBox<SalesQuoteLineSLView> Amount { get; set; } 
        public IRPSGridComboBox<SalesQuoteLineSLView> ConditionType { get; set; } 
        public IRPSGridComboBox<SalesQuoteLineSLView> BaseApply { get; set; } 
        public IRPSGridTextBox<SalesQuoteLineSLView> DateFrom { get; set; } 
        public IRPSGridTextBox<SalesQuoteLineSLView> DateTo { get; set; } 
        public IRPSGridCheckbox<SalesQuoteLineSLView> AffectsPrice { get; set; } 
                     
    }
 
        public partial class SalesQuoteLineTaxSLsCollectionEditor<SalesQuoteLineSLView,SalesQuoteLineCommercialAgentSLView>:RPSCollectionEditor<SalesQuoteLineSLView,SalesQuoteLineCommercialAgentSLView> where SalesQuoteLineSLView : class, IView where SalesQuoteLineCommercialAgentSLView : class, IView
    {
        public  SalesQuoteLineTaxSLsGridView<SalesQuoteLineSLView,SalesQuoteLineCommercialAgentSLView> GridView {get;set;}
    }
    public partial class SalesQuoteLineTaxSLsGridView <SalesQuoteLineSLView,SalesQuoteLineCommercialAgentSLView> :  RPSGridView<SalesQuoteLineSLView,SalesQuoteLineCommercialAgentSLView> where SalesQuoteLineSLView : class, IView where SalesQuoteLineCommercialAgentSLView : class, IView
    {
        public SalesQuoteLineTaxSLsGridView(SalesQuoteLineSLView currentView,SalesQuoteLineCommercialAgentSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDTaxValue = RPSControlFactory.CreateRPSGridComboBox<SalesQuoteLineSLView>("","#029d2a63-7c72-425c-93e6-28e7035b7640 .ag-row[role='row']@ROWINDEX [col-id='cIDTaxValue']","",true, this.CurrentView);
 
            ApplicationType = RPSControlFactory.CreateRPSGridEnumComboBox<SalesQuoteLineSLView>("","#029d2a63-7c72-425c-93e6-28e7035b7640 .ag-row[role='row']@ROWINDEX [col-id='cApplicationType']","",true, this.CurrentView);
 
            BaseType = RPSControlFactory.CreateRPSGridEnumComboBox<SalesQuoteLineSLView>("","#029d2a63-7c72-425c-93e6-28e7035b7640 .ag-row[role='row']@ROWINDEX [col-id='cBaseType']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<SalesQuoteLineSLView>("","#029d2a63-7c72-425c-93e6-28e7035b7640 .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            Value = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesQuoteLineSLView>("","#029d2a63-7c72-425c-93e6-28e7035b7640 .ag-row[role='row']@ROWINDEX [col-id='cValue']","",true, this.CurrentView);
 
            PriceIncluded = RPSControlFactory.CreateRPSGridCheckBox<SalesQuoteLineSLView>("","#029d2a63-7c72-425c-93e6-28e7035b7640 .ag-row[role='row']@ROWINDEX [col-id='cPriceIncluded']","",true, this.CurrentView);
 
            VAT = RPSControlFactory.CreateRPSGridCheckBox<SalesQuoteLineSLView>("","#029d2a63-7c72-425c-93e6-28e7035b7640 .ag-row[role='row']@ROWINDEX [col-id='cVAT']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<SalesQuoteLineSLView> IDTaxValue { get; set; } 
        public IRPSGridComboBox<SalesQuoteLineSLView> ApplicationType { get; set; } 
        public IRPSGridComboBox<SalesQuoteLineSLView> BaseType { get; set; } 
        public IRPSGridComboBox<SalesQuoteLineSLView> Type { get; set; } 
        public IRPSGridTextBox<SalesQuoteLineSLView> Value { get; set; } 
        public IRPSGridCheckbox<SalesQuoteLineSLView> PriceIncluded { get; set; } 
        public IRPSGridCheckbox<SalesQuoteLineSLView> VAT { get; set; } 
                     
    }
 
        public partial class SalesQuoteLineCommercialAgentSLsCollectionEditor<SalesQuoteLineSLView,SalesQuoteLineCommercialAgentSLView>:RPSCollectionEditor<SalesQuoteLineSLView,SalesQuoteLineCommercialAgentSLView> where SalesQuoteLineSLView : class, IView where SalesQuoteLineCommercialAgentSLView : class, IView
    {
        public  SalesQuoteLineCommercialAgentSLsGridView<SalesQuoteLineSLView,SalesQuoteLineCommercialAgentSLView> GridView {get;set;}
    }
    public partial class SalesQuoteLineCommercialAgentSLsGridView <SalesQuoteLineSLView,SalesQuoteLineCommercialAgentSLView> :  RPSGridView<SalesQuoteLineSLView,SalesQuoteLineCommercialAgentSLView> where SalesQuoteLineSLView : class, IView where SalesQuoteLineCommercialAgentSLView : class, IView
    {
        public SalesQuoteLineCommercialAgentSLsGridView(SalesQuoteLineSLView currentView,SalesQuoteLineCommercialAgentSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDCommercialAgent = RPSControlFactory.CreateRPSGridComboBox<SalesQuoteLineSLView>("","#1d284eeb-cf59-45bf-858d-de6c495a9e23 .ag-row[role='row']@ROWINDEX [col-id='cIDCommercialAgent']","",true, this.CurrentView);
 
            IDCommercialAgentClassification = RPSControlFactory.CreateRPSGridComboBox<SalesQuoteLineSLView>("","#1d284eeb-cf59-45bf-858d-de6c495a9e23 .ag-row[role='row']@ROWINDEX [col-id='cIDCommercialAgentClassification']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<SalesQuoteLineSLView>("","#1d284eeb-cf59-45bf-858d-de6c495a9e23 .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            Commission = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesQuoteLineSLView>("","#1d284eeb-cf59-45bf-858d-de6c495a9e23 .ag-row[role='row']@ROWINDEX [col-id='cCommission']","",true, this.CurrentView);
 
            CommissionAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesQuoteLineSLView>("","#1d284eeb-cf59-45bf-858d-de6c495a9e23 .ag-row[role='row']@ROWINDEX [col-id='cCommissionAmount']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<SalesQuoteLineSLView> IDCommercialAgent { get; set; } 
        public IRPSGridComboBox<SalesQuoteLineSLView> IDCommercialAgentClassification { get; set; } 
        public IRPSGridComboBox<SalesQuoteLineSLView> Type { get; set; } 
        public IRPSGridTextBox<SalesQuoteLineSLView> Commission { get; set; } 
        public IRPSGridTextBox<SalesQuoteLineSLView> CommissionAmount { get; set; } 
                     
    }
 
    }
  
            
    public partial class SalesQuoteAdvanceSLView : View
    {
        public SalesQuoteAdvanceSLView(SalesQuoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SalesQuoteAdvanceSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SalesQuoteAdvanceSLView,SalesQuoteLineSLView>( this,Screen.SalesQuoteLineSLView);
 
            BackButton = RPSControlFactory.RPSBackButton<SalesQuoteAdvanceSLView,SalesQuoteLineSLView>( this,Screen.SalesQuoteLineSLView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SalesQuoteAdvanceSLView,SalesQuoteLineSLView>( this,Screen.SalesQuoteLineSLView);
 
            NumAdvance = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteAdvanceSLView>("4d0349d5-595f-4e9c-ac17-e60cdbe20085","","",true, this);
 
            AdvanceDate = RPSControlFactory.CreateRPSTextBox<SalesQuoteAdvanceSLView>("79ec994e-90a7-4892-a54d-21010fce6ec2","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SalesQuoteAdvanceSLView>("03026b87-7fdb-4226-8d29-8de242a2fe37","","",false, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteAdvanceSLView>("6a7e3cbe-6328-4dfd-8568-e0eab0b9cfe1","","",true, this);
 
            VAT = RPSControlFactory.CreateRPSCheckBox<SalesQuoteAdvanceSLView>("960f4c62-75c7-4aa2-804c-884dacaaa190","","",true, this);
 
            AmountRecalculated = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteAdvanceSLView>("5227454d-329f-443b-b3bb-2de4762c3d58","","",true, this);
 
            Invoice = RPSControlFactory.CreateRPSCheckBox<SalesQuoteAdvanceSLView>("8e17193a-339e-48cf-860e-69f01d8e9e7e","","",true, this);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSComboBox<SalesQuoteAdvanceSLView>("00c9e2de-b921-420c-ab35-7058d053a669","","",false, this);
 
            IDVATType = RPSControlFactory.CreateRPSComboBox<SalesQuoteAdvanceSLView>("10ca6f35-f990-4c54-b7c7-51a5e6b3ab64","","",false, this);
 
            IDVAT = RPSControlFactory.CreateRPSComboBox<SalesQuoteAdvanceSLView>("af6c2ff0-2780-4932-8ff9-4806f31ddc88","","",false, this);
 
            PercentVAT = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteAdvanceSLView>("4e1516fa-7817-49cd-946a-1be2841c97db","","",true, this);
 
            PercentSurcharge = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteAdvanceSLView>("82ef76bd-fba9-4e8b-8a25-6958b39f1725","","",true, this);
 
            TaxType = RPSControlFactory.CreateRPSEnumComboBox<SalesQuoteAdvanceSLView>("5e6b91b5-6467-4108-bbb7-99883e322e3f","","",true, this);
 
            IDTaxGroup = RPSControlFactory.CreateRPSComboBox<SalesQuoteAdvanceSLView>("b3248af0-27bf-4f3f-8742-5fcd28335c6e","","",false, this);
 
            CollectionInit params_SalesQuoteAdvanceTaxSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="572ea8ba-af84-486d-aa79-d4fc4c35950c",CSSSelectorGrid="",XPathGrid=""};
            SalesQuoteAdvanceTaxSLs = RPSControlFactory.RPSCreateCollectionWithGrid<SalesQuoteAdvanceTaxSLsCollectionEditor<SalesQuoteAdvanceSLView,SalesQuoteAdvanceTaxSLView>,SalesQuoteAdvanceSLView,SalesQuoteAdvanceTaxSLView>( params_SalesQuoteAdvanceTaxSLs,this,Screen.SalesQuoteAdvanceTaxSLView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<SalesQuoteAdvanceSLView>( "","ul li[rpsid='0d2b83eb-d437-4355-8e55-12228bdf5e6e']","",this);
 
            Taxes = RPSControlFactory.CreateRPSSection<SalesQuoteAdvanceSLView>( "","ul li[rpsid='e1a17e5f-c022-4db1-8740-a44928346e2f']","",this);
 

        }
        public IRPSButton<SalesQuoteAdvanceSLView> DeleteButton { get; set; } 
        public IRPSButton<SalesQuoteAdvanceSLView,SalesQuoteLineSLView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SalesQuoteAdvanceSLView,SalesQuoteLineSLView> BackButton { get; set; } 
        public IRPSAcceptButton<SalesQuoteAdvanceSLView,SalesQuoteLineSLView> AcceptButton { get; set; } 
        public IRPSTextBox<SalesQuoteAdvanceSLView> NumAdvance { get; set; } 
        public IRPSTextBox<SalesQuoteAdvanceSLView> AdvanceDate { get; set; } 
        public IRPSTextBox<SalesQuoteAdvanceSLView> Description { get; set; } 
        public IRPSTextBox<SalesQuoteAdvanceSLView> Amount { get; set; } 
        public IRPSCheckbox<SalesQuoteAdvanceSLView> VAT { get; set; } 
        public IRPSTextBox<SalesQuoteAdvanceSLView> AmountRecalculated { get; set; } 
        public IRPSCheckbox<SalesQuoteAdvanceSLView> Invoice { get; set; } 
        public IRPSComboBox<SalesQuoteAdvanceSLView> IDPaymentMethod { get; set; } 
        public IRPSComboBox<SalesQuoteAdvanceSLView> IDVATType { get; set; } 
        public IRPSComboBox<SalesQuoteAdvanceSLView> IDVAT { get; set; } 
        public IRPSTextBox<SalesQuoteAdvanceSLView> PercentVAT { get; set; } 
        public IRPSTextBox<SalesQuoteAdvanceSLView> PercentSurcharge { get; set; } 
        public IRPSComboBox<SalesQuoteAdvanceSLView> TaxType { get; set; } 
        public IRPSComboBox<SalesQuoteAdvanceSLView> IDTaxGroup { get; set; } 
        public SalesQuoteAdvanceTaxSLsCollectionEditor<SalesQuoteAdvanceSLView,SalesQuoteAdvanceTaxSLView> SalesQuoteAdvanceTaxSLs { get; set; } 
        public IRPSSection<SalesQuoteAdvanceSLView> GeneralData { get; set; } 
        public IRPSSection<SalesQuoteAdvanceSLView> Taxes { get; set; } 
        public SalesQuoteSL Screen { get; set; }
        public SalesQuoteAdvanceSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SalesQuoteAdvanceTaxSLsCollectionEditor<SalesQuoteAdvanceSLView,SalesQuoteAdvanceTaxSLView>:RPSCollectionEditor<SalesQuoteAdvanceSLView,SalesQuoteAdvanceTaxSLView> where SalesQuoteAdvanceSLView : class, IView where SalesQuoteAdvanceTaxSLView : class, IView
    {
        public  SalesQuoteAdvanceTaxSLsGridView<SalesQuoteAdvanceSLView,SalesQuoteAdvanceTaxSLView> GridView {get;set;}
    }
    public partial class SalesQuoteAdvanceTaxSLsGridView <SalesQuoteAdvanceSLView,SalesQuoteAdvanceTaxSLView> :  RPSGridView<SalesQuoteAdvanceSLView,SalesQuoteAdvanceTaxSLView> where SalesQuoteAdvanceSLView : class, IView where SalesQuoteAdvanceTaxSLView : class, IView
    {
        public SalesQuoteAdvanceTaxSLsGridView(SalesQuoteAdvanceSLView currentView,SalesQuoteAdvanceTaxSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDTaxValue = RPSControlFactory.CreateRPSGridComboBox<SalesQuoteAdvanceSLView>("","#572ea8ba-af84-486d-aa79-d4fc4c35950c .ag-row[role='row']@ROWINDEX [col-id='cIDTaxValue']","",true, this.CurrentView);
 
            ApplicationType = RPSControlFactory.CreateRPSGridEnumComboBox<SalesQuoteAdvanceSLView>("","#572ea8ba-af84-486d-aa79-d4fc4c35950c .ag-row[role='row']@ROWINDEX [col-id='cApplicationType']","",true, this.CurrentView);
 
            BaseType = RPSControlFactory.CreateRPSGridEnumComboBox<SalesQuoteAdvanceSLView>("","#572ea8ba-af84-486d-aa79-d4fc4c35950c .ag-row[role='row']@ROWINDEX [col-id='cBaseType']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<SalesQuoteAdvanceSLView>("","#572ea8ba-af84-486d-aa79-d4fc4c35950c .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            Value = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesQuoteAdvanceSLView>("","#572ea8ba-af84-486d-aa79-d4fc4c35950c .ag-row[role='row']@ROWINDEX [col-id='cValue']","",true, this.CurrentView);
 
            VAT = RPSControlFactory.CreateRPSGridCheckBox<SalesQuoteAdvanceSLView>("","#572ea8ba-af84-486d-aa79-d4fc4c35950c .ag-row[role='row']@ROWINDEX [col-id='cVAT']","",true, this.CurrentView);
 
            PriceIncluded = RPSControlFactory.CreateRPSGridCheckBox<SalesQuoteAdvanceSLView>("","#572ea8ba-af84-486d-aa79-d4fc4c35950c .ag-row[role='row']@ROWINDEX [col-id='cPriceIncluded']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<SalesQuoteAdvanceSLView> IDTaxValue { get; set; } 
        public IRPSGridComboBox<SalesQuoteAdvanceSLView> ApplicationType { get; set; } 
        public IRPSGridComboBox<SalesQuoteAdvanceSLView> BaseType { get; set; } 
        public IRPSGridComboBox<SalesQuoteAdvanceSLView> Type { get; set; } 
        public IRPSGridTextBox<SalesQuoteAdvanceSLView> Value { get; set; } 
        public IRPSGridCheckbox<SalesQuoteAdvanceSLView> VAT { get; set; } 
        public IRPSGridCheckbox<SalesQuoteAdvanceSLView> PriceIncluded { get; set; } 
                     
    }
 
    }
  
            
    public partial class SalesQuoteVariablePaymentSLView : View
    {
        public SalesQuoteVariablePaymentSLView(SalesQuoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SalesQuoteVariablePaymentSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SalesQuoteVariablePaymentSLView,SalesQuoteLineSLView>( this,Screen.SalesQuoteLineSLView);
 
            BackButton = RPSControlFactory.RPSBackButton<SalesQuoteVariablePaymentSLView,SalesQuoteLineSLView>( this,Screen.SalesQuoteLineSLView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SalesQuoteVariablePaymentSLView,SalesQuoteLineSLView>( this,Screen.SalesQuoteLineSLView);
 
            NumPayment = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteVariablePaymentSLView>("f8e521a6-a47a-4677-bfbd-b53d78efe6f9","","",true, this);
 
            DatePayment = RPSControlFactory.CreateRPSTextBox<SalesQuoteVariablePaymentSLView>("a4628892-da76-4ab0-b63c-3afcd78247fc","","",false, this);
 
            DayPayment = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteVariablePaymentSLView>("cffe066a-5ebf-47e0-847a-b350c711a653","","",false, this);
 
            Percentage = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteVariablePaymentSLView>("35df6332-32a2-46bd-9596-c81f3d931800","","",true, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteVariablePaymentSLView>("11ee83fb-7828-4c87-86de-495b0828e775","","",true, this);
 
            Rest = RPSControlFactory.CreateRPSCheckBox<SalesQuoteVariablePaymentSLView>("6a6371d6-31c3-4370-b055-0725604d4af1","","",false, this);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSComboBox<SalesQuoteVariablePaymentSLView>("96eeba72-4f24-47f3-b27e-9364c604a280","","",false, this);
 

        }
        public IRPSButton<SalesQuoteVariablePaymentSLView> DeleteButton { get; set; } 
        public IRPSButton<SalesQuoteVariablePaymentSLView,SalesQuoteLineSLView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SalesQuoteVariablePaymentSLView,SalesQuoteLineSLView> BackButton { get; set; } 
        public IRPSAcceptButton<SalesQuoteVariablePaymentSLView,SalesQuoteLineSLView> AcceptButton { get; set; } 
        public IRPSTextBox<SalesQuoteVariablePaymentSLView> NumPayment { get; set; } 
        public IRPSTextBox<SalesQuoteVariablePaymentSLView> DatePayment { get; set; } 
        public IRPSTextBox<SalesQuoteVariablePaymentSLView> DayPayment { get; set; } 
        public IRPSTextBox<SalesQuoteVariablePaymentSLView> Percentage { get; set; } 
        public IRPSTextBox<SalesQuoteVariablePaymentSLView> Amount { get; set; } 
        public IRPSCheckbox<SalesQuoteVariablePaymentSLView> Rest { get; set; } 
        public IRPSComboBox<SalesQuoteVariablePaymentSLView> IDPaymentMethod { get; set; } 
        public SalesQuoteSL Screen { get; set; }
        public SalesQuoteVariablePaymentSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SalesQuoteAdvanceTaxSLView : View
    {
        public SalesQuoteAdvanceTaxSLView(SalesQuoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SalesQuoteAdvanceTaxSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SalesQuoteAdvanceTaxSLView,SalesQuoteAdvanceSLView>( this,Screen.SalesQuoteAdvanceSLView);
 
            BackButton = RPSControlFactory.RPSBackButton<SalesQuoteAdvanceTaxSLView,SalesQuoteAdvanceSLView>( this,Screen.SalesQuoteAdvanceSLView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SalesQuoteAdvanceTaxSLView,SalesQuoteAdvanceSLView>( this,Screen.SalesQuoteAdvanceSLView);
 
            IDTaxValue = RPSControlFactory.CreateRPSComboBox<SalesQuoteAdvanceTaxSLView>("85716220-0819-485c-ad15-e57c738c08f5","","",true, this);
 
            ApplicationType = RPSControlFactory.CreateRPSEnumComboBox<SalesQuoteAdvanceTaxSLView>("fea7bbfb-2217-4cf7-be7e-a2623ebaf311","","",true, this);
 
            BaseType = RPSControlFactory.CreateRPSEnumComboBox<SalesQuoteAdvanceTaxSLView>("e122ede5-8583-4877-b10a-6b75c02b8bf8","","",true, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<SalesQuoteAdvanceTaxSLView>("e3c0a249-24b6-46b8-a83e-6a5979ed4fee","","",true, this);
 
            Value = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteAdvanceTaxSLView>("e91e1845-5846-4349-9a43-496a69d50dea","","",true, this);
 
            VAT = RPSControlFactory.CreateRPSCheckBox<SalesQuoteAdvanceTaxSLView>("534a241e-0cb0-409a-adff-abce479530f9","","",true, this);
 
            PriceIncluded = RPSControlFactory.CreateRPSCheckBox<SalesQuoteAdvanceTaxSLView>("ef07036b-7729-416c-9968-34073a56c825","","",true, this);
 

        }
        public IRPSButton<SalesQuoteAdvanceTaxSLView> DeleteButton { get; set; } 
        public IRPSButton<SalesQuoteAdvanceTaxSLView,SalesQuoteAdvanceSLView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SalesQuoteAdvanceTaxSLView,SalesQuoteAdvanceSLView> BackButton { get; set; } 
        public IRPSAcceptButton<SalesQuoteAdvanceTaxSLView,SalesQuoteAdvanceSLView> AcceptButton { get; set; } 
        public IRPSComboBox<SalesQuoteAdvanceTaxSLView> IDTaxValue { get; set; } 
        public IRPSComboBox<SalesQuoteAdvanceTaxSLView> ApplicationType { get; set; } 
        public IRPSComboBox<SalesQuoteAdvanceTaxSLView> BaseType { get; set; } 
        public IRPSComboBox<SalesQuoteAdvanceTaxSLView> Type { get; set; } 
        public IRPSTextBox<SalesQuoteAdvanceTaxSLView> Value { get; set; } 
        public IRPSCheckbox<SalesQuoteAdvanceTaxSLView> VAT { get; set; } 
        public IRPSCheckbox<SalesQuoteAdvanceTaxSLView> PriceIncluded { get; set; } 
        public SalesQuoteSL Screen { get; set; }
        public SalesQuoteAdvanceTaxSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SalesQuoteLineTaxSLView : View
    {
        public SalesQuoteLineTaxSLView(SalesQuoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SalesQuoteLineTaxSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SalesQuoteLineTaxSLView,SalesQuoteLineSLView>( this,Screen.SalesQuoteLineSLView);
 
            BackButton = RPSControlFactory.RPSBackButton<SalesQuoteLineTaxSLView,SalesQuoteLineSLView>( this,Screen.SalesQuoteLineSLView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SalesQuoteLineTaxSLView,SalesQuoteLineSLView>( this,Screen.SalesQuoteLineSLView);
 
            IDTaxValue = RPSControlFactory.CreateRPSComboBox<SalesQuoteLineTaxSLView>("2abec68b-b2ba-4428-b015-7cd5f75d581c","","",true, this);
 
            ApplicationType = RPSControlFactory.CreateRPSEnumComboBox<SalesQuoteLineTaxSLView>("dfd6cbd1-c29a-42c2-93ae-7a18369b6675","","",true, this);
 
            BaseType = RPSControlFactory.CreateRPSEnumComboBox<SalesQuoteLineTaxSLView>("6c526eda-0796-44d2-b408-47944189ae19","","",true, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<SalesQuoteLineTaxSLView>("04e37af0-0581-4391-b512-16a3e619bdec","","",true, this);
 
            Value = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteLineTaxSLView>("bd75c726-6f55-420b-b0e4-ebaa1bca0273","","",true, this);
 
            PriceIncluded = RPSControlFactory.CreateRPSCheckBox<SalesQuoteLineTaxSLView>("2fb8435c-527d-43a6-a2f1-0402a1bb6f02","","",true, this);
 
            VAT = RPSControlFactory.CreateRPSCheckBox<SalesQuoteLineTaxSLView>("ffa77a09-8cff-4304-adae-1ceea68d6da6","","",true, this);
 

        }
        public IRPSButton<SalesQuoteLineTaxSLView> DeleteButton { get; set; } 
        public IRPSButton<SalesQuoteLineTaxSLView,SalesQuoteLineSLView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SalesQuoteLineTaxSLView,SalesQuoteLineSLView> BackButton { get; set; } 
        public IRPSAcceptButton<SalesQuoteLineTaxSLView,SalesQuoteLineSLView> AcceptButton { get; set; } 
        public IRPSComboBox<SalesQuoteLineTaxSLView> IDTaxValue { get; set; } 
        public IRPSComboBox<SalesQuoteLineTaxSLView> ApplicationType { get; set; } 
        public IRPSComboBox<SalesQuoteLineTaxSLView> BaseType { get; set; } 
        public IRPSComboBox<SalesQuoteLineTaxSLView> Type { get; set; } 
        public IRPSTextBox<SalesQuoteLineTaxSLView> Value { get; set; } 
        public IRPSCheckbox<SalesQuoteLineTaxSLView> PriceIncluded { get; set; } 
        public IRPSCheckbox<SalesQuoteLineTaxSLView> VAT { get; set; } 
        public SalesQuoteSL Screen { get; set; }
        public SalesQuoteLineTaxSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SalesQuoteIncidenceSLView : View
    {
        public SalesQuoteIncidenceSLView(SalesQuoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SalesQuoteIncidenceSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SalesQuoteIncidenceSLView,SalesQuoteSLEntityView>( this,Screen.SalesQuoteSLEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<SalesQuoteIncidenceSLView,SalesQuoteSLEntityView>( this,Screen.SalesQuoteSLEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SalesQuoteIncidenceSLView,SalesQuoteSLEntityView>( this,Screen.SalesQuoteSLEntityView);
 
            NumIncidence = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteIncidenceSLView>("9252a2e1-c1a4-4fd7-bad8-32a17ae27e68","","",true, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<SalesQuoteIncidenceSLView>("2c826b02-2fcd-4765-be45-0cf33d57edf8","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SalesQuoteIncidenceSLView>("b0d1f75a-49bd-4d4d-a4aa-18fa7b1283bd","","",false, this);
 

        }
        public IRPSButton<SalesQuoteIncidenceSLView> DeleteButton { get; set; } 
        public IRPSButton<SalesQuoteIncidenceSLView,SalesQuoteSLEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SalesQuoteIncidenceSLView,SalesQuoteSLEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<SalesQuoteIncidenceSLView,SalesQuoteSLEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<SalesQuoteIncidenceSLView> NumIncidence { get; set; } 
        public IRPSTextBox<SalesQuoteIncidenceSLView> Date { get; set; } 
        public IRPSTextBox<SalesQuoteIncidenceSLView> Description { get; set; } 
        public SalesQuoteSL Screen { get; set; }
        public SalesQuoteIncidenceSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SalesQuoteMilestoneSLView : View
    {
        public SalesQuoteMilestoneSLView(SalesQuoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SalesQuoteMilestoneSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SalesQuoteMilestoneSLView,SalesQuoteLineSLView>( this,Screen.SalesQuoteLineSLView);
 
            BackButton = RPSControlFactory.RPSBackButton<SalesQuoteMilestoneSLView,SalesQuoteLineSLView>( this,Screen.SalesQuoteLineSLView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SalesQuoteMilestoneSLView,SalesQuoteLineSLView>( this,Screen.SalesQuoteLineSLView);
 
            IDTask = RPSControlFactory.CreateRPSComboBox<SalesQuoteMilestoneSLView>("440710c1-f818-4871-b44e-63b5ea0ab08b","","",true, this);
 
            Final = RPSControlFactory.CreateRPSCheckBox<SalesQuoteMilestoneSLView>("c98ad0c0-f014-47f4-a71a-4933b9ba5230","","",false, this);
 
            PlannedDate = RPSControlFactory.CreateRPSTextBox<SalesQuoteMilestoneSLView>("3ebe498d-4fef-4fb3-ac6e-fb602c2dc4cd","","",false, this);
 
            Percentage = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteMilestoneSLView>("7735beb9-7241-4de5-95d1-bd7a2cf87ad7","","",true, this);
 
            GenerateAdvance = RPSControlFactory.CreateRPSCheckBox<SalesQuoteMilestoneSLView>("3635d24c-7914-484a-a4df-1eaef2abe981","","",true, this);
 

        }
        public IRPSButton<SalesQuoteMilestoneSLView> DeleteButton { get; set; } 
        public IRPSButton<SalesQuoteMilestoneSLView,SalesQuoteLineSLView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SalesQuoteMilestoneSLView,SalesQuoteLineSLView> BackButton { get; set; } 
        public IRPSAcceptButton<SalesQuoteMilestoneSLView,SalesQuoteLineSLView> AcceptButton { get; set; } 
        public IRPSComboBox<SalesQuoteMilestoneSLView> IDTask { get; set; } 
        public IRPSCheckbox<SalesQuoteMilestoneSLView> Final { get; set; } 
        public IRPSTextBox<SalesQuoteMilestoneSLView> PlannedDate { get; set; } 
        public IRPSTextBox<SalesQuoteMilestoneSLView> Percentage { get; set; } 
        public IRPSCheckbox<SalesQuoteMilestoneSLView> GenerateAdvance { get; set; } 
        public SalesQuoteSL Screen { get; set; }
        public SalesQuoteMilestoneSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SalesQuoteComAgentSLView : View
    {
        public SalesQuoteComAgentSLView(SalesQuoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SalesQuoteComAgentSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SalesQuoteComAgentSLView,SalesQuoteLineSLView>( this,Screen.SalesQuoteLineSLView);
 
            BackButton = RPSControlFactory.RPSBackButton<SalesQuoteComAgentSLView,SalesQuoteLineSLView>( this,Screen.SalesQuoteLineSLView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SalesQuoteComAgentSLView,SalesQuoteLineSLView>( this,Screen.SalesQuoteLineSLView);
 
            IDCommercialAgent = RPSControlFactory.CreateRPSComboBox<SalesQuoteComAgentSLView>("d8c41828-6938-4d75-a3fc-ae66faec66ca","","",true, this);
 
            IDCommercialAgentClassification = RPSControlFactory.CreateRPSComboBox<SalesQuoteComAgentSLView>("f8ec520f-007b-442d-bd86-a994a743e57b","","",true, this);
 
            Commission = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteComAgentSLView>("6db69be4-2774-44c8-b2c2-c305a07061e4","","",false, this);
 
            ComisionTypeString = RPSControlFactory.CreateRPSTextBox<SalesQuoteComAgentSLView>("b8f91e41-9b57-4ee4-ac0b-d95d56673972","","",false, this);
 
            ComisionHead = RPSControlFactory.CreateRPSCheckBox<SalesQuoteComAgentSLView>("af7cf654-93fa-4c27-8a41-25fa957f79dc","","",false, this);
 
            ChangeCommisionCommand = RPSControlFactory.CreateRPSButton<SalesQuoteComAgentSLView>( "c40f6ef7-9fb0-4295-9c02-162d7ea9727c","","",this);
 
            CollectionInit params_SalesQuoteCommisions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="66c060da-d27b-4ea9-a7e4-4e1d5173df23",CSSSelectorGrid="",XPathGrid=""};
            SalesQuoteCommisions = RPSControlFactory.RPSCreateCollectionWithGrid<SalesQuoteCommisionsCollectionEditor<SalesQuoteComAgentSLView>,SalesQuoteComAgentSLView>( params_SalesQuoteCommisions,this);
 

        }
        public IRPSButton<SalesQuoteComAgentSLView> DeleteButton { get; set; } 
        public IRPSButton<SalesQuoteComAgentSLView,SalesQuoteLineSLView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SalesQuoteComAgentSLView,SalesQuoteLineSLView> BackButton { get; set; } 
        public IRPSAcceptButton<SalesQuoteComAgentSLView,SalesQuoteLineSLView> AcceptButton { get; set; } 
        public IRPSComboBox<SalesQuoteComAgentSLView> IDCommercialAgent { get; set; } 
        public IRPSComboBox<SalesQuoteComAgentSLView> IDCommercialAgentClassification { get; set; } 
        public IRPSTextBox<SalesQuoteComAgentSLView> Commission { get; set; } 
        public IRPSTextBox<SalesQuoteComAgentSLView> ComisionTypeString { get; set; } 
        public IRPSCheckbox<SalesQuoteComAgentSLView> ComisionHead { get; set; } 
        public IRPSButton<SalesQuoteComAgentSLView> ChangeCommisionCommand { get; set; } 
        public SalesQuoteCommisionsCollectionEditor<SalesQuoteComAgentSLView> SalesQuoteCommisions { get; set; } 
        public SalesQuoteSL Screen { get; set; }
        public SalesQuoteComAgentSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SalesQuoteCommisionsCollectionEditor<SalesQuoteComAgentSLView>:RPSCollectionEditor<SalesQuoteComAgentSLView> where SalesQuoteComAgentSLView : class, IView
    {
        public  SalesQuoteCommisionsGridView<SalesQuoteComAgentSLView> GridView {get;set;}
    }
    public partial class SalesQuoteCommisionsGridView <SalesQuoteComAgentSLView> :  RPSGridView<SalesQuoteComAgentSLView> where SalesQuoteComAgentSLView : class, IView
    {
        public SalesQuoteCommisionsGridView(SalesQuoteComAgentSLView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Ordenation = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesQuoteComAgentSLView>("","#66c060da-d27b-4ea9-a7e4-4e1d5173df23 .ag-row[role='row']@ROWINDEX [col-id='cOrdenation']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<SalesQuoteComAgentSLView>("","#66c060da-d27b-4ea9-a7e4-4e1d5173df23 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            IDCommercialAgent = RPSControlFactory.CreateRPSGridComboBox<SalesQuoteComAgentSLView>("","#66c060da-d27b-4ea9-a7e4-4e1d5173df23 .ag-row[role='row']@ROWINDEX [col-id='cIDCommercialAgent']","",true, this.CurrentView);
 
            IDCommercialAgentClassification = RPSControlFactory.CreateRPSGridComboBox<SalesQuoteComAgentSLView>("","#66c060da-d27b-4ea9-a7e4-4e1d5173df23 .ag-row[role='row']@ROWINDEX [col-id='cIDCommercialAgentClassification']","",true, this.CurrentView);
 
            Commission = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesQuoteComAgentSLView>("","#66c060da-d27b-4ea9-a7e4-4e1d5173df23 .ag-row[role='row']@ROWINDEX [col-id='cCommission']","",false, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridTextBox<SalesQuoteComAgentSLView>("","#66c060da-d27b-4ea9-a7e4-4e1d5173df23 .ag-row[role='row']@ROWINDEX [col-id='cType']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SalesQuoteComAgentSLView> Ordenation { get; set; } 
        public IRPSGridTextBox<SalesQuoteComAgentSLView> Description { get; set; } 
        public IRPSGridComboBox<SalesQuoteComAgentSLView> IDCommercialAgent { get; set; } 
        public IRPSGridComboBox<SalesQuoteComAgentSLView> IDCommercialAgentClassification { get; set; } 
        public IRPSGridTextBox<SalesQuoteComAgentSLView> Commission { get; set; } 
        public IRPSGridTextBox<SalesQuoteComAgentSLView> Type { get; set; } 
                     
    }
 
    }
  
            
    public partial class SalesQuotePrintDialogView : View
    {
        public SalesQuotePrintDialogView(SalesQuoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIOptSalesQuoteDocument = RPSControlFactory.CreateRPSOption<SalesQuotePrintDialogView>( "688bd702-e496-4207-b8f0-348c8ff5444f","","",this);
 
            UIOptSalesQuoteReport = RPSControlFactory.CreateRPSOption<SalesQuotePrintDialogView>( "625acb8e-3bc6-4a4b-ae00-0e5b11603c5c","","",this);
 
            CustomerLanguage = RPSControlFactory.CreateRPSOption<SalesQuotePrintDialogView>( "609c2676-64fb-4d8b-9602-b20b946c25e1","","",this);
 
            SelectedLanguage = RPSControlFactory.CreateRPSOption<SalesQuotePrintDialogView>( "084e7d96-9dc7-46c5-bafd-c0c6bc8295f4","","",this);
 
            UIPrintOptionsIDLanguage = RPSControlFactory.CreateRPSComboBox<SalesQuotePrintDialogView>("85e1b0a1-f396-419e-8f2f-5881b844f75b","","",false, this);
 
            UIPrintSpecificReport = RPSControlFactory.CreateRPSCheckBox<SalesQuotePrintDialogView>("44517c06-cbfc-4c7b-999f-62dd32a8fa81","","",false, this);
 
            UICodSalesQuoteReport = RPSControlFactory.CreateRPSComboBox<SalesQuotePrintDialogView>("f420679f-f3b6-431c-bc8f-2d8e47882778","","",false, this);
 
            UIDocumentsArticle = RPSControlFactory.CreateRPSCheckBox<SalesQuotePrintDialogView>("cb6ebc1a-f945-4bd6-9c29-b5a0394c5098","","",false, this);
 
            UIOptAllDocuments = RPSControlFactory.CreateRPSOption<SalesQuotePrintDialogView>( "43aac03c-d25b-4033-92f7-2094a4ff7a0e","","",this);
 
            UIOptByDocument = RPSControlFactory.CreateRPSOption<SalesQuotePrintDialogView>( "d846cb7c-1244-4d29-8946-418c4ef4b1c3","","",this);
 
            UIDocumentsSalesQuote = RPSControlFactory.CreateRPSCheckBox<SalesQuotePrintDialogView>("7d398149-a6fa-4182-8cdb-851774aab6b6","","",false, this);
 
            UIOptAllDocuments1 = RPSControlFactory.CreateRPSOption<SalesQuotePrintDialogView>( "9fc5c78b-be0b-4b75-8cf7-42bd6b5cdd93","","",this);
 
            UIOptByDocument1 = RPSControlFactory.CreateRPSOption<SalesQuotePrintDialogView>( "6637e586-8822-4478-95f0-d54c1fbc1cb6","","",this);
 
            PrintSalesQuoteCommandButton = RPSControlFactory.CreateRPSButton<SalesQuotePrintDialogView>( "77c48b8c-76fc-4a72-930e-dcb0f6bbb2b3","","",this);
 
            PrintSalesQuoteDocumentCommandButton = RPSControlFactory.CreateRPSButton<SalesQuotePrintDialogView>( "b15d5369-8d4b-4f6b-9a40-8794921c20d1","","",this);
 
            SendSalesQuoteByEmailCommandButton = RPSControlFactory.CreateRPSButton<SalesQuotePrintDialogView>( "a5d3d2a4-a7f6-46c5-ac22-2fcb32f14f58","","",this);
 
            SendSalesQuoteToCustomerEmailCommandButton = RPSControlFactory.CreateRPSButton<SalesQuotePrintDialogView>( "01d55494-68ec-4963-a9ea-50f710ad0d21","","",this);
 
            SendSalesQuoteDocumentToCustomerEmailCommandButton = RPSControlFactory.CreateRPSButton<SalesQuotePrintDialogView>( "ba6f3fd7-80cf-4917-9c1a-65efd6eefb58","","",this);
 

        }
        public IRPSOption<SalesQuotePrintDialogView> UIOptSalesQuoteDocument { get; set; } 
        public IRPSOption<SalesQuotePrintDialogView> UIOptSalesQuoteReport { get; set; } 
        public IRPSOption<SalesQuotePrintDialogView> CustomerLanguage { get; set; } 
        public IRPSOption<SalesQuotePrintDialogView> SelectedLanguage { get; set; } 
        public IRPSComboBox<SalesQuotePrintDialogView> UIPrintOptionsIDLanguage { get; set; } 
        public IRPSCheckbox<SalesQuotePrintDialogView> UIPrintSpecificReport { get; set; } 
        public IRPSComboBox<SalesQuotePrintDialogView> UICodSalesQuoteReport { get; set; } 
        public IRPSCheckbox<SalesQuotePrintDialogView> UIDocumentsArticle { get; set; } 
        public IRPSOption<SalesQuotePrintDialogView> UIOptAllDocuments { get; set; } 
        public IRPSOption<SalesQuotePrintDialogView> UIOptByDocument { get; set; } 
        public IRPSCheckbox<SalesQuotePrintDialogView> UIDocumentsSalesQuote { get; set; } 
        public IRPSOption<SalesQuotePrintDialogView> UIOptAllDocuments1 { get; set; } 
        public IRPSOption<SalesQuotePrintDialogView> UIOptByDocument1 { get; set; } 
        public IRPSButton<SalesQuotePrintDialogView> PrintSalesQuoteCommandButton { get; set; } 
        public IRPSButton<SalesQuotePrintDialogView> PrintSalesQuoteDocumentCommandButton { get; set; } 
        public IRPSButton<SalesQuotePrintDialogView> SendSalesQuoteByEmailCommandButton { get; set; } 
        public IRPSButton<SalesQuotePrintDialogView> SendSalesQuoteToCustomerEmailCommandButton { get; set; } 
        public IRPSButton<SalesQuotePrintDialogView> SendSalesQuoteDocumentToCustomerEmailCommandButton { get; set; } 
        public SalesQuoteSL Screen { get; set; }
        public SalesQuotePrintDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NewArticleChildDialogView : View
    {
        public NewArticleChildDialogView(SalesQuoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSComboBox<NewArticleChildDialogView>("13cd01d6-d6fe-4c69-984a-ad8dc142f11f","","",true, this);
 
            bRecalPrice = RPSControlFactory.CreateRPSCheckBox<NewArticleChildDialogView>("559a38a1-77d2-48cf-af7a-02eec58eee73","","",false, this);
 

        }
        public IRPSComboBox<NewArticleChildDialogView> IDArticle { get; set; } 
        public IRPSCheckbox<NewArticleChildDialogView> bRecalPrice { get; set; } 
        public SalesQuoteSL Screen { get; set; }
        public NewArticleChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SalesQuoteLineCommercialAgentSLView : View
    {
        public SalesQuoteLineCommercialAgentSLView(SalesQuoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SalesQuoteLineCommercialAgentSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SalesQuoteLineCommercialAgentSLView,SalesQuoteLineSLView>( this,Screen.SalesQuoteLineSLView);
 
            BackButton = RPSControlFactory.RPSBackButton<SalesQuoteLineCommercialAgentSLView,SalesQuoteLineSLView>( this,Screen.SalesQuoteLineSLView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SalesQuoteLineCommercialAgentSLView,SalesQuoteLineSLView>( this,Screen.SalesQuoteLineSLView);
 
            IDCommercialAgent = RPSControlFactory.CreateRPSComboBox<SalesQuoteLineCommercialAgentSLView>("3ca80203-04fb-48ef-9f6b-7e819f2eb2e2","","",true, this);
 
            IDCommercialAgentClassification = RPSControlFactory.CreateRPSComboBox<SalesQuoteLineCommercialAgentSLView>("19f9e388-2565-48b2-ba3f-c70bd1796ea5","","",true, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<SalesQuoteLineCommercialAgentSLView>("7bce7761-4856-4d64-897a-54b86ff98d29","","",true, this);
 
            Commission = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteLineCommercialAgentSLView>("28b896c0-d238-4865-ae68-a9f5d903688a","","",true, this);
 
            CommissionAmount = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteLineCommercialAgentSLView>("ddd6a4c9-ffbd-4d63-9c3c-0941a97584da","","",true, this);
 

        }
        public IRPSButton<SalesQuoteLineCommercialAgentSLView> DeleteButton { get; set; } 
        public IRPSButton<SalesQuoteLineCommercialAgentSLView,SalesQuoteLineSLView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SalesQuoteLineCommercialAgentSLView,SalesQuoteLineSLView> BackButton { get; set; } 
        public IRPSAcceptButton<SalesQuoteLineCommercialAgentSLView,SalesQuoteLineSLView> AcceptButton { get; set; } 
        public IRPSComboBox<SalesQuoteLineCommercialAgentSLView> IDCommercialAgent { get; set; } 
        public IRPSComboBox<SalesQuoteLineCommercialAgentSLView> IDCommercialAgentClassification { get; set; } 
        public IRPSComboBox<SalesQuoteLineCommercialAgentSLView> Type { get; set; } 
        public IRPSTextBox<SalesQuoteLineCommercialAgentSLView> Commission { get; set; } 
        public IRPSTextBox<SalesQuoteLineCommercialAgentSLView> CommissionAmount { get; set; } 
        public SalesQuoteSL Screen { get; set; }
        public SalesQuoteLineCommercialAgentSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OptionChildDialogView : View
    {
        public OptionChildDialogView(SalesQuoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDSalesQuoteOption = RPSControlFactory.CreateRPSComboBox<OptionChildDialogView>("f5203e5b-45fa-4ad0-be89-526a839f8cc4","","",true, this);
 

        }
        public IRPSComboBox<OptionChildDialogView> IDSalesQuoteOption { get; set; } 
        public SalesQuoteSL Screen { get; set; }
        public OptionChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SalesQuoteComAgentNewChildDialogView : View
    {
        public SalesQuoteComAgentNewChildDialogView(SalesQuoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDCommercialAgent = RPSControlFactory.CreateRPSComboBox<SalesQuoteComAgentNewChildDialogView>("5ae829e7-c729-4ecb-bfec-1c407dc17f6e","","",true, this);
 
            IDCommercialAgentClassification = RPSControlFactory.CreateRPSComboBox<SalesQuoteComAgentNewChildDialogView>("be0c5dfc-6231-41c0-94de-d9fd4749f080","","",true, this);
 

        }
        public IRPSComboBox<SalesQuoteComAgentNewChildDialogView> IDCommercialAgent { get; set; } 
        public IRPSComboBox<SalesQuoteComAgentNewChildDialogView> IDCommercialAgentClassification { get; set; } 
        public SalesQuoteSL Screen { get; set; }
        public SalesQuoteComAgentNewChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SalesQuoteChangesChildDialogView : View
    {
        public SalesQuoteChangesChildDialogView(SalesQuoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ReceptionDate = RPSControlFactory.CreateRPSTextBox<SalesQuoteChangesChildDialogView>("b5bc7584-6841-493f-a320-fed241dfcc54","","",false, this);
 
            IDDeliveryNoteTypeSL = RPSControlFactory.CreateRPSComboBox<SalesQuoteChangesChildDialogView>("c1130dd9-1ace-4543-8eda-19087eb74ec3","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<SalesQuoteChangesChildDialogView>("36541f4b-8e8f-49e5-b1ba-70ddbabf4583","","",false, this);
 
            IDWareHouse = RPSControlFactory.CreateRPSComboBox<SalesQuoteChangesChildDialogView>("a2477ae3-92f1-4245-824a-dc1db3865e42","","",false, this);
 

        }
        public IRPSTextBox<SalesQuoteChangesChildDialogView> ReceptionDate { get; set; } 
        public IRPSComboBox<SalesQuoteChangesChildDialogView> IDDeliveryNoteTypeSL { get; set; } 
        public IRPSComboBox<SalesQuoteChangesChildDialogView> IDSite { get; set; } 
        public IRPSComboBox<SalesQuoteChangesChildDialogView> IDWareHouse { get; set; } 
        public SalesQuoteSL Screen { get; set; }
        public SalesQuoteChangesChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SalesQuoteOptionSLView : View
    {
        public SalesQuoteOptionSLView(SalesQuoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SalesQuoteOptionSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SalesQuoteOptionSLView,SalesQuoteLineSLView>( this,Screen.SalesQuoteLineSLView);
 
            BackButton = RPSControlFactory.RPSBackButton<SalesQuoteOptionSLView,SalesQuoteLineSLView>( this,Screen.SalesQuoteLineSLView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SalesQuoteOptionSLView,SalesQuoteLineSLView>( this,Screen.SalesQuoteLineSLView);
 
            CodOption = RPSControlFactory.CreateRPSTextBox<SalesQuoteOptionSLView>("31f3e34d-40d7-4864-8c93-1b0164cb8c66","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SalesQuoteOptionSLView>("731463ae-0ec5-4e22-aa5c-0fc5d233d5d8","","",false, this);
 
            Total = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteOptionSLView>("fef8e7f3-ddb5-47e6-ac46-51fa4af7e373","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<SalesQuoteOptionSLView>("38f0a940-62e5-42f6-9665-014018c46c33","","",false, this);
 
            TotalCost = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteOptionSLView>("88c03e6e-0342-4595-926f-97e4145d079b","","",false, this);
 
            Margin = RPSControlFactory.CreateRPSFormattedTextBox<SalesQuoteOptionSLView>("34507f72-ff02-452d-bf11-0aee037d0d44","","",false, this);
 

        }
        public IRPSButton<SalesQuoteOptionSLView> DeleteButton { get; set; } 
        public IRPSButton<SalesQuoteOptionSLView,SalesQuoteLineSLView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SalesQuoteOptionSLView,SalesQuoteLineSLView> BackButton { get; set; } 
        public IRPSAcceptButton<SalesQuoteOptionSLView,SalesQuoteLineSLView> AcceptButton { get; set; } 
        public IRPSTextBox<SalesQuoteOptionSLView> CodOption { get; set; } 
        public IRPSTextBox<SalesQuoteOptionSLView> Description { get; set; } 
        public IRPSTextBox<SalesQuoteOptionSLView> Total { get; set; } 
        public IRPSTextBox<SalesQuoteOptionSLView> Comment { get; set; } 
        public IRPSTextBox<SalesQuoteOptionSLView> TotalCost { get; set; } 
        public IRPSTextBox<SalesQuoteOptionSLView> Margin { get; set; } 
        public SalesQuoteSL Screen { get; set; }
        public SalesQuoteOptionSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OrderDataChildDialogView : View
    {
        public OrderDataChildDialogView(SalesQuoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SalesQuoteDate = RPSControlFactory.CreateRPSOption<OrderDataChildDialogView>( "2257c792-2e00-43fa-910b-16131eb2a679","","",this);
 
            RecalculateDate = RPSControlFactory.CreateRPSOption<OrderDataChildDialogView>( "5747d8ca-56bd-4542-8d45-8f9dc9145011","","",this);
 
            CodOrderNew = RPSControlFactory.CreateRPSTextBox<OrderDataChildDialogView>("c5b48636-ad41-4e58-8f5c-90e81f9bcc2e","","",false, this);
 
            IDCloseReasonSL = RPSControlFactory.CreateRPSComboBox<OrderDataChildDialogView>("af829536-6be4-4cda-8b6e-0691b284dd3f","","",true, this);
 
            Advances = RPSControlFactory.CreateRPSCheckBox<OrderDataChildDialogView>("ae6d1217-94b9-4227-a4cc-832e890f6477","","",false, this);
 
            Documents = RPSControlFactory.CreateRPSCheckBox<OrderDataChildDialogView>("5e45fb34-0793-4b4d-9957-f2db449772fc","","",false, this);
 
            VariablePayments = RPSControlFactory.CreateRPSCheckBox<OrderDataChildDialogView>("a77559f1-e345-4e26-8768-daf694c1cd8c","","",false, this);
 
            CollectionInit params_OrderGenerateGridLinesCollection = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b93a1e3d-0e9a-493e-9e89-78f21a98d675",CSSSelectorGrid="",XPathGrid=""};
            OrderGenerateGridLinesCollection = RPSControlFactory.RPSCreateCollectionWithGrid<OrderGenerateGridLinesCollectionCollectionEditor<OrderDataChildDialogView>,OrderDataChildDialogView>( params_OrderGenerateGridLinesCollection,this);
 

        }
        public IRPSOption<OrderDataChildDialogView> SalesQuoteDate { get; set; } 
        public IRPSOption<OrderDataChildDialogView> RecalculateDate { get; set; } 
        public IRPSTextBox<OrderDataChildDialogView> CodOrderNew { get; set; } 
        public IRPSComboBox<OrderDataChildDialogView> IDCloseReasonSL { get; set; } 
        public IRPSCheckbox<OrderDataChildDialogView> Advances { get; set; } 
        public IRPSCheckbox<OrderDataChildDialogView> Documents { get; set; } 
        public IRPSCheckbox<OrderDataChildDialogView> VariablePayments { get; set; } 
        public OrderGenerateGridLinesCollectionCollectionEditor<OrderDataChildDialogView> OrderGenerateGridLinesCollection { get; set; } 
        public SalesQuoteSL Screen { get; set; }
        public OrderDataChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class OrderGenerateGridLinesCollectionCollectionEditor<OrderDataChildDialogView>:RPSCollectionEditor<OrderDataChildDialogView> where OrderDataChildDialogView : class, IView
    {
        public  OrderGenerateGridLinesCollectionGridView<OrderDataChildDialogView> GridView {get;set;}
    }
    public partial class OrderGenerateGridLinesCollectionGridView <OrderDataChildDialogView> :  RPSGridView<OrderDataChildDialogView> where OrderDataChildDialogView : class, IView
    {
        public OrderGenerateGridLinesCollectionGridView(OrderDataChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<OrderDataChildDialogView>("","#b93a1e3d-0e9a-493e-9e89-78f21a98d675 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderDataChildDialogView>("","#b93a1e3d-0e9a-493e-9e89-78f21a98d675 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            AcceptedQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderDataChildDialogView>("","#b93a1e3d-0e9a-493e-9e89-78f21a98d675 .ag-row[role='row']@ROWINDEX [col-id='cAcceptedQuantity']","",true, this.CurrentView);
 
            OrderQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderDataChildDialogView>("","#b93a1e3d-0e9a-493e-9e89-78f21a98d675 .ag-row[role='row']@ROWINDEX [col-id='cOrderQuantity']","",true, this.CurrentView);
 
            QuantityToOrder = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderDataChildDialogView>("","#b93a1e3d-0e9a-493e-9e89-78f21a98d675 .ag-row[role='row']@ROWINDEX [col-id='cQuantityToOrder']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<OrderDataChildDialogView> IDArticle { get; set; } 
        public IRPSGridTextBox<OrderDataChildDialogView> Quantity { get; set; } 
        public IRPSGridTextBox<OrderDataChildDialogView> AcceptedQuantity { get; set; } 
        public IRPSGridTextBox<OrderDataChildDialogView> OrderQuantity { get; set; } 
        public IRPSGridTextBox<OrderDataChildDialogView> QuantityToOrder { get; set; } 
                     
    }
 
    }
  
            
    public partial class GenerateCustomerArticleChildDialogView : View
    {
        public GenerateCustomerArticleChildDialogView(SalesQuoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIDateFrom = RPSControlFactory.CreateRPSTextBox<GenerateCustomerArticleChildDialogView>("13cea51e-e33e-42db-85bb-59e622103804","","",true, this);
 
            UIDateTo = RPSControlFactory.CreateRPSTextBox<GenerateCustomerArticleChildDialogView>("dab81227-6aab-4473-94bf-8d7f16084081","","",true, this);
 
            UIUseSalesQuoteLineQuantity = RPSControlFactory.CreateRPSCheckBox<GenerateCustomerArticleChildDialogView>("2fa92b8c-076c-4f45-a9c7-34c62b2b2cab","","",false, this);
 

        }
        public IRPSTextBox<GenerateCustomerArticleChildDialogView> UIDateFrom { get; set; } 
        public IRPSTextBox<GenerateCustomerArticleChildDialogView> UIDateTo { get; set; } 
        public IRPSCheckbox<GenerateCustomerArticleChildDialogView> UIUseSalesQuoteLineQuantity { get; set; } 
        public SalesQuoteSL Screen { get; set; }
        public GenerateCustomerArticleChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ChangeCustomerChildDialogView : View
    {
        public ChangeCustomerChildDialogView(SalesQuoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDCustomer = RPSControlFactory.CreateRPSComboBox<ChangeCustomerChildDialogView>("ee23f1fc-c136-4c97-9cb7-2a10b31e60f6","","",false, this);
 
            IDPotentialCustomer = RPSControlFactory.CreateRPSComboBox<ChangeCustomerChildDialogView>("98bc980f-8536-4d77-a1e4-b6ff2e8eacd8","","",false, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<ChangeCustomerChildDialogView>("cb03adbf-c7c6-4c5c-9111-6bc62c10590f","","",false, this);
 
            IDCustomerMiscellaneous = RPSControlFactory.CreateRPSComboBox<ChangeCustomerChildDialogView>("98973288-1bdf-4431-9623-a54d1037d42a","","",false, this);
 
            NewCustomer = RPSControlFactory.CreateRPSComboBox<ChangeCustomerChildDialogView>("46cd31a3-4d68-4a37-8716-a11009d4d0a4","","",true, this);
 
            NewPotentialCustomer = RPSControlFactory.CreateRPSComboBox<ChangeCustomerChildDialogView>("635f6be1-5979-41d4-856d-15431f9fd817","","",false, this);
 
            IDNewCustomerMiscellaneousSL = RPSControlFactory.CreateRPSComboBox<ChangeCustomerChildDialogView>("486b3952-181d-426a-a2fd-e62276acbc1a","","",false, this);
 
            NewVATNumber = RPSControlFactory.CreateRPSTextBox<ChangeCustomerChildDialogView>("a39be641-8a53-4008-8e5c-bc3452761012","","",false, this);
 
            NewPotentialVATNumber = RPSControlFactory.CreateRPSTextBox<ChangeCustomerChildDialogView>("76396ebe-ab59-4da8-addc-6de6e31cc497","","",false, this);
 
            bChangeHeader = RPSControlFactory.CreateRPSCheckBox<ChangeCustomerChildDialogView>("8a4405eb-5296-43d1-aab6-3f56dc0f0ce2","","",false, this);
 

        }
        public IRPSComboBox<ChangeCustomerChildDialogView> IDCustomer { get; set; } 
        public IRPSComboBox<ChangeCustomerChildDialogView> IDPotentialCustomer { get; set; } 
        public IRPSTextBox<ChangeCustomerChildDialogView> VATNumber { get; set; } 
        public IRPSComboBox<ChangeCustomerChildDialogView> IDCustomerMiscellaneous { get; set; } 
        public IRPSComboBox<ChangeCustomerChildDialogView> NewCustomer { get; set; } 
        public IRPSComboBox<ChangeCustomerChildDialogView> NewPotentialCustomer { get; set; } 
        public IRPSComboBox<ChangeCustomerChildDialogView> IDNewCustomerMiscellaneousSL { get; set; } 
        public IRPSTextBox<ChangeCustomerChildDialogView> NewVATNumber { get; set; } 
        public IRPSTextBox<ChangeCustomerChildDialogView> NewPotentialVATNumber { get; set; } 
        public IRPSCheckbox<ChangeCustomerChildDialogView> bChangeHeader { get; set; } 
        public SalesQuoteSL Screen { get; set; }
        public ChangeCustomerChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FrameworkContractFromSalesQuoteChildDialogView : View
    {
        public FrameworkContractFromSalesQuoteChildDialogView(SalesQuoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewCodFrameworkContract = RPSControlFactory.CreateRPSTextBox<FrameworkContractFromSalesQuoteChildDialogView>("3ff8486c-251d-4794-b904-e9515ec69c8f","","",false, this);
 
            NewFrameworkContractDate = RPSControlFactory.CreateRPSTextBox<FrameworkContractFromSalesQuoteChildDialogView>("4297e61c-008f-44fa-81ad-642c714d5d5c","","",true, this);
 
            CopyDocuments = RPSControlFactory.CreateRPSCheckBox<FrameworkContractFromSalesQuoteChildDialogView>("4c2d2f2f-084d-4f11-9850-0bd97ddbf1cb","","",false, this);
 
            NewFrameworkContractDateFrom = RPSControlFactory.CreateRPSTextBox<FrameworkContractFromSalesQuoteChildDialogView>("fb575654-847c-4a66-b1cb-9d62fd7aeefa","","",true, this);
 
            NewFrameworkContractDateTo = RPSControlFactory.CreateRPSTextBox<FrameworkContractFromSalesQuoteChildDialogView>("06e30c18-b105-4b4d-b8ab-5a59017cca14","","",true, this);
 
            IDCloseReason = RPSControlFactory.CreateRPSComboBox<FrameworkContractFromSalesQuoteChildDialogView>("076defe1-7a36-4afa-99ca-cef2adf8f525","","",true, this);
 

        }
        public IRPSTextBox<FrameworkContractFromSalesQuoteChildDialogView> NewCodFrameworkContract { get; set; } 
        public IRPSTextBox<FrameworkContractFromSalesQuoteChildDialogView> NewFrameworkContractDate { get; set; } 
        public IRPSCheckbox<FrameworkContractFromSalesQuoteChildDialogView> CopyDocuments { get; set; } 
        public IRPSTextBox<FrameworkContractFromSalesQuoteChildDialogView> NewFrameworkContractDateFrom { get; set; } 
        public IRPSTextBox<FrameworkContractFromSalesQuoteChildDialogView> NewFrameworkContractDateTo { get; set; } 
        public IRPSComboBox<FrameworkContractFromSalesQuoteChildDialogView> IDCloseReason { get; set; } 
        public SalesQuoteSL Screen { get; set; }
        public FrameworkContractFromSalesQuoteChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DueDateCalculationDialogView : View
    {
        public DueDateCalculationDialogView(SalesQuoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSComboBox<DueDateCalculationDialogView>("31cc8fd8-3778-4db7-8a00-fc6b486c99ca","","",false, this);
 
            AcceptedQuantity = RPSControlFactory.CreateRPSFormattedTextBox<DueDateCalculationDialogView>("f0fb5ec9-eea9-42a8-9045-08117f516d02","","",false, this);
 
            OrderQuantity = RPSControlFactory.CreateRPSFormattedTextBox<DueDateCalculationDialogView>("f4ea71c6-0f97-401d-80e3-bd750331d650","","",false, this);
 
            PendingQuantity = RPSControlFactory.CreateRPSFormattedTextBox<DueDateCalculationDialogView>("3a4ece11-9acb-4977-a883-5843a75f16c3","","",false, this);
 
            ReceptionDate = RPSControlFactory.CreateRPSTextBox<DueDateCalculationDialogView>("90f22eaf-e242-478d-9c00-0c95292cd638","","",false, this);
 
            CalculatedDate = RPSControlFactory.CreateRPSTextBox<DueDateCalculationDialogView>("d3c3bde9-30f4-45e9-a0f1-ab702383696f","","",false, this);
 
            LastCalculatedDate = RPSControlFactory.CreateRPSTextBox<DueDateCalculationDialogView>("604d4563-705a-47bd-bd4e-eac060558d25","","",false, this);
 
            Message = RPSControlFactory.CreateRPSTextBox<DueDateCalculationDialogView>("7e6528c4-a67f-4a1c-a881-a4396cadddaf","","",false, this);
 
            CalculateDateCommand = RPSControlFactory.CreateRPSButton<DueDateCalculationDialogView>( "a7af80a1-a9ed-4e6c-add5-ba6a35a8e394","","",this);
 
            ExecuteSaveSalesQuoteLineDueDateCalculation = RPSControlFactory.CreateRPSButton<DueDateCalculationDialogView>( "c004482f-0805-4242-9a2d-89fa39686c55","","",this);
 
            CancelCommand = RPSControlFactory.CreateRPSButton<DueDateCalculationDialogView>( "27d31af0-7512-4fc8-bb33-e5298cf18f42","","",this);
 

        }
        public IRPSComboBox<DueDateCalculationDialogView> IDArticle { get; set; } 
        public IRPSTextBox<DueDateCalculationDialogView> AcceptedQuantity { get; set; } 
        public IRPSTextBox<DueDateCalculationDialogView> OrderQuantity { get; set; } 
        public IRPSTextBox<DueDateCalculationDialogView> PendingQuantity { get; set; } 
        public IRPSTextBox<DueDateCalculationDialogView> ReceptionDate { get; set; } 
        public IRPSTextBox<DueDateCalculationDialogView> CalculatedDate { get; set; } 
        public IRPSTextBox<DueDateCalculationDialogView> LastCalculatedDate { get; set; } 
        public IRPSTextBox<DueDateCalculationDialogView> Message { get; set; } 
        public IRPSButton<DueDateCalculationDialogView> CalculateDateCommand { get; set; } 
        public IRPSButton<DueDateCalculationDialogView> ExecuteSaveSalesQuoteLineDueDateCalculation { get; set; } 
        public IRPSButton<DueDateCalculationDialogView> CancelCommand { get; set; } 
        public SalesQuoteSL Screen { get; set; }
        public DueDateCalculationDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class AddToCompositionExistingDocumentDialogView : View
    {
        public AddToCompositionExistingDocumentDialogView(SalesQuoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDDocument = RPSControlFactory.CreateRPSCollectionComboBox<AddToCompositionExistingDocumentDialogView>("423e9d45-eb0c-4ce6-b346-db90089dea4c","","",false, this);
 

        }
        public IRPSCollectionComboBox<AddToCompositionExistingDocumentDialogView> IDDocument { get; set; } 
        public SalesQuoteSL Screen { get; set; }
        public AddToCompositionExistingDocumentDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class AddToCompositionSalesQuoteHeaderDialogView : View
    {
        public AddToCompositionSalesQuoteHeaderDialogView(SalesQuoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_DocumentsSearch = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="01669cc8-c973-4e44-8f8e-4ce9a6ba2d43",CSSSelectorGrid="",XPathGrid=""};
            DocumentsSearch = RPSControlFactory.RPSCreateCollectionWithGrid<DocumentsSearchCollectionEditor<AddToCompositionSalesQuoteHeaderDialogView>,AddToCompositionSalesQuoteHeaderDialogView>( params_DocumentsSearch,this);
 

        }
        public DocumentsSearchCollectionEditor<AddToCompositionSalesQuoteHeaderDialogView> DocumentsSearch { get; set; } 
        public SalesQuoteSL Screen { get; set; }
        public AddToCompositionSalesQuoteHeaderDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DocumentsSearchCollectionEditor<AddToCompositionSalesQuoteHeaderDialogView>:RPSCollectionEditor<AddToCompositionSalesQuoteHeaderDialogView> where AddToCompositionSalesQuoteHeaderDialogView : class, IView
    {
        public  DocumentsSearchGridView<AddToCompositionSalesQuoteHeaderDialogView> GridView {get;set;}
    }
    public partial class DocumentsSearchGridView <AddToCompositionSalesQuoteHeaderDialogView> :  RPSGridView<AddToCompositionSalesQuoteHeaderDialogView> where AddToCompositionSalesQuoteHeaderDialogView : class, IView
    {
        public DocumentsSearchGridView(AddToCompositionSalesQuoteHeaderDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Document_Date = RPSControlFactory.CreateRPSGridTextBox<AddToCompositionSalesQuoteHeaderDialogView>("","#01669cc8-c973-4e44-8f8e-4ce9a6ba2d43 .ag-row[role='row']@ROWINDEX [col-id='cDocument_Date']","",false, this.CurrentView);
 
            Document_Description = RPSControlFactory.CreateRPSGridTextBox<AddToCompositionSalesQuoteHeaderDialogView>("","#01669cc8-c973-4e44-8f8e-4ce9a6ba2d43 .ag-row[role='row']@ROWINDEX [col-id='cDocument_Description']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<AddToCompositionSalesQuoteHeaderDialogView> Document_Date { get; set; } 
        public IRPSGridTextBox<AddToCompositionSalesQuoteHeaderDialogView> Document_Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class AddToCompositionArticleDocumentDialogView : View
    {
        public AddToCompositionArticleDocumentDialogView(SalesQuoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_DocumentsSearch = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="28ac68f9-3181-48e4-8a07-b22e329c546a",CSSSelectorGrid="",XPathGrid=""};
            DocumentsSearch = RPSControlFactory.RPSCreateCollectionWithGrid<DocumentsSearchCollectionEditor<AddToCompositionArticleDocumentDialogView>,AddToCompositionArticleDocumentDialogView>( params_DocumentsSearch,this);
 

        }
        public DocumentsSearchCollectionEditor<AddToCompositionArticleDocumentDialogView> DocumentsSearch { get; set; } 
        public SalesQuoteSL Screen { get; set; }
        public AddToCompositionArticleDocumentDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DocumentsSearchCollectionEditor<AddToCompositionArticleDocumentDialogView>:RPSCollectionEditor<AddToCompositionArticleDocumentDialogView> where AddToCompositionArticleDocumentDialogView : class, IView
    {
        public  DocumentsSearchGridView<AddToCompositionArticleDocumentDialogView> GridView {get;set;}
    }
    public partial class DocumentsSearchGridView <AddToCompositionArticleDocumentDialogView> :  RPSGridView<AddToCompositionArticleDocumentDialogView> where AddToCompositionArticleDocumentDialogView : class, IView
    {
        public DocumentsSearchGridView(AddToCompositionArticleDocumentDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Document_Date = RPSControlFactory.CreateRPSGridTextBox<AddToCompositionArticleDocumentDialogView>("","#28ac68f9-3181-48e4-8a07-b22e329c546a .ag-row[role='row']@ROWINDEX [col-id='cDocument_Date']","",false, this.CurrentView);
 
            Document_Description = RPSControlFactory.CreateRPSGridTextBox<AddToCompositionArticleDocumentDialogView>("","#28ac68f9-3181-48e4-8a07-b22e329c546a .ag-row[role='row']@ROWINDEX [col-id='cDocument_Description']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<AddToCompositionArticleDocumentDialogView> Document_Date { get; set; } 
        public IRPSGridTextBox<AddToCompositionArticleDocumentDialogView> Document_Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class AddToCompositionReportDialogView : View
    {
        public AddToCompositionReportDialogView(SalesQuoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDCustomReport = RPSControlFactory.CreateRPSCollectionComboBox<AddToCompositionReportDialogView>("0a183eef-c830-42a0-93c5-610f67253876","","",false, this);
 

        }
        public IRPSCollectionComboBox<AddToCompositionReportDialogView> IDCustomReport { get; set; } 
        public SalesQuoteSL Screen { get; set; }
        public AddToCompositionReportDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SalesQuoteProFormaPrintDialogView : View
    {
        public SalesQuoteProFormaPrintDialogView(SalesQuoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CustomerLanguage = RPSControlFactory.CreateRPSOption<SalesQuoteProFormaPrintDialogView>( "4fcb48f3-676e-4352-91f5-619434aea2a6","","",this);
 
            SelectedLanguage = RPSControlFactory.CreateRPSOption<SalesQuoteProFormaPrintDialogView>( "6f63b3cb-1cfe-4894-817a-55888b6e9cf7","","",this);
 
            UIPrintOptionsIDLanguage = RPSControlFactory.CreateRPSComboBox<SalesQuoteProFormaPrintDialogView>("87d1b7ef-b4d7-45e0-a7a4-eee12db13602","","",false, this);
 
            UIPrintSpecificReportProForma = RPSControlFactory.CreateRPSCheckBox<SalesQuoteProFormaPrintDialogView>("8a4fc29a-4efb-4c4f-8969-f51615cc8b45","","",false, this);
 
            UICodSalesQuoteProFormaReport = RPSControlFactory.CreateRPSComboBox<SalesQuoteProFormaPrintDialogView>("73e68b7a-0797-4abc-8385-48ef0c49aa05","","",false, this);
 
            ProFormaDateTime = RPSControlFactory.CreateRPSTextBox<SalesQuoteProFormaPrintDialogView>("ffdef78b-a6e5-4a11-8613-19b02a7eca50","","",false, this);
 
            PrintSalesQuoteProFormaCommandButton = RPSControlFactory.CreateRPSButton<SalesQuoteProFormaPrintDialogView>( "636321f5-5ac6-473c-bc96-49b04cd96f03","","",this);
 
            SendSalesQuoteProFormaByEmailCommandButton = RPSControlFactory.CreateRPSButton<SalesQuoteProFormaPrintDialogView>( "8551e2ad-fa0b-402c-93da-25a38bac1af4","","",this);
 
            SendSalesQuoteProFormaToCustomerEmailCommandButton = RPSControlFactory.CreateRPSButton<SalesQuoteProFormaPrintDialogView>( "057e506b-1641-47f3-8bbe-5f6cfb9344ce","","",this);
 

        }
        public IRPSOption<SalesQuoteProFormaPrintDialogView> CustomerLanguage { get; set; } 
        public IRPSOption<SalesQuoteProFormaPrintDialogView> SelectedLanguage { get; set; } 
        public IRPSComboBox<SalesQuoteProFormaPrintDialogView> UIPrintOptionsIDLanguage { get; set; } 
        public IRPSCheckbox<SalesQuoteProFormaPrintDialogView> UIPrintSpecificReportProForma { get; set; } 
        public IRPSComboBox<SalesQuoteProFormaPrintDialogView> UICodSalesQuoteProFormaReport { get; set; } 
        public IRPSTextBox<SalesQuoteProFormaPrintDialogView> ProFormaDateTime { get; set; } 
        public IRPSButton<SalesQuoteProFormaPrintDialogView> PrintSalesQuoteProFormaCommandButton { get; set; } 
        public IRPSButton<SalesQuoteProFormaPrintDialogView> SendSalesQuoteProFormaByEmailCommandButton { get; set; } 
        public IRPSButton<SalesQuoteProFormaPrintDialogView> SendSalesQuoteProFormaToCustomerEmailCommandButton { get; set; } 
        public SalesQuoteSL Screen { get; set; }
        public SalesQuoteProFormaPrintDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NewVersionChildDialogView : View
    {
        public NewVersionChildDialogView(SalesQuoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UISalesQuoteCopyVersion = RPSControlFactory.CreateRPSTextBox<NewVersionChildDialogView>("4329df78-f1e9-4bc0-b714-83768efb6887","","",false, this);
 
            UISalesQuoteCopyDate = RPSControlFactory.CreateRPSTextBox<NewVersionChildDialogView>("343f43d2-b881-43b4-a50d-02e10c9d6675","","",false, this);
 
            UISalesQuoteCopyUpdateConditions = RPSControlFactory.CreateRPSCheckBox<NewVersionChildDialogView>("826061cc-80ed-4501-bcb5-0fabc189bdf2","","",false, this);
 
            bRecalcLines = RPSControlFactory.CreateRPSCheckBox<NewVersionChildDialogView>("5f8a95eb-ad71-4e2a-8810-f199f3abdc56","","",false, this);
 

        }
        public IRPSTextBox<NewVersionChildDialogView> UISalesQuoteCopyVersion { get; set; } 
        public IRPSTextBox<NewVersionChildDialogView> UISalesQuoteCopyDate { get; set; } 
        public IRPSCheckbox<NewVersionChildDialogView> UISalesQuoteCopyUpdateConditions { get; set; } 
        public IRPSCheckbox<NewVersionChildDialogView> bRecalcLines { get; set; } 
        public SalesQuoteSL Screen { get; set; }
        public NewVersionChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NewFromCopyChildDialogView : View
    {
        public NewFromCopyChildDialogView(SalesQuoteSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Customer = RPSControlFactory.CreateRPSOption<NewFromCopyChildDialogView>( "ca19cc6b-8119-4504-89f0-960050b563a1","","",this);
 
            PotentialCustomer = RPSControlFactory.CreateRPSOption<NewFromCopyChildDialogView>( "9003e31e-46aa-411e-8386-24b61a7c3538","","",this);
 
            UINewSalesQuoteFromCopyCode = RPSControlFactory.CreateRPSTextBox<NewFromCopyChildDialogView>("179d015b-942c-45ce-9aef-87703e9049ec","","",false, this);
 
            UISalesQuoteCopyIDCustomer = RPSControlFactory.CreateRPSComboBox<NewFromCopyChildDialogView>("019db9a4-431a-4d14-bba1-4748426212e9","","",false, this);
 
            UISalesQuoteCopyIDCustomerMiscellaneousSL = RPSControlFactory.CreateRPSComboBox<NewFromCopyChildDialogView>("e66705bd-36f2-428c-81d7-d4f19ab84d01","","",false, this);
 
            UISalesQuoteCopyIDPotentialCustomer = RPSControlFactory.CreateRPSComboBox<NewFromCopyChildDialogView>("5949d75e-86ea-48e3-8889-faf1358b77e7","","",false, this);
 
            UISalesQuoteCopyVersion = RPSControlFactory.CreateRPSTextBox<NewFromCopyChildDialogView>("91dc0106-4c96-4252-8ab3-051f5c087a2a","","",false, this);
 
            UISalesQuoteCopyDate = RPSControlFactory.CreateRPSTextBox<NewFromCopyChildDialogView>("dd17b51e-241a-4e59-9b82-bcc6238b9b22","","",false, this);
 
            UISalesQuoteCopyPendingQuantity = RPSControlFactory.CreateRPSCheckBox<NewFromCopyChildDialogView>("103f5eda-5666-453b-8471-b95c4c8a2d79","","",false, this);
 
            UISalesQuoteCopyUpdateConditions = RPSControlFactory.CreateRPSCheckBox<NewFromCopyChildDialogView>("39312b3a-546a-4d07-8e12-6e55f694e438","","",false, this);
 
            bRecalcLines = RPSControlFactory.CreateRPSCheckBox<NewFromCopyChildDialogView>("3e224227-5a8b-49d7-8e8e-363820daf11a","","",false, this);
 
            UISalesQuoteCopyDocuments = RPSControlFactory.CreateRPSCheckBox<NewFromCopyChildDialogView>("b988facf-34a4-4c8b-ab76-cd7fe65fa676","","",false, this);
 
            UISalesQuoteCopyPaymentMethods = RPSControlFactory.CreateRPSCheckBox<NewFromCopyChildDialogView>("8461e2b9-fe65-4e39-a0ab-7ea5b1d91b22","","",false, this);
 
            UISalesQuoteCopyAdvances = RPSControlFactory.CreateRPSCheckBox<NewFromCopyChildDialogView>("b98ae567-373e-4cc8-9d55-c9e2757aefb9","","",false, this);
 

        }
        public IRPSOption<NewFromCopyChildDialogView> Customer { get; set; } 
        public IRPSOption<NewFromCopyChildDialogView> PotentialCustomer { get; set; } 
        public IRPSTextBox<NewFromCopyChildDialogView> UINewSalesQuoteFromCopyCode { get; set; } 
        public IRPSComboBox<NewFromCopyChildDialogView> UISalesQuoteCopyIDCustomer { get; set; } 
        public IRPSComboBox<NewFromCopyChildDialogView> UISalesQuoteCopyIDCustomerMiscellaneousSL { get; set; } 
        public IRPSComboBox<NewFromCopyChildDialogView> UISalesQuoteCopyIDPotentialCustomer { get; set; } 
        public IRPSTextBox<NewFromCopyChildDialogView> UISalesQuoteCopyVersion { get; set; } 
        public IRPSTextBox<NewFromCopyChildDialogView> UISalesQuoteCopyDate { get; set; } 
        public IRPSCheckbox<NewFromCopyChildDialogView> UISalesQuoteCopyPendingQuantity { get; set; } 
        public IRPSCheckbox<NewFromCopyChildDialogView> UISalesQuoteCopyUpdateConditions { get; set; } 
        public IRPSCheckbox<NewFromCopyChildDialogView> bRecalcLines { get; set; } 
        public IRPSCheckbox<NewFromCopyChildDialogView> UISalesQuoteCopyDocuments { get; set; } 
        public IRPSCheckbox<NewFromCopyChildDialogView> UISalesQuoteCopyPaymentMethods { get; set; } 
        public IRPSCheckbox<NewFromCopyChildDialogView> UISalesQuoteCopyAdvances { get; set; } 
        public SalesQuoteSL Screen { get; set; }
        public NewFromCopyChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ArticleGenericChildDialogView : View
    {
        public ArticleGenericChildDialogView(SalesQuoteSL screen) : base()
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
        public SalesQuoteSL Screen { get; set; }
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
  
    

}