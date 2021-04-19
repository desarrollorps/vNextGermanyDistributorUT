    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.Article
{
    //RPS VERSION 1.0.0.0
    public partial class Article:Screen
    {
        public Article():base()
        {
            this.URL = "purchase.article";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ArticleCollectionView  = new ArticleCollectionView(this); 
            ArticleEntityView  = new ArticleEntityView(this); 
            ArticleByLangView  = new ArticleByLangView(this); 
            ArticleAlternativePurchaseView  = new ArticleAlternativePurchaseView(this); 
            ArticleConvertMeasureUnitView  = new ArticleConvertMeasureUnitView(this); 
            ArticleDetailView  = new ArticleDetailView(this); 
            ArticleCollectionView.InitializeControls(); 
            ArticleEntityView.InitializeControls(); 
            ArticleByLangView.InitializeControls(); 
            ArticleAlternativePurchaseView.InitializeControls(); 
            ArticleConvertMeasureUnitView.InitializeControls(); 
            ArticleDetailView.InitializeControls(); 
           
        }
      
            public ArticleCollectionView ArticleCollectionView {get; set; } 
            public ArticleEntityView ArticleEntityView {get; set; } 
            public ArticleByLangView ArticleByLangView {get; set; } 
            public ArticleAlternativePurchaseView ArticleAlternativePurchaseView {get; set; } 
            public ArticleConvertMeasureUnitView ArticleConvertMeasureUnitView {get; set; } 
            public ArticleDetailView ArticleDetailView {get; set; } 
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
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "01d5b776-32dc-4fee-bd31-cba1c71152e7",CSSSelectorDescriptor = "",XPathDescriptor = ""};
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
 
            CodArticle = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("f6d41188-795b-4fd4-ad8a-d9c9de74954f","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("fc3718c2-d53f-4cf4-b81e-663a96eba934","","",false, this);
 
            IDProductLine = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("c3a2ebe6-030c-4851-bb90-7abcbc8657bb","","",false, this);
 
            IDProductFamily = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("9434bc9c-9a27-443b-a5cf-e2a9566404c7","","",false, this);
 
            IDProductSubFamily = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("ff98b92d-aeed-4664-8894-2ae0aa27e599","","",false, this);
 
            InactiveDate = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("e8520034-5eb1-4610-88a2-ba86a97ed541","","",false, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<ArticleEntityView>("fc6bd453-00e1-4f4a-a6ad-c081e5921abb","","",true, this);
 
            ValuationCostType = RPSControlFactory.CreateRPSEnumComboBox<ArticleEntityView>("fb622236-6030-48f7-96e7-bed96f458073","","",true, this);
 
            Dimension = RPSControlFactory.CreateRPSEnumComboBox<ArticleEntityView>("48ff80f6-de11-4097-bcc5-6017e6fa3bc5","","",true, this);
 
            PurchaseKit = RPSControlFactory.CreateRPSCheckBox<ArticleEntityView>("b454f719-91ce-4a70-96fe-93333eb02667","","",true, this);
 
            BlockedPurchase = RPSControlFactory.CreateRPSCheckBox<ArticleEntityView>("010c500e-733e-445d-855a-069e250c2764","","",true, this);
 
            CodArticlePrevious = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("d5be8189-e9c9-45c0-8a52-f74e35259da4","","",false, this);
 
            InvestmentExpense = RPSControlFactory.CreateRPSEnumComboBox<ArticleEntityView>("23612cac-6783-4e1a-8ab0-b5ec009dee7e","","",true, this);
 
            PurchaseLot = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("c4b2ad56-2a7a-461e-89ff-3cb624066e1e","","",true, this);
 
            LaunchLot = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("bf8bd83d-5614-4773-baf9-ae5403b3d3ce","","",true, this);
 
            NetWeight = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("624c1361-d547-4cd8-8a0a-75c668fff15f","","",true, this);
 
            GrossWeight = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("d03881e3-5586-4067-bba1-e4a8e6414907","","",true, this);
 
            StandardPrice = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("81ee7caf-541c-41a5-a660-718e30dbf377","","",true, this);
 
            PurchasePrice = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("b082fea1-5e38-4ac5-a58f-72566595f309","","",true, this);
 
            PurchaseDate = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("1f042e9a-ea2e-4dc4-b13b-8dd8690b9902","","",false, this);
 
            MatchCode = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("aad1ba2f-2169-4fd5-904e-7d3ded5673a2","","",false, this);
 
            PlanNumber = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("503af2b7-6d8e-4698-9634-834102b061d1","","",false, this);
 
            IDUnitQuantityPurchase = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("cf5e933c-4440-455c-935f-f829256a632f","","",true, this);
 
            IDUnitPricePurchase = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("c5e46d56-c5d1-41c9-8c65-21b1893c91b1","","",true, this);
 
            IDUnitHomogeneousPurchase = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("f31d420a-d76d-4723-b491-71b5f6d5895b","","",true, this);
 
            ReturnPercent = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("7c53230d-1522-4f28-ab8c-2da94ae818fa","","",true, this);
 
            IDVATType = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("f3f97ffd-e5f2-4948-af57-df1f2c093111","","",true, this);
 
            TaxTypePurchase = RPSControlFactory.CreateRPSEnumComboBox<ArticleEntityView>("3f2d32ea-7e14-495a-a956-bfbcaefeefc5","","",true, this);
 
            IDTaxGroupPurchase = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("a9413773-6409-4016-9ffe-c1c71796a77d","","",false, this);
 
            IDArticleAccType = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("72438b5d-a331-4155-a9dd-eeae2a6c2872","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("c9627bec-011d-4ddf-b981-2737c02022a7","","",false, this);
 
            IDSupplierGroup = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("d4f59d2d-53b3-4733-a244-3b9e37483276","","",false, this);
 
            SupplierReferenceControl = RPSControlFactory.CreateRPSCheckBox<ArticleEntityView>("ba9b2b29-95b7-4f94-ab24-7a8a27e22bb7","","",true, this);
 
            DeliveryDays = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("56e1274f-0216-4b18-8219-b07eaa84eb4e","","",true, this);
 
            ApplyPurchaseDiscount = RPSControlFactory.CreateRPSCheckBox<ArticleEntityView>("50dc74c7-5e33-43fe-882d-a44edde1d181","","",true, this);
 
            ApplyPurchaseDiscountPP = RPSControlFactory.CreateRPSCheckBox<ArticleEntityView>("93c6868a-f169-4620-9d91-317c57ba22e1","","",true, this);
 
            ApplyPurchaseFinancialSurcharge = RPSControlFactory.CreateRPSCheckBox<ArticleEntityView>("c3e6c393-bc75-4e3a-8b77-db9ea9d9ff00","","",true, this);
 
            ApplyPurchaseRetention = RPSControlFactory.CreateRPSCheckBox<ArticleEntityView>("462db985-6d16-4f21-9077-650377a7810b","","",true, this);
 
            CostMovement = RPSControlFactory.CreateRPSCheckBox<ArticleEntityView>("a6b1b039-086c-4017-9386-71413b992661","","",true, this);
 
            IDMovementType = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("a2849070-e45f-4cfe-a76a-ece5dd02d8c7","","",false, this);
 
            IDSiteEntry = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("fb69df17-49fe-4d1b-bdd0-a01271ee1304","","",false, this);
 
            IDEntryWarehouse = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("29574844-61ea-487f-bfe9-16ac5c8bf896","","",false, this);
 
            IDSiteOutput = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("7dfe4436-ad32-4947-babd-7f5a423a895f","","",false, this);
 
            IDOutputWarehouse = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("a7993bd7-0d74-41bd-b9e5-f7916d0d6619","","",false, this);
 
            QualityOnReception = RPSControlFactory.CreateRPSEnumComboBox<ArticleEntityView>("4fe30d31-12c2-40a5-a88f-b9f28d944a1b","","",true, this);
 
            Quality = RPSControlFactory.CreateRPSOption<ArticleEntityView>( "13e5aa8a-fdea-458e-a32c-72251f56628a","","",this);
 
            Main = RPSControlFactory.CreateRPSOption<ArticleEntityView>( "e318c904-653f-481c-b2a4-2c6681633ae1","","",this);
 
            IDQualityPartType = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("3228af07-90dc-4b23-9145-daf6e7312e0c","","",false, this);
 
            IDSiteProvision = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("8f047040-81ad-4e35-89db-edb871e9c581","","",false, this);
 
            IDWarehouseProvision = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("78226e8d-6b21-42f9-a7d0-a178b0753548","","",false, this);
 
            StatisticsCode = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("232577e8-c9b1-42ff-a800-f73c78e77fed","","",false, this);
 
            CodCountryOfOrigin = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("3ef6e397-08b4-42ac-9d5a-9274ab7c25fb","","",false, this);
 
            SupplemetUnit = RPSControlFactory.CreateRPSCheckBox<ArticleEntityView>("ed1855e3-d526-47c0-9d53-cd1fdb6770e7","","",true, this);
 
            IDUnitSupplement = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("4effbe0e-bc08-4874-9f46-2b8a6603964e","","",false, this);
 
            IDImportDocumentType = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("f94b8a0d-dc19-4692-ace2-a5bf4f0c2584","","",false, this);
 
            IDImportTariffType = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("01ad10be-200f-4d47-bf71-fe026be9712c","","",false, this);
 
            DocumentParent = RPSControlFactory.CreateRPSCheckBox<ArticleEntityView>("fc81b087-6631-4694-b6e5-484c12241e1b","","",true, this);
 
            DocumentMaterials = RPSControlFactory.CreateRPSCheckBox<ArticleEntityView>("69bd1e1f-1b9d-44cc-954d-e175b49bcad3","","",true, this);
 
            TechnicalDescription = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("0ca8f950-48a3-4845-b634-2f7cfe15bc44","","",false, this);
 
            Notes = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("aad58f7e-8b7c-4bce-b1be-50d5402f8ad4","","",false, this);
 
            CollectionInit params_ArticleByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5c9e0a7e-6691-4ece-ae2f-908e59e4db23",CSSSelectorGrid="",XPathGrid=""};
            ArticleByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleByLangsCollectionEditor<ArticleEntityView,ArticleByLangView>,ArticleEntityView,ArticleByLangView>( params_ArticleByLangs,this,Screen.ArticleByLangView);
 
            CollectionInit params_ArticleAlternativePurchases = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="90d11194-6607-46bc-b11a-746c0b2faf05",CSSSelectorGrid="",XPathGrid=""};
            ArticleAlternativePurchases = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleAlternativePurchasesCollectionEditor<ArticleEntityView,ArticleByLangView>,ArticleEntityView,ArticleByLangView>( params_ArticleAlternativePurchases,this,Screen.ArticleByLangView);
 
            CollectionInit params_ArticleConvertMeasureUnits = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1af6d3e7-5f45-4298-82fa-3e17a6d1ddab",CSSSelectorGrid="",XPathGrid=""};
            ArticleConvertMeasureUnits = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleConvertMeasureUnitsCollectionEditor<ArticleEntityView,ArticleByLangView>,ArticleEntityView,ArticleByLangView>( params_ArticleConvertMeasureUnits,this,Screen.ArticleByLangView);
 
            CollectionInit params_ArticleDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="349e3f40-5594-452d-9a10-df6d466f6ab5",CSSSelectorGrid="",XPathGrid=""};
            ArticleDetails = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleDetailsCollectionEditor<ArticleEntityView,ArticleByLangView>,ArticleEntityView,ArticleByLangView>( params_ArticleDetails,this,Screen.ArticleByLangView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='65ac2aae-d43f-4cd6-bdf5-366befe00cee']","",this);
 
            ArticleByLang = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='61b9374a-6540-4449-ba9b-22f50373f77a']","",this);
 
            Alternative = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='a3305f01-2c06-439d-aa72-7f0c91c214f8']","",this);
 
            MeasureUnit = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='4d647544-54eb-4b68-ab61-d4574251856b']","",this);
 
            TechnicalDescription1 = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='6bf86828-033e-4d3a-877b-72bb439bc95a']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='fb3f35e2-c7cf-43ba-830c-867f16367cf4']","",this);
 
            Subsidiaries = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='56e26628-bad2-469e-886f-fc4400a117b8']","",this);
 

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
        public IRPSCheckbox<ArticleEntityView> PurchaseKit { get; set; } 
        public IRPSCheckbox<ArticleEntityView> BlockedPurchase { get; set; } 
        public IRPSTextBox<ArticleEntityView> CodArticlePrevious { get; set; } 
        public IRPSComboBox<ArticleEntityView> InvestmentExpense { get; set; } 
        public IRPSTextBox<ArticleEntityView> PurchaseLot { get; set; } 
        public IRPSTextBox<ArticleEntityView> LaunchLot { get; set; } 
        public IRPSTextBox<ArticleEntityView> NetWeight { get; set; } 
        public IRPSTextBox<ArticleEntityView> GrossWeight { get; set; } 
        public IRPSTextBox<ArticleEntityView> StandardPrice { get; set; } 
        public IRPSTextBox<ArticleEntityView> PurchasePrice { get; set; } 
        public IRPSTextBox<ArticleEntityView> PurchaseDate { get; set; } 
        public IRPSTextBox<ArticleEntityView> MatchCode { get; set; } 
        public IRPSTextBox<ArticleEntityView> PlanNumber { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDUnitQuantityPurchase { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDUnitPricePurchase { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDUnitHomogeneousPurchase { get; set; } 
        public IRPSTextBox<ArticleEntityView> ReturnPercent { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDVATType { get; set; } 
        public IRPSComboBox<ArticleEntityView> TaxTypePurchase { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDTaxGroupPurchase { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDArticleAccType { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDSupplier { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDSupplierGroup { get; set; } 
        public IRPSCheckbox<ArticleEntityView> SupplierReferenceControl { get; set; } 
        public IRPSTextBox<ArticleEntityView> DeliveryDays { get; set; } 
        public IRPSCheckbox<ArticleEntityView> ApplyPurchaseDiscount { get; set; } 
        public IRPSCheckbox<ArticleEntityView> ApplyPurchaseDiscountPP { get; set; } 
        public IRPSCheckbox<ArticleEntityView> ApplyPurchaseFinancialSurcharge { get; set; } 
        public IRPSCheckbox<ArticleEntityView> ApplyPurchaseRetention { get; set; } 
        public IRPSCheckbox<ArticleEntityView> CostMovement { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDMovementType { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDSiteEntry { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDEntryWarehouse { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDSiteOutput { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDOutputWarehouse { get; set; } 
        public IRPSComboBox<ArticleEntityView> QualityOnReception { get; set; } 
        public IRPSOption<ArticleEntityView> Quality { get; set; } 
        public IRPSOption<ArticleEntityView> Main { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDQualityPartType { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDSiteProvision { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDWarehouseProvision { get; set; } 
        public IRPSTextBox<ArticleEntityView> StatisticsCode { get; set; } 
        public IRPSComboBox<ArticleEntityView> CodCountryOfOrigin { get; set; } 
        public IRPSCheckbox<ArticleEntityView> SupplemetUnit { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDUnitSupplement { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDImportDocumentType { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDImportTariffType { get; set; } 
        public IRPSCheckbox<ArticleEntityView> DocumentParent { get; set; } 
        public IRPSCheckbox<ArticleEntityView> DocumentMaterials { get; set; } 
        public IRPSTextBox<ArticleEntityView> TechnicalDescription { get; set; } 
        public IRPSTextBox<ArticleEntityView> Notes { get; set; } 
        public ArticleByLangsCollectionEditor<ArticleEntityView,ArticleByLangView> ArticleByLangs { get; set; } 
        public ArticleAlternativePurchasesCollectionEditor<ArticleEntityView,ArticleByLangView> ArticleAlternativePurchases { get; set; } 
        public ArticleConvertMeasureUnitsCollectionEditor<ArticleEntityView,ArticleByLangView> ArticleConvertMeasureUnits { get; set; } 
        public ArticleDetailsCollectionEditor<ArticleEntityView,ArticleByLangView> ArticleDetails { get; set; } 
        public IRPSSection<ArticleEntityView> GeneralData { get; set; } 
        public IRPSSection<ArticleEntityView> ArticleByLang { get; set; } 
        public IRPSSection<ArticleEntityView> Alternative { get; set; } 
        public IRPSSection<ArticleEntityView> MeasureUnit { get; set; } 
        public IRPSSection<ArticleEntityView> TechnicalDescription1 { get; set; } 
        public IRPSSection<ArticleEntityView> Comments { get; set; } 
        public IRPSSection<ArticleEntityView> Subsidiaries { get; set; } 
        public Article Screen { get; set; }
        public ArticleEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
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
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<ArticleEntityView>("","#5c9e0a7e-6691-4ece-ae2f-908e59e4db23 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ArticleEntityView>("","#5c9e0a7e-6691-4ece-ae2f-908e59e4db23 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            TechnicalDescription = RPSControlFactory.CreateRPSGridMemoTextBox<ArticleEntityView>("","#5c9e0a7e-6691-4ece-ae2f-908e59e4db23 .ag-row[role='row']@ROWINDEX [col-id='cTechnicalDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ArticleEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<ArticleEntityView> Description { get; set; } 
        public IRPSGridTextBox<ArticleEntityView> TechnicalDescription { get; set; } 
                     
    }
 
        public partial class ArticleAlternativePurchasesCollectionEditor<ArticleEntityView,ArticleByLangView>:RPSCollectionEditor<ArticleEntityView,ArticleByLangView> where ArticleEntityView : class, IView where ArticleByLangView : class, IView
    {
        public  ArticleAlternativePurchasesGridView<ArticleEntityView,ArticleByLangView> GridView {get;set;}
    }
    public partial class ArticleAlternativePurchasesGridView <ArticleEntityView,ArticleByLangView> :  RPSGridView<ArticleEntityView,ArticleByLangView> where ArticleEntityView : class, IView where ArticleByLangView : class, IView
    {
        public ArticleAlternativePurchasesGridView(ArticleEntityView currentView,ArticleByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticleEquivalent = RPSControlFactory.CreateRPSGridComboBox<ArticleEntityView>("","#90d11194-6607-46bc-b11a-746c0b2faf05 .ag-row[role='row']@ROWINDEX [col-id='cIDArticleEquivalent']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<ArticleEntityView> IDArticleEquivalent { get; set; } 
                     
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
            IDUnitSource = RPSControlFactory.CreateRPSGridComboBox<ArticleEntityView>("","#1af6d3e7-5f45-4298-82fa-3e17a6d1ddab .ag-row[role='row']@ROWINDEX [col-id='cIDUnitSource']","",true, this.CurrentView);
 
            MultiplyOperator = RPSControlFactory.CreateRPSGridEnumComboBox<ArticleEntityView>("","#1af6d3e7-5f45-4298-82fa-3e17a6d1ddab .ag-row[role='row']@ROWINDEX [col-id='cMultiplyOperator']","",true, this.CurrentView);
 
            MultiplyFactor = RPSControlFactory.CreateRPSGridFormattedTextBox<ArticleEntityView>("","#1af6d3e7-5f45-4298-82fa-3e17a6d1ddab .ag-row[role='row']@ROWINDEX [col-id='cMultiplyFactor']","",true, this.CurrentView);
 
            SumOperator = RPSControlFactory.CreateRPSGridEnumComboBox<ArticleEntityView>("","#1af6d3e7-5f45-4298-82fa-3e17a6d1ddab .ag-row[role='row']@ROWINDEX [col-id='cSumOperator']","",true, this.CurrentView);
 
            SumFactor = RPSControlFactory.CreateRPSGridTextBox<ArticleEntityView>("","#1af6d3e7-5f45-4298-82fa-3e17a6d1ddab .ag-row[role='row']@ROWINDEX [col-id='cSumFactor']","",true, this.CurrentView);
 
            IDUnitDestination = RPSControlFactory.CreateRPSGridComboBox<ArticleEntityView>("","#1af6d3e7-5f45-4298-82fa-3e17a6d1ddab .ag-row[role='row']@ROWINDEX [col-id='cIDUnitDestination']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<ArticleEntityView> IDUnitSource { get; set; } 
        public IRPSGridComboBox<ArticleEntityView> MultiplyOperator { get; set; } 
        public IRPSGridTextBox<ArticleEntityView> MultiplyFactor { get; set; } 
        public IRPSGridComboBox<ArticleEntityView> SumOperator { get; set; } 
        public IRPSGridTextBox<ArticleEntityView> SumFactor { get; set; } 
        public IRPSGridComboBox<ArticleEntityView> IDUnitDestination { get; set; } 
                     
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
            CodCompany = RPSControlFactory.CreateRPSGridComboBox<ArticleEntityView>("","#349e3f40-5594-452d-9a10-df6d466f6ab5 .ag-row[role='row']@ROWINDEX [col-id='cCodCompany']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<ArticleEntityView>("","#349e3f40-5594-452d-9a10-df6d466f6ab5 .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            ValuationCostType = RPSControlFactory.CreateRPSGridEnumComboBox<ArticleEntityView>("","#349e3f40-5594-452d-9a10-df6d466f6ab5 .ag-row[role='row']@ROWINDEX [col-id='cValuationCostType']","",true, this.CurrentView);
 
            QualityOnReception = RPSControlFactory.CreateRPSGridEnumComboBox<ArticleEntityView>("","#349e3f40-5594-452d-9a10-df6d466f6ab5 .ag-row[role='row']@ROWINDEX [col-id='cQualityOnReception']","",true, this.CurrentView);
 
            QualityMainWarehouse = RPSControlFactory.CreateRPSGridCheckBox<ArticleEntityView>("","#349e3f40-5594-452d-9a10-df6d466f6ab5 .ag-row[role='row']@ROWINDEX [col-id='cQualityMainWarehouse']","",true, this.CurrentView);
 
            BlockedPurchase = RPSControlFactory.CreateRPSGridCheckBox<ArticleEntityView>("","#349e3f40-5594-452d-9a10-df6d466f6ab5 .ag-row[role='row']@ROWINDEX [col-id='cBlockedPurchase']","",true, this.CurrentView);
 
            PurchaseKit = RPSControlFactory.CreateRPSGridCheckBox<ArticleEntityView>("","#349e3f40-5594-452d-9a10-df6d466f6ab5 .ag-row[role='row']@ROWINDEX [col-id='cPurchaseKit']","",true, this.CurrentView);
 
            PlanNumber = RPSControlFactory.CreateRPSGridTextBox<ArticleEntityView>("","#349e3f40-5594-452d-9a10-df6d466f6ab5 .ag-row[role='row']@ROWINDEX [col-id='cPlanNumber']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ArticleEntityView> CodCompany { get; set; } 
        public IRPSGridComboBox<ArticleEntityView> Type { get; set; } 
        public IRPSGridComboBox<ArticleEntityView> ValuationCostType { get; set; } 
        public IRPSGridComboBox<ArticleEntityView> QualityOnReception { get; set; } 
        public IRPSGridCheckbox<ArticleEntityView> QualityMainWarehouse { get; set; } 
        public IRPSGridCheckbox<ArticleEntityView> BlockedPurchase { get; set; } 
        public IRPSGridCheckbox<ArticleEntityView> PurchaseKit { get; set; } 
        public IRPSGridTextBox<ArticleEntityView> PlanNumber { get; set; } 
                     
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
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<ArticleByLangView>("5ca18c87-a507-400c-9988-2ae8aaf68816","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ArticleByLangView>("7e88511a-e3bb-4420-afdd-7df413cc9eb8","","",false, this);
 
            TechnicalDescription = RPSControlFactory.CreateRPSTextBox<ArticleByLangView>("a182ace4-e32a-4b9d-b20d-9f94d0121bf3","","",false, this);
 

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
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ArticleAlternativePurchaseView,ArticleEntityView>( this,Screen.ArticleEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ArticleAlternativePurchaseView,ArticleEntityView>( this,Screen.ArticleEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ArticleAlternativePurchaseView,ArticleEntityView>( this,Screen.ArticleEntityView);
 
            IDArticleEquivalent = RPSControlFactory.CreateRPSComboBox<ArticleAlternativePurchaseView>("decef461-a339-4689-b4bc-9fb05047cde5","","",true, this);
 

        }
        public IRPSButton<ArticleAlternativePurchaseView> DeleteButton { get; set; } 
        public IRPSButton<ArticleAlternativePurchaseView,ArticleEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleAlternativePurchaseView,ArticleEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ArticleAlternativePurchaseView,ArticleEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ArticleAlternativePurchaseView> IDArticleEquivalent { get; set; } 
        public Article Screen { get; set; }
        public ArticleAlternativePurchaseView Wait(int seconds)
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
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ArticleConvertMeasureUnitView,ArticleEntityView>( this,Screen.ArticleEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ArticleConvertMeasureUnitView,ArticleEntityView>( this,Screen.ArticleEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ArticleConvertMeasureUnitView,ArticleEntityView>( this,Screen.ArticleEntityView);
 
            Formulated = RPSControlFactory.CreateRPSOption<ArticleConvertMeasureUnitView>( "62c6b0f8-7ba1-45b6-b7cc-010c1944a32f","","",this);
 
            IDUnitSource = RPSControlFactory.CreateRPSComboBox<ArticleConvertMeasureUnitView>("0a1294a4-9376-463b-b779-d1cc70cc9fd0","","",true, this);
 
            MultiplyOperator = RPSControlFactory.CreateRPSEnumComboBox<ArticleConvertMeasureUnitView>("f77e41b7-19dc-46dd-aae7-b9cec76669d1","","",true, this);
 
            MultiplyFactor = RPSControlFactory.CreateRPSFormattedTextBox<ArticleConvertMeasureUnitView>("3479e761-92a1-4a15-b738-88e17e6bc5c8","","",true, this);
 
            IDUnitDestination = RPSControlFactory.CreateRPSComboBox<ArticleConvertMeasureUnitView>("c345029d-dac7-46c8-9c34-ff64978db59f","","",true, this);
 
            Second_Unit = RPSControlFactory.CreateRPSOption<ArticleConvertMeasureUnitView>( "79e56cba-46d6-4c7a-86fd-76e77ae3438e","","",this);
 
            SumOperator = RPSControlFactory.CreateRPSEnumComboBox<ArticleConvertMeasureUnitView>("a43a3caf-76b1-4cb9-8f8a-bd8747aa23fa","","",true, this);
 
            SumFactor = RPSControlFactory.CreateRPSTextBox<ArticleConvertMeasureUnitView>("5415b01e-651e-4e46-8613-54f78663a37c","","",true, this);
 

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
 
            CodCompany = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("86941a6f-7cbe-4dac-9350-d46b1d0eaf7f","","",true, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<ArticleDetailView>("2442d82c-c969-4405-839b-1d6acdc8fb16","","",true, this);
 
            ValuationCostType = RPSControlFactory.CreateRPSEnumComboBox<ArticleDetailView>("c91116f8-e4ec-48f4-b16f-f4265402ef0d","","",true, this);
 
            PurchaseKit = RPSControlFactory.CreateRPSCheckBox<ArticleDetailView>("5e683337-bbd5-4d4f-9666-0f1504341171","","",true, this);
 
            BlockedPurchase = RPSControlFactory.CreateRPSCheckBox<ArticleDetailView>("9e714297-87d2-4a37-bfcb-c2cc700aa61a","","",true, this);
 
            StandardPrice = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("073416a1-5c06-4ad1-b7bc-e31aa48468d9","","",true, this);
 
            PurchasePrice = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("899d2b05-374a-4938-90ed-0b6a6e50bd34","","",true, this);
 
            PurchaseDate = RPSControlFactory.CreateRPSTextBox<ArticleDetailView>("f9044749-bbf8-4d2b-9301-03295e1352aa","","",false, this);
 
            LaunchLot = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("833e1dfe-6fd0-4bd8-9683-878261b6f0af","","",true, this);
 
            PurchaseLot = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("c758ebe2-44d3-4718-800e-befdc2664661","","",true, this);
 
            IDVATType = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("fd97ff31-4471-4d17-873a-dcf20a1d400c","","",true, this);
 
            TaxTypePurchase = RPSControlFactory.CreateRPSEnumComboBox<ArticleDetailView>("8ff02b13-19bd-4668-adca-2a167f557328","","",true, this);
 
            IDTaxGroupPurchase = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("35da81bb-3060-49b5-b134-aa2b73b39ed2","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("b9e9bede-6d0f-4331-bc49-5f71008e0afc","","",false, this);
 
            SupplierReferenceControl = RPSControlFactory.CreateRPSCheckBox<ArticleDetailView>("533ac63b-8e86-4662-928a-42bff9bce143","","",true, this);
 
            DeliveryDays = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("fa3c33ca-039b-4c7f-876d-f00ebb52b153","","",true, this);
 
            ReturnPercent = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("892a7134-4f4e-42a6-bb22-8cb95e195965","","",true, this);
 
            IDSupplierGroup = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("d6f2662b-6844-424d-a1fb-3732c3fef748","","",false, this);
 
            IDArticleAccType = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("918e6010-3bc5-482f-bd88-e0c08b934b1a","","",false, this);
 
            CostMovement = RPSControlFactory.CreateRPSCheckBox<ArticleDetailView>("977ac87b-e87f-4992-9853-30599d9007aa","","",true, this);
 
            IDMovementType = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("d16cf348-5fbf-4371-b7a6-3fdb712adb32","","",false, this);
 
            IDSiteEntry = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("10229407-42d0-4a21-bce1-f5664f960b4f","","",false, this);
 
            IDEntryWarehouse = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("f769fd68-dbf4-4be9-adb4-eb9ee7dac609","","",false, this);
 
            IDSiteOutput = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("81233ece-70ea-4cb5-bb95-3168a0733970","","",false, this);
 
            IDOutputWarehouse = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("a65e2c07-a510-4a7d-abd5-9c440aaae0f9","","",false, this);
 
            QualityOnReception = RPSControlFactory.CreateRPSEnumComboBox<ArticleDetailView>("249837be-94e5-4e83-9066-c5ca2318bbe6","","",true, this);
 
            Quality = RPSControlFactory.CreateRPSOption<ArticleDetailView>( "27a2b106-5242-447b-aa06-e3d974ff0d8d","","",this);
 
            Main = RPSControlFactory.CreateRPSOption<ArticleDetailView>( "e2d3c86c-a60e-40f5-a572-6bc481b413af","","",this);
 
            IDQualityPartType = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("4cf32b9b-3ec9-4af6-8d75-4cf03ee146fc","","",false, this);
 
            IDSiteProvision = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("1ea7caa5-d469-4524-bba1-15532ae60520","","",false, this);
 
            IDWarehouseProvision = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("36f659ca-2b3d-405a-8213-ea55227a91bb","","",false, this);
 
            IDImportDocumentType = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("9fe88b69-2e0f-4c4f-89b2-88df69353585","","",false, this);
 
            IDImportTariffType = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("3b764993-f942-4001-80b5-19ab30353b15","","",false, this);
 
            DocumentParent = RPSControlFactory.CreateRPSCheckBox<ArticleDetailView>("68ae6ee0-682a-4073-9137-c77c8bf77e1e","","",true, this);
 
            DocumentMaterials = RPSControlFactory.CreateRPSCheckBox<ArticleDetailView>("e29fec18-771d-4821-b5f6-bd86fa1cb49d","","",true, this);
 

        }
        public IRPSButton<ArticleDetailView> DeleteButton { get; set; } 
        public IRPSButton<ArticleDetailView,ArticleEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleDetailView,ArticleEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ArticleDetailView,ArticleEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ArticleDetailView> CodCompany { get; set; } 
        public IRPSComboBox<ArticleDetailView> Type { get; set; } 
        public IRPSComboBox<ArticleDetailView> ValuationCostType { get; set; } 
        public IRPSCheckbox<ArticleDetailView> PurchaseKit { get; set; } 
        public IRPSCheckbox<ArticleDetailView> BlockedPurchase { get; set; } 
        public IRPSTextBox<ArticleDetailView> StandardPrice { get; set; } 
        public IRPSTextBox<ArticleDetailView> PurchasePrice { get; set; } 
        public IRPSTextBox<ArticleDetailView> PurchaseDate { get; set; } 
        public IRPSTextBox<ArticleDetailView> LaunchLot { get; set; } 
        public IRPSTextBox<ArticleDetailView> PurchaseLot { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDVATType { get; set; } 
        public IRPSComboBox<ArticleDetailView> TaxTypePurchase { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDTaxGroupPurchase { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDSupplier { get; set; } 
        public IRPSCheckbox<ArticleDetailView> SupplierReferenceControl { get; set; } 
        public IRPSTextBox<ArticleDetailView> DeliveryDays { get; set; } 
        public IRPSTextBox<ArticleDetailView> ReturnPercent { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDSupplierGroup { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDArticleAccType { get; set; } 
        public IRPSCheckbox<ArticleDetailView> CostMovement { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDMovementType { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDSiteEntry { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDEntryWarehouse { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDSiteOutput { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDOutputWarehouse { get; set; } 
        public IRPSComboBox<ArticleDetailView> QualityOnReception { get; set; } 
        public IRPSOption<ArticleDetailView> Quality { get; set; } 
        public IRPSOption<ArticleDetailView> Main { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDQualityPartType { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDSiteProvision { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDWarehouseProvision { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDImportDocumentType { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDImportTariffType { get; set; } 
        public IRPSCheckbox<ArticleDetailView> DocumentParent { get; set; } 
        public IRPSCheckbox<ArticleDetailView> DocumentMaterials { get; set; } 
        public Article Screen { get; set; }
        public ArticleDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}