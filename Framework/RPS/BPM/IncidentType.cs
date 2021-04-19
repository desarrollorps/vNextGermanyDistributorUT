    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.BPM.IncidentType
{
    //RPS VERSION 1.0.0.0
    public partial class IncidentType:Screen
    {
        public IncidentType():base()
        {
            this.URL = "bpm.incidenttype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            IncidentTypeCollectionView  = new IncidentTypeCollectionView(this); 
            IncidentTypeEntityView  = new IncidentTypeEntityView(this); 
            IncidentTypeCollectionView.InitializeControls(); 
            IncidentTypeEntityView.InitializeControls(); 
           
        }
      
            public IncidentTypeCollectionView IncidentTypeCollectionView {get; set; } 
            public IncidentTypeEntityView IncidentTypeEntityView {get; set; } 
    }
            
    public partial class IncidentTypeCollectionView : View
    {
        public IncidentTypeCollectionView(IncidentType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<IncidentTypeCollectionView,IncidentTypeEntityView>( this,Screen.IncidentTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "fb1235d8-e430-424f-b3e0-5ee6f46814ac",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<IncidentTypeCollectionView,IncidentTypeEntityView>( params_MainConsult,this,Screen.IncidentTypeEntityView);
 

        }
        public IRPSButton<IncidentTypeCollectionView,IncidentTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<IncidentTypeCollectionView,IncidentTypeEntityView> MainConsult { get; set; } 
        public IncidentType Screen { get; set; }
        public IncidentTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class IncidentTypeEntityView : View
    {
        public IncidentTypeEntityView(IncidentType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<IncidentTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<IncidentTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<IncidentTypeEntityView,IncidentTypeCollectionView>( this,Screen.IncidentTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<IncidentTypeEntityView,IncidentTypeCollectionView>( this,Screen.IncidentTypeCollectionView);
 
            CodIncidentType = RPSControlFactory.CreateRPSTextBox<IncidentTypeEntityView>("8a991e28-99d1-4f30-b1dd-09473eeb0f4f","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<IncidentTypeEntityView>("641cbb5b-7666-4d94-ae9f-af016527045c","","",false, this);
 

        }
        public IRPSSaveButton<IncidentTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<IncidentTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<IncidentTypeEntityView,IncidentTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<IncidentTypeEntityView,IncidentTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<IncidentTypeEntityView> CodIncidentType { get; set; } 
        public IRPSTextBox<IncidentTypeEntityView> Description { get; set; } 
        public IncidentType Screen { get; set; }
        public IncidentTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}