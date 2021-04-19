    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Documents.Synonymous
{
    //RPS VERSION 1.0.0.0
    public partial class Synonymous:Screen
    {
        public Synonymous():base()
        {
            this.URL = "documents.synonymous";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SynonymousView  = new SynonymousView(this); 
            SynonymousView.InitializeControls(); 
           
        }
      
            public SynonymousView SynonymousView {get; set; } 
    }
            
    public partial class SynonymousView : View
    {
        public SynonymousView(Synonymous screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_DocumentSemanticSearchSynonymous = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="88686efa-624c-4e70-9d10-89d42faa8980",CSSSelectorGrid="",XPathGrid=""};
            DocumentSemanticSearchSynonymous = RPSControlFactory.RPSCreateCollectionWithGrid<DocumentSemanticSearchSynonymousCollectionEditor<SynonymousView>,SynonymousView>( params_DocumentSemanticSearchSynonymous,this);
 

        }
        public DocumentSemanticSearchSynonymousCollectionEditor<SynonymousView> DocumentSemanticSearchSynonymous { get; set; } 
        public Synonymous Screen { get; set; }
        public SynonymousView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DocumentSemanticSearchSynonymousCollectionEditor<SynonymousView>:RPSCollectionEditor<SynonymousView> where SynonymousView : class, IView
    {
        public  DocumentSemanticSearchSynonymousGridView<SynonymousView> GridView {get;set;}
    }
    public partial class DocumentSemanticSearchSynonymousGridView <SynonymousView> :  RPSGridView<SynonymousView> where SynonymousView : class, IView
    {
        public DocumentSemanticSearchSynonymousGridView(SynonymousView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            line = RPSControlFactory.CreateRPSGridTextBox<SynonymousView>("","#88686efa-624c-4e70-9d10-89d42faa8980 .ag-row[role='row']@ROWINDEX [col-id='cline']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SynonymousView> line { get; set; } 
                     
    }
 
    }
  
    

}