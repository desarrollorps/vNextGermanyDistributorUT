    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.ReceivablePayable.SupplierMiscellaneous
{
    //RPS VERSION 1.0.0.0
    public partial class SupplierMiscellaneous:Screen
    {
        public SupplierMiscellaneous():base()
        {
            this.URL = "receivablepayable.suppliermiscellaneous";
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
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "5bc52c96-fee4-44cb-9e47-4b8723344f4f",CSSSelectorDescriptor = "",XPathDescriptor = ""};
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
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<SupplierMiscellaneousEntityView>("4ffa9ade-97f3-48d1-a781-db349f69d97f","","",true, this);
 
            ThirdType = RPSControlFactory.CreateRPSEnumComboBox<SupplierMiscellaneousEntityView>("812cb960-2f65-49d0-9751-73173e36dea5","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SupplierMiscellaneousEntityView>("7b519db1-e862-4aa2-a712-d010359f66fc","","",false, this);
 
            Position = RPSControlFactory.CreateRPSTextBox<SupplierMiscellaneousEntityView>("4c61cb1d-765c-47e0-a0c4-7f22cfd3807a","","",false, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<SupplierMiscellaneousEntityView>("d5a278c6-b23f-4f83-80be-a5caef8ca9dc","","",false, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<SupplierMiscellaneousEntityView>("7cceb97f-6552-4df6-9346-1febcaa96bdc","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<SupplierMiscellaneousEntityView>("a174f2de-78d0-4975-aab1-bb840b1f5d53","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<SupplierMiscellaneousEntityView>("834a1320-57eb-4566-b588-92474af34d6c","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<SupplierMiscellaneousEntityView>("8d335f57-ee44-4c55-9254-26e3bdea3d83","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<SupplierMiscellaneousEntityView>("eba2ff1c-7b03-4b3d-9d0d-24c2a5a37192","","",false, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<SupplierMiscellaneousEntityView>("e9bfdca0-c1da-4838-9240-18abb27250ba","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<SupplierMiscellaneousEntityView>("9ddedd0f-8066-489c-8e46-ed3d3c6b3224","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<SupplierMiscellaneousEntityView>("be227575-7aa4-444b-8384-317f061499ca","","",false, this);
 
            Email = RPSControlFactory.CreateRPSEmailTextBox<SupplierMiscellaneousEntityView>("a4b478f1-3f9c-4f45-8689-c024280c4898","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<SupplierMiscellaneousEntityView>("a9678c36-f0e4-4f1e-b5a2-c1ef5529514d","","",false, this);
 
            Section = RPSControlFactory.CreateRPSSection<SupplierMiscellaneousEntityView>( "","ul li[rpsid='9fe92667-6e93-4160-bba0-f434760a3a0f']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<SupplierMiscellaneousEntityView>( "","ul li[rpsid='d4d3c23e-0cfc-4935-977e-4a61fcc349db']","",this);
 

        }
        public IRPSSaveButton<SupplierMiscellaneousEntityView> SaveButton { get; set; } 
        public IRPSButton<SupplierMiscellaneousEntityView> DeleteButton { get; set; } 
        public IRPSButton<SupplierMiscellaneousEntityView,SupplierMiscellaneousCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierMiscellaneousEntityView,SupplierMiscellaneousCollectionView> BackButton { get; set; } 
        public IRPSTextBox<SupplierMiscellaneousEntityView> VATNumber { get; set; } 
        public IRPSComboBox<SupplierMiscellaneousEntityView> ThirdType { get; set; } 
        public IRPSTextBox<SupplierMiscellaneousEntityView> Description { get; set; } 
        public IRPSTextBox<SupplierMiscellaneousEntityView> Position { get; set; } 
        public IRPSComboBox<SupplierMiscellaneousEntityView> CodCountry { get; set; } 
        public IRPSTextBox<SupplierMiscellaneousEntityView> ZipCode { get; set; } 
        public IRPSComboBox<SupplierMiscellaneousEntityView> IDState { get; set; } 
        public IRPSComboBox<SupplierMiscellaneousEntityView> IDCounty { get; set; } 
        public IRPSTextBox<SupplierMiscellaneousEntityView> Address { get; set; } 
        public IRPSTextBox<SupplierMiscellaneousEntityView> City { get; set; } 
        public IRPSTextBox<SupplierMiscellaneousEntityView> Phone1 { get; set; } 
        public IRPSTextBox<SupplierMiscellaneousEntityView> Phone2 { get; set; } 
        public IRPSTextBox<SupplierMiscellaneousEntityView> Fax { get; set; } 
        public IRPSTextBox<SupplierMiscellaneousEntityView> Email { get; set; } 
        public IRPSTextBox<SupplierMiscellaneousEntityView> Comment { get; set; } 
        public IRPSSection<SupplierMiscellaneousEntityView> Section { get; set; } 
        public IRPSSection<SupplierMiscellaneousEntityView> Section1 { get; set; } 
        public SupplierMiscellaneous Screen { get; set; }
        public SupplierMiscellaneousEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}