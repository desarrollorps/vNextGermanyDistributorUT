    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.ReceivablePayable.CustomerMiscellaneousSL
{
    //RPS VERSION 1.0.0.0
    public partial class CustomerMiscellaneousSL:Screen
    {
        public CustomerMiscellaneousSL():base()
        {
            this.URL = "receivablepayable.customermiscellaneoussl";
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
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "cfc4bb66-a3c1-4fe8-b561-e834809ee570",CSSSelectorDescriptor = "",XPathDescriptor = ""};
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
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<CustomerMiscellaneousSLEntityView>("0aa0bc72-2eac-4847-bc2a-6df843053bb5","","",true, this);
 
            ThirdType = RPSControlFactory.CreateRPSEnumComboBox<CustomerMiscellaneousSLEntityView>("1241d74a-97b3-4247-ac8c-3c3ae9135d57","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CustomerMiscellaneousSLEntityView>("a36b1729-5cde-44b6-81ad-a0ef83a41a06","","",false, this);
 
            Position = RPSControlFactory.CreateRPSTextBox<CustomerMiscellaneousSLEntityView>("b18918ff-cc87-4493-a25d-e0ac032980b4","","",false, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<CustomerMiscellaneousSLEntityView>("7ac979c3-b3e1-4699-81d2-b202168f24bd","","",false, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<CustomerMiscellaneousSLEntityView>("8547e370-135a-4597-9dbd-489d4a39a032","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<CustomerMiscellaneousSLEntityView>("ccab38c7-b5e9-489f-8846-79e5ab12ed84","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<CustomerMiscellaneousSLEntityView>("79baee3c-b302-4d1c-8a5c-819b22ffbd17","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<CustomerMiscellaneousSLEntityView>("04a875f7-1166-4f82-a6e1-694b6e0439d2","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<CustomerMiscellaneousSLEntityView>("23040700-0542-4975-83cf-8460172dfb1c","","",false, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<CustomerMiscellaneousSLEntityView>("bc95b9e4-c069-44ed-bb1d-ed248e30d95c","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<CustomerMiscellaneousSLEntityView>("995b1f3d-7d63-455a-99bf-36f78e675fe1","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<CustomerMiscellaneousSLEntityView>("a7c5b93d-0247-466b-8abe-699f40754cbe","","",false, this);
 
            Email = RPSControlFactory.CreateRPSEmailTextBox<CustomerMiscellaneousSLEntityView>("364f103b-d4bc-4b94-a8be-b5d5b5f8d497","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<CustomerMiscellaneousSLEntityView>("53be1d56-ef0c-472e-b060-47d6f6573be1","","",false, this);
 
            SectionGenData = RPSControlFactory.CreateRPSSection<CustomerMiscellaneousSLEntityView>( "","ul li[rpsid='146babbe-f544-4137-aa7b-12353dbd44bf']","",this);
 
            SectionComments = RPSControlFactory.CreateRPSSection<CustomerMiscellaneousSLEntityView>( "","ul li[rpsid='c9634fa5-1348-45a8-be2d-dc562b6a378a']","",this);
 

        }
        public IRPSSaveButton<CustomerMiscellaneousSLEntityView> SaveButton { get; set; } 
        public IRPSButton<CustomerMiscellaneousSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<CustomerMiscellaneousSLEntityView,CustomerMiscellaneousSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerMiscellaneousSLEntityView,CustomerMiscellaneousSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CustomerMiscellaneousSLEntityView> VATNumber { get; set; } 
        public IRPSComboBox<CustomerMiscellaneousSLEntityView> ThirdType { get; set; } 
        public IRPSTextBox<CustomerMiscellaneousSLEntityView> Description { get; set; } 
        public IRPSTextBox<CustomerMiscellaneousSLEntityView> Position { get; set; } 
        public IRPSComboBox<CustomerMiscellaneousSLEntityView> CodCountry { get; set; } 
        public IRPSTextBox<CustomerMiscellaneousSLEntityView> ZipCode { get; set; } 
        public IRPSComboBox<CustomerMiscellaneousSLEntityView> IDState { get; set; } 
        public IRPSComboBox<CustomerMiscellaneousSLEntityView> IDCounty { get; set; } 
        public IRPSTextBox<CustomerMiscellaneousSLEntityView> Address { get; set; } 
        public IRPSTextBox<CustomerMiscellaneousSLEntityView> City { get; set; } 
        public IRPSTextBox<CustomerMiscellaneousSLEntityView> Phone1 { get; set; } 
        public IRPSTextBox<CustomerMiscellaneousSLEntityView> Phone2 { get; set; } 
        public IRPSTextBox<CustomerMiscellaneousSLEntityView> Fax { get; set; } 
        public IRPSTextBox<CustomerMiscellaneousSLEntityView> Email { get; set; } 
        public IRPSTextBox<CustomerMiscellaneousSLEntityView> Comment { get; set; } 
        public IRPSSection<CustomerMiscellaneousSLEntityView> SectionGenData { get; set; } 
        public IRPSSection<CustomerMiscellaneousSLEntityView> SectionComments { get; set; } 
        public CustomerMiscellaneousSL Screen { get; set; }
        public CustomerMiscellaneousSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}