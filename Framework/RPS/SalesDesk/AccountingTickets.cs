    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.SalesDesk.AccountingTickets
{
    //RPS VERSION 1.0.0.0
    public partial class AccountingTickets:Screen
    {
        public AccountingTickets():base()
        {
            this.URL = "salesdesk.accountingtickets";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            AccountingTicketsQueryView  = new AccountingTicketsQueryView(this); 
            PercentAllocationChildDialogView  = new PercentAllocationChildDialogView(this); 
            AccountingDateChildDialogView  = new AccountingDateChildDialogView(this); 
            AccountingTicketsQueryView.InitializeControls(); 
            PercentAllocationChildDialogView.InitializeControls(); 
            AccountingDateChildDialogView.InitializeControls(); 
           
        }
      
            public AccountingTicketsQueryView AccountingTicketsQueryView {get; set; } 
            public PercentAllocationChildDialogView PercentAllocationChildDialogView {get; set; } 
            public AccountingDateChildDialogView AccountingDateChildDialogView {get; set; } 
    }
            
    public partial class AccountingTicketsQueryView : View
    {
        public AccountingTicketsQueryView(AccountingTickets screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DateFrom = RPSControlFactory.CreateRPSTextBox<AccountingTicketsQueryView>("33d9ace7-b0c5-46db-9a6e-2e3a978ca6ed","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<AccountingTicketsQueryView>("171fd2fe-8a72-426c-94ee-04ce3ab6ced5","","",false, this);
 
            AccountingDateChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<AccountingTicketsQueryView,AccountingDateChildDialogView>("968ce6ce-04b2-4c84-a4ca-9aa7639e93ac","","", this,Screen.AccountingDateChildDialogView);
 
            PercentAllocationChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<AccountingTicketsQueryView,PercentAllocationChildDialogView>("7659c8fd-a694-44ea-8bcf-32032efdcaf7","","", this,Screen.PercentAllocationChildDialogView);
 
            CollectionInit params_AccountingTicketsConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="aff6c816-26d1-4f28-8643-5779a22af343",CSSSelectorGrid="",XPathGrid=""};
            AccountingTicketsConsult = RPSControlFactory.RPSCreateCollectionWithGrid<AccountingTicketsConsultCollectionEditor<AccountingTicketsQueryView,PercentAllocationChildDialogView>,AccountingTicketsQueryView,PercentAllocationChildDialogView>( params_AccountingTicketsConsult,this,Screen.PercentAllocationChildDialogView);
 

        }
        public IRPSTextBox<AccountingTicketsQueryView> DateFrom { get; set; } 
        public IRPSTextBox<AccountingTicketsQueryView> DateTo { get; set; } 
        public IRPSButton<AccountingTicketsQueryView,AccountingDateChildDialogView> AccountingDateChildNavigationCommandButton { get; set; } 
        public IRPSButton<AccountingTicketsQueryView,PercentAllocationChildDialogView> PercentAllocationChildNavigationCommandButton { get; set; } 
        public AccountingTicketsConsultCollectionEditor<AccountingTicketsQueryView,PercentAllocationChildDialogView> AccountingTicketsConsult { get; set; } 
        public AccountingTickets Screen { get; set; }
        public AccountingTicketsQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class AccountingTicketsConsultCollectionEditor<AccountingTicketsQueryView,PercentAllocationChildDialogView>:RPSCollectionEditor<AccountingTicketsQueryView,PercentAllocationChildDialogView> where AccountingTicketsQueryView : class, IView where PercentAllocationChildDialogView : class, IView
    {
        public  AccountingTicketsConsultGridView<AccountingTicketsQueryView,PercentAllocationChildDialogView> GridView {get;set;}
    }
    public partial class AccountingTicketsConsultGridView <AccountingTicketsQueryView,PercentAllocationChildDialogView> :  RPSGridView<AccountingTicketsQueryView,PercentAllocationChildDialogView> where AccountingTicketsQueryView : class, IView where PercentAllocationChildDialogView : class, IView
    {
        public AccountingTicketsConsultGridView(AccountingTicketsQueryView currentView,PercentAllocationChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDACCType = RPSControlFactory.CreateRPSGridComboBox<AccountingTicketsQueryView>("","#aff6c816-26d1-4f28-8643-5779a22af343 .ag-row[role='row']@ROWINDEX [col-id='cIDACCType']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<AccountingTicketsQueryView> IDACCType { get; set; } 
                     
    }
 
    }
  
            
    public partial class PercentAllocationChildDialogView : View
    {
        public PercentAllocationChildDialogView(AccountingTickets screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            AvailableAmount = RPSControlFactory.CreateRPSFormattedTextBox<PercentAllocationChildDialogView>("41697050-345f-4cb3-8443-a3d23bec63ec","","",false, this);
 
            CollectionInit params_PercentAllocationQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="fa7372ab-2cf8-4c7b-80a2-407b46f82aee",CSSSelectorGrid="",XPathGrid=""};
            PercentAllocationQuery = RPSControlFactory.RPSCreateCollectionWithGrid<PercentAllocationQueryCollectionEditor<PercentAllocationChildDialogView>,PercentAllocationChildDialogView>( params_PercentAllocationQuery,this);
 

        }
        public IRPSTextBox<PercentAllocationChildDialogView> AvailableAmount { get; set; } 
        public PercentAllocationQueryCollectionEditor<PercentAllocationChildDialogView> PercentAllocationQuery { get; set; } 
        public AccountingTickets Screen { get; set; }
        public PercentAllocationChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class PercentAllocationQueryCollectionEditor<PercentAllocationChildDialogView>:RPSCollectionEditor<PercentAllocationChildDialogView> where PercentAllocationChildDialogView : class, IView
    {
        public  PercentAllocationQueryGridView<PercentAllocationChildDialogView> GridView {get;set;}
    }
    public partial class PercentAllocationQueryGridView <PercentAllocationChildDialogView> :  RPSGridView<PercentAllocationChildDialogView> where PercentAllocationChildDialogView : class, IView
    {
        public PercentAllocationQueryGridView(PercentAllocationChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<PercentAllocationChildDialogView>("","#fa7372ab-2cf8-4c7b-80a2-407b46f82aee .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<PercentAllocationChildDialogView>("","#fa7372ab-2cf8-4c7b-80a2-407b46f82aee .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<PercentAllocationChildDialogView> Percentage { get; set; } 
        public IRPSGridTextBox<PercentAllocationChildDialogView> Amount { get; set; } 
                     
    }
 
    }
  
            
    public partial class AccountingDateChildDialogView : View
    {
        public AccountingDateChildDialogView(AccountingTickets screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            AccountingDate = RPSControlFactory.CreateRPSTextBox<AccountingDateChildDialogView>("a76b15b5-2e3f-41dd-8119-d8d648acc163","","",true, this);
 

        }
        public IRPSTextBox<AccountingDateChildDialogView> AccountingDate { get; set; } 
        public AccountingTickets Screen { get; set; }
        public AccountingDateChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}