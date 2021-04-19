    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.MaintenanceComponentHistory
{
    //RPS VERSION 1.0.0.0
    public partial class MaintenanceComponentHistory:Screen
    {
        public MaintenanceComponentHistory():base()
        {
            this.URL = "maintenance.maintenancecomponenthistory";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MaintenanceComponentHistoryView  = new MaintenanceComponentHistoryView(this); 
            MaintenanceComponentHistoryView.InitializeControls(); 
           
        }
      
            public MaintenanceComponentHistoryView MaintenanceComponentHistoryView {get; set; } 
    }
            
    public partial class MaintenanceComponentHistoryView : View
    {
        public MaintenanceComponentHistoryView(MaintenanceComponentHistory screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIMaintenanceComponent = RPSControlFactory.CreateRPSComboBox<MaintenanceComponentHistoryView>("1c268a57-c240-41da-92cd-d23347e8983e","","",false, this);
 
            UISerialNumber = RPSControlFactory.CreateRPSTextBox<MaintenanceComponentHistoryView>("fab35209-4a61-45f8-a1cf-4240b9ab67e4","","",false, this);
 
            ConsultCommand = RPSControlFactory.CreateRPSButton<MaintenanceComponentHistoryView>( "60d343bd-1cb3-4eae-abb2-4638ec47e719","","",this);
 

        }
        public IRPSComboBox<MaintenanceComponentHistoryView> UIMaintenanceComponent { get; set; } 
        public IRPSTextBox<MaintenanceComponentHistoryView> UISerialNumber { get; set; } 
        public IRPSButton<MaintenanceComponentHistoryView> ConsultCommand { get; set; } 
        public MaintenanceComponentHistory Screen { get; set; }
        public MaintenanceComponentHistoryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}