    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.CustomerMiscellaneousSL
{
    //RPS VERSION 1.0.0.0
    public partial class CustomerMiscellaneousSL:Screen
    {
        public CustomerMiscellaneousSL():base()
        {
            this.URL = "sales.customermiscellaneoussl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CustomerMiscellaneousSLCollectionView  = new CustomerMiscellaneousSLCollectionView(this); 
            CustomerMiscellaneousSLEntityView  = new CustomerMiscellaneousSLEntityView(this); 
            CustomerMiscellaneousSLCollectionView.InitializeControls(); 
            CustomerMiscellaneousSLEntityView.InitializeControls(); 
           
        }
      
            public CustomerMiscellaneousSLCollectionView CustomerMiscellaneousSLCollectionView {get; set; } 
            public CustomerMiscellaneousSLEntityView CustomerMiscellaneousSLEntityView {get; set; } 
    }
            
    public partial class CustomerMiscellaneousSLCollectionView : View
    {
        public CustomerMiscellaneousSLCollectionView(CustomerMiscellaneousSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CustomerMiscellaneousSLCollectionView,CustomerMiscellaneousSLEntityView>( this,Screen.CustomerMiscellaneousSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "07047ffa-ec8e-4f6a-9223-ad633d292c65",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CustomerMiscellaneousSLCollectionView,CustomerMiscellaneousSLEntityView>( params_MainConsult,this,Screen.CustomerMiscellaneousSLEntityView);
 

        }
        public IRPSButton<CustomerMiscellaneousSLCollectionView,CustomerMiscellaneousSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CustomerMiscellaneousSLCollectionView,CustomerMiscellaneousSLEntityView> MainConsult { get; set; } 
        public CustomerMiscellaneousSL Screen { get; set; }
        public CustomerMiscellaneousSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CustomerMiscellaneousSLEntityView : View
    {
        public CustomerMiscellaneousSLEntityView(CustomerMiscellaneousSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CustomerMiscellaneousSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CustomerMiscellaneousSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CustomerMiscellaneousSLEntityView,CustomerMiscellaneousSLCollectionView>( this,Screen.CustomerMiscellaneousSLCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CustomerMiscellaneousSLEntityView,CustomerMiscellaneousSLCollectionView>( this,Screen.CustomerMiscellaneousSLCollectionView);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<CustomerMiscellaneousSLEntityView>("ecdbe697-f5d7-42c1-9709-0754e3eb461b","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CustomerMiscellaneousSLEntityView>("87b70273-6e57-4633-9fd4-9a122f161281","","",false, this);
 
            ThirdType = RPSControlFactory.CreateRPSEnumComboBox<CustomerMiscellaneousSLEntityView>("15b194f2-b4e2-4f3d-a15b-35cc8c0353f3","","",true, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<CustomerMiscellaneousSLEntityView>("241c1922-e8d3-4b44-9262-dfbe8a2118ca","","",false, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<CustomerMiscellaneousSLEntityView>("764d667c-d623-4900-b911-68302922ffd0","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<CustomerMiscellaneousSLEntityView>("d14f23e3-1c7c-4a64-9b1d-a882bdf1c3e1","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<CustomerMiscellaneousSLEntityView>("7efa3e68-7e8b-4104-aee0-990c5494ff4a","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<CustomerMiscellaneousSLEntityView>("be37245a-61b0-46d7-9a8e-e127ecf56954","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<CustomerMiscellaneousSLEntityView>("6d22bba9-1e58-4eb5-9a59-0f01a5a68936","","",false, this);
 
            Position = RPSControlFactory.CreateRPSTextBox<CustomerMiscellaneousSLEntityView>("c1ab3b25-d919-48e9-aa4e-57c92b33ae10","","",false, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<CustomerMiscellaneousSLEntityView>("17c94f6b-5f91-4a79-89c8-a38bf9dabb0c","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<CustomerMiscellaneousSLEntityView>("13e6b7cc-32d0-4135-96b0-5f777f97afa0","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<CustomerMiscellaneousSLEntityView>("37e701d3-9986-4dc1-be6c-24f331aba2be","","",false, this);
 
            Email1 = RPSControlFactory.CreateRPSEmailTextBox<CustomerMiscellaneousSLEntityView>("0440de87-204d-4044-8511-e042a951940d","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<CustomerMiscellaneousSLEntityView>("3a56e8a0-1dee-4faf-8867-1f8e33fdc26f","","",false, this);
 
            GeneralData = RPSControlFactory.CreateRPSSection<CustomerMiscellaneousSLEntityView>( "","ul li[rpsid='cfde3625-944d-471d-9fba-b31094cf543f']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<CustomerMiscellaneousSLEntityView>( "","ul li[rpsid='782bcd93-d7ab-406f-9822-91074718fbcf']","",this);
 

        }
        public IRPSSaveButton<CustomerMiscellaneousSLEntityView> SaveButton { get; set; } 
        public IRPSButton<CustomerMiscellaneousSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<CustomerMiscellaneousSLEntityView,CustomerMiscellaneousSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerMiscellaneousSLEntityView,CustomerMiscellaneousSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CustomerMiscellaneousSLEntityView> VATNumber { get; set; } 
        public IRPSTextBox<CustomerMiscellaneousSLEntityView> Description { get; set; } 
        public IRPSComboBox<CustomerMiscellaneousSLEntityView> ThirdType { get; set; } 
        public IRPSComboBox<CustomerMiscellaneousSLEntityView> CodCountry { get; set; } 
        public IRPSTextBox<CustomerMiscellaneousSLEntityView> ZipCode { get; set; } 
        public IRPSComboBox<CustomerMiscellaneousSLEntityView> IDState { get; set; } 
        public IRPSComboBox<CustomerMiscellaneousSLEntityView> IDCounty { get; set; } 
        public IRPSTextBox<CustomerMiscellaneousSLEntityView> Address { get; set; } 
        public IRPSTextBox<CustomerMiscellaneousSLEntityView> City { get; set; } 
        public IRPSTextBox<CustomerMiscellaneousSLEntityView> Position { get; set; } 
        public IRPSTextBox<CustomerMiscellaneousSLEntityView> Phone1 { get; set; } 
        public IRPSTextBox<CustomerMiscellaneousSLEntityView> Phone2 { get; set; } 
        public IRPSTextBox<CustomerMiscellaneousSLEntityView> Fax { get; set; } 
        public IRPSTextBox<CustomerMiscellaneousSLEntityView> Email1 { get; set; } 
        public IRPSTextBox<CustomerMiscellaneousSLEntityView> Comment { get; set; } 
        public IRPSSection<CustomerMiscellaneousSLEntityView> GeneralData { get; set; } 
        public IRPSSection<CustomerMiscellaneousSLEntityView> Comments { get; set; } 
        public CustomerMiscellaneousSL Screen { get; set; }
        public CustomerMiscellaneousSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}