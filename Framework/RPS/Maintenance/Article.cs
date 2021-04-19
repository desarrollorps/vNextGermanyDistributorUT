    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.Article
{
    //RPS VERSION 1.0.0.0
    public partial class Article:Screen
    {
        public Article():base()
        {
            this.URL = "maintenance.article";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ArticleCollectionView  = new ArticleCollectionView(this); 
            ArticleEntityView  = new ArticleEntityView(this); 
            ArticleAlternativeMaintenanceView  = new ArticleAlternativeMaintenanceView(this); 
            ArticleByLangView  = new ArticleByLangView(this); 
            ArticleDetailView  = new ArticleDetailView(this); 
            ArticleCollectionView.InitializeControls(); 
            ArticleEntityView.InitializeControls(); 
            ArticleAlternativeMaintenanceView.InitializeControls(); 
            ArticleByLangView.InitializeControls(); 
            ArticleDetailView.InitializeControls(); 
           
        }
      
            public ArticleCollectionView ArticleCollectionView {get; set; } 
            public ArticleEntityView ArticleEntityView {get; set; } 
            public ArticleAlternativeMaintenanceView ArticleAlternativeMaintenanceView {get; set; } 
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
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "0cbf1ccb-6488-483a-9587-efe90d8cef55",CSSSelectorDescriptor = "",XPathDescriptor = ""};
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
 
            CodArticle = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("a19251b7-25e0-49ca-bcfb-51c798db1cd0","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("d1702858-bf60-40af-911b-5a7245245876","","",false, this);
 
            IDProductLine = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("10586352-346a-4625-8cd1-53355a1fe259","","",false, this);
 
            IDProductFamily = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("81aa308d-702e-4ebb-9060-5260584a9ee3","","",false, this);
 
            IDProductSubFamily = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("5bc1db06-21ac-45b3-adf0-1a17c24549ef","","",false, this);
 
            InactiveDate = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("3ef421c9-50a0-45d6-b158-d2631d8c90d1","","",false, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<ArticleEntityView>("24ee5cd2-5dfd-412a-9d9f-d4b1a9f0b6c6","","",true, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("fb9b000f-fa67-4694-8945-1871ba6bd80f","","",false, this);
 
            StandardPrice = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("606ffea5-06b8-48bb-8b33-4a4fd1434660","","",true, this);
 
            MakeAutomaticOutput = RPSControlFactory.CreateRPSCheckBox<ArticleEntityView>("3a064513-48e9-4bc5-8f73-0ea915d97b19","","",true, this);
 
            ImputationCostUpdated = RPSControlFactory.CreateRPSCheckBox<ArticleEntityView>("132a9012-63d3-4854-a3ea-94e203a6648e","","",true, this);
 
            ImputationTotalQuantity = RPSControlFactory.CreateRPSCheckBox<ArticleEntityView>("7ba8a2cf-ce63-4852-8cc2-83e8fe0dcfc2","","",true, this);
 
            ProjectProvisionType = RPSControlFactory.CreateRPSEnumComboBox<ArticleEntityView>("d3ad1b57-375b-4ee3-8352-878a1e6f85ac","","",true, this);
 
            MatchCode = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("1a034797-8a65-4810-93d7-a060978c3e27","","",false, this);
 
            PlanNumber = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("caaf1545-c9cb-443b-b586-3b3d9227e524","","",false, this);
 
            IDSiteOutput = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("025f334b-1bc5-490d-b291-15d65ebbf433","","",false, this);
 
            IDOutputWarehouse = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("b4bbeba3-697c-4e61-949b-67f3fe7a586c","","",false, this);
 
            IDSiteEntry = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("c2587352-35e1-4049-9a06-3d159451603f","","",false, this);
 
            IDEntryWarehouse = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("643723e2-dd4e-43c5-8eff-c6c6f13351a3","","",false, this);
 
            SalesGuarantee = RPSControlFactory.CreateRPSCheckBox<ArticleEntityView>("e13d8840-178d-4f75-b2f7-2e03b2416fe9","","",true, this);
 
            SalesGuaranteePeriod = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("3b290f8f-742a-4f20-a55c-b8e211eaf9b6","","",true, this);
 
            TechnicalDescription = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("828e5353-320b-4a50-a06a-5e6a495660e7","","",false, this);
 
            Notes = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("1041d864-3d45-4a28-ae0b-1b56afa6f467","","",false, this);
 
            CollectionInit params_MANArticleAlternativeMaintenances = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="9f5a82c9-7910-4d38-8325-6be7c690f6dc",CSSSelectorGrid="",XPathGrid=""};
            MANArticleAlternativeMaintenances = RPSControlFactory.RPSCreateCollectionWithGrid<MANArticleAlternativeMaintenancesCollectionEditor<ArticleEntityView,ArticleAlternativeMaintenanceView>,ArticleEntityView,ArticleAlternativeMaintenanceView>( params_MANArticleAlternativeMaintenances,this,Screen.ArticleAlternativeMaintenanceView);
 
            CollectionInit params_ArticleByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="9aa05b18-cb39-479d-8eec-43b6690a19f3",CSSSelectorGrid="",XPathGrid=""};
            ArticleByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleByLangsCollectionEditor<ArticleEntityView,ArticleAlternativeMaintenanceView>,ArticleEntityView,ArticleAlternativeMaintenanceView>( params_ArticleByLangs,this,Screen.ArticleAlternativeMaintenanceView);
 
            CollectionInit params_ArticleDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="739addbc-d967-4d4e-a739-deed782b624e",CSSSelectorGrid="",XPathGrid=""};
            ArticleDetails = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleDetailsCollectionEditor<ArticleEntityView,ArticleAlternativeMaintenanceView>,ArticleEntityView,ArticleAlternativeMaintenanceView>( params_ArticleDetails,this,Screen.ArticleAlternativeMaintenanceView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='ff2d3f8a-9b2c-434f-95ea-0c90162cba01']","",this);
 
            TechnicalDescription1 = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='80b37522-82be-4915-a4d2-edd7f510f19e']","",this);
 
            Alternative = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='ea8d13af-2399-453f-a213-6806a04f8299']","",this);
 
            Language = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='826abcf3-2228-4989-b000-b296d752a848']","",this);
 
            Subsidiaries = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='23fe1268-da9e-48b3-9433-e096aff0637f']","",this);
 
            Notes1 = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='c9f1ab01-9ba1-4978-a946-dfd12ceb3772']","",this);
 

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
        public IRPSComboBox<ArticleEntityView> IDSupplier { get; set; } 
        public IRPSTextBox<ArticleEntityView> StandardPrice { get; set; } 
        public IRPSCheckbox<ArticleEntityView> MakeAutomaticOutput { get; set; } 
        public IRPSCheckbox<ArticleEntityView> ImputationCostUpdated { get; set; } 
        public IRPSCheckbox<ArticleEntityView> ImputationTotalQuantity { get; set; } 
        public IRPSComboBox<ArticleEntityView> ProjectProvisionType { get; set; } 
        public IRPSTextBox<ArticleEntityView> MatchCode { get; set; } 
        public IRPSTextBox<ArticleEntityView> PlanNumber { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDSiteOutput { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDOutputWarehouse { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDSiteEntry { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDEntryWarehouse { get; set; } 
        public IRPSCheckbox<ArticleEntityView> SalesGuarantee { get; set; } 
        public IRPSTextBox<ArticleEntityView> SalesGuaranteePeriod { get; set; } 
        public IRPSTextBox<ArticleEntityView> TechnicalDescription { get; set; } 
        public IRPSTextBox<ArticleEntityView> Notes { get; set; } 
        public MANArticleAlternativeMaintenancesCollectionEditor<ArticleEntityView,ArticleAlternativeMaintenanceView> MANArticleAlternativeMaintenances { get; set; } 
        public ArticleByLangsCollectionEditor<ArticleEntityView,ArticleAlternativeMaintenanceView> ArticleByLangs { get; set; } 
        public ArticleDetailsCollectionEditor<ArticleEntityView,ArticleAlternativeMaintenanceView> ArticleDetails { get; set; } 
        public IRPSSection<ArticleEntityView> GeneralData { get; set; } 
        public IRPSSection<ArticleEntityView> TechnicalDescription1 { get; set; } 
        public IRPSSection<ArticleEntityView> Alternative { get; set; } 
        public IRPSSection<ArticleEntityView> Language { get; set; } 
        public IRPSSection<ArticleEntityView> Subsidiaries { get; set; } 
        public IRPSSection<ArticleEntityView> Notes1 { get; set; } 
        public Article Screen { get; set; }
        public ArticleEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MANArticleAlternativeMaintenancesCollectionEditor<ArticleEntityView,ArticleAlternativeMaintenanceView>:RPSCollectionEditor<ArticleEntityView,ArticleAlternativeMaintenanceView> where ArticleEntityView : class, IView where ArticleAlternativeMaintenanceView : class, IView
    {
        public  MANArticleAlternativeMaintenancesGridView<ArticleEntityView,ArticleAlternativeMaintenanceView> GridView {get;set;}
    }
    public partial class MANArticleAlternativeMaintenancesGridView <ArticleEntityView,ArticleAlternativeMaintenanceView> :  RPSGridView<ArticleEntityView,ArticleAlternativeMaintenanceView> where ArticleEntityView : class, IView where ArticleAlternativeMaintenanceView : class, IView
    {
        public MANArticleAlternativeMaintenancesGridView(ArticleEntityView currentView,ArticleAlternativeMaintenanceView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticleEquivalent = RPSControlFactory.CreateRPSGridComboBox<ArticleEntityView>("","#9f5a82c9-7910-4d38-8325-6be7c690f6dc .ag-row[role='row']@ROWINDEX [col-id='cIDArticleEquivalent']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<ArticleEntityView> IDArticleEquivalent { get; set; } 
                     
    }
 
        public partial class ArticleByLangsCollectionEditor<ArticleEntityView,ArticleAlternativeMaintenanceView>:RPSCollectionEditor<ArticleEntityView,ArticleAlternativeMaintenanceView> where ArticleEntityView : class, IView where ArticleAlternativeMaintenanceView : class, IView
    {
        public  ArticleByLangsGridView<ArticleEntityView,ArticleAlternativeMaintenanceView> GridView {get;set;}
    }
    public partial class ArticleByLangsGridView <ArticleEntityView,ArticleAlternativeMaintenanceView> :  RPSGridView<ArticleEntityView,ArticleAlternativeMaintenanceView> where ArticleEntityView : class, IView where ArticleAlternativeMaintenanceView : class, IView
    {
        public ArticleByLangsGridView(ArticleEntityView currentView,ArticleAlternativeMaintenanceView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            TechnicalDescription = RPSControlFactory.CreateRPSGridMemoTextBox<ArticleEntityView>("","#9aa05b18-cb39-479d-8eec-43b6690a19f3 .ag-row[role='row']@ROWINDEX [col-id='cTechnicalDescription']","",false, this.CurrentView);
 
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<ArticleEntityView>("","#9aa05b18-cb39-479d-8eec-43b6690a19f3 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ArticleEntityView>("","#9aa05b18-cb39-479d-8eec-43b6690a19f3 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ArticleEntityView> TechnicalDescription { get; set; } 
        public IRPSGridComboBox<ArticleEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<ArticleEntityView> Description { get; set; } 
                     
    }
 
        public partial class ArticleDetailsCollectionEditor<ArticleEntityView,ArticleAlternativeMaintenanceView>:RPSCollectionEditor<ArticleEntityView,ArticleAlternativeMaintenanceView> where ArticleEntityView : class, IView where ArticleAlternativeMaintenanceView : class, IView
    {
        public  ArticleDetailsGridView<ArticleEntityView,ArticleAlternativeMaintenanceView> GridView {get;set;}
    }
    public partial class ArticleDetailsGridView <ArticleEntityView,ArticleAlternativeMaintenanceView> :  RPSGridView<ArticleEntityView,ArticleAlternativeMaintenanceView> where ArticleEntityView : class, IView where ArticleAlternativeMaintenanceView : class, IView
    {
        public ArticleDetailsGridView(ArticleEntityView currentView,ArticleAlternativeMaintenanceView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodCompany = RPSControlFactory.CreateRPSGridComboBox<ArticleEntityView>("","#739addbc-d967-4d4e-a739-deed782b624e .ag-row[role='row']@ROWINDEX [col-id='cCodCompany']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<ArticleEntityView>("","#739addbc-d967-4d4e-a739-deed782b624e .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            SalesGuarantee = RPSControlFactory.CreateRPSGridCheckBox<ArticleEntityView>("","#739addbc-d967-4d4e-a739-deed782b624e .ag-row[role='row']@ROWINDEX [col-id='cSalesGuarantee']","",true, this.CurrentView);
 
            SalesGuaranteePeriod = RPSControlFactory.CreateRPSGridFormattedTextBox<ArticleEntityView>("","#739addbc-d967-4d4e-a739-deed782b624e .ag-row[role='row']@ROWINDEX [col-id='cSalesGuaranteePeriod']","",true, this.CurrentView);
 
            StandardPrice = RPSControlFactory.CreateRPSGridFormattedTextBox<ArticleEntityView>("","#739addbc-d967-4d4e-a739-deed782b624e .ag-row[role='row']@ROWINDEX [col-id='cStandardPrice']","",true, this.CurrentView);
 
            IDSupplier = RPSControlFactory.CreateRPSGridComboBox<ArticleEntityView>("","#739addbc-d967-4d4e-a739-deed782b624e .ag-row[role='row']@ROWINDEX [col-id='cIDSupplier']","",false, this.CurrentView);
 
            PlanNumber = RPSControlFactory.CreateRPSGridTextBox<ArticleEntityView>("","#739addbc-d967-4d4e-a739-deed782b624e .ag-row[role='row']@ROWINDEX [col-id='cPlanNumber']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ArticleEntityView> CodCompany { get; set; } 
        public IRPSGridComboBox<ArticleEntityView> Type { get; set; } 
        public IRPSGridCheckbox<ArticleEntityView> SalesGuarantee { get; set; } 
        public IRPSGridTextBox<ArticleEntityView> SalesGuaranteePeriod { get; set; } 
        public IRPSGridTextBox<ArticleEntityView> StandardPrice { get; set; } 
        public IRPSGridComboBox<ArticleEntityView> IDSupplier { get; set; } 
        public IRPSGridTextBox<ArticleEntityView> PlanNumber { get; set; } 
                     
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
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ArticleAlternativeMaintenanceView,ArticleEntityView>( this,Screen.ArticleEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ArticleAlternativeMaintenanceView,ArticleEntityView>( this,Screen.ArticleEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ArticleAlternativeMaintenanceView,ArticleEntityView>( this,Screen.ArticleEntityView);
 
            IDArticleEquivalent = RPSControlFactory.CreateRPSComboBox<ArticleAlternativeMaintenanceView>("10be66f8-eb33-4a18-af19-9c5abe475b85","","",true, this);
 

        }
        public IRPSButton<ArticleAlternativeMaintenanceView> DeleteButton { get; set; } 
        public IRPSButton<ArticleAlternativeMaintenanceView,ArticleEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleAlternativeMaintenanceView,ArticleEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ArticleAlternativeMaintenanceView,ArticleEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ArticleAlternativeMaintenanceView> IDArticleEquivalent { get; set; } 
        public Article Screen { get; set; }
        public ArticleAlternativeMaintenanceView Wait(int seconds)
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
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<ArticleByLangView>("87715865-6cfa-4a97-b6bb-22a89d4a9b1c","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ArticleByLangView>("a4a596fd-c67d-4485-8fc5-c08a700e4c31","","",false, this);
 
            TechnicalDescription = RPSControlFactory.CreateRPSTextBox<ArticleByLangView>("6f5ffb23-9b39-44e4-b830-1ecd4f109f2e","","",false, this);
 

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
 
            CodCompany = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("dec5de4e-6250-4f2f-9b1a-d528366e76d7","","",true, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<ArticleDetailView>("ab65395d-713c-4775-b83c-9980baec866d","","",true, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("405d59e0-614d-4c40-afab-e58052ff8fcf","","",false, this);
 
            StandardPrice = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("92357a95-f57e-40f0-8a28-77ea82f1e808","","",true, this);
 
            ProjectProvisionType = RPSControlFactory.CreateRPSEnumComboBox<ArticleDetailView>("3fe3778c-23e4-45fe-a4a9-877127f09d4f","","",true, this);
 
            IDSiteOutput = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("138040e3-ae36-4705-b2a4-5166f2307940","","",false, this);
 
            IDOutputWarehouse = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("cdfc4888-b477-4395-a3e9-9b6a95436b46","","",false, this);
 
            IDSiteEntry = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("426350aa-e5b1-4b79-9b71-b8eb394831c8","","",false, this);
 
            IDEntryWarehouse = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("0f077367-45e7-4e69-a33a-a0078d805519","","",false, this);
 
            SalesGuarantee = RPSControlFactory.CreateRPSCheckBox<ArticleDetailView>("2e44bb78-9590-468d-bd47-19b462eede11","","",true, this);
 
            SalesGuaranteePeriod = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("fe2652f1-ee29-44c8-b53f-cc95c101663d","","",true, this);
 

        }
        public IRPSButton<ArticleDetailView> DeleteButton { get; set; } 
        public IRPSButton<ArticleDetailView,ArticleEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleDetailView,ArticleEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ArticleDetailView,ArticleEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ArticleDetailView> CodCompany { get; set; } 
        public IRPSComboBox<ArticleDetailView> Type { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDSupplier { get; set; } 
        public IRPSTextBox<ArticleDetailView> StandardPrice { get; set; } 
        public IRPSComboBox<ArticleDetailView> ProjectProvisionType { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDSiteOutput { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDOutputWarehouse { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDSiteEntry { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDEntryWarehouse { get; set; } 
        public IRPSCheckbox<ArticleDetailView> SalesGuarantee { get; set; } 
        public IRPSTextBox<ArticleDetailView> SalesGuaranteePeriod { get; set; } 
        public Article Screen { get; set; }
        public ArticleDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}