    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.SalesBreak
{
    //RPS VERSION 1.0.0.0
    public partial class SalesBreak:Screen
    {
        public SalesBreak():base()
        {
            this.URL = "generalledger.salesbreak";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SalesBreakView  = new SalesBreakView(this); 
            SalesBreakView.InitializeControls(); 
           
        }
      
            public SalesBreakView SalesBreakView {get; set; } 
    }
            
    public partial class SalesBreakView : View
    {
        public SalesBreakView(SalesBreak screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeliveryNoteDateTo = RPSControlFactory.CreateRPSTextBox<SalesBreakView>("20d1423c-b5d9-43ef-b5b0-4e9dfa91f85d","","",false, this);
 
            Account = RPSControlFactory.CreateRPSComboBox<SalesBreakView>("98e13542-47f2-4692-8419-fd58f50b818b","","",false, this);
 
            VoucherType = RPSControlFactory.CreateRPSComboBox<SalesBreakView>("76d13f91-4d1a-42f6-a7ae-b6cd33d85a18","","",false, this);
 
            VoucherSeriesBook = RPSControlFactory.CreateRPSComboBox<SalesBreakView>("9124a347-596c-4c5a-af0f-47de2ec6fe94","","",false, this);
 
            AccountingDateProvisional = RPSControlFactory.CreateRPSTextBox<SalesBreakView>("743c7081-968f-49bd-91a5-ed1363c7c3a9","","",false, this);
 
            AccountingDateReverse = RPSControlFactory.CreateRPSTextBox<SalesBreakView>("ceb2ea3c-8c62-44a0-8977-3a47e8272c72","","",false, this);
 
            ExecuteInsertFromBreakSalesButton = RPSControlFactory.CreateRPSButton<SalesBreakView>( "d12d9eec-42ab-4899-b111-118780a3cdc8","","",this);
 

        }
        public IRPSTextBox<SalesBreakView> DeliveryNoteDateTo { get; set; } 
        public IRPSComboBox<SalesBreakView> Account { get; set; } 
        public IRPSComboBox<SalesBreakView> VoucherType { get; set; } 
        public IRPSComboBox<SalesBreakView> VoucherSeriesBook { get; set; } 
        public IRPSTextBox<SalesBreakView> AccountingDateProvisional { get; set; } 
        public IRPSTextBox<SalesBreakView> AccountingDateReverse { get; set; } 
        public IRPSButton<SalesBreakView> ExecuteInsertFromBreakSalesButton { get; set; } 
        public SalesBreak Screen { get; set; }
        public SalesBreakView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}