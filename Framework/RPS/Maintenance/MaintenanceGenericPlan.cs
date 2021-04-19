    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.MaintenanceGenericPlan
{
    //RPS VERSION 1.0.0.0
    public partial class MaintenanceGenericPlan:Screen
    {
        public MaintenanceGenericPlan():base()
        {
            this.URL = "maintenance.maintenancegenericplan";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MaintenanceGenericPlanQueryView  = new MaintenanceGenericPlanQueryView(this); 
            MaintenanceGenericPlanQueryView.InitializeControls(); 
           
        }
      
            public MaintenanceGenericPlanQueryView MaintenanceGenericPlanQueryView {get; set; } 
    }
            
    public partial class MaintenanceGenericPlanQueryView : View
    {
        public MaintenanceGenericPlanQueryView(MaintenanceGenericPlan screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            MaintenanceComponentType = RPSControlFactory.CreateRPSComboBox<MaintenanceGenericPlanQueryView>("ab991a1d-74f5-4d14-ad29-e2b4d4082b96","","",false, this);
 
            NewMaintenancePlanCommandButton = RPSControlFactory.CreateRPSButton<MaintenanceGenericPlanQueryView>( "21b80e8e-f96d-4390-97be-c10da09e4013","","",this);
 
            CollectionInit params_MaintenancePlanForComponentType = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4cb92dea-2670-4526-8e50-d69480cd5a15",CSSSelectorGrid="",XPathGrid=""};
            MaintenancePlanForComponentType = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenancePlanForComponentTypeCollectionEditor<MaintenanceGenericPlanQueryView>,MaintenanceGenericPlanQueryView>( params_MaintenancePlanForComponentType,this);
 

        }
        public IRPSComboBox<MaintenanceGenericPlanQueryView> MaintenanceComponentType { get; set; } 
        public IRPSButton<MaintenanceGenericPlanQueryView> NewMaintenancePlanCommandButton { get; set; } 
        public MaintenancePlanForComponentTypeCollectionEditor<MaintenanceGenericPlanQueryView> MaintenancePlanForComponentType { get; set; } 
        public MaintenanceGenericPlan Screen { get; set; }
        public MaintenanceGenericPlanQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaintenancePlanForComponentTypeCollectionEditor<MaintenanceGenericPlanQueryView>:RPSCollectionEditor<MaintenanceGenericPlanQueryView> where MaintenanceGenericPlanQueryView : class, IView
    {
        public  MaintenancePlanForComponentTypeGridView<MaintenanceGenericPlanQueryView> GridView {get;set;}
    }
    public partial class MaintenancePlanForComponentTypeGridView <MaintenanceGenericPlanQueryView> :  RPSGridView<MaintenanceGenericPlanQueryView> where MaintenanceGenericPlanQueryView : class, IView
    {
        public MaintenancePlanForComponentTypeGridView(MaintenanceGenericPlanQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MaintenancePlan_TypeOfAction = RPSControlFactory.CreateRPSGridTextBox<MaintenanceGenericPlanQueryView>("","#4cb92dea-2670-4526-8e50-d69480cd5a15 .ag-row[role='row']@ROWINDEX [col-id='cMaintenancePlan_TypeOfAction']","",false, this.CurrentView);
 
            MaintenancePlan_ResponsibleType = RPSControlFactory.CreateRPSGridTextBox<MaintenanceGenericPlanQueryView>("","#4cb92dea-2670-4526-8e50-d69480cd5a15 .ag-row[role='row']@ROWINDEX [col-id='cMaintenancePlan_ResponsibleType']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MaintenanceGenericPlanQueryView> MaintenancePlan_TypeOfAction { get; set; } 
        public IRPSGridTextBox<MaintenanceGenericPlanQueryView> MaintenancePlan_ResponsibleType { get; set; } 
                     
    }
 
    }
  
    

}