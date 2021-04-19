    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.InvoiceNoUnassignmentSL
{
    //RPS VERSION 1.0.0.0
    public partial class InvoiceNoUnassignmentSL:Screen
    {
        public InvoiceNoUnassignmentSL():base()
        {
            this.URL = "sales.invoicenounassignmentsl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            InvoiceNoUnassignmentSLView  = new InvoiceNoUnassignmentSLView(this); 
            InvoiceNoUnassignmentSLView.InitializeControls(); 
           
        }
      
            public InvoiceNoUnassignmentSLView InvoiceNoUnassignmentSLView {get; set; } 
    }
            
    public partial class InvoiceNoUnassignmentSLView : View
    {
        public InvoiceNoUnassignmentSLView(InvoiceNoUnassignmentSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Sales = RPSControlFactory.CreateRPSOption<InvoiceNoUnassignmentSLView>( "4217063f-37cc-4d1b-919f-000104fc2d14","","",this);
 
            OrderPrePayment = RPSControlFactory.CreateRPSOption<InvoiceNoUnassignmentSLView>( "7c2ab097-ab9f-40aa-a26b-e7afb7b5cf6c","","",this);
 
            ExecuteDeleteAction = RPSControlFactory.CreateRPSButton<InvoiceNoUnassignmentSLView>( "6787b19e-17c3-472d-a853-910a8fa7a4d0","","",this);
 
            CollectionInit params_InvoiceNoUnassigmentQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="df0f51f4-b461-4f39-be8a-7ff149115386",CSSSelectorGrid="",XPathGrid=""};
            InvoiceNoUnassigmentQuery = RPSControlFactory.RPSCreateCollectionWithGrid<InvoiceNoUnassigmentQueryCollectionEditor<InvoiceNoUnassignmentSLView>,InvoiceNoUnassignmentSLView>( params_InvoiceNoUnassigmentQuery,this);
 
            CollectionInit params_InvoiceNoUnassigmentQuery1 = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="73504877-6884-4755-8a1d-3684c504ba9d",CSSSelectorGrid="",XPathGrid=""};
            InvoiceNoUnassigmentQuery1 = RPSControlFactory.RPSCreateCollectionWithGrid<InvoiceNoUnassigmentQuery1CollectionEditor<InvoiceNoUnassignmentSLView>,InvoiceNoUnassignmentSLView>( params_InvoiceNoUnassigmentQuery1,this);
 

        }
        public IRPSOption<InvoiceNoUnassignmentSLView> Sales { get; set; } 
        public IRPSOption<InvoiceNoUnassignmentSLView> OrderPrePayment { get; set; } 
        public IRPSButton<InvoiceNoUnassignmentSLView> ExecuteDeleteAction { get; set; } 
        public InvoiceNoUnassigmentQueryCollectionEditor<InvoiceNoUnassignmentSLView> InvoiceNoUnassigmentQuery { get; set; } 
        public InvoiceNoUnassigmentQuery1CollectionEditor<InvoiceNoUnassignmentSLView> InvoiceNoUnassigmentQuery1 { get; set; } 
        public InvoiceNoUnassignmentSL Screen { get; set; }
        public InvoiceNoUnassignmentSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class InvoiceNoUnassigmentQueryCollectionEditor<InvoiceNoUnassignmentSLView>:RPSCollectionEditor<InvoiceNoUnassignmentSLView> where InvoiceNoUnassignmentSLView : class, IView
    {
        public  InvoiceNoUnassigmentQueryGridView<InvoiceNoUnassignmentSLView> GridView {get;set;}
    }
    public partial class InvoiceNoUnassigmentQueryGridView <InvoiceNoUnassignmentSLView> :  RPSGridView<InvoiceNoUnassignmentSLView> where InvoiceNoUnassignmentSLView : class, IView
    {
        public InvoiceNoUnassigmentQueryGridView(InvoiceNoUnassignmentSLView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodInvoiceReserve = RPSControlFactory.CreateRPSGridTextBox<InvoiceNoUnassignmentSLView>("","#df0f51f4-b461-4f39-be8a-7ff149115386 .ag-row[role='row']@ROWINDEX [col-id='cCodInvoiceReserve']","",false, this.CurrentView);
 
            DeliveryNoteDate = RPSControlFactory.CreateRPSGridTextBox<InvoiceNoUnassignmentSLView>("","#df0f51f4-b461-4f39-be8a-7ff149115386 .ag-row[role='row']@ROWINDEX [col-id='cDeliveryNoteDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<InvoiceNoUnassignmentSLView> CodInvoiceReserve { get; set; } 
        public IRPSGridTextBox<InvoiceNoUnassignmentSLView> DeliveryNoteDate { get; set; } 
                     
    }
 
        public partial class InvoiceNoUnassigmentQuery1CollectionEditor<InvoiceNoUnassignmentSLView>:RPSCollectionEditor<InvoiceNoUnassignmentSLView> where InvoiceNoUnassignmentSLView : class, IView
    {
        public  InvoiceNoUnassigmentQuery1GridView<InvoiceNoUnassignmentSLView> GridView {get;set;}
    }
    public partial class InvoiceNoUnassigmentQuery1GridView <InvoiceNoUnassignmentSLView> :  RPSGridView<InvoiceNoUnassignmentSLView> where InvoiceNoUnassignmentSLView : class, IView
    {
        public InvoiceNoUnassigmentQuery1GridView(InvoiceNoUnassignmentSLView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodInvoiceReserve = RPSControlFactory.CreateRPSGridTextBox<InvoiceNoUnassignmentSLView>("","#73504877-6884-4755-8a1d-3684c504ba9d .ag-row[role='row']@ROWINDEX [col-id='cCodInvoiceReserve']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<InvoiceNoUnassignmentSLView> CodInvoiceReserve { get; set; } 
                     
    }
 
    }
  
    

}