    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Planification.ParameterPac
{
    //RPS VERSION 1.0.0.0
    public partial class ParameterPac:Screen
    {
        public ParameterPac():base()
        {
            this.URL = "planification.parameterpac";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ParameterPacEntityView  = new ParameterPacEntityView(this); 
            ParameterOptionsDialogView  = new ParameterOptionsDialogView(this); 
            ParameterPacEntityView.InitializeControls(); 
            ParameterOptionsDialogView.InitializeControls(); 
           
        }
      
            public ParameterPacEntityView ParameterPacEntityView {get; set; } 
            public ParameterOptionsDialogView ParameterOptionsDialogView {get; set; } 
    }
            
    public partial class ParameterPacEntityView : View
    {
        public ParameterPacEntityView(ParameterPac screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            TFixedColor = RPSControlFactory.CreateRPSColorEditor<ParameterPacEntityView>( "7e6a8c45-e8e0-4dd2-aa36-4ab55f81e86c","","",this);
 
            TDelayedColor = RPSControlFactory.CreateRPSColorEditor<ParameterPacEntityView>( "9a08a806-db20-418f-8b32-2cc038286cd2","","",this);
 
            TStartedColor = RPSControlFactory.CreateRPSColorEditor<ParameterPacEntityView>( "b64720fd-4b66-4a32-8fe0-7b7625835939","","",this);
 
            TMaintenanceColor = RPSControlFactory.CreateRPSColorEditor<ParameterPacEntityView>( "97cf08a4-f38c-4e4a-93bd-1556ad4f0556","","",this);
 
            DaysOfGrouping = RPSControlFactory.CreateRPSFormattedTextBox<ParameterPacEntityView>("e9460265-feba-439e-b7d4-be3a0544eda0","","",false, this);
 
            RemovePrepTime = RPSControlFactory.CreateRPSCheckBox<ParameterPacEntityView>("4763dbaf-4c76-4e18-aef3-be724594d961","","",false, this);
 
            IDResourceTypeOptimization = RPSControlFactory.CreateRPSComboBox<ParameterPacEntityView>("85b88879-5fd4-4959-8059-9e695abf8640","","",false, this);
 
            InitialCalendarSize = RPSControlFactory.CreateRPSFormattedTextBox<ParameterPacEntityView>("ba4c1b20-a6c6-47ec-9441-e52ec0dbead7","","",false, this);
 
            WindowSize = RPSControlFactory.CreateRPSFormattedTextBox<ParameterPacEntityView>("3ed5a1ed-c9ba-4966-8950-ccaba97da805","","",false, this);
 
            Precision2FromDays = RPSControlFactory.CreateRPSFormattedTextBox<ParameterPacEntityView>("afedf6e5-4d9f-4930-a05b-10d0e47b2aea","","",true, this);
 
            Precision = RPSControlFactory.CreateRPSFormattedTextBox<ParameterPacEntityView>("f82d5e6a-acbc-406a-871d-d82a0cae3110","","",false, this);
 
            Precision2 = RPSControlFactory.CreateRPSFormattedTextBox<ParameterPacEntityView>("5a566b6b-bf3b-4ff7-acfb-e51262156ca8","","",true, this);
 
            ResourceAssignmentType = RPSControlFactory.CreateRPSEnumComboBox<ParameterPacEntityView>("e77da60b-a25e-4bf1-b930-2dd7ea4df3c4","","",true, this);
 
            CapacityCalculationDays = RPSControlFactory.CreateRPSFormattedTextBox<ParameterPacEntityView>("71267c40-e049-4d44-ac05-0193167e5f14","","",true, this);
 
            PlanOrder = RPSControlFactory.CreateRPSTextBox<ParameterPacEntityView>("d7711eae-6f5e-4eb5-a8d7-c67e2fb87461","","",false, this);
 
            ParameterOptionsNavigationCommand = RPSControlFactory.CreateRPSButtonToView<ParameterPacEntityView,ParameterOptionsDialogView>("2ae5f3fd-a29e-4ff2-867d-d8c4277ad6cb","","", this,Screen.ParameterOptionsDialogView);
 
            GroupDaysArticle = RPSControlFactory.CreateRPSCheckBox<ParameterPacEntityView>("7ac8a4aa-1685-4bc1-8b65-18b9407f2aeb","","",true, this);
 
            GroupDays = RPSControlFactory.CreateRPSEnumComboBox<ParameterPacEntityView>("a5463978-e82c-4697-8171-c5e956e4668b","","",true, this);
 
            GroupDaysNumber = RPSControlFactory.CreateRPSFormattedTextBox<ParameterPacEntityView>("6b7ae051-5249-47c1-be38-08b452de73d8","","",true, this);
 
            GroupAdjust = RPSControlFactory.CreateRPSEnumComboBox<ParameterPacEntityView>("732dcc55-f171-4295-a95e-3faddb06a147","","",true, this);
 
            FirstDayOfWeek = RPSControlFactory.CreateRPSEnumComboBox<ParameterPacEntityView>("7434c7b2-d9dd-47c6-aa83-a095faa6aa8d","","",true, this);
 
            StartDayWorkWeek = RPSControlFactory.CreateRPSEnumComboBox<ParameterPacEntityView>("15ef8575-3760-4e16-b486-f751be99f67c","","",true, this);
 
            EndDayWorkWeek = RPSControlFactory.CreateRPSEnumComboBox<ParameterPacEntityView>("266569b4-08fa-4139-9193-fd4a1a315402","","",true, this);
 
            AdjustStockMRPStart = RPSControlFactory.CreateRPSCheckBox<ParameterPacEntityView>("6ffa534b-3bbf-4cba-9b9f-eecbb0da1142","","",true, this);
 
            PlanningDirectionNewMO = RPSControlFactory.CreateRPSEnumComboBox<ParameterPacEntityView>("56a8a52b-dde0-4d4b-af4c-9c3f51225aa7","","",true, this);
 
            SaveInMRP = RPSControlFactory.CreateRPSCheckBox<ParameterPacEntityView>("38e53601-7dcf-4d36-b642-373099dbbdff","","",true, this);
 
            SchedulerTaskSeparator = RPSControlFactory.CreateRPSTextBox<ParameterPacEntityView>("c9798954-2953-45da-be17-4375109e4444","","",false, this);
 
            OneRightComm = RPSControlFactory.CreateRPSButton<ParameterPacEntityView>( "171b053f-75a5-42cc-b20d-8e27d746143a","","",this);
 
            OneLeftComm = RPSControlFactory.CreateRPSButton<ParameterPacEntityView>( "a43d5485-27c3-478f-8393-4811ca330f5c","","",this);
 
            AllRightComm = RPSControlFactory.CreateRPSButton<ParameterPacEntityView>( "21312bbb-fae7-4ed1-bf3e-3d254bb9eb62","","",this);
 
            AllLeftComm = RPSControlFactory.CreateRPSButton<ParameterPacEntityView>( "c142e052-75c2-4b32-9fe5-54190ebb7e83","","",this);
 
            CollectionInit params_AvailableDescriptionsCollection = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0ca72419-0423-49da-a0ea-e3b5e785cb0d",CSSSelectorGrid="",XPathGrid=""};
            AvailableDescriptionsCollection = RPSControlFactory.RPSCreateCollectionWithGrid<AvailableDescriptionsCollectionCollectionEditor<ParameterPacEntityView,ParameterOptionsDialogView>,ParameterPacEntityView,ParameterOptionsDialogView>( params_AvailableDescriptionsCollection,this,Screen.ParameterOptionsDialogView);
 
            CollectionInit params_SelectedDescriptionsCollection = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b3774a6e-740e-47f2-a39d-8b39145545f1",CSSSelectorGrid="",XPathGrid=""};
            SelectedDescriptionsCollection = RPSControlFactory.RPSCreateCollectionWithGrid<SelectedDescriptionsCollectionCollectionEditor<ParameterPacEntityView,ParameterOptionsDialogView>,ParameterPacEntityView,ParameterOptionsDialogView>( params_SelectedDescriptionsCollection,this,Screen.ParameterOptionsDialogView);
 
            SectionGeneral = RPSControlFactory.CreateRPSSection<ParameterPacEntityView>( "","ul li[rpsid='12ac6dba-6309-42a8-95b7-db2409487845']","",this);
 
            SectionSchedulerTaskInfo = RPSControlFactory.CreateRPSSection<ParameterPacEntityView>( "","ul li[rpsid='5c4c49be-3fd6-4d80-8098-5dcd10c1d75f']","",this);
 

        }
        public IRPSColorEditor<ParameterPacEntityView> TFixedColor { get; set; } 
        public IRPSColorEditor<ParameterPacEntityView> TDelayedColor { get; set; } 
        public IRPSColorEditor<ParameterPacEntityView> TStartedColor { get; set; } 
        public IRPSColorEditor<ParameterPacEntityView> TMaintenanceColor { get; set; } 
        public IRPSTextBox<ParameterPacEntityView> DaysOfGrouping { get; set; } 
        public IRPSCheckbox<ParameterPacEntityView> RemovePrepTime { get; set; } 
        public IRPSComboBox<ParameterPacEntityView> IDResourceTypeOptimization { get; set; } 
        public IRPSTextBox<ParameterPacEntityView> InitialCalendarSize { get; set; } 
        public IRPSTextBox<ParameterPacEntityView> WindowSize { get; set; } 
        public IRPSTextBox<ParameterPacEntityView> Precision2FromDays { get; set; } 
        public IRPSTextBox<ParameterPacEntityView> Precision { get; set; } 
        public IRPSTextBox<ParameterPacEntityView> Precision2 { get; set; } 
        public IRPSComboBox<ParameterPacEntityView> ResourceAssignmentType { get; set; } 
        public IRPSTextBox<ParameterPacEntityView> CapacityCalculationDays { get; set; } 
        public IRPSTextBox<ParameterPacEntityView> PlanOrder { get; set; } 
        public IRPSButton<ParameterPacEntityView,ParameterOptionsDialogView> ParameterOptionsNavigationCommand { get; set; } 
        public IRPSCheckbox<ParameterPacEntityView> GroupDaysArticle { get; set; } 
        public IRPSComboBox<ParameterPacEntityView> GroupDays { get; set; } 
        public IRPSTextBox<ParameterPacEntityView> GroupDaysNumber { get; set; } 
        public IRPSComboBox<ParameterPacEntityView> GroupAdjust { get; set; } 
        public IRPSComboBox<ParameterPacEntityView> FirstDayOfWeek { get; set; } 
        public IRPSComboBox<ParameterPacEntityView> StartDayWorkWeek { get; set; } 
        public IRPSComboBox<ParameterPacEntityView> EndDayWorkWeek { get; set; } 
        public IRPSCheckbox<ParameterPacEntityView> AdjustStockMRPStart { get; set; } 
        public IRPSComboBox<ParameterPacEntityView> PlanningDirectionNewMO { get; set; } 
        public IRPSCheckbox<ParameterPacEntityView> SaveInMRP { get; set; } 
        public IRPSTextBox<ParameterPacEntityView> SchedulerTaskSeparator { get; set; } 
        public IRPSButton<ParameterPacEntityView> OneRightComm { get; set; } 
        public IRPSButton<ParameterPacEntityView> OneLeftComm { get; set; } 
        public IRPSButton<ParameterPacEntityView> AllRightComm { get; set; } 
        public IRPSButton<ParameterPacEntityView> AllLeftComm { get; set; } 
        public AvailableDescriptionsCollectionCollectionEditor<ParameterPacEntityView,ParameterOptionsDialogView> AvailableDescriptionsCollection { get; set; } 
        public SelectedDescriptionsCollectionCollectionEditor<ParameterPacEntityView,ParameterOptionsDialogView> SelectedDescriptionsCollection { get; set; } 
        public IRPSSection<ParameterPacEntityView> SectionGeneral { get; set; } 
        public IRPSSection<ParameterPacEntityView> SectionSchedulerTaskInfo { get; set; } 
        public ParameterPac Screen { get; set; }
        public ParameterPacEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class AvailableDescriptionsCollectionCollectionEditor<ParameterPacEntityView,ParameterOptionsDialogView>:RPSCollectionEditor<ParameterPacEntityView,ParameterOptionsDialogView> where ParameterPacEntityView : class, IView where ParameterOptionsDialogView : class, IView
    {
        public  AvailableDescriptionsCollectionGridView<ParameterPacEntityView,ParameterOptionsDialogView> GridView {get;set;}
    }
    public partial class AvailableDescriptionsCollectionGridView <ParameterPacEntityView,ParameterOptionsDialogView> :  RPSGridView<ParameterPacEntityView,ParameterOptionsDialogView> where ParameterPacEntityView : class, IView where ParameterOptionsDialogView : class, IView
    {
        public AvailableDescriptionsCollectionGridView(ParameterPacEntityView currentView,ParameterOptionsDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Description = RPSControlFactory.CreateRPSGridTextBox<ParameterPacEntityView>("","#0ca72419-0423-49da-a0ea-e3b5e785cb0d .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ParameterPacEntityView> Description { get; set; } 
                     
    }
 
        public partial class SelectedDescriptionsCollectionCollectionEditor<ParameterPacEntityView,ParameterOptionsDialogView>:RPSCollectionEditor<ParameterPacEntityView,ParameterOptionsDialogView> where ParameterPacEntityView : class, IView where ParameterOptionsDialogView : class, IView
    {
        public  SelectedDescriptionsCollectionGridView<ParameterPacEntityView,ParameterOptionsDialogView> GridView {get;set;}
    }
    public partial class SelectedDescriptionsCollectionGridView <ParameterPacEntityView,ParameterOptionsDialogView> :  RPSGridView<ParameterPacEntityView,ParameterOptionsDialogView> where ParameterPacEntityView : class, IView where ParameterOptionsDialogView : class, IView
    {
        public SelectedDescriptionsCollectionGridView(ParameterPacEntityView currentView,ParameterOptionsDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Description = RPSControlFactory.CreateRPSGridTextBox<ParameterPacEntityView>("","#b3774a6e-740e-47f2-a39d-8b39145545f1 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ParameterPacEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class ParameterOptionsDialogView : View
    {
        public ParameterOptionsDialogView(ParameterPac screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DaysOfGrouping = RPSControlFactory.CreateRPSFormattedTextBox<ParameterOptionsDialogView>("8c0a6b6a-28f2-40b0-9b6a-0df0a215ae9d","","",false, this);
 
            AddCommand = RPSControlFactory.CreateRPSButton<ParameterOptionsDialogView>( "4879818c-9f4e-4717-a5e7-d53a1c9c177f","","",this);
 
            RemoveCommand = RPSControlFactory.CreateRPSButton<ParameterOptionsDialogView>( "5e94869b-4114-4bec-b476-c8b1ff8372d8","","",this);
 
            AddAllCommand = RPSControlFactory.CreateRPSButton<ParameterOptionsDialogView>( "2a92befa-5f8c-4df0-bd7f-f18221ca3943","","",this);
 
            RemoveAllCommand = RPSControlFactory.CreateRPSButton<ParameterOptionsDialogView>( "fa1f51b3-b3b8-4566-8ea6-7dcc6a170260","","",this);
 
            CollectionInit params_OptionsOriginalModelCollection = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="efcd56f8-69cc-4195-b45a-4829e975ae88",CSSSelectorGrid="",XPathGrid=""};
            OptionsOriginalModelCollection = RPSControlFactory.RPSCreateCollectionWithGrid<OptionsOriginalModelCollectionCollectionEditor<ParameterOptionsDialogView>,ParameterOptionsDialogView>( params_OptionsOriginalModelCollection,this);
 
            CollectionInit params_OptionsAppliedModelCollection = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="45940259-0e8e-426a-9195-37edea855220",CSSSelectorGrid="",XPathGrid=""};
            OptionsAppliedModelCollection = RPSControlFactory.RPSCreateCollectionWithGrid<OptionsAppliedModelCollectionCollectionEditor<ParameterOptionsDialogView>,ParameterOptionsDialogView>( params_OptionsAppliedModelCollection,this);
 

        }
        public IRPSTextBox<ParameterOptionsDialogView> DaysOfGrouping { get; set; } 
        public IRPSButton<ParameterOptionsDialogView> AddCommand { get; set; } 
        public IRPSButton<ParameterOptionsDialogView> RemoveCommand { get; set; } 
        public IRPSButton<ParameterOptionsDialogView> AddAllCommand { get; set; } 
        public IRPSButton<ParameterOptionsDialogView> RemoveAllCommand { get; set; } 
        public OptionsOriginalModelCollectionCollectionEditor<ParameterOptionsDialogView> OptionsOriginalModelCollection { get; set; } 
        public OptionsAppliedModelCollectionCollectionEditor<ParameterOptionsDialogView> OptionsAppliedModelCollection { get; set; } 
        public ParameterPac Screen { get; set; }
        public ParameterOptionsDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class OptionsOriginalModelCollectionCollectionEditor<ParameterOptionsDialogView>:RPSCollectionEditor<ParameterOptionsDialogView> where ParameterOptionsDialogView : class, IView
    {
        public  OptionsOriginalModelCollectionGridView<ParameterOptionsDialogView> GridView {get;set;}
    }
    public partial class OptionsOriginalModelCollectionGridView <ParameterOptionsDialogView> :  RPSGridView<ParameterOptionsDialogView> where ParameterOptionsDialogView : class, IView
    {
        public OptionsOriginalModelCollectionGridView(ParameterOptionsDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            OriginalOrder = RPSControlFactory.CreateRPSGridTextBox<ParameterOptionsDialogView>("","#efcd56f8-69cc-4195-b45a-4829e975ae88 .ag-row[role='row']@ROWINDEX [col-id='cOriginalOrder']","",false, this.CurrentView);
 
            PlanifyForward = RPSControlFactory.CreateRPSGridCheckBox<ParameterOptionsDialogView>("","#efcd56f8-69cc-4195-b45a-4829e975ae88 .ag-row[role='row']@ROWINDEX [col-id='cPlanifyForward']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ParameterOptionsDialogView> OriginalOrder { get; set; } 
        public IRPSGridCheckbox<ParameterOptionsDialogView> PlanifyForward { get; set; } 
                     
    }
 
        public partial class OptionsAppliedModelCollectionCollectionEditor<ParameterOptionsDialogView>:RPSCollectionEditor<ParameterOptionsDialogView> where ParameterOptionsDialogView : class, IView
    {
        public  OptionsAppliedModelCollectionGridView<ParameterOptionsDialogView> GridView {get;set;}
    }
    public partial class OptionsAppliedModelCollectionGridView <ParameterOptionsDialogView> :  RPSGridView<ParameterOptionsDialogView> where ParameterOptionsDialogView : class, IView
    {
        public OptionsAppliedModelCollectionGridView(ParameterOptionsDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            OriginalOrder = RPSControlFactory.CreateRPSGridTextBox<ParameterOptionsDialogView>("","#45940259-0e8e-426a-9195-37edea855220 .ag-row[role='row']@ROWINDEX [col-id='cOriginalOrder']","",false, this.CurrentView);
 
            PlanifyForward = RPSControlFactory.CreateRPSGridCheckBox<ParameterOptionsDialogView>("","#45940259-0e8e-426a-9195-37edea855220 .ag-row[role='row']@ROWINDEX [col-id='cPlanifyForward']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ParameterOptionsDialogView> OriginalOrder { get; set; } 
        public IRPSGridCheckbox<ParameterOptionsDialogView> PlanifyForward { get; set; } 
                     
    }
 
    }
  
    

}