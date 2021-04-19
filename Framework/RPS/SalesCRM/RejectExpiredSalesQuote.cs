    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.SalesCRM.RejectExpiredSalesQuote
{
    //RPS VERSION 1.0.0.0
    public partial class RejectExpiredSalesQuote:Screen
    {
        public RejectExpiredSalesQuote():base()
        {
            this.URL = "salescrm.rejectexpiredsalesquote";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            RejectExpiredSalesQuoteQueryView  = new RejectExpiredSalesQuoteQueryView(this); 
            RejectExpiredSalesQuoteQueryView.InitializeControls(); 
           
        }
      
            public RejectExpiredSalesQuoteQueryView RejectExpiredSalesQuoteQueryView {get; set; } 
    }
            
    public partial class RejectExpiredSalesQuoteQueryView : View
    {
        public RejectExpiredSalesQuoteQueryView(RejectExpiredSalesQuote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            opendlgSelectSalesQuoteStatusButton = RPSControlFactory.CreateRPSButton<RejectExpiredSalesQuoteQueryView>( "4084b1ac-50cf-499a-9bc6-d5c716670258","","",this);
 
            CollectionInit params_SalesQuotesToReject = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b3afb16f-72d6-4bbf-9ee7-283326ce4fb1",CSSSelectorGrid="",XPathGrid=""};
            SalesQuotesToReject = RPSControlFactory.RPSCreateCollectionWithGrid<SalesQuotesToRejectCollectionEditor<RejectExpiredSalesQuoteQueryView>,RejectExpiredSalesQuoteQueryView>( params_SalesQuotesToReject,this);
 

        }
        public IRPSButton<RejectExpiredSalesQuoteQueryView> opendlgSelectSalesQuoteStatusButton { get; set; } 
        public SalesQuotesToRejectCollectionEditor<RejectExpiredSalesQuoteQueryView> SalesQuotesToReject { get; set; } 
        public RejectExpiredSalesQuote Screen { get; set; }
        public RejectExpiredSalesQuoteQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SalesQuotesToRejectCollectionEditor<RejectExpiredSalesQuoteQueryView>:RPSCollectionEditor<RejectExpiredSalesQuoteQueryView> where RejectExpiredSalesQuoteQueryView : class, IView
    {
        public  SalesQuotesToRejectGridView<RejectExpiredSalesQuoteQueryView> GridView {get;set;}
    }
    public partial class SalesQuotesToRejectGridView <RejectExpiredSalesQuoteQueryView> :  RPSGridView<RejectExpiredSalesQuoteQueryView> where RejectExpiredSalesQuoteQueryView : class, IView
    {
        public SalesQuotesToRejectGridView(RejectExpiredSalesQuoteQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ownerType = RPSControlFactory.CreateRPSGridTextBox<RejectExpiredSalesQuoteQueryView>("","#b3afb16f-72d6-4bbf-9ee7-283326ce4fb1 .ag-row[role='row']@ROWINDEX [col-id='cownerType']","",false, this.CurrentView);
 
            SalesQuoteSL_SalesQuoteDate = RPSControlFactory.CreateRPSGridTextBox<RejectExpiredSalesQuoteQueryView>("","#b3afb16f-72d6-4bbf-9ee7-283326ce4fb1 .ag-row[role='row']@ROWINDEX [col-id='cSalesQuoteSL_SalesQuoteDate']","",false, this.CurrentView);
 
            SalesQuoteSL_EffectiveDate = RPSControlFactory.CreateRPSGridTextBox<RejectExpiredSalesQuoteQueryView>("","#b3afb16f-72d6-4bbf-9ee7-283326ce4fb1 .ag-row[role='row']@ROWINDEX [col-id='cSalesQuoteSL_EffectiveDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<RejectExpiredSalesQuoteQueryView> ownerType { get; set; } 
        public IRPSGridTextBox<RejectExpiredSalesQuoteQueryView> SalesQuoteSL_SalesQuoteDate { get; set; } 
        public IRPSGridTextBox<RejectExpiredSalesQuoteQueryView> SalesQuoteSL_EffectiveDate { get; set; } 
                     
    }
 
    }
  
    

}