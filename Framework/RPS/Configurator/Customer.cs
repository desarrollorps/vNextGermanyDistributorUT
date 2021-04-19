    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Configurator.Customer
{
    //RPS VERSION 1.0.0.0
    public partial class Customer:Screen
    {
        public Customer():base()
        {
            this.URL = "configurator.customer";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CustomerCollectionView  = new CustomerCollectionView(this); 
            CustomerEntityView  = new CustomerEntityView(this); 
            CustomerDetailView  = new CustomerDetailView(this); 
            CustomerCollectionView.InitializeControls(); 
            CustomerEntityView.InitializeControls(); 
            CustomerDetailView.InitializeControls(); 
           
        }
      
            public CustomerCollectionView CustomerCollectionView {get; set; } 
            public CustomerEntityView CustomerEntityView {get; set; } 
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
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "bfd0cfc3-95c1-4831-ac70-eafc07c77716",CSSSelectorDescriptor = "",XPathDescriptor = ""};
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
 
            CodCustomer = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("036bb5f5-2e3c-411f-a36a-1cefe92dddec","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("abd92bb6-641d-4340-9e29-4993c8d694d1","","",false, this);
 
            CompanyName = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("55b6e67c-222c-4a05-8d2b-cf1400bbae55","","",false, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("1c8d0084-293f-46df-9ddb-103700f1fa1d","","",false, this);
 
            ThirdType = RPSControlFactory.CreateRPSEnumComboBox<CustomerEntityView>("9b92c4bb-18c3-4036-8964-d75e43cc57e6","","",true, this);
 
            InactiveDate = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("d8fac8ee-7506-4ba6-ad0d-8a047e2022d8","","",false, this);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("ffe01d11-76e3-43a1-8e03-fb5db2802c45","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("cc309b4f-8eff-4be9-8a7a-eb3265199f0c","","",true, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("1faeea36-f2dd-4b66-b2f7-3b5b990712a1","","",false, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("088c7ee3-9119-480f-a4f7-3faa2e13cf7d","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("9938078c-cc52-45a3-ad00-356639b2b4e6","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("9c1e7e4c-8478-481a-a536-4ba8f414aa92","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("2160db34-e4b9-486a-8bc8-89cc504a028b","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("fb4770ff-f64c-4391-b0ec-eb4e454187f6","","",false, this);
 
            Position = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("14380773-229b-4977-84fe-76efe0d790dc","","",false, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("0a2b5645-8b58-4211-8273-063c3e2bd4de","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("e74464c9-e994-4a12-82b0-e3d3b8d5ab34","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("7d83f982-9c8c-4346-b131-40b2eab570bc","","",false, this);
 
            Email = RPSControlFactory.CreateRPSEmailTextBox<CustomerEntityView>("6ad278c5-97df-41fa-b91a-90e49ec06fdc","","",false, this);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("4d527121-3287-496e-a7c6-8f9ddeb213f7","","",false, this);
 
            CollectionInit params_CustomerDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7f862f6d-dfe3-4213-9314-afb5423717b2",CSSSelectorGrid="",XPathGrid=""};
            CustomerDetails = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerDetailsCollectionEditor<CustomerEntityView,CustomerDetailView>,CustomerEntityView,CustomerDetailView>( params_CustomerDetails,this,Screen.CustomerDetailView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<CustomerEntityView>( "","ul li[rpsid='19f9fc83-ff66-4a05-bfe4-43ee3b61c2a3']","",this);
 
            SubsidiaryCompanies = RPSControlFactory.CreateRPSSection<CustomerEntityView>( "","ul li[rpsid='558df172-6212-4bf8-8d6e-ec9ca1ea95be']","",this);
 

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
        public CustomerDetailsCollectionEditor<CustomerEntityView,CustomerDetailView> CustomerDetails { get; set; } 
        public IRPSSection<CustomerEntityView> GeneralData { get; set; } 
        public IRPSSection<CustomerEntityView> SubsidiaryCompanies { get; set; } 
        public Customer Screen { get; set; }
        public CustomerEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
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
            CodCompany = RPSControlFactory.CreateRPSGridComboBox<CustomerEntityView>("","#7f862f6d-dfe3-4213-9314-afb5423717b2 .ag-row[role='row']@ROWINDEX [col-id='cCodCompany']","",true, this.CurrentView);
 
            IDCurrency = RPSControlFactory.CreateRPSGridComboBox<CustomerEntityView>("","#7f862f6d-dfe3-4213-9314-afb5423717b2 .ag-row[role='row']@ROWINDEX [col-id='cIDCurrency']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<CustomerEntityView> CodCompany { get; set; } 
        public IRPSGridComboBox<CustomerEntityView> IDCurrency { get; set; } 
                     
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
 
            CodCompany = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("0cd7f06f-6e25-4aab-bdac-b67fa086f297","","",true, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("5a2b32cc-5563-4f97-a5e0-fd445e5defc7","","",true, this);
 

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