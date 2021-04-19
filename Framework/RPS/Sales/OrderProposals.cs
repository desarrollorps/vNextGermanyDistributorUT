    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.OrderProposals
{
    //RPS VERSION 1.0.0.0
    public partial class OrderProposals:Screen
    {
        public OrderProposals():base()
        {
            this.URL = "sales.orderproposals";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            OrderProposalsQueryView  = new OrderProposalsQueryView(this); 
            OrderLineSLView  = new OrderLineSLView(this); 
            OrderLineProposalSLView  = new OrderLineProposalSLView(this); 
            GenerateOrderProposalChildDialogView  = new GenerateOrderProposalChildDialogView(this); 
            DeleteProposalsChildDialogView  = new DeleteProposalsChildDialogView(this); 
            OrderProposalsQueryView.InitializeControls(); 
            OrderLineSLView.InitializeControls(); 
            OrderLineProposalSLView.InitializeControls(); 
            GenerateOrderProposalChildDialogView.InitializeControls(); 
            DeleteProposalsChildDialogView.InitializeControls(); 
           
        }
      
            public OrderProposalsQueryView OrderProposalsQueryView {get; set; } 
            public OrderLineSLView OrderLineSLView {get; set; } 
            public OrderLineProposalSLView OrderLineProposalSLView {get; set; } 
            public GenerateOrderProposalChildDialogView GenerateOrderProposalChildDialogView {get; set; } 
            public DeleteProposalsChildDialogView DeleteProposalsChildDialogView {get; set; } 
    }
            
    public partial class OrderProposalsQueryView : View
    {
        public OrderProposalsQueryView(OrderProposals screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIOrderDateFrom = RPSControlFactory.CreateRPSTextBox<OrderProposalsQueryView>("abe0e880-ef0d-429b-8043-635dd03f8d5e","","",false, this);
 
            UIOrderDateTo = RPSControlFactory.CreateRPSTextBox<OrderProposalsQueryView>("f44781d2-41fe-4f6a-bdc5-ea2ae942bfa5","","",false, this);
 
            UIReceptionDateFrom = RPSControlFactory.CreateRPSTextBox<OrderProposalsQueryView>("8f46b8b5-61a5-4647-aebb-4fe278edbf9c","","",false, this);
 
            UIReceptionDateTo = RPSControlFactory.CreateRPSTextBox<OrderProposalsQueryView>("2017ce65-0b37-461d-adbc-299604af263c","","",false, this);
 
            bLines = RPSControlFactory.CreateRPSCheckBox<OrderProposalsQueryView>("1ec1f79b-b089-4967-82f4-a202281b5391","","",false, this);
 
            UILstOrderSL = RPSControlFactory.CreateRPSCollectionComboBox<OrderProposalsQueryView>("6462a752-70b5-414c-ba45-0aef2edb6430","","",false, this);
 
            UILstCustomer = RPSControlFactory.CreateRPSCollectionComboBox<OrderProposalsQueryView>("54a19125-9876-4795-83a8-433d83f978c5","","",false, this);
 
            Site = RPSControlFactory.CreateRPSComboBox<OrderProposalsQueryView>("e731989a-c4f0-42e8-b1b4-4cffdc1656b6","","",false, this);
 
            All = RPSControlFactory.CreateRPSOption<OrderProposalsQueryView>( "061d5b5a-e3f9-478e-bd9b-117654343c2f","","",this);
 
            OrdersWithoutProposal = RPSControlFactory.CreateRPSOption<OrderProposalsQueryView>( "a645fec8-0b38-4ed7-8ec9-9239ca8eacbe","","",this);
 
            OrdersWithProposal = RPSControlFactory.CreateRPSOption<OrderProposalsQueryView>( "8845c1de-5324-4d3e-bac5-9ce4eb434701","","",this);
 
            GenerateOrderProposalButton = RPSControlFactory.CreateRPSButton<OrderProposalsQueryView>( "c2375073-994c-4d03-bbd4-96c4bb073155","","",this);
 
            DeleteProposalButton = RPSControlFactory.CreateRPSButton<OrderProposalsQueryView>( "d48fbf3c-0698-42d7-830a-d151e498fd72","","",this);
 
            ReportCommandButton = RPSControlFactory.CreateRPSButton<OrderProposalsQueryView>( "9162b619-0438-46aa-a521-14313ef1a448","","",this);
 
            CollectionInit params_OrderLinesForProposalsMainQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4d8ad15a-d959-485d-9eb8-ee65d0e28e35",CSSSelectorGrid="",XPathGrid=""};
            OrderLinesForProposalsMainQuery = RPSControlFactory.RPSCreateCollectionWithGrid<OrderLinesForProposalsMainQueryCollectionEditor<OrderProposalsQueryView,GenerateOrderProposalChildDialogView>,OrderProposalsQueryView,GenerateOrderProposalChildDialogView>( params_OrderLinesForProposalsMainQuery,this,Screen.GenerateOrderProposalChildDialogView);
 

        }
        public IRPSTextBox<OrderProposalsQueryView> UIOrderDateFrom { get; set; } 
        public IRPSTextBox<OrderProposalsQueryView> UIOrderDateTo { get; set; } 
        public IRPSTextBox<OrderProposalsQueryView> UIReceptionDateFrom { get; set; } 
        public IRPSTextBox<OrderProposalsQueryView> UIReceptionDateTo { get; set; } 
        public IRPSCheckbox<OrderProposalsQueryView> bLines { get; set; } 
        public IRPSCollectionComboBox<OrderProposalsQueryView> UILstOrderSL { get; set; } 
        public IRPSCollectionComboBox<OrderProposalsQueryView> UILstCustomer { get; set; } 
        public IRPSComboBox<OrderProposalsQueryView> Site { get; set; } 
        public IRPSOption<OrderProposalsQueryView> All { get; set; } 
        public IRPSOption<OrderProposalsQueryView> OrdersWithoutProposal { get; set; } 
        public IRPSOption<OrderProposalsQueryView> OrdersWithProposal { get; set; } 
        public IRPSButton<OrderProposalsQueryView> GenerateOrderProposalButton { get; set; } 
        public IRPSButton<OrderProposalsQueryView> DeleteProposalButton { get; set; } 
        public IRPSButton<OrderProposalsQueryView> ReportCommandButton { get; set; } 
        public OrderLinesForProposalsMainQueryCollectionEditor<OrderProposalsQueryView,GenerateOrderProposalChildDialogView> OrderLinesForProposalsMainQuery { get; set; } 
        public OrderProposals Screen { get; set; }
        public OrderProposalsQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class OrderLinesForProposalsMainQueryCollectionEditor<OrderProposalsQueryView,GenerateOrderProposalChildDialogView>:RPSCollectionEditor<OrderProposalsQueryView,GenerateOrderProposalChildDialogView> where OrderProposalsQueryView : class, IView where GenerateOrderProposalChildDialogView : class, IView
    {
        public  OrderLinesForProposalsMainQueryGridView<OrderProposalsQueryView,GenerateOrderProposalChildDialogView> GridView {get;set;}
    }
    public partial class OrderLinesForProposalsMainQueryGridView <OrderProposalsQueryView,GenerateOrderProposalChildDialogView> :  RPSGridView<OrderProposalsQueryView,GenerateOrderProposalChildDialogView> where OrderProposalsQueryView : class, IView where GenerateOrderProposalChildDialogView : class, IView
    {
        public OrderLinesForProposalsMainQueryGridView(OrderProposalsQueryView currentView,GenerateOrderProposalChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            OrderSL_OrderDate = RPSControlFactory.CreateRPSGridTextBox<OrderProposalsQueryView>("","#4d8ad15a-d959-485d-9eb8-ee65d0e28e35 .ag-row[role='row']@ROWINDEX [col-id='cOrderSL_OrderDate']","",false, this.CurrentView);
 
            OrderLineSL_ReceptionDate = RPSControlFactory.CreateRPSGridTextBox<OrderProposalsQueryView>("","#4d8ad15a-d959-485d-9eb8-ee65d0e28e35 .ag-row[role='row']@ROWINDEX [col-id='cOrderLineSL_ReceptionDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<OrderProposalsQueryView> OrderSL_OrderDate { get; set; } 
        public IRPSGridTextBox<OrderProposalsQueryView> OrderLineSL_ReceptionDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class OrderLineSLView : View
    {
        public OrderLineSLView(OrderProposals screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<OrderLineSLView>( this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<OrderLineSLView>("bc3f2b54-3224-4dcb-9ef7-7e7f5abf9c9d","","",true, this);
 
            Quantity1 = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineSLView>("dc5d8f3a-38d2-4afb-aeba-575617e9b3e1","","",true, this);
 
            ProposalQuantity1 = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineSLView>("47db39da-40c8-401e-8b88-bf6dbcb14549","","",false, this);
 
            PendingProposalQuantity1 = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineSLView>("cfb6a43a-d41b-4774-9ca9-fe5bdf5e3212","","",false, this);
 
            LinkNavigationCommandButton = RPSControlFactory.CreateRPSButton<OrderLineSLView>( "d92dec9d-12bc-4ec0-be79-35e23bf05af6","","",this);
 
            CollectionInit params_OrderLineProposalSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c958ebfb-8f14-489a-82d3-60f18858bb16",CSSSelectorGrid="",XPathGrid=""};
            OrderLineProposalSLs = RPSControlFactory.RPSCreateCollectionWithGrid<OrderLineProposalSLsCollectionEditor<OrderLineSLView,OrderLineProposalSLView>,OrderLineSLView,OrderLineProposalSLView>( params_OrderLineProposalSLs,this,Screen.OrderLineProposalSLView);
 

        }
        public IRPSSaveButton<OrderLineSLView> SaveButton { get; set; } 
        public IRPSComboBox<OrderLineSLView> IDArticle { get; set; } 
        public IRPSTextBox<OrderLineSLView> Quantity1 { get; set; } 
        public IRPSTextBox<OrderLineSLView> ProposalQuantity1 { get; set; } 
        public IRPSTextBox<OrderLineSLView> PendingProposalQuantity1 { get; set; } 
        public IRPSButton<OrderLineSLView> LinkNavigationCommandButton { get; set; } 
        public OrderLineProposalSLsCollectionEditor<OrderLineSLView,OrderLineProposalSLView> OrderLineProposalSLs { get; set; } 
        public OrderProposals Screen { get; set; }
        public OrderLineSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class OrderLineProposalSLsCollectionEditor<OrderLineSLView,OrderLineProposalSLView>:RPSCollectionEditor<OrderLineSLView,OrderLineProposalSLView> where OrderLineSLView : class, IView where OrderLineProposalSLView : class, IView
    {
        public  OrderLineProposalSLsGridView<OrderLineSLView,OrderLineProposalSLView> GridView {get;set;}
    }
    public partial class OrderLineProposalSLsGridView <OrderLineSLView,OrderLineProposalSLView> :  RPSGridView<OrderLineSLView,OrderLineProposalSLView> where OrderLineSLView : class, IView where OrderLineProposalSLView : class, IView
    {
        public OrderLineProposalSLsGridView(OrderLineSLView currentView,OrderLineProposalSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDSite = RPSControlFactory.CreateRPSGridComboBox<OrderLineSLView>("","#c958ebfb-8f14-489a-82d3-60f18858bb16 .ag-row[role='row']@ROWINDEX [col-id='cIDSite']","",true, this.CurrentView);
 
            IDWarehouse = RPSControlFactory.CreateRPSGridComboBox<OrderLineSLView>("","#c958ebfb-8f14-489a-82d3-60f18858bb16 .ag-row[role='row']@ROWINDEX [col-id='cIDWarehouse']","",true, this.CurrentView);
 
            Series = RPSControlFactory.CreateRPSGridEnumComboBox<OrderLineSLView>("","#c958ebfb-8f14-489a-82d3-60f18858bb16 .ag-row[role='row']@ROWINDEX [col-id='cSeries']","",false, this.CurrentView);
 
            ExpiryDate = RPSControlFactory.CreateRPSGridTextBox<OrderLineSLView>("","#c958ebfb-8f14-489a-82d3-60f18858bb16 .ag-row[role='row']@ROWINDEX [col-id='cExpiryDate']","",false, this.CurrentView);
 
            IDLocationWarehouse = RPSControlFactory.CreateRPSGridComboBox<OrderLineSLView>("","#c958ebfb-8f14-489a-82d3-60f18858bb16 .ag-row[role='row']@ROWINDEX [col-id='cIDLocationWarehouse']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderLineSLView>("","#c958ebfb-8f14-489a-82d3-60f18858bb16 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSGridFormattedTextBox<OrderLineSLView>("","#c958ebfb-8f14-489a-82d3-60f18858bb16 .ag-row[role='row']@ROWINDEX [col-id='cQuantitySecondUnit']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<OrderLineSLView> IDSite { get; set; } 
        public IRPSGridComboBox<OrderLineSLView> IDWarehouse { get; set; } 
        public IRPSGridComboBox<OrderLineSLView> Series { get; set; } 
        public IRPSGridTextBox<OrderLineSLView> ExpiryDate { get; set; } 
        public IRPSGridComboBox<OrderLineSLView> IDLocationWarehouse { get; set; } 
        public IRPSGridTextBox<OrderLineSLView> Quantity { get; set; } 
        public IRPSGridTextBox<OrderLineSLView> QuantitySecondUnit { get; set; } 
                     
    }
 
    }
  
            
    public partial class OrderLineProposalSLView : View
    {
        public OrderLineProposalSLView(OrderProposals screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<OrderLineProposalSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<OrderLineProposalSLView,OrderLineSLView>( this,Screen.OrderLineSLView);
 
            BackButton = RPSControlFactory.RPSBackButton<OrderLineProposalSLView,OrderLineSLView>( this,Screen.OrderLineSLView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<OrderLineProposalSLView,OrderLineSLView>( this,Screen.OrderLineSLView);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<OrderLineProposalSLView>("4af7be58-ccb4-422e-be05-10024931168e","","",true, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<OrderLineProposalSLView>("132b155f-0746-4385-a3b5-2f5a25a71b8e","","",true, this);
 
            Series = RPSControlFactory.CreateRPSEnumComboBox<OrderLineProposalSLView>("14fa7b46-3976-4f31-9361-37a8224ca8a0","","",false, this);
 
            ExpiryDate = RPSControlFactory.CreateRPSTextBox<OrderLineProposalSLView>("dfedd8bb-0264-4786-a797-3ffc7c0f6903","","",false, this);
 
            IDLocationWarehouse = RPSControlFactory.CreateRPSComboBox<OrderLineProposalSLView>("9456f3a0-0c9e-4a5c-857b-8cb3d645b86a","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineProposalSLView>("953253da-4dfe-4159-a4d7-71177de06344","","",true, this);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<OrderLineProposalSLView>("fc46ca62-0bbe-45c5-9378-d5760f3c3568","","",true, this);
 

        }
        public IRPSButton<OrderLineProposalSLView> DeleteButton { get; set; } 
        public IRPSButton<OrderLineProposalSLView,OrderLineSLView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<OrderLineProposalSLView,OrderLineSLView> BackButton { get; set; } 
        public IRPSAcceptButton<OrderLineProposalSLView,OrderLineSLView> AcceptButton { get; set; } 
        public IRPSComboBox<OrderLineProposalSLView> IDSite { get; set; } 
        public IRPSComboBox<OrderLineProposalSLView> IDWarehouse { get; set; } 
        public IRPSComboBox<OrderLineProposalSLView> Series { get; set; } 
        public IRPSTextBox<OrderLineProposalSLView> ExpiryDate { get; set; } 
        public IRPSComboBox<OrderLineProposalSLView> IDLocationWarehouse { get; set; } 
        public IRPSTextBox<OrderLineProposalSLView> Quantity { get; set; } 
        public IRPSTextBox<OrderLineProposalSLView> QuantitySecondUnit { get; set; } 
        public OrderProposals Screen { get; set; }
        public OrderLineProposalSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class GenerateOrderProposalChildDialogView : View
    {
        public GenerateOrderProposalChildDialogView(OrderProposals screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIOrderDateFrom = RPSControlFactory.CreateRPSTextBox<GenerateOrderProposalChildDialogView>("ff1fd452-d045-4498-8436-1bec74543dc9","","",false, this);
 
            UIOrderDateTo = RPSControlFactory.CreateRPSTextBox<GenerateOrderProposalChildDialogView>("22fb8e37-4ff0-4bd4-b67b-5cb002b1ccda","","",false, this);
 
            UIReceptionDateFrom = RPSControlFactory.CreateRPSTextBox<GenerateOrderProposalChildDialogView>("9b6b00d3-c0a3-4281-85f8-dbfb83c50d47","","",false, this);
 
            UIReceptionDateTo = RPSControlFactory.CreateRPSTextBox<GenerateOrderProposalChildDialogView>("ed671d59-b2eb-4c07-b80d-c7b58a0b91f5","","",false, this);
 
            bLines = RPSControlFactory.CreateRPSCheckBox<GenerateOrderProposalChildDialogView>("45b2feb5-347d-426a-9f88-e7557a53e719","","",false, this);
 
            UILstOrderSL = RPSControlFactory.CreateRPSCollectionComboBox<GenerateOrderProposalChildDialogView>("3aa0fbb7-ec3a-44c7-a5f1-e4c4ce3da2e4","","",false, this);
 
            UILstCustomer = RPSControlFactory.CreateRPSCollectionComboBox<GenerateOrderProposalChildDialogView>("12e668c0-570b-4e2f-90de-d25f3a32ce2e","","",false, this);
 
            bOrderPreviousSelection = RPSControlFactory.CreateRPSCheckBox<GenerateOrderProposalChildDialogView>("6f96a7ba-6655-46b6-8011-fd2f852ee17a","","",false, this);
 
            bStockControl = RPSControlFactory.CreateRPSCheckBox<GenerateOrderProposalChildDialogView>("310e6ab8-85c4-4491-9772-087fd681352f","","",false, this);
 
            UIReserves = RPSControlFactory.CreateRPSCheckBox<GenerateOrderProposalChildDialogView>("74c15f3a-d384-48bd-ad17-d76d9edebc15","","",false, this);
 
            CollectionInit params_OrdersForProposals = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8d340343-80ba-468f-baa2-8fec10a74dca",CSSSelectorGrid="",XPathGrid=""};
            OrdersForProposals = RPSControlFactory.RPSCreateCollectionWithGrid<OrdersForProposalsCollectionEditor<GenerateOrderProposalChildDialogView>,GenerateOrderProposalChildDialogView>( params_OrdersForProposals,this);
 

        }
        public IRPSTextBox<GenerateOrderProposalChildDialogView> UIOrderDateFrom { get; set; } 
        public IRPSTextBox<GenerateOrderProposalChildDialogView> UIOrderDateTo { get; set; } 
        public IRPSTextBox<GenerateOrderProposalChildDialogView> UIReceptionDateFrom { get; set; } 
        public IRPSTextBox<GenerateOrderProposalChildDialogView> UIReceptionDateTo { get; set; } 
        public IRPSCheckbox<GenerateOrderProposalChildDialogView> bLines { get; set; } 
        public IRPSCollectionComboBox<GenerateOrderProposalChildDialogView> UILstOrderSL { get; set; } 
        public IRPSCollectionComboBox<GenerateOrderProposalChildDialogView> UILstCustomer { get; set; } 
        public IRPSCheckbox<GenerateOrderProposalChildDialogView> bOrderPreviousSelection { get; set; } 
        public IRPSCheckbox<GenerateOrderProposalChildDialogView> bStockControl { get; set; } 
        public IRPSCheckbox<GenerateOrderProposalChildDialogView> UIReserves { get; set; } 
        public OrdersForProposalsCollectionEditor<GenerateOrderProposalChildDialogView> OrdersForProposals { get; set; } 
        public OrderProposals Screen { get; set; }
        public GenerateOrderProposalChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class OrdersForProposalsCollectionEditor<GenerateOrderProposalChildDialogView>:RPSCollectionEditor<GenerateOrderProposalChildDialogView> where GenerateOrderProposalChildDialogView : class, IView
    {
        public  OrdersForProposalsGridView<GenerateOrderProposalChildDialogView> GridView {get;set;}
    }
    public partial class OrdersForProposalsGridView <GenerateOrderProposalChildDialogView> :  RPSGridView<GenerateOrderProposalChildDialogView> where GenerateOrderProposalChildDialogView : class, IView
    {
        public OrdersForProposalsGridView(GenerateOrderProposalChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            OrderSL_OrderDate = RPSControlFactory.CreateRPSGridTextBox<GenerateOrderProposalChildDialogView>("","#8d340343-80ba-468f-baa2-8fec10a74dca .ag-row[role='row']@ROWINDEX [col-id='cOrderSL_OrderDate']","",false, this.CurrentView);
 
            OrderSL_ReceptionDate = RPSControlFactory.CreateRPSGridTextBox<GenerateOrderProposalChildDialogView>("","#8d340343-80ba-468f-baa2-8fec10a74dca .ag-row[role='row']@ROWINDEX [col-id='cOrderSL_ReceptionDate']","",false, this.CurrentView);
 
            OrderSL_OrderNumberCustomer = RPSControlFactory.CreateRPSGridTextBox<GenerateOrderProposalChildDialogView>("","#8d340343-80ba-468f-baa2-8fec10a74dca .ag-row[role='row']@ROWINDEX [col-id='cOrderSL_OrderNumberCustomer']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<GenerateOrderProposalChildDialogView> OrderSL_OrderDate { get; set; } 
        public IRPSGridTextBox<GenerateOrderProposalChildDialogView> OrderSL_ReceptionDate { get; set; } 
        public IRPSGridTextBox<GenerateOrderProposalChildDialogView> OrderSL_OrderNumberCustomer { get; set; } 
                     
    }
 
    }
  
            
    public partial class DeleteProposalsChildDialogView : View
    {
        public DeleteProposalsChildDialogView(OrderProposals screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIOrderDateFrom = RPSControlFactory.CreateRPSTextBox<DeleteProposalsChildDialogView>("50597033-c61c-4af1-beae-f54e448040de","","",false, this);
 
            UIOrderDateTo = RPSControlFactory.CreateRPSTextBox<DeleteProposalsChildDialogView>("dea3a20b-8ea4-4f3f-8a30-c268fbf06ac5","","",false, this);
 
            UIReceptionDateFrom = RPSControlFactory.CreateRPSTextBox<DeleteProposalsChildDialogView>("ec002f03-3546-40c6-9432-59c1b3e35756","","",false, this);
 
            UIReceptionDateTo = RPSControlFactory.CreateRPSTextBox<DeleteProposalsChildDialogView>("e5d14426-618b-48f4-89f3-7567d1181a4b","","",false, this);
 
            bLines = RPSControlFactory.CreateRPSCheckBox<DeleteProposalsChildDialogView>("17146959-5985-4333-8565-78d79181d8fa","","",false, this);
 
            UILstOrderSL = RPSControlFactory.CreateRPSCollectionComboBox<DeleteProposalsChildDialogView>("932d7ef9-ab74-4dba-8d2d-1390908ef306","","",false, this);
 
            UILstCustomer = RPSControlFactory.CreateRPSCollectionComboBox<DeleteProposalsChildDialogView>("b41f78a4-0904-4d2a-ad95-008e0d92e299","","",false, this);
 
            bOrderPreviousSelection = RPSControlFactory.CreateRPSCheckBox<DeleteProposalsChildDialogView>("c1286a42-f1b3-47a9-8e8d-d1a40e0f204e","","",false, this);
 
            UIReserves = RPSControlFactory.CreateRPSCheckBox<DeleteProposalsChildDialogView>("9f509ef2-bdff-4142-8ec2-835c0a22d824","","",false, this);
 
            CollectionInit params_OrdersForProposals = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7c68bdea-15e1-4197-a7e0-26c1583ee44a",CSSSelectorGrid="",XPathGrid=""};
            OrdersForProposals = RPSControlFactory.RPSCreateCollectionWithGrid<OrdersForProposalsCollectionEditor<DeleteProposalsChildDialogView>,DeleteProposalsChildDialogView>( params_OrdersForProposals,this);
 

        }
        public IRPSTextBox<DeleteProposalsChildDialogView> UIOrderDateFrom { get; set; } 
        public IRPSTextBox<DeleteProposalsChildDialogView> UIOrderDateTo { get; set; } 
        public IRPSTextBox<DeleteProposalsChildDialogView> UIReceptionDateFrom { get; set; } 
        public IRPSTextBox<DeleteProposalsChildDialogView> UIReceptionDateTo { get; set; } 
        public IRPSCheckbox<DeleteProposalsChildDialogView> bLines { get; set; } 
        public IRPSCollectionComboBox<DeleteProposalsChildDialogView> UILstOrderSL { get; set; } 
        public IRPSCollectionComboBox<DeleteProposalsChildDialogView> UILstCustomer { get; set; } 
        public IRPSCheckbox<DeleteProposalsChildDialogView> bOrderPreviousSelection { get; set; } 
        public IRPSCheckbox<DeleteProposalsChildDialogView> UIReserves { get; set; } 
        public OrdersForProposalsCollectionEditor<DeleteProposalsChildDialogView> OrdersForProposals { get; set; } 
        public OrderProposals Screen { get; set; }
        public DeleteProposalsChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class OrdersForProposalsCollectionEditor<DeleteProposalsChildDialogView>:RPSCollectionEditor<DeleteProposalsChildDialogView> where DeleteProposalsChildDialogView : class, IView
    {
        public  OrdersForProposalsGridView<DeleteProposalsChildDialogView> GridView {get;set;}
    }
    public partial class OrdersForProposalsGridView <DeleteProposalsChildDialogView> :  RPSGridView<DeleteProposalsChildDialogView> where DeleteProposalsChildDialogView : class, IView
    {
        public OrdersForProposalsGridView(DeleteProposalsChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            OrderSL_OrderDate = RPSControlFactory.CreateRPSGridTextBox<DeleteProposalsChildDialogView>("","#7c68bdea-15e1-4197-a7e0-26c1583ee44a .ag-row[role='row']@ROWINDEX [col-id='cOrderSL_OrderDate']","",false, this.CurrentView);
 
            OrderSL_ReceptionDate = RPSControlFactory.CreateRPSGridTextBox<DeleteProposalsChildDialogView>("","#7c68bdea-15e1-4197-a7e0-26c1583ee44a .ag-row[role='row']@ROWINDEX [col-id='cOrderSL_ReceptionDate']","",false, this.CurrentView);
 
            OrderSL_OrderNumberCustomer = RPSControlFactory.CreateRPSGridTextBox<DeleteProposalsChildDialogView>("","#7c68bdea-15e1-4197-a7e0-26c1583ee44a .ag-row[role='row']@ROWINDEX [col-id='cOrderSL_OrderNumberCustomer']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<DeleteProposalsChildDialogView> OrderSL_OrderDate { get; set; } 
        public IRPSGridTextBox<DeleteProposalsChildDialogView> OrderSL_ReceptionDate { get; set; } 
        public IRPSGridTextBox<DeleteProposalsChildDialogView> OrderSL_OrderNumberCustomer { get; set; } 
                     
    }
 
    }
  
    

}