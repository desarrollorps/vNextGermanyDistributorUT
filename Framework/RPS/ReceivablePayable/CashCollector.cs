    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.ReceivablePayable.CashCollector
{
    //RPS VERSION 1.0.0.0
    public partial class CashCollector:Screen
    {
        public CashCollector():base()
        {
            this.URL = "receivablepayable.cashcollector";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CashCollectorCollectionView  = new CashCollectorCollectionView(this); 
            CashCollectorEntityView  = new CashCollectorEntityView(this); 
            CashCollectorCollectionView.InitializeControls(); 
            CashCollectorEntityView.InitializeControls(); 
           
        }
      
            public CashCollectorCollectionView CashCollectorCollectionView {get; set; } 
            public CashCollectorEntityView CashCollectorEntityView {get; set; } 
    }
            
    public partial class CashCollectorCollectionView : View
    {
        public CashCollectorCollectionView(CashCollector screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CashCollectorCollectionView,CashCollectorEntityView>( this,Screen.CashCollectorEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "bd804766-8fc4-4f89-8865-0c2d1670f473",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CashCollectorCollectionView,CashCollectorEntityView>( params_MainConsult,this,Screen.CashCollectorEntityView);
 

        }
        public IRPSButton<CashCollectorCollectionView,CashCollectorEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CashCollectorCollectionView,CashCollectorEntityView> MainConsult { get; set; } 
        public CashCollector Screen { get; set; }
        public CashCollectorCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CashCollectorEntityView : View
    {
        public CashCollectorEntityView(CashCollector screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CashCollectorEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CashCollectorEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CashCollectorEntityView,CashCollectorCollectionView>( this,Screen.CashCollectorCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CashCollectorEntityView,CashCollectorCollectionView>( this,Screen.CashCollectorCollectionView);
 
            CodCashCollector = RPSControlFactory.CreateRPSTextBox<CashCollectorEntityView>("c2d321c2-8ae8-4097-b94a-7009e702099a","","",true, this);
 
            Name = RPSControlFactory.CreateRPSTextBox<CashCollectorEntityView>("2eb770cc-c0fb-4f3d-b55b-cda5fba63bfe","","",false, this);
 
            LastSentNumber = RPSControlFactory.CreateRPSFormattedTextBox<CashCollectorEntityView>("eaa6e6d8-7447-456c-80fe-636f5b18f137","","",true, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<CashCollectorEntityView>("5491e671-e2d5-4273-95e3-2d9dacbf3694","","",false, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<CashCollectorEntityView>("73a77142-0117-437e-a3dc-e691165f7206","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<CashCollectorEntityView>("240612f6-4c6f-4543-bb09-43fc53951e6a","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<CashCollectorEntityView>("c59bfbd6-b613-4f8a-b70c-390980320550","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<CashCollectorEntityView>("f39ae116-075a-4977-b97b-9786a1beef5d","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<CashCollectorEntityView>("53d38ac9-0065-441e-bd72-76c44e940b2a","","",false, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<CashCollectorEntityView>("a05c0be7-4c52-46ff-aa57-1d67a5e5245c","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<CashCollectorEntityView>("96cb3f3d-7f09-4d22-b98b-53467480e432","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<CashCollectorEntityView>("db130cf8-1c96-42da-b48c-e16ab5cad261","","",false, this);
 
            Email = RPSControlFactory.CreateRPSTextBox<CashCollectorEntityView>("6cabf6b0-3c13-4bc0-9c67-798b24e3a1d3","","",false, this);
 

        }
        public IRPSSaveButton<CashCollectorEntityView> SaveButton { get; set; } 
        public IRPSButton<CashCollectorEntityView> DeleteButton { get; set; } 
        public IRPSButton<CashCollectorEntityView,CashCollectorCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CashCollectorEntityView,CashCollectorCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CashCollectorEntityView> CodCashCollector { get; set; } 
        public IRPSTextBox<CashCollectorEntityView> Name { get; set; } 
        public IRPSTextBox<CashCollectorEntityView> LastSentNumber { get; set; } 
        public IRPSComboBox<CashCollectorEntityView> CodCountry { get; set; } 
        public IRPSTextBox<CashCollectorEntityView> ZipCode { get; set; } 
        public IRPSComboBox<CashCollectorEntityView> IDState { get; set; } 
        public IRPSComboBox<CashCollectorEntityView> IDCounty { get; set; } 
        public IRPSTextBox<CashCollectorEntityView> Address { get; set; } 
        public IRPSTextBox<CashCollectorEntityView> City { get; set; } 
        public IRPSTextBox<CashCollectorEntityView> Phone1 { get; set; } 
        public IRPSTextBox<CashCollectorEntityView> Phone2 { get; set; } 
        public IRPSTextBox<CashCollectorEntityView> Fax { get; set; } 
        public IRPSTextBox<CashCollectorEntityView> Email { get; set; } 
        public CashCollector Screen { get; set; }
        public CashCollectorEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}