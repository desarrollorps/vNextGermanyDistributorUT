    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.BudgetControl
{
    //RPS VERSION 1.0.0.0
    public partial class BudgetControl:Screen
    {
        public BudgetControl():base()
        {
            this.URL = "generalledger.budgetcontrol";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            BudgetControlQueryView  = new BudgetControlQueryView(this); 
            BudgetControlQueryView.InitializeControls(); 
           
        }
      
            public BudgetControlQueryView BudgetControlQueryView {get; set; } 
    }
            
    public partial class BudgetControlQueryView : View
    {
        public BudgetControlQueryView(BudgetControl screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDBudget = RPSControlFactory.CreateRPSComboBox<BudgetControlQueryView>("ab871439-20ca-4e46-a668-731c9a97d28d","","",false, this);
 
            WithPeriodDetail = RPSControlFactory.CreateRPSCheckBox<BudgetControlQueryView>("c136884f-e3c7-4625-8ed0-6b6c24ef6c7c","","",false, this);
 
            IDACCYear = RPSControlFactory.CreateRPSComboBox<BudgetControlQueryView>("82872075-1bfc-4463-af1b-5084af7fdabd","","",false, this);
 
            IDACCPeriodFrom = RPSControlFactory.CreateRPSComboBox<BudgetControlQueryView>("d538725c-9c30-432c-a55e-39fbf68fe09e","","",false, this);
 
            IDACCPeriodTo = RPSControlFactory.CreateRPSComboBox<BudgetControlQueryView>("e4dccfec-cfc1-42ba-87d8-64c1a22792eb","","",false, this);
 
            IDAccountList = RPSControlFactory.CreateRPSCollectionComboBox<BudgetControlQueryView>("57884093-9579-46dc-941e-913acab439c2","","",false, this);
 
            IDAccountGroupList = RPSControlFactory.CreateRPSCollectionComboBox<BudgetControlQueryView>("c1edbd7e-6a51-47e5-88d7-cd19ef49a90c","","",false, this);
 
            IDAccountClusterList = RPSControlFactory.CreateRPSCollectionComboBox<BudgetControlQueryView>("e22137cc-ef48-4374-86a6-85308a61c91a","","",false, this);
 
            DeviationPercentage = RPSControlFactory.CreateRPSFormattedTextBox<BudgetControlQueryView>("d0979367-7919-46a6-ab6e-cbd2af048ed0","","",false, this);
 
            ExecutedPercentage = RPSControlFactory.CreateRPSFormattedTextBox<BudgetControlQueryView>("3a4cc945-c15c-4704-82d7-0b4cf8194b8a","","",false, this);
 

        }
        public IRPSComboBox<BudgetControlQueryView> IDBudget { get; set; } 
        public IRPSCheckbox<BudgetControlQueryView> WithPeriodDetail { get; set; } 
        public IRPSComboBox<BudgetControlQueryView> IDACCYear { get; set; } 
        public IRPSComboBox<BudgetControlQueryView> IDACCPeriodFrom { get; set; } 
        public IRPSComboBox<BudgetControlQueryView> IDACCPeriodTo { get; set; } 
        public IRPSCollectionComboBox<BudgetControlQueryView> IDAccountList { get; set; } 
        public IRPSCollectionComboBox<BudgetControlQueryView> IDAccountGroupList { get; set; } 
        public IRPSCollectionComboBox<BudgetControlQueryView> IDAccountClusterList { get; set; } 
        public IRPSTextBox<BudgetControlQueryView> DeviationPercentage { get; set; } 
        public IRPSTextBox<BudgetControlQueryView> ExecutedPercentage { get; set; } 
        public BudgetControl Screen { get; set; }
        public BudgetControlQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}