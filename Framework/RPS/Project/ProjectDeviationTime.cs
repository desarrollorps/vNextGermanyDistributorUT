    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.ProjectDeviationTime
{
    //RPS VERSION 1.0.0.0
    public partial class ProjectDeviationTime:Screen
    {
        public ProjectDeviationTime():base()
        {
            this.URL = "project.projectdeviationtime";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ProjectDeviationTimeQueryView  = new ProjectDeviationTimeQueryView(this); 
            ProjectDeviationTimeQueryView.InitializeControls(); 
           
        }
      
            public ProjectDeviationTimeQueryView ProjectDeviationTimeQueryView {get; set; } 
    }
            
    public partial class ProjectDeviationTimeQueryView : View
    {
        public ProjectDeviationTimeQueryView(ProjectDeviationTime screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<ProjectDeviationTimeQueryView>("51ebfe05-53df-4ae7-b863-d46b810b9125","","",false, this);
 
            Project = RPSControlFactory.CreateRPSCollectionComboBox<ProjectDeviationTimeQueryView>("c7d8758f-b39c-46c1-ad34-b23304bf5625","","",false, this);
 
            Situation = RPSControlFactory.CreateRPSCollectionComboBox<ProjectDeviationTimeQueryView>("471d5ea8-4912-4f30-96fb-5b4c2ce3e70f","","",false, this);
 
            ProjectType = RPSControlFactory.CreateRPSComboBox<ProjectDeviationTimeQueryView>("59897dda-976e-4b43-8ba3-faf4a8e90881","","",false, this);
 
            UIGetIncludeChild = RPSControlFactory.CreateRPSCheckBox<ProjectDeviationTimeQueryView>("41b2aea7-139d-4626-9326-541a3f8d4a37","","",false, this);
 
            Canceled = RPSControlFactory.CreateRPSCheckBox<ProjectDeviationTimeQueryView>("c24f7668-d449-4b0b-b8ca-47eb379d5f62","","",false, this);
 
            EstimatedTime = RPSControlFactory.CreateRPSFormattedTextBox<ProjectDeviationTimeQueryView>("d96dac3d-89cd-4ef9-a185-ac09a2e6af69","","",false, this);
 
            RealTime = RPSControlFactory.CreateRPSFormattedTextBox<ProjectDeviationTimeQueryView>("09256601-6734-4cdf-b679-25d0a008360e","","",false, this);
 
            PendingTime = RPSControlFactory.CreateRPSFormattedTextBox<ProjectDeviationTimeQueryView>("b4e761a8-250e-4e38-9394-1482ffda9c23","","",false, this);
 
            Deviation = RPSControlFactory.CreateRPSFormattedTextBox<ProjectDeviationTimeQueryView>("561b0b8e-d060-4406-b2cb-2e94c977ed3d","","",false, this);
 
            Progress = RPSControlFactory.CreateRPSFormattedTextBox<ProjectDeviationTimeQueryView>("64feda4c-8df9-41c4-a2c5-73187eb25412","","",false, this);
 
            RealUnproductiveTime = RPSControlFactory.CreateRPSFormattedTextBox<ProjectDeviationTimeQueryView>("412b915a-9152-4402-bddd-9be409ed14ce","","",false, this);
 
            Plan = RPSControlFactory.CreateRPSCheckBox<ProjectDeviationTimeQueryView>("527f752d-8749-48bc-a974-f4e4ad977dc7","","",false, this);
 
            EstimatedTime1 = RPSControlFactory.CreateRPSFormattedTextBox<ProjectDeviationTimeQueryView>("61793607-32f1-456b-a247-1004a079189b","","",false, this);
 
            RealTime1 = RPSControlFactory.CreateRPSFormattedTextBox<ProjectDeviationTimeQueryView>("c0e6638c-f324-4ed2-8173-0ae55d2cdd3b","","",false, this);
 
            PendingTime1 = RPSControlFactory.CreateRPSFormattedTextBox<ProjectDeviationTimeQueryView>("60ffbf3b-a8ad-48c1-9829-60fb37655720","","",false, this);
 
            Deviation1 = RPSControlFactory.CreateRPSFormattedTextBox<ProjectDeviationTimeQueryView>("01709c97-24db-4969-b2da-ac5c361de8a6","","",false, this);
 
            Progress1 = RPSControlFactory.CreateRPSFormattedTextBox<ProjectDeviationTimeQueryView>("4e6345f0-5a16-4420-aea3-37ce49343cce","","",false, this);
 
            RealUnproductiveTime1 = RPSControlFactory.CreateRPSFormattedTextBox<ProjectDeviationTimeQueryView>("93d470cb-7881-4eac-a27b-6f44524aa83c","","",false, this);
 
            Plan1 = RPSControlFactory.CreateRPSCheckBox<ProjectDeviationTimeQueryView>("0f4b5bf8-2886-4eb1-bc6e-aa8e2c07e77c","","",false, this);
 
            Canceled1 = RPSControlFactory.CreateRPSCheckBox<ProjectDeviationTimeQueryView>("db478abe-7c37-4bc6-8ef4-79baf2018acd","","",false, this);
 

        }
        public IRPSComboBox<ProjectDeviationTimeQueryView> Site { get; set; } 
        public IRPSCollectionComboBox<ProjectDeviationTimeQueryView> Project { get; set; } 
        public IRPSCollectionComboBox<ProjectDeviationTimeQueryView> Situation { get; set; } 
        public IRPSComboBox<ProjectDeviationTimeQueryView> ProjectType { get; set; } 
        public IRPSCheckbox<ProjectDeviationTimeQueryView> UIGetIncludeChild { get; set; } 
        public IRPSCheckbox<ProjectDeviationTimeQueryView> Canceled { get; set; } 
        public IRPSTextBox<ProjectDeviationTimeQueryView> EstimatedTime { get; set; } 
        public IRPSTextBox<ProjectDeviationTimeQueryView> RealTime { get; set; } 
        public IRPSTextBox<ProjectDeviationTimeQueryView> PendingTime { get; set; } 
        public IRPSTextBox<ProjectDeviationTimeQueryView> Deviation { get; set; } 
        public IRPSTextBox<ProjectDeviationTimeQueryView> Progress { get; set; } 
        public IRPSTextBox<ProjectDeviationTimeQueryView> RealUnproductiveTime { get; set; } 
        public IRPSCheckbox<ProjectDeviationTimeQueryView> Plan { get; set; } 
        public IRPSTextBox<ProjectDeviationTimeQueryView> EstimatedTime1 { get; set; } 
        public IRPSTextBox<ProjectDeviationTimeQueryView> RealTime1 { get; set; } 
        public IRPSTextBox<ProjectDeviationTimeQueryView> PendingTime1 { get; set; } 
        public IRPSTextBox<ProjectDeviationTimeQueryView> Deviation1 { get; set; } 
        public IRPSTextBox<ProjectDeviationTimeQueryView> Progress1 { get; set; } 
        public IRPSTextBox<ProjectDeviationTimeQueryView> RealUnproductiveTime1 { get; set; } 
        public IRPSCheckbox<ProjectDeviationTimeQueryView> Plan1 { get; set; } 
        public IRPSCheckbox<ProjectDeviationTimeQueryView> Canceled1 { get; set; } 
        public ProjectDeviationTime Screen { get; set; }
        public ProjectDeviationTimeQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}