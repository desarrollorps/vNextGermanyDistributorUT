    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.BPM.Process
{
    //RPS VERSION 1.0.0.0
    public partial class Process:Screen
    {
        public Process():base()
        {
            this.URL = "bpm.process";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ProcessCollectionView  = new ProcessCollectionView(this); 
            ProcessEntityView  = new ProcessEntityView(this); 
            ProcessVersionView  = new ProcessVersionView(this); 
            ProcessIssueView  = new ProcessIssueView(this); 
            ProcessPhaseView  = new ProcessPhaseView(this); 
            ProcessTaskView  = new ProcessTaskView(this); 
            ProcessIndicatorView  = new ProcessIndicatorView(this); 
            DuplicateProcessIndicatorPeriodDialogView  = new DuplicateProcessIndicatorPeriodDialogView(this); 
            ProcessCollectionView.InitializeControls(); 
            ProcessEntityView.InitializeControls(); 
            ProcessVersionView.InitializeControls(); 
            ProcessIssueView.InitializeControls(); 
            ProcessPhaseView.InitializeControls(); 
            ProcessTaskView.InitializeControls(); 
            ProcessIndicatorView.InitializeControls(); 
            DuplicateProcessIndicatorPeriodDialogView.InitializeControls(); 
           
        }
      
            public ProcessCollectionView ProcessCollectionView {get; set; } 
            public ProcessEntityView ProcessEntityView {get; set; } 
            public ProcessVersionView ProcessVersionView {get; set; } 
            public ProcessIssueView ProcessIssueView {get; set; } 
            public ProcessPhaseView ProcessPhaseView {get; set; } 
            public ProcessTaskView ProcessTaskView {get; set; } 
            public ProcessIndicatorView ProcessIndicatorView {get; set; } 
            public DuplicateProcessIndicatorPeriodDialogView DuplicateProcessIndicatorPeriodDialogView {get; set; } 
    }
            
    public partial class ProcessCollectionView : View
    {
        public ProcessCollectionView(Process screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ProcessCollectionView,ProcessEntityView>( this,Screen.ProcessEntityView);
 
            DuplicateProcessIndicatorPeriodNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ProcessCollectionView,DuplicateProcessIndicatorPeriodDialogView>("de5b23f2-3409-42ae-8eb4-9da17629d5e2","","", this,Screen.DuplicateProcessIndicatorPeriodDialogView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "5e22b8b9-7210-43b5-8257-ecb8071c5663",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ProcessCollectionView,ProcessEntityView>( params_MainConsult,this,Screen.ProcessEntityView);
 

        }
        public IRPSButton<ProcessCollectionView,ProcessEntityView> NewButton { get; set; } 
        public IRPSButton<ProcessCollectionView,DuplicateProcessIndicatorPeriodDialogView> DuplicateProcessIndicatorPeriodNavigationCommandButton { get; set; } 
        public IRPSCollectionEditor<ProcessCollectionView,ProcessEntityView> MainConsult { get; set; } 
        public Process Screen { get; set; }
        public ProcessCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ProcessEntityView : View
    {
        public ProcessEntityView(Process screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ProcessEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ProcessEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ProcessEntityView,ProcessCollectionView>( this,Screen.ProcessCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ProcessEntityView,ProcessCollectionView>( this,Screen.ProcessCollectionView);
 
            CodProcess = RPSControlFactory.CreateRPSTextBox<ProcessEntityView>("eddf2164-be98-4194-8d0d-af20c9d2be4f","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ProcessEntityView>("b4557b9b-66f9-4b47-b5ef-2e7dd86eb466","","",false, this);
 
            Priority = RPSControlFactory.CreateRPSEnumComboBox<ProcessEntityView>("600ad8a4-8393-4fd3-8251-178884cd2d8c","","",true, this);
 
            Status = RPSControlFactory.CreateRPSEnumComboBox<ProcessEntityView>("085afd93-8fc3-496b-b491-f05825b1ade1","","",true, this);
 
            Classification = RPSControlFactory.CreateRPSEnumComboBox<ProcessEntityView>("1769303d-3918-4fe5-8d1d-8804367f9b1a","","",true, this);
 
            ProcessType = RPSControlFactory.CreateRPSEnumComboBox<ProcessEntityView>("12eda378-fd8a-4391-97fc-b138dab06669","","",true, this);
 
            Criticality = RPSControlFactory.CreateRPSEnumComboBox<ProcessEntityView>("1b1b7da3-2b22-4764-80f0-574c49cc2811","","",true, this);
 
            Analysis = RPSControlFactory.CreateRPSCheckBox<ProcessEntityView>("f27831ac-58e7-4ebd-a5ce-08b8101772ca","","",true, this);
 
            IsIncidentEnabled = RPSControlFactory.CreateRPSCheckBox<ProcessEntityView>("5cd1f597-b06b-45c9-b60b-495585fe1bdc","","",true, this);
 
            IDDefaultIncindentCategory = RPSControlFactory.CreateRPSEnumComboBox<ProcessEntityView>("b9d35fef-c057-4b95-b268-f854a273449b","","",false, this);
 
            IDIncidentCodingSeries = RPSControlFactory.CreateRPSEnumComboBox<ProcessEntityView>("99b0cabc-0381-4ec4-b4f0-3f976bf9e8fd","","",false, this);
 
            CollectionInit params_ProcessVersions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ef14ae32-7976-498f-b171-ae477bb7848c",CSSSelectorGrid="",XPathGrid=""};
            ProcessVersions = RPSControlFactory.RPSCreateCollectionWithGrid<ProcessVersionsCollectionEditor<ProcessEntityView,ProcessIndicatorView>,ProcessEntityView,ProcessIndicatorView>( params_ProcessVersions,this,Screen.ProcessIndicatorView);
 
            CollectionInit params_ProcessUsers = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="165f9afb-26f3-48ce-ac62-b903851b7edc",CSSSelectorGrid="",XPathGrid=""};
            ProcessUsers = RPSControlFactory.RPSCreateCollectionWithGrid<ProcessUsersCollectionEditor<ProcessEntityView,ProcessIndicatorView>,ProcessEntityView,ProcessIndicatorView>( params_ProcessUsers,this,Screen.ProcessIndicatorView);
 
            CollectionInit params_ProcessIndicators = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="e677b2b0-2726-4150-acff-b9dd5076a3de",CSSSelectorGrid="",XPathGrid=""};
            ProcessIndicators = RPSControlFactory.RPSCreateCollectionWithGrid<ProcessIndicatorsCollectionEditor<ProcessEntityView,ProcessIndicatorView>,ProcessEntityView,ProcessIndicatorView>( params_ProcessIndicators,this,Screen.ProcessIndicatorView);
 
            CollectionInit params_ProcessIssues = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="51249da2-6fa8-42fc-8fdf-7e745dccf660",CSSSelectorGrid="",XPathGrid=""};
            ProcessIssues = RPSControlFactory.RPSCreateCollectionWithGrid<ProcessIssuesCollectionEditor<ProcessEntityView,ProcessIndicatorView>,ProcessEntityView,ProcessIndicatorView>( params_ProcessIssues,this,Screen.ProcessIndicatorView);
 
            CollectionInit params_GetWorkflow = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="97794df7-7991-4c4c-aa90-4c5a5cd2d3f2",CSSSelectorGrid="",XPathGrid=""};
            GetWorkflow = RPSControlFactory.RPSCreateCollectionWithGrid<GetWorkflowCollectionEditor<ProcessEntityView,ProcessIndicatorView>,ProcessEntityView,ProcessIndicatorView>( params_GetWorkflow,this,Screen.ProcessIndicatorView);
 
            CollectionInit params_GetProcessImprovementArea = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d6f3d100-35cc-4398-afbe-d7289e98862f",CSSSelectorGrid="",XPathGrid=""};
            GetProcessImprovementArea = RPSControlFactory.RPSCreateCollectionWithGrid<GetProcessImprovementAreaCollectionEditor<ProcessEntityView,ProcessIndicatorView>,ProcessEntityView,ProcessIndicatorView>( params_GetProcessImprovementArea,this,Screen.ProcessIndicatorView);
 
            CollectionInit params_GetProcessImprovementActions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="2792a535-0339-4b71-ac23-dbe2ac659ee6",CSSSelectorGrid="",XPathGrid=""};
            GetProcessImprovementActions = RPSControlFactory.RPSCreateCollectionWithGrid<GetProcessImprovementActionsCollectionEditor<ProcessEntityView,ProcessIndicatorView>,ProcessEntityView,ProcessIndicatorView>( params_GetProcessImprovementActions,this,Screen.ProcessIndicatorView);
 
            CollectionInit params_GetSubprocess = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1e61837a-7632-4107-a862-cb6d4cf789c1",CSSSelectorGrid="",XPathGrid=""};
            GetSubprocess = RPSControlFactory.RPSCreateCollectionWithGrid<GetSubprocessCollectionEditor<ProcessEntityView,ProcessIndicatorView>,ProcessEntityView,ProcessIndicatorView>( params_GetSubprocess,this,Screen.ProcessIndicatorView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<ProcessEntityView>( "","ul li[rpsid='0ac666ef-a008-47b9-8a81-df0aac4b87e3']","",this);
 
            Team = RPSControlFactory.CreateRPSSection<ProcessEntityView>( "","ul li[rpsid='58bd9524-e45c-473a-b4d4-b1e161297e3a']","",this);
 
            Indicators = RPSControlFactory.CreateRPSSection<ProcessEntityView>( "","ul li[rpsid='c1154b47-1dbe-437a-a973-a6d3a782e243']","",this);
 
            ProcessIssue = RPSControlFactory.CreateRPSSection<ProcessEntityView>( "","ul li[rpsid='c4aca484-2b93-4b2c-ac6b-a0bab99e3857']","",this);
 
            Workflow = RPSControlFactory.CreateRPSSection<ProcessEntityView>( "","ul li[rpsid='0f7fbcce-7d01-44a7-9e12-fe214780bc3f']","",this);
 
            ProcessImprovementArea = RPSControlFactory.CreateRPSSection<ProcessEntityView>( "","ul li[rpsid='9fe74b5c-59f2-4143-b5d1-107ff32fdccc']","",this);
 
            SubProcess = RPSControlFactory.CreateRPSSection<ProcessEntityView>( "","ul li[rpsid='d79076f4-11ef-4e27-9a9f-8a7dade6d6be']","",this);
 

        }
        public IRPSSaveButton<ProcessEntityView> SaveButton { get; set; } 
        public IRPSButton<ProcessEntityView> DeleteButton { get; set; } 
        public IRPSButton<ProcessEntityView,ProcessCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ProcessEntityView,ProcessCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ProcessEntityView> CodProcess { get; set; } 
        public IRPSTextBox<ProcessEntityView> Description { get; set; } 
        public IRPSComboBox<ProcessEntityView> Priority { get; set; } 
        public IRPSComboBox<ProcessEntityView> Status { get; set; } 
        public IRPSComboBox<ProcessEntityView> Classification { get; set; } 
        public IRPSComboBox<ProcessEntityView> ProcessType { get; set; } 
        public IRPSComboBox<ProcessEntityView> Criticality { get; set; } 
        public IRPSCheckbox<ProcessEntityView> Analysis { get; set; } 
        public IRPSCheckbox<ProcessEntityView> IsIncidentEnabled { get; set; } 
        public IRPSComboBox<ProcessEntityView> IDDefaultIncindentCategory { get; set; } 
        public IRPSComboBox<ProcessEntityView> IDIncidentCodingSeries { get; set; } 
        public ProcessVersionsCollectionEditor<ProcessEntityView,ProcessIndicatorView> ProcessVersions { get; set; } 
        public ProcessUsersCollectionEditor<ProcessEntityView,ProcessIndicatorView> ProcessUsers { get; set; } 
        public ProcessIndicatorsCollectionEditor<ProcessEntityView,ProcessIndicatorView> ProcessIndicators { get; set; } 
        public ProcessIssuesCollectionEditor<ProcessEntityView,ProcessIndicatorView> ProcessIssues { get; set; } 
        public GetWorkflowCollectionEditor<ProcessEntityView,ProcessIndicatorView> GetWorkflow { get; set; } 
        public GetProcessImprovementAreaCollectionEditor<ProcessEntityView,ProcessIndicatorView> GetProcessImprovementArea { get; set; } 
        public GetProcessImprovementActionsCollectionEditor<ProcessEntityView,ProcessIndicatorView> GetProcessImprovementActions { get; set; } 
        public GetSubprocessCollectionEditor<ProcessEntityView,ProcessIndicatorView> GetSubprocess { get; set; } 
        public IRPSSection<ProcessEntityView> GeneralData { get; set; } 
        public IRPSSection<ProcessEntityView> Team { get; set; } 
        public IRPSSection<ProcessEntityView> Indicators { get; set; } 
        public IRPSSection<ProcessEntityView> ProcessIssue { get; set; } 
        public IRPSSection<ProcessEntityView> Workflow { get; set; } 
        public IRPSSection<ProcessEntityView> ProcessImprovementArea { get; set; } 
        public IRPSSection<ProcessEntityView> SubProcess { get; set; } 
        public Process Screen { get; set; }
        public ProcessEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ProcessVersionsCollectionEditor<ProcessEntityView,ProcessIndicatorView>:RPSCollectionEditor<ProcessEntityView,ProcessIndicatorView> where ProcessEntityView : class, IView where ProcessIndicatorView : class, IView
    {
        public  ProcessVersionsGridView<ProcessEntityView,ProcessIndicatorView> GridView {get;set;}
    }
    public partial class ProcessVersionsGridView <ProcessEntityView,ProcessIndicatorView> :  RPSGridView<ProcessEntityView,ProcessIndicatorView> where ProcessEntityView : class, IView where ProcessIndicatorView : class, IView
    {
        public ProcessVersionsGridView(ProcessEntityView currentView,ProcessIndicatorView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Version = RPSControlFactory.CreateRPSGridFormattedTextBox<ProcessEntityView>("","#ef14ae32-7976-498f-b171-ae477bb7848c .ag-row[role='row']@ROWINDEX [col-id='cVersion']","",true, this.CurrentView);
 
            Status = RPSControlFactory.CreateRPSGridEnumComboBox<ProcessEntityView>("","#ef14ae32-7976-498f-b171-ae477bb7848c .ag-row[role='row']@ROWINDEX [col-id='cStatus']","",true, this.CurrentView);
 
            ActivationDate = RPSControlFactory.CreateRPSGridTextBox<ProcessEntityView>("","#ef14ae32-7976-498f-b171-ae477bb7848c .ag-row[role='row']@ROWINDEX [col-id='cActivationDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ProcessEntityView> Version { get; set; } 
        public IRPSGridComboBox<ProcessEntityView> Status { get; set; } 
        public IRPSGridTextBox<ProcessEntityView> ActivationDate { get; set; } 
                     
    }
 
        public partial class ProcessUsersCollectionEditor<ProcessEntityView,ProcessIndicatorView>:RPSCollectionEditor<ProcessEntityView,ProcessIndicatorView> where ProcessEntityView : class, IView where ProcessIndicatorView : class, IView
    {
        public  ProcessUsersGridView<ProcessEntityView,ProcessIndicatorView> GridView {get;set;}
    }
    public partial class ProcessUsersGridView <ProcessEntityView,ProcessIndicatorView> :  RPSGridView<ProcessEntityView,ProcessIndicatorView> where ProcessEntityView : class, IView where ProcessIndicatorView : class, IView
    {
        public ProcessUsersGridView(ProcessEntityView currentView,ProcessIndicatorView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodUser = RPSControlFactory.CreateRPSGridComboBox<ProcessEntityView>("","#165f9afb-26f3-48ce-ac62-b903851b7edc .ag-row[role='row']@ROWINDEX [col-id='cCodUser']","",true, this.CurrentView);
 
            ProcessRole = RPSControlFactory.CreateRPSGridEnumComboBox<ProcessEntityView>("","#165f9afb-26f3-48ce-ac62-b903851b7edc .ag-row[role='row']@ROWINDEX [col-id='cProcessRole']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<ProcessEntityView> CodUser { get; set; } 
        public IRPSGridComboBox<ProcessEntityView> ProcessRole { get; set; } 
                     
    }
 
        public partial class ProcessIndicatorsCollectionEditor<ProcessEntityView,ProcessIndicatorView>:RPSCollectionEditor<ProcessEntityView,ProcessIndicatorView> where ProcessEntityView : class, IView where ProcessIndicatorView : class, IView
    {
        public  ProcessIndicatorsGridView<ProcessEntityView,ProcessIndicatorView> GridView {get;set;}
    }
    public partial class ProcessIndicatorsGridView <ProcessEntityView,ProcessIndicatorView> :  RPSGridView<ProcessEntityView,ProcessIndicatorView> where ProcessEntityView : class, IView where ProcessIndicatorView : class, IView
    {
        public ProcessIndicatorsGridView(ProcessEntityView currentView,ProcessIndicatorView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Description = RPSControlFactory.CreateRPSGridTextBox<ProcessEntityView>("","#e677b2b0-2726-4150-acff-b9dd5076a3de .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            IndicatorType = RPSControlFactory.CreateRPSGridEnumComboBox<ProcessEntityView>("","#e677b2b0-2726-4150-acff-b9dd5076a3de .ag-row[role='row']@ROWINDEX [col-id='cIndicatorType']","",true, this.CurrentView);
 
            IDIndicatorGroup = RPSControlFactory.CreateRPSGridComboBox<ProcessEntityView>("","#e677b2b0-2726-4150-acff-b9dd5076a3de .ag-row[role='row']@ROWINDEX [col-id='cIDIndicatorGroup']","",true, this.CurrentView);
 
            ValueInterpretation = RPSControlFactory.CreateRPSGridEnumComboBox<ProcessEntityView>("","#e677b2b0-2726-4150-acff-b9dd5076a3de .ag-row[role='row']@ROWINDEX [col-id='cValueInterpretation']","",true, this.CurrentView);
 
            CompareType = RPSControlFactory.CreateRPSGridEnumComboBox<ProcessEntityView>("","#e677b2b0-2726-4150-acff-b9dd5076a3de .ag-row[role='row']@ROWINDEX [col-id='cCompareType']","",false, this.CurrentView);
 
            ControlResponsible = RPSControlFactory.CreateRPSGridComboBox<ProcessEntityView>("","#e677b2b0-2726-4150-acff-b9dd5076a3de .ag-row[role='row']@ROWINDEX [col-id='cControlResponsible']","",true, this.CurrentView);
 
            MeasurementResponsible = RPSControlFactory.CreateRPSGridComboBox<ProcessEntityView>("","#e677b2b0-2726-4150-acff-b9dd5076a3de .ag-row[role='row']@ROWINDEX [col-id='cMeasurementResponsible']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<ProcessEntityView> Description { get; set; } 
        public IRPSGridComboBox<ProcessEntityView> IndicatorType { get; set; } 
        public IRPSGridComboBox<ProcessEntityView> IDIndicatorGroup { get; set; } 
        public IRPSGridComboBox<ProcessEntityView> ValueInterpretation { get; set; } 
        public IRPSGridComboBox<ProcessEntityView> CompareType { get; set; } 
        public IRPSGridComboBox<ProcessEntityView> ControlResponsible { get; set; } 
        public IRPSGridComboBox<ProcessEntityView> MeasurementResponsible { get; set; } 
                     
    }
 
        public partial class ProcessIssuesCollectionEditor<ProcessEntityView,ProcessIndicatorView>:RPSCollectionEditor<ProcessEntityView,ProcessIndicatorView> where ProcessEntityView : class, IView where ProcessIndicatorView : class, IView
    {
        public  ProcessIssuesGridView<ProcessEntityView,ProcessIndicatorView> GridView {get;set;}
    }
    public partial class ProcessIssuesGridView <ProcessEntityView,ProcessIndicatorView> :  RPSGridView<ProcessEntityView,ProcessIndicatorView> where ProcessEntityView : class, IView where ProcessIndicatorView : class, IView
    {
        public ProcessIssuesGridView(ProcessEntityView currentView,ProcessIndicatorView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Description = RPSControlFactory.CreateRPSGridTextBox<ProcessEntityView>("","#51249da2-6fa8-42fc-8fdf-7e745dccf660 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",true, this.CurrentView);
 
            Priority = RPSControlFactory.CreateRPSGridEnumComboBox<ProcessEntityView>("","#51249da2-6fa8-42fc-8fdf-7e745dccf660 .ag-row[role='row']@ROWINDEX [col-id='cPriority']","",true, this.CurrentView);
 
            RegisteredBy = RPSControlFactory.CreateRPSGridTextBox<ProcessEntityView>("","#51249da2-6fa8-42fc-8fdf-7e745dccf660 .ag-row[role='row']@ROWINDEX [col-id='cRegisteredBy']","",true, this.CurrentView);
 
            RegisteredOn = RPSControlFactory.CreateRPSGridTextBox<ProcessEntityView>("","#51249da2-6fa8-42fc-8fdf-7e745dccf660 .ag-row[role='row']@ROWINDEX [col-id='cRegisteredOn']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<ProcessEntityView> Description { get; set; } 
        public IRPSGridComboBox<ProcessEntityView> Priority { get; set; } 
        public IRPSGridTextBox<ProcessEntityView> RegisteredBy { get; set; } 
        public IRPSGridTextBox<ProcessEntityView> RegisteredOn { get; set; } 
                     
    }
 
        public partial class GetWorkflowCollectionEditor<ProcessEntityView,ProcessIndicatorView>:RPSCollectionEditor<ProcessEntityView,ProcessIndicatorView> where ProcessEntityView : class, IView where ProcessIndicatorView : class, IView
    {
        public  GetWorkflowGridView<ProcessEntityView,ProcessIndicatorView> GridView {get;set;}
    }
    public partial class GetWorkflowGridView <ProcessEntityView,ProcessIndicatorView> :  RPSGridView<ProcessEntityView,ProcessIndicatorView> where ProcessEntityView : class, IView where ProcessIndicatorView : class, IView
    {
        public GetWorkflowGridView(ProcessEntityView currentView,ProcessIndicatorView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Workflow_CodWorkflow = RPSControlFactory.CreateRPSGridTextBox<ProcessEntityView>("","#97794df7-7991-4c4c-aa90-4c5a5cd2d3f2 .ag-row[role='row']@ROWINDEX [col-id='cWorkflow_CodWorkflow']","",false, this.CurrentView);
 
            Workflow_Description = RPSControlFactory.CreateRPSGridTextBox<ProcessEntityView>("","#97794df7-7991-4c4c-aa90-4c5a5cd2d3f2 .ag-row[role='row']@ROWINDEX [col-id='cWorkflow_Description']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ProcessEntityView> Workflow_CodWorkflow { get; set; } 
        public IRPSGridTextBox<ProcessEntityView> Workflow_Description { get; set; } 
                     
    }
 
        public partial class GetProcessImprovementAreaCollectionEditor<ProcessEntityView,ProcessIndicatorView>:RPSCollectionEditor<ProcessEntityView,ProcessIndicatorView> where ProcessEntityView : class, IView where ProcessIndicatorView : class, IView
    {
        public  GetProcessImprovementAreaGridView<ProcessEntityView,ProcessIndicatorView> GridView {get;set;}
    }
    public partial class GetProcessImprovementAreaGridView <ProcessEntityView,ProcessIndicatorView> :  RPSGridView<ProcessEntityView,ProcessIndicatorView> where ProcessEntityView : class, IView where ProcessIndicatorView : class, IView
    {
        public GetProcessImprovementAreaGridView(ProcessEntityView currentView,ProcessIndicatorView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDProcessImprovementArea = RPSControlFactory.CreateRPSGridComboBox<ProcessEntityView>("","#d6f3d100-35cc-4398-afbe-d7289e98862f .ag-row[role='row']@ROWINDEX [col-id='cIDProcessImprovementArea']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ProcessEntityView> IDProcessImprovementArea { get; set; } 
                     
    }
 
        public partial class GetProcessImprovementActionsCollectionEditor<ProcessEntityView,ProcessIndicatorView>:RPSCollectionEditor<ProcessEntityView,ProcessIndicatorView> where ProcessEntityView : class, IView where ProcessIndicatorView : class, IView
    {
        public  GetProcessImprovementActionsGridView<ProcessEntityView,ProcessIndicatorView> GridView {get;set;}
    }
    public partial class GetProcessImprovementActionsGridView <ProcessEntityView,ProcessIndicatorView> :  RPSGridView<ProcessEntityView,ProcessIndicatorView> where ProcessEntityView : class, IView where ProcessIndicatorView : class, IView
    {
        public GetProcessImprovementActionsGridView(ProcessEntityView currentView,ProcessIndicatorView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ProcessImprovementAction = RPSControlFactory.CreateRPSGridComboBox<ProcessEntityView>("","#2792a535-0339-4b71-ac23-dbe2ac659ee6 .ag-row[role='row']@ROWINDEX [col-id='cProcessImprovementAction']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ProcessEntityView> ProcessImprovementAction { get; set; } 
                     
    }
 
        public partial class GetSubprocessCollectionEditor<ProcessEntityView,ProcessIndicatorView>:RPSCollectionEditor<ProcessEntityView,ProcessIndicatorView> where ProcessEntityView : class, IView where ProcessIndicatorView : class, IView
    {
        public  GetSubprocessGridView<ProcessEntityView,ProcessIndicatorView> GridView {get;set;}
    }
    public partial class GetSubprocessGridView <ProcessEntityView,ProcessIndicatorView> :  RPSGridView<ProcessEntityView,ProcessIndicatorView> where ProcessEntityView : class, IView where ProcessIndicatorView : class, IView
    {
        public GetSubprocessGridView(ProcessEntityView currentView,ProcessIndicatorView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Process_Priority = RPSControlFactory.CreateRPSGridTextBox<ProcessEntityView>("","#1e61837a-7632-4107-a862-cb6d4cf789c1 .ag-row[role='row']@ROWINDEX [col-id='cProcess_Priority']","",false, this.CurrentView);
 
            Process_Status = RPSControlFactory.CreateRPSGridTextBox<ProcessEntityView>("","#1e61837a-7632-4107-a862-cb6d4cf789c1 .ag-row[role='row']@ROWINDEX [col-id='cProcess_Status']","",false, this.CurrentView);
 
            Process_Classification = RPSControlFactory.CreateRPSGridTextBox<ProcessEntityView>("","#1e61837a-7632-4107-a862-cb6d4cf789c1 .ag-row[role='row']@ROWINDEX [col-id='cProcess_Classification']","",false, this.CurrentView);
 
            Process_ProcessType = RPSControlFactory.CreateRPSGridTextBox<ProcessEntityView>("","#1e61837a-7632-4107-a862-cb6d4cf789c1 .ag-row[role='row']@ROWINDEX [col-id='cProcess_ProcessType']","",false, this.CurrentView);
 
            Process_Criticality = RPSControlFactory.CreateRPSGridTextBox<ProcessEntityView>("","#1e61837a-7632-4107-a862-cb6d4cf789c1 .ag-row[role='row']@ROWINDEX [col-id='cProcess_Criticality']","",false, this.CurrentView);
 
            Process_Analysis = RPSControlFactory.CreateRPSGridCheckBox<ProcessEntityView>("","#1e61837a-7632-4107-a862-cb6d4cf789c1 .ag-row[role='row']@ROWINDEX [col-id='cProcess_Analysis']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ProcessEntityView> Process_Priority { get; set; } 
        public IRPSGridTextBox<ProcessEntityView> Process_Status { get; set; } 
        public IRPSGridTextBox<ProcessEntityView> Process_Classification { get; set; } 
        public IRPSGridTextBox<ProcessEntityView> Process_ProcessType { get; set; } 
        public IRPSGridTextBox<ProcessEntityView> Process_Criticality { get; set; } 
        public IRPSGridCheckbox<ProcessEntityView> Process_Analysis { get; set; } 
                     
    }
 
    }
  
            
    public partial class ProcessVersionView : View
    {
        public ProcessVersionView(Process screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ProcessVersionView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ProcessVersionView,ProcessEntityView>( this,Screen.ProcessEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ProcessVersionView,ProcessEntityView>( this,Screen.ProcessEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ProcessVersionView,ProcessEntityView>( this,Screen.ProcessEntityView);
 
            Version = RPSControlFactory.CreateRPSFormattedTextBox<ProcessVersionView>("d24eec87-29ab-4a28-8b56-03154f6945ff","","",true, this);
 
            Status = RPSControlFactory.CreateRPSEnumComboBox<ProcessVersionView>("44322580-9be2-4814-a41d-59e0462344a9","","",true, this);
 
            ActivationDate = RPSControlFactory.CreateRPSTextBox<ProcessVersionView>("b0dd1062-e2b7-4d1f-be58-ab15e5f6b0b2","","",false, this);
 
            SIPOC_S = RPSControlFactory.CreateRPSTextBox<ProcessVersionView>("da15b306-0e21-45e8-b727-3fba7e749705","","",false, this);
 
            SIPOC_I = RPSControlFactory.CreateRPSTextBox<ProcessVersionView>("f61ee995-ce95-47a1-9492-4b7a14e82aa7","","",false, this);
 
            SIPOC_O = RPSControlFactory.CreateRPSTextBox<ProcessVersionView>("97fff027-843f-4ac9-8025-f5a3d2c8c460","","",false, this);
 
            SIPOC_C = RPSControlFactory.CreateRPSTextBox<ProcessVersionView>("dfff5c28-dd7a-4320-96d4-86dc335c40ff","","",false, this);
 
            ScopeBegins = RPSControlFactory.CreateRPSTextBox<ProcessVersionView>("e66e60d9-6d33-476c-a089-02491436783a","","",false, this);
 
            ScopeEnds = RPSControlFactory.CreateRPSTextBox<ProcessVersionView>("3bc4344f-faeb-4b13-a939-4dabb515c63d","","",false, this);
 
            ScopeIncludes = RPSControlFactory.CreateRPSTextBox<ProcessVersionView>("17e5ce66-2001-496d-a43c-5437273e474a","","",false, this);
 
            Mission = RPSControlFactory.CreateRPSTextBox<ProcessVersionView>("e9f4827a-0dd4-43fa-8262-c5790fca5e75","","",false, this);
 
            Comments = RPSControlFactory.CreateRPSTextBox<ProcessVersionView>("6a946dd5-4dea-456c-bb08-8ff71ca5ba2b","","",false, this);
 
            CopyVersionCommandButton = RPSControlFactory.CreateRPSButton<ProcessVersionView>( "c7e5a2c5-27cc-4f7a-8458-1c3aa99e0c15","","",this);
 
            ExecuteActivateVersionButton = RPSControlFactory.CreateRPSButton<ProcessVersionView>( "49ae6ab8-823e-4a69-9922-5ef0953394bb","","",this);
 
            CollectionInit params_ProcessPhases = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="af3fb777-4e2f-438e-9802-0d9bd09e4d94",CSSSelectorGrid="",XPathGrid=""};
            ProcessPhases = RPSControlFactory.RPSCreateCollectionWithGrid<ProcessPhasesCollectionEditor<ProcessVersionView,ProcessPhaseView>,ProcessVersionView,ProcessPhaseView>( params_ProcessPhases,this,Screen.ProcessPhaseView);
 
            CollectionInit params_ProcessStakeholders = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d8fef869-83eb-499c-83d6-5d38acdcb6e4",CSSSelectorGrid="",XPathGrid=""};
            ProcessStakeholders = RPSControlFactory.RPSCreateCollectionWithGrid<ProcessStakeholdersCollectionEditor<ProcessVersionView,ProcessPhaseView>,ProcessVersionView,ProcessPhaseView>( params_ProcessStakeholders,this,Screen.ProcessPhaseView);
 
            CollectionInit params_ProcessApplications = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="843164fe-2296-479f-b5c1-e3319876b067",CSSSelectorGrid="",XPathGrid=""};
            ProcessApplications = RPSControlFactory.RPSCreateCollectionWithGrid<ProcessApplicationsCollectionEditor<ProcessVersionView,ProcessPhaseView>,ProcessVersionView,ProcessPhaseView>( params_ProcessApplications,this,Screen.ProcessPhaseView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<ProcessVersionView>( "","ul li[rpsid='3b30fe0e-6bdf-47fb-bd58-b455f63dd2c6']","",this);
 
            SIPOC = RPSControlFactory.CreateRPSSection<ProcessVersionView>( "","ul li[rpsid='680a4e8d-a40b-4b17-b04c-88408bd78651']","",this);
 
            Scope = RPSControlFactory.CreateRPSSection<ProcessVersionView>( "","ul li[rpsid='a49acfbf-920e-4ee0-ba45-88ebb744d137']","",this);
 
            Analysis = RPSControlFactory.CreateRPSSection<ProcessVersionView>( "","ul li[rpsid='f4ac53bb-f9a9-45c6-80ff-cdf892776a0b']","",this);
 
            Stakeholders = RPSControlFactory.CreateRPSSection<ProcessVersionView>( "","ul li[rpsid='c1c85f9a-8130-4c48-937b-b902ea163fc0']","",this);
 
            Applications = RPSControlFactory.CreateRPSSection<ProcessVersionView>( "","ul li[rpsid='82e54e04-1b71-4c04-bad9-2360bcc0d97a']","",this);
 

        }
        public IRPSButton<ProcessVersionView> DeleteButton { get; set; } 
        public IRPSButton<ProcessVersionView,ProcessEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ProcessVersionView,ProcessEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ProcessVersionView,ProcessEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<ProcessVersionView> Version { get; set; } 
        public IRPSComboBox<ProcessVersionView> Status { get; set; } 
        public IRPSTextBox<ProcessVersionView> ActivationDate { get; set; } 
        public IRPSTextBox<ProcessVersionView> SIPOC_S { get; set; } 
        public IRPSTextBox<ProcessVersionView> SIPOC_I { get; set; } 
        public IRPSTextBox<ProcessVersionView> SIPOC_O { get; set; } 
        public IRPSTextBox<ProcessVersionView> SIPOC_C { get; set; } 
        public IRPSTextBox<ProcessVersionView> ScopeBegins { get; set; } 
        public IRPSTextBox<ProcessVersionView> ScopeEnds { get; set; } 
        public IRPSTextBox<ProcessVersionView> ScopeIncludes { get; set; } 
        public IRPSTextBox<ProcessVersionView> Mission { get; set; } 
        public IRPSTextBox<ProcessVersionView> Comments { get; set; } 
        public IRPSButton<ProcessVersionView> CopyVersionCommandButton { get; set; } 
        public IRPSButton<ProcessVersionView> ExecuteActivateVersionButton { get; set; } 
        public ProcessPhasesCollectionEditor<ProcessVersionView,ProcessPhaseView> ProcessPhases { get; set; } 
        public ProcessStakeholdersCollectionEditor<ProcessVersionView,ProcessPhaseView> ProcessStakeholders { get; set; } 
        public ProcessApplicationsCollectionEditor<ProcessVersionView,ProcessPhaseView> ProcessApplications { get; set; } 
        public IRPSSection<ProcessVersionView> GeneralData { get; set; } 
        public IRPSSection<ProcessVersionView> SIPOC { get; set; } 
        public IRPSSection<ProcessVersionView> Scope { get; set; } 
        public IRPSSection<ProcessVersionView> Analysis { get; set; } 
        public IRPSSection<ProcessVersionView> Stakeholders { get; set; } 
        public IRPSSection<ProcessVersionView> Applications { get; set; } 
        public Process Screen { get; set; }
        public ProcessVersionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ProcessPhasesCollectionEditor<ProcessVersionView,ProcessPhaseView>:RPSCollectionEditor<ProcessVersionView,ProcessPhaseView> where ProcessVersionView : class, IView where ProcessPhaseView : class, IView
    {
        public  ProcessPhasesGridView<ProcessVersionView,ProcessPhaseView> GridView {get;set;}
    }
    public partial class ProcessPhasesGridView <ProcessVersionView,ProcessPhaseView> :  RPSGridView<ProcessVersionView,ProcessPhaseView> where ProcessVersionView : class, IView where ProcessPhaseView : class, IView
    {
        public ProcessPhasesGridView(ProcessVersionView currentView,ProcessPhaseView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodProcessPhase = RPSControlFactory.CreateRPSGridTextBox<ProcessVersionView>("","#af3fb777-4e2f-438e-9802-0d9bd09e4d94 .ag-row[role='row']@ROWINDEX [col-id='cCodProcessPhase']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ProcessVersionView>("","#af3fb777-4e2f-438e-9802-0d9bd09e4d94 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ProcessVersionView> CodProcessPhase { get; set; } 
        public IRPSGridTextBox<ProcessVersionView> Description { get; set; } 
                     
    }
 
        public partial class ProcessStakeholdersCollectionEditor<ProcessVersionView,ProcessPhaseView>:RPSCollectionEditor<ProcessVersionView,ProcessPhaseView> where ProcessVersionView : class, IView where ProcessPhaseView : class, IView
    {
        public  ProcessStakeholdersGridView<ProcessVersionView,ProcessPhaseView> GridView {get;set;}
    }
    public partial class ProcessStakeholdersGridView <ProcessVersionView,ProcessPhaseView> :  RPSGridView<ProcessVersionView,ProcessPhaseView> where ProcessVersionView : class, IView where ProcessPhaseView : class, IView
    {
        public ProcessStakeholdersGridView(ProcessVersionView currentView,ProcessPhaseView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDStakeholder = RPSControlFactory.CreateRPSGridComboBox<ProcessVersionView>("","#d8fef869-83eb-499c-83d6-5d38acdcb6e4 .ag-row[role='row']@ROWINDEX [col-id='cIDStakeholder']","",true, this.CurrentView);
 
            Function = RPSControlFactory.CreateRPSGridEnumComboBox<ProcessVersionView>("","#d8fef869-83eb-499c-83d6-5d38acdcb6e4 .ag-row[role='row']@ROWINDEX [col-id='cFunction']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<ProcessVersionView> IDStakeholder { get; set; } 
        public IRPSGridComboBox<ProcessVersionView> Function { get; set; } 
                     
    }
 
        public partial class ProcessApplicationsCollectionEditor<ProcessVersionView,ProcessPhaseView>:RPSCollectionEditor<ProcessVersionView,ProcessPhaseView> where ProcessVersionView : class, IView where ProcessPhaseView : class, IView
    {
        public  ProcessApplicationsGridView<ProcessVersionView,ProcessPhaseView> GridView {get;set;}
    }
    public partial class ProcessApplicationsGridView <ProcessVersionView,ProcessPhaseView> :  RPSGridView<ProcessVersionView,ProcessPhaseView> where ProcessVersionView : class, IView where ProcessPhaseView : class, IView
    {
        public ProcessApplicationsGridView(ProcessVersionView currentView,ProcessPhaseView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDApplication = RPSControlFactory.CreateRPSGridComboBox<ProcessVersionView>("","#843164fe-2296-479f-b5c1-e3319876b067 .ag-row[role='row']@ROWINDEX [col-id='cIDApplication']","",true, this.CurrentView);
 
            Comments = RPSControlFactory.CreateRPSGridMemoTextBox<ProcessVersionView>("","#843164fe-2296-479f-b5c1-e3319876b067 .ag-row[role='row']@ROWINDEX [col-id='cComments']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ProcessVersionView> IDApplication { get; set; } 
        public IRPSGridTextBox<ProcessVersionView> Comments { get; set; } 
                     
    }
 
    }
  
            
    public partial class ProcessIssueView : View
    {
        public ProcessIssueView(Process screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ProcessIssueView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ProcessIssueView,ProcessEntityView>( this,Screen.ProcessEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ProcessIssueView,ProcessEntityView>( this,Screen.ProcessEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ProcessIssueView,ProcessEntityView>( this,Screen.ProcessEntityView);
 
            Description = RPSControlFactory.CreateRPSTextBox<ProcessIssueView>("cebbbb16-2d10-4502-b59c-d8dec1ee5f16","","",true, this);
 
            Priority = RPSControlFactory.CreateRPSEnumComboBox<ProcessIssueView>("0dddf2c8-dcd9-4cc6-b963-0fa45fe7ab34","","",true, this);
 
            RegisteredOn = RPSControlFactory.CreateRPSTextBox<ProcessIssueView>("f3213954-3f8c-4d5f-a57a-112ca2b59bcd","","",true, this);
 
            RegisteredBy = RPSControlFactory.CreateRPSEnumComboBox<ProcessIssueView>("f1c1266e-de01-4f10-84ea-9bb3b9161999","","",true, this);
 
            ClosedOn = RPSControlFactory.CreateRPSTextBox<ProcessIssueView>("348a5c62-f449-455f-9579-dbea95fe5961","","",false, this);
 
            Causes = RPSControlFactory.CreateRPSTextBox<ProcessIssueView>("7021b47d-97e0-4878-86c5-bf1407eef838","","",false, this);
 
            Source = RPSControlFactory.CreateRPSTextBox<ProcessIssueView>("b5671733-2a45-4033-afef-c21a36a9a364","","",false, this);
 
            Consequences = RPSControlFactory.CreateRPSTextBox<ProcessIssueView>("077941b2-b433-4f5a-a951-f46ebfbd18e1","","",false, this);
 
            Coments = RPSControlFactory.CreateRPSTextBox<ProcessIssueView>("039eb292-ba2c-4e7c-a47c-473b99aa6ba2","","",false, this);
 
            CollectionInit params_IssueSolutions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="03034389-59e8-49f0-bb3f-a8c80668e0cf",CSSSelectorGrid="",XPathGrid=""};
            IssueSolutions = RPSControlFactory.RPSCreateCollectionWithGrid<IssueSolutionsCollectionEditor<ProcessIssueView>,ProcessIssueView>( params_IssueSolutions,this);
 
            GeneralData = RPSControlFactory.CreateRPSSection<ProcessIssueView>( "","ul li[rpsid='0a29506b-6bdf-4e78-82ea-95002ba35e5d']","",this);
 
            Causes1 = RPSControlFactory.CreateRPSSection<ProcessIssueView>( "","ul li[rpsid='40247e26-6c12-49d2-b353-c9e49502d139']","",this);
 
            Source1 = RPSControlFactory.CreateRPSSection<ProcessIssueView>( "","ul li[rpsid='be2817d9-4c5f-490f-92fd-c95062b3c2cd']","",this);
 
            Consequences1 = RPSControlFactory.CreateRPSSection<ProcessIssueView>( "","ul li[rpsid='1afa9f89-cc9b-425a-9b13-97df95d7ff8c']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<ProcessIssueView>( "","ul li[rpsid='77c5370f-66d1-44e2-b9c0-e85f331e51a7']","",this);
 

        }
        public IRPSButton<ProcessIssueView> DeleteButton { get; set; } 
        public IRPSButton<ProcessIssueView,ProcessEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ProcessIssueView,ProcessEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ProcessIssueView,ProcessEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<ProcessIssueView> Description { get; set; } 
        public IRPSComboBox<ProcessIssueView> Priority { get; set; } 
        public IRPSTextBox<ProcessIssueView> RegisteredOn { get; set; } 
        public IRPSComboBox<ProcessIssueView> RegisteredBy { get; set; } 
        public IRPSTextBox<ProcessIssueView> ClosedOn { get; set; } 
        public IRPSTextBox<ProcessIssueView> Causes { get; set; } 
        public IRPSTextBox<ProcessIssueView> Source { get; set; } 
        public IRPSTextBox<ProcessIssueView> Consequences { get; set; } 
        public IRPSTextBox<ProcessIssueView> Coments { get; set; } 
        public IssueSolutionsCollectionEditor<ProcessIssueView> IssueSolutions { get; set; } 
        public IRPSSection<ProcessIssueView> GeneralData { get; set; } 
        public IRPSSection<ProcessIssueView> Causes1 { get; set; } 
        public IRPSSection<ProcessIssueView> Source1 { get; set; } 
        public IRPSSection<ProcessIssueView> Consequences1 { get; set; } 
        public IRPSSection<ProcessIssueView> Comments { get; set; } 
        public Process Screen { get; set; }
        public ProcessIssueView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class IssueSolutionsCollectionEditor<ProcessIssueView>:RPSCollectionEditor<ProcessIssueView> where ProcessIssueView : class, IView
    {
        public  IssueSolutionsGridView<ProcessIssueView> GridView {get;set;}
    }
    public partial class IssueSolutionsGridView <ProcessIssueView> :  RPSGridView<ProcessIssueView> where ProcessIssueView : class, IView
    {
        public IssueSolutionsGridView(ProcessIssueView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Description = RPSControlFactory.CreateRPSGridTextBox<ProcessIssueView>("","#03034389-59e8-49f0-bb3f-a8c80668e0cf .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",true, this.CurrentView);
 
            Priority = RPSControlFactory.CreateRPSGridEnumComboBox<ProcessIssueView>("","#03034389-59e8-49f0-bb3f-a8c80668e0cf .ag-row[role='row']@ROWINDEX [col-id='cPriority']","",true, this.CurrentView);
 
            Comments = RPSControlFactory.CreateRPSGridMemoTextBox<ProcessIssueView>("","#03034389-59e8-49f0-bb3f-a8c80668e0cf .ag-row[role='row']@ROWINDEX [col-id='cComments']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ProcessIssueView> Description { get; set; } 
        public IRPSGridComboBox<ProcessIssueView> Priority { get; set; } 
        public IRPSGridTextBox<ProcessIssueView> Comments { get; set; } 
                     
    }
 
    }
  
            
    public partial class ProcessPhaseView : View
    {
        public ProcessPhaseView(Process screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ProcessPhaseView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ProcessPhaseView,ProcessVersionView>( this,Screen.ProcessVersionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ProcessPhaseView,ProcessVersionView>( this,Screen.ProcessVersionView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ProcessPhaseView,ProcessVersionView>( this,Screen.ProcessVersionView);
 
            CodProcessPhase = RPSControlFactory.CreateRPSTextBox<ProcessPhaseView>("1bf773fa-ae65-454e-8399-7479b8bfc5b6","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ProcessPhaseView>("308b3687-40b6-44ec-81c6-623cdf4a655c","","",false, this);
 
            CollectionInit params_ProcessTasks = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ead7021b-6970-4927-bf1a-992a4ad9c6a1",CSSSelectorGrid="",XPathGrid=""};
            ProcessTasks = RPSControlFactory.RPSCreateCollectionWithGrid<ProcessTasksCollectionEditor<ProcessPhaseView,ProcessTaskView>,ProcessPhaseView,ProcessTaskView>( params_ProcessTasks,this,Screen.ProcessTaskView);
 

        }
        public IRPSButton<ProcessPhaseView> DeleteButton { get; set; } 
        public IRPSButton<ProcessPhaseView,ProcessVersionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ProcessPhaseView,ProcessVersionView> BackButton { get; set; } 
        public IRPSAcceptButton<ProcessPhaseView,ProcessVersionView> AcceptButton { get; set; } 
        public IRPSTextBox<ProcessPhaseView> CodProcessPhase { get; set; } 
        public IRPSTextBox<ProcessPhaseView> Description { get; set; } 
        public ProcessTasksCollectionEditor<ProcessPhaseView,ProcessTaskView> ProcessTasks { get; set; } 
        public Process Screen { get; set; }
        public ProcessPhaseView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ProcessTasksCollectionEditor<ProcessPhaseView,ProcessTaskView>:RPSCollectionEditor<ProcessPhaseView,ProcessTaskView> where ProcessPhaseView : class, IView where ProcessTaskView : class, IView
    {
        public  ProcessTasksGridView<ProcessPhaseView,ProcessTaskView> GridView {get;set;}
    }
    public partial class ProcessTasksGridView <ProcessPhaseView,ProcessTaskView> :  RPSGridView<ProcessPhaseView,ProcessTaskView> where ProcessPhaseView : class, IView where ProcessTaskView : class, IView
    {
        public ProcessTasksGridView(ProcessPhaseView currentView,ProcessTaskView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodProcessTask = RPSControlFactory.CreateRPSGridTextBox<ProcessPhaseView>("","#ead7021b-6970-4927-bf1a-992a4ad9c6a1 .ag-row[role='row']@ROWINDEX [col-id='cCodProcessTask']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ProcessPhaseView>("","#ead7021b-6970-4927-bf1a-992a4ad9c6a1 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",true, this.CurrentView);
 
            TaskType = RPSControlFactory.CreateRPSGridEnumComboBox<ProcessPhaseView>("","#ead7021b-6970-4927-bf1a-992a4ad9c6a1 .ag-row[role='row']@ROWINDEX [col-id='cTaskType']","",true, this.CurrentView);
 
            AddsValue = RPSControlFactory.CreateRPSGridCheckBox<ProcessPhaseView>("","#ead7021b-6970-4927-bf1a-992a4ad9c6a1 .ag-row[role='row']@ROWINDEX [col-id='cAddsValue']","",true, this.CurrentView);
 
            IsRequired = RPSControlFactory.CreateRPSGridCheckBox<ProcessPhaseView>("","#ead7021b-6970-4927-bf1a-992a4ad9c6a1 .ag-row[role='row']@ROWINDEX [col-id='cIsRequired']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<ProcessPhaseView> CodProcessTask { get; set; } 
        public IRPSGridTextBox<ProcessPhaseView> Description { get; set; } 
        public IRPSGridComboBox<ProcessPhaseView> TaskType { get; set; } 
        public IRPSGridCheckbox<ProcessPhaseView> AddsValue { get; set; } 
        public IRPSGridCheckbox<ProcessPhaseView> IsRequired { get; set; } 
                     
    }
 
    }
  
            
    public partial class ProcessTaskView : View
    {
        public ProcessTaskView(Process screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ProcessTaskView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ProcessTaskView,ProcessPhaseView>( this,Screen.ProcessPhaseView);
 
            BackButton = RPSControlFactory.RPSBackButton<ProcessTaskView,ProcessPhaseView>( this,Screen.ProcessPhaseView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ProcessTaskView,ProcessPhaseView>( this,Screen.ProcessPhaseView);
 
            CodProcessTask = RPSControlFactory.CreateRPSTextBox<ProcessTaskView>("d88fde0e-08c1-4c82-b62d-8f456db01ec2","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ProcessTaskView>("aeea7965-c659-4b5e-a1ba-3e4a0881bbf5","","",true, this);
 
            TaskType = RPSControlFactory.CreateRPSEnumComboBox<ProcessTaskView>("9a16e9f8-c7d5-4e00-bec0-22223e1b76e0","","",true, this);
 
            AddsValue = RPSControlFactory.CreateRPSCheckBox<ProcessTaskView>("4e00e744-ffd7-4107-9501-669df2bfff69","","",true, this);
 
            IsRequired = RPSControlFactory.CreateRPSCheckBox<ProcessTaskView>("29a65911-4671-47c8-b5ee-8bfe1ec9a5bd","","",true, this);
 
            IsIncidentEnabled = RPSControlFactory.CreateRPSCheckBox<ProcessTaskView>("a706a17e-5924-48c5-8c54-313e34c4dd10","","",true, this);
 
            IDIncidentCategory = RPSControlFactory.CreateRPSComboBox<ProcessTaskView>("5de24bd8-00f7-4847-b14a-b173def25a52","","",false, this);
 
            Shortcomings = RPSControlFactory.CreateRPSTextBox<ProcessTaskView>("c6080a8f-6e7b-4f44-b719-7723e2498eed","","",false, this);
 
            Comments = RPSControlFactory.CreateRPSTextBox<ProcessTaskView>("5a6adc89-ae71-479e-be9f-9c10580d4cec","","",false, this);
 
            Inputs = RPSControlFactory.CreateRPSTextBox<ProcessTaskView>("5aca4a3d-31a1-4b2c-accc-6559e71fcb2c","","",false, this);
 
            Outputs = RPSControlFactory.CreateRPSTextBox<ProcessTaskView>("50454571-c991-4483-86b5-3f56e9897e70","","",false, this);
 
            CollectionInit params_ProcessTaskApplications = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="e5781696-463c-4504-9ae8-d9d992b88772",CSSSelectorGrid="",XPathGrid=""};
            ProcessTaskApplications = RPSControlFactory.RPSCreateCollectionWithGrid<ProcessTaskApplicationsCollectionEditor<ProcessTaskView>,ProcessTaskView>( params_ProcessTaskApplications,this);
 
            CollectionInit params_ProcessTaskGroups = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ddfe5d20-8fa2-43bb-bd11-9373aafbdd99",CSSSelectorGrid="",XPathGrid=""};
            ProcessTaskGroups = RPSControlFactory.RPSCreateCollectionWithGrid<ProcessTaskGroupsCollectionEditor<ProcessTaskView>,ProcessTaskView>( params_ProcessTaskGroups,this);
 
            CollectionInit params_ProcessTaskRequirements = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a875d36c-ef2f-48e1-80aa-dfe14b055b85",CSSSelectorGrid="",XPathGrid=""};
            ProcessTaskRequirements = RPSControlFactory.RPSCreateCollectionWithGrid<ProcessTaskRequirementsCollectionEditor<ProcessTaskView>,ProcessTaskView>( params_ProcessTaskRequirements,this);
 
            General = RPSControlFactory.CreateRPSSection<ProcessTaskView>( "","ul li[rpsid='8aaa9423-17fc-443b-aa4e-b611cfdaf0eb']","",this);
 
            Comments1 = RPSControlFactory.CreateRPSSection<ProcessTaskView>( "","ul li[rpsid='f6be704e-24dc-4e9a-8be3-bea3730882a0']","",this);
 
            InputOutput = RPSControlFactory.CreateRPSSection<ProcessTaskView>( "","ul li[rpsid='4e55af84-565e-4da7-b4a8-0a070b66cea3']","",this);
 
            Applications = RPSControlFactory.CreateRPSSection<ProcessTaskView>( "","ul li[rpsid='b8b74681-66a4-4b8a-a85c-276c5baa20e2']","",this);
 
            Stakeholders = RPSControlFactory.CreateRPSSection<ProcessTaskView>( "","ul li[rpsid='264aa134-c3e8-4ea1-b691-00ff42ab2a13']","",this);
 
            Requirements = RPSControlFactory.CreateRPSSection<ProcessTaskView>( "","ul li[rpsid='0124fada-f123-4266-917d-02aee79ab7a4']","",this);
 

        }
        public IRPSButton<ProcessTaskView> DeleteButton { get; set; } 
        public IRPSButton<ProcessTaskView,ProcessPhaseView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ProcessTaskView,ProcessPhaseView> BackButton { get; set; } 
        public IRPSAcceptButton<ProcessTaskView,ProcessPhaseView> AcceptButton { get; set; } 
        public IRPSTextBox<ProcessTaskView> CodProcessTask { get; set; } 
        public IRPSTextBox<ProcessTaskView> Description { get; set; } 
        public IRPSComboBox<ProcessTaskView> TaskType { get; set; } 
        public IRPSCheckbox<ProcessTaskView> AddsValue { get; set; } 
        public IRPSCheckbox<ProcessTaskView> IsRequired { get; set; } 
        public IRPSCheckbox<ProcessTaskView> IsIncidentEnabled { get; set; } 
        public IRPSComboBox<ProcessTaskView> IDIncidentCategory { get; set; } 
        public IRPSTextBox<ProcessTaskView> Shortcomings { get; set; } 
        public IRPSTextBox<ProcessTaskView> Comments { get; set; } 
        public IRPSTextBox<ProcessTaskView> Inputs { get; set; } 
        public IRPSTextBox<ProcessTaskView> Outputs { get; set; } 
        public ProcessTaskApplicationsCollectionEditor<ProcessTaskView> ProcessTaskApplications { get; set; } 
        public ProcessTaskGroupsCollectionEditor<ProcessTaskView> ProcessTaskGroups { get; set; } 
        public ProcessTaskRequirementsCollectionEditor<ProcessTaskView> ProcessTaskRequirements { get; set; } 
        public IRPSSection<ProcessTaskView> General { get; set; } 
        public IRPSSection<ProcessTaskView> Comments1 { get; set; } 
        public IRPSSection<ProcessTaskView> InputOutput { get; set; } 
        public IRPSSection<ProcessTaskView> Applications { get; set; } 
        public IRPSSection<ProcessTaskView> Stakeholders { get; set; } 
        public IRPSSection<ProcessTaskView> Requirements { get; set; } 
        public Process Screen { get; set; }
        public ProcessTaskView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ProcessTaskApplicationsCollectionEditor<ProcessTaskView>:RPSCollectionEditor<ProcessTaskView> where ProcessTaskView : class, IView
    {
        public  ProcessTaskApplicationsGridView<ProcessTaskView> GridView {get;set;}
    }
    public partial class ProcessTaskApplicationsGridView <ProcessTaskView> :  RPSGridView<ProcessTaskView> where ProcessTaskView : class, IView
    {
        public ProcessTaskApplicationsGridView(ProcessTaskView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDApplication = RPSControlFactory.CreateRPSGridComboBox<ProcessTaskView>("","#e5781696-463c-4504-9ae8-d9d992b88772 .ag-row[role='row']@ROWINDEX [col-id='cIDApplication']","",true, this.CurrentView);
 
            Comments = RPSControlFactory.CreateRPSGridMemoTextBox<ProcessTaskView>("","#e5781696-463c-4504-9ae8-d9d992b88772 .ag-row[role='row']@ROWINDEX [col-id='cComments']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ProcessTaskView> IDApplication { get; set; } 
        public IRPSGridTextBox<ProcessTaskView> Comments { get; set; } 
                     
    }
 
        public partial class ProcessTaskGroupsCollectionEditor<ProcessTaskView>:RPSCollectionEditor<ProcessTaskView> where ProcessTaskView : class, IView
    {
        public  ProcessTaskGroupsGridView<ProcessTaskView> GridView {get;set;}
    }
    public partial class ProcessTaskGroupsGridView <ProcessTaskView> :  RPSGridView<ProcessTaskView> where ProcessTaskView : class, IView
    {
        public ProcessTaskGroupsGridView(ProcessTaskView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDStakeholder = RPSControlFactory.CreateRPSGridComboBox<ProcessTaskView>("","#ddfe5d20-8fa2-43bb-bd11-9373aafbdd99 .ag-row[role='row']@ROWINDEX [col-id='cIDStakeholder']","",true, this.CurrentView);
 
            Function = RPSControlFactory.CreateRPSGridEnumComboBox<ProcessTaskView>("","#ddfe5d20-8fa2-43bb-bd11-9373aafbdd99 .ag-row[role='row']@ROWINDEX [col-id='cFunction']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<ProcessTaskView> IDStakeholder { get; set; } 
        public IRPSGridComboBox<ProcessTaskView> Function { get; set; } 
                     
    }
 
        public partial class ProcessTaskRequirementsCollectionEditor<ProcessTaskView>:RPSCollectionEditor<ProcessTaskView> where ProcessTaskView : class, IView
    {
        public  ProcessTaskRequirementsGridView<ProcessTaskView> GridView {get;set;}
    }
    public partial class ProcessTaskRequirementsGridView <ProcessTaskView> :  RPSGridView<ProcessTaskView> where ProcessTaskView : class, IView
    {
        public ProcessTaskRequirementsGridView(ProcessTaskView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodRequirement = RPSControlFactory.CreateRPSGridTextBox<ProcessTaskView>("","#a875d36c-ef2f-48e1-80aa-dfe14b055b85 .ag-row[role='row']@ROWINDEX [col-id='cCodRequirement']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ProcessTaskView>("","#a875d36c-ef2f-48e1-80aa-dfe14b055b85 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Scope = RPSControlFactory.CreateRPSGridTextBox<ProcessTaskView>("","#a875d36c-ef2f-48e1-80aa-dfe14b055b85 .ag-row[role='row']@ROWINDEX [col-id='cScope']","",false, this.CurrentView);
 
            Priority = RPSControlFactory.CreateRPSGridEnumComboBox<ProcessTaskView>("","#a875d36c-ef2f-48e1-80aa-dfe14b055b85 .ag-row[role='row']@ROWINDEX [col-id='cPriority']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<ProcessTaskView>("","#a875d36c-ef2f-48e1-80aa-dfe14b055b85 .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            Comments = RPSControlFactory.CreateRPSGridMemoTextBox<ProcessTaskView>("","#a875d36c-ef2f-48e1-80aa-dfe14b055b85 .ag-row[role='row']@ROWINDEX [col-id='cComments']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ProcessTaskView> CodRequirement { get; set; } 
        public IRPSGridTextBox<ProcessTaskView> Description { get; set; } 
        public IRPSGridTextBox<ProcessTaskView> Scope { get; set; } 
        public IRPSGridComboBox<ProcessTaskView> Priority { get; set; } 
        public IRPSGridComboBox<ProcessTaskView> Type { get; set; } 
        public IRPSGridTextBox<ProcessTaskView> Comments { get; set; } 
                     
    }
 
    }
  
            
    public partial class ProcessIndicatorView : View
    {
        public ProcessIndicatorView(Process screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ProcessIndicatorView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ProcessIndicatorView,ProcessEntityView>( this,Screen.ProcessEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ProcessIndicatorView,ProcessEntityView>( this,Screen.ProcessEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ProcessIndicatorView,ProcessEntityView>( this,Screen.ProcessEntityView);
 
            Description = RPSControlFactory.CreateRPSTextBox<ProcessIndicatorView>("7967d5d7-d151-43d1-8bfe-236eab5e7cd2","","",false, this);
 
            IDIndicatorGroup = RPSControlFactory.CreateRPSComboBox<ProcessIndicatorView>("ae81b023-81c7-4ff5-b5b9-c7958167501f","","",true, this);
 
            IndicatorType = RPSControlFactory.CreateRPSEnumComboBox<ProcessIndicatorView>("29e41a36-a7bd-4a0b-92fe-83fb295ecc9f","","",true, this);
 
            CompareType = RPSControlFactory.CreateRPSEnumComboBox<ProcessIndicatorView>("ab30df98-747d-4248-bea9-b036c597bb29","","",false, this);
 
            Weight = RPSControlFactory.CreateRPSEnumComboBox<ProcessIndicatorView>("4ecc4824-80f1-4124-a747-9ea5173cf2a5","","",true, this);
 
            ValueInterpretation = RPSControlFactory.CreateRPSEnumComboBox<ProcessIndicatorView>("ff003dcf-d717-4378-9337-d3af8f40fdc7","","",true, this);
 
            MeasurementUnit = RPSControlFactory.CreateRPSEnumComboBox<ProcessIndicatorView>("ab56dc56-5575-46f5-95c0-78138e17a78e","","",true, this);
 
            MeasurementUnitOther = RPSControlFactory.CreateRPSTextBox<ProcessIndicatorView>("58cefe30-9e09-4c9a-b7ee-0984978ba0ed","","",false, this);
 
            Periodicity = RPSControlFactory.CreateRPSTextBox<ProcessIndicatorView>("3df0eca5-44bb-4c70-a48d-880ef92bbd4f","","",false, this);
 
            MeasurementResponsible = RPSControlFactory.CreateRPSComboBox<ProcessIndicatorView>("0917347b-be0c-4740-984b-53f01b05ac2e","","",true, this);
 
            ControlResponsible = RPSControlFactory.CreateRPSComboBox<ProcessIndicatorView>("6c3e8167-2add-4e96-bc17-5ff526289753","","",true, this);
 
            Formula = RPSControlFactory.CreateRPSTextBox<ProcessIndicatorView>("c45ab953-cb8e-4edd-a4a0-bd5ef0209131","","",false, this);
 
            Source = RPSControlFactory.CreateRPSTextBox<ProcessIndicatorView>("7675e3b3-7d19-42ad-a08c-b682466d5eca","","",false, this);
 
            Interpretation = RPSControlFactory.CreateRPSTextBox<ProcessIndicatorView>("89af341d-c85b-40bb-ba10-3e0b7f904a56","","",false, this);
 
            CollectionInit params_InfluencedStrategicIndicators = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="90afe985-bdf2-40f0-b7e2-3b9aef019294",CSSSelectorGrid="",XPathGrid=""};
            InfluencedStrategicIndicators = RPSControlFactory.RPSCreateCollectionWithGrid<InfluencedStrategicIndicatorsCollectionEditor<ProcessIndicatorView>,ProcessIndicatorView>( params_InfluencedStrategicIndicators,this);
 
            CollectionInit params_ProcessIndicatorPeriods = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a1fb899c-a162-46dc-9736-fb21b94ecc5d",CSSSelectorGrid="",XPathGrid=""};
            ProcessIndicatorPeriods = RPSControlFactory.RPSCreateCollectionWithGrid<ProcessIndicatorPeriodsCollectionEditor<ProcessIndicatorView>,ProcessIndicatorView>( params_ProcessIndicatorPeriods,this);
 
            GeneralData = RPSControlFactory.CreateRPSSection<ProcessIndicatorView>( "","ul li[rpsid='44a6d093-3c68-4a6c-ba46-913512d002aa']","",this);
 
            Details = RPSControlFactory.CreateRPSSection<ProcessIndicatorView>( "","ul li[rpsid='0d1676f9-60e9-4df4-9764-3878433c8a3c']","",this);
 
            StrategicIndicatorsInfluenced = RPSControlFactory.CreateRPSSection<ProcessIndicatorView>( "","ul li[rpsid='113a4b2a-5b7e-4f7d-ba09-0ea92c91be0b']","",this);
 
            Data = RPSControlFactory.CreateRPSSection<ProcessIndicatorView>( "","ul li[rpsid='de11714a-3d53-4483-a1ce-35c1d8e53dd6']","",this);
 
            Periods = RPSControlFactory.CreateRPSSection<ProcessIndicatorView>( "","ul li[rpsid='41154429-669c-42c8-9539-53474a02672c']","",this);
 

        }
        public IRPSButton<ProcessIndicatorView> DeleteButton { get; set; } 
        public IRPSButton<ProcessIndicatorView,ProcessEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ProcessIndicatorView,ProcessEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ProcessIndicatorView,ProcessEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<ProcessIndicatorView> Description { get; set; } 
        public IRPSComboBox<ProcessIndicatorView> IDIndicatorGroup { get; set; } 
        public IRPSComboBox<ProcessIndicatorView> IndicatorType { get; set; } 
        public IRPSComboBox<ProcessIndicatorView> CompareType { get; set; } 
        public IRPSComboBox<ProcessIndicatorView> Weight { get; set; } 
        public IRPSComboBox<ProcessIndicatorView> ValueInterpretation { get; set; } 
        public IRPSComboBox<ProcessIndicatorView> MeasurementUnit { get; set; } 
        public IRPSTextBox<ProcessIndicatorView> MeasurementUnitOther { get; set; } 
        public IRPSTextBox<ProcessIndicatorView> Periodicity { get; set; } 
        public IRPSComboBox<ProcessIndicatorView> MeasurementResponsible { get; set; } 
        public IRPSComboBox<ProcessIndicatorView> ControlResponsible { get; set; } 
        public IRPSTextBox<ProcessIndicatorView> Formula { get; set; } 
        public IRPSTextBox<ProcessIndicatorView> Source { get; set; } 
        public IRPSTextBox<ProcessIndicatorView> Interpretation { get; set; } 
        public InfluencedStrategicIndicatorsCollectionEditor<ProcessIndicatorView> InfluencedStrategicIndicators { get; set; } 
        public ProcessIndicatorPeriodsCollectionEditor<ProcessIndicatorView> ProcessIndicatorPeriods { get; set; } 
        public IRPSSection<ProcessIndicatorView> GeneralData { get; set; } 
        public IRPSSection<ProcessIndicatorView> Details { get; set; } 
        public IRPSSection<ProcessIndicatorView> StrategicIndicatorsInfluenced { get; set; } 
        public IRPSSection<ProcessIndicatorView> Data { get; set; } 
        public IRPSSection<ProcessIndicatorView> Periods { get; set; } 
        public Process Screen { get; set; }
        public ProcessIndicatorView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class InfluencedStrategicIndicatorsCollectionEditor<ProcessIndicatorView>:RPSCollectionEditor<ProcessIndicatorView> where ProcessIndicatorView : class, IView
    {
        public  InfluencedStrategicIndicatorsGridView<ProcessIndicatorView> GridView {get;set;}
    }
    public partial class InfluencedStrategicIndicatorsGridView <ProcessIndicatorView> :  RPSGridView<ProcessIndicatorView> where ProcessIndicatorView : class, IView
    {
        public InfluencedStrategicIndicatorsGridView(ProcessIndicatorView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDStrategicIndicator = RPSControlFactory.CreateRPSGridComboBox<ProcessIndicatorView>("","#90afe985-bdf2-40f0-b7e2-3b9aef019294 .ag-row[role='row']@ROWINDEX [col-id='cIDStrategicIndicator']","",true, this.CurrentView);
 
            Implication = RPSControlFactory.CreateRPSGridTextBox<ProcessIndicatorView>("","#90afe985-bdf2-40f0-b7e2-3b9aef019294 .ag-row[role='row']@ROWINDEX [col-id='cImplication']","",false, this.CurrentView);
 
            Weight = RPSControlFactory.CreateRPSGridEnumComboBox<ProcessIndicatorView>("","#90afe985-bdf2-40f0-b7e2-3b9aef019294 .ag-row[role='row']@ROWINDEX [col-id='cWeight']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<ProcessIndicatorView> IDStrategicIndicator { get; set; } 
        public IRPSGridTextBox<ProcessIndicatorView> Implication { get; set; } 
        public IRPSGridComboBox<ProcessIndicatorView> Weight { get; set; } 
                     
    }
 
        public partial class ProcessIndicatorPeriodsCollectionEditor<ProcessIndicatorView>:RPSCollectionEditor<ProcessIndicatorView> where ProcessIndicatorView : class, IView
    {
        public  ProcessIndicatorPeriodsGridView<ProcessIndicatorView> GridView {get;set;}
    }
    public partial class ProcessIndicatorPeriodsGridView <ProcessIndicatorView> :  RPSGridView<ProcessIndicatorView> where ProcessIndicatorView : class, IView
    {
        public ProcessIndicatorPeriodsGridView(ProcessIndicatorView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<ProcessIndicatorView>("","#a1fb899c-a162-46dc-9736-fb21b94ecc5d .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",true, this.CurrentView);
 
            DateTo = RPSControlFactory.CreateRPSGridTextBox<ProcessIndicatorView>("","#a1fb899c-a162-46dc-9736-fb21b94ecc5d .ag-row[role='row']@ROWINDEX [col-id='cDateTo']","",true, this.CurrentView);
 
            TargetValue = RPSControlFactory.CreateRPSGridFormattedTextBox<ProcessIndicatorView>("","#a1fb899c-a162-46dc-9736-fb21b94ecc5d .ag-row[role='row']@ROWINDEX [col-id='cTargetValue']","",true, this.CurrentView);
 
            LimitValue = RPSControlFactory.CreateRPSGridFormattedTextBox<ProcessIndicatorView>("","#a1fb899c-a162-46dc-9736-fb21b94ecc5d .ag-row[role='row']@ROWINDEX [col-id='cLimitValue']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<ProcessIndicatorView> DateFrom { get; set; } 
        public IRPSGridTextBox<ProcessIndicatorView> DateTo { get; set; } 
        public IRPSGridTextBox<ProcessIndicatorView> TargetValue { get; set; } 
        public IRPSGridTextBox<ProcessIndicatorView> LimitValue { get; set; } 
                     
    }
 
    }
  
            
    public partial class DuplicateProcessIndicatorPeriodDialogView : View
    {
        public DuplicateProcessIndicatorPeriodDialogView(Process screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDProcess = RPSControlFactory.CreateRPSComboBox<DuplicateProcessIndicatorPeriodDialogView>("02dfaba0-4113-40a3-a16c-04e39e6cef86","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<DuplicateProcessIndicatorPeriodDialogView>("fb64cafb-50ec-44ae-94ee-53b3977f0ab4","","",true, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<DuplicateProcessIndicatorPeriodDialogView>("c4b4dc2a-e8e0-48a2-b103-9a92591c0e8a","","",true, this);
 
            DateFromNew = RPSControlFactory.CreateRPSTextBox<DuplicateProcessIndicatorPeriodDialogView>("92bbd254-18ee-49d9-b2fe-4b1ba080e8c5","","",true, this);
 
            DateToNew = RPSControlFactory.CreateRPSTextBox<DuplicateProcessIndicatorPeriodDialogView>("460afb55-9ac4-4444-8bb5-eb5c09ad2156","","",true, this);
 

        }
        public IRPSComboBox<DuplicateProcessIndicatorPeriodDialogView> IDProcess { get; set; } 
        public IRPSTextBox<DuplicateProcessIndicatorPeriodDialogView> DateFrom { get; set; } 
        public IRPSTextBox<DuplicateProcessIndicatorPeriodDialogView> DateTo { get; set; } 
        public IRPSTextBox<DuplicateProcessIndicatorPeriodDialogView> DateFromNew { get; set; } 
        public IRPSTextBox<DuplicateProcessIndicatorPeriodDialogView> DateToNew { get; set; } 
        public Process Screen { get; set; }
        public DuplicateProcessIndicatorPeriodDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}