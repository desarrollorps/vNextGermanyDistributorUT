    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.ProjectTracking
{
    //RPS VERSION 1.0.0.0
    public partial class ProjectTracking:Screen
    {
        public ProjectTracking():base()
        {
            this.URL = "project.projecttracking";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ProjectTrackingQueryView  = new ProjectTrackingQueryView(this); 
            ProjectTrackingQueryView.InitializeControls(); 
           
        }
      
            public ProjectTrackingQueryView ProjectTrackingQueryView {get; set; } 
    }
            
    public partial class ProjectTrackingQueryView : View
    {
        public ProjectTrackingQueryView(ProjectTracking screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDProject = RPSControlFactory.CreateRPSComboBox<ProjectTrackingQueryView>("93e61633-37ab-47c4-807e-e67b5c75af39","","",false, this);
 
            GetManufacturingCosts = RPSControlFactory.CreateRPSCheckBox<ProjectTrackingQueryView>("ae92ee6c-14a5-41de-bd01-d57b5641aff8","","",false, this);
 
            BCWS = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTrackingQueryView>("736afb0f-9533-4daa-a785-03e518456e9c","","",false, this);
 
            BCWP = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTrackingQueryView>("7abad1fc-40ac-4a24-8295-ecb7ab0b22af","","",false, this);
 
            SV = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTrackingQueryView>("3521e3b6-5b9e-4e26-a0dc-28e4aaa073e1","","",false, this);
 
            ACWP = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTrackingQueryView>("dd6cc1da-db3c-414f-a6e9-82ae3c8cf2e5","","",false, this);
 
            CV = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTrackingQueryView>("7642d9a5-5e93-4056-aff3-d0493df3d35f","","",false, this);
 
            FactorP = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTrackingQueryView>("377322fe-56d6-4899-912b-481601790fc1","","",false, this);
 
            CollectionInit params_ProjectTaskTracking = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="58e558fd-2260-4c5c-afbf-0c3c166229d5",CSSSelectorGrid="",XPathGrid=""};
            ProjectTaskTracking = RPSControlFactory.RPSCreateCollectionWithGrid<ProjectTaskTrackingCollectionEditor<ProjectTrackingQueryView>,ProjectTrackingQueryView>( params_ProjectTaskTracking,this);
 
            SectionChart = RPSControlFactory.CreateRPSSection<ProjectTrackingQueryView>( "","ul li[rpsid='c54a1fce-0c5d-43bf-8563-b4bfff60d0ba']","",this);
 
            Section = RPSControlFactory.CreateRPSSection<ProjectTrackingQueryView>( "","ul li[rpsid='e4d8879a-95ea-4eb4-aae3-8b942df74744']","",this);
 

        }
        public IRPSComboBox<ProjectTrackingQueryView> IDProject { get; set; } 
        public IRPSCheckbox<ProjectTrackingQueryView> GetManufacturingCosts { get; set; } 
        public IRPSTextBox<ProjectTrackingQueryView> BCWS { get; set; } 
        public IRPSTextBox<ProjectTrackingQueryView> BCWP { get; set; } 
        public IRPSTextBox<ProjectTrackingQueryView> SV { get; set; } 
        public IRPSTextBox<ProjectTrackingQueryView> ACWP { get; set; } 
        public IRPSTextBox<ProjectTrackingQueryView> CV { get; set; } 
        public IRPSTextBox<ProjectTrackingQueryView> FactorP { get; set; } 
        public ProjectTaskTrackingCollectionEditor<ProjectTrackingQueryView> ProjectTaskTracking { get; set; } 
        public IRPSSection<ProjectTrackingQueryView> SectionChart { get; set; } 
        public IRPSSection<ProjectTrackingQueryView> Section { get; set; } 
        public ProjectTracking Screen { get; set; }
        public ProjectTrackingQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ProjectTaskTrackingCollectionEditor<ProjectTrackingQueryView>:RPSCollectionEditor<ProjectTrackingQueryView> where ProjectTrackingQueryView : class, IView
    {
        public  ProjectTaskTrackingGridView<ProjectTrackingQueryView> GridView {get;set;}
    }
    public partial class ProjectTaskTrackingGridView <ProjectTrackingQueryView> :  RPSGridView<ProjectTrackingQueryView> where ProjectTrackingQueryView : class, IView
    {
        public ProjectTaskTrackingGridView(ProjectTrackingQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            BCWSPG = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectTrackingQueryView>("","#58e558fd-2260-4c5c-afbf-0c3c166229d5 .ag-row[role='row']@ROWINDEX [col-id='cBCWSPG']","",false, this.CurrentView);
 
            BCWPToday = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectTrackingQueryView>("","#58e558fd-2260-4c5c-afbf-0c3c166229d5 .ag-row[role='row']@ROWINDEX [col-id='cBCWPToday']","",false, this.CurrentView);
 
            BCWP_BCWS_Difference = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectTrackingQueryView>("","#58e558fd-2260-4c5c-afbf-0c3c166229d5 .ag-row[role='row']@ROWINDEX [col-id='cBCWP_BCWS_Difference']","",false, this.CurrentView);
 
            Risk = RPSControlFactory.CreateRPSGridTextBox<ProjectTrackingQueryView>("","#58e558fd-2260-4c5c-afbf-0c3c166229d5 .ag-row[role='row']@ROWINDEX [col-id='cRisk']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ProjectTrackingQueryView> BCWSPG { get; set; } 
        public IRPSGridTextBox<ProjectTrackingQueryView> BCWPToday { get; set; } 
        public IRPSGridTextBox<ProjectTrackingQueryView> BCWP_BCWS_Difference { get; set; } 
        public IRPSGridTextBox<ProjectTrackingQueryView> Risk { get; set; } 
                     
    }
 
    }
  
    

}