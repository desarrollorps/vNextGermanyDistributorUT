    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.Agenda
{
    //RPS VERSION 1.0.0.0
    public partial class Agenda:Screen
    {
        public Agenda():base()
        {
            this.URL = "manufacturing.agenda";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            AgendaView  = new AgendaView(this); 
            EditAppointmentsView  = new EditAppointmentsView(this); 
            NewAppointmentView  = new NewAppointmentView(this); 
            MOTaskPendingDialogView  = new MOTaskPendingDialogView(this); 
            AgendaView.InitializeControls(); 
            EditAppointmentsView.InitializeControls(); 
            NewAppointmentView.InitializeControls(); 
            MOTaskPendingDialogView.InitializeControls(); 
           
        }
      
            public AgendaView AgendaView {get; set; } 
            public EditAppointmentsView EditAppointmentsView {get; set; } 
            public NewAppointmentView NewAppointmentView {get; set; } 
            public MOTaskPendingDialogView MOTaskPendingDialogView {get; set; } 
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
            UIStartLoadDate = RPSControlFactory.CreateRPSTextBox<AgendaView>("b0a26ff7-2f6f-4e9c-860e-801b75508c6d","","",true, this);
 
            UIIDSite = RPSControlFactory.CreateRPSComboBox<AgendaView>("f219f560-73ea-4932-99cd-be54b0afce05","","",false, this);
 
            UIEmployee = RPSControlFactory.CreateRPSComboBox<AgendaView>("97652812-8633-4b91-b468-7abb4548b37c","","",false, this);
 
            UIeTypeEmployee = RPSControlFactory.CreateRPSEnumComboBox<AgendaView>("3287ccee-74ec-461f-8fee-c5e25af5072e","","",false, this);
 
            UIIDDepartment = RPSControlFactory.CreateRPSComboBox<AgendaView>("0f1518a0-fa10-4e62-9945-216762913d7a","","",false, this);
 
            UIIDCategory = RPSControlFactory.CreateRPSComboBox<AgendaView>("3ee036e1-49fa-4724-a99c-7dbe88ca253e","","",false, this);
 
            UIIDQualify = RPSControlFactory.CreateRPSComboBox<AgendaView>("4c590b4e-fae1-4325-bf29-204f2827f299","","",false, this);
 
            ExecuteEmployeesAllowedForTaskManager = RPSControlFactory.CreateRPSButton<AgendaView>( "f4d1d813-1cdf-4a6d-9d85-909c68ba2d46","","",this);
 
            MOTaskPendingNavigationCommand = RPSControlFactory.CreateRPSButtonToView<AgendaView,MOTaskPendingDialogView>("64db886d-eb41-4aef-874f-a8e7db773ab5","","", this,Screen.MOTaskPendingDialogView);
 

        }
        public IRPSTextBox<AgendaView> UIStartLoadDate { get; set; } 
        public IRPSComboBox<AgendaView> UIIDSite { get; set; } 
        public IRPSComboBox<AgendaView> UIEmployee { get; set; } 
        public IRPSComboBox<AgendaView> UIeTypeEmployee { get; set; } 
        public IRPSComboBox<AgendaView> UIIDDepartment { get; set; } 
        public IRPSComboBox<AgendaView> UIIDCategory { get; set; } 
        public IRPSComboBox<AgendaView> UIIDQualify { get; set; } 
        public IRPSButton<AgendaView> ExecuteEmployeesAllowedForTaskManager { get; set; } 
        public IRPSButton<AgendaView,MOTaskPendingDialogView> MOTaskPendingNavigationCommand { get; set; } 
        public Agenda Screen { get; set; }
        public AgendaView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class EditAppointmentsView : View
    {
        public EditAppointmentsView(Agenda screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<EditAppointmentsView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<EditAppointmentsView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<EditAppointmentsView,AgendaView>( this,Screen.AgendaView);
 
            BackButton = RPSControlFactory.RPSBackButton<EditAppointmentsView,AgendaView>( this,Screen.AgendaView);
 
            IDManufacturingOrder = RPSControlFactory.CreateRPSComboBox<EditAppointmentsView>("031e234d-5391-4202-94cc-897aa6e8e5d5","","",false, this);
 
            IDMOTask = RPSControlFactory.CreateRPSComboBox<EditAppointmentsView>("522e7203-d1d2-4f76-831d-10bcc5d087cb","","",false, this);
 
            AppointmentNotes = RPSControlFactory.CreateRPSTextBox<EditAppointmentsView>("9e462c4b-0900-4059-b70f-6ae65ebf3b3f","","",false, this);
 
            IDStopType = RPSControlFactory.CreateRPSComboBox<EditAppointmentsView>("4af8da22-0e9c-4118-816b-43802454868e","","",false, this);
 
            IDMaintenanceOrder = RPSControlFactory.CreateRPSComboBox<EditAppointmentsView>("ea542edb-2ebc-44d8-974b-87cf9cbba46f","","",false, this);
 
            AppointmentNotes1 = RPSControlFactory.CreateRPSTextBox<EditAppointmentsView>("06ce3751-9440-434a-ac33-b59dbd36c2e6","","",false, this);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<EditAppointmentsView>("e64050ea-ea51-45c2-b7fe-7da8bd6eebb7","","",false, this);
 
            IDProjectTask = RPSControlFactory.CreateRPSComboBox<EditAppointmentsView>("1597af06-cfd7-404f-8b15-5af4d277a212","","",false, this);
 
            AppointmentNotes2 = RPSControlFactory.CreateRPSTextBox<EditAppointmentsView>("3f2f040d-5b47-413e-9a2e-755192d3a874","","",false, this);
 
            AppointmentDateStart = RPSControlFactory.CreateRPSTextBox<EditAppointmentsView>("bb498321-119d-42dd-860d-947e63f8b605","","",true, this);
 
            UIStartHourTime = RPSControlFactory.CreateRPSTextBox<EditAppointmentsView>("b7109725-1291-487d-8796-1e15b0854402","","",false, this);
 
            UIEndHourTime = RPSControlFactory.CreateRPSTextBox<EditAppointmentsView>("6526cf01-73fb-41e4-b633-eb25c76c1982","","",false, this);
 
            UIIsAllDay = RPSControlFactory.CreateRPSCheckBox<EditAppointmentsView>("d6cf1fdf-2961-4104-a9d8-40608e699292","","",false, this);
 

        }
        public IRPSSaveButton<EditAppointmentsView> SaveButton { get; set; } 
        public IRPSButton<EditAppointmentsView> DeleteButton { get; set; } 
        public IRPSButton<EditAppointmentsView,AgendaView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<EditAppointmentsView,AgendaView> BackButton { get; set; } 
        public IRPSComboBox<EditAppointmentsView> IDManufacturingOrder { get; set; } 
        public IRPSComboBox<EditAppointmentsView> IDMOTask { get; set; } 
        public IRPSTextBox<EditAppointmentsView> AppointmentNotes { get; set; } 
        public IRPSComboBox<EditAppointmentsView> IDStopType { get; set; } 
        public IRPSComboBox<EditAppointmentsView> IDMaintenanceOrder { get; set; } 
        public IRPSTextBox<EditAppointmentsView> AppointmentNotes1 { get; set; } 
        public IRPSComboBox<EditAppointmentsView> IDProject { get; set; } 
        public IRPSComboBox<EditAppointmentsView> IDProjectTask { get; set; } 
        public IRPSTextBox<EditAppointmentsView> AppointmentNotes2 { get; set; } 
        public IRPSTextBox<EditAppointmentsView> AppointmentDateStart { get; set; } 
        public IRPSTextBox<EditAppointmentsView> UIStartHourTime { get; set; } 
        public IRPSTextBox<EditAppointmentsView> UIEndHourTime { get; set; } 
        public IRPSCheckbox<EditAppointmentsView> UIIsAllDay { get; set; } 
        public Agenda Screen { get; set; }
        public EditAppointmentsView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NewAppointmentView : View
    {
        public NewAppointmentView(Agenda screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ManufacturingOrder = RPSControlFactory.CreateRPSOption<NewAppointmentView>( "5438b46e-ff24-4be5-a4c5-2a3ffe3c27f9","","",this);
 
            StopResource = RPSControlFactory.CreateRPSOption<NewAppointmentView>( "ff63c55e-e7e7-4317-b5b5-52cebed85391","","",this);
 
            IDManufacturingOrder = RPSControlFactory.CreateRPSComboBox<NewAppointmentView>("5b4a36bf-ab71-4d93-b04f-4c36b8bc9faa","","",false, this);
 
            IDMOTask = RPSControlFactory.CreateRPSComboBox<NewAppointmentView>("6871a554-4c37-4e57-9737-ac9816cebf60","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<NewAppointmentView>("142c93a3-d4af-4a02-ac8a-4a118f9e8490","","",false, this);
 
            IDStopType = RPSControlFactory.CreateRPSComboBox<NewAppointmentView>("cfed6be5-24cb-4837-a659-b1972cd783eb","","",false, this);
 
            Unique = RPSControlFactory.CreateRPSOption<NewAppointmentView>( "765e02e2-d080-4ba0-91b4-31c88391882a","","",this);
 
            AllDays = RPSControlFactory.CreateRPSOption<NewAppointmentView>( "53ceaff4-f972-4ef5-ad3d-eee43019491b","","",this);
 
            Week = RPSControlFactory.CreateRPSOption<NewAppointmentView>( "25a89969-2daa-43ac-b4f8-7483ab825da2","","",this);
 
            UIMonday = RPSControlFactory.CreateRPSCheckBox<NewAppointmentView>("eae53b10-6170-4476-91c2-e50c097345e9","","",false, this);
 
            UITuesday = RPSControlFactory.CreateRPSCheckBox<NewAppointmentView>("2580e343-9786-4e9a-8c3b-0ace485eee61","","",false, this);
 
            UIWednesday = RPSControlFactory.CreateRPSCheckBox<NewAppointmentView>("250918f0-fdd4-42e7-9c41-cca29930f303","","",false, this);
 
            UIThursday = RPSControlFactory.CreateRPSCheckBox<NewAppointmentView>("08aaf4f2-4e80-4f11-93dc-0337252b67e7","","",false, this);
 
            UIFriday = RPSControlFactory.CreateRPSCheckBox<NewAppointmentView>("7e4f1b14-9f7a-43c8-8099-92755f8cff1d","","",false, this);
 
            UISaturday = RPSControlFactory.CreateRPSCheckBox<NewAppointmentView>("1816fcb4-e8ef-4dc4-9245-6170630d2622","","",false, this);
 
            UISunday = RPSControlFactory.CreateRPSCheckBox<NewAppointmentView>("3c89c60d-a59d-4ebf-8db0-95df549bf0d3","","",false, this);
 
            Each = RPSControlFactory.CreateRPSOption<NewAppointmentView>( "a4ec575f-ed45-4c08-966a-bed473d5de0a","","",this);
 
            UIPeriodicityDays = RPSControlFactory.CreateRPSFormattedTextBox<NewAppointmentView>("8ff8f0b5-db58-4bc6-9bd3-440e5bfd0c0c","","",false, this);
 
            AppointmentDateStart = RPSControlFactory.CreateRPSTextBox<NewAppointmentView>("10d87034-eabe-4c9d-a622-200b03d14981","","",true, this);
 
            AppointmentDateEnd = RPSControlFactory.CreateRPSTextBox<NewAppointmentView>("8c88df61-626e-4908-8f96-753d8a5acc11","","",true, this);
 
            UIStartHourTime = RPSControlFactory.CreateRPSTextBox<NewAppointmentView>("3c211b68-0ed6-4242-96c7-408fb5d9a932","","",true, this);
 
            UIEndHourTime = RPSControlFactory.CreateRPSTextBox<NewAppointmentView>("9ba6076d-bad2-44fc-b7ab-470b85366453","","",true, this);
 
            UIIsAllDay = RPSControlFactory.CreateRPSCheckBox<NewAppointmentView>("a5c52957-3ceb-4ae5-9090-69105c393a95","","",false, this);
 

        }
        public IRPSOption<NewAppointmentView> ManufacturingOrder { get; set; } 
        public IRPSOption<NewAppointmentView> StopResource { get; set; } 
        public IRPSComboBox<NewAppointmentView> IDManufacturingOrder { get; set; } 
        public IRPSComboBox<NewAppointmentView> IDMOTask { get; set; } 
        public IRPSTextBox<NewAppointmentView> Comment { get; set; } 
        public IRPSComboBox<NewAppointmentView> IDStopType { get; set; } 
        public IRPSOption<NewAppointmentView> Unique { get; set; } 
        public IRPSOption<NewAppointmentView> AllDays { get; set; } 
        public IRPSOption<NewAppointmentView> Week { get; set; } 
        public IRPSCheckbox<NewAppointmentView> UIMonday { get; set; } 
        public IRPSCheckbox<NewAppointmentView> UITuesday { get; set; } 
        public IRPSCheckbox<NewAppointmentView> UIWednesday { get; set; } 
        public IRPSCheckbox<NewAppointmentView> UIThursday { get; set; } 
        public IRPSCheckbox<NewAppointmentView> UIFriday { get; set; } 
        public IRPSCheckbox<NewAppointmentView> UISaturday { get; set; } 
        public IRPSCheckbox<NewAppointmentView> UISunday { get; set; } 
        public IRPSOption<NewAppointmentView> Each { get; set; } 
        public IRPSTextBox<NewAppointmentView> UIPeriodicityDays { get; set; } 
        public IRPSTextBox<NewAppointmentView> AppointmentDateStart { get; set; } 
        public IRPSTextBox<NewAppointmentView> AppointmentDateEnd { get; set; } 
        public IRPSTextBox<NewAppointmentView> UIStartHourTime { get; set; } 
        public IRPSTextBox<NewAppointmentView> UIEndHourTime { get; set; } 
        public IRPSCheckbox<NewAppointmentView> UIIsAllDay { get; set; } 
        public Agenda Screen { get; set; }
        public NewAppointmentView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MOTaskPendingDialogView : View
    {
        public MOTaskPendingDialogView(Agenda screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_PendingMOTasksForAppointments = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="52953712-f067-4fd3-a9fa-16b6d13c8d52",CSSSelectorGrid="",XPathGrid=""};
            PendingMOTasksForAppointments = RPSControlFactory.RPSCreateCollectionWithGrid<PendingMOTasksForAppointmentsCollectionEditor<MOTaskPendingDialogView>,MOTaskPendingDialogView>( params_PendingMOTasksForAppointments,this);
 

        }
        public PendingMOTasksForAppointmentsCollectionEditor<MOTaskPendingDialogView> PendingMOTasksForAppointments { get; set; } 
        public Agenda Screen { get; set; }
        public MOTaskPendingDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class PendingMOTasksForAppointmentsCollectionEditor<MOTaskPendingDialogView>:RPSCollectionEditor<MOTaskPendingDialogView> where MOTaskPendingDialogView : class, IView
    {
        public  PendingMOTasksForAppointmentsGridView<MOTaskPendingDialogView> GridView {get;set;}
    }
    public partial class PendingMOTasksForAppointmentsGridView <MOTaskPendingDialogView> :  RPSGridView<MOTaskPendingDialogView> where MOTaskPendingDialogView : class, IView
    {
        public PendingMOTasksForAppointmentsGridView(MOTaskPendingDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MOTask_PlannedStartDate = RPSControlFactory.CreateRPSGridTextBox<MOTaskPendingDialogView>("","#52953712-f067-4fd3-a9fa-16b6d13c8d52 .ag-row[role='row']@ROWINDEX [col-id='cMOTask_PlannedStartDate']","",false, this.CurrentView);
 
            MOTask_PlannedEndDate = RPSControlFactory.CreateRPSGridTextBox<MOTaskPendingDialogView>("","#52953712-f067-4fd3-a9fa-16b6d13c8d52 .ag-row[role='row']@ROWINDEX [col-id='cMOTask_PlannedEndDate']","",false, this.CurrentView);
 
            MOTask_Notes = RPSControlFactory.CreateRPSGridMemoTextBox<MOTaskPendingDialogView>("","#52953712-f067-4fd3-a9fa-16b6d13c8d52 .ag-row[role='row']@ROWINDEX [col-id='cMOTask_Notes']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MOTaskPendingDialogView> MOTask_PlannedStartDate { get; set; } 
        public IRPSGridTextBox<MOTaskPendingDialogView> MOTask_PlannedEndDate { get; set; } 
        public IRPSGridTextBox<MOTaskPendingDialogView> MOTask_Notes { get; set; } 
                     
    }
 
    }
  
    

}