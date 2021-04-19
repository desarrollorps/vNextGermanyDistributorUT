    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.OrderImportExpenses
{
    //RPS VERSION 1.0.0.0
    public partial class OrderImportExpenses:Screen
    {
        public OrderImportExpenses():base()
        {
            this.URL = "purchase.orderimportexpenses";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            OrderVMQueryView  = new OrderVMQueryView(this); 
            OrderVMEntityView  = new OrderVMEntityView(this); 
            OrderImportExpensesView  = new OrderImportExpensesView(this); 
            OrderVMQueryView.InitializeControls(); 
            OrderVMEntityView.InitializeControls(); 
            OrderImportExpensesView.InitializeControls(); 
           
        }
      
            public OrderVMQueryView OrderVMQueryView {get; set; } 
            public OrderVMEntityView OrderVMEntityView {get; set; } 
            public OrderImportExpensesView OrderImportExpensesView {get; set; } 
    }
            
    public partial class OrderVMQueryView : View
    {
        public OrderVMQueryView(OrderImportExpenses screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<OrderVMQueryView,OrderVMEntityView>( this,Screen.OrderVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<OrderVMQueryView>( this);
 
            CollectionInit params_OrderImportExpenses = new CollectionInit(){IDDescriptor = "17e1689b-3ab7-4522-9244-7e20cdad28f4",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="46cee781-c39c-4173-aed7-c13e5e3c157f",CSSSelectorGrid="",XPathGrid=""};
            OrderImportExpenses = RPSControlFactory.RPSCreateCollectionWithGrid<OrderImportExpensesCollectionEditor<OrderVMQueryView,OrderVMEntityView>,OrderVMQueryView,OrderVMEntityView>( params_OrderImportExpenses,this,Screen.OrderVMEntityView);
 

        }
        public IRPSButton<OrderVMQueryView,OrderVMEntityView> NewButton { get; set; } 
        public IRPSButton<OrderVMQueryView> ConsultButton { get; set; } 
        public OrderImportExpensesCollectionEditor<OrderVMQueryView,OrderVMEntityView> OrderImportExpenses { get; set; } 
        public OrderImportExpenses Screen { get; set; }
        public OrderVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class OrderImportExpensesCollectionEditor<OrderVMQueryView,OrderVMEntityView>:RPSCollectionEditor<OrderVMQueryView,OrderVMEntityView> where OrderVMQueryView : class, IView where OrderVMEntityView : class, IView
    {
        public  OrderImportExpensesGridView<OrderVMQueryView,OrderVMEntityView> GridView {get;set;}
    }
    public partial class OrderImportExpensesGridView <OrderVMQueryView,OrderVMEntityView> :  RPSGridView<OrderVMQueryView,OrderVMEntityView> where OrderVMQueryView : class, IView where OrderVMEntityView : class, IView
    {
        public OrderImportExpensesGridView(OrderVMQueryView currentView,OrderVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Order_OrderDate = RPSControlFactory.CreateRPSGridTextBox<OrderVMQueryView>("","#46cee781-c39c-4173-aed7-c13e5e3c157f .ag-row[role='row']@ROWINDEX [col-id='cOrder_OrderDate']","",false, this.CurrentView);
 
            Order_StatusImport = RPSControlFactory.CreateRPSGridTextBox<OrderVMQueryView>("","#46cee781-c39c-4173-aed7-c13e5e3c157f .ag-row[role='row']@ROWINDEX [col-id='cOrder_StatusImport']","",false, this.CurrentView);
 
            Order_ImportClosedDate = RPSControlFactory.CreateRPSGridTextBox<OrderVMQueryView>("","#46cee781-c39c-4173-aed7-c13e5e3c157f .ag-row[role='row']@ROWINDEX [col-id='cOrder_ImportClosedDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<OrderVMQueryView> Order_OrderDate { get; set; } 
        public IRPSGridTextBox<OrderVMQueryView> Order_StatusImport { get; set; } 
        public IRPSGridTextBox<OrderVMQueryView> Order_ImportClosedDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class OrderVMEntityView : View
    {
        public OrderVMEntityView(OrderImportExpenses screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<OrderVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<OrderVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<OrderVMEntityView,OrderVMQueryView>( this,Screen.OrderVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<OrderVMEntityView,OrderVMQueryView>( this,Screen.OrderVMQueryView);
 
            Status = RPSControlFactory.CreateRPSFormattedTextBox<OrderVMEntityView>("2e47262b-da43-415f-a287-8f5dd6bbac6d","","",true, this);
 
            StatusImport = RPSControlFactory.CreateRPSEnumComboBox<OrderVMEntityView>("9c5ebd34-9667-45d2-ba58-f57d6836701a","","",true, this);
 
            ImportClosedDate = RPSControlFactory.CreateRPSTextBox<OrderVMEntityView>("1d6aff72-7762-427f-a503-1a76b0ffb23c","","",false, this);
 
            UITotalFOBReal = RPSControlFactory.CreateRPSFormattedTextBox<OrderVMEntityView>("c5dcaacc-c444-4267-a3ad-b9ee27e4f1cf","","",false, this);
 
            UITotalInsurancesReal = RPSControlFactory.CreateRPSFormattedTextBox<OrderVMEntityView>("2ea24f8c-4d6f-4385-8ea9-f90d39995391","","",false, this);
 
            UITotalFreightsReal = RPSControlFactory.CreateRPSFormattedTextBox<OrderVMEntityView>("b4ac7806-c620-47f7-a5bf-6d77b1f1e3a7","","",false, this);
 
            UITotalPermissionsReal = RPSControlFactory.CreateRPSFormattedTextBox<OrderVMEntityView>("9f5c9658-5e81-455c-acf0-e5fb9e33244d","","",false, this);
 
            UITotalBankingReal = RPSControlFactory.CreateRPSFormattedTextBox<OrderVMEntityView>("bfa1130d-b0bf-47d5-9f50-f5d7b8b4bbb1","","",false, this);
 
            UITotalExternalReal = RPSControlFactory.CreateRPSFormattedTextBox<OrderVMEntityView>("b6244aab-6b91-4e5e-8e0b-0dc0faed943c","","",false, this);
 
            UITotalOthersReal = RPSControlFactory.CreateRPSFormattedTextBox<OrderVMEntityView>("024eb833-0765-47b4-bf02-c37baa3e853a","","",false, this);
 
            UITotalCIFReal = RPSControlFactory.CreateRPSFormattedTextBox<OrderVMEntityView>("45d354cb-83b8-4a83-b5ab-0970cc9fe7b2","","",false, this);
 
            UITotalTariffReal = RPSControlFactory.CreateRPSFormattedTextBox<OrderVMEntityView>("97f41b13-b12c-450b-b8da-bf29d3e0b53b","","",false, this);
 
            UITotalGastosReal = RPSControlFactory.CreateRPSFormattedTextBox<OrderVMEntityView>("9abed7e4-2ba9-4e31-beee-e094fca61821","","",false, this);
 
            UITotalFOB = RPSControlFactory.CreateRPSFormattedTextBox<OrderVMEntityView>("5128ebfd-b322-4b82-8dc5-0e9a7fc39672","","",false, this);
 
            UITotalInsurances = RPSControlFactory.CreateRPSFormattedTextBox<OrderVMEntityView>("4422ae53-fe0f-4643-a0f4-43625e18d626","","",false, this);
 
            UITotalFreights = RPSControlFactory.CreateRPSFormattedTextBox<OrderVMEntityView>("2f6d197a-d5ea-4207-98b1-6560fc59d1d1","","",false, this);
 
            UITotalPermissions = RPSControlFactory.CreateRPSFormattedTextBox<OrderVMEntityView>("83ad34c8-60f9-477b-8095-8ff01a4e17a7","","",false, this);
 
            UITotalBanking = RPSControlFactory.CreateRPSFormattedTextBox<OrderVMEntityView>("88a43cbe-3d67-4136-89d9-ab95917a0542","","",false, this);
 
            UITotalExternal = RPSControlFactory.CreateRPSFormattedTextBox<OrderVMEntityView>("a7176e3d-bab4-45e7-9f8c-e8a4faf5197f","","",false, this);
 
            UITotalOthers = RPSControlFactory.CreateRPSFormattedTextBox<OrderVMEntityView>("d3b21334-b00a-4397-834c-44c805ae111b","","",false, this);
 
            UITotalCIF = RPSControlFactory.CreateRPSFormattedTextBox<OrderVMEntityView>("637474f3-69f8-47f7-9111-dad1330855ca","","",false, this);
 
            UITotalTariff = RPSControlFactory.CreateRPSFormattedTextBox<OrderVMEntityView>("cb712aab-cc49-4a80-97d3-df4e4e101cda","","",false, this);
 
            UITotalGastos = RPSControlFactory.CreateRPSFormattedTextBox<OrderVMEntityView>("e5a9fe06-838a-42db-9e58-7c60f4b1890a","","",false, this);
 
            Difference = RPSControlFactory.CreateRPSFormattedTextBox<OrderVMEntityView>("6f9300db-7a65-4fe7-a310-c4d110e5b0fc","","",false, this);
 
            ExecuteGetImportExpensesButton = RPSControlFactory.CreateRPSButton<OrderVMEntityView>( "b756769a-2ed5-41b2-9072-53fd77bb9ea3","","",this);
 
            CalcularGastosImportacionCommandButton = RPSControlFactory.CreateRPSButton<OrderVMEntityView>( "d92edde3-c8f9-403f-ad38-73fd739d4b6c","","",this);
 
            ExecuteCloseImportExpensesButton = RPSControlFactory.CreateRPSButton<OrderVMEntityView>( "64eea299-14d1-47a3-a2b9-8b2546900927","","",this);
 
            ReportCommandButton = RPSControlFactory.CreateRPSButton<OrderVMEntityView>( "c85482c3-42a6-4332-a621-792bf9b0ab43","","",this);
 
            CollectionInit params_OrderImportExpensess = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b05baddd-75c3-4940-a348-d6bd54c67bd8",CSSSelectorGrid="",XPathGrid=""};
            OrderImportExpensess = RPSControlFactory.RPSCreateCollectionWithGrid<OrderImportExpensessCollectionEditor<OrderVMEntityView,OrderImportExpensesView>,OrderVMEntityView,OrderImportExpensesView>( params_OrderImportExpensess,this,Screen.OrderImportExpensesView);
 

        }
        public IRPSSaveButton<OrderVMEntityView> SaveButton { get; set; } 
        public IRPSButton<OrderVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<OrderVMEntityView,OrderVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<OrderVMEntityView,OrderVMQueryView> BackButton { get; set; } 
        public IRPSTextBox<OrderVMEntityView> Status { get; set; } 
        public IRPSComboBox<OrderVMEntityView> StatusImport { get; set; } 
        public IRPSTextBox<OrderVMEntityView> ImportClosedDate { get; set; } 
        public IRPSTextBox<OrderVMEntityView> UITotalFOBReal { get; set; } 
        public IRPSTextBox<OrderVMEntityView> UITotalInsurancesReal { get; set; } 
        public IRPSTextBox<OrderVMEntityView> UITotalFreightsReal { get; set; } 
        public IRPSTextBox<OrderVMEntityView> UITotalPermissionsReal { get; set; } 
        public IRPSTextBox<OrderVMEntityView> UITotalBankingReal { get; set; } 
        public IRPSTextBox<OrderVMEntityView> UITotalExternalReal { get; set; } 
        public IRPSTextBox<OrderVMEntityView> UITotalOthersReal { get; set; } 
        public IRPSTextBox<OrderVMEntityView> UITotalCIFReal { get; set; } 
        public IRPSTextBox<OrderVMEntityView> UITotalTariffReal { get; set; } 
        public IRPSTextBox<OrderVMEntityView> UITotalGastosReal { get; set; } 
        public IRPSTextBox<OrderVMEntityView> UITotalFOB { get; set; } 
        public IRPSTextBox<OrderVMEntityView> UITotalInsurances { get; set; } 
        public IRPSTextBox<OrderVMEntityView> UITotalFreights { get; set; } 
        public IRPSTextBox<OrderVMEntityView> UITotalPermissions { get; set; } 
        public IRPSTextBox<OrderVMEntityView> UITotalBanking { get; set; } 
        public IRPSTextBox<OrderVMEntityView> UITotalExternal { get; set; } 
        public IRPSTextBox<OrderVMEntityView> UITotalOthers { get; set; } 
        public IRPSTextBox<OrderVMEntityView> UITotalCIF { get; set; } 
        public IRPSTextBox<OrderVMEntityView> UITotalTariff { get; set; } 
        public IRPSTextBox<OrderVMEntityView> UITotalGastos { get; set; } 
        public IRPSTextBox<OrderVMEntityView> Difference { get; set; } 
        public IRPSButton<OrderVMEntityView> ExecuteGetImportExpensesButton { get; set; } 
        public IRPSButton<OrderVMEntityView> CalcularGastosImportacionCommandButton { get; set; } 
        public IRPSButton<OrderVMEntityView> ExecuteCloseImportExpensesButton { get; set; } 
        public IRPSButton<OrderVMEntityView> ReportCommandButton { get; set; } 
        public OrderImportExpensessCollectionEditor<OrderVMEntityView,OrderImportExpensesView> OrderImportExpensess { get; set; } 
        public OrderImportExpenses Screen { get; set; }
        public OrderVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class OrderImportExpensessCollectionEditor<OrderVMEntityView,OrderImportExpensesView>:RPSCollectionEditor<OrderVMEntityView,OrderImportExpensesView> where OrderVMEntityView : class, IView where OrderImportExpensesView : class, IView
    {
        public  OrderImportExpensessGridView<OrderVMEntityView,OrderImportExpensesView> GridView {get;set;}
    }
    public partial class OrderImportExpensessGridView <OrderVMEntityView,OrderImportExpensesView> :  RPSGridView<OrderVMEntityView,OrderImportExpensesView> where OrderVMEntityView : class, IView where OrderImportExpensesView : class, IView
    {
        public OrderImportExpensessGridView(OrderVMEntityView currentView,OrderImportExpensesView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDInvoice = RPSControlFactory.CreateRPSGridComboBox<OrderVMEntityView>("","#b05baddd-75c3-4940-a348-d6bd54c67bd8 .ag-row[role='row']@ROWINDEX [col-id='cIDInvoice']","",false, this.CurrentView);
 
            IDSupplier = RPSControlFactory.CreateRPSGridComboBox<OrderVMEntityView>("","#b05baddd-75c3-4940-a348-d6bd54c67bd8 .ag-row[role='row']@ROWINDEX [col-id='cIDSupplier']","",false, this.CurrentView);
 
            InvoiceCurrencyAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderVMEntityView>("","#b05baddd-75c3-4940-a348-d6bd54c67bd8 .ag-row[role='row']@ROWINDEX [col-id='cInvoiceCurrencyAmount']","",false, this.CurrentView);
 
            InvoiceCurrencyCompanyAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderVMEntityView>("","#b05baddd-75c3-4940-a348-d6bd54c67bd8 .ag-row[role='row']@ROWINDEX [col-id='cInvoiceCurrencyCompanyAmount']","",false, this.CurrentView);
 
            ExpenseType = RPSControlFactory.CreateRPSGridEnumComboBox<OrderVMEntityView>("","#b05baddd-75c3-4940-a348-d6bd54c67bd8 .ag-row[role='row']@ROWINDEX [col-id='cExpenseType']","",true, this.CurrentView);
 
            ApportionmentType = RPSControlFactory.CreateRPSGridEnumComboBox<OrderVMEntityView>("","#b05baddd-75c3-4940-a348-d6bd54c67bd8 .ag-row[role='row']@ROWINDEX [col-id='cApportionmentType']","",true, this.CurrentView);
 
            BreakDownPar = RPSControlFactory.CreateRPSGridCheckBox<OrderVMEntityView>("","#b05baddd-75c3-4940-a348-d6bd54c67bd8 .ag-row[role='row']@ROWINDEX [col-id='cBreakDownPar']","",true, this.CurrentView);
 
            ManValue = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderVMEntityView>("","#b05baddd-75c3-4940-a348-d6bd54c67bd8 .ag-row[role='row']@ROWINDEX [col-id='cManValue']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<OrderVMEntityView> IDInvoice { get; set; } 
        public IRPSGridComboBox<OrderVMEntityView> IDSupplier { get; set; } 
        public IRPSGridTextBox<OrderVMEntityView> InvoiceCurrencyAmount { get; set; } 
        public IRPSGridTextBox<OrderVMEntityView> InvoiceCurrencyCompanyAmount { get; set; } 
        public IRPSGridComboBox<OrderVMEntityView> ExpenseType { get; set; } 
        public IRPSGridComboBox<OrderVMEntityView> ApportionmentType { get; set; } 
        public IRPSGridCheckbox<OrderVMEntityView> BreakDownPar { get; set; } 
        public IRPSGridTextBox<OrderVMEntityView> ManValue { get; set; } 
                     
    }
 
    }
  
            
    public partial class OrderImportExpensesView : View
    {
        public OrderImportExpensesView(OrderImportExpenses screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<OrderImportExpensesView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<OrderImportExpensesView,OrderVMEntityView>( this,Screen.OrderVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<OrderImportExpensesView,OrderVMEntityView>( this,Screen.OrderVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<OrderImportExpensesView,OrderVMEntityView>( this,Screen.OrderVMEntityView);
 
            NumLine = RPSControlFactory.CreateRPSFormattedTextBox<OrderImportExpensesView>("f9538515-a7d0-4713-afa9-ea2fa4ebd01d","","",true, this);
 
            IDInvoice = RPSControlFactory.CreateRPSComboBox<OrderImportExpensesView>("cc5088a5-b220-42f5-a23f-09b497172bf3","","",false, this);
 
            Ordenation = RPSControlFactory.CreateRPSFormattedTextBox<OrderImportExpensesView>("a236baa3-aede-41f4-88f8-9be2b4a95919","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<OrderImportExpensesView>("00de67c2-bbd5-4c2d-a242-b36188a0012c","","",false, this);
 
            InvoiceDate = RPSControlFactory.CreateRPSTextBox<OrderImportExpensesView>("1bbe8511-e9b4-4ab0-b913-07d286bf9f6b","","",false, this);
 
            InvoiceCurrencyAmount = RPSControlFactory.CreateRPSFormattedTextBox<OrderImportExpensesView>("9ccb9872-24d0-480c-a827-25e0efe213fd","","",false, this);
 
            InvoiceCurrencyCompanyAmount = RPSControlFactory.CreateRPSFormattedTextBox<OrderImportExpensesView>("9a010d1b-d0d3-40a9-899d-56645648136e","","",false, this);
 
            ExpenseType = RPSControlFactory.CreateRPSEnumComboBox<OrderImportExpensesView>("877c0a66-4b19-4b48-890e-2f3873b91e64","","",true, this);
 
            ApportionmentType = RPSControlFactory.CreateRPSEnumComboBox<OrderImportExpensesView>("67623255-9a89-4869-8e7b-388d2282dd58","","",true, this);
 
            BreakDownPar = RPSControlFactory.CreateRPSCheckBox<OrderImportExpensesView>("65e079fe-fca0-44ab-adda-abd777aadfac","","",true, this);
 
            ManValue = RPSControlFactory.CreateRPSFormattedTextBox<OrderImportExpensesView>("53f55d9a-d78c-4e51-a140-2be070253044","","",true, this);
 
            CollectionInit params_OrderImportExpensesTariffs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="12cc2b1f-7b87-4676-9874-2edf54a4212c",CSSSelectorGrid="",XPathGrid=""};
            OrderImportExpensesTariffs = RPSControlFactory.RPSCreateCollectionWithGrid<OrderImportExpensesTariffsCollectionEditor<OrderImportExpensesView>,OrderImportExpensesView>( params_OrderImportExpensesTariffs,this);
 
            GeneralData = RPSControlFactory.CreateRPSSection<OrderImportExpensesView>( "","ul li[rpsid='8535061f-ce42-4d25-9e1e-f50bc913bb99']","",this);
 
            OrderImportExpenseTariff = RPSControlFactory.CreateRPSSection<OrderImportExpensesView>( "","ul li[rpsid='442f85c9-8ec4-4038-a898-c49b002d2f4e']","",this);
 

        }
        public IRPSButton<OrderImportExpensesView> DeleteButton { get; set; } 
        public IRPSButton<OrderImportExpensesView,OrderVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<OrderImportExpensesView,OrderVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<OrderImportExpensesView,OrderVMEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<OrderImportExpensesView> NumLine { get; set; } 
        public IRPSComboBox<OrderImportExpensesView> IDInvoice { get; set; } 
        public IRPSTextBox<OrderImportExpensesView> Ordenation { get; set; } 
        public IRPSComboBox<OrderImportExpensesView> IDSupplier { get; set; } 
        public IRPSTextBox<OrderImportExpensesView> InvoiceDate { get; set; } 
        public IRPSTextBox<OrderImportExpensesView> InvoiceCurrencyAmount { get; set; } 
        public IRPSTextBox<OrderImportExpensesView> InvoiceCurrencyCompanyAmount { get; set; } 
        public IRPSComboBox<OrderImportExpensesView> ExpenseType { get; set; } 
        public IRPSComboBox<OrderImportExpensesView> ApportionmentType { get; set; } 
        public IRPSCheckbox<OrderImportExpensesView> BreakDownPar { get; set; } 
        public IRPSTextBox<OrderImportExpensesView> ManValue { get; set; } 
        public OrderImportExpensesTariffsCollectionEditor<OrderImportExpensesView> OrderImportExpensesTariffs { get; set; } 
        public IRPSSection<OrderImportExpensesView> GeneralData { get; set; } 
        public IRPSSection<OrderImportExpensesView> OrderImportExpenseTariff { get; set; } 
        public OrderImportExpenses Screen { get; set; }
        public OrderImportExpensesView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class OrderImportExpensesTariffsCollectionEditor<OrderImportExpensesView>:RPSCollectionEditor<OrderImportExpensesView> where OrderImportExpensesView : class, IView
    {
        public  OrderImportExpensesTariffsGridView<OrderImportExpensesView> GridView {get;set;}
    }
    public partial class OrderImportExpensesTariffsGridView <OrderImportExpensesView> :  RPSGridView<OrderImportExpensesView> where OrderImportExpensesView : class, IView
    {
        public OrderImportExpensesTariffsGridView(OrderImportExpensesView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDImportTariffType = RPSControlFactory.CreateRPSGridComboBox<OrderImportExpensesView>("","#12cc2b1f-7b87-4676-9874-2edf54a4212c .ag-row[role='row']@ROWINDEX [col-id='cIDImportTariffType']","",true, this.CurrentView);
 
            Value = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderImportExpensesView>("","#12cc2b1f-7b87-4676-9874-2edf54a4212c .ag-row[role='row']@ROWINDEX [col-id='cValue']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<OrderImportExpensesView> IDImportTariffType { get; set; } 
        public IRPSGridTextBox<OrderImportExpensesView> Value { get; set; } 
                     
    }
 
    }
  
    

}