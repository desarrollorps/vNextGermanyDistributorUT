    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.AccountStatement
{
    //RPS VERSION 1.0.0.0
    public partial class AccountStatement:Screen
    {
        public AccountStatement():base()
        {
            this.URL = "generalledger.accountstatement";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            AccountStatementQueryView  = new AccountStatementQueryView(this); 
            AccountStatementListDialogView  = new AccountStatementListDialogView(this); 
            AccountStatementQueryView.InitializeControls(); 
            AccountStatementListDialogView.InitializeControls(); 
           
        }
      
            public AccountStatementQueryView AccountStatementQueryView {get; set; } 
            public AccountStatementListDialogView AccountStatementListDialogView {get; set; } 
    }
            
    public partial class AccountStatementQueryView : View
    {
        public AccountStatementQueryView(AccountStatement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDAccount = RPSControlFactory.CreateRPSComboBox<AccountStatementQueryView>("acb0158a-f667-48a2-9a32-01e13ae65374","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<AccountStatementQueryView>("e9b7d4c2-7c9e-4724-a918-4891a852a5a7","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<AccountStatementQueryView>("f0e61af4-c20a-47ea-86c9-ba3482cd004a","","",false, this);
 
            bIncludeLastYearBalance = RPSControlFactory.CreateRPSCheckBox<AccountStatementQueryView>("5133872c-3607-4653-9c57-ac2614629ddf","","",false, this);
 
            bIncludeNullified = RPSControlFactory.CreateRPSCheckBox<AccountStatementQueryView>("1b603a36-c9a9-44a1-bc0b-a63b98e91d26","","",false, this);
 
            bTC = RPSControlFactory.CreateRPSCheckBox<AccountStatementQueryView>("a123c69b-7591-4fe0-9876-e9c881acab24","","",false, this);
 
            OnlyNoReviewed = RPSControlFactory.CreateRPSCheckBox<AccountStatementQueryView>("da5c444b-d0f6-4a80-88a5-e15389381cd8","","",false, this);
 
            optTypes = RPSControlFactory.CreateRPSEnumComboBox<AccountStatementQueryView>("a04ec51b-a1e1-444a-93fb-8b14738b1788","","",false, this);
 
            IDBankAccountCompany = RPSControlFactory.CreateRPSComboBox<AccountStatementQueryView>("40314783-1ff4-45bc-ba30-a81554d0dfd0","","",false, this);
 
            IDVAT = RPSControlFactory.CreateRPSComboBox<AccountStatementQueryView>("a677c110-538d-4de6-9fd9-0ffb623147b6","","",false, this);
 
            IDTaxValue = RPSControlFactory.CreateRPSComboBox<AccountStatementQueryView>("6dc80821-4d3f-4d2a-bbf0-9c8a12ef174c","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<AccountStatementQueryView>("ebafe245-5edc-4df6-b135-8a5007a441b2","","",false, this);
 
            IDCustomerMiscellaneous = RPSControlFactory.CreateRPSComboBox<AccountStatementQueryView>("fe53e56d-3ed7-4465-8060-1c2d7f73e618","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<AccountStatementQueryView>("92798bf7-28c1-4dce-8702-bfdea35fff31","","",false, this);
 
            IDSupplierMiscellaneous = RPSControlFactory.CreateRPSComboBox<AccountStatementQueryView>("c77265ae-ccd1-4fe6-8ce8-85e6bc03c22c","","",false, this);
 
            bUsePostingForBalance = RPSControlFactory.CreateRPSCheckBox<AccountStatementQueryView>("5bedd56f-846a-4e4a-852e-1428d68978c7","","",false, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<AccountStatementQueryView>("8d7f1033-8ce2-4cf4-af59-a01606e85d96","","",false, this);
 
            IDAccount1 = RPSControlFactory.CreateRPSComboBox<AccountStatementQueryView>("11fa9557-85a6-481d-8380-13146cabc9bd","","",true, this);
 
            Extension = RPSControlFactory.CreateRPSTextBox<AccountStatementQueryView>("abcdb94e-82e9-4543-bb33-9e4da0abf018","","",false, this);
 
            ReportCommandButton = RPSControlFactory.CreateRPSButton<AccountStatementQueryView>( "d0f0d491-4fd9-4472-ad4c-c70c6a88baa4","","",this);
 
            AccountStatementListNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<AccountStatementQueryView,AccountStatementListDialogView>("eff0c6d6-ab5b-4504-af00-b829798a3408","","", this,Screen.AccountStatementListDialogView);
 
            ExportToExcelCommandButton = RPSControlFactory.CreateRPSButtonToView<AccountStatementQueryView,AccountStatementListDialogView>("c2bf1daf-ea75-4421-af14-c9ef5d2a230c","","", this,Screen.AccountStatementListDialogView);
 
            PreviousAccountCommandButton = RPSControlFactory.CreateRPSButton<AccountStatementQueryView>( "30bc2003-875e-4ea2-b01e-47fffe556650","","",this);
 
            NetxAccountCommandButton = RPSControlFactory.CreateRPSButton<AccountStatementQueryView>( "ed25555f-2308-4e2b-9026-57bbf04266ff","","",this);
 
            CollectionInit params_AccountStatement = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="452d20be-1b52-47d6-900f-58c921516ed4",CSSSelectorGrid="",XPathGrid=""};
            AccountStatement = RPSControlFactory.RPSCreateCollectionWithGrid<AccountStatementCollectionEditor<AccountStatementQueryView,AccountStatementListDialogView>,AccountStatementQueryView,AccountStatementListDialogView>( params_AccountStatement,this,Screen.AccountStatementListDialogView);
 
            CollectionInit params_ACCTransactionsAnalyticConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="99184add-7ae3-41c0-8579-6450e4dbdd4c",CSSSelectorGrid="",XPathGrid=""};
            ACCTransactionsAnalyticConsult = RPSControlFactory.RPSCreateCollectionWithGrid<ACCTransactionsAnalyticConsultCollectionEditor<AccountStatementQueryView,AccountStatementListDialogView>,AccountStatementQueryView,AccountStatementListDialogView>( params_ACCTransactionsAnalyticConsult,this,Screen.AccountStatementListDialogView);
 
            CollectionInit params_GetBalances = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="40ac0850-5c78-4fbd-93ac-b3b0d9b7d499",CSSSelectorGrid="",XPathGrid=""};
            GetBalances = RPSControlFactory.RPSCreateCollectionWithGrid<GetBalancesCollectionEditor<AccountStatementQueryView,AccountStatementListDialogView>,AccountStatementQueryView,AccountStatementListDialogView>( params_GetBalances,this,Screen.AccountStatementListDialogView);
 
            SectionVouchers = RPSControlFactory.CreateRPSSection<AccountStatementQueryView>( "","ul li[rpsid='098f9a6f-7bc6-4a17-bee2-dcf31a782072']","",this);
 
            SectionBalance = RPSControlFactory.CreateRPSSection<AccountStatementQueryView>( "","ul li[rpsid='dacc5ab9-8cb4-4ee6-8270-9d4f6733864f']","",this);
 

        }
        public IRPSComboBox<AccountStatementQueryView> IDAccount { get; set; } 
        public IRPSTextBox<AccountStatementQueryView> DateFrom { get; set; } 
        public IRPSTextBox<AccountStatementQueryView> DateTo { get; set; } 
        public IRPSCheckbox<AccountStatementQueryView> bIncludeLastYearBalance { get; set; } 
        public IRPSCheckbox<AccountStatementQueryView> bIncludeNullified { get; set; } 
        public IRPSCheckbox<AccountStatementQueryView> bTC { get; set; } 
        public IRPSCheckbox<AccountStatementQueryView> OnlyNoReviewed { get; set; } 
        public IRPSComboBox<AccountStatementQueryView> optTypes { get; set; } 
        public IRPSComboBox<AccountStatementQueryView> IDBankAccountCompany { get; set; } 
        public IRPSComboBox<AccountStatementQueryView> IDVAT { get; set; } 
        public IRPSComboBox<AccountStatementQueryView> IDTaxValue { get; set; } 
        public IRPSComboBox<AccountStatementQueryView> IDCustomer { get; set; } 
        public IRPSComboBox<AccountStatementQueryView> IDCustomerMiscellaneous { get; set; } 
        public IRPSComboBox<AccountStatementQueryView> IDSupplier { get; set; } 
        public IRPSComboBox<AccountStatementQueryView> IDSupplierMiscellaneous { get; set; } 
        public IRPSCheckbox<AccountStatementQueryView> bUsePostingForBalance { get; set; } 
        public IRPSTextBox<AccountStatementQueryView> VATNumber { get; set; } 
        public IRPSComboBox<AccountStatementQueryView> IDAccount1 { get; set; } 
        public IRPSTextBox<AccountStatementQueryView> Extension { get; set; } 
        public IRPSButton<AccountStatementQueryView> ReportCommandButton { get; set; } 
        public IRPSButton<AccountStatementQueryView,AccountStatementListDialogView> AccountStatementListNavigationCommandButton { get; set; } 
        public IRPSButton<AccountStatementQueryView,AccountStatementListDialogView> ExportToExcelCommandButton { get; set; } 
        public IRPSButton<AccountStatementQueryView> PreviousAccountCommandButton { get; set; } 
        public IRPSButton<AccountStatementQueryView> NetxAccountCommandButton { get; set; } 
        public AccountStatementCollectionEditor<AccountStatementQueryView,AccountStatementListDialogView> AccountStatement { get; set; } 
        public ACCTransactionsAnalyticConsultCollectionEditor<AccountStatementQueryView,AccountStatementListDialogView> ACCTransactionsAnalyticConsult { get; set; } 
        public GetBalancesCollectionEditor<AccountStatementQueryView,AccountStatementListDialogView> GetBalances { get; set; } 
        public IRPSSection<AccountStatementQueryView> SectionVouchers { get; set; } 
        public IRPSSection<AccountStatementQueryView> SectionBalance { get; set; } 
        public AccountStatement Screen { get; set; }
        public AccountStatementQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class AccountStatementCollectionEditor<AccountStatementQueryView,AccountStatementListDialogView>:RPSCollectionEditor<AccountStatementQueryView,AccountStatementListDialogView> where AccountStatementQueryView : class, IView where AccountStatementListDialogView : class, IView
    {
        public  AccountStatementGridView<AccountStatementQueryView,AccountStatementListDialogView> GridView {get;set;}
    }
    public partial class AccountStatementGridView <AccountStatementQueryView,AccountStatementListDialogView> :  RPSGridView<AccountStatementQueryView,AccountStatementListDialogView> where AccountStatementQueryView : class, IView where AccountStatementListDialogView : class, IView
    {
        public AccountStatementGridView(AccountStatementQueryView currentView,AccountStatementListDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Extension = RPSControlFactory.CreateRPSGridTextBox<AccountStatementQueryView>("","#452d20be-1b52-47d6-900f-58c921516ed4 .ag-row[role='row']@ROWINDEX [col-id='cExtension']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<AccountStatementQueryView>("","#452d20be-1b52-47d6-900f-58c921516ed4 .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 
            Reviewed = RPSControlFactory.CreateRPSGridCheckBox<AccountStatementQueryView>("","#452d20be-1b52-47d6-900f-58c921516ed4 .ag-row[role='row']@ROWINDEX [col-id='cReviewed']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<AccountStatementQueryView> Extension { get; set; } 
        public IRPSGridTextBox<AccountStatementQueryView> InvoiceDate { get; set; } 
        public IRPSGridCheckbox<AccountStatementQueryView> Reviewed { get; set; } 
                     
    }
 
        public partial class ACCTransactionsAnalyticConsultCollectionEditor<AccountStatementQueryView,AccountStatementListDialogView>:RPSCollectionEditor<AccountStatementQueryView,AccountStatementListDialogView> where AccountStatementQueryView : class, IView where AccountStatementListDialogView : class, IView
    {
        public  ACCTransactionsAnalyticConsultGridView<AccountStatementQueryView,AccountStatementListDialogView> GridView {get;set;}
    }
    public partial class ACCTransactionsAnalyticConsultGridView <AccountStatementQueryView,AccountStatementListDialogView> :  RPSGridView<AccountStatementQueryView,AccountStatementListDialogView> where AccountStatementQueryView : class, IView where AccountStatementListDialogView : class, IView
    {
        public ACCTransactionsAnalyticConsultGridView(AccountStatementQueryView currentView,AccountStatementListDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {

        }
                     
    }
 
        public partial class GetBalancesCollectionEditor<AccountStatementQueryView,AccountStatementListDialogView>:RPSCollectionEditor<AccountStatementQueryView,AccountStatementListDialogView> where AccountStatementQueryView : class, IView where AccountStatementListDialogView : class, IView
    {
        public  GetBalancesGridView<AccountStatementQueryView,AccountStatementListDialogView> GridView {get;set;}
    }
    public partial class GetBalancesGridView <AccountStatementQueryView,AccountStatementListDialogView> :  RPSGridView<AccountStatementQueryView,AccountStatementListDialogView> where AccountStatementQueryView : class, IView where AccountStatementListDialogView : class, IView
    {
        public GetBalancesGridView(AccountStatementQueryView currentView,AccountStatementListDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            PeriodDescription = RPSControlFactory.CreateRPSGridTextBox<AccountStatementQueryView>("","#40ac0850-5c78-4fbd-93ac-b3b0d9b7d499 .ag-row[role='row']@ROWINDEX [col-id='cPeriodDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<AccountStatementQueryView> PeriodDescription { get; set; } 
                     
    }
 
    }
  
            
    public partial class AccountStatementListDialogView : View
    {
        public AccountStatementListDialogView(AccountStatement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIDateFrom = RPSControlFactory.CreateRPSTextBox<AccountStatementListDialogView>("df8928ca-9311-499c-a4ba-56ac3c568d42","","",true, this);
 
            UIDateTo = RPSControlFactory.CreateRPSTextBox<AccountStatementListDialogView>("e945b4e9-5486-4b9d-aefd-9accc795a7b8","","",true, this);
 
            UILstAccount = RPSControlFactory.CreateRPSCollectionComboBox<AccountStatementListDialogView>("2951f7d2-ff1b-442d-b7d4-34683d8f6edc","","",false, this);
 
            UILStAccountGroup = RPSControlFactory.CreateRPSCollectionComboBox<AccountStatementListDialogView>("a59e882c-07fd-47b4-9cc8-1a46ad68dbd1","","",false, this);
 
            UILstAccountCluster = RPSControlFactory.CreateRPSCollectionComboBox<AccountStatementListDialogView>("351fa1ad-2d36-49e2-b253-75fe59c7f1fc","","",false, this);
 
            bIncludeLastYearBalance = RPSControlFactory.CreateRPSCheckBox<AccountStatementListDialogView>("82b2f52e-5b16-4d66-a121-1fb1c6ad4642","","",false, this);
 
            bIncludeNullified = RPSControlFactory.CreateRPSCheckBox<AccountStatementListDialogView>("073a9fb1-ecba-47a1-91c5-17cade65260a","","",false, this);
 
            bTC = RPSControlFactory.CreateRPSCheckBox<AccountStatementListDialogView>("28826bc1-bc3e-4d5d-bce3-7e179c64020d","","",false, this);
 

        }
        public IRPSTextBox<AccountStatementListDialogView> UIDateFrom { get; set; } 
        public IRPSTextBox<AccountStatementListDialogView> UIDateTo { get; set; } 
        public IRPSCollectionComboBox<AccountStatementListDialogView> UILstAccount { get; set; } 
        public IRPSCollectionComboBox<AccountStatementListDialogView> UILStAccountGroup { get; set; } 
        public IRPSCollectionComboBox<AccountStatementListDialogView> UILstAccountCluster { get; set; } 
        public IRPSCheckbox<AccountStatementListDialogView> bIncludeLastYearBalance { get; set; } 
        public IRPSCheckbox<AccountStatementListDialogView> bIncludeNullified { get; set; } 
        public IRPSCheckbox<AccountStatementListDialogView> bTC { get; set; } 
        public AccountStatement Screen { get; set; }
        public AccountStatementListDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}