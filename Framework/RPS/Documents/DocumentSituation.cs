    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Documents.DocumentSituation
{
    //RPS VERSION 1.0.0.0
    public partial class DocumentSituation:Screen
    {
        public DocumentSituation():base()
        {
            this.URL = "documents.documentsituation";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DocumentSituationCollectionView  = new DocumentSituationCollectionView(this); 
            DocumentSituationEntityView  = new DocumentSituationEntityView(this); 
            DocumentSituationCollectionView.InitializeControls(); 
            DocumentSituationEntityView.InitializeControls(); 
           
        }
      
            public DocumentSituationCollectionView DocumentSituationCollectionView {get; set; } 
            public DocumentSituationEntityView DocumentSituationEntityView {get; set; } 
    }
            
    public partial class DocumentSituationCollectionView : View
    {
        public DocumentSituationCollectionView(DocumentSituation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<DocumentSituationCollectionView,DocumentSituationEntityView>( this,Screen.DocumentSituationEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "27175d16-a8fb-4055-b8ab-ec0a0c520b32",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<DocumentSituationCollectionView,DocumentSituationEntityView>( params_MainConsult,this,Screen.DocumentSituationEntityView);
 

        }
        public IRPSButton<DocumentSituationCollectionView,DocumentSituationEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<DocumentSituationCollectionView,DocumentSituationEntityView> MainConsult { get; set; } 
        public DocumentSituation Screen { get; set; }
        public DocumentSituationCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DocumentSituationEntityView : View
    {
        public DocumentSituationEntityView(DocumentSituation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<DocumentSituationEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<DocumentSituationEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DocumentSituationEntityView,DocumentSituationCollectionView>( this,Screen.DocumentSituationCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<DocumentSituationEntityView,DocumentSituationCollectionView>( this,Screen.DocumentSituationCollectionView);
 
            CodSituation = RPSControlFactory.CreateRPSTextBox<DocumentSituationEntityView>("371910a5-70a4-475a-972f-63c7bb78907c","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<DocumentSituationEntityView>("130b5572-89b8-45b8-81d3-e9b317f463d0","","",false, this);
 
            NotEditable = RPSControlFactory.CreateRPSCheckBox<DocumentSituationEntityView>("61708696-d95d-4525-9872-92377e3bf1a3","","",true, this);
 

        }
        public IRPSSaveButton<DocumentSituationEntityView> SaveButton { get; set; } 
        public IRPSButton<DocumentSituationEntityView> DeleteButton { get; set; } 
        public IRPSButton<DocumentSituationEntityView,DocumentSituationCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DocumentSituationEntityView,DocumentSituationCollectionView> BackButton { get; set; } 
        public IRPSTextBox<DocumentSituationEntityView> CodSituation { get; set; } 
        public IRPSTextBox<DocumentSituationEntityView> Description { get; set; } 
        public IRPSCheckbox<DocumentSituationEntityView> NotEditable { get; set; } 
        public DocumentSituation Screen { get; set; }
        public DocumentSituationEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}