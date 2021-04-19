    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.JournalReportConsult
{
    //RPS VERSION 1.0.0.0
    public partial class JournalReportConsult:Screen
    {
        public JournalReportConsult():base()
        {
            this.URL = "generalledger.journalreportconsult";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            JournalReportConsultQueryView  = new JournalReportConsultQueryView(this); 
            JournalReportConsultQueryView.InitializeControls(); 
           
        }
      
            public JournalReportConsultQueryView JournalReportConsultQueryView {get; set; } 
    }
            
    public partial class JournalReportConsultQueryView : View
    {
        public JournalReportConsultQueryView(JournalReportConsult screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DateFrom = RPSControlFactory.CreateRPSTextBox<JournalReportConsultQueryView>("b2453478-b83f-489e-a10f-736f315b438c","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<JournalReportConsultQueryView>("4c67eac6-0790-4a6b-b569-df6b9041be9f","","",false, this);
 
            VoucherSeriesBook = RPSControlFactory.CreateRPSCollectionComboBox<JournalReportConsultQueryView>("ff135ef0-512d-4459-ba37-bf38de4444e9","","",false, this);
 
            Nullified = RPSControlFactory.CreateRPSCheckBox<JournalReportConsultQueryView>("b99995e4-4d37-49bf-8965-51f4c57f3417","","",false, this);
 
            Account = RPSControlFactory.CreateRPSCollectionComboBox<JournalReportConsultQueryView>("a66c5dbe-e993-4b4b-93b0-758754b5f494","","",false, this);
 
            AccountGroup = RPSControlFactory.CreateRPSCollectionComboBox<JournalReportConsultQueryView>("53baaaf5-b29b-41c1-a3f3-153d276b9604","","",false, this);
 
            AccountCluster = RPSControlFactory.CreateRPSCollectionComboBox<JournalReportConsultQueryView>("27a2b985-84e7-4caf-bd95-1ee4558d6660","","",false, this);
 
            ByJournalNumber = RPSControlFactory.CreateRPSOption<JournalReportConsultQueryView>( "2174ea01-c340-4c74-a002-41fbb9390392","","",this);
 
            ByDate = RPSControlFactory.CreateRPSOption<JournalReportConsultQueryView>( "be2460dc-0756-43c7-8376-1820ad246180","","",this);
 
            ByVoucherSerieVoucherName = RPSControlFactory.CreateRPSOption<JournalReportConsultQueryView>( "c09d7d39-7c06-4aa3-8d68-b8704a16abdd","","",this);
 
            ByVoucherSerieDate = RPSControlFactory.CreateRPSOption<JournalReportConsultQueryView>( "9e70698b-d68f-4a51-a9b8-50bfe142c922","","",this);
 
            ReportDate = RPSControlFactory.CreateRPSTextBox<JournalReportConsultQueryView>("c1034db6-d89b-4bb4-ac3b-0277ac97938e","","",false, this);
 
            TotalCreditAmount = RPSControlFactory.CreateRPSFormattedTextBox<JournalReportConsultQueryView>("86f6b980-c766-4535-814a-b4d4cd942f7d","","",false, this);
 
            TotalDebitAmount = RPSControlFactory.CreateRPSFormattedTextBox<JournalReportConsultQueryView>("5eee200c-1a0e-4a90-a226-ae9424d83686","","",false, this);
 
            ACCTransactions_VoucherNumber = RPSControlFactory.CreateRPSFormattedTextBox<JournalReportConsultQueryView>("d240339d-41de-4f18-8aa7-f76bb8eba3ef","","",false, this);
 
            ACCTransactionsDetail_VoucherNumberLine = RPSControlFactory.CreateRPSFormattedTextBox<JournalReportConsultQueryView>("9f35a4d7-7392-451b-97bd-2742271625b4","","",false, this);
 
            ACCTransactionsDetail_Extension = RPSControlFactory.CreateRPSTextBox<JournalReportConsultQueryView>("3712a5ed-4b6a-491a-a4d5-13d386ae1239","","",false, this);
 
            CollectionInit params_JournalReportConsult = new CollectionInit(){IDDescriptor = "26328e19-1b51-4a6f-bffa-2990a51156a1",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f79e19af-b12c-4a62-ad84-693ef1622ca5",CSSSelectorGrid="",XPathGrid=""};
            JournalReportConsult = RPSControlFactory.RPSCreateCollectionWithGrid<JournalReportConsultCollectionEditor<JournalReportConsultQueryView>,JournalReportConsultQueryView>( params_JournalReportConsult,this);
 
            CollectionInit params_ACCTransactionsAnalyticConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="49f4e7c6-d0b2-4ecf-a7cc-833ea3fc9cf4",CSSSelectorGrid="",XPathGrid=""};
            ACCTransactionsAnalyticConsult = RPSControlFactory.RPSCreateCollectionWithGrid<ACCTransactionsAnalyticConsultCollectionEditor<JournalReportConsultQueryView>,JournalReportConsultQueryView>( params_ACCTransactionsAnalyticConsult,this);
 

        }
        public IRPSTextBox<JournalReportConsultQueryView> DateFrom { get; set; } 
        public IRPSTextBox<JournalReportConsultQueryView> DateTo { get; set; } 
        public IRPSCollectionComboBox<JournalReportConsultQueryView> VoucherSeriesBook { get; set; } 
        public IRPSCheckbox<JournalReportConsultQueryView> Nullified { get; set; } 
        public IRPSCollectionComboBox<JournalReportConsultQueryView> Account { get; set; } 
        public IRPSCollectionComboBox<JournalReportConsultQueryView> AccountGroup { get; set; } 
        public IRPSCollectionComboBox<JournalReportConsultQueryView> AccountCluster { get; set; } 
        public IRPSOption<JournalReportConsultQueryView> ByJournalNumber { get; set; } 
        public IRPSOption<JournalReportConsultQueryView> ByDate { get; set; } 
        public IRPSOption<JournalReportConsultQueryView> ByVoucherSerieVoucherName { get; set; } 
        public IRPSOption<JournalReportConsultQueryView> ByVoucherSerieDate { get; set; } 
        public IRPSTextBox<JournalReportConsultQueryView> ReportDate { get; set; } 
        public IRPSTextBox<JournalReportConsultQueryView> TotalCreditAmount { get; set; } 
        public IRPSTextBox<JournalReportConsultQueryView> TotalDebitAmount { get; set; } 
        public IRPSTextBox<JournalReportConsultQueryView> ACCTransactions_VoucherNumber { get; set; } 
        public IRPSTextBox<JournalReportConsultQueryView> ACCTransactionsDetail_VoucherNumberLine { get; set; } 
        public IRPSTextBox<JournalReportConsultQueryView> ACCTransactionsDetail_Extension { get; set; } 
        public JournalReportConsultCollectionEditor<JournalReportConsultQueryView> JournalReportConsult { get; set; } 
        public ACCTransactionsAnalyticConsultCollectionEditor<JournalReportConsultQueryView> ACCTransactionsAnalyticConsult { get; set; } 
        public JournalReportConsult Screen { get; set; }
        public JournalReportConsultQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class JournalReportConsultCollectionEditor<JournalReportConsultQueryView>:RPSCollectionEditor<JournalReportConsultQueryView> where JournalReportConsultQueryView : class, IView
    {
        public  JournalReportConsultGridView<JournalReportConsultQueryView> GridView {get;set;}
    }
    public partial class JournalReportConsultGridView <JournalReportConsultQueryView> :  RPSGridView<JournalReportConsultQueryView> where JournalReportConsultQueryView : class, IView
    {
        public JournalReportConsultGridView(JournalReportConsultQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ACCTransactions_VoucherNumber = RPSControlFactory.CreateRPSGridFormattedTextBox<JournalReportConsultQueryView>("","#f79e19af-b12c-4a62-ad84-693ef1622ca5 .ag-row[role='row']@ROWINDEX [col-id='cACCTransactions_VoucherNumber']","",false, this.CurrentView);
 
            ACCTransactionsDetail_Extension = RPSControlFactory.CreateRPSGridTextBox<JournalReportConsultQueryView>("","#f79e19af-b12c-4a62-ad84-693ef1622ca5 .ag-row[role='row']@ROWINDEX [col-id='cACCTransactionsDetail_Extension']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<JournalReportConsultQueryView> ACCTransactions_VoucherNumber { get; set; } 
        public IRPSGridTextBox<JournalReportConsultQueryView> ACCTransactionsDetail_Extension { get; set; } 
                     
    }
 
        public partial class ACCTransactionsAnalyticConsultCollectionEditor<JournalReportConsultQueryView>:RPSCollectionEditor<JournalReportConsultQueryView> where JournalReportConsultQueryView : class, IView
    {
        public  ACCTransactionsAnalyticConsultGridView<JournalReportConsultQueryView> GridView {get;set;}
    }
    public partial class ACCTransactionsAnalyticConsultGridView <JournalReportConsultQueryView> :  RPSGridView<JournalReportConsultQueryView> where JournalReportConsultQueryView : class, IView
    {
        public ACCTransactionsAnalyticConsultGridView(JournalReportConsultQueryView currentView)
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