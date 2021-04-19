    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.MaintenancePlan
{
    //RPS VERSION 1.0.0.0
    public partial class MaintenancePlan:Screen
    {
        public MaintenancePlan():base()
        {
            this.URL = "maintenance.maintenanceplan";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MaintenancePlanQueryView  = new MaintenancePlanQueryView(this); 
            MaintenanceComponentPlansView  = new MaintenanceComponentPlansView(this); 
            NewMaintenancePlanFromGenericDialogView  = new NewMaintenancePlanFromGenericDialogView(this); 
            MaintenancePlanQueryView.InitializeControls(); 
            MaintenanceComponentPlansView.InitializeControls(); 
            NewMaintenancePlanFromGenericDialogView.InitializeControls(); 
           
        }
      
            public MaintenancePlanQueryView MaintenancePlanQueryView {get; set; } 
            public MaintenanceComponentPlansView MaintenanceComponentPlansView {get; set; } 
            public NewMaintenancePlanFromGenericDialogView NewMaintenancePlanFromGenericDialogView {get; set; } 
    }
            
    public partial class MaintenancePlanQueryView : View
    {
        public MaintenancePlanQueryView(MaintenancePlan screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIIDSite = RPSControlFactory.CreateRPSComboBox<MaintenancePlanQueryView>("a3730ff3-cb76-48f4-ae45-32e3efa2ce0f","","",false, this);
 
            UIMaintenanceComponent = RPSControlFactory.CreateRPSComboBox<MaintenancePlanQueryView>("7d921fda-e5be-4426-a8c3-27f7dc07e824","","",false, this);
 
            SerialNumber = RPSControlFactory.CreateRPSTextBox<MaintenancePlanQueryView>("59fd7bb2-9063-4ebf-adb9-4df778ce84f8","","",false, this);
 

        }
        public IRPSComboBox<MaintenancePlanQueryView> UIIDSite { get; set; } 
        public IRPSComboBox<MaintenancePlanQueryView> UIMaintenanceComponent { get; set; } 
        public IRPSTextBox<MaintenancePlanQueryView> SerialNumber { get; set; } 
        public MaintenancePlan Screen { get; set; }
        public MaintenancePlanQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenanceComponentPlansView : View
    {
        public MaintenanceComponentPlansView(MaintenancePlan screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewMaintenancePlanCommandButton = RPSControlFactory.CreateRPSButton<MaintenanceComponentPlansView>( "00657d63-c259-4003-9849-bd544ea8929d","","",this);
 
            NewMaintenancePlanFromGenericNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<MaintenanceComponentPlansView,NewMaintenancePlanFromGenericDialogView>("e63a5d40-d0a4-4506-a765-1b99b260ce4c","","", this,Screen.NewMaintenancePlanFromGenericDialogView);
 
            CollectionInit params_MaintenancePlanForComponent = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="36946e1d-0347-4d2f-8438-ed3fb65c96e1",CSSSelectorGrid="",XPathGrid=""};
            MaintenancePlanForComponent = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenancePlanForComponentCollectionEditor<MaintenanceComponentPlansView,NewMaintenancePlanFromGenericDialogView>,MaintenanceComponentPlansView,NewMaintenancePlanFromGenericDialogView>( params_MaintenancePlanForComponent,this,Screen.NewMaintenancePlanFromGenericDialogView);
 

        }
        public IRPSButton<MaintenanceComponentPlansView> NewMaintenancePlanCommandButton { get; set; } 
        public IRPSButton<MaintenanceComponentPlansView,NewMaintenancePlanFromGenericDialogView> NewMaintenancePlanFromGenericNavigationCommandButton { get; set; } 
        public MaintenancePlanForComponentCollectionEditor<MaintenanceComponentPlansView,NewMaintenancePlanFromGenericDialogView> MaintenancePlanForComponent { get; set; } 
        public MaintenancePlan Screen { get; set; }
        public MaintenanceComponentPlansView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaintenancePlanForComponentCollectionEditor<MaintenanceComponentPlansView,NewMaintenancePlanFromGenericDialogView>:RPSCollectionEditor<MaintenanceComponentPlansView,NewMaintenancePlanFromGenericDialogView> where MaintenanceComponentPlansView : class, IView where NewMaintenancePlanFromGenericDialogView : class, IView
    {
        public  MaintenancePlanForComponentGridView<MaintenanceComponentPlansView,NewMaintenancePlanFromGenericDialogView> GridView {get;set;}
    }
    public partial class MaintenancePlanForComponentGridView <MaintenanceComponentPlansView,NewMaintenancePlanFromGenericDialogView> :  RPSGridView<MaintenanceComponentPlansView,NewMaintenancePlanFromGenericDialogView> where MaintenanceComponentPlansView : class, IView where NewMaintenancePlanFromGenericDialogView : class, IView
    {
        public MaintenancePlanForComponentGridView(MaintenanceComponentPlansView currentView,NewMaintenancePlanFromGenericDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MaintenancePlan_LastActionDate = RPSControlFactory.CreateRPSGridTextBox<MaintenanceComponentPlansView>("","#36946e1d-0347-4d2f-8438-ed3fb65c96e1 .ag-row[role='row']@ROWINDEX [col-id='cMaintenancePlan_LastActionDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MaintenanceComponentPlansView> MaintenancePlan_LastActionDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class NewMaintenancePlanFromGenericDialogView : View
    {
        public NewMaintenancePlanFromGenericDialogView(MaintenancePlan screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIMaintenancePlan = RPSControlFactory.CreateRPSComboBox<NewMaintenancePlanFromGenericDialogView>("8d03400d-fcaa-43e0-a85c-ead878f4eb47","","",true, this);
 
            NewPlanCode = RPSControlFactory.CreateRPSTextBox<NewMaintenancePlanFromGenericDialogView>("7d6d5d68-081f-47ec-aa40-02b0fd4eb523","","",false, this);
 

        }
        public IRPSComboBox<NewMaintenancePlanFromGenericDialogView> UIMaintenancePlan { get; set; } 
        public IRPSTextBox<NewMaintenancePlanFromGenericDialogView> NewPlanCode { get; set; } 
        public MaintenancePlan Screen { get; set; }
        public NewMaintenancePlanFromGenericDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}