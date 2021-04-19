    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.ManufacturingOrderSituation
{
    //RPS VERSION 1.0.0.0
    public partial class ManufacturingOrderSituation:Screen
    {
        public ManufacturingOrderSituation():base()
        {
            this.URL = "manufacturing.manufacturingordersituation";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ManufacturingOrderSituationCollectionView  = new ManufacturingOrderSituationCollectionView(this); 
            ManufacturingOrderSituationEntityView  = new ManufacturingOrderSituationEntityView(this); 
            ManufacturingOrderSituationCollectionView.InitializeControls(); 
            ManufacturingOrderSituationEntityView.InitializeControls(); 
           
        }
      
            public ManufacturingOrderSituationCollectionView ManufacturingOrderSituationCollectionView {get; set; } 
            public ManufacturingOrderSituationEntityView ManufacturingOrderSituationEntityView {get; set; } 
    }
            
    public partial class ManufacturingOrderSituationCollectionView : View
    {
        public ManufacturingOrderSituationCollectionView(ManufacturingOrderSituation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ManufacturingOrderSituationCollectionView,ManufacturingOrderSituationEntityView>( this,Screen.ManufacturingOrderSituationEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "7cdcda09-3e07-412b-9f8f-8ce3a86c0f1e",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ManufacturingOrderSituationCollectionView,ManufacturingOrderSituationEntityView>( params_MainConsult,this,Screen.ManufacturingOrderSituationEntityView);
 

        }
        public IRPSButton<ManufacturingOrderSituationCollectionView,ManufacturingOrderSituationEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ManufacturingOrderSituationCollectionView,ManufacturingOrderSituationEntityView> MainConsult { get; set; } 
        public ManufacturingOrderSituation Screen { get; set; }
        public ManufacturingOrderSituationCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ManufacturingOrderSituationEntityView : View
    {
        public ManufacturingOrderSituationEntityView(ManufacturingOrderSituation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ManufacturingOrderSituationEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ManufacturingOrderSituationEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ManufacturingOrderSituationEntityView,ManufacturingOrderSituationCollectionView>( this,Screen.ManufacturingOrderSituationCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ManufacturingOrderSituationEntityView,ManufacturingOrderSituationCollectionView>( this,Screen.ManufacturingOrderSituationCollectionView);
 
            CodSituation = RPSControlFactory.CreateRPSTextBox<ManufacturingOrderSituationEntityView>("4b1dae87-fede-46cf-b70e-a84babb3a1c6","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ManufacturingOrderSituationEntityView>("99d7c558-d758-41c1-bff7-f94867db1468","","",false, this);
 
            SituationType = RPSControlFactory.CreateRPSEnumComboBox<ManufacturingOrderSituationEntityView>("47c65365-a50e-4593-bd3a-2216cd22413d","","",true, this);
 
            AllowImputations = RPSControlFactory.CreateRPSCheckBox<ManufacturingOrderSituationEntityView>("da0f0fd9-75d4-4549-b815-a97409f932f8","","",true, this);
 
            AllowImputationsMaterial = RPSControlFactory.CreateRPSCheckBox<ManufacturingOrderSituationEntityView>("3940b2e0-81c8-4bf1-b2dc-524e2ff58de5","","",false, this);
 
            AllowImputationsCost = RPSControlFactory.CreateRPSCheckBox<ManufacturingOrderSituationEntityView>("bdd6881a-f154-4c3d-9ad8-7b0d5f2ef893","","",false, this);
 

        }
        public IRPSSaveButton<ManufacturingOrderSituationEntityView> SaveButton { get; set; } 
        public IRPSButton<ManufacturingOrderSituationEntityView> DeleteButton { get; set; } 
        public IRPSButton<ManufacturingOrderSituationEntityView,ManufacturingOrderSituationCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ManufacturingOrderSituationEntityView,ManufacturingOrderSituationCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ManufacturingOrderSituationEntityView> CodSituation { get; set; } 
        public IRPSTextBox<ManufacturingOrderSituationEntityView> Description { get; set; } 
        public IRPSComboBox<ManufacturingOrderSituationEntityView> SituationType { get; set; } 
        public IRPSCheckbox<ManufacturingOrderSituationEntityView> AllowImputations { get; set; } 
        public IRPSCheckbox<ManufacturingOrderSituationEntityView> AllowImputationsMaterial { get; set; } 
        public IRPSCheckbox<ManufacturingOrderSituationEntityView> AllowImputationsCost { get; set; } 
        public ManufacturingOrderSituation Screen { get; set; }
        public ManufacturingOrderSituationEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}