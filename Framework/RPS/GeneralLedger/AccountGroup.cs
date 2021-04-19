    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.AccountGroup
{
    //RPS VERSION 1.0.0.0
    public partial class AccountGroup:Screen
    {
        public AccountGroup():base()
        {
            this.URL = "generalledger.accountgroup";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            AccountGroupCollectionView  = new AccountGroupCollectionView(this); 
            AccountGroupEntityView  = new AccountGroupEntityView(this); 
            ImportAccountGroupDialogView  = new ImportAccountGroupDialogView(this); 
            AccountGroupCollectionView.InitializeControls(); 
            AccountGroupEntityView.InitializeControls(); 
            ImportAccountGroupDialogView.InitializeControls(); 
           
        }
      
            public AccountGroupCollectionView AccountGroupCollectionView {get; set; } 
            public AccountGroupEntityView AccountGroupEntityView {get; set; } 
            public ImportAccountGroupDialogView ImportAccountGroupDialogView {get; set; } 
    }
            
    public partial class AccountGroupCollectionView : View
    {
        public AccountGroupCollectionView(AccountGroup screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<AccountGroupCollectionView,AccountGroupEntityView>( this,Screen.AccountGroupEntityView);
 
            ImportAccountGroupNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<AccountGroupCollectionView,ImportAccountGroupDialogView>("19ee66df-b507-4ecc-afea-6e4efb8fffff","","", this,Screen.ImportAccountGroupDialogView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "d27c3e12-9c11-4c9b-8ffc-76bbd27a34fb",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<AccountGroupCollectionView,AccountGroupEntityView>( params_MainConsult,this,Screen.AccountGroupEntityView);
 

        }
        public IRPSButton<AccountGroupCollectionView,AccountGroupEntityView> NewButton { get; set; } 
        public IRPSButton<AccountGroupCollectionView,ImportAccountGroupDialogView> ImportAccountGroupNavigationCommandButton { get; set; } 
        public IRPSCollectionEditor<AccountGroupCollectionView,AccountGroupEntityView> MainConsult { get; set; } 
        public AccountGroup Screen { get; set; }
        public AccountGroupCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class AccountGroupEntityView : View
    {
        public AccountGroupEntityView(AccountGroup screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<AccountGroupEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<AccountGroupEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<AccountGroupEntityView,AccountGroupCollectionView>( this,Screen.AccountGroupCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<AccountGroupEntityView,AccountGroupCollectionView>( this,Screen.AccountGroupCollectionView);
 
            CodAccountGroup = RPSControlFactory.CreateRPSTextBox<AccountGroupEntityView>("ac13ec64-3c61-4ecd-8de1-e3915de6ea15","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<AccountGroupEntityView>("7853443c-8499-4582-91bb-92da46ef2a1d","","",false, this);
 

        }
        public IRPSSaveButton<AccountGroupEntityView> SaveButton { get; set; } 
        public IRPSButton<AccountGroupEntityView> DeleteButton { get; set; } 
        public IRPSButton<AccountGroupEntityView,AccountGroupCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<AccountGroupEntityView,AccountGroupCollectionView> BackButton { get; set; } 
        public IRPSTextBox<AccountGroupEntityView> CodAccountGroup { get; set; } 
        public IRPSTextBox<AccountGroupEntityView> Description { get; set; } 
        public AccountGroup Screen { get; set; }
        public AccountGroupEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ImportAccountGroupDialogView : View
    {
        public ImportAccountGroupDialogView(AccountGroup screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public AccountGroup Screen { get; set; }
        public ImportAccountGroupDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}