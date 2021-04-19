    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.Occurrence
{
    //RPS VERSION 1.0.0.0
    public partial class Occurrence:Screen
    {
        public Occurrence():base()
        {
            this.URL = "quality.occurrence";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            OccurrenceCollectionView  = new OccurrenceCollectionView(this); 
            OccurrenceEntityView  = new OccurrenceEntityView(this); 
            OccurrenceCollectionView.InitializeControls(); 
            OccurrenceEntityView.InitializeControls(); 
           
        }
      
            public OccurrenceCollectionView OccurrenceCollectionView {get; set; } 
            public OccurrenceEntityView OccurrenceEntityView {get; set; } 
    }
            
    public partial class OccurrenceCollectionView : View
    {
        public OccurrenceCollectionView(Occurrence screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<OccurrenceCollectionView,OccurrenceEntityView>( this,Screen.OccurrenceEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "29028673-12b0-4fcf-a95a-c9e9e6536e58",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<OccurrenceCollectionView,OccurrenceEntityView>( params_MainConsult,this,Screen.OccurrenceEntityView);
 

        }
        public IRPSButton<OccurrenceCollectionView,OccurrenceEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<OccurrenceCollectionView,OccurrenceEntityView> MainConsult { get; set; } 
        public Occurrence Screen { get; set; }
        public OccurrenceCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OccurrenceEntityView : View
    {
        public OccurrenceEntityView(Occurrence screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<OccurrenceEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<OccurrenceEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<OccurrenceEntityView,OccurrenceCollectionView>( this,Screen.OccurrenceCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<OccurrenceEntityView,OccurrenceCollectionView>( this,Screen.OccurrenceCollectionView);
 
            Value = RPSControlFactory.CreateRPSFormattedTextBox<OccurrenceEntityView>("6044e98e-43f0-4aa3-afba-536e155f5995","","",true, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<OccurrenceEntityView>("283c7b14-2895-469a-ab69-26680eb7cc79","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<OccurrenceEntityView>("ebf65c9e-b749-4c5c-96d8-75d54e910e1a","","",false, this);
 
            Frequency = RPSControlFactory.CreateRPSTextBox<OccurrenceEntityView>("b1c18516-8ff2-44fa-aa3d-75d46445a180","","",false, this);
 

        }
        public IRPSSaveButton<OccurrenceEntityView> SaveButton { get; set; } 
        public IRPSButton<OccurrenceEntityView> DeleteButton { get; set; } 
        public IRPSButton<OccurrenceEntityView,OccurrenceCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<OccurrenceEntityView,OccurrenceCollectionView> BackButton { get; set; } 
        public IRPSTextBox<OccurrenceEntityView> Value { get; set; } 
        public IRPSComboBox<OccurrenceEntityView> IDCustomer { get; set; } 
        public IRPSTextBox<OccurrenceEntityView> Description { get; set; } 
        public IRPSTextBox<OccurrenceEntityView> Frequency { get; set; } 
        public Occurrence Screen { get; set; }
        public OccurrenceEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}