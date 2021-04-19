    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.MANCONPlan
{
    //RPS VERSION 1.0.0.0
    public partial class MANCONPlan:Screen
    {
        public MANCONPlan():base()
        {
            this.URL = "maintenance.manconplan";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MANCONPlanQueryView  = new MANCONPlanQueryView(this); 
            MANCONPlanQueryView.InitializeControls(); 
           
        }
      
            public MANCONPlanQueryView MANCONPlanQueryView {get; set; } 
    }
            
    public partial class MANCONPlanQueryView : View
    {
        public MANCONPlanQueryView(MANCONPlan screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<MANCONPlanQueryView>("e6fd3fbe-44cf-4420-93c0-f2b3396340a5","","",false, this);
 
            MaintenanceTypes = RPSControlFactory.CreateRPSCollectionComboBox<MANCONPlanQueryView>("fd48ca62-0f76-4008-bcc6-87a2c1915cb6","","",false, this);
 
            All = RPSControlFactory.CreateRPSOption<MANCONPlanQueryView>( "6cc01115-e7ad-484e-ab3f-8e8b94f453f0","","",this);
 
            Component = RPSControlFactory.CreateRPSOption<MANCONPlanQueryView>( "2381b6a1-5c7a-4408-9b5b-5ba4a2fa111c","","",this);
 
            MaintenanceComponent = RPSControlFactory.CreateRPSComboBox<MANCONPlanQueryView>("50a398f8-7b9a-4b4b-b8b4-26f61f2b8329","","",false, this);
 
            SerialNumber = RPSControlFactory.CreateRPSTextBox<MANCONPlanQueryView>("a3f94beb-8302-496d-b107-f67dc4a9a7fb","","",false, this);
 
            Generic = RPSControlFactory.CreateRPSOption<MANCONPlanQueryView>( "84061e23-7371-46d3-b2a5-a47e004cfc07","","",this);
 
            MaintenanceComponentType = RPSControlFactory.CreateRPSComboBox<MANCONPlanQueryView>("02b7dd6f-0dee-463c-ad35-dd5619fd66e9","","",false, this);
 
            All1 = RPSControlFactory.CreateRPSOption<MANCONPlanQueryView>( "598f1b9c-b83b-40fb-99bc-a387760a24a5","","",this);
 
            Stop = RPSControlFactory.CreateRPSOption<MANCONPlanQueryView>( "0012a725-8c22-4e90-afc5-a64d421c6bc4","","",this);
 
            NotStop = RPSControlFactory.CreateRPSOption<MANCONPlanQueryView>( "ee3be962-2ea5-49a5-a54a-c70c4f9663a0","","",this);
 
            All2 = RPSControlFactory.CreateRPSOption<MANCONPlanQueryView>( "aa285d57-0218-49c6-b83c-2030cc64f5c2","","",this);
 
            Active = RPSControlFactory.CreateRPSOption<MANCONPlanQueryView>( "6b8ef74d-43dc-4848-af32-3d7127e21c7a","","",this);
 
            Locked = RPSControlFactory.CreateRPSOption<MANCONPlanQueryView>( "ec10c0ff-38fc-4998-b362-54afd2878aee","","",this);
 
            All3 = RPSControlFactory.CreateRPSOption<MANCONPlanQueryView>( "d265c497-0a22-4697-b001-e6d08e1d021f","","",this);
 
            Qualification = RPSControlFactory.CreateRPSOption<MANCONPlanQueryView>( "8ae25307-ac0a-479a-9fbf-af30215361e1","","",this);
 
            IDQualify = RPSControlFactory.CreateRPSComboBox<MANCONPlanQueryView>("cf5a576d-5b8e-4301-90d3-20aa68ef428b","","",false, this);
 
            Employee = RPSControlFactory.CreateRPSOption<MANCONPlanQueryView>( "15782d8f-034f-4586-ab24-5d6d9b1e2173","","",this);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<MANCONPlanQueryView>("6ced0042-775f-44d4-b3fe-ccb8661a9bd0","","",false, this);
 
            Supplier = RPSControlFactory.CreateRPSOption<MANCONPlanQueryView>( "4d9971f2-5ca2-442e-957d-79b7fc7f641a","","",this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<MANCONPlanQueryView>("f88051e3-c04e-4d7a-812f-5d9292a73c46","","",false, this);
 
            CollectionInit params_MaintenancePlanHistoricConsult = new CollectionInit(){IDDescriptor = "0ed537b6-a1b3-4303-9b9e-da04852826c1",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a6eb4301-ce63-47bf-996c-d60b1c0a28e1",CSSSelectorGrid="",XPathGrid=""};
            MaintenancePlanHistoricConsult = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenancePlanHistoricConsultCollectionEditor<MANCONPlanQueryView>,MANCONPlanQueryView>( params_MaintenancePlanHistoricConsult,this);
 

        }
        public IRPSComboBox<MANCONPlanQueryView> Site { get; set; } 
        public IRPSCollectionComboBox<MANCONPlanQueryView> MaintenanceTypes { get; set; } 
        public IRPSOption<MANCONPlanQueryView> All { get; set; } 
        public IRPSOption<MANCONPlanQueryView> Component { get; set; } 
        public IRPSComboBox<MANCONPlanQueryView> MaintenanceComponent { get; set; } 
        public IRPSTextBox<MANCONPlanQueryView> SerialNumber { get; set; } 
        public IRPSOption<MANCONPlanQueryView> Generic { get; set; } 
        public IRPSComboBox<MANCONPlanQueryView> MaintenanceComponentType { get; set; } 
        public IRPSOption<MANCONPlanQueryView> All1 { get; set; } 
        public IRPSOption<MANCONPlanQueryView> Stop { get; set; } 
        public IRPSOption<MANCONPlanQueryView> NotStop { get; set; } 
        public IRPSOption<MANCONPlanQueryView> All2 { get; set; } 
        public IRPSOption<MANCONPlanQueryView> Active { get; set; } 
        public IRPSOption<MANCONPlanQueryView> Locked { get; set; } 
        public IRPSOption<MANCONPlanQueryView> All3 { get; set; } 
        public IRPSOption<MANCONPlanQueryView> Qualification { get; set; } 
        public IRPSComboBox<MANCONPlanQueryView> IDQualify { get; set; } 
        public IRPSOption<MANCONPlanQueryView> Employee { get; set; } 
        public IRPSComboBox<MANCONPlanQueryView> IDEmployee { get; set; } 
        public IRPSOption<MANCONPlanQueryView> Supplier { get; set; } 
        public IRPSComboBox<MANCONPlanQueryView> IDSupplier { get; set; } 
        public MaintenancePlanHistoricConsultCollectionEditor<MANCONPlanQueryView> MaintenancePlanHistoricConsult { get; set; } 
        public MANCONPlan Screen { get; set; }
        public MANCONPlanQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaintenancePlanHistoricConsultCollectionEditor<MANCONPlanQueryView>:RPSCollectionEditor<MANCONPlanQueryView> where MANCONPlanQueryView : class, IView
    {
        public  MaintenancePlanHistoricConsultGridView<MANCONPlanQueryView> GridView {get;set;}
    }
    public partial class MaintenancePlanHistoricConsultGridView <MANCONPlanQueryView> :  RPSGridView<MANCONPlanQueryView> where MANCONPlanQueryView : class, IView
    {
        public MaintenancePlanHistoricConsultGridView(MANCONPlanQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MaintenancePlan_TypeOfAction = RPSControlFactory.CreateRPSGridTextBox<MANCONPlanQueryView>("","#a6eb4301-ce63-47bf-996c-d60b1c0a28e1 .ag-row[role='row']@ROWINDEX [col-id='cMaintenancePlan_TypeOfAction']","",false, this.CurrentView);
 
            MaintenancePlan_ResponsibleType = RPSControlFactory.CreateRPSGridTextBox<MANCONPlanQueryView>("","#a6eb4301-ce63-47bf-996c-d60b1c0a28e1 .ag-row[role='row']@ROWINDEX [col-id='cMaintenancePlan_ResponsibleType']","",false, this.CurrentView);
 
            MaintenancePlan_LastActionDate = RPSControlFactory.CreateRPSGridTextBox<MANCONPlanQueryView>("","#a6eb4301-ce63-47bf-996c-d60b1c0a28e1 .ag-row[role='row']@ROWINDEX [col-id='cMaintenancePlan_LastActionDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MANCONPlanQueryView> MaintenancePlan_TypeOfAction { get; set; } 
        public IRPSGridTextBox<MANCONPlanQueryView> MaintenancePlan_ResponsibleType { get; set; } 
        public IRPSGridTextBox<MANCONPlanQueryView> MaintenancePlan_LastActionDate { get; set; } 
                     
    }
 
    }
  
    

}