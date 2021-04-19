    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.TrainingEvaluation
{
    //RPS VERSION 1.0.0.0
    public partial class TrainingEvaluation:Screen
    {
        public TrainingEvaluation():base()
        {
            this.URL = "general.trainingevaluation";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            TrainingEvaluationCollectionView  = new TrainingEvaluationCollectionView(this); 
            TrainingEvaluationEntityView  = new TrainingEvaluationEntityView(this); 
            TrainingEvaluationCollectionView.InitializeControls(); 
            TrainingEvaluationEntityView.InitializeControls(); 
           
        }
      
            public TrainingEvaluationCollectionView TrainingEvaluationCollectionView {get; set; } 
            public TrainingEvaluationEntityView TrainingEvaluationEntityView {get; set; } 
    }
            
    public partial class TrainingEvaluationCollectionView : View
    {
        public TrainingEvaluationCollectionView(TrainingEvaluation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<TrainingEvaluationCollectionView,TrainingEvaluationEntityView>( this,Screen.TrainingEvaluationEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "039b8486-185a-4bd2-859a-434feaa81525",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<TrainingEvaluationCollectionView,TrainingEvaluationEntityView>( params_MainConsult,this,Screen.TrainingEvaluationEntityView);
 

        }
        public IRPSButton<TrainingEvaluationCollectionView,TrainingEvaluationEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<TrainingEvaluationCollectionView,TrainingEvaluationEntityView> MainConsult { get; set; } 
        public TrainingEvaluation Screen { get; set; }
        public TrainingEvaluationCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class TrainingEvaluationEntityView : View
    {
        public TrainingEvaluationEntityView(TrainingEvaluation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<TrainingEvaluationEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<TrainingEvaluationEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<TrainingEvaluationEntityView,TrainingEvaluationCollectionView>( this,Screen.TrainingEvaluationCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<TrainingEvaluationEntityView,TrainingEvaluationCollectionView>( this,Screen.TrainingEvaluationCollectionView);
 
            CodEvaluation = RPSControlFactory.CreateRPSTextBox<TrainingEvaluationEntityView>("213bd09e-f69f-4a0a-ad38-8ad00ddc32b6","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<TrainingEvaluationEntityView>("bbcdeadf-84a1-4a29-bb6c-742758b6b93f","","",false, this);
 

        }
        public IRPSSaveButton<TrainingEvaluationEntityView> SaveButton { get; set; } 
        public IRPSButton<TrainingEvaluationEntityView> DeleteButton { get; set; } 
        public IRPSButton<TrainingEvaluationEntityView,TrainingEvaluationCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<TrainingEvaluationEntityView,TrainingEvaluationCollectionView> BackButton { get; set; } 
        public IRPSTextBox<TrainingEvaluationEntityView> CodEvaluation { get; set; } 
        public IRPSTextBox<TrainingEvaluationEntityView> Description { get; set; } 
        public TrainingEvaluation Screen { get; set; }
        public TrainingEvaluationEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}