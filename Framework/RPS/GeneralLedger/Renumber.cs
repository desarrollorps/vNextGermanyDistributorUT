    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.Renumber
{
    //RPS VERSION 1.0.0.0
    public partial class Renumber:Screen
    {
        public Renumber():base()
        {
            this.URL = "generalledger.renumber";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            RenumberView  = new RenumberView(this); 
            RenumberView.InitializeControls(); 
           
        }
      
            public RenumberView RenumberView {get; set; } 
    }
            
    public partial class RenumberView : View
    {
        public RenumberView(Renumber screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDACCYear = RPSControlFactory.CreateRPSComboBox<RenumberView>("1ad67628-a21f-4087-abb2-f3654ec2da4d","","",true, this);
 
            VoucherEntry = RPSControlFactory.CreateRPSCheckBox<RenumberView>("7d0483e5-b231-4ec4-8313-9a6c635d595a","","",false, this);
 
            VoucherEntryBook = RPSControlFactory.CreateRPSCheckBox<RenumberView>("484e8f55-a6ff-4d94-b2e4-27e499938710","","",false, this);
 
            VATPurchaseNumber = RPSControlFactory.CreateRPSCheckBox<RenumberView>("aa650d00-16c6-4d22-8190-81332aa066c2","","",false, this);
 
            VATSalesNumber = RPSControlFactory.CreateRPSCheckBox<RenumberView>("6868e597-bf4d-4a7c-bf26-17bd90219081","","",false, this);
 
            RenumberProcessCommandButton = RPSControlFactory.CreateRPSButton<RenumberView>( "d767cbfd-6005-4356-bd8a-1fcd45456df9","","",this);
 

        }
        public IRPSComboBox<RenumberView> IDACCYear { get; set; } 
        public IRPSCheckbox<RenumberView> VoucherEntry { get; set; } 
        public IRPSCheckbox<RenumberView> VoucherEntryBook { get; set; } 
        public IRPSCheckbox<RenumberView> VATPurchaseNumber { get; set; } 
        public IRPSCheckbox<RenumberView> VATSalesNumber { get; set; } 
        public IRPSButton<RenumberView> RenumberProcessCommandButton { get; set; } 
        public Renumber Screen { get; set; }
        public RenumberView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}