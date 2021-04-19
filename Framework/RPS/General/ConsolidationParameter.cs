    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.ConsolidationParameter
{
    //RPS VERSION 1.0.0.0
    public partial class ConsolidationParameter:Screen
    {
        public ConsolidationParameter():base()
        {
            this.URL = "general.consolidationparameter";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ConsolidationParameterView  = new ConsolidationParameterView(this); 
            ParameterGLMView  = new ParameterGLMView(this); 
            CompanyCONView  = new CompanyCONView(this); 
            DimensionCONDialogView  = new DimensionCONDialogView(this); 
            NewCompanyCONDialogView  = new NewCompanyCONDialogView(this); 
            LoadAccountsChildDialogView  = new LoadAccountsChildDialogView(this); 
            CheckAccountChildDialogView  = new CheckAccountChildDialogView(this); 
            ConsolidationParameterView.InitializeControls(); 
            ParameterGLMView.InitializeControls(); 
            CompanyCONView.InitializeControls(); 
            DimensionCONDialogView.InitializeControls(); 
            NewCompanyCONDialogView.InitializeControls(); 
            LoadAccountsChildDialogView.InitializeControls(); 
            CheckAccountChildDialogView.InitializeControls(); 
           
        }
      
            public ConsolidationParameterView ConsolidationParameterView {get; set; } 
            public ParameterGLMView ParameterGLMView {get; set; } 
            public CompanyCONView CompanyCONView {get; set; } 
            public DimensionCONDialogView DimensionCONDialogView {get; set; } 
            public NewCompanyCONDialogView NewCompanyCONDialogView {get; set; } 
            public LoadAccountsChildDialogView LoadAccountsChildDialogView {get; set; } 
            public CheckAccountChildDialogView CheckAccountChildDialogView {get; set; } 
    }
            
    public partial class ConsolidationParameterView : View
    {
        public ConsolidationParameterView(ConsolidationParameter screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            LoadAccountsChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ConsolidationParameterView,LoadAccountsChildDialogView>("6367dd6c-6227-44a5-aa49-768fcde37814","","", this,Screen.LoadAccountsChildDialogView);
 

        }
        public IRPSButton<ConsolidationParameterView,LoadAccountsChildDialogView> LoadAccountsChildNavigationCommandButton { get; set; } 
        public ConsolidationParameter Screen { get; set; }
        public ConsolidationParameterView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ParameterGLMView : View
    {
        public ParameterGLMView(ConsolidationParameter screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDVoucherTypeTransfer = RPSControlFactory.CreateRPSComboBox<ParameterGLMView>("6039e97f-8a61-4bdc-9709-9e1828ed36a8","","",false, this);
 
            IDAccountDifferences = RPSControlFactory.CreateRPSComboBox<ParameterGLMView>("96cad3d2-b1e9-4915-b810-dee91d212b68","","",false, this);
 
            TransferGLMethod = RPSControlFactory.CreateRPSEnumComboBox<ParameterGLMView>("c36c9bf4-ea78-439a-9238-ab65723d1af0","","",false, this);
 
            NewCompanyCONNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ParameterGLMView,NewCompanyCONDialogView>("7b7a262c-260a-42be-a12f-9d6de6dc7e3b","","", this,Screen.NewCompanyCONDialogView);
 
            CollectionInit params_CompanyCONs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0c078d68-075c-40e2-81ca-a47ce1ef28dc",CSSSelectorGrid="",XPathGrid=""};
            CompanyCONs = RPSControlFactory.RPSCreateCollectionWithGrid<CompanyCONsCollectionEditor<ParameterGLMView,CompanyCONView>,ParameterGLMView,CompanyCONView>( params_CompanyCONs,this,Screen.CompanyCONView);
 
            SectionConsolidation = RPSControlFactory.CreateRPSSection<ParameterGLMView>( "","ul li[rpsid='b9213d06-538e-44c0-a678-52356a336728']","",this);
 
            SectionCompany = RPSControlFactory.CreateRPSSection<ParameterGLMView>( "","ul li[rpsid='49272e23-11ee-4b3a-b5b8-555f119e9229']","",this);
 

        }
        public IRPSComboBox<ParameterGLMView> IDVoucherTypeTransfer { get; set; } 
        public IRPSComboBox<ParameterGLMView> IDAccountDifferences { get; set; } 
        public IRPSComboBox<ParameterGLMView> TransferGLMethod { get; set; } 
        public IRPSButton<ParameterGLMView,NewCompanyCONDialogView> NewCompanyCONNavigationCommandButton { get; set; } 
        public CompanyCONsCollectionEditor<ParameterGLMView,CompanyCONView> CompanyCONs { get; set; } 
        public IRPSSection<ParameterGLMView> SectionConsolidation { get; set; } 
        public IRPSSection<ParameterGLMView> SectionCompany { get; set; } 
        public ConsolidationParameter Screen { get; set; }
        public ParameterGLMView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CompanyCONsCollectionEditor<ParameterGLMView,CompanyCONView>:RPSCollectionEditor<ParameterGLMView,CompanyCONView> where ParameterGLMView : class, IView where CompanyCONView : class, IView
    {
        public  CompanyCONsGridView<ParameterGLMView,CompanyCONView> GridView {get;set;}
    }
    public partial class CompanyCONsGridView <ParameterGLMView,CompanyCONView> :  RPSGridView<ParameterGLMView,CompanyCONView> where ParameterGLMView : class, IView where CompanyCONView : class, IView
    {
        public CompanyCONsGridView(ParameterGLMView currentView,CompanyCONView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodCompanyCON = RPSControlFactory.CreateRPSGridComboBox<ParameterGLMView>("","#0c078d68-075c-40e2-81ca-a47ce1ef28dc .ag-row[role='row']@ROWINDEX [col-id='cCodCompanyCON']","",true, this.CurrentView);
 
            MethodConsolidation = RPSControlFactory.CreateRPSGridEnumComboBox<ParameterGLMView>("","#0c078d68-075c-40e2-81ca-a47ce1ef28dc .ag-row[role='row']@ROWINDEX [col-id='cMethodConsolidation']","",true, this.CurrentView);
 
            HoldingPercentage = RPSControlFactory.CreateRPSGridFormattedTextBox<ParameterGLMView>("","#0c078d68-075c-40e2-81ca-a47ce1ef28dc .ag-row[role='row']@ROWINDEX [col-id='cHoldingPercentage']","",true, this.CurrentView);
 
            IDVoucherSeriesBookTransfer = RPSControlFactory.CreateRPSGridComboBox<ParameterGLMView>("","#0c078d68-075c-40e2-81ca-a47ce1ef28dc .ag-row[role='row']@ROWINDEX [col-id='cIDVoucherSeriesBookTransfer']","",true, this.CurrentView);
 
            IDCurrency = RPSControlFactory.CreateRPSGridComboBox<ParameterGLMView>("","#0c078d68-075c-40e2-81ca-a47ce1ef28dc .ag-row[role='row']@ROWINDEX [col-id='cIDCurrency']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<ParameterGLMView> CodCompanyCON { get; set; } 
        public IRPSGridComboBox<ParameterGLMView> MethodConsolidation { get; set; } 
        public IRPSGridTextBox<ParameterGLMView> HoldingPercentage { get; set; } 
        public IRPSGridComboBox<ParameterGLMView> IDVoucherSeriesBookTransfer { get; set; } 
        public IRPSGridComboBox<ParameterGLMView> IDCurrency { get; set; } 
                     
    }
 
    }
  
            
    public partial class CompanyCONView : View
    {
        public CompanyCONView(ConsolidationParameter screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CompanyCONView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CompanyCONView,ParameterGLMView>( this,Screen.ParameterGLMView);
 
            BackButton = RPSControlFactory.RPSBackButton<CompanyCONView,ParameterGLMView>( this,Screen.ParameterGLMView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CompanyCONView,ParameterGLMView>( this,Screen.ParameterGLMView);
 
            CodCompanyCON = RPSControlFactory.CreateRPSComboBox<CompanyCONView>("ea210aa0-ff42-40ec-b9d1-4dd63efc534a","","",true, this);
 
            MethodConsolidation = RPSControlFactory.CreateRPSEnumComboBox<CompanyCONView>("a93bc8f7-0eb3-4e2c-9401-d051299d57bd","","",true, this);
 
            HoldingPercentage = RPSControlFactory.CreateRPSFormattedTextBox<CompanyCONView>("aabd73e8-1dde-4dd9-9d5b-c4ad3e0cf8f1","","",true, this);
 
            CodACCType = RPSControlFactory.CreateRPSEnumComboBox<CompanyCONView>("f3e395ee-acb6-492c-8ce7-0775db0fd214","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<CompanyCONView>("5ecb2389-67ca-4030-a5a0-23bbd8e5853a","","",true, this);
 
            IDVoucherSeriesBookTransfer = RPSControlFactory.CreateRPSComboBox<CompanyCONView>("fabbec22-a76c-42b8-89d3-9e992191dade","","",true, this);
 
            NoMoveOpenJournal = RPSControlFactory.CreateRPSCheckBox<CompanyCONView>("cefd5403-7d0e-4a06-8be7-72cf61c28123","","",true, this);
 
            NoMoveCloseJournal = RPSControlFactory.CreateRPSCheckBox<CompanyCONView>("90932b79-71b4-4c0b-9dbe-275b74125f30","","",true, this);
 
            ExchangeTypeTransferB = RPSControlFactory.CreateRPSEnumComboBox<CompanyCONView>("ae9daca4-7b5a-4c22-85cc-865b54578d6d","","",true, this);
 
            ExchangeTypeTransferPyG = RPSControlFactory.CreateRPSEnumComboBox<CompanyCONView>("b5f19fe3-472f-485b-b048-37461e3be51c","","",true, this);
 
            ExchangeTypeTransferFP = RPSControlFactory.CreateRPSEnumComboBox<CompanyCONView>("0cbe5e94-80f9-44fd-a788-5b40b6ecf377","","",true, this);
 
            IDAccountDif = RPSControlFactory.CreateRPSComboBox<CompanyCONView>("c20b1bce-6a25-4723-8377-ef41f057a758","","",false, this);
 
            IDAccountDifEquity = RPSControlFactory.CreateRPSComboBox<CompanyCONView>("6cc43d09-29dc-406a-a754-df4885f2bbfc","","",false, this);
 
            EliminateShareHoldersFunds = RPSControlFactory.CreateRPSCheckBox<CompanyCONView>("9a3ad0b3-97eb-4620-b9be-a8e729799516","","",true, this);
 
            AccShareHoldersFunds = RPSControlFactory.CreateRPSTextBox<CompanyCONView>("6a95e2dd-abe5-4a9b-a798-764956018444","","",false, this);
 
            EliminateStockHolding = RPSControlFactory.CreateRPSCheckBox<CompanyCONView>("9ff39fed-4896-404e-bfb4-be9bd036a321","","",true, this);
 
            AccStockHolding = RPSControlFactory.CreateRPSTextBox<CompanyCONView>("b01a5296-98ef-4c25-9145-6e1326be61a7","","",false, this);
 
            EliminateAccPurchase = RPSControlFactory.CreateRPSCheckBox<CompanyCONView>("4ef49b8e-eff3-4fb7-9e32-ad10cc5a9a4d","","",true, this);
 
            AccPurchaseIC = RPSControlFactory.CreateRPSTextBox<CompanyCONView>("7cae83e0-f71b-40b0-86ab-06e1830866a9","","",false, this);
 
            EliminateAccSales = RPSControlFactory.CreateRPSCheckBox<CompanyCONView>("6389bf0d-f48c-43cc-ae1e-3c4a885c9bdc","","",true, this);
 
            AccSalesIC = RPSControlFactory.CreateRPSTextBox<CompanyCONView>("91169237-1700-479c-aaab-76dc6adbc1f0","","",false, this);
 
            EliminateAccSupplierIC = RPSControlFactory.CreateRPSCheckBox<CompanyCONView>("d12ad834-51a0-4569-bce8-a1743f47909e","","",true, this);
 
            AccSupplierIC = RPSControlFactory.CreateRPSTextBox<CompanyCONView>("598c42c7-e0c6-4ae6-8e36-f509bbdc3a53","","",false, this);
 
            EliminateAccCustomerIC = RPSControlFactory.CreateRPSCheckBox<CompanyCONView>("568a365b-a1ef-47a0-8f83-4386565aa7ed","","",true, this);
 
            AccCustomerIC = RPSControlFactory.CreateRPSTextBox<CompanyCONView>("7eaf98e7-04c7-4517-9559-1f3a026bc140","","",false, this);
 
            CheckAccountChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<CompanyCONView,CheckAccountChildDialogView>("28636e0f-b508-4079-8186-65359caef793","","", this,Screen.CheckAccountChildDialogView);
 
            DeleteCompanyCONCommandButton = RPSControlFactory.CreateRPSButton<CompanyCONView>( "38f22da4-af0d-4d6b-a83c-86642eeeef7e","","",this);
 
            CollectionInit params_AccountCONs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0ab10217-67cd-4fd0-a43e-60ac870aa60b",CSSSelectorGrid="",XPathGrid=""};
            AccountCONs = RPSControlFactory.RPSCreateCollectionWithGrid<AccountCONsCollectionEditor<CompanyCONView,DimensionCONDialogView>,CompanyCONView,DimensionCONDialogView>( params_AccountCONs,this,Screen.DimensionCONDialogView);
 
            CollectionInit params_GLMDimensionCONs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="99894c85-40bf-4316-9639-cf21511e9784",CSSSelectorGrid="",XPathGrid=""};
            GLMDimensionCONs = RPSControlFactory.RPSCreateCollectionWithGrid<GLMDimensionCONsCollectionEditor<CompanyCONView,DimensionCONDialogView>,CompanyCONView,DimensionCONDialogView>( params_GLMDimensionCONs,this,Screen.DimensionCONDialogView);
 
            CollectionInit params_BudgetCONs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="22bd85f0-fc54-45fa-ae87-f43b50510187",CSSSelectorGrid="",XPathGrid=""};
            BudgetCONs = RPSControlFactory.RPSCreateCollectionWithGrid<BudgetCONsCollectionEditor<CompanyCONView,DimensionCONDialogView>,CompanyCONView,DimensionCONDialogView>( params_BudgetCONs,this,Screen.DimensionCONDialogView);
 
            SectionCompanyCONs = RPSControlFactory.CreateRPSSection<CompanyCONView>( "","ul li[rpsid='fb28da14-fe88-496f-8dc2-73ce0f26a058']","",this);
 
            SectionAccounts = RPSControlFactory.CreateRPSSection<CompanyCONView>( "","ul li[rpsid='5c0c26ab-8b25-43dc-845f-c7871ed0486a']","",this);
 
            SectionDimension = RPSControlFactory.CreateRPSSection<CompanyCONView>( "","ul li[rpsid='ddf601c7-000c-42f5-9459-86ec84fefac1']","",this);
 
            SectionBudget = RPSControlFactory.CreateRPSSection<CompanyCONView>( "","ul li[rpsid='7865f663-3a3e-4ea7-aabe-899383a8360f']","",this);
 

        }
        public IRPSButton<CompanyCONView> DeleteButton { get; set; } 
        public IRPSButton<CompanyCONView,ParameterGLMView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CompanyCONView,ParameterGLMView> BackButton { get; set; } 
        public IRPSAcceptButton<CompanyCONView,ParameterGLMView> AcceptButton { get; set; } 
        public IRPSComboBox<CompanyCONView> CodCompanyCON { get; set; } 
        public IRPSComboBox<CompanyCONView> MethodConsolidation { get; set; } 
        public IRPSTextBox<CompanyCONView> HoldingPercentage { get; set; } 
        public IRPSComboBox<CompanyCONView> CodACCType { get; set; } 
        public IRPSComboBox<CompanyCONView> IDCurrency { get; set; } 
        public IRPSComboBox<CompanyCONView> IDVoucherSeriesBookTransfer { get; set; } 
        public IRPSCheckbox<CompanyCONView> NoMoveOpenJournal { get; set; } 
        public IRPSCheckbox<CompanyCONView> NoMoveCloseJournal { get; set; } 
        public IRPSComboBox<CompanyCONView> ExchangeTypeTransferB { get; set; } 
        public IRPSComboBox<CompanyCONView> ExchangeTypeTransferPyG { get; set; } 
        public IRPSComboBox<CompanyCONView> ExchangeTypeTransferFP { get; set; } 
        public IRPSComboBox<CompanyCONView> IDAccountDif { get; set; } 
        public IRPSComboBox<CompanyCONView> IDAccountDifEquity { get; set; } 
        public IRPSCheckbox<CompanyCONView> EliminateShareHoldersFunds { get; set; } 
        public IRPSTextBox<CompanyCONView> AccShareHoldersFunds { get; set; } 
        public IRPSCheckbox<CompanyCONView> EliminateStockHolding { get; set; } 
        public IRPSTextBox<CompanyCONView> AccStockHolding { get; set; } 
        public IRPSCheckbox<CompanyCONView> EliminateAccPurchase { get; set; } 
        public IRPSTextBox<CompanyCONView> AccPurchaseIC { get; set; } 
        public IRPSCheckbox<CompanyCONView> EliminateAccSales { get; set; } 
        public IRPSTextBox<CompanyCONView> AccSalesIC { get; set; } 
        public IRPSCheckbox<CompanyCONView> EliminateAccSupplierIC { get; set; } 
        public IRPSTextBox<CompanyCONView> AccSupplierIC { get; set; } 
        public IRPSCheckbox<CompanyCONView> EliminateAccCustomerIC { get; set; } 
        public IRPSTextBox<CompanyCONView> AccCustomerIC { get; set; } 
        public IRPSButton<CompanyCONView,CheckAccountChildDialogView> CheckAccountChildNavigationCommandButton { get; set; } 
        public IRPSButton<CompanyCONView> DeleteCompanyCONCommandButton { get; set; } 
        public AccountCONsCollectionEditor<CompanyCONView,DimensionCONDialogView> AccountCONs { get; set; } 
        public GLMDimensionCONsCollectionEditor<CompanyCONView,DimensionCONDialogView> GLMDimensionCONs { get; set; } 
        public BudgetCONsCollectionEditor<CompanyCONView,DimensionCONDialogView> BudgetCONs { get; set; } 
        public IRPSSection<CompanyCONView> SectionCompanyCONs { get; set; } 
        public IRPSSection<CompanyCONView> SectionAccounts { get; set; } 
        public IRPSSection<CompanyCONView> SectionDimension { get; set; } 
        public IRPSSection<CompanyCONView> SectionBudget { get; set; } 
        public ConsolidationParameter Screen { get; set; }
        public CompanyCONView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class AccountCONsCollectionEditor<CompanyCONView,DimensionCONDialogView>:RPSCollectionEditor<CompanyCONView,DimensionCONDialogView> where CompanyCONView : class, IView where DimensionCONDialogView : class, IView
    {
        public  AccountCONsGridView<CompanyCONView,DimensionCONDialogView> GridView {get;set;}
    }
    public partial class AccountCONsGridView <CompanyCONView,DimensionCONDialogView> :  RPSGridView<CompanyCONView,DimensionCONDialogView> where CompanyCONView : class, IView where DimensionCONDialogView : class, IView
    {
        public AccountCONsGridView(CompanyCONView currentView,DimensionCONDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodPrefixAcc = RPSControlFactory.CreateRPSGridTextBox<CompanyCONView>("","#0ab10217-67cd-4fd0-a43e-60ac870aa60b .ag-row[role='row']@ROWINDEX [col-id='cCodPrefixAcc']","",true, this.CurrentView);
 
            IDAccount = RPSControlFactory.CreateRPSGridComboBox<CompanyCONView>("","#0ab10217-67cd-4fd0-a43e-60ac870aa60b .ag-row[role='row']@ROWINDEX [col-id='cIDAccount']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<CompanyCONView>("","#0ab10217-67cd-4fd0-a43e-60ac870aa60b .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CompanyCONView> CodPrefixAcc { get; set; } 
        public IRPSGridComboBox<CompanyCONView> IDAccount { get; set; } 
        public IRPSGridTextBox<CompanyCONView> Description { get; set; } 
                     
    }
 
        public partial class GLMDimensionCONsCollectionEditor<CompanyCONView,DimensionCONDialogView>:RPSCollectionEditor<CompanyCONView,DimensionCONDialogView> where CompanyCONView : class, IView where DimensionCONDialogView : class, IView
    {
        public  GLMDimensionCONsGridView<CompanyCONView,DimensionCONDialogView> GridView {get;set;}
    }
    public partial class GLMDimensionCONsGridView <CompanyCONView,DimensionCONDialogView> :  RPSGridView<CompanyCONView,DimensionCONDialogView> where CompanyCONView : class, IView where DimensionCONDialogView : class, IView
    {
        public GLMDimensionCONsGridView(CompanyCONView currentView,DimensionCONDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDDimensionCompanyCON = RPSControlFactory.CreateRPSGridComboBox<CompanyCONView>("","#99894c85-40bf-4316-9639-cf21511e9784 .ag-row[role='row']@ROWINDEX [col-id='cIDDimensionCompanyCON']","",true, this.CurrentView);
 
            IDDimension = RPSControlFactory.CreateRPSGridComboBox<CompanyCONView>("","#99894c85-40bf-4316-9639-cf21511e9784 .ag-row[role='row']@ROWINDEX [col-id='cIDDimension']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<CompanyCONView>("","#99894c85-40bf-4316-9639-cf21511e9784 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            LinkToViewDimensionValues = RPSControlFactory.CreateRPSGridButton<CompanyCONView>( "","#99894c85-40bf-4316-9639-cf21511e9784 .ag-row[role='row']@ROWINDEX [col-id='cLinkToViewDimensionValues']","",this.CurrentView);
 

        }
        public IRPSGridComboBox<CompanyCONView> IDDimensionCompanyCON { get; set; } 
        public IRPSGridComboBox<CompanyCONView> IDDimension { get; set; } 
        public IRPSGridTextBox<CompanyCONView> Description { get; set; } 
        public IRPSGridButton<CompanyCONView> LinkToViewDimensionValues { get; set; } 
                     
    }
 
        public partial class BudgetCONsCollectionEditor<CompanyCONView,DimensionCONDialogView>:RPSCollectionEditor<CompanyCONView,DimensionCONDialogView> where CompanyCONView : class, IView where DimensionCONDialogView : class, IView
    {
        public  BudgetCONsGridView<CompanyCONView,DimensionCONDialogView> GridView {get;set;}
    }
    public partial class BudgetCONsGridView <CompanyCONView,DimensionCONDialogView> :  RPSGridView<CompanyCONView,DimensionCONDialogView> where CompanyCONView : class, IView where DimensionCONDialogView : class, IView
    {
        public BudgetCONsGridView(CompanyCONView currentView,DimensionCONDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDBudgetCompanyCON = RPSControlFactory.CreateRPSGridComboBox<CompanyCONView>("","#22bd85f0-fc54-45fa-ae87-f43b50510187 .ag-row[role='row']@ROWINDEX [col-id='cIDBudgetCompanyCON']","",true, this.CurrentView);
 
            IDBudget = RPSControlFactory.CreateRPSGridComboBox<CompanyCONView>("","#22bd85f0-fc54-45fa-ae87-f43b50510187 .ag-row[role='row']@ROWINDEX [col-id='cIDBudget']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<CompanyCONView>("","#22bd85f0-fc54-45fa-ae87-f43b50510187 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<CompanyCONView> IDBudgetCompanyCON { get; set; } 
        public IRPSGridComboBox<CompanyCONView> IDBudget { get; set; } 
        public IRPSGridTextBox<CompanyCONView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class DimensionCONDialogView : View
    {
        public DimensionCONDialogView(ConsolidationParameter screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_DimValueCONs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3cdeffde-83a3-4942-8e4a-3e97ba1fa7e2",CSSSelectorGrid="",XPathGrid=""};
            DimValueCONs = RPSControlFactory.RPSCreateCollectionWithGrid<DimValueCONsCollectionEditor<DimensionCONDialogView>,DimensionCONDialogView>( params_DimValueCONs,this);
 

        }
        public DimValueCONsCollectionEditor<DimensionCONDialogView> DimValueCONs { get; set; } 
        public ConsolidationParameter Screen { get; set; }
        public DimensionCONDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DimValueCONsCollectionEditor<DimensionCONDialogView>:RPSCollectionEditor<DimensionCONDialogView> where DimensionCONDialogView : class, IView
    {
        public  DimValueCONsGridView<DimensionCONDialogView> GridView {get;set;}
    }
    public partial class DimValueCONsGridView <DimensionCONDialogView> :  RPSGridView<DimensionCONDialogView> where DimensionCONDialogView : class, IView
    {
        public DimValueCONsGridView(DimensionCONDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodPrefixDimValue = RPSControlFactory.CreateRPSGridTextBox<DimensionCONDialogView>("","#3cdeffde-83a3-4942-8e4a-3e97ba1fa7e2 .ag-row[role='row']@ROWINDEX [col-id='cCodPrefixDimValue']","",true, this.CurrentView);
 
            IDDimValue = RPSControlFactory.CreateRPSGridComboBox<DimensionCONDialogView>("","#3cdeffde-83a3-4942-8e4a-3e97ba1fa7e2 .ag-row[role='row']@ROWINDEX [col-id='cIDDimValue']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<DimensionCONDialogView>("","#3cdeffde-83a3-4942-8e4a-3e97ba1fa7e2 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<DimensionCONDialogView> CodPrefixDimValue { get; set; } 
        public IRPSGridComboBox<DimensionCONDialogView> IDDimValue { get; set; } 
        public IRPSGridTextBox<DimensionCONDialogView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class NewCompanyCONDialogView : View
    {
        public NewCompanyCONDialogView(ConsolidationParameter screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CodCompanyCON = RPSControlFactory.CreateRPSComboBox<NewCompanyCONDialogView>("5f5cf24a-0036-4d21-bc2c-02b32b92ac77","","",true, this);
 
            MethodConsolidation = RPSControlFactory.CreateRPSEnumComboBox<NewCompanyCONDialogView>("d76333e6-c8b6-460a-b3a2-6ea34ff5d2a6","","",true, this);
 
            HoldingPercentage = RPSControlFactory.CreateRPSFormattedTextBox<NewCompanyCONDialogView>("7a71184c-4903-4e5e-af77-31f54d53e790","","",true, this);
 
            CodACCType = RPSControlFactory.CreateRPSEnumComboBox<NewCompanyCONDialogView>("cf73bc06-6d80-4759-8ff0-c9f3e12f9266","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<NewCompanyCONDialogView>("59133fb9-bf66-4933-9841-465f9f5c3f38","","",true, this);
 
            IDVoucherSeriesBookTransfer = RPSControlFactory.CreateRPSComboBox<NewCompanyCONDialogView>("b240113f-41e0-422c-9766-13fa1e524491","","",true, this);
 

        }
        public IRPSComboBox<NewCompanyCONDialogView> CodCompanyCON { get; set; } 
        public IRPSComboBox<NewCompanyCONDialogView> MethodConsolidation { get; set; } 
        public IRPSTextBox<NewCompanyCONDialogView> HoldingPercentage { get; set; } 
        public IRPSComboBox<NewCompanyCONDialogView> CodACCType { get; set; } 
        public IRPSComboBox<NewCompanyCONDialogView> IDCurrency { get; set; } 
        public IRPSComboBox<NewCompanyCONDialogView> IDVoucherSeriesBookTransfer { get; set; } 
        public ConsolidationParameter Screen { get; set; }
        public NewCompanyCONDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class LoadAccountsChildDialogView : View
    {
        public LoadAccountsChildDialogView(ConsolidationParameter screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public ConsolidationParameter Screen { get; set; }
        public LoadAccountsChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CheckAccountChildDialogView : View
    {
        public CheckAccountChildDialogView(ConsolidationParameter screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Company1 = RPSControlFactory.CreateRPSComboBox<CheckAccountChildDialogView>("b453d55a-ef76-4de2-81d3-111a1a2ca0f9","","",false, this);
 
            CodCompanyCON = RPSControlFactory.CreateRPSComboBox<CheckAccountChildDialogView>("04edcdfd-2f46-45ac-97c7-2d408650e065","","",true, this);
 
            CodACCType = RPSControlFactory.CreateRPSEnumComboBox<CheckAccountChildDialogView>("f72f30c8-ee28-4182-aaaa-272282646914","","",true, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<CheckAccountChildDialogView>("f73d4edb-52cc-40aa-9e9b-71a7e1ca3e9e","","",true, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<CheckAccountChildDialogView>("9072aa0d-8710-4dd3-a51e-2315ff9f7ba5","","",true, this);
 
            All = RPSControlFactory.CreateRPSOption<CheckAccountChildDialogView>( "e24111a0-95dd-4040-8799-54a635e50d44","","",this);
 
            OnlyErrors = RPSControlFactory.CreateRPSOption<CheckAccountChildDialogView>( "e2d40277-2656-43fe-aeae-b02565012408","","",this);
 
            CollectionInit params_GetConsolidationAccountMap = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="14bd0c6d-3009-4ef2-89ec-518e7fedfb92",CSSSelectorGrid="",XPathGrid=""};
            GetConsolidationAccountMap = RPSControlFactory.RPSCreateCollectionWithGrid<GetConsolidationAccountMapCollectionEditor<CheckAccountChildDialogView>,CheckAccountChildDialogView>( params_GetConsolidationAccountMap,this);
 

        }
        public IRPSComboBox<CheckAccountChildDialogView> Company1 { get; set; } 
        public IRPSComboBox<CheckAccountChildDialogView> CodCompanyCON { get; set; } 
        public IRPSComboBox<CheckAccountChildDialogView> CodACCType { get; set; } 
        public IRPSTextBox<CheckAccountChildDialogView> DateFrom { get; set; } 
        public IRPSTextBox<CheckAccountChildDialogView> DateTo { get; set; } 
        public IRPSOption<CheckAccountChildDialogView> All { get; set; } 
        public IRPSOption<CheckAccountChildDialogView> OnlyErrors { get; set; } 
        public GetConsolidationAccountMapCollectionEditor<CheckAccountChildDialogView> GetConsolidationAccountMap { get; set; } 
        public ConsolidationParameter Screen { get; set; }
        public CheckAccountChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetConsolidationAccountMapCollectionEditor<CheckAccountChildDialogView>:RPSCollectionEditor<CheckAccountChildDialogView> where CheckAccountChildDialogView : class, IView
    {
        public  GetConsolidationAccountMapGridView<CheckAccountChildDialogView> GridView {get;set;}
    }
    public partial class GetConsolidationAccountMapGridView <CheckAccountChildDialogView> :  RPSGridView<CheckAccountChildDialogView> where CheckAccountChildDialogView : class, IView
    {
        public GetConsolidationAccountMapGridView(CheckAccountChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MensError = RPSControlFactory.CreateRPSGridTextBox<CheckAccountChildDialogView>("","#14bd0c6d-3009-4ef2-89ec-518e7fedfb92 .ag-row[role='row']@ROWINDEX [col-id='cMensError']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CheckAccountChildDialogView> MensError { get; set; } 
                     
    }
 
    }
  
    

}