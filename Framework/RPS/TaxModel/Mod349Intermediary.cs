    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.TaxModel.Mod349Intermediary
{
    //RPS VERSION 1.0.0.0
    public partial class Mod349Intermediary:Screen
    {
        public Mod349Intermediary():base()
        {
            this.URL = "taxmodel.mod349intermediary";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            Mod349IntermediaryView  = new Mod349IntermediaryView(this); 
            Mod349IntermediaryView.InitializeControls(); 
           
        }
      
            public Mod349IntermediaryView Mod349IntermediaryView {get; set; } 
    }
            
    public partial class Mod349IntermediaryView : View
    {
        public Mod349IntermediaryView(Mod349Intermediary screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public Mod349Intermediary Screen { get; set; }
        public Mod349IntermediaryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}