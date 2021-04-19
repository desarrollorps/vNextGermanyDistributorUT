    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.PassToHistoric
{
    //RPS VERSION 1.0.0.0
    public partial class PassToHistoric:Screen
    {
        public PassToHistoric():base()
        {
            this.URL = "general.passtohistoric";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            PassToHistoricView  = new PassToHistoricView(this); 
            PassToHistoricView.InitializeControls(); 
           
        }
      
            public PassToHistoricView PassToHistoricView {get; set; } 
    }
            
    public partial class PassToHistoricView : View
    {
        public PassToHistoricView(PassToHistoric screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Sales = RPSControlFactory.CreateRPSCheckBox<PassToHistoricView>("23fa760d-acf8-4d61-8c01-1d1f16ddd3a2","","",false, this);
 
            Purchase = RPSControlFactory.CreateRPSCheckBox<PassToHistoricView>("e729c621-ce58-47a1-af69-6a56e51f9189","","",false, this);
 
            ManufacturingOrder = RPSControlFactory.CreateRPSCheckBox<PassToHistoricView>("74f2c512-ea8a-4975-a0e3-71677eb7e5dc","","",false, this);
 
            Projects = RPSControlFactory.CreateRPSCheckBox<PassToHistoricView>("2ddef4d8-f659-4cee-97d6-39879ada810a","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<PassToHistoricView>("1ed2dc9b-519a-4510-9d01-4ea2e2ebd036","","",false, this);
 
            ExecutePassToHistoric = RPSControlFactory.CreateRPSButton<PassToHistoricView>( "6b14faa2-32c0-4ebf-b2d5-3f3be471e8de","","",this);
 

        }
        public IRPSCheckbox<PassToHistoricView> Sales { get; set; } 
        public IRPSCheckbox<PassToHistoricView> Purchase { get; set; } 
        public IRPSCheckbox<PassToHistoricView> ManufacturingOrder { get; set; } 
        public IRPSCheckbox<PassToHistoricView> Projects { get; set; } 
        public IRPSTextBox<PassToHistoricView> DateTo { get; set; } 
        public IRPSButton<PassToHistoricView> ExecutePassToHistoric { get; set; } 
        public PassToHistoric Screen { get; set; }
        public PassToHistoricView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}