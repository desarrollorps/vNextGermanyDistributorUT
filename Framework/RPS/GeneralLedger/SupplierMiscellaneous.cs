    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.SupplierMiscellaneous
{
    //RPS VERSION 1.0.0.0
    public partial class SupplierMiscellaneous:Screen
    {
        public SupplierMiscellaneous():base()
        {
            this.URL = "generalledger.suppliermiscellaneous";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SupplierMiscellaneousCollectionView  = new SupplierMiscellaneousCollectionView(this); 
            SupplierMiscellaneousEntityView  = new SupplierMiscellaneousEntityView(this); 
            SupplierMiscellaneousCollectionView.InitializeControls(); 
            SupplierMiscellaneousEntityView.InitializeControls(); 
           
        }
      
            public SupplierMiscellaneousCollectionView SupplierMiscellaneousCollectionView {get; set; } 
            public SupplierMiscellaneousEntityView SupplierMiscellaneousEntityView {get; set; } 
    }
            
    public partial class SupplierMiscellaneousCollectionView : View
    {
        public SupplierMiscellaneousCollectionView(SupplierMiscellaneous screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<SupplierMiscellaneousCollectionView,SupplierMiscellaneousEntityView>( this,Screen.SupplierMiscellaneousEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "a3c527bd-0433-478f-b353-605da275d16f",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<SupplierMiscellaneousCollectionView,SupplierMiscellaneousEntityView>( params_MainConsult,this,Screen.SupplierMiscellaneousEntityView);
 

        }
        public IRPSButton<SupplierMiscellaneousCollectionView,SupplierMiscellaneousEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<SupplierMiscellaneousCollectionView,SupplierMiscellaneousEntityView> MainConsult { get; set; } 
        public SupplierMiscellaneous Screen { get; set; }
        public SupplierMiscellaneousCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SupplierMiscellaneousEntityView : View
    {
        public SupplierMiscellaneousEntityView(SupplierMiscellaneous screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<SupplierMiscellaneousEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierMiscellaneousEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierMiscellaneousEntityView,SupplierMiscellaneousCollectionView>( this,Screen.SupplierMiscellaneousCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierMiscellaneousEntityView,SupplierMiscellaneousCollectionView>( this,Screen.SupplierMiscellaneousCollectionView);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<SupplierMiscellaneousEntityView>("f1decf2e-72cc-4d03-a38d-51e931649d58","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SupplierMiscellaneousEntityView>("315d84ac-36db-4549-b5f8-c5779393649c","","",false, this);
 
            ThirdType = RPSControlFactory.CreateRPSEnumComboBox<SupplierMiscellaneousEntityView>("317e7eab-4a22-44b9-a034-6d3b84174338","","",true, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<SupplierMiscellaneousEntityView>("1aa361ec-30dc-4966-8411-00f5b393f800","","",false, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<SupplierMiscellaneousEntityView>("5d369136-0b04-411f-85d9-0769c83e956d","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<SupplierMiscellaneousEntityView>("9596cd3f-b31a-429c-95d6-429fc27b34d9","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<SupplierMiscellaneousEntityView>("ea449c5d-3e0c-452b-9613-19c931db2919","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<SupplierMiscellaneousEntityView>("b50a32ae-2499-483f-bb51-e4a25a6cc139","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<SupplierMiscellaneousEntityView>("e7b4f62d-713a-4f1a-9677-fec70c3fefd1","","",false, this);
 
            Position = RPSControlFactory.CreateRPSTextBox<SupplierMiscellaneousEntityView>("d7c67770-6309-49ad-a677-1d25ceb00671","","",false, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<SupplierMiscellaneousEntityView>("5a6ad4e7-6656-4a54-b70e-a076d81d9537","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<SupplierMiscellaneousEntityView>("d19ef36b-619a-4773-a5db-64d5ce8b935e","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<SupplierMiscellaneousEntityView>("5bb13547-51fb-4451-8c85-e7f3cca48990","","",false, this);
 
            Email = RPSControlFactory.CreateRPSEmailTextBox<SupplierMiscellaneousEntityView>("049a8014-cfdf-449d-9dd7-fe7ca86b5935","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<SupplierMiscellaneousEntityView>("53475895-9302-444b-9fd3-bb61c827d921","","",false, this);
 
            GeneralData = RPSControlFactory.CreateRPSSection<SupplierMiscellaneousEntityView>( "","ul li[rpsid='f43c105d-c30c-4c1f-b37d-5ebb4aa1111f']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<SupplierMiscellaneousEntityView>( "","ul li[rpsid='bebe41f5-8a8f-4132-9e5d-46c809b4620a']","",this);
 

        }
        public IRPSSaveButton<SupplierMiscellaneousEntityView> SaveButton { get; set; } 
        public IRPSButton<SupplierMiscellaneousEntityView> DeleteButton { get; set; } 
        public IRPSButton<SupplierMiscellaneousEntityView,SupplierMiscellaneousCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierMiscellaneousEntityView,SupplierMiscellaneousCollectionView> BackButton { get; set; } 
        public IRPSTextBox<SupplierMiscellaneousEntityView> VATNumber { get; set; } 
        public IRPSTextBox<SupplierMiscellaneousEntityView> Description { get; set; } 
        public IRPSComboBox<SupplierMiscellaneousEntityView> ThirdType { get; set; } 
        public IRPSComboBox<SupplierMiscellaneousEntityView> CodCountry { get; set; } 
        public IRPSTextBox<SupplierMiscellaneousEntityView> ZipCode { get; set; } 
        public IRPSComboBox<SupplierMiscellaneousEntityView> IDState { get; set; } 
        public IRPSComboBox<SupplierMiscellaneousEntityView> IDCounty { get; set; } 
        public IRPSTextBox<SupplierMiscellaneousEntityView> Address { get; set; } 
        public IRPSTextBox<SupplierMiscellaneousEntityView> City { get; set; } 
        public IRPSTextBox<SupplierMiscellaneousEntityView> Position { get; set; } 
        public IRPSTextBox<SupplierMiscellaneousEntityView> Phone1 { get; set; } 
        public IRPSTextBox<SupplierMiscellaneousEntityView> Phone2 { get; set; } 
        public IRPSTextBox<SupplierMiscellaneousEntityView> Fax { get; set; } 
        public IRPSTextBox<SupplierMiscellaneousEntityView> Email { get; set; } 
        public IRPSTextBox<SupplierMiscellaneousEntityView> Comment { get; set; } 
        public IRPSSection<SupplierMiscellaneousEntityView> GeneralData { get; set; } 
        public IRPSSection<SupplierMiscellaneousEntityView> Comments { get; set; } 
        public SupplierMiscellaneous Screen { get; set; }
        public SupplierMiscellaneousEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}