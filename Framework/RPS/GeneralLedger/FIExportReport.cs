    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.FIExportReport
{
    //RPS VERSION 1.0.0.0
    public partial class FIExportReport:Screen
    {
        public FIExportReport():base()
        {
            this.URL = "generalledger.fiexportreport";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            FIExportReportView  = new FIExportReportView(this); 
            FIExportReportView.InitializeControls(); 
           
        }
      
            public FIExportReportView FIExportReportView {get; set; } 
    }
            
    public partial class FIExportReportView : View
    {
        public FIExportReportView(FIExportReport screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SelectLines = RPSControlFactory.CreateRPSTextBox<FIExportReportView>("4a830303-ddad-425d-87aa-ea6edd763a10","","",false, this);
 
            SelectColumns = RPSControlFactory.CreateRPSTextBox<FIExportReportView>("3e1af79f-89dc-488b-89f2-1c76c6d2e645","","",false, this);
 
            SelectComplexLines = RPSControlFactory.CreateRPSTextBox<FIExportReportView>("72f35493-12d4-43c9-b1dd-ea91e25b8920","","",false, this);
 
            ExportCommandButton = RPSControlFactory.CreateRPSButton<FIExportReportView>( "fc6c25d0-746f-4da5-88b9-8d1649cd5815","","",this);
 
            FullExportCommandButton = RPSControlFactory.CreateRPSButton<FIExportReportView>( "5a58b66b-3522-4f7a-865a-5ae57ab81a3e","","",this);
 
            CollectionInit params_FILineModelConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="03b3df16-3f83-4c94-a7ff-17b583d58575",CSSSelectorGrid="",XPathGrid=""};
            FILineModelConsult = RPSControlFactory.RPSCreateCollectionWithGrid<FILineModelConsultCollectionEditor<FIExportReportView>,FIExportReportView>( params_FILineModelConsult,this);
 
            CollectionInit params_FIColumnModelConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1b44b3d0-809e-45bc-ad12-a0bdbd444e75",CSSSelectorGrid="",XPathGrid=""};
            FIColumnModelConsult = RPSControlFactory.RPSCreateCollectionWithGrid<FIColumnModelConsultCollectionEditor<FIExportReportView>,FIExportReportView>( params_FIColumnModelConsult,this);
 
            CollectionInit params_FIComplexLineConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="19549dd3-46e0-4eb4-bb13-27533fe244ad",CSSSelectorGrid="",XPathGrid=""};
            FIComplexLineConsult = RPSControlFactory.RPSCreateCollectionWithGrid<FIComplexLineConsultCollectionEditor<FIExportReportView>,FIExportReportView>( params_FIComplexLineConsult,this);
 
            SectionLine = RPSControlFactory.CreateRPSSection<FIExportReportView>( "","ul li[rpsid='f65e4d76-8b06-4ba5-8ea3-d05de875800d']","",this);
 
            SectionColumn = RPSControlFactory.CreateRPSSection<FIExportReportView>( "","ul li[rpsid='41aff974-9b4e-408a-be03-5cac88202de2']","",this);
 
            SectionComplexLine = RPSControlFactory.CreateRPSSection<FIExportReportView>( "","ul li[rpsid='abaccd0b-0b81-40af-8753-2b2c20c2cf8e']","",this);
 

        }
        public IRPSTextBox<FIExportReportView> SelectLines { get; set; } 
        public IRPSTextBox<FIExportReportView> SelectColumns { get; set; } 
        public IRPSTextBox<FIExportReportView> SelectComplexLines { get; set; } 
        public IRPSButton<FIExportReportView> ExportCommandButton { get; set; } 
        public IRPSButton<FIExportReportView> FullExportCommandButton { get; set; } 
        public FILineModelConsultCollectionEditor<FIExportReportView> FILineModelConsult { get; set; } 
        public FIColumnModelConsultCollectionEditor<FIExportReportView> FIColumnModelConsult { get; set; } 
        public FIComplexLineConsultCollectionEditor<FIExportReportView> FIComplexLineConsult { get; set; } 
        public IRPSSection<FIExportReportView> SectionLine { get; set; } 
        public IRPSSection<FIExportReportView> SectionColumn { get; set; } 
        public IRPSSection<FIExportReportView> SectionComplexLine { get; set; } 
        public FIExportReport Screen { get; set; }
        public FIExportReportView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class FILineModelConsultCollectionEditor<FIExportReportView>:RPSCollectionEditor<FIExportReportView> where FIExportReportView : class, IView
    {
        public  FILineModelConsultGridView<FIExportReportView> GridView {get;set;}
    }
    public partial class FILineModelConsultGridView <FIExportReportView> :  RPSGridView<FIExportReportView> where FIExportReportView : class, IView
    {
        public FILineModelConsultGridView(FIExportReportView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DetailsCount = RPSControlFactory.CreateRPSGridFormattedTextBox<FIExportReportView>("","#03b3df16-3f83-4c94-a7ff-17b583d58575 .ag-row[role='row']@ROWINDEX [col-id='cDetailsCount']","",false, this.CurrentView);
 
            ComplexCount = RPSControlFactory.CreateRPSGridFormattedTextBox<FIExportReportView>("","#03b3df16-3f83-4c94-a7ff-17b583d58575 .ag-row[role='row']@ROWINDEX [col-id='cComplexCount']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<FIExportReportView> DetailsCount { get; set; } 
        public IRPSGridTextBox<FIExportReportView> ComplexCount { get; set; } 
                     
    }
 
        public partial class FIColumnModelConsultCollectionEditor<FIExportReportView>:RPSCollectionEditor<FIExportReportView> where FIExportReportView : class, IView
    {
        public  FIColumnModelConsultGridView<FIExportReportView> GridView {get;set;}
    }
    public partial class FIColumnModelConsultGridView <FIExportReportView> :  RPSGridView<FIExportReportView> where FIExportReportView : class, IView
    {
        public FIColumnModelConsultGridView(FIExportReportView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DetailsCount = RPSControlFactory.CreateRPSGridFormattedTextBox<FIExportReportView>("","#1b44b3d0-809e-45bc-ad12-a0bdbd444e75 .ag-row[role='row']@ROWINDEX [col-id='cDetailsCount']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<FIExportReportView> DetailsCount { get; set; } 
                     
    }
 
        public partial class FIComplexLineConsultCollectionEditor<FIExportReportView>:RPSCollectionEditor<FIExportReportView> where FIExportReportView : class, IView
    {
        public  FIComplexLineConsultGridView<FIExportReportView> GridView {get;set;}
    }
    public partial class FIComplexLineConsultGridView <FIExportReportView> :  RPSGridView<FIExportReportView> where FIExportReportView : class, IView
    {
        public FIComplexLineConsultGridView(FIExportReportView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            FIComplexLine_Areas = RPSControlFactory.CreateRPSGridTextBox<FIExportReportView>("","#19549dd3-46e0-4eb4-bb13-27533fe244ad .ag-row[role='row']@ROWINDEX [col-id='cFIComplexLine_Areas']","",false, this.CurrentView);
 
            FIComplexLine_VoucherTypes = RPSControlFactory.CreateRPSGridTextBox<FIExportReportView>("","#19549dd3-46e0-4eb4-bb13-27533fe244ad .ag-row[role='row']@ROWINDEX [col-id='cFIComplexLine_VoucherTypes']","",false, this.CurrentView);
 
            FIComplexLine_DocumentTypes = RPSControlFactory.CreateRPSGridTextBox<FIExportReportView>("","#19549dd3-46e0-4eb4-bb13-27533fe244ad .ag-row[role='row']@ROWINDEX [col-id='cFIComplexLine_DocumentTypes']","",false, this.CurrentView);
 
            FIComplexLine_CountryType = RPSControlFactory.CreateRPSGridTextBox<FIExportReportView>("","#19549dd3-46e0-4eb4-bb13-27533fe244ad .ag-row[role='row']@ROWINDEX [col-id='cFIComplexLine_CountryType']","",false, this.CurrentView);
 
            FIComplexLine_MovementTypes = RPSControlFactory.CreateRPSGridTextBox<FIExportReportView>("","#19549dd3-46e0-4eb4-bb13-27533fe244ad .ag-row[role='row']@ROWINDEX [col-id='cFIComplexLine_MovementTypes']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<FIExportReportView> FIComplexLine_Areas { get; set; } 
        public IRPSGridTextBox<FIExportReportView> FIComplexLine_VoucherTypes { get; set; } 
        public IRPSGridTextBox<FIExportReportView> FIComplexLine_DocumentTypes { get; set; } 
        public IRPSGridTextBox<FIExportReportView> FIComplexLine_CountryType { get; set; } 
        public IRPSGridTextBox<FIExportReportView> FIComplexLine_MovementTypes { get; set; } 
                     
    }
 
    }
  
    

}