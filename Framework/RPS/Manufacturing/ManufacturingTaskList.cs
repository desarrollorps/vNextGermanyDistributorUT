    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.ManufacturingTaskList
{
    //RPS VERSION 1.0.0.0
    public partial class ManufacturingTaskList:Screen
    {
        public ManufacturingTaskList():base()
        {
            this.URL = "manufacturing.manufacturingtasklist";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ManufacturingTaskListQueryView  = new ManufacturingTaskListQueryView(this); 
            MOMaterialListView  = new MOMaterialListView(this); 
            OrderOfferListView  = new OrderOfferListView(this); 
            ManufacturingTaskListQueryView.InitializeControls(); 
            MOMaterialListView.InitializeControls(); 
            OrderOfferListView.InitializeControls(); 
           
        }
      
            public ManufacturingTaskListQueryView ManufacturingTaskListQueryView {get; set; } 
            public MOMaterialListView MOMaterialListView {get; set; } 
            public OrderOfferListView OrderOfferListView {get; set; } 
    }
            
    public partial class ManufacturingTaskListQueryView : View
    {
        public ManufacturingTaskListQueryView(ManufacturingTaskList screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UISite = RPSControlFactory.CreateRPSComboBox<ManufacturingTaskListQueryView>("5ffabbae-8675-4c93-8498-5942330314cd","","",false, this);
 
            UIManufacturingOrderSituation = RPSControlFactory.CreateRPSComboBox<ManufacturingTaskListQueryView>("c7972aea-a916-45b9-bc4c-a5bdf0858769","","",false, this);
 
            UILstManufacturingOrder = RPSControlFactory.CreateRPSCollectionComboBox<ManufacturingTaskListQueryView>("fe19e0ce-c7c4-4e93-bc8e-1b5129434120","","",true, this);
 
            UIInternalCode = RPSControlFactory.CreateRPSTextBox<ManufacturingTaskListQueryView>("160caaf2-1906-425c-a294-40468cc7b1f7","","",false, this);
 
            UIUsualTaskSTR = RPSControlFactory.CreateRPSComboBox<ManufacturingTaskListQueryView>("928cf8b0-067d-4d81-9c5f-be920a089e43","","",false, this);
 
            UICustomer = RPSControlFactory.CreateRPSComboBox<ManufacturingTaskListQueryView>("2d288b52-0cd5-4bb0-b5d0-90121bf7d920","","",false, this);
 
            UIOrderSL = RPSControlFactory.CreateRPSCollectionComboBox<ManufacturingTaskListQueryView>("d10d494e-8b28-422b-974e-7f4d1284f865","","",false, this);
 
            UIViewOnlyPendingTasks = RPSControlFactory.CreateRPSCheckBox<ManufacturingTaskListQueryView>("35669f3f-bb39-47d7-be35-06639d024fe7","","",false, this);
 
            UIDelayedTasks = RPSControlFactory.CreateRPSCheckBox<ManufacturingTaskListQueryView>("6b6519b8-89f6-450e-9656-46d70221641f","","",false, this);
 
            UITasksWithPendingPurchaseOrders = RPSControlFactory.CreateRPSCheckBox<ManufacturingTaskListQueryView>("974b100c-5e21-4165-8ae0-c19173c5e476","","",false, this);
 
            UIHighlightMaterialsWithoutStock = RPSControlFactory.CreateRPSCheckBox<ManufacturingTaskListQueryView>("d3345351-6cea-4e82-ab0a-89d02849bf14","","",false, this);
 
            InternalCode = RPSControlFactory.CreateRPSTextBox<ManufacturingTaskListQueryView>("6f24826d-97dd-4d6e-a88c-02a00cfeb8b0","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<ManufacturingTaskListQueryView>("1eecc4de-f04b-4dcb-be3c-c79a114b409e","","",false, this);
 
            UIPreparationTime = RPSControlFactory.CreateRPSFormattedTextBox<ManufacturingTaskListQueryView>("d68200e9-e6b0-4128-bf58-1504ea5a46db","","",false, this);
 
            UIExecutionTime = RPSControlFactory.CreateRPSFormattedTextBox<ManufacturingTaskListQueryView>("e62e7d45-9bc0-4cc8-8b00-6f1531ee0d75","","",false, this);
 
            UIRealHours = RPSControlFactory.CreateRPSFormattedTextBox<ManufacturingTaskListQueryView>("1963aeca-62cb-4431-a7ad-5d56dc7cddfa","","",false, this);
 
            PlannedStartDate = RPSControlFactory.CreateRPSTextBox<ManufacturingTaskListQueryView>("cea74cbd-9727-4656-8ec5-e022936cf85c","","",false, this);
 
            PlannedEndDate = RPSControlFactory.CreateRPSTextBox<ManufacturingTaskListQueryView>("3b48076f-392f-48f1-834b-721787703536","","",false, this);
 
            RealStartDate = RPSControlFactory.CreateRPSTextBox<ManufacturingTaskListQueryView>("98f7d202-efaf-4dfc-8230-cc9b5e6e80d5","","",false, this);
 
            RealSDMinusPlanSD = RPSControlFactory.CreateRPSFormattedTextBox<ManufacturingTaskListQueryView>("5248f87b-4586-43e1-9807-e3ed65c1a2bf","","",false, this);
 
            TodayMinusPlanSD = RPSControlFactory.CreateRPSFormattedTextBox<ManufacturingTaskListQueryView>("bb5ff31f-e25c-47f8-bc04-d49b005bd3cf","","",false, this);
 
            UsedQuantity = RPSControlFactory.CreateRPSFormattedTextBox<ManufacturingTaskListQueryView>("70029b61-3bc5-4225-bac2-87878c0b6ae9","","",false, this);
 
            ReportCommandButton = RPSControlFactory.CreateRPSButton<ManufacturingTaskListQueryView>( "5666685d-6818-4b23-9345-d9157b2f5b78","","",this);
 
            CollectionInit params_ManufacturingTaskListData = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8c82d583-28c9-40aa-8601-351ee673e280",CSSSelectorGrid="",XPathGrid=""};
            ManufacturingTaskListData = RPSControlFactory.RPSCreateCollectionWithGrid<ManufacturingTaskListDataCollectionEditor<ManufacturingTaskListQueryView>,ManufacturingTaskListQueryView>( params_ManufacturingTaskListData,this);
 

        }
        public IRPSComboBox<ManufacturingTaskListQueryView> UISite { get; set; } 
        public IRPSComboBox<ManufacturingTaskListQueryView> UIManufacturingOrderSituation { get; set; } 
        public IRPSCollectionComboBox<ManufacturingTaskListQueryView> UILstManufacturingOrder { get; set; } 
        public IRPSTextBox<ManufacturingTaskListQueryView> UIInternalCode { get; set; } 
        public IRPSComboBox<ManufacturingTaskListQueryView> UIUsualTaskSTR { get; set; } 
        public IRPSComboBox<ManufacturingTaskListQueryView> UICustomer { get; set; } 
        public IRPSCollectionComboBox<ManufacturingTaskListQueryView> UIOrderSL { get; set; } 
        public IRPSCheckbox<ManufacturingTaskListQueryView> UIViewOnlyPendingTasks { get; set; } 
        public IRPSCheckbox<ManufacturingTaskListQueryView> UIDelayedTasks { get; set; } 
        public IRPSCheckbox<ManufacturingTaskListQueryView> UITasksWithPendingPurchaseOrders { get; set; } 
        public IRPSCheckbox<ManufacturingTaskListQueryView> UIHighlightMaterialsWithoutStock { get; set; } 
        public IRPSTextBox<ManufacturingTaskListQueryView> InternalCode { get; set; } 
        public IRPSTextBox<ManufacturingTaskListQueryView> Quantity { get; set; } 
        public IRPSTextBox<ManufacturingTaskListQueryView> UIPreparationTime { get; set; } 
        public IRPSTextBox<ManufacturingTaskListQueryView> UIExecutionTime { get; set; } 
        public IRPSTextBox<ManufacturingTaskListQueryView> UIRealHours { get; set; } 
        public IRPSTextBox<ManufacturingTaskListQueryView> PlannedStartDate { get; set; } 
        public IRPSTextBox<ManufacturingTaskListQueryView> PlannedEndDate { get; set; } 
        public IRPSTextBox<ManufacturingTaskListQueryView> RealStartDate { get; set; } 
        public IRPSTextBox<ManufacturingTaskListQueryView> RealSDMinusPlanSD { get; set; } 
        public IRPSTextBox<ManufacturingTaskListQueryView> TodayMinusPlanSD { get; set; } 
        public IRPSTextBox<ManufacturingTaskListQueryView> UsedQuantity { get; set; } 
        public IRPSButton<ManufacturingTaskListQueryView> ReportCommandButton { get; set; } 
        public ManufacturingTaskListDataCollectionEditor<ManufacturingTaskListQueryView> ManufacturingTaskListData { get; set; } 
        public ManufacturingTaskList Screen { get; set; }
        public ManufacturingTaskListQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ManufacturingTaskListDataCollectionEditor<ManufacturingTaskListQueryView>:RPSCollectionEditor<ManufacturingTaskListQueryView> where ManufacturingTaskListQueryView : class, IView
    {
        public  ManufacturingTaskListDataGridView<ManufacturingTaskListQueryView> GridView {get;set;}
    }
    public partial class ManufacturingTaskListDataGridView <ManufacturingTaskListQueryView> :  RPSGridView<ManufacturingTaskListQueryView> where ManufacturingTaskListQueryView : class, IView
    {
        public ManufacturingTaskListDataGridView(ManufacturingTaskListQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            InternalCode = RPSControlFactory.CreateRPSGridTextBox<ManufacturingTaskListQueryView>("","#8c82d583-28c9-40aa-8601-351ee673e280 .ag-row[role='row']@ROWINDEX [col-id='cInternalCode']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<ManufacturingTaskListQueryView>("","#8c82d583-28c9-40aa-8601-351ee673e280 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            UIPreparationTime = RPSControlFactory.CreateRPSGridFormattedTextBox<ManufacturingTaskListQueryView>("","#8c82d583-28c9-40aa-8601-351ee673e280 .ag-row[role='row']@ROWINDEX [col-id='cUIPreparationTime']","",false, this.CurrentView);
 
            UIExecutionTime = RPSControlFactory.CreateRPSGridFormattedTextBox<ManufacturingTaskListQueryView>("","#8c82d583-28c9-40aa-8601-351ee673e280 .ag-row[role='row']@ROWINDEX [col-id='cUIExecutionTime']","",false, this.CurrentView);
 
            UIRealHours = RPSControlFactory.CreateRPSGridFormattedTextBox<ManufacturingTaskListQueryView>("","#8c82d583-28c9-40aa-8601-351ee673e280 .ag-row[role='row']@ROWINDEX [col-id='cUIRealHours']","",false, this.CurrentView);
 
            PlannedStartDate = RPSControlFactory.CreateRPSGridTextBox<ManufacturingTaskListQueryView>("","#8c82d583-28c9-40aa-8601-351ee673e280 .ag-row[role='row']@ROWINDEX [col-id='cPlannedStartDate']","",false, this.CurrentView);
 
            PlannedEndDate = RPSControlFactory.CreateRPSGridTextBox<ManufacturingTaskListQueryView>("","#8c82d583-28c9-40aa-8601-351ee673e280 .ag-row[role='row']@ROWINDEX [col-id='cPlannedEndDate']","",false, this.CurrentView);
 
            RealStartDate = RPSControlFactory.CreateRPSGridTextBox<ManufacturingTaskListQueryView>("","#8c82d583-28c9-40aa-8601-351ee673e280 .ag-row[role='row']@ROWINDEX [col-id='cRealStartDate']","",false, this.CurrentView);
 
            RealSDMinusPlanSD = RPSControlFactory.CreateRPSGridFormattedTextBox<ManufacturingTaskListQueryView>("","#8c82d583-28c9-40aa-8601-351ee673e280 .ag-row[role='row']@ROWINDEX [col-id='cRealSDMinusPlanSD']","",false, this.CurrentView);
 
            TodayMinusPlanSD = RPSControlFactory.CreateRPSGridFormattedTextBox<ManufacturingTaskListQueryView>("","#8c82d583-28c9-40aa-8601-351ee673e280 .ag-row[role='row']@ROWINDEX [col-id='cTodayMinusPlanSD']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ManufacturingTaskListQueryView> InternalCode { get; set; } 
        public IRPSGridTextBox<ManufacturingTaskListQueryView> Quantity { get; set; } 
        public IRPSGridTextBox<ManufacturingTaskListQueryView> UIPreparationTime { get; set; } 
        public IRPSGridTextBox<ManufacturingTaskListQueryView> UIExecutionTime { get; set; } 
        public IRPSGridTextBox<ManufacturingTaskListQueryView> UIRealHours { get; set; } 
        public IRPSGridTextBox<ManufacturingTaskListQueryView> PlannedStartDate { get; set; } 
        public IRPSGridTextBox<ManufacturingTaskListQueryView> PlannedEndDate { get; set; } 
        public IRPSGridTextBox<ManufacturingTaskListQueryView> RealStartDate { get; set; } 
        public IRPSGridTextBox<ManufacturingTaskListQueryView> RealSDMinusPlanSD { get; set; } 
        public IRPSGridTextBox<ManufacturingTaskListQueryView> TodayMinusPlanSD { get; set; } 
                     
    }
 
    }
  
            
    public partial class MOMaterialListView : View
    {
        public MOMaterialListView(ManufacturingTaskList screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_ManufacturingTaskListDataMaterial = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d11daa5c-3221-4b63-b99d-c594d2c2fd62",CSSSelectorGrid="",XPathGrid=""};
            ManufacturingTaskListDataMaterial = RPSControlFactory.RPSCreateCollectionWithGrid<ManufacturingTaskListDataMaterialCollectionEditor<MOMaterialListView>,MOMaterialListView>( params_ManufacturingTaskListDataMaterial,this);
 

        }
        public ManufacturingTaskListDataMaterialCollectionEditor<MOMaterialListView> ManufacturingTaskListDataMaterial { get; set; } 
        public ManufacturingTaskList Screen { get; set; }
        public MOMaterialListView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ManufacturingTaskListDataMaterialCollectionEditor<MOMaterialListView>:RPSCollectionEditor<MOMaterialListView> where MOMaterialListView : class, IView
    {
        public  ManufacturingTaskListDataMaterialGridView<MOMaterialListView> GridView {get;set;}
    }
    public partial class ManufacturingTaskListDataMaterialGridView <MOMaterialListView> :  RPSGridView<MOMaterialListView> where MOMaterialListView : class, IView
    {
        public ManufacturingTaskListDataMaterialGridView(MOMaterialListView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Stock = RPSControlFactory.CreateRPSGridFormattedTextBox<MOMaterialListView>("","#d11daa5c-3221-4b63-b99d-c594d2c2fd62 .ag-row[role='row']@ROWINDEX [col-id='cStock']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MOMaterialListView> Stock { get; set; } 
                     
    }
 
    }
  
            
    public partial class OrderOfferListView : View
    {
        public OrderOfferListView(ManufacturingTaskList screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_ManufacturingTaskListDataOrderOffer = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b7897482-0ba9-44d5-86d3-2020c470010a",CSSSelectorGrid="",XPathGrid=""};
            ManufacturingTaskListDataOrderOffer = RPSControlFactory.RPSCreateCollectionWithGrid<ManufacturingTaskListDataOrderOfferCollectionEditor<OrderOfferListView>,OrderOfferListView>( params_ManufacturingTaskListDataOrderOffer,this);
 

        }
        public ManufacturingTaskListDataOrderOfferCollectionEditor<OrderOfferListView> ManufacturingTaskListDataOrderOffer { get; set; } 
        public ManufacturingTaskList Screen { get; set; }
        public OrderOfferListView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ManufacturingTaskListDataOrderOfferCollectionEditor<OrderOfferListView>:RPSCollectionEditor<OrderOfferListView> where OrderOfferListView : class, IView
    {
        public  ManufacturingTaskListDataOrderOfferGridView<OrderOfferListView> GridView {get;set;}
    }
    public partial class ManufacturingTaskListDataOrderOfferGridView <OrderOfferListView> :  RPSGridView<OrderOfferListView> where OrderOfferListView : class, IView
    {
        public ManufacturingTaskListDataOrderOfferGridView(OrderOfferListView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            OfferOrder = RPSControlFactory.CreateRPSGridTextBox<OrderOfferListView>("","#b7897482-0ba9-44d5-86d3-2020c470010a .ag-row[role='row']@ROWINDEX [col-id='cOfferOrder']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderOfferListView>("","#b7897482-0ba9-44d5-86d3-2020c470010a .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            RequestDate = RPSControlFactory.CreateRPSGridTextBox<OrderOfferListView>("","#b7897482-0ba9-44d5-86d3-2020c470010a .ag-row[role='row']@ROWINDEX [col-id='cRequestDate']","",false, this.CurrentView);
 
            Overdue = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderOfferListView>("","#b7897482-0ba9-44d5-86d3-2020c470010a .ag-row[role='row']@ROWINDEX [col-id='cOverdue']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<OrderOfferListView> OfferOrder { get; set; } 
        public IRPSGridTextBox<OrderOfferListView> Quantity { get; set; } 
        public IRPSGridTextBox<OrderOfferListView> RequestDate { get; set; } 
        public IRPSGridTextBox<OrderOfferListView> Overdue { get; set; } 
                     
    }
 
    }
  
    

}