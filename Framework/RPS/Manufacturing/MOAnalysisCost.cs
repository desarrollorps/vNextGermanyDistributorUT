    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.MOAnalysisCost
{
    //RPS VERSION 1.0.0.0
    public partial class MOAnalysisCost:Screen
    {
        public MOAnalysisCost():base()
        {
            this.URL = "manufacturing.moanalysiscost";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MOAnalysisCostQueryView  = new MOAnalysisCostQueryView(this); 
            MOAnalysisCostQueryView.InitializeControls(); 
           
        }
      
            public MOAnalysisCostQueryView MOAnalysisCostQueryView {get; set; } 
    }
            
    public partial class MOAnalysisCostQueryView : View
    {
        public MOAnalysisCostQueryView(MOAnalysisCost screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ManufacturingOrder = RPSControlFactory.CreateRPSComboBox<MOAnalysisCostQueryView>("3cabf88c-5403-4208-8b94-9a61f72be884","","",true, this);
 
            UnitarianCost = RPSControlFactory.CreateRPSCheckBox<MOAnalysisCostQueryView>("3b28a531-a4c5-4784-b9d5-d4c6f4738793","","",false, this);
 
            CodElement = RPSControlFactory.CreateRPSTextBox<MOAnalysisCostQueryView>("7b97f6dc-2511-47dc-a24a-8c818a56eba1","","",false, this);
 

        }
        public IRPSComboBox<MOAnalysisCostQueryView> ManufacturingOrder { get; set; } 
        public IRPSCheckbox<MOAnalysisCostQueryView> UnitarianCost { get; set; } 
        public IRPSTextBox<MOAnalysisCostQueryView> CodElement { get; set; } 
        public MOAnalysisCost Screen { get; set; }
        public MOAnalysisCostQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}