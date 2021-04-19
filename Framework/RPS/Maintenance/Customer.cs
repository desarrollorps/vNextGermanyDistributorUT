    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.Customer
{
    //RPS VERSION 1.0.0.0
    public partial class Customer:Screen
    {
        public Customer():base()
        {
            this.URL = "maintenance.customer";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CustomerCollectionView  = new CustomerCollectionView(this); 
            CustomerEntityView  = new CustomerEntityView(this); 
            CustomerContactView  = new CustomerContactView(this); 
            CustomerDeliveryAddressView  = new CustomerDeliveryAddressView(this); 
            CustomerDetailView  = new CustomerDetailView(this); 
            CustomerCollectionView.InitializeControls(); 
            CustomerEntityView.InitializeControls(); 
            CustomerContactView.InitializeControls(); 
            CustomerDeliveryAddressView.InitializeControls(); 
            CustomerDetailView.InitializeControls(); 
           
        }
      
            public CustomerCollectionView CustomerCollectionView {get; set; } 
            public CustomerEntityView CustomerEntityView {get; set; } 
            public CustomerContactView CustomerContactView {get; set; } 
            public CustomerDeliveryAddressView CustomerDeliveryAddressView {get; set; } 
            public CustomerDetailView CustomerDetailView {get; set; } 
    }
            
    public partial class CustomerCollectionView : View
    {
        public CustomerCollectionView(Customer screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CustomerCollectionView,CustomerEntityView>( this,Screen.CustomerEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "40c0484c-5727-4c0f-8036-f34430f08677",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CustomerCollectionView,CustomerEntityView>( params_MainConsult,this,Screen.CustomerEntityView);
 

        }
        public IRPSButton<CustomerCollectionView,CustomerEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CustomerCollectionView,CustomerEntityView> MainConsult { get; set; } 
        public Customer Screen { get; set; }
        public CustomerCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CustomerEntityView : View
    {
        public CustomerEntityView(Customer screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CustomerEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CustomerEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CustomerEntityView,CustomerCollectionView>( this,Screen.CustomerCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CustomerEntityView,CustomerCollectionView>( this,Screen.CustomerCollectionView);
 
            CodCustomer = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("21285caf-fc9e-40bb-8f9f-ebb93d79d366","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("dac8fb53-df88-4a15-828c-42e83cdaba74","","",false, this);
 
            CompanyName = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("2763232d-b796-4feb-a643-51074559f5cb","","",false, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("876c2b88-5ee7-49a3-abaa-7d5383e51bf0","","",false, this);
 
            ThirdType = RPSControlFactory.CreateRPSEnumComboBox<CustomerEntityView>("95405d83-770a-46bc-b444-05ee411c48b8","","",true, this);
 
            InactiveDate = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("042424a9-d4b9-4191-8312-fa888e8e743a","","",false, this);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("4c70d4a8-c732-4c46-97e0-e4142bf20c19","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("a80bb1e9-c861-4d14-b7bb-3addf1d9b742","","",true, this);
 
            BlockedMaintenance = RPSControlFactory.CreateRPSCheckBox<CustomerEntityView>("52f61576-02fb-44fb-b584-58f63a69a47a","","",true, this);
 
            TextNoticeMaintenance = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("90c2d557-91dc-4754-819e-7e2d913f6e47","","",false, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("7ce38029-553e-4629-adf9-9268de629545","","",false, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("bfc6933e-ede9-4bb1-b1cb-3af0b7c5255c","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("b1f97d5b-7dc2-4f57-9bce-b31b0de7bc02","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("a2461340-90a0-4f38-b21c-6a07d0d75ead","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("cd80341c-a275-444f-adbc-91e5394a06d6","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("0c1a0df7-892a-491f-9017-cf64536259a7","","",false, this);
 
            Position = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("de5d8204-6a02-4867-b884-0680e3f2aa9d","","",false, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("68b757b6-2bab-495d-846b-89e7316d0c94","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("4b558a56-85d1-4b4f-ae63-88a0b87663b9","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("58e60d30-25f4-4a9e-8277-6eff31573dac","","",false, this);
 
            Email = RPSControlFactory.CreateRPSEmailTextBox<CustomerEntityView>("fe5f26cc-fc99-48aa-b5f0-55da00abea21","","",false, this);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("d4ad5b55-e934-4436-bd53-bfa9ac63ec8f","","",false, this);
 
            CollectionInit params_CustomerContacts = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="dfea1ca1-8181-4450-a9b1-e205054e6c69",CSSSelectorGrid="",XPathGrid=""};
            CustomerContacts = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerContactsCollectionEditor<CustomerEntityView,CustomerDetailView>,CustomerEntityView,CustomerDetailView>( params_CustomerContacts,this,Screen.CustomerDetailView);
 
            CollectionInit params_CustomerDeliveryAddresss = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="014bc503-1a92-4b66-a518-d1ceae1defdd",CSSSelectorGrid="",XPathGrid=""};
            CustomerDeliveryAddresss = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerDeliveryAddresssCollectionEditor<CustomerEntityView,CustomerDetailView>,CustomerEntityView,CustomerDetailView>( params_CustomerDeliveryAddresss,this,Screen.CustomerDetailView);
 
            CollectionInit params_CustomerDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="52eb9e52-979e-4b46-958e-bc94ddcfabf7",CSSSelectorGrid="",XPathGrid=""};
            CustomerDetails = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerDetailsCollectionEditor<CustomerEntityView,CustomerDetailView>,CustomerEntityView,CustomerDetailView>( params_CustomerDetails,this,Screen.CustomerDetailView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<CustomerEntityView>( "","ul li[rpsid='7da4cc98-9128-464f-80d9-4089d4200d50']","",this);
 
            Contact = RPSControlFactory.CreateRPSSection<CustomerEntityView>( "","ul li[rpsid='524b5b1a-a986-414a-a7aa-4daa2b175ea7']","",this);
 
            DeliveryAddress = RPSControlFactory.CreateRPSSection<CustomerEntityView>( "","ul li[rpsid='1c7d4e99-2776-4a4d-8842-85ae86240cc9']","",this);
 
            SubsidiaryCompanies = RPSControlFactory.CreateRPSSection<CustomerEntityView>( "","ul li[rpsid='2191ef6c-0a46-4f7a-a654-a63f49c91a99']","",this);
 

        }
        public IRPSSaveButton<CustomerEntityView> SaveButton { get; set; } 
        public IRPSButton<CustomerEntityView> DeleteButton { get; set; } 
        public IRPSButton<CustomerEntityView,CustomerCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerEntityView,CustomerCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CustomerEntityView> CodCustomer { get; set; } 
        public IRPSTextBox<CustomerEntityView> Description { get; set; } 
        public IRPSTextBox<CustomerEntityView> CompanyName { get; set; } 
        public IRPSTextBox<CustomerEntityView> VATNumber { get; set; } 
        public IRPSComboBox<CustomerEntityView> ThirdType { get; set; } 
        public IRPSTextBox<CustomerEntityView> InactiveDate { get; set; } 
        public IRPSComboBox<CustomerEntityView> CodUser { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDCurrency { get; set; } 
        public IRPSCheckbox<CustomerEntityView> BlockedMaintenance { get; set; } 
        public IRPSTextBox<CustomerEntityView> TextNoticeMaintenance { get; set; } 
        public IRPSComboBox<CustomerEntityView> CodCountry { get; set; } 
        public IRPSTextBox<CustomerEntityView> ZipCode { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDState { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDCounty { get; set; } 
        public IRPSTextBox<CustomerEntityView> Address { get; set; } 
        public IRPSTextBox<CustomerEntityView> City { get; set; } 
        public IRPSTextBox<CustomerEntityView> Position { get; set; } 
        public IRPSTextBox<CustomerEntityView> Phone1 { get; set; } 
        public IRPSTextBox<CustomerEntityView> Phone2 { get; set; } 
        public IRPSTextBox<CustomerEntityView> Fax { get; set; } 
        public IRPSTextBox<CustomerEntityView> Email { get; set; } 
        public IRPSComboBox<CustomerEntityView> CodLanguage { get; set; } 
        public CustomerContactsCollectionEditor<CustomerEntityView,CustomerDetailView> CustomerContacts { get; set; } 
        public CustomerDeliveryAddresssCollectionEditor<CustomerEntityView,CustomerDetailView> CustomerDeliveryAddresss { get; set; } 
        public CustomerDetailsCollectionEditor<CustomerEntityView,CustomerDetailView> CustomerDetails { get; set; } 
        public IRPSSection<CustomerEntityView> GeneralData { get; set; } 
        public IRPSSection<CustomerEntityView> Contact { get; set; } 
        public IRPSSection<CustomerEntityView> DeliveryAddress { get; set; } 
        public IRPSSection<CustomerEntityView> SubsidiaryCompanies { get; set; } 
        public Customer Screen { get; set; }
        public CustomerEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CustomerContactsCollectionEditor<CustomerEntityView,CustomerDetailView>:RPSCollectionEditor<CustomerEntityView,CustomerDetailView> where CustomerEntityView : class, IView where CustomerDetailView : class, IView
    {
        public  CustomerContactsGridView<CustomerEntityView,CustomerDetailView> GridView {get;set;}
    }
    public partial class CustomerContactsGridView <CustomerEntityView,CustomerDetailView> :  RPSGridView<CustomerEntityView,CustomerDetailView> where CustomerEntityView : class, IView where CustomerDetailView : class, IView
    {
        public CustomerContactsGridView(CustomerEntityView currentView,CustomerDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDContactType = RPSControlFactory.CreateRPSGridComboBox<CustomerEntityView>("","#dfea1ca1-8181-4450-a9b1-e205054e6c69 .ag-row[role='row']@ROWINDEX [col-id='cIDContactType']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#dfea1ca1-8181-4450-a9b1-e205054e6c69 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",true, this.CurrentView);
 
            Phone1 = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#dfea1ca1-8181-4450-a9b1-e205054e6c69 .ag-row[role='row']@ROWINDEX [col-id='cPhone1']","",false, this.CurrentView);
 
            Email = RPSControlFactory.CreateRPSGridEmailTextBox<CustomerEntityView>("","#dfea1ca1-8181-4450-a9b1-e205054e6c69 .ag-row[role='row']@ROWINDEX [col-id='cEmail']","",false, this.CurrentView);
 
            Commercial = RPSControlFactory.CreateRPSGridCheckBox<CustomerEntityView>("","#dfea1ca1-8181-4450-a9b1-e205054e6c69 .ag-row[role='row']@ROWINDEX [col-id='cCommercial']","",true, this.CurrentView);
 
            Technical = RPSControlFactory.CreateRPSGridCheckBox<CustomerEntityView>("","#dfea1ca1-8181-4450-a9b1-e205054e6c69 .ag-row[role='row']@ROWINDEX [col-id='cTechnical']","",true, this.CurrentView);
 
            DefaultCommercial = RPSControlFactory.CreateRPSGridCheckBox<CustomerEntityView>("","#dfea1ca1-8181-4450-a9b1-e205054e6c69 .ag-row[role='row']@ROWINDEX [col-id='cDefaultCommercial']","",true, this.CurrentView);
 
            DefaultAdministration = RPSControlFactory.CreateRPSGridCheckBox<CustomerEntityView>("","#dfea1ca1-8181-4450-a9b1-e205054e6c69 .ag-row[role='row']@ROWINDEX [col-id='cDefaultAdministration']","",true, this.CurrentView);
 
            DefaultFinancial = RPSControlFactory.CreateRPSGridCheckBox<CustomerEntityView>("","#dfea1ca1-8181-4450-a9b1-e205054e6c69 .ag-row[role='row']@ROWINDEX [col-id='cDefaultFinancial']","",true, this.CurrentView);
 
            InactiveDate = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#dfea1ca1-8181-4450-a9b1-e205054e6c69 .ag-row[role='row']@ROWINDEX [col-id='cInactiveDate']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<CustomerEntityView> IDContactType { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> Description { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> Phone1 { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> Email { get; set; } 
        public IRPSGridCheckbox<CustomerEntityView> Commercial { get; set; } 
        public IRPSGridCheckbox<CustomerEntityView> Technical { get; set; } 
        public IRPSGridCheckbox<CustomerEntityView> DefaultCommercial { get; set; } 
        public IRPSGridCheckbox<CustomerEntityView> DefaultAdministration { get; set; } 
        public IRPSGridCheckbox<CustomerEntityView> DefaultFinancial { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> InactiveDate { get; set; } 
                     
    }
 
        public partial class CustomerDeliveryAddresssCollectionEditor<CustomerEntityView,CustomerDetailView>:RPSCollectionEditor<CustomerEntityView,CustomerDetailView> where CustomerEntityView : class, IView where CustomerDetailView : class, IView
    {
        public  CustomerDeliveryAddresssGridView<CustomerEntityView,CustomerDetailView> GridView {get;set;}
    }
    public partial class CustomerDeliveryAddresssGridView <CustomerEntityView,CustomerDetailView> :  RPSGridView<CustomerEntityView,CustomerDetailView> where CustomerEntityView : class, IView where CustomerDetailView : class, IView
    {
        public CustomerDeliveryAddresssGridView(CustomerEntityView currentView,CustomerDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodCustomerDeliveryAddress = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#014bc503-1a92-4b66-a518-d1ceae1defdd .ag-row[role='row']@ROWINDEX [col-id='cCodCustomerDeliveryAddress']","",true, this.CurrentView);
 
            DefaultAddress = RPSControlFactory.CreateRPSGridCheckBox<CustomerEntityView>("","#014bc503-1a92-4b66-a518-d1ceae1defdd .ag-row[role='row']@ROWINDEX [col-id='cDefaultAddress']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#014bc503-1a92-4b66-a518-d1ceae1defdd .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            CodCountry = RPSControlFactory.CreateRPSGridComboBox<CustomerEntityView>("","#014bc503-1a92-4b66-a518-d1ceae1defdd .ag-row[role='row']@ROWINDEX [col-id='cCodCountry']","",false, this.CurrentView);
 
            IDState = RPSControlFactory.CreateRPSGridComboBox<CustomerEntityView>("","#014bc503-1a92-4b66-a518-d1ceae1defdd .ag-row[role='row']@ROWINDEX [col-id='cIDState']","",false, this.CurrentView);
 
            IDCounty = RPSControlFactory.CreateRPSGridComboBox<CustomerEntityView>("","#014bc503-1a92-4b66-a518-d1ceae1defdd .ag-row[role='row']@ROWINDEX [col-id='cIDCounty']","",false, this.CurrentView);
 
            Address = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#014bc503-1a92-4b66-a518-d1ceae1defdd .ag-row[role='row']@ROWINDEX [col-id='cAddress']","",false, this.CurrentView);
 
            City = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#014bc503-1a92-4b66-a518-d1ceae1defdd .ag-row[role='row']@ROWINDEX [col-id='cCity']","",false, this.CurrentView);
 
            Phone1 = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#014bc503-1a92-4b66-a518-d1ceae1defdd .ag-row[role='row']@ROWINDEX [col-id='cPhone1']","",false, this.CurrentView);
 
            Email = RPSControlFactory.CreateRPSGridEmailTextBox<CustomerEntityView>("","#014bc503-1a92-4b66-a518-d1ceae1defdd .ag-row[role='row']@ROWINDEX [col-id='cEmail']","",false, this.CurrentView);
 
            ContactPerson = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#014bc503-1a92-4b66-a518-d1ceae1defdd .ag-row[role='row']@ROWINDEX [col-id='cContactPerson']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CustomerEntityView> CodCustomerDeliveryAddress { get; set; } 
        public IRPSGridCheckbox<CustomerEntityView> DefaultAddress { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> Description { get; set; } 
        public IRPSGridComboBox<CustomerEntityView> CodCountry { get; set; } 
        public IRPSGridComboBox<CustomerEntityView> IDState { get; set; } 
        public IRPSGridComboBox<CustomerEntityView> IDCounty { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> Address { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> City { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> Phone1 { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> Email { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> ContactPerson { get; set; } 
                     
    }
 
        public partial class CustomerDetailsCollectionEditor<CustomerEntityView,CustomerDetailView>:RPSCollectionEditor<CustomerEntityView,CustomerDetailView> where CustomerEntityView : class, IView where CustomerDetailView : class, IView
    {
        public  CustomerDetailsGridView<CustomerEntityView,CustomerDetailView> GridView {get;set;}
    }
    public partial class CustomerDetailsGridView <CustomerEntityView,CustomerDetailView> :  RPSGridView<CustomerEntityView,CustomerDetailView> where CustomerEntityView : class, IView where CustomerDetailView : class, IView
    {
        public CustomerDetailsGridView(CustomerEntityView currentView,CustomerDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodCompany = RPSControlFactory.CreateRPSGridComboBox<CustomerEntityView>("","#52eb9e52-979e-4b46-958e-bc94ddcfabf7 .ag-row[role='row']@ROWINDEX [col-id='cCodCompany']","",true, this.CurrentView);
 
            IDCurrency = RPSControlFactory.CreateRPSGridComboBox<CustomerEntityView>("","#52eb9e52-979e-4b46-958e-bc94ddcfabf7 .ag-row[role='row']@ROWINDEX [col-id='cIDCurrency']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<CustomerEntityView> CodCompany { get; set; } 
        public IRPSGridComboBox<CustomerEntityView> IDCurrency { get; set; } 
                     
    }
 
    }
  
            
    public partial class CustomerContactView : View
    {
        public CustomerContactView(Customer screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CustomerContactView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CustomerContactView,CustomerEntityView>( this,Screen.CustomerEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<CustomerContactView,CustomerEntityView>( this,Screen.CustomerEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CustomerContactView,CustomerEntityView>( this,Screen.CustomerEntityView);
 
            InactiveDate = RPSControlFactory.CreateRPSTextBox<CustomerContactView>("7e9658a5-aa91-4f2e-ab93-80218f841d1f","","",false, this);
 
            IDContactType = RPSControlFactory.CreateRPSComboBox<CustomerContactView>("fb8f80a3-32fd-4148-be88-6f340a357f15","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CustomerContactView>("0dc0c8ed-1021-4364-bc49-bd5b715fc14a","","",true, this);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<CustomerContactView>("d9cbd78e-5776-4840-b532-ddb7174e3b9f","","",false, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<CustomerContactView>("5d27b66e-e273-485f-9485-fb71171f1dac","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<CustomerContactView>("7b616373-be76-436c-ab11-26feb65d273a","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<CustomerContactView>("3aad7a71-aa36-42df-9e77-99041d6b4479","","",false, this);
 
            Email = RPSControlFactory.CreateRPSEmailTextBox<CustomerContactView>("9048f905-df1c-4d33-8ff4-c9c75c47dd2d","","",false, this);
 
            Commercial = RPSControlFactory.CreateRPSCheckBox<CustomerContactView>("83fb3c24-5270-4b8a-b56b-f80313b329fc","","",true, this);
 
            Technical = RPSControlFactory.CreateRPSCheckBox<CustomerContactView>("be783356-c5ff-484a-8925-100e068c25fe","","",true, this);
 
            DefaultCommercial = RPSControlFactory.CreateRPSCheckBox<CustomerContactView>("73d939fd-a46a-4d9a-bf0b-c4e700da2023","","",true, this);
 
            DefaultAdministration = RPSControlFactory.CreateRPSCheckBox<CustomerContactView>("6dee4b0f-ed75-4e2f-9482-d7846e23662d","","",true, this);
 
            DefaultFinancial = RPSControlFactory.CreateRPSCheckBox<CustomerContactView>("d722ed60-cc87-449c-be2f-2c859b01df41","","",true, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<CustomerContactView>("a42bb556-5d73-4544-b21d-d61cc44337c8","","",false, this);
 
            GeneralData = RPSControlFactory.CreateRPSSection<CustomerContactView>( "","ul li[rpsid='1331b581-9578-4f55-95c5-ae5b555e70ff']","",this);
 
            CommentSection = RPSControlFactory.CreateRPSSection<CustomerContactView>( "","ul li[rpsid='fb4a6d60-99fc-4535-b71d-622a7575cc16']","",this);
 

        }
        public IRPSButton<CustomerContactView> DeleteButton { get; set; } 
        public IRPSButton<CustomerContactView,CustomerEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerContactView,CustomerEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CustomerContactView,CustomerEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<CustomerContactView> InactiveDate { get; set; } 
        public IRPSComboBox<CustomerContactView> IDContactType { get; set; } 
        public IRPSTextBox<CustomerContactView> Description { get; set; } 
        public IRPSComboBox<CustomerContactView> CodUser { get; set; } 
        public IRPSTextBox<CustomerContactView> Phone1 { get; set; } 
        public IRPSTextBox<CustomerContactView> Phone2 { get; set; } 
        public IRPSTextBox<CustomerContactView> Fax { get; set; } 
        public IRPSTextBox<CustomerContactView> Email { get; set; } 
        public IRPSCheckbox<CustomerContactView> Commercial { get; set; } 
        public IRPSCheckbox<CustomerContactView> Technical { get; set; } 
        public IRPSCheckbox<CustomerContactView> DefaultCommercial { get; set; } 
        public IRPSCheckbox<CustomerContactView> DefaultAdministration { get; set; } 
        public IRPSCheckbox<CustomerContactView> DefaultFinancial { get; set; } 
        public IRPSTextBox<CustomerContactView> Comment { get; set; } 
        public IRPSSection<CustomerContactView> GeneralData { get; set; } 
        public IRPSSection<CustomerContactView> CommentSection { get; set; } 
        public Customer Screen { get; set; }
        public CustomerContactView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CustomerDeliveryAddressView : View
    {
        public CustomerDeliveryAddressView(Customer screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CustomerDeliveryAddressView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CustomerDeliveryAddressView,CustomerEntityView>( this,Screen.CustomerEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<CustomerDeliveryAddressView,CustomerEntityView>( this,Screen.CustomerEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CustomerDeliveryAddressView,CustomerEntityView>( this,Screen.CustomerEntityView);
 
            CodCustomerDeliveryAddress = RPSControlFactory.CreateRPSTextBox<CustomerDeliveryAddressView>("7216e625-0d4f-42a8-b5e2-6522a7d059f7","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CustomerDeliveryAddressView>("1755e912-1e35-4998-8753-e34d93244fa1","","",false, this);
 
            DefaultAddress = RPSControlFactory.CreateRPSCheckBox<CustomerDeliveryAddressView>("c68e8d65-c816-4ada-827c-2bb96a4a7fbe","","",true, this);
 
            ContactPerson = RPSControlFactory.CreateRPSTextBox<CustomerDeliveryAddressView>("3e8b00b3-9fca-4d92-8317-09f33bae10b3","","",false, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<CustomerDeliveryAddressView>("b6783f35-5763-471c-aa31-58ffa47b435c","","",false, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<CustomerDeliveryAddressView>("ca7f79a1-785e-4975-9a76-3210e113b356","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<CustomerDeliveryAddressView>("6050cb87-e4be-433e-bdc4-cec2b2f81964","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<CustomerDeliveryAddressView>("6ce60498-1440-487e-bb7d-357125ded563","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<CustomerDeliveryAddressView>("79c1c94a-f69e-46c4-9663-4466d180fe96","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<CustomerDeliveryAddressView>("e7b9969a-61b2-4a2c-8976-57f01fbf0174","","",false, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<CustomerDeliveryAddressView>("bb7b243d-eac5-490b-8513-9c2de48b27ef","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<CustomerDeliveryAddressView>("20843ef7-fa50-439a-ab08-19874406bafb","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<CustomerDeliveryAddressView>("54cab240-2063-485f-8a0b-27d23b2eda4a","","",false, this);
 
            Email = RPSControlFactory.CreateRPSEmailTextBox<CustomerDeliveryAddressView>("75fe7851-5131-4af9-9f08-079fc5b97858","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<CustomerDeliveryAddressView>("5a2fc959-8bd1-4cc3-96e0-45f71ac94b2c","","",false, this);
 
            GeneralData = RPSControlFactory.CreateRPSSection<CustomerDeliveryAddressView>( "","ul li[rpsid='6371d809-28b1-47eb-b358-3d76db12870a']","",this);
 
            Comment1 = RPSControlFactory.CreateRPSSection<CustomerDeliveryAddressView>( "","ul li[rpsid='f780e33d-f82f-4b34-8f0a-d09b263ad53d']","",this);
 

        }
        public IRPSButton<CustomerDeliveryAddressView> DeleteButton { get; set; } 
        public IRPSButton<CustomerDeliveryAddressView,CustomerEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerDeliveryAddressView,CustomerEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CustomerDeliveryAddressView,CustomerEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<CustomerDeliveryAddressView> CodCustomerDeliveryAddress { get; set; } 
        public IRPSTextBox<CustomerDeliveryAddressView> Description { get; set; } 
        public IRPSCheckbox<CustomerDeliveryAddressView> DefaultAddress { get; set; } 
        public IRPSTextBox<CustomerDeliveryAddressView> ContactPerson { get; set; } 
        public IRPSComboBox<CustomerDeliveryAddressView> CodCountry { get; set; } 
        public IRPSTextBox<CustomerDeliveryAddressView> ZipCode { get; set; } 
        public IRPSComboBox<CustomerDeliveryAddressView> IDState { get; set; } 
        public IRPSComboBox<CustomerDeliveryAddressView> IDCounty { get; set; } 
        public IRPSTextBox<CustomerDeliveryAddressView> Address { get; set; } 
        public IRPSTextBox<CustomerDeliveryAddressView> City { get; set; } 
        public IRPSTextBox<CustomerDeliveryAddressView> Phone1 { get; set; } 
        public IRPSTextBox<CustomerDeliveryAddressView> Phone2 { get; set; } 
        public IRPSTextBox<CustomerDeliveryAddressView> Fax { get; set; } 
        public IRPSTextBox<CustomerDeliveryAddressView> Email { get; set; } 
        public IRPSTextBox<CustomerDeliveryAddressView> Comment { get; set; } 
        public IRPSSection<CustomerDeliveryAddressView> GeneralData { get; set; } 
        public IRPSSection<CustomerDeliveryAddressView> Comment1 { get; set; } 
        public Customer Screen { get; set; }
        public CustomerDeliveryAddressView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CustomerDetailView : View
    {
        public CustomerDetailView(Customer screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CustomerDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CustomerDetailView,CustomerEntityView>( this,Screen.CustomerEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<CustomerDetailView,CustomerEntityView>( this,Screen.CustomerEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CustomerDetailView,CustomerEntityView>( this,Screen.CustomerEntityView);
 
            CodCompany = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("f4fc39f8-e767-4e2a-b9c5-2e1fdb47efe9","","",true, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("59d15ae9-4cfb-4b4f-b657-14e061319139","","",true, this);
 

        }
        public IRPSButton<CustomerDetailView> DeleteButton { get; set; } 
        public IRPSButton<CustomerDetailView,CustomerEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerDetailView,CustomerEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CustomerDetailView,CustomerEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<CustomerDetailView> CodCompany { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDCurrency { get; set; } 
        public Customer Screen { get; set; }
        public CustomerDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}