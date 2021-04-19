    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.CashflowForecast.FXIEConcept
{
    //RPS VERSION 1.0.0.0
    public partial class FXIEConcept:Screen
    {
        public FXIEConcept():base()
        {
            this.URL = "cashflowforecast.fxieconcept";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            FXIEConceptCollectionView  = new FXIEConceptCollectionView(this); 
            FXIEConceptEntityView  = new FXIEConceptEntityView(this); 
            FXIEConceptCollectionView.InitializeControls(); 
            FXIEConceptEntityView.InitializeControls(); 
           
        }
      
            public FXIEConceptCollectionView FXIEConceptCollectionView {get; set; } 
            public FXIEConceptEntityView FXIEConceptEntityView {get; set; } 
    }
            
    public partial class FXIEConceptCollectionView : View
    {
        public FXIEConceptCollectionView(FXIEConcept screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<FXIEConceptCollectionView,FXIEConceptEntityView>( this,Screen.FXIEConceptEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "10052b7f-2f39-4bf5-b580-3f944b4c45b3",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<FXIEConceptCollectionView,FXIEConceptEntityView>( params_MainConsult,this,Screen.FXIEConceptEntityView);
 

        }
        public IRPSButton<FXIEConceptCollectionView,FXIEConceptEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<FXIEConceptCollectionView,FXIEConceptEntityView> MainConsult { get; set; } 
        public FXIEConcept Screen { get; set; }
        public FXIEConceptCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FXIEConceptEntityView : View
    {
        public FXIEConceptEntityView(FXIEConcept screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<FXIEConceptEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<FXIEConceptEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FXIEConceptEntityView,FXIEConceptCollectionView>( this,Screen.FXIEConceptCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<FXIEConceptEntityView,FXIEConceptCollectionView>( this,Screen.FXIEConceptCollectionView);
 
            CodFXIEConcept = RPSControlFactory.CreateRPSTextBox<FXIEConceptEntityView>("a47b53bb-6d76-49e1-8c97-4a2ae84a547e","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<FXIEConceptEntityView>("fa565806-80a7-4005-9c94-04158e901edf","","",false, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<FXIEConceptEntityView>("57820af3-55da-474f-aee2-ba5a0a787266","","",true, this);
 
            Order = RPSControlFactory.CreateRPSFormattedTextBox<FXIEConceptEntityView>("24cc2751-4046-4592-a5d2-f66c19209b79","","",false, this);
 

        }
        public IRPSSaveButton<FXIEConceptEntityView> SaveButton { get; set; } 
        public IRPSButton<FXIEConceptEntityView> DeleteButton { get; set; } 
        public IRPSButton<FXIEConceptEntityView,FXIEConceptCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FXIEConceptEntityView,FXIEConceptCollectionView> BackButton { get; set; } 
        public IRPSTextBox<FXIEConceptEntityView> CodFXIEConcept { get; set; } 
        public IRPSTextBox<FXIEConceptEntityView> Description { get; set; } 
        public IRPSComboBox<FXIEConceptEntityView> Type { get; set; } 
        public IRPSTextBox<FXIEConceptEntityView> Order { get; set; } 
        public FXIEConcept Screen { get; set; }
        public FXIEConceptEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}