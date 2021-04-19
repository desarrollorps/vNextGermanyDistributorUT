    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.AccountCluster
{
    //RPS VERSION 1.0.0.0
    public partial class AccountCluster:Screen
    {
        public AccountCluster():base()
        {
            this.URL = "generalledger.accountcluster";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            AccountClusterCollectionView  = new AccountClusterCollectionView(this); 
            AccountClusterEntityView  = new AccountClusterEntityView(this); 
            AccountsDialogView  = new AccountsDialogView(this); 
            AccountClusterCollectionView.InitializeControls(); 
            AccountClusterEntityView.InitializeControls(); 
            AccountsDialogView.InitializeControls(); 
           
        }
      
            public AccountClusterCollectionView AccountClusterCollectionView {get; set; } 
            public AccountClusterEntityView AccountClusterEntityView {get; set; } 
            public AccountsDialogView AccountsDialogView {get; set; } 
    }
            
    public partial class AccountClusterCollectionView : View
    {
        public AccountClusterCollectionView(AccountCluster screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<AccountClusterCollectionView,AccountClusterEntityView>( this,Screen.AccountClusterEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "3866a835-d8e4-440b-b9d0-15efb3c380ad",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<AccountClusterCollectionView,AccountClusterEntityView>( params_MainConsult,this,Screen.AccountClusterEntityView);
 

        }
        public IRPSButton<AccountClusterCollectionView,AccountClusterEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<AccountClusterCollectionView,AccountClusterEntityView> MainConsult { get; set; } 
        public AccountCluster Screen { get; set; }
        public AccountClusterCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class AccountClusterEntityView : View
    {
        public AccountClusterEntityView(AccountCluster screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<AccountClusterEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<AccountClusterEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<AccountClusterEntityView,AccountClusterCollectionView>( this,Screen.AccountClusterCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<AccountClusterEntityView,AccountClusterCollectionView>( this,Screen.AccountClusterCollectionView);
 
            CodAccountCluster = RPSControlFactory.CreateRPSTextBox<AccountClusterEntityView>("5bf1c254-0b94-45cc-b146-c4781ea95f09","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<AccountClusterEntityView>("2187b44d-da94-4df9-8165-5c063f1625e8","","",false, this);
 
            AccountsNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<AccountClusterEntityView,AccountsDialogView>("d0c34300-1033-47b5-9d77-004b8883e3c2","","", this,Screen.AccountsDialogView);
 
            CollectionInit params_GetClusterAccounts = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="38db41e4-fdbf-4f52-8694-e5deb7711df7",CSSSelectorGrid="",XPathGrid=""};
            GetClusterAccounts = RPSControlFactory.RPSCreateCollectionWithGrid<GetClusterAccountsCollectionEditor<AccountClusterEntityView,AccountsDialogView>,AccountClusterEntityView,AccountsDialogView>( params_GetClusterAccounts,this,Screen.AccountsDialogView);
 

        }
        public IRPSSaveButton<AccountClusterEntityView> SaveButton { get; set; } 
        public IRPSButton<AccountClusterEntityView> DeleteButton { get; set; } 
        public IRPSButton<AccountClusterEntityView,AccountClusterCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<AccountClusterEntityView,AccountClusterCollectionView> BackButton { get; set; } 
        public IRPSTextBox<AccountClusterEntityView> CodAccountCluster { get; set; } 
        public IRPSTextBox<AccountClusterEntityView> Description { get; set; } 
        public IRPSButton<AccountClusterEntityView,AccountsDialogView> AccountsNavigationCommandButton { get; set; } 
        public GetClusterAccountsCollectionEditor<AccountClusterEntityView,AccountsDialogView> GetClusterAccounts { get; set; } 
        public AccountCluster Screen { get; set; }
        public AccountClusterEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetClusterAccountsCollectionEditor<AccountClusterEntityView,AccountsDialogView>:RPSCollectionEditor<AccountClusterEntityView,AccountsDialogView> where AccountClusterEntityView : class, IView where AccountsDialogView : class, IView
    {
        public  GetClusterAccountsGridView<AccountClusterEntityView,AccountsDialogView> GridView {get;set;}
    }
    public partial class GetClusterAccountsGridView <AccountClusterEntityView,AccountsDialogView> :  RPSGridView<AccountClusterEntityView,AccountsDialogView> where AccountClusterEntityView : class, IView where AccountsDialogView : class, IView
    {
        public GetClusterAccountsGridView(AccountClusterEntityView currentView,AccountsDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeleteCommand = RPSControlFactory.CreateRPSGridButton<AccountClusterEntityView>( "","#38db41e4-fdbf-4f52-8694-e5deb7711df7 .ag-row[role='row']@ROWINDEX [col-id='cDeleteCommand']","",this.CurrentView);
 

        }
        public IRPSGridButton<AccountClusterEntityView> DeleteCommand { get; set; } 
                     
    }
 
    }
  
            
    public partial class AccountsDialogView : View
    {
        public AccountsDialogView(AccountCluster screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Account = RPSControlFactory.CreateRPSCollectionComboBox<AccountsDialogView>("45dac935-3140-431c-b51c-0546189da1f4","","",false, this);
 

        }
        public IRPSCollectionComboBox<AccountsDialogView> Account { get; set; } 
        public AccountCluster Screen { get; set; }
        public AccountsDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}