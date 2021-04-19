    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.BudgetAnalyticControl
{
    //RPS VERSION 1.0.0.0
    public partial class BudgetAnalyticControl:Screen
    {
        public BudgetAnalyticControl():base()
        {
            this.URL = "generalledger.budgetanalyticcontrol";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            BudgetAnalyticControlQueryView  = new BudgetAnalyticControlQueryView(this); 
            BudgetAnalyticControlQueryView.InitializeControls(); 
           
        }
      
            public BudgetAnalyticControlQueryView BudgetAnalyticControlQueryView {get; set; } 
    }
            
    public partial class BudgetAnalyticControlQueryView : View
    {
        public BudgetAnalyticControlQueryView(BudgetAnalyticControl screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDBudget = RPSControlFactory.CreateRPSComboBox<BudgetAnalyticControlQueryView>("c8e017c8-5e91-4c12-aaa0-68d09b4d8e56","","",false, this);
 
            IDDimension = RPSControlFactory.CreateRPSComboBox<BudgetAnalyticControlQueryView>("6b02ada3-a41a-427a-986f-060383e6d03f","","",false, this);
 
            IDDimValues = RPSControlFactory.CreateRPSCollectionComboBox<BudgetAnalyticControlQueryView>("3eeb078b-667b-4b59-9fed-e2f210918f46","","",false, this);
 
            IDACCYear = RPSControlFactory.CreateRPSComboBox<BudgetAnalyticControlQueryView>("3135b5e1-7fdf-4a9f-95fb-6ac30d1f79ce","","",false, this);
 
            IDACCPeriodFrom = RPSControlFactory.CreateRPSComboBox<BudgetAnalyticControlQueryView>("929aeab0-57af-4140-b64b-c79f17da4aa9","","",false, this);
 
            IDACCPeriodTo = RPSControlFactory.CreateRPSComboBox<BudgetAnalyticControlQueryView>("0612dd62-98f8-4656-8bf7-13a36f5e3663","","",false, this);
 
            IDAccountList = RPSControlFactory.CreateRPSCollectionComboBox<BudgetAnalyticControlQueryView>("e2f65385-3090-42a1-a8d4-9428b894db03","","",false, this);
 
            IDAccountGroupList = RPSControlFactory.CreateRPSCollectionComboBox<BudgetAnalyticControlQueryView>("22a47929-bd02-46fd-9b2c-c55c3c34b3c8","","",false, this);
 
            IDAccountClusterList = RPSControlFactory.CreateRPSCollectionComboBox<BudgetAnalyticControlQueryView>("45661815-94c8-429b-8609-4ec93160a64a","","",false, this);
 
            WithAccountDetail = RPSControlFactory.CreateRPSCheckBox<BudgetAnalyticControlQueryView>("d4cfcc1c-ba9b-42bf-b608-67313c950ad2","","",false, this);
 
            WithPeriodDetail = RPSControlFactory.CreateRPSCheckBox<BudgetAnalyticControlQueryView>("f4341899-aa4c-4a8e-ba7f-5c78cb415fa0","","",false, this);
 
            DeviationPercentage = RPSControlFactory.CreateRPSFormattedTextBox<BudgetAnalyticControlQueryView>("e0e2ea49-96e2-412d-a556-f13282def90d","","",false, this);
 
            ExecutedPercentage = RPSControlFactory.CreateRPSFormattedTextBox<BudgetAnalyticControlQueryView>("3d4f894e-e47e-4626-97e6-b9484b1d738a","","",false, this);
 

        }
        public IRPSComboBox<BudgetAnalyticControlQueryView> IDBudget { get; set; } 
        public IRPSComboBox<BudgetAnalyticControlQueryView> IDDimension { get; set; } 
        public IRPSCollectionComboBox<BudgetAnalyticControlQueryView> IDDimValues { get; set; } 
        public IRPSComboBox<BudgetAnalyticControlQueryView> IDACCYear { get; set; } 
        public IRPSComboBox<BudgetAnalyticControlQueryView> IDACCPeriodFrom { get; set; } 
        public IRPSComboBox<BudgetAnalyticControlQueryView> IDACCPeriodTo { get; set; } 
        public IRPSCollectionComboBox<BudgetAnalyticControlQueryView> IDAccountList { get; set; } 
        public IRPSCollectionComboBox<BudgetAnalyticControlQueryView> IDAccountGroupList { get; set; } 
        public IRPSCollectionComboBox<BudgetAnalyticControlQueryView> IDAccountClusterList { get; set; } 
        public IRPSCheckbox<BudgetAnalyticControlQueryView> WithAccountDetail { get; set; } 
        public IRPSCheckbox<BudgetAnalyticControlQueryView> WithPeriodDetail { get; set; } 
        public IRPSTextBox<BudgetAnalyticControlQueryView> DeviationPercentage { get; set; } 
        public IRPSTextBox<BudgetAnalyticControlQueryView> ExecutedPercentage { get; set; } 
        public BudgetAnalyticControl Screen { get; set; }
        public BudgetAnalyticControlQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}