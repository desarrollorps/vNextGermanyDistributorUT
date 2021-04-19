    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.ConsolidationReport
{
    //RPS VERSION 1.0.0.0
    public partial class ConsolidationReport:Screen
    {
        public ConsolidationReport():base()
        {
            this.URL = "generalledger.consolidationreport";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ConsolidationReportQueryView  = new ConsolidationReportQueryView(this); 
            ConsolidationReportQueryView.InitializeControls(); 
           
        }
      
            public ConsolidationReportQueryView ConsolidationReportQueryView {get; set; } 
    }
            
    public partial class ConsolidationReportQueryView : View
    {
        public ConsolidationReportQueryView(ConsolidationReport screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ReportDate = RPSControlFactory.CreateRPSTextBox<ConsolidationReportQueryView>("f8c87e47-af4a-4075-b6bc-2d510cd82962","","",false, this);
 
            AccountigDateFrom = RPSControlFactory.CreateRPSTextBox<ConsolidationReportQueryView>("11bf237b-f4fa-4ff7-8163-ac415d8bb3b4","","",false, this);
 
            AccountigDateTo = RPSControlFactory.CreateRPSTextBox<ConsolidationReportQueryView>("9350d744-bea0-4279-a545-ee0e33e348c6","","",false, this);
 
            IDVoucherType = RPSControlFactory.CreateRPSCollectionComboBox<ConsolidationReportQueryView>("0aaa1b97-d901-4685-ac90-3531e57c3650","","",false, this);
 
            IDVoucherSeriesBook = RPSControlFactory.CreateRPSCollectionComboBox<ConsolidationReportQueryView>("5122873e-8fc7-482a-b5ad-d49029f7c15a","","",false, this);
 
            IDCompanyCON = RPSControlFactory.CreateRPSCollectionComboBox<ConsolidationReportQueryView>("26e8b0d7-5094-4aa9-8b1e-f331cef3b89b","","",false, this);
 
            IDCompanyGroup = RPSControlFactory.CreateRPSCollectionComboBox<ConsolidationReportQueryView>("a71cd8e8-904c-444e-b145-bede7d5cb146","","",false, this);
 

        }
        public IRPSTextBox<ConsolidationReportQueryView> ReportDate { get; set; } 
        public IRPSTextBox<ConsolidationReportQueryView> AccountigDateFrom { get; set; } 
        public IRPSTextBox<ConsolidationReportQueryView> AccountigDateTo { get; set; } 
        public IRPSCollectionComboBox<ConsolidationReportQueryView> IDVoucherType { get; set; } 
        public IRPSCollectionComboBox<ConsolidationReportQueryView> IDVoucherSeriesBook { get; set; } 
        public IRPSCollectionComboBox<ConsolidationReportQueryView> IDCompanyCON { get; set; } 
        public IRPSCollectionComboBox<ConsolidationReportQueryView> IDCompanyGroup { get; set; } 
        public ConsolidationReport Screen { get; set; }
        public ConsolidationReportQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}