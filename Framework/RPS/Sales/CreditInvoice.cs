    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.CreditInvoice
{
    //RPS VERSION 1.0.0.0
    public partial class CreditInvoice:Screen
    {
        public CreditInvoice():base()
        {
            this.URL = "sales.creditinvoice";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CreditInvoiceView  = new CreditInvoiceView(this); 
            ProcessResultChildDialogView  = new ProcessResultChildDialogView(this); 
            CreditInvoiceView.InitializeControls(); 
            ProcessResultChildDialogView.InitializeControls(); 
           
        }
      
            public CreditInvoiceView CreditInvoiceView {get; set; } 
            public ProcessResultChildDialogView ProcessResultChildDialogView {get; set; } 
    }
            
    public partial class CreditInvoiceView : View
    {
        public CreditInvoiceView(CreditInvoice screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIInvoiceSL = RPSControlFactory.CreateRPSComboBox<CreditInvoiceView>("b2c22a25-d44c-4d9b-99fe-793461b8500a","","",true, this);
 
            UICustomer = RPSControlFactory.CreateRPSComboBox<CreditInvoiceView>("b7e32dba-af25-4866-b2dd-888b445b4ad5","","",false, this);
 
            UIInvoiceDate = RPSControlFactory.CreateRPSTextBox<CreditInvoiceView>("86f53deb-528a-441b-9571-0e9435accd08","","",false, this);
 
            UIAdvanceInvoice = RPSControlFactory.CreateRPSCheckBox<CreditInvoiceView>("c868ad7a-98c2-488a-850f-dd2460435345","","",false, this);
 
            Transport = RPSControlFactory.CreateRPSFormattedTextBox<CreditInvoiceView>("2db93f06-c3e1-48db-8b93-2b1b9ee34b09","","",false, this);
 
            UICreditDate = RPSControlFactory.CreateRPSTextBox<CreditInvoiceView>("93de0d31-0253-4eb1-b76a-8276ac37aa5b","","",true, this);
 
            UIReturnCauseSL = RPSControlFactory.CreateRPSComboBox<CreditInvoiceView>("1c88e3dc-4f99-4b15-b037-194e53c31dea","","",true, this);
 
            UIOptNewDeliveryNote = RPSControlFactory.CreateRPSOption<CreditInvoiceView>( "a2688e4b-23e7-4868-86eb-92fd44820129","","",this);
 
            UIOptSameDeliveryNote = RPSControlFactory.CreateRPSOption<CreditInvoiceView>( "5eef3620-9a8e-498b-99fb-9973c2208d75","","",this);
 
            UINoImputationCostIndirect = RPSControlFactory.CreateRPSCheckBox<CreditInvoiceView>("f934aef0-ddbc-48ea-adc2-65f7ad8f66a8","","",false, this);
 
            UIOptTotal = RPSControlFactory.CreateRPSOption<CreditInvoiceView>( "1911ab5e-f0f1-43b7-896b-5a2ae950992a","","",this);
 
            UIOptPartial = RPSControlFactory.CreateRPSOption<CreditInvoiceView>( "53ebd258-a763-4f35-a728-ad964635e44c","","",this);
 
            UIOrderComplete = RPSControlFactory.CreateRPSCheckBox<CreditInvoiceView>("7fc157df-697f-4a21-a94f-14fbe2114b68","","",false, this);
 
            UIDeliveryNoteFinalized = RPSControlFactory.CreateRPSCheckBox<CreditInvoiceView>("aefef191-c57c-44a5-a514-26564670f6ae","","",false, this);
 
            UIGenerateInvoice = RPSControlFactory.CreateRPSCheckBox<CreditInvoiceView>("8bc825fb-9d5e-4fb9-85db-5ace34115700","","",false, this);
 
            UIDeliveryNoteCodingSeries = RPSControlFactory.CreateRPSComboBox<CreditInvoiceView>("23e752f7-668b-4ff5-a055-ebdfaf860007","","",false, this);
 
            UIInvoiceCodingSeries = RPSControlFactory.CreateRPSComboBox<CreditInvoiceView>("eb22e935-5199-430b-84cd-778a3be13a37","","",false, this);
 
            UIOptInvoicePaymentMethod = RPSControlFactory.CreateRPSOption<CreditInvoiceView>( "b1ba9341-1c33-4ec1-b8cf-33459bb5f597","","",this);
 
            UIOptNewPaymentMethod = RPSControlFactory.CreateRPSOption<CreditInvoiceView>( "52f7cb9e-aa30-4ad9-b3d8-ef99f677ec10","","",this);
 
            UIPaymentMethodSL = RPSControlFactory.CreateRPSComboBox<CreditInvoiceView>("7b0e0f57-354b-429c-8c56-29c81acc90b3","","",false, this);
 
            UIOptInvoiceWarehouse = RPSControlFactory.CreateRPSOption<CreditInvoiceView>( "d4cb41c6-9b03-445d-88c0-f1f39fbad6a2","","",this);
 
            UIOptNewWarehouse = RPSControlFactory.CreateRPSOption<CreditInvoiceView>( "7863c10f-ee71-427c-b054-2108bbe13d25","","",this);
 
            UISite = RPSControlFactory.CreateRPSComboBox<CreditInvoiceView>("7e13eebb-4605-4b4d-a33f-b9a5a618d2a9","","",false, this);
 
            UIWareHouse = RPSControlFactory.CreateRPSComboBox<CreditInvoiceView>("db200de4-4605-4e98-ac10-948c7158ada8","","",false, this);
 
            IDLocationWarehouse = RPSControlFactory.CreateRPSComboBox<CreditInvoiceView>("61f02ad5-6a56-479a-b2af-a84c6c1a3f2c","","",false, this);
 
            UICommentDeliveryNote = RPSControlFactory.CreateRPSTextBox<CreditInvoiceView>("5281526e-6939-4a57-94ba-7b2f21d6726e","","",false, this);
 
            UICommentInvoice = RPSControlFactory.CreateRPSTextBox<CreditInvoiceView>("24453ca6-064d-41f3-8f2b-941d67f8e86a","","",false, this);
 
            PreTextIDTextLineInvoice = RPSControlFactory.CreateRPSComboBox<CreditInvoiceView>("df187123-9def-4f1c-8dc5-f69289da64d6","","",false, this);
 
            PostTextIDTextLineInvoice = RPSControlFactory.CreateRPSComboBox<CreditInvoiceView>("b134bad0-95ff-49ce-80ff-899e3bdaa181","","",false, this);
 
            PreText = RPSControlFactory.CreateRPSTextBox<CreditInvoiceView>("99eb2ca6-1413-45e2-9cc3-6ba8a6f554aa","","",false, this);
 
            PostText = RPSControlFactory.CreateRPSTextBox<CreditInvoiceView>("45b5d164-a19d-4658-b705-a0968031640f","","",false, this);
 
            CollectionInit params_InvoiceCreditLines = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="90d3c41e-9786-493d-9675-afd4748064ab",CSSSelectorGrid="",XPathGrid=""};
            InvoiceCreditLines = RPSControlFactory.RPSCreateCollectionWithGrid<InvoiceCreditLinesCollectionEditor<CreditInvoiceView,ProcessResultChildDialogView>,CreditInvoiceView,ProcessResultChildDialogView>( params_InvoiceCreditLines,this,Screen.ProcessResultChildDialogView);
 

        }
        public IRPSComboBox<CreditInvoiceView> UIInvoiceSL { get; set; } 
        public IRPSComboBox<CreditInvoiceView> UICustomer { get; set; } 
        public IRPSTextBox<CreditInvoiceView> UIInvoiceDate { get; set; } 
        public IRPSCheckbox<CreditInvoiceView> UIAdvanceInvoice { get; set; } 
        public IRPSTextBox<CreditInvoiceView> Transport { get; set; } 
        public IRPSTextBox<CreditInvoiceView> UICreditDate { get; set; } 
        public IRPSComboBox<CreditInvoiceView> UIReturnCauseSL { get; set; } 
        public IRPSOption<CreditInvoiceView> UIOptNewDeliveryNote { get; set; } 
        public IRPSOption<CreditInvoiceView> UIOptSameDeliveryNote { get; set; } 
        public IRPSCheckbox<CreditInvoiceView> UINoImputationCostIndirect { get; set; } 
        public IRPSOption<CreditInvoiceView> UIOptTotal { get; set; } 
        public IRPSOption<CreditInvoiceView> UIOptPartial { get; set; } 
        public IRPSCheckbox<CreditInvoiceView> UIOrderComplete { get; set; } 
        public IRPSCheckbox<CreditInvoiceView> UIDeliveryNoteFinalized { get; set; } 
        public IRPSCheckbox<CreditInvoiceView> UIGenerateInvoice { get; set; } 
        public IRPSComboBox<CreditInvoiceView> UIDeliveryNoteCodingSeries { get; set; } 
        public IRPSComboBox<CreditInvoiceView> UIInvoiceCodingSeries { get; set; } 
        public IRPSOption<CreditInvoiceView> UIOptInvoicePaymentMethod { get; set; } 
        public IRPSOption<CreditInvoiceView> UIOptNewPaymentMethod { get; set; } 
        public IRPSComboBox<CreditInvoiceView> UIPaymentMethodSL { get; set; } 
        public IRPSOption<CreditInvoiceView> UIOptInvoiceWarehouse { get; set; } 
        public IRPSOption<CreditInvoiceView> UIOptNewWarehouse { get; set; } 
        public IRPSComboBox<CreditInvoiceView> UISite { get; set; } 
        public IRPSComboBox<CreditInvoiceView> UIWareHouse { get; set; } 
        public IRPSComboBox<CreditInvoiceView> IDLocationWarehouse { get; set; } 
        public IRPSTextBox<CreditInvoiceView> UICommentDeliveryNote { get; set; } 
        public IRPSTextBox<CreditInvoiceView> UICommentInvoice { get; set; } 
        public IRPSComboBox<CreditInvoiceView> PreTextIDTextLineInvoice { get; set; } 
        public IRPSComboBox<CreditInvoiceView> PostTextIDTextLineInvoice { get; set; } 
        public IRPSTextBox<CreditInvoiceView> PreText { get; set; } 
        public IRPSTextBox<CreditInvoiceView> PostText { get; set; } 
        public InvoiceCreditLinesCollectionEditor<CreditInvoiceView,ProcessResultChildDialogView> InvoiceCreditLines { get; set; } 
        public CreditInvoice Screen { get; set; }
        public CreditInvoiceView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class InvoiceCreditLinesCollectionEditor<CreditInvoiceView,ProcessResultChildDialogView>:RPSCollectionEditor<CreditInvoiceView,ProcessResultChildDialogView> where CreditInvoiceView : class, IView where ProcessResultChildDialogView : class, IView
    {
        public  InvoiceCreditLinesGridView<CreditInvoiceView,ProcessResultChildDialogView> GridView {get;set;}
    }
    public partial class InvoiceCreditLinesGridView <CreditInvoiceView,ProcessResultChildDialogView> :  RPSGridView<CreditInvoiceView,ProcessResultChildDialogView> where CreditInvoiceView : class, IView where ProcessResultChildDialogView : class, IView
    {
        public InvoiceCreditLinesGridView(CreditInvoiceView currentView,ProcessResultChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            InvoiceLineSL_Ordenation = RPSControlFactory.CreateRPSGridFormattedTextBox<CreditInvoiceView>("","#90d3c41e-9786-493d-9675-afd4748064ab .ag-row[role='row']@ROWINDEX [col-id='cInvoiceLineSL_Ordenation']","",false, this.CurrentView);
 
            RETURNCAUSE = RPSControlFactory.CreateRPSGridComboBox<CreditInvoiceView>("","#90d3c41e-9786-493d-9675-afd4748064ab .ag-row[role='row']@ROWINDEX [col-id='cRETURNCAUSE']","",false, this.CurrentView);
 
            InvoiceLineSL_Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<CreditInvoiceView>("","#90d3c41e-9786-493d-9675-afd4748064ab .ag-row[role='row']@ROWINDEX [col-id='cInvoiceLineSL_Quantity']","",false, this.CurrentView);
 
            InvoiceLineSL_QuantitySecondUnit = RPSControlFactory.CreateRPSGridFormattedTextBox<CreditInvoiceView>("","#90d3c41e-9786-493d-9675-afd4748064ab .ag-row[role='row']@ROWINDEX [col-id='cInvoiceLineSL_QuantitySecondUnit']","",false, this.CurrentView);
 
            InvoiceLineSL_Series = RPSControlFactory.CreateRPSGridTextBox<CreditInvoiceView>("","#90d3c41e-9786-493d-9675-afd4748064ab .ag-row[role='row']@ROWINDEX [col-id='cInvoiceLineSL_Series']","",false, this.CurrentView);
 
            CREDITQUANTITY = RPSControlFactory.CreateRPSGridFormattedTextBox<CreditInvoiceView>("","#90d3c41e-9786-493d-9675-afd4748064ab .ag-row[role='row']@ROWINDEX [col-id='cCREDITQUANTITY']","",false, this.CurrentView);
 
            CREDITQUANTITYSECONDUNIT = RPSControlFactory.CreateRPSGridFormattedTextBox<CreditInvoiceView>("","#90d3c41e-9786-493d-9675-afd4748064ab .ag-row[role='row']@ROWINDEX [col-id='cCREDITQUANTITYSECONDUNIT']","",false, this.CurrentView);
 
            NETPRICE = RPSControlFactory.CreateRPSGridFormattedTextBox<CreditInvoiceView>("","#90d3c41e-9786-493d-9675-afd4748064ab .ag-row[role='row']@ROWINDEX [col-id='cNETPRICE']","",false, this.CurrentView);
 
            NEWNETPRICE = RPSControlFactory.CreateRPSGridFormattedTextBox<CreditInvoiceView>("","#90d3c41e-9786-493d-9675-afd4748064ab .ag-row[role='row']@ROWINDEX [col-id='cNEWNETPRICE']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CreditInvoiceView> InvoiceLineSL_Ordenation { get; set; } 
        public IRPSGridComboBox<CreditInvoiceView> RETURNCAUSE { get; set; } 
        public IRPSGridTextBox<CreditInvoiceView> InvoiceLineSL_Quantity { get; set; } 
        public IRPSGridTextBox<CreditInvoiceView> InvoiceLineSL_QuantitySecondUnit { get; set; } 
        public IRPSGridTextBox<CreditInvoiceView> InvoiceLineSL_Series { get; set; } 
        public IRPSGridTextBox<CreditInvoiceView> CREDITQUANTITY { get; set; } 
        public IRPSGridTextBox<CreditInvoiceView> CREDITQUANTITYSECONDUNIT { get; set; } 
        public IRPSGridTextBox<CreditInvoiceView> NETPRICE { get; set; } 
        public IRPSGridTextBox<CreditInvoiceView> NEWNETPRICE { get; set; } 
                     
    }
 
    }
  
            
    public partial class ProcessResultChildDialogView : View
    {
        public ProcessResultChildDialogView(CreditInvoice screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_DeliveryNoteSLConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4c53c23e-d9dd-4ef9-989e-5c1365227f1c",CSSSelectorGrid="",XPathGrid=""};
            DeliveryNoteSLConsult = RPSControlFactory.RPSCreateCollectionWithGrid<DeliveryNoteSLConsultCollectionEditor<ProcessResultChildDialogView>,ProcessResultChildDialogView>( params_DeliveryNoteSLConsult,this);
 
            CollectionInit params_InvoiceGeneratedProcess = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="040c1b0d-4062-4997-91ca-2dffc87778ca",CSSSelectorGrid="",XPathGrid=""};
            InvoiceGeneratedProcess = RPSControlFactory.RPSCreateCollectionWithGrid<InvoiceGeneratedProcessCollectionEditor<ProcessResultChildDialogView>,ProcessResultChildDialogView>( params_InvoiceGeneratedProcess,this);
 

        }
        public DeliveryNoteSLConsultCollectionEditor<ProcessResultChildDialogView> DeliveryNoteSLConsult { get; set; } 
        public InvoiceGeneratedProcessCollectionEditor<ProcessResultChildDialogView> InvoiceGeneratedProcess { get; set; } 
        public CreditInvoice Screen { get; set; }
        public ProcessResultChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DeliveryNoteSLConsultCollectionEditor<ProcessResultChildDialogView>:RPSCollectionEditor<ProcessResultChildDialogView> where ProcessResultChildDialogView : class, IView
    {
        public  DeliveryNoteSLConsultGridView<ProcessResultChildDialogView> GridView {get;set;}
    }
    public partial class DeliveryNoteSLConsultGridView <ProcessResultChildDialogView> :  RPSGridView<ProcessResultChildDialogView> where ProcessResultChildDialogView : class, IView
    {
        public DeliveryNoteSLConsultGridView(ProcessResultChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeliveryNoteSL_DeliveryNoteDate = RPSControlFactory.CreateRPSGridTextBox<ProcessResultChildDialogView>("","#4c53c23e-d9dd-4ef9-989e-5c1365227f1c .ag-row[role='row']@ROWINDEX [col-id='cDeliveryNoteSL_DeliveryNoteDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ProcessResultChildDialogView> DeliveryNoteSL_DeliveryNoteDate { get; set; } 
                     
    }
 
        public partial class InvoiceGeneratedProcessCollectionEditor<ProcessResultChildDialogView>:RPSCollectionEditor<ProcessResultChildDialogView> where ProcessResultChildDialogView : class, IView
    {
        public  InvoiceGeneratedProcessGridView<ProcessResultChildDialogView> GridView {get;set;}
    }
    public partial class InvoiceGeneratedProcessGridView <ProcessResultChildDialogView> :  RPSGridView<ProcessResultChildDialogView> where ProcessResultChildDialogView : class, IView
    {
        public InvoiceGeneratedProcessGridView(ProcessResultChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            InvoiceSL_InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<ProcessResultChildDialogView>("","#040c1b0d-4062-4997-91ca-2dffc87778ca .ag-row[role='row']@ROWINDEX [col-id='cInvoiceSL_InvoiceDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ProcessResultChildDialogView> InvoiceSL_InvoiceDate { get; set; } 
                     
    }
 
    }
  
    

}