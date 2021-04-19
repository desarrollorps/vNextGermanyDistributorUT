    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.Agenda
{
    //RPS VERSION 1.0.0.0
    public partial class Agenda:Screen
    {
        public Agenda():base()
        {
            this.URL = "general.agenda";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            AgendaView  = new AgendaView(this); 
            AllAppointmentsView  = new AllAppointmentsView(this); 
            NewAppoinmentView  = new NewAppoinmentView(this); 
            ProjectTaskActivityView  = new ProjectTaskActivityView(this); 
            ImputationDialogView  = new ImputationDialogView(this); 
            ImputationCostDialogView  = new ImputationCostDialogView(this); 
            MaintenanceOrderActivityView  = new MaintenanceOrderActivityView(this); 
            MaintenanceOrderEmployeeDialogView  = new MaintenanceOrderEmployeeDialogView(this); 
            ManOrderEmployeeExpensesDialogView  = new ManOrderEmployeeExpensesDialogView(this); 
            MOTaskActivityView  = new MOTaskActivityView(this); 
            ImputationMODialogView  = new ImputationMODialogView(this); 
            ImputationCostMODialogView  = new ImputationCostMODialogView(this); 
            ManualActivityView  = new ManualActivityView(this); 
            UsersInDownHierarchyDialogView  = new UsersInDownHierarchyDialogView(this); 
            NewImputationView  = new NewImputationView(this); 
            DeleteAppointmentsView  = new DeleteAppointmentsView(this); 
            NCPendingActionView  = new NCPendingActionView(this); 
            CRMActivitySLView  = new CRMActivitySLView(this); 
            BPMTaskActivityView  = new BPMTaskActivityView(this); 
            ProjectWarningView  = new ProjectWarningView(this); 
            AgendaView.InitializeControls(); 
            AllAppointmentsView.InitializeControls(); 
            NewAppoinmentView.InitializeControls(); 
            ProjectTaskActivityView.InitializeControls(); 
            ImputationDialogView.InitializeControls(); 
            ImputationCostDialogView.InitializeControls(); 
            MaintenanceOrderActivityView.InitializeControls(); 
            MaintenanceOrderEmployeeDialogView.InitializeControls(); 
            ManOrderEmployeeExpensesDialogView.InitializeControls(); 
            MOTaskActivityView.InitializeControls(); 
            ImputationMODialogView.InitializeControls(); 
            ImputationCostMODialogView.InitializeControls(); 
            ManualActivityView.InitializeControls(); 
            UsersInDownHierarchyDialogView.InitializeControls(); 
            NewImputationView.InitializeControls(); 
            DeleteAppointmentsView.InitializeControls(); 
            NCPendingActionView.InitializeControls(); 
            CRMActivitySLView.InitializeControls(); 
            BPMTaskActivityView.InitializeControls(); 
            ProjectWarningView.InitializeControls(); 
           
        }
      
            public AgendaView AgendaView {get; set; } 
            public AllAppointmentsView AllAppointmentsView {get; set; } 
            public NewAppoinmentView NewAppoinmentView {get; set; } 
            public ProjectTaskActivityView ProjectTaskActivityView {get; set; } 
            public ImputationDialogView ImputationDialogView {get; set; } 
            public ImputationCostDialogView ImputationCostDialogView {get; set; } 
            public MaintenanceOrderActivityView MaintenanceOrderActivityView {get; set; } 
            public MaintenanceOrderEmployeeDialogView MaintenanceOrderEmployeeDialogView {get; set; } 
            public ManOrderEmployeeExpensesDialogView ManOrderEmployeeExpensesDialogView {get; set; } 
            public MOTaskActivityView MOTaskActivityView {get; set; } 
            public ImputationMODialogView ImputationMODialogView {get; set; } 
            public ImputationCostMODialogView ImputationCostMODialogView {get; set; } 
            public ManualActivityView ManualActivityView {get; set; } 
            public UsersInDownHierarchyDialogView UsersInDownHierarchyDialogView {get; set; } 
            public NewImputationView NewImputationView {get; set; } 
            public DeleteAppointmentsView DeleteAppointmentsView {get; set; } 
            public NCPendingActionView NCPendingActionView {get; set; } 
            public CRMActivitySLView CRMActivitySLView {get; set; } 
            public BPMTaskActivityView BPMTaskActivityView {get; set; } 
            public ProjectWarningView ProjectWarningView {get; set; } 
    }
            
    public partial class AgendaView : View
    {
        public AgendaView(Agenda screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            LinkToNewManualActivityButton = RPSControlFactory.CreateRPSButton<AgendaView>( "88f5cd2e-a4e3-41a9-8fe5-98b4d3cfd0db","","",this);
 
            LinkToNewCRMActivityCommandButton = RPSControlFactory.CreateRPSButton<AgendaView>( "9db4defe-f9f3-4c8f-8e7a-4b0ce0c4befa","","",this);
 
            LinkToNewAppointmentCommand = RPSControlFactory.CreateRPSButtonToView<AgendaView,NewAppoinmentView>("7b268b62-c465-49de-88d9-dd4d4078f303","","", this,Screen.NewAppoinmentView);
 
            DeleteAppointmentsNavigationCommand = RPSControlFactory.CreateRPSButtonToView<AgendaView,DeleteAppointmentsView>("1a94699b-4349-42dc-9200-d66dd8b34ff9","","", this,Screen.DeleteAppointmentsView);
 
            LinkToNewImputationCommand = RPSControlFactory.CreateRPSButton<AgendaView>( "10a4e1b2-ee0a-4627-bd47-cc28cdf0eb64","","",this);
 
            RefreshCommandButton = RPSControlFactory.CreateRPSButton<AgendaView>( "58a8b916-6b19-48b0-bd1c-a539a0f10003","","",this);
 
            ChangeUserCommandButton = RPSControlFactory.CreateRPSButtonToView<AgendaView,UsersInDownHierarchyDialogView>("7b76d863-2dbc-4aff-9072-f84534127b36","","", this,Screen.UsersInDownHierarchyDialogView);
 
            ShowOptionsCommandButton = RPSControlFactory.CreateRPSButton<AgendaView>( "594b51ae-4127-41d5-b572-2521db87ea34","","",this);
 
            CollectionInit params_PendingActivities = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="afa10bcb-5f0b-4e31-89ad-cfaf257e65cd",CSSSelectorGrid="",XPathGrid=""};
            PendingActivities = RPSControlFactory.RPSCreateCollectionWithGrid<PendingActivitiesCollectionEditor<AgendaView,NewAppoinmentView>,AgendaView,NewAppoinmentView>( params_PendingActivities,this,Screen.NewAppoinmentView);
 
            Task = RPSControlFactory.CreateRPSSection<AgendaView>( "","ul li[rpsid='d3b356e3-5297-4dc0-901a-8f1414f8063a']","",this);
 
            Appointment = RPSControlFactory.CreateRPSSection<AgendaView>( "","ul li[rpsid='55bc1541-6a53-43fa-938a-bff9ba0b9e53']","",this);
 
            Imputations = RPSControlFactory.CreateRPSSection<AgendaView>( "","ul li[rpsid='2d118e65-94fd-4169-b079-52886ea8115e']","",this);
 

        }
        public IRPSButton<AgendaView> LinkToNewManualActivityButton { get; set; } 
        public IRPSButton<AgendaView> LinkToNewCRMActivityCommandButton { get; set; } 
        public IRPSButton<AgendaView,NewAppoinmentView> LinkToNewAppointmentCommand { get; set; } 
        public IRPSButton<AgendaView,DeleteAppointmentsView> DeleteAppointmentsNavigationCommand { get; set; } 
        public IRPSButton<AgendaView> LinkToNewImputationCommand { get; set; } 
        public IRPSButton<AgendaView> RefreshCommandButton { get; set; } 
        public IRPSButton<AgendaView,UsersInDownHierarchyDialogView> ChangeUserCommandButton { get; set; } 
        public IRPSButton<AgendaView> ShowOptionsCommandButton { get; set; } 
        public PendingActivitiesCollectionEditor<AgendaView,NewAppoinmentView> PendingActivities { get; set; } 
        public IRPSSection<AgendaView> Task { get; set; } 
        public IRPSSection<AgendaView> Appointment { get; set; } 
        public IRPSSection<AgendaView> Imputations { get; set; } 
        public Agenda Screen { get; set; }
        public AgendaView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class PendingActivitiesCollectionEditor<AgendaView,NewAppoinmentView>:RPSCollectionEditor<AgendaView,NewAppoinmentView> where AgendaView : class, IView where NewAppoinmentView : class, IView
    {
        public  PendingActivitiesGridView<AgendaView,NewAppoinmentView> GridView {get;set;}
    }
    public partial class PendingActivitiesGridView <AgendaView,NewAppoinmentView> :  RPSGridView<AgendaView,NewAppoinmentView> where AgendaView : class, IView where NewAppoinmentView : class, IView
    {
        public PendingActivitiesGridView(AgendaView currentView,NewAppoinmentView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ActivityLinkCommand = RPSControlFactory.CreateRPSGridButton<AgendaView>( "","#afa10bcb-5f0b-4e31-89ad-cfaf257e65cd .ag-row[role='row']@ROWINDEX [col-id='cActivityLinkCommand']","",this.CurrentView);
 
            EntityName = RPSControlFactory.CreateRPSGridTextBox<AgendaView>("","#afa10bcb-5f0b-4e31-89ad-cfaf257e65cd .ag-row[role='row']@ROWINDEX [col-id='cEntityName']","",false, this.CurrentView);
 
            InstanceLabel = RPSControlFactory.CreateRPSGridTextBox<AgendaView>("","#afa10bcb-5f0b-4e31-89ad-cfaf257e65cd .ag-row[role='row']@ROWINDEX [col-id='cInstanceLabel']","",false, this.CurrentView);
 
            CreationDateTime = RPSControlFactory.CreateRPSGridTextBox<AgendaView>("","#afa10bcb-5f0b-4e31-89ad-cfaf257e65cd .ag-row[role='row']@ROWINDEX [col-id='cCreationDateTime']","",false, this.CurrentView);
 
            DueDateTime = RPSControlFactory.CreateRPSGridTextBox<AgendaView>("","#afa10bcb-5f0b-4e31-89ad-cfaf257e65cd .ag-row[role='row']@ROWINDEX [col-id='cDueDateTime']","",false, this.CurrentView);
 
            ExecuteActivityCommand = RPSControlFactory.CreateRPSGridButton<AgendaView>( "","#afa10bcb-5f0b-4e31-89ad-cfaf257e65cd .ag-row[role='row']@ROWINDEX [col-id='cExecuteActivityCommand']","",this.CurrentView);
 

        }
        public IRPSGridButton<AgendaView> ActivityLinkCommand { get; set; } 
        public IRPSGridTextBox<AgendaView> EntityName { get; set; } 
        public IRPSGridTextBox<AgendaView> InstanceLabel { get; set; } 
        public IRPSGridTextBox<AgendaView> CreationDateTime { get; set; } 
        public IRPSGridTextBox<AgendaView> DueDateTime { get; set; } 
        public IRPSGridButton<AgendaView> ExecuteActivityCommand { get; set; } 
                     
    }
 
    }
  
            
    public partial class AllAppointmentsView : View
    {
        public AllAppointmentsView(Agenda screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<AllAppointmentsView>( this);
 
            TypeAppointment = RPSControlFactory.CreateRPSEnumComboBox<AllAppointmentsView>("055c165c-3ca0-4b6a-8d1f-5e1cbeb64e80","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<AllAppointmentsView>("2faa52b5-53a7-452c-8bfd-73dcdac6d189","","",false, this);
 
            AppointmentNotes = RPSControlFactory.CreateRPSTextBox<AllAppointmentsView>("7b8bbc9b-1352-4b6b-87a6-5237cd335c97","","",false, this);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<AllAppointmentsView>("d3e6d114-33f9-43d7-b0c1-40daac4f5340","","",false, this);
 
            IDProTask = RPSControlFactory.CreateRPSComboBox<AllAppointmentsView>("0f6ee1b3-1e9d-4f02-9c04-5f0f81722bdd","","",false, this);
 
            AppointmentNotes1 = RPSControlFactory.CreateRPSTextBox<AllAppointmentsView>("a2ff53f0-e819-4f51-bf1c-4f06668fcd1a","","",false, this);
 
            IDManufacturingOrder = RPSControlFactory.CreateRPSComboBox<AllAppointmentsView>("56304730-3d28-460d-91a9-c33854f1ad06","","",false, this);
 
            IDMOTask = RPSControlFactory.CreateRPSComboBox<AllAppointmentsView>("08110efa-7236-4437-9408-af4a47edbbd1","","",false, this);
 
            AppointmentNotes2 = RPSControlFactory.CreateRPSTextBox<AllAppointmentsView>("a052f49c-4e30-4e3c-9eda-215599c87dd7","","",false, this);
 
            IDMaintenanceOrder = RPSControlFactory.CreateRPSComboBox<AllAppointmentsView>("e8e60b04-1606-4630-b8ff-e97f939efa59","","",false, this);
 
            AppointmentNotes3 = RPSControlFactory.CreateRPSTextBox<AllAppointmentsView>("06ce3751-9440-434a-ac33-b59dbd36c2e6","","",false, this);
 
            IDActivity = RPSControlFactory.CreateRPSComboBox<AllAppointmentsView>("32cd4bf9-f24b-4296-8331-4460675fdd4e","","",false, this);
 
            AppointmentNotes4 = RPSControlFactory.CreateRPSTextBox<AllAppointmentsView>("f165011a-d58d-4917-9bf0-ded74a53da0f","","",false, this);
 
            IDStopType = RPSControlFactory.CreateRPSComboBox<AllAppointmentsView>("2823364a-e0fb-4540-8bfa-2264f8b3dc8e","","",false, this);
 
            AppointmentDateStart = RPSControlFactory.CreateRPSTextBox<AllAppointmentsView>("b666f982-b20b-446f-be1c-ef1baad264e9","","",true, this);
 
            UIStartHourTime = RPSControlFactory.CreateRPSTextBox<AllAppointmentsView>("5ccf25ee-dd05-4ed9-89be-fcb109d0a4fe","","",false, this);
 
            UIEndHourTime = RPSControlFactory.CreateRPSTextBox<AllAppointmentsView>("02b628b1-ea05-49f0-a62d-10e25be44c15","","",false, this);
 
            UIIsAllDay = RPSControlFactory.CreateRPSCheckBox<AllAppointmentsView>("0ab6b853-99da-41bd-8cd7-294896c40729","","",false, this);
 
            ReminderMinutesBeforeStart = RPSControlFactory.CreateRPSEnumComboBox<AllAppointmentsView>("52d65f92-4d08-4653-9258-2d184652c47a","","",false, this);
 

        }
        public IRPSSaveButton<AllAppointmentsView> SaveButton { get; set; } 
        public IRPSComboBox<AllAppointmentsView> TypeAppointment { get; set; } 
        public IRPSTextBox<AllAppointmentsView> Description { get; set; } 
        public IRPSTextBox<AllAppointmentsView> AppointmentNotes { get; set; } 
        public IRPSComboBox<AllAppointmentsView> IDProject { get; set; } 
        public IRPSComboBox<AllAppointmentsView> IDProTask { get; set; } 
        public IRPSTextBox<AllAppointmentsView> AppointmentNotes1 { get; set; } 
        public IRPSComboBox<AllAppointmentsView> IDManufacturingOrder { get; set; } 
        public IRPSComboBox<AllAppointmentsView> IDMOTask { get; set; } 
        public IRPSTextBox<AllAppointmentsView> AppointmentNotes2 { get; set; } 
        public IRPSComboBox<AllAppointmentsView> IDMaintenanceOrder { get; set; } 
        public IRPSTextBox<AllAppointmentsView> AppointmentNotes3 { get; set; } 
        public IRPSComboBox<AllAppointmentsView> IDActivity { get; set; } 
        public IRPSTextBox<AllAppointmentsView> AppointmentNotes4 { get; set; } 
        public IRPSComboBox<AllAppointmentsView> IDStopType { get; set; } 
        public IRPSTextBox<AllAppointmentsView> AppointmentDateStart { get; set; } 
        public IRPSTextBox<AllAppointmentsView> UIStartHourTime { get; set; } 
        public IRPSTextBox<AllAppointmentsView> UIEndHourTime { get; set; } 
        public IRPSCheckbox<AllAppointmentsView> UIIsAllDay { get; set; } 
        public IRPSComboBox<AllAppointmentsView> ReminderMinutesBeforeStart { get; set; } 
        public Agenda Screen { get; set; }
        public AllAppointmentsView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NewAppoinmentView : View
    {
        public NewAppoinmentView(Agenda screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Project = RPSControlFactory.CreateRPSOption<NewAppoinmentView>( "b18ec610-d8a8-4d94-a005-69374cf3ba51","","",this);
 
            Manufacturing = RPSControlFactory.CreateRPSOption<NewAppoinmentView>( "b3d57b66-1626-4e94-99c8-fcbe60f53f91","","",this);
 
            Maintenance = RPSControlFactory.CreateRPSOption<NewAppoinmentView>( "a3a35ca8-475e-4b79-9b6a-0607b12cb514","","",this);
 
            ResourceStop = RPSControlFactory.CreateRPSOption<NewAppoinmentView>( "f674972d-b17c-4548-824f-fa5400a4df39","","",this);
 
            CRM = RPSControlFactory.CreateRPSOption<NewAppoinmentView>( "951b89f4-b5ba-4bf5-b990-b07de2d00ee5","","",this);
 
            Manual = RPSControlFactory.CreateRPSOption<NewAppoinmentView>( "0db845c6-0bf3-4968-964b-a891eeaa4683","","",this);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<NewAppoinmentView>("09a689e8-5551-4220-8e53-6961f52a566a","","",false, this);
 
            IDProTask = RPSControlFactory.CreateRPSComboBox<NewAppoinmentView>("63d3c3df-bded-4bb4-bdc7-4745ddadc94f","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<NewAppoinmentView>("0ec8a009-1cc1-4d6a-ab3a-42ece8f7d41c","","",false, this);
 
            IDManufacturingOrder = RPSControlFactory.CreateRPSComboBox<NewAppoinmentView>("186b29e0-da3e-46a5-ac89-3b7763d5e18f","","",false, this);
 
            IDMOTask = RPSControlFactory.CreateRPSComboBox<NewAppoinmentView>("eb006136-f032-4c14-a17b-14a30aa01eaa","","",false, this);
 
            Comment1 = RPSControlFactory.CreateRPSTextBox<NewAppoinmentView>("61a21f43-ff03-412b-80ef-b51839aa5a0f","","",false, this);
 
            IDMaintenanceOrder = RPSControlFactory.CreateRPSComboBox<NewAppoinmentView>("bbf6e9a3-ab04-4a0f-a00e-403f7ef3a25d","","",false, this);
 
            Comment2 = RPSControlFactory.CreateRPSTextBox<NewAppoinmentView>("85964840-318f-4f88-b169-0b68ed1ced49","","",false, this);
 
            IDStopType = RPSControlFactory.CreateRPSComboBox<NewAppoinmentView>("897a549f-fe80-4826-b65d-f52621c7f2cb","","",false, this);
 
            Comment3 = RPSControlFactory.CreateRPSTextBox<NewAppoinmentView>("3a3baf5d-154c-45f6-acb2-2334d9717c5c","","",false, this);
 
            IDActivity = RPSControlFactory.CreateRPSComboBox<NewAppoinmentView>("32f2ee1b-9a62-4f2a-89bc-b0734b8e84e5","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<NewAppoinmentView>("c30b3e08-1a05-42da-98c0-9dea07b6e098","","",false, this);
 
            Comment4 = RPSControlFactory.CreateRPSTextBox<NewAppoinmentView>("240f6aa2-9b65-4bea-9ada-131695b51ab2","","",false, this);
 
            Description1 = RPSControlFactory.CreateRPSTextBox<NewAppoinmentView>("10831b2a-4b2c-4f9e-bce7-369eb64be360","","",false, this);
 
            Comment5 = RPSControlFactory.CreateRPSTextBox<NewAppoinmentView>("9946847a-2123-4c42-ab71-7cc5899b8462","","",false, this);
 
            UniqueAppointmentDate = RPSControlFactory.CreateRPSTextBox<NewAppoinmentView>("99274702-6a4b-4b70-a06f-056f1d163e5f","","",true, this);
 
            AppointmentDateStart = RPSControlFactory.CreateRPSTextBox<NewAppoinmentView>("10d87034-eabe-4c9d-a622-200b03d14981","","",true, this);
 
            AppointmentDateEnd = RPSControlFactory.CreateRPSTextBox<NewAppoinmentView>("8c88df61-626e-4908-8f96-753d8a5acc11","","",true, this);
 
            UIStartHourTime = RPSControlFactory.CreateRPSTextBox<NewAppoinmentView>("3c211b68-0ed6-4242-96c7-408fb5d9a932","","",false, this);
 
            UIEndHourTime = RPSControlFactory.CreateRPSTextBox<NewAppoinmentView>("9ba6076d-bad2-44fc-b7ab-470b85366453","","",false, this);
 
            UIIsAllDay = RPSControlFactory.CreateRPSCheckBox<NewAppoinmentView>("a5c52957-3ceb-4ae5-9090-69105c393a95","","",false, this);
 
            Unique = RPSControlFactory.CreateRPSOption<NewAppoinmentView>( "765e02e2-d080-4ba0-91b4-31c88391882a","","",this);
 
            AllDays = RPSControlFactory.CreateRPSOption<NewAppoinmentView>( "53ceaff4-f972-4ef5-ad3d-eee43019491b","","",this);
 
            Week = RPSControlFactory.CreateRPSOption<NewAppoinmentView>( "25a89969-2daa-43ac-b4f8-7483ab825da2","","",this);
 
            UIMonday = RPSControlFactory.CreateRPSCheckBox<NewAppoinmentView>("eae53b10-6170-4476-91c2-e50c097345e9","","",false, this);
 
            UITuesday = RPSControlFactory.CreateRPSCheckBox<NewAppoinmentView>("2580e343-9786-4e9a-8c3b-0ace485eee61","","",false, this);
 
            UIWednesday = RPSControlFactory.CreateRPSCheckBox<NewAppoinmentView>("250918f0-fdd4-42e7-9c41-cca29930f303","","",false, this);
 
            UIThursday = RPSControlFactory.CreateRPSCheckBox<NewAppoinmentView>("08aaf4f2-4e80-4f11-93dc-0337252b67e7","","",false, this);
 
            UIFriday = RPSControlFactory.CreateRPSCheckBox<NewAppoinmentView>("7e4f1b14-9f7a-43c8-8099-92755f8cff1d","","",false, this);
 
            UISaturday = RPSControlFactory.CreateRPSCheckBox<NewAppoinmentView>("1816fcb4-e8ef-4dc4-9245-6170630d2622","","",false, this);
 
            UISunday = RPSControlFactory.CreateRPSCheckBox<NewAppoinmentView>("3c89c60d-a59d-4ebf-8db0-95df549bf0d3","","",false, this);
 
            Each = RPSControlFactory.CreateRPSOption<NewAppoinmentView>( "a4ec575f-ed45-4c08-966a-bed473d5de0a","","",this);
 
            UIPeriodicityDays = RPSControlFactory.CreateRPSFormattedTextBox<NewAppoinmentView>("8ff8f0b5-db58-4bc6-9bd3-440e5bfd0c0c","","",false, this);
 
            eReminder = RPSControlFactory.CreateRPSEnumComboBox<NewAppoinmentView>("a88ae832-115c-44d8-aef8-2f851a9a31eb","","",false, this);
 

        }
        public IRPSOption<NewAppoinmentView> Project { get; set; } 
        public IRPSOption<NewAppoinmentView> Manufacturing { get; set; } 
        public IRPSOption<NewAppoinmentView> Maintenance { get; set; } 
        public IRPSOption<NewAppoinmentView> ResourceStop { get; set; } 
        public IRPSOption<NewAppoinmentView> CRM { get; set; } 
        public IRPSOption<NewAppoinmentView> Manual { get; set; } 
        public IRPSComboBox<NewAppoinmentView> IDProject { get; set; } 
        public IRPSComboBox<NewAppoinmentView> IDProTask { get; set; } 
        public IRPSTextBox<NewAppoinmentView> Comment { get; set; } 
        public IRPSComboBox<NewAppoinmentView> IDManufacturingOrder { get; set; } 
        public IRPSComboBox<NewAppoinmentView> IDMOTask { get; set; } 
        public IRPSTextBox<NewAppoinmentView> Comment1 { get; set; } 
        public IRPSComboBox<NewAppoinmentView> IDMaintenanceOrder { get; set; } 
        public IRPSTextBox<NewAppoinmentView> Comment2 { get; set; } 
        public IRPSComboBox<NewAppoinmentView> IDStopType { get; set; } 
        public IRPSTextBox<NewAppoinmentView> Comment3 { get; set; } 
        public IRPSComboBox<NewAppoinmentView> IDActivity { get; set; } 
        public IRPSTextBox<NewAppoinmentView> Description { get; set; } 
        public IRPSTextBox<NewAppoinmentView> Comment4 { get; set; } 
        public IRPSTextBox<NewAppoinmentView> Description1 { get; set; } 
        public IRPSTextBox<NewAppoinmentView> Comment5 { get; set; } 
        public IRPSTextBox<NewAppoinmentView> UniqueAppointmentDate { get; set; } 
        public IRPSTextBox<NewAppoinmentView> AppointmentDateStart { get; set; } 
        public IRPSTextBox<NewAppoinmentView> AppointmentDateEnd { get; set; } 
        public IRPSTextBox<NewAppoinmentView> UIStartHourTime { get; set; } 
        public IRPSTextBox<NewAppoinmentView> UIEndHourTime { get; set; } 
        public IRPSCheckbox<NewAppoinmentView> UIIsAllDay { get; set; } 
        public IRPSOption<NewAppoinmentView> Unique { get; set; } 
        public IRPSOption<NewAppoinmentView> AllDays { get; set; } 
        public IRPSOption<NewAppoinmentView> Week { get; set; } 
        public IRPSCheckbox<NewAppoinmentView> UIMonday { get; set; } 
        public IRPSCheckbox<NewAppoinmentView> UITuesday { get; set; } 
        public IRPSCheckbox<NewAppoinmentView> UIWednesday { get; set; } 
        public IRPSCheckbox<NewAppoinmentView> UIThursday { get; set; } 
        public IRPSCheckbox<NewAppoinmentView> UIFriday { get; set; } 
        public IRPSCheckbox<NewAppoinmentView> UISaturday { get; set; } 
        public IRPSCheckbox<NewAppoinmentView> UISunday { get; set; } 
        public IRPSOption<NewAppoinmentView> Each { get; set; } 
        public IRPSTextBox<NewAppoinmentView> UIPeriodicityDays { get; set; } 
        public IRPSComboBox<NewAppoinmentView> eReminder { get; set; } 
        public Agenda Screen { get; set; }
        public NewAppoinmentView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ProjectTaskActivityView : View
    {
        public ProjectTaskActivityView(Agenda screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIIDProject = RPSControlFactory.CreateRPSComboBox<ProjectTaskActivityView>("e2b43a1b-0d14-4063-b46f-29dac4c9b801","","",false, this);
 
            UIIDProjectResponsible = RPSControlFactory.CreateRPSComboBox<ProjectTaskActivityView>("c3232358-7d50-4bc3-8784-4a0e1c5426da","","",false, this);
 
            UIIDProjectTask = RPSControlFactory.CreateRPSComboBox<ProjectTaskActivityView>("476d2449-f371-40af-add3-707e35e19922","","",false, this);
 
            UIIDProjectTaskResponsible = RPSControlFactory.CreateRPSComboBox<ProjectTaskActivityView>("2003d679-1773-46e7-9144-d0273fac67d6","","",false, this);
 
            UIPlannedStartDate = RPSControlFactory.CreateRPSTextBox<ProjectTaskActivityView>("40fac5a7-5b12-40c9-9f13-a33cd4d59f70","","",false, this);
 
            UIPlannedEndDate = RPSControlFactory.CreateRPSTextBox<ProjectTaskActivityView>("835a6271-39f4-48c6-975c-bed841b778da","","",false, this);
 
            UIEstimatedTime = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskActivityView>("35798425-fbf0-4294-8543-8bbe3a3a8021","","",false, this);
 
            UIPercentProgress = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskActivityView>("fdb443bf-0039-4dae-bdb0-252335580b8a","","",false, this);
 
            UINotes = RPSControlFactory.CreateRPSTextBox<ProjectTaskActivityView>("fa14b1c4-cd67-4660-b251-10606ab5a90f","","",false, this);
 
            ImputationNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ProjectTaskActivityView,ImputationDialogView>("21708022-e818-4995-8b14-014cd9673569","","", this,Screen.ImputationDialogView);
 
            ImputationCostNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ProjectTaskActivityView,ImputationCostDialogView>("a7e53a97-dca4-49d2-afa8-cf37d78fa35c","","", this,Screen.ImputationCostDialogView);
 
            Notes = RPSControlFactory.CreateRPSSection<ProjectTaskActivityView>( "","ul li[rpsid='4285eadf-b5b4-4c23-9a8e-13af56f509f5']","",this);
 
            Documents = RPSControlFactory.CreateRPSSection<ProjectTaskActivityView>( "","ul li[rpsid='90913dfe-ce0d-467b-aaf9-c8a8ad22b7cd']","",this);
 

        }
        public IRPSComboBox<ProjectTaskActivityView> UIIDProject { get; set; } 
        public IRPSComboBox<ProjectTaskActivityView> UIIDProjectResponsible { get; set; } 
        public IRPSComboBox<ProjectTaskActivityView> UIIDProjectTask { get; set; } 
        public IRPSComboBox<ProjectTaskActivityView> UIIDProjectTaskResponsible { get; set; } 
        public IRPSTextBox<ProjectTaskActivityView> UIPlannedStartDate { get; set; } 
        public IRPSTextBox<ProjectTaskActivityView> UIPlannedEndDate { get; set; } 
        public IRPSTextBox<ProjectTaskActivityView> UIEstimatedTime { get; set; } 
        public IRPSTextBox<ProjectTaskActivityView> UIPercentProgress { get; set; } 
        public IRPSTextBox<ProjectTaskActivityView> UINotes { get; set; } 
        public IRPSButton<ProjectTaskActivityView,ImputationDialogView> ImputationNavigationCommandButton { get; set; } 
        public IRPSButton<ProjectTaskActivityView,ImputationCostDialogView> ImputationCostNavigationCommandButton { get; set; } 
        public IRPSSection<ProjectTaskActivityView> Notes { get; set; } 
        public IRPSSection<ProjectTaskActivityView> Documents { get; set; } 
        public Agenda Screen { get; set; }
        public ProjectTaskActivityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ImputationDialogView : View
    {
        public ImputationDialogView(Agenda screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Descripton = RPSControlFactory.CreateRPSTextBox<ImputationDialogView>("d20754fd-407a-4a6b-ab10-ea8399882d95","","",false, this);
 
            UIEstimatedTime = RPSControlFactory.CreateRPSFormattedTextBox<ImputationDialogView>("8d7600ba-4424-4fc0-8bf4-b83ea6ebb333","","",false, this);
 
            UIImputatedTime = RPSControlFactory.CreateRPSFormattedTextBox<ImputationDialogView>("32f52fae-3e50-4a4b-b6f9-5bbf901fd8ef","","",false, this);
 
            UIPercentProgress = RPSControlFactory.CreateRPSFormattedTextBox<ImputationDialogView>("9ab7ec04-4e0e-4837-9c45-2ea78ed6cddd","","",false, this);
 
            ImputationDate = RPSControlFactory.CreateRPSTextBox<ImputationDialogView>("7453b3cb-bd07-4fde-a171-547d3101f832","","",true, this);
 
            StartHour = RPSControlFactory.CreateRPSTextBox<ImputationDialogView>("c42ee475-832a-4da2-a826-702d673912d4","","",false, this);
 
            EndHour = RPSControlFactory.CreateRPSTextBox<ImputationDialogView>("d729529a-cbf3-400b-897f-12c8eb882c60","","",false, this);
 
            UIDuration = RPSControlFactory.CreateRPSDurationTextBox<ImputationDialogView>("3b263dd9-ee2e-4951-9d29-aba89aa91d0f","","",false, this);
 
            IDHourType = RPSControlFactory.CreateRPSComboBox<ImputationDialogView>("9b8da517-b520-4eeb-844f-6a229b68a1fb","","",true, this);
 
            PercentProgress = RPSControlFactory.CreateRPSFormattedTextBox<ImputationDialogView>("8bea89af-db22-4076-8da7-422084a863cb","","",true, this);
 
            Unproductive = RPSControlFactory.CreateRPSCheckBox<ImputationDialogView>("eeea26b7-269a-4d10-81ec-54e1b1b526ea","","",true, this);
 
            IDUnproductiveType = RPSControlFactory.CreateRPSComboBox<ImputationDialogView>("2e7e1bef-0687-4ccf-951b-0067f95df70b","","",false, this);
 

        }
        public IRPSTextBox<ImputationDialogView> Descripton { get; set; } 
        public IRPSTextBox<ImputationDialogView> UIEstimatedTime { get; set; } 
        public IRPSTextBox<ImputationDialogView> UIImputatedTime { get; set; } 
        public IRPSTextBox<ImputationDialogView> UIPercentProgress { get; set; } 
        public IRPSTextBox<ImputationDialogView> ImputationDate { get; set; } 
        public IRPSTextBox<ImputationDialogView> StartHour { get; set; } 
        public IRPSTextBox<ImputationDialogView> EndHour { get; set; } 
        public IRPSDurationTextBox<ImputationDialogView> UIDuration { get; set; } 
        public IRPSComboBox<ImputationDialogView> IDHourType { get; set; } 
        public IRPSTextBox<ImputationDialogView> PercentProgress { get; set; } 
        public IRPSCheckbox<ImputationDialogView> Unproductive { get; set; } 
        public IRPSComboBox<ImputationDialogView> IDUnproductiveType { get; set; } 
        public Agenda Screen { get; set; }
        public ImputationDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ImputationCostDialogView : View
    {
        public ImputationCostDialogView(Agenda screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Description = RPSControlFactory.CreateRPSTextBox<ImputationCostDialogView>("5844c563-ed94-4c17-b1e1-65c8854d7502","","",false, this);
 
            ImputationDate = RPSControlFactory.CreateRPSTextBox<ImputationCostDialogView>("ef8cbfef-d7c2-4bf1-84d9-ae77a4e42b91","","",true, this);
 
            IDCostComponent = RPSControlFactory.CreateRPSComboBox<ImputationCostDialogView>("39cb9329-a4f2-4e0c-aeab-a13de478b8c1","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<ImputationCostDialogView>("33af9bb8-048c-4f4d-a3c7-c8dc6d7ad66f","","",true, this);
 
            CostPriceReal = RPSControlFactory.CreateRPSFormattedTextBox<ImputationCostDialogView>("ec5ca8ce-dd3d-4803-90eb-6d79d55cf855","","",true, this);
 
            CostAmountReal = RPSControlFactory.CreateRPSFormattedTextBox<ImputationCostDialogView>("cd437650-cefd-4596-9996-65a892839063","","",true, this);
 

        }
        public IRPSTextBox<ImputationCostDialogView> Description { get; set; } 
        public IRPSTextBox<ImputationCostDialogView> ImputationDate { get; set; } 
        public IRPSComboBox<ImputationCostDialogView> IDCostComponent { get; set; } 
        public IRPSTextBox<ImputationCostDialogView> Quantity { get; set; } 
        public IRPSTextBox<ImputationCostDialogView> CostPriceReal { get; set; } 
        public IRPSTextBox<ImputationCostDialogView> CostAmountReal { get; set; } 
        public Agenda Screen { get; set; }
        public ImputationCostDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenanceOrderActivityView : View
    {
        public MaintenanceOrderActivityView(Agenda screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIIDMaintenanceOrder = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderActivityView>("a50b5c17-b084-46da-9364-b942ff1035d7","","",false, this);
 
            UIIDMaintenanceComponent = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderActivityView>("a043606a-656e-4fca-8131-47c2535842b3","","",false, this);
 
            UIPlannedStartDate = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderActivityView>("daf5abd9-2bc8-475f-8ed5-7cabd6c1a92f","","",false, this);
 
            UIPlannedEndDate = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderActivityView>("efb75a67-77e3-49e1-88ed-7fd3f1484acf","","",false, this);
 
            UIEstimatedTime = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceOrderActivityView>("48d7128f-72b1-400b-824e-40b636dcbe14","","",false, this);
 
            UIPercentProgress = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceOrderActivityView>("d6dc4857-fb9b-4009-9bf2-6c1649b9f848","","",false, this);
 
            UINotes = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderActivityView>("f192376f-5d5e-4c83-b3a5-1b6c2a7a82f3","","",false, this);
 
            MaintenanceOrderEmployeeNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<MaintenanceOrderActivityView,MaintenanceOrderEmployeeDialogView>("0e03fe5d-fe27-46fb-acf0-5ee4a8490aeb","","", this,Screen.MaintenanceOrderEmployeeDialogView);
 
            ManOrderEmployeeExpensesNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<MaintenanceOrderActivityView,ManOrderEmployeeExpensesDialogView>("c032b372-d211-43b8-aaaa-b96e75d9d369","","", this,Screen.ManOrderEmployeeExpensesDialogView);
 
            Notes = RPSControlFactory.CreateRPSSection<MaintenanceOrderActivityView>( "","ul li[rpsid='14119629-b793-4267-9158-c4e78fdfef08']","",this);
 
            Documents = RPSControlFactory.CreateRPSSection<MaintenanceOrderActivityView>( "","ul li[rpsid='cf71b253-2f92-43bc-93a9-0a70a7bcaa69']","",this);
 

        }
        public IRPSComboBox<MaintenanceOrderActivityView> UIIDMaintenanceOrder { get; set; } 
        public IRPSComboBox<MaintenanceOrderActivityView> UIIDMaintenanceComponent { get; set; } 
        public IRPSTextBox<MaintenanceOrderActivityView> UIPlannedStartDate { get; set; } 
        public IRPSTextBox<MaintenanceOrderActivityView> UIPlannedEndDate { get; set; } 
        public IRPSTextBox<MaintenanceOrderActivityView> UIEstimatedTime { get; set; } 
        public IRPSTextBox<MaintenanceOrderActivityView> UIPercentProgress { get; set; } 
        public IRPSTextBox<MaintenanceOrderActivityView> UINotes { get; set; } 
        public IRPSButton<MaintenanceOrderActivityView,MaintenanceOrderEmployeeDialogView> MaintenanceOrderEmployeeNavigationCommandButton { get; set; } 
        public IRPSButton<MaintenanceOrderActivityView,ManOrderEmployeeExpensesDialogView> ManOrderEmployeeExpensesNavigationCommandButton { get; set; } 
        public IRPSSection<MaintenanceOrderActivityView> Notes { get; set; } 
        public IRPSSection<MaintenanceOrderActivityView> Documents { get; set; } 
        public Agenda Screen { get; set; }
        public MaintenanceOrderActivityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenanceOrderEmployeeDialogView : View
    {
        public MaintenanceOrderEmployeeDialogView(Agenda screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIEstimatedTime = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceOrderEmployeeDialogView>("37f006a6-3f5f-4629-b7a7-8a4e8e5b0c56","","",false, this);
 
            UIImputatedTime = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceOrderEmployeeDialogView>("86736481-aa67-41d1-b2a2-4e41c83a8653","","",false, this);
 
            UIPercentProgress = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceOrderEmployeeDialogView>("5a25c208-d6b5-4ef1-a82b-b065ae3ab71a","","",false, this);
 
            InitialDate = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderEmployeeDialogView>("7e47db1d-e1d0-4857-b97f-6f07dda7077d","","",false, this);
 
            InitialTime = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderEmployeeDialogView>("932c1fe9-0082-4964-9a73-754fc9755459","","",false, this);
 
            FinalDate = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderEmployeeDialogView>("b225073b-40b2-4b11-b65e-9641fa0b54d6","","",false, this);
 
            FinalTime = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderEmployeeDialogView>("a31ceae1-bb7e-460c-9f79-4e9e442fe03f","","",false, this);
 
            Duration = RPSControlFactory.CreateRPSDurationTextBox<MaintenanceOrderEmployeeDialogView>("a0f5bd93-38be-40a4-b8d1-2a948ac12cf8","","",true, this);
 
            IDHourType = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderEmployeeDialogView>("c728a788-5604-4f03-9a6e-82472cd12e44","","",true, this);
 

        }
        public IRPSTextBox<MaintenanceOrderEmployeeDialogView> UIEstimatedTime { get; set; } 
        public IRPSTextBox<MaintenanceOrderEmployeeDialogView> UIImputatedTime { get; set; } 
        public IRPSTextBox<MaintenanceOrderEmployeeDialogView> UIPercentProgress { get; set; } 
        public IRPSTextBox<MaintenanceOrderEmployeeDialogView> InitialDate { get; set; } 
        public IRPSTextBox<MaintenanceOrderEmployeeDialogView> InitialTime { get; set; } 
        public IRPSTextBox<MaintenanceOrderEmployeeDialogView> FinalDate { get; set; } 
        public IRPSTextBox<MaintenanceOrderEmployeeDialogView> FinalTime { get; set; } 
        public IRPSDurationTextBox<MaintenanceOrderEmployeeDialogView> Duration { get; set; } 
        public IRPSComboBox<MaintenanceOrderEmployeeDialogView> IDHourType { get; set; } 
        public Agenda Screen { get; set; }
        public MaintenanceOrderEmployeeDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ManOrderEmployeeExpensesDialogView : View
    {
        public ManOrderEmployeeExpensesDialogView(Agenda screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            StartDate = RPSControlFactory.CreateRPSTextBox<ManOrderEmployeeExpensesDialogView>("bc5427eb-f3a1-415f-97e2-dfcb0fb21afb","","",true, this);
 
            EndDate = RPSControlFactory.CreateRPSTextBox<ManOrderEmployeeExpensesDialogView>("542492e3-3bfa-4915-8a24-bd96e4bf71e7","","",true, this);
 
            Destination = RPSControlFactory.CreateRPSTextBox<ManOrderEmployeeExpensesDialogView>("a12e4542-cddc-4e35-a421-e7c47d5dff22","","",true, this);
 
            DietAmount = RPSControlFactory.CreateRPSFormattedTextBox<ManOrderEmployeeExpensesDialogView>("0dba6beb-0563-4f68-8cd7-94a1e0661385","","",true, this);
 
            Kilometers = RPSControlFactory.CreateRPSFormattedTextBox<ManOrderEmployeeExpensesDialogView>("fcec0530-1ab4-4cbd-b620-d7ddc3ee3cbd","","",true, this);
 
            KmAmount = RPSControlFactory.CreateRPSFormattedTextBox<ManOrderEmployeeExpensesDialogView>("e600975e-2e75-4cc8-8bf6-79e749c02f3b","","",true, this);
 
            Tolls = RPSControlFactory.CreateRPSFormattedTextBox<ManOrderEmployeeExpensesDialogView>("48effede-f146-4cfb-a226-3886fab8de75","","",true, this);
 
            Meals = RPSControlFactory.CreateRPSFormattedTextBox<ManOrderEmployeeExpensesDialogView>("2ec88f03-8c05-410a-8d1d-5406dd9d136d","","",true, this);
 
            Transports = RPSControlFactory.CreateRPSFormattedTextBox<ManOrderEmployeeExpensesDialogView>("f1521b3f-a4c7-4ebc-a386-16ce72b917a8","","",true, this);
 
            Hotels = RPSControlFactory.CreateRPSFormattedTextBox<ManOrderEmployeeExpensesDialogView>("ccd226f3-1993-42f6-93fd-3e99ee7b6554","","",true, this);
 
            Comments = RPSControlFactory.CreateRPSTextBox<ManOrderEmployeeExpensesDialogView>("9069b611-5b5b-4b5b-9552-7f6b0dfb4ed3","","",false, this);
 

        }
        public IRPSTextBox<ManOrderEmployeeExpensesDialogView> StartDate { get; set; } 
        public IRPSTextBox<ManOrderEmployeeExpensesDialogView> EndDate { get; set; } 
        public IRPSTextBox<ManOrderEmployeeExpensesDialogView> Destination { get; set; } 
        public IRPSTextBox<ManOrderEmployeeExpensesDialogView> DietAmount { get; set; } 
        public IRPSTextBox<ManOrderEmployeeExpensesDialogView> Kilometers { get; set; } 
        public IRPSTextBox<ManOrderEmployeeExpensesDialogView> KmAmount { get; set; } 
        public IRPSTextBox<ManOrderEmployeeExpensesDialogView> Tolls { get; set; } 
        public IRPSTextBox<ManOrderEmployeeExpensesDialogView> Meals { get; set; } 
        public IRPSTextBox<ManOrderEmployeeExpensesDialogView> Transports { get; set; } 
        public IRPSTextBox<ManOrderEmployeeExpensesDialogView> Hotels { get; set; } 
        public IRPSTextBox<ManOrderEmployeeExpensesDialogView> Comments { get; set; } 
        public Agenda Screen { get; set; }
        public ManOrderEmployeeExpensesDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MOTaskActivityView : View
    {
        public MOTaskActivityView(Agenda screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIIDManufacturingOrder = RPSControlFactory.CreateRPSComboBox<MOTaskActivityView>("5d19d324-e701-4a52-9da1-1408f8ea3b6b","","",false, this);
 
            UIIDMOTask = RPSControlFactory.CreateRPSComboBox<MOTaskActivityView>("0bd59f3c-0658-4a6d-9158-6a1eaa944b20","","",false, this);
 
            UIPlannedStartDate = RPSControlFactory.CreateRPSTextBox<MOTaskActivityView>("1c7d4afe-ac3d-482e-85bc-b838010438b2","","",false, this);
 
            UIPlannedEndDate = RPSControlFactory.CreateRPSTextBox<MOTaskActivityView>("d65ecc02-94bf-412f-9fc2-973efedc48e8","","",false, this);
 
            UIEstimatedTime = RPSControlFactory.CreateRPSFormattedTextBox<MOTaskActivityView>("bcc5bbd8-14cd-4efd-9d4e-0a54abf758b6","","",false, this);
 
            UIPercentProgress = RPSControlFactory.CreateRPSFormattedTextBox<MOTaskActivityView>("e451b583-5305-4cfb-9eee-e5ad9f2e976b","","",false, this);
 
            UINotes = RPSControlFactory.CreateRPSTextBox<MOTaskActivityView>("8283b7c2-febc-4373-a0c3-9109d442151a","","",false, this);
 
            ImputationMONavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<MOTaskActivityView,ImputationMODialogView>("0f09ebc8-17e3-472b-b8f5-cfe096382883","","", this,Screen.ImputationMODialogView);
 
            ImputationCostMONavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<MOTaskActivityView,ImputationCostMODialogView>("84ebd497-d03a-48bf-bfc6-6e845136d1d9","","", this,Screen.ImputationCostMODialogView);
 
            Notes = RPSControlFactory.CreateRPSSection<MOTaskActivityView>( "","ul li[rpsid='5e36a406-a1eb-4b82-8376-0546a4e34396']","",this);
 
            Documents = RPSControlFactory.CreateRPSSection<MOTaskActivityView>( "","ul li[rpsid='4694a37e-d738-4a89-84ce-b808285e44ac']","",this);
 

        }
        public IRPSComboBox<MOTaskActivityView> UIIDManufacturingOrder { get; set; } 
        public IRPSComboBox<MOTaskActivityView> UIIDMOTask { get; set; } 
        public IRPSTextBox<MOTaskActivityView> UIPlannedStartDate { get; set; } 
        public IRPSTextBox<MOTaskActivityView> UIPlannedEndDate { get; set; } 
        public IRPSTextBox<MOTaskActivityView> UIEstimatedTime { get; set; } 
        public IRPSTextBox<MOTaskActivityView> UIPercentProgress { get; set; } 
        public IRPSTextBox<MOTaskActivityView> UINotes { get; set; } 
        public IRPSButton<MOTaskActivityView,ImputationMODialogView> ImputationMONavigationCommandButton { get; set; } 
        public IRPSButton<MOTaskActivityView,ImputationCostMODialogView> ImputationCostMONavigationCommandButton { get; set; } 
        public IRPSSection<MOTaskActivityView> Notes { get; set; } 
        public IRPSSection<MOTaskActivityView> Documents { get; set; } 
        public Agenda Screen { get; set; }
        public MOTaskActivityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ImputationMODialogView : View
    {
        public ImputationMODialogView(Agenda screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIEstimatedTime = RPSControlFactory.CreateRPSFormattedTextBox<ImputationMODialogView>("7f12d25d-2d45-4af7-9c6a-ef0957ec3fd9","","",false, this);
 
            UIImputatedTime = RPSControlFactory.CreateRPSFormattedTextBox<ImputationMODialogView>("1975d823-c482-431e-9f97-981469099d2e","","",false, this);
 
            UIPercentProgress = RPSControlFactory.CreateRPSFormattedTextBox<ImputationMODialogView>("0dfba4df-2bd0-41bf-8339-21258e9212aa","","",false, this);
 
            ImputationDate = RPSControlFactory.CreateRPSTextBox<ImputationMODialogView>("92692a87-baff-4c44-8471-82d93e09654a","","",true, this);
 
            StartHour = RPSControlFactory.CreateRPSTextBox<ImputationMODialogView>("361737a9-0a59-4f6b-8762-a2017601bf89","","",true, this);
 
            EndHour = RPSControlFactory.CreateRPSTextBox<ImputationMODialogView>("4abc41cd-3395-46b6-9274-d302b38ba14d","","",true, this);
 
            UIDuration = RPSControlFactory.CreateRPSDurationTextBox<ImputationMODialogView>("eec171b9-c11f-47d5-b3fa-2d1d3b0ebb6c","","",false, this);
 
            IDHourType = RPSControlFactory.CreateRPSComboBox<ImputationMODialogView>("d82ff331-b9f2-44a1-840d-afa9b3a60ba9","","",true, this);
 
            PercentProgress = RPSControlFactory.CreateRPSFormattedTextBox<ImputationMODialogView>("1e37d43e-7e73-456d-be4f-f665e5503ea6","","",true, this);
 
            Unproductive = RPSControlFactory.CreateRPSCheckBox<ImputationMODialogView>("d6910528-e8a9-473e-a7ff-cf1040683419","","",true, this);
 
            IDUnproductiveType = RPSControlFactory.CreateRPSComboBox<ImputationMODialogView>("2bd9dc61-466b-4161-980b-eacd374445ec","","",false, this);
 

        }
        public IRPSTextBox<ImputationMODialogView> UIEstimatedTime { get; set; } 
        public IRPSTextBox<ImputationMODialogView> UIImputatedTime { get; set; } 
        public IRPSTextBox<ImputationMODialogView> UIPercentProgress { get; set; } 
        public IRPSTextBox<ImputationMODialogView> ImputationDate { get; set; } 
        public IRPSTextBox<ImputationMODialogView> StartHour { get; set; } 
        public IRPSTextBox<ImputationMODialogView> EndHour { get; set; } 
        public IRPSDurationTextBox<ImputationMODialogView> UIDuration { get; set; } 
        public IRPSComboBox<ImputationMODialogView> IDHourType { get; set; } 
        public IRPSTextBox<ImputationMODialogView> PercentProgress { get; set; } 
        public IRPSCheckbox<ImputationMODialogView> Unproductive { get; set; } 
        public IRPSComboBox<ImputationMODialogView> IDUnproductiveType { get; set; } 
        public Agenda Screen { get; set; }
        public ImputationMODialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ImputationCostMODialogView : View
    {
        public ImputationCostMODialogView(Agenda screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ImputationDate = RPSControlFactory.CreateRPSTextBox<ImputationCostMODialogView>("2b3a733b-afb8-4c96-b4ce-1d304389a981","","",true, this);
 
            IDCostComponent = RPSControlFactory.CreateRPSComboBox<ImputationCostMODialogView>("70c45f93-2686-4aa7-859b-97f3a29bef7d","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<ImputationCostMODialogView>("f3e739e5-199b-40cf-8411-7b6331644d02","","",true, this);
 
            CostPriceReal = RPSControlFactory.CreateRPSFormattedTextBox<ImputationCostMODialogView>("1c1c0f26-062d-4a71-ab0c-18744164adbd","","",true, this);
 
            CostAmountReal = RPSControlFactory.CreateRPSFormattedTextBox<ImputationCostMODialogView>("d8c8d287-6ea0-4296-ae5e-34d358ae05a9","","",true, this);
 

        }
        public IRPSTextBox<ImputationCostMODialogView> ImputationDate { get; set; } 
        public IRPSComboBox<ImputationCostMODialogView> IDCostComponent { get; set; } 
        public IRPSTextBox<ImputationCostMODialogView> Quantity { get; set; } 
        public IRPSTextBox<ImputationCostMODialogView> CostPriceReal { get; set; } 
        public IRPSTextBox<ImputationCostMODialogView> CostAmountReal { get; set; } 
        public Agenda Screen { get; set; }
        public ImputationCostMODialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ManualActivityView : View
    {
        public ManualActivityView(Agenda screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ManualActivityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ManualActivityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ManualActivityView,AgendaView>( this,Screen.AgendaView);
 
            BackButton = RPSControlFactory.RPSBackButton<ManualActivityView,AgendaView>( this,Screen.AgendaView);
 
            CodActivity = RPSControlFactory.CreateRPSTextBox<ManualActivityView>("4caf2829-8b72-453e-8554-f7638d7c1d5b","","",true, this);
 
            Status = RPSControlFactory.CreateRPSEnumComboBox<ManualActivityView>("f45077b8-0cd3-4509-970c-c368b0f29084","","",true, this);
 
            Priority = RPSControlFactory.CreateRPSEnumComboBox<ManualActivityView>("c1579d88-54c0-4646-9227-f21474a33fa7","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ManualActivityView>("de39ad0f-d5ec-488d-a1fc-11e8eece7c60","","",false, this);
 
            CreationDate = RPSControlFactory.CreateRPSTextBox<ManualActivityView>("a3d2435b-309c-491f-a1d8-99135a2234e4","","",true, this);
 
            CreationTime = RPSControlFactory.CreateRPSTextBox<ManualActivityView>("a648d22c-dfe2-4cf3-a7f8-7a844415a5f2","","",true, this);
 
            ExecutionTime = RPSControlFactory.CreateRPSFormattedTextBox<ManualActivityView>("865718de-0838-45ab-9aeb-1e2faad0daa6","","",true, this);
 
            DueDate = RPSControlFactory.CreateRPSTextBox<ManualActivityView>("2b0c8b36-7e69-46ae-866d-d9d80378dab9","","",true, this);
 
            DueTime = RPSControlFactory.CreateRPSTextBox<ManualActivityView>("2561252d-b199-4083-9259-9e273658091e","","",false, this);
 
            Progress = RPSControlFactory.CreateRPSFormattedTextBox<ManualActivityView>("5cf9c387-b30d-4c4c-adee-5f0082663b5c","","",true, this);
 
            EndDate = RPSControlFactory.CreateRPSTextBox<ManualActivityView>("3eedd720-0507-44fa-8b19-5abafc8e1b7a","","",false, this);
 
            EndTime = RPSControlFactory.CreateRPSTextBox<ManualActivityView>("0b56bfd9-832b-4667-ac13-8f7ab479e0e1","","",false, this);
 
            RealTime = RPSControlFactory.CreateRPSFormattedTextBox<ManualActivityView>("115189ce-090a-471a-b38f-b95d0ae32def","","",true, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<ManualActivityView>("908b91dd-0da1-4f61-93e4-d8f29afe2477","","",false, this);
 

        }
        public IRPSSaveButton<ManualActivityView> SaveButton { get; set; } 
        public IRPSButton<ManualActivityView> DeleteButton { get; set; } 
        public IRPSButton<ManualActivityView,AgendaView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ManualActivityView,AgendaView> BackButton { get; set; } 
        public IRPSTextBox<ManualActivityView> CodActivity { get; set; } 
        public IRPSComboBox<ManualActivityView> Status { get; set; } 
        public IRPSComboBox<ManualActivityView> Priority { get; set; } 
        public IRPSTextBox<ManualActivityView> Description { get; set; } 
        public IRPSTextBox<ManualActivityView> CreationDate { get; set; } 
        public IRPSTextBox<ManualActivityView> CreationTime { get; set; } 
        public IRPSTextBox<ManualActivityView> ExecutionTime { get; set; } 
        public IRPSTextBox<ManualActivityView> DueDate { get; set; } 
        public IRPSTextBox<ManualActivityView> DueTime { get; set; } 
        public IRPSTextBox<ManualActivityView> Progress { get; set; } 
        public IRPSTextBox<ManualActivityView> EndDate { get; set; } 
        public IRPSTextBox<ManualActivityView> EndTime { get; set; } 
        public IRPSTextBox<ManualActivityView> RealTime { get; set; } 
        public IRPSTextBox<ManualActivityView> Comment { get; set; } 
        public Agenda Screen { get; set; }
        public ManualActivityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class UsersInDownHierarchyDialogView : View
    {
        public UsersInDownHierarchyDialogView(Agenda screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ShowEmployeesWithoutUser = RPSControlFactory.CreateRPSCheckBox<UsersInDownHierarchyDialogView>("6eb8d14c-0585-409f-968d-94f4bee4ef2b","","",false, this);
 
            CollectionInit params_UsersAndEmployeesForAgenda = new CollectionInit(){IDDescriptor = "60b1fa1c-dafa-441c-ace4-78c929106efd",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            UsersAndEmployeesForAgenda = RPSControlFactory.RPSCreateCollection<UsersInDownHierarchyDialogView>( params_UsersAndEmployeesForAgenda,this);
 

        }
        public IRPSCheckbox<UsersInDownHierarchyDialogView> ShowEmployeesWithoutUser { get; set; } 
        public IRPSCollectionEditor<UsersInDownHierarchyDialogView> UsersAndEmployeesForAgenda { get; set; } 
        public Agenda Screen { get; set; }
        public UsersInDownHierarchyDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NewImputationView : View
    {
        public NewImputationView(Agenda screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Project = RPSControlFactory.CreateRPSOption<NewImputationView>( "482e8321-1a41-4a74-9cd9-1c3e887ed13d","","",this);
 
            Manufacturing = RPSControlFactory.CreateRPSOption<NewImputationView>( "67157003-7fe3-4a32-9baa-a847bca4c447","","",this);
 
            Maintenance = RPSControlFactory.CreateRPSOption<NewImputationView>( "a16e68a5-14c2-4269-a300-438859926561","","",this);
 
            UIIDProject = RPSControlFactory.CreateRPSComboBox<NewImputationView>("58b99c93-e797-4498-b8ab-51d2a1b6ef98","","",false, this);
 
            UIIDProjectTask = RPSControlFactory.CreateRPSComboBox<NewImputationView>("c2e86083-2257-44ae-a2ba-75a33c393efa","","",false, this);
 
            UIIDManufacturingOrder = RPSControlFactory.CreateRPSComboBox<NewImputationView>("93e00bbf-e8da-4217-85da-277fa1b4ac4f","","",false, this);
 
            UIIDMOTask = RPSControlFactory.CreateRPSComboBox<NewImputationView>("70226d59-08d4-48ba-b58d-da7e670bd743","","",false, this);
 
            UIIDMaintenanceOrder = RPSControlFactory.CreateRPSComboBox<NewImputationView>("fb7ac65d-dae7-4e81-ac9d-b95cd55408ae","","",false, this);
 
            Unique = RPSControlFactory.CreateRPSOption<NewImputationView>( "8b7ca3f7-ef6f-4a3b-9c1c-689350fbe502","","",this);
 
            AllDays = RPSControlFactory.CreateRPSOption<NewImputationView>( "03695beb-44ce-4f8b-8917-2ecc8c3de361","","",this);
 
            Week = RPSControlFactory.CreateRPSOption<NewImputationView>( "621670eb-b096-40a7-ae78-9b6e346b3942","","",this);
 
            UIMonday = RPSControlFactory.CreateRPSCheckBox<NewImputationView>("86153832-16c7-4f70-939a-7fba64030a6c","","",false, this);
 
            UITuesday = RPSControlFactory.CreateRPSCheckBox<NewImputationView>("ecb1a7dd-94c0-4aa7-80b4-382e68b8f091","","",false, this);
 
            UIWednesday = RPSControlFactory.CreateRPSCheckBox<NewImputationView>("c173fcb2-1049-4135-8097-dadae810b9bf","","",false, this);
 
            UIThursday = RPSControlFactory.CreateRPSCheckBox<NewImputationView>("40811fd5-7a14-4f27-a3a1-128935e8fa01","","",false, this);
 
            UIFriday = RPSControlFactory.CreateRPSCheckBox<NewImputationView>("4bcc5651-2a95-4827-ae06-26738b15de59","","",false, this);
 
            UISaturday = RPSControlFactory.CreateRPSCheckBox<NewImputationView>("20640863-38f5-498e-bdea-dad91c956759","","",false, this);
 
            UISunday = RPSControlFactory.CreateRPSCheckBox<NewImputationView>("2633ed04-b1de-4b3a-ae0c-f8f00e4eaf06","","",false, this);
 
            Each = RPSControlFactory.CreateRPSOption<NewImputationView>( "4cfac1a3-4805-40a4-ac01-91e3b75ee951","","",this);
 
            UIPeriodicityDays = RPSControlFactory.CreateRPSFormattedTextBox<NewImputationView>("9ec9cb39-1aab-4abf-9bf0-9906a0adda93","","",false, this);
 
            UIDateFromImputation = RPSControlFactory.CreateRPSTextBox<NewImputationView>("4fcc2b73-bb7b-4133-979a-be5bcb955fae","","",false, this);
 
            UIDateToImputation = RPSControlFactory.CreateRPSTextBox<NewImputationView>("1354a918-cc43-4a28-a3e5-dad7225a5273","","",false, this);
 
            UIStartHour = RPSControlFactory.CreateRPSTextBox<NewImputationView>("6fc9c977-1d0b-48ba-8b65-cd031b9a8660","","",false, this);
 
            UIEndHour = RPSControlFactory.CreateRPSTextBox<NewImputationView>("8f25ce62-f9fa-4e96-a9a8-d78e231a3a5f","","",false, this);
 
            UIDuration = RPSControlFactory.CreateRPSDurationTextBox<NewImputationView>("6e99c7ff-6e3f-4549-988e-c165c837b48e","","",false, this);
 
            UIIDHourType = RPSControlFactory.CreateRPSComboBox<NewImputationView>("fefa785d-be08-4087-8344-3386620c212a","","",false, this);
 
            UIPROUnproductive = RPSControlFactory.CreateRPSCheckBox<NewImputationView>("144115f8-d6ab-49f2-9319-ade80c85e3d3","","",false, this);
 
            UIIDPROUnproductiveType = RPSControlFactory.CreateRPSComboBox<NewImputationView>("b80f97d5-6b6c-4325-8cb4-e5d169677b05","","",false, this);
 
            UIMOUnproductive = RPSControlFactory.CreateRPSCheckBox<NewImputationView>("831c530b-4914-4c45-8549-38235d9e9a55","","",false, this);
 
            UIIDMOUnproductiveType = RPSControlFactory.CreateRPSComboBox<NewImputationView>("3a13e4c1-0ca7-4898-895d-d239b55054e2","","",false, this);
 

        }
        public IRPSOption<NewImputationView> Project { get; set; } 
        public IRPSOption<NewImputationView> Manufacturing { get; set; } 
        public IRPSOption<NewImputationView> Maintenance { get; set; } 
        public IRPSComboBox<NewImputationView> UIIDProject { get; set; } 
        public IRPSComboBox<NewImputationView> UIIDProjectTask { get; set; } 
        public IRPSComboBox<NewImputationView> UIIDManufacturingOrder { get; set; } 
        public IRPSComboBox<NewImputationView> UIIDMOTask { get; set; } 
        public IRPSComboBox<NewImputationView> UIIDMaintenanceOrder { get; set; } 
        public IRPSOption<NewImputationView> Unique { get; set; } 
        public IRPSOption<NewImputationView> AllDays { get; set; } 
        public IRPSOption<NewImputationView> Week { get; set; } 
        public IRPSCheckbox<NewImputationView> UIMonday { get; set; } 
        public IRPSCheckbox<NewImputationView> UITuesday { get; set; } 
        public IRPSCheckbox<NewImputationView> UIWednesday { get; set; } 
        public IRPSCheckbox<NewImputationView> UIThursday { get; set; } 
        public IRPSCheckbox<NewImputationView> UIFriday { get; set; } 
        public IRPSCheckbox<NewImputationView> UISaturday { get; set; } 
        public IRPSCheckbox<NewImputationView> UISunday { get; set; } 
        public IRPSOption<NewImputationView> Each { get; set; } 
        public IRPSTextBox<NewImputationView> UIPeriodicityDays { get; set; } 
        public IRPSTextBox<NewImputationView> UIDateFromImputation { get; set; } 
        public IRPSTextBox<NewImputationView> UIDateToImputation { get; set; } 
        public IRPSTextBox<NewImputationView> UIStartHour { get; set; } 
        public IRPSTextBox<NewImputationView> UIEndHour { get; set; } 
        public IRPSDurationTextBox<NewImputationView> UIDuration { get; set; } 
        public IRPSComboBox<NewImputationView> UIIDHourType { get; set; } 
        public IRPSCheckbox<NewImputationView> UIPROUnproductive { get; set; } 
        public IRPSComboBox<NewImputationView> UIIDPROUnproductiveType { get; set; } 
        public IRPSCheckbox<NewImputationView> UIMOUnproductive { get; set; } 
        public IRPSComboBox<NewImputationView> UIIDMOUnproductiveType { get; set; } 
        public Agenda Screen { get; set; }
        public NewImputationView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DeleteAppointmentsView : View
    {
        public DeleteAppointmentsView(Agenda screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            All = RPSControlFactory.CreateRPSOption<DeleteAppointmentsView>( "3e4631b1-6066-4fee-ae81-56235cb744a0","","",this);
 
            AppointmentType = RPSControlFactory.CreateRPSOption<DeleteAppointmentsView>( "69452b5a-de38-41a3-aa3a-c85177ca4d71","","",this);
 
            UIeTypeAppointment = RPSControlFactory.CreateRPSEnumComboBox<DeleteAppointmentsView>("164321a4-0e29-4317-a6b1-beadafdb3e22","","",false, this);
 
            UIIDProject = RPSControlFactory.CreateRPSComboBox<DeleteAppointmentsView>("258b3a96-17bd-4302-92d3-dd5a6456ba77","","",false, this);
 
            UIIDManufacturingOrder = RPSControlFactory.CreateRPSComboBox<DeleteAppointmentsView>("96623206-b6fd-4835-9f8a-db4769d8e676","","",false, this);
 
            UIIDMaintenanceOrder = RPSControlFactory.CreateRPSComboBox<DeleteAppointmentsView>("71069151-06ff-4b1e-ba47-5d9764d3af74","","",false, this);
 
            UIIDStopType = RPSControlFactory.CreateRPSComboBox<DeleteAppointmentsView>("7cb7e45a-46ac-4b6a-ab01-dd1cebf8665e","","",false, this);
 
            UIIDActivity = RPSControlFactory.CreateRPSComboBox<DeleteAppointmentsView>("99c01000-39a4-4f43-bf86-b69c43489507","","",false, this);
 
            UIDateFrom = RPSControlFactory.CreateRPSTextBox<DeleteAppointmentsView>("66a265c9-43f3-4255-ac30-f16a99ce4f51","","",false, this);
 
            UIDateTo = RPSControlFactory.CreateRPSTextBox<DeleteAppointmentsView>("06996800-b40d-4aaa-9d7c-a31b3671d5e5","","",false, this);
 

        }
        public IRPSOption<DeleteAppointmentsView> All { get; set; } 
        public IRPSOption<DeleteAppointmentsView> AppointmentType { get; set; } 
        public IRPSComboBox<DeleteAppointmentsView> UIeTypeAppointment { get; set; } 
        public IRPSComboBox<DeleteAppointmentsView> UIIDProject { get; set; } 
        public IRPSComboBox<DeleteAppointmentsView> UIIDManufacturingOrder { get; set; } 
        public IRPSComboBox<DeleteAppointmentsView> UIIDMaintenanceOrder { get; set; } 
        public IRPSComboBox<DeleteAppointmentsView> UIIDStopType { get; set; } 
        public IRPSComboBox<DeleteAppointmentsView> UIIDActivity { get; set; } 
        public IRPSTextBox<DeleteAppointmentsView> UIDateFrom { get; set; } 
        public IRPSTextBox<DeleteAppointmentsView> UIDateTo { get; set; } 
        public Agenda Screen { get; set; }
        public DeleteAppointmentsView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NCPendingActionView : View
    {
        public NCPendingActionView(Agenda screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDNonConformity = RPSControlFactory.CreateRPSComboBox<NCPendingActionView>("0c06df12-08ce-4fa8-b198-8866140ab04b","","",false, this);
 
            ReportedBy = RPSControlFactory.CreateRPSTextBox<NCPendingActionView>("7647ffc8-7952-4663-bcee-c39ca21f0fb4","","",false, this);
 
            ActionNumber = RPSControlFactory.CreateRPSFormattedTextBox<NCPendingActionView>("c9ddc954-2644-4033-a909-e28b7ec2b70c","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<NCPendingActionView>("fe2bcdac-8a50-447d-b563-4e81c6777517","","",false, this);
 
            Type8D = RPSControlFactory.CreateRPSTextBox<NCPendingActionView>("4f302953-bbc0-4c6b-afc6-9c428bf89d7f","","",false, this);
 
            PlanedDate = RPSControlFactory.CreateRPSTextBox<NCPendingActionView>("a2a798e1-fc8d-471e-b7c4-9e2955de1739","","",true, this);
 
            RealDate = RPSControlFactory.CreateRPSTextBox<NCPendingActionView>("a75f914b-ddf4-4d99-938e-0146178408ca","","",false, this);
 
            EndDate = RPSControlFactory.CreateRPSTextBox<NCPendingActionView>("2322ba9d-1679-4072-8e93-b884f2e78d2c","","",false, this);
 
            Efficacy = RPSControlFactory.CreateRPSTextBox<NCPendingActionView>("8d1bca85-27af-4834-bba7-7ddce2277f35","","",false, this);
 
            Progress = RPSControlFactory.CreateRPSFormattedTextBox<NCPendingActionView>("925cdd49-0c61-42e6-b64b-576b9b3b903b","","",false, this);
 
            Verification = RPSControlFactory.CreateRPSTextBox<NCPendingActionView>("bf3ff98e-6d47-44a4-a794-7124d0583373","","",false, this);
 
            Comments = RPSControlFactory.CreateRPSTextBox<NCPendingActionView>("fa1d64ff-9065-4e0f-9091-b59edff3a218","","",false, this);
 
            ExecuteNCActionUpdateFromAgendaCommandButton = RPSControlFactory.CreateRPSButton<NCPendingActionView>( "2f3dfbe5-9071-470d-8236-5e04b87db4af","","",this);
 

        }
        public IRPSComboBox<NCPendingActionView> IDNonConformity { get; set; } 
        public IRPSTextBox<NCPendingActionView> ReportedBy { get; set; } 
        public IRPSTextBox<NCPendingActionView> ActionNumber { get; set; } 
        public IRPSTextBox<NCPendingActionView> Description { get; set; } 
        public IRPSTextBox<NCPendingActionView> Type8D { get; set; } 
        public IRPSTextBox<NCPendingActionView> PlanedDate { get; set; } 
        public IRPSTextBox<NCPendingActionView> RealDate { get; set; } 
        public IRPSTextBox<NCPendingActionView> EndDate { get; set; } 
        public IRPSTextBox<NCPendingActionView> Efficacy { get; set; } 
        public IRPSTextBox<NCPendingActionView> Progress { get; set; } 
        public IRPSTextBox<NCPendingActionView> Verification { get; set; } 
        public IRPSTextBox<NCPendingActionView> Comments { get; set; } 
        public IRPSButton<NCPendingActionView> ExecuteNCActionUpdateFromAgendaCommandButton { get; set; } 
        public Agenda Screen { get; set; }
        public NCPendingActionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CRMActivitySLView : View
    {
        public CRMActivitySLView(Agenda screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CRMActivitySLView>( this);
 
            IDActivity = RPSControlFactory.CreateRPSComboBox<CRMActivitySLView>("1322760d-853a-4b50-b4d9-0c7ab393d8c1","","",false, this);
 
            IDActivityType = RPSControlFactory.CreateRPSComboBox<CRMActivitySLView>("8f484e60-1c27-4adb-8345-9f0ff55d7a28","","",false, this);
 
            IDOportunity = RPSControlFactory.CreateRPSComboBox<CRMActivitySLView>("87825d19-3123-426c-9aa2-e489091f3eda","","",false, this);
 
            Priority = RPSControlFactory.CreateRPSEnumComboBox<CRMActivitySLView>("627f33ea-03aa-4ab1-80f5-d587aa237363","","",true, this);
 
            CreationDate = RPSControlFactory.CreateRPSTextBox<CRMActivitySLView>("f0c01cf0-73bc-4edf-b08d-f809626996c5","","",true, this);
 
            DueDate = RPSControlFactory.CreateRPSTextBox<CRMActivitySLView>("81567e82-9623-4b03-b2d4-ae1db32ca07b","","",true, this);
 
            Status = RPSControlFactory.CreateRPSEnumComboBox<CRMActivitySLView>("e0c0988c-c3ba-43c9-872f-d10eaa8c920c","","",true, this);
 
            RealTime = RPSControlFactory.CreateRPSFormattedTextBox<CRMActivitySLView>("76136b12-c581-41b6-a781-9c5e7a1d2e27","","",true, this);
 
            Progress = RPSControlFactory.CreateRPSFormattedTextBox<CRMActivitySLView>("04026e30-3c89-4c89-92f6-218362d80f07","","",true, this);
 
            EndDate = RPSControlFactory.CreateRPSTextBox<CRMActivitySLView>("34566cd4-2cc0-4735-a589-94138e9582ed","","",false, this);
 
            EndTime = RPSControlFactory.CreateRPSTextBox<CRMActivitySLView>("f13ad121-efca-45d6-a4dd-b6373c3d1d0b","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<CRMActivitySLView>("7011d30c-259a-43a0-bfd0-540c457a16a2","","",false, this);
 
            Comment1 = RPSControlFactory.CreateRPSSection<CRMActivitySLView>( "","ul li[rpsid='4f37831b-ccb4-4208-9659-2d689113170a']","",this);
 
            Documents = RPSControlFactory.CreateRPSSection<CRMActivitySLView>( "","ul li[rpsid='ee7bba6a-f0f8-429b-aee5-f87cf5392232']","",this);
 

        }
        public IRPSSaveButton<CRMActivitySLView> SaveButton { get; set; } 
        public IRPSComboBox<CRMActivitySLView> IDActivity { get; set; } 
        public IRPSComboBox<CRMActivitySLView> IDActivityType { get; set; } 
        public IRPSComboBox<CRMActivitySLView> IDOportunity { get; set; } 
        public IRPSComboBox<CRMActivitySLView> Priority { get; set; } 
        public IRPSTextBox<CRMActivitySLView> CreationDate { get; set; } 
        public IRPSTextBox<CRMActivitySLView> DueDate { get; set; } 
        public IRPSComboBox<CRMActivitySLView> Status { get; set; } 
        public IRPSTextBox<CRMActivitySLView> RealTime { get; set; } 
        public IRPSTextBox<CRMActivitySLView> Progress { get; set; } 
        public IRPSTextBox<CRMActivitySLView> EndDate { get; set; } 
        public IRPSTextBox<CRMActivitySLView> EndTime { get; set; } 
        public IRPSTextBox<CRMActivitySLView> Comment { get; set; } 
        public IRPSSection<CRMActivitySLView> Comment1 { get; set; } 
        public IRPSSection<CRMActivitySLView> Documents { get; set; } 
        public Agenda Screen { get; set; }
        public CRMActivitySLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class BPMTaskActivityView : View
    {
        public BPMTaskActivityView(Agenda screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ProcessId = RPSControlFactory.CreateRPSComboBox<BPMTaskActivityView>("dbfccf3d-3658-4e59-ab0d-6e36d045419c","","",false, this);
 
            IDTaskLookUp = RPSControlFactory.CreateRPSComboBox<BPMTaskActivityView>("a4953e19-14fb-4cb1-9849-d1f90dcacc15","","",false, this);
 
            UserAssigned = RPSControlFactory.CreateRPSComboBox<BPMTaskActivityView>("d102c1b9-88ff-41da-85c3-6d12b1b9e323","","",false, this);
 
            TaskType = RPSControlFactory.CreateRPSTextBox<BPMTaskActivityView>("b5dbf3db-3a01-40da-8389-f998ec899996","","",false, this);
 
            TaskState = RPSControlFactory.CreateRPSTextBox<BPMTaskActivityView>("29f0db8e-db45-4ff8-b036-0933ddb5a32c","","",false, this);
 
            CreationDate = RPSControlFactory.CreateRPSTextBox<BPMTaskActivityView>("ae24e905-d5a1-4988-83f9-69ff88893273","","",false, this);
 
            DueDate = RPSControlFactory.CreateRPSTextBox<BPMTaskActivityView>("ba7abf34-ef45-4a76-aaa9-7533222c871e","","",false, this);
 
            EndDate = RPSControlFactory.CreateRPSTextBox<BPMTaskActivityView>("12f93b2d-dc8c-4d6b-9235-8340ebac50e0","","",false, this);
 
            DetailedDescription = RPSControlFactory.CreateRPSTextBox<BPMTaskActivityView>("3dbfa369-c569-4d54-acae-b4f44d759759","","",false, this);
 
            RunBPMTaskCommandButton = RPSControlFactory.CreateRPSButton<BPMTaskActivityView>( "53f7ae4d-b653-4fba-aee9-ed7b96e51a61","","",this);
 
            ExecuteReleaseTaskButton = RPSControlFactory.CreateRPSButton<BPMTaskActivityView>( "188e40a6-67dd-45a2-8da9-a924502678bc","","",this);
 
            ExecuteAssignTaskButton = RPSControlFactory.CreateRPSButton<BPMTaskActivityView>( "c6a80d32-b1a6-4b4b-a375-4cd9d752388f","","",this);
 

        }
        public IRPSComboBox<BPMTaskActivityView> ProcessId { get; set; } 
        public IRPSComboBox<BPMTaskActivityView> IDTaskLookUp { get; set; } 
        public IRPSComboBox<BPMTaskActivityView> UserAssigned { get; set; } 
        public IRPSTextBox<BPMTaskActivityView> TaskType { get; set; } 
        public IRPSTextBox<BPMTaskActivityView> TaskState { get; set; } 
        public IRPSTextBox<BPMTaskActivityView> CreationDate { get; set; } 
        public IRPSTextBox<BPMTaskActivityView> DueDate { get; set; } 
        public IRPSTextBox<BPMTaskActivityView> EndDate { get; set; } 
        public IRPSTextBox<BPMTaskActivityView> DetailedDescription { get; set; } 
        public IRPSButton<BPMTaskActivityView> RunBPMTaskCommandButton { get; set; } 
        public IRPSButton<BPMTaskActivityView> ExecuteReleaseTaskButton { get; set; } 
        public IRPSButton<BPMTaskActivityView> ExecuteAssignTaskButton { get; set; } 
        public Agenda Screen { get; set; }
        public BPMTaskActivityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ProjectWarningView : View
    {
        public ProjectWarningView(Agenda screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ProjectWarningView>( this);
 
            CodWarning = RPSControlFactory.CreateRPSTextBox<ProjectWarningView>("4cd2bcd0-ff65-4f7c-a02f-2623daa5c6b6","","",true, this);
 
            IDPROSituationWarning = RPSControlFactory.CreateRPSComboBox<ProjectWarningView>("973fa5ab-98c1-4b98-8d91-ad074f657a30","","",true, this);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<ProjectWarningView>("75dd3305-892f-4cb1-a3b2-12e827271355","","",true, this);
 
            IDPROTask = RPSControlFactory.CreateRPSComboBox<ProjectWarningView>("ae168e2d-5e07-49c5-a571-e2fcf6dd3836","","",true, this);
 
            IDPROWarningType = RPSControlFactory.CreateRPSComboBox<ProjectWarningView>("fb854785-4bbe-42b5-8f54-8d33485309af","","",true, this);
 
            IDPROWarningPriority = RPSControlFactory.CreateRPSComboBox<ProjectWarningView>("315359ce-aea8-4bfe-a1b8-aa41fc02a630","","",true, this);
 
            IDPROWarningSeverity = RPSControlFactory.CreateRPSComboBox<ProjectWarningView>("8b1d05cc-d9b5-436b-ab42-a114ead3a3c2","","",true, this);
 
            IDEmployeeReportedBy = RPSControlFactory.CreateRPSComboBox<ProjectWarningView>("b5c0a4cc-7c26-4d7e-802c-7a5f05e05d83","","",true, this);
 
            IDEmployeeAssignedTo = RPSControlFactory.CreateRPSComboBox<ProjectWarningView>("6408b366-f20e-4e61-bfdd-81c3b310cfec","","",false, this);
 
            IDEmployeeManager = RPSControlFactory.CreateRPSComboBox<ProjectWarningView>("a0b3d163-e257-40e5-91c3-ad8b5c3f7312","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ProjectWarningView>("e20d9385-4cb7-48b4-b4b5-a786768ac750","","",false, this);
 

        }
        public IRPSSaveButton<ProjectWarningView> SaveButton { get; set; } 
        public IRPSTextBox<ProjectWarningView> CodWarning { get; set; } 
        public IRPSComboBox<ProjectWarningView> IDPROSituationWarning { get; set; } 
        public IRPSComboBox<ProjectWarningView> IDProject { get; set; } 
        public IRPSComboBox<ProjectWarningView> IDPROTask { get; set; } 
        public IRPSComboBox<ProjectWarningView> IDPROWarningType { get; set; } 
        public IRPSComboBox<ProjectWarningView> IDPROWarningPriority { get; set; } 
        public IRPSComboBox<ProjectWarningView> IDPROWarningSeverity { get; set; } 
        public IRPSComboBox<ProjectWarningView> IDEmployeeReportedBy { get; set; } 
        public IRPSComboBox<ProjectWarningView> IDEmployeeAssignedTo { get; set; } 
        public IRPSComboBox<ProjectWarningView> IDEmployeeManager { get; set; } 
        public IRPSTextBox<ProjectWarningView> Description { get; set; } 
        public Agenda Screen { get; set; }
        public ProjectWarningView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}