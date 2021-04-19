    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.Customer
{
    //RPS VERSION 1.0.0.0
    public partial class Customer:Screen
    {
        public Customer():base()
        {
            this.URL = "quality.customer";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CustomerCollectionView  = new CustomerCollectionView(this); 
            CustomerEntityView  = new CustomerEntityView(this); 
            CustomerContactView  = new CustomerContactView(this); 
            CustomerDetailView  = new CustomerDetailView(this); 
            CustomerArticleView  = new CustomerArticleView(this); 
            CustomerCollectionView.InitializeControls(); 
            CustomerEntityView.InitializeControls(); 
            CustomerContactView.InitializeControls(); 
            CustomerDetailView.InitializeControls(); 
            CustomerArticleView.InitializeControls(); 
           
        }
      
            public CustomerCollectionView CustomerCollectionView {get; set; } 
            public CustomerEntityView CustomerEntityView {get; set; } 
            public CustomerContactView CustomerContactView {get; set; } 
            public CustomerDetailView CustomerDetailView {get; set; } 
            public CustomerArticleView CustomerArticleView {get; set; } 
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
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "9748290e-d8e1-4e38-8bed-06ae1c35fd66",CSSSelectorDescriptor = "",XPathDescriptor = ""};
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
 
            CodCustomer = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("631c4fe7-fed3-4cf4-9502-8a36654c5991","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("ac57b710-644a-4989-8708-0c2657336014","","",false, this);
 
            CompanyName = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("460a447d-1860-4d07-ab2e-26aefe6e4084","","",false, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("cfed79e8-a703-434b-89bd-b26437025365","","",false, this);
 
            ThirdType = RPSControlFactory.CreateRPSEnumComboBox<CustomerEntityView>("ec812007-a8e8-4c36-9c7d-1e19d6deaf57","","",true, this);
 
            InactiveDate = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("77474bba-3ab1-4036-81a7-a27cd0a8a78d","","",false, this);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("5f9499af-f7f6-414b-acb3-357ae808cd00","","",false, this);
 
            RpnMax = RPSControlFactory.CreateRPSFormattedTextBox<CustomerEntityView>("247ddd42-651e-4cf5-a139-be418774940d","","",false, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("46f0d635-353d-4ab2-a477-ca683a0386fe","","",false, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("f615c700-c881-40c4-8336-24af6072a495","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("ed6ce49b-d8af-43cf-a468-f0a20cca854c","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("03b56c07-c151-4278-9714-8a64eff3df9a","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("ef67ed49-3026-40f6-bd3b-797fb43db2ff","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("defb62f3-7609-4f62-998d-d708c977c340","","",false, this);
 
            Position = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("198770f3-5447-4d91-aa82-73b647358176","","",false, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("baac8810-c41b-4cb4-8889-b3c44d6abbf3","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("bcb52c4d-e698-4216-b641-c160b8ce2890","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("30059d75-f1a9-4aca-b23c-38c69c51d6f4","","",false, this);
 
            Email = RPSControlFactory.CreateRPSEmailTextBox<CustomerEntityView>("ebcdbcda-68f1-4723-ae8d-50c1ec1305ac","","",false, this);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("993c327c-7552-4ef9-86fc-5d217b39c523","","",false, this);
 
            CollectionInit params_CustomerContacts = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="094d4ffe-736a-4d71-8d15-34814514c421",CSSSelectorGrid="",XPathGrid=""};
            CustomerContacts = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerContactsCollectionEditor<CustomerEntityView,CustomerDetailView>,CustomerEntityView,CustomerDetailView>( params_CustomerContacts,this,Screen.CustomerDetailView);
 
            CollectionInit params_CustomerArticles = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c00f0502-f808-4196-839a-0433c879129e",CSSSelectorGrid="",XPathGrid=""};
            CustomerArticles = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerArticlesCollectionEditor<CustomerEntityView,CustomerDetailView>,CustomerEntityView,CustomerDetailView>( params_CustomerArticles,this,Screen.CustomerDetailView);
 
            CollectionInit params_CustomerDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="869e8db8-d437-4e04-9777-20ee74811c6c",CSSSelectorGrid="",XPathGrid=""};
            CustomerDetails = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerDetailsCollectionEditor<CustomerEntityView,CustomerDetailView>,CustomerEntityView,CustomerDetailView>( params_CustomerDetails,this,Screen.CustomerDetailView);
 
            GeneralSection = RPSControlFactory.CreateRPSSection<CustomerEntityView>( "","ul li[rpsid='ef60c38e-e6ba-4fec-9a80-d67fe7ab68c9']","",this);
 
            CustomerContactSection = RPSControlFactory.CreateRPSSection<CustomerEntityView>( "","ul li[rpsid='d2f1dbc8-f021-4158-8cf8-c9bdda915769']","",this);
 
            CustomerArticleSection = RPSControlFactory.CreateRPSSection<CustomerEntityView>( "","ul li[rpsid='aaab4577-f7d4-4c03-8922-fd420f6decdb']","",this);
 
            SubsidiariesSection = RPSControlFactory.CreateRPSSection<CustomerEntityView>( "","ul li[rpsid='7f2c1b96-143d-49e0-84a7-e50b258f44a7']","",this);
 

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
        public IRPSTextBox<CustomerEntityView> RpnMax { get; set; } 
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
        public CustomerArticlesCollectionEditor<CustomerEntityView,CustomerDetailView> CustomerArticles { get; set; } 
        public CustomerDetailsCollectionEditor<CustomerEntityView,CustomerDetailView> CustomerDetails { get; set; } 
        public IRPSSection<CustomerEntityView> GeneralSection { get; set; } 
        public IRPSSection<CustomerEntityView> CustomerContactSection { get; set; } 
        public IRPSSection<CustomerEntityView> CustomerArticleSection { get; set; } 
        public IRPSSection<CustomerEntityView> SubsidiariesSection { get; set; } 
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
            IDContactType = RPSControlFactory.CreateRPSGridComboBox<CustomerEntityView>("","#094d4ffe-736a-4d71-8d15-34814514c421 .ag-row[role='row']@ROWINDEX [col-id='cIDContactType']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#094d4ffe-736a-4d71-8d15-34814514c421 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",true, this.CurrentView);
 
            Commercial = RPSControlFactory.CreateRPSGridCheckBox<CustomerEntityView>("","#094d4ffe-736a-4d71-8d15-34814514c421 .ag-row[role='row']@ROWINDEX [col-id='cCommercial']","",true, this.CurrentView);
 
            Technical = RPSControlFactory.CreateRPSGridCheckBox<CustomerEntityView>("","#094d4ffe-736a-4d71-8d15-34814514c421 .ag-row[role='row']@ROWINDEX [col-id='cTechnical']","",true, this.CurrentView);
 
            DefaultCommercial = RPSControlFactory.CreateRPSGridCheckBox<CustomerEntityView>("","#094d4ffe-736a-4d71-8d15-34814514c421 .ag-row[role='row']@ROWINDEX [col-id='cDefaultCommercial']","",true, this.CurrentView);
 
            DefaultAdministration = RPSControlFactory.CreateRPSGridCheckBox<CustomerEntityView>("","#094d4ffe-736a-4d71-8d15-34814514c421 .ag-row[role='row']@ROWINDEX [col-id='cDefaultAdministration']","",true, this.CurrentView);
 
            DefaultFinancial = RPSControlFactory.CreateRPSGridCheckBox<CustomerEntityView>("","#094d4ffe-736a-4d71-8d15-34814514c421 .ag-row[role='row']@ROWINDEX [col-id='cDefaultFinancial']","",false, this.CurrentView);
 
            Phone1 = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#094d4ffe-736a-4d71-8d15-34814514c421 .ag-row[role='row']@ROWINDEX [col-id='cPhone1']","",false, this.CurrentView);
 
            Email = RPSControlFactory.CreateRPSGridEmailTextBox<CustomerEntityView>("","#094d4ffe-736a-4d71-8d15-34814514c421 .ag-row[role='row']@ROWINDEX [col-id='cEmail']","",false, this.CurrentView);
 
            InactiveDate = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#094d4ffe-736a-4d71-8d15-34814514c421 .ag-row[role='row']@ROWINDEX [col-id='cInactiveDate']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<CustomerEntityView> IDContactType { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> Description { get; set; } 
        public IRPSGridCheckbox<CustomerEntityView> Commercial { get; set; } 
        public IRPSGridCheckbox<CustomerEntityView> Technical { get; set; } 
        public IRPSGridCheckbox<CustomerEntityView> DefaultCommercial { get; set; } 
        public IRPSGridCheckbox<CustomerEntityView> DefaultAdministration { get; set; } 
        public IRPSGridCheckbox<CustomerEntityView> DefaultFinancial { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> Phone1 { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> Email { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> InactiveDate { get; set; } 
                     
    }
 
        public partial class CustomerArticlesCollectionEditor<CustomerEntityView,CustomerDetailView>:RPSCollectionEditor<CustomerEntityView,CustomerDetailView> where CustomerEntityView : class, IView where CustomerDetailView : class, IView
    {
        public  CustomerArticlesGridView<CustomerEntityView,CustomerDetailView> GridView {get;set;}
    }
    public partial class CustomerArticlesGridView <CustomerEntityView,CustomerDetailView> :  RPSGridView<CustomerEntityView,CustomerDetailView> where CustomerEntityView : class, IView where CustomerDetailView : class, IView
    {
        public CustomerArticlesGridView(CustomerEntityView currentView,CustomerDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<CustomerEntityView>("","#c00f0502-f808-4196-839a-0433c879129e .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            CustReference = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#c00f0502-f808-4196-839a-0433c879129e .ag-row[role='row']@ROWINDEX [col-id='cCustReference']","",false, this.CurrentView);
 
            DescriptionCustomer = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#c00f0502-f808-4196-839a-0433c879129e .ag-row[role='row']@ROWINDEX [col-id='cDescriptionCustomer']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<CustomerEntityView> IDArticle { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> CustReference { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> DescriptionCustomer { get; set; } 
                     
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
            CodCompany = RPSControlFactory.CreateRPSGridComboBox<CustomerEntityView>("","#869e8db8-d437-4e04-9777-20ee74811c6c .ag-row[role='row']@ROWINDEX [col-id='cCodCompany']","",false, this.CurrentView);
 
            IDCustomer = RPSControlFactory.CreateRPSGridComboBox<CustomerEntityView>("","#869e8db8-d437-4e04-9777-20ee74811c6c .ag-row[role='row']@ROWINDEX [col-id='cIDCustomer']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<CustomerEntityView> CodCompany { get; set; } 
        public IRPSGridComboBox<CustomerEntityView> IDCustomer { get; set; } 
                     
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
 
            IDContactType = RPSControlFactory.CreateRPSComboBox<CustomerContactView>("46466fd2-86ff-42c6-83b8-69ecc4f01a08","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CustomerContactView>("2ea66ecc-3f8e-431d-b22d-68d9434fb928","","",true, this);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<CustomerContactView>("d582fac8-a327-4023-884c-9cc6edc0a8c3","","",false, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<CustomerContactView>("f8aef333-6666-48c5-93b1-a9f627471bf6","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<CustomerContactView>("adedb71f-5614-4b07-894d-e347d7198fb8","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<CustomerContactView>("ff5260c3-c08a-4600-a661-b4b6b48c79ae","","",false, this);
 
            Email = RPSControlFactory.CreateRPSEmailTextBox<CustomerContactView>("663982d8-5fe7-4253-a20d-118b3b84f807","","",false, this);
 
            InactiveDate = RPSControlFactory.CreateRPSTextBox<CustomerContactView>("eba3db99-dc7f-47e7-91f4-fb349bd34261","","",false, this);
 
            Commercial = RPSControlFactory.CreateRPSCheckBox<CustomerContactView>("b2a4bb67-6df3-4020-bb09-409b52c3968d","","",true, this);
 
            Technical = RPSControlFactory.CreateRPSCheckBox<CustomerContactView>("82d097bf-7343-48df-a30a-5afa862d245c","","",true, this);
 
            DefaultCommercial = RPSControlFactory.CreateRPSCheckBox<CustomerContactView>("2ab5d32e-71f1-40c1-af14-da2e35b0e640","","",true, this);
 
            DefaultAdministration = RPSControlFactory.CreateRPSCheckBox<CustomerContactView>("1960d918-34b0-4d17-a3e9-b82fff9152e6","","",true, this);
 
            DefaultFinancial = RPSControlFactory.CreateRPSCheckBox<CustomerContactView>("9cd24eca-aafc-4372-a7b7-29e7ae01d05a","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<CustomerContactView>("a133bcfd-19d3-4db8-ac43-01e7cb7ecf3e","","",false, this);
 
            GeneralData = RPSControlFactory.CreateRPSSection<CustomerContactView>( "","ul li[rpsid='a37bc7da-0176-421a-821c-25fe07e170f5']","",this);
 
            Comment1 = RPSControlFactory.CreateRPSSection<CustomerContactView>( "","ul li[rpsid='e7b2fd9f-eef2-4ce8-af86-cfb196050935']","",this);
 

        }
        public IRPSButton<CustomerContactView> DeleteButton { get; set; } 
        public IRPSButton<CustomerContactView,CustomerEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerContactView,CustomerEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CustomerContactView,CustomerEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<CustomerContactView> IDContactType { get; set; } 
        public IRPSTextBox<CustomerContactView> Description { get; set; } 
        public IRPSComboBox<CustomerContactView> CodUser { get; set; } 
        public IRPSTextBox<CustomerContactView> Phone1 { get; set; } 
        public IRPSTextBox<CustomerContactView> Phone2 { get; set; } 
        public IRPSTextBox<CustomerContactView> Fax { get; set; } 
        public IRPSTextBox<CustomerContactView> Email { get; set; } 
        public IRPSTextBox<CustomerContactView> InactiveDate { get; set; } 
        public IRPSCheckbox<CustomerContactView> Commercial { get; set; } 
        public IRPSCheckbox<CustomerContactView> Technical { get; set; } 
        public IRPSCheckbox<CustomerContactView> DefaultCommercial { get; set; } 
        public IRPSCheckbox<CustomerContactView> DefaultAdministration { get; set; } 
        public IRPSCheckbox<CustomerContactView> DefaultFinancial { get; set; } 
        public IRPSTextBox<CustomerContactView> Comment { get; set; } 
        public IRPSSection<CustomerContactView> GeneralData { get; set; } 
        public IRPSSection<CustomerContactView> Comment1 { get; set; } 
        public Customer Screen { get; set; }
        public CustomerContactView Wait(int seconds)
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
 
            CodCompany = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("bfab5895-2376-46fe-834a-87ce17042c96","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("0700c2b9-4484-410c-ac75-7ee3d1e1a78f","","",true, this);
 

        }
        public IRPSButton<CustomerDetailView> DeleteButton { get; set; } 
        public IRPSButton<CustomerDetailView,CustomerEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerDetailView,CustomerEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CustomerDetailView,CustomerEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<CustomerDetailView> CodCompany { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDCustomer { get; set; } 
        public Customer Screen { get; set; }
        public CustomerDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CustomerArticleView : View
    {
        public CustomerArticleView(Customer screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CustomerArticleView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CustomerArticleView,CustomerEntityView>( this,Screen.CustomerEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<CustomerArticleView,CustomerEntityView>( this,Screen.CustomerEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CustomerArticleView,CustomerEntityView>( this,Screen.CustomerEntityView);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<CustomerArticleView>("d3b9358f-5014-46b5-808b-e851b2cbabbe","","",true, this);
 
            CustReference = RPSControlFactory.CreateRPSTextBox<CustomerArticleView>("f07d2743-c417-4b94-bf8c-4876fea96856","","",false, this);
 
            DescriptionCustomer = RPSControlFactory.CreateRPSTextBox<CustomerArticleView>("a39521ec-9c76-4f0b-a686-ccdd6953133b","","",false, this);
 

        }
        public IRPSButton<CustomerArticleView> DeleteButton { get; set; } 
        public IRPSButton<CustomerArticleView,CustomerEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerArticleView,CustomerEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CustomerArticleView,CustomerEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<CustomerArticleView> IDArticle { get; set; } 
        public IRPSTextBox<CustomerArticleView> CustReference { get; set; } 
        public IRPSTextBox<CustomerArticleView> DescriptionCustomer { get; set; } 
        public Customer Screen { get; set; }
        public CustomerArticleView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}