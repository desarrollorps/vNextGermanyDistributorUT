    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.OrderIncidenceConsult
{
    //RPS VERSION 1.0.0.0
    public partial class OrderIncidenceConsult:Screen
    {
        public OrderIncidenceConsult():base()
        {
            this.URL = "purchase.orderincidenceconsult";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            OrderIncidenceConsultQueryView  = new OrderIncidenceConsultQueryView(this); 
            OrderIncidenceConsultQueryView.InitializeControls(); 
           
        }
      
            public OrderIncidenceConsultQueryView OrderIncidenceConsultQueryView {get; set; } 
    }
            
    public partial class OrderIncidenceConsultQueryView : View
    {
        public OrderIncidenceConsultQueryView(OrderIncidenceConsult screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDOrder = RPSControlFactory.CreateRPSComboBox<OrderIncidenceConsultQueryView>("012a6af7-ab3c-4360-ac21-fb558fb7e973","","",false, this);
 
            OrderDateFrom = RPSControlFactory.CreateRPSTextBox<OrderIncidenceConsultQueryView>("57fade35-a6d9-4a54-8630-118717e48274","","",false, this);
 
            OrderDateTo = RPSControlFactory.CreateRPSTextBox<OrderIncidenceConsultQueryView>("1a4a3aa9-1eda-4136-b8f7-741de3fa0b45","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<OrderIncidenceConsultQueryView>("97b3506e-fe95-4909-bfc7-0204382fbfed","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<OrderIncidenceConsultQueryView>("04aa0dea-272e-4600-b509-0c3b2a9eae6e","","",false, this);
 
            IDIncidenceType = RPSControlFactory.CreateRPSComboBox<OrderIncidenceConsultQueryView>("05d4b53c-beb0-4221-96a2-4a68a2e0a345","","",false, this);
 
            IDIncidenceSituation = RPSControlFactory.CreateRPSComboBox<OrderIncidenceConsultQueryView>("2f8b01dd-3b22-4d9b-8bd5-b8749cac9adf","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<OrderIncidenceConsultQueryView>("b78d0806-895d-4836-a2bf-b83dc2155eb0","","",false, this);
 
            IDSupplierGroup = RPSControlFactory.CreateRPSComboBox<OrderIncidenceConsultQueryView>("4eead97f-5af5-4483-93a9-7d8a64687129","","",false, this);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<OrderIncidenceConsultQueryView>("0bbd0907-1905-4829-9a75-e8042872bd9f","","",false, this);
 
            User = RPSControlFactory.CreateRPSComboBox<OrderIncidenceConsultQueryView>("6bc4f483-9054-45bf-9765-f48289d49f15","","",false, this);
 
            Order_OrderDate = RPSControlFactory.CreateRPSTextBox<OrderIncidenceConsultQueryView>("706113c1-3ae1-49e9-91e6-25c88be60b37","","",false, this);
 
            Order_ReceptionDate = RPSControlFactory.CreateRPSTextBox<OrderIncidenceConsultQueryView>("249d6ad4-c7e4-45af-85fb-fae3438db318","","",false, this);
 
            Order_ClaimsNumber = RPSControlFactory.CreateRPSFormattedTextBox<OrderIncidenceConsultQueryView>("e2d47189-8702-4a98-a340-e37a61a33977","","",false, this);
 
            OrderIncidence_NumIncidence = RPSControlFactory.CreateRPSFormattedTextBox<OrderIncidenceConsultQueryView>("940caeb8-43fc-4c37-b99f-338b34286222","","",false, this);
 
            OrderIncidence_Description = RPSControlFactory.CreateRPSTextBox<OrderIncidenceConsultQueryView>("613c5413-6cfe-4128-8d95-12261ababe4d","","",false, this);
 
            OrderIncidence_Comment = RPSControlFactory.CreateRPSTextBox<OrderIncidenceConsultQueryView>("fe00407e-877a-4fa2-89c7-36aff75f061d","","",false, this);
 
            CollectionInit params_OrderIncidenceConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1abba5fa-0898-4e68-9705-e983f8e4fa2a",CSSSelectorGrid="",XPathGrid=""};
            OrderIncidenceConsult = RPSControlFactory.RPSCreateCollectionWithGrid<OrderIncidenceConsultCollectionEditor<OrderIncidenceConsultQueryView>,OrderIncidenceConsultQueryView>( params_OrderIncidenceConsult,this);
 

        }
        public IRPSComboBox<OrderIncidenceConsultQueryView> IDOrder { get; set; } 
        public IRPSTextBox<OrderIncidenceConsultQueryView> OrderDateFrom { get; set; } 
        public IRPSTextBox<OrderIncidenceConsultQueryView> OrderDateTo { get; set; } 
        public IRPSTextBox<OrderIncidenceConsultQueryView> DateFrom { get; set; } 
        public IRPSTextBox<OrderIncidenceConsultQueryView> DateTo { get; set; } 
        public IRPSComboBox<OrderIncidenceConsultQueryView> IDIncidenceType { get; set; } 
        public IRPSComboBox<OrderIncidenceConsultQueryView> IDIncidenceSituation { get; set; } 
        public IRPSComboBox<OrderIncidenceConsultQueryView> IDSupplier { get; set; } 
        public IRPSComboBox<OrderIncidenceConsultQueryView> IDSupplierGroup { get; set; } 
        public IRPSComboBox<OrderIncidenceConsultQueryView> IDEmployee { get; set; } 
        public IRPSComboBox<OrderIncidenceConsultQueryView> User { get; set; } 
        public IRPSTextBox<OrderIncidenceConsultQueryView> Order_OrderDate { get; set; } 
        public IRPSTextBox<OrderIncidenceConsultQueryView> Order_ReceptionDate { get; set; } 
        public IRPSTextBox<OrderIncidenceConsultQueryView> Order_ClaimsNumber { get; set; } 
        public IRPSTextBox<OrderIncidenceConsultQueryView> OrderIncidence_NumIncidence { get; set; } 
        public IRPSTextBox<OrderIncidenceConsultQueryView> OrderIncidence_Description { get; set; } 
        public IRPSTextBox<OrderIncidenceConsultQueryView> OrderIncidence_Comment { get; set; } 
        public OrderIncidenceConsultCollectionEditor<OrderIncidenceConsultQueryView> OrderIncidenceConsult { get; set; } 
        public OrderIncidenceConsult Screen { get; set; }
        public OrderIncidenceConsultQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class OrderIncidenceConsultCollectionEditor<OrderIncidenceConsultQueryView>:RPSCollectionEditor<OrderIncidenceConsultQueryView> where OrderIncidenceConsultQueryView : class, IView
    {
        public  OrderIncidenceConsultGridView<OrderIncidenceConsultQueryView> GridView {get;set;}
    }
    public partial class OrderIncidenceConsultGridView <OrderIncidenceConsultQueryView> :  RPSGridView<OrderIncidenceConsultQueryView> where OrderIncidenceConsultQueryView : class, IView
    {
        public OrderIncidenceConsultGridView(OrderIncidenceConsultQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Order_OrderDate = RPSControlFactory.CreateRPSGridTextBox<OrderIncidenceConsultQueryView>("","#1abba5fa-0898-4e68-9705-e983f8e4fa2a .ag-row[role='row']@ROWINDEX [col-id='cOrder_OrderDate']","",false, this.CurrentView);
 
            Order_ReceptionDate = RPSControlFactory.CreateRPSGridTextBox<OrderIncidenceConsultQueryView>("","#1abba5fa-0898-4e68-9705-e983f8e4fa2a .ag-row[role='row']@ROWINDEX [col-id='cOrder_ReceptionDate']","",false, this.CurrentView);
 
            OrderIncidence_Date = RPSControlFactory.CreateRPSGridTextBox<OrderIncidenceConsultQueryView>("","#1abba5fa-0898-4e68-9705-e983f8e4fa2a .ag-row[role='row']@ROWINDEX [col-id='cOrderIncidence_Date']","",false, this.CurrentView);
 
            OrderIncidence_Description = RPSControlFactory.CreateRPSGridTextBox<OrderIncidenceConsultQueryView>("","#1abba5fa-0898-4e68-9705-e983f8e4fa2a .ag-row[role='row']@ROWINDEX [col-id='cOrderIncidence_Description']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<OrderIncidenceConsultQueryView> Order_OrderDate { get; set; } 
        public IRPSGridTextBox<OrderIncidenceConsultQueryView> Order_ReceptionDate { get; set; } 
        public IRPSGridTextBox<OrderIncidenceConsultQueryView> OrderIncidence_Date { get; set; } 
        public IRPSGridTextBox<OrderIncidenceConsultQueryView> OrderIncidence_Description { get; set; } 
                     
    }
 
    }
  
    

}