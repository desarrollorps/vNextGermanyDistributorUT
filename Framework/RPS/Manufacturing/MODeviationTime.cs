    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.MODeviationTime
{
    //RPS VERSION 1.0.0.0
    public partial class MODeviationTime:Screen
    {
        public MODeviationTime():base()
        {
            this.URL = "manufacturing.modeviationtime";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MODeviationTimeQueryView  = new MODeviationTimeQueryView(this); 
            MODeviationTimeQueryView.InitializeControls(); 
           
        }
      
            public MODeviationTimeQueryView MODeviationTimeQueryView {get; set; } 
    }
            
    public partial class MODeviationTimeQueryView : View
    {
        public MODeviationTimeQueryView(MODeviationTime screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<MODeviationTimeQueryView>("fd95a843-681f-4384-acee-86c3d57ffe22","","",false, this);
 
            ManufacturingOrder = RPSControlFactory.CreateRPSCollectionComboBox<MODeviationTimeQueryView>("b9da43ac-0612-43e1-ab48-f62b6ec516ad","","",false, this);
 
            ManufacturingOrderSituation = RPSControlFactory.CreateRPSCollectionComboBox<MODeviationTimeQueryView>("08e4ca36-6451-4c01-bc6f-d61a1e2dc332","","",false, this);
 
            Historic = RPSControlFactory.CreateRPSCheckBox<MODeviationTimeQueryView>("e2114216-960c-4b42-82a5-5a1e0d87ca7f","","",false, this);
 
            Project = RPSControlFactory.CreateRPSCollectionComboBox<MODeviationTimeQueryView>("195499e3-ee15-4bfe-b8be-9b0c12750e6d","","",false, this);
 
            TaskNotStarted = RPSControlFactory.CreateRPSCheckBox<MODeviationTimeQueryView>("a0d3817b-6dc8-4222-8b36-33cc02df663e","","",false, this);
 
            TaskInProgress = RPSControlFactory.CreateRPSCheckBox<MODeviationTimeQueryView>("6bea3bf5-8c10-4daf-8108-b5bf225cd930","","",false, this);
 
            TaskFinished = RPSControlFactory.CreateRPSCheckBox<MODeviationTimeQueryView>("086e501f-d630-49eb-ae06-0ca7323c9697","","",false, this);
 
            Planify = RPSControlFactory.CreateRPSCheckBox<MODeviationTimeQueryView>("592d8a4d-3604-4b49-9090-d923c8b85a97","","",false, this);
 
            Canceled = RPSControlFactory.CreateRPSCheckBox<MODeviationTimeQueryView>("46c1e821-02ac-4812-80b2-8ba1d2913ce7","","",false, this);
 
            Planify1 = RPSControlFactory.CreateRPSCheckBox<MODeviationTimeQueryView>("102e21d6-79b7-40a5-92ce-7d4404f2c28a","","",false, this);
 

        }
        public IRPSComboBox<MODeviationTimeQueryView> Site { get; set; } 
        public IRPSCollectionComboBox<MODeviationTimeQueryView> ManufacturingOrder { get; set; } 
        public IRPSCollectionComboBox<MODeviationTimeQueryView> ManufacturingOrderSituation { get; set; } 
        public IRPSCheckbox<MODeviationTimeQueryView> Historic { get; set; } 
        public IRPSCollectionComboBox<MODeviationTimeQueryView> Project { get; set; } 
        public IRPSCheckbox<MODeviationTimeQueryView> TaskNotStarted { get; set; } 
        public IRPSCheckbox<MODeviationTimeQueryView> TaskInProgress { get; set; } 
        public IRPSCheckbox<MODeviationTimeQueryView> TaskFinished { get; set; } 
        public IRPSCheckbox<MODeviationTimeQueryView> Planify { get; set; } 
        public IRPSCheckbox<MODeviationTimeQueryView> Canceled { get; set; } 
        public IRPSCheckbox<MODeviationTimeQueryView> Planify1 { get; set; } 
        public MODeviationTime Screen { get; set; }
        public MODeviationTimeQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}