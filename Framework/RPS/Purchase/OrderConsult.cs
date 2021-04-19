    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.OrderConsult
{
    //RPS VERSION 1.0.0.0
    public partial class OrderConsult:Screen
    {
        public OrderConsult():base()
        {
            this.URL = "purchase.orderconsult";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            OrderConsultQueryView  = new OrderConsultQueryView(this); 
            ModifyOrderSituationDialogView  = new ModifyOrderSituationDialogView(this); 
            OrderConsultQueryView.InitializeControls(); 
            ModifyOrderSituationDialogView.InitializeControls(); 
           
        }
      
            public OrderConsultQueryView OrderConsultQueryView {get; set; } 
            public ModifyOrderSituationDialogView ModifyOrderSituationDialogView {get; set; } 
    }
            
    public partial class OrderConsultQueryView : View
    {
        public OrderConsultQueryView(OrderConsult screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            lsIDOrderFilter = RPSControlFactory.CreateRPSCollectionComboBox<OrderConsultQueryView>("db30b479-209a-4184-b401-97aff55322fa","","",false, this);
 
            All = RPSControlFactory.CreateRPSOption<OrderConsultQueryView>( "fbd5e094-06ef-47d9-932a-918e822f74ed","","",this);
 
            PendingReceive = RPSControlFactory.CreateRPSOption<OrderConsultQueryView>( "6a1661bd-d4d1-42aa-b709-6fcf65fb0152","","",this);
 
            PendingInvoice = RPSControlFactory.CreateRPSOption<OrderConsultQueryView>( "66f429b6-3659-42ab-a177-27a2ca3e964f","","",this);
 
            OrderDateFromFilter = RPSControlFactory.CreateRPSTextBox<OrderConsultQueryView>("84608579-270b-469c-8d0f-1ec4d5097b80","","",false, this);
 
            OrderDateToFilter = RPSControlFactory.CreateRPSTextBox<OrderConsultQueryView>("fa2a8ac8-8d82-4294-bcc9-53eb438c2bc1","","",false, this);
 
            ReceptionDateFromFilter = RPSControlFactory.CreateRPSTextBox<OrderConsultQueryView>("ed249960-562f-4288-8ee7-bdbec06aafbd","","",false, this);
 
            ReceptionDateToFilter = RPSControlFactory.CreateRPSTextBox<OrderConsultQueryView>("a27de54d-bc3e-4ba5-9ee7-9bc4965a6e13","","",false, this);
 
            Empresa = RPSControlFactory.CreateRPSOption<OrderConsultQueryView>( "97d095e2-adf5-4e7d-a00a-f29937a8eafc","","",this);
 
            Pedido = RPSControlFactory.CreateRPSOption<OrderConsultQueryView>( "ca8e1447-8ecf-4950-8540-0a1e56f4dd69","","",this);
 
            OrderSituation = RPSControlFactory.CreateRPSCollectionComboBox<OrderConsultQueryView>("4cdc2fac-2165-418a-b527-9c49e6a4f64f","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSCollectionComboBox<OrderConsultQueryView>("72db7bc5-3836-4545-93b1-ab8631122e1c","","",false, this);
 
            IDSupplierGroup = RPSControlFactory.CreateRPSCollectionComboBox<OrderConsultQueryView>("98a68ee0-4933-4d41-8038-dbc181775cb2","","",false, this);
 
            IDProductLine = RPSControlFactory.CreateRPSCollectionComboBox<OrderConsultQueryView>("b5ca50c6-4e6d-4620-a883-b9156f596473","","",false, this);
 
            IDProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<OrderConsultQueryView>("c96dcc82-ce47-40a1-ac1d-bff4d2b83d1a","","",false, this);
 
            IDProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<OrderConsultQueryView>("70399a98-dd3f-4c57-94da-c307e9b9eecf","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSCollectionComboBox<OrderConsultQueryView>("63981a10-8c75-4aac-a39d-99777c671d86","","",false, this);
 
            ReferenceSupplier = RPSControlFactory.CreateRPSEnumComboBox<OrderConsultQueryView>("101d7e60-66e5-43b3-a061-f94ed408ddcc","","",false, this);
 
            SupplierRequestQuotation = RPSControlFactory.CreateRPSCollectionComboBox<OrderConsultQueryView>("b4e3b482-7dec-4e37-a051-022133313e15","","",false, this);
 
            SupplierOrder = RPSControlFactory.CreateRPSTextBox<OrderConsultQueryView>("2d6c98df-90e1-48bf-88fe-a47f0808a5c5","","",false, this);
 
            InternalCode = RPSControlFactory.CreateRPSTextBox<OrderConsultQueryView>("4df9a389-83bc-4925-967d-dc62365963cd","","",false, this);
 
            IDFrameworkContract = RPSControlFactory.CreateRPSComboBox<OrderConsultQueryView>("f0afb2d0-5f1a-4783-874a-0618cf01b911","","",false, this);
 
            IDArticleStructure = RPSControlFactory.CreateRPSComboBox<OrderConsultQueryView>("700a7634-7a90-49d4-bd04-cf08bd608d79","","",false, this);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<OrderConsultQueryView>("54fa154b-42a0-472e-b63a-29e5180d6a0f","","",false, this);
 
            IDManufacturingOrder = RPSControlFactory.CreateRPSComboBox<OrderConsultQueryView>("e1ae25fa-821f-4ea4-979e-4d17a7522769","","",false, this);
 
            IDOrderSL = RPSControlFactory.CreateRPSComboBox<OrderConsultQueryView>("d60cf4b3-75df-4294-8b10-d30b3dc437b2","","",false, this);
 
            IDMaintenanceOrder = RPSControlFactory.CreateRPSComboBox<OrderConsultQueryView>("fa68d32c-a04e-448f-bdff-4a81e7e2f9e2","","",false, this);
 
            IDMaintenanceContract = RPSControlFactory.CreateRPSComboBox<OrderConsultQueryView>("cf8b5c56-4cd9-451a-af24-a7b741e51e40","","",false, this);
 
            OnlyExternalTask = RPSControlFactory.CreateRPSCheckBox<OrderConsultQueryView>("1865d5cf-66b4-4732-ae5b-b1c555987f66","","",false, this);
 
            All1 = RPSControlFactory.CreateRPSOption<OrderConsultQueryView>( "5407c0c6-07fa-4518-b032-cfb437bdc048","","",this);
 
            Pending = RPSControlFactory.CreateRPSOption<OrderConsultQueryView>( "f8d07544-dd92-461c-9231-e748bad6c71e","","",this);
 
            Finalized = RPSControlFactory.CreateRPSOption<OrderConsultQueryView>( "d4dff362-204e-4113-9b3c-589fe013fa22","","",this);
 
            ChangeOrderSituationCommandButton = RPSControlFactory.CreateRPSButtonToView<OrderConsultQueryView,ModifyOrderSituationDialogView>("55a3f17b-0049-43a8-9a25-6d82f82252f4","","", this,Screen.ModifyOrderSituationDialogView);
 
            CollectionInit params_OrderConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="05db2039-5d48-412e-b4eb-1874f6b6e21b",CSSSelectorGrid="",XPathGrid=""};
            OrderConsult = RPSControlFactory.RPSCreateCollectionWithGrid<OrderConsultCollectionEditor<OrderConsultQueryView,ModifyOrderSituationDialogView>,OrderConsultQueryView,ModifyOrderSituationDialogView>( params_OrderConsult,this,Screen.ModifyOrderSituationDialogView);
 
            CollectionInit params_OrderLineConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6668f92f-734f-4580-a6f3-4db24040a9b0",CSSSelectorGrid="",XPathGrid=""};
            OrderLineConsult = RPSControlFactory.RPSCreateCollectionWithGrid<OrderLineConsultCollectionEditor<OrderConsultQueryView,ModifyOrderSituationDialogView>,OrderConsultQueryView,ModifyOrderSituationDialogView>( params_OrderLineConsult,this,Screen.ModifyOrderSituationDialogView);
 

        }
        public IRPSCollectionComboBox<OrderConsultQueryView> lsIDOrderFilter { get; set; } 
        public IRPSOption<OrderConsultQueryView> All { get; set; } 
        public IRPSOption<OrderConsultQueryView> PendingReceive { get; set; } 
        public IRPSOption<OrderConsultQueryView> PendingInvoice { get; set; } 
        public IRPSTextBox<OrderConsultQueryView> OrderDateFromFilter { get; set; } 
        public IRPSTextBox<OrderConsultQueryView> OrderDateToFilter { get; set; } 
        public IRPSTextBox<OrderConsultQueryView> ReceptionDateFromFilter { get; set; } 
        public IRPSTextBox<OrderConsultQueryView> ReceptionDateToFilter { get; set; } 
        public IRPSOption<OrderConsultQueryView> Empresa { get; set; } 
        public IRPSOption<OrderConsultQueryView> Pedido { get; set; } 
        public IRPSCollectionComboBox<OrderConsultQueryView> OrderSituation { get; set; } 
        public IRPSCollectionComboBox<OrderConsultQueryView> IDSupplier { get; set; } 
        public IRPSCollectionComboBox<OrderConsultQueryView> IDSupplierGroup { get; set; } 
        public IRPSCollectionComboBox<OrderConsultQueryView> IDProductLine { get; set; } 
        public IRPSCollectionComboBox<OrderConsultQueryView> IDProductFamily { get; set; } 
        public IRPSCollectionComboBox<OrderConsultQueryView> IDProductSubFamily { get; set; } 
        public IRPSCollectionComboBox<OrderConsultQueryView> IDArticle { get; set; } 
        public IRPSComboBox<OrderConsultQueryView> ReferenceSupplier { get; set; } 
        public IRPSCollectionComboBox<OrderConsultQueryView> SupplierRequestQuotation { get; set; } 
        public IRPSTextBox<OrderConsultQueryView> SupplierOrder { get; set; } 
        public IRPSTextBox<OrderConsultQueryView> InternalCode { get; set; } 
        public IRPSComboBox<OrderConsultQueryView> IDFrameworkContract { get; set; } 
        public IRPSComboBox<OrderConsultQueryView> IDArticleStructure { get; set; } 
        public IRPSComboBox<OrderConsultQueryView> IDProject { get; set; } 
        public IRPSComboBox<OrderConsultQueryView> IDManufacturingOrder { get; set; } 
        public IRPSComboBox<OrderConsultQueryView> IDOrderSL { get; set; } 
        public IRPSComboBox<OrderConsultQueryView> IDMaintenanceOrder { get; set; } 
        public IRPSComboBox<OrderConsultQueryView> IDMaintenanceContract { get; set; } 
        public IRPSCheckbox<OrderConsultQueryView> OnlyExternalTask { get; set; } 
        public IRPSOption<OrderConsultQueryView> All1 { get; set; } 
        public IRPSOption<OrderConsultQueryView> Pending { get; set; } 
        public IRPSOption<OrderConsultQueryView> Finalized { get; set; } 
        public IRPSButton<OrderConsultQueryView,ModifyOrderSituationDialogView> ChangeOrderSituationCommandButton { get; set; } 
        public OrderConsultCollectionEditor<OrderConsultQueryView,ModifyOrderSituationDialogView> OrderConsult { get; set; } 
        public OrderLineConsultCollectionEditor<OrderConsultQueryView,ModifyOrderSituationDialogView> OrderLineConsult { get; set; } 
        public OrderConsult Screen { get; set; }
        public OrderConsultQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class OrderConsultCollectionEditor<OrderConsultQueryView,ModifyOrderSituationDialogView>:RPSCollectionEditor<OrderConsultQueryView,ModifyOrderSituationDialogView> where OrderConsultQueryView : class, IView where ModifyOrderSituationDialogView : class, IView
    {
        public  OrderConsultGridView<OrderConsultQueryView,ModifyOrderSituationDialogView> GridView {get;set;}
    }
    public partial class OrderConsultGridView <OrderConsultQueryView,ModifyOrderSituationDialogView> :  RPSGridView<OrderConsultQueryView,ModifyOrderSituationDialogView> where OrderConsultQueryView : class, IView where ModifyOrderSituationDialogView : class, IView
    {
        public OrderConsultGridView(OrderConsultQueryView currentView,ModifyOrderSituationDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            SupplierMiscellaneous_Description = RPSControlFactory.CreateRPSGridTextBox<OrderConsultQueryView>("","#05db2039-5d48-412e-b4eb-1874f6b6e21b .ag-row[role='row']@ROWINDEX [col-id='cSupplierMiscellaneous_Description']","",false, this.CurrentView);
 
            Order_OrderDate = RPSControlFactory.CreateRPSGridTextBox<OrderConsultQueryView>("","#05db2039-5d48-412e-b4eb-1874f6b6e21b .ag-row[role='row']@ROWINDEX [col-id='cOrder_OrderDate']","",false, this.CurrentView);
 
            Order_ReceptionDate = RPSControlFactory.CreateRPSGridTextBox<OrderConsultQueryView>("","#05db2039-5d48-412e-b4eb-1874f6b6e21b .ag-row[role='row']@ROWINDEX [col-id='cOrder_ReceptionDate']","",false, this.CurrentView);
 
            QuoteNumberSupplier = RPSControlFactory.CreateRPSGridTextBox<OrderConsultQueryView>("","#05db2039-5d48-412e-b4eb-1874f6b6e21b .ag-row[role='row']@ROWINDEX [col-id='cQuoteNumberSupplier']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<OrderConsultQueryView> SupplierMiscellaneous_Description { get; set; } 
        public IRPSGridTextBox<OrderConsultQueryView> Order_OrderDate { get; set; } 
        public IRPSGridTextBox<OrderConsultQueryView> Order_ReceptionDate { get; set; } 
        public IRPSGridTextBox<OrderConsultQueryView> QuoteNumberSupplier { get; set; } 
                     
    }
 
        public partial class OrderLineConsultCollectionEditor<OrderConsultQueryView,ModifyOrderSituationDialogView>:RPSCollectionEditor<OrderConsultQueryView,ModifyOrderSituationDialogView> where OrderConsultQueryView : class, IView where ModifyOrderSituationDialogView : class, IView
    {
        public  OrderLineConsultGridView<OrderConsultQueryView,ModifyOrderSituationDialogView> GridView {get;set;}
    }
    public partial class OrderLineConsultGridView <OrderConsultQueryView,ModifyOrderSituationDialogView> :  RPSGridView<OrderConsultQueryView,ModifyOrderSituationDialogView> where OrderConsultQueryView : class, IView where ModifyOrderSituationDialogView : class, IView
    {
        public OrderLineConsultGridView(OrderConsultQueryView currentView,ModifyOrderSituationDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            OrderLine_Description = RPSControlFactory.CreateRPSGridTextBox<OrderConsultQueryView>("","#6668f92f-734f-4580-a6f3-4db24040a9b0 .ag-row[role='row']@ROWINDEX [col-id='cOrderLine_Description']","",false, this.CurrentView);
 
            OrderLine_ReferenceSupplier = RPSControlFactory.CreateRPSGridTextBox<OrderConsultQueryView>("","#6668f92f-734f-4580-a6f3-4db24040a9b0 .ag-row[role='row']@ROWINDEX [col-id='cOrderLine_ReferenceSupplier']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<OrderConsultQueryView> OrderLine_Description { get; set; } 
        public IRPSGridTextBox<OrderConsultQueryView> OrderLine_ReferenceSupplier { get; set; } 
                     
    }
 
    }
  
            
    public partial class ModifyOrderSituationDialogView : View
    {
        public ModifyOrderSituationDialogView(OrderConsult screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            OrderSituation = RPSControlFactory.CreateRPSComboBox<ModifyOrderSituationDialogView>("69ca3b5b-648b-4d70-b127-ecd07103ea07","","",false, this);
 

        }
        public IRPSComboBox<ModifyOrderSituationDialogView> OrderSituation { get; set; } 
        public OrderConsult Screen { get; set; }
        public ModifyOrderSituationDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}