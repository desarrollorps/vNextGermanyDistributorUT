    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.DeliveryAddress
{
    //RPS VERSION 1.0.0.0
    public partial class DeliveryAddress:Screen
    {
        public DeliveryAddress():base()
        {
            this.URL = "purchase.deliveryaddress";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DeliveryAddressCollectionView  = new DeliveryAddressCollectionView(this); 
            DeliveryAddressEntityView  = new DeliveryAddressEntityView(this); 
            DeliveryAddressFromCustomerDialogView  = new DeliveryAddressFromCustomerDialogView(this); 
            DeliveryAddressCollectionView.InitializeControls(); 
            DeliveryAddressEntityView.InitializeControls(); 
            DeliveryAddressFromCustomerDialogView.InitializeControls(); 
           
        }
      
            public DeliveryAddressCollectionView DeliveryAddressCollectionView {get; set; } 
            public DeliveryAddressEntityView DeliveryAddressEntityView {get; set; } 
            public DeliveryAddressFromCustomerDialogView DeliveryAddressFromCustomerDialogView {get; set; } 
    }
            
    public partial class DeliveryAddressCollectionView : View
    {
        public DeliveryAddressCollectionView(DeliveryAddress screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<DeliveryAddressCollectionView,DeliveryAddressEntityView>( this,Screen.DeliveryAddressEntityView);
 
            DeliveryAddressFromCustomerNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DeliveryAddressCollectionView,DeliveryAddressFromCustomerDialogView>("a086b558-5b9d-4fe8-87b2-0b19a686f1f8","","", this,Screen.DeliveryAddressFromCustomerDialogView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "95212a14-ff23-4800-9a2a-fc5a9a6fe581",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<DeliveryAddressCollectionView,DeliveryAddressEntityView>( params_MainConsult,this,Screen.DeliveryAddressEntityView);
 

        }
        public IRPSButton<DeliveryAddressCollectionView,DeliveryAddressEntityView> NewButton { get; set; } 
        public IRPSButton<DeliveryAddressCollectionView,DeliveryAddressFromCustomerDialogView> DeliveryAddressFromCustomerNavigationCommandButton { get; set; } 
        public IRPSCollectionEditor<DeliveryAddressCollectionView,DeliveryAddressEntityView> MainConsult { get; set; } 
        public DeliveryAddress Screen { get; set; }
        public DeliveryAddressCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DeliveryAddressEntityView : View
    {
        public DeliveryAddressEntityView(DeliveryAddress screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<DeliveryAddressEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<DeliveryAddressEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DeliveryAddressEntityView,DeliveryAddressCollectionView>( this,Screen.DeliveryAddressCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<DeliveryAddressEntityView,DeliveryAddressCollectionView>( this,Screen.DeliveryAddressCollectionView);
 
            CodDeliveryAddress = RPSControlFactory.CreateRPSTextBox<DeliveryAddressEntityView>("ba606c82-d97a-4149-a143-96261ef1e5b1","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<DeliveryAddressEntityView>("295a9bd5-e335-4732-a8d8-95dd233147db","","",false, this);
 
            DefaultAddress = RPSControlFactory.CreateRPSCheckBox<DeliveryAddressEntityView>("4c5ce363-6c55-4af4-8146-f216f01921dd","","",true, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<DeliveryAddressEntityView>("f89513d3-f217-4c8e-a6a3-db104db3058e","","",false, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<DeliveryAddressEntityView>("359df668-e689-4535-b4cd-71b51f50368f","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<DeliveryAddressEntityView>("9a035d10-43cd-4aef-8bb3-81981291c87a","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<DeliveryAddressEntityView>("e2a705c4-e8ff-4406-9ba7-7ae9d4f14421","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<DeliveryAddressEntityView>("fb4ebf9b-94fd-4b59-93a8-fa7de7c4b0f1","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<DeliveryAddressEntityView>("2fc5e93e-d3a5-4307-aa3f-a1791cf7fd07","","",false, this);
 
            ContactPerson = RPSControlFactory.CreateRPSTextBox<DeliveryAddressEntityView>("082c13f3-4aaf-4696-8286-79ffd5ae2356","","",false, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<DeliveryAddressEntityView>("31aa03cc-c19f-4166-bf7f-f4d2e711a2aa","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<DeliveryAddressEntityView>("ffad38c8-28f5-4c14-b075-3e7c0d430788","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<DeliveryAddressEntityView>("e38b986f-8cb1-4c74-a738-213ad660fd27","","",false, this);
 
            Email = RPSControlFactory.CreateRPSEmailTextBox<DeliveryAddressEntityView>("cbbd363c-0423-4e80-ae77-99ded15b7b8f","","",false, this);
 
            Ean13 = RPSControlFactory.CreateRPSTextBox<DeliveryAddressEntityView>("d503ebe2-9296-43eb-8fa1-3ecaa31496c8","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<DeliveryAddressEntityView>("bcbb70c6-99ea-4db9-95f3-a6d9e637402d","","",false, this);
 
            GeneralDataSection = RPSControlFactory.CreateRPSSection<DeliveryAddressEntityView>( "","ul li[rpsid='8c1f31e4-60c0-4a42-95fd-aed3420078b5']","",this);
 
            CommentsSection = RPSControlFactory.CreateRPSSection<DeliveryAddressEntityView>( "","ul li[rpsid='a11033cf-e607-4428-92e6-162adb79fcd8']","",this);
 

        }
        public IRPSSaveButton<DeliveryAddressEntityView> SaveButton { get; set; } 
        public IRPSButton<DeliveryAddressEntityView> DeleteButton { get; set; } 
        public IRPSButton<DeliveryAddressEntityView,DeliveryAddressCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DeliveryAddressEntityView,DeliveryAddressCollectionView> BackButton { get; set; } 
        public IRPSTextBox<DeliveryAddressEntityView> CodDeliveryAddress { get; set; } 
        public IRPSTextBox<DeliveryAddressEntityView> Description { get; set; } 
        public IRPSCheckbox<DeliveryAddressEntityView> DefaultAddress { get; set; } 
        public IRPSComboBox<DeliveryAddressEntityView> CodCountry { get; set; } 
        public IRPSTextBox<DeliveryAddressEntityView> ZipCode { get; set; } 
        public IRPSComboBox<DeliveryAddressEntityView> IDState { get; set; } 
        public IRPSComboBox<DeliveryAddressEntityView> IDCounty { get; set; } 
        public IRPSTextBox<DeliveryAddressEntityView> Address { get; set; } 
        public IRPSTextBox<DeliveryAddressEntityView> City { get; set; } 
        public IRPSTextBox<DeliveryAddressEntityView> ContactPerson { get; set; } 
        public IRPSTextBox<DeliveryAddressEntityView> Phone1 { get; set; } 
        public IRPSTextBox<DeliveryAddressEntityView> Phone2 { get; set; } 
        public IRPSTextBox<DeliveryAddressEntityView> Fax { get; set; } 
        public IRPSTextBox<DeliveryAddressEntityView> Email { get; set; } 
        public IRPSTextBox<DeliveryAddressEntityView> Ean13 { get; set; } 
        public IRPSTextBox<DeliveryAddressEntityView> Comment { get; set; } 
        public IRPSSection<DeliveryAddressEntityView> GeneralDataSection { get; set; } 
        public IRPSSection<DeliveryAddressEntityView> CommentsSection { get; set; } 
        public DeliveryAddress Screen { get; set; }
        public DeliveryAddressEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DeliveryAddressFromCustomerDialogView : View
    {
        public DeliveryAddressFromCustomerDialogView(DeliveryAddress screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDCustomer = RPSControlFactory.CreateRPSComboBox<DeliveryAddressFromCustomerDialogView>("b55dcd3e-6a23-48a3-b402-b387b32e77e6","","",true, this);
 
            IDCustomerDeliveryAddress = RPSControlFactory.CreateRPSComboBox<DeliveryAddressFromCustomerDialogView>("43f94bd2-63b9-4510-ac1a-9925629be79a","","",false, this);
 

        }
        public IRPSComboBox<DeliveryAddressFromCustomerDialogView> IDCustomer { get; set; } 
        public IRPSComboBox<DeliveryAddressFromCustomerDialogView> IDCustomerDeliveryAddress { get; set; } 
        public DeliveryAddress Screen { get; set; }
        public DeliveryAddressFromCustomerDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}