    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.Article
{
    //RPS VERSION 1.0.0.0
    public partial class Article:Screen
    {
        public Article():base()
        {
            this.URL = "manufacturing.article";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ArticleCollectionView  = new ArticleCollectionView(this); 
            ArticleEntityView  = new ArticleEntityView(this); 
            ArticleDetailView  = new ArticleDetailView(this); 
            ArticleByLangView  = new ArticleByLangView(this); 
            ArticleAlternativeManufacturingView  = new ArticleAlternativeManufacturingView(this); 
            ArticleCollectionView.InitializeControls(); 
            ArticleEntityView.InitializeControls(); 
            ArticleDetailView.InitializeControls(); 
            ArticleByLangView.InitializeControls(); 
            ArticleAlternativeManufacturingView.InitializeControls(); 
           
        }
      
            public ArticleCollectionView ArticleCollectionView {get; set; } 
            public ArticleEntityView ArticleEntityView {get; set; } 
            public ArticleDetailView ArticleDetailView {get; set; } 
            public ArticleByLangView ArticleByLangView {get; set; } 
            public ArticleAlternativeManufacturingView ArticleAlternativeManufacturingView {get; set; } 
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
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "14b7a86d-e1b5-4701-b2b7-8fb9ae9b619b",CSSSelectorDescriptor = "",XPathDescriptor = ""};
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
 
            CodArticle = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("ac358489-b237-478a-82e1-9a0d0b6b84dc","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("87ec0dad-6b07-4ed5-b72e-5120e8c7d6f7","","",false, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<ArticleEntityView>("48536498-a973-443f-8082-5d62a5d5ec82","","",true, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("c4c228f6-1237-4b7b-8e16-f0339d30375e","","",false, this);
 
            IDProductLine = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("6900e6f2-a2de-4c50-a292-471ee6b92953","","",false, this);
 
            IDProductFamily = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("3e1b3e50-b6d7-474a-ae5e-1ff4b2cf9f78","","",false, this);
 
            IDProductSubFamily = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("e4f5dbd5-6c1b-42a9-9ab8-4ac6e02cb85f","","",false, this);
 
            IDSupplierGroup = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("fae3f30d-f6e9-4f94-8e1e-1932550c7e59","","",false, this);
 
            StandardCostLot = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("7ed15527-7ec2-4f1a-a5bf-6dc6087d57af","","",true, this);
 
            StandardPrice = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("bef3f213-aad3-43fb-a6d3-de2205e1ff35","","",true, this);
 
            ManufacturePrice = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("223e0353-1c81-4c3e-aa08-e11c2f4532cb","","",true, this);
 
            ManufactureDate = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("7dc8609e-3fcb-4e26-8c38-02c6ad1f7d1d","","",false, this);
 
            LaunchLot = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("fac93cdf-a1d6-4d3c-bd56-2dd7bfffc1e9","","",true, this);
 
            MinimumManufacturingLot = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("a18b1b4a-b6d4-42c4-90ef-cba282a6e266","","",true, this);
 
            ManufacturingLot = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("c3c3d67b-3234-44de-a3a2-3a02958c8789","","",true, this);
 
            ReturnPercent = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("6a972a2e-b1f0-4e6c-9b1a-dbd6b06594e7","","",true, this);
 
            DeliveryDays = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("202165d7-57b1-422a-a5f7-2cbd08af5fc5","","",true, this);
 
            ManufacturingGroupCode = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("97eca572-053d-4fa3-9e60-291ebde956fe","","",false, this);
 
            ManufacturingGroupQuantity = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("bc0cd200-4b1d-475b-b228-78ab1ceb135a","","",true, this);
 
            ImputationCostUpdated = RPSControlFactory.CreateRPSCheckBox<ArticleEntityView>("a93fb594-530a-4b2f-b2cd-3d386ed36e2a","","",true, this);
 
            MakeAutomaticOutput = RPSControlFactory.CreateRPSCheckBox<ArticleEntityView>("917551c5-e376-47c8-82f2-ac9eb345d13d","","",true, this);
 
            ImputationTotalQuantity = RPSControlFactory.CreateRPSCheckBox<ArticleEntityView>("a5cb2829-c151-46e2-994f-24a18809089d","","",true, this);
 
            BlockedManufacturing = RPSControlFactory.CreateRPSCheckBox<ArticleEntityView>("f338a25a-d6d1-41f6-b495-e239b0e67e50","","",true, this);
 
            MatchCode = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("0baefc10-6714-404c-ae44-5b63a8d6f212","","",false, this);
 
            PlanNumber = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("8c7e3c9f-692a-4cfc-872b-27a1236fc668","","",false, this);
 
            MultipleCADLink = RPSControlFactory.CreateRPSCheckBox<ArticleEntityView>("cb082107-56ef-4231-8b02-8400ffc7afb9","","",true, this);
 
            ComponentsGroupType = RPSControlFactory.CreateRPSEnumComboBox<ArticleEntityView>("3d36b378-74eb-4932-8951-553976ee02ab","","",true, this);
 
            IDSiteEntry = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("8df725c5-a75f-4420-ac59-844730d47f0b","","",false, this);
 
            IDEntryWarehouse = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("0b56ee93-3aab-48a0-b726-4b536510729a","","",false, this);
 
            IDSiteOutput = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("e8f05e44-abf9-48e0-a6a5-0c16df83c629","","",false, this);
 
            IDOutputWarehouse = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("c8cbf0b2-9e27-4e0b-a5ce-c66788c4d4f5","","",false, this);
 
            IDUnitQuantityWarehouse = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("4ef7c556-32eb-407f-9e45-18d371a7117b","","",true, this);
 
            IDUnitPriceWarehouse = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("38e48513-36af-467d-8863-3270deb33629","","",true, this);
 
            InactiveDate = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("38c3fea3-1cfd-4f82-96e6-d85923c844c3","","",false, this);
 
            BatchBalancing = RPSControlFactory.CreateRPSCheckBox<ArticleEntityView>("7336c88b-9e2c-4b40-9b94-aa332c4a04db","","",true, this);
 
            QuantityBaseFormula = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("e6b48e56-380e-4099-aa1c-c3996320d30b","","",true, this);
 
            IDUnitBaseFormula = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("d15a2fc1-09ad-43cb-9c66-8fd7cbf09cd2","","",true, this);
 
            PotencyControl = RPSControlFactory.CreateRPSCheckBox<ArticleEntityView>("499d81c4-788e-4035-89f6-967f417a5e06","","",true, this);
 
            PotencyDefault = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("b71bfcc9-79cd-4c33-a663-2f441ee1514d","","",true, this);
 
            Notes = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("37a32572-72e4-4bef-b77d-5673baef22e5","","",false, this);
 
            LotsReserve = RPSControlFactory.CreateRPSCheckBox<ArticleEntityView>("3067dd77-8fde-4430-a27d-bf1053a961c5","","",true, this);
 
            LotsReserveDays = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("a2ed2128-6f96-4595-85e8-55680a49542d","","",true, this);
 
            LotsOrder = RPSControlFactory.CreateRPSCheckBox<ArticleEntityView>("d9cef7e4-3944-4b37-9cf0-dd51e1545d00","","",true, this);
 
            LotsOrderDays = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("343a9f7f-4d77-4f75-b20c-1e5c4aa0b4c3","","",true, this);
 
            CollectionInit params_ArticleAlternativeManufacturings = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1722d9b7-5a39-40bf-a79e-36b7a29c2f3d",CSSSelectorGrid="",XPathGrid=""};
            ArticleAlternativeManufacturings = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleAlternativeManufacturingsCollectionEditor<ArticleEntityView,ArticleAlternativeManufacturingView>,ArticleEntityView,ArticleAlternativeManufacturingView>( params_ArticleAlternativeManufacturings,this,Screen.ArticleAlternativeManufacturingView);
 
            CollectionInit params_ArticleDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f3fd3c66-2035-4f23-8379-0911b37d3752",CSSSelectorGrid="",XPathGrid=""};
            ArticleDetails = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleDetailsCollectionEditor<ArticleEntityView,ArticleAlternativeManufacturingView>,ArticleEntityView,ArticleAlternativeManufacturingView>( params_ArticleDetails,this,Screen.ArticleAlternativeManufacturingView);
 
            CollectionInit params_ArticleByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4296c411-9f0a-42a8-84b3-98b0f71dd419",CSSSelectorGrid="",XPathGrid=""};
            ArticleByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleByLangsCollectionEditor<ArticleEntityView,ArticleAlternativeManufacturingView>,ArticleEntityView,ArticleAlternativeManufacturingView>( params_ArticleByLangs,this,Screen.ArticleAlternativeManufacturingView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='5af0f376-2bf4-4bf0-9a6a-ca4cd5856eca']","",this);
 
            CalculatedQuantity = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='72f5573c-8403-4e86-9595-4e920ea07294']","",this);
 
            EquivalentArticle = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='e8702c71-ff4c-4783-aa45-62b39139985d']","",this);
 
            Notes1 = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='c2af03b9-88ff-4abd-a103-7e2aca6d0aca']","",this);
 
            Subsidiary = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='74b2e441-e3e2-4fa3-9035-73c512781e16']","",this);
 
            Languages = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='2603660e-0ae2-4290-b59d-dcaefa27adc5']","",this);
 
            Batches = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='67a225a9-956a-42cf-9070-61b2048ad646']","",this);
 

        }
        public IRPSSaveButton<ArticleEntityView> SaveButton { get; set; } 
        public IRPSButton<ArticleEntityView> DeleteButton { get; set; } 
        public IRPSButton<ArticleEntityView,ArticleCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleEntityView,ArticleCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ArticleEntityView> CodArticle { get; set; } 
        public IRPSTextBox<ArticleEntityView> Description { get; set; } 
        public IRPSComboBox<ArticleEntityView> Type { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDSupplier { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDProductLine { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDProductFamily { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDProductSubFamily { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDSupplierGroup { get; set; } 
        public IRPSTextBox<ArticleEntityView> StandardCostLot { get; set; } 
        public IRPSTextBox<ArticleEntityView> StandardPrice { get; set; } 
        public IRPSTextBox<ArticleEntityView> ManufacturePrice { get; set; } 
        public IRPSTextBox<ArticleEntityView> ManufactureDate { get; set; } 
        public IRPSTextBox<ArticleEntityView> LaunchLot { get; set; } 
        public IRPSTextBox<ArticleEntityView> MinimumManufacturingLot { get; set; } 
        public IRPSTextBox<ArticleEntityView> ManufacturingLot { get; set; } 
        public IRPSTextBox<ArticleEntityView> ReturnPercent { get; set; } 
        public IRPSTextBox<ArticleEntityView> DeliveryDays { get; set; } 
        public IRPSTextBox<ArticleEntityView> ManufacturingGroupCode { get; set; } 
        public IRPSTextBox<ArticleEntityView> ManufacturingGroupQuantity { get; set; } 
        public IRPSCheckbox<ArticleEntityView> ImputationCostUpdated { get; set; } 
        public IRPSCheckbox<ArticleEntityView> MakeAutomaticOutput { get; set; } 
        public IRPSCheckbox<ArticleEntityView> ImputationTotalQuantity { get; set; } 
        public IRPSCheckbox<ArticleEntityView> BlockedManufacturing { get; set; } 
        public IRPSTextBox<ArticleEntityView> MatchCode { get; set; } 
        public IRPSTextBox<ArticleEntityView> PlanNumber { get; set; } 
        public IRPSCheckbox<ArticleEntityView> MultipleCADLink { get; set; } 
        public IRPSComboBox<ArticleEntityView> ComponentsGroupType { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDSiteEntry { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDEntryWarehouse { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDSiteOutput { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDOutputWarehouse { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDUnitQuantityWarehouse { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDUnitPriceWarehouse { get; set; } 
        public IRPSTextBox<ArticleEntityView> InactiveDate { get; set; } 
        public IRPSCheckbox<ArticleEntityView> BatchBalancing { get; set; } 
        public IRPSTextBox<ArticleEntityView> QuantityBaseFormula { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDUnitBaseFormula { get; set; } 
        public IRPSCheckbox<ArticleEntityView> PotencyControl { get; set; } 
        public IRPSTextBox<ArticleEntityView> PotencyDefault { get; set; } 
        public IRPSTextBox<ArticleEntityView> Notes { get; set; } 
        public IRPSCheckbox<ArticleEntityView> LotsReserve { get; set; } 
        public IRPSTextBox<ArticleEntityView> LotsReserveDays { get; set; } 
        public IRPSCheckbox<ArticleEntityView> LotsOrder { get; set; } 
        public IRPSTextBox<ArticleEntityView> LotsOrderDays { get; set; } 
        public ArticleAlternativeManufacturingsCollectionEditor<ArticleEntityView,ArticleAlternativeManufacturingView> ArticleAlternativeManufacturings { get; set; } 
        public ArticleDetailsCollectionEditor<ArticleEntityView,ArticleAlternativeManufacturingView> ArticleDetails { get; set; } 
        public ArticleByLangsCollectionEditor<ArticleEntityView,ArticleAlternativeManufacturingView> ArticleByLangs { get; set; } 
        public IRPSSection<ArticleEntityView> GeneralData { get; set; } 
        public IRPSSection<ArticleEntityView> CalculatedQuantity { get; set; } 
        public IRPSSection<ArticleEntityView> EquivalentArticle { get; set; } 
        public IRPSSection<ArticleEntityView> Notes1 { get; set; } 
        public IRPSSection<ArticleEntityView> Subsidiary { get; set; } 
        public IRPSSection<ArticleEntityView> Languages { get; set; } 
        public IRPSSection<ArticleEntityView> Batches { get; set; } 
        public Article Screen { get; set; }
        public ArticleEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ArticleAlternativeManufacturingsCollectionEditor<ArticleEntityView,ArticleAlternativeManufacturingView>:RPSCollectionEditor<ArticleEntityView,ArticleAlternativeManufacturingView> where ArticleEntityView : class, IView where ArticleAlternativeManufacturingView : class, IView
    {
        public  ArticleAlternativeManufacturingsGridView<ArticleEntityView,ArticleAlternativeManufacturingView> GridView {get;set;}
    }
    public partial class ArticleAlternativeManufacturingsGridView <ArticleEntityView,ArticleAlternativeManufacturingView> :  RPSGridView<ArticleEntityView,ArticleAlternativeManufacturingView> where ArticleEntityView : class, IView where ArticleAlternativeManufacturingView : class, IView
    {
        public ArticleAlternativeManufacturingsGridView(ArticleEntityView currentView,ArticleAlternativeManufacturingView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticleEquivalent = RPSControlFactory.CreateRPSGridComboBox<ArticleEntityView>("","#1722d9b7-5a39-40bf-a79e-36b7a29c2f3d .ag-row[role='row']@ROWINDEX [col-id='cIDArticleEquivalent']","",true, this.CurrentView);
 
            Priority = RPSControlFactory.CreateRPSGridFormattedTextBox<ArticleEntityView>("","#1722d9b7-5a39-40bf-a79e-36b7a29c2f3d .ag-row[role='row']@ROWINDEX [col-id='cPriority']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ArticleEntityView> IDArticleEquivalent { get; set; } 
        public IRPSGridTextBox<ArticleEntityView> Priority { get; set; } 
                     
    }
 
        public partial class ArticleDetailsCollectionEditor<ArticleEntityView,ArticleAlternativeManufacturingView>:RPSCollectionEditor<ArticleEntityView,ArticleAlternativeManufacturingView> where ArticleEntityView : class, IView where ArticleAlternativeManufacturingView : class, IView
    {
        public  ArticleDetailsGridView<ArticleEntityView,ArticleAlternativeManufacturingView> GridView {get;set;}
    }
    public partial class ArticleDetailsGridView <ArticleEntityView,ArticleAlternativeManufacturingView> :  RPSGridView<ArticleEntityView,ArticleAlternativeManufacturingView> where ArticleEntityView : class, IView where ArticleAlternativeManufacturingView : class, IView
    {
        public ArticleDetailsGridView(ArticleEntityView currentView,ArticleAlternativeManufacturingView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodCompany = RPSControlFactory.CreateRPSGridComboBox<ArticleEntityView>("","#f3fd3c66-2035-4f23-8379-0911b37d3752 .ag-row[role='row']@ROWINDEX [col-id='cCodCompany']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<ArticleEntityView>("","#f3fd3c66-2035-4f23-8379-0911b37d3752 .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            BlockedManufacturing = RPSControlFactory.CreateRPSGridCheckBox<ArticleEntityView>("","#f3fd3c66-2035-4f23-8379-0911b37d3752 .ag-row[role='row']@ROWINDEX [col-id='cBlockedManufacturing']","",true, this.CurrentView);
 
            PlanNumber = RPSControlFactory.CreateRPSGridTextBox<ArticleEntityView>("","#f3fd3c66-2035-4f23-8379-0911b37d3752 .ag-row[role='row']@ROWINDEX [col-id='cPlanNumber']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ArticleEntityView> CodCompany { get; set; } 
        public IRPSGridComboBox<ArticleEntityView> Type { get; set; } 
        public IRPSGridCheckbox<ArticleEntityView> BlockedManufacturing { get; set; } 
        public IRPSGridTextBox<ArticleEntityView> PlanNumber { get; set; } 
                     
    }
 
        public partial class ArticleByLangsCollectionEditor<ArticleEntityView,ArticleAlternativeManufacturingView>:RPSCollectionEditor<ArticleEntityView,ArticleAlternativeManufacturingView> where ArticleEntityView : class, IView where ArticleAlternativeManufacturingView : class, IView
    {
        public  ArticleByLangsGridView<ArticleEntityView,ArticleAlternativeManufacturingView> GridView {get;set;}
    }
    public partial class ArticleByLangsGridView <ArticleEntityView,ArticleAlternativeManufacturingView> :  RPSGridView<ArticleEntityView,ArticleAlternativeManufacturingView> where ArticleEntityView : class, IView where ArticleAlternativeManufacturingView : class, IView
    {
        public ArticleByLangsGridView(ArticleEntityView currentView,ArticleAlternativeManufacturingView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<ArticleEntityView>("","#4296c411-9f0a-42a8-84b3-98b0f71dd419 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ArticleEntityView>("","#4296c411-9f0a-42a8-84b3-98b0f71dd419 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            TechnicalDescription = RPSControlFactory.CreateRPSGridMemoTextBox<ArticleEntityView>("","#4296c411-9f0a-42a8-84b3-98b0f71dd419 .ag-row[role='row']@ROWINDEX [col-id='cTechnicalDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ArticleEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<ArticleEntityView> Description { get; set; } 
        public IRPSGridTextBox<ArticleEntityView> TechnicalDescription { get; set; } 
                     
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
 
            CodCompany = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("82969d63-718a-4352-8467-9d83416fa7ae","","",true, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<ArticleDetailView>("25f20ecb-075c-4ffb-88e3-b519cb38f215","","",true, this);
 
            ValuationCostType = RPSControlFactory.CreateRPSEnumComboBox<ArticleDetailView>("66ed6876-30e8-4e5d-a2da-0fd2dafad4b1","","",true, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("8fd985c6-6b50-426b-82b4-a66044fc0f1e","","",false, this);
 
            BlockedManufacturing = RPSControlFactory.CreateRPSCheckBox<ArticleDetailView>("ba40df9d-9df7-463a-a1dd-2033c39e708b","","",true, this);
 
            IDSupplierGroup = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("099480da-0db1-4cec-91e6-f39d000fb026","","",false, this);
 
            PlanNumber = RPSControlFactory.CreateRPSTextBox<ArticleDetailView>("3a49cd7c-9418-412b-bcf2-6241f9a882ee","","",false, this);
 
            IDSiteEntry = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("7a707f7f-4eb5-4e0e-bb53-0a78ffc7026d","","",false, this);
 
            IDEntryWarehouse = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("da75a7e8-3feb-4d92-a7d6-297eda6dbb8b","","",false, this);
 
            IDEntryLocationWarehouse = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("aea12153-d7ee-4e20-a1cd-b4ce5369e33e","","",false, this);
 
            IDSiteOutput = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("b4d7d8c7-615e-47db-a2f3-75d85c2b6e70","","",false, this);
 
            IDOutputWarehouse = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("506fa6d4-3c12-4cb0-80ac-d841a5cad227","","",false, this);
 
            IDOutputLocationWarehouse = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("8aa4c1d8-c4ef-44d6-a7ee-64765be67801","","",false, this);
 
            ManufacturePrice = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("b99a49e3-c1b6-4641-90c0-6e75fcd9fe13","","",true, this);
 
            ManufactureDate = RPSControlFactory.CreateRPSTextBox<ArticleDetailView>("adb07b5d-4811-43d8-8035-0ee0f5ce05cb","","",false, this);
 
            StandardPrice = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("222086ae-42aa-4a4a-8383-7c0a7cbbf340","","",true, this);
 
            DeliveryDays = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("3ca6ce71-c1c7-4b20-8954-bdbf8fac1769","","",true, this);
 
            ManufacturingLot = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("c73889b5-274b-46bd-8cf0-25e44f6d523c","","",true, this);
 
            StandardCostLot = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("ba25074a-d8d7-4914-8abf-b128d098a228","","",true, this);
 
            LaunchLot = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("4e32ad68-1cf7-4c78-9695-0d02d0a8b068","","",true, this);
 
            MinimumManufacturingLot = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("ded72843-202f-4e0a-99b2-c2f5013fe859","","",true, this);
 
            ReturnPercent = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("cf0315e8-b371-4ab8-8e0b-d5dceb30aa37","","",true, this);
 

        }
        public IRPSButton<ArticleDetailView> DeleteButton { get; set; } 
        public IRPSButton<ArticleDetailView,ArticleEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleDetailView,ArticleEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ArticleDetailView,ArticleEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ArticleDetailView> CodCompany { get; set; } 
        public IRPSComboBox<ArticleDetailView> Type { get; set; } 
        public IRPSComboBox<ArticleDetailView> ValuationCostType { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDSupplier { get; set; } 
        public IRPSCheckbox<ArticleDetailView> BlockedManufacturing { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDSupplierGroup { get; set; } 
        public IRPSTextBox<ArticleDetailView> PlanNumber { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDSiteEntry { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDEntryWarehouse { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDEntryLocationWarehouse { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDSiteOutput { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDOutputWarehouse { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDOutputLocationWarehouse { get; set; } 
        public IRPSTextBox<ArticleDetailView> ManufacturePrice { get; set; } 
        public IRPSTextBox<ArticleDetailView> ManufactureDate { get; set; } 
        public IRPSTextBox<ArticleDetailView> StandardPrice { get; set; } 
        public IRPSTextBox<ArticleDetailView> DeliveryDays { get; set; } 
        public IRPSTextBox<ArticleDetailView> ManufacturingLot { get; set; } 
        public IRPSTextBox<ArticleDetailView> StandardCostLot { get; set; } 
        public IRPSTextBox<ArticleDetailView> LaunchLot { get; set; } 
        public IRPSTextBox<ArticleDetailView> MinimumManufacturingLot { get; set; } 
        public IRPSTextBox<ArticleDetailView> ReturnPercent { get; set; } 
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
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<ArticleByLangView>("ff3a1eb6-80cd-4f63-bafc-dc6caafe071d","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ArticleByLangView>("964d6794-91a5-4d50-a878-081f275857b4","","",false, this);
 
            TechnicalDescription = RPSControlFactory.CreateRPSTextBox<ArticleByLangView>("b33855e1-641f-4603-92de-824eca61a5b5","","",false, this);
 
            GeneralData = RPSControlFactory.CreateRPSSection<ArticleByLangView>( "","ul li[rpsid='c3c35842-ba86-450e-b91c-d4e448a349e6']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<ArticleByLangView>( "","ul li[rpsid='27c2e5a2-186d-4a96-a3c8-5fe507b32d3f']","",this);
 

        }
        public IRPSButton<ArticleByLangView> DeleteButton { get; set; } 
        public IRPSButton<ArticleByLangView,ArticleEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleByLangView,ArticleEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ArticleByLangView,ArticleEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ArticleByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<ArticleByLangView> Description { get; set; } 
        public IRPSTextBox<ArticleByLangView> TechnicalDescription { get; set; } 
        public IRPSSection<ArticleByLangView> GeneralData { get; set; } 
        public IRPSSection<ArticleByLangView> Comments { get; set; } 
        public Article Screen { get; set; }
        public ArticleByLangView Wait(int seconds)
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
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ArticleAlternativeManufacturingView,ArticleEntityView>( this,Screen.ArticleEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ArticleAlternativeManufacturingView,ArticleEntityView>( this,Screen.ArticleEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ArticleAlternativeManufacturingView,ArticleEntityView>( this,Screen.ArticleEntityView);
 
            IDArticleEquivalent = RPSControlFactory.CreateRPSComboBox<ArticleAlternativeManufacturingView>("a04a1a6a-8329-4eb3-b23b-016708a29609","","",true, this);
 
            Priority = RPSControlFactory.CreateRPSFormattedTextBox<ArticleAlternativeManufacturingView>("766bee70-1e80-4197-95af-1c0fc44b801f","","",false, this);
 

        }
        public IRPSButton<ArticleAlternativeManufacturingView> DeleteButton { get; set; } 
        public IRPSButton<ArticleAlternativeManufacturingView,ArticleEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleAlternativeManufacturingView,ArticleEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ArticleAlternativeManufacturingView,ArticleEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ArticleAlternativeManufacturingView> IDArticleEquivalent { get; set; } 
        public IRPSTextBox<ArticleAlternativeManufacturingView> Priority { get; set; } 
        public Article Screen { get; set; }
        public ArticleAlternativeManufacturingView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}