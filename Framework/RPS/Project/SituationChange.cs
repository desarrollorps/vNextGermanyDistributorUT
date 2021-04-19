    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.SituationChange
{
    //RPS VERSION 1.0.0.0
    public partial class SituationChange:Screen
    {
        public SituationChange():base()
        {
            this.URL = "project.situationchange";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SituationChangeView  = new SituationChangeView(this); 
            SituationChangeView.InitializeControls(); 
           
        }
      
            public SituationChangeView SituationChangeView {get; set; } 
    }
            
    public partial class SituationChangeView : View
    {
        public SituationChangeView(SituationChange screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Project = RPSControlFactory.CreateRPSComboBox<SituationChangeView>("5ff9de1b-1825-4534-9054-c101d5fdaa63","","",false, this);
 
            Site = RPSControlFactory.CreateRPSTextBox<SituationChangeView>("aa253e63-873e-496a-bc80-50a82d2e4eac","","",false, this);
 
            Version = RPSControlFactory.CreateRPSTextBox<SituationChangeView>("76261e22-1efa-47bc-932c-a3421f087628","","",false, this);
 
            OldSituation = RPSControlFactory.CreateRPSTextBox<SituationChangeView>("16e21b90-cfa4-4997-a3ff-46e02079b10d","","",false, this);
 
            NewSituation = RPSControlFactory.CreateRPSComboBox<SituationChangeView>("40f523bc-e183-4f49-8f7d-141d56e02a40","","",false, this);
 
            ChangeProjectLinked = RPSControlFactory.CreateRPSCheckBox<SituationChangeView>("6c215dd7-650f-480b-a54d-ec58cf9289bc","","",false, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<SituationChangeView>("477e275c-4e77-4f52-b1ce-d782e8925143","","",false, this);
 
            CloseOpenTasks = RPSControlFactory.CreateRPSCheckBox<SituationChangeView>("2b109170-7cdd-466e-b495-8519053e7015","","",false, this);
 
            Apply = RPSControlFactory.CreateRPSButton<SituationChangeView>( "935bcb2a-ba63-4418-8e0b-8c2bed63977b","","",this);
 

        }
        public IRPSComboBox<SituationChangeView> Project { get; set; } 
        public IRPSTextBox<SituationChangeView> Site { get; set; } 
        public IRPSTextBox<SituationChangeView> Version { get; set; } 
        public IRPSTextBox<SituationChangeView> OldSituation { get; set; } 
        public IRPSComboBox<SituationChangeView> NewSituation { get; set; } 
        public IRPSCheckbox<SituationChangeView> ChangeProjectLinked { get; set; } 
        public IRPSTextBox<SituationChangeView> Date { get; set; } 
        public IRPSCheckbox<SituationChangeView> CloseOpenTasks { get; set; } 
        public IRPSButton<SituationChangeView> Apply { get; set; } 
        public SituationChange Screen { get; set; }
        public SituationChangeView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}