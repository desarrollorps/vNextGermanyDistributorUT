    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.UndoAnnualClosingAssistan
{
    //RPS VERSION 1.0.0.0
    public partial class UndoAnnualClosingAssistan:Screen
    {
        public UndoAnnualClosingAssistan():base()
        {
            this.URL = "generalledger.undoannualclosingassistan";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            UndoAnnualClosingAssistanView  = new UndoAnnualClosingAssistanView(this); 
            UndoAnnualClosingAssistanView.InitializeControls(); 
           
        }
      
            public UndoAnnualClosingAssistanView UndoAnnualClosingAssistanView {get; set; } 
    }
            
    public partial class UndoAnnualClosingAssistanView : View
    {
        public UndoAnnualClosingAssistanView(UndoAnnualClosingAssistan screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Year = RPSControlFactory.CreateRPSTextBox<UndoAnnualClosingAssistanView>("92921671-201c-47fc-bcc5-aa669334b8cd","","",false, this);
 
            StepName = RPSControlFactory.CreateRPSTextBox<UndoAnnualClosingAssistanView>("47ebac2e-6e74-4f95-9e17-40d2680ebdc2","","",false, this);
 
            JournalNumber = RPSControlFactory.CreateRPSFormattedTextBox<UndoAnnualClosingAssistanView>("7e205d09-e00b-47d9-8270-ddafb403e559","","",false, this);
 
            AcceptCommandButton = RPSControlFactory.CreateRPSButton<UndoAnnualClosingAssistanView>( "e08ebb23-bb51-4aa2-97fb-dd4f8fd1a2e7","","",this);
 

        }
        public IRPSTextBox<UndoAnnualClosingAssistanView> Year { get; set; } 
        public IRPSTextBox<UndoAnnualClosingAssistanView> StepName { get; set; } 
        public IRPSTextBox<UndoAnnualClosingAssistanView> JournalNumber { get; set; } 
        public IRPSButton<UndoAnnualClosingAssistanView> AcceptCommandButton { get; set; } 
        public UndoAnnualClosingAssistan Screen { get; set; }
        public UndoAnnualClosingAssistanView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}