    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.OrderSLConsult
{
    //RPS VERSION 1.0.0.0
    public partial class OrderSLConsult:Screen
    {
        public OrderSLConsult():base()
        {
            this.URL = "sales.orderslconsult";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            OrderSLConsultQueryView  = new OrderSLConsultQueryView(this); 
            ModifyOrderSituationSLDialogView  = new ModifyOrderSituationSLDialogView(this); 
            OrderSLConsultQueryView.InitializeControls(); 
            ModifyOrderSituationSLDialogView.InitializeControls(); 
           
        }
      
            public OrderSLConsultQueryView OrderSLConsultQueryView {get; set; } 
            public ModifyOrderSituationSLDialogView ModifyOrderSituationSLDialogView {get; set; } 
    }
            
    public partial class OrderSLConsultQueryView : View
    {
        public OrderSLConsultQueryView(OrderSLConsult screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            LsOrderSLFilter = RPSControlFactory.CreateRPSCollectionComboBox<OrderSLConsultQueryView>("cf793bcf-0281-4d2b-86fa-b34a37f6e265","","",false, this);
 
            lsIDCustomerFilter = RPSControlFactory.CreateRPSCollectionComboBox<OrderSLConsultQueryView>("fb0c5d28-bb03-4850-8f31-075fa6871aec","","",false, this);
 
            OrderDateFromFilter = RPSControlFactory.CreateRPSTextBox<OrderSLConsultQueryView>("d98f9628-f872-4a94-9cb6-06152a8885eb","","",false, this);
 
            OrderDateToFilter = RPSControlFactory.CreateRPSTextBox<OrderSLConsultQueryView>("093863eb-3432-4403-94b8-328a75a889a2","","",false, this);
 
            ReceptionDateFromFilter = RPSControlFactory.CreateRPSTextBox<OrderSLConsultQueryView>("b4e09f53-8700-463e-bf9e-f66583c3ba00","","",false, this);
 
            ReceptionDateToFilter = RPSControlFactory.CreateRPSTextBox<OrderSLConsultQueryView>("60075422-a718-422c-aaec-7374ec15a034","","",false, this);
 
            All = RPSControlFactory.CreateRPSOption<OrderSLConsultQueryView>( "debf5b79-76a6-4965-b942-e4627d270969","","",this);
 
            PendingReceive = RPSControlFactory.CreateRPSOption<OrderSLConsultQueryView>( "5cf331e4-5a45-46b3-b468-8e3af422a2df","","",this);
 
            PendingInvoice = RPSControlFactory.CreateRPSOption<OrderSLConsultQueryView>( "3548510a-634d-44c0-92c5-c768e209379c","","",this);
 
            Empresa = RPSControlFactory.CreateRPSOption<OrderSLConsultQueryView>( "edd23ae4-d2d4-4ca3-a5f7-802f794febe4","","",this);
 
            Albaran = RPSControlFactory.CreateRPSOption<OrderSLConsultQueryView>( "528e8a64-3a44-43ea-a3cb-b468ae17f7b7","","",this);
 
            OrderSituationSL = RPSControlFactory.CreateRPSCollectionComboBox<OrderSLConsultQueryView>("473e751b-1a1d-446f-9e79-027f79873d08","","",false, this);
 
            SelectedProductLines = RPSControlFactory.CreateRPSCollectionComboBox<OrderSLConsultQueryView>("b8ccd911-2b18-4424-a922-8a247608d8f6","","",false, this);
 
            SelectedProductFamilies = RPSControlFactory.CreateRPSCollectionComboBox<OrderSLConsultQueryView>("71231434-e726-4618-a4d6-92081a422e40","","",false, this);
 
            SelectedProductSubFamilies = RPSControlFactory.CreateRPSCollectionComboBox<OrderSLConsultQueryView>("81b8ebf6-de89-4d3a-ac72-539181cee64f","","",false, this);
 
            LsArticleFilter = RPSControlFactory.CreateRPSCollectionComboBox<OrderSLConsultQueryView>("fe7d9180-9ba5-46e1-bbe0-c5c392359383","","",false, this);
 
            ReferenceCustomer = RPSControlFactory.CreateRPSEnumComboBox<OrderSLConsultQueryView>("3c02acf4-328e-499c-8b4b-c71bcaab69da","","",false, this);
 
            SalesQuoteFilter = RPSControlFactory.CreateRPSComboBox<OrderSLConsultQueryView>("45e895a6-44b3-4261-a0be-ee02e32d6e5b","","",false, this);
 
            OrderNumberCustomer = RPSControlFactory.CreateRPSTextBox<OrderSLConsultQueryView>("345fab5d-c9ee-4f78-b5dc-06b9e45d6b2b","","",false, this);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<OrderSLConsultQueryView>("54f53972-2f4e-4845-bcd5-cac5175a37b3","","",false, this);
 
            IDManufacturingOrder = RPSControlFactory.CreateRPSComboBox<OrderSLConsultQueryView>("73b345b6-b3dd-4fd1-9dcc-58a8f7622165","","",false, this);
 
            InternalCode = RPSControlFactory.CreateRPSTextBox<OrderSLConsultQueryView>("96303638-5ef8-4f3d-b3d4-2fc70d0b25e1","","",false, this);
 
            IDMaintenanceOrder = RPSControlFactory.CreateRPSComboBox<OrderSLConsultQueryView>("9a350280-0255-4f4d-b884-0cc5b1cbedd2","","",false, this);
 
            FrameworkContractSL = RPSControlFactory.CreateRPSComboBox<OrderSLConsultQueryView>("d2fd084a-25d9-4ea1-ab2c-ca7cec8bd97f","","",false, this);
 
            IDMaintenanceContract = RPSControlFactory.CreateRPSComboBox<OrderSLConsultQueryView>("9fd6ad23-d009-4a6d-9fee-f199f6914732","","",false, this);
 
            ChangeOrderSituationCommandButton = RPSControlFactory.CreateRPSButtonToView<OrderSLConsultQueryView,ModifyOrderSituationSLDialogView>("4d96a84a-974b-40b7-a939-866ed4aad623","","", this,Screen.ModifyOrderSituationSLDialogView);
 
            CollectionInit params_OrderSLConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f1857ee3-c5ca-4f51-9520-644dd710be9d",CSSSelectorGrid="",XPathGrid=""};
            OrderSLConsult = RPSControlFactory.RPSCreateCollectionWithGrid<OrderSLConsultCollectionEditor<OrderSLConsultQueryView,ModifyOrderSituationSLDialogView>,OrderSLConsultQueryView,ModifyOrderSituationSLDialogView>( params_OrderSLConsult,this,Screen.ModifyOrderSituationSLDialogView);
 
            CollectionInit params_OrderLineSLConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="e7fba66c-1184-41bf-936b-f9876489bd3f",CSSSelectorGrid="",XPathGrid=""};
            OrderLineSLConsult = RPSControlFactory.RPSCreateCollectionWithGrid<OrderLineSLConsultCollectionEditor<OrderSLConsultQueryView,ModifyOrderSituationSLDialogView>,OrderSLConsultQueryView,ModifyOrderSituationSLDialogView>( params_OrderLineSLConsult,this,Screen.ModifyOrderSituationSLDialogView);
 

        }
        public IRPSCollectionComboBox<OrderSLConsultQueryView> LsOrderSLFilter { get; set; } 
        public IRPSCollectionComboBox<OrderSLConsultQueryView> lsIDCustomerFilter { get; set; } 
        public IRPSTextBox<OrderSLConsultQueryView> OrderDateFromFilter { get; set; } 
        public IRPSTextBox<OrderSLConsultQueryView> OrderDateToFilter { get; set; } 
        public IRPSTextBox<OrderSLConsultQueryView> ReceptionDateFromFilter { get; set; } 
        public IRPSTextBox<OrderSLConsultQueryView> ReceptionDateToFilter { get; set; } 
        public IRPSOption<OrderSLConsultQueryView> All { get; set; } 
        public IRPSOption<OrderSLConsultQueryView> PendingReceive { get; set; } 
        public IRPSOption<OrderSLConsultQueryView> PendingInvoice { get; set; } 
        public IRPSOption<OrderSLConsultQueryView> Empresa { get; set; } 
        public IRPSOption<OrderSLConsultQueryView> Albaran { get; set; } 
        public IRPSCollectionComboBox<OrderSLConsultQueryView> OrderSituationSL { get; set; } 
        public IRPSCollectionComboBox<OrderSLConsultQueryView> SelectedProductLines { get; set; } 
        public IRPSCollectionComboBox<OrderSLConsultQueryView> SelectedProductFamilies { get; set; } 
        public IRPSCollectionComboBox<OrderSLConsultQueryView> SelectedProductSubFamilies { get; set; } 
        public IRPSCollectionComboBox<OrderSLConsultQueryView> LsArticleFilter { get; set; } 
        public IRPSComboBox<OrderSLConsultQueryView> ReferenceCustomer { get; set; } 
        public IRPSComboBox<OrderSLConsultQueryView> SalesQuoteFilter { get; set; } 
        public IRPSTextBox<OrderSLConsultQueryView> OrderNumberCustomer { get; set; } 
        public IRPSComboBox<OrderSLConsultQueryView> IDProject { get; set; } 
        public IRPSComboBox<OrderSLConsultQueryView> IDManufacturingOrder { get; set; } 
        public IRPSTextBox<OrderSLConsultQueryView> InternalCode { get; set; } 
        public IRPSComboBox<OrderSLConsultQueryView> IDMaintenanceOrder { get; set; } 
        public IRPSComboBox<OrderSLConsultQueryView> FrameworkContractSL { get; set; } 
        public IRPSComboBox<OrderSLConsultQueryView> IDMaintenanceContract { get; set; } 
        public IRPSButton<OrderSLConsultQueryView,ModifyOrderSituationSLDialogView> ChangeOrderSituationCommandButton { get; set; } 
        public OrderSLConsultCollectionEditor<OrderSLConsultQueryView,ModifyOrderSituationSLDialogView> OrderSLConsult { get; set; } 
        public OrderLineSLConsultCollectionEditor<OrderSLConsultQueryView,ModifyOrderSituationSLDialogView> OrderLineSLConsult { get; set; } 
        public OrderSLConsult Screen { get; set; }
        public OrderSLConsultQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class OrderSLConsultCollectionEditor<OrderSLConsultQueryView,ModifyOrderSituationSLDialogView>:RPSCollectionEditor<OrderSLConsultQueryView,ModifyOrderSituationSLDialogView> where OrderSLConsultQueryView : class, IView where ModifyOrderSituationSLDialogView : class, IView
    {
        public  OrderSLConsultGridView<OrderSLConsultQueryView,ModifyOrderSituationSLDialogView> GridView {get;set;}
    }
    public partial class OrderSLConsultGridView <OrderSLConsultQueryView,ModifyOrderSituationSLDialogView> :  RPSGridView<OrderSLConsultQueryView,ModifyOrderSituationSLDialogView> where OrderSLConsultQueryView : class, IView where ModifyOrderSituationSLDialogView : class, IView
    {
        public OrderSLConsultGridView(OrderSLConsultQueryView currentView,ModifyOrderSituationSLDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CustomerMiscellaneousSL_Description = RPSControlFactory.CreateRPSGridTextBox<OrderSLConsultQueryView>("","#f1857ee3-c5ca-4f51-9520-644dd710be9d .ag-row[role='row']@ROWINDEX [col-id='cCustomerMiscellaneousSL_Description']","",false, this.CurrentView);
 
            OrderSL_OrderDate = RPSControlFactory.CreateRPSGridTextBox<OrderSLConsultQueryView>("","#f1857ee3-c5ca-4f51-9520-644dd710be9d .ag-row[role='row']@ROWINDEX [col-id='cOrderSL_OrderDate']","",false, this.CurrentView);
 
            OrderSL_ReceptionDate = RPSControlFactory.CreateRPSGridTextBox<OrderSLConsultQueryView>("","#f1857ee3-c5ca-4f51-9520-644dd710be9d .ag-row[role='row']@ROWINDEX [col-id='cOrderSL_ReceptionDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<OrderSLConsultQueryView> CustomerMiscellaneousSL_Description { get; set; } 
        public IRPSGridTextBox<OrderSLConsultQueryView> OrderSL_OrderDate { get; set; } 
        public IRPSGridTextBox<OrderSLConsultQueryView> OrderSL_ReceptionDate { get; set; } 
                     
    }
 
        public partial class OrderLineSLConsultCollectionEditor<OrderSLConsultQueryView,ModifyOrderSituationSLDialogView>:RPSCollectionEditor<OrderSLConsultQueryView,ModifyOrderSituationSLDialogView> where OrderSLConsultQueryView : class, IView where ModifyOrderSituationSLDialogView : class, IView
    {
        public  OrderLineSLConsultGridView<OrderSLConsultQueryView,ModifyOrderSituationSLDialogView> GridView {get;set;}
    }
    public partial class OrderLineSLConsultGridView <OrderSLConsultQueryView,ModifyOrderSituationSLDialogView> :  RPSGridView<OrderSLConsultQueryView,ModifyOrderSituationSLDialogView> where OrderSLConsultQueryView : class, IView where ModifyOrderSituationSLDialogView : class, IView
    {
        public OrderLineSLConsultGridView(OrderSLConsultQueryView currentView,ModifyOrderSituationSLDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            OrderLineSL_Description = RPSControlFactory.CreateRPSGridTextBox<OrderSLConsultQueryView>("","#e7fba66c-1184-41bf-936b-f9876489bd3f .ag-row[role='row']@ROWINDEX [col-id='cOrderLineSL_Description']","",false, this.CurrentView);
 
            OrderLineSL_BlockedMRP = RPSControlFactory.CreateRPSGridCheckBox<OrderSLConsultQueryView>("","#e7fba66c-1184-41bf-936b-f9876489bd3f .ag-row[role='row']@ROWINDEX [col-id='cOrderLineSL_BlockedMRP']","",false, this.CurrentView);
 
            OrderLineSL_ReferenceCustomer = RPSControlFactory.CreateRPSGridTextBox<OrderSLConsultQueryView>("","#e7fba66c-1184-41bf-936b-f9876489bd3f .ag-row[role='row']@ROWINDEX [col-id='cOrderLineSL_ReferenceCustomer']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<OrderSLConsultQueryView> OrderLineSL_Description { get; set; } 
        public IRPSGridCheckbox<OrderSLConsultQueryView> OrderLineSL_BlockedMRP { get; set; } 
        public IRPSGridTextBox<OrderSLConsultQueryView> OrderLineSL_ReferenceCustomer { get; set; } 
                     
    }
 
    }
  
            
    public partial class ModifyOrderSituationSLDialogView : View
    {
        public ModifyOrderSituationSLDialogView(OrderSLConsult screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDOrderSituation = RPSControlFactory.CreateRPSComboBox<ModifyOrderSituationSLDialogView>("41fbe8c7-6939-4075-b122-c12af1092116","","",true, this);
 

        }
        public IRPSComboBox<ModifyOrderSituationSLDialogView> IDOrderSituation { get; set; } 
        public OrderSLConsult Screen { get; set; }
        public ModifyOrderSituationSLDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}