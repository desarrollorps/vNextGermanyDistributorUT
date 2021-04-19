    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.HTML5.Desktop
{
    //RPS VERSION 1.0.0.0
    public partial class Desktop:Screen
    {
        public Desktop():base()
        {
            this.URL = "html5.desktop";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DesktopView  = new DesktopView(this); 
            DesktopView.InitializeControls(); 
           
        }
      
            public DesktopView DesktopView {get; set; } 
    }
            
    public partial class DesktopView : View
    {
        public DesktopView(Desktop screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public Desktop Screen { get; set; }
        public DesktopView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}