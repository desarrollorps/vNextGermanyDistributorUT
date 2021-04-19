    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.TaxModel.Mod347
{
    //RPS VERSION 1.0.0.0
    public partial class Mod347:Screen
    {
        public Mod347():base()
        {
            this.URL = "taxmodel.mod347";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            Mod347View  = new Mod347View(this); 
            Mod347View.InitializeControls(); 
           
        }
      
            public Mod347View Mod347View {get; set; } 
    }
            
    public partial class Mod347View : View
    {
        public Mod347View(Mod347 screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Exercise = RPSControlFactory.CreateRPSFormattedTextBox<Mod347View>("6b3c9e12-14f6-4798-bca3-125379d4331b","","",true, this);
 
            AmountLimitType = RPSControlFactory.CreateRPSEnumComboBox<Mod347View>("08f3703f-19b5-4525-973a-98238b135e17","","",false, this);
 
            AmountLimit = RPSControlFactory.CreateRPSFormattedTextBox<Mod347View>("1eafa0d7-66c5-4cba-9f94-d2f397b27f2c","","",false, this);
 
            ThirdPartyCollectionAmountLimit = RPSControlFactory.CreateRPSFormattedTextBox<Mod347View>("4fc44135-c838-4866-b804-b9cdd82f325b","","",false, this);
 
            CashAmountLimit = RPSControlFactory.CreateRPSFormattedTextBox<Mod347View>("a2fcbab9-8db0-4bfb-8826-9c44b62cbefd","","",false, this);
 
            ExecuteSaveMod347Data = RPSControlFactory.CreateRPSButton<Mod347View>( "669b00d9-be58-4fee-bc2a-721849929ed7","","",this);
 
            Prefix = RPSControlFactory.CreateRPSTextBox<Mod347View>("dfa9d38a-d5ad-4909-bcfc-fd44a500bcea","","",false, this);
 
            DeclarationNumber = RPSControlFactory.CreateRPSTextBox<Mod347View>("b64afb1c-6f3f-492d-8d5b-32dc8bf4eaad","","",true, this);
 
            SelectionTypes = RPSControlFactory.CreateRPSEnumComboBox<Mod347View>("abcb9473-636c-456f-88bd-c2be9849e41a","","",true, this);
 
            Prefix1 = RPSControlFactory.CreateRPSTextBox<Mod347View>("27d8e4fc-ab8f-4a6f-85a6-d0dbb4649513","","",false, this);
 
            PrevDeclarationNumber = RPSControlFactory.CreateRPSTextBox<Mod347View>("13a7ec8a-b93d-45ad-a125-e8304762a8c5","","",false, this);
 
            ContactPerson = RPSControlFactory.CreateRPSTextBox<Mod347View>("c6fe908d-6d16-45b3-a277-d062916e18fe","","",false, this);
 
            Phone = RPSControlFactory.CreateRPSTextBox<Mod347View>("c517bf22-41c8-43a8-8244-f35cd4542d1d","","",false, this);
 
            TotalCount = RPSControlFactory.CreateRPSFormattedTextBox<Mod347View>("e220e0fd-0e82-4e7c-90fb-48d729450794","","",false, this);
 
            TotalAmount = RPSControlFactory.CreateRPSFormattedTextBox<Mod347View>("7216c48a-908e-440b-8d6e-53b347262ce3","","",false, this);
 
            RealStatesCount = RPSControlFactory.CreateRPSFormattedTextBox<Mod347View>("90219b40-1611-4f93-ba36-38d2c72256e3","","",false, this);
 
            RealStatesTotalAmount = RPSControlFactory.CreateRPSFormattedTextBox<Mod347View>("953b2938-9108-4e07-a3e1-042ebca4a6a1","","",false, this);
 
            MssError = RPSControlFactory.CreateRPSTextBox<Mod347View>("202630d9-29eb-4a47-bfa0-60337c23eefa","","",false, this);
 
            ExecuteGenerateMod347Button = RPSControlFactory.CreateRPSButton<Mod347View>( "885c7001-5c6a-47af-85ef-5b1475d4acb4","","",this);
 
            CollectionInit params_GetMod347Customers = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="cb9fd2f5-620a-4a10-9615-761cb761278e",CSSSelectorGrid="",XPathGrid=""};
            GetMod347Customers = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod347CustomersCollectionEditor<Mod347View>,Mod347View>( params_GetMod347Customers,this);
 
            CollectionInit params_GetMod347CustomerInvoices = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="38c9e98c-8fb5-4257-99c3-e2cc185286b8",CSSSelectorGrid="",XPathGrid=""};
            GetMod347CustomerInvoices = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod347CustomerInvoicesCollectionEditor<Mod347View>,Mod347View>( params_GetMod347CustomerInvoices,this);
 
            CollectionInit params_GetMod347CustomerRealizedPayments = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="9915d1cc-3b9c-4207-9725-79f605624366",CSSSelectorGrid="",XPathGrid=""};
            GetMod347CustomerRealizedPayments = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod347CustomerRealizedPaymentsCollectionEditor<Mod347View>,Mod347View>( params_GetMod347CustomerRealizedPayments,this);
 
            CollectionInit params_GetMod347CustomerCashDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="86399d0b-4641-439b-b53f-c7fe983e56ba",CSSSelectorGrid="",XPathGrid=""};
            GetMod347CustomerCashDetails = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod347CustomerCashDetailsCollectionEditor<Mod347View>,Mod347View>( params_GetMod347CustomerCashDetails,this);
 
            CollectionInit params_GetMod347CustomerRealStates = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ac6a43df-706b-402e-83d7-d7638348eca6",CSSSelectorGrid="",XPathGrid=""};
            GetMod347CustomerRealStates = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod347CustomerRealStatesCollectionEditor<Mod347View>,Mod347View>( params_GetMod347CustomerRealStates,this);
 
            CollectionInit params_GetMod347Suppliers = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a15cf5ef-4eac-4a3b-b7ce-079b33239145",CSSSelectorGrid="",XPathGrid=""};
            GetMod347Suppliers = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod347SuppliersCollectionEditor<Mod347View>,Mod347View>( params_GetMod347Suppliers,this);
 
            CollectionInit params_GetMod347SupplierInvoices = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="049d2350-5acd-4cec-a1b5-b15c03178211",CSSSelectorGrid="",XPathGrid=""};
            GetMod347SupplierInvoices = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod347SupplierInvoicesCollectionEditor<Mod347View>,Mod347View>( params_GetMod347SupplierInvoices,this);
 
            CollectionInit params_GetMod347SupplierRealizedPayments = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="542af0ac-e71b-4ec9-88b6-0e719fe09b50",CSSSelectorGrid="",XPathGrid=""};
            GetMod347SupplierRealizedPayments = RPSControlFactory.RPSCreateCollectionWithGrid<GetMod347SupplierRealizedPaymentsCollectionEditor<Mod347View>,Mod347View>( params_GetMod347SupplierRealizedPayments,this);
 
            Customers = RPSControlFactory.CreateRPSSection<Mod347View>( "","ul li[rpsid='69cc47f5-1db0-4528-afd6-ff752f758087']","",this);
 
            InvoiceRegister = RPSControlFactory.CreateRPSSection<Mod347View>( "","ul li[rpsid='8e3fa513-dac5-4a8a-8252-88851ded5e99']","",this);
 
            PaymentDetail = RPSControlFactory.CreateRPSSection<Mod347View>( "","ul li[rpsid='eb1b6b57-d28a-446f-b177-d0c2093ee510']","",this);
 
            CashCollection = RPSControlFactory.CreateRPSSection<Mod347View>( "","ul li[rpsid='50ade7a2-a8db-4626-8e61-835724de00fb']","",this);
 
            RealStateRegister = RPSControlFactory.CreateRPSSection<Mod347View>( "","ul li[rpsid='11033374-7b1f-4447-93b8-3a6514f076ea']","",this);
 
            Suppliers = RPSControlFactory.CreateRPSSection<Mod347View>( "","ul li[rpsid='f7118061-55f1-43d0-99ca-5a95bdbda624']","",this);
 
            InvoiceRegister1 = RPSControlFactory.CreateRPSSection<Mod347View>( "","ul li[rpsid='d5590a1b-ef69-4395-ac99-029b4af0793f']","",this);
 
            PaymentDetail1 = RPSControlFactory.CreateRPSSection<Mod347View>( "","ul li[rpsid='0db20da6-1ecd-4309-9bfe-9cb35f389c48']","",this);
 
            Errors = RPSControlFactory.CreateRPSSection<Mod347View>( "","ul li[rpsid='83e23759-f61e-46d1-a776-e8dc15a68002']","",this);
 

        }
        public IRPSTextBox<Mod347View> Exercise { get; set; } 
        public IRPSComboBox<Mod347View> AmountLimitType { get; set; } 
        public IRPSTextBox<Mod347View> AmountLimit { get; set; } 
        public IRPSTextBox<Mod347View> ThirdPartyCollectionAmountLimit { get; set; } 
        public IRPSTextBox<Mod347View> CashAmountLimit { get; set; } 
        public IRPSButton<Mod347View> ExecuteSaveMod347Data { get; set; } 
        public IRPSTextBox<Mod347View> Prefix { get; set; } 
        public IRPSTextBox<Mod347View> DeclarationNumber { get; set; } 
        public IRPSComboBox<Mod347View> SelectionTypes { get; set; } 
        public IRPSTextBox<Mod347View> Prefix1 { get; set; } 
        public IRPSTextBox<Mod347View> PrevDeclarationNumber { get; set; } 
        public IRPSTextBox<Mod347View> ContactPerson { get; set; } 
        public IRPSTextBox<Mod347View> Phone { get; set; } 
        public IRPSTextBox<Mod347View> TotalCount { get; set; } 
        public IRPSTextBox<Mod347View> TotalAmount { get; set; } 
        public IRPSTextBox<Mod347View> RealStatesCount { get; set; } 
        public IRPSTextBox<Mod347View> RealStatesTotalAmount { get; set; } 
        public IRPSTextBox<Mod347View> MssError { get; set; } 
        public IRPSButton<Mod347View> ExecuteGenerateMod347Button { get; set; } 
        public GetMod347CustomersCollectionEditor<Mod347View> GetMod347Customers { get; set; } 
        public GetMod347CustomerInvoicesCollectionEditor<Mod347View> GetMod347CustomerInvoices { get; set; } 
        public GetMod347CustomerRealizedPaymentsCollectionEditor<Mod347View> GetMod347CustomerRealizedPayments { get; set; } 
        public GetMod347CustomerCashDetailsCollectionEditor<Mod347View> GetMod347CustomerCashDetails { get; set; } 
        public GetMod347CustomerRealStatesCollectionEditor<Mod347View> GetMod347CustomerRealStates { get; set; } 
        public GetMod347SuppliersCollectionEditor<Mod347View> GetMod347Suppliers { get; set; } 
        public GetMod347SupplierInvoicesCollectionEditor<Mod347View> GetMod347SupplierInvoices { get; set; } 
        public GetMod347SupplierRealizedPaymentsCollectionEditor<Mod347View> GetMod347SupplierRealizedPayments { get; set; } 
        public IRPSSection<Mod347View> Customers { get; set; } 
        public IRPSSection<Mod347View> InvoiceRegister { get; set; } 
        public IRPSSection<Mod347View> PaymentDetail { get; set; } 
        public IRPSSection<Mod347View> CashCollection { get; set; } 
        public IRPSSection<Mod347View> RealStateRegister { get; set; } 
        public IRPSSection<Mod347View> Suppliers { get; set; } 
        public IRPSSection<Mod347View> InvoiceRegister1 { get; set; } 
        public IRPSSection<Mod347View> PaymentDetail1 { get; set; } 
        public IRPSSection<Mod347View> Errors { get; set; } 
        public Mod347 Screen { get; set; }
        public Mod347View Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetMod347CustomersCollectionEditor<Mod347View>:RPSCollectionEditor<Mod347View> where Mod347View : class, IView
    {
        public  GetMod347CustomersGridView<Mod347View> GridView {get;set;}
    }
    public partial class GetMod347CustomersGridView <Mod347View> :  RPSGridView<Mod347View> where Mod347View : class, IView
    {
        public GetMod347CustomersGridView(Mod347View currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Key347 = RPSControlFactory.CreateRPSGridTextBox<Mod347View>("","#cb9fd2f5-620a-4a10-9615-761cb761278e .ag-row[role='row']@ROWINDEX [col-id='cKey347']","",false, this.CurrentView);
 
            ThirdName = RPSControlFactory.CreateRPSGridTextBox<Mod347View>("","#cb9fd2f5-620a-4a10-9615-761cb761278e .ag-row[role='row']@ROWINDEX [col-id='cThirdName']","",false, this.CurrentView);
 
            ThirdVATNumber = RPSControlFactory.CreateRPSGridTextBox<Mod347View>("","#cb9fd2f5-620a-4a10-9615-761cb761278e .ag-row[role='row']@ROWINDEX [col-id='cThirdVATNumber']","",false, this.CurrentView);
 
            ThirdCountryISOCode = RPSControlFactory.CreateRPSGridTextBox<Mod347View>("","#cb9fd2f5-620a-4a10-9615-761cb761278e .ag-row[role='row']@ROWINDEX [col-id='cThirdCountryISOCode']","",false, this.CurrentView);
 
            YearTotalAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod347View>("","#cb9fd2f5-620a-4a10-9615-761cb761278e .ag-row[role='row']@ROWINDEX [col-id='cYearTotalAmount']","",false, this.CurrentView);
 
            YearTotalRealizedAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod347View>("","#cb9fd2f5-620a-4a10-9615-761cb761278e .ag-row[role='row']@ROWINDEX [col-id='cYearTotalRealizedAmount']","",false, this.CurrentView);
 
            YearTotalCashAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod347View>("","#cb9fd2f5-620a-4a10-9615-761cb761278e .ag-row[role='row']@ROWINDEX [col-id='cYearTotalCashAmount']","",false, this.CurrentView);
 
            YearTotalRealStatesAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod347View>("","#cb9fd2f5-620a-4a10-9615-761cb761278e .ag-row[role='row']@ROWINDEX [col-id='cYearTotalRealStatesAmount']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod347View> Key347 { get; set; } 
        public IRPSGridTextBox<Mod347View> ThirdName { get; set; } 
        public IRPSGridTextBox<Mod347View> ThirdVATNumber { get; set; } 
        public IRPSGridTextBox<Mod347View> ThirdCountryISOCode { get; set; } 
        public IRPSGridTextBox<Mod347View> YearTotalAmount { get; set; } 
        public IRPSGridTextBox<Mod347View> YearTotalRealizedAmount { get; set; } 
        public IRPSGridTextBox<Mod347View> YearTotalCashAmount { get; set; } 
        public IRPSGridTextBox<Mod347View> YearTotalRealStatesAmount { get; set; } 
                     
    }
 
        public partial class GetMod347CustomerInvoicesCollectionEditor<Mod347View>:RPSCollectionEditor<Mod347View> where Mod347View : class, IView
    {
        public  GetMod347CustomerInvoicesGridView<Mod347View> GridView {get;set;}
    }
    public partial class GetMod347CustomerInvoicesGridView <Mod347View> :  RPSGridView<Mod347View> where Mod347View : class, IView
    {
        public GetMod347CustomerInvoicesGridView(Mod347View currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Subkey347 = RPSControlFactory.CreateRPSGridTextBox<Mod347View>("","#38c9e98c-8fb5-4257-99c3-e2cc185286b8 .ag-row[role='row']@ROWINDEX [col-id='cSubkey347']","",false, this.CurrentView);
 
            TotalAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod347View>("","#38c9e98c-8fb5-4257-99c3-e2cc185286b8 .ag-row[role='row']@ROWINDEX [col-id='cTotalAmount']","",false, this.CurrentView);
 
            Quarter = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod347View>("","#38c9e98c-8fb5-4257-99c3-e2cc185286b8 .ag-row[role='row']@ROWINDEX [col-id='cQuarter']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod347View> Subkey347 { get; set; } 
        public IRPSGridTextBox<Mod347View> TotalAmount { get; set; } 
        public IRPSGridTextBox<Mod347View> Quarter { get; set; } 
                     
    }
 
        public partial class GetMod347CustomerRealizedPaymentsCollectionEditor<Mod347View>:RPSCollectionEditor<Mod347View> where Mod347View : class, IView
    {
        public  GetMod347CustomerRealizedPaymentsGridView<Mod347View> GridView {get;set;}
    }
    public partial class GetMod347CustomerRealizedPaymentsGridView <Mod347View> :  RPSGridView<Mod347View> where Mod347View : class, IView
    {
        public GetMod347CustomerRealizedPaymentsGridView(Mod347View currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            PaidAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod347View>("","#9915d1cc-3b9c-4207-9725-79f605624366 .ag-row[role='row']@ROWINDEX [col-id='cPaidAmount']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod347View> PaidAmount { get; set; } 
                     
    }
 
        public partial class GetMod347CustomerCashDetailsCollectionEditor<Mod347View>:RPSCollectionEditor<Mod347View> where Mod347View : class, IView
    {
        public  GetMod347CustomerCashDetailsGridView<Mod347View> GridView {get;set;}
    }
    public partial class GetMod347CustomerCashDetailsGridView <Mod347View> :  RPSGridView<Mod347View> where Mod347View : class, IView
    {
        public GetMod347CustomerCashDetailsGridView(Mod347View currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CollectedAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod347View>("","#86399d0b-4641-439b-b53f-c7fe983e56ba .ag-row[role='row']@ROWINDEX [col-id='cCollectedAmount']","",false, this.CurrentView);
 
            CollectionDate = RPSControlFactory.CreateRPSGridTextBox<Mod347View>("","#86399d0b-4641-439b-b53f-c7fe983e56ba .ag-row[role='row']@ROWINDEX [col-id='cCollectionDate']","",false, this.CurrentView);
 
            InvoiceYear = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod347View>("","#86399d0b-4641-439b-b53f-c7fe983e56ba .ag-row[role='row']@ROWINDEX [col-id='cInvoiceYear']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod347View> CollectedAmount { get; set; } 
        public IRPSGridTextBox<Mod347View> CollectionDate { get; set; } 
        public IRPSGridTextBox<Mod347View> InvoiceYear { get; set; } 
                     
    }
 
        public partial class GetMod347CustomerRealStatesCollectionEditor<Mod347View>:RPSCollectionEditor<Mod347View> where Mod347View : class, IView
    {
        public  GetMod347CustomerRealStatesGridView<Mod347View> GridView {get;set;}
    }
    public partial class GetMod347CustomerRealStatesGridView <Mod347View> :  RPSGridView<Mod347View> where Mod347View : class, IView
    {
        public GetMod347CustomerRealStatesGridView(Mod347View currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            YearTotalAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod347View>("","#ac6a43df-706b-402e-83d7-d7638348eca6 .ag-row[role='row']@ROWINDEX [col-id='cYearTotalAmount']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod347View> YearTotalAmount { get; set; } 
                     
    }
 
        public partial class GetMod347SuppliersCollectionEditor<Mod347View>:RPSCollectionEditor<Mod347View> where Mod347View : class, IView
    {
        public  GetMod347SuppliersGridView<Mod347View> GridView {get;set;}
    }
    public partial class GetMod347SuppliersGridView <Mod347View> :  RPSGridView<Mod347View> where Mod347View : class, IView
    {
        public GetMod347SuppliersGridView(Mod347View currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Key347 = RPSControlFactory.CreateRPSGridTextBox<Mod347View>("","#a15cf5ef-4eac-4a3b-b7ce-079b33239145 .ag-row[role='row']@ROWINDEX [col-id='cKey347']","",false, this.CurrentView);
 
            ThirdName = RPSControlFactory.CreateRPSGridTextBox<Mod347View>("","#a15cf5ef-4eac-4a3b-b7ce-079b33239145 .ag-row[role='row']@ROWINDEX [col-id='cThirdName']","",false, this.CurrentView);
 
            ThirdVATNumber = RPSControlFactory.CreateRPSGridTextBox<Mod347View>("","#a15cf5ef-4eac-4a3b-b7ce-079b33239145 .ag-row[role='row']@ROWINDEX [col-id='cThirdVATNumber']","",false, this.CurrentView);
 
            ThirdCountryISOCode = RPSControlFactory.CreateRPSGridTextBox<Mod347View>("","#a15cf5ef-4eac-4a3b-b7ce-079b33239145 .ag-row[role='row']@ROWINDEX [col-id='cThirdCountryISOCode']","",false, this.CurrentView);
 
            YearTotalAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod347View>("","#a15cf5ef-4eac-4a3b-b7ce-079b33239145 .ag-row[role='row']@ROWINDEX [col-id='cYearTotalAmount']","",false, this.CurrentView);
 
            YearTotalRealizedAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod347View>("","#a15cf5ef-4eac-4a3b-b7ce-079b33239145 .ag-row[role='row']@ROWINDEX [col-id='cYearTotalRealizedAmount']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod347View> Key347 { get; set; } 
        public IRPSGridTextBox<Mod347View> ThirdName { get; set; } 
        public IRPSGridTextBox<Mod347View> ThirdVATNumber { get; set; } 
        public IRPSGridTextBox<Mod347View> ThirdCountryISOCode { get; set; } 
        public IRPSGridTextBox<Mod347View> YearTotalAmount { get; set; } 
        public IRPSGridTextBox<Mod347View> YearTotalRealizedAmount { get; set; } 
                     
    }
 
        public partial class GetMod347SupplierInvoicesCollectionEditor<Mod347View>:RPSCollectionEditor<Mod347View> where Mod347View : class, IView
    {
        public  GetMod347SupplierInvoicesGridView<Mod347View> GridView {get;set;}
    }
    public partial class GetMod347SupplierInvoicesGridView <Mod347View> :  RPSGridView<Mod347View> where Mod347View : class, IView
    {
        public GetMod347SupplierInvoicesGridView(Mod347View currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Subkey347 = RPSControlFactory.CreateRPSGridTextBox<Mod347View>("","#049d2350-5acd-4cec-a1b5-b15c03178211 .ag-row[role='row']@ROWINDEX [col-id='cSubkey347']","",false, this.CurrentView);
 
            TotalAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod347View>("","#049d2350-5acd-4cec-a1b5-b15c03178211 .ag-row[role='row']@ROWINDEX [col-id='cTotalAmount']","",false, this.CurrentView);
 
            Quarter = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod347View>("","#049d2350-5acd-4cec-a1b5-b15c03178211 .ag-row[role='row']@ROWINDEX [col-id='cQuarter']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod347View> Subkey347 { get; set; } 
        public IRPSGridTextBox<Mod347View> TotalAmount { get; set; } 
        public IRPSGridTextBox<Mod347View> Quarter { get; set; } 
                     
    }
 
        public partial class GetMod347SupplierRealizedPaymentsCollectionEditor<Mod347View>:RPSCollectionEditor<Mod347View> where Mod347View : class, IView
    {
        public  GetMod347SupplierRealizedPaymentsGridView<Mod347View> GridView {get;set;}
    }
    public partial class GetMod347SupplierRealizedPaymentsGridView <Mod347View> :  RPSGridView<Mod347View> where Mod347View : class, IView
    {
        public GetMod347SupplierRealizedPaymentsGridView(Mod347View currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            PaidAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<Mod347View>("","#542af0ac-e71b-4ec9-88b6-0e719fe09b50 .ag-row[role='row']@ROWINDEX [col-id='cPaidAmount']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<Mod347View> PaidAmount { get; set; } 
                     
    }
 
    }
  
    

}