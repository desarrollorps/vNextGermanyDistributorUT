    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.SupplierMiscellaneous
{
    //RPS VERSION 1.0.0.0
    public partial class SupplierMiscellaneous:Screen
    {
        public SupplierMiscellaneous():base()
        {
            this.URL = "purchase.suppliermiscellaneous";
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
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "fed1620d-e56f-490a-97c4-a7305d2a501c",CSSSelectorDescriptor = "",XPathDescriptor = ""};
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
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<SupplierMiscellaneousEntityView>("923947da-9467-4c3b-8c05-35711de01670","","",true, this);
 
            ThirdType = RPSControlFactory.CreateRPSEnumComboBox<SupplierMiscellaneousEntityView>("11785384-ad90-4631-86c1-905bead99557","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SupplierMiscellaneousEntityView>("961b6414-b897-4cab-be27-303c1ba99eef","","",false, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<SupplierMiscellaneousEntityView>("358d576f-7b65-42eb-ae53-72b691a37798","","",false, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<SupplierMiscellaneousEntityView>("85d12ad4-9181-41bc-bb87-3a9a9572fb38","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<SupplierMiscellaneousEntityView>("b274e1aa-42e3-4845-a403-d0b808c87022","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<SupplierMiscellaneousEntityView>("2fd01ba6-d2b6-4937-8b21-b50c63f79c09","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<SupplierMiscellaneousEntityView>("892abc90-e1b0-41e4-8612-9ceca9f884f3","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<SupplierMiscellaneousEntityView>("d0f5be3a-0de8-4d37-ae29-33371a75d524","","",false, this);
 
            Position = RPSControlFactory.CreateRPSTextBox<SupplierMiscellaneousEntityView>("eaa69630-831c-4c64-8e9b-81c627ab28f2","","",false, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<SupplierMiscellaneousEntityView>("ed0149b7-3550-4383-b8a8-e5c5e801c8ba","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<SupplierMiscellaneousEntityView>("f7caabf0-c56e-4bfa-be64-70846644d676","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<SupplierMiscellaneousEntityView>("d92fe4b2-79f9-4696-8d19-282fecd84dc7","","",false, this);
 
            Email = RPSControlFactory.CreateRPSEmailTextBox<SupplierMiscellaneousEntityView>("c40d8160-dfd3-44c3-9838-a0a764999447","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<SupplierMiscellaneousEntityView>("8a890ff6-cb1b-48f0-a4f0-78fef9b36f53","","",false, this);
 
            GeneralDataSection = RPSControlFactory.CreateRPSSection<SupplierMiscellaneousEntityView>( "","ul li[rpsid='cc447f05-609e-4d59-8eb9-f5dc7cac7d2e']","",this);
 
            CommentsSection = RPSControlFactory.CreateRPSSection<SupplierMiscellaneousEntityView>( "","ul li[rpsid='00e4916f-24c4-4471-9346-28e5803a59cd']","",this);
 

        }
        public IRPSSaveButton<SupplierMiscellaneousEntityView> SaveButton { get; set; } 
        public IRPSButton<SupplierMiscellaneousEntityView> DeleteButton { get; set; } 
        public IRPSButton<SupplierMiscellaneousEntityView,SupplierMiscellaneousCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierMiscellaneousEntityView,SupplierMiscellaneousCollectionView> BackButton { get; set; } 
        public IRPSTextBox<SupplierMiscellaneousEntityView> VATNumber { get; set; } 
        public IRPSComboBox<SupplierMiscellaneousEntityView> ThirdType { get; set; } 
        public IRPSTextBox<SupplierMiscellaneousEntityView> Description { get; set; } 
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
        public IRPSSection<SupplierMiscellaneousEntityView> GeneralDataSection { get; set; } 
        public IRPSSection<SupplierMiscellaneousEntityView> CommentsSection { get; set; } 
        public SupplierMiscellaneous Screen { get; set; }
        public SupplierMiscellaneousEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}