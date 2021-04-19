    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Documents.GenDocumentVariableTableViewModel
{
    //RPS VERSION 1.0.0.0
    public partial class GenDocumentVariableTableViewModel:Screen
    {
        public GenDocumentVariableTableViewModel():base()
        {
            this.URL = "documents.gendocumentvariabletableviewmodel";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DocumentVariableTableCollectionView  = new DocumentVariableTableCollectionView(this); 
            DocumentVariableTableEntityView  = new DocumentVariableTableEntityView(this); 
            DocumentVariableTableCollectionView.InitializeControls(); 
            DocumentVariableTableEntityView.InitializeControls(); 
           
        }
      
            public DocumentVariableTableCollectionView DocumentVariableTableCollectionView {get; set; } 
            public DocumentVariableTableEntityView DocumentVariableTableEntityView {get; set; } 
    }
            
    public partial class DocumentVariableTableCollectionView : View
    {
        public DocumentVariableTableCollectionView(GenDocumentVariableTableViewModel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<DocumentVariableTableCollectionView,DocumentVariableTableEntityView>( this,Screen.DocumentVariableTableEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "4002c9d9-4395-4d66-b1bd-5bb3a40dbf7f",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<DocumentVariableTableCollectionView,DocumentVariableTableEntityView>( params_MainConsult,this,Screen.DocumentVariableTableEntityView);
 

        }
        public IRPSButton<DocumentVariableTableCollectionView,DocumentVariableTableEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<DocumentVariableTableCollectionView,DocumentVariableTableEntityView> MainConsult { get; set; } 
        public GenDocumentVariableTableViewModel Screen { get; set; }
        public DocumentVariableTableCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DocumentVariableTableEntityView : View
    {
        public DocumentVariableTableEntityView(GenDocumentVariableTableViewModel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<DocumentVariableTableEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<DocumentVariableTableEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DocumentVariableTableEntityView,DocumentVariableTableCollectionView>( this,Screen.DocumentVariableTableCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<DocumentVariableTableEntityView,DocumentVariableTableCollectionView>( this,Screen.DocumentVariableTableCollectionView);
 
            CodTable = RPSControlFactory.CreateRPSTextBox<DocumentVariableTableEntityView>("fa7dc5ee-2533-4acf-8ed9-4b87241d9982","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<DocumentVariableTableEntityView>("961c1ac1-25a1-4fac-b51f-fbd52687ab7c","","",false, this);
 
            CollectionInit params_DocumentVariableTableValues = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4f128d10-0abd-4e18-bb56-622e83a436ca",CSSSelectorGrid="",XPathGrid=""};
            DocumentVariableTableValues = RPSControlFactory.RPSCreateCollectionWithGrid<DocumentVariableTableValuesCollectionEditor<DocumentVariableTableEntityView>,DocumentVariableTableEntityView>( params_DocumentVariableTableValues,this);
 

        }
        public IRPSSaveButton<DocumentVariableTableEntityView> SaveButton { get; set; } 
        public IRPSButton<DocumentVariableTableEntityView> DeleteButton { get; set; } 
        public IRPSButton<DocumentVariableTableEntityView,DocumentVariableTableCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DocumentVariableTableEntityView,DocumentVariableTableCollectionView> BackButton { get; set; } 
        public IRPSTextBox<DocumentVariableTableEntityView> CodTable { get; set; } 
        public IRPSTextBox<DocumentVariableTableEntityView> Description { get; set; } 
        public DocumentVariableTableValuesCollectionEditor<DocumentVariableTableEntityView> DocumentVariableTableValues { get; set; } 
        public GenDocumentVariableTableViewModel Screen { get; set; }
        public DocumentVariableTableEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DocumentVariableTableValuesCollectionEditor<DocumentVariableTableEntityView>:RPSCollectionEditor<DocumentVariableTableEntityView> where DocumentVariableTableEntityView : class, IView
    {
        public  DocumentVariableTableValuesGridView<DocumentVariableTableEntityView> GridView {get;set;}
    }
    public partial class DocumentVariableTableValuesGridView <DocumentVariableTableEntityView> :  RPSGridView<DocumentVariableTableEntityView> where DocumentVariableTableEntityView : class, IView
    {
        public DocumentVariableTableValuesGridView(DocumentVariableTableEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Value = RPSControlFactory.CreateRPSGridTextBox<DocumentVariableTableEntityView>("","#4f128d10-0abd-4e18-bb56-622e83a436ca .ag-row[role='row']@ROWINDEX [col-id='cValue']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<DocumentVariableTableEntityView> Value { get; set; } 
                     
    }
 
    }
  
    

}