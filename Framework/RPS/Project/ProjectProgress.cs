    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.ProjectProgress
{
    //RPS VERSION 1.0.0.0
    public partial class ProjectProgress:Screen
    {
        public ProjectProgress():base()
        {
            this.URL = "project.projectprogress";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ProjectProgressQueryView  = new ProjectProgressQueryView(this); 
            ProjectProgressQueryView.InitializeControls(); 
           
        }
      
            public ProjectProgressQueryView ProjectProgressQueryView {get; set; } 
    }
            
    public partial class ProjectProgressQueryView : View
    {
        public ProjectProgressQueryView(ProjectProgress screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<ProjectProgressQueryView>("28ce0e45-e651-4799-ac88-601e624e6499","","",false, this);
 
            Project = RPSControlFactory.CreateRPSCollectionComboBox<ProjectProgressQueryView>("5dca39d9-4b99-4b4b-a47e-663f1b094889","","",false, this);
 
            Situation = RPSControlFactory.CreateRPSCollectionComboBox<ProjectProgressQueryView>("b573c62d-4721-4b5e-9ecc-982f349224f2","","",false, this);
 
            ProjectType = RPSControlFactory.CreateRPSComboBox<ProjectProgressQueryView>("598d84e0-1ef4-48a5-9f3b-97ea97c51e66","","",false, this);
 
            UIGetIncludeChild = RPSControlFactory.CreateRPSCheckBox<ProjectProgressQueryView>("54d95509-805b-44bf-9803-8e2c17665862","","",false, this);
 
            Canceled = RPSControlFactory.CreateRPSCheckBox<ProjectProgressQueryView>("b120c066-e56d-4854-ab90-1d203910e3d9","","",false, this);
 
            DelayEndPlannedManual = RPSControlFactory.CreateRPSFormattedTextBox<ProjectProgressQueryView>("7f7418fc-7650-4349-8e4e-42e01c565371","","",false, this);
 
            PlanificatedEndDate = RPSControlFactory.CreateRPSTextBox<ProjectProgressQueryView>("1575183b-8309-439e-8461-f377ab6c21b5","","",false, this);
 
            TotalEstimatedTime = RPSControlFactory.CreateRPSFormattedTextBox<ProjectProgressQueryView>("26f648c0-3dba-498a-aaab-19c1a8b58515","","",false, this);
 
            TotalRealTime = RPSControlFactory.CreateRPSFormattedTextBox<ProjectProgressQueryView>("d16429e4-dee4-43d6-90c5-7d0f390d57ee","","",false, this);
 
            Progress = RPSControlFactory.CreateRPSFormattedTextBox<ProjectProgressQueryView>("6618d94b-3393-4d56-9573-b1e1aaad271f","","",false, this);
 
            Canceled1 = RPSControlFactory.CreateRPSCheckBox<ProjectProgressQueryView>("395a19af-9b91-4c9d-a8dd-4651cbe0e9b3","","",false, this);
 
            TotalEstimatedTime1 = RPSControlFactory.CreateRPSFormattedTextBox<ProjectProgressQueryView>("f0e120e9-e8da-46fc-b022-7d25010b7877","","",false, this);
 
            Progress1 = RPSControlFactory.CreateRPSFormattedTextBox<ProjectProgressQueryView>("6118222b-e9de-49c7-a683-cd69caaae7b4","","",false, this);
 
            TotalRealTime1 = RPSControlFactory.CreateRPSFormattedTextBox<ProjectProgressQueryView>("f4a78799-6ce1-48dd-bc5c-11fea47d99e1","","",false, this);
 
            PendingTime = RPSControlFactory.CreateRPSFormattedTextBox<ProjectProgressQueryView>("c922e30e-cfa3-4e57-b893-bc271ec551dc","","",false, this);
 
            EstimatedExpectedTime = RPSControlFactory.CreateRPSFormattedTextBox<ProjectProgressQueryView>("0e723c12-1c31-4d9c-ae84-d0fb8b4ad778","","",false, this);
 
            TheoricalProgress = RPSControlFactory.CreateRPSFormattedTextBox<ProjectProgressQueryView>("423b1745-b47e-4d78-845a-367be4ba23fa","","",false, this);
 
            ManualInitialDate = RPSControlFactory.CreateRPSTextBox<ProjectProgressQueryView>("1c45635c-6869-4b7c-a517-74a9af352443","","",false, this);
 
            ManualEndDate = RPSControlFactory.CreateRPSTextBox<ProjectProgressQueryView>("dd37fcec-1637-4e7c-99a2-956bfb330a58","","",false, this);
 
            ManualClientEndDate = RPSControlFactory.CreateRPSTextBox<ProjectProgressQueryView>("a765dc1c-59eb-41b0-87cc-c85dc24f7c8d","","",false, this);
 
            PlanificatedInitialDate = RPSControlFactory.CreateRPSTextBox<ProjectProgressQueryView>("6cde54fa-3495-49e4-94ae-217cb7557215","","",false, this);
 
            PlanificatedEndDate1 = RPSControlFactory.CreateRPSTextBox<ProjectProgressQueryView>("b986a02c-d666-4ce0-8df1-19bf941b161c","","",false, this);
 
            DelayStartPlannedManual = RPSControlFactory.CreateRPSFormattedTextBox<ProjectProgressQueryView>("19d01f12-f652-4345-8941-6eb61a4621b0","","",false, this);
 
            DelayEndPlannedManual1 = RPSControlFactory.CreateRPSFormattedTextBox<ProjectProgressQueryView>("47429c51-bae2-4ea1-a820-14c3e3cd5238","","",false, this);
 
            RealStartDate = RPSControlFactory.CreateRPSTextBox<ProjectProgressQueryView>("7eb25944-da06-4d9a-8219-d933965ac786","","",false, this);
 
            RealEndDate = RPSControlFactory.CreateRPSTextBox<ProjectProgressQueryView>("1fec49ef-cc73-478b-ad9b-7e8b747bec23","","",false, this);
 
            DelayStartPlannedReal = RPSControlFactory.CreateRPSFormattedTextBox<ProjectProgressQueryView>("8bd26d2a-2379-4141-903a-fdf85d252edf","","",false, this);
 
            DelayEndPlannedReal = RPSControlFactory.CreateRPSFormattedTextBox<ProjectProgressQueryView>("5af36d11-bcfd-4eb5-9c56-1df8bc97adcd","","",false, this);
 

        }
        public IRPSComboBox<ProjectProgressQueryView> Site { get; set; } 
        public IRPSCollectionComboBox<ProjectProgressQueryView> Project { get; set; } 
        public IRPSCollectionComboBox<ProjectProgressQueryView> Situation { get; set; } 
        public IRPSComboBox<ProjectProgressQueryView> ProjectType { get; set; } 
        public IRPSCheckbox<ProjectProgressQueryView> UIGetIncludeChild { get; set; } 
        public IRPSCheckbox<ProjectProgressQueryView> Canceled { get; set; } 
        public IRPSTextBox<ProjectProgressQueryView> DelayEndPlannedManual { get; set; } 
        public IRPSTextBox<ProjectProgressQueryView> PlanificatedEndDate { get; set; } 
        public IRPSTextBox<ProjectProgressQueryView> TotalEstimatedTime { get; set; } 
        public IRPSTextBox<ProjectProgressQueryView> TotalRealTime { get; set; } 
        public IRPSTextBox<ProjectProgressQueryView> Progress { get; set; } 
        public IRPSCheckbox<ProjectProgressQueryView> Canceled1 { get; set; } 
        public IRPSTextBox<ProjectProgressQueryView> TotalEstimatedTime1 { get; set; } 
        public IRPSTextBox<ProjectProgressQueryView> Progress1 { get; set; } 
        public IRPSTextBox<ProjectProgressQueryView> TotalRealTime1 { get; set; } 
        public IRPSTextBox<ProjectProgressQueryView> PendingTime { get; set; } 
        public IRPSTextBox<ProjectProgressQueryView> EstimatedExpectedTime { get; set; } 
        public IRPSTextBox<ProjectProgressQueryView> TheoricalProgress { get; set; } 
        public IRPSTextBox<ProjectProgressQueryView> ManualInitialDate { get; set; } 
        public IRPSTextBox<ProjectProgressQueryView> ManualEndDate { get; set; } 
        public IRPSTextBox<ProjectProgressQueryView> ManualClientEndDate { get; set; } 
        public IRPSTextBox<ProjectProgressQueryView> PlanificatedInitialDate { get; set; } 
        public IRPSTextBox<ProjectProgressQueryView> PlanificatedEndDate1 { get; set; } 
        public IRPSTextBox<ProjectProgressQueryView> DelayStartPlannedManual { get; set; } 
        public IRPSTextBox<ProjectProgressQueryView> DelayEndPlannedManual1 { get; set; } 
        public IRPSTextBox<ProjectProgressQueryView> RealStartDate { get; set; } 
        public IRPSTextBox<ProjectProgressQueryView> RealEndDate { get; set; } 
        public IRPSTextBox<ProjectProgressQueryView> DelayStartPlannedReal { get; set; } 
        public IRPSTextBox<ProjectProgressQueryView> DelayEndPlannedReal { get; set; } 
        public ProjectProgress Screen { get; set; }
        public ProjectProgressQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}