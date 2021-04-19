    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.ShippingAgent
{
    //RPS VERSION 1.0.0.0
    public partial class ShippingAgent:Screen
    {
        public ShippingAgent():base()
        {
            this.URL = "purchase.shippingagent";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ShippingAgentSLCollectionView  = new ShippingAgentSLCollectionView(this); 
            ShippingAgentSLEntityView  = new ShippingAgentSLEntityView(this); 
            ShippingAgentSLCollectionView.InitializeControls(); 
            ShippingAgentSLEntityView.InitializeControls(); 
           
        }
      
            public ShippingAgentSLCollectionView ShippingAgentSLCollectionView {get; set; } 
            public ShippingAgentSLEntityView ShippingAgentSLEntityView {get; set; } 
    }
            
    public partial class ShippingAgentSLCollectionView : View
    {
        public ShippingAgentSLCollectionView(ShippingAgent screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ShippingAgentSLCollectionView,ShippingAgentSLEntityView>( this,Screen.ShippingAgentSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "c6d8067a-3d44-4d15-b836-cdb8988aadc1",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ShippingAgentSLCollectionView,ShippingAgentSLEntityView>( params_MainConsult,this,Screen.ShippingAgentSLEntityView);
 

        }
        public IRPSButton<ShippingAgentSLCollectionView,ShippingAgentSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ShippingAgentSLCollectionView,ShippingAgentSLEntityView> MainConsult { get; set; } 
        public ShippingAgent Screen { get; set; }
        public ShippingAgentSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ShippingAgentSLEntityView : View
    {
        public ShippingAgentSLEntityView(ShippingAgent screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ShippingAgentSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ShippingAgentSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ShippingAgentSLEntityView,ShippingAgentSLCollectionView>( this,Screen.ShippingAgentSLCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ShippingAgentSLEntityView,ShippingAgentSLCollectionView>( this,Screen.ShippingAgentSLCollectionView);
 
            CodShippingAgent = RPSControlFactory.CreateRPSTextBox<ShippingAgentSLEntityView>("e1e47e9f-de34-4b57-ab87-79dff3a4cf67","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ShippingAgentSLEntityView>("89b7751d-05f4-405d-b416-8ad1a626f382","","",false, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<ShippingAgentSLEntityView>("36b95841-479d-4ee7-88ad-54bc30329a5a","","",false, this);
 
            ThirdType = RPSControlFactory.CreateRPSEnumComboBox<ShippingAgentSLEntityView>("9fd5cc73-9992-44fb-b55a-cb61cd17bbc8","","",true, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<ShippingAgentSLEntityView>("c4ad67d0-b9a4-4daf-bd03-2007ae02a37c","","",true, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<ShippingAgentSLEntityView>("2e8c0f2e-69d2-4566-ae83-8faf50de3111","","",false, this);
 
            InactiveDate = RPSControlFactory.CreateRPSTextBox<ShippingAgentSLEntityView>("5cb3d98d-e671-407e-b6a7-e931ddf11bd1","","",false, this);
 
            IDShippingVehicle = RPSControlFactory.CreateRPSComboBox<ShippingAgentSLEntityView>("4f5852c4-8b00-4a7a-8990-0dcafe5efbb5","","",false, this);
 
            CodTransportMethod = RPSControlFactory.CreateRPSComboBox<ShippingAgentSLEntityView>("e509db05-5714-4697-8ba3-0530fe81a3e3","","",false, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<ShippingAgentSLEntityView>("313fc8e1-db05-457a-ae4a-c968d7561f4c","","",false, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<ShippingAgentSLEntityView>("c4f31c72-de52-46a1-816e-8e1a3cef1b46","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<ShippingAgentSLEntityView>("25777997-1d42-48c5-8a06-e37e4a41f615","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<ShippingAgentSLEntityView>("a56b5a86-ad94-4c69-86e8-fa85a06ee27d","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<ShippingAgentSLEntityView>("23e6aa52-46c9-43db-8897-bc9ccea8e405","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<ShippingAgentSLEntityView>("748cdfdc-b814-4334-9607-7d0fee47d0be","","",false, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<ShippingAgentSLEntityView>("1c638c86-1c50-403c-94ff-7386ac974757","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<ShippingAgentSLEntityView>("0b2cfccc-0727-44d5-a5a4-884916c11ce8","","",false, this);
 
            Email = RPSControlFactory.CreateRPSTextBox<ShippingAgentSLEntityView>("49fc02ad-320e-40a4-9ac2-c7d59479f9ec","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<ShippingAgentSLEntityView>("cdf8fa50-c3d5-44ec-8461-3fdf51859ac8","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<ShippingAgentSLEntityView>("88c227ef-f895-4a8f-913d-80a4a9095b13","","",false, this);
 
            Section = RPSControlFactory.CreateRPSSection<ShippingAgentSLEntityView>( "","ul li[rpsid='a792f841-3896-4b28-ba5e-87d85952ea5c']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<ShippingAgentSLEntityView>( "","ul li[rpsid='94169c91-0a87-4102-96aa-2604e9955c40']","",this);
 

        }
        public IRPSSaveButton<ShippingAgentSLEntityView> SaveButton { get; set; } 
        public IRPSButton<ShippingAgentSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<ShippingAgentSLEntityView,ShippingAgentSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ShippingAgentSLEntityView,ShippingAgentSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ShippingAgentSLEntityView> CodShippingAgent { get; set; } 
        public IRPSTextBox<ShippingAgentSLEntityView> Description { get; set; } 
        public IRPSTextBox<ShippingAgentSLEntityView> VATNumber { get; set; } 
        public IRPSComboBox<ShippingAgentSLEntityView> ThirdType { get; set; } 
        public IRPSComboBox<ShippingAgentSLEntityView> Type { get; set; } 
        public IRPSComboBox<ShippingAgentSLEntityView> IDSupplier { get; set; } 
        public IRPSTextBox<ShippingAgentSLEntityView> InactiveDate { get; set; } 
        public IRPSComboBox<ShippingAgentSLEntityView> IDShippingVehicle { get; set; } 
        public IRPSComboBox<ShippingAgentSLEntityView> CodTransportMethod { get; set; } 
        public IRPSComboBox<ShippingAgentSLEntityView> CodCountry { get; set; } 
        public IRPSTextBox<ShippingAgentSLEntityView> ZipCode { get; set; } 
        public IRPSComboBox<ShippingAgentSLEntityView> IDState { get; set; } 
        public IRPSComboBox<ShippingAgentSLEntityView> IDCounty { get; set; } 
        public IRPSTextBox<ShippingAgentSLEntityView> Address { get; set; } 
        public IRPSTextBox<ShippingAgentSLEntityView> City { get; set; } 
        public IRPSTextBox<ShippingAgentSLEntityView> Phone1 { get; set; } 
        public IRPSTextBox<ShippingAgentSLEntityView> Phone2 { get; set; } 
        public IRPSTextBox<ShippingAgentSLEntityView> Email { get; set; } 
        public IRPSTextBox<ShippingAgentSLEntityView> Fax { get; set; } 
        public IRPSTextBox<ShippingAgentSLEntityView> Comment { get; set; } 
        public IRPSSection<ShippingAgentSLEntityView> Section { get; set; } 
        public IRPSSection<ShippingAgentSLEntityView> Section1 { get; set; } 
        public ShippingAgent Screen { get; set; }
        public ShippingAgentSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}