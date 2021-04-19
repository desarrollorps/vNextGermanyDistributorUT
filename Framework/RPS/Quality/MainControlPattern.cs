    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.MainControlPattern
{
    //RPS VERSION 1.0.0.0
    public partial class MainControlPattern:Screen
    {
        public MainControlPattern():base()
        {
            this.URL = "quality.maincontrolpattern";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MainControlPatternView  = new MainControlPatternView(this); 
            MainControlPatternView.InitializeControls(); 
           
        }
      
            public MainControlPatternView MainControlPatternView {get; set; } 
    }
            
    public partial class MainControlPatternView : View
    {
        public MainControlPatternView(MainControlPattern screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public MainControlPattern Screen { get; set; }
        public MainControlPatternView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}