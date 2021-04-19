    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.AllMaintenancePlans
{
    //RPS VERSION 1.0.0.0
    public partial class AllMaintenancePlans:Screen
    {
        public AllMaintenancePlans():base()
        {
            this.URL = "maintenance.allmaintenanceplans";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MaintenancePlanCollectionView  = new MaintenancePlanCollectionView(this); 
            MaintenancePlanEntityView  = new MaintenancePlanEntityView(this); 
            MaintenancePlanPredictiveView  = new MaintenancePlanPredictiveView(this); 
            MaintenancePlanProcedureView  = new MaintenancePlanProcedureView(this); 
            MaintenancePlanProcTaskView  = new MaintenancePlanProcTaskView(this); 
            MaintenancePlanResourceView  = new MaintenancePlanResourceView(this); 
            MaintenancePlanSubcontractView  = new MaintenancePlanSubcontractView(this); 
            MaintenancePlanMaterialView  = new MaintenancePlanMaterialView(this); 
            MaintenancePlanControlView  = new MaintenancePlanControlView(this); 
            MaintenancePlanStaffView  = new MaintenancePlanStaffView(this); 
            MaintenancePlanExpensesView  = new MaintenancePlanExpensesView(this); 
            MaintenancePlanCollectionView.InitializeControls(); 
            MaintenancePlanEntityView.InitializeControls(); 
            MaintenancePlanPredictiveView.InitializeControls(); 
            MaintenancePlanProcedureView.InitializeControls(); 
            MaintenancePlanProcTaskView.InitializeControls(); 
            MaintenancePlanResourceView.InitializeControls(); 
            MaintenancePlanSubcontractView.InitializeControls(); 
            MaintenancePlanMaterialView.InitializeControls(); 
            MaintenancePlanControlView.InitializeControls(); 
            MaintenancePlanStaffView.InitializeControls(); 
            MaintenancePlanExpensesView.InitializeControls(); 
           
        }
      
            public MaintenancePlanCollectionView MaintenancePlanCollectionView {get; set; } 
            public MaintenancePlanEntityView MaintenancePlanEntityView {get; set; } 
            public MaintenancePlanPredictiveView MaintenancePlanPredictiveView {get; set; } 
            public MaintenancePlanProcedureView MaintenancePlanProcedureView {get; set; } 
            public MaintenancePlanProcTaskView MaintenancePlanProcTaskView {get; set; } 
            public MaintenancePlanResourceView MaintenancePlanResourceView {get; set; } 
            public MaintenancePlanSubcontractView MaintenancePlanSubcontractView {get; set; } 
            public MaintenancePlanMaterialView MaintenancePlanMaterialView {get; set; } 
            public MaintenancePlanControlView MaintenancePlanControlView {get; set; } 
            public MaintenancePlanStaffView MaintenancePlanStaffView {get; set; } 
            public MaintenancePlanExpensesView MaintenancePlanExpensesView {get; set; } 
    }
            
    public partial class MaintenancePlanCollectionView : View
    {
        public MaintenancePlanCollectionView(AllMaintenancePlans screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<MaintenancePlanCollectionView,MaintenancePlanEntityView>( this,Screen.MaintenancePlanEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "3b62733a-eed7-4f7a-b735-0efe0b2a4dfe",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<MaintenancePlanCollectionView,MaintenancePlanEntityView>( params_MainConsult,this,Screen.MaintenancePlanEntityView);
 

        }
        public IRPSButton<MaintenancePlanCollectionView,MaintenancePlanEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<MaintenancePlanCollectionView,MaintenancePlanEntityView> MainConsult { get; set; } 
        public AllMaintenancePlans Screen { get; set; }
        public MaintenancePlanCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenancePlanEntityView : View
    {
        public MaintenancePlanEntityView(AllMaintenancePlans screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MaintenancePlanEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenancePlanEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenancePlanEntityView,MaintenancePlanCollectionView>( this,Screen.MaintenancePlanCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenancePlanEntityView,MaintenancePlanCollectionView>( this,Screen.MaintenancePlanCollectionView);
 
            MaintenancePlanCode = RPSControlFactory.CreateRPSTextBox<MaintenancePlanEntityView>("724cc298-7f1a-446f-86f2-10ef7b213d20","","",false, this);
 
            IDMaintenanceType = RPSControlFactory.CreateRPSComboBox<MaintenancePlanEntityView>("a8eab036-01be-42b2-987a-5bb5cf172aa4","","",true, this);
 
            IDManComponent = RPSControlFactory.CreateRPSComboBox<MaintenancePlanEntityView>("174a0a45-14de-4fdf-858d-3d6d77074d5a","","",false, this);
 
            Serial_Number = RPSControlFactory.CreateRPSTextBox<MaintenancePlanEntityView>("7eca3ed6-da5c-447c-a569-c5fd40b5a38c","","",false, this);
 
            ComponentType = RPSControlFactory.CreateRPSComboBox<MaintenancePlanEntityView>("61e03742-4014-4692-bc59-518791eaa840","","",false, this);
 
            IDMaintenanceComponentType = RPSControlFactory.CreateRPSComboBox<MaintenancePlanEntityView>("40f4de8c-17d7-41c7-9c9d-552594977102","","",false, this);
 
            Locked = RPSControlFactory.CreateRPSEnumComboBox<MaintenancePlanEntityView>("58a8b567-d832-4e26-9dd1-62b7360ac688","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MaintenancePlanEntityView>("61797805-d6b5-49fd-bb8e-434d413aa79f","","",false, this);
 
            LastActionDate = RPSControlFactory.CreateRPSTextBox<MaintenancePlanEntityView>("294583f2-b154-4475-b138-a1c874f90792","","",true, this);
 
            LastActionTime = RPSControlFactory.CreateRPSTextBox<MaintenancePlanEntityView>("b4e645af-8d69-41be-a913-cf638198f882","","",false, this);
 
            DegreeOfRisk = RPSControlFactory.CreateRPSEnumComboBox<MaintenancePlanEntityView>("8007a789-d248-4620-a192-d6b76b5993b5","","",true, this);
 
            Tolerance = RPSControlFactory.CreateRPSFormattedTextBox<MaintenancePlanEntityView>("3a227381-bfb8-49ae-a277-40d82f57f151","","",false, this);
 
            TypeOfAction = RPSControlFactory.CreateRPSEnumComboBox<MaintenancePlanEntityView>("5a29b456-6259-4086-b90c-74b7c5dd22df","","",true, this);
 
            PlannedTime = RPSControlFactory.CreateRPSDurationTextBox<MaintenancePlanEntityView>("b005b276-ffaa-4c17-80af-6953548a128d","","",true, this);
 
            PlannedStopTime = RPSControlFactory.CreateRPSDurationTextBox<MaintenancePlanEntityView>("41e46840-f4c9-4e95-b664-cd4d8f6d1d22","","",false, this);
 
            ResponsibleType = RPSControlFactory.CreateRPSEnumComboBox<MaintenancePlanEntityView>("43eb1716-396d-497e-86e7-de94d3716c12","","",true, this);
 
            IDResponsibleEmployee = RPSControlFactory.CreateRPSComboBox<MaintenancePlanEntityView>("23b19da0-1669-4957-a3ca-e166a16b058a","","",false, this);
 
            IDResponsibleQualification = RPSControlFactory.CreateRPSComboBox<MaintenancePlanEntityView>("6a5bcfb8-616b-43cd-8c54-de4dbd9cbca3","","",false, this);
 
            IDResponsibleSupplier = RPSControlFactory.CreateRPSComboBox<MaintenancePlanEntityView>("fb93987d-d78b-4fe9-97f5-814ca2078b79","","",false, this);
 
            OverlappingAllowed = RPSControlFactory.CreateRPSCheckBox<MaintenancePlanEntityView>("48eb3d4e-6d6f-49ae-8c83-6c453979e369","","",true, this);
 
            ExclusiveProgramming = RPSControlFactory.CreateRPSCheckBox<MaintenancePlanEntityView>("39fe76ec-05f2-4182-8ed4-2272e3cd2b37","","",true, this);
 
            Priority = RPSControlFactory.CreateRPSFormattedTextBox<MaintenancePlanEntityView>("d5729465-a06d-413f-9e4e-65be78a1aa5c","","",true, this);
 
            OptimizationFeature = RPSControlFactory.CreateRPSTextBox<MaintenancePlanEntityView>("f247ef5a-b932-4ad7-8f3b-04be25f1891d","","",false, this);
 
            OccupancyType = RPSControlFactory.CreateRPSEnumComboBox<MaintenancePlanEntityView>("1ba3cff7-8424-4fe1-9a1a-71cbfbf98d9b","","",true, this);
 
            OccupancyHours = RPSControlFactory.CreateRPSFormattedTextBox<MaintenancePlanEntityView>("e69d4e73-9c54-4771-b02a-ec49d17ae70f","","",true, this);
 
            OccupancyPercent = RPSControlFactory.CreateRPSFormattedTextBox<MaintenancePlanEntityView>("96c7e76b-755a-4087-a55f-1158be6b602e","","",true, this);
 
            LinkToComponentPlansCommandButton = RPSControlFactory.CreateRPSButton<MaintenancePlanEntityView>( "21ccb20e-e388-4721-93a5-bfbc3e4debe5","","",this);
 
            CollectionInit params_MaintenancePlanControls = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="72e3237e-4548-4150-b926-383c038b36c0",CSSSelectorGrid="",XPathGrid=""};
            MaintenancePlanControls = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenancePlanControlsCollectionEditor<MaintenancePlanEntityView,MaintenancePlanPredictiveView>,MaintenancePlanEntityView,MaintenancePlanPredictiveView>( params_MaintenancePlanControls,this,Screen.MaintenancePlanPredictiveView);
 
            CollectionInit params_MaintenancePlanProcedures = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="11ff7601-c652-4983-87b9-0c353e81e629",CSSSelectorGrid="",XPathGrid=""};
            MaintenancePlanProcedures = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenancePlanProceduresCollectionEditor<MaintenancePlanEntityView,MaintenancePlanPredictiveView>,MaintenancePlanEntityView,MaintenancePlanPredictiveView>( params_MaintenancePlanProcedures,this,Screen.MaintenancePlanPredictiveView);
 
            CollectionInit params_MaintenancePlanMaterials = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="254cd91e-415c-422e-a5c1-e8a8c8f2a525",CSSSelectorGrid="",XPathGrid=""};
            MaintenancePlanMaterials = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenancePlanMaterialsCollectionEditor<MaintenancePlanEntityView,MaintenancePlanPredictiveView>,MaintenancePlanEntityView,MaintenancePlanPredictiveView>( params_MaintenancePlanMaterials,this,Screen.MaintenancePlanPredictiveView);
 
            CollectionInit params_MaintenancePlanSubcontracts = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4389e7f5-6402-49d4-8b49-416cf74301b8",CSSSelectorGrid="",XPathGrid=""};
            MaintenancePlanSubcontracts = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenancePlanSubcontractsCollectionEditor<MaintenancePlanEntityView,MaintenancePlanPredictiveView>,MaintenancePlanEntityView,MaintenancePlanPredictiveView>( params_MaintenancePlanSubcontracts,this,Screen.MaintenancePlanPredictiveView);
 
            CollectionInit params_MaintenancePlanResources = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6fd04721-fb9d-4cc7-8e58-1084acf57ed2",CSSSelectorGrid="",XPathGrid=""};
            MaintenancePlanResources = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenancePlanResourcesCollectionEditor<MaintenancePlanEntityView,MaintenancePlanPredictiveView>,MaintenancePlanEntityView,MaintenancePlanPredictiveView>( params_MaintenancePlanResources,this,Screen.MaintenancePlanPredictiveView);
 
            CollectionInit params_MANMaintenancePlanStaffs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="e59d8430-932b-4a1d-99ef-b4cca6bc63f7",CSSSelectorGrid="",XPathGrid=""};
            MANMaintenancePlanStaffs = RPSControlFactory.RPSCreateCollectionWithGrid<MANMaintenancePlanStaffsCollectionEditor<MaintenancePlanEntityView,MaintenancePlanPredictiveView>,MaintenancePlanEntityView,MaintenancePlanPredictiveView>( params_MANMaintenancePlanStaffs,this,Screen.MaintenancePlanPredictiveView);
 
            CollectionInit params_MaintenancePlanExpensess = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="2a1e3532-ad05-43ba-a73e-cd098948a6f8",CSSSelectorGrid="",XPathGrid=""};
            MaintenancePlanExpensess = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenancePlanExpensessCollectionEditor<MaintenancePlanEntityView,MaintenancePlanPredictiveView>,MaintenancePlanEntityView,MaintenancePlanPredictiveView>( params_MaintenancePlanExpensess,this,Screen.MaintenancePlanPredictiveView);
 
            CollectionInit params_MaintenancePlanPredictives1 = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0e1bf02c-0f83-44da-bcc3-92766b4e48c9",CSSSelectorGrid="",XPathGrid=""};
            MaintenancePlanPredictives1 = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenancePlanPredictives1CollectionEditor<MaintenancePlanEntityView,MaintenancePlanPredictiveView>,MaintenancePlanEntityView,MaintenancePlanPredictiveView>( params_MaintenancePlanPredictives1,this,Screen.MaintenancePlanPredictiveView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<MaintenancePlanEntityView>( "","ul li[rpsid='836c2d03-2f3c-4a3f-b67a-e450cbaa7668']","",this);
 
            Controls = RPSControlFactory.CreateRPSSection<MaintenancePlanEntityView>( "","ul li[rpsid='85368795-fad5-43d1-bb82-07802e8e0e9b']","",this);
 
            Procedures = RPSControlFactory.CreateRPSSection<MaintenancePlanEntityView>( "","ul li[rpsid='298a6530-7e42-4cde-9f16-00073855a14d']","",this);
 
            Materials = RPSControlFactory.CreateRPSSection<MaintenancePlanEntityView>( "","ul li[rpsid='2db7fa9f-39a8-481e-ad46-5785d88ff1fb']","",this);
 
            Subcontracts = RPSControlFactory.CreateRPSSection<MaintenancePlanEntityView>( "","ul li[rpsid='e6d90085-7fbc-4895-9966-8a70133edc59']","",this);
 
            Resources = RPSControlFactory.CreateRPSSection<MaintenancePlanEntityView>( "","ul li[rpsid='7e8746f2-8fab-4b7d-a62e-8e021598d636']","",this);
 
            Staff = RPSControlFactory.CreateRPSSection<MaintenancePlanEntityView>( "","ul li[rpsid='7a47ac0f-66db-4617-b204-6c8b54a15be5']","",this);
 
            Expenses = RPSControlFactory.CreateRPSSection<MaintenancePlanEntityView>( "","ul li[rpsid='4ef8284e-4d73-42d2-83ea-e2670eac954c']","",this);
 
            CharacteristicsControl = RPSControlFactory.CreateRPSSection<MaintenancePlanEntityView>( "","ul li[rpsid='f9ef8d40-aa9d-4699-b4fe-21b933037b2b']","",this);
 

        }
        public IRPSSaveButton<MaintenancePlanEntityView> SaveButton { get; set; } 
        public IRPSButton<MaintenancePlanEntityView> DeleteButton { get; set; } 
        public IRPSButton<MaintenancePlanEntityView,MaintenancePlanCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenancePlanEntityView,MaintenancePlanCollectionView> BackButton { get; set; } 
        public IRPSTextBox<MaintenancePlanEntityView> MaintenancePlanCode { get; set; } 
        public IRPSComboBox<MaintenancePlanEntityView> IDMaintenanceType { get; set; } 
        public IRPSComboBox<MaintenancePlanEntityView> IDManComponent { get; set; } 
        public IRPSTextBox<MaintenancePlanEntityView> Serial_Number { get; set; } 
        public IRPSComboBox<MaintenancePlanEntityView> ComponentType { get; set; } 
        public IRPSComboBox<MaintenancePlanEntityView> IDMaintenanceComponentType { get; set; } 
        public IRPSComboBox<MaintenancePlanEntityView> Locked { get; set; } 
        public IRPSTextBox<MaintenancePlanEntityView> Description { get; set; } 
        public IRPSTextBox<MaintenancePlanEntityView> LastActionDate { get; set; } 
        public IRPSTextBox<MaintenancePlanEntityView> LastActionTime { get; set; } 
        public IRPSComboBox<MaintenancePlanEntityView> DegreeOfRisk { get; set; } 
        public IRPSTextBox<MaintenancePlanEntityView> Tolerance { get; set; } 
        public IRPSComboBox<MaintenancePlanEntityView> TypeOfAction { get; set; } 
        public IRPSDurationTextBox<MaintenancePlanEntityView> PlannedTime { get; set; } 
        public IRPSDurationTextBox<MaintenancePlanEntityView> PlannedStopTime { get; set; } 
        public IRPSComboBox<MaintenancePlanEntityView> ResponsibleType { get; set; } 
        public IRPSComboBox<MaintenancePlanEntityView> IDResponsibleEmployee { get; set; } 
        public IRPSComboBox<MaintenancePlanEntityView> IDResponsibleQualification { get; set; } 
        public IRPSComboBox<MaintenancePlanEntityView> IDResponsibleSupplier { get; set; } 
        public IRPSCheckbox<MaintenancePlanEntityView> OverlappingAllowed { get; set; } 
        public IRPSCheckbox<MaintenancePlanEntityView> ExclusiveProgramming { get; set; } 
        public IRPSTextBox<MaintenancePlanEntityView> Priority { get; set; } 
        public IRPSTextBox<MaintenancePlanEntityView> OptimizationFeature { get; set; } 
        public IRPSComboBox<MaintenancePlanEntityView> OccupancyType { get; set; } 
        public IRPSTextBox<MaintenancePlanEntityView> OccupancyHours { get; set; } 
        public IRPSTextBox<MaintenancePlanEntityView> OccupancyPercent { get; set; } 
        public IRPSButton<MaintenancePlanEntityView> LinkToComponentPlansCommandButton { get; set; } 
        public MaintenancePlanControlsCollectionEditor<MaintenancePlanEntityView,MaintenancePlanPredictiveView> MaintenancePlanControls { get; set; } 
        public MaintenancePlanProceduresCollectionEditor<MaintenancePlanEntityView,MaintenancePlanPredictiveView> MaintenancePlanProcedures { get; set; } 
        public MaintenancePlanMaterialsCollectionEditor<MaintenancePlanEntityView,MaintenancePlanPredictiveView> MaintenancePlanMaterials { get; set; } 
        public MaintenancePlanSubcontractsCollectionEditor<MaintenancePlanEntityView,MaintenancePlanPredictiveView> MaintenancePlanSubcontracts { get; set; } 
        public MaintenancePlanResourcesCollectionEditor<MaintenancePlanEntityView,MaintenancePlanPredictiveView> MaintenancePlanResources { get; set; } 
        public MANMaintenancePlanStaffsCollectionEditor<MaintenancePlanEntityView,MaintenancePlanPredictiveView> MANMaintenancePlanStaffs { get; set; } 
        public MaintenancePlanExpensessCollectionEditor<MaintenancePlanEntityView,MaintenancePlanPredictiveView> MaintenancePlanExpensess { get; set; } 
        public MaintenancePlanPredictives1CollectionEditor<MaintenancePlanEntityView,MaintenancePlanPredictiveView> MaintenancePlanPredictives1 { get; set; } 
        public IRPSSection<MaintenancePlanEntityView> GeneralData { get; set; } 
        public IRPSSection<MaintenancePlanEntityView> Controls { get; set; } 
        public IRPSSection<MaintenancePlanEntityView> Procedures { get; set; } 
        public IRPSSection<MaintenancePlanEntityView> Materials { get; set; } 
        public IRPSSection<MaintenancePlanEntityView> Subcontracts { get; set; } 
        public IRPSSection<MaintenancePlanEntityView> Resources { get; set; } 
        public IRPSSection<MaintenancePlanEntityView> Staff { get; set; } 
        public IRPSSection<MaintenancePlanEntityView> Expenses { get; set; } 
        public IRPSSection<MaintenancePlanEntityView> CharacteristicsControl { get; set; } 
        public AllMaintenancePlans Screen { get; set; }
        public MaintenancePlanEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaintenancePlanControlsCollectionEditor<MaintenancePlanEntityView,MaintenancePlanPredictiveView>:RPSCollectionEditor<MaintenancePlanEntityView,MaintenancePlanPredictiveView> where MaintenancePlanEntityView : class, IView where MaintenancePlanPredictiveView : class, IView
    {
        public  MaintenancePlanControlsGridView<MaintenancePlanEntityView,MaintenancePlanPredictiveView> GridView {get;set;}
    }
    public partial class MaintenancePlanControlsGridView <MaintenancePlanEntityView,MaintenancePlanPredictiveView> :  RPSGridView<MaintenancePlanEntityView,MaintenancePlanPredictiveView> where MaintenancePlanEntityView : class, IView where MaintenancePlanPredictiveView : class, IView
    {
        public MaintenancePlanControlsGridView(MaintenancePlanEntityView currentView,MaintenancePlanPredictiveView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ControlType = RPSControlFactory.CreateRPSGridEnumComboBox<MaintenancePlanEntityView>("","#72e3237e-4548-4150-b926-383c038b36c0 .ag-row[role='row']@ROWINDEX [col-id='cControlType']","",true, this.CurrentView);
 
            FixedDate = RPSControlFactory.CreateRPSGridTextBox<MaintenancePlanEntityView>("","#72e3237e-4548-4150-b926-383c038b36c0 .ag-row[role='row']@ROWINDEX [col-id='cFixedDate']","",false, this.CurrentView);
 
            ReleaseDate = RPSControlFactory.CreateRPSGridTextBox<MaintenancePlanEntityView>("","#72e3237e-4548-4150-b926-383c038b36c0 .ag-row[role='row']@ROWINDEX [col-id='cReleaseDate']","",false, this.CurrentView);
 
            TimeRepetitionValue = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenancePlanEntityView>("","#72e3237e-4548-4150-b926-383c038b36c0 .ag-row[role='row']@ROWINDEX [col-id='cTimeRepetitionValue']","",false, this.CurrentView);
 
            TimeUnit = RPSControlFactory.CreateRPSGridEnumComboBox<MaintenancePlanEntityView>("","#72e3237e-4548-4150-b926-383c038b36c0 .ag-row[role='row']@ROWINDEX [col-id='cTimeUnit']","",true, this.CurrentView);
 
            CalendarUnit = RPSControlFactory.CreateRPSGridEnumComboBox<MaintenancePlanEntityView>("","#72e3237e-4548-4150-b926-383c038b36c0 .ag-row[role='row']@ROWINDEX [col-id='cCalendarUnit']","",true, this.CurrentView);
 
            CounterRepetionValue = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenancePlanEntityView>("","#72e3237e-4548-4150-b926-383c038b36c0 .ag-row[role='row']@ROWINDEX [col-id='cCounterRepetionValue']","",false, this.CurrentView);
 
            LimitValue = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenancePlanEntityView>("","#72e3237e-4548-4150-b926-383c038b36c0 .ag-row[role='row']@ROWINDEX [col-id='cLimitValue']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<MaintenancePlanEntityView> ControlType { get; set; } 
        public IRPSGridTextBox<MaintenancePlanEntityView> FixedDate { get; set; } 
        public IRPSGridTextBox<MaintenancePlanEntityView> ReleaseDate { get; set; } 
        public IRPSGridTextBox<MaintenancePlanEntityView> TimeRepetitionValue { get; set; } 
        public IRPSGridComboBox<MaintenancePlanEntityView> TimeUnit { get; set; } 
        public IRPSGridComboBox<MaintenancePlanEntityView> CalendarUnit { get; set; } 
        public IRPSGridTextBox<MaintenancePlanEntityView> CounterRepetionValue { get; set; } 
        public IRPSGridTextBox<MaintenancePlanEntityView> LimitValue { get; set; } 
                     
    }
 
        public partial class MaintenancePlanProceduresCollectionEditor<MaintenancePlanEntityView,MaintenancePlanPredictiveView>:RPSCollectionEditor<MaintenancePlanEntityView,MaintenancePlanPredictiveView> where MaintenancePlanEntityView : class, IView where MaintenancePlanPredictiveView : class, IView
    {
        public  MaintenancePlanProceduresGridView<MaintenancePlanEntityView,MaintenancePlanPredictiveView> GridView {get;set;}
    }
    public partial class MaintenancePlanProceduresGridView <MaintenancePlanEntityView,MaintenancePlanPredictiveView> :  RPSGridView<MaintenancePlanEntityView,MaintenancePlanPredictiveView> where MaintenancePlanEntityView : class, IView where MaintenancePlanPredictiveView : class, IView
    {
        public MaintenancePlanProceduresGridView(MaintenancePlanEntityView currentView,MaintenancePlanPredictiveView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDMaintenanceProcedure = RPSControlFactory.CreateRPSGridComboBox<MaintenancePlanEntityView>("","#11ff7601-c652-4983-87b9-0c353e81e629 .ag-row[role='row']@ROWINDEX [col-id='cIDMaintenanceProcedure']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<MaintenancePlanEntityView>("","#11ff7601-c652-4983-87b9-0c353e81e629 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<MaintenancePlanEntityView> IDMaintenanceProcedure { get; set; } 
        public IRPSGridTextBox<MaintenancePlanEntityView> Description { get; set; } 
                     
    }
 
        public partial class MaintenancePlanMaterialsCollectionEditor<MaintenancePlanEntityView,MaintenancePlanPredictiveView>:RPSCollectionEditor<MaintenancePlanEntityView,MaintenancePlanPredictiveView> where MaintenancePlanEntityView : class, IView where MaintenancePlanPredictiveView : class, IView
    {
        public  MaintenancePlanMaterialsGridView<MaintenancePlanEntityView,MaintenancePlanPredictiveView> GridView {get;set;}
    }
    public partial class MaintenancePlanMaterialsGridView <MaintenancePlanEntityView,MaintenancePlanPredictiveView> :  RPSGridView<MaintenancePlanEntityView,MaintenancePlanPredictiveView> where MaintenancePlanEntityView : class, IView where MaintenancePlanPredictiveView : class, IView
    {
        public MaintenancePlanMaterialsGridView(MaintenancePlanEntityView currentView,MaintenancePlanPredictiveView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<MaintenancePlanEntityView>("","#254cd91e-415c-422e-a5c1-e8a8c8f2a525 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenancePlanEntityView>("","#254cd91e-415c-422e-a5c1-e8a8c8f2a525 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            CostPrice = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenancePlanEntityView>("","#254cd91e-415c-422e-a5c1-e8a8c8f2a525 .ag-row[role='row']@ROWINDEX [col-id='cCostPrice']","",true, this.CurrentView);
 
            MakeMovement = RPSControlFactory.CreateRPSGridCheckBox<MaintenancePlanEntityView>("","#254cd91e-415c-422e-a5c1-e8a8c8f2a525 .ag-row[role='row']@ROWINDEX [col-id='cMakeMovement']","",true, this.CurrentView);
 
            Comments = RPSControlFactory.CreateRPSGridMemoTextBox<MaintenancePlanEntityView>("","#254cd91e-415c-422e-a5c1-e8a8c8f2a525 .ag-row[role='row']@ROWINDEX [col-id='cComments']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<MaintenancePlanEntityView> IDArticle { get; set; } 
        public IRPSGridTextBox<MaintenancePlanEntityView> Quantity { get; set; } 
        public IRPSGridTextBox<MaintenancePlanEntityView> CostPrice { get; set; } 
        public IRPSGridCheckbox<MaintenancePlanEntityView> MakeMovement { get; set; } 
        public IRPSGridTextBox<MaintenancePlanEntityView> Comments { get; set; } 
                     
    }
 
        public partial class MaintenancePlanSubcontractsCollectionEditor<MaintenancePlanEntityView,MaintenancePlanPredictiveView>:RPSCollectionEditor<MaintenancePlanEntityView,MaintenancePlanPredictiveView> where MaintenancePlanEntityView : class, IView where MaintenancePlanPredictiveView : class, IView
    {
        public  MaintenancePlanSubcontractsGridView<MaintenancePlanEntityView,MaintenancePlanPredictiveView> GridView {get;set;}
    }
    public partial class MaintenancePlanSubcontractsGridView <MaintenancePlanEntityView,MaintenancePlanPredictiveView> :  RPSGridView<MaintenancePlanEntityView,MaintenancePlanPredictiveView> where MaintenancePlanEntityView : class, IView where MaintenancePlanPredictiveView : class, IView
    {
        public MaintenancePlanSubcontractsGridView(MaintenancePlanEntityView currentView,MaintenancePlanPredictiveView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<MaintenancePlanEntityView>("","#4389e7f5-6402-49d4-8b49-416cf74301b8 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            IDSupplier = RPSControlFactory.CreateRPSGridComboBox<MaintenancePlanEntityView>("","#4389e7f5-6402-49d4-8b49-416cf74301b8 .ag-row[role='row']@ROWINDEX [col-id='cIDSupplier']","",true, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenancePlanEntityView>("","#4389e7f5-6402-49d4-8b49-416cf74301b8 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            CostPrice = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenancePlanEntityView>("","#4389e7f5-6402-49d4-8b49-416cf74301b8 .ag-row[role='row']@ROWINDEX [col-id='cCostPrice']","",true, this.CurrentView);
 
            Comments = RPSControlFactory.CreateRPSGridMemoTextBox<MaintenancePlanEntityView>("","#4389e7f5-6402-49d4-8b49-416cf74301b8 .ag-row[role='row']@ROWINDEX [col-id='cComments']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<MaintenancePlanEntityView> IDArticle { get; set; } 
        public IRPSGridComboBox<MaintenancePlanEntityView> IDSupplier { get; set; } 
        public IRPSGridTextBox<MaintenancePlanEntityView> Quantity { get; set; } 
        public IRPSGridTextBox<MaintenancePlanEntityView> CostPrice { get; set; } 
        public IRPSGridTextBox<MaintenancePlanEntityView> Comments { get; set; } 
                     
    }
 
        public partial class MaintenancePlanResourcesCollectionEditor<MaintenancePlanEntityView,MaintenancePlanPredictiveView>:RPSCollectionEditor<MaintenancePlanEntityView,MaintenancePlanPredictiveView> where MaintenancePlanEntityView : class, IView where MaintenancePlanPredictiveView : class, IView
    {
        public  MaintenancePlanResourcesGridView<MaintenancePlanEntityView,MaintenancePlanPredictiveView> GridView {get;set;}
    }
    public partial class MaintenancePlanResourcesGridView <MaintenancePlanEntityView,MaintenancePlanPredictiveView> :  RPSGridView<MaintenancePlanEntityView,MaintenancePlanPredictiveView> where MaintenancePlanEntityView : class, IView where MaintenancePlanPredictiveView : class, IView
    {
        public MaintenancePlanResourcesGridView(MaintenancePlanEntityView currentView,MaintenancePlanPredictiveView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDMaintenanceResource = RPSControlFactory.CreateRPSGridComboBox<MaintenancePlanEntityView>("","#6fd04721-fb9d-4cc7-8e58-1084acf57ed2 .ag-row[role='row']@ROWINDEX [col-id='cIDMaintenanceResource']","",true, this.CurrentView);
 
            PlannedTime = RPSControlFactory.CreateRPSGridDurationTextBox<MaintenancePlanEntityView>("","#6fd04721-fb9d-4cc7-8e58-1084acf57ed2 .ag-row[role='row']@ROWINDEX [col-id='cPlannedTime']","",true, this.CurrentView);
 
            CostPrice = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenancePlanEntityView>("","#6fd04721-fb9d-4cc7-8e58-1084acf57ed2 .ag-row[role='row']@ROWINDEX [col-id='cCostPrice']","",true, this.CurrentView);
 
            Planning = RPSControlFactory.CreateRPSGridCheckBox<MaintenancePlanEntityView>("","#6fd04721-fb9d-4cc7-8e58-1084acf57ed2 .ag-row[role='row']@ROWINDEX [col-id='cPlanning']","",true, this.CurrentView);
 
            DedicationPercentage = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenancePlanEntityView>("","#6fd04721-fb9d-4cc7-8e58-1084acf57ed2 .ag-row[role='row']@ROWINDEX [col-id='cDedicationPercentage']","",true, this.CurrentView);
 
            Comments = RPSControlFactory.CreateRPSGridMemoTextBox<MaintenancePlanEntityView>("","#6fd04721-fb9d-4cc7-8e58-1084acf57ed2 .ag-row[role='row']@ROWINDEX [col-id='cComments']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<MaintenancePlanEntityView> IDMaintenanceResource { get; set; } 
        public IRPSGridDurationTextBox<MaintenancePlanEntityView> PlannedTime { get; set; } 
        public IRPSGridTextBox<MaintenancePlanEntityView> CostPrice { get; set; } 
        public IRPSGridCheckbox<MaintenancePlanEntityView> Planning { get; set; } 
        public IRPSGridTextBox<MaintenancePlanEntityView> DedicationPercentage { get; set; } 
        public IRPSGridTextBox<MaintenancePlanEntityView> Comments { get; set; } 
                     
    }
 
        public partial class MANMaintenancePlanStaffsCollectionEditor<MaintenancePlanEntityView,MaintenancePlanPredictiveView>:RPSCollectionEditor<MaintenancePlanEntityView,MaintenancePlanPredictiveView> where MaintenancePlanEntityView : class, IView where MaintenancePlanPredictiveView : class, IView
    {
        public  MANMaintenancePlanStaffsGridView<MaintenancePlanEntityView,MaintenancePlanPredictiveView> GridView {get;set;}
    }
    public partial class MANMaintenancePlanStaffsGridView <MaintenancePlanEntityView,MaintenancePlanPredictiveView> :  RPSGridView<MaintenancePlanEntityView,MaintenancePlanPredictiveView> where MaintenancePlanEntityView : class, IView where MaintenancePlanPredictiveView : class, IView
    {
        public MANMaintenancePlanStaffsGridView(MaintenancePlanEntityView currentView,MaintenancePlanPredictiveView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDQualify = RPSControlFactory.CreateRPSGridComboBox<MaintenancePlanEntityView>("","#e59d8430-932b-4a1d-99ef-b4cca6bc63f7 .ag-row[role='row']@ROWINDEX [col-id='cIDQualify']","",true, this.CurrentView);
 
            IDEmployee = RPSControlFactory.CreateRPSGridComboBox<MaintenancePlanEntityView>("","#e59d8430-932b-4a1d-99ef-b4cca6bc63f7 .ag-row[role='row']@ROWINDEX [col-id='cIDEmployee']","",false, this.CurrentView);
 
            PeopleNumber = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenancePlanEntityView>("","#e59d8430-932b-4a1d-99ef-b4cca6bc63f7 .ag-row[role='row']@ROWINDEX [col-id='cPeopleNumber']","",true, this.CurrentView);
 
            TimePerPerson = RPSControlFactory.CreateRPSGridDurationTextBox<MaintenancePlanEntityView>("","#e59d8430-932b-4a1d-99ef-b4cca6bc63f7 .ag-row[role='row']@ROWINDEX [col-id='cTimePerPerson']","",true, this.CurrentView);
 
            TimePerQualification = RPSControlFactory.CreateRPSGridDurationTextBox<MaintenancePlanEntityView>("","#e59d8430-932b-4a1d-99ef-b4cca6bc63f7 .ag-row[role='row']@ROWINDEX [col-id='cTimePerQualification']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<MaintenancePlanEntityView> IDQualify { get; set; } 
        public IRPSGridComboBox<MaintenancePlanEntityView> IDEmployee { get; set; } 
        public IRPSGridTextBox<MaintenancePlanEntityView> PeopleNumber { get; set; } 
        public IRPSGridDurationTextBox<MaintenancePlanEntityView> TimePerPerson { get; set; } 
        public IRPSGridDurationTextBox<MaintenancePlanEntityView> TimePerQualification { get; set; } 
                     
    }
 
        public partial class MaintenancePlanExpensessCollectionEditor<MaintenancePlanEntityView,MaintenancePlanPredictiveView>:RPSCollectionEditor<MaintenancePlanEntityView,MaintenancePlanPredictiveView> where MaintenancePlanEntityView : class, IView where MaintenancePlanPredictiveView : class, IView
    {
        public  MaintenancePlanExpensessGridView<MaintenancePlanEntityView,MaintenancePlanPredictiveView> GridView {get;set;}
    }
    public partial class MaintenancePlanExpensessGridView <MaintenancePlanEntityView,MaintenancePlanPredictiveView> :  RPSGridView<MaintenancePlanEntityView,MaintenancePlanPredictiveView> where MaintenancePlanEntityView : class, IView where MaintenancePlanPredictiveView : class, IView
    {
        public MaintenancePlanExpensessGridView(MaintenancePlanEntityView currentView,MaintenancePlanPredictiveView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<MaintenancePlanEntityView>("","#2a1e3532-ad05-43ba-a73e-cd098948a6f8 .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<MaintenancePlanEntityView>("","#2a1e3532-ad05-43ba-a73e-cd098948a6f8 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenancePlanEntityView>("","#2a1e3532-ad05-43ba-a73e-cd098948a6f8 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            CostPrice = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenancePlanEntityView>("","#2a1e3532-ad05-43ba-a73e-cd098948a6f8 .ag-row[role='row']@ROWINDEX [col-id='cCostPrice']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<MaintenancePlanEntityView> Type { get; set; } 
        public IRPSGridTextBox<MaintenancePlanEntityView> Description { get; set; } 
        public IRPSGridTextBox<MaintenancePlanEntityView> Quantity { get; set; } 
        public IRPSGridTextBox<MaintenancePlanEntityView> CostPrice { get; set; } 
                     
    }
 
        public partial class MaintenancePlanPredictives1CollectionEditor<MaintenancePlanEntityView,MaintenancePlanPredictiveView>:RPSCollectionEditor<MaintenancePlanEntityView,MaintenancePlanPredictiveView> where MaintenancePlanEntityView : class, IView where MaintenancePlanPredictiveView : class, IView
    {
        public  MaintenancePlanPredictives1GridView<MaintenancePlanEntityView,MaintenancePlanPredictiveView> GridView {get;set;}
    }
    public partial class MaintenancePlanPredictives1GridView <MaintenancePlanEntityView,MaintenancePlanPredictiveView> :  RPSGridView<MaintenancePlanEntityView,MaintenancePlanPredictiveView> where MaintenancePlanEntityView : class, IView where MaintenancePlanPredictiveView : class, IView
    {
        public MaintenancePlanPredictives1GridView(MaintenancePlanEntityView currentView,MaintenancePlanPredictiveView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ControlFeatureCode = RPSControlFactory.CreateRPSGridTextBox<MaintenancePlanEntityView>("","#0e1bf02c-0f83-44da-bcc3-92766b4e48c9 .ag-row[role='row']@ROWINDEX [col-id='cControlFeatureCode']","",true, this.CurrentView);
 
            ControlFeatureDesc = RPSControlFactory.CreateRPSGridTextBox<MaintenancePlanEntityView>("","#0e1bf02c-0f83-44da-bcc3-92766b4e48c9 .ag-row[role='row']@ROWINDEX [col-id='cControlFeatureDesc']","",false, this.CurrentView);
 
            ControlType = RPSControlFactory.CreateRPSGridEnumComboBox<MaintenancePlanEntityView>("","#0e1bf02c-0f83-44da-bcc3-92766b4e48c9 .ag-row[role='row']@ROWINDEX [col-id='cControlType']","",true, this.CurrentView);
 
            MinimunValue = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenancePlanEntityView>("","#0e1bf02c-0f83-44da-bcc3-92766b4e48c9 .ag-row[role='row']@ROWINDEX [col-id='cMinimunValue']","",true, this.CurrentView);
 
            MaximunValue = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenancePlanEntityView>("","#0e1bf02c-0f83-44da-bcc3-92766b4e48c9 .ag-row[role='row']@ROWINDEX [col-id='cMaximunValue']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<MaintenancePlanEntityView> ControlFeatureCode { get; set; } 
        public IRPSGridTextBox<MaintenancePlanEntityView> ControlFeatureDesc { get; set; } 
        public IRPSGridComboBox<MaintenancePlanEntityView> ControlType { get; set; } 
        public IRPSGridTextBox<MaintenancePlanEntityView> MinimunValue { get; set; } 
        public IRPSGridTextBox<MaintenancePlanEntityView> MaximunValue { get; set; } 
                     
    }
 
    }
  
            
    public partial class MaintenancePlanPredictiveView : View
    {
        public MaintenancePlanPredictiveView(AllMaintenancePlans screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenancePlanPredictiveView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenancePlanPredictiveView,MaintenancePlanEntityView>( this,Screen.MaintenancePlanEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenancePlanPredictiveView,MaintenancePlanEntityView>( this,Screen.MaintenancePlanEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MaintenancePlanPredictiveView,MaintenancePlanEntityView>( this,Screen.MaintenancePlanEntityView);
 
            ControlFeatureCode = RPSControlFactory.CreateRPSTextBox<MaintenancePlanPredictiveView>("99a241f5-bb2d-4eaf-b2ed-e7d92fb5204f","","",true, this);
 
            ControlFeatureDesc = RPSControlFactory.CreateRPSTextBox<MaintenancePlanPredictiveView>("d24f3c01-3c0b-4c80-a67c-410ceb617e26","","",false, this);
 
            ControlType = RPSControlFactory.CreateRPSEnumComboBox<MaintenancePlanPredictiveView>("00825739-3e14-48eb-bfd5-ff411940d233","","",true, this);
 
            MinimunValue = RPSControlFactory.CreateRPSFormattedTextBox<MaintenancePlanPredictiveView>("a4e9cab9-09d5-4026-b88d-dd28ea410176","","",true, this);
 
            MaximunValue = RPSControlFactory.CreateRPSFormattedTextBox<MaintenancePlanPredictiveView>("e2561477-2c53-4ee9-96df-3b55ae30889a","","",true, this);
 
            Accuracy = RPSControlFactory.CreateRPSTextBox<MaintenancePlanPredictiveView>("9f406505-1b42-4736-9de2-14cebb540234","","",false, this);
 
            Precision = RPSControlFactory.CreateRPSTextBox<MaintenancePlanPredictiveView>("515d25ef-81a3-46d7-bcf4-a84265033dfa","","",false, this);
 
            IDControlMethod = RPSControlFactory.CreateRPSComboBox<MaintenancePlanPredictiveView>("bae41a5b-747d-4989-8853-8ff622d15346","","",false, this);
 
            IDTestMethod = RPSControlFactory.CreateRPSComboBox<MaintenancePlanPredictiveView>("05662a5e-795a-4f2c-bed2-0f82efb0d96e","","",false, this);
 

        }
        public IRPSButton<MaintenancePlanPredictiveView> DeleteButton { get; set; } 
        public IRPSButton<MaintenancePlanPredictiveView,MaintenancePlanEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenancePlanPredictiveView,MaintenancePlanEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<MaintenancePlanPredictiveView,MaintenancePlanEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<MaintenancePlanPredictiveView> ControlFeatureCode { get; set; } 
        public IRPSTextBox<MaintenancePlanPredictiveView> ControlFeatureDesc { get; set; } 
        public IRPSComboBox<MaintenancePlanPredictiveView> ControlType { get; set; } 
        public IRPSTextBox<MaintenancePlanPredictiveView> MinimunValue { get; set; } 
        public IRPSTextBox<MaintenancePlanPredictiveView> MaximunValue { get; set; } 
        public IRPSTextBox<MaintenancePlanPredictiveView> Accuracy { get; set; } 
        public IRPSTextBox<MaintenancePlanPredictiveView> Precision { get; set; } 
        public IRPSComboBox<MaintenancePlanPredictiveView> IDControlMethod { get; set; } 
        public IRPSComboBox<MaintenancePlanPredictiveView> IDTestMethod { get; set; } 
        public AllMaintenancePlans Screen { get; set; }
        public MaintenancePlanPredictiveView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenancePlanProcedureView : View
    {
        public MaintenancePlanProcedureView(AllMaintenancePlans screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenancePlanProcedureView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenancePlanProcedureView,MaintenancePlanEntityView>( this,Screen.MaintenancePlanEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenancePlanProcedureView,MaintenancePlanEntityView>( this,Screen.MaintenancePlanEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MaintenancePlanProcedureView,MaintenancePlanEntityView>( this,Screen.MaintenancePlanEntityView);
 
            IDMaintenanceProcedure = RPSControlFactory.CreateRPSComboBox<MaintenancePlanProcedureView>("0b98af17-b7b9-4d9a-afee-b77aa5efd8b7","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MaintenancePlanProcedureView>("df9526e1-f4f2-4153-ba9b-67238d451c1b","","",false, this);
 
            CollectionInit params_MANMaintenancePlanProcTasks = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6ce5f5de-f9d7-4c6b-b950-efabfb819791",CSSSelectorGrid="",XPathGrid=""};
            MANMaintenancePlanProcTasks = RPSControlFactory.RPSCreateCollectionWithGrid<MANMaintenancePlanProcTasksCollectionEditor<MaintenancePlanProcedureView,MaintenancePlanProcTaskView>,MaintenancePlanProcedureView,MaintenancePlanProcTaskView>( params_MANMaintenancePlanProcTasks,this,Screen.MaintenancePlanProcTaskView);
 

        }
        public IRPSButton<MaintenancePlanProcedureView> DeleteButton { get; set; } 
        public IRPSButton<MaintenancePlanProcedureView,MaintenancePlanEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenancePlanProcedureView,MaintenancePlanEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<MaintenancePlanProcedureView,MaintenancePlanEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<MaintenancePlanProcedureView> IDMaintenanceProcedure { get; set; } 
        public IRPSTextBox<MaintenancePlanProcedureView> Description { get; set; } 
        public MANMaintenancePlanProcTasksCollectionEditor<MaintenancePlanProcedureView,MaintenancePlanProcTaskView> MANMaintenancePlanProcTasks { get; set; } 
        public AllMaintenancePlans Screen { get; set; }
        public MaintenancePlanProcedureView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MANMaintenancePlanProcTasksCollectionEditor<MaintenancePlanProcedureView,MaintenancePlanProcTaskView>:RPSCollectionEditor<MaintenancePlanProcedureView,MaintenancePlanProcTaskView> where MaintenancePlanProcedureView : class, IView where MaintenancePlanProcTaskView : class, IView
    {
        public  MANMaintenancePlanProcTasksGridView<MaintenancePlanProcedureView,MaintenancePlanProcTaskView> GridView {get;set;}
    }
    public partial class MANMaintenancePlanProcTasksGridView <MaintenancePlanProcedureView,MaintenancePlanProcTaskView> :  RPSGridView<MaintenancePlanProcedureView,MaintenancePlanProcTaskView> where MaintenancePlanProcedureView : class, IView where MaintenancePlanProcTaskView : class, IView
    {
        public MANMaintenancePlanProcTasksGridView(MaintenancePlanProcedureView currentView,MaintenancePlanProcTaskView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDMaintenanceProcTask = RPSControlFactory.CreateRPSGridComboBox<MaintenancePlanProcedureView>("","#6ce5f5de-f9d7-4c6b-b950-efabfb819791 .ag-row[role='row']@ROWINDEX [col-id='cIDMaintenanceProcTask']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<MaintenancePlanProcedureView>("","#6ce5f5de-f9d7-4c6b-b950-efabfb819791 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Duration = RPSControlFactory.CreateRPSGridDurationTextBox<MaintenancePlanProcedureView>("","#6ce5f5de-f9d7-4c6b-b950-efabfb819791 .ag-row[role='row']@ROWINDEX [col-id='cDuration']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<MaintenancePlanProcedureView> IDMaintenanceProcTask { get; set; } 
        public IRPSGridTextBox<MaintenancePlanProcedureView> Description { get; set; } 
        public IRPSGridDurationTextBox<MaintenancePlanProcedureView> Duration { get; set; } 
                     
    }
 
    }
  
            
    public partial class MaintenancePlanProcTaskView : View
    {
        public MaintenancePlanProcTaskView(AllMaintenancePlans screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenancePlanProcTaskView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenancePlanProcTaskView,MaintenancePlanProcedureView>( this,Screen.MaintenancePlanProcedureView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenancePlanProcTaskView,MaintenancePlanProcedureView>( this,Screen.MaintenancePlanProcedureView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MaintenancePlanProcTaskView,MaintenancePlanProcedureView>( this,Screen.MaintenancePlanProcedureView);
 
            IDMaintenanceProcTask = RPSControlFactory.CreateRPSComboBox<MaintenancePlanProcTaskView>("6d4102c6-08f9-44a1-8ecb-5beea27b70b2","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MaintenancePlanProcTaskView>("ca320604-4de7-43d4-a78b-a8dc830be860","","",false, this);
 
            Duration = RPSControlFactory.CreateRPSDurationTextBox<MaintenancePlanProcTaskView>("7213dddc-6ea0-4047-b432-5388f6cd2a4d","","",false, this);
 

        }
        public IRPSButton<MaintenancePlanProcTaskView> DeleteButton { get; set; } 
        public IRPSButton<MaintenancePlanProcTaskView,MaintenancePlanProcedureView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenancePlanProcTaskView,MaintenancePlanProcedureView> BackButton { get; set; } 
        public IRPSAcceptButton<MaintenancePlanProcTaskView,MaintenancePlanProcedureView> AcceptButton { get; set; } 
        public IRPSComboBox<MaintenancePlanProcTaskView> IDMaintenanceProcTask { get; set; } 
        public IRPSTextBox<MaintenancePlanProcTaskView> Description { get; set; } 
        public IRPSDurationTextBox<MaintenancePlanProcTaskView> Duration { get; set; } 
        public AllMaintenancePlans Screen { get; set; }
        public MaintenancePlanProcTaskView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenancePlanResourceView : View
    {
        public MaintenancePlanResourceView(AllMaintenancePlans screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenancePlanResourceView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenancePlanResourceView,MaintenancePlanEntityView>( this,Screen.MaintenancePlanEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenancePlanResourceView,MaintenancePlanEntityView>( this,Screen.MaintenancePlanEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MaintenancePlanResourceView,MaintenancePlanEntityView>( this,Screen.MaintenancePlanEntityView);
 
            IDMaintenanceResource = RPSControlFactory.CreateRPSComboBox<MaintenancePlanResourceView>("193009d9-7c98-4c82-9506-6f1ba5bef37e","","",true, this);
 
            PlannedTime = RPSControlFactory.CreateRPSDurationTextBox<MaintenancePlanResourceView>("2f473d80-f964-4aaa-9bb4-5244004f064b","","",true, this);
 
            CostPrice = RPSControlFactory.CreateRPSFormattedTextBox<MaintenancePlanResourceView>("10958549-dec6-40d6-b356-61a490c46966","","",true, this);
 
            DedicationPercentage = RPSControlFactory.CreateRPSFormattedTextBox<MaintenancePlanResourceView>("00d370fd-e68f-452c-8614-d0d5218ddead","","",true, this);
 
            Planning = RPSControlFactory.CreateRPSCheckBox<MaintenancePlanResourceView>("a03f216e-4fa6-466f-8e26-c53e12551a27","","",true, this);
 
            Comments = RPSControlFactory.CreateRPSTextBox<MaintenancePlanResourceView>("1c66244e-d773-4e2b-a1b1-50cacadf9869","","",false, this);
 

        }
        public IRPSButton<MaintenancePlanResourceView> DeleteButton { get; set; } 
        public IRPSButton<MaintenancePlanResourceView,MaintenancePlanEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenancePlanResourceView,MaintenancePlanEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<MaintenancePlanResourceView,MaintenancePlanEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<MaintenancePlanResourceView> IDMaintenanceResource { get; set; } 
        public IRPSDurationTextBox<MaintenancePlanResourceView> PlannedTime { get; set; } 
        public IRPSTextBox<MaintenancePlanResourceView> CostPrice { get; set; } 
        public IRPSTextBox<MaintenancePlanResourceView> DedicationPercentage { get; set; } 
        public IRPSCheckbox<MaintenancePlanResourceView> Planning { get; set; } 
        public IRPSTextBox<MaintenancePlanResourceView> Comments { get; set; } 
        public AllMaintenancePlans Screen { get; set; }
        public MaintenancePlanResourceView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenancePlanSubcontractView : View
    {
        public MaintenancePlanSubcontractView(AllMaintenancePlans screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenancePlanSubcontractView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenancePlanSubcontractView,MaintenancePlanEntityView>( this,Screen.MaintenancePlanEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenancePlanSubcontractView,MaintenancePlanEntityView>( this,Screen.MaintenancePlanEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MaintenancePlanSubcontractView,MaintenancePlanEntityView>( this,Screen.MaintenancePlanEntityView);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<MaintenancePlanSubcontractView>("cebf5c79-b491-4362-b8fc-15cd79198dfd","","",true, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<MaintenancePlanSubcontractView>("2444e247-4f35-4b23-b100-ac745625485d","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<MaintenancePlanSubcontractView>("8e4ff944-ef36-474c-ba1f-599bff0f3981","","",true, this);
 
            CostPrice = RPSControlFactory.CreateRPSFormattedTextBox<MaintenancePlanSubcontractView>("5676f086-1432-4bdb-a766-5f6213706e8d","","",true, this);
 
            Comments = RPSControlFactory.CreateRPSTextBox<MaintenancePlanSubcontractView>("94499a8e-8489-40be-a847-cdd0873f9f91","","",false, this);
 

        }
        public IRPSButton<MaintenancePlanSubcontractView> DeleteButton { get; set; } 
        public IRPSButton<MaintenancePlanSubcontractView,MaintenancePlanEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenancePlanSubcontractView,MaintenancePlanEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<MaintenancePlanSubcontractView,MaintenancePlanEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<MaintenancePlanSubcontractView> IDArticle { get; set; } 
        public IRPSComboBox<MaintenancePlanSubcontractView> IDSupplier { get; set; } 
        public IRPSTextBox<MaintenancePlanSubcontractView> Quantity { get; set; } 
        public IRPSTextBox<MaintenancePlanSubcontractView> CostPrice { get; set; } 
        public IRPSTextBox<MaintenancePlanSubcontractView> Comments { get; set; } 
        public AllMaintenancePlans Screen { get; set; }
        public MaintenancePlanSubcontractView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenancePlanMaterialView : View
    {
        public MaintenancePlanMaterialView(AllMaintenancePlans screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenancePlanMaterialView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenancePlanMaterialView,MaintenancePlanEntityView>( this,Screen.MaintenancePlanEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenancePlanMaterialView,MaintenancePlanEntityView>( this,Screen.MaintenancePlanEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MaintenancePlanMaterialView,MaintenancePlanEntityView>( this,Screen.MaintenancePlanEntityView);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<MaintenancePlanMaterialView>("80fd0a6f-daa0-41e8-80e0-89cc371e951f","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<MaintenancePlanMaterialView>("17c629e8-d0e5-4e33-b28a-c540a6a44d8e","","",true, this);
 
            CostPrice = RPSControlFactory.CreateRPSFormattedTextBox<MaintenancePlanMaterialView>("42d5969b-2b54-4289-918b-20c9910eef9c","","",true, this);
 
            MakeMovement = RPSControlFactory.CreateRPSCheckBox<MaintenancePlanMaterialView>("4bb58d56-bd85-4673-aaeb-7ed452ed9f41","","",true, this);
 
            Comments = RPSControlFactory.CreateRPSTextBox<MaintenancePlanMaterialView>("4ba96aa8-fd42-4a0d-bd96-cdf485ca07de","","",false, this);
 

        }
        public IRPSButton<MaintenancePlanMaterialView> DeleteButton { get; set; } 
        public IRPSButton<MaintenancePlanMaterialView,MaintenancePlanEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenancePlanMaterialView,MaintenancePlanEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<MaintenancePlanMaterialView,MaintenancePlanEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<MaintenancePlanMaterialView> IDArticle { get; set; } 
        public IRPSTextBox<MaintenancePlanMaterialView> Quantity { get; set; } 
        public IRPSTextBox<MaintenancePlanMaterialView> CostPrice { get; set; } 
        public IRPSCheckbox<MaintenancePlanMaterialView> MakeMovement { get; set; } 
        public IRPSTextBox<MaintenancePlanMaterialView> Comments { get; set; } 
        public AllMaintenancePlans Screen { get; set; }
        public MaintenancePlanMaterialView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenancePlanControlView : View
    {
        public MaintenancePlanControlView(AllMaintenancePlans screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenancePlanControlView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenancePlanControlView,MaintenancePlanEntityView>( this,Screen.MaintenancePlanEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenancePlanControlView,MaintenancePlanEntityView>( this,Screen.MaintenancePlanEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MaintenancePlanControlView,MaintenancePlanEntityView>( this,Screen.MaintenancePlanEntityView);
 
            ControlType = RPSControlFactory.CreateRPSEnumComboBox<MaintenancePlanControlView>("2c49d548-69c6-47a9-baf0-dcc5807cdef3","","",true, this);
 
            FixedDate = RPSControlFactory.CreateRPSTextBox<MaintenancePlanControlView>("f930871f-9aed-4cd8-ba62-6ad3f8e409d3","","",false, this);
 
            ReleaseDate = RPSControlFactory.CreateRPSTextBox<MaintenancePlanControlView>("1d6d5fdd-3761-4850-a9b1-39a57f8dd39e","","",false, this);
 
            TimeRepetitionValue = RPSControlFactory.CreateRPSFormattedTextBox<MaintenancePlanControlView>("7182d8da-c025-45b1-8141-f9c3a7fbe16f","","",false, this);
 
            TimeUnit = RPSControlFactory.CreateRPSEnumComboBox<MaintenancePlanControlView>("4d8963f5-90b3-4eb3-aba9-51d7792f7379","","",true, this);
 
            CalendarUnit = RPSControlFactory.CreateRPSEnumComboBox<MaintenancePlanControlView>("4c03f3be-9e63-4e38-844c-93fefdb29f1d","","",true, this);
 
            CounterRepetionValue = RPSControlFactory.CreateRPSFormattedTextBox<MaintenancePlanControlView>("f3d8a047-1bf6-4e42-a215-70224fb40d59","","",false, this);
 
            LimitValue = RPSControlFactory.CreateRPSFormattedTextBox<MaintenancePlanControlView>("a620263f-468b-4249-b411-b1729d597dbb","","",false, this);
 
            LastGeneratedOrderDate = RPSControlFactory.CreateRPSTextBox<MaintenancePlanControlView>("99bc9f5f-6cee-4e27-8f00-552e3438aa5f","","",true, this);
 
            LastGeneratedOrderTime = RPSControlFactory.CreateRPSTextBox<MaintenancePlanControlView>("69ab74a1-f79f-4ec0-a379-f4b796cea2df","","",true, this);
 

        }
        public IRPSButton<MaintenancePlanControlView> DeleteButton { get; set; } 
        public IRPSButton<MaintenancePlanControlView,MaintenancePlanEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenancePlanControlView,MaintenancePlanEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<MaintenancePlanControlView,MaintenancePlanEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<MaintenancePlanControlView> ControlType { get; set; } 
        public IRPSTextBox<MaintenancePlanControlView> FixedDate { get; set; } 
        public IRPSTextBox<MaintenancePlanControlView> ReleaseDate { get; set; } 
        public IRPSTextBox<MaintenancePlanControlView> TimeRepetitionValue { get; set; } 
        public IRPSComboBox<MaintenancePlanControlView> TimeUnit { get; set; } 
        public IRPSComboBox<MaintenancePlanControlView> CalendarUnit { get; set; } 
        public IRPSTextBox<MaintenancePlanControlView> CounterRepetionValue { get; set; } 
        public IRPSTextBox<MaintenancePlanControlView> LimitValue { get; set; } 
        public IRPSTextBox<MaintenancePlanControlView> LastGeneratedOrderDate { get; set; } 
        public IRPSTextBox<MaintenancePlanControlView> LastGeneratedOrderTime { get; set; } 
        public AllMaintenancePlans Screen { get; set; }
        public MaintenancePlanControlView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenancePlanStaffView : View
    {
        public MaintenancePlanStaffView(AllMaintenancePlans screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenancePlanStaffView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenancePlanStaffView,MaintenancePlanEntityView>( this,Screen.MaintenancePlanEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenancePlanStaffView,MaintenancePlanEntityView>( this,Screen.MaintenancePlanEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MaintenancePlanStaffView,MaintenancePlanEntityView>( this,Screen.MaintenancePlanEntityView);
 
            IDQualify = RPSControlFactory.CreateRPSComboBox<MaintenancePlanStaffView>("911eabcf-2264-48a2-8cb7-be4a5d003b6d","","",true, this);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<MaintenancePlanStaffView>("5ac977e4-e4b6-42fd-a5fa-9d93e80342c8","","",false, this);
 
            Planning = RPSControlFactory.CreateRPSCheckBox<MaintenancePlanStaffView>("9fb82504-4c95-4384-ac49-058f73a65344","","",true, this);
 
            PeopleNumber = RPSControlFactory.CreateRPSFormattedTextBox<MaintenancePlanStaffView>("9079e7c4-c4a0-42b0-bcd1-6d9cec765e3b","","",true, this);
 
            TimePerPerson = RPSControlFactory.CreateRPSDurationTextBox<MaintenancePlanStaffView>("ccdad657-7222-4645-b41d-a33339323625","","",true, this);
 
            TimePerQualification = RPSControlFactory.CreateRPSDurationTextBox<MaintenancePlanStaffView>("d269f7e9-2f4c-426b-b90d-311f9b61514b","","",true, this);
 
            CostPrice = RPSControlFactory.CreateRPSFormattedTextBox<MaintenancePlanStaffView>("fe424889-7346-418b-ad92-8965ff38ab00","","",true, this);
 
            DedicationPercentage = RPSControlFactory.CreateRPSFormattedTextBox<MaintenancePlanStaffView>("0b79f56a-63f4-4817-a12a-b70f4e727599","","",true, this);
 

        }
        public IRPSButton<MaintenancePlanStaffView> DeleteButton { get; set; } 
        public IRPSButton<MaintenancePlanStaffView,MaintenancePlanEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenancePlanStaffView,MaintenancePlanEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<MaintenancePlanStaffView,MaintenancePlanEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<MaintenancePlanStaffView> IDQualify { get; set; } 
        public IRPSComboBox<MaintenancePlanStaffView> IDEmployee { get; set; } 
        public IRPSCheckbox<MaintenancePlanStaffView> Planning { get; set; } 
        public IRPSTextBox<MaintenancePlanStaffView> PeopleNumber { get; set; } 
        public IRPSDurationTextBox<MaintenancePlanStaffView> TimePerPerson { get; set; } 
        public IRPSDurationTextBox<MaintenancePlanStaffView> TimePerQualification { get; set; } 
        public IRPSTextBox<MaintenancePlanStaffView> CostPrice { get; set; } 
        public IRPSTextBox<MaintenancePlanStaffView> DedicationPercentage { get; set; } 
        public AllMaintenancePlans Screen { get; set; }
        public MaintenancePlanStaffView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenancePlanExpensesView : View
    {
        public MaintenancePlanExpensesView(AllMaintenancePlans screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenancePlanExpensesView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenancePlanExpensesView,MaintenancePlanEntityView>( this,Screen.MaintenancePlanEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenancePlanExpensesView,MaintenancePlanEntityView>( this,Screen.MaintenancePlanEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MaintenancePlanExpensesView,MaintenancePlanEntityView>( this,Screen.MaintenancePlanEntityView);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<MaintenancePlanExpensesView>("5add41e7-de8c-4449-ac9e-4b5617024dba","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MaintenancePlanExpensesView>("4571f161-5d84-4d63-92b4-ff413f5037bf","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<MaintenancePlanExpensesView>("a18f71ec-0e4d-4452-b4e1-5e7ec4b2dc5c","","",true, this);
 
            CostPrice = RPSControlFactory.CreateRPSFormattedTextBox<MaintenancePlanExpensesView>("bddac3e3-84a0-4035-90d1-2937ff02a2f9","","",true, this);
 

        }
        public IRPSButton<MaintenancePlanExpensesView> DeleteButton { get; set; } 
        public IRPSButton<MaintenancePlanExpensesView,MaintenancePlanEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenancePlanExpensesView,MaintenancePlanEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<MaintenancePlanExpensesView,MaintenancePlanEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<MaintenancePlanExpensesView> Type { get; set; } 
        public IRPSTextBox<MaintenancePlanExpensesView> Description { get; set; } 
        public IRPSTextBox<MaintenancePlanExpensesView> Quantity { get; set; } 
        public IRPSTextBox<MaintenancePlanExpensesView> CostPrice { get; set; } 
        public AllMaintenancePlans Screen { get; set; }
        public MaintenancePlanExpensesView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}