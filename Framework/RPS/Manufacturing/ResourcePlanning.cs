    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.ResourcePlanning
{
    //RPS VERSION 1.0.0.0
    public partial class ResourcePlanning:Screen
    {
        public ResourcePlanning():base()
        {
            this.URL = "manufacturing.resourceplanning";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ResourcePlanningQueryView  = new ResourcePlanningQueryView(this); 
            ResourcePlanningQueryView.InitializeControls(); 
           
        }
      
            public ResourcePlanningQueryView ResourcePlanningQueryView {get; set; } 
    }
            
    public partial class ResourcePlanningQueryView : View
    {
        public ResourcePlanningQueryView(ResourcePlanning screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<ResourcePlanningQueryView>("0ba9cd4c-fde0-46ed-9ddc-7d18eb88cc40","","",false, this);
 
            ManufacturingOrder = RPSControlFactory.CreateRPSCollectionComboBox<ResourcePlanningQueryView>("2ced7a90-8d1a-4e31-995c-2303dada579a","","",false, this);
 
            ManufacturingOrderSituation = RPSControlFactory.CreateRPSCollectionComboBox<ResourcePlanningQueryView>("1c8b868a-490f-4ee2-81aa-096aec6bef27","","",false, this);
 
            StructureType = RPSControlFactory.CreateRPSCollectionComboBox<ResourcePlanningQueryView>("b7708fa5-e47c-47f4-9107-a969ddbde403","","",false, this);
 
            Project = RPSControlFactory.CreateRPSCollectionComboBox<ResourcePlanningQueryView>("fcdea767-21d5-448a-8c91-c23001bec16e","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<ResourcePlanningQueryView>("a2348309-60bb-43ec-aaf7-d381b73614eb","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<ResourcePlanningQueryView>("1d96c1a5-07d3-4f90-85b5-5392bf42b3ef","","",false, this);
 
            Employee = RPSControlFactory.CreateRPSCollectionComboBox<ResourcePlanningQueryView>("88c6ddb7-5be9-451b-8426-356bbe8c5a03","","",false, this);
 
            Qualify = RPSControlFactory.CreateRPSCollectionComboBox<ResourcePlanningQueryView>("5a5163a0-1b82-4e85-a0f8-205d1ec39469","","",false, this);
 
            Machine = RPSControlFactory.CreateRPSCollectionComboBox<ResourcePlanningQueryView>("a116e604-3c27-428b-9420-8858993ae637","","",false, this);
 
            MachineGroup = RPSControlFactory.CreateRPSCollectionComboBox<ResourcePlanningQueryView>("488f3541-9d18-4c09-aa21-cadaf328e976","","",false, this);
 
            Tool = RPSControlFactory.CreateRPSCollectionComboBox<ResourcePlanningQueryView>("48bc271f-ea8c-47c3-aacb-ac91af54d0aa","","",false, this);
 

        }
        public IRPSComboBox<ResourcePlanningQueryView> Site { get; set; } 
        public IRPSCollectionComboBox<ResourcePlanningQueryView> ManufacturingOrder { get; set; } 
        public IRPSCollectionComboBox<ResourcePlanningQueryView> ManufacturingOrderSituation { get; set; } 
        public IRPSCollectionComboBox<ResourcePlanningQueryView> StructureType { get; set; } 
        public IRPSCollectionComboBox<ResourcePlanningQueryView> Project { get; set; } 
        public IRPSTextBox<ResourcePlanningQueryView> DateFrom { get; set; } 
        public IRPSTextBox<ResourcePlanningQueryView> DateTo { get; set; } 
        public IRPSCollectionComboBox<ResourcePlanningQueryView> Employee { get; set; } 
        public IRPSCollectionComboBox<ResourcePlanningQueryView> Qualify { get; set; } 
        public IRPSCollectionComboBox<ResourcePlanningQueryView> Machine { get; set; } 
        public IRPSCollectionComboBox<ResourcePlanningQueryView> MachineGroup { get; set; } 
        public IRPSCollectionComboBox<ResourcePlanningQueryView> Tool { get; set; } 
        public ResourcePlanning Screen { get; set; }
        public ResourcePlanningQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}