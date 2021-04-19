    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.AnalyticBalance
{
    //RPS VERSION 1.0.0.0
    public partial class AnalyticBalance:Screen
    {
        public AnalyticBalance():base()
        {
            this.URL = "generalledger.analyticbalance";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            AnalyticBalanceQueryView  = new AnalyticBalanceQueryView(this); 
            AnalyticBalanceQueryView.InitializeControls(); 
           
        }
      
            public AnalyticBalanceQueryView AnalyticBalanceQueryView {get; set; } 
    }
            
    public partial class AnalyticBalanceQueryView : View
    {
        public AnalyticBalanceQueryView(AnalyticBalance screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDDimension = RPSControlFactory.CreateRPSComboBox<AnalyticBalanceQueryView>("6b02ada3-a41a-427a-986f-060383e6d03f","","",false, this);
 
            IDDimValues = RPSControlFactory.CreateRPSCollectionComboBox<AnalyticBalanceQueryView>("3eeb078b-667b-4b59-9fed-e2f210918f46","","",false, this);
 
            optValueDateTo = RPSControlFactory.CreateRPSOption<AnalyticBalanceQueryView>( "cd52b188-a41f-4ed8-9c74-d8826dddfbde","","",this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<AnalyticBalanceQueryView>("7e80aec8-11ce-432d-a6f1-00ef2936cb68","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<AnalyticBalanceQueryView>("b397de3a-6f2b-4192-bac0-1bc975f1ea2b","","",false, this);
 
            optValuePeriods = RPSControlFactory.CreateRPSOption<AnalyticBalanceQueryView>( "5fd3a935-dc53-4528-ad6a-0ddce8a7b215","","",this);
 
            IDACCYearPeriod = RPSControlFactory.CreateRPSComboBox<AnalyticBalanceQueryView>("9727421d-4099-4457-b4f6-d4c13ecb2dc2","","",false, this);
 
            IDACCPeriodFrom = RPSControlFactory.CreateRPSComboBox<AnalyticBalanceQueryView>("11fd41e0-ada4-4540-9f93-8686a9bbcd88","","",false, this);
 
            IDACCPeriodTo = RPSControlFactory.CreateRPSComboBox<AnalyticBalanceQueryView>("00836140-a24e-4435-becb-8ab1748fbb0e","","",false, this);
 
            IDAccountList = RPSControlFactory.CreateRPSCollectionComboBox<AnalyticBalanceQueryView>("5843d19f-d540-424d-ae83-781e1b0b4d73","","",false, this);
 
            IDAccountGroupList = RPSControlFactory.CreateRPSCollectionComboBox<AnalyticBalanceQueryView>("321a105d-8f8f-41c7-bd87-430728c4066b","","",false, this);
 
            IDAccountClusterList = RPSControlFactory.CreateRPSCollectionComboBox<AnalyticBalanceQueryView>("502594c3-8ccf-4590-a4ab-54d07c76a53c","","",false, this);
 
            chkIncludeLastYearBalance = RPSControlFactory.CreateRPSCheckBox<AnalyticBalanceQueryView>("04e5f8ac-c8d8-41fe-b92c-cd580000addd","","",false, this);
 
            IDACCYear = RPSControlFactory.CreateRPSComboBox<AnalyticBalanceQueryView>("1ea1d057-6032-4218-add1-dac667edb8a7","","",false, this);
 
            chkExcludeClosingEntry = RPSControlFactory.CreateRPSCheckBox<AnalyticBalanceQueryView>("7dcfcad2-74e1-4460-a5b1-707c7807f979","","",false, this);
 
            bTC = RPSControlFactory.CreateRPSCheckBox<AnalyticBalanceQueryView>("a123c69b-7591-4fe0-9876-e9c881acab24","","",false, this);
 
            WithAccountDetail = RPSControlFactory.CreateRPSCheckBox<AnalyticBalanceQueryView>("d4cfcc1c-ba9b-42bf-b608-67313c950ad2","","",false, this);
 

        }
        public IRPSComboBox<AnalyticBalanceQueryView> IDDimension { get; set; } 
        public IRPSCollectionComboBox<AnalyticBalanceQueryView> IDDimValues { get; set; } 
        public IRPSOption<AnalyticBalanceQueryView> optValueDateTo { get; set; } 
        public IRPSTextBox<AnalyticBalanceQueryView> DateFrom { get; set; } 
        public IRPSTextBox<AnalyticBalanceQueryView> DateTo { get; set; } 
        public IRPSOption<AnalyticBalanceQueryView> optValuePeriods { get; set; } 
        public IRPSComboBox<AnalyticBalanceQueryView> IDACCYearPeriod { get; set; } 
        public IRPSComboBox<AnalyticBalanceQueryView> IDACCPeriodFrom { get; set; } 
        public IRPSComboBox<AnalyticBalanceQueryView> IDACCPeriodTo { get; set; } 
        public IRPSCollectionComboBox<AnalyticBalanceQueryView> IDAccountList { get; set; } 
        public IRPSCollectionComboBox<AnalyticBalanceQueryView> IDAccountGroupList { get; set; } 
        public IRPSCollectionComboBox<AnalyticBalanceQueryView> IDAccountClusterList { get; set; } 
        public IRPSCheckbox<AnalyticBalanceQueryView> chkIncludeLastYearBalance { get; set; } 
        public IRPSComboBox<AnalyticBalanceQueryView> IDACCYear { get; set; } 
        public IRPSCheckbox<AnalyticBalanceQueryView> chkExcludeClosingEntry { get; set; } 
        public IRPSCheckbox<AnalyticBalanceQueryView> bTC { get; set; } 
        public IRPSCheckbox<AnalyticBalanceQueryView> WithAccountDetail { get; set; } 
        public AnalyticBalance Screen { get; set; }
        public AnalyticBalanceQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}