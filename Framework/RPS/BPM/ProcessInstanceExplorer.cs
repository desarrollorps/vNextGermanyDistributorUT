    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.BPM.ProcessInstanceExplorer
{
    //RPS VERSION 1.0.0.0
    public partial class ProcessInstanceExplorer:Screen
    {
        public ProcessInstanceExplorer():base()
        {
            this.URL = "bpm.processinstanceexplorer";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ProcessInstanceExplorerQueryView  = new ProcessInstanceExplorerQueryView(this); 
            ProcessInstanceExplorerQueryView.InitializeControls(); 
           
        }
      
            public ProcessInstanceExplorerQueryView ProcessInstanceExplorerQueryView {get; set; } 
    }
            
    public partial class ProcessInstanceExplorerQueryView : View
    {
        public ProcessInstanceExplorerQueryView(ProcessInstanceExplorer screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDProcess = RPSControlFactory.CreateRPSComboBox<ProcessInstanceExplorerQueryView>("db86f89e-b400-4ba5-a240-e2e7416d33c2","","",false, this);
 
            LabelFilter = RPSControlFactory.CreateRPSTextBox<ProcessInstanceExplorerQueryView>("955de0bc-e439-419f-9070-5efec432383d","","",false, this);
 
            Current = RPSControlFactory.CreateRPSOption<ProcessInstanceExplorerQueryView>( "026c08d3-cd18-47f8-bf4b-1e3a199917ef","","",this);
 
            Instances = RPSControlFactory.CreateRPSOption<ProcessInstanceExplorerQueryView>( "77c08c07-4bd6-4ebd-94e1-fe2edcda8990","","",this);
 
            From = RPSControlFactory.CreateRPSTextBox<ProcessInstanceExplorerQueryView>("528d4ed6-f05c-419f-a9a8-dde70c4b3bcd","","",false, this);
 
            To = RPSControlFactory.CreateRPSTextBox<ProcessInstanceExplorerQueryView>("45c75aeb-61f0-454b-87ab-27b5b172b895","","",false, this);
 
            StartDateTime = RPSControlFactory.CreateRPSTextBox<ProcessInstanceExplorerQueryView>("de9c920c-bacf-46bb-9121-536b24939f6c","","",false, this);
 
            EndDateTime = RPSControlFactory.CreateRPSTextBox<ProcessInstanceExplorerQueryView>("433e18d0-dafb-42fd-9fd7-ffd094a7886e","","",false, this);
 
            InstanceLabel = RPSControlFactory.CreateRPSTextBox<ProcessInstanceExplorerQueryView>("f04d6938-368b-44f4-81c0-116167b85065","","",false, this);
 
            CollectionInit params_ProcessInstanceExplorer = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="e0f911e8-15d3-4564-9327-905e5d6f9698",CSSSelectorGrid="",XPathGrid=""};
            ProcessInstanceExplorer = RPSControlFactory.RPSCreateCollectionWithGrid<ProcessInstanceExplorerCollectionEditor<ProcessInstanceExplorerQueryView>,ProcessInstanceExplorerQueryView>( params_ProcessInstanceExplorer,this);
 
            CollectionInit params_GetProcessInstanceData = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0d176855-b7c9-4bb6-99df-cba34a8fd53d",CSSSelectorGrid="",XPathGrid=""};
            GetProcessInstanceData = RPSControlFactory.RPSCreateCollectionWithGrid<GetProcessInstanceDataCollectionEditor<ProcessInstanceExplorerQueryView>,ProcessInstanceExplorerQueryView>( params_GetProcessInstanceData,this);
 
            CollectionInit params_GetProcessInstanceDataDetail = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="24d77d79-e98a-4499-949a-eef0cab8bc0a",CSSSelectorGrid="",XPathGrid=""};
            GetProcessInstanceDataDetail = RPSControlFactory.RPSCreateCollectionWithGrid<GetProcessInstanceDataDetailCollectionEditor<ProcessInstanceExplorerQueryView>,ProcessInstanceExplorerQueryView>( params_GetProcessInstanceDataDetail,this);
 
            CollectionInit params_ProcessInstanceTasks = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c2d1042c-9a8c-4689-a3d9-c437a1deae2d",CSSSelectorGrid="",XPathGrid=""};
            ProcessInstanceTasks = RPSControlFactory.RPSCreateCollectionWithGrid<ProcessInstanceTasksCollectionEditor<ProcessInstanceExplorerQueryView>,ProcessInstanceExplorerQueryView>( params_ProcessInstanceTasks,this);
 
            CollectionInit params_ProcessInstanceIncidents = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="de1e4e90-a984-4592-9ade-2f20ff4d5d68",CSSSelectorGrid="",XPathGrid=""};
            ProcessInstanceIncidents = RPSControlFactory.RPSCreateCollectionWithGrid<ProcessInstanceIncidentsCollectionEditor<ProcessInstanceExplorerQueryView>,ProcessInstanceExplorerQueryView>( params_ProcessInstanceIncidents,this);
 
            Section = RPSControlFactory.CreateRPSSection<ProcessInstanceExplorerQueryView>( "","ul li[rpsid='4c1e889d-db86-4567-bc22-f77828af5412']","",this);
 
            SelectedProcessSection = RPSControlFactory.CreateRPSSection<ProcessInstanceExplorerQueryView>( "","ul li[rpsid='c7a2fab5-9715-48bf-8b8a-36c0870b42fe']","",this);
 
            TaskSection = RPSControlFactory.CreateRPSSection<ProcessInstanceExplorerQueryView>( "","ul li[rpsid='8e0330d4-d293-4837-bc2e-18803eb9d409']","",this);
 
            IncidencesSection = RPSControlFactory.CreateRPSSection<ProcessInstanceExplorerQueryView>( "","ul li[rpsid='1d85023f-3eeb-4e13-89b4-d61afa9b0155']","",this);
 

        }
        public IRPSComboBox<ProcessInstanceExplorerQueryView> IDProcess { get; set; } 
        public IRPSTextBox<ProcessInstanceExplorerQueryView> LabelFilter { get; set; } 
        public IRPSOption<ProcessInstanceExplorerQueryView> Current { get; set; } 
        public IRPSOption<ProcessInstanceExplorerQueryView> Instances { get; set; } 
        public IRPSTextBox<ProcessInstanceExplorerQueryView> From { get; set; } 
        public IRPSTextBox<ProcessInstanceExplorerQueryView> To { get; set; } 
        public IRPSTextBox<ProcessInstanceExplorerQueryView> StartDateTime { get; set; } 
        public IRPSTextBox<ProcessInstanceExplorerQueryView> EndDateTime { get; set; } 
        public IRPSTextBox<ProcessInstanceExplorerQueryView> InstanceLabel { get; set; } 
        public ProcessInstanceExplorerCollectionEditor<ProcessInstanceExplorerQueryView> ProcessInstanceExplorer { get; set; } 
        public GetProcessInstanceDataCollectionEditor<ProcessInstanceExplorerQueryView> GetProcessInstanceData { get; set; } 
        public GetProcessInstanceDataDetailCollectionEditor<ProcessInstanceExplorerQueryView> GetProcessInstanceDataDetail { get; set; } 
        public ProcessInstanceTasksCollectionEditor<ProcessInstanceExplorerQueryView> ProcessInstanceTasks { get; set; } 
        public ProcessInstanceIncidentsCollectionEditor<ProcessInstanceExplorerQueryView> ProcessInstanceIncidents { get; set; } 
        public IRPSSection<ProcessInstanceExplorerQueryView> Section { get; set; } 
        public IRPSSection<ProcessInstanceExplorerQueryView> SelectedProcessSection { get; set; } 
        public IRPSSection<ProcessInstanceExplorerQueryView> TaskSection { get; set; } 
        public IRPSSection<ProcessInstanceExplorerQueryView> IncidencesSection { get; set; } 
        public ProcessInstanceExplorer Screen { get; set; }
        public ProcessInstanceExplorerQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ProcessInstanceExplorerCollectionEditor<ProcessInstanceExplorerQueryView>:RPSCollectionEditor<ProcessInstanceExplorerQueryView> where ProcessInstanceExplorerQueryView : class, IView
    {
        public  ProcessInstanceExplorerGridView<ProcessInstanceExplorerQueryView> GridView {get;set;}
    }
    public partial class ProcessInstanceExplorerGridView <ProcessInstanceExplorerQueryView> :  RPSGridView<ProcessInstanceExplorerQueryView> where ProcessInstanceExplorerQueryView : class, IView
    {
        public ProcessInstanceExplorerGridView(ProcessInstanceExplorerQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            TotalInstances = RPSControlFactory.CreateRPSGridFormattedTextBox<ProcessInstanceExplorerQueryView>("","#e0f911e8-15d3-4564-9327-905e5d6f9698 .ag-row[role='row']@ROWINDEX [col-id='cTotalInstances']","",false, this.CurrentView);
 
            ExecutingInstances = RPSControlFactory.CreateRPSGridFormattedTextBox<ProcessInstanceExplorerQueryView>("","#e0f911e8-15d3-4564-9327-905e5d6f9698 .ag-row[role='row']@ROWINDEX [col-id='cExecutingInstances']","",false, this.CurrentView);
 
            TotalIncidents = RPSControlFactory.CreateRPSGridFormattedTextBox<ProcessInstanceExplorerQueryView>("","#e0f911e8-15d3-4564-9327-905e5d6f9698 .ag-row[role='row']@ROWINDEX [col-id='cTotalIncidents']","",false, this.CurrentView);
 
            OpenIncidents = RPSControlFactory.CreateRPSGridFormattedTextBox<ProcessInstanceExplorerQueryView>("","#e0f911e8-15d3-4564-9327-905e5d6f9698 .ag-row[role='row']@ROWINDEX [col-id='cOpenIncidents']","",false, this.CurrentView);
 
            OpenBlockingIncidents = RPSControlFactory.CreateRPSGridFormattedTextBox<ProcessInstanceExplorerQueryView>("","#e0f911e8-15d3-4564-9327-905e5d6f9698 .ag-row[role='row']@ROWINDEX [col-id='cOpenBlockingIncidents']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ProcessInstanceExplorerQueryView> TotalInstances { get; set; } 
        public IRPSGridTextBox<ProcessInstanceExplorerQueryView> ExecutingInstances { get; set; } 
        public IRPSGridTextBox<ProcessInstanceExplorerQueryView> TotalIncidents { get; set; } 
        public IRPSGridTextBox<ProcessInstanceExplorerQueryView> OpenIncidents { get; set; } 
        public IRPSGridTextBox<ProcessInstanceExplorerQueryView> OpenBlockingIncidents { get; set; } 
                     
    }
 
        public partial class GetProcessInstanceDataCollectionEditor<ProcessInstanceExplorerQueryView>:RPSCollectionEditor<ProcessInstanceExplorerQueryView> where ProcessInstanceExplorerQueryView : class, IView
    {
        public  GetProcessInstanceDataGridView<ProcessInstanceExplorerQueryView> GridView {get;set;}
    }
    public partial class GetProcessInstanceDataGridView <ProcessInstanceExplorerQueryView> :  RPSGridView<ProcessInstanceExplorerQueryView> where ProcessInstanceExplorerQueryView : class, IView
    {
        public GetProcessInstanceDataGridView(ProcessInstanceExplorerQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            StartDateTime = RPSControlFactory.CreateRPSGridTextBox<ProcessInstanceExplorerQueryView>("","#0d176855-b7c9-4bb6-99df-cba34a8fd53d .ag-row[role='row']@ROWINDEX [col-id='cStartDateTime']","",false, this.CurrentView);
 
            EndDateTime = RPSControlFactory.CreateRPSGridTextBox<ProcessInstanceExplorerQueryView>("","#0d176855-b7c9-4bb6-99df-cba34a8fd53d .ag-row[role='row']@ROWINDEX [col-id='cEndDateTime']","",false, this.CurrentView);
 
            InstanceLabel = RPSControlFactory.CreateRPSGridTextBox<ProcessInstanceExplorerQueryView>("","#0d176855-b7c9-4bb6-99df-cba34a8fd53d .ag-row[role='row']@ROWINDEX [col-id='cInstanceLabel']","",false, this.CurrentView);
 
            PhaseStatus1 = RPSControlFactory.CreateRPSGridTextBox<ProcessInstanceExplorerQueryView>("","#0d176855-b7c9-4bb6-99df-cba34a8fd53d .ag-row[role='row']@ROWINDEX [col-id='cPhaseStatus1']","",false, this.CurrentView);
 
            PhaseStatus2 = RPSControlFactory.CreateRPSGridTextBox<ProcessInstanceExplorerQueryView>("","#0d176855-b7c9-4bb6-99df-cba34a8fd53d .ag-row[role='row']@ROWINDEX [col-id='cPhaseStatus2']","",false, this.CurrentView);
 
            PhaseStatus3 = RPSControlFactory.CreateRPSGridTextBox<ProcessInstanceExplorerQueryView>("","#0d176855-b7c9-4bb6-99df-cba34a8fd53d .ag-row[role='row']@ROWINDEX [col-id='cPhaseStatus3']","",false, this.CurrentView);
 
            PhaseStatus4 = RPSControlFactory.CreateRPSGridTextBox<ProcessInstanceExplorerQueryView>("","#0d176855-b7c9-4bb6-99df-cba34a8fd53d .ag-row[role='row']@ROWINDEX [col-id='cPhaseStatus4']","",false, this.CurrentView);
 
            PhaseStatus5 = RPSControlFactory.CreateRPSGridTextBox<ProcessInstanceExplorerQueryView>("","#0d176855-b7c9-4bb6-99df-cba34a8fd53d .ag-row[role='row']@ROWINDEX [col-id='cPhaseStatus5']","",false, this.CurrentView);
 
            PhaseStatus6 = RPSControlFactory.CreateRPSGridTextBox<ProcessInstanceExplorerQueryView>("","#0d176855-b7c9-4bb6-99df-cba34a8fd53d .ag-row[role='row']@ROWINDEX [col-id='cPhaseStatus6']","",false, this.CurrentView);
 
            PhaseStatus7 = RPSControlFactory.CreateRPSGridTextBox<ProcessInstanceExplorerQueryView>("","#0d176855-b7c9-4bb6-99df-cba34a8fd53d .ag-row[role='row']@ROWINDEX [col-id='cPhaseStatus7']","",false, this.CurrentView);
 
            PhaseStatus8 = RPSControlFactory.CreateRPSGridTextBox<ProcessInstanceExplorerQueryView>("","#0d176855-b7c9-4bb6-99df-cba34a8fd53d .ag-row[role='row']@ROWINDEX [col-id='cPhaseStatus8']","",false, this.CurrentView);
 
            PhaseStatus9 = RPSControlFactory.CreateRPSGridTextBox<ProcessInstanceExplorerQueryView>("","#0d176855-b7c9-4bb6-99df-cba34a8fd53d .ag-row[role='row']@ROWINDEX [col-id='cPhaseStatus9']","",false, this.CurrentView);
 
            PhaseStatus10 = RPSControlFactory.CreateRPSGridTextBox<ProcessInstanceExplorerQueryView>("","#0d176855-b7c9-4bb6-99df-cba34a8fd53d .ag-row[role='row']@ROWINDEX [col-id='cPhaseStatus10']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ProcessInstanceExplorerQueryView> StartDateTime { get; set; } 
        public IRPSGridTextBox<ProcessInstanceExplorerQueryView> EndDateTime { get; set; } 
        public IRPSGridTextBox<ProcessInstanceExplorerQueryView> InstanceLabel { get; set; } 
        public IRPSGridTextBox<ProcessInstanceExplorerQueryView> PhaseStatus1 { get; set; } 
        public IRPSGridTextBox<ProcessInstanceExplorerQueryView> PhaseStatus2 { get; set; } 
        public IRPSGridTextBox<ProcessInstanceExplorerQueryView> PhaseStatus3 { get; set; } 
        public IRPSGridTextBox<ProcessInstanceExplorerQueryView> PhaseStatus4 { get; set; } 
        public IRPSGridTextBox<ProcessInstanceExplorerQueryView> PhaseStatus5 { get; set; } 
        public IRPSGridTextBox<ProcessInstanceExplorerQueryView> PhaseStatus6 { get; set; } 
        public IRPSGridTextBox<ProcessInstanceExplorerQueryView> PhaseStatus7 { get; set; } 
        public IRPSGridTextBox<ProcessInstanceExplorerQueryView> PhaseStatus8 { get; set; } 
        public IRPSGridTextBox<ProcessInstanceExplorerQueryView> PhaseStatus9 { get; set; } 
        public IRPSGridTextBox<ProcessInstanceExplorerQueryView> PhaseStatus10 { get; set; } 
                     
    }
 
        public partial class GetProcessInstanceDataDetailCollectionEditor<ProcessInstanceExplorerQueryView>:RPSCollectionEditor<ProcessInstanceExplorerQueryView> where ProcessInstanceExplorerQueryView : class, IView
    {
        public  GetProcessInstanceDataDetailGridView<ProcessInstanceExplorerQueryView> GridView {get;set;}
    }
    public partial class GetProcessInstanceDataDetailGridView <ProcessInstanceExplorerQueryView> :  RPSGridView<ProcessInstanceExplorerQueryView> where ProcessInstanceExplorerQueryView : class, IView
    {
        public GetProcessInstanceDataDetailGridView(ProcessInstanceExplorerQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Phase = RPSControlFactory.CreateRPSGridTextBox<ProcessInstanceExplorerQueryView>("","#24d77d79-e98a-4499-949a-eef0cab8bc0a .ag-row[role='row']@ROWINDEX [col-id='cPhase']","",false, this.CurrentView);
 
            Status = RPSControlFactory.CreateRPSGridTextBox<ProcessInstanceExplorerQueryView>("","#24d77d79-e98a-4499-949a-eef0cab8bc0a .ag-row[role='row']@ROWINDEX [col-id='cStatus']","",false, this.CurrentView);
 
            CompletedTasks = RPSControlFactory.CreateRPSGridFormattedTextBox<ProcessInstanceExplorerQueryView>("","#24d77d79-e98a-4499-949a-eef0cab8bc0a .ag-row[role='row']@ROWINDEX [col-id='cCompletedTasks']","",false, this.CurrentView);
 
            ExecutingTasks = RPSControlFactory.CreateRPSGridFormattedTextBox<ProcessInstanceExplorerQueryView>("","#24d77d79-e98a-4499-949a-eef0cab8bc0a .ag-row[role='row']@ROWINDEX [col-id='cExecutingTasks']","",false, this.CurrentView);
 
            ClosedIncidents = RPSControlFactory.CreateRPSGridFormattedTextBox<ProcessInstanceExplorerQueryView>("","#24d77d79-e98a-4499-949a-eef0cab8bc0a .ag-row[role='row']@ROWINDEX [col-id='cClosedIncidents']","",false, this.CurrentView);
 
            OpenIncidents = RPSControlFactory.CreateRPSGridFormattedTextBox<ProcessInstanceExplorerQueryView>("","#24d77d79-e98a-4499-949a-eef0cab8bc0a .ag-row[role='row']@ROWINDEX [col-id='cOpenIncidents']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ProcessInstanceExplorerQueryView> Phase { get; set; } 
        public IRPSGridTextBox<ProcessInstanceExplorerQueryView> Status { get; set; } 
        public IRPSGridTextBox<ProcessInstanceExplorerQueryView> CompletedTasks { get; set; } 
        public IRPSGridTextBox<ProcessInstanceExplorerQueryView> ExecutingTasks { get; set; } 
        public IRPSGridTextBox<ProcessInstanceExplorerQueryView> ClosedIncidents { get; set; } 
        public IRPSGridTextBox<ProcessInstanceExplorerQueryView> OpenIncidents { get; set; } 
                     
    }
 
        public partial class ProcessInstanceTasksCollectionEditor<ProcessInstanceExplorerQueryView>:RPSCollectionEditor<ProcessInstanceExplorerQueryView> where ProcessInstanceExplorerQueryView : class, IView
    {
        public  ProcessInstanceTasksGridView<ProcessInstanceExplorerQueryView> GridView {get;set;}
    }
    public partial class ProcessInstanceTasksGridView <ProcessInstanceExplorerQueryView> :  RPSGridView<ProcessInstanceExplorerQueryView> where ProcessInstanceExplorerQueryView : class, IView
    {
        public ProcessInstanceTasksGridView(ProcessInstanceExplorerQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CreationDateTime = RPSControlFactory.CreateRPSGridTextBox<ProcessInstanceExplorerQueryView>("","#c2d1042c-9a8c-4689-a3d9-c437a1deae2d .ag-row[role='row']@ROWINDEX [col-id='cCreationDateTime']","",false, this.CurrentView);
 
            EndDateTime = RPSControlFactory.CreateRPSGridTextBox<ProcessInstanceExplorerQueryView>("","#c2d1042c-9a8c-4689-a3d9-c437a1deae2d .ag-row[role='row']@ROWINDEX [col-id='cEndDateTime']","",false, this.CurrentView);
 
            Priority = RPSControlFactory.CreateRPSGridFormattedTextBox<ProcessInstanceExplorerQueryView>("","#c2d1042c-9a8c-4689-a3d9-c437a1deae2d .ag-row[role='row']@ROWINDEX [col-id='cPriority']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ProcessInstanceExplorerQueryView> CreationDateTime { get; set; } 
        public IRPSGridTextBox<ProcessInstanceExplorerQueryView> EndDateTime { get; set; } 
        public IRPSGridTextBox<ProcessInstanceExplorerQueryView> Priority { get; set; } 
                     
    }
 
        public partial class ProcessInstanceIncidentsCollectionEditor<ProcessInstanceExplorerQueryView>:RPSCollectionEditor<ProcessInstanceExplorerQueryView> where ProcessInstanceExplorerQueryView : class, IView
    {
        public  ProcessInstanceIncidentsGridView<ProcessInstanceExplorerQueryView> GridView {get;set;}
    }
    public partial class ProcessInstanceIncidentsGridView <ProcessInstanceExplorerQueryView> :  RPSGridView<ProcessInstanceExplorerQueryView> where ProcessInstanceExplorerQueryView : class, IView
    {
        public ProcessInstanceIncidentsGridView(ProcessInstanceExplorerQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CreationDateTime = RPSControlFactory.CreateRPSGridTextBox<ProcessInstanceExplorerQueryView>("","#de1e4e90-a984-4592-9ade-2f20ff4d5d68 .ag-row[role='row']@ROWINDEX [col-id='cCreationDateTime']","",false, this.CurrentView);
 
            EndDateTime = RPSControlFactory.CreateRPSGridTextBox<ProcessInstanceExplorerQueryView>("","#de1e4e90-a984-4592-9ade-2f20ff4d5d68 .ag-row[role='row']@ROWINDEX [col-id='cEndDateTime']","",false, this.CurrentView);
 
            State = RPSControlFactory.CreateRPSGridTextBox<ProcessInstanceExplorerQueryView>("","#de1e4e90-a984-4592-9ade-2f20ff4d5d68 .ag-row[role='row']@ROWINDEX [col-id='cState']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ProcessInstanceExplorerQueryView> CreationDateTime { get; set; } 
        public IRPSGridTextBox<ProcessInstanceExplorerQueryView> EndDateTime { get; set; } 
        public IRPSGridTextBox<ProcessInstanceExplorerQueryView> State { get; set; } 
                     
    }
 
    }
  
    

}