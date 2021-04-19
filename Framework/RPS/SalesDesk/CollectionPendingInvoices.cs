    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.SalesDesk.CollectionPendingInvoices
{
    //RPS VERSION 1.0.0.0
    public partial class CollectionPendingInvoices:Screen
    {
        public CollectionPendingInvoices():base()
        {
            this.URL = "salesdesk.collectionpendinginvoices";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CollectionPendingInvoicesView  = new CollectionPendingInvoicesView(this); 
            NewPaymentMethodChildDialogView  = new NewPaymentMethodChildDialogView(this); 
            CollectionPendingInvoicesView.InitializeControls(); 
            NewPaymentMethodChildDialogView.InitializeControls(); 
           
        }
      
            public CollectionPendingInvoicesView CollectionPendingInvoicesView {get; set; } 
            public NewPaymentMethodChildDialogView NewPaymentMethodChildDialogView {get; set; } 
    }
            
    public partial class CollectionPendingInvoicesView : View
    {
        public CollectionPendingInvoicesView(CollectionPendingInvoices screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDInvoiceSL = RPSControlFactory.CreateRPSComboBox<CollectionPendingInvoicesView>("8be3285f-a3d5-4e73-afd0-4119bade6948","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<CollectionPendingInvoicesView>("19a47f6b-a84d-403c-a92f-854dc71cb4ad","","",false, this);
 
            InvoiceDate = RPSControlFactory.CreateRPSTextBox<CollectionPendingInvoicesView>("8d01d246-62a7-4791-8aee-ad2f053dc545","","",false, this);
 
            NewPaymentMethodChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<CollectionPendingInvoicesView,NewPaymentMethodChildDialogView>("154f8379-b6d2-45bc-8bc9-3b620eb4577d","","", this,Screen.NewPaymentMethodChildDialogView);
 
            CollectionInit params_InvoicePaymentSLConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="83dd98a6-3f5e-4437-8d49-f5e726e9e47d",CSSSelectorGrid="",XPathGrid=""};
            InvoicePaymentSLConsult = RPSControlFactory.RPSCreateCollectionWithGrid<InvoicePaymentSLConsultCollectionEditor<CollectionPendingInvoicesView,NewPaymentMethodChildDialogView>,CollectionPendingInvoicesView,NewPaymentMethodChildDialogView>( params_InvoicePaymentSLConsult,this,Screen.NewPaymentMethodChildDialogView);
 

        }
        public IRPSComboBox<CollectionPendingInvoicesView> IDInvoiceSL { get; set; } 
        public IRPSComboBox<CollectionPendingInvoicesView> IDCustomer { get; set; } 
        public IRPSTextBox<CollectionPendingInvoicesView> InvoiceDate { get; set; } 
        public IRPSButton<CollectionPendingInvoicesView,NewPaymentMethodChildDialogView> NewPaymentMethodChildNavigationCommandButton { get; set; } 
        public InvoicePaymentSLConsultCollectionEditor<CollectionPendingInvoicesView,NewPaymentMethodChildDialogView> InvoicePaymentSLConsult { get; set; } 
        public CollectionPendingInvoices Screen { get; set; }
        public CollectionPendingInvoicesView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class InvoicePaymentSLConsultCollectionEditor<CollectionPendingInvoicesView,NewPaymentMethodChildDialogView>:RPSCollectionEditor<CollectionPendingInvoicesView,NewPaymentMethodChildDialogView> where CollectionPendingInvoicesView : class, IView where NewPaymentMethodChildDialogView : class, IView
    {
        public  InvoicePaymentSLConsultGridView<CollectionPendingInvoicesView,NewPaymentMethodChildDialogView> GridView {get;set;}
    }
    public partial class InvoicePaymentSLConsultGridView <CollectionPendingInvoicesView,NewPaymentMethodChildDialogView> :  RPSGridView<CollectionPendingInvoicesView,NewPaymentMethodChildDialogView> where CollectionPendingInvoicesView : class, IView where NewPaymentMethodChildDialogView : class, IView
    {
        public InvoicePaymentSLConsultGridView(CollectionPendingInvoicesView currentView,NewPaymentMethodChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            InvoicePaymentSL_NumPayment = RPSControlFactory.CreateRPSGridFormattedTextBox<CollectionPendingInvoicesView>("","#83dd98a6-3f5e-4437-8d49-f5e726e9e47d .ag-row[role='row']@ROWINDEX [col-id='cInvoicePaymentSL_NumPayment']","",false, this.CurrentView);
 
            InvoicePaymentSL_IDPaymentMethod = RPSControlFactory.CreateRPSGridComboBox<CollectionPendingInvoicesView>("","#83dd98a6-3f5e-4437-8d49-f5e726e9e47d .ag-row[role='row']@ROWINDEX [col-id='cInvoicePaymentSL_IDPaymentMethod']","",false, this.CurrentView);
 
            InvoicePaymentSL_Date = RPSControlFactory.CreateRPSGridTextBox<CollectionPendingInvoicesView>("","#83dd98a6-3f5e-4437-8d49-f5e726e9e47d .ag-row[role='row']@ROWINDEX [col-id='cInvoicePaymentSL_Date']","",false, this.CurrentView);
 
            InvoicePaymentSL_NumberPaymentMethod = RPSControlFactory.CreateRPSGridTextBox<CollectionPendingInvoicesView>("","#83dd98a6-3f5e-4437-8d49-f5e726e9e47d .ag-row[role='row']@ROWINDEX [col-id='cInvoicePaymentSL_NumberPaymentMethod']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CollectionPendingInvoicesView> InvoicePaymentSL_NumPayment { get; set; } 
        public IRPSGridComboBox<CollectionPendingInvoicesView> InvoicePaymentSL_IDPaymentMethod { get; set; } 
        public IRPSGridTextBox<CollectionPendingInvoicesView> InvoicePaymentSL_Date { get; set; } 
        public IRPSGridTextBox<CollectionPendingInvoicesView> InvoicePaymentSL_NumberPaymentMethod { get; set; } 
                     
    }
 
    }
  
            
    public partial class NewPaymentMethodChildDialogView : View
    {
        public NewPaymentMethodChildDialogView(CollectionPendingInvoices screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDPaymentMethodSL = RPSControlFactory.CreateRPSComboBox<NewPaymentMethodChildDialogView>("f5e072dd-4450-4df0-acbd-b5d57104746f","","",true, this);
 

        }
        public IRPSComboBox<NewPaymentMethodChildDialogView> IDPaymentMethodSL { get; set; } 
        public CollectionPendingInvoices Screen { get; set; }
        public NewPaymentMethodChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}