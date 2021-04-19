    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.SalesDesk.CashControl
{
    //RPS VERSION 1.0.0.0
    public partial class CashControl:Screen
    {
        public CashControl():base()
        {
            this.URL = "salesdesk.cashcontrol";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CashControlQueryView  = new CashControlQueryView(this); 
            CashControlQueryView.InitializeControls(); 
           
        }
      
            public CashControlQueryView CashControlQueryView {get; set; } 
    }
            
    public partial class CashControlQueryView : View
    {
        public CashControlQueryView(CashControl screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDCashPaymentSL = RPSControlFactory.CreateRPSComboBox<CashControlQueryView>("1f6da13f-45ef-41a2-be34-50736424988d","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<CashControlQueryView>("8225d6df-081b-4d6b-8642-fdccc800f3b7","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<CashControlQueryView>("9f620651-97d3-4cde-a8b7-9c7f83d379a1","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<CashControlQueryView>("91cb479a-3ff9-4e56-b573-6db8316ef8b3","","",false, this);
 
            DisplayOpenCloseMovements = RPSControlFactory.CreateRPSCheckBox<CashControlQueryView>("9b215302-938f-46b7-a68b-b8d8d3facbe2","","",false, this);
 
            TotalInput = RPSControlFactory.CreateRPSFormattedTextBox<CashControlQueryView>("f63783c2-abd6-4cde-ae21-5adf73aaec41","","",false, this);
 
            TotalOutput = RPSControlFactory.CreateRPSFormattedTextBox<CashControlQueryView>("8258af27-8407-4ed4-bb79-b163320ffe6c","","",false, this);
 
            Difference = RPSControlFactory.CreateRPSFormattedTextBox<CashControlQueryView>("5fb11441-3081-4fa4-9bd7-1e76d18944ae","","",false, this);
 
            ReportCommandButton = RPSControlFactory.CreateRPSButton<CashControlQueryView>( "3fd7552a-b4b8-44b5-83c1-bb0c3b4614f5","","",this);
 
            InsertSummaryCommandButton = RPSControlFactory.CreateRPSButton<CashControlQueryView>( "227db848-f03a-4c60-82fd-2dac14b2c490","","",this);
 
            LinkNavigationCommandButton = RPSControlFactory.CreateRPSButton<CashControlQueryView>( "1b6ac8bd-4855-40d8-9820-ba35da9963e2","","",this);
 
            CollectionInit params_CashControlConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="11c1798b-a810-4546-8009-61b87e57966f",CSSSelectorGrid="",XPathGrid=""};
            CashControlConsult = RPSControlFactory.RPSCreateCollectionWithGrid<CashControlConsultCollectionEditor<CashControlQueryView>,CashControlQueryView>( params_CashControlConsult,this);
 
            CollectionInit params_CashControlDetailConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="59efef0a-ccc1-4343-8478-5051aae6afc5",CSSSelectorGrid="",XPathGrid=""};
            CashControlDetailConsult = RPSControlFactory.RPSCreateCollectionWithGrid<CashControlDetailConsultCollectionEditor<CashControlQueryView>,CashControlQueryView>( params_CashControlDetailConsult,this);
 

        }
        public IRPSComboBox<CashControlQueryView> IDCashPaymentSL { get; set; } 
        public IRPSComboBox<CashControlQueryView> IDCurrency { get; set; } 
        public IRPSTextBox<CashControlQueryView> DateFrom { get; set; } 
        public IRPSTextBox<CashControlQueryView> DateTo { get; set; } 
        public IRPSCheckbox<CashControlQueryView> DisplayOpenCloseMovements { get; set; } 
        public IRPSTextBox<CashControlQueryView> TotalInput { get; set; } 
        public IRPSTextBox<CashControlQueryView> TotalOutput { get; set; } 
        public IRPSTextBox<CashControlQueryView> Difference { get; set; } 
        public IRPSButton<CashControlQueryView> ReportCommandButton { get; set; } 
        public IRPSButton<CashControlQueryView> InsertSummaryCommandButton { get; set; } 
        public IRPSButton<CashControlQueryView> LinkNavigationCommandButton { get; set; } 
        public CashControlConsultCollectionEditor<CashControlQueryView> CashControlConsult { get; set; } 
        public CashControlDetailConsultCollectionEditor<CashControlQueryView> CashControlDetailConsult { get; set; } 
        public CashControl Screen { get; set; }
        public CashControlQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CashControlConsultCollectionEditor<CashControlQueryView>:RPSCollectionEditor<CashControlQueryView> where CashControlQueryView : class, IView
    {
        public  CashControlConsultGridView<CashControlQueryView> GridView {get;set;}
    }
    public partial class CashControlConsultGridView <CashControlQueryView> :  RPSGridView<CashControlQueryView> where CashControlQueryView : class, IView
    {
        public CashControlConsultGridView(CashControlQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CashMovementDate = RPSControlFactory.CreateRPSGridTextBox<CashControlQueryView>("","#11c1798b-a810-4546-8009-61b87e57966f .ag-row[role='row']@ROWINDEX [col-id='cCashMovementDate']","",false, this.CurrentView);
 
            MovementType = RPSControlFactory.CreateRPSGridTextBox<CashControlQueryView>("","#11c1798b-a810-4546-8009-61b87e57966f .ag-row[role='row']@ROWINDEX [col-id='cMovementType']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CashControlQueryView> CashMovementDate { get; set; } 
        public IRPSGridTextBox<CashControlQueryView> MovementType { get; set; } 
                     
    }
 
        public partial class CashControlDetailConsultCollectionEditor<CashControlQueryView>:RPSCollectionEditor<CashControlQueryView> where CashControlQueryView : class, IView
    {
        public  CashControlDetailConsultGridView<CashControlQueryView> GridView {get;set;}
    }
    public partial class CashControlDetailConsultGridView <CashControlQueryView> :  RPSGridView<CashControlQueryView> where CashControlQueryView : class, IView
    {
        public CashControlDetailConsultGridView(CashControlQueryView currentView)
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