    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.SituationMilestone
{
    //RPS VERSION 1.0.0.0
    public partial class SituationMilestone:Screen
    {
        public SituationMilestone():base()
        {
            this.URL = "project.situationmilestone";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SituationMilestoneCollectionView  = new SituationMilestoneCollectionView(this); 
            SituationMilestoneEntityView  = new SituationMilestoneEntityView(this); 
            SituationMilestoneCollectionView.InitializeControls(); 
            SituationMilestoneEntityView.InitializeControls(); 
           
        }
      
            public SituationMilestoneCollectionView SituationMilestoneCollectionView {get; set; } 
            public SituationMilestoneEntityView SituationMilestoneEntityView {get; set; } 
    }
            
    public partial class SituationMilestoneCollectionView : View
    {
        public SituationMilestoneCollectionView(SituationMilestone screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<SituationMilestoneCollectionView,SituationMilestoneEntityView>( this,Screen.SituationMilestoneEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "0ce71415-2f91-400d-8bf0-4af70af1502d",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<SituationMilestoneCollectionView,SituationMilestoneEntityView>( params_MainConsult,this,Screen.SituationMilestoneEntityView);
 

        }
        public IRPSButton<SituationMilestoneCollectionView,SituationMilestoneEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<SituationMilestoneCollectionView,SituationMilestoneEntityView> MainConsult { get; set; } 
        public SituationMilestone Screen { get; set; }
        public SituationMilestoneCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SituationMilestoneEntityView : View
    {
        public SituationMilestoneEntityView(SituationMilestone screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<SituationMilestoneEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<SituationMilestoneEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SituationMilestoneEntityView,SituationMilestoneCollectionView>( this,Screen.SituationMilestoneCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<SituationMilestoneEntityView,SituationMilestoneCollectionView>( this,Screen.SituationMilestoneCollectionView);
 
            CodSituationMilestone = RPSControlFactory.CreateRPSTextBox<SituationMilestoneEntityView>("4ff67c3b-bf23-40d5-b9fe-37cfa290d45f","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SituationMilestoneEntityView>("14d8227f-83f3-4de0-b601-dca2d00a34df","","",false, this);
 
            PercentProgress = RPSControlFactory.CreateRPSFormattedTextBox<SituationMilestoneEntityView>("8e68a8b8-9c47-4239-b442-562c2c950100","","",true, this);
 

        }
        public IRPSSaveButton<SituationMilestoneEntityView> SaveButton { get; set; } 
        public IRPSButton<SituationMilestoneEntityView> DeleteButton { get; set; } 
        public IRPSButton<SituationMilestoneEntityView,SituationMilestoneCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SituationMilestoneEntityView,SituationMilestoneCollectionView> BackButton { get; set; } 
        public IRPSTextBox<SituationMilestoneEntityView> CodSituationMilestone { get; set; } 
        public IRPSTextBox<SituationMilestoneEntityView> Description { get; set; } 
        public IRPSTextBox<SituationMilestoneEntityView> PercentProgress { get; set; } 
        public SituationMilestone Screen { get; set; }
        public SituationMilestoneEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}