    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Warehouse.PreliminaryMovement
{
    //RPS VERSION 1.0.0.0
    public partial class PreliminaryMovement:Screen
    {
        public PreliminaryMovement():base()
        {
            this.URL = "warehouse.preliminarymovement";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            PreliminaryMovementView  = new PreliminaryMovementView(this); 
            PreliminaryMovementView.InitializeControls(); 
           
        }
      
            public PreliminaryMovementView PreliminaryMovementView {get; set; } 
    }
            
    public partial class PreliminaryMovementView : View
    {
        public PreliminaryMovementView(PreliminaryMovement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ExecutePreliminaryMovementsRecord = RPSControlFactory.CreateRPSButton<PreliminaryMovementView>( "a0a8f124-6251-4852-9193-d5b7eddf2f07","","",this);
 

        }
        public IRPSButton<PreliminaryMovementView> ExecutePreliminaryMovementsRecord { get; set; } 
        public PreliminaryMovement Screen { get; set; }
        public PreliminaryMovementView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}