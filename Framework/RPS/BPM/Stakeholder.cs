    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.BPM.Stakeholder
{
    //RPS VERSION 1.0.0.0
    public partial class Stakeholder:Screen
    {
        public Stakeholder():base()
        {
            this.URL = "bpm.stakeholder";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            StakeholderCollectionView  = new StakeholderCollectionView(this); 
            StakeholderEntityView  = new StakeholderEntityView(this); 
            StakeholderCollectionView.InitializeControls(); 
            StakeholderEntityView.InitializeControls(); 
           
        }
      
            public StakeholderCollectionView StakeholderCollectionView {get; set; } 
            public StakeholderEntityView StakeholderEntityView {get; set; } 
    }
            
    public partial class StakeholderCollectionView : View
    {
        public StakeholderCollectionView(Stakeholder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<StakeholderCollectionView,StakeholderEntityView>( this,Screen.StakeholderEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "b3ad0418-ef01-4013-ac5e-78c5c369243f",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<StakeholderCollectionView,StakeholderEntityView>( params_MainConsult,this,Screen.StakeholderEntityView);
 

        }
        public IRPSButton<StakeholderCollectionView,StakeholderEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<StakeholderCollectionView,StakeholderEntityView> MainConsult { get; set; } 
        public Stakeholder Screen { get; set; }
        public StakeholderCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class StakeholderEntityView : View
    {
        public StakeholderEntityView(Stakeholder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<StakeholderEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<StakeholderEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<StakeholderEntityView,StakeholderCollectionView>( this,Screen.StakeholderCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<StakeholderEntityView,StakeholderCollectionView>( this,Screen.StakeholderCollectionView);
 
            CodStakeholder = RPSControlFactory.CreateRPSTextBox<StakeholderEntityView>("f8bf194e-b227-4b8e-aa3d-894ff69f840a","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<StakeholderEntityView>("2fbc75d4-8873-48b3-a295-2c9806de901f","","",false, this);
 

        }
        public IRPSSaveButton<StakeholderEntityView> SaveButton { get; set; } 
        public IRPSButton<StakeholderEntityView> DeleteButton { get; set; } 
        public IRPSButton<StakeholderEntityView,StakeholderCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<StakeholderEntityView,StakeholderCollectionView> BackButton { get; set; } 
        public IRPSTextBox<StakeholderEntityView> CodStakeholder { get; set; } 
        public IRPSTextBox<StakeholderEntityView> Description { get; set; } 
        public Stakeholder Screen { get; set; }
        public StakeholderEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}