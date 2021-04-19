    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.Project
{
    //RPS VERSION 1.0.0.0
    public partial class Project:Screen
    {
        public Project():base()
        {
            this.URL = "project.project";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ProjectCollectionView  = new ProjectCollectionView(this); 
            ProjectEntityView  = new ProjectEntityView(this); 
            ProjectFeatureView  = new ProjectFeatureView(this); 
            ProjectAlertView  = new ProjectAlertView(this); 
            ProjectDimensionView  = new ProjectDimensionView(this); 
            ProjectTaskView  = new ProjectTaskView(this); 
            ProjectTaskDimensionView  = new ProjectTaskDimensionView(this); 
            ProjectMaterialView  = new ProjectMaterialView(this); 
            ProjectResourceEmployeeView  = new ProjectResourceEmployeeView(this); 
            ProjectResourceMachineView  = new ProjectResourceMachineView(this); 
            ProjectResourceToolView  = new ProjectResourceToolView(this); 
            ProjectTaskCostComponentView  = new ProjectTaskCostComponentView(this); 
            ProjectTaskRelationView  = new ProjectTaskRelationView(this); 
            NewProjectVersionDialogDialogView  = new NewProjectVersionDialogDialogView(this); 
            CreateProjectFromTaskDialogView  = new CreateProjectFromTaskDialogView(this); 
            AddUsualTaskDialogView  = new AddUsualTaskDialogView(this); 
            ImportTaskDialogView  = new ImportTaskDialogView(this); 
            AssignEmployeesDialogView  = new AssignEmployeesDialogView(this); 
            ProjectUserView  = new ProjectUserView(this); 
            CopyFromProjectSourceChildDialogView  = new CopyFromProjectSourceChildDialogView(this); 
            ProjectChangeSitutationChildDialogView  = new ProjectChangeSitutationChildDialogView(this); 
            GenerateSupplysDialogView  = new GenerateSupplysDialogView(this); 
            GenerateSupplysForTaskDialogView  = new GenerateSupplysForTaskDialogView(this); 
            SupplysUpdateOptionsScreenDialogView  = new SupplysUpdateOptionsScreenDialogView(this); 
            DetailsFromProjectIndicatorValueDialogView  = new DetailsFromProjectIndicatorValueDialogView(this); 
            ReportOptionsDialogView  = new ReportOptionsDialogView(this); 
            ProjectTaskCategoryView  = new ProjectTaskCategoryView(this); 
            ProjectMaterialChangeStatusDialogView  = new ProjectMaterialChangeStatusDialogView(this); 
            ProjectPlanningDateDialogView  = new ProjectPlanningDateDialogView(this); 
            ProjectTaskLinkedDialogView  = new ProjectTaskLinkedDialogView(this); 
            CuDistSplitOfTaskPopUpDialogView  = new CuDistSplitOfTaskPopUpDialogView(this); 
            ProjectCollectionView.InitializeControls(); 
            ProjectEntityView.InitializeControls(); 
            ProjectFeatureView.InitializeControls(); 
            ProjectAlertView.InitializeControls(); 
            ProjectDimensionView.InitializeControls(); 
            ProjectTaskView.InitializeControls(); 
            ProjectTaskDimensionView.InitializeControls(); 
            ProjectMaterialView.InitializeControls(); 
            ProjectResourceEmployeeView.InitializeControls(); 
            ProjectResourceMachineView.InitializeControls(); 
            ProjectResourceToolView.InitializeControls(); 
            ProjectTaskCostComponentView.InitializeControls(); 
            ProjectTaskRelationView.InitializeControls(); 
            NewProjectVersionDialogDialogView.InitializeControls(); 
            CreateProjectFromTaskDialogView.InitializeControls(); 
            AddUsualTaskDialogView.InitializeControls(); 
            ImportTaskDialogView.InitializeControls(); 
            AssignEmployeesDialogView.InitializeControls(); 
            ProjectUserView.InitializeControls(); 
            CopyFromProjectSourceChildDialogView.InitializeControls(); 
            ProjectChangeSitutationChildDialogView.InitializeControls(); 
            GenerateSupplysDialogView.InitializeControls(); 
            GenerateSupplysForTaskDialogView.InitializeControls(); 
            SupplysUpdateOptionsScreenDialogView.InitializeControls(); 
            DetailsFromProjectIndicatorValueDialogView.InitializeControls(); 
            ReportOptionsDialogView.InitializeControls(); 
            ProjectTaskCategoryView.InitializeControls(); 
            ProjectMaterialChangeStatusDialogView.InitializeControls(); 
            ProjectPlanningDateDialogView.InitializeControls(); 
            ProjectTaskLinkedDialogView.InitializeControls(); 
            CuDistSplitOfTaskPopUpDialogView.InitializeControls(); 
           
        }
      
            public ProjectCollectionView ProjectCollectionView {get; set; } 
            public ProjectEntityView ProjectEntityView {get; set; } 
            public ProjectFeatureView ProjectFeatureView {get; set; } 
            public ProjectAlertView ProjectAlertView {get; set; } 
            public ProjectDimensionView ProjectDimensionView {get; set; } 
            public ProjectTaskView ProjectTaskView {get; set; } 
            public ProjectTaskDimensionView ProjectTaskDimensionView {get; set; } 
            public ProjectMaterialView ProjectMaterialView {get; set; } 
            public ProjectResourceEmployeeView ProjectResourceEmployeeView {get; set; } 
            public ProjectResourceMachineView ProjectResourceMachineView {get; set; } 
            public ProjectResourceToolView ProjectResourceToolView {get; set; } 
            public ProjectTaskCostComponentView ProjectTaskCostComponentView {get; set; } 
            public ProjectTaskRelationView ProjectTaskRelationView {get; set; } 
            public NewProjectVersionDialogDialogView NewProjectVersionDialogDialogView {get; set; } 
            public CreateProjectFromTaskDialogView CreateProjectFromTaskDialogView {get; set; } 
            public AddUsualTaskDialogView AddUsualTaskDialogView {get; set; } 
            public ImportTaskDialogView ImportTaskDialogView {get; set; } 
            public AssignEmployeesDialogView AssignEmployeesDialogView {get; set; } 
            public ProjectUserView ProjectUserView {get; set; } 
            public CopyFromProjectSourceChildDialogView CopyFromProjectSourceChildDialogView {get; set; } 
            public ProjectChangeSitutationChildDialogView ProjectChangeSitutationChildDialogView {get; set; } 
            public GenerateSupplysDialogView GenerateSupplysDialogView {get; set; } 
            public GenerateSupplysForTaskDialogView GenerateSupplysForTaskDialogView {get; set; } 
            public SupplysUpdateOptionsScreenDialogView SupplysUpdateOptionsScreenDialogView {get; set; } 
            public DetailsFromProjectIndicatorValueDialogView DetailsFromProjectIndicatorValueDialogView {get; set; } 
            public ReportOptionsDialogView ReportOptionsDialogView {get; set; } 
            public ProjectTaskCategoryView ProjectTaskCategoryView {get; set; } 
            public ProjectMaterialChangeStatusDialogView ProjectMaterialChangeStatusDialogView {get; set; } 
            public ProjectPlanningDateDialogView ProjectPlanningDateDialogView {get; set; } 
            public ProjectTaskLinkedDialogView ProjectTaskLinkedDialogView {get; set; } 
            public CuDistSplitOfTaskPopUpDialogView CuDistSplitOfTaskPopUpDialogView {get; set; } 
    }
            
    public partial class ProjectCollectionView : View
    {
        public ProjectCollectionView(Project screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ProjectCollectionView,ProjectEntityView>( this,Screen.ProjectEntityView);
 
            CopyFromProjectSourceChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ProjectCollectionView,CopyFromProjectSourceChildDialogView>("6cf0b35e-69f3-4b40-a71d-43243aa644b5","","", this,Screen.CopyFromProjectSourceChildDialogView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "7a214617-6ba9-4202-97e7-72765067822b",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ProjectCollectionView,ProjectEntityView>( params_MainConsult,this,Screen.ProjectEntityView);
 

        }
        public IRPSButton<ProjectCollectionView,ProjectEntityView> NewButton { get; set; } 
        public IRPSButton<ProjectCollectionView,CopyFromProjectSourceChildDialogView> CopyFromProjectSourceChildNavigationCommandButton { get; set; } 
        public IRPSCollectionEditor<ProjectCollectionView,ProjectEntityView> MainConsult { get; set; } 
        public Project Screen { get; set; }
        public ProjectCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ProjectEntityView : View
    {
        public ProjectEntityView(Project screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ProjectEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ProjectEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ProjectEntityView,ProjectCollectionView>( this,Screen.ProjectCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ProjectEntityView,ProjectCollectionView>( this,Screen.ProjectCollectionView);
 
            CodProject = RPSControlFactory.CreateRPSTextBox<ProjectEntityView>("59d0ba3c-a294-4441-b804-c5a58ce84f40","","",true, this);
 
            Version = RPSControlFactory.CreateRPSTextBox<ProjectEntityView>("3976e5af-46ee-47cd-871a-af573adf4f0a","","",true, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<ProjectEntityView>("9dd8daa3-2af1-4158-9c58-70e7eceae8f4","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ProjectEntityView>("7a66764d-bbb9-4323-a333-923794fa0414","","",false, this);
 
            Final = RPSControlFactory.CreateRPSCheckBox<ProjectEntityView>("47ecac4d-c16a-47ef-935e-05ca7fd72729","","",true, this);
 
            BudgetClosed = RPSControlFactory.CreateRPSCheckBox<ProjectEntityView>("716a3956-ab10-4168-8927-12a211c1c65e","","",true, this);
 
            PlanningDirection = RPSControlFactory.CreateRPSEnumComboBox<ProjectEntityView>("02c3dba3-45df-4c45-8c71-fa6ccab496a2","","",true, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<ProjectEntityView>("bef492ca-a884-4cd1-af0c-54acc10962df","","",false, this);
 
            IDPROSituation = RPSControlFactory.CreateRPSComboBox<ProjectEntityView>("d9329756-27d6-4e95-82d2-a42947863fab","","",true, this);
 
            IDProjectType = RPSControlFactory.CreateRPSComboBox<ProjectEntityView>("defe57d6-7be1-4a80-9ae0-c533e81ef267","","",true, this);
 
            Color = RPSControlFactory.CreateRPSColorEditor<ProjectEntityView>( "2a079a81-0ca6-4389-891e-1b05b323a73a","","",this);
 
            UIOptCustomer = RPSControlFactory.CreateRPSOption<ProjectEntityView>( "3346e5fa-5059-4caf-8ebd-4efeae325567","","",this);
 
            UIOptPotential = RPSControlFactory.CreateRPSOption<ProjectEntityView>( "c58eaba6-93fc-4c90-867b-76912573bb40","","",this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<ProjectEntityView>("17f3de06-bcc6-4bcd-81d5-56b8ad5a2257","","",false, this);
 
            IDPotentialCustomer = RPSControlFactory.CreateRPSComboBox<ProjectEntityView>("ea12ed3e-ba18-4d3d-90a3-b183fc5832e1","","",false, this);
 
            IDOportunity = RPSControlFactory.CreateRPSComboBox<ProjectEntityView>("53f89240-2efb-4011-853e-e2604a4db971","","",false, this);
 
            PlannedStartDate = RPSControlFactory.CreateRPSTextBox<ProjectEntityView>("9354b499-2347-4e4d-87ec-68697d982953","","",true, this);
 
            PlannedStartTime = RPSControlFactory.CreateRPSTextBox<ProjectEntityView>("1432f1ba-5b74-43b8-9968-68d994d485ad","","",false, this);
 
            PlannedEndDate = RPSControlFactory.CreateRPSTextBox<ProjectEntityView>("0b73a66c-76ed-4d48-bf03-d6f113e14363","","",true, this);
 
            PlannedEndTime = RPSControlFactory.CreateRPSTextBox<ProjectEntityView>("e62f2e49-e027-4b67-8126-024dca71be8f","","",true, this);
 
            ManualEndCustomerDate = RPSControlFactory.CreateRPSTextBox<ProjectEntityView>("cad4a6de-5f24-4b64-8384-a3741451b579","","",true, this);
 
            PlannedEndMRPDate = RPSControlFactory.CreateRPSTextBox<ProjectEntityView>("b4870155-bcf7-4214-bf0d-8f1fa9f78c53","","",false, this);
 
            RealEndDate = RPSControlFactory.CreateRPSTextBox<ProjectEntityView>("c32d7885-158d-42ff-b1d7-d09cb9580dbf","","",false, this);
 
            AcceptedDate = RPSControlFactory.CreateRPSTextBox<ProjectEntityView>("5b6dee01-58c1-4d3f-98a1-59cd2abf18c1","","",false, this);
 
            ManualPStartDate = RPSControlFactory.CreateRPSTextBox<ProjectEntityView>("bb1cb069-6520-44e4-86b4-a2455631ee75","","",false, this);
 
            ManualPEndDate = RPSControlFactory.CreateRPSTextBox<ProjectEntityView>("0d34b52a-85b9-4453-958c-cfff65919f89","","",false, this);
 
            IDEmployeeTechnical = RPSControlFactory.CreateRPSComboBox<ProjectEntityView>("ec0745be-365a-44af-a090-9e4c37a0858d","","",false, this);
 
            CreateResponsibleResource = RPSControlFactory.CreateRPSCheckBox<ProjectEntityView>("dc0ce266-53a5-4fc4-84e1-c5e21cf7605a","","",true, this);
 
            IDEmployeeCommercial = RPSControlFactory.CreateRPSComboBox<ProjectEntityView>("04e0fc32-f41c-4f18-8d55-493a6b2bda15","","",false, this);
 
            TimeUnitDefault = RPSControlFactory.CreateRPSEnumComboBox<ProjectEntityView>("2cbd8926-0a4d-495a-b1f3-5e5ad91c460e","","",true, this);
 
            WarningThreshold = RPSControlFactory.CreateRPSFormattedTextBox<ProjectEntityView>("ae81ff93-e512-4073-880b-5af7b904fafc","","",true, this);
 
            BlockingThreshold = RPSControlFactory.CreateRPSFormattedTextBox<ProjectEntityView>("8a0f7f2e-c12a-4a70-ae9d-5d909475375a","","",true, this);
 
            SendResponsibleMessage = RPSControlFactory.CreateRPSCheckBox<ProjectEntityView>("efa60df3-49f1-410f-bc69-83d4d6998401","","",true, this);
 
            AutomaticCodification = RPSControlFactory.CreateRPSCheckBox<ProjectEntityView>("15970057-7a5f-4999-8b35-69e5dfe0f016","","",true, this);
 
            QuantityReference = RPSControlFactory.CreateRPSFormattedTextBox<ProjectEntityView>("94d0314a-4b28-4b40-8fdc-50a41a2bb6ce","","",true, this);
 
            PercentProfit = RPSControlFactory.CreateRPSFormattedTextBox<ProjectEntityView>("708c39a9-9062-49cd-ad2b-7714917fae8a","","",true, this);
 
            Priority = RPSControlFactory.CreateRPSFormattedTextBox<ProjectEntityView>("60b3c14f-00da-45d7-9456-3a3cc28dc219","","",true, this);
 
            Group = RPSControlFactory.CreateRPSTextBox<ProjectEntityView>("6a9a5fdb-43e7-4c18-acd2-36895973b97c","","",false, this);
 
            CalcAmountSale = RPSControlFactory.CreateRPSFormattedTextBox<ProjectEntityView>("72db98bc-e1c8-4697-bdfd-34e42ab18f91","","",false, this);
 
            CalcOfferedEmployee = RPSControlFactory.CreateRPSFormattedTextBox<ProjectEntityView>("4ff5de87-04d9-434f-baf3-73ce65b4cac1","","",false, this);
 
            CalcOfferedMaterial = RPSControlFactory.CreateRPSFormattedTextBox<ProjectEntityView>("3aa6f102-8606-4912-a836-3dcfb4785959","","",false, this);
 
            CalcOfferedMachine = RPSControlFactory.CreateRPSFormattedTextBox<ProjectEntityView>("f2d376c2-a357-4fa8-a9fa-825b8325a9f3","","",false, this);
 
            CalcOfferedOtherCost = RPSControlFactory.CreateRPSFormattedTextBox<ProjectEntityView>("536220a4-f9f6-4fda-b337-0050af832dc2","","",false, this);
 
            CalcOfferedTool = RPSControlFactory.CreateRPSFormattedTextBox<ProjectEntityView>("5b460fb3-f32f-4639-967c-4edf45d3743c","","",false, this);
 
            CalcOfferedExternal = RPSControlFactory.CreateRPSFormattedTextBox<ProjectEntityView>("0f5fcf48-547c-4a6d-809f-b745fcdc148a","","",false, this);
 
            CalcOffered = RPSControlFactory.CreateRPSFormattedTextBox<ProjectEntityView>("df7afe96-cbfb-4e76-8f77-dea727d43ccb","","",false, this);
 
            CalcOfferedHours = RPSControlFactory.CreateRPSFormattedTextBox<ProjectEntityView>("ecfd7290-c1da-49df-ad62-6e914f58d49d","","",false, this);
 
            CalcAmountCostInitialEmployee = RPSControlFactory.CreateRPSFormattedTextBox<ProjectEntityView>("81852a49-a439-4112-85da-d6fd98054f2e","","",false, this);
 
            CalcAmountCostInitialMaterial = RPSControlFactory.CreateRPSFormattedTextBox<ProjectEntityView>("e11c52da-65ef-4bf4-a212-aa39b3b23465","","",false, this);
 
            CalcAmountCostInitialMachine = RPSControlFactory.CreateRPSFormattedTextBox<ProjectEntityView>("9200e00c-ddac-4ddd-9806-2d23707d1632","","",false, this);
 
            CalcAmountCostInitialOtherCost = RPSControlFactory.CreateRPSFormattedTextBox<ProjectEntityView>("cf4dbe8f-9941-4143-b5d1-4e0a5d992f71","","",false, this);
 
            CalcAmountCostInitialTool = RPSControlFactory.CreateRPSFormattedTextBox<ProjectEntityView>("3a630208-d0bb-4d37-90e9-4dac6840de41","","",false, this);
 
            CalcAmountCostInitialExternal = RPSControlFactory.CreateRPSFormattedTextBox<ProjectEntityView>("96e022c0-4cf4-4f71-ac87-d522264b526e","","",false, this);
 
            CalcAmountBudgetInCategory = RPSControlFactory.CreateRPSFormattedTextBox<ProjectEntityView>("92ac953f-4ea1-49a3-9f11-51462a12611f","","",false, this);
 
            CalcAmountCostInitial = RPSControlFactory.CreateRPSFormattedTextBox<ProjectEntityView>("27ee5de9-c62b-47c9-8a06-38808017e516","","",false, this);
 
            CalcHourInitial = RPSControlFactory.CreateRPSFormattedTextBox<ProjectEntityView>("dc6dab84-67fb-47cd-b5ec-577b977bbdfc","","",false, this);
 
            CalcAmountCostTheoricEmployee = RPSControlFactory.CreateRPSFormattedTextBox<ProjectEntityView>("01b3d6bb-590f-470a-b0c5-22cc4323ed40","","",false, this);
 
            CalcAmountCostTheoricMaterial = RPSControlFactory.CreateRPSFormattedTextBox<ProjectEntityView>("fd6b0a22-84a9-438c-a091-d352df319708","","",false, this);
 
            CalcAmountCostTheoricMachine = RPSControlFactory.CreateRPSFormattedTextBox<ProjectEntityView>("55909d6c-d6a9-4c9a-8a13-cb8be253d4a4","","",false, this);
 
            CalcAmountCostTheoricOtherCost = RPSControlFactory.CreateRPSFormattedTextBox<ProjectEntityView>("7a213c14-0499-494a-a696-3beb72efa503","","",false, this);
 
            CalcAmountCostTheoricTool = RPSControlFactory.CreateRPSFormattedTextBox<ProjectEntityView>("8d33bfcd-554d-4a88-bac0-c7396f859ee1","","",false, this);
 
            CalcAmountCostTheoricExternal = RPSControlFactory.CreateRPSFormattedTextBox<ProjectEntityView>("48de339e-1a10-479f-a84d-5fb64d74aa9b","","",false, this);
 
            CalcAmountCost = RPSControlFactory.CreateRPSFormattedTextBox<ProjectEntityView>("af4383de-0cb1-40e3-9c5a-0008b8ec3ee1","","",false, this);
 
            CalcHourEstimated = RPSControlFactory.CreateRPSFormattedTextBox<ProjectEntityView>("28251842-b90d-4a24-af59-9959cdfe5510","","",false, this);
 
            CalcHourEstimatedNotPlanify = RPSControlFactory.CreateRPSFormattedTextBox<ProjectEntityView>("7f027772-5d5e-4f65-a658-903b4fd0ac84","","",false, this);
 
            CalcAmountCostRealEmployee = RPSControlFactory.CreateRPSFormattedTextBox<ProjectEntityView>("4b71aa2b-d431-4345-bc63-6e8f8595228e","","",false, this);
 
            CalcAmountCostRealMaterial = RPSControlFactory.CreateRPSFormattedTextBox<ProjectEntityView>("b6f4ff18-40d1-4b35-8a78-e8ae02ae85e4","","",false, this);
 
            CalcAmountCostRealMachine = RPSControlFactory.CreateRPSFormattedTextBox<ProjectEntityView>("6abacd26-bb0a-4c86-9ad1-4f163d657f4a","","",false, this);
 
            CalcAmountCostRealOtherCost = RPSControlFactory.CreateRPSFormattedTextBox<ProjectEntityView>("7fd86561-1e3b-46b9-9443-126c75b9a951","","",false, this);
 
            CalcAmountCostRealTool = RPSControlFactory.CreateRPSFormattedTextBox<ProjectEntityView>("436195eb-d769-46b7-8d74-e5c594b20255","","",false, this);
 
            CalcAmountCostRealExternal = RPSControlFactory.CreateRPSFormattedTextBox<ProjectEntityView>("971cc040-ac94-4ae2-a07d-aef34719f6bd","","",false, this);
 
            CalcAmountCostReal = RPSControlFactory.CreateRPSFormattedTextBox<ProjectEntityView>("9b1869a1-fb28-4af0-b2d8-b825b76001ff","","",false, this);
 
            CalcHourReal = RPSControlFactory.CreateRPSFormattedTextBox<ProjectEntityView>("2568738f-043a-4ee5-a57f-c14de2abd0a2","","",false, this);
 
            CalcHourRealNotPlanify = RPSControlFactory.CreateRPSFormattedTextBox<ProjectEntityView>("05bddee8-9584-4f1f-add8-ce00cbb20780","","",false, this);
 
            Notes = RPSControlFactory.CreateRPSTextBox<ProjectEntityView>("09d87fd2-06a7-4d12-b16c-80caf9fb24e8","","",false, this);
 
            SetProjectIndicatorInStudyCommand = RPSControlFactory.CreateRPSButton<ProjectEntityView>( "a0ffc18e-bcb6-42e8-8cd7-66cbdecda351","","",this);
 
            FinalizeIndicatorStudyCommand = RPSControlFactory.CreateRPSButton<ProjectEntityView>( "3fb71069-58f1-445b-8aaa-5759c8ad52c7","","",this);
 
            ReportOptionsNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ProjectEntityView,ReportOptionsDialogView>("7b29c8ff-b4b7-4086-84da-2de1eb8a7a78","","", this,Screen.ReportOptionsDialogView);
 
            AddUsualTaskNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ProjectEntityView,AddUsualTaskDialogView>("8251bd55-2295-4ad4-bf5c-73ed06a30d75","","", this,Screen.AddUsualTaskDialogView);
 
            PlanifyProjectCommandButton = RPSControlFactory.CreateRPSButton<ProjectEntityView>( "edd91712-c894-4d77-8ba1-3725d65c7f69","","",this);
 
            ProjectChangeSitutationChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ProjectEntityView,ProjectChangeSitutationChildDialogView>("33aa3a0f-b046-4429-98da-e757f41d4c3a","","", this,Screen.ProjectChangeSitutationChildDialogView);
 
            GenerateSupplysNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ProjectEntityView,GenerateSupplysDialogView>("8af0d12b-cefc-4a54-acf6-bf66021a327a","","", this,Screen.GenerateSupplysDialogView);
 
            ExecuteProjectMaterialAutomaticAllocationButton = RPSControlFactory.CreateRPSButton<ProjectEntityView>( "4ed172b8-c3f6-4e5c-8066-909c33d7a507","","",this);
 
            ExecuteRecalculateProjectInitialDataButton = RPSControlFactory.CreateRPSButton<ProjectEntityView>( "2faed6b9-8390-4927-bc8d-2694b9854a30","","",this);
 
            NewProjectVersionDialogNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ProjectEntityView,NewProjectVersionDialogDialogView>("5bf02280-4cf7-4bfa-acab-18ae6c0c26c9","","", this,Screen.NewProjectVersionDialogDialogView);
 
            ImportTaskNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ProjectEntityView,ImportTaskDialogView>("055b4b69-ca1b-4a94-a3c5-1d5ddcab0460","","", this,Screen.ImportTaskDialogView);
 
            AssignEmployeesNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ProjectEntityView,AssignEmployeesDialogView>("215e30d7-1b43-40d1-9e05-76c0511b8de4","","", this,Screen.AssignEmployeesDialogView);
 
            CreateNewBaseLineCommandButton = RPSControlFactory.CreateRPSButton<ProjectEntityView>( "5d3f560f-227e-4758-90ea-f48378332bb0","","",this);
 
            ExportToMSProjectNavigationCommandButton = RPSControlFactory.CreateRPSButton<ProjectEntityView>( "32c4613c-0e3c-4af4-8fcc-70bc51562020","","",this);
 
            CreateWarningCommandButton = RPSControlFactory.CreateRPSButton<ProjectEntityView>( "fcdc23b8-3fec-4ab3-b6a5-893dfff89196","","",this);
 
            PlanningProjectCommandButton = RPSControlFactory.CreateRPSButton<ProjectEntityView>( "ad29a894-cbcb-4288-ae4e-0c69e2d1b24a","","",this);
 
            ProMRPNavigationCommandButton = RPSControlFactory.CreateRPSButton<ProjectEntityView>( "632301f8-e82f-472e-a9b4-7d5d21aa124e","","",this);
 
            CollectionInit params_ProjectTasks = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="02bf6a91-dc4d-42b9-9a4e-9a7cf1930e88",CSSSelectorGrid="",XPathGrid=""};
            ProjectTasks = RPSControlFactory.RPSCreateCollectionWithGrid<ProjectTasksCollectionEditor<ProjectEntityView,ProjectTaskView>,ProjectEntityView,ProjectTaskView>( params_ProjectTasks,this,Screen.ProjectTaskView);
 
            CollectionInit params_ProjectFeatures = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7e43de01-4011-4d49-8cd3-c69dc31d0fd6",CSSSelectorGrid="",XPathGrid=""};
            ProjectFeatures = RPSControlFactory.RPSCreateCollectionWithGrid<ProjectFeaturesCollectionEditor<ProjectEntityView,ProjectTaskView>,ProjectEntityView,ProjectTaskView>( params_ProjectFeatures,this,Screen.ProjectTaskView);
 
            CollectionInit params_ProjectUsers = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7451b315-f0f3-491f-bf49-7763d266391c",CSSSelectorGrid="",XPathGrid=""};
            ProjectUsers = RPSControlFactory.RPSCreateCollectionWithGrid<ProjectUsersCollectionEditor<ProjectEntityView,ProjectTaskView>,ProjectEntityView,ProjectTaskView>( params_ProjectUsers,this,Screen.ProjectTaskView);
 
            CollectionInit params_ProjectAlerts = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="496090d7-0535-4bbb-9e6c-a5b93c0cc6e9",CSSSelectorGrid="",XPathGrid=""};
            ProjectAlerts = RPSControlFactory.RPSCreateCollectionWithGrid<ProjectAlertsCollectionEditor<ProjectEntityView,ProjectTaskView>,ProjectEntityView,ProjectTaskView>( params_ProjectAlerts,this,Screen.ProjectTaskView);
 
            CollectionInit params_ProjectDimensions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1fd323ce-42ee-432f-823d-45d8d37b6cea",CSSSelectorGrid="",XPathGrid=""};
            ProjectDimensions = RPSControlFactory.RPSCreateCollectionWithGrid<ProjectDimensionsCollectionEditor<ProjectEntityView,ProjectTaskView>,ProjectEntityView,ProjectTaskView>( params_ProjectDimensions,this,Screen.ProjectTaskView);
 
            SectionGantt = RPSControlFactory.CreateRPSSection<ProjectEntityView>( "","ul li[rpsid='533160b8-3af6-4952-bd92-5981f8253b3f']","",this);
 
            SectionTasks = RPSControlFactory.CreateRPSSection<ProjectEntityView>( "","ul li[rpsid='464297d0-fbba-4920-805f-72a5e7622823']","",this);
 
            SectionGeneral = RPSControlFactory.CreateRPSSection<ProjectEntityView>( "","ul li[rpsid='b5294b1d-0ada-4b38-bd40-6f292b52586f']","",this);
 
            SectionCostAnalysis = RPSControlFactory.CreateRPSSection<ProjectEntityView>( "","ul li[rpsid='6d49523b-de25-4349-a206-08642b7713b3']","",this);
 
            SectionNotes = RPSControlFactory.CreateRPSSection<ProjectEntityView>( "","ul li[rpsid='3bf6d8d4-bd04-45d6-8c3b-8fb741fc1150']","",this);
 
            SectionFeatures = RPSControlFactory.CreateRPSSection<ProjectEntityView>( "","ul li[rpsid='4f1534f7-1021-4ad1-bfd8-d84af0439694']","",this);
 
            SectionUsers = RPSControlFactory.CreateRPSSection<ProjectEntityView>( "","ul li[rpsid='0af14593-d7b2-46ac-80aa-52aeea312695']","",this);
 
            SectionAlerts = RPSControlFactory.CreateRPSSection<ProjectEntityView>( "","ul li[rpsid='92470171-8436-4bbc-954b-5f392dd09a86']","",this);
 
            SectionDimensions = RPSControlFactory.CreateRPSSection<ProjectEntityView>( "","ul li[rpsid='09ce0402-a014-4d69-afc7-1985ceaf40f7']","",this);
 
            IndicatorValues = RPSControlFactory.CreateRPSSection<ProjectEntityView>( "","ul li[rpsid='e72c84f5-4ab0-4b04-8299-c6c53e2ff9f3']","",this);
 

        }
        public IRPSSaveButton<ProjectEntityView> SaveButton { get; set; } 
        public IRPSButton<ProjectEntityView> DeleteButton { get; set; } 
        public IRPSButton<ProjectEntityView,ProjectCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ProjectEntityView,ProjectCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ProjectEntityView> CodProject { get; set; } 
        public IRPSTextBox<ProjectEntityView> Version { get; set; } 
        public IRPSComboBox<ProjectEntityView> IDSite { get; set; } 
        public IRPSTextBox<ProjectEntityView> Description { get; set; } 
        public IRPSCheckbox<ProjectEntityView> Final { get; set; } 
        public IRPSCheckbox<ProjectEntityView> BudgetClosed { get; set; } 
        public IRPSComboBox<ProjectEntityView> PlanningDirection { get; set; } 
        public IRPSComboBox<ProjectEntityView> IDArticle { get; set; } 
        public IRPSComboBox<ProjectEntityView> IDPROSituation { get; set; } 
        public IRPSComboBox<ProjectEntityView> IDProjectType { get; set; } 
        public IRPSColorEditor<ProjectEntityView> Color { get; set; } 
        public IRPSOption<ProjectEntityView> UIOptCustomer { get; set; } 
        public IRPSOption<ProjectEntityView> UIOptPotential { get; set; } 
        public IRPSComboBox<ProjectEntityView> IDCustomer { get; set; } 
        public IRPSComboBox<ProjectEntityView> IDPotentialCustomer { get; set; } 
        public IRPSComboBox<ProjectEntityView> IDOportunity { get; set; } 
        public IRPSTextBox<ProjectEntityView> PlannedStartDate { get; set; } 
        public IRPSTextBox<ProjectEntityView> PlannedStartTime { get; set; } 
        public IRPSTextBox<ProjectEntityView> PlannedEndDate { get; set; } 
        public IRPSTextBox<ProjectEntityView> PlannedEndTime { get; set; } 
        public IRPSTextBox<ProjectEntityView> ManualEndCustomerDate { get; set; } 
        public IRPSTextBox<ProjectEntityView> PlannedEndMRPDate { get; set; } 
        public IRPSTextBox<ProjectEntityView> RealEndDate { get; set; } 
        public IRPSTextBox<ProjectEntityView> AcceptedDate { get; set; } 
        public IRPSTextBox<ProjectEntityView> ManualPStartDate { get; set; } 
        public IRPSTextBox<ProjectEntityView> ManualPEndDate { get; set; } 
        public IRPSComboBox<ProjectEntityView> IDEmployeeTechnical { get; set; } 
        public IRPSCheckbox<ProjectEntityView> CreateResponsibleResource { get; set; } 
        public IRPSComboBox<ProjectEntityView> IDEmployeeCommercial { get; set; } 
        public IRPSComboBox<ProjectEntityView> TimeUnitDefault { get; set; } 
        public IRPSTextBox<ProjectEntityView> WarningThreshold { get; set; } 
        public IRPSTextBox<ProjectEntityView> BlockingThreshold { get; set; } 
        public IRPSCheckbox<ProjectEntityView> SendResponsibleMessage { get; set; } 
        public IRPSCheckbox<ProjectEntityView> AutomaticCodification { get; set; } 
        public IRPSTextBox<ProjectEntityView> QuantityReference { get; set; } 
        public IRPSTextBox<ProjectEntityView> PercentProfit { get; set; } 
        public IRPSTextBox<ProjectEntityView> Priority { get; set; } 
        public IRPSTextBox<ProjectEntityView> Group { get; set; } 
        public IRPSTextBox<ProjectEntityView> CalcAmountSale { get; set; } 
        public IRPSTextBox<ProjectEntityView> CalcOfferedEmployee { get; set; } 
        public IRPSTextBox<ProjectEntityView> CalcOfferedMaterial { get; set; } 
        public IRPSTextBox<ProjectEntityView> CalcOfferedMachine { get; set; } 
        public IRPSTextBox<ProjectEntityView> CalcOfferedOtherCost { get; set; } 
        public IRPSTextBox<ProjectEntityView> CalcOfferedTool { get; set; } 
        public IRPSTextBox<ProjectEntityView> CalcOfferedExternal { get; set; } 
        public IRPSTextBox<ProjectEntityView> CalcOffered { get; set; } 
        public IRPSTextBox<ProjectEntityView> CalcOfferedHours { get; set; } 
        public IRPSTextBox<ProjectEntityView> CalcAmountCostInitialEmployee { get; set; } 
        public IRPSTextBox<ProjectEntityView> CalcAmountCostInitialMaterial { get; set; } 
        public IRPSTextBox<ProjectEntityView> CalcAmountCostInitialMachine { get; set; } 
        public IRPSTextBox<ProjectEntityView> CalcAmountCostInitialOtherCost { get; set; } 
        public IRPSTextBox<ProjectEntityView> CalcAmountCostInitialTool { get; set; } 
        public IRPSTextBox<ProjectEntityView> CalcAmountCostInitialExternal { get; set; } 
        public IRPSTextBox<ProjectEntityView> CalcAmountBudgetInCategory { get; set; } 
        public IRPSTextBox<ProjectEntityView> CalcAmountCostInitial { get; set; } 
        public IRPSTextBox<ProjectEntityView> CalcHourInitial { get; set; } 
        public IRPSTextBox<ProjectEntityView> CalcAmountCostTheoricEmployee { get; set; } 
        public IRPSTextBox<ProjectEntityView> CalcAmountCostTheoricMaterial { get; set; } 
        public IRPSTextBox<ProjectEntityView> CalcAmountCostTheoricMachine { get; set; } 
        public IRPSTextBox<ProjectEntityView> CalcAmountCostTheoricOtherCost { get; set; } 
        public IRPSTextBox<ProjectEntityView> CalcAmountCostTheoricTool { get; set; } 
        public IRPSTextBox<ProjectEntityView> CalcAmountCostTheoricExternal { get; set; } 
        public IRPSTextBox<ProjectEntityView> CalcAmountCost { get; set; } 
        public IRPSTextBox<ProjectEntityView> CalcHourEstimated { get; set; } 
        public IRPSTextBox<ProjectEntityView> CalcHourEstimatedNotPlanify { get; set; } 
        public IRPSTextBox<ProjectEntityView> CalcAmountCostRealEmployee { get; set; } 
        public IRPSTextBox<ProjectEntityView> CalcAmountCostRealMaterial { get; set; } 
        public IRPSTextBox<ProjectEntityView> CalcAmountCostRealMachine { get; set; } 
        public IRPSTextBox<ProjectEntityView> CalcAmountCostRealOtherCost { get; set; } 
        public IRPSTextBox<ProjectEntityView> CalcAmountCostRealTool { get; set; } 
        public IRPSTextBox<ProjectEntityView> CalcAmountCostRealExternal { get; set; } 
        public IRPSTextBox<ProjectEntityView> CalcAmountCostReal { get; set; } 
        public IRPSTextBox<ProjectEntityView> CalcHourReal { get; set; } 
        public IRPSTextBox<ProjectEntityView> CalcHourRealNotPlanify { get; set; } 
        public IRPSTextBox<ProjectEntityView> Notes { get; set; } 
        public IRPSButton<ProjectEntityView> SetProjectIndicatorInStudyCommand { get; set; } 
        public IRPSButton<ProjectEntityView> FinalizeIndicatorStudyCommand { get; set; } 
        public IRPSButton<ProjectEntityView,ReportOptionsDialogView> ReportOptionsNavigationCommandButton { get; set; } 
        public IRPSButton<ProjectEntityView,AddUsualTaskDialogView> AddUsualTaskNavigationCommandButton { get; set; } 
        public IRPSButton<ProjectEntityView> PlanifyProjectCommandButton { get; set; } 
        public IRPSButton<ProjectEntityView,ProjectChangeSitutationChildDialogView> ProjectChangeSitutationChildNavigationCommandButton { get; set; } 
        public IRPSButton<ProjectEntityView,GenerateSupplysDialogView> GenerateSupplysNavigationCommandButton { get; set; } 
        public IRPSButton<ProjectEntityView> ExecuteProjectMaterialAutomaticAllocationButton { get; set; } 
        public IRPSButton<ProjectEntityView> ExecuteRecalculateProjectInitialDataButton { get; set; } 
        public IRPSButton<ProjectEntityView,NewProjectVersionDialogDialogView> NewProjectVersionDialogNavigationCommandButton { get; set; } 
        public IRPSButton<ProjectEntityView,ImportTaskDialogView> ImportTaskNavigationCommandButton { get; set; } 
        public IRPSButton<ProjectEntityView,AssignEmployeesDialogView> AssignEmployeesNavigationCommandButton { get; set; } 
        public IRPSButton<ProjectEntityView> CreateNewBaseLineCommandButton { get; set; } 
        public IRPSButton<ProjectEntityView> ExportToMSProjectNavigationCommandButton { get; set; } 
        public IRPSButton<ProjectEntityView> CreateWarningCommandButton { get; set; } 
        public IRPSButton<ProjectEntityView> PlanningProjectCommandButton { get; set; } 
        public IRPSButton<ProjectEntityView> ProMRPNavigationCommandButton { get; set; } 
        public ProjectTasksCollectionEditor<ProjectEntityView,ProjectTaskView> ProjectTasks { get; set; } 
        public ProjectFeaturesCollectionEditor<ProjectEntityView,ProjectTaskView> ProjectFeatures { get; set; } 
        public ProjectUsersCollectionEditor<ProjectEntityView,ProjectTaskView> ProjectUsers { get; set; } 
        public ProjectAlertsCollectionEditor<ProjectEntityView,ProjectTaskView> ProjectAlerts { get; set; } 
        public ProjectDimensionsCollectionEditor<ProjectEntityView,ProjectTaskView> ProjectDimensions { get; set; } 
        public IRPSSection<ProjectEntityView> SectionGantt { get; set; } 
        public IRPSSection<ProjectEntityView> SectionTasks { get; set; } 
        public IRPSSection<ProjectEntityView> SectionGeneral { get; set; } 
        public IRPSSection<ProjectEntityView> SectionCostAnalysis { get; set; } 
        public IRPSSection<ProjectEntityView> SectionNotes { get; set; } 
        public IRPSSection<ProjectEntityView> SectionFeatures { get; set; } 
        public IRPSSection<ProjectEntityView> SectionUsers { get; set; } 
        public IRPSSection<ProjectEntityView> SectionAlerts { get; set; } 
        public IRPSSection<ProjectEntityView> SectionDimensions { get; set; } 
        public IRPSSection<ProjectEntityView> IndicatorValues { get; set; } 
        public Project Screen { get; set; }
        public ProjectEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ProjectTasksCollectionEditor<ProjectEntityView,ProjectTaskView>:RPSCollectionEditor<ProjectEntityView,ProjectTaskView> where ProjectEntityView : class, IView where ProjectTaskView : class, IView
    {
        public  ProjectTasksGridView<ProjectEntityView,ProjectTaskView> GridView {get;set;}
    }
    public partial class ProjectTasksGridView <ProjectEntityView,ProjectTaskView> :  RPSGridView<ProjectEntityView,ProjectTaskView> where ProjectEntityView : class, IView where ProjectTaskView : class, IView
    {
        public ProjectTasksGridView(ProjectEntityView currentView,ProjectTaskView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            TaskType = RPSControlFactory.CreateRPSGridEnumComboBox<ProjectEntityView>("","#02bf6a91-dc4d-42b9-9a4e-9a7cf1930e88 .ag-row[role='row']@ROWINDEX [col-id='cTaskType']","",true, this.CurrentView);
 
            CodPROTask = RPSControlFactory.CreateRPSGridTextBox<ProjectEntityView>("","#02bf6a91-dc4d-42b9-9a4e-9a7cf1930e88 .ag-row[role='row']@ROWINDEX [col-id='cCodPROTask']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ProjectEntityView>("","#02bf6a91-dc4d-42b9-9a4e-9a7cf1930e88 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            IDProTaskParent = RPSControlFactory.CreateRPSGridComboBox<ProjectEntityView>("","#02bf6a91-dc4d-42b9-9a4e-9a7cf1930e88 .ag-row[role='row']@ROWINDEX [col-id='cIDProTaskParent']","",false, this.CurrentView);
 
            ExecutionTime = RPSControlFactory.CreateRPSGridDurationTextBox<ProjectEntityView>("","#02bf6a91-dc4d-42b9-9a4e-9a7cf1930e88 .ag-row[role='row']@ROWINDEX [col-id='cExecutionTime']","",true, this.CurrentView);
 
            PlannedStartDate = RPSControlFactory.CreateRPSGridTextBox<ProjectEntityView>("","#02bf6a91-dc4d-42b9-9a4e-9a7cf1930e88 .ag-row[role='row']@ROWINDEX [col-id='cPlannedStartDate']","",true, this.CurrentView);
 
            PlannedEndDate = RPSControlFactory.CreateRPSGridTextBox<ProjectEntityView>("","#02bf6a91-dc4d-42b9-9a4e-9a7cf1930e88 .ag-row[role='row']@ROWINDEX [col-id='cPlannedEndDate']","",true, this.CurrentView);
 
            PorcentProg = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectEntityView>("","#02bf6a91-dc4d-42b9-9a4e-9a7cf1930e88 .ag-row[role='row']@ROWINDEX [col-id='cPorcentProg']","",false, this.CurrentView);
 
            CalcPercentProgress = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectEntityView>("","#02bf6a91-dc4d-42b9-9a4e-9a7cf1930e88 .ag-row[role='row']@ROWINDEX [col-id='cCalcPercentProgress']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ProjectEntityView> TaskType { get; set; } 
        public IRPSGridTextBox<ProjectEntityView> CodPROTask { get; set; } 
        public IRPSGridTextBox<ProjectEntityView> Description { get; set; } 
        public IRPSGridComboBox<ProjectEntityView> IDProTaskParent { get; set; } 
        public IRPSGridDurationTextBox<ProjectEntityView> ExecutionTime { get; set; } 
        public IRPSGridTextBox<ProjectEntityView> PlannedStartDate { get; set; } 
        public IRPSGridTextBox<ProjectEntityView> PlannedEndDate { get; set; } 
        public IRPSGridTextBox<ProjectEntityView> PorcentProg { get; set; } 
        public IRPSGridTextBox<ProjectEntityView> CalcPercentProgress { get; set; } 
                     
    }
 
        public partial class ProjectFeaturesCollectionEditor<ProjectEntityView,ProjectTaskView>:RPSCollectionEditor<ProjectEntityView,ProjectTaskView> where ProjectEntityView : class, IView where ProjectTaskView : class, IView
    {
        public  ProjectFeaturesGridView<ProjectEntityView,ProjectTaskView> GridView {get;set;}
    }
    public partial class ProjectFeaturesGridView <ProjectEntityView,ProjectTaskView> :  RPSGridView<ProjectEntityView,ProjectTaskView> where ProjectEntityView : class, IView where ProjectTaskView : class, IView
    {
        public ProjectFeaturesGridView(ProjectEntityView currentView,ProjectTaskView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDPROFeatureLabel = RPSControlFactory.CreateRPSGridComboBox<ProjectEntityView>("","#7e43de01-4011-4d49-8cd3-c69dc31d0fd6 .ag-row[role='row']@ROWINDEX [col-id='cIDPROFeatureLabel']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<ProjectEntityView> IDPROFeatureLabel { get; set; } 
                     
    }
 
        public partial class ProjectUsersCollectionEditor<ProjectEntityView,ProjectTaskView>:RPSCollectionEditor<ProjectEntityView,ProjectTaskView> where ProjectEntityView : class, IView where ProjectTaskView : class, IView
    {
        public  ProjectUsersGridView<ProjectEntityView,ProjectTaskView> GridView {get;set;}
    }
    public partial class ProjectUsersGridView <ProjectEntityView,ProjectTaskView> :  RPSGridView<ProjectEntityView,ProjectTaskView> where ProjectEntityView : class, IView where ProjectTaskView : class, IView
    {
        public ProjectUsersGridView(ProjectEntityView currentView,ProjectTaskView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodUser = RPSControlFactory.CreateRPSGridComboBox<ProjectEntityView>("","#7451b315-f0f3-491f-bf49-7763d266391c .ag-row[role='row']@ROWINDEX [col-id='cCodUser']","",false, this.CurrentView);
 
            Admin = RPSControlFactory.CreateRPSGridCheckBox<ProjectEntityView>("","#7451b315-f0f3-491f-bf49-7763d266391c .ag-row[role='row']@ROWINDEX [col-id='cAdmin']","",true, this.CurrentView);
 
            ProjectPermission = RPSControlFactory.CreateRPSGridEnumComboBox<ProjectEntityView>("","#7451b315-f0f3-491f-bf49-7763d266391c .ag-row[role='row']@ROWINDEX [col-id='cProjectPermission']","",true, this.CurrentView);
 
            ImputationPermission = RPSControlFactory.CreateRPSGridEnumComboBox<ProjectEntityView>("","#7451b315-f0f3-491f-bf49-7763d266391c .ag-row[role='row']@ROWINDEX [col-id='cImputationPermission']","",true, this.CurrentView);
 
            WarningPermission = RPSControlFactory.CreateRPSGridEnumComboBox<ProjectEntityView>("","#7451b315-f0f3-491f-bf49-7763d266391c .ag-row[role='row']@ROWINDEX [col-id='cWarningPermission']","",true, this.CurrentView);
 
            TestPermission = RPSControlFactory.CreateRPSGridEnumComboBox<ProjectEntityView>("","#7451b315-f0f3-491f-bf49-7763d266391c .ag-row[role='row']@ROWINDEX [col-id='cTestPermission']","",true, this.CurrentView);
 
            CertificationPermission = RPSControlFactory.CreateRPSGridEnumComboBox<ProjectEntityView>("","#7451b315-f0f3-491f-bf49-7763d266391c .ag-row[role='row']@ROWINDEX [col-id='cCertificationPermission']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<ProjectEntityView> CodUser { get; set; } 
        public IRPSGridCheckbox<ProjectEntityView> Admin { get; set; } 
        public IRPSGridComboBox<ProjectEntityView> ProjectPermission { get; set; } 
        public IRPSGridComboBox<ProjectEntityView> ImputationPermission { get; set; } 
        public IRPSGridComboBox<ProjectEntityView> WarningPermission { get; set; } 
        public IRPSGridComboBox<ProjectEntityView> TestPermission { get; set; } 
        public IRPSGridComboBox<ProjectEntityView> CertificationPermission { get; set; } 
                     
    }
 
        public partial class ProjectAlertsCollectionEditor<ProjectEntityView,ProjectTaskView>:RPSCollectionEditor<ProjectEntityView,ProjectTaskView> where ProjectEntityView : class, IView where ProjectTaskView : class, IView
    {
        public  ProjectAlertsGridView<ProjectEntityView,ProjectTaskView> GridView {get;set;}
    }
    public partial class ProjectAlertsGridView <ProjectEntityView,ProjectTaskView> :  RPSGridView<ProjectEntityView,ProjectTaskView> where ProjectEntityView : class, IView where ProjectTaskView : class, IView
    {
        public ProjectAlertsGridView(ProjectEntityView currentView,ProjectTaskView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Description = RPSControlFactory.CreateRPSGridTextBox<ProjectEntityView>("","#496090d7-0535-4bbb-9e6c-a5b93c0cc6e9 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            TypeAlert = RPSControlFactory.CreateRPSGridEnumComboBox<ProjectEntityView>("","#496090d7-0535-4bbb-9e6c-a5b93c0cc6e9 .ag-row[role='row']@ROWINDEX [col-id='cTypeAlert']","",true, this.CurrentView);
 
            FactorX = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectEntityView>("","#496090d7-0535-4bbb-9e6c-a5b93c0cc6e9 .ag-row[role='row']@ROWINDEX [col-id='cFactorX']","",true, this.CurrentView);
 
            TypeProjectTask = RPSControlFactory.CreateRPSGridEnumComboBox<ProjectEntityView>("","#496090d7-0535-4bbb-9e6c-a5b93c0cc6e9 .ag-row[role='row']@ROWINDEX [col-id='cTypeProjectTask']","",true, this.CurrentView);
 
            IDPROTask = RPSControlFactory.CreateRPSGridComboBox<ProjectEntityView>("","#496090d7-0535-4bbb-9e6c-a5b93c0cc6e9 .ag-row[role='row']@ROWINDEX [col-id='cIDPROTask']","",false, this.CurrentView);
 
            Blocked = RPSControlFactory.CreateRPSGridCheckBox<ProjectEntityView>("","#496090d7-0535-4bbb-9e6c-a5b93c0cc6e9 .ag-row[role='row']@ROWINDEX [col-id='cBlocked']","",true, this.CurrentView);
 
            NotifyTask = RPSControlFactory.CreateRPSGridCheckBox<ProjectEntityView>("","#496090d7-0535-4bbb-9e6c-a5b93c0cc6e9 .ag-row[role='row']@ROWINDEX [col-id='cNotifyTask']","",true, this.CurrentView);
 
            NotifyResTechical = RPSControlFactory.CreateRPSGridCheckBox<ProjectEntityView>("","#496090d7-0535-4bbb-9e6c-a5b93c0cc6e9 .ag-row[role='row']@ROWINDEX [col-id='cNotifyResTechical']","",true, this.CurrentView);
 
            NotifyResCommercial = RPSControlFactory.CreateRPSGridCheckBox<ProjectEntityView>("","#496090d7-0535-4bbb-9e6c-a5b93c0cc6e9 .ag-row[role='row']@ROWINDEX [col-id='cNotifyResCommercial']","",true, this.CurrentView);
 
            BlockedTask = RPSControlFactory.CreateRPSGridCheckBox<ProjectEntityView>("","#496090d7-0535-4bbb-9e6c-a5b93c0cc6e9 .ag-row[role='row']@ROWINDEX [col-id='cBlockedTask']","",true, this.CurrentView);
 
            IDPROSituation = RPSControlFactory.CreateRPSGridTextBox<ProjectEntityView>("","#496090d7-0535-4bbb-9e6c-a5b93c0cc6e9 .ag-row[role='row']@ROWINDEX [col-id='cIDPROSituation']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ProjectEntityView> Description { get; set; } 
        public IRPSGridComboBox<ProjectEntityView> TypeAlert { get; set; } 
        public IRPSGridTextBox<ProjectEntityView> FactorX { get; set; } 
        public IRPSGridComboBox<ProjectEntityView> TypeProjectTask { get; set; } 
        public IRPSGridComboBox<ProjectEntityView> IDPROTask { get; set; } 
        public IRPSGridCheckbox<ProjectEntityView> Blocked { get; set; } 
        public IRPSGridCheckbox<ProjectEntityView> NotifyTask { get; set; } 
        public IRPSGridCheckbox<ProjectEntityView> NotifyResTechical { get; set; } 
        public IRPSGridCheckbox<ProjectEntityView> NotifyResCommercial { get; set; } 
        public IRPSGridCheckbox<ProjectEntityView> BlockedTask { get; set; } 
        public IRPSGridTextBox<ProjectEntityView> IDPROSituation { get; set; } 
                     
    }
 
        public partial class ProjectDimensionsCollectionEditor<ProjectEntityView,ProjectTaskView>:RPSCollectionEditor<ProjectEntityView,ProjectTaskView> where ProjectEntityView : class, IView where ProjectTaskView : class, IView
    {
        public  ProjectDimensionsGridView<ProjectEntityView,ProjectTaskView> GridView {get;set;}
    }
    public partial class ProjectDimensionsGridView <ProjectEntityView,ProjectTaskView> :  RPSGridView<ProjectEntityView,ProjectTaskView> where ProjectEntityView : class, IView where ProjectTaskView : class, IView
    {
        public ProjectDimensionsGridView(ProjectEntityView currentView,ProjectTaskView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDDimension = RPSControlFactory.CreateRPSGridComboBox<ProjectEntityView>("","#1fd323ce-42ee-432f-823d-45d8d37b6cea .ag-row[role='row']@ROWINDEX [col-id='cIDDimension']","",true, this.CurrentView);
 
            IDDimValue = RPSControlFactory.CreateRPSGridComboBox<ProjectEntityView>("","#1fd323ce-42ee-432f-823d-45d8d37b6cea .ag-row[role='row']@ROWINDEX [col-id='cIDDimValue']","",true, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectEntityView>("","#1fd323ce-42ee-432f-823d-45d8d37b6cea .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<ProjectEntityView> IDDimension { get; set; } 
        public IRPSGridComboBox<ProjectEntityView> IDDimValue { get; set; } 
        public IRPSGridTextBox<ProjectEntityView> Percentage { get; set; } 
                     
    }
 
    }
  
            
    public partial class ProjectFeatureView : View
    {
        public ProjectFeatureView(Project screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ProjectFeatureView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ProjectFeatureView,ProjectEntityView>( this,Screen.ProjectEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ProjectFeatureView,ProjectEntityView>( this,Screen.ProjectEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ProjectFeatureView,ProjectEntityView>( this,Screen.ProjectEntityView);
 
            IDPROFeatureLabel = RPSControlFactory.CreateRPSComboBox<ProjectFeatureView>("2ddda3c1-a092-4858-ab04-e2d35bc9f2d1","","",true, this);
 

        }
        public IRPSButton<ProjectFeatureView> DeleteButton { get; set; } 
        public IRPSButton<ProjectFeatureView,ProjectEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ProjectFeatureView,ProjectEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ProjectFeatureView,ProjectEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ProjectFeatureView> IDPROFeatureLabel { get; set; } 
        public Project Screen { get; set; }
        public ProjectFeatureView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ProjectAlertView : View
    {
        public ProjectAlertView(Project screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ProjectAlertView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ProjectAlertView,ProjectEntityView>( this,Screen.ProjectEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ProjectAlertView,ProjectEntityView>( this,Screen.ProjectEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ProjectAlertView,ProjectEntityView>( this,Screen.ProjectEntityView);
 
            Description = RPSControlFactory.CreateRPSTextBox<ProjectAlertView>("7a370328-6a2c-4c84-8ba7-7618ca40d376","","",false, this);
 
            TypeAlert = RPSControlFactory.CreateRPSEnumComboBox<ProjectAlertView>("47424b3b-04d6-408e-9eb4-0fae324e6538","","",true, this);
 
            FactorX = RPSControlFactory.CreateRPSFormattedTextBox<ProjectAlertView>("624c3879-1c7b-4d91-8db3-4b83e96427a7","","",true, this);
 
            TypeProjectTask = RPSControlFactory.CreateRPSEnumComboBox<ProjectAlertView>("d905e687-2f10-42e3-930b-398107f62453","","",true, this);
 
            IDPROTask = RPSControlFactory.CreateRPSComboBox<ProjectAlertView>("67d1581b-0804-45e5-871c-0abd487a026a","","",false, this);
 
            Blocked = RPSControlFactory.CreateRPSCheckBox<ProjectAlertView>("83e01460-05f1-45e4-8f12-8820472ee0dc","","",true, this);
 
            NotifyTask = RPSControlFactory.CreateRPSCheckBox<ProjectAlertView>("f245449a-a841-465e-9d82-b3761195919b","","",true, this);
 
            NotifyResTechical = RPSControlFactory.CreateRPSCheckBox<ProjectAlertView>("464028d9-e437-4db9-87da-034a84037bdb","","",true, this);
 
            NotifyResCommercial = RPSControlFactory.CreateRPSCheckBox<ProjectAlertView>("4c631e6f-735e-45c1-b4f0-8f7d46763a20","","",true, this);
 
            NotifyResources = RPSControlFactory.CreateRPSCheckBox<ProjectAlertView>("d0508164-6146-4998-97dc-425e28a20564","","",true, this);
 
            BlockedTask = RPSControlFactory.CreateRPSCheckBox<ProjectAlertView>("76e6994d-6a56-4776-9dbd-62e5707f0be6","","",true, this);
 
            IDPROSituation = RPSControlFactory.CreateRPSTextBox<ProjectAlertView>("2bf55a7a-6dec-4ea2-abf6-500d4e028b23","","",false, this);
 

        }
        public IRPSButton<ProjectAlertView> DeleteButton { get; set; } 
        public IRPSButton<ProjectAlertView,ProjectEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ProjectAlertView,ProjectEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ProjectAlertView,ProjectEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<ProjectAlertView> Description { get; set; } 
        public IRPSComboBox<ProjectAlertView> TypeAlert { get; set; } 
        public IRPSTextBox<ProjectAlertView> FactorX { get; set; } 
        public IRPSComboBox<ProjectAlertView> TypeProjectTask { get; set; } 
        public IRPSComboBox<ProjectAlertView> IDPROTask { get; set; } 
        public IRPSCheckbox<ProjectAlertView> Blocked { get; set; } 
        public IRPSCheckbox<ProjectAlertView> NotifyTask { get; set; } 
        public IRPSCheckbox<ProjectAlertView> NotifyResTechical { get; set; } 
        public IRPSCheckbox<ProjectAlertView> NotifyResCommercial { get; set; } 
        public IRPSCheckbox<ProjectAlertView> NotifyResources { get; set; } 
        public IRPSCheckbox<ProjectAlertView> BlockedTask { get; set; } 
        public IRPSTextBox<ProjectAlertView> IDPROSituation { get; set; } 
        public Project Screen { get; set; }
        public ProjectAlertView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ProjectDimensionView : View
    {
        public ProjectDimensionView(Project screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ProjectDimensionView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ProjectDimensionView,ProjectEntityView>( this,Screen.ProjectEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ProjectDimensionView,ProjectEntityView>( this,Screen.ProjectEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ProjectDimensionView,ProjectEntityView>( this,Screen.ProjectEntityView);
 
            IDDimension = RPSControlFactory.CreateRPSComboBox<ProjectDimensionView>("29eef876-91a8-40ca-ad87-3481294e6c03","","",true, this);
 
            IDDimValue = RPSControlFactory.CreateRPSComboBox<ProjectDimensionView>("feedb501-5080-4726-bb12-62e9e101829b","","",true, this);
 
            Percentage = RPSControlFactory.CreateRPSFormattedTextBox<ProjectDimensionView>("b98bbcb9-fe2d-42f2-b285-11286ab71660","","",true, this);
 

        }
        public IRPSButton<ProjectDimensionView> DeleteButton { get; set; } 
        public IRPSButton<ProjectDimensionView,ProjectEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ProjectDimensionView,ProjectEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ProjectDimensionView,ProjectEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ProjectDimensionView> IDDimension { get; set; } 
        public IRPSComboBox<ProjectDimensionView> IDDimValue { get; set; } 
        public IRPSTextBox<ProjectDimensionView> Percentage { get; set; } 
        public Project Screen { get; set; }
        public ProjectDimensionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ProjectTaskView : View
    {
        public ProjectTaskView(Project screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ProjectTaskView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ProjectTaskView,ProjectEntityView>( this,Screen.ProjectEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ProjectTaskView,ProjectEntityView>( this,Screen.ProjectEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ProjectTaskView,ProjectEntityView>( this,Screen.ProjectEntityView);
 
            CodPROTask = RPSControlFactory.CreateRPSTextBox<ProjectTaskView>("96c7c462-a699-408a-bdc8-54563ba86efb","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ProjectTaskView>("aa0a87b9-f5b5-4ae5-a5b2-dcba03f77015","","",false, this);
 
            IDProTaskType = RPSControlFactory.CreateRPSComboBox<ProjectTaskView>("15c106fe-9331-4c3c-a36d-a166f58b6b2b","","",false, this);
 
            TaskType = RPSControlFactory.CreateRPSEnumComboBox<ProjectTaskView>("529c5daa-ccc4-4f99-8599-36483bd9003e","","",true, this);
 
            PlannedStartDate = RPSControlFactory.CreateRPSTextBox<ProjectTaskView>("5fb8db33-51f1-4441-8377-3fc8b85b2006","","",true, this);
 
            PlannedStartHour = RPSControlFactory.CreateRPSTextBox<ProjectTaskView>("cbe17047-422d-4c5d-bf82-95ff5ee3e4b5","","",false, this);
 
            ManualStartDate = RPSControlFactory.CreateRPSTextBox<ProjectTaskView>("a354832a-94b4-486b-bbad-0f5d211f0dc9","","",false, this);
 
            PlannedEndDate = RPSControlFactory.CreateRPSTextBox<ProjectTaskView>("b7880f96-c018-41fa-bdf6-7c55c676f531","","",true, this);
 
            PlannedEndHour = RPSControlFactory.CreateRPSTextBox<ProjectTaskView>("7b036c03-b643-43f6-845b-18771bc8183b","","",false, this);
 
            ManualEndDate = RPSControlFactory.CreateRPSTextBox<ProjectTaskView>("33b72dd7-f931-49b3-b73e-e186ca5e101c","","",false, this);
 
            RealEndDate = RPSControlFactory.CreateRPSTextBox<ProjectTaskView>("59f75790-dc24-4e61-b898-09f668acb525","","",false, this);
 
            PreparationTime = RPSControlFactory.CreateRPSDurationTextBox<ProjectTaskView>("7646065e-c961-4a69-8459-e14bb79a0edc","","",true, this);
 
            ExecutionTime = RPSControlFactory.CreateRPSDurationTextBox<ProjectTaskView>("0a544ebc-07d0-4bc0-bda4-23a2faaff997","","",true, this);
 
            UI_Finished = RPSControlFactory.CreateRPSCheckBox<ProjectTaskView>("b9edd2b8-9ca6-4970-b6f0-41b6808c5cb4","","",false, this);
 
            UIHasLeadTime = RPSControlFactory.CreateRPSCheckBox<ProjectTaskView>("cd3aba5c-6346-4d99-a197-c4cbad8193b2","","",false, this);
 
            LeadTime = RPSControlFactory.CreateRPSDurationTextBox<ProjectTaskView>("5c8e2402-aa55-47a7-89fe-b8c5050b5745","","",true, this);
 
            PercentProgress = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("742eb903-40c1-4d29-b71b-c5661c4b2447","","",true, this);
 
            CalcPercentProgress = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("fe6a074e-58cd-496d-9c90-66c056b400c8","","",false, this);
 
            CalcHourReal = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("bbb95e48-0b71-4718-a895-12b5fe675d23","","",false, this);
 
            CalcHourPendingManual = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("1a963375-230e-47fb-afd4-a8a35ee9a440","","",false, this);
 
            IDSituationMilestone = RPSControlFactory.CreateRPSComboBox<ProjectTaskView>("1a3f26cb-53bb-412c-8e73-9ef860300801","","",false, this);
 
            QuantityReference = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("e439b20e-33ae-49dc-8f8c-ca57e4dbd80c","","",true, this);
 
            BlockedQuantityReference = RPSControlFactory.CreateRPSCheckBox<ProjectTaskView>("b9dbd3c8-09b8-47e5-9981-1458f7578f3f","","",true, this);
 
            WarningThreshold = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("246bbc0b-e130-4654-b17b-bfea1916ad36","","",true, this);
 
            BlockingThreshold = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("8f76a21d-331a-4c89-9129-ce0864578a59","","",true, this);
 
            SendResponsibleMessage = RPSControlFactory.CreateRPSCheckBox<ProjectTaskView>("20190cb4-fd91-4957-8748-1f44beb2d579","","",true, this);
 
            IDProUsualTask = RPSControlFactory.CreateRPSComboBox<ProjectTaskView>("0b8ff3f6-c921-425b-910d-3c68cb65805e","","",false, this);
 
            IDProTaskParent = RPSControlFactory.CreateRPSComboBox<ProjectTaskView>("0e58454c-2662-4902-81c7-33e69b60e483","","",false, this);
 
            IDProjectChild = RPSControlFactory.CreateRPSComboBox<ProjectTaskView>("5e21ca74-7d06-456a-a0e2-80f48a73b887","","",false, this);
 
            ProjectTaskLinkedNavigationCommand = RPSControlFactory.CreateRPSButtonToView<ProjectTaskView,ProjectTaskLinkedDialogView>("cfff2a45-1810-47c3-b874-8fc1433cf5bf","","", this,Screen.ProjectTaskLinkedDialogView);
 
            IDEmployeeTechnical = RPSControlFactory.CreateRPSComboBox<ProjectTaskView>("25fab751-d4e6-48a1-992a-78861a85ed25","","",false, this);
 
            IDArticleInvoice = RPSControlFactory.CreateRPSComboBox<ProjectTaskView>("ed0ff52d-69fb-4c88-b08c-c48f44a68aa4","","",false, this);
 
            CalcAmountSale = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("1b9fcf3b-11f9-4114-b4ca-418b8fe30830","","",false, this);
 
            MaterialExit = RPSControlFactory.CreateRPSCheckBox<ProjectTaskView>("58309e3b-3aec-45f5-a8da-6e0b3e934a3c","","",true, this);
 
            Blocked = RPSControlFactory.CreateRPSCheckBox<ProjectTaskView>("73816b36-22af-4fe2-ab08-7de0977761af","","",true, this);
 
            BlockedTime = RPSControlFactory.CreateRPSCheckBox<ProjectTaskView>("e92096ac-f683-4367-85d7-dac5b9ccaf47","","",true, this);
 
            BlockedMaterial = RPSControlFactory.CreateRPSCheckBox<ProjectTaskView>("d780dbe6-2249-4ce5-a07b-fd932786c6cc","","",true, this);
 
            BlockedCost = RPSControlFactory.CreateRPSCheckBox<ProjectTaskView>("0a5a4ede-d56e-4004-95c0-b2cc49d152a1","","",true, this);
 
            Canceled = RPSControlFactory.CreateRPSCheckBox<ProjectTaskView>("fb64cf92-5e33-4900-b63c-2988c876efe1","","",true, this);
 
            QualityStatus = RPSControlFactory.CreateRPSEnumComboBox<ProjectTaskView>("c62ab205-8c49-48b6-a851-99f32fcba8be","","",true, this);
 
            UIService = RPSControlFactory.CreateRPSEnumComboBox<ProjectTaskView>("6a527215-ecef-43b5-a273-62b9279f3a34","","",false, this);
 
            UIEntity = RPSControlFactory.CreateRPSEnumComboBox<ProjectTaskView>("77901705-475b-4702-b27f-a74e2424e668","","",false, this);
 
            CalcCostEmployeeManual = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("d03bd7de-0757-48f9-a2a0-442a72dc3458","","",false, this);
 
            CalcCostMaterialManual = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("c758f741-2fab-4ad7-976b-5da6c911e488","","",false, this);
 
            CalcCostMachineManual = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("b0f07e21-93cc-424e-9094-3c9e45d6c354","","",false, this);
 
            CalcCostOtherCostManual = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("e84b0db1-270a-47dd-afde-e347903c56a2","","",false, this);
 
            CalcCostToolManual = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("7ce4b2e8-503f-4fe0-af31-017eaeb5a211","","",false, this);
 
            CalcCostExternalManual = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("832b44f8-1499-4933-88d9-92423a952f23","","",false, this);
 
            CalcBudgetInCategory = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("02c8c86a-6761-4d82-9141-c35bfd11eb2f","","",false, this);
 
            CalcTotalBudget = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("a888bdd4-b03c-4a7a-bb6d-ed4ef7a9056f","","",false, this);
 
            CalcDurationManual = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("e7524a51-1759-4ff6-ac58-08df88ea3384","","",false, this);
 
            CalcAmountCostTheoricEmployee = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("17d4c976-43b1-4060-81ed-50649f68467b","","",false, this);
 
            CalcAmountCostTheoricMaterial = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("506f72ce-aa8c-4034-b085-cb22afed8f08","","",false, this);
 
            CalcAmountCostTheoricMachine = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("e5aac962-652a-439a-aa56-9c155b9c4cb0","","",false, this);
 
            CalcAmountCostTheoricOtherCost = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("8d44405c-5384-4475-a650-cfcf7af58159","","",false, this);
 
            CalcAmountCostTheoricTool = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("896f6165-f9ac-4f10-8be0-d97f597bc1e5","","",false, this);
 
            CalcAmountCostTheoricExternal = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("ec5a9074-06c1-490d-ba25-186bd867987b","","",false, this);
 
            CalcAmountCost = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("72125fd1-3aea-48a9-868c-d50193a32531","","",false, this);
 
            CalcHourEstimated = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("b2307549-880a-4d4b-888f-9fd274c54c4a","","",false, this);
 
            CalcHourEstimatedNotPlanify = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("e135156f-614b-4c87-a99c-5eefb93492b5","","",false, this);
 
            CalcAmountCostRealEmployee = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("76313d71-7410-4992-acc6-fdc7c4ae2f30","","",false, this);
 
            CalcAmountCostRealMaterial = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("06876a03-f22e-4a79-b281-b566c5d4087c","","",false, this);
 
            CalcAmountCostRealMachine = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("80e8d9c5-c4e5-4e8c-a620-08460eef92f2","","",false, this);
 
            CalcAmountCostRealOtherCost = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("b1ca77f6-fd26-4147-82eb-ae5fc1b8687a","","",false, this);
 
            CalcAmountCostRealTool = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("97595104-cdfa-480e-89e9-bc4cec76a701","","",false, this);
 
            CalcAmountCostRealExternal = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("1497fe4f-3c34-40f9-8982-626c54b93d95","","",false, this);
 
            CalcAmountCostReal = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("b57ed8da-f091-4ca3-afc9-3d8a2aa0924d","","",false, this);
 
            CalcHourReal1 = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("3c31b181-1799-4ffc-abf1-14dfb16a9003","","",false, this);
 
            CalcHourRealNotPlanify = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("e0414d46-b82c-41a1-b9aa-9fb9af6db5ec","","",false, this);
 
            DelimitationType = RPSControlFactory.CreateRPSEnumComboBox<ProjectTaskView>("7a42075d-0ade-47dd-a7a7-32fbba69e5a3","","",true, this);
 
            DelimitationDate = RPSControlFactory.CreateRPSTextBox<ProjectTaskView>("eb3f0445-eb8a-4a84-8dc4-f5f97e9b4dbb","","",false, this);
 
            DelimitationHour = RPSControlFactory.CreateRPSTextBox<ProjectTaskView>("a0529a1c-a752-4160-997a-51d966a1ae0e","","",false, this);
 
            DelimitationObligatoryUsual = RPSControlFactory.CreateRPSCheckBox<ProjectTaskView>("f3f2fe4d-720e-4c55-9651-b7ea037049de","","",true, this);
 
            DelimitationObligatoryMilestone = RPSControlFactory.CreateRPSCheckBox<ProjectTaskView>("ae43185b-a8a2-40c0-924b-80200a0a7fe0","","",true, this);
 
            AllowFraccionate = RPSControlFactory.CreateRPSCheckBox<ProjectTaskView>("00b66b9f-334c-47f6-afbd-acd3261790d1","","",true, this);
 
            MinimumFraction = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("0a0ed635-a7a4-41bd-9362-a75c57127217","","",true, this);
 
            TimeUnit = RPSControlFactory.CreateRPSEnumComboBox<ProjectTaskView>("ba08d094-8ff3-474b-b60f-eb6e6109ee2e","","",true, this);
 
            NotPlanify = RPSControlFactory.CreateRPSCheckBox<ProjectTaskView>("8cb7b547-852c-46e1-b58e-cbfedf503610","","",true, this);
 
            Fixed = RPSControlFactory.CreateRPSCheckBox<ProjectTaskView>("c972df52-2425-4368-90d2-ac543dbd3fc3","","",true, this);
 
            WithoutTimetable = RPSControlFactory.CreateRPSCheckBox<ProjectTaskView>("e054b327-2844-4a83-a1cd-a94ce7db3f28","","",true, this);
 
            OptimizationFeature = RPSControlFactory.CreateRPSTextBox<ProjectTaskView>("7977257d-b856-440b-aa29-bd68c4d8b81e","","",false, this);
 
            Priority = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("498df6a0-009e-4fdb-a879-42381b1b0ea8","","",true, this);
 
            Group = RPSControlFactory.CreateRPSTextBox<ProjectTaskView>("41f29f81-9b47-498b-b569-91ad4e967e8d","","",false, this);
 
            ResourcePlanType = RPSControlFactory.CreateRPSEnumComboBox<ProjectTaskView>("57fd1c4c-0183-40ee-aaad-db8fcdc90d11","","",true, this);
 
            SplitNumber = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("dbaa7445-3bfe-42ac-bbff-c40cd10609a9","","",true, this);
 
            OccupancyType = RPSControlFactory.CreateRPSEnumComboBox<ProjectTaskView>("603ae093-7a65-470c-a2f9-c56da4620fa1","","",true, this);
 
            OccupancyHours = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("70c73615-ce19-4938-a4d9-b8512483d3fd","","",true, this);
 
            OccupancyPercent = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("b7fb3406-f739-4182-a00a-6f05867917e5","","",true, this);
 
            External = RPSControlFactory.CreateRPSCheckBox<ProjectTaskView>("f88facb2-b028-4844-b424-d4f8781349cb","","",true, this);
 
            IDArticleExternal = RPSControlFactory.CreateRPSComboBox<ProjectTaskView>("06b66ddd-ea4c-4428-a33d-d48d524c7727","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<ProjectTaskView>("173bfc45-e012-498b-a0c5-06c9065a701a","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("80a85927-70d5-4cc1-82a5-679f9af05770","","",true, this);
 
            IDSiteMaterial = RPSControlFactory.CreateRPSComboBox<ProjectTaskView>("5c1a2458-283f-4eb9-b53e-55f409499e28","","",false, this);
 
            IDWarehouseMaterial = RPSControlFactory.CreateRPSComboBox<ProjectTaskView>("1d26f96f-3e9b-4c19-854d-a5e432e747d1","","",false, this);
 
            ImputationCostUpdated = RPSControlFactory.CreateRPSCheckBox<ProjectTaskView>("89857277-10f0-4242-919f-ffefbc5f08a2","","",true, this);
 
            TypeProfit = RPSControlFactory.CreateRPSEnumComboBox<ProjectTaskView>("fc295128-7863-4a24-ac20-8579f22bf56e","","",true, this);
 
            PriceCostTheoric = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("3db4757a-aff7-4a93-8007-1cbd8d071837","","",false, this);
 
            PercentProfit = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("d963ffc7-b6a4-43d5-8112-086403e9f29b","","",true, this);
 
            PriceSaleTheoric = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("a2b81c90-bac6-4d37-8762-9fc1dc6da278","","",false, this);
 
            BlockedBudget = RPSControlFactory.CreateRPSCheckBox<ProjectTaskView>("6e5e7de1-9655-4517-ba06-9d3d376765d2","","",true, this);
 
            BudgetQuantity = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("2937990e-dc76-4324-94d2-7d6b849d31bc","","",true, this);
 
            BudgetPrice = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("088e3028-583e-4bba-97df-5adf45cc1efc","","",true, this);
 
            BudgetAmount = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskView>("56db1a64-5614-4ddc-a38b-dd3cf48a04e6","","",true, this);
 
            IDBudgetCategory = RPSControlFactory.CreateRPSComboBox<ProjectTaskView>("9c1d99d2-3c1d-4b69-bcc9-f65c46ea6471","","",false, this);
 
            IDBudgetEmployee = RPSControlFactory.CreateRPSComboBox<ProjectTaskView>("d4b7057a-5cbc-40d4-9749-6ae6ad94f95a","","",false, this);
 
            IDBudgetMachine = RPSControlFactory.CreateRPSComboBox<ProjectTaskView>("80668166-cc4d-4c05-8d2b-76348b4f4d4f","","",false, this);
 
            IDBudgetTool = RPSControlFactory.CreateRPSComboBox<ProjectTaskView>("bf816e0c-f08f-4254-8bf3-2f7ceb8498c3","","",false, this);
 
            IDBudgetMaterial = RPSControlFactory.CreateRPSComboBox<ProjectTaskView>("35656c16-9490-4b5f-8beb-9dee6ca0554e","","",false, this);
 
            IDBudgetOtherCost = RPSControlFactory.CreateRPSComboBox<ProjectTaskView>("0946aa17-9e89-4a25-b85f-bb99d436a857","","",false, this);
 
            Notes = RPSControlFactory.CreateRPSTextBox<ProjectTaskView>("6b0677b6-d57e-481c-989b-daef63787f36","","",false, this);
 
            AddMaterialButton = RPSControlFactory.CreateRPSButton<ProjectTaskView>( "15590ae3-7763-4581-9d20-3e1e7c9b0146","","",this);
 
            SplitTaskCommandButton = RPSControlFactory.CreateRPSButton<ProjectTaskView>( "6a818e9a-03c9-4838-95b9-e440e35739df","","",this);
 
            RelocateTaskAppointmentsCommandButton = RPSControlFactory.CreateRPSButton<ProjectTaskView>( "a84318b9-0fd8-486a-9d1a-68b616bc4ff1","","",this);
 
            GenerateSupplysForTaskNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ProjectTaskView,GenerateSupplysForTaskDialogView>("257555f7-d534-4a17-a61f-8d53fcdc4fbb","","", this,Screen.GenerateSupplysForTaskDialogView);
 
            ExecuteProjectTaskStockReserveAutomaticButton = RPSControlFactory.CreateRPSButton<ProjectTaskView>( "65bee625-2556-4fa2-befd-cf1622848ed9","","",this);
 
            CreateProjectFromTaskNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ProjectTaskView,CreateProjectFromTaskDialogView>("3d5254c1-1d56-447e-a4fa-9f6e93e09347","","", this,Screen.CreateProjectFromTaskDialogView);
 
            CuDistSplitOfTaskPopUpNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ProjectTaskView,CuDistSplitOfTaskPopUpDialogView>("b519271b-852c-4058-8290-d56036e64d58","","", this,Screen.CuDistSplitOfTaskPopUpDialogView);
 
            CreateWarningCommandButton = RPSControlFactory.CreateRPSButton<ProjectTaskView>( "9f37f4f6-6bb9-4615-af0f-7c3bba70bc94","","",this);
 
            CollectionInit params_ProjectTaskDimensions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7e12d0fa-edf7-4ad0-ab52-0c2c89286541",CSSSelectorGrid="",XPathGrid=""};
            ProjectTaskDimensions = RPSControlFactory.RPSCreateCollectionWithGrid<ProjectTaskDimensionsCollectionEditor<ProjectTaskView,ProjectMaterialView>,ProjectTaskView,ProjectMaterialView>( params_ProjectTaskDimensions,this,Screen.ProjectMaterialView);
 
            CollectionInit params_ProjectTaskRelations = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c95e1a98-f17c-49a8-845a-5c0573d6ed4f",CSSSelectorGrid="",XPathGrid=""};
            ProjectTaskRelations = RPSControlFactory.RPSCreateCollectionWithGrid<ProjectTaskRelationsCollectionEditor<ProjectTaskView,ProjectMaterialView>,ProjectTaskView,ProjectMaterialView>( params_ProjectTaskRelations,this,Screen.ProjectMaterialView);
 
            CollectionInit params_PROProjectMaterials = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4e18ccb3-7271-4755-ba54-de58b9a48d48",CSSSelectorGrid="",XPathGrid=""};
            PROProjectMaterials = RPSControlFactory.RPSCreateCollectionWithGrid<PROProjectMaterialsCollectionEditor<ProjectTaskView,ProjectMaterialView>,ProjectTaskView,ProjectMaterialView>( params_PROProjectMaterials,this,Screen.ProjectMaterialView);
 
            CollectionInit params_ProjectTaskCostComponents = new CollectionInit(){IDDescriptor = "552eeb15-67f8-4a9e-9ec3-8b6322198526",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6a209d33-abb4-415b-b01b-a539fd998284",CSSSelectorGrid="",XPathGrid=""};
            ProjectTaskCostComponents = RPSControlFactory.RPSCreateCollectionWithGrid<ProjectTaskCostComponentsCollectionEditor<ProjectTaskView,ProjectMaterialView>,ProjectTaskView,ProjectMaterialView>( params_ProjectTaskCostComponents,this,Screen.ProjectMaterialView);
 
            CollectionInit params_ProjectResourceEmployees = new CollectionInit(){IDDescriptor = "1daaf6ac-522c-4f11-860a-19c5f399ce6f",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4b4d30db-9921-4c89-8159-d8e423611231",CSSSelectorGrid="",XPathGrid=""};
            ProjectResourceEmployees = RPSControlFactory.RPSCreateCollectionWithGrid<ProjectResourceEmployeesCollectionEditor<ProjectTaskView,ProjectMaterialView>,ProjectTaskView,ProjectMaterialView>( params_ProjectResourceEmployees,this,Screen.ProjectMaterialView);
 
            CollectionInit params_ProjectResourceMachines = new CollectionInit(){IDDescriptor = "6fed5bf6-be89-409a-a462-561f93824aa1",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3aaf8126-5d9f-4781-be28-52f61b6176c1",CSSSelectorGrid="",XPathGrid=""};
            ProjectResourceMachines = RPSControlFactory.RPSCreateCollectionWithGrid<ProjectResourceMachinesCollectionEditor<ProjectTaskView,ProjectMaterialView>,ProjectTaskView,ProjectMaterialView>( params_ProjectResourceMachines,this,Screen.ProjectMaterialView);
 
            CollectionInit params_ProjectResourceTools = new CollectionInit(){IDDescriptor = "916f689f-c366-45f8-95e9-9eff0238cad5",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="fafbf297-b044-4c4b-9e90-215d45e2f017",CSSSelectorGrid="",XPathGrid=""};
            ProjectResourceTools = RPSControlFactory.RPSCreateCollectionWithGrid<ProjectResourceToolsCollectionEditor<ProjectTaskView,ProjectMaterialView>,ProjectTaskView,ProjectMaterialView>( params_ProjectResourceTools,this,Screen.ProjectMaterialView);
 
            CollectionInit params_ProjectTaskCategorys = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="bd01f0e2-254d-4c26-8923-e91cab11eb93",CSSSelectorGrid="",XPathGrid=""};
            ProjectTaskCategorys = RPSControlFactory.RPSCreateCollectionWithGrid<ProjectTaskCategorysCollectionEditor<ProjectTaskView,ProjectMaterialView>,ProjectTaskView,ProjectMaterialView>( params_ProjectTaskCategorys,this,Screen.ProjectMaterialView);
 
            SectionGeneral = RPSControlFactory.CreateRPSSection<ProjectTaskView>( "","ul li[rpsid='7848389d-ab92-4eae-9f0d-22d252f14972']","",this);
 
            SectionCostAnalysis = RPSControlFactory.CreateRPSSection<ProjectTaskView>( "","ul li[rpsid='fad4566d-64ee-4c54-808f-c14ebfe752fd']","",this);
 
            SectionPlanning = RPSControlFactory.CreateRPSSection<ProjectTaskView>( "","ul li[rpsid='a5e0c85f-63f1-48f6-a579-dfc3c100f2c6']","",this);
 
            SectionCost = RPSControlFactory.CreateRPSSection<ProjectTaskView>( "","ul li[rpsid='41c0518f-306c-4501-abb7-9e2b5d34ce62']","",this);
 
            SectionNotes = RPSControlFactory.CreateRPSSection<ProjectTaskView>( "","ul li[rpsid='de216bd9-ccb6-444f-a829-a9213a27990d']","",this);
 
            SectionDimensions = RPSControlFactory.CreateRPSSection<ProjectTaskView>( "","ul li[rpsid='02319e7e-3981-485c-a58c-77e5cef52768']","",this);
 
            SectionTaskRelations = RPSControlFactory.CreateRPSSection<ProjectTaskView>( "","ul li[rpsid='f7547cd2-6f60-44f3-9e27-2e2c07b27a33']","",this);
 
            SectionMaterials = RPSControlFactory.CreateRPSSection<ProjectTaskView>( "","ul li[rpsid='d31e6b5f-542d-4efe-9c27-72f0e1bcb79b']","",this);
 
            SectionTaskCostComponent = RPSControlFactory.CreateRPSSection<ProjectTaskView>( "","ul li[rpsid='052462cd-3b4a-4519-9c19-8cdaa85fedae']","",this);
 
            SectionTaskResourceEmployee = RPSControlFactory.CreateRPSSection<ProjectTaskView>( "","ul li[rpsid='5998cf2c-d465-4a2d-a47a-000484843bf2']","",this);
 
            SectionTaskResourceMachine = RPSControlFactory.CreateRPSSection<ProjectTaskView>( "","ul li[rpsid='e7ab9aea-8c42-46b2-9316-44fd1281a2d1']","",this);
 
            SectionTaskResourceTool = RPSControlFactory.CreateRPSSection<ProjectTaskView>( "","ul li[rpsid='18249f09-4456-456c-84c4-11f82c6c6342']","",this);
 
            SectionTaskCategory = RPSControlFactory.CreateRPSSection<ProjectTaskView>( "","ul li[rpsid='4f05a3f3-a429-4f2e-b4c1-d587a59dccb8']","",this);
 

        }
        public IRPSButton<ProjectTaskView> DeleteButton { get; set; } 
        public IRPSButton<ProjectTaskView,ProjectEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ProjectTaskView,ProjectEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ProjectTaskView,ProjectEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<ProjectTaskView> CodPROTask { get; set; } 
        public IRPSTextBox<ProjectTaskView> Description { get; set; } 
        public IRPSComboBox<ProjectTaskView> IDProTaskType { get; set; } 
        public IRPSComboBox<ProjectTaskView> TaskType { get; set; } 
        public IRPSTextBox<ProjectTaskView> PlannedStartDate { get; set; } 
        public IRPSTextBox<ProjectTaskView> PlannedStartHour { get; set; } 
        public IRPSTextBox<ProjectTaskView> ManualStartDate { get; set; } 
        public IRPSTextBox<ProjectTaskView> PlannedEndDate { get; set; } 
        public IRPSTextBox<ProjectTaskView> PlannedEndHour { get; set; } 
        public IRPSTextBox<ProjectTaskView> ManualEndDate { get; set; } 
        public IRPSTextBox<ProjectTaskView> RealEndDate { get; set; } 
        public IRPSDurationTextBox<ProjectTaskView> PreparationTime { get; set; } 
        public IRPSDurationTextBox<ProjectTaskView> ExecutionTime { get; set; } 
        public IRPSCheckbox<ProjectTaskView> UI_Finished { get; set; } 
        public IRPSCheckbox<ProjectTaskView> UIHasLeadTime { get; set; } 
        public IRPSDurationTextBox<ProjectTaskView> LeadTime { get; set; } 
        public IRPSTextBox<ProjectTaskView> PercentProgress { get; set; } 
        public IRPSTextBox<ProjectTaskView> CalcPercentProgress { get; set; } 
        public IRPSTextBox<ProjectTaskView> CalcHourReal { get; set; } 
        public IRPSTextBox<ProjectTaskView> CalcHourPendingManual { get; set; } 
        public IRPSComboBox<ProjectTaskView> IDSituationMilestone { get; set; } 
        public IRPSTextBox<ProjectTaskView> QuantityReference { get; set; } 
        public IRPSCheckbox<ProjectTaskView> BlockedQuantityReference { get; set; } 
        public IRPSTextBox<ProjectTaskView> WarningThreshold { get; set; } 
        public IRPSTextBox<ProjectTaskView> BlockingThreshold { get; set; } 
        public IRPSCheckbox<ProjectTaskView> SendResponsibleMessage { get; set; } 
        public IRPSComboBox<ProjectTaskView> IDProUsualTask { get; set; } 
        public IRPSComboBox<ProjectTaskView> IDProTaskParent { get; set; } 
        public IRPSComboBox<ProjectTaskView> IDProjectChild { get; set; } 
        public IRPSButton<ProjectTaskView,ProjectTaskLinkedDialogView> ProjectTaskLinkedNavigationCommand { get; set; } 
        public IRPSComboBox<ProjectTaskView> IDEmployeeTechnical { get; set; } 
        public IRPSComboBox<ProjectTaskView> IDArticleInvoice { get; set; } 
        public IRPSTextBox<ProjectTaskView> CalcAmountSale { get; set; } 
        public IRPSCheckbox<ProjectTaskView> MaterialExit { get; set; } 
        public IRPSCheckbox<ProjectTaskView> Blocked { get; set; } 
        public IRPSCheckbox<ProjectTaskView> BlockedTime { get; set; } 
        public IRPSCheckbox<ProjectTaskView> BlockedMaterial { get; set; } 
        public IRPSCheckbox<ProjectTaskView> BlockedCost { get; set; } 
        public IRPSCheckbox<ProjectTaskView> Canceled { get; set; } 
        public IRPSComboBox<ProjectTaskView> QualityStatus { get; set; } 
        public IRPSComboBox<ProjectTaskView> UIService { get; set; } 
        public IRPSComboBox<ProjectTaskView> UIEntity { get; set; } 
        public IRPSTextBox<ProjectTaskView> CalcCostEmployeeManual { get; set; } 
        public IRPSTextBox<ProjectTaskView> CalcCostMaterialManual { get; set; } 
        public IRPSTextBox<ProjectTaskView> CalcCostMachineManual { get; set; } 
        public IRPSTextBox<ProjectTaskView> CalcCostOtherCostManual { get; set; } 
        public IRPSTextBox<ProjectTaskView> CalcCostToolManual { get; set; } 
        public IRPSTextBox<ProjectTaskView> CalcCostExternalManual { get; set; } 
        public IRPSTextBox<ProjectTaskView> CalcBudgetInCategory { get; set; } 
        public IRPSTextBox<ProjectTaskView> CalcTotalBudget { get; set; } 
        public IRPSTextBox<ProjectTaskView> CalcDurationManual { get; set; } 
        public IRPSTextBox<ProjectTaskView> CalcAmountCostTheoricEmployee { get; set; } 
        public IRPSTextBox<ProjectTaskView> CalcAmountCostTheoricMaterial { get; set; } 
        public IRPSTextBox<ProjectTaskView> CalcAmountCostTheoricMachine { get; set; } 
        public IRPSTextBox<ProjectTaskView> CalcAmountCostTheoricOtherCost { get; set; } 
        public IRPSTextBox<ProjectTaskView> CalcAmountCostTheoricTool { get; set; } 
        public IRPSTextBox<ProjectTaskView> CalcAmountCostTheoricExternal { get; set; } 
        public IRPSTextBox<ProjectTaskView> CalcAmountCost { get; set; } 
        public IRPSTextBox<ProjectTaskView> CalcHourEstimated { get; set; } 
        public IRPSTextBox<ProjectTaskView> CalcHourEstimatedNotPlanify { get; set; } 
        public IRPSTextBox<ProjectTaskView> CalcAmountCostRealEmployee { get; set; } 
        public IRPSTextBox<ProjectTaskView> CalcAmountCostRealMaterial { get; set; } 
        public IRPSTextBox<ProjectTaskView> CalcAmountCostRealMachine { get; set; } 
        public IRPSTextBox<ProjectTaskView> CalcAmountCostRealOtherCost { get; set; } 
        public IRPSTextBox<ProjectTaskView> CalcAmountCostRealTool { get; set; } 
        public IRPSTextBox<ProjectTaskView> CalcAmountCostRealExternal { get; set; } 
        public IRPSTextBox<ProjectTaskView> CalcAmountCostReal { get; set; } 
        public IRPSTextBox<ProjectTaskView> CalcHourReal1 { get; set; } 
        public IRPSTextBox<ProjectTaskView> CalcHourRealNotPlanify { get; set; } 
        public IRPSComboBox<ProjectTaskView> DelimitationType { get; set; } 
        public IRPSTextBox<ProjectTaskView> DelimitationDate { get; set; } 
        public IRPSTextBox<ProjectTaskView> DelimitationHour { get; set; } 
        public IRPSCheckbox<ProjectTaskView> DelimitationObligatoryUsual { get; set; } 
        public IRPSCheckbox<ProjectTaskView> DelimitationObligatoryMilestone { get; set; } 
        public IRPSCheckbox<ProjectTaskView> AllowFraccionate { get; set; } 
        public IRPSTextBox<ProjectTaskView> MinimumFraction { get; set; } 
        public IRPSComboBox<ProjectTaskView> TimeUnit { get; set; } 
        public IRPSCheckbox<ProjectTaskView> NotPlanify { get; set; } 
        public IRPSCheckbox<ProjectTaskView> Fixed { get; set; } 
        public IRPSCheckbox<ProjectTaskView> WithoutTimetable { get; set; } 
        public IRPSTextBox<ProjectTaskView> OptimizationFeature { get; set; } 
        public IRPSTextBox<ProjectTaskView> Priority { get; set; } 
        public IRPSTextBox<ProjectTaskView> Group { get; set; } 
        public IRPSComboBox<ProjectTaskView> ResourcePlanType { get; set; } 
        public IRPSTextBox<ProjectTaskView> SplitNumber { get; set; } 
        public IRPSComboBox<ProjectTaskView> OccupancyType { get; set; } 
        public IRPSTextBox<ProjectTaskView> OccupancyHours { get; set; } 
        public IRPSTextBox<ProjectTaskView> OccupancyPercent { get; set; } 
        public IRPSCheckbox<ProjectTaskView> External { get; set; } 
        public IRPSComboBox<ProjectTaskView> IDArticleExternal { get; set; } 
        public IRPSComboBox<ProjectTaskView> IDSupplier { get; set; } 
        public IRPSTextBox<ProjectTaskView> Quantity { get; set; } 
        public IRPSComboBox<ProjectTaskView> IDSiteMaterial { get; set; } 
        public IRPSComboBox<ProjectTaskView> IDWarehouseMaterial { get; set; } 
        public IRPSCheckbox<ProjectTaskView> ImputationCostUpdated { get; set; } 
        public IRPSComboBox<ProjectTaskView> TypeProfit { get; set; } 
        public IRPSTextBox<ProjectTaskView> PriceCostTheoric { get; set; } 
        public IRPSTextBox<ProjectTaskView> PercentProfit { get; set; } 
        public IRPSTextBox<ProjectTaskView> PriceSaleTheoric { get; set; } 
        public IRPSCheckbox<ProjectTaskView> BlockedBudget { get; set; } 
        public IRPSTextBox<ProjectTaskView> BudgetQuantity { get; set; } 
        public IRPSTextBox<ProjectTaskView> BudgetPrice { get; set; } 
        public IRPSTextBox<ProjectTaskView> BudgetAmount { get; set; } 
        public IRPSComboBox<ProjectTaskView> IDBudgetCategory { get; set; } 
        public IRPSComboBox<ProjectTaskView> IDBudgetEmployee { get; set; } 
        public IRPSComboBox<ProjectTaskView> IDBudgetMachine { get; set; } 
        public IRPSComboBox<ProjectTaskView> IDBudgetTool { get; set; } 
        public IRPSComboBox<ProjectTaskView> IDBudgetMaterial { get; set; } 
        public IRPSComboBox<ProjectTaskView> IDBudgetOtherCost { get; set; } 
        public IRPSTextBox<ProjectTaskView> Notes { get; set; } 
        public IRPSButton<ProjectTaskView> AddMaterialButton { get; set; } 
        public IRPSButton<ProjectTaskView> SplitTaskCommandButton { get; set; } 
        public IRPSButton<ProjectTaskView> RelocateTaskAppointmentsCommandButton { get; set; } 
        public IRPSButton<ProjectTaskView,GenerateSupplysForTaskDialogView> GenerateSupplysForTaskNavigationCommandButton { get; set; } 
        public IRPSButton<ProjectTaskView> ExecuteProjectTaskStockReserveAutomaticButton { get; set; } 
        public IRPSButton<ProjectTaskView,CreateProjectFromTaskDialogView> CreateProjectFromTaskNavigationCommandButton { get; set; } 
        public IRPSButton<ProjectTaskView,CuDistSplitOfTaskPopUpDialogView> CuDistSplitOfTaskPopUpNavigationCommandButton { get; set; } 
        public IRPSButton<ProjectTaskView> CreateWarningCommandButton { get; set; } 
        public ProjectTaskDimensionsCollectionEditor<ProjectTaskView,ProjectMaterialView> ProjectTaskDimensions { get; set; } 
        public ProjectTaskRelationsCollectionEditor<ProjectTaskView,ProjectMaterialView> ProjectTaskRelations { get; set; } 
        public PROProjectMaterialsCollectionEditor<ProjectTaskView,ProjectMaterialView> PROProjectMaterials { get; set; } 
        public ProjectTaskCostComponentsCollectionEditor<ProjectTaskView,ProjectMaterialView> ProjectTaskCostComponents { get; set; } 
        public ProjectResourceEmployeesCollectionEditor<ProjectTaskView,ProjectMaterialView> ProjectResourceEmployees { get; set; } 
        public ProjectResourceMachinesCollectionEditor<ProjectTaskView,ProjectMaterialView> ProjectResourceMachines { get; set; } 
        public ProjectResourceToolsCollectionEditor<ProjectTaskView,ProjectMaterialView> ProjectResourceTools { get; set; } 
        public ProjectTaskCategorysCollectionEditor<ProjectTaskView,ProjectMaterialView> ProjectTaskCategorys { get; set; } 
        public IRPSSection<ProjectTaskView> SectionGeneral { get; set; } 
        public IRPSSection<ProjectTaskView> SectionCostAnalysis { get; set; } 
        public IRPSSection<ProjectTaskView> SectionPlanning { get; set; } 
        public IRPSSection<ProjectTaskView> SectionCost { get; set; } 
        public IRPSSection<ProjectTaskView> SectionNotes { get; set; } 
        public IRPSSection<ProjectTaskView> SectionDimensions { get; set; } 
        public IRPSSection<ProjectTaskView> SectionTaskRelations { get; set; } 
        public IRPSSection<ProjectTaskView> SectionMaterials { get; set; } 
        public IRPSSection<ProjectTaskView> SectionTaskCostComponent { get; set; } 
        public IRPSSection<ProjectTaskView> SectionTaskResourceEmployee { get; set; } 
        public IRPSSection<ProjectTaskView> SectionTaskResourceMachine { get; set; } 
        public IRPSSection<ProjectTaskView> SectionTaskResourceTool { get; set; } 
        public IRPSSection<ProjectTaskView> SectionTaskCategory { get; set; } 
        public Project Screen { get; set; }
        public ProjectTaskView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ProjectTaskDimensionsCollectionEditor<ProjectTaskView,ProjectMaterialView>:RPSCollectionEditor<ProjectTaskView,ProjectMaterialView> where ProjectTaskView : class, IView where ProjectMaterialView : class, IView
    {
        public  ProjectTaskDimensionsGridView<ProjectTaskView,ProjectMaterialView> GridView {get;set;}
    }
    public partial class ProjectTaskDimensionsGridView <ProjectTaskView,ProjectMaterialView> :  RPSGridView<ProjectTaskView,ProjectMaterialView> where ProjectTaskView : class, IView where ProjectMaterialView : class, IView
    {
        public ProjectTaskDimensionsGridView(ProjectTaskView currentView,ProjectMaterialView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDDimension = RPSControlFactory.CreateRPSGridComboBox<ProjectTaskView>("","#7e12d0fa-edf7-4ad0-ab52-0c2c89286541 .ag-row[role='row']@ROWINDEX [col-id='cIDDimension']","",true, this.CurrentView);
 
            IDDimValue = RPSControlFactory.CreateRPSGridComboBox<ProjectTaskView>("","#7e12d0fa-edf7-4ad0-ab52-0c2c89286541 .ag-row[role='row']@ROWINDEX [col-id='cIDDimValue']","",true, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectTaskView>("","#7e12d0fa-edf7-4ad0-ab52-0c2c89286541 .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<ProjectTaskView> IDDimension { get; set; } 
        public IRPSGridComboBox<ProjectTaskView> IDDimValue { get; set; } 
        public IRPSGridTextBox<ProjectTaskView> Percentage { get; set; } 
                     
    }
 
        public partial class ProjectTaskRelationsCollectionEditor<ProjectTaskView,ProjectMaterialView>:RPSCollectionEditor<ProjectTaskView,ProjectMaterialView> where ProjectTaskView : class, IView where ProjectMaterialView : class, IView
    {
        public  ProjectTaskRelationsGridView<ProjectTaskView,ProjectMaterialView> GridView {get;set;}
    }
    public partial class ProjectTaskRelationsGridView <ProjectTaskView,ProjectMaterialView> :  RPSGridView<ProjectTaskView,ProjectMaterialView> where ProjectTaskView : class, IView where ProjectMaterialView : class, IView
    {
        public ProjectTaskRelationsGridView(ProjectTaskView currentView,ProjectMaterialView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDProTaskPredecessor = RPSControlFactory.CreateRPSGridComboBox<ProjectTaskView>("","#c95e1a98-f17c-49a8-845a-5c0573d6ed4f .ag-row[role='row']@ROWINDEX [col-id='cIDProTaskPredecessor']","",false, this.CurrentView);
 
            RelationType = RPSControlFactory.CreateRPSGridEnumComboBox<ProjectTaskView>("","#c95e1a98-f17c-49a8-845a-5c0573d6ed4f .ag-row[role='row']@ROWINDEX [col-id='cRelationType']","",true, this.CurrentView);
 
            TimeLag = RPSControlFactory.CreateRPSGridDurationTextBox<ProjectTaskView>("","#c95e1a98-f17c-49a8-845a-5c0573d6ed4f .ag-row[role='row']@ROWINDEX [col-id='cTimeLag']","",false, this.CurrentView);
 
            Linked = RPSControlFactory.CreateRPSGridCheckBox<ProjectTaskView>("","#c95e1a98-f17c-49a8-845a-5c0573d6ed4f .ag-row[role='row']@ROWINDEX [col-id='cLinked']","",true, this.CurrentView);
 
            CalendarType = RPSControlFactory.CreateRPSGridEnumComboBox<ProjectTaskView>("","#c95e1a98-f17c-49a8-845a-5c0573d6ed4f .ag-row[role='row']@ROWINDEX [col-id='cCalendarType']","",true, this.CurrentView);
 
            TypeTask = RPSControlFactory.CreateRPSGridEnumComboBox<ProjectTaskView>("","#c95e1a98-f17c-49a8-845a-5c0573d6ed4f .ag-row[role='row']@ROWINDEX [col-id='cTypeTask']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<ProjectTaskView> IDProTaskPredecessor { get; set; } 
        public IRPSGridComboBox<ProjectTaskView> RelationType { get; set; } 
        public IRPSGridDurationTextBox<ProjectTaskView> TimeLag { get; set; } 
        public IRPSGridCheckbox<ProjectTaskView> Linked { get; set; } 
        public IRPSGridComboBox<ProjectTaskView> CalendarType { get; set; } 
        public IRPSGridComboBox<ProjectTaskView> TypeTask { get; set; } 
                     
    }
 
        public partial class PROProjectMaterialsCollectionEditor<ProjectTaskView,ProjectMaterialView>:RPSCollectionEditor<ProjectTaskView,ProjectMaterialView> where ProjectTaskView : class, IView where ProjectMaterialView : class, IView
    {
        public  PROProjectMaterialsGridView<ProjectTaskView,ProjectMaterialView> GridView {get;set;}
    }
    public partial class PROProjectMaterialsGridView <ProjectTaskView,ProjectMaterialView> :  RPSGridView<ProjectTaskView,ProjectMaterialView> where ProjectTaskView : class, IView where ProjectMaterialView : class, IView
    {
        public PROProjectMaterialsGridView(ProjectTaskView currentView,ProjectMaterialView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodMaterial = RPSControlFactory.CreateRPSGridTextBox<ProjectTaskView>("","#4e18ccb3-7271-4755-ba54-de58b9a48d48 .ag-row[role='row']@ROWINDEX [col-id='cCodMaterial']","",true, this.CurrentView);
 
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<ProjectTaskView>("","#4e18ccb3-7271-4755-ba54-de58b9a48d48 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ProjectTaskView>("","#4e18ccb3-7271-4755-ba54-de58b9a48d48 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            IDArticleParent = RPSControlFactory.CreateRPSGridComboBox<ProjectTaskView>("","#4e18ccb3-7271-4755-ba54-de58b9a48d48 .ag-row[role='row']@ROWINDEX [col-id='cIDArticleParent']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectTaskView>("","#4e18ccb3-7271-4755-ba54-de58b9a48d48 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            CalcAmountCost = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectTaskView>("","#4e18ccb3-7271-4755-ba54-de58b9a48d48 .ag-row[role='row']@ROWINDEX [col-id='cCalcAmountCost']","",false, this.CurrentView);
 
            CalcAmountCostReal = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectTaskView>("","#4e18ccb3-7271-4755-ba54-de58b9a48d48 .ag-row[role='row']@ROWINDEX [col-id='cCalcAmountCostReal']","",false, this.CurrentView);
 
            SupplySituation = RPSControlFactory.CreateRPSGridEnumComboBox<ProjectTaskView>("","#4e18ccb3-7271-4755-ba54-de58b9a48d48 .ag-row[role='row']@ROWINDEX [col-id='cSupplySituation']","",false, this.CurrentView);
 
            Matchcode = RPSControlFactory.CreateRPSGridTextBox<ProjectTaskView>("","#4e18ccb3-7271-4755-ba54-de58b9a48d48 .ag-row[role='row']@ROWINDEX [col-id='cMatchcode']","",false, this.CurrentView);
 
            BlockedMRP = RPSControlFactory.CreateRPSGridCheckBox<ProjectTaskView>("","#4e18ccb3-7271-4755-ba54-de58b9a48d48 .ag-row[role='row']@ROWINDEX [col-id='cBlockedMRP']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<ProjectTaskView> CodMaterial { get; set; } 
        public IRPSGridComboBox<ProjectTaskView> IDArticle { get; set; } 
        public IRPSGridTextBox<ProjectTaskView> Description { get; set; } 
        public IRPSGridComboBox<ProjectTaskView> IDArticleParent { get; set; } 
        public IRPSGridTextBox<ProjectTaskView> Quantity { get; set; } 
        public IRPSGridTextBox<ProjectTaskView> CalcAmountCost { get; set; } 
        public IRPSGridTextBox<ProjectTaskView> CalcAmountCostReal { get; set; } 
        public IRPSGridComboBox<ProjectTaskView> SupplySituation { get; set; } 
        public IRPSGridTextBox<ProjectTaskView> Matchcode { get; set; } 
        public IRPSGridCheckbox<ProjectTaskView> BlockedMRP { get; set; } 
                     
    }
 
        public partial class ProjectTaskCostComponentsCollectionEditor<ProjectTaskView,ProjectMaterialView>:RPSCollectionEditor<ProjectTaskView,ProjectMaterialView> where ProjectTaskView : class, IView where ProjectMaterialView : class, IView
    {
        public  ProjectTaskCostComponentsGridView<ProjectTaskView,ProjectMaterialView> GridView {get;set;}
    }
    public partial class ProjectTaskCostComponentsGridView <ProjectTaskView,ProjectMaterialView> :  RPSGridView<ProjectTaskView,ProjectMaterialView> where ProjectTaskView : class, IView where ProjectMaterialView : class, IView
    {
        public ProjectTaskCostComponentsGridView(ProjectTaskView currentView,ProjectMaterialView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDCostComponent = RPSControlFactory.CreateRPSGridComboBox<ProjectTaskView>("","#6a209d33-abb4-415b-b01b-a539fd998284 .ag-row[role='row']@ROWINDEX [col-id='cIDCostComponent']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ProjectTaskView>("","#6a209d33-abb4-415b-b01b-a539fd998284 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectTaskView>("","#6a209d33-abb4-415b-b01b-a539fd998284 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            CalcAmountCost = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectTaskView>("","#6a209d33-abb4-415b-b01b-a539fd998284 .ag-row[role='row']@ROWINDEX [col-id='cCalcAmountCost']","",false, this.CurrentView);
 
            CalcAmountCostReal = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectTaskView>("","#6a209d33-abb4-415b-b01b-a539fd998284 .ag-row[role='row']@ROWINDEX [col-id='cCalcAmountCostReal']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ProjectTaskView> IDCostComponent { get; set; } 
        public IRPSGridTextBox<ProjectTaskView> Description { get; set; } 
        public IRPSGridTextBox<ProjectTaskView> Quantity { get; set; } 
        public IRPSGridTextBox<ProjectTaskView> CalcAmountCost { get; set; } 
        public IRPSGridTextBox<ProjectTaskView> CalcAmountCostReal { get; set; } 
                     
    }
 
        public partial class ProjectResourceEmployeesCollectionEditor<ProjectTaskView,ProjectMaterialView>:RPSCollectionEditor<ProjectTaskView,ProjectMaterialView> where ProjectTaskView : class, IView where ProjectMaterialView : class, IView
    {
        public  ProjectResourceEmployeesGridView<ProjectTaskView,ProjectMaterialView> GridView {get;set;}
    }
    public partial class ProjectResourceEmployeesGridView <ProjectTaskView,ProjectMaterialView> :  RPSGridView<ProjectTaskView,ProjectMaterialView> where ProjectTaskView : class, IView where ProjectMaterialView : class, IView
    {
        public ProjectResourceEmployeesGridView(ProjectTaskView currentView,ProjectMaterialView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDEmployee = RPSControlFactory.CreateRPSGridComboBox<ProjectTaskView>("","#4b4d30db-9921-4c89-8159-d8e423611231 .ag-row[role='row']@ROWINDEX [col-id='cIDEmployee']","",false, this.CurrentView);
 
            IDQualify = RPSControlFactory.CreateRPSGridComboBox<ProjectTaskView>("","#4b4d30db-9921-4c89-8159-d8e423611231 .ag-row[role='row']@ROWINDEX [col-id='cIDQualify']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ProjectTaskView>("","#4b4d30db-9921-4c89-8159-d8e423611231 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Planify = RPSControlFactory.CreateRPSGridCheckBox<ProjectTaskView>("","#4b4d30db-9921-4c89-8159-d8e423611231 .ag-row[role='row']@ROWINDEX [col-id='cPlanify']","",true, this.CurrentView);
 
            DedicationPercent = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectTaskView>("","#4b4d30db-9921-4c89-8159-d8e423611231 .ag-row[role='row']@ROWINDEX [col-id='cDedicationPercent']","",true, this.CurrentView);
 
            CalcAmountCost = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectTaskView>("","#4b4d30db-9921-4c89-8159-d8e423611231 .ag-row[role='row']@ROWINDEX [col-id='cCalcAmountCost']","",false, this.CurrentView);
 
            CalcAmountCostReal = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectTaskView>("","#4b4d30db-9921-4c89-8159-d8e423611231 .ag-row[role='row']@ROWINDEX [col-id='cCalcAmountCostReal']","",false, this.CurrentView);
 
            ExecutionTime = RPSControlFactory.CreateRPSGridDurationTextBox<ProjectTaskView>("","#4b4d30db-9921-4c89-8159-d8e423611231 .ag-row[role='row']@ROWINDEX [col-id='cExecutionTime']","",true, this.CurrentView);
 
            PercentProgress = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectTaskView>("","#4b4d30db-9921-4c89-8159-d8e423611231 .ag-row[role='row']@ROWINDEX [col-id='cPercentProgress']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<ProjectTaskView> IDEmployee { get; set; } 
        public IRPSGridComboBox<ProjectTaskView> IDQualify { get; set; } 
        public IRPSGridTextBox<ProjectTaskView> Description { get; set; } 
        public IRPSGridCheckbox<ProjectTaskView> Planify { get; set; } 
        public IRPSGridTextBox<ProjectTaskView> DedicationPercent { get; set; } 
        public IRPSGridTextBox<ProjectTaskView> CalcAmountCost { get; set; } 
        public IRPSGridTextBox<ProjectTaskView> CalcAmountCostReal { get; set; } 
        public IRPSGridDurationTextBox<ProjectTaskView> ExecutionTime { get; set; } 
        public IRPSGridTextBox<ProjectTaskView> PercentProgress { get; set; } 
                     
    }
 
        public partial class ProjectResourceMachinesCollectionEditor<ProjectTaskView,ProjectMaterialView>:RPSCollectionEditor<ProjectTaskView,ProjectMaterialView> where ProjectTaskView : class, IView where ProjectMaterialView : class, IView
    {
        public  ProjectResourceMachinesGridView<ProjectTaskView,ProjectMaterialView> GridView {get;set;}
    }
    public partial class ProjectResourceMachinesGridView <ProjectTaskView,ProjectMaterialView> :  RPSGridView<ProjectTaskView,ProjectMaterialView> where ProjectTaskView : class, IView where ProjectMaterialView : class, IView
    {
        public ProjectResourceMachinesGridView(ProjectTaskView currentView,ProjectMaterialView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDMachine = RPSControlFactory.CreateRPSGridComboBox<ProjectTaskView>("","#3aaf8126-5d9f-4781-be28-52f61b6176c1 .ag-row[role='row']@ROWINDEX [col-id='cIDMachine']","",false, this.CurrentView);
 
            IDMachineGroup = RPSControlFactory.CreateRPSGridComboBox<ProjectTaskView>("","#3aaf8126-5d9f-4781-be28-52f61b6176c1 .ag-row[role='row']@ROWINDEX [col-id='cIDMachineGroup']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ProjectTaskView>("","#3aaf8126-5d9f-4781-be28-52f61b6176c1 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            IDProResourceEmployee = RPSControlFactory.CreateRPSGridComboBox<ProjectTaskView>("","#3aaf8126-5d9f-4781-be28-52f61b6176c1 .ag-row[role='row']@ROWINDEX [col-id='cIDProResourceEmployee']","",false, this.CurrentView);
 
            Planify = RPSControlFactory.CreateRPSGridCheckBox<ProjectTaskView>("","#3aaf8126-5d9f-4781-be28-52f61b6176c1 .ag-row[role='row']@ROWINDEX [col-id='cPlanify']","",true, this.CurrentView);
 
            DedicationPercent = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectTaskView>("","#3aaf8126-5d9f-4781-be28-52f61b6176c1 .ag-row[role='row']@ROWINDEX [col-id='cDedicationPercent']","",true, this.CurrentView);
 
            CalcAmountCost = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectTaskView>("","#3aaf8126-5d9f-4781-be28-52f61b6176c1 .ag-row[role='row']@ROWINDEX [col-id='cCalcAmountCost']","",false, this.CurrentView);
 
            CalcAmountCostReal = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectTaskView>("","#3aaf8126-5d9f-4781-be28-52f61b6176c1 .ag-row[role='row']@ROWINDEX [col-id='cCalcAmountCostReal']","",false, this.CurrentView);
 
            ExecutionTime = RPSControlFactory.CreateRPSGridDurationTextBox<ProjectTaskView>("","#3aaf8126-5d9f-4781-be28-52f61b6176c1 .ag-row[role='row']@ROWINDEX [col-id='cExecutionTime']","",true, this.CurrentView);
 
            PercentProgress = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectTaskView>("","#3aaf8126-5d9f-4781-be28-52f61b6176c1 .ag-row[role='row']@ROWINDEX [col-id='cPercentProgress']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<ProjectTaskView> IDMachine { get; set; } 
        public IRPSGridComboBox<ProjectTaskView> IDMachineGroup { get; set; } 
        public IRPSGridTextBox<ProjectTaskView> Description { get; set; } 
        public IRPSGridComboBox<ProjectTaskView> IDProResourceEmployee { get; set; } 
        public IRPSGridCheckbox<ProjectTaskView> Planify { get; set; } 
        public IRPSGridTextBox<ProjectTaskView> DedicationPercent { get; set; } 
        public IRPSGridTextBox<ProjectTaskView> CalcAmountCost { get; set; } 
        public IRPSGridTextBox<ProjectTaskView> CalcAmountCostReal { get; set; } 
        public IRPSGridDurationTextBox<ProjectTaskView> ExecutionTime { get; set; } 
        public IRPSGridTextBox<ProjectTaskView> PercentProgress { get; set; } 
                     
    }
 
        public partial class ProjectResourceToolsCollectionEditor<ProjectTaskView,ProjectMaterialView>:RPSCollectionEditor<ProjectTaskView,ProjectMaterialView> where ProjectTaskView : class, IView where ProjectMaterialView : class, IView
    {
        public  ProjectResourceToolsGridView<ProjectTaskView,ProjectMaterialView> GridView {get;set;}
    }
    public partial class ProjectResourceToolsGridView <ProjectTaskView,ProjectMaterialView> :  RPSGridView<ProjectTaskView,ProjectMaterialView> where ProjectTaskView : class, IView where ProjectMaterialView : class, IView
    {
        public ProjectResourceToolsGridView(ProjectTaskView currentView,ProjectMaterialView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDTool = RPSControlFactory.CreateRPSGridComboBox<ProjectTaskView>("","#fafbf297-b044-4c4b-9e90-215d45e2f017 .ag-row[role='row']@ROWINDEX [col-id='cIDTool']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ProjectTaskView>("","#fafbf297-b044-4c4b-9e90-215d45e2f017 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            IDProResourceEmployee = RPSControlFactory.CreateRPSGridComboBox<ProjectTaskView>("","#fafbf297-b044-4c4b-9e90-215d45e2f017 .ag-row[role='row']@ROWINDEX [col-id='cIDProResourceEmployee']","",false, this.CurrentView);
 
            Planify = RPSControlFactory.CreateRPSGridCheckBox<ProjectTaskView>("","#fafbf297-b044-4c4b-9e90-215d45e2f017 .ag-row[role='row']@ROWINDEX [col-id='cPlanify']","",true, this.CurrentView);
 
            DedicationPercent = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectTaskView>("","#fafbf297-b044-4c4b-9e90-215d45e2f017 .ag-row[role='row']@ROWINDEX [col-id='cDedicationPercent']","",true, this.CurrentView);
 
            CalcAmountCost = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectTaskView>("","#fafbf297-b044-4c4b-9e90-215d45e2f017 .ag-row[role='row']@ROWINDEX [col-id='cCalcAmountCost']","",false, this.CurrentView);
 
            CalcAmountCostReal = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectTaskView>("","#fafbf297-b044-4c4b-9e90-215d45e2f017 .ag-row[role='row']@ROWINDEX [col-id='cCalcAmountCostReal']","",false, this.CurrentView);
 
            ExecutionTime = RPSControlFactory.CreateRPSGridDurationTextBox<ProjectTaskView>("","#fafbf297-b044-4c4b-9e90-215d45e2f017 .ag-row[role='row']@ROWINDEX [col-id='cExecutionTime']","",true, this.CurrentView);
 
            PercentProgress = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectTaskView>("","#fafbf297-b044-4c4b-9e90-215d45e2f017 .ag-row[role='row']@ROWINDEX [col-id='cPercentProgress']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<ProjectTaskView> IDTool { get; set; } 
        public IRPSGridTextBox<ProjectTaskView> Description { get; set; } 
        public IRPSGridComboBox<ProjectTaskView> IDProResourceEmployee { get; set; } 
        public IRPSGridCheckbox<ProjectTaskView> Planify { get; set; } 
        public IRPSGridTextBox<ProjectTaskView> DedicationPercent { get; set; } 
        public IRPSGridTextBox<ProjectTaskView> CalcAmountCost { get; set; } 
        public IRPSGridTextBox<ProjectTaskView> CalcAmountCostReal { get; set; } 
        public IRPSGridDurationTextBox<ProjectTaskView> ExecutionTime { get; set; } 
        public IRPSGridTextBox<ProjectTaskView> PercentProgress { get; set; } 
                     
    }
 
        public partial class ProjectTaskCategorysCollectionEditor<ProjectTaskView,ProjectMaterialView>:RPSCollectionEditor<ProjectTaskView,ProjectMaterialView> where ProjectTaskView : class, IView where ProjectMaterialView : class, IView
    {
        public  ProjectTaskCategorysGridView<ProjectTaskView,ProjectMaterialView> GridView {get;set;}
    }
    public partial class ProjectTaskCategorysGridView <ProjectTaskView,ProjectMaterialView> :  RPSGridView<ProjectTaskView,ProjectMaterialView> where ProjectTaskView : class, IView where ProjectMaterialView : class, IView
    {
        public ProjectTaskCategorysGridView(ProjectTaskView currentView,ProjectMaterialView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDBudgetCategory = RPSControlFactory.CreateRPSGridComboBox<ProjectTaskView>("","#bd01f0e2-254d-4c26-8923-e91cab11eb93 .ag-row[role='row']@ROWINDEX [col-id='cIDBudgetCategory']","",true, this.CurrentView);
 
            BudgetAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectTaskView>("","#bd01f0e2-254d-4c26-8923-e91cab11eb93 .ag-row[role='row']@ROWINDEX [col-id='cBudgetAmount']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<ProjectTaskView> IDBudgetCategory { get; set; } 
        public IRPSGridTextBox<ProjectTaskView> BudgetAmount { get; set; } 
                     
    }
 
    }
  
            
    public partial class ProjectTaskDimensionView : View
    {
        public ProjectTaskDimensionView(Project screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ProjectTaskDimensionView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ProjectTaskDimensionView,ProjectTaskView>( this,Screen.ProjectTaskView);
 
            BackButton = RPSControlFactory.RPSBackButton<ProjectTaskDimensionView,ProjectTaskView>( this,Screen.ProjectTaskView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ProjectTaskDimensionView,ProjectTaskView>( this,Screen.ProjectTaskView);
 
            IDDimension = RPSControlFactory.CreateRPSComboBox<ProjectTaskDimensionView>("f0dd16c7-3eb0-4ced-87c6-4187c5cf6332","","",true, this);
 
            IDDimValue = RPSControlFactory.CreateRPSComboBox<ProjectTaskDimensionView>("ca2e6a47-8683-4148-9f39-697de97cdd8d","","",true, this);
 
            Percentage = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskDimensionView>("cc1a819f-6e0c-4cd6-a066-e742d18e2892","","",true, this);
 

        }
        public IRPSButton<ProjectTaskDimensionView> DeleteButton { get; set; } 
        public IRPSButton<ProjectTaskDimensionView,ProjectTaskView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ProjectTaskDimensionView,ProjectTaskView> BackButton { get; set; } 
        public IRPSAcceptButton<ProjectTaskDimensionView,ProjectTaskView> AcceptButton { get; set; } 
        public IRPSComboBox<ProjectTaskDimensionView> IDDimension { get; set; } 
        public IRPSComboBox<ProjectTaskDimensionView> IDDimValue { get; set; } 
        public IRPSTextBox<ProjectTaskDimensionView> Percentage { get; set; } 
        public Project Screen { get; set; }
        public ProjectTaskDimensionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ProjectMaterialView : View
    {
        public ProjectMaterialView(Project screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ProjectMaterialView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ProjectMaterialView,ProjectTaskView>( this,Screen.ProjectTaskView);
 
            BackButton = RPSControlFactory.RPSBackButton<ProjectMaterialView,ProjectTaskView>( this,Screen.ProjectTaskView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ProjectMaterialView,ProjectTaskView>( this,Screen.ProjectTaskView);
 
            CodMaterial = RPSControlFactory.CreateRPSTextBox<ProjectMaterialView>("6a817755-1a97-4445-a7ea-b87675e45656","","",true, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<ProjectMaterialView>("4bdbcdab-13d0-4baa-b992-a11784afa37b","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ProjectMaterialView>("4a31b75a-fb3e-4143-8e7a-653b59073deb","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<ProjectMaterialView>("08d004bc-e62f-491c-b89e-833d19131216","","",true, this);
 
            QuantityImputed = RPSControlFactory.CreateRPSFormattedTextBox<ProjectMaterialView>("cda5eb01-d8d7-47a9-ae5e-b0250d48f6b3","","",false, this);
 
            Completed = RPSControlFactory.CreateRPSCheckBox<ProjectMaterialView>("670a0fd3-1103-4ae6-abf8-f771fc1a6dc2","","",true, this);
 
            SupplySituation = RPSControlFactory.CreateRPSEnumComboBox<ProjectMaterialView>("47206c0c-4ee3-45a5-b48c-a0f62e25707b","","",false, this);
 
            Status = RPSControlFactory.CreateRPSEnumComboBox<ProjectMaterialView>("027f1499-f8de-4c03-8402-649cfbade672","","",true, this);
 
            IncludePacking = RPSControlFactory.CreateRPSEnumComboBox<ProjectMaterialView>("a50311cb-5b07-4b04-8ac6-e545ba62a9ed","","",true, this);
 
            IDArticleParent = RPSControlFactory.CreateRPSComboBox<ProjectMaterialView>("4f19a6e8-a416-4a0b-9689-66b23764de01","","",false, this);
 
            QuantityParent = RPSControlFactory.CreateRPSFormattedTextBox<ProjectMaterialView>("dca35770-eb51-4cbc-855c-b6ccc20af4cd","","",true, this);
 
            CADFileVersion = RPSControlFactory.CreateRPSTextBox<ProjectMaterialView>("99404bdf-5bfb-4d7c-a1f9-bc2c09a5581e","","",false, this);
 
            QuantityElements = RPSControlFactory.CreateRPSFormattedTextBox<ProjectMaterialView>("37c544c3-e666-476a-adeb-7ef613841124","","",true, this);
 
            AdvanceDays = RPSControlFactory.CreateRPSFormattedTextBox<ProjectMaterialView>("c1a15231-f78b-44f0-9aa3-aa3cfdae34b1","","",true, this);
 
            BlockedQuantityReference = RPSControlFactory.CreateRPSCheckBox<ProjectMaterialView>("06e80947-48bd-44f9-ac20-a99d6c84da7f","","",true, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<ProjectMaterialView>("79cb1ce3-fed9-46e5-9919-8f72ca485435","","",false, this);
 
            IDWareHouse = RPSControlFactory.CreateRPSComboBox<ProjectMaterialView>("849b44ac-3781-4513-9ae6-1c936da1585b","","",false, this);
 
            MakeMovement = RPSControlFactory.CreateRPSCheckBox<ProjectMaterialView>("80a53ea8-a4e5-442a-9000-a1f5537969ae","","",true, this);
 
            MakeAutomaticOutput = RPSControlFactory.CreateRPSCheckBox<ProjectMaterialView>("01b16898-0c7e-46e5-ae01-421369c39d78","","",true, this);
 
            ImputationTotalQuantity = RPSControlFactory.CreateRPSCheckBox<ProjectMaterialView>("90160e8e-0421-4ddf-8900-bfd7fdfc2216","","",true, this);
 
            ImputationCostUpdated = RPSControlFactory.CreateRPSCheckBox<ProjectMaterialView>("284e3087-14ae-43b2-825f-af82dc364bc9","","",true, this);
 
            Critical = RPSControlFactory.CreateRPSCheckBox<ProjectMaterialView>("2c88227f-215b-4e67-b494-9f25cf74f21a","","",true, this);
 
            CalcAmountCost = RPSControlFactory.CreateRPSFormattedTextBox<ProjectMaterialView>("769b5cf9-3fca-4b01-9b78-212329fdd681","","",false, this);
 
            CalcAmountCostReal = RPSControlFactory.CreateRPSFormattedTextBox<ProjectMaterialView>("db62fdf7-f5bd-4c4c-b163-ded82d467eca","","",false, this);
 
            CalcAmountSale = RPSControlFactory.CreateRPSFormattedTextBox<ProjectMaterialView>("6286322a-dd09-4801-b388-06e3e7814468","","",false, this);
 
            TypeProfit = RPSControlFactory.CreateRPSEnumComboBox<ProjectMaterialView>("c4af2283-7670-4f67-836d-e2cb91ef3877","","",true, this);
 
            PriceCostTheoric = RPSControlFactory.CreateRPSFormattedTextBox<ProjectMaterialView>("282066c7-c962-4f16-b043-769a56d1b7eb","","",false, this);
 
            PercentProfit = RPSControlFactory.CreateRPSFormattedTextBox<ProjectMaterialView>("7637e815-d5cc-48f5-8038-6288bd95f8c8","","",true, this);
 
            PriceSaleTheoric = RPSControlFactory.CreateRPSFormattedTextBox<ProjectMaterialView>("04eb6337-e0ec-4f0f-baf8-1914254f578a","","",false, this);
 
            BlockedBudget = RPSControlFactory.CreateRPSCheckBox<ProjectMaterialView>("7b0c5243-794d-4b4c-be16-f80ab77cfcfb","","",true, this);
 
            BudgetQuantity = RPSControlFactory.CreateRPSFormattedTextBox<ProjectMaterialView>("18f0b829-1f99-48e2-87b8-4a1ae8e63e41","","",true, this);
 
            BudgetPrice = RPSControlFactory.CreateRPSFormattedTextBox<ProjectMaterialView>("756e56a6-e1ec-4877-8a61-659f5f4421c2","","",true, this);
 
            BudgetAmount = RPSControlFactory.CreateRPSFormattedTextBox<ProjectMaterialView>("6434d664-9708-4a23-93b8-c7d2439445d2","","",true, this);
 
            IDBudgetCategory = RPSControlFactory.CreateRPSComboBox<ProjectMaterialView>("11489dcb-9fb0-439c-ae7b-6d5893bf50ed","","",false, this);
 
            Notes = RPSControlFactory.CreateRPSTextBox<ProjectMaterialView>("b128e7a4-6b27-486f-a404-40bfc8e95c60","","",false, this);
 
            IDTask = RPSControlFactory.CreateRPSComboBox<ProjectMaterialView>("a53cba01-69ab-4c74-af5c-74aacc453e00","","",false, this);
 
            IDMaterial = RPSControlFactory.CreateRPSComboBox<ProjectMaterialView>("882d58fd-2e9f-4bbb-b9b6-e2b3f081c13d","","",false, this);
 
            StartDate = RPSControlFactory.CreateRPSTextBox<ProjectMaterialView>("976fd14c-a90c-4974-8909-aac68b715764","","",false, this);
 
            ArticleType = RPSControlFactory.CreateRPSEnumComboBox<ProjectMaterialView>("438aadd6-3f7c-434b-aaad-a6f7e0da226f","","",false, this);
 
            ProjectProvisionType = RPSControlFactory.CreateRPSEnumComboBox<ProjectMaterialView>("9f215765-3967-423d-be65-26a0b9d87cd2","","",false, this);
 
            SupplySituation1 = RPSControlFactory.CreateRPSEnumComboBox<ProjectMaterialView>("47748ee8-5f8b-4a24-81d8-a7c5c22022c6","","",false, this);
 
            Quantity1 = RPSControlFactory.CreateRPSFormattedTextBox<ProjectMaterialView>("89cefd43-7a70-495a-816e-5b02e6dc7331","","",false, this);
 
            QuantityToSupplyment = RPSControlFactory.CreateRPSFormattedTextBox<ProjectMaterialView>("d17edf1b-cf3b-4e61-baee-466416ac5ab9","","",false, this);
 
            Suffix = RPSControlFactory.CreateRPSTextBox<ProjectMaterialView>("66c57a16-b244-4cf4-bd85-28dc85a3888d","","",false, this);
 
            QuantityImputated = RPSControlFactory.CreateRPSFormattedTextBox<ProjectMaterialView>("545cd211-30fd-4342-9669-95d3b4e55858","","",false, this);
 
            QuantityPendingImputate = RPSControlFactory.CreateRPSFormattedTextBox<ProjectMaterialView>("0094ec29-79c1-41cd-ab5e-dbf944691709","","",false, this);
 
            QuantityAvailableStock = RPSControlFactory.CreateRPSFormattedTextBox<ProjectMaterialView>("34e77901-6086-4701-8a9c-8abd9e384caa","","",false, this);
 
            QuantityAssigned = RPSControlFactory.CreateRPSFormattedTextBox<ProjectMaterialView>("1aa3d13a-1b12-4604-9d5e-505bbae40808","","",false, this);
 
            PurchaseProposal = RPSControlFactory.CreateRPSTextBox<ProjectMaterialView>("9af5acbf-5298-4f48-bc68-1acf6b41a429","","",false, this);
 
            IDPurchaseProposal = RPSControlFactory.CreateRPSComboBox<ProjectMaterialView>("3c227da5-2a5c-4dc6-b686-af3fa6800ad2","","",false, this);
 
            PurchaseOrder = RPSControlFactory.CreateRPSTextBox<ProjectMaterialView>("e816fe6d-f249-4670-b7c8-c54556c91532","","",false, this);
 
            IDOrder = RPSControlFactory.CreateRPSComboBox<ProjectMaterialView>("5317a7c4-ebb5-4b60-b110-1ddb404728d7","","",false, this);
 
            ManufacturingOrder = RPSControlFactory.CreateRPSTextBox<ProjectMaterialView>("0f723127-1ba5-44f8-8dde-7db8b0d68092","","",false, this);
 
            IDManufacturingOrder1 = RPSControlFactory.CreateRPSComboBox<ProjectMaterialView>("b0c92427-b394-41d7-a06a-ea1025d7c152","","",false, this);
 
            QuantityOrdered = RPSControlFactory.CreateRPSFormattedTextBox<ProjectMaterialView>("6db10179-b66e-4ef7-bfb0-11ca8f420954","","",false, this);
 
            QuantityDelivered = RPSControlFactory.CreateRPSFormattedTextBox<ProjectMaterialView>("96d3c88c-7f21-40e2-8be4-71bb67c9e045","","",false, this);
 
            QuantityInvoiced = RPSControlFactory.CreateRPSFormattedTextBox<ProjectMaterialView>("f1e62757-7e4f-4967-951e-b2247a4dd39d","","",false, this);
 
            QuantityPendingDelivery = RPSControlFactory.CreateRPSFormattedTextBox<ProjectMaterialView>("8c089644-eba6-4a07-9e07-31487741e7cd","","",false, this);
 
            Matchcode = RPSControlFactory.CreateRPSTextBox<ProjectMaterialView>("52a7499a-80a2-4219-a78c-27612938c551","","",false, this);
 
            BlockedMRP = RPSControlFactory.CreateRPSCheckBox<ProjectMaterialView>("1d80a691-3ee6-4e08-adea-d1edb47bd2d8","","",true, this);
 
            GenerateSupplysCommandButton = RPSControlFactory.CreateRPSButtonToView<ProjectMaterialView,SupplysUpdateOptionsScreenDialogView>("1cc7e1e6-0293-4902-af48-3369ecf33bd1","","", this,Screen.SupplysUpdateOptionsScreenDialogView);
 
            ExecuteProjectTaskMaterialStockReserveAutomaticButton = RPSControlFactory.CreateRPSButton<ProjectMaterialView>( "ad8542de-b649-495a-aab8-c451b288bd19","","",this);
 
            ProjectMaterialChangeStatusNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ProjectMaterialView,ProjectMaterialChangeStatusDialogView>("a5a1b6c7-df39-4b41-9fe5-ed5563b1dc65","","", this,Screen.ProjectMaterialChangeStatusDialogView);
 
            SectionGeneral = RPSControlFactory.CreateRPSSection<ProjectMaterialView>( "","ul li[rpsid='dac188fa-a0a1-41fe-839d-4633d360cc44']","",this);
 
            SectionComentarios = RPSControlFactory.CreateRPSSection<ProjectMaterialView>( "","ul li[rpsid='b2d9e01f-3361-4826-af73-0b9ecfc3038d']","",this);
 
            Section = RPSControlFactory.CreateRPSSection<ProjectMaterialView>( "","ul li[rpsid='7941fe88-e0e7-4409-8726-c9c9059bb80c']","",this);
 
            SectionDPS = RPSControlFactory.CreateRPSSection<ProjectMaterialView>( "","ul li[rpsid='11155558-cf23-401b-8a5c-bfa992618789']","",this);
 

        }
        public IRPSButton<ProjectMaterialView> DeleteButton { get; set; } 
        public IRPSButton<ProjectMaterialView,ProjectTaskView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ProjectMaterialView,ProjectTaskView> BackButton { get; set; } 
        public IRPSAcceptButton<ProjectMaterialView,ProjectTaskView> AcceptButton { get; set; } 
        public IRPSTextBox<ProjectMaterialView> CodMaterial { get; set; } 
        public IRPSComboBox<ProjectMaterialView> IDArticle { get; set; } 
        public IRPSTextBox<ProjectMaterialView> Description { get; set; } 
        public IRPSTextBox<ProjectMaterialView> Quantity { get; set; } 
        public IRPSTextBox<ProjectMaterialView> QuantityImputed { get; set; } 
        public IRPSCheckbox<ProjectMaterialView> Completed { get; set; } 
        public IRPSComboBox<ProjectMaterialView> SupplySituation { get; set; } 
        public IRPSComboBox<ProjectMaterialView> Status { get; set; } 
        public IRPSComboBox<ProjectMaterialView> IncludePacking { get; set; } 
        public IRPSComboBox<ProjectMaterialView> IDArticleParent { get; set; } 
        public IRPSTextBox<ProjectMaterialView> QuantityParent { get; set; } 
        public IRPSTextBox<ProjectMaterialView> CADFileVersion { get; set; } 
        public IRPSTextBox<ProjectMaterialView> QuantityElements { get; set; } 
        public IRPSTextBox<ProjectMaterialView> AdvanceDays { get; set; } 
        public IRPSCheckbox<ProjectMaterialView> BlockedQuantityReference { get; set; } 
        public IRPSComboBox<ProjectMaterialView> IDSite { get; set; } 
        public IRPSComboBox<ProjectMaterialView> IDWareHouse { get; set; } 
        public IRPSCheckbox<ProjectMaterialView> MakeMovement { get; set; } 
        public IRPSCheckbox<ProjectMaterialView> MakeAutomaticOutput { get; set; } 
        public IRPSCheckbox<ProjectMaterialView> ImputationTotalQuantity { get; set; } 
        public IRPSCheckbox<ProjectMaterialView> ImputationCostUpdated { get; set; } 
        public IRPSCheckbox<ProjectMaterialView> Critical { get; set; } 
        public IRPSTextBox<ProjectMaterialView> CalcAmountCost { get; set; } 
        public IRPSTextBox<ProjectMaterialView> CalcAmountCostReal { get; set; } 
        public IRPSTextBox<ProjectMaterialView> CalcAmountSale { get; set; } 
        public IRPSComboBox<ProjectMaterialView> TypeProfit { get; set; } 
        public IRPSTextBox<ProjectMaterialView> PriceCostTheoric { get; set; } 
        public IRPSTextBox<ProjectMaterialView> PercentProfit { get; set; } 
        public IRPSTextBox<ProjectMaterialView> PriceSaleTheoric { get; set; } 
        public IRPSCheckbox<ProjectMaterialView> BlockedBudget { get; set; } 
        public IRPSTextBox<ProjectMaterialView> BudgetQuantity { get; set; } 
        public IRPSTextBox<ProjectMaterialView> BudgetPrice { get; set; } 
        public IRPSTextBox<ProjectMaterialView> BudgetAmount { get; set; } 
        public IRPSComboBox<ProjectMaterialView> IDBudgetCategory { get; set; } 
        public IRPSTextBox<ProjectMaterialView> Notes { get; set; } 
        public IRPSComboBox<ProjectMaterialView> IDTask { get; set; } 
        public IRPSComboBox<ProjectMaterialView> IDMaterial { get; set; } 
        public IRPSTextBox<ProjectMaterialView> StartDate { get; set; } 
        public IRPSComboBox<ProjectMaterialView> ArticleType { get; set; } 
        public IRPSComboBox<ProjectMaterialView> ProjectProvisionType { get; set; } 
        public IRPSComboBox<ProjectMaterialView> SupplySituation1 { get; set; } 
        public IRPSTextBox<ProjectMaterialView> Quantity1 { get; set; } 
        public IRPSTextBox<ProjectMaterialView> QuantityToSupplyment { get; set; } 
        public IRPSTextBox<ProjectMaterialView> Suffix { get; set; } 
        public IRPSTextBox<ProjectMaterialView> QuantityImputated { get; set; } 
        public IRPSTextBox<ProjectMaterialView> QuantityPendingImputate { get; set; } 
        public IRPSTextBox<ProjectMaterialView> QuantityAvailableStock { get; set; } 
        public IRPSTextBox<ProjectMaterialView> QuantityAssigned { get; set; } 
        public IRPSTextBox<ProjectMaterialView> PurchaseProposal { get; set; } 
        public IRPSComboBox<ProjectMaterialView> IDPurchaseProposal { get; set; } 
        public IRPSTextBox<ProjectMaterialView> PurchaseOrder { get; set; } 
        public IRPSComboBox<ProjectMaterialView> IDOrder { get; set; } 
        public IRPSTextBox<ProjectMaterialView> ManufacturingOrder { get; set; } 
        public IRPSComboBox<ProjectMaterialView> IDManufacturingOrder1 { get; set; } 
        public IRPSTextBox<ProjectMaterialView> QuantityOrdered { get; set; } 
        public IRPSTextBox<ProjectMaterialView> QuantityDelivered { get; set; } 
        public IRPSTextBox<ProjectMaterialView> QuantityInvoiced { get; set; } 
        public IRPSTextBox<ProjectMaterialView> QuantityPendingDelivery { get; set; } 
        public IRPSTextBox<ProjectMaterialView> Matchcode { get; set; } 
        public IRPSCheckbox<ProjectMaterialView> BlockedMRP { get; set; } 
        public IRPSButton<ProjectMaterialView,SupplysUpdateOptionsScreenDialogView> GenerateSupplysCommandButton { get; set; } 
        public IRPSButton<ProjectMaterialView> ExecuteProjectTaskMaterialStockReserveAutomaticButton { get; set; } 
        public IRPSButton<ProjectMaterialView,ProjectMaterialChangeStatusDialogView> ProjectMaterialChangeStatusNavigationCommandButton { get; set; } 
        public IRPSSection<ProjectMaterialView> SectionGeneral { get; set; } 
        public IRPSSection<ProjectMaterialView> SectionComentarios { get; set; } 
        public IRPSSection<ProjectMaterialView> Section { get; set; } 
        public IRPSSection<ProjectMaterialView> SectionDPS { get; set; } 
        public Project Screen { get; set; }
        public ProjectMaterialView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ProjectResourceEmployeeView : View
    {
        public ProjectResourceEmployeeView(Project screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ProjectResourceEmployeeView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ProjectResourceEmployeeView,ProjectTaskView>( this,Screen.ProjectTaskView);
 
            BackButton = RPSControlFactory.RPSBackButton<ProjectResourceEmployeeView,ProjectTaskView>( this,Screen.ProjectTaskView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ProjectResourceEmployeeView,ProjectTaskView>( this,Screen.ProjectTaskView);
 
            CodResourceEmployee = RPSControlFactory.CreateRPSTextBox<ProjectResourceEmployeeView>("502996bc-8161-4423-8388-bd18d5ede738","","",true, this);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<ProjectResourceEmployeeView>("6d83c707-d146-48e9-9ccf-944a055bbeb6","","",false, this);
 
            IDQualify = RPSControlFactory.CreateRPSComboBox<ProjectResourceEmployeeView>("02f326d2-ee30-45e1-bb6b-3d7d7df8f476","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ProjectResourceEmployeeView>("27d0596d-d5f4-4145-ace4-00bcc4ced8a0","","",false, this);
 
            DedicationPercent = RPSControlFactory.CreateRPSFormattedTextBox<ProjectResourceEmployeeView>("0b5c2a35-3df1-432e-9a6b-bfcd924eeb78","","",true, this);
 
            Planify = RPSControlFactory.CreateRPSCheckBox<ProjectResourceEmployeeView>("babee422-ef32-4c96-aff5-524feaf450e3","","",true, this);
 
            Duration = RPSControlFactory.CreateRPSDurationTextBox<ProjectResourceEmployeeView>("f2ab09df-ea72-4c03-a8ab-680b123f02ed","","",true, this);
 
            VariableEmployee = RPSControlFactory.CreateRPSCheckBox<ProjectResourceEmployeeView>("cc4060e6-d5df-44f3-ad29-2a328d7bfab0","","",true, this);
 
            BlockedQuantityReference = RPSControlFactory.CreateRPSCheckBox<ProjectResourceEmployeeView>("41fc23e9-a301-4bfb-bc43-3e1906684718","","",true, this);
 
            PreparationTime = RPSControlFactory.CreateRPSDurationTextBox<ProjectResourceEmployeeView>("d163b506-6367-4ea2-92af-7875903094a2","","",true, this);
 
            ExecutionTime = RPSControlFactory.CreateRPSDurationTextBox<ProjectResourceEmployeeView>("e4a1bccb-30cb-432b-97b4-6fcbe576a3c5","","",true, this);
 
            PercentProgress = RPSControlFactory.CreateRPSFormattedTextBox<ProjectResourceEmployeeView>("79a0f303-ef7b-4613-9a7a-f1a084396093","","",true, this);
 
            CalcHourPendingManual = RPSControlFactory.CreateRPSFormattedTextBox<ProjectResourceEmployeeView>("970024b8-0e6f-4ecb-9c57-7444ee36362a","","",false, this);
 
            CalcPercentProgress = RPSControlFactory.CreateRPSFormattedTextBox<ProjectResourceEmployeeView>("87c1fd05-707b-42ef-9637-b13b2f8ba9cc","","",false, this);
 
            CalcHourReal = RPSControlFactory.CreateRPSFormattedTextBox<ProjectResourceEmployeeView>("fa64babe-0afe-4dd3-836e-b6da2613a69f","","",false, this);
 
            CalcAmountCost = RPSControlFactory.CreateRPSFormattedTextBox<ProjectResourceEmployeeView>("58cfc73d-a7a2-4ce5-94c7-1a171369fd56","","",false, this);
 
            CalcAmountCostReal = RPSControlFactory.CreateRPSFormattedTextBox<ProjectResourceEmployeeView>("b0c3ecd1-a55f-47d2-944b-586cfe3709d8","","",false, this);
 
            CalcAmountSale = RPSControlFactory.CreateRPSFormattedTextBox<ProjectResourceEmployeeView>("7ac574eb-965d-4408-bcf6-476ee36296c8","","",false, this);
 
            TypeProfit = RPSControlFactory.CreateRPSEnumComboBox<ProjectResourceEmployeeView>("22f94bf3-0f1d-425a-83ca-fe91274e2531","","",true, this);
 
            PriceCostTheoric = RPSControlFactory.CreateRPSFormattedTextBox<ProjectResourceEmployeeView>("abefc1cd-08e6-46a7-a1e2-8383adb49f75","","",false, this);
 
            PercentProfit = RPSControlFactory.CreateRPSFormattedTextBox<ProjectResourceEmployeeView>("a8b197df-cffd-4907-bd80-8f0e01561456","","",true, this);
 
            PriceSaleTheoric = RPSControlFactory.CreateRPSFormattedTextBox<ProjectResourceEmployeeView>("6303ebbd-9157-4535-b479-d4942c5e3d4b","","",false, this);
 
            BlockedBudget = RPSControlFactory.CreateRPSCheckBox<ProjectResourceEmployeeView>("04944c54-803c-4697-b9a2-b440ec96c46e","","",true, this);
 
            BudgetQuantity = RPSControlFactory.CreateRPSFormattedTextBox<ProjectResourceEmployeeView>("5f398e08-9ce6-4f18-86e9-a14bc4cbb80e","","",true, this);
 
            BudgetPrice = RPSControlFactory.CreateRPSFormattedTextBox<ProjectResourceEmployeeView>("a5563a15-db5e-4deb-849c-cb43c270a799","","",true, this);
 
            BudgetAmount = RPSControlFactory.CreateRPSFormattedTextBox<ProjectResourceEmployeeView>("ea0cc30b-d12a-45ac-bb88-174557222c80","","",true, this);
 
            IDBudgetCategory = RPSControlFactory.CreateRPSComboBox<ProjectResourceEmployeeView>("bbf8a7e4-7718-46e3-a2cd-204eafad9c80","","",false, this);
 

        }
        public IRPSButton<ProjectResourceEmployeeView> DeleteButton { get; set; } 
        public IRPSButton<ProjectResourceEmployeeView,ProjectTaskView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ProjectResourceEmployeeView,ProjectTaskView> BackButton { get; set; } 
        public IRPSAcceptButton<ProjectResourceEmployeeView,ProjectTaskView> AcceptButton { get; set; } 
        public IRPSTextBox<ProjectResourceEmployeeView> CodResourceEmployee { get; set; } 
        public IRPSComboBox<ProjectResourceEmployeeView> IDEmployee { get; set; } 
        public IRPSComboBox<ProjectResourceEmployeeView> IDQualify { get; set; } 
        public IRPSTextBox<ProjectResourceEmployeeView> Description { get; set; } 
        public IRPSTextBox<ProjectResourceEmployeeView> DedicationPercent { get; set; } 
        public IRPSCheckbox<ProjectResourceEmployeeView> Planify { get; set; } 
        public IRPSDurationTextBox<ProjectResourceEmployeeView> Duration { get; set; } 
        public IRPSCheckbox<ProjectResourceEmployeeView> VariableEmployee { get; set; } 
        public IRPSCheckbox<ProjectResourceEmployeeView> BlockedQuantityReference { get; set; } 
        public IRPSDurationTextBox<ProjectResourceEmployeeView> PreparationTime { get; set; } 
        public IRPSDurationTextBox<ProjectResourceEmployeeView> ExecutionTime { get; set; } 
        public IRPSTextBox<ProjectResourceEmployeeView> PercentProgress { get; set; } 
        public IRPSTextBox<ProjectResourceEmployeeView> CalcHourPendingManual { get; set; } 
        public IRPSTextBox<ProjectResourceEmployeeView> CalcPercentProgress { get; set; } 
        public IRPSTextBox<ProjectResourceEmployeeView> CalcHourReal { get; set; } 
        public IRPSTextBox<ProjectResourceEmployeeView> CalcAmountCost { get; set; } 
        public IRPSTextBox<ProjectResourceEmployeeView> CalcAmountCostReal { get; set; } 
        public IRPSTextBox<ProjectResourceEmployeeView> CalcAmountSale { get; set; } 
        public IRPSComboBox<ProjectResourceEmployeeView> TypeProfit { get; set; } 
        public IRPSTextBox<ProjectResourceEmployeeView> PriceCostTheoric { get; set; } 
        public IRPSTextBox<ProjectResourceEmployeeView> PercentProfit { get; set; } 
        public IRPSTextBox<ProjectResourceEmployeeView> PriceSaleTheoric { get; set; } 
        public IRPSCheckbox<ProjectResourceEmployeeView> BlockedBudget { get; set; } 
        public IRPSTextBox<ProjectResourceEmployeeView> BudgetQuantity { get; set; } 
        public IRPSTextBox<ProjectResourceEmployeeView> BudgetPrice { get; set; } 
        public IRPSTextBox<ProjectResourceEmployeeView> BudgetAmount { get; set; } 
        public IRPSComboBox<ProjectResourceEmployeeView> IDBudgetCategory { get; set; } 
        public Project Screen { get; set; }
        public ProjectResourceEmployeeView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ProjectResourceMachineView : View
    {
        public ProjectResourceMachineView(Project screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ProjectResourceMachineView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ProjectResourceMachineView,ProjectTaskView>( this,Screen.ProjectTaskView);
 
            BackButton = RPSControlFactory.RPSBackButton<ProjectResourceMachineView,ProjectTaskView>( this,Screen.ProjectTaskView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ProjectResourceMachineView,ProjectTaskView>( this,Screen.ProjectTaskView);
 
            CodResourceMachine = RPSControlFactory.CreateRPSTextBox<ProjectResourceMachineView>("f2168533-c155-4ee8-b6e1-c0c6885c900c","","",true, this);
 
            IDMachine = RPSControlFactory.CreateRPSComboBox<ProjectResourceMachineView>("d9044f20-d6a3-4534-8320-95c0dfdb31bb","","",false, this);
 
            IDMachineGroup = RPSControlFactory.CreateRPSComboBox<ProjectResourceMachineView>("67e650ef-8f9d-4a99-8fe2-5293fad73d2b","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ProjectResourceMachineView>("2fd90c82-0dea-4d03-a338-b53b2168a5c6","","",false, this);
 
            IDProResourceEmployee = RPSControlFactory.CreateRPSComboBox<ProjectResourceMachineView>("38bbce8d-0f66-4497-ac23-271a3c9a7a34","","",false, this);
 
            DedicationPercent = RPSControlFactory.CreateRPSFormattedTextBox<ProjectResourceMachineView>("b19af95a-a652-4fce-bde3-a8a6870151c3","","",true, this);
 
            Planify = RPSControlFactory.CreateRPSCheckBox<ProjectResourceMachineView>("44a3da77-0324-479f-aebf-4987d175392b","","",true, this);
 
            Duration = RPSControlFactory.CreateRPSDurationTextBox<ProjectResourceMachineView>("8300e7bb-e901-41b0-864e-65efd50b5d2d","","",false, this);
 
            VariableGroup = RPSControlFactory.CreateRPSCheckBox<ProjectResourceMachineView>("355e15d9-b288-4498-aca3-c90fab4dcdd1","","",true, this);
 
            BlockedQuantityReference = RPSControlFactory.CreateRPSCheckBox<ProjectResourceMachineView>("22e8819e-70a9-47fe-8d00-02c88508889c","","",true, this);
 
            PreparationTime = RPSControlFactory.CreateRPSDurationTextBox<ProjectResourceMachineView>("0b00575d-a1b3-4f20-a8f4-1cea2b258a84","","",true, this);
 
            ExecutionTime = RPSControlFactory.CreateRPSDurationTextBox<ProjectResourceMachineView>("3a440628-3729-46bc-b7fa-fea9294f8656","","",true, this);
 
            PercentProgress = RPSControlFactory.CreateRPSFormattedTextBox<ProjectResourceMachineView>("761e1fb4-6aa9-4065-a743-72ef3a8a691b","","",true, this);
 
            CalcHourPendingManual = RPSControlFactory.CreateRPSFormattedTextBox<ProjectResourceMachineView>("4344f312-f72c-4c33-bbf0-a70850ec8a52","","",false, this);
 
            CalcPercentProgress = RPSControlFactory.CreateRPSFormattedTextBox<ProjectResourceMachineView>("258e4a22-c9e3-4ec5-9952-222ea11771ba","","",false, this);
 
            CalcHourReal = RPSControlFactory.CreateRPSFormattedTextBox<ProjectResourceMachineView>("67987b2d-4611-4ba0-bdb4-c4209ee52da6","","",false, this);
 
            CalcAmountCost = RPSControlFactory.CreateRPSFormattedTextBox<ProjectResourceMachineView>("4eaad4d1-03e9-42a9-b169-698eac7b6d49","","",false, this);
 
            CalcAmountCostReal = RPSControlFactory.CreateRPSFormattedTextBox<ProjectResourceMachineView>("c331009a-d007-4d88-a31a-a25783c0b5c7","","",false, this);
 
            CalcAmountSale = RPSControlFactory.CreateRPSFormattedTextBox<ProjectResourceMachineView>("40a978cb-02ce-455a-a209-3d0530ff5a89","","",false, this);
 
            TypeProfit = RPSControlFactory.CreateRPSEnumComboBox<ProjectResourceMachineView>("e2611789-f4ab-4d2b-bef8-dd437e095918","","",true, this);
 
            PriceCostTheoric = RPSControlFactory.CreateRPSFormattedTextBox<ProjectResourceMachineView>("0e3cc289-5b71-4c04-a35f-e5e90fa19175","","",false, this);
 
            PercentProfit = RPSControlFactory.CreateRPSFormattedTextBox<ProjectResourceMachineView>("4ff6f1bd-94d0-423a-9152-768813bb8baf","","",true, this);
 
            PriceSaleTheoric = RPSControlFactory.CreateRPSFormattedTextBox<ProjectResourceMachineView>("38236b61-b067-4008-8e33-533be6f08483","","",false, this);
 
            BlockedBudget = RPSControlFactory.CreateRPSCheckBox<ProjectResourceMachineView>("df2fc83c-43d2-44c3-bf9b-2157e9b9e432","","",true, this);
 
            BudgetQuantity = RPSControlFactory.CreateRPSFormattedTextBox<ProjectResourceMachineView>("643ffed7-32d6-40ab-b021-43c0d0400249","","",true, this);
 
            BudgetPrice = RPSControlFactory.CreateRPSFormattedTextBox<ProjectResourceMachineView>("8f2c563f-9385-4e46-8452-146ef448b081","","",true, this);
 
            BudgetAmount = RPSControlFactory.CreateRPSFormattedTextBox<ProjectResourceMachineView>("83e3c428-e7cf-4eb7-884b-370be730040d","","",true, this);
 
            IDBudgetCategory = RPSControlFactory.CreateRPSComboBox<ProjectResourceMachineView>("e341e33c-51b0-4579-8aa8-35fdb384250e","","",false, this);
 

        }
        public IRPSButton<ProjectResourceMachineView> DeleteButton { get; set; } 
        public IRPSButton<ProjectResourceMachineView,ProjectTaskView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ProjectResourceMachineView,ProjectTaskView> BackButton { get; set; } 
        public IRPSAcceptButton<ProjectResourceMachineView,ProjectTaskView> AcceptButton { get; set; } 
        public IRPSTextBox<ProjectResourceMachineView> CodResourceMachine { get; set; } 
        public IRPSComboBox<ProjectResourceMachineView> IDMachine { get; set; } 
        public IRPSComboBox<ProjectResourceMachineView> IDMachineGroup { get; set; } 
        public IRPSTextBox<ProjectResourceMachineView> Description { get; set; } 
        public IRPSComboBox<ProjectResourceMachineView> IDProResourceEmployee { get; set; } 
        public IRPSTextBox<ProjectResourceMachineView> DedicationPercent { get; set; } 
        public IRPSCheckbox<ProjectResourceMachineView> Planify { get; set; } 
        public IRPSDurationTextBox<ProjectResourceMachineView> Duration { get; set; } 
        public IRPSCheckbox<ProjectResourceMachineView> VariableGroup { get; set; } 
        public IRPSCheckbox<ProjectResourceMachineView> BlockedQuantityReference { get; set; } 
        public IRPSDurationTextBox<ProjectResourceMachineView> PreparationTime { get; set; } 
        public IRPSDurationTextBox<ProjectResourceMachineView> ExecutionTime { get; set; } 
        public IRPSTextBox<ProjectResourceMachineView> PercentProgress { get; set; } 
        public IRPSTextBox<ProjectResourceMachineView> CalcHourPendingManual { get; set; } 
        public IRPSTextBox<ProjectResourceMachineView> CalcPercentProgress { get; set; } 
        public IRPSTextBox<ProjectResourceMachineView> CalcHourReal { get; set; } 
        public IRPSTextBox<ProjectResourceMachineView> CalcAmountCost { get; set; } 
        public IRPSTextBox<ProjectResourceMachineView> CalcAmountCostReal { get; set; } 
        public IRPSTextBox<ProjectResourceMachineView> CalcAmountSale { get; set; } 
        public IRPSComboBox<ProjectResourceMachineView> TypeProfit { get; set; } 
        public IRPSTextBox<ProjectResourceMachineView> PriceCostTheoric { get; set; } 
        public IRPSTextBox<ProjectResourceMachineView> PercentProfit { get; set; } 
        public IRPSTextBox<ProjectResourceMachineView> PriceSaleTheoric { get; set; } 
        public IRPSCheckbox<ProjectResourceMachineView> BlockedBudget { get; set; } 
        public IRPSTextBox<ProjectResourceMachineView> BudgetQuantity { get; set; } 
        public IRPSTextBox<ProjectResourceMachineView> BudgetPrice { get; set; } 
        public IRPSTextBox<ProjectResourceMachineView> BudgetAmount { get; set; } 
        public IRPSComboBox<ProjectResourceMachineView> IDBudgetCategory { get; set; } 
        public Project Screen { get; set; }
        public ProjectResourceMachineView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ProjectResourceToolView : View
    {
        public ProjectResourceToolView(Project screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ProjectResourceToolView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ProjectResourceToolView,ProjectTaskView>( this,Screen.ProjectTaskView);
 
            BackButton = RPSControlFactory.RPSBackButton<ProjectResourceToolView,ProjectTaskView>( this,Screen.ProjectTaskView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ProjectResourceToolView,ProjectTaskView>( this,Screen.ProjectTaskView);
 
            CodResourceTool = RPSControlFactory.CreateRPSTextBox<ProjectResourceToolView>("2b677066-543b-4711-9ac6-5b225bf6a6dc","","",true, this);
 
            IDTool = RPSControlFactory.CreateRPSComboBox<ProjectResourceToolView>("f4637b57-1958-4e64-9f60-1787dbd1f083","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ProjectResourceToolView>("351c2d83-03f9-4102-b178-109348d04c77","","",false, this);
 
            IDProResourceEmployee = RPSControlFactory.CreateRPSComboBox<ProjectResourceToolView>("46c01297-18df-4324-8276-b26b800a6329","","",false, this);
 
            DedicationPercent = RPSControlFactory.CreateRPSFormattedTextBox<ProjectResourceToolView>("48a62224-b8f4-48b3-87e4-813c7a4b6612","","",true, this);
 
            Planify = RPSControlFactory.CreateRPSCheckBox<ProjectResourceToolView>("b1baae07-f8e6-4582-bb83-a86f656201a5","","",true, this);
 
            Duration = RPSControlFactory.CreateRPSDurationTextBox<ProjectResourceToolView>("0f7da5cd-0db0-45ae-be03-81af7179316d","","",false, this);
 
            BlockedQuantityReference = RPSControlFactory.CreateRPSCheckBox<ProjectResourceToolView>("9c9d2186-e458-4083-b2eb-42de519d395b","","",true, this);
 
            PreparationTime = RPSControlFactory.CreateRPSDurationTextBox<ProjectResourceToolView>("5ff4cfbe-81c1-4ac4-bc3d-e253d4008753","","",true, this);
 
            ExecutionTime = RPSControlFactory.CreateRPSDurationTextBox<ProjectResourceToolView>("54ccf6ba-1469-4945-9c11-1d6427ad087c","","",true, this);
 
            PercentProgress = RPSControlFactory.CreateRPSFormattedTextBox<ProjectResourceToolView>("8434aa29-97fd-47ca-a00e-b5012395d7f0","","",true, this);
 
            CalcHourPendingManual = RPSControlFactory.CreateRPSFormattedTextBox<ProjectResourceToolView>("0ea0c0bb-7706-44e1-bfa7-bfdcf94b5374","","",false, this);
 
            CalcPercentProgress = RPSControlFactory.CreateRPSFormattedTextBox<ProjectResourceToolView>("73efb105-ef2b-4948-8c89-df5906ddb37c","","",false, this);
 
            CalcHourReal = RPSControlFactory.CreateRPSFormattedTextBox<ProjectResourceToolView>("0b33b5cb-d3da-4a73-9e73-2c7672883887","","",false, this);
 
            CalcAmountCost = RPSControlFactory.CreateRPSFormattedTextBox<ProjectResourceToolView>("888ec0a2-b529-4020-841b-8ebbfb76ce9d","","",false, this);
 
            CalcAmountCostReal = RPSControlFactory.CreateRPSFormattedTextBox<ProjectResourceToolView>("3d6e6a8a-89a0-40f5-9647-7eea3f501304","","",false, this);
 
            CalcAmountSale = RPSControlFactory.CreateRPSFormattedTextBox<ProjectResourceToolView>("602e37bb-53c6-4a25-8556-c693a35964a7","","",false, this);
 
            TypeProfit = RPSControlFactory.CreateRPSEnumComboBox<ProjectResourceToolView>("061730f8-8cb3-46f6-a126-ef63387f93da","","",true, this);
 
            PriceCostTheoric = RPSControlFactory.CreateRPSFormattedTextBox<ProjectResourceToolView>("a02e78fd-2c52-471a-9369-9ae3b8d7664d","","",false, this);
 
            PercentProfit = RPSControlFactory.CreateRPSFormattedTextBox<ProjectResourceToolView>("6d08d0a0-4881-4dee-a839-32a983101556","","",true, this);
 
            PriceSaleTheoric = RPSControlFactory.CreateRPSFormattedTextBox<ProjectResourceToolView>("88ef906e-5ef2-4dc7-8298-3e576b972814","","",false, this);
 
            BlockedBudget = RPSControlFactory.CreateRPSCheckBox<ProjectResourceToolView>("ae509e5a-eab0-4231-b5a7-2dd58e5a5a79","","",true, this);
 
            BudgetQuantity = RPSControlFactory.CreateRPSFormattedTextBox<ProjectResourceToolView>("3f7c67e6-c193-4ca8-bf02-8b79d96f3867","","",true, this);
 
            BudgetPrice = RPSControlFactory.CreateRPSFormattedTextBox<ProjectResourceToolView>("249e7598-7357-4535-9175-795b2741b9a4","","",true, this);
 
            BudgetAmount = RPSControlFactory.CreateRPSFormattedTextBox<ProjectResourceToolView>("889d4779-78e9-4e44-900b-31ccd4d69820","","",true, this);
 
            IDBudgetCategory = RPSControlFactory.CreateRPSComboBox<ProjectResourceToolView>("210da176-be17-4787-9d33-d30898ed0139","","",false, this);
 

        }
        public IRPSButton<ProjectResourceToolView> DeleteButton { get; set; } 
        public IRPSButton<ProjectResourceToolView,ProjectTaskView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ProjectResourceToolView,ProjectTaskView> BackButton { get; set; } 
        public IRPSAcceptButton<ProjectResourceToolView,ProjectTaskView> AcceptButton { get; set; } 
        public IRPSTextBox<ProjectResourceToolView> CodResourceTool { get; set; } 
        public IRPSComboBox<ProjectResourceToolView> IDTool { get; set; } 
        public IRPSTextBox<ProjectResourceToolView> Description { get; set; } 
        public IRPSComboBox<ProjectResourceToolView> IDProResourceEmployee { get; set; } 
        public IRPSTextBox<ProjectResourceToolView> DedicationPercent { get; set; } 
        public IRPSCheckbox<ProjectResourceToolView> Planify { get; set; } 
        public IRPSDurationTextBox<ProjectResourceToolView> Duration { get; set; } 
        public IRPSCheckbox<ProjectResourceToolView> BlockedQuantityReference { get; set; } 
        public IRPSDurationTextBox<ProjectResourceToolView> PreparationTime { get; set; } 
        public IRPSDurationTextBox<ProjectResourceToolView> ExecutionTime { get; set; } 
        public IRPSTextBox<ProjectResourceToolView> PercentProgress { get; set; } 
        public IRPSTextBox<ProjectResourceToolView> CalcHourPendingManual { get; set; } 
        public IRPSTextBox<ProjectResourceToolView> CalcPercentProgress { get; set; } 
        public IRPSTextBox<ProjectResourceToolView> CalcHourReal { get; set; } 
        public IRPSTextBox<ProjectResourceToolView> CalcAmountCost { get; set; } 
        public IRPSTextBox<ProjectResourceToolView> CalcAmountCostReal { get; set; } 
        public IRPSTextBox<ProjectResourceToolView> CalcAmountSale { get; set; } 
        public IRPSComboBox<ProjectResourceToolView> TypeProfit { get; set; } 
        public IRPSTextBox<ProjectResourceToolView> PriceCostTheoric { get; set; } 
        public IRPSTextBox<ProjectResourceToolView> PercentProfit { get; set; } 
        public IRPSTextBox<ProjectResourceToolView> PriceSaleTheoric { get; set; } 
        public IRPSCheckbox<ProjectResourceToolView> BlockedBudget { get; set; } 
        public IRPSTextBox<ProjectResourceToolView> BudgetQuantity { get; set; } 
        public IRPSTextBox<ProjectResourceToolView> BudgetPrice { get; set; } 
        public IRPSTextBox<ProjectResourceToolView> BudgetAmount { get; set; } 
        public IRPSComboBox<ProjectResourceToolView> IDBudgetCategory { get; set; } 
        public Project Screen { get; set; }
        public ProjectResourceToolView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ProjectTaskCostComponentView : View
    {
        public ProjectTaskCostComponentView(Project screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ProjectTaskCostComponentView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ProjectTaskCostComponentView,ProjectTaskView>( this,Screen.ProjectTaskView);
 
            BackButton = RPSControlFactory.RPSBackButton<ProjectTaskCostComponentView,ProjectTaskView>( this,Screen.ProjectTaskView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ProjectTaskCostComponentView,ProjectTaskView>( this,Screen.ProjectTaskView);
 
            CodCostComponent = RPSControlFactory.CreateRPSTextBox<ProjectTaskCostComponentView>("3397469e-46fa-42ce-8b14-a0ceb2ac2c09","","",true, this);
 
            IDCostComponent = RPSControlFactory.CreateRPSComboBox<ProjectTaskCostComponentView>("e9048170-e4b7-45cf-9e91-d744d3bce683","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ProjectTaskCostComponentView>("7c3c3eca-0dbe-42dc-8007-bae5d371487f","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskCostComponentView>("63566398-9111-40ce-8783-6ca1016fa9e4","","",true, this);
 
            BlockedQuantityReference = RPSControlFactory.CreateRPSCheckBox<ProjectTaskCostComponentView>("a483d5d7-5ded-43a0-aafc-c496e818b588","","",true, this);
 
            CalcAmountCost = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskCostComponentView>("de9ee90f-e405-454b-a776-90cb19a771da","","",false, this);
 
            CalcAmountCostReal = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskCostComponentView>("76ceaa49-9e6f-4921-948c-c25ff06d6233","","",false, this);
 
            CalcAmountSale = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskCostComponentView>("707355e9-80a7-4774-a408-5307dd42ce7f","","",false, this);
 
            TypeProfit = RPSControlFactory.CreateRPSEnumComboBox<ProjectTaskCostComponentView>("e72aff9c-bd34-449b-a24d-82be59e890dd","","",true, this);
 
            PriceCostTheoric = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskCostComponentView>("b5d9267d-5881-4ee7-904b-46d0ec41e869","","",false, this);
 
            PercentProfit = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskCostComponentView>("99b3522a-6011-4cb2-9144-b319ee2d83ab","","",true, this);
 
            PriceSaleTheoric = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskCostComponentView>("9b7bfd7a-eeef-428a-85fc-d09be12a3b33","","",false, this);
 
            BlockedBudget = RPSControlFactory.CreateRPSCheckBox<ProjectTaskCostComponentView>("b3f50d97-fe38-4364-82d4-1bf1ad8bf405","","",true, this);
 
            BudgetQuantity = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskCostComponentView>("2764aa68-43bd-4459-aae6-178076e9502b","","",true, this);
 
            BudgetPrice = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskCostComponentView>("602fdcd3-e0db-4aad-9577-848d06855a83","","",true, this);
 
            BudgetAmount = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskCostComponentView>("9b2d18df-0879-49aa-9c3e-e927a719be32","","",true, this);
 
            IDBudgetCategory = RPSControlFactory.CreateRPSComboBox<ProjectTaskCostComponentView>("1c027132-2bb4-415e-abb2-1841bf24f475","","",false, this);
 

        }
        public IRPSButton<ProjectTaskCostComponentView> DeleteButton { get; set; } 
        public IRPSButton<ProjectTaskCostComponentView,ProjectTaskView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ProjectTaskCostComponentView,ProjectTaskView> BackButton { get; set; } 
        public IRPSAcceptButton<ProjectTaskCostComponentView,ProjectTaskView> AcceptButton { get; set; } 
        public IRPSTextBox<ProjectTaskCostComponentView> CodCostComponent { get; set; } 
        public IRPSComboBox<ProjectTaskCostComponentView> IDCostComponent { get; set; } 
        public IRPSTextBox<ProjectTaskCostComponentView> Description { get; set; } 
        public IRPSTextBox<ProjectTaskCostComponentView> Quantity { get; set; } 
        public IRPSCheckbox<ProjectTaskCostComponentView> BlockedQuantityReference { get; set; } 
        public IRPSTextBox<ProjectTaskCostComponentView> CalcAmountCost { get; set; } 
        public IRPSTextBox<ProjectTaskCostComponentView> CalcAmountCostReal { get; set; } 
        public IRPSTextBox<ProjectTaskCostComponentView> CalcAmountSale { get; set; } 
        public IRPSComboBox<ProjectTaskCostComponentView> TypeProfit { get; set; } 
        public IRPSTextBox<ProjectTaskCostComponentView> PriceCostTheoric { get; set; } 
        public IRPSTextBox<ProjectTaskCostComponentView> PercentProfit { get; set; } 
        public IRPSTextBox<ProjectTaskCostComponentView> PriceSaleTheoric { get; set; } 
        public IRPSCheckbox<ProjectTaskCostComponentView> BlockedBudget { get; set; } 
        public IRPSTextBox<ProjectTaskCostComponentView> BudgetQuantity { get; set; } 
        public IRPSTextBox<ProjectTaskCostComponentView> BudgetPrice { get; set; } 
        public IRPSTextBox<ProjectTaskCostComponentView> BudgetAmount { get; set; } 
        public IRPSComboBox<ProjectTaskCostComponentView> IDBudgetCategory { get; set; } 
        public Project Screen { get; set; }
        public ProjectTaskCostComponentView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ProjectTaskRelationView : View
    {
        public ProjectTaskRelationView(Project screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ProjectTaskRelationView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ProjectTaskRelationView,ProjectTaskView>( this,Screen.ProjectTaskView);
 
            BackButton = RPSControlFactory.RPSBackButton<ProjectTaskRelationView,ProjectTaskView>( this,Screen.ProjectTaskView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ProjectTaskRelationView,ProjectTaskView>( this,Screen.ProjectTaskView);
 
            IDProTaskPredecessor = RPSControlFactory.CreateRPSComboBox<ProjectTaskRelationView>("96eaa0c3-991e-4b97-a2e2-fb83fcfe13ac","","",false, this);
 
            TypeTask = RPSControlFactory.CreateRPSEnumComboBox<ProjectTaskRelationView>("2c7ae376-a7ac-4eda-976b-7ad371546ec8","","",true, this);
 
            RelationType = RPSControlFactory.CreateRPSEnumComboBox<ProjectTaskRelationView>("2310ff0a-0798-4d60-80f7-6e9e2d078ef3","","",true, this);
 
            TimeLag = RPSControlFactory.CreateRPSDurationTextBox<ProjectTaskRelationView>("4b1f5ba0-ba7e-4c90-aea4-f961d52ecc14","","",false, this);
 
            CalendarType = RPSControlFactory.CreateRPSEnumComboBox<ProjectTaskRelationView>("715e1ee1-fb75-447f-859d-aa141ccf9c04","","",true, this);
 
            Linked = RPSControlFactory.CreateRPSCheckBox<ProjectTaskRelationView>("c7ffab9c-634c-4340-bd51-56143ab2c63f","","",true, this);
 

        }
        public IRPSButton<ProjectTaskRelationView> DeleteButton { get; set; } 
        public IRPSButton<ProjectTaskRelationView,ProjectTaskView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ProjectTaskRelationView,ProjectTaskView> BackButton { get; set; } 
        public IRPSAcceptButton<ProjectTaskRelationView,ProjectTaskView> AcceptButton { get; set; } 
        public IRPSComboBox<ProjectTaskRelationView> IDProTaskPredecessor { get; set; } 
        public IRPSComboBox<ProjectTaskRelationView> TypeTask { get; set; } 
        public IRPSComboBox<ProjectTaskRelationView> RelationType { get; set; } 
        public IRPSDurationTextBox<ProjectTaskRelationView> TimeLag { get; set; } 
        public IRPSComboBox<ProjectTaskRelationView> CalendarType { get; set; } 
        public IRPSCheckbox<ProjectTaskRelationView> Linked { get; set; } 
        public Project Screen { get; set; }
        public ProjectTaskRelationView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NewProjectVersionDialogDialogView : View
    {
        public NewProjectVersionDialogDialogView(Project screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            TargetVersion = RPSControlFactory.CreateRPSTextBox<NewProjectVersionDialogDialogView>("692d493d-7c10-4074-90db-5a12d18fd442","","",false, this);
 
            KeepCost = RPSControlFactory.CreateRPSCheckBox<NewProjectVersionDialogDialogView>("81a927d2-acb8-4d7c-9865-dfbbc1feed63","","",false, this);
 
            AdjustToEnd = RPSControlFactory.CreateRPSCheckBox<NewProjectVersionDialogDialogView>("26b10756-f125-44f9-8d59-caad53c3d477","","",false, this);
 
            PlannedDate = RPSControlFactory.CreateRPSTextBox<NewProjectVersionDialogDialogView>("a1f6ce44-3a2e-4079-9359-f66f9d3e329e","","",false, this);
 

        }
        public IRPSTextBox<NewProjectVersionDialogDialogView> TargetVersion { get; set; } 
        public IRPSCheckbox<NewProjectVersionDialogDialogView> KeepCost { get; set; } 
        public IRPSCheckbox<NewProjectVersionDialogDialogView> AdjustToEnd { get; set; } 
        public IRPSTextBox<NewProjectVersionDialogDialogView> PlannedDate { get; set; } 
        public Project Screen { get; set; }
        public NewProjectVersionDialogDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CreateProjectFromTaskDialogView : View
    {
        public CreateProjectFromTaskDialogView(Project screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            TargetCodProject = RPSControlFactory.CreateRPSTextBox<CreateProjectFromTaskDialogView>("e23f6d90-14c0-4cb6-a976-da1881894eea","","",false, this);
 
            TargetVersion = RPSControlFactory.CreateRPSTextBox<CreateProjectFromTaskDialogView>("7884675f-a24c-4280-a52f-6d79955fd9ce","","",false, this);
 
            IDEmployeeTechnical = RPSControlFactory.CreateRPSComboBox<CreateProjectFromTaskDialogView>("dc303d35-4cfd-4aa7-90dd-dfd6ec062c22","","",false, this);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<CreateProjectFromTaskDialogView>("954e7d74-b95d-43bf-b489-c98ec1665bea","","",false, this);
 

        }
        public IRPSTextBox<CreateProjectFromTaskDialogView> TargetCodProject { get; set; } 
        public IRPSTextBox<CreateProjectFromTaskDialogView> TargetVersion { get; set; } 
        public IRPSComboBox<CreateProjectFromTaskDialogView> IDEmployeeTechnical { get; set; } 
        public IRPSComboBox<CreateProjectFromTaskDialogView> IDProject { get; set; } 
        public Project Screen { get; set; }
        public CreateProjectFromTaskDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class AddUsualTaskDialogView : View
    {
        public AddUsualTaskDialogView(Project screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UsualTask = RPSControlFactory.CreateRPSComboBox<AddUsualTaskDialogView>("025fc2dd-933b-48bc-b2bd-e150362b4a5e","","",false, this);
 

        }
        public IRPSComboBox<AddUsualTaskDialogView> UsualTask { get; set; } 
        public Project Screen { get; set; }
        public AddUsualTaskDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ImportTaskDialogView : View
    {
        public ImportTaskDialogView(Project screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDProjectSource = RPSControlFactory.CreateRPSComboBox<ImportTaskDialogView>("e515d2af-6cd4-4b31-b984-2b0d037f2c0f","","",false, this);
 
            IDProjectTaskSource = RPSControlFactory.CreateRPSComboBox<ImportTaskDialogView>("aa3a0a8f-b6a0-4a5c-a377-f27b9df21112","","",false, this);
 
            OptionForward = RPSControlFactory.CreateRPSOption<ImportTaskDialogView>( "7a1d9312-c7b9-4b0e-a413-1e29b39403b1","","",this);
 
            OptionAdjustToEnd = RPSControlFactory.CreateRPSOption<ImportTaskDialogView>( "19df8bdd-a15a-48aa-b1b4-7c0f4e571057","","",this);
 
            PlannedDate = RPSControlFactory.CreateRPSTextBox<ImportTaskDialogView>("0e330493-0a58-416a-bbd5-a3b703d5e522","","",false, this);
 
            DuplicateTest = RPSControlFactory.CreateRPSCheckBox<ImportTaskDialogView>("cfd670cb-394d-49a8-b50b-3b4b9e66bb0f","","",false, this);
 
            DuplicateDocuments = RPSControlFactory.CreateRPSCheckBox<ImportTaskDialogView>("69a9852a-2db4-4fb7-8fbe-c8f3dfc48ef5","","",false, this);
 
            DuplicateResources = RPSControlFactory.CreateRPSCheckBox<ImportTaskDialogView>("2065c905-96c2-4ad7-8f24-befe5bd5c88e","","",false, this);
 
            ResourceAssignTimeReal = RPSControlFactory.CreateRPSCheckBox<ImportTaskDialogView>("3d97d24e-3da1-40da-a42a-0d9db341b95d","","",false, this);
 
            TheoricCostRes = RPSControlFactory.CreateRPSEnumComboBox<ImportTaskDialogView>("895966a1-bd39-476f-ba2e-7893360a46c1","","",false, this);
 
            SalesCostRes = RPSControlFactory.CreateRPSEnumComboBox<ImportTaskDialogView>("b40b0ac8-5c72-42c7-ad1e-5a26c30a9ca3","","",false, this);
 
            BudgetRes = RPSControlFactory.CreateRPSEnumComboBox<ImportTaskDialogView>("3176a340-d584-43f8-ba69-8597f1ff5ab8","","",false, this);
 
            GroupBudgetRes = RPSControlFactory.CreateRPSEnumComboBox<ImportTaskDialogView>("75e6f761-ec54-4863-ba08-0ad3ba0dc1fe","","",false, this);
 
            DuplicateMaterials = RPSControlFactory.CreateRPSCheckBox<ImportTaskDialogView>("7f1dc751-aec2-4bc1-91fd-9a0e3c72c319","","",false, this);
 
            MaterialAssignMaterialQuantityReal = RPSControlFactory.CreateRPSCheckBox<ImportTaskDialogView>("ce4f4a73-9d4d-4fb3-bcdc-663dbccab67b","","",false, this);
 
            TheoricCostMats = RPSControlFactory.CreateRPSEnumComboBox<ImportTaskDialogView>("8cb3c0b6-1ac0-4d01-a7d5-f460bcbd1b99","","",false, this);
 
            SalesCostMats = RPSControlFactory.CreateRPSEnumComboBox<ImportTaskDialogView>("792c0bd3-2c24-4723-8991-d857d4a6a0b3","","",false, this);
 
            BudgetMats = RPSControlFactory.CreateRPSEnumComboBox<ImportTaskDialogView>("36f22117-e5b1-474d-bfc3-7a706ee8f222","","",false, this);
 
            GroupBudgetMats = RPSControlFactory.CreateRPSEnumComboBox<ImportTaskDialogView>("6bc413e6-17cf-4525-b4c6-ab1063d81060","","",false, this);
 
            DuplicateComponentsCost = RPSControlFactory.CreateRPSCheckBox<ImportTaskDialogView>("d9401d0c-b0ac-40c9-8234-55ad44c38802","","",false, this);
 
            ComponentCostAssignCostQuantityReal = RPSControlFactory.CreateRPSCheckBox<ImportTaskDialogView>("2b295824-cfec-4c6e-89ad-021d9a19b6d9","","",false, this);
 
            TheoricCostCompCost = RPSControlFactory.CreateRPSEnumComboBox<ImportTaskDialogView>("983b6c8d-22a4-45dd-a009-24ef4071a2fd","","",false, this);
 
            SalesCostCompCost = RPSControlFactory.CreateRPSEnumComboBox<ImportTaskDialogView>("4e545df9-2f10-4345-b7f0-e55a219adca5","","",false, this);
 
            BudgetCompCost = RPSControlFactory.CreateRPSEnumComboBox<ImportTaskDialogView>("8cd35c1d-e83e-4b74-af53-6987239d89a1","","",false, this);
 
            GroupBudgetCompCost = RPSControlFactory.CreateRPSEnumComboBox<ImportTaskDialogView>("27bc3967-f8f3-47d1-add5-983329564350","","",false, this);
 

        }
        public IRPSComboBox<ImportTaskDialogView> IDProjectSource { get; set; } 
        public IRPSComboBox<ImportTaskDialogView> IDProjectTaskSource { get; set; } 
        public IRPSOption<ImportTaskDialogView> OptionForward { get; set; } 
        public IRPSOption<ImportTaskDialogView> OptionAdjustToEnd { get; set; } 
        public IRPSTextBox<ImportTaskDialogView> PlannedDate { get; set; } 
        public IRPSCheckbox<ImportTaskDialogView> DuplicateTest { get; set; } 
        public IRPSCheckbox<ImportTaskDialogView> DuplicateDocuments { get; set; } 
        public IRPSCheckbox<ImportTaskDialogView> DuplicateResources { get; set; } 
        public IRPSCheckbox<ImportTaskDialogView> ResourceAssignTimeReal { get; set; } 
        public IRPSComboBox<ImportTaskDialogView> TheoricCostRes { get; set; } 
        public IRPSComboBox<ImportTaskDialogView> SalesCostRes { get; set; } 
        public IRPSComboBox<ImportTaskDialogView> BudgetRes { get; set; } 
        public IRPSComboBox<ImportTaskDialogView> GroupBudgetRes { get; set; } 
        public IRPSCheckbox<ImportTaskDialogView> DuplicateMaterials { get; set; } 
        public IRPSCheckbox<ImportTaskDialogView> MaterialAssignMaterialQuantityReal { get; set; } 
        public IRPSComboBox<ImportTaskDialogView> TheoricCostMats { get; set; } 
        public IRPSComboBox<ImportTaskDialogView> SalesCostMats { get; set; } 
        public IRPSComboBox<ImportTaskDialogView> BudgetMats { get; set; } 
        public IRPSComboBox<ImportTaskDialogView> GroupBudgetMats { get; set; } 
        public IRPSCheckbox<ImportTaskDialogView> DuplicateComponentsCost { get; set; } 
        public IRPSCheckbox<ImportTaskDialogView> ComponentCostAssignCostQuantityReal { get; set; } 
        public IRPSComboBox<ImportTaskDialogView> TheoricCostCompCost { get; set; } 
        public IRPSComboBox<ImportTaskDialogView> SalesCostCompCost { get; set; } 
        public IRPSComboBox<ImportTaskDialogView> BudgetCompCost { get; set; } 
        public IRPSComboBox<ImportTaskDialogView> GroupBudgetCompCost { get; set; } 
        public Project Screen { get; set; }
        public ImportTaskDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class AssignEmployeesDialogView : View
    {
        public AssignEmployeesDialogView(Project screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_GetProjectQualifies = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="eab28749-89b2-4d64-aabd-580da1df58d1",CSSSelectorGrid="",XPathGrid=""};
            GetProjectQualifies = RPSControlFactory.RPSCreateCollectionWithGrid<GetProjectQualifiesCollectionEditor<AssignEmployeesDialogView>,AssignEmployeesDialogView>( params_GetProjectQualifies,this);
 

        }
        public GetProjectQualifiesCollectionEditor<AssignEmployeesDialogView> GetProjectQualifies { get; set; } 
        public Project Screen { get; set; }
        public AssignEmployeesDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetProjectQualifiesCollectionEditor<AssignEmployeesDialogView>:RPSCollectionEditor<AssignEmployeesDialogView> where AssignEmployeesDialogView : class, IView
    {
        public  GetProjectQualifiesGridView<AssignEmployeesDialogView> GridView {get;set;}
    }
    public partial class GetProjectQualifiesGridView <AssignEmployeesDialogView> :  RPSGridView<AssignEmployeesDialogView> where AssignEmployeesDialogView : class, IView
    {
        public GetProjectQualifiesGridView(AssignEmployeesDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            UI_IDQualify = RPSControlFactory.CreateRPSGridComboBox<AssignEmployeesDialogView>("","#eab28749-89b2-4d64-aabd-580da1df58d1 .ag-row[role='row']@ROWINDEX [col-id='cUI_IDQualify']","",false, this.CurrentView);
 
            UIEmployeeOriginType = RPSControlFactory.CreateRPSGridEnumComboBox<AssignEmployeesDialogView>("","#eab28749-89b2-4d64-aabd-580da1df58d1 .ag-row[role='row']@ROWINDEX [col-id='cUIEmployeeOriginType']","",false, this.CurrentView);
 
            UIIDEmployeeOrigin = RPSControlFactory.CreateRPSGridComboBox<AssignEmployeesDialogView>("","#eab28749-89b2-4d64-aabd-580da1df58d1 .ag-row[role='row']@ROWINDEX [col-id='cUIIDEmployeeOrigin']","",false, this.CurrentView);
 
            UITaskType = RPSControlFactory.CreateRPSGridEnumComboBox<AssignEmployeesDialogView>("","#eab28749-89b2-4d64-aabd-580da1df58d1 .ag-row[role='row']@ROWINDEX [col-id='cUITaskType']","",false, this.CurrentView);
 
            UIIDProjectTask = RPSControlFactory.CreateRPSGridComboBox<AssignEmployeesDialogView>("","#eab28749-89b2-4d64-aabd-580da1df58d1 .ag-row[role='row']@ROWINDEX [col-id='cUIIDProjectTask']","",false, this.CurrentView);
 
            UI_IDEmployee = RPSControlFactory.CreateRPSGridComboBox<AssignEmployeesDialogView>("","#eab28749-89b2-4d64-aabd-580da1df58d1 .ag-row[role='row']@ROWINDEX [col-id='cUI_IDEmployee']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<AssignEmployeesDialogView> UI_IDQualify { get; set; } 
        public IRPSGridComboBox<AssignEmployeesDialogView> UIEmployeeOriginType { get; set; } 
        public IRPSGridComboBox<AssignEmployeesDialogView> UIIDEmployeeOrigin { get; set; } 
        public IRPSGridComboBox<AssignEmployeesDialogView> UITaskType { get; set; } 
        public IRPSGridComboBox<AssignEmployeesDialogView> UIIDProjectTask { get; set; } 
        public IRPSGridComboBox<AssignEmployeesDialogView> UI_IDEmployee { get; set; } 
                     
    }
 
    }
  
            
    public partial class ProjectUserView : View
    {
        public ProjectUserView(Project screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ProjectUserView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ProjectUserView,ProjectEntityView>( this,Screen.ProjectEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ProjectUserView,ProjectEntityView>( this,Screen.ProjectEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ProjectUserView,ProjectEntityView>( this,Screen.ProjectEntityView);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<ProjectUserView>("20beb99d-4f57-43b6-a12e-f54cc98d1df5","","",false, this);
 
            Admin = RPSControlFactory.CreateRPSCheckBox<ProjectUserView>("57d20101-2075-41df-af4a-bf663b8f0d22","","",true, this);
 
            ProjectPermission = RPSControlFactory.CreateRPSEnumComboBox<ProjectUserView>("8dfb233d-4eb4-45b0-8e09-c9b9ec8c8b51","","",true, this);
 
            ImputationPermission = RPSControlFactory.CreateRPSEnumComboBox<ProjectUserView>("4393dfca-d639-464e-bf85-cd9fb9590edf","","",true, this);
 
            WarningPermission = RPSControlFactory.CreateRPSEnumComboBox<ProjectUserView>("7800d352-a0bf-43b2-aa96-6aabda8c802f","","",true, this);
 
            TestPermission = RPSControlFactory.CreateRPSEnumComboBox<ProjectUserView>("52d27b4c-8c9b-48eb-9d3e-579ea5dd06f8","","",true, this);
 
            CertificationPermission = RPSControlFactory.CreateRPSEnumComboBox<ProjectUserView>("d3bd125e-571d-4b98-9fcf-934efa5f3cad","","",true, this);
 

        }
        public IRPSButton<ProjectUserView> DeleteButton { get; set; } 
        public IRPSButton<ProjectUserView,ProjectEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ProjectUserView,ProjectEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ProjectUserView,ProjectEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ProjectUserView> CodUser { get; set; } 
        public IRPSCheckbox<ProjectUserView> Admin { get; set; } 
        public IRPSComboBox<ProjectUserView> ProjectPermission { get; set; } 
        public IRPSComboBox<ProjectUserView> ImputationPermission { get; set; } 
        public IRPSComboBox<ProjectUserView> WarningPermission { get; set; } 
        public IRPSComboBox<ProjectUserView> TestPermission { get; set; } 
        public IRPSComboBox<ProjectUserView> CertificationPermission { get; set; } 
        public Project Screen { get; set; }
        public ProjectUserView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CopyFromProjectSourceChildDialogView : View
    {
        public CopyFromProjectSourceChildDialogView(Project screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ProjectSource = RPSControlFactory.CreateRPSComboBox<CopyFromProjectSourceChildDialogView>("82b6ffd8-9e9c-4d1b-b66f-e76ab26f89eb","","",false, this);
 
            TargetCodProject = RPSControlFactory.CreateRPSTextBox<CopyFromProjectSourceChildDialogView>("1c21c3b3-4e7b-4fe0-bd71-d63568090a01","","",false, this);
 
            TargetVersion = RPSControlFactory.CreateRPSTextBox<CopyFromProjectSourceChildDialogView>("8b9d1513-b875-490c-8505-ba24bdd405df","","",false, this);
 
            DuplicateTest = RPSControlFactory.CreateRPSCheckBox<CopyFromProjectSourceChildDialogView>("4e6b7d99-35d2-42c7-a8d2-84344a36f131","","",false, this);
 
            DuplicateUsers = RPSControlFactory.CreateRPSCheckBox<CopyFromProjectSourceChildDialogView>("ee50c0ee-e354-4c68-a16f-2cbe25565849","","",false, this);
 
            DuplicateDocuments = RPSControlFactory.CreateRPSCheckBox<CopyFromProjectSourceChildDialogView>("283540a4-179a-4dc8-be39-99a1ed9a3a83","","",false, this);
 
            Site = RPSControlFactory.CreateRPSEnumComboBox<CopyFromProjectSourceChildDialogView>("f31b5727-acac-4410-a11d-6e028fbd012f","","",false, this);
 
            TargetIDsite = RPSControlFactory.CreateRPSComboBox<CopyFromProjectSourceChildDialogView>("118b0bc3-ce3d-41ae-9cef-efc307011431","","",false, this);
 
            AddDescriptionPosition = RPSControlFactory.CreateRPSEnumComboBox<CopyFromProjectSourceChildDialogView>("d5bade1b-8a1d-42b8-8e4f-1f555800ff89","","",false, this);
 
            AddDescription = RPSControlFactory.CreateRPSTextBox<CopyFromProjectSourceChildDialogView>("92cb4399-d06e-48c2-af8f-d0f0046854a1","","",false, this);
 
            SameTechnicalEmployee = RPSControlFactory.CreateRPSEnumComboBox<CopyFromProjectSourceChildDialogView>("552d43ea-5879-4855-a17f-fb8d9eff8953","","",false, this);
 
            IDEmployeeTechnical = RPSControlFactory.CreateRPSComboBox<CopyFromProjectSourceChildDialogView>("e458acd4-ecf6-4b83-9428-5c5cb89ccba2","","",false, this);
 
            optPlanningDirection = RPSControlFactory.CreateRPSEnumComboBox<CopyFromProjectSourceChildDialogView>("fa0aff67-c43c-42f2-98e1-8fd7a0dff045","","",false, this);
 
            PlannedDate = RPSControlFactory.CreateRPSTextBox<CopyFromProjectSourceChildDialogView>("425ed8df-039f-4803-bd9f-98030993ebc7","","",false, this);
 
            optCustomer = RPSControlFactory.CreateRPSEnumComboBox<CopyFromProjectSourceChildDialogView>("03a129dc-31c3-42ef-88f9-900b6f2845a0","","",false, this);
 
            IDNewCustomer = RPSControlFactory.CreateRPSComboBox<CopyFromProjectSourceChildDialogView>("9eabc2cb-8151-41cd-aef6-d45161c97ea0","","",false, this);
 
            IDNewPotentialCustomer = RPSControlFactory.CreateRPSComboBox<CopyFromProjectSourceChildDialogView>("e8fb7766-44bf-40f7-9eeb-127e3bc85bb4","","",false, this);
 
            DuplicateResources = RPSControlFactory.CreateRPSCheckBox<CopyFromProjectSourceChildDialogView>("50926511-305c-420c-8b86-6819623937b1","","",false, this);
 
            ResourceAssignTimeReal = RPSControlFactory.CreateRPSCheckBox<CopyFromProjectSourceChildDialogView>("2e07b4a1-0983-4c72-a90e-d6e50b27434a","","",false, this);
 
            TheoricCostRes = RPSControlFactory.CreateRPSEnumComboBox<CopyFromProjectSourceChildDialogView>("1ec37cca-eea0-437c-90ce-d15cf23f0142","","",false, this);
 
            SalesCostRes = RPSControlFactory.CreateRPSEnumComboBox<CopyFromProjectSourceChildDialogView>("74dcf138-344e-405c-9011-f6cbddc85894","","",false, this);
 
            BudgetRes = RPSControlFactory.CreateRPSEnumComboBox<CopyFromProjectSourceChildDialogView>("031706f5-4192-42df-ab1b-50b0d9c74c25","","",false, this);
 
            GroupBudgetRes = RPSControlFactory.CreateRPSEnumComboBox<CopyFromProjectSourceChildDialogView>("aad9c227-dcac-431f-b298-9694bda90c42","","",false, this);
 
            DuplicateMaterials = RPSControlFactory.CreateRPSCheckBox<CopyFromProjectSourceChildDialogView>("837e112e-40a6-48dc-8cad-f46263991918","","",false, this);
 
            MaterialAssignMaterialQuantityReal = RPSControlFactory.CreateRPSCheckBox<CopyFromProjectSourceChildDialogView>("6423a99c-670b-4c02-bced-cb3aac03c7df","","",false, this);
 
            TheoricCostMats = RPSControlFactory.CreateRPSEnumComboBox<CopyFromProjectSourceChildDialogView>("79d522be-65f5-4794-81c4-b910c8b3d80c","","",false, this);
 
            SalesCostMats = RPSControlFactory.CreateRPSEnumComboBox<CopyFromProjectSourceChildDialogView>("cf60bab8-73b7-47a4-9b26-cb6751bebdf9","","",false, this);
 
            BudgetMats = RPSControlFactory.CreateRPSEnumComboBox<CopyFromProjectSourceChildDialogView>("30920fba-9442-4123-82cf-fa903b57e58f","","",false, this);
 
            GroupBudgetMats = RPSControlFactory.CreateRPSEnumComboBox<CopyFromProjectSourceChildDialogView>("67e59979-0273-460f-8dd0-d80f4f536894","","",false, this);
 
            DuplicateComponentsCost = RPSControlFactory.CreateRPSCheckBox<CopyFromProjectSourceChildDialogView>("5c9a06a0-e7aa-4a67-983b-ee3ce29b4f97","","",false, this);
 
            ComponentCostAssignCostQuantityReal = RPSControlFactory.CreateRPSCheckBox<CopyFromProjectSourceChildDialogView>("924d863f-38e6-498b-9356-0111334e1170","","",false, this);
 
            TheoricCostCompCost = RPSControlFactory.CreateRPSEnumComboBox<CopyFromProjectSourceChildDialogView>("5d77d021-4bdf-43c5-aa28-ba86891159e7","","",false, this);
 
            SalesCostCompCost = RPSControlFactory.CreateRPSEnumComboBox<CopyFromProjectSourceChildDialogView>("cc8c6fbe-f64d-496c-b456-f68cd04e6328","","",false, this);
 
            BudgetCompCost = RPSControlFactory.CreateRPSEnumComboBox<CopyFromProjectSourceChildDialogView>("734ae6e1-d3ad-4b6e-898b-1e0df6807b84","","",false, this);
 
            GroupBudgetCompCost = RPSControlFactory.CreateRPSEnumComboBox<CopyFromProjectSourceChildDialogView>("0b2f3e3e-928a-4a2e-8d26-de8b11e219da","","",false, this);
 

        }
        public IRPSComboBox<CopyFromProjectSourceChildDialogView> ProjectSource { get; set; } 
        public IRPSTextBox<CopyFromProjectSourceChildDialogView> TargetCodProject { get; set; } 
        public IRPSTextBox<CopyFromProjectSourceChildDialogView> TargetVersion { get; set; } 
        public IRPSCheckbox<CopyFromProjectSourceChildDialogView> DuplicateTest { get; set; } 
        public IRPSCheckbox<CopyFromProjectSourceChildDialogView> DuplicateUsers { get; set; } 
        public IRPSCheckbox<CopyFromProjectSourceChildDialogView> DuplicateDocuments { get; set; } 
        public IRPSComboBox<CopyFromProjectSourceChildDialogView> Site { get; set; } 
        public IRPSComboBox<CopyFromProjectSourceChildDialogView> TargetIDsite { get; set; } 
        public IRPSComboBox<CopyFromProjectSourceChildDialogView> AddDescriptionPosition { get; set; } 
        public IRPSTextBox<CopyFromProjectSourceChildDialogView> AddDescription { get; set; } 
        public IRPSComboBox<CopyFromProjectSourceChildDialogView> SameTechnicalEmployee { get; set; } 
        public IRPSComboBox<CopyFromProjectSourceChildDialogView> IDEmployeeTechnical { get; set; } 
        public IRPSComboBox<CopyFromProjectSourceChildDialogView> optPlanningDirection { get; set; } 
        public IRPSTextBox<CopyFromProjectSourceChildDialogView> PlannedDate { get; set; } 
        public IRPSComboBox<CopyFromProjectSourceChildDialogView> optCustomer { get; set; } 
        public IRPSComboBox<CopyFromProjectSourceChildDialogView> IDNewCustomer { get; set; } 
        public IRPSComboBox<CopyFromProjectSourceChildDialogView> IDNewPotentialCustomer { get; set; } 
        public IRPSCheckbox<CopyFromProjectSourceChildDialogView> DuplicateResources { get; set; } 
        public IRPSCheckbox<CopyFromProjectSourceChildDialogView> ResourceAssignTimeReal { get; set; } 
        public IRPSComboBox<CopyFromProjectSourceChildDialogView> TheoricCostRes { get; set; } 
        public IRPSComboBox<CopyFromProjectSourceChildDialogView> SalesCostRes { get; set; } 
        public IRPSComboBox<CopyFromProjectSourceChildDialogView> BudgetRes { get; set; } 
        public IRPSComboBox<CopyFromProjectSourceChildDialogView> GroupBudgetRes { get; set; } 
        public IRPSCheckbox<CopyFromProjectSourceChildDialogView> DuplicateMaterials { get; set; } 
        public IRPSCheckbox<CopyFromProjectSourceChildDialogView> MaterialAssignMaterialQuantityReal { get; set; } 
        public IRPSComboBox<CopyFromProjectSourceChildDialogView> TheoricCostMats { get; set; } 
        public IRPSComboBox<CopyFromProjectSourceChildDialogView> SalesCostMats { get; set; } 
        public IRPSComboBox<CopyFromProjectSourceChildDialogView> BudgetMats { get; set; } 
        public IRPSComboBox<CopyFromProjectSourceChildDialogView> GroupBudgetMats { get; set; } 
        public IRPSCheckbox<CopyFromProjectSourceChildDialogView> DuplicateComponentsCost { get; set; } 
        public IRPSCheckbox<CopyFromProjectSourceChildDialogView> ComponentCostAssignCostQuantityReal { get; set; } 
        public IRPSComboBox<CopyFromProjectSourceChildDialogView> TheoricCostCompCost { get; set; } 
        public IRPSComboBox<CopyFromProjectSourceChildDialogView> SalesCostCompCost { get; set; } 
        public IRPSComboBox<CopyFromProjectSourceChildDialogView> BudgetCompCost { get; set; } 
        public IRPSComboBox<CopyFromProjectSourceChildDialogView> GroupBudgetCompCost { get; set; } 
        public Project Screen { get; set; }
        public CopyFromProjectSourceChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ProjectChangeSitutationChildDialogView : View
    {
        public ProjectChangeSitutationChildDialogView(Project screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SituationDescription = RPSControlFactory.CreateRPSTextBox<ProjectChangeSitutationChildDialogView>("f08773b4-9a32-47a5-9db5-f8ef86ff49a5","","",false, this);
 
            NewSituation = RPSControlFactory.CreateRPSComboBox<ProjectChangeSitutationChildDialogView>("187e9563-227f-4cd0-a3d5-894e39373d18","","",false, this);
 
            ChangeProjectLinked = RPSControlFactory.CreateRPSCheckBox<ProjectChangeSitutationChildDialogView>("651092c9-a17f-4f97-b876-50d663e70a67","","",false, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<ProjectChangeSitutationChildDialogView>("187b839b-a9b6-4185-b00c-165e235e5f72","","",false, this);
 
            CloseOpenTasks = RPSControlFactory.CreateRPSCheckBox<ProjectChangeSitutationChildDialogView>("7a9e9183-c7a2-4bdb-9a77-4e20d629281e","","",false, this);
 

        }
        public IRPSTextBox<ProjectChangeSitutationChildDialogView> SituationDescription { get; set; } 
        public IRPSComboBox<ProjectChangeSitutationChildDialogView> NewSituation { get; set; } 
        public IRPSCheckbox<ProjectChangeSitutationChildDialogView> ChangeProjectLinked { get; set; } 
        public IRPSTextBox<ProjectChangeSitutationChildDialogView> Date { get; set; } 
        public IRPSCheckbox<ProjectChangeSitutationChildDialogView> CloseOpenTasks { get; set; } 
        public Project Screen { get; set; }
        public ProjectChangeSitutationChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class GenerateSupplysDialogView : View
    {
        public GenerateSupplysDialogView(Project screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Purchase = RPSControlFactory.CreateRPSOption<GenerateSupplysDialogView>( "afcdbe80-704f-4169-96ee-83b3bbb84907","","",this);
 
            Manufacturing = RPSControlFactory.CreateRPSOption<GenerateSupplysDialogView>( "3126a59e-a014-4e20-985d-d8b4b56c58c3","","",this);
 
            Order = RPSControlFactory.CreateRPSOption<GenerateSupplysDialogView>( "43e0aad4-07ac-4d6a-9c14-dfe87c515c54","","",this);
 
            Proposal = RPSControlFactory.CreateRPSOption<GenerateSupplysDialogView>( "8f675840-f8c2-4113-9a47-e32e34c0f683","","",this);
 

        }
        public IRPSOption<GenerateSupplysDialogView> Purchase { get; set; } 
        public IRPSOption<GenerateSupplysDialogView> Manufacturing { get; set; } 
        public IRPSOption<GenerateSupplysDialogView> Order { get; set; } 
        public IRPSOption<GenerateSupplysDialogView> Proposal { get; set; } 
        public Project Screen { get; set; }
        public GenerateSupplysDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class GenerateSupplysForTaskDialogView : View
    {
        public GenerateSupplysForTaskDialogView(Project screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Purchase = RPSControlFactory.CreateRPSOption<GenerateSupplysForTaskDialogView>( "0a1b4c86-2974-4691-a89a-10946b298cb5","","",this);
 
            Manufacturing = RPSControlFactory.CreateRPSOption<GenerateSupplysForTaskDialogView>( "a18034f4-d935-40ed-b48e-99e1d2f8c750","","",this);
 
            Order = RPSControlFactory.CreateRPSOption<GenerateSupplysForTaskDialogView>( "cc58b2c9-0e4c-4ef2-9969-87257b631c34","","",this);
 
            Proposal = RPSControlFactory.CreateRPSOption<GenerateSupplysForTaskDialogView>( "bc0f3f02-2f8d-44e2-9e45-85fcfe5c123d","","",this);
 

        }
        public IRPSOption<GenerateSupplysForTaskDialogView> Purchase { get; set; } 
        public IRPSOption<GenerateSupplysForTaskDialogView> Manufacturing { get; set; } 
        public IRPSOption<GenerateSupplysForTaskDialogView> Order { get; set; } 
        public IRPSOption<GenerateSupplysForTaskDialogView> Proposal { get; set; } 
        public Project Screen { get; set; }
        public GenerateSupplysForTaskDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SupplysUpdateOptionsScreenDialogView : View
    {
        public SupplysUpdateOptionsScreenDialogView(Project screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Order = RPSControlFactory.CreateRPSOption<SupplysUpdateOptionsScreenDialogView>( "20f8ab55-2355-4076-ab38-70f652c0107a","","",this);
 
            Proposal = RPSControlFactory.CreateRPSOption<SupplysUpdateOptionsScreenDialogView>( "4eb30730-f698-4cd1-a744-1fb28112ed41","","",this);
 

        }
        public IRPSOption<SupplysUpdateOptionsScreenDialogView> Order { get; set; } 
        public IRPSOption<SupplysUpdateOptionsScreenDialogView> Proposal { get; set; } 
        public Project Screen { get; set; }
        public SupplysUpdateOptionsScreenDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DetailsFromProjectIndicatorValueDialogView : View
    {
        public DetailsFromProjectIndicatorValueDialogView(Project screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_DetailValuesForProjectIndicator = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8d7c5e7f-f079-4e51-9ecd-ba9735536fa7",CSSSelectorGrid="",XPathGrid=""};
            DetailValuesForProjectIndicator = RPSControlFactory.RPSCreateCollectionWithGrid<DetailValuesForProjectIndicatorCollectionEditor<DetailsFromProjectIndicatorValueDialogView>,DetailsFromProjectIndicatorValueDialogView>( params_DetailValuesForProjectIndicator,this);
 

        }
        public DetailValuesForProjectIndicatorCollectionEditor<DetailsFromProjectIndicatorValueDialogView> DetailValuesForProjectIndicator { get; set; } 
        public Project Screen { get; set; }
        public DetailsFromProjectIndicatorValueDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DetailValuesForProjectIndicatorCollectionEditor<DetailsFromProjectIndicatorValueDialogView>:RPSCollectionEditor<DetailsFromProjectIndicatorValueDialogView> where DetailsFromProjectIndicatorValueDialogView : class, IView
    {
        public  DetailValuesForProjectIndicatorGridView<DetailsFromProjectIndicatorValueDialogView> GridView {get;set;}
    }
    public partial class DetailValuesForProjectIndicatorGridView <DetailsFromProjectIndicatorValueDialogView> :  RPSGridView<DetailsFromProjectIndicatorValueDialogView> where DetailsFromProjectIndicatorValueDialogView : class, IView
    {
        public DetailValuesForProjectIndicatorGridView(DetailsFromProjectIndicatorValueDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ProjectIndicatorValueDetail_Value = RPSControlFactory.CreateRPSGridTextBox<DetailsFromProjectIndicatorValueDialogView>("","#8d7c5e7f-f079-4e51-9ecd-ba9735536fa7 .ag-row[role='row']@ROWINDEX [col-id='cProjectIndicatorValueDetail_Value']","",false, this.CurrentView);
 
            ValueDecimal = RPSControlFactory.CreateRPSGridFormattedTextBox<DetailsFromProjectIndicatorValueDialogView>("","#8d7c5e7f-f079-4e51-9ecd-ba9735536fa7 .ag-row[role='row']@ROWINDEX [col-id='cValueDecimal']","",false, this.CurrentView);
 
            ValueInteger = RPSControlFactory.CreateRPSGridFormattedTextBox<DetailsFromProjectIndicatorValueDialogView>("","#8d7c5e7f-f079-4e51-9ecd-ba9735536fa7 .ag-row[role='row']@ROWINDEX [col-id='cValueInteger']","",false, this.CurrentView);
 
            ValueDateTime = RPSControlFactory.CreateRPSGridTextBox<DetailsFromProjectIndicatorValueDialogView>("","#8d7c5e7f-f079-4e51-9ecd-ba9735536fa7 .ag-row[role='row']@ROWINDEX [col-id='cValueDateTime']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<DetailsFromProjectIndicatorValueDialogView> ProjectIndicatorValueDetail_Value { get; set; } 
        public IRPSGridTextBox<DetailsFromProjectIndicatorValueDialogView> ValueDecimal { get; set; } 
        public IRPSGridTextBox<DetailsFromProjectIndicatorValueDialogView> ValueInteger { get; set; } 
        public IRPSGridTextBox<DetailsFromProjectIndicatorValueDialogView> ValueDateTime { get; set; } 
                     
    }
 
    }
  
            
    public partial class ReportOptionsDialogView : View
    {
        public ReportOptionsDialogView(Project screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Standar = RPSControlFactory.CreateRPSOption<ReportOptionsDialogView>( "695aaf14-5251-47b2-a349-2a72f218fe75","","",this);
 
            Custom = RPSControlFactory.CreateRPSOption<ReportOptionsDialogView>( "58775bbc-2fc5-4aa0-aa84-dc953605afa1","","",this);
 
            CustomReport = RPSControlFactory.CreateRPSComboBox<ReportOptionsDialogView>("51686cc8-6c66-4cee-9dbc-acda18e3ff55","","",false, this);
 

        }
        public IRPSOption<ReportOptionsDialogView> Standar { get; set; } 
        public IRPSOption<ReportOptionsDialogView> Custom { get; set; } 
        public IRPSComboBox<ReportOptionsDialogView> CustomReport { get; set; } 
        public Project Screen { get; set; }
        public ReportOptionsDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ProjectTaskCategoryView : View
    {
        public ProjectTaskCategoryView(Project screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ProjectTaskCategoryView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ProjectTaskCategoryView,ProjectTaskView>( this,Screen.ProjectTaskView);
 
            BackButton = RPSControlFactory.RPSBackButton<ProjectTaskCategoryView,ProjectTaskView>( this,Screen.ProjectTaskView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ProjectTaskCategoryView,ProjectTaskView>( this,Screen.ProjectTaskView);
 
            IDBudgetCategory = RPSControlFactory.CreateRPSComboBox<ProjectTaskCategoryView>("de16f62b-4f14-4784-8939-f641768140a4","","",true, this);
 
            BudgetAmount = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskCategoryView>("53ccb7b5-af6d-4d49-b859-12fe533b2258","","",true, this);
 

        }
        public IRPSButton<ProjectTaskCategoryView> DeleteButton { get; set; } 
        public IRPSButton<ProjectTaskCategoryView,ProjectTaskView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ProjectTaskCategoryView,ProjectTaskView> BackButton { get; set; } 
        public IRPSAcceptButton<ProjectTaskCategoryView,ProjectTaskView> AcceptButton { get; set; } 
        public IRPSComboBox<ProjectTaskCategoryView> IDBudgetCategory { get; set; } 
        public IRPSTextBox<ProjectTaskCategoryView> BudgetAmount { get; set; } 
        public Project Screen { get; set; }
        public ProjectTaskCategoryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ProjectMaterialChangeStatusDialogView : View
    {
        public ProjectMaterialChangeStatusDialogView(Project screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIStatus = RPSControlFactory.CreateRPSEnumComboBox<ProjectMaterialChangeStatusDialogView>("0bdcfff0-5648-47a0-beb9-5bdd7ab222f2","","",false, this);
 
            UIComment = RPSControlFactory.CreateRPSTextBox<ProjectMaterialChangeStatusDialogView>("d2250689-5013-46a4-b6bd-8de45ea9dd85","","",false, this);
 

        }
        public IRPSComboBox<ProjectMaterialChangeStatusDialogView> UIStatus { get; set; } 
        public IRPSTextBox<ProjectMaterialChangeStatusDialogView> UIComment { get; set; } 
        public Project Screen { get; set; }
        public ProjectMaterialChangeStatusDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ProjectPlanningDateDialogView : View
    {
        public ProjectPlanningDateDialogView(Project screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            PlaningDate = RPSControlFactory.CreateRPSTextBox<ProjectPlanningDateDialogView>("24e0d68d-f778-4050-83be-a2af06e20972","","",true, this);
 

        }
        public IRPSTextBox<ProjectPlanningDateDialogView> PlaningDate { get; set; } 
        public Project Screen { get; set; }
        public ProjectPlanningDateDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ProjectTaskLinkedDialogView : View
    {
        public ProjectTaskLinkedDialogView(Project screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIIDProject = RPSControlFactory.CreateRPSComboBox<ProjectTaskLinkedDialogView>("f8f7f7aa-eb9d-4de7-ac0d-0de5bf9ea804","","",false, this);
 
            UIPlannedStartDate = RPSControlFactory.CreateRPSTextBox<ProjectTaskLinkedDialogView>("5bd3be6c-e75e-4930-baae-122708e2786e","","",false, this);
 
            UIPlannedEndDate = RPSControlFactory.CreateRPSTextBox<ProjectTaskLinkedDialogView>("c997bf82-e3c1-4465-8261-80f91cc67334","","",false, this);
 
            UIIDEmployeeTechnical = RPSControlFactory.CreateRPSComboBox<ProjectTaskLinkedDialogView>("8050c739-8331-4fd6-919a-a47e1f5730ea","","",false, this);
 
            UIEstimatedTime = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskLinkedDialogView>("3ff6a07a-606b-4872-9f40-6953ab063b27","","",false, this);
 
            UIRealTime = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskLinkedDialogView>("7ef126f5-fdbd-4e0b-a7a6-c988e3f39b77","","",false, this);
 
            UIPendingTime = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskLinkedDialogView>("8384de83-2c63-4e92-a768-479d951ac3e7","","",false, this);
 
            UIPercentProgress = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskLinkedDialogView>("7ec26170-93cd-4e90-911a-4b174738ef53","","",false, this);
 
            UIAmountCostTheoric = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskLinkedDialogView>("9193e4c0-d15e-4ef0-9d3d-945a302ca98e","","",false, this);
 
            UIAmountCostReal = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskLinkedDialogView>("2ba08686-7cd5-4595-a064-b4dea3fd78c6","","",false, this);
 
            UIAmountSaleTheoric = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskLinkedDialogView>("207ebba4-64dc-416a-aeba-a7d1d5914628","","",false, this);
 

        }
        public IRPSComboBox<ProjectTaskLinkedDialogView> UIIDProject { get; set; } 
        public IRPSTextBox<ProjectTaskLinkedDialogView> UIPlannedStartDate { get; set; } 
        public IRPSTextBox<ProjectTaskLinkedDialogView> UIPlannedEndDate { get; set; } 
        public IRPSComboBox<ProjectTaskLinkedDialogView> UIIDEmployeeTechnical { get; set; } 
        public IRPSTextBox<ProjectTaskLinkedDialogView> UIEstimatedTime { get; set; } 
        public IRPSTextBox<ProjectTaskLinkedDialogView> UIRealTime { get; set; } 
        public IRPSTextBox<ProjectTaskLinkedDialogView> UIPendingTime { get; set; } 
        public IRPSTextBox<ProjectTaskLinkedDialogView> UIPercentProgress { get; set; } 
        public IRPSTextBox<ProjectTaskLinkedDialogView> UIAmountCostTheoric { get; set; } 
        public IRPSTextBox<ProjectTaskLinkedDialogView> UIAmountCostReal { get; set; } 
        public IRPSTextBox<ProjectTaskLinkedDialogView> UIAmountSaleTheoric { get; set; } 
        public Project Screen { get; set; }
        public ProjectTaskLinkedDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CuDistSplitOfTaskPopUpDialogView : View
    {
        public CuDistSplitOfTaskPopUpDialogView(Project screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Description = RPSControlFactory.CreateRPSTextBox<CuDistSplitOfTaskPopUpDialogView>("23605fce-2046-4e20-b7d4-5e60ce949eb5","","",false, this);
 
            PreparationTime = RPSControlFactory.CreateRPSDurationTextBox<CuDistSplitOfTaskPopUpDialogView>("92d35c63-12c6-4bcd-b638-a8248231e80d","","",false, this);
 
            ExecutionTime = RPSControlFactory.CreateRPSDurationTextBox<CuDistSplitOfTaskPopUpDialogView>("4f53020b-21bd-48b1-b5fb-0a9b9de0322a","","",false, this);
 
            NewDescription = RPSControlFactory.CreateRPSTextBox<CuDistSplitOfTaskPopUpDialogView>("f2cd80f0-f413-46e7-b110-bd3bdeb3d00f","","",false, this);
 
            NewPreparationTime = RPSControlFactory.CreateRPSFormattedTextBox<CuDistSplitOfTaskPopUpDialogView>("10db0aeb-34b4-4e13-bfcc-7405dfe4bff1","","",false, this);
 
            NewExecutionTime = RPSControlFactory.CreateRPSFormattedTextBox<CuDistSplitOfTaskPopUpDialogView>("ce24f991-65ec-4471-9e6d-fbaedc9b628c","","",false, this);
 
            TaskType = RPSControlFactory.CreateRPSComboBox<CuDistSplitOfTaskPopUpDialogView>("3a4f7e46-9c50-4c92-ac13-ea6a19330279","","",false, this);
 

        }
        public IRPSTextBox<CuDistSplitOfTaskPopUpDialogView> Description { get; set; } 
        public IRPSDurationTextBox<CuDistSplitOfTaskPopUpDialogView> PreparationTime { get; set; } 
        public IRPSDurationTextBox<CuDistSplitOfTaskPopUpDialogView> ExecutionTime { get; set; } 
        public IRPSTextBox<CuDistSplitOfTaskPopUpDialogView> NewDescription { get; set; } 
        public IRPSTextBox<CuDistSplitOfTaskPopUpDialogView> NewPreparationTime { get; set; } 
        public IRPSTextBox<CuDistSplitOfTaskPopUpDialogView> NewExecutionTime { get; set; } 
        public IRPSComboBox<CuDistSplitOfTaskPopUpDialogView> TaskType { get; set; } 
        public Project Screen { get; set; }
        public CuDistSplitOfTaskPopUpDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}