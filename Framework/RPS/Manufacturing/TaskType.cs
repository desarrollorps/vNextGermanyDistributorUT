    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.TaskType
{
    //RPS VERSION 1.0.0.0
    public partial class TaskType:Screen
    {
        public TaskType():base()
        {
            this.URL = "manufacturing.tasktype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            TaskTypeSTRCollectionView  = new TaskTypeSTRCollectionView(this); 
            TaskTypeSTREntityView  = new TaskTypeSTREntityView(this); 
            TaskTypeSTRCollectionView.InitializeControls(); 
            TaskTypeSTREntityView.InitializeControls(); 
           
        }
      
            public TaskTypeSTRCollectionView TaskTypeSTRCollectionView {get; set; } 
            public TaskTypeSTREntityView TaskTypeSTREntityView {get; set; } 
    }
            
    public partial class TaskTypeSTRCollectionView : View
    {
        public TaskTypeSTRCollectionView(TaskType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<TaskTypeSTRCollectionView,TaskTypeSTREntityView>( this,Screen.TaskTypeSTREntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "22444266-0066-49bf-824b-29dd084863d1",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<TaskTypeSTRCollectionView,TaskTypeSTREntityView>( params_MainConsult,this,Screen.TaskTypeSTREntityView);
 

        }
        public IRPSButton<TaskTypeSTRCollectionView,TaskTypeSTREntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<TaskTypeSTRCollectionView,TaskTypeSTREntityView> MainConsult { get; set; } 
        public TaskType Screen { get; set; }
        public TaskTypeSTRCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class TaskTypeSTREntityView : View
    {
        public TaskTypeSTREntityView(TaskType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<TaskTypeSTREntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<TaskTypeSTREntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<TaskTypeSTREntityView,TaskTypeSTRCollectionView>( this,Screen.TaskTypeSTRCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<TaskTypeSTREntityView,TaskTypeSTRCollectionView>( this,Screen.TaskTypeSTRCollectionView);
 
            CodTaskType = RPSControlFactory.CreateRPSTextBox<TaskTypeSTREntityView>("ef2efb56-21de-4d20-b11c-4254e8710357","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<TaskTypeSTREntityView>("893284a5-6325-43af-8651-c4fe65d49b5a","","",false, this);
 
            IDBudgetEmployee = RPSControlFactory.CreateRPSComboBox<TaskTypeSTREntityView>("b7b4238b-ce46-42d2-8618-6e114c14ea25","","",false, this);
 
            IDBudgetMachine = RPSControlFactory.CreateRPSComboBox<TaskTypeSTREntityView>("78216b87-a193-4c47-b16a-243ef31c3a73","","",false, this);
 
            IDBudgetMaterial = RPSControlFactory.CreateRPSComboBox<TaskTypeSTREntityView>("41d306be-5027-41c4-baf7-aa0e0f63ba99","","",false, this);
 
            IDBudgetTool = RPSControlFactory.CreateRPSComboBox<TaskTypeSTREntityView>("c8bd8c07-605d-447f-b52e-0d28f2e7ac26","","",false, this);
 
            IDBudgetOtherCost = RPSControlFactory.CreateRPSComboBox<TaskTypeSTREntityView>("8190cc78-8bd8-4d90-b495-eed36a63daf6","","",false, this);
 
            IDBudgetExternal = RPSControlFactory.CreateRPSComboBox<TaskTypeSTREntityView>("388cb295-77e2-4c48-9ccc-29fcf8c6ea9e","","",false, this);
 

        }
        public IRPSSaveButton<TaskTypeSTREntityView> SaveButton { get; set; } 
        public IRPSButton<TaskTypeSTREntityView> DeleteButton { get; set; } 
        public IRPSButton<TaskTypeSTREntityView,TaskTypeSTRCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<TaskTypeSTREntityView,TaskTypeSTRCollectionView> BackButton { get; set; } 
        public IRPSTextBox<TaskTypeSTREntityView> CodTaskType { get; set; } 
        public IRPSTextBox<TaskTypeSTREntityView> Description { get; set; } 
        public IRPSComboBox<TaskTypeSTREntityView> IDBudgetEmployee { get; set; } 
        public IRPSComboBox<TaskTypeSTREntityView> IDBudgetMachine { get; set; } 
        public IRPSComboBox<TaskTypeSTREntityView> IDBudgetMaterial { get; set; } 
        public IRPSComboBox<TaskTypeSTREntityView> IDBudgetTool { get; set; } 
        public IRPSComboBox<TaskTypeSTREntityView> IDBudgetOtherCost { get; set; } 
        public IRPSComboBox<TaskTypeSTREntityView> IDBudgetExternal { get; set; } 
        public TaskType Screen { get; set; }
        public TaskTypeSTREntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}