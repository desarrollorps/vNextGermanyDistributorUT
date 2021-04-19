    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.OccupancyConsult
{
    //RPS VERSION 1.0.0.0
    public partial class OccupancyConsult:Screen
    {
        public OccupancyConsult():base()
        {
            this.URL = "general.occupancyconsult";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            OccupancyConsultQueryView  = new OccupancyConsultQueryView(this); 
            OccupancyConsultQueryView.InitializeControls(); 
           
        }
      
            public OccupancyConsultQueryView OccupancyConsultQueryView {get; set; } 
    }
            
    public partial class OccupancyConsultQueryView : View
    {
        public OccupancyConsultQueryView(OccupancyConsult screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UI_Site = RPSControlFactory.CreateRPSComboBox<OccupancyConsultQueryView>("bfeb3be4-4933-47ab-a616-242be19fd1d7","","",false, this);
 
            UI_SelectProject = RPSControlFactory.CreateRPSCheckBox<OccupancyConsultQueryView>("c526b415-5409-411d-8447-85d4cdaf9e27","","",false, this);
 
            UI_SelectManufacturingOrder = RPSControlFactory.CreateRPSCheckBox<OccupancyConsultQueryView>("f0c9cdfc-9291-4205-9d52-83487b9d3717","","",false, this);
 
            UI_SelectMaintenanceOrder = RPSControlFactory.CreateRPSCheckBox<OccupancyConsultQueryView>("498a12e3-4089-4f4d-9196-5dcd5a794f37","","",false, this);
 
            UI_SelectEmployees = RPSControlFactory.CreateRPSCheckBox<OccupancyConsultQueryView>("84e49b11-6910-486f-b69d-fb38a3aa4949","","",false, this);
 
            UI_SelectMachines = RPSControlFactory.CreateRPSCheckBox<OccupancyConsultQueryView>("8a54ceb5-793d-42fd-be79-6a4881019440","","",false, this);
 
            UI_SelectTools = RPSControlFactory.CreateRPSCheckBox<OccupancyConsultQueryView>("ca6ee8ab-f357-40e6-9ada-fdb5e344c607","","",false, this);
 
            UI_Qualify = RPSControlFactory.CreateRPSCollectionComboBox<OccupancyConsultQueryView>("e124dc8a-57d9-4fd4-8dbd-f96775019b2b","","",false, this);
 
            UI_MachineGroup = RPSControlFactory.CreateRPSCollectionComboBox<OccupancyConsultQueryView>("8a1b0089-9815-4c74-8c14-c6e2a08c557a","","",false, this);
 
            UI_Department = RPSControlFactory.CreateRPSCollectionComboBox<OccupancyConsultQueryView>("a93c2fab-4008-45f1-923a-3e717568a46c","","",false, this);
 
            UI_OnlyResourcesSelected = RPSControlFactory.CreateRPSCheckBox<OccupancyConsultQueryView>("ca901df0-7a00-4cee-b52b-c6a3778fbbe4","","",false, this);
 
            UI_IncludeResourceNotPlanify = RPSControlFactory.CreateRPSCheckBox<OccupancyConsultQueryView>("d28a4a0c-4cee-43cc-be61-1fdaac923b76","","",false, this);
 
            StartDateForward = RPSControlFactory.CreateRPSOption<OccupancyConsultQueryView>( "af263325-92c2-482e-90ef-3502ba4f62ca","","",this);
 
            ProportionalBetweenDates = RPSControlFactory.CreateRPSOption<OccupancyConsultQueryView>( "d880e710-b24f-4a1c-837b-adef7262b29e","","",this);
 
            UI_StartDate = RPSControlFactory.CreateRPSTextBox<OccupancyConsultQueryView>("134c9d8c-f7e2-4137-90b0-a8dbc3544ffb","","",false, this);
 
            SectionActivities = RPSControlFactory.CreateRPSSection<OccupancyConsultQueryView>( "","ul li[rpsid='6d684ad8-46cf-4f5a-9ced-0944358a4df1']","",this);
 
            SectionCapabilities = RPSControlFactory.CreateRPSSection<OccupancyConsultQueryView>( "","ul li[rpsid='31c22b1d-9f59-45fb-bfcb-a12ed9c03501']","",this);
 
            SectionGraph = RPSControlFactory.CreateRPSSection<OccupancyConsultQueryView>( "","ul li[rpsid='f1eed061-f664-4d61-a2ee-63c81767ebe2']","",this);
 
            SectionSaturatedEmployees = RPSControlFactory.CreateRPSSection<OccupancyConsultQueryView>( "","ul li[rpsid='8e3b452f-d7cc-49aa-b3c5-0190ff16a2c0']","",this);
 

        }
        public IRPSComboBox<OccupancyConsultQueryView> UI_Site { get; set; } 
        public IRPSCheckbox<OccupancyConsultQueryView> UI_SelectProject { get; set; } 
        public IRPSCheckbox<OccupancyConsultQueryView> UI_SelectManufacturingOrder { get; set; } 
        public IRPSCheckbox<OccupancyConsultQueryView> UI_SelectMaintenanceOrder { get; set; } 
        public IRPSCheckbox<OccupancyConsultQueryView> UI_SelectEmployees { get; set; } 
        public IRPSCheckbox<OccupancyConsultQueryView> UI_SelectMachines { get; set; } 
        public IRPSCheckbox<OccupancyConsultQueryView> UI_SelectTools { get; set; } 
        public IRPSCollectionComboBox<OccupancyConsultQueryView> UI_Qualify { get; set; } 
        public IRPSCollectionComboBox<OccupancyConsultQueryView> UI_MachineGroup { get; set; } 
        public IRPSCollectionComboBox<OccupancyConsultQueryView> UI_Department { get; set; } 
        public IRPSCheckbox<OccupancyConsultQueryView> UI_OnlyResourcesSelected { get; set; } 
        public IRPSCheckbox<OccupancyConsultQueryView> UI_IncludeResourceNotPlanify { get; set; } 
        public IRPSOption<OccupancyConsultQueryView> StartDateForward { get; set; } 
        public IRPSOption<OccupancyConsultQueryView> ProportionalBetweenDates { get; set; } 
        public IRPSTextBox<OccupancyConsultQueryView> UI_StartDate { get; set; } 
        public IRPSSection<OccupancyConsultQueryView> SectionActivities { get; set; } 
        public IRPSSection<OccupancyConsultQueryView> SectionCapabilities { get; set; } 
        public IRPSSection<OccupancyConsultQueryView> SectionGraph { get; set; } 
        public IRPSSection<OccupancyConsultQueryView> SectionSaturatedEmployees { get; set; } 
        public OccupancyConsult Screen { get; set; }
        public OccupancyConsultQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}