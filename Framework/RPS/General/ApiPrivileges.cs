    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.ApiPrivileges
{
    //RPS VERSION 1.0.0.0
    public partial class ApiPrivileges:Screen
    {
        public ApiPrivileges():base()
        {
            this.URL = "general.apiprivileges";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ApiPrivilegesQueryView  = new ApiPrivilegesQueryView(this); 
            ApiPrivilegesQueryView.InitializeControls(); 
           
        }
      
            public ApiPrivilegesQueryView ApiPrivilegesQueryView {get; set; } 
    }
            
    public partial class ApiPrivilegesQueryView : View
    {
        public ApiPrivilegesQueryView(ApiPrivileges screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            RequiredPrivileges = RPSControlFactory.CreateRPSTextBox<ApiPrivilegesQueryView>("349a13df-c99d-4665-bea9-d2f403820849","","",false, this);
 
            ReadPrivileges = RPSControlFactory.CreateRPSTextBox<ApiPrivilegesQueryView>("f767a4d7-f690-44aa-8fe3-83fc139fee61","","",false, this);
 
            WritePrivileges = RPSControlFactory.CreateRPSTextBox<ApiPrivilegesQueryView>("40dbc5d3-250a-4428-960d-84e8ab80f6dd","","",false, this);
 
            DeletePrivileges = RPSControlFactory.CreateRPSTextBox<ApiPrivilegesQueryView>("a6529ee6-7a3e-4da7-abe4-aab0d881984c","","",false, this);
 

        }
        public IRPSTextBox<ApiPrivilegesQueryView> RequiredPrivileges { get; set; } 
        public IRPSTextBox<ApiPrivilegesQueryView> ReadPrivileges { get; set; } 
        public IRPSTextBox<ApiPrivilegesQueryView> WritePrivileges { get; set; } 
        public IRPSTextBox<ApiPrivilegesQueryView> DeletePrivileges { get; set; } 
        public ApiPrivileges Screen { get; set; }
        public ApiPrivilegesQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}