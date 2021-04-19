    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.InvoiceProcess
{
    //RPS VERSION 1.0.0.0
    public partial class InvoiceProcess:Screen
    {
        public InvoiceProcess():base()
        {
            this.URL = "sales.invoiceprocess";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            InvoiceProcessView  = new InvoiceProcessView(this); 
            InvoiceProcessChildViewModelDialogView  = new InvoiceProcessChildViewModelDialogView(this); 
            InvoiceFinalProcessChildViewDialogView  = new InvoiceFinalProcessChildViewDialogView(this); 
            InvoiceProcessView.InitializeControls(); 
            InvoiceProcessChildViewModelDialogView.InitializeControls(); 
            InvoiceFinalProcessChildViewDialogView.InitializeControls(); 
           
        }
      
            public InvoiceProcessView InvoiceProcessView {get; set; } 
            public InvoiceProcessChildViewModelDialogView InvoiceProcessChildViewModelDialogView {get; set; } 
            public InvoiceFinalProcessChildViewDialogView InvoiceFinalProcessChildViewDialogView {get; set; } 
    }
            
    public partial class InvoiceProcessView : View
    {
        public InvoiceProcessView(InvoiceProcess screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Customers = RPSControlFactory.CreateRPSCollectionComboBox<InvoiceProcessView>("7f5b0008-2e0d-485c-891c-b22456e93d42","","",false, this);
 
            InvoicingTypes = RPSControlFactory.CreateRPSCollectionComboBox<InvoiceProcessView>("e2ea9bad-4953-4415-a722-10f0ddb125f9","","",false, this);
 
            InvoiceTypeGroups = RPSControlFactory.CreateRPSCollectionComboBox<InvoiceProcessView>("0130b508-4c0c-4c35-8d2d-3809ef8eeba8","","",false, this);
 
            eDocumentType = RPSControlFactory.CreateRPSEnumComboBox<InvoiceProcessView>("d1701184-b7ba-4895-856f-abd0988dd2a2","","",false, this);
 
            eDocumentType1 = RPSControlFactory.CreateRPSEnumComboBox<InvoiceProcessView>("54f1a13e-82a4-49be-b05b-66bc0fc010cc","","",false, this);
 
            bAll = RPSControlFactory.CreateRPSCheckBox<InvoiceProcessView>("06857ecc-29bf-42f8-9427-24544edb0c2f","","",false, this);
 
            DeliveryNotes = RPSControlFactory.CreateRPSCollectionComboBox<InvoiceProcessView>("d955f29f-f694-451c-81a6-68ca5cf3de53","","",false, this);
 
            Orders = RPSControlFactory.CreateRPSCollectionComboBox<InvoiceProcessView>("fc7799d4-331b-4cb2-8e54-09cfcbd1656e","","",false, this);
 
            OrderComplete = RPSControlFactory.CreateRPSCheckBox<InvoiceProcessView>("ef54e547-e051-46e4-8617-9114bd38a5ab","","",false, this);
 
            DeliveryNoteDateFrom = RPSControlFactory.CreateRPSTextBox<InvoiceProcessView>("fcca90ad-0e74-4c13-8f44-69ad9fd8f735","","",false, this);
 
            DeliveryNoteDateTo = RPSControlFactory.CreateRPSTextBox<InvoiceProcessView>("9e070e2b-a667-47b5-be06-66b305e33264","","",false, this);
 
            Currencys = RPSControlFactory.CreateRPSCollectionComboBox<InvoiceProcessView>("abe12747-04fb-476a-b7db-a288e6be7c2f","","",false, this);
 
            InvoiceProcessChildViewNavigationCommand = RPSControlFactory.CreateRPSButton<InvoiceProcessView>( "cd71bf1c-b0d7-4eb7-b70f-c4f551eeb55f","","",this);
 

        }
        public IRPSCollectionComboBox<InvoiceProcessView> Customers { get; set; } 
        public IRPSCollectionComboBox<InvoiceProcessView> InvoicingTypes { get; set; } 
        public IRPSCollectionComboBox<InvoiceProcessView> InvoiceTypeGroups { get; set; } 
        public IRPSComboBox<InvoiceProcessView> eDocumentType { get; set; } 
        public IRPSComboBox<InvoiceProcessView> eDocumentType1 { get; set; } 
        public IRPSCheckbox<InvoiceProcessView> bAll { get; set; } 
        public IRPSCollectionComboBox<InvoiceProcessView> DeliveryNotes { get; set; } 
        public IRPSCollectionComboBox<InvoiceProcessView> Orders { get; set; } 
        public IRPSCheckbox<InvoiceProcessView> OrderComplete { get; set; } 
        public IRPSTextBox<InvoiceProcessView> DeliveryNoteDateFrom { get; set; } 
        public IRPSTextBox<InvoiceProcessView> DeliveryNoteDateTo { get; set; } 
        public IRPSCollectionComboBox<InvoiceProcessView> Currencys { get; set; } 
        public IRPSButton<InvoiceProcessView> InvoiceProcessChildViewNavigationCommand { get; set; } 
        public InvoiceProcess Screen { get; set; }
        public InvoiceProcessView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class InvoiceProcessChildViewModelDialogView : View
    {
        public InvoiceProcessChildViewModelDialogView(InvoiceProcess screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IsInvoicePartial = RPSControlFactory.CreateRPSCheckBox<InvoiceProcessChildViewModelDialogView>("812cb4f8-71e2-4f6a-b306-618920adcb05","","",false, this);
 
            UpdateInvoice = RPSControlFactory.CreateRPSCheckBox<InvoiceProcessChildViewModelDialogView>("35f5af64-efce-4cda-8112-59118258e660","","",false, this);
 
            bDeliveryNoteDate = RPSControlFactory.CreateRPSCheckBox<InvoiceProcessChildViewModelDialogView>("8d669953-65b9-47b9-8808-aef491a876f0","","",false, this);
 
            InvoiceDate = RPSControlFactory.CreateRPSTextBox<InvoiceProcessChildViewModelDialogView>("12852d6d-9960-4438-aeb0-87b7be306cfc","","",false, this);
 
            ShowPrintInvoiceCommand = RPSControlFactory.CreateRPSButton<InvoiceProcessChildViewModelDialogView>( "b1a9590f-af1a-4af0-8e2d-531fa61f4570","","",this);
 
            UpdateInvoice1 = RPSControlFactory.CreateRPSCheckBox<InvoiceProcessChildViewModelDialogView>("fc1fa789-1653-4296-8459-2daa9c064b7d","","",false, this);
 
            bDeliveryNoteDate1 = RPSControlFactory.CreateRPSCheckBox<InvoiceProcessChildViewModelDialogView>("5c2e265d-3283-4a6f-be4b-a2222cb63210","","",false, this);
 
            InvoiceDate1 = RPSControlFactory.CreateRPSTextBox<InvoiceProcessChildViewModelDialogView>("9d0fc20f-c614-4b3f-b1ea-27807fd13056","","",false, this);
 
            ShowPrintInvoiceCommand1 = RPSControlFactory.CreateRPSButton<InvoiceProcessChildViewModelDialogView>( "2d0f7a81-e233-43f0-b527-f65a82268ebf","","",this);
 
            PreviousSelection = RPSControlFactory.CreateRPSCheckBox<InvoiceProcessChildViewModelDialogView>("77d3166a-8b6b-41db-9157-1a7e67cce03a","","",true, this);
 
            IsInvoicePartial1 = RPSControlFactory.CreateRPSCheckBox<InvoiceProcessChildViewModelDialogView>("221523bc-53cc-40e4-bc62-5901524e3a74","","",false, this);
 
            UpdateInvoice2 = RPSControlFactory.CreateRPSCheckBox<InvoiceProcessChildViewModelDialogView>("ee45d437-92f3-4003-96d9-0be773faae8d","","",false, this);
 
            bDeliveryNoteDate2 = RPSControlFactory.CreateRPSCheckBox<InvoiceProcessChildViewModelDialogView>("b9edf330-b7ca-4a91-8bed-4fac35c0cddc","","",false, this);
 
            InvoiceDate2 = RPSControlFactory.CreateRPSTextBox<InvoiceProcessChildViewModelDialogView>("bcfc86b6-f875-42b9-bd08-4f3dc3c7ec14","","",false, this);
 
            CollectionInit params_InvoiceSelection = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a7873e23-ce99-431d-b7a0-45c6c8fbb5bf",CSSSelectorGrid="",XPathGrid=""};
            InvoiceSelection = RPSControlFactory.RPSCreateCollectionWithGrid<InvoiceSelectionCollectionEditor<InvoiceProcessChildViewModelDialogView,InvoiceFinalProcessChildViewDialogView>,InvoiceProcessChildViewModelDialogView,InvoiceFinalProcessChildViewDialogView>( params_InvoiceSelection,this,Screen.InvoiceFinalProcessChildViewDialogView);
 
            CollectionInit params_DeliveryNoteLineToPartialInvoice = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="29a210f1-87f9-4a08-be59-28bb6ce027b7",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNoteLineToPartialInvoice = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNoteLineToPartialInvoiceCollectionEditor<InvoiceProcessChildViewModelDialogView,InvoiceFinalProcessChildViewDialogView>,InvoiceProcessChildViewModelDialogView,InvoiceFinalProcessChildViewDialogView>( params_DeliveryNoteLineToPartialInvoice,this,Screen.InvoiceFinalProcessChildViewDialogView);
 
            CollectionInit params_InvoiceTemp = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="cf714eb1-55aa-4339-8452-9d5477e15243",CSSSelectorGrid="",XPathGrid=""};
            InvoiceTemp = RPSControlFactory.RPSCreateCollectionWithGrid<InvoiceTempCollectionEditor<InvoiceProcessChildViewModelDialogView,InvoiceFinalProcessChildViewDialogView>,InvoiceProcessChildViewModelDialogView,InvoiceFinalProcessChildViewDialogView>( params_InvoiceTemp,this,Screen.InvoiceFinalProcessChildViewDialogView);
 

        }
        public IRPSCheckbox<InvoiceProcessChildViewModelDialogView> IsInvoicePartial { get; set; } 
        public IRPSCheckbox<InvoiceProcessChildViewModelDialogView> UpdateInvoice { get; set; } 
        public IRPSCheckbox<InvoiceProcessChildViewModelDialogView> bDeliveryNoteDate { get; set; } 
        public IRPSTextBox<InvoiceProcessChildViewModelDialogView> InvoiceDate { get; set; } 
        public IRPSButton<InvoiceProcessChildViewModelDialogView> ShowPrintInvoiceCommand { get; set; } 
        public IRPSCheckbox<InvoiceProcessChildViewModelDialogView> UpdateInvoice1 { get; set; } 
        public IRPSCheckbox<InvoiceProcessChildViewModelDialogView> bDeliveryNoteDate1 { get; set; } 
        public IRPSTextBox<InvoiceProcessChildViewModelDialogView> InvoiceDate1 { get; set; } 
        public IRPSButton<InvoiceProcessChildViewModelDialogView> ShowPrintInvoiceCommand1 { get; set; } 
        public IRPSCheckbox<InvoiceProcessChildViewModelDialogView> PreviousSelection { get; set; } 
        public IRPSCheckbox<InvoiceProcessChildViewModelDialogView> IsInvoicePartial1 { get; set; } 
        public IRPSCheckbox<InvoiceProcessChildViewModelDialogView> UpdateInvoice2 { get; set; } 
        public IRPSCheckbox<InvoiceProcessChildViewModelDialogView> bDeliveryNoteDate2 { get; set; } 
        public IRPSTextBox<InvoiceProcessChildViewModelDialogView> InvoiceDate2 { get; set; } 
        public InvoiceSelectionCollectionEditor<InvoiceProcessChildViewModelDialogView,InvoiceFinalProcessChildViewDialogView> InvoiceSelection { get; set; } 
        public DeliveryNoteLineToPartialInvoiceCollectionEditor<InvoiceProcessChildViewModelDialogView,InvoiceFinalProcessChildViewDialogView> DeliveryNoteLineToPartialInvoice { get; set; } 
        public InvoiceTempCollectionEditor<InvoiceProcessChildViewModelDialogView,InvoiceFinalProcessChildViewDialogView> InvoiceTemp { get; set; } 
        public InvoiceProcess Screen { get; set; }
        public InvoiceProcessChildViewModelDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class InvoiceSelectionCollectionEditor<InvoiceProcessChildViewModelDialogView,InvoiceFinalProcessChildViewDialogView>:RPSCollectionEditor<InvoiceProcessChildViewModelDialogView,InvoiceFinalProcessChildViewDialogView> where InvoiceProcessChildViewModelDialogView : class, IView where InvoiceFinalProcessChildViewDialogView : class, IView
    {
        public  InvoiceSelectionGridView<InvoiceProcessChildViewModelDialogView,InvoiceFinalProcessChildViewDialogView> GridView {get;set;}
    }
    public partial class InvoiceSelectionGridView <InvoiceProcessChildViewModelDialogView,InvoiceFinalProcessChildViewDialogView> :  RPSGridView<InvoiceProcessChildViewModelDialogView,InvoiceFinalProcessChildViewDialogView> where InvoiceProcessChildViewModelDialogView : class, IView where InvoiceFinalProcessChildViewDialogView : class, IView
    {
        public InvoiceSelectionGridView(InvoiceProcessChildViewModelDialogView currentView,InvoiceFinalProcessChildViewDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeliveryNoteSituation = RPSControlFactory.CreateRPSGridTextBox<InvoiceProcessChildViewModelDialogView>("","#a7873e23-ce99-431d-b7a0-45c6c8fbb5bf .ag-row[role='row']@ROWINDEX [col-id='cDeliveryNoteSituation']","",false, this.CurrentView);
 
            OrderNumberCustomer = RPSControlFactory.CreateRPSGridTextBox<InvoiceProcessChildViewModelDialogView>("","#a7873e23-ce99-431d-b7a0-45c6c8fbb5bf .ag-row[role='row']@ROWINDEX [col-id='cOrderNumberCustomer']","",false, this.CurrentView);
 
            DeliveryNoteDate = RPSControlFactory.CreateRPSGridTextBox<InvoiceProcessChildViewModelDialogView>("","#a7873e23-ce99-431d-b7a0-45c6c8fbb5bf .ag-row[role='row']@ROWINDEX [col-id='cDeliveryNoteDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<InvoiceProcessChildViewModelDialogView> DeliveryNoteSituation { get; set; } 
        public IRPSGridTextBox<InvoiceProcessChildViewModelDialogView> OrderNumberCustomer { get; set; } 
        public IRPSGridTextBox<InvoiceProcessChildViewModelDialogView> DeliveryNoteDate { get; set; } 
                     
    }
 
        public partial class DeliveryNoteLineToPartialInvoiceCollectionEditor<InvoiceProcessChildViewModelDialogView,InvoiceFinalProcessChildViewDialogView>:RPSCollectionEditor<InvoiceProcessChildViewModelDialogView,InvoiceFinalProcessChildViewDialogView> where InvoiceProcessChildViewModelDialogView : class, IView where InvoiceFinalProcessChildViewDialogView : class, IView
    {
        public  DeliveryNoteLineToPartialInvoiceGridView<InvoiceProcessChildViewModelDialogView,InvoiceFinalProcessChildViewDialogView> GridView {get;set;}
    }
    public partial class DeliveryNoteLineToPartialInvoiceGridView <InvoiceProcessChildViewModelDialogView,InvoiceFinalProcessChildViewDialogView> :  RPSGridView<InvoiceProcessChildViewModelDialogView,InvoiceFinalProcessChildViewDialogView> where InvoiceProcessChildViewModelDialogView : class, IView where InvoiceFinalProcessChildViewDialogView : class, IView
    {
        public DeliveryNoteLineToPartialInvoiceGridView(InvoiceProcessChildViewModelDialogView currentView,InvoiceFinalProcessChildViewDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeliveryNoteSL_OrderNumberCustomer = RPSControlFactory.CreateRPSGridTextBox<InvoiceProcessChildViewModelDialogView>("","#29a210f1-87f9-4a08-be59-28bb6ce027b7 .ag-row[role='row']@ROWINDEX [col-id='cDeliveryNoteSL_OrderNumberCustomer']","",false, this.CurrentView);
 
            DeliveryNoteLineSL_Ordenation = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceProcessChildViewModelDialogView>("","#29a210f1-87f9-4a08-be59-28bb6ce027b7 .ag-row[role='row']@ROWINDEX [col-id='cDeliveryNoteLineSL_Ordenation']","",false, this.CurrentView);
 
            DeliveryNoteLineSL_Series = RPSControlFactory.CreateRPSGridTextBox<InvoiceProcessChildViewModelDialogView>("","#29a210f1-87f9-4a08-be59-28bb6ce027b7 .ag-row[role='row']@ROWINDEX [col-id='cDeliveryNoteLineSL_Series']","",false, this.CurrentView);
 
            QuantityPending = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceProcessChildViewModelDialogView>("","#29a210f1-87f9-4a08-be59-28bb6ce027b7 .ag-row[role='row']@ROWINDEX [col-id='cQuantityPending']","",false, this.CurrentView);
 
            QuantityPendingToInvoice = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceProcessChildViewModelDialogView>("","#29a210f1-87f9-4a08-be59-28bb6ce027b7 .ag-row[role='row']@ROWINDEX [col-id='cQuantityPendingToInvoice']","",false, this.CurrentView);
 
            QuantitySecondUnitPending = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceProcessChildViewModelDialogView>("","#29a210f1-87f9-4a08-be59-28bb6ce027b7 .ag-row[role='row']@ROWINDEX [col-id='cQuantitySecondUnitPending']","",false, this.CurrentView);
 
            QuantitySecondUnitPendingToInvoice = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceProcessChildViewModelDialogView>("","#29a210f1-87f9-4a08-be59-28bb6ce027b7 .ag-row[role='row']@ROWINDEX [col-id='cQuantitySecondUnitPendingToInvoice']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<InvoiceProcessChildViewModelDialogView> DeliveryNoteSL_OrderNumberCustomer { get; set; } 
        public IRPSGridTextBox<InvoiceProcessChildViewModelDialogView> DeliveryNoteLineSL_Ordenation { get; set; } 
        public IRPSGridTextBox<InvoiceProcessChildViewModelDialogView> DeliveryNoteLineSL_Series { get; set; } 
        public IRPSGridTextBox<InvoiceProcessChildViewModelDialogView> QuantityPending { get; set; } 
        public IRPSGridTextBox<InvoiceProcessChildViewModelDialogView> QuantityPendingToInvoice { get; set; } 
        public IRPSGridTextBox<InvoiceProcessChildViewModelDialogView> QuantitySecondUnitPending { get; set; } 
        public IRPSGridTextBox<InvoiceProcessChildViewModelDialogView> QuantitySecondUnitPendingToInvoice { get; set; } 
                     
    }
 
        public partial class InvoiceTempCollectionEditor<InvoiceProcessChildViewModelDialogView,InvoiceFinalProcessChildViewDialogView>:RPSCollectionEditor<InvoiceProcessChildViewModelDialogView,InvoiceFinalProcessChildViewDialogView> where InvoiceProcessChildViewModelDialogView : class, IView where InvoiceFinalProcessChildViewDialogView : class, IView
    {
        public  InvoiceTempGridView<InvoiceProcessChildViewModelDialogView,InvoiceFinalProcessChildViewDialogView> GridView {get;set;}
    }
    public partial class InvoiceTempGridView <InvoiceProcessChildViewModelDialogView,InvoiceFinalProcessChildViewDialogView> :  RPSGridView<InvoiceProcessChildViewModelDialogView,InvoiceFinalProcessChildViewDialogView> where InvoiceProcessChildViewModelDialogView : class, IView where InvoiceFinalProcessChildViewDialogView : class, IView
    {
        public InvoiceTempGridView(InvoiceProcessChildViewModelDialogView currentView,InvoiceFinalProcessChildViewDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodInvoice = RPSControlFactory.CreateRPSGridTextBox<InvoiceProcessChildViewModelDialogView>("","#cf714eb1-55aa-4339-8452-9d5477e15243 .ag-row[role='row']@ROWINDEX [col-id='cCodInvoice']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<InvoiceProcessChildViewModelDialogView>("","#cf714eb1-55aa-4339-8452-9d5477e15243 .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 
            DecriptionCustomer = RPSControlFactory.CreateRPSGridTextBox<InvoiceProcessChildViewModelDialogView>("","#cf714eb1-55aa-4339-8452-9d5477e15243 .ag-row[role='row']@ROWINDEX [col-id='cDecriptionCustomer']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<InvoiceProcessChildViewModelDialogView> CodInvoice { get; set; } 
        public IRPSGridTextBox<InvoiceProcessChildViewModelDialogView> InvoiceDate { get; set; } 
        public IRPSGridTextBox<InvoiceProcessChildViewModelDialogView> DecriptionCustomer { get; set; } 
                     
    }
 
    }
  
            
    public partial class InvoiceFinalProcessChildViewDialogView : View
    {
        public InvoiceFinalProcessChildViewDialogView(InvoiceProcess screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ShowPrintInvoiceCommand = RPSControlFactory.CreateRPSButton<InvoiceFinalProcessChildViewDialogView>( "0f4f5e22-3e0d-4a8e-b822-676384179594","","",this);
 
            CollectionInit params_InvoiceGeneratedProcess = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="81241a8e-6b6e-4f02-a606-986c6ed1a38a",CSSSelectorGrid="",XPathGrid=""};
            InvoiceGeneratedProcess = RPSControlFactory.RPSCreateCollectionWithGrid<InvoiceGeneratedProcessCollectionEditor<InvoiceFinalProcessChildViewDialogView>,InvoiceFinalProcessChildViewDialogView>( params_InvoiceGeneratedProcess,this);
 

        }
        public IRPSButton<InvoiceFinalProcessChildViewDialogView> ShowPrintInvoiceCommand { get; set; } 
        public InvoiceGeneratedProcessCollectionEditor<InvoiceFinalProcessChildViewDialogView> InvoiceGeneratedProcess { get; set; } 
        public InvoiceProcess Screen { get; set; }
        public InvoiceFinalProcessChildViewDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class InvoiceGeneratedProcessCollectionEditor<InvoiceFinalProcessChildViewDialogView>:RPSCollectionEditor<InvoiceFinalProcessChildViewDialogView> where InvoiceFinalProcessChildViewDialogView : class, IView
    {
        public  InvoiceGeneratedProcessGridView<InvoiceFinalProcessChildViewDialogView> GridView {get;set;}
    }
    public partial class InvoiceGeneratedProcessGridView <InvoiceFinalProcessChildViewDialogView> :  RPSGridView<InvoiceFinalProcessChildViewDialogView> where InvoiceFinalProcessChildViewDialogView : class, IView
    {
        public InvoiceGeneratedProcessGridView(InvoiceFinalProcessChildViewDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            InvoiceSL_InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<InvoiceFinalProcessChildViewDialogView>("","#81241a8e-6b6e-4f02-a606-986c6ed1a38a .ag-row[role='row']@ROWINDEX [col-id='cInvoiceSL_InvoiceDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<InvoiceFinalProcessChildViewDialogView> InvoiceSL_InvoiceDate { get; set; } 
                     
    }
 
    }
  
    

}