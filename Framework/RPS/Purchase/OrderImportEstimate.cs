    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.OrderImportEstimate
{
    //RPS VERSION 1.0.0.0
    public partial class OrderImportEstimate:Screen
    {
        public OrderImportEstimate():base()
        {
            this.URL = "purchase.orderimportestimate";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            OrderVMQueryView  = new OrderVMQueryView(this); 
            OrderVMEntityView  = new OrderVMEntityView(this); 
            OrderImportEstimateView  = new OrderImportEstimateView(this); 
            CalcularGastosImportacionDialogView  = new CalcularGastosImportacionDialogView(this); 
            OrderVMQueryView.InitializeControls(); 
            OrderVMEntityView.InitializeControls(); 
            OrderImportEstimateView.InitializeControls(); 
            CalcularGastosImportacionDialogView.InitializeControls(); 
           
        }
      
            public OrderVMQueryView OrderVMQueryView {get; set; } 
            public OrderVMEntityView OrderVMEntityView {get; set; } 
            public OrderImportEstimateView OrderImportEstimateView {get; set; } 
            public CalcularGastosImportacionDialogView CalcularGastosImportacionDialogView {get; set; } 
    }
            
    public partial class OrderVMQueryView : View
    {
        public OrderVMQueryView(OrderImportEstimate screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<OrderVMQueryView,OrderVMEntityView>( this,Screen.OrderVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<OrderVMQueryView>( this);
 
            CollectionInit params_OrderImportEstimate = new CollectionInit(){IDDescriptor = "97d022bf-6c7a-43d6-8d95-e0e17ef719f3",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4674c184-5d35-43b4-aeb7-dff11f54ffce",CSSSelectorGrid="",XPathGrid=""};
            OrderImportEstimate = RPSControlFactory.RPSCreateCollectionWithGrid<OrderImportEstimateCollectionEditor<OrderVMQueryView,OrderVMEntityView>,OrderVMQueryView,OrderVMEntityView>( params_OrderImportEstimate,this,Screen.OrderVMEntityView);
 

        }
        public IRPSButton<OrderVMQueryView,OrderVMEntityView> NewButton { get; set; } 
        public IRPSButton<OrderVMQueryView> ConsultButton { get; set; } 
        public OrderImportEstimateCollectionEditor<OrderVMQueryView,OrderVMEntityView> OrderImportEstimate { get; set; } 
        public OrderImportEstimate Screen { get; set; }
        public OrderVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class OrderImportEstimateCollectionEditor<OrderVMQueryView,OrderVMEntityView>:RPSCollectionEditor<OrderVMQueryView,OrderVMEntityView> where OrderVMQueryView : class, IView where OrderVMEntityView : class, IView
    {
        public  OrderImportEstimateGridView<OrderVMQueryView,OrderVMEntityView> GridView {get;set;}
    }
    public partial class OrderImportEstimateGridView <OrderVMQueryView,OrderVMEntityView> :  RPSGridView<OrderVMQueryView,OrderVMEntityView> where OrderVMQueryView : class, IView where OrderVMEntityView : class, IView
    {
        public OrderImportEstimateGridView(OrderVMQueryView currentView,OrderVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Order_OrderDate = RPSControlFactory.CreateRPSGridTextBox<OrderVMQueryView>("","#4674c184-5d35-43b4-aeb7-dff11f54ffce .ag-row[role='row']@ROWINDEX [col-id='cOrder_OrderDate']","",false, this.CurrentView);
 
            Order_StatusImportEstimate = RPSControlFactory.CreateRPSGridTextBox<OrderVMQueryView>("","#4674c184-5d35-43b4-aeb7-dff11f54ffce .ag-row[role='row']@ROWINDEX [col-id='cOrder_StatusImportEstimate']","",false, this.CurrentView);
 
            Order_ImportEstimateDate = RPSControlFactory.CreateRPSGridTextBox<OrderVMQueryView>("","#4674c184-5d35-43b4-aeb7-dff11f54ffce .ag-row[role='row']@ROWINDEX [col-id='cOrder_ImportEstimateDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<OrderVMQueryView> Order_OrderDate { get; set; } 
        public IRPSGridTextBox<OrderVMQueryView> Order_StatusImportEstimate { get; set; } 
        public IRPSGridTextBox<OrderVMQueryView> Order_ImportEstimateDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class OrderVMEntityView : View
    {
        public OrderVMEntityView(OrderImportEstimate screen) : base()
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
 
            StatusImportEstimate = RPSControlFactory.CreateRPSEnumComboBox<OrderVMEntityView>("d5eb2b9c-0d5a-46db-ae4b-1986fc72e81c","","",true, this);
 
            ImportEstimateDate = RPSControlFactory.CreateRPSTextBox<OrderVMEntityView>("70528ee4-7c41-4b55-8c52-704ef1c6fc18","","",false, this);
 
            ImportEstimateClosedDate = RPSControlFactory.CreateRPSTextBox<OrderVMEntityView>("ba0128d7-92b0-4cb2-8e34-d63c79afa456","","",false, this);
 
            UITotalGastos = RPSControlFactory.CreateRPSFormattedTextBox<OrderVMEntityView>("1d61930e-0bc5-41a9-95d3-ae3626521acb","","",false, this);
 
            UITotalFOB = RPSControlFactory.CreateRPSFormattedTextBox<OrderVMEntityView>("3e846b61-a377-4871-a206-a9f6a789322e","","",false, this);
 
            UITotalInsurances = RPSControlFactory.CreateRPSFormattedTextBox<OrderVMEntityView>("c3ada2a5-18e7-4b5c-ac42-a4ea832d6a5f","","",false, this);
 
            UITotalFreights = RPSControlFactory.CreateRPSFormattedTextBox<OrderVMEntityView>("0b6b96ec-15c6-49c2-b62a-bafe25463c4a","","",false, this);
 
            UITotalCIF = RPSControlFactory.CreateRPSFormattedTextBox<OrderVMEntityView>("1376aef1-7a6f-4a2c-8185-94f1886256a8","","",false, this);
 
            UITotalExternal = RPSControlFactory.CreateRPSFormattedTextBox<OrderVMEntityView>("8b37b083-909d-452f-bd77-a772ade03556","","",false, this);
 
            UITotalBanking = RPSControlFactory.CreateRPSFormattedTextBox<OrderVMEntityView>("23c557e1-2d8a-4875-b58b-63e1e6ee023a","","",false, this);
 
            UITotalOthers = RPSControlFactory.CreateRPSFormattedTextBox<OrderVMEntityView>("96055d3f-fd0f-4114-9e7b-db2d213c556a","","",false, this);
 
            UITotalTariff = RPSControlFactory.CreateRPSFormattedTextBox<OrderVMEntityView>("cbc24592-1386-4570-ac20-841ac1feedd1","","",false, this);
 
            UITotalPermissions = RPSControlFactory.CreateRPSFormattedTextBox<OrderVMEntityView>("fddaf91a-0905-488b-bde8-e56bcde6f701","","",false, this);
 
            CalcularGastosImportacionNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<OrderVMEntityView,CalcularGastosImportacionDialogView>("aff1cf51-5543-403b-b0d6-090b55c5da34","","", this,Screen.CalcularGastosImportacionDialogView);
 
            ExecuteCloseImportEstimateButton = RPSControlFactory.CreateRPSButton<OrderVMEntityView>( "a451c372-122a-4a28-9dad-4a7919266173","","",this);
 
            ExecuteOpenImportEstimateButton = RPSControlFactory.CreateRPSButton<OrderVMEntityView>( "0d3a8b2c-6b57-4399-be4f-752c390c5cd8","","",this);
 
            ReportCommandButton = RPSControlFactory.CreateRPSButton<OrderVMEntityView>( "91d6ac69-e9f2-4c6e-a539-5bd00cb12522","","",this);
 
            CollectionInit params_OrderImportEstimates = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="59f5e382-a0b5-4948-8ae3-fe734a93a42d",CSSSelectorGrid="",XPathGrid=""};
            OrderImportEstimates = RPSControlFactory.RPSCreateCollectionWithGrid<OrderImportEstimatesCollectionEditor<OrderVMEntityView,OrderImportEstimateView>,OrderVMEntityView,OrderImportEstimateView>( params_OrderImportEstimates,this,Screen.OrderImportEstimateView);
 
            CollectionInit params_OrderLines = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f980e17e-f1a3-4571-8cf6-713bb994b872",CSSSelectorGrid="",XPathGrid=""};
            OrderLines = RPSControlFactory.RPSCreateCollectionWithGrid<OrderLinesCollectionEditor<OrderVMEntityView,OrderImportEstimateView>,OrderVMEntityView,OrderImportEstimateView>( params_OrderLines,this,Screen.OrderImportEstimateView);
 

        }
        public IRPSSaveButton<OrderVMEntityView> SaveButton { get; set; } 
        public IRPSButton<OrderVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<OrderVMEntityView,OrderVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<OrderVMEntityView,OrderVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<OrderVMEntityView> StatusImportEstimate { get; set; } 
        public IRPSTextBox<OrderVMEntityView> ImportEstimateDate { get; set; } 
        public IRPSTextBox<OrderVMEntityView> ImportEstimateClosedDate { get; set; } 
        public IRPSTextBox<OrderVMEntityView> UITotalGastos { get; set; } 
        public IRPSTextBox<OrderVMEntityView> UITotalFOB { get; set; } 
        public IRPSTextBox<OrderVMEntityView> UITotalInsurances { get; set; } 
        public IRPSTextBox<OrderVMEntityView> UITotalFreights { get; set; } 
        public IRPSTextBox<OrderVMEntityView> UITotalCIF { get; set; } 
        public IRPSTextBox<OrderVMEntityView> UITotalExternal { get; set; } 
        public IRPSTextBox<OrderVMEntityView> UITotalBanking { get; set; } 
        public IRPSTextBox<OrderVMEntityView> UITotalOthers { get; set; } 
        public IRPSTextBox<OrderVMEntityView> UITotalTariff { get; set; } 
        public IRPSTextBox<OrderVMEntityView> UITotalPermissions { get; set; } 
        public IRPSButton<OrderVMEntityView,CalcularGastosImportacionDialogView> CalcularGastosImportacionNavigationCommandButton { get; set; } 
        public IRPSButton<OrderVMEntityView> ExecuteCloseImportEstimateButton { get; set; } 
        public IRPSButton<OrderVMEntityView> ExecuteOpenImportEstimateButton { get; set; } 
        public IRPSButton<OrderVMEntityView> ReportCommandButton { get; set; } 
        public OrderImportEstimatesCollectionEditor<OrderVMEntityView,OrderImportEstimateView> OrderImportEstimates { get; set; } 
        public OrderLinesCollectionEditor<OrderVMEntityView,OrderImportEstimateView> OrderLines { get; set; } 
        public OrderImportEstimate Screen { get; set; }
        public OrderVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class OrderImportEstimatesCollectionEditor<OrderVMEntityView,OrderImportEstimateView>:RPSCollectionEditor<OrderVMEntityView,OrderImportEstimateView> where OrderVMEntityView : class, IView where OrderImportEstimateView : class, IView
    {
        public  OrderImportEstimatesGridView<OrderVMEntityView,OrderImportEstimateView> GridView {get;set;}
    }
    public partial class OrderImportEstimatesGridView <OrderVMEntityView,OrderImportEstimateView> :  RPSGridView<OrderVMEntityView,OrderImportEstimateView> where OrderVMEntityView : class, IView where OrderImportEstimateView : class, IView
    {
        public OrderImportEstimatesGridView(OrderVMEntityView currentView,OrderImportEstimateView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ExpenseType = RPSControlFactory.CreateRPSGridEnumComboBox<OrderVMEntityView>("","#59f5e382-a0b5-4948-8ae3-fe734a93a42d .ag-row[role='row']@ROWINDEX [col-id='cExpenseType']","",true, this.CurrentView);
 
            IDImportDocumentType = RPSControlFactory.CreateRPSGridComboBox<OrderVMEntityView>("","#59f5e382-a0b5-4948-8ae3-fe734a93a42d .ag-row[role='row']@ROWINDEX [col-id='cIDImportDocumentType']","",true, this.CurrentView);
 
            ApportionmentType = RPSControlFactory.CreateRPSGridEnumComboBox<OrderVMEntityView>("","#59f5e382-a0b5-4948-8ae3-fe734a93a42d .ag-row[role='row']@ROWINDEX [col-id='cApportionmentType']","",true, this.CurrentView);
 
            BreakDownPar = RPSControlFactory.CreateRPSGridCheckBox<OrderVMEntityView>("","#59f5e382-a0b5-4948-8ae3-fe734a93a42d .ag-row[role='row']@ROWINDEX [col-id='cBreakDownPar']","",true, this.CurrentView);
 
            PorcCalc = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderVMEntityView>("","#59f5e382-a0b5-4948-8ae3-fe734a93a42d .ag-row[role='row']@ROWINDEX [col-id='cPorcCalc']","",true, this.CurrentView);
 
            ManValue = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderVMEntityView>("","#59f5e382-a0b5-4948-8ae3-fe734a93a42d .ag-row[role='row']@ROWINDEX [col-id='cManValue']","",true, this.CurrentView);
 
            CalculatedValue = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderVMEntityView>("","#59f5e382-a0b5-4948-8ae3-fe734a93a42d .ag-row[role='row']@ROWINDEX [col-id='cCalculatedValue']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<OrderVMEntityView> ExpenseType { get; set; } 
        public IRPSGridComboBox<OrderVMEntityView> IDImportDocumentType { get; set; } 
        public IRPSGridComboBox<OrderVMEntityView> ApportionmentType { get; set; } 
        public IRPSGridCheckbox<OrderVMEntityView> BreakDownPar { get; set; } 
        public IRPSGridTextBox<OrderVMEntityView> PorcCalc { get; set; } 
        public IRPSGridTextBox<OrderVMEntityView> ManValue { get; set; } 
        public IRPSGridTextBox<OrderVMEntityView> CalculatedValue { get; set; } 
                     
    }
 
        public partial class OrderLinesCollectionEditor<OrderVMEntityView,OrderImportEstimateView>:RPSCollectionEditor<OrderVMEntityView,OrderImportEstimateView> where OrderVMEntityView : class, IView where OrderImportEstimateView : class, IView
    {
        public  OrderLinesGridView<OrderVMEntityView,OrderImportEstimateView> GridView {get;set;}
    }
    public partial class OrderLinesGridView <OrderVMEntityView,OrderImportEstimateView> :  RPSGridView<OrderVMEntityView,OrderImportEstimateView> where OrderVMEntityView : class, IView where OrderImportEstimateView : class, IView
    {
        public OrderLinesGridView(OrderVMEntityView currentView,OrderImportEstimateView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<OrderVMEntityView>("","#f980e17e-f1a3-4571-8cf6-713bb994b872 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",false, this.CurrentView);
 
            FOB = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderVMEntityView>("","#f980e17e-f1a3-4571-8cf6-713bb994b872 .ag-row[role='row']@ROWINDEX [col-id='cFOB']","",true, this.CurrentView);
 
            IDImportTariffType = RPSControlFactory.CreateRPSGridComboBox<OrderVMEntityView>("","#f980e17e-f1a3-4571-8cf6-713bb994b872 .ag-row[role='row']@ROWINDEX [col-id='cIDImportTariffType']","",false, this.CurrentView);
 
            NetMass = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderVMEntityView>("","#f980e17e-f1a3-4571-8cf6-713bb994b872 .ag-row[role='row']@ROWINDEX [col-id='cNetMass']","",true, this.CurrentView);
 
            InsurancesCost = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderVMEntityView>("","#f980e17e-f1a3-4571-8cf6-713bb994b872 .ag-row[role='row']@ROWINDEX [col-id='cInsurancesCost']","",true, this.CurrentView);
 
            FreightsCost = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderVMEntityView>("","#f980e17e-f1a3-4571-8cf6-713bb994b872 .ag-row[role='row']@ROWINDEX [col-id='cFreightsCost']","",true, this.CurrentView);
 
            PermissionsCost = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderVMEntityView>("","#f980e17e-f1a3-4571-8cf6-713bb994b872 .ag-row[role='row']@ROWINDEX [col-id='cPermissionsCost']","",true, this.CurrentView);
 
            BankingCost = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderVMEntityView>("","#f980e17e-f1a3-4571-8cf6-713bb994b872 .ag-row[role='row']@ROWINDEX [col-id='cBankingCost']","",true, this.CurrentView);
 
            OthersCost = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderVMEntityView>("","#f980e17e-f1a3-4571-8cf6-713bb994b872 .ag-row[role='row']@ROWINDEX [col-id='cOthersCost']","",true, this.CurrentView);
 
            ExternalCost = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderVMEntityView>("","#f980e17e-f1a3-4571-8cf6-713bb994b872 .ag-row[role='row']@ROWINDEX [col-id='cExternalCost']","",true, this.CurrentView);
 
            TariffCost = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderVMEntityView>("","#f980e17e-f1a3-4571-8cf6-713bb994b872 .ag-row[role='row']@ROWINDEX [col-id='cTariffCost']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<OrderVMEntityView> IDArticle { get; set; } 
        public IRPSGridTextBox<OrderVMEntityView> FOB { get; set; } 
        public IRPSGridComboBox<OrderVMEntityView> IDImportTariffType { get; set; } 
        public IRPSGridTextBox<OrderVMEntityView> NetMass { get; set; } 
        public IRPSGridTextBox<OrderVMEntityView> InsurancesCost { get; set; } 
        public IRPSGridTextBox<OrderVMEntityView> FreightsCost { get; set; } 
        public IRPSGridTextBox<OrderVMEntityView> PermissionsCost { get; set; } 
        public IRPSGridTextBox<OrderVMEntityView> BankingCost { get; set; } 
        public IRPSGridTextBox<OrderVMEntityView> OthersCost { get; set; } 
        public IRPSGridTextBox<OrderVMEntityView> ExternalCost { get; set; } 
        public IRPSGridTextBox<OrderVMEntityView> TariffCost { get; set; } 
                     
    }
 
    }
  
            
    public partial class OrderImportEstimateView : View
    {
        public OrderImportEstimateView(OrderImportEstimate screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<OrderImportEstimateView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<OrderImportEstimateView,OrderVMEntityView>( this,Screen.OrderVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<OrderImportEstimateView,OrderVMEntityView>( this,Screen.OrderVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<OrderImportEstimateView,OrderVMEntityView>( this,Screen.OrderVMEntityView);
 
            NumLine = RPSControlFactory.CreateRPSFormattedTextBox<OrderImportEstimateView>("b404b418-8fa0-4a3f-9ed7-af9cfc54667f","","",true, this);
 
            IDImportDocumentType = RPSControlFactory.CreateRPSComboBox<OrderImportEstimateView>("a8c4da16-c72e-4e47-8100-9bb9456450ba","","",true, this);
 
            ExpenseType = RPSControlFactory.CreateRPSEnumComboBox<OrderImportEstimateView>("4bc665e2-d11d-4e4d-9af0-c0c2a76b79ee","","",true, this);
 
            ApportionmentType = RPSControlFactory.CreateRPSEnumComboBox<OrderImportEstimateView>("a8c97873-c44c-4a4f-a4ef-25d37fd31ace","","",true, this);
 
            BreakDownPar = RPSControlFactory.CreateRPSCheckBox<OrderImportEstimateView>("d50f08d9-9723-443a-b053-82baac464034","","",true, this);
 
            PorcCalc = RPSControlFactory.CreateRPSFormattedTextBox<OrderImportEstimateView>("396b4eed-9d6f-4f66-a3c7-642297b6a524","","",true, this);
 
            ManValue = RPSControlFactory.CreateRPSFormattedTextBox<OrderImportEstimateView>("942164ca-210d-4ae0-963f-47de2bd68e4c","","",true, this);
 
            CalculatedValue = RPSControlFactory.CreateRPSFormattedTextBox<OrderImportEstimateView>("ce54b891-a310-45f1-a045-8c1a4a7569a8","","",true, this);
 
            CollectionInit params_OrderImportEstimateTariffs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="694bc044-e196-498c-9e48-19382d9ca798",CSSSelectorGrid="",XPathGrid=""};
            OrderImportEstimateTariffs = RPSControlFactory.RPSCreateCollectionWithGrid<OrderImportEstimateTariffsCollectionEditor<OrderImportEstimateView>,OrderImportEstimateView>( params_OrderImportEstimateTariffs,this);
 

        }
        public IRPSButton<OrderImportEstimateView> DeleteButton { get; set; } 
        public IRPSButton<OrderImportEstimateView,OrderVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<OrderImportEstimateView,OrderVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<OrderImportEstimateView,OrderVMEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<OrderImportEstimateView> NumLine { get; set; } 
        public IRPSComboBox<OrderImportEstimateView> IDImportDocumentType { get; set; } 
        public IRPSComboBox<OrderImportEstimateView> ExpenseType { get; set; } 
        public IRPSComboBox<OrderImportEstimateView> ApportionmentType { get; set; } 
        public IRPSCheckbox<OrderImportEstimateView> BreakDownPar { get; set; } 
        public IRPSTextBox<OrderImportEstimateView> PorcCalc { get; set; } 
        public IRPSTextBox<OrderImportEstimateView> ManValue { get; set; } 
        public IRPSTextBox<OrderImportEstimateView> CalculatedValue { get; set; } 
        public OrderImportEstimateTariffsCollectionEditor<OrderImportEstimateView> OrderImportEstimateTariffs { get; set; } 
        public OrderImportEstimate Screen { get; set; }
        public OrderImportEstimateView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class OrderImportEstimateTariffsCollectionEditor<OrderImportEstimateView>:RPSCollectionEditor<OrderImportEstimateView> where OrderImportEstimateView : class, IView
    {
        public  OrderImportEstimateTariffsGridView<OrderImportEstimateView> GridView {get;set;}
    }
    public partial class OrderImportEstimateTariffsGridView <OrderImportEstimateView> :  RPSGridView<OrderImportEstimateView> where OrderImportEstimateView : class, IView
    {
        public OrderImportEstimateTariffsGridView(OrderImportEstimateView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDImportTariffType = RPSControlFactory.CreateRPSGridComboBox<OrderImportEstimateView>("","#694bc044-e196-498c-9e48-19382d9ca798 .ag-row[role='row']@ROWINDEX [col-id='cIDImportTariffType']","",true, this.CurrentView);
 
            Value = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderImportEstimateView>("","#694bc044-e196-498c-9e48-19382d9ca798 .ag-row[role='row']@ROWINDEX [col-id='cValue']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<OrderImportEstimateView> IDImportTariffType { get; set; } 
        public IRPSGridTextBox<OrderImportEstimateView> Value { get; set; } 
                     
    }
 
    }
  
            
    public partial class CalcularGastosImportacionDialogView : View
    {
        public CalcularGastosImportacionDialogView(OrderImportEstimate screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            OnlyArticleStockControl = RPSControlFactory.CreateRPSCheckBox<CalcularGastosImportacionDialogView>("33fe2736-fef8-438c-a2bc-d96dcde46e4a","","",false, this);
 

        }
        public IRPSCheckbox<CalcularGastosImportacionDialogView> OnlyArticleStockControl { get; set; } 
        public OrderImportEstimate Screen { get; set; }
        public CalcularGastosImportacionDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}