    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Documents.SemanticSearchSynonymous
{
    //RPS VERSION 1.0.0.0
    public partial class SemanticSearchSynonymous:Screen
    {
        public SemanticSearchSynonymous():base()
        {
            this.URL = "documents.semanticsearchsynonymous";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SemanticSearchSynonymousView  = new SemanticSearchSynonymousView(this); 
            SemanticSearchSynonymousView.InitializeControls(); 
           
        }
      
            public SemanticSearchSynonymousView SemanticSearchSynonymousView {get; set; } 
    }
            
    public partial class SemanticSearchSynonymousView : View
    {
        public SemanticSearchSynonymousView(SemanticSearchSynonymous screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveCommandButton = RPSControlFactory.CreateRPSButton<SemanticSearchSynonymousView>( "f2de8f2e-a901-4bbd-a7ac-0da2d9b984e9","","",this);
 
            ExecuteSemanticSearchSynonymousListButton = RPSControlFactory.CreateRPSButton<SemanticSearchSynonymousView>( "0a4a4481-efc9-4355-8134-3ed3eb442c48","","",this);
 
            CollectionInit params_SynonimousList = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="45a1f85c-b3fe-49b0-bfdd-3749e21abf9c",CSSSelectorGrid="",XPathGrid=""};
            SynonimousList = RPSControlFactory.RPSCreateCollectionWithGrid<SynonimousListCollectionEditor<SemanticSearchSynonymousView>,SemanticSearchSynonymousView>( params_SynonimousList,this);
 

        }
        public IRPSButton<SemanticSearchSynonymousView> SaveCommandButton { get; set; } 
        public IRPSButton<SemanticSearchSynonymousView> ExecuteSemanticSearchSynonymousListButton { get; set; } 
        public SynonimousListCollectionEditor<SemanticSearchSynonymousView> SynonimousList { get; set; } 
        public SemanticSearchSynonymous Screen { get; set; }
        public SemanticSearchSynonymousView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SynonimousListCollectionEditor<SemanticSearchSynonymousView>:RPSCollectionEditor<SemanticSearchSynonymousView> where SemanticSearchSynonymousView : class, IView
    {
        public  SynonimousListGridView<SemanticSearchSynonymousView> GridView {get;set;}
    }
    public partial class SynonimousListGridView <SemanticSearchSynonymousView> :  RPSGridView<SemanticSearchSynonymousView> where SemanticSearchSynonymousView : class, IView
    {
        public SynonimousListGridView(SemanticSearchSynonymousView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            SynonymousText = RPSControlFactory.CreateRPSGridTextBox<SemanticSearchSynonymousView>("","#45a1f85c-b3fe-49b0-bfdd-3749e21abf9c .ag-row[role='row']@ROWINDEX [col-id='cSynonymousText']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SemanticSearchSynonymousView> SynonymousText { get; set; } 
                     
    }
 
    }
  
    

}