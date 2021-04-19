    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.Customer
{
    //RPS VERSION 1.0.0.0
    public partial class Customer:Screen
    {
        public Customer():base()
        {
            this.URL = "project.customer";
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
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "946097fd-0648-46a4-b6e2-145103340ee7",CSSSelectorDescriptor = "",XPathDescriptor = ""};
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
 
            CodCustomer = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("dbc0a050-2fc1-4feb-a3ed-a06a130666ea","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("093ea181-7e33-48ed-bb7a-bf4c6288e18c","","",false, this);
 
            CompanyName = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("ece87d8b-eb36-427e-b48b-0ff1891bbc1a","","",false, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("d376a49d-834f-4df1-9a04-a8ee9cab44a8","","",false, this);
 
            ThirdType = RPSControlFactory.CreateRPSEnumComboBox<CustomerEntityView>("e2bec011-50d6-4a32-8365-4b34a49004d2","","",true, this);
 
            InactiveDate = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("0da82888-d0a5-471a-90c9-1fd89af21498","","",false, this);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("f5806322-3a1f-412a-8ab1-e03ce86b1f57","","",false, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("976d0e62-7a3b-49d6-a282-4ec20408cad6","","",false, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("922fd1dc-484f-4fe2-83d6-0f9719792e1b","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("a5e452eb-4f1c-40a3-9254-7433819866ca","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("778f44b1-2437-45ca-b5e3-842562784c5e","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("dd12de2b-8faa-4b80-b5f8-d114af80c7b3","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("0aa7774e-6213-4d7d-b01b-c2b207fae8fe","","",false, this);
 
            Position = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("a3df2221-9bd4-4bfc-b67b-3f7b3ed6e8cb","","",false, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("4cf35abd-07e7-487b-a174-e16a89d9d234","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("d3c1d71f-e084-48e3-bddb-6b7e8c178b75","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("05bf2382-c5e9-4c1a-9e9f-9f8e7ea4d5c5","","",false, this);
 
            Email = RPSControlFactory.CreateRPSEmailTextBox<CustomerEntityView>("e1c76cc9-92f2-404e-bfd4-f86073162849","","",false, this);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("d8f090a2-c87c-45a4-82ba-e6a951430a63","","",false, this);
 
            CollectionInit params_CustomerDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="073309dc-e260-41cd-a82a-b68014c5707e",CSSSelectorGrid="",XPathGrid=""};
            CustomerDetails = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerDetailsCollectionEditor<CustomerEntityView,CustomerDetailView>,CustomerEntityView,CustomerDetailView>( params_CustomerDetails,this,Screen.CustomerDetailView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<CustomerEntityView>( "","ul li[rpsid='97c287e4-b623-4500-9b4c-be80f4c4b52d']","",this);
 
            SubsidiaryCompanies = RPSControlFactory.CreateRPSSection<CustomerEntityView>( "","ul li[rpsid='f82b4afc-1a7a-48d4-9062-ad3f55bb0967']","",this);
 

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
            CodCompany = RPSControlFactory.CreateRPSGridComboBox<CustomerEntityView>("","#073309dc-e260-41cd-a82a-b68014c5707e .ag-row[role='row']@ROWINDEX [col-id='cCodCompany']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<CustomerEntityView> CodCompany { get; set; } 
                     
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
 
            CodCompany = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("de33295e-1c96-4f25-9080-599fac336975","","",true, this);
 

        }
        public IRPSButton<CustomerDetailView> DeleteButton { get; set; } 
        public IRPSButton<CustomerDetailView,CustomerEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerDetailView,CustomerEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CustomerDetailView,CustomerEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<CustomerDetailView> CodCompany { get; set; } 
        public Customer Screen { get; set; }
        public CustomerDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}