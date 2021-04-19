    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.ManufacturingOrderCostByBudgetCategory
{
    //RPS VERSION 1.0.0.0
    public partial class ManufacturingOrderCostByBudgetCategory:Screen
    {
        public ManufacturingOrderCostByBudgetCategory():base()
        {
            this.URL = "manufacturing.manufacturingordercostbybudgetcategory";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ManufacturingOrderCostByBudgetCategoryQueryView  = new ManufacturingOrderCostByBudgetCategoryQueryView(this); 
            ManufacturingOrderCostByBudgetCategoryQueryView.InitializeControls(); 
           
        }
      
            public ManufacturingOrderCostByBudgetCategoryQueryView ManufacturingOrderCostByBudgetCategoryQueryView {get; set; } 
    }
            
    public partial class ManufacturingOrderCostByBudgetCategoryQueryView : View
    {
        public ManufacturingOrderCostByBudgetCategoryQueryView(ManufacturingOrderCostByBudgetCategory screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<ManufacturingOrderCostByBudgetCategoryQueryView>("311458b0-8dc9-426f-88a1-9c3b02b9f78f","","",false, this);
 
            ManufacturingOrder = RPSControlFactory.CreateRPSCollectionComboBox<ManufacturingOrderCostByBudgetCategoryQueryView>("20476727-0223-4695-9b01-cc861e8cef09","","",false, this);
 
            ManufacturingOrderSituation = RPSControlFactory.CreateRPSComboBox<ManufacturingOrderCostByBudgetCategoryQueryView>("696b4137-c0bf-49c2-a796-9e08ad28fa28","","",false, this);
 
            Project = RPSControlFactory.CreateRPSCollectionComboBox<ManufacturingOrderCostByBudgetCategoryQueryView>("cf6a02b7-7f62-4c01-a802-6ac0cdf2a25f","","",false, this);
 

        }
        public IRPSComboBox<ManufacturingOrderCostByBudgetCategoryQueryView> Site { get; set; } 
        public IRPSCollectionComboBox<ManufacturingOrderCostByBudgetCategoryQueryView> ManufacturingOrder { get; set; } 
        public IRPSComboBox<ManufacturingOrderCostByBudgetCategoryQueryView> ManufacturingOrderSituation { get; set; } 
        public IRPSCollectionComboBox<ManufacturingOrderCostByBudgetCategoryQueryView> Project { get; set; } 
        public ManufacturingOrderCostByBudgetCategory Screen { get; set; }
        public ManufacturingOrderCostByBudgetCategoryQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}