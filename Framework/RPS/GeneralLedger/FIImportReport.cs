    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.FIImportReport
{
    //RPS VERSION 1.0.0.0
    public partial class FIImportReport:Screen
    {
        public FIImportReport():base()
        {
            this.URL = "generalledger.fiimportreport";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            FIImportReportView  = new FIImportReportView(this); 
            XMLImportDialogView  = new XMLImportDialogView(this); 
            FIImportReportView.InitializeControls(); 
            XMLImportDialogView.InitializeControls(); 
           
        }
      
            public FIImportReportView FIImportReportView {get; set; } 
            public XMLImportDialogView XMLImportDialogView {get; set; } 
    }
            
    public partial class FIImportReportView : View
    {
        public FIImportReportView(FIImportReport screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SelectLines = RPSControlFactory.CreateRPSTextBox<FIImportReportView>("299daa0e-ae7a-4c63-ba90-20073eaabe9b","","",false, this);
 
            SelectColumns = RPSControlFactory.CreateRPSTextBox<FIImportReportView>("4e9695c7-6159-454e-94b7-5289e1fc77e6","","",false, this);
 
            SelectComplexLines = RPSControlFactory.CreateRPSTextBox<FIImportReportView>("ac3a160d-9033-4531-bda5-4d0accc18333","","",false, this);
 
            XMLImportNavigationCommandButton = RPSControlFactory.CreateRPSButton<FIImportReportView>( "5f453b1d-6f8a-49bd-9f2d-b3aed11b983d","","",this);
 
            SaveCommandButton = RPSControlFactory.CreateRPSButton<FIImportReportView>( "1fca1979-513f-4741-ba41-e6ee3e6a54ef","","",this);
 
            CollectionInit params_FILineModelConsultFromImport = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0466d7ce-9150-4482-9bf1-014f30fb93d2",CSSSelectorGrid="",XPathGrid=""};
            FILineModelConsultFromImport = RPSControlFactory.RPSCreateCollectionWithGrid<FILineModelConsultFromImportCollectionEditor<FIImportReportView,XMLImportDialogView>,FIImportReportView,XMLImportDialogView>( params_FILineModelConsultFromImport,this,Screen.XMLImportDialogView);
 
            CollectionInit params_FIColumnModelConsultFromImport = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3320988f-55fb-480c-bfc7-a6a804f63072",CSSSelectorGrid="",XPathGrid=""};
            FIColumnModelConsultFromImport = RPSControlFactory.RPSCreateCollectionWithGrid<FIColumnModelConsultFromImportCollectionEditor<FIImportReportView,XMLImportDialogView>,FIImportReportView,XMLImportDialogView>( params_FIColumnModelConsultFromImport,this,Screen.XMLImportDialogView);
 
            CollectionInit params_FIComplexLineConsultFromImport = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0d16be35-1e11-4abc-84fb-74e016b67296",CSSSelectorGrid="",XPathGrid=""};
            FIComplexLineConsultFromImport = RPSControlFactory.RPSCreateCollectionWithGrid<FIComplexLineConsultFromImportCollectionEditor<FIImportReportView,XMLImportDialogView>,FIImportReportView,XMLImportDialogView>( params_FIComplexLineConsultFromImport,this,Screen.XMLImportDialogView);
 
            SectionLine = RPSControlFactory.CreateRPSSection<FIImportReportView>( "","ul li[rpsid='4dc14700-887e-4375-947a-eba6e36ea083']","",this);
 
            SectionColumn = RPSControlFactory.CreateRPSSection<FIImportReportView>( "","ul li[rpsid='0a98b969-4613-439a-a4e3-9afd0c4b2e35']","",this);
 
            SectionComplexLine = RPSControlFactory.CreateRPSSection<FIImportReportView>( "","ul li[rpsid='5e745d7e-18b1-4928-90fc-9836e01428b2']","",this);
 

        }
        public IRPSTextBox<FIImportReportView> SelectLines { get; set; } 
        public IRPSTextBox<FIImportReportView> SelectColumns { get; set; } 
        public IRPSTextBox<FIImportReportView> SelectComplexLines { get; set; } 
        public IRPSButton<FIImportReportView> XMLImportNavigationCommandButton { get; set; } 
        public IRPSButton<FIImportReportView> SaveCommandButton { get; set; } 
        public FILineModelConsultFromImportCollectionEditor<FIImportReportView,XMLImportDialogView> FILineModelConsultFromImport { get; set; } 
        public FIColumnModelConsultFromImportCollectionEditor<FIImportReportView,XMLImportDialogView> FIColumnModelConsultFromImport { get; set; } 
        public FIComplexLineConsultFromImportCollectionEditor<FIImportReportView,XMLImportDialogView> FIComplexLineConsultFromImport { get; set; } 
        public IRPSSection<FIImportReportView> SectionLine { get; set; } 
        public IRPSSection<FIImportReportView> SectionColumn { get; set; } 
        public IRPSSection<FIImportReportView> SectionComplexLine { get; set; } 
        public FIImportReport Screen { get; set; }
        public FIImportReportView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class FILineModelConsultFromImportCollectionEditor<FIImportReportView,XMLImportDialogView>:RPSCollectionEditor<FIImportReportView,XMLImportDialogView> where FIImportReportView : class, IView where XMLImportDialogView : class, IView
    {
        public  FILineModelConsultFromImportGridView<FIImportReportView,XMLImportDialogView> GridView {get;set;}
    }
    public partial class FILineModelConsultFromImportGridView <FIImportReportView,XMLImportDialogView> :  RPSGridView<FIImportReportView,XMLImportDialogView> where FIImportReportView : class, IView where XMLImportDialogView : class, IView
    {
        public FILineModelConsultFromImportGridView(FIImportReportView currentView,XMLImportDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodFILineModel = RPSControlFactory.CreateRPSGridTextBox<FIImportReportView>("","#0466d7ce-9150-4482-9bf1-014f30fb93d2 .ag-row[role='row']@ROWINDEX [col-id='cCodFILineModel']","",false, this.CurrentView);
 
            FIColumnModel = RPSControlFactory.CreateRPSGridTextBox<FIImportReportView>("","#0466d7ce-9150-4482-9bf1-014f30fb93d2 .ag-row[role='row']@ROWINDEX [col-id='cFIColumnModel']","",false, this.CurrentView);
 
            DetailsCount = RPSControlFactory.CreateRPSGridFormattedTextBox<FIImportReportView>("","#0466d7ce-9150-4482-9bf1-014f30fb93d2 .ag-row[role='row']@ROWINDEX [col-id='cDetailsCount']","",false, this.CurrentView);
 
            ComplexCount = RPSControlFactory.CreateRPSGridFormattedTextBox<FIImportReportView>("","#0466d7ce-9150-4482-9bf1-014f30fb93d2 .ag-row[role='row']@ROWINDEX [col-id='cComplexCount']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<FIImportReportView> CodFILineModel { get; set; } 
        public IRPSGridTextBox<FIImportReportView> FIColumnModel { get; set; } 
        public IRPSGridTextBox<FIImportReportView> DetailsCount { get; set; } 
        public IRPSGridTextBox<FIImportReportView> ComplexCount { get; set; } 
                     
    }
 
        public partial class FIColumnModelConsultFromImportCollectionEditor<FIImportReportView,XMLImportDialogView>:RPSCollectionEditor<FIImportReportView,XMLImportDialogView> where FIImportReportView : class, IView where XMLImportDialogView : class, IView
    {
        public  FIColumnModelConsultFromImportGridView<FIImportReportView,XMLImportDialogView> GridView {get;set;}
    }
    public partial class FIColumnModelConsultFromImportGridView <FIImportReportView,XMLImportDialogView> :  RPSGridView<FIImportReportView,XMLImportDialogView> where FIImportReportView : class, IView where XMLImportDialogView : class, IView
    {
        public FIColumnModelConsultFromImportGridView(FIImportReportView currentView,XMLImportDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodFIColumnModel = RPSControlFactory.CreateRPSGridTextBox<FIImportReportView>("","#3320988f-55fb-480c-bfc7-a6a804f63072 .ag-row[role='row']@ROWINDEX [col-id='cCodFIColumnModel']","",false, this.CurrentView);
 
            DetailsCount = RPSControlFactory.CreateRPSGridFormattedTextBox<FIImportReportView>("","#3320988f-55fb-480c-bfc7-a6a804f63072 .ag-row[role='row']@ROWINDEX [col-id='cDetailsCount']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<FIImportReportView> CodFIColumnModel { get; set; } 
        public IRPSGridTextBox<FIImportReportView> DetailsCount { get; set; } 
                     
    }
 
        public partial class FIComplexLineConsultFromImportCollectionEditor<FIImportReportView,XMLImportDialogView>:RPSCollectionEditor<FIImportReportView,XMLImportDialogView> where FIImportReportView : class, IView where XMLImportDialogView : class, IView
    {
        public  FIComplexLineConsultFromImportGridView<FIImportReportView,XMLImportDialogView> GridView {get;set;}
    }
    public partial class FIComplexLineConsultFromImportGridView <FIImportReportView,XMLImportDialogView> :  RPSGridView<FIImportReportView,XMLImportDialogView> where FIImportReportView : class, IView where XMLImportDialogView : class, IView
    {
        public FIComplexLineConsultFromImportGridView(FIImportReportView currentView,XMLImportDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodComplexLine = RPSControlFactory.CreateRPSGridTextBox<FIImportReportView>("","#0d16be35-1e11-4abc-84fb-74e016b67296 .ag-row[role='row']@ROWINDEX [col-id='cCodComplexLine']","",false, this.CurrentView);
 
            Areas = RPSControlFactory.CreateRPSGridTextBox<FIImportReportView>("","#0d16be35-1e11-4abc-84fb-74e016b67296 .ag-row[role='row']@ROWINDEX [col-id='cAreas']","",false, this.CurrentView);
 
            VoucherTypes = RPSControlFactory.CreateRPSGridTextBox<FIImportReportView>("","#0d16be35-1e11-4abc-84fb-74e016b67296 .ag-row[role='row']@ROWINDEX [col-id='cVoucherTypes']","",false, this.CurrentView);
 
            DocumentTypes = RPSControlFactory.CreateRPSGridTextBox<FIImportReportView>("","#0d16be35-1e11-4abc-84fb-74e016b67296 .ag-row[role='row']@ROWINDEX [col-id='cDocumentTypes']","",false, this.CurrentView);
 
            CountryType = RPSControlFactory.CreateRPSGridEnumComboBox<FIImportReportView>("","#0d16be35-1e11-4abc-84fb-74e016b67296 .ag-row[role='row']@ROWINDEX [col-id='ceCountryType']","",false, this.CurrentView);
 
            MovementTypes = RPSControlFactory.CreateRPSGridTextBox<FIImportReportView>("","#0d16be35-1e11-4abc-84fb-74e016b67296 .ag-row[role='row']@ROWINDEX [col-id='cMovementTypes']","",false, this.CurrentView);
 
            VATCodes = RPSControlFactory.CreateRPSGridTextBox<FIImportReportView>("","#0d16be35-1e11-4abc-84fb-74e016b67296 .ag-row[role='row']@ROWINDEX [col-id='cVATCodes']","",false, this.CurrentView);
 
            TaxCodes = RPSControlFactory.CreateRPSGridTextBox<FIImportReportView>("","#0d16be35-1e11-4abc-84fb-74e016b67296 .ag-row[role='row']@ROWINDEX [col-id='cTaxCodes']","",false, this.CurrentView);
 
            TaxValueCodes = RPSControlFactory.CreateRPSGridTextBox<FIImportReportView>("","#0d16be35-1e11-4abc-84fb-74e016b67296 .ag-row[role='row']@ROWINDEX [col-id='cTaxValueCodes']","",false, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<FIImportReportView>("","#0d16be35-1e11-4abc-84fb-74e016b67296 .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",false, this.CurrentView);
 
            UsePercentage = RPSControlFactory.CreateRPSGridCheckBox<FIImportReportView>("","#0d16be35-1e11-4abc-84fb-74e016b67296 .ag-row[role='row']@ROWINDEX [col-id='cUsePercentage']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<FIImportReportView> CodComplexLine { get; set; } 
        public IRPSGridTextBox<FIImportReportView> Areas { get; set; } 
        public IRPSGridTextBox<FIImportReportView> VoucherTypes { get; set; } 
        public IRPSGridTextBox<FIImportReportView> DocumentTypes { get; set; } 
        public IRPSGridComboBox<FIImportReportView> CountryType { get; set; } 
        public IRPSGridTextBox<FIImportReportView> MovementTypes { get; set; } 
        public IRPSGridTextBox<FIImportReportView> VATCodes { get; set; } 
        public IRPSGridTextBox<FIImportReportView> TaxCodes { get; set; } 
        public IRPSGridTextBox<FIImportReportView> TaxValueCodes { get; set; } 
        public IRPSGridTextBox<FIImportReportView> Percentage { get; set; } 
        public IRPSGridCheckbox<FIImportReportView> UsePercentage { get; set; } 
                     
    }
 
    }
  
            
    public partial class XMLImportDialogView : View
    {
        public XMLImportDialogView(FIImportReport screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public FIImportReport Screen { get; set; }
        public XMLImportDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}