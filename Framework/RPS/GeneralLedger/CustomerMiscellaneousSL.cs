    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.CustomerMiscellaneousSL
{
    //RPS VERSION 1.0.0.0
    public partial class CustomerMiscellaneousSL:Screen
    {
        public CustomerMiscellaneousSL():base()
        {
            this.URL = "generalledger.customermiscellaneoussl";
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
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "d5d1cdc6-f37e-40ad-a4c6-9af1667eecfb",CSSSelectorDescriptor = "",XPathDescriptor = ""};
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
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<CustomerMiscellaneousSLEntityView>("226ff3f3-29fa-4710-b349-88283cd5bb80","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CustomerMiscellaneousSLEntityView>("477d71a7-799a-46d2-8180-37964316c841","","",false, this);
 
            ThirdType = RPSControlFactory.CreateRPSEnumComboBox<CustomerMiscellaneousSLEntityView>("b8553fbc-eaef-4f3a-b812-f9524b3a2b15","","",true, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<CustomerMiscellaneousSLEntityView>("b4332589-c6b5-4b2c-96ec-98e028daa588","","",false, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<CustomerMiscellaneousSLEntityView>("2bfb8453-5e01-4f62-b8b0-f49378d82cb1","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<CustomerMiscellaneousSLEntityView>("06de7961-99f1-4035-ae87-ccd071a9e4c6","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<CustomerMiscellaneousSLEntityView>("67b15b30-e936-475c-aee6-b95bd43aed77","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<CustomerMiscellaneousSLEntityView>("28c1f6ae-f17b-4ac7-8cf5-01d9902acb04","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<CustomerMiscellaneousSLEntityView>("ab3bb01a-77f8-4cd7-a74b-de0a828cb799","","",false, this);
 
            Position = RPSControlFactory.CreateRPSTextBox<CustomerMiscellaneousSLEntityView>("bf25ca3a-5dda-42a3-8403-a6a16252588d","","",false, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<CustomerMiscellaneousSLEntityView>("0fc484f5-987d-46ca-a148-13416480c492","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<CustomerMiscellaneousSLEntityView>("f3adee15-074f-4bb8-b45b-bb14a832ee87","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<CustomerMiscellaneousSLEntityView>("2a7e8c78-8d9e-43bf-aebb-234b6b315255","","",false, this);
 
            Email = RPSControlFactory.CreateRPSEmailTextBox<CustomerMiscellaneousSLEntityView>("273fbc8e-ead0-4de2-a31e-fe4d40759649","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<CustomerMiscellaneousSLEntityView>("bae93118-419e-4f2d-ac00-337635dfb0cc","","",false, this);
 
            GeneralData = RPSControlFactory.CreateRPSSection<CustomerMiscellaneousSLEntityView>( "","ul li[rpsid='37073716-1608-4ff1-a28b-b4f01f7dbeb1']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<CustomerMiscellaneousSLEntityView>( "","ul li[rpsid='185e749a-9c21-481e-998d-ae834224d64d']","",this);
 

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
        public IRPSTextBox<CustomerMiscellaneousSLEntityView> Email { get; set; } 
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