    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.SalesDesk.CashSummary
{
    //RPS VERSION 1.0.0.0
    public partial class CashSummary:Screen
    {
        public CashSummary():base()
        {
            this.URL = "salesdesk.cashsummary";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CashSummaryQueryView  = new CashSummaryQueryView(this); 
            CashSummaryQueryView.InitializeControls(); 
           
        }
      
            public CashSummaryQueryView CashSummaryQueryView {get; set; } 
    }
            
    public partial class CashSummaryQueryView : View
    {
        public CashSummaryQueryView(CashSummary screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDCashPaymentSL = RPSControlFactory.CreateRPSComboBox<CashSummaryQueryView>("1f6da13f-45ef-41a2-be34-50736424988d","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<CashSummaryQueryView>("8225d6df-081b-4d6b-8642-fdccc800f3b7","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<CashSummaryQueryView>("9f620651-97d3-4cde-a8b7-9c7f83d379a1","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<CashSummaryQueryView>("91cb479a-3ff9-4e56-b573-6db8316ef8b3","","",false, this);
 
            TotalInput = RPSControlFactory.CreateRPSFormattedTextBox<CashSummaryQueryView>("6d8454f2-b392-4ce4-b77d-c5217246cdeb","","",false, this);
 
            TotalOutput = RPSControlFactory.CreateRPSFormattedTextBox<CashSummaryQueryView>("9818644e-688e-44e6-8693-729306843fe5","","",false, this);
 
            Difference = RPSControlFactory.CreateRPSFormattedTextBox<CashSummaryQueryView>("8c9b66e6-961b-4911-ba11-f48dd9c0dc51","","",false, this);
 
            DeleteCommandButton = RPSControlFactory.CreateRPSButton<CashSummaryQueryView>( "d95d31e7-58bd-408a-8884-5dee56894e3e","","",this);
 
            CollectionInit params_CashSummaryConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="36954973-03ee-4115-81a1-79e073e31c3b",CSSSelectorGrid="",XPathGrid=""};
            CashSummaryConsult = RPSControlFactory.RPSCreateCollectionWithGrid<CashSummaryConsultCollectionEditor<CashSummaryQueryView>,CashSummaryQueryView>( params_CashSummaryConsult,this);
 
            CollectionInit params_CashSummaryDetailConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f4b3b3ab-bf7a-433d-9ac4-016ec099c231",CSSSelectorGrid="",XPathGrid=""};
            CashSummaryDetailConsult = RPSControlFactory.RPSCreateCollectionWithGrid<CashSummaryDetailConsultCollectionEditor<CashSummaryQueryView>,CashSummaryQueryView>( params_CashSummaryDetailConsult,this);
 

        }
        public IRPSComboBox<CashSummaryQueryView> IDCashPaymentSL { get; set; } 
        public IRPSComboBox<CashSummaryQueryView> IDCurrency { get; set; } 
        public IRPSTextBox<CashSummaryQueryView> DateFrom { get; set; } 
        public IRPSTextBox<CashSummaryQueryView> DateTo { get; set; } 
        public IRPSTextBox<CashSummaryQueryView> TotalInput { get; set; } 
        public IRPSTextBox<CashSummaryQueryView> TotalOutput { get; set; } 
        public IRPSTextBox<CashSummaryQueryView> Difference { get; set; } 
        public IRPSButton<CashSummaryQueryView> DeleteCommandButton { get; set; } 
        public CashSummaryConsultCollectionEditor<CashSummaryQueryView> CashSummaryConsult { get; set; } 
        public CashSummaryDetailConsultCollectionEditor<CashSummaryQueryView> CashSummaryDetailConsult { get; set; } 
        public CashSummary Screen { get; set; }
        public CashSummaryQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CashSummaryConsultCollectionEditor<CashSummaryQueryView>:RPSCollectionEditor<CashSummaryQueryView> where CashSummaryQueryView : class, IView
    {
        public  CashSummaryConsultGridView<CashSummaryQueryView> GridView {get;set;}
    }
    public partial class CashSummaryConsultGridView <CashSummaryQueryView> :  RPSGridView<CashSummaryQueryView> where CashSummaryQueryView : class, IView
    {
        public CashSummaryConsultGridView(CashSummaryQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CashMovementDate = RPSControlFactory.CreateRPSGridTextBox<CashSummaryQueryView>("","#36954973-03ee-4115-81a1-79e073e31c3b .ag-row[role='row']@ROWINDEX [col-id='cCashMovementDate']","",false, this.CurrentView);
 
            MovementType = RPSControlFactory.CreateRPSGridTextBox<CashSummaryQueryView>("","#36954973-03ee-4115-81a1-79e073e31c3b .ag-row[role='row']@ROWINDEX [col-id='cMovementType']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CashSummaryQueryView> CashMovementDate { get; set; } 
        public IRPSGridTextBox<CashSummaryQueryView> MovementType { get; set; } 
                     
    }
 
        public partial class CashSummaryDetailConsultCollectionEditor<CashSummaryQueryView>:RPSCollectionEditor<CashSummaryQueryView> where CashSummaryQueryView : class, IView
    {
        public  CashSummaryDetailConsultGridView<CashSummaryQueryView> GridView {get;set;}
    }
    public partial class CashSummaryDetailConsultGridView <CashSummaryQueryView> :  RPSGridView<CashSummaryQueryView> where CashSummaryQueryView : class, IView
    {
        public CashSummaryDetailConsultGridView(CashSummaryQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {

        }
                     
    }
 
    }
  
    

}