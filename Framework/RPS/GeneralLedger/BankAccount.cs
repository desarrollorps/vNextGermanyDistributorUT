    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.BankAccount
{
    //RPS VERSION 1.0.0.0
    public partial class BankAccount:Screen
    {
        public BankAccount():base()
        {
            this.URL = "generalledger.bankaccount";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            BankAccountCollectionView  = new BankAccountCollectionView(this); 
            BankAccountEntityView  = new BankAccountEntityView(this); 
            BankAccountCollectionView.InitializeControls(); 
            BankAccountEntityView.InitializeControls(); 
           
        }
      
            public BankAccountCollectionView BankAccountCollectionView {get; set; } 
            public BankAccountEntityView BankAccountEntityView {get; set; } 
    }
            
    public partial class BankAccountCollectionView : View
    {
        public BankAccountCollectionView(BankAccount screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<BankAccountCollectionView,BankAccountEntityView>( this,Screen.BankAccountEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "96e62995-a6fb-453d-912e-f2e6c3f084b0",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<BankAccountCollectionView,BankAccountEntityView>( params_MainConsult,this,Screen.BankAccountEntityView);
 

        }
        public IRPSButton<BankAccountCollectionView,BankAccountEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<BankAccountCollectionView,BankAccountEntityView> MainConsult { get; set; } 
        public BankAccount Screen { get; set; }
        public BankAccountCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class BankAccountEntityView : View
    {
        public BankAccountEntityView(BankAccount screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<BankAccountEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<BankAccountEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<BankAccountEntityView,BankAccountCollectionView>( this,Screen.BankAccountCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<BankAccountEntityView,BankAccountCollectionView>( this,Screen.BankAccountCollectionView);
 
            IDBankAccountCompany = RPSControlFactory.CreateRPSComboBox<BankAccountEntityView>("fb638233-9302-49e3-970a-dde988ca4bb4","","",true, this);
 
            IDAccountBank = RPSControlFactory.CreateRPSComboBox<BankAccountEntityView>("6f7112ee-d50a-43b1-b9b3-73b54af67178","","",true, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<BankAccountEntityView>("fedb3078-af78-4c93-ae45-d0ed41479a97","","",false, this);
 
            IDAccountServices = RPSControlFactory.CreateRPSComboBox<BankAccountEntityView>("2aadc67b-4440-43ec-9bdf-dfd55018706e","","",false, this);
 
            IDAccountDiscountInterest = RPSControlFactory.CreateRPSComboBox<BankAccountEntityView>("fcecbd58-da1f-4bcf-aa66-55c9fee70028","","",false, this);
 
            IDAccountUnpaidExpense = RPSControlFactory.CreateRPSComboBox<BankAccountEntityView>("88a7c877-bed6-4e60-bdaa-81841b00145a","","",false, this);
 

        }
        public IRPSSaveButton<BankAccountEntityView> SaveButton { get; set; } 
        public IRPSButton<BankAccountEntityView> DeleteButton { get; set; } 
        public IRPSButton<BankAccountEntityView,BankAccountCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<BankAccountEntityView,BankAccountCollectionView> BackButton { get; set; } 
        public IRPSComboBox<BankAccountEntityView> IDBankAccountCompany { get; set; } 
        public IRPSComboBox<BankAccountEntityView> IDAccountBank { get; set; } 
        public IRPSComboBox<BankAccountEntityView> IDSupplier { get; set; } 
        public IRPSComboBox<BankAccountEntityView> IDAccountServices { get; set; } 
        public IRPSComboBox<BankAccountEntityView> IDAccountDiscountInterest { get; set; } 
        public IRPSComboBox<BankAccountEntityView> IDAccountUnpaidExpense { get; set; } 
        public BankAccount Screen { get; set; }
        public BankAccountEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}