    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Documents.StopWords
{
    //RPS VERSION 1.0.0.0
    public partial class StopWords:Screen
    {
        public StopWords():base()
        {
            this.URL = "documents.stopwords";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            StopWordsView  = new StopWordsView(this); 
            StopWordsView.InitializeControls(); 
           
        }
      
            public StopWordsView StopWordsView {get; set; } 
    }
            
    public partial class StopWordsView : View
    {
        public StopWordsView(StopWords screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_DocumentSemanticSearchStopWords = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b364ca9c-e0ff-4697-a159-714c9131f516",CSSSelectorGrid="",XPathGrid=""};
            DocumentSemanticSearchStopWords = RPSControlFactory.RPSCreateCollectionWithGrid<DocumentSemanticSearchStopWordsCollectionEditor<StopWordsView>,StopWordsView>( params_DocumentSemanticSearchStopWords,this);
 

        }
        public DocumentSemanticSearchStopWordsCollectionEditor<StopWordsView> DocumentSemanticSearchStopWords { get; set; } 
        public StopWords Screen { get; set; }
        public StopWordsView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DocumentSemanticSearchStopWordsCollectionEditor<StopWordsView>:RPSCollectionEditor<StopWordsView> where StopWordsView : class, IView
    {
        public  DocumentSemanticSearchStopWordsGridView<StopWordsView> GridView {get;set;}
    }
    public partial class DocumentSemanticSearchStopWordsGridView <StopWordsView> :  RPSGridView<StopWordsView> where StopWordsView : class, IView
    {
        public DocumentSemanticSearchStopWordsGridView(StopWordsView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            line = RPSControlFactory.CreateRPSGridTextBox<StopWordsView>("","#b364ca9c-e0ff-4697-a159-714c9131f516 .ag-row[role='row']@ROWINDEX [col-id='cline']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<StopWordsView> line { get; set; } 
                     
    }
 
    }
  
    

}