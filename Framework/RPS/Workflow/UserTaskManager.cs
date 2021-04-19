    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Workflow.UserTaskManager
{
    //RPS VERSION 1.0.0.0
    public partial class UserTaskManager:Screen
    {
        public UserTaskManager():base()
        {
            this.URL = "workflow.usertaskmanager";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            UserTaskManagerQueryView  = new UserTaskManagerQueryView(this); 
            TaskAsignationDialogView  = new TaskAsignationDialogView(this); 
            UserTaskManagerQueryView.InitializeControls(); 
            TaskAsignationDialogView.InitializeControls(); 
           
        }
      
            public UserTaskManagerQueryView UserTaskManagerQueryView {get; set; } 
            public TaskAsignationDialogView TaskAsignationDialogView {get; set; } 
    }
            
    public partial class UserTaskManagerQueryView : View
    {
        public UserTaskManagerQueryView(UserTaskManager screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIOptTeam = RPSControlFactory.CreateRPSOption<UserTaskManagerQueryView>( "27d0d378-f34e-4282-b71a-27e4b4edeebd","","",this);
 
            UIOptUser = RPSControlFactory.CreateRPSOption<UserTaskManagerQueryView>( "ab8fd3ef-bfc7-411d-b981-056eeb412f36","","",this);
 
            UILstUsers = RPSControlFactory.CreateRPSComboBox<UserTaskManagerQueryView>("05f00563-98ee-49f8-b694-4ff723cc91b4","","",false, this);
 
            UILstWorkflow = RPSControlFactory.CreateRPSComboBox<UserTaskManagerQueryView>("7e3ff743-3a25-4596-a75f-5bf86cbd63b8","","",false, this);
 
            UIIncludeOrphanedTasks = RPSControlFactory.CreateRPSCheckBox<UserTaskManagerQueryView>("e2409cb7-3eb3-4808-bc1e-b20a9573e432","","",false, this);
 
            CollectionInit params_GetHierarchyTasks = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f9932e3b-13e7-4ee7-8377-ce5d812efdea",CSSSelectorGrid="",XPathGrid=""};
            GetHierarchyTasks = RPSControlFactory.RPSCreateCollectionWithGrid<GetHierarchyTasksCollectionEditor<UserTaskManagerQueryView>,UserTaskManagerQueryView>( params_GetHierarchyTasks,this);
 

        }
        public IRPSOption<UserTaskManagerQueryView> UIOptTeam { get; set; } 
        public IRPSOption<UserTaskManagerQueryView> UIOptUser { get; set; } 
        public IRPSComboBox<UserTaskManagerQueryView> UILstUsers { get; set; } 
        public IRPSComboBox<UserTaskManagerQueryView> UILstWorkflow { get; set; } 
        public IRPSCheckbox<UserTaskManagerQueryView> UIIncludeOrphanedTasks { get; set; } 
        public GetHierarchyTasksCollectionEditor<UserTaskManagerQueryView> GetHierarchyTasks { get; set; } 
        public UserTaskManager Screen { get; set; }
        public UserTaskManagerQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetHierarchyTasksCollectionEditor<UserTaskManagerQueryView>:RPSCollectionEditor<UserTaskManagerQueryView> where UserTaskManagerQueryView : class, IView
    {
        public  GetHierarchyTasksGridView<UserTaskManagerQueryView> GridView {get;set;}
    }
    public partial class GetHierarchyTasksGridView <UserTaskManagerQueryView> :  RPSGridView<UserTaskManagerQueryView> where UserTaskManagerQueryView : class, IView
    {
        public GetHierarchyTasksGridView(UserTaskManagerQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Label = RPSControlFactory.CreateRPSGridTextBox<UserTaskManagerQueryView>("","#f9932e3b-13e7-4ee7-8377-ce5d812efdea .ag-row[role='row']@ROWINDEX [col-id='cLabel']","",false, this.CurrentView);
 
            CreationtDate = RPSControlFactory.CreateRPSGridTextBox<UserTaskManagerQueryView>("","#f9932e3b-13e7-4ee7-8377-ce5d812efdea .ag-row[role='row']@ROWINDEX [col-id='cCreationtDate']","",false, this.CurrentView);
 
            AssignedUser = RPSControlFactory.CreateRPSGridComboBox<UserTaskManagerQueryView>("","#f9932e3b-13e7-4ee7-8377-ce5d812efdea .ag-row[role='row']@ROWINDEX [col-id='cAssignedUser']","",false, this.CurrentView);
 
            TaskAsignationCommand = RPSControlFactory.CreateRPSGridButton<UserTaskManagerQueryView>( "","#f9932e3b-13e7-4ee7-8377-ce5d812efdea .ag-row[role='row']@ROWINDEX [col-id='cTaskAsignationCommand']","",this.CurrentView);
 

        }
        public IRPSGridTextBox<UserTaskManagerQueryView> Label { get; set; } 
        public IRPSGridTextBox<UserTaskManagerQueryView> CreationtDate { get; set; } 
        public IRPSGridComboBox<UserTaskManagerQueryView> AssignedUser { get; set; } 
        public IRPSGridButton<UserTaskManagerQueryView> TaskAsignationCommand { get; set; } 
                     
    }
 
    }
  
            
    public partial class TaskAsignationDialogView : View
    {
        public TaskAsignationDialogView(UserTaskManager screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            OKCommand = RPSControlFactory.CreateRPSButton<TaskAsignationDialogView>( "b108cced-7fa4-4fb6-9ecf-33db6c9cda4f","","",this);
 
            CancelCommand = RPSControlFactory.CreateRPSButton<TaskAsignationDialogView>( "aeb59cc5-f256-4d21-9008-8873a7ac66c9","","",this);
 
            CollectionInit params_GetUserTaskAssignations = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5fefe52b-3942-461a-9523-360aa79fd125",CSSSelectorGrid="",XPathGrid=""};
            GetUserTaskAssignations = RPSControlFactory.RPSCreateCollectionWithGrid<GetUserTaskAssignationsCollectionEditor<TaskAsignationDialogView>,TaskAsignationDialogView>( params_GetUserTaskAssignations,this);
 
            CollectionInit params_GetRoleTaskAssignations = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="e6862687-b03d-4028-a698-67c031f05986",CSSSelectorGrid="",XPathGrid=""};
            GetRoleTaskAssignations = RPSControlFactory.RPSCreateCollectionWithGrid<GetRoleTaskAssignationsCollectionEditor<TaskAsignationDialogView>,TaskAsignationDialogView>( params_GetRoleTaskAssignations,this);
 
            User = RPSControlFactory.CreateRPSSection<TaskAsignationDialogView>( "","ul li[rpsid='6f66f0cf-e57b-4fe9-aa5a-cbc876ed5abb']","",this);
 
            Role = RPSControlFactory.CreateRPSSection<TaskAsignationDialogView>( "","ul li[rpsid='b718ec2c-3256-40d4-8e18-a5bccab890ca']","",this);
 

        }
        public IRPSButton<TaskAsignationDialogView> OKCommand { get; set; } 
        public IRPSButton<TaskAsignationDialogView> CancelCommand { get; set; } 
        public GetUserTaskAssignationsCollectionEditor<TaskAsignationDialogView> GetUserTaskAssignations { get; set; } 
        public GetRoleTaskAssignationsCollectionEditor<TaskAsignationDialogView> GetRoleTaskAssignations { get; set; } 
        public IRPSSection<TaskAsignationDialogView> User { get; set; } 
        public IRPSSection<TaskAsignationDialogView> Role { get; set; } 
        public UserTaskManager Screen { get; set; }
        public TaskAsignationDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetUserTaskAssignationsCollectionEditor<TaskAsignationDialogView>:RPSCollectionEditor<TaskAsignationDialogView> where TaskAsignationDialogView : class, IView
    {
        public  GetUserTaskAssignationsGridView<TaskAsignationDialogView> GridView {get;set;}
    }
    public partial class GetUserTaskAssignationsGridView <TaskAsignationDialogView> :  RPSGridView<TaskAsignationDialogView> where TaskAsignationDialogView : class, IView
    {
        public GetUserTaskAssignationsGridView(TaskAsignationDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            TaskAsignation = RPSControlFactory.CreateRPSGridCheckBox<TaskAsignationDialogView>("","#5fefe52b-3942-461a-9523-360aa79fd125 .ag-row[role='row']@ROWINDEX [col-id='cTaskAsignation']","",false, this.CurrentView);
 

        }
        public IRPSGridCheckbox<TaskAsignationDialogView> TaskAsignation { get; set; } 
                     
    }
 
        public partial class GetRoleTaskAssignationsCollectionEditor<TaskAsignationDialogView>:RPSCollectionEditor<TaskAsignationDialogView> where TaskAsignationDialogView : class, IView
    {
        public  GetRoleTaskAssignationsGridView<TaskAsignationDialogView> GridView {get;set;}
    }
    public partial class GetRoleTaskAssignationsGridView <TaskAsignationDialogView> :  RPSGridView<TaskAsignationDialogView> where TaskAsignationDialogView : class, IView
    {
        public GetRoleTaskAssignationsGridView(TaskAsignationDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            TaskAsignation = RPSControlFactory.CreateRPSGridCheckBox<TaskAsignationDialogView>("","#e6862687-b03d-4028-a698-67c031f05986 .ag-row[role='row']@ROWINDEX [col-id='cTaskAsignation']","",false, this.CurrentView);
 

        }
        public IRPSGridCheckbox<TaskAsignationDialogView> TaskAsignation { get; set; } 
                     
    }
 
    }
  
    

}