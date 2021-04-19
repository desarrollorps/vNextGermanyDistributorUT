    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Warehouse.ArticleClassification
{
    //RPS VERSION 1.0.0.0
    public partial class ArticleClassification:Screen
    {
        public ArticleClassification():base()
        {
            this.URL = "warehouse.articleclassification";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ArticleClassificationCollectionView  = new ArticleClassificationCollectionView(this); 
            ArticleClassificationEntityView  = new ArticleClassificationEntityView(this); 
            ArticleClassificationFeatureView  = new ArticleClassificationFeatureView(this); 
            ArticleClassificationDetailView  = new ArticleClassificationDetailView(this); 
            ArticleClassificationCollectionView.InitializeControls(); 
            ArticleClassificationEntityView.InitializeControls(); 
            ArticleClassificationFeatureView.InitializeControls(); 
            ArticleClassificationDetailView.InitializeControls(); 
           
        }
      
            public ArticleClassificationCollectionView ArticleClassificationCollectionView {get; set; } 
            public ArticleClassificationEntityView ArticleClassificationEntityView {get; set; } 
            public ArticleClassificationFeatureView ArticleClassificationFeatureView {get; set; } 
            public ArticleClassificationDetailView ArticleClassificationDetailView {get; set; } 
    }
            
    public partial class ArticleClassificationCollectionView : View
    {
        public ArticleClassificationCollectionView(ArticleClassification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ArticleClassificationCollectionView,ArticleClassificationEntityView>( this,Screen.ArticleClassificationEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "841c3153-727f-42b5-82ab-18f7e6b9dada",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ArticleClassificationCollectionView,ArticleClassificationEntityView>( params_MainConsult,this,Screen.ArticleClassificationEntityView);
 

        }
        public IRPSButton<ArticleClassificationCollectionView,ArticleClassificationEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ArticleClassificationCollectionView,ArticleClassificationEntityView> MainConsult { get; set; } 
        public ArticleClassification Screen { get; set; }
        public ArticleClassificationCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ArticleClassificationEntityView : View
    {
        public ArticleClassificationEntityView(ArticleClassification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ArticleClassificationEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ArticleClassificationEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ArticleClassificationEntityView,ArticleClassificationCollectionView>( this,Screen.ArticleClassificationCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ArticleClassificationEntityView,ArticleClassificationCollectionView>( this,Screen.ArticleClassificationCollectionView);
 
            CodArticleClassification = RPSControlFactory.CreateRPSTextBox<ArticleClassificationEntityView>("64e230ea-06bc-4374-8287-593609b46e97","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ArticleClassificationEntityView>("d65b27fb-b030-448d-95d1-fe1f9225b76a","","",false, this);
 
            IDProductLine = RPSControlFactory.CreateRPSComboBox<ArticleClassificationEntityView>("3701e5b3-ed80-47f8-a41a-9b9f8d49a004","","",false, this);
 
            IDProductFamily = RPSControlFactory.CreateRPSComboBox<ArticleClassificationEntityView>("bb9ab64d-43b7-4c0a-98eb-b27dc6e83a86","","",false, this);
 
            IDProductSubFamily = RPSControlFactory.CreateRPSComboBox<ArticleClassificationEntityView>("253703b7-ec07-4717-ada4-40c68bab429d","","",false, this);
 
            IDVATType = RPSControlFactory.CreateRPSComboBox<ArticleClassificationEntityView>("0dab2ada-93ac-4b84-b09d-9934ace0db7a","","",false, this);
 
            IDArticleAccType = RPSControlFactory.CreateRPSComboBox<ArticleClassificationEntityView>("ce54b508-78c0-44ac-94b7-25519c73f478","","",false, this);
 
            CodificationType = RPSControlFactory.CreateRPSEnumComboBox<ArticleClassificationEntityView>("8e377a06-cfde-4728-acaa-48b6a3c77487","","",true, this);
 
            IDCodingSerieArticle = RPSControlFactory.CreateRPSComboBox<ArticleClassificationEntityView>("fcc37ada-2438-4d7e-b277-181d138ac736","","",false, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<ArticleClassificationEntityView>("c6d43ee5-59a7-4c49-a0e7-7212a630064d","","",true, this);
 
            ValuationCostType = RPSControlFactory.CreateRPSEnumComboBox<ArticleClassificationEntityView>("8695ee07-4b98-4394-a44c-34461be59ac8","","",true, this);
 
            Dimension = RPSControlFactory.CreateRPSEnumComboBox<ArticleClassificationEntityView>("5bae7c38-55dc-4017-ad66-edb30af1f7db","","",true, this);
 
            IDUnitQuantityPurchase = RPSControlFactory.CreateRPSComboBox<ArticleClassificationEntityView>("ddbceb41-26dd-4d0f-9695-bfeca608f290","","",false, this);
 
            IDUnitPricePurchase = RPSControlFactory.CreateRPSComboBox<ArticleClassificationEntityView>("d18c4114-98f1-4fd5-b607-3904d4e9bceb","","",false, this);
 
            IDUnitHomogeneousPurchase = RPSControlFactory.CreateRPSComboBox<ArticleClassificationEntityView>("0296b2e9-5bde-4b97-bcc4-c3e90b3c0c7a","","",false, this);
 
            TaxTypePurchase = RPSControlFactory.CreateRPSEnumComboBox<ArticleClassificationEntityView>("383b7c21-4a1f-4aba-ac6a-cf4e5197fd7e","","",true, this);
 
            IDTaxGroupPurchase = RPSControlFactory.CreateRPSComboBox<ArticleClassificationEntityView>("0ec6e347-2aa1-4c10-8508-230e5bf97975","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<ArticleClassificationEntityView>("e8b420cc-b92b-4fa1-b334-88f6a0440eb6","","",false, this);
 
            IDSupplierGroup = RPSControlFactory.CreateRPSComboBox<ArticleClassificationEntityView>("cb1e2422-8cf3-4db6-a74d-547e4ef17ee6","","",false, this);
 
            QualityOnReception = RPSControlFactory.CreateRPSEnumComboBox<ArticleClassificationEntityView>("592cf347-63f2-4fa9-aec1-22646f11b596","","",true, this);
 
            Quality = RPSControlFactory.CreateRPSOption<ArticleClassificationEntityView>( "d6936f31-1403-47d9-8e91-7922b6084b1e","","",this);
 
            Main = RPSControlFactory.CreateRPSOption<ArticleClassificationEntityView>( "233d4147-c9fd-4826-8a26-218809db0796","","",this);
 
            IDQualityPartType = RPSControlFactory.CreateRPSComboBox<ArticleClassificationEntityView>("836c67ee-bb6f-4fd0-8ff3-3328cfcc2df9","","",false, this);
 
            ApplyPurchaseDiscount = RPSControlFactory.CreateRPSCheckBox<ArticleClassificationEntityView>("92503667-4343-4c4e-a392-17412ff55686","","",true, this);
 
            ApplyPurchaseDiscountPP = RPSControlFactory.CreateRPSCheckBox<ArticleClassificationEntityView>("411c3afc-60b5-4656-884f-e8d6c3e1a2d6","","",true, this);
 
            ApplyPurchaseFinancialSurcharge = RPSControlFactory.CreateRPSCheckBox<ArticleClassificationEntityView>("ea9dfa46-b1bf-4dd7-a78f-b3239b39948c","","",true, this);
 
            ApplyPurchaseRetention = RPSControlFactory.CreateRPSCheckBox<ArticleClassificationEntityView>("08266983-c509-4e2c-bec5-b148348b3599","","",true, this);
 
            IDUnitQuantitySales = RPSControlFactory.CreateRPSComboBox<ArticleClassificationEntityView>("75ba8cc6-d524-45ed-89a0-204cc0ea32ec","","",false, this);
 
            IDUnitPriceSales = RPSControlFactory.CreateRPSComboBox<ArticleClassificationEntityView>("2f0bbef8-2d74-4ff0-b2c4-d27a96ad7760","","",false, this);
 
            IDUnitHomogeneousSales = RPSControlFactory.CreateRPSComboBox<ArticleClassificationEntityView>("8241643f-7db1-45fa-8a23-7cdb304778d8","","",false, this);
 
            TaxTypeSales = RPSControlFactory.CreateRPSEnumComboBox<ArticleClassificationEntityView>("c6d38e28-de2b-455c-8da6-07667d47dee7","","",true, this);
 
            IDTaxGroupSales = RPSControlFactory.CreateRPSComboBox<ArticleClassificationEntityView>("f7b46231-2779-4c80-8d84-5f6fb5909993","","",false, this);
 
            ApplySalesDiscount = RPSControlFactory.CreateRPSCheckBox<ArticleClassificationEntityView>("7b0a4874-57d7-43f6-99da-8309cb97a28a","","",true, this);
 
            ApplySalesDiscountPP = RPSControlFactory.CreateRPSCheckBox<ArticleClassificationEntityView>("8b434e7f-77e5-4a1e-b945-f818a4d30a0b","","",true, this);
 
            ApplySalesFinancialSurcharge = RPSControlFactory.CreateRPSCheckBox<ArticleClassificationEntityView>("7c786955-5ec8-49ea-9c68-39b05b5cefa6","","",true, this);
 
            ApplySalesRetention = RPSControlFactory.CreateRPSCheckBox<ArticleClassificationEntityView>("cde762a0-6587-4721-966e-3fa31b38c65b","","",true, this);
 
            ApplyCommission = RPSControlFactory.CreateRPSCheckBox<ArticleClassificationEntityView>("047e7203-ec3e-4149-b1e3-20d3dd3cb236","","",true, this);
 
            SalesGuarantee = RPSControlFactory.CreateRPSCheckBox<ArticleClassificationEntityView>("72be9c0a-c713-4488-bb30-af0544cf6c20","","",true, this);
 
            GeneratePurchase = RPSControlFactory.CreateRPSCheckBox<ArticleClassificationEntityView>("5d39250b-be30-4d72-a0f9-07dd97b5ac2f","","",true, this);
 
            IDUnitQuantityWarehouse = RPSControlFactory.CreateRPSComboBox<ArticleClassificationEntityView>("ac3b556d-2a9c-4ebc-a121-f6ae44d93ee4","","",false, this);
 
            IDUnitPriceWarehouse = RPSControlFactory.CreateRPSComboBox<ArticleClassificationEntityView>("4632c81c-1584-4715-9e56-5f9cc88a6d6c","","",false, this);
 
            SecondUnitFixed = RPSControlFactory.CreateRPSCheckBox<ArticleClassificationEntityView>("d59b2d76-ae97-476d-ba58-1da8496e8d6d","","",true, this);
 
            SecondUnit = RPSControlFactory.CreateRPSCheckBox<ArticleClassificationEntityView>("a4f6e081-f40f-4e29-adcb-cf1710f60908","","",true, this);
 
            IDUnitSecondUnit = RPSControlFactory.CreateRPSComboBox<ArticleClassificationEntityView>("ff4f133e-3a76-4339-8a7a-c76c30bdecc9","","",false, this);
 
            AverageSecondUnitSerie = RPSControlFactory.CreateRPSCheckBox<ArticleClassificationEntityView>("656bf014-8038-49e6-af0b-ffb4bdcbb55c","","",true, this);
 
            SeriesControl = RPSControlFactory.CreateRPSCheckBox<ArticleClassificationEntityView>("2a9348db-1976-465e-87b9-7cc2e0c898ec","","",true, this);
 
            UnitarianSeries = RPSControlFactory.CreateRPSCheckBox<ArticleClassificationEntityView>("e308a19d-3923-440f-92bf-8b3ed62eddfd","","",true, this);
 
            IDCodingSerie = RPSControlFactory.CreateRPSComboBox<ArticleClassificationEntityView>("375f0a3e-833a-424f-a1f1-2445254a8724","","",false, this);
 
            LocationWarehouseControl = RPSControlFactory.CreateRPSCheckBox<ArticleClassificationEntityView>("65263308-44e0-4bcc-8cae-4e5b2e9b2ff4","","",true, this);
 
            CostMovement = RPSControlFactory.CreateRPSCheckBox<ArticleClassificationEntityView>("07006515-7e99-47d7-81c1-2938621b7087","","",true, this);
 
            IDMovementType = RPSControlFactory.CreateRPSComboBox<ArticleClassificationEntityView>("6a0bda5d-cfdc-4a7f-a2bd-41b1106aea61","","",false, this);
 
            ExpiryControl = RPSControlFactory.CreateRPSCheckBox<ArticleClassificationEntityView>("c734f648-0cdb-42c3-8bf3-5deb98fcf04e","","",true, this);
 
            StatusLot = RPSControlFactory.CreateRPSCheckBox<ArticleClassificationEntityView>("96297f41-7677-4350-9909-d49b3f7b1b75","","",true, this);
 
            IDStatusLotGroup = RPSControlFactory.CreateRPSComboBox<ArticleClassificationEntityView>("50993b1b-5c65-4b94-9f3f-e0d64d786585","","",false, this);
 
            MakeAutomaticOutput = RPSControlFactory.CreateRPSCheckBox<ArticleClassificationEntityView>("0e6153f2-ba4c-42f8-98ea-a8b57ba9081c","","",true, this);
 
            ImputationCostUpdated = RPSControlFactory.CreateRPSCheckBox<ArticleClassificationEntityView>("7c07044f-d489-48ad-9d88-9363aa8bdcfe","","",true, this);
 
            ImputationTotalQuantity = RPSControlFactory.CreateRPSCheckBox<ArticleClassificationEntityView>("c2ea5d66-b856-4533-8301-c8699258a896","","",true, this);
 
            ProjectProvisionType = RPSControlFactory.CreateRPSEnumComboBox<ArticleClassificationEntityView>("7a4422b4-8e69-454b-bdf3-e6eafc1876c2","","",true, this);
 
            MRPType = RPSControlFactory.CreateRPSEnumComboBox<ArticleClassificationEntityView>("453b93a0-7242-468b-a794-a48850a16a28","","",true, this);
 
            MRPPrevisionsOnly = RPSControlFactory.CreateRPSCheckBox<ArticleClassificationEntityView>("d1e7f135-d7d3-4582-9e4b-62287c1e1686","","",true, this);
 
            CollectionInit params_ArticleClassificationDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="10db92af-85cb-4c41-812f-f399d3a1b864",CSSSelectorGrid="",XPathGrid=""};
            ArticleClassificationDetails = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleClassificationDetailsCollectionEditor<ArticleClassificationEntityView,ArticleClassificationFeatureView>,ArticleClassificationEntityView,ArticleClassificationFeatureView>( params_ArticleClassificationDetails,this,Screen.ArticleClassificationFeatureView);
 
            CollectionInit params_ArticleClassificationFeatures = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="444da02a-85c3-45cc-bca8-d702e308fdf6",CSSSelectorGrid="",XPathGrid=""};
            ArticleClassificationFeatures = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleClassificationFeaturesCollectionEditor<ArticleClassificationEntityView,ArticleClassificationFeatureView>,ArticleClassificationEntityView,ArticleClassificationFeatureView>( params_ArticleClassificationFeatures,this,Screen.ArticleClassificationFeatureView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<ArticleClassificationEntityView>( "","ul li[rpsid='6eb9309c-7760-46a4-bead-965d096e0618']","",this);
 
            SubsidiaryCompanies = RPSControlFactory.CreateRPSSection<ArticleClassificationEntityView>( "","ul li[rpsid='68440c66-1a45-40ee-ad9e-17c1103eb578']","",this);
 
            Features = RPSControlFactory.CreateRPSSection<ArticleClassificationEntityView>( "","ul li[rpsid='9db9ee88-d3e3-495d-8ca2-88f1aaa396ee']","",this);
 

        }
        public IRPSSaveButton<ArticleClassificationEntityView> SaveButton { get; set; } 
        public IRPSButton<ArticleClassificationEntityView> DeleteButton { get; set; } 
        public IRPSButton<ArticleClassificationEntityView,ArticleClassificationCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleClassificationEntityView,ArticleClassificationCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ArticleClassificationEntityView> CodArticleClassification { get; set; } 
        public IRPSTextBox<ArticleClassificationEntityView> Description { get; set; } 
        public IRPSComboBox<ArticleClassificationEntityView> IDProductLine { get; set; } 
        public IRPSComboBox<ArticleClassificationEntityView> IDProductFamily { get; set; } 
        public IRPSComboBox<ArticleClassificationEntityView> IDProductSubFamily { get; set; } 
        public IRPSComboBox<ArticleClassificationEntityView> IDVATType { get; set; } 
        public IRPSComboBox<ArticleClassificationEntityView> IDArticleAccType { get; set; } 
        public IRPSComboBox<ArticleClassificationEntityView> CodificationType { get; set; } 
        public IRPSComboBox<ArticleClassificationEntityView> IDCodingSerieArticle { get; set; } 
        public IRPSComboBox<ArticleClassificationEntityView> Type { get; set; } 
        public IRPSComboBox<ArticleClassificationEntityView> ValuationCostType { get; set; } 
        public IRPSComboBox<ArticleClassificationEntityView> Dimension { get; set; } 
        public IRPSComboBox<ArticleClassificationEntityView> IDUnitQuantityPurchase { get; set; } 
        public IRPSComboBox<ArticleClassificationEntityView> IDUnitPricePurchase { get; set; } 
        public IRPSComboBox<ArticleClassificationEntityView> IDUnitHomogeneousPurchase { get; set; } 
        public IRPSComboBox<ArticleClassificationEntityView> TaxTypePurchase { get; set; } 
        public IRPSComboBox<ArticleClassificationEntityView> IDTaxGroupPurchase { get; set; } 
        public IRPSComboBox<ArticleClassificationEntityView> IDSupplier { get; set; } 
        public IRPSComboBox<ArticleClassificationEntityView> IDSupplierGroup { get; set; } 
        public IRPSComboBox<ArticleClassificationEntityView> QualityOnReception { get; set; } 
        public IRPSOption<ArticleClassificationEntityView> Quality { get; set; } 
        public IRPSOption<ArticleClassificationEntityView> Main { get; set; } 
        public IRPSComboBox<ArticleClassificationEntityView> IDQualityPartType { get; set; } 
        public IRPSCheckbox<ArticleClassificationEntityView> ApplyPurchaseDiscount { get; set; } 
        public IRPSCheckbox<ArticleClassificationEntityView> ApplyPurchaseDiscountPP { get; set; } 
        public IRPSCheckbox<ArticleClassificationEntityView> ApplyPurchaseFinancialSurcharge { get; set; } 
        public IRPSCheckbox<ArticleClassificationEntityView> ApplyPurchaseRetention { get; set; } 
        public IRPSComboBox<ArticleClassificationEntityView> IDUnitQuantitySales { get; set; } 
        public IRPSComboBox<ArticleClassificationEntityView> IDUnitPriceSales { get; set; } 
        public IRPSComboBox<ArticleClassificationEntityView> IDUnitHomogeneousSales { get; set; } 
        public IRPSComboBox<ArticleClassificationEntityView> TaxTypeSales { get; set; } 
        public IRPSComboBox<ArticleClassificationEntityView> IDTaxGroupSales { get; set; } 
        public IRPSCheckbox<ArticleClassificationEntityView> ApplySalesDiscount { get; set; } 
        public IRPSCheckbox<ArticleClassificationEntityView> ApplySalesDiscountPP { get; set; } 
        public IRPSCheckbox<ArticleClassificationEntityView> ApplySalesFinancialSurcharge { get; set; } 
        public IRPSCheckbox<ArticleClassificationEntityView> ApplySalesRetention { get; set; } 
        public IRPSCheckbox<ArticleClassificationEntityView> ApplyCommission { get; set; } 
        public IRPSCheckbox<ArticleClassificationEntityView> SalesGuarantee { get; set; } 
        public IRPSCheckbox<ArticleClassificationEntityView> GeneratePurchase { get; set; } 
        public IRPSComboBox<ArticleClassificationEntityView> IDUnitQuantityWarehouse { get; set; } 
        public IRPSComboBox<ArticleClassificationEntityView> IDUnitPriceWarehouse { get; set; } 
        public IRPSCheckbox<ArticleClassificationEntityView> SecondUnitFixed { get; set; } 
        public IRPSCheckbox<ArticleClassificationEntityView> SecondUnit { get; set; } 
        public IRPSComboBox<ArticleClassificationEntityView> IDUnitSecondUnit { get; set; } 
        public IRPSCheckbox<ArticleClassificationEntityView> AverageSecondUnitSerie { get; set; } 
        public IRPSCheckbox<ArticleClassificationEntityView> SeriesControl { get; set; } 
        public IRPSCheckbox<ArticleClassificationEntityView> UnitarianSeries { get; set; } 
        public IRPSComboBox<ArticleClassificationEntityView> IDCodingSerie { get; set; } 
        public IRPSCheckbox<ArticleClassificationEntityView> LocationWarehouseControl { get; set; } 
        public IRPSCheckbox<ArticleClassificationEntityView> CostMovement { get; set; } 
        public IRPSComboBox<ArticleClassificationEntityView> IDMovementType { get; set; } 
        public IRPSCheckbox<ArticleClassificationEntityView> ExpiryControl { get; set; } 
        public IRPSCheckbox<ArticleClassificationEntityView> StatusLot { get; set; } 
        public IRPSComboBox<ArticleClassificationEntityView> IDStatusLotGroup { get; set; } 
        public IRPSCheckbox<ArticleClassificationEntityView> MakeAutomaticOutput { get; set; } 
        public IRPSCheckbox<ArticleClassificationEntityView> ImputationCostUpdated { get; set; } 
        public IRPSCheckbox<ArticleClassificationEntityView> ImputationTotalQuantity { get; set; } 
        public IRPSComboBox<ArticleClassificationEntityView> ProjectProvisionType { get; set; } 
        public IRPSComboBox<ArticleClassificationEntityView> MRPType { get; set; } 
        public IRPSCheckbox<ArticleClassificationEntityView> MRPPrevisionsOnly { get; set; } 
        public ArticleClassificationDetailsCollectionEditor<ArticleClassificationEntityView,ArticleClassificationFeatureView> ArticleClassificationDetails { get; set; } 
        public ArticleClassificationFeaturesCollectionEditor<ArticleClassificationEntityView,ArticleClassificationFeatureView> ArticleClassificationFeatures { get; set; } 
        public IRPSSection<ArticleClassificationEntityView> GeneralData { get; set; } 
        public IRPSSection<ArticleClassificationEntityView> SubsidiaryCompanies { get; set; } 
        public IRPSSection<ArticleClassificationEntityView> Features { get; set; } 
        public ArticleClassification Screen { get; set; }
        public ArticleClassificationEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ArticleClassificationDetailsCollectionEditor<ArticleClassificationEntityView,ArticleClassificationFeatureView>:RPSCollectionEditor<ArticleClassificationEntityView,ArticleClassificationFeatureView> where ArticleClassificationEntityView : class, IView where ArticleClassificationFeatureView : class, IView
    {
        public  ArticleClassificationDetailsGridView<ArticleClassificationEntityView,ArticleClassificationFeatureView> GridView {get;set;}
    }
    public partial class ArticleClassificationDetailsGridView <ArticleClassificationEntityView,ArticleClassificationFeatureView> :  RPSGridView<ArticleClassificationEntityView,ArticleClassificationFeatureView> where ArticleClassificationEntityView : class, IView where ArticleClassificationFeatureView : class, IView
    {
        public ArticleClassificationDetailsGridView(ArticleClassificationEntityView currentView,ArticleClassificationFeatureView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodCompany = RPSControlFactory.CreateRPSGridComboBox<ArticleClassificationEntityView>("","#10db92af-85cb-4c41-812f-f399d3a1b864 .ag-row[role='row']@ROWINDEX [col-id='cCodCompany']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<ArticleClassificationEntityView>("","#10db92af-85cb-4c41-812f-f399d3a1b864 .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            ValuationCostType = RPSControlFactory.CreateRPSGridEnumComboBox<ArticleClassificationEntityView>("","#10db92af-85cb-4c41-812f-f399d3a1b864 .ag-row[role='row']@ROWINDEX [col-id='cValuationCostType']","",true, this.CurrentView);
 
            QualityOnReception = RPSControlFactory.CreateRPSGridEnumComboBox<ArticleClassificationEntityView>("","#10db92af-85cb-4c41-812f-f399d3a1b864 .ag-row[role='row']@ROWINDEX [col-id='cQualityOnReception']","",true, this.CurrentView);
 
            QualityMainWarehouse = RPSControlFactory.CreateRPSGridCheckBox<ArticleClassificationEntityView>("","#10db92af-85cb-4c41-812f-f399d3a1b864 .ag-row[role='row']@ROWINDEX [col-id='cQualityMainWarehouse']","",true, this.CurrentView);
 
            GeneratePurchase = RPSControlFactory.CreateRPSGridCheckBox<ArticleClassificationEntityView>("","#10db92af-85cb-4c41-812f-f399d3a1b864 .ag-row[role='row']@ROWINDEX [col-id='cGeneratePurchase']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<ArticleClassificationEntityView> CodCompany { get; set; } 
        public IRPSGridComboBox<ArticleClassificationEntityView> Type { get; set; } 
        public IRPSGridComboBox<ArticleClassificationEntityView> ValuationCostType { get; set; } 
        public IRPSGridComboBox<ArticleClassificationEntityView> QualityOnReception { get; set; } 
        public IRPSGridCheckbox<ArticleClassificationEntityView> QualityMainWarehouse { get; set; } 
        public IRPSGridCheckbox<ArticleClassificationEntityView> GeneratePurchase { get; set; } 
                     
    }
 
        public partial class ArticleClassificationFeaturesCollectionEditor<ArticleClassificationEntityView,ArticleClassificationFeatureView>:RPSCollectionEditor<ArticleClassificationEntityView,ArticleClassificationFeatureView> where ArticleClassificationEntityView : class, IView where ArticleClassificationFeatureView : class, IView
    {
        public  ArticleClassificationFeaturesGridView<ArticleClassificationEntityView,ArticleClassificationFeatureView> GridView {get;set;}
    }
    public partial class ArticleClassificationFeaturesGridView <ArticleClassificationEntityView,ArticleClassificationFeatureView> :  RPSGridView<ArticleClassificationEntityView,ArticleClassificationFeatureView> where ArticleClassificationEntityView : class, IView where ArticleClassificationFeatureView : class, IView
    {
        public ArticleClassificationFeaturesGridView(ArticleClassificationEntityView currentView,ArticleClassificationFeatureView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticleLabel = RPSControlFactory.CreateRPSGridComboBox<ArticleClassificationEntityView>("","#444da02a-85c3-45cc-bca8-d702e308fdf6 .ag-row[role='row']@ROWINDEX [col-id='cIDArticleLabel']","",true, this.CurrentView);
 
            Value = RPSControlFactory.CreateRPSGridTextBox<ArticleClassificationEntityView>("","#444da02a-85c3-45cc-bca8-d702e308fdf6 .ag-row[role='row']@ROWINDEX [col-id='cValue']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ArticleClassificationEntityView> IDArticleLabel { get; set; } 
        public IRPSGridTextBox<ArticleClassificationEntityView> Value { get; set; } 
                     
    }
 
    }
  
            
    public partial class ArticleClassificationFeatureView : View
    {
        public ArticleClassificationFeatureView(ArticleClassification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ArticleClassificationFeatureView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ArticleClassificationFeatureView,ArticleClassificationEntityView>( this,Screen.ArticleClassificationEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ArticleClassificationFeatureView,ArticleClassificationEntityView>( this,Screen.ArticleClassificationEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ArticleClassificationFeatureView,ArticleClassificationEntityView>( this,Screen.ArticleClassificationEntityView);
 
            IDArticleLabel = RPSControlFactory.CreateRPSComboBox<ArticleClassificationFeatureView>("849399ef-c330-46f9-991a-e1f8c697b640","","",true, this);
 
            ValueString = RPSControlFactory.CreateRPSTextBox<ArticleClassificationFeatureView>("f0c6f4a4-e5b6-42e1-97e8-083947e4c865","","",false, this);
 
            ValueInt = RPSControlFactory.CreateRPSFormattedTextBox<ArticleClassificationFeatureView>("6465e86b-365b-461f-85af-d099213877ce","","",false, this);
 
            ValueDecimal = RPSControlFactory.CreateRPSFormattedTextBox<ArticleClassificationFeatureView>("9bef94e9-c1ca-4ee7-a9ae-2052c7665cd5","","",false, this);
 
            ValueDate = RPSControlFactory.CreateRPSTextBox<ArticleClassificationFeatureView>("fb17c655-5e0e-4751-a992-8cb26ab6d5ba","","",false, this);
 
            ValueTable = RPSControlFactory.CreateRPSEnumComboBox<ArticleClassificationFeatureView>("2e1225de-b328-4ac9-b7b1-65a7bcc504ef","","",false, this);
 

        }
        public IRPSButton<ArticleClassificationFeatureView> DeleteButton { get; set; } 
        public IRPSButton<ArticleClassificationFeatureView,ArticleClassificationEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleClassificationFeatureView,ArticleClassificationEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ArticleClassificationFeatureView,ArticleClassificationEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ArticleClassificationFeatureView> IDArticleLabel { get; set; } 
        public IRPSTextBox<ArticleClassificationFeatureView> ValueString { get; set; } 
        public IRPSTextBox<ArticleClassificationFeatureView> ValueInt { get; set; } 
        public IRPSTextBox<ArticleClassificationFeatureView> ValueDecimal { get; set; } 
        public IRPSTextBox<ArticleClassificationFeatureView> ValueDate { get; set; } 
        public IRPSComboBox<ArticleClassificationFeatureView> ValueTable { get; set; } 
        public ArticleClassification Screen { get; set; }
        public ArticleClassificationFeatureView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ArticleClassificationDetailView : View
    {
        public ArticleClassificationDetailView(ArticleClassification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ArticleClassificationDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ArticleClassificationDetailView,ArticleClassificationEntityView>( this,Screen.ArticleClassificationEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ArticleClassificationDetailView,ArticleClassificationEntityView>( this,Screen.ArticleClassificationEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ArticleClassificationDetailView,ArticleClassificationEntityView>( this,Screen.ArticleClassificationEntityView);
 
            CodCompany = RPSControlFactory.CreateRPSComboBox<ArticleClassificationDetailView>("ce74e75c-8855-4ae5-a942-c2c14ae2a52c","","",true, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<ArticleClassificationDetailView>("42c6b881-be27-409b-9beb-ac090cbed003","","",true, this);
 
            ValuationCostType = RPSControlFactory.CreateRPSEnumComboBox<ArticleClassificationDetailView>("ad64beb8-6587-42bd-adc1-aa255d63a53f","","",true, this);
 
            IDVATType = RPSControlFactory.CreateRPSComboBox<ArticleClassificationDetailView>("a642533c-7305-4a42-b126-81b0d83ccb04","","",false, this);
 
            IDArticleAccType = RPSControlFactory.CreateRPSComboBox<ArticleClassificationDetailView>("c5a403c5-091a-4d71-a5be-8be7384fbc4d","","",false, this);
 
            IDCodingSerieArticle = RPSControlFactory.CreateRPSComboBox<ArticleClassificationDetailView>("44585c5a-cce7-45b8-8279-aa80153d4dbf","","",false, this);
 
            TaxTypeSales = RPSControlFactory.CreateRPSEnumComboBox<ArticleClassificationDetailView>("4f33cbce-5141-4616-98a7-fe0c22d828d5","","",true, this);
 
            IDTaxGroupSales = RPSControlFactory.CreateRPSComboBox<ArticleClassificationDetailView>("111204f0-6c7b-4fc4-a637-cf1aff342c2a","","",false, this);
 
            SalesGuarantee = RPSControlFactory.CreateRPSCheckBox<ArticleClassificationDetailView>("b2c8669d-0fb7-429d-b0fa-9b902b776b1b","","",true, this);
 
            GeneratePurchase = RPSControlFactory.CreateRPSCheckBox<ArticleClassificationDetailView>("da179473-6dd7-41ac-8294-aa122ab1c6d9","","",true, this);
 
            TaxTypePurchase = RPSControlFactory.CreateRPSEnumComboBox<ArticleClassificationDetailView>("3955b7aa-0692-47d3-9b78-6a0453ee570a","","",true, this);
 
            IDTaxGroupPurchase = RPSControlFactory.CreateRPSComboBox<ArticleClassificationDetailView>("4d440333-4cb1-4274-bf59-c09f1d07c1ea","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<ArticleClassificationDetailView>("2f45b555-7740-456e-8ae6-b0d609efabad","","",false, this);
 
            IDSupplierGroup = RPSControlFactory.CreateRPSComboBox<ArticleClassificationDetailView>("0ac7947a-e985-415a-8898-7ade70fe89d2","","",false, this);
 
            QualityOnReception = RPSControlFactory.CreateRPSEnumComboBox<ArticleClassificationDetailView>("c9b64dea-12e2-4532-881f-26c40de5603b","","",true, this);
 
            Quality = RPSControlFactory.CreateRPSOption<ArticleClassificationDetailView>( "848478e4-4b3d-4ce5-ac43-538cec7b8ead","","",this);
 
            Main = RPSControlFactory.CreateRPSOption<ArticleClassificationDetailView>( "496733e9-b6bc-4011-b622-76985755d155","","",this);
 
            IDQualityPartType = RPSControlFactory.CreateRPSComboBox<ArticleClassificationDetailView>("e6323cee-dd9b-4661-88d4-ce39478e5cde","","",false, this);
 
            CostMovement = RPSControlFactory.CreateRPSCheckBox<ArticleClassificationDetailView>("051a2545-0ee8-41fa-ad62-512a59e310f0","","",true, this);
 
            IDMovementType = RPSControlFactory.CreateRPSComboBox<ArticleClassificationDetailView>("dc6340ba-6559-47a3-9bfd-4ce20d6854f2","","",false, this);
 
            IDCodingSerie = RPSControlFactory.CreateRPSComboBox<ArticleClassificationDetailView>("89648e12-1760-4086-a748-7c64d743d5f6","","",false, this);
 
            MRPType = RPSControlFactory.CreateRPSEnumComboBox<ArticleClassificationDetailView>("336d7ad2-be2a-4ac9-afd5-907c92ab3a6b","","",true, this);
 
            ProjectProvisionType = RPSControlFactory.CreateRPSEnumComboBox<ArticleClassificationDetailView>("38db4ad1-4dcf-40c9-a37c-f7f395a4a865","","",true, this);
 

        }
        public IRPSButton<ArticleClassificationDetailView> DeleteButton { get; set; } 
        public IRPSButton<ArticleClassificationDetailView,ArticleClassificationEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleClassificationDetailView,ArticleClassificationEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ArticleClassificationDetailView,ArticleClassificationEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ArticleClassificationDetailView> CodCompany { get; set; } 
        public IRPSComboBox<ArticleClassificationDetailView> Type { get; set; } 
        public IRPSComboBox<ArticleClassificationDetailView> ValuationCostType { get; set; } 
        public IRPSComboBox<ArticleClassificationDetailView> IDVATType { get; set; } 
        public IRPSComboBox<ArticleClassificationDetailView> IDArticleAccType { get; set; } 
        public IRPSComboBox<ArticleClassificationDetailView> IDCodingSerieArticle { get; set; } 
        public IRPSComboBox<ArticleClassificationDetailView> TaxTypeSales { get; set; } 
        public IRPSComboBox<ArticleClassificationDetailView> IDTaxGroupSales { get; set; } 
        public IRPSCheckbox<ArticleClassificationDetailView> SalesGuarantee { get; set; } 
        public IRPSCheckbox<ArticleClassificationDetailView> GeneratePurchase { get; set; } 
        public IRPSComboBox<ArticleClassificationDetailView> TaxTypePurchase { get; set; } 
        public IRPSComboBox<ArticleClassificationDetailView> IDTaxGroupPurchase { get; set; } 
        public IRPSComboBox<ArticleClassificationDetailView> IDSupplier { get; set; } 
        public IRPSComboBox<ArticleClassificationDetailView> IDSupplierGroup { get; set; } 
        public IRPSComboBox<ArticleClassificationDetailView> QualityOnReception { get; set; } 
        public IRPSOption<ArticleClassificationDetailView> Quality { get; set; } 
        public IRPSOption<ArticleClassificationDetailView> Main { get; set; } 
        public IRPSComboBox<ArticleClassificationDetailView> IDQualityPartType { get; set; } 
        public IRPSCheckbox<ArticleClassificationDetailView> CostMovement { get; set; } 
        public IRPSComboBox<ArticleClassificationDetailView> IDMovementType { get; set; } 
        public IRPSComboBox<ArticleClassificationDetailView> IDCodingSerie { get; set; } 
        public IRPSComboBox<ArticleClassificationDetailView> MRPType { get; set; } 
        public IRPSComboBox<ArticleClassificationDetailView> ProjectProvisionType { get; set; } 
        public ArticleClassification Screen { get; set; }
        public ArticleClassificationDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}