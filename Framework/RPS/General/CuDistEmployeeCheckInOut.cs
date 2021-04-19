    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.CuDistEmployeeCheckInOut
{
    //RPS VERSION 1.0.0.0
    public partial class CuDistEmployeeCheckInOut:Screen
    {
        public CuDistEmployeeCheckInOut():base()
        {
            this.URL = "general.cudistemployeecheckinout";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CuDistEmployeeCheckInOutView  = new CuDistEmployeeCheckInOutView(this); 
            CuDistEmployeeCheckInOutView.InitializeControls(); 
           
        }
      
            public CuDistEmployeeCheckInOutView CuDistEmployeeCheckInOutView {get; set; } 
    }
            
    public partial class CuDistEmployeeCheckInOutView : View
    {
        public CuDistEmployeeCheckInOutView(CuDistEmployeeCheckInOut screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SelectedCodEmployee = RPSControlFactory.CreateRPSEnumComboBox<CuDistEmployeeCheckInOutView>("a43fa67a-b44b-4ca3-8d39-0bfeebf6ea04","","",false, this);
 
            CheckInCommand = RPSControlFactory.CreateRPSButton<CuDistEmployeeCheckInOutView>( "416c7f20-526d-48a0-a84a-223b62fa05c4","","",this);
 
            CheckOutCommand = RPSControlFactory.CreateRPSButton<CuDistEmployeeCheckInOutView>( "d0892728-0ba4-4950-991b-bd6e2aa8451e","","",this);
 

        }
        public IRPSComboBox<CuDistEmployeeCheckInOutView> SelectedCodEmployee { get; set; } 
        public IRPSButton<CuDistEmployeeCheckInOutView> CheckInCommand { get; set; } 
        public IRPSButton<CuDistEmployeeCheckInOutView> CheckOutCommand { get; set; } 
        public CuDistEmployeeCheckInOut Screen { get; set; }
        public CuDistEmployeeCheckInOutView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}