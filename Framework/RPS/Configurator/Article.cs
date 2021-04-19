    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Configurator.Article
{
    //RPS VERSION 1.0.0.0
    public partial class Article:Screen
    {
        public Article():base()
        {
            this.URL = "configurator.article";
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
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "16e13819-37ff-4ba5-9ccf-117c6c01f506",CSSSelectorDescriptor = "",XPathDescriptor = ""};
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
 
            CodArticle = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("62e2eddc-8c14-44fd-9ee4-bb2f360d4af5","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("f1244012-21d6-45a6-89f2-9308dc838f5a","","",false, this);
 
            IDProductLine = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("a03c6344-8cbb-4d3d-9596-ba56cdb1ae07","","",false, this);
 
            IDProductFamily = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("00d67752-2f69-4bed-9950-37c626b80451","","",false, this);
 
            IDProductSubFamily = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("f52500cc-16d3-4c06-81f4-a64ff9bcfbf2","","",false, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<ArticleEntityView>("8c1f3f9e-74e1-40b1-8fa2-424e4bef071c","","",false, this);
 
            InactiveDate = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("620048f6-0aab-48fd-9a28-753a5421ce74","","",false, this);
 
            MatchCode = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("fccafd48-1dc9-46be-b424-9f2a0b5c2930","","",false, this);
 
            PlanNumber = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("48dad54d-1d01-4416-a67b-7f1f3b924a03","","",false, this);
 
            IDUnitQuantityWarehouse = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("b2f8937e-eecc-498a-bc89-44047caf04ad","","",true, this);
 
            IDUnitPriceWarehouse = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("d1d85992-4a36-438d-89b2-8166f4cd92de","","",true, this);
 
            Notes = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("032e96b0-db73-41f4-aee1-916cf26571c4","","",false, this);
 
            CollectionInit params_ArticleByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5c069918-87ab-4e56-a54a-27a816b4fa56",CSSSelectorGrid="",XPathGrid=""};
            ArticleByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleByLangsCollectionEditor<ArticleEntityView,ArticleByLangView>,ArticleEntityView,ArticleByLangView>( params_ArticleByLangs,this,Screen.ArticleByLangView);
 
            CollectionInit params_ArticleDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f3badde2-1255-4ca5-b0ef-a40ee5e2837d",CSSSelectorGrid="",XPathGrid=""};
            ArticleDetails = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleDetailsCollectionEditor<ArticleEntityView,ArticleByLangView>,ArticleEntityView,ArticleByLangView>( params_ArticleDetails,this,Screen.ArticleByLangView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='ba05047a-d8ae-4b6b-b852-d29ddc2473f5']","",this);
 
            Languages = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='904eddf9-d908-471d-bc81-0a29cbc41185']","",this);
 
            Subsidiary = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='cb9c9392-5dca-4104-9e7b-6167eb886fd1']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='54b3963f-604a-4965-a395-faae3aaccc95']","",this);
 

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
        public IRPSComboBox<ArticleEntityView> Type { get; set; } 
        public IRPSTextBox<ArticleEntityView> InactiveDate { get; set; } 
        public IRPSTextBox<ArticleEntityView> MatchCode { get; set; } 
        public IRPSTextBox<ArticleEntityView> PlanNumber { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDUnitQuantityWarehouse { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDUnitPriceWarehouse { get; set; } 
        public IRPSTextBox<ArticleEntityView> Notes { get; set; } 
        public ArticleByLangsCollectionEditor<ArticleEntityView,ArticleByLangView> ArticleByLangs { get; set; } 
        public ArticleDetailsCollectionEditor<ArticleEntityView,ArticleByLangView> ArticleDetails { get; set; } 
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
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<ArticleEntityView>("","#5c069918-87ab-4e56-a54a-27a816b4fa56 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ArticleEntityView>("","#5c069918-87ab-4e56-a54a-27a816b4fa56 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            TechnicalDescription = RPSControlFactory.CreateRPSGridMemoTextBox<ArticleEntityView>("","#5c069918-87ab-4e56-a54a-27a816b4fa56 .ag-row[role='row']@ROWINDEX [col-id='cTechnicalDescription']","",false, this.CurrentView);
 

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
            CodCompany = RPSControlFactory.CreateRPSGridComboBox<ArticleEntityView>("","#f3badde2-1255-4ca5-b0ef-a40ee5e2837d .ag-row[role='row']@ROWINDEX [col-id='cCodCompany']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<ArticleEntityView>("","#f3badde2-1255-4ca5-b0ef-a40ee5e2837d .ag-row[role='row']@ROWINDEX [col-id='cType']","",false, this.CurrentView);
 
            PlanNumber = RPSControlFactory.CreateRPSGridTextBox<ArticleEntityView>("","#f3badde2-1255-4ca5-b0ef-a40ee5e2837d .ag-row[role='row']@ROWINDEX [col-id='cPlanNumber']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ArticleEntityView> CodCompany { get; set; } 
        public IRPSGridComboBox<ArticleEntityView> Type { get; set; } 
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
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<ArticleByLangView>("bc1affa8-a090-48b4-9f39-e6fd00e0d57e","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ArticleByLangView>("f43dda7e-9e6f-40e7-8a69-5983ff9b87c4","","",false, this);
 
            TechnicalDescription = RPSControlFactory.CreateRPSTextBox<ArticleByLangView>("d6a3d766-552e-44b3-85be-456dffcc5728","","",false, this);
 

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
 
            CodCompany = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("ef97ce14-09ae-42ac-8419-bd057ec0303a","","",true, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<ArticleDetailView>("1e720b73-a2e6-436a-96b5-8f69f18efaa3","","",false, this);
 
            PlanNumber = RPSControlFactory.CreateRPSTextBox<ArticleDetailView>("e720f1de-6fba-403b-8772-2fc732269d78","","",false, this);
 

        }
        public IRPSButton<ArticleDetailView> DeleteButton { get; set; } 
        public IRPSButton<ArticleDetailView,ArticleEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleDetailView,ArticleEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ArticleDetailView,ArticleEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ArticleDetailView> CodCompany { get; set; } 
        public IRPSComboBox<ArticleDetailView> Type { get; set; } 
        public IRPSTextBox<ArticleDetailView> PlanNumber { get; set; } 
        public Article Screen { get; set; }
        public ArticleDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}