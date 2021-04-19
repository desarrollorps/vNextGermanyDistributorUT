    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.ReceivablePayable.Supplier
{
    //RPS VERSION 1.0.0.0
    public partial class Supplier:Screen
    {
        public Supplier():base()
        {
            this.URL = "receivablepayable.supplier";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SupplierCollectionView  = new SupplierCollectionView(this); 
            SupplierEntityView  = new SupplierEntityView(this); 
            SupplierBankAccountView  = new SupplierBankAccountView(this); 
            SupplierDetailView  = new SupplierDetailView(this); 
            SupplierContactView  = new SupplierContactView(this); 
            SupplierCollectionView.InitializeControls(); 
            SupplierEntityView.InitializeControls(); 
            SupplierBankAccountView.InitializeControls(); 
            SupplierDetailView.InitializeControls(); 
            SupplierContactView.InitializeControls(); 
           
        }
      
            public SupplierCollectionView SupplierCollectionView {get; set; } 
            public SupplierEntityView SupplierEntityView {get; set; } 
            public SupplierBankAccountView SupplierBankAccountView {get; set; } 
            public SupplierDetailView SupplierDetailView {get; set; } 
            public SupplierContactView SupplierContactView {get; set; } 
    }
            
    public partial class SupplierCollectionView : View
    {
        public SupplierCollectionView(Supplier screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<SupplierCollectionView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "1511425e-09a8-4e3a-9436-260cba15bf07",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<SupplierCollectionView,SupplierEntityView>( params_MainConsult,this,Screen.SupplierEntityView);
 

        }
        public IRPSButton<SupplierCollectionView,SupplierEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<SupplierCollectionView,SupplierEntityView> MainConsult { get; set; } 
        public Supplier Screen { get; set; }
        public SupplierCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SupplierEntityView : View
    {
        public SupplierEntityView(Supplier screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<SupplierEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierEntityView,SupplierCollectionView>( this,Screen.SupplierCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierEntityView,SupplierCollectionView>( this,Screen.SupplierCollectionView);
 
            CodSupplier = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("19baa503-6655-4f88-8909-cbf468791b11","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("2ab562f4-d870-480f-8a41-ec3cb605f221","","",false, this);
 
            InactiveDate = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("6a10d9f2-22da-4687-b56b-98d3a03e9247","","",false, this);
 
            CompanyName = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("fdea124f-9753-41fe-afa9-db600225d245","","",false, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("f5e54719-fba6-415d-8b96-8eb018c99ece","","",false, this);
 
            ThirdType = RPSControlFactory.CreateRPSEnumComboBox<SupplierEntityView>("bc3c0e70-9c3a-4cbe-91c2-26b4723ab209","","",true, this);
 
            Miscellaneous = RPSControlFactory.CreateRPSCheckBox<SupplierEntityView>("d2ee78f4-cd84-46bf-a28d-65f667486288","","",true, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("5a1255a7-1cda-4e1d-b6d8-3a65a2320691","","",false, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("48d4c0d6-a0b2-421b-ada7-d2f056ee83ce","","",false, this);
 
            IDState = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("dd21fde8-86a1-49a6-b2e1-a757ae4e4421","","",false, this);
 
            IDCounty = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("5bcedd16-da34-427c-a80d-29ae19aafe59","","",false, this);
 
            Address = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("8775be7f-a11f-4930-9ade-42d9330a04a6","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("d815a490-d962-4bed-9436-a80e9133e901","","",false, this);
 
            Position = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("f80c82d7-1505-4b2a-87f6-c06c0f41862f","","",false, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("d70cf888-88a9-4f1a-8184-50583b74333c","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("6ea2f0a7-88ea-4a1d-a6d3-75a065928f45","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("f139a5e5-f0ae-4d31-9185-13ecaf5c1438","","",false, this);
 
            Email = RPSControlFactory.CreateRPSEmailTextBox<SupplierEntityView>("85f19dbe-ec84-48c5-8e0a-0b03903e7036","","",false, this);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("6a4d483d-a28e-4c8f-8645-1d7bf8c1b5c5","","",false, this);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("9bc456b0-15dd-4d69-bfb0-6f9d1e3d6e56","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("12478224-d7fe-49c9-b6e9-b4b4f4a6f70d","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("3cf41c60-a111-4813-8948-ff06eda4afc6","","",true, this);
 
            SupplierCustomerINFO = RPSControlFactory.CreateRPSTextBox<SupplierEntityView>("37642ff2-db0f-4c03-b471-d31e86b571aa","","",false, this);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("c2d0f3f2-7164-4a18-a2a3-330d8d73405c","","",false, this);
 
            IDBankAccountCompany = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("dce5d923-b630-4238-a066-b65da9a91c96","","",false, this);
 
            IDThirdAccType = RPSControlFactory.CreateRPSComboBox<SupplierEntityView>("d97aae17-ad0c-4bf8-a7ac-09ee52dbc374","","",false, this);
 
            CollectionInit params_SupplierContacts = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1c6412ab-1759-43bd-b269-96639ac271b8",CSSSelectorGrid="",XPathGrid=""};
            SupplierContacts = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierContactsCollectionEditor<SupplierEntityView,SupplierBankAccountView>,SupplierEntityView,SupplierBankAccountView>( params_SupplierContacts,this,Screen.SupplierBankAccountView);
 
            CollectionInit params_SupplierBankAccounts = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="33ab18bb-809f-4f15-a0df-80892cfc4e98",CSSSelectorGrid="",XPathGrid=""};
            SupplierBankAccounts = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierBankAccountsCollectionEditor<SupplierEntityView,SupplierBankAccountView>,SupplierEntityView,SupplierBankAccountView>( params_SupplierBankAccounts,this,Screen.SupplierBankAccountView);
 
            CollectionInit params_SupplierDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b22f688c-1f0b-4117-a4ed-75f1560f6cee",CSSSelectorGrid="",XPathGrid=""};
            SupplierDetails = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierDetailsCollectionEditor<SupplierEntityView,SupplierBankAccountView>,SupplierEntityView,SupplierBankAccountView>( params_SupplierDetails,this,Screen.SupplierBankAccountView);
 
            General = RPSControlFactory.CreateRPSSection<SupplierEntityView>( "","ul li[rpsid='93a85c03-a3ac-44ab-9e61-17e5786d2275']","",this);
 
            Financial = RPSControlFactory.CreateRPSSection<SupplierEntityView>( "","ul li[rpsid='0c752e6c-589e-493e-aa1c-a4103aadbd75']","",this);
 
            Section = RPSControlFactory.CreateRPSSection<SupplierEntityView>( "","ul li[rpsid='f601bd1c-a634-4998-8fc6-2e5afa90490d']","",this);
 
            Banks = RPSControlFactory.CreateRPSSection<SupplierEntityView>( "","ul li[rpsid='e544e77c-e2db-48af-8710-fdee9b12225a']","",this);
 
            Subsidiaries = RPSControlFactory.CreateRPSSection<SupplierEntityView>( "","ul li[rpsid='a8b7627a-84b1-40e6-b79f-0385be7e6fb3']","",this);
 

        }
        public IRPSSaveButton<SupplierEntityView> SaveButton { get; set; } 
        public IRPSButton<SupplierEntityView> DeleteButton { get; set; } 
        public IRPSButton<SupplierEntityView,SupplierCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierEntityView,SupplierCollectionView> BackButton { get; set; } 
        public IRPSTextBox<SupplierEntityView> CodSupplier { get; set; } 
        public IRPSTextBox<SupplierEntityView> Description { get; set; } 
        public IRPSTextBox<SupplierEntityView> InactiveDate { get; set; } 
        public IRPSTextBox<SupplierEntityView> CompanyName { get; set; } 
        public IRPSTextBox<SupplierEntityView> VATNumber { get; set; } 
        public IRPSComboBox<SupplierEntityView> ThirdType { get; set; } 
        public IRPSCheckbox<SupplierEntityView> Miscellaneous { get; set; } 
        public IRPSComboBox<SupplierEntityView> CodCountry { get; set; } 
        public IRPSTextBox<SupplierEntityView> ZipCode { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDState { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDCounty { get; set; } 
        public IRPSTextBox<SupplierEntityView> Address { get; set; } 
        public IRPSTextBox<SupplierEntityView> City { get; set; } 
        public IRPSTextBox<SupplierEntityView> Position { get; set; } 
        public IRPSTextBox<SupplierEntityView> Phone1 { get; set; } 
        public IRPSTextBox<SupplierEntityView> Phone2 { get; set; } 
        public IRPSTextBox<SupplierEntityView> Fax { get; set; } 
        public IRPSTextBox<SupplierEntityView> Email { get; set; } 
        public IRPSComboBox<SupplierEntityView> CodUser { get; set; } 
        public IRPSComboBox<SupplierEntityView> CodLanguage { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDCustomer { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDCurrency { get; set; } 
        public IRPSTextBox<SupplierEntityView> SupplierCustomerINFO { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDPaymentMethod { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDBankAccountCompany { get; set; } 
        public IRPSComboBox<SupplierEntityView> IDThirdAccType { get; set; } 
        public SupplierContactsCollectionEditor<SupplierEntityView,SupplierBankAccountView> SupplierContacts { get; set; } 
        public SupplierBankAccountsCollectionEditor<SupplierEntityView,SupplierBankAccountView> SupplierBankAccounts { get; set; } 
        public SupplierDetailsCollectionEditor<SupplierEntityView,SupplierBankAccountView> SupplierDetails { get; set; } 
        public IRPSSection<SupplierEntityView> General { get; set; } 
        public IRPSSection<SupplierEntityView> Financial { get; set; } 
        public IRPSSection<SupplierEntityView> Section { get; set; } 
        public IRPSSection<SupplierEntityView> Banks { get; set; } 
        public IRPSSection<SupplierEntityView> Subsidiaries { get; set; } 
        public Supplier Screen { get; set; }
        public SupplierEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SupplierContactsCollectionEditor<SupplierEntityView,SupplierBankAccountView>:RPSCollectionEditor<SupplierEntityView,SupplierBankAccountView> where SupplierEntityView : class, IView where SupplierBankAccountView : class, IView
    {
        public  SupplierContactsGridView<SupplierEntityView,SupplierBankAccountView> GridView {get;set;}
    }
    public partial class SupplierContactsGridView <SupplierEntityView,SupplierBankAccountView> :  RPSGridView<SupplierEntityView,SupplierBankAccountView> where SupplierEntityView : class, IView where SupplierBankAccountView : class, IView
    {
        public SupplierContactsGridView(SupplierEntityView currentView,SupplierBankAccountView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDContactType = RPSControlFactory.CreateRPSGridComboBox<SupplierEntityView>("","#1c6412ab-1759-43bd-b269-96639ac271b8 .ag-row[role='row']@ROWINDEX [col-id='cIDContactType']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#1c6412ab-1759-43bd-b269-96639ac271b8 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",true, this.CurrentView);
 
            DefaultCommercial = RPSControlFactory.CreateRPSGridCheckBox<SupplierEntityView>("","#1c6412ab-1759-43bd-b269-96639ac271b8 .ag-row[role='row']@ROWINDEX [col-id='cDefaultCommercial']","",true, this.CurrentView);
 
            DefaultAdministration = RPSControlFactory.CreateRPSGridCheckBox<SupplierEntityView>("","#1c6412ab-1759-43bd-b269-96639ac271b8 .ag-row[role='row']@ROWINDEX [col-id='cDefaultAdministration']","",true, this.CurrentView);
 
            DefaultFinancial = RPSControlFactory.CreateRPSGridCheckBox<SupplierEntityView>("","#1c6412ab-1759-43bd-b269-96639ac271b8 .ag-row[role='row']@ROWINDEX [col-id='cDefaultFinancial']","",true, this.CurrentView);
 
            Phone1 = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#1c6412ab-1759-43bd-b269-96639ac271b8 .ag-row[role='row']@ROWINDEX [col-id='cPhone1']","",false, this.CurrentView);
 
            CodUser = RPSControlFactory.CreateRPSGridComboBox<SupplierEntityView>("","#1c6412ab-1759-43bd-b269-96639ac271b8 .ag-row[role='row']@ROWINDEX [col-id='cCodUser']","",false, this.CurrentView);
 
            Email = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#1c6412ab-1759-43bd-b269-96639ac271b8 .ag-row[role='row']@ROWINDEX [col-id='cEmail']","",false, this.CurrentView);
 
            InactiveDate = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#1c6412ab-1759-43bd-b269-96639ac271b8 .ag-row[role='row']@ROWINDEX [col-id='cInactiveDate']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<SupplierEntityView> IDContactType { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Description { get; set; } 
        public IRPSGridCheckbox<SupplierEntityView> DefaultCommercial { get; set; } 
        public IRPSGridCheckbox<SupplierEntityView> DefaultAdministration { get; set; } 
        public IRPSGridCheckbox<SupplierEntityView> DefaultFinancial { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Phone1 { get; set; } 
        public IRPSGridComboBox<SupplierEntityView> CodUser { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Email { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> InactiveDate { get; set; } 
                     
    }
 
        public partial class SupplierBankAccountsCollectionEditor<SupplierEntityView,SupplierBankAccountView>:RPSCollectionEditor<SupplierEntityView,SupplierBankAccountView> where SupplierEntityView : class, IView where SupplierBankAccountView : class, IView
    {
        public  SupplierBankAccountsGridView<SupplierEntityView,SupplierBankAccountView> GridView {get;set;}
    }
    public partial class SupplierBankAccountsGridView <SupplierEntityView,SupplierBankAccountView> :  RPSGridView<SupplierEntityView,SupplierBankAccountView> where SupplierEntityView : class, IView where SupplierBankAccountView : class, IView
    {
        public SupplierBankAccountsGridView(SupplierEntityView currentView,SupplierBankAccountView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodSupplierBankAccount = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#33ab18bb-809f-4f15-a0df-80892cfc4e98 .ag-row[role='row']@ROWINDEX [col-id='cCodSupplierBankAccount']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#33ab18bb-809f-4f15-a0df-80892cfc4e98 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            IBAN = RPSControlFactory.CreateRPSGridTextBox<SupplierEntityView>("","#33ab18bb-809f-4f15-a0df-80892cfc4e98 .ag-row[role='row']@ROWINDEX [col-id='cIBAN']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SupplierEntityView> CodSupplierBankAccount { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> Description { get; set; } 
        public IRPSGridTextBox<SupplierEntityView> IBAN { get; set; } 
                     
    }
 
        public partial class SupplierDetailsCollectionEditor<SupplierEntityView,SupplierBankAccountView>:RPSCollectionEditor<SupplierEntityView,SupplierBankAccountView> where SupplierEntityView : class, IView where SupplierBankAccountView : class, IView
    {
        public  SupplierDetailsGridView<SupplierEntityView,SupplierBankAccountView> GridView {get;set;}
    }
    public partial class SupplierDetailsGridView <SupplierEntityView,SupplierBankAccountView> :  RPSGridView<SupplierEntityView,SupplierBankAccountView> where SupplierEntityView : class, IView where SupplierBankAccountView : class, IView
    {
        public SupplierDetailsGridView(SupplierEntityView currentView,SupplierBankAccountView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodCompany = RPSControlFactory.CreateRPSGridComboBox<SupplierEntityView>("","#b22f688c-1f0b-4117-a4ed-75f1560f6cee .ag-row[role='row']@ROWINDEX [col-id='cCodCompany']","",true, this.CurrentView);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSGridComboBox<SupplierEntityView>("","#b22f688c-1f0b-4117-a4ed-75f1560f6cee .ag-row[role='row']@ROWINDEX [col-id='cIDPaymentMethod']","",false, this.CurrentView);
 
            IDCurrency = RPSControlFactory.CreateRPSGridComboBox<SupplierEntityView>("","#b22f688c-1f0b-4117-a4ed-75f1560f6cee .ag-row[role='row']@ROWINDEX [col-id='cIDCurrency']","",true, this.CurrentView);
 
            IDThirdAccType = RPSControlFactory.CreateRPSGridComboBox<SupplierEntityView>("","#b22f688c-1f0b-4117-a4ed-75f1560f6cee .ag-row[role='row']@ROWINDEX [col-id='cIDThirdAccType']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<SupplierEntityView> CodCompany { get; set; } 
        public IRPSGridComboBox<SupplierEntityView> IDPaymentMethod { get; set; } 
        public IRPSGridComboBox<SupplierEntityView> IDCurrency { get; set; } 
        public IRPSGridComboBox<SupplierEntityView> IDThirdAccType { get; set; } 
                     
    }
 
    }
  
            
    public partial class SupplierBankAccountView : View
    {
        public SupplierBankAccountView(Supplier screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierBankAccountView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierBankAccountView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierBankAccountView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SupplierBankAccountView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            CodSupplierBankAccount = RPSControlFactory.CreateRPSTextBox<SupplierBankAccountView>("2b5b975d-7582-4c1c-b442-e092606505b0","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SupplierBankAccountView>("4eb11460-14c4-4c53-80f4-acb5d5085bb6","","",false, this);
 
            CodBank = RPSControlFactory.CreateRPSComboBox<SupplierBankAccountView>("e826efba-b833-441e-9899-b309cd6b42df","","",false, this);
 
            CodBankBranch = RPSControlFactory.CreateRPSEnumComboBox<SupplierBankAccountView>("19cda6b4-d2bd-4b31-8c2b-94ad2f356a3d","","",false, this);
 
            DigitControl = RPSControlFactory.CreateRPSTextBox<SupplierBankAccountView>("f13bd528-e6ae-4ee4-b582-1626bbde357f","","",false, this);
 
            BankAccount = RPSControlFactory.CreateRPSTextBox<SupplierBankAccountView>("0a07ed54-3a5a-493b-b9be-92841c1da743","","",false, this);
 
            BankAccNumber = RPSControlFactory.CreateRPSTextBox<SupplierBankAccountView>("b136af96-73ae-4633-90fa-6b31fe481c83","","",false, this);
 
            IBAN = RPSControlFactory.CreateRPSTextBox<SupplierBankAccountView>("5f5ca50b-98ad-4672-b61e-57044fed0852","","",false, this);
 
            SWIFTCode = RPSControlFactory.CreateRPSTextBox<SupplierBankAccountView>("b4e358fd-43e2-458d-a1bf-55e2298713a2","","",false, this);
 
            TypeBankAcc = RPSControlFactory.CreateRPSEnumComboBox<SupplierBankAccountView>("3eae1028-745f-4386-b757-510babe46002","","",true, this);
 
            Default = RPSControlFactory.CreateRPSCheckBox<SupplierBankAccountView>("7a35c185-649f-4d51-8052-12282b103170","","",true, this);
 

        }
        public IRPSButton<SupplierBankAccountView> DeleteButton { get; set; } 
        public IRPSButton<SupplierBankAccountView,SupplierEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierBankAccountView,SupplierEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<SupplierBankAccountView,SupplierEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<SupplierBankAccountView> CodSupplierBankAccount { get; set; } 
        public IRPSTextBox<SupplierBankAccountView> Description { get; set; } 
        public IRPSComboBox<SupplierBankAccountView> CodBank { get; set; } 
        public IRPSComboBox<SupplierBankAccountView> CodBankBranch { get; set; } 
        public IRPSTextBox<SupplierBankAccountView> DigitControl { get; set; } 
        public IRPSTextBox<SupplierBankAccountView> BankAccount { get; set; } 
        public IRPSTextBox<SupplierBankAccountView> BankAccNumber { get; set; } 
        public IRPSTextBox<SupplierBankAccountView> IBAN { get; set; } 
        public IRPSTextBox<SupplierBankAccountView> SWIFTCode { get; set; } 
        public IRPSComboBox<SupplierBankAccountView> TypeBankAcc { get; set; } 
        public IRPSCheckbox<SupplierBankAccountView> Default { get; set; } 
        public Supplier Screen { get; set; }
        public SupplierBankAccountView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SupplierDetailView : View
    {
        public SupplierDetailView(Supplier screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierDetailView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierDetailView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SupplierDetailView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            CodCompany = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("a9647466-7c79-46ee-bd09-66273b80b442","","",true, this);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("05db4ca9-0fac-4b58-ad69-94d81d94c3aa","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("532969f1-663a-42e0-864a-2f49c3cfba15","","",true, this);
 
            IDBankAccountCompany = RPSControlFactory.CreateRPSComboBox<SupplierDetailView>("59320aa0-a4db-4b1d-bc59-2256b29f8736","","",false, this);
 

        }
        public IRPSButton<SupplierDetailView> DeleteButton { get; set; } 
        public IRPSButton<SupplierDetailView,SupplierEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierDetailView,SupplierEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<SupplierDetailView,SupplierEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<SupplierDetailView> CodCompany { get; set; } 
        public IRPSComboBox<SupplierDetailView> IDPaymentMethod { get; set; } 
        public IRPSComboBox<SupplierDetailView> IDCurrency { get; set; } 
        public IRPSComboBox<SupplierDetailView> IDBankAccountCompany { get; set; } 
        public Supplier Screen { get; set; }
        public SupplierDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SupplierContactView : View
    {
        public SupplierContactView(Supplier screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierContactView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierContactView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierContactView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SupplierContactView,SupplierEntityView>( this,Screen.SupplierEntityView);
 
            IDContactType = RPSControlFactory.CreateRPSComboBox<SupplierContactView>("9eaffa07-60d0-42f3-89ec-8082cfef8f74","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SupplierContactView>("6e82845b-64ba-43cd-b078-e2b070c535e6","","",true, this);
 
            Phone1 = RPSControlFactory.CreateRPSTextBox<SupplierContactView>("c2bab17b-9f03-4de2-b9a3-f7968e2b1f99","","",false, this);
 
            Phone2 = RPSControlFactory.CreateRPSTextBox<SupplierContactView>("e4b2b4b2-ad8d-4243-9d1f-8da99bdb5c72","","",false, this);
 
            Fax = RPSControlFactory.CreateRPSTextBox<SupplierContactView>("38cd8400-5fba-4829-afdb-55795db02d23","","",false, this);
 
            Email = RPSControlFactory.CreateRPSTextBox<SupplierContactView>("565a609a-d3a5-436b-9e96-4387a9e14bfa","","",false, this);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<SupplierContactView>("dbff4f47-ea2d-47b7-9f09-63293a2860c2","","",false, this);
 
            InactiveDate = RPSControlFactory.CreateRPSTextBox<SupplierContactView>("2fede95b-a7ea-4b28-9774-0b1eaec4944e","","",false, this);
 
            DefaultCommercial = RPSControlFactory.CreateRPSCheckBox<SupplierContactView>("596796cd-e0f3-4982-85a3-fb849250cf37","","",true, this);
 
            DefaultAdministration = RPSControlFactory.CreateRPSCheckBox<SupplierContactView>("c28dba77-097a-48a4-86c9-e3ed45a0fbff","","",true, this);
 
            DefaultFinancial = RPSControlFactory.CreateRPSCheckBox<SupplierContactView>("7b8a52f8-8818-4053-b285-dce357a187a3","","",true, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<SupplierContactView>("875c650d-20ad-4d9d-8157-036193b1609a","","",false, this);
 
            Section = RPSControlFactory.CreateRPSSection<SupplierContactView>( "","ul li[rpsid='e2549cd8-5969-4599-82cd-493f94e1c22d']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<SupplierContactView>( "","ul li[rpsid='1bd19bff-e6d8-43e5-80d5-d50bec2b23f6']","",this);
 

        }
        public IRPSButton<SupplierContactView> DeleteButton { get; set; } 
        public IRPSButton<SupplierContactView,SupplierEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierContactView,SupplierEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<SupplierContactView,SupplierEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<SupplierContactView> IDContactType { get; set; } 
        public IRPSTextBox<SupplierContactView> Description { get; set; } 
        public IRPSTextBox<SupplierContactView> Phone1 { get; set; } 
        public IRPSTextBox<SupplierContactView> Phone2 { get; set; } 
        public IRPSTextBox<SupplierContactView> Fax { get; set; } 
        public IRPSTextBox<SupplierContactView> Email { get; set; } 
        public IRPSComboBox<SupplierContactView> CodUser { get; set; } 
        public IRPSTextBox<SupplierContactView> InactiveDate { get; set; } 
        public IRPSCheckbox<SupplierContactView> DefaultCommercial { get; set; } 
        public IRPSCheckbox<SupplierContactView> DefaultAdministration { get; set; } 
        public IRPSCheckbox<SupplierContactView> DefaultFinancial { get; set; } 
        public IRPSTextBox<SupplierContactView> Comment { get; set; } 
        public IRPSSection<SupplierContactView> Section { get; set; } 
        public IRPSSection<SupplierContactView> Section1 { get; set; } 
        public Supplier Screen { get; set; }
        public SupplierContactView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}