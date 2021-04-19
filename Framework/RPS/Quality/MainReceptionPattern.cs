    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.MainReceptionPattern
{
    //RPS VERSION 1.0.0.0
    public partial class MainReceptionPattern:Screen
    {
        public MainReceptionPattern():base()
        {
            this.URL = "quality.mainreceptionpattern";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MainReceptionPatternView  = new MainReceptionPatternView(this); 
            MainReceptionPatternView.InitializeControls(); 
           
        }
      
            public MainReceptionPatternView MainReceptionPatternView {get; set; } 
    }
            
    public partial class MainReceptionPatternView : View
    {
        public MainReceptionPatternView(MainReceptionPattern screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public MainReceptionPattern Screen { get; set; }
        public MainReceptionPatternView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}