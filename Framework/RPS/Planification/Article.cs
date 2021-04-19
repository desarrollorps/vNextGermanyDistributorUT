    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Planification.Article
{
    //RPS VERSION 1.0.0.0
    public partial class Article:Screen
    {
        public Article():base()
        {
            this.URL = "planification.article";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ArticleCollectionView  = new ArticleCollectionView(this); 
            ArticleEntityView  = new ArticleEntityView(this); 
            ArticleByLangView  = new ArticleByLangView(this); 
            ArticleDetailView  = new ArticleDetailView(this); 
            ArticleCollectionView.InitializeControls(); 
            ArticleEntityView.InitializeControls(); 
            ArticleByLangView.InitializeControls(); 
            ArticleDetailView.InitializeControls(); 
           
        }
      
            public ArticleCollectionView ArticleCollectionView {get; set; } 
            public ArticleEntityView ArticleEntityView {get; set; } 
            public ArticleByLangView ArticleByLangView {get; set; } 
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
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "b0a40332-646a-4504-bfb0-0637830b182a",CSSSelectorDescriptor = "",XPathDescriptor = ""};
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
 
            CodArticle = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("6ee9c554-4cbc-4c03-98e3-314bdb921b4e","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("120b50d1-30a6-4f3c-bd0f-fe3721dacd07","","",false, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<ArticleEntityView>("f1064cc7-7da5-476e-aa9f-4417593020fb","","",true, this);
 
            IDProductLine = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("3f32c0c0-54d0-4c13-b74c-faaf95703edd","","",false, this);
 
            IDProductFamily = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("a4ca1370-3e95-48cf-9d10-c57b54284a20","","",false, this);
 
            IDProductSubFamily = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("b17d1804-e836-4862-9fb5-fd9acdf9b207","","",false, this);
 
            BlockedManufacturing = RPSControlFactory.CreateRPSCheckBox<ArticleEntityView>("982fad71-48d4-4186-a3b9-f521bf4e612c","","",true, this);
 
            BlockedPurchase = RPSControlFactory.CreateRPSCheckBox<ArticleEntityView>("5082e846-e16e-4fd4-9ddc-c849d57ded61","","",true, this);
 
            StockMin = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("d7732696-131f-40a7-bd51-7259f7ffcc5f","","",true, this);
 
            LaunchLot = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("a47efd7a-a60a-4ff6-8032-5a95c59148bb","","",true, this);
 
            MinimumManufacturingLot = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("15e9e9ae-4ac9-40fa-9008-d639d8a8f735","","",true, this);
 
            ReturnPercent = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("1815437b-b489-4d50-80f2-901d6b22857a","","",true, this);
 
            PurchaseLot = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("ccedef75-b5eb-4333-bc32-4e91708828eb","","",true, this);
 
            DeliveryDays = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("b55da3c0-5e94-4c70-b18a-9f75dfa5c54f","","",true, this);
 
            ManufacturingLot = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("f1fa5dab-66f8-410a-be7d-26ae94dbfb17","","",true, this);
 
            ManufacturingGroupCode = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("0a826de1-336e-4328-9a96-27571a4629fd","","",false, this);
 
            ManufacturingGroupQuantity = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("34c86b76-81af-4285-a0e3-8eeef7aac7de","","",true, this);
 
            MatchCode = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("18c63c37-7a64-4499-a068-de673967d91a","","",false, this);
 
            PlanNumber = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("917d505c-9b7a-4cb2-ac01-fe3b4286c26b","","",false, this);
 
            InactiveDate = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("a147f362-3237-4aef-9e4a-91ea5041aefc","","",false, this);
 
            MRPType = RPSControlFactory.CreateRPSEnumComboBox<ArticleEntityView>("3b1e2ab0-a494-4991-bac6-a2f73677163e","","",true, this);
 
            MRPPrevisionsOnly = RPSControlFactory.CreateRPSCheckBox<ArticleEntityView>("cdaaf842-3660-4159-958b-c3a46c6a4307","","",true, this);
 
            GroupDaysNumber = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("74d11415-65f2-4595-92ae-daba6d236027","","",true, this);
 
            GroupDays = RPSControlFactory.CreateRPSEnumComboBox<ArticleEntityView>("be32dfe9-7fec-4e4f-a746-9a1ef1af9b74","","",true, this);
 
            ConsumePrevisionBehavior = RPSControlFactory.CreateRPSEnumComboBox<ArticleEntityView>("c7551abd-49c3-4cb7-9e4d-d40aa69f3431","","",true, this);
 
            ConsumePrevision = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("33d7d982-5038-4166-b14e-e8a609676cc9","","",true, this);
 
            LotsReserve = RPSControlFactory.CreateRPSCheckBox<ArticleEntityView>("f2199916-d136-4b77-bed0-39e982c0b018","","",true, this);
 
            LotsReserveDays = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("ac3d8e95-1feb-48b9-bf2a-14f98b7ed3e9","","",true, this);
 
            LotsOrder = RPSControlFactory.CreateRPSCheckBox<ArticleEntityView>("51ed2438-ed4e-452f-b51a-b5b6e2a21556","","",true, this);
 
            LotsOrderDays = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("749277b7-2b4b-4631-ade0-376f57dd709f","","",true, this);
 
            IDProductionUnit = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("ad22b0f5-3c21-4114-9408-599b0998a2d1","","",false, this);
 
            EffortQuantity = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("a99d156d-50ea-4db8-9126-abc270126a09","","",false, this);
 
            StartingMarginDays = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("f146606e-f907-47e4-8b16-ba961c815a68","","",false, this);
 
            EndingMarginDays = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("3d7eabea-4207-4d90-a730-562ee774f448","","",false, this);
 
            Notes = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("f2908196-4061-4bbe-9ca1-94b6b1ba7916","","",false, this);
 
            CollectionInit params_ArticleByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ca03b3e0-0136-49d3-87e1-ff9af9a51a27",CSSSelectorGrid="",XPathGrid=""};
            ArticleByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleByLangsCollectionEditor<ArticleEntityView,ArticleDetailView>,ArticleEntityView,ArticleDetailView>( params_ArticleByLangs,this,Screen.ArticleDetailView);
 
            CollectionInit params_ArticleDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="09c28c8c-c792-48fa-b274-6ecae4217003",CSSSelectorGrid="",XPathGrid=""};
            ArticleDetails = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleDetailsCollectionEditor<ArticleEntityView,ArticleDetailView>,ArticleEntityView,ArticleDetailView>( params_ArticleDetails,this,Screen.ArticleDetailView);
 
            SectionGeneralData = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='4c690cf3-79a1-4604-ab6a-a1c0a888829a']","",this);
 
            SectionLanguage = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='0e55ba76-59c1-41cb-9e90-67ecd1db732d']","",this);
 
            SectionManufacturing = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='f15c21d9-6792-4170-80ee-6338cd6a9deb']","",this);
 
            Subisidiaries = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='dea01a2f-2425-486e-bb05-29137a137357']","",this);
 
            SectionNotes = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='ad3e1143-def6-4c6c-aabf-b9f05160f155']","",this);
 

        }
        public IRPSSaveButton<ArticleEntityView> SaveButton { get; set; } 
        public IRPSButton<ArticleEntityView> DeleteButton { get; set; } 
        public IRPSButton<ArticleEntityView,ArticleCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleEntityView,ArticleCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ArticleEntityView> CodArticle { get; set; } 
        public IRPSTextBox<ArticleEntityView> Description { get; set; } 
        public IRPSComboBox<ArticleEntityView> Type { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDProductLine { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDProductFamily { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDProductSubFamily { get; set; } 
        public IRPSCheckbox<ArticleEntityView> BlockedManufacturing { get; set; } 
        public IRPSCheckbox<ArticleEntityView> BlockedPurchase { get; set; } 
        public IRPSTextBox<ArticleEntityView> StockMin { get; set; } 
        public IRPSTextBox<ArticleEntityView> LaunchLot { get; set; } 
        public IRPSTextBox<ArticleEntityView> MinimumManufacturingLot { get; set; } 
        public IRPSTextBox<ArticleEntityView> ReturnPercent { get; set; } 
        public IRPSTextBox<ArticleEntityView> PurchaseLot { get; set; } 
        public IRPSTextBox<ArticleEntityView> DeliveryDays { get; set; } 
        public IRPSTextBox<ArticleEntityView> ManufacturingLot { get; set; } 
        public IRPSTextBox<ArticleEntityView> ManufacturingGroupCode { get; set; } 
        public IRPSTextBox<ArticleEntityView> ManufacturingGroupQuantity { get; set; } 
        public IRPSTextBox<ArticleEntityView> MatchCode { get; set; } 
        public IRPSTextBox<ArticleEntityView> PlanNumber { get; set; } 
        public IRPSTextBox<ArticleEntityView> InactiveDate { get; set; } 
        public IRPSComboBox<ArticleEntityView> MRPType { get; set; } 
        public IRPSCheckbox<ArticleEntityView> MRPPrevisionsOnly { get; set; } 
        public IRPSTextBox<ArticleEntityView> GroupDaysNumber { get; set; } 
        public IRPSComboBox<ArticleEntityView> GroupDays { get; set; } 
        public IRPSComboBox<ArticleEntityView> ConsumePrevisionBehavior { get; set; } 
        public IRPSTextBox<ArticleEntityView> ConsumePrevision { get; set; } 
        public IRPSCheckbox<ArticleEntityView> LotsReserve { get; set; } 
        public IRPSTextBox<ArticleEntityView> LotsReserveDays { get; set; } 
        public IRPSCheckbox<ArticleEntityView> LotsOrder { get; set; } 
        public IRPSTextBox<ArticleEntityView> LotsOrderDays { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDProductionUnit { get; set; } 
        public IRPSTextBox<ArticleEntityView> EffortQuantity { get; set; } 
        public IRPSTextBox<ArticleEntityView> StartingMarginDays { get; set; } 
        public IRPSTextBox<ArticleEntityView> EndingMarginDays { get; set; } 
        public IRPSTextBox<ArticleEntityView> Notes { get; set; } 
        public ArticleByLangsCollectionEditor<ArticleEntityView,ArticleDetailView> ArticleByLangs { get; set; } 
        public ArticleDetailsCollectionEditor<ArticleEntityView,ArticleDetailView> ArticleDetails { get; set; } 
        public IRPSSection<ArticleEntityView> SectionGeneralData { get; set; } 
        public IRPSSection<ArticleEntityView> SectionLanguage { get; set; } 
        public IRPSSection<ArticleEntityView> SectionManufacturing { get; set; } 
        public IRPSSection<ArticleEntityView> Subisidiaries { get; set; } 
        public IRPSSection<ArticleEntityView> SectionNotes { get; set; } 
        public Article Screen { get; set; }
        public ArticleEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ArticleByLangsCollectionEditor<ArticleEntityView,ArticleDetailView>:RPSCollectionEditor<ArticleEntityView,ArticleDetailView> where ArticleEntityView : class, IView where ArticleDetailView : class, IView
    {
        public  ArticleByLangsGridView<ArticleEntityView,ArticleDetailView> GridView {get;set;}
    }
    public partial class ArticleByLangsGridView <ArticleEntityView,ArticleDetailView> :  RPSGridView<ArticleEntityView,ArticleDetailView> where ArticleEntityView : class, IView where ArticleDetailView : class, IView
    {
        public ArticleByLangsGridView(ArticleEntityView currentView,ArticleDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<ArticleEntityView>("","#ca03b3e0-0136-49d3-87e1-ff9af9a51a27 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ArticleEntityView>("","#ca03b3e0-0136-49d3-87e1-ff9af9a51a27 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            TechnicalDescription = RPSControlFactory.CreateRPSGridMemoTextBox<ArticleEntityView>("","#ca03b3e0-0136-49d3-87e1-ff9af9a51a27 .ag-row[role='row']@ROWINDEX [col-id='cTechnicalDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ArticleEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<ArticleEntityView> Description { get; set; } 
        public IRPSGridTextBox<ArticleEntityView> TechnicalDescription { get; set; } 
                     
    }
 
        public partial class ArticleDetailsCollectionEditor<ArticleEntityView,ArticleDetailView>:RPSCollectionEditor<ArticleEntityView,ArticleDetailView> where ArticleEntityView : class, IView where ArticleDetailView : class, IView
    {
        public  ArticleDetailsGridView<ArticleEntityView,ArticleDetailView> GridView {get;set;}
    }
    public partial class ArticleDetailsGridView <ArticleEntityView,ArticleDetailView> :  RPSGridView<ArticleEntityView,ArticleDetailView> where ArticleEntityView : class, IView where ArticleDetailView : class, IView
    {
        public ArticleDetailsGridView(ArticleEntityView currentView,ArticleDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodCompany = RPSControlFactory.CreateRPSGridComboBox<ArticleEntityView>("","#09c28c8c-c792-48fa-b274-6ecae4217003 .ag-row[role='row']@ROWINDEX [col-id='cCodCompany']","",true, this.CurrentView);
 
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<ArticleEntityView>("","#09c28c8c-c792-48fa-b274-6ecae4217003 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<ArticleEntityView>("","#09c28c8c-c792-48fa-b274-6ecae4217003 .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            MRPType = RPSControlFactory.CreateRPSGridEnumComboBox<ArticleEntityView>("","#09c28c8c-c792-48fa-b274-6ecae4217003 .ag-row[role='row']@ROWINDEX [col-id='cMRPType']","",true, this.CurrentView);
 
            BlockedManufacturing = RPSControlFactory.CreateRPSGridCheckBox<ArticleEntityView>("","#09c28c8c-c792-48fa-b274-6ecae4217003 .ag-row[role='row']@ROWINDEX [col-id='cBlockedManufacturing']","",true, this.CurrentView);
 
            PlanNumber = RPSControlFactory.CreateRPSGridTextBox<ArticleEntityView>("","#09c28c8c-c792-48fa-b274-6ecae4217003 .ag-row[role='row']@ROWINDEX [col-id='cPlanNumber']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ArticleEntityView> CodCompany { get; set; } 
        public IRPSGridComboBox<ArticleEntityView> IDArticle { get; set; } 
        public IRPSGridComboBox<ArticleEntityView> Type { get; set; } 
        public IRPSGridComboBox<ArticleEntityView> MRPType { get; set; } 
        public IRPSGridCheckbox<ArticleEntityView> BlockedManufacturing { get; set; } 
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
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<ArticleByLangView>("1ef07450-fcf5-46d1-a34b-8afc1c488418","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ArticleByLangView>("fbf8d970-f937-4a76-8abc-784505068141","","",false, this);
 
            TechnicalDescription = RPSControlFactory.CreateRPSTextBox<ArticleByLangView>("f9fceaf3-2992-4e69-981e-4c9cf8aa6b71","","",false, this);
 

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
 
            CodCompany = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("73a30bab-6b66-424a-a512-276d45adee8f","","",true, this);
 
            ConsumePrevision = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("cbd8f3d9-70a7-42bb-9921-f3c1dc6acf30","","",true, this);
 
            DeliveryDays = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("5ca1128f-77ff-471a-8c8f-0b02ff71bf6d","","",true, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("aee6b61e-0445-49be-85c6-bb71afdceed4","","",true, this);
 
            LaunchLot = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("5d85a143-ffc4-4faf-8bfa-88289842cdcb","","",true, this);
 
            ManufacturingLot = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("fef51874-1374-477b-b58d-36d772f3c8d1","","",true, this);
 
            MinimumManufacturingLot = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("a7bf8231-09fe-45c9-9b94-c1e1a7e361ff","","",true, this);
 
            PurchaseLot = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("38f50029-f733-4b52-be84-1f5f70941eeb","","",true, this);
 
            ReturnPercent = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("35e131ed-a7ea-42a0-a1eb-2c7799250997","","",true, this);
 
            StockMin = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("e6609887-8847-4b65-88c8-7386105e8b4c","","",true, this);
 
            MRPType = RPSControlFactory.CreateRPSEnumComboBox<ArticleDetailView>("17f1649b-69fd-439d-bdca-c64fe9b475ac","","",true, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<ArticleDetailView>("b02a2470-23b2-4316-9966-251c2c42b80c","","",true, this);
 
            PlanNumber = RPSControlFactory.CreateRPSTextBox<ArticleDetailView>("f255f37f-d6ed-4924-a259-08c4ca42afed","","",false, this);
 
            IDProductionUnit = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("43100fd6-5762-4b8f-8924-c32c88424724","","",false, this);
 
            EffortQuantity = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("73eecf99-039a-46a9-8c0a-3103920e00ec","","",true, this);
 
            StartingMarginDays = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("a317e218-9572-4645-9249-fc761d01dabf","","",true, this);
 
            EndingMarginDays = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("b5dbeed9-9e2e-4824-898d-a8a70f4becfd","","",true, this);
 

        }
        public IRPSButton<ArticleDetailView> DeleteButton { get; set; } 
        public IRPSButton<ArticleDetailView,ArticleEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleDetailView,ArticleEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ArticleDetailView,ArticleEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ArticleDetailView> CodCompany { get; set; } 
        public IRPSTextBox<ArticleDetailView> ConsumePrevision { get; set; } 
        public IRPSTextBox<ArticleDetailView> DeliveryDays { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDArticle { get; set; } 
        public IRPSTextBox<ArticleDetailView> LaunchLot { get; set; } 
        public IRPSTextBox<ArticleDetailView> ManufacturingLot { get; set; } 
        public IRPSTextBox<ArticleDetailView> MinimumManufacturingLot { get; set; } 
        public IRPSTextBox<ArticleDetailView> PurchaseLot { get; set; } 
        public IRPSTextBox<ArticleDetailView> ReturnPercent { get; set; } 
        public IRPSTextBox<ArticleDetailView> StockMin { get; set; } 
        public IRPSComboBox<ArticleDetailView> MRPType { get; set; } 
        public IRPSComboBox<ArticleDetailView> Type { get; set; } 
        public IRPSTextBox<ArticleDetailView> PlanNumber { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDProductionUnit { get; set; } 
        public IRPSTextBox<ArticleDetailView> EffortQuantity { get; set; } 
        public IRPSTextBox<ArticleDetailView> StartingMarginDays { get; set; } 
        public IRPSTextBox<ArticleDetailView> EndingMarginDays { get; set; } 
        public Article Screen { get; set; }
        public ArticleDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}