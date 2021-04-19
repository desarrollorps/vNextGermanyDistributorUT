    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.MODeviationCost
{
    //RPS VERSION 1.0.0.0
    public partial class MODeviationCost:Screen
    {
        public MODeviationCost():base()
        {
            this.URL = "manufacturing.modeviationcost";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MODeviationCostQueryView  = new MODeviationCostQueryView(this); 
            MODeviationCostQueryView.InitializeControls(); 
           
        }
      
            public MODeviationCostQueryView MODeviationCostQueryView {get; set; } 
    }
            
    public partial class MODeviationCostQueryView : View
    {
        public MODeviationCostQueryView(MODeviationCost screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<MODeviationCostQueryView>("c97e718a-6a27-4316-8e2c-351fed562c71","","",false, this);
 
            ManufacturingOrder = RPSControlFactory.CreateRPSCollectionComboBox<MODeviationCostQueryView>("6ce553ed-2313-4a6f-9570-b34bd45d114d","","",false, this);
 
            ManufacturingOrderSituation = RPSControlFactory.CreateRPSCollectionComboBox<MODeviationCostQueryView>("eae5d40b-716d-4737-a5e6-2cc03bd156f7","","",false, this);
 
            Historic = RPSControlFactory.CreateRPSCheckBox<MODeviationCostQueryView>("5e979ff8-6437-42c8-9023-d9f77586f448","","",false, this);
 
            Project = RPSControlFactory.CreateRPSCollectionComboBox<MODeviationCostQueryView>("34b703ee-4b35-41fa-bb04-fac8587cc1b6","","",false, this);
 
            TaskNotStarted = RPSControlFactory.CreateRPSCheckBox<MODeviationCostQueryView>("addf15cc-716c-4f1a-8f06-7cb0808f7ca9","","",false, this);
 
            TaskInProgress = RPSControlFactory.CreateRPSCheckBox<MODeviationCostQueryView>("05741c26-83ed-49ab-89af-24ed0ebe1598","","",false, this);
 
            TaskFinished = RPSControlFactory.CreateRPSCheckBox<MODeviationCostQueryView>("5a396b66-dd0f-41e3-8961-5c8643ff9c44","","",false, this);
 
            DeviationPercent = RPSControlFactory.CreateRPSFormattedTextBox<MODeviationCostQueryView>("671bf16c-6109-4cbf-be3e-a8393f7641e5","","",false, this);
 
            Canceled = RPSControlFactory.CreateRPSCheckBox<MODeviationCostQueryView>("e5a62139-1062-4214-b1e3-7400abba38d5","","",false, this);
 
            Group = RPSControlFactory.CreateRPSTextBox<MODeviationCostQueryView>("33c8c344-3994-4f48-8b0b-42b994a04a97","","",false, this);
 
            InternalCode = RPSControlFactory.CreateRPSTextBox<MODeviationCostQueryView>("4825edf8-04c9-4456-86f4-d886a099adf5","","",false, this);
 
            DeviationPercent1 = RPSControlFactory.CreateRPSFormattedTextBox<MODeviationCostQueryView>("55b22baa-2b01-45f1-8b05-cd622846a294","","",false, this);
 
            ReportCommandButton = RPSControlFactory.CreateRPSButton<MODeviationCostQueryView>( "be7000a9-b1de-4124-a694-be8cc4642d91","","",this);
 

        }
        public IRPSComboBox<MODeviationCostQueryView> Site { get; set; } 
        public IRPSCollectionComboBox<MODeviationCostQueryView> ManufacturingOrder { get; set; } 
        public IRPSCollectionComboBox<MODeviationCostQueryView> ManufacturingOrderSituation { get; set; } 
        public IRPSCheckbox<MODeviationCostQueryView> Historic { get; set; } 
        public IRPSCollectionComboBox<MODeviationCostQueryView> Project { get; set; } 
        public IRPSCheckbox<MODeviationCostQueryView> TaskNotStarted { get; set; } 
        public IRPSCheckbox<MODeviationCostQueryView> TaskInProgress { get; set; } 
        public IRPSCheckbox<MODeviationCostQueryView> TaskFinished { get; set; } 
        public IRPSTextBox<MODeviationCostQueryView> DeviationPercent { get; set; } 
        public IRPSCheckbox<MODeviationCostQueryView> Canceled { get; set; } 
        public IRPSTextBox<MODeviationCostQueryView> Group { get; set; } 
        public IRPSTextBox<MODeviationCostQueryView> InternalCode { get; set; } 
        public IRPSTextBox<MODeviationCostQueryView> DeviationPercent1 { get; set; } 
        public IRPSButton<MODeviationCostQueryView> ReportCommandButton { get; set; } 
        public MODeviationCost Screen { get; set; }
        public MODeviationCostQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}