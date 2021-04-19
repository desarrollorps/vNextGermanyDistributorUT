    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.CuDistAddress
{
    //RPS VERSION 1.0.0.0
    public partial class CuDistAddress:Screen
    {
        public CuDistAddress():base()
        {
            this.URL = "general.cudistaddress";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CuDistAddressCollectionView  = new CuDistAddressCollectionView(this); 
            CuDistAddressView  = new CuDistAddressView(this); 
            CuDistAddressContactView  = new CuDistAddressContactView(this); 
            CuDistAddressCollectionView.InitializeControls(); 
            CuDistAddressView.InitializeControls(); 
            CuDistAddressContactView.InitializeControls(); 
           
        }
      
            public CuDistAddressCollectionView CuDistAddressCollectionView {get; set; } 
            public CuDistAddressView CuDistAddressView {get; set; } 
            public CuDistAddressContactView CuDistAddressContactView {get; set; } 
    }
            
    public partial class CuDistAddressCollectionView : View
    {
        public CuDistAddressCollectionView(CuDistAddress screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CuDistAddressCollectionView,CuDistAddressView>( this,Screen.CuDistAddressView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "6f6b9b34-fd65-4d9e-85d3-fc8289ab7eba",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CuDistAddressCollectionView,CuDistAddressView>( params_MainConsult,this,Screen.CuDistAddressView);
 

        }
        public IRPSButton<CuDistAddressCollectionView,CuDistAddressView> NewButton { get; set; } 
        public IRPSCollectionEditor<CuDistAddressCollectionView,CuDistAddressView> MainConsult { get; set; } 
        public CuDistAddress Screen { get; set; }
        public CuDistAddressCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CuDistAddressView : View
    {
        public CuDistAddressView(CuDistAddress screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CuDistAddressView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CuDistAddressView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CuDistAddressView,CuDistAddressCollectionView>( this,Screen.CuDistAddressCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CuDistAddressView,CuDistAddressCollectionView>( this,Screen.CuDistAddressCollectionView);
 
            CodAddress = RPSControlFactory.CreateRPSTextBox<CuDistAddressView>("35317b65-0a17-4f2d-b92a-6ec84391fc90","","",true, this);
 
            CompanyName = RPSControlFactory.CreateRPSTextBox<CuDistAddressView>("21b511cb-45cf-4720-8b4c-3bd82358b8d5","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<CuDistAddressView>("c7dcd194-40d8-4700-a81c-340a07b527e8","","",false, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<CuDistAddressView>("5eb26e80-c4d8-4ae0-837a-8a8aa2a6b4cd","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<CuDistAddressView>("c391ea6f-3c79-4117-8f7a-fa6f57606892","","",false, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<CuDistAddressView>("628e980d-a078-4b13-93d0-e92388877a58","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<CuDistAddressView>("c1f083f5-bf4a-4be5-94e2-fba716d89040","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<CuDistAddressView>("bf64a0ab-645c-4f63-b71e-23df3ed10fc2","","",false, this);
 
            IDPotentialCustomer = RPSControlFactory.CreateRPSComboBox<CuDistAddressView>("f792eebe-3233-4718-aefa-1bb713dd5037","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<CuDistAddressView>("dd8cc4b1-2216-4c9f-b3a8-424c2c3c0f59","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<CuDistAddressView>("439314bc-f1bb-4c62-910d-d200f995c9d1","","",false, this);
 
            CreatePotentialCustomerCommandButton = RPSControlFactory.CreateRPSButton<CuDistAddressView>( "61363cf4-f3ea-46af-b453-40dd28cf8d1e","","",this);
 
            CreateCustomerCommandButton = RPSControlFactory.CreateRPSButton<CuDistAddressView>( "96da97c0-a3ed-4cb0-a359-357e13440dc8","","",this);
 
            CreateSupplierCommandButton = RPSControlFactory.CreateRPSButton<CuDistAddressView>( "0656c58a-fdf1-40a4-92b8-8573b85421fe","","",this);
 
            CollectionInit params_CuDistAddressContacts = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0f2a3efe-afbb-4c50-b22a-d2c16b235f74",CSSSelectorGrid="",XPathGrid=""};
            CuDistAddressContacts = RPSControlFactory.RPSCreateCollectionWithGrid<CuDistAddressContactsCollectionEditor<CuDistAddressView,CuDistAddressContactView>,CuDistAddressView,CuDistAddressContactView>( params_CuDistAddressContacts,this,Screen.CuDistAddressContactView);
 
            GeneralDataSection = RPSControlFactory.CreateRPSSection<CuDistAddressView>( "","ul li[rpsid='048bad93-df31-475e-b257-570c054b6f92']","",this);
 
            CuDistAddressContactSection = RPSControlFactory.CreateRPSSection<CuDistAddressView>( "","ul li[rpsid='5f9fa86d-8fe9-46a5-8f66-1d2de9121cbf']","",this);
 

        }
        public IRPSSaveButton<CuDistAddressView> SaveButton { get; set; } 
        public IRPSButton<CuDistAddressView> DeleteButton { get; set; } 
        public IRPSButton<CuDistAddressView,CuDistAddressCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CuDistAddressView,CuDistAddressCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CuDistAddressView> CodAddress { get; set; } 
        public IRPSTextBox<CuDistAddressView> CompanyName { get; set; } 
        public IRPSTextBox<CuDistAddressView> Address { get; set; } 
        public IRPSTextBox<CuDistAddressView> ZipCode { get; set; } 
        public IRPSTextBox<CuDistAddressView> City { get; set; } 
        public IRPSComboBox<CuDistAddressView> CodCountry { get; set; } 
        public IRPSComboBox<CuDistAddressView> IDState { get; set; } 
        public IRPSComboBox<CuDistAddressView> IDCounty { get; set; } 
        public IRPSComboBox<CuDistAddressView> IDPotentialCustomer { get; set; } 
        public IRPSComboBox<CuDistAddressView> IDCustomer { get; set; } 
        public IRPSComboBox<CuDistAddressView> IDSupplier { get; set; } 
        public IRPSButton<CuDistAddressView> CreatePotentialCustomerCommandButton { get; set; } 
        public IRPSButton<CuDistAddressView> CreateCustomerCommandButton { get; set; } 
        public IRPSButton<CuDistAddressView> CreateSupplierCommandButton { get; set; } 
        public CuDistAddressContactsCollectionEditor<CuDistAddressView,CuDistAddressContactView> CuDistAddressContacts { get; set; } 
        public IRPSSection<CuDistAddressView> GeneralDataSection { get; set; } 
        public IRPSSection<CuDistAddressView> CuDistAddressContactSection { get; set; } 
        public CuDistAddress Screen { get; set; }
        public CuDistAddressView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CuDistAddressContactsCollectionEditor<CuDistAddressView,CuDistAddressContactView>:RPSCollectionEditor<CuDistAddressView,CuDistAddressContactView> where CuDistAddressView : class, IView where CuDistAddressContactView : class, IView
    {
        public  CuDistAddressContactsGridView<CuDistAddressView,CuDistAddressContactView> GridView {get;set;}
    }
    public partial class CuDistAddressContactsGridView <CuDistAddressView,CuDistAddressContactView> :  RPSGridView<CuDistAddressView,CuDistAddressContactView> where CuDistAddressView : class, IView where CuDistAddressContactView : class, IView
    {
        public CuDistAddressContactsGridView(CuDistAddressView currentView,CuDistAddressContactView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Title = RPSControlFactory.CreateRPSGridTextBox<CuDistAddressView>("","#0f2a3efe-afbb-4c50-b22a-d2c16b235f74 .ag-row[role='row']@ROWINDEX [col-id='cTitle']","",false, this.CurrentView);
 
            Gender = RPSControlFactory.CreateRPSGridEnumComboBox<CuDistAddressView>("","#0f2a3efe-afbb-4c50-b22a-d2c16b235f74 .ag-row[role='row']@ROWINDEX [col-id='cGender']","",true, this.CurrentView);
 
            FirstName = RPSControlFactory.CreateRPSGridTextBox<CuDistAddressView>("","#0f2a3efe-afbb-4c50-b22a-d2c16b235f74 .ag-row[role='row']@ROWINDEX [col-id='cFirstName']","",false, this.CurrentView);
 
            LastName = RPSControlFactory.CreateRPSGridTextBox<CuDistAddressView>("","#0f2a3efe-afbb-4c50-b22a-d2c16b235f74 .ag-row[role='row']@ROWINDEX [col-id='cLastName']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<CuDistAddressView>("","#0f2a3efe-afbb-4c50-b22a-d2c16b235f74 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Phone1 = RPSControlFactory.CreateRPSGridTextBox<CuDistAddressView>("","#0f2a3efe-afbb-4c50-b22a-d2c16b235f74 .ag-row[role='row']@ROWINDEX [col-id='cPhone1']","",false, this.CurrentView);
 
            Mobile = RPSControlFactory.CreateRPSGridTextBox<CuDistAddressView>("","#0f2a3efe-afbb-4c50-b22a-d2c16b235f74 .ag-row[role='row']@ROWINDEX [col-id='cMobile']","",false, this.CurrentView);
 
            Email = RPSControlFactory.CreateRPSGridTextBox<CuDistAddressView>("","#0f2a3efe-afbb-4c50-b22a-d2c16b235f74 .ag-row[role='row']@ROWINDEX [col-id='cEmail']","",false, this.CurrentView);
 
            IDPotentialCustomerContact = RPSControlFactory.CreateRPSGridComboBox<CuDistAddressView>("","#0f2a3efe-afbb-4c50-b22a-d2c16b235f74 .ag-row[role='row']@ROWINDEX [col-id='cIDPotentialCustomerContact']","",false, this.CurrentView);
 
            IDCustomerContact = RPSControlFactory.CreateRPSGridComboBox<CuDistAddressView>("","#0f2a3efe-afbb-4c50-b22a-d2c16b235f74 .ag-row[role='row']@ROWINDEX [col-id='cIDCustomerContact']","",false, this.CurrentView);
 
            IDSupplierContact = RPSControlFactory.CreateRPSGridComboBox<CuDistAddressView>("","#0f2a3efe-afbb-4c50-b22a-d2c16b235f74 .ag-row[role='row']@ROWINDEX [col-id='cIDSupplierContact']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CuDistAddressView> Title { get; set; } 
        public IRPSGridComboBox<CuDistAddressView> Gender { get; set; } 
        public IRPSGridTextBox<CuDistAddressView> FirstName { get; set; } 
        public IRPSGridTextBox<CuDistAddressView> LastName { get; set; } 
        public IRPSGridTextBox<CuDistAddressView> Description { get; set; } 
        public IRPSGridTextBox<CuDistAddressView> Phone1 { get; set; } 
        public IRPSGridTextBox<CuDistAddressView> Mobile { get; set; } 
        public IRPSGridTextBox<CuDistAddressView> Email { get; set; } 
        public IRPSGridComboBox<CuDistAddressView> IDPotentialCustomerContact { get; set; } 
        public IRPSGridComboBox<CuDistAddressView> IDCustomerContact { get; set; } 
        public IRPSGridComboBox<CuDistAddressView> IDSupplierContact { get; set; } 
                     
    }
 
    }
  
            
    public partial class CuDistAddressContactView : View
    {
        public CuDistAddressContactView(CuDistAddress screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CuDistAddressContactView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CuDistAddressContactView,CuDistAddressView>( this,Screen.CuDistAddressView);
 
            BackButton = RPSControlFactory.RPSBackButton<CuDistAddressContactView,CuDistAddressView>( this,Screen.CuDistAddressView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CuDistAddressContactView,CuDistAddressView>( this,Screen.CuDistAddressView);
 
            Title = RPSControlFactory.CreateRPSTextBox<CuDistAddressContactView>("94555096-26ba-4029-a38f-b7a252b24491","","",false, this);
 
            Gender = RPSControlFactory.CreateRPSEnumComboBox<CuDistAddressContactView>("ed54bbec-54d3-4341-a371-bbe6ad3b97da","","",true, this);
 
            FirstName = RPSControlFactory.CreateRPSTextBox<CuDistAddressContactView>("55da90d4-34b1-438a-b923-685e08e5d198","","",false, this);
 
            LastName = RPSControlFactory.CreateRPSTextBox<CuDistAddressContactView>("3dcbaafc-3637-4c25-a8e1-fbd8f7927d84","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CuDistAddressContactView>("9a3e2690-17aa-49b6-a52c-ec7cca4a7e54","","",false, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<CuDistAddressContactView>("574f81b3-5e35-485b-91d8-2454fc30de27","","",false, this);
 
            Mobile = RPSControlFactory.CreateRPSTextBox<CuDistAddressContactView>("4be0c1c1-fc11-4f11-b262-a83a1a92a364","","",false, this);
 
            Email = RPSControlFactory.CreateRPSTextBox<CuDistAddressContactView>("979513df-5514-407b-b59b-18aa378d9a0b","","",false, this);
 
            IDPotentialCustomerContact = RPSControlFactory.CreateRPSComboBox<CuDistAddressContactView>("8c88aa3d-7189-42e8-af20-ca1b1c3cabfc","","",false, this);
 
            IDCustomerContact = RPSControlFactory.CreateRPSComboBox<CuDistAddressContactView>("0c78b101-7a66-462d-84b3-ddfacc53c6dd","","",false, this);
 
            IDSupplierContact = RPSControlFactory.CreateRPSComboBox<CuDistAddressContactView>("736a0d97-5742-4068-a459-55c2213a17aa","","",false, this);
 

        }
        public IRPSButton<CuDistAddressContactView> DeleteButton { get; set; } 
        public IRPSButton<CuDistAddressContactView,CuDistAddressView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CuDistAddressContactView,CuDistAddressView> BackButton { get; set; } 
        public IRPSAcceptButton<CuDistAddressContactView,CuDistAddressView> AcceptButton { get; set; } 
        public IRPSTextBox<CuDistAddressContactView> Title { get; set; } 
        public IRPSComboBox<CuDistAddressContactView> Gender { get; set; } 
        public IRPSTextBox<CuDistAddressContactView> FirstName { get; set; } 
        public IRPSTextBox<CuDistAddressContactView> LastName { get; set; } 
        public IRPSTextBox<CuDistAddressContactView> Description { get; set; } 
        public IRPSTextBox<CuDistAddressContactView> Phone1 { get; set; } 
        public IRPSTextBox<CuDistAddressContactView> Mobile { get; set; } 
        public IRPSTextBox<CuDistAddressContactView> Email { get; set; } 
        public IRPSComboBox<CuDistAddressContactView> IDPotentialCustomerContact { get; set; } 
        public IRPSComboBox<CuDistAddressContactView> IDCustomerContact { get; set; } 
        public IRPSComboBox<CuDistAddressContactView> IDSupplierContact { get; set; } 
        public CuDistAddress Screen { get; set; }
        public CuDistAddressContactView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}