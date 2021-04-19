    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.MainFinalSheet
{
    //RPS VERSION 1.0.0.0
    public partial class MainFinalSheet:Screen
    {
        public MainFinalSheet():base()
        {
            this.URL = "quality.mainfinalsheet";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MainFinalSheetView  = new MainFinalSheetView(this); 
            MainFinalSheetView.InitializeControls(); 
           
        }
      
            public MainFinalSheetView MainFinalSheetView {get; set; } 
    }
            
    public partial class MainFinalSheetView : View
    {
        public MainFinalSheetView(MainFinalSheet screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public MainFinalSheet Screen { get; set; }
        public MainFinalSheetView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}