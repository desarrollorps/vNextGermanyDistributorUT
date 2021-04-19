    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.MainMachinePattern
{
    //RPS VERSION 1.0.0.0
    public partial class MainMachinePattern:Screen
    {
        public MainMachinePattern():base()
        {
            this.URL = "quality.mainmachinepattern";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MainMachinePatternView  = new MainMachinePatternView(this); 
            MainMachinePatternView.InitializeControls(); 
           
        }
      
            public MainMachinePatternView MainMachinePatternView {get; set; } 
    }
            
    public partial class MainMachinePatternView : View
    {
        public MainMachinePatternView(MainMachinePattern screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public MainMachinePattern Screen { get; set; }
        public MainMachinePatternView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}