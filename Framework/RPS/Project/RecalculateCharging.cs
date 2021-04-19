    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.RecalculateCharging
{
    //RPS VERSION 1.0.0.0
    public partial class RecalculateCharging:Screen
    {
        public RecalculateCharging():base()
        {
            this.URL = "project.recalculatecharging";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            RecalculateChargingView  = new RecalculateChargingView(this); 
            RecalculateChargingView.InitializeControls(); 
           
        }
      
            public RecalculateChargingView RecalculateChargingView {get; set; } 
    }
            
    public partial class RecalculateChargingView : View
    {
        public RecalculateChargingView(RecalculateCharging screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<RecalculateChargingView>("1699a6b7-7cff-4000-8bf0-ea6d79005976","","",false, this);
 
            Employees = RPSControlFactory.CreateRPSCheckBox<RecalculateChargingView>("3828cadc-ce13-47c2-bc47-4522bce52df9","","",false, this);
 
            Machines = RPSControlFactory.CreateRPSCheckBox<RecalculateChargingView>("13970524-b417-4d04-bc59-004be156e13d","","",false, this);
 
            Project = RPSControlFactory.CreateRPSCollectionComboBox<RecalculateChargingView>("c982eb04-8658-4726-b209-514ce5e88c59","","",false, this);
 
            Tools = RPSControlFactory.CreateRPSCheckBox<RecalculateChargingView>("a9df2a0c-4bc5-41ed-a682-4a9ad96c9a4e","","",false, this);
 
            CostComponents = RPSControlFactory.CreateRPSCheckBox<RecalculateChargingView>("50628508-eea9-4289-8263-fab730bfd862","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<RecalculateChargingView>("b8ebdca9-1248-443f-aee8-13525de57511","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<RecalculateChargingView>("4db190d1-a71b-4179-9606-eabb6039d229","","",false, this);
 
            Accept = RPSControlFactory.CreateRPSButton<RecalculateChargingView>( "bd6a4ca4-ddd0-455e-a77c-e02cc5cd6b91","","",this);
 

        }
        public IRPSComboBox<RecalculateChargingView> Site { get; set; } 
        public IRPSCheckbox<RecalculateChargingView> Employees { get; set; } 
        public IRPSCheckbox<RecalculateChargingView> Machines { get; set; } 
        public IRPSCollectionComboBox<RecalculateChargingView> Project { get; set; } 
        public IRPSCheckbox<RecalculateChargingView> Tools { get; set; } 
        public IRPSCheckbox<RecalculateChargingView> CostComponents { get; set; } 
        public IRPSTextBox<RecalculateChargingView> DateFrom { get; set; } 
        public IRPSTextBox<RecalculateChargingView> DateTo { get; set; } 
        public IRPSButton<RecalculateChargingView> Accept { get; set; } 
        public RecalculateCharging Screen { get; set; }
        public RecalculateChargingView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}