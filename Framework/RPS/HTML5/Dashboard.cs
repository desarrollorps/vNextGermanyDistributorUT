    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.HTML5.Dashboard
{
    //RPS VERSION 1.0.0.0
    public partial class Dashboard:Screen
    {
        public Dashboard():base()
        {
            this.URL = "html5.dashboard";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DashboardView  = new DashboardView(this); 
            DashboardView.InitializeControls(); 
           
        }
      
            public DashboardView DashboardView {get; set; } 
    }
            
    public partial class DashboardView : View
    {
        public DashboardView(Dashboard screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public Dashboard Screen { get; set; }
        public DashboardView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}