    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.QualityDocumentType
{
    //RPS VERSION 1.0.0.0
    public partial class QualityDocumentType:Screen
    {
        public QualityDocumentType():base()
        {
            this.URL = "quality.qualitydocumenttype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            QualityDocumentTypeCollectionView  = new QualityDocumentTypeCollectionView(this); 
            QualityDocumentTypeEntityView  = new QualityDocumentTypeEntityView(this); 
            QualityDocumentTypeCollectionView.InitializeControls(); 
            QualityDocumentTypeEntityView.InitializeControls(); 
           
        }
      
            public QualityDocumentTypeCollectionView QualityDocumentTypeCollectionView {get; set; } 
            public QualityDocumentTypeEntityView QualityDocumentTypeEntityView {get; set; } 
    }
            
    public partial class QualityDocumentTypeCollectionView : View
    {
        public QualityDocumentTypeCollectionView(QualityDocumentType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<QualityDocumentTypeCollectionView,QualityDocumentTypeEntityView>( this,Screen.QualityDocumentTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "be708d5e-bfd4-4fb2-9920-22a9fbcaf39a",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<QualityDocumentTypeCollectionView,QualityDocumentTypeEntityView>( params_MainConsult,this,Screen.QualityDocumentTypeEntityView);
 

        }
        public IRPSButton<QualityDocumentTypeCollectionView,QualityDocumentTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<QualityDocumentTypeCollectionView,QualityDocumentTypeEntityView> MainConsult { get; set; } 
        public QualityDocumentType Screen { get; set; }
        public QualityDocumentTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class QualityDocumentTypeEntityView : View
    {
        public QualityDocumentTypeEntityView(QualityDocumentType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<QualityDocumentTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<QualityDocumentTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<QualityDocumentTypeEntityView,QualityDocumentTypeCollectionView>( this,Screen.QualityDocumentTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<QualityDocumentTypeEntityView,QualityDocumentTypeCollectionView>( this,Screen.QualityDocumentTypeCollectionView);
 
            Description = RPSControlFactory.CreateRPSTextBox<QualityDocumentTypeEntityView>("944cf088-b1f6-40d3-8958-c7637ed400b9","","",false, this);
 
            VersionWorkFlow = RPSControlFactory.CreateRPSCheckBox<QualityDocumentTypeEntityView>("333239ed-95b2-4793-847b-383fad985998","","",true, this);
 

        }
        public IRPSSaveButton<QualityDocumentTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<QualityDocumentTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<QualityDocumentTypeEntityView,QualityDocumentTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<QualityDocumentTypeEntityView,QualityDocumentTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<QualityDocumentTypeEntityView> Description { get; set; } 
        public IRPSCheckbox<QualityDocumentTypeEntityView> VersionWorkFlow { get; set; } 
        public QualityDocumentType Screen { get; set; }
        public QualityDocumentTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}