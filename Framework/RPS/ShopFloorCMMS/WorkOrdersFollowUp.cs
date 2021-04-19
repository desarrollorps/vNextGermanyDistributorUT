    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.ShopFloorCMMS.WorkOrdersFollowUp
{
    //RPS VERSION 1.0.0.0
    public partial class WorkOrdersFollowUp:Screen
    {
        public WorkOrdersFollowUp():base()
        {
            this.URL = "shopfloorcmms.workordersfollowup";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MaintenanceOrderVMQueryView  = new MaintenanceOrderVMQueryView(this); 
            MaintenanceOrderVMEntityView  = new MaintenanceOrderVMEntityView(this); 
            StatusLegendDialogView  = new StatusLegendDialogView(this); 
            NewOTDialogView  = new NewOTDialogView(this); 
            MaintenanceOrderMaterialView  = new MaintenanceOrderMaterialView(this); 
            NewCharacOfControlDialogView  = new NewCharacOfControlDialogView(this); 
            OMChangeStatusDialogView  = new OMChangeStatusDialogView(this); 
            EmployeeValidationDialogView  = new EmployeeValidationDialogView(this); 
            TimeDialogView  = new TimeDialogView(this); 
            OrderMaterialPrevisionView  = new OrderMaterialPrevisionView(this); 
            MaterialProvisioningValidationDialogView  = new MaterialProvisioningValidationDialogView(this); 
            MaintenanceOrderVMQueryView.InitializeControls(); 
            MaintenanceOrderVMEntityView.InitializeControls(); 
            StatusLegendDialogView.InitializeControls(); 
            NewOTDialogView.InitializeControls(); 
            MaintenanceOrderMaterialView.InitializeControls(); 
            NewCharacOfControlDialogView.InitializeControls(); 
            OMChangeStatusDialogView.InitializeControls(); 
            EmployeeValidationDialogView.InitializeControls(); 
            TimeDialogView.InitializeControls(); 
            OrderMaterialPrevisionView.InitializeControls(); 
            MaterialProvisioningValidationDialogView.InitializeControls(); 
           
        }
      
            public MaintenanceOrderVMQueryView MaintenanceOrderVMQueryView {get; set; } 
            public MaintenanceOrderVMEntityView MaintenanceOrderVMEntityView {get; set; } 
            public StatusLegendDialogView StatusLegendDialogView {get; set; } 
            public NewOTDialogView NewOTDialogView {get; set; } 
            public MaintenanceOrderMaterialView MaintenanceOrderMaterialView {get; set; } 
            public NewCharacOfControlDialogView NewCharacOfControlDialogView {get; set; } 
            public OMChangeStatusDialogView OMChangeStatusDialogView {get; set; } 
            public EmployeeValidationDialogView EmployeeValidationDialogView {get; set; } 
            public TimeDialogView TimeDialogView {get; set; } 
            public OrderMaterialPrevisionView OrderMaterialPrevisionView {get; set; } 
            public MaterialProvisioningValidationDialogView MaterialProvisioningValidationDialogView {get; set; } 
    }
            
    public partial class MaintenanceOrderVMQueryView : View
    {
        public MaintenanceOrderVMQueryView(WorkOrdersFollowUp screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<MaintenanceOrderVMQueryView,MaintenanceOrderVMEntityView>( this,Screen.MaintenanceOrderVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<MaintenanceOrderVMQueryView>( this);
 
            OnlyOpen = RPSControlFactory.CreateRPSCheckBox<MaintenanceOrderVMQueryView>("a3a199b5-2296-4d51-bcf5-8ae414100e97","","",false, this);
 
            MaintenanceOrderStatus = RPSControlFactory.CreateRPSCollectionComboBox<MaintenanceOrderVMQueryView>("2422ea63-f7b5-4a99-b9bb-d530d5bf4a0d","","",false, this);
 
            ExecutionDateFrom = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderVMQueryView>("fc9431ad-65c4-4557-a613-e83d1aab62b1","","",false, this);
 
            ExecutionDateTo = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderVMQueryView>("5978c8de-2640-4de6-a0ef-4a8e464b0012","","",false, this);
 
            IDTerminal = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderVMQueryView>("f98f9513-b324-4920-bef6-bc0d6363b516","","",false, this);
 
            IDMaintenanceComponent = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderVMQueryView>("6c8a01d8-1303-47b1-857b-5afffb1519b5","","",false, this);
 
            eResponsibleType = RPSControlFactory.CreateRPSEnumComboBox<MaintenanceOrderVMQueryView>("5089cb7d-6e41-4d44-a655-88563f272187","","",false, this);
 
            IDEmployeeResponsible = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderVMQueryView>("aa71df48-2b88-4c02-ae2f-1c4860bd9228","","",false, this);
 
            IDQualifyResponsible = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderVMQueryView>("021b3b06-8311-4884-9287-ac2b802402e3","","",false, this);
 
            IDSupplierResponsible = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderVMQueryView>("df98def2-d447-47d0-8e80-75b872301642","","",false, this);
 
            IDEmployeeReportedBy = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderVMQueryView>("a8162ee2-43d8-40f0-a5c5-0b2d8aa840a3","","",false, this);
 
            IDMaintenanceType = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderVMQueryView>("ae1e044f-d43b-46cb-819f-1bc34fe8e23d","","",false, this);
 
            IDMaintenanceOrder = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderVMQueryView>("e4abf268-6987-4bdf-9cc8-83b429e64b43","","",false, this);
 
            SelectEmployeeMessage = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderVMQueryView>("a1c2015f-9e30-4250-be3e-bc99633f8049","","",false, this);
 
            NewOTNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<MaintenanceOrderVMQueryView,NewOTDialogView>("78c1ee6a-bb58-40a9-bce5-800a3a3b01a7","","", this,Screen.NewOTDialogView);
 
            StatusLegendNavigationCommandButton = RPSControlFactory.CreateRPSButton<MaintenanceOrderVMQueryView>( "7d67ebda-b7b4-4910-bfc5-f72a90e8c3e9","","",this);
 
            SelectMaintenanceWorkerNavigationCommandButton = RPSControlFactory.CreateRPSButton<MaintenanceOrderVMQueryView>( "ee5dd2c7-b637-4a40-a4e8-2aef68c27690","","",this);
 
            TicketRequestNavigationCommandButton = RPSControlFactory.CreateRPSButton<MaintenanceOrderVMQueryView>( "a6e7342b-1ad6-46f3-861d-a1cbbfdf1d9a","","",this);
 
            MOHistoricNavigationCommandButton = RPSControlFactory.CreateRPSButton<MaintenanceOrderVMQueryView>( "a6f372ff-5823-42eb-94ed-b69fdd589ba5","","",this);
 
            MaterialStockLocatorNavigationCommandButton = RPSControlFactory.CreateRPSButton<MaintenanceOrderVMQueryView>( "71b8a9b9-3ccf-4b95-9db0-551c18a0bbc2","","",this);
 
            ShopfloorDocumentationNavigationCommandButton = RPSControlFactory.CreateRPSButton<MaintenanceOrderVMQueryView>( "69af18a5-d086-4d85-937a-66fd49e1d499","","",this);
 
            CollectionInit params_WorkOrdersFollowUp = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="e4a19f4b-0b89-43cb-9ff7-74b888e07782",CSSSelectorGrid="",XPathGrid=""};
            WorkOrdersFollowUp = RPSControlFactory.RPSCreateCollectionWithGrid<WorkOrdersFollowUpCollectionEditor<MaintenanceOrderVMQueryView,MaintenanceOrderVMEntityView>,MaintenanceOrderVMQueryView,MaintenanceOrderVMEntityView>( params_WorkOrdersFollowUp,this,Screen.MaintenanceOrderVMEntityView);
 

        }
        public IRPSButton<MaintenanceOrderVMQueryView,MaintenanceOrderVMEntityView> NewButton { get; set; } 
        public IRPSButton<MaintenanceOrderVMQueryView> ConsultButton { get; set; } 
        public IRPSCheckbox<MaintenanceOrderVMQueryView> OnlyOpen { get; set; } 
        public IRPSCollectionComboBox<MaintenanceOrderVMQueryView> MaintenanceOrderStatus { get; set; } 
        public IRPSTextBox<MaintenanceOrderVMQueryView> ExecutionDateFrom { get; set; } 
        public IRPSTextBox<MaintenanceOrderVMQueryView> ExecutionDateTo { get; set; } 
        public IRPSComboBox<MaintenanceOrderVMQueryView> IDTerminal { get; set; } 
        public IRPSComboBox<MaintenanceOrderVMQueryView> IDMaintenanceComponent { get; set; } 
        public IRPSComboBox<MaintenanceOrderVMQueryView> eResponsibleType { get; set; } 
        public IRPSComboBox<MaintenanceOrderVMQueryView> IDEmployeeResponsible { get; set; } 
        public IRPSComboBox<MaintenanceOrderVMQueryView> IDQualifyResponsible { get; set; } 
        public IRPSComboBox<MaintenanceOrderVMQueryView> IDSupplierResponsible { get; set; } 
        public IRPSComboBox<MaintenanceOrderVMQueryView> IDEmployeeReportedBy { get; set; } 
        public IRPSComboBox<MaintenanceOrderVMQueryView> IDMaintenanceType { get; set; } 
        public IRPSComboBox<MaintenanceOrderVMQueryView> IDMaintenanceOrder { get; set; } 
        public IRPSTextBox<MaintenanceOrderVMQueryView> SelectEmployeeMessage { get; set; } 
        public IRPSButton<MaintenanceOrderVMQueryView,NewOTDialogView> NewOTNavigationCommandButton { get; set; } 
        public IRPSButton<MaintenanceOrderVMQueryView> StatusLegendNavigationCommandButton { get; set; } 
        public IRPSButton<MaintenanceOrderVMQueryView> SelectMaintenanceWorkerNavigationCommandButton { get; set; } 
        public IRPSButton<MaintenanceOrderVMQueryView> TicketRequestNavigationCommandButton { get; set; } 
        public IRPSButton<MaintenanceOrderVMQueryView> MOHistoricNavigationCommandButton { get; set; } 
        public IRPSButton<MaintenanceOrderVMQueryView> MaterialStockLocatorNavigationCommandButton { get; set; } 
        public IRPSButton<MaintenanceOrderVMQueryView> ShopfloorDocumentationNavigationCommandButton { get; set; } 
        public WorkOrdersFollowUpCollectionEditor<MaintenanceOrderVMQueryView,MaintenanceOrderVMEntityView> WorkOrdersFollowUp { get; set; } 
        public WorkOrdersFollowUp Screen { get; set; }
        public MaintenanceOrderVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class WorkOrdersFollowUpCollectionEditor<MaintenanceOrderVMQueryView,MaintenanceOrderVMEntityView>:RPSCollectionEditor<MaintenanceOrderVMQueryView,MaintenanceOrderVMEntityView> where MaintenanceOrderVMQueryView : class, IView where MaintenanceOrderVMEntityView : class, IView
    {
        public  WorkOrdersFollowUpGridView<MaintenanceOrderVMQueryView,MaintenanceOrderVMEntityView> GridView {get;set;}
    }
    public partial class WorkOrdersFollowUpGridView <MaintenanceOrderVMQueryView,MaintenanceOrderVMEntityView> :  RPSGridView<MaintenanceOrderVMQueryView,MaintenanceOrderVMEntityView> where MaintenanceOrderVMQueryView : class, IView where MaintenanceOrderVMEntityView : class, IView
    {
        public WorkOrdersFollowUpGridView(MaintenanceOrderVMQueryView currentView,MaintenanceOrderVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MaintenanceOrder_ExecutionDate = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderVMQueryView>("","#e4a19f4b-0b89-43cb-9ff7-74b888e07782 .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceOrder_ExecutionDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MaintenanceOrderVMQueryView> MaintenanceOrder_ExecutionDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class MaintenanceOrderVMEntityView : View
    {
        public MaintenanceOrderVMEntityView(WorkOrdersFollowUp screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MaintenanceOrderVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceOrderVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceOrderVMEntityView,MaintenanceOrderVMQueryView>( this,Screen.MaintenanceOrderVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceOrderVMEntityView,MaintenanceOrderVMQueryView>( this,Screen.MaintenanceOrderVMQueryView);
 
            PurchaseProposal = RPSControlFactory.CreateRPSOption<MaintenanceOrderVMEntityView>( "b08a5842-6c21-4690-90fc-b329190b663f","","",this);
 
            ManufacturingOrder = RPSControlFactory.CreateRPSOption<MaintenanceOrderVMEntityView>( "b6f1a349-d386-4209-a222-0f0f0f9ce8b1","","",this);
 
            ExecuteAddMaintenanceOrderMaterialsPrevisonButton = RPSControlFactory.CreateRPSButton<MaintenanceOrderVMEntityView>( "8b3b6465-a054-460e-9d26-348370098586","","",this);
 
            PurchaseProposalValidationCommandButton = RPSControlFactory.CreateRPSButtonToView<MaintenanceOrderVMEntityView,EmployeeValidationDialogView>("cf849266-17ee-4e8d-a86a-2ca7e4770866","","", this,Screen.EmployeeValidationDialogView);
 
            AddNewCharacOfControl = RPSControlFactory.CreateRPSButtonToView<MaintenanceOrderVMEntityView,NewCharacOfControlDialogView>("6ec388df-ed53-453a-afae-919953f93aad","","", this,Screen.NewCharacOfControlDialogView);
 
            RemoveSelectedCharacOfControl = RPSControlFactory.CreateRPSButton<MaintenanceOrderVMEntityView>( "8a1067b7-b6bb-4924-89ac-e1bf50c31961","","",this);
 
            GoToFirstCharac = RPSControlFactory.CreateRPSButton<MaintenanceOrderVMEntityView>( "df12b4db-cd2e-48dc-9fc3-5552461eb235","","",this);
 
            GoToPreviousCharac = RPSControlFactory.CreateRPSButton<MaintenanceOrderVMEntityView>( "bd86a441-281d-41da-ae07-fcbac8cb808c","","",this);
 
            GoToNextCharac = RPSControlFactory.CreateRPSButton<MaintenanceOrderVMEntityView>( "92ae08f3-ccbe-4281-b3f1-f4a6e29ae38d","","",this);
 
            GoToLastCharac = RPSControlFactory.CreateRPSButton<MaintenanceOrderVMEntityView>( "dd9bbdc0-94b3-4b21-9fb8-60eef4604465","","",this);
 
            SelectedCharacValue = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceOrderVMEntityView>("0ec42cbc-070d-4656-b94b-62194b89c443","","",false, this);
 
            AddNewSampleValue = RPSControlFactory.CreateRPSButton<MaintenanceOrderVMEntityView>( "bacbfa4a-2cd5-40fb-807a-0e97e8632620","","",this);
 
            AddNewSampleValue1 = RPSControlFactory.CreateRPSButton<MaintenanceOrderVMEntityView>( "48f45509-332f-4b72-9be8-b81db30bec4c","","",this);
 
            OKSampleCommand = RPSControlFactory.CreateRPSButton<MaintenanceOrderVMEntityView>( "42a3d049-c60d-41f0-aaf9-227446d4c0d5","","",this);
 
            NoOKSampleCommand = RPSControlFactory.CreateRPSButton<MaintenanceOrderVMEntityView>( "a8e27603-6dd2-4716-8b4b-8920bde1f587","","",this);
 
            SelectedControlFeatureCode = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderVMEntityView>("7837fad3-8cd6-4a5a-a35c-3d60b6a53023","","",false, this);
 
            SelectedControlFeatureDesc = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderVMEntityView>("b52ea5d8-bebf-4d87-9d57-5e6be4dd2d13","","",false, this);
 
            SelectedControlType = RPSControlFactory.CreateRPSEnumComboBox<MaintenanceOrderVMEntityView>("3165cd7c-053b-43fa-b395-45474cf6e13d","","",false, this);
 
            SelectedMinimumValue = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceOrderVMEntityView>("65a5ec1d-27c0-4185-9e38-02b5687fc72e","","",false, this);
 
            SelectedMaximumValue = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceOrderVMEntityView>("d7edf05e-c71a-4142-af3b-838b2df63260","","",false, this);
 
            SelectedAccuracy = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderVMEntityView>("305de78c-b185-4be6-86ab-4235a4e7a74a","","",false, this);
 
            SelectedPrecision = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderVMEntityView>("48a8381e-3490-4078-a97d-2e9b96b8449d","","",false, this);
 
            SelectedIDControlMethod = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderVMEntityView>("c43acf33-b513-47c9-9660-12375972de68","","",false, this);
 
            SelectedIDTestMethod = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderVMEntityView>("4f68a53a-1976-42dc-89d1-a8b970217e01","","",false, this);
 
            CreationDate = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderVMEntityView>("7171880e-aff8-4f12-bb28-833fe91d45f5","","",true, this);
 
            CodUserCreatedBy = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderVMEntityView>("f912c0b0-d824-4d93-a328-0eb522c265b8","","",false, this);
 
            IDEmployeeReportedBy = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderVMEntityView>("f9c64aa6-d3bd-41ce-aa43-6f7a880942ad","","",false, this);
 
            IDEmployeeResponsible = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderVMEntityView>("2426bb69-346f-4730-b650-5e31deaa2fba","","",false, this);
 
            IDQualifyResponsible = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderVMEntityView>("58199412-7460-4980-ab7d-1d0a21979faf","","",false, this);
 
            IDSupplierResponsible = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderVMEntityView>("16fe3d80-fd07-4b19-8007-7ef539a57bc8","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderVMEntityView>("beeaf456-6ace-4611-bdea-d6ec6122bfff","","",false, this);
 
            Observations = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderVMEntityView>("17d312bb-f64c-402d-9202-4263ec895dd3","","",false, this);
 
            Notes = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderVMEntityView>("2bd9eba5-8117-4c76-8555-6756bbe6564f","","",false, this);
 
            StopTime = RPSControlFactory.CreateRPSDurationTextBox<MaintenanceOrderVMEntityView>("f068701a-b21f-4196-b460-931a032c4a9c","","",true, this);
 
            ChangeEmployeeNavigationCommandButton = RPSControlFactory.CreateRPSButton<MaintenanceOrderVMEntityView>( "778a7681-25d8-4af9-bf31-786bdbdbb1ef","","",this);
 
            OMChangeStatusNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<MaintenanceOrderVMEntityView,OMChangeStatusDialogView>("b25c419e-269c-4d58-b7d0-63e040374ce3","","", this,Screen.OMChangeStatusDialogView);
 
            StartNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<MaintenanceOrderVMEntityView,EmployeeValidationDialogView>("df4329ae-e6fe-4fa6-b4e2-1c34dff4ff53","","", this,Screen.EmployeeValidationDialogView);
 
            EndNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<MaintenanceOrderVMEntityView,EmployeeValidationDialogView>("396309f5-86cc-4193-b990-0130a25a755a","","", this,Screen.EmployeeValidationDialogView);
 
            TimeValidationNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<MaintenanceOrderVMEntityView,EmployeeValidationDialogView>("3889b18f-854c-4bbd-a32f-d552e72b8d8e","","", this,Screen.EmployeeValidationDialogView);
 
            TicketRequestNavigationCommandButton = RPSControlFactory.CreateRPSButton<MaintenanceOrderVMEntityView>( "b679a4d0-183d-49ba-aa4f-6a1a2d36632a","","",this);
 
            MOHistoricNavigationCommandButton = RPSControlFactory.CreateRPSButton<MaintenanceOrderVMEntityView>( "479a0d54-e117-4184-83b0-67c4a4d00941","","",this);
 
            MaterialStockLocatorNavigationCommandButton = RPSControlFactory.CreateRPSButton<MaintenanceOrderVMEntityView>( "054e909c-dea7-4126-a972-e896cb7f3401","","",this);
 
            ShopfloorDocumentationNavigationCommandButton = RPSControlFactory.CreateRPSButton<MaintenanceOrderVMEntityView>( "7fbc811b-1006-421b-85a8-4929f1df7c4b","","",this);
 
            CollectionInit params_MaintenanceOrderEmployees = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f0fc0a8d-145a-4de4-97f5-f9dd80c103c4",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceOrderEmployees = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceOrderEmployeesCollectionEditor<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView>,MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView>( params_MaintenanceOrderEmployees,this,Screen.MaintenanceOrderMaterialView);
 
            CollectionInit params_OrderMaterialPrevisions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="63cf298c-abfd-4529-b393-ffe70285abb5",CSSSelectorGrid="",XPathGrid=""};
            OrderMaterialPrevisions = RPSControlFactory.RPSCreateCollectionWithGrid<OrderMaterialPrevisionsCollectionEditor<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView>,MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView>( params_OrderMaterialPrevisions,this,Screen.MaintenanceOrderMaterialView);
 
            CollectionInit params_MANMaintenanceOrderMaterials = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="cf5cbc1b-b1a7-4063-b341-1561cc7fede4",CSSSelectorGrid="",XPathGrid=""};
            MANMaintenanceOrderMaterials = RPSControlFactory.RPSCreateCollectionWithGrid<MANMaintenanceOrderMaterialsCollectionEditor<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView>,MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView>( params_MANMaintenanceOrderMaterials,this,Screen.MaintenanceOrderMaterialView);
 
            CollectionInit params_SelectedCharacteristicSamples = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="cf888766-87b8-45e5-834f-d2b26b7ef79c",CSSSelectorGrid="",XPathGrid=""};
            SelectedCharacteristicSamples = RPSControlFactory.RPSCreateCollectionWithGrid<SelectedCharacteristicSamplesCollectionEditor<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView>,MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView>( params_SelectedCharacteristicSamples,this,Screen.MaintenanceOrderMaterialView);
 
            CollectionInit params_MaintenanceOrderDefects = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="617e5428-2cb4-4129-8ec8-18f1fcec05d8",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceOrderDefects = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceOrderDefectsCollectionEditor<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView>,MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView>( params_MaintenanceOrderDefects,this,Screen.MaintenanceOrderMaterialView);
 
            CollectionInit params_MaintenanceOrderCauses = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="110e707d-67a2-4268-b290-e466a87e50a5",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceOrderCauses = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceOrderCausesCollectionEditor<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView>,MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView>( params_MaintenanceOrderCauses,this,Screen.MaintenanceOrderMaterialView);
 
            CollectionInit params_MaintenanceOrderSolutions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="217dd957-3704-4ef3-ae73-9c9d8be7a513",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceOrderSolutions = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceOrderSolutionsCollectionEditor<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView>,MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView>( params_MaintenanceOrderSolutions,this,Screen.MaintenanceOrderMaterialView);
 
            CollectionInit params_MaintenanceOrderPurchaseData = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7147af35-ba47-4510-a808-10570fdffa35",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceOrderPurchaseData = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceOrderPurchaseDataCollectionEditor<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView>,MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView>( params_MaintenanceOrderPurchaseData,this,Screen.MaintenanceOrderMaterialView);
 
            TimeImputations = RPSControlFactory.CreateRPSSection<MaintenanceOrderVMEntityView>( "","ul li[rpsid='5d297ad2-3eb2-4d2d-acf5-1633075d9e14']","",this);
 
            MaterialPrevision = RPSControlFactory.CreateRPSSection<MaintenanceOrderVMEntityView>( "","ul li[rpsid='3a313150-7015-491f-87d8-6adb18d2cd9f']","",this);
 
            Materials = RPSControlFactory.CreateRPSSection<MaintenanceOrderVMEntityView>( "","ul li[rpsid='a2aa7b04-6f45-488c-b8ee-1e54e925d292']","",this);
 
            CharacControl = RPSControlFactory.CreateRPSSection<MaintenanceOrderVMEntityView>( "","ul li[rpsid='e81b4f26-a11f-4521-9369-72a0207b53f9']","",this);
 
            Description1 = RPSControlFactory.CreateRPSSection<MaintenanceOrderVMEntityView>( "","ul li[rpsid='e58614e9-9404-4228-bff7-6fe939012c41']","",this);
 
            ExtraData = RPSControlFactory.CreateRPSSection<MaintenanceOrderVMEntityView>( "","ul li[rpsid='cc00146b-ea13-4800-9ef1-79eacd0e0b27']","",this);
 
            PurchaseAndManufacturing = RPSControlFactory.CreateRPSSection<MaintenanceOrderVMEntityView>( "","ul li[rpsid='dbd06298-9645-43ac-bfe4-917315d61612']","",this);
 

        }
        public IRPSSaveButton<MaintenanceOrderVMEntityView> SaveButton { get; set; } 
        public IRPSButton<MaintenanceOrderVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceOrderVMEntityView,MaintenanceOrderVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceOrderVMEntityView,MaintenanceOrderVMQueryView> BackButton { get; set; } 
        public IRPSOption<MaintenanceOrderVMEntityView> PurchaseProposal { get; set; } 
        public IRPSOption<MaintenanceOrderVMEntityView> ManufacturingOrder { get; set; } 
        public IRPSButton<MaintenanceOrderVMEntityView> ExecuteAddMaintenanceOrderMaterialsPrevisonButton { get; set; } 
        public IRPSButton<MaintenanceOrderVMEntityView,EmployeeValidationDialogView> PurchaseProposalValidationCommandButton { get; set; } 
        public IRPSButton<MaintenanceOrderVMEntityView,NewCharacOfControlDialogView> AddNewCharacOfControl { get; set; } 
        public IRPSButton<MaintenanceOrderVMEntityView> RemoveSelectedCharacOfControl { get; set; } 
        public IRPSButton<MaintenanceOrderVMEntityView> GoToFirstCharac { get; set; } 
        public IRPSButton<MaintenanceOrderVMEntityView> GoToPreviousCharac { get; set; } 
        public IRPSButton<MaintenanceOrderVMEntityView> GoToNextCharac { get; set; } 
        public IRPSButton<MaintenanceOrderVMEntityView> GoToLastCharac { get; set; } 
        public IRPSTextBox<MaintenanceOrderVMEntityView> SelectedCharacValue { get; set; } 
        public IRPSButton<MaintenanceOrderVMEntityView> AddNewSampleValue { get; set; } 
        public IRPSButton<MaintenanceOrderVMEntityView> AddNewSampleValue1 { get; set; } 
        public IRPSButton<MaintenanceOrderVMEntityView> OKSampleCommand { get; set; } 
        public IRPSButton<MaintenanceOrderVMEntityView> NoOKSampleCommand { get; set; } 
        public IRPSTextBox<MaintenanceOrderVMEntityView> SelectedControlFeatureCode { get; set; } 
        public IRPSTextBox<MaintenanceOrderVMEntityView> SelectedControlFeatureDesc { get; set; } 
        public IRPSComboBox<MaintenanceOrderVMEntityView> SelectedControlType { get; set; } 
        public IRPSTextBox<MaintenanceOrderVMEntityView> SelectedMinimumValue { get; set; } 
        public IRPSTextBox<MaintenanceOrderVMEntityView> SelectedMaximumValue { get; set; } 
        public IRPSTextBox<MaintenanceOrderVMEntityView> SelectedAccuracy { get; set; } 
        public IRPSTextBox<MaintenanceOrderVMEntityView> SelectedPrecision { get; set; } 
        public IRPSComboBox<MaintenanceOrderVMEntityView> SelectedIDControlMethod { get; set; } 
        public IRPSComboBox<MaintenanceOrderVMEntityView> SelectedIDTestMethod { get; set; } 
        public IRPSTextBox<MaintenanceOrderVMEntityView> CreationDate { get; set; } 
        public IRPSComboBox<MaintenanceOrderVMEntityView> CodUserCreatedBy { get; set; } 
        public IRPSComboBox<MaintenanceOrderVMEntityView> IDEmployeeReportedBy { get; set; } 
        public IRPSComboBox<MaintenanceOrderVMEntityView> IDEmployeeResponsible { get; set; } 
        public IRPSComboBox<MaintenanceOrderVMEntityView> IDQualifyResponsible { get; set; } 
        public IRPSComboBox<MaintenanceOrderVMEntityView> IDSupplierResponsible { get; set; } 
        public IRPSTextBox<MaintenanceOrderVMEntityView> Description { get; set; } 
        public IRPSTextBox<MaintenanceOrderVMEntityView> Observations { get; set; } 
        public IRPSTextBox<MaintenanceOrderVMEntityView> Notes { get; set; } 
        public IRPSDurationTextBox<MaintenanceOrderVMEntityView> StopTime { get; set; } 
        public IRPSButton<MaintenanceOrderVMEntityView> ChangeEmployeeNavigationCommandButton { get; set; } 
        public IRPSButton<MaintenanceOrderVMEntityView,OMChangeStatusDialogView> OMChangeStatusNavigationCommandButton { get; set; } 
        public IRPSButton<MaintenanceOrderVMEntityView,EmployeeValidationDialogView> StartNavigationCommandButton { get; set; } 
        public IRPSButton<MaintenanceOrderVMEntityView,EmployeeValidationDialogView> EndNavigationCommandButton { get; set; } 
        public IRPSButton<MaintenanceOrderVMEntityView,EmployeeValidationDialogView> TimeValidationNavigationCommandButton { get; set; } 
        public IRPSButton<MaintenanceOrderVMEntityView> TicketRequestNavigationCommandButton { get; set; } 
        public IRPSButton<MaintenanceOrderVMEntityView> MOHistoricNavigationCommandButton { get; set; } 
        public IRPSButton<MaintenanceOrderVMEntityView> MaterialStockLocatorNavigationCommandButton { get; set; } 
        public IRPSButton<MaintenanceOrderVMEntityView> ShopfloorDocumentationNavigationCommandButton { get; set; } 
        public MaintenanceOrderEmployeesCollectionEditor<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView> MaintenanceOrderEmployees { get; set; } 
        public OrderMaterialPrevisionsCollectionEditor<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView> OrderMaterialPrevisions { get; set; } 
        public MANMaintenanceOrderMaterialsCollectionEditor<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView> MANMaintenanceOrderMaterials { get; set; } 
        public SelectedCharacteristicSamplesCollectionEditor<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView> SelectedCharacteristicSamples { get; set; } 
        public MaintenanceOrderDefectsCollectionEditor<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView> MaintenanceOrderDefects { get; set; } 
        public MaintenanceOrderCausesCollectionEditor<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView> MaintenanceOrderCauses { get; set; } 
        public MaintenanceOrderSolutionsCollectionEditor<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView> MaintenanceOrderSolutions { get; set; } 
        public MaintenanceOrderPurchaseDataCollectionEditor<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView> MaintenanceOrderPurchaseData { get; set; } 
        public IRPSSection<MaintenanceOrderVMEntityView> TimeImputations { get; set; } 
        public IRPSSection<MaintenanceOrderVMEntityView> MaterialPrevision { get; set; } 
        public IRPSSection<MaintenanceOrderVMEntityView> Materials { get; set; } 
        public IRPSSection<MaintenanceOrderVMEntityView> CharacControl { get; set; } 
        public IRPSSection<MaintenanceOrderVMEntityView> Description1 { get; set; } 
        public IRPSSection<MaintenanceOrderVMEntityView> ExtraData { get; set; } 
        public IRPSSection<MaintenanceOrderVMEntityView> PurchaseAndManufacturing { get; set; } 
        public WorkOrdersFollowUp Screen { get; set; }
        public MaintenanceOrderVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaintenanceOrderEmployeesCollectionEditor<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView>:RPSCollectionEditor<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView> where MaintenanceOrderVMEntityView : class, IView where MaintenanceOrderMaterialView : class, IView
    {
        public  MaintenanceOrderEmployeesGridView<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView> GridView {get;set;}
    }
    public partial class MaintenanceOrderEmployeesGridView <MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView> :  RPSGridView<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView> where MaintenanceOrderVMEntityView : class, IView where MaintenanceOrderMaterialView : class, IView
    {
        public MaintenanceOrderEmployeesGridView(MaintenanceOrderVMEntityView currentView,MaintenanceOrderMaterialView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeleteImputationCommand = RPSControlFactory.CreateRPSGridButton<MaintenanceOrderVMEntityView>( "","#f0fc0a8d-145a-4de4-97f5-f9dd80c103c4 .ag-row[role='row']@ROWINDEX [col-id='cDeleteImputationCommand']","",this.CurrentView);
 
            IDEmployee = RPSControlFactory.CreateRPSGridComboBox<MaintenanceOrderVMEntityView>("","#f0fc0a8d-145a-4de4-97f5-f9dd80c103c4 .ag-row[role='row']@ROWINDEX [col-id='cIDEmployee']","",true, this.CurrentView);
 
            InitialDate = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderVMEntityView>("","#f0fc0a8d-145a-4de4-97f5-f9dd80c103c4 .ag-row[role='row']@ROWINDEX [col-id='cInitialDate']","",false, this.CurrentView);
 
            InitialTime = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderVMEntityView>("","#f0fc0a8d-145a-4de4-97f5-f9dd80c103c4 .ag-row[role='row']@ROWINDEX [col-id='cInitialTime']","",false, this.CurrentView);
 
            FinalDate = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderVMEntityView>("","#f0fc0a8d-145a-4de4-97f5-f9dd80c103c4 .ag-row[role='row']@ROWINDEX [col-id='cFinalDate']","",false, this.CurrentView);
 
            FinalTime = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderVMEntityView>("","#f0fc0a8d-145a-4de4-97f5-f9dd80c103c4 .ag-row[role='row']@ROWINDEX [col-id='cFinalTime']","",false, this.CurrentView);
 
            Duration = RPSControlFactory.CreateRPSGridDurationTextBox<MaintenanceOrderVMEntityView>("","#f0fc0a8d-145a-4de4-97f5-f9dd80c103c4 .ag-row[role='row']@ROWINDEX [col-id='cDuration']","",true, this.CurrentView);
 
            Comments = RPSControlFactory.CreateRPSGridMemoTextBox<MaintenanceOrderVMEntityView>("","#f0fc0a8d-145a-4de4-97f5-f9dd80c103c4 .ag-row[role='row']@ROWINDEX [col-id='cComments']","",false, this.CurrentView);
 

        }
        public IRPSGridButton<MaintenanceOrderVMEntityView> DeleteImputationCommand { get; set; } 
        public IRPSGridComboBox<MaintenanceOrderVMEntityView> IDEmployee { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderVMEntityView> InitialDate { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderVMEntityView> InitialTime { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderVMEntityView> FinalDate { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderVMEntityView> FinalTime { get; set; } 
        public IRPSGridDurationTextBox<MaintenanceOrderVMEntityView> Duration { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderVMEntityView> Comments { get; set; } 
                     
    }
 
        public partial class OrderMaterialPrevisionsCollectionEditor<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView>:RPSCollectionEditor<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView> where MaintenanceOrderVMEntityView : class, IView where MaintenanceOrderMaterialView : class, IView
    {
        public  OrderMaterialPrevisionsGridView<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView> GridView {get;set;}
    }
    public partial class OrderMaterialPrevisionsGridView <MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView> :  RPSGridView<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView> where MaintenanceOrderVMEntityView : class, IView where MaintenanceOrderMaterialView : class, IView
    {
        public OrderMaterialPrevisionsGridView(MaintenanceOrderVMEntityView currentView,MaintenanceOrderMaterialView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<MaintenanceOrderVMEntityView>("","#63cf298c-abfd-4529-b393-ffe70285abb5 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderVMEntityView>("","#63cf298c-abfd-4529-b393-ffe70285abb5 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            IDSite = RPSControlFactory.CreateRPSGridComboBox<MaintenanceOrderVMEntityView>("","#63cf298c-abfd-4529-b393-ffe70285abb5 .ag-row[role='row']@ROWINDEX [col-id='cIDSite']","",false, this.CurrentView);
 
            IDWareHouse = RPSControlFactory.CreateRPSGridComboBox<MaintenanceOrderVMEntityView>("","#63cf298c-abfd-4529-b393-ffe70285abb5 .ag-row[role='row']@ROWINDEX [col-id='cIDWareHouse']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenanceOrderVMEntityView>("","#63cf298c-abfd-4529-b393-ffe70285abb5 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            QuantityImputed = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenanceOrderVMEntityView>("","#63cf298c-abfd-4529-b393-ffe70285abb5 .ag-row[role='row']@ROWINDEX [col-id='cQuantityImputed']","",true, this.CurrentView);
 
            PriceCost = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenanceOrderVMEntityView>("","#63cf298c-abfd-4529-b393-ffe70285abb5 .ag-row[role='row']@ROWINDEX [col-id='cPriceCost']","",true, this.CurrentView);
 
            MakeMovement = RPSControlFactory.CreateRPSGridCheckBox<MaintenanceOrderVMEntityView>("","#63cf298c-abfd-4529-b393-ffe70285abb5 .ag-row[role='row']@ROWINDEX [col-id='cMakeMovement']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<MaintenanceOrderVMEntityView> IDArticle { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderVMEntityView> Description { get; set; } 
        public IRPSGridComboBox<MaintenanceOrderVMEntityView> IDSite { get; set; } 
        public IRPSGridComboBox<MaintenanceOrderVMEntityView> IDWareHouse { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderVMEntityView> Quantity { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderVMEntityView> QuantityImputed { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderVMEntityView> PriceCost { get; set; } 
        public IRPSGridCheckbox<MaintenanceOrderVMEntityView> MakeMovement { get; set; } 
                     
    }
 
        public partial class MANMaintenanceOrderMaterialsCollectionEditor<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView>:RPSCollectionEditor<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView> where MaintenanceOrderVMEntityView : class, IView where MaintenanceOrderMaterialView : class, IView
    {
        public  MANMaintenanceOrderMaterialsGridView<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView> GridView {get;set;}
    }
    public partial class MANMaintenanceOrderMaterialsGridView <MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView> :  RPSGridView<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView> where MaintenanceOrderVMEntityView : class, IView where MaintenanceOrderMaterialView : class, IView
    {
        public MANMaintenanceOrderMaterialsGridView(MaintenanceOrderVMEntityView currentView,MaintenanceOrderMaterialView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<MaintenanceOrderVMEntityView>("","#cf5cbc1b-b1a7-4063-b341-1561cc7fede4 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            IDSite = RPSControlFactory.CreateRPSGridComboBox<MaintenanceOrderVMEntityView>("","#cf5cbc1b-b1a7-4063-b341-1561cc7fede4 .ag-row[role='row']@ROWINDEX [col-id='cIDSite']","",false, this.CurrentView);
 
            IDWarehouse = RPSControlFactory.CreateRPSGridComboBox<MaintenanceOrderVMEntityView>("","#cf5cbc1b-b1a7-4063-b341-1561cc7fede4 .ag-row[role='row']@ROWINDEX [col-id='cIDWarehouse']","",false, this.CurrentView);
 
            Series = RPSControlFactory.CreateRPSGridEnumComboBox<MaintenanceOrderVMEntityView>("","#cf5cbc1b-b1a7-4063-b341-1561cc7fede4 .ag-row[role='row']@ROWINDEX [col-id='cSeries']","",false, this.CurrentView);
 
            IDLocationWarehouse = RPSControlFactory.CreateRPSGridComboBox<MaintenanceOrderVMEntityView>("","#cf5cbc1b-b1a7-4063-b341-1561cc7fede4 .ag-row[role='row']@ROWINDEX [col-id='cIDLocationWarehouse']","",false, this.CurrentView);
 
            Date = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderVMEntityView>("","#cf5cbc1b-b1a7-4063-b341-1561cc7fede4 .ag-row[role='row']@ROWINDEX [col-id='cDate']","",true, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenanceOrderVMEntityView>("","#cf5cbc1b-b1a7-4063-b341-1561cc7fede4 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            Comments = RPSControlFactory.CreateRPSGridMemoTextBox<MaintenanceOrderVMEntityView>("","#cf5cbc1b-b1a7-4063-b341-1561cc7fede4 .ag-row[role='row']@ROWINDEX [col-id='cComments']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<MaintenanceOrderVMEntityView> IDArticle { get; set; } 
        public IRPSGridComboBox<MaintenanceOrderVMEntityView> IDSite { get; set; } 
        public IRPSGridComboBox<MaintenanceOrderVMEntityView> IDWarehouse { get; set; } 
        public IRPSGridComboBox<MaintenanceOrderVMEntityView> Series { get; set; } 
        public IRPSGridComboBox<MaintenanceOrderVMEntityView> IDLocationWarehouse { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderVMEntityView> Date { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderVMEntityView> Quantity { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderVMEntityView> Comments { get; set; } 
                     
    }
 
        public partial class SelectedCharacteristicSamplesCollectionEditor<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView>:RPSCollectionEditor<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView> where MaintenanceOrderVMEntityView : class, IView where MaintenanceOrderMaterialView : class, IView
    {
        public  SelectedCharacteristicSamplesGridView<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView> GridView {get;set;}
    }
    public partial class SelectedCharacteristicSamplesGridView <MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView> :  RPSGridView<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView> where MaintenanceOrderVMEntityView : class, IView where MaintenanceOrderMaterialView : class, IView
    {
        public SelectedCharacteristicSamplesGridView(MaintenanceOrderVMEntityView currentView,MaintenanceOrderMaterialView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeleteCommand = RPSControlFactory.CreateRPSGridButton<MaintenanceOrderVMEntityView>( "","#cf888766-87b8-45e5-834f-d2b26b7ef79c .ag-row[role='row']@ROWINDEX [col-id='cDeleteCommand']","",this.CurrentView);
 
            CaptureSequence = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenanceOrderVMEntityView>("","#cf888766-87b8-45e5-834f-d2b26b7ef79c .ag-row[role='row']@ROWINDEX [col-id='cCaptureSequence']","",true, this.CurrentView);
 
            IDEmployee = RPSControlFactory.CreateRPSGridComboBox<MaintenanceOrderVMEntityView>("","#cf888766-87b8-45e5-834f-d2b26b7ef79c .ag-row[role='row']@ROWINDEX [col-id='cIDEmployee']","",false, this.CurrentView);
 
            CaptureDate = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderVMEntityView>("","#cf888766-87b8-45e5-834f-d2b26b7ef79c .ag-row[role='row']@ROWINDEX [col-id='cCaptureDate']","",false, this.CurrentView);
 
            CaptureTime = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderVMEntityView>("","#cf888766-87b8-45e5-834f-d2b26b7ef79c .ag-row[role='row']@ROWINDEX [col-id='cCaptureTime']","",false, this.CurrentView);
 
            Value = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenanceOrderVMEntityView>("","#cf888766-87b8-45e5-834f-d2b26b7ef79c .ag-row[role='row']@ROWINDEX [col-id='cValue']","",true, this.CurrentView);
 
            OKorNOK = RPSControlFactory.CreateRPSGridEnumComboBox<MaintenanceOrderVMEntityView>("","#cf888766-87b8-45e5-834f-d2b26b7ef79c .ag-row[role='row']@ROWINDEX [col-id='cOKorNOK']","",true, this.CurrentView);
 
            Comment = RPSControlFactory.CreateRPSGridMemoTextBox<MaintenanceOrderVMEntityView>("","#cf888766-87b8-45e5-834f-d2b26b7ef79c .ag-row[role='row']@ROWINDEX [col-id='cComment']","",false, this.CurrentView);
 

        }
        public IRPSGridButton<MaintenanceOrderVMEntityView> DeleteCommand { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderVMEntityView> CaptureSequence { get; set; } 
        public IRPSGridComboBox<MaintenanceOrderVMEntityView> IDEmployee { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderVMEntityView> CaptureDate { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderVMEntityView> CaptureTime { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderVMEntityView> Value { get; set; } 
        public IRPSGridComboBox<MaintenanceOrderVMEntityView> OKorNOK { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderVMEntityView> Comment { get; set; } 
                     
    }
 
        public partial class MaintenanceOrderDefectsCollectionEditor<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView>:RPSCollectionEditor<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView> where MaintenanceOrderVMEntityView : class, IView where MaintenanceOrderMaterialView : class, IView
    {
        public  MaintenanceOrderDefectsGridView<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView> GridView {get;set;}
    }
    public partial class MaintenanceOrderDefectsGridView <MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView> :  RPSGridView<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView> where MaintenanceOrderVMEntityView : class, IView where MaintenanceOrderMaterialView : class, IView
    {
        public MaintenanceOrderDefectsGridView(MaintenanceOrderVMEntityView currentView,MaintenanceOrderMaterialView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDMaintenanceDefect = RPSControlFactory.CreateRPSGridComboBox<MaintenanceOrderVMEntityView>("","#617e5428-2cb4-4129-8ec8-18f1fcec05d8 .ag-row[role='row']@ROWINDEX [col-id='cIDMaintenanceDefect']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderVMEntityView>("","#617e5428-2cb4-4129-8ec8-18f1fcec05d8 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<MaintenanceOrderVMEntityView> IDMaintenanceDefect { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderVMEntityView> Description { get; set; } 
                     
    }
 
        public partial class MaintenanceOrderCausesCollectionEditor<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView>:RPSCollectionEditor<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView> where MaintenanceOrderVMEntityView : class, IView where MaintenanceOrderMaterialView : class, IView
    {
        public  MaintenanceOrderCausesGridView<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView> GridView {get;set;}
    }
    public partial class MaintenanceOrderCausesGridView <MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView> :  RPSGridView<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView> where MaintenanceOrderVMEntityView : class, IView where MaintenanceOrderMaterialView : class, IView
    {
        public MaintenanceOrderCausesGridView(MaintenanceOrderVMEntityView currentView,MaintenanceOrderMaterialView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDMaintenanceCause = RPSControlFactory.CreateRPSGridComboBox<MaintenanceOrderVMEntityView>("","#110e707d-67a2-4268-b290-e466a87e50a5 .ag-row[role='row']@ROWINDEX [col-id='cIDMaintenanceCause']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderVMEntityView>("","#110e707d-67a2-4268-b290-e466a87e50a5 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<MaintenanceOrderVMEntityView> IDMaintenanceCause { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderVMEntityView> Description { get; set; } 
                     
    }
 
        public partial class MaintenanceOrderSolutionsCollectionEditor<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView>:RPSCollectionEditor<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView> where MaintenanceOrderVMEntityView : class, IView where MaintenanceOrderMaterialView : class, IView
    {
        public  MaintenanceOrderSolutionsGridView<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView> GridView {get;set;}
    }
    public partial class MaintenanceOrderSolutionsGridView <MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView> :  RPSGridView<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView> where MaintenanceOrderVMEntityView : class, IView where MaintenanceOrderMaterialView : class, IView
    {
        public MaintenanceOrderSolutionsGridView(MaintenanceOrderVMEntityView currentView,MaintenanceOrderMaterialView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDMaintenanceSolution = RPSControlFactory.CreateRPSGridComboBox<MaintenanceOrderVMEntityView>("","#217dd957-3704-4ef3-ae73-9c9d8be7a513 .ag-row[role='row']@ROWINDEX [col-id='cIDMaintenanceSolution']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderVMEntityView>("","#217dd957-3704-4ef3-ae73-9c9d8be7a513 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<MaintenanceOrderVMEntityView> IDMaintenanceSolution { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderVMEntityView> Description { get; set; } 
                     
    }
 
        public partial class MaintenanceOrderPurchaseDataCollectionEditor<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView>:RPSCollectionEditor<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView> where MaintenanceOrderVMEntityView : class, IView where MaintenanceOrderMaterialView : class, IView
    {
        public  MaintenanceOrderPurchaseDataGridView<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView> GridView {get;set;}
    }
    public partial class MaintenanceOrderPurchaseDataGridView <MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView> :  RPSGridView<MaintenanceOrderVMEntityView,MaintenanceOrderMaterialView> where MaintenanceOrderVMEntityView : class, IView where MaintenanceOrderMaterialView : class, IView
    {
        public MaintenanceOrderPurchaseDataGridView(MaintenanceOrderVMEntityView currentView,MaintenanceOrderMaterialView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DataType = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderVMEntityView>("","#7147af35-ba47-4510-a808-10570fdffa35 .ag-row[role='row']@ROWINDEX [col-id='cDataType']","",false, this.CurrentView);
 
            ReceptionDate = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderVMEntityView>("","#7147af35-ba47-4510-a808-10570fdffa35 .ag-row[role='row']@ROWINDEX [col-id='cReceptionDate']","",false, this.CurrentView);
 
            Status = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderVMEntityView>("","#7147af35-ba47-4510-a808-10570fdffa35 .ag-row[role='row']@ROWINDEX [col-id='cStatus']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderVMEntityView>("","#7147af35-ba47-4510-a808-10570fdffa35 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Comment = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderVMEntityView>("","#7147af35-ba47-4510-a808-10570fdffa35 .ag-row[role='row']@ROWINDEX [col-id='cComment']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MaintenanceOrderVMEntityView> DataType { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderVMEntityView> ReceptionDate { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderVMEntityView> Status { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderVMEntityView> Description { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderVMEntityView> Comment { get; set; } 
                     
    }
 
    }
  
            
    public partial class StatusLegendDialogView : View
    {
        public StatusLegendDialogView(WorkOrdersFollowUp screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_MaintenanceOrderStatusShopfloorCMMS = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c7939a86-7747-40d6-b5dc-46ab93a7cd20",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceOrderStatusShopfloorCMMS = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceOrderStatusShopfloorCMMSCollectionEditor<StatusLegendDialogView>,StatusLegendDialogView>( params_MaintenanceOrderStatusShopfloorCMMS,this);
 

        }
        public MaintenanceOrderStatusShopfloorCMMSCollectionEditor<StatusLegendDialogView> MaintenanceOrderStatusShopfloorCMMS { get; set; } 
        public WorkOrdersFollowUp Screen { get; set; }
        public StatusLegendDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaintenanceOrderStatusShopfloorCMMSCollectionEditor<StatusLegendDialogView>:RPSCollectionEditor<StatusLegendDialogView> where StatusLegendDialogView : class, IView
    {
        public  MaintenanceOrderStatusShopfloorCMMSGridView<StatusLegendDialogView> GridView {get;set;}
    }
    public partial class MaintenanceOrderStatusShopfloorCMMSGridView <StatusLegendDialogView> :  RPSGridView<StatusLegendDialogView> where StatusLegendDialogView : class, IView
    {
        public MaintenanceOrderStatusShopfloorCMMSGridView(StatusLegendDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MaintenanceOrderStatus_CodStatus = RPSControlFactory.CreateRPSGridTextBox<StatusLegendDialogView>("","#c7939a86-7747-40d6-b5dc-46ab93a7cd20 .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceOrderStatus_CodStatus']","",false, this.CurrentView);
 
            MaintenanceOrderStatus_Description = RPSControlFactory.CreateRPSGridTextBox<StatusLegendDialogView>("","#c7939a86-7747-40d6-b5dc-46ab93a7cd20 .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceOrderStatus_Description']","",false, this.CurrentView);
 
            MaintenanceOrderStatus_ShowInShopfloorCMMS = RPSControlFactory.CreateRPSGridCheckBox<StatusLegendDialogView>("","#c7939a86-7747-40d6-b5dc-46ab93a7cd20 .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceOrderStatus_ShowInShopfloorCMMS']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<StatusLegendDialogView> MaintenanceOrderStatus_CodStatus { get; set; } 
        public IRPSGridTextBox<StatusLegendDialogView> MaintenanceOrderStatus_Description { get; set; } 
        public IRPSGridCheckbox<StatusLegendDialogView> MaintenanceOrderStatus_ShowInShopfloorCMMS { get; set; } 
                     
    }
 
    }
  
            
    public partial class NewOTDialogView : View
    {
        public NewOTDialogView(WorkOrdersFollowUp screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIDlgOrderExecutionDate = RPSControlFactory.CreateRPSTextBox<NewOTDialogView>("16471ee5-4552-4fbd-abd8-260b7db17dae","","",true, this);
 
            UIDlgOrderExecutionTime = RPSControlFactory.CreateRPSTextBox<NewOTDialogView>("153409d4-1410-4f15-9084-3b9c5ac0e3c7","","",false, this);
 
            UIDlgOrderDurationTime = RPSControlFactory.CreateRPSDurationTextBox<NewOTDialogView>("5c102b81-9359-4162-800b-f6e6f92d681a","","",true, this);
 
            IDTerminal = RPSControlFactory.CreateRPSComboBox<NewOTDialogView>("54798117-ec06-4a2b-b983-e4af48d1e17d","","",false, this);
 
            IDMaintenanceComponent = RPSControlFactory.CreateRPSComboBox<NewOTDialogView>("9af40063-35e8-4278-86cf-a3e2321048ea","","",true, this);
 
            UIDlgOrderMaintenanceType = RPSControlFactory.CreateRPSComboBox<NewOTDialogView>("6942b4a5-ff2e-46e7-96ad-ae9208be3456","","",true, this);
 
            UIDlgOrderResponsibleType = RPSControlFactory.CreateRPSEnumComboBox<NewOTDialogView>("5a376f43-d5b1-4fb9-b3b7-80cc9b32bad0","","",false, this);
 
            UIDlgOrderQualify = RPSControlFactory.CreateRPSComboBox<NewOTDialogView>("d7f42255-f713-496f-9ad9-9753994165aa","","",true, this);
 
            UIDlgOrderMaintenanceType1 = RPSControlFactory.CreateRPSComboBox<NewOTDialogView>("332cda6d-b010-4f37-9bb3-57199ee6c28a","","",true, this);
 
            UIDlgOrderResponsibleType1 = RPSControlFactory.CreateRPSEnumComboBox<NewOTDialogView>("e227fa21-8948-4cb7-9156-4cb2664ba016","","",false, this);
 
            UIDlgOrderEmployee = RPSControlFactory.CreateRPSComboBox<NewOTDialogView>("1493be64-966e-4b64-9083-221d9ad0a3f7","","",true, this);
 
            UIDlgOrderMaintenanceType2 = RPSControlFactory.CreateRPSComboBox<NewOTDialogView>("f4957911-3308-4199-9eff-94e1e5bb154a","","",true, this);
 
            UIDlgOrderResponsibleType2 = RPSControlFactory.CreateRPSEnumComboBox<NewOTDialogView>("811db794-b7d4-4130-97e3-f7a09569f8bd","","",false, this);
 
            UIDlgOrderSupplier = RPSControlFactory.CreateRPSComboBox<NewOTDialogView>("8ec45547-81b0-43c0-a10f-14d272761774","","",true, this);
 
            OTDescription = RPSControlFactory.CreateRPSTextBox<NewOTDialogView>("30c3fb2c-1a93-4602-8095-05642f80e290","","",false, this);
 

        }
        public IRPSTextBox<NewOTDialogView> UIDlgOrderExecutionDate { get; set; } 
        public IRPSTextBox<NewOTDialogView> UIDlgOrderExecutionTime { get; set; } 
        public IRPSDurationTextBox<NewOTDialogView> UIDlgOrderDurationTime { get; set; } 
        public IRPSComboBox<NewOTDialogView> IDTerminal { get; set; } 
        public IRPSComboBox<NewOTDialogView> IDMaintenanceComponent { get; set; } 
        public IRPSComboBox<NewOTDialogView> UIDlgOrderMaintenanceType { get; set; } 
        public IRPSComboBox<NewOTDialogView> UIDlgOrderResponsibleType { get; set; } 
        public IRPSComboBox<NewOTDialogView> UIDlgOrderQualify { get; set; } 
        public IRPSComboBox<NewOTDialogView> UIDlgOrderMaintenanceType1 { get; set; } 
        public IRPSComboBox<NewOTDialogView> UIDlgOrderResponsibleType1 { get; set; } 
        public IRPSComboBox<NewOTDialogView> UIDlgOrderEmployee { get; set; } 
        public IRPSComboBox<NewOTDialogView> UIDlgOrderMaintenanceType2 { get; set; } 
        public IRPSComboBox<NewOTDialogView> UIDlgOrderResponsibleType2 { get; set; } 
        public IRPSComboBox<NewOTDialogView> UIDlgOrderSupplier { get; set; } 
        public IRPSTextBox<NewOTDialogView> OTDescription { get; set; } 
        public WorkOrdersFollowUp Screen { get; set; }
        public NewOTDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenanceOrderMaterialView : View
    {
        public MaintenanceOrderMaterialView(WorkOrdersFollowUp screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceOrderMaterialView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceOrderMaterialView,MaintenanceOrderVMEntityView>( this,Screen.MaintenanceOrderVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceOrderMaterialView,MaintenanceOrderVMEntityView>( this,Screen.MaintenanceOrderVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MaintenanceOrderMaterialView,MaintenanceOrderVMEntityView>( this,Screen.MaintenanceOrderVMEntityView);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderMaterialView>("7990df33-a4c2-4994-9e3c-582f69fbbd8a","","",true, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderMaterialView>("53baed3c-55c8-45d9-ad60-8f67b52638ef","","",false, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderMaterialView>("13e477e8-caf6-406d-8be4-71d8e806378c","","",false, this);
 
            Series = RPSControlFactory.CreateRPSEnumComboBox<MaintenanceOrderMaterialView>("163aeaba-5c89-4859-a872-72c8475ff5ed","","",false, this);
 
            IDLocationWarehouse = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderMaterialView>("136fb920-ef87-4e42-a2f8-dd7d16b0cff9","","",false, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderMaterialView>("754f85db-269a-42d5-aad5-c4ace7cddb38","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceOrderMaterialView>("79701aa9-c775-46ab-bd2a-044f0509c2a5","","",true, this);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceOrderMaterialView>("8140b79f-16c8-4bcf-9adc-a5f746a169bc","","",false, this);
 
            UnitCost = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceOrderMaterialView>("9e53f271-5e52-43a3-a6f1-e686ab67de5f","","",true, this);
 
            Cost = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceOrderMaterialView>("7f783f38-e5d8-4e9f-8885-5eecf3eeea26","","",true, this);
 
            MakeMovement = RPSControlFactory.CreateRPSCheckBox<MaintenanceOrderMaterialView>("113f8ee5-7a9c-4907-a7c3-37cabd569655","","",true, this);
 
            ExecuteAppendTechnicalDescriptionToComment = RPSControlFactory.CreateRPSButton<MaintenanceOrderMaterialView>( "34248728-f96b-4dd7-9572-9ccbd1c2f80b","","",this);
 
            Comments = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderMaterialView>("76aa1dc3-7b6f-44c0-9fb9-5aac8dcf8a09","","",false, this);
 
            GeneralData = RPSControlFactory.CreateRPSSection<MaintenanceOrderMaterialView>( "","ul li[rpsid='8a377ab8-5ac1-4138-bc2b-60d94bec3784']","",this);
 
            Comments1 = RPSControlFactory.CreateRPSSection<MaintenanceOrderMaterialView>( "","ul li[rpsid='a0100ec7-536e-498e-8236-8074cd7adb26']","",this);
 

        }
        public IRPSButton<MaintenanceOrderMaterialView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceOrderMaterialView,MaintenanceOrderVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceOrderMaterialView,MaintenanceOrderVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<MaintenanceOrderMaterialView,MaintenanceOrderVMEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<MaintenanceOrderMaterialView> IDArticle { get; set; } 
        public IRPSComboBox<MaintenanceOrderMaterialView> IDSite { get; set; } 
        public IRPSComboBox<MaintenanceOrderMaterialView> IDWarehouse { get; set; } 
        public IRPSComboBox<MaintenanceOrderMaterialView> Series { get; set; } 
        public IRPSComboBox<MaintenanceOrderMaterialView> IDLocationWarehouse { get; set; } 
        public IRPSTextBox<MaintenanceOrderMaterialView> Date { get; set; } 
        public IRPSTextBox<MaintenanceOrderMaterialView> Quantity { get; set; } 
        public IRPSTextBox<MaintenanceOrderMaterialView> QuantitySecondUnit { get; set; } 
        public IRPSTextBox<MaintenanceOrderMaterialView> UnitCost { get; set; } 
        public IRPSTextBox<MaintenanceOrderMaterialView> Cost { get; set; } 
        public IRPSCheckbox<MaintenanceOrderMaterialView> MakeMovement { get; set; } 
        public IRPSButton<MaintenanceOrderMaterialView> ExecuteAppendTechnicalDescriptionToComment { get; set; } 
        public IRPSTextBox<MaintenanceOrderMaterialView> Comments { get; set; } 
        public IRPSSection<MaintenanceOrderMaterialView> GeneralData { get; set; } 
        public IRPSSection<MaintenanceOrderMaterialView> Comments1 { get; set; } 
        public WorkOrdersFollowUp Screen { get; set; }
        public MaintenanceOrderMaterialView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NewCharacOfControlDialogView : View
    {
        public NewCharacOfControlDialogView(WorkOrdersFollowUp screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ControlFeatureCode = RPSControlFactory.CreateRPSTextBox<NewCharacOfControlDialogView>("3c4121cc-0468-4510-9112-27338dd48a7d","","",true, this);
 
            ControlFeatureDesc = RPSControlFactory.CreateRPSTextBox<NewCharacOfControlDialogView>("3f83406c-80a2-4e22-b8fb-3f9a02c3f667","","",false, this);
 
            ControlType = RPSControlFactory.CreateRPSEnumComboBox<NewCharacOfControlDialogView>("14ff1831-06d4-4f08-84da-50f13b370b1f","","",true, this);
 
            MinimumValue = RPSControlFactory.CreateRPSFormattedTextBox<NewCharacOfControlDialogView>("c13209ab-779a-4045-8bbf-61cbbb8585d7","","",true, this);
 
            MaximumValue = RPSControlFactory.CreateRPSFormattedTextBox<NewCharacOfControlDialogView>("10bf0f55-6a6c-401d-9df8-79d038270315","","",true, this);
 
            Accuracy = RPSControlFactory.CreateRPSTextBox<NewCharacOfControlDialogView>("7412235b-1c15-4e6a-9c1d-e76247e4d81a","","",false, this);
 
            Precision = RPSControlFactory.CreateRPSTextBox<NewCharacOfControlDialogView>("78e93d7e-aadd-4292-af6a-1319aca3da5a","","",false, this);
 
            IDControlMethod = RPSControlFactory.CreateRPSComboBox<NewCharacOfControlDialogView>("764ec15f-96e1-4a92-8d22-abd1ea68d674","","",false, this);
 
            IDTestMethod = RPSControlFactory.CreateRPSComboBox<NewCharacOfControlDialogView>("5fd0378f-e14e-4ea7-ae52-9130238c6676","","",false, this);
 

        }
        public IRPSTextBox<NewCharacOfControlDialogView> ControlFeatureCode { get; set; } 
        public IRPSTextBox<NewCharacOfControlDialogView> ControlFeatureDesc { get; set; } 
        public IRPSComboBox<NewCharacOfControlDialogView> ControlType { get; set; } 
        public IRPSTextBox<NewCharacOfControlDialogView> MinimumValue { get; set; } 
        public IRPSTextBox<NewCharacOfControlDialogView> MaximumValue { get; set; } 
        public IRPSTextBox<NewCharacOfControlDialogView> Accuracy { get; set; } 
        public IRPSTextBox<NewCharacOfControlDialogView> Precision { get; set; } 
        public IRPSComboBox<NewCharacOfControlDialogView> IDControlMethod { get; set; } 
        public IRPSComboBox<NewCharacOfControlDialogView> IDTestMethod { get; set; } 
        public WorkOrdersFollowUp Screen { get; set; }
        public NewCharacOfControlDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OMChangeStatusDialogView : View
    {
        public OMChangeStatusDialogView(WorkOrdersFollowUp screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDMaintenanceOrderStatus = RPSControlFactory.CreateRPSComboBox<OMChangeStatusDialogView>("03c9f6a5-5b28-41d3-a48c-7072ac46465e","","",true, this);
 
            IDMaintenanceOrderStatusDestination = RPSControlFactory.CreateRPSComboBox<OMChangeStatusDialogView>("bb72c604-8248-46e1-80a2-fa1452d5331f","","",false, this);
 
            ClosingDate = RPSControlFactory.CreateRPSTextBox<OMChangeStatusDialogView>("e00f518e-03e1-462c-b98e-502ac222aa6f","","",false, this);
 
            ClosingTime = RPSControlFactory.CreateRPSTextBox<OMChangeStatusDialogView>("f443fa88-fd09-471e-9a74-d0ca72e1bf71","","",false, this);
 

        }
        public IRPSComboBox<OMChangeStatusDialogView> IDMaintenanceOrderStatus { get; set; } 
        public IRPSComboBox<OMChangeStatusDialogView> IDMaintenanceOrderStatusDestination { get; set; } 
        public IRPSTextBox<OMChangeStatusDialogView> ClosingDate { get; set; } 
        public IRPSTextBox<OMChangeStatusDialogView> ClosingTime { get; set; } 
        public WorkOrdersFollowUp Screen { get; set; }
        public OMChangeStatusDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class EmployeeValidationDialogView : View
    {
        public EmployeeValidationDialogView(WorkOrdersFollowUp screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDEmployee = RPSControlFactory.CreateRPSComboBox<EmployeeValidationDialogView>("fc73ab9d-a072-4821-abda-72813104af93","","",false, this);
 
            PassWord = RPSControlFactory.CreateRPSTextBox<EmployeeValidationDialogView>("24007462-8047-450c-b7d2-e4b239f8354f","","",true, this);
 

        }
        public IRPSComboBox<EmployeeValidationDialogView> IDEmployee { get; set; } 
        public IRPSTextBox<EmployeeValidationDialogView> PassWord { get; set; } 
        public WorkOrdersFollowUp Screen { get; set; }
        public EmployeeValidationDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class TimeDialogView : View
    {
        public TimeDialogView(WorkOrdersFollowUp screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            InitialDate = RPSControlFactory.CreateRPSTextBox<TimeDialogView>("34ef2b52-1c60-4477-bca8-44225792697d","","",true, this);
 
            InitialTime = RPSControlFactory.CreateRPSTextBox<TimeDialogView>("3d04f186-44ab-4750-9f79-1d30665125ef","","",true, this);
 
            FinalDate = RPSControlFactory.CreateRPSTextBox<TimeDialogView>("1cbcb41f-ba48-4a87-a350-a29322b39862","","",true, this);
 
            FinalTime = RPSControlFactory.CreateRPSTextBox<TimeDialogView>("49d6a153-3bd1-4da9-9d16-71244970496d","","",true, this);
 
            Comments = RPSControlFactory.CreateRPSTextBox<TimeDialogView>("622ca36f-62cf-40fa-93ec-75e6777de28c","","",false, this);
 

        }
        public IRPSTextBox<TimeDialogView> InitialDate { get; set; } 
        public IRPSTextBox<TimeDialogView> InitialTime { get; set; } 
        public IRPSTextBox<TimeDialogView> FinalDate { get; set; } 
        public IRPSTextBox<TimeDialogView> FinalTime { get; set; } 
        public IRPSTextBox<TimeDialogView> Comments { get; set; } 
        public WorkOrdersFollowUp Screen { get; set; }
        public TimeDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OrderMaterialPrevisionView : View
    {
        public OrderMaterialPrevisionView(WorkOrdersFollowUp screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<OrderMaterialPrevisionView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<OrderMaterialPrevisionView,MaintenanceOrderVMEntityView>( this,Screen.MaintenanceOrderVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<OrderMaterialPrevisionView,MaintenanceOrderVMEntityView>( this,Screen.MaintenanceOrderVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<OrderMaterialPrevisionView,MaintenanceOrderVMEntityView>( this,Screen.MaintenanceOrderVMEntityView);
 
            PurchaseProposal = RPSControlFactory.CreateRPSOption<OrderMaterialPrevisionView>( "c499b483-6a7b-440e-a8b4-45887972886f","","",this);
 
            ManufacturingOrder = RPSControlFactory.CreateRPSOption<OrderMaterialPrevisionView>( "31230084-729d-47df-b175-3b2d8eff85f3","","",this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<OrderMaterialPrevisionView>("c60053db-b185-4a56-ad1c-a1f32038795b","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<OrderMaterialPrevisionView>("5debe338-fd5c-4a2b-99dc-a28b9b17a1b4","","",false, this);
 
            PriceCost = RPSControlFactory.CreateRPSFormattedTextBox<OrderMaterialPrevisionView>("0e888f9e-7333-4ff3-b88c-4f9e0b28f7ac","","",true, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<OrderMaterialPrevisionView>("c98c2be8-3c3b-4aef-8f7b-a8647149a672","","",false, this);
 
            IDWareHouse = RPSControlFactory.CreateRPSComboBox<OrderMaterialPrevisionView>("b404c8e0-c254-4534-8c0f-53bfc6252b00","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<OrderMaterialPrevisionView>("a20db1d6-c18c-427e-b056-faaf8ad2b328","","",true, this);
 
            QuantityImputed = RPSControlFactory.CreateRPSFormattedTextBox<OrderMaterialPrevisionView>("64454f44-8234-4261-a787-091c00728694","","",true, this);
 
            MakeMovement = RPSControlFactory.CreateRPSCheckBox<OrderMaterialPrevisionView>("6b682aa2-2772-4afa-a397-886f8eccb17e","","",true, this);
 
            MakeAutomaticOutput = RPSControlFactory.CreateRPSCheckBox<OrderMaterialPrevisionView>("f8f1ee56-a15f-438f-b48b-778f62b4bac5","","",true, this);
 
            ImputationCostUpdated = RPSControlFactory.CreateRPSCheckBox<OrderMaterialPrevisionView>("83a17e0a-a440-4309-bd80-b1ba2d564bc9","","",true, this);
 
            ImputationTotalQuantity = RPSControlFactory.CreateRPSCheckBox<OrderMaterialPrevisionView>("cd948834-295b-4ba5-898e-6a1a881f67c2","","",true, this);
 
            Completed = RPSControlFactory.CreateRPSCheckBox<OrderMaterialPrevisionView>("c1dc4ce1-f40f-4ed4-a877-9895004a36a6","","",true, this);
 
            Comments = RPSControlFactory.CreateRPSTextBox<OrderMaterialPrevisionView>("0d0b6791-e78f-4964-8f9c-48c64d2bf907","","",false, this);
 
            ExecuteAddMaintenanceOrderMaterialPrevisionButton = RPSControlFactory.CreateRPSButton<OrderMaterialPrevisionView>( "e3f43b39-12b2-4c40-8a8a-96c69eccd539","","",this);
 
            MaterialProvisioningValidationNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<OrderMaterialPrevisionView,MaterialProvisioningValidationDialogView>("3b8f73b4-57a8-4000-aec8-356d76e8819c","","", this,Screen.MaterialProvisioningValidationDialogView);
 

        }
        public IRPSButton<OrderMaterialPrevisionView> DeleteButton { get; set; } 
        public IRPSButton<OrderMaterialPrevisionView,MaintenanceOrderVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<OrderMaterialPrevisionView,MaintenanceOrderVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<OrderMaterialPrevisionView,MaintenanceOrderVMEntityView> AcceptButton { get; set; } 
        public IRPSOption<OrderMaterialPrevisionView> PurchaseProposal { get; set; } 
        public IRPSOption<OrderMaterialPrevisionView> ManufacturingOrder { get; set; } 
        public IRPSComboBox<OrderMaterialPrevisionView> IDArticle { get; set; } 
        public IRPSTextBox<OrderMaterialPrevisionView> Description { get; set; } 
        public IRPSTextBox<OrderMaterialPrevisionView> PriceCost { get; set; } 
        public IRPSComboBox<OrderMaterialPrevisionView> IDSite { get; set; } 
        public IRPSComboBox<OrderMaterialPrevisionView> IDWareHouse { get; set; } 
        public IRPSTextBox<OrderMaterialPrevisionView> Quantity { get; set; } 
        public IRPSTextBox<OrderMaterialPrevisionView> QuantityImputed { get; set; } 
        public IRPSCheckbox<OrderMaterialPrevisionView> MakeMovement { get; set; } 
        public IRPSCheckbox<OrderMaterialPrevisionView> MakeAutomaticOutput { get; set; } 
        public IRPSCheckbox<OrderMaterialPrevisionView> ImputationCostUpdated { get; set; } 
        public IRPSCheckbox<OrderMaterialPrevisionView> ImputationTotalQuantity { get; set; } 
        public IRPSCheckbox<OrderMaterialPrevisionView> Completed { get; set; } 
        public IRPSTextBox<OrderMaterialPrevisionView> Comments { get; set; } 
        public IRPSButton<OrderMaterialPrevisionView> ExecuteAddMaintenanceOrderMaterialPrevisionButton { get; set; } 
        public IRPSButton<OrderMaterialPrevisionView,MaterialProvisioningValidationDialogView> MaterialProvisioningValidationNavigationCommandButton { get; set; } 
        public WorkOrdersFollowUp Screen { get; set; }
        public OrderMaterialPrevisionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaterialProvisioningValidationDialogView : View
    {
        public MaterialProvisioningValidationDialogView(WorkOrdersFollowUp screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDEmployee = RPSControlFactory.CreateRPSComboBox<MaterialProvisioningValidationDialogView>("82be5980-8d96-4173-8c4f-f6624641f339","","",false, this);
 
            PassWord = RPSControlFactory.CreateRPSTextBox<MaterialProvisioningValidationDialogView>("75037155-96b1-4b8f-aa94-a9f740e179ab","","",true, this);
 

        }
        public IRPSComboBox<MaterialProvisioningValidationDialogView> IDEmployee { get; set; } 
        public IRPSTextBox<MaterialProvisioningValidationDialogView> PassWord { get; set; } 
        public WorkOrdersFollowUp Screen { get; set; }
        public MaterialProvisioningValidationDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}