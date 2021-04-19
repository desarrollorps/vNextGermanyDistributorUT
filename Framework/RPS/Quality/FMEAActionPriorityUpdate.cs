    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.FMEAActionPriorityUpdate
{
    //RPS VERSION 1.0.0.0
    public partial class FMEAActionPriorityUpdate:Screen
    {
        public FMEAActionPriorityUpdate():base()
        {
            this.URL = "quality.fmeaactionpriorityupdate";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            FMEAActionPriorityUpdateView  = new FMEAActionPriorityUpdateView(this); 
            FMEAActionPriorityUpdateView.InitializeControls(); 
           
        }
      
            public FMEAActionPriorityUpdateView FMEAActionPriorityUpdateView {get; set; } 
    }
            
    public partial class FMEAActionPriorityUpdateView : View
    {
        public FMEAActionPriorityUpdateView(FMEAActionPriorityUpdate screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            OnlyNotApproved = RPSControlFactory.CreateRPSCheckBox<FMEAActionPriorityUpdateView>("fd9c2e48-6bcb-4b99-8f03-cd82fe26b315","","",false, this);
 
            Approved = RPSControlFactory.CreateRPSCheckBox<FMEAActionPriorityUpdateView>("99ef58dc-23b4-4fa8-a4d0-2476605b3334","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<FMEAActionPriorityUpdateView>("b2d32d41-fec5-4d09-94f6-8712e450e16d","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<FMEAActionPriorityUpdateView>("8afc8b5f-890c-48dc-aa5c-81c0fe3cb29a","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<FMEAActionPriorityUpdateView>("f3a56361-bba3-4a88-8b15-5ce39bd07713","","",false, this);
 
            eType = RPSControlFactory.CreateRPSEnumComboBox<FMEAActionPriorityUpdateView>("3fd30bf3-770e-4b88-8ac1-c6d8d7c87c94","","",true, this);
 
            IDFMEAVersion = RPSControlFactory.CreateRPSComboBox<FMEAActionPriorityUpdateView>("4855827c-ef75-4524-b913-216b8fe19e9f","","",false, this);
 
            ExecuteFMEAUpdateActionPriorityLevelsButton = RPSControlFactory.CreateRPSButton<FMEAActionPriorityUpdateView>( "05672994-f4f6-4764-9110-ca9d9c9e345d","","",this);
 
            CancelCommandButton = RPSControlFactory.CreateRPSButton<FMEAActionPriorityUpdateView>( "210c6266-858c-4386-b661-07016bb5402f","","",this);
 

        }
        public IRPSCheckbox<FMEAActionPriorityUpdateView> OnlyNotApproved { get; set; } 
        public IRPSCheckbox<FMEAActionPriorityUpdateView> Approved { get; set; } 
        public IRPSTextBox<FMEAActionPriorityUpdateView> DateFrom { get; set; } 
        public IRPSTextBox<FMEAActionPriorityUpdateView> DateTo { get; set; } 
        public IRPSComboBox<FMEAActionPriorityUpdateView> IDArticle { get; set; } 
        public IRPSComboBox<FMEAActionPriorityUpdateView> eType { get; set; } 
        public IRPSComboBox<FMEAActionPriorityUpdateView> IDFMEAVersion { get; set; } 
        public IRPSButton<FMEAActionPriorityUpdateView> ExecuteFMEAUpdateActionPriorityLevelsButton { get; set; } 
        public IRPSButton<FMEAActionPriorityUpdateView> CancelCommandButton { get; set; } 
        public FMEAActionPriorityUpdate Screen { get; set; }
        public FMEAActionPriorityUpdateView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}