    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.CostConcept
{
    //RPS VERSION 1.0.0.0
    public partial class CostConcept:Screen
    {
        public CostConcept():base()
        {
            this.URL = "quality.costconcept";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CostConceptCollectionView  = new CostConceptCollectionView(this); 
            CostConceptEntityView  = new CostConceptEntityView(this); 
            CostConceptCollectionView.InitializeControls(); 
            CostConceptEntityView.InitializeControls(); 
           
        }
      
            public CostConceptCollectionView CostConceptCollectionView {get; set; } 
            public CostConceptEntityView CostConceptEntityView {get; set; } 
    }
            
    public partial class CostConceptCollectionView : View
    {
        public CostConceptCollectionView(CostConcept screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CostConceptCollectionView,CostConceptEntityView>( this,Screen.CostConceptEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "f7a9fbb2-07ed-4ddf-8cc3-ba8516c6ad80",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CostConceptCollectionView,CostConceptEntityView>( params_MainConsult,this,Screen.CostConceptEntityView);
 

        }
        public IRPSButton<CostConceptCollectionView,CostConceptEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CostConceptCollectionView,CostConceptEntityView> MainConsult { get; set; } 
        public CostConcept Screen { get; set; }
        public CostConceptCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CostConceptEntityView : View
    {
        public CostConceptEntityView(CostConcept screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CostConceptEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CostConceptEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CostConceptEntityView,CostConceptCollectionView>( this,Screen.CostConceptCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CostConceptEntityView,CostConceptCollectionView>( this,Screen.CostConceptCollectionView);
 
            CodCostConcept = RPSControlFactory.CreateRPSTextBox<CostConceptEntityView>("1423e9ff-22bd-4696-b75a-dad511f01673","","",true, this);
 
            IDCostGroup = RPSControlFactory.CreateRPSComboBox<CostConceptEntityView>("8a4420f1-1b99-4553-bb1c-8d25c99474cf","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CostConceptEntityView>("30c8a0b4-2db4-44e9-8f22-ef57e6b09dad","","",false, this);
 
            DefaultPrice = RPSControlFactory.CreateRPSFormattedTextBox<CostConceptEntityView>("5ed8c06a-79c9-449c-bea8-e95bfa600732","","",false, this);
 

        }
        public IRPSSaveButton<CostConceptEntityView> SaveButton { get; set; } 
        public IRPSButton<CostConceptEntityView> DeleteButton { get; set; } 
        public IRPSButton<CostConceptEntityView,CostConceptCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CostConceptEntityView,CostConceptCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CostConceptEntityView> CodCostConcept { get; set; } 
        public IRPSComboBox<CostConceptEntityView> IDCostGroup { get; set; } 
        public IRPSTextBox<CostConceptEntityView> Description { get; set; } 
        public IRPSTextBox<CostConceptEntityView> DefaultPrice { get; set; } 
        public CostConcept Screen { get; set; }
        public CostConceptEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}