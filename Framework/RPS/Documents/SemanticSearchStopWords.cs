    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Documents.SemanticSearchStopWords
{
    //RPS VERSION 1.0.0.0
    public partial class SemanticSearchStopWords:Screen
    {
        public SemanticSearchStopWords():base()
        {
            this.URL = "documents.semanticsearchstopwords";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SemanticSearchStopWordsView  = new SemanticSearchStopWordsView(this); 
            SemanticSearchStopWordsView.InitializeControls(); 
           
        }
      
            public SemanticSearchStopWordsView SemanticSearchStopWordsView {get; set; } 
    }
            
    public partial class SemanticSearchStopWordsView : View
    {
        public SemanticSearchStopWordsView(SemanticSearchStopWords screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveCommandButton = RPSControlFactory.CreateRPSButton<SemanticSearchStopWordsView>( "417927e0-a4c4-4849-a9b3-cb854f8fbb54","","",this);
 
            ExecuteSemanticSearchStopWordsListButton = RPSControlFactory.CreateRPSButton<SemanticSearchStopWordsView>( "521c008c-57ae-4223-ac6a-fc536cc21a8a","","",this);
 
            CollectionInit params_StopWordsList = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f85ad584-709c-41ed-9fd3-192184cc0612",CSSSelectorGrid="",XPathGrid=""};
            StopWordsList = RPSControlFactory.RPSCreateCollectionWithGrid<StopWordsListCollectionEditor<SemanticSearchStopWordsView>,SemanticSearchStopWordsView>( params_StopWordsList,this);
 

        }
        public IRPSButton<SemanticSearchStopWordsView> SaveCommandButton { get; set; } 
        public IRPSButton<SemanticSearchStopWordsView> ExecuteSemanticSearchStopWordsListButton { get; set; } 
        public StopWordsListCollectionEditor<SemanticSearchStopWordsView> StopWordsList { get; set; } 
        public SemanticSearchStopWords Screen { get; set; }
        public SemanticSearchStopWordsView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class StopWordsListCollectionEditor<SemanticSearchStopWordsView>:RPSCollectionEditor<SemanticSearchStopWordsView> where SemanticSearchStopWordsView : class, IView
    {
        public  StopWordsListGridView<SemanticSearchStopWordsView> GridView {get;set;}
    }
    public partial class StopWordsListGridView <SemanticSearchStopWordsView> :  RPSGridView<SemanticSearchStopWordsView> where SemanticSearchStopWordsView : class, IView
    {
        public StopWordsListGridView(SemanticSearchStopWordsView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            StopWordText = RPSControlFactory.CreateRPSGridTextBox<SemanticSearchStopWordsView>("","#f85ad584-709c-41ed-9fd3-192184cc0612 .ag-row[role='row']@ROWINDEX [col-id='cStopWordText']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SemanticSearchStopWordsView> StopWordText { get; set; } 
                     
    }
 
    }
  
    

}