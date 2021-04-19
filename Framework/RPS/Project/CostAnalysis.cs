    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.CostAnalysis
{
    //RPS VERSION 1.0.0.0
    public partial class CostAnalysis:Screen
    {
        public CostAnalysis():base()
        {
            this.URL = "project.costanalysis";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CostAnalysisQueryView  = new CostAnalysisQueryView(this); 
            CostAnalysisQueryView.InitializeControls(); 
           
        }
      
            public CostAnalysisQueryView CostAnalysisQueryView {get; set; } 
    }
            
    public partial class CostAnalysisQueryView : View
    {
        public CostAnalysisQueryView(CostAnalysis screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<CostAnalysisQueryView>("301217e4-b8b4-4c79-a7d2-8551b2945f3a","","",false, this);
 
            Project = RPSControlFactory.CreateRPSCollectionComboBox<CostAnalysisQueryView>("e3743fc0-a5a3-4fdd-9396-62789e8e418f","","",false, this);
 
            UI_Situation = RPSControlFactory.CreateRPSCollectionComboBox<CostAnalysisQueryView>("8f98e908-7469-4ddb-9acf-ff352f95217c","","",false, this);
 
            ProjectType = RPSControlFactory.CreateRPSComboBox<CostAnalysisQueryView>("15dc0fd2-51d9-49ac-96a9-7881492c882c","","",false, this);
 
            GetManufacturingCosts = RPSControlFactory.CreateRPSCheckBox<CostAnalysisQueryView>("b5d48b68-38c9-4456-b601-1ba5a0cc4714","","",false, this);
 
            UIGetIncludeChild = RPSControlFactory.CreateRPSCheckBox<CostAnalysisQueryView>("fa1632d4-f7f6-4c74-b014-3377c23ad03b","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<CostAnalysisQueryView>("d1e99eb8-2592-4f65-a773-17663e61adf5","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<CostAnalysisQueryView>("8a4ec14a-b764-4d15-9854-6192404d0792","","",false, this);
 
            Canceled = RPSControlFactory.CreateRPSCheckBox<CostAnalysisQueryView>("4c2d0184-5bfb-4b73-a728-fee79c436c83","","",false, this);
 
            Group = RPSControlFactory.CreateRPSTextBox<CostAnalysisQueryView>("51b5ff12-f288-4c91-88b6-680a54d5e99b","","",false, this);
 
            Type1 = RPSControlFactory.CreateRPSTextBox<CostAnalysisQueryView>("99907b6e-a995-4998-b704-38da26d9eb30","","",false, this);
 
            Canceled1 = RPSControlFactory.CreateRPSCheckBox<CostAnalysisQueryView>("0a390444-f222-44e6-8312-4b940e246b79","","",false, this);
 

        }
        public IRPSComboBox<CostAnalysisQueryView> Site { get; set; } 
        public IRPSCollectionComboBox<CostAnalysisQueryView> Project { get; set; } 
        public IRPSCollectionComboBox<CostAnalysisQueryView> UI_Situation { get; set; } 
        public IRPSComboBox<CostAnalysisQueryView> ProjectType { get; set; } 
        public IRPSCheckbox<CostAnalysisQueryView> GetManufacturingCosts { get; set; } 
        public IRPSCheckbox<CostAnalysisQueryView> UIGetIncludeChild { get; set; } 
        public IRPSTextBox<CostAnalysisQueryView> DateFrom { get; set; } 
        public IRPSTextBox<CostAnalysisQueryView> DateTo { get; set; } 
        public IRPSCheckbox<CostAnalysisQueryView> Canceled { get; set; } 
        public IRPSTextBox<CostAnalysisQueryView> Group { get; set; } 
        public IRPSTextBox<CostAnalysisQueryView> Type1 { get; set; } 
        public IRPSCheckbox<CostAnalysisQueryView> Canceled1 { get; set; } 
        public CostAnalysis Screen { get; set; }
        public CostAnalysisQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}