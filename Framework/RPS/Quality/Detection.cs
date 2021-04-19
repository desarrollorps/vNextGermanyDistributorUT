    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.Detection
{
    //RPS VERSION 1.0.0.0
    public partial class Detection:Screen
    {
        public Detection():base()
        {
            this.URL = "quality.detection";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DetectionCollectionView  = new DetectionCollectionView(this); 
            DetectionEntityView  = new DetectionEntityView(this); 
            DetectionCollectionView.InitializeControls(); 
            DetectionEntityView.InitializeControls(); 
           
        }
      
            public DetectionCollectionView DetectionCollectionView {get; set; } 
            public DetectionEntityView DetectionEntityView {get; set; } 
    }
            
    public partial class DetectionCollectionView : View
    {
        public DetectionCollectionView(Detection screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<DetectionCollectionView,DetectionEntityView>( this,Screen.DetectionEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "b56a8ddb-d850-4595-a1ca-5b5335dc7479",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<DetectionCollectionView,DetectionEntityView>( params_MainConsult,this,Screen.DetectionEntityView);
 

        }
        public IRPSButton<DetectionCollectionView,DetectionEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<DetectionCollectionView,DetectionEntityView> MainConsult { get; set; } 
        public Detection Screen { get; set; }
        public DetectionCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DetectionEntityView : View
    {
        public DetectionEntityView(Detection screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<DetectionEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<DetectionEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DetectionEntityView,DetectionCollectionView>( this,Screen.DetectionCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<DetectionEntityView,DetectionCollectionView>( this,Screen.DetectionCollectionView);
 
            Description = RPSControlFactory.CreateRPSTextBox<DetectionEntityView>("85454ade-7213-42e6-844c-5b842dca2ba8","","",false, this);
 
            NoDetectionProbability = RPSControlFactory.CreateRPSTextBox<DetectionEntityView>("77323b1b-6dfa-4ac0-a460-92919a559eb1","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<DetectionEntityView>("9f354942-6af4-40d8-9690-da2997f876b8","","",false, this);
 
            Value = RPSControlFactory.CreateRPSFormattedTextBox<DetectionEntityView>("8f4ba1cb-144b-4be9-a23c-1892adbad7b6","","",true, this);
 

        }
        public IRPSSaveButton<DetectionEntityView> SaveButton { get; set; } 
        public IRPSButton<DetectionEntityView> DeleteButton { get; set; } 
        public IRPSButton<DetectionEntityView,DetectionCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DetectionEntityView,DetectionCollectionView> BackButton { get; set; } 
        public IRPSTextBox<DetectionEntityView> Description { get; set; } 
        public IRPSTextBox<DetectionEntityView> NoDetectionProbability { get; set; } 
        public IRPSComboBox<DetectionEntityView> IDCustomer { get; set; } 
        public IRPSTextBox<DetectionEntityView> Value { get; set; } 
        public Detection Screen { get; set; }
        public DetectionEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}