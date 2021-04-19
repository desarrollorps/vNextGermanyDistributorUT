    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.RecalculateCommissions
{
    //RPS VERSION 1.0.0.0
    public partial class RecalculateCommissions:Screen
    {
        public RecalculateCommissions():base()
        {
            this.URL = "sales.recalculatecommissions";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            RecalculateCommissionsQueryView  = new RecalculateCommissionsQueryView(this); 
            RecalculateCommissionsChildView  = new RecalculateCommissionsChildView(this); 
            RecalculateCommissionsQueryView.InitializeControls(); 
            RecalculateCommissionsChildView.InitializeControls(); 
           
        }
      
            public RecalculateCommissionsQueryView RecalculateCommissionsQueryView {get; set; } 
            public RecalculateCommissionsChildView RecalculateCommissionsChildView {get; set; } 
    }
            
    public partial class RecalculateCommissionsQueryView : View
    {
        public RecalculateCommissionsQueryView(RecalculateCommissions screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CommercialAgentSL = RPSControlFactory.CreateRPSCollectionComboBox<RecalculateCommissionsQueryView>("46f81cfb-d6b6-4b98-9ec8-14f3f7d831f7","","",false, this);
 
            InvoiceDateFrom = RPSControlFactory.CreateRPSTextBox<RecalculateCommissionsQueryView>("7db02ee6-d670-48db-8e07-71c74c3d24f0","","",false, this);
 
            InvoiceDateTo = RPSControlFactory.CreateRPSTextBox<RecalculateCommissionsQueryView>("110afc95-14d3-4c2b-918a-7ac56bc8bcb6","","",false, this);
 
            CollectionInit params_RecalculateCommissionConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1e499fd3-498d-4637-9f9d-97b0346ff020",CSSSelectorGrid="",XPathGrid=""};
            RecalculateCommissionConsult = RPSControlFactory.RPSCreateCollectionWithGrid<RecalculateCommissionConsultCollectionEditor<RecalculateCommissionsQueryView>,RecalculateCommissionsQueryView>( params_RecalculateCommissionConsult,this);
 

        }
        public IRPSCollectionComboBox<RecalculateCommissionsQueryView> CommercialAgentSL { get; set; } 
        public IRPSTextBox<RecalculateCommissionsQueryView> InvoiceDateFrom { get; set; } 
        public IRPSTextBox<RecalculateCommissionsQueryView> InvoiceDateTo { get; set; } 
        public RecalculateCommissionConsultCollectionEditor<RecalculateCommissionsQueryView> RecalculateCommissionConsult { get; set; } 
        public RecalculateCommissions Screen { get; set; }
        public RecalculateCommissionsQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class RecalculateCommissionConsultCollectionEditor<RecalculateCommissionsQueryView>:RPSCollectionEditor<RecalculateCommissionsQueryView> where RecalculateCommissionsQueryView : class, IView
    {
        public  RecalculateCommissionConsultGridView<RecalculateCommissionsQueryView> GridView {get;set;}
    }
    public partial class RecalculateCommissionConsultGridView <RecalculateCommissionsQueryView> :  RPSGridView<RecalculateCommissionsQueryView> where RecalculateCommissionsQueryView : class, IView
    {
        public RecalculateCommissionConsultGridView(RecalculateCommissionsQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CommissionPercentage = RPSControlFactory.CreateRPSGridFormattedTextBox<RecalculateCommissionsQueryView>("","#1e499fd3-498d-4637-9f9d-97b0346ff020 .ag-row[role='row']@ROWINDEX [col-id='cCommissionPercentage']","",false, this.CurrentView);
 
            TotalBase = RPSControlFactory.CreateRPSGridFormattedTextBox<RecalculateCommissionsQueryView>("","#1e499fd3-498d-4637-9f9d-97b0346ff020 .ag-row[role='row']@ROWINDEX [col-id='cTotalBase']","",false, this.CurrentView);
 
            AmountCommission = RPSControlFactory.CreateRPSGridFormattedTextBox<RecalculateCommissionsQueryView>("","#1e499fd3-498d-4637-9f9d-97b0346ff020 .ag-row[role='row']@ROWINDEX [col-id='cAmountCommission']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<RecalculateCommissionsQueryView> CommissionPercentage { get; set; } 
        public IRPSGridTextBox<RecalculateCommissionsQueryView> TotalBase { get; set; } 
        public IRPSGridTextBox<RecalculateCommissionsQueryView> AmountCommission { get; set; } 
                     
    }
 
    }
  
            
    public partial class RecalculateCommissionsChildView : View
    {
        public RecalculateCommissionsChildView(RecalculateCommissions screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            RecalculateCommissionsCommandButton = RPSControlFactory.CreateRPSButton<RecalculateCommissionsChildView>( "aa1980a9-7bce-49d4-a694-461a5b986909","","",this);
 
            CollectionInit params_RecalculateCommissionConsultInvoiceLines = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="04168c01-0eb5-4183-8ad3-319acc3d31f1",CSSSelectorGrid="",XPathGrid=""};
            RecalculateCommissionConsultInvoiceLines = RPSControlFactory.RPSCreateCollectionWithGrid<RecalculateCommissionConsultInvoiceLinesCollectionEditor<RecalculateCommissionsChildView>,RecalculateCommissionsChildView>( params_RecalculateCommissionConsultInvoiceLines,this);
 

        }
        public IRPSButton<RecalculateCommissionsChildView> RecalculateCommissionsCommandButton { get; set; } 
        public RecalculateCommissionConsultInvoiceLinesCollectionEditor<RecalculateCommissionsChildView> RecalculateCommissionConsultInvoiceLines { get; set; } 
        public RecalculateCommissions Screen { get; set; }
        public RecalculateCommissionsChildView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class RecalculateCommissionConsultInvoiceLinesCollectionEditor<RecalculateCommissionsChildView>:RPSCollectionEditor<RecalculateCommissionsChildView> where RecalculateCommissionsChildView : class, IView
    {
        public  RecalculateCommissionConsultInvoiceLinesGridView<RecalculateCommissionsChildView> GridView {get;set;}
    }
    public partial class RecalculateCommissionConsultInvoiceLinesGridView <RecalculateCommissionsChildView> :  RPSGridView<RecalculateCommissionsChildView> where RecalculateCommissionsChildView : class, IView
    {
        public RecalculateCommissionConsultInvoiceLinesGridView(RecalculateCommissionsChildView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodInvoice = RPSControlFactory.CreateRPSGridTextBox<RecalculateCommissionsChildView>("","#04168c01-0eb5-4183-8ad3-319acc3d31f1 .ag-row[role='row']@ROWINDEX [col-id='cCodInvoice']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<RecalculateCommissionsChildView>("","#04168c01-0eb5-4183-8ad3-319acc3d31f1 .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 
            Base = RPSControlFactory.CreateRPSGridFormattedTextBox<RecalculateCommissionsChildView>("","#04168c01-0eb5-4183-8ad3-319acc3d31f1 .ag-row[role='row']@ROWINDEX [col-id='cBase']","",false, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<RecalculateCommissionsChildView>("","#04168c01-0eb5-4183-8ad3-319acc3d31f1 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<RecalculateCommissionsChildView> CodInvoice { get; set; } 
        public IRPSGridTextBox<RecalculateCommissionsChildView> InvoiceDate { get; set; } 
        public IRPSGridTextBox<RecalculateCommissionsChildView> Base { get; set; } 
        public IRPSGridTextBox<RecalculateCommissionsChildView> Amount { get; set; } 
                     
    }
 
    }
  
    

}