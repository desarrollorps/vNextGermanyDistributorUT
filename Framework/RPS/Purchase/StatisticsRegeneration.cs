    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.StatisticsRegeneration
{
    //RPS VERSION 1.0.0.0
    public partial class StatisticsRegeneration:Screen
    {
        public StatisticsRegeneration():base()
        {
            this.URL = "purchase.statisticsregeneration";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            StatisticsRegenerationView  = new StatisticsRegenerationView(this); 
            StatisticsRegenerationView.InitializeControls(); 
           
        }
      
            public StatisticsRegenerationView StatisticsRegenerationView {get; set; } 
    }
            
    public partial class StatisticsRegenerationView : View
    {
        public StatisticsRegenerationView(StatisticsRegeneration screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeliveryNote = RPSControlFactory.CreateRPSCollectionComboBox<StatisticsRegenerationView>("1baed518-87b8-4b2b-a13c-04ea383de608","","",false, this);
 
            Invoice = RPSControlFactory.CreateRPSCollectionComboBox<StatisticsRegenerationView>("4e1bcc82-f966-4e1d-afcb-7669140e0a68","","",false, this);
 
            DateStart = RPSControlFactory.CreateRPSTextBox<StatisticsRegenerationView>("bfe5cca9-be7e-4f01-b5ab-7cc97c1c1c97","","",false, this);
 
            DateEnd = RPSControlFactory.CreateRPSTextBox<StatisticsRegenerationView>("7c1056c2-277d-4f07-8df6-e5497d691d3b","","",false, this);
 
            DeliveryNotesCheck = RPSControlFactory.CreateRPSCheckBox<StatisticsRegenerationView>("b37cc85d-c033-48f9-90c5-f7f05e40e58d","","",false, this);
 
            InvoicesCheck = RPSControlFactory.CreateRPSCheckBox<StatisticsRegenerationView>("85299b73-2601-47b7-a03c-16a37b294fde","","",false, this);
 
            AceptarCommand = RPSControlFactory.CreateRPSButton<StatisticsRegenerationView>( "827f81a9-1ad3-4402-972f-971764b75fa6","","",this);
 

        }
        public IRPSCollectionComboBox<StatisticsRegenerationView> DeliveryNote { get; set; } 
        public IRPSCollectionComboBox<StatisticsRegenerationView> Invoice { get; set; } 
        public IRPSTextBox<StatisticsRegenerationView> DateStart { get; set; } 
        public IRPSTextBox<StatisticsRegenerationView> DateEnd { get; set; } 
        public IRPSCheckbox<StatisticsRegenerationView> DeliveryNotesCheck { get; set; } 
        public IRPSCheckbox<StatisticsRegenerationView> InvoicesCheck { get; set; } 
        public IRPSButton<StatisticsRegenerationView> AceptarCommand { get; set; } 
        public StatisticsRegeneration Screen { get; set; }
        public StatisticsRegenerationView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}