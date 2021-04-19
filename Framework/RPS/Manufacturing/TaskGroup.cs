    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.TaskGroup
{
    //RPS VERSION 1.0.0.0
    public partial class TaskGroup:Screen
    {
        public TaskGroup():base()
        {
            this.URL = "manufacturing.taskgroup";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            TaskGroupQueryView  = new TaskGroupQueryView(this); 
            TaskGroupQueryView.InitializeControls(); 
           
        }
      
            public TaskGroupQueryView TaskGroupQueryView {get; set; } 
    }
            
    public partial class TaskGroupQueryView : View
    {
        public TaskGroupQueryView(TaskGroup screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UISite = RPSControlFactory.CreateRPSComboBox<TaskGroupQueryView>("9fbb7ef7-ad81-466e-baa2-491cae590fda","","",false, this);
 
            UIInternalCode = RPSControlFactory.CreateRPSTextBox<TaskGroupQueryView>("3ce144ea-24f1-46b4-950c-e8d69a190317","","",false, this);
 
            UIDateFrom = RPSControlFactory.CreateRPSTextBox<TaskGroupQueryView>("ecd2d7dc-e72e-443a-8007-b1b7cd84828c","","",false, this);
 
            UIDateTo = RPSControlFactory.CreateRPSTextBox<TaskGroupQueryView>("09280b9d-9cb8-49e3-bc69-45254e5e68ad","","",false, this);
 
            UIArticle = RPSControlFactory.CreateRPSCollectionComboBox<TaskGroupQueryView>("42a7aeae-4eac-4449-ad39-9f5b3e2ba6f2","","",false, this);
 
            UIOptimizationFeature = RPSControlFactory.CreateRPSTextBox<TaskGroupQueryView>("907f6803-3d53-419e-a941-2add16d8c682","","",false, this);
 
            UITaskType = RPSControlFactory.CreateRPSComboBox<TaskGroupQueryView>("26465bd4-1983-409c-a38e-9e061f125f77","","",false, this);
 
            UIUsualTask = RPSControlFactory.CreateRPSComboBox<TaskGroupQueryView>("10ef21d0-8f7a-49ff-a52c-d1586674c5a8","","",false, this);
 
            DesGroupOfTask = RPSControlFactory.CreateRPSTextBox<TaskGroupQueryView>("7700142b-d892-406d-b618-166227900618","","",false, this);
 
            IDMachineGroupFilter = RPSControlFactory.CreateRPSComboBox<TaskGroupQueryView>("4b344ed5-86f2-4776-af31-6bf060dca131","","",false, this);
 
            IDMachineFilter = RPSControlFactory.CreateRPSComboBox<TaskGroupQueryView>("28135134-4b70-4e3c-b9ea-0f02ed6aa2d2","","",false, this);
 
            IDManufacturingOrderFilter = RPSControlFactory.CreateRPSComboBox<TaskGroupQueryView>("1fede72d-1891-4b94-aaba-93336cc666b5","","",false, this);
 
            GroupCommandButton = RPSControlFactory.CreateRPSButton<TaskGroupQueryView>( "6420c387-7971-450a-b822-1f04808c16bc","","",this);
 
            RemoveGroupCommandButton = RPSControlFactory.CreateRPSButton<TaskGroupQueryView>( "8da7e7b0-4143-4fef-ae9c-1116be91bcdd","","",this);
 
            CollectionInit params_GetPendingTasks = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f3f42cac-68f4-474a-827b-13e693811c7f",CSSSelectorGrid="",XPathGrid=""};
            GetPendingTasks = RPSControlFactory.RPSCreateCollectionWithGrid<GetPendingTasksCollectionEditor<TaskGroupQueryView>,TaskGroupQueryView>( params_GetPendingTasks,this);
 

        }
        public IRPSComboBox<TaskGroupQueryView> UISite { get; set; } 
        public IRPSTextBox<TaskGroupQueryView> UIInternalCode { get; set; } 
        public IRPSTextBox<TaskGroupQueryView> UIDateFrom { get; set; } 
        public IRPSTextBox<TaskGroupQueryView> UIDateTo { get; set; } 
        public IRPSCollectionComboBox<TaskGroupQueryView> UIArticle { get; set; } 
        public IRPSTextBox<TaskGroupQueryView> UIOptimizationFeature { get; set; } 
        public IRPSComboBox<TaskGroupQueryView> UITaskType { get; set; } 
        public IRPSComboBox<TaskGroupQueryView> UIUsualTask { get; set; } 
        public IRPSTextBox<TaskGroupQueryView> DesGroupOfTask { get; set; } 
        public IRPSComboBox<TaskGroupQueryView> IDMachineGroupFilter { get; set; } 
        public IRPSComboBox<TaskGroupQueryView> IDMachineFilter { get; set; } 
        public IRPSComboBox<TaskGroupQueryView> IDManufacturingOrderFilter { get; set; } 
        public IRPSButton<TaskGroupQueryView> GroupCommandButton { get; set; } 
        public IRPSButton<TaskGroupQueryView> RemoveGroupCommandButton { get; set; } 
        public GetPendingTasksCollectionEditor<TaskGroupQueryView> GetPendingTasks { get; set; } 
        public TaskGroup Screen { get; set; }
        public TaskGroupQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetPendingTasksCollectionEditor<TaskGroupQueryView>:RPSCollectionEditor<TaskGroupQueryView> where TaskGroupQueryView : class, IView
    {
        public  GetPendingTasksGridView<TaskGroupQueryView> GridView {get;set;}
    }
    public partial class GetPendingTasksGridView <TaskGroupQueryView> :  RPSGridView<TaskGroupQueryView> where TaskGroupQueryView : class, IView
    {
        public GetPendingTasksGridView(TaskGroupQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            GroupingNumber = RPSControlFactory.CreateRPSGridTextBox<TaskGroupQueryView>("","#f3f42cac-68f4-474a-827b-13e693811c7f .ag-row[role='row']@ROWINDEX [col-id='cGroupingNumber']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<TaskGroupQueryView>("","#f3f42cac-68f4-474a-827b-13e693811c7f .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            InternalCode = RPSControlFactory.CreateRPSGridTextBox<TaskGroupQueryView>("","#f3f42cac-68f4-474a-827b-13e693811c7f .ag-row[role='row']@ROWINDEX [col-id='cInternalCode']","",false, this.CurrentView);
 
            PlannedEndDate = RPSControlFactory.CreateRPSGridTextBox<TaskGroupQueryView>("","#f3f42cac-68f4-474a-827b-13e693811c7f .ag-row[role='row']@ROWINDEX [col-id='cPlannedEndDate']","",false, this.CurrentView);
 
            PercentProgressOfTask = RPSControlFactory.CreateRPSGridFormattedTextBox<TaskGroupQueryView>("","#f3f42cac-68f4-474a-827b-13e693811c7f .ag-row[role='row']@ROWINDEX [col-id='cPercentProgressOfTask']","",false, this.CurrentView);
 
            QPendingValue = RPSControlFactory.CreateRPSGridFormattedTextBox<TaskGroupQueryView>("","#f3f42cac-68f4-474a-827b-13e693811c7f .ag-row[role='row']@ROWINDEX [col-id='cQPendingValue']","",false, this.CurrentView);
 
            OptimizationFeature = RPSControlFactory.CreateRPSGridTextBox<TaskGroupQueryView>("","#f3f42cac-68f4-474a-827b-13e693811c7f .ag-row[role='row']@ROWINDEX [col-id='cOptimizationFeature']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<TaskGroupQueryView> GroupingNumber { get; set; } 
        public IRPSGridTextBox<TaskGroupQueryView> Quantity { get; set; } 
        public IRPSGridTextBox<TaskGroupQueryView> InternalCode { get; set; } 
        public IRPSGridTextBox<TaskGroupQueryView> PlannedEndDate { get; set; } 
        public IRPSGridTextBox<TaskGroupQueryView> PercentProgressOfTask { get; set; } 
        public IRPSGridTextBox<TaskGroupQueryView> QPendingValue { get; set; } 
        public IRPSGridTextBox<TaskGroupQueryView> OptimizationFeature { get; set; } 
                     
    }
 
    }
  
    

}