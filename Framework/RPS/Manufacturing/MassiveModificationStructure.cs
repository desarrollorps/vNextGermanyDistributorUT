    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.MassiveModificationStructure
{
    //RPS VERSION 1.0.0.0
    public partial class MassiveModificationStructure:Screen
    {
        public MassiveModificationStructure():base()
        {
            this.URL = "manufacturing.massivemodificationstructure";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MassiveModificationStructureView  = new MassiveModificationStructureView(this); 
            MaterialMassiveDialogView  = new MaterialMassiveDialogView(this); 
            EmployeeMassiveDialogView  = new EmployeeMassiveDialogView(this); 
            MachineMassiveDialogView  = new MachineMassiveDialogView(this); 
            ToolMassiveDialogView  = new ToolMassiveDialogView(this); 
            QualifyMassiveDialogView  = new QualifyMassiveDialogView(this); 
            MachineGroupMassiveDialogView  = new MachineGroupMassiveDialogView(this); 
            MassiveModificationStructureView.InitializeControls(); 
            MaterialMassiveDialogView.InitializeControls(); 
            EmployeeMassiveDialogView.InitializeControls(); 
            MachineMassiveDialogView.InitializeControls(); 
            ToolMassiveDialogView.InitializeControls(); 
            QualifyMassiveDialogView.InitializeControls(); 
            MachineGroupMassiveDialogView.InitializeControls(); 
           
        }
      
            public MassiveModificationStructureView MassiveModificationStructureView {get; set; } 
            public MaterialMassiveDialogView MaterialMassiveDialogView {get; set; } 
            public EmployeeMassiveDialogView EmployeeMassiveDialogView {get; set; } 
            public MachineMassiveDialogView MachineMassiveDialogView {get; set; } 
            public ToolMassiveDialogView ToolMassiveDialogView {get; set; } 
            public QualifyMassiveDialogView QualifyMassiveDialogView {get; set; } 
            public MachineGroupMassiveDialogView MachineGroupMassiveDialogView {get; set; } 
    }
            
    public partial class MassiveModificationStructureView : View
    {
        public MassiveModificationStructureView(MassiveModificationStructure screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<MassiveModificationStructureView>("d364df6e-a585-48ae-a1ed-56f3f20d3b6d","","",true, this);
 
            ListArticle = RPSControlFactory.CreateRPSCollectionComboBox<MassiveModificationStructureView>("0ef936f7-7075-4d00-99ad-97dd04ad3ee8","","",false, this);
 
            ListUsualTaskSTR = RPSControlFactory.CreateRPSCollectionComboBox<MassiveModificationStructureView>("ce8ae426-9ed1-472c-8bd1-381efc08a419","","",false, this);
 
            NoActive = RPSControlFactory.CreateRPSOption<MassiveModificationStructureView>( "bb61aa58-00e3-421d-a3de-6849663b18e6","","",this);
 
            LatestVersion = RPSControlFactory.CreateRPSOption<MassiveModificationStructureView>( "965b66de-fc29-4900-8baf-c3a856dd7707","","",this);
 
            ActiveOnly = RPSControlFactory.CreateRPSOption<MassiveModificationStructureView>( "9cbda53b-37d4-4d49-86eb-ed10311f5f8c","","",this);
 
            ActiveOnlyDate = RPSControlFactory.CreateRPSTextBox<MassiveModificationStructureView>("0ba148b7-432f-4d8a-aa0c-36b1d5cc7b13","","",false, this);
 
            ListArticleMaterial = RPSControlFactory.CreateRPSCollectionComboBox<MassiveModificationStructureView>("8f406365-5f2f-40d4-84d3-bda04385dc23","","",false, this);
 
            DestinationArticle = RPSControlFactory.CreateRPSComboBox<MassiveModificationStructureView>("892f1b57-301f-4c9b-b7c3-664796003491","","",false, this);
 
            CheckQuantityMaterial = RPSControlFactory.CreateRPSCheckBox<MassiveModificationStructureView>("c8e97def-7f7c-46d4-912b-4f380b43fa27","","",false, this);
 
            Fixed = RPSControlFactory.CreateRPSOption<MassiveModificationStructureView>( "1a80c685-f988-41ea-bb81-0ddfdda9b387","","",this);
 
            Percentage = RPSControlFactory.CreateRPSOption<MassiveModificationStructureView>( "e0cfc568-136b-4dba-b800-b6f53f148c48","","",this);
 
            MaterialQuantity = RPSControlFactory.CreateRPSFormattedTextBox<MassiveModificationStructureView>("956d5f11-486e-4849-8ea6-3f29b6edf9e5","","",false, this);
 
            MaterialMassiveNavigationCommand = RPSControlFactory.CreateRPSButtonToView<MassiveModificationStructureView,MaterialMassiveDialogView>("e3be7b64-9391-40cf-8372-356ddf8b7eeb","","", this,Screen.MaterialMassiveDialogView);
 
            ListEmployee = RPSControlFactory.CreateRPSCollectionComboBox<MassiveModificationStructureView>("742d6c94-1beb-457f-bfb6-32ff142cbb65","","",false, this);
 
            DestinationEmployee = RPSControlFactory.CreateRPSComboBox<MassiveModificationStructureView>("e16c1a39-f998-4701-aac1-1032fd00368e","","",false, this);
 
            CheckExecutionTimeEmployee = RPSControlFactory.CreateRPSCheckBox<MassiveModificationStructureView>("54590e8f-49aa-4adf-b2fc-6a128b3384ad","","",false, this);
 
            Fixed1 = RPSControlFactory.CreateRPSOption<MassiveModificationStructureView>( "1f2fbee0-da3c-40d3-8bb1-a71a63fb42a7","","",this);
 
            Percentage1 = RPSControlFactory.CreateRPSOption<MassiveModificationStructureView>( "294df248-abfc-4be3-8389-d654b0ff6a62","","",this);
 
            EmployeeQuantityPercentage = RPSControlFactory.CreateRPSFormattedTextBox<MassiveModificationStructureView>("cd7aa4e2-7e86-44bf-9d31-249f47abeb83","","",false, this);
 
            EmployeeUnitQuantity = RPSControlFactory.CreateRPSDurationTextBox<MassiveModificationStructureView>("9460fe20-f0e8-4b81-afc7-2f295ca6edcd","","",false, this);
 
            EmployeeMassiveNavigationCommand = RPSControlFactory.CreateRPSButtonToView<MassiveModificationStructureView,EmployeeMassiveDialogView>("49afb73b-ff22-4052-a45b-de3484c31736","","", this,Screen.EmployeeMassiveDialogView);
 
            ListQualify = RPSControlFactory.CreateRPSCollectionComboBox<MassiveModificationStructureView>("39a06014-6fa3-48ea-b1bc-a6537e15a9df","","",false, this);
 
            DestinationQualify = RPSControlFactory.CreateRPSComboBox<MassiveModificationStructureView>("3decd32a-9ce1-4b01-a0bd-0e266a055b03","","",false, this);
 
            CheckExecutionTimeQualify = RPSControlFactory.CreateRPSCheckBox<MassiveModificationStructureView>("a8cabce0-824f-4409-b164-d3d4d43c86b0","","",false, this);
 
            Fixed2 = RPSControlFactory.CreateRPSOption<MassiveModificationStructureView>( "de4ce6f8-85f4-444b-a60e-bf3a7183f5a6","","",this);
 
            Percentage2 = RPSControlFactory.CreateRPSOption<MassiveModificationStructureView>( "eb6fbce9-70fd-4ee0-9349-cb3c3d306f5f","","",this);
 
            QualifyQuantityPercentage = RPSControlFactory.CreateRPSFormattedTextBox<MassiveModificationStructureView>("94405091-6a32-4967-937a-2b68dfb81434","","",false, this);
 
            QualifyUnitQuantity = RPSControlFactory.CreateRPSDurationTextBox<MassiveModificationStructureView>("8805bb23-dced-420d-b1a7-163658b16679","","",false, this);
 
            QualifyMassiveNavigationCommand = RPSControlFactory.CreateRPSButton<MassiveModificationStructureView>( "b8a7ce04-e20b-4674-917c-f66e97bd003d","","",this);
 
            ListMachine = RPSControlFactory.CreateRPSCollectionComboBox<MassiveModificationStructureView>("94e1324d-1552-4179-9943-430d4b2f729c","","",false, this);
 
            DestinationMachine = RPSControlFactory.CreateRPSComboBox<MassiveModificationStructureView>("622fd896-d7ff-4eb0-82f0-6584df3ce7bb","","",false, this);
 
            CheckExecutionTimeMachine = RPSControlFactory.CreateRPSCheckBox<MassiveModificationStructureView>("ecec71e0-a423-4631-adde-2e9385621af0","","",false, this);
 
            Fixed3 = RPSControlFactory.CreateRPSOption<MassiveModificationStructureView>( "db28545e-ffe5-4c76-a4d1-9ba9904ac909","","",this);
 
            Percentage3 = RPSControlFactory.CreateRPSOption<MassiveModificationStructureView>( "ac0bce2b-eed7-44e3-b077-a8cad180755c","","",this);
 
            MachineQuantity = RPSControlFactory.CreateRPSFormattedTextBox<MassiveModificationStructureView>("85f8edb7-d1bb-4976-a3c0-77c82d09aa69","","",false, this);
 
            MachineUnitQuantity = RPSControlFactory.CreateRPSDurationTextBox<MassiveModificationStructureView>("88978a62-5a69-49cd-9075-803938890db7","","",false, this);
 
            MachineMassiveNavigationCommand = RPSControlFactory.CreateRPSButtonToView<MassiveModificationStructureView,MachineMassiveDialogView>("e417f90d-e543-4376-9f69-459951ef49d3","","", this,Screen.MachineMassiveDialogView);
 
            ListMachineGroup = RPSControlFactory.CreateRPSCollectionComboBox<MassiveModificationStructureView>("8fbda966-54f7-4d31-bb76-ae347b9b30a5","","",false, this);
 
            DestinationMachineGroup = RPSControlFactory.CreateRPSComboBox<MassiveModificationStructureView>("047db950-b509-430f-aaff-64a504a60304","","",false, this);
 
            CheckExecutionTimeMachineGroup = RPSControlFactory.CreateRPSCheckBox<MassiveModificationStructureView>("4efe8bbd-3a6b-4567-9be8-f0010fcacc97","","",false, this);
 
            Fixed4 = RPSControlFactory.CreateRPSOption<MassiveModificationStructureView>( "8a95550b-324d-43b7-92aa-2e189e207ae1","","",this);
 
            Percentage4 = RPSControlFactory.CreateRPSOption<MassiveModificationStructureView>( "6678c3f2-18b4-49be-80c3-4f9b2c8e31f0","","",this);
 
            MachineGroupQuantityPercentage = RPSControlFactory.CreateRPSFormattedTextBox<MassiveModificationStructureView>("88035fa3-f34d-4ee5-83eb-61d133c8f139","","",false, this);
 
            MachineGroupUnitQuantity = RPSControlFactory.CreateRPSDurationTextBox<MassiveModificationStructureView>("5ace8f9a-91e5-4893-bc8c-06cbf1c0bcab","","",false, this);
 
            MachineGroupMassiveNavigationCommand = RPSControlFactory.CreateRPSButton<MassiveModificationStructureView>( "13c7dc62-4778-4356-9263-34ee42167922","","",this);
 
            ListTool = RPSControlFactory.CreateRPSCollectionComboBox<MassiveModificationStructureView>("44a639e6-2ad6-4a38-82d6-3225db0fd2b3","","",false, this);
 
            DestinationTool = RPSControlFactory.CreateRPSComboBox<MassiveModificationStructureView>("86383362-69ea-4d29-ab78-9ef864cb6d9d","","",false, this);
 
            CheckExecutionTimeTool = RPSControlFactory.CreateRPSCheckBox<MassiveModificationStructureView>("e0ccf3d6-c951-459c-9a5e-0057d95dceae","","",false, this);
 
            Fixed5 = RPSControlFactory.CreateRPSOption<MassiveModificationStructureView>( "93acd5a2-5c78-452e-9ad4-aac06a1091bb","","",this);
 
            Percentage5 = RPSControlFactory.CreateRPSOption<MassiveModificationStructureView>( "875aa3e0-4db1-44d7-bbfc-1aadf725e823","","",this);
 
            ToolQuantity = RPSControlFactory.CreateRPSFormattedTextBox<MassiveModificationStructureView>("2babb216-feb0-42b1-b649-8e252926391d","","",false, this);
 
            ToolUnitQuantity = RPSControlFactory.CreateRPSDurationTextBox<MassiveModificationStructureView>("e335827b-5273-490e-87c4-10d1bbbe9d68","","",false, this);
 
            ToolMassiveNavigationCommand = RPSControlFactory.CreateRPSButtonToView<MassiveModificationStructureView,ToolMassiveDialogView>("dd6358ac-82b2-4744-bd70-c23f29f6f267","","", this,Screen.ToolMassiveDialogView);
 
            SectionMaterial = RPSControlFactory.CreateRPSSection<MassiveModificationStructureView>( "","ul li[rpsid='abc418f5-6345-45ed-a485-b6d4b7cc0a5e']","",this);
 
            SectionEmployee = RPSControlFactory.CreateRPSSection<MassiveModificationStructureView>( "","ul li[rpsid='bdcab740-4dde-446c-abe8-c5c8faae6b82']","",this);
 
            SectionQualify = RPSControlFactory.CreateRPSSection<MassiveModificationStructureView>( "","ul li[rpsid='b08457f6-ede5-4846-bae8-5eb3da78baad']","",this);
 
            SectionMachine = RPSControlFactory.CreateRPSSection<MassiveModificationStructureView>( "","ul li[rpsid='17208091-cf47-43fe-a1ba-7ff116ecaf75']","",this);
 
            SectionMachineGroup = RPSControlFactory.CreateRPSSection<MassiveModificationStructureView>( "","ul li[rpsid='588a9735-f911-425f-abf6-213bdcbb1842']","",this);
 
            SectionTool = RPSControlFactory.CreateRPSSection<MassiveModificationStructureView>( "","ul li[rpsid='e5b69255-d60f-4b87-bd3b-97df4622ba66']","",this);
 

        }
        public IRPSComboBox<MassiveModificationStructureView> Site { get; set; } 
        public IRPSCollectionComboBox<MassiveModificationStructureView> ListArticle { get; set; } 
        public IRPSCollectionComboBox<MassiveModificationStructureView> ListUsualTaskSTR { get; set; } 
        public IRPSOption<MassiveModificationStructureView> NoActive { get; set; } 
        public IRPSOption<MassiveModificationStructureView> LatestVersion { get; set; } 
        public IRPSOption<MassiveModificationStructureView> ActiveOnly { get; set; } 
        public IRPSTextBox<MassiveModificationStructureView> ActiveOnlyDate { get; set; } 
        public IRPSCollectionComboBox<MassiveModificationStructureView> ListArticleMaterial { get; set; } 
        public IRPSComboBox<MassiveModificationStructureView> DestinationArticle { get; set; } 
        public IRPSCheckbox<MassiveModificationStructureView> CheckQuantityMaterial { get; set; } 
        public IRPSOption<MassiveModificationStructureView> Fixed { get; set; } 
        public IRPSOption<MassiveModificationStructureView> Percentage { get; set; } 
        public IRPSTextBox<MassiveModificationStructureView> MaterialQuantity { get; set; } 
        public IRPSButton<MassiveModificationStructureView,MaterialMassiveDialogView> MaterialMassiveNavigationCommand { get; set; } 
        public IRPSCollectionComboBox<MassiveModificationStructureView> ListEmployee { get; set; } 
        public IRPSComboBox<MassiveModificationStructureView> DestinationEmployee { get; set; } 
        public IRPSCheckbox<MassiveModificationStructureView> CheckExecutionTimeEmployee { get; set; } 
        public IRPSOption<MassiveModificationStructureView> Fixed1 { get; set; } 
        public IRPSOption<MassiveModificationStructureView> Percentage1 { get; set; } 
        public IRPSTextBox<MassiveModificationStructureView> EmployeeQuantityPercentage { get; set; } 
        public IRPSDurationTextBox<MassiveModificationStructureView> EmployeeUnitQuantity { get; set; } 
        public IRPSButton<MassiveModificationStructureView,EmployeeMassiveDialogView> EmployeeMassiveNavigationCommand { get; set; } 
        public IRPSCollectionComboBox<MassiveModificationStructureView> ListQualify { get; set; } 
        public IRPSComboBox<MassiveModificationStructureView> DestinationQualify { get; set; } 
        public IRPSCheckbox<MassiveModificationStructureView> CheckExecutionTimeQualify { get; set; } 
        public IRPSOption<MassiveModificationStructureView> Fixed2 { get; set; } 
        public IRPSOption<MassiveModificationStructureView> Percentage2 { get; set; } 
        public IRPSTextBox<MassiveModificationStructureView> QualifyQuantityPercentage { get; set; } 
        public IRPSDurationTextBox<MassiveModificationStructureView> QualifyUnitQuantity { get; set; } 
        public IRPSButton<MassiveModificationStructureView> QualifyMassiveNavigationCommand { get; set; } 
        public IRPSCollectionComboBox<MassiveModificationStructureView> ListMachine { get; set; } 
        public IRPSComboBox<MassiveModificationStructureView> DestinationMachine { get; set; } 
        public IRPSCheckbox<MassiveModificationStructureView> CheckExecutionTimeMachine { get; set; } 
        public IRPSOption<MassiveModificationStructureView> Fixed3 { get; set; } 
        public IRPSOption<MassiveModificationStructureView> Percentage3 { get; set; } 
        public IRPSTextBox<MassiveModificationStructureView> MachineQuantity { get; set; } 
        public IRPSDurationTextBox<MassiveModificationStructureView> MachineUnitQuantity { get; set; } 
        public IRPSButton<MassiveModificationStructureView,MachineMassiveDialogView> MachineMassiveNavigationCommand { get; set; } 
        public IRPSCollectionComboBox<MassiveModificationStructureView> ListMachineGroup { get; set; } 
        public IRPSComboBox<MassiveModificationStructureView> DestinationMachineGroup { get; set; } 
        public IRPSCheckbox<MassiveModificationStructureView> CheckExecutionTimeMachineGroup { get; set; } 
        public IRPSOption<MassiveModificationStructureView> Fixed4 { get; set; } 
        public IRPSOption<MassiveModificationStructureView> Percentage4 { get; set; } 
        public IRPSTextBox<MassiveModificationStructureView> MachineGroupQuantityPercentage { get; set; } 
        public IRPSDurationTextBox<MassiveModificationStructureView> MachineGroupUnitQuantity { get; set; } 
        public IRPSButton<MassiveModificationStructureView> MachineGroupMassiveNavigationCommand { get; set; } 
        public IRPSCollectionComboBox<MassiveModificationStructureView> ListTool { get; set; } 
        public IRPSComboBox<MassiveModificationStructureView> DestinationTool { get; set; } 
        public IRPSCheckbox<MassiveModificationStructureView> CheckExecutionTimeTool { get; set; } 
        public IRPSOption<MassiveModificationStructureView> Fixed5 { get; set; } 
        public IRPSOption<MassiveModificationStructureView> Percentage5 { get; set; } 
        public IRPSTextBox<MassiveModificationStructureView> ToolQuantity { get; set; } 
        public IRPSDurationTextBox<MassiveModificationStructureView> ToolUnitQuantity { get; set; } 
        public IRPSButton<MassiveModificationStructureView,ToolMassiveDialogView> ToolMassiveNavigationCommand { get; set; } 
        public IRPSSection<MassiveModificationStructureView> SectionMaterial { get; set; } 
        public IRPSSection<MassiveModificationStructureView> SectionEmployee { get; set; } 
        public IRPSSection<MassiveModificationStructureView> SectionQualify { get; set; } 
        public IRPSSection<MassiveModificationStructureView> SectionMachine { get; set; } 
        public IRPSSection<MassiveModificationStructureView> SectionMachineGroup { get; set; } 
        public IRPSSection<MassiveModificationStructureView> SectionTool { get; set; } 
        public MassiveModificationStructure Screen { get; set; }
        public MassiveModificationStructureView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaterialMassiveDialogView : View
    {
        public MaterialMassiveDialogView(MassiveModificationStructure screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            OKCommand = RPSControlFactory.CreateRPSButton<MaterialMassiveDialogView>( "e00dc60c-2fd4-44fb-b0ac-61a84d3480a8","","",this);
 
            CancelCommand = RPSControlFactory.CreateRPSButton<MaterialMassiveDialogView>( "ef1dcbae-9d76-4b24-9c83-bd8c2b620480","","",this);
 
            CollectionInit params_GetMaterialForMassiveChange = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6ca5be00-6232-46ff-9529-43b1abb0aa08",CSSSelectorGrid="",XPathGrid=""};
            GetMaterialForMassiveChange = RPSControlFactory.RPSCreateCollectionWithGrid<GetMaterialForMassiveChangeCollectionEditor<MaterialMassiveDialogView,EmployeeMassiveDialogView>,MaterialMassiveDialogView,EmployeeMassiveDialogView>( params_GetMaterialForMassiveChange,this,Screen.EmployeeMassiveDialogView);
 

        }
        public IRPSButton<MaterialMassiveDialogView> OKCommand { get; set; } 
        public IRPSButton<MaterialMassiveDialogView> CancelCommand { get; set; } 
        public GetMaterialForMassiveChangeCollectionEditor<MaterialMassiveDialogView,EmployeeMassiveDialogView> GetMaterialForMassiveChange { get; set; } 
        public MassiveModificationStructure Screen { get; set; }
        public MaterialMassiveDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetMaterialForMassiveChangeCollectionEditor<MaterialMassiveDialogView,EmployeeMassiveDialogView>:RPSCollectionEditor<MaterialMassiveDialogView,EmployeeMassiveDialogView> where MaterialMassiveDialogView : class, IView where EmployeeMassiveDialogView : class, IView
    {
        public  GetMaterialForMassiveChangeGridView<MaterialMassiveDialogView,EmployeeMassiveDialogView> GridView {get;set;}
    }
    public partial class GetMaterialForMassiveChangeGridView <MaterialMassiveDialogView,EmployeeMassiveDialogView> :  RPSGridView<MaterialMassiveDialogView,EmployeeMassiveDialogView> where MaterialMassiveDialogView : class, IView where EmployeeMassiveDialogView : class, IView
    {
        public GetMaterialForMassiveChangeGridView(MaterialMassiveDialogView currentView,EmployeeMassiveDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            StructureDate = RPSControlFactory.CreateRPSGridTextBox<MaterialMassiveDialogView>("","#6ca5be00-6232-46ff-9529-43b1abb0aa08 .ag-row[role='row']@ROWINDEX [col-id='cStructureDate']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<MaterialMassiveDialogView>("","#6ca5be00-6232-46ff-9529-43b1abb0aa08 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MaterialMassiveDialogView> StructureDate { get; set; } 
        public IRPSGridTextBox<MaterialMassiveDialogView> Quantity { get; set; } 
                     
    }
 
    }
  
            
    public partial class EmployeeMassiveDialogView : View
    {
        public EmployeeMassiveDialogView(MassiveModificationStructure screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            OkCommand = RPSControlFactory.CreateRPSButton<EmployeeMassiveDialogView>( "ceb5c09a-0e74-4e0a-927b-7591dee87408","","",this);
 
            CancelCommand = RPSControlFactory.CreateRPSButton<EmployeeMassiveDialogView>( "7969a116-0adf-470e-9825-16fc96bfe078","","",this);
 
            CollectionInit params_GetResourceEmployeeForMassiveChange = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5fc3dc38-2913-4a91-9a03-6d3076f7c5c4",CSSSelectorGrid="",XPathGrid=""};
            GetResourceEmployeeForMassiveChange = RPSControlFactory.RPSCreateCollectionWithGrid<GetResourceEmployeeForMassiveChangeCollectionEditor<EmployeeMassiveDialogView>,EmployeeMassiveDialogView>( params_GetResourceEmployeeForMassiveChange,this);
 

        }
        public IRPSButton<EmployeeMassiveDialogView> OkCommand { get; set; } 
        public IRPSButton<EmployeeMassiveDialogView> CancelCommand { get; set; } 
        public GetResourceEmployeeForMassiveChangeCollectionEditor<EmployeeMassiveDialogView> GetResourceEmployeeForMassiveChange { get; set; } 
        public MassiveModificationStructure Screen { get; set; }
        public EmployeeMassiveDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetResourceEmployeeForMassiveChangeCollectionEditor<EmployeeMassiveDialogView>:RPSCollectionEditor<EmployeeMassiveDialogView> where EmployeeMassiveDialogView : class, IView
    {
        public  GetResourceEmployeeForMassiveChangeGridView<EmployeeMassiveDialogView> GridView {get;set;}
    }
    public partial class GetResourceEmployeeForMassiveChangeGridView <EmployeeMassiveDialogView> :  RPSGridView<EmployeeMassiveDialogView> where EmployeeMassiveDialogView : class, IView
    {
        public GetResourceEmployeeForMassiveChangeGridView(EmployeeMassiveDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            StructureDate = RPSControlFactory.CreateRPSGridTextBox<EmployeeMassiveDialogView>("","#5fc3dc38-2913-4a91-9a03-6d3076f7c5c4 .ag-row[role='row']@ROWINDEX [col-id='cStructureDate']","",false, this.CurrentView);
 
            Duration = RPSControlFactory.CreateRPSGridFormattedTextBox<EmployeeMassiveDialogView>("","#5fc3dc38-2913-4a91-9a03-6d3076f7c5c4 .ag-row[role='row']@ROWINDEX [col-id='cDuration']","",false, this.CurrentView);
 
            eTimeUnit = RPSControlFactory.CreateRPSGridEnumComboBox<EmployeeMassiveDialogView>("","#5fc3dc38-2913-4a91-9a03-6d3076f7c5c4 .ag-row[role='row']@ROWINDEX [col-id='ceTimeUnit']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<EmployeeMassiveDialogView> StructureDate { get; set; } 
        public IRPSGridTextBox<EmployeeMassiveDialogView> Duration { get; set; } 
        public IRPSGridComboBox<EmployeeMassiveDialogView> eTimeUnit { get; set; } 
                     
    }
 
    }
  
            
    public partial class MachineMassiveDialogView : View
    {
        public MachineMassiveDialogView(MassiveModificationStructure screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            OKCommand = RPSControlFactory.CreateRPSButton<MachineMassiveDialogView>( "dc6ce8a0-60c0-4747-b83e-3f968819dee9","","",this);
 
            CancelCommand = RPSControlFactory.CreateRPSButton<MachineMassiveDialogView>( "7e2efd39-4670-46da-ae76-5a840e922914","","",this);
 
            CollectionInit params_GetResourceMachineForMassiveChange = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ca903961-b2be-4229-827c-516ab936efc4",CSSSelectorGrid="",XPathGrid=""};
            GetResourceMachineForMassiveChange = RPSControlFactory.RPSCreateCollectionWithGrid<GetResourceMachineForMassiveChangeCollectionEditor<MachineMassiveDialogView>,MachineMassiveDialogView>( params_GetResourceMachineForMassiveChange,this);
 

        }
        public IRPSButton<MachineMassiveDialogView> OKCommand { get; set; } 
        public IRPSButton<MachineMassiveDialogView> CancelCommand { get; set; } 
        public GetResourceMachineForMassiveChangeCollectionEditor<MachineMassiveDialogView> GetResourceMachineForMassiveChange { get; set; } 
        public MassiveModificationStructure Screen { get; set; }
        public MachineMassiveDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetResourceMachineForMassiveChangeCollectionEditor<MachineMassiveDialogView>:RPSCollectionEditor<MachineMassiveDialogView> where MachineMassiveDialogView : class, IView
    {
        public  GetResourceMachineForMassiveChangeGridView<MachineMassiveDialogView> GridView {get;set;}
    }
    public partial class GetResourceMachineForMassiveChangeGridView <MachineMassiveDialogView> :  RPSGridView<MachineMassiveDialogView> where MachineMassiveDialogView : class, IView
    {
        public GetResourceMachineForMassiveChangeGridView(MachineMassiveDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            StructureDate = RPSControlFactory.CreateRPSGridTextBox<MachineMassiveDialogView>("","#ca903961-b2be-4229-827c-516ab936efc4 .ag-row[role='row']@ROWINDEX [col-id='cStructureDate']","",false, this.CurrentView);
 
            Duration = RPSControlFactory.CreateRPSGridFormattedTextBox<MachineMassiveDialogView>("","#ca903961-b2be-4229-827c-516ab936efc4 .ag-row[role='row']@ROWINDEX [col-id='cDuration']","",false, this.CurrentView);
 
            eTimeUnit = RPSControlFactory.CreateRPSGridEnumComboBox<MachineMassiveDialogView>("","#ca903961-b2be-4229-827c-516ab936efc4 .ag-row[role='row']@ROWINDEX [col-id='ceTimeUnit']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MachineMassiveDialogView> StructureDate { get; set; } 
        public IRPSGridTextBox<MachineMassiveDialogView> Duration { get; set; } 
        public IRPSGridComboBox<MachineMassiveDialogView> eTimeUnit { get; set; } 
                     
    }
 
    }
  
            
    public partial class ToolMassiveDialogView : View
    {
        public ToolMassiveDialogView(MassiveModificationStructure screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            OKCommand = RPSControlFactory.CreateRPSButton<ToolMassiveDialogView>( "d654c038-b865-48ca-89e2-be0c6c98b54a","","",this);
 
            CancelCommand = RPSControlFactory.CreateRPSButton<ToolMassiveDialogView>( "22e16e22-9831-428e-9ab0-1b3eab4ca81d","","",this);
 
            CollectionInit params_GetResourceToolForMassiveChange = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7c1e74d1-3171-4949-996d-5e582157f57a",CSSSelectorGrid="",XPathGrid=""};
            GetResourceToolForMassiveChange = RPSControlFactory.RPSCreateCollectionWithGrid<GetResourceToolForMassiveChangeCollectionEditor<ToolMassiveDialogView>,ToolMassiveDialogView>( params_GetResourceToolForMassiveChange,this);
 

        }
        public IRPSButton<ToolMassiveDialogView> OKCommand { get; set; } 
        public IRPSButton<ToolMassiveDialogView> CancelCommand { get; set; } 
        public GetResourceToolForMassiveChangeCollectionEditor<ToolMassiveDialogView> GetResourceToolForMassiveChange { get; set; } 
        public MassiveModificationStructure Screen { get; set; }
        public ToolMassiveDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetResourceToolForMassiveChangeCollectionEditor<ToolMassiveDialogView>:RPSCollectionEditor<ToolMassiveDialogView> where ToolMassiveDialogView : class, IView
    {
        public  GetResourceToolForMassiveChangeGridView<ToolMassiveDialogView> GridView {get;set;}
    }
    public partial class GetResourceToolForMassiveChangeGridView <ToolMassiveDialogView> :  RPSGridView<ToolMassiveDialogView> where ToolMassiveDialogView : class, IView
    {
        public GetResourceToolForMassiveChangeGridView(ToolMassiveDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            StructureDate = RPSControlFactory.CreateRPSGridTextBox<ToolMassiveDialogView>("","#7c1e74d1-3171-4949-996d-5e582157f57a .ag-row[role='row']@ROWINDEX [col-id='cStructureDate']","",false, this.CurrentView);
 
            Duration = RPSControlFactory.CreateRPSGridFormattedTextBox<ToolMassiveDialogView>("","#7c1e74d1-3171-4949-996d-5e582157f57a .ag-row[role='row']@ROWINDEX [col-id='cDuration']","",false, this.CurrentView);
 
            eTimeUnit = RPSControlFactory.CreateRPSGridEnumComboBox<ToolMassiveDialogView>("","#7c1e74d1-3171-4949-996d-5e582157f57a .ag-row[role='row']@ROWINDEX [col-id='ceTimeUnit']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ToolMassiveDialogView> StructureDate { get; set; } 
        public IRPSGridTextBox<ToolMassiveDialogView> Duration { get; set; } 
        public IRPSGridComboBox<ToolMassiveDialogView> eTimeUnit { get; set; } 
                     
    }
 
    }
  
            
    public partial class QualifyMassiveDialogView : View
    {
        public QualifyMassiveDialogView(MassiveModificationStructure screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            OkCommand = RPSControlFactory.CreateRPSButton<QualifyMassiveDialogView>( "eec1b8b9-494e-405a-bb9b-3bd43a2be4f2","","",this);
 
            CancelCommand = RPSControlFactory.CreateRPSButton<QualifyMassiveDialogView>( "641b513b-14e9-4611-974b-4fa40761513f","","",this);
 
            CollectionInit params_GetResourceEmployeeForQualifyMassiveChange = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a149264b-7b45-438c-984e-12495bf4b102",CSSSelectorGrid="",XPathGrid=""};
            GetResourceEmployeeForQualifyMassiveChange = RPSControlFactory.RPSCreateCollectionWithGrid<GetResourceEmployeeForQualifyMassiveChangeCollectionEditor<QualifyMassiveDialogView>,QualifyMassiveDialogView>( params_GetResourceEmployeeForQualifyMassiveChange,this);
 

        }
        public IRPSButton<QualifyMassiveDialogView> OkCommand { get; set; } 
        public IRPSButton<QualifyMassiveDialogView> CancelCommand { get; set; } 
        public GetResourceEmployeeForQualifyMassiveChangeCollectionEditor<QualifyMassiveDialogView> GetResourceEmployeeForQualifyMassiveChange { get; set; } 
        public MassiveModificationStructure Screen { get; set; }
        public QualifyMassiveDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetResourceEmployeeForQualifyMassiveChangeCollectionEditor<QualifyMassiveDialogView>:RPSCollectionEditor<QualifyMassiveDialogView> where QualifyMassiveDialogView : class, IView
    {
        public  GetResourceEmployeeForQualifyMassiveChangeGridView<QualifyMassiveDialogView> GridView {get;set;}
    }
    public partial class GetResourceEmployeeForQualifyMassiveChangeGridView <QualifyMassiveDialogView> :  RPSGridView<QualifyMassiveDialogView> where QualifyMassiveDialogView : class, IView
    {
        public GetResourceEmployeeForQualifyMassiveChangeGridView(QualifyMassiveDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            StructureDate = RPSControlFactory.CreateRPSGridTextBox<QualifyMassiveDialogView>("","#a149264b-7b45-438c-984e-12495bf4b102 .ag-row[role='row']@ROWINDEX [col-id='cStructureDate']","",false, this.CurrentView);
 
            Duration = RPSControlFactory.CreateRPSGridFormattedTextBox<QualifyMassiveDialogView>("","#a149264b-7b45-438c-984e-12495bf4b102 .ag-row[role='row']@ROWINDEX [col-id='cDuration']","",false, this.CurrentView);
 
            eTimeUnit = RPSControlFactory.CreateRPSGridEnumComboBox<QualifyMassiveDialogView>("","#a149264b-7b45-438c-984e-12495bf4b102 .ag-row[role='row']@ROWINDEX [col-id='ceTimeUnit']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<QualifyMassiveDialogView> StructureDate { get; set; } 
        public IRPSGridTextBox<QualifyMassiveDialogView> Duration { get; set; } 
        public IRPSGridComboBox<QualifyMassiveDialogView> eTimeUnit { get; set; } 
                     
    }
 
    }
  
            
    public partial class MachineGroupMassiveDialogView : View
    {
        public MachineGroupMassiveDialogView(MassiveModificationStructure screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_GetResourceMachineForMachineGroupMassiveChange = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1e705608-778d-4224-9669-a98fce7a8946",CSSSelectorGrid="",XPathGrid=""};
            GetResourceMachineForMachineGroupMassiveChange = RPSControlFactory.RPSCreateCollectionWithGrid<GetResourceMachineForMachineGroupMassiveChangeCollectionEditor<MachineGroupMassiveDialogView>,MachineGroupMassiveDialogView>( params_GetResourceMachineForMachineGroupMassiveChange,this);
 

        }
        public GetResourceMachineForMachineGroupMassiveChangeCollectionEditor<MachineGroupMassiveDialogView> GetResourceMachineForMachineGroupMassiveChange { get; set; } 
        public MassiveModificationStructure Screen { get; set; }
        public MachineGroupMassiveDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetResourceMachineForMachineGroupMassiveChangeCollectionEditor<MachineGroupMassiveDialogView>:RPSCollectionEditor<MachineGroupMassiveDialogView> where MachineGroupMassiveDialogView : class, IView
    {
        public  GetResourceMachineForMachineGroupMassiveChangeGridView<MachineGroupMassiveDialogView> GridView {get;set;}
    }
    public partial class GetResourceMachineForMachineGroupMassiveChangeGridView <MachineGroupMassiveDialogView> :  RPSGridView<MachineGroupMassiveDialogView> where MachineGroupMassiveDialogView : class, IView
    {
        public GetResourceMachineForMachineGroupMassiveChangeGridView(MachineGroupMassiveDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            StructureDate = RPSControlFactory.CreateRPSGridTextBox<MachineGroupMassiveDialogView>("","#1e705608-778d-4224-9669-a98fce7a8946 .ag-row[role='row']@ROWINDEX [col-id='cStructureDate']","",false, this.CurrentView);
 
            Duration = RPSControlFactory.CreateRPSGridFormattedTextBox<MachineGroupMassiveDialogView>("","#1e705608-778d-4224-9669-a98fce7a8946 .ag-row[role='row']@ROWINDEX [col-id='cDuration']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MachineGroupMassiveDialogView> StructureDate { get; set; } 
        public IRPSGridTextBox<MachineGroupMassiveDialogView> Duration { get; set; } 
                     
    }
 
    }
  
    

}