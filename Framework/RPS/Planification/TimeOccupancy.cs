    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Planification.TimeOccupancy
{
    //RPS VERSION 1.0.0.0
    public partial class TimeOccupancy:Screen
    {
        public TimeOccupancy():base()
        {
            this.URL = "planification.timeoccupancy";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            TimeOccupancyQueryView  = new TimeOccupancyQueryView(this); 
            TimeOccupancyQueryView.InitializeControls(); 
           
        }
      
            public TimeOccupancyQueryView TimeOccupancyQueryView {get; set; } 
    }
            
    public partial class TimeOccupancyQueryView : View
    {
        public TimeOccupancyQueryView(TimeOccupancy screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<TimeOccupancyQueryView>("6978d801-e826-47a9-a161-ade17a67b8de","","",false, this);
 
            Scene = RPSControlFactory.CreateRPSComboBox<TimeOccupancyQueryView>("7ab8598d-ef51-4e7c-863f-a84992246774","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<TimeOccupancyQueryView>("4c83a0df-470b-4d23-a597-cd9230649cf9","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<TimeOccupancyQueryView>("ad31bfd1-d9ca-4fdc-aa53-e9cbc92eda8a","","",false, this);
 
            CheckEmployees = RPSControlFactory.CreateRPSCheckBox<TimeOccupancyQueryView>("9384e398-d8ba-4af8-8743-9c75bc9d33bf","","",false, this);
 
            Employee = RPSControlFactory.CreateRPSCollectionComboBox<TimeOccupancyQueryView>("62e07961-3924-483a-9320-08d58f900724","","",false, this);
 
            CheckProjects = RPSControlFactory.CreateRPSCheckBox<TimeOccupancyQueryView>("abc41af2-029f-427c-aacb-d4a122910e2b","","",false, this);
 
            Project = RPSControlFactory.CreateRPSCollectionComboBox<TimeOccupancyQueryView>("66655d5c-0582-4db1-8dba-17be123575de","","",false, this);
 
            CheckMachines = RPSControlFactory.CreateRPSCheckBox<TimeOccupancyQueryView>("2a325ee7-5033-481b-9f0a-ce7a3dd89b5e","","",false, this);
 
            Machine = RPSControlFactory.CreateRPSCollectionComboBox<TimeOccupancyQueryView>("ae685a1d-9c89-40b0-8b20-819060f7a006","","",false, this);
 
            CheckManufacturingOrder = RPSControlFactory.CreateRPSCheckBox<TimeOccupancyQueryView>("27cdc52e-65b0-4c7b-94a4-fb903ada6cc1","","",false, this);
 
            ManufacturingOrder = RPSControlFactory.CreateRPSCollectionComboBox<TimeOccupancyQueryView>("aca847eb-77f6-4487-a7df-0d3a2e888546","","",false, this);
 
            CheckTools = RPSControlFactory.CreateRPSCheckBox<TimeOccupancyQueryView>("b4eafc76-b2b1-42e3-a0d3-d0cc924d1f66","","",false, this);
 
            Tool = RPSControlFactory.CreateRPSCollectionComboBox<TimeOccupancyQueryView>("5e39b580-f565-4ada-b23a-c2d1ae50f44b","","",false, this);
 
            CheckMaintenanceOrder = RPSControlFactory.CreateRPSCheckBox<TimeOccupancyQueryView>("b7100c05-6cef-4623-8fb0-5aa7f08fc915","","",false, this);
 
            MaintenanceOrder = RPSControlFactory.CreateRPSCollectionComboBox<TimeOccupancyQueryView>("eb8277b0-3d1f-48d4-a2f3-94543f05a9bf","","",false, this);
 

        }
        public IRPSComboBox<TimeOccupancyQueryView> Site { get; set; } 
        public IRPSComboBox<TimeOccupancyQueryView> Scene { get; set; } 
        public IRPSTextBox<TimeOccupancyQueryView> DateFrom { get; set; } 
        public IRPSTextBox<TimeOccupancyQueryView> DateTo { get; set; } 
        public IRPSCheckbox<TimeOccupancyQueryView> CheckEmployees { get; set; } 
        public IRPSCollectionComboBox<TimeOccupancyQueryView> Employee { get; set; } 
        public IRPSCheckbox<TimeOccupancyQueryView> CheckProjects { get; set; } 
        public IRPSCollectionComboBox<TimeOccupancyQueryView> Project { get; set; } 
        public IRPSCheckbox<TimeOccupancyQueryView> CheckMachines { get; set; } 
        public IRPSCollectionComboBox<TimeOccupancyQueryView> Machine { get; set; } 
        public IRPSCheckbox<TimeOccupancyQueryView> CheckManufacturingOrder { get; set; } 
        public IRPSCollectionComboBox<TimeOccupancyQueryView> ManufacturingOrder { get; set; } 
        public IRPSCheckbox<TimeOccupancyQueryView> CheckTools { get; set; } 
        public IRPSCollectionComboBox<TimeOccupancyQueryView> Tool { get; set; } 
        public IRPSCheckbox<TimeOccupancyQueryView> CheckMaintenanceOrder { get; set; } 
        public IRPSCollectionComboBox<TimeOccupancyQueryView> MaintenanceOrder { get; set; } 
        public TimeOccupancy Screen { get; set; }
        public TimeOccupancyQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}