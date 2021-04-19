    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.DeliveryNotesConsumptionConsultation
{
    //RPS VERSION 1.0.0.0
    public partial class DeliveryNotesConsumptionConsultation:Screen
    {
        public DeliveryNotesConsumptionConsultation():base()
        {
            this.URL = "purchase.deliverynotesconsumptionconsultation";
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
            Site = RPSControlFactory.CreateRPSComboBox<DeliveryNotesConsumptionConsultationView>("c4456a01-deab-41d0-96ae-3f2d5f34950c","","",false, this);
 
            WareHouse = RPSControlFactory.CreateRPSComboBox<DeliveryNotesConsumptionConsultationView>("4f6eafac-46d9-4ff4-b7c4-1e1fec9eaecb","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<DeliveryNotesConsumptionConsultationView>("ae014983-7ed4-46b4-bb5b-04a07c700baa","","",true, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<DeliveryNotesConsumptionConsultationView>("cdb23e8d-7dec-41ed-9006-eb22468a57d6","","",true, this);
 
            Article = RPSControlFactory.CreateRPSComboBox<DeliveryNotesConsumptionConsultationView>("3bfd3da4-c5d5-4f0b-8724-cb7000cc2529","","",false, this);
 
            Stock = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNotesConsumptionConsultationView>("1fc8e40f-0daa-479e-9b82-18d0263c11d0","","",false, this);
 
            Stock2 = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNotesConsumptionConsultationView>("8f1810ad-be3d-41dd-845d-8a43b47e82e2","","",false, this);
 
            TotalConsumed = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNotesConsumptionConsultationView>("ba1d80fc-306e-48ac-8103-ec14a7cb1949","","",false, this);
 
            TotalNotConsumed = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNotesConsumptionConsultationView>("f1899a3d-4104-4475-a3f1-4788d61e4523","","",false, this);
 
            CollectionInit params_DevNoteNotConsumedConsultation = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="353176eb-c9bb-4ee0-b1c4-aa06dcb174f2",CSSSelectorGrid="",XPathGrid=""};
            DevNoteNotConsumedConsultation = RPSControlFactory.RPSCreateCollectionWithGrid<DevNoteNotConsumedConsultationCollectionEditor<DeliveryNotesConsumptionConsultationView>,DeliveryNotesConsumptionConsultationView>( params_DevNoteNotConsumedConsultation,this);
 
            CollectionInit params_DevNoteConsumedConsultation = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4b303d54-99e2-49b2-8769-b85a9d0b75fd",CSSSelectorGrid="",XPathGrid=""};
            DevNoteConsumedConsultation = RPSControlFactory.RPSCreateCollectionWithGrid<DevNoteConsumedConsultationCollectionEditor<DeliveryNotesConsumptionConsultationView>,DeliveryNotesConsumptionConsultationView>( params_DevNoteConsumedConsultation,this);
 

        }
        public IRPSComboBox<DeliveryNotesConsumptionConsultationView> Site { get; set; } 
        public IRPSComboBox<DeliveryNotesConsumptionConsultationView> WareHouse { get; set; } 
        public IRPSTextBox<DeliveryNotesConsumptionConsultationView> DateFrom { get; set; } 
        public IRPSTextBox<DeliveryNotesConsumptionConsultationView> DateTo { get; set; } 
        public IRPSComboBox<DeliveryNotesConsumptionConsultationView> Article { get; set; } 
        public IRPSTextBox<DeliveryNotesConsumptionConsultationView> Stock { get; set; } 
        public IRPSTextBox<DeliveryNotesConsumptionConsultationView> Stock2 { get; set; } 
        public IRPSTextBox<DeliveryNotesConsumptionConsultationView> TotalConsumed { get; set; } 
        public IRPSTextBox<DeliveryNotesConsumptionConsultationView> TotalNotConsumed { get; set; } 
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
            DeliveryNoteDate = RPSControlFactory.CreateRPSGridTextBox<DeliveryNotesConsumptionConsultationView>("","#353176eb-c9bb-4ee0-b1c4-aa06dcb174f2 .ag-row[role='row']@ROWINDEX [col-id='cDeliveryNoteDate']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNotesConsumptionConsultationView>("","#353176eb-c9bb-4ee0-b1c4-aa06dcb174f2 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNotesConsumptionConsultationView>("","#353176eb-c9bb-4ee0-b1c4-aa06dcb174f2 .ag-row[role='row']@ROWINDEX [col-id='cQuantitySecondUnit']","",false, this.CurrentView);
 

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
            DeliveryNoteDate = RPSControlFactory.CreateRPSGridTextBox<DeliveryNotesConsumptionConsultationView>("","#4b303d54-99e2-49b2-8769-b85a9d0b75fd .ag-row[role='row']@ROWINDEX [col-id='cDeliveryNoteDate']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNotesConsumptionConsultationView>("","#4b303d54-99e2-49b2-8769-b85a9d0b75fd .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNotesConsumptionConsultationView>("","#4b303d54-99e2-49b2-8769-b85a9d0b75fd .ag-row[role='row']@ROWINDEX [col-id='cQuantitySecondUnit']","",false, this.CurrentView);
 
            InvoicedQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNotesConsumptionConsultationView>("","#4b303d54-99e2-49b2-8769-b85a9d0b75fd .ag-row[role='row']@ROWINDEX [col-id='cInvoicedQuantity']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<DeliveryNotesConsumptionConsultationView> DeliveryNoteDate { get; set; } 
        public IRPSGridTextBox<DeliveryNotesConsumptionConsultationView> Quantity { get; set; } 
        public IRPSGridTextBox<DeliveryNotesConsumptionConsultationView> QuantitySecondUnit { get; set; } 
        public IRPSGridTextBox<DeliveryNotesConsumptionConsultationView> InvoicedQuantity { get; set; } 
                     
    }
 
    }
  
    

}