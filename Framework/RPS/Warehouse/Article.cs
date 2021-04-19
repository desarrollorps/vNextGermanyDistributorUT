    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Warehouse.Article
{
    //RPS VERSION 1.0.0.0
    public partial class Article:Screen
    {
        public Article():base()
        {
            this.URL = "warehouse.article";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CollectionView  = new CollectionView(this); 
            EntityView  = new EntityView(this); 
            ArticleFeatureView  = new ArticleFeatureView(this); 
            ArticleByLangView  = new ArticleByLangView(this); 
            ArticleBarCodeView  = new ArticleBarCodeView(this); 
            ArticleDetailView  = new ArticleDetailView(this); 
            ArticleConvertMeasureUnitView  = new ArticleConvertMeasureUnitView(this); 
            RecodeArticleDialogChildDialogView  = new RecodeArticleDialogChildDialogView(this); 
            ArticleAlternativePurchaseView  = new ArticleAlternativePurchaseView(this); 
            ArticleAlternativeSalesSLView  = new ArticleAlternativeSalesSLView(this); 
            ArticleAlternativeManufacturingView  = new ArticleAlternativeManufacturingView(this); 
            ArticleAlternativeMaintenanceView  = new ArticleAlternativeMaintenanceView(this); 
            UpdateSiteWarehouseArticleDialogView  = new UpdateSiteWarehouseArticleDialogView(this); 
            FormulaValidatorView  = new FormulaValidatorView(this); 
            CollectionView.InitializeControls(); 
            EntityView.InitializeControls(); 
            ArticleFeatureView.InitializeControls(); 
            ArticleByLangView.InitializeControls(); 
            ArticleBarCodeView.InitializeControls(); 
            ArticleDetailView.InitializeControls(); 
            ArticleConvertMeasureUnitView.InitializeControls(); 
            RecodeArticleDialogChildDialogView.InitializeControls(); 
            ArticleAlternativePurchaseView.InitializeControls(); 
            ArticleAlternativeSalesSLView.InitializeControls(); 
            ArticleAlternativeManufacturingView.InitializeControls(); 
            ArticleAlternativeMaintenanceView.InitializeControls(); 
            UpdateSiteWarehouseArticleDialogView.InitializeControls(); 
            FormulaValidatorView.InitializeControls(); 
           
        }
      
            public CollectionView CollectionView {get; set; } 
            public EntityView EntityView {get; set; } 
            public ArticleFeatureView ArticleFeatureView {get; set; } 
            public ArticleByLangView ArticleByLangView {get; set; } 
            public ArticleBarCodeView ArticleBarCodeView {get; set; } 
            public ArticleDetailView ArticleDetailView {get; set; } 
            public ArticleConvertMeasureUnitView ArticleConvertMeasureUnitView {get; set; } 
            public RecodeArticleDialogChildDialogView RecodeArticleDialogChildDialogView {get; set; } 
            public ArticleAlternativePurchaseView ArticleAlternativePurchaseView {get; set; } 
            public ArticleAlternativeSalesSLView ArticleAlternativeSalesSLView {get; set; } 
            public ArticleAlternativeManufacturingView ArticleAlternativeManufacturingView {get; set; } 
            public ArticleAlternativeMaintenanceView ArticleAlternativeMaintenanceView {get; set; } 
            public UpdateSiteWarehouseArticleDialogView UpdateSiteWarehouseArticleDialogView {get; set; } 
            public FormulaValidatorView FormulaValidatorView {get; set; } 
    }
            
    public partial class CollectionView : View
    {
        public CollectionView(Article screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CollectionView,EntityView>( this,Screen.EntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "5acfc217-0f25-4d5b-ba15-d43e88825d0b",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CollectionView,EntityView>( params_MainConsult,this,Screen.EntityView);
 

        }
        public IRPSButton<CollectionView,EntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CollectionView,EntityView> MainConsult { get; set; } 
        public Article Screen { get; set; }
        public CollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class EntityView : View
    {
        public EntityView(Article screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<EntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<EntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<EntityView,CollectionView>( this,Screen.CollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<EntityView,CollectionView>( this,Screen.CollectionView);
 
            CodArticle = RPSControlFactory.CreateRPSTextBox<EntityView>("d22e2fb8-e743-4dc0-b770-c9818c2a8aeb","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<EntityView>("c2d7224b-9621-48b0-906b-7014d81f274b","","",false, this);
 
            IDArticleClassification = RPSControlFactory.CreateRPSComboBox<EntityView>("731c445d-be00-4d80-b6e5-bfc50ffd8449","","",false, this);
 
            IDProductLine = RPSControlFactory.CreateRPSComboBox<EntityView>("fe5436da-709d-4325-b34b-66651539fa86","","",false, this);
 
            IDProductFamily = RPSControlFactory.CreateRPSComboBox<EntityView>("70abd57c-c4b6-4069-a2a2-baa2fa017036","","",false, this);
 
            IDProductSubFamily = RPSControlFactory.CreateRPSComboBox<EntityView>("cab36a5f-8788-4a83-bbd5-26684f29c61b","","",false, this);
 
            IDAttribute1 = RPSControlFactory.CreateRPSComboBox<EntityView>("aa62c881-9c76-4894-8bf0-678376335960","","",false, this);
 
            IDAttribute2 = RPSControlFactory.CreateRPSComboBox<EntityView>("ad663a7b-ef12-4a74-9eca-8467fa42dded","","",false, this);
 
            IDAttribute3 = RPSControlFactory.CreateRPSComboBox<EntityView>("cace26c6-df4a-4d53-b910-86f267f6fb65","","",false, this);
 
            InactiveDate = RPSControlFactory.CreateRPSTextBox<EntityView>("824c0842-574f-4ad0-8a90-0e61a30cbddd","","",false, this);
 
            IDAttributeValue1 = RPSControlFactory.CreateRPSComboBox<EntityView>("0c15a2da-c2c6-465e-8f7a-45aead133df6","","",false, this);
 
            IDAttributeValue2 = RPSControlFactory.CreateRPSComboBox<EntityView>("94a9f4a1-f8bc-4020-a648-b0146ba49987","","",false, this);
 
            IDAttributeValue3 = RPSControlFactory.CreateRPSComboBox<EntityView>("bc141284-589c-4aa1-9b0e-701554ebddd1","","",false, this);
 
            IDArticleGeneric = RPSControlFactory.CreateRPSComboBox<EntityView>("c8ca3d02-acfc-494b-9fd6-0475e542125e","","",false, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<EntityView>("4aff022a-01c7-4829-9baf-0ccd2a9aadc5","","",true, this);
 
            ValuationCostType = RPSControlFactory.CreateRPSEnumComboBox<EntityView>("26e67007-98ac-4879-aef0-06ecca01508c","","",true, this);
 
            Dimension = RPSControlFactory.CreateRPSEnumComboBox<EntityView>("38922ea9-7b75-45e1-a444-601b0e90daea","","",true, this);
 
            IDVATType = RPSControlFactory.CreateRPSComboBox<EntityView>("a19182ff-62fa-4b9e-a348-86715d4386da","","",true, this);
 
            NetWeight = RPSControlFactory.CreateRPSFormattedTextBox<EntityView>("d4e1f29b-7669-4bc8-a3c9-d6c570f70e9e","","",true, this);
 
            GrossWeight = RPSControlFactory.CreateRPSFormattedTextBox<EntityView>("950e64f7-f4eb-45fd-aae5-0e527460bfa3","","",true, this);
 
            CodArticlePrevious = RPSControlFactory.CreateRPSTextBox<EntityView>("a5812c59-8bf6-485e-9f72-4d862985a0d2","","",false, this);
 
            MatchCode = RPSControlFactory.CreateRPSTextBox<EntityView>("0b8add81-d13a-41d5-8f15-8df4d0ef5e09","","",false, this);
 
            PlanNumber = RPSControlFactory.CreateRPSTextBox<EntityView>("c0eb7e23-3442-44de-a443-e1111775d505","","",false, this);
 
            IDArticleAccType = RPSControlFactory.CreateRPSComboBox<EntityView>("50109d6e-97ef-43e2-ac81-bfcdd012a7c6","","",false, this);
 
            InvestmentExpense = RPSControlFactory.CreateRPSEnumComboBox<EntityView>("ba6af6c0-1e24-45c8-9778-a379b71ceee2","","",true, this);
 
            StatisticsCode = RPSControlFactory.CreateRPSTextBox<EntityView>("0ef467c0-7f15-4e39-871f-444ff2a94a84","","",false, this);
 
            CodCountryOfOrigin = RPSControlFactory.CreateRPSComboBox<EntityView>("62fafff3-a57d-4c31-993f-854466cadc27","","",false, this);
 
            SupplemetUnit = RPSControlFactory.CreateRPSCheckBox<EntityView>("efb0fb77-544b-4651-8e00-f823b089babd","","",true, this);
 
            IDUnitSupplement = RPSControlFactory.CreateRPSComboBox<EntityView>("abaf2b1a-0f38-47d8-8e86-882a8e7b996e","","",false, this);
 
            IDImportDocumentType = RPSControlFactory.CreateRPSComboBox<EntityView>("e3d7045a-1c0f-4318-a8fa-df76920048de","","",false, this);
 
            IDImportTariffType = RPSControlFactory.CreateRPSComboBox<EntityView>("876cdba3-0885-4626-89e0-46c81991cba7","","",false, this);
 
            QuantityFormula = RPSControlFactory.CreateRPSTextBox<EntityView>("f266058c-2ec7-4e76-ac03-02defae5b6b0","","",false, this);
 
            FormulaValidatorNavigationCommand = RPSControlFactory.CreateRPSButtonToView<EntityView,FormulaValidatorView>("4d2a4ff5-15c8-4493-93b2-b2a37b9cc7fd","","", this,Screen.FormulaValidatorView);
 
            Length = RPSControlFactory.CreateRPSFormattedTextBox<EntityView>("8fecc1de-6496-4bba-90bf-0faf062467fa","","",true, this);
 
            Height = RPSControlFactory.CreateRPSFormattedTextBox<EntityView>("abc5cf18-6ad5-4ed4-82e3-cef65a242301","","",true, this);
 
            Width = RPSControlFactory.CreateRPSFormattedTextBox<EntityView>("c562ba61-a6e4-4e9f-94fb-52f5a54f6d0a","","",true, this);
 
            TypeAssembly = RPSControlFactory.CreateRPSEnumComboBox<EntityView>("88f7a296-98b2-4d75-a857-41ed64e8f887","","",true, this);
 
            IDUnitQuantitySales = RPSControlFactory.CreateRPSComboBox<EntityView>("b0a96680-8b3e-459b-a720-1b590429e966","","",true, this);
 
            IDUnitPriceSales = RPSControlFactory.CreateRPSComboBox<EntityView>("4bc9ac02-590f-403a-a0cf-7f522f750b72","","",true, this);
 
            IDUnitHomogeneousSales = RPSControlFactory.CreateRPSComboBox<EntityView>("6fb3c214-184c-4769-8d29-b874fc9a555b","","",true, this);
 
            TaxTypeSales = RPSControlFactory.CreateRPSEnumComboBox<EntityView>("3b3fb718-cec7-43a9-a5c6-21490b7443dd","","",true, this);
 
            IDTaxGroupSales = RPSControlFactory.CreateRPSComboBox<EntityView>("6925b0cd-28b1-459e-8d19-257e9d96da47","","",false, this);
 
            SalesLot = RPSControlFactory.CreateRPSFormattedTextBox<EntityView>("82754859-e421-4095-bf75-74dd60087d0a","","",true, this);
 
            MinimumSalesLot = RPSControlFactory.CreateRPSFormattedTextBox<EntityView>("855f7054-0b0e-4748-85ee-7feee63803c8","","",true, this);
 
            SalesKit = RPSControlFactory.CreateRPSCheckBox<EntityView>("45b36c7b-7954-4ac0-8d56-8b1bd3acdb6d","","",true, this);
 
            BlockedSales = RPSControlFactory.CreateRPSCheckBox<EntityView>("7968fb40-b751-4351-a350-c73b2c655844","","",true, this);
 
            GeneratePurchase = RPSControlFactory.CreateRPSCheckBox<EntityView>("b893ae0a-7ac1-468e-872f-745c65c074cc","","",true, this);
 
            SalesGuarantee = RPSControlFactory.CreateRPSCheckBox<EntityView>("33d6362d-f844-4d49-93e7-c5cbe4dd3cd1","","",true, this);
 
            SalesGuaranteePeriod = RPSControlFactory.CreateRPSFormattedTextBox<EntityView>("5108676e-0001-43c2-a552-afde85658318","","",true, this);
 
            ApplySalesDiscount = RPSControlFactory.CreateRPSCheckBox<EntityView>("99aad858-4745-4a4f-b5d4-08d27a2de99b","","",true, this);
 
            ApplySalesDiscountPP = RPSControlFactory.CreateRPSCheckBox<EntityView>("7babd8bc-b360-4fdb-a7f9-67462dbfff42","","",true, this);
 
            ApplySalesFinancialSurcharge = RPSControlFactory.CreateRPSCheckBox<EntityView>("930ec73e-6c89-42f0-bff2-6a6d9f2cbc7d","","",true, this);
 
            ApplySalesRetention = RPSControlFactory.CreateRPSCheckBox<EntityView>("80deba0a-1f8d-48f6-9a2b-a17403f4d12f","","",true, this);
 
            ApplyCommission = RPSControlFactory.CreateRPSCheckBox<EntityView>("2d7070a0-c446-46d7-9374-81a2bb6ffacb","","",true, this);
 
            CustomerReferenceControl = RPSControlFactory.CreateRPSCheckBox<EntityView>("e0d32760-7add-4770-8bd6-311c19370bdb","","",true, this);
 
            IDUnitQuantityPurchase = RPSControlFactory.CreateRPSComboBox<EntityView>("272c0d18-b6c9-467a-9666-0dc0c5b0c5af","","",true, this);
 
            IDUnitPricePurchase = RPSControlFactory.CreateRPSComboBox<EntityView>("b2ef0dc4-74ff-4742-841d-6eabe3075476","","",true, this);
 
            IDUnitHomogeneousPurchase = RPSControlFactory.CreateRPSComboBox<EntityView>("fdcadb16-94fb-4c89-b105-027e8f4063fe","","",true, this);
 
            PurchaseLot = RPSControlFactory.CreateRPSFormattedTextBox<EntityView>("4bcb7982-1bf0-49be-bd6f-b82631be7756","","",true, this);
 
            LaunchLot = RPSControlFactory.CreateRPSFormattedTextBox<EntityView>("474d0445-ae01-40dc-bea6-7efc75b58b9c","","",true, this);
 
            TaxTypePurchase = RPSControlFactory.CreateRPSEnumComboBox<EntityView>("734d53f2-c3a0-4931-9c7f-bb3cb513c5f0","","",true, this);
 
            IDTaxGroupPurchase = RPSControlFactory.CreateRPSComboBox<EntityView>("00552839-d0c9-41ed-8083-5e0459336944","","",false, this);
 
            IDSupplierGroupHeader = RPSControlFactory.CreateRPSComboBox<EntityView>("7aac39bd-f136-4b28-b5b7-3b2267099a5d","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<EntityView>("ba72f2e4-d75e-490b-a976-a3ec8486fc4d","","",false, this);
 
            IDSupplierGroup = RPSControlFactory.CreateRPSComboBox<EntityView>("bc26c868-47d3-4b1e-883c-ae5caad4157f","","",false, this);
 
            SupplierReferenceControl = RPSControlFactory.CreateRPSCheckBox<EntityView>("02c67baf-a3e3-4c32-832d-d17d1fd546cf","","",true, this);
 
            DeliveryDays = RPSControlFactory.CreateRPSFormattedTextBox<EntityView>("4016aae2-ea11-40c5-869b-d94aba612a11","","",true, this);
 
            ReturnPercent = RPSControlFactory.CreateRPSFormattedTextBox<EntityView>("9ce37ea8-2ef0-4a35-ab2a-887a4c2c8fa9","","",true, this);
 
            PurchasePrice = RPSControlFactory.CreateRPSFormattedTextBox<EntityView>("d6990f2a-7118-43c5-a796-15904ed1f371","","",true, this);
 
            AveragePrice = RPSControlFactory.CreateRPSFormattedTextBox<EntityView>("459cfe82-9138-4323-8131-fc89e8010c92","","",true, this);
 
            PurchaseDate = RPSControlFactory.CreateRPSTextBox<EntityView>("e6a2a4a5-5948-4def-a73d-004844127d36","","",false, this);
 
            PurchaseKit = RPSControlFactory.CreateRPSCheckBox<EntityView>("7f9e9ba5-84a7-4722-b6aa-51c58d740ecd","","",true, this);
 
            BlockedPurchase = RPSControlFactory.CreateRPSCheckBox<EntityView>("033444fc-c171-490a-bbf1-13734bd0bee8","","",true, this);
 
            ApplyPurchaseDiscount = RPSControlFactory.CreateRPSCheckBox<EntityView>("e71e848d-be68-442a-9a37-e512ef6dd624","","",true, this);
 
            ApplyPurchaseDiscountPP = RPSControlFactory.CreateRPSCheckBox<EntityView>("0da8e29c-0ebf-4e3c-9a8a-2c168dea9801","","",true, this);
 
            ApplyPurchaseFinancialSurcharge = RPSControlFactory.CreateRPSCheckBox<EntityView>("402d2f40-2d9b-43bb-8714-352bce6ca2c6","","",true, this);
 
            ApplyPurchaseRetention = RPSControlFactory.CreateRPSCheckBox<EntityView>("e586c656-99f7-4293-b689-02f28dba5f33","","",true, this);
 
            DocumentParent = RPSControlFactory.CreateRPSCheckBox<EntityView>("21a5f8ad-9f1a-4d4c-af25-25fb6b886553","","",true, this);
 
            DocumentMaterials = RPSControlFactory.CreateRPSCheckBox<EntityView>("ac2dd148-5227-4104-9d15-2e6dbea88ab2","","",true, this);
 
            QualityOnReception = RPSControlFactory.CreateRPSEnumComboBox<EntityView>("feac9632-e485-4ca5-ab6a-085d1da48066","","",true, this);
 
            Quality = RPSControlFactory.CreateRPSOption<EntityView>( "06bef9d2-7126-4973-8aba-eefe994c3cd8","","",this);
 
            Main = RPSControlFactory.CreateRPSOption<EntityView>( "335b65c7-dd16-4074-9c70-439d49c2c18a","","",this);
 
            IDQualityPartType = RPSControlFactory.CreateRPSComboBox<EntityView>("4daaecd9-d3b0-448a-a85a-9bfa128642a3","","",false, this);
 
            IDUnitQuantityWarehouse = RPSControlFactory.CreateRPSComboBox<EntityView>("e7765e88-0baf-4bbf-95a2-cbc7525e21c8","","",true, this);
 
            IDUnitPriceWarehouse = RPSControlFactory.CreateRPSComboBox<EntityView>("b4c3c664-4fde-4a74-a997-c7c55ae47be0","","",true, this);
 
            SecondUnit = RPSControlFactory.CreateRPSCheckBox<EntityView>("43fed008-1ec9-454f-9b1a-8a8640a2e881","","",true, this);
 
            SecondUnitFixed = RPSControlFactory.CreateRPSCheckBox<EntityView>("e11206ba-8f2b-4e1a-b1ed-20ccfffe2ed5","","",true, this);
 
            IDUnitSecondUnit = RPSControlFactory.CreateRPSComboBox<EntityView>("f0a0aff5-41a1-4d03-b9bf-82531c30dccb","","",false, this);
 
            AverageSecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<EntityView>("c7d23354-9fa1-45f0-b58a-1ce8c350700f","","",true, this);
 
            SeriesControl = RPSControlFactory.CreateRPSCheckBox<EntityView>("d98f938e-61c3-4fce-ab3a-bdacdb933f27","","",true, this);
 
            IDCodingSerie = RPSControlFactory.CreateRPSComboBox<EntityView>("71dfdac5-a3e6-47ce-9283-526d4288f5d4","","",false, this);
 
            WholeSeries = RPSControlFactory.CreateRPSCheckBox<EntityView>("b9c69b73-eec4-49ed-8775-938fee37104c","","",true, this);
 
            AverageSecondUnitSerie = RPSControlFactory.CreateRPSCheckBox<EntityView>("aa7cff07-9e01-4f50-b9f7-e7428cb36200","","",true, this);
 
            UnitarianSeries = RPSControlFactory.CreateRPSCheckBox<EntityView>("9294a0ba-b92c-4b8b-8015-1f1f7cd2c3be","","",true, this);
 
            UnitarianSerieOrder = RPSControlFactory.CreateRPSCheckBox<EntityView>("cb06699b-4f9b-4408-8df1-549a65c1f5ce","","",true, this);
 
            ExpiryControl = RPSControlFactory.CreateRPSCheckBox<EntityView>("18da1d30-d08a-4f9f-a46a-ae95b9264fe8","","",true, this);
 
            ExpireDays = RPSControlFactory.CreateRPSFormattedTextBox<EntityView>("43efda3d-351c-4664-baf5-68e1920037f9","","",true, this);
 
            StatusLot = RPSControlFactory.CreateRPSCheckBox<EntityView>("a539a652-001f-4927-b395-005892a6c765","","",true, this);
 
            IDStatusLotGroup = RPSControlFactory.CreateRPSComboBox<EntityView>("bc88fe9c-5ed9-47d7-8f52-fcac15b4cc75","","",false, this);
 
            PotencyControl = RPSControlFactory.CreateRPSCheckBox<EntityView>("20fe9577-0d2d-450c-9dd2-ce93882d6f58","","",true, this);
 
            PotencyDefault = RPSControlFactory.CreateRPSFormattedTextBox<EntityView>("6ba2b424-f214-4343-a1e3-c9d30c572c41","","",true, this);
 
            RotationIndex = RPSControlFactory.CreateRPSFormattedTextBox<EntityView>("2c857638-87d0-4091-a9b8-92c9322cd60a","","",false, this);
 
            StockMin = RPSControlFactory.CreateRPSFormattedTextBox<EntityView>("16d4b703-dece-48a4-a4e1-33c9b2e4caec","","",true, this);
 
            PointOrder = RPSControlFactory.CreateRPSFormattedTextBox<EntityView>("44fa6967-ec87-472a-b44c-2d2173ba8ab5","","",true, this);
 
            ConsumePrevision = RPSControlFactory.CreateRPSFormattedTextBox<EntityView>("2010439e-bb54-46f5-94a1-91b2eee42dcf","","",true, this);
 
            Container = RPSControlFactory.CreateRPSCheckBox<EntityView>("eb3a7bc2-4e34-4113-a5b7-c42dfb94f4d5","","",true, this);
 
            HasContainer = RPSControlFactory.CreateRPSCheckBox<EntityView>("5d7e2afa-cb1e-4a84-81f5-b853dada7d69","","",true, this);
 
            DiscountContainer = RPSControlFactory.CreateRPSCheckBox<EntityView>("81d8d835-8592-4cf8-adfa-aa81435227bf","","",true, this);
 
            IDArticleContainer = RPSControlFactory.CreateRPSComboBox<EntityView>("0c2ab4ee-8d06-48f7-b77b-c96581bd9018","","",false, this);
 
            CostMovement = RPSControlFactory.CreateRPSCheckBox<EntityView>("f6504424-7a9f-4c0a-9ddd-895949264e62","","",true, this);
 
            IDMovementType = RPSControlFactory.CreateRPSComboBox<EntityView>("6749a705-0e4a-4758-99d3-e7e71cae199c","","",false, this);
 
            IDSiteEntry = RPSControlFactory.CreateRPSComboBox<EntityView>("209411eb-d4e9-4174-8fdb-058b3e8300d8","","",false, this);
 
            IDEntryWarehouse = RPSControlFactory.CreateRPSComboBox<EntityView>("098a950a-9d84-45e5-82ee-784651076175","","",false, this);
 
            IDSiteOutput = RPSControlFactory.CreateRPSComboBox<EntityView>("dca709b4-4931-4540-b43b-ecd93b3fdebd","","",false, this);
 
            IDOutputWarehouse = RPSControlFactory.CreateRPSComboBox<EntityView>("8ce4e152-6daf-49cc-aae7-b33e994067f7","","",false, this);
 
            LocationWarehouseControl = RPSControlFactory.CreateRPSCheckBox<EntityView>("a6bccc3a-fb7e-4ef5-a06e-f14cc5227567","","",true, this);
 
            IDEntryLocationWarehouse = RPSControlFactory.CreateRPSComboBox<EntityView>("f0d0bc05-908e-44c8-8e77-eb1503c68023","","",false, this);
 
            IDOutputLocationWarehouse = RPSControlFactory.CreateRPSComboBox<EntityView>("e7ccdfd7-1bbb-4984-bc27-795fe4ed693f","","",false, this);
 
            ProvisionType = RPSControlFactory.CreateRPSEnumComboBox<EntityView>("69ab9af6-fa74-45b5-bd87-bc6c79947905","","",true, this);
 
            IDSiteProvision = RPSControlFactory.CreateRPSComboBox<EntityView>("f8a7a38c-dfff-4dd7-9c02-51eed995932c","","",false, this);
 
            IDWarehouseProvision = RPSControlFactory.CreateRPSComboBox<EntityView>("bf195ad0-fecd-47dc-9b05-aa7ed50fbb50","","",false, this);
 
            PlanningGroup = RPSControlFactory.CreateRPSTextBox<EntityView>("a09195de-52c1-41c9-bd03-be503807a8ee","","",false, this);
 
            ManufactureDate = RPSControlFactory.CreateRPSTextBox<EntityView>("bc65a680-ef28-410a-bfbb-ddbde4fae9b1","","",false, this);
 
            StandardCostLot = RPSControlFactory.CreateRPSFormattedTextBox<EntityView>("c5d348ef-7eb6-4453-90d7-054f1c85a7be","","",true, this);
 
            StandardPrice = RPSControlFactory.CreateRPSFormattedTextBox<EntityView>("4cf7a2a4-3bae-4b55-9cfb-a509a5689108","","",true, this);
 
            ManufacturePrice = RPSControlFactory.CreateRPSFormattedTextBox<EntityView>("f886f2be-5d00-4157-8d73-e63160b49765","","",true, this);
 
            PlanningCategory = RPSControlFactory.CreateRPSTextBox<EntityView>("55c76e23-ed09-429f-b09e-56bcaf9eb6c4","","",false, this);
 
            MinimumManufacturingLot = RPSControlFactory.CreateRPSFormattedTextBox<EntityView>("b6048999-b4cd-4504-ae90-09ef98ed0e0b","","",true, this);
 
            ManufacturingLot = RPSControlFactory.CreateRPSFormattedTextBox<EntityView>("d7ff5335-bcab-4dbc-a710-a84b9f0a0073","","",true, this);
 
            GroupDays = RPSControlFactory.CreateRPSEnumComboBox<EntityView>("bfe92ca0-9ab3-47ac-87e3-371a4f29287a","","",true, this);
 
            GroupDaysNumber = RPSControlFactory.CreateRPSFormattedTextBox<EntityView>("484179cf-b09b-44a7-ada4-4102decfe252","","",true, this);
 
            ManufacturingGroupCode = RPSControlFactory.CreateRPSTextBox<EntityView>("b1220589-f9c8-45f2-9b5f-f0a042eed3fb","","",false, this);
 
            ManufacturingGroupQuantity = RPSControlFactory.CreateRPSFormattedTextBox<EntityView>("9e23153f-7bbc-4349-be83-1626cc622f53","","",true, this);
 
            ConsumePrevisionBehavior = RPSControlFactory.CreateRPSEnumComboBox<EntityView>("1a1668d8-df5b-4947-a44b-c82725d5fbf3","","",true, this);
 
            MRPType = RPSControlFactory.CreateRPSEnumComboBox<EntityView>("c2b46238-8e4d-4c6e-8e40-2a703029f5a4","","",true, this);
 
            MRPPrevisionsOnly = RPSControlFactory.CreateRPSCheckBox<EntityView>("1317304d-6cc3-4e73-916b-27a9544c981e","","",true, this);
 
            BlockedManufacturing = RPSControlFactory.CreateRPSCheckBox<EntityView>("928f35d6-ad00-4cb2-8607-1c968b374c5f","","",true, this);
 
            BatchBalancing = RPSControlFactory.CreateRPSCheckBox<EntityView>("d6b926c3-b6d3-4568-bf76-0d4d0dc5d141","","",true, this);
 
            QuantityBaseFormula = RPSControlFactory.CreateRPSFormattedTextBox<EntityView>("f19be2e1-b71d-4dfe-869c-724c00470ca4","","",true, this);
 
            IDUnitBaseFormula = RPSControlFactory.CreateRPSComboBox<EntityView>("fdb3f62f-4636-4ebb-8a5f-6583d53d2c7f","","",true, this);
 
            MultipleCADLink = RPSControlFactory.CreateRPSCheckBox<EntityView>("c692c453-1fc2-4df2-a270-793b72f4c71e","","",true, this);
 
            ComponentsGroupType = RPSControlFactory.CreateRPSEnumComboBox<EntityView>("b466e52d-aae7-42b6-aa5a-0a771354f91d","","",true, this);
 
            MakeAutomaticOutput = RPSControlFactory.CreateRPSCheckBox<EntityView>("4f64beaa-4ce1-49a4-b119-30698c2d529e","","",true, this);
 
            ImputationCostUpdated = RPSControlFactory.CreateRPSCheckBox<EntityView>("9c2417dd-9441-45b4-919e-a54052e300c5","","",true, this);
 
            ImputationTotalQuantity = RPSControlFactory.CreateRPSCheckBox<EntityView>("2d6798ba-153d-40a2-ba30-f7a4c54c1e4c","","",true, this);
 
            ProjectProvisionType = RPSControlFactory.CreateRPSEnumComboBox<EntityView>("1a556a87-655e-44e6-8b24-202e77b0051a","","",true, this);
 
            LotsReserve = RPSControlFactory.CreateRPSCheckBox<EntityView>("6c5511b3-70d2-4334-9c38-496a35c7c304","","",true, this);
 
            LotsReserveDays = RPSControlFactory.CreateRPSFormattedTextBox<EntityView>("7a314bb1-562e-4d94-ba32-c4d1c4758a63","","",true, this);
 
            LotsOrder = RPSControlFactory.CreateRPSCheckBox<EntityView>("af722326-9277-4c81-8f9a-dad86b27f54c","","",true, this);
 
            LotsOrderDays = RPSControlFactory.CreateRPSFormattedTextBox<EntityView>("2b1a506e-b88f-44f8-9252-713459511393","","",true, this);
 
            IDProductionUnit = RPSControlFactory.CreateRPSComboBox<EntityView>("56d61bbc-78eb-4ea2-b828-8794c417c7a7","","",false, this);
 
            EffortQuantity = RPSControlFactory.CreateRPSFormattedTextBox<EntityView>("ff3b4384-58ea-456d-bd53-5b0559fd5865","","",false, this);
 
            StartingMarginDays = RPSControlFactory.CreateRPSFormattedTextBox<EntityView>("1e84ff21-32b5-420b-8821-167b28681c62","","",false, this);
 
            EndingMarginDays = RPSControlFactory.CreateRPSFormattedTextBox<EntityView>("7240e4fd-31ac-4ddc-8265-7ab28281c8f2","","",false, this);
 
            TechnicalDescription = RPSControlFactory.CreateRPSTextBox<EntityView>("c84da38e-3731-41e3-9153-791a15f842cb","","",false, this);
 
            Notes = RPSControlFactory.CreateRPSTextBox<EntityView>("51742c62-23ce-4acf-9e60-c683b16976fb","","",false, this);
 
            NewArticleFromCopyCommandButton = RPSControlFactory.CreateRPSButton<EntityView>( "7a2382a5-ec9d-4089-81c7-e1c2de3906d7","","",this);
 
            RecodeArticleDialogChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<EntityView,RecodeArticleDialogChildDialogView>("6e85db49-c25f-47b7-9eec-19ed0cfa9590","","", this,Screen.RecodeArticleDialogChildDialogView);
 
            GenerateBarcodeCommandButton = RPSControlFactory.CreateRPSButton<EntityView>( "a5e3eeea-b688-49de-ba2a-ac6eeb7c57eb","","",this);
 
            GenerateDependantsCommandButton = RPSControlFactory.CreateRPSButton<EntityView>( "2d67183f-ab88-4538-b3b6-f2cac55bc7b8","","",this);
 
            UpdateSiteWarehouseArticleNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<EntityView,UpdateSiteWarehouseArticleDialogView>("25afd61b-5897-4e0a-98f0-e6008e3122ce","","", this,Screen.UpdateSiteWarehouseArticleDialogView);
 
            InsertEANCommandButton = RPSControlFactory.CreateRPSButton<EntityView>( "42240770-c891-4bcd-ada3-c49348953fc5","","",this);
 
            CollectionInit params_ArticleFeatures = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c17b005b-d7a5-4c78-9136-ec82290a68d6",CSSSelectorGrid="",XPathGrid=""};
            ArticleFeatures = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleFeaturesCollectionEditor<EntityView,ArticleByLangView>,EntityView,ArticleByLangView>( params_ArticleFeatures,this,Screen.ArticleByLangView);
 
            CollectionInit params_ArticleByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="936dcf16-69f7-4b89-a1a0-dee13e3b11e1",CSSSelectorGrid="",XPathGrid=""};
            ArticleByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleByLangsCollectionEditor<EntityView,ArticleByLangView>,EntityView,ArticleByLangView>( params_ArticleByLangs,this,Screen.ArticleByLangView);
 
            CollectionInit params_ArticleConvertMeasureUnits = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c30b5486-4694-43a5-aa8c-3a8efe317458",CSSSelectorGrid="",XPathGrid=""};
            ArticleConvertMeasureUnits = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleConvertMeasureUnitsCollectionEditor<EntityView,ArticleByLangView>,EntityView,ArticleByLangView>( params_ArticleConvertMeasureUnits,this,Screen.ArticleByLangView);
 
            CollectionInit params_ArticleBarCodes = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="76f6982d-c441-41a0-8da6-8ab3c1a1fc5b",CSSSelectorGrid="",XPathGrid=""};
            ArticleBarCodes = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleBarCodesCollectionEditor<EntityView,ArticleByLangView>,EntityView,ArticleByLangView>( params_ArticleBarCodes,this,Screen.ArticleByLangView);
 
            CollectionInit params_ArticleDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="407492e0-cb38-4f0d-bdac-cb7c63b47355",CSSSelectorGrid="",XPathGrid=""};
            ArticleDetails = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleDetailsCollectionEditor<EntityView,ArticleByLangView>,EntityView,ArticleByLangView>( params_ArticleDetails,this,Screen.ArticleByLangView);
 
            CollectionInit params_ArticleAlternativePurchases = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b163274d-9761-408e-9748-be78fb06c7fa",CSSSelectorGrid="",XPathGrid=""};
            ArticleAlternativePurchases = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleAlternativePurchasesCollectionEditor<EntityView,ArticleByLangView>,EntityView,ArticleByLangView>( params_ArticleAlternativePurchases,this,Screen.ArticleByLangView);
 
            CollectionInit params_ArticleAlternativeSalesSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0e9ed952-fcaf-43ff-a0c1-5567c5a85ae2",CSSSelectorGrid="",XPathGrid=""};
            ArticleAlternativeSalesSLs = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleAlternativeSalesSLsCollectionEditor<EntityView,ArticleByLangView>,EntityView,ArticleByLangView>( params_ArticleAlternativeSalesSLs,this,Screen.ArticleByLangView);
 
            CollectionInit params_ArticleAlternativeMaintenances = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b0a72a41-d68e-41b4-932c-b21b7b77fd52",CSSSelectorGrid="",XPathGrid=""};
            ArticleAlternativeMaintenances = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleAlternativeMaintenancesCollectionEditor<EntityView,ArticleByLangView>,EntityView,ArticleByLangView>( params_ArticleAlternativeMaintenances,this,Screen.ArticleByLangView);
 
            CollectionInit params_ArticleAlternativeManufacturings = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="83c2e335-f3d8-4610-9572-ee1fcff1cc98",CSSSelectorGrid="",XPathGrid=""};
            ArticleAlternativeManufacturings = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleAlternativeManufacturingsCollectionEditor<EntityView,ArticleByLangView>,EntityView,ArticleByLangView>( params_ArticleAlternativeManufacturings,this,Screen.ArticleByLangView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<EntityView>( "","ul li[rpsid='d4044d89-5267-41a9-900d-f024356318f4']","",this);
 
            SecDPS = RPSControlFactory.CreateRPSSection<EntityView>( "","ul li[rpsid='7dd768be-6dcd-4c08-8ed5-8cd03203c190']","",this);
 
            SalesConfiguration = RPSControlFactory.CreateRPSSection<EntityView>( "","ul li[rpsid='b61b5429-bbcc-43db-b5d3-c7d9248e1b5e']","",this);
 
            PurchaseConfiguration = RPSControlFactory.CreateRPSSection<EntityView>( "","ul li[rpsid='4e01ece4-3151-47b5-8b7e-5a33c3070001']","",this);
 
            WarehouseConfiguration = RPSControlFactory.CreateRPSSection<EntityView>( "","ul li[rpsid='3c073348-191a-4ea9-872c-e9c91db7034f']","",this);
 
            ManufacturingConfiguration = RPSControlFactory.CreateRPSSection<EntityView>( "","ul li[rpsid='8a3243e7-e729-4d28-937a-fd76111cdba7']","",this);
 
            Features = RPSControlFactory.CreateRPSSection<EntityView>( "","ul li[rpsid='44ba7a80-359e-4329-9dd5-f624b3507bfc']","",this);
 
            ArticleByLang = RPSControlFactory.CreateRPSSection<EntityView>( "","ul li[rpsid='bbfe145b-b81f-41dd-bc14-27d1788b9285']","",this);
 
            MeasureUnit = RPSControlFactory.CreateRPSSection<EntityView>( "","ul li[rpsid='c18e7f27-23ec-4894-85a8-7df3cb548944']","",this);
 
            BarCodes = RPSControlFactory.CreateRPSSection<EntityView>( "","ul li[rpsid='53eb9079-0797-47dd-a52c-8ae8db446d3e']","",this);
 
            Subsidiary = RPSControlFactory.CreateRPSSection<EntityView>( "","ul li[rpsid='5b32a119-2079-4c24-83c0-d3c25091d66a']","",this);
 
            TechnicalDescription1 = RPSControlFactory.CreateRPSSection<EntityView>( "","ul li[rpsid='f62de397-f9a1-4960-869a-9e0712c0694a']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<EntityView>( "","ul li[rpsid='6fca3546-cbd8-4055-b991-d5945ef4f88d']","",this);
 
            AlternativeArticles = RPSControlFactory.CreateRPSSection<EntityView>( "","ul li[rpsid='1c59dd09-6b58-42ef-b845-167088b717b7']","",this);
 

        }
        public IRPSSaveButton<EntityView> SaveButton { get; set; } 
        public IRPSButton<EntityView> DeleteButton { get; set; } 
        public IRPSButton<EntityView,CollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<EntityView,CollectionView> BackButton { get; set; } 
        public IRPSTextBox<EntityView> CodArticle { get; set; } 
        public IRPSTextBox<EntityView> Description { get; set; } 
        public IRPSComboBox<EntityView> IDArticleClassification { get; set; } 
        public IRPSComboBox<EntityView> IDProductLine { get; set; } 
        public IRPSComboBox<EntityView> IDProductFamily { get; set; } 
        public IRPSComboBox<EntityView> IDProductSubFamily { get; set; } 
        public IRPSComboBox<EntityView> IDAttribute1 { get; set; } 
        public IRPSComboBox<EntityView> IDAttribute2 { get; set; } 
        public IRPSComboBox<EntityView> IDAttribute3 { get; set; } 
        public IRPSTextBox<EntityView> InactiveDate { get; set; } 
        public IRPSComboBox<EntityView> IDAttributeValue1 { get; set; } 
        public IRPSComboBox<EntityView> IDAttributeValue2 { get; set; } 
        public IRPSComboBox<EntityView> IDAttributeValue3 { get; set; } 
        public IRPSComboBox<EntityView> IDArticleGeneric { get; set; } 
        public IRPSComboBox<EntityView> Type { get; set; } 
        public IRPSComboBox<EntityView> ValuationCostType { get; set; } 
        public IRPSComboBox<EntityView> Dimension { get; set; } 
        public IRPSComboBox<EntityView> IDVATType { get; set; } 
        public IRPSTextBox<EntityView> NetWeight { get; set; } 
        public IRPSTextBox<EntityView> GrossWeight { get; set; } 
        public IRPSTextBox<EntityView> CodArticlePrevious { get; set; } 
        public IRPSTextBox<EntityView> MatchCode { get; set; } 
        public IRPSTextBox<EntityView> PlanNumber { get; set; } 
        public IRPSComboBox<EntityView> IDArticleAccType { get; set; } 
        public IRPSComboBox<EntityView> InvestmentExpense { get; set; } 
        public IRPSTextBox<EntityView> StatisticsCode { get; set; } 
        public IRPSComboBox<EntityView> CodCountryOfOrigin { get; set; } 
        public IRPSCheckbox<EntityView> SupplemetUnit { get; set; } 
        public IRPSComboBox<EntityView> IDUnitSupplement { get; set; } 
        public IRPSComboBox<EntityView> IDImportDocumentType { get; set; } 
        public IRPSComboBox<EntityView> IDImportTariffType { get; set; } 
        public IRPSTextBox<EntityView> QuantityFormula { get; set; } 
        public IRPSButton<EntityView,FormulaValidatorView> FormulaValidatorNavigationCommand { get; set; } 
        public IRPSTextBox<EntityView> Length { get; set; } 
        public IRPSTextBox<EntityView> Height { get; set; } 
        public IRPSTextBox<EntityView> Width { get; set; } 
        public IRPSComboBox<EntityView> TypeAssembly { get; set; } 
        public IRPSComboBox<EntityView> IDUnitQuantitySales { get; set; } 
        public IRPSComboBox<EntityView> IDUnitPriceSales { get; set; } 
        public IRPSComboBox<EntityView> IDUnitHomogeneousSales { get; set; } 
        public IRPSComboBox<EntityView> TaxTypeSales { get; set; } 
        public IRPSComboBox<EntityView> IDTaxGroupSales { get; set; } 
        public IRPSTextBox<EntityView> SalesLot { get; set; } 
        public IRPSTextBox<EntityView> MinimumSalesLot { get; set; } 
        public IRPSCheckbox<EntityView> SalesKit { get; set; } 
        public IRPSCheckbox<EntityView> BlockedSales { get; set; } 
        public IRPSCheckbox<EntityView> GeneratePurchase { get; set; } 
        public IRPSCheckbox<EntityView> SalesGuarantee { get; set; } 
        public IRPSTextBox<EntityView> SalesGuaranteePeriod { get; set; } 
        public IRPSCheckbox<EntityView> ApplySalesDiscount { get; set; } 
        public IRPSCheckbox<EntityView> ApplySalesDiscountPP { get; set; } 
        public IRPSCheckbox<EntityView> ApplySalesFinancialSurcharge { get; set; } 
        public IRPSCheckbox<EntityView> ApplySalesRetention { get; set; } 
        public IRPSCheckbox<EntityView> ApplyCommission { get; set; } 
        public IRPSCheckbox<EntityView> CustomerReferenceControl { get; set; } 
        public IRPSComboBox<EntityView> IDUnitQuantityPurchase { get; set; } 
        public IRPSComboBox<EntityView> IDUnitPricePurchase { get; set; } 
        public IRPSComboBox<EntityView> IDUnitHomogeneousPurchase { get; set; } 
        public IRPSTextBox<EntityView> PurchaseLot { get; set; } 
        public IRPSTextBox<EntityView> LaunchLot { get; set; } 
        public IRPSComboBox<EntityView> TaxTypePurchase { get; set; } 
        public IRPSComboBox<EntityView> IDTaxGroupPurchase { get; set; } 
        public IRPSComboBox<EntityView> IDSupplierGroupHeader { get; set; } 
        public IRPSComboBox<EntityView> IDSupplier { get; set; } 
        public IRPSComboBox<EntityView> IDSupplierGroup { get; set; } 
        public IRPSCheckbox<EntityView> SupplierReferenceControl { get; set; } 
        public IRPSTextBox<EntityView> DeliveryDays { get; set; } 
        public IRPSTextBox<EntityView> ReturnPercent { get; set; } 
        public IRPSTextBox<EntityView> PurchasePrice { get; set; } 
        public IRPSTextBox<EntityView> AveragePrice { get; set; } 
        public IRPSTextBox<EntityView> PurchaseDate { get; set; } 
        public IRPSCheckbox<EntityView> PurchaseKit { get; set; } 
        public IRPSCheckbox<EntityView> BlockedPurchase { get; set; } 
        public IRPSCheckbox<EntityView> ApplyPurchaseDiscount { get; set; } 
        public IRPSCheckbox<EntityView> ApplyPurchaseDiscountPP { get; set; } 
        public IRPSCheckbox<EntityView> ApplyPurchaseFinancialSurcharge { get; set; } 
        public IRPSCheckbox<EntityView> ApplyPurchaseRetention { get; set; } 
        public IRPSCheckbox<EntityView> DocumentParent { get; set; } 
        public IRPSCheckbox<EntityView> DocumentMaterials { get; set; } 
        public IRPSComboBox<EntityView> QualityOnReception { get; set; } 
        public IRPSOption<EntityView> Quality { get; set; } 
        public IRPSOption<EntityView> Main { get; set; } 
        public IRPSComboBox<EntityView> IDQualityPartType { get; set; } 
        public IRPSComboBox<EntityView> IDUnitQuantityWarehouse { get; set; } 
        public IRPSComboBox<EntityView> IDUnitPriceWarehouse { get; set; } 
        public IRPSCheckbox<EntityView> SecondUnit { get; set; } 
        public IRPSCheckbox<EntityView> SecondUnitFixed { get; set; } 
        public IRPSComboBox<EntityView> IDUnitSecondUnit { get; set; } 
        public IRPSTextBox<EntityView> AverageSecondUnit { get; set; } 
        public IRPSCheckbox<EntityView> SeriesControl { get; set; } 
        public IRPSComboBox<EntityView> IDCodingSerie { get; set; } 
        public IRPSCheckbox<EntityView> WholeSeries { get; set; } 
        public IRPSCheckbox<EntityView> AverageSecondUnitSerie { get; set; } 
        public IRPSCheckbox<EntityView> UnitarianSeries { get; set; } 
        public IRPSCheckbox<EntityView> UnitarianSerieOrder { get; set; } 
        public IRPSCheckbox<EntityView> ExpiryControl { get; set; } 
        public IRPSTextBox<EntityView> ExpireDays { get; set; } 
        public IRPSCheckbox<EntityView> StatusLot { get; set; } 
        public IRPSComboBox<EntityView> IDStatusLotGroup { get; set; } 
        public IRPSCheckbox<EntityView> PotencyControl { get; set; } 
        public IRPSTextBox<EntityView> PotencyDefault { get; set; } 
        public IRPSTextBox<EntityView> RotationIndex { get; set; } 
        public IRPSTextBox<EntityView> StockMin { get; set; } 
        public IRPSTextBox<EntityView> PointOrder { get; set; } 
        public IRPSTextBox<EntityView> ConsumePrevision { get; set; } 
        public IRPSCheckbox<EntityView> Container { get; set; } 
        public IRPSCheckbox<EntityView> HasContainer { get; set; } 
        public IRPSCheckbox<EntityView> DiscountContainer { get; set; } 
        public IRPSComboBox<EntityView> IDArticleContainer { get; set; } 
        public IRPSCheckbox<EntityView> CostMovement { get; set; } 
        public IRPSComboBox<EntityView> IDMovementType { get; set; } 
        public IRPSComboBox<EntityView> IDSiteEntry { get; set; } 
        public IRPSComboBox<EntityView> IDEntryWarehouse { get; set; } 
        public IRPSComboBox<EntityView> IDSiteOutput { get; set; } 
        public IRPSComboBox<EntityView> IDOutputWarehouse { get; set; } 
        public IRPSCheckbox<EntityView> LocationWarehouseControl { get; set; } 
        public IRPSComboBox<EntityView> IDEntryLocationWarehouse { get; set; } 
        public IRPSComboBox<EntityView> IDOutputLocationWarehouse { get; set; } 
        public IRPSComboBox<EntityView> ProvisionType { get; set; } 
        public IRPSComboBox<EntityView> IDSiteProvision { get; set; } 
        public IRPSComboBox<EntityView> IDWarehouseProvision { get; set; } 
        public IRPSTextBox<EntityView> PlanningGroup { get; set; } 
        public IRPSTextBox<EntityView> ManufactureDate { get; set; } 
        public IRPSTextBox<EntityView> StandardCostLot { get; set; } 
        public IRPSTextBox<EntityView> StandardPrice { get; set; } 
        public IRPSTextBox<EntityView> ManufacturePrice { get; set; } 
        public IRPSTextBox<EntityView> PlanningCategory { get; set; } 
        public IRPSTextBox<EntityView> MinimumManufacturingLot { get; set; } 
        public IRPSTextBox<EntityView> ManufacturingLot { get; set; } 
        public IRPSComboBox<EntityView> GroupDays { get; set; } 
        public IRPSTextBox<EntityView> GroupDaysNumber { get; set; } 
        public IRPSTextBox<EntityView> ManufacturingGroupCode { get; set; } 
        public IRPSTextBox<EntityView> ManufacturingGroupQuantity { get; set; } 
        public IRPSComboBox<EntityView> ConsumePrevisionBehavior { get; set; } 
        public IRPSComboBox<EntityView> MRPType { get; set; } 
        public IRPSCheckbox<EntityView> MRPPrevisionsOnly { get; set; } 
        public IRPSCheckbox<EntityView> BlockedManufacturing { get; set; } 
        public IRPSCheckbox<EntityView> BatchBalancing { get; set; } 
        public IRPSTextBox<EntityView> QuantityBaseFormula { get; set; } 
        public IRPSComboBox<EntityView> IDUnitBaseFormula { get; set; } 
        public IRPSCheckbox<EntityView> MultipleCADLink { get; set; } 
        public IRPSComboBox<EntityView> ComponentsGroupType { get; set; } 
        public IRPSCheckbox<EntityView> MakeAutomaticOutput { get; set; } 
        public IRPSCheckbox<EntityView> ImputationCostUpdated { get; set; } 
        public IRPSCheckbox<EntityView> ImputationTotalQuantity { get; set; } 
        public IRPSComboBox<EntityView> ProjectProvisionType { get; set; } 
        public IRPSCheckbox<EntityView> LotsReserve { get; set; } 
        public IRPSTextBox<EntityView> LotsReserveDays { get; set; } 
        public IRPSCheckbox<EntityView> LotsOrder { get; set; } 
        public IRPSTextBox<EntityView> LotsOrderDays { get; set; } 
        public IRPSComboBox<EntityView> IDProductionUnit { get; set; } 
        public IRPSTextBox<EntityView> EffortQuantity { get; set; } 
        public IRPSTextBox<EntityView> StartingMarginDays { get; set; } 
        public IRPSTextBox<EntityView> EndingMarginDays { get; set; } 
        public IRPSTextBox<EntityView> TechnicalDescription { get; set; } 
        public IRPSTextBox<EntityView> Notes { get; set; } 
        public IRPSButton<EntityView> NewArticleFromCopyCommandButton { get; set; } 
        public IRPSButton<EntityView,RecodeArticleDialogChildDialogView> RecodeArticleDialogChildNavigationCommandButton { get; set; } 
        public IRPSButton<EntityView> GenerateBarcodeCommandButton { get; set; } 
        public IRPSButton<EntityView> GenerateDependantsCommandButton { get; set; } 
        public IRPSButton<EntityView,UpdateSiteWarehouseArticleDialogView> UpdateSiteWarehouseArticleNavigationCommandButton { get; set; } 
        public IRPSButton<EntityView> InsertEANCommandButton { get; set; } 
        public ArticleFeaturesCollectionEditor<EntityView,ArticleByLangView> ArticleFeatures { get; set; } 
        public ArticleByLangsCollectionEditor<EntityView,ArticleByLangView> ArticleByLangs { get; set; } 
        public ArticleConvertMeasureUnitsCollectionEditor<EntityView,ArticleByLangView> ArticleConvertMeasureUnits { get; set; } 
        public ArticleBarCodesCollectionEditor<EntityView,ArticleByLangView> ArticleBarCodes { get; set; } 
        public ArticleDetailsCollectionEditor<EntityView,ArticleByLangView> ArticleDetails { get; set; } 
        public ArticleAlternativePurchasesCollectionEditor<EntityView,ArticleByLangView> ArticleAlternativePurchases { get; set; } 
        public ArticleAlternativeSalesSLsCollectionEditor<EntityView,ArticleByLangView> ArticleAlternativeSalesSLs { get; set; } 
        public ArticleAlternativeMaintenancesCollectionEditor<EntityView,ArticleByLangView> ArticleAlternativeMaintenances { get; set; } 
        public ArticleAlternativeManufacturingsCollectionEditor<EntityView,ArticleByLangView> ArticleAlternativeManufacturings { get; set; } 
        public IRPSSection<EntityView> GeneralData { get; set; } 
        public IRPSSection<EntityView> SecDPS { get; set; } 
        public IRPSSection<EntityView> SalesConfiguration { get; set; } 
        public IRPSSection<EntityView> PurchaseConfiguration { get; set; } 
        public IRPSSection<EntityView> WarehouseConfiguration { get; set; } 
        public IRPSSection<EntityView> ManufacturingConfiguration { get; set; } 
        public IRPSSection<EntityView> Features { get; set; } 
        public IRPSSection<EntityView> ArticleByLang { get; set; } 
        public IRPSSection<EntityView> MeasureUnit { get; set; } 
        public IRPSSection<EntityView> BarCodes { get; set; } 
        public IRPSSection<EntityView> Subsidiary { get; set; } 
        public IRPSSection<EntityView> TechnicalDescription1 { get; set; } 
        public IRPSSection<EntityView> Comments { get; set; } 
        public IRPSSection<EntityView> AlternativeArticles { get; set; } 
        public Article Screen { get; set; }
        public EntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ArticleFeaturesCollectionEditor<EntityView,ArticleByLangView>:RPSCollectionEditor<EntityView,ArticleByLangView> where EntityView : class, IView where ArticleByLangView : class, IView
    {
        public  ArticleFeaturesGridView<EntityView,ArticleByLangView> GridView {get;set;}
    }
    public partial class ArticleFeaturesGridView <EntityView,ArticleByLangView> :  RPSGridView<EntityView,ArticleByLangView> where EntityView : class, IView where ArticleByLangView : class, IView
    {
        public ArticleFeaturesGridView(EntityView currentView,ArticleByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticleLabel = RPSControlFactory.CreateRPSGridComboBox<EntityView>("","#c17b005b-d7a5-4c78-9136-ec82290a68d6 .ag-row[role='row']@ROWINDEX [col-id='cIDArticleLabel']","",true, this.CurrentView);
 
            MatchCode = RPSControlFactory.CreateRPSGridCheckBox<EntityView>("","#c17b005b-d7a5-4c78-9136-ec82290a68d6 .ag-row[role='row']@ROWINDEX [col-id='cMatchCode']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<EntityView> IDArticleLabel { get; set; } 
        public IRPSGridCheckbox<EntityView> MatchCode { get; set; } 
                     
    }
 
        public partial class ArticleByLangsCollectionEditor<EntityView,ArticleByLangView>:RPSCollectionEditor<EntityView,ArticleByLangView> where EntityView : class, IView where ArticleByLangView : class, IView
    {
        public  ArticleByLangsGridView<EntityView,ArticleByLangView> GridView {get;set;}
    }
    public partial class ArticleByLangsGridView <EntityView,ArticleByLangView> :  RPSGridView<EntityView,ArticleByLangView> where EntityView : class, IView where ArticleByLangView : class, IView
    {
        public ArticleByLangsGridView(EntityView currentView,ArticleByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<EntityView>("","#936dcf16-69f7-4b89-a1a0-dee13e3b11e1 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<EntityView>("","#936dcf16-69f7-4b89-a1a0-dee13e3b11e1 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            TechnicalDescription = RPSControlFactory.CreateRPSGridMemoTextBox<EntityView>("","#936dcf16-69f7-4b89-a1a0-dee13e3b11e1 .ag-row[role='row']@ROWINDEX [col-id='cTechnicalDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<EntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<EntityView> Description { get; set; } 
        public IRPSGridTextBox<EntityView> TechnicalDescription { get; set; } 
                     
    }
 
        public partial class ArticleConvertMeasureUnitsCollectionEditor<EntityView,ArticleByLangView>:RPSCollectionEditor<EntityView,ArticleByLangView> where EntityView : class, IView where ArticleByLangView : class, IView
    {
        public  ArticleConvertMeasureUnitsGridView<EntityView,ArticleByLangView> GridView {get;set;}
    }
    public partial class ArticleConvertMeasureUnitsGridView <EntityView,ArticleByLangView> :  RPSGridView<EntityView,ArticleByLangView> where EntityView : class, IView where ArticleByLangView : class, IView
    {
        public ArticleConvertMeasureUnitsGridView(EntityView currentView,ArticleByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDUnitSource = RPSControlFactory.CreateRPSGridComboBox<EntityView>("","#c30b5486-4694-43a5-aa8c-3a8efe317458 .ag-row[role='row']@ROWINDEX [col-id='cIDUnitSource']","",true, this.CurrentView);
 
            MultiplyOperator = RPSControlFactory.CreateRPSGridEnumComboBox<EntityView>("","#c30b5486-4694-43a5-aa8c-3a8efe317458 .ag-row[role='row']@ROWINDEX [col-id='cMultiplyOperator']","",true, this.CurrentView);
 
            MultiplyFactor = RPSControlFactory.CreateRPSGridFormattedTextBox<EntityView>("","#c30b5486-4694-43a5-aa8c-3a8efe317458 .ag-row[role='row']@ROWINDEX [col-id='cMultiplyFactor']","",true, this.CurrentView);
 
            SumOperator = RPSControlFactory.CreateRPSGridEnumComboBox<EntityView>("","#c30b5486-4694-43a5-aa8c-3a8efe317458 .ag-row[role='row']@ROWINDEX [col-id='cSumOperator']","",true, this.CurrentView);
 
            SumFactor = RPSControlFactory.CreateRPSGridTextBox<EntityView>("","#c30b5486-4694-43a5-aa8c-3a8efe317458 .ag-row[role='row']@ROWINDEX [col-id='cSumFactor']","",true, this.CurrentView);
 
            IDUnitDestination = RPSControlFactory.CreateRPSGridComboBox<EntityView>("","#c30b5486-4694-43a5-aa8c-3a8efe317458 .ag-row[role='row']@ROWINDEX [col-id='cIDUnitDestination']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<EntityView> IDUnitSource { get; set; } 
        public IRPSGridComboBox<EntityView> MultiplyOperator { get; set; } 
        public IRPSGridTextBox<EntityView> MultiplyFactor { get; set; } 
        public IRPSGridComboBox<EntityView> SumOperator { get; set; } 
        public IRPSGridTextBox<EntityView> SumFactor { get; set; } 
        public IRPSGridComboBox<EntityView> IDUnitDestination { get; set; } 
                     
    }
 
        public partial class ArticleBarCodesCollectionEditor<EntityView,ArticleByLangView>:RPSCollectionEditor<EntityView,ArticleByLangView> where EntityView : class, IView where ArticleByLangView : class, IView
    {
        public  ArticleBarCodesGridView<EntityView,ArticleByLangView> GridView {get;set;}
    }
    public partial class ArticleBarCodesGridView <EntityView,ArticleByLangView> :  RPSGridView<EntityView,ArticleByLangView> where EntityView : class, IView where ArticleByLangView : class, IView
    {
        public ArticleBarCodesGridView(EntityView currentView,ArticleByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Ean13 = RPSControlFactory.CreateRPSGridTextBox<EntityView>("","#76f6982d-c441-41a0-8da6-8ab3c1a1fc5b .ag-row[role='row']@ROWINDEX [col-id='cEan13']","",true, this.CurrentView);
 
            DefaulltEan = RPSControlFactory.CreateRPSGridCheckBox<EntityView>("","#76f6982d-c441-41a0-8da6-8ab3c1a1fc5b .ag-row[role='row']@ROWINDEX [col-id='cDefaulltEan']","",true, this.CurrentView);
 
            Ean8 = RPSControlFactory.CreateRPSGridTextBox<EntityView>("","#76f6982d-c441-41a0-8da6-8ab3c1a1fc5b .ag-row[role='row']@ROWINDEX [col-id='cEan8']","",false, this.CurrentView);
 
            Code39 = RPSControlFactory.CreateRPSGridTextBox<EntityView>("","#76f6982d-c441-41a0-8da6-8ab3c1a1fc5b .ag-row[role='row']@ROWINDEX [col-id='cCode39']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<EntityView> Ean13 { get; set; } 
        public IRPSGridCheckbox<EntityView> DefaulltEan { get; set; } 
        public IRPSGridTextBox<EntityView> Ean8 { get; set; } 
        public IRPSGridTextBox<EntityView> Code39 { get; set; } 
                     
    }
 
        public partial class ArticleDetailsCollectionEditor<EntityView,ArticleByLangView>:RPSCollectionEditor<EntityView,ArticleByLangView> where EntityView : class, IView where ArticleByLangView : class, IView
    {
        public  ArticleDetailsGridView<EntityView,ArticleByLangView> GridView {get;set;}
    }
    public partial class ArticleDetailsGridView <EntityView,ArticleByLangView> :  RPSGridView<EntityView,ArticleByLangView> where EntityView : class, IView where ArticleByLangView : class, IView
    {
        public ArticleDetailsGridView(EntityView currentView,ArticleByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodCompany = RPSControlFactory.CreateRPSGridComboBox<EntityView>("","#407492e0-cb38-4f0d-bdac-cb7c63b47355 .ag-row[role='row']@ROWINDEX [col-id='cCodCompany']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<EntityView>("","#407492e0-cb38-4f0d-bdac-cb7c63b47355 .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            ValuationCostType = RPSControlFactory.CreateRPSGridEnumComboBox<EntityView>("","#407492e0-cb38-4f0d-bdac-cb7c63b47355 .ag-row[role='row']@ROWINDEX [col-id='cValuationCostType']","",true, this.CurrentView);
 
            QualityOnReception = RPSControlFactory.CreateRPSGridEnumComboBox<EntityView>("","#407492e0-cb38-4f0d-bdac-cb7c63b47355 .ag-row[role='row']@ROWINDEX [col-id='cQualityOnReception']","",true, this.CurrentView);
 
            QualityMainWarehouse = RPSControlFactory.CreateRPSGridCheckBox<EntityView>("","#407492e0-cb38-4f0d-bdac-cb7c63b47355 .ag-row[role='row']@ROWINDEX [col-id='cQualityMainWarehouse']","",true, this.CurrentView);
 
            GeneratePurchase = RPSControlFactory.CreateRPSGridCheckBox<EntityView>("","#407492e0-cb38-4f0d-bdac-cb7c63b47355 .ag-row[role='row']@ROWINDEX [col-id='cGeneratePurchase']","",true, this.CurrentView);
 
            PlanNumber = RPSControlFactory.CreateRPSGridTextBox<EntityView>("","#407492e0-cb38-4f0d-bdac-cb7c63b47355 .ag-row[role='row']@ROWINDEX [col-id='cPlanNumber']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<EntityView> CodCompany { get; set; } 
        public IRPSGridComboBox<EntityView> Type { get; set; } 
        public IRPSGridComboBox<EntityView> ValuationCostType { get; set; } 
        public IRPSGridComboBox<EntityView> QualityOnReception { get; set; } 
        public IRPSGridCheckbox<EntityView> QualityMainWarehouse { get; set; } 
        public IRPSGridCheckbox<EntityView> GeneratePurchase { get; set; } 
        public IRPSGridTextBox<EntityView> PlanNumber { get; set; } 
                     
    }
 
        public partial class ArticleAlternativePurchasesCollectionEditor<EntityView,ArticleByLangView>:RPSCollectionEditor<EntityView,ArticleByLangView> where EntityView : class, IView where ArticleByLangView : class, IView
    {
        public  ArticleAlternativePurchasesGridView<EntityView,ArticleByLangView> GridView {get;set;}
    }
    public partial class ArticleAlternativePurchasesGridView <EntityView,ArticleByLangView> :  RPSGridView<EntityView,ArticleByLangView> where EntityView : class, IView where ArticleByLangView : class, IView
    {
        public ArticleAlternativePurchasesGridView(EntityView currentView,ArticleByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticleEquivalent = RPSControlFactory.CreateRPSGridComboBox<EntityView>("","#b163274d-9761-408e-9748-be78fb06c7fa .ag-row[role='row']@ROWINDEX [col-id='cIDArticleEquivalent']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<EntityView> IDArticleEquivalent { get; set; } 
                     
    }
 
        public partial class ArticleAlternativeSalesSLsCollectionEditor<EntityView,ArticleByLangView>:RPSCollectionEditor<EntityView,ArticleByLangView> where EntityView : class, IView where ArticleByLangView : class, IView
    {
        public  ArticleAlternativeSalesSLsGridView<EntityView,ArticleByLangView> GridView {get;set;}
    }
    public partial class ArticleAlternativeSalesSLsGridView <EntityView,ArticleByLangView> :  RPSGridView<EntityView,ArticleByLangView> where EntityView : class, IView where ArticleByLangView : class, IView
    {
        public ArticleAlternativeSalesSLsGridView(EntityView currentView,ArticleByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticleEquivalent = RPSControlFactory.CreateRPSGridComboBox<EntityView>("","#0e9ed952-fcaf-43ff-a0c1-5567c5a85ae2 .ag-row[role='row']@ROWINDEX [col-id='cIDArticleEquivalent']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<EntityView> IDArticleEquivalent { get; set; } 
                     
    }
 
        public partial class ArticleAlternativeMaintenancesCollectionEditor<EntityView,ArticleByLangView>:RPSCollectionEditor<EntityView,ArticleByLangView> where EntityView : class, IView where ArticleByLangView : class, IView
    {
        public  ArticleAlternativeMaintenancesGridView<EntityView,ArticleByLangView> GridView {get;set;}
    }
    public partial class ArticleAlternativeMaintenancesGridView <EntityView,ArticleByLangView> :  RPSGridView<EntityView,ArticleByLangView> where EntityView : class, IView where ArticleByLangView : class, IView
    {
        public ArticleAlternativeMaintenancesGridView(EntityView currentView,ArticleByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticleEquivalent = RPSControlFactory.CreateRPSGridComboBox<EntityView>("","#b0a72a41-d68e-41b4-932c-b21b7b77fd52 .ag-row[role='row']@ROWINDEX [col-id='cIDArticleEquivalent']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<EntityView> IDArticleEquivalent { get; set; } 
                     
    }
 
        public partial class ArticleAlternativeManufacturingsCollectionEditor<EntityView,ArticleByLangView>:RPSCollectionEditor<EntityView,ArticleByLangView> where EntityView : class, IView where ArticleByLangView : class, IView
    {
        public  ArticleAlternativeManufacturingsGridView<EntityView,ArticleByLangView> GridView {get;set;}
    }
    public partial class ArticleAlternativeManufacturingsGridView <EntityView,ArticleByLangView> :  RPSGridView<EntityView,ArticleByLangView> where EntityView : class, IView where ArticleByLangView : class, IView
    {
        public ArticleAlternativeManufacturingsGridView(EntityView currentView,ArticleByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticleEquivalent = RPSControlFactory.CreateRPSGridComboBox<EntityView>("","#83c2e335-f3d8-4610-9572-ee1fcff1cc98 .ag-row[role='row']@ROWINDEX [col-id='cIDArticleEquivalent']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<EntityView> IDArticleEquivalent { get; set; } 
                     
    }
 
    }
  
            
    public partial class ArticleFeatureView : View
    {
        public ArticleFeatureView(Article screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ArticleFeatureView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ArticleFeatureView,EntityView>( this,Screen.EntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ArticleFeatureView,EntityView>( this,Screen.EntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ArticleFeatureView,EntityView>( this,Screen.EntityView);
 
            IDArticleLabel = RPSControlFactory.CreateRPSComboBox<ArticleFeatureView>("8eab0d38-6590-4c1b-aa16-d6b25cef4626","","",true, this);
 
            MatchCode = RPSControlFactory.CreateRPSCheckBox<ArticleFeatureView>("f222e570-8d80-4cc5-8857-9d77ae39c2b3","","",false, this);
 

        }
        public IRPSButton<ArticleFeatureView> DeleteButton { get; set; } 
        public IRPSButton<ArticleFeatureView,EntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleFeatureView,EntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ArticleFeatureView,EntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ArticleFeatureView> IDArticleLabel { get; set; } 
        public IRPSCheckbox<ArticleFeatureView> MatchCode { get; set; } 
        public Article Screen { get; set; }
        public ArticleFeatureView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ArticleByLangView : View
    {
        public ArticleByLangView(Article screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ArticleByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ArticleByLangView,EntityView>( this,Screen.EntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ArticleByLangView,EntityView>( this,Screen.EntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ArticleByLangView,EntityView>( this,Screen.EntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<ArticleByLangView>("9ef8c96f-86c1-4c5f-ad43-1e2fce3937cc","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ArticleByLangView>("d8f46cbb-56d2-4c1b-b096-cdad67393b08","","",false, this);
 
            TechnicalDescription = RPSControlFactory.CreateRPSTextBox<ArticleByLangView>("7932c305-eca2-4ea3-b864-749579b726b5","","",false, this);
 

        }
        public IRPSButton<ArticleByLangView> DeleteButton { get; set; } 
        public IRPSButton<ArticleByLangView,EntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleByLangView,EntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ArticleByLangView,EntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ArticleByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<ArticleByLangView> Description { get; set; } 
        public IRPSTextBox<ArticleByLangView> TechnicalDescription { get; set; } 
        public Article Screen { get; set; }
        public ArticleByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ArticleBarCodeView : View
    {
        public ArticleBarCodeView(Article screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ArticleBarCodeView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ArticleBarCodeView,EntityView>( this,Screen.EntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ArticleBarCodeView,EntityView>( this,Screen.EntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ArticleBarCodeView,EntityView>( this,Screen.EntityView);
 
            Ean13 = RPSControlFactory.CreateRPSTextBox<ArticleBarCodeView>("92896262-1b88-414e-aff0-920a8c0bc92c","","",true, this);
 
            DefaulltEan = RPSControlFactory.CreateRPSCheckBox<ArticleBarCodeView>("1cfea69b-f98b-4867-b2ec-34d9691d6d42","","",true, this);
 
            Ean8 = RPSControlFactory.CreateRPSTextBox<ArticleBarCodeView>("031b3845-7b9a-430f-8caa-718e9010a0b6","","",false, this);
 
            Code39 = RPSControlFactory.CreateRPSTextBox<ArticleBarCodeView>("ade53139-97b4-4488-ae80-ffbc9d1c5e1e","","",false, this);
 
            Dum141 = RPSControlFactory.CreateRPSTextBox<ArticleBarCodeView>("635c8c71-cca3-4210-a58b-47e08f8ca9a3","","",false, this);
 
            IDUnit1 = RPSControlFactory.CreateRPSComboBox<ArticleBarCodeView>("67829cda-d01e-4b9c-9f0a-054875caef05","","",false, this);
 
            Dum142 = RPSControlFactory.CreateRPSTextBox<ArticleBarCodeView>("4b726241-01ea-46c8-b294-c19dadd008f9","","",false, this);
 
            IDUnit2 = RPSControlFactory.CreateRPSComboBox<ArticleBarCodeView>("bc8190b3-6260-443d-aebc-6598e4044df1","","",false, this);
 
            Dum143 = RPSControlFactory.CreateRPSTextBox<ArticleBarCodeView>("9af24442-ee51-4317-bc7a-4bb5fe913d0c","","",false, this);
 
            IDUnit3 = RPSControlFactory.CreateRPSComboBox<ArticleBarCodeView>("eae7e3b4-c241-490b-85da-c77f39286059","","",false, this);
 
            Dum144 = RPSControlFactory.CreateRPSTextBox<ArticleBarCodeView>("44eadc7a-1d0f-4453-b70d-7bfeb984d0f5","","",false, this);
 
            IDUnit4 = RPSControlFactory.CreateRPSComboBox<ArticleBarCodeView>("b167fc36-8b06-4c71-871e-691d28032958","","",false, this);
 
            Dum145 = RPSControlFactory.CreateRPSTextBox<ArticleBarCodeView>("d28fe2f0-141d-4cf1-8a30-e27eae31af5d","","",false, this);
 
            IDUnit5 = RPSControlFactory.CreateRPSComboBox<ArticleBarCodeView>("78c62d74-8c1a-46de-b101-7a9cfb04d72f","","",false, this);
 
            Dum146 = RPSControlFactory.CreateRPSTextBox<ArticleBarCodeView>("ffc56d3b-d42b-43e7-a28c-ea1018f70c5a","","",false, this);
 
            IDUnit6 = RPSControlFactory.CreateRPSComboBox<ArticleBarCodeView>("bf9daeaa-35c2-4c7c-a6f3-48724bca98f1","","",false, this);
 
            Dum147 = RPSControlFactory.CreateRPSTextBox<ArticleBarCodeView>("a79c2103-ac90-4416-8d1a-113806d51eba","","",false, this);
 
            IDUnit7 = RPSControlFactory.CreateRPSComboBox<ArticleBarCodeView>("1c144c97-c80d-40ec-bd71-a3cb59e0ad88","","",false, this);
 
            Dum148 = RPSControlFactory.CreateRPSTextBox<ArticleBarCodeView>("6297e865-86dd-435e-a7a3-b74ba9fcc624","","",false, this);
 
            IDUnit8 = RPSControlFactory.CreateRPSComboBox<ArticleBarCodeView>("3b9c5f45-c24f-40b9-a79f-81000874786d","","",false, this);
 

        }
        public IRPSButton<ArticleBarCodeView> DeleteButton { get; set; } 
        public IRPSButton<ArticleBarCodeView,EntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleBarCodeView,EntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ArticleBarCodeView,EntityView> AcceptButton { get; set; } 
        public IRPSTextBox<ArticleBarCodeView> Ean13 { get; set; } 
        public IRPSCheckbox<ArticleBarCodeView> DefaulltEan { get; set; } 
        public IRPSTextBox<ArticleBarCodeView> Ean8 { get; set; } 
        public IRPSTextBox<ArticleBarCodeView> Code39 { get; set; } 
        public IRPSTextBox<ArticleBarCodeView> Dum141 { get; set; } 
        public IRPSComboBox<ArticleBarCodeView> IDUnit1 { get; set; } 
        public IRPSTextBox<ArticleBarCodeView> Dum142 { get; set; } 
        public IRPSComboBox<ArticleBarCodeView> IDUnit2 { get; set; } 
        public IRPSTextBox<ArticleBarCodeView> Dum143 { get; set; } 
        public IRPSComboBox<ArticleBarCodeView> IDUnit3 { get; set; } 
        public IRPSTextBox<ArticleBarCodeView> Dum144 { get; set; } 
        public IRPSComboBox<ArticleBarCodeView> IDUnit4 { get; set; } 
        public IRPSTextBox<ArticleBarCodeView> Dum145 { get; set; } 
        public IRPSComboBox<ArticleBarCodeView> IDUnit5 { get; set; } 
        public IRPSTextBox<ArticleBarCodeView> Dum146 { get; set; } 
        public IRPSComboBox<ArticleBarCodeView> IDUnit6 { get; set; } 
        public IRPSTextBox<ArticleBarCodeView> Dum147 { get; set; } 
        public IRPSComboBox<ArticleBarCodeView> IDUnit7 { get; set; } 
        public IRPSTextBox<ArticleBarCodeView> Dum148 { get; set; } 
        public IRPSComboBox<ArticleBarCodeView> IDUnit8 { get; set; } 
        public Article Screen { get; set; }
        public ArticleBarCodeView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ArticleDetailView : View
    {
        public ArticleDetailView(Article screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ArticleDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ArticleDetailView,EntityView>( this,Screen.EntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ArticleDetailView,EntityView>( this,Screen.EntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ArticleDetailView,EntityView>( this,Screen.EntityView);
 
            CodCompany = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("bd3ffc0b-1854-4fa1-b72e-69b62c9c5e69","","",true, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<ArticleDetailView>("a7d9df42-d66d-465b-a098-79f6728b8972","","",true, this);
 
            ValuationCostType = RPSControlFactory.CreateRPSEnumComboBox<ArticleDetailView>("5cc5b911-b0e7-426f-b9d3-56679df1f8c3","","",true, this);
 
            IDVATType = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("77198cf9-fd82-4995-998e-24fac0cbf74e","","",true, this);
 
            IDArticleAccType = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("2e8e31dc-2d64-477b-b6aa-a869fcdf1f2b","","",false, this);
 
            SalesLot = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("87bc5fdc-8a5d-4109-a29c-f8bbc6573e3f","","",true, this);
 
            MinimumSalesLot = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("7bf5a88d-5d57-455c-8453-f94dac870bc4","","",true, this);
 
            SalesKit = RPSControlFactory.CreateRPSCheckBox<ArticleDetailView>("286994d2-81ed-4f90-8c61-52cacd3aaacf","","",true, this);
 
            BlockedSales = RPSControlFactory.CreateRPSCheckBox<ArticleDetailView>("9418e027-914d-4d7a-aad4-6ecdba449342","","",true, this);
 
            GeneratePurchase = RPSControlFactory.CreateRPSCheckBox<ArticleDetailView>("2797f92d-24da-4fc1-84da-1f464506a501","","",true, this);
 
            CustomerReferenceControl = RPSControlFactory.CreateRPSCheckBox<ArticleDetailView>("7b2aaa83-3702-4bea-9823-8d4e2bdfb599","","",true, this);
 
            TaxTypeSales = RPSControlFactory.CreateRPSEnumComboBox<ArticleDetailView>("7a7fdf9f-6b3e-4882-a10d-2011b54ae3d0","","",true, this);
 
            IDTaxGroupSales = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("823e1551-4e3d-4761-bc2c-73f8d9d75971","","",false, this);
 
            SalesGuarantee = RPSControlFactory.CreateRPSCheckBox<ArticleDetailView>("f5eeed05-8851-4cc4-970f-2a2bd0ce534d","","",true, this);
 
            SalesGuaranteePeriod = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("e341dd25-be53-477d-8612-c105fdd6fc0c","","",true, this);
 
            TaxTypePurchase = RPSControlFactory.CreateRPSEnumComboBox<ArticleDetailView>("baa5d262-bb8b-4b68-b874-36e63e5e331f","","",true, this);
 
            IDTaxGroupPurchase = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("a3b7d94c-fd8e-4466-9df6-bfb0d0159f0a","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("224e0922-c291-4459-bb3f-28f63a67a178","","",false, this);
 
            SupplierReferenceControl = RPSControlFactory.CreateRPSCheckBox<ArticleDetailView>("e13ab4a7-e032-466a-adfc-c7578c60f26d","","",true, this);
 
            IDSupplierGroup = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("21c7f684-5d27-4d09-8ad2-9ada5bc3eeb8","","",false, this);
 
            ReturnPercent = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("c40cb75e-8ece-4ef8-9bbd-217604840b84","","",true, this);
 
            PurchasePrice = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("2e478a92-c021-40ed-bc6d-267f801517f0","","",true, this);
 
            AveragePrice = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("34cbc065-b534-4882-8fcb-11868a877d19","","",true, this);
 
            PurchaseDate = RPSControlFactory.CreateRPSTextBox<ArticleDetailView>("63fa45d6-ce16-4e93-beae-4a60f0a975df","","",false, this);
 
            PurchaseLot = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("81633cc5-dfa8-4696-9ade-87412007aac4","","",true, this);
 
            LaunchLot = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("d81eea5a-774a-483c-bfd3-f796f1db8e00","","",true, this);
 
            DeliveryDays = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("53ad354e-7777-4136-8ed9-50e43fd018af","","",true, this);
 
            PurchaseKit = RPSControlFactory.CreateRPSCheckBox<ArticleDetailView>("f0de610a-298c-4fce-8e3a-649523932eaa","","",true, this);
 
            BlockedPurchase = RPSControlFactory.CreateRPSCheckBox<ArticleDetailView>("778a37a3-073b-4859-8b19-310e290e016d","","",true, this);
 
            DocumentParent = RPSControlFactory.CreateRPSCheckBox<ArticleDetailView>("adca00d7-4054-45db-aa14-7e8f678f0d16","","",true, this);
 
            DocumentMaterials = RPSControlFactory.CreateRPSCheckBox<ArticleDetailView>("58684292-e96b-4c81-bd96-38a4f520d6d2","","",true, this);
 
            QualityOnReception = RPSControlFactory.CreateRPSEnumComboBox<ArticleDetailView>("a65100de-fa83-4a2e-857b-aba82f1eda51","","",true, this);
 
            Quality = RPSControlFactory.CreateRPSOption<ArticleDetailView>( "37cc7398-c860-49a6-aa5f-93bf33455dc1","","",this);
 
            Main = RPSControlFactory.CreateRPSOption<ArticleDetailView>( "a19d6fc0-48d3-48a9-90e6-745a1de3738a","","",this);
 
            IDQualityPartType = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("cbd961d5-0925-4b78-a9d4-283338ab0bf4","","",false, this);
 
            RotationIndex = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("54d3ad8d-1988-4fb1-92ff-f551095aacbb","","",false, this);
 
            StockMin = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("5e9e0bf2-9e86-427c-b39b-4b16890d1ddd","","",true, this);
 
            PointOrder = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("d438ec54-22f7-44a0-a634-c45d07609665","","",true, this);
 
            ConsumePrevision = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("4eaf4418-0302-4770-94e7-260e771fcd06","","",true, this);
 
            IDCodingSerie = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("28686b14-0828-4d83-ba88-d8ea83b056c2","","",false, this);
 
            CostMovement = RPSControlFactory.CreateRPSCheckBox<ArticleDetailView>("688b9c7d-8568-4f44-9095-c6b34c19974c","","",true, this);
 
            IDMovementType = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("3eaab42b-f89a-42b1-bc5e-f256a4045e52","","",false, this);
 
            IDSiteEntry = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("fb15e196-a350-411a-80cd-1cba096218bb","","",false, this);
 
            IDEntryWarehouse = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("03a0f5f3-c1e7-4a04-b96d-77c279d7b856","","",false, this);
 
            IDEntryLocationWarehouse = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("d1dd8e03-68c7-4c3f-bcb0-3fe080cfa467","","",false, this);
 
            IDSiteOutput = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("9e29011d-29ed-4ab7-bc8a-fa682b4cf2cc","","",false, this);
 
            IDOutputWarehouse = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("b3ff32fd-0e4c-44cc-a4f2-f13e72cc9c7d","","",false, this);
 
            IDOutputLocationWarehouse = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("7a4e9b95-760b-4eaa-93b8-4e191d8219f1","","",false, this);
 
            ProvisionType = RPSControlFactory.CreateRPSEnumComboBox<ArticleDetailView>("56710b8a-2d27-443b-8ca4-9c38b1ef3cca","","",true, this);
 
            IDSiteProvision = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("300c03d4-f8be-413b-9252-89b09a82a725","","",false, this);
 
            IDWarehouseProvision = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("b5b84837-e87a-4515-a967-e0898a106278","","",false, this);
 
            ManufacturePrice = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("c85ead59-b1ad-491e-85e2-2855adc45cbc","","",true, this);
 
            ManufactureDate = RPSControlFactory.CreateRPSTextBox<ArticleDetailView>("4db98eeb-8591-4a54-9cfc-528f5d692970","","",false, this);
 
            StandardCostLot = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("bf09bbbe-3f52-4274-8a11-f230afae526b","","",true, this);
 
            StandardPrice = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("48ab0a09-9903-475c-a9fb-73c530a10f43","","",true, this);
 
            MinimumManufacturingLot = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("9cfeae95-d9fb-4e90-8ffd-9b98eadbaa5d","","",true, this);
 
            ManufacturingLot = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("24399964-014e-4a12-89b7-c1d3e66b4448","","",true, this);
 
            BlockedManufacturing = RPSControlFactory.CreateRPSCheckBox<ArticleDetailView>("ba06c766-acc9-4729-ae62-2e128e49dc11","","",true, this);
 
            MRPType = RPSControlFactory.CreateRPSEnumComboBox<ArticleDetailView>("99b3fc38-6baf-4812-8ee9-c6459ba9cbad","","",true, this);
 
            PlanNumber = RPSControlFactory.CreateRPSTextBox<ArticleDetailView>("c3505399-f2f3-414c-a57b-4da10281398f","","",false, this);
 
            IDImportDocumentType = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("4cb10d4e-0740-49ae-a62d-8210d1322816","","",false, this);
 
            IDImportTariffType = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("b599f798-d03a-4e81-a8fb-2392240e0f42","","",false, this);
 

        }
        public IRPSButton<ArticleDetailView> DeleteButton { get; set; } 
        public IRPSButton<ArticleDetailView,EntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleDetailView,EntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ArticleDetailView,EntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ArticleDetailView> CodCompany { get; set; } 
        public IRPSComboBox<ArticleDetailView> Type { get; set; } 
        public IRPSComboBox<ArticleDetailView> ValuationCostType { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDVATType { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDArticleAccType { get; set; } 
        public IRPSTextBox<ArticleDetailView> SalesLot { get; set; } 
        public IRPSTextBox<ArticleDetailView> MinimumSalesLot { get; set; } 
        public IRPSCheckbox<ArticleDetailView> SalesKit { get; set; } 
        public IRPSCheckbox<ArticleDetailView> BlockedSales { get; set; } 
        public IRPSCheckbox<ArticleDetailView> GeneratePurchase { get; set; } 
        public IRPSCheckbox<ArticleDetailView> CustomerReferenceControl { get; set; } 
        public IRPSComboBox<ArticleDetailView> TaxTypeSales { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDTaxGroupSales { get; set; } 
        public IRPSCheckbox<ArticleDetailView> SalesGuarantee { get; set; } 
        public IRPSTextBox<ArticleDetailView> SalesGuaranteePeriod { get; set; } 
        public IRPSComboBox<ArticleDetailView> TaxTypePurchase { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDTaxGroupPurchase { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDSupplier { get; set; } 
        public IRPSCheckbox<ArticleDetailView> SupplierReferenceControl { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDSupplierGroup { get; set; } 
        public IRPSTextBox<ArticleDetailView> ReturnPercent { get; set; } 
        public IRPSTextBox<ArticleDetailView> PurchasePrice { get; set; } 
        public IRPSTextBox<ArticleDetailView> AveragePrice { get; set; } 
        public IRPSTextBox<ArticleDetailView> PurchaseDate { get; set; } 
        public IRPSTextBox<ArticleDetailView> PurchaseLot { get; set; } 
        public IRPSTextBox<ArticleDetailView> LaunchLot { get; set; } 
        public IRPSTextBox<ArticleDetailView> DeliveryDays { get; set; } 
        public IRPSCheckbox<ArticleDetailView> PurchaseKit { get; set; } 
        public IRPSCheckbox<ArticleDetailView> BlockedPurchase { get; set; } 
        public IRPSCheckbox<ArticleDetailView> DocumentParent { get; set; } 
        public IRPSCheckbox<ArticleDetailView> DocumentMaterials { get; set; } 
        public IRPSComboBox<ArticleDetailView> QualityOnReception { get; set; } 
        public IRPSOption<ArticleDetailView> Quality { get; set; } 
        public IRPSOption<ArticleDetailView> Main { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDQualityPartType { get; set; } 
        public IRPSTextBox<ArticleDetailView> RotationIndex { get; set; } 
        public IRPSTextBox<ArticleDetailView> StockMin { get; set; } 
        public IRPSTextBox<ArticleDetailView> PointOrder { get; set; } 
        public IRPSTextBox<ArticleDetailView> ConsumePrevision { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDCodingSerie { get; set; } 
        public IRPSCheckbox<ArticleDetailView> CostMovement { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDMovementType { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDSiteEntry { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDEntryWarehouse { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDEntryLocationWarehouse { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDSiteOutput { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDOutputWarehouse { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDOutputLocationWarehouse { get; set; } 
        public IRPSComboBox<ArticleDetailView> ProvisionType { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDSiteProvision { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDWarehouseProvision { get; set; } 
        public IRPSTextBox<ArticleDetailView> ManufacturePrice { get; set; } 
        public IRPSTextBox<ArticleDetailView> ManufactureDate { get; set; } 
        public IRPSTextBox<ArticleDetailView> StandardCostLot { get; set; } 
        public IRPSTextBox<ArticleDetailView> StandardPrice { get; set; } 
        public IRPSTextBox<ArticleDetailView> MinimumManufacturingLot { get; set; } 
        public IRPSTextBox<ArticleDetailView> ManufacturingLot { get; set; } 
        public IRPSCheckbox<ArticleDetailView> BlockedManufacturing { get; set; } 
        public IRPSComboBox<ArticleDetailView> MRPType { get; set; } 
        public IRPSTextBox<ArticleDetailView> PlanNumber { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDImportDocumentType { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDImportTariffType { get; set; } 
        public Article Screen { get; set; }
        public ArticleDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ArticleConvertMeasureUnitView : View
    {
        public ArticleConvertMeasureUnitView(Article screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ArticleConvertMeasureUnitView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ArticleConvertMeasureUnitView,EntityView>( this,Screen.EntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ArticleConvertMeasureUnitView,EntityView>( this,Screen.EntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ArticleConvertMeasureUnitView,EntityView>( this,Screen.EntityView);
 
            Formulated = RPSControlFactory.CreateRPSOption<ArticleConvertMeasureUnitView>( "c8070849-7f5f-4470-957d-10be083f2937","","",this);
 
            IDUnitSource = RPSControlFactory.CreateRPSComboBox<ArticleConvertMeasureUnitView>("71ef103c-c072-4434-b5ed-30f802a1437d","","",true, this);
 
            MultiplyOperator = RPSControlFactory.CreateRPSEnumComboBox<ArticleConvertMeasureUnitView>("5a42f14b-c50e-47d5-b2fd-634c3c03980c","","",true, this);
 
            MultiplyFactor = RPSControlFactory.CreateRPSFormattedTextBox<ArticleConvertMeasureUnitView>("ab028154-d7b5-42b2-bbe4-ef72ab74099a","","",true, this);
 
            IDUnitDestination = RPSControlFactory.CreateRPSComboBox<ArticleConvertMeasureUnitView>("53bb5567-9c51-4d14-bede-77e030d59a87","","",true, this);
 
            Second_Unit = RPSControlFactory.CreateRPSOption<ArticleConvertMeasureUnitView>( "25017581-7842-46bf-9123-abd19a7f5be0","","",this);
 
            SumOperator = RPSControlFactory.CreateRPSEnumComboBox<ArticleConvertMeasureUnitView>("0cdbec68-f077-4b96-a9e4-a93ae561868f","","",true, this);
 
            SumFactor = RPSControlFactory.CreateRPSTextBox<ArticleConvertMeasureUnitView>("050e475e-8256-49ea-aad8-6cb7665ed29b","","",true, this);
 

        }
        public IRPSButton<ArticleConvertMeasureUnitView> DeleteButton { get; set; } 
        public IRPSButton<ArticleConvertMeasureUnitView,EntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleConvertMeasureUnitView,EntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ArticleConvertMeasureUnitView,EntityView> AcceptButton { get; set; } 
        public IRPSOption<ArticleConvertMeasureUnitView> Formulated { get; set; } 
        public IRPSComboBox<ArticleConvertMeasureUnitView> IDUnitSource { get; set; } 
        public IRPSComboBox<ArticleConvertMeasureUnitView> MultiplyOperator { get; set; } 
        public IRPSTextBox<ArticleConvertMeasureUnitView> MultiplyFactor { get; set; } 
        public IRPSComboBox<ArticleConvertMeasureUnitView> IDUnitDestination { get; set; } 
        public IRPSOption<ArticleConvertMeasureUnitView> Second_Unit { get; set; } 
        public IRPSComboBox<ArticleConvertMeasureUnitView> SumOperator { get; set; } 
        public IRPSTextBox<ArticleConvertMeasureUnitView> SumFactor { get; set; } 
        public Article Screen { get; set; }
        public ArticleConvertMeasureUnitView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class RecodeArticleDialogChildDialogView : View
    {
        public RecodeArticleDialogChildDialogView(Article screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Automatic = RPSControlFactory.CreateRPSOption<RecodeArticleDialogChildDialogView>( "2959479a-46c9-4264-8f5b-f7b83528d1b4","","",this);
 
            Manual = RPSControlFactory.CreateRPSOption<RecodeArticleDialogChildDialogView>( "0b90b07b-da65-4530-b5cc-30e3a0af9eba","","",this);
 
            UINewCode = RPSControlFactory.CreateRPSTextBox<RecodeArticleDialogChildDialogView>("407d9275-f916-40ac-9258-c6a9fa6d313c","","",false, this);
 

        }
        public IRPSOption<RecodeArticleDialogChildDialogView> Automatic { get; set; } 
        public IRPSOption<RecodeArticleDialogChildDialogView> Manual { get; set; } 
        public IRPSTextBox<RecodeArticleDialogChildDialogView> UINewCode { get; set; } 
        public Article Screen { get; set; }
        public RecodeArticleDialogChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ArticleAlternativePurchaseView : View
    {
        public ArticleAlternativePurchaseView(Article screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ArticleAlternativePurchaseView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ArticleAlternativePurchaseView,EntityView>( this,Screen.EntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ArticleAlternativePurchaseView,EntityView>( this,Screen.EntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ArticleAlternativePurchaseView,EntityView>( this,Screen.EntityView);
 
            IDArticleEquivalent = RPSControlFactory.CreateRPSComboBox<ArticleAlternativePurchaseView>("711b27ea-5eec-4fb1-8bc1-724d295fc239","","",true, this);
 

        }
        public IRPSButton<ArticleAlternativePurchaseView> DeleteButton { get; set; } 
        public IRPSButton<ArticleAlternativePurchaseView,EntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleAlternativePurchaseView,EntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ArticleAlternativePurchaseView,EntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ArticleAlternativePurchaseView> IDArticleEquivalent { get; set; } 
        public Article Screen { get; set; }
        public ArticleAlternativePurchaseView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ArticleAlternativeSalesSLView : View
    {
        public ArticleAlternativeSalesSLView(Article screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ArticleAlternativeSalesSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ArticleAlternativeSalesSLView,EntityView>( this,Screen.EntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ArticleAlternativeSalesSLView,EntityView>( this,Screen.EntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ArticleAlternativeSalesSLView,EntityView>( this,Screen.EntityView);
 
            IDArticleEquivalent = RPSControlFactory.CreateRPSComboBox<ArticleAlternativeSalesSLView>("37983ea6-3e21-47aa-8601-db69dcd334f6","","",true, this);
 

        }
        public IRPSButton<ArticleAlternativeSalesSLView> DeleteButton { get; set; } 
        public IRPSButton<ArticleAlternativeSalesSLView,EntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleAlternativeSalesSLView,EntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ArticleAlternativeSalesSLView,EntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ArticleAlternativeSalesSLView> IDArticleEquivalent { get; set; } 
        public Article Screen { get; set; }
        public ArticleAlternativeSalesSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ArticleAlternativeManufacturingView : View
    {
        public ArticleAlternativeManufacturingView(Article screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ArticleAlternativeManufacturingView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ArticleAlternativeManufacturingView,EntityView>( this,Screen.EntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ArticleAlternativeManufacturingView,EntityView>( this,Screen.EntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ArticleAlternativeManufacturingView,EntityView>( this,Screen.EntityView);
 
            IDArticleEquivalent = RPSControlFactory.CreateRPSComboBox<ArticleAlternativeManufacturingView>("5c8dce34-7815-4333-ac80-ce6307aaa46f","","",true, this);
 

        }
        public IRPSButton<ArticleAlternativeManufacturingView> DeleteButton { get; set; } 
        public IRPSButton<ArticleAlternativeManufacturingView,EntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleAlternativeManufacturingView,EntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ArticleAlternativeManufacturingView,EntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ArticleAlternativeManufacturingView> IDArticleEquivalent { get; set; } 
        public Article Screen { get; set; }
        public ArticleAlternativeManufacturingView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ArticleAlternativeMaintenanceView : View
    {
        public ArticleAlternativeMaintenanceView(Article screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ArticleAlternativeMaintenanceView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ArticleAlternativeMaintenanceView,EntityView>( this,Screen.EntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ArticleAlternativeMaintenanceView,EntityView>( this,Screen.EntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ArticleAlternativeMaintenanceView,EntityView>( this,Screen.EntityView);
 
            IDArticleEquivalent = RPSControlFactory.CreateRPSComboBox<ArticleAlternativeMaintenanceView>("49ff1374-09af-4741-816e-be05fecbe27a","","",true, this);
 

        }
        public IRPSButton<ArticleAlternativeMaintenanceView> DeleteButton { get; set; } 
        public IRPSButton<ArticleAlternativeMaintenanceView,EntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleAlternativeMaintenanceView,EntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ArticleAlternativeMaintenanceView,EntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ArticleAlternativeMaintenanceView> IDArticleEquivalent { get; set; } 
        public Article Screen { get; set; }
        public ArticleAlternativeMaintenanceView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class UpdateSiteWarehouseArticleDialogView : View
    {
        public UpdateSiteWarehouseArticleDialogView(Article screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIUpdateSite = RPSControlFactory.CreateRPSCheckBox<UpdateSiteWarehouseArticleDialogView>("aac8dcfa-4359-4018-a88d-1b46ab9d960b","","",false, this);
 
            UIUpdateWarehouse = RPSControlFactory.CreateRPSCheckBox<UpdateSiteWarehouseArticleDialogView>("b57bee92-0f63-4998-9062-5380d45f8f49","","",false, this);
 
            UIStocMin = RPSControlFactory.CreateRPSCheckBox<UpdateSiteWarehouseArticleDialogView>("48e25ddd-98df-4d31-8098-f4c7ef104efe","","",false, this);
 
            UIConsumePrevision = RPSControlFactory.CreateRPSCheckBox<UpdateSiteWarehouseArticleDialogView>("fc3bb665-768f-4177-b91b-a93ec96b86c6","","",false, this);
 
            UIOrderPoint = RPSControlFactory.CreateRPSCheckBox<UpdateSiteWarehouseArticleDialogView>("14c44e85-5614-4240-bcfd-2ce277998785","","",false, this);
 
            UIRotationIndex = RPSControlFactory.CreateRPSCheckBox<UpdateSiteWarehouseArticleDialogView>("805b60ae-e8ff-401d-b787-f477a7644053","","",false, this);
 
            UIStandardPrice = RPSControlFactory.CreateRPSCheckBox<UpdateSiteWarehouseArticleDialogView>("acf6c714-1d15-4596-8fa0-fe83f832e2dc","","",false, this);
 

        }
        public IRPSCheckbox<UpdateSiteWarehouseArticleDialogView> UIUpdateSite { get; set; } 
        public IRPSCheckbox<UpdateSiteWarehouseArticleDialogView> UIUpdateWarehouse { get; set; } 
        public IRPSCheckbox<UpdateSiteWarehouseArticleDialogView> UIStocMin { get; set; } 
        public IRPSCheckbox<UpdateSiteWarehouseArticleDialogView> UIConsumePrevision { get; set; } 
        public IRPSCheckbox<UpdateSiteWarehouseArticleDialogView> UIOrderPoint { get; set; } 
        public IRPSCheckbox<UpdateSiteWarehouseArticleDialogView> UIRotationIndex { get; set; } 
        public IRPSCheckbox<UpdateSiteWarehouseArticleDialogView> UIStandardPrice { get; set; } 
        public Article Screen { get; set; }
        public UpdateSiteWarehouseArticleDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FormulaValidatorView : View
    {
        public FormulaValidatorView(Article screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            cmdPlus = RPSControlFactory.CreateRPSButton<FormulaValidatorView>( "c082d1f5-2156-47d6-bbfb-21e52ac8ee56","","",this);
 
            cmdSub = RPSControlFactory.CreateRPSButton<FormulaValidatorView>( "5f51d98c-1996-486f-b452-dd8437a08211","","",this);
 
            cmdMult = RPSControlFactory.CreateRPSButton<FormulaValidatorView>( "dd2c4e03-b7cc-4a83-a777-a2305881f0ba","","",this);
 
            cmdDiv = RPSControlFactory.CreateRPSButton<FormulaValidatorView>( "cadf5e6c-7d82-4b2e-83b3-f701be20b1c2","","",this);
 
            cmdOpenParent = RPSControlFactory.CreateRPSButton<FormulaValidatorView>( "64bf342c-96eb-4aea-b6f2-7083e28ce36b","","",this);
 
            cmdCloseParent = RPSControlFactory.CreateRPSButton<FormulaValidatorView>( "a2e825e3-2fa5-4bca-ad9b-8658f5cb3756","","",this);
 
            Formula = RPSControlFactory.CreateRPSTextBox<FormulaValidatorView>("346efa2a-850e-488a-8611-3d18b54105d6","","",false, this);
 

        }
        public IRPSButton<FormulaValidatorView> cmdPlus { get; set; } 
        public IRPSButton<FormulaValidatorView> cmdSub { get; set; } 
        public IRPSButton<FormulaValidatorView> cmdMult { get; set; } 
        public IRPSButton<FormulaValidatorView> cmdDiv { get; set; } 
        public IRPSButton<FormulaValidatorView> cmdOpenParent { get; set; } 
        public IRPSButton<FormulaValidatorView> cmdCloseParent { get; set; } 
        public IRPSTextBox<FormulaValidatorView> Formula { get; set; } 
        public Article Screen { get; set; }
        public FormulaValidatorView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}