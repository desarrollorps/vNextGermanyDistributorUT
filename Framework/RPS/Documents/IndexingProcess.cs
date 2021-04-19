    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Documents.IndexingProcess
{
    //RPS VERSION 1.0.0.0
    public partial class IndexingProcess:Screen
    {
        public IndexingProcess():base()
        {
            this.URL = "documents.indexingprocess";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            IndexingProcessView  = new IndexingProcessView(this); 
            IndexingProcessView.InitializeControls(); 
           
        }
      
            public IndexingProcessView IndexingProcessView {get; set; } 
    }
            
    public partial class IndexingProcessView : View
    {
        public IndexingProcessView(IndexingProcess screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            FullIndex = RPSControlFactory.CreateRPSOption<IndexingProcessView>( "1783ddba-5cc0-48ea-8749-bf42d71e997e","","",this);
 
            IncIndex = RPSControlFactory.CreateRPSOption<IndexingProcessView>( "e03e74b4-ba9c-47d5-b6c7-a9c9c13648d2","","",this);
 
            ExecuteDocumentIndexingProcess = RPSControlFactory.CreateRPSButton<IndexingProcessView>( "55292ec6-e0b1-4e17-8971-8137b0e01d16","","",this);
 

        }
        public IRPSOption<IndexingProcessView> FullIndex { get; set; } 
        public IRPSOption<IndexingProcessView> IncIndex { get; set; } 
        public IRPSButton<IndexingProcessView> ExecuteDocumentIndexingProcess { get; set; } 
        public IndexingProcess Screen { get; set; }
        public IndexingProcessView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}