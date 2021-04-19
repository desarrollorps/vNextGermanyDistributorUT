    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.ReceivablePayable.Customer
{
    //RPS VERSION 1.0.0.0
    public partial class Customer:Screen
    {
        public Customer():base()
        {
            this.URL = "receivablepayable.customer";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CustomerCollectionView  = new CustomerCollectionView(this); 
            CustomerEntityView  = new CustomerEntityView(this); 
            CustomerBankAccountView  = new CustomerBankAccountView(this); 
            CustomerDetailView  = new CustomerDetailView(this); 
            CustomerContactView  = new CustomerContactView(this); 
            CustomerCollectionView.InitializeControls(); 
            CustomerEntityView.InitializeControls(); 
            CustomerBankAccountView.InitializeControls(); 
            CustomerDetailView.InitializeControls(); 
            CustomerContactView.InitializeControls(); 
           
        }
      
            public CustomerCollectionView CustomerCollectionView {get; set; } 
            public CustomerEntityView CustomerEntityView {get; set; } 
            public CustomerBankAccountView CustomerBankAccountView {get; set; } 
            public CustomerDetailView CustomerDetailView {get; set; } 
            public CustomerContactView CustomerContactView {get; set; } 
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
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "cbb55c56-306c-402e-801e-e247f7d1520c",CSSSelectorDescriptor = "",XPathDescriptor = ""};
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
 
            CodCustomer = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("8f71ea4f-8700-4dd4-ae30-f2e40b16cc0c","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("20254b13-9884-439b-ae6b-c870fcfa4a02","","",false, this);
 
            InactiveDate = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("569ef383-2eba-4aba-aa07-592c5b56f01e","","",false, this);
 
            CompanyName = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("78a1af8c-99aa-4e19-a801-b7a06da43be2","","",false, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("860bf8fe-ba9f-4ac7-8b50-8795ee1bcf7a","","",false, this);
 
            ThirdType = RPSControlFactory.CreateRPSEnumComboBox<CustomerEntityView>("d7b78f17-e0c8-480b-a35e-74b4e6caed4f","","",true, this);
 
            Miscellaneous = RPSControlFactory.CreateRPSCheckBox<CustomerEntityView>("c0365ffe-d6a8-489c-b20e-10bcb0e151ff","","",true, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("251f3d3f-a7aa-48c8-acda-c1e9268939b3","","",false, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("ff58985b-63cc-4420-b0ed-cb427e89466f","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("7ed5aef1-3a3c-4c78-804d-e182c6ba34b6","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("2a55b6e3-af65-48e3-9ce1-e5b16c3a2046","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("ef9b47b5-aaac-4cce-8a4c-594dc9580e3a","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("062bb210-7e4e-459a-96bb-f9bb86653879","","",false, this);
 
            Position = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("bc257aec-97c7-4b32-93f1-84dba9547bd9","","",false, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("61d48631-4963-435a-8636-f6afed9ff165","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("45ff7430-cfdb-4d69-a3fe-ea9d5bf63f01","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("961bcdf0-119c-4d87-a3f1-07434b8a03ec","","",false, this);
 
            Email = RPSControlFactory.CreateRPSEmailTextBox<CustomerEntityView>("4a6bb927-3e14-4338-84f8-531f5a7fb5af","","",false, this);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("a632d6e1-518f-449a-bde9-444a1ffcff01","","",false, this);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("523ba222-32e4-4590-bfae-740423909e5e","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("dcff6e57-8bc1-4bb6-8850-7f372d226ec8","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("b0bbedd4-447f-4034-9fdd-2fa5a8c132a6","","",true, this);
 
            CustomerSupplierINFO = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("669721f6-ba6e-4ef1-bc6a-88dab6d02363","","",false, this);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("0a22fabb-121b-4e67-95f1-0a5f7a7ddce5","","",false, this);
 
            IDBankAccountCompany = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("7e1b6914-c8d1-4fb6-867d-7afa6b250433","","",false, this);
 
            IDCashCollector = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("f4a12cb8-dceb-4fe4-9c76-207a3fc42643","","",false, this);
 
            IDThirdAccType = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("8a0bea6b-dadc-4899-8863-2767b1d94de7","","",false, this);
 
            IDCustomerGroup1 = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("f9968935-4373-44e6-a770-41fca8213fa2","","",false, this);
 
            IDCustomerGroup1Value = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("42c5ab20-03b7-4646-9135-9596d6f8bec5","","",false, this);
 
            IDCustomerGroup2 = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("b6d3a0cc-fe31-4c04-8ff8-69b5855283fe","","",false, this);
 
            IDCustomerGroup2Value = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("47307538-c36a-4b59-80f2-f5636ab03439","","",false, this);
 
            IDCustomerGroup3 = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("04c0f14d-fc1a-4c67-a3f7-18ea4f89071f","","",false, this);
 
            IDCustomerGroup3Value = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("f0483ddc-2858-4a50-8062-cb6f9599e61e","","",false, this);
 
            IDCustomerGroup4 = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("b2e67c4e-2b40-454b-a31e-3d48fa5653ea","","",false, this);
 
            IDCustomerGroup4Value = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("dc6f02ac-e3d1-41e0-8c16-aa368061022b","","",false, this);
 
            CollectionInit params_CustomerContacts = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5c1e8f9d-a494-4279-9d94-f380a08a922e",CSSSelectorGrid="",XPathGrid=""};
            CustomerContacts = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerContactsCollectionEditor<CustomerEntityView,CustomerBankAccountView>,CustomerEntityView,CustomerBankAccountView>( params_CustomerContacts,this,Screen.CustomerBankAccountView);
 
            CollectionInit params_CustomerBankAccounts = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1d21ca67-6386-4c0f-9bc2-ff54716966cb",CSSSelectorGrid="",XPathGrid=""};
            CustomerBankAccounts = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerBankAccountsCollectionEditor<CustomerEntityView,CustomerBankAccountView>,CustomerEntityView,CustomerBankAccountView>( params_CustomerBankAccounts,this,Screen.CustomerBankAccountView);
 
            CollectionInit params_CustomerDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="08df6e2c-bdac-4657-b91e-61a24c6cece5",CSSSelectorGrid="",XPathGrid=""};
            CustomerDetails = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerDetailsCollectionEditor<CustomerEntityView,CustomerBankAccountView>,CustomerEntityView,CustomerBankAccountView>( params_CustomerDetails,this,Screen.CustomerBankAccountView);
 
            General = RPSControlFactory.CreateRPSSection<CustomerEntityView>( "","ul li[rpsid='ffbb470a-6bf0-4d45-8441-82cdc67e6a32']","",this);
 
            Financial = RPSControlFactory.CreateRPSSection<CustomerEntityView>( "","ul li[rpsid='99879e72-ce5d-44b6-bb81-81226583f569']","",this);
 
            Section = RPSControlFactory.CreateRPSSection<CustomerEntityView>( "","ul li[rpsid='1ff93546-84b1-452f-8b0a-fcb6d4ba8cef']","",this);
 
            Domiciliation = RPSControlFactory.CreateRPSSection<CustomerEntityView>( "","ul li[rpsid='c93640a1-3938-4c7f-af59-56269699fd7f']","",this);
 
            Subsidiaries = RPSControlFactory.CreateRPSSection<CustomerEntityView>( "","ul li[rpsid='81aff14b-7285-4e97-8955-d934f0fd07e5']","",this);
 

        }
        public IRPSSaveButton<CustomerEntityView> SaveButton { get; set; } 
        public IRPSButton<CustomerEntityView> DeleteButton { get; set; } 
        public IRPSButton<CustomerEntityView,CustomerCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerEntityView,CustomerCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CustomerEntityView> CodCustomer { get; set; } 
        public IRPSTextBox<CustomerEntityView> Description { get; set; } 
        public IRPSTextBox<CustomerEntityView> InactiveDate { get; set; } 
        public IRPSTextBox<CustomerEntityView> CompanyName { get; set; } 
        public IRPSTextBox<CustomerEntityView> VATNumber { get; set; } 
        public IRPSComboBox<CustomerEntityView> ThirdType { get; set; } 
        public IRPSCheckbox<CustomerEntityView> Miscellaneous { get; set; } 
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
        public IRPSComboBox<CustomerEntityView> CodUser { get; set; } 
        public IRPSComboBox<CustomerEntityView> CodLanguage { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDSupplier { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDCurrency { get; set; } 
        public IRPSTextBox<CustomerEntityView> CustomerSupplierINFO { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDPaymentMethod { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDBankAccountCompany { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDCashCollector { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDThirdAccType { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDCustomerGroup1 { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDCustomerGroup1Value { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDCustomerGroup2 { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDCustomerGroup2Value { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDCustomerGroup3 { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDCustomerGroup3Value { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDCustomerGroup4 { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDCustomerGroup4Value { get; set; } 
        public CustomerContactsCollectionEditor<CustomerEntityView,CustomerBankAccountView> CustomerContacts { get; set; } 
        public CustomerBankAccountsCollectionEditor<CustomerEntityView,CustomerBankAccountView> CustomerBankAccounts { get; set; } 
        public CustomerDetailsCollectionEditor<CustomerEntityView,CustomerBankAccountView> CustomerDetails { get; set; } 
        public IRPSSection<CustomerEntityView> General { get; set; } 
        public IRPSSection<CustomerEntityView> Financial { get; set; } 
        public IRPSSection<CustomerEntityView> Section { get; set; } 
        public IRPSSection<CustomerEntityView> Domiciliation { get; set; } 
        public IRPSSection<CustomerEntityView> Subsidiaries { get; set; } 
        public Customer Screen { get; set; }
        public CustomerEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CustomerContactsCollectionEditor<CustomerEntityView,CustomerBankAccountView>:RPSCollectionEditor<CustomerEntityView,CustomerBankAccountView> where CustomerEntityView : class, IView where CustomerBankAccountView : class, IView
    {
        public  CustomerContactsGridView<CustomerEntityView,CustomerBankAccountView> GridView {get;set;}
    }
    public partial class CustomerContactsGridView <CustomerEntityView,CustomerBankAccountView> :  RPSGridView<CustomerEntityView,CustomerBankAccountView> where CustomerEntityView : class, IView where CustomerBankAccountView : class, IView
    {
        public CustomerContactsGridView(CustomerEntityView currentView,CustomerBankAccountView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDContactType = RPSControlFactory.CreateRPSGridComboBox<CustomerEntityView>("","#5c1e8f9d-a494-4279-9d94-f380a08a922e .ag-row[role='row']@ROWINDEX [col-id='cIDContactType']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#5c1e8f9d-a494-4279-9d94-f380a08a922e .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",true, this.CurrentView);
 
            Commercial = RPSControlFactory.CreateRPSGridCheckBox<CustomerEntityView>("","#5c1e8f9d-a494-4279-9d94-f380a08a922e .ag-row[role='row']@ROWINDEX [col-id='cCommercial']","",true, this.CurrentView);
 
            DefaultCommercial = RPSControlFactory.CreateRPSGridCheckBox<CustomerEntityView>("","#5c1e8f9d-a494-4279-9d94-f380a08a922e .ag-row[role='row']@ROWINDEX [col-id='cDefaultCommercial']","",true, this.CurrentView);
 
            DefaultAdministration = RPSControlFactory.CreateRPSGridCheckBox<CustomerEntityView>("","#5c1e8f9d-a494-4279-9d94-f380a08a922e .ag-row[role='row']@ROWINDEX [col-id='cDefaultAdministration']","",true, this.CurrentView);
 
            DefaultFinancial = RPSControlFactory.CreateRPSGridCheckBox<CustomerEntityView>("","#5c1e8f9d-a494-4279-9d94-f380a08a922e .ag-row[role='row']@ROWINDEX [col-id='cDefaultFinancial']","",true, this.CurrentView);
 
            Technical = RPSControlFactory.CreateRPSGridCheckBox<CustomerEntityView>("","#5c1e8f9d-a494-4279-9d94-f380a08a922e .ag-row[role='row']@ROWINDEX [col-id='cTechnical']","",true, this.CurrentView);
 
            Phone1 = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#5c1e8f9d-a494-4279-9d94-f380a08a922e .ag-row[role='row']@ROWINDEX [col-id='cPhone1']","",false, this.CurrentView);
 
            CodUser = RPSControlFactory.CreateRPSGridComboBox<CustomerEntityView>("","#5c1e8f9d-a494-4279-9d94-f380a08a922e .ag-row[role='row']@ROWINDEX [col-id='cCodUser']","",false, this.CurrentView);
 
            Email = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#5c1e8f9d-a494-4279-9d94-f380a08a922e .ag-row[role='row']@ROWINDEX [col-id='cEmail']","",false, this.CurrentView);
 
            InactiveDate = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#5c1e8f9d-a494-4279-9d94-f380a08a922e .ag-row[role='row']@ROWINDEX [col-id='cInactiveDate']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<CustomerEntityView> IDContactType { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> Description { get; set; } 
        public IRPSGridCheckbox<CustomerEntityView> Commercial { get; set; } 
        public IRPSGridCheckbox<CustomerEntityView> DefaultCommercial { get; set; } 
        public IRPSGridCheckbox<CustomerEntityView> DefaultAdministration { get; set; } 
        public IRPSGridCheckbox<CustomerEntityView> DefaultFinancial { get; set; } 
        public IRPSGridCheckbox<CustomerEntityView> Technical { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> Phone1 { get; set; } 
        public IRPSGridComboBox<CustomerEntityView> CodUser { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> Email { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> InactiveDate { get; set; } 
                     
    }
 
        public partial class CustomerBankAccountsCollectionEditor<CustomerEntityView,CustomerBankAccountView>:RPSCollectionEditor<CustomerEntityView,CustomerBankAccountView> where CustomerEntityView : class, IView where CustomerBankAccountView : class, IView
    {
        public  CustomerBankAccountsGridView<CustomerEntityView,CustomerBankAccountView> GridView {get;set;}
    }
    public partial class CustomerBankAccountsGridView <CustomerEntityView,CustomerBankAccountView> :  RPSGridView<CustomerEntityView,CustomerBankAccountView> where CustomerEntityView : class, IView where CustomerBankAccountView : class, IView
    {
        public CustomerBankAccountsGridView(CustomerEntityView currentView,CustomerBankAccountView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodCustomerBankAccount = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#1d21ca67-6386-4c0f-9bc2-ff54716966cb .ag-row[role='row']@ROWINDEX [col-id='cCodCustomerBankAccount']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#1d21ca67-6386-4c0f-9bc2-ff54716966cb .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            IBAN = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#1d21ca67-6386-4c0f-9bc2-ff54716966cb .ag-row[role='row']@ROWINDEX [col-id='cIBAN']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CustomerEntityView> CodCustomerBankAccount { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> Description { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> IBAN { get; set; } 
                     
    }
 
        public partial class CustomerDetailsCollectionEditor<CustomerEntityView,CustomerBankAccountView>:RPSCollectionEditor<CustomerEntityView,CustomerBankAccountView> where CustomerEntityView : class, IView where CustomerBankAccountView : class, IView
    {
        public  CustomerDetailsGridView<CustomerEntityView,CustomerBankAccountView> GridView {get;set;}
    }
    public partial class CustomerDetailsGridView <CustomerEntityView,CustomerBankAccountView> :  RPSGridView<CustomerEntityView,CustomerBankAccountView> where CustomerEntityView : class, IView where CustomerBankAccountView : class, IView
    {
        public CustomerDetailsGridView(CustomerEntityView currentView,CustomerBankAccountView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodCompany = RPSControlFactory.CreateRPSGridComboBox<CustomerEntityView>("","#08df6e2c-bdac-4657-b91e-61a24c6cece5 .ag-row[role='row']@ROWINDEX [col-id='cCodCompany']","",true, this.CurrentView);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSGridComboBox<CustomerEntityView>("","#08df6e2c-bdac-4657-b91e-61a24c6cece5 .ag-row[role='row']@ROWINDEX [col-id='cIDPaymentMethod']","",false, this.CurrentView);
 
            IDCurrency = RPSControlFactory.CreateRPSGridComboBox<CustomerEntityView>("","#08df6e2c-bdac-4657-b91e-61a24c6cece5 .ag-row[role='row']@ROWINDEX [col-id='cIDCurrency']","",true, this.CurrentView);
 
            IDCashCollector = RPSControlFactory.CreateRPSGridComboBox<CustomerEntityView>("","#08df6e2c-bdac-4657-b91e-61a24c6cece5 .ag-row[role='row']@ROWINDEX [col-id='cIDCashCollector']","",false, this.CurrentView);
 
            IDBankAccountCompany = RPSControlFactory.CreateRPSGridComboBox<CustomerEntityView>("","#08df6e2c-bdac-4657-b91e-61a24c6cece5 .ag-row[role='row']@ROWINDEX [col-id='cIDBankAccountCompany']","",false, this.CurrentView);
 
            IDThirdAccType = RPSControlFactory.CreateRPSGridComboBox<CustomerEntityView>("","#08df6e2c-bdac-4657-b91e-61a24c6cece5 .ag-row[role='row']@ROWINDEX [col-id='cIDThirdAccType']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<CustomerEntityView> CodCompany { get; set; } 
        public IRPSGridComboBox<CustomerEntityView> IDPaymentMethod { get; set; } 
        public IRPSGridComboBox<CustomerEntityView> IDCurrency { get; set; } 
        public IRPSGridComboBox<CustomerEntityView> IDCashCollector { get; set; } 
        public IRPSGridComboBox<CustomerEntityView> IDBankAccountCompany { get; set; } 
        public IRPSGridComboBox<CustomerEntityView> IDThirdAccType { get; set; } 
                     
    }
 
    }
  
            
    public partial class CustomerBankAccountView : View
    {
        public CustomerBankAccountView(Customer screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CustomerBankAccountView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CustomerBankAccountView,CustomerEntityView>( this,Screen.CustomerEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<CustomerBankAccountView,CustomerEntityView>( this,Screen.CustomerEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CustomerBankAccountView,CustomerEntityView>( this,Screen.CustomerEntityView);
 
            CodCustomerBankAccount = RPSControlFactory.CreateRPSTextBox<CustomerBankAccountView>("8931a9c6-bc9e-45f2-856f-a1248f60e15a","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CustomerBankAccountView>("24ee1b99-ad19-4b40-b565-027dec58e479","","",false, this);
 
            CodBank = RPSControlFactory.CreateRPSComboBox<CustomerBankAccountView>("e248d2cc-4b53-4cb9-8075-22318f34f6ad","","",false, this);
 
            CodBankBranch = RPSControlFactory.CreateRPSEnumComboBox<CustomerBankAccountView>("f12b022a-bb96-44e3-bb54-69f11a3cda12","","",false, this);
 
            DigitControl = RPSControlFactory.CreateRPSTextBox<CustomerBankAccountView>("47db0519-777c-43ad-ac09-5b034898f20d","","",false, this);
 
            BankAccount = RPSControlFactory.CreateRPSTextBox<CustomerBankAccountView>("d4c31b80-241e-4af7-a5ba-f944e8a37b29","","",false, this);
 
            BankAccNumber = RPSControlFactory.CreateRPSTextBox<CustomerBankAccountView>("fabde1a6-b05f-4a26-8083-1a48e49640d0","","",false, this);
 
            IBAN = RPSControlFactory.CreateRPSTextBox<CustomerBankAccountView>("1b4f2285-f286-45be-8254-a837151e9c2b","","",false, this);
 
            SWIFTCode = RPSControlFactory.CreateRPSTextBox<CustomerBankAccountView>("eb0f04d0-be3e-40cf-a6bc-1aba77e90a80","","",false, this);
 
            Default = RPSControlFactory.CreateRPSCheckBox<CustomerBankAccountView>("24348e93-222c-470f-8cca-d7b1c22b8c32","","",true, this);
 
            TypeBankAcc = RPSControlFactory.CreateRPSEnumComboBox<CustomerBankAccountView>("b16076b2-8b72-49c8-86c1-7cb1758b5726","","",true, this);
 

        }
        public IRPSButton<CustomerBankAccountView> DeleteButton { get; set; } 
        public IRPSButton<CustomerBankAccountView,CustomerEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerBankAccountView,CustomerEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CustomerBankAccountView,CustomerEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<CustomerBankAccountView> CodCustomerBankAccount { get; set; } 
        public IRPSTextBox<CustomerBankAccountView> Description { get; set; } 
        public IRPSComboBox<CustomerBankAccountView> CodBank { get; set; } 
        public IRPSComboBox<CustomerBankAccountView> CodBankBranch { get; set; } 
        public IRPSTextBox<CustomerBankAccountView> DigitControl { get; set; } 
        public IRPSTextBox<CustomerBankAccountView> BankAccount { get; set; } 
        public IRPSTextBox<CustomerBankAccountView> BankAccNumber { get; set; } 
        public IRPSTextBox<CustomerBankAccountView> IBAN { get; set; } 
        public IRPSTextBox<CustomerBankAccountView> SWIFTCode { get; set; } 
        public IRPSCheckbox<CustomerBankAccountView> Default { get; set; } 
        public IRPSComboBox<CustomerBankAccountView> TypeBankAcc { get; set; } 
        public Customer Screen { get; set; }
        public CustomerBankAccountView Wait(int seconds)
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
 
            CodCompany = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("fdb42ceb-fd19-427e-8f00-4031a6e77762","","",true, this);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("5e894f43-e5b4-4e64-890a-8f583e3b1819","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("e195627f-ddfd-4215-80bc-a64c50f23df8","","",true, this);
 
            IDCashCollector = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("245748c4-4bbe-4e13-b15e-d38781cb11e1","","",false, this);
 
            IDBankAccountCompany = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("b98c1386-df8f-4081-8c20-7c0edad78bf9","","",false, this);
 
            IDThirdAccType = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("bb830cb7-9796-4f3a-938f-919d7e1b9a13","","",false, this);
 

        }
        public IRPSButton<CustomerDetailView> DeleteButton { get; set; } 
        public IRPSButton<CustomerDetailView,CustomerEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerDetailView,CustomerEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CustomerDetailView,CustomerEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<CustomerDetailView> CodCompany { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDPaymentMethod { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDCurrency { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDCashCollector { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDBankAccountCompany { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDThirdAccType { get; set; } 
        public Customer Screen { get; set; }
        public CustomerDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
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
 
            IDContactType = RPSControlFactory.CreateRPSComboBox<CustomerContactView>("98029fdf-7817-44cf-ac7d-7d96299febbc","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CustomerContactView>("94f71f96-2e6c-442f-9eb5-be1387c8c5fe","","",true, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<CustomerContactView>("b35a6c9a-2d8e-4136-82a3-d053058f6853","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<CustomerContactView>("c02b984f-c0ed-45e5-9662-18f9c09ebc12","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<CustomerContactView>("f7a47661-7365-40a7-bab0-b3abfb5b4bde","","",false, this);
 
            Email = RPSControlFactory.CreateRPSTextBox<CustomerContactView>("9b8f00db-738f-4a9d-97ab-73bc8d999d1a","","",false, this);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<CustomerContactView>("a5dd3e40-8ab4-432a-ac3c-933165a69300","","",false, this);
 
            InactiveDate = RPSControlFactory.CreateRPSTextBox<CustomerContactView>("64379f8a-e061-4d85-b8a7-92ad263ca461","","",false, this);
 
            Commercial = RPSControlFactory.CreateRPSCheckBox<CustomerContactView>("c2da67d2-b7ec-4e65-989a-75b4c36dc145","","",true, this);
 
            DefaultCommercial = RPSControlFactory.CreateRPSCheckBox<CustomerContactView>("cfbbbcff-988b-41a8-8227-cf3efbb7c9bf","","",true, this);
 
            DefaultAdministration = RPSControlFactory.CreateRPSCheckBox<CustomerContactView>("a47b1a41-f5ab-4a3c-bd6e-c1dbd7d3aa79","","",true, this);
 
            DefaultFinancial = RPSControlFactory.CreateRPSCheckBox<CustomerContactView>("760d7de9-7c23-4cae-9fd4-7034850569b9","","",true, this);
 
            Technical = RPSControlFactory.CreateRPSCheckBox<CustomerContactView>("5a95cf3f-8cef-405e-b946-e3b59c9e8c26","","",true, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<CustomerContactView>("0aacc63d-a61e-46a7-934c-494c2d848520","","",false, this);
 
            Section = RPSControlFactory.CreateRPSSection<CustomerContactView>( "","ul li[rpsid='29b9e7a2-af99-455e-b1bf-0b59a0917c07']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<CustomerContactView>( "","ul li[rpsid='4cf53376-04aa-4808-827d-96ec00ea880e']","",this);
 

        }
        public IRPSButton<CustomerContactView> DeleteButton { get; set; } 
        public IRPSButton<CustomerContactView,CustomerEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerContactView,CustomerEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CustomerContactView,CustomerEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<CustomerContactView> IDContactType { get; set; } 
        public IRPSTextBox<CustomerContactView> Description { get; set; } 
        public IRPSTextBox<CustomerContactView> Phone1 { get; set; } 
        public IRPSTextBox<CustomerContactView> Phone2 { get; set; } 
        public IRPSTextBox<CustomerContactView> Fax { get; set; } 
        public IRPSTextBox<CustomerContactView> Email { get; set; } 
        public IRPSComboBox<CustomerContactView> CodUser { get; set; } 
        public IRPSTextBox<CustomerContactView> InactiveDate { get; set; } 
        public IRPSCheckbox<CustomerContactView> Commercial { get; set; } 
        public IRPSCheckbox<CustomerContactView> DefaultCommercial { get; set; } 
        public IRPSCheckbox<CustomerContactView> DefaultAdministration { get; set; } 
        public IRPSCheckbox<CustomerContactView> DefaultFinancial { get; set; } 
        public IRPSCheckbox<CustomerContactView> Technical { get; set; } 
        public IRPSTextBox<CustomerContactView> Comment { get; set; } 
        public IRPSSection<CustomerContactView> Section { get; set; } 
        public IRPSSection<CustomerContactView> Section1 { get; set; } 
        public Customer Screen { get; set; }
        public CustomerContactView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}