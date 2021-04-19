    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.CommissionLiquidationConsult
{
    //RPS VERSION 1.0.0.0
    public partial class CommissionLiquidationConsult:Screen
    {
        public CommissionLiquidationConsult():base()
        {
            this.URL = "sales.commissionliquidationconsult";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CommissionLiquidationConsultQueryView  = new CommissionLiquidationConsultQueryView(this); 
            CommissionLiquidationConsultQueryView.InitializeControls(); 
           
        }
      
            public CommissionLiquidationConsultQueryView CommissionLiquidationConsultQueryView {get; set; } 
    }
            
    public partial class CommissionLiquidationConsultQueryView : View
    {
        public CommissionLiquidationConsultQueryView(CommissionLiquidationConsult screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CommercialAgentSL = RPSControlFactory.CreateRPSCollectionComboBox<CommissionLiquidationConsultQueryView>("688e5646-10ef-4375-8501-8b6fb699a705","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<CommissionLiquidationConsultQueryView>("03f978e7-e7b8-4949-a794-17db139e7f8b","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<CommissionLiquidationConsultQueryView>("15928a4b-c08b-45ab-aed5-57723f8505bb","","",false, this);
 
            CollectionInit params_LiquidationConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="98655130-ce48-41e4-9e2d-4cea54a701b9",CSSSelectorGrid="",XPathGrid=""};
            LiquidationConsult = RPSControlFactory.RPSCreateCollectionWithGrid<LiquidationConsultCollectionEditor<CommissionLiquidationConsultQueryView>,CommissionLiquidationConsultQueryView>( params_LiquidationConsult,this);
 
            CollectionInit params_LiquidationConsultDetail = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="889da7f5-f349-47fc-a85f-1bf616e1b89d",CSSSelectorGrid="",XPathGrid=""};
            LiquidationConsultDetail = RPSControlFactory.RPSCreateCollectionWithGrid<LiquidationConsultDetailCollectionEditor<CommissionLiquidationConsultQueryView>,CommissionLiquidationConsultQueryView>( params_LiquidationConsultDetail,this);
 

        }
        public IRPSCollectionComboBox<CommissionLiquidationConsultQueryView> CommercialAgentSL { get; set; } 
        public IRPSTextBox<CommissionLiquidationConsultQueryView> DateFrom { get; set; } 
        public IRPSTextBox<CommissionLiquidationConsultQueryView> DateTo { get; set; } 
        public LiquidationConsultCollectionEditor<CommissionLiquidationConsultQueryView> LiquidationConsult { get; set; } 
        public LiquidationConsultDetailCollectionEditor<CommissionLiquidationConsultQueryView> LiquidationConsultDetail { get; set; } 
        public CommissionLiquidationConsult Screen { get; set; }
        public CommissionLiquidationConsultQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class LiquidationConsultCollectionEditor<CommissionLiquidationConsultQueryView>:RPSCollectionEditor<CommissionLiquidationConsultQueryView> where CommissionLiquidationConsultQueryView : class, IView
    {
        public  LiquidationConsultGridView<CommissionLiquidationConsultQueryView> GridView {get;set;}
    }
    public partial class LiquidationConsultGridView <CommissionLiquidationConsultQueryView> :  RPSGridView<CommissionLiquidationConsultQueryView> where CommissionLiquidationConsultQueryView : class, IView
    {
        public LiquidationConsultGridView(CommissionLiquidationConsultQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            LiquidatedDate = RPSControlFactory.CreateRPSGridTextBox<CommissionLiquidationConsultQueryView>("","#98655130-ce48-41e4-9e2d-4cea54a701b9 .ag-row[role='row']@ROWINDEX [col-id='cLiquidatedDate']","",false, this.CurrentView);
 
            AmountCommission = RPSControlFactory.CreateRPSGridFormattedTextBox<CommissionLiquidationConsultQueryView>("","#98655130-ce48-41e4-9e2d-4cea54a701b9 .ag-row[role='row']@ROWINDEX [col-id='cAmountCommission']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CommissionLiquidationConsultQueryView> LiquidatedDate { get; set; } 
        public IRPSGridTextBox<CommissionLiquidationConsultQueryView> AmountCommission { get; set; } 
                     
    }
 
        public partial class LiquidationConsultDetailCollectionEditor<CommissionLiquidationConsultQueryView>:RPSCollectionEditor<CommissionLiquidationConsultQueryView> where CommissionLiquidationConsultQueryView : class, IView
    {
        public  LiquidationConsultDetailGridView<CommissionLiquidationConsultQueryView> GridView {get;set;}
    }
    public partial class LiquidationConsultDetailGridView <CommissionLiquidationConsultQueryView> :  RPSGridView<CommissionLiquidationConsultQueryView> where CommissionLiquidationConsultQueryView : class, IView
    {
        public LiquidationConsultDetailGridView(CommissionLiquidationConsultQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            AmountCommission = RPSControlFactory.CreateRPSGridFormattedTextBox<CommissionLiquidationConsultQueryView>("","#889da7f5-f349-47fc-a85f-1bf616e1b89d .ag-row[role='row']@ROWINDEX [col-id='cAmountCommission']","",false, this.CurrentView);
 
            TotalInvoice = RPSControlFactory.CreateRPSGridFormattedTextBox<CommissionLiquidationConsultQueryView>("","#889da7f5-f349-47fc-a85f-1bf616e1b89d .ag-row[role='row']@ROWINDEX [col-id='cTotalInvoice']","",false, this.CurrentView);
 
            Date = RPSControlFactory.CreateRPSGridTextBox<CommissionLiquidationConsultQueryView>("","#889da7f5-f349-47fc-a85f-1bf616e1b89d .ag-row[role='row']@ROWINDEX [col-id='cDate']","",false, this.CurrentView);
 
            BaseAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<CommissionLiquidationConsultQueryView>("","#889da7f5-f349-47fc-a85f-1bf616e1b89d .ag-row[role='row']@ROWINDEX [col-id='cBaseAmount']","",false, this.CurrentView);
 
            CommissionPercentage = RPSControlFactory.CreateRPSGridFormattedTextBox<CommissionLiquidationConsultQueryView>("","#889da7f5-f349-47fc-a85f-1bf616e1b89d .ag-row[role='row']@ROWINDEX [col-id='cCommissionPercentage']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CommissionLiquidationConsultQueryView> AmountCommission { get; set; } 
        public IRPSGridTextBox<CommissionLiquidationConsultQueryView> TotalInvoice { get; set; } 
        public IRPSGridTextBox<CommissionLiquidationConsultQueryView> Date { get; set; } 
        public IRPSGridTextBox<CommissionLiquidationConsultQueryView> BaseAmount { get; set; } 
        public IRPSGridTextBox<CommissionLiquidationConsultQueryView> CommissionPercentage { get; set; } 
                     
    }
 
    }
  
    

}