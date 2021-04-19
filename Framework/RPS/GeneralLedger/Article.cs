    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.Article
{
    //RPS VERSION 1.0.0.0
    public partial class Article:Screen
    {
        public Article():base()
        {
            this.URL = "generalledger.article";
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
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "1f92e126-f4a9-4ed7-b81a-fd4e33d0ec28",CSSSelectorDescriptor = "",XPathDescriptor = ""};
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
 
            CodArticle = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("ba032e1d-c1cc-4403-bfbb-faa026dd7d89","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("31da10ba-1b84-4487-9fe1-128d16851a2b","","",false, this);
 
            IDArticleAccType = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("9d55464a-7d43-44d6-a1b0-a5944ced21c5","","",true, this);
 
            InvestmentExpense = RPSControlFactory.CreateRPSEnumComboBox<ArticleEntityView>("f8a7265f-58ae-4542-a80b-68f2ded2523e","","",true, this);
 
            IDProductLine = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("7df25266-96f4-45cc-a8fc-bbf3b2b78764","","",false, this);
 
            IDProductFamily = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("35eb3700-f9cd-4a19-b57f-acf8b8d1b754","","",false, this);
 
            IDProductSubFamily = RPSControlFactory.CreateRPSComboBox<ArticleEntityView>("1755e7c5-b2d3-408b-bb63-d1e1c061ce5c","","",false, this);
 
            InactiveDate = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("80693b13-54a4-4710-89fa-02f8f373794e","","",false, this);
 
            MatchCode = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("7de85e2a-526d-481b-abc9-f76db30df1ff","","",false, this);
 
            PlanNumber = RPSControlFactory.CreateRPSTextBox<ArticleEntityView>("f1e9d99b-5c7f-4e9c-ada5-5f1b30d8eb95","","",false, this);
 
            CollectionInit params_ArticleByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6dcad7fa-f666-4926-be4b-8a5b6c5a2c15",CSSSelectorGrid="",XPathGrid=""};
            ArticleByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleByLangsCollectionEditor<ArticleEntityView,ArticleDetailView>,ArticleEntityView,ArticleDetailView>( params_ArticleByLangs,this,Screen.ArticleDetailView);
 
            CollectionInit params_ArticleDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="bade52c6-dd9d-4c0d-93d1-3f7cac9c4bf2",CSSSelectorGrid="",XPathGrid=""};
            ArticleDetails = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleDetailsCollectionEditor<ArticleEntityView,ArticleDetailView>,ArticleEntityView,ArticleDetailView>( params_ArticleDetails,this,Screen.ArticleDetailView);
 
            General = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='6f9816a8-af0c-4f52-ba1e-812b02f212b2']","",this);
 
            ArticlePerLang = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='1ee57260-1f27-483b-8c81-d074ba4d60f4']","",this);
 
            Subsidiaries = RPSControlFactory.CreateRPSSection<ArticleEntityView>( "","ul li[rpsid='620712a5-b204-4a4c-98c5-39a1eb689d2e']","",this);
 

        }
        public IRPSSaveButton<ArticleEntityView> SaveButton { get; set; } 
        public IRPSButton<ArticleEntityView> DeleteButton { get; set; } 
        public IRPSButton<ArticleEntityView,ArticleCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleEntityView,ArticleCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ArticleEntityView> CodArticle { get; set; } 
        public IRPSTextBox<ArticleEntityView> Description { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDArticleAccType { get; set; } 
        public IRPSComboBox<ArticleEntityView> InvestmentExpense { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDProductLine { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDProductFamily { get; set; } 
        public IRPSComboBox<ArticleEntityView> IDProductSubFamily { get; set; } 
        public IRPSTextBox<ArticleEntityView> InactiveDate { get; set; } 
        public IRPSTextBox<ArticleEntityView> MatchCode { get; set; } 
        public IRPSTextBox<ArticleEntityView> PlanNumber { get; set; } 
        public ArticleByLangsCollectionEditor<ArticleEntityView,ArticleDetailView> ArticleByLangs { get; set; } 
        public ArticleDetailsCollectionEditor<ArticleEntityView,ArticleDetailView> ArticleDetails { get; set; } 
        public IRPSSection<ArticleEntityView> General { get; set; } 
        public IRPSSection<ArticleEntityView> ArticlePerLang { get; set; } 
        public IRPSSection<ArticleEntityView> Subsidiaries { get; set; } 
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
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<ArticleEntityView>("","#6dcad7fa-f666-4926-be4b-8a5b6c5a2c15 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ArticleEntityView>("","#6dcad7fa-f666-4926-be4b-8a5b6c5a2c15 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ArticleEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<ArticleEntityView> Description { get; set; } 
                     
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
            CodCompany = RPSControlFactory.CreateRPSGridComboBox<ArticleEntityView>("","#bade52c6-dd9d-4c0d-93d1-3f7cac9c4bf2 .ag-row[role='row']@ROWINDEX [col-id='cCodCompany']","",true, this.CurrentView);
 
            IDArticleAccType = RPSControlFactory.CreateRPSGridComboBox<ArticleEntityView>("","#bade52c6-dd9d-4c0d-93d1-3f7cac9c4bf2 .ag-row[role='row']@ROWINDEX [col-id='cIDArticleAccType']","",true, this.CurrentView);
 
            PlanNumber = RPSControlFactory.CreateRPSGridTextBox<ArticleEntityView>("","#bade52c6-dd9d-4c0d-93d1-3f7cac9c4bf2 .ag-row[role='row']@ROWINDEX [col-id='cPlanNumber']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ArticleEntityView> CodCompany { get; set; } 
        public IRPSGridComboBox<ArticleEntityView> IDArticleAccType { get; set; } 
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
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<ArticleByLangView>("37545339-3717-475c-8230-37bcb1a5ec93","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ArticleByLangView>("594b3932-2b56-4135-b546-987ae9bef8b2","","",false, this);
 

        }
        public IRPSButton<ArticleByLangView> DeleteButton { get; set; } 
        public IRPSButton<ArticleByLangView,ArticleEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleByLangView,ArticleEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ArticleByLangView,ArticleEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ArticleByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<ArticleByLangView> Description { get; set; } 
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
 
            CodCompany = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("543d62c6-7c5f-40df-823d-2323e12367e1","","",true, this);
 
            IDArticleAccType = RPSControlFactory.CreateRPSComboBox<ArticleDetailView>("87d7b198-aa89-4065-86f6-4527f14e475d","","",true, this);
 
            PlanNumber = RPSControlFactory.CreateRPSTextBox<ArticleDetailView>("60970e45-7776-4d3c-902a-1c122abc9b4d","","",false, this);
 

        }
        public IRPSButton<ArticleDetailView> DeleteButton { get; set; } 
        public IRPSButton<ArticleDetailView,ArticleEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleDetailView,ArticleEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ArticleDetailView,ArticleEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ArticleDetailView> CodCompany { get; set; } 
        public IRPSComboBox<ArticleDetailView> IDArticleAccType { get; set; } 
        public IRPSTextBox<ArticleDetailView> PlanNumber { get; set; } 
        public Article Screen { get; set; }
        public ArticleDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}