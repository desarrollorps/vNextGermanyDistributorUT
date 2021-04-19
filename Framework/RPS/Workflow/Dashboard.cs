    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Workflow.Dashboard
{
    //RPS VERSION 1.0.0.0
    public partial class Dashboard:Screen
    {
        public Dashboard():base()
        {
            this.URL = "workflow.dashboard";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DashboardQueryView  = new DashboardQueryView(this); 
            WorkFlowDashboardTaskView  = new WorkFlowDashboardTaskView(this); 
            WorkFlowDashboardTaskProcessView  = new WorkFlowDashboardTaskProcessView(this); 
            DashboardQueryView.InitializeControls(); 
            WorkFlowDashboardTaskView.InitializeControls(); 
            WorkFlowDashboardTaskProcessView.InitializeControls(); 
           
        }
      
            public DashboardQueryView DashboardQueryView {get; set; } 
            public WorkFlowDashboardTaskView WorkFlowDashboardTaskView {get; set; } 
            public WorkFlowDashboardTaskProcessView WorkFlowDashboardTaskProcessView {get; set; } 
    }
            
    public partial class DashboardQueryView : View
    {
        public DashboardQueryView(Dashboard screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIPendingTasks = RPSControlFactory.CreateRPSCheckBox<DashboardQueryView>("46337011-3b8a-4717-9752-203ab46d85a6","","",false, this);
 
            UIClosedTasks = RPSControlFactory.CreateRPSCheckBox<DashboardQueryView>("e1dd2b6c-57f1-4990-b032-27410e04c5ee","","",false, this);
 
            UIDateFrom = RPSControlFactory.CreateRPSTextBox<DashboardQueryView>("625801f5-01c0-4eb3-8310-ac9f0ed69425","","",false, this);
 
            UIDateTo = RPSControlFactory.CreateRPSTextBox<DashboardQueryView>("cf9545e7-404e-43f1-b64f-227af57ee2c0","","",false, this);
 
            UIOptUser = RPSControlFactory.CreateRPSOption<DashboardQueryView>( "7f52cd44-113b-4773-bc5c-7559ff9a663c","","",this);
 
            UILstUsers = RPSControlFactory.CreateRPSComboBox<DashboardQueryView>("51e5bad0-7c6b-4f48-bb45-84ee4356a95b","","",false, this);
 
            UIOptTeam = RPSControlFactory.CreateRPSOption<DashboardQueryView>( "43fadae7-e3d9-4d72-953d-194b5b728faa","","",this);
 
            UILstProcess = RPSControlFactory.CreateRPSComboBox<DashboardQueryView>("58f2a910-b222-4aaf-86a4-a451650035e7","","",false, this);
 
            UILstWorkflow = RPSControlFactory.CreateRPSComboBox<DashboardQueryView>("6d3ec1ad-7cb4-49bc-a1fe-5ec940ecab31","","",false, this);
 
            CollectionInit params_WorkflowDashBoard = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="22cc270e-a459-427a-85a2-affcda413d74",CSSSelectorGrid="",XPathGrid=""};
            WorkflowDashBoard = RPSControlFactory.RPSCreateCollectionWithGrid<WorkflowDashBoardCollectionEditor<DashboardQueryView>,DashboardQueryView>( params_WorkflowDashBoard,this);
 

        }
        public IRPSCheckbox<DashboardQueryView> UIPendingTasks { get; set; } 
        public IRPSCheckbox<DashboardQueryView> UIClosedTasks { get; set; } 
        public IRPSTextBox<DashboardQueryView> UIDateFrom { get; set; } 
        public IRPSTextBox<DashboardQueryView> UIDateTo { get; set; } 
        public IRPSOption<DashboardQueryView> UIOptUser { get; set; } 
        public IRPSComboBox<DashboardQueryView> UILstUsers { get; set; } 
        public IRPSOption<DashboardQueryView> UIOptTeam { get; set; } 
        public IRPSComboBox<DashboardQueryView> UILstProcess { get; set; } 
        public IRPSComboBox<DashboardQueryView> UILstWorkflow { get; set; } 
        public WorkflowDashBoardCollectionEditor<DashboardQueryView> WorkflowDashBoard { get; set; } 
        public Dashboard Screen { get; set; }
        public DashboardQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class WorkflowDashBoardCollectionEditor<DashboardQueryView>:RPSCollectionEditor<DashboardQueryView> where DashboardQueryView : class, IView
    {
        public  WorkflowDashBoardGridView<DashboardQueryView> GridView {get;set;}
    }
    public partial class WorkflowDashBoardGridView <DashboardQueryView> :  RPSGridView<DashboardQueryView> where DashboardQueryView : class, IView
    {
        public WorkflowDashBoardGridView(DashboardQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NumPendinTaskUser = RPSControlFactory.CreateRPSGridFormattedTextBox<DashboardQueryView>("","#22cc270e-a459-427a-85a2-affcda413d74 .ag-row[role='row']@ROWINDEX [col-id='cNumPendinTaskUser']","",false, this.CurrentView);
 
            NumOpenInstance = RPSControlFactory.CreateRPSGridFormattedTextBox<DashboardQueryView>("","#22cc270e-a459-427a-85a2-affcda413d74 .ag-row[role='row']@ROWINDEX [col-id='cNumOpenInstance']","",false, this.CurrentView);
 
            NumDelayedTask = RPSControlFactory.CreateRPSGridFormattedTextBox<DashboardQueryView>("","#22cc270e-a459-427a-85a2-affcda413d74 .ag-row[role='row']@ROWINDEX [col-id='cNumDelayedTask']","",false, this.CurrentView);
 
            NumRegisteredIncidents = RPSControlFactory.CreateRPSGridFormattedTextBox<DashboardQueryView>("","#22cc270e-a459-427a-85a2-affcda413d74 .ag-row[role='row']@ROWINDEX [col-id='cNumRegisteredIncidents']","",false, this.CurrentView);
 
            NumPendinIncidents = RPSControlFactory.CreateRPSGridFormattedTextBox<DashboardQueryView>("","#22cc270e-a459-427a-85a2-affcda413d74 .ag-row[role='row']@ROWINDEX [col-id='cNumPendinIncidents']","",false, this.CurrentView);
 
            TaskDetailNavigationCommand = RPSControlFactory.CreateRPSGridButton<DashboardQueryView>( "","#22cc270e-a459-427a-85a2-affcda413d74 .ag-row[role='row']@ROWINDEX [col-id='cTaskDetailNavigationCommand']","",this.CurrentView);
 
            TaskDetailProcessNavigationCommand = RPSControlFactory.CreateRPSGridButton<DashboardQueryView>( "","#22cc270e-a459-427a-85a2-affcda413d74 .ag-row[role='row']@ROWINDEX [col-id='cTaskDetailProcessNavigationCommand']","",this.CurrentView);
 

        }
        public IRPSGridTextBox<DashboardQueryView> NumPendinTaskUser { get; set; } 
        public IRPSGridTextBox<DashboardQueryView> NumOpenInstance { get; set; } 
        public IRPSGridTextBox<DashboardQueryView> NumDelayedTask { get; set; } 
        public IRPSGridTextBox<DashboardQueryView> NumRegisteredIncidents { get; set; } 
        public IRPSGridTextBox<DashboardQueryView> NumPendinIncidents { get; set; } 
        public IRPSGridButton<DashboardQueryView> TaskDetailNavigationCommand { get; set; } 
        public IRPSGridButton<DashboardQueryView> TaskDetailProcessNavigationCommand { get; set; } 
                     
    }
 
    }
  
            
    public partial class WorkFlowDashboardTaskView : View
    {
        public WorkFlowDashboardTaskView(Dashboard screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Delay = RPSControlFactory.CreateRPSFormattedTextBox<WorkFlowDashboardTaskView>("df345903-d887-48dd-92d4-916306cb4ef8","","",false, this);
 
            StartDate = RPSControlFactory.CreateRPSTextBox<WorkFlowDashboardTaskView>("2537aff9-736a-4834-bba1-82862f9cbb94","","",false, this);
 
            eTaskState = RPSControlFactory.CreateRPSEnumComboBox<WorkFlowDashboardTaskView>("13a3b985-4f47-4c4b-a75c-e613b461b985","","",false, this);
 
            eTaskPriority = RPSControlFactory.CreateRPSEnumComboBox<WorkFlowDashboardTaskView>("b029b3b9-7732-48a5-8316-32912341273c","","",false, this);
 
            Label = RPSControlFactory.CreateRPSTextBox<WorkFlowDashboardTaskView>("c11a65d8-3851-46b5-ad50-a76a5e4369d0","","",false, this);
 
            Feature1 = RPSControlFactory.CreateRPSTextBox<WorkFlowDashboardTaskView>("8df1b0a4-3e1f-4ac9-8fd8-3875b6899e1c","","",false, this);
 
            Feature2 = RPSControlFactory.CreateRPSTextBox<WorkFlowDashboardTaskView>("651d27b4-1008-45d7-925b-4d17e408552a","","",false, this);
 
            Feature3 = RPSControlFactory.CreateRPSTextBox<WorkFlowDashboardTaskView>("ab09508b-4343-4661-8503-93cf3882ea39","","",false, this);
 
            Feature4 = RPSControlFactory.CreateRPSTextBox<WorkFlowDashboardTaskView>("dc5d7a9d-1780-497e-bfaf-698f6b812ab6","","",false, this);
 
            Feature5 = RPSControlFactory.CreateRPSTextBox<WorkFlowDashboardTaskView>("7e2000fb-b88e-4b22-81ed-14605ca0b6da","","",false, this);
 
            Feature6 = RPSControlFactory.CreateRPSTextBox<WorkFlowDashboardTaskView>("a9ac4869-a417-44d1-a83a-da562586d1bd","","",false, this);
 
            Feature7 = RPSControlFactory.CreateRPSTextBox<WorkFlowDashboardTaskView>("c6573168-f092-446c-8495-434e714f749a","","",false, this);
 
            Feature8 = RPSControlFactory.CreateRPSTextBox<WorkFlowDashboardTaskView>("e512b903-9936-4c2f-848d-22f96792de21","","",false, this);
 
            Feature9 = RPSControlFactory.CreateRPSTextBox<WorkFlowDashboardTaskView>("7d60bf37-feea-4af8-8a27-3fcd83321844","","",false, this);
 
            Feature10 = RPSControlFactory.CreateRPSTextBox<WorkFlowDashboardTaskView>("2b15060a-eb82-4496-9087-887e57c2d4ec","","",false, this);
 
            CollectionInit params_WorkflowDashBoardTask = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d0b74fe6-43ac-463e-95fb-450fbdff8bc5",CSSSelectorGrid="",XPathGrid=""};
            WorkflowDashBoardTask = RPSControlFactory.RPSCreateCollectionWithGrid<WorkflowDashBoardTaskCollectionEditor<WorkFlowDashboardTaskView>,WorkFlowDashboardTaskView>( params_WorkflowDashBoardTask,this);
 

        }
        public IRPSTextBox<WorkFlowDashboardTaskView> Delay { get; set; } 
        public IRPSTextBox<WorkFlowDashboardTaskView> StartDate { get; set; } 
        public IRPSComboBox<WorkFlowDashboardTaskView> eTaskState { get; set; } 
        public IRPSComboBox<WorkFlowDashboardTaskView> eTaskPriority { get; set; } 
        public IRPSTextBox<WorkFlowDashboardTaskView> Label { get; set; } 
        public IRPSTextBox<WorkFlowDashboardTaskView> Feature1 { get; set; } 
        public IRPSTextBox<WorkFlowDashboardTaskView> Feature2 { get; set; } 
        public IRPSTextBox<WorkFlowDashboardTaskView> Feature3 { get; set; } 
        public IRPSTextBox<WorkFlowDashboardTaskView> Feature4 { get; set; } 
        public IRPSTextBox<WorkFlowDashboardTaskView> Feature5 { get; set; } 
        public IRPSTextBox<WorkFlowDashboardTaskView> Feature6 { get; set; } 
        public IRPSTextBox<WorkFlowDashboardTaskView> Feature7 { get; set; } 
        public IRPSTextBox<WorkFlowDashboardTaskView> Feature8 { get; set; } 
        public IRPSTextBox<WorkFlowDashboardTaskView> Feature9 { get; set; } 
        public IRPSTextBox<WorkFlowDashboardTaskView> Feature10 { get; set; } 
        public WorkflowDashBoardTaskCollectionEditor<WorkFlowDashboardTaskView> WorkflowDashBoardTask { get; set; } 
        public Dashboard Screen { get; set; }
        public WorkFlowDashboardTaskView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class WorkflowDashBoardTaskCollectionEditor<WorkFlowDashboardTaskView>:RPSCollectionEditor<WorkFlowDashboardTaskView> where WorkFlowDashboardTaskView : class, IView
    {
        public  WorkflowDashBoardTaskGridView<WorkFlowDashboardTaskView> GridView {get;set;}
    }
    public partial class WorkflowDashBoardTaskGridView <WorkFlowDashboardTaskView> :  RPSGridView<WorkFlowDashboardTaskView> where WorkFlowDashboardTaskView : class, IView
    {
        public WorkflowDashBoardTaskGridView(WorkFlowDashboardTaskView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Delay = RPSControlFactory.CreateRPSGridFormattedTextBox<WorkFlowDashboardTaskView>("","#d0b74fe6-43ac-463e-95fb-450fbdff8bc5 .ag-row[role='row']@ROWINDEX [col-id='cDelay']","",false, this.CurrentView);
 
            StartDate = RPSControlFactory.CreateRPSGridTextBox<WorkFlowDashboardTaskView>("","#d0b74fe6-43ac-463e-95fb-450fbdff8bc5 .ag-row[role='row']@ROWINDEX [col-id='cStartDate']","",false, this.CurrentView);
 
            eTaskState = RPSControlFactory.CreateRPSGridEnumComboBox<WorkFlowDashboardTaskView>("","#d0b74fe6-43ac-463e-95fb-450fbdff8bc5 .ag-row[role='row']@ROWINDEX [col-id='ceTaskState']","",false, this.CurrentView);
 
            Label = RPSControlFactory.CreateRPSGridTextBox<WorkFlowDashboardTaskView>("","#d0b74fe6-43ac-463e-95fb-450fbdff8bc5 .ag-row[role='row']@ROWINDEX [col-id='cLabel']","",false, this.CurrentView);
 
            RunTaskCommand = RPSControlFactory.CreateRPSGridButton<WorkFlowDashboardTaskView>( "","#d0b74fe6-43ac-463e-95fb-450fbdff8bc5 .ag-row[role='row']@ROWINDEX [col-id='cRunTaskCommand']","",this.CurrentView);
 

        }
        public IRPSGridTextBox<WorkFlowDashboardTaskView> Delay { get; set; } 
        public IRPSGridTextBox<WorkFlowDashboardTaskView> StartDate { get; set; } 
        public IRPSGridComboBox<WorkFlowDashboardTaskView> eTaskState { get; set; } 
        public IRPSGridTextBox<WorkFlowDashboardTaskView> Label { get; set; } 
        public IRPSGridButton<WorkFlowDashboardTaskView> RunTaskCommand { get; set; } 
                     
    }
 
    }
  
            
    public partial class WorkFlowDashboardTaskProcessView : View
    {
        public WorkFlowDashboardTaskProcessView(Dashboard screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Delay = RPSControlFactory.CreateRPSFormattedTextBox<WorkFlowDashboardTaskProcessView>("a99766d2-9e2b-425f-aafe-24c0d595dd64","","",false, this);
 
            StartDate = RPSControlFactory.CreateRPSTextBox<WorkFlowDashboardTaskProcessView>("39c9aab6-d5cd-412c-b91c-5652f9d6b5d5","","",false, this);
 
            eTaskState = RPSControlFactory.CreateRPSEnumComboBox<WorkFlowDashboardTaskProcessView>("2688b486-2c0f-4f80-b3f5-06477ade482c","","",false, this);
 
            eTaskPriority = RPSControlFactory.CreateRPSEnumComboBox<WorkFlowDashboardTaskProcessView>("3d38859d-5d18-46e7-b39d-c1042d249067","","",false, this);
 
            Label = RPSControlFactory.CreateRPSTextBox<WorkFlowDashboardTaskProcessView>("03136cd4-02b6-4e0c-9fc1-a22145072173","","",false, this);
 
            Feature1 = RPSControlFactory.CreateRPSTextBox<WorkFlowDashboardTaskProcessView>("2b8e369e-dbed-438a-ba6a-a0c6f250143d","","",false, this);
 
            Feature2 = RPSControlFactory.CreateRPSTextBox<WorkFlowDashboardTaskProcessView>("d07182a3-888e-403a-ba71-dd656b95970e","","",false, this);
 
            Feature3 = RPSControlFactory.CreateRPSTextBox<WorkFlowDashboardTaskProcessView>("3604310e-4606-4ee3-8b32-c2de34471ba9","","",false, this);
 
            Feature4 = RPSControlFactory.CreateRPSTextBox<WorkFlowDashboardTaskProcessView>("80db50b8-e3c4-4a7e-b35b-5016a0e9a5d6","","",false, this);
 
            Feature5 = RPSControlFactory.CreateRPSTextBox<WorkFlowDashboardTaskProcessView>("e7fa5ec5-0204-4184-9e80-97c487e3b3aa","","",false, this);
 
            Feature6 = RPSControlFactory.CreateRPSTextBox<WorkFlowDashboardTaskProcessView>("a169d763-7108-4768-859c-0bc73812b1dd","","",false, this);
 
            Feature7 = RPSControlFactory.CreateRPSTextBox<WorkFlowDashboardTaskProcessView>("862d4cc9-0564-4102-b46b-9c860cab4e12","","",false, this);
 
            Feature8 = RPSControlFactory.CreateRPSTextBox<WorkFlowDashboardTaskProcessView>("d16439f0-b42e-415a-9500-565338b8a14e","","",false, this);
 
            Feature9 = RPSControlFactory.CreateRPSTextBox<WorkFlowDashboardTaskProcessView>("d80f4b7b-713b-47a9-8866-4e4a799dbfc8","","",false, this);
 
            Feature10 = RPSControlFactory.CreateRPSTextBox<WorkFlowDashboardTaskProcessView>("df5405e4-8011-466e-b07d-bd995432e9aa","","",false, this);
 
            CollectionInit params_WorkflowDashBoardTaskProcess = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="74bad9f9-dab4-4a88-9e8c-8d8d69fbcd0b",CSSSelectorGrid="",XPathGrid=""};
            WorkflowDashBoardTaskProcess = RPSControlFactory.RPSCreateCollectionWithGrid<WorkflowDashBoardTaskProcessCollectionEditor<WorkFlowDashboardTaskProcessView>,WorkFlowDashboardTaskProcessView>( params_WorkflowDashBoardTaskProcess,this);
 

        }
        public IRPSTextBox<WorkFlowDashboardTaskProcessView> Delay { get; set; } 
        public IRPSTextBox<WorkFlowDashboardTaskProcessView> StartDate { get; set; } 
        public IRPSComboBox<WorkFlowDashboardTaskProcessView> eTaskState { get; set; } 
        public IRPSComboBox<WorkFlowDashboardTaskProcessView> eTaskPriority { get; set; } 
        public IRPSTextBox<WorkFlowDashboardTaskProcessView> Label { get; set; } 
        public IRPSTextBox<WorkFlowDashboardTaskProcessView> Feature1 { get; set; } 
        public IRPSTextBox<WorkFlowDashboardTaskProcessView> Feature2 { get; set; } 
        public IRPSTextBox<WorkFlowDashboardTaskProcessView> Feature3 { get; set; } 
        public IRPSTextBox<WorkFlowDashboardTaskProcessView> Feature4 { get; set; } 
        public IRPSTextBox<WorkFlowDashboardTaskProcessView> Feature5 { get; set; } 
        public IRPSTextBox<WorkFlowDashboardTaskProcessView> Feature6 { get; set; } 
        public IRPSTextBox<WorkFlowDashboardTaskProcessView> Feature7 { get; set; } 
        public IRPSTextBox<WorkFlowDashboardTaskProcessView> Feature8 { get; set; } 
        public IRPSTextBox<WorkFlowDashboardTaskProcessView> Feature9 { get; set; } 
        public IRPSTextBox<WorkFlowDashboardTaskProcessView> Feature10 { get; set; } 
        public WorkflowDashBoardTaskProcessCollectionEditor<WorkFlowDashboardTaskProcessView> WorkflowDashBoardTaskProcess { get; set; } 
        public Dashboard Screen { get; set; }
        public WorkFlowDashboardTaskProcessView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class WorkflowDashBoardTaskProcessCollectionEditor<WorkFlowDashboardTaskProcessView>:RPSCollectionEditor<WorkFlowDashboardTaskProcessView> where WorkFlowDashboardTaskProcessView : class, IView
    {
        public  WorkflowDashBoardTaskProcessGridView<WorkFlowDashboardTaskProcessView> GridView {get;set;}
    }
    public partial class WorkflowDashBoardTaskProcessGridView <WorkFlowDashboardTaskProcessView> :  RPSGridView<WorkFlowDashboardTaskProcessView> where WorkFlowDashboardTaskProcessView : class, IView
    {
        public WorkflowDashBoardTaskProcessGridView(WorkFlowDashboardTaskProcessView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Delay = RPSControlFactory.CreateRPSGridFormattedTextBox<WorkFlowDashboardTaskProcessView>("","#74bad9f9-dab4-4a88-9e8c-8d8d69fbcd0b .ag-row[role='row']@ROWINDEX [col-id='cDelay']","",false, this.CurrentView);
 
            StartDate = RPSControlFactory.CreateRPSGridTextBox<WorkFlowDashboardTaskProcessView>("","#74bad9f9-dab4-4a88-9e8c-8d8d69fbcd0b .ag-row[role='row']@ROWINDEX [col-id='cStartDate']","",false, this.CurrentView);
 
            eTaskState = RPSControlFactory.CreateRPSGridEnumComboBox<WorkFlowDashboardTaskProcessView>("","#74bad9f9-dab4-4a88-9e8c-8d8d69fbcd0b .ag-row[role='row']@ROWINDEX [col-id='ceTaskState']","",false, this.CurrentView);
 
            Label = RPSControlFactory.CreateRPSGridTextBox<WorkFlowDashboardTaskProcessView>("","#74bad9f9-dab4-4a88-9e8c-8d8d69fbcd0b .ag-row[role='row']@ROWINDEX [col-id='cLabel']","",false, this.CurrentView);
 
            RunTaskCommand = RPSControlFactory.CreateRPSGridButton<WorkFlowDashboardTaskProcessView>( "","#74bad9f9-dab4-4a88-9e8c-8d8d69fbcd0b .ag-row[role='row']@ROWINDEX [col-id='cRunTaskCommand']","",this.CurrentView);
 

        }
        public IRPSGridTextBox<WorkFlowDashboardTaskProcessView> Delay { get; set; } 
        public IRPSGridTextBox<WorkFlowDashboardTaskProcessView> StartDate { get; set; } 
        public IRPSGridComboBox<WorkFlowDashboardTaskProcessView> eTaskState { get; set; } 
        public IRPSGridTextBox<WorkFlowDashboardTaskProcessView> Label { get; set; } 
        public IRPSGridButton<WorkFlowDashboardTaskProcessView> RunTaskCommand { get; set; } 
                     
    }
 
    }
  
    

}