    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Workflow.WorkflowInstanceTracking
{
    //RPS VERSION 1.0.0.0
    public partial class WorkflowInstanceTracking:Screen
    {
        public WorkflowInstanceTracking():base()
        {
            this.URL = "workflow.workflowinstancetracking";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            WorkflowInstanceTrackingQueryView  = new WorkflowInstanceTrackingQueryView(this); 
            WorkflowInstanceTrackingDetailsView  = new WorkflowInstanceTrackingDetailsView(this); 
            CleanWorkflowHistoryDataDialogView  = new CleanWorkflowHistoryDataDialogView(this); 
            WorkflowInstanceTrackingQueryView.InitializeControls(); 
            WorkflowInstanceTrackingDetailsView.InitializeControls(); 
            CleanWorkflowHistoryDataDialogView.InitializeControls(); 
           
        }
      
            public WorkflowInstanceTrackingQueryView WorkflowInstanceTrackingQueryView {get; set; } 
            public WorkflowInstanceTrackingDetailsView WorkflowInstanceTrackingDetailsView {get; set; } 
            public CleanWorkflowHistoryDataDialogView CleanWorkflowHistoryDataDialogView {get; set; } 
    }
            
    public partial class WorkflowInstanceTrackingQueryView : View
    {
        public WorkflowInstanceTrackingQueryView(WorkflowInstanceTracking screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIWorkflowGroup = RPSControlFactory.CreateRPSComboBox<WorkflowInstanceTrackingQueryView>("e5ea0c2b-1b20-4fa1-a6d4-7f58ccc819c9","","",false, this);
 
            UIWorkflow = RPSControlFactory.CreateRPSComboBox<WorkflowInstanceTrackingQueryView>("f49737de-2dd0-4cc6-87e4-6ff5051880ad","","",false, this);
 
            UIWorkflowVersion = RPSControlFactory.CreateRPSComboBox<WorkflowInstanceTrackingQueryView>("4fd56771-4e19-4412-a0f2-f42524eae2c6","","",false, this);
 
            UIOptRunning = RPSControlFactory.CreateRPSOption<WorkflowInstanceTrackingQueryView>( "be9f388c-f8cd-4472-8058-16028f25852e","","",this);
 
            UIOptAll = RPSControlFactory.CreateRPSOption<WorkflowInstanceTrackingQueryView>( "9dc35cc8-1069-427a-a41f-8a6477b5535f","","",this);
 
            TerminateWorkflowCommandButton = RPSControlFactory.CreateRPSButton<WorkflowInstanceTrackingQueryView>( "5abcacdd-c0cd-484b-877b-9964618fc46b","","",this);
 
            CleanWorkflowHistoryDataNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<WorkflowInstanceTrackingQueryView,CleanWorkflowHistoryDataDialogView>("da875c72-f760-4c22-8e0c-52ce95f53d0c","","", this,Screen.CleanWorkflowHistoryDataDialogView);
 
            CollectionInit params_WorkflowInstanceTracking = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ff3fd532-d6b1-4af9-b49d-e878c5bf7d93",CSSSelectorGrid="",XPathGrid=""};
            WorkflowInstanceTracking = RPSControlFactory.RPSCreateCollectionWithGrid<WorkflowInstanceTrackingCollectionEditor<WorkflowInstanceTrackingQueryView,CleanWorkflowHistoryDataDialogView>,WorkflowInstanceTrackingQueryView,CleanWorkflowHistoryDataDialogView>( params_WorkflowInstanceTracking,this,Screen.CleanWorkflowHistoryDataDialogView);
 

        }
        public IRPSComboBox<WorkflowInstanceTrackingQueryView> UIWorkflowGroup { get; set; } 
        public IRPSComboBox<WorkflowInstanceTrackingQueryView> UIWorkflow { get; set; } 
        public IRPSComboBox<WorkflowInstanceTrackingQueryView> UIWorkflowVersion { get; set; } 
        public IRPSOption<WorkflowInstanceTrackingQueryView> UIOptRunning { get; set; } 
        public IRPSOption<WorkflowInstanceTrackingQueryView> UIOptAll { get; set; } 
        public IRPSButton<WorkflowInstanceTrackingQueryView> TerminateWorkflowCommandButton { get; set; } 
        public IRPSButton<WorkflowInstanceTrackingQueryView,CleanWorkflowHistoryDataDialogView> CleanWorkflowHistoryDataNavigationCommandButton { get; set; } 
        public WorkflowInstanceTrackingCollectionEditor<WorkflowInstanceTrackingQueryView,CleanWorkflowHistoryDataDialogView> WorkflowInstanceTracking { get; set; } 
        public WorkflowInstanceTracking Screen { get; set; }
        public WorkflowInstanceTrackingQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class WorkflowInstanceTrackingCollectionEditor<WorkflowInstanceTrackingQueryView,CleanWorkflowHistoryDataDialogView>:RPSCollectionEditor<WorkflowInstanceTrackingQueryView,CleanWorkflowHistoryDataDialogView> where WorkflowInstanceTrackingQueryView : class, IView where CleanWorkflowHistoryDataDialogView : class, IView
    {
        public  WorkflowInstanceTrackingGridView<WorkflowInstanceTrackingQueryView,CleanWorkflowHistoryDataDialogView> GridView {get;set;}
    }
    public partial class WorkflowInstanceTrackingGridView <WorkflowInstanceTrackingQueryView,CleanWorkflowHistoryDataDialogView> :  RPSGridView<WorkflowInstanceTrackingQueryView,CleanWorkflowHistoryDataDialogView> where WorkflowInstanceTrackingQueryView : class, IView where CleanWorkflowHistoryDataDialogView : class, IView
    {
        public WorkflowInstanceTrackingGridView(WorkflowInstanceTrackingQueryView currentView,CleanWorkflowHistoryDataDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            StateDate = RPSControlFactory.CreateRPSGridTextBox<WorkflowInstanceTrackingQueryView>("","#ff3fd532-d6b1-4af9-b49d-e878c5bf7d93 .ag-row[role='row']@ROWINDEX [col-id='cStateDate']","",false, this.CurrentView);
 
            Label = RPSControlFactory.CreateRPSGridTextBox<WorkflowInstanceTrackingQueryView>("","#ff3fd532-d6b1-4af9-b49d-e878c5bf7d93 .ag-row[role='row']@ROWINDEX [col-id='cWorkflowTracking_Label']","",false, this.CurrentView);
 
            CreationDate = RPSControlFactory.CreateRPSGridTextBox<WorkflowInstanceTrackingQueryView>("","#ff3fd532-d6b1-4af9-b49d-e878c5bf7d93 .ag-row[role='row']@ROWINDEX [col-id='cCreationDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<WorkflowInstanceTrackingQueryView> StateDate { get; set; } 
        public IRPSGridTextBox<WorkflowInstanceTrackingQueryView> Label { get; set; } 
        public IRPSGridTextBox<WorkflowInstanceTrackingQueryView> CreationDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class WorkflowInstanceTrackingDetailsView : View
    {
        public WorkflowInstanceTrackingDetailsView(WorkflowInstanceTracking screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            eTaskState = RPSControlFactory.CreateRPSEnumComboBox<WorkflowInstanceTrackingDetailsView>("892e2333-2751-4fb6-be46-aaa92d13fe92","","",false, this);
 
            eTaskPriority = RPSControlFactory.CreateRPSEnumComboBox<WorkflowInstanceTrackingDetailsView>("1da97ef2-b69b-4be3-b697-88f9748762b7","","",false, this);
 
            CreationDate = RPSControlFactory.CreateRPSTextBox<WorkflowInstanceTrackingDetailsView>("876d2570-8163-4d93-93dc-173f3d80751b","","",false, this);
 
            CreationTime = RPSControlFactory.CreateRPSTextBox<WorkflowInstanceTrackingDetailsView>("d5d11b7a-d489-41c3-842b-ce5c049e85d0","","",false, this);
 
            DueDate = RPSControlFactory.CreateRPSTextBox<WorkflowInstanceTrackingDetailsView>("4f04f9ab-2af1-499e-a7b9-fde9fc273809","","",false, this);
 
            DueTime = RPSControlFactory.CreateRPSTextBox<WorkflowInstanceTrackingDetailsView>("7bd1e3c7-7edf-4fa4-a06a-00c603900eb6","","",false, this);
 
            EndDate = RPSControlFactory.CreateRPSTextBox<WorkflowInstanceTrackingDetailsView>("5901e6bf-d514-49ff-a59f-91b0345aa1af","","",false, this);
 
            EndTime = RPSControlFactory.CreateRPSTextBox<WorkflowInstanceTrackingDetailsView>("d1a19f81-9794-4512-9c35-29f14f159b8c","","",false, this);
 
            Arguments = RPSControlFactory.CreateRPSTextBox<WorkflowInstanceTrackingDetailsView>("40878f66-41bf-4ef3-b10b-a3ce1f74f70d","","",false, this);
 
            Exception = RPSControlFactory.CreateRPSTextBox<WorkflowInstanceTrackingDetailsView>("2434a0dd-18b0-49ec-bfc4-289fa43abca8","","",false, this);
 
            TerminateReason = RPSControlFactory.CreateRPSTextBox<WorkflowInstanceTrackingDetailsView>("ab8b5f46-0ca0-43a2-9340-96a66e9e239f","","",false, this);
 
            Variables = RPSControlFactory.CreateRPSTextBox<WorkflowInstanceTrackingDetailsView>("874f1fa5-c014-4887-a5b2-40503f210c11","","",false, this);
 
            CollectionInit params_WorkflowInstanceHistory = new CollectionInit(){IDDescriptor = "ec0ef45a-4311-4585-b545-8bb7b94d615e",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            WorkflowInstanceHistory = RPSControlFactory.RPSCreateCollection<WorkflowInstanceTrackingDetailsView>( params_WorkflowInstanceHistory,this);
 
            CollectionInit params_WorkflowInstanceTrackingEvents = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="227ebb4f-2cd5-411a-bbe4-bbd3377dab6e",CSSSelectorGrid="",XPathGrid=""};
            WorkflowInstanceTrackingEvents = RPSControlFactory.RPSCreateCollectionWithGrid<WorkflowInstanceTrackingEventsCollectionEditor<WorkflowInstanceTrackingDetailsView>,WorkflowInstanceTrackingDetailsView>( params_WorkflowInstanceTrackingEvents,this);
 
            TrackingHistory = RPSControlFactory.CreateRPSSection<WorkflowInstanceTrackingDetailsView>( "","ul li[rpsid='6fb95702-234e-4f6f-9e89-0ed1146eeae3']","",this);
 
            TrackingEvents = RPSControlFactory.CreateRPSSection<WorkflowInstanceTrackingDetailsView>( "","ul li[rpsid='17e3a510-2b7c-4019-9432-310676d50d82']","",this);
 

        }
        public IRPSComboBox<WorkflowInstanceTrackingDetailsView> eTaskState { get; set; } 
        public IRPSComboBox<WorkflowInstanceTrackingDetailsView> eTaskPriority { get; set; } 
        public IRPSTextBox<WorkflowInstanceTrackingDetailsView> CreationDate { get; set; } 
        public IRPSTextBox<WorkflowInstanceTrackingDetailsView> CreationTime { get; set; } 
        public IRPSTextBox<WorkflowInstanceTrackingDetailsView> DueDate { get; set; } 
        public IRPSTextBox<WorkflowInstanceTrackingDetailsView> DueTime { get; set; } 
        public IRPSTextBox<WorkflowInstanceTrackingDetailsView> EndDate { get; set; } 
        public IRPSTextBox<WorkflowInstanceTrackingDetailsView> EndTime { get; set; } 
        public IRPSTextBox<WorkflowInstanceTrackingDetailsView> Arguments { get; set; } 
        public IRPSTextBox<WorkflowInstanceTrackingDetailsView> Exception { get; set; } 
        public IRPSTextBox<WorkflowInstanceTrackingDetailsView> TerminateReason { get; set; } 
        public IRPSTextBox<WorkflowInstanceTrackingDetailsView> Variables { get; set; } 
        public IRPSCollectionEditor<WorkflowInstanceTrackingDetailsView> WorkflowInstanceHistory { get; set; } 
        public WorkflowInstanceTrackingEventsCollectionEditor<WorkflowInstanceTrackingDetailsView> WorkflowInstanceTrackingEvents { get; set; } 
        public IRPSSection<WorkflowInstanceTrackingDetailsView> TrackingHistory { get; set; } 
        public IRPSSection<WorkflowInstanceTrackingDetailsView> TrackingEvents { get; set; } 
        public WorkflowInstanceTracking Screen { get; set; }
        public WorkflowInstanceTrackingDetailsView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class WorkflowInstanceTrackingEventsCollectionEditor<WorkflowInstanceTrackingDetailsView>:RPSCollectionEditor<WorkflowInstanceTrackingDetailsView> where WorkflowInstanceTrackingDetailsView : class, IView
    {
        public  WorkflowInstanceTrackingEventsGridView<WorkflowInstanceTrackingDetailsView> GridView {get;set;}
    }
    public partial class WorkflowInstanceTrackingEventsGridView <WorkflowInstanceTrackingDetailsView> :  RPSGridView<WorkflowInstanceTrackingDetailsView> where WorkflowInstanceTrackingDetailsView : class, IView
    {
        public WorkflowInstanceTrackingEventsGridView(WorkflowInstanceTrackingDetailsView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            WorkflowTrackingEvent_EventType = RPSControlFactory.CreateRPSGridTextBox<WorkflowInstanceTrackingDetailsView>("","#227ebb4f-2cd5-411a-bbe4-bbd3377dab6e .ag-row[role='row']@ROWINDEX [col-id='cWorkflowTrackingEvent_EventType']","",false, this.CurrentView);
 
            WorkflowTrackingEvent_ActivityName = RPSControlFactory.CreateRPSGridTextBox<WorkflowInstanceTrackingDetailsView>("","#227ebb4f-2cd5-411a-bbe4-bbd3377dab6e .ag-row[role='row']@ROWINDEX [col-id='cWorkflowTrackingEvent_ActivityName']","",false, this.CurrentView);
 
            WorkflowTrackingEvent_State = RPSControlFactory.CreateRPSGridTextBox<WorkflowInstanceTrackingDetailsView>("","#227ebb4f-2cd5-411a-bbe4-bbd3377dab6e .ag-row[role='row']@ROWINDEX [col-id='cWorkflowTrackingEvent_State']","",false, this.CurrentView);
 
            WorkflowTrackingEvent_EventDate = RPSControlFactory.CreateRPSGridTextBox<WorkflowInstanceTrackingDetailsView>("","#227ebb4f-2cd5-411a-bbe4-bbd3377dab6e .ag-row[role='row']@ROWINDEX [col-id='cWorkflowTrackingEvent_EventDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<WorkflowInstanceTrackingDetailsView> WorkflowTrackingEvent_EventType { get; set; } 
        public IRPSGridTextBox<WorkflowInstanceTrackingDetailsView> WorkflowTrackingEvent_ActivityName { get; set; } 
        public IRPSGridTextBox<WorkflowInstanceTrackingDetailsView> WorkflowTrackingEvent_State { get; set; } 
        public IRPSGridTextBox<WorkflowInstanceTrackingDetailsView> WorkflowTrackingEvent_EventDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class CleanWorkflowHistoryDataDialogView : View
    {
        public CleanWorkflowHistoryDataDialogView(WorkflowInstanceTracking screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIOptAllWorkflows = RPSControlFactory.CreateRPSOption<CleanWorkflowHistoryDataDialogView>( "f77438e5-6217-40f9-87d6-60482e4d6c29","","",this);
 
            UIOptOneWorkflow = RPSControlFactory.CreateRPSOption<CleanWorkflowHistoryDataDialogView>( "87ee5fd5-41c6-4208-9c47-9098befe5ede","","",this);
 
            UIWorkflow = RPSControlFactory.CreateRPSComboBox<CleanWorkflowHistoryDataDialogView>("ba459a8f-55a5-4c50-bdb9-4ec831306713","","",false, this);
 
            UIOptAllVersions = RPSControlFactory.CreateRPSOption<CleanWorkflowHistoryDataDialogView>( "f10e5a41-8af1-45a5-ab2d-3541c31e08ba","","",this);
 
            UIOptOneVersion = RPSControlFactory.CreateRPSOption<CleanWorkflowHistoryDataDialogView>( "35066b7a-29d9-49b1-9950-f160777c18cf","","",this);
 
            UIWorkflowVersion = RPSControlFactory.CreateRPSComboBox<CleanWorkflowHistoryDataDialogView>("a640b075-6922-4b06-b615-eec0ea591251","","",false, this);
 
            UIOptAllDates = RPSControlFactory.CreateRPSOption<CleanWorkflowHistoryDataDialogView>( "7dd8059a-c169-4008-8d0f-ccd3ee69bb15","","",this);
 
            OPOneDate = RPSControlFactory.CreateRPSOption<CleanWorkflowHistoryDataDialogView>( "72ddb4e2-9765-473b-81b6-030714b1ea64","","",this);
 
            UIDateFilter = RPSControlFactory.CreateRPSTextBox<CleanWorkflowHistoryDataDialogView>("eeb32bb5-f56c-47ad-bad6-7e112fda0bd1","","",false, this);
 

        }
        public IRPSOption<CleanWorkflowHistoryDataDialogView> UIOptAllWorkflows { get; set; } 
        public IRPSOption<CleanWorkflowHistoryDataDialogView> UIOptOneWorkflow { get; set; } 
        public IRPSComboBox<CleanWorkflowHistoryDataDialogView> UIWorkflow { get; set; } 
        public IRPSOption<CleanWorkflowHistoryDataDialogView> UIOptAllVersions { get; set; } 
        public IRPSOption<CleanWorkflowHistoryDataDialogView> UIOptOneVersion { get; set; } 
        public IRPSComboBox<CleanWorkflowHistoryDataDialogView> UIWorkflowVersion { get; set; } 
        public IRPSOption<CleanWorkflowHistoryDataDialogView> UIOptAllDates { get; set; } 
        public IRPSOption<CleanWorkflowHistoryDataDialogView> OPOneDate { get; set; } 
        public IRPSTextBox<CleanWorkflowHistoryDataDialogView> UIDateFilter { get; set; } 
        public WorkflowInstanceTracking Screen { get; set; }
        public CleanWorkflowHistoryDataDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}