    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.DeliveryNotesConsumptionConsultation
{
    //RPS VERSION 1.0.0.0
    public partial class DeliveryNotesConsumptionConsultation:Screen
    {
        public DeliveryNotesConsumptionConsultation():base()
        {
            this.URL = "sales.deliverynotesconsumptionconsultation";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DeliveryNotesConsumptionConsultationView  = new DeliveryNotesConsumptionConsultationView(this); 
            DeliveryNotesConsumptionConsultationView.InitializeControls(); 
           
        }
      
            public DeliveryNotesConsumptionConsultationView DeliveryNotesConsumptionConsultationView {get; set; } 
    }
            
    public partial class DeliveryNotesConsumptionConsultationView : View
    {
        public DeliveryNotesConsumptionConsultationView(DeliveryNotesConsumptionConsultation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<DeliveryNotesConsumptionConsultationView>("3001d1e9-7137-44c1-b1f8-9ece526ccc32","","",true, this);
 
            WareHouse = RPSControlFactory.CreateRPSComboBox<DeliveryNotesConsumptionConsultationView>("d3218af6-6323-4605-a966-7c401c06aaa7","","",true, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<DeliveryNotesConsumptionConsultationView>("c51e4e1a-4afa-4c2f-82e2-110bc2f01f5d","","",true, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<DeliveryNotesConsumptionConsultationView>("96dcf09c-1fd9-43ef-ae8a-29c423068f28","","",true, this);
 
            Article = RPSControlFactory.CreateRPSComboBox<DeliveryNotesConsumptionConsultationView>("592155a8-f4f8-4ab9-aac5-9edbd06a3c3c","","",true, this);
 
            Stock = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNotesConsumptionConsultationView>("d94a8439-233b-40c0-a4b7-950d8eaed503","","",false, this);
 
            Stock2 = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNotesConsumptionConsultationView>("4e70ad49-2cee-49b0-8768-b0803efbd756","","",false, this);
 
            TotalConsumption = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNotesConsumptionConsultationView>("57461bcb-2f4b-43c1-bb36-59a3e089b884","","",false, this);
 
            TotalNotConsumption = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNotesConsumptionConsultationView>("d0d114d0-716f-4ca1-94d8-579bd92c04d6","","",false, this);
 
            CollectionInit params_DevNoteNotConsumedConsultation = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="39bafab4-3177-473d-8c27-4f73e7476ccc",CSSSelectorGrid="",XPathGrid=""};
            DevNoteNotConsumedConsultation = RPSControlFactory.RPSCreateCollectionWithGrid<DevNoteNotConsumedConsultationCollectionEditor<DeliveryNotesConsumptionConsultationView>,DeliveryNotesConsumptionConsultationView>( params_DevNoteNotConsumedConsultation,this);
 
            CollectionInit params_DevNoteConsumedConsultation = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b052b6c3-0459-407c-8efd-9a2683fe88fe",CSSSelectorGrid="",XPathGrid=""};
            DevNoteConsumedConsultation = RPSControlFactory.RPSCreateCollectionWithGrid<DevNoteConsumedConsultationCollectionEditor<DeliveryNotesConsumptionConsultationView>,DeliveryNotesConsumptionConsultationView>( params_DevNoteConsumedConsultation,this);
 

        }
        public IRPSComboBox<DeliveryNotesConsumptionConsultationView> Site { get; set; } 
        public IRPSComboBox<DeliveryNotesConsumptionConsultationView> WareHouse { get; set; } 
        public IRPSTextBox<DeliveryNotesConsumptionConsultationView> DateFrom { get; set; } 
        public IRPSTextBox<DeliveryNotesConsumptionConsultationView> DateTo { get; set; } 
        public IRPSComboBox<DeliveryNotesConsumptionConsultationView> Article { get; set; } 
        public IRPSTextBox<DeliveryNotesConsumptionConsultationView> Stock { get; set; } 
        public IRPSTextBox<DeliveryNotesConsumptionConsultationView> Stock2 { get; set; } 
        public IRPSTextBox<DeliveryNotesConsumptionConsultationView> TotalConsumption { get; set; } 
        public IRPSTextBox<DeliveryNotesConsumptionConsultationView> TotalNotConsumption { get; set; } 
        public DevNoteNotConsumedConsultationCollectionEditor<DeliveryNotesConsumptionConsultationView> DevNoteNotConsumedConsultation { get; set; } 
        public DevNoteConsumedConsultationCollectionEditor<DeliveryNotesConsumptionConsultationView> DevNoteConsumedConsultation { get; set; } 
        public DeliveryNotesConsumptionConsultation Screen { get; set; }
        public DeliveryNotesConsumptionConsultationView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DevNoteNotConsumedConsultationCollectionEditor<DeliveryNotesConsumptionConsultationView>:RPSCollectionEditor<DeliveryNotesConsumptionConsultationView> where DeliveryNotesConsumptionConsultationView : class, IView
    {
        public  DevNoteNotConsumedConsultationGridView<DeliveryNotesConsumptionConsultationView> GridView {get;set;}
    }
    public partial class DevNoteNotConsumedConsultationGridView <DeliveryNotesConsumptionConsultationView> :  RPSGridView<DeliveryNotesConsumptionConsultationView> where DeliveryNotesConsumptionConsultationView : class, IView
    {
        public DevNoteNotConsumedConsultationGridView(DeliveryNotesConsumptionConsultationView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeliveryNoteDate = RPSControlFactory.CreateRPSGridTextBox<DeliveryNotesConsumptionConsultationView>("","#39bafab4-3177-473d-8c27-4f73e7476ccc .ag-row[role='row']@ROWINDEX [col-id='cDeliveryNoteDate']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNotesConsumptionConsultationView>("","#39bafab4-3177-473d-8c27-4f73e7476ccc .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNotesConsumptionConsultationView>("","#39bafab4-3177-473d-8c27-4f73e7476ccc .ag-row[role='row']@ROWINDEX [col-id='cQuantitySecondUnit']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<DeliveryNotesConsumptionConsultationView> DeliveryNoteDate { get; set; } 
        public IRPSGridTextBox<DeliveryNotesConsumptionConsultationView> Quantity { get; set; } 
        public IRPSGridTextBox<DeliveryNotesConsumptionConsultationView> QuantitySecondUnit { get; set; } 
                     
    }
 
        public partial class DevNoteConsumedConsultationCollectionEditor<DeliveryNotesConsumptionConsultationView>:RPSCollectionEditor<DeliveryNotesConsumptionConsultationView> where DeliveryNotesConsumptionConsultationView : class, IView
    {
        public  DevNoteConsumedConsultationGridView<DeliveryNotesConsumptionConsultationView> GridView {get;set;}
    }
    public partial class DevNoteConsumedConsultationGridView <DeliveryNotesConsumptionConsultationView> :  RPSGridView<DeliveryNotesConsumptionConsultationView> where DeliveryNotesConsumptionConsultationView : class, IView
    {
        public DevNoteConsumedConsultationGridView(DeliveryNotesConsumptionConsultationView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeliveryNoteDate = RPSControlFactory.CreateRPSGridTextBox<DeliveryNotesConsumptionConsultationView>("","#b052b6c3-0459-407c-8efd-9a2683fe88fe .ag-row[role='row']@ROWINDEX [col-id='cDeliveryNoteDate']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNotesConsumptionConsultationView>("","#b052b6c3-0459-407c-8efd-9a2683fe88fe .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNotesConsumptionConsultationView>("","#b052b6c3-0459-407c-8efd-9a2683fe88fe .ag-row[role='row']@ROWINDEX [col-id='cQuantitySecondUnit']","",false, this.CurrentView);
 
            InvoicedQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNotesConsumptionConsultationView>("","#b052b6c3-0459-407c-8efd-9a2683fe88fe .ag-row[role='row']@ROWINDEX [col-id='cInvoicedQuantity']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<DeliveryNotesConsumptionConsultationView> DeliveryNoteDate { get; set; } 
        public IRPSGridTextBox<DeliveryNotesConsumptionConsultationView> Quantity { get; set; } 
        public IRPSGridTextBox<DeliveryNotesConsumptionConsultationView> QuantitySecondUnit { get; set; } 
        public IRPSGridTextBox<DeliveryNotesConsumptionConsultationView> InvoicedQuantity { get; set; } 
                     
    }
 
    }
  
    

}