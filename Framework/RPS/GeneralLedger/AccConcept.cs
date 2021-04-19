    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.AccConcept
{
    //RPS VERSION 1.0.0.0
    public partial class AccConcept:Screen
    {
        public AccConcept():base()
        {
            this.URL = "generalledger.accconcept";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            AccConceptCollectionView  = new AccConceptCollectionView(this); 
            AccConceptEntityView  = new AccConceptEntityView(this); 
            AccConceptCollectionView.InitializeControls(); 
            AccConceptEntityView.InitializeControls(); 
           
        }
      
            public AccConceptCollectionView AccConceptCollectionView {get; set; } 
            public AccConceptEntityView AccConceptEntityView {get; set; } 
    }
            
    public partial class AccConceptCollectionView : View
    {
        public AccConceptCollectionView(AccConcept screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<AccConceptCollectionView,AccConceptEntityView>( this,Screen.AccConceptEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "802a4931-6bb6-4624-b14f-937a0b029a9b",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<AccConceptCollectionView,AccConceptEntityView>( params_MainConsult,this,Screen.AccConceptEntityView);
 

        }
        public IRPSButton<AccConceptCollectionView,AccConceptEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<AccConceptCollectionView,AccConceptEntityView> MainConsult { get; set; } 
        public AccConcept Screen { get; set; }
        public AccConceptCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class AccConceptEntityView : View
    {
        public AccConceptEntityView(AccConcept screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<AccConceptEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<AccConceptEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<AccConceptEntityView,AccConceptCollectionView>( this,Screen.AccConceptCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<AccConceptEntityView,AccConceptCollectionView>( this,Screen.AccConceptCollectionView);
 
            CodAccConcept = RPSControlFactory.CreateRPSTextBox<AccConceptEntityView>("7d9d9be1-80a9-43ac-9209-976dbee7ebee","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<AccConceptEntityView>("bfc79706-9364-46b1-9474-607cf0838585","","",false, this);
 

        }
        public IRPSSaveButton<AccConceptEntityView> SaveButton { get; set; } 
        public IRPSButton<AccConceptEntityView> DeleteButton { get; set; } 
        public IRPSButton<AccConceptEntityView,AccConceptCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<AccConceptEntityView,AccConceptCollectionView> BackButton { get; set; } 
        public IRPSTextBox<AccConceptEntityView> CodAccConcept { get; set; } 
        public IRPSTextBox<AccConceptEntityView> Description { get; set; } 
        public AccConcept Screen { get; set; }
        public AccConceptEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}