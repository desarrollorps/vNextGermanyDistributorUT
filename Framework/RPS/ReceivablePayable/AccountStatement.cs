    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.ReceivablePayable.AccountStatement
{
    //RPS VERSION 1.0.0.0
    public partial class AccountStatement:Screen
    {
        public AccountStatement():base()
        {
            this.URL = "receivablepayable.accountstatement";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            AccountStatementView  = new AccountStatementView(this); 
            AccountStatementView.InitializeControls(); 
           
        }
      
            public AccountStatementView AccountStatementView {get; set; } 
    }
            
    public partial class AccountStatementView : View
    {
        public AccountStatementView(AccountStatement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CheckSales = RPSControlFactory.CreateRPSCheckBox<AccountStatementView>("5a3e7c92-7aae-487f-a8dc-857991eb8e94","","",false, this);
 
            CheckPurchase = RPSControlFactory.CreateRPSCheckBox<AccountStatementView>("873cd214-d48f-4cae-866f-4a0dc4e9c043","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<AccountStatementView>("89ba6235-e77b-4501-86ac-339a3df6fcd2","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<AccountStatementView>("bd6a455b-497d-468f-a0a4-0539962f0636","","",false, this);
 
            OnlyPendingInvoices = RPSControlFactory.CreateRPSCheckBox<AccountStatementView>("eb8d308a-10fb-4209-b23a-983e278d0cc3","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSCollectionComboBox<AccountStatementView>("edbeb9c2-c929-4aae-b0ec-5a851879723f","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSCollectionComboBox<AccountStatementView>("d8695d24-7cf7-4f4b-adc4-e2ade3e2a83d","","",false, this);
 
            PrintCommand = RPSControlFactory.CreateRPSButton<AccountStatementView>( "be5399fe-3db4-4307-abf1-6bd930d6948a","","",this);
 

        }
        public IRPSCheckbox<AccountStatementView> CheckSales { get; set; } 
        public IRPSCheckbox<AccountStatementView> CheckPurchase { get; set; } 
        public IRPSTextBox<AccountStatementView> DateFrom { get; set; } 
        public IRPSTextBox<AccountStatementView> DateTo { get; set; } 
        public IRPSCheckbox<AccountStatementView> OnlyPendingInvoices { get; set; } 
        public IRPSCollectionComboBox<AccountStatementView> IDCustomer { get; set; } 
        public IRPSCollectionComboBox<AccountStatementView> IDSupplier { get; set; } 
        public IRPSButton<AccountStatementView> PrintCommand { get; set; } 
        public AccountStatement Screen { get; set; }
        public AccountStatementView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}