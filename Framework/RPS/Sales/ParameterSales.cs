    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.ParameterSales
{
    //RPS VERSION 1.0.0.0
    public partial class ParameterSales:Screen
    {
        public ParameterSales():base()
        {
            this.URL = "sales.parametersales";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ParameterFacSLEntityView  = new ParameterFacSLEntityView(this); 
            ParameterFacSLEntityView.InitializeControls(); 
           
        }
      
            public ParameterFacSLEntityView ParameterFacSLEntityView {get; set; } 
    }
            
    public partial class ParameterFacSLEntityView : View
    {
        public ParameterFacSLEntityView(ParameterSales screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ControlBusinessUnit = RPSControlFactory.CreateRPSCheckBox<ParameterFacSLEntityView>("ad004274-026b-4367-a93b-9211a84fe434","","",true, this);
 
            ControlUser = RPSControlFactory.CreateRPSCheckBox<ParameterFacSLEntityView>("20cae7fb-96f8-4427-b48b-b67002b7c3ec","","",true, this);
 
            IDCustomerClassification = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("1f6e4b6a-9de5-4e85-95de-8b491a576dc6","","",false, this);
 
            Cost = RPSControlFactory.CreateRPSEnumComboBox<ParameterFacSLEntityView>("1a4b5677-23d7-43d9-ba19-50c6b5d397cd","","",true, this);
 
            MarginType = RPSControlFactory.CreateRPSEnumComboBox<ParameterFacSLEntityView>("441de740-2339-462c-a86c-64f55dd341f0","","",true, this);
 
            MarginPercent = RPSControlFactory.CreateRPSFormattedTextBox<ParameterFacSLEntityView>("8ebf5768-8276-48b4-8d21-4a41519afb9b","","",true, this);
 
            RiskCalculated = RPSControlFactory.CreateRPSCheckBox<ParameterFacSLEntityView>("68db8c9e-7402-4a98-82d2-cc6c26e5f053","","",true, this);
 
            RiskType = RPSControlFactory.CreateRPSEnumComboBox<ParameterFacSLEntityView>("44b934cc-40fb-4e5c-b3fe-90e250ed3384","","",true, this);
 
            RiskTypeOrder = RPSControlFactory.CreateRPSEnumComboBox<ParameterFacSLEntityView>("8b543e1f-0195-4db5-a515-327b05eb4d44","","",true, this);
 
            InternalCodeOrder = RPSControlFactory.CreateRPSEnumComboBox<ParameterFacSLEntityView>("d3bce484-659a-48c9-ba2d-e96b674a04aa","","",true, this);
 
            InternalCodeCustomer = RPSControlFactory.CreateRPSEnumComboBox<ParameterFacSLEntityView>("a4294759-4e9c-46f3-bc09-008a79d6a833","","",true, this);
 
            InternalCodeArticle = RPSControlFactory.CreateRPSEnumComboBox<ParameterFacSLEntityView>("6924c990-380f-415b-b06d-b460597afb72","","",true, this);
 
            InternalCodeLine = RPSControlFactory.CreateRPSEnumComboBox<ParameterFacSLEntityView>("5dab7858-e126-4a13-81d6-1f830cc72eba","","",true, this);
 
            IDOrderSituationRisk = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("5be8c086-2e07-46ce-b2cb-134d35b78bbc","","",false, this);
 
            KitWarehouse = RPSControlFactory.CreateRPSCheckBox<ParameterFacSLEntityView>("c80e3f3e-0f99-4278-8d45-ddb114cd9eb9","","",true, this);
 
            InputComponent = RPSControlFactory.CreateRPSEnumComboBox<ParameterFacSLEntityView>("c08da313-9ce4-4323-8a79-a2a3b3ab852f","","",true, this);
 
            PercentDelivery = RPSControlFactory.CreateRPSFormattedTextBox<ParameterFacSLEntityView>("1111a4da-3c04-48f8-8b6e-1a5197f95ffb","","",true, this);
 
            ArticleVersionDefault = RPSControlFactory.CreateRPSCheckBox<ParameterFacSLEntityView>("16763225-dae9-41bf-8f59-c08dc93e1013","","",true, this);
 
            IDDocumentCategoryOrder = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("0c537278-221b-4a37-9fd8-e624ee7d8198","","",false, this);
 
            ZippedDocuments = RPSControlFactory.CreateRPSCheckBox<ParameterFacSLEntityView>("9c396650-9f81-456e-bf3e-3f3588f4c9d2","","",true, this);
 
            IDOrderSituation = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("61d5db1e-9d87-4370-97a1-070ba6a7cf0a","","",true, this);
 
            IDOrderSituationManual = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("8b476f45-a7ed-4eff-806a-6d405842d7c0","","",true, this);
 
            IDOrderSituationDirect = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("ed7875a2-26ab-446d-ba77-c759759055df","","",true, this);
 
            PreliminaryDeliveryNote = RPSControlFactory.CreateRPSCheckBox<ParameterFacSLEntityView>("e9f09236-3f2a-4d6e-8b62-518ebabe2252","","",true, this);
 
            IDCodingSerieDeliveryNoteTemp = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("999c3c6b-6641-4946-b147-1b0daee30a7b","","",false, this);
 
            RegisteredInvoice = RPSControlFactory.CreateRPSCheckBox<ParameterFacSLEntityView>("5367eba1-18f3-4afd-96bb-6cb4f4376cab","","",true, this);
 
            FinalizedInvoice = RPSControlFactory.CreateRPSCheckBox<ParameterFacSLEntityView>("803b4b4a-4fda-44de-aeba-8eb5583377d0","","",true, this);
 
            IDDocumentCategoryDeliveryNote = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("bddde5c5-1864-4451-a68d-557e329cb986","","",false, this);
 
            IDDeliveryNoteTypeReplacement = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("11b85d62-5c45-47fa-95a8-b653249b0cea","","",false, this);
 
            IDArticleRoapMap = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("f06826f6-ef03-4529-9937-8a8257d3ea2e","","",false, this);
 
            ManualWeight = RPSControlFactory.CreateRPSCheckBox<ParameterFacSLEntityView>("a22bffd2-c7f0-4e0e-a0d3-2e26ad3afad7","","",true, this);
 
            InvoiceType = RPSControlFactory.CreateRPSEnumComboBox<ParameterFacSLEntityView>("8c9aae61-15dd-45ef-b09f-32327182c523","","",true, this);
 
            IDCodingSerieInvoiceTemp = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("b18a1631-3843-4c57-b498-1d10a018f525","","",false, this);
 
            IDVATFree = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("67f6b6e8-5264-434e-a6a2-21b293f5db9e","","",true, this);
 
            IDVATTypeTransport = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("22ac4026-a28e-4e7e-8864-c7c631fdda31","","",false, this);
 
            IDDocumentCategoryInvoice = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("11ba459b-5717-48d7-8ec3-e7350bc6e2eb","","",false, this);
 
            VATNumberDigitalInvoice = RPSControlFactory.CreateRPSTextBox<ParameterFacSLEntityView>("81ced8fe-f249-4b11-a565-e47419806e40","","",false, this);
 
            SubjectDigitalInvoice = RPSControlFactory.CreateRPSTextBox<ParameterFacSLEntityView>("9c100601-a043-429b-93ac-fa5a39870eef","","",false, this);
 
            IDArticleAutoInvoice = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("a489abb6-192b-40c8-9b38-e3134eea5ab8","","",false, this);
 
            ClosedDate = RPSControlFactory.CreateRPSTextBox<ParameterFacSLEntityView>("aecde4f2-f0b2-4949-a149-55ccf4e8d956","","",false, this);
 
            TypeAdvanceInvoice = RPSControlFactory.CreateRPSEnumComboBox<ParameterFacSLEntityView>("4b98503e-6a87-405b-a91a-deb5536dd8b8","","",true, this);
 
            IDAdvancePaymentVATType = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("0f57988e-9159-4662-93b0-7c90674aa79e","","",false, this);
 
            IDAdvancePaymentMethod = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("3b7ac7b5-08e4-4d3a-9755-b940d9cbb68b","","",false, this);
 
            IDArticleAdvanceStatistic = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("56ffea09-d845-48a8-aa6b-28a5f6b6a2c0","","",false, this);
 
            RetentionAdvances = RPSControlFactory.CreateRPSCheckBox<ParameterFacSLEntityView>("560f86a1-905d-4610-b5e6-1d652ab0047c","","",true, this);
 
            IDCodingSerieRoadMap = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("1309c312-4cb4-431b-85ff-93fea181ef95","","",false, this);
 
            IDCodingSeriePackingList = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("5317930b-b36e-4b25-bac7-4b7dfea2ae22","","",false, this);
 
            IDCodingSerieRappelAgreement = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("34596416-7568-4a76-9614-23979c94cbdc","","",false, this);
 
            IDCodingSerieMerchandiseGift = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("d190a737-6ce7-47be-9f69-ee6a5d55e699","","",false, this);
 
            TextLineGeneralReplace = RPSControlFactory.CreateRPSCheckBox<ParameterFacSLEntityView>("e7b5ea0f-6b50-466d-a9f8-96fa0c2d8ff1","","",true, this);
 
            IDTextLineOfferPre = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("d77060b8-cb69-4d71-8b54-9299909fb77a","","",false, this);
 
            IDTextLineFContractPre = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("986b2fe4-c552-4d6c-9e5c-43a5f7fb8571","","",false, this);
 
            IDTextLineOrderPre = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("35e93b4d-c2dd-45fd-9c96-c988bae588e9","","",false, this);
 
            IDTextLineDNotePre = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("1d360c41-5fa5-4bac-aa5e-8910935f55d8","","",false, this);
 
            IDTextLineInvoicePre = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("f7b5c316-bcac-406f-86ee-51b156a9d7f9","","",false, this);
 
            IDTextLineCreditPre = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("8adea574-8375-415d-aed2-5d34cd078cd6","","",false, this);
 
            IDTextLineAdvancePre = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("bf92ee28-611c-4bcd-bacd-aa5dbd850cd7","","",false, this);
 
            IDTextLineOfferPost = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("05875132-74e4-4f60-b548-ac747957b9d7","","",false, this);
 
            IDTextLineFContractPost = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("cd0bfa6f-e07a-4c57-a35a-5d1fce8443ce","","",false, this);
 
            IDTextLineOrderPost = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("e58d2bc7-fcf6-4f88-8352-d734476ec026","","",false, this);
 
            IDTextLineDNotePost = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("de0d26cd-3891-47d8-a1d1-fc81b32dc6a6","","",false, this);
 
            IDTextLineInvoicePost = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("b6694cbe-503b-4e6a-996e-a6a7c3068a6f","","",false, this);
 
            IDTextLineCreditPost = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("383a73d8-d4e6-47bf-92b5-f583e8d981e3","","",false, this);
 
            IDTextLineAdvancePost = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("07bf83f9-69c9-4404-9fa2-0801ba91684a","","",false, this);
 
            FrameworkContractPrice = RPSControlFactory.CreateRPSCheckBox<ParameterFacSLEntityView>("e425031a-dd04-404f-9627-4a43aabf7e9d","","",true, this);
 
            ReceptionDateComCondition = RPSControlFactory.CreateRPSCheckBox<ParameterFacSLEntityView>("4cdf04ad-5185-44d4-b9b9-bb06a0adbeea","","",true, this);
 
            AllowModifyPrice = RPSControlFactory.CreateRPSCheckBox<ParameterFacSLEntityView>("7d36cd8e-63a5-4f6d-9c53-a811e4b3fa81","","",true, this);
 
            RecalculatePrice = RPSControlFactory.CreateRPSCheckBox<ParameterFacSLEntityView>("205a123b-79e1-4248-ae9c-1ae215748797","","",true, this);
 
            PriceList = RPSControlFactory.CreateRPSEnumComboBox<ParameterFacSLEntityView>("efde3f5e-3d42-4fba-89fa-b9a4a04198a9","","",true, this);
 
            PriceCustomerArticle = RPSControlFactory.CreateRPSEnumComboBox<ParameterFacSLEntityView>("602079a9-db41-489b-b7c2-4462afc24f96","","",true, this);
 
            PriceCustomerArticleGroup = RPSControlFactory.CreateRPSEnumComboBox<ParameterFacSLEntityView>("3a24d741-1498-4c5f-af0d-111debcff343","","",true, this);
 
            IDPriceList = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("c736b010-0b91-4976-87a2-2744f1f18a6b","","",false, this);
 
            PriceSerieList = RPSControlFactory.CreateRPSEnumComboBox<ParameterFacSLEntityView>("84815fbc-e78f-4d06-a175-51c93079c588","","",true, this);
 
            PriceSerie = RPSControlFactory.CreateRPSEnumComboBox<ParameterFacSLEntityView>("226e67c0-95fc-44cc-928d-b52f1fc92bcb","","",true, this);
 
            DiscountGroup = RPSControlFactory.CreateRPSEnumComboBox<ParameterFacSLEntityView>("3ef158b9-350e-4def-9fd7-975b9a64ac90","","",true, this);
 
            DiscountCustomerArticle = RPSControlFactory.CreateRPSEnumComboBox<ParameterFacSLEntityView>("de0713ba-29d8-4210-909b-1f841120ec73","","",true, this);
 
            DiscountCustomerArticleGroup = RPSControlFactory.CreateRPSEnumComboBox<ParameterFacSLEntityView>("6f13c0a7-c904-4473-94b7-0152833d17cf","","",true, this);
 
            CondititionCustomer = RPSControlFactory.CreateRPSEnumComboBox<ParameterFacSLEntityView>("473a5f9a-c53f-4a1e-afb5-75fe63f50bd7","","",true, this);
 
            ConditionCustomerGroup = RPSControlFactory.CreateRPSEnumComboBox<ParameterFacSLEntityView>("e7b65a13-7b3e-491b-a122-4392e42be73f","","",true, this);
 
            ConditionGeneric = RPSControlFactory.CreateRPSEnumComboBox<ParameterFacSLEntityView>("0b6bb0ff-2ff5-4498-b489-e663f4e39d46","","",true, this);
 
            CommissionDefinition = RPSControlFactory.CreateRPSEnumComboBox<ParameterFacSLEntityView>("fcd59865-203a-41af-b0a1-d8f655708725","","",true, this);
 
            CommissionCustomerArticle = RPSControlFactory.CreateRPSEnumComboBox<ParameterFacSLEntityView>("6bde9060-6228-4256-97e7-39f95d2ca1ac","","",true, this);
 
            CommissionCustomeArticlerGroup = RPSControlFactory.CreateRPSEnumComboBox<ParameterFacSLEntityView>("72320ae3-d3db-4b41-a71e-4cbe7acfd08f","","",true, this);
 
            CommissionType = RPSControlFactory.CreateRPSEnumComboBox<ParameterFacSLEntityView>("83ae23c4-0bcf-4063-8309-025bd5d87046","","",true, this);
 
            CommissionOrderCustomer = RPSControlFactory.CreateRPSEnumComboBox<ParameterFacSLEntityView>("073353de-86b4-436f-83d0-19c60c36a152","","",true, this);
 
            CommissionOrderCustomerGroup = RPSControlFactory.CreateRPSEnumComboBox<ParameterFacSLEntityView>("23ab0ded-1c7c-4cdd-9279-424a98d61b34","","",true, this);
 
            CommissionOrderAgent = RPSControlFactory.CreateRPSEnumComboBox<ParameterFacSLEntityView>("4328d03f-55c6-488a-b0fd-e0b67fda5a82","","",true, this);
 
            CommissionOrderAgentGroup = RPSControlFactory.CreateRPSEnumComboBox<ParameterFacSLEntityView>("dbe8f9d1-d5c9-466c-b074-d2fc32628d90","","",true, this);
 
            CommissionOrderAgentClassification = RPSControlFactory.CreateRPSEnumComboBox<ParameterFacSLEntityView>("c0cba601-a17f-4412-ae77-3ff3899c1193","","",true, this);
 
            PromotionCustomer = RPSControlFactory.CreateRPSEnumComboBox<ParameterFacSLEntityView>("4b8ac7db-0b6c-4b16-8d8e-74f4b34bf5e5","","",true, this);
 
            PromotionCustomerGroup = RPSControlFactory.CreateRPSEnumComboBox<ParameterFacSLEntityView>("4554204d-f643-4fae-903e-496e838f88c6","","",true, this);
 
            PromotionGeneric = RPSControlFactory.CreateRPSEnumComboBox<ParameterFacSLEntityView>("88121800-5156-4e99-9f66-e2cc956114d2","","",true, this);
 
            IDFrameworkCStatusInitial = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("4382ba90-1386-4199-9d56-89586db556a9","","",false, this);
 
            IDFrameworkCStatusOffer = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("64103d9d-a20f-44f0-b20f-b90e350e9868","","",false, this);
 
            DocumentType = RPSControlFactory.CreateRPSEnumComboBox<ParameterFacSLEntityView>("9e1f3c38-a296-4a32-955f-43c50be75e8b","","",true, this);
 
            IDDeliveryNoteTypeWithMovementMAN = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("81ab3b4b-3f8d-4cf4-a14c-25a06e094342","","",false, this);
 
            IDDeliveryNoteTypeWithoutMovementMAN = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("441463c8-c65e-4055-8f49-e8c072dc19e9","","",false, this);
 
            FinalizedMaintenanceOrder = RPSControlFactory.CreateRPSCheckBox<ParameterFacSLEntityView>("94916d73-fc99-49e5-86e3-2d1b796262fa","","",true, this);
 
            IDCodingSerieInvoiceMOrder = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("057741d6-e2c5-441f-9ae3-4b9e09f2c5fc","","",false, this);
 
            IDInvoiceTypeGroupMOrder = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("6893e386-f7d7-4881-a968-cb3462ac7f80","","",false, this);
 
            DocumentTypeManContract = RPSControlFactory.CreateRPSEnumComboBox<ParameterFacSLEntityView>("8fca8b89-4ca0-4775-ab5c-84e7cba95d91","","",true, this);
 
            IDDeliveyNoteTypeWithoutMovContractMAN = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("5d299a81-66c9-4488-832c-91e043e469dd","","",false, this);
 
            FinalizedMaintenanceContract = RPSControlFactory.CreateRPSCheckBox<ParameterFacSLEntityView>("04804252-eefa-45f2-aa41-bb911874d881","","",true, this);
 
            IDCodingSerieInvoiceMContract = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("ab55e67a-11cc-4b63-953b-257ac50371d3","","",false, this);
 
            IDInvoiceTypeGroupMContract = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("093b6961-f40d-4313-9c7f-be712da6a07d","","",false, this);
 
            FinalizedProject = RPSControlFactory.CreateRPSCheckBox<ParameterFacSLEntityView>("e6ae3c1e-e6b7-4553-b546-1342535dd34e","","",true, this);
 
            IDDeliveryNoteTypePacking = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("61847f0c-8489-4ac9-a465-448821bdc337","","",false, this);
 
            FinalizedPurchaseRappel = RPSControlFactory.CreateRPSCheckBox<ParameterFacSLEntityView>("54586205-5bc9-4fb0-be49-d1f751d3943c","","",true, this);
 
            IDCodingSerieAddress = RPSControlFactory.CreateRPSComboBox<ParameterFacSLEntityView>("c740285d-d099-4f6e-97d2-8071b2700689","","",false, this);
 
            AutoAddressCustomer = RPSControlFactory.CreateRPSCheckBox<ParameterFacSLEntityView>("2dc03524-2790-4d66-95fc-5d519a64b6c9","","",true, this);
 
            AutoAddressPotCustomer = RPSControlFactory.CreateRPSCheckBox<ParameterFacSLEntityView>("a6640049-2fdd-4baf-a70c-67076e8eb83a","","",true, this);
 
            AutoAddressSupplier = RPSControlFactory.CreateRPSCheckBox<ParameterFacSLEntityView>("2e8a1385-b5a8-4639-b0dd-7a0b64f32874","","",true, this);
 
            GeneralDataSection = RPSControlFactory.CreateRPSSection<ParameterFacSLEntityView>( "","ul li[rpsid='8b3f60c9-79f0-450e-afd9-0167c812c9fb']","",this);
 
            ConditionCommercialSection = RPSControlFactory.CreateRPSSection<ParameterFacSLEntityView>( "","ul li[rpsid='c405bbf3-8f96-4d80-9299-b3f9ac8ba938']","",this);
 
            IntegrationServicesSection = RPSControlFactory.CreateRPSSection<ParameterFacSLEntityView>( "","ul li[rpsid='9531cbbd-be79-4aa3-bf9e-b55f1d5b2e6e']","",this);
 
            DPSAddressesSection = RPSControlFactory.CreateRPSSection<ParameterFacSLEntityView>( "","ul li[rpsid='06d2b5ca-005c-40a7-80f4-949d2ea4eb9a']","",this);
 

        }
        public IRPSCheckbox<ParameterFacSLEntityView> ControlBusinessUnit { get; set; } 
        public IRPSCheckbox<ParameterFacSLEntityView> ControlUser { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDCustomerClassification { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> Cost { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> MarginType { get; set; } 
        public IRPSTextBox<ParameterFacSLEntityView> MarginPercent { get; set; } 
        public IRPSCheckbox<ParameterFacSLEntityView> RiskCalculated { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> RiskType { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> RiskTypeOrder { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> InternalCodeOrder { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> InternalCodeCustomer { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> InternalCodeArticle { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> InternalCodeLine { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDOrderSituationRisk { get; set; } 
        public IRPSCheckbox<ParameterFacSLEntityView> KitWarehouse { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> InputComponent { get; set; } 
        public IRPSTextBox<ParameterFacSLEntityView> PercentDelivery { get; set; } 
        public IRPSCheckbox<ParameterFacSLEntityView> ArticleVersionDefault { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDDocumentCategoryOrder { get; set; } 
        public IRPSCheckbox<ParameterFacSLEntityView> ZippedDocuments { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDOrderSituation { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDOrderSituationManual { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDOrderSituationDirect { get; set; } 
        public IRPSCheckbox<ParameterFacSLEntityView> PreliminaryDeliveryNote { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDCodingSerieDeliveryNoteTemp { get; set; } 
        public IRPSCheckbox<ParameterFacSLEntityView> RegisteredInvoice { get; set; } 
        public IRPSCheckbox<ParameterFacSLEntityView> FinalizedInvoice { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDDocumentCategoryDeliveryNote { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDDeliveryNoteTypeReplacement { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDArticleRoapMap { get; set; } 
        public IRPSCheckbox<ParameterFacSLEntityView> ManualWeight { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> InvoiceType { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDCodingSerieInvoiceTemp { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDVATFree { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDVATTypeTransport { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDDocumentCategoryInvoice { get; set; } 
        public IRPSTextBox<ParameterFacSLEntityView> VATNumberDigitalInvoice { get; set; } 
        public IRPSTextBox<ParameterFacSLEntityView> SubjectDigitalInvoice { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDArticleAutoInvoice { get; set; } 
        public IRPSTextBox<ParameterFacSLEntityView> ClosedDate { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> TypeAdvanceInvoice { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDAdvancePaymentVATType { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDAdvancePaymentMethod { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDArticleAdvanceStatistic { get; set; } 
        public IRPSCheckbox<ParameterFacSLEntityView> RetentionAdvances { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDCodingSerieRoadMap { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDCodingSeriePackingList { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDCodingSerieRappelAgreement { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDCodingSerieMerchandiseGift { get; set; } 
        public IRPSCheckbox<ParameterFacSLEntityView> TextLineGeneralReplace { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDTextLineOfferPre { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDTextLineFContractPre { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDTextLineOrderPre { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDTextLineDNotePre { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDTextLineInvoicePre { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDTextLineCreditPre { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDTextLineAdvancePre { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDTextLineOfferPost { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDTextLineFContractPost { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDTextLineOrderPost { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDTextLineDNotePost { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDTextLineInvoicePost { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDTextLineCreditPost { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDTextLineAdvancePost { get; set; } 
        public IRPSCheckbox<ParameterFacSLEntityView> FrameworkContractPrice { get; set; } 
        public IRPSCheckbox<ParameterFacSLEntityView> ReceptionDateComCondition { get; set; } 
        public IRPSCheckbox<ParameterFacSLEntityView> AllowModifyPrice { get; set; } 
        public IRPSCheckbox<ParameterFacSLEntityView> RecalculatePrice { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> PriceList { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> PriceCustomerArticle { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> PriceCustomerArticleGroup { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDPriceList { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> PriceSerieList { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> PriceSerie { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> DiscountGroup { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> DiscountCustomerArticle { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> DiscountCustomerArticleGroup { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> CondititionCustomer { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> ConditionCustomerGroup { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> ConditionGeneric { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> CommissionDefinition { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> CommissionCustomerArticle { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> CommissionCustomeArticlerGroup { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> CommissionType { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> CommissionOrderCustomer { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> CommissionOrderCustomerGroup { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> CommissionOrderAgent { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> CommissionOrderAgentGroup { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> CommissionOrderAgentClassification { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> PromotionCustomer { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> PromotionCustomerGroup { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> PromotionGeneric { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDFrameworkCStatusInitial { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDFrameworkCStatusOffer { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> DocumentType { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDDeliveryNoteTypeWithMovementMAN { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDDeliveryNoteTypeWithoutMovementMAN { get; set; } 
        public IRPSCheckbox<ParameterFacSLEntityView> FinalizedMaintenanceOrder { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDCodingSerieInvoiceMOrder { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDInvoiceTypeGroupMOrder { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> DocumentTypeManContract { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDDeliveyNoteTypeWithoutMovContractMAN { get; set; } 
        public IRPSCheckbox<ParameterFacSLEntityView> FinalizedMaintenanceContract { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDCodingSerieInvoiceMContract { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDInvoiceTypeGroupMContract { get; set; } 
        public IRPSCheckbox<ParameterFacSLEntityView> FinalizedProject { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDDeliveryNoteTypePacking { get; set; } 
        public IRPSCheckbox<ParameterFacSLEntityView> FinalizedPurchaseRappel { get; set; } 
        public IRPSComboBox<ParameterFacSLEntityView> IDCodingSerieAddress { get; set; } 
        public IRPSCheckbox<ParameterFacSLEntityView> AutoAddressCustomer { get; set; } 
        public IRPSCheckbox<ParameterFacSLEntityView> AutoAddressPotCustomer { get; set; } 
        public IRPSCheckbox<ParameterFacSLEntityView> AutoAddressSupplier { get; set; } 
        public IRPSSection<ParameterFacSLEntityView> GeneralDataSection { get; set; } 
        public IRPSSection<ParameterFacSLEntityView> ConditionCommercialSection { get; set; } 
        public IRPSSection<ParameterFacSLEntityView> IntegrationServicesSection { get; set; } 
        public IRPSSection<ParameterFacSLEntityView> DPSAddressesSection { get; set; } 
        public ParameterSales Screen { get; set; }
        public ParameterFacSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}