    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.Structure
{
    //RPS VERSION 1.0.0.0
    public partial class Structure:Screen
    {
        public Structure():base()
        {
            this.URL = "manufacturing.structure";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            StructureCollectionView  = new StructureCollectionView(this); 
            StructureEntityView  = new StructureEntityView(this); 
            TaskView  = new TaskView(this); 
            TaskRelationView  = new TaskRelationView(this); 
            TaskRouteView  = new TaskRouteView(this); 
            StructureFeatureView  = new StructureFeatureView(this); 
            StructureDimensionView  = new StructureDimensionView(this); 
            ResourceMachineView  = new ResourceMachineView(this); 
            ResourceEmployeeView  = new ResourceEmployeeView(this); 
            ResourceToolView  = new ResourceToolView(this); 
            MaterialView  = new MaterialView(this); 
            MaterialAlternativeView  = new MaterialAlternativeView(this); 
            TaskCostComponentView  = new TaskCostComponentView(this); 
            TaskDimensionView  = new TaskDimensionView(this); 
            StructureRoutesView  = new StructureRoutesView(this); 
            StructureDetailView  = new StructureDetailView(this); 
            DuplicateStructureDialogView  = new DuplicateStructureDialogView(this); 
            NewVersionStructureDialogView  = new NewVersionStructureDialogView(this); 
            ArticlesWithoutStructureDialogView  = new ArticlesWithoutStructureDialogView(this); 
            AddUsualTaskDialogView  = new AddUsualTaskDialogView(this); 
            AddStructureRouteDialogView  = new AddStructureRouteDialogView(this); 
            CopyStructureRouteDialogView  = new CopyStructureRouteDialogView(this); 
            DeleteStructureRouteDialogView  = new DeleteStructureRouteDialogView(this); 
            SubStructureView  = new SubStructureView(this); 
            SubTaskView  = new SubTaskView(this); 
            SubMaterialView  = new SubMaterialView(this); 
            StructureFormulaDV  = new StructureFormulaDV(this); 
            StructureCollectionView.InitializeControls(); 
            StructureEntityView.InitializeControls(); 
            TaskView.InitializeControls(); 
            TaskRelationView.InitializeControls(); 
            TaskRouteView.InitializeControls(); 
            StructureFeatureView.InitializeControls(); 
            StructureDimensionView.InitializeControls(); 
            ResourceMachineView.InitializeControls(); 
            ResourceEmployeeView.InitializeControls(); 
            ResourceToolView.InitializeControls(); 
            MaterialView.InitializeControls(); 
            MaterialAlternativeView.InitializeControls(); 
            TaskCostComponentView.InitializeControls(); 
            TaskDimensionView.InitializeControls(); 
            StructureRoutesView.InitializeControls(); 
            StructureDetailView.InitializeControls(); 
            DuplicateStructureDialogView.InitializeControls(); 
            NewVersionStructureDialogView.InitializeControls(); 
            ArticlesWithoutStructureDialogView.InitializeControls(); 
            AddUsualTaskDialogView.InitializeControls(); 
            AddStructureRouteDialogView.InitializeControls(); 
            CopyStructureRouteDialogView.InitializeControls(); 
            DeleteStructureRouteDialogView.InitializeControls(); 
            SubStructureView.InitializeControls(); 
            SubTaskView.InitializeControls(); 
            SubMaterialView.InitializeControls(); 
            StructureFormulaDV.InitializeControls(); 
           
        }
      
            public StructureCollectionView StructureCollectionView {get; set; } 
            public StructureEntityView StructureEntityView {get; set; } 
            public TaskView TaskView {get; set; } 
            public TaskRelationView TaskRelationView {get; set; } 
            public TaskRouteView TaskRouteView {get; set; } 
            public StructureFeatureView StructureFeatureView {get; set; } 
            public StructureDimensionView StructureDimensionView {get; set; } 
            public ResourceMachineView ResourceMachineView {get; set; } 
            public ResourceEmployeeView ResourceEmployeeView {get; set; } 
            public ResourceToolView ResourceToolView {get; set; } 
            public MaterialView MaterialView {get; set; } 
            public MaterialAlternativeView MaterialAlternativeView {get; set; } 
            public TaskCostComponentView TaskCostComponentView {get; set; } 
            public TaskDimensionView TaskDimensionView {get; set; } 
            public StructureRoutesView StructureRoutesView {get; set; } 
            public StructureDetailView StructureDetailView {get; set; } 
            public DuplicateStructureDialogView DuplicateStructureDialogView {get; set; } 
            public NewVersionStructureDialogView NewVersionStructureDialogView {get; set; } 
            public ArticlesWithoutStructureDialogView ArticlesWithoutStructureDialogView {get; set; } 
            public AddUsualTaskDialogView AddUsualTaskDialogView {get; set; } 
            public AddStructureRouteDialogView AddStructureRouteDialogView {get; set; } 
            public CopyStructureRouteDialogView CopyStructureRouteDialogView {get; set; } 
            public DeleteStructureRouteDialogView DeleteStructureRouteDialogView {get; set; } 
            public SubStructureView SubStructureView {get; set; } 
            public SubTaskView SubTaskView {get; set; } 
            public SubMaterialView SubMaterialView {get; set; } 
            public StructureFormulaDV StructureFormulaDV {get; set; } 
    }
            
    public partial class StructureCollectionView : View
    {
        public StructureCollectionView(Structure screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<StructureCollectionView,StructureEntityView>( this,Screen.StructureEntityView);
 
            DuplicateStructureNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<StructureCollectionView,DuplicateStructureDialogView>("c3624cfe-533a-4878-841d-7421a4d6b50c","","", this,Screen.DuplicateStructureDialogView);
 
            ArticlesWithoutStructureNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<StructureCollectionView,ArticlesWithoutStructureDialogView>("43634df2-ebae-4304-a0b2-3cd8b2dd7a10","","", this,Screen.ArticlesWithoutStructureDialogView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "c791015f-082f-45ef-a548-40646d24a990",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<StructureCollectionView,StructureEntityView>( params_MainConsult,this,Screen.StructureEntityView);
 

        }
        public IRPSButton<StructureCollectionView,StructureEntityView> NewButton { get; set; } 
        public IRPSButton<StructureCollectionView,DuplicateStructureDialogView> DuplicateStructureNavigationCommandButton { get; set; } 
        public IRPSButton<StructureCollectionView,ArticlesWithoutStructureDialogView> ArticlesWithoutStructureNavigationCommandButton { get; set; } 
        public IRPSCollectionEditor<StructureCollectionView,StructureEntityView> MainConsult { get; set; } 
        public Structure Screen { get; set; }
        public StructureCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class StructureEntityView : View
    {
        public StructureEntityView(Structure screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<StructureEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<StructureEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<StructureEntityView,StructureCollectionView>( this,Screen.StructureCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<StructureEntityView,StructureCollectionView>( this,Screen.StructureCollectionView);
 
            ReportCommandButton = RPSControlFactory.CreateRPSButton<StructureEntityView>( "9c4d0c0f-a6de-4694-bf4e-ba27cb980a3c","","",this);
 
            NewVersionStructureNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<StructureEntityView,NewVersionStructureDialogView>("be5cff2c-9040-4171-ab11-69bebcb0f733","","", this,Screen.NewVersionStructureDialogView);
 
            ExecuteGenerateTaskRelationsButton = RPSControlFactory.CreateRPSButton<StructureEntityView>( "41cad3ec-e6e1-444a-ae34-efbc434fe3c0","","",this);
 
            ExecuteRecodeTasksButton = RPSControlFactory.CreateRPSButton<StructureEntityView>( "29dd68b2-15ac-4d15-a7db-eba195ab2424","","",this);
 
            AddUsualTaskNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<StructureEntityView,AddUsualTaskDialogView>("02301ec4-472d-4fba-8835-402a3847e213","","", this,Screen.AddUsualTaskDialogView);
 

        }
        public IRPSSaveButton<StructureEntityView> SaveButton { get; set; } 
        public IRPSButton<StructureEntityView> DeleteButton { get; set; } 
        public IRPSButton<StructureEntityView,StructureCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<StructureEntityView,StructureCollectionView> BackButton { get; set; } 
        public IRPSButton<StructureEntityView> ReportCommandButton { get; set; } 
        public IRPSButton<StructureEntityView,NewVersionStructureDialogView> NewVersionStructureNavigationCommandButton { get; set; } 
        public IRPSButton<StructureEntityView> ExecuteGenerateTaskRelationsButton { get; set; } 
        public IRPSButton<StructureEntityView> ExecuteRecodeTasksButton { get; set; } 
        public IRPSButton<StructureEntityView,AddUsualTaskDialogView> AddUsualTaskNavigationCommandButton { get; set; } 
        public Structure Screen { get; set; }
        public StructureEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class TaskView : View
    {
        public TaskView(Structure screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<TaskView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<TaskView,StructureEntityView>( this,Screen.StructureEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<TaskView,StructureEntityView>( this,Screen.StructureEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<TaskView,StructureEntityView>( this,Screen.StructureEntityView);
 
            CodTask = RPSControlFactory.CreateRPSTextBox<TaskView>("e644b5e5-4eb7-45e2-8ce7-44ad263f39b9","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<TaskView>("e058ea27-15e8-490c-97d2-942ffb152f43","","",false, this);
 
            TaskType = RPSControlFactory.CreateRPSEnumComboBox<TaskView>("8e7147dd-ee89-45a9-bbba-053a1db8192c","","",true, this);
 
            PreparationTime = RPSControlFactory.CreateRPSDurationTextBox<TaskView>("71f233a6-7fd0-4247-9c6d-9ed630f7fb81","","",true, this);
 
            ExecutionTime = RPSControlFactory.CreateRPSDurationTextBox<TaskView>("50560876-1459-4bd7-a020-d01a228bf44d","","",true, this);
 
            TimeUnit = RPSControlFactory.CreateRPSEnumComboBox<TaskView>("0901b976-0c51-400c-8ad0-65e47389d3d7","","",true, this);
 
            ExecutionLot = RPSControlFactory.CreateRPSFormattedTextBox<TaskView>("ccfc8e77-a87d-456d-af85-e5a9ddd79d43","","",true, this);
 
            UIUnitarianTime = RPSControlFactory.CreateRPSFormattedTextBox<TaskView>("324c0abc-da16-42df-a3bc-362fdd4e254f","","",false, this);
 
            RepetitionTime = RPSControlFactory.CreateRPSDurationTextBox<TaskView>("171d8f55-94b7-4b3b-b442-53dceb2d0876","","",true, this);
 
            RepetitionLot = RPSControlFactory.CreateRPSFormattedTextBox<TaskView>("e04c036b-39cc-4bc0-bd4c-8b5beaa8def2","","",true, this);
 
            WorkUnits = RPSControlFactory.CreateRPSFormattedTextBox<TaskView>("3d0831c8-b04e-4a52-a735-1559d5e0a43a","","",true, this);
 
            IDUsualTask = RPSControlFactory.CreateRPSComboBox<TaskView>("1ccdbc23-639c-49d9-b9b7-e4ac07106696","","",false, this);
 
            IDTaskParent = RPSControlFactory.CreateRPSComboBox<TaskView>("322b3469-7491-475f-afec-392336f86bd0","","",false, this);
 
            IDTaskType = RPSControlFactory.CreateRPSComboBox<TaskView>("cb669574-07f3-4f03-bfb6-6d8c4280a699","","",false, this);
 
            SeriesRequired = RPSControlFactory.CreateRPSCheckBox<TaskView>("3d704e8d-915f-48c5-bd79-0ae71006308d","","",true, this);
 
            ProductEntry = RPSControlFactory.CreateRPSCheckBox<TaskView>("f8eae210-9565-4be5-9c77-7d342a93c816","","",true, this);
 
            MaterialExit = RPSControlFactory.CreateRPSCheckBox<TaskView>("7d87169e-9c66-4002-a936-acbaa0100880","","",true, this);
 
            PrintLabels = RPSControlFactory.CreateRPSCheckBox<TaskView>("8db4b15a-aab0-4d88-b977-ec4b1ad98377","","",true, this);
 
            LotsOrder = RPSControlFactory.CreateRPSCheckBox<TaskView>("4a7eb87c-015a-4401-adda-a724fec5d9c7","","",true, this);
 
            AutoExecutionImputation = RPSControlFactory.CreateRPSCheckBox<TaskView>("79290f66-3c29-4c32-b91b-7a7747b41c0e","","",true, this);
 
            IDProductFormula = RPSControlFactory.CreateRPSComboBox<TaskView>("4efbd313-e0b5-4ddc-834b-8268ca32f94c","","",false, this);
 
            FormulaVersion = RPSControlFactory.CreateRPSTextBox<TaskView>("24dc902d-2922-473d-b3ca-b0fb6421f3ce","","",false, this);
 
            FormulaDate = RPSControlFactory.CreateRPSTextBox<TaskView>("904954df-2368-4e4a-b318-eca57ee366b4","","",false, this);
 
            External = RPSControlFactory.CreateRPSCheckBox<TaskView>("399a33b4-2dc7-44b8-891b-269c0bbd5f91","","",true, this);
 
            IDArticleExternal = RPSControlFactory.CreateRPSComboBox<TaskView>("c72b33e8-6f67-4135-901a-2895b6e8d413","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<TaskView>("5a10b245-0faf-4611-a543-51993cbad836","","",true, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<TaskView>("f4aa5303-7153-4d19-873b-ab92f1981fc0","","",false, this);
 
            IDBudgetCategory = RPSControlFactory.CreateRPSComboBox<TaskView>("1edb1776-a1c2-4449-878b-9a37278fb37b","","",false, this);
 
            IDSiteMaterial = RPSControlFactory.CreateRPSComboBox<TaskView>("052f7b81-aecd-4c12-a28d-0a2b80b1b1c9","","",false, this);
 
            IDWarehouseMaterial = RPSControlFactory.CreateRPSComboBox<TaskView>("a90c9749-b0c5-48ed-8fe7-e36f14b75cfd","","",false, this);
 
            ImputationCostUpdated = RPSControlFactory.CreateRPSCheckBox<TaskView>("b190bdd3-de30-4406-aecc-efb900dea0b8","","",true, this);
 
            DelimitationType = RPSControlFactory.CreateRPSEnumComboBox<TaskView>("9b1edd67-6011-4341-ad13-01b6c5857c7d","","",true, this);
 
            ManualPlanning = RPSControlFactory.CreateRPSCheckBox<TaskView>("124b14f2-f049-41a9-b346-db9b90ad3399","","",true, this);
 
            ReleaseKeptResources = RPSControlFactory.CreateRPSCheckBox<TaskView>("d9257512-0d97-4a8f-9bc5-cc5025a09c55","","",true, this);
 
            AllowFraccionate = RPSControlFactory.CreateRPSCheckBox<TaskView>("771f1f54-053e-4499-addd-65dc387176df","","",true, this);
 
            MinimumFraction = RPSControlFactory.CreateRPSFormattedTextBox<TaskView>("cc67e0d7-2ec3-43d2-85ef-282ab63dc9ef","","",true, this);
 
            TimeUnit1 = RPSControlFactory.CreateRPSEnumComboBox<TaskView>("3abc0049-f77e-4a25-abc2-02859b6eca24","","",true, this);
 
            WithoutTimetable = RPSControlFactory.CreateRPSCheckBox<TaskView>("7db81da7-8c90-4fd5-98e1-ce0f3eb024ca","","",true, this);
 
            OptimizationFeature = RPSControlFactory.CreateRPSTextBox<TaskView>("b545c5bb-37c8-46a2-b724-86d9c6cfba50","","",false, this);
 
            ResourcePlanType = RPSControlFactory.CreateRPSEnumComboBox<TaskView>("de1ceae3-bd47-4dab-9f7f-b591ad7cd8e5","","",true, this);
 
            SplitNumber = RPSControlFactory.CreateRPSFormattedTextBox<TaskView>("ae3c836b-c4ae-46d8-ac01-93c44c1cf4db","","",true, this);
 
            OccupancyType = RPSControlFactory.CreateRPSEnumComboBox<TaskView>("75994992-411f-4eda-8935-69e9b5919d33","","",true, this);
 
            OccupancyHours = RPSControlFactory.CreateRPSFormattedTextBox<TaskView>("6b5e4ccb-f1f2-47cd-aecb-ef1982ae93dc","","",true, this);
 
            OccupancyPercent = RPSControlFactory.CreateRPSFormattedTextBox<TaskView>("aeec95c7-dee4-4db0-a3fb-723b25213be8","","",true, this);
 
            NotOverlapCode = RPSControlFactory.CreateRPSTextBox<TaskView>("cd1df14d-f06d-425a-b405-2922061845b8","","",false, this);
 
            GroupedManufacturing = RPSControlFactory.CreateRPSCheckBox<TaskView>("64bc01c3-20f8-4c8a-b3e1-9176623fca21","","",true, this);
 
            Notes = RPSControlFactory.CreateRPSTextBox<TaskView>("5442d859-571e-42a4-acf0-48c293841e8b","","",false, this);
 
            IDBudgetEmployee = RPSControlFactory.CreateRPSComboBox<TaskView>("279b0fdd-eb2c-483b-a002-3535ee2974f1","","",false, this);
 
            IDBudgetMachine = RPSControlFactory.CreateRPSComboBox<TaskView>("167929e0-860a-48ef-9399-5d06c5857781","","",false, this);
 
            IDBudgetTool = RPSControlFactory.CreateRPSComboBox<TaskView>("1d48242a-81d1-4327-ae15-e376a0b66d57","","",false, this);
 
            IDBudgetMaterial = RPSControlFactory.CreateRPSComboBox<TaskView>("75b1af84-af5f-466c-8d34-04a2b9083d2f","","",false, this);
 
            IDBudgetOtherCost = RPSControlFactory.CreateRPSComboBox<TaskView>("9bcc0423-990c-461c-9d35-491f9e041ba9","","",false, this);
 
            LinkNavigationCommandButton = RPSControlFactory.CreateRPSButton<TaskView>( "13724afa-eb89-4899-b187-857025cf4973","","",this);
 
            CollectionInit params_Materials = new CollectionInit(){IDDescriptor = "37813c34-e535-4e69-935a-3acee7decb8f",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ead57c08-af1e-48d7-aa8e-0d555da2474c",CSSSelectorGrid="",XPathGrid=""};
            Materials = RPSControlFactory.RPSCreateCollectionWithGrid<MaterialsCollectionEditor<TaskView,TaskRouteView>,TaskView,TaskRouteView>( params_Materials,this,Screen.TaskRouteView);
 
            CollectionInit params_TaskRelations = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1e5a81e6-ecef-4961-9569-c5f634080f98",CSSSelectorGrid="",XPathGrid=""};
            TaskRelations = RPSControlFactory.RPSCreateCollectionWithGrid<TaskRelationsCollectionEditor<TaskView,TaskRouteView>,TaskView,TaskRouteView>( params_TaskRelations,this,Screen.TaskRouteView);
 
            CollectionInit params_TaskRoutes = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="653f7b44-15e2-40c1-891a-90992caee2ab",CSSSelectorGrid="",XPathGrid=""};
            TaskRoutes = RPSControlFactory.RPSCreateCollectionWithGrid<TaskRoutesCollectionEditor<TaskView,TaskRouteView>,TaskView,TaskRouteView>( params_TaskRoutes,this,Screen.TaskRouteView);
 
            CollectionInit params_ResourceEmployees = new CollectionInit(){IDDescriptor = "68aaa6f1-8c7c-4b6e-942f-d5d53ab339fd",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="edfb1e1d-1989-4dc5-bb10-478154f42d13",CSSSelectorGrid="",XPathGrid=""};
            ResourceEmployees = RPSControlFactory.RPSCreateCollectionWithGrid<ResourceEmployeesCollectionEditor<TaskView,TaskRouteView>,TaskView,TaskRouteView>( params_ResourceEmployees,this,Screen.TaskRouteView);
 
            CollectionInit params_ResourceMachines = new CollectionInit(){IDDescriptor = "e22aee1d-1603-4a15-974e-e262ae81243d",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5632bf9f-d099-4f28-bf9a-28269fb6a672",CSSSelectorGrid="",XPathGrid=""};
            ResourceMachines = RPSControlFactory.RPSCreateCollectionWithGrid<ResourceMachinesCollectionEditor<TaskView,TaskRouteView>,TaskView,TaskRouteView>( params_ResourceMachines,this,Screen.TaskRouteView);
 
            CollectionInit params_ResourceTools = new CollectionInit(){IDDescriptor = "e31ab526-4906-4324-9e88-8200d995e498",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7c6ef1e0-c2c7-4619-a39d-befc2b059d1b",CSSSelectorGrid="",XPathGrid=""};
            ResourceTools = RPSControlFactory.RPSCreateCollectionWithGrid<ResourceToolsCollectionEditor<TaskView,TaskRouteView>,TaskView,TaskRouteView>( params_ResourceTools,this,Screen.TaskRouteView);
 
            CollectionInit params_TaskCostComponents = new CollectionInit(){IDDescriptor = "68d5fe2f-1119-4d52-87b7-36b0d8e5690b",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6553948f-bb6f-4c96-a689-35064af04f91",CSSSelectorGrid="",XPathGrid=""};
            TaskCostComponents = RPSControlFactory.RPSCreateCollectionWithGrid<TaskCostComponentsCollectionEditor<TaskView,TaskRouteView>,TaskView,TaskRouteView>( params_TaskCostComponents,this,Screen.TaskRouteView);
 
            CollectionInit params_TaskDimensions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="52de4055-cac1-473b-a9bb-57718b90af9b",CSSSelectorGrid="",XPathGrid=""};
            TaskDimensions = RPSControlFactory.RPSCreateCollectionWithGrid<TaskDimensionsCollectionEditor<TaskView,TaskRouteView>,TaskView,TaskRouteView>( params_TaskDimensions,this,Screen.TaskRouteView);
 
            SectionGeneral = RPSControlFactory.CreateRPSSection<TaskView>( "","ul li[rpsid='16855287-a6ab-413e-9dfc-b78f2dff66fe']","",this);
 
            SectionMaterials = RPSControlFactory.CreateRPSSection<TaskView>( "","ul li[rpsid='ed8b41bd-9ad0-4c9e-a2a8-c9cc896d95dd']","",this);
 
            SectionExternal = RPSControlFactory.CreateRPSSection<TaskView>( "","ul li[rpsid='e55e982f-2d81-4daf-968c-f29a75b53383']","",this);
 
            SectionPlanning = RPSControlFactory.CreateRPSSection<TaskView>( "","ul li[rpsid='73f82618-cb06-4b47-a52b-aa8ec5b8c33c']","",this);
 
            SectionNotes = RPSControlFactory.CreateRPSSection<TaskView>( "","ul li[rpsid='e2777132-7855-4363-8684-1abcb1fa762d']","",this);
 
            SectionRelations = RPSControlFactory.CreateRPSSection<TaskView>( "","ul li[rpsid='42a752c4-deca-4550-a553-fd38c0c08b63']","",this);
 
            SectionRoutes = RPSControlFactory.CreateRPSSection<TaskView>( "","ul li[rpsid='dc830748-7365-42c9-9cab-6939d09405f8']","",this);
 
            SectionEmployees = RPSControlFactory.CreateRPSSection<TaskView>( "","ul li[rpsid='5957971a-fd1f-4dd1-b0a4-daac45dca455']","",this);
 
            SectionMachine = RPSControlFactory.CreateRPSSection<TaskView>( "","ul li[rpsid='03df7493-dda6-4544-a083-38b1e35ad9f3']","",this);
 
            SectionTool = RPSControlFactory.CreateRPSSection<TaskView>( "","ul li[rpsid='b61da8c9-6813-486e-906c-20b62ccc0789']","",this);
 
            SectionCostComponent = RPSControlFactory.CreateRPSSection<TaskView>( "","ul li[rpsid='f771381e-bcf9-4e07-b8c0-85a480d8724a']","",this);
 
            SectionBudgetCategory = RPSControlFactory.CreateRPSSection<TaskView>( "","ul li[rpsid='ac94edfa-89b3-4f9f-a739-169548bba019']","",this);
 
            SectionDimensions = RPSControlFactory.CreateRPSSection<TaskView>( "","ul li[rpsid='3457585e-7039-4086-8a87-3833471d7f6e']","",this);
 

        }
        public IRPSButton<TaskView> DeleteButton { get; set; } 
        public IRPSButton<TaskView,StructureEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<TaskView,StructureEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<TaskView,StructureEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<TaskView> CodTask { get; set; } 
        public IRPSTextBox<TaskView> Description { get; set; } 
        public IRPSComboBox<TaskView> TaskType { get; set; } 
        public IRPSDurationTextBox<TaskView> PreparationTime { get; set; } 
        public IRPSDurationTextBox<TaskView> ExecutionTime { get; set; } 
        public IRPSComboBox<TaskView> TimeUnit { get; set; } 
        public IRPSTextBox<TaskView> ExecutionLot { get; set; } 
        public IRPSTextBox<TaskView> UIUnitarianTime { get; set; } 
        public IRPSDurationTextBox<TaskView> RepetitionTime { get; set; } 
        public IRPSTextBox<TaskView> RepetitionLot { get; set; } 
        public IRPSTextBox<TaskView> WorkUnits { get; set; } 
        public IRPSComboBox<TaskView> IDUsualTask { get; set; } 
        public IRPSComboBox<TaskView> IDTaskParent { get; set; } 
        public IRPSComboBox<TaskView> IDTaskType { get; set; } 
        public IRPSCheckbox<TaskView> SeriesRequired { get; set; } 
        public IRPSCheckbox<TaskView> ProductEntry { get; set; } 
        public IRPSCheckbox<TaskView> MaterialExit { get; set; } 
        public IRPSCheckbox<TaskView> PrintLabels { get; set; } 
        public IRPSCheckbox<TaskView> LotsOrder { get; set; } 
        public IRPSCheckbox<TaskView> AutoExecutionImputation { get; set; } 
        public IRPSComboBox<TaskView> IDProductFormula { get; set; } 
        public IRPSTextBox<TaskView> FormulaVersion { get; set; } 
        public IRPSTextBox<TaskView> FormulaDate { get; set; } 
        public IRPSCheckbox<TaskView> External { get; set; } 
        public IRPSComboBox<TaskView> IDArticleExternal { get; set; } 
        public IRPSTextBox<TaskView> Quantity { get; set; } 
        public IRPSComboBox<TaskView> IDSupplier { get; set; } 
        public IRPSComboBox<TaskView> IDBudgetCategory { get; set; } 
        public IRPSComboBox<TaskView> IDSiteMaterial { get; set; } 
        public IRPSComboBox<TaskView> IDWarehouseMaterial { get; set; } 
        public IRPSCheckbox<TaskView> ImputationCostUpdated { get; set; } 
        public IRPSComboBox<TaskView> DelimitationType { get; set; } 
        public IRPSCheckbox<TaskView> ManualPlanning { get; set; } 
        public IRPSCheckbox<TaskView> ReleaseKeptResources { get; set; } 
        public IRPSCheckbox<TaskView> AllowFraccionate { get; set; } 
        public IRPSTextBox<TaskView> MinimumFraction { get; set; } 
        public IRPSComboBox<TaskView> TimeUnit1 { get; set; } 
        public IRPSCheckbox<TaskView> WithoutTimetable { get; set; } 
        public IRPSTextBox<TaskView> OptimizationFeature { get; set; } 
        public IRPSComboBox<TaskView> ResourcePlanType { get; set; } 
        public IRPSTextBox<TaskView> SplitNumber { get; set; } 
        public IRPSComboBox<TaskView> OccupancyType { get; set; } 
        public IRPSTextBox<TaskView> OccupancyHours { get; set; } 
        public IRPSTextBox<TaskView> OccupancyPercent { get; set; } 
        public IRPSTextBox<TaskView> NotOverlapCode { get; set; } 
        public IRPSCheckbox<TaskView> GroupedManufacturing { get; set; } 
        public IRPSTextBox<TaskView> Notes { get; set; } 
        public IRPSComboBox<TaskView> IDBudgetEmployee { get; set; } 
        public IRPSComboBox<TaskView> IDBudgetMachine { get; set; } 
        public IRPSComboBox<TaskView> IDBudgetTool { get; set; } 
        public IRPSComboBox<TaskView> IDBudgetMaterial { get; set; } 
        public IRPSComboBox<TaskView> IDBudgetOtherCost { get; set; } 
        public IRPSButton<TaskView> LinkNavigationCommandButton { get; set; } 
        public MaterialsCollectionEditor<TaskView,TaskRouteView> Materials { get; set; } 
        public TaskRelationsCollectionEditor<TaskView,TaskRouteView> TaskRelations { get; set; } 
        public TaskRoutesCollectionEditor<TaskView,TaskRouteView> TaskRoutes { get; set; } 
        public ResourceEmployeesCollectionEditor<TaskView,TaskRouteView> ResourceEmployees { get; set; } 
        public ResourceMachinesCollectionEditor<TaskView,TaskRouteView> ResourceMachines { get; set; } 
        public ResourceToolsCollectionEditor<TaskView,TaskRouteView> ResourceTools { get; set; } 
        public TaskCostComponentsCollectionEditor<TaskView,TaskRouteView> TaskCostComponents { get; set; } 
        public TaskDimensionsCollectionEditor<TaskView,TaskRouteView> TaskDimensions { get; set; } 
        public IRPSSection<TaskView> SectionGeneral { get; set; } 
        public IRPSSection<TaskView> SectionMaterials { get; set; } 
        public IRPSSection<TaskView> SectionExternal { get; set; } 
        public IRPSSection<TaskView> SectionPlanning { get; set; } 
        public IRPSSection<TaskView> SectionNotes { get; set; } 
        public IRPSSection<TaskView> SectionRelations { get; set; } 
        public IRPSSection<TaskView> SectionRoutes { get; set; } 
        public IRPSSection<TaskView> SectionEmployees { get; set; } 
        public IRPSSection<TaskView> SectionMachine { get; set; } 
        public IRPSSection<TaskView> SectionTool { get; set; } 
        public IRPSSection<TaskView> SectionCostComponent { get; set; } 
        public IRPSSection<TaskView> SectionBudgetCategory { get; set; } 
        public IRPSSection<TaskView> SectionDimensions { get; set; } 
        public Structure Screen { get; set; }
        public TaskView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaterialsCollectionEditor<TaskView,TaskRouteView>:RPSCollectionEditor<TaskView,TaskRouteView> where TaskView : class, IView where TaskRouteView : class, IView
    {
        public  MaterialsGridView<TaskView,TaskRouteView> GridView {get;set;}
    }
    public partial class MaterialsGridView <TaskView,TaskRouteView> :  RPSGridView<TaskView,TaskRouteView> where TaskView : class, IView where TaskRouteView : class, IView
    {
        public MaterialsGridView(TaskView currentView,TaskRouteView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodMaterial = RPSControlFactory.CreateRPSGridTextBox<TaskView>("","#ead57c08-af1e-48d7-aa8e-0d555da2474c .ag-row[role='row']@ROWINDEX [col-id='cCodMaterial']","",true, this.CurrentView);
 
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<TaskView>("","#ead57c08-af1e-48d7-aa8e-0d555da2474c .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<TaskView>("","#ead57c08-af1e-48d7-aa8e-0d555da2474c .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<TaskView>("","#ead57c08-af1e-48d7-aa8e-0d555da2474c .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            ContentLot = RPSControlFactory.CreateRPSGridFormattedTextBox<TaskView>("","#ead57c08-af1e-48d7-aa8e-0d555da2474c .ag-row[role='row']@ROWINDEX [col-id='cContentLot']","",true, this.CurrentView);
 
            Order = RPSControlFactory.CreateRPSGridFormattedTextBox<TaskView>("","#ead57c08-af1e-48d7-aa8e-0d555da2474c .ag-row[role='row']@ROWINDEX [col-id='cOrder']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<TaskView> CodMaterial { get; set; } 
        public IRPSGridComboBox<TaskView> IDArticle { get; set; } 
        public IRPSGridTextBox<TaskView> Description { get; set; } 
        public IRPSGridTextBox<TaskView> Quantity { get; set; } 
        public IRPSGridTextBox<TaskView> ContentLot { get; set; } 
        public IRPSGridTextBox<TaskView> Order { get; set; } 
                     
    }
 
        public partial class TaskRelationsCollectionEditor<TaskView,TaskRouteView>:RPSCollectionEditor<TaskView,TaskRouteView> where TaskView : class, IView where TaskRouteView : class, IView
    {
        public  TaskRelationsGridView<TaskView,TaskRouteView> GridView {get;set;}
    }
    public partial class TaskRelationsGridView <TaskView,TaskRouteView> :  RPSGridView<TaskView,TaskRouteView> where TaskView : class, IView where TaskRouteView : class, IView
    {
        public TaskRelationsGridView(TaskView currentView,TaskRouteView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDPredecessorTask = RPSControlFactory.CreateRPSGridComboBox<TaskView>("","#1e5a81e6-ecef-4961-9569-c5f634080f98 .ag-row[role='row']@ROWINDEX [col-id='cIDPredecessorTask']","",true, this.CurrentView);
 
            RelationType = RPSControlFactory.CreateRPSGridEnumComboBox<TaskView>("","#1e5a81e6-ecef-4961-9569-c5f634080f98 .ag-row[role='row']@ROWINDEX [col-id='cRelationType']","",true, this.CurrentView);
 
            LagType = RPSControlFactory.CreateRPSGridEnumComboBox<TaskView>("","#1e5a81e6-ecef-4961-9569-c5f634080f98 .ag-row[role='row']@ROWINDEX [col-id='cLagType']","",true, this.CurrentView);
 
            TimeLag = RPSControlFactory.CreateRPSGridDurationTextBox<TaskView>("","#1e5a81e6-ecef-4961-9569-c5f634080f98 .ag-row[role='row']@ROWINDEX [col-id='cTimeLag']","",true, this.CurrentView);
 
            UnitsLag = RPSControlFactory.CreateRPSGridFormattedTextBox<TaskView>("","#1e5a81e6-ecef-4961-9569-c5f634080f98 .ag-row[role='row']@ROWINDEX [col-id='cUnitsLag']","",true, this.CurrentView);
 
            Linked = RPSControlFactory.CreateRPSGridCheckBox<TaskView>("","#1e5a81e6-ecef-4961-9569-c5f634080f98 .ag-row[role='row']@ROWINDEX [col-id='cLinked']","",true, this.CurrentView);
 
            CalendarType = RPSControlFactory.CreateRPSGridEnumComboBox<TaskView>("","#1e5a81e6-ecef-4961-9569-c5f634080f98 .ag-row[role='row']@ROWINDEX [col-id='cCalendarType']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<TaskView> IDPredecessorTask { get; set; } 
        public IRPSGridComboBox<TaskView> RelationType { get; set; } 
        public IRPSGridComboBox<TaskView> LagType { get; set; } 
        public IRPSGridDurationTextBox<TaskView> TimeLag { get; set; } 
        public IRPSGridTextBox<TaskView> UnitsLag { get; set; } 
        public IRPSGridCheckbox<TaskView> Linked { get; set; } 
        public IRPSGridComboBox<TaskView> CalendarType { get; set; } 
                     
    }
 
        public partial class TaskRoutesCollectionEditor<TaskView,TaskRouteView>:RPSCollectionEditor<TaskView,TaskRouteView> where TaskView : class, IView where TaskRouteView : class, IView
    {
        public  TaskRoutesGridView<TaskView,TaskRouteView> GridView {get;set;}
    }
    public partial class TaskRoutesGridView <TaskView,TaskRouteView> :  RPSGridView<TaskView,TaskRouteView> where TaskView : class, IView where TaskRouteView : class, IView
    {
        public TaskRoutesGridView(TaskView currentView,TaskRouteView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDRoute = RPSControlFactory.CreateRPSGridComboBox<TaskView>("","#653f7b44-15e2-40c1-891a-90992caee2ab .ag-row[role='row']@ROWINDEX [col-id='cIDRoute']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<TaskView> IDRoute { get; set; } 
                     
    }
 
        public partial class ResourceEmployeesCollectionEditor<TaskView,TaskRouteView>:RPSCollectionEditor<TaskView,TaskRouteView> where TaskView : class, IView where TaskRouteView : class, IView
    {
        public  ResourceEmployeesGridView<TaskView,TaskRouteView> GridView {get;set;}
    }
    public partial class ResourceEmployeesGridView <TaskView,TaskRouteView> :  RPSGridView<TaskView,TaskRouteView> where TaskView : class, IView where TaskRouteView : class, IView
    {
        public ResourceEmployeesGridView(TaskView currentView,TaskRouteView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDEmployee = RPSControlFactory.CreateRPSGridComboBox<TaskView>("","#edfb1e1d-1989-4dc5-bb10-478154f42d13 .ag-row[role='row']@ROWINDEX [col-id='cIDEmployee']","",false, this.CurrentView);
 
            IDQualify = RPSControlFactory.CreateRPSGridComboBox<TaskView>("","#edfb1e1d-1989-4dc5-bb10-478154f42d13 .ag-row[role='row']@ROWINDEX [col-id='cIDQualify']","",true, this.CurrentView);
 
            ParticipateIn = RPSControlFactory.CreateRPSGridEnumComboBox<TaskView>("","#edfb1e1d-1989-4dc5-bb10-478154f42d13 .ag-row[role='row']@ROWINDEX [col-id='cParticipateIn']","",true, this.CurrentView);
 
            Planify = RPSControlFactory.CreateRPSGridCheckBox<TaskView>("","#edfb1e1d-1989-4dc5-bb10-478154f42d13 .ag-row[role='row']@ROWINDEX [col-id='cPlanify']","",true, this.CurrentView);
 
            DedicationPercent = RPSControlFactory.CreateRPSGridFormattedTextBox<TaskView>("","#edfb1e1d-1989-4dc5-bb10-478154f42d13 .ag-row[role='row']@ROWINDEX [col-id='cDedicationPercent']","",true, this.CurrentView);
 
            IDBudgetCategory = RPSControlFactory.CreateRPSGridComboBox<TaskView>("","#edfb1e1d-1989-4dc5-bb10-478154f42d13 .ag-row[role='row']@ROWINDEX [col-id='cIDBudgetCategory']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<TaskView> IDEmployee { get; set; } 
        public IRPSGridComboBox<TaskView> IDQualify { get; set; } 
        public IRPSGridComboBox<TaskView> ParticipateIn { get; set; } 
        public IRPSGridCheckbox<TaskView> Planify { get; set; } 
        public IRPSGridTextBox<TaskView> DedicationPercent { get; set; } 
        public IRPSGridComboBox<TaskView> IDBudgetCategory { get; set; } 
                     
    }
 
        public partial class ResourceMachinesCollectionEditor<TaskView,TaskRouteView>:RPSCollectionEditor<TaskView,TaskRouteView> where TaskView : class, IView where TaskRouteView : class, IView
    {
        public  ResourceMachinesGridView<TaskView,TaskRouteView> GridView {get;set;}
    }
    public partial class ResourceMachinesGridView <TaskView,TaskRouteView> :  RPSGridView<TaskView,TaskRouteView> where TaskView : class, IView where TaskRouteView : class, IView
    {
        public ResourceMachinesGridView(TaskView currentView,TaskRouteView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDMachine = RPSControlFactory.CreateRPSGridComboBox<TaskView>("","#5632bf9f-d099-4f28-bf9a-28269fb6a672 .ag-row[role='row']@ROWINDEX [col-id='cIDMachine']","",false, this.CurrentView);
 
            IDMachineGroup = RPSControlFactory.CreateRPSGridComboBox<TaskView>("","#5632bf9f-d099-4f28-bf9a-28269fb6a672 .ag-row[role='row']@ROWINDEX [col-id='cIDMachineGroup']","",false, this.CurrentView);
 
            ParticipateIn = RPSControlFactory.CreateRPSGridEnumComboBox<TaskView>("","#5632bf9f-d099-4f28-bf9a-28269fb6a672 .ag-row[role='row']@ROWINDEX [col-id='cParticipateIn']","",true, this.CurrentView);
 
            Planify = RPSControlFactory.CreateRPSGridCheckBox<TaskView>("","#5632bf9f-d099-4f28-bf9a-28269fb6a672 .ag-row[role='row']@ROWINDEX [col-id='cPlanify']","",true, this.CurrentView);
 
            DedicationPercent = RPSControlFactory.CreateRPSGridFormattedTextBox<TaskView>("","#5632bf9f-d099-4f28-bf9a-28269fb6a672 .ag-row[role='row']@ROWINDEX [col-id='cDedicationPercent']","",true, this.CurrentView);
 
            IDResourceEmployee = RPSControlFactory.CreateRPSGridComboBox<TaskView>("","#5632bf9f-d099-4f28-bf9a-28269fb6a672 .ag-row[role='row']@ROWINDEX [col-id='cIDResourceEmployee']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<TaskView> IDMachine { get; set; } 
        public IRPSGridComboBox<TaskView> IDMachineGroup { get; set; } 
        public IRPSGridComboBox<TaskView> ParticipateIn { get; set; } 
        public IRPSGridCheckbox<TaskView> Planify { get; set; } 
        public IRPSGridTextBox<TaskView> DedicationPercent { get; set; } 
        public IRPSGridComboBox<TaskView> IDResourceEmployee { get; set; } 
                     
    }
 
        public partial class ResourceToolsCollectionEditor<TaskView,TaskRouteView>:RPSCollectionEditor<TaskView,TaskRouteView> where TaskView : class, IView where TaskRouteView : class, IView
    {
        public  ResourceToolsGridView<TaskView,TaskRouteView> GridView {get;set;}
    }
    public partial class ResourceToolsGridView <TaskView,TaskRouteView> :  RPSGridView<TaskView,TaskRouteView> where TaskView : class, IView where TaskRouteView : class, IView
    {
        public ResourceToolsGridView(TaskView currentView,TaskRouteView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDTool = RPSControlFactory.CreateRPSGridComboBox<TaskView>("","#7c6ef1e0-c2c7-4619-a39d-befc2b059d1b .ag-row[role='row']@ROWINDEX [col-id='cIDTool']","",true, this.CurrentView);
 
            ParticipateIn = RPSControlFactory.CreateRPSGridEnumComboBox<TaskView>("","#7c6ef1e0-c2c7-4619-a39d-befc2b059d1b .ag-row[role='row']@ROWINDEX [col-id='cParticipateIn']","",true, this.CurrentView);
 
            Planify = RPSControlFactory.CreateRPSGridCheckBox<TaskView>("","#7c6ef1e0-c2c7-4619-a39d-befc2b059d1b .ag-row[role='row']@ROWINDEX [col-id='cPlanify']","",true, this.CurrentView);
 
            DedicationPercent = RPSControlFactory.CreateRPSGridFormattedTextBox<TaskView>("","#7c6ef1e0-c2c7-4619-a39d-befc2b059d1b .ag-row[role='row']@ROWINDEX [col-id='cDedicationPercent']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<TaskView> IDTool { get; set; } 
        public IRPSGridComboBox<TaskView> ParticipateIn { get; set; } 
        public IRPSGridCheckbox<TaskView> Planify { get; set; } 
        public IRPSGridTextBox<TaskView> DedicationPercent { get; set; } 
                     
    }
 
        public partial class TaskCostComponentsCollectionEditor<TaskView,TaskRouteView>:RPSCollectionEditor<TaskView,TaskRouteView> where TaskView : class, IView where TaskRouteView : class, IView
    {
        public  TaskCostComponentsGridView<TaskView,TaskRouteView> GridView {get;set;}
    }
    public partial class TaskCostComponentsGridView <TaskView,TaskRouteView> :  RPSGridView<TaskView,TaskRouteView> where TaskView : class, IView where TaskRouteView : class, IView
    {
        public TaskCostComponentsGridView(TaskView currentView,TaskRouteView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodTaskCostComponent = RPSControlFactory.CreateRPSGridTextBox<TaskView>("","#6553948f-bb6f-4c96-a689-35064af04f91 .ag-row[role='row']@ROWINDEX [col-id='cCodTaskCostComponent']","",true, this.CurrentView);
 
            IDCostComponent = RPSControlFactory.CreateRPSGridComboBox<TaskView>("","#6553948f-bb6f-4c96-a689-35064af04f91 .ag-row[role='row']@ROWINDEX [col-id='cIDCostComponent']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<TaskView>("","#6553948f-bb6f-4c96-a689-35064af04f91 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<TaskView>("","#6553948f-bb6f-4c96-a689-35064af04f91 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            Price = RPSControlFactory.CreateRPSGridFormattedTextBox<TaskView>("","#6553948f-bb6f-4c96-a689-35064af04f91 .ag-row[role='row']@ROWINDEX [col-id='cPrice']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<TaskView> CodTaskCostComponent { get; set; } 
        public IRPSGridComboBox<TaskView> IDCostComponent { get; set; } 
        public IRPSGridTextBox<TaskView> Description { get; set; } 
        public IRPSGridTextBox<TaskView> Quantity { get; set; } 
        public IRPSGridTextBox<TaskView> Price { get; set; } 
                     
    }
 
        public partial class TaskDimensionsCollectionEditor<TaskView,TaskRouteView>:RPSCollectionEditor<TaskView,TaskRouteView> where TaskView : class, IView where TaskRouteView : class, IView
    {
        public  TaskDimensionsGridView<TaskView,TaskRouteView> GridView {get;set;}
    }
    public partial class TaskDimensionsGridView <TaskView,TaskRouteView> :  RPSGridView<TaskView,TaskRouteView> where TaskView : class, IView where TaskRouteView : class, IView
    {
        public TaskDimensionsGridView(TaskView currentView,TaskRouteView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDDimension = RPSControlFactory.CreateRPSGridComboBox<TaskView>("","#52de4055-cac1-473b-a9bb-57718b90af9b .ag-row[role='row']@ROWINDEX [col-id='cIDDimension']","",true, this.CurrentView);
 
            IDDimValue = RPSControlFactory.CreateRPSGridComboBox<TaskView>("","#52de4055-cac1-473b-a9bb-57718b90af9b .ag-row[role='row']@ROWINDEX [col-id='cIDDimValue']","",true, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<TaskView>("","#52de4055-cac1-473b-a9bb-57718b90af9b .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<TaskView> IDDimension { get; set; } 
        public IRPSGridComboBox<TaskView> IDDimValue { get; set; } 
        public IRPSGridTextBox<TaskView> Percentage { get; set; } 
                     
    }
 
    }
  
            
    public partial class TaskRelationView : View
    {
        public TaskRelationView(Structure screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<TaskRelationView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<TaskRelationView,TaskView>( this,Screen.TaskView);
 
            BackButton = RPSControlFactory.RPSBackButton<TaskRelationView,TaskView>( this,Screen.TaskView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<TaskRelationView,TaskView>( this,Screen.TaskView);
 
            IDPredecessorTask = RPSControlFactory.CreateRPSComboBox<TaskRelationView>("8b1b2657-2510-4065-99f7-441da1564a1a","","",true, this);
 
            RelationType = RPSControlFactory.CreateRPSEnumComboBox<TaskRelationView>("1f3c598d-4a94-479a-9180-982dc2994d71","","",true, this);
 
            Linked = RPSControlFactory.CreateRPSCheckBox<TaskRelationView>("2d538fb3-59c6-44c9-a82c-af22599eb3cb","","",true, this);
 
            LagType = RPSControlFactory.CreateRPSEnumComboBox<TaskRelationView>("403c2cb7-df8a-4457-bf6f-17bcee4e1aec","","",true, this);
 
            TimeLag = RPSControlFactory.CreateRPSDurationTextBox<TaskRelationView>("a9b626a1-40e0-42e5-9294-472242ec9f1b","","",true, this);
 
            UnitsLag = RPSControlFactory.CreateRPSFormattedTextBox<TaskRelationView>("58c28ec0-5bb2-4d26-8417-a908fe8730b3","","",true, this);
 
            CalendarType = RPSControlFactory.CreateRPSEnumComboBox<TaskRelationView>("d10e2168-3883-4ed5-a5af-dc74e5f36753","","",true, this);
 

        }
        public IRPSButton<TaskRelationView> DeleteButton { get; set; } 
        public IRPSButton<TaskRelationView,TaskView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<TaskRelationView,TaskView> BackButton { get; set; } 
        public IRPSAcceptButton<TaskRelationView,TaskView> AcceptButton { get; set; } 
        public IRPSComboBox<TaskRelationView> IDPredecessorTask { get; set; } 
        public IRPSComboBox<TaskRelationView> RelationType { get; set; } 
        public IRPSCheckbox<TaskRelationView> Linked { get; set; } 
        public IRPSComboBox<TaskRelationView> LagType { get; set; } 
        public IRPSDurationTextBox<TaskRelationView> TimeLag { get; set; } 
        public IRPSTextBox<TaskRelationView> UnitsLag { get; set; } 
        public IRPSComboBox<TaskRelationView> CalendarType { get; set; } 
        public Structure Screen { get; set; }
        public TaskRelationView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class TaskRouteView : View
    {
        public TaskRouteView(Structure screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<TaskRouteView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<TaskRouteView,TaskView>( this,Screen.TaskView);
 
            BackButton = RPSControlFactory.RPSBackButton<TaskRouteView,TaskView>( this,Screen.TaskView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<TaskRouteView,TaskView>( this,Screen.TaskView);
 
            IDRoute = RPSControlFactory.CreateRPSComboBox<TaskRouteView>("1f3371aa-9b20-4c74-8f7e-0552cec76ff5","","",false, this);
 

        }
        public IRPSButton<TaskRouteView> DeleteButton { get; set; } 
        public IRPSButton<TaskRouteView,TaskView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<TaskRouteView,TaskView> BackButton { get; set; } 
        public IRPSAcceptButton<TaskRouteView,TaskView> AcceptButton { get; set; } 
        public IRPSComboBox<TaskRouteView> IDRoute { get; set; } 
        public Structure Screen { get; set; }
        public TaskRouteView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class StructureFeatureView : View
    {
        public StructureFeatureView(Structure screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<StructureFeatureView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<StructureFeatureView,StructureEntityView>( this,Screen.StructureEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<StructureFeatureView,StructureEntityView>( this,Screen.StructureEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<StructureFeatureView,StructureEntityView>( this,Screen.StructureEntityView);
 
            IDFeatureLabel = RPSControlFactory.CreateRPSComboBox<StructureFeatureView>("9508b4be-b808-4c08-86f8-0813ae6258c9","","",true, this);
 

        }
        public IRPSButton<StructureFeatureView> DeleteButton { get; set; } 
        public IRPSButton<StructureFeatureView,StructureEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<StructureFeatureView,StructureEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<StructureFeatureView,StructureEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<StructureFeatureView> IDFeatureLabel { get; set; } 
        public Structure Screen { get; set; }
        public StructureFeatureView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class StructureDimensionView : View
    {
        public StructureDimensionView(Structure screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<StructureDimensionView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<StructureDimensionView,StructureEntityView>( this,Screen.StructureEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<StructureDimensionView,StructureEntityView>( this,Screen.StructureEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<StructureDimensionView,StructureEntityView>( this,Screen.StructureEntityView);
 
            IDDimension = RPSControlFactory.CreateRPSComboBox<StructureDimensionView>("21c7982a-b366-4a52-be20-d1752b65d24d","","",true, this);
 
            IDDimValue = RPSControlFactory.CreateRPSComboBox<StructureDimensionView>("1791a771-db15-45b6-8de8-5736de511631","","",true, this);
 
            Percentage = RPSControlFactory.CreateRPSFormattedTextBox<StructureDimensionView>("6c0becad-7f70-43b4-89ae-3ded91051150","","",true, this);
 

        }
        public IRPSButton<StructureDimensionView> DeleteButton { get; set; } 
        public IRPSButton<StructureDimensionView,StructureEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<StructureDimensionView,StructureEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<StructureDimensionView,StructureEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<StructureDimensionView> IDDimension { get; set; } 
        public IRPSComboBox<StructureDimensionView> IDDimValue { get; set; } 
        public IRPSTextBox<StructureDimensionView> Percentage { get; set; } 
        public Structure Screen { get; set; }
        public StructureDimensionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ResourceMachineView : View
    {
        public ResourceMachineView(Structure screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ResourceMachineView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ResourceMachineView,TaskView>( this,Screen.TaskView);
 
            BackButton = RPSControlFactory.RPSBackButton<ResourceMachineView,TaskView>( this,Screen.TaskView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ResourceMachineView,TaskView>( this,Screen.TaskView);
 
            CodResourceMachine = RPSControlFactory.CreateRPSTextBox<ResourceMachineView>("59b0adcf-b883-413c-9281-3445dd3e713b","","",false, this);
 
            IDMachine = RPSControlFactory.CreateRPSComboBox<ResourceMachineView>("02af25d3-60e0-4106-b086-c7b74496a435","","",false, this);
 
            IDMachineGroup = RPSControlFactory.CreateRPSComboBox<ResourceMachineView>("7de2ab48-3d1b-43da-bcde-6d1769093957","","",false, this);
 
            AddAltMachinesToGrid = RPSControlFactory.CreateRPSButton<ResourceMachineView>( "5cdf080f-5e51-4629-b630-6829b12fa6b3","","",this);
 
            ParticipateIn = RPSControlFactory.CreateRPSEnumComboBox<ResourceMachineView>("df0c1b67-f059-4b84-9c53-4db2640d4852","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ResourceMachineView>("d75e7f60-5cca-4f9f-9c0b-d6ef8ee378ca","","",false, this);
 
            Planify = RPSControlFactory.CreateRPSCheckBox<ResourceMachineView>("b99e9903-3642-4e5a-87ac-1330a80e8a75","","",true, this);
 
            VariableGroup = RPSControlFactory.CreateRPSCheckBox<ResourceMachineView>("6555bd8f-d38d-4c13-accd-a6c68d5c292e","","",true, this);
 
            DedicationPercent = RPSControlFactory.CreateRPSFormattedTextBox<ResourceMachineView>("e9c43d36-5317-4679-9a77-1f3a974d3f64","","",true, this);
 
            CostQuantity = RPSControlFactory.CreateRPSFormattedTextBox<ResourceMachineView>("61f242ad-5109-47b8-8c58-7fd41891f6f6","","",true, this);
 
            Duration = RPSControlFactory.CreateRPSDurationTextBox<ResourceMachineView>("67d6ecf7-3543-457c-a2a3-d5e2070e9c3e","","",true, this);
 
            IDBudgetCategory = RPSControlFactory.CreateRPSComboBox<ResourceMachineView>("5db144c4-8936-4dce-aacd-f271ef6fc257","","",false, this);
 
            CollectionInit params_ResourceMachineAlts = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6741fd64-522c-45e4-be8d-32ee11daf4ad",CSSSelectorGrid="",XPathGrid=""};
            ResourceMachineAlts = RPSControlFactory.RPSCreateCollectionWithGrid<ResourceMachineAltsCollectionEditor<ResourceMachineView>,ResourceMachineView>( params_ResourceMachineAlts,this);
 

        }
        public IRPSButton<ResourceMachineView> DeleteButton { get; set; } 
        public IRPSButton<ResourceMachineView,TaskView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ResourceMachineView,TaskView> BackButton { get; set; } 
        public IRPSAcceptButton<ResourceMachineView,TaskView> AcceptButton { get; set; } 
        public IRPSTextBox<ResourceMachineView> CodResourceMachine { get; set; } 
        public IRPSComboBox<ResourceMachineView> IDMachine { get; set; } 
        public IRPSComboBox<ResourceMachineView> IDMachineGroup { get; set; } 
        public IRPSButton<ResourceMachineView> AddAltMachinesToGrid { get; set; } 
        public IRPSComboBox<ResourceMachineView> ParticipateIn { get; set; } 
        public IRPSTextBox<ResourceMachineView> Description { get; set; } 
        public IRPSCheckbox<ResourceMachineView> Planify { get; set; } 
        public IRPSCheckbox<ResourceMachineView> VariableGroup { get; set; } 
        public IRPSTextBox<ResourceMachineView> DedicationPercent { get; set; } 
        public IRPSTextBox<ResourceMachineView> CostQuantity { get; set; } 
        public IRPSDurationTextBox<ResourceMachineView> Duration { get; set; } 
        public IRPSComboBox<ResourceMachineView> IDBudgetCategory { get; set; } 
        public ResourceMachineAltsCollectionEditor<ResourceMachineView> ResourceMachineAlts { get; set; } 
        public Structure Screen { get; set; }
        public ResourceMachineView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ResourceMachineAltsCollectionEditor<ResourceMachineView>:RPSCollectionEditor<ResourceMachineView> where ResourceMachineView : class, IView
    {
        public  ResourceMachineAltsGridView<ResourceMachineView> GridView {get;set;}
    }
    public partial class ResourceMachineAltsGridView <ResourceMachineView> :  RPSGridView<ResourceMachineView> where ResourceMachineView : class, IView
    {
        public ResourceMachineAltsGridView(ResourceMachineView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDMachine = RPSControlFactory.CreateRPSGridComboBox<ResourceMachineView>("","#6741fd64-522c-45e4-be8d-32ee11daf4ad .ag-row[role='row']@ROWINDEX [col-id='cIDMachine']","",false, this.CurrentView);
 
            PreparationTime = RPSControlFactory.CreateRPSGridDurationTextBox<ResourceMachineView>("","#6741fd64-522c-45e4-be8d-32ee11daf4ad .ag-row[role='row']@ROWINDEX [col-id='cPreparationTime']","",true, this.CurrentView);
 
            ExecutionTime = RPSControlFactory.CreateRPSGridDurationTextBox<ResourceMachineView>("","#6741fd64-522c-45e4-be8d-32ee11daf4ad .ag-row[role='row']@ROWINDEX [col-id='cExecutionTime']","",true, this.CurrentView);
 
            ExecutionLot = RPSControlFactory.CreateRPSGridFormattedTextBox<ResourceMachineView>("","#6741fd64-522c-45e4-be8d-32ee11daf4ad .ag-row[role='row']@ROWINDEX [col-id='cExecutionLot']","",true, this.CurrentView);
 
            RepetitionTime = RPSControlFactory.CreateRPSGridDurationTextBox<ResourceMachineView>("","#6741fd64-522c-45e4-be8d-32ee11daf4ad .ag-row[role='row']@ROWINDEX [col-id='cRepetitionTime']","",true, this.CurrentView);
 
            RepetitionLot = RPSControlFactory.CreateRPSGridFormattedTextBox<ResourceMachineView>("","#6741fd64-522c-45e4-be8d-32ee11daf4ad .ag-row[role='row']@ROWINDEX [col-id='cRepetitionLot']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<ResourceMachineView> IDMachine { get; set; } 
        public IRPSGridDurationTextBox<ResourceMachineView> PreparationTime { get; set; } 
        public IRPSGridDurationTextBox<ResourceMachineView> ExecutionTime { get; set; } 
        public IRPSGridTextBox<ResourceMachineView> ExecutionLot { get; set; } 
        public IRPSGridDurationTextBox<ResourceMachineView> RepetitionTime { get; set; } 
        public IRPSGridTextBox<ResourceMachineView> RepetitionLot { get; set; } 
                     
    }
 
    }
  
            
    public partial class ResourceEmployeeView : View
    {
        public ResourceEmployeeView(Structure screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ResourceEmployeeView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ResourceEmployeeView,TaskView>( this,Screen.TaskView);
 
            BackButton = RPSControlFactory.RPSBackButton<ResourceEmployeeView,TaskView>( this,Screen.TaskView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ResourceEmployeeView,TaskView>( this,Screen.TaskView);
 
            CodResourceEmployee = RPSControlFactory.CreateRPSTextBox<ResourceEmployeeView>("2df90904-d16e-43c1-ae0a-2c8d63f3e63d","","",true, this);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<ResourceEmployeeView>("1a36da57-83ef-459b-98f5-9bed97e2b1ba","","",false, this);
 
            IDQualify = RPSControlFactory.CreateRPSComboBox<ResourceEmployeeView>("3dc47681-6e0a-4098-b445-251f70655bc0","","",true, this);
 
            ParticipateIn = RPSControlFactory.CreateRPSEnumComboBox<ResourceEmployeeView>("a06dd65e-9813-4872-9cb4-64b98484fce9","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ResourceEmployeeView>("9129bbf0-7836-434d-8d6a-197288100584","","",false, this);
 
            Planify = RPSControlFactory.CreateRPSCheckBox<ResourceEmployeeView>("4790a8db-61d3-4ebb-8f39-c89da5bba43e","","",true, this);
 
            DedicationPercent = RPSControlFactory.CreateRPSFormattedTextBox<ResourceEmployeeView>("d8963e60-f297-4f91-a545-87d1df85fd4a","","",true, this);
 
            Duration = RPSControlFactory.CreateRPSDurationTextBox<ResourceEmployeeView>("07a15b81-aef3-417f-8584-701b09b067d1","","",true, this);
 
            TimeUnit = RPSControlFactory.CreateRPSEnumComboBox<ResourceEmployeeView>("3f4b09ef-20da-4dcd-be82-9f5c488f444f","","",true, this);
 
            IDBudgetCategory = RPSControlFactory.CreateRPSComboBox<ResourceEmployeeView>("f6e57586-437a-4670-b9df-669802315d89","","",false, this);
 

        }
        public IRPSButton<ResourceEmployeeView> DeleteButton { get; set; } 
        public IRPSButton<ResourceEmployeeView,TaskView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ResourceEmployeeView,TaskView> BackButton { get; set; } 
        public IRPSAcceptButton<ResourceEmployeeView,TaskView> AcceptButton { get; set; } 
        public IRPSTextBox<ResourceEmployeeView> CodResourceEmployee { get; set; } 
        public IRPSComboBox<ResourceEmployeeView> IDEmployee { get; set; } 
        public IRPSComboBox<ResourceEmployeeView> IDQualify { get; set; } 
        public IRPSComboBox<ResourceEmployeeView> ParticipateIn { get; set; } 
        public IRPSTextBox<ResourceEmployeeView> Description { get; set; } 
        public IRPSCheckbox<ResourceEmployeeView> Planify { get; set; } 
        public IRPSTextBox<ResourceEmployeeView> DedicationPercent { get; set; } 
        public IRPSDurationTextBox<ResourceEmployeeView> Duration { get; set; } 
        public IRPSComboBox<ResourceEmployeeView> TimeUnit { get; set; } 
        public IRPSComboBox<ResourceEmployeeView> IDBudgetCategory { get; set; } 
        public Structure Screen { get; set; }
        public ResourceEmployeeView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ResourceToolView : View
    {
        public ResourceToolView(Structure screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ResourceToolView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ResourceToolView,TaskView>( this,Screen.TaskView);
 
            BackButton = RPSControlFactory.RPSBackButton<ResourceToolView,TaskView>( this,Screen.TaskView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ResourceToolView,TaskView>( this,Screen.TaskView);
 
            CodResourceTool = RPSControlFactory.CreateRPSTextBox<ResourceToolView>("2aa1a2ed-a1a5-4e25-a94c-132c4131bd2e","","",false, this);
 
            IDTool = RPSControlFactory.CreateRPSComboBox<ResourceToolView>("2199e241-9d80-4b45-8e24-00a853d1c6a9","","",true, this);
 
            IDResourceEmployee = RPSControlFactory.CreateRPSComboBox<ResourceToolView>("5b79cf29-1ff3-4738-bb96-bff46a13f792","","",false, this);
 
            ParticipateIn = RPSControlFactory.CreateRPSEnumComboBox<ResourceToolView>("940bdacf-b4ad-44de-82f3-40fa513626ba","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ResourceToolView>("9bc7ba78-e3ed-4763-a137-7d26dc95c78d","","",false, this);
 
            Planify = RPSControlFactory.CreateRPSCheckBox<ResourceToolView>("caeca979-9194-4545-9ab5-60f953745d39","","",true, this);
 
            DedicationPercent = RPSControlFactory.CreateRPSFormattedTextBox<ResourceToolView>("69776a26-7227-4d41-9282-3fc8a828bb5f","","",true, this);
 
            Duration = RPSControlFactory.CreateRPSDurationTextBox<ResourceToolView>("b74528c2-413b-4e20-ac58-12e189f5b7f0","","",true, this);
 
            IDBudgetCategory = RPSControlFactory.CreateRPSComboBox<ResourceToolView>("54b5aaac-92a8-4f5d-83bb-7e9d6176ac81","","",false, this);
 

        }
        public IRPSButton<ResourceToolView> DeleteButton { get; set; } 
        public IRPSButton<ResourceToolView,TaskView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ResourceToolView,TaskView> BackButton { get; set; } 
        public IRPSAcceptButton<ResourceToolView,TaskView> AcceptButton { get; set; } 
        public IRPSTextBox<ResourceToolView> CodResourceTool { get; set; } 
        public IRPSComboBox<ResourceToolView> IDTool { get; set; } 
        public IRPSComboBox<ResourceToolView> IDResourceEmployee { get; set; } 
        public IRPSComboBox<ResourceToolView> ParticipateIn { get; set; } 
        public IRPSTextBox<ResourceToolView> Description { get; set; } 
        public IRPSCheckbox<ResourceToolView> Planify { get; set; } 
        public IRPSTextBox<ResourceToolView> DedicationPercent { get; set; } 
        public IRPSDurationTextBox<ResourceToolView> Duration { get; set; } 
        public IRPSComboBox<ResourceToolView> IDBudgetCategory { get; set; } 
        public Structure Screen { get; set; }
        public ResourceToolView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaterialView : View
    {
        public MaterialView(Structure screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaterialView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaterialView,TaskView>( this,Screen.TaskView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaterialView,TaskView>( this,Screen.TaskView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MaterialView,TaskView>( this,Screen.TaskView);
 
            CodMaterial = RPSControlFactory.CreateRPSTextBox<MaterialView>("8bb1258d-8abb-4df7-9155-cb0f1e65b07d","","",true, this);
 
            ArticleType = RPSControlFactory.CreateRPSEnumComboBox<MaterialView>("97d002fb-9143-48d9-be1f-f8901633b3d9","","",true, this);
 
            UIArticleType = RPSControlFactory.CreateRPSEnumComboBox<MaterialView>("3b64b032-c528-4549-aea5-457e6a850016","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<MaterialView>("3a724a26-a08a-4f62-8610-1fb7fb474081","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MaterialView>("c8c307f6-b97a-4c3c-9901-bcc2abb43a8d","","",false, this);
 
            MaterialType = RPSControlFactory.CreateRPSEnumComboBox<MaterialView>("b14bf220-d79b-494d-a3a5-0d802df1bcf8","","",true, this);
 
            QuantityType = RPSControlFactory.CreateRPSEnumComboBox<MaterialView>("86cf1e77-6dd8-4ee6-b662-889d09874faf","","",true, this);
 
            QuantityPercent = RPSControlFactory.CreateRPSFormattedTextBox<MaterialView>("0bab6eb7-0313-4dd4-bd4b-c8483e24ac9b","","",true, this);
 
            QuantitySource = RPSControlFactory.CreateRPSEnumComboBox<MaterialView>("28df101a-7c82-425a-a2be-6a2dc63abdc2","","",true, this);
 
            Formula = RPSControlFactory.CreateRPSTextBox<MaterialView>("bacb92ca-9806-487f-af3a-63bcdd59bca1","","",false, this);
 
            StructureFormulaNavComm = RPSControlFactory.CreateRPSButtonToView<MaterialView,StructureFormulaDV>("4f57e570-b089-419e-98c1-8f93bc05d741","","", this,Screen.StructureFormulaDV);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<MaterialView>("77161553-7083-44e7-b03f-13ad2643f32a","","",true, this);
 
            ContentLot = RPSControlFactory.CreateRPSFormattedTextBox<MaterialView>("ebd07be9-2ed7-485a-a116-46ebf1eb9c76","","",true, this);
 
            QuantityElements = RPSControlFactory.CreateRPSFormattedTextBox<MaterialView>("2a24eda7-912d-4c9d-862c-e9cff1e6ab87","","",true, this);
 
            CADFileVersion = RPSControlFactory.CreateRPSTextBox<MaterialView>("47ae5f28-a7d7-4083-a933-40fa01e07edf","","",false, this);
 
            AdvanceDays = RPSControlFactory.CreateRPSFormattedTextBox<MaterialView>("3786daac-22dc-42da-8714-80edbe3f0314","","",true, this);
 
            IDBudgetCategory = RPSControlFactory.CreateRPSComboBox<MaterialView>("1ec6d50f-08c8-4c1c-950d-c0dddcda70c3","","",false, this);
 
            MakeAutomaticOutput = RPSControlFactory.CreateRPSCheckBox<MaterialView>("d8b43555-bfc4-4142-9db1-1fdb3252e2a8","","",true, this);
 
            UseAlternativeArticles = RPSControlFactory.CreateRPSCheckBox<MaterialView>("e5dac84f-c464-43d7-beb4-7df683686496","","",true, this);
 
            ImputationCostUpdated = RPSControlFactory.CreateRPSCheckBox<MaterialView>("bbe99dc5-b324-4239-9261-6db40ccccb8e","","",true, this);
 
            Critical = RPSControlFactory.CreateRPSCheckBox<MaterialView>("83995f17-5739-451c-9825-a2718d3275fa","","",true, this);
 
            ManualConsumption = RPSControlFactory.CreateRPSCheckBox<MaterialView>("95f64a1c-23ff-41b6-802b-48b22fb80d3e","","",true, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<MaterialView>("91429737-9e8c-4e5f-8097-b1467af03e1d","","",true, this);
 
            IDWareHouse = RPSControlFactory.CreateRPSComboBox<MaterialView>("cf91ced1-6bbd-4081-b9a4-8afa05ff5bf4","","",false, this);
 
            Notes = RPSControlFactory.CreateRPSTextBox<MaterialView>("51d5092a-9648-4b90-80ac-5ba9586a45a0","","",false, this);
 
            DateActiveFrom = RPSControlFactory.CreateRPSTextBox<MaterialView>("61b5c9b0-9cde-420b-bc2c-f57c5927cd99","","",false, this);
 
            DateActiveTo = RPSControlFactory.CreateRPSTextBox<MaterialView>("cff0170b-1147-459a-a136-359b69a8aff8","","",false, this);
 
            MatchCode = RPSControlFactory.CreateRPSTextBox<MaterialView>("407d0e59-ef3b-49fa-b520-2cae7180b999","","",false, this);
 
            IsMandatory = RPSControlFactory.CreateRPSCheckBox<MaterialView>("d62d7ac1-53d9-46d3-bc25-8dd2d07dbfc1","","",true, this);
 
            CollectionInit params_MaterialAlternatives = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="44118c48-951f-41ef-aa1e-618d5c9de349",CSSSelectorGrid="",XPathGrid=""};
            MaterialAlternatives = RPSControlFactory.RPSCreateCollectionWithGrid<MaterialAlternativesCollectionEditor<MaterialView,MaterialAlternativeView>,MaterialView,MaterialAlternativeView>( params_MaterialAlternatives,this,Screen.MaterialAlternativeView);
 
            SectionData = RPSControlFactory.CreateRPSSection<MaterialView>( "","ul li[rpsid='81bea0dc-0077-4e74-af70-b12ac4c39adc']","",this);
 
            SectionArticleAlternative = RPSControlFactory.CreateRPSSection<MaterialView>( "","ul li[rpsid='9356fcf1-1a41-4d49-9b84-41f0ebef6f69']","",this);
 
            SectionDPS = RPSControlFactory.CreateRPSSection<MaterialView>( "","ul li[rpsid='fb718ff1-7a58-4cdb-962b-0f9dfea90d5a']","",this);
 

        }
        public IRPSButton<MaterialView> DeleteButton { get; set; } 
        public IRPSButton<MaterialView,TaskView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaterialView,TaskView> BackButton { get; set; } 
        public IRPSAcceptButton<MaterialView,TaskView> AcceptButton { get; set; } 
        public IRPSTextBox<MaterialView> CodMaterial { get; set; } 
        public IRPSComboBox<MaterialView> ArticleType { get; set; } 
        public IRPSComboBox<MaterialView> UIArticleType { get; set; } 
        public IRPSComboBox<MaterialView> IDArticle { get; set; } 
        public IRPSTextBox<MaterialView> Description { get; set; } 
        public IRPSComboBox<MaterialView> MaterialType { get; set; } 
        public IRPSComboBox<MaterialView> QuantityType { get; set; } 
        public IRPSTextBox<MaterialView> QuantityPercent { get; set; } 
        public IRPSComboBox<MaterialView> QuantitySource { get; set; } 
        public IRPSTextBox<MaterialView> Formula { get; set; } 
        public IRPSButton<MaterialView,StructureFormulaDV> StructureFormulaNavComm { get; set; } 
        public IRPSTextBox<MaterialView> Quantity { get; set; } 
        public IRPSTextBox<MaterialView> ContentLot { get; set; } 
        public IRPSTextBox<MaterialView> QuantityElements { get; set; } 
        public IRPSTextBox<MaterialView> CADFileVersion { get; set; } 
        public IRPSTextBox<MaterialView> AdvanceDays { get; set; } 
        public IRPSComboBox<MaterialView> IDBudgetCategory { get; set; } 
        public IRPSCheckbox<MaterialView> MakeAutomaticOutput { get; set; } 
        public IRPSCheckbox<MaterialView> UseAlternativeArticles { get; set; } 
        public IRPSCheckbox<MaterialView> ImputationCostUpdated { get; set; } 
        public IRPSCheckbox<MaterialView> Critical { get; set; } 
        public IRPSCheckbox<MaterialView> ManualConsumption { get; set; } 
        public IRPSComboBox<MaterialView> IDSite { get; set; } 
        public IRPSComboBox<MaterialView> IDWareHouse { get; set; } 
        public IRPSTextBox<MaterialView> Notes { get; set; } 
        public IRPSTextBox<MaterialView> DateActiveFrom { get; set; } 
        public IRPSTextBox<MaterialView> DateActiveTo { get; set; } 
        public IRPSTextBox<MaterialView> MatchCode { get; set; } 
        public IRPSCheckbox<MaterialView> IsMandatory { get; set; } 
        public MaterialAlternativesCollectionEditor<MaterialView,MaterialAlternativeView> MaterialAlternatives { get; set; } 
        public IRPSSection<MaterialView> SectionData { get; set; } 
        public IRPSSection<MaterialView> SectionArticleAlternative { get; set; } 
        public IRPSSection<MaterialView> SectionDPS { get; set; } 
        public Structure Screen { get; set; }
        public MaterialView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaterialAlternativesCollectionEditor<MaterialView,MaterialAlternativeView>:RPSCollectionEditor<MaterialView,MaterialAlternativeView> where MaterialView : class, IView where MaterialAlternativeView : class, IView
    {
        public  MaterialAlternativesGridView<MaterialView,MaterialAlternativeView> GridView {get;set;}
    }
    public partial class MaterialAlternativesGridView <MaterialView,MaterialAlternativeView> :  RPSGridView<MaterialView,MaterialAlternativeView> where MaterialView : class, IView where MaterialAlternativeView : class, IView
    {
        public MaterialAlternativesGridView(MaterialView currentView,MaterialAlternativeView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<MaterialView>("","#44118c48-951f-41ef-aa1e-618d5c9de349 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            Priority = RPSControlFactory.CreateRPSGridFormattedTextBox<MaterialView>("","#44118c48-951f-41ef-aa1e-618d5c9de349 .ag-row[role='row']@ROWINDEX [col-id='cPriority']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<MaterialView> IDArticle { get; set; } 
        public IRPSGridTextBox<MaterialView> Priority { get; set; } 
                     
    }
 
    }
  
            
    public partial class MaterialAlternativeView : View
    {
        public MaterialAlternativeView(Structure screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaterialAlternativeView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaterialAlternativeView,MaterialView>( this,Screen.MaterialView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaterialAlternativeView,MaterialView>( this,Screen.MaterialView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MaterialAlternativeView,MaterialView>( this,Screen.MaterialView);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<MaterialAlternativeView>("b6746c77-2518-4851-85b5-8caaf6b3aee0","","",true, this);
 
            Priority = RPSControlFactory.CreateRPSFormattedTextBox<MaterialAlternativeView>("97aa9b46-922e-4ae8-9c0c-89d1399cebf2","","",true, this);
 

        }
        public IRPSButton<MaterialAlternativeView> DeleteButton { get; set; } 
        public IRPSButton<MaterialAlternativeView,MaterialView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaterialAlternativeView,MaterialView> BackButton { get; set; } 
        public IRPSAcceptButton<MaterialAlternativeView,MaterialView> AcceptButton { get; set; } 
        public IRPSComboBox<MaterialAlternativeView> IDArticle { get; set; } 
        public IRPSTextBox<MaterialAlternativeView> Priority { get; set; } 
        public Structure Screen { get; set; }
        public MaterialAlternativeView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class TaskCostComponentView : View
    {
        public TaskCostComponentView(Structure screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<TaskCostComponentView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<TaskCostComponentView,TaskView>( this,Screen.TaskView);
 
            BackButton = RPSControlFactory.RPSBackButton<TaskCostComponentView,TaskView>( this,Screen.TaskView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<TaskCostComponentView,TaskView>( this,Screen.TaskView);
 
            CodTaskCostComponent = RPSControlFactory.CreateRPSTextBox<TaskCostComponentView>("daf8dd0b-0d9b-4503-814a-b002eb1e2dc0","","",true, this);
 
            IDCostComponent = RPSControlFactory.CreateRPSComboBox<TaskCostComponentView>("960f435f-2f87-422f-8ffd-2a25d7e93571","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<TaskCostComponentView>("9f29a7ca-0744-403e-a143-ecccf3afa6f8","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<TaskCostComponentView>("235066c7-0272-42c4-ba90-0f2a23b7ba72","","",true, this);
 
            Price = RPSControlFactory.CreateRPSFormattedTextBox<TaskCostComponentView>("fd25962e-49b0-4445-973d-b0d8f6e9e558","","",true, this);
 
            IDBudgetCategory = RPSControlFactory.CreateRPSComboBox<TaskCostComponentView>("d6b1da11-e024-415f-99b9-7a44f31e30b9","","",false, this);
 

        }
        public IRPSButton<TaskCostComponentView> DeleteButton { get; set; } 
        public IRPSButton<TaskCostComponentView,TaskView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<TaskCostComponentView,TaskView> BackButton { get; set; } 
        public IRPSAcceptButton<TaskCostComponentView,TaskView> AcceptButton { get; set; } 
        public IRPSTextBox<TaskCostComponentView> CodTaskCostComponent { get; set; } 
        public IRPSComboBox<TaskCostComponentView> IDCostComponent { get; set; } 
        public IRPSTextBox<TaskCostComponentView> Description { get; set; } 
        public IRPSTextBox<TaskCostComponentView> Quantity { get; set; } 
        public IRPSTextBox<TaskCostComponentView> Price { get; set; } 
        public IRPSComboBox<TaskCostComponentView> IDBudgetCategory { get; set; } 
        public Structure Screen { get; set; }
        public TaskCostComponentView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class TaskDimensionView : View
    {
        public TaskDimensionView(Structure screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<TaskDimensionView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<TaskDimensionView,TaskView>( this,Screen.TaskView);
 
            BackButton = RPSControlFactory.RPSBackButton<TaskDimensionView,TaskView>( this,Screen.TaskView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<TaskDimensionView,TaskView>( this,Screen.TaskView);
 
            IDDimension = RPSControlFactory.CreateRPSComboBox<TaskDimensionView>("8d8b5ac1-92c8-4934-9999-bf5d56695260","","",true, this);
 
            IDDimValue = RPSControlFactory.CreateRPSComboBox<TaskDimensionView>("91923442-335d-4510-b582-b5996bcc32b6","","",true, this);
 
            Percentage = RPSControlFactory.CreateRPSFormattedTextBox<TaskDimensionView>("ceebfcb1-3ddf-49db-8120-295133d812dd","","",true, this);
 

        }
        public IRPSButton<TaskDimensionView> DeleteButton { get; set; } 
        public IRPSButton<TaskDimensionView,TaskView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<TaskDimensionView,TaskView> BackButton { get; set; } 
        public IRPSAcceptButton<TaskDimensionView,TaskView> AcceptButton { get; set; } 
        public IRPSComboBox<TaskDimensionView> IDDimension { get; set; } 
        public IRPSComboBox<TaskDimensionView> IDDimValue { get; set; } 
        public IRPSTextBox<TaskDimensionView> Percentage { get; set; } 
        public Structure Screen { get; set; }
        public TaskDimensionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class StructureRoutesView : View
    {
        public StructureRoutesView(Structure screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public Structure Screen { get; set; }
        public StructureRoutesView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class StructureDetailView : View
    {
        public StructureDetailView(Structure screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UI_ConsultDate = RPSControlFactory.CreateRPSTextBox<StructureDetailView>("57cb3767-decb-4c8f-88be-8d493561c91b","","",true, this);
 
            UI_ViewAllMaterials = RPSControlFactory.CreateRPSCheckBox<StructureDetailView>("73c60dfb-1cf6-49a6-ba97-dbe88b520b7d","","",false, this);
 
            UI_AllRoutes = RPSControlFactory.CreateRPSCheckBox<StructureDetailView>("77c5f9c7-5e25-4d97-818d-11872007c8a1","","",false, this);
 
            UI_SelectedRoute = RPSControlFactory.CreateRPSComboBox<StructureDetailView>("a8fa0802-890f-4d0b-9a2b-e6e84713fd58","","",false, this);
 
            UIPropagateRoute = RPSControlFactory.CreateRPSCheckBox<StructureDetailView>("3ccf8e92-7d04-4bc1-9699-c266e16300d1","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<StructureDetailView>("09e713c5-5ef3-485e-a5f7-b5e4f90ff8b4","","",true, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<StructureDetailView>("9f7e0de3-345c-4928-a82f-f68742e68323","","",true, this);
 
            Version = RPSControlFactory.CreateRPSTextBox<StructureDetailView>("58ab45a3-b1c3-4548-92c3-e39366ba47f3","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<StructureDetailView>("b64bf9a9-561b-4098-a36d-1c778870f319","","",false, this);
 
            Active = RPSControlFactory.CreateRPSCheckBox<StructureDetailView>("031dc1da-e7d8-430b-a98b-37703e259402","","",true, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<StructureDetailView>("562e7b2e-4a49-41a4-aa50-6abad5a17e9a","","",false, this);
 
            AutomaticCodification = RPSControlFactory.CreateRPSCheckBox<StructureDetailView>("e1587342-ce16-435f-96d7-12ff1c39eb10","","",true, this);
 
            TimeUnitDefault = RPSControlFactory.CreateRPSEnumComboBox<StructureDetailView>("1c963ba8-ac17-42ce-8b1e-d09ae1f41f1b","","",true, this);
 
            IDStructureType = RPSControlFactory.CreateRPSComboBox<StructureDetailView>("61f2514e-a182-4318-9804-b8bce6242aaa","","",false, this);
 
            PlanningDirection = RPSControlFactory.CreateRPSEnumComboBox<StructureDetailView>("3f1e52f3-cb88-4c60-bd78-8eca2ad82352","","",true, this);
 
            IDWareHouse = RPSControlFactory.CreateRPSComboBox<StructureDetailView>("3ab4bfe8-e437-4c4b-9bda-f888ee2135a0","","",false, this);
 
            QuantityBaseFormula = RPSControlFactory.CreateRPSFormattedTextBox<StructureDetailView>("2cccf74f-42a7-4dff-a1f8-630bd400ed3e","","",true, this);
 
            IDUnitBaseFormula = RPSControlFactory.CreateRPSComboBox<StructureDetailView>("be605b94-8358-4687-bcfc-5811392db5b1","","",false, this);
 
            Notes = RPSControlFactory.CreateRPSTextBox<StructureDetailView>("79ae1a47-bcf3-4240-8c8b-a4a4fa749126","","",false, this);
 
            NewTaskCommandButton = RPSControlFactory.CreateRPSButton<StructureDetailView>( "1b94c83e-fbf4-4be1-8de2-4dcbbe3136b3","","",this);
 
            NewFeatureCommandButton = RPSControlFactory.CreateRPSButton<StructureDetailView>( "cac87b37-f60f-4b63-91b7-c80c4d999be7","","",this);
 
            NewDimensionCommandButton = RPSControlFactory.CreateRPSButton<StructureDetailView>( "388d0d12-0d3e-443f-a4ef-7d04a01a90e0","","",this);
 
            ChangeRoutesCommand = RPSControlFactory.CreateRPSButton<StructureDetailView>( "7e47b975-6c2c-4dbd-ba3f-d99021470b10","","",this);
 
            AddStructureRouteNavigationCommand = RPSControlFactory.CreateRPSButtonToView<StructureDetailView,AddStructureRouteDialogView>("39b954da-7e4d-4302-bfb3-986d90d8479b","","", this,Screen.AddStructureRouteDialogView);
 
            CopyStructureRouteNavigationCommand = RPSControlFactory.CreateRPSButtonToView<StructureDetailView,CopyStructureRouteDialogView>("3b2680cf-43a7-450d-916d-e1dafcf7e1e1","","", this,Screen.CopyStructureRouteDialogView);
 
            DeleteStructureRouteNavigationCommand = RPSControlFactory.CreateRPSButtonToView<StructureDetailView,DeleteStructureRouteDialogView>("85b72df1-a64d-4449-a109-d450e45646dc","","", this,Screen.DeleteStructureRouteDialogView);
 
            LinkNavigationCommandButton = RPSControlFactory.CreateRPSButton<StructureDetailView>( "d4ea405f-f004-4b52-84f6-97bbfc744494","","",this);
 
            ExecuteStructureCheckPercentageMaterialsButton = RPSControlFactory.CreateRPSButton<StructureDetailView>( "c5620025-fc9d-4be7-b56f-43217f584c08","","",this);
 
            LinkNavigationCommandStructureCostButton = RPSControlFactory.CreateRPSButton<StructureDetailView>( "a037cd86-5dfa-46cf-9c88-78766bc5e54a","","",this);
 
            LinkNavigationCommandMaterialStructureButton = RPSControlFactory.CreateRPSButton<StructureDetailView>( "57fd1025-3a78-4a6e-af10-a1dd028324de","","",this);
 
            CollectionInit params_Tasks = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="2460a20e-2fb4-4a53-84ef-e82c9d3ecc08",CSSSelectorGrid="",XPathGrid=""};
            Tasks = RPSControlFactory.RPSCreateCollectionWithGrid<TasksCollectionEditor<StructureDetailView,AddStructureRouteDialogView>,StructureDetailView,AddStructureRouteDialogView>( params_Tasks,this,Screen.AddStructureRouteDialogView);
 
            CollectionInit params_StructureFeatures = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a2dba43b-7f46-4d44-af88-39a119955ee7",CSSSelectorGrid="",XPathGrid=""};
            StructureFeatures = RPSControlFactory.RPSCreateCollectionWithGrid<StructureFeaturesCollectionEditor<StructureDetailView,AddStructureRouteDialogView>,StructureDetailView,AddStructureRouteDialogView>( params_StructureFeatures,this,Screen.AddStructureRouteDialogView);
 
            CollectionInit params_StructureDimensions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d3bdb4c1-4882-46fa-8eac-25d7914f61ff",CSSSelectorGrid="",XPathGrid=""};
            StructureDimensions = RPSControlFactory.RPSCreateCollectionWithGrid<StructureDimensionsCollectionEditor<StructureDetailView,AddStructureRouteDialogView>,StructureDetailView,AddStructureRouteDialogView>( params_StructureDimensions,this,Screen.AddStructureRouteDialogView);
 
            SectionGeneralData = RPSControlFactory.CreateRPSSection<StructureDetailView>( "","ul li[rpsid='2c4c1c5f-58e0-40b9-a860-2569d410a79b']","",this);
 
            SectionTasks = RPSControlFactory.CreateRPSSection<StructureDetailView>( "","ul li[rpsid='a3a0e67f-b12c-4e37-9e79-2a41c5cc89a2']","",this);
 
            SectionFeatures = RPSControlFactory.CreateRPSSection<StructureDetailView>( "","ul li[rpsid='b69f5af1-b2ef-45bf-8a56-0e8a767cc155']","",this);
 
            SectionDimensions = RPSControlFactory.CreateRPSSection<StructureDetailView>( "","ul li[rpsid='732d6ce6-7c77-4d2f-abf3-8caa8c8738cb']","",this);
 
            SectionStructureRoutes = RPSControlFactory.CreateRPSSection<StructureDetailView>( "","ul li[rpsid='cb767a08-cf25-4209-8311-1f3c6f4713a2']","",this);
 

        }
        public IRPSTextBox<StructureDetailView> UI_ConsultDate { get; set; } 
        public IRPSCheckbox<StructureDetailView> UI_ViewAllMaterials { get; set; } 
        public IRPSCheckbox<StructureDetailView> UI_AllRoutes { get; set; } 
        public IRPSComboBox<StructureDetailView> UI_SelectedRoute { get; set; } 
        public IRPSCheckbox<StructureDetailView> UIPropagateRoute { get; set; } 
        public IRPSComboBox<StructureDetailView> IDSite { get; set; } 
        public IRPSComboBox<StructureDetailView> IDArticle { get; set; } 
        public IRPSTextBox<StructureDetailView> Version { get; set; } 
        public IRPSTextBox<StructureDetailView> Description { get; set; } 
        public IRPSCheckbox<StructureDetailView> Active { get; set; } 
        public IRPSTextBox<StructureDetailView> DateFrom { get; set; } 
        public IRPSCheckbox<StructureDetailView> AutomaticCodification { get; set; } 
        public IRPSComboBox<StructureDetailView> TimeUnitDefault { get; set; } 
        public IRPSComboBox<StructureDetailView> IDStructureType { get; set; } 
        public IRPSComboBox<StructureDetailView> PlanningDirection { get; set; } 
        public IRPSComboBox<StructureDetailView> IDWareHouse { get; set; } 
        public IRPSTextBox<StructureDetailView> QuantityBaseFormula { get; set; } 
        public IRPSComboBox<StructureDetailView> IDUnitBaseFormula { get; set; } 
        public IRPSTextBox<StructureDetailView> Notes { get; set; } 
        public IRPSButton<StructureDetailView> NewTaskCommandButton { get; set; } 
        public IRPSButton<StructureDetailView> NewFeatureCommandButton { get; set; } 
        public IRPSButton<StructureDetailView> NewDimensionCommandButton { get; set; } 
        public IRPSButton<StructureDetailView> ChangeRoutesCommand { get; set; } 
        public IRPSButton<StructureDetailView,AddStructureRouteDialogView> AddStructureRouteNavigationCommand { get; set; } 
        public IRPSButton<StructureDetailView,CopyStructureRouteDialogView> CopyStructureRouteNavigationCommand { get; set; } 
        public IRPSButton<StructureDetailView,DeleteStructureRouteDialogView> DeleteStructureRouteNavigationCommand { get; set; } 
        public IRPSButton<StructureDetailView> LinkNavigationCommandButton { get; set; } 
        public IRPSButton<StructureDetailView> ExecuteStructureCheckPercentageMaterialsButton { get; set; } 
        public IRPSButton<StructureDetailView> LinkNavigationCommandStructureCostButton { get; set; } 
        public IRPSButton<StructureDetailView> LinkNavigationCommandMaterialStructureButton { get; set; } 
        public TasksCollectionEditor<StructureDetailView,AddStructureRouteDialogView> Tasks { get; set; } 
        public StructureFeaturesCollectionEditor<StructureDetailView,AddStructureRouteDialogView> StructureFeatures { get; set; } 
        public StructureDimensionsCollectionEditor<StructureDetailView,AddStructureRouteDialogView> StructureDimensions { get; set; } 
        public IRPSSection<StructureDetailView> SectionGeneralData { get; set; } 
        public IRPSSection<StructureDetailView> SectionTasks { get; set; } 
        public IRPSSection<StructureDetailView> SectionFeatures { get; set; } 
        public IRPSSection<StructureDetailView> SectionDimensions { get; set; } 
        public IRPSSection<StructureDetailView> SectionStructureRoutes { get; set; } 
        public Structure Screen { get; set; }
        public StructureDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class TasksCollectionEditor<StructureDetailView,AddStructureRouteDialogView>:RPSCollectionEditor<StructureDetailView,AddStructureRouteDialogView> where StructureDetailView : class, IView where AddStructureRouteDialogView : class, IView
    {
        public  TasksGridView<StructureDetailView,AddStructureRouteDialogView> GridView {get;set;}
    }
    public partial class TasksGridView <StructureDetailView,AddStructureRouteDialogView> :  RPSGridView<StructureDetailView,AddStructureRouteDialogView> where StructureDetailView : class, IView where AddStructureRouteDialogView : class, IView
    {
        public TasksGridView(StructureDetailView currentView,AddStructureRouteDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            TaskType = RPSControlFactory.CreateRPSGridEnumComboBox<StructureDetailView>("","#2460a20e-2fb4-4a53-84ef-e82c9d3ecc08 .ag-row[role='row']@ROWINDEX [col-id='cTaskType']","",true, this.CurrentView);
 
            CodTask = RPSControlFactory.CreateRPSGridTextBox<StructureDetailView>("","#2460a20e-2fb4-4a53-84ef-e82c9d3ecc08 .ag-row[role='row']@ROWINDEX [col-id='cCodTask']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<StructureDetailView>("","#2460a20e-2fb4-4a53-84ef-e82c9d3ecc08 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            IDTaskParent = RPSControlFactory.CreateRPSGridComboBox<StructureDetailView>("","#2460a20e-2fb4-4a53-84ef-e82c9d3ecc08 .ag-row[role='row']@ROWINDEX [col-id='cIDTaskParent']","",false, this.CurrentView);
 
            PreparationTime = RPSControlFactory.CreateRPSGridDurationTextBox<StructureDetailView>("","#2460a20e-2fb4-4a53-84ef-e82c9d3ecc08 .ag-row[role='row']@ROWINDEX [col-id='cPreparationTime']","",true, this.CurrentView);
 
            ExecutionTime = RPSControlFactory.CreateRPSGridDurationTextBox<StructureDetailView>("","#2460a20e-2fb4-4a53-84ef-e82c9d3ecc08 .ag-row[role='row']@ROWINDEX [col-id='cExecutionTime']","",true, this.CurrentView);
 
            External = RPSControlFactory.CreateRPSGridCheckBox<StructureDetailView>("","#2460a20e-2fb4-4a53-84ef-e82c9d3ecc08 .ag-row[role='row']@ROWINDEX [col-id='cExternal']","",true, this.CurrentView);
 
            Order = RPSControlFactory.CreateRPSGridFormattedTextBox<StructureDetailView>("","#2460a20e-2fb4-4a53-84ef-e82c9d3ecc08 .ag-row[role='row']@ROWINDEX [col-id='cOrder']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<StructureDetailView> TaskType { get; set; } 
        public IRPSGridTextBox<StructureDetailView> CodTask { get; set; } 
        public IRPSGridTextBox<StructureDetailView> Description { get; set; } 
        public IRPSGridComboBox<StructureDetailView> IDTaskParent { get; set; } 
        public IRPSGridDurationTextBox<StructureDetailView> PreparationTime { get; set; } 
        public IRPSGridDurationTextBox<StructureDetailView> ExecutionTime { get; set; } 
        public IRPSGridCheckbox<StructureDetailView> External { get; set; } 
        public IRPSGridTextBox<StructureDetailView> Order { get; set; } 
                     
    }
 
        public partial class StructureFeaturesCollectionEditor<StructureDetailView,AddStructureRouteDialogView>:RPSCollectionEditor<StructureDetailView,AddStructureRouteDialogView> where StructureDetailView : class, IView where AddStructureRouteDialogView : class, IView
    {
        public  StructureFeaturesGridView<StructureDetailView,AddStructureRouteDialogView> GridView {get;set;}
    }
    public partial class StructureFeaturesGridView <StructureDetailView,AddStructureRouteDialogView> :  RPSGridView<StructureDetailView,AddStructureRouteDialogView> where StructureDetailView : class, IView where AddStructureRouteDialogView : class, IView
    {
        public StructureFeaturesGridView(StructureDetailView currentView,AddStructureRouteDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDFeatureLabel = RPSControlFactory.CreateRPSGridComboBox<StructureDetailView>("","#a2dba43b-7f46-4d44-af88-39a119955ee7 .ag-row[role='row']@ROWINDEX [col-id='cIDFeatureLabel']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<StructureDetailView> IDFeatureLabel { get; set; } 
                     
    }
 
        public partial class StructureDimensionsCollectionEditor<StructureDetailView,AddStructureRouteDialogView>:RPSCollectionEditor<StructureDetailView,AddStructureRouteDialogView> where StructureDetailView : class, IView where AddStructureRouteDialogView : class, IView
    {
        public  StructureDimensionsGridView<StructureDetailView,AddStructureRouteDialogView> GridView {get;set;}
    }
    public partial class StructureDimensionsGridView <StructureDetailView,AddStructureRouteDialogView> :  RPSGridView<StructureDetailView,AddStructureRouteDialogView> where StructureDetailView : class, IView where AddStructureRouteDialogView : class, IView
    {
        public StructureDimensionsGridView(StructureDetailView currentView,AddStructureRouteDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDDimension = RPSControlFactory.CreateRPSGridComboBox<StructureDetailView>("","#d3bdb4c1-4882-46fa-8eac-25d7914f61ff .ag-row[role='row']@ROWINDEX [col-id='cIDDimension']","",true, this.CurrentView);
 
            IDDimValue = RPSControlFactory.CreateRPSGridComboBox<StructureDetailView>("","#d3bdb4c1-4882-46fa-8eac-25d7914f61ff .ag-row[role='row']@ROWINDEX [col-id='cIDDimValue']","",true, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<StructureDetailView>("","#d3bdb4c1-4882-46fa-8eac-25d7914f61ff .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<StructureDetailView> IDDimension { get; set; } 
        public IRPSGridComboBox<StructureDetailView> IDDimValue { get; set; } 
        public IRPSGridTextBox<StructureDetailView> Percentage { get; set; } 
                     
    }
 
    }
  
            
    public partial class DuplicateStructureDialogView : View
    {
        public DuplicateStructureDialogView(Structure screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            OriginSite = RPSControlFactory.CreateRPSComboBox<DuplicateStructureDialogView>("fcf8d361-7726-4588-8079-34cc8606c7af","","",false, this);
 
            OriginArticle = RPSControlFactory.CreateRPSComboBox<DuplicateStructureDialogView>("8a223f0f-8021-44f8-99b7-206eaacc9192","","",false, this);
 
            OriginVersion = RPSControlFactory.CreateRPSEnumComboBox<DuplicateStructureDialogView>("5e7d4131-ac3f-42e5-a99f-3b575af36775","","",false, this);
 
            DestinationSite = RPSControlFactory.CreateRPSComboBox<DuplicateStructureDialogView>("2e5bbfba-b22d-4a9c-8e16-bdf0cf55dc33","","",false, this);
 
            DestinationArticle = RPSControlFactory.CreateRPSComboBox<DuplicateStructureDialogView>("ceef8eba-73a4-4a93-a1e0-2c651472f68f","","",false, this);
 
            DestinationVersion = RPSControlFactory.CreateRPSTextBox<DuplicateStructureDialogView>("667b2baa-841a-446b-9d5d-6654b6d2ab5f","","",false, this);
 
            Route = RPSControlFactory.CreateRPSComboBox<DuplicateStructureDialogView>("b6c18473-3ff2-4da7-89c6-25a38416914f","","",false, this);
 
            CopyQualityDocumentation = RPSControlFactory.CreateRPSCheckBox<DuplicateStructureDialogView>("57901f8f-fda6-4434-a8eb-eaca407e4630","","",false, this);
 
            CopyTimeOutMaterials = RPSControlFactory.CreateRPSCheckBox<DuplicateStructureDialogView>("c7138ccb-2261-4781-b805-2993475ae98e","","",false, this);
 
            StructureQualityVersion = RPSControlFactory.CreateRPSTextBox<DuplicateStructureDialogView>("1b99dd91-3324-4432-a3b4-7d3b9a4249a3","","",false, this);
 
            StructureQualityDrawingLevel = RPSControlFactory.CreateRPSTextBox<DuplicateStructureDialogView>("5d7ce104-55ad-443a-bcab-b7be27f4dcb0","","",false, this);
 
            StructureQualityDrawingDate = RPSControlFactory.CreateRPSTextBox<DuplicateStructureDialogView>("d43603a5-d031-4301-990c-cce2d42df536","","",false, this);
 

        }
        public IRPSComboBox<DuplicateStructureDialogView> OriginSite { get; set; } 
        public IRPSComboBox<DuplicateStructureDialogView> OriginArticle { get; set; } 
        public IRPSComboBox<DuplicateStructureDialogView> OriginVersion { get; set; } 
        public IRPSComboBox<DuplicateStructureDialogView> DestinationSite { get; set; } 
        public IRPSComboBox<DuplicateStructureDialogView> DestinationArticle { get; set; } 
        public IRPSTextBox<DuplicateStructureDialogView> DestinationVersion { get; set; } 
        public IRPSComboBox<DuplicateStructureDialogView> Route { get; set; } 
        public IRPSCheckbox<DuplicateStructureDialogView> CopyQualityDocumentation { get; set; } 
        public IRPSCheckbox<DuplicateStructureDialogView> CopyTimeOutMaterials { get; set; } 
        public IRPSTextBox<DuplicateStructureDialogView> StructureQualityVersion { get; set; } 
        public IRPSTextBox<DuplicateStructureDialogView> StructureQualityDrawingLevel { get; set; } 
        public IRPSTextBox<DuplicateStructureDialogView> StructureQualityDrawingDate { get; set; } 
        public Structure Screen { get; set; }
        public DuplicateStructureDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NewVersionStructureDialogView : View
    {
        public NewVersionStructureDialogView(Structure screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDStructure = RPSControlFactory.CreateRPSComboBox<NewVersionStructureDialogView>("7d88b3aa-9304-498e-a25b-b92da371ddab","","",false, this);
 
            Version = RPSControlFactory.CreateRPSTextBox<NewVersionStructureDialogView>("8270bb57-347f-4337-a524-2d04622f043b","","",true, this);
 
            NewVersion = RPSControlFactory.CreateRPSTextBox<NewVersionStructureDialogView>("5eeeccf0-d4dc-42cc-95c9-3dbe57a12bb1","","",true, this);
 
            Route = RPSControlFactory.CreateRPSComboBox<NewVersionStructureDialogView>("a3d62854-8b44-4f18-b3dc-563cf11596c3","","",false, this);
 
            CopyQualityDocumentation = RPSControlFactory.CreateRPSCheckBox<NewVersionStructureDialogView>("5b213932-feba-4eb4-966f-5a150f1687c9","","",false, this);
 
            CopyTimeOutMaterials = RPSControlFactory.CreateRPSCheckBox<NewVersionStructureDialogView>("53c59b94-c690-43b5-879d-e591d8c1a706","","",false, this);
 
            StructureQualityVersion = RPSControlFactory.CreateRPSTextBox<NewVersionStructureDialogView>("414f5cef-9d9a-4e58-8025-da5eb4ac0aae","","",true, this);
 
            StructureQualityDrawingLevel = RPSControlFactory.CreateRPSTextBox<NewVersionStructureDialogView>("0be6d382-132a-4e52-9148-35fc3a7081d7","","",true, this);
 
            StructureQualityDrawingDate = RPSControlFactory.CreateRPSTextBox<NewVersionStructureDialogView>("552eef3b-31ce-4ee5-a7d3-a1311b9fb501","","",true, this);
 

        }
        public IRPSComboBox<NewVersionStructureDialogView> IDStructure { get; set; } 
        public IRPSTextBox<NewVersionStructureDialogView> Version { get; set; } 
        public IRPSTextBox<NewVersionStructureDialogView> NewVersion { get; set; } 
        public IRPSComboBox<NewVersionStructureDialogView> Route { get; set; } 
        public IRPSCheckbox<NewVersionStructureDialogView> CopyQualityDocumentation { get; set; } 
        public IRPSCheckbox<NewVersionStructureDialogView> CopyTimeOutMaterials { get; set; } 
        public IRPSTextBox<NewVersionStructureDialogView> StructureQualityVersion { get; set; } 
        public IRPSTextBox<NewVersionStructureDialogView> StructureQualityDrawingLevel { get; set; } 
        public IRPSTextBox<NewVersionStructureDialogView> StructureQualityDrawingDate { get; set; } 
        public Structure Screen { get; set; }
        public NewVersionStructureDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ArticlesWithoutStructureDialogView : View
    {
        public ArticlesWithoutStructureDialogView(Structure screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<ArticlesWithoutStructureDialogView>("2b9a26ad-fc5d-4dcc-8bb5-f809c6718156","","",false, this);
 
            ArticlesWithoutStructureCommand = RPSControlFactory.CreateRPSButton<ArticlesWithoutStructureDialogView>( "cc58628e-b9fc-4c7d-b3b1-9ac0b7790da6","","",this);
 
            CollectionInit params_ArticlesWithoutStructure = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7aa247e5-dde9-4269-b4c5-a329ebd60820",CSSSelectorGrid="",XPathGrid=""};
            ArticlesWithoutStructure = RPSControlFactory.RPSCreateCollectionWithGrid<ArticlesWithoutStructureCollectionEditor<ArticlesWithoutStructureDialogView>,ArticlesWithoutStructureDialogView>( params_ArticlesWithoutStructure,this);
 

        }
        public IRPSComboBox<ArticlesWithoutStructureDialogView> Site { get; set; } 
        public IRPSButton<ArticlesWithoutStructureDialogView> ArticlesWithoutStructureCommand { get; set; } 
        public ArticlesWithoutStructureCollectionEditor<ArticlesWithoutStructureDialogView> ArticlesWithoutStructure { get; set; } 
        public Structure Screen { get; set; }
        public ArticlesWithoutStructureDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ArticlesWithoutStructureCollectionEditor<ArticlesWithoutStructureDialogView>:RPSCollectionEditor<ArticlesWithoutStructureDialogView> where ArticlesWithoutStructureDialogView : class, IView
    {
        public  ArticlesWithoutStructureGridView<ArticlesWithoutStructureDialogView> GridView {get;set;}
    }
    public partial class ArticlesWithoutStructureGridView <ArticlesWithoutStructureDialogView> :  RPSGridView<ArticlesWithoutStructureDialogView> where ArticlesWithoutStructureDialogView : class, IView
    {
        public ArticlesWithoutStructureGridView(ArticlesWithoutStructureDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ArticleWithoutStructure = RPSControlFactory.CreateRPSGridCheckBox<ArticlesWithoutStructureDialogView>("","#7aa247e5-dde9-4269-b4c5-a329ebd60820 .ag-row[role='row']@ROWINDEX [col-id='cArticleWithoutStructure']","",false, this.CurrentView);
 
            ArticleWithInactiveStructure = RPSControlFactory.CreateRPSGridCheckBox<ArticlesWithoutStructureDialogView>("","#7aa247e5-dde9-4269-b4c5-a329ebd60820 .ag-row[role='row']@ROWINDEX [col-id='cArticleWithInactiveStructure']","",false, this.CurrentView);
 

        }
        public IRPSGridCheckbox<ArticlesWithoutStructureDialogView> ArticleWithoutStructure { get; set; } 
        public IRPSGridCheckbox<ArticlesWithoutStructureDialogView> ArticleWithInactiveStructure { get; set; } 
                     
    }
 
    }
  
            
    public partial class AddUsualTaskDialogView : View
    {
        public AddUsualTaskDialogView(Structure screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIUsualTaskSTR = RPSControlFactory.CreateRPSComboBox<AddUsualTaskDialogView>("2fc0f28c-96ec-462b-a480-8cac4688fe66","","",false, this);
 

        }
        public IRPSComboBox<AddUsualTaskDialogView> UIUsualTaskSTR { get; set; } 
        public Structure Screen { get; set; }
        public AddUsualTaskDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class AddStructureRouteDialogView : View
    {
        public AddStructureRouteDialogView(Structure screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIRouteNew = RPSControlFactory.CreateRPSComboBox<AddStructureRouteDialogView>("70a44f7b-8da3-479b-b2ec-17a4cbb88a47","","",false, this);
 
            UICopyFromExistingRoute = RPSControlFactory.CreateRPSCheckBox<AddStructureRouteDialogView>("ae1dc12c-6f36-40eb-9ce9-aed2ba627071","","",false, this);
 
            UIRouteOrigin = RPSControlFactory.CreateRPSComboBox<AddStructureRouteDialogView>("8750fbe7-50e0-4c3d-bc9a-b9c67eb12fdf","","",false, this);
 

        }
        public IRPSComboBox<AddStructureRouteDialogView> UIRouteNew { get; set; } 
        public IRPSCheckbox<AddStructureRouteDialogView> UICopyFromExistingRoute { get; set; } 
        public IRPSComboBox<AddStructureRouteDialogView> UIRouteOrigin { get; set; } 
        public Structure Screen { get; set; }
        public AddStructureRouteDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CopyStructureRouteDialogView : View
    {
        public CopyStructureRouteDialogView(Structure screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIRouteOrigin = RPSControlFactory.CreateRPSComboBox<CopyStructureRouteDialogView>("2ba7132a-cf26-4c55-938e-8646cacf21c3","","",false, this);
 
            UIRouteDestination = RPSControlFactory.CreateRPSComboBox<CopyStructureRouteDialogView>("ed2323d4-da42-4e32-89e3-7cfbbcaf7b0f","","",false, this);
 

        }
        public IRPSComboBox<CopyStructureRouteDialogView> UIRouteOrigin { get; set; } 
        public IRPSComboBox<CopyStructureRouteDialogView> UIRouteDestination { get; set; } 
        public Structure Screen { get; set; }
        public CopyStructureRouteDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DeleteStructureRouteDialogView : View
    {
        public DeleteStructureRouteDialogView(Structure screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIRoute = RPSControlFactory.CreateRPSComboBox<DeleteStructureRouteDialogView>("2ca40582-01c0-4e24-9ae6-e5077304a4e9","","",false, this);
 

        }
        public IRPSComboBox<DeleteStructureRouteDialogView> UIRoute { get; set; } 
        public Structure Screen { get; set; }
        public DeleteStructureRouteDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SubStructureView : View
    {
        public SubStructureView(Structure screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<SubStructureView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<SubStructureView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SubStructureView,StructureDetailView>( this,Screen.StructureDetailView);
 
            BackButton = RPSControlFactory.RPSBackButton<SubStructureView,StructureDetailView>( this,Screen.StructureDetailView);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<SubStructureView>("5aa760c1-b40d-446f-aabb-36a3fe09ae33","","",true, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<SubStructureView>("dc859fb1-cb0a-4889-9059-acea5efc1552","","",true, this);
 
            Version = RPSControlFactory.CreateRPSTextBox<SubStructureView>("4b7f00bc-9d4b-459f-9027-89781fecaf3e","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SubStructureView>("eb9affb6-23f2-405c-8d76-044e71df7ed8","","",false, this);
 
            Active = RPSControlFactory.CreateRPSCheckBox<SubStructureView>("1553a013-82c1-41b4-906c-0e126cefa91f","","",true, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<SubStructureView>("a7cf719a-e234-48ad-a035-9ad599ffe295","","",false, this);
 
            AutomaticCodification = RPSControlFactory.CreateRPSCheckBox<SubStructureView>("edb0e997-318d-4d74-8b66-eee7b7555c92","","",true, this);
 
            TimeUnitDefault = RPSControlFactory.CreateRPSEnumComboBox<SubStructureView>("fa099772-b38d-4839-a8d3-92643f99d2c5","","",true, this);
 
            IDStructureType = RPSControlFactory.CreateRPSComboBox<SubStructureView>("72c4cfc5-1601-4cc1-a5c1-0afeb3ac9eb8","","",false, this);
 
            PlanningDirection = RPSControlFactory.CreateRPSEnumComboBox<SubStructureView>("62d58f28-eeb1-42a5-be78-0f776e908e37","","",true, this);
 
            IDWareHouse = RPSControlFactory.CreateRPSComboBox<SubStructureView>("966e1481-6c72-4d22-b19f-6918cc2b5a2b","","",false, this);
 
            QuantityBaseFormula = RPSControlFactory.CreateRPSFormattedTextBox<SubStructureView>("56887350-78a3-4cce-9b04-0e5d71735286","","",true, this);
 
            IDUnitBaseFormula = RPSControlFactory.CreateRPSComboBox<SubStructureView>("0869f44a-4f95-4365-a4f8-b3a77e0cc597","","",false, this);
 
            Notes = RPSControlFactory.CreateRPSTextBox<SubStructureView>("0244ba13-3905-40a0-8048-5767738a9ec3","","",false, this);
 
            StrucutreNavigateCommandButton = RPSControlFactory.CreateRPSButton<SubStructureView>( "0e623a92-5a39-49d3-9af1-64a04c622b21","","",this);
 
            CollectionInit params_Tasks = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6acd518f-eb4a-4c7f-9441-b5298327bd25",CSSSelectorGrid="",XPathGrid=""};
            Tasks = RPSControlFactory.RPSCreateCollectionWithGrid<TasksCollectionEditor<SubStructureView,SubTaskView>,SubStructureView,SubTaskView>( params_Tasks,this,Screen.SubTaskView);
 
            CollectionInit params_StructureFeatures = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="189c3e04-5549-4564-94dc-fc53f83ab756",CSSSelectorGrid="",XPathGrid=""};
            StructureFeatures = RPSControlFactory.RPSCreateCollectionWithGrid<StructureFeaturesCollectionEditor<SubStructureView,SubTaskView>,SubStructureView,SubTaskView>( params_StructureFeatures,this,Screen.SubTaskView);
 
            CollectionInit params_StructureDimensions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="bf571769-821c-4401-92de-9afc47160121",CSSSelectorGrid="",XPathGrid=""};
            StructureDimensions = RPSControlFactory.RPSCreateCollectionWithGrid<StructureDimensionsCollectionEditor<SubStructureView,SubTaskView>,SubStructureView,SubTaskView>( params_StructureDimensions,this,Screen.SubTaskView);
 
            SectionGeneral = RPSControlFactory.CreateRPSSection<SubStructureView>( "","ul li[rpsid='53f18139-b2ca-4e3c-844b-183e50af8630']","",this);
 
            SectionTasks = RPSControlFactory.CreateRPSSection<SubStructureView>( "","ul li[rpsid='b6610da5-c29b-44bc-b4fb-eeb39d97ced7']","",this);
 
            SectionFeatures = RPSControlFactory.CreateRPSSection<SubStructureView>( "","ul li[rpsid='ebf1d3de-75ec-4282-91c1-d664b0266ecd']","",this);
 
            SectionDimensions = RPSControlFactory.CreateRPSSection<SubStructureView>( "","ul li[rpsid='8a25c392-9fe3-42d8-b5b6-1d4076fbcdce']","",this);
 

        }
        public IRPSSaveButton<SubStructureView> SaveButton { get; set; } 
        public IRPSButton<SubStructureView> DeleteButton { get; set; } 
        public IRPSButton<SubStructureView,StructureDetailView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SubStructureView,StructureDetailView> BackButton { get; set; } 
        public IRPSComboBox<SubStructureView> IDSite { get; set; } 
        public IRPSComboBox<SubStructureView> IDArticle { get; set; } 
        public IRPSTextBox<SubStructureView> Version { get; set; } 
        public IRPSTextBox<SubStructureView> Description { get; set; } 
        public IRPSCheckbox<SubStructureView> Active { get; set; } 
        public IRPSTextBox<SubStructureView> DateFrom { get; set; } 
        public IRPSCheckbox<SubStructureView> AutomaticCodification { get; set; } 
        public IRPSComboBox<SubStructureView> TimeUnitDefault { get; set; } 
        public IRPSComboBox<SubStructureView> IDStructureType { get; set; } 
        public IRPSComboBox<SubStructureView> PlanningDirection { get; set; } 
        public IRPSComboBox<SubStructureView> IDWareHouse { get; set; } 
        public IRPSTextBox<SubStructureView> QuantityBaseFormula { get; set; } 
        public IRPSComboBox<SubStructureView> IDUnitBaseFormula { get; set; } 
        public IRPSTextBox<SubStructureView> Notes { get; set; } 
        public IRPSButton<SubStructureView> StrucutreNavigateCommandButton { get; set; } 
        public TasksCollectionEditor<SubStructureView,SubTaskView> Tasks { get; set; } 
        public StructureFeaturesCollectionEditor<SubStructureView,SubTaskView> StructureFeatures { get; set; } 
        public StructureDimensionsCollectionEditor<SubStructureView,SubTaskView> StructureDimensions { get; set; } 
        public IRPSSection<SubStructureView> SectionGeneral { get; set; } 
        public IRPSSection<SubStructureView> SectionTasks { get; set; } 
        public IRPSSection<SubStructureView> SectionFeatures { get; set; } 
        public IRPSSection<SubStructureView> SectionDimensions { get; set; } 
        public Structure Screen { get; set; }
        public SubStructureView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class TasksCollectionEditor<SubStructureView,SubTaskView>:RPSCollectionEditor<SubStructureView,SubTaskView> where SubStructureView : class, IView where SubTaskView : class, IView
    {
        public  TasksGridView<SubStructureView,SubTaskView> GridView {get;set;}
    }
    public partial class TasksGridView <SubStructureView,SubTaskView> :  RPSGridView<SubStructureView,SubTaskView> where SubStructureView : class, IView where SubTaskView : class, IView
    {
        public TasksGridView(SubStructureView currentView,SubTaskView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            TaskType = RPSControlFactory.CreateRPSGridEnumComboBox<SubStructureView>("","#6acd518f-eb4a-4c7f-9441-b5298327bd25 .ag-row[role='row']@ROWINDEX [col-id='cTaskType']","",true, this.CurrentView);
 
            CodTask = RPSControlFactory.CreateRPSGridTextBox<SubStructureView>("","#6acd518f-eb4a-4c7f-9441-b5298327bd25 .ag-row[role='row']@ROWINDEX [col-id='cCodTask']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<SubStructureView>("","#6acd518f-eb4a-4c7f-9441-b5298327bd25 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            IDTaskParent = RPSControlFactory.CreateRPSGridComboBox<SubStructureView>("","#6acd518f-eb4a-4c7f-9441-b5298327bd25 .ag-row[role='row']@ROWINDEX [col-id='cIDTaskParent']","",false, this.CurrentView);
 
            PreparationTime = RPSControlFactory.CreateRPSGridDurationTextBox<SubStructureView>("","#6acd518f-eb4a-4c7f-9441-b5298327bd25 .ag-row[role='row']@ROWINDEX [col-id='cPreparationTime']","",true, this.CurrentView);
 
            ExecutionTime = RPSControlFactory.CreateRPSGridDurationTextBox<SubStructureView>("","#6acd518f-eb4a-4c7f-9441-b5298327bd25 .ag-row[role='row']@ROWINDEX [col-id='cExecutionTime']","",true, this.CurrentView);
 
            External = RPSControlFactory.CreateRPSGridCheckBox<SubStructureView>("","#6acd518f-eb4a-4c7f-9441-b5298327bd25 .ag-row[role='row']@ROWINDEX [col-id='cExternal']","",true, this.CurrentView);
 
            Order = RPSControlFactory.CreateRPSGridFormattedTextBox<SubStructureView>("","#6acd518f-eb4a-4c7f-9441-b5298327bd25 .ag-row[role='row']@ROWINDEX [col-id='cOrder']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<SubStructureView> TaskType { get; set; } 
        public IRPSGridTextBox<SubStructureView> CodTask { get; set; } 
        public IRPSGridTextBox<SubStructureView> Description { get; set; } 
        public IRPSGridComboBox<SubStructureView> IDTaskParent { get; set; } 
        public IRPSGridDurationTextBox<SubStructureView> PreparationTime { get; set; } 
        public IRPSGridDurationTextBox<SubStructureView> ExecutionTime { get; set; } 
        public IRPSGridCheckbox<SubStructureView> External { get; set; } 
        public IRPSGridTextBox<SubStructureView> Order { get; set; } 
                     
    }
 
        public partial class StructureFeaturesCollectionEditor<SubStructureView,SubTaskView>:RPSCollectionEditor<SubStructureView,SubTaskView> where SubStructureView : class, IView where SubTaskView : class, IView
    {
        public  StructureFeaturesGridView<SubStructureView,SubTaskView> GridView {get;set;}
    }
    public partial class StructureFeaturesGridView <SubStructureView,SubTaskView> :  RPSGridView<SubStructureView,SubTaskView> where SubStructureView : class, IView where SubTaskView : class, IView
    {
        public StructureFeaturesGridView(SubStructureView currentView,SubTaskView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDFeatureLabel = RPSControlFactory.CreateRPSGridComboBox<SubStructureView>("","#189c3e04-5549-4564-94dc-fc53f83ab756 .ag-row[role='row']@ROWINDEX [col-id='cIDFeatureLabel']","",true, this.CurrentView);
 
            Value = RPSControlFactory.CreateRPSGridTextBox<SubStructureView>("","#189c3e04-5549-4564-94dc-fc53f83ab756 .ag-row[role='row']@ROWINDEX [col-id='cValue']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<SubStructureView> IDFeatureLabel { get; set; } 
        public IRPSGridTextBox<SubStructureView> Value { get; set; } 
                     
    }
 
        public partial class StructureDimensionsCollectionEditor<SubStructureView,SubTaskView>:RPSCollectionEditor<SubStructureView,SubTaskView> where SubStructureView : class, IView where SubTaskView : class, IView
    {
        public  StructureDimensionsGridView<SubStructureView,SubTaskView> GridView {get;set;}
    }
    public partial class StructureDimensionsGridView <SubStructureView,SubTaskView> :  RPSGridView<SubStructureView,SubTaskView> where SubStructureView : class, IView where SubTaskView : class, IView
    {
        public StructureDimensionsGridView(SubStructureView currentView,SubTaskView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDDimension = RPSControlFactory.CreateRPSGridComboBox<SubStructureView>("","#bf571769-821c-4401-92de-9afc47160121 .ag-row[role='row']@ROWINDEX [col-id='cIDDimension']","",true, this.CurrentView);
 
            IDDimValue = RPSControlFactory.CreateRPSGridComboBox<SubStructureView>("","#bf571769-821c-4401-92de-9afc47160121 .ag-row[role='row']@ROWINDEX [col-id='cIDDimValue']","",true, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<SubStructureView>("","#bf571769-821c-4401-92de-9afc47160121 .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<SubStructureView> IDDimension { get; set; } 
        public IRPSGridComboBox<SubStructureView> IDDimValue { get; set; } 
        public IRPSGridTextBox<SubStructureView> Percentage { get; set; } 
                     
    }
 
    }
  
            
    public partial class SubTaskView : View
    {
        public SubTaskView(Structure screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SubTaskView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SubTaskView,SubStructureView>( this,Screen.SubStructureView);
 
            BackButton = RPSControlFactory.RPSBackButton<SubTaskView,SubStructureView>( this,Screen.SubStructureView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SubTaskView,SubStructureView>( this,Screen.SubStructureView);
 
            CodTask = RPSControlFactory.CreateRPSTextBox<SubTaskView>("e28a959e-41d2-4ef5-9554-985f6c8b66d5","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SubTaskView>("08caa5be-cd3c-4af7-9a86-fd66b6636cab","","",false, this);
 
            TaskType = RPSControlFactory.CreateRPSEnumComboBox<SubTaskView>("986d6d4e-a0b1-4231-b303-8074b9b280cf","","",true, this);
 
            PreparationTime = RPSControlFactory.CreateRPSDurationTextBox<SubTaskView>("a6ccd270-32e8-4b72-bf9e-01473c8ff981","","",true, this);
 
            ExecutionTime = RPSControlFactory.CreateRPSDurationTextBox<SubTaskView>("aff03128-e2ba-4d46-944e-aaec8bc697d8","","",true, this);
 
            TimeUnit = RPSControlFactory.CreateRPSEnumComboBox<SubTaskView>("d46ebda0-fcdb-4434-9910-3e78bbbd9e05","","",true, this);
 
            ExecutionLot = RPSControlFactory.CreateRPSFormattedTextBox<SubTaskView>("40e70765-ddb5-431f-bfd7-f309c3f50d13","","",true, this);
 
            RepetitionTime = RPSControlFactory.CreateRPSDurationTextBox<SubTaskView>("a2b50d3e-5c4c-4c61-b553-499b348ab508","","",true, this);
 
            RepetitionLot = RPSControlFactory.CreateRPSFormattedTextBox<SubTaskView>("7f76a4ba-8b73-4459-ba14-1246a246f76a","","",true, this);
 
            WorkUnits = RPSControlFactory.CreateRPSFormattedTextBox<SubTaskView>("10bd766a-95b7-4425-b594-0e693cef589a","","",true, this);
 
            IDUsualTask = RPSControlFactory.CreateRPSComboBox<SubTaskView>("d8566069-2d03-4b86-b2f4-2155c33ef2a9","","",false, this);
 
            IDTaskParent = RPSControlFactory.CreateRPSComboBox<SubTaskView>("48c6cb4b-e072-4ed2-9267-b071e34814db","","",false, this);
 
            IDTaskType = RPSControlFactory.CreateRPSComboBox<SubTaskView>("7fda8ab8-0a88-45e9-8797-51a060bf0143","","",false, this);
 
            SeriesRequired = RPSControlFactory.CreateRPSCheckBox<SubTaskView>("6445c1f0-6816-463c-942a-306baffe6445","","",true, this);
 
            ProductEntry = RPSControlFactory.CreateRPSCheckBox<SubTaskView>("58fa6850-8d75-4348-8173-afaddadbc18d","","",true, this);
 
            MaterialExit = RPSControlFactory.CreateRPSCheckBox<SubTaskView>("295a46b1-b94e-4a10-8b93-1e50dae34b4b","","",true, this);
 
            PrintLabels = RPSControlFactory.CreateRPSCheckBox<SubTaskView>("c58de66b-5521-4fa3-a683-067e0dee6261","","",true, this);
 
            LotsOrder = RPSControlFactory.CreateRPSCheckBox<SubTaskView>("9c040b12-6ced-4fe2-a7bf-fb726f4f7402","","",true, this);
 
            AutoExecutionImputation = RPSControlFactory.CreateRPSCheckBox<SubTaskView>("cba8fc0d-f557-49dc-9b65-21d5801be4a4","","",true, this);
 
            IDProductFormula = RPSControlFactory.CreateRPSComboBox<SubTaskView>("2573e28b-9e2c-4470-847a-8d6571287b78","","",false, this);
 
            External = RPSControlFactory.CreateRPSCheckBox<SubTaskView>("c8f86964-3d8c-4b0c-a6d2-1be2942dbc6c","","",true, this);
 
            IDArticleExternal = RPSControlFactory.CreateRPSComboBox<SubTaskView>("4fb4f5bf-0074-4b6e-aea7-35450dfdd7e0","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<SubTaskView>("fad44d90-5716-4c67-9509-8c1337c54c8f","","",true, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<SubTaskView>("bc0b1a33-2127-46ab-a844-468b2d181d7a","","",false, this);
 
            IDBudgetCategory = RPSControlFactory.CreateRPSComboBox<SubTaskView>("11fd5353-7889-4e36-b28a-95a242fda4ef","","",false, this);
 
            IDSiteMaterial = RPSControlFactory.CreateRPSComboBox<SubTaskView>("f54ee0c9-69b6-42bb-aab4-9ca3270c434a","","",false, this);
 
            IDWarehouseMaterial = RPSControlFactory.CreateRPSComboBox<SubTaskView>("2f746d1b-c492-41ca-bd2e-8bd867a8dd19","","",false, this);
 
            ImputationCostUpdated = RPSControlFactory.CreateRPSCheckBox<SubTaskView>("5609863b-464b-4d22-8468-62266cb5f795","","",true, this);
 
            DelimitationType = RPSControlFactory.CreateRPSEnumComboBox<SubTaskView>("849b5ed2-9e69-4e54-ac4f-23e238e9d26e","","",true, this);
 
            ManualPlanning = RPSControlFactory.CreateRPSCheckBox<SubTaskView>("55f0c235-c836-499e-8ae5-268e79f4a5fb","","",true, this);
 
            AllowFraccionate = RPSControlFactory.CreateRPSCheckBox<SubTaskView>("05c8778c-6c3c-416d-96f8-36f897989302","","",true, this);
 
            MinimumFraction = RPSControlFactory.CreateRPSFormattedTextBox<SubTaskView>("ecafc739-fe29-4089-9921-667e0045854b","","",true, this);
 
            WithoutTimetable = RPSControlFactory.CreateRPSCheckBox<SubTaskView>("976f8fd9-8c13-4a40-8475-80db0026ba49","","",true, this);
 
            OptimizationFeature = RPSControlFactory.CreateRPSTextBox<SubTaskView>("2987c923-4178-440d-8c2f-d27e7c24ecf2","","",false, this);
 
            ResourcePlanType = RPSControlFactory.CreateRPSEnumComboBox<SubTaskView>("9a0967a4-6de2-41b2-8050-6aea7cb5b354","","",true, this);
 
            SplitNumber = RPSControlFactory.CreateRPSFormattedTextBox<SubTaskView>("e99f7590-3893-472b-a3c1-db9990fcfcea","","",true, this);
 
            OccupancyType = RPSControlFactory.CreateRPSEnumComboBox<SubTaskView>("aefc1fe2-5826-4c0a-8b31-a02bd5440fd4","","",true, this);
 
            OccupancyHours = RPSControlFactory.CreateRPSFormattedTextBox<SubTaskView>("13b29060-25cc-4b2c-b3f6-a5ca5d362300","","",true, this);
 
            OccupancyPercent = RPSControlFactory.CreateRPSFormattedTextBox<SubTaskView>("19cd02f1-4cda-47d5-a32a-a4bf699d1c95","","",true, this);
 
            Notes = RPSControlFactory.CreateRPSTextBox<SubTaskView>("285daccf-11df-47bb-8b80-63b90437c0d5","","",false, this);
 
            IDBudgetEmployee = RPSControlFactory.CreateRPSComboBox<SubTaskView>("cef9989c-62cb-4c0a-83af-f38c60e908c2","","",false, this);
 
            IDBudgetMachine = RPSControlFactory.CreateRPSComboBox<SubTaskView>("04c22ca9-dae1-4001-8737-16474b09720d","","",false, this);
 
            IDBudgetTool = RPSControlFactory.CreateRPSComboBox<SubTaskView>("34bbcfcd-ced4-430e-89bb-1b6cbe77d468","","",false, this);
 
            IDBudgetMaterial = RPSControlFactory.CreateRPSComboBox<SubTaskView>("c26c86a6-6697-4c59-9dbd-f9b2a931ce7b","","",false, this);
 
            IDBudgetOtherCost = RPSControlFactory.CreateRPSComboBox<SubTaskView>("bb54b726-f09c-40c4-b2ae-3acbb1e01220","","",false, this);
 
            CollectionInit params_Materials = new CollectionInit(){IDDescriptor = "81a482c0-256e-4d64-a726-63b9245f2bcb",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3db92298-c008-4b65-8c76-8eaa698b30f1",CSSSelectorGrid="",XPathGrid=""};
            Materials = RPSControlFactory.RPSCreateCollectionWithGrid<MaterialsCollectionEditor<SubTaskView,SubMaterialView>,SubTaskView,SubMaterialView>( params_Materials,this,Screen.SubMaterialView);
 
            CollectionInit params_TaskRelations = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="73e03ac4-75fb-4381-a454-dbc1c3fd8dfc",CSSSelectorGrid="",XPathGrid=""};
            TaskRelations = RPSControlFactory.RPSCreateCollectionWithGrid<TaskRelationsCollectionEditor<SubTaskView,SubMaterialView>,SubTaskView,SubMaterialView>( params_TaskRelations,this,Screen.SubMaterialView);
 
            CollectionInit params_TaskRoutes = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d43bf6a6-4bae-426e-a66e-233efb3fee73",CSSSelectorGrid="",XPathGrid=""};
            TaskRoutes = RPSControlFactory.RPSCreateCollectionWithGrid<TaskRoutesCollectionEditor<SubTaskView,SubMaterialView>,SubTaskView,SubMaterialView>( params_TaskRoutes,this,Screen.SubMaterialView);
 
            CollectionInit params_ResourceEmployees = new CollectionInit(){IDDescriptor = "4f36a181-1d64-43c2-9bea-0cdc83fa4ea7",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f73a9457-4fe6-4963-96d7-3609c86e7004",CSSSelectorGrid="",XPathGrid=""};
            ResourceEmployees = RPSControlFactory.RPSCreateCollectionWithGrid<ResourceEmployeesCollectionEditor<SubTaskView,SubMaterialView>,SubTaskView,SubMaterialView>( params_ResourceEmployees,this,Screen.SubMaterialView);
 
            CollectionInit params_ResourceMachines = new CollectionInit(){IDDescriptor = "718b6806-a59a-4d1c-a347-c0b2fb04f35b",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="16c40429-92c9-4b52-83d4-0237de1c0ccd",CSSSelectorGrid="",XPathGrid=""};
            ResourceMachines = RPSControlFactory.RPSCreateCollectionWithGrid<ResourceMachinesCollectionEditor<SubTaskView,SubMaterialView>,SubTaskView,SubMaterialView>( params_ResourceMachines,this,Screen.SubMaterialView);
 
            CollectionInit params_ResourceTools = new CollectionInit(){IDDescriptor = "abbbd812-dcce-41c6-9b64-2d301d3a0f25",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4235348b-bd8b-426e-b8da-6eba28237279",CSSSelectorGrid="",XPathGrid=""};
            ResourceTools = RPSControlFactory.RPSCreateCollectionWithGrid<ResourceToolsCollectionEditor<SubTaskView,SubMaterialView>,SubTaskView,SubMaterialView>( params_ResourceTools,this,Screen.SubMaterialView);
 
            CollectionInit params_TaskCostComponents = new CollectionInit(){IDDescriptor = "0e2519a4-3f93-4662-b6cb-c9d965119d3c",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7f4e960c-7448-49b3-8aa2-891c662db2be",CSSSelectorGrid="",XPathGrid=""};
            TaskCostComponents = RPSControlFactory.RPSCreateCollectionWithGrid<TaskCostComponentsCollectionEditor<SubTaskView,SubMaterialView>,SubTaskView,SubMaterialView>( params_TaskCostComponents,this,Screen.SubMaterialView);
 
            CollectionInit params_TaskDimensions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="847c5370-8203-4693-8755-30d3a7399b3c",CSSSelectorGrid="",XPathGrid=""};
            TaskDimensions = RPSControlFactory.RPSCreateCollectionWithGrid<TaskDimensionsCollectionEditor<SubTaskView,SubMaterialView>,SubTaskView,SubMaterialView>( params_TaskDimensions,this,Screen.SubMaterialView);
 
            SectionGeneral = RPSControlFactory.CreateRPSSection<SubTaskView>( "","ul li[rpsid='857f9c74-a016-4064-85bf-0876e2a2409a']","",this);
 
            SectionMaterials = RPSControlFactory.CreateRPSSection<SubTaskView>( "","ul li[rpsid='d02c5e06-b53e-4461-ad03-4c117877be52']","",this);
 
            SectionExternal = RPSControlFactory.CreateRPSSection<SubTaskView>( "","ul li[rpsid='80376aae-b262-4a07-af9e-50f9e4686dba']","",this);
 
            SectionPlanning = RPSControlFactory.CreateRPSSection<SubTaskView>( "","ul li[rpsid='cf1ac315-9f5d-4e6e-af28-47a917314f1d']","",this);
 
            SectionNotes = RPSControlFactory.CreateRPSSection<SubTaskView>( "","ul li[rpsid='a7bd3aca-1e65-4236-98c9-2ada26d2aaed']","",this);
 
            SectionRelations = RPSControlFactory.CreateRPSSection<SubTaskView>( "","ul li[rpsid='80e74af0-f119-4c2f-b0b2-be9afa92d631']","",this);
 
            SectionRoutes = RPSControlFactory.CreateRPSSection<SubTaskView>( "","ul li[rpsid='69a2a217-7184-476c-881f-3a0894761b5f']","",this);
 
            SectionEmployees = RPSControlFactory.CreateRPSSection<SubTaskView>( "","ul li[rpsid='e43a5add-34cc-41b1-aa3f-b80b1ea01313']","",this);
 
            SectionMachines = RPSControlFactory.CreateRPSSection<SubTaskView>( "","ul li[rpsid='12339eb9-c3d1-439b-aff7-c5e340290b23']","",this);
 
            SectionTools = RPSControlFactory.CreateRPSSection<SubTaskView>( "","ul li[rpsid='c09047fa-da3f-4e45-8e9d-c2f43833204a']","",this);
 
            SectionCostComponent = RPSControlFactory.CreateRPSSection<SubTaskView>( "","ul li[rpsid='19d7b4a6-cc2e-48d0-9bf9-5f6a79ea04c0']","",this);
 
            SectionBudgetCategory = RPSControlFactory.CreateRPSSection<SubTaskView>( "","ul li[rpsid='05d880c7-5c9d-433e-894a-0afda61913c4']","",this);
 
            SectionDimensions = RPSControlFactory.CreateRPSSection<SubTaskView>( "","ul li[rpsid='ea2cad96-0add-4e50-b55e-0d876620ff8b']","",this);
 

        }
        public IRPSButton<SubTaskView> DeleteButton { get; set; } 
        public IRPSButton<SubTaskView,SubStructureView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SubTaskView,SubStructureView> BackButton { get; set; } 
        public IRPSAcceptButton<SubTaskView,SubStructureView> AcceptButton { get; set; } 
        public IRPSTextBox<SubTaskView> CodTask { get; set; } 
        public IRPSTextBox<SubTaskView> Description { get; set; } 
        public IRPSComboBox<SubTaskView> TaskType { get; set; } 
        public IRPSDurationTextBox<SubTaskView> PreparationTime { get; set; } 
        public IRPSDurationTextBox<SubTaskView> ExecutionTime { get; set; } 
        public IRPSComboBox<SubTaskView> TimeUnit { get; set; } 
        public IRPSTextBox<SubTaskView> ExecutionLot { get; set; } 
        public IRPSDurationTextBox<SubTaskView> RepetitionTime { get; set; } 
        public IRPSTextBox<SubTaskView> RepetitionLot { get; set; } 
        public IRPSTextBox<SubTaskView> WorkUnits { get; set; } 
        public IRPSComboBox<SubTaskView> IDUsualTask { get; set; } 
        public IRPSComboBox<SubTaskView> IDTaskParent { get; set; } 
        public IRPSComboBox<SubTaskView> IDTaskType { get; set; } 
        public IRPSCheckbox<SubTaskView> SeriesRequired { get; set; } 
        public IRPSCheckbox<SubTaskView> ProductEntry { get; set; } 
        public IRPSCheckbox<SubTaskView> MaterialExit { get; set; } 
        public IRPSCheckbox<SubTaskView> PrintLabels { get; set; } 
        public IRPSCheckbox<SubTaskView> LotsOrder { get; set; } 
        public IRPSCheckbox<SubTaskView> AutoExecutionImputation { get; set; } 
        public IRPSComboBox<SubTaskView> IDProductFormula { get; set; } 
        public IRPSCheckbox<SubTaskView> External { get; set; } 
        public IRPSComboBox<SubTaskView> IDArticleExternal { get; set; } 
        public IRPSTextBox<SubTaskView> Quantity { get; set; } 
        public IRPSComboBox<SubTaskView> IDSupplier { get; set; } 
        public IRPSComboBox<SubTaskView> IDBudgetCategory { get; set; } 
        public IRPSComboBox<SubTaskView> IDSiteMaterial { get; set; } 
        public IRPSComboBox<SubTaskView> IDWarehouseMaterial { get; set; } 
        public IRPSCheckbox<SubTaskView> ImputationCostUpdated { get; set; } 
        public IRPSComboBox<SubTaskView> DelimitationType { get; set; } 
        public IRPSCheckbox<SubTaskView> ManualPlanning { get; set; } 
        public IRPSCheckbox<SubTaskView> AllowFraccionate { get; set; } 
        public IRPSTextBox<SubTaskView> MinimumFraction { get; set; } 
        public IRPSCheckbox<SubTaskView> WithoutTimetable { get; set; } 
        public IRPSTextBox<SubTaskView> OptimizationFeature { get; set; } 
        public IRPSComboBox<SubTaskView> ResourcePlanType { get; set; } 
        public IRPSTextBox<SubTaskView> SplitNumber { get; set; } 
        public IRPSComboBox<SubTaskView> OccupancyType { get; set; } 
        public IRPSTextBox<SubTaskView> OccupancyHours { get; set; } 
        public IRPSTextBox<SubTaskView> OccupancyPercent { get; set; } 
        public IRPSTextBox<SubTaskView> Notes { get; set; } 
        public IRPSComboBox<SubTaskView> IDBudgetEmployee { get; set; } 
        public IRPSComboBox<SubTaskView> IDBudgetMachine { get; set; } 
        public IRPSComboBox<SubTaskView> IDBudgetTool { get; set; } 
        public IRPSComboBox<SubTaskView> IDBudgetMaterial { get; set; } 
        public IRPSComboBox<SubTaskView> IDBudgetOtherCost { get; set; } 
        public MaterialsCollectionEditor<SubTaskView,SubMaterialView> Materials { get; set; } 
        public TaskRelationsCollectionEditor<SubTaskView,SubMaterialView> TaskRelations { get; set; } 
        public TaskRoutesCollectionEditor<SubTaskView,SubMaterialView> TaskRoutes { get; set; } 
        public ResourceEmployeesCollectionEditor<SubTaskView,SubMaterialView> ResourceEmployees { get; set; } 
        public ResourceMachinesCollectionEditor<SubTaskView,SubMaterialView> ResourceMachines { get; set; } 
        public ResourceToolsCollectionEditor<SubTaskView,SubMaterialView> ResourceTools { get; set; } 
        public TaskCostComponentsCollectionEditor<SubTaskView,SubMaterialView> TaskCostComponents { get; set; } 
        public TaskDimensionsCollectionEditor<SubTaskView,SubMaterialView> TaskDimensions { get; set; } 
        public IRPSSection<SubTaskView> SectionGeneral { get; set; } 
        public IRPSSection<SubTaskView> SectionMaterials { get; set; } 
        public IRPSSection<SubTaskView> SectionExternal { get; set; } 
        public IRPSSection<SubTaskView> SectionPlanning { get; set; } 
        public IRPSSection<SubTaskView> SectionNotes { get; set; } 
        public IRPSSection<SubTaskView> SectionRelations { get; set; } 
        public IRPSSection<SubTaskView> SectionRoutes { get; set; } 
        public IRPSSection<SubTaskView> SectionEmployees { get; set; } 
        public IRPSSection<SubTaskView> SectionMachines { get; set; } 
        public IRPSSection<SubTaskView> SectionTools { get; set; } 
        public IRPSSection<SubTaskView> SectionCostComponent { get; set; } 
        public IRPSSection<SubTaskView> SectionBudgetCategory { get; set; } 
        public IRPSSection<SubTaskView> SectionDimensions { get; set; } 
        public Structure Screen { get; set; }
        public SubTaskView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaterialsCollectionEditor<SubTaskView,SubMaterialView>:RPSCollectionEditor<SubTaskView,SubMaterialView> where SubTaskView : class, IView where SubMaterialView : class, IView
    {
        public  MaterialsGridView<SubTaskView,SubMaterialView> GridView {get;set;}
    }
    public partial class MaterialsGridView <SubTaskView,SubMaterialView> :  RPSGridView<SubTaskView,SubMaterialView> where SubTaskView : class, IView where SubMaterialView : class, IView
    {
        public MaterialsGridView(SubTaskView currentView,SubMaterialView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodMaterial = RPSControlFactory.CreateRPSGridTextBox<SubTaskView>("","#3db92298-c008-4b65-8c76-8eaa698b30f1 .ag-row[role='row']@ROWINDEX [col-id='cCodMaterial']","",true, this.CurrentView);
 
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<SubTaskView>("","#3db92298-c008-4b65-8c76-8eaa698b30f1 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<SubTaskView>("","#3db92298-c008-4b65-8c76-8eaa698b30f1 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<SubTaskView>("","#3db92298-c008-4b65-8c76-8eaa698b30f1 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            ContentLot = RPSControlFactory.CreateRPSGridFormattedTextBox<SubTaskView>("","#3db92298-c008-4b65-8c76-8eaa698b30f1 .ag-row[role='row']@ROWINDEX [col-id='cContentLot']","",true, this.CurrentView);
 
            Order = RPSControlFactory.CreateRPSGridFormattedTextBox<SubTaskView>("","#3db92298-c008-4b65-8c76-8eaa698b30f1 .ag-row[role='row']@ROWINDEX [col-id='cOrder']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<SubTaskView> CodMaterial { get; set; } 
        public IRPSGridComboBox<SubTaskView> IDArticle { get; set; } 
        public IRPSGridTextBox<SubTaskView> Description { get; set; } 
        public IRPSGridTextBox<SubTaskView> Quantity { get; set; } 
        public IRPSGridTextBox<SubTaskView> ContentLot { get; set; } 
        public IRPSGridTextBox<SubTaskView> Order { get; set; } 
                     
    }
 
        public partial class TaskRelationsCollectionEditor<SubTaskView,SubMaterialView>:RPSCollectionEditor<SubTaskView,SubMaterialView> where SubTaskView : class, IView where SubMaterialView : class, IView
    {
        public  TaskRelationsGridView<SubTaskView,SubMaterialView> GridView {get;set;}
    }
    public partial class TaskRelationsGridView <SubTaskView,SubMaterialView> :  RPSGridView<SubTaskView,SubMaterialView> where SubTaskView : class, IView where SubMaterialView : class, IView
    {
        public TaskRelationsGridView(SubTaskView currentView,SubMaterialView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDPredecessorTask = RPSControlFactory.CreateRPSGridComboBox<SubTaskView>("","#73e03ac4-75fb-4381-a454-dbc1c3fd8dfc .ag-row[role='row']@ROWINDEX [col-id='cIDPredecessorTask']","",true, this.CurrentView);
 
            RelationType = RPSControlFactory.CreateRPSGridEnumComboBox<SubTaskView>("","#73e03ac4-75fb-4381-a454-dbc1c3fd8dfc .ag-row[role='row']@ROWINDEX [col-id='cRelationType']","",true, this.CurrentView);
 
            LagType = RPSControlFactory.CreateRPSGridEnumComboBox<SubTaskView>("","#73e03ac4-75fb-4381-a454-dbc1c3fd8dfc .ag-row[role='row']@ROWINDEX [col-id='cLagType']","",true, this.CurrentView);
 
            TimeLag = RPSControlFactory.CreateRPSGridDurationTextBox<SubTaskView>("","#73e03ac4-75fb-4381-a454-dbc1c3fd8dfc .ag-row[role='row']@ROWINDEX [col-id='cTimeLag']","",true, this.CurrentView);
 
            UnitsLag = RPSControlFactory.CreateRPSGridFormattedTextBox<SubTaskView>("","#73e03ac4-75fb-4381-a454-dbc1c3fd8dfc .ag-row[role='row']@ROWINDEX [col-id='cUnitsLag']","",true, this.CurrentView);
 
            Linked = RPSControlFactory.CreateRPSGridCheckBox<SubTaskView>("","#73e03ac4-75fb-4381-a454-dbc1c3fd8dfc .ag-row[role='row']@ROWINDEX [col-id='cLinked']","",true, this.CurrentView);
 
            CalendarType = RPSControlFactory.CreateRPSGridEnumComboBox<SubTaskView>("","#73e03ac4-75fb-4381-a454-dbc1c3fd8dfc .ag-row[role='row']@ROWINDEX [col-id='cCalendarType']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<SubTaskView> IDPredecessorTask { get; set; } 
        public IRPSGridComboBox<SubTaskView> RelationType { get; set; } 
        public IRPSGridComboBox<SubTaskView> LagType { get; set; } 
        public IRPSGridDurationTextBox<SubTaskView> TimeLag { get; set; } 
        public IRPSGridTextBox<SubTaskView> UnitsLag { get; set; } 
        public IRPSGridCheckbox<SubTaskView> Linked { get; set; } 
        public IRPSGridComboBox<SubTaskView> CalendarType { get; set; } 
                     
    }
 
        public partial class TaskRoutesCollectionEditor<SubTaskView,SubMaterialView>:RPSCollectionEditor<SubTaskView,SubMaterialView> where SubTaskView : class, IView where SubMaterialView : class, IView
    {
        public  TaskRoutesGridView<SubTaskView,SubMaterialView> GridView {get;set;}
    }
    public partial class TaskRoutesGridView <SubTaskView,SubMaterialView> :  RPSGridView<SubTaskView,SubMaterialView> where SubTaskView : class, IView where SubMaterialView : class, IView
    {
        public TaskRoutesGridView(SubTaskView currentView,SubMaterialView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDRoute = RPSControlFactory.CreateRPSGridComboBox<SubTaskView>("","#d43bf6a6-4bae-426e-a66e-233efb3fee73 .ag-row[role='row']@ROWINDEX [col-id='cIDRoute']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<SubTaskView> IDRoute { get; set; } 
                     
    }
 
        public partial class ResourceEmployeesCollectionEditor<SubTaskView,SubMaterialView>:RPSCollectionEditor<SubTaskView,SubMaterialView> where SubTaskView : class, IView where SubMaterialView : class, IView
    {
        public  ResourceEmployeesGridView<SubTaskView,SubMaterialView> GridView {get;set;}
    }
    public partial class ResourceEmployeesGridView <SubTaskView,SubMaterialView> :  RPSGridView<SubTaskView,SubMaterialView> where SubTaskView : class, IView where SubMaterialView : class, IView
    {
        public ResourceEmployeesGridView(SubTaskView currentView,SubMaterialView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDEmployee = RPSControlFactory.CreateRPSGridComboBox<SubTaskView>("","#f73a9457-4fe6-4963-96d7-3609c86e7004 .ag-row[role='row']@ROWINDEX [col-id='cIDEmployee']","",false, this.CurrentView);
 
            IDQualify = RPSControlFactory.CreateRPSGridComboBox<SubTaskView>("","#f73a9457-4fe6-4963-96d7-3609c86e7004 .ag-row[role='row']@ROWINDEX [col-id='cIDQualify']","",true, this.CurrentView);
 
            Planify = RPSControlFactory.CreateRPSGridCheckBox<SubTaskView>("","#f73a9457-4fe6-4963-96d7-3609c86e7004 .ag-row[role='row']@ROWINDEX [col-id='cPlanify']","",true, this.CurrentView);
 
            DedicationPercent = RPSControlFactory.CreateRPSGridFormattedTextBox<SubTaskView>("","#f73a9457-4fe6-4963-96d7-3609c86e7004 .ag-row[role='row']@ROWINDEX [col-id='cDedicationPercent']","",true, this.CurrentView);
 
            IDBudgetCategory = RPSControlFactory.CreateRPSGridComboBox<SubTaskView>("","#f73a9457-4fe6-4963-96d7-3609c86e7004 .ag-row[role='row']@ROWINDEX [col-id='cIDBudgetCategory']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<SubTaskView> IDEmployee { get; set; } 
        public IRPSGridComboBox<SubTaskView> IDQualify { get; set; } 
        public IRPSGridCheckbox<SubTaskView> Planify { get; set; } 
        public IRPSGridTextBox<SubTaskView> DedicationPercent { get; set; } 
        public IRPSGridComboBox<SubTaskView> IDBudgetCategory { get; set; } 
                     
    }
 
        public partial class ResourceMachinesCollectionEditor<SubTaskView,SubMaterialView>:RPSCollectionEditor<SubTaskView,SubMaterialView> where SubTaskView : class, IView where SubMaterialView : class, IView
    {
        public  ResourceMachinesGridView<SubTaskView,SubMaterialView> GridView {get;set;}
    }
    public partial class ResourceMachinesGridView <SubTaskView,SubMaterialView> :  RPSGridView<SubTaskView,SubMaterialView> where SubTaskView : class, IView where SubMaterialView : class, IView
    {
        public ResourceMachinesGridView(SubTaskView currentView,SubMaterialView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDMachine = RPSControlFactory.CreateRPSGridComboBox<SubTaskView>("","#16c40429-92c9-4b52-83d4-0237de1c0ccd .ag-row[role='row']@ROWINDEX [col-id='cIDMachine']","",false, this.CurrentView);
 
            IDMachineGroup = RPSControlFactory.CreateRPSGridComboBox<SubTaskView>("","#16c40429-92c9-4b52-83d4-0237de1c0ccd .ag-row[role='row']@ROWINDEX [col-id='cIDMachineGroup']","",false, this.CurrentView);
 
            Planify = RPSControlFactory.CreateRPSGridCheckBox<SubTaskView>("","#16c40429-92c9-4b52-83d4-0237de1c0ccd .ag-row[role='row']@ROWINDEX [col-id='cPlanify']","",true, this.CurrentView);
 
            DedicationPercent = RPSControlFactory.CreateRPSGridFormattedTextBox<SubTaskView>("","#16c40429-92c9-4b52-83d4-0237de1c0ccd .ag-row[role='row']@ROWINDEX [col-id='cDedicationPercent']","",true, this.CurrentView);
 
            IDResourceEmployee = RPSControlFactory.CreateRPSGridComboBox<SubTaskView>("","#16c40429-92c9-4b52-83d4-0237de1c0ccd .ag-row[role='row']@ROWINDEX [col-id='cIDResourceEmployee']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<SubTaskView> IDMachine { get; set; } 
        public IRPSGridComboBox<SubTaskView> IDMachineGroup { get; set; } 
        public IRPSGridCheckbox<SubTaskView> Planify { get; set; } 
        public IRPSGridTextBox<SubTaskView> DedicationPercent { get; set; } 
        public IRPSGridComboBox<SubTaskView> IDResourceEmployee { get; set; } 
                     
    }
 
        public partial class ResourceToolsCollectionEditor<SubTaskView,SubMaterialView>:RPSCollectionEditor<SubTaskView,SubMaterialView> where SubTaskView : class, IView where SubMaterialView : class, IView
    {
        public  ResourceToolsGridView<SubTaskView,SubMaterialView> GridView {get;set;}
    }
    public partial class ResourceToolsGridView <SubTaskView,SubMaterialView> :  RPSGridView<SubTaskView,SubMaterialView> where SubTaskView : class, IView where SubMaterialView : class, IView
    {
        public ResourceToolsGridView(SubTaskView currentView,SubMaterialView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDTool = RPSControlFactory.CreateRPSGridComboBox<SubTaskView>("","#4235348b-bd8b-426e-b8da-6eba28237279 .ag-row[role='row']@ROWINDEX [col-id='cIDTool']","",true, this.CurrentView);
 
            Planify = RPSControlFactory.CreateRPSGridCheckBox<SubTaskView>("","#4235348b-bd8b-426e-b8da-6eba28237279 .ag-row[role='row']@ROWINDEX [col-id='cPlanify']","",true, this.CurrentView);
 
            DedicationPercent = RPSControlFactory.CreateRPSGridFormattedTextBox<SubTaskView>("","#4235348b-bd8b-426e-b8da-6eba28237279 .ag-row[role='row']@ROWINDEX [col-id='cDedicationPercent']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<SubTaskView> IDTool { get; set; } 
        public IRPSGridCheckbox<SubTaskView> Planify { get; set; } 
        public IRPSGridTextBox<SubTaskView> DedicationPercent { get; set; } 
                     
    }
 
        public partial class TaskCostComponentsCollectionEditor<SubTaskView,SubMaterialView>:RPSCollectionEditor<SubTaskView,SubMaterialView> where SubTaskView : class, IView where SubMaterialView : class, IView
    {
        public  TaskCostComponentsGridView<SubTaskView,SubMaterialView> GridView {get;set;}
    }
    public partial class TaskCostComponentsGridView <SubTaskView,SubMaterialView> :  RPSGridView<SubTaskView,SubMaterialView> where SubTaskView : class, IView where SubMaterialView : class, IView
    {
        public TaskCostComponentsGridView(SubTaskView currentView,SubMaterialView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodTaskCostComponent = RPSControlFactory.CreateRPSGridTextBox<SubTaskView>("","#7f4e960c-7448-49b3-8aa2-891c662db2be .ag-row[role='row']@ROWINDEX [col-id='cCodTaskCostComponent']","",true, this.CurrentView);
 
            IDCostComponent = RPSControlFactory.CreateRPSGridComboBox<SubTaskView>("","#7f4e960c-7448-49b3-8aa2-891c662db2be .ag-row[role='row']@ROWINDEX [col-id='cIDCostComponent']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<SubTaskView>("","#7f4e960c-7448-49b3-8aa2-891c662db2be .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<SubTaskView>("","#7f4e960c-7448-49b3-8aa2-891c662db2be .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            Price = RPSControlFactory.CreateRPSGridFormattedTextBox<SubTaskView>("","#7f4e960c-7448-49b3-8aa2-891c662db2be .ag-row[role='row']@ROWINDEX [col-id='cPrice']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<SubTaskView> CodTaskCostComponent { get; set; } 
        public IRPSGridComboBox<SubTaskView> IDCostComponent { get; set; } 
        public IRPSGridTextBox<SubTaskView> Description { get; set; } 
        public IRPSGridTextBox<SubTaskView> Quantity { get; set; } 
        public IRPSGridTextBox<SubTaskView> Price { get; set; } 
                     
    }
 
        public partial class TaskDimensionsCollectionEditor<SubTaskView,SubMaterialView>:RPSCollectionEditor<SubTaskView,SubMaterialView> where SubTaskView : class, IView where SubMaterialView : class, IView
    {
        public  TaskDimensionsGridView<SubTaskView,SubMaterialView> GridView {get;set;}
    }
    public partial class TaskDimensionsGridView <SubTaskView,SubMaterialView> :  RPSGridView<SubTaskView,SubMaterialView> where SubTaskView : class, IView where SubMaterialView : class, IView
    {
        public TaskDimensionsGridView(SubTaskView currentView,SubMaterialView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDDimension = RPSControlFactory.CreateRPSGridComboBox<SubTaskView>("","#847c5370-8203-4693-8755-30d3a7399b3c .ag-row[role='row']@ROWINDEX [col-id='cIDDimension']","",true, this.CurrentView);
 
            IDDimValue = RPSControlFactory.CreateRPSGridComboBox<SubTaskView>("","#847c5370-8203-4693-8755-30d3a7399b3c .ag-row[role='row']@ROWINDEX [col-id='cIDDimValue']","",true, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<SubTaskView>("","#847c5370-8203-4693-8755-30d3a7399b3c .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<SubTaskView> IDDimension { get; set; } 
        public IRPSGridComboBox<SubTaskView> IDDimValue { get; set; } 
        public IRPSGridTextBox<SubTaskView> Percentage { get; set; } 
                     
    }
 
    }
  
            
    public partial class SubMaterialView : View
    {
        public SubMaterialView(Structure screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SubMaterialView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SubMaterialView,SubTaskView>( this,Screen.SubTaskView);
 
            BackButton = RPSControlFactory.RPSBackButton<SubMaterialView,SubTaskView>( this,Screen.SubTaskView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SubMaterialView,SubTaskView>( this,Screen.SubTaskView);
 
            CodMaterial = RPSControlFactory.CreateRPSTextBox<SubMaterialView>("afb2577b-13f7-44cf-83ee-b1e550d3d9b5","","",true, this);
 
            ArticleType = RPSControlFactory.CreateRPSEnumComboBox<SubMaterialView>("ae431836-2c66-4257-8867-dcab9aee7a1e","","",true, this);
 
            UIArticleType = RPSControlFactory.CreateRPSEnumComboBox<SubMaterialView>("d83511c2-dc45-429a-9be5-7b8794cee81f","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<SubMaterialView>("08930d54-e2ff-4ba7-b4e4-c31cd4c325fa","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<SubMaterialView>("d6cc0445-f1cb-4178-a4e2-a3378360af56","","",false, this);
 
            MaterialType = RPSControlFactory.CreateRPSEnumComboBox<SubMaterialView>("940a0be7-ec48-4b11-a4cd-01bfe75ca6dc","","",true, this);
 
            QuantityType = RPSControlFactory.CreateRPSEnumComboBox<SubMaterialView>("abc264a9-f0b1-4df2-b45d-0b208d037720","","",true, this);
 
            QuantityPercent = RPSControlFactory.CreateRPSFormattedTextBox<SubMaterialView>("a377cac7-1b9e-4c29-b716-97aa9356f5ba","","",true, this);
 
            QuantitySource = RPSControlFactory.CreateRPSEnumComboBox<SubMaterialView>("8334bf91-361e-4b7e-8fb9-11879dec388d","","",true, this);
 
            QuantityFormula = RPSControlFactory.CreateRPSTextBox<SubMaterialView>("22e90758-3d86-4db7-925b-43ee8dd8a9da","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<SubMaterialView>("3e54c8bd-0114-46f4-b0d0-864eaa75c4dd","","",false, this);
 
            ContentLot = RPSControlFactory.CreateRPSFormattedTextBox<SubMaterialView>("1cddb40a-926f-4653-b8d0-34ece0306d00","","",true, this);
 
            QuantityElements = RPSControlFactory.CreateRPSFormattedTextBox<SubMaterialView>("c2d807b7-ecf1-4b83-b43a-134a941a83ff","","",true, this);
 
            AdvanceDays = RPSControlFactory.CreateRPSFormattedTextBox<SubMaterialView>("3daf57f3-ce5c-46b3-ab1b-4e3c3a7d9800","","",true, this);
 
            IDBudgetCategory = RPSControlFactory.CreateRPSComboBox<SubMaterialView>("37ef98da-236c-4ff3-880c-8f49cccbe5ee","","",false, this);
 
            MakeAutomaticOutput = RPSControlFactory.CreateRPSCheckBox<SubMaterialView>("d59069d1-6118-41c3-a586-630f1adfb514","","",true, this);
 
            UseAlternativeArticles = RPSControlFactory.CreateRPSCheckBox<SubMaterialView>("70c9e028-6a67-44c3-a807-745a5a4df1a7","","",true, this);
 
            ImputationCostUpdated = RPSControlFactory.CreateRPSCheckBox<SubMaterialView>("51ae7f4b-d010-4ca3-b3b8-37fff07419ca","","",true, this);
 
            Critical = RPSControlFactory.CreateRPSCheckBox<SubMaterialView>("6cf85b3c-0b66-4169-a541-a82b8b1b4bc2","","",true, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<SubMaterialView>("c0acee4c-3049-43fb-b8a1-afce3f0c1c6c","","",true, this);
 
            IDWareHouse = RPSControlFactory.CreateRPSComboBox<SubMaterialView>("199db3f7-ad0a-4f5b-a921-86e6f7f90d2a","","",false, this);
 
            Notes = RPSControlFactory.CreateRPSTextBox<SubMaterialView>("f7220407-1499-4716-98d8-9346189b7429","","",false, this);
 
            DateActiveFrom = RPSControlFactory.CreateRPSTextBox<SubMaterialView>("df295604-154d-4993-8f07-fda90f62359a","","",false, this);
 
            DateActiveTo = RPSControlFactory.CreateRPSTextBox<SubMaterialView>("f62db540-c084-4dba-a3c1-43a567623088","","",false, this);
 
            MatchCode = RPSControlFactory.CreateRPSTextBox<SubMaterialView>("2388f604-e7ec-4df5-87af-12bfeb5cbe85","","",false, this);
 
            IsMandatory = RPSControlFactory.CreateRPSCheckBox<SubMaterialView>("02410bfa-debf-4dde-8a25-e7bbde1c39c4","","",true, this);
 
            CollectionInit params_MaterialAlternatives = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8f9a4ca4-30ee-4c7a-83cb-1f6d3102cfff",CSSSelectorGrid="",XPathGrid=""};
            MaterialAlternatives = RPSControlFactory.RPSCreateCollectionWithGrid<MaterialAlternativesCollectionEditor<SubMaterialView>,SubMaterialView>( params_MaterialAlternatives,this);
 
            SectionData = RPSControlFactory.CreateRPSSection<SubMaterialView>( "","ul li[rpsid='39b8e97b-7aa8-4228-a860-dfbe7d4c4d63']","",this);
 
            SectionArticleAlternative = RPSControlFactory.CreateRPSSection<SubMaterialView>( "","ul li[rpsid='5f80193f-ebd2-4493-b873-53f53bdb42b8']","",this);
 
            SectionDPS = RPSControlFactory.CreateRPSSection<SubMaterialView>( "","ul li[rpsid='f204d32a-75e6-4280-bfbe-5402bfb872fa']","",this);
 

        }
        public IRPSButton<SubMaterialView> DeleteButton { get; set; } 
        public IRPSButton<SubMaterialView,SubTaskView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SubMaterialView,SubTaskView> BackButton { get; set; } 
        public IRPSAcceptButton<SubMaterialView,SubTaskView> AcceptButton { get; set; } 
        public IRPSTextBox<SubMaterialView> CodMaterial { get; set; } 
        public IRPSComboBox<SubMaterialView> ArticleType { get; set; } 
        public IRPSComboBox<SubMaterialView> UIArticleType { get; set; } 
        public IRPSComboBox<SubMaterialView> IDArticle { get; set; } 
        public IRPSTextBox<SubMaterialView> Description { get; set; } 
        public IRPSComboBox<SubMaterialView> MaterialType { get; set; } 
        public IRPSComboBox<SubMaterialView> QuantityType { get; set; } 
        public IRPSTextBox<SubMaterialView> QuantityPercent { get; set; } 
        public IRPSComboBox<SubMaterialView> QuantitySource { get; set; } 
        public IRPSTextBox<SubMaterialView> QuantityFormula { get; set; } 
        public IRPSTextBox<SubMaterialView> Quantity { get; set; } 
        public IRPSTextBox<SubMaterialView> ContentLot { get; set; } 
        public IRPSTextBox<SubMaterialView> QuantityElements { get; set; } 
        public IRPSTextBox<SubMaterialView> AdvanceDays { get; set; } 
        public IRPSComboBox<SubMaterialView> IDBudgetCategory { get; set; } 
        public IRPSCheckbox<SubMaterialView> MakeAutomaticOutput { get; set; } 
        public IRPSCheckbox<SubMaterialView> UseAlternativeArticles { get; set; } 
        public IRPSCheckbox<SubMaterialView> ImputationCostUpdated { get; set; } 
        public IRPSCheckbox<SubMaterialView> Critical { get; set; } 
        public IRPSComboBox<SubMaterialView> IDSite { get; set; } 
        public IRPSComboBox<SubMaterialView> IDWareHouse { get; set; } 
        public IRPSTextBox<SubMaterialView> Notes { get; set; } 
        public IRPSTextBox<SubMaterialView> DateActiveFrom { get; set; } 
        public IRPSTextBox<SubMaterialView> DateActiveTo { get; set; } 
        public IRPSTextBox<SubMaterialView> MatchCode { get; set; } 
        public IRPSCheckbox<SubMaterialView> IsMandatory { get; set; } 
        public MaterialAlternativesCollectionEditor<SubMaterialView> MaterialAlternatives { get; set; } 
        public IRPSSection<SubMaterialView> SectionData { get; set; } 
        public IRPSSection<SubMaterialView> SectionArticleAlternative { get; set; } 
        public IRPSSection<SubMaterialView> SectionDPS { get; set; } 
        public Structure Screen { get; set; }
        public SubMaterialView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaterialAlternativesCollectionEditor<SubMaterialView>:RPSCollectionEditor<SubMaterialView> where SubMaterialView : class, IView
    {
        public  MaterialAlternativesGridView<SubMaterialView> GridView {get;set;}
    }
    public partial class MaterialAlternativesGridView <SubMaterialView> :  RPSGridView<SubMaterialView> where SubMaterialView : class, IView
    {
        public MaterialAlternativesGridView(SubMaterialView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<SubMaterialView>("","#8f9a4ca4-30ee-4c7a-83cb-1f6d3102cfff .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            Priority = RPSControlFactory.CreateRPSGridFormattedTextBox<SubMaterialView>("","#8f9a4ca4-30ee-4c7a-83cb-1f6d3102cfff .ag-row[role='row']@ROWINDEX [col-id='cPriority']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<SubMaterialView> IDArticle { get; set; } 
        public IRPSGridTextBox<SubMaterialView> Priority { get; set; } 
                     
    }
 
    }
  
            
    public partial class StructureFormulaDV : View
    {
        public StructureFormulaDV(Structure screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Formula = RPSControlFactory.CreateRPSTextBox<StructureFormulaDV>("0c78343f-62c6-4069-bd38-a1e980bbaa94","","",false, this);
 
            Structure = RPSControlFactory.CreateRPSEnumComboBox<StructureFormulaDV>("51072de2-10b2-4876-a0c9-107498da0940","","",false, this);
 
            Task = RPSControlFactory.CreateRPSEnumComboBox<StructureFormulaDV>("3417ffb4-87af-42e0-a636-b4114e3ef79d","","",false, this);
 
            Materials = RPSControlFactory.CreateRPSEnumComboBox<StructureFormulaDV>("e026b413-afd7-4211-99e6-e42072661592","","",false, this);
 
            Article = RPSControlFactory.CreateRPSEnumComboBox<StructureFormulaDV>("9da87065-3003-4336-b2dc-046fa5d4d379","","",false, this);
 
            AddButton = RPSControlFactory.CreateRPSButton<StructureFormulaDV>( "5e080f82-8677-48b6-9530-32d260df3ae5","","",this);
 
            VerifyCommand = RPSControlFactory.CreateRPSButton<StructureFormulaDV>( "da2da2b1-b8d8-427e-9753-64d1b209b732","","",this);
 
            OkCommand = RPSControlFactory.CreateRPSButton<StructureFormulaDV>( "7fa82d95-9e5b-4a74-9923-1e0d619de2bc","","",this);
 

        }
        public IRPSTextBox<StructureFormulaDV> Formula { get; set; } 
        public IRPSComboBox<StructureFormulaDV> Structure { get; set; } 
        public IRPSComboBox<StructureFormulaDV> Task { get; set; } 
        public IRPSComboBox<StructureFormulaDV> Materials { get; set; } 
        public IRPSComboBox<StructureFormulaDV> Article { get; set; } 
        public IRPSButton<StructureFormulaDV> AddButton { get; set; } 
        public IRPSButton<StructureFormulaDV> VerifyCommand { get; set; } 
        public IRPSButton<StructureFormulaDV> OkCommand { get; set; } 
        public Structure Screen { get; set; }
        public StructureFormulaDV Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}