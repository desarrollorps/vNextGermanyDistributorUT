    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.MainProductionSheet
{
    //RPS VERSION 1.0.0.0
    public partial class MainProductionSheet:Screen
    {
        public MainProductionSheet():base()
        {
            this.URL = "quality.mainproductionsheet";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MainProductionSheetView  = new MainProductionSheetView(this); 
            MainProductionSheetView.InitializeControls(); 
           
        }
      
            public MainProductionSheetView MainProductionSheetView {get; set; } 
    }
            
    public partial class MainProductionSheetView : View
    {
        public MainProductionSheetView(MainProductionSheet screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public MainProductionSheet Screen { get; set; }
        public MainProductionSheetView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}