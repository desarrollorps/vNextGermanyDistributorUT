    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.ProjectComparativeBudget
{
    //RPS VERSION 1.0.0.0
    public partial class ProjectComparativeBudget:Screen
    {
        public ProjectComparativeBudget():base()
        {
            this.URL = "project.projectcomparativebudget";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ProjectComparativeBudgetQueryView  = new ProjectComparativeBudgetQueryView(this); 
            ProjectComparativeBudgetQueryView.InitializeControls(); 
           
        }
      
            public ProjectComparativeBudgetQueryView ProjectComparativeBudgetQueryView {get; set; } 
    }
            
    public partial class ProjectComparativeBudgetQueryView : View
    {
        public ProjectComparativeBudgetQueryView(ProjectComparativeBudget screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDProject = RPSControlFactory.CreateRPSComboBox<ProjectComparativeBudgetQueryView>("fd5abc56-74e6-453b-aeac-335503959d44","","",false, this);
 
            ShowTopLevelTasks = RPSControlFactory.CreateRPSCheckBox<ProjectComparativeBudgetQueryView>("6befbf8b-02fc-4d24-b8e3-09700ee81aec","","",false, this);
 
            ShowEmptyColumns = RPSControlFactory.CreateRPSCheckBox<ProjectComparativeBudgetQueryView>("461aa93e-8931-4796-b17c-69822592aef5","","",false, this);
 
            ShowCategoryHigherLevels = RPSControlFactory.CreateRPSCheckBox<ProjectComparativeBudgetQueryView>("3d36d34c-265f-4413-98d9-cecd6fa61749","","",false, this);
 
            ShowResume = RPSControlFactory.CreateRPSCheckBox<ProjectComparativeBudgetQueryView>("79595da5-bdd8-4b35-bcd9-0c18cf67749c","","",false, this);
 
            RealCost = RPSControlFactory.CreateRPSOption<ProjectComparativeBudgetQueryView>( "45abbb22-dfd3-40d2-97dc-7f56b1474674","","",this);
 
            RealCostExpected = RPSControlFactory.CreateRPSOption<ProjectComparativeBudgetQueryView>( "6e04c740-e7e1-4883-8bbd-0b85fb52e691","","",this);
 
            RealCostMO = RPSControlFactory.CreateRPSOption<ProjectComparativeBudgetQueryView>( "e1495faa-408e-4548-9d21-468429245643","","",this);
 
            RealVSTheoric = RPSControlFactory.CreateRPSOption<ProjectComparativeBudgetQueryView>( "ae459401-d987-4d27-a2b3-96043a0d08d6","","",this);
 
            RealVSBudget = RPSControlFactory.CreateRPSOption<ProjectComparativeBudgetQueryView>( "3f4ab079-3c81-47f3-b40b-e9aa69f9fed9","","",this);
 
            Amount = RPSControlFactory.CreateRPSOption<ProjectComparativeBudgetQueryView>( "572a659b-f4d3-4668-8bcf-6bfa180dc3c1","","",this);
 
            Difference = RPSControlFactory.CreateRPSOption<ProjectComparativeBudgetQueryView>( "42e4f2d0-2aa8-4a38-b5c2-5a43f6aa6cf9","","",this);
 
            Percent = RPSControlFactory.CreateRPSOption<ProjectComparativeBudgetQueryView>( "06315588-9ce7-4f35-a2d2-e22bd104e758","","",this);
 
            TotalSalesPrice = RPSControlFactory.CreateRPSFormattedTextBox<ProjectComparativeBudgetQueryView>("d75ba71d-8e1d-475a-b9e2-6769fa5ca408","","",false, this);
 
            TotalBudget = RPSControlFactory.CreateRPSFormattedTextBox<ProjectComparativeBudgetQueryView>("5e7eff96-3805-4c26-b5ab-b87be2f50d5d","","",false, this);
 
            MarginBudget = RPSControlFactory.CreateRPSFormattedTextBox<ProjectComparativeBudgetQueryView>("00fbbb3a-1cdd-4e0b-bae2-b71edea3f2c6","","",false, this);
 
            PercentMarginBudget = RPSControlFactory.CreateRPSFormattedTextBox<ProjectComparativeBudgetQueryView>("d6faa463-e3a6-4533-9980-ecc9cbb39bb3","","",false, this);
 
            TotalRealCost = RPSControlFactory.CreateRPSFormattedTextBox<ProjectComparativeBudgetQueryView>("7c622754-0d89-4ebd-a14a-7f063a26092f","","",false, this);
 
            MarginCostReal = RPSControlFactory.CreateRPSFormattedTextBox<ProjectComparativeBudgetQueryView>("26e25d68-d8c0-47cb-8746-ff2ae97e6da3","","",false, this);
 
            PercentMarginCostReal = RPSControlFactory.CreateRPSFormattedTextBox<ProjectComparativeBudgetQueryView>("7a665880-225f-424f-95e4-a1d87444cca9","","",false, this);
 
            TotalRealCostExpected = RPSControlFactory.CreateRPSFormattedTextBox<ProjectComparativeBudgetQueryView>("fdd7df30-d2f4-41e5-91e2-fc8ff34a8e36","","",false, this);
 
            MarginCostExpected = RPSControlFactory.CreateRPSFormattedTextBox<ProjectComparativeBudgetQueryView>("2d4c6f34-e34e-48b2-9112-8262469aa698","","",false, this);
 
            PercentMarginCostRealExpected = RPSControlFactory.CreateRPSFormattedTextBox<ProjectComparativeBudgetQueryView>("ba1fd3a6-ab20-4951-8641-73e533e867f5","","",false, this);
 
            TotalInvoicePrice = RPSControlFactory.CreateRPSFormattedTextBox<ProjectComparativeBudgetQueryView>("57098663-1bee-4909-a013-fbbba6a6ef75","","",false, this);
 
            TotalRealCost1 = RPSControlFactory.CreateRPSFormattedTextBox<ProjectComparativeBudgetQueryView>("9180edd8-eee8-4912-aeae-ba5a45ca5476","","",false, this);
 
            MarginRealInvoiced = RPSControlFactory.CreateRPSFormattedTextBox<ProjectComparativeBudgetQueryView>("ff752251-264c-4999-9a18-e2dd3f75aac0","","",false, this);
 
            PercentMarginRealInvoiced = RPSControlFactory.CreateRPSFormattedTextBox<ProjectComparativeBudgetQueryView>("77410177-cd0b-4915-87d5-aa98a342d362","","",false, this);
 
            Details = RPSControlFactory.CreateRPSSection<ProjectComparativeBudgetQueryView>( "","ul li[rpsid='1fe3e4a1-b4d6-4bf8-a615-a7bda34579f9']","",this);
 
            Resume = RPSControlFactory.CreateRPSSection<ProjectComparativeBudgetQueryView>( "","ul li[rpsid='a71b1e36-860d-468d-b524-d9cc8f359444']","",this);
 

        }
        public IRPSComboBox<ProjectComparativeBudgetQueryView> IDProject { get; set; } 
        public IRPSCheckbox<ProjectComparativeBudgetQueryView> ShowTopLevelTasks { get; set; } 
        public IRPSCheckbox<ProjectComparativeBudgetQueryView> ShowEmptyColumns { get; set; } 
        public IRPSCheckbox<ProjectComparativeBudgetQueryView> ShowCategoryHigherLevels { get; set; } 
        public IRPSCheckbox<ProjectComparativeBudgetQueryView> ShowResume { get; set; } 
        public IRPSOption<ProjectComparativeBudgetQueryView> RealCost { get; set; } 
        public IRPSOption<ProjectComparativeBudgetQueryView> RealCostExpected { get; set; } 
        public IRPSOption<ProjectComparativeBudgetQueryView> RealCostMO { get; set; } 
        public IRPSOption<ProjectComparativeBudgetQueryView> RealVSTheoric { get; set; } 
        public IRPSOption<ProjectComparativeBudgetQueryView> RealVSBudget { get; set; } 
        public IRPSOption<ProjectComparativeBudgetQueryView> Amount { get; set; } 
        public IRPSOption<ProjectComparativeBudgetQueryView> Difference { get; set; } 
        public IRPSOption<ProjectComparativeBudgetQueryView> Percent { get; set; } 
        public IRPSTextBox<ProjectComparativeBudgetQueryView> TotalSalesPrice { get; set; } 
        public IRPSTextBox<ProjectComparativeBudgetQueryView> TotalBudget { get; set; } 
        public IRPSTextBox<ProjectComparativeBudgetQueryView> MarginBudget { get; set; } 
        public IRPSTextBox<ProjectComparativeBudgetQueryView> PercentMarginBudget { get; set; } 
        public IRPSTextBox<ProjectComparativeBudgetQueryView> TotalRealCost { get; set; } 
        public IRPSTextBox<ProjectComparativeBudgetQueryView> MarginCostReal { get; set; } 
        public IRPSTextBox<ProjectComparativeBudgetQueryView> PercentMarginCostReal { get; set; } 
        public IRPSTextBox<ProjectComparativeBudgetQueryView> TotalRealCostExpected { get; set; } 
        public IRPSTextBox<ProjectComparativeBudgetQueryView> MarginCostExpected { get; set; } 
        public IRPSTextBox<ProjectComparativeBudgetQueryView> PercentMarginCostRealExpected { get; set; } 
        public IRPSTextBox<ProjectComparativeBudgetQueryView> TotalInvoicePrice { get; set; } 
        public IRPSTextBox<ProjectComparativeBudgetQueryView> TotalRealCost1 { get; set; } 
        public IRPSTextBox<ProjectComparativeBudgetQueryView> MarginRealInvoiced { get; set; } 
        public IRPSTextBox<ProjectComparativeBudgetQueryView> PercentMarginRealInvoiced { get; set; } 
        public IRPSSection<ProjectComparativeBudgetQueryView> Details { get; set; } 
        public IRPSSection<ProjectComparativeBudgetQueryView> Resume { get; set; } 
        public ProjectComparativeBudget Screen { get; set; }
        public ProjectComparativeBudgetQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}