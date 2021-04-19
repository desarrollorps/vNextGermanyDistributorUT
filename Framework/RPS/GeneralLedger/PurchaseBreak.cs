    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.PurchaseBreak
{
    //RPS VERSION 1.0.0.0
    public partial class PurchaseBreak:Screen
    {
        public PurchaseBreak():base()
        {
            this.URL = "generalledger.purchasebreak";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            PurchaseBreakView  = new PurchaseBreakView(this); 
            PurchaseBreakView.InitializeControls(); 
           
        }
      
            public PurchaseBreakView PurchaseBreakView {get; set; } 
    }
            
    public partial class PurchaseBreakView : View
    {
        public PurchaseBreakView(PurchaseBreak screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeliveryNoteDateTo = RPSControlFactory.CreateRPSTextBox<PurchaseBreakView>("20d1423c-b5d9-43ef-b5b0-4e9dfa91f85d","","",false, this);
 
            Account = RPSControlFactory.CreateRPSComboBox<PurchaseBreakView>("98e13542-47f2-4692-8419-fd58f50b818b","","",false, this);
 
            VoucherType = RPSControlFactory.CreateRPSComboBox<PurchaseBreakView>("76d13f91-4d1a-42f6-a7ae-b6cd33d85a18","","",false, this);
 
            VoucherSeriesBook = RPSControlFactory.CreateRPSComboBox<PurchaseBreakView>("9124a347-596c-4c5a-af0f-47de2ec6fe94","","",false, this);
 
            AccountingDateProvisional = RPSControlFactory.CreateRPSTextBox<PurchaseBreakView>("743c7081-968f-49bd-91a5-ed1363c7c3a9","","",false, this);
 
            AccountingDateReverse = RPSControlFactory.CreateRPSTextBox<PurchaseBreakView>("ceb2ea3c-8c62-44a0-8977-3a47e8272c72","","",false, this);
 
            ExecuteInsertFromBreakPurchaseButton = RPSControlFactory.CreateRPSButton<PurchaseBreakView>( "a67a581f-9ff9-4334-91de-2c6580e4e346","","",this);
 

        }
        public IRPSTextBox<PurchaseBreakView> DeliveryNoteDateTo { get; set; } 
        public IRPSComboBox<PurchaseBreakView> Account { get; set; } 
        public IRPSComboBox<PurchaseBreakView> VoucherType { get; set; } 
        public IRPSComboBox<PurchaseBreakView> VoucherSeriesBook { get; set; } 
        public IRPSTextBox<PurchaseBreakView> AccountingDateProvisional { get; set; } 
        public IRPSTextBox<PurchaseBreakView> AccountingDateReverse { get; set; } 
        public IRPSButton<PurchaseBreakView> ExecuteInsertFromBreakPurchaseButton { get; set; } 
        public PurchaseBreak Screen { get; set; }
        public PurchaseBreakView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}