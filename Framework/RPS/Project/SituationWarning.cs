    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.SituationWarning
{
    //RPS VERSION 1.0.0.0
    public partial class SituationWarning:Screen
    {
        public SituationWarning():base()
        {
            this.URL = "project.situationwarning";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SituationWarningCollectionView  = new SituationWarningCollectionView(this); 
            SituationWarningEntityView  = new SituationWarningEntityView(this); 
            SituationWarningCollectionView.InitializeControls(); 
            SituationWarningEntityView.InitializeControls(); 
           
        }
      
            public SituationWarningCollectionView SituationWarningCollectionView {get; set; } 
            public SituationWarningEntityView SituationWarningEntityView {get; set; } 
    }
            
    public partial class SituationWarningCollectionView : View
    {
        public SituationWarningCollectionView(SituationWarning screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<SituationWarningCollectionView,SituationWarningEntityView>( this,Screen.SituationWarningEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "3099d2ef-3adb-4521-b1c3-9a302c739eed",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<SituationWarningCollectionView,SituationWarningEntityView>( params_MainConsult,this,Screen.SituationWarningEntityView);
 

        }
        public IRPSButton<SituationWarningCollectionView,SituationWarningEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<SituationWarningCollectionView,SituationWarningEntityView> MainConsult { get; set; } 
        public SituationWarning Screen { get; set; }
        public SituationWarningCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SituationWarningEntityView : View
    {
        public SituationWarningEntityView(SituationWarning screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<SituationWarningEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<SituationWarningEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SituationWarningEntityView,SituationWarningCollectionView>( this,Screen.SituationWarningCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<SituationWarningEntityView,SituationWarningCollectionView>( this,Screen.SituationWarningCollectionView);
 
            CodSituationWarning = RPSControlFactory.CreateRPSTextBox<SituationWarningEntityView>("2a907c53-23ab-4358-8fc2-dfe56dbeb741","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SituationWarningEntityView>("9b159198-b54e-4089-8d3a-5362eb53afae","","",false, this);
 

        }
        public IRPSSaveButton<SituationWarningEntityView> SaveButton { get; set; } 
        public IRPSButton<SituationWarningEntityView> DeleteButton { get; set; } 
        public IRPSButton<SituationWarningEntityView,SituationWarningCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SituationWarningEntityView,SituationWarningCollectionView> BackButton { get; set; } 
        public IRPSTextBox<SituationWarningEntityView> CodSituationWarning { get; set; } 
        public IRPSTextBox<SituationWarningEntityView> Description { get; set; } 
        public SituationWarning Screen { get; set; }
        public SituationWarningEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}