    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.ConsolidationAggregation
{
    //RPS VERSION 1.0.0.0
    public partial class ConsolidationAggregation:Screen
    {
        public ConsolidationAggregation():base()
        {
            this.URL = "generalledger.consolidationaggregation";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ConsolidationAggregationView  = new ConsolidationAggregationView(this); 
            ConsolidationAggregationView.InitializeControls(); 
           
        }
      
            public ConsolidationAggregationView ConsolidationAggregationView {get; set; } 
    }
            
    public partial class ConsolidationAggregationView : View
    {
        public ConsolidationAggregationView(ConsolidationAggregation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            GeneralLedger = RPSControlFactory.CreateRPSOption<ConsolidationAggregationView>( "18686fc7-72c5-4175-ad2c-8608a11b1e92","","",this);
 
            budget = RPSControlFactory.CreateRPSOption<ConsolidationAggregationView>( "3a074ddb-f4ad-4a09-a2e0-691d93176370","","",this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<ConsolidationAggregationView>("be40dd50-fa2c-4ed2-8889-d23b843e3c1f","","",true, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<ConsolidationAggregationView>("3e070d02-5254-4b5e-8051-6b085660f1af","","",true, this);
 
            CompanyCONList = RPSControlFactory.CreateRPSCollectionComboBox<ConsolidationAggregationView>("e121629b-22a5-413b-8854-6e40c16be92f","","",false, this);
 
            Overwrite = RPSControlFactory.CreateRPSCheckBox<ConsolidationAggregationView>("97d3529a-cbfc-4a25-990f-2a1968b576dc","","",false, this);
 
            AcceptCommandButton = RPSControlFactory.CreateRPSButton<ConsolidationAggregationView>( "9557e764-a803-42c8-aba9-fec171298f1d","","",this);
 

        }
        public IRPSOption<ConsolidationAggregationView> GeneralLedger { get; set; } 
        public IRPSOption<ConsolidationAggregationView> budget { get; set; } 
        public IRPSTextBox<ConsolidationAggregationView> DateFrom { get; set; } 
        public IRPSTextBox<ConsolidationAggregationView> DateTo { get; set; } 
        public IRPSCollectionComboBox<ConsolidationAggregationView> CompanyCONList { get; set; } 
        public IRPSCheckbox<ConsolidationAggregationView> Overwrite { get; set; } 
        public IRPSButton<ConsolidationAggregationView> AcceptCommandButton { get; set; } 
        public ConsolidationAggregation Screen { get; set; }
        public ConsolidationAggregationView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}