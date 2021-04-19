    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.Article
{
    //RPS VERSION 1.0.0.0
    public partial class Article:Screen
    {
        public Article():base()
        {
            this.URL = "sales.article";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ArticleCollectionView  = new ArticleCollectionView(this); 
            ArticleEntityView  = new ArticleEntityView(this); 
            ArticleConvertMeasureUnitView  = new ArticleConvertMeasureUnitView(this); 
            ArticleDetailView  = new ArticleDetailView(this); 
            ArticleByLangView  = new ArticleByLangView(this); 
            ArticleAlternativeSalesSLView  = new ArticleAlternativeSalesSLView(this); 
            ArticleCollectionView.InitializeControls(); 
            ArticleEntityView.InitializeControls(); 
            ArticleConvertMeasureUnitView.InitializeControls(); 
            ArticleDetailView.InitializeControls(); 
            ArticleByLangView.InitializeControls(); 
            ArticleAlternativeSalesSLView.InitializeControls(); 
           
        }
      
            public ArticleCollectionView ArticleCollectionView {get; set; } 
            public ArticleEntityView ArticleEntityView {get; set; } 
            public ArticleConvertMeasureUnitView ArticleConvertMeasureUnitView {get; set; } 
            public ArticleDetailView ArticleDetailView {get; set; } 
            public ArticleByLangView ArticleByLangView {get; set; } 
            public ArticleAlternativeSalesSLView ArticleAlternativeSalesSLView {get; set; } 
    }
            
    public partial class ArticleCollectionView : View
    {
        public ArticleCollectionView(Article screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ArticleCollectionView,ArticleEntityView>( this,Screen.ArticleEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "1579c435-2d37-4b34-aaad-8f2279035297",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ArticleCollectionView,ArticleEntityView>( params_MainConsult,this,Screen.ArticleEntityView);
 

        }
        public IRPSButton<ArticleCollectionView,ArticleEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ArticleCollectionView,ArticleEntityView> MainConsult { get; set; } 
        public Article Screen { get; set; }
        public ArticleCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ArticleEntityView : View
    {
        public ArticleEntityView(Article screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ArticleEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ArticleEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ArticleEntityView,ArticleCollectionView>( this,Screen.ArticleCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ArticleEntityView,ArticleCollectionView>( this,Screen.ArticleCollectionView);
 
            CodArticle = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("1e3e1974-5d63-486d-a085-4a487849f513","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("d35d80c7-ecbb-46be-9d9f-f34498f6122e","","",false, this);
 
            IDProductLine = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("9366db5a-cea1-4af2-93d9-7a623a2d0de7","","",false, this);
 
            IDProductFamily = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("71e3acb4-c14e-44da-8367-08b2b67c3a2e","","",false, this);
 
            IDProductSubFamily = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("ebf52aa1-5a36-48ca-ad91-6140eb716edc","","",false, this);
 
            InactiveDate = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("27f9d052-262c-4bd6-b598-aa1058fd0aad","","",false, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<ArticleEntityView>("eefc36f1-d96f-4790-ae02-9104797e1655","","",true, this);
 
            ValuationCostType = RPSControlFactory.CreateRPSEnumComboBox<ArticleEntityView>("43e38100-b6ae-480e-b517-bac697bd112b","","",true, this);
 
            Dimension = RPSControlFactory.CreateRPSEnumComboBox<ArticleEntityView>("d3b26c6c-5930-4f14-a7a9-3bed2534ad20","","",true, this);
 
            SalesKit = RPSControlFactory.CreateRPSCheckBox<ArticleEntityView>("e28c917b-b796-4e5b-bcea-682ed67a8758","","",true, this);
 
            BlockedSales = RPSControlFactory.CreateRPSCheckBox<ArticleEntityView>("8fba3d07-c43b-4864-8fb6-4441794431e5","","",true, this);
 
            CodArticlePrevious = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("2d0fc36b-f316-4dc5-9b85-3015a43e993c","","",false, this);
 
            GeneratePurchase = RPSControlFactory.CreateRPSCheckBox<ArticleEntityView>("ff9a9a2d-78ce-4aac-b848-1e24aebcce9c","","",true, this);
 
            StandardPrice = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("fe395bf1-8f15-4a59-8d05-fa3b818de9b5","","",true, this);
 
            NetWeight = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("647883f8-0311-4b3d-888c-6e7d4d3308a1","","",true, this);
 
            GrossWeight = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("db2dc53b-1cfc-4888-b9a8-94e850e29923","","",true, this);
 
            CustomerReferenceControl = RPSControlFactory.CreateRPSCheckBox<ArticleEntityView>("81f91bd0-4799-4dad-9c16-c0a5c671771d","","",true, this);
 
            MatchCode = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("e4f6e10c-6da3-4867-a5d5-535fc4244c1e","","",false, this);
 
            PlanNumber = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("130276c2-85bb-4e59-8b15-c17146fc6700","","",false, this);
 
            IDUnitQuantitySales = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("4bc3538b-bba5-42ad-921d-e2a8cda1582c","","",true, this);
 
            IDUnitPriceSales = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("08460753-b0f8-4a97-b223-ddc2f233fa7f","","",true, this);
 
            IDUnitHomogeneousSales = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("1201182e-625c-455a-a74c-3f0c32cbfbce","","",true, this);
 
            SalesLot = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("6c9da1d4-dc27-4b35-a1c9-d3f01db06bfa","","",true, this);
 
            MinimumSalesLot = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("28b894ad-cf9b-4bd8-ac32-590f371013d9","","",true, this);
 
            IDVATType = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("1ea7fcbe-25b5-44e8-8e94-49b6e1d93675","","",true, this);
 
            TaxTypeSales = RPSControlFactory.CreateRPSEnumComboBox<ArticleEntityView>("f44c0686-ae09-4482-bfbd-2078092db159","","",true, this);
 
            IDTaxGroupSales = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("c266658c-e7b3-416c-aca1-16f3ae999b13","","",false, this);
 
            IDArticleAccType = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("2700e7d4-f7a7-4292-8453-273332ea910c","","",false, this);
 
            IDSiteOutput = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("f5cdd240-a629-45f6-99a0-b4261f6e7f3e","","",false, this);
 
            IDOutputWarehouse = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("65e05c0b-6fad-4137-b60b-637eeb93bf39","","",false, this);
 
            IDSiteEntry = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("270669c0-41a2-45ab-aad5-06aa41ce72b9","","",false, this);
 
            IDEntryWarehouse = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("fb33af55-7449-40ff-ab8c-b0bef346e144","","",false, this);
 
            ApplySalesDiscount = RPSControlFactory.CreateRPSCheckBox<ArticleEntityView>("5b7201b9-f362-40b4-a600-3fb30203c858","","",true, this);
 
            ApplySalesDiscountPP = RPSControlFactory.CreateRPSCheckBox<ArticleEntityView>("3fc6d4a4-4dd2-472e-a0a1-dc9a850e9e4a","","",true, this);
 
            ApplySalesFinancialSurcharge = RPSControlFactory.CreateRPSCheckBox<ArticleEntityView>("0d90e6b2-11f6-4722-b225-7ea85c5abf29","","",true, this);
 
            ApplySalesRetention = RPSControlFactory.CreateRPSCheckBox<ArticleEntityView>("b6ece066-1599-4db6-a1e2-a194fd21ef49","","",true, this);
 
            ApplyCommission = RPSControlFactory.CreateRPSCheckBox<ArticleEntityView>("6860e442-8f04-4c63-ac7f-d352ca71414a","","",true, this);
 
            ProvisionType = RPSControlFactory.CreateRPSEnumComboBox<ArticleEntityView>("1886970b-8366-4df7-bde0-6d661c9f1349","","",true, this);
 
            IDSiteProvision = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("08f48774-8cbf-428d-b412-68a7fc2a64e0","","",false, this);
 
            IDWarehouseProvision = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("778c5a31-0a0b-4c79-9be3-d357fe4ad3e2","","",false, this);
 
            StatisticsCode = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("b978d75b-1145-469b-8f47-e2d8f4987998","","",false, this);
 
            CodCountryOfOrigin = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("374aa8f7-a567-4d72-a6f6-af004a00559f","","",false, this);
 
            SupplemetUnit = RPSControlFactory.CreateRPSCheckBox<ArticleEntityView>("d292695d-e8bf-4a07-895d-8b2538883728","","",true, this);
 
            IDUnitSupplement = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("54082fd1-d49f-48e2-9a06-c5c117b6e547","","",false, this);
 
            IDProductionUnit = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("010e32f0-a0ec-4090-a708-6b809dfa090c","","",false, this);
 
            EffortQuantity = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("4554f4c7-194e-4a37-b823-fb233834a6d2","","",false, this);
 
            StartingMarginDays = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("935446cf-3a89-4e31-aadd-5fa7f4e4064c","","",false, this);
 
            EndingMarginDays = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("90a0cb56-be6a-4829-b488-67eb5e723819","","",false, this);
 
            TechnicalDescription = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("7eea638e-44f6-46c5-929b-4f9ee97ec804","","",false, this);
 
            Notes = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("64ff23d7-976d-4c05-8590-b6297d362ca4","","",false, this);
 
            CollectionInit params_ArticleConvertMeasureUnits = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="2086bca0-37f5-41f3-a3a6-31adff77cf56",CSSSelectorGrid="",XPathGrid=""};
            ArticleConvertMeasureUnits = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleConvertMeasureUnitsCollectionEditor<ArticleEntityView,ArticleByLangView>,ArticleEntityView,ArticleByLangView>( params_ArticleConvertMeasureUnits,this,Screen.ArticleByLangView);
 
            CollectionInit params_ArticleAlternativeSalesSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1f8fbaa7-205f-41af-9323-d19016db42cc",CSSSelectorGrid="",XPathGrid=""};
            ArticleAlternativeSalesSLs = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleAlternativeSalesSLsCollectionEditor<ArticleEntityView,ArticleByLangView>,ArticleEntityView,ArticleByLangView>( params_ArticleAlternativeSalesSLs,this,Screen.ArticleByLangView);
 
            CollectionInit params_ArticleByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6217efab-e86e-4331-bf3a-2a60faba6798",CSSSelectorGrid="",XPathGrid=""};
            ArticleByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleByLangsCollectionEditor<ArticleEntityView,ArticleByLangView>,ArticleEntityView,ArticleByLangView>( params_ArticleByLangs,this,Screen.ArticleByLangView);
 
            CollectionInit params_ArticleDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c63b7095-b600-4814-8509-ff201acb48d7",CSSSelectorGrid="",XPathGrid=""};
            ArticleDetails = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleDetailsCollectionEditor<ArticleEntityView,ArticleByLangView>,ArticleEntityView,ArticleByLangView>( params_ArticleDetails,this,Screen.ArticleByLangView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='beca9523-9df3-49a5-9a98-cb190af5d190']","",this);
 
            TechnnicalDescription = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='9fbfc281-7e83-453d-b97e-54a19fd21fbd']","",this);
 
            UnitOfMeasure = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='2bcbc423-1241-4d34-9238-fb705ffe4c22']","",this);
 
            Alternative = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='a3c14b6c-1b2e-4bf8-8fc6-22384901b560']","",this);
 
            ArticleByLang = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='e89ce6e1-3167-4bc9-9364-899e921e875e']","",this);
 
            Subsidiary = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='54af837e-c120-428c-a436-d33d62fb4577']","",this);
 
            Notes1 = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='12442f02-1450-42d1-ba6b-7446ef505157']","",this);
 

        }
        public IRPSSaveButton<ArticleEntityView> SaveButton { get; set; } 
        public IRPSButton<ArticleEntityView> DeleteButton { get; set; } 
        public IRPSButton<ArticleEntityView,ArticleCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleEntityView,ArticleCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ArticleEntityView> CodArticle { get; set; } 
        public IRPSTextBox<ArticleEntityView> Description { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDProductLine { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDProductFamily { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDProductSubFamily { get; set; } 
        public IRPSTextBox<ArticleEntityView> InactiveDate { get; set; } 
        public IRPSComboBox<ArticleEntityView> Type { get; set; } 
        public IRPSComboBox<ArticleEntityView> ValuationCostType { get; set; } 
        public IRPSComboBox<ArticleEntityView> Dimension { get; set; } 
        public IRPSCheckbox<ArticleEntityView> SalesKit { get; set; } 
        public IRPSCheckbox<ArticleEntityView> BlockedSales { get; set; } 
        public IRPSTextBox<ArticleEntityView> CodArticlePrevious { get; set; } 
        public IRPSCheckbox<ArticleEntityView> GeneratePurchase { get; set; } 
        public IRPSTextBox<ArticleEntityView> StandardPrice { get; set; } 
        public IRPSTextBox<ArticleEntityView> NetWeight { get; set; } 
        public IRPSTextBox<ArticleEntityView> GrossWeight { get; set; } 
        public IRPSCheckbox<ArticleEntityView> CustomerReferenceControl { get; set; } 
        public IRPSTextBox<ArticleEntityView> MatchCode { get; set; } 
        public IRPSTextBox<ArticleEntityView> PlanNumber { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDUnitQuantitySales { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDUnitPriceSales { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDUnitHomogeneousSales { get; set; } 
        public IRPSTextBox<ArticleEntityView> SalesLot { get; set; } 
        public IRPSTextBox<ArticleEntityView> MinimumSalesLot { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDVATType { get; set; } 
        public IRPSComboBox<ArticleEntityView> TaxTypeSales { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDTaxGroupSales { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDArticleAccType { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDSiteOutput { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDOutputWarehouse { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDSiteEntry { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDEntryWarehouse { get; set; } 
        public IRPSCheckbox<ArticleEntityView> ApplySalesDiscount { get; set; } 
        public IRPSCheckbox<ArticleEntityView> ApplySalesDiscountPP { get; set; } 
        public IRPSCheckbox<ArticleEntityView> ApplySalesFinancialSurcharge { get; set; } 
        public IRPSCheckbox<ArticleEntityView> ApplySalesRetention { get; set; } 
        public IRPSCheckbox<ArticleEntityView> ApplyCommission { get; set; } 
        public IRPSComboBox<ArticleEntityView> ProvisionType { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDSiteProvision { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDWarehouseProvision { get; set; } 
        public IRPSTextBox<ArticleEntityView> StatisticsCode { get; set; } 
        public IRPSComboBox<ArticleEntityView> CodCountryOfOrigin { get; set; } 
        public IRPSCheckbox<ArticleEntityView> SupplemetUnit { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDUnitSupplement { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDProductionUnit { get; set; } 
        public IRPSTextBox<ArticleEntityView> EffortQuantity { get; set; } 
        public IRPSTextBox<ArticleEntityView> StartingMarginDays { get; set; } 
        public IRPSTextBox<ArticleEntityView> EndingMarginDays { get; set; } 
        public IRPSTextBox<ArticleEntityView> TechnicalDescription { get; set; } 
        public IRPSTextBox<ArticleEntityView> Notes { get; set; } 
        public ArticleConvertMeasureUnitsCollectionEditor<ArticleEntityView,ArticleByLangView> ArticleConvertMeasureUnits { get; set; } 
        public ArticleAlternativeSalesSLsCollectionEditor<ArticleEntityView,ArticleByLangView> ArticleAlternativeSalesSLs { get; set; } 
        public ArticleByLangsCollectionEditor<ArticleEntityView,ArticleByLangView> ArticleByLangs { get; set; } 
        public ArticleDetailsCollectionEditor<ArticleEntityView,ArticleByLangView> ArticleDetails { get; set; } 
        public IRPSSection<ArticleEntityView> GeneralData { get; set; } 
        public IRPSSection<ArticleEntityView> TechnnicalDescription { get; set; } 
        public IRPSSection<ArticleEntityView> UnitOfMeasure { get; set; } 
        public IRPSSection<ArticleEntityView> Alternative { get; set; } 
        public IRPSSection<ArticleEntityView> ArticleByLang { get; set; } 
        public IRPSSection<ArticleEntityView> Subsidiary { get; set; } 
        public IRPSSection<ArticleEntityView> Notes1 { get; set; } 
        public Article Screen { get; set; }
        public ArticleEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ArticleConvertMeasureUnitsCollectionEditor<ArticleEntityView,ArticleByLangView>:RPSCollectionEditor<ArticleEntityView,ArticleByLangView> where ArticleEntityView : class, IView where ArticleByLangView : class, IView
    {
        public  ArticleConvertMeasureUnitsGridView<ArticleEntityView,ArticleByLangView> GridView {get;set;}
    }
    public partial class ArticleConvertMeasureUnitsGridView <ArticleEntityView,ArticleByLangView> :  RPSGridView<ArticleEntityView,ArticleByLangView> where ArticleEntityView : class, IView where ArticleByLangView : class, IView
    {
        public ArticleConvertMeasureUnitsGridView(ArticleEntityView currentView,ArticleByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDUnitSource = RPSControlFactory.CreateRPSGridComboBox<ArticleEntityView>("","#2086bca0-37f5-41f3-a3a6-31adff77cf56 .ag-row[role='row']@ROWINDEX [col-id='cIDUnitSource']","",true, this.CurrentView);
 
            MultiplyOperator = RPSControlFactory.CreateRPSGridEnumComboBox<ArticleEntityView>("","#2086bca0-37f5-41f3-a3a6-31adff77cf56 .ag-row[role='row']@ROWINDEX [col-id='cMultiplyOperator']","",true, this.CurrentView);
 
            MultiplyFactor = RPSControlFactory.CreateRPSGridFormattedTextBox<ArticleEntityView>("","#2086bca0-37f5-41f3-a3a6-31adff77cf56 .ag-row[role='row']@ROWINDEX [col-id='cMultiplyFactor']","",true, this.CurrentView);
 
            SumOperator = RPSControlFactory.CreateRPSGridEnumComboBox<ArticleEntityView>("","#2086bca0-37f5-41f3-a3a6-31adff77cf56 .ag-row[role='row']@ROWINDEX [col-id='cSumOperator']","",true, this.CurrentView);
 
            SumFactor = RPSControlFactory.CreateRPSGridTextBox<ArticleEntityView>("","#2086bca0-37f5-41f3-a3a6-31adff77cf56 .ag-row[role='row']@ROWINDEX [col-id='cSumFactor']","",true, this.CurrentView);
 
            IDUnitDestination = RPSControlFactory.CreateRPSGridComboBox<ArticleEntityView>("","#2086bca0-37f5-41f3-a3a6-31adff77cf56 .ag-row[role='row']@ROWINDEX [col-id='cIDUnitDestination']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<ArticleEntityView> IDUnitSource { get; set; } 
        public IRPSGridComboBox<ArticleEntityView> MultiplyOperator { get; set; } 
        public IRPSGridTextBox<ArticleEntityView> MultiplyFactor { get; set; } 
        public IRPSGridComboBox<ArticleEntityView> SumOperator { get; set; } 
        public IRPSGridTextBox<ArticleEntityView> SumFactor { get; set; } 
        public IRPSGridComboBox<ArticleEntityView> IDUnitDestination { get; set; } 
                     
    }
 
        public partial class ArticleAlternativeSalesSLsCollectionEditor<ArticleEntityView,ArticleByLangView>:RPSCollectionEditor<ArticleEntityView,ArticleByLangView> where ArticleEntityView : class, IView where ArticleByLangView : class, IView
    {
        public  ArticleAlternativeSalesSLsGridView<ArticleEntityView,ArticleByLangView> GridView {get;set;}
    }
    public partial class ArticleAlternativeSalesSLsGridView <ArticleEntityView,ArticleByLangView> :  RPSGridView<ArticleEntityView,ArticleByLangView> where ArticleEntityView : class, IView where ArticleByLangView : class, IView
    {
        public ArticleAlternativeSalesSLsGridView(ArticleEntityView currentView,ArticleByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticleEquivalent = RPSControlFactory.CreateRPSGridComboBox<ArticleEntityView>("","#1f8fbaa7-205f-41af-9323-d19016db42cc .ag-row[role='row']@ROWINDEX [col-id='cIDArticleEquivalent']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<ArticleEntityView> IDArticleEquivalent { get; set; } 
                     
    }
 
        public partial class ArticleByLangsCollectionEditor<ArticleEntityView,ArticleByLangView>:RPSCollectionEditor<ArticleEntityView,ArticleByLangView> where ArticleEntityView : class, IView where ArticleByLangView : class, IView
    {
        public  ArticleByLangsGridView<ArticleEntityView,ArticleByLangView> GridView {get;set;}
    }
    public partial class ArticleByLangsGridView <ArticleEntityView,ArticleByLangView> :  RPSGridView<ArticleEntityView,ArticleByLangView> where ArticleEntityView : class, IView where ArticleByLangView : class, IView
    {
        public ArticleByLangsGridView(ArticleEntityView currentView,ArticleByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<ArticleEntityView>("","#6217efab-e86e-4331-bf3a-2a60faba6798 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ArticleEntityView>("","#6217efab-e86e-4331-bf3a-2a60faba6798 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            TechnicalDescription = RPSControlFactory.CreateRPSGridMemoTextBox<ArticleEntityView>("","#6217efab-e86e-4331-bf3a-2a60faba6798 .ag-row[role='row']@ROWINDEX [col-id='cTechnicalDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ArticleEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<ArticleEntityView> Description { get; set; } 
        public IRPSGridTextBox<ArticleEntityView> TechnicalDescription { get; set; } 
                     
    }
 
        public partial class ArticleDetailsCollectionEditor<ArticleEntityView,ArticleByLangView>:RPSCollectionEditor<ArticleEntityView,ArticleByLangView> where ArticleEntityView : class, IView where ArticleByLangView : class, IView
    {
        public  ArticleDetailsGridView<ArticleEntityView,ArticleByLangView> GridView {get;set;}
    }
    public partial class ArticleDetailsGridView <ArticleEntityView,ArticleByLangView> :  RPSGridView<ArticleEntityView,ArticleByLangView> where ArticleEntityView : class, IView where ArticleByLangView : class, IView
    {
        public ArticleDetailsGridView(ArticleEntityView currentView,ArticleByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodCompany = RPSControlFactory.CreateRPSGridComboBox<ArticleEntityView>("","#c63b7095-b600-4814-8509-ff201acb48d7 .ag-row[role='row']@ROWINDEX [col-id='cCodCompany']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<ArticleEntityView>("","#c63b7095-b600-4814-8509-ff201acb48d7 .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            ValuationCostType = RPSControlFactory.CreateRPSGridEnumComboBox<ArticleEntityView>("","#c63b7095-b600-4814-8509-ff201acb48d7 .ag-row[role='row']@ROWINDEX [col-id='cValuationCostType']","",true, this.CurrentView);
 
            BlockedSales = RPSControlFactory.CreateRPSGridCheckBox<ArticleEntityView>("","#c63b7095-b600-4814-8509-ff201acb48d7 .ag-row[role='row']@ROWINDEX [col-id='cBlockedSales']","",true, this.CurrentView);
 
            SalesKit = RPSControlFactory.CreateRPSGridCheckBox<ArticleEntityView>("","#c63b7095-b600-4814-8509-ff201acb48d7 .ag-row[role='row']@ROWINDEX [col-id='cSalesKit']","",true, this.CurrentView);
 
            GeneratePurchase = RPSControlFactory.CreateRPSGridCheckBox<ArticleEntityView>("","#c63b7095-b600-4814-8509-ff201acb48d7 .ag-row[role='row']@ROWINDEX [col-id='cGeneratePurchase']","",true, this.CurrentView);
 
            PlanNumber = RPSControlFactory.CreateRPSGridTextBox<ArticleEntityView>("","#c63b7095-b600-4814-8509-ff201acb48d7 .ag-row[role='row']@ROWINDEX [col-id='cPlanNumber']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ArticleEntityView> CodCompany { get; set; } 
        public IRPSGridComboBox<ArticleEntityView> Type { get; set; } 
        public IRPSGridComboBox<ArticleEntityView> ValuationCostType { get; set; } 
        public IRPSGridCheckbox<ArticleEntityView> BlockedSales { get; set; } 
        public IRPSGridCheckbox<ArticleEntityView> SalesKit { get; set; } 
        public IRPSGridCheckbox<ArticleEntityView> GeneratePurchase { get; set; } 
        public IRPSGridTextBox<ArticleEntityView> PlanNumber { get; set; } 
                     
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
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ArticleConvertMeasureUnitView,ArticleEntityView>( this,Screen.ArticleEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ArticleConvertMeasureUnitView,ArticleEntityView>( this,Screen.ArticleEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ArticleConvertMeasureUnitView,ArticleEntityView>( this,Screen.ArticleEntityView);
 
            Formulated = RPSControlFactory.CreateRPSOption<ArticleConvertMeasureUnitView>( "32755d42-0fd1-4fc1-9733-a96b3dcb9f76","","",this);
 
            IDUnitSource = RPSControlFactory.CreateRPSComboBox<ArticleConvertMeasureUnitView>("7402a4cd-76f2-42de-8490-8b569cd59ab6","","",true, this);
 
            MultiplyOperator = RPSControlFactory.CreateRPSEnumComboBox<ArticleConvertMeasureUnitView>("08d5b9b0-18f5-419c-9154-7304f4777381","","",true, this);
 
            MultiplyFactor = RPSControlFactory.CreateRPSFormattedTextBox<ArticleConvertMeasureUnitView>("eaaf80c6-9895-43b5-ad1c-b8dd4006a625","","",true, this);
 
            IDUnitDestination = RPSControlFactory.CreateRPSComboBox<ArticleConvertMeasureUnitView>("414b6ed0-dd84-4e40-bbb3-3cf46179deba","","",true, this);
 
            Second_Unit = RPSControlFactory.CreateRPSOption<ArticleConvertMeasureUnitView>( "0df6714c-7d8b-48fe-868c-e9497c37cdb3","","",this);
 
            SumOperator = RPSControlFactory.CreateRPSEnumComboBox<ArticleConvertMeasureUnitView>("fd855479-6fc4-4fb8-8001-154cd610e55f","","",true, this);
 
            SumFactor = RPSControlFactory.CreateRPSTextBox<ArticleConvertMeasureUnitView>("f855d62a-8190-4957-99a4-a0611ef8396c","","",true, this);
 

        }
        public IRPSButton<ArticleConvertMeasureUnitView> DeleteButton { get; set; } 
        public IRPSButton<ArticleConvertMeasureUnitView,ArticleEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleConvertMeasureUnitView,ArticleEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ArticleConvertMeasureUnitView,ArticleEntityView> AcceptButton { get; set; } 
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
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ArticleDetailView,ArticleEntityView>( this,Screen.ArticleEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ArticleDetailView,ArticleEntityView>( this,Screen.ArticleEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ArticleDetailView,ArticleEntityView>( this,Screen.ArticleEntityView);
 
            CodCompany = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("435325e3-79fb-4cdd-abe4-89397b5aeece","","",true, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<ArticleDetailView>("1df717ca-6da0-4bd2-ac33-5d6bb54c374f","","",true, this);
 
            ValuationCostType = RPSControlFactory.CreateRPSEnumComboBox<ArticleDetailView>("268a4449-6d3d-42ad-bd06-70c94096cca0","","",true, this);
 
            PlanNumber = RPSControlFactory.CreateRPSTextBox<ArticleDetailView>("cb0a8ffc-e2e0-4223-aa1a-989a214442b3","","",false, this);
 
            GeneratePurchase = RPSControlFactory.CreateRPSCheckBox<ArticleDetailView>("d408d104-c414-4078-9f43-70c1c3ac235d","","",true, this);
 
            BlockedSales = RPSControlFactory.CreateRPSCheckBox<ArticleDetailView>("ea5c28de-4861-4112-aee8-9073b12a23dd","","",true, this);
 
            SalesKit = RPSControlFactory.CreateRPSCheckBox<ArticleDetailView>("ca9fb339-9a26-4dcc-afb5-d588edc14815","","",true, this);
 
            StandardPrice = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("74c779e1-1fcc-41d3-a1fa-390fe7613672","","",true, this);
 
            CustomerReferenceControl = RPSControlFactory.CreateRPSCheckBox<ArticleDetailView>("5d7135f6-ede7-4d9b-8828-e658e1fc73a0","","",true, this);
 
            IDArticleAccType = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("6c9239f1-7951-41ca-bcb8-9a9661b75091","","",false, this);
 
            SalesLot = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("7c34298b-fa59-45d3-8f39-478c4b246cde","","",true, this);
 
            MinimumSalesLot = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("b5c150b4-3c94-4f02-92c7-49f6e3b104b1","","",true, this);
 
            IDSiteOutput = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("9531eb32-08db-4a2c-b183-e91224de13af","","",false, this);
 
            IDOutputWarehouse = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("2d769e96-a5ed-42f4-a89b-c6a204cd04a3","","",false, this);
 
            IDSiteEntry = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("7ae27d17-6b4c-46ca-ba2a-ed6ee29aa62a","","",false, this);
 
            IDEntryWarehouse = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("ce7edb9d-d438-4fc0-82f4-b8498e879fee","","",false, this);
 
            IDVATType = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("2117fc91-fda3-48ef-b585-4cec31441ac1","","",true, this);
 
            TaxTypeSales = RPSControlFactory.CreateRPSEnumComboBox<ArticleDetailView>("25b2e822-73af-4205-a88a-3ec86511f0f7","","",true, this);
 
            IDTaxGroupSales = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("5334e987-9fed-4461-b6a3-3fa0d3094b1d","","",false, this);
 
            ProvisionType = RPSControlFactory.CreateRPSEnumComboBox<ArticleDetailView>("f306d4f6-4dc1-48d2-bc1e-088279f35640","","",true, this);
 
            IDSiteProvision = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("d6ed0eb9-84db-470f-862e-44d2665da1ec","","",false, this);
 
            IDWarehouseProvision = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("6b89c542-a6cf-4208-ae5e-29fdd1bde35e","","",false, this);
 

        }
        public IRPSButton<ArticleDetailView> DeleteButton { get; set; } 
        public IRPSButton<ArticleDetailView,ArticleEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleDetailView,ArticleEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ArticleDetailView,ArticleEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ArticleDetailView> CodCompany { get; set; } 
        public IRPSComboBox<ArticleDetailView> Type { get; set; } 
        public IRPSComboBox<ArticleDetailView> ValuationCostType { get; set; } 
        public IRPSTextBox<ArticleDetailView> PlanNumber { get; set; } 
        public IRPSCheckbox<ArticleDetailView> GeneratePurchase { get; set; } 
        public IRPSCheckbox<ArticleDetailView> BlockedSales { get; set; } 
        public IRPSCheckbox<ArticleDetailView> SalesKit { get; set; } 
        public IRPSTextBox<ArticleDetailView> StandardPrice { get; set; } 
        public IRPSCheckbox<ArticleDetailView> CustomerReferenceControl { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDArticleAccType { get; set; } 
        public IRPSTextBox<ArticleDetailView> SalesLot { get; set; } 
        public IRPSTextBox<ArticleDetailView> MinimumSalesLot { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDSiteOutput { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDOutputWarehouse { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDSiteEntry { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDEntryWarehouse { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDVATType { get; set; } 
        public IRPSComboBox<ArticleDetailView> TaxTypeSales { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDTaxGroupSales { get; set; } 
        public IRPSComboBox<ArticleDetailView> ProvisionType { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDSiteProvision { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDWarehouseProvision { get; set; } 
        public Article Screen { get; set; }
        public ArticleDetailView Wait(int seconds)
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
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ArticleByLangView,ArticleEntityView>( this,Screen.ArticleEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ArticleByLangView,ArticleEntityView>( this,Screen.ArticleEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ArticleByLangView,ArticleEntityView>( this,Screen.ArticleEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<ArticleByLangView>("57455301-9a9b-4da0-8c03-dea846f22d61","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ArticleByLangView>("1d47d8b5-fba5-411c-b71a-0d0b008ab7cb","","",false, this);
 
            TechnicalDescription = RPSControlFactory.CreateRPSTextBox<ArticleByLangView>("569ad04b-4877-4c5a-9232-ffa461808273","","",false, this);
 

        }
        public IRPSButton<ArticleByLangView> DeleteButton { get; set; } 
        public IRPSButton<ArticleByLangView,ArticleEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleByLangView,ArticleEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ArticleByLangView,ArticleEntityView> AcceptButton { get; set; } 
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
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ArticleAlternativeSalesSLView,ArticleEntityView>( this,Screen.ArticleEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ArticleAlternativeSalesSLView,ArticleEntityView>( this,Screen.ArticleEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ArticleAlternativeSalesSLView,ArticleEntityView>( this,Screen.ArticleEntityView);
 
            IDArticleEquivalent = RPSControlFactory.CreateRPSComboBox<ArticleAlternativeSalesSLView>("c0c3848f-9f0b-4b8f-bbae-32b32ab54287","","",true, this);
 

        }
        public IRPSButton<ArticleAlternativeSalesSLView> DeleteButton { get; set; } 
        public IRPSButton<ArticleAlternativeSalesSLView,ArticleEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleAlternativeSalesSLView,ArticleEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ArticleAlternativeSalesSLView,ArticleEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ArticleAlternativeSalesSLView> IDArticleEquivalent { get; set; } 
        public Article Screen { get; set; }
        public ArticleAlternativeSalesSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}