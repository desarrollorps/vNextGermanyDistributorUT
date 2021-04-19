    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.ConsolidatedTrialBalance
{
    //RPS VERSION 1.0.0.0
    public partial class ConsolidatedTrialBalance:Screen
    {
        public ConsolidatedTrialBalance():base()
        {
            this.URL = "generalledger.consolidatedtrialbalance";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ConsolidatedTrialBalanceQueryView  = new ConsolidatedTrialBalanceQueryView(this); 
            ConsolidatedTrialBalanceQueryView.InitializeControls(); 
           
        }
      
            public ConsolidatedTrialBalanceQueryView ConsolidatedTrialBalanceQueryView {get; set; } 
    }
            
    public partial class ConsolidatedTrialBalanceQueryView : View
    {
        public ConsolidatedTrialBalanceQueryView(ConsolidatedTrialBalance screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ConsolidationType = RPSControlFactory.CreateRPSComboBox<ConsolidatedTrialBalanceQueryView>("952e801a-075e-491d-9db1-db535348ea7a","","",false, this);
 
            IDAccConsolidationList = RPSControlFactory.CreateRPSCollectionComboBox<ConsolidatedTrialBalanceQueryView>("6d8cecd0-378a-4156-b26b-fa5ad3752925","","",false, this);
 
            DateTimeFrom = RPSControlFactory.CreateRPSTextBox<ConsolidatedTrialBalanceQueryView>("3d489166-8f2c-4749-9ad9-dbf5989166c3","","",false, this);
 
            DateTimeTo = RPSControlFactory.CreateRPSTextBox<ConsolidatedTrialBalanceQueryView>("b98d7e08-7aa2-46cf-9d18-e8cfb2facca6","","",false, this);
 
            CodCompanyList = RPSControlFactory.CreateRPSCollectionComboBox<ConsolidatedTrialBalanceQueryView>("91a5d982-1f6c-45f6-8827-c7fceea92acf","","",false, this);
 
            bOnlyAccountsWithFinalBalanceOrMovements = RPSControlFactory.CreateRPSCheckBox<ConsolidatedTrialBalanceQueryView>("04077c41-5d07-4ce6-be59-91317289edac","","",false, this);
 
            chkOnlyAccountsWithFinalBalance = RPSControlFactory.CreateRPSCheckBox<ConsolidatedTrialBalanceQueryView>("af7e0530-b708-4e8d-a425-dba9909c2124","","",false, this);
 
            chkOnlyAccountsWithPeriodMovements = RPSControlFactory.CreateRPSCheckBox<ConsolidatedTrialBalanceQueryView>("a19c2e88-6c34-41d8-8d14-e409af426132","","",false, this);
 
            chkIncludeLastYearBalance = RPSControlFactory.CreateRPSCheckBox<ConsolidatedTrialBalanceQueryView>("04e5f8ac-c8d8-41fe-b92c-cd580000addd","","",false, this);
 
            chkExcludeClosingEntry = RPSControlFactory.CreateRPSCheckBox<ConsolidatedTrialBalanceQueryView>("7dcfcad2-74e1-4460-a5b1-707c7807f979","","",false, this);
 
            bGroup1 = RPSControlFactory.CreateRPSCheckBox<ConsolidatedTrialBalanceQueryView>("bb8bc6be-4e86-475e-91f0-4fdb4ba6412b","","",false, this);
 
            bGroup2 = RPSControlFactory.CreateRPSCheckBox<ConsolidatedTrialBalanceQueryView>("81279bc5-66dd-4170-a731-9deaa0e2ba39","","",false, this);
 
            bGroup3 = RPSControlFactory.CreateRPSCheckBox<ConsolidatedTrialBalanceQueryView>("e539232d-2d7a-47be-89fb-8c60b4fdecf0","","",false, this);
 
            bGroup4 = RPSControlFactory.CreateRPSCheckBox<ConsolidatedTrialBalanceQueryView>("4b5e35b6-eab6-440b-9d8a-c7be00e9ba8b","","",false, this);
 
            bGroup5 = RPSControlFactory.CreateRPSCheckBox<ConsolidatedTrialBalanceQueryView>("e7fbe0a4-832f-4870-b6c9-9490e2dd5f00","","",false, this);
 
            bGroup6 = RPSControlFactory.CreateRPSCheckBox<ConsolidatedTrialBalanceQueryView>("58f6eaa1-f41f-40ee-86c2-c8b88d7fd9f6","","",false, this);
 
            bGroup7 = RPSControlFactory.CreateRPSCheckBox<ConsolidatedTrialBalanceQueryView>("194cb505-d91d-4c17-bc39-584ef2a77fb4","","",false, this);
 
            bDetailed = RPSControlFactory.CreateRPSCheckBox<ConsolidatedTrialBalanceQueryView>("189f45b3-589b-4464-8a05-ba7891d7a476","","",false, this);
 
            ReportCommandButton = RPSControlFactory.CreateRPSButton<ConsolidatedTrialBalanceQueryView>( "06506d3d-7cf8-4a25-8613-8bc8f6f760d7","","",this);
 

        }
        public IRPSComboBox<ConsolidatedTrialBalanceQueryView> ConsolidationType { get; set; } 
        public IRPSCollectionComboBox<ConsolidatedTrialBalanceQueryView> IDAccConsolidationList { get; set; } 
        public IRPSTextBox<ConsolidatedTrialBalanceQueryView> DateTimeFrom { get; set; } 
        public IRPSTextBox<ConsolidatedTrialBalanceQueryView> DateTimeTo { get; set; } 
        public IRPSCollectionComboBox<ConsolidatedTrialBalanceQueryView> CodCompanyList { get; set; } 
        public IRPSCheckbox<ConsolidatedTrialBalanceQueryView> bOnlyAccountsWithFinalBalanceOrMovements { get; set; } 
        public IRPSCheckbox<ConsolidatedTrialBalanceQueryView> chkOnlyAccountsWithFinalBalance { get; set; } 
        public IRPSCheckbox<ConsolidatedTrialBalanceQueryView> chkOnlyAccountsWithPeriodMovements { get; set; } 
        public IRPSCheckbox<ConsolidatedTrialBalanceQueryView> chkIncludeLastYearBalance { get; set; } 
        public IRPSCheckbox<ConsolidatedTrialBalanceQueryView> chkExcludeClosingEntry { get; set; } 
        public IRPSCheckbox<ConsolidatedTrialBalanceQueryView> bGroup1 { get; set; } 
        public IRPSCheckbox<ConsolidatedTrialBalanceQueryView> bGroup2 { get; set; } 
        public IRPSCheckbox<ConsolidatedTrialBalanceQueryView> bGroup3 { get; set; } 
        public IRPSCheckbox<ConsolidatedTrialBalanceQueryView> bGroup4 { get; set; } 
        public IRPSCheckbox<ConsolidatedTrialBalanceQueryView> bGroup5 { get; set; } 
        public IRPSCheckbox<ConsolidatedTrialBalanceQueryView> bGroup6 { get; set; } 
        public IRPSCheckbox<ConsolidatedTrialBalanceQueryView> bGroup7 { get; set; } 
        public IRPSCheckbox<ConsolidatedTrialBalanceQueryView> bDetailed { get; set; } 
        public IRPSButton<ConsolidatedTrialBalanceQueryView> ReportCommandButton { get; set; } 
        public ConsolidatedTrialBalance Screen { get; set; }
        public ConsolidatedTrialBalanceQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}