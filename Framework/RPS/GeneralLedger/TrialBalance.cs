    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.TrialBalance
{
    //RPS VERSION 1.0.0.0
    public partial class TrialBalance:Screen
    {
        public TrialBalance():base()
        {
            this.URL = "generalledger.trialbalance";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            TrialBalanceQueryView  = new TrialBalanceQueryView(this); 
            TrialBalanceQueryView.InitializeControls(); 
           
        }
      
            public TrialBalanceQueryView TrialBalanceQueryView {get; set; } 
    }
            
    public partial class TrialBalanceQueryView : View
    {
        public TrialBalanceQueryView(TrialBalance screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            optValueDateTo = RPSControlFactory.CreateRPSOption<TrialBalanceQueryView>( "cd52b188-a41f-4ed8-9c74-d8826dddfbde","","",this);
 
            optValuePeriods = RPSControlFactory.CreateRPSOption<TrialBalanceQueryView>( "5fd3a935-dc53-4528-ad6a-0ddce8a7b215","","",this);
 
            optValueOpening = RPSControlFactory.CreateRPSOption<TrialBalanceQueryView>( "9ac221f3-b9bd-4fdf-a064-75684040f839","","",this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<TrialBalanceQueryView>("b397de3a-6f2b-4192-bac0-1bc975f1ea2b","","",false, this);
 
            IDACCYear = RPSControlFactory.CreateRPSComboBox<TrialBalanceQueryView>("91be51c5-2f18-4caa-8f97-cd25eb606db2","","",false, this);
 
            IDACCPeriodFrom = RPSControlFactory.CreateRPSComboBox<TrialBalanceQueryView>("11fd41e0-ada4-4540-9f93-8686a9bbcd88","","",false, this);
 
            IDACCPeriodTo = RPSControlFactory.CreateRPSComboBox<TrialBalanceQueryView>("00836140-a24e-4435-becb-8ab1748fbb0e","","",false, this);
 
            IDAccountList = RPSControlFactory.CreateRPSCollectionComboBox<TrialBalanceQueryView>("5843d19f-d540-424d-ae83-781e1b0b4d73","","",false, this);
 
            IDAccountGroupList = RPSControlFactory.CreateRPSCollectionComboBox<TrialBalanceQueryView>("321a105d-8f8f-41c7-bd87-430728c4066b","","",false, this);
 
            IDAccountClusterList = RPSControlFactory.CreateRPSCollectionComboBox<TrialBalanceQueryView>("502594c3-8ccf-4590-a4ab-54d07c76a53c","","",false, this);
 
            bOnlyAccountsWithFinalBalanceOrMovements = RPSControlFactory.CreateRPSCheckBox<TrialBalanceQueryView>("ec72de26-18dc-4e76-93c7-61ed6c2dd5db","","",false, this);
 
            chkOnlyAccountsWithFinalBalance = RPSControlFactory.CreateRPSCheckBox<TrialBalanceQueryView>("af7e0530-b708-4e8d-a425-dba9909c2124","","",false, this);
 
            chkOnlyAccountsWithPeriodMovements = RPSControlFactory.CreateRPSCheckBox<TrialBalanceQueryView>("a19c2e88-6c34-41d8-8d14-e409af426132","","",false, this);
 
            chkIncludeLastYearBalance = RPSControlFactory.CreateRPSCheckBox<TrialBalanceQueryView>("04e5f8ac-c8d8-41fe-b92c-cd580000addd","","",false, this);
 
            chkExcludeClosingEntry = RPSControlFactory.CreateRPSCheckBox<TrialBalanceQueryView>("7dcfcad2-74e1-4460-a5b1-707c7807f979","","",false, this);
 
            bTC = RPSControlFactory.CreateRPSCheckBox<TrialBalanceQueryView>("a123c69b-7591-4fe0-9876-e9c881acab24","","",false, this);
 
            bGroup1 = RPSControlFactory.CreateRPSCheckBox<TrialBalanceQueryView>("bb8bc6be-4e86-475e-91f0-4fdb4ba6412b","","",false, this);
 
            bGroup2 = RPSControlFactory.CreateRPSCheckBox<TrialBalanceQueryView>("81279bc5-66dd-4170-a731-9deaa0e2ba39","","",false, this);
 
            bGroup3 = RPSControlFactory.CreateRPSCheckBox<TrialBalanceQueryView>("e539232d-2d7a-47be-89fb-8c60b4fdecf0","","",false, this);
 
            bGroup4 = RPSControlFactory.CreateRPSCheckBox<TrialBalanceQueryView>("4b5e35b6-eab6-440b-9d8a-c7be00e9ba8b","","",false, this);
 
            bGroup5 = RPSControlFactory.CreateRPSCheckBox<TrialBalanceQueryView>("e7fbe0a4-832f-4870-b6c9-9490e2dd5f00","","",false, this);
 
            bGroup6 = RPSControlFactory.CreateRPSCheckBox<TrialBalanceQueryView>("58f6eaa1-f41f-40ee-86c2-c8b88d7fd9f6","","",false, this);
 
            bGroup7 = RPSControlFactory.CreateRPSCheckBox<TrialBalanceQueryView>("194cb505-d91d-4c17-bc39-584ef2a77fb4","","",false, this);
 
            bDetailed = RPSControlFactory.CreateRPSCheckBox<TrialBalanceQueryView>("189f45b3-589b-4464-8a05-ba7891d7a476","","",false, this);
 
            bPosting = RPSControlFactory.CreateRPSCheckBox<TrialBalanceQueryView>("b272a3fb-1a9f-4ecf-b681-82781e1d0b80","","",false, this);
 
            ReportCommandButton = RPSControlFactory.CreateRPSButton<TrialBalanceQueryView>( "f059436e-7c7d-46e1-9737-5cc220cb70c9","","",this);
 

        }
        public IRPSOption<TrialBalanceQueryView> optValueDateTo { get; set; } 
        public IRPSOption<TrialBalanceQueryView> optValuePeriods { get; set; } 
        public IRPSOption<TrialBalanceQueryView> optValueOpening { get; set; } 
        public IRPSTextBox<TrialBalanceQueryView> DateTo { get; set; } 
        public IRPSComboBox<TrialBalanceQueryView> IDACCYear { get; set; } 
        public IRPSComboBox<TrialBalanceQueryView> IDACCPeriodFrom { get; set; } 
        public IRPSComboBox<TrialBalanceQueryView> IDACCPeriodTo { get; set; } 
        public IRPSCollectionComboBox<TrialBalanceQueryView> IDAccountList { get; set; } 
        public IRPSCollectionComboBox<TrialBalanceQueryView> IDAccountGroupList { get; set; } 
        public IRPSCollectionComboBox<TrialBalanceQueryView> IDAccountClusterList { get; set; } 
        public IRPSCheckbox<TrialBalanceQueryView> bOnlyAccountsWithFinalBalanceOrMovements { get; set; } 
        public IRPSCheckbox<TrialBalanceQueryView> chkOnlyAccountsWithFinalBalance { get; set; } 
        public IRPSCheckbox<TrialBalanceQueryView> chkOnlyAccountsWithPeriodMovements { get; set; } 
        public IRPSCheckbox<TrialBalanceQueryView> chkIncludeLastYearBalance { get; set; } 
        public IRPSCheckbox<TrialBalanceQueryView> chkExcludeClosingEntry { get; set; } 
        public IRPSCheckbox<TrialBalanceQueryView> bTC { get; set; } 
        public IRPSCheckbox<TrialBalanceQueryView> bGroup1 { get; set; } 
        public IRPSCheckbox<TrialBalanceQueryView> bGroup2 { get; set; } 
        public IRPSCheckbox<TrialBalanceQueryView> bGroup3 { get; set; } 
        public IRPSCheckbox<TrialBalanceQueryView> bGroup4 { get; set; } 
        public IRPSCheckbox<TrialBalanceQueryView> bGroup5 { get; set; } 
        public IRPSCheckbox<TrialBalanceQueryView> bGroup6 { get; set; } 
        public IRPSCheckbox<TrialBalanceQueryView> bGroup7 { get; set; } 
        public IRPSCheckbox<TrialBalanceQueryView> bDetailed { get; set; } 
        public IRPSCheckbox<TrialBalanceQueryView> bPosting { get; set; } 
        public IRPSButton<TrialBalanceQueryView> ReportCommandButton { get; set; } 
        public TrialBalance Screen { get; set; }
        public TrialBalanceQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}