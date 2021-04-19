    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Workflow.WorkflowExecutionReport
{
    //RPS VERSION 1.0.0.0
    public partial class WorkflowExecutionReport:Screen
    {
        public WorkflowExecutionReport():base()
        {
            this.URL = "workflow.workflowexecutionreport";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            WorkflowExecutionReportView  = new WorkflowExecutionReportView(this); 
            WorkflowExecutionReportView.InitializeControls(); 
           
        }
      
            public WorkflowExecutionReportView WorkflowExecutionReportView {get; set; } 
    }
            
    public partial class WorkflowExecutionReportView : View
    {
        public WorkflowExecutionReportView(WorkflowExecutionReport screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIWorkflowGroup = RPSControlFactory.CreateRPSComboBox<WorkflowExecutionReportView>("848a4956-e6f2-47dc-b374-defa1e2edb21","","",false, this);
 
            UIWorkflow = RPSControlFactory.CreateRPSComboBox<WorkflowExecutionReportView>("34a791d1-aeb5-421b-8e10-8d4b744a3716","","",false, this);
 
            UIWorkflowVersion = RPSControlFactory.CreateRPSComboBox<WorkflowExecutionReportView>("f629c1fa-d4f1-4d14-aaeb-2626d74d4a16","","",false, this);
 
            ExecuteWorkflowExecutionReport = RPSControlFactory.CreateRPSButton<WorkflowExecutionReportView>( "cf242a0d-0147-4490-843a-c29b84f1c4d3","","",this);
 
            UIAverageDuration = RPSControlFactory.CreateRPSTextBox<WorkflowExecutionReportView>("c2192efd-dd68-4b7b-9510-3d410c2fe904","","",false, this);
 
            UIExecutionCount = RPSControlFactory.CreateRPSFormattedTextBox<WorkflowExecutionReportView>("782a2fa4-7e14-4706-92e2-d86250d5b48f","","",false, this);
 
            CollectionInit params_WorkflowExecutionReport = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ab05c82f-74e5-448c-9ba9-0645eed958ee",CSSSelectorGrid="",XPathGrid=""};
            WorkflowExecutionReport = RPSControlFactory.RPSCreateCollectionWithGrid<WorkflowExecutionReportCollectionEditor<WorkflowExecutionReportView>,WorkflowExecutionReportView>( params_WorkflowExecutionReport,this);
 

        }
        public IRPSComboBox<WorkflowExecutionReportView> UIWorkflowGroup { get; set; } 
        public IRPSComboBox<WorkflowExecutionReportView> UIWorkflow { get; set; } 
        public IRPSComboBox<WorkflowExecutionReportView> UIWorkflowVersion { get; set; } 
        public IRPSButton<WorkflowExecutionReportView> ExecuteWorkflowExecutionReport { get; set; } 
        public IRPSTextBox<WorkflowExecutionReportView> UIAverageDuration { get; set; } 
        public IRPSTextBox<WorkflowExecutionReportView> UIExecutionCount { get; set; } 
        public WorkflowExecutionReportCollectionEditor<WorkflowExecutionReportView> WorkflowExecutionReport { get; set; } 
        public WorkflowExecutionReport Screen { get; set; }
        public WorkflowExecutionReportView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class WorkflowExecutionReportCollectionEditor<WorkflowExecutionReportView>:RPSCollectionEditor<WorkflowExecutionReportView> where WorkflowExecutionReportView : class, IView
    {
        public  WorkflowExecutionReportGridView<WorkflowExecutionReportView> GridView {get;set;}
    }
    public partial class WorkflowExecutionReportGridView <WorkflowExecutionReportView> :  RPSGridView<WorkflowExecutionReportView> where WorkflowExecutionReportView : class, IView
    {
        public WorkflowExecutionReportGridView(WorkflowExecutionReportView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            AverageDurationStr = RPSControlFactory.CreateRPSGridTextBox<WorkflowExecutionReportView>("","#ab05c82f-74e5-448c-9ba9-0645eed958ee .ag-row[role='row']@ROWINDEX [col-id='cAverageDurationStr']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<WorkflowExecutionReportView> AverageDurationStr { get; set; } 
                     
    }
 
    }
  
    

}