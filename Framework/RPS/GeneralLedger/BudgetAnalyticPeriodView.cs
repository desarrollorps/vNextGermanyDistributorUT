    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.BudgetAnalyticPeriodView
{
    //RPS VERSION 1.0.0.0
    public partial class BudgetAnalyticPeriodView:Screen
    {
        public BudgetAnalyticPeriodView():base()
        {
            this.URL = "generalledger.budgetanalyticperiodview";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            BudgetAnalyticPeriodViewView  = new BudgetAnalyticPeriodViewView(this); 
            InsertAnalyticChildDialogView  = new InsertAnalyticChildDialogView(this); 
            BudgetAnalyticPeriodViewView.InitializeControls(); 
            InsertAnalyticChildDialogView.InitializeControls(); 
           
        }
      
            public BudgetAnalyticPeriodViewView BudgetAnalyticPeriodViewView {get; set; } 
            public InsertAnalyticChildDialogView InsertAnalyticChildDialogView {get; set; } 
    }
            
    public partial class BudgetAnalyticPeriodViewView : View
    {
        public BudgetAnalyticPeriodViewView(BudgetAnalyticPeriodView screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDBudget = RPSControlFactory.CreateRPSComboBox<BudgetAnalyticPeriodViewView>("c8e017c8-5e91-4c12-aaa0-68d09b4d8e56","","",true, this);
 
            IDDimension = RPSControlFactory.CreateRPSComboBox<BudgetAnalyticPeriodViewView>("6b02ada3-a41a-427a-986f-060383e6d03f","","",true, this);
 
            IDDimValues = RPSControlFactory.CreateRPSCollectionComboBox<BudgetAnalyticPeriodViewView>("3eeb078b-667b-4b59-9fed-e2f210918f46","","",false, this);
 
            IDAccountList = RPSControlFactory.CreateRPSCollectionComboBox<BudgetAnalyticPeriodViewView>("e2f65385-3090-42a1-a8d4-9428b894db03","","",false, this);
 
            IDAccountGroupList = RPSControlFactory.CreateRPSCollectionComboBox<BudgetAnalyticPeriodViewView>("22a47929-bd02-46fd-9b2c-c55c3c34b3c8","","",false, this);
 
            IDAccountClusterList = RPSControlFactory.CreateRPSCollectionComboBox<BudgetAnalyticPeriodViewView>("45661815-94c8-429b-8609-4ec93160a64a","","",false, this);
 
            ConsultCommand = RPSControlFactory.CreateRPSButton<BudgetAnalyticPeriodViewView>( "777248cc-aaf3-4921-b599-b71ffc8c387a","","",this);
 
            InsertAnalyticChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<BudgetAnalyticPeriodViewView,InsertAnalyticChildDialogView>("bdb9b75b-4a5b-437c-983b-a669c601da18","","", this,Screen.InsertAnalyticChildDialogView);
 
            DeleteCommandButton = RPSControlFactory.CreateRPSButton<BudgetAnalyticPeriodViewView>( "b67d8794-a93b-4f95-b86e-49f5d2ed173b","","",this);
 

        }
        public IRPSComboBox<BudgetAnalyticPeriodViewView> IDBudget { get; set; } 
        public IRPSComboBox<BudgetAnalyticPeriodViewView> IDDimension { get; set; } 
        public IRPSCollectionComboBox<BudgetAnalyticPeriodViewView> IDDimValues { get; set; } 
        public IRPSCollectionComboBox<BudgetAnalyticPeriodViewView> IDAccountList { get; set; } 
        public IRPSCollectionComboBox<BudgetAnalyticPeriodViewView> IDAccountGroupList { get; set; } 
        public IRPSCollectionComboBox<BudgetAnalyticPeriodViewView> IDAccountClusterList { get; set; } 
        public IRPSButton<BudgetAnalyticPeriodViewView> ConsultCommand { get; set; } 
        public IRPSButton<BudgetAnalyticPeriodViewView,InsertAnalyticChildDialogView> InsertAnalyticChildNavigationCommandButton { get; set; } 
        public IRPSButton<BudgetAnalyticPeriodViewView> DeleteCommandButton { get; set; } 
        public BudgetAnalyticPeriodView Screen { get; set; }
        public BudgetAnalyticPeriodViewView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class InsertAnalyticChildDialogView : View
    {
        public InsertAnalyticChildDialogView(BudgetAnalyticPeriodView screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDBudget = RPSControlFactory.CreateRPSComboBox<InsertAnalyticChildDialogView>("4028c7ad-ea48-45bc-b314-0e8956e2fc1c","","",true, this);
 
            IDDimension = RPSControlFactory.CreateRPSComboBox<InsertAnalyticChildDialogView>("086e6be5-b566-4190-aa3f-699b391e0532","","",true, this);
 
            RewriteGeneration = RPSControlFactory.CreateRPSCheckBox<InsertAnalyticChildDialogView>("82c5feaf-2f86-4537-864e-90828e13b334","","",false, this);
 
            IDAccountList = RPSControlFactory.CreateRPSCollectionComboBox<InsertAnalyticChildDialogView>("6fe3b2f7-d4b1-4923-b299-7a95f0e784f5","","",false, this);
 
            IDAccountGroupList = RPSControlFactory.CreateRPSCollectionComboBox<InsertAnalyticChildDialogView>("e8488a7b-4dd5-4e9a-a5ef-1cb76167fd7b","","",false, this);
 
            IDAccountClusterList = RPSControlFactory.CreateRPSCollectionComboBox<InsertAnalyticChildDialogView>("4adc129b-9b2b-443c-af0f-cd86b63a98de","","",false, this);
 

        }
        public IRPSComboBox<InsertAnalyticChildDialogView> IDBudget { get; set; } 
        public IRPSComboBox<InsertAnalyticChildDialogView> IDDimension { get; set; } 
        public IRPSCheckbox<InsertAnalyticChildDialogView> RewriteGeneration { get; set; } 
        public IRPSCollectionComboBox<InsertAnalyticChildDialogView> IDAccountList { get; set; } 
        public IRPSCollectionComboBox<InsertAnalyticChildDialogView> IDAccountGroupList { get; set; } 
        public IRPSCollectionComboBox<InsertAnalyticChildDialogView> IDAccountClusterList { get; set; } 
        public BudgetAnalyticPeriodView Screen { get; set; }
        public InsertAnalyticChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}