    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.ProjectMargin
{
    //RPS VERSION 1.0.0.0
    public partial class ProjectMargin:Screen
    {
        public ProjectMargin():base()
        {
            this.URL = "project.projectmargin";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ProjectMarginQueryView  = new ProjectMarginQueryView(this); 
            ProjectMarginQueryView.InitializeControls(); 
           
        }
      
            public ProjectMarginQueryView ProjectMarginQueryView {get; set; } 
    }
            
    public partial class ProjectMarginQueryView : View
    {
        public ProjectMarginQueryView(ProjectMargin screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<ProjectMarginQueryView>("2e6ec12d-4ff4-474a-86e7-ea2093cc9868","","",false, this);
 
            Project = RPSControlFactory.CreateRPSCollectionComboBox<ProjectMarginQueryView>("0c495ad1-1796-48fe-a5f9-43817259529f","","",false, this);
 
            Situation = RPSControlFactory.CreateRPSCollectionComboBox<ProjectMarginQueryView>("84fb4967-5659-4923-9522-629fa22d00f9","","",false, this);
 
            ProjectType = RPSControlFactory.CreateRPSComboBox<ProjectMarginQueryView>("326a466b-764e-4fbc-95fc-f11fdc10c8af","","",false, this);
 
            GetManufacturingCosts = RPSControlFactory.CreateRPSCheckBox<ProjectMarginQueryView>("a2bbedb2-89ae-4b12-bdbf-f0aefb442ff5","","",false, this);
 
            UIGetIncludeChild = RPSControlFactory.CreateRPSCheckBox<ProjectMarginQueryView>("fe2a7994-0b3b-4604-8b86-a9c5cb7aba3a","","",false, this);
 
            Canceled = RPSControlFactory.CreateRPSCheckBox<ProjectMarginQueryView>("21e85bfa-be00-467e-966b-1425ba697c20","","",false, this);
 
            MarginTheoric = RPSControlFactory.CreateRPSFormattedTextBox<ProjectMarginQueryView>("a0b39563-b66a-4b6c-9e7a-11be1e3e44c0","","",false, this);
 
            MarginReal = RPSControlFactory.CreateRPSFormattedTextBox<ProjectMarginQueryView>("c6db50bf-87da-4b28-a26f-3b32bb79b7f1","","",false, this);
 
            Canceled1 = RPSControlFactory.CreateRPSCheckBox<ProjectMarginQueryView>("1dbefb41-7aab-49d7-abfe-33ed858707e2","","",false, this);
 
            MarginTheoric1 = RPSControlFactory.CreateRPSFormattedTextBox<ProjectMarginQueryView>("f6ee7ea3-8145-4867-bdc4-ecb6e8eb388a","","",false, this);
 
            MarginReal1 = RPSControlFactory.CreateRPSFormattedTextBox<ProjectMarginQueryView>("7bde676b-9c0d-4ee6-9669-fa8725584371","","",false, this);
 

        }
        public IRPSComboBox<ProjectMarginQueryView> Site { get; set; } 
        public IRPSCollectionComboBox<ProjectMarginQueryView> Project { get; set; } 
        public IRPSCollectionComboBox<ProjectMarginQueryView> Situation { get; set; } 
        public IRPSComboBox<ProjectMarginQueryView> ProjectType { get; set; } 
        public IRPSCheckbox<ProjectMarginQueryView> GetManufacturingCosts { get; set; } 
        public IRPSCheckbox<ProjectMarginQueryView> UIGetIncludeChild { get; set; } 
        public IRPSCheckbox<ProjectMarginQueryView> Canceled { get; set; } 
        public IRPSTextBox<ProjectMarginQueryView> MarginTheoric { get; set; } 
        public IRPSTextBox<ProjectMarginQueryView> MarginReal { get; set; } 
        public IRPSCheckbox<ProjectMarginQueryView> Canceled1 { get; set; } 
        public IRPSTextBox<ProjectMarginQueryView> MarginTheoric1 { get; set; } 
        public IRPSTextBox<ProjectMarginQueryView> MarginReal1 { get; set; } 
        public ProjectMargin Screen { get; set; }
        public ProjectMarginQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}