    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.CostCalculation
{
    //RPS VERSION 1.0.0.0
    public partial class CostCalculation:Screen
    {
        public CostCalculation():base()
        {
            this.URL = "manufacturing.costcalculation";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CostCalculationView  = new CostCalculationView(this); 
            CostCalculationView.InitializeControls(); 
           
        }
      
            public CostCalculationView CostCalculationView {get; set; } 
    }
            
    public partial class CostCalculationView : View
    {
        public CostCalculationView(CostCalculation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Article = RPSControlFactory.CreateRPSCollectionComboBox<CostCalculationView>("0961be7b-b1a6-4beb-90ca-6c610dd59419","","",false, this);
 
            Site = RPSControlFactory.CreateRPSComboBox<CostCalculationView>("6d51c620-ed62-4b01-83b4-d85be2074517","","",false, this);
 
            Route = RPSControlFactory.CreateRPSComboBox<CostCalculationView>("75d4212b-ab31-4ddc-ba63-9f5b49b14a18","","",true, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<CostCalculationView>("e92d5477-e100-4731-a409-7df814f9f040","","",false, this);
 
            UIPropagateRoutes = RPSControlFactory.CreateRPSCheckBox<CostCalculationView>("f459defa-c4d6-40ae-9818-94e709fba9ad","","",false, this);
 
            AveragePrice = RPSControlFactory.CreateRPSOption<CostCalculationView>( "97e9d8a7-11d7-4713-a8cd-9da0506ef14b","","",this);
 
            LastPurchaseManufacturing = RPSControlFactory.CreateRPSOption<CostCalculationView>( "c44992c0-f8b7-48cc-a894-a55dc4b3d613","","",this);
 
            StandardPrice = RPSControlFactory.CreateRPSOption<CostCalculationView>( "b868ae56-5679-4449-a5e1-6a0697c64389","","",this);
 
            ValuationCostPrice = RPSControlFactory.CreateRPSOption<CostCalculationView>( "338a1587-5c24-4883-98c4-0a1fb3ec1a08","","",this);
 
            UpdateStandardCost = RPSControlFactory.CreateRPSCheckBox<CostCalculationView>("6aa1d305-e155-42b2-a685-5042c05157db","","",false, this);
 
            SaveCostToDate = RPSControlFactory.CreateRPSCheckBox<CostCalculationView>("499108db-43cc-46d6-8631-ce332bc7b8f3","","",false, this);
 
            PurchaseTypeArticlesStructureTreat = RPSControlFactory.CreateRPSCheckBox<CostCalculationView>("8960422b-434f-4035-a747-b27ab600e3e3","","",false, this);
 
            Simulation = RPSControlFactory.CreateRPSCheckBox<CostCalculationView>("51f6355d-135a-4faa-b662-a6485600c09a","","",false, this);
 
            UpdatePriceArticle = RPSControlFactory.CreateRPSCheckBox<CostCalculationView>("15fdfca5-2574-4952-90f0-1aef0c7f7e9e","","",false, this);
 
            UpdateProjectMaterialTheoricCost = RPSControlFactory.CreateRPSCheckBox<CostCalculationView>("b80f6c3d-1176-4400-864b-45673439e64e","","",false, this);
 
            MakeCostMovement = RPSControlFactory.CreateRPSCheckBox<CostCalculationView>("716e7794-bf59-4962-8a1b-7d312107afdc","","",false, this);
 
            MovementType = RPSControlFactory.CreateRPSComboBox<CostCalculationView>("eb9892e8-1422-495a-952a-a1f6a0b824bb","","",false, this);
 
            ExecuteProcessRecalculateCost = RPSControlFactory.CreateRPSButton<CostCalculationView>( "0a0612dc-5425-4bcf-a30f-af98abe821a6","","",this);
 

        }
        public IRPSCollectionComboBox<CostCalculationView> Article { get; set; } 
        public IRPSComboBox<CostCalculationView> Site { get; set; } 
        public IRPSComboBox<CostCalculationView> Route { get; set; } 
        public IRPSTextBox<CostCalculationView> DateFrom { get; set; } 
        public IRPSCheckbox<CostCalculationView> UIPropagateRoutes { get; set; } 
        public IRPSOption<CostCalculationView> AveragePrice { get; set; } 
        public IRPSOption<CostCalculationView> LastPurchaseManufacturing { get; set; } 
        public IRPSOption<CostCalculationView> StandardPrice { get; set; } 
        public IRPSOption<CostCalculationView> ValuationCostPrice { get; set; } 
        public IRPSCheckbox<CostCalculationView> UpdateStandardCost { get; set; } 
        public IRPSCheckbox<CostCalculationView> SaveCostToDate { get; set; } 
        public IRPSCheckbox<CostCalculationView> PurchaseTypeArticlesStructureTreat { get; set; } 
        public IRPSCheckbox<CostCalculationView> Simulation { get; set; } 
        public IRPSCheckbox<CostCalculationView> UpdatePriceArticle { get; set; } 
        public IRPSCheckbox<CostCalculationView> UpdateProjectMaterialTheoricCost { get; set; } 
        public IRPSCheckbox<CostCalculationView> MakeCostMovement { get; set; } 
        public IRPSComboBox<CostCalculationView> MovementType { get; set; } 
        public IRPSButton<CostCalculationView> ExecuteProcessRecalculateCost { get; set; } 
        public CostCalculation Screen { get; set; }
        public CostCalculationView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}