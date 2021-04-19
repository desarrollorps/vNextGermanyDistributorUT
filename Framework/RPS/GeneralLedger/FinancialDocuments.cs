    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.FinancialDocuments
{
    //RPS VERSION 1.0.0.0
    public partial class FinancialDocuments:Screen
    {
        public FinancialDocuments():base()
        {
            this.URL = "generalledger.financialdocuments";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            FinancialDocumentsView  = new FinancialDocumentsView(this); 
            FinancialDocumentsView.InitializeControls(); 
           
        }
      
            public FinancialDocumentsView FinancialDocumentsView {get; set; } 
    }
            
    public partial class FinancialDocumentsView : View
    {
        public FinancialDocumentsView(FinancialDocuments screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDParamFinancialDoc = RPSControlFactory.CreateRPSComboBox<FinancialDocumentsView>("44f06e56-d64b-47f6-a596-9298e924a01e","","",true, this);
 
            IDBudget = RPSControlFactory.CreateRPSComboBox<FinancialDocumentsView>("744f4b12-82eb-428c-86d7-2b7d3e2806e3","","",false, this);
 
            IDDimension = RPSControlFactory.CreateRPSComboBox<FinancialDocumentsView>("3cc3dcc3-0a41-4cfb-bf87-d134ab6fd8c6","","",false, this);
 
            IDDimValue = RPSControlFactory.CreateRPSComboBox<FinancialDocumentsView>("92753398-225f-4d6a-8b3d-ad8ff024ce65","","",false, this);
 
            First = RPSControlFactory.CreateRPSOption<FinancialDocumentsView>( "d4b59b56-9149-4188-9092-67fd5f3340a8","","",this);
 
            Last = RPSControlFactory.CreateRPSOption<FinancialDocumentsView>( "fef849e3-87c4-4c50-848d-043132006adb","","",this);
 
            Selected = RPSControlFactory.CreateRPSOption<FinancialDocumentsView>( "ebbc9588-b603-4b82-a3eb-ba1f05c510a8","","",this);
 
            bIncludeLastYearsBalance = RPSControlFactory.CreateRPSCheckBox<FinancialDocumentsView>("1b95a61a-70f5-4204-b557-c716bc429217","","",false, this);
 
            bTC = RPSControlFactory.CreateRPSCheckBox<FinancialDocumentsView>("944625e1-65c0-4e2c-8f0d-5e42457000e6","","",false, this);
 
            optValueDateTo = RPSControlFactory.CreateRPSOption<FinancialDocumentsView>( "1b9adedd-2500-4de4-bcc7-b54ae17902de","","",this);
 
            optValuePeriods = RPSControlFactory.CreateRPSOption<FinancialDocumentsView>( "7f57b781-3924-4c22-a71f-db26bca9b739","","",this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<FinancialDocumentsView>("88ca1cfc-b0e1-47ed-b49c-f25acbe516c5","","",false, this);
 
            IDACCYear = RPSControlFactory.CreateRPSComboBox<FinancialDocumentsView>("6bfb12ec-220d-4c21-a9e7-b0ded034fb7d","","",false, this);
 
            IDACCPeriodFrom = RPSControlFactory.CreateRPSComboBox<FinancialDocumentsView>("9c381216-0237-424d-8198-f89603ee1f65","","",false, this);
 
            IDACCPeriodTo = RPSControlFactory.CreateRPSComboBox<FinancialDocumentsView>("793dfbaa-7d02-4e58-af14-0cb8a5552897","","",false, this);
 

        }
        public IRPSComboBox<FinancialDocumentsView> IDParamFinancialDoc { get; set; } 
        public IRPSComboBox<FinancialDocumentsView> IDBudget { get; set; } 
        public IRPSComboBox<FinancialDocumentsView> IDDimension { get; set; } 
        public IRPSComboBox<FinancialDocumentsView> IDDimValue { get; set; } 
        public IRPSOption<FinancialDocumentsView> First { get; set; } 
        public IRPSOption<FinancialDocumentsView> Last { get; set; } 
        public IRPSOption<FinancialDocumentsView> Selected { get; set; } 
        public IRPSCheckbox<FinancialDocumentsView> bIncludeLastYearsBalance { get; set; } 
        public IRPSCheckbox<FinancialDocumentsView> bTC { get; set; } 
        public IRPSOption<FinancialDocumentsView> optValueDateTo { get; set; } 
        public IRPSOption<FinancialDocumentsView> optValuePeriods { get; set; } 
        public IRPSTextBox<FinancialDocumentsView> DateTo { get; set; } 
        public IRPSComboBox<FinancialDocumentsView> IDACCYear { get; set; } 
        public IRPSComboBox<FinancialDocumentsView> IDACCPeriodFrom { get; set; } 
        public IRPSComboBox<FinancialDocumentsView> IDACCPeriodTo { get; set; } 
        public FinancialDocuments Screen { get; set; }
        public FinancialDocumentsView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}