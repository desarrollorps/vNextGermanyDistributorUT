    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Planification.Availability
{
    //RPS VERSION 1.0.0.0
    public partial class Availability:Screen
    {
        public Availability():base()
        {
            this.URL = "planification.availability";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            AvailabilityQueryView  = new AvailabilityQueryView(this); 
            OrderAndReservesToDateDialogView  = new OrderAndReservesToDateDialogView(this); 
            AvailabilityQueryView.InitializeControls(); 
            OrderAndReservesToDateDialogView.InitializeControls(); 
           
        }
      
            public AvailabilityQueryView AvailabilityQueryView {get; set; } 
            public OrderAndReservesToDateDialogView OrderAndReservesToDateDialogView {get; set; } 
    }
            
    public partial class AvailabilityQueryView : View
    {
        public AvailabilityQueryView(Availability screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<AvailabilityQueryView>("fcaf4be1-83e4-44cf-ab8f-e42911766de4","","",true, this);
 
            Scene = RPSControlFactory.CreateRPSComboBox<AvailabilityQueryView>("206b3478-b1d9-426a-891b-0794fd0cd896","","",false, this);
 
            KeepMRPData = RPSControlFactory.CreateRPSCheckBox<AvailabilityQueryView>("393f4114-a1f9-426d-89f7-ee512a783555","","",false, this);
 
            Article = RPSControlFactory.CreateRPSComboBox<AvailabilityQueryView>("48e9982d-e1a7-4fad-b3d5-c32b235677f0","","",true, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<AvailabilityQueryView>("31a2ea41-829c-4c19-bf92-3fc2cdf32dd7","","",true, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<AvailabilityQueryView>("8208ca2c-58cf-41f9-9f16-49c9b62aba2a","","",true, this);
 
            CheckManufacturingOrder = RPSControlFactory.CreateRPSCheckBox<AvailabilityQueryView>("213bfcf4-a1d5-42d8-9563-00c674d83079","","",false, this);
 
            CheckPurchase = RPSControlFactory.CreateRPSCheckBox<AvailabilityQueryView>("bd008509-80b2-4d91-99b1-206d2df9a67f","","",false, this);
 
            CheckManufacturingPrevisions = RPSControlFactory.CreateRPSCheckBox<AvailabilityQueryView>("9419c022-f123-4cfa-8042-94d205a3abb2","","",false, this);
 
            CheckConsumePrevisions = RPSControlFactory.CreateRPSCheckBox<AvailabilityQueryView>("12171247-5957-45ab-bc84-5e3ab8000f2b","","",false, this);
 
            CheckMaintenance = RPSControlFactory.CreateRPSCheckBox<AvailabilityQueryView>("f1982d49-07fe-4982-91f2-ca1c908a4331","","",false, this);
 
            CheckProjectMaterial = RPSControlFactory.CreateRPSCheckBox<AvailabilityQueryView>("ef4568f0-d611-4318-b530-0797a9c751c0","","",false, this);
 
            CheckSalesPrevisions = RPSControlFactory.CreateRPSCheckBox<AvailabilityQueryView>("82b00431-b9ab-4a5c-860f-f340c7507992","","",false, this);
 
            CheckOrderSales = RPSControlFactory.CreateRPSCheckBox<AvailabilityQueryView>("957943e9-b000-4b4e-b52d-eefd2b551f43","","",false, this);
 
            CheckDeliveryPlanPurchase = RPSControlFactory.CreateRPSCheckBox<AvailabilityQueryView>("aec0acb6-d8d1-4166-8d31-b28c0f664a98","","",false, this);
 
            CheckDeliveryPlanSales = RPSControlFactory.CreateRPSCheckBox<AvailabilityQueryView>("5a03d7dc-f72c-4c36-b604-acf94783dedf","","",false, this);
 
            UIInitialStock = RPSControlFactory.CreateRPSFormattedTextBox<AvailabilityQueryView>("c15458e6-129b-4911-aa66-8a0323f2380b","","",false, this);
 
            UIAssignedQuantity = RPSControlFactory.CreateRPSFormattedTextBox<AvailabilityQueryView>("ff4beb0d-5ece-4540-a6e9-a1335adca929","","",false, this);
 
            UIPreviousOrderToDate = RPSControlFactory.CreateRPSFormattedTextBox<AvailabilityQueryView>("e366eb7e-a645-4078-a987-97234f45afc5","","",false, this);
 
            UIPreviousReserveToDate = RPSControlFactory.CreateRPSFormattedTextBox<AvailabilityQueryView>("abcdc436-7102-4704-afa6-d76a5fa9cb81","","",false, this);
 
            UIInitialAvailable = RPSControlFactory.CreateRPSFormattedTextBox<AvailabilityQueryView>("56361eca-b671-4209-83ed-5a4d68d5002a","","",false, this);
 
            CollectionInit params_RetrieveAvailabilityList = new CollectionInit(){IDDescriptor = "a7198458-2036-4a01-8fdd-240d81f55c5b",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c4ce83a2-0dfa-41b5-bca9-248b5ec34bf5",CSSSelectorGrid="",XPathGrid=""};
            RetrieveAvailabilityList = RPSControlFactory.RPSCreateCollectionWithGrid<RetrieveAvailabilityListCollectionEditor<AvailabilityQueryView,OrderAndReservesToDateDialogView>,AvailabilityQueryView,OrderAndReservesToDateDialogView>( params_RetrieveAvailabilityList,this,Screen.OrderAndReservesToDateDialogView);
 
            CollectionInit params_GetOrdersAndReserves = new CollectionInit(){IDDescriptor = "a7198458-2036-4a01-8fdd-240d81f55c5b",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            GetOrdersAndReserves = RPSControlFactory.RPSCreateCollection<AvailabilityQueryView,OrderAndReservesToDateDialogView>( params_GetOrdersAndReserves,this,Screen.OrderAndReservesToDateDialogView);
 

        }
        public IRPSComboBox<AvailabilityQueryView> Site { get; set; } 
        public IRPSComboBox<AvailabilityQueryView> Scene { get; set; } 
        public IRPSCheckbox<AvailabilityQueryView> KeepMRPData { get; set; } 
        public IRPSComboBox<AvailabilityQueryView> Article { get; set; } 
        public IRPSTextBox<AvailabilityQueryView> DateFrom { get; set; } 
        public IRPSTextBox<AvailabilityQueryView> DateTo { get; set; } 
        public IRPSCheckbox<AvailabilityQueryView> CheckManufacturingOrder { get; set; } 
        public IRPSCheckbox<AvailabilityQueryView> CheckPurchase { get; set; } 
        public IRPSCheckbox<AvailabilityQueryView> CheckManufacturingPrevisions { get; set; } 
        public IRPSCheckbox<AvailabilityQueryView> CheckConsumePrevisions { get; set; } 
        public IRPSCheckbox<AvailabilityQueryView> CheckMaintenance { get; set; } 
        public IRPSCheckbox<AvailabilityQueryView> CheckProjectMaterial { get; set; } 
        public IRPSCheckbox<AvailabilityQueryView> CheckSalesPrevisions { get; set; } 
        public IRPSCheckbox<AvailabilityQueryView> CheckOrderSales { get; set; } 
        public IRPSCheckbox<AvailabilityQueryView> CheckDeliveryPlanPurchase { get; set; } 
        public IRPSCheckbox<AvailabilityQueryView> CheckDeliveryPlanSales { get; set; } 
        public IRPSTextBox<AvailabilityQueryView> UIInitialStock { get; set; } 
        public IRPSTextBox<AvailabilityQueryView> UIAssignedQuantity { get; set; } 
        public IRPSTextBox<AvailabilityQueryView> UIPreviousOrderToDate { get; set; } 
        public IRPSTextBox<AvailabilityQueryView> UIPreviousReserveToDate { get; set; } 
        public IRPSTextBox<AvailabilityQueryView> UIInitialAvailable { get; set; } 
        public RetrieveAvailabilityListCollectionEditor<AvailabilityQueryView,OrderAndReservesToDateDialogView> RetrieveAvailabilityList { get; set; } 
        public IRPSCollectionEditor<AvailabilityQueryView,OrderAndReservesToDateDialogView> GetOrdersAndReserves { get; set; } 
        public Availability Screen { get; set; }
        public AvailabilityQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class RetrieveAvailabilityListCollectionEditor<AvailabilityQueryView,OrderAndReservesToDateDialogView>:RPSCollectionEditor<AvailabilityQueryView,OrderAndReservesToDateDialogView> where AvailabilityQueryView : class, IView where OrderAndReservesToDateDialogView : class, IView
    {
        public  RetrieveAvailabilityListGridView<AvailabilityQueryView,OrderAndReservesToDateDialogView> GridView {get;set;}
    }
    public partial class RetrieveAvailabilityListGridView <AvailabilityQueryView,OrderAndReservesToDateDialogView> :  RPSGridView<AvailabilityQueryView,OrderAndReservesToDateDialogView> where AvailabilityQueryView : class, IView where OrderAndReservesToDateDialogView : class, IView
    {
        public RetrieveAvailabilityListGridView(AvailabilityQueryView currentView,OrderAndReservesToDateDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Date = RPSControlFactory.CreateRPSGridTextBox<AvailabilityQueryView>("","#c4ce83a2-0dfa-41b5-bca9-248b5ec34bf5 .ag-row[role='row']@ROWINDEX [col-id='cDate']","",false, this.CurrentView);
 
            OrderQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<AvailabilityQueryView>("","#c4ce83a2-0dfa-41b5-bca9-248b5ec34bf5 .ag-row[role='row']@ROWINDEX [col-id='cOrderQuantity']","",false, this.CurrentView);
 
            ReserveQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<AvailabilityQueryView>("","#c4ce83a2-0dfa-41b5-bca9-248b5ec34bf5 .ag-row[role='row']@ROWINDEX [col-id='cReserveQuantity']","",false, this.CurrentView);
 
            StockReserveQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<AvailabilityQueryView>("","#c4ce83a2-0dfa-41b5-bca9-248b5ec34bf5 .ag-row[role='row']@ROWINDEX [col-id='cStockReserveQuantity']","",false, this.CurrentView);
 
            AvailableQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<AvailabilityQueryView>("","#c4ce83a2-0dfa-41b5-bca9-248b5ec34bf5 .ag-row[role='row']@ROWINDEX [col-id='cAvailableQuantity']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<AvailabilityQueryView> Date { get; set; } 
        public IRPSGridTextBox<AvailabilityQueryView> OrderQuantity { get; set; } 
        public IRPSGridTextBox<AvailabilityQueryView> ReserveQuantity { get; set; } 
        public IRPSGridTextBox<AvailabilityQueryView> StockReserveQuantity { get; set; } 
        public IRPSGridTextBox<AvailabilityQueryView> AvailableQuantity { get; set; } 
                     
    }
 
    }
  
            
    public partial class OrderAndReservesToDateDialogView : View
    {
        public OrderAndReservesToDateDialogView(Availability screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            OK_LinkNavigationCommand = RPSControlFactory.CreateRPSButton<OrderAndReservesToDateDialogView>( "c4e2de2e-52ed-4d71-9ce7-d39f60c0274c","","",this);
 
            CollectionInit params_GetOrdersAndReserves = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1790c1a9-af8c-4701-94b4-eb5f3ddbcf09",CSSSelectorGrid="",XPathGrid=""};
            GetOrdersAndReserves = RPSControlFactory.RPSCreateCollectionWithGrid<GetOrdersAndReservesCollectionEditor<OrderAndReservesToDateDialogView>,OrderAndReservesToDateDialogView>( params_GetOrdersAndReserves,this);
 

        }
        public IRPSButton<OrderAndReservesToDateDialogView> OK_LinkNavigationCommand { get; set; } 
        public GetOrdersAndReservesCollectionEditor<OrderAndReservesToDateDialogView> GetOrdersAndReserves { get; set; } 
        public Availability Screen { get; set; }
        public OrderAndReservesToDateDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetOrdersAndReservesCollectionEditor<OrderAndReservesToDateDialogView>:RPSCollectionEditor<OrderAndReservesToDateDialogView> where OrderAndReservesToDateDialogView : class, IView
    {
        public  GetOrdersAndReservesGridView<OrderAndReservesToDateDialogView> GridView {get;set;}
    }
    public partial class GetOrdersAndReservesGridView <OrderAndReservesToDateDialogView> :  RPSGridView<OrderAndReservesToDateDialogView> where OrderAndReservesToDateDialogView : class, IView
    {
        public GetOrdersAndReservesGridView(OrderAndReservesToDateDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            OriginType = RPSControlFactory.CreateRPSGridTextBox<OrderAndReservesToDateDialogView>("","#1790c1a9-af8c-4701-94b4-eb5f3ddbcf09 .ag-row[role='row']@ROWINDEX [col-id='cOriginType']","",false, this.CurrentView);
 
            Header = RPSControlFactory.CreateRPSGridTextBox<OrderAndReservesToDateDialogView>("","#1790c1a9-af8c-4701-94b4-eb5f3ddbcf09 .ag-row[role='row']@ROWINDEX [col-id='cHeader']","",false, this.CurrentView);
 
            DescriptionHeader = RPSControlFactory.CreateRPSGridTextBox<OrderAndReservesToDateDialogView>("","#1790c1a9-af8c-4701-94b4-eb5f3ddbcf09 .ag-row[role='row']@ROWINDEX [col-id='cDescriptionHeader']","",false, this.CurrentView);
 
            OriginLine = RPSControlFactory.CreateRPSGridTextBox<OrderAndReservesToDateDialogView>("","#1790c1a9-af8c-4701-94b4-eb5f3ddbcf09 .ag-row[role='row']@ROWINDEX [col-id='cOriginLine']","",false, this.CurrentView);
 
            OrderQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderAndReservesToDateDialogView>("","#1790c1a9-af8c-4701-94b4-eb5f3ddbcf09 .ag-row[role='row']@ROWINDEX [col-id='cOrderQuantity']","",false, this.CurrentView);
 
            ReserveQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderAndReservesToDateDialogView>("","#1790c1a9-af8c-4701-94b4-eb5f3ddbcf09 .ag-row[role='row']@ROWINDEX [col-id='cReserveQuantity']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<OrderAndReservesToDateDialogView> OriginType { get; set; } 
        public IRPSGridTextBox<OrderAndReservesToDateDialogView> Header { get; set; } 
        public IRPSGridTextBox<OrderAndReservesToDateDialogView> DescriptionHeader { get; set; } 
        public IRPSGridTextBox<OrderAndReservesToDateDialogView> OriginLine { get; set; } 
        public IRPSGridTextBox<OrderAndReservesToDateDialogView> OrderQuantity { get; set; } 
        public IRPSGridTextBox<OrderAndReservesToDateDialogView> ReserveQuantity { get; set; } 
                     
    }
 
    }
  
    

}