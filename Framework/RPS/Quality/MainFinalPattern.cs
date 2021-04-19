    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.MainFinalPattern
{
    //RPS VERSION 1.0.0.0
    public partial class MainFinalPattern:Screen
    {
        public MainFinalPattern():base()
        {
            this.URL = "quality.mainfinalpattern";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MainFinalPatternView  = new MainFinalPatternView(this); 
            MainFinalPatternView.InitializeControls(); 
           
        }
      
            public MainFinalPatternView MainFinalPatternView {get; set; } 
    }
            
    public partial class MainFinalPatternView : View
    {
        public MainFinalPatternView(MainFinalPattern screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public MainFinalPattern Screen { get; set; }
        public MainFinalPatternView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}