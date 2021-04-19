    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.Article
{
    //RPS VERSION 1.0.0.0
    public partial class Article:Screen
    {
        public Article():base()
        {
            this.URL = "project.article";
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
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "d0f01782-525d-46e1-b503-3da781c6ff43",CSSSelectorDescriptor = "",XPathDescriptor = ""};
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
 
            CodArticle = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("bc8e3030-0204-424b-9c1a-278d390b2687","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("44b82457-87e2-45b1-84b9-8915fca0a801","","",false, this);
 
            IDProductLine = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("95950d67-c0ee-41cf-be43-d4d8d4658ecc","","",false, this);
 
            IDProductFamily = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("d1c9b744-0542-4f30-bcb0-2629aac09821","","",false, this);
 
            IDProductSubFamily = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("46045c32-5c0c-401d-aa76-24807ea8657d","","",false, this);
 
            InactiveDate = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("f058fc45-5d02-46f9-a08f-87dc75f7102e","","",false, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<ArticleEntityView>("c8b932ef-c175-4209-9b6f-3b2e6ba9d77e","","",true, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("fc90466e-a5f5-4c65-8832-3ff5aec2a76f","","",false, this);
 
            DeliveryDays = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("47ff5ec7-0215-4a02-bb69-bae2a7624474","","",true, this);
 
            StandardPrice = RPSControlFactory.CreateRPSFormattedTextBox<ArticleEntityView>("44526479-2ae9-44f4-a03b-f2af73c610b2","","",true, this);
 
            MakeAutomaticOutput = RPSControlFactory.CreateRPSCheckBox<ArticleEntityView>("d70cb675-3059-48ae-af8f-8926e64bb98e","","",true, this);
 
            ImputationTotalQuantity = RPSControlFactory.CreateRPSCheckBox<ArticleEntityView>("f2126917-6056-4b75-9735-1a8748216d26","","",true, this);
 
            ImputationCostUpdated = RPSControlFactory.CreateRPSCheckBox<ArticleEntityView>("9ede0589-2df2-46dc-84c7-9b1e40d0a70e","","",true, this);
 
            ProjectProvisionType = RPSControlFactory.CreateRPSEnumComboBox<ArticleEntityView>("96a17d6e-83fb-495d-9eed-982294d2e00d","","",true, this);
 
            MatchCode = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("56cd3dd2-8b63-4fb7-93f8-a80ec66e6b92","","",false, this);
 
            PlanNumber = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("6f3d1fff-25ab-4d77-9af9-8fe9be1b8718","","",false, this);
 
            MultipleCADLink = RPSControlFactory.CreateRPSCheckBox<ArticleEntityView>("6897d9e2-d734-4121-8f4e-097ebb6e0484","","",true, this);
 
            ComponentsGroupType = RPSControlFactory.CreateRPSEnumComboBox<ArticleEntityView>("10744c21-76b9-466c-8f97-0f8e8caab17c","","",true, this);
 
            IDUnitQuantityWarehouse = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("4602be0d-23da-49f8-b9c8-f3541a5fbea3","","",true, this);
 
            IDUnitPriceWarehouse = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("543fa1e9-db55-4e12-80aa-f8dc2353b359","","",true, this);
 
            IDSiteEntry = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("4cdb9da1-8d08-42e4-8cb0-d976e6b6fa91","","",false, this);
 
            IDEntryWarehouse = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("bed7e11f-551f-43aa-8663-c1466df36a2d","","",false, this);
 
            IDSiteOutput = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("93ccacf7-e196-46db-8cfb-4ec364689e03","","",false, this);
 
            IDOutputWarehouse = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("ee9574e9-5587-4e80-a605-e23dd3497f03","","",false, this);
 
            Notes = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("604ac816-900c-47f6-b7d0-8434e98cb7a4","","",false, this);
 
            CollectionInit params_ArticleByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c2d322c7-a11e-4b33-81fc-d6a825b8cbdc",CSSSelectorGrid="",XPathGrid=""};
            ArticleByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleByLangsCollectionEditor<ArticleEntityView,ArticleDetailView>,ArticleEntityView,ArticleDetailView>( params_ArticleByLangs,this,Screen.ArticleDetailView);
 
            CollectionInit params_ArticleDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="06b4c319-80f0-4a88-98ac-bce23d1d81b2",CSSSelectorGrid="",XPathGrid=""};
            ArticleDetails = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleDetailsCollectionEditor<ArticleEntityView,ArticleDetailView>,ArticleEntityView,ArticleDetailView>( params_ArticleDetails,this,Screen.ArticleDetailView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='574591ed-e23c-4f62-84fb-0059039511d1']","",this);
 
            Languages = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='5f42eeb0-a40f-44f7-9c81-8ca854cde45d']","",this);
 
            Subsidiary = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='3427749b-7d6e-4ad6-a410-527c126bc54a']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='8232f8bd-d486-4205-b57e-cf787e50ab4f']","",this);
 

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
        public IRPSTextBox<ArticleEntityView> DeliveryDays { get; set; } 
        public IRPSTextBox<ArticleEntityView> StandardPrice { get; set; } 
        public IRPSCheckbox<ArticleEntityView> MakeAutomaticOutput { get; set; } 
        public IRPSCheckbox<ArticleEntityView> ImputationTotalQuantity { get; set; } 
        public IRPSCheckbox<ArticleEntityView> ImputationCostUpdated { get; set; } 
        public IRPSComboBox<ArticleEntityView> ProjectProvisionType { get; set; } 
        public IRPSTextBox<ArticleEntityView> MatchCode { get; set; } 
        public IRPSTextBox<ArticleEntityView> PlanNumber { get; set; } 
        public IRPSCheckbox<ArticleEntityView> MultipleCADLink { get; set; } 
        public IRPSComboBox<ArticleEntityView> ComponentsGroupType { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDUnitQuantityWarehouse { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDUnitPriceWarehouse { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDSiteEntry { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDEntryWarehouse { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDSiteOutput { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDOutputWarehouse { get; set; } 
        public IRPSTextBox<ArticleEntityView> Notes { get; set; } 
        public ArticleByLangsCollectionEditor<ArticleEntityView,ArticleDetailView> ArticleByLangs { get; set; } 
        public ArticleDetailsCollectionEditor<ArticleEntityView,ArticleDetailView> ArticleDetails { get; set; } 
        public IRPSSection<ArticleEntityView> GeneralData { get; set; } 
        public IRPSSection<ArticleEntityView> Languages { get; set; } 
        public IRPSSection<ArticleEntityView> Subsidiary { get; set; } 
        public IRPSSection<ArticleEntityView> Comments { get; set; } 
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
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<ArticleEntityView>("","#c2d322c7-a11e-4b33-81fc-d6a825b8cbdc .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ArticleEntityView>("","#c2d322c7-a11e-4b33-81fc-d6a825b8cbdc .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            TechnicalDescription = RPSControlFactory.CreateRPSGridMemoTextBox<ArticleEntityView>("","#c2d322c7-a11e-4b33-81fc-d6a825b8cbdc .ag-row[role='row']@ROWINDEX [col-id='cTechnicalDescription']","",false, this.CurrentView);
 

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
            CodCompany = RPSControlFactory.CreateRPSGridComboBox<ArticleEntityView>("","#06b4c319-80f0-4a88-98ac-bce23d1d81b2 .ag-row[role='row']@ROWINDEX [col-id='cCodCompany']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<ArticleEntityView>("","#06b4c319-80f0-4a88-98ac-bce23d1d81b2 .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            StandardPrice = RPSControlFactory.CreateRPSGridFormattedTextBox<ArticleEntityView>("","#06b4c319-80f0-4a88-98ac-bce23d1d81b2 .ag-row[role='row']@ROWINDEX [col-id='cStandardPrice']","",true, this.CurrentView);
 
            ValuationCostType = RPSControlFactory.CreateRPSGridEnumComboBox<ArticleEntityView>("","#06b4c319-80f0-4a88-98ac-bce23d1d81b2 .ag-row[role='row']@ROWINDEX [col-id='cValuationCostType']","",true, this.CurrentView);
 
            IDSupplier = RPSControlFactory.CreateRPSGridComboBox<ArticleEntityView>("","#06b4c319-80f0-4a88-98ac-bce23d1d81b2 .ag-row[role='row']@ROWINDEX [col-id='cIDSupplier']","",false, this.CurrentView);
 
            DeliveryDays = RPSControlFactory.CreateRPSGridFormattedTextBox<ArticleEntityView>("","#06b4c319-80f0-4a88-98ac-bce23d1d81b2 .ag-row[role='row']@ROWINDEX [col-id='cDeliveryDays']","",true, this.CurrentView);
 
            PlanNumber = RPSControlFactory.CreateRPSGridTextBox<ArticleEntityView>("","#06b4c319-80f0-4a88-98ac-bce23d1d81b2 .ag-row[role='row']@ROWINDEX [col-id='cPlanNumber']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ArticleEntityView> CodCompany { get; set; } 
        public IRPSGridComboBox<ArticleEntityView> Type { get; set; } 
        public IRPSGridTextBox<ArticleEntityView> StandardPrice { get; set; } 
        public IRPSGridComboBox<ArticleEntityView> ValuationCostType { get; set; } 
        public IRPSGridComboBox<ArticleEntityView> IDSupplier { get; set; } 
        public IRPSGridTextBox<ArticleEntityView> DeliveryDays { get; set; } 
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
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<ArticleByLangView>("fd7ad0ae-180d-4b4b-8659-78731db0e06c","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ArticleByLangView>("69507347-af08-46de-b386-e7292fbc3662","","",false, this);
 
            TechnicalDescription = RPSControlFactory.CreateRPSTextBox<ArticleByLangView>("5da30a41-7600-4ce8-9810-2d2021a67509","","",false, this);
 

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
 
            CodCompany = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("d54fa0b4-2fc2-4289-ab19-c610c1a36956","","",true, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<ArticleDetailView>("1f001a4a-65e1-4c38-a074-b0ba95442c73","","",true, this);
 
            ValuationCostType = RPSControlFactory.CreateRPSEnumComboBox<ArticleDetailView>("765959a6-179c-43b2-84a4-beb14ba25a5f","","",true, this);
 
            ProjectProvisionType = RPSControlFactory.CreateRPSEnumComboBox<ArticleDetailView>("6e9b1395-a793-4bf1-9bb2-956aef0c81cf","","",true, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("a45a3ded-d4c8-4803-8507-92911f5c8fde","","",false, this);
 
            StandardPrice = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("10abe4d6-8b15-45d4-bf81-96ebfe3cca11","","",true, this);
 
            DeliveryDays = RPSControlFactory.CreateRPSFormattedTextBox<ArticleDetailView>("70724e7c-c7f8-41fc-beb3-e2a1c557b963","","",true, this);
 
            PlanNumber = RPSControlFactory.CreateRPSTextBox<ArticleDetailView>("a5af3edf-3424-4150-be0c-718e478964a5","","",false, this);
 
            IDSiteEntry = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("9c525a11-7cc2-4c32-81c6-a4fd9e4e8074","","",false, this);
 
            IDEntryWarehouse = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("53955653-114f-4480-839b-c9c06b9ad0e0","","",false, this);
 
            IDSiteOutput = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("b5cbbb4a-8e31-4d78-ae12-eac52681e9af","","",false, this);
 
            IDOutputWarehouse = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("611bacf2-7cbb-44b9-aba3-905f807dc78f","","",false, this);
 

        }
        public IRPSButton<ArticleDetailView> DeleteButton { get; set; } 
        public IRPSButton<ArticleDetailView,ArticleEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleDetailView,ArticleEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ArticleDetailView,ArticleEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ArticleDetailView> CodCompany { get; set; } 
        public IRPSComboBox<ArticleDetailView> Type { get; set; } 
        public IRPSComboBox<ArticleDetailView> ValuationCostType { get; set; } 
        public IRPSComboBox<ArticleDetailView> ProjectProvisionType { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDSupplier { get; set; } 
        public IRPSTextBox<ArticleDetailView> StandardPrice { get; set; } 
        public IRPSTextBox<ArticleDetailView> DeliveryDays { get; set; } 
        public IRPSTextBox<ArticleDetailView> PlanNumber { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDSiteEntry { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDEntryWarehouse { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDSiteOutput { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDOutputWarehouse { get; set; } 
        public Article Screen { get; set; }
        public ArticleDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}