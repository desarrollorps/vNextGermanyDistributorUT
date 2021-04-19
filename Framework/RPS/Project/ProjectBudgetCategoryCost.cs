    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.ProjectBudgetCategoryCost
{
    //RPS VERSION 1.0.0.0
    public partial class ProjectBudgetCategoryCost:Screen
    {
        public ProjectBudgetCategoryCost():base()
        {
            this.URL = "project.projectbudgetcategorycost";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ProjectBudgetCategoryCostQueryView  = new ProjectBudgetCategoryCostQueryView(this); 
            ProjectBudgetCategoryCostQueryView.InitializeControls(); 
           
        }
      
            public ProjectBudgetCategoryCostQueryView ProjectBudgetCategoryCostQueryView {get; set; } 
    }
            
    public partial class ProjectBudgetCategoryCostQueryView : View
    {
        public ProjectBudgetCategoryCostQueryView(ProjectBudgetCategoryCost screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<ProjectBudgetCategoryCostQueryView>("ae8437cf-0181-4130-9ebb-e439e9dc0823","","",false, this);
 
            Project = RPSControlFactory.CreateRPSCollectionComboBox<ProjectBudgetCategoryCostQueryView>("077b999b-274e-4136-88cd-05b8ccc87bcb","","",false, this);
 
            Situation = RPSControlFactory.CreateRPSCollectionComboBox<ProjectBudgetCategoryCostQueryView>("7f2d81b2-6005-4936-8fae-6acf2748b33e","","",false, this);
 
            UIGetIncludeChild = RPSControlFactory.CreateRPSCheckBox<ProjectBudgetCategoryCostQueryView>("1683e5d2-c632-49ca-9aaa-779e25a1da1c","","",false, this);
 
            OffertedVersion = RPSControlFactory.CreateRPSCheckBox<ProjectBudgetCategoryCostQueryView>("dcf1d0f4-7902-4e87-8401-8c0775e312fc","","",false, this);
 
            ProjectVersions = RPSControlFactory.CreateRPSComboBox<ProjectBudgetCategoryCostQueryView>("7a88519c-d877-4b19-ab55-1ef2d4658a71","","",false, this);
 
            BreakDownManufacturingCosts = RPSControlFactory.CreateRPSCheckBox<ProjectBudgetCategoryCostQueryView>("2beb7d2a-92d2-4a6b-8713-715a789b394d","","",false, this);
 

        }
        public IRPSComboBox<ProjectBudgetCategoryCostQueryView> Site { get; set; } 
        public IRPSCollectionComboBox<ProjectBudgetCategoryCostQueryView> Project { get; set; } 
        public IRPSCollectionComboBox<ProjectBudgetCategoryCostQueryView> Situation { get; set; } 
        public IRPSCheckbox<ProjectBudgetCategoryCostQueryView> UIGetIncludeChild { get; set; } 
        public IRPSCheckbox<ProjectBudgetCategoryCostQueryView> OffertedVersion { get; set; } 
        public IRPSComboBox<ProjectBudgetCategoryCostQueryView> ProjectVersions { get; set; } 
        public IRPSCheckbox<ProjectBudgetCategoryCostQueryView> BreakDownManufacturingCosts { get; set; } 
        public ProjectBudgetCategoryCost Screen { get; set; }
        public ProjectBudgetCategoryCostQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}