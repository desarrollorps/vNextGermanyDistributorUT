    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.Customer
{
    //RPS VERSION 1.0.0.0
    public partial class Customer:Screen
    {
        public Customer():base()
        {
            this.URL = "generalledger.customer";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CustomerCollectionView  = new CustomerCollectionView(this); 
            CustomerEntityView  = new CustomerEntityView(this); 
            CustomerDetailView  = new CustomerDetailView(this); 
            CustomerContactView  = new CustomerContactView(this); 
            CustomerCollectionView.InitializeControls(); 
            CustomerEntityView.InitializeControls(); 
            CustomerDetailView.InitializeControls(); 
            CustomerContactView.InitializeControls(); 
           
        }
      
            public CustomerCollectionView CustomerCollectionView {get; set; } 
            public CustomerEntityView CustomerEntityView {get; set; } 
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
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "fa0d33b4-7d19-4a21-bf39-3e3cb842298d",CSSSelectorDescriptor = "",XPathDescriptor = ""};
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
 
            CodCustomer = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("83e2ccbf-3dba-4d9a-b6a0-a324de4f0543","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("c1d5b49c-5c76-4e67-90b0-b8687649b02c","","",false, this);
 
            CompanyName = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("823a439e-5665-47e6-aca2-49f8a50d3522","","",false, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("1e73fd0a-87a6-470a-8c17-b7a7e7552f90","","",false, this);
 
            ThirdType = RPSControlFactory.CreateRPSEnumComboBox<CustomerEntityView>("c895588f-3d01-4300-9f15-fbced2b0ee85","","",true, this);
 
            Miscellaneous = RPSControlFactory.CreateRPSCheckBox<CustomerEntityView>("38893b55-d42f-4894-aabe-a6b29b4de1e1","","",true, this);
 
            InactiveDate = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("6cc7c0ee-55b3-43d6-a564-fe3aa768d1c5","","",false, this);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("c842f6fb-c9cd-411a-bf8f-e3f955adbc24","","",false, this);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("1c1b5496-76cd-49a7-bd9b-dc9e3fafd5ef","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("673a11e9-382a-4d3e-a6e2-3b5cb01fd5e4","","",false, this);
 
            Revaluation = RPSControlFactory.CreateRPSCheckBox<CustomerEntityView>("edfa2256-b3df-49ed-a893-be9ab5f99e9d","","",true, this);
 
            IDThirdAccType = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("0316f786-728c-46e3-a14b-23b1c1447d3e","","",true, this);
 
            IDVoucherType = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("97e75373-6db9-4876-9ff3-0f3f20b102d3","","",true, this);
 
            RetentionPercent = RPSControlFactory.CreateRPSFormattedTextBox<CustomerEntityView>("66bacbec-f7fd-4d26-8ec9-63e3b51a0bc6","","",true, this);
 
            RetentionType = RPSControlFactory.CreateRPSEnumComboBox<CustomerEntityView>("f7de9514-f00d-4d42-bc26-e987cb771556","","",true, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("b23d7ffb-858e-45e2-b449-ae8a9e37ea5d","","",false, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("7a3e2d9f-3ae3-4da4-9652-ebba2dd4848f","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("8452e8ab-cee4-4769-bba3-3f992e110ac5","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("095aa3b9-3a76-4eb8-b5ad-89e981201941","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("c7fa1bb8-ecb7-416f-86ce-bcf5c2c8f767","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("4d29c1d0-87dd-491e-b24f-f5eb40914f6b","","",false, this);
 
            Position = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("8e1a8df4-8dac-4ef7-b47d-007d728eca8a","","",false, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("13f6079e-5805-4579-90ea-3c29363033ad","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("2801f146-cc5e-41e8-bd7f-07c7a430ef51","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<CustomerEntityView>("e008c4a9-dfc5-41a8-b9c5-71c3e6de0386","","",false, this);
 
            Email = RPSControlFactory.CreateRPSEmailTextBox<CustomerEntityView>("406e3b8a-406e-420a-9f31-2b24ff02b2f2","","",false, this);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<CustomerEntityView>("12f45f3b-7069-4494-bebf-ea8fd8ce5139","","",false, this);
 
            CollectionInit params_CustomerContacts = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="74ca5b7f-0d54-4d14-91fb-c49438799967",CSSSelectorGrid="",XPathGrid=""};
            CustomerContacts = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerContactsCollectionEditor<CustomerEntityView,CustomerDetailView>,CustomerEntityView,CustomerDetailView>( params_CustomerContacts,this,Screen.CustomerDetailView);
 
            CollectionInit params_CustomerDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="09e67adf-5020-4efe-947d-54a96016bb1d",CSSSelectorGrid="",XPathGrid=""};
            CustomerDetails = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerDetailsCollectionEditor<CustomerEntityView,CustomerDetailView>,CustomerEntityView,CustomerDetailView>( params_CustomerDetails,this,Screen.CustomerDetailView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<CustomerEntityView>( "","ul li[rpsid='1395a403-7d54-413d-a0ef-1fe2db121523']","",this);
 
            Contacts = RPSControlFactory.CreateRPSSection<CustomerEntityView>( "","ul li[rpsid='3ca780d7-a090-403a-a8f5-f7c09d945414']","",this);
 
            Subsidiares = RPSControlFactory.CreateRPSSection<CustomerEntityView>( "","ul li[rpsid='22ce95c3-c535-48d0-8c6f-979fb34d711d']","",this);
 

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
        public IRPSCheckbox<CustomerEntityView> Miscellaneous { get; set; } 
        public IRPSTextBox<CustomerEntityView> InactiveDate { get; set; } 
        public IRPSComboBox<CustomerEntityView> CodUser { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDPaymentMethod { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDCurrency { get; set; } 
        public IRPSCheckbox<CustomerEntityView> Revaluation { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDThirdAccType { get; set; } 
        public IRPSComboBox<CustomerEntityView> IDVoucherType { get; set; } 
        public IRPSTextBox<CustomerEntityView> RetentionPercent { get; set; } 
        public IRPSComboBox<CustomerEntityView> RetentionType { get; set; } 
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
        public CustomerDetailsCollectionEditor<CustomerEntityView,CustomerDetailView> CustomerDetails { get; set; } 
        public IRPSSection<CustomerEntityView> GeneralData { get; set; } 
        public IRPSSection<CustomerEntityView> Contacts { get; set; } 
        public IRPSSection<CustomerEntityView> Subsidiares { get; set; } 
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
            IDContactType = RPSControlFactory.CreateRPSGridComboBox<CustomerEntityView>("","#74ca5b7f-0d54-4d14-91fb-c49438799967 .ag-row[role='row']@ROWINDEX [col-id='cIDContactType']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#74ca5b7f-0d54-4d14-91fb-c49438799967 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",true, this.CurrentView);
 
            Commercial = RPSControlFactory.CreateRPSGridCheckBox<CustomerEntityView>("","#74ca5b7f-0d54-4d14-91fb-c49438799967 .ag-row[role='row']@ROWINDEX [col-id='cCommercial']","",true, this.CurrentView);
 
            DefaultCommercial = RPSControlFactory.CreateRPSGridCheckBox<CustomerEntityView>("","#74ca5b7f-0d54-4d14-91fb-c49438799967 .ag-row[role='row']@ROWINDEX [col-id='cDefaultCommercial']","",true, this.CurrentView);
 
            DefaultAdministration = RPSControlFactory.CreateRPSGridCheckBox<CustomerEntityView>("","#74ca5b7f-0d54-4d14-91fb-c49438799967 .ag-row[role='row']@ROWINDEX [col-id='cDefaultAdministration']","",true, this.CurrentView);
 
            DefaultFinancial = RPSControlFactory.CreateRPSGridCheckBox<CustomerEntityView>("","#74ca5b7f-0d54-4d14-91fb-c49438799967 .ag-row[role='row']@ROWINDEX [col-id='cDefaultFinancial']","",true, this.CurrentView);
 
            Technical = RPSControlFactory.CreateRPSGridCheckBox<CustomerEntityView>("","#74ca5b7f-0d54-4d14-91fb-c49438799967 .ag-row[role='row']@ROWINDEX [col-id='cTechnical']","",true, this.CurrentView);
 
            Phone1 = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#74ca5b7f-0d54-4d14-91fb-c49438799967 .ag-row[role='row']@ROWINDEX [col-id='cPhone1']","",false, this.CurrentView);
 
            Email = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#74ca5b7f-0d54-4d14-91fb-c49438799967 .ag-row[role='row']@ROWINDEX [col-id='cEmail']","",false, this.CurrentView);
 
            InactiveDate = RPSControlFactory.CreateRPSGridTextBox<CustomerEntityView>("","#74ca5b7f-0d54-4d14-91fb-c49438799967 .ag-row[role='row']@ROWINDEX [col-id='cInactiveDate']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<CustomerEntityView> IDContactType { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> Description { get; set; } 
        public IRPSGridCheckbox<CustomerEntityView> Commercial { get; set; } 
        public IRPSGridCheckbox<CustomerEntityView> DefaultCommercial { get; set; } 
        public IRPSGridCheckbox<CustomerEntityView> DefaultAdministration { get; set; } 
        public IRPSGridCheckbox<CustomerEntityView> DefaultFinancial { get; set; } 
        public IRPSGridCheckbox<CustomerEntityView> Technical { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> Phone1 { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> Email { get; set; } 
        public IRPSGridTextBox<CustomerEntityView> InactiveDate { get; set; } 
                     
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
            CodCompany = RPSControlFactory.CreateRPSGridComboBox<CustomerEntityView>("","#09e67adf-5020-4efe-947d-54a96016bb1d .ag-row[role='row']@ROWINDEX [col-id='cCodCompany']","",true, this.CurrentView);
 
            IDCurrency = RPSControlFactory.CreateRPSGridComboBox<CustomerEntityView>("","#09e67adf-5020-4efe-947d-54a96016bb1d .ag-row[role='row']@ROWINDEX [col-id='cIDCurrency']","",false, this.CurrentView);
 
            Revaluation = RPSControlFactory.CreateRPSGridCheckBox<CustomerEntityView>("","#09e67adf-5020-4efe-947d-54a96016bb1d .ag-row[role='row']@ROWINDEX [col-id='cRevaluation']","",true, this.CurrentView);
 
            IDThirdAccType = RPSControlFactory.CreateRPSGridComboBox<CustomerEntityView>("","#09e67adf-5020-4efe-947d-54a96016bb1d .ag-row[role='row']@ROWINDEX [col-id='cIDThirdAccType']","",true, this.CurrentView);
 
            IDVoucherType = RPSControlFactory.CreateRPSGridComboBox<CustomerEntityView>("","#09e67adf-5020-4efe-947d-54a96016bb1d .ag-row[role='row']@ROWINDEX [col-id='cIDVoucherType']","",true, this.CurrentView);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSGridComboBox<CustomerEntityView>("","#09e67adf-5020-4efe-947d-54a96016bb1d .ag-row[role='row']@ROWINDEX [col-id='cIDPaymentMethod']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<CustomerEntityView> CodCompany { get; set; } 
        public IRPSGridComboBox<CustomerEntityView> IDCurrency { get; set; } 
        public IRPSGridCheckbox<CustomerEntityView> Revaluation { get; set; } 
        public IRPSGridComboBox<CustomerEntityView> IDThirdAccType { get; set; } 
        public IRPSGridComboBox<CustomerEntityView> IDVoucherType { get; set; } 
        public IRPSGridComboBox<CustomerEntityView> IDPaymentMethod { get; set; } 
                     
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
 
            CodCompany = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("f49ec736-aaea-498b-9c3a-ec8f90c65ebf","","",true, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("e83dbb43-14eb-4811-982d-5a5945f2fd2b","","",false, this);
 
            IDThirdAccType = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("ca54ddb5-9f06-4d4d-b8f1-e17e46ca212d","","",true, this);
 
            IDVoucherType = RPSControlFactory.CreateRPSComboBox<CustomerDetailView>("a1dc1641-6693-4fbb-81b0-dc0e3ceb07e8","","",true, this);
 
            Revaluation = RPSControlFactory.CreateRPSCheckBox<CustomerDetailView>("7358163c-2797-4be1-8ad5-4020b004941f","","",true, this);
 

        }
        public IRPSButton<CustomerDetailView> DeleteButton { get; set; } 
        public IRPSButton<CustomerDetailView,CustomerEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerDetailView,CustomerEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CustomerDetailView,CustomerEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<CustomerDetailView> CodCompany { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDCurrency { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDThirdAccType { get; set; } 
        public IRPSComboBox<CustomerDetailView> IDVoucherType { get; set; } 
        public IRPSCheckbox<CustomerDetailView> Revaluation { get; set; } 
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
 
            IDContactType = RPSControlFactory.CreateRPSComboBox<CustomerContactView>("ac2a94ce-7d79-4c68-ac61-3f2f5090c48b","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CustomerContactView>("b7057e64-dcc8-4959-a753-a6d1761b48c2","","",true, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<CustomerContactView>("2ff8dd7d-7ed1-4284-bd5f-14c1e5fc5950","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<CustomerContactView>("8df52f18-77f3-4c3e-a625-751091c49866","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<CustomerContactView>("60b2fdbc-aead-4148-ac48-02fa4c28edd3","","",false, this);
 
            Email = RPSControlFactory.CreateRPSTextBox<CustomerContactView>("d0a37c73-30af-4aa6-95bf-92f4afe967a3","","",false, this);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<CustomerContactView>("79beffb7-3ced-45c7-8004-fffe26a53dc2","","",false, this);
 
            InactiveDate = RPSControlFactory.CreateRPSTextBox<CustomerContactView>("5a7f21f5-c253-4417-ae5c-f69641f595c2","","",false, this);
 
            Commercial = RPSControlFactory.CreateRPSCheckBox<CustomerContactView>("09355fa6-1e1d-458d-a33f-d93483ceb491","","",true, this);
 
            DefaultCommercial = RPSControlFactory.CreateRPSCheckBox<CustomerContactView>("ce88642b-e76b-48ee-ba27-713c88173dd8","","",true, this);
 
            DefaultAdministration = RPSControlFactory.CreateRPSCheckBox<CustomerContactView>("67211434-7dfc-4e0f-a03e-e26a0b955d73","","",true, this);
 
            DefaultFinancial = RPSControlFactory.CreateRPSCheckBox<CustomerContactView>("5b8c866f-20ec-4071-a6ab-6aa8fee7c3e8","","",true, this);
 
            Technical = RPSControlFactory.CreateRPSCheckBox<CustomerContactView>("1b93f465-825c-404b-9343-d579653384f7","","",true, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<CustomerContactView>("1ec8bfba-3174-47ae-9fb2-ac4e739b53fd","","",false, this);
 
            Section = RPSControlFactory.CreateRPSSection<CustomerContactView>( "","ul li[rpsid='49a271dc-a4ba-4193-84fe-dad5b8bdd42a']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<CustomerContactView>( "","ul li[rpsid='73607a23-b933-483e-82bc-3729b9c84d79']","",this);
 

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