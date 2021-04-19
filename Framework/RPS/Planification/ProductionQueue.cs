    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Planification.ProductionQueue
{
    //RPS VERSION 1.0.0.0
    public partial class ProductionQueue:Screen
    {
        public ProductionQueue():base()
        {
            this.URL = "planification.productionqueue";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ProductionQueueQueryView  = new ProductionQueueQueryView(this); 
            ProductionQueueQueryView.InitializeControls(); 
           
        }
      
            public ProductionQueueQueryView ProductionQueueQueryView {get; set; } 
    }
            
    public partial class ProductionQueueQueryView : View
    {
        public ProductionQueueQueryView(ProductionQueue screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIProductionUnit = RPSControlFactory.CreateRPSComboBox<ProductionQueueQueryView>("64f20b1c-67b2-44bb-b34f-cc53be424211","","",false, this);
 
            UICustomer = RPSControlFactory.CreateRPSComboBox<ProductionQueueQueryView>("73dee7da-cba8-4a33-b904-dbf403ffa721","","",false, this);
 
            UILstArticle = RPSControlFactory.CreateRPSCollectionComboBox<ProductionQueueQueryView>("908476c4-de9a-4953-a089-00edd60e4ac5","","",false, this);
 
            UIDeliveryDateFrom = RPSControlFactory.CreateRPSTextBox<ProductionQueueQueryView>("18f49589-a8a8-4d48-b8d5-455a5f9d79c5","","",false, this);
 
            UIDeliveryDateTo = RPSControlFactory.CreateRPSTextBox<ProductionQueueQueryView>("e9e53250-323a-4451-92f9-21f2890e4ab1","","",false, this);
 
            UIStartDateFrom = RPSControlFactory.CreateRPSTextBox<ProductionQueueQueryView>("87020e2a-1cf3-4004-994c-ecbff8249c65","","",false, this);
 
            UIStartDateTo = RPSControlFactory.CreateRPSTextBox<ProductionQueueQueryView>("7c415cfc-4709-42cb-a283-c5d0745d9812","","",false, this);
 
            UIEndDateFrom = RPSControlFactory.CreateRPSTextBox<ProductionQueueQueryView>("01b1f58f-fbfe-469a-a268-771e9b5e52fe","","",false, this);
 
            UIEndDateTo = RPSControlFactory.CreateRPSTextBox<ProductionQueueQueryView>("6f6417b9-e1cc-485d-87d1-bc8f9e14c22d","","",false, this);
 
            EntryDate = RPSControlFactory.CreateRPSTextBox<ProductionQueueQueryView>("b3d6e33a-f973-49e0-84d6-c856b2cbe1cf","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<ProductionQueueQueryView>("0c27749e-c137-4d36-ad37-0a694f335e6d","","",false, this);
 
            EffortQuantity = RPSControlFactory.CreateRPSFormattedTextBox<ProductionQueueQueryView>("2982bf8b-b4b4-45a3-8257-103380be74f6","","",false, this);
 
            Availability = RPSControlFactory.CreateRPSFormattedTextBox<ProductionQueueQueryView>("f6b32337-f123-4b06-a2c9-33cb4ebe2f62","","",false, this);
 
            CalcStartDate = RPSControlFactory.CreateRPSTextBox<ProductionQueueQueryView>("c80cb73c-a99e-457e-b65e-ab77d8ec3651","","",false, this);
 
            CalcEndDate = RPSControlFactory.CreateRPSTextBox<ProductionQueueQueryView>("b4f605b6-6fe4-43f2-828e-1a079801a5b6","","",false, this);
 
            QuantityChanged = RPSControlFactory.CreateRPSCheckBox<ProductionQueueQueryView>("4e8e6aaf-8a5c-49da-9284-544f7b54890a","","",false, this);
 
            DeleteCommandButton = RPSControlFactory.CreateRPSButton<ProductionQueueQueryView>( "9b237012-d27f-44af-a2da-bae56c4b4a82","","",this);
 
            CollectionInit params_ProductionQueue = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c46a4a49-f201-4863-b47b-39a8fb55e822",CSSSelectorGrid="",XPathGrid=""};
            ProductionQueue = RPSControlFactory.RPSCreateCollectionWithGrid<ProductionQueueCollectionEditor<ProductionQueueQueryView>,ProductionQueueQueryView>( params_ProductionQueue,this);
 
            CollectionInit params_ProductionQueueDetail = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="587e13ac-33a9-4030-beba-987f06088b78",CSSSelectorGrid="",XPathGrid=""};
            ProductionQueueDetail = RPSControlFactory.RPSCreateCollectionWithGrid<ProductionQueueDetailCollectionEditor<ProductionQueueQueryView>,ProductionQueueQueryView>( params_ProductionQueueDetail,this);
 

        }
        public IRPSComboBox<ProductionQueueQueryView> UIProductionUnit { get; set; } 
        public IRPSComboBox<ProductionQueueQueryView> UICustomer { get; set; } 
        public IRPSCollectionComboBox<ProductionQueueQueryView> UILstArticle { get; set; } 
        public IRPSTextBox<ProductionQueueQueryView> UIDeliveryDateFrom { get; set; } 
        public IRPSTextBox<ProductionQueueQueryView> UIDeliveryDateTo { get; set; } 
        public IRPSTextBox<ProductionQueueQueryView> UIStartDateFrom { get; set; } 
        public IRPSTextBox<ProductionQueueQueryView> UIStartDateTo { get; set; } 
        public IRPSTextBox<ProductionQueueQueryView> UIEndDateFrom { get; set; } 
        public IRPSTextBox<ProductionQueueQueryView> UIEndDateTo { get; set; } 
        public IRPSTextBox<ProductionQueueQueryView> EntryDate { get; set; } 
        public IRPSTextBox<ProductionQueueQueryView> Quantity { get; set; } 
        public IRPSTextBox<ProductionQueueQueryView> EffortQuantity { get; set; } 
        public IRPSTextBox<ProductionQueueQueryView> Availability { get; set; } 
        public IRPSTextBox<ProductionQueueQueryView> CalcStartDate { get; set; } 
        public IRPSTextBox<ProductionQueueQueryView> CalcEndDate { get; set; } 
        public IRPSCheckbox<ProductionQueueQueryView> QuantityChanged { get; set; } 
        public IRPSButton<ProductionQueueQueryView> DeleteCommandButton { get; set; } 
        public ProductionQueueCollectionEditor<ProductionQueueQueryView> ProductionQueue { get; set; } 
        public ProductionQueueDetailCollectionEditor<ProductionQueueQueryView> ProductionQueueDetail { get; set; } 
        public ProductionQueue Screen { get; set; }
        public ProductionQueueQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ProductionQueueCollectionEditor<ProductionQueueQueryView>:RPSCollectionEditor<ProductionQueueQueryView> where ProductionQueueQueryView : class, IView
    {
        public  ProductionQueueGridView<ProductionQueueQueryView> GridView {get;set;}
    }
    public partial class ProductionQueueGridView <ProductionQueueQueryView> :  RPSGridView<ProductionQueueQueryView> where ProductionQueueQueryView : class, IView
    {
        public ProductionQueueGridView(ProductionQueueQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<ProductionQueueQueryView>("","#c46a4a49-f201-4863-b47b-39a8fb55e822 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            CalcStartDate = RPSControlFactory.CreateRPSGridTextBox<ProductionQueueQueryView>("","#c46a4a49-f201-4863-b47b-39a8fb55e822 .ag-row[role='row']@ROWINDEX [col-id='cCalcStartDate']","",false, this.CurrentView);
 
            CalcEndDate = RPSControlFactory.CreateRPSGridTextBox<ProductionQueueQueryView>("","#c46a4a49-f201-4863-b47b-39a8fb55e822 .ag-row[role='row']@ROWINDEX [col-id='cCalcEndDate']","",false, this.CurrentView);
 
            Availability = RPSControlFactory.CreateRPSGridFormattedTextBox<ProductionQueueQueryView>("","#c46a4a49-f201-4863-b47b-39a8fb55e822 .ag-row[role='row']@ROWINDEX [col-id='cAvailability']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ProductionQueueQueryView> Quantity { get; set; } 
        public IRPSGridTextBox<ProductionQueueQueryView> CalcStartDate { get; set; } 
        public IRPSGridTextBox<ProductionQueueQueryView> CalcEndDate { get; set; } 
        public IRPSGridTextBox<ProductionQueueQueryView> Availability { get; set; } 
                     
    }
 
        public partial class ProductionQueueDetailCollectionEditor<ProductionQueueQueryView>:RPSCollectionEditor<ProductionQueueQueryView> where ProductionQueueQueryView : class, IView
    {
        public  ProductionQueueDetailGridView<ProductionQueueQueryView> GridView {get;set;}
    }
    public partial class ProductionQueueDetailGridView <ProductionQueueQueryView> :  RPSGridView<ProductionQueueQueryView> where ProductionQueueQueryView : class, IView
    {
        public ProductionQueueDetailGridView(ProductionQueueQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ProductionQueueDetail_Date = RPSControlFactory.CreateRPSGridTextBox<ProductionQueueQueryView>("","#587e13ac-33a9-4030-beba-987f06088b78 .ag-row[role='row']@ROWINDEX [col-id='cProductionQueueDetail_Date']","",false, this.CurrentView);
 
            ProductionQueueDetail_OccupiedQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<ProductionQueueQueryView>("","#587e13ac-33a9-4030-beba-987f06088b78 .ag-row[role='row']@ROWINDEX [col-id='cProductionQueueDetail_OccupiedQuantity']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ProductionQueueQueryView> ProductionQueueDetail_Date { get; set; } 
        public IRPSGridTextBox<ProductionQueueQueryView> ProductionQueueDetail_OccupiedQuantity { get; set; } 
                     
    }
 
    }
  
    

}