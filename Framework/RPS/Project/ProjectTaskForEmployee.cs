    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.ProjectTaskForEmployee
{
    //RPS VERSION 1.0.0.0
    public partial class ProjectTaskForEmployee:Screen
    {
        public ProjectTaskForEmployee():base()
        {
            this.URL = "project.projecttaskforemployee";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ProjectTaskForEmployeeQueryView  = new ProjectTaskForEmployeeQueryView(this); 
            ProjectTaskDataView  = new ProjectTaskDataView(this); 
            ProjectTaskForEmployeeQueryView.InitializeControls(); 
            ProjectTaskDataView.InitializeControls(); 
           
        }
      
            public ProjectTaskForEmployeeQueryView ProjectTaskForEmployeeQueryView {get; set; } 
            public ProjectTaskDataView ProjectTaskDataView {get; set; } 
    }
            
    public partial class ProjectTaskForEmployeeQueryView : View
    {
        public ProjectTaskForEmployeeQueryView(ProjectTaskForEmployee screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_ProjectTaskForEmployee = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="757fa112-9961-433a-b8ae-99b28324abfb",CSSSelectorGrid="",XPathGrid=""};
            ProjectTaskForEmployee = RPSControlFactory.RPSCreateCollectionWithGrid<ProjectTaskForEmployeeCollectionEditor<ProjectTaskForEmployeeQueryView>,ProjectTaskForEmployeeQueryView>( params_ProjectTaskForEmployee,this);
 

        }
        public ProjectTaskForEmployeeCollectionEditor<ProjectTaskForEmployeeQueryView> ProjectTaskForEmployee { get; set; } 
        public ProjectTaskForEmployee Screen { get; set; }
        public ProjectTaskForEmployeeQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ProjectTaskForEmployeeCollectionEditor<ProjectTaskForEmployeeQueryView>:RPSCollectionEditor<ProjectTaskForEmployeeQueryView> where ProjectTaskForEmployeeQueryView : class, IView
    {
        public  ProjectTaskForEmployeeGridView<ProjectTaskForEmployeeQueryView> GridView {get;set;}
    }
    public partial class ProjectTaskForEmployeeGridView <ProjectTaskForEmployeeQueryView> :  RPSGridView<ProjectTaskForEmployeeQueryView> where ProjectTaskForEmployeeQueryView : class, IView
    {
        public ProjectTaskForEmployeeGridView(ProjectTaskForEmployeeQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ProjectTask_PlannedStartDate = RPSControlFactory.CreateRPSGridTextBox<ProjectTaskForEmployeeQueryView>("","#757fa112-9961-433a-b8ae-99b28324abfb .ag-row[role='row']@ROWINDEX [col-id='cProjectTask_PlannedStartDate']","",false, this.CurrentView);
 
            ProjectTask_PlannedEndDate = RPSControlFactory.CreateRPSGridTextBox<ProjectTaskForEmployeeQueryView>("","#757fa112-9961-433a-b8ae-99b28324abfb .ag-row[role='row']@ROWINDEX [col-id='cProjectTask_PlannedEndDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ProjectTaskForEmployeeQueryView> ProjectTask_PlannedStartDate { get; set; } 
        public IRPSGridTextBox<ProjectTaskForEmployeeQueryView> ProjectTask_PlannedEndDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class ProjectTaskDataView : View
    {
        public ProjectTaskDataView(ProjectTaskForEmployee screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIIDProject = RPSControlFactory.CreateRPSComboBox<ProjectTaskDataView>("e2b43a1b-0d14-4063-b46f-29dac4c9b801","","",false, this);
 
            UIIDProjectResponsible = RPSControlFactory.CreateRPSComboBox<ProjectTaskDataView>("c3232358-7d50-4bc3-8784-4a0e1c5426da","","",false, this);
 
            UIIDProjectTask = RPSControlFactory.CreateRPSComboBox<ProjectTaskDataView>("476d2449-f371-40af-add3-707e35e19922","","",false, this);
 
            UIIDProjectTaskResponsible = RPSControlFactory.CreateRPSComboBox<ProjectTaskDataView>("2003d679-1773-46e7-9144-d0273fac67d6","","",false, this);
 
            UIPlannedStartDate = RPSControlFactory.CreateRPSTextBox<ProjectTaskDataView>("40fac5a7-5b12-40c9-9f13-a33cd4d59f70","","",false, this);
 
            UIPlannedEndDate = RPSControlFactory.CreateRPSTextBox<ProjectTaskDataView>("835a6271-39f4-48c6-975c-bed841b778da","","",false, this);
 
            UIPercentProgress = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskDataView>("12adb0ce-bb70-4755-a184-9ef36fd25006","","",false, this);
 
            UIDuration = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskDataView>("5984cb9e-b6ec-4f9e-b818-d418f396e26b","","",false, this);
 
            UITimeUnit = RPSControlFactory.CreateRPSEnumComboBox<ProjectTaskDataView>("6110e80c-aff7-4831-9377-5ab5c96761e0","","",false, this);
 
            UINotes = RPSControlFactory.CreateRPSTextBox<ProjectTaskDataView>("fa14b1c4-cd67-4660-b251-10606ab5a90f","","",false, this);
 
            CostImputationButton = RPSControlFactory.CreateRPSButton<ProjectTaskDataView>( "1208f558-5a2d-47fc-9dc0-af18bd4dcb34","","",this);
 
            TimeImputationButton = RPSControlFactory.CreateRPSButton<ProjectTaskDataView>( "0e54191b-f193-4c2c-91cb-f5c2e7c8fdca","","",this);
 

        }
        public IRPSComboBox<ProjectTaskDataView> UIIDProject { get; set; } 
        public IRPSComboBox<ProjectTaskDataView> UIIDProjectResponsible { get; set; } 
        public IRPSComboBox<ProjectTaskDataView> UIIDProjectTask { get; set; } 
        public IRPSComboBox<ProjectTaskDataView> UIIDProjectTaskResponsible { get; set; } 
        public IRPSTextBox<ProjectTaskDataView> UIPlannedStartDate { get; set; } 
        public IRPSTextBox<ProjectTaskDataView> UIPlannedEndDate { get; set; } 
        public IRPSTextBox<ProjectTaskDataView> UIPercentProgress { get; set; } 
        public IRPSTextBox<ProjectTaskDataView> UIDuration { get; set; } 
        public IRPSComboBox<ProjectTaskDataView> UITimeUnit { get; set; } 
        public IRPSTextBox<ProjectTaskDataView> UINotes { get; set; } 
        public IRPSButton<ProjectTaskDataView> CostImputationButton { get; set; } 
        public IRPSButton<ProjectTaskDataView> TimeImputationButton { get; set; } 
        public ProjectTaskForEmployee Screen { get; set; }
        public ProjectTaskDataView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}