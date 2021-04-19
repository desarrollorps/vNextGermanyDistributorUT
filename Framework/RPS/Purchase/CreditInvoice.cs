    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.CreditInvoice
{
    //RPS VERSION 1.0.0.0
    public partial class CreditInvoice:Screen
    {
        public CreditInvoice():base()
        {
            this.URL = "purchase.creditinvoice";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CreditInvoiceView  = new CreditInvoiceView(this); 
            CreditInvoiceProcessResultVMChildDialogView  = new CreditInvoiceProcessResultVMChildDialogView(this); 
            CreditInvoiceView.InitializeControls(); 
            CreditInvoiceProcessResultVMChildDialogView.InitializeControls(); 
           
        }
      
            public CreditInvoiceView CreditInvoiceView {get; set; } 
            public CreditInvoiceProcessResultVMChildDialogView CreditInvoiceProcessResultVMChildDialogView {get; set; } 
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
            UISupplier = RPSControlFactory.CreateRPSComboBox<CreditInvoiceView>("c2d3bd8d-131e-42ec-8b6b-a4518c55996f","","",true, this);
 
            UIInvoice = RPSControlFactory.CreateRPSComboBox<CreditInvoiceView>("639c2271-3c18-482a-8dbb-a311e081bbc9","","",true, this);
 
            UIInvoiceDate = RPSControlFactory.CreateRPSTextBox<CreditInvoiceView>("fe5579e3-08c2-4dc8-9d81-77fa1cfa79e5","","",false, this);
 
            UIAdvanceInvoice = RPSControlFactory.CreateRPSCheckBox<CreditInvoiceView>("c6e2a477-a71e-4c7f-af63-1697d9b30af9","","",false, this);
 
            UITransport = RPSControlFactory.CreateRPSFormattedTextBox<CreditInvoiceView>("668dbd41-da03-4e08-ac59-74552b25d99f","","",false, this);
 
            UICreditDate = RPSControlFactory.CreateRPSTextBox<CreditInvoiceView>("d7408fc0-eff8-4dcb-9930-6c287d8a177c","","",false, this);
 
            UIReturnCause = RPSControlFactory.CreateRPSComboBox<CreditInvoiceView>("f8a7262f-7f39-4170-b0b3-da7fdcd494c6","","",true, this);
 
            UIWareHouse = RPSControlFactory.CreateRPSComboBox<CreditInvoiceView>("61220890-129e-44a4-ba29-8b240ff96851","","",false, this);
 
            UINewInvoice = RPSControlFactory.CreateRPSTextBox<CreditInvoiceView>("9bbcf844-6086-4a36-91e2-097e98f0f54a","","",false, this);
 
            UINewDeliveryNote = RPSControlFactory.CreateRPSTextBox<CreditInvoiceView>("b0e1ccdd-b76b-434b-bfdc-2ab28544a181","","",false, this);
 
            UINoImputationCost = RPSControlFactory.CreateRPSCheckBox<CreditInvoiceView>("0fb21771-b90a-4dc9-bb6e-e92684d69c8a","","",false, this);
 
            UIOptTotal = RPSControlFactory.CreateRPSOption<CreditInvoiceView>( "8626bdbd-5802-4aea-acbb-f75481abcbef","","",this);
 
            UIOptPartial = RPSControlFactory.CreateRPSOption<CreditInvoiceView>( "0dfa6476-9860-4cae-8983-b516d59fafe2","","",this);
 
            bFinalized = RPSControlFactory.CreateRPSCheckBox<CreditInvoiceView>("621ea11d-dea8-4899-bafe-71603c483329","","",false, this);
 
            bCompleteOrder = RPSControlFactory.CreateRPSCheckBox<CreditInvoiceView>("1bdb45eb-0078-4a19-8e0f-cfb682c9052d","","",false, this);
 
            CollectionInit params_InvoiceCreditLines = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="290bb144-79cc-484b-a0ef-812c1c158ed1",CSSSelectorGrid="",XPathGrid=""};
            InvoiceCreditLines = RPSControlFactory.RPSCreateCollectionWithGrid<InvoiceCreditLinesCollectionEditor<CreditInvoiceView,CreditInvoiceProcessResultVMChildDialogView>,CreditInvoiceView,CreditInvoiceProcessResultVMChildDialogView>( params_InvoiceCreditLines,this,Screen.CreditInvoiceProcessResultVMChildDialogView);
 

        }
        public IRPSComboBox<CreditInvoiceView> UISupplier { get; set; } 
        public IRPSComboBox<CreditInvoiceView> UIInvoice { get; set; } 
        public IRPSTextBox<CreditInvoiceView> UIInvoiceDate { get; set; } 
        public IRPSCheckbox<CreditInvoiceView> UIAdvanceInvoice { get; set; } 
        public IRPSTextBox<CreditInvoiceView> UITransport { get; set; } 
        public IRPSTextBox<CreditInvoiceView> UICreditDate { get; set; } 
        public IRPSComboBox<CreditInvoiceView> UIReturnCause { get; set; } 
        public IRPSComboBox<CreditInvoiceView> UIWareHouse { get; set; } 
        public IRPSTextBox<CreditInvoiceView> UINewInvoice { get; set; } 
        public IRPSTextBox<CreditInvoiceView> UINewDeliveryNote { get; set; } 
        public IRPSCheckbox<CreditInvoiceView> UINoImputationCost { get; set; } 
        public IRPSOption<CreditInvoiceView> UIOptTotal { get; set; } 
        public IRPSOption<CreditInvoiceView> UIOptPartial { get; set; } 
        public IRPSCheckbox<CreditInvoiceView> bFinalized { get; set; } 
        public IRPSCheckbox<CreditInvoiceView> bCompleteOrder { get; set; } 
        public InvoiceCreditLinesCollectionEditor<CreditInvoiceView,CreditInvoiceProcessResultVMChildDialogView> InvoiceCreditLines { get; set; } 
        public CreditInvoice Screen { get; set; }
        public CreditInvoiceView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class InvoiceCreditLinesCollectionEditor<CreditInvoiceView,CreditInvoiceProcessResultVMChildDialogView>:RPSCollectionEditor<CreditInvoiceView,CreditInvoiceProcessResultVMChildDialogView> where CreditInvoiceView : class, IView where CreditInvoiceProcessResultVMChildDialogView : class, IView
    {
        public  InvoiceCreditLinesGridView<CreditInvoiceView,CreditInvoiceProcessResultVMChildDialogView> GridView {get;set;}
    }
    public partial class InvoiceCreditLinesGridView <CreditInvoiceView,CreditInvoiceProcessResultVMChildDialogView> :  RPSGridView<CreditInvoiceView,CreditInvoiceProcessResultVMChildDialogView> where CreditInvoiceView : class, IView where CreditInvoiceProcessResultVMChildDialogView : class, IView
    {
        public InvoiceCreditLinesGridView(CreditInvoiceView currentView,CreditInvoiceProcessResultVMChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            InvoiceLine_Ordenation = RPSControlFactory.CreateRPSGridFormattedTextBox<CreditInvoiceView>("","#290bb144-79cc-484b-a0ef-812c1c158ed1 .ag-row[role='row']@ROWINDEX [col-id='cInvoiceLine_Ordenation']","",false, this.CurrentView);
 
            ReturnCause = RPSControlFactory.CreateRPSGridComboBox<CreditInvoiceView>("","#290bb144-79cc-484b-a0ef-812c1c158ed1 .ag-row[role='row']@ROWINDEX [col-id='cReturnCause']","",false, this.CurrentView);
 
            InvoiceLine_Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<CreditInvoiceView>("","#290bb144-79cc-484b-a0ef-812c1c158ed1 .ag-row[role='row']@ROWINDEX [col-id='cInvoiceLine_Quantity']","",false, this.CurrentView);
 
            InvoiceLine_QuantitySecondUnit = RPSControlFactory.CreateRPSGridFormattedTextBox<CreditInvoiceView>("","#290bb144-79cc-484b-a0ef-812c1c158ed1 .ag-row[role='row']@ROWINDEX [col-id='cInvoiceLine_QuantitySecondUnit']","",false, this.CurrentView);
 
            UISite = RPSControlFactory.CreateRPSGridComboBox<CreditInvoiceView>("","#290bb144-79cc-484b-a0ef-812c1c158ed1 .ag-row[role='row']@ROWINDEX [col-id='cUISite']","",false, this.CurrentView);
 
            UIWarehouse = RPSControlFactory.CreateRPSGridComboBox<CreditInvoiceView>("","#290bb144-79cc-484b-a0ef-812c1c158ed1 .ag-row[role='row']@ROWINDEX [col-id='cUIWarehouse']","",false, this.CurrentView);
 
            InvoiceLine_Series = RPSControlFactory.CreateRPSGridTextBox<CreditInvoiceView>("","#290bb144-79cc-484b-a0ef-812c1c158ed1 .ag-row[role='row']@ROWINDEX [col-id='cInvoiceLine_Series']","",false, this.CurrentView);
 
            CREDITQUANTITY = RPSControlFactory.CreateRPSGridFormattedTextBox<CreditInvoiceView>("","#290bb144-79cc-484b-a0ef-812c1c158ed1 .ag-row[role='row']@ROWINDEX [col-id='cCREDITQUANTITY']","",false, this.CurrentView);
 
            CREDITQUANTITYSECONDUNIT = RPSControlFactory.CreateRPSGridFormattedTextBox<CreditInvoiceView>("","#290bb144-79cc-484b-a0ef-812c1c158ed1 .ag-row[role='row']@ROWINDEX [col-id='cCREDITQUANTITYSECONDUNIT']","",false, this.CurrentView);
 
            NETPRICE = RPSControlFactory.CreateRPSGridFormattedTextBox<CreditInvoiceView>("","#290bb144-79cc-484b-a0ef-812c1c158ed1 .ag-row[role='row']@ROWINDEX [col-id='cNETPRICE']","",false, this.CurrentView);
 
            NEWNETPRICE = RPSControlFactory.CreateRPSGridFormattedTextBox<CreditInvoiceView>("","#290bb144-79cc-484b-a0ef-812c1c158ed1 .ag-row[role='row']@ROWINDEX [col-id='cNEWNETPRICE']","",false, this.CurrentView);
 
            IDLocationWarehouse = RPSControlFactory.CreateRPSGridComboBox<CreditInvoiceView>("","#290bb144-79cc-484b-a0ef-812c1c158ed1 .ag-row[role='row']@ROWINDEX [col-id='cIDLocationWarehouse']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CreditInvoiceView> InvoiceLine_Ordenation { get; set; } 
        public IRPSGridComboBox<CreditInvoiceView> ReturnCause { get; set; } 
        public IRPSGridTextBox<CreditInvoiceView> InvoiceLine_Quantity { get; set; } 
        public IRPSGridTextBox<CreditInvoiceView> InvoiceLine_QuantitySecondUnit { get; set; } 
        public IRPSGridComboBox<CreditInvoiceView> UISite { get; set; } 
        public IRPSGridComboBox<CreditInvoiceView> UIWarehouse { get; set; } 
        public IRPSGridTextBox<CreditInvoiceView> InvoiceLine_Series { get; set; } 
        public IRPSGridTextBox<CreditInvoiceView> CREDITQUANTITY { get; set; } 
        public IRPSGridTextBox<CreditInvoiceView> CREDITQUANTITYSECONDUNIT { get; set; } 
        public IRPSGridTextBox<CreditInvoiceView> NETPRICE { get; set; } 
        public IRPSGridTextBox<CreditInvoiceView> NEWNETPRICE { get; set; } 
        public IRPSGridComboBox<CreditInvoiceView> IDLocationWarehouse { get; set; } 
                     
    }
 
    }
  
            
    public partial class CreditInvoiceProcessResultVMChildDialogView : View
    {
        public CreditInvoiceProcessResultVMChildDialogView(CreditInvoice screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_GenerateCreditInvoiceResult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="09650859-9711-4037-a81a-8f3882e0afe1",CSSSelectorGrid="",XPathGrid=""};
            GenerateCreditInvoiceResult = RPSControlFactory.RPSCreateCollectionWithGrid<GenerateCreditInvoiceResultCollectionEditor<CreditInvoiceProcessResultVMChildDialogView>,CreditInvoiceProcessResultVMChildDialogView>( params_GenerateCreditInvoiceResult,this);
 
            CollectionInit params_GenerateCreditInvoiceAdvancesResult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="24252de5-5936-4d95-9cc6-ac7b17e13a82",CSSSelectorGrid="",XPathGrid=""};
            GenerateCreditInvoiceAdvancesResult = RPSControlFactory.RPSCreateCollectionWithGrid<GenerateCreditInvoiceAdvancesResultCollectionEditor<CreditInvoiceProcessResultVMChildDialogView>,CreditInvoiceProcessResultVMChildDialogView>( params_GenerateCreditInvoiceAdvancesResult,this);
 

        }
        public GenerateCreditInvoiceResultCollectionEditor<CreditInvoiceProcessResultVMChildDialogView> GenerateCreditInvoiceResult { get; set; } 
        public GenerateCreditInvoiceAdvancesResultCollectionEditor<CreditInvoiceProcessResultVMChildDialogView> GenerateCreditInvoiceAdvancesResult { get; set; } 
        public CreditInvoice Screen { get; set; }
        public CreditInvoiceProcessResultVMChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GenerateCreditInvoiceResultCollectionEditor<CreditInvoiceProcessResultVMChildDialogView>:RPSCollectionEditor<CreditInvoiceProcessResultVMChildDialogView> where CreditInvoiceProcessResultVMChildDialogView : class, IView
    {
        public  GenerateCreditInvoiceResultGridView<CreditInvoiceProcessResultVMChildDialogView> GridView {get;set;}
    }
    public partial class GenerateCreditInvoiceResultGridView <CreditInvoiceProcessResultVMChildDialogView> :  RPSGridView<CreditInvoiceProcessResultVMChildDialogView> where CreditInvoiceProcessResultVMChildDialogView : class, IView
    {
        public GenerateCreditInvoiceResultGridView(CreditInvoiceProcessResultVMChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeliveryNote_DeliveryNoteDate = RPSControlFactory.CreateRPSGridTextBox<CreditInvoiceProcessResultVMChildDialogView>("","#09650859-9711-4037-a81a-8f3882e0afe1 .ag-row[role='row']@ROWINDEX [col-id='cDeliveryNote_DeliveryNoteDate']","",false, this.CurrentView);
 
            DeliveryNote_TotalAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<CreditInvoiceProcessResultVMChildDialogView>("","#09650859-9711-4037-a81a-8f3882e0afe1 .ag-row[role='row']@ROWINDEX [col-id='cDeliveryNote_TotalAmount']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CreditInvoiceProcessResultVMChildDialogView> DeliveryNote_DeliveryNoteDate { get; set; } 
        public IRPSGridTextBox<CreditInvoiceProcessResultVMChildDialogView> DeliveryNote_TotalAmount { get; set; } 
                     
    }
 
        public partial class GenerateCreditInvoiceAdvancesResultCollectionEditor<CreditInvoiceProcessResultVMChildDialogView>:RPSCollectionEditor<CreditInvoiceProcessResultVMChildDialogView> where CreditInvoiceProcessResultVMChildDialogView : class, IView
    {
        public  GenerateCreditInvoiceAdvancesResultGridView<CreditInvoiceProcessResultVMChildDialogView> GridView {get;set;}
    }
    public partial class GenerateCreditInvoiceAdvancesResultGridView <CreditInvoiceProcessResultVMChildDialogView> :  RPSGridView<CreditInvoiceProcessResultVMChildDialogView> where CreditInvoiceProcessResultVMChildDialogView : class, IView
    {
        public GenerateCreditInvoiceAdvancesResultGridView(CreditInvoiceProcessResultVMChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Invoice_InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<CreditInvoiceProcessResultVMChildDialogView>("","#24252de5-5936-4d95-9cc6-ac7b17e13a82 .ag-row[role='row']@ROWINDEX [col-id='cInvoice_InvoiceDate']","",false, this.CurrentView);
 
            Invoice_TotalLinesAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<CreditInvoiceProcessResultVMChildDialogView>("","#24252de5-5936-4d95-9cc6-ac7b17e13a82 .ag-row[role='row']@ROWINDEX [col-id='cInvoice_TotalLinesAmount']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CreditInvoiceProcessResultVMChildDialogView> Invoice_InvoiceDate { get; set; } 
        public IRPSGridTextBox<CreditInvoiceProcessResultVMChildDialogView> Invoice_TotalLinesAmount { get; set; } 
                     
    }
 
    }
  
    

}