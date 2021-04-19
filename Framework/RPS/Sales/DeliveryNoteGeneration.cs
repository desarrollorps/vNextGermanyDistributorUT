    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.DeliveryNoteGeneration
{
    //RPS VERSION 1.0.0.0
    public partial class DeliveryNoteGeneration:Screen
    {
        public DeliveryNoteGeneration():base()
        {
            this.URL = "sales.deliverynotegeneration";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DeliveryNoteGenerationView  = new DeliveryNoteGenerationView(this); 
            DeliveryNoteGenerationView.InitializeControls(); 
           
        }
      
            public DeliveryNoteGenerationView DeliveryNoteGenerationView {get; set; } 
    }
            
    public partial class DeliveryNoteGenerationView : View
    {
        public DeliveryNoteGenerationView(DeliveryNoteGeneration screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            OrderDateFrom = RPSControlFactory.CreateRPSTextBox<DeliveryNoteGenerationView>("58bce59f-e198-4603-9326-eef82aafefec","","",false, this);
 
            OrderDateTo = RPSControlFactory.CreateRPSTextBox<DeliveryNoteGenerationView>("d3c0d31b-cdcf-4e4f-b7ab-8f37dd95b93e","","",false, this);
 
            Customer = RPSControlFactory.CreateRPSCollectionComboBox<DeliveryNoteGenerationView>("c1c6e48b-ba8e-4513-aa00-3ad13167a468","","",false, this);
 
            OrderSL = RPSControlFactory.CreateRPSCollectionComboBox<DeliveryNoteGenerationView>("c7e2ce0f-9b8b-4f3a-ba5e-53badcbdf2ef","","",false, this);
 
            DeliveryNoteTypeGroupSL = RPSControlFactory.CreateRPSCollectionComboBox<DeliveryNoteGenerationView>("e9bc2444-c21b-43e3-ba94-441d6d1463d8","","",false, this);
 
            DeliveryNoteDate = RPSControlFactory.CreateRPSTextBox<DeliveryNoteGenerationView>("af55ea9c-afb9-4218-827a-c96ae4eaae12","","",false, this);
 
            bUpdateDeliveryNotes = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteGenerationView>("c6a50e9b-f39c-480e-837f-360e9430ec84","","",false, this);
 
            bGenerateFinalizedDeliveryNote = RPSControlFactory.CreateRPSCheckBox<DeliveryNoteGenerationView>("4c9b22bb-1ae8-43a8-99e1-e8147e8a43e5","","",false, this);
 
            PrintDeliveryNoteModalNavigationCommand = RPSControlFactory.CreateRPSButton<DeliveryNoteGenerationView>( "de4b8583-f5ee-420c-ac05-b52f1f7c2682","","",this);
 
            CollectionInit params_DeliveryNoteTemp = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="abe6dc3f-b81e-48b8-a326-e5c23d43cb68",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNoteTemp = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNoteTempCollectionEditor<DeliveryNoteGenerationView>,DeliveryNoteGenerationView>( params_DeliveryNoteTemp,this);
 
            CollectionInit params_DeliveryNoteTempSaved = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b8f2b533-ab09-4845-b913-58bd37fde370",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNoteTempSaved = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNoteTempSavedCollectionEditor<DeliveryNoteGenerationView>,DeliveryNoteGenerationView>( params_DeliveryNoteTempSaved,this);
 

        }
        public IRPSTextBox<DeliveryNoteGenerationView> OrderDateFrom { get; set; } 
        public IRPSTextBox<DeliveryNoteGenerationView> OrderDateTo { get; set; } 
        public IRPSCollectionComboBox<DeliveryNoteGenerationView> Customer { get; set; } 
        public IRPSCollectionComboBox<DeliveryNoteGenerationView> OrderSL { get; set; } 
        public IRPSCollectionComboBox<DeliveryNoteGenerationView> DeliveryNoteTypeGroupSL { get; set; } 
        public IRPSTextBox<DeliveryNoteGenerationView> DeliveryNoteDate { get; set; } 
        public IRPSCheckbox<DeliveryNoteGenerationView> bUpdateDeliveryNotes { get; set; } 
        public IRPSCheckbox<DeliveryNoteGenerationView> bGenerateFinalizedDeliveryNote { get; set; } 
        public IRPSButton<DeliveryNoteGenerationView> PrintDeliveryNoteModalNavigationCommand { get; set; } 
        public DeliveryNoteTempCollectionEditor<DeliveryNoteGenerationView> DeliveryNoteTemp { get; set; } 
        public DeliveryNoteTempSavedCollectionEditor<DeliveryNoteGenerationView> DeliveryNoteTempSaved { get; set; } 
        public DeliveryNoteGeneration Screen { get; set; }
        public DeliveryNoteGenerationView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DeliveryNoteTempCollectionEditor<DeliveryNoteGenerationView>:RPSCollectionEditor<DeliveryNoteGenerationView> where DeliveryNoteGenerationView : class, IView
    {
        public  DeliveryNoteTempGridView<DeliveryNoteGenerationView> GridView {get;set;}
    }
    public partial class DeliveryNoteTempGridView <DeliveryNoteGenerationView> :  RPSGridView<DeliveryNoteGenerationView> where DeliveryNoteGenerationView : class, IView
    {
        public DeliveryNoteTempGridView(DeliveryNoteGenerationView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodDeliveryNote = RPSControlFactory.CreateRPSGridTextBox<DeliveryNoteGenerationView>("","#abe6dc3f-b81e-48b8-a326-e5c23d43cb68 .ag-row[role='row']@ROWINDEX [col-id='cCodDeliveryNote']","",false, this.CurrentView);
 
            DecriptionCustomer = RPSControlFactory.CreateRPSGridTextBox<DeliveryNoteGenerationView>("","#abe6dc3f-b81e-48b8-a326-e5c23d43cb68 .ag-row[role='row']@ROWINDEX [col-id='cDecriptionCustomer']","",false, this.CurrentView);
 
            DeliveryNoteDate = RPSControlFactory.CreateRPSGridTextBox<DeliveryNoteGenerationView>("","#abe6dc3f-b81e-48b8-a326-e5c23d43cb68 .ag-row[role='row']@ROWINDEX [col-id='cDeliveryNoteDate']","",false, this.CurrentView);
 
            Base = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteGenerationView>("","#abe6dc3f-b81e-48b8-a326-e5c23d43cb68 .ag-row[role='row']@ROWINDEX [col-id='cBase']","",false, this.CurrentView);
 
            VAT = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteGenerationView>("","#abe6dc3f-b81e-48b8-a326-e5c23d43cb68 .ag-row[role='row']@ROWINDEX [col-id='cVAT']","",false, this.CurrentView);
 
            Total = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteGenerationView>("","#abe6dc3f-b81e-48b8-a326-e5c23d43cb68 .ag-row[role='row']@ROWINDEX [col-id='cTotal']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<DeliveryNoteGenerationView> CodDeliveryNote { get; set; } 
        public IRPSGridTextBox<DeliveryNoteGenerationView> DecriptionCustomer { get; set; } 
        public IRPSGridTextBox<DeliveryNoteGenerationView> DeliveryNoteDate { get; set; } 
        public IRPSGridTextBox<DeliveryNoteGenerationView> Base { get; set; } 
        public IRPSGridTextBox<DeliveryNoteGenerationView> VAT { get; set; } 
        public IRPSGridTextBox<DeliveryNoteGenerationView> Total { get; set; } 
                     
    }
 
        public partial class DeliveryNoteTempSavedCollectionEditor<DeliveryNoteGenerationView>:RPSCollectionEditor<DeliveryNoteGenerationView> where DeliveryNoteGenerationView : class, IView
    {
        public  DeliveryNoteTempSavedGridView<DeliveryNoteGenerationView> GridView {get;set;}
    }
    public partial class DeliveryNoteTempSavedGridView <DeliveryNoteGenerationView> :  RPSGridView<DeliveryNoteGenerationView> where DeliveryNoteGenerationView : class, IView
    {
        public DeliveryNoteTempSavedGridView(DeliveryNoteGenerationView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DecriptionCustomer = RPSControlFactory.CreateRPSGridTextBox<DeliveryNoteGenerationView>("","#b8f2b533-ab09-4845-b913-58bd37fde370 .ag-row[role='row']@ROWINDEX [col-id='cDecriptionCustomer']","",false, this.CurrentView);
 
            DeliveryNoteDate = RPSControlFactory.CreateRPSGridTextBox<DeliveryNoteGenerationView>("","#b8f2b533-ab09-4845-b913-58bd37fde370 .ag-row[role='row']@ROWINDEX [col-id='cDeliveryNoteDate']","",false, this.CurrentView);
 
            Base = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteGenerationView>("","#b8f2b533-ab09-4845-b913-58bd37fde370 .ag-row[role='row']@ROWINDEX [col-id='cBase']","",false, this.CurrentView);
 
            VAT = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteGenerationView>("","#b8f2b533-ab09-4845-b913-58bd37fde370 .ag-row[role='row']@ROWINDEX [col-id='cVAT']","",false, this.CurrentView);
 
            Total = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteGenerationView>("","#b8f2b533-ab09-4845-b913-58bd37fde370 .ag-row[role='row']@ROWINDEX [col-id='cTotal']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<DeliveryNoteGenerationView> DecriptionCustomer { get; set; } 
        public IRPSGridTextBox<DeliveryNoteGenerationView> DeliveryNoteDate { get; set; } 
        public IRPSGridTextBox<DeliveryNoteGenerationView> Base { get; set; } 
        public IRPSGridTextBox<DeliveryNoteGenerationView> VAT { get; set; } 
        public IRPSGridTextBox<DeliveryNoteGenerationView> Total { get; set; } 
                     
    }
 
    }
  
    

}