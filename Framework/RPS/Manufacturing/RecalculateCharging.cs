    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.RecalculateCharging
{
    //RPS VERSION 1.0.0.0
    public partial class RecalculateCharging:Screen
    {
        public RecalculateCharging():base()
        {
            this.URL = "manufacturing.recalculatecharging";
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
            Site = RPSControlFactory.CreateRPSComboBox<RecalculateChargingView>("cd809fd7-3eec-4917-80ed-ba9256cdbc42","","",false, this);
 
            CheckEmployee = RPSControlFactory.CreateRPSCheckBox<RecalculateChargingView>("e1644334-b53f-41a6-bf40-5c0a23cecb4d","","",false, this);
 
            CheckMachine = RPSControlFactory.CreateRPSCheckBox<RecalculateChargingView>("2f94af96-e7fa-46c9-92f8-c40334a0f8ae","","",false, this);
 
            ManufacturingOrder = RPSControlFactory.CreateRPSCollectionComboBox<RecalculateChargingView>("b057d159-fc2a-4114-82b4-1fa833b0f792","","",false, this);
 
            CheckTool = RPSControlFactory.CreateRPSCheckBox<RecalculateChargingView>("29089c99-df40-4d20-8722-b0d79f51407f","","",false, this);
 
            CheckCostComponent = RPSControlFactory.CreateRPSCheckBox<RecalculateChargingView>("f66ec80c-394c-4608-a7b2-10f8a56c844f","","",false, this);
 
            Project = RPSControlFactory.CreateRPSCollectionComboBox<RecalculateChargingView>("4a1cf99f-afca-436e-a6c2-45b09b5e0d2b","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<RecalculateChargingView>("b0079ed1-1a23-4977-b164-3f4562a5c1ce","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<RecalculateChargingView>("eba15222-42f1-4c70-83d1-c34e68336a85","","",false, this);
 
            ExecuteRecalculateCharging = RPSControlFactory.CreateRPSButton<RecalculateChargingView>( "4b99e23e-8959-428e-8f34-d143c0654100","","",this);
 

        }
        public IRPSComboBox<RecalculateChargingView> Site { get; set; } 
        public IRPSCheckbox<RecalculateChargingView> CheckEmployee { get; set; } 
        public IRPSCheckbox<RecalculateChargingView> CheckMachine { get; set; } 
        public IRPSCollectionComboBox<RecalculateChargingView> ManufacturingOrder { get; set; } 
        public IRPSCheckbox<RecalculateChargingView> CheckTool { get; set; } 
        public IRPSCheckbox<RecalculateChargingView> CheckCostComponent { get; set; } 
        public IRPSCollectionComboBox<RecalculateChargingView> Project { get; set; } 
        public IRPSTextBox<RecalculateChargingView> DateFrom { get; set; } 
        public IRPSTextBox<RecalculateChargingView> DateTo { get; set; } 
        public IRPSButton<RecalculateChargingView> ExecuteRecalculateCharging { get; set; } 
        public RecalculateCharging Screen { get; set; }
        public RecalculateChargingView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}