    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.MainReceptionSheet
{
    //RPS VERSION 1.0.0.0
    public partial class MainReceptionSheet:Screen
    {
        public MainReceptionSheet():base()
        {
            this.URL = "quality.mainreceptionsheet";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MainReceptionSheetView  = new MainReceptionSheetView(this); 
            MainReceptionSheetView.InitializeControls(); 
           
        }
      
            public MainReceptionSheetView MainReceptionSheetView {get; set; } 
    }
            
    public partial class MainReceptionSheetView : View
    {
        public MainReceptionSheetView(MainReceptionSheet screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public MainReceptionSheet Screen { get; set; }
        public MainReceptionSheetView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}