    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Documents.DocumentManager
{
    //RPS VERSION 1.0.0.0
    public partial class DocumentManager:Screen
    {
        public DocumentManager():base()
        {
            this.URL = "documents.documentmanager";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DocumentManagerView  = new DocumentManagerView(this); 
            DocumentManagerView.InitializeControls(); 
           
        }
      
            public DocumentManagerView DocumentManagerView {get; set; } 
    }
            
    public partial class DocumentManagerView : View
    {
        public DocumentManagerView(DocumentManager screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_DocumentRepository = new CollectionInit(){IDDescriptor = "46caf563-ae2f-4e78-8e01-70405bc3068a",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            DocumentRepository = RPSControlFactory.RPSCreateCollection<DocumentManagerView>( params_DocumentRepository,this);
 

        }
        public IRPSCollectionEditor<DocumentManagerView> DocumentRepository { get; set; } 
        public DocumentManager Screen { get; set; }
        public DocumentManagerView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}