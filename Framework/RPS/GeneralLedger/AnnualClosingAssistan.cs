    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.AnnualClosingAssistan
{
    //RPS VERSION 1.0.0.0
    public partial class AnnualClosingAssistan:Screen
    {
        public AnnualClosingAssistan():base()
        {
            this.URL = "generalledger.annualclosingassistan";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            AnnualClosingAssistanView  = new AnnualClosingAssistanView(this); 
            AnnualClosingAssistanView.InitializeControls(); 
           
        }
      
            public AnnualClosingAssistanView AnnualClosingAssistanView {get; set; } 
    }
            
    public partial class AnnualClosingAssistanView : View
    {
        public AnnualClosingAssistanView(AnnualClosingAssistan screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Year = RPSControlFactory.CreateRPSFormattedTextBox<AnnualClosingAssistanView>("83ec49cd-331f-4a30-a9a3-f599666b9d0d","","",false, this);
 
            AccountingDate = RPSControlFactory.CreateRPSTextBox<AnnualClosingAssistanView>("26f0ca4b-7936-4eb9-befb-5ee5fd804a5f","","",true, this);
 
            IDVoucherType = RPSControlFactory.CreateRPSComboBox<AnnualClosingAssistanView>("5ff89ab5-82af-4c4c-bf3b-8f79dd47fad6","","",true, this);
 
            IDVoucherSeriesBook = RPSControlFactory.CreateRPSComboBox<AnnualClosingAssistanView>("cbf0c464-3bbe-4c4c-9674-a9bfb5fa7c2a","","",true, this);
 
            IDAccConcept = RPSControlFactory.CreateRPSComboBox<AnnualClosingAssistanView>("24ff8869-95c5-4d27-8dc2-2beef548e450","","",true, this);
 
            ByAccount = RPSControlFactory.CreateRPSOption<AnnualClosingAssistanView>( "cc0c9564-8b83-4a8b-8a65-092cfd5bbb87","","",this);
 
            ByTypeAndAccount = RPSControlFactory.CreateRPSOption<AnnualClosingAssistanView>( "32aa2c43-8754-40cd-a617-8be450b252a6","","",this);
 
            bDimension = RPSControlFactory.CreateRPSCheckBox<AnnualClosingAssistanView>("c50d49d8-38de-4c71-a40c-7a5e1e5d21c7","","",false, this);
 
            IDDimensionList = RPSControlFactory.CreateRPSCollectionComboBox<AnnualClosingAssistanView>("fc9e2fa0-1569-458b-9bdc-44c195049249","","",false, this);
 
            AcceptCommandButton = RPSControlFactory.CreateRPSButton<AnnualClosingAssistanView>( "fb30dc0a-b280-4d2a-8c12-7dc24951b30c","","",this);
 

        }
        public IRPSTextBox<AnnualClosingAssistanView> Year { get; set; } 
        public IRPSTextBox<AnnualClosingAssistanView> AccountingDate { get; set; } 
        public IRPSComboBox<AnnualClosingAssistanView> IDVoucherType { get; set; } 
        public IRPSComboBox<AnnualClosingAssistanView> IDVoucherSeriesBook { get; set; } 
        public IRPSComboBox<AnnualClosingAssistanView> IDAccConcept { get; set; } 
        public IRPSOption<AnnualClosingAssistanView> ByAccount { get; set; } 
        public IRPSOption<AnnualClosingAssistanView> ByTypeAndAccount { get; set; } 
        public IRPSCheckbox<AnnualClosingAssistanView> bDimension { get; set; } 
        public IRPSCollectionComboBox<AnnualClosingAssistanView> IDDimensionList { get; set; } 
        public IRPSButton<AnnualClosingAssistanView> AcceptCommandButton { get; set; } 
        public AnnualClosingAssistan Screen { get; set; }
        public AnnualClosingAssistanView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}