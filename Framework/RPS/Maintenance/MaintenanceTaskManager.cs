    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.MaintenanceTaskManager
{
    //RPS VERSION 1.0.0.0
    public partial class MaintenanceTaskManager:Screen
    {
        public MaintenanceTaskManager():base()
        {
            this.URL = "maintenance.maintenancetaskmanager";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MaintenanceTaskManagerView  = new MaintenanceTaskManagerView(this); 
            EditMaintenanceGanttItemView  = new EditMaintenanceGanttItemView(this); 
            NewMaintenanceGanttItemView  = new NewMaintenanceGanttItemView(this); 
            MaintenanceOrdersPendingDialogView  = new MaintenanceOrdersPendingDialogView(this); 
            MaintenanceTaskManagerView.InitializeControls(); 
            EditMaintenanceGanttItemView.InitializeControls(); 
            NewMaintenanceGanttItemView.InitializeControls(); 
            MaintenanceOrdersPendingDialogView.InitializeControls(); 
           
        }
      
            public MaintenanceTaskManagerView MaintenanceTaskManagerView {get; set; } 
            public EditMaintenanceGanttItemView EditMaintenanceGanttItemView {get; set; } 
            public NewMaintenanceGanttItemView NewMaintenanceGanttItemView {get; set; } 
            public MaintenanceOrdersPendingDialogView MaintenanceOrdersPendingDialogView {get; set; } 
    }
            
    public partial class MaintenanceTaskManagerView : View
    {
        public MaintenanceTaskManagerView(MaintenanceTaskManager screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIStartLoadDate = RPSControlFactory.CreateRPSTextBox<MaintenanceTaskManagerView>("0f4f6634-8702-4c0c-9a85-778e45ec86e8","","",false, this);
 
            UIIDSite = RPSControlFactory.CreateRPSComboBox<MaintenanceTaskManagerView>("088611f7-99a3-4f15-82eb-7a6850a00eea","","",false, this);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<MaintenanceTaskManagerView>("8af12c59-5e57-4365-9381-3235b6586831","","",false, this);
 
            UIeTypeEmployee = RPSControlFactory.CreateRPSEnumComboBox<MaintenanceTaskManagerView>("fbb2a422-a813-48a1-b5d6-11677b2eda12","","",false, this);
 
            UIIDDepartment = RPSControlFactory.CreateRPSComboBox<MaintenanceTaskManagerView>("bf14989b-ec19-4ef3-80e4-eef06671a09e","","",false, this);
 
            UIIDCategory = RPSControlFactory.CreateRPSComboBox<MaintenanceTaskManagerView>("4b3dde9c-b737-456a-bb8d-8df86822c515","","",false, this);
 
            UIIDQualify = RPSControlFactory.CreateRPSComboBox<MaintenanceTaskManagerView>("9c8d5700-ad36-4e0a-acd9-3e7fdc7231c4","","",false, this);
 
            QueryCommand = RPSControlFactory.CreateRPSButton<MaintenanceTaskManagerView>( "fedd3eac-ba2c-432b-b6f1-62b9dbad8cde","","",this);
 
            MaintenanceOrdersPendingNavigationCommand = RPSControlFactory.CreateRPSButtonToView<MaintenanceTaskManagerView,MaintenanceOrdersPendingDialogView>("50fe5b30-bcf9-4f37-b4f5-6d6f6f5f5b06","","", this,Screen.MaintenanceOrdersPendingDialogView);
 

        }
        public IRPSTextBox<MaintenanceTaskManagerView> UIStartLoadDate { get; set; } 
        public IRPSComboBox<MaintenanceTaskManagerView> UIIDSite { get; set; } 
        public IRPSComboBox<MaintenanceTaskManagerView> IDEmployee { get; set; } 
        public IRPSComboBox<MaintenanceTaskManagerView> UIeTypeEmployee { get; set; } 
        public IRPSComboBox<MaintenanceTaskManagerView> UIIDDepartment { get; set; } 
        public IRPSComboBox<MaintenanceTaskManagerView> UIIDCategory { get; set; } 
        public IRPSComboBox<MaintenanceTaskManagerView> UIIDQualify { get; set; } 
        public IRPSButton<MaintenanceTaskManagerView> QueryCommand { get; set; } 
        public IRPSButton<MaintenanceTaskManagerView,MaintenanceOrdersPendingDialogView> MaintenanceOrdersPendingNavigationCommand { get; set; } 
        public MaintenanceTaskManager Screen { get; set; }
        public MaintenanceTaskManagerView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class EditMaintenanceGanttItemView : View
    {
        public EditMaintenanceGanttItemView(MaintenanceTaskManager screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<EditMaintenanceGanttItemView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<EditMaintenanceGanttItemView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<EditMaintenanceGanttItemView,MaintenanceTaskManagerView>( this,Screen.MaintenanceTaskManagerView);
 
            BackButton = RPSControlFactory.RPSBackButton<EditMaintenanceGanttItemView,MaintenanceTaskManagerView>( this,Screen.MaintenanceTaskManagerView);
 
            IDMaintenanceOrder = RPSControlFactory.CreateRPSComboBox<EditMaintenanceGanttItemView>("ea542edb-2ebc-44d8-974b-87cf9cbba46f","","",false, this);
 
            AppointmentNotes = RPSControlFactory.CreateRPSTextBox<EditMaintenanceGanttItemView>("06ce3751-9440-434a-ac33-b59dbd36c2e6","","",false, this);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<EditMaintenanceGanttItemView>("e64050ea-ea51-45c2-b7fe-7da8bd6eebb7","","",false, this);
 
            IDProjectTask = RPSControlFactory.CreateRPSComboBox<EditMaintenanceGanttItemView>("1597af06-cfd7-404f-8b15-5af4d277a212","","",false, this);
 
            AppointmentNotes1 = RPSControlFactory.CreateRPSTextBox<EditMaintenanceGanttItemView>("3f2f040d-5b47-413e-9a2e-755192d3a874","","",false, this);
 
            IDManufacturingOrder = RPSControlFactory.CreateRPSComboBox<EditMaintenanceGanttItemView>("031e234d-5391-4202-94cc-897aa6e8e5d5","","",false, this);
 
            IDMOTask = RPSControlFactory.CreateRPSComboBox<EditMaintenanceGanttItemView>("82fa2a92-b153-475c-b49a-89f0140766f9","","",false, this);
 
            AppointmentNotes2 = RPSControlFactory.CreateRPSTextBox<EditMaintenanceGanttItemView>("9e462c4b-0900-4059-b70f-6ae65ebf3b3f","","",false, this);
 
            IDStopType = RPSControlFactory.CreateRPSComboBox<EditMaintenanceGanttItemView>("2823364a-e0fb-4540-8bfa-2264f8b3dc8e","","",false, this);
 
            AppointmentDateStart = RPSControlFactory.CreateRPSTextBox<EditMaintenanceGanttItemView>("b666f982-b20b-446f-be1c-ef1baad264e9","","",true, this);
 
            UIStartHourTime = RPSControlFactory.CreateRPSTextBox<EditMaintenanceGanttItemView>("5ccf25ee-dd05-4ed9-89be-fcb109d0a4fe","","",false, this);
 
            UIEndHourTime = RPSControlFactory.CreateRPSTextBox<EditMaintenanceGanttItemView>("02b628b1-ea05-49f0-a62d-10e25be44c15","","",false, this);
 
            UIIsAllDay = RPSControlFactory.CreateRPSCheckBox<EditMaintenanceGanttItemView>("0ab6b853-99da-41bd-8cd7-294896c40729","","",false, this);
 

        }
        public IRPSSaveButton<EditMaintenanceGanttItemView> SaveButton { get; set; } 
        public IRPSButton<EditMaintenanceGanttItemView> DeleteButton { get; set; } 
        public IRPSButton<EditMaintenanceGanttItemView,MaintenanceTaskManagerView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<EditMaintenanceGanttItemView,MaintenanceTaskManagerView> BackButton { get; set; } 
        public IRPSComboBox<EditMaintenanceGanttItemView> IDMaintenanceOrder { get; set; } 
        public IRPSTextBox<EditMaintenanceGanttItemView> AppointmentNotes { get; set; } 
        public IRPSComboBox<EditMaintenanceGanttItemView> IDProject { get; set; } 
        public IRPSComboBox<EditMaintenanceGanttItemView> IDProjectTask { get; set; } 
        public IRPSTextBox<EditMaintenanceGanttItemView> AppointmentNotes1 { get; set; } 
        public IRPSComboBox<EditMaintenanceGanttItemView> IDManufacturingOrder { get; set; } 
        public IRPSComboBox<EditMaintenanceGanttItemView> IDMOTask { get; set; } 
        public IRPSTextBox<EditMaintenanceGanttItemView> AppointmentNotes2 { get; set; } 
        public IRPSComboBox<EditMaintenanceGanttItemView> IDStopType { get; set; } 
        public IRPSTextBox<EditMaintenanceGanttItemView> AppointmentDateStart { get; set; } 
        public IRPSTextBox<EditMaintenanceGanttItemView> UIStartHourTime { get; set; } 
        public IRPSTextBox<EditMaintenanceGanttItemView> UIEndHourTime { get; set; } 
        public IRPSCheckbox<EditMaintenanceGanttItemView> UIIsAllDay { get; set; } 
        public MaintenanceTaskManager Screen { get; set; }
        public EditMaintenanceGanttItemView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NewMaintenanceGanttItemView : View
    {
        public NewMaintenanceGanttItemView(MaintenanceTaskManager screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Maintenance = RPSControlFactory.CreateRPSOption<NewMaintenanceGanttItemView>( "683f6307-48ca-46a8-b6d0-be43fbd00b0d","","",this);
 
            StopResource = RPSControlFactory.CreateRPSOption<NewMaintenanceGanttItemView>( "c627fe69-15b1-45c5-8b46-786db37fe57f","","",this);
 
            IDMaintenanceOrder = RPSControlFactory.CreateRPSComboBox<NewMaintenanceGanttItemView>("bbf6e9a3-ab04-4a0f-a00e-403f7ef3a25d","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<NewMaintenanceGanttItemView>("85964840-318f-4f88-b169-0b68ed1ced49","","",false, this);
 
            IDStopType = RPSControlFactory.CreateRPSComboBox<NewMaintenanceGanttItemView>("897a549f-fe80-4826-b65d-f52621c7f2cb","","",false, this);
 
            Unique = RPSControlFactory.CreateRPSOption<NewMaintenanceGanttItemView>( "765e02e2-d080-4ba0-91b4-31c88391882a","","",this);
 
            AllDays = RPSControlFactory.CreateRPSOption<NewMaintenanceGanttItemView>( "53ceaff4-f972-4ef5-ad3d-eee43019491b","","",this);
 
            Week = RPSControlFactory.CreateRPSOption<NewMaintenanceGanttItemView>( "25a89969-2daa-43ac-b4f8-7483ab825da2","","",this);
 
            UIMonday = RPSControlFactory.CreateRPSCheckBox<NewMaintenanceGanttItemView>("eae53b10-6170-4476-91c2-e50c097345e9","","",false, this);
 
            UITuesday = RPSControlFactory.CreateRPSCheckBox<NewMaintenanceGanttItemView>("2580e343-9786-4e9a-8c3b-0ace485eee61","","",false, this);
 
            UIWednesday = RPSControlFactory.CreateRPSCheckBox<NewMaintenanceGanttItemView>("250918f0-fdd4-42e7-9c41-cca29930f303","","",false, this);
 
            UIThursday = RPSControlFactory.CreateRPSCheckBox<NewMaintenanceGanttItemView>("08aaf4f2-4e80-4f11-93dc-0337252b67e7","","",false, this);
 
            UIFriday = RPSControlFactory.CreateRPSCheckBox<NewMaintenanceGanttItemView>("7e4f1b14-9f7a-43c8-8099-92755f8cff1d","","",false, this);
 
            UISaturday = RPSControlFactory.CreateRPSCheckBox<NewMaintenanceGanttItemView>("1816fcb4-e8ef-4dc4-9245-6170630d2622","","",false, this);
 
            UISunday = RPSControlFactory.CreateRPSCheckBox<NewMaintenanceGanttItemView>("3c89c60d-a59d-4ebf-8db0-95df549bf0d3","","",false, this);
 
            Each = RPSControlFactory.CreateRPSOption<NewMaintenanceGanttItemView>( "a4ec575f-ed45-4c08-966a-bed473d5de0a","","",this);
 
            UIPeriodicityDays = RPSControlFactory.CreateRPSFormattedTextBox<NewMaintenanceGanttItemView>("8ff8f0b5-db58-4bc6-9bd3-440e5bfd0c0c","","",false, this);
 
            AppointmentDateStart = RPSControlFactory.CreateRPSTextBox<NewMaintenanceGanttItemView>("10d87034-eabe-4c9d-a622-200b03d14981","","",true, this);
 
            AppointmentDateEnd = RPSControlFactory.CreateRPSTextBox<NewMaintenanceGanttItemView>("8c88df61-626e-4908-8f96-753d8a5acc11","","",true, this);
 
            UIStartHourTime = RPSControlFactory.CreateRPSTextBox<NewMaintenanceGanttItemView>("3c211b68-0ed6-4242-96c7-408fb5d9a932","","",true, this);
 
            UIEndHourTime = RPSControlFactory.CreateRPSTextBox<NewMaintenanceGanttItemView>("9ba6076d-bad2-44fc-b7ab-470b85366453","","",true, this);
 
            UIIsAllDay = RPSControlFactory.CreateRPSCheckBox<NewMaintenanceGanttItemView>("a5c52957-3ceb-4ae5-9090-69105c393a95","","",false, this);
 

        }
        public IRPSOption<NewMaintenanceGanttItemView> Maintenance { get; set; } 
        public IRPSOption<NewMaintenanceGanttItemView> StopResource { get; set; } 
        public IRPSComboBox<NewMaintenanceGanttItemView> IDMaintenanceOrder { get; set; } 
        public IRPSTextBox<NewMaintenanceGanttItemView> Comment { get; set; } 
        public IRPSComboBox<NewMaintenanceGanttItemView> IDStopType { get; set; } 
        public IRPSOption<NewMaintenanceGanttItemView> Unique { get; set; } 
        public IRPSOption<NewMaintenanceGanttItemView> AllDays { get; set; } 
        public IRPSOption<NewMaintenanceGanttItemView> Week { get; set; } 
        public IRPSCheckbox<NewMaintenanceGanttItemView> UIMonday { get; set; } 
        public IRPSCheckbox<NewMaintenanceGanttItemView> UITuesday { get; set; } 
        public IRPSCheckbox<NewMaintenanceGanttItemView> UIWednesday { get; set; } 
        public IRPSCheckbox<NewMaintenanceGanttItemView> UIThursday { get; set; } 
        public IRPSCheckbox<NewMaintenanceGanttItemView> UIFriday { get; set; } 
        public IRPSCheckbox<NewMaintenanceGanttItemView> UISaturday { get; set; } 
        public IRPSCheckbox<NewMaintenanceGanttItemView> UISunday { get; set; } 
        public IRPSOption<NewMaintenanceGanttItemView> Each { get; set; } 
        public IRPSTextBox<NewMaintenanceGanttItemView> UIPeriodicityDays { get; set; } 
        public IRPSTextBox<NewMaintenanceGanttItemView> AppointmentDateStart { get; set; } 
        public IRPSTextBox<NewMaintenanceGanttItemView> AppointmentDateEnd { get; set; } 
        public IRPSTextBox<NewMaintenanceGanttItemView> UIStartHourTime { get; set; } 
        public IRPSTextBox<NewMaintenanceGanttItemView> UIEndHourTime { get; set; } 
        public IRPSCheckbox<NewMaintenanceGanttItemView> UIIsAllDay { get; set; } 
        public MaintenanceTaskManager Screen { get; set; }
        public NewMaintenanceGanttItemView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenanceOrdersPendingDialogView : View
    {
        public MaintenanceOrdersPendingDialogView(MaintenanceTaskManager screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_MaintenanceOrdersPendingForTaskManager = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="488f3f6d-64a6-4910-a930-dd4499db073b",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceOrdersPendingForTaskManager = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceOrdersPendingForTaskManagerCollectionEditor<MaintenanceOrdersPendingDialogView>,MaintenanceOrdersPendingDialogView>( params_MaintenanceOrdersPendingForTaskManager,this);
 

        }
        public MaintenanceOrdersPendingForTaskManagerCollectionEditor<MaintenanceOrdersPendingDialogView> MaintenanceOrdersPendingForTaskManager { get; set; } 
        public MaintenanceTaskManager Screen { get; set; }
        public MaintenanceOrdersPendingDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaintenanceOrdersPendingForTaskManagerCollectionEditor<MaintenanceOrdersPendingDialogView>:RPSCollectionEditor<MaintenanceOrdersPendingDialogView> where MaintenanceOrdersPendingDialogView : class, IView
    {
        public  MaintenanceOrdersPendingForTaskManagerGridView<MaintenanceOrdersPendingDialogView> GridView {get;set;}
    }
    public partial class MaintenanceOrdersPendingForTaskManagerGridView <MaintenanceOrdersPendingDialogView> :  RPSGridView<MaintenanceOrdersPendingDialogView> where MaintenanceOrdersPendingDialogView : class, IView
    {
        public MaintenanceOrdersPendingForTaskManagerGridView(MaintenanceOrdersPendingDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MaintenanceOrder_ExecutionDate = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrdersPendingDialogView>("","#488f3f6d-64a6-4910-a930-dd4499db073b .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceOrder_ExecutionDate']","",false, this.CurrentView);
 
            MaintenanceOrder_ExecutionTime = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrdersPendingDialogView>("","#488f3f6d-64a6-4910-a930-dd4499db073b .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceOrder_ExecutionTime']","",false, this.CurrentView);
 
            EndDate = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrdersPendingDialogView>("","#488f3f6d-64a6-4910-a930-dd4499db073b .ag-row[role='row']@ROWINDEX [col-id='cEndDate']","",false, this.CurrentView);
 
            EndTime = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrdersPendingDialogView>("","#488f3f6d-64a6-4910-a930-dd4499db073b .ag-row[role='row']@ROWINDEX [col-id='cEndTime']","",false, this.CurrentView);
 
            MaintenanceOrder_Notes = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrdersPendingDialogView>("","#488f3f6d-64a6-4910-a930-dd4499db073b .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceOrder_Notes']","",false, this.CurrentView);
 
            MaintenanceOrder_Observations = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrdersPendingDialogView>("","#488f3f6d-64a6-4910-a930-dd4499db073b .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceOrder_Observations']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MaintenanceOrdersPendingDialogView> MaintenanceOrder_ExecutionDate { get; set; } 
        public IRPSGridTextBox<MaintenanceOrdersPendingDialogView> MaintenanceOrder_ExecutionTime { get; set; } 
        public IRPSGridTextBox<MaintenanceOrdersPendingDialogView> EndDate { get; set; } 
        public IRPSGridTextBox<MaintenanceOrdersPendingDialogView> EndTime { get; set; } 
        public IRPSGridTextBox<MaintenanceOrdersPendingDialogView> MaintenanceOrder_Notes { get; set; } 
        public IRPSGridTextBox<MaintenanceOrdersPendingDialogView> MaintenanceOrder_Observations { get; set; } 
                     
    }
 
    }
  
    

}