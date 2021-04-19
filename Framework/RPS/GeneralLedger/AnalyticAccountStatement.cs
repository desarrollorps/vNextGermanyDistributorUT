    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.AnalyticAccountStatement
{
    //RPS VERSION 1.0.0.0
    public partial class AnalyticAccountStatement:Screen
    {
        public AnalyticAccountStatement():base()
        {
            this.URL = "generalledger.analyticaccountstatement";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            AnalyticAccountStatementQueryView  = new AnalyticAccountStatementQueryView(this); 
            AnalyticAccountStatementTreeChildView  = new AnalyticAccountStatementTreeChildView(this); 
            ResultsView  = new ResultsView(this); 
            AnalyticAccountStatementQueryView.InitializeControls(); 
            AnalyticAccountStatementTreeChildView.InitializeControls(); 
            ResultsView.InitializeControls(); 
           
        }
      
            public AnalyticAccountStatementQueryView AnalyticAccountStatementQueryView {get; set; } 
            public AnalyticAccountStatementTreeChildView AnalyticAccountStatementTreeChildView {get; set; } 
            public ResultsView ResultsView {get; set; } 
    }
            
    public partial class AnalyticAccountStatementQueryView : View
    {
        public AnalyticAccountStatementQueryView(AnalyticAccountStatement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDDimension = RPSControlFactory.CreateRPSComboBox<AnalyticAccountStatementQueryView>("6b02ada3-a41a-427a-986f-060383e6d03f","","",true, this);
 
            IDDimValues = RPSControlFactory.CreateRPSCollectionComboBox<AnalyticAccountStatementQueryView>("3eeb078b-667b-4b59-9fed-e2f210918f46","","",false, this);
 
            IDAccount = RPSControlFactory.CreateRPSComboBox<AnalyticAccountStatementQueryView>("acb0158a-f667-48a2-9a32-01e13ae65374","","",true, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<AnalyticAccountStatementQueryView>("e9b7d4c2-7c9e-4724-a918-4891a852a5a7","","",true, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<AnalyticAccountStatementQueryView>("f0e61af4-c20a-47ea-86c9-ba3482cd004a","","",true, this);
 
            bIncludeNullified = RPSControlFactory.CreateRPSCheckBox<AnalyticAccountStatementQueryView>("1b603a36-c9a9-44a1-bc0b-a63b98e91d26","","",false, this);
 
            chkExcludeClosingEntry = RPSControlFactory.CreateRPSCheckBox<AnalyticAccountStatementQueryView>("7dcfcad2-74e1-4460-a5b1-707c7807f979","","",false, this);
 
            bTC = RPSControlFactory.CreateRPSCheckBox<AnalyticAccountStatementQueryView>("a123c69b-7591-4fe0-9876-e9c881acab24","","",false, this);
 

        }
        public IRPSComboBox<AnalyticAccountStatementQueryView> IDDimension { get; set; } 
        public IRPSCollectionComboBox<AnalyticAccountStatementQueryView> IDDimValues { get; set; } 
        public IRPSComboBox<AnalyticAccountStatementQueryView> IDAccount { get; set; } 
        public IRPSTextBox<AnalyticAccountStatementQueryView> DateFrom { get; set; } 
        public IRPSTextBox<AnalyticAccountStatementQueryView> DateTo { get; set; } 
        public IRPSCheckbox<AnalyticAccountStatementQueryView> bIncludeNullified { get; set; } 
        public IRPSCheckbox<AnalyticAccountStatementQueryView> chkExcludeClosingEntry { get; set; } 
        public IRPSCheckbox<AnalyticAccountStatementQueryView> bTC { get; set; } 
        public AnalyticAccountStatement Screen { get; set; }
        public AnalyticAccountStatementQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class AnalyticAccountStatementTreeChildView : View
    {
        public AnalyticAccountStatementTreeChildView(AnalyticAccountStatement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public AnalyticAccountStatement Screen { get; set; }
        public AnalyticAccountStatementTreeChildView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ResultsView : View
    {
        public ResultsView(AnalyticAccountStatement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_AnalyticAccountStatement = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c7f680a2-8f9b-45a8-9c67-00dfe1281e30",CSSSelectorGrid="",XPathGrid=""};
            AnalyticAccountStatement = RPSControlFactory.RPSCreateCollectionWithGrid<AnalyticAccountStatementCollectionEditor<ResultsView>,ResultsView>( params_AnalyticAccountStatement,this);
 

        }
        public AnalyticAccountStatementCollectionEditor<ResultsView> AnalyticAccountStatement { get; set; } 
        public AnalyticAccountStatement Screen { get; set; }
        public ResultsView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class AnalyticAccountStatementCollectionEditor<ResultsView>:RPSCollectionEditor<ResultsView> where ResultsView : class, IView
    {
        public  AnalyticAccountStatementGridView<ResultsView> GridView {get;set;}
    }
    public partial class AnalyticAccountStatementGridView <ResultsView> :  RPSGridView<ResultsView> where ResultsView : class, IView
    {
        public AnalyticAccountStatementGridView(ResultsView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Manual = RPSControlFactory.CreateRPSGridCheckBox<ResultsView>("","#c7f680a2-8f9b-45a8-9c67-00dfe1281e30 .ag-row[role='row']@ROWINDEX [col-id='cManual']","",false, this.CurrentView);
 
            AccountingDate = RPSControlFactory.CreateRPSGridTextBox<ResultsView>("","#c7f680a2-8f9b-45a8-9c67-00dfe1281e30 .ag-row[role='row']@ROWINDEX [col-id='cAccountingDate']","",false, this.CurrentView);
 
            SignType = RPSControlFactory.CreateRPSGridTextBox<ResultsView>("","#c7f680a2-8f9b-45a8-9c67-00dfe1281e30 .ag-row[role='row']@ROWINDEX [col-id='cSignType']","",false, this.CurrentView);
 
            Extension = RPSControlFactory.CreateRPSGridTextBox<ResultsView>("","#c7f680a2-8f9b-45a8-9c67-00dfe1281e30 .ag-row[role='row']@ROWINDEX [col-id='cExtension']","",false, this.CurrentView);
 
            Service = RPSControlFactory.CreateRPSGridTextBox<ResultsView>("","#c7f680a2-8f9b-45a8-9c67-00dfe1281e30 .ag-row[role='row']@ROWINDEX [col-id='cService']","",false, this.CurrentView);
 
            CodInvoice = RPSControlFactory.CreateRPSGridTextBox<ResultsView>("","#c7f680a2-8f9b-45a8-9c67-00dfe1281e30 .ag-row[role='row']@ROWINDEX [col-id='cCodInvoice']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<ResultsView>("","#c7f680a2-8f9b-45a8-9c67-00dfe1281e30 .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 
            Nullified = RPSControlFactory.CreateRPSGridCheckBox<ResultsView>("","#c7f680a2-8f9b-45a8-9c67-00dfe1281e30 .ag-row[role='row']@ROWINDEX [col-id='cNullified']","",false, this.CurrentView);
 
            CodACCType = RPSControlFactory.CreateRPSGridTextBox<ResultsView>("","#c7f680a2-8f9b-45a8-9c67-00dfe1281e30 .ag-row[role='row']@ROWINDEX [col-id='cCodACCType']","",false, this.CurrentView);
 

        }
        public IRPSGridCheckbox<ResultsView> Manual { get; set; } 
        public IRPSGridTextBox<ResultsView> AccountingDate { get; set; } 
        public IRPSGridTextBox<ResultsView> SignType { get; set; } 
        public IRPSGridTextBox<ResultsView> Extension { get; set; } 
        public IRPSGridTextBox<ResultsView> Service { get; set; } 
        public IRPSGridTextBox<ResultsView> CodInvoice { get; set; } 
        public IRPSGridTextBox<ResultsView> InvoiceDate { get; set; } 
        public IRPSGridCheckbox<ResultsView> Nullified { get; set; } 
        public IRPSGridTextBox<ResultsView> CodACCType { get; set; } 
                     
    }
 
    }
  
    

}