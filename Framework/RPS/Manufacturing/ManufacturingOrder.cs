    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.ManufacturingOrder
{
    //RPS VERSION 1.0.0.0
    public partial class ManufacturingOrder:Screen
    {
        public ManufacturingOrder():base()
        {
            this.URL = "manufacturing.manufacturingorder";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ManufacturingOrderCollectionView  = new ManufacturingOrderCollectionView(this); 
            ManufacturingOrderEntityView  = new ManufacturingOrderEntityView(this); 
            MOFeatureView  = new MOFeatureView(this); 
            NewFromSalesDialogView  = new NewFromSalesDialogView(this); 
            MODimensionView  = new MODimensionView(this); 
            MOSeriesReserveView  = new MOSeriesReserveView(this); 
            MOTaskView  = new MOTaskView(this); 
            MOTaskRelationView  = new MOTaskRelationView(this); 
            MOTaskDimensionView  = new MOTaskDimensionView(this); 
            MOResourceEmployeeView  = new MOResourceEmployeeView(this); 
            MOResourceMachineView  = new MOResourceMachineView(this); 
            MOResourceToolView  = new MOResourceToolView(this); 
            MOTaskCostComponentView  = new MOTaskCostComponentView(this); 
            MOMaterialView  = new MOMaterialView(this); 
            AddUsualTaskDialogView  = new AddUsualTaskDialogView(this); 
            NewMODialogView  = new NewMODialogView(this); 
            ChangeSiteDialogView  = new ChangeSiteDialogView(this); 
            ChangeRouteDialogView  = new ChangeRouteDialogView(this); 
            MainManufacturingOrderDialogView  = new MainManufacturingOrderDialogView(this); 
            SecondaryManufacturingOrderDialogView  = new SecondaryManufacturingOrderDialogView(this); 
            EndProductInputDialogView  = new EndProductInputDialogView(this); 
            MOMaterialChangeStatusDialogView  = new MOMaterialChangeStatusDialogView(this); 
            MOPlanningDateDialogView  = new MOPlanningDateDialogView(this); 
            ChangeSituationMODV  = new ChangeSituationMODV(this); 
            PrintDocumentationDV  = new PrintDocumentationDV(this); 
            ManufacturingOrderCollectionView.InitializeControls(); 
            ManufacturingOrderEntityView.InitializeControls(); 
            MOFeatureView.InitializeControls(); 
            NewFromSalesDialogView.InitializeControls(); 
            MODimensionView.InitializeControls(); 
            MOSeriesReserveView.InitializeControls(); 
            MOTaskView.InitializeControls(); 
            MOTaskRelationView.InitializeControls(); 
            MOTaskDimensionView.InitializeControls(); 
            MOResourceEmployeeView.InitializeControls(); 
            MOResourceMachineView.InitializeControls(); 
            MOResourceToolView.InitializeControls(); 
            MOTaskCostComponentView.InitializeControls(); 
            MOMaterialView.InitializeControls(); 
            AddUsualTaskDialogView.InitializeControls(); 
            NewMODialogView.InitializeControls(); 
            ChangeSiteDialogView.InitializeControls(); 
            ChangeRouteDialogView.InitializeControls(); 
            MainManufacturingOrderDialogView.InitializeControls(); 
            SecondaryManufacturingOrderDialogView.InitializeControls(); 
            EndProductInputDialogView.InitializeControls(); 
            MOMaterialChangeStatusDialogView.InitializeControls(); 
            MOPlanningDateDialogView.InitializeControls(); 
            ChangeSituationMODV.InitializeControls(); 
            PrintDocumentationDV.InitializeControls(); 
           
        }
      
            public ManufacturingOrderCollectionView ManufacturingOrderCollectionView {get; set; } 
            public ManufacturingOrderEntityView ManufacturingOrderEntityView {get; set; } 
            public MOFeatureView MOFeatureView {get; set; } 
            public NewFromSalesDialogView NewFromSalesDialogView {get; set; } 
            public MODimensionView MODimensionView {get; set; } 
            public MOSeriesReserveView MOSeriesReserveView {get; set; } 
            public MOTaskView MOTaskView {get; set; } 
            public MOTaskRelationView MOTaskRelationView {get; set; } 
            public MOTaskDimensionView MOTaskDimensionView {get; set; } 
            public MOResourceEmployeeView MOResourceEmployeeView {get; set; } 
            public MOResourceMachineView MOResourceMachineView {get; set; } 
            public MOResourceToolView MOResourceToolView {get; set; } 
            public MOTaskCostComponentView MOTaskCostComponentView {get; set; } 
            public MOMaterialView MOMaterialView {get; set; } 
            public AddUsualTaskDialogView AddUsualTaskDialogView {get; set; } 
            public NewMODialogView NewMODialogView {get; set; } 
            public ChangeSiteDialogView ChangeSiteDialogView {get; set; } 
            public ChangeRouteDialogView ChangeRouteDialogView {get; set; } 
            public MainManufacturingOrderDialogView MainManufacturingOrderDialogView {get; set; } 
            public SecondaryManufacturingOrderDialogView SecondaryManufacturingOrderDialogView {get; set; } 
            public EndProductInputDialogView EndProductInputDialogView {get; set; } 
            public MOMaterialChangeStatusDialogView MOMaterialChangeStatusDialogView {get; set; } 
            public MOPlanningDateDialogView MOPlanningDateDialogView {get; set; } 
            public ChangeSituationMODV ChangeSituationMODV {get; set; } 
            public PrintDocumentationDV PrintDocumentationDV {get; set; } 
    }
            
    public partial class ManufacturingOrderCollectionView : View
    {
        public ManufacturingOrderCollectionView(ManufacturingOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ManufacturingOrderCollectionView,ManufacturingOrderEntityView>( this,Screen.ManufacturingOrderEntityView);
 
            NewMONavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ManufacturingOrderCollectionView,NewMODialogView>("1ab49e21-3b5f-4747-bef6-b0a1da76b965","","", this,Screen.NewMODialogView);
 
            NewFromSalesNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ManufacturingOrderCollectionView,NewFromSalesDialogView>("57f8a1d3-f79b-4425-b168-a3718870b6f0","","", this,Screen.NewFromSalesDialogView);
 
            MOLaunchCommButton = RPSControlFactory.CreateRPSButton<ManufacturingOrderCollectionView>( "596bce09-d277-419a-8ace-70e5e2a6dd12","","",this);
 
            ChangeSituationMONavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ManufacturingOrderCollectionView,ChangeSituationMODV>("d98ce03e-01ae-46f2-a216-22532d8eb619","","", this,Screen.ChangeSituationMODV);
 
            PrintDocumentationCommButton = RPSControlFactory.CreateRPSButtonToView<ManufacturingOrderCollectionView,PrintDocumentationDV>("ee02e2f4-3758-4a11-8b06-152cdd0cc4fe","","", this,Screen.PrintDocumentationDV);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "32b90571-f1b9-4bbd-bed2-89327a05c796",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ManufacturingOrderCollectionView,ManufacturingOrderEntityView>( params_MainConsult,this,Screen.ManufacturingOrderEntityView);
 

        }
        public IRPSButton<ManufacturingOrderCollectionView,ManufacturingOrderEntityView> NewButton { get; set; } 
        public IRPSButton<ManufacturingOrderCollectionView,NewMODialogView> NewMONavigationCommandButton { get; set; } 
        public IRPSButton<ManufacturingOrderCollectionView,NewFromSalesDialogView> NewFromSalesNavigationCommandButton { get; set; } 
        public IRPSButton<ManufacturingOrderCollectionView> MOLaunchCommButton { get; set; } 
        public IRPSButton<ManufacturingOrderCollectionView,ChangeSituationMODV> ChangeSituationMONavigationCommandButton { get; set; } 
        public IRPSButton<ManufacturingOrderCollectionView,PrintDocumentationDV> PrintDocumentationCommButton { get; set; } 
        public IRPSCollectionEditor<ManufacturingOrderCollectionView,ManufacturingOrderEntityView> MainConsult { get; set; } 
        public ManufacturingOrder Screen { get; set; }
        public ManufacturingOrderCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ManufacturingOrderEntityView : View
    {
        public ManufacturingOrderEntityView(ManufacturingOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ManufacturingOrderEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ManufacturingOrderEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ManufacturingOrderEntityView,ManufacturingOrderCollectionView>( this,Screen.ManufacturingOrderCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ManufacturingOrderEntityView,ManufacturingOrderCollectionView>( this,Screen.ManufacturingOrderCollectionView);
 
            CodManufacturingOrder = RPSControlFactory.CreateRPSTextBox<ManufacturingOrderEntityView>("2daf8a92-61a0-4da2-9903-b6b12245abeb","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ManufacturingOrderEntityView>("9077085a-5790-4fe6-9559-a2f0044803c2","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<ManufacturingOrderEntityView>("9427e1f0-32d0-450d-8b87-8aead186c50f","","",true, this);
 
            UISite = RPSControlFactory.CreateRPSComboBox<ManufacturingOrderEntityView>("cc01cd8e-42b3-4866-b90b-48907035c923","","",false, this);
 
            IDMOSituation = RPSControlFactory.CreateRPSComboBox<ManufacturingOrderEntityView>("748daa86-5499-42f5-b329-5515b272910b","","",true, this);
 
            Color = RPSControlFactory.CreateRPSColorEditor<ManufacturingOrderEntityView>( "b0c0d451-ef0c-49d2-a59e-89221826c406","","",this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<ManufacturingOrderEntityView>("7142d4c2-e760-404d-8ce1-79822d86dff1","","",true, this);
 
            CalcManufacturedQuantity = RPSControlFactory.CreateRPSFormattedTextBox<ManufacturingOrderEntityView>("91f87a8f-e4db-4008-87cb-1bd40955042b","","",false, this);
 
            PlannedStartDate = RPSControlFactory.CreateRPSTextBox<ManufacturingOrderEntityView>("07f8795e-99d2-423a-8c4d-489f2fe70249","","",true, this);
 
            PlannedStartTime = RPSControlFactory.CreateRPSTextBox<ManufacturingOrderEntityView>("19403aeb-fe3a-4e9b-a7b1-b2ed941b8b72","","",false, this);
 
            PlannedEndDate = RPSControlFactory.CreateRPSTextBox<ManufacturingOrderEntityView>("982adcda-ac22-4780-b5b3-289595bdd2e0","","",true, this);
 
            PlannedEndTime = RPSControlFactory.CreateRPSTextBox<ManufacturingOrderEntityView>("8c5c00b3-1fc7-4c02-8967-e99acb6277f9","","",false, this);
 
            PlannedEndMRPDate = RPSControlFactory.CreateRPSTextBox<ManufacturingOrderEntityView>("031be2a8-cb6b-4e20-b6e1-4330a19391af","","",false, this);
 
            ManualPStartDate = RPSControlFactory.CreateRPSTextBox<ManufacturingOrderEntityView>("4319882d-29d6-4918-9235-344bad1abf13","","",false, this);
 
            ManualPEndDate = RPSControlFactory.CreateRPSTextBox<ManufacturingOrderEntityView>("dbe3c631-1fd7-4349-888f-3f818497c3b4","","",false, this);
 
            ManualEndDate = RPSControlFactory.CreateRPSTextBox<ManufacturingOrderEntityView>("af8b129b-3876-4388-93da-7fee14b83237","","",true, this);
 
            RealEndDate = RPSControlFactory.CreateRPSTextBox<ManufacturingOrderEntityView>("d9deeb34-11e5-478e-89a8-b57a81d1013d","","",false, this);
 
            AcceptedDate = RPSControlFactory.CreateRPSTextBox<ManufacturingOrderEntityView>("5d28572c-7cb4-4f87-b334-a5acd1ff3dc6","","",false, this);
 
            IDStructureType = RPSControlFactory.CreateRPSComboBox<ManufacturingOrderEntityView>("9afafbec-06ed-4652-911b-9f81afe77bc0","","",true, this);
 
            UIStructure = RPSControlFactory.CreateRPSComboBox<ManufacturingOrderEntityView>("a4cec516-1971-4323-98f7-bf6786f8e29b","","",false, this);
 
            IDArticleVersion = RPSControlFactory.CreateRPSComboBox<ManufacturingOrderEntityView>("3f7aa3e9-8a99-42ac-ad76-fcc4d3240df6","","",false, this);
 
            TimeUnitDefault = RPSControlFactory.CreateRPSEnumComboBox<ManufacturingOrderEntityView>("35cf8a57-bf17-4097-a7c4-3a8176360426","","",true, this);
 
            IDWareHouse = RPSControlFactory.CreateRPSComboBox<ManufacturingOrderEntityView>("24d78b5c-beef-46d7-8e47-93874af5af4e","","",false, this);
 
            InternalCode = RPSControlFactory.CreateRPSTextBox<ManufacturingOrderEntityView>("6ca414ee-2bef-4e20-8633-c976ac186a4a","","",false, this);
 
            IDRoute = RPSControlFactory.CreateRPSComboBox<ManufacturingOrderEntityView>("9e4a3137-2970-4e2d-8cfa-2e3f70926db3","","",false, this);
 
            PlanningDirection = RPSControlFactory.CreateRPSEnumComboBox<ManufacturingOrderEntityView>("224a2211-1c84-4c12-8cac-55f15586d0ac","","",true, this);
 
            Priority = RPSControlFactory.CreateRPSFormattedTextBox<ManufacturingOrderEntityView>("3821a572-309c-45be-a296-544079daa5de","","",true, this);
 
            Group = RPSControlFactory.CreateRPSTextBox<ManufacturingOrderEntityView>("68ea0b38-a33b-435b-9657-75afdf153023","","",false, this);
 
            AutomaticCodification = RPSControlFactory.CreateRPSCheckBox<ManufacturingOrderEntityView>("834a40e1-b7b3-4019-9788-b018d51852b8","","",true, this);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<ManufacturingOrderEntityView>("27e9fb56-7736-41af-bf51-c28e8654cedf","","",false, this);
 
            IDProTask = RPSControlFactory.CreateRPSComboBox<ManufacturingOrderEntityView>("e2c81329-10d5-4d0e-8a7c-7c575cdcbe6a","","",false, this);
 
            IDProMaterial = RPSControlFactory.CreateRPSComboBox<ManufacturingOrderEntityView>("b41da9b3-f9ae-4eeb-8709-23f5ba1da286","","",false, this);
 
            IDMaintenanceOrder = RPSControlFactory.CreateRPSComboBox<ManufacturingOrderEntityView>("749b3dbc-8737-4f9d-94f6-a7111bec2e52","","",false, this);
 
            IDOrderMaterialPrevision = RPSControlFactory.CreateRPSComboBox<ManufacturingOrderEntityView>("41c7d63e-13a0-4b76-92a1-3a9902b838e5","","",false, this);
 
            UIOrderSL = RPSControlFactory.CreateRPSComboBox<ManufacturingOrderEntityView>("0cb366f5-01eb-49b4-a1b4-dab875411fc7","","",false, this);
 
            UIOrderLineSL = RPSControlFactory.CreateRPSComboBox<ManufacturingOrderEntityView>("ac438e21-14d5-493e-82a1-ec4c9b722db8","","",false, this);
 
            Notes = RPSControlFactory.CreateRPSTextBox<ManufacturingOrderEntityView>("e4f199f7-a924-4e4d-8767-b395af8fd112","","",false, this);
 
            CalcInventoryCost = RPSControlFactory.CreateRPSFormattedTextBox<ManufacturingOrderEntityView>("f73fcd17-b97d-4b2a-b7ce-c93c79d4754d","","",false, this);
 
            CalcManufacturedQuantity1 = RPSControlFactory.CreateRPSFormattedTextBox<ManufacturingOrderEntityView>("270787b1-34d4-4cf2-9127-102751682b04","","",false, this);
 
            CalcManufacturedQuantityCost = RPSControlFactory.CreateRPSFormattedTextBox<ManufacturingOrderEntityView>("6268656b-00a7-45d6-9aef-6d972c406b09","","",false, this);
 
            CalcRejectedQuantity = RPSControlFactory.CreateRPSFormattedTextBox<ManufacturingOrderEntityView>("bf7a9c0c-aed8-43aa-b53b-e5d09212adaf","","",false, this);
 
            CalcMaterialCostTheoric = RPSControlFactory.CreateRPSFormattedTextBox<ManufacturingOrderEntityView>("7e723932-c742-46a8-b11a-59334951fcda","","",false, this);
 
            CalcLaborCostTheoric = RPSControlFactory.CreateRPSFormattedTextBox<ManufacturingOrderEntityView>("77d3a81f-c8f2-41f9-8f41-cd35f0a11c6e","","",false, this);
 
            CalcExternalCostTheoric = RPSControlFactory.CreateRPSFormattedTextBox<ManufacturingOrderEntityView>("48312dfb-e9ed-43ed-a87f-0efc8965d383","","",false, this);
 
            CalcOtherCostTheoric = RPSControlFactory.CreateRPSFormattedTextBox<ManufacturingOrderEntityView>("912ee35c-49b9-47a6-8a39-bd55965aece5","","",false, this);
 
            CalcEstimatedTime = RPSControlFactory.CreateRPSFormattedTextBox<ManufacturingOrderEntityView>("3c6fd4c3-8ea0-48bd-9b03-06edb55ca30a","","",false, this);
 
            CalcMaterialCostReal = RPSControlFactory.CreateRPSFormattedTextBox<ManufacturingOrderEntityView>("fbbefe47-0c59-4f08-8028-e0fb228da1eb","","",false, this);
 
            CalcLaborCostReal = RPSControlFactory.CreateRPSFormattedTextBox<ManufacturingOrderEntityView>("56fbe7c0-e901-44a0-9d9d-04a4803c3d05","","",false, this);
 
            CalcExternalCostReal = RPSControlFactory.CreateRPSFormattedTextBox<ManufacturingOrderEntityView>("9a5b74dd-0cd7-4644-a454-7ee4ae6f1f88","","",false, this);
 
            CalcOtherCostReal = RPSControlFactory.CreateRPSFormattedTextBox<ManufacturingOrderEntityView>("ba063653-0dce-4310-b67a-3822a835f5e1","","",false, this);
 
            CalcRealTime = RPSControlFactory.CreateRPSFormattedTextBox<ManufacturingOrderEntityView>("5d5094f3-416a-48ef-a81c-336a9fd2c16f","","",false, this);
 
            ExecuteAddNewMOSeriesReserveButton = RPSControlFactory.CreateRPSButton<ManufacturingOrderEntityView>( "f4e9818b-93de-4995-b275-143122e88bd1","","",this);
 
            AddUsualTaskCommandButton = RPSControlFactory.CreateRPSButtonToView<ManufacturingOrderEntityView,AddUsualTaskDialogView>("7dd3db6c-e4a2-4c64-8ee2-8ba3ab328b27","","", this,Screen.AddUsualTaskDialogView);
 
            MOPlanningExecCommandButton = RPSControlFactory.CreateRPSButton<ManufacturingOrderEntityView>( "aa3becf2-9ceb-4498-b695-422ed39bd230","","",this);
 
            ChangeSiteNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ManufacturingOrderEntityView,ChangeSiteDialogView>("a3d865fc-cf8d-42d3-bb2b-2766811738da","","", this,Screen.ChangeSiteDialogView);
 
            ChangeRouteNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ManufacturingOrderEntityView,ChangeRouteDialogView>("29a69452-3dfe-4ed5-8b12-590b95427b01","","", this,Screen.ChangeRouteDialogView);
 
            MainManufacturingOrderNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ManufacturingOrderEntityView,MainManufacturingOrderDialogView>("90cfbac4-63a5-4167-89d7-a50d6724fa92","","", this,Screen.MainManufacturingOrderDialogView);
 
            SecondaryManufacturingOrderNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ManufacturingOrderEntityView,SecondaryManufacturingOrderDialogView>("ec626556-8e72-488e-bffa-fff3f67239f4","","", this,Screen.SecondaryManufacturingOrderDialogView);
 
            ExecuteAssignAndLaunchMOButton = RPSControlFactory.CreateRPSButton<ManufacturingOrderEntityView>( "c344c241-541e-4859-b45d-60dc63b8284a","","",this);
 
            ExecutePlanifyMOButton = RPSControlFactory.CreateRPSButton<ManufacturingOrderEntityView>( "a7227616-5b93-4f17-837c-d8c13fcdabb7","","",this);
 
            EndProductInputNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ManufacturingOrderEntityView,EndProductInputDialogView>("6c066d76-b7bd-450c-b93d-a81b0b8f4b11","","", this,Screen.EndProductInputDialogView);
 
            CollectionInit params_MOTasks = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a9a9c4da-1f5a-47ab-8592-98518bd24d87",CSSSelectorGrid="",XPathGrid=""};
            MOTasks = RPSControlFactory.RPSCreateCollectionWithGrid<MOTasksCollectionEditor<ManufacturingOrderEntityView,MOTaskView>,ManufacturingOrderEntityView,MOTaskView>( params_MOTasks,this,Screen.MOTaskView);
 
            CollectionInit params_MOFeatures = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="33f7c56a-7413-43e2-9f25-a14cc66f275b",CSSSelectorGrid="",XPathGrid=""};
            MOFeatures = RPSControlFactory.RPSCreateCollectionWithGrid<MOFeaturesCollectionEditor<ManufacturingOrderEntityView,MOTaskView>,ManufacturingOrderEntityView,MOTaskView>( params_MOFeatures,this,Screen.MOTaskView);
 
            CollectionInit params_MOSeriesReserves = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="bf4328b8-a7d2-43c0-8be6-e64024c2e959",CSSSelectorGrid="",XPathGrid=""};
            MOSeriesReserves = RPSControlFactory.RPSCreateCollectionWithGrid<MOSeriesReservesCollectionEditor<ManufacturingOrderEntityView,MOTaskView>,ManufacturingOrderEntityView,MOTaskView>( params_MOSeriesReserves,this,Screen.MOTaskView);
 
            CollectionInit params_MODimensions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ed5a518f-e06c-4a6e-bf53-d8b0417de162",CSSSelectorGrid="",XPathGrid=""};
            MODimensions = RPSControlFactory.RPSCreateCollectionWithGrid<MODimensionsCollectionEditor<ManufacturingOrderEntityView,MOTaskView>,ManufacturingOrderEntityView,MOTaskView>( params_MODimensions,this,Screen.MOTaskView);
 
            SectionGantt = RPSControlFactory.CreateRPSSection<ManufacturingOrderEntityView>( "","ul li[rpsid='63af889e-9862-42a7-8ad1-f17bfd14ddb7']","",this);
 
            SectionGeneral = RPSControlFactory.CreateRPSSection<ManufacturingOrderEntityView>( "","ul li[rpsid='6ea7d97d-d474-455f-8ca4-6fc36d2bb391']","",this);
 
            SectionTasks = RPSControlFactory.CreateRPSSection<ManufacturingOrderEntityView>( "","ul li[rpsid='3574f08f-6b8a-47e6-a5b9-d4b7c31982fb']","",this);
 
            SectionNotes = RPSControlFactory.CreateRPSSection<ManufacturingOrderEntityView>( "","ul li[rpsid='f81cabe4-d12a-4e4a-a1b7-b9203a39008a']","",this);
 
            SectionFeatures = RPSControlFactory.CreateRPSSection<ManufacturingOrderEntityView>( "","ul li[rpsid='6744f306-703f-4bf1-8267-1e7a22d765dd']","",this);
 
            SectionCostAnalysis = RPSControlFactory.CreateRPSSection<ManufacturingOrderEntityView>( "","ul li[rpsid='f83f4af2-8fbe-4076-8552-39ec8c4a4c26']","",this);
 
            SectionSeriesReserve = RPSControlFactory.CreateRPSSection<ManufacturingOrderEntityView>( "","ul li[rpsid='7a6fa7b8-abad-47a8-b253-1f1872e0fa03']","",this);
 
            SectionDimensions = RPSControlFactory.CreateRPSSection<ManufacturingOrderEntityView>( "","ul li[rpsid='adc26e88-95c0-4619-88d4-ec609b697a73']","",this);
 

        }
        public IRPSSaveButton<ManufacturingOrderEntityView> SaveButton { get; set; } 
        public IRPSButton<ManufacturingOrderEntityView> DeleteButton { get; set; } 
        public IRPSButton<ManufacturingOrderEntityView,ManufacturingOrderCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ManufacturingOrderEntityView,ManufacturingOrderCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ManufacturingOrderEntityView> CodManufacturingOrder { get; set; } 
        public IRPSTextBox<ManufacturingOrderEntityView> Description { get; set; } 
        public IRPSComboBox<ManufacturingOrderEntityView> IDArticle { get; set; } 
        public IRPSComboBox<ManufacturingOrderEntityView> UISite { get; set; } 
        public IRPSComboBox<ManufacturingOrderEntityView> IDMOSituation { get; set; } 
        public IRPSColorEditor<ManufacturingOrderEntityView> Color { get; set; } 
        public IRPSTextBox<ManufacturingOrderEntityView> Quantity { get; set; } 
        public IRPSTextBox<ManufacturingOrderEntityView> CalcManufacturedQuantity { get; set; } 
        public IRPSTextBox<ManufacturingOrderEntityView> PlannedStartDate { get; set; } 
        public IRPSTextBox<ManufacturingOrderEntityView> PlannedStartTime { get; set; } 
        public IRPSTextBox<ManufacturingOrderEntityView> PlannedEndDate { get; set; } 
        public IRPSTextBox<ManufacturingOrderEntityView> PlannedEndTime { get; set; } 
        public IRPSTextBox<ManufacturingOrderEntityView> PlannedEndMRPDate { get; set; } 
        public IRPSTextBox<ManufacturingOrderEntityView> ManualPStartDate { get; set; } 
        public IRPSTextBox<ManufacturingOrderEntityView> ManualPEndDate { get; set; } 
        public IRPSTextBox<ManufacturingOrderEntityView> ManualEndDate { get; set; } 
        public IRPSTextBox<ManufacturingOrderEntityView> RealEndDate { get; set; } 
        public IRPSTextBox<ManufacturingOrderEntityView> AcceptedDate { get; set; } 
        public IRPSComboBox<ManufacturingOrderEntityView> IDStructureType { get; set; } 
        public IRPSComboBox<ManufacturingOrderEntityView> UIStructure { get; set; } 
        public IRPSComboBox<ManufacturingOrderEntityView> IDArticleVersion { get; set; } 
        public IRPSComboBox<ManufacturingOrderEntityView> TimeUnitDefault { get; set; } 
        public IRPSComboBox<ManufacturingOrderEntityView> IDWareHouse { get; set; } 
        public IRPSTextBox<ManufacturingOrderEntityView> InternalCode { get; set; } 
        public IRPSComboBox<ManufacturingOrderEntityView> IDRoute { get; set; } 
        public IRPSComboBox<ManufacturingOrderEntityView> PlanningDirection { get; set; } 
        public IRPSTextBox<ManufacturingOrderEntityView> Priority { get; set; } 
        public IRPSTextBox<ManufacturingOrderEntityView> Group { get; set; } 
        public IRPSCheckbox<ManufacturingOrderEntityView> AutomaticCodification { get; set; } 
        public IRPSComboBox<ManufacturingOrderEntityView> IDProject { get; set; } 
        public IRPSComboBox<ManufacturingOrderEntityView> IDProTask { get; set; } 
        public IRPSComboBox<ManufacturingOrderEntityView> IDProMaterial { get; set; } 
        public IRPSComboBox<ManufacturingOrderEntityView> IDMaintenanceOrder { get; set; } 
        public IRPSComboBox<ManufacturingOrderEntityView> IDOrderMaterialPrevision { get; set; } 
        public IRPSComboBox<ManufacturingOrderEntityView> UIOrderSL { get; set; } 
        public IRPSComboBox<ManufacturingOrderEntityView> UIOrderLineSL { get; set; } 
        public IRPSTextBox<ManufacturingOrderEntityView> Notes { get; set; } 
        public IRPSTextBox<ManufacturingOrderEntityView> CalcInventoryCost { get; set; } 
        public IRPSTextBox<ManufacturingOrderEntityView> CalcManufacturedQuantity1 { get; set; } 
        public IRPSTextBox<ManufacturingOrderEntityView> CalcManufacturedQuantityCost { get; set; } 
        public IRPSTextBox<ManufacturingOrderEntityView> CalcRejectedQuantity { get; set; } 
        public IRPSTextBox<ManufacturingOrderEntityView> CalcMaterialCostTheoric { get; set; } 
        public IRPSTextBox<ManufacturingOrderEntityView> CalcLaborCostTheoric { get; set; } 
        public IRPSTextBox<ManufacturingOrderEntityView> CalcExternalCostTheoric { get; set; } 
        public IRPSTextBox<ManufacturingOrderEntityView> CalcOtherCostTheoric { get; set; } 
        public IRPSTextBox<ManufacturingOrderEntityView> CalcEstimatedTime { get; set; } 
        public IRPSTextBox<ManufacturingOrderEntityView> CalcMaterialCostReal { get; set; } 
        public IRPSTextBox<ManufacturingOrderEntityView> CalcLaborCostReal { get; set; } 
        public IRPSTextBox<ManufacturingOrderEntityView> CalcExternalCostReal { get; set; } 
        public IRPSTextBox<ManufacturingOrderEntityView> CalcOtherCostReal { get; set; } 
        public IRPSTextBox<ManufacturingOrderEntityView> CalcRealTime { get; set; } 
        public IRPSButton<ManufacturingOrderEntityView> ExecuteAddNewMOSeriesReserveButton { get; set; } 
        public IRPSButton<ManufacturingOrderEntityView,AddUsualTaskDialogView> AddUsualTaskCommandButton { get; set; } 
        public IRPSButton<ManufacturingOrderEntityView> MOPlanningExecCommandButton { get; set; } 
        public IRPSButton<ManufacturingOrderEntityView,ChangeSiteDialogView> ChangeSiteNavigationCommandButton { get; set; } 
        public IRPSButton<ManufacturingOrderEntityView,ChangeRouteDialogView> ChangeRouteNavigationCommandButton { get; set; } 
        public IRPSButton<ManufacturingOrderEntityView,MainManufacturingOrderDialogView> MainManufacturingOrderNavigationCommandButton { get; set; } 
        public IRPSButton<ManufacturingOrderEntityView,SecondaryManufacturingOrderDialogView> SecondaryManufacturingOrderNavigationCommandButton { get; set; } 
        public IRPSButton<ManufacturingOrderEntityView> ExecuteAssignAndLaunchMOButton { get; set; } 
        public IRPSButton<ManufacturingOrderEntityView> ExecutePlanifyMOButton { get; set; } 
        public IRPSButton<ManufacturingOrderEntityView,EndProductInputDialogView> EndProductInputNavigationCommandButton { get; set; } 
        public MOTasksCollectionEditor<ManufacturingOrderEntityView,MOTaskView> MOTasks { get; set; } 
        public MOFeaturesCollectionEditor<ManufacturingOrderEntityView,MOTaskView> MOFeatures { get; set; } 
        public MOSeriesReservesCollectionEditor<ManufacturingOrderEntityView,MOTaskView> MOSeriesReserves { get; set; } 
        public MODimensionsCollectionEditor<ManufacturingOrderEntityView,MOTaskView> MODimensions { get; set; } 
        public IRPSSection<ManufacturingOrderEntityView> SectionGantt { get; set; } 
        public IRPSSection<ManufacturingOrderEntityView> SectionGeneral { get; set; } 
        public IRPSSection<ManufacturingOrderEntityView> SectionTasks { get; set; } 
        public IRPSSection<ManufacturingOrderEntityView> SectionNotes { get; set; } 
        public IRPSSection<ManufacturingOrderEntityView> SectionFeatures { get; set; } 
        public IRPSSection<ManufacturingOrderEntityView> SectionCostAnalysis { get; set; } 
        public IRPSSection<ManufacturingOrderEntityView> SectionSeriesReserve { get; set; } 
        public IRPSSection<ManufacturingOrderEntityView> SectionDimensions { get; set; } 
        public ManufacturingOrder Screen { get; set; }
        public ManufacturingOrderEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MOTasksCollectionEditor<ManufacturingOrderEntityView,MOTaskView>:RPSCollectionEditor<ManufacturingOrderEntityView,MOTaskView> where ManufacturingOrderEntityView : class, IView where MOTaskView : class, IView
    {
        public  MOTasksGridView<ManufacturingOrderEntityView,MOTaskView> GridView {get;set;}
    }
    public partial class MOTasksGridView <ManufacturingOrderEntityView,MOTaskView> :  RPSGridView<ManufacturingOrderEntityView,MOTaskView> where ManufacturingOrderEntityView : class, IView where MOTaskView : class, IView
    {
        public MOTasksGridView(ManufacturingOrderEntityView currentView,MOTaskView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            TaskType = RPSControlFactory.CreateRPSGridEnumComboBox<ManufacturingOrderEntityView>("","#a9a9c4da-1f5a-47ab-8592-98518bd24d87 .ag-row[role='row']@ROWINDEX [col-id='cTaskType']","",true, this.CurrentView);
 
            CodMOTask = RPSControlFactory.CreateRPSGridTextBox<ManufacturingOrderEntityView>("","#a9a9c4da-1f5a-47ab-8592-98518bd24d87 .ag-row[role='row']@ROWINDEX [col-id='cCodMOTask']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ManufacturingOrderEntityView>("","#a9a9c4da-1f5a-47ab-8592-98518bd24d87 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            ExecutionTime = RPSControlFactory.CreateRPSGridDurationTextBox<ManufacturingOrderEntityView>("","#a9a9c4da-1f5a-47ab-8592-98518bd24d87 .ag-row[role='row']@ROWINDEX [col-id='cExecutionTime']","",true, this.CurrentView);
 
            PlannedStartDate = RPSControlFactory.CreateRPSGridTextBox<ManufacturingOrderEntityView>("","#a9a9c4da-1f5a-47ab-8592-98518bd24d87 .ag-row[role='row']@ROWINDEX [col-id='cPlannedStartDate']","",true, this.CurrentView);
 
            PlannedEndDate = RPSControlFactory.CreateRPSGridTextBox<ManufacturingOrderEntityView>("","#a9a9c4da-1f5a-47ab-8592-98518bd24d87 .ag-row[role='row']@ROWINDEX [col-id='cPlannedEndDate']","",true, this.CurrentView);
 
            PorcentProg = RPSControlFactory.CreateRPSGridFormattedTextBox<ManufacturingOrderEntityView>("","#a9a9c4da-1f5a-47ab-8592-98518bd24d87 .ag-row[role='row']@ROWINDEX [col-id='cPorcentProg']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ManufacturingOrderEntityView> TaskType { get; set; } 
        public IRPSGridTextBox<ManufacturingOrderEntityView> CodMOTask { get; set; } 
        public IRPSGridTextBox<ManufacturingOrderEntityView> Description { get; set; } 
        public IRPSGridDurationTextBox<ManufacturingOrderEntityView> ExecutionTime { get; set; } 
        public IRPSGridTextBox<ManufacturingOrderEntityView> PlannedStartDate { get; set; } 
        public IRPSGridTextBox<ManufacturingOrderEntityView> PlannedEndDate { get; set; } 
        public IRPSGridTextBox<ManufacturingOrderEntityView> PorcentProg { get; set; } 
                     
    }
 
        public partial class MOFeaturesCollectionEditor<ManufacturingOrderEntityView,MOTaskView>:RPSCollectionEditor<ManufacturingOrderEntityView,MOTaskView> where ManufacturingOrderEntityView : class, IView where MOTaskView : class, IView
    {
        public  MOFeaturesGridView<ManufacturingOrderEntityView,MOTaskView> GridView {get;set;}
    }
    public partial class MOFeaturesGridView <ManufacturingOrderEntityView,MOTaskView> :  RPSGridView<ManufacturingOrderEntityView,MOTaskView> where ManufacturingOrderEntityView : class, IView where MOTaskView : class, IView
    {
        public MOFeaturesGridView(ManufacturingOrderEntityView currentView,MOTaskView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDFeatureLabel = RPSControlFactory.CreateRPSGridComboBox<ManufacturingOrderEntityView>("","#33f7c56a-7413-43e2-9f25-a14cc66f275b .ag-row[role='row']@ROWINDEX [col-id='cIDFeatureLabel']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<ManufacturingOrderEntityView> IDFeatureLabel { get; set; } 
                     
    }
 
        public partial class MOSeriesReservesCollectionEditor<ManufacturingOrderEntityView,MOTaskView>:RPSCollectionEditor<ManufacturingOrderEntityView,MOTaskView> where ManufacturingOrderEntityView : class, IView where MOTaskView : class, IView
    {
        public  MOSeriesReservesGridView<ManufacturingOrderEntityView,MOTaskView> GridView {get;set;}
    }
    public partial class MOSeriesReservesGridView <ManufacturingOrderEntityView,MOTaskView> :  RPSGridView<ManufacturingOrderEntityView,MOTaskView> where ManufacturingOrderEntityView : class, IView where MOTaskView : class, IView
    {
        public MOSeriesReservesGridView(ManufacturingOrderEntityView currentView,MOTaskView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Series = RPSControlFactory.CreateRPSGridTextBox<ManufacturingOrderEntityView>("","#bf4328b8-a7d2-43c0-8be6-e64024c2e959 .ag-row[role='row']@ROWINDEX [col-id='cSeries']","",true, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<ManufacturingOrderEntityView>("","#bf4328b8-a7d2-43c0-8be6-e64024c2e959 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            QuantityRejected = RPSControlFactory.CreateRPSGridFormattedTextBox<ManufacturingOrderEntityView>("","#bf4328b8-a7d2-43c0-8be6-e64024c2e959 .ag-row[role='row']@ROWINDEX [col-id='cQuantityRejected']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<ManufacturingOrderEntityView> Series { get; set; } 
        public IRPSGridTextBox<ManufacturingOrderEntityView> Quantity { get; set; } 
        public IRPSGridTextBox<ManufacturingOrderEntityView> QuantityRejected { get; set; } 
                     
    }
 
        public partial class MODimensionsCollectionEditor<ManufacturingOrderEntityView,MOTaskView>:RPSCollectionEditor<ManufacturingOrderEntityView,MOTaskView> where ManufacturingOrderEntityView : class, IView where MOTaskView : class, IView
    {
        public  MODimensionsGridView<ManufacturingOrderEntityView,MOTaskView> GridView {get;set;}
    }
    public partial class MODimensionsGridView <ManufacturingOrderEntityView,MOTaskView> :  RPSGridView<ManufacturingOrderEntityView,MOTaskView> where ManufacturingOrderEntityView : class, IView where MOTaskView : class, IView
    {
        public MODimensionsGridView(ManufacturingOrderEntityView currentView,MOTaskView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDDimension = RPSControlFactory.CreateRPSGridComboBox<ManufacturingOrderEntityView>("","#ed5a518f-e06c-4a6e-bf53-d8b0417de162 .ag-row[role='row']@ROWINDEX [col-id='cIDDimension']","",true, this.CurrentView);
 
            IDDimValue = RPSControlFactory.CreateRPSGridComboBox<ManufacturingOrderEntityView>("","#ed5a518f-e06c-4a6e-bf53-d8b0417de162 .ag-row[role='row']@ROWINDEX [col-id='cIDDimValue']","",false, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<ManufacturingOrderEntityView>("","#ed5a518f-e06c-4a6e-bf53-d8b0417de162 .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<ManufacturingOrderEntityView> IDDimension { get; set; } 
        public IRPSGridComboBox<ManufacturingOrderEntityView> IDDimValue { get; set; } 
        public IRPSGridTextBox<ManufacturingOrderEntityView> Percentage { get; set; } 
                     
    }
 
    }
  
            
    public partial class MOFeatureView : View
    {
        public MOFeatureView(ManufacturingOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MOFeatureView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MOFeatureView,ManufacturingOrderEntityView>( this,Screen.ManufacturingOrderEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<MOFeatureView,ManufacturingOrderEntityView>( this,Screen.ManufacturingOrderEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MOFeatureView,ManufacturingOrderEntityView>( this,Screen.ManufacturingOrderEntityView);
 
            IDFeatureLabel = RPSControlFactory.CreateRPSComboBox<MOFeatureView>("b3ae9134-d3af-4f9a-acf1-bb64841d9b08","","",true, this);
 

        }
        public IRPSButton<MOFeatureView> DeleteButton { get; set; } 
        public IRPSButton<MOFeatureView,ManufacturingOrderEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MOFeatureView,ManufacturingOrderEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<MOFeatureView,ManufacturingOrderEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<MOFeatureView> IDFeatureLabel { get; set; } 
        public ManufacturingOrder Screen { get; set; }
        public MOFeatureView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NewFromSalesDialogView : View
    {
        public NewFromSalesDialogView(ManufacturingOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIRoute = RPSControlFactory.CreateRPSComboBox<NewFromSalesDialogView>("48f2c964-73dc-4218-b8f3-77fdea1daa2a","","",false, this);
 
            UICreateMOMaterials = RPSControlFactory.CreateRPSCheckBox<NewFromSalesDialogView>("15dabf58-6781-4597-a065-a90cfa4ded0b","","",false, this);
 
            UICreateProposalMaterials = RPSControlFactory.CreateRPSCheckBox<NewFromSalesDialogView>("5b34a76e-8aa4-4004-8661-d953c5842ce2","","",false, this);
 
            UILaunchAfterCreate = RPSControlFactory.CreateRPSCheckBox<NewFromSalesDialogView>("a026f3eb-8211-414b-b6ed-d88e2a0593fa","","",false, this);
 
            UIMOSituation = RPSControlFactory.CreateRPSComboBox<NewFromSalesDialogView>("4c8d2044-94c2-4d2e-bf9a-e5e43c29d4d9","","",false, this);
 
            UILaunchDate = RPSControlFactory.CreateRPSTextBox<NewFromSalesDialogView>("59f9f3b1-5897-4ead-97c5-196f7c34093c","","",false, this);
 
            CollectionInit params_GetOrderSalesToCreateMO = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8f413d67-21c8-4a2d-8b0b-0e3e0d83e8f8",CSSSelectorGrid="",XPathGrid=""};
            GetOrderSalesToCreateMO = RPSControlFactory.RPSCreateCollectionWithGrid<GetOrderSalesToCreateMOCollectionEditor<NewFromSalesDialogView>,NewFromSalesDialogView>( params_GetOrderSalesToCreateMO,this);
 

        }
        public IRPSComboBox<NewFromSalesDialogView> UIRoute { get; set; } 
        public IRPSCheckbox<NewFromSalesDialogView> UICreateMOMaterials { get; set; } 
        public IRPSCheckbox<NewFromSalesDialogView> UICreateProposalMaterials { get; set; } 
        public IRPSCheckbox<NewFromSalesDialogView> UILaunchAfterCreate { get; set; } 
        public IRPSComboBox<NewFromSalesDialogView> UIMOSituation { get; set; } 
        public IRPSTextBox<NewFromSalesDialogView> UILaunchDate { get; set; } 
        public GetOrderSalesToCreateMOCollectionEditor<NewFromSalesDialogView> GetOrderSalesToCreateMO { get; set; } 
        public ManufacturingOrder Screen { get; set; }
        public NewFromSalesDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetOrderSalesToCreateMOCollectionEditor<NewFromSalesDialogView>:RPSCollectionEditor<NewFromSalesDialogView> where NewFromSalesDialogView : class, IView
    {
        public  GetOrderSalesToCreateMOGridView<NewFromSalesDialogView> GridView {get;set;}
    }
    public partial class GetOrderSalesToCreateMOGridView <NewFromSalesDialogView> :  RPSGridView<NewFromSalesDialogView> where NewFromSalesDialogView : class, IView
    {
        public GetOrderSalesToCreateMOGridView(NewFromSalesDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            OrderSL_OrderDate = RPSControlFactory.CreateRPSGridTextBox<NewFromSalesDialogView>("","#8f413d67-21c8-4a2d-8b0b-0e3e0d83e8f8 .ag-row[role='row']@ROWINDEX [col-id='cOrderSL_OrderDate']","",false, this.CurrentView);
 
            ArticleDetail_Type = RPSControlFactory.CreateRPSGridTextBox<NewFromSalesDialogView>("","#8f413d67-21c8-4a2d-8b0b-0e3e0d83e8f8 .ag-row[role='row']@ROWINDEX [col-id='cArticleDetail_Type']","",false, this.CurrentView);
 
            OrderLineSL_Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<NewFromSalesDialogView>("","#8f413d67-21c8-4a2d-8b0b-0e3e0d83e8f8 .ag-row[role='row']@ROWINDEX [col-id='cOrderLineSL_Quantity']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<NewFromSalesDialogView> OrderSL_OrderDate { get; set; } 
        public IRPSGridTextBox<NewFromSalesDialogView> ArticleDetail_Type { get; set; } 
        public IRPSGridTextBox<NewFromSalesDialogView> OrderLineSL_Quantity { get; set; } 
                     
    }
 
    }
  
            
    public partial class MODimensionView : View
    {
        public MODimensionView(ManufacturingOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MODimensionView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MODimensionView,ManufacturingOrderEntityView>( this,Screen.ManufacturingOrderEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<MODimensionView,ManufacturingOrderEntityView>( this,Screen.ManufacturingOrderEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MODimensionView,ManufacturingOrderEntityView>( this,Screen.ManufacturingOrderEntityView);
 
            IDDimension = RPSControlFactory.CreateRPSComboBox<MODimensionView>("91eac5f6-ed70-4340-86de-a7a939e2bfbf","","",true, this);
 
            IDDimValue = RPSControlFactory.CreateRPSComboBox<MODimensionView>("904ba669-97e8-4ad0-a78a-dce3670d559d","","",false, this);
 
            Percentage = RPSControlFactory.CreateRPSFormattedTextBox<MODimensionView>("4fadcf31-36e7-4a6d-a7f1-d5f89ac4b6a7","","",true, this);
 

        }
        public IRPSButton<MODimensionView> DeleteButton { get; set; } 
        public IRPSButton<MODimensionView,ManufacturingOrderEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MODimensionView,ManufacturingOrderEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<MODimensionView,ManufacturingOrderEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<MODimensionView> IDDimension { get; set; } 
        public IRPSComboBox<MODimensionView> IDDimValue { get; set; } 
        public IRPSTextBox<MODimensionView> Percentage { get; set; } 
        public ManufacturingOrder Screen { get; set; }
        public MODimensionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MOSeriesReserveView : View
    {
        public MOSeriesReserveView(ManufacturingOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MOSeriesReserveView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MOSeriesReserveView,ManufacturingOrderEntityView>( this,Screen.ManufacturingOrderEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<MOSeriesReserveView,ManufacturingOrderEntityView>( this,Screen.ManufacturingOrderEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MOSeriesReserveView,ManufacturingOrderEntityView>( this,Screen.ManufacturingOrderEntityView);
 
            Series = RPSControlFactory.CreateRPSTextBox<MOSeriesReserveView>("9c969e7c-cda1-43e0-a86d-56727de4d860","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<MOSeriesReserveView>("d9baf8f8-6881-41c1-930e-6cbc7de610b8","","",true, this);
 
            QuantityRejected = RPSControlFactory.CreateRPSFormattedTextBox<MOSeriesReserveView>("e2f433c9-9e4f-45b3-891b-42464471f95d","","",true, this);
 

        }
        public IRPSButton<MOSeriesReserveView> DeleteButton { get; set; } 
        public IRPSButton<MOSeriesReserveView,ManufacturingOrderEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MOSeriesReserveView,ManufacturingOrderEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<MOSeriesReserveView,ManufacturingOrderEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<MOSeriesReserveView> Series { get; set; } 
        public IRPSTextBox<MOSeriesReserveView> Quantity { get; set; } 
        public IRPSTextBox<MOSeriesReserveView> QuantityRejected { get; set; } 
        public ManufacturingOrder Screen { get; set; }
        public MOSeriesReserveView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MOTaskView : View
    {
        public MOTaskView(ManufacturingOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MOTaskView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MOTaskView,ManufacturingOrderEntityView>( this,Screen.ManufacturingOrderEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<MOTaskView,ManufacturingOrderEntityView>( this,Screen.ManufacturingOrderEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MOTaskView,ManufacturingOrderEntityView>( this,Screen.ManufacturingOrderEntityView);
 
            CodMOTask = RPSControlFactory.CreateRPSTextBox<MOTaskView>("1465a3c5-649e-4bd5-ac3a-f276fae0ee7a","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MOTaskView>("f43f1df3-2782-4981-8c7f-a5ecc5ecde08","","",false, this);
 
            PlannedStartDate = RPSControlFactory.CreateRPSTextBox<MOTaskView>("321c5a7a-d968-4b31-b815-2baca7d51259","","",true, this);
 
            PlannedStartTime = RPSControlFactory.CreateRPSTextBox<MOTaskView>("7ef4ffcf-ebf3-4cfc-8dc2-cad02050ed89","","",false, this);
 
            PlannedEndDate = RPSControlFactory.CreateRPSTextBox<MOTaskView>("70377141-1bcd-46f8-aa09-9ee928f2b95f","","",true, this);
 
            PlannedEndTime = RPSControlFactory.CreateRPSTextBox<MOTaskView>("6dc3fe18-bd77-406d-8659-5e9b2c9cce00","","",false, this);
 
            ExecutionTime = RPSControlFactory.CreateRPSDurationTextBox<MOTaskView>("f696026f-de94-4925-b093-df9da86cf412","","",true, this);
 
            PreparationTime = RPSControlFactory.CreateRPSDurationTextBox<MOTaskView>("16c373ae-b562-4a9a-b1fb-7b1afdeaf0b1","","",true, this);
 
            ManualStartDate = RPSControlFactory.CreateRPSTextBox<MOTaskView>("702fd3d2-f684-47fb-a2b7-84e54f569644","","",false, this);
 
            ManualEndDate = RPSControlFactory.CreateRPSTextBox<MOTaskView>("8c02f879-61e7-4e2f-bb02-ec297b1db203","","",false, this);
 
            TimeUnit = RPSControlFactory.CreateRPSEnumComboBox<MOTaskView>("0fa4aa94-be6a-40a4-876c-f3522ba18151","","",true, this);
 
            WorkUnits = RPSControlFactory.CreateRPSFormattedTextBox<MOTaskView>("09b21401-2689-4a93-a49a-b8e5b806739f","","",true, this);
 
            PercentProgress = RPSControlFactory.CreateRPSFormattedTextBox<MOTaskView>("d91eefaa-dcbb-4d0c-9fc7-2e02979c5593","","",true, this);
 
            TaskType = RPSControlFactory.CreateRPSEnumComboBox<MOTaskView>("c2573807-5610-4c2b-a549-67298621af09","","",true, this);
 
            DateReplanify = RPSControlFactory.CreateRPSTextBox<MOTaskView>("55116e20-c796-4ac1-9dbf-48d6424a9e68","","",true, this);
 
            RealEndDate = RPSControlFactory.CreateRPSTextBox<MOTaskView>("4fffeed3-9fed-4cd6-a0e5-41b9fad7da9e","","",false, this);
 
            Blocked = RPSControlFactory.CreateRPSCheckBox<MOTaskView>("a30ca254-ebd0-4526-904c-b1660348a750","","",true, this);
 
            BlockedMaterial = RPSControlFactory.CreateRPSCheckBox<MOTaskView>("41648a65-b79a-44ca-a678-3c6a795c05e5","","",true, this);
 
            BlockedCost = RPSControlFactory.CreateRPSCheckBox<MOTaskView>("7b301dc0-2959-411c-9a95-054df70ee97d","","",true, this);
 
            LotsOrder = RPSControlFactory.CreateRPSCheckBox<MOTaskView>("0aadc7da-a712-4c56-98a5-c7c82a8db7c3","","",true, this);
 
            ProductEntry = RPSControlFactory.CreateRPSCheckBox<MOTaskView>("de9f7280-4106-4641-b2ee-43ff17223c15","","",true, this);
 
            MaterialExit = RPSControlFactory.CreateRPSCheckBox<MOTaskView>("3e8bbaf7-62ed-4bda-a7b4-aae9ce356b63","","",true, this);
 
            PrintLabels = RPSControlFactory.CreateRPSCheckBox<MOTaskView>("5fd369c5-edad-490a-b053-c54feef8c65a","","",true, this);
 
            AutoExecutionImputation = RPSControlFactory.CreateRPSCheckBox<MOTaskView>("737e921d-98af-4fb0-a2c8-cbde0b274c22","","",true, this);
 
            Canceled = RPSControlFactory.CreateRPSCheckBox<MOTaskView>("487b182f-d409-4dfc-92a5-7b584f7aa476","","",true, this);
 
            GroupingNumber = RPSControlFactory.CreateRPSTextBox<MOTaskView>("b499002e-86e9-4bdd-a25f-d7f7d41a81e2","","",false, this);
 
            DescGroupOfTask = RPSControlFactory.CreateRPSTextBox<MOTaskView>("4d705b2f-26fb-4900-a79e-60d0ba226148","","",false, this);
 
            UIProductFormula = RPSControlFactory.CreateRPSComboBox<MOTaskView>("72e4ef92-d37b-4f9c-abe4-2a7fbf67cbef","","",false, this);
 
            UIProductFormulaVersion = RPSControlFactory.CreateRPSTextBox<MOTaskView>("82e7e665-5b10-436d-ae1d-209513d4325d","","",false, this);
 
            UIProductFormulaDate = RPSControlFactory.CreateRPSTextBox<MOTaskView>("3ff90658-04a2-4670-95af-d80367fdd98c","","",false, this);
 
            IDMOTaskParent = RPSControlFactory.CreateRPSComboBox<MOTaskView>("7e5f7966-b29b-4d8b-a7a7-0b67474cfe21","","",false, this);
 
            IDTaskType = RPSControlFactory.CreateRPSComboBox<MOTaskView>("ff603d1d-4100-40fd-bb2d-3a18e59aca1b","","",false, this);
 
            RepetitionTime = RPSControlFactory.CreateRPSDurationTextBox<MOTaskView>("9e9e373c-788c-4b44-91b8-0b768bbb0f7b","","",true, this);
 
            RepetitionLot = RPSControlFactory.CreateRPSFormattedTextBox<MOTaskView>("1b0bdeb5-7c7a-40d4-904c-499bc40ef61e","","",true, this);
 
            IDUsualTask = RPSControlFactory.CreateRPSComboBox<MOTaskView>("0dbd2559-2244-44fa-aed5-aef04cacf81d","","",false, this);
 
            prepTimeReal = RPSControlFactory.CreateRPSDurationTextBox<MOTaskView>("88f4c482-9d2c-418a-8191-c2f7b38a66ee","","",false, this);
 
            execTimeReal = RPSControlFactory.CreateRPSDurationTextBox<MOTaskView>("b8582d0e-efd3-437d-87fd-408e3e646b16","","",false, this);
 
            RepetitionTimeReal = RPSControlFactory.CreateRPSDurationTextBox<MOTaskView>("c5ddcdf4-d98f-4291-b9d2-b2952201bb74","","",true, this);
 
            SeriesRequired = RPSControlFactory.CreateRPSCheckBox<MOTaskView>("dd424b14-0aa3-4cff-88ca-31f4f793ede9","","",true, this);
 
            QualityStatus = RPSControlFactory.CreateRPSEnumComboBox<MOTaskView>("2f056cfb-88bc-4f87-9ba7-da7f6e19ed9f","","",true, this);
 
            InspectedDate = RPSControlFactory.CreateRPSTextBox<MOTaskView>("9b9aab2f-746a-4566-ba6d-6b79e4fdb405","","",false, this);
 
            IDCheckList = RPSControlFactory.CreateRPSComboBox<MOTaskView>("c8b50160-ea4a-4d41-8902-34304e51c85c","","",false, this);
 
            DelimitationType = RPSControlFactory.CreateRPSEnumComboBox<MOTaskView>("180c04c4-cf6f-4748-917e-cbdbb0b99f9f","","",true, this);
 
            DelimitationDate = RPSControlFactory.CreateRPSTextBox<MOTaskView>("ed095d4f-ac95-4b26-854b-b6ae95bfee85","","",false, this);
 
            DelimitationHour = RPSControlFactory.CreateRPSTextBox<MOTaskView>("4130fbfe-a054-42fc-8148-36af75da309d","","",false, this);
 
            DelimitationObligatory = RPSControlFactory.CreateRPSCheckBox<MOTaskView>("29302c8f-5d19-48a6-9ce5-043888bdc2f7","","",true, this);
 
            MinimumFraction = RPSControlFactory.CreateRPSFormattedTextBox<MOTaskView>("16816357-285f-4b30-adaa-94c93f2e2ee4","","",true, this);
 
            TimeUnit1 = RPSControlFactory.CreateRPSEnumComboBox<MOTaskView>("5e702dec-60e3-43c1-b9cd-d1c4e0873ea1","","",true, this);
 
            ManualPlanning = RPSControlFactory.CreateRPSCheckBox<MOTaskView>("5b6d8687-f5e7-4d3c-aca3-70f51514c662","","",true, this);
 
            AllowFraccionate = RPSControlFactory.CreateRPSCheckBox<MOTaskView>("cfd06f02-28c7-4daa-81c5-3dc9b33cbebc","","",true, this);
 
            Fixed = RPSControlFactory.CreateRPSCheckBox<MOTaskView>("fed9ef4c-ac57-4f88-9e7b-aad8fec62ead","","",true, this);
 
            WithoutTimetable = RPSControlFactory.CreateRPSCheckBox<MOTaskView>("054f7dca-0f8d-4f5f-84a9-5b140d445a31","","",true, this);
 
            ReleaseKeptResources = RPSControlFactory.CreateRPSCheckBox<MOTaskView>("f45c537e-2d6b-47ef-a0b0-694bfc41a5a5","","",true, this);
 
            OptimizationFeature = RPSControlFactory.CreateRPSTextBox<MOTaskView>("7dfc6701-384c-42f8-8931-e6ed7a466a96","","",false, this);
 
            Priority = RPSControlFactory.CreateRPSFormattedTextBox<MOTaskView>("35b4f79f-3603-4957-843f-1a3df82a1cea","","",true, this);
 
            Group = RPSControlFactory.CreateRPSTextBox<MOTaskView>("18228cdc-5bee-4b12-8173-f8e474011423","","",false, this);
 
            NotOverlapCode = RPSControlFactory.CreateRPSTextBox<MOTaskView>("b6dbc703-b42b-4f4a-ab0c-284575d14eaf","","",false, this);
 
            TiedCode = RPSControlFactory.CreateRPSTextBox<MOTaskView>("ddc0fcd2-b425-4583-83b9-e03a7de1383e","","",false, this);
 
            GroupedManufacturing = RPSControlFactory.CreateRPSCheckBox<MOTaskView>("526bf7e1-4f95-49f9-a7ae-cc5b6eab7611","","",true, this);
 
            ResourcePlanType = RPSControlFactory.CreateRPSEnumComboBox<MOTaskView>("eaa4eb00-c90e-4132-99fd-98552428f58c","","",true, this);
 
            SplitNumber = RPSControlFactory.CreateRPSFormattedTextBox<MOTaskView>("445291e4-863b-4716-ae86-8176f013c40d","","",true, this);
 
            OccupancyType = RPSControlFactory.CreateRPSEnumComboBox<MOTaskView>("92603b37-00da-4c72-9baf-99fe2936bb68","","",true, this);
 
            OccupancyHours = RPSControlFactory.CreateRPSFormattedTextBox<MOTaskView>("52f16d18-b32b-4850-9ef0-3643a80e3956","","",true, this);
 
            OccupancyPercent = RPSControlFactory.CreateRPSFormattedTextBox<MOTaskView>("935cd4ff-9dd0-4451-a286-3041c45a04e4","","",true, this);
 
            External = RPSControlFactory.CreateRPSCheckBox<MOTaskView>("57aeec38-c75f-4c89-bed5-c7332ea43459","","",false, this);
 
            IDArticleExternal = RPSControlFactory.CreateRPSComboBox<MOTaskView>("de65b2a2-07bd-4303-85f3-f58cb19e32c7","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<MOTaskView>("233fd07b-2ec1-43f1-8e91-bc0e1212de40","","",true, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<MOTaskView>("acfecb73-05f8-467e-a4c4-378f62c8e83f","","",false, this);
 
            IDBudgetCategory = RPSControlFactory.CreateRPSComboBox<MOTaskView>("f916f910-381d-4a68-a044-12b6aea44158","","",false, this);
 
            IDSiteMaterial = RPSControlFactory.CreateRPSComboBox<MOTaskView>("c4132c63-439e-4afc-8ac3-f09939a4058c","","",false, this);
 
            IDWarehouseMaterial = RPSControlFactory.CreateRPSComboBox<MOTaskView>("61b09ccf-7682-4816-92be-85ba6422c9f4","","",false, this);
 
            ImputationCostUpdated = RPSControlFactory.CreateRPSCheckBox<MOTaskView>("cbd5b22c-c407-480f-9b7c-a6856f097a99","","",true, this);
 
            Notes = RPSControlFactory.CreateRPSTextBox<MOTaskView>("5f35c382-e5f2-418f-ae35-ac1d1f4ec640","","",false, this);
 
            IDBudgetEmployee = RPSControlFactory.CreateRPSComboBox<MOTaskView>("555f49fa-0f0c-4e5a-8f2e-88e267aaaaa0","","",false, this);
 
            IDBudgetMachine = RPSControlFactory.CreateRPSComboBox<MOTaskView>("1f1a4feb-be1a-4b9d-a888-970d20e10622","","",false, this);
 
            IDBudgetTool = RPSControlFactory.CreateRPSComboBox<MOTaskView>("902e58a4-1e2b-4c21-aacd-fb86dd5a19c6","","",false, this);
 
            IDBudgetMaterial = RPSControlFactory.CreateRPSComboBox<MOTaskView>("3cbd5a6d-ec8a-44d1-888f-1ab93a684317","","",false, this);
 
            IDBudgetOtherCost = RPSControlFactory.CreateRPSComboBox<MOTaskView>("736f3dfc-76e7-4c4f-92ce-bb803ecc656d","","",false, this);
 
            CalcExternalCostTheoric = RPSControlFactory.CreateRPSFormattedTextBox<MOTaskView>("943e0239-bb2a-4bb0-86c5-4e3602d34cbc","","",false, this);
 
            CalcLaborCostTheoric = RPSControlFactory.CreateRPSFormattedTextBox<MOTaskView>("a83c6c62-b620-4538-8cfe-0ddb4e1b02cc","","",false, this);
 
            CalcMaterialCostTheoric = RPSControlFactory.CreateRPSFormattedTextBox<MOTaskView>("8562e594-235f-4fdc-a2d9-01efeb23033b","","",false, this);
 
            CalcOtherCostTheoric = RPSControlFactory.CreateRPSFormattedTextBox<MOTaskView>("8c5e709d-6a9d-4cfd-8130-563223b4a661","","",false, this);
 
            CalcExternalCostReal = RPSControlFactory.CreateRPSFormattedTextBox<MOTaskView>("82ef04fb-9c5d-41f4-84cb-3a197ff6ffdf","","",false, this);
 
            CalcLaborCostReal = RPSControlFactory.CreateRPSFormattedTextBox<MOTaskView>("eb62d641-3aa3-4b60-8115-22acf1a3882f","","",false, this);
 
            CalcMaterialCostReal = RPSControlFactory.CreateRPSFormattedTextBox<MOTaskView>("8451b482-9c35-4b67-a13e-a8953b938c31","","",false, this);
 
            CalcOtherCostReal = RPSControlFactory.CreateRPSFormattedTextBox<MOTaskView>("c3176e3a-cfb2-4963-9475-bf980b1aed40","","",false, this);
 
            CalcRealExecutionTime = RPSControlFactory.CreateRPSFormattedTextBox<MOTaskView>("c8afbda5-5559-4bec-bc40-e80fadd76e34","","",false, this);
 
            CalcRealPreparationTime = RPSControlFactory.CreateRPSFormattedTextBox<MOTaskView>("5ead1b77-19eb-4dd2-a574-6ecb21fc4c0a","","",false, this);
 
            CalcRealTime = RPSControlFactory.CreateRPSFormattedTextBox<MOTaskView>("0881dc41-557d-46ef-a389-0b2d11492c34","","",false, this);
 
            CalcEstimatedTime = RPSControlFactory.CreateRPSFormattedTextBox<MOTaskView>("ca637a0c-fe25-4e33-a8f1-075cfeae5b0f","","",false, this);
 
            CalcManufacturedQuantity = RPSControlFactory.CreateRPSFormattedTextBox<MOTaskView>("7dd433a5-def6-4aa0-b0a4-86816003f939","","",false, this);
 
            CalcPendingTime = RPSControlFactory.CreateRPSFormattedTextBox<MOTaskView>("5f5ff0c0-d63c-4462-9186-dc390d29b126","","",false, this);
 
            CalcRejectedQuantity = RPSControlFactory.CreateRPSFormattedTextBox<MOTaskView>("a5cbdc41-cfcc-4a39-b315-a0cc63e6930c","","",false, this);
 
            CalcRejectedQuantityQuality = RPSControlFactory.CreateRPSFormattedTextBox<MOTaskView>("4133c341-5a56-4b1e-8120-bbe093490d33","","",false, this);
 
            SplitTaskCommandButton = RPSControlFactory.CreateRPSButton<MOTaskView>( "67c76eef-fa25-41e0-96ad-03b9e669d055","","",this);
 
            CollectionInit params_MOTaskRelations = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="90cdf425-4959-4da5-9f42-a6bc69cd5f41",CSSSelectorGrid="",XPathGrid=""};
            MOTaskRelations = RPSControlFactory.RPSCreateCollectionWithGrid<MOTaskRelationsCollectionEditor<MOTaskView,MOMaterialView>,MOTaskView,MOMaterialView>( params_MOTaskRelations,this,Screen.MOMaterialView);
 
            CollectionInit params_MOMaterials = new CollectionInit(){IDDescriptor = "5af0ab99-23b8-4ba7-b8fa-9cd7c14dd365",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="90da6b45-916f-49eb-b139-9850457748f8",CSSSelectorGrid="",XPathGrid=""};
            MOMaterials = RPSControlFactory.RPSCreateCollectionWithGrid<MOMaterialsCollectionEditor<MOTaskView,MOMaterialView>,MOTaskView,MOMaterialView>( params_MOMaterials,this,Screen.MOMaterialView);
 
            CollectionInit params_MOTaskCostComponents = new CollectionInit(){IDDescriptor = "d2b7f436-e22b-4099-8032-43092ba126bc",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b642b7e6-3fac-441e-a783-4410c4cc0bf7",CSSSelectorGrid="",XPathGrid=""};
            MOTaskCostComponents = RPSControlFactory.RPSCreateCollectionWithGrid<MOTaskCostComponentsCollectionEditor<MOTaskView,MOMaterialView>,MOTaskView,MOMaterialView>( params_MOTaskCostComponents,this,Screen.MOMaterialView);
 
            CollectionInit params_MOResourceMachines = new CollectionInit(){IDDescriptor = "c016ad41-df53-4339-a6cd-ea431e8db210",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="14fa10e0-663a-42ba-93d3-82968ca0fcf1",CSSSelectorGrid="",XPathGrid=""};
            MOResourceMachines = RPSControlFactory.RPSCreateCollectionWithGrid<MOResourceMachinesCollectionEditor<MOTaskView,MOMaterialView>,MOTaskView,MOMaterialView>( params_MOResourceMachines,this,Screen.MOMaterialView);
 
            CollectionInit params_MOResourceEmployees = new CollectionInit(){IDDescriptor = "0e22d68f-4ec5-48f0-b7b2-c055573dceb8",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="887cfd06-8f94-4b89-b302-e32d8b6ee8ee",CSSSelectorGrid="",XPathGrid=""};
            MOResourceEmployees = RPSControlFactory.RPSCreateCollectionWithGrid<MOResourceEmployeesCollectionEditor<MOTaskView,MOMaterialView>,MOTaskView,MOMaterialView>( params_MOResourceEmployees,this,Screen.MOMaterialView);
 
            CollectionInit params_MOResourceTools = new CollectionInit(){IDDescriptor = "5f9f474b-3019-4ceb-98c2-487568223426",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f389d670-55ee-4229-8afc-bb752718dfef",CSSSelectorGrid="",XPathGrid=""};
            MOResourceTools = RPSControlFactory.RPSCreateCollectionWithGrid<MOResourceToolsCollectionEditor<MOTaskView,MOMaterialView>,MOTaskView,MOMaterialView>( params_MOResourceTools,this,Screen.MOMaterialView);
 
            CollectionInit params_MOTaskDimensions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7ab5e6c0-acc6-4503-b66f-a2409c18c141",CSSSelectorGrid="",XPathGrid=""};
            MOTaskDimensions = RPSControlFactory.RPSCreateCollectionWithGrid<MOTaskDimensionsCollectionEditor<MOTaskView,MOMaterialView>,MOTaskView,MOMaterialView>( params_MOTaskDimensions,this,Screen.MOMaterialView);
 
            SectionGeneral = RPSControlFactory.CreateRPSSection<MOTaskView>( "","ul li[rpsid='fc016c7f-5210-4bb3-87c4-b9915c46fc09']","",this);
 
            SectionPlanning = RPSControlFactory.CreateRPSSection<MOTaskView>( "","ul li[rpsid='deab17ca-74d0-46bc-ae55-550713ec9050']","",this);
 
            SectionExternal = RPSControlFactory.CreateRPSSection<MOTaskView>( "","ul li[rpsid='d83fd121-3011-4da6-9694-a8b54515fb98']","",this);
 
            SectionNotes = RPSControlFactory.CreateRPSSection<MOTaskView>( "","ul li[rpsid='6c2874c1-db2c-4bf2-bbeb-199916c36a12']","",this);
 
            SectionBudgetCategory = RPSControlFactory.CreateRPSSection<MOTaskView>( "","ul li[rpsid='fe969455-66ba-42ce-9687-7289b48f9f9b']","",this);
 
            SectionCosts = RPSControlFactory.CreateRPSSection<MOTaskView>( "","ul li[rpsid='f6cb88f8-b4aa-4ed2-910c-f0078d322ea0']","",this);
 
            SectionTaskRelations = RPSControlFactory.CreateRPSSection<MOTaskView>( "","ul li[rpsid='e6e41e62-30a0-4591-bc47-04e86ed40ca3']","",this);
 
            SectionMaterial = RPSControlFactory.CreateRPSSection<MOTaskView>( "","ul li[rpsid='82460da6-c577-467d-a9d2-b7ea4395cf1e']","",this);
 
            SectionCostComponent = RPSControlFactory.CreateRPSSection<MOTaskView>( "","ul li[rpsid='2033611e-af3f-416d-9db8-d906cf0bbceb']","",this);
 
            SectionResourceMachines = RPSControlFactory.CreateRPSSection<MOTaskView>( "","ul li[rpsid='28ea07a0-a418-40ec-9bb5-313548c276e2']","",this);
 
            SectionResourceEmployees = RPSControlFactory.CreateRPSSection<MOTaskView>( "","ul li[rpsid='0cae429b-ea8b-4ce9-acd9-01c49790909c']","",this);
 
            SectionResourceTools = RPSControlFactory.CreateRPSSection<MOTaskView>( "","ul li[rpsid='c0f37ef7-ca16-45e6-b5e8-a4f0a5338a42']","",this);
 
            SectionDimensions = RPSControlFactory.CreateRPSSection<MOTaskView>( "","ul li[rpsid='9be259ac-ae5d-4eee-828c-c6d9641fccd6']","",this);
 

        }
        public IRPSButton<MOTaskView> DeleteButton { get; set; } 
        public IRPSButton<MOTaskView,ManufacturingOrderEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MOTaskView,ManufacturingOrderEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<MOTaskView,ManufacturingOrderEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<MOTaskView> CodMOTask { get; set; } 
        public IRPSTextBox<MOTaskView> Description { get; set; } 
        public IRPSTextBox<MOTaskView> PlannedStartDate { get; set; } 
        public IRPSTextBox<MOTaskView> PlannedStartTime { get; set; } 
        public IRPSTextBox<MOTaskView> PlannedEndDate { get; set; } 
        public IRPSTextBox<MOTaskView> PlannedEndTime { get; set; } 
        public IRPSDurationTextBox<MOTaskView> ExecutionTime { get; set; } 
        public IRPSDurationTextBox<MOTaskView> PreparationTime { get; set; } 
        public IRPSTextBox<MOTaskView> ManualStartDate { get; set; } 
        public IRPSTextBox<MOTaskView> ManualEndDate { get; set; } 
        public IRPSComboBox<MOTaskView> TimeUnit { get; set; } 
        public IRPSTextBox<MOTaskView> WorkUnits { get; set; } 
        public IRPSTextBox<MOTaskView> PercentProgress { get; set; } 
        public IRPSComboBox<MOTaskView> TaskType { get; set; } 
        public IRPSTextBox<MOTaskView> DateReplanify { get; set; } 
        public IRPSTextBox<MOTaskView> RealEndDate { get; set; } 
        public IRPSCheckbox<MOTaskView> Blocked { get; set; } 
        public IRPSCheckbox<MOTaskView> BlockedMaterial { get; set; } 
        public IRPSCheckbox<MOTaskView> BlockedCost { get; set; } 
        public IRPSCheckbox<MOTaskView> LotsOrder { get; set; } 
        public IRPSCheckbox<MOTaskView> ProductEntry { get; set; } 
        public IRPSCheckbox<MOTaskView> MaterialExit { get; set; } 
        public IRPSCheckbox<MOTaskView> PrintLabels { get; set; } 
        public IRPSCheckbox<MOTaskView> AutoExecutionImputation { get; set; } 
        public IRPSCheckbox<MOTaskView> Canceled { get; set; } 
        public IRPSTextBox<MOTaskView> GroupingNumber { get; set; } 
        public IRPSTextBox<MOTaskView> DescGroupOfTask { get; set; } 
        public IRPSComboBox<MOTaskView> UIProductFormula { get; set; } 
        public IRPSTextBox<MOTaskView> UIProductFormulaVersion { get; set; } 
        public IRPSTextBox<MOTaskView> UIProductFormulaDate { get; set; } 
        public IRPSComboBox<MOTaskView> IDMOTaskParent { get; set; } 
        public IRPSComboBox<MOTaskView> IDTaskType { get; set; } 
        public IRPSDurationTextBox<MOTaskView> RepetitionTime { get; set; } 
        public IRPSTextBox<MOTaskView> RepetitionLot { get; set; } 
        public IRPSComboBox<MOTaskView> IDUsualTask { get; set; } 
        public IRPSDurationTextBox<MOTaskView> prepTimeReal { get; set; } 
        public IRPSDurationTextBox<MOTaskView> execTimeReal { get; set; } 
        public IRPSDurationTextBox<MOTaskView> RepetitionTimeReal { get; set; } 
        public IRPSCheckbox<MOTaskView> SeriesRequired { get; set; } 
        public IRPSComboBox<MOTaskView> QualityStatus { get; set; } 
        public IRPSTextBox<MOTaskView> InspectedDate { get; set; } 
        public IRPSComboBox<MOTaskView> IDCheckList { get; set; } 
        public IRPSComboBox<MOTaskView> DelimitationType { get; set; } 
        public IRPSTextBox<MOTaskView> DelimitationDate { get; set; } 
        public IRPSTextBox<MOTaskView> DelimitationHour { get; set; } 
        public IRPSCheckbox<MOTaskView> DelimitationObligatory { get; set; } 
        public IRPSTextBox<MOTaskView> MinimumFraction { get; set; } 
        public IRPSComboBox<MOTaskView> TimeUnit1 { get; set; } 
        public IRPSCheckbox<MOTaskView> ManualPlanning { get; set; } 
        public IRPSCheckbox<MOTaskView> AllowFraccionate { get; set; } 
        public IRPSCheckbox<MOTaskView> Fixed { get; set; } 
        public IRPSCheckbox<MOTaskView> WithoutTimetable { get; set; } 
        public IRPSCheckbox<MOTaskView> ReleaseKeptResources { get; set; } 
        public IRPSTextBox<MOTaskView> OptimizationFeature { get; set; } 
        public IRPSTextBox<MOTaskView> Priority { get; set; } 
        public IRPSTextBox<MOTaskView> Group { get; set; } 
        public IRPSTextBox<MOTaskView> NotOverlapCode { get; set; } 
        public IRPSTextBox<MOTaskView> TiedCode { get; set; } 
        public IRPSCheckbox<MOTaskView> GroupedManufacturing { get; set; } 
        public IRPSComboBox<MOTaskView> ResourcePlanType { get; set; } 
        public IRPSTextBox<MOTaskView> SplitNumber { get; set; } 
        public IRPSComboBox<MOTaskView> OccupancyType { get; set; } 
        public IRPSTextBox<MOTaskView> OccupancyHours { get; set; } 
        public IRPSTextBox<MOTaskView> OccupancyPercent { get; set; } 
        public IRPSCheckbox<MOTaskView> External { get; set; } 
        public IRPSComboBox<MOTaskView> IDArticleExternal { get; set; } 
        public IRPSTextBox<MOTaskView> Quantity { get; set; } 
        public IRPSComboBox<MOTaskView> IDSupplier { get; set; } 
        public IRPSComboBox<MOTaskView> IDBudgetCategory { get; set; } 
        public IRPSComboBox<MOTaskView> IDSiteMaterial { get; set; } 
        public IRPSComboBox<MOTaskView> IDWarehouseMaterial { get; set; } 
        public IRPSCheckbox<MOTaskView> ImputationCostUpdated { get; set; } 
        public IRPSTextBox<MOTaskView> Notes { get; set; } 
        public IRPSComboBox<MOTaskView> IDBudgetEmployee { get; set; } 
        public IRPSComboBox<MOTaskView> IDBudgetMachine { get; set; } 
        public IRPSComboBox<MOTaskView> IDBudgetTool { get; set; } 
        public IRPSComboBox<MOTaskView> IDBudgetMaterial { get; set; } 
        public IRPSComboBox<MOTaskView> IDBudgetOtherCost { get; set; } 
        public IRPSTextBox<MOTaskView> CalcExternalCostTheoric { get; set; } 
        public IRPSTextBox<MOTaskView> CalcLaborCostTheoric { get; set; } 
        public IRPSTextBox<MOTaskView> CalcMaterialCostTheoric { get; set; } 
        public IRPSTextBox<MOTaskView> CalcOtherCostTheoric { get; set; } 
        public IRPSTextBox<MOTaskView> CalcExternalCostReal { get; set; } 
        public IRPSTextBox<MOTaskView> CalcLaborCostReal { get; set; } 
        public IRPSTextBox<MOTaskView> CalcMaterialCostReal { get; set; } 
        public IRPSTextBox<MOTaskView> CalcOtherCostReal { get; set; } 
        public IRPSTextBox<MOTaskView> CalcRealExecutionTime { get; set; } 
        public IRPSTextBox<MOTaskView> CalcRealPreparationTime { get; set; } 
        public IRPSTextBox<MOTaskView> CalcRealTime { get; set; } 
        public IRPSTextBox<MOTaskView> CalcEstimatedTime { get; set; } 
        public IRPSTextBox<MOTaskView> CalcManufacturedQuantity { get; set; } 
        public IRPSTextBox<MOTaskView> CalcPendingTime { get; set; } 
        public IRPSTextBox<MOTaskView> CalcRejectedQuantity { get; set; } 
        public IRPSTextBox<MOTaskView> CalcRejectedQuantityQuality { get; set; } 
        public IRPSButton<MOTaskView> SplitTaskCommandButton { get; set; } 
        public MOTaskRelationsCollectionEditor<MOTaskView,MOMaterialView> MOTaskRelations { get; set; } 
        public MOMaterialsCollectionEditor<MOTaskView,MOMaterialView> MOMaterials { get; set; } 
        public MOTaskCostComponentsCollectionEditor<MOTaskView,MOMaterialView> MOTaskCostComponents { get; set; } 
        public MOResourceMachinesCollectionEditor<MOTaskView,MOMaterialView> MOResourceMachines { get; set; } 
        public MOResourceEmployeesCollectionEditor<MOTaskView,MOMaterialView> MOResourceEmployees { get; set; } 
        public MOResourceToolsCollectionEditor<MOTaskView,MOMaterialView> MOResourceTools { get; set; } 
        public MOTaskDimensionsCollectionEditor<MOTaskView,MOMaterialView> MOTaskDimensions { get; set; } 
        public IRPSSection<MOTaskView> SectionGeneral { get; set; } 
        public IRPSSection<MOTaskView> SectionPlanning { get; set; } 
        public IRPSSection<MOTaskView> SectionExternal { get; set; } 
        public IRPSSection<MOTaskView> SectionNotes { get; set; } 
        public IRPSSection<MOTaskView> SectionBudgetCategory { get; set; } 
        public IRPSSection<MOTaskView> SectionCosts { get; set; } 
        public IRPSSection<MOTaskView> SectionTaskRelations { get; set; } 
        public IRPSSection<MOTaskView> SectionMaterial { get; set; } 
        public IRPSSection<MOTaskView> SectionCostComponent { get; set; } 
        public IRPSSection<MOTaskView> SectionResourceMachines { get; set; } 
        public IRPSSection<MOTaskView> SectionResourceEmployees { get; set; } 
        public IRPSSection<MOTaskView> SectionResourceTools { get; set; } 
        public IRPSSection<MOTaskView> SectionDimensions { get; set; } 
        public ManufacturingOrder Screen { get; set; }
        public MOTaskView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MOTaskRelationsCollectionEditor<MOTaskView,MOMaterialView>:RPSCollectionEditor<MOTaskView,MOMaterialView> where MOTaskView : class, IView where MOMaterialView : class, IView
    {
        public  MOTaskRelationsGridView<MOTaskView,MOMaterialView> GridView {get;set;}
    }
    public partial class MOTaskRelationsGridView <MOTaskView,MOMaterialView> :  RPSGridView<MOTaskView,MOMaterialView> where MOTaskView : class, IView where MOMaterialView : class, IView
    {
        public MOTaskRelationsGridView(MOTaskView currentView,MOMaterialView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDPredecessorMOTask = RPSControlFactory.CreateRPSGridComboBox<MOTaskView>("","#90cdf425-4959-4da5-9f42-a6bc69cd5f41 .ag-row[role='row']@ROWINDEX [col-id='cIDPredecessorMOTask']","",true, this.CurrentView);
 
            RelationType = RPSControlFactory.CreateRPSGridEnumComboBox<MOTaskView>("","#90cdf425-4959-4da5-9f42-a6bc69cd5f41 .ag-row[role='row']@ROWINDEX [col-id='cRelationType']","",true, this.CurrentView);
 
            LagType = RPSControlFactory.CreateRPSGridEnumComboBox<MOTaskView>("","#90cdf425-4959-4da5-9f42-a6bc69cd5f41 .ag-row[role='row']@ROWINDEX [col-id='cLagType']","",true, this.CurrentView);
 
            TimeLag = RPSControlFactory.CreateRPSGridDurationTextBox<MOTaskView>("","#90cdf425-4959-4da5-9f42-a6bc69cd5f41 .ag-row[role='row']@ROWINDEX [col-id='cTimeLag']","",true, this.CurrentView);
 
            UnitsLag = RPSControlFactory.CreateRPSGridFormattedTextBox<MOTaskView>("","#90cdf425-4959-4da5-9f42-a6bc69cd5f41 .ag-row[role='row']@ROWINDEX [col-id='cUnitsLag']","",true, this.CurrentView);
 
            Linked = RPSControlFactory.CreateRPSGridCheckBox<MOTaskView>("","#90cdf425-4959-4da5-9f42-a6bc69cd5f41 .ag-row[role='row']@ROWINDEX [col-id='cLinked']","",true, this.CurrentView);
 
            CalendarType = RPSControlFactory.CreateRPSGridEnumComboBox<MOTaskView>("","#90cdf425-4959-4da5-9f42-a6bc69cd5f41 .ag-row[role='row']@ROWINDEX [col-id='cCalendarType']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<MOTaskView> IDPredecessorMOTask { get; set; } 
        public IRPSGridComboBox<MOTaskView> RelationType { get; set; } 
        public IRPSGridComboBox<MOTaskView> LagType { get; set; } 
        public IRPSGridDurationTextBox<MOTaskView> TimeLag { get; set; } 
        public IRPSGridTextBox<MOTaskView> UnitsLag { get; set; } 
        public IRPSGridCheckbox<MOTaskView> Linked { get; set; } 
        public IRPSGridComboBox<MOTaskView> CalendarType { get; set; } 
                     
    }
 
        public partial class MOMaterialsCollectionEditor<MOTaskView,MOMaterialView>:RPSCollectionEditor<MOTaskView,MOMaterialView> where MOTaskView : class, IView where MOMaterialView : class, IView
    {
        public  MOMaterialsGridView<MOTaskView,MOMaterialView> GridView {get;set;}
    }
    public partial class MOMaterialsGridView <MOTaskView,MOMaterialView> :  RPSGridView<MOTaskView,MOMaterialView> where MOTaskView : class, IView where MOMaterialView : class, IView
    {
        public MOMaterialsGridView(MOTaskView currentView,MOMaterialView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodMOMaterial = RPSControlFactory.CreateRPSGridTextBox<MOTaskView>("","#90da6b45-916f-49eb-b139-9850457748f8 .ag-row[role='row']@ROWINDEX [col-id='cCodMOMaterial']","",true, this.CurrentView);
 
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<MOTaskView>("","#90da6b45-916f-49eb-b139-9850457748f8 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<MOTaskView>("","#90da6b45-916f-49eb-b139-9850457748f8 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<MOTaskView>("","#90da6b45-916f-49eb-b139-9850457748f8 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            QuantityImputed = RPSControlFactory.CreateRPSGridFormattedTextBox<MOTaskView>("","#90da6b45-916f-49eb-b139-9850457748f8 .ag-row[role='row']@ROWINDEX [col-id='cQuantityImputed']","",true, this.CurrentView);
 
            CalcCostTheoric = RPSControlFactory.CreateRPSGridFormattedTextBox<MOTaskView>("","#90da6b45-916f-49eb-b139-9850457748f8 .ag-row[role='row']@ROWINDEX [col-id='cCalcCostTheoric']","",false, this.CurrentView);
 
            CalcCostReal = RPSControlFactory.CreateRPSGridFormattedTextBox<MOTaskView>("","#90da6b45-916f-49eb-b139-9850457748f8 .ag-row[role='row']@ROWINDEX [col-id='cCalcCostReal']","",false, this.CurrentView);
 
            Matchcode = RPSControlFactory.CreateRPSGridTextBox<MOTaskView>("","#90da6b45-916f-49eb-b139-9850457748f8 .ag-row[role='row']@ROWINDEX [col-id='cMatchcode']","",false, this.CurrentView);
 
            IsMandatory = RPSControlFactory.CreateRPSGridCheckBox<MOTaskView>("","#90da6b45-916f-49eb-b139-9850457748f8 .ag-row[role='row']@ROWINDEX [col-id='cIsMandatory']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<MOTaskView> CodMOMaterial { get; set; } 
        public IRPSGridComboBox<MOTaskView> IDArticle { get; set; } 
        public IRPSGridTextBox<MOTaskView> Description { get; set; } 
        public IRPSGridTextBox<MOTaskView> Quantity { get; set; } 
        public IRPSGridTextBox<MOTaskView> QuantityImputed { get; set; } 
        public IRPSGridTextBox<MOTaskView> CalcCostTheoric { get; set; } 
        public IRPSGridTextBox<MOTaskView> CalcCostReal { get; set; } 
        public IRPSGridTextBox<MOTaskView> Matchcode { get; set; } 
        public IRPSGridCheckbox<MOTaskView> IsMandatory { get; set; } 
                     
    }
 
        public partial class MOTaskCostComponentsCollectionEditor<MOTaskView,MOMaterialView>:RPSCollectionEditor<MOTaskView,MOMaterialView> where MOTaskView : class, IView where MOMaterialView : class, IView
    {
        public  MOTaskCostComponentsGridView<MOTaskView,MOMaterialView> GridView {get;set;}
    }
    public partial class MOTaskCostComponentsGridView <MOTaskView,MOMaterialView> :  RPSGridView<MOTaskView,MOMaterialView> where MOTaskView : class, IView where MOMaterialView : class, IView
    {
        public MOTaskCostComponentsGridView(MOTaskView currentView,MOMaterialView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodMOTaskCostComponent = RPSControlFactory.CreateRPSGridTextBox<MOTaskView>("","#b642b7e6-3fac-441e-a783-4410c4cc0bf7 .ag-row[role='row']@ROWINDEX [col-id='cCodMOTaskCostComponent']","",true, this.CurrentView);
 
            IDCostComponent = RPSControlFactory.CreateRPSGridComboBox<MOTaskView>("","#b642b7e6-3fac-441e-a783-4410c4cc0bf7 .ag-row[role='row']@ROWINDEX [col-id='cIDCostComponent']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<MOTaskView>("","#b642b7e6-3fac-441e-a783-4410c4cc0bf7 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<MOTaskView>("","#b642b7e6-3fac-441e-a783-4410c4cc0bf7 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            CalcCostTheoric = RPSControlFactory.CreateRPSGridFormattedTextBox<MOTaskView>("","#b642b7e6-3fac-441e-a783-4410c4cc0bf7 .ag-row[role='row']@ROWINDEX [col-id='cCalcCostTheoric']","",false, this.CurrentView);
 
            CalcCostReal = RPSControlFactory.CreateRPSGridFormattedTextBox<MOTaskView>("","#b642b7e6-3fac-441e-a783-4410c4cc0bf7 .ag-row[role='row']@ROWINDEX [col-id='cCalcCostReal']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MOTaskView> CodMOTaskCostComponent { get; set; } 
        public IRPSGridComboBox<MOTaskView> IDCostComponent { get; set; } 
        public IRPSGridTextBox<MOTaskView> Description { get; set; } 
        public IRPSGridTextBox<MOTaskView> Quantity { get; set; } 
        public IRPSGridTextBox<MOTaskView> CalcCostTheoric { get; set; } 
        public IRPSGridTextBox<MOTaskView> CalcCostReal { get; set; } 
                     
    }
 
        public partial class MOResourceMachinesCollectionEditor<MOTaskView,MOMaterialView>:RPSCollectionEditor<MOTaskView,MOMaterialView> where MOTaskView : class, IView where MOMaterialView : class, IView
    {
        public  MOResourceMachinesGridView<MOTaskView,MOMaterialView> GridView {get;set;}
    }
    public partial class MOResourceMachinesGridView <MOTaskView,MOMaterialView> :  RPSGridView<MOTaskView,MOMaterialView> where MOTaskView : class, IView where MOMaterialView : class, IView
    {
        public MOResourceMachinesGridView(MOTaskView currentView,MOMaterialView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodMOResourceMachine = RPSControlFactory.CreateRPSGridTextBox<MOTaskView>("","#14fa10e0-663a-42ba-93d3-82968ca0fcf1 .ag-row[role='row']@ROWINDEX [col-id='cCodMOResourceMachine']","",true, this.CurrentView);
 
            IDMachine = RPSControlFactory.CreateRPSGridComboBox<MOTaskView>("","#14fa10e0-663a-42ba-93d3-82968ca0fcf1 .ag-row[role='row']@ROWINDEX [col-id='cIDMachine']","",false, this.CurrentView);
 
            IDMachineGroup = RPSControlFactory.CreateRPSGridComboBox<MOTaskView>("","#14fa10e0-663a-42ba-93d3-82968ca0fcf1 .ag-row[role='row']@ROWINDEX [col-id='cIDMachineGroup']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<MOTaskView>("","#14fa10e0-663a-42ba-93d3-82968ca0fcf1 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            ParticipateIn = RPSControlFactory.CreateRPSGridEnumComboBox<MOTaskView>("","#14fa10e0-663a-42ba-93d3-82968ca0fcf1 .ag-row[role='row']@ROWINDEX [col-id='cParticipateIn']","",true, this.CurrentView);
 
            Planify = RPSControlFactory.CreateRPSGridCheckBox<MOTaskView>("","#14fa10e0-663a-42ba-93d3-82968ca0fcf1 .ag-row[role='row']@ROWINDEX [col-id='cPlanify']","",true, this.CurrentView);
 
            DedicationPercent = RPSControlFactory.CreateRPSGridFormattedTextBox<MOTaskView>("","#14fa10e0-663a-42ba-93d3-82968ca0fcf1 .ag-row[role='row']@ROWINDEX [col-id='cDedicationPercent']","",true, this.CurrentView);
 
            CalcCostTheoric = RPSControlFactory.CreateRPSGridFormattedTextBox<MOTaskView>("","#14fa10e0-663a-42ba-93d3-82968ca0fcf1 .ag-row[role='row']@ROWINDEX [col-id='cCalcCostTheoric']","",false, this.CurrentView);
 
            CalcCostReal = RPSControlFactory.CreateRPSGridFormattedTextBox<MOTaskView>("","#14fa10e0-663a-42ba-93d3-82968ca0fcf1 .ag-row[role='row']@ROWINDEX [col-id='cCalcCostReal']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MOTaskView> CodMOResourceMachine { get; set; } 
        public IRPSGridComboBox<MOTaskView> IDMachine { get; set; } 
        public IRPSGridComboBox<MOTaskView> IDMachineGroup { get; set; } 
        public IRPSGridTextBox<MOTaskView> Description { get; set; } 
        public IRPSGridComboBox<MOTaskView> ParticipateIn { get; set; } 
        public IRPSGridCheckbox<MOTaskView> Planify { get; set; } 
        public IRPSGridTextBox<MOTaskView> DedicationPercent { get; set; } 
        public IRPSGridTextBox<MOTaskView> CalcCostTheoric { get; set; } 
        public IRPSGridTextBox<MOTaskView> CalcCostReal { get; set; } 
                     
    }
 
        public partial class MOResourceEmployeesCollectionEditor<MOTaskView,MOMaterialView>:RPSCollectionEditor<MOTaskView,MOMaterialView> where MOTaskView : class, IView where MOMaterialView : class, IView
    {
        public  MOResourceEmployeesGridView<MOTaskView,MOMaterialView> GridView {get;set;}
    }
    public partial class MOResourceEmployeesGridView <MOTaskView,MOMaterialView> :  RPSGridView<MOTaskView,MOMaterialView> where MOTaskView : class, IView where MOMaterialView : class, IView
    {
        public MOResourceEmployeesGridView(MOTaskView currentView,MOMaterialView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodMOResourceEmployee = RPSControlFactory.CreateRPSGridTextBox<MOTaskView>("","#887cfd06-8f94-4b89-b302-e32d8b6ee8ee .ag-row[role='row']@ROWINDEX [col-id='cCodMOResourceEmployee']","",true, this.CurrentView);
 
            IDEmployee = RPSControlFactory.CreateRPSGridComboBox<MOTaskView>("","#887cfd06-8f94-4b89-b302-e32d8b6ee8ee .ag-row[role='row']@ROWINDEX [col-id='cIDEmployee']","",false, this.CurrentView);
 
            IDQualify = RPSControlFactory.CreateRPSGridComboBox<MOTaskView>("","#887cfd06-8f94-4b89-b302-e32d8b6ee8ee .ag-row[role='row']@ROWINDEX [col-id='cIDQualify']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<MOTaskView>("","#887cfd06-8f94-4b89-b302-e32d8b6ee8ee .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            ParticipateIn = RPSControlFactory.CreateRPSGridEnumComboBox<MOTaskView>("","#887cfd06-8f94-4b89-b302-e32d8b6ee8ee .ag-row[role='row']@ROWINDEX [col-id='cParticipateIn']","",true, this.CurrentView);
 
            Planify = RPSControlFactory.CreateRPSGridCheckBox<MOTaskView>("","#887cfd06-8f94-4b89-b302-e32d8b6ee8ee .ag-row[role='row']@ROWINDEX [col-id='cPlanify']","",true, this.CurrentView);
 
            DedicationPercent = RPSControlFactory.CreateRPSGridFormattedTextBox<MOTaskView>("","#887cfd06-8f94-4b89-b302-e32d8b6ee8ee .ag-row[role='row']@ROWINDEX [col-id='cDedicationPercent']","",true, this.CurrentView);
 
            CalcCostTheoric = RPSControlFactory.CreateRPSGridFormattedTextBox<MOTaskView>("","#887cfd06-8f94-4b89-b302-e32d8b6ee8ee .ag-row[role='row']@ROWINDEX [col-id='cCalcCostTheoric']","",false, this.CurrentView);
 
            CalcCostReal = RPSControlFactory.CreateRPSGridFormattedTextBox<MOTaskView>("","#887cfd06-8f94-4b89-b302-e32d8b6ee8ee .ag-row[role='row']@ROWINDEX [col-id='cCalcCostReal']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MOTaskView> CodMOResourceEmployee { get; set; } 
        public IRPSGridComboBox<MOTaskView> IDEmployee { get; set; } 
        public IRPSGridComboBox<MOTaskView> IDQualify { get; set; } 
        public IRPSGridTextBox<MOTaskView> Description { get; set; } 
        public IRPSGridComboBox<MOTaskView> ParticipateIn { get; set; } 
        public IRPSGridCheckbox<MOTaskView> Planify { get; set; } 
        public IRPSGridTextBox<MOTaskView> DedicationPercent { get; set; } 
        public IRPSGridTextBox<MOTaskView> CalcCostTheoric { get; set; } 
        public IRPSGridTextBox<MOTaskView> CalcCostReal { get; set; } 
                     
    }
 
        public partial class MOResourceToolsCollectionEditor<MOTaskView,MOMaterialView>:RPSCollectionEditor<MOTaskView,MOMaterialView> where MOTaskView : class, IView where MOMaterialView : class, IView
    {
        public  MOResourceToolsGridView<MOTaskView,MOMaterialView> GridView {get;set;}
    }
    public partial class MOResourceToolsGridView <MOTaskView,MOMaterialView> :  RPSGridView<MOTaskView,MOMaterialView> where MOTaskView : class, IView where MOMaterialView : class, IView
    {
        public MOResourceToolsGridView(MOTaskView currentView,MOMaterialView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodMOResourceTool = RPSControlFactory.CreateRPSGridTextBox<MOTaskView>("","#f389d670-55ee-4229-8afc-bb752718dfef .ag-row[role='row']@ROWINDEX [col-id='cCodMOResourceTool']","",true, this.CurrentView);
 
            IDTool = RPSControlFactory.CreateRPSGridComboBox<MOTaskView>("","#f389d670-55ee-4229-8afc-bb752718dfef .ag-row[role='row']@ROWINDEX [col-id='cIDTool']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<MOTaskView>("","#f389d670-55ee-4229-8afc-bb752718dfef .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            ParticipateIn = RPSControlFactory.CreateRPSGridEnumComboBox<MOTaskView>("","#f389d670-55ee-4229-8afc-bb752718dfef .ag-row[role='row']@ROWINDEX [col-id='cParticipateIn']","",true, this.CurrentView);
 
            Planify = RPSControlFactory.CreateRPSGridCheckBox<MOTaskView>("","#f389d670-55ee-4229-8afc-bb752718dfef .ag-row[role='row']@ROWINDEX [col-id='cPlanify']","",false, this.CurrentView);
 
            DedicationPercent = RPSControlFactory.CreateRPSGridFormattedTextBox<MOTaskView>("","#f389d670-55ee-4229-8afc-bb752718dfef .ag-row[role='row']@ROWINDEX [col-id='cDedicationPercent']","",true, this.CurrentView);
 
            CalcCostTheoric = RPSControlFactory.CreateRPSGridFormattedTextBox<MOTaskView>("","#f389d670-55ee-4229-8afc-bb752718dfef .ag-row[role='row']@ROWINDEX [col-id='cCalcCostTheoric']","",false, this.CurrentView);
 
            CalcCostReal = RPSControlFactory.CreateRPSGridFormattedTextBox<MOTaskView>("","#f389d670-55ee-4229-8afc-bb752718dfef .ag-row[role='row']@ROWINDEX [col-id='cCalcCostReal']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MOTaskView> CodMOResourceTool { get; set; } 
        public IRPSGridComboBox<MOTaskView> IDTool { get; set; } 
        public IRPSGridTextBox<MOTaskView> Description { get; set; } 
        public IRPSGridComboBox<MOTaskView> ParticipateIn { get; set; } 
        public IRPSGridCheckbox<MOTaskView> Planify { get; set; } 
        public IRPSGridTextBox<MOTaskView> DedicationPercent { get; set; } 
        public IRPSGridTextBox<MOTaskView> CalcCostTheoric { get; set; } 
        public IRPSGridTextBox<MOTaskView> CalcCostReal { get; set; } 
                     
    }
 
        public partial class MOTaskDimensionsCollectionEditor<MOTaskView,MOMaterialView>:RPSCollectionEditor<MOTaskView,MOMaterialView> where MOTaskView : class, IView where MOMaterialView : class, IView
    {
        public  MOTaskDimensionsGridView<MOTaskView,MOMaterialView> GridView {get;set;}
    }
    public partial class MOTaskDimensionsGridView <MOTaskView,MOMaterialView> :  RPSGridView<MOTaskView,MOMaterialView> where MOTaskView : class, IView where MOMaterialView : class, IView
    {
        public MOTaskDimensionsGridView(MOTaskView currentView,MOMaterialView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDDimension = RPSControlFactory.CreateRPSGridComboBox<MOTaskView>("","#7ab5e6c0-acc6-4503-b66f-a2409c18c141 .ag-row[role='row']@ROWINDEX [col-id='cIDDimension']","",true, this.CurrentView);
 
            IDDimValue = RPSControlFactory.CreateRPSGridComboBox<MOTaskView>("","#7ab5e6c0-acc6-4503-b66f-a2409c18c141 .ag-row[role='row']@ROWINDEX [col-id='cIDDimValue']","",false, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<MOTaskView>("","#7ab5e6c0-acc6-4503-b66f-a2409c18c141 .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<MOTaskView> IDDimension { get; set; } 
        public IRPSGridComboBox<MOTaskView> IDDimValue { get; set; } 
        public IRPSGridTextBox<MOTaskView> Percentage { get; set; } 
                     
    }
 
    }
  
            
    public partial class MOTaskRelationView : View
    {
        public MOTaskRelationView(ManufacturingOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MOTaskRelationView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MOTaskRelationView,MOTaskView>( this,Screen.MOTaskView);
 
            BackButton = RPSControlFactory.RPSBackButton<MOTaskRelationView,MOTaskView>( this,Screen.MOTaskView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MOTaskRelationView,MOTaskView>( this,Screen.MOTaskView);
 
            IDPredecessorMOTask = RPSControlFactory.CreateRPSComboBox<MOTaskRelationView>("4f6e607a-6e74-4a35-b862-3cf7f64e73e3","","",true, this);
 
            RelationType = RPSControlFactory.CreateRPSEnumComboBox<MOTaskRelationView>("679b68ee-1817-44ee-840f-41967bc4cbab","","",true, this);
 
            LagType = RPSControlFactory.CreateRPSEnumComboBox<MOTaskRelationView>("ecbb5826-9751-48cd-b1ac-d79f04cff764","","",true, this);
 
            TimeLag = RPSControlFactory.CreateRPSDurationTextBox<MOTaskRelationView>("5060977f-8072-443a-9cdd-15bb2d4d83e1","","",true, this);
 
            CalendarType = RPSControlFactory.CreateRPSEnumComboBox<MOTaskRelationView>("8beba3ef-1d89-4d59-9d8b-5a3dacc3608c","","",true, this);
 
            UnitsLag = RPSControlFactory.CreateRPSFormattedTextBox<MOTaskRelationView>("c68121f8-0fcf-4007-8591-72ed59139b94","","",true, this);
 
            Linked = RPSControlFactory.CreateRPSCheckBox<MOTaskRelationView>("666be10b-39a8-4eb3-b23f-af8c6760c2a3","","",true, this);
 

        }
        public IRPSButton<MOTaskRelationView> DeleteButton { get; set; } 
        public IRPSButton<MOTaskRelationView,MOTaskView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MOTaskRelationView,MOTaskView> BackButton { get; set; } 
        public IRPSAcceptButton<MOTaskRelationView,MOTaskView> AcceptButton { get; set; } 
        public IRPSComboBox<MOTaskRelationView> IDPredecessorMOTask { get; set; } 
        public IRPSComboBox<MOTaskRelationView> RelationType { get; set; } 
        public IRPSComboBox<MOTaskRelationView> LagType { get; set; } 
        public IRPSDurationTextBox<MOTaskRelationView> TimeLag { get; set; } 
        public IRPSComboBox<MOTaskRelationView> CalendarType { get; set; } 
        public IRPSTextBox<MOTaskRelationView> UnitsLag { get; set; } 
        public IRPSCheckbox<MOTaskRelationView> Linked { get; set; } 
        public ManufacturingOrder Screen { get; set; }
        public MOTaskRelationView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MOTaskDimensionView : View
    {
        public MOTaskDimensionView(ManufacturingOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MOTaskDimensionView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MOTaskDimensionView,MOTaskView>( this,Screen.MOTaskView);
 
            BackButton = RPSControlFactory.RPSBackButton<MOTaskDimensionView,MOTaskView>( this,Screen.MOTaskView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MOTaskDimensionView,MOTaskView>( this,Screen.MOTaskView);
 
            IDDimension = RPSControlFactory.CreateRPSComboBox<MOTaskDimensionView>("c1e3dcdd-d0fd-4fe2-99a6-e313957ab46d","","",true, this);
 
            IDDimValue = RPSControlFactory.CreateRPSComboBox<MOTaskDimensionView>("34ac7cb6-540f-4031-84e7-ce0ebd5b025a","","",false, this);
 
            Percentage = RPSControlFactory.CreateRPSFormattedTextBox<MOTaskDimensionView>("ce98b128-0249-4a05-88f3-94303ce0ed4a","","",true, this);
 

        }
        public IRPSButton<MOTaskDimensionView> DeleteButton { get; set; } 
        public IRPSButton<MOTaskDimensionView,MOTaskView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MOTaskDimensionView,MOTaskView> BackButton { get; set; } 
        public IRPSAcceptButton<MOTaskDimensionView,MOTaskView> AcceptButton { get; set; } 
        public IRPSComboBox<MOTaskDimensionView> IDDimension { get; set; } 
        public IRPSComboBox<MOTaskDimensionView> IDDimValue { get; set; } 
        public IRPSTextBox<MOTaskDimensionView> Percentage { get; set; } 
        public ManufacturingOrder Screen { get; set; }
        public MOTaskDimensionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MOResourceEmployeeView : View
    {
        public MOResourceEmployeeView(ManufacturingOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MOResourceEmployeeView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MOResourceEmployeeView,MOTaskView>( this,Screen.MOTaskView);
 
            BackButton = RPSControlFactory.RPSBackButton<MOResourceEmployeeView,MOTaskView>( this,Screen.MOTaskView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MOResourceEmployeeView,MOTaskView>( this,Screen.MOTaskView);
 
            CodMOResourceEmployee = RPSControlFactory.CreateRPSTextBox<MOResourceEmployeeView>("5edacf13-25fa-4623-bd90-1e1e0737c273","","",true, this);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<MOResourceEmployeeView>("de89a645-27d7-4c85-9064-5cabdbf7708c","","",false, this);
 
            IDQualify = RPSControlFactory.CreateRPSComboBox<MOResourceEmployeeView>("e628feb6-f909-4d74-9f51-edd29c4212c7","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MOResourceEmployeeView>("e88834b0-857d-4e2b-9341-666f3fa6ce19","","",false, this);
 
            ParticipateIn = RPSControlFactory.CreateRPSEnumComboBox<MOResourceEmployeeView>("ac595ceb-8eaf-4d29-81d6-09189583f802","","",true, this);
 
            DedicationPercent = RPSControlFactory.CreateRPSFormattedTextBox<MOResourceEmployeeView>("aad2069c-d410-4aa6-9b14-fb094ac295ed","","",true, this);
 
            VariableEmployee = RPSControlFactory.CreateRPSCheckBox<MOResourceEmployeeView>("a20803f7-4893-479f-9fb7-d75ce282d320","","",true, this);
 
            Planify = RPSControlFactory.CreateRPSCheckBox<MOResourceEmployeeView>("7d4f461c-7dd7-47f3-a904-3199f47ce866","","",true, this);
 
            Duration = RPSControlFactory.CreateRPSDurationTextBox<MOResourceEmployeeView>("5568b847-783b-42ae-9163-c986936f6de2","","",true, this);
 
            TimeUnit = RPSControlFactory.CreateRPSEnumComboBox<MOResourceEmployeeView>("769bdb29-0cca-4c0f-aeb6-85e2f9690e00","","",true, this);
 
            IDBudgetCategory = RPSControlFactory.CreateRPSComboBox<MOResourceEmployeeView>("deba1422-33fc-4ae7-b81d-e17072731ff9","","",false, this);
 
            CalcRealTimeUnproductive = RPSControlFactory.CreateRPSFormattedTextBox<MOResourceEmployeeView>("ce5055ba-08d6-46be-9928-4c6a3dd2335d","","",false, this);
 
            CalcRealTime = RPSControlFactory.CreateRPSFormattedTextBox<MOResourceEmployeeView>("0836240c-b469-4b5a-b86b-2c0e4dc48778","","",false, this);
 
            CalcEstimatedTime = RPSControlFactory.CreateRPSFormattedTextBox<MOResourceEmployeeView>("3208824c-640c-4f9e-8795-5e66c1d659b8","","",false, this);
 
            CalcCostTheoric = RPSControlFactory.CreateRPSFormattedTextBox<MOResourceEmployeeView>("f8961e16-336b-43b9-b8e8-cfa0a7fa4ea8","","",false, this);
 
            CalcCostReal = RPSControlFactory.CreateRPSFormattedTextBox<MOResourceEmployeeView>("36b6d5f3-9d9e-4eb4-8be9-5a1305b72f2b","","",false, this);
 

        }
        public IRPSButton<MOResourceEmployeeView> DeleteButton { get; set; } 
        public IRPSButton<MOResourceEmployeeView,MOTaskView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MOResourceEmployeeView,MOTaskView> BackButton { get; set; } 
        public IRPSAcceptButton<MOResourceEmployeeView,MOTaskView> AcceptButton { get; set; } 
        public IRPSTextBox<MOResourceEmployeeView> CodMOResourceEmployee { get; set; } 
        public IRPSComboBox<MOResourceEmployeeView> IDEmployee { get; set; } 
        public IRPSComboBox<MOResourceEmployeeView> IDQualify { get; set; } 
        public IRPSTextBox<MOResourceEmployeeView> Description { get; set; } 
        public IRPSComboBox<MOResourceEmployeeView> ParticipateIn { get; set; } 
        public IRPSTextBox<MOResourceEmployeeView> DedicationPercent { get; set; } 
        public IRPSCheckbox<MOResourceEmployeeView> VariableEmployee { get; set; } 
        public IRPSCheckbox<MOResourceEmployeeView> Planify { get; set; } 
        public IRPSDurationTextBox<MOResourceEmployeeView> Duration { get; set; } 
        public IRPSComboBox<MOResourceEmployeeView> TimeUnit { get; set; } 
        public IRPSComboBox<MOResourceEmployeeView> IDBudgetCategory { get; set; } 
        public IRPSTextBox<MOResourceEmployeeView> CalcRealTimeUnproductive { get; set; } 
        public IRPSTextBox<MOResourceEmployeeView> CalcRealTime { get; set; } 
        public IRPSTextBox<MOResourceEmployeeView> CalcEstimatedTime { get; set; } 
        public IRPSTextBox<MOResourceEmployeeView> CalcCostTheoric { get; set; } 
        public IRPSTextBox<MOResourceEmployeeView> CalcCostReal { get; set; } 
        public ManufacturingOrder Screen { get; set; }
        public MOResourceEmployeeView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MOResourceMachineView : View
    {
        public MOResourceMachineView(ManufacturingOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MOResourceMachineView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MOResourceMachineView,MOTaskView>( this,Screen.MOTaskView);
 
            BackButton = RPSControlFactory.RPSBackButton<MOResourceMachineView,MOTaskView>( this,Screen.MOTaskView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MOResourceMachineView,MOTaskView>( this,Screen.MOTaskView);
 
            CodMOResourceMachine = RPSControlFactory.CreateRPSTextBox<MOResourceMachineView>("f031ca4d-0be3-4df1-af05-03bf060e5111","","",true, this);
 
            IDMachine = RPSControlFactory.CreateRPSComboBox<MOResourceMachineView>("fd73b825-8ff3-4cc1-a2d6-1c57a43d5751","","",false, this);
 
            IDMachineGroup = RPSControlFactory.CreateRPSComboBox<MOResourceMachineView>("425705fd-4d2d-4ae3-8499-006fc091a484","","",false, this);
 
            IDMOResourceEmployee = RPSControlFactory.CreateRPSComboBox<MOResourceMachineView>("c1957bde-547a-49c0-8578-0d9fb0ffc6c7","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MOResourceMachineView>("1a68ec61-6151-44f0-af33-49bb940ef99c","","",false, this);
 
            ParticipateIn = RPSControlFactory.CreateRPSEnumComboBox<MOResourceMachineView>("1a0cc046-7526-4d2c-95bc-df38e44384c7","","",true, this);
 
            DedicationPercent = RPSControlFactory.CreateRPSFormattedTextBox<MOResourceMachineView>("19a93f7b-9c46-4a9c-87a8-13eda94b3847","","",true, this);
 
            VariableGroup = RPSControlFactory.CreateRPSCheckBox<MOResourceMachineView>("069f2128-1118-44c7-abe4-974343f36b11","","",true, this);
 
            Planify = RPSControlFactory.CreateRPSCheckBox<MOResourceMachineView>("512af689-696f-40fb-824c-23363a15d371","","",true, this);
 
            Duration = RPSControlFactory.CreateRPSFormattedTextBox<MOResourceMachineView>("0b551570-eaba-4f36-9614-02e82f289167","","",true, this);
 
            TimeUnit = RPSControlFactory.CreateRPSEnumComboBox<MOResourceMachineView>("d4fc02cc-f3be-4b61-a835-fa0ae1eb273a","","",true, this);
 
            IDBudgetCategory = RPSControlFactory.CreateRPSComboBox<MOResourceMachineView>("b0074fef-eb7e-4cf8-a0d1-9b0493b1b07f","","",false, this);
 
            CalcCostReal = RPSControlFactory.CreateRPSFormattedTextBox<MOResourceMachineView>("ac05d69a-5b47-46c3-9bc4-6ac187df0e97","","",false, this);
 
            CalcCostTheoric = RPSControlFactory.CreateRPSFormattedTextBox<MOResourceMachineView>("5c7141a6-7f77-41c9-8d90-7367e897f582","","",false, this);
 
            CalcEstimatedTime = RPSControlFactory.CreateRPSFormattedTextBox<MOResourceMachineView>("0d6db692-ab53-41f6-959b-6b34b1f0d2be","","",false, this);
 
            CalcRealTime = RPSControlFactory.CreateRPSFormattedTextBox<MOResourceMachineView>("5588fdc5-b661-488d-a544-16323e0dd6d2","","",false, this);
 
            CalcRealTimeUnproductive = RPSControlFactory.CreateRPSFormattedTextBox<MOResourceMachineView>("f13f31e1-a216-4f97-a8e7-6bf5827ba990","","",false, this);
 
            CostQuantity = RPSControlFactory.CreateRPSFormattedTextBox<MOResourceMachineView>("3d166f4a-2b6f-4e6e-8603-5d453612e883","","",true, this);
 
            AddGroupMachinesCommandButton = RPSControlFactory.CreateRPSButton<MOResourceMachineView>( "390261ed-069b-4b1d-99e7-f0fbff862b4d","","",this);
 
            CollectionInit params_MOResourceMachineAlts = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8d5df10b-1e18-4795-a5d5-f8da2058990a",CSSSelectorGrid="",XPathGrid=""};
            MOResourceMachineAlts = RPSControlFactory.RPSCreateCollectionWithGrid<MOResourceMachineAltsCollectionEditor<MOResourceMachineView>,MOResourceMachineView>( params_MOResourceMachineAlts,this);
 

        }
        public IRPSButton<MOResourceMachineView> DeleteButton { get; set; } 
        public IRPSButton<MOResourceMachineView,MOTaskView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MOResourceMachineView,MOTaskView> BackButton { get; set; } 
        public IRPSAcceptButton<MOResourceMachineView,MOTaskView> AcceptButton { get; set; } 
        public IRPSTextBox<MOResourceMachineView> CodMOResourceMachine { get; set; } 
        public IRPSComboBox<MOResourceMachineView> IDMachine { get; set; } 
        public IRPSComboBox<MOResourceMachineView> IDMachineGroup { get; set; } 
        public IRPSComboBox<MOResourceMachineView> IDMOResourceEmployee { get; set; } 
        public IRPSTextBox<MOResourceMachineView> Description { get; set; } 
        public IRPSComboBox<MOResourceMachineView> ParticipateIn { get; set; } 
        public IRPSTextBox<MOResourceMachineView> DedicationPercent { get; set; } 
        public IRPSCheckbox<MOResourceMachineView> VariableGroup { get; set; } 
        public IRPSCheckbox<MOResourceMachineView> Planify { get; set; } 
        public IRPSTextBox<MOResourceMachineView> Duration { get; set; } 
        public IRPSComboBox<MOResourceMachineView> TimeUnit { get; set; } 
        public IRPSComboBox<MOResourceMachineView> IDBudgetCategory { get; set; } 
        public IRPSTextBox<MOResourceMachineView> CalcCostReal { get; set; } 
        public IRPSTextBox<MOResourceMachineView> CalcCostTheoric { get; set; } 
        public IRPSTextBox<MOResourceMachineView> CalcEstimatedTime { get; set; } 
        public IRPSTextBox<MOResourceMachineView> CalcRealTime { get; set; } 
        public IRPSTextBox<MOResourceMachineView> CalcRealTimeUnproductive { get; set; } 
        public IRPSTextBox<MOResourceMachineView> CostQuantity { get; set; } 
        public IRPSButton<MOResourceMachineView> AddGroupMachinesCommandButton { get; set; } 
        public MOResourceMachineAltsCollectionEditor<MOResourceMachineView> MOResourceMachineAlts { get; set; } 
        public ManufacturingOrder Screen { get; set; }
        public MOResourceMachineView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MOResourceMachineAltsCollectionEditor<MOResourceMachineView>:RPSCollectionEditor<MOResourceMachineView> where MOResourceMachineView : class, IView
    {
        public  MOResourceMachineAltsGridView<MOResourceMachineView> GridView {get;set;}
    }
    public partial class MOResourceMachineAltsGridView <MOResourceMachineView> :  RPSGridView<MOResourceMachineView> where MOResourceMachineView : class, IView
    {
        public MOResourceMachineAltsGridView(MOResourceMachineView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDMachine = RPSControlFactory.CreateRPSGridComboBox<MOResourceMachineView>("","#8d5df10b-1e18-4795-a5d5-f8da2058990a .ag-row[role='row']@ROWINDEX [col-id='cIDMachine']","",true, this.CurrentView);
 
            PreparationTime = RPSControlFactory.CreateRPSGridDurationTextBox<MOResourceMachineView>("","#8d5df10b-1e18-4795-a5d5-f8da2058990a .ag-row[role='row']@ROWINDEX [col-id='cPreparationTime']","",true, this.CurrentView);
 
            ExecutionTime = RPSControlFactory.CreateRPSGridDurationTextBox<MOResourceMachineView>("","#8d5df10b-1e18-4795-a5d5-f8da2058990a .ag-row[role='row']@ROWINDEX [col-id='cExecutionTime']","",true, this.CurrentView);
 
            RepetitionTime = RPSControlFactory.CreateRPSGridDurationTextBox<MOResourceMachineView>("","#8d5df10b-1e18-4795-a5d5-f8da2058990a .ag-row[role='row']@ROWINDEX [col-id='cRepetitionTime']","",true, this.CurrentView);
 
            RepetitionLot = RPSControlFactory.CreateRPSGridFormattedTextBox<MOResourceMachineView>("","#8d5df10b-1e18-4795-a5d5-f8da2058990a .ag-row[role='row']@ROWINDEX [col-id='cRepetitionLot']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<MOResourceMachineView> IDMachine { get; set; } 
        public IRPSGridDurationTextBox<MOResourceMachineView> PreparationTime { get; set; } 
        public IRPSGridDurationTextBox<MOResourceMachineView> ExecutionTime { get; set; } 
        public IRPSGridDurationTextBox<MOResourceMachineView> RepetitionTime { get; set; } 
        public IRPSGridTextBox<MOResourceMachineView> RepetitionLot { get; set; } 
                     
    }
 
    }
  
            
    public partial class MOResourceToolView : View
    {
        public MOResourceToolView(ManufacturingOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MOResourceToolView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MOResourceToolView,MOTaskView>( this,Screen.MOTaskView);
 
            BackButton = RPSControlFactory.RPSBackButton<MOResourceToolView,MOTaskView>( this,Screen.MOTaskView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MOResourceToolView,MOTaskView>( this,Screen.MOTaskView);
 
            CodMOResourceTool = RPSControlFactory.CreateRPSTextBox<MOResourceToolView>("1306e678-7352-4cb5-8e62-a392dbb49ef3","","",true, this);
 
            IDTool = RPSControlFactory.CreateRPSComboBox<MOResourceToolView>("deaf5bbd-096f-4029-9075-9083f219b629","","",true, this);
 
            IDMOResourceEmployee = RPSControlFactory.CreateRPSComboBox<MOResourceToolView>("30af0ecc-1da6-44af-b374-dc9083df9878","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MOResourceToolView>("3b5eed1a-f049-48e2-be3a-75315748bae6","","",false, this);
 
            ParticipateIn = RPSControlFactory.CreateRPSEnumComboBox<MOResourceToolView>("04b13c6b-37d9-4dfa-924b-e0cd54c180a0","","",true, this);
 
            DedicationPercent = RPSControlFactory.CreateRPSFormattedTextBox<MOResourceToolView>("f54d6d2f-40ef-418f-b718-7f26a95ac67f","","",true, this);
 
            Planify = RPSControlFactory.CreateRPSCheckBox<MOResourceToolView>("59464abf-3e2f-4b91-bc7d-1e59d4b91161","","",false, this);
 
            Duration = RPSControlFactory.CreateRPSDurationTextBox<MOResourceToolView>("3e1d6641-c936-4029-aeb1-e66c9620a8b4","","",true, this);
 
            TimeUnit = RPSControlFactory.CreateRPSEnumComboBox<MOResourceToolView>("266a2d51-79ab-445c-a449-3e13c378638e","","",true, this);
 
            IDBudgetCategory = RPSControlFactory.CreateRPSComboBox<MOResourceToolView>("3ba1f929-30ba-439d-9aa4-6a11de872b47","","",false, this);
 
            CalcRealTimeUnproductive = RPSControlFactory.CreateRPSFormattedTextBox<MOResourceToolView>("6504ca23-8857-41ca-82bf-3dc593df8b7d","","",false, this);
 
            CalcRealTime = RPSControlFactory.CreateRPSFormattedTextBox<MOResourceToolView>("1c0afe2d-f760-4194-8f9e-e17dd93652ee","","",false, this);
 
            CalcEstimatedTime = RPSControlFactory.CreateRPSFormattedTextBox<MOResourceToolView>("5f5a4b20-e5b7-4f81-aeda-a1c51f1cd273","","",false, this);
 
            CalcCostTheoric = RPSControlFactory.CreateRPSFormattedTextBox<MOResourceToolView>("0930820e-2f3b-4758-916d-e5fd2edc16a1","","",false, this);
 
            CalcCostReal = RPSControlFactory.CreateRPSFormattedTextBox<MOResourceToolView>("99caf749-1a9d-4fd0-9cab-ffeb3b34afb7","","",false, this);
 

        }
        public IRPSButton<MOResourceToolView> DeleteButton { get; set; } 
        public IRPSButton<MOResourceToolView,MOTaskView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MOResourceToolView,MOTaskView> BackButton { get; set; } 
        public IRPSAcceptButton<MOResourceToolView,MOTaskView> AcceptButton { get; set; } 
        public IRPSTextBox<MOResourceToolView> CodMOResourceTool { get; set; } 
        public IRPSComboBox<MOResourceToolView> IDTool { get; set; } 
        public IRPSComboBox<MOResourceToolView> IDMOResourceEmployee { get; set; } 
        public IRPSTextBox<MOResourceToolView> Description { get; set; } 
        public IRPSComboBox<MOResourceToolView> ParticipateIn { get; set; } 
        public IRPSTextBox<MOResourceToolView> DedicationPercent { get; set; } 
        public IRPSCheckbox<MOResourceToolView> Planify { get; set; } 
        public IRPSDurationTextBox<MOResourceToolView> Duration { get; set; } 
        public IRPSComboBox<MOResourceToolView> TimeUnit { get; set; } 
        public IRPSComboBox<MOResourceToolView> IDBudgetCategory { get; set; } 
        public IRPSTextBox<MOResourceToolView> CalcRealTimeUnproductive { get; set; } 
        public IRPSTextBox<MOResourceToolView> CalcRealTime { get; set; } 
        public IRPSTextBox<MOResourceToolView> CalcEstimatedTime { get; set; } 
        public IRPSTextBox<MOResourceToolView> CalcCostTheoric { get; set; } 
        public IRPSTextBox<MOResourceToolView> CalcCostReal { get; set; } 
        public ManufacturingOrder Screen { get; set; }
        public MOResourceToolView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MOTaskCostComponentView : View
    {
        public MOTaskCostComponentView(ManufacturingOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MOTaskCostComponentView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MOTaskCostComponentView,MOTaskView>( this,Screen.MOTaskView);
 
            BackButton = RPSControlFactory.RPSBackButton<MOTaskCostComponentView,MOTaskView>( this,Screen.MOTaskView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MOTaskCostComponentView,MOTaskView>( this,Screen.MOTaskView);
 
            CodMOTaskCostComponent = RPSControlFactory.CreateRPSTextBox<MOTaskCostComponentView>("f42a1a00-a945-4a39-9d87-725f08d4ed43","","",true, this);
 
            IDCostComponent = RPSControlFactory.CreateRPSComboBox<MOTaskCostComponentView>("60b8695c-cb88-43b3-a229-ab0c511f61ae","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MOTaskCostComponentView>("48033396-bdff-4154-9ae6-c6db1dca5e18","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<MOTaskCostComponentView>("57f0c351-512f-4780-bfe3-cbf07189d7ff","","",true, this);
 
            Price = RPSControlFactory.CreateRPSFormattedTextBox<MOTaskCostComponentView>("9d7460ce-4b3e-49ec-a7f7-5e332249a0d8","","",true, this);
 
            IDBudgetCategory = RPSControlFactory.CreateRPSComboBox<MOTaskCostComponentView>("88c71b3d-2bfb-45ca-884a-9349ea892bbc","","",false, this);
 
            CalcCostReal = RPSControlFactory.CreateRPSFormattedTextBox<MOTaskCostComponentView>("e8e15f6e-3f55-4305-83a8-ce3f9f1a42a8","","",false, this);
 
            CalcCostTheoric = RPSControlFactory.CreateRPSFormattedTextBox<MOTaskCostComponentView>("77a3cc26-1411-4612-967c-6962c83ee18e","","",false, this);
 

        }
        public IRPSButton<MOTaskCostComponentView> DeleteButton { get; set; } 
        public IRPSButton<MOTaskCostComponentView,MOTaskView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MOTaskCostComponentView,MOTaskView> BackButton { get; set; } 
        public IRPSAcceptButton<MOTaskCostComponentView,MOTaskView> AcceptButton { get; set; } 
        public IRPSTextBox<MOTaskCostComponentView> CodMOTaskCostComponent { get; set; } 
        public IRPSComboBox<MOTaskCostComponentView> IDCostComponent { get; set; } 
        public IRPSTextBox<MOTaskCostComponentView> Description { get; set; } 
        public IRPSTextBox<MOTaskCostComponentView> Quantity { get; set; } 
        public IRPSTextBox<MOTaskCostComponentView> Price { get; set; } 
        public IRPSComboBox<MOTaskCostComponentView> IDBudgetCategory { get; set; } 
        public IRPSTextBox<MOTaskCostComponentView> CalcCostReal { get; set; } 
        public IRPSTextBox<MOTaskCostComponentView> CalcCostTheoric { get; set; } 
        public ManufacturingOrder Screen { get; set; }
        public MOTaskCostComponentView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MOMaterialView : View
    {
        public MOMaterialView(ManufacturingOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MOMaterialView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MOMaterialView,MOTaskView>( this,Screen.MOTaskView);
 
            BackButton = RPSControlFactory.RPSBackButton<MOMaterialView,MOTaskView>( this,Screen.MOTaskView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MOMaterialView,MOTaskView>( this,Screen.MOTaskView);
 
            CodMOMaterial = RPSControlFactory.CreateRPSTextBox<MOMaterialView>("95f4bffc-2837-45e8-b295-42ca277c16ab","","",true, this);
 
            Status = RPSControlFactory.CreateRPSEnumComboBox<MOMaterialView>("d1436bec-ac59-4033-8bf6-f57a083402ae","","",true, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<MOMaterialView>("0c26c132-cf9d-4047-a151-fa6767fec9bd","","",true, this);
 
            ArticleType = RPSControlFactory.CreateRPSEnumComboBox<MOMaterialView>("3661fc1e-fde2-4b60-a9ff-5ec098b38ed3","","",true, this);
 
            UIArticleType = RPSControlFactory.CreateRPSEnumComboBox<MOMaterialView>("0a820710-a7cd-4891-8c76-6f10cf534f1f","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MOMaterialView>("cf7b4fb8-09bd-4a7c-b6e1-70cfd31e2c1b","","",false, this);
 
            QuantityElements = RPSControlFactory.CreateRPSFormattedTextBox<MOMaterialView>("57d7dc8a-9a7a-4b6e-8396-e816fc978722","","",true, this);
 
            MaterialType = RPSControlFactory.CreateRPSEnumComboBox<MOMaterialView>("1e757825-8528-4d47-863a-f81b23d642a8","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<MOMaterialView>("d9f781a5-6e1d-4655-9fb7-9417f2a0a3d3","","",true, this);
 
            QuantityImputed = RPSControlFactory.CreateRPSFormattedTextBox<MOMaterialView>("479654c1-ddeb-40a2-8587-46b9618a8374","","",true, this);
 
            Completed = RPSControlFactory.CreateRPSCheckBox<MOMaterialView>("92d578f6-80aa-4ec4-bcb5-d00380231398","","",true, this);
 
            AdvanceDays = RPSControlFactory.CreateRPSFormattedTextBox<MOMaterialView>("fb63fe4a-ed0c-4775-9cd0-df63f5aeb268","","",true, this);
 
            Critical = RPSControlFactory.CreateRPSCheckBox<MOMaterialView>("ba625e01-1a2f-4640-9c8a-9456fb03817d","","",true, this);
 
            ManualConsumption = RPSControlFactory.CreateRPSCheckBox<MOMaterialView>("b9b88870-3b92-46e2-aa8b-36cb9f2ffe72","","",true, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<MOMaterialView>("9f182945-3b3f-46c7-8a6a-f99904b99243","","",true, this);
 
            IDWareHouse = RPSControlFactory.CreateRPSComboBox<MOMaterialView>("390bfd25-f541-490b-adf0-c68f11c74063","","",false, this);
 
            MakeAutomaticOutput = RPSControlFactory.CreateRPSCheckBox<MOMaterialView>("954e3a9f-d68d-4ca4-8373-3cb4d1c25a2f","","",true, this);
 
            FixedQuantity = RPSControlFactory.CreateRPSCheckBox<MOMaterialView>("bcec41a9-f3c4-40ab-9c28-27b0ae967d33","","",true, this);
 
            Alternative = RPSControlFactory.CreateRPSCheckBox<MOMaterialView>("6d41ae26-03ea-4775-b125-f06c0f52c4ff","","",true, this);
 
            Potency = RPSControlFactory.CreateRPSFormattedTextBox<MOMaterialView>("0db69422-c484-40c3-bf3d-3323dcedf367","","",true, this);
 
            ImputationCostUpdated = RPSControlFactory.CreateRPSCheckBox<MOMaterialView>("31a61294-bb23-42f0-bd45-6014bf27381c","","",true, this);
 
            IDBudgetCategory = RPSControlFactory.CreateRPSComboBox<MOMaterialView>("fb5f1490-d95b-4e5f-8401-10d6845ce0bf","","",false, this);
 
            IDCompensatedMaterial = RPSControlFactory.CreateRPSComboBox<MOMaterialView>("29d80439-97b0-4520-9bf0-2e299e430ff5","","",false, this);
 
            CompensatingFactor = RPSControlFactory.CreateRPSFormattedTextBox<MOMaterialView>("aaa91ae4-9b6f-49ba-8680-21728725e528","","",true, this);
 
            IDProductFormula = RPSControlFactory.CreateRPSComboBox<MOMaterialView>("c07f8d56-09a2-427a-b547-2c9b4dd6e495","","",false, this);
 
            Order = RPSControlFactory.CreateRPSFormattedTextBox<MOMaterialView>("a3adf35c-36b0-4540-a4c9-8adecec29a9c","","",true, this);
 
            IDArticleFictitious = RPSControlFactory.CreateRPSComboBox<MOMaterialView>("dd4aeb8a-e08f-4c3f-9cd0-977736bec4ba","","",false, this);
 
            CalcCostReal = RPSControlFactory.CreateRPSFormattedTextBox<MOMaterialView>("e576c396-0444-439f-9916-afbe6d29d909","","",false, this);
 
            CalcCostTheoric = RPSControlFactory.CreateRPSFormattedTextBox<MOMaterialView>("bb8b27ea-d3d9-4974-83b3-ce6f4622d35f","","",false, this);
 
            CalcTheoricQuantityActive = RPSControlFactory.CreateRPSFormattedTextBox<MOMaterialView>("e88cf2bf-ae60-428b-b56c-64c3427209d8","","",false, this);
 
            CalcRealQuantityActive = RPSControlFactory.CreateRPSFormattedTextBox<MOMaterialView>("5dab5666-fe41-45c5-bec7-232414461c3a","","",false, this);
 
            CalcQuantitySecondUnitReal = RPSControlFactory.CreateRPSFormattedTextBox<MOMaterialView>("ea96be8d-2509-4265-8d92-e2da33f84e5b","","",false, this);
 
            CalcQuantityReal = RPSControlFactory.CreateRPSFormattedTextBox<MOMaterialView>("b5f93080-1831-4fa6-bf14-05b2eb10a5f9","","",false, this);
 
            Notes = RPSControlFactory.CreateRPSTextBox<MOMaterialView>("1f45471a-1633-4c5d-a9a5-61267bbc7626","","",false, this);
 
            Matchcode = RPSControlFactory.CreateRPSTextBox<MOMaterialView>("0d6204d9-d83a-4fc0-988e-6bcabea4286c","","",false, this);
 
            IsMandatory = RPSControlFactory.CreateRPSCheckBox<MOMaterialView>("61c37b78-ce19-4017-b641-1320d877db69","","",true, this);
 
            MOMaterialChangeStatusNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<MOMaterialView,MOMaterialChangeStatusDialogView>("8749c1d2-ba64-4891-a8b7-2fe3d7172ee5","","", this,Screen.MOMaterialChangeStatusDialogView);
 
            SectionGeneral = RPSControlFactory.CreateRPSSection<MOMaterialView>( "","ul li[rpsid='f19a7913-b037-4c96-9ffe-337cdf18fbcb']","",this);
 
            SectionNotes = RPSControlFactory.CreateRPSSection<MOMaterialView>( "","ul li[rpsid='1b2a14af-8d54-418d-aacc-0a7235cec8a5']","",this);
 
            SectionDPS = RPSControlFactory.CreateRPSSection<MOMaterialView>( "","ul li[rpsid='e6654817-0615-4f50-abc9-6aae48196637']","",this);
 

        }
        public IRPSButton<MOMaterialView> DeleteButton { get; set; } 
        public IRPSButton<MOMaterialView,MOTaskView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MOMaterialView,MOTaskView> BackButton { get; set; } 
        public IRPSAcceptButton<MOMaterialView,MOTaskView> AcceptButton { get; set; } 
        public IRPSTextBox<MOMaterialView> CodMOMaterial { get; set; } 
        public IRPSComboBox<MOMaterialView> Status { get; set; } 
        public IRPSComboBox<MOMaterialView> IDArticle { get; set; } 
        public IRPSComboBox<MOMaterialView> ArticleType { get; set; } 
        public IRPSComboBox<MOMaterialView> UIArticleType { get; set; } 
        public IRPSTextBox<MOMaterialView> Description { get; set; } 
        public IRPSTextBox<MOMaterialView> QuantityElements { get; set; } 
        public IRPSComboBox<MOMaterialView> MaterialType { get; set; } 
        public IRPSTextBox<MOMaterialView> Quantity { get; set; } 
        public IRPSTextBox<MOMaterialView> QuantityImputed { get; set; } 
        public IRPSCheckbox<MOMaterialView> Completed { get; set; } 
        public IRPSTextBox<MOMaterialView> AdvanceDays { get; set; } 
        public IRPSCheckbox<MOMaterialView> Critical { get; set; } 
        public IRPSCheckbox<MOMaterialView> ManualConsumption { get; set; } 
        public IRPSComboBox<MOMaterialView> IDSite { get; set; } 
        public IRPSComboBox<MOMaterialView> IDWareHouse { get; set; } 
        public IRPSCheckbox<MOMaterialView> MakeAutomaticOutput { get; set; } 
        public IRPSCheckbox<MOMaterialView> FixedQuantity { get; set; } 
        public IRPSCheckbox<MOMaterialView> Alternative { get; set; } 
        public IRPSTextBox<MOMaterialView> Potency { get; set; } 
        public IRPSCheckbox<MOMaterialView> ImputationCostUpdated { get; set; } 
        public IRPSComboBox<MOMaterialView> IDBudgetCategory { get; set; } 
        public IRPSComboBox<MOMaterialView> IDCompensatedMaterial { get; set; } 
        public IRPSTextBox<MOMaterialView> CompensatingFactor { get; set; } 
        public IRPSComboBox<MOMaterialView> IDProductFormula { get; set; } 
        public IRPSTextBox<MOMaterialView> Order { get; set; } 
        public IRPSComboBox<MOMaterialView> IDArticleFictitious { get; set; } 
        public IRPSTextBox<MOMaterialView> CalcCostReal { get; set; } 
        public IRPSTextBox<MOMaterialView> CalcCostTheoric { get; set; } 
        public IRPSTextBox<MOMaterialView> CalcTheoricQuantityActive { get; set; } 
        public IRPSTextBox<MOMaterialView> CalcRealQuantityActive { get; set; } 
        public IRPSTextBox<MOMaterialView> CalcQuantitySecondUnitReal { get; set; } 
        public IRPSTextBox<MOMaterialView> CalcQuantityReal { get; set; } 
        public IRPSTextBox<MOMaterialView> Notes { get; set; } 
        public IRPSTextBox<MOMaterialView> Matchcode { get; set; } 
        public IRPSCheckbox<MOMaterialView> IsMandatory { get; set; } 
        public IRPSButton<MOMaterialView,MOMaterialChangeStatusDialogView> MOMaterialChangeStatusNavigationCommandButton { get; set; } 
        public IRPSSection<MOMaterialView> SectionGeneral { get; set; } 
        public IRPSSection<MOMaterialView> SectionNotes { get; set; } 
        public IRPSSection<MOMaterialView> SectionDPS { get; set; } 
        public ManufacturingOrder Screen { get; set; }
        public MOMaterialView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class AddUsualTaskDialogView : View
    {
        public AddUsualTaskDialogView(ManufacturingOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIIDUsualTaskSTR = RPSControlFactory.CreateRPSComboBox<AddUsualTaskDialogView>("fab7a3e1-6772-45eb-a5b5-1378fdbd8909","","",false, this);
 

        }
        public IRPSComboBox<AddUsualTaskDialogView> UIIDUsualTaskSTR { get; set; } 
        public ManufacturingOrder Screen { get; set; }
        public AddUsualTaskDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NewMODialogView : View
    {
        public NewMODialogView(ManufacturingOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UISite = RPSControlFactory.CreateRPSComboBox<NewMODialogView>("9b82f466-6e7d-467c-a2c6-98940031323d","","",false, this);
 
            UICodMO = RPSControlFactory.CreateRPSTextBox<NewMODialogView>("e195b6bf-9b94-4582-8c01-14f3ce6d925c","","",false, this);
 
            UIArticle = RPSControlFactory.CreateRPSComboBox<NewMODialogView>("6f417889-0475-4dd5-8f83-896dd0c5c735","","",false, this);
 
            UIRoute = RPSControlFactory.CreateRPSComboBox<NewMODialogView>("46b72c9d-c5fc-4c6a-be62-572d4bd2b3cd","","",false, this);
 
            UIQuantity = RPSControlFactory.CreateRPSFormattedTextBox<NewMODialogView>("1de998c6-5bb0-445e-b9ea-2b943cf13eca","","",false, this);
 
            UIInternalCode = RPSControlFactory.CreateRPSTextBox<NewMODialogView>("107f9006-518d-4b2e-a5a2-0b6f4a87ec64","","",false, this);
 
            ePlanningDirection = RPSControlFactory.CreateRPSEnumComboBox<NewMODialogView>("8e31dba3-08f2-4f84-809b-5f1bf4b1002b","","",false, this);
 
            UIPlannedDate = RPSControlFactory.CreateRPSTextBox<NewMODialogView>("54d6f907-efd3-4ecd-8aec-d59d6f8b10ea","","",false, this);
 
            UIOptActiveVersion = RPSControlFactory.CreateRPSOption<NewMODialogView>( "339dc7ea-6e67-4651-bc19-892af4c9f720","","",this);
 
            UIOptSelectedVersion = RPSControlFactory.CreateRPSOption<NewMODialogView>( "b1e5007e-7cad-4426-9e28-9f99aec7c846","","",this);
 
            UIStructureVersion = RPSControlFactory.CreateRPSComboBox<NewMODialogView>("ffd371ba-dc2f-413b-bd88-6975e90113d8","","",false, this);
 
            UIArticleVersion = RPSControlFactory.CreateRPSComboBox<NewMODialogView>("f17e93f3-7609-415a-9e98-b9f182281923","","",false, this);
 
            UICreateMOMaterials = RPSControlFactory.CreateRPSCheckBox<NewMODialogView>("267b5714-e6a7-41de-86bd-8a8dfb198d48","","",false, this);
 
            UICreateProposalMaterials = RPSControlFactory.CreateRPSCheckBox<NewMODialogView>("9a34a2bd-33b5-486a-9bb0-a98bfadae029","","",false, this);
 

        }
        public IRPSComboBox<NewMODialogView> UISite { get; set; } 
        public IRPSTextBox<NewMODialogView> UICodMO { get; set; } 
        public IRPSComboBox<NewMODialogView> UIArticle { get; set; } 
        public IRPSComboBox<NewMODialogView> UIRoute { get; set; } 
        public IRPSTextBox<NewMODialogView> UIQuantity { get; set; } 
        public IRPSTextBox<NewMODialogView> UIInternalCode { get; set; } 
        public IRPSComboBox<NewMODialogView> ePlanningDirection { get; set; } 
        public IRPSTextBox<NewMODialogView> UIPlannedDate { get; set; } 
        public IRPSOption<NewMODialogView> UIOptActiveVersion { get; set; } 
        public IRPSOption<NewMODialogView> UIOptSelectedVersion { get; set; } 
        public IRPSComboBox<NewMODialogView> UIStructureVersion { get; set; } 
        public IRPSComboBox<NewMODialogView> UIArticleVersion { get; set; } 
        public IRPSCheckbox<NewMODialogView> UICreateMOMaterials { get; set; } 
        public IRPSCheckbox<NewMODialogView> UICreateProposalMaterials { get; set; } 
        public ManufacturingOrder Screen { get; set; }
        public NewMODialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ChangeSiteDialogView : View
    {
        public ChangeSiteDialogView(ManufacturingOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UISite = RPSControlFactory.CreateRPSComboBox<ChangeSiteDialogView>("8d44b95c-88e2-4f12-9fea-8c3177d3824c","","",false, this);
 

        }
        public IRPSComboBox<ChangeSiteDialogView> UISite { get; set; } 
        public ManufacturingOrder Screen { get; set; }
        public ChangeSiteDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ChangeRouteDialogView : View
    {
        public ChangeRouteDialogView(ManufacturingOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIRoute = RPSControlFactory.CreateRPSComboBox<ChangeRouteDialogView>("0498ae24-b698-4546-ae5d-f3382603216c","","",false, this);
 

        }
        public IRPSComboBox<ChangeRouteDialogView> UIRoute { get; set; } 
        public ManufacturingOrder Screen { get; set; }
        public ChangeRouteDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MainManufacturingOrderDialogView : View
    {
        public MainManufacturingOrderDialogView(ManufacturingOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_GetMainManufacturingOrder = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="196eeb5c-e562-4462-a269-70bfa37615cb",CSSSelectorGrid="",XPathGrid=""};
            GetMainManufacturingOrder = RPSControlFactory.RPSCreateCollectionWithGrid<GetMainManufacturingOrderCollectionEditor<MainManufacturingOrderDialogView>,MainManufacturingOrderDialogView>( params_GetMainManufacturingOrder,this);
 

        }
        public GetMainManufacturingOrderCollectionEditor<MainManufacturingOrderDialogView> GetMainManufacturingOrder { get; set; } 
        public ManufacturingOrder Screen { get; set; }
        public MainManufacturingOrderDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetMainManufacturingOrderCollectionEditor<MainManufacturingOrderDialogView>:RPSCollectionEditor<MainManufacturingOrderDialogView> where MainManufacturingOrderDialogView : class, IView
    {
        public  GetMainManufacturingOrderGridView<MainManufacturingOrderDialogView> GridView {get;set;}
    }
    public partial class GetMainManufacturingOrderGridView <MainManufacturingOrderDialogView> :  RPSGridView<MainManufacturingOrderDialogView> where MainManufacturingOrderDialogView : class, IView
    {
        public GetMainManufacturingOrderGridView(MainManufacturingOrderDialogView currentView)
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
  
            
    public partial class SecondaryManufacturingOrderDialogView : View
    {
        public SecondaryManufacturingOrderDialogView(ManufacturingOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_GetSecondaryManufacturingOrder = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="fe40f975-6c31-4c46-94cf-8f870111aff9",CSSSelectorGrid="",XPathGrid=""};
            GetSecondaryManufacturingOrder = RPSControlFactory.RPSCreateCollectionWithGrid<GetSecondaryManufacturingOrderCollectionEditor<SecondaryManufacturingOrderDialogView>,SecondaryManufacturingOrderDialogView>( params_GetSecondaryManufacturingOrder,this);
 

        }
        public GetSecondaryManufacturingOrderCollectionEditor<SecondaryManufacturingOrderDialogView> GetSecondaryManufacturingOrder { get; set; } 
        public ManufacturingOrder Screen { get; set; }
        public SecondaryManufacturingOrderDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetSecondaryManufacturingOrderCollectionEditor<SecondaryManufacturingOrderDialogView>:RPSCollectionEditor<SecondaryManufacturingOrderDialogView> where SecondaryManufacturingOrderDialogView : class, IView
    {
        public  GetSecondaryManufacturingOrderGridView<SecondaryManufacturingOrderDialogView> GridView {get;set;}
    }
    public partial class GetSecondaryManufacturingOrderGridView <SecondaryManufacturingOrderDialogView> :  RPSGridView<SecondaryManufacturingOrderDialogView> where SecondaryManufacturingOrderDialogView : class, IView
    {
        public GetSecondaryManufacturingOrderGridView(SecondaryManufacturingOrderDialogView currentView)
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
  
            
    public partial class EndProductInputDialogView : View
    {
        public EndProductInputDialogView(ManufacturingOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDManufacturingOrder = RPSControlFactory.CreateRPSComboBox<EndProductInputDialogView>("5fc6bea3-74c1-456a-ba50-b651b4a57276","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<EndProductInputDialogView>("e8202e74-5552-494e-9fd7-85e672d1c332","","",false, this);
 
            UIQuantity = RPSControlFactory.CreateRPSFormattedTextBox<EndProductInputDialogView>("c5348951-73e6-4dea-a32e-3eb2f5a36f31","","",false, this);
 
            UIQuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<EndProductInputDialogView>("b5748fb0-eb65-49dc-a452-573beb8f1610","","",false, this);
 
            UIPotencyDefault = RPSControlFactory.CreateRPSFormattedTextBox<EndProductInputDialogView>("890ce02b-4b03-4f0c-80a6-836ae490f86e","","",false, this);
 
            UIWareHouse = RPSControlFactory.CreateRPSComboBox<EndProductInputDialogView>("9679132b-82e9-4302-8af7-73469c61ecb9","","",false, this);
 
            UISeries = RPSControlFactory.CreateRPSEnumComboBox<EndProductInputDialogView>("5b2b6c1b-73e5-467e-a387-dd52f20dbabb","","",false, this);
 
            ExecuteCreateNewMOSeriesReserve = RPSControlFactory.CreateRPSButton<EndProductInputDialogView>( "1e5b601c-20e6-4795-a0d4-91e9773df9ae","","",this);
 
            UIPrice = RPSControlFactory.CreateRPSFormattedTextBox<EndProductInputDialogView>("efc2e962-9b97-4e2d-84f2-78065c809f5f","","",false, this);
 
            UILocationWarehouse = RPSControlFactory.CreateRPSComboBox<EndProductInputDialogView>("2e31436b-17d5-46da-99db-673ba9bdb165","","",false, this);
 
            UIDateOfExpiry = RPSControlFactory.CreateRPSTextBox<EndProductInputDialogView>("72fdce97-b6ca-4b02-8f5a-5efd2c692e38","","",false, this);
 
            UIDate = RPSControlFactory.CreateRPSTextBox<EndProductInputDialogView>("276ef848-6354-42a6-86b3-441143e887c9","","",false, this);
 
            UIDocumentNumber = RPSControlFactory.CreateRPSTextBox<EndProductInputDialogView>("4f35dc57-fe80-48fa-b00d-660f72bab299","","",false, this);
 

        }
        public IRPSComboBox<EndProductInputDialogView> IDManufacturingOrder { get; set; } 
        public IRPSComboBox<EndProductInputDialogView> IDArticle { get; set; } 
        public IRPSTextBox<EndProductInputDialogView> UIQuantity { get; set; } 
        public IRPSTextBox<EndProductInputDialogView> UIQuantitySecondUnit { get; set; } 
        public IRPSTextBox<EndProductInputDialogView> UIPotencyDefault { get; set; } 
        public IRPSComboBox<EndProductInputDialogView> UIWareHouse { get; set; } 
        public IRPSComboBox<EndProductInputDialogView> UISeries { get; set; } 
        public IRPSButton<EndProductInputDialogView> ExecuteCreateNewMOSeriesReserve { get; set; } 
        public IRPSTextBox<EndProductInputDialogView> UIPrice { get; set; } 
        public IRPSComboBox<EndProductInputDialogView> UILocationWarehouse { get; set; } 
        public IRPSTextBox<EndProductInputDialogView> UIDateOfExpiry { get; set; } 
        public IRPSTextBox<EndProductInputDialogView> UIDate { get; set; } 
        public IRPSTextBox<EndProductInputDialogView> UIDocumentNumber { get; set; } 
        public ManufacturingOrder Screen { get; set; }
        public EndProductInputDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MOMaterialChangeStatusDialogView : View
    {
        public MOMaterialChangeStatusDialogView(ManufacturingOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIStatus = RPSControlFactory.CreateRPSEnumComboBox<MOMaterialChangeStatusDialogView>("9f5b9b05-808f-4a4f-a26e-2dd16e8af71f","","",false, this);
 
            UIComment = RPSControlFactory.CreateRPSTextBox<MOMaterialChangeStatusDialogView>("268fa3be-8a58-4bae-9e68-eb958c885121","","",false, this);
 

        }
        public IRPSComboBox<MOMaterialChangeStatusDialogView> UIStatus { get; set; } 
        public IRPSTextBox<MOMaterialChangeStatusDialogView> UIComment { get; set; } 
        public ManufacturingOrder Screen { get; set; }
        public MOMaterialChangeStatusDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MOPlanningDateDialogView : View
    {
        public MOPlanningDateDialogView(ManufacturingOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            PlannedStartDate = RPSControlFactory.CreateRPSTextBox<MOPlanningDateDialogView>("79138c92-9ca9-4417-b350-58edbc52abb2","","",true, this);
 

        }
        public IRPSTextBox<MOPlanningDateDialogView> PlannedStartDate { get; set; } 
        public ManufacturingOrder Screen { get; set; }
        public MOPlanningDateDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ChangeSituationMODV : View
    {
        public ChangeSituationMODV(ManufacturingOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Situation = RPSControlFactory.CreateRPSComboBox<ChangeSituationMODV>("7df13c89-df62-4f2c-a49f-c0512804bd45","","",false, this);
 

        }
        public IRPSComboBox<ChangeSituationMODV> Situation { get; set; } 
        public ManufacturingOrder Screen { get; set; }
        public ChangeSituationMODV Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PrintDocumentationDV : View
    {
        public PrintDocumentationDV(ManufacturingOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            RoadMap = RPSControlFactory.CreateRPSCheckBox<PrintDocumentationDV>("bfe2b3dd-bf70-4f9d-9eb2-f3faa64a1643","","",false, this);
 
            WorkSheet = RPSControlFactory.CreateRPSCheckBox<PrintDocumentationDV>("377e6407-b3eb-4c45-befb-127f96cceb67","","",false, this);
 
            SheetEnd = RPSControlFactory.CreateRPSCheckBox<PrintDocumentationDV>("8489fbff-8f69-4a75-a9bc-e6f09af8f5e1","","",false, this);
 
            TicketMaterial = RPSControlFactory.CreateRPSCheckBox<PrintDocumentationDV>("ca717f4a-9d50-4727-a117-c411dd759d19","","",false, this);
 
            EntryMaterial = RPSControlFactory.CreateRPSCheckBox<PrintDocumentationDV>("7984487c-5a17-4b4c-a9ff-1d0d850b18f7","","",false, this);
 
            Labels = RPSControlFactory.CreateRPSCheckBox<PrintDocumentationDV>("0eb4db88-3485-4a9c-bc91-f6c0b83062b3","","",false, this);
 
            ControlSheetVersion = RPSControlFactory.CreateRPSCheckBox<PrintDocumentationDV>("e00cb4d3-bc4c-4a3a-8ce4-f1dccf79db78","","",false, this);
 
            TextMap = RPSControlFactory.CreateRPSCheckBox<PrintDocumentationDV>("70afd82c-b80c-4ba0-b595-2069bd40fd62","","",false, this);
 
            bManufacturedProduct = RPSControlFactory.CreateRPSCheckBox<PrintDocumentationDV>("7ea24ebb-6337-44e2-aa8e-58c2aadcfbe4","","",false, this);
 
            bMaterials = RPSControlFactory.CreateRPSCheckBox<PrintDocumentationDV>("b2c5c8bf-77fa-4aff-992c-5a2b282cc9cb","","",false, this);
 
            bTasks = RPSControlFactory.CreateRPSCheckBox<PrintDocumentationDV>("ce9d5b1b-cc72-4bf5-8427-5a1fba0de9d4","","",false, this);
 
            Manufactured_Product = RPSControlFactory.CreateRPSEnumComboBox<PrintDocumentationDV>("8bfb0826-3dde-492b-a555-639a8e85c752","","",false, this);
 
            Materials = RPSControlFactory.CreateRPSEnumComboBox<PrintDocumentationDV>("6bbfb2d5-1a5f-44ca-8dca-932067799ee7","","",false, this);
 
            CompressDocuments = RPSControlFactory.CreateRPSCheckBox<PrintDocumentationDV>("40885636-43d0-49fa-8a93-620e3187fc16","","",false, this);
 

        }
        public IRPSCheckbox<PrintDocumentationDV> RoadMap { get; set; } 
        public IRPSCheckbox<PrintDocumentationDV> WorkSheet { get; set; } 
        public IRPSCheckbox<PrintDocumentationDV> SheetEnd { get; set; } 
        public IRPSCheckbox<PrintDocumentationDV> TicketMaterial { get; set; } 
        public IRPSCheckbox<PrintDocumentationDV> EntryMaterial { get; set; } 
        public IRPSCheckbox<PrintDocumentationDV> Labels { get; set; } 
        public IRPSCheckbox<PrintDocumentationDV> ControlSheetVersion { get; set; } 
        public IRPSCheckbox<PrintDocumentationDV> TextMap { get; set; } 
        public IRPSCheckbox<PrintDocumentationDV> bManufacturedProduct { get; set; } 
        public IRPSCheckbox<PrintDocumentationDV> bMaterials { get; set; } 
        public IRPSCheckbox<PrintDocumentationDV> bTasks { get; set; } 
        public IRPSComboBox<PrintDocumentationDV> Manufactured_Product { get; set; } 
        public IRPSComboBox<PrintDocumentationDV> Materials { get; set; } 
        public IRPSCheckbox<PrintDocumentationDV> CompressDocuments { get; set; } 
        public ManufacturingOrder Screen { get; set; }
        public PrintDocumentationDV Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}