    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.ProjectTaskManager
{
    //RPS VERSION 1.0.0.0
    public partial class ProjectTaskManager:Screen
    {
        public ProjectTaskManager():base()
        {
            this.URL = "project.projecttaskmanager";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ProjectTaskManagerView  = new ProjectTaskManagerView(this); 
            NewProjectGanttItemView  = new NewProjectGanttItemView(this); 
            EditProjectGanttItemView  = new EditProjectGanttItemView(this); 
            ProjectTasksPendingDialogView  = new ProjectTasksPendingDialogView(this); 
            ProjectTaskManagerView.InitializeControls(); 
            NewProjectGanttItemView.InitializeControls(); 
            EditProjectGanttItemView.InitializeControls(); 
            ProjectTasksPendingDialogView.InitializeControls(); 
           
        }
      
            public ProjectTaskManagerView ProjectTaskManagerView {get; set; } 
            public NewProjectGanttItemView NewProjectGanttItemView {get; set; } 
            public EditProjectGanttItemView EditProjectGanttItemView {get; set; } 
            public ProjectTasksPendingDialogView ProjectTasksPendingDialogView {get; set; } 
    }
            
    public partial class ProjectTaskManagerView : View
    {
        public ProjectTaskManagerView(ProjectTaskManager screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIStartLoadDate = RPSControlFactory.CreateRPSTextBox<ProjectTaskManagerView>("0f4f6634-8702-4c0c-9a85-778e45ec86e8","","",true, this);
 
            UIIDSite = RPSControlFactory.CreateRPSComboBox<ProjectTaskManagerView>("088611f7-99a3-4f15-82eb-7a6850a00eea","","",false, this);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<ProjectTaskManagerView>("7bb6d247-3a47-47f4-a93b-1742dbdfa58d","","",false, this);
 
            UIeTypeEmployee = RPSControlFactory.CreateRPSEnumComboBox<ProjectTaskManagerView>("fbb2a422-a813-48a1-b5d6-11677b2eda12","","",false, this);
 
            UIIDDepartment = RPSControlFactory.CreateRPSComboBox<ProjectTaskManagerView>("bf14989b-ec19-4ef3-80e4-eef06671a09e","","",false, this);
 
            UIIDCategory = RPSControlFactory.CreateRPSComboBox<ProjectTaskManagerView>("4b3dde9c-b737-456a-bb8d-8df86822c515","","",false, this);
 
            UIIDQualify = RPSControlFactory.CreateRPSComboBox<ProjectTaskManagerView>("9c8d5700-ad36-4e0a-acd9-3e7fdc7231c4","","",false, this);
 
            QueryCommand = RPSControlFactory.CreateRPSButton<ProjectTaskManagerView>( "fedd3eac-ba2c-432b-b6f1-62b9dbad8cde","","",this);
 
            ProjectTasksPendingNavigationCommand = RPSControlFactory.CreateRPSButtonToView<ProjectTaskManagerView,ProjectTasksPendingDialogView>("cfe90c01-3fe0-4183-8b66-87a129a5ee46","","", this,Screen.ProjectTasksPendingDialogView);
 

        }
        public IRPSTextBox<ProjectTaskManagerView> UIStartLoadDate { get; set; } 
        public IRPSComboBox<ProjectTaskManagerView> UIIDSite { get; set; } 
        public IRPSComboBox<ProjectTaskManagerView> IDEmployee { get; set; } 
        public IRPSComboBox<ProjectTaskManagerView> UIeTypeEmployee { get; set; } 
        public IRPSComboBox<ProjectTaskManagerView> UIIDDepartment { get; set; } 
        public IRPSComboBox<ProjectTaskManagerView> UIIDCategory { get; set; } 
        public IRPSComboBox<ProjectTaskManagerView> UIIDQualify { get; set; } 
        public IRPSButton<ProjectTaskManagerView> QueryCommand { get; set; } 
        public IRPSButton<ProjectTaskManagerView,ProjectTasksPendingDialogView> ProjectTasksPendingNavigationCommand { get; set; } 
        public ProjectTaskManager Screen { get; set; }
        public ProjectTaskManagerView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NewProjectGanttItemView : View
    {
        public NewProjectGanttItemView(ProjectTaskManager screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Project = RPSControlFactory.CreateRPSOption<NewProjectGanttItemView>( "fa8a98b7-f296-4032-a1d8-0dece73f8ed0","","",this);
 
            StopResource = RPSControlFactory.CreateRPSOption<NewProjectGanttItemView>( "a784bb58-b8fd-49e2-b124-d65ba5e7675d","","",this);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<NewProjectGanttItemView>("52fa4f6c-9552-41de-8919-88dac08026bc","","",false, this);
 
            IDProjectTask = RPSControlFactory.CreateRPSComboBox<NewProjectGanttItemView>("5a36a654-c55d-4e2d-8563-2bcbfeb31dbe","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<NewProjectGanttItemView>("e2fcea23-69c7-42d3-97b0-834941b4bd26","","",false, this);
 
            IDStopType = RPSControlFactory.CreateRPSComboBox<NewProjectGanttItemView>("095aaeca-3103-4dd9-b6dd-b3e412362834","","",false, this);
 
            Unique = RPSControlFactory.CreateRPSOption<NewProjectGanttItemView>( "765e02e2-d080-4ba0-91b4-31c88391882a","","",this);
 
            AllDays = RPSControlFactory.CreateRPSOption<NewProjectGanttItemView>( "53ceaff4-f972-4ef5-ad3d-eee43019491b","","",this);
 
            Week = RPSControlFactory.CreateRPSOption<NewProjectGanttItemView>( "25a89969-2daa-43ac-b4f8-7483ab825da2","","",this);
 
            UIMonday = RPSControlFactory.CreateRPSCheckBox<NewProjectGanttItemView>("eae53b10-6170-4476-91c2-e50c097345e9","","",false, this);
 
            UITuesday = RPSControlFactory.CreateRPSCheckBox<NewProjectGanttItemView>("2580e343-9786-4e9a-8c3b-0ace485eee61","","",false, this);
 
            UIWednesday = RPSControlFactory.CreateRPSCheckBox<NewProjectGanttItemView>("250918f0-fdd4-42e7-9c41-cca29930f303","","",false, this);
 
            UIThursday = RPSControlFactory.CreateRPSCheckBox<NewProjectGanttItemView>("08aaf4f2-4e80-4f11-93dc-0337252b67e7","","",false, this);
 
            UIFriday = RPSControlFactory.CreateRPSCheckBox<NewProjectGanttItemView>("7e4f1b14-9f7a-43c8-8099-92755f8cff1d","","",false, this);
 
            UISaturday = RPSControlFactory.CreateRPSCheckBox<NewProjectGanttItemView>("1816fcb4-e8ef-4dc4-9245-6170630d2622","","",false, this);
 
            UISunday = RPSControlFactory.CreateRPSCheckBox<NewProjectGanttItemView>("3c89c60d-a59d-4ebf-8db0-95df549bf0d3","","",false, this);
 
            Each = RPSControlFactory.CreateRPSOption<NewProjectGanttItemView>( "a4ec575f-ed45-4c08-966a-bed473d5de0a","","",this);
 
            UIPeriodicityDays = RPSControlFactory.CreateRPSFormattedTextBox<NewProjectGanttItemView>("8ff8f0b5-db58-4bc6-9bd3-440e5bfd0c0c","","",false, this);
 
            AppointmentDateStart = RPSControlFactory.CreateRPSTextBox<NewProjectGanttItemView>("10d87034-eabe-4c9d-a622-200b03d14981","","",true, this);
 
            AppointmentDateEnd = RPSControlFactory.CreateRPSTextBox<NewProjectGanttItemView>("8c88df61-626e-4908-8f96-753d8a5acc11","","",true, this);
 
            UIStartHourTime = RPSControlFactory.CreateRPSTextBox<NewProjectGanttItemView>("3c211b68-0ed6-4242-96c7-408fb5d9a932","","",true, this);
 
            UIEndHourTime = RPSControlFactory.CreateRPSTextBox<NewProjectGanttItemView>("9ba6076d-bad2-44fc-b7ab-470b85366453","","",true, this);
 
            UIIsAllDay = RPSControlFactory.CreateRPSCheckBox<NewProjectGanttItemView>("a5c52957-3ceb-4ae5-9090-69105c393a95","","",false, this);
 

        }
        public IRPSOption<NewProjectGanttItemView> Project { get; set; } 
        public IRPSOption<NewProjectGanttItemView> StopResource { get; set; } 
        public IRPSComboBox<NewProjectGanttItemView> IDProject { get; set; } 
        public IRPSComboBox<NewProjectGanttItemView> IDProjectTask { get; set; } 
        public IRPSTextBox<NewProjectGanttItemView> Comment { get; set; } 
        public IRPSComboBox<NewProjectGanttItemView> IDStopType { get; set; } 
        public IRPSOption<NewProjectGanttItemView> Unique { get; set; } 
        public IRPSOption<NewProjectGanttItemView> AllDays { get; set; } 
        public IRPSOption<NewProjectGanttItemView> Week { get; set; } 
        public IRPSCheckbox<NewProjectGanttItemView> UIMonday { get; set; } 
        public IRPSCheckbox<NewProjectGanttItemView> UITuesday { get; set; } 
        public IRPSCheckbox<NewProjectGanttItemView> UIWednesday { get; set; } 
        public IRPSCheckbox<NewProjectGanttItemView> UIThursday { get; set; } 
        public IRPSCheckbox<NewProjectGanttItemView> UIFriday { get; set; } 
        public IRPSCheckbox<NewProjectGanttItemView> UISaturday { get; set; } 
        public IRPSCheckbox<NewProjectGanttItemView> UISunday { get; set; } 
        public IRPSOption<NewProjectGanttItemView> Each { get; set; } 
        public IRPSTextBox<NewProjectGanttItemView> UIPeriodicityDays { get; set; } 
        public IRPSTextBox<NewProjectGanttItemView> AppointmentDateStart { get; set; } 
        public IRPSTextBox<NewProjectGanttItemView> AppointmentDateEnd { get; set; } 
        public IRPSTextBox<NewProjectGanttItemView> UIStartHourTime { get; set; } 
        public IRPSTextBox<NewProjectGanttItemView> UIEndHourTime { get; set; } 
        public IRPSCheckbox<NewProjectGanttItemView> UIIsAllDay { get; set; } 
        public ProjectTaskManager Screen { get; set; }
        public NewProjectGanttItemView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class EditProjectGanttItemView : View
    {
        public EditProjectGanttItemView(ProjectTaskManager screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<EditProjectGanttItemView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<EditProjectGanttItemView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<EditProjectGanttItemView,ProjectTaskManagerView>( this,Screen.ProjectTaskManagerView);
 
            BackButton = RPSControlFactory.RPSBackButton<EditProjectGanttItemView,ProjectTaskManagerView>( this,Screen.ProjectTaskManagerView);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<EditProjectGanttItemView>("e64050ea-ea51-45c2-b7fe-7da8bd6eebb7","","",false, this);
 
            IDProTask = RPSControlFactory.CreateRPSComboBox<EditProjectGanttItemView>("67ab4256-7cdf-4f03-b94f-b2b6e3e7c08a","","",false, this);
 
            AppointmentNotes = RPSControlFactory.CreateRPSTextBox<EditProjectGanttItemView>("06ce3751-9440-434a-ac33-b59dbd36c2e6","","",false, this);
 
            IDStopType = RPSControlFactory.CreateRPSComboBox<EditProjectGanttItemView>("d8e1a2af-642d-4d7c-9173-8fb70ac0de0d","","",false, this);
 
            IDMaintenanceOrder = RPSControlFactory.CreateRPSComboBox<EditProjectGanttItemView>("ea542edb-2ebc-44d8-974b-87cf9cbba46f","","",false, this);
 
            AppointmentNotes1 = RPSControlFactory.CreateRPSTextBox<EditProjectGanttItemView>("d923b3bb-bb63-4e70-9437-1d1adb970827","","",false, this);
 
            IDManufacturingOrder = RPSControlFactory.CreateRPSComboBox<EditProjectGanttItemView>("031e234d-5391-4202-94cc-897aa6e8e5d5","","",false, this);
 
            IDMOTask = RPSControlFactory.CreateRPSComboBox<EditProjectGanttItemView>("82fa2a92-b153-475c-b49a-89f0140766f9","","",false, this);
 
            AppointmentNotes2 = RPSControlFactory.CreateRPSTextBox<EditProjectGanttItemView>("9e462c4b-0900-4059-b70f-6ae65ebf3b3f","","",false, this);
 
            AppointmentDateStart = RPSControlFactory.CreateRPSTextBox<EditProjectGanttItemView>("b666f982-b20b-446f-be1c-ef1baad264e9","","",true, this);
 
            UIStartHourTime = RPSControlFactory.CreateRPSTextBox<EditProjectGanttItemView>("5ccf25ee-dd05-4ed9-89be-fcb109d0a4fe","","",false, this);
 
            UIEndHourTime = RPSControlFactory.CreateRPSTextBox<EditProjectGanttItemView>("02b628b1-ea05-49f0-a62d-10e25be44c15","","",false, this);
 
            UIIsAllDay = RPSControlFactory.CreateRPSCheckBox<EditProjectGanttItemView>("0ab6b853-99da-41bd-8cd7-294896c40729","","",false, this);
 

        }
        public IRPSSaveButton<EditProjectGanttItemView> SaveButton { get; set; } 
        public IRPSButton<EditProjectGanttItemView> DeleteButton { get; set; } 
        public IRPSButton<EditProjectGanttItemView,ProjectTaskManagerView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<EditProjectGanttItemView,ProjectTaskManagerView> BackButton { get; set; } 
        public IRPSComboBox<EditProjectGanttItemView> IDProject { get; set; } 
        public IRPSComboBox<EditProjectGanttItemView> IDProTask { get; set; } 
        public IRPSTextBox<EditProjectGanttItemView> AppointmentNotes { get; set; } 
        public IRPSComboBox<EditProjectGanttItemView> IDStopType { get; set; } 
        public IRPSComboBox<EditProjectGanttItemView> IDMaintenanceOrder { get; set; } 
        public IRPSTextBox<EditProjectGanttItemView> AppointmentNotes1 { get; set; } 
        public IRPSComboBox<EditProjectGanttItemView> IDManufacturingOrder { get; set; } 
        public IRPSComboBox<EditProjectGanttItemView> IDMOTask { get; set; } 
        public IRPSTextBox<EditProjectGanttItemView> AppointmentNotes2 { get; set; } 
        public IRPSTextBox<EditProjectGanttItemView> AppointmentDateStart { get; set; } 
        public IRPSTextBox<EditProjectGanttItemView> UIStartHourTime { get; set; } 
        public IRPSTextBox<EditProjectGanttItemView> UIEndHourTime { get; set; } 
        public IRPSCheckbox<EditProjectGanttItemView> UIIsAllDay { get; set; } 
        public ProjectTaskManager Screen { get; set; }
        public EditProjectGanttItemView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ProjectTasksPendingDialogView : View
    {
        public ProjectTasksPendingDialogView(ProjectTaskManager screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_ProjectTasksPendingForTaskManager = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="e406594a-214a-4c5c-8a96-ed03c25b4693",CSSSelectorGrid="",XPathGrid=""};
            ProjectTasksPendingForTaskManager = RPSControlFactory.RPSCreateCollectionWithGrid<ProjectTasksPendingForTaskManagerCollectionEditor<ProjectTasksPendingDialogView>,ProjectTasksPendingDialogView>( params_ProjectTasksPendingForTaskManager,this);
 

        }
        public ProjectTasksPendingForTaskManagerCollectionEditor<ProjectTasksPendingDialogView> ProjectTasksPendingForTaskManager { get; set; } 
        public ProjectTaskManager Screen { get; set; }
        public ProjectTasksPendingDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ProjectTasksPendingForTaskManagerCollectionEditor<ProjectTasksPendingDialogView>:RPSCollectionEditor<ProjectTasksPendingDialogView> where ProjectTasksPendingDialogView : class, IView
    {
        public  ProjectTasksPendingForTaskManagerGridView<ProjectTasksPendingDialogView> GridView {get;set;}
    }
    public partial class ProjectTasksPendingForTaskManagerGridView <ProjectTasksPendingDialogView> :  RPSGridView<ProjectTasksPendingDialogView> where ProjectTasksPendingDialogView : class, IView
    {
        public ProjectTasksPendingForTaskManagerGridView(ProjectTasksPendingDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ProjectTask_PlannedStartDate = RPSControlFactory.CreateRPSGridTextBox<ProjectTasksPendingDialogView>("","#e406594a-214a-4c5c-8a96-ed03c25b4693 .ag-row[role='row']@ROWINDEX [col-id='cProjectTask_PlannedStartDate']","",false, this.CurrentView);
 
            ProjectTask_PlannedEndDate = RPSControlFactory.CreateRPSGridTextBox<ProjectTasksPendingDialogView>("","#e406594a-214a-4c5c-8a96-ed03c25b4693 .ag-row[role='row']@ROWINDEX [col-id='cProjectTask_PlannedEndDate']","",false, this.CurrentView);
 
            ProjectTask_Notes = RPSControlFactory.CreateRPSGridTextBox<ProjectTasksPendingDialogView>("","#e406594a-214a-4c5c-8a96-ed03c25b4693 .ag-row[role='row']@ROWINDEX [col-id='cProjectTask_Notes']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ProjectTasksPendingDialogView> ProjectTask_PlannedStartDate { get; set; } 
        public IRPSGridTextBox<ProjectTasksPendingDialogView> ProjectTask_PlannedEndDate { get; set; } 
        public IRPSGridTextBox<ProjectTasksPendingDialogView> ProjectTask_Notes { get; set; } 
                     
    }
 
    }
  
    

}