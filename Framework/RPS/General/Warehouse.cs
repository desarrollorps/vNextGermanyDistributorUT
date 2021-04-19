    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.Warehouse
{
    //RPS VERSION 1.0.0.0
    public partial class Warehouse:Screen
    {
        public Warehouse():base()
        {
            this.URL = "general.warehouse";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            WareHouseCollectionView  = new WareHouseCollectionView(this); 
            WareHouseEntityView  = new WareHouseEntityView(this); 
            WareHouseCollectionView.InitializeControls(); 
            WareHouseEntityView.InitializeControls(); 
           
        }
      
            public WareHouseCollectionView WareHouseCollectionView {get; set; } 
            public WareHouseEntityView WareHouseEntityView {get; set; } 
    }
            
    public partial class WareHouseCollectionView : View
    {
        public WareHouseCollectionView(Warehouse screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<WareHouseCollectionView,WareHouseEntityView>( this,Screen.WareHouseEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "a7d34dd6-dc06-472f-8744-ab334efca43f",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<WareHouseCollectionView,WareHouseEntityView>( params_MainConsult,this,Screen.WareHouseEntityView);
 

        }
        public IRPSButton<WareHouseCollectionView,WareHouseEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<WareHouseCollectionView,WareHouseEntityView> MainConsult { get; set; } 
        public Warehouse Screen { get; set; }
        public WareHouseCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class WareHouseEntityView : View
    {
        public WareHouseEntityView(Warehouse screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<WareHouseEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<WareHouseEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<WareHouseEntityView,WareHouseCollectionView>( this,Screen.WareHouseCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<WareHouseEntityView,WareHouseCollectionView>( this,Screen.WareHouseCollectionView);
 
            CodWarehouse = RPSControlFactory.CreateRPSTextBox<WareHouseEntityView>("e6e56fbc-7500-4e49-bdf1-a364f739ce8f","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<WareHouseEntityView>("92dc8686-e037-4f1d-a8f1-e2f27eb9860f","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<WareHouseEntityView>("8ec635f5-6d10-42d3-ba37-3e8fc07e0837","","",true, this);
 
            ClosedDate = RPSControlFactory.CreateRPSTextBox<WareHouseEntityView>("7a960851-7db4-4a65-b4fc-6fc4524e6837","","",false, this);
 
            StockNegative = RPSControlFactory.CreateRPSCheckBox<WareHouseEntityView>("85271a7a-f64c-4c4d-9c07-98f19980c298","","",true, this);
 
            Available = RPSControlFactory.CreateRPSCheckBox<WareHouseEntityView>("cc548529-58fa-4ff9-b559-107fb814d32c","","",true, this);
 
            AvailableMRP = RPSControlFactory.CreateRPSCheckBox<WareHouseEntityView>("cb5441c9-1b2c-4d53-9bdd-07192456e113","","",true, this);
 
            LocationControl = RPSControlFactory.CreateRPSCheckBox<WareHouseEntityView>("2a68fde9-13e7-4bcf-af33-195b5aae9f25","","",true, this);
 
            Deposit = RPSControlFactory.CreateRPSCheckBox<WareHouseEntityView>("74dc605c-b2ba-467c-ad5c-b324158121bc","","",true, this);
 
            Blocked = RPSControlFactory.CreateRPSCheckBox<WareHouseEntityView>("7c70b746-1aa6-4a8c-8770-d97a297a2656","","",true, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<WareHouseEntityView>("2c8dfe85-bc5b-429c-89ae-8a261b206a69","","",false, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<WareHouseEntityView>("fd1df572-6f48-4b2b-8fe4-1007595101ed","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<WareHouseEntityView>("52e2d499-f942-459a-b713-e8b6bd18421e","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<WareHouseEntityView>("1a1042a9-e8c6-429f-a8a1-2a33daf68757","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<WareHouseEntityView>("062038d0-bd08-49c8-be05-d90f55e39b34","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<WareHouseEntityView>("5a3defcb-25ec-4092-8d89-ee47865becac","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<WareHouseEntityView>("8281faa4-2b19-4581-9a98-6e2126064918","","",false, this);
 
            BasicData = RPSControlFactory.CreateRPSSection<WareHouseEntityView>( "","ul li[rpsid='4683afef-485e-40b9-8c9f-ac4a3e550253']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<WareHouseEntityView>( "","ul li[rpsid='00b5914b-6fba-41b5-9542-2f098a6d533a']","",this);
 

        }
        public IRPSSaveButton<WareHouseEntityView> SaveButton { get; set; } 
        public IRPSButton<WareHouseEntityView> DeleteButton { get; set; } 
        public IRPSButton<WareHouseEntityView,WareHouseCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<WareHouseEntityView,WareHouseCollectionView> BackButton { get; set; } 
        public IRPSTextBox<WareHouseEntityView> CodWarehouse { get; set; } 
        public IRPSTextBox<WareHouseEntityView> Description { get; set; } 
        public IRPSComboBox<WareHouseEntityView> IDSite { get; set; } 
        public IRPSTextBox<WareHouseEntityView> ClosedDate { get; set; } 
        public IRPSCheckbox<WareHouseEntityView> StockNegative { get; set; } 
        public IRPSCheckbox<WareHouseEntityView> Available { get; set; } 
        public IRPSCheckbox<WareHouseEntityView> AvailableMRP { get; set; } 
        public IRPSCheckbox<WareHouseEntityView> LocationControl { get; set; } 
        public IRPSCheckbox<WareHouseEntityView> Deposit { get; set; } 
        public IRPSCheckbox<WareHouseEntityView> Blocked { get; set; } 
        public IRPSComboBox<WareHouseEntityView> CodCountry { get; set; } 
        public IRPSTextBox<WareHouseEntityView> ZipCode { get; set; } 
        public IRPSComboBox<WareHouseEntityView> IDState { get; set; } 
        public IRPSComboBox<WareHouseEntityView> IDCounty { get; set; } 
        public IRPSTextBox<WareHouseEntityView> Address { get; set; } 
        public IRPSTextBox<WareHouseEntityView> City { get; set; } 
        public IRPSTextBox<WareHouseEntityView> Comment { get; set; } 
        public IRPSSection<WareHouseEntityView> BasicData { get; set; } 
        public IRPSSection<WareHouseEntityView> Comments { get; set; } 
        public Warehouse Screen { get; set; }
        public WareHouseEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}