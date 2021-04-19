    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.TaskType
{
    //RPS VERSION 1.0.0.0
    public partial class TaskType:Screen
    {
        public TaskType():base()
        {
            this.URL = "project.tasktype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            TaskTypeCollectionView  = new TaskTypeCollectionView(this); 
            TaskTypeEntityView  = new TaskTypeEntityView(this); 
            TaskTypeCollectionView.InitializeControls(); 
            TaskTypeEntityView.InitializeControls(); 
           
        }
      
            public TaskTypeCollectionView TaskTypeCollectionView {get; set; } 
            public TaskTypeEntityView TaskTypeEntityView {get; set; } 
    }
            
    public partial class TaskTypeCollectionView : View
    {
        public TaskTypeCollectionView(TaskType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<TaskTypeCollectionView,TaskTypeEntityView>( this,Screen.TaskTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "2d60cb49-4820-4b7f-8698-2a72ae45cf0f",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<TaskTypeCollectionView,TaskTypeEntityView>( params_MainConsult,this,Screen.TaskTypeEntityView);
 

        }
        public IRPSButton<TaskTypeCollectionView,TaskTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<TaskTypeCollectionView,TaskTypeEntityView> MainConsult { get; set; } 
        public TaskType Screen { get; set; }
        public TaskTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class TaskTypeEntityView : View
    {
        public TaskTypeEntityView(TaskType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<TaskTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<TaskTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<TaskTypeEntityView,TaskTypeCollectionView>( this,Screen.TaskTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<TaskTypeEntityView,TaskTypeCollectionView>( this,Screen.TaskTypeCollectionView);
 
            CodTaskType = RPSControlFactory.CreateRPSTextBox<TaskTypeEntityView>("86a8e3aa-894a-4ba7-ad4b-517da9cbef72","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<TaskTypeEntityView>("5afe0e16-b671-40c3-8047-ad2d72fdc332","","",false, this);
 
            IDBudgetEmployee = RPSControlFactory.CreateRPSComboBox<TaskTypeEntityView>("083dc660-9c5c-4c7a-b4ef-59bc15f6ee12","","",false, this);
 
            IDBudgetMachine = RPSControlFactory.CreateRPSComboBox<TaskTypeEntityView>("7590dc76-c1cb-4a61-a6c5-f44903d85794","","",false, this);
 
            IDBudgetMaterial = RPSControlFactory.CreateRPSComboBox<TaskTypeEntityView>("76bb5fdd-7015-46f7-ba95-76f2367ebed5","","",false, this);
 
            IDBudgetTool = RPSControlFactory.CreateRPSComboBox<TaskTypeEntityView>("e5bc424a-64a2-4e73-b43f-a5e883a77772","","",false, this);
 
            IDBudgetOtherCost = RPSControlFactory.CreateRPSComboBox<TaskTypeEntityView>("630c8b2f-e32a-4386-b3f7-396aff229960","","",false, this);
 
            IDBudgetExternal = RPSControlFactory.CreateRPSComboBox<TaskTypeEntityView>("14a143d0-4034-4572-bd97-ef72b82215b8","","",false, this);
 

        }
        public IRPSSaveButton<TaskTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<TaskTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<TaskTypeEntityView,TaskTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<TaskTypeEntityView,TaskTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<TaskTypeEntityView> CodTaskType { get; set; } 
        public IRPSTextBox<TaskTypeEntityView> Description { get; set; } 
        public IRPSComboBox<TaskTypeEntityView> IDBudgetEmployee { get; set; } 
        public IRPSComboBox<TaskTypeEntityView> IDBudgetMachine { get; set; } 
        public IRPSComboBox<TaskTypeEntityView> IDBudgetMaterial { get; set; } 
        public IRPSComboBox<TaskTypeEntityView> IDBudgetTool { get; set; } 
        public IRPSComboBox<TaskTypeEntityView> IDBudgetOtherCost { get; set; } 
        public IRPSComboBox<TaskTypeEntityView> IDBudgetExternal { get; set; } 
        public TaskType Screen { get; set; }
        public TaskTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}