    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.CreditInvoicePendingtoDiscount
{
    //RPS VERSION 1.0.0.0
    public partial class CreditInvoicePendingtoDiscount:Screen
    {
        public CreditInvoicePendingtoDiscount():base()
        {
            this.URL = "sales.creditinvoicependingtodiscount";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CreditInvoicePendingtoDiscountQueryView  = new CreditInvoicePendingtoDiscountQueryView(this); 
            CreditInvoicePendingtoDiscountChildDialogView  = new CreditInvoicePendingtoDiscountChildDialogView(this); 
            CreditInvoicePendingtoDiscountQueryView.InitializeControls(); 
            CreditInvoicePendingtoDiscountChildDialogView.InitializeControls(); 
           
        }
      
            public CreditInvoicePendingtoDiscountQueryView CreditInvoicePendingtoDiscountQueryView {get; set; } 
            public CreditInvoicePendingtoDiscountChildDialogView CreditInvoicePendingtoDiscountChildDialogView {get; set; } 
    }
            
    public partial class CreditInvoicePendingtoDiscountQueryView : View
    {
        public CreditInvoicePendingtoDiscountQueryView(CreditInvoicePendingtoDiscount screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Customer = RPSControlFactory.CreateRPSComboBox<CreditInvoicePendingtoDiscountQueryView>("ff6da6b5-97fb-4c99-9bd9-7196b82a8b8f","","",false, this);
 
            InvoiceSL = RPSControlFactory.CreateRPSCollectionComboBox<CreditInvoicePendingtoDiscountQueryView>("8a4f2a14-a18e-415c-a11a-df49ccc2cf63","","",false, this);
 
            OnlyPending = RPSControlFactory.CreateRPSCheckBox<CreditInvoicePendingtoDiscountQueryView>("b1bb40ff-5460-4d2e-8801-cf1b6f08a2a0","","",false, this);
 
            CollectionInit params_CreditPendingtoDiscount = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f7263569-bc70-4322-9c35-75cb5a571e16",CSSSelectorGrid="",XPathGrid=""};
            CreditPendingtoDiscount = RPSControlFactory.RPSCreateCollectionWithGrid<CreditPendingtoDiscountCollectionEditor<CreditInvoicePendingtoDiscountQueryView>,CreditInvoicePendingtoDiscountQueryView>( params_CreditPendingtoDiscount,this);
 

        }
        public IRPSComboBox<CreditInvoicePendingtoDiscountQueryView> Customer { get; set; } 
        public IRPSCollectionComboBox<CreditInvoicePendingtoDiscountQueryView> InvoiceSL { get; set; } 
        public IRPSCheckbox<CreditInvoicePendingtoDiscountQueryView> OnlyPending { get; set; } 
        public CreditPendingtoDiscountCollectionEditor<CreditInvoicePendingtoDiscountQueryView> CreditPendingtoDiscount { get; set; } 
        public CreditInvoicePendingtoDiscount Screen { get; set; }
        public CreditInvoicePendingtoDiscountQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CreditPendingtoDiscountCollectionEditor<CreditInvoicePendingtoDiscountQueryView>:RPSCollectionEditor<CreditInvoicePendingtoDiscountQueryView> where CreditInvoicePendingtoDiscountQueryView : class, IView
    {
        public  CreditPendingtoDiscountGridView<CreditInvoicePendingtoDiscountQueryView> GridView {get;set;}
    }
    public partial class CreditPendingtoDiscountGridView <CreditInvoicePendingtoDiscountQueryView> :  RPSGridView<CreditInvoicePendingtoDiscountQueryView> where CreditInvoicePendingtoDiscountQueryView : class, IView
    {
        public CreditPendingtoDiscountGridView(CreditInvoicePendingtoDiscountQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<CreditInvoicePendingtoDiscountQueryView>("","#f7263569-bc70-4322-9c35-75cb5a571e16 .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<CreditInvoicePendingtoDiscountQueryView>("","#f7263569-bc70-4322-9c35-75cb5a571e16 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",false, this.CurrentView);
 
            AmountDiscount = RPSControlFactory.CreateRPSGridFormattedTextBox<CreditInvoicePendingtoDiscountQueryView>("","#f7263569-bc70-4322-9c35-75cb5a571e16 .ag-row[role='row']@ROWINDEX [col-id='cAmountDiscount']","",false, this.CurrentView);
 
            AmountPending = RPSControlFactory.CreateRPSGridFormattedTextBox<CreditInvoicePendingtoDiscountQueryView>("","#f7263569-bc70-4322-9c35-75cb5a571e16 .ag-row[role='row']@ROWINDEX [col-id='cAmountPending']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CreditInvoicePendingtoDiscountQueryView> InvoiceDate { get; set; } 
        public IRPSGridTextBox<CreditInvoicePendingtoDiscountQueryView> Amount { get; set; } 
        public IRPSGridTextBox<CreditInvoicePendingtoDiscountQueryView> AmountDiscount { get; set; } 
        public IRPSGridTextBox<CreditInvoicePendingtoDiscountQueryView> AmountPending { get; set; } 
                     
    }
 
    }
  
            
    public partial class CreditInvoicePendingtoDiscountChildDialogView : View
    {
        public CreditInvoicePendingtoDiscountChildDialogView(CreditInvoicePendingtoDiscount screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_CreditPendingtoDiscountChild = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c2876ed2-7b7c-480d-8150-d911eb833f8a",CSSSelectorGrid="",XPathGrid=""};
            CreditPendingtoDiscountChild = RPSControlFactory.RPSCreateCollectionWithGrid<CreditPendingtoDiscountChildCollectionEditor<CreditInvoicePendingtoDiscountChildDialogView>,CreditInvoicePendingtoDiscountChildDialogView>( params_CreditPendingtoDiscountChild,this);
 

        }
        public CreditPendingtoDiscountChildCollectionEditor<CreditInvoicePendingtoDiscountChildDialogView> CreditPendingtoDiscountChild { get; set; } 
        public CreditInvoicePendingtoDiscount Screen { get; set; }
        public CreditInvoicePendingtoDiscountChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CreditPendingtoDiscountChildCollectionEditor<CreditInvoicePendingtoDiscountChildDialogView>:RPSCollectionEditor<CreditInvoicePendingtoDiscountChildDialogView> where CreditInvoicePendingtoDiscountChildDialogView : class, IView
    {
        public  CreditPendingtoDiscountChildGridView<CreditInvoicePendingtoDiscountChildDialogView> GridView {get;set;}
    }
    public partial class CreditPendingtoDiscountChildGridView <CreditInvoicePendingtoDiscountChildDialogView> :  RPSGridView<CreditInvoicePendingtoDiscountChildDialogView> where CreditInvoicePendingtoDiscountChildDialogView : class, IView
    {
        public CreditPendingtoDiscountChildGridView(CreditInvoicePendingtoDiscountChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<CreditInvoicePendingtoDiscountChildDialogView>("","#c2876ed2-7b7c-480d-8150-d911eb833f8a .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<CreditInvoicePendingtoDiscountChildDialogView>("","#c2876ed2-7b7c-480d-8150-d911eb833f8a .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CreditInvoicePendingtoDiscountChildDialogView> InvoiceDate { get; set; } 
        public IRPSGridTextBox<CreditInvoicePendingtoDiscountChildDialogView> Amount { get; set; } 
                     
    }
 
    }
  
    

}