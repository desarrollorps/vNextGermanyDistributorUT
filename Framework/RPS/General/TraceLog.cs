    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.TraceLog
{
    //RPS VERSION 1.0.0.0
    public partial class TraceLog:Screen
    {
        public TraceLog():base()
        {
            this.URL = "general.tracelog";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            TraceLogView  = new TraceLogView(this); 
            TraceLogView.InitializeControls(); 
           
        }
      
            public TraceLogView TraceLogView {get; set; } 
    }
            
    public partial class TraceLogView : View
    {
        public TraceLogView(TraceLog screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public TraceLog Screen { get; set; }
        public TraceLogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}