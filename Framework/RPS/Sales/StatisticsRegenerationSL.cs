    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.StatisticsRegenerationSL
{
    //RPS VERSION 1.0.0.0
    public partial class StatisticsRegenerationSL:Screen
    {
        public StatisticsRegenerationSL():base()
        {
            this.URL = "sales.statisticsregenerationsl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            StatisticsRegenerationSLView  = new StatisticsRegenerationSLView(this); 
            StatisticsRegenerationSLView.InitializeControls(); 
           
        }
      
            public StatisticsRegenerationSLView StatisticsRegenerationSLView {get; set; } 
    }
            
    public partial class StatisticsRegenerationSLView : View
    {
        public StatisticsRegenerationSLView(StatisticsRegenerationSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeliveryNoteSL1 = RPSControlFactory.CreateRPSCollectionComboBox<StatisticsRegenerationSLView>("5dc1e8da-c052-4dac-b592-0fa1902e495e","","",false, this);
 
            InvoiceSL1 = RPSControlFactory.CreateRPSCollectionComboBox<StatisticsRegenerationSLView>("06eb4f43-49ff-47d2-8e76-8d769d6a8dab","","",false, this);
 
            DateFromSL = RPSControlFactory.CreateRPSTextBox<StatisticsRegenerationSLView>("19fc4591-6f6a-49e8-9e35-8220e92354b6","","",false, this);
 
            DateToSL = RPSControlFactory.CreateRPSTextBox<StatisticsRegenerationSLView>("99f75ff8-2085-4bf8-a756-96140c0b7513","","",false, this);
 
            DeliveryNotesSLCheck = RPSControlFactory.CreateRPSCheckBox<StatisticsRegenerationSLView>("de30e26e-4be9-4080-811d-73023ef79d23","","",false, this);
 
            InvoicesSLCheck = RPSControlFactory.CreateRPSCheckBox<StatisticsRegenerationSLView>("8ba2a8ad-bdcc-47e5-83a8-8f2143d15363","","",false, this);
 
            AceptarCommand = RPSControlFactory.CreateRPSButton<StatisticsRegenerationSLView>( "66401bae-2e9a-42f1-a388-e26965de9f7e","","",this);
 

        }
        public IRPSCollectionComboBox<StatisticsRegenerationSLView> DeliveryNoteSL1 { get; set; } 
        public IRPSCollectionComboBox<StatisticsRegenerationSLView> InvoiceSL1 { get; set; } 
        public IRPSTextBox<StatisticsRegenerationSLView> DateFromSL { get; set; } 
        public IRPSTextBox<StatisticsRegenerationSLView> DateToSL { get; set; } 
        public IRPSCheckbox<StatisticsRegenerationSLView> DeliveryNotesSLCheck { get; set; } 
        public IRPSCheckbox<StatisticsRegenerationSLView> InvoicesSLCheck { get; set; } 
        public IRPSButton<StatisticsRegenerationSLView> AceptarCommand { get; set; } 
        public StatisticsRegenerationSL Screen { get; set; }
        public StatisticsRegenerationSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}