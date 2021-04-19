    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.QualityPartType
{
    //RPS VERSION 1.0.0.0
    public partial class QualityPartType:Screen
    {
        public QualityPartType():base()
        {
            this.URL = "quality.qualityparttype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            QualityPartTypeCollectionView  = new QualityPartTypeCollectionView(this); 
            QualityPartTypeEntityView  = new QualityPartTypeEntityView(this); 
            QualityPartTypeCollectionView.InitializeControls(); 
            QualityPartTypeEntityView.InitializeControls(); 
           
        }
      
            public QualityPartTypeCollectionView QualityPartTypeCollectionView {get; set; } 
            public QualityPartTypeEntityView QualityPartTypeEntityView {get; set; } 
    }
            
    public partial class QualityPartTypeCollectionView : View
    {
        public QualityPartTypeCollectionView(QualityPartType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<QualityPartTypeCollectionView,QualityPartTypeEntityView>( this,Screen.QualityPartTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "fa7e0492-877f-4a71-8ead-bf9c4cb53238",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<QualityPartTypeCollectionView,QualityPartTypeEntityView>( params_MainConsult,this,Screen.QualityPartTypeEntityView);
 

        }
        public IRPSButton<QualityPartTypeCollectionView,QualityPartTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<QualityPartTypeCollectionView,QualityPartTypeEntityView> MainConsult { get; set; } 
        public QualityPartType Screen { get; set; }
        public QualityPartTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class QualityPartTypeEntityView : View
    {
        public QualityPartTypeEntityView(QualityPartType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<QualityPartTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<QualityPartTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<QualityPartTypeEntityView,QualityPartTypeCollectionView>( this,Screen.QualityPartTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<QualityPartTypeEntityView,QualityPartTypeCollectionView>( this,Screen.QualityPartTypeCollectionView);
 
            CodType = RPSControlFactory.CreateRPSTextBox<QualityPartTypeEntityView>("57591a4f-9511-43bf-9b96-5707c0563913","","",true, this);
 

        }
        public IRPSSaveButton<QualityPartTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<QualityPartTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<QualityPartTypeEntityView,QualityPartTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<QualityPartTypeEntityView,QualityPartTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<QualityPartTypeEntityView> CodType { get; set; } 
        public QualityPartType Screen { get; set; }
        public QualityPartTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}