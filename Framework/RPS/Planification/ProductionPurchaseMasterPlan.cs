    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Planification.ProductionPurchaseMasterPlan
{
    //RPS VERSION 1.0.0.0
    public partial class ProductionPurchaseMasterPlan:Screen
    {
        public ProductionPurchaseMasterPlan():base()
        {
            this.URL = "planification.productionpurchasemasterplan";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ProductionPurchaseMasterPlanView  = new ProductionPurchaseMasterPlanView(this); 
            ProductionPurchaseMasterPlanView.InitializeControls(); 
           
        }
      
            public ProductionPurchaseMasterPlanView ProductionPurchaseMasterPlanView {get; set; } 
    }
            
    public partial class ProductionPurchaseMasterPlanView : View
    {
        public ProductionPurchaseMasterPlanView(ProductionPurchaseMasterPlan screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Customer = RPSControlFactory.CreateRPSCollectionComboBox<ProductionPurchaseMasterPlanView>("974870a6-7e9b-48c6-ba5e-fbb35420532f","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<ProductionPurchaseMasterPlanView>("f55dd2d3-eadd-4470-9d6d-c741e98737b1","","",false, this);
 
            Site = RPSControlFactory.CreateRPSComboBox<ProductionPurchaseMasterPlanView>("a23a554f-0247-4729-9b57-469eb5dd1378","","",true, this);
 
            WareHouse = RPSControlFactory.CreateRPSCollectionComboBox<ProductionPurchaseMasterPlanView>("0497069a-2070-4293-a6a6-9f1d2a071904","","",false, this);
 
            Scene = RPSControlFactory.CreateRPSComboBox<ProductionPurchaseMasterPlanView>("91ef268b-4413-420e-b5db-c61a0ebe0d28","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<ProductionPurchaseMasterPlanView>("fc6a9fb8-f8cc-4c86-b2a9-156124d66e6c","","",true, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<ProductionPurchaseMasterPlanView>("94ed7c40-a605-47fd-b248-da02f2d14b28","","",true, this);
 
            CheckParametersWarehouseAvailableMRP = RPSControlFactory.CreateRPSCheckBox<ProductionPurchaseMasterPlanView>("5b4eb631-2436-466e-bd85-475057c35339","","",false, this);
 
            CheckParametersFinishedArticles = RPSControlFactory.CreateRPSCheckBox<ProductionPurchaseMasterPlanView>("93e937a7-32cc-4ff7-b0ef-186bfb14e6b1","","",false, this);
 
            CheckParametersPurchaseTypeArticles = RPSControlFactory.CreateRPSCheckBox<ProductionPurchaseMasterPlanView>("3c72e2bc-16b5-4279-9178-56750e651607","","",false, this);
 
            CheckParametersStocksMin = RPSControlFactory.CreateRPSCheckBox<ProductionPurchaseMasterPlanView>("85d12f7e-d55d-48f7-bd96-41a29fe8c330","","",false, this);
 
            CheckUsePurchase = RPSControlFactory.CreateRPSCheckBox<ProductionPurchaseMasterPlanView>("ddb8ecae-ed51-497b-9141-d72ad47da75b","","",false, this);
 
            CheckUseSales = RPSControlFactory.CreateRPSCheckBox<ProductionPurchaseMasterPlanView>("8b1c434d-1c9d-4c0f-b974-8da6c7abe1fe","","",false, this);
 
            CheckUseManufacturingOrder = RPSControlFactory.CreateRPSCheckBox<ProductionPurchaseMasterPlanView>("e7b4d895-bdb7-4e53-b0dd-756c652bfa7a","","",false, this);
 
            CheckUseProject = RPSControlFactory.CreateRPSCheckBox<ProductionPurchaseMasterPlanView>("6d605312-2fe2-4d9f-a241-e1f1c2051473","","",false, this);
 
            CheckUseConsumptionForecast = RPSControlFactory.CreateRPSCheckBox<ProductionPurchaseMasterPlanView>("4f3a1028-6ef4-4601-baf0-8f371131f9dc","","",false, this);
 
            CheckUseSalesForecast = RPSControlFactory.CreateRPSCheckBox<ProductionPurchaseMasterPlanView>("7df8a28a-77a3-45e9-a374-93cc949c2701","","",false, this);
 
            CheckUseManufacturingForecast = RPSControlFactory.CreateRPSCheckBox<ProductionPurchaseMasterPlanView>("85bce62f-8955-40b2-8ac1-d7d53c14ed07","","",false, this);
 
            CheckUseIndustrialMaintenance = RPSControlFactory.CreateRPSCheckBox<ProductionPurchaseMasterPlanView>("2338411c-33ec-44c1-9839-c74cbb65763d","","",false, this);
 
            Daily = RPSControlFactory.CreateRPSOption<ProductionPurchaseMasterPlanView>( "e97d0f33-4a47-4f31-be1c-4dec6f5d197f","","",this);
 
            Weekly = RPSControlFactory.CreateRPSOption<ProductionPurchaseMasterPlanView>( "773f5841-c5e2-4e95-a850-06f90d6919e6","","",this);
 
            Fortnightly = RPSControlFactory.CreateRPSOption<ProductionPurchaseMasterPlanView>( "7f70549d-57cc-4f8b-8568-fadceaa7b054","","",this);
 
            Monthly = RPSControlFactory.CreateRPSOption<ProductionPurchaseMasterPlanView>( "cd381b71-edfb-44ce-91f9-880b447b31d7","","",this);
 
            SelectedOptionValue = RPSControlFactory.CreateRPSFormattedTextBox<ProductionPurchaseMasterPlanView>("ca146d15-44a6-4f28-8530-03b8bee517bb","","",false, this);
 
            ColumnsCommand = RPSControlFactory.CreateRPSButton<ProductionPurchaseMasterPlanView>( "6937462c-acaa-483d-846f-6b225259ee06","","",this);
 
            LinkNavigationCommandButton = RPSControlFactory.CreateRPSButton<ProductionPurchaseMasterPlanView>( "4bfe8280-ea78-4715-8b98-b9d4ae70bdd0","","",this);
 

        }
        public IRPSCollectionComboBox<ProductionPurchaseMasterPlanView> Customer { get; set; } 
        public IRPSCollectionComboBox<ProductionPurchaseMasterPlanView> Article { get; set; } 
        public IRPSComboBox<ProductionPurchaseMasterPlanView> Site { get; set; } 
        public IRPSCollectionComboBox<ProductionPurchaseMasterPlanView> WareHouse { get; set; } 
        public IRPSComboBox<ProductionPurchaseMasterPlanView> Scene { get; set; } 
        public IRPSTextBox<ProductionPurchaseMasterPlanView> DateFrom { get; set; } 
        public IRPSTextBox<ProductionPurchaseMasterPlanView> DateTo { get; set; } 
        public IRPSCheckbox<ProductionPurchaseMasterPlanView> CheckParametersWarehouseAvailableMRP { get; set; } 
        public IRPSCheckbox<ProductionPurchaseMasterPlanView> CheckParametersFinishedArticles { get; set; } 
        public IRPSCheckbox<ProductionPurchaseMasterPlanView> CheckParametersPurchaseTypeArticles { get; set; } 
        public IRPSCheckbox<ProductionPurchaseMasterPlanView> CheckParametersStocksMin { get; set; } 
        public IRPSCheckbox<ProductionPurchaseMasterPlanView> CheckUsePurchase { get; set; } 
        public IRPSCheckbox<ProductionPurchaseMasterPlanView> CheckUseSales { get; set; } 
        public IRPSCheckbox<ProductionPurchaseMasterPlanView> CheckUseManufacturingOrder { get; set; } 
        public IRPSCheckbox<ProductionPurchaseMasterPlanView> CheckUseProject { get; set; } 
        public IRPSCheckbox<ProductionPurchaseMasterPlanView> CheckUseConsumptionForecast { get; set; } 
        public IRPSCheckbox<ProductionPurchaseMasterPlanView> CheckUseSalesForecast { get; set; } 
        public IRPSCheckbox<ProductionPurchaseMasterPlanView> CheckUseManufacturingForecast { get; set; } 
        public IRPSCheckbox<ProductionPurchaseMasterPlanView> CheckUseIndustrialMaintenance { get; set; } 
        public IRPSOption<ProductionPurchaseMasterPlanView> Daily { get; set; } 
        public IRPSOption<ProductionPurchaseMasterPlanView> Weekly { get; set; } 
        public IRPSOption<ProductionPurchaseMasterPlanView> Fortnightly { get; set; } 
        public IRPSOption<ProductionPurchaseMasterPlanView> Monthly { get; set; } 
        public IRPSTextBox<ProductionPurchaseMasterPlanView> SelectedOptionValue { get; set; } 
        public IRPSButton<ProductionPurchaseMasterPlanView> ColumnsCommand { get; set; } 
        public IRPSButton<ProductionPurchaseMasterPlanView> LinkNavigationCommandButton { get; set; } 
        public ProductionPurchaseMasterPlan Screen { get; set; }
        public ProductionPurchaseMasterPlanView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}