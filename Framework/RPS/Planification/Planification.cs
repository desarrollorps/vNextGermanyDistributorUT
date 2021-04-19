    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Planification.Planification
{
    //RPS VERSION 1.0.0.0
    public partial class Planification:Screen
    {
        public Planification():base()
        {
            this.URL = "planification.planification";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            PlanificationView  = new PlanificationView(this); 
            ImportToXMLDialogView  = new ImportToXMLDialogView(this); 
            ResourceVisibleSelectDialogView  = new ResourceVisibleSelectDialogView(this); 
            EntitiesVisibleSelectDialogView  = new EntitiesVisibleSelectDialogView(this); 
            PlanningOptionsDialogView  = new PlanningOptionsDialogView(this); 
            PlanningLogDialogView  = new PlanningLogDialogView(this); 
            PlanningTaskView  = new PlanningTaskView(this); 
            PlanningRresourceView  = new PlanningRresourceView(this); 
            PlanningTaskPredecesorView  = new PlanningTaskPredecesorView(this); 
            TimeOccupancyDialogView  = new TimeOccupancyDialogView(this); 
            PlanificationCalendarView  = new PlanificationCalendarView(this); 
            PlanificationCalendarDetailView  = new PlanificationCalendarDetailView(this); 
            PlanificationCalendarDetailDataView  = new PlanificationCalendarDetailDataView(this); 
            NewHourIntervalDialogView  = new NewHourIntervalDialogView(this); 
            NewDateDialogView  = new NewDateDialogView(this); 
            FixBlocksDialogView  = new FixBlocksDialogView(this); 
            PlanningTaskOverloadedView  = new PlanningTaskOverloadedView(this); 
            LocateTaskDialogView  = new LocateTaskDialogView(this); 
            PlanningTaskAvailableResourcesDialogView  = new PlanningTaskAvailableResourcesDialogView(this); 
            PlanningUndoDialogView  = new PlanningUndoDialogView(this); 
            PlanningRedoDialogView  = new PlanningRedoDialogView(this); 
            ConvertResourcesDialogView  = new ConvertResourcesDialogView(this); 
            PendingPlanningDialogView  = new PendingPlanningDialogView(this); 
            PlanningStartDateDialogView  = new PlanningStartDateDialogView(this); 
            InternalCodesDialogView  = new InternalCodesDialogView(this); 
            MoveTaskToResourceDialogView  = new MoveTaskToResourceDialogView(this); 
            PlanningResourceDV  = new PlanningResourceDV(this); 
            ManualResourcePlanningDV  = new ManualResourcePlanningDV(this); 
            NewPlanningTaskPredecessorDV  = new NewPlanningTaskPredecessorDV(this); 
            SelectionDeselectionDV  = new SelectionDeselectionDV(this); 
            ChangePlannedResourceDV  = new ChangePlannedResourceDV(this); 
            PlanificationView.InitializeControls(); 
            ImportToXMLDialogView.InitializeControls(); 
            ResourceVisibleSelectDialogView.InitializeControls(); 
            EntitiesVisibleSelectDialogView.InitializeControls(); 
            PlanningOptionsDialogView.InitializeControls(); 
            PlanningLogDialogView.InitializeControls(); 
            PlanningTaskView.InitializeControls(); 
            PlanningRresourceView.InitializeControls(); 
            PlanningTaskPredecesorView.InitializeControls(); 
            TimeOccupancyDialogView.InitializeControls(); 
            PlanificationCalendarView.InitializeControls(); 
            PlanificationCalendarDetailView.InitializeControls(); 
            PlanificationCalendarDetailDataView.InitializeControls(); 
            NewHourIntervalDialogView.InitializeControls(); 
            NewDateDialogView.InitializeControls(); 
            FixBlocksDialogView.InitializeControls(); 
            PlanningTaskOverloadedView.InitializeControls(); 
            LocateTaskDialogView.InitializeControls(); 
            PlanningTaskAvailableResourcesDialogView.InitializeControls(); 
            PlanningUndoDialogView.InitializeControls(); 
            PlanningRedoDialogView.InitializeControls(); 
            ConvertResourcesDialogView.InitializeControls(); 
            PendingPlanningDialogView.InitializeControls(); 
            PlanningStartDateDialogView.InitializeControls(); 
            InternalCodesDialogView.InitializeControls(); 
            MoveTaskToResourceDialogView.InitializeControls(); 
            PlanningResourceDV.InitializeControls(); 
            ManualResourcePlanningDV.InitializeControls(); 
            NewPlanningTaskPredecessorDV.InitializeControls(); 
            SelectionDeselectionDV.InitializeControls(); 
            ChangePlannedResourceDV.InitializeControls(); 
           
        }
      
            public PlanificationView PlanificationView {get; set; } 
            public ImportToXMLDialogView ImportToXMLDialogView {get; set; } 
            public ResourceVisibleSelectDialogView ResourceVisibleSelectDialogView {get; set; } 
            public EntitiesVisibleSelectDialogView EntitiesVisibleSelectDialogView {get; set; } 
            public PlanningOptionsDialogView PlanningOptionsDialogView {get; set; } 
            public PlanningLogDialogView PlanningLogDialogView {get; set; } 
            public PlanningTaskView PlanningTaskView {get; set; } 
            public PlanningRresourceView PlanningRresourceView {get; set; } 
            public PlanningTaskPredecesorView PlanningTaskPredecesorView {get; set; } 
            public TimeOccupancyDialogView TimeOccupancyDialogView {get; set; } 
            public PlanificationCalendarView PlanificationCalendarView {get; set; } 
            public PlanificationCalendarDetailView PlanificationCalendarDetailView {get; set; } 
            public PlanificationCalendarDetailDataView PlanificationCalendarDetailDataView {get; set; } 
            public NewHourIntervalDialogView NewHourIntervalDialogView {get; set; } 
            public NewDateDialogView NewDateDialogView {get; set; } 
            public FixBlocksDialogView FixBlocksDialogView {get; set; } 
            public PlanningTaskOverloadedView PlanningTaskOverloadedView {get; set; } 
            public LocateTaskDialogView LocateTaskDialogView {get; set; } 
            public PlanningTaskAvailableResourcesDialogView PlanningTaskAvailableResourcesDialogView {get; set; } 
            public PlanningUndoDialogView PlanningUndoDialogView {get; set; } 
            public PlanningRedoDialogView PlanningRedoDialogView {get; set; } 
            public ConvertResourcesDialogView ConvertResourcesDialogView {get; set; } 
            public PendingPlanningDialogView PendingPlanningDialogView {get; set; } 
            public PlanningStartDateDialogView PlanningStartDateDialogView {get; set; } 
            public InternalCodesDialogView InternalCodesDialogView {get; set; } 
            public MoveTaskToResourceDialogView MoveTaskToResourceDialogView {get; set; } 
            public PlanningResourceDV PlanningResourceDV {get; set; } 
            public ManualResourcePlanningDV ManualResourcePlanningDV {get; set; } 
            public NewPlanningTaskPredecessorDV NewPlanningTaskPredecessorDV {get; set; } 
            public SelectionDeselectionDV SelectionDeselectionDV {get; set; } 
            public ChangePlannedResourceDV ChangePlannedResourceDV {get; set; } 
    }
            
    public partial class PlanificationView : View
    {
        public PlanificationView(Planification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UISite = RPSControlFactory.CreateRPSComboBox<PlanificationView>("f295e960-8194-4270-94c6-1f2dd07d3c83","","",false, this);
 
            UIPlanificationDate = RPSControlFactory.CreateRPSTextBox<PlanificationView>("0ce871a4-ef6d-4a39-bd34-ad9d240c56cf","","",false, this);
 
            UIPlanificationTime = RPSControlFactory.CreateRPSTextBox<PlanificationView>("2b11388c-f4de-40cf-b698-000de5278c04","","",true, this);
 
            UIOptAutomaticManual = RPSControlFactory.CreateRPSEnumComboBox<PlanificationView>("c21f691b-ddd1-46a1-86d5-44927e1640e8","","",false, this);
 
            UIScene = RPSControlFactory.CreateRPSComboBox<PlanificationView>("c4c3abcb-6ca2-47e9-ad6b-b71ad89b57d4","","",false, this);
 
            UIOptOrderType = RPSControlFactory.CreateRPSEnumComboBox<PlanificationView>("62521260-e40a-4802-83d2-fe52603cbf28","","",false, this);
 
            UISetSeeStatus = RPSControlFactory.CreateRPSCheckBox<PlanificationView>("bbe0dd16-5995-4be7-bf79-4ca19dbe0b32","","",false, this);
 
            UISeeGroups = RPSControlFactory.CreateRPSCheckBox<PlanificationView>("7e5a68fe-fc26-4766-850a-61c8fef104eb","","",false, this);
 
            UISetFree = RPSControlFactory.CreateRPSCheckBox<PlanificationView>("2bf98012-386a-4522-bc8a-75ff1dc65c23","","",false, this);
 
            UISeeAlternativePlannedTasks = RPSControlFactory.CreateRPSCheckBox<PlanificationView>("45d5e31c-235a-4964-b581-0ce329d0469a","","",false, this);
 
            UIPlanSelectedBlocking = RPSControlFactory.CreateRPSCheckBox<PlanificationView>("fd88ba3f-e9e8-429f-b5bd-2442aa871eee","","",false, this);
 
            UIHideNotPlannedResources = RPSControlFactory.CreateRPSCheckBox<PlanificationView>("8d74686e-4921-4b78-95d4-ee1f52eb619d","","",false, this);
 
            UIPrecision2FromDays = RPSControlFactory.CreateRPSFormattedTextBox<PlanificationView>("863c4f36-7ca1-4bd2-95e9-4a476ff62f03","","",false, this);
 
            FinePrecision = RPSControlFactory.CreateRPSFormattedTextBox<PlanificationView>("7de0a2ea-0021-43e3-84fd-5c90106bd1b5","","",false, this);
 
            GrossPrecision = RPSControlFactory.CreateRPSFormattedTextBox<PlanificationView>("c94820de-916c-49e3-8b6a-aaba608d1e26","","",false, this);
 
            SelectionDeselectionComm = RPSControlFactory.CreateRPSButtonToView<PlanificationView,SelectionDeselectionDV>("58f7827b-acb1-4587-bb7c-8b14ff07b9bf","","", this,Screen.SelectionDeselectionDV);
 
            UIDelimitationNotFulFilledColor = RPSControlFactory.CreateRPSColorEditor<PlanificationView>( "d0dce2be-80ca-40bc-b658-bacac2bc4970","","",this);
 
            UIDelimitationNotFulFilled = RPSControlFactory.CreateRPSCheckBox<PlanificationView>("ebef2df7-b314-4901-a02c-2a781f288efa","","",false, this);
 
            UIEndDateGreaterThanManualDateColor = RPSControlFactory.CreateRPSColorEditor<PlanificationView>( "92b54dbd-3b46-4f00-8812-fa85fe6ac09a","","",this);
 
            UIEndDateGreaterThanManualDate = RPSControlFactory.CreateRPSCheckBox<PlanificationView>("a02d09b0-651a-4a92-9d8d-e492858aea8e","","",false, this);
 
            UIMaterialsNotProvisionableColor = RPSControlFactory.CreateRPSColorEditor<PlanificationView>( "b666dabf-5217-4775-bf53-496c86b03e81","","",this);
 
            UIMaterialsNotProvisionable = RPSControlFactory.CreateRPSCheckBox<PlanificationView>("5597deeb-01cf-404e-9166-2efd24d185a8","","",false, this);
 
            UIMaterialsWithoutAvailabilityColor = RPSControlFactory.CreateRPSColorEditor<PlanificationView>( "f7b4cef5-1ebb-4a10-af9e-0d1f601add5c","","",this);
 
            UIMaterialsWithoutAvailability = RPSControlFactory.CreateRPSCheckBox<PlanificationView>("96c5967b-4b41-416a-be1e-c20e0cead420","","",false, this);
 
            UIRelationNotFulFilledColor = RPSControlFactory.CreateRPSColorEditor<PlanificationView>( "1be7bd33-0f01-4534-95c3-c44f3f4ea050","","",this);
 
            UIRelationNotFulFilled = RPSControlFactory.CreateRPSCheckBox<PlanificationView>("16269e14-be91-4db0-a035-6cccb80886cd","","",false, this);
 
            UIStartDatePreviousToPlanningDateColor = RPSControlFactory.CreateRPSColorEditor<PlanificationView>( "3982aeb1-07c3-4dde-bd9f-b589b316d71d","","",this);
 
            UIStartDatePreviousToPlanningDate = RPSControlFactory.CreateRPSCheckBox<PlanificationView>("78485d4c-a93a-4212-8351-97e8643783aa","","",false, this);
 
            UILeadTimeCheckColor = RPSControlFactory.CreateRPSColorEditor<PlanificationView>( "bd503830-cbb1-44a6-a818-07fa1c3cc6a9","","",this);
 
            UILeadTimeCheck = RPSControlFactory.CreateRPSCheckBox<PlanificationView>("c9cdaba9-1d75-4138-b8ef-4b1e6c7a751b","","",false, this);
 
            UIFixedTimeDistinctPendingCheckColor = RPSControlFactory.CreateRPSColorEditor<PlanificationView>( "c62fa05e-ebb1-4775-82a0-dcc0a689cef7","","",this);
 
            UIFixedTimeDistinctPendingCheck = RPSControlFactory.CreateRPSCheckBox<PlanificationView>("888211de-7dcf-48b7-b70a-503079340713","","",false, this);
 
            ExecuteGetPlanningAlertsButton = RPSControlFactory.CreateRPSButton<PlanificationView>( "74367655-2a58-48ad-9637-050ad730020a","","",this);
 
            InitialDate = RPSControlFactory.CreateRPSTextBox<PlanificationView>("a6c95dee-2637-4f15-9404-62696ba15081","","",false, this);
 
            EndDate = RPSControlFactory.CreateRPSTextBox<PlanificationView>("f4023116-745f-455f-ad90-53cac208713c","","",false, this);
 
            Details = RPSControlFactory.CreateRPSTextBox<PlanificationView>("94607224-7000-42af-9198-efb86fa836d4","","",false, this);
 
            SavePlanningCommButton = RPSControlFactory.CreateRPSButton<PlanificationView>( "d4254e89-852c-4835-9414-2f712fa041c2","","",this);
 
            PlanningUndoNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<PlanificationView,PlanningUndoDialogView>("5217263a-9abd-4c15-a245-d180d99db2f8","","", this,Screen.PlanningUndoDialogView);
 
            PlanningRedoNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<PlanificationView,PlanningRedoDialogView>("894a6e00-9e17-4b61-87e5-c272d788f066","","", this,Screen.PlanningRedoDialogView);
 
            RefreshCommandButton = RPSControlFactory.CreateRPSButton<PlanificationView>( "902da2cd-863b-4b38-9264-559cc1c144aa","","",this);
 
            LocateTaskNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<PlanificationView,LocateTaskDialogView>("9b99ed21-93a9-4c72-89b7-2bb202a0324d","","", this,Screen.LocateTaskDialogView);
 
            PendingPlanningNavigationCommandButton = RPSControlFactory.CreateRPSButton<PlanificationView>( "d62c40f6-fd91-42de-8271-e0498eb5263d","","",this);
 
            ExecutePlanifyRestManualEntitiesButton = RPSControlFactory.CreateRPSButton<PlanificationView>( "7ffe37ad-cef9-46ba-9b20-b34f954a0d43","","",this);
 
            ExecutePlannifyButton = RPSControlFactory.CreateRPSButton<PlanificationView>( "f40c3d03-6433-4b68-8211-363a578aad73","","",this);
 
            FixBlocksNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<PlanificationView,FixBlocksDialogView>("83d5e21d-62a6-44d4-85b2-e6901a94770b","","", this,Screen.FixBlocksDialogView);
 
            ResourceVisibleSelectNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<PlanificationView,ResourceVisibleSelectDialogView>("faa48004-a016-4e20-b769-9d9c423e63cb","","", this,Screen.ResourceVisibleSelectDialogView);
 
            EntitiesVisibleSelectNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<PlanificationView,EntitiesVisibleSelectDialogView>("605267bf-5f8b-4754-8601-c2f8972fb2a4","","", this,Screen.EntitiesVisibleSelectDialogView);
 
            PlanningResourceNavCommButton = RPSControlFactory.CreateRPSButtonToView<PlanificationView,PlanningResourceDV>("fad15695-d839-401d-895f-af27c2cf83ee","","", this,Screen.PlanningResourceDV);
 
            ManualResourcePlanningNavCommButton = RPSControlFactory.CreateRPSButtonToView<PlanificationView,ManualResourcePlanningDV>("c627fdb8-04cf-42f3-b9d3-6542f759a956","","", this,Screen.ManualResourcePlanningDV);
 
            ExecutePlanFinePeriodOnlyCommButton = RPSControlFactory.CreateRPSButton<PlanificationView>( "c6d6873a-b49c-4af7-b1ba-3769c6a7861b","","",this);
 
            PlanifyTaskToTaskCommandButton = RPSControlFactory.CreateRPSButton<PlanificationView>( "b26f7bee-ef99-4efa-b67a-700a4c8e081b","","",this);
 
            PlanningOptionsNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<PlanificationView,PlanningOptionsDialogView>("c516b0a5-66af-4366-84ab-6242a444c5a5","","", this,Screen.PlanningOptionsDialogView);
 
            PlanificationCalendarNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<PlanificationView,PlanificationCalendarView>("b12e2dce-948c-4c47-a4ab-62dace2eae29","","", this,Screen.PlanificationCalendarView);
 
            TimeOccupancyNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<PlanificationView,TimeOccupancyDialogView>("f08b3a01-a891-4005-b3c3-eed84a6d587e","","", this,Screen.TimeOccupancyDialogView);
 
            InternalCodesNavigationCommandButton = RPSControlFactory.CreateRPSButton<PlanificationView>( "c8963053-b3bb-49a0-8583-222305ef86af","","",this);
 
            PlanifyTillTaskCommandButton = RPSControlFactory.CreateRPSButton<PlanificationView>( "a2ce1cf2-4fee-48d1-a542-2ab5c9d34254","","",this);
 
            NextPlanifyTaskToTaskCommandButton = RPSControlFactory.CreateRPSButton<PlanificationView>( "ac7ec1fa-ca43-4f53-8bdf-72321795e173","","",this);
 
            FixProposedResourceCommandButton = RPSControlFactory.CreateRPSButton<PlanificationView>( "db3bfec5-dd89-45c7-b5a5-a041216fb9e5","","",this);
 
            ImportToXMLNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<PlanificationView,ImportToXMLDialogView>("9ebbe49d-0cee-4427-913c-13c0083937b9","","", this,Screen.ImportToXMLDialogView);
 
            SaveToXMLCommandButton = RPSControlFactory.CreateRPSButton<PlanificationView>( "acc5e6f2-d796-437b-8d6f-5de2a4d87c69","","",this);
 
            ChainTaskCommandButton = RPSControlFactory.CreateRPSButton<PlanificationView>( "97d8c0a0-07d3-4650-b074-edbeaffdea02","","",this);
 
            DechainTaskCommandButton = RPSControlFactory.CreateRPSButton<PlanificationView>( "1f068d6a-664d-462e-876d-2fc51dd48b74","","",this);
 
            MoveTaskToResourceNavigationCommandButton = RPSControlFactory.CreateRPSButton<PlanificationView>( "01f2a646-7bfc-4c91-a3be-06d51be58b46","","",this);
 
            PlanningLogNavigationCommandButton = RPSControlFactory.CreateRPSButton<PlanificationView>( "5a5221b9-7a35-457a-b49c-8c1b06ea7563","","",this);
 
            ExecuteRemoveSavedPlanningDataCommButton = RPSControlFactory.CreateRPSButton<PlanificationView>( "04ac43fb-3773-41bc-8737-5f87e4c943d9","","",this);
 
            CollectionInit params_GetPlanningAlerts = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5403f8c4-2cd4-41b7-bd68-a5da20eab4f4",CSSSelectorGrid="",XPathGrid=""};
            GetPlanningAlerts = RPSControlFactory.RPSCreateCollectionWithGrid<GetPlanningAlertsCollectionEditor<PlanificationView,ImportToXMLDialogView>,PlanificationView,ImportToXMLDialogView>( params_GetPlanningAlerts,this,Screen.ImportToXMLDialogView);
 
            Gantt = RPSControlFactory.CreateRPSSection<PlanificationView>( "","ul li[rpsid='d9234eb8-8d79-48e7-8d3f-646c9c4bcd15']","",this);
 
            Alerts = RPSControlFactory.CreateRPSSection<PlanificationView>( "","ul li[rpsid='afd6e672-032d-4f56-8807-be855638b60b']","",this);
 

        }
        public IRPSComboBox<PlanificationView> UISite { get; set; } 
        public IRPSTextBox<PlanificationView> UIPlanificationDate { get; set; } 
        public IRPSTextBox<PlanificationView> UIPlanificationTime { get; set; } 
        public IRPSComboBox<PlanificationView> UIOptAutomaticManual { get; set; } 
        public IRPSComboBox<PlanificationView> UIScene { get; set; } 
        public IRPSComboBox<PlanificationView> UIOptOrderType { get; set; } 
        public IRPSCheckbox<PlanificationView> UISetSeeStatus { get; set; } 
        public IRPSCheckbox<PlanificationView> UISeeGroups { get; set; } 
        public IRPSCheckbox<PlanificationView> UISetFree { get; set; } 
        public IRPSCheckbox<PlanificationView> UISeeAlternativePlannedTasks { get; set; } 
        public IRPSCheckbox<PlanificationView> UIPlanSelectedBlocking { get; set; } 
        public IRPSCheckbox<PlanificationView> UIHideNotPlannedResources { get; set; } 
        public IRPSTextBox<PlanificationView> UIPrecision2FromDays { get; set; } 
        public IRPSTextBox<PlanificationView> FinePrecision { get; set; } 
        public IRPSTextBox<PlanificationView> GrossPrecision { get; set; } 
        public IRPSButton<PlanificationView,SelectionDeselectionDV> SelectionDeselectionComm { get; set; } 
        public IRPSColorEditor<PlanificationView> UIDelimitationNotFulFilledColor { get; set; } 
        public IRPSCheckbox<PlanificationView> UIDelimitationNotFulFilled { get; set; } 
        public IRPSColorEditor<PlanificationView> UIEndDateGreaterThanManualDateColor { get; set; } 
        public IRPSCheckbox<PlanificationView> UIEndDateGreaterThanManualDate { get; set; } 
        public IRPSColorEditor<PlanificationView> UIMaterialsNotProvisionableColor { get; set; } 
        public IRPSCheckbox<PlanificationView> UIMaterialsNotProvisionable { get; set; } 
        public IRPSColorEditor<PlanificationView> UIMaterialsWithoutAvailabilityColor { get; set; } 
        public IRPSCheckbox<PlanificationView> UIMaterialsWithoutAvailability { get; set; } 
        public IRPSColorEditor<PlanificationView> UIRelationNotFulFilledColor { get; set; } 
        public IRPSCheckbox<PlanificationView> UIRelationNotFulFilled { get; set; } 
        public IRPSColorEditor<PlanificationView> UIStartDatePreviousToPlanningDateColor { get; set; } 
        public IRPSCheckbox<PlanificationView> UIStartDatePreviousToPlanningDate { get; set; } 
        public IRPSColorEditor<PlanificationView> UILeadTimeCheckColor { get; set; } 
        public IRPSCheckbox<PlanificationView> UILeadTimeCheck { get; set; } 
        public IRPSColorEditor<PlanificationView> UIFixedTimeDistinctPendingCheckColor { get; set; } 
        public IRPSCheckbox<PlanificationView> UIFixedTimeDistinctPendingCheck { get; set; } 
        public IRPSButton<PlanificationView> ExecuteGetPlanningAlertsButton { get; set; } 
        public IRPSTextBox<PlanificationView> InitialDate { get; set; } 
        public IRPSTextBox<PlanificationView> EndDate { get; set; } 
        public IRPSTextBox<PlanificationView> Details { get; set; } 
        public IRPSButton<PlanificationView> SavePlanningCommButton { get; set; } 
        public IRPSButton<PlanificationView,PlanningUndoDialogView> PlanningUndoNavigationCommandButton { get; set; } 
        public IRPSButton<PlanificationView,PlanningRedoDialogView> PlanningRedoNavigationCommandButton { get; set; } 
        public IRPSButton<PlanificationView> RefreshCommandButton { get; set; } 
        public IRPSButton<PlanificationView,LocateTaskDialogView> LocateTaskNavigationCommandButton { get; set; } 
        public IRPSButton<PlanificationView> PendingPlanningNavigationCommandButton { get; set; } 
        public IRPSButton<PlanificationView> ExecutePlanifyRestManualEntitiesButton { get; set; } 
        public IRPSButton<PlanificationView> ExecutePlannifyButton { get; set; } 
        public IRPSButton<PlanificationView,FixBlocksDialogView> FixBlocksNavigationCommandButton { get; set; } 
        public IRPSButton<PlanificationView,ResourceVisibleSelectDialogView> ResourceVisibleSelectNavigationCommandButton { get; set; } 
        public IRPSButton<PlanificationView,EntitiesVisibleSelectDialogView> EntitiesVisibleSelectNavigationCommandButton { get; set; } 
        public IRPSButton<PlanificationView,PlanningResourceDV> PlanningResourceNavCommButton { get; set; } 
        public IRPSButton<PlanificationView,ManualResourcePlanningDV> ManualResourcePlanningNavCommButton { get; set; } 
        public IRPSButton<PlanificationView> ExecutePlanFinePeriodOnlyCommButton { get; set; } 
        public IRPSButton<PlanificationView> PlanifyTaskToTaskCommandButton { get; set; } 
        public IRPSButton<PlanificationView,PlanningOptionsDialogView> PlanningOptionsNavigationCommandButton { get; set; } 
        public IRPSButton<PlanificationView,PlanificationCalendarView> PlanificationCalendarNavigationCommandButton { get; set; } 
        public IRPSButton<PlanificationView,TimeOccupancyDialogView> TimeOccupancyNavigationCommandButton { get; set; } 
        public IRPSButton<PlanificationView> InternalCodesNavigationCommandButton { get; set; } 
        public IRPSButton<PlanificationView> PlanifyTillTaskCommandButton { get; set; } 
        public IRPSButton<PlanificationView> NextPlanifyTaskToTaskCommandButton { get; set; } 
        public IRPSButton<PlanificationView> FixProposedResourceCommandButton { get; set; } 
        public IRPSButton<PlanificationView,ImportToXMLDialogView> ImportToXMLNavigationCommandButton { get; set; } 
        public IRPSButton<PlanificationView> SaveToXMLCommandButton { get; set; } 
        public IRPSButton<PlanificationView> ChainTaskCommandButton { get; set; } 
        public IRPSButton<PlanificationView> DechainTaskCommandButton { get; set; } 
        public IRPSButton<PlanificationView> MoveTaskToResourceNavigationCommandButton { get; set; } 
        public IRPSButton<PlanificationView> PlanningLogNavigationCommandButton { get; set; } 
        public IRPSButton<PlanificationView> ExecuteRemoveSavedPlanningDataCommButton { get; set; } 
        public GetPlanningAlertsCollectionEditor<PlanificationView,ImportToXMLDialogView> GetPlanningAlerts { get; set; } 
        public IRPSSection<PlanificationView> Gantt { get; set; } 
        public IRPSSection<PlanificationView> Alerts { get; set; } 
        public Planification Screen { get; set; }
        public PlanificationView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetPlanningAlertsCollectionEditor<PlanificationView,ImportToXMLDialogView>:RPSCollectionEditor<PlanificationView,ImportToXMLDialogView> where PlanificationView : class, IView where ImportToXMLDialogView : class, IView
    {
        public  GetPlanningAlertsGridView<PlanificationView,ImportToXMLDialogView> GridView {get;set;}
    }
    public partial class GetPlanningAlertsGridView <PlanificationView,ImportToXMLDialogView> :  RPSGridView<PlanificationView,ImportToXMLDialogView> where PlanificationView : class, IView where ImportToXMLDialogView : class, IView
    {
        public GetPlanningAlertsGridView(PlanificationView currentView,ImportToXMLDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            InitialDate = RPSControlFactory.CreateRPSGridTextBox<PlanificationView>("","#5403f8c4-2cd4-41b7-bd68-a5da20eab4f4 .ag-row[role='row']@ROWINDEX [col-id='cInitialDate']","",false, this.CurrentView);
 
            EndDate = RPSControlFactory.CreateRPSGridTextBox<PlanificationView>("","#5403f8c4-2cd4-41b7-bd68-a5da20eab4f4 .ag-row[role='row']@ROWINDEX [col-id='cEndDate']","",false, this.CurrentView);
 
            NumAlerts = RPSControlFactory.CreateRPSGridFormattedTextBox<PlanificationView>("","#5403f8c4-2cd4-41b7-bd68-a5da20eab4f4 .ag-row[role='row']@ROWINDEX [col-id='cNumAlerts']","",false, this.CurrentView);
 
            Details = RPSControlFactory.CreateRPSGridMemoTextBox<PlanificationView>("","#5403f8c4-2cd4-41b7-bd68-a5da20eab4f4 .ag-row[role='row']@ROWINDEX [col-id='cDetails']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<PlanificationView> InitialDate { get; set; } 
        public IRPSGridTextBox<PlanificationView> EndDate { get; set; } 
        public IRPSGridTextBox<PlanificationView> NumAlerts { get; set; } 
        public IRPSGridTextBox<PlanificationView> Details { get; set; } 
                     
    }
 
    }
  
            
    public partial class ImportToXMLDialogView : View
    {
        public ImportToXMLDialogView(Planification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public Planification Screen { get; set; }
        public ImportToXMLDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ResourceVisibleSelectDialogView : View
    {
        public ResourceVisibleSelectDialogView(Planification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIEmployees = RPSControlFactory.CreateRPSCheckBox<ResourceVisibleSelectDialogView>("2c5b6fcb-b138-45f8-bc8e-6b6d1838a222","","",false, this);
 
            UIMachines = RPSControlFactory.CreateRPSCheckBox<ResourceVisibleSelectDialogView>("129a2a78-982a-422e-82b9-77f6d6a9375e","","",false, this);
 
            UITool = RPSControlFactory.CreateRPSCheckBox<ResourceVisibleSelectDialogView>("a54c7f63-7963-475f-8d29-77bc4f469a92","","",false, this);
 
            SelectAllGroupCommandButton = RPSControlFactory.CreateRPSButton<ResourceVisibleSelectDialogView>( "b2d69b1a-bcbb-45b8-91f8-1c425de0d54f","","",this);
 
            DeselectAllGroupCommandButton = RPSControlFactory.CreateRPSButton<ResourceVisibleSelectDialogView>( "ea428fc9-43bd-4039-8ad6-a618f9386a01","","",this);
 
            SelectAllCommandButton = RPSControlFactory.CreateRPSButton<ResourceVisibleSelectDialogView>( "8d9ddf4a-749d-4990-8b5d-554fe455f79d","","",this);
 
            DeselectAllCommandButton = RPSControlFactory.CreateRPSButton<ResourceVisibleSelectDialogView>( "8c3aea48-02c3-46df-80d9-f2eb2686910a","","",this);
 
            CollectionInit params_GetVisiblePlanningResourceGroup = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0cbaa43d-4c93-43ac-87a6-530a1f5e6edb",CSSSelectorGrid="",XPathGrid=""};
            GetVisiblePlanningResourceGroup = RPSControlFactory.RPSCreateCollectionWithGrid<GetVisiblePlanningResourceGroupCollectionEditor<ResourceVisibleSelectDialogView>,ResourceVisibleSelectDialogView>( params_GetVisiblePlanningResourceGroup,this);
 
            CollectionInit params_GetVisiblePlanningResources = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ab55059b-9ad5-4f77-a832-a44c8b6ffa17",CSSSelectorGrid="",XPathGrid=""};
            GetVisiblePlanningResources = RPSControlFactory.RPSCreateCollectionWithGrid<GetVisiblePlanningResourcesCollectionEditor<ResourceVisibleSelectDialogView>,ResourceVisibleSelectDialogView>( params_GetVisiblePlanningResources,this);
 

        }
        public IRPSCheckbox<ResourceVisibleSelectDialogView> UIEmployees { get; set; } 
        public IRPSCheckbox<ResourceVisibleSelectDialogView> UIMachines { get; set; } 
        public IRPSCheckbox<ResourceVisibleSelectDialogView> UITool { get; set; } 
        public IRPSButton<ResourceVisibleSelectDialogView> SelectAllGroupCommandButton { get; set; } 
        public IRPSButton<ResourceVisibleSelectDialogView> DeselectAllGroupCommandButton { get; set; } 
        public IRPSButton<ResourceVisibleSelectDialogView> SelectAllCommandButton { get; set; } 
        public IRPSButton<ResourceVisibleSelectDialogView> DeselectAllCommandButton { get; set; } 
        public GetVisiblePlanningResourceGroupCollectionEditor<ResourceVisibleSelectDialogView> GetVisiblePlanningResourceGroup { get; set; } 
        public GetVisiblePlanningResourcesCollectionEditor<ResourceVisibleSelectDialogView> GetVisiblePlanningResources { get; set; } 
        public Planification Screen { get; set; }
        public ResourceVisibleSelectDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetVisiblePlanningResourceGroupCollectionEditor<ResourceVisibleSelectDialogView>:RPSCollectionEditor<ResourceVisibleSelectDialogView> where ResourceVisibleSelectDialogView : class, IView
    {
        public  GetVisiblePlanningResourceGroupGridView<ResourceVisibleSelectDialogView> GridView {get;set;}
    }
    public partial class GetVisiblePlanningResourceGroupGridView <ResourceVisibleSelectDialogView> :  RPSGridView<ResourceVisibleSelectDialogView> where ResourceVisibleSelectDialogView : class, IView
    {
        public GetVisiblePlanningResourceGroupGridView(ResourceVisibleSelectDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            TipoRecurso = RPSControlFactory.CreateRPSGridTextBox<ResourceVisibleSelectDialogView>("","#0cbaa43d-4c93-43ac-87a6-530a1f5e6edb .ag-row[role='row']@ROWINDEX [col-id='cTipoRecurso']","",false, this.CurrentView);
 
            Visible = RPSControlFactory.CreateRPSGridCheckBox<ResourceVisibleSelectDialogView>("","#0cbaa43d-4c93-43ac-87a6-530a1f5e6edb .ag-row[role='row']@ROWINDEX [col-id='cVisible']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ResourceVisibleSelectDialogView> TipoRecurso { get; set; } 
        public IRPSGridCheckbox<ResourceVisibleSelectDialogView> Visible { get; set; } 
                     
    }
 
        public partial class GetVisiblePlanningResourcesCollectionEditor<ResourceVisibleSelectDialogView>:RPSCollectionEditor<ResourceVisibleSelectDialogView> where ResourceVisibleSelectDialogView : class, IView
    {
        public  GetVisiblePlanningResourcesGridView<ResourceVisibleSelectDialogView> GridView {get;set;}
    }
    public partial class GetVisiblePlanningResourcesGridView <ResourceVisibleSelectDialogView> :  RPSGridView<ResourceVisibleSelectDialogView> where ResourceVisibleSelectDialogView : class, IView
    {
        public GetVisiblePlanningResourcesGridView(ResourceVisibleSelectDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            TipoRecurso = RPSControlFactory.CreateRPSGridTextBox<ResourceVisibleSelectDialogView>("","#ab55059b-9ad5-4f77-a832-a44c8b6ffa17 .ag-row[role='row']@ROWINDEX [col-id='cTipoRecurso']","",false, this.CurrentView);
 
            Visible = RPSControlFactory.CreateRPSGridCheckBox<ResourceVisibleSelectDialogView>("","#ab55059b-9ad5-4f77-a832-a44c8b6ffa17 .ag-row[role='row']@ROWINDEX [col-id='cVisible']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ResourceVisibleSelectDialogView> TipoRecurso { get; set; } 
        public IRPSGridCheckbox<ResourceVisibleSelectDialogView> Visible { get; set; } 
                     
    }
 
    }
  
            
    public partial class EntitiesVisibleSelectDialogView : View
    {
        public EntitiesVisibleSelectDialogView(Planification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIDeliveryDateFrom = RPSControlFactory.CreateRPSTextBox<EntitiesVisibleSelectDialogView>("088a1809-7fc1-46f3-83d3-299da718557c","","",false, this);
 
            UIDeliveryDateTo = RPSControlFactory.CreateRPSTextBox<EntitiesVisibleSelectDialogView>("1c5fd9a9-216e-4ac3-85c1-d4066501623c","","",false, this);
 
            UIProjects = RPSControlFactory.CreateRPSCheckBox<EntitiesVisibleSelectDialogView>("2419bf44-e4f6-47e5-8d37-2895faac903e","","",false, this);
 
            UIManufacturingOrder = RPSControlFactory.CreateRPSCheckBox<EntitiesVisibleSelectDialogView>("f6d0ac7b-2b38-4624-ba72-d17ac0a95e64","","",false, this);
 
            UIMaintenanceOrder = RPSControlFactory.CreateRPSCheckBox<EntitiesVisibleSelectDialogView>("13f99c89-8316-4bcc-893c-97d3cfd4f109","","",false, this);
 
            UIGeneric = RPSControlFactory.CreateRPSCheckBox<EntitiesVisibleSelectDialogView>("20373bb4-bddf-4479-8bfb-83c4f88b2a6e","","",false, this);
 
            SelectAllCommandButton = RPSControlFactory.CreateRPSButton<EntitiesVisibleSelectDialogView>( "79fb1819-067f-40c4-a0b4-89ef2a0d5db5","","",this);
 
            DeselectAllCommandButton = RPSControlFactory.CreateRPSButton<EntitiesVisibleSelectDialogView>( "464af0fb-e99f-4d4c-9a11-295351b8b422","","",this);
 
            CollectionInit params_GetVisiblePlanningEntities = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c62cdc6a-7472-4525-9952-fd9bde1934c5",CSSSelectorGrid="",XPathGrid=""};
            GetVisiblePlanningEntities = RPSControlFactory.RPSCreateCollectionWithGrid<GetVisiblePlanningEntitiesCollectionEditor<EntitiesVisibleSelectDialogView>,EntitiesVisibleSelectDialogView>( params_GetVisiblePlanningEntities,this);
 

        }
        public IRPSTextBox<EntitiesVisibleSelectDialogView> UIDeliveryDateFrom { get; set; } 
        public IRPSTextBox<EntitiesVisibleSelectDialogView> UIDeliveryDateTo { get; set; } 
        public IRPSCheckbox<EntitiesVisibleSelectDialogView> UIProjects { get; set; } 
        public IRPSCheckbox<EntitiesVisibleSelectDialogView> UIManufacturingOrder { get; set; } 
        public IRPSCheckbox<EntitiesVisibleSelectDialogView> UIMaintenanceOrder { get; set; } 
        public IRPSCheckbox<EntitiesVisibleSelectDialogView> UIGeneric { get; set; } 
        public IRPSButton<EntitiesVisibleSelectDialogView> SelectAllCommandButton { get; set; } 
        public IRPSButton<EntitiesVisibleSelectDialogView> DeselectAllCommandButton { get; set; } 
        public GetVisiblePlanningEntitiesCollectionEditor<EntitiesVisibleSelectDialogView> GetVisiblePlanningEntities { get; set; } 
        public Planification Screen { get; set; }
        public EntitiesVisibleSelectDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetVisiblePlanningEntitiesCollectionEditor<EntitiesVisibleSelectDialogView>:RPSCollectionEditor<EntitiesVisibleSelectDialogView> where EntitiesVisibleSelectDialogView : class, IView
    {
        public  GetVisiblePlanningEntitiesGridView<EntitiesVisibleSelectDialogView> GridView {get;set;}
    }
    public partial class GetVisiblePlanningEntitiesGridView <EntitiesVisibleSelectDialogView> :  RPSGridView<EntitiesVisibleSelectDialogView> where EntitiesVisibleSelectDialogView : class, IView
    {
        public GetVisiblePlanningEntitiesGridView(EntitiesVisibleSelectDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Source = RPSControlFactory.CreateRPSGridTextBox<EntitiesVisibleSelectDialogView>("","#c62cdc6a-7472-4525-9952-fd9bde1934c5 .ag-row[role='row']@ROWINDEX [col-id='cSource']","",false, this.CurrentView);
 
            Visible = RPSControlFactory.CreateRPSGridCheckBox<EntitiesVisibleSelectDialogView>("","#c62cdc6a-7472-4525-9952-fd9bde1934c5 .ag-row[role='row']@ROWINDEX [col-id='cVisible']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<EntitiesVisibleSelectDialogView> Source { get; set; } 
        public IRPSGridCheckbox<EntitiesVisibleSelectDialogView> Visible { get; set; } 
                     
    }
 
    }
  
            
    public partial class PlanningOptionsDialogView : View
    {
        public PlanningOptionsDialogView(Planification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIAgrupationDays = RPSControlFactory.CreateRPSFormattedTextBox<PlanningOptionsDialogView>("31c96cd3-dd48-40ce-a72d-36284918e9ba","","",false, this);
 
            UIGenerateLog = RPSControlFactory.CreateRPSCheckBox<PlanningOptionsDialogView>("afd73d74-b4bc-48d8-8374-30ca13fd8d77","","",false, this);
 
            AddCommand = RPSControlFactory.CreateRPSButton<PlanningOptionsDialogView>( "e707fcf2-e9c8-4fe2-a5de-509058fc1b0d","","",this);
 
            RemoveCommand = RPSControlFactory.CreateRPSButton<PlanningOptionsDialogView>( "15dd10ec-1ae3-4288-a2c0-9bbedf768cd1","","",this);
 
            AddAllCommand = RPSControlFactory.CreateRPSButton<PlanningOptionsDialogView>( "1f38f2de-3d92-4634-b75c-252f0c832032","","",this);
 
            RemoveAllCommand = RPSControlFactory.CreateRPSButton<PlanningOptionsDialogView>( "5740eeb0-c599-4709-bae5-89ae2b70d7c7","","",this);
 
            CollectionInit params_OptionsOriginalModelCollection = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="de984895-5e3c-4e90-a318-6ae704002cf9",CSSSelectorGrid="",XPathGrid=""};
            OptionsOriginalModelCollection = RPSControlFactory.RPSCreateCollectionWithGrid<OptionsOriginalModelCollectionCollectionEditor<PlanningOptionsDialogView>,PlanningOptionsDialogView>( params_OptionsOriginalModelCollection,this);
 
            CollectionInit params_OptionsAppliedModelCollection = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a0503894-ed69-4bd1-aa76-334e04b8adb4",CSSSelectorGrid="",XPathGrid=""};
            OptionsAppliedModelCollection = RPSControlFactory.RPSCreateCollectionWithGrid<OptionsAppliedModelCollectionCollectionEditor<PlanningOptionsDialogView>,PlanningOptionsDialogView>( params_OptionsAppliedModelCollection,this);
 

        }
        public IRPSTextBox<PlanningOptionsDialogView> UIAgrupationDays { get; set; } 
        public IRPSCheckbox<PlanningOptionsDialogView> UIGenerateLog { get; set; } 
        public IRPSButton<PlanningOptionsDialogView> AddCommand { get; set; } 
        public IRPSButton<PlanningOptionsDialogView> RemoveCommand { get; set; } 
        public IRPSButton<PlanningOptionsDialogView> AddAllCommand { get; set; } 
        public IRPSButton<PlanningOptionsDialogView> RemoveAllCommand { get; set; } 
        public OptionsOriginalModelCollectionCollectionEditor<PlanningOptionsDialogView> OptionsOriginalModelCollection { get; set; } 
        public OptionsAppliedModelCollectionCollectionEditor<PlanningOptionsDialogView> OptionsAppliedModelCollection { get; set; } 
        public Planification Screen { get; set; }
        public PlanningOptionsDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class OptionsOriginalModelCollectionCollectionEditor<PlanningOptionsDialogView>:RPSCollectionEditor<PlanningOptionsDialogView> where PlanningOptionsDialogView : class, IView
    {
        public  OptionsOriginalModelCollectionGridView<PlanningOptionsDialogView> GridView {get;set;}
    }
    public partial class OptionsOriginalModelCollectionGridView <PlanningOptionsDialogView> :  RPSGridView<PlanningOptionsDialogView> where PlanningOptionsDialogView : class, IView
    {
        public OptionsOriginalModelCollectionGridView(PlanningOptionsDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            OriginalOrder = RPSControlFactory.CreateRPSGridTextBox<PlanningOptionsDialogView>("","#de984895-5e3c-4e90-a318-6ae704002cf9 .ag-row[role='row']@ROWINDEX [col-id='cOriginalOrder']","",false, this.CurrentView);
 
            PlanifyForward = RPSControlFactory.CreateRPSGridCheckBox<PlanningOptionsDialogView>("","#de984895-5e3c-4e90-a318-6ae704002cf9 .ag-row[role='row']@ROWINDEX [col-id='cPlanifyForward']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<PlanningOptionsDialogView> OriginalOrder { get; set; } 
        public IRPSGridCheckbox<PlanningOptionsDialogView> PlanifyForward { get; set; } 
                     
    }
 
        public partial class OptionsAppliedModelCollectionCollectionEditor<PlanningOptionsDialogView>:RPSCollectionEditor<PlanningOptionsDialogView> where PlanningOptionsDialogView : class, IView
    {
        public  OptionsAppliedModelCollectionGridView<PlanningOptionsDialogView> GridView {get;set;}
    }
    public partial class OptionsAppliedModelCollectionGridView <PlanningOptionsDialogView> :  RPSGridView<PlanningOptionsDialogView> where PlanningOptionsDialogView : class, IView
    {
        public OptionsAppliedModelCollectionGridView(PlanningOptionsDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            OriginalOrder = RPSControlFactory.CreateRPSGridTextBox<PlanningOptionsDialogView>("","#a0503894-ed69-4bd1-aa76-334e04b8adb4 .ag-row[role='row']@ROWINDEX [col-id='cOriginalOrder']","",false, this.CurrentView);
 
            PlanifyForward = RPSControlFactory.CreateRPSGridCheckBox<PlanningOptionsDialogView>("","#a0503894-ed69-4bd1-aa76-334e04b8adb4 .ag-row[role='row']@ROWINDEX [col-id='cPlanifyForward']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<PlanningOptionsDialogView> OriginalOrder { get; set; } 
        public IRPSGridCheckbox<PlanningOptionsDialogView> PlanifyForward { get; set; } 
                     
    }
 
    }
  
            
    public partial class PlanningLogDialogView : View
    {
        public PlanningLogDialogView(Planification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NumPlanifs = RPSControlFactory.CreateRPSFormattedTextBox<PlanningLogDialogView>("ee03c13a-ef12-42e3-a7e8-831abdd3633a","","",false, this);
 
            NumPlanifsLinkedTasks = RPSControlFactory.CreateRPSFormattedTextBox<PlanningLogDialogView>("1bc4a87d-54a8-4221-9260-e10ecd27e06f","","",false, this);
 
            NumResourceCombinations = RPSControlFactory.CreateRPSFormattedTextBox<PlanningLogDialogView>("34833030-9036-4905-9734-859e41250b72","","",false, this);
 
            PlanifyErrors = RPSControlFactory.CreateRPSFormattedTextBox<PlanningLogDialogView>("65030a72-352f-4c24-badb-e6c67469f237","","",false, this);
 
            OrdenPlanificacion = RPSControlFactory.CreateRPSFormattedTextBox<PlanningLogDialogView>("c490f150-c7ce-4d8d-9f4d-5ac2346f2035","","",false, this);
 
            CollectionInit params_GetPlanningLog = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="9e62e9b1-a148-4e48-a02d-6fa9d02ba49c",CSSSelectorGrid="",XPathGrid=""};
            GetPlanningLog = RPSControlFactory.RPSCreateCollectionWithGrid<GetPlanningLogCollectionEditor<PlanningLogDialogView>,PlanningLogDialogView>( params_GetPlanningLog,this);
 
            CollectionInit params_GetPlanningLogDetail = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5307ba21-3d38-4698-b836-4779d245f4b3",CSSSelectorGrid="",XPathGrid=""};
            GetPlanningLogDetail = RPSControlFactory.RPSCreateCollectionWithGrid<GetPlanningLogDetailCollectionEditor<PlanningLogDialogView>,PlanningLogDialogView>( params_GetPlanningLogDetail,this);
 

        }
        public IRPSTextBox<PlanningLogDialogView> NumPlanifs { get; set; } 
        public IRPSTextBox<PlanningLogDialogView> NumPlanifsLinkedTasks { get; set; } 
        public IRPSTextBox<PlanningLogDialogView> NumResourceCombinations { get; set; } 
        public IRPSTextBox<PlanningLogDialogView> PlanifyErrors { get; set; } 
        public IRPSTextBox<PlanningLogDialogView> OrdenPlanificacion { get; set; } 
        public GetPlanningLogCollectionEditor<PlanningLogDialogView> GetPlanningLog { get; set; } 
        public GetPlanningLogDetailCollectionEditor<PlanningLogDialogView> GetPlanningLogDetail { get; set; } 
        public Planification Screen { get; set; }
        public PlanningLogDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetPlanningLogCollectionEditor<PlanningLogDialogView>:RPSCollectionEditor<PlanningLogDialogView> where PlanningLogDialogView : class, IView
    {
        public  GetPlanningLogGridView<PlanningLogDialogView> GridView {get;set;}
    }
    public partial class GetPlanningLogGridView <PlanningLogDialogView> :  RPSGridView<PlanningLogDialogView> where PlanningLogDialogView : class, IView
    {
        public GetPlanningLogGridView(PlanningLogDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NumPlanifs = RPSControlFactory.CreateRPSGridFormattedTextBox<PlanningLogDialogView>("","#9e62e9b1-a148-4e48-a02d-6fa9d02ba49c .ag-row[role='row']@ROWINDEX [col-id='cNumPlanifs']","",false, this.CurrentView);
 
            NumPlanifsLinkedTasks = RPSControlFactory.CreateRPSGridFormattedTextBox<PlanningLogDialogView>("","#9e62e9b1-a148-4e48-a02d-6fa9d02ba49c .ag-row[role='row']@ROWINDEX [col-id='cNumPlanifsLinkedTasks']","",false, this.CurrentView);
 
            NumResourceCombinations = RPSControlFactory.CreateRPSGridFormattedTextBox<PlanningLogDialogView>("","#9e62e9b1-a148-4e48-a02d-6fa9d02ba49c .ag-row[role='row']@ROWINDEX [col-id='cNumResourceCombinations']","",false, this.CurrentView);
 
            PlanifyErrors = RPSControlFactory.CreateRPSGridFormattedTextBox<PlanningLogDialogView>("","#9e62e9b1-a148-4e48-a02d-6fa9d02ba49c .ag-row[role='row']@ROWINDEX [col-id='cPlanifyErrors']","",false, this.CurrentView);
 
            StartDate = RPSControlFactory.CreateRPSGridTextBox<PlanningLogDialogView>("","#9e62e9b1-a148-4e48-a02d-6fa9d02ba49c .ag-row[role='row']@ROWINDEX [col-id='cStartDate']","",false, this.CurrentView);
 
            EndDate = RPSControlFactory.CreateRPSGridTextBox<PlanningLogDialogView>("","#9e62e9b1-a148-4e48-a02d-6fa9d02ba49c .ag-row[role='row']@ROWINDEX [col-id='cEndDate']","",false, this.CurrentView);
 
            Priority = RPSControlFactory.CreateRPSGridFormattedTextBox<PlanningLogDialogView>("","#9e62e9b1-a148-4e48-a02d-6fa9d02ba49c .ag-row[role='row']@ROWINDEX [col-id='cPriority']","",false, this.CurrentView);
 
            DeliveryDate = RPSControlFactory.CreateRPSGridTextBox<PlanningLogDialogView>("","#9e62e9b1-a148-4e48-a02d-6fa9d02ba49c .ag-row[role='row']@ROWINDEX [col-id='cDeliveryDate']","",false, this.CurrentView);
 
            OptimizationFeature = RPSControlFactory.CreateRPSGridTextBox<PlanningLogDialogView>("","#9e62e9b1-a148-4e48-a02d-6fa9d02ba49c .ag-row[role='row']@ROWINDEX [col-id='cOptimizationFeature']","",false, this.CurrentView);
 
            OrdenPlanificacion = RPSControlFactory.CreateRPSGridFormattedTextBox<PlanningLogDialogView>("","#9e62e9b1-a148-4e48-a02d-6fa9d02ba49c .ag-row[role='row']@ROWINDEX [col-id='cOrdenPlanificacion']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<PlanningLogDialogView> NumPlanifs { get; set; } 
        public IRPSGridTextBox<PlanningLogDialogView> NumPlanifsLinkedTasks { get; set; } 
        public IRPSGridTextBox<PlanningLogDialogView> NumResourceCombinations { get; set; } 
        public IRPSGridTextBox<PlanningLogDialogView> PlanifyErrors { get; set; } 
        public IRPSGridTextBox<PlanningLogDialogView> StartDate { get; set; } 
        public IRPSGridTextBox<PlanningLogDialogView> EndDate { get; set; } 
        public IRPSGridTextBox<PlanningLogDialogView> Priority { get; set; } 
        public IRPSGridTextBox<PlanningLogDialogView> DeliveryDate { get; set; } 
        public IRPSGridTextBox<PlanningLogDialogView> OptimizationFeature { get; set; } 
        public IRPSGridTextBox<PlanningLogDialogView> OrdenPlanificacion { get; set; } 
                     
    }
 
        public partial class GetPlanningLogDetailCollectionEditor<PlanningLogDialogView>:RPSCollectionEditor<PlanningLogDialogView> where PlanningLogDialogView : class, IView
    {
        public  GetPlanningLogDetailGridView<PlanningLogDialogView> GridView {get;set;}
    }
    public partial class GetPlanningLogDetailGridView <PlanningLogDialogView> :  RPSGridView<PlanningLogDialogView> where PlanningLogDialogView : class, IView
    {
        public GetPlanningLogDetailGridView(PlanningLogDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Description = RPSControlFactory.CreateRPSGridTextBox<PlanningLogDialogView>("","#5307ba21-3d38-4698-b836-4779d245f4b3 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<PlanningLogDialogView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class PlanningTaskView : View
    {
        public PlanningTaskView(Planification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIRootIDArticle = RPSControlFactory.CreateRPSComboBox<PlanningTaskView>("a7b772f3-4cc1-44be-8d7a-ad7977dcc032","","",false, this);
 
            UIRootEntitySituationDescription = RPSControlFactory.CreateRPSTextBox<PlanningTaskView>("3b0a1223-f9c8-46cc-a90c-04e89d5d0a76","","",false, this);
 
            UIRootPriority = RPSControlFactory.CreateRPSFormattedTextBox<PlanningTaskView>("41f15f1c-599b-45fb-be8e-764c6f8ecad8","","",false, this);
 
            UIRootInternalCode = RPSControlFactory.CreateRPSTextBox<PlanningTaskView>("720e3e9c-cc6a-4bf8-8419-c441e4d1c358","","",false, this);
 
            UICodigoERP = RPSControlFactory.CreateRPSTextBox<PlanningTaskView>("5463f406-276c-4050-90aa-3a2e051c7e38","","",false, this);
 
            UIDescription = RPSControlFactory.CreateRPSTextBox<PlanningTaskView>("1b75e719-2519-4416-a773-c392277fcbd0","","",false, this);
 
            UIActive = RPSControlFactory.CreateRPSCheckBox<PlanningTaskView>("8d516a45-e040-44ef-9c52-770c756a72fa","","",false, this);
 
            UITaskPriority = RPSControlFactory.CreateRPSFormattedTextBox<PlanningTaskView>("2276f2f0-ea6f-4e97-a6f7-e7c6b7bcdd5e","","",false, this);
 
            UIDurationS = RPSControlFactory.CreateRPSTextBox<PlanningTaskView>("c28c3308-c5e3-41b1-a583-5c9821817c5c","","",false, this);
 
            UIPreparationTimeS = RPSControlFactory.CreateRPSTextBox<PlanningTaskView>("0d0f4daa-e544-49a6-862a-c6942dc3c2bf","","",false, this);
 
            UIExecutionTimeS = RPSControlFactory.CreateRPSTextBox<PlanningTaskView>("e710bff8-0891-4a75-ae0c-a203844cf773","","",false, this);
 
            UIRealizedTimeS = RPSControlFactory.CreateRPSTextBox<PlanningTaskView>("54bb6b8b-b315-4bb9-a03f-0ab59ecad0da","","",false, this);
 
            UIStartDate = RPSControlFactory.CreateRPSTextBox<PlanningTaskView>("77226ecc-d606-4c64-bc7c-542775d9e240","","",false, this);
 
            UIStartTime = RPSControlFactory.CreateRPSTextBox<PlanningTaskView>("30737c61-ef67-4370-bb7a-aff0ea2119c6","","",false, this);
 
            UIEndDate = RPSControlFactory.CreateRPSTextBox<PlanningTaskView>("f2addd30-1ee6-4497-b994-64e43070fb2c","","",false, this);
 
            UIEndTime = RPSControlFactory.CreateRPSTextBox<PlanningTaskView>("6b368709-8c3c-4f36-800f-bfce36510023","","",false, this);
 
            UIDeliveryDate = RPSControlFactory.CreateRPSTextBox<PlanningTaskView>("1c836ff6-150b-461c-b32b-b6fadb25e5ec","","",false, this);
 
            UIDelimitationType = RPSControlFactory.CreateRPSEnumComboBox<PlanningTaskView>("a6d3ce4d-a90e-41a8-84a0-bd99cd1712c5","","",false, this);
 
            UIDelimitationDate = RPSControlFactory.CreateRPSTextBox<PlanningTaskView>("f401fc13-7ae6-4a4f-b177-d352b0e6268b","","",false, this);
 
            UIDelimitationTime = RPSControlFactory.CreateRPSTextBox<PlanningTaskView>("2bf248cb-a893-4f85-9084-7c949cd1a60f","","",false, this);
 
            UIDelimitationObligatory = RPSControlFactory.CreateRPSCheckBox<PlanningTaskView>("b5a8d383-cfac-4fdd-9b2b-d38ee791849a","","",false, this);
 
            UIPriority = RPSControlFactory.CreateRPSFormattedTextBox<PlanningTaskView>("7e0b4fae-92dc-4468-971c-9ba504c5f7fa","","",false, this);
 
            UIPlanningGroupColor = RPSControlFactory.CreateRPSColorEditor<PlanningTaskView>( "6a4924f9-64ff-47a6-934f-20fc6f18fd64","","",this);
 
            UIOptimizationCharacteristics = RPSControlFactory.CreateRPSTextBox<PlanningTaskView>("703f4b80-1f0f-47c4-a92e-bf2de8c5c79f","","",false, this);
 
            UIGroupingNumber = RPSControlFactory.CreateRPSTextBox<PlanningTaskView>("661e4a30-3c53-4af7-aea5-1a9ba8c810a5","","",false, this);
 
            UIFixed = RPSControlFactory.CreateRPSCheckBox<PlanningTaskView>("99ff9ae4-dbdb-4fb2-9210-36c202f9d0fe","","",false, this);
 
            UIAdjustDay = RPSControlFactory.CreateRPSCheckBox<PlanningTaskView>("89f222b1-3015-41b2-8f78-3798703e915f","","",false, this);
 
            UIIgnoreCalendar = RPSControlFactory.CreateRPSCheckBox<PlanningTaskView>("7e5d32ab-d96e-4530-b842-647bae0d8376","","",false, this);
 
            UISplit = RPSControlFactory.CreateRPSCheckBox<PlanningTaskView>("f9523dfd-6f35-4171-b55d-8d652c349c2f","","",false, this);
 
            UIMinimumSplit = RPSControlFactory.CreateRPSFormattedTextBox<PlanningTaskView>("41594619-cbd6-42af-965a-579dcdff7e0c","","",false, this);
 
            UIOccupancyType = RPSControlFactory.CreateRPSEnumComboBox<PlanningTaskView>("b4a3cfc0-eb18-40e6-a18e-49789c82dad1","","",false, this);
 
            UIOccupancyHours = RPSControlFactory.CreateRPSFormattedTextBox<PlanningTaskView>("96961715-6464-47f8-98ce-e5d9bdc19cd3","","",false, this);
 
            UIOccupancyPercent = RPSControlFactory.CreateRPSFormattedTextBox<PlanningTaskView>("fc40880f-3924-4e7a-b46f-e3df59c843de","","",false, this);
 
            UIBlockNumber = RPSControlFactory.CreateRPSFormattedTextBox<PlanningTaskView>("6ee87782-ceb1-4db0-ac68-6e4baa757dd5","","",false, this);
 
            UIResourcesPlanType = RPSControlFactory.CreateRPSEnumComboBox<PlanningTaskView>("e0526575-3477-4824-abdc-63c9ab04e157","","",true, this);
 
            UISplitNumber = RPSControlFactory.CreateRPSFormattedTextBox<PlanningTaskView>("411c5993-73f4-4536-929e-3a28cbd0a171","","",false, this);
 
            UINumericDV1 = RPSControlFactory.CreateRPSFormattedTextBox<PlanningTaskView>("83e64dbc-2e13-4c63-b1c2-c0ca33ed75b7","","",false, this);
 
            UINumericDV2 = RPSControlFactory.CreateRPSFormattedTextBox<PlanningTaskView>("8eab8966-1670-4430-a36c-3034aefd74ea","","",false, this);
 
            UINumericDV3 = RPSControlFactory.CreateRPSFormattedTextBox<PlanningTaskView>("39e38255-6b51-4f27-88f9-e3fe15df7617","","",false, this);
 
            UINumericDV4 = RPSControlFactory.CreateRPSFormattedTextBox<PlanningTaskView>("30ca0d66-47ca-4567-9e2c-c1dd4c68a497","","",false, this);
 
            UINumericDV5 = RPSControlFactory.CreateRPSFormattedTextBox<PlanningTaskView>("6b20d938-77b4-4073-9b3a-be054b78ccb7","","",false, this);
 
            UIStringDV1 = RPSControlFactory.CreateRPSTextBox<PlanningTaskView>("5108e0f0-75ac-42ad-8e04-ff29fb1b598f","","",false, this);
 
            UIStringDV2 = RPSControlFactory.CreateRPSTextBox<PlanningTaskView>("e322a5bc-70d9-442a-a361-8c55cf122d39","","",false, this);
 
            UIStringDV3 = RPSControlFactory.CreateRPSTextBox<PlanningTaskView>("90fc0cc1-4aa6-4ac0-8848-dc4d67abc0de","","",false, this);
 
            UIStringDV4 = RPSControlFactory.CreateRPSTextBox<PlanningTaskView>("f728fc2c-9a97-4bce-b4d4-70723841b646","","",false, this);
 
            UIStringDV5 = RPSControlFactory.CreateRPSTextBox<PlanningTaskView>("965fe904-f8d4-4086-916a-8f05aa48e8a1","","",false, this);
 
            NewPlanningTaskPredecessorNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<PlanningTaskView,NewPlanningTaskPredecessorDV>("26337001-001d-4ae2-aa30-08706cf71ce0","","", this,Screen.NewPlanningTaskPredecessorDV);
 
            RemovePlanningPredecessorsFromTaskButton = RPSControlFactory.CreateRPSButton<PlanningTaskView>( "62f33a14-81e6-4f4c-ac7c-45e83842281d","","",this);
 
            PlanningTaskAvailableResourcesNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<PlanningTaskView,PlanningTaskAvailableResourcesDialogView>("01eda828-6907-43e5-bfbf-42e57a9689a6","","", this,Screen.PlanningTaskAvailableResourcesDialogView);
 
            RemovePlanningresourcesCommandButton = RPSControlFactory.CreateRPSButton<PlanningTaskView>( "773afeef-9f86-4374-9c79-149274069f32","","",this);
 
            ExecuteSavePlanningTaskDataButton = RPSControlFactory.CreateRPSButton<PlanningTaskView>( "d5420517-1f8e-44f0-a0c2-1957d80c6db0","","",this);
 
            ExecutePropagatePriorityToPredecessorsButton = RPSControlFactory.CreateRPSButton<PlanningTaskView>( "2f046ea3-1584-458a-b333-5b483c4a1608","","",this);
 
            CollectionInit params_GetPlanningTaskDataPredecesors = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d2c525f8-3241-48a4-8459-515bbc7f2cad",CSSSelectorGrid="",XPathGrid=""};
            GetPlanningTaskDataPredecesors = RPSControlFactory.RPSCreateCollectionWithGrid<GetPlanningTaskDataPredecesorsCollectionEditor<PlanningTaskView,TimeOccupancyDialogView>,PlanningTaskView,TimeOccupancyDialogView>( params_GetPlanningTaskDataPredecesors,this,Screen.TimeOccupancyDialogView);
 
            CollectionInit params_GetPlanningTaskDataResources = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b97cb943-8f25-4fb4-8d09-c8feaa26f1f6",CSSSelectorGrid="",XPathGrid=""};
            GetPlanningTaskDataResources = RPSControlFactory.RPSCreateCollectionWithGrid<GetPlanningTaskDataResourcesCollectionEditor<PlanningTaskView,TimeOccupancyDialogView>,PlanningTaskView,TimeOccupancyDialogView>( params_GetPlanningTaskDataResources,this,Screen.TimeOccupancyDialogView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<PlanningTaskView>( "","ul li[rpsid='fd1385d3-34e9-4d87-9964-ae3b4375db25']","",this);
 
            Predecesors = RPSControlFactory.CreateRPSSection<PlanningTaskView>( "","ul li[rpsid='13661ea3-24f0-4d40-b649-719e3f430ad8']","",this);
 
            Resources = RPSControlFactory.CreateRPSSection<PlanningTaskView>( "","ul li[rpsid='5efede6d-e4e0-4176-8890-2731b063076c']","",this);
 

        }
        public IRPSComboBox<PlanningTaskView> UIRootIDArticle { get; set; } 
        public IRPSTextBox<PlanningTaskView> UIRootEntitySituationDescription { get; set; } 
        public IRPSTextBox<PlanningTaskView> UIRootPriority { get; set; } 
        public IRPSTextBox<PlanningTaskView> UIRootInternalCode { get; set; } 
        public IRPSTextBox<PlanningTaskView> UICodigoERP { get; set; } 
        public IRPSTextBox<PlanningTaskView> UIDescription { get; set; } 
        public IRPSCheckbox<PlanningTaskView> UIActive { get; set; } 
        public IRPSTextBox<PlanningTaskView> UITaskPriority { get; set; } 
        public IRPSTextBox<PlanningTaskView> UIDurationS { get; set; } 
        public IRPSTextBox<PlanningTaskView> UIPreparationTimeS { get; set; } 
        public IRPSTextBox<PlanningTaskView> UIExecutionTimeS { get; set; } 
        public IRPSTextBox<PlanningTaskView> UIRealizedTimeS { get; set; } 
        public IRPSTextBox<PlanningTaskView> UIStartDate { get; set; } 
        public IRPSTextBox<PlanningTaskView> UIStartTime { get; set; } 
        public IRPSTextBox<PlanningTaskView> UIEndDate { get; set; } 
        public IRPSTextBox<PlanningTaskView> UIEndTime { get; set; } 
        public IRPSTextBox<PlanningTaskView> UIDeliveryDate { get; set; } 
        public IRPSComboBox<PlanningTaskView> UIDelimitationType { get; set; } 
        public IRPSTextBox<PlanningTaskView> UIDelimitationDate { get; set; } 
        public IRPSTextBox<PlanningTaskView> UIDelimitationTime { get; set; } 
        public IRPSCheckbox<PlanningTaskView> UIDelimitationObligatory { get; set; } 
        public IRPSTextBox<PlanningTaskView> UIPriority { get; set; } 
        public IRPSColorEditor<PlanningTaskView> UIPlanningGroupColor { get; set; } 
        public IRPSTextBox<PlanningTaskView> UIOptimizationCharacteristics { get; set; } 
        public IRPSTextBox<PlanningTaskView> UIGroupingNumber { get; set; } 
        public IRPSCheckbox<PlanningTaskView> UIFixed { get; set; } 
        public IRPSCheckbox<PlanningTaskView> UIAdjustDay { get; set; } 
        public IRPSCheckbox<PlanningTaskView> UIIgnoreCalendar { get; set; } 
        public IRPSCheckbox<PlanningTaskView> UISplit { get; set; } 
        public IRPSTextBox<PlanningTaskView> UIMinimumSplit { get; set; } 
        public IRPSComboBox<PlanningTaskView> UIOccupancyType { get; set; } 
        public IRPSTextBox<PlanningTaskView> UIOccupancyHours { get; set; } 
        public IRPSTextBox<PlanningTaskView> UIOccupancyPercent { get; set; } 
        public IRPSTextBox<PlanningTaskView> UIBlockNumber { get; set; } 
        public IRPSComboBox<PlanningTaskView> UIResourcesPlanType { get; set; } 
        public IRPSTextBox<PlanningTaskView> UISplitNumber { get; set; } 
        public IRPSTextBox<PlanningTaskView> UINumericDV1 { get; set; } 
        public IRPSTextBox<PlanningTaskView> UINumericDV2 { get; set; } 
        public IRPSTextBox<PlanningTaskView> UINumericDV3 { get; set; } 
        public IRPSTextBox<PlanningTaskView> UINumericDV4 { get; set; } 
        public IRPSTextBox<PlanningTaskView> UINumericDV5 { get; set; } 
        public IRPSTextBox<PlanningTaskView> UIStringDV1 { get; set; } 
        public IRPSTextBox<PlanningTaskView> UIStringDV2 { get; set; } 
        public IRPSTextBox<PlanningTaskView> UIStringDV3 { get; set; } 
        public IRPSTextBox<PlanningTaskView> UIStringDV4 { get; set; } 
        public IRPSTextBox<PlanningTaskView> UIStringDV5 { get; set; } 
        public IRPSButton<PlanningTaskView,NewPlanningTaskPredecessorDV> NewPlanningTaskPredecessorNavigationCommandButton { get; set; } 
        public IRPSButton<PlanningTaskView> RemovePlanningPredecessorsFromTaskButton { get; set; } 
        public IRPSButton<PlanningTaskView,PlanningTaskAvailableResourcesDialogView> PlanningTaskAvailableResourcesNavigationCommandButton { get; set; } 
        public IRPSButton<PlanningTaskView> RemovePlanningresourcesCommandButton { get; set; } 
        public IRPSButton<PlanningTaskView> ExecuteSavePlanningTaskDataButton { get; set; } 
        public IRPSButton<PlanningTaskView> ExecutePropagatePriorityToPredecessorsButton { get; set; } 
        public GetPlanningTaskDataPredecesorsCollectionEditor<PlanningTaskView,TimeOccupancyDialogView> GetPlanningTaskDataPredecesors { get; set; } 
        public GetPlanningTaskDataResourcesCollectionEditor<PlanningTaskView,TimeOccupancyDialogView> GetPlanningTaskDataResources { get; set; } 
        public IRPSSection<PlanningTaskView> GeneralData { get; set; } 
        public IRPSSection<PlanningTaskView> Predecesors { get; set; } 
        public IRPSSection<PlanningTaskView> Resources { get; set; } 
        public Planification Screen { get; set; }
        public PlanningTaskView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetPlanningTaskDataPredecesorsCollectionEditor<PlanningTaskView,TimeOccupancyDialogView>:RPSCollectionEditor<PlanningTaskView,TimeOccupancyDialogView> where PlanningTaskView : class, IView where TimeOccupancyDialogView : class, IView
    {
        public  GetPlanningTaskDataPredecesorsGridView<PlanningTaskView,TimeOccupancyDialogView> GridView {get;set;}
    }
    public partial class GetPlanningTaskDataPredecesorsGridView <PlanningTaskView,TimeOccupancyDialogView> :  RPSGridView<PlanningTaskView,TimeOccupancyDialogView> where PlanningTaskView : class, IView where TimeOccupancyDialogView : class, IView
    {
        public GetPlanningTaskDataPredecesorsGridView(PlanningTaskView currentView,TimeOccupancyDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            eRelationType = RPSControlFactory.CreateRPSGridEnumComboBox<PlanningTaskView>("","#d2c525f8-3241-48a4-8459-515bbc7f2cad .ag-row[role='row']@ROWINDEX [col-id='ceRelationType']","",false, this.CurrentView);
 
            Decalaje = RPSControlFactory.CreateRPSGridFormattedTextBox<PlanningTaskView>("","#d2c525f8-3241-48a4-8459-515bbc7f2cad .ag-row[role='row']@ROWINDEX [col-id='cDecalaje']","",false, this.CurrentView);
 
            eTimeUnit = RPSControlFactory.CreateRPSGridEnumComboBox<PlanningTaskView>("","#d2c525f8-3241-48a4-8459-515bbc7f2cad .ag-row[role='row']@ROWINDEX [col-id='ceTimeUnit']","",false, this.CurrentView);
 
            Linked = RPSControlFactory.CreateRPSGridCheckBox<PlanningTaskView>("","#d2c525f8-3241-48a4-8459-515bbc7f2cad .ag-row[role='row']@ROWINDEX [col-id='cLinked']","",false, this.CurrentView);
 
            eCalendarType = RPSControlFactory.CreateRPSGridEnumComboBox<PlanningTaskView>("","#d2c525f8-3241-48a4-8459-515bbc7f2cad .ag-row[role='row']@ROWINDEX [col-id='ceCalendarType']","",false, this.CurrentView);
 
            bDependency = RPSControlFactory.CreateRPSGridCheckBox<PlanningTaskView>("","#d2c525f8-3241-48a4-8459-515bbc7f2cad .ag-row[role='row']@ROWINDEX [col-id='cbDependency']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<PlanningTaskView> eRelationType { get; set; } 
        public IRPSGridTextBox<PlanningTaskView> Decalaje { get; set; } 
        public IRPSGridComboBox<PlanningTaskView> eTimeUnit { get; set; } 
        public IRPSGridCheckbox<PlanningTaskView> Linked { get; set; } 
        public IRPSGridComboBox<PlanningTaskView> eCalendarType { get; set; } 
        public IRPSGridCheckbox<PlanningTaskView> bDependency { get; set; } 
                     
    }
 
        public partial class GetPlanningTaskDataResourcesCollectionEditor<PlanningTaskView,TimeOccupancyDialogView>:RPSCollectionEditor<PlanningTaskView,TimeOccupancyDialogView> where PlanningTaskView : class, IView where TimeOccupancyDialogView : class, IView
    {
        public  GetPlanningTaskDataResourcesGridView<PlanningTaskView,TimeOccupancyDialogView> GridView {get;set;}
    }
    public partial class GetPlanningTaskDataResourcesGridView <PlanningTaskView,TimeOccupancyDialogView> :  RPSGridView<PlanningTaskView,TimeOccupancyDialogView> where PlanningTaskView : class, IView where TimeOccupancyDialogView : class, IView
    {
        public GetPlanningTaskDataResourcesGridView(PlanningTaskView currentView,TimeOccupancyDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ResourceType = RPSControlFactory.CreateRPSGridTextBox<PlanningTaskView>("","#b97cb943-8f25-4fb4-8d09-c8feaa26f1f6 .ag-row[role='row']@ROWINDEX [col-id='cResourceType']","",false, this.CurrentView);
 
            CodTask = RPSControlFactory.CreateRPSGridTextBox<PlanningTaskView>("","#b97cb943-8f25-4fb4-8d09-c8feaa26f1f6 .ag-row[role='row']@ROWINDEX [col-id='cCodTask']","",false, this.CurrentView);
 
            Variable = RPSControlFactory.CreateRPSGridCheckBox<PlanningTaskView>("","#b97cb943-8f25-4fb4-8d09-c8feaa26f1f6 .ag-row[role='row']@ROWINDEX [col-id='cVariable']","",false, this.CurrentView);
 
            Dedication = RPSControlFactory.CreateRPSGridFormattedTextBox<PlanningTaskView>("","#b97cb943-8f25-4fb4-8d09-c8feaa26f1f6 .ag-row[role='row']@ROWINDEX [col-id='cDedication']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<PlanningTaskView> ResourceType { get; set; } 
        public IRPSGridTextBox<PlanningTaskView> CodTask { get; set; } 
        public IRPSGridCheckbox<PlanningTaskView> Variable { get; set; } 
        public IRPSGridTextBox<PlanningTaskView> Dedication { get; set; } 
                     
    }
 
    }
  
            
    public partial class PlanningRresourceView : View
    {
        public PlanningRresourceView(Planification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDEmployee = RPSControlFactory.CreateRPSComboBox<PlanningRresourceView>("db547442-c587-484a-84e2-e45228fa3573","","",false, this);
 
            IDMachine = RPSControlFactory.CreateRPSComboBox<PlanningRresourceView>("e166cda1-0ea4-4961-b0a5-dae43d581090","","",false, this);
 
            IDTool = RPSControlFactory.CreateRPSComboBox<PlanningRresourceView>("c19f484c-df3f-4ab3-beda-49e9e3311c79","","",false, this);
 
            ResourceType = RPSControlFactory.CreateRPSTextBox<PlanningRresourceView>("879a85a1-47da-4ddc-87c5-4a37841f7da1","","",false, this);
 
            CodTask = RPSControlFactory.CreateRPSTextBox<PlanningRresourceView>("f6a6fb41-b7b9-462a-999f-02e42d2abc37","","",false, this);
 
            Variable = RPSControlFactory.CreateRPSCheckBox<PlanningRresourceView>("8518298b-ad74-4bb7-bd44-9f5fa7b68403","","",false, this);
 
            Dedication = RPSControlFactory.CreateRPSFormattedTextBox<PlanningRresourceView>("0e4f55fa-7022-4f0a-b284-bf842bbcd21f","","",false, this);
 
            IDQualify = RPSControlFactory.CreateRPSComboBox<PlanningRresourceView>("bd518622-d9de-4ec3-b5b1-c088c3e42e3d","","",false, this);
 
            IDMachineGroup = RPSControlFactory.CreateRPSComboBox<PlanningRresourceView>("8716b627-e5b0-4344-b1ef-a8e8085ae04b","","",false, this);
 
            Duration = RPSControlFactory.CreateRPSFormattedTextBox<PlanningRresourceView>("c791468d-1858-49e7-96f3-d4a8415955c9","","",false, this);
 
            PercentProgress = RPSControlFactory.CreateRPSFormattedTextBox<PlanningRresourceView>("a984c07d-dc86-48d7-a5e6-b57c6793b2a4","","",false, this);
 
            DurationTheoric = RPSControlFactory.CreateRPSFormattedTextBox<PlanningRresourceView>("58158c19-a566-434f-9a2e-36daa6951835","","",false, this);
 
            IDResource = RPSControlFactory.CreateRPSTextBox<PlanningRresourceView>("e6496186-2352-47b8-be2d-51d73801bfba","","",false, this);
 
            ExecuteSavePlanningResourceDataButton = RPSControlFactory.CreateRPSButton<PlanningRresourceView>( "b77b40a5-c94f-4252-8bcc-ed8b26f720a9","","",this);
 

        }
        public IRPSComboBox<PlanningRresourceView> IDEmployee { get; set; } 
        public IRPSComboBox<PlanningRresourceView> IDMachine { get; set; } 
        public IRPSComboBox<PlanningRresourceView> IDTool { get; set; } 
        public IRPSTextBox<PlanningRresourceView> ResourceType { get; set; } 
        public IRPSTextBox<PlanningRresourceView> CodTask { get; set; } 
        public IRPSCheckbox<PlanningRresourceView> Variable { get; set; } 
        public IRPSTextBox<PlanningRresourceView> Dedication { get; set; } 
        public IRPSComboBox<PlanningRresourceView> IDQualify { get; set; } 
        public IRPSComboBox<PlanningRresourceView> IDMachineGroup { get; set; } 
        public IRPSTextBox<PlanningRresourceView> Duration { get; set; } 
        public IRPSTextBox<PlanningRresourceView> PercentProgress { get; set; } 
        public IRPSTextBox<PlanningRresourceView> DurationTheoric { get; set; } 
        public IRPSTextBox<PlanningRresourceView> IDResource { get; set; } 
        public IRPSButton<PlanningRresourceView> ExecuteSavePlanningResourceDataButton { get; set; } 
        public Planification Screen { get; set; }
        public PlanningRresourceView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PlanningTaskPredecesorView : View
    {
        public PlanningTaskPredecesorView(Planification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIManufacturingOrder = RPSControlFactory.CreateRPSComboBox<PlanningTaskPredecesorView>("0900bf10-368a-46ec-9ebb-4b49106108e3","","",false, this);
 
            UIMOTask = RPSControlFactory.CreateRPSComboBox<PlanningTaskPredecesorView>("d013c005-8b62-4413-bc6a-55e17a613d7c","","",false, this);
 
            UIProject = RPSControlFactory.CreateRPSComboBox<PlanningTaskPredecesorView>("81964ff8-7387-4eef-b4c6-b00589858f20","","",false, this);
 
            UIProjectTask = RPSControlFactory.CreateRPSComboBox<PlanningTaskPredecesorView>("4f342056-1508-43d5-a999-f4b50da7b227","","",false, this);
 
            UIMaintenanceOrder = RPSControlFactory.CreateRPSComboBox<PlanningTaskPredecesorView>("19a4899b-8da9-448c-b363-4f49bcb2beda","","",false, this);
 
            UIRelationType = RPSControlFactory.CreateRPSEnumComboBox<PlanningTaskPredecesorView>("b1717122-68eb-4b5a-b40d-8487218080fd","","",false, this);
 
            UIOffSet = RPSControlFactory.CreateRPSFormattedTextBox<PlanningTaskPredecesorView>("a8614c97-c74b-459a-9de7-c608dbba2572","","",false, this);
 
            UITimeUnit = RPSControlFactory.CreateRPSEnumComboBox<PlanningTaskPredecesorView>("b99d1b2d-b796-49bf-82ff-bd057cb07c29","","",false, this);
 
            UILinked = RPSControlFactory.CreateRPSCheckBox<PlanningTaskPredecesorView>("78d4f05d-f5b3-46cb-8a43-0dd333e3c96d","","",false, this);
 
            UICalendarType = RPSControlFactory.CreateRPSEnumComboBox<PlanningTaskPredecesorView>("dcaed75c-a796-43cb-9a5f-ad6a87bd61e6","","",false, this);
 
            UIDependency = RPSControlFactory.CreateRPSCheckBox<PlanningTaskPredecesorView>("3c89bf80-23ca-4833-bd73-ec4b28bf0d8c","","",false, this);
 
            ExecuteSavePlanningPredecesorTaskDataButton = RPSControlFactory.CreateRPSButton<PlanningTaskPredecesorView>( "3f332c86-31a9-4885-ba0f-7c52b4eaf6a6","","",this);
 

        }
        public IRPSComboBox<PlanningTaskPredecesorView> UIManufacturingOrder { get; set; } 
        public IRPSComboBox<PlanningTaskPredecesorView> UIMOTask { get; set; } 
        public IRPSComboBox<PlanningTaskPredecesorView> UIProject { get; set; } 
        public IRPSComboBox<PlanningTaskPredecesorView> UIProjectTask { get; set; } 
        public IRPSComboBox<PlanningTaskPredecesorView> UIMaintenanceOrder { get; set; } 
        public IRPSComboBox<PlanningTaskPredecesorView> UIRelationType { get; set; } 
        public IRPSTextBox<PlanningTaskPredecesorView> UIOffSet { get; set; } 
        public IRPSComboBox<PlanningTaskPredecesorView> UITimeUnit { get; set; } 
        public IRPSCheckbox<PlanningTaskPredecesorView> UILinked { get; set; } 
        public IRPSComboBox<PlanningTaskPredecesorView> UICalendarType { get; set; } 
        public IRPSCheckbox<PlanningTaskPredecesorView> UIDependency { get; set; } 
        public IRPSButton<PlanningTaskPredecesorView> ExecuteSavePlanningPredecesorTaskDataButton { get; set; } 
        public Planification Screen { get; set; }
        public PlanningTaskPredecesorView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class TimeOccupancyDialogView : View
    {
        public TimeOccupancyDialogView(Planification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UICodEntity = RPSControlFactory.CreateRPSTextBox<TimeOccupancyDialogView>("61b4583e-c4b4-4f4b-bf9c-a4a6f8838294","","",false, this);
 
            UIOnlyTaskInCriticalPath = RPSControlFactory.CreateRPSCheckBox<TimeOccupancyDialogView>("fa082275-149e-4e51-a287-2d3f092728f6","","",false, this);
 
            UIViewAllResourcesInGroups = RPSControlFactory.CreateRPSCheckBox<TimeOccupancyDialogView>("0fe9ec03-1fb0-4914-8375-1d37181a4db8","","",false, this);
 
            UIHalfYear = RPSControlFactory.CreateRPSCheckBox<TimeOccupancyDialogView>("64a4e7f3-8a1f-4f54-bd48-4dc303af1f99","","",false, this);
 
            UIQuarters = RPSControlFactory.CreateRPSCheckBox<TimeOccupancyDialogView>("572049ec-f7be-4bb7-a81c-334600549189","","",false, this);
 
            ExecuteGetPlanningOccupancyData = RPSControlFactory.CreateRPSButton<TimeOccupancyDialogView>( "a1ad6856-5911-4958-be02-330e5a2dd017","","",this);
 

        }
        public IRPSTextBox<TimeOccupancyDialogView> UICodEntity { get; set; } 
        public IRPSCheckbox<TimeOccupancyDialogView> UIOnlyTaskInCriticalPath { get; set; } 
        public IRPSCheckbox<TimeOccupancyDialogView> UIViewAllResourcesInGroups { get; set; } 
        public IRPSCheckbox<TimeOccupancyDialogView> UIHalfYear { get; set; } 
        public IRPSCheckbox<TimeOccupancyDialogView> UIQuarters { get; set; } 
        public IRPSButton<TimeOccupancyDialogView> ExecuteGetPlanningOccupancyData { get; set; } 
        public Planification Screen { get; set; }
        public TimeOccupancyDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PlanificationCalendarView : View
    {
        public PlanificationCalendarView(Planification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ExecuteCreateNewPlanningCalendarButton = RPSControlFactory.CreateRPSButton<PlanificationCalendarView>( "c7632af1-630b-4aee-b116-7ffbd85cf9c4","","",this);
 
            ExecuteCreateNewPlanningCalendarChildButton = RPSControlFactory.CreateRPSButton<PlanificationCalendarView>( "52af5429-3c7e-43d9-aa48-218e2263b379","","",this);
 
            ExecuteSavePlanningCalendarsButton = RPSControlFactory.CreateRPSButton<PlanificationCalendarView>( "7242b69b-d7af-4632-a73b-6f2f99c51597","","",this);
 

        }
        public IRPSButton<PlanificationCalendarView> ExecuteCreateNewPlanningCalendarButton { get; set; } 
        public IRPSButton<PlanificationCalendarView> ExecuteCreateNewPlanningCalendarChildButton { get; set; } 
        public IRPSButton<PlanificationCalendarView> ExecuteSavePlanningCalendarsButton { get; set; } 
        public Planification Screen { get; set; }
        public PlanificationCalendarView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PlanificationCalendarDetailView : View
    {
        public PlanificationCalendarDetailView(Planification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ExecuteSavePlanningCalendarData = RPSControlFactory.CreateRPSButton<PlanificationCalendarDetailView>( "67b5cdac-b870-441e-8f4d-7934b0c688b9","","",this);
 
            CodCalendar = RPSControlFactory.CreateRPSTextBox<PlanificationCalendarDetailView>("ab8bec73-d059-4bd8-a5bd-c06300139cef","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<PlanificationCalendarDetailView>("7e3bf6f1-6c35-4812-bf62-da5b0751a29d","","",false, this);
 
            UIGetHigherCalendars = RPSControlFactory.CreateRPSCheckBox<PlanificationCalendarDetailView>("8255a343-6e65-47de-857d-6f7bc43a10ac","","",false, this);
 
            UISeeActiveCalendars = RPSControlFactory.CreateRPSCheckBox<PlanificationCalendarDetailView>("c53e74e9-c4b0-4fd7-91f1-b58e6114135a","","",false, this);
 
            ExecuteCreateNewPlanningCalendarDetail = RPSControlFactory.CreateRPSButton<PlanificationCalendarDetailView>( "f25634f5-b904-4217-b401-ca06ac42f022","","",this);
 
            CollectionInit params_GetPlanningCalendarDetail = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b6507fad-a9e1-4a3a-b996-76a0c1bf0bdf",CSSSelectorGrid="",XPathGrid=""};
            GetPlanningCalendarDetail = RPSControlFactory.RPSCreateCollectionWithGrid<GetPlanningCalendarDetailCollectionEditor<PlanificationCalendarDetailView>,PlanificationCalendarDetailView>( params_GetPlanningCalendarDetail,this);
 
            Preview = RPSControlFactory.CreateRPSSection<PlanificationCalendarDetailView>( "","ul li[rpsid='9334f78b-1134-4743-9b57-c8d27eb496a8']","",this);
 
            Edition = RPSControlFactory.CreateRPSSection<PlanificationCalendarDetailView>( "","ul li[rpsid='b466c71a-a5a6-46e6-b6bf-05bfaa710d66']","",this);
 

        }
        public IRPSButton<PlanificationCalendarDetailView> ExecuteSavePlanningCalendarData { get; set; } 
        public IRPSTextBox<PlanificationCalendarDetailView> CodCalendar { get; set; } 
        public IRPSTextBox<PlanificationCalendarDetailView> Description { get; set; } 
        public IRPSCheckbox<PlanificationCalendarDetailView> UIGetHigherCalendars { get; set; } 
        public IRPSCheckbox<PlanificationCalendarDetailView> UISeeActiveCalendars { get; set; } 
        public IRPSButton<PlanificationCalendarDetailView> ExecuteCreateNewPlanningCalendarDetail { get; set; } 
        public GetPlanningCalendarDetailCollectionEditor<PlanificationCalendarDetailView> GetPlanningCalendarDetail { get; set; } 
        public IRPSSection<PlanificationCalendarDetailView> Preview { get; set; } 
        public IRPSSection<PlanificationCalendarDetailView> Edition { get; set; } 
        public Planification Screen { get; set; }
        public PlanificationCalendarDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetPlanningCalendarDetailCollectionEditor<PlanificationCalendarDetailView>:RPSCollectionEditor<PlanificationCalendarDetailView> where PlanificationCalendarDetailView : class, IView
    {
        public  GetPlanningCalendarDetailGridView<PlanificationCalendarDetailView> GridView {get;set;}
    }
    public partial class GetPlanningCalendarDetailGridView <PlanificationCalendarDetailView> :  RPSGridView<PlanificationCalendarDetailView> where PlanificationCalendarDetailView : class, IView
    {
        public GetPlanningCalendarDetailGridView(PlanificationCalendarDetailView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeleteCalendarDetComm = RPSControlFactory.CreateRPSGridButton<PlanificationCalendarDetailView>( "","#b6507fad-a9e1-4a3a-b996-76a0c1bf0bdf .ag-row[role='row']@ROWINDEX [col-id='cDeleteCalendarDetComm']","",this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<PlanificationCalendarDetailView>("","#b6507fad-a9e1-4a3a-b996-76a0c1bf0bdf .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<PlanificationCalendarDetailView>("","#b6507fad-a9e1-4a3a-b996-76a0c1bf0bdf .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",false, this.CurrentView);
 
            DateTo = RPSControlFactory.CreateRPSGridTextBox<PlanificationCalendarDetailView>("","#b6507fad-a9e1-4a3a-b996-76a0c1bf0bdf .ag-row[role='row']@ROWINDEX [col-id='cDateTo']","",false, this.CurrentView);
 
            Priority = RPSControlFactory.CreateRPSGridFormattedTextBox<PlanificationCalendarDetailView>("","#b6507fad-a9e1-4a3a-b996-76a0c1bf0bdf .ag-row[role='row']@ROWINDEX [col-id='cPriority']","",false, this.CurrentView);
 

        }
        public IRPSGridButton<PlanificationCalendarDetailView> DeleteCalendarDetComm { get; set; } 
        public IRPSGridTextBox<PlanificationCalendarDetailView> Description { get; set; } 
        public IRPSGridTextBox<PlanificationCalendarDetailView> DateFrom { get; set; } 
        public IRPSGridTextBox<PlanificationCalendarDetailView> DateTo { get; set; } 
        public IRPSGridTextBox<PlanificationCalendarDetailView> Priority { get; set; } 
                     
    }
 
    }
  
            
    public partial class PlanificationCalendarDetailDataView : View
    {
        public PlanificationCalendarDetailDataView(Planification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DayExpression = RPSControlFactory.CreateRPSTextBox<PlanificationCalendarDetailDataView>("1f255477-cfbb-4741-b0d8-47ef6c97a5ac","","",false, this);
 
            TimeExpression = RPSControlFactory.CreateRPSTextBox<PlanificationCalendarDetailDataView>("c787fbda-07fc-44b4-a8ea-f8444b2c3a7e","","",false, this);
 
            UIDescription = RPSControlFactory.CreateRPSTextBox<PlanificationCalendarDetailDataView>("f41f3dc6-ead5-4289-a4a0-f690079ba4e4","","",false, this);
 
            UIDateFrom = RPSControlFactory.CreateRPSTextBox<PlanificationCalendarDetailDataView>("2376887d-be95-4111-a98d-c521a6cafa54","","",false, this);
 
            UIDateTo = RPSControlFactory.CreateRPSTextBox<PlanificationCalendarDetailDataView>("e8cf8046-98d6-4ab4-99da-9966f00e0dbc","","",false, this);
 
            UIPriority = RPSControlFactory.CreateRPSFormattedTextBox<PlanificationCalendarDetailDataView>("10be6bdd-266f-44fa-bced-aef0d6de3fc6","","",false, this);
 
            UICalendarDetailType = RPSControlFactory.CreateRPSComboBox<PlanificationCalendarDetailDataView>("062fd68e-6d47-421e-abdc-3daf274517c6","","",false, this);
 
            UIOptAllDays = RPSControlFactory.CreateRPSOption<PlanificationCalendarDetailDataView>( "c553467b-30ad-45fe-8f0f-81c586682933","","",this);
 
            UIOptWeek = RPSControlFactory.CreateRPSOption<PlanificationCalendarDetailDataView>( "8335cbe2-54f8-422a-8c2e-1fdffaf468a9","","",this);
 
            UIMonday = RPSControlFactory.CreateRPSCheckBox<PlanificationCalendarDetailDataView>("487f02e3-9423-44ae-9ca3-504f4d0c3337","","",false, this);
 
            UITuesday = RPSControlFactory.CreateRPSCheckBox<PlanificationCalendarDetailDataView>("a15c4ded-149b-471f-9c0e-f360a71b0bd8","","",false, this);
 
            UIWednesday = RPSControlFactory.CreateRPSCheckBox<PlanificationCalendarDetailDataView>("6d5bbfd8-1569-4d17-9871-c6de7892a4f7","","",false, this);
 
            UIThursday = RPSControlFactory.CreateRPSCheckBox<PlanificationCalendarDetailDataView>("0e5c1afc-97f5-4970-8275-0d440c5d4f1b","","",false, this);
 
            UIFriday = RPSControlFactory.CreateRPSCheckBox<PlanificationCalendarDetailDataView>("5ed3eb48-5596-45eb-879d-dc2a754297bd","","",false, this);
 
            UISaturday = RPSControlFactory.CreateRPSCheckBox<PlanificationCalendarDetailDataView>("60be9d9f-5c46-4bf2-ab73-023abcaccc0c","","",false, this);
 
            UISunday = RPSControlFactory.CreateRPSCheckBox<PlanificationCalendarDetailDataView>("cbd0f0b3-cea7-4c50-8dea-c09ec4d6dcf2","","",false, this);
 
            UIOptDateRange = RPSControlFactory.CreateRPSOption<PlanificationCalendarDetailDataView>( "a0db362a-dd05-4eed-b3c5-5a9a768039f0","","",this);
 
            UIDateFromExpression = RPSControlFactory.CreateRPSTextBox<PlanificationCalendarDetailDataView>("8da2c8a6-ccee-4968-8931-4a4f1be2eac9","","",false, this);
 
            UIDateToExpression = RPSControlFactory.CreateRPSTextBox<PlanificationCalendarDetailDataView>("86a13aeb-8be4-4694-820a-d67fa574d5ce","","",false, this);
 
            UIOptDates = RPSControlFactory.CreateRPSOption<PlanificationCalendarDetailDataView>( "b746d7e9-e9e4-417d-8cc0-f0e0eaa00d27","","",this);
 
            NewDateNavigationCommand = RPSControlFactory.CreateRPSButtonToView<PlanificationCalendarDetailDataView,NewDateDialogView>("b4552542-7b27-42a0-9428-33e13871a286","","", this,Screen.NewDateDialogView);
 
            DayExpressionDates = RPSControlFactory.CreateRPSTextBox<PlanificationCalendarDetailDataView>("63d3ba31-5c00-4bd1-80c2-fb1ace658a2a","","",false, this);
 
            FreeDay = RPSControlFactory.CreateRPSCheckBox<PlanificationCalendarDetailDataView>("c45d3556-dc51-40cb-a2fd-de285ba8c450","","",false, this);
 
            NewHourIntervalNavigationCommand = RPSControlFactory.CreateRPSButtonToView<PlanificationCalendarDetailDataView,NewHourIntervalDialogView>("960106b3-8433-41f9-994e-512c55ff1c5e","","", this,Screen.NewHourIntervalDialogView);
 
            ExecuteSavePlanningCalendarDetailDataButton = RPSControlFactory.CreateRPSButton<PlanificationCalendarDetailDataView>( "23cab4cb-1ccf-47a2-8242-6dc1784b13e9","","",this);
 
            CollectionInit params_GetHourIntervalsFromTimeExpresion = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="bc70d060-f53a-4efa-8ea8-c5d6ebf84558",CSSSelectorGrid="",XPathGrid=""};
            GetHourIntervalsFromTimeExpresion = RPSControlFactory.RPSCreateCollectionWithGrid<GetHourIntervalsFromTimeExpresionCollectionEditor<PlanificationCalendarDetailDataView,NewHourIntervalDialogView>,PlanificationCalendarDetailDataView,NewHourIntervalDialogView>( params_GetHourIntervalsFromTimeExpresion,this,Screen.NewHourIntervalDialogView);
 

        }
        public IRPSTextBox<PlanificationCalendarDetailDataView> DayExpression { get; set; } 
        public IRPSTextBox<PlanificationCalendarDetailDataView> TimeExpression { get; set; } 
        public IRPSTextBox<PlanificationCalendarDetailDataView> UIDescription { get; set; } 
        public IRPSTextBox<PlanificationCalendarDetailDataView> UIDateFrom { get; set; } 
        public IRPSTextBox<PlanificationCalendarDetailDataView> UIDateTo { get; set; } 
        public IRPSTextBox<PlanificationCalendarDetailDataView> UIPriority { get; set; } 
        public IRPSComboBox<PlanificationCalendarDetailDataView> UICalendarDetailType { get; set; } 
        public IRPSOption<PlanificationCalendarDetailDataView> UIOptAllDays { get; set; } 
        public IRPSOption<PlanificationCalendarDetailDataView> UIOptWeek { get; set; } 
        public IRPSCheckbox<PlanificationCalendarDetailDataView> UIMonday { get; set; } 
        public IRPSCheckbox<PlanificationCalendarDetailDataView> UITuesday { get; set; } 
        public IRPSCheckbox<PlanificationCalendarDetailDataView> UIWednesday { get; set; } 
        public IRPSCheckbox<PlanificationCalendarDetailDataView> UIThursday { get; set; } 
        public IRPSCheckbox<PlanificationCalendarDetailDataView> UIFriday { get; set; } 
        public IRPSCheckbox<PlanificationCalendarDetailDataView> UISaturday { get; set; } 
        public IRPSCheckbox<PlanificationCalendarDetailDataView> UISunday { get; set; } 
        public IRPSOption<PlanificationCalendarDetailDataView> UIOptDateRange { get; set; } 
        public IRPSTextBox<PlanificationCalendarDetailDataView> UIDateFromExpression { get; set; } 
        public IRPSTextBox<PlanificationCalendarDetailDataView> UIDateToExpression { get; set; } 
        public IRPSOption<PlanificationCalendarDetailDataView> UIOptDates { get; set; } 
        public IRPSButton<PlanificationCalendarDetailDataView,NewDateDialogView> NewDateNavigationCommand { get; set; } 
        public IRPSTextBox<PlanificationCalendarDetailDataView> DayExpressionDates { get; set; } 
        public IRPSCheckbox<PlanificationCalendarDetailDataView> FreeDay { get; set; } 
        public IRPSButton<PlanificationCalendarDetailDataView,NewHourIntervalDialogView> NewHourIntervalNavigationCommand { get; set; } 
        public IRPSButton<PlanificationCalendarDetailDataView> ExecuteSavePlanningCalendarDetailDataButton { get; set; } 
        public GetHourIntervalsFromTimeExpresionCollectionEditor<PlanificationCalendarDetailDataView,NewHourIntervalDialogView> GetHourIntervalsFromTimeExpresion { get; set; } 
        public Planification Screen { get; set; }
        public PlanificationCalendarDetailDataView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetHourIntervalsFromTimeExpresionCollectionEditor<PlanificationCalendarDetailDataView,NewHourIntervalDialogView>:RPSCollectionEditor<PlanificationCalendarDetailDataView,NewHourIntervalDialogView> where PlanificationCalendarDetailDataView : class, IView where NewHourIntervalDialogView : class, IView
    {
        public  GetHourIntervalsFromTimeExpresionGridView<PlanificationCalendarDetailDataView,NewHourIntervalDialogView> GridView {get;set;}
    }
    public partial class GetHourIntervalsFromTimeExpresionGridView <PlanificationCalendarDetailDataView,NewHourIntervalDialogView> :  RPSGridView<PlanificationCalendarDetailDataView,NewHourIntervalDialogView> where PlanificationCalendarDetailDataView : class, IView where NewHourIntervalDialogView : class, IView
    {
        public GetHourIntervalsFromTimeExpresionGridView(PlanificationCalendarDetailDataView currentView,NewHourIntervalDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeleteHourIntervalCommand = RPSControlFactory.CreateRPSGridButton<PlanificationCalendarDetailDataView>( "","#bc70d060-f53a-4efa-8ea8-c5d6ebf84558 .ag-row[role='row']@ROWINDEX [col-id='cDeleteHourIntervalCommand']","",this.CurrentView);
 
            HourFrom = RPSControlFactory.CreateRPSGridTextBox<PlanificationCalendarDetailDataView>("","#bc70d060-f53a-4efa-8ea8-c5d6ebf84558 .ag-row[role='row']@ROWINDEX [col-id='cHourFrom']","",false, this.CurrentView);
 
            HourTo = RPSControlFactory.CreateRPSGridTextBox<PlanificationCalendarDetailDataView>("","#bc70d060-f53a-4efa-8ea8-c5d6ebf84558 .ag-row[role='row']@ROWINDEX [col-id='cHourTo']","",false, this.CurrentView);
 

        }
        public IRPSGridButton<PlanificationCalendarDetailDataView> DeleteHourIntervalCommand { get; set; } 
        public IRPSGridTextBox<PlanificationCalendarDetailDataView> HourFrom { get; set; } 
        public IRPSGridTextBox<PlanificationCalendarDetailDataView> HourTo { get; set; } 
                     
    }
 
    }
  
            
    public partial class NewHourIntervalDialogView : View
    {
        public NewHourIntervalDialogView(Planification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIDateFrom = RPSControlFactory.CreateRPSTextBox<NewHourIntervalDialogView>("82c08e36-711c-4a36-b870-885123b9f8d1","","",false, this);
 
            UIDateTo = RPSControlFactory.CreateRPSTextBox<NewHourIntervalDialogView>("f997dcfb-ac36-49ab-9c1e-538e3f1d3436","","",false, this);
 

        }
        public IRPSTextBox<NewHourIntervalDialogView> UIDateFrom { get; set; } 
        public IRPSTextBox<NewHourIntervalDialogView> UIDateTo { get; set; } 
        public Planification Screen { get; set; }
        public NewHourIntervalDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NewDateDialogView : View
    {
        public NewDateDialogView(Planification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewDate = RPSControlFactory.CreateRPSTextBox<NewDateDialogView>("2a5adb00-8c53-42ed-b2b5-52e9661df2e2","","",false, this);
 
            AddNewDate = RPSControlFactory.CreateRPSButton<NewDateDialogView>( "62f5ad54-f01c-4b77-820e-79be5181d4b4","","",this);
 
            CollectionInit params_GetDatesFromDateExpresion = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="86f76109-040c-49cd-8bee-93627d06b5b3",CSSSelectorGrid="",XPathGrid=""};
            GetDatesFromDateExpresion = RPSControlFactory.RPSCreateCollectionWithGrid<GetDatesFromDateExpresionCollectionEditor<NewDateDialogView>,NewDateDialogView>( params_GetDatesFromDateExpresion,this);
 

        }
        public IRPSTextBox<NewDateDialogView> NewDate { get; set; } 
        public IRPSButton<NewDateDialogView> AddNewDate { get; set; } 
        public GetDatesFromDateExpresionCollectionEditor<NewDateDialogView> GetDatesFromDateExpresion { get; set; } 
        public Planification Screen { get; set; }
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
            DeleteDateCommand = RPSControlFactory.CreateRPSGridButton<NewDateDialogView>( "","#86f76109-040c-49cd-8bee-93627d06b5b3 .ag-row[role='row']@ROWINDEX [col-id='cDeleteDateCommand']","",this.CurrentView);
 
            Date = RPSControlFactory.CreateRPSGridTextBox<NewDateDialogView>("","#86f76109-040c-49cd-8bee-93627d06b5b3 .ag-row[role='row']@ROWINDEX [col-id='cDate']","",false, this.CurrentView);
 

        }
        public IRPSGridButton<NewDateDialogView> DeleteDateCommand { get; set; } 
        public IRPSGridTextBox<NewDateDialogView> Date { get; set; } 
                     
    }
 
    }
  
            
    public partial class FixBlocksDialogView : View
    {
        public FixBlocksDialogView(Planification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIOptFixBlocks = RPSControlFactory.CreateRPSOption<FixBlocksDialogView>( "7a9108a4-1f02-4dac-99f2-05efc796754d","","",this);
 
            UIOptReleaseFixedBlocks = RPSControlFactory.CreateRPSOption<FixBlocksDialogView>( "4724d6d9-5c21-4f54-bc77-7e3d0a82d811","","",this);
 
            UIOptFixSelectedTasks = RPSControlFactory.CreateRPSOption<FixBlocksDialogView>( "456fbb44-d869-410c-ac18-3184d4f40885","","",this);
 
            UIOptUnFixSelectedTasks = RPSControlFactory.CreateRPSOption<FixBlocksDialogView>( "9b46d8d0-2f8d-48e6-9deb-b02093714d5a","","",this);
 
            UIOptAll = RPSControlFactory.CreateRPSOption<FixBlocksDialogView>( "ad773d2b-b30c-4bd9-a8ce-5f035604af97","","",this);
 
            UIOptSelected = RPSControlFactory.CreateRPSOption<FixBlocksDialogView>( "b3ee3267-0985-4b50-885e-488e77931612","","",this);
 
            UIOptDates = RPSControlFactory.CreateRPSOption<FixBlocksDialogView>( "ce3d5f91-601b-4fa6-99cd-5bbd5f66adac","","",this);
 
            UIDateFrom = RPSControlFactory.CreateRPSTextBox<FixBlocksDialogView>("88f26359-421b-48df-bea8-c108045207cf","","",false, this);
 
            UIDateTo = RPSControlFactory.CreateRPSTextBox<FixBlocksDialogView>("62b8f24b-7824-4017-8ccc-a5f8f73b6832","","",false, this);
 

        }
        public IRPSOption<FixBlocksDialogView> UIOptFixBlocks { get; set; } 
        public IRPSOption<FixBlocksDialogView> UIOptReleaseFixedBlocks { get; set; } 
        public IRPSOption<FixBlocksDialogView> UIOptFixSelectedTasks { get; set; } 
        public IRPSOption<FixBlocksDialogView> UIOptUnFixSelectedTasks { get; set; } 
        public IRPSOption<FixBlocksDialogView> UIOptAll { get; set; } 
        public IRPSOption<FixBlocksDialogView> UIOptSelected { get; set; } 
        public IRPSOption<FixBlocksDialogView> UIOptDates { get; set; } 
        public IRPSTextBox<FixBlocksDialogView> UIDateFrom { get; set; } 
        public IRPSTextBox<FixBlocksDialogView> UIDateTo { get; set; } 
        public Planification Screen { get; set; }
        public FixBlocksDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PlanningTaskOverloadedView : View
    {
        public PlanningTaskOverloadedView(Planification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_GetPlanningTaskOverloaded = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="396067b8-8838-4359-82a8-a07a4a7d8420",CSSSelectorGrid="",XPathGrid=""};
            GetPlanningTaskOverloaded = RPSControlFactory.RPSCreateCollectionWithGrid<GetPlanningTaskOverloadedCollectionEditor<PlanningTaskOverloadedView>,PlanningTaskOverloadedView>( params_GetPlanningTaskOverloaded,this);
 

        }
        public GetPlanningTaskOverloadedCollectionEditor<PlanningTaskOverloadedView> GetPlanningTaskOverloaded { get; set; } 
        public Planification Screen { get; set; }
        public PlanningTaskOverloadedView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetPlanningTaskOverloadedCollectionEditor<PlanningTaskOverloadedView>:RPSCollectionEditor<PlanningTaskOverloadedView> where PlanningTaskOverloadedView : class, IView
    {
        public  GetPlanningTaskOverloadedGridView<PlanningTaskOverloadedView> GridView {get;set;}
    }
    public partial class GetPlanningTaskOverloadedGridView <PlanningTaskOverloadedView> :  RPSGridView<PlanningTaskOverloadedView> where PlanningTaskOverloadedView : class, IView
    {
        public GetPlanningTaskOverloadedGridView(PlanningTaskOverloadedView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Start = RPSControlFactory.CreateRPSGridTextBox<PlanningTaskOverloadedView>("","#396067b8-8838-4359-82a8-a07a4a7d8420 .ag-row[role='row']@ROWINDEX [col-id='cStart']","",false, this.CurrentView);
 
            End = RPSControlFactory.CreateRPSGridTextBox<PlanningTaskOverloadedView>("","#396067b8-8838-4359-82a8-a07a4a7d8420 .ag-row[role='row']@ROWINDEX [col-id='cEnd']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<PlanningTaskOverloadedView> Start { get; set; } 
        public IRPSGridTextBox<PlanningTaskOverloadedView> End { get; set; } 
                     
    }
 
    }
  
            
    public partial class LocateTaskDialogView : View
    {
        public LocateTaskDialogView(Planification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            EntitiesFilter = RPSControlFactory.CreateRPSTextBox<LocateTaskDialogView>("54b4578f-0a9e-44e6-a985-6731e15435fe","","",false, this);
 
            TasksFilter = RPSControlFactory.CreateRPSTextBox<LocateTaskDialogView>("1aba39ee-8ba3-4845-9671-a263ef8b228b","","",false, this);
 
            CollectionInit params_GetPlanningTasksToLocate = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="99fdad1c-1551-4521-83b8-635e6f3def58",CSSSelectorGrid="",XPathGrid=""};
            GetPlanningTasksToLocate = RPSControlFactory.RPSCreateCollectionWithGrid<GetPlanningTasksToLocateCollectionEditor<LocateTaskDialogView>,LocateTaskDialogView>( params_GetPlanningTasksToLocate,this);
 

        }
        public IRPSTextBox<LocateTaskDialogView> EntitiesFilter { get; set; } 
        public IRPSTextBox<LocateTaskDialogView> TasksFilter { get; set; } 
        public GetPlanningTasksToLocateCollectionEditor<LocateTaskDialogView> GetPlanningTasksToLocate { get; set; } 
        public Planification Screen { get; set; }
        public LocateTaskDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetPlanningTasksToLocateCollectionEditor<LocateTaskDialogView>:RPSCollectionEditor<LocateTaskDialogView> where LocateTaskDialogView : class, IView
    {
        public  GetPlanningTasksToLocateGridView<LocateTaskDialogView> GridView {get;set;}
    }
    public partial class GetPlanningTasksToLocateGridView <LocateTaskDialogView> :  RPSGridView<LocateTaskDialogView> where LocateTaskDialogView : class, IView
    {
        public GetPlanningTasksToLocateGridView(LocateTaskDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            SourceType = RPSControlFactory.CreateRPSGridTextBox<LocateTaskDialogView>("","#99fdad1c-1551-4521-83b8-635e6f3def58 .ag-row[role='row']@ROWINDEX [col-id='cSourceType']","",false, this.CurrentView);
 
            InternalCode = RPSControlFactory.CreateRPSGridTextBox<LocateTaskDialogView>("","#99fdad1c-1551-4521-83b8-635e6f3def58 .ag-row[role='row']@ROWINDEX [col-id='cInternalCode']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<LocateTaskDialogView> SourceType { get; set; } 
        public IRPSGridTextBox<LocateTaskDialogView> InternalCode { get; set; } 
                     
    }
 
    }
  
            
    public partial class PlanningTaskAvailableResourcesDialogView : View
    {
        public PlanningTaskAvailableResourcesDialogView(Planification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_GetPlanningAvailableEmployees = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ce801c24-babe-4492-afc0-4bdfe356f66d",CSSSelectorGrid="",XPathGrid=""};
            GetPlanningAvailableEmployees = RPSControlFactory.RPSCreateCollectionWithGrid<GetPlanningAvailableEmployeesCollectionEditor<PlanningTaskAvailableResourcesDialogView>,PlanningTaskAvailableResourcesDialogView>( params_GetPlanningAvailableEmployees,this);
 
            CollectionInit params_GetPlanningAvailableMachines = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="839e96f4-74aa-482a-bafd-0abe2001ed6a",CSSSelectorGrid="",XPathGrid=""};
            GetPlanningAvailableMachines = RPSControlFactory.RPSCreateCollectionWithGrid<GetPlanningAvailableMachinesCollectionEditor<PlanningTaskAvailableResourcesDialogView>,PlanningTaskAvailableResourcesDialogView>( params_GetPlanningAvailableMachines,this);
 
            CollectionInit params_GetPlanningAvailableTools = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ae205f03-ce6f-48e2-8584-b44267cd575e",CSSSelectorGrid="",XPathGrid=""};
            GetPlanningAvailableTools = RPSControlFactory.RPSCreateCollectionWithGrid<GetPlanningAvailableToolsCollectionEditor<PlanningTaskAvailableResourcesDialogView>,PlanningTaskAvailableResourcesDialogView>( params_GetPlanningAvailableTools,this);
 
            CollectionInit params_GetPlanningAvailableMachineGroups = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="76bebf2b-f44d-4105-a124-7c0c4c2aa6c6",CSSSelectorGrid="",XPathGrid=""};
            GetPlanningAvailableMachineGroups = RPSControlFactory.RPSCreateCollectionWithGrid<GetPlanningAvailableMachineGroupsCollectionEditor<PlanningTaskAvailableResourcesDialogView>,PlanningTaskAvailableResourcesDialogView>( params_GetPlanningAvailableMachineGroups,this);
 
            CollectionInit params_GetPlanningAvailableQualifications = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="983dc9f2-2bce-4080-a2d2-624bdbc681e6",CSSSelectorGrid="",XPathGrid=""};
            GetPlanningAvailableQualifications = RPSControlFactory.RPSCreateCollectionWithGrid<GetPlanningAvailableQualificationsCollectionEditor<PlanningTaskAvailableResourcesDialogView>,PlanningTaskAvailableResourcesDialogView>( params_GetPlanningAvailableQualifications,this);
 
            Employee = RPSControlFactory.CreateRPSSection<PlanningTaskAvailableResourcesDialogView>( "","ul li[rpsid='b1209793-2122-465a-b724-34ed2c7b608c']","",this);
 
            Machine = RPSControlFactory.CreateRPSSection<PlanningTaskAvailableResourcesDialogView>( "","ul li[rpsid='1f0b0732-7a7b-4350-bffe-7b16d8b8f3f9']","",this);
 
            Tool = RPSControlFactory.CreateRPSSection<PlanningTaskAvailableResourcesDialogView>( "","ul li[rpsid='81600278-239a-431d-968a-dfd090bc02d0']","",this);
 
            MachineGroup = RPSControlFactory.CreateRPSSection<PlanningTaskAvailableResourcesDialogView>( "","ul li[rpsid='22af6d02-ec7f-470f-a860-341552a4887d']","",this);
 
            Qualify = RPSControlFactory.CreateRPSSection<PlanningTaskAvailableResourcesDialogView>( "","ul li[rpsid='c2827f03-f00e-4e3e-a52d-b966cfafca5a']","",this);
 

        }
        public GetPlanningAvailableEmployeesCollectionEditor<PlanningTaskAvailableResourcesDialogView> GetPlanningAvailableEmployees { get; set; } 
        public GetPlanningAvailableMachinesCollectionEditor<PlanningTaskAvailableResourcesDialogView> GetPlanningAvailableMachines { get; set; } 
        public GetPlanningAvailableToolsCollectionEditor<PlanningTaskAvailableResourcesDialogView> GetPlanningAvailableTools { get; set; } 
        public GetPlanningAvailableMachineGroupsCollectionEditor<PlanningTaskAvailableResourcesDialogView> GetPlanningAvailableMachineGroups { get; set; } 
        public GetPlanningAvailableQualificationsCollectionEditor<PlanningTaskAvailableResourcesDialogView> GetPlanningAvailableQualifications { get; set; } 
        public IRPSSection<PlanningTaskAvailableResourcesDialogView> Employee { get; set; } 
        public IRPSSection<PlanningTaskAvailableResourcesDialogView> Machine { get; set; } 
        public IRPSSection<PlanningTaskAvailableResourcesDialogView> Tool { get; set; } 
        public IRPSSection<PlanningTaskAvailableResourcesDialogView> MachineGroup { get; set; } 
        public IRPSSection<PlanningTaskAvailableResourcesDialogView> Qualify { get; set; } 
        public Planification Screen { get; set; }
        public PlanningTaskAvailableResourcesDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetPlanningAvailableEmployeesCollectionEditor<PlanningTaskAvailableResourcesDialogView>:RPSCollectionEditor<PlanningTaskAvailableResourcesDialogView> where PlanningTaskAvailableResourcesDialogView : class, IView
    {
        public  GetPlanningAvailableEmployeesGridView<PlanningTaskAvailableResourcesDialogView> GridView {get;set;}
    }
    public partial class GetPlanningAvailableEmployeesGridView <PlanningTaskAvailableResourcesDialogView> :  RPSGridView<PlanningTaskAvailableResourcesDialogView> where PlanningTaskAvailableResourcesDialogView : class, IView
    {
        public GetPlanningAvailableEmployeesGridView(PlanningTaskAvailableResourcesDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Fictitious = RPSControlFactory.CreateRPSGridCheckBox<PlanningTaskAvailableResourcesDialogView>("","#ce801c24-babe-4492-afc0-4bdfe356f66d .ag-row[role='row']@ROWINDEX [col-id='cFictitious']","",false, this.CurrentView);
 

        }
        public IRPSGridCheckbox<PlanningTaskAvailableResourcesDialogView> Fictitious { get; set; } 
                     
    }
 
        public partial class GetPlanningAvailableMachinesCollectionEditor<PlanningTaskAvailableResourcesDialogView>:RPSCollectionEditor<PlanningTaskAvailableResourcesDialogView> where PlanningTaskAvailableResourcesDialogView : class, IView
    {
        public  GetPlanningAvailableMachinesGridView<PlanningTaskAvailableResourcesDialogView> GridView {get;set;}
    }
    public partial class GetPlanningAvailableMachinesGridView <PlanningTaskAvailableResourcesDialogView> :  RPSGridView<PlanningTaskAvailableResourcesDialogView> where PlanningTaskAvailableResourcesDialogView : class, IView
    {
        public GetPlanningAvailableMachinesGridView(PlanningTaskAvailableResourcesDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Fictitious = RPSControlFactory.CreateRPSGridCheckBox<PlanningTaskAvailableResourcesDialogView>("","#839e96f4-74aa-482a-bafd-0abe2001ed6a .ag-row[role='row']@ROWINDEX [col-id='cFictitious']","",false, this.CurrentView);
 

        }
        public IRPSGridCheckbox<PlanningTaskAvailableResourcesDialogView> Fictitious { get; set; } 
                     
    }
 
        public partial class GetPlanningAvailableToolsCollectionEditor<PlanningTaskAvailableResourcesDialogView>:RPSCollectionEditor<PlanningTaskAvailableResourcesDialogView> where PlanningTaskAvailableResourcesDialogView : class, IView
    {
        public  GetPlanningAvailableToolsGridView<PlanningTaskAvailableResourcesDialogView> GridView {get;set;}
    }
    public partial class GetPlanningAvailableToolsGridView <PlanningTaskAvailableResourcesDialogView> :  RPSGridView<PlanningTaskAvailableResourcesDialogView> where PlanningTaskAvailableResourcesDialogView : class, IView
    {
        public GetPlanningAvailableToolsGridView(PlanningTaskAvailableResourcesDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {

        }
                     
    }
 
        public partial class GetPlanningAvailableMachineGroupsCollectionEditor<PlanningTaskAvailableResourcesDialogView>:RPSCollectionEditor<PlanningTaskAvailableResourcesDialogView> where PlanningTaskAvailableResourcesDialogView : class, IView
    {
        public  GetPlanningAvailableMachineGroupsGridView<PlanningTaskAvailableResourcesDialogView> GridView {get;set;}
    }
    public partial class GetPlanningAvailableMachineGroupsGridView <PlanningTaskAvailableResourcesDialogView> :  RPSGridView<PlanningTaskAvailableResourcesDialogView> where PlanningTaskAvailableResourcesDialogView : class, IView
    {
        public GetPlanningAvailableMachineGroupsGridView(PlanningTaskAvailableResourcesDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {

        }
                     
    }
 
        public partial class GetPlanningAvailableQualificationsCollectionEditor<PlanningTaskAvailableResourcesDialogView>:RPSCollectionEditor<PlanningTaskAvailableResourcesDialogView> where PlanningTaskAvailableResourcesDialogView : class, IView
    {
        public  GetPlanningAvailableQualificationsGridView<PlanningTaskAvailableResourcesDialogView> GridView {get;set;}
    }
    public partial class GetPlanningAvailableQualificationsGridView <PlanningTaskAvailableResourcesDialogView> :  RPSGridView<PlanningTaskAvailableResourcesDialogView> where PlanningTaskAvailableResourcesDialogView : class, IView
    {
        public GetPlanningAvailableQualificationsGridView(PlanningTaskAvailableResourcesDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {

        }
                     
    }
 
    }
  
            
    public partial class PlanningUndoDialogView : View
    {
        public PlanningUndoDialogView(Planification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_GetPlanningUndo = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="21bc16f4-a681-4c53-a814-a961deef8b40",CSSSelectorGrid="",XPathGrid=""};
            GetPlanningUndo = RPSControlFactory.RPSCreateCollectionWithGrid<GetPlanningUndoCollectionEditor<PlanningUndoDialogView>,PlanningUndoDialogView>( params_GetPlanningUndo,this);
 

        }
        public GetPlanningUndoCollectionEditor<PlanningUndoDialogView> GetPlanningUndo { get; set; } 
        public Planification Screen { get; set; }
        public PlanningUndoDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetPlanningUndoCollectionEditor<PlanningUndoDialogView>:RPSCollectionEditor<PlanningUndoDialogView> where PlanningUndoDialogView : class, IView
    {
        public  GetPlanningUndoGridView<PlanningUndoDialogView> GridView {get;set;}
    }
    public partial class GetPlanningUndoGridView <PlanningUndoDialogView> :  RPSGridView<PlanningUndoDialogView> where PlanningUndoDialogView : class, IView
    {
        public GetPlanningUndoGridView(PlanningUndoDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Description = RPSControlFactory.CreateRPSGridTextBox<PlanningUndoDialogView>("","#21bc16f4-a681-4c53-a814-a961deef8b40 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<PlanningUndoDialogView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class PlanningRedoDialogView : View
    {
        public PlanningRedoDialogView(Planification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_GetPlanningRedo = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="464a9fac-f010-42cd-acdf-56467277a91e",CSSSelectorGrid="",XPathGrid=""};
            GetPlanningRedo = RPSControlFactory.RPSCreateCollectionWithGrid<GetPlanningRedoCollectionEditor<PlanningRedoDialogView>,PlanningRedoDialogView>( params_GetPlanningRedo,this);
 

        }
        public GetPlanningRedoCollectionEditor<PlanningRedoDialogView> GetPlanningRedo { get; set; } 
        public Planification Screen { get; set; }
        public PlanningRedoDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetPlanningRedoCollectionEditor<PlanningRedoDialogView>:RPSCollectionEditor<PlanningRedoDialogView> where PlanningRedoDialogView : class, IView
    {
        public  GetPlanningRedoGridView<PlanningRedoDialogView> GridView {get;set;}
    }
    public partial class GetPlanningRedoGridView <PlanningRedoDialogView> :  RPSGridView<PlanningRedoDialogView> where PlanningRedoDialogView : class, IView
    {
        public GetPlanningRedoGridView(PlanningRedoDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Description = RPSControlFactory.CreateRPSGridTextBox<PlanningRedoDialogView>("","#464a9fac-f010-42cd-acdf-56467277a91e .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<PlanningRedoDialogView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class ConvertResourcesDialogView : View
    {
        public ConvertResourcesDialogView(Planification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIConvertToNoFicticious = RPSControlFactory.CreateRPSOption<ConvertResourcesDialogView>( "3ffe0911-c92d-4288-8b09-d6714731f98a","","",this);
 
            UIConvertToExternalTask = RPSControlFactory.CreateRPSOption<ConvertResourcesDialogView>( "e99a5bc2-58a0-472e-86b4-df1fa86af9ac","","",this);
 
            UIArticle = RPSControlFactory.CreateRPSComboBox<ConvertResourcesDialogView>("fceb0f2c-f774-47e8-b039-094e2e1c308b","","",false, this);
 
            UISupplier = RPSControlFactory.CreateRPSComboBox<ConvertResourcesDialogView>("1be082c3-7f5a-4226-9c7e-eaf21baa878d","","",false, this);
 
            UIQuantity = RPSControlFactory.CreateRPSFormattedTextBox<ConvertResourcesDialogView>("f99c9b64-8ab1-47ca-a0b6-dfdbe3e81b59","","",false, this);
 

        }
        public IRPSOption<ConvertResourcesDialogView> UIConvertToNoFicticious { get; set; } 
        public IRPSOption<ConvertResourcesDialogView> UIConvertToExternalTask { get; set; } 
        public IRPSComboBox<ConvertResourcesDialogView> UIArticle { get; set; } 
        public IRPSComboBox<ConvertResourcesDialogView> UISupplier { get; set; } 
        public IRPSTextBox<ConvertResourcesDialogView> UIQuantity { get; set; } 
        public Planification Screen { get; set; }
        public ConvertResourcesDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PendingPlanningDialogView : View
    {
        public PendingPlanningDialogView(Planification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_GetPendingMOForManualPlanning = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="e331ff34-5e8a-4859-bf61-fec65e6e3f0d",CSSSelectorGrid="",XPathGrid=""};
            GetPendingMOForManualPlanning = RPSControlFactory.RPSCreateCollectionWithGrid<GetPendingMOForManualPlanningCollectionEditor<PendingPlanningDialogView>,PendingPlanningDialogView>( params_GetPendingMOForManualPlanning,this);
 
            CollectionInit params_GetPendingProjectForManualPlanning = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ba4ae543-fd8c-4a2e-be21-5b0100cd335f",CSSSelectorGrid="",XPathGrid=""};
            GetPendingProjectForManualPlanning = RPSControlFactory.RPSCreateCollectionWithGrid<GetPendingProjectForManualPlanningCollectionEditor<PendingPlanningDialogView>,PendingPlanningDialogView>( params_GetPendingProjectForManualPlanning,this);
 
            CollectionInit params_GetPendingManOrderForManualPlanning = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="37aa8769-c28b-4643-81ac-199e588efaf0",CSSSelectorGrid="",XPathGrid=""};
            GetPendingManOrderForManualPlanning = RPSControlFactory.RPSCreateCollectionWithGrid<GetPendingManOrderForManualPlanningCollectionEditor<PendingPlanningDialogView>,PendingPlanningDialogView>( params_GetPendingManOrderForManualPlanning,this);
 
            CollectionInit params_GetPendingTasksForManualPlanning = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7dcbe427-d574-4ff2-bb00-fe9654a12d93",CSSSelectorGrid="",XPathGrid=""};
            GetPendingTasksForManualPlanning = RPSControlFactory.RPSCreateCollectionWithGrid<GetPendingTasksForManualPlanningCollectionEditor<PendingPlanningDialogView>,PendingPlanningDialogView>( params_GetPendingTasksForManualPlanning,this);
 
            ManufacturingOrder = RPSControlFactory.CreateRPSSection<PendingPlanningDialogView>( "","ul li[rpsid='4a44404f-92cd-4ab0-b007-c7c28a05b3d3']","",this);
 
            Project = RPSControlFactory.CreateRPSSection<PendingPlanningDialogView>( "","ul li[rpsid='de949c30-6046-450b-a435-11faa9c35cb9']","",this);
 
            MaintenanceOrder = RPSControlFactory.CreateRPSSection<PendingPlanningDialogView>( "","ul li[rpsid='fdb7607d-d656-473d-9828-cc81306809c2']","",this);
 
            Tasks = RPSControlFactory.CreateRPSSection<PendingPlanningDialogView>( "","ul li[rpsid='31f8338a-0794-490f-bd7a-975e1af16916']","",this);
 

        }
        public GetPendingMOForManualPlanningCollectionEditor<PendingPlanningDialogView> GetPendingMOForManualPlanning { get; set; } 
        public GetPendingProjectForManualPlanningCollectionEditor<PendingPlanningDialogView> GetPendingProjectForManualPlanning { get; set; } 
        public GetPendingManOrderForManualPlanningCollectionEditor<PendingPlanningDialogView> GetPendingManOrderForManualPlanning { get; set; } 
        public GetPendingTasksForManualPlanningCollectionEditor<PendingPlanningDialogView> GetPendingTasksForManualPlanning { get; set; } 
        public IRPSSection<PendingPlanningDialogView> ManufacturingOrder { get; set; } 
        public IRPSSection<PendingPlanningDialogView> Project { get; set; } 
        public IRPSSection<PendingPlanningDialogView> MaintenanceOrder { get; set; } 
        public IRPSSection<PendingPlanningDialogView> Tasks { get; set; } 
        public Planification Screen { get; set; }
        public PendingPlanningDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetPendingMOForManualPlanningCollectionEditor<PendingPlanningDialogView>:RPSCollectionEditor<PendingPlanningDialogView> where PendingPlanningDialogView : class, IView
    {
        public  GetPendingMOForManualPlanningGridView<PendingPlanningDialogView> GridView {get;set;}
    }
    public partial class GetPendingMOForManualPlanningGridView <PendingPlanningDialogView> :  RPSGridView<PendingPlanningDialogView> where PendingPlanningDialogView : class, IView
    {
        public GetPendingMOForManualPlanningGridView(PendingPlanningDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeliveryDate = RPSControlFactory.CreateRPSGridTextBox<PendingPlanningDialogView>("","#e331ff34-5e8a-4859-bf61-fec65e6e3f0d .ag-row[role='row']@ROWINDEX [col-id='cDeliveryDate']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<PendingPlanningDialogView>("","#e331ff34-5e8a-4859-bf61-fec65e6e3f0d .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<PendingPlanningDialogView> DeliveryDate { get; set; } 
        public IRPSGridTextBox<PendingPlanningDialogView> Quantity { get; set; } 
                     
    }
 
        public partial class GetPendingProjectForManualPlanningCollectionEditor<PendingPlanningDialogView>:RPSCollectionEditor<PendingPlanningDialogView> where PendingPlanningDialogView : class, IView
    {
        public  GetPendingProjectForManualPlanningGridView<PendingPlanningDialogView> GridView {get;set;}
    }
    public partial class GetPendingProjectForManualPlanningGridView <PendingPlanningDialogView> :  RPSGridView<PendingPlanningDialogView> where PendingPlanningDialogView : class, IView
    {
        public GetPendingProjectForManualPlanningGridView(PendingPlanningDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeliveryDate = RPSControlFactory.CreateRPSGridTextBox<PendingPlanningDialogView>("","#ba4ae543-fd8c-4a2e-be21-5b0100cd335f .ag-row[role='row']@ROWINDEX [col-id='cDeliveryDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<PendingPlanningDialogView> DeliveryDate { get; set; } 
                     
    }
 
        public partial class GetPendingManOrderForManualPlanningCollectionEditor<PendingPlanningDialogView>:RPSCollectionEditor<PendingPlanningDialogView> where PendingPlanningDialogView : class, IView
    {
        public  GetPendingManOrderForManualPlanningGridView<PendingPlanningDialogView> GridView {get;set;}
    }
    public partial class GetPendingManOrderForManualPlanningGridView <PendingPlanningDialogView> :  RPSGridView<PendingPlanningDialogView> where PendingPlanningDialogView : class, IView
    {
        public GetPendingManOrderForManualPlanningGridView(PendingPlanningDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeliveryDate = RPSControlFactory.CreateRPSGridTextBox<PendingPlanningDialogView>("","#37aa8769-c28b-4643-81ac-199e588efaf0 .ag-row[role='row']@ROWINDEX [col-id='cDeliveryDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<PendingPlanningDialogView> DeliveryDate { get; set; } 
                     
    }
 
        public partial class GetPendingTasksForManualPlanningCollectionEditor<PendingPlanningDialogView>:RPSCollectionEditor<PendingPlanningDialogView> where PendingPlanningDialogView : class, IView
    {
        public  GetPendingTasksForManualPlanningGridView<PendingPlanningDialogView> GridView {get;set;}
    }
    public partial class GetPendingTasksForManualPlanningGridView <PendingPlanningDialogView> :  RPSGridView<PendingPlanningDialogView> where PendingPlanningDialogView : class, IView
    {
        public GetPendingTasksForManualPlanningGridView(PendingPlanningDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            EntityType = RPSControlFactory.CreateRPSGridTextBox<PendingPlanningDialogView>("","#7dcbe427-d574-4ff2-bb00-fe9654a12d93 .ag-row[role='row']@ROWINDEX [col-id='cEntityType']","",false, this.CurrentView);
 
            DeliveryDate = RPSControlFactory.CreateRPSGridTextBox<PendingPlanningDialogView>("","#7dcbe427-d574-4ff2-bb00-fe9654a12d93 .ag-row[role='row']@ROWINDEX [col-id='cDeliveryDate']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<PendingPlanningDialogView>("","#7dcbe427-d574-4ff2-bb00-fe9654a12d93 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            Duration = RPSControlFactory.CreateRPSGridFormattedTextBox<PendingPlanningDialogView>("","#7dcbe427-d574-4ff2-bb00-fe9654a12d93 .ag-row[role='row']@ROWINDEX [col-id='cDuration']","",false, this.CurrentView);
 
            Priority = RPSControlFactory.CreateRPSGridFormattedTextBox<PendingPlanningDialogView>("","#7dcbe427-d574-4ff2-bb00-fe9654a12d93 .ag-row[role='row']@ROWINDEX [col-id='cPriority']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<PendingPlanningDialogView> EntityType { get; set; } 
        public IRPSGridTextBox<PendingPlanningDialogView> DeliveryDate { get; set; } 
        public IRPSGridTextBox<PendingPlanningDialogView> Quantity { get; set; } 
        public IRPSGridTextBox<PendingPlanningDialogView> Duration { get; set; } 
        public IRPSGridTextBox<PendingPlanningDialogView> Priority { get; set; } 
                     
    }
 
    }
  
            
    public partial class PlanningStartDateDialogView : View
    {
        public PlanningStartDateDialogView(Planification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIStartDate = RPSControlFactory.CreateRPSTextBox<PlanningStartDateDialogView>("14006d39-f1ec-49a1-8eae-ca0d27570fae","","",false, this);
 

        }
        public IRPSTextBox<PlanningStartDateDialogView> UIStartDate { get; set; } 
        public Planification Screen { get; set; }
        public PlanningStartDateDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class InternalCodesDialogView : View
    {
        public InternalCodesDialogView(Planification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewCommandButton = RPSControlFactory.CreateRPSButton<InternalCodesDialogView>( "0b73f6c2-0ea2-4d95-af7f-1f54323d4f65","","",this);
 
            DeleteCommandButton = RPSControlFactory.CreateRPSButton<InternalCodesDialogView>( "4b2173b4-7ef1-4314-8dc8-0bbe445c88dc","","",this);
 
            PlanComm = RPSControlFactory.CreateRPSButton<InternalCodesDialogView>( "4805520e-911c-4243-9aa0-91c857eae404","","",this);
 
            CancelComm = RPSControlFactory.CreateRPSButton<InternalCodesDialogView>( "7a059bd9-7a3a-4d10-87be-9aebd30c87a2","","",this);
 
            CollectionInit params_InternalCodes = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="24cfae1a-e59b-40dd-a18e-e283601fe720",CSSSelectorGrid="",XPathGrid=""};
            InternalCodes = RPSControlFactory.RPSCreateCollectionWithGrid<InternalCodesCollectionEditor<InternalCodesDialogView>,InternalCodesDialogView>( params_InternalCodes,this);
 

        }
        public IRPSButton<InternalCodesDialogView> NewCommandButton { get; set; } 
        public IRPSButton<InternalCodesDialogView> DeleteCommandButton { get; set; } 
        public IRPSButton<InternalCodesDialogView> PlanComm { get; set; } 
        public IRPSButton<InternalCodesDialogView> CancelComm { get; set; } 
        public InternalCodesCollectionEditor<InternalCodesDialogView> InternalCodes { get; set; } 
        public Planification Screen { get; set; }
        public InternalCodesDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class InternalCodesCollectionEditor<InternalCodesDialogView>:RPSCollectionEditor<InternalCodesDialogView> where InternalCodesDialogView : class, IView
    {
        public  InternalCodesGridView<InternalCodesDialogView> GridView {get;set;}
    }
    public partial class InternalCodesGridView <InternalCodesDialogView> :  RPSGridView<InternalCodesDialogView> where InternalCodesDialogView : class, IView
    {
        public InternalCodesGridView(InternalCodesDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            InternalCode = RPSControlFactory.CreateRPSGridEnumComboBox<InternalCodesDialogView>("","#24cfae1a-e59b-40dd-a18e-e283601fe720 .ag-row[role='row']@ROWINDEX [col-id='cInternalCode']","",false, this.CurrentView);
 
            DelimitationDate = RPSControlFactory.CreateRPSGridTextBox<InternalCodesDialogView>("","#24cfae1a-e59b-40dd-a18e-e283601fe720 .ag-row[role='row']@ROWINDEX [col-id='cDelimitationDate']","",false, this.CurrentView);
 
            Priority = RPSControlFactory.CreateRPSGridFormattedTextBox<InternalCodesDialogView>("","#24cfae1a-e59b-40dd-a18e-e283601fe720 .ag-row[role='row']@ROWINDEX [col-id='cPriority']","",false, this.CurrentView);
 
            ManufacturingOrderCode = RPSControlFactory.CreateRPSGridEnumComboBox<InternalCodesDialogView>("","#24cfae1a-e59b-40dd-a18e-e283601fe720 .ag-row[role='row']@ROWINDEX [col-id='cManufacturingOrderCode']","",false, this.CurrentView);
 
            ProjectCode = RPSControlFactory.CreateRPSGridEnumComboBox<InternalCodesDialogView>("","#24cfae1a-e59b-40dd-a18e-e283601fe720 .ag-row[role='row']@ROWINDEX [col-id='cProjectCode']","",false, this.CurrentView);
 
            TaskCode = RPSControlFactory.CreateRPSGridEnumComboBox<InternalCodesDialogView>("","#24cfae1a-e59b-40dd-a18e-e283601fe720 .ag-row[role='row']@ROWINDEX [col-id='cTaskCode']","",false, this.CurrentView);
 
            UI_IDArticle = RPSControlFactory.CreateRPSGridComboBox<InternalCodesDialogView>("","#24cfae1a-e59b-40dd-a18e-e283601fe720 .ag-row[role='row']@ROWINDEX [col-id='cUI_IDArticle']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<InternalCodesDialogView> InternalCode { get; set; } 
        public IRPSGridTextBox<InternalCodesDialogView> DelimitationDate { get; set; } 
        public IRPSGridTextBox<InternalCodesDialogView> Priority { get; set; } 
        public IRPSGridComboBox<InternalCodesDialogView> ManufacturingOrderCode { get; set; } 
        public IRPSGridComboBox<InternalCodesDialogView> ProjectCode { get; set; } 
        public IRPSGridComboBox<InternalCodesDialogView> TaskCode { get; set; } 
        public IRPSGridComboBox<InternalCodesDialogView> UI_IDArticle { get; set; } 
                     
    }
 
    }
  
            
    public partial class MoveTaskToResourceDialogView : View
    {
        public MoveTaskToResourceDialogView(Planification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Replan_ = RPSControlFactory.CreateRPSCheckBox<MoveTaskToResourceDialogView>("26dfcc3e-e656-40b7-bfdd-312c19e8861a","","",false, this);
 
            EntityTask = RPSControlFactory.CreateRPSTextBox<MoveTaskToResourceDialogView>("ccf81714-dc44-439e-b05f-de823768cfbf","","",false, this);
 
            EntityTaskDesc = RPSControlFactory.CreateRPSTextBox<MoveTaskToResourceDialogView>("a8276398-0bc6-4545-a47d-38ffc20652a5","","",false, this);
 
            ResCode = RPSControlFactory.CreateRPSTextBox<MoveTaskToResourceDialogView>("813e81e2-fafb-45e5-87a4-2545489c8ab2","","",false, this);
 
            ResDesc = RPSControlFactory.CreateRPSTextBox<MoveTaskToResourceDialogView>("e677d591-aa25-44f4-a6a4-c73aa28e08bd","","",false, this);
 
            Resource = RPSControlFactory.CreateRPSEnumComboBox<MoveTaskToResourceDialogView>("2804f82d-c5bf-4464-bbbd-01e4002d1fd0","","",false, this);
 

        }
        public IRPSCheckbox<MoveTaskToResourceDialogView> Replan_ { get; set; } 
        public IRPSTextBox<MoveTaskToResourceDialogView> EntityTask { get; set; } 
        public IRPSTextBox<MoveTaskToResourceDialogView> EntityTaskDesc { get; set; } 
        public IRPSTextBox<MoveTaskToResourceDialogView> ResCode { get; set; } 
        public IRPSTextBox<MoveTaskToResourceDialogView> ResDesc { get; set; } 
        public IRPSComboBox<MoveTaskToResourceDialogView> Resource { get; set; } 
        public Planification Screen { get; set; }
        public MoveTaskToResourceDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PlanningResourceDV : View
    {
        public PlanningResourceDV(Planification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Resource = RPSControlFactory.CreateRPSEnumComboBox<PlanningResourceDV>("b061b806-90e9-44ef-b9f3-f8ec0a04b1c3","","",true, this);
 
            IsDetailed = RPSControlFactory.CreateRPSCheckBox<PlanningResourceDV>("02a6666b-5f37-414f-a385-0faf03e8d4bf","","",false, this);
 
            ExecuteGetResourcePlanningPlans = RPSControlFactory.CreateRPSButton<PlanningResourceDV>( "d621aa9f-a9ee-4dcd-b14b-1dc2649750bf","","",this);
 
            CollectionInit params_GetResourcePlanningPlans = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="040d8282-28d7-4db8-a973-2c97606df79c",CSSSelectorGrid="",XPathGrid=""};
            GetResourcePlanningPlans = RPSControlFactory.RPSCreateCollectionWithGrid<GetResourcePlanningPlansCollectionEditor<PlanningResourceDV>,PlanningResourceDV>( params_GetResourcePlanningPlans,this);
 

        }
        public IRPSComboBox<PlanningResourceDV> Resource { get; set; } 
        public IRPSCheckbox<PlanningResourceDV> IsDetailed { get; set; } 
        public IRPSButton<PlanningResourceDV> ExecuteGetResourcePlanningPlans { get; set; } 
        public GetResourcePlanningPlansCollectionEditor<PlanningResourceDV> GetResourcePlanningPlans { get; set; } 
        public Planification Screen { get; set; }
        public PlanningResourceDV Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetResourcePlanningPlansCollectionEditor<PlanningResourceDV>:RPSCollectionEditor<PlanningResourceDV> where PlanningResourceDV : class, IView
    {
        public  GetResourcePlanningPlansGridView<PlanningResourceDV> GridView {get;set;}
    }
    public partial class GetResourcePlanningPlansGridView <PlanningResourceDV> :  RPSGridView<PlanningResourceDV> where PlanningResourceDV : class, IView
    {
        public GetResourcePlanningPlansGridView(PlanningResourceDV currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            StartDate = RPSControlFactory.CreateRPSGridTextBox<PlanningResourceDV>("","#040d8282-28d7-4db8-a973-2c97606df79c .ag-row[role='row']@ROWINDEX [col-id='cStartDate']","",false, this.CurrentView);
 
            FinalDate = RPSControlFactory.CreateRPSGridTextBox<PlanningResourceDV>("","#040d8282-28d7-4db8-a973-2c97606df79c .ag-row[role='row']@ROWINDEX [col-id='cFinalDate']","",false, this.CurrentView);
 
            Dedication = RPSControlFactory.CreateRPSGridFormattedTextBox<PlanningResourceDV>("","#040d8282-28d7-4db8-a973-2c97606df79c .ag-row[role='row']@ROWINDEX [col-id='cDedication']","",false, this.CurrentView);
 
            Priority = RPSControlFactory.CreateRPSGridFormattedTextBox<PlanningResourceDV>("","#040d8282-28d7-4db8-a973-2c97606df79c .ag-row[role='row']@ROWINDEX [col-id='cPriority']","",false, this.CurrentView);
 
            InternalCode = RPSControlFactory.CreateRPSGridTextBox<PlanningResourceDV>("","#040d8282-28d7-4db8-a973-2c97606df79c .ag-row[role='row']@ROWINDEX [col-id='cInternalCode']","",false, this.CurrentView);
 
            Duration = RPSControlFactory.CreateRPSGridFormattedTextBox<PlanningResourceDV>("","#040d8282-28d7-4db8-a973-2c97606df79c .ag-row[role='row']@ROWINDEX [col-id='cDuration']","",false, this.CurrentView);
 
            Date = RPSControlFactory.CreateRPSGridTextBox<PlanningResourceDV>("","#040d8282-28d7-4db8-a973-2c97606df79c .ag-row[role='row']@ROWINDEX [col-id='cDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<PlanningResourceDV> StartDate { get; set; } 
        public IRPSGridTextBox<PlanningResourceDV> FinalDate { get; set; } 
        public IRPSGridTextBox<PlanningResourceDV> Dedication { get; set; } 
        public IRPSGridTextBox<PlanningResourceDV> Priority { get; set; } 
        public IRPSGridTextBox<PlanningResourceDV> InternalCode { get; set; } 
        public IRPSGridTextBox<PlanningResourceDV> Duration { get; set; } 
        public IRPSGridTextBox<PlanningResourceDV> Date { get; set; } 
                     
    }
 
    }
  
            
    public partial class ManualResourcePlanningDV : View
    {
        public ManualResourcePlanningDV(Planification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Employee = RPSControlFactory.CreateRPSOption<ManualResourcePlanningDV>( "3ae128d6-922f-4f92-9f5a-c531b5156723","","",this);
 
            Machine = RPSControlFactory.CreateRPSOption<ManualResourcePlanningDV>( "68b4e8e7-0d59-422e-8d93-dc4223e0b059","","",this);
 
            FromDate = RPSControlFactory.CreateRPSTextBox<ManualResourcePlanningDV>("4139c4cc-f61d-4c09-98f3-a2de92f268fd","","",false, this);
 
            PlanningTime = RPSControlFactory.CreateRPSTextBox<ManualResourcePlanningDV>("da5bfea7-ebd7-4448-8119-8ff3330b5c7f","","",false, this);
 
            Tool = RPSControlFactory.CreateRPSOption<ManualResourcePlanningDV>( "a5df0319-a904-46ff-8d53-f2a6a78fc790","","",this);
 
            Qualification = RPSControlFactory.CreateRPSOption<ManualResourcePlanningDV>( "10c97c7b-b74a-415c-a554-66af5fb4b82e","","",this);
 
            MachineGroup = RPSControlFactory.CreateRPSOption<ManualResourcePlanningDV>( "bac671e2-d116-4611-8b66-ed7c6b595db2","","",this);
 
            EmployeeCb = RPSControlFactory.CreateRPSEnumComboBox<ManualResourcePlanningDV>("88ef5314-203e-488e-b0ae-6982f391bcb9","","",false, this);
 
            MachineCb = RPSControlFactory.CreateRPSEnumComboBox<ManualResourcePlanningDV>("5007ac81-5746-4005-9694-d0969166c0de","","",false, this);
 
            ToolCb = RPSControlFactory.CreateRPSEnumComboBox<ManualResourcePlanningDV>("024f5579-7c0b-4a9b-a923-b424cff1b7d2","","",false, this);
 
            QualificationCb = RPSControlFactory.CreateRPSEnumComboBox<ManualResourcePlanningDV>("a741e355-440c-4696-8fa1-227b934a0645","","",false, this);
 
            MachineGroupCb = RPSControlFactory.CreateRPSEnumComboBox<ManualResourcePlanningDV>("bec207b2-84ad-43ba-8623-f747a95b2b7e","","",false, this);
 
            Query = RPSControlFactory.CreateRPSButton<ManualResourcePlanningDV>( "f60b135b-7404-47df-9b25-c0d160a49529","","",this);
 
            ChangePlannedResourceToSelectedResource = RPSControlFactory.CreateRPSButtonToView<ManualResourcePlanningDV,ChangePlannedResourceDV>("e98a04e3-e662-4d94-96c6-bd508774fc1e","","", this,Screen.ChangePlannedResourceDV);
 
            RePlanify = RPSControlFactory.CreateRPSButton<ManualResourcePlanningDV>( "b9ecea21-ae55-4e2a-8b07-256cb8a39e0b","","",this);
 
            AddToRes = RPSControlFactory.CreateRPSButton<ManualResourcePlanningDV>( "1e2cc1b6-2b64-43af-97e9-9e9d36827b0f","","",this);
 
            DelFromRes = RPSControlFactory.CreateRPSButton<ManualResourcePlanningDV>( "a327e425-0148-4ceb-915a-8a28c2a57716","","",this);
 
            ApplyOrder = RPSControlFactory.CreateRPSButton<ManualResourcePlanningDV>( "cc656a10-9e60-480e-bd5f-0b36a31d4ce2","","",this);
 
            CollectionInit params_GetAvailableResourceManualPlanningPlans = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="643dc1db-cb75-4200-9b12-625078ee9009",CSSSelectorGrid="",XPathGrid=""};
            GetAvailableResourceManualPlanningPlans = RPSControlFactory.RPSCreateCollectionWithGrid<GetAvailableResourceManualPlanningPlansCollectionEditor<ManualResourcePlanningDV,ChangePlannedResourceDV>,ManualResourcePlanningDV,ChangePlannedResourceDV>( params_GetAvailableResourceManualPlanningPlans,this,Screen.ChangePlannedResourceDV);
 
            CollectionInit params_ResourceManualPlanningPlansDataItemCollection = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7bf2b403-4467-4741-a683-da93190b4ecb",CSSSelectorGrid="",XPathGrid=""};
            ResourceManualPlanningPlansDataItemCollection = RPSControlFactory.RPSCreateCollectionWithGrid<ResourceManualPlanningPlansDataItemCollectionCollectionEditor<ManualResourcePlanningDV,ChangePlannedResourceDV>,ManualResourcePlanningDV,ChangePlannedResourceDV>( params_ResourceManualPlanningPlansDataItemCollection,this,Screen.ChangePlannedResourceDV);
 

        }
        public IRPSOption<ManualResourcePlanningDV> Employee { get; set; } 
        public IRPSOption<ManualResourcePlanningDV> Machine { get; set; } 
        public IRPSTextBox<ManualResourcePlanningDV> FromDate { get; set; } 
        public IRPSTextBox<ManualResourcePlanningDV> PlanningTime { get; set; } 
        public IRPSOption<ManualResourcePlanningDV> Tool { get; set; } 
        public IRPSOption<ManualResourcePlanningDV> Qualification { get; set; } 
        public IRPSOption<ManualResourcePlanningDV> MachineGroup { get; set; } 
        public IRPSComboBox<ManualResourcePlanningDV> EmployeeCb { get; set; } 
        public IRPSComboBox<ManualResourcePlanningDV> MachineCb { get; set; } 
        public IRPSComboBox<ManualResourcePlanningDV> ToolCb { get; set; } 
        public IRPSComboBox<ManualResourcePlanningDV> QualificationCb { get; set; } 
        public IRPSComboBox<ManualResourcePlanningDV> MachineGroupCb { get; set; } 
        public IRPSButton<ManualResourcePlanningDV> Query { get; set; } 
        public IRPSButton<ManualResourcePlanningDV,ChangePlannedResourceDV> ChangePlannedResourceToSelectedResource { get; set; } 
        public IRPSButton<ManualResourcePlanningDV> RePlanify { get; set; } 
        public IRPSButton<ManualResourcePlanningDV> AddToRes { get; set; } 
        public IRPSButton<ManualResourcePlanningDV> DelFromRes { get; set; } 
        public IRPSButton<ManualResourcePlanningDV> ApplyOrder { get; set; } 
        public GetAvailableResourceManualPlanningPlansCollectionEditor<ManualResourcePlanningDV,ChangePlannedResourceDV> GetAvailableResourceManualPlanningPlans { get; set; } 
        public ResourceManualPlanningPlansDataItemCollectionCollectionEditor<ManualResourcePlanningDV,ChangePlannedResourceDV> ResourceManualPlanningPlansDataItemCollection { get; set; } 
        public Planification Screen { get; set; }
        public ManualResourcePlanningDV Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetAvailableResourceManualPlanningPlansCollectionEditor<ManualResourcePlanningDV,ChangePlannedResourceDV>:RPSCollectionEditor<ManualResourcePlanningDV,ChangePlannedResourceDV> where ManualResourcePlanningDV : class, IView where ChangePlannedResourceDV : class, IView
    {
        public  GetAvailableResourceManualPlanningPlansGridView<ManualResourcePlanningDV,ChangePlannedResourceDV> GridView {get;set;}
    }
    public partial class GetAvailableResourceManualPlanningPlansGridView <ManualResourcePlanningDV,ChangePlannedResourceDV> :  RPSGridView<ManualResourcePlanningDV,ChangePlannedResourceDV> where ManualResourcePlanningDV : class, IView where ChangePlannedResourceDV : class, IView
    {
        public GetAvailableResourceManualPlanningPlansGridView(ManualResourcePlanningDV currentView,ChangePlannedResourceDV newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            EntityType = RPSControlFactory.CreateRPSGridTextBox<ManualResourcePlanningDV>("","#643dc1db-cb75-4200-9b12-625078ee9009 .ag-row[role='row']@ROWINDEX [col-id='cEntityType']","",false, this.CurrentView);
 
            DeliveryDate = RPSControlFactory.CreateRPSGridTextBox<ManualResourcePlanningDV>("","#643dc1db-cb75-4200-9b12-625078ee9009 .ag-row[role='row']@ROWINDEX [col-id='cDeliveryDate']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<ManualResourcePlanningDV>("","#643dc1db-cb75-4200-9b12-625078ee9009 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            Duration = RPSControlFactory.CreateRPSGridFormattedTextBox<ManualResourcePlanningDV>("","#643dc1db-cb75-4200-9b12-625078ee9009 .ag-row[role='row']@ROWINDEX [col-id='cDuration']","",false, this.CurrentView);
 
            Priority = RPSControlFactory.CreateRPSGridFormattedTextBox<ManualResourcePlanningDV>("","#643dc1db-cb75-4200-9b12-625078ee9009 .ag-row[role='row']@ROWINDEX [col-id='cPriority']","",false, this.CurrentView);
 
            InternalCode = RPSControlFactory.CreateRPSGridTextBox<ManualResourcePlanningDV>("","#643dc1db-cb75-4200-9b12-625078ee9009 .ag-row[role='row']@ROWINDEX [col-id='cInternalCode']","",false, this.CurrentView);
 
            Qualification = RPSControlFactory.CreateRPSGridTextBox<ManualResourcePlanningDV>("","#643dc1db-cb75-4200-9b12-625078ee9009 .ag-row[role='row']@ROWINDEX [col-id='cQualification']","",false, this.CurrentView);
 
            Situation = RPSControlFactory.CreateRPSGridTextBox<ManualResourcePlanningDV>("","#643dc1db-cb75-4200-9b12-625078ee9009 .ag-row[role='row']@ROWINDEX [col-id='cSituation']","",false, this.CurrentView);
 
            LowestPredecessorStartDate = RPSControlFactory.CreateRPSGridTextBox<ManualResourcePlanningDV>("","#643dc1db-cb75-4200-9b12-625078ee9009 .ag-row[role='row']@ROWINDEX [col-id='cLowestPredecessorStartDate']","",false, this.CurrentView);
 
            HighestPredecessorEndDate = RPSControlFactory.CreateRPSGridTextBox<ManualResourcePlanningDV>("","#643dc1db-cb75-4200-9b12-625078ee9009 .ag-row[role='row']@ROWINDEX [col-id='cHighestPredecessorEndDate']","",false, this.CurrentView);
 
            TaskOptimizationFeature = RPSControlFactory.CreateRPSGridTextBox<ManualResourcePlanningDV>("","#643dc1db-cb75-4200-9b12-625078ee9009 .ag-row[role='row']@ROWINDEX [col-id='cTaskOptimizationFeature']","",false, this.CurrentView);
 
            GroupingNumber = RPSControlFactory.CreateRPSGridTextBox<ManualResourcePlanningDV>("","#643dc1db-cb75-4200-9b12-625078ee9009 .ag-row[role='row']@ROWINDEX [col-id='cGroupingNumber']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ManualResourcePlanningDV> EntityType { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningDV> DeliveryDate { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningDV> Quantity { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningDV> Duration { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningDV> Priority { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningDV> InternalCode { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningDV> Qualification { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningDV> Situation { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningDV> LowestPredecessorStartDate { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningDV> HighestPredecessorEndDate { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningDV> TaskOptimizationFeature { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningDV> GroupingNumber { get; set; } 
                     
    }
 
        public partial class ResourceManualPlanningPlansDataItemCollectionCollectionEditor<ManualResourcePlanningDV,ChangePlannedResourceDV>:RPSCollectionEditor<ManualResourcePlanningDV,ChangePlannedResourceDV> where ManualResourcePlanningDV : class, IView where ChangePlannedResourceDV : class, IView
    {
        public  ResourceManualPlanningPlansDataItemCollectionGridView<ManualResourcePlanningDV,ChangePlannedResourceDV> GridView {get;set;}
    }
    public partial class ResourceManualPlanningPlansDataItemCollectionGridView <ManualResourcePlanningDV,ChangePlannedResourceDV> :  RPSGridView<ManualResourcePlanningDV,ChangePlannedResourceDV> where ManualResourcePlanningDV : class, IView where ChangePlannedResourceDV : class, IView
    {
        public ResourceManualPlanningPlansDataItemCollectionGridView(ManualResourcePlanningDV currentView,ChangePlannedResourceDV newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NextOrder = RPSControlFactory.CreateRPSGridFormattedTextBox<ManualResourcePlanningDV>("","#7bf2b403-4467-4741-a683-da93190b4ecb .ag-row[role='row']@ROWINDEX [col-id='cNextOrder']","",false, this.CurrentView);
 
            IsFixed = RPSControlFactory.CreateRPSGridCheckBox<ManualResourcePlanningDV>("","#7bf2b403-4467-4741-a683-da93190b4ecb .ag-row[role='row']@ROWINDEX [col-id='cIsFixed']","",false, this.CurrentView);
 
            StartDate = RPSControlFactory.CreateRPSGridTextBox<ManualResourcePlanningDV>("","#7bf2b403-4467-4741-a683-da93190b4ecb .ag-row[role='row']@ROWINDEX [col-id='cStartDate']","",false, this.CurrentView);
 
            FinalDate = RPSControlFactory.CreateRPSGridTextBox<ManualResourcePlanningDV>("","#7bf2b403-4467-4741-a683-da93190b4ecb .ag-row[role='row']@ROWINDEX [col-id='cFinalDate']","",false, this.CurrentView);
 
            Dedication = RPSControlFactory.CreateRPSGridFormattedTextBox<ManualResourcePlanningDV>("","#7bf2b403-4467-4741-a683-da93190b4ecb .ag-row[role='row']@ROWINDEX [col-id='cDedication']","",false, this.CurrentView);
 
            Priority = RPSControlFactory.CreateRPSGridFormattedTextBox<ManualResourcePlanningDV>("","#7bf2b403-4467-4741-a683-da93190b4ecb .ag-row[role='row']@ROWINDEX [col-id='cPriority']","",false, this.CurrentView);
 
            InternalCode = RPSControlFactory.CreateRPSGridTextBox<ManualResourcePlanningDV>("","#7bf2b403-4467-4741-a683-da93190b4ecb .ag-row[role='row']@ROWINDEX [col-id='cInternalCode']","",false, this.CurrentView);
 
            Duration = RPSControlFactory.CreateRPSGridFormattedTextBox<ManualResourcePlanningDV>("","#7bf2b403-4467-4741-a683-da93190b4ecb .ag-row[role='row']@ROWINDEX [col-id='cDuration']","",false, this.CurrentView);
 
            Date = RPSControlFactory.CreateRPSGridTextBox<ManualResourcePlanningDV>("","#7bf2b403-4467-4741-a683-da93190b4ecb .ag-row[role='row']@ROWINDEX [col-id='cDate']","",false, this.CurrentView);
 
            Qualify = RPSControlFactory.CreateRPSGridTextBox<ManualResourcePlanningDV>("","#7bf2b403-4467-4741-a683-da93190b4ecb .ag-row[role='row']@ROWINDEX [col-id='cQualify']","",false, this.CurrentView);
 
            Situation = RPSControlFactory.CreateRPSGridTextBox<ManualResourcePlanningDV>("","#7bf2b403-4467-4741-a683-da93190b4ecb .ag-row[role='row']@ROWINDEX [col-id='cSituation']","",false, this.CurrentView);
 
            LowestPredecessorStartDate = RPSControlFactory.CreateRPSGridTextBox<ManualResourcePlanningDV>("","#7bf2b403-4467-4741-a683-da93190b4ecb .ag-row[role='row']@ROWINDEX [col-id='cLowestPredecessorStartDate']","",false, this.CurrentView);
 
            HighestPredecessorEndDate = RPSControlFactory.CreateRPSGridTextBox<ManualResourcePlanningDV>("","#7bf2b403-4467-4741-a683-da93190b4ecb .ag-row[role='row']@ROWINDEX [col-id='cHighestPredecessorEndDate']","",false, this.CurrentView);
 
            TaskOptimizationFeature = RPSControlFactory.CreateRPSGridTextBox<ManualResourcePlanningDV>("","#7bf2b403-4467-4741-a683-da93190b4ecb .ag-row[role='row']@ROWINDEX [col-id='cTaskOptimizationFeature']","",false, this.CurrentView);
 
            GroupingNumber = RPSControlFactory.CreateRPSGridTextBox<ManualResourcePlanningDV>("","#7bf2b403-4467-4741-a683-da93190b4ecb .ag-row[role='row']@ROWINDEX [col-id='cGroupingNumber']","",false, this.CurrentView);
 
            EntityQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<ManualResourcePlanningDV>("","#7bf2b403-4467-4741-a683-da93190b4ecb .ag-row[role='row']@ROWINDEX [col-id='cEntityQuantity']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ManualResourcePlanningDV> NextOrder { get; set; } 
        public IRPSGridCheckbox<ManualResourcePlanningDV> IsFixed { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningDV> StartDate { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningDV> FinalDate { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningDV> Dedication { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningDV> Priority { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningDV> InternalCode { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningDV> Duration { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningDV> Date { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningDV> Qualify { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningDV> Situation { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningDV> LowestPredecessorStartDate { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningDV> HighestPredecessorEndDate { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningDV> TaskOptimizationFeature { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningDV> GroupingNumber { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningDV> EntityQuantity { get; set; } 
                     
    }
 
    }
  
            
    public partial class NewPlanningTaskPredecessorDV : View
    {
        public NewPlanningTaskPredecessorDV(Planification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Entity = RPSControlFactory.CreateRPSEnumComboBox<NewPlanningTaskPredecessorDV>("dd338944-cb77-4708-9d7b-2e43a42d53b8","","",false, this);
 
            EntityTask = RPSControlFactory.CreateRPSEnumComboBox<NewPlanningTaskPredecessorDV>("22ab12e7-733a-4539-a183-72edb00fa912","","",false, this);
 
            eRelationType = RPSControlFactory.CreateRPSEnumComboBox<NewPlanningTaskPredecessorDV>("684635fb-c90e-4ac6-9950-ec92a2e8df7b","","",false, this);
 
            Decalaje = RPSControlFactory.CreateRPSFormattedTextBox<NewPlanningTaskPredecessorDV>("dfc6c7f5-8246-472e-bf59-8a8c6cc8c600","","",false, this);
 
            eTimeUnit = RPSControlFactory.CreateRPSEnumComboBox<NewPlanningTaskPredecessorDV>("2a0f7fd1-5268-4db0-a068-90686c7cae12","","",false, this);
 
            Linked = RPSControlFactory.CreateRPSCheckBox<NewPlanningTaskPredecessorDV>("d4fb80d3-50d5-4d44-a585-3117f476ef1d","","",false, this);
 
            eCalendarType = RPSControlFactory.CreateRPSEnumComboBox<NewPlanningTaskPredecessorDV>("7da72964-1758-4f88-9ec2-1df8d727b5c4","","",false, this);
 
            ExecuteAddPlanningPredecessorTaskDataButton = RPSControlFactory.CreateRPSButton<NewPlanningTaskPredecessorDV>( "0d97e1fa-be23-428d-9027-f444b558c877","","",this);
 

        }
        public IRPSComboBox<NewPlanningTaskPredecessorDV> Entity { get; set; } 
        public IRPSComboBox<NewPlanningTaskPredecessorDV> EntityTask { get; set; } 
        public IRPSComboBox<NewPlanningTaskPredecessorDV> eRelationType { get; set; } 
        public IRPSTextBox<NewPlanningTaskPredecessorDV> Decalaje { get; set; } 
        public IRPSComboBox<NewPlanningTaskPredecessorDV> eTimeUnit { get; set; } 
        public IRPSCheckbox<NewPlanningTaskPredecessorDV> Linked { get; set; } 
        public IRPSComboBox<NewPlanningTaskPredecessorDV> eCalendarType { get; set; } 
        public IRPSButton<NewPlanningTaskPredecessorDV> ExecuteAddPlanningPredecessorTaskDataButton { get; set; } 
        public Planification Screen { get; set; }
        public NewPlanningTaskPredecessorDV Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SelectionDeselectionDV : View
    {
        public SelectionDeselectionDV(Planification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SelDesAll = RPSControlFactory.CreateRPSCheckBox<SelectionDeselectionDV>("6da755ba-1713-426d-ae62-8cfbc8a6d622","","",false, this);
 
            KeepPreviousSelection = RPSControlFactory.CreateRPSCheckBox<SelectionDeselectionDV>("257b8f6a-e298-401c-9828-ae69fc62b2fa","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<SelectionDeselectionDV>("d01e32de-1875-4fdb-917e-ba0b473905d7","","",false, this);
 
            TimeFrom = RPSControlFactory.CreateRPSTextBox<SelectionDeselectionDV>("58202d41-22b9-4c0b-8f17-2a582951ab27","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<SelectionDeselectionDV>("b2597372-663f-4fe6-abc9-f25acc6ccb4f","","",false, this);
 
            TimeTo = RPSControlFactory.CreateRPSTextBox<SelectionDeselectionDV>("644f0dc6-ec73-4862-a13e-3a2f43fe4765","","",false, this);
 
            ManufacturingOrder = RPSControlFactory.CreateRPSCollectionComboBox<SelectionDeselectionDV>("8f7e1d94-e4e8-4abc-a525-a14975b7ff0a","","",false, this);
 
            PlannableMOTask = RPSControlFactory.CreateRPSCollectionComboBox<SelectionDeselectionDV>("4e6505f4-4a2e-4c01-9d53-1342ed99b923","","",false, this);
 
            Project = RPSControlFactory.CreateRPSCollectionComboBox<SelectionDeselectionDV>("0b2c9fcc-4961-46c0-a61a-91bb53fbc3c9","","",false, this);
 
            PlannableProjectTask = RPSControlFactory.CreateRPSCollectionComboBox<SelectionDeselectionDV>("9215e974-67ca-46bb-ba27-d633707202b4","","",false, this);
 
            MaintenanceOrder = RPSControlFactory.CreateRPSCollectionComboBox<SelectionDeselectionDV>("069c0ade-c849-4454-9b3e-061661407526","","",false, this);
 
            ResourceEmployee = RPSControlFactory.CreateRPSCollectionComboBox<SelectionDeselectionDV>("54614bcc-aab8-4a6e-8d86-a4db0623dcb1","","",false, this);
 
            ResourceMachine = RPSControlFactory.CreateRPSCollectionComboBox<SelectionDeselectionDV>("f29f2d78-cd27-4c5e-9bbb-75e6606270a5","","",false, this);
 
            ResourceTool = RPSControlFactory.CreateRPSCollectionComboBox<SelectionDeselectionDV>("6a671e50-9e04-470c-9b7c-2df3bc0a208f","","",false, this);
 
            TaskPriority = RPSControlFactory.CreateRPSFormattedTextBox<SelectionDeselectionDV>("bac721f7-a0ed-419f-bc11-70bdf7f3cd96","","",false, this);
 
            OptimizationFeature = RPSControlFactory.CreateRPSTextBox<SelectionDeselectionDV>("832221cb-5393-421e-9458-5bb675495c0b","","",false, this);
 
            InternalCode = RPSControlFactory.CreateRPSTextBox<SelectionDeselectionDV>("ad9e0707-561c-4a38-a70e-bb43fe2aa5ac","","",false, this);
 
            SelectComm = RPSControlFactory.CreateRPSButton<SelectionDeselectionDV>( "af6c3554-4191-4a16-97d1-acfa28422cc9","","",this);
 
            DeselectComm = RPSControlFactory.CreateRPSButton<SelectionDeselectionDV>( "a668e45b-b6c4-4b9c-8ef7-08d2644b1409","","",this);
 

        }
        public IRPSCheckbox<SelectionDeselectionDV> SelDesAll { get; set; } 
        public IRPSCheckbox<SelectionDeselectionDV> KeepPreviousSelection { get; set; } 
        public IRPSTextBox<SelectionDeselectionDV> DateFrom { get; set; } 
        public IRPSTextBox<SelectionDeselectionDV> TimeFrom { get; set; } 
        public IRPSTextBox<SelectionDeselectionDV> DateTo { get; set; } 
        public IRPSTextBox<SelectionDeselectionDV> TimeTo { get; set; } 
        public IRPSCollectionComboBox<SelectionDeselectionDV> ManufacturingOrder { get; set; } 
        public IRPSCollectionComboBox<SelectionDeselectionDV> PlannableMOTask { get; set; } 
        public IRPSCollectionComboBox<SelectionDeselectionDV> Project { get; set; } 
        public IRPSCollectionComboBox<SelectionDeselectionDV> PlannableProjectTask { get; set; } 
        public IRPSCollectionComboBox<SelectionDeselectionDV> MaintenanceOrder { get; set; } 
        public IRPSCollectionComboBox<SelectionDeselectionDV> ResourceEmployee { get; set; } 
        public IRPSCollectionComboBox<SelectionDeselectionDV> ResourceMachine { get; set; } 
        public IRPSCollectionComboBox<SelectionDeselectionDV> ResourceTool { get; set; } 
        public IRPSTextBox<SelectionDeselectionDV> TaskPriority { get; set; } 
        public IRPSTextBox<SelectionDeselectionDV> OptimizationFeature { get; set; } 
        public IRPSTextBox<SelectionDeselectionDV> InternalCode { get; set; } 
        public IRPSButton<SelectionDeselectionDV> SelectComm { get; set; } 
        public IRPSButton<SelectionDeselectionDV> DeselectComm { get; set; } 
        public Planification Screen { get; set; }
        public SelectionDeselectionDV Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ChangePlannedResourceDV : View
    {
        public ChangePlannedResourceDV(Planification screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            FromResource = RPSControlFactory.CreateRPSTextBox<ChangePlannedResourceDV>("1d362315-5ec9-48c5-b840-30c05ce6748f","","",false, this);
 
            ToResource = RPSControlFactory.CreateRPSEnumComboBox<ChangePlannedResourceDV>("27449e2f-2496-4719-acab-9c31b61d6fe4","","",false, this);
 

        }
        public IRPSTextBox<ChangePlannedResourceDV> FromResource { get; set; } 
        public IRPSComboBox<ChangePlannedResourceDV> ToResource { get; set; } 
        public Planification Screen { get; set; }
        public ChangePlannedResourceDV Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}