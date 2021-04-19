    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.Calendar
{
    //RPS VERSION 1.0.0.0
    public partial class Calendar:Screen
    {
        public Calendar():base()
        {
            this.URL = "general.calendar";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CalendarVMTreeView  = new CalendarVMTreeView(this); 
            CalendarVMEntityView  = new CalendarVMEntityView(this); 
            CalendarDetailView  = new CalendarDetailView(this); 
            NewHourIntervalDialogView  = new NewHourIntervalDialogView(this); 
            NewDateDialogView  = new NewDateDialogView(this); 
            CopyCalendarWizardDialogView  = new CopyCalendarWizardDialogView(this); 
            CalendarDetailsOfHigherCalendarsChildDialogView  = new CalendarDetailsOfHigherCalendarsChildDialogView(this); 
            CalendarTotalHoursDialogView  = new CalendarTotalHoursDialogView(this); 
            CalendarVMTreeView.InitializeControls(); 
            CalendarVMEntityView.InitializeControls(); 
            CalendarDetailView.InitializeControls(); 
            NewHourIntervalDialogView.InitializeControls(); 
            NewDateDialogView.InitializeControls(); 
            CopyCalendarWizardDialogView.InitializeControls(); 
            CalendarDetailsOfHigherCalendarsChildDialogView.InitializeControls(); 
            CalendarTotalHoursDialogView.InitializeControls(); 
           
        }
      
            public CalendarVMTreeView CalendarVMTreeView {get; set; } 
            public CalendarVMEntityView CalendarVMEntityView {get; set; } 
            public CalendarDetailView CalendarDetailView {get; set; } 
            public NewHourIntervalDialogView NewHourIntervalDialogView {get; set; } 
            public NewDateDialogView NewDateDialogView {get; set; } 
            public CopyCalendarWizardDialogView CopyCalendarWizardDialogView {get; set; } 
            public CalendarDetailsOfHigherCalendarsChildDialogView CalendarDetailsOfHigherCalendarsChildDialogView {get; set; } 
            public CalendarTotalHoursDialogView CalendarTotalHoursDialogView {get; set; } 
    }
            
    public partial class CalendarVMTreeView : View
    {
        public CalendarVMTreeView(Calendar screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CopyCalendarWyzardNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<CalendarVMTreeView,CopyCalendarWizardDialogView>("6f60d2d9-2363-4bfb-b665-9ffaa3d5270d","","", this,Screen.CopyCalendarWizardDialogView);
 

        }
        public IRPSButton<CalendarVMTreeView,CopyCalendarWizardDialogView> CopyCalendarWyzardNavigationCommandButton { get; set; } 
        public Calendar Screen { get; set; }
        public CalendarVMTreeView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CalendarVMEntityView : View
    {
        public CalendarVMEntityView(Calendar screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CalendarVMEntityView>( this);
 
            CodCalendar = RPSControlFactory.CreateRPSTextBox<CalendarVMEntityView>("fa23ae30-b3e3-4242-831a-9005d44234e0","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CalendarVMEntityView>("624d80f7-c44b-4327-8902-c7661fa9195d","","",false, this);
 
            CalendarDetailsOfHigherCalendarsChildNavigationCommand = RPSControlFactory.CreateRPSButtonToView<CalendarVMEntityView,CalendarDetailsOfHigherCalendarsChildDialogView>("546467e0-846f-4683-87ab-11c3a6530182","","", this,Screen.CalendarDetailsOfHigherCalendarsChildDialogView);
 
            CalendariosSuperiores = RPSControlFactory.CreateRPSCheckBox<CalendarVMEntityView>("3a9eb7b8-87ac-420a-b360-2101fedeef60","","",false, this);
 
            CalendarTotalHoursNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<CalendarVMEntityView,CalendarTotalHoursDialogView>("c1810487-577b-4ac9-a89d-4de41fc6a641","","", this,Screen.CalendarTotalHoursDialogView);
 
            CollectionInit params_GENCalendarDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0dddfb49-3ab5-425c-8328-7cd5264582af",CSSSelectorGrid="",XPathGrid=""};
            GENCalendarDetails = RPSControlFactory.RPSCreateCollectionWithGrid<GENCalendarDetailsCollectionEditor<CalendarVMEntityView,CalendarDetailView>,CalendarVMEntityView,CalendarDetailView>( params_GENCalendarDetails,this,Screen.CalendarDetailView);
 
            Section = RPSControlFactory.CreateRPSSection<CalendarVMEntityView>( "","ul li[rpsid='51ba4dc4-da7e-4942-896e-3f714cf5e5ea']","",this);
 
            Edition = RPSControlFactory.CreateRPSSection<CalendarVMEntityView>( "","ul li[rpsid='4b2071d1-c770-4d6d-be7e-d90fb99bd2f1']","",this);
 

        }
        public IRPSSaveButton<CalendarVMEntityView> SaveButton { get; set; } 
        public IRPSTextBox<CalendarVMEntityView> CodCalendar { get; set; } 
        public IRPSTextBox<CalendarVMEntityView> Description { get; set; } 
        public IRPSButton<CalendarVMEntityView,CalendarDetailsOfHigherCalendarsChildDialogView> CalendarDetailsOfHigherCalendarsChildNavigationCommand { get; set; } 
        public IRPSCheckbox<CalendarVMEntityView> CalendariosSuperiores { get; set; } 
        public IRPSButton<CalendarVMEntityView,CalendarTotalHoursDialogView> CalendarTotalHoursNavigationCommandButton { get; set; } 
        public GENCalendarDetailsCollectionEditor<CalendarVMEntityView,CalendarDetailView> GENCalendarDetails { get; set; } 
        public IRPSSection<CalendarVMEntityView> Section { get; set; } 
        public IRPSSection<CalendarVMEntityView> Edition { get; set; } 
        public Calendar Screen { get; set; }
        public CalendarVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GENCalendarDetailsCollectionEditor<CalendarVMEntityView,CalendarDetailView>:RPSCollectionEditor<CalendarVMEntityView,CalendarDetailView> where CalendarVMEntityView : class, IView where CalendarDetailView : class, IView
    {
        public  GENCalendarDetailsGridView<CalendarVMEntityView,CalendarDetailView> GridView {get;set;}
    }
    public partial class GENCalendarDetailsGridView <CalendarVMEntityView,CalendarDetailView> :  RPSGridView<CalendarVMEntityView,CalendarDetailView> where CalendarVMEntityView : class, IView where CalendarDetailView : class, IView
    {
        public GENCalendarDetailsGridView(CalendarVMEntityView currentView,CalendarDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Description = RPSControlFactory.CreateRPSGridTextBox<CalendarVMEntityView>("","#0dddfb49-3ab5-425c-8328-7cd5264582af .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<CalendarVMEntityView>("","#0dddfb49-3ab5-425c-8328-7cd5264582af .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",true, this.CurrentView);
 
            DateTo = RPSControlFactory.CreateRPSGridTextBox<CalendarVMEntityView>("","#0dddfb49-3ab5-425c-8328-7cd5264582af .ag-row[role='row']@ROWINDEX [col-id='cDateTo']","",false, this.CurrentView);
 
            Priority = RPSControlFactory.CreateRPSGridFormattedTextBox<CalendarVMEntityView>("","#0dddfb49-3ab5-425c-8328-7cd5264582af .ag-row[role='row']@ROWINDEX [col-id='cPriority']","",true, this.CurrentView);
 
            IDCalendarDetailType = RPSControlFactory.CreateRPSGridComboBox<CalendarVMEntityView>("","#0dddfb49-3ab5-425c-8328-7cd5264582af .ag-row[role='row']@ROWINDEX [col-id='cIDCalendarDetailType']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CalendarVMEntityView> Description { get; set; } 
        public IRPSGridTextBox<CalendarVMEntityView> DateFrom { get; set; } 
        public IRPSGridTextBox<CalendarVMEntityView> DateTo { get; set; } 
        public IRPSGridTextBox<CalendarVMEntityView> Priority { get; set; } 
        public IRPSGridComboBox<CalendarVMEntityView> IDCalendarDetailType { get; set; } 
                     
    }
 
    }
  
            
    public partial class CalendarDetailView : View
    {
        public CalendarDetailView(Calendar screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CalendarDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CalendarDetailView,CalendarVMEntityView>( this,Screen.CalendarVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<CalendarDetailView,CalendarVMEntityView>( this,Screen.CalendarVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CalendarDetailView,CalendarVMEntityView>( this,Screen.CalendarVMEntityView);
 
            Description = RPSControlFactory.CreateRPSTextBox<CalendarDetailView>("4fc26d32-eaea-45dc-96d2-2aae03ef2809","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<CalendarDetailView>("a3b615fd-aa7e-4afc-bc09-6bb072b2bcc5","","",true, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<CalendarDetailView>("380ba6fc-d671-45b7-8a33-9b906120f458","","",false, this);
 
            Priority = RPSControlFactory.CreateRPSFormattedTextBox<CalendarDetailView>("bfd05252-879e-482f-a67d-0a3e8fd57a8d","","",true, this);
 
            IDCalendarDetailType = RPSControlFactory.CreateRPSComboBox<CalendarDetailView>("f8dc42ca-1ea8-4b02-a272-8100394647d6","","",false, this);
 
            AllDays = RPSControlFactory.CreateRPSOption<CalendarDetailView>( "c3a64084-edbe-493d-ae20-be0f4ca119ec","","",this);
 
            Week = RPSControlFactory.CreateRPSOption<CalendarDetailView>( "24f79f08-9ae1-4ced-a14f-62ac4f86f3e1","","",this);
 
            Monday = RPSControlFactory.CreateRPSCheckBox<CalendarDetailView>("fea7b223-2e62-4158-82f6-47e2f97108bb","","",false, this);
 
            Tuesday = RPSControlFactory.CreateRPSCheckBox<CalendarDetailView>("acba89f9-27b9-4ef0-a2cf-b395442066c6","","",false, this);
 
            Wednesday = RPSControlFactory.CreateRPSCheckBox<CalendarDetailView>("a18a02e9-63ff-48ef-b847-a04a792f3ec0","","",false, this);
 
            Thursday = RPSControlFactory.CreateRPSCheckBox<CalendarDetailView>("3ea3390d-00e9-412b-8672-0ac288b68376","","",false, this);
 
            Friday = RPSControlFactory.CreateRPSCheckBox<CalendarDetailView>("7d55dedc-c10a-43d2-adff-54a6db89ec37","","",false, this);
 
            Saturday = RPSControlFactory.CreateRPSCheckBox<CalendarDetailView>("b56b6718-bed4-42f8-a8a6-7cd9de1a913c","","",false, this);
 
            Sunday = RPSControlFactory.CreateRPSCheckBox<CalendarDetailView>("edd485f5-9044-4033-be63-ed6a675ee2a0","","",false, this);
 
            DateRange = RPSControlFactory.CreateRPSOption<CalendarDetailView>( "694e36b3-f0a7-46f2-bd15-816eaf34b379","","",this);
 
            UIDateFrom = RPSControlFactory.CreateRPSTextBox<CalendarDetailView>("44c5d349-a95e-4e1b-b537-6bff8b15205b","","",false, this);
 
            UIDateTo = RPSControlFactory.CreateRPSTextBox<CalendarDetailView>("a9c4549e-7777-43fc-b126-e602e5b3eae4","","",false, this);
 
            Dates = RPSControlFactory.CreateRPSOption<CalendarDetailView>( "a11f350c-49ed-4cfa-a879-545221f0a820","","",this);
 
            NewDateNavigationCommand = RPSControlFactory.CreateRPSButtonToView<CalendarDetailView,NewDateDialogView>("5ad1731d-b4c5-4946-a6ee-1f0d2adcb98f","","", this,Screen.NewDateDialogView);
 
            DayExpressionDates = RPSControlFactory.CreateRPSTextBox<CalendarDetailView>("6a77fdd3-bd03-4e07-8425-3ab0b39049c9","","",false, this);
 
            NewHourIntervalNavigationCommand = RPSControlFactory.CreateRPSButtonToView<CalendarDetailView,NewHourIntervalDialogView>("8b3f53eb-8009-4139-8e33-aada3cc79d75","","", this,Screen.NewHourIntervalDialogView);
 
            FreeDay = RPSControlFactory.CreateRPSCheckBox<CalendarDetailView>("25345b2b-b353-4c19-b6f4-668e44145b6b","","",false, this);
 
            CollectionInit params_GetHourIntervalsFromTimeExpresion = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3d63d595-b833-47ab-afcf-7f3762b82714",CSSSelectorGrid="",XPathGrid=""};
            GetHourIntervalsFromTimeExpresion = RPSControlFactory.RPSCreateCollectionWithGrid<GetHourIntervalsFromTimeExpresionCollectionEditor<CalendarDetailView,NewHourIntervalDialogView>,CalendarDetailView,NewHourIntervalDialogView>( params_GetHourIntervalsFromTimeExpresion,this,Screen.NewHourIntervalDialogView);
 

        }
        public IRPSButton<CalendarDetailView> DeleteButton { get; set; } 
        public IRPSButton<CalendarDetailView,CalendarVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CalendarDetailView,CalendarVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CalendarDetailView,CalendarVMEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<CalendarDetailView> Description { get; set; } 
        public IRPSTextBox<CalendarDetailView> DateFrom { get; set; } 
        public IRPSTextBox<CalendarDetailView> DateTo { get; set; } 
        public IRPSTextBox<CalendarDetailView> Priority { get; set; } 
        public IRPSComboBox<CalendarDetailView> IDCalendarDetailType { get; set; } 
        public IRPSOption<CalendarDetailView> AllDays { get; set; } 
        public IRPSOption<CalendarDetailView> Week { get; set; } 
        public IRPSCheckbox<CalendarDetailView> Monday { get; set; } 
        public IRPSCheckbox<CalendarDetailView> Tuesday { get; set; } 
        public IRPSCheckbox<CalendarDetailView> Wednesday { get; set; } 
        public IRPSCheckbox<CalendarDetailView> Thursday { get; set; } 
        public IRPSCheckbox<CalendarDetailView> Friday { get; set; } 
        public IRPSCheckbox<CalendarDetailView> Saturday { get; set; } 
        public IRPSCheckbox<CalendarDetailView> Sunday { get; set; } 
        public IRPSOption<CalendarDetailView> DateRange { get; set; } 
        public IRPSTextBox<CalendarDetailView> UIDateFrom { get; set; } 
        public IRPSTextBox<CalendarDetailView> UIDateTo { get; set; } 
        public IRPSOption<CalendarDetailView> Dates { get; set; } 
        public IRPSButton<CalendarDetailView,NewDateDialogView> NewDateNavigationCommand { get; set; } 
        public IRPSTextBox<CalendarDetailView> DayExpressionDates { get; set; } 
        public IRPSButton<CalendarDetailView,NewHourIntervalDialogView> NewHourIntervalNavigationCommand { get; set; } 
        public IRPSCheckbox<CalendarDetailView> FreeDay { get; set; } 
        public GetHourIntervalsFromTimeExpresionCollectionEditor<CalendarDetailView,NewHourIntervalDialogView> GetHourIntervalsFromTimeExpresion { get; set; } 
        public Calendar Screen { get; set; }
        public CalendarDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetHourIntervalsFromTimeExpresionCollectionEditor<CalendarDetailView,NewHourIntervalDialogView>:RPSCollectionEditor<CalendarDetailView,NewHourIntervalDialogView> where CalendarDetailView : class, IView where NewHourIntervalDialogView : class, IView
    {
        public  GetHourIntervalsFromTimeExpresionGridView<CalendarDetailView,NewHourIntervalDialogView> GridView {get;set;}
    }
    public partial class GetHourIntervalsFromTimeExpresionGridView <CalendarDetailView,NewHourIntervalDialogView> :  RPSGridView<CalendarDetailView,NewHourIntervalDialogView> where CalendarDetailView : class, IView where NewHourIntervalDialogView : class, IView
    {
        public GetHourIntervalsFromTimeExpresionGridView(CalendarDetailView currentView,NewHourIntervalDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeleteHourIntervalCommand = RPSControlFactory.CreateRPSGridButton<CalendarDetailView>( "","#3d63d595-b833-47ab-afcf-7f3762b82714 .ag-row[role='row']@ROWINDEX [col-id='cDeleteHourIntervalCommand']","",this.CurrentView);
 
            HourFrom = RPSControlFactory.CreateRPSGridTextBox<CalendarDetailView>("","#3d63d595-b833-47ab-afcf-7f3762b82714 .ag-row[role='row']@ROWINDEX [col-id='cHourFrom']","",false, this.CurrentView);
 
            HourTo = RPSControlFactory.CreateRPSGridTextBox<CalendarDetailView>("","#3d63d595-b833-47ab-afcf-7f3762b82714 .ag-row[role='row']@ROWINDEX [col-id='cHourTo']","",false, this.CurrentView);
 

        }
        public IRPSGridButton<CalendarDetailView> DeleteHourIntervalCommand { get; set; } 
        public IRPSGridTextBox<CalendarDetailView> HourFrom { get; set; } 
        public IRPSGridTextBox<CalendarDetailView> HourTo { get; set; } 
                     
    }
 
    }
  
            
    public partial class NewHourIntervalDialogView : View
    {
        public NewHourIntervalDialogView(Calendar screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIDateFrom = RPSControlFactory.CreateRPSTextBox<NewHourIntervalDialogView>("d9347043-1649-4357-ab89-138e6b483117","","",false, this);
 
            UIDateTo = RPSControlFactory.CreateRPSTextBox<NewHourIntervalDialogView>("0085c4be-2480-4f01-8aa1-a65cc436298c","","",false, this);
 

        }
        public IRPSTextBox<NewHourIntervalDialogView> UIDateFrom { get; set; } 
        public IRPSTextBox<NewHourIntervalDialogView> UIDateTo { get; set; } 
        public Calendar Screen { get; set; }
        public NewHourIntervalDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NewDateDialogView : View
    {
        public NewDateDialogView(Calendar screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewDate = RPSControlFactory.CreateRPSTextBox<NewDateDialogView>("094aba8a-93af-4c39-bf3e-56f44fbbeb8c","","",false, this);
 
            AddNewDate = RPSControlFactory.CreateRPSButton<NewDateDialogView>( "f577fe20-cdb4-4e6f-907d-98aefdd3656e","","",this);
 
            CollectionInit params_GetDatesFromDateExpresion = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8d3ae888-2917-4a17-937f-af0a84878f39",CSSSelectorGrid="",XPathGrid=""};
            GetDatesFromDateExpresion = RPSControlFactory.RPSCreateCollectionWithGrid<GetDatesFromDateExpresionCollectionEditor<NewDateDialogView>,NewDateDialogView>( params_GetDatesFromDateExpresion,this);
 

        }
        public IRPSTextBox<NewDateDialogView> NewDate { get; set; } 
        public IRPSButton<NewDateDialogView> AddNewDate { get; set; } 
        public GetDatesFromDateExpresionCollectionEditor<NewDateDialogView> GetDatesFromDateExpresion { get; set; } 
        public Calendar Screen { get; set; }
        public NewDateDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetDatesFromDateExpresionCollectionEditor<NewDateDialogView>:RPSCollectionEditor<NewDateDialogView> where NewDateDialogView : class, IView
    {
        public  GetDatesFromDateExpresionGridView<NewDateDialogView> GridView {get;set;}
    }
    public partial class GetDatesFromDateExpresionGridView <NewDateDialogView> :  RPSGridView<NewDateDialogView> where NewDateDialogView : class, IView
    {
        public GetDatesFromDateExpresionGridView(NewDateDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeleteDateCommand = RPSControlFactory.CreateRPSGridButton<NewDateDialogView>( "","#8d3ae888-2917-4a17-937f-af0a84878f39 .ag-row[role='row']@ROWINDEX [col-id='cDeleteDateCommand']","",this.CurrentView);
 
            Date = RPSControlFactory.CreateRPSGridTextBox<NewDateDialogView>("","#8d3ae888-2917-4a17-937f-af0a84878f39 .ag-row[role='row']@ROWINDEX [col-id='cDate']","",false, this.CurrentView);
 

        }
        public IRPSGridButton<NewDateDialogView> DeleteDateCommand { get; set; } 
        public IRPSGridTextBox<NewDateDialogView> Date { get; set; } 
                     
    }
 
    }
  
            
    public partial class CopyCalendarWizardDialogView : View
    {
        public CopyCalendarWizardDialogView(Calendar screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Calendar = RPSControlFactory.CreateRPSComboBox<CopyCalendarWizardDialogView>("c2802fcc-7fe1-45d8-b89c-a4468d35d4f9","","",false, this);
 
            CollectionInit params_CalendarDetailsToCopy = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="012deba8-23a5-4e66-99a3-dabef5c6e8ba",CSSSelectorGrid="",XPathGrid=""};
            CalendarDetailsToCopy = RPSControlFactory.RPSCreateCollectionWithGrid<CalendarDetailsToCopyCollectionEditor<CopyCalendarWizardDialogView>,CopyCalendarWizardDialogView>( params_CalendarDetailsToCopy,this);
 
            CollectionInit params_CalendarsToCopy = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="06060423-240e-41d4-83ac-b246d73b7917",CSSSelectorGrid="",XPathGrid=""};
            CalendarsToCopy = RPSControlFactory.RPSCreateCollectionWithGrid<CalendarsToCopyCollectionEditor<CopyCalendarWizardDialogView>,CopyCalendarWizardDialogView>( params_CalendarsToCopy,this);
 

        }
        public IRPSComboBox<CopyCalendarWizardDialogView> Calendar { get; set; } 
        public CalendarDetailsToCopyCollectionEditor<CopyCalendarWizardDialogView> CalendarDetailsToCopy { get; set; } 
        public CalendarsToCopyCollectionEditor<CopyCalendarWizardDialogView> CalendarsToCopy { get; set; } 
        public Calendar Screen { get; set; }
        public CopyCalendarWizardDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CalendarDetailsToCopyCollectionEditor<CopyCalendarWizardDialogView>:RPSCollectionEditor<CopyCalendarWizardDialogView> where CopyCalendarWizardDialogView : class, IView
    {
        public  CalendarDetailsToCopyGridView<CopyCalendarWizardDialogView> GridView {get;set;}
    }
    public partial class CalendarDetailsToCopyGridView <CopyCalendarWizardDialogView> :  RPSGridView<CopyCalendarWizardDialogView> where CopyCalendarWizardDialogView : class, IView
    {
        public CalendarDetailsToCopyGridView(CopyCalendarWizardDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CalendarDetail_DateFrom = RPSControlFactory.CreateRPSGridTextBox<CopyCalendarWizardDialogView>("","#012deba8-23a5-4e66-99a3-dabef5c6e8ba .ag-row[role='row']@ROWINDEX [col-id='cCalendarDetail_DateFrom']","",false, this.CurrentView);
 
            CalendarDetail_DateTo = RPSControlFactory.CreateRPSGridTextBox<CopyCalendarWizardDialogView>("","#012deba8-23a5-4e66-99a3-dabef5c6e8ba .ag-row[role='row']@ROWINDEX [col-id='cCalendarDetail_DateTo']","",false, this.CurrentView);
 
            CalendarDetail_Priority = RPSControlFactory.CreateRPSGridFormattedTextBox<CopyCalendarWizardDialogView>("","#012deba8-23a5-4e66-99a3-dabef5c6e8ba .ag-row[role='row']@ROWINDEX [col-id='cCalendarDetail_Priority']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CopyCalendarWizardDialogView> CalendarDetail_DateFrom { get; set; } 
        public IRPSGridTextBox<CopyCalendarWizardDialogView> CalendarDetail_DateTo { get; set; } 
        public IRPSGridTextBox<CopyCalendarWizardDialogView> CalendarDetail_Priority { get; set; } 
                     
    }
 
        public partial class CalendarsToCopyCollectionEditor<CopyCalendarWizardDialogView>:RPSCollectionEditor<CopyCalendarWizardDialogView> where CopyCalendarWizardDialogView : class, IView
    {
        public  CalendarsToCopyGridView<CopyCalendarWizardDialogView> GridView {get;set;}
    }
    public partial class CalendarsToCopyGridView <CopyCalendarWizardDialogView> :  RPSGridView<CopyCalendarWizardDialogView> where CopyCalendarWizardDialogView : class, IView
    {
        public CalendarsToCopyGridView(CopyCalendarWizardDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ParentCalendar_Description = RPSControlFactory.CreateRPSGridTextBox<CopyCalendarWizardDialogView>("","#06060423-240e-41d4-83ac-b246d73b7917 .ag-row[role='row']@ROWINDEX [col-id='cParentCalendar_Description']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CopyCalendarWizardDialogView> ParentCalendar_Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class CalendarDetailsOfHigherCalendarsChildDialogView : View
    {
        public CalendarDetailsOfHigherCalendarsChildDialogView(Calendar screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ValoresCalendario = RPSControlFactory.CreateRPSCheckBox<CalendarDetailsOfHigherCalendarsChildDialogView>("e82ac6a5-1608-4081-b23b-559b69f34cbc","","",false, this);
 
            CollectionInit params_CalendarDetailsOfHigherCalendars = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a28369d4-dd5b-4a60-b2d9-048a6c825d97",CSSSelectorGrid="",XPathGrid=""};
            CalendarDetailsOfHigherCalendars = RPSControlFactory.RPSCreateCollectionWithGrid<CalendarDetailsOfHigherCalendarsCollectionEditor<CalendarDetailsOfHigherCalendarsChildDialogView>,CalendarDetailsOfHigherCalendarsChildDialogView>( params_CalendarDetailsOfHigherCalendars,this);
 

        }
        public IRPSCheckbox<CalendarDetailsOfHigherCalendarsChildDialogView> ValoresCalendario { get; set; } 
        public CalendarDetailsOfHigherCalendarsCollectionEditor<CalendarDetailsOfHigherCalendarsChildDialogView> CalendarDetailsOfHigherCalendars { get; set; } 
        public Calendar Screen { get; set; }
        public CalendarDetailsOfHigherCalendarsChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CalendarDetailsOfHigherCalendarsCollectionEditor<CalendarDetailsOfHigherCalendarsChildDialogView>:RPSCollectionEditor<CalendarDetailsOfHigherCalendarsChildDialogView> where CalendarDetailsOfHigherCalendarsChildDialogView : class, IView
    {
        public  CalendarDetailsOfHigherCalendarsGridView<CalendarDetailsOfHigherCalendarsChildDialogView> GridView {get;set;}
    }
    public partial class CalendarDetailsOfHigherCalendarsGridView <CalendarDetailsOfHigherCalendarsChildDialogView> :  RPSGridView<CalendarDetailsOfHigherCalendarsChildDialogView> where CalendarDetailsOfHigherCalendarsChildDialogView : class, IView
    {
        public CalendarDetailsOfHigherCalendarsGridView(CalendarDetailsOfHigherCalendarsChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CalendarDetail_DateFrom = RPSControlFactory.CreateRPSGridTextBox<CalendarDetailsOfHigherCalendarsChildDialogView>("","#a28369d4-dd5b-4a60-b2d9-048a6c825d97 .ag-row[role='row']@ROWINDEX [col-id='cCalendarDetail_DateFrom']","",false, this.CurrentView);
 
            CalendarDetail_DateTo = RPSControlFactory.CreateRPSGridTextBox<CalendarDetailsOfHigherCalendarsChildDialogView>("","#a28369d4-dd5b-4a60-b2d9-048a6c825d97 .ag-row[role='row']@ROWINDEX [col-id='cCalendarDetail_DateTo']","",false, this.CurrentView);
 
            CalendarDetail_Priority = RPSControlFactory.CreateRPSGridFormattedTextBox<CalendarDetailsOfHigherCalendarsChildDialogView>("","#a28369d4-dd5b-4a60-b2d9-048a6c825d97 .ag-row[role='row']@ROWINDEX [col-id='cCalendarDetail_Priority']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CalendarDetailsOfHigherCalendarsChildDialogView> CalendarDetail_DateFrom { get; set; } 
        public IRPSGridTextBox<CalendarDetailsOfHigherCalendarsChildDialogView> CalendarDetail_DateTo { get; set; } 
        public IRPSGridTextBox<CalendarDetailsOfHigherCalendarsChildDialogView> CalendarDetail_Priority { get; set; } 
                     
    }
 
    }
  
            
    public partial class CalendarTotalHoursDialogView : View
    {
        public CalendarTotalHoursDialogView(Calendar screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIYear = RPSControlFactory.CreateRPSFormattedTextBox<CalendarTotalHoursDialogView>("9f0aeb5f-2a03-4294-a29a-9218f5a69dd0","","",false, this);
 
            CollectionInit params_GetTotalHours = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a3512efa-8c8b-480a-b1dc-fa4a90f3c2a6",CSSSelectorGrid="",XPathGrid=""};
            GetTotalHours = RPSControlFactory.RPSCreateCollectionWithGrid<GetTotalHoursCollectionEditor<CalendarTotalHoursDialogView>,CalendarTotalHoursDialogView>( params_GetTotalHours,this);
 

        }
        public IRPSTextBox<CalendarTotalHoursDialogView> UIYear { get; set; } 
        public GetTotalHoursCollectionEditor<CalendarTotalHoursDialogView> GetTotalHours { get; set; } 
        public Calendar Screen { get; set; }
        public CalendarTotalHoursDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetTotalHoursCollectionEditor<CalendarTotalHoursDialogView>:RPSCollectionEditor<CalendarTotalHoursDialogView> where CalendarTotalHoursDialogView : class, IView
    {
        public  GetTotalHoursGridView<CalendarTotalHoursDialogView> GridView {get;set;}
    }
    public partial class GetTotalHoursGridView <CalendarTotalHoursDialogView> :  RPSGridView<CalendarTotalHoursDialogView> where CalendarTotalHoursDialogView : class, IView
    {
        public GetTotalHoursGridView(CalendarTotalHoursDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            UIMonthDescription = RPSControlFactory.CreateRPSGridTextBox<CalendarTotalHoursDialogView>("","#a3512efa-8c8b-480a-b1dc-fa4a90f3c2a6 .ag-row[role='row']@ROWINDEX [col-id='cUIMonthDescription']","",false, this.CurrentView);
 
            TotalHours = RPSControlFactory.CreateRPSGridFormattedTextBox<CalendarTotalHoursDialogView>("","#a3512efa-8c8b-480a-b1dc-fa4a90f3c2a6 .ag-row[role='row']@ROWINDEX [col-id='cTotalHours']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CalendarTotalHoursDialogView> UIMonthDescription { get; set; } 
        public IRPSGridTextBox<CalendarTotalHoursDialogView> TotalHours { get; set; } 
                     
    }
 
    }
  
    

}