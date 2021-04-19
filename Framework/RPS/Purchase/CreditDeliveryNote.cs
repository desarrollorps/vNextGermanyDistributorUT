    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.CreditDeliveryNote
{
    //RPS VERSION 1.0.0.0
    public partial class CreditDeliveryNote:Screen
    {
        public CreditDeliveryNote():base()
        {
            this.URL = "purchase.creditdeliverynote";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CreditDeliveryNoteView  = new CreditDeliveryNoteView(this); 
            CreditDeliveryNoteProcessResultVMChildDialogView  = new CreditDeliveryNoteProcessResultVMChildDialogView(this); 
            CreditDeliveryNoteView.InitializeControls(); 
            CreditDeliveryNoteProcessResultVMChildDialogView.InitializeControls(); 
           
        }
      
            public CreditDeliveryNoteView CreditDeliveryNoteView {get; set; } 
            public CreditDeliveryNoteProcessResultVMChildDialogView CreditDeliveryNoteProcessResultVMChildDialogView {get; set; } 
    }
            
    public partial class CreditDeliveryNoteView : View
    {
        public CreditDeliveryNoteView(CreditDeliveryNote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Supplier = RPSControlFactory.CreateRPSComboBox<CreditDeliveryNoteView>("c873c1ba-729e-4f16-a7a2-b126c5b5f704","","",true, this);
 
            DeliveryNote = RPSControlFactory.CreateRPSComboBox<CreditDeliveryNoteView>("73d54b49-0986-4806-be70-eabdd1cd23f1","","",false, this);
 
            UIDeliveryNoteDate = RPSControlFactory.CreateRPSTextBox<CreditDeliveryNoteView>("866390f5-94f9-4518-b44d-199f56eaa74e","","",false, this);
 
            UICreditDate = RPSControlFactory.CreateRPSTextBox<CreditDeliveryNoteView>("d1af2de7-8a26-471a-91cd-1aa69c4f6fa4","","",false, this);
 
            Transport = RPSControlFactory.CreateRPSFormattedTextBox<CreditDeliveryNoteView>("9a2dbd01-7fe4-44cd-a765-2e2e1fb2d1a6","","",false, this);
 
            GridReturnCause = RPSControlFactory.CreateRPSComboBox<CreditDeliveryNoteView>("b67ab566-6bd5-4730-87ab-e38c25cc98af","","",false, this);
 
            UIWarehouse = RPSControlFactory.CreateRPSComboBox<CreditDeliveryNoteView>("4a5ea047-2ede-4655-9d5d-42d53a588104","","",false, this);
 
            IDNewDeliveryNote = RPSControlFactory.CreateRPSTextBox<CreditDeliveryNoteView>("abd2514a-d0db-4559-b9ed-e6e31f3c581c","","",false, this);
 
            UIOptTotal = RPSControlFactory.CreateRPSOption<CreditDeliveryNoteView>( "ae7ac6dd-fc0f-423e-8b7b-84037e606222","","",this);
 
            UIOptPartial = RPSControlFactory.CreateRPSOption<CreditDeliveryNoteView>( "f0eef2db-cd03-4e5d-a169-af6cd68cbe14","","",this);
 
            FinalizeDeliveryNote = RPSControlFactory.CreateRPSCheckBox<CreditDeliveryNoteView>("9e4eeeee-c8ea-4218-990a-21ff428fd045","","",false, this);
 
            UINoImputationCost = RPSControlFactory.CreateRPSCheckBox<CreditDeliveryNoteView>("f94d22a9-f8af-46d0-81b3-3467832339e3","","",false, this);
 
            CollectionInit params_DeliveryNoteCreditLines = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="9f65a2a6-8ec8-4421-b2fd-1fff237f3190",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNoteCreditLines = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNoteCreditLinesCollectionEditor<CreditDeliveryNoteView,CreditDeliveryNoteProcessResultVMChildDialogView>,CreditDeliveryNoteView,CreditDeliveryNoteProcessResultVMChildDialogView>( params_DeliveryNoteCreditLines,this,Screen.CreditDeliveryNoteProcessResultVMChildDialogView);
 

        }
        public IRPSComboBox<CreditDeliveryNoteView> Supplier { get; set; } 
        public IRPSComboBox<CreditDeliveryNoteView> DeliveryNote { get; set; } 
        public IRPSTextBox<CreditDeliveryNoteView> UIDeliveryNoteDate { get; set; } 
        public IRPSTextBox<CreditDeliveryNoteView> UICreditDate { get; set; } 
        public IRPSTextBox<CreditDeliveryNoteView> Transport { get; set; } 
        public IRPSComboBox<CreditDeliveryNoteView> GridReturnCause { get; set; } 
        public IRPSComboBox<CreditDeliveryNoteView> UIWarehouse { get; set; } 
        public IRPSTextBox<CreditDeliveryNoteView> IDNewDeliveryNote { get; set; } 
        public IRPSOption<CreditDeliveryNoteView> UIOptTotal { get; set; } 
        public IRPSOption<CreditDeliveryNoteView> UIOptPartial { get; set; } 
        public IRPSCheckbox<CreditDeliveryNoteView> FinalizeDeliveryNote { get; set; } 
        public IRPSCheckbox<CreditDeliveryNoteView> UINoImputationCost { get; set; } 
        public DeliveryNoteCreditLinesCollectionEditor<CreditDeliveryNoteView,CreditDeliveryNoteProcessResultVMChildDialogView> DeliveryNoteCreditLines { get; set; } 
        public CreditDeliveryNote Screen { get; set; }
        public CreditDeliveryNoteView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DeliveryNoteCreditLinesCollectionEditor<CreditDeliveryNoteView,CreditDeliveryNoteProcessResultVMChildDialogView>:RPSCollectionEditor<CreditDeliveryNoteView,CreditDeliveryNoteProcessResultVMChildDialogView> where CreditDeliveryNoteView : class, IView where CreditDeliveryNoteProcessResultVMChildDialogView : class, IView
    {
        public  DeliveryNoteCreditLinesGridView<CreditDeliveryNoteView,CreditDeliveryNoteProcessResultVMChildDialogView> GridView {get;set;}
    }
    public partial class DeliveryNoteCreditLinesGridView <CreditDeliveryNoteView,CreditDeliveryNoteProcessResultVMChildDialogView> :  RPSGridView<CreditDeliveryNoteView,CreditDeliveryNoteProcessResultVMChildDialogView> where CreditDeliveryNoteView : class, IView where CreditDeliveryNoteProcessResultVMChildDialogView : class, IView
    {
        public DeliveryNoteCreditLinesGridView(CreditDeliveryNoteView currentView,CreditDeliveryNoteProcessResultVMChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeliveryNoteLine_Ordenation = RPSControlFactory.CreateRPSGridFormattedTextBox<CreditDeliveryNoteView>("","#9f65a2a6-8ec8-4421-b2fd-1fff237f3190 .ag-row[role='row']@ROWINDEX [col-id='cDeliveryNoteLine_Ordenation']","",false, this.CurrentView);
 
            DeliveryNoteLine_Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<CreditDeliveryNoteView>("","#9f65a2a6-8ec8-4421-b2fd-1fff237f3190 .ag-row[role='row']@ROWINDEX [col-id='cDeliveryNoteLine_Quantity']","",false, this.CurrentView);
 
            UISite = RPSControlFactory.CreateRPSGridComboBox<CreditDeliveryNoteView>("","#9f65a2a6-8ec8-4421-b2fd-1fff237f3190 .ag-row[role='row']@ROWINDEX [col-id='cUISite']","",false, this.CurrentView);
 
            UIWarehouse = RPSControlFactory.CreateRPSGridComboBox<CreditDeliveryNoteView>("","#9f65a2a6-8ec8-4421-b2fd-1fff237f3190 .ag-row[role='row']@ROWINDEX [col-id='cUIWarehouse']","",false, this.CurrentView);
 
            DeliveryNoteLine_Series = RPSControlFactory.CreateRPSGridTextBox<CreditDeliveryNoteView>("","#9f65a2a6-8ec8-4421-b2fd-1fff237f3190 .ag-row[role='row']@ROWINDEX [col-id='cDeliveryNoteLine_Series']","",false, this.CurrentView);
 
            LineReturnCause = RPSControlFactory.CreateRPSGridComboBox<CreditDeliveryNoteView>("","#9f65a2a6-8ec8-4421-b2fd-1fff237f3190 .ag-row[role='row']@ROWINDEX [col-id='cLineReturnCause']","",false, this.CurrentView);
 
            CREDITQUANTITY = RPSControlFactory.CreateRPSGridFormattedTextBox<CreditDeliveryNoteView>("","#9f65a2a6-8ec8-4421-b2fd-1fff237f3190 .ag-row[role='row']@ROWINDEX [col-id='cCREDITQUANTITY']","",false, this.CurrentView);
 
            CREDITQUANTITYSECONDUNIT = RPSControlFactory.CreateRPSGridFormattedTextBox<CreditDeliveryNoteView>("","#9f65a2a6-8ec8-4421-b2fd-1fff237f3190 .ag-row[role='row']@ROWINDEX [col-id='cCREDITQUANTITYSECONDUNIT']","",false, this.CurrentView);
 
            IDLocationWarehouse = RPSControlFactory.CreateRPSGridComboBox<CreditDeliveryNoteView>("","#9f65a2a6-8ec8-4421-b2fd-1fff237f3190 .ag-row[role='row']@ROWINDEX [col-id='cIDLocationWarehouse']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CreditDeliveryNoteView> DeliveryNoteLine_Ordenation { get; set; } 
        public IRPSGridTextBox<CreditDeliveryNoteView> DeliveryNoteLine_Quantity { get; set; } 
        public IRPSGridComboBox<CreditDeliveryNoteView> UISite { get; set; } 
        public IRPSGridComboBox<CreditDeliveryNoteView> UIWarehouse { get; set; } 
        public IRPSGridTextBox<CreditDeliveryNoteView> DeliveryNoteLine_Series { get; set; } 
        public IRPSGridComboBox<CreditDeliveryNoteView> LineReturnCause { get; set; } 
        public IRPSGridTextBox<CreditDeliveryNoteView> CREDITQUANTITY { get; set; } 
        public IRPSGridTextBox<CreditDeliveryNoteView> CREDITQUANTITYSECONDUNIT { get; set; } 
        public IRPSGridComboBox<CreditDeliveryNoteView> IDLocationWarehouse { get; set; } 
                     
    }
 
    }
  
            
    public partial class CreditDeliveryNoteProcessResultVMChildDialogView : View
    {
        public CreditDeliveryNoteProcessResultVMChildDialogView(CreditDeliveryNote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_GenerateCreditInvoiceResult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="561d3e2f-c257-4256-b039-6c1d653b5aa7",CSSSelectorGrid="",XPathGrid=""};
            GenerateCreditInvoiceResult = RPSControlFactory.RPSCreateCollectionWithGrid<GenerateCreditInvoiceResultCollectionEditor<CreditDeliveryNoteProcessResultVMChildDialogView>,CreditDeliveryNoteProcessResultVMChildDialogView>( params_GenerateCreditInvoiceResult,this);
 

        }
        public GenerateCreditInvoiceResultCollectionEditor<CreditDeliveryNoteProcessResultVMChildDialogView> GenerateCreditInvoiceResult { get; set; } 
        public CreditDeliveryNote Screen { get; set; }
        public CreditDeliveryNoteProcessResultVMChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GenerateCreditInvoiceResultCollectionEditor<CreditDeliveryNoteProcessResultVMChildDialogView>:RPSCollectionEditor<CreditDeliveryNoteProcessResultVMChildDialogView> where CreditDeliveryNoteProcessResultVMChildDialogView : class, IView
    {
        public  GenerateCreditInvoiceResultGridView<CreditDeliveryNoteProcessResultVMChildDialogView> GridView {get;set;}
    }
    public partial class GenerateCreditInvoiceResultGridView <CreditDeliveryNoteProcessResultVMChildDialogView> :  RPSGridView<CreditDeliveryNoteProcessResultVMChildDialogView> where CreditDeliveryNoteProcessResultVMChildDialogView : class, IView
    {
        public GenerateCreditInvoiceResultGridView(CreditDeliveryNoteProcessResultVMChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeliveryNote_DeliveryNoteDate = RPSControlFactory.CreateRPSGridTextBox<CreditDeliveryNoteProcessResultVMChildDialogView>("","#561d3e2f-c257-4256-b039-6c1d653b5aa7 .ag-row[role='row']@ROWINDEX [col-id='cDeliveryNote_DeliveryNoteDate']","",false, this.CurrentView);
 
            DeliveryNote_TotalAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<CreditDeliveryNoteProcessResultVMChildDialogView>("","#561d3e2f-c257-4256-b039-6c1d653b5aa7 .ag-row[role='row']@ROWINDEX [col-id='cDeliveryNote_TotalAmount']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CreditDeliveryNoteProcessResultVMChildDialogView> DeliveryNote_DeliveryNoteDate { get; set; } 
        public IRPSGridTextBox<CreditDeliveryNoteProcessResultVMChildDialogView> DeliveryNote_TotalAmount { get; set; } 
                     
    }
 
    }
  
    

}