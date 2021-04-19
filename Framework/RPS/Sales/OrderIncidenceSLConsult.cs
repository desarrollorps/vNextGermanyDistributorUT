    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.OrderIncidenceSLConsult
{
    //RPS VERSION 1.0.0.0
    public partial class OrderIncidenceSLConsult:Screen
    {
        public OrderIncidenceSLConsult():base()
        {
            this.URL = "sales.orderincidenceslconsult";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            OrderIncidenceSLConsultQueryView  = new OrderIncidenceSLConsultQueryView(this); 
            OrderIncidenceSLConsultQueryView.InitializeControls(); 
           
        }
      
            public OrderIncidenceSLConsultQueryView OrderIncidenceSLConsultQueryView {get; set; } 
    }
            
    public partial class OrderIncidenceSLConsultQueryView : View
    {
        public OrderIncidenceSLConsultQueryView(OrderIncidenceSLConsult screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDOrderSL = RPSControlFactory.CreateRPSComboBox<OrderIncidenceSLConsultQueryView>("23c66961-d748-468d-ac80-e49b4115b13b","","",false, this);
 
            OrderDateFrom = RPSControlFactory.CreateRPSTextBox<OrderIncidenceSLConsultQueryView>("18fd4728-0b82-4878-8dbc-8745da0dd480","","",false, this);
 
            OrderDateTo = RPSControlFactory.CreateRPSTextBox<OrderIncidenceSLConsultQueryView>("6f216aff-8fd6-4576-bdc7-44192869355a","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<OrderIncidenceSLConsultQueryView>("8e3b6323-aac0-4dc5-ae39-cbb178f5da30","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<OrderIncidenceSLConsultQueryView>("7cec2b3d-9c27-4e87-9aa5-33acab520fc9","","",false, this);
 
            IDIncidenceTypeSL = RPSControlFactory.CreateRPSComboBox<OrderIncidenceSLConsultQueryView>("94c85ee2-86fb-4712-bef1-c6f15f9cfd77","","",false, this);
 
            IDIncidenceSituationSL = RPSControlFactory.CreateRPSComboBox<OrderIncidenceSLConsultQueryView>("df45eb8a-ea39-4b17-8fdb-b89eaf8e67c6","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<OrderIncidenceSLConsultQueryView>("29019a6c-3a01-4b8f-92bc-6b40b8f16049","","",false, this);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<OrderIncidenceSLConsultQueryView>("1648468c-b89f-4363-b7d6-c725fb4571e5","","",false, this);
 
            User = RPSControlFactory.CreateRPSComboBox<OrderIncidenceSLConsultQueryView>("9e4f527f-d73f-4ba0-8fc4-852cf4d2d3cb","","",false, this);
 
            OrderSL_OrderDate = RPSControlFactory.CreateRPSTextBox<OrderIncidenceSLConsultQueryView>("04daa1b1-5efa-4dc7-91b7-56ba8d8de8c4","","",false, this);
 
            OrderSL_ReceptionDate = RPSControlFactory.CreateRPSTextBox<OrderIncidenceSLConsultQueryView>("39e043a3-dd5a-4916-86d9-c00eba86a5fa","","",false, this);
 
            OrderIncidenceSL_NumIncidence = RPSControlFactory.CreateRPSFormattedTextBox<OrderIncidenceSLConsultQueryView>("16efcd8d-d5a0-418e-9283-700d43cc75a2","","",false, this);
 
            OrderIncidenceSL_Description = RPSControlFactory.CreateRPSTextBox<OrderIncidenceSLConsultQueryView>("84835ad7-c3d3-4598-abd9-f904fb6d1502","","",false, this);
 
            OrderIncidenceSL_Comment = RPSControlFactory.CreateRPSTextBox<OrderIncidenceSLConsultQueryView>("12df9310-b735-45a1-8b45-b5ac9170ff2c","","",false, this);
 
            CollectionInit params_OrderIncidenceSLConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="39be4287-2ca0-4f12-96e8-5bc60e8505cf",CSSSelectorGrid="",XPathGrid=""};
            OrderIncidenceSLConsult = RPSControlFactory.RPSCreateCollectionWithGrid<OrderIncidenceSLConsultCollectionEditor<OrderIncidenceSLConsultQueryView>,OrderIncidenceSLConsultQueryView>( params_OrderIncidenceSLConsult,this);
 

        }
        public IRPSComboBox<OrderIncidenceSLConsultQueryView> IDOrderSL { get; set; } 
        public IRPSTextBox<OrderIncidenceSLConsultQueryView> OrderDateFrom { get; set; } 
        public IRPSTextBox<OrderIncidenceSLConsultQueryView> OrderDateTo { get; set; } 
        public IRPSTextBox<OrderIncidenceSLConsultQueryView> DateFrom { get; set; } 
        public IRPSTextBox<OrderIncidenceSLConsultQueryView> DateTo { get; set; } 
        public IRPSComboBox<OrderIncidenceSLConsultQueryView> IDIncidenceTypeSL { get; set; } 
        public IRPSComboBox<OrderIncidenceSLConsultQueryView> IDIncidenceSituationSL { get; set; } 
        public IRPSComboBox<OrderIncidenceSLConsultQueryView> IDCustomer { get; set; } 
        public IRPSComboBox<OrderIncidenceSLConsultQueryView> IDEmployee { get; set; } 
        public IRPSComboBox<OrderIncidenceSLConsultQueryView> User { get; set; } 
        public IRPSTextBox<OrderIncidenceSLConsultQueryView> OrderSL_OrderDate { get; set; } 
        public IRPSTextBox<OrderIncidenceSLConsultQueryView> OrderSL_ReceptionDate { get; set; } 
        public IRPSTextBox<OrderIncidenceSLConsultQueryView> OrderIncidenceSL_NumIncidence { get; set; } 
        public IRPSTextBox<OrderIncidenceSLConsultQueryView> OrderIncidenceSL_Description { get; set; } 
        public IRPSTextBox<OrderIncidenceSLConsultQueryView> OrderIncidenceSL_Comment { get; set; } 
        public OrderIncidenceSLConsultCollectionEditor<OrderIncidenceSLConsultQueryView> OrderIncidenceSLConsult { get; set; } 
        public OrderIncidenceSLConsult Screen { get; set; }
        public OrderIncidenceSLConsultQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class OrderIncidenceSLConsultCollectionEditor<OrderIncidenceSLConsultQueryView>:RPSCollectionEditor<OrderIncidenceSLConsultQueryView> where OrderIncidenceSLConsultQueryView : class, IView
    {
        public  OrderIncidenceSLConsultGridView<OrderIncidenceSLConsultQueryView> GridView {get;set;}
    }
    public partial class OrderIncidenceSLConsultGridView <OrderIncidenceSLConsultQueryView> :  RPSGridView<OrderIncidenceSLConsultQueryView> where OrderIncidenceSLConsultQueryView : class, IView
    {
        public OrderIncidenceSLConsultGridView(OrderIncidenceSLConsultQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            OrderSL_OrderDate = RPSControlFactory.CreateRPSGridTextBox<OrderIncidenceSLConsultQueryView>("","#39be4287-2ca0-4f12-96e8-5bc60e8505cf .ag-row[role='row']@ROWINDEX [col-id='cOrderSL_OrderDate']","",false, this.CurrentView);
 
            OrderSL_ReceptionDate = RPSControlFactory.CreateRPSGridTextBox<OrderIncidenceSLConsultQueryView>("","#39be4287-2ca0-4f12-96e8-5bc60e8505cf .ag-row[role='row']@ROWINDEX [col-id='cOrderSL_ReceptionDate']","",false, this.CurrentView);
 
            OrderIncidenceSL_Date = RPSControlFactory.CreateRPSGridTextBox<OrderIncidenceSLConsultQueryView>("","#39be4287-2ca0-4f12-96e8-5bc60e8505cf .ag-row[role='row']@ROWINDEX [col-id='cOrderIncidenceSL_Date']","",false, this.CurrentView);
 
            OrderIncidenceSL_Description = RPSControlFactory.CreateRPSGridTextBox<OrderIncidenceSLConsultQueryView>("","#39be4287-2ca0-4f12-96e8-5bc60e8505cf .ag-row[role='row']@ROWINDEX [col-id='cOrderIncidenceSL_Description']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<OrderIncidenceSLConsultQueryView> OrderSL_OrderDate { get; set; } 
        public IRPSGridTextBox<OrderIncidenceSLConsultQueryView> OrderSL_ReceptionDate { get; set; } 
        public IRPSGridTextBox<OrderIncidenceSLConsultQueryView> OrderIncidenceSL_Date { get; set; } 
        public IRPSGridTextBox<OrderIncidenceSLConsultQueryView> OrderIncidenceSL_Description { get; set; } 
                     
    }
 
    }
  
    

}