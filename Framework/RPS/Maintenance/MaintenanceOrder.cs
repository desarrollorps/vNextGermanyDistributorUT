    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.MaintenanceOrder
{
    //RPS VERSION 1.0.0.0
    public partial class MaintenanceOrder:Screen
    {
        public MaintenanceOrder():base()
        {
            this.URL = "maintenance.maintenanceorder";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MaintenanceOrderCollectionView  = new MaintenanceOrderCollectionView(this); 
            MaintenanceOrderEntityView  = new MaintenanceOrderEntityView(this); 
            MaintenanceOrderMaterialView  = new MaintenanceOrderMaterialView(this); 
            MaintenanceOrderDefectView  = new MaintenanceOrderDefectView(this); 
            MaintenanceOrderSolutionView  = new MaintenanceOrderSolutionView(this); 
            MaintenanceOrderCauseView  = new MaintenanceOrderCauseView(this); 
            MaintenanceOrderEmployeeView  = new MaintenanceOrderEmployeeView(this); 
            MaintenanceOrderSubcontractView  = new MaintenanceOrderSubcontractView(this); 
            MaintenanceOrderResourceView  = new MaintenanceOrderResourceView(this); 
            ManOrderEmployeeExpensesView  = new ManOrderEmployeeExpensesView(this); 
            MaintenanceOrderExpensesView  = new MaintenanceOrderExpensesView(this); 
            MaintenanceOrderProcedureView  = new MaintenanceOrderProcedureView(this); 
            MaintenanceOrderProcTaskView  = new MaintenanceOrderProcTaskView(this); 
            MaintenanceOrderAssociateWarningView  = new MaintenanceOrderAssociateWarningView(this); 
            MaintenanceOrderRelationView  = new MaintenanceOrderRelationView(this); 
            ManOrderDimensionView  = new ManOrderDimensionView(this); 
            MaintenanceOrderPredictiveView  = new MaintenanceOrderPredictiveView(this); 
            MaintenanceOrderPredictiveSampleView  = new MaintenanceOrderPredictiveSampleView(this); 
            MaintenanceOrderResourcePrevisionDialogView  = new MaintenanceOrderResourcePrevisionDialogView(this); 
            MaintenanceOrderSubcontractPrevisionDialogView  = new MaintenanceOrderSubcontractPrevisionDialogView(this); 
            MaintenanceOrderStaffPrevisionDialogView  = new MaintenanceOrderStaffPrevisionDialogView(this); 
            MaintenaceOrderChangeStatusDialogView  = new MaintenaceOrderChangeStatusDialogView(this); 
            MaintenanceOrderPrintOptionsDialogView  = new MaintenanceOrderPrintOptionsDialogView(this); 
            OrderMaterialPrevisionView  = new OrderMaterialPrevisionView(this); 
            ManOrderEmployeeExpensesPrevisionDialogView  = new ManOrderEmployeeExpensesPrevisionDialogView(this); 
            CuDistChangeCustomerDialogView  = new CuDistChangeCustomerDialogView(this); 
            MaintenanceOrderCollectionView.InitializeControls(); 
            MaintenanceOrderEntityView.InitializeControls(); 
            MaintenanceOrderMaterialView.InitializeControls(); 
            MaintenanceOrderDefectView.InitializeControls(); 
            MaintenanceOrderSolutionView.InitializeControls(); 
            MaintenanceOrderCauseView.InitializeControls(); 
            MaintenanceOrderEmployeeView.InitializeControls(); 
            MaintenanceOrderSubcontractView.InitializeControls(); 
            MaintenanceOrderResourceView.InitializeControls(); 
            ManOrderEmployeeExpensesView.InitializeControls(); 
            MaintenanceOrderExpensesView.InitializeControls(); 
            MaintenanceOrderProcedureView.InitializeControls(); 
            MaintenanceOrderProcTaskView.InitializeControls(); 
            MaintenanceOrderAssociateWarningView.InitializeControls(); 
            MaintenanceOrderRelationView.InitializeControls(); 
            ManOrderDimensionView.InitializeControls(); 
            MaintenanceOrderPredictiveView.InitializeControls(); 
            MaintenanceOrderPredictiveSampleView.InitializeControls(); 
            MaintenanceOrderResourcePrevisionDialogView.InitializeControls(); 
            MaintenanceOrderSubcontractPrevisionDialogView.InitializeControls(); 
            MaintenanceOrderStaffPrevisionDialogView.InitializeControls(); 
            MaintenaceOrderChangeStatusDialogView.InitializeControls(); 
            MaintenanceOrderPrintOptionsDialogView.InitializeControls(); 
            OrderMaterialPrevisionView.InitializeControls(); 
            ManOrderEmployeeExpensesPrevisionDialogView.InitializeControls(); 
            CuDistChangeCustomerDialogView.InitializeControls(); 
           
        }
      
            public MaintenanceOrderCollectionView MaintenanceOrderCollectionView {get; set; } 
            public MaintenanceOrderEntityView MaintenanceOrderEntityView {get; set; } 
            public MaintenanceOrderMaterialView MaintenanceOrderMaterialView {get; set; } 
            public MaintenanceOrderDefectView MaintenanceOrderDefectView {get; set; } 
            public MaintenanceOrderSolutionView MaintenanceOrderSolutionView {get; set; } 
            public MaintenanceOrderCauseView MaintenanceOrderCauseView {get; set; } 
            public MaintenanceOrderEmployeeView MaintenanceOrderEmployeeView {get; set; } 
            public MaintenanceOrderSubcontractView MaintenanceOrderSubcontractView {get; set; } 
            public MaintenanceOrderResourceView MaintenanceOrderResourceView {get; set; } 
            public ManOrderEmployeeExpensesView ManOrderEmployeeExpensesView {get; set; } 
            public MaintenanceOrderExpensesView MaintenanceOrderExpensesView {get; set; } 
            public MaintenanceOrderProcedureView MaintenanceOrderProcedureView {get; set; } 
            public MaintenanceOrderProcTaskView MaintenanceOrderProcTaskView {get; set; } 
            public MaintenanceOrderAssociateWarningView MaintenanceOrderAssociateWarningView {get; set; } 
            public MaintenanceOrderRelationView MaintenanceOrderRelationView {get; set; } 
            public ManOrderDimensionView ManOrderDimensionView {get; set; } 
            public MaintenanceOrderPredictiveView MaintenanceOrderPredictiveView {get; set; } 
            public MaintenanceOrderPredictiveSampleView MaintenanceOrderPredictiveSampleView {get; set; } 
            public MaintenanceOrderResourcePrevisionDialogView MaintenanceOrderResourcePrevisionDialogView {get; set; } 
            public MaintenanceOrderSubcontractPrevisionDialogView MaintenanceOrderSubcontractPrevisionDialogView {get; set; } 
            public MaintenanceOrderStaffPrevisionDialogView MaintenanceOrderStaffPrevisionDialogView {get; set; } 
            public MaintenaceOrderChangeStatusDialogView MaintenaceOrderChangeStatusDialogView {get; set; } 
            public MaintenanceOrderPrintOptionsDialogView MaintenanceOrderPrintOptionsDialogView {get; set; } 
            public OrderMaterialPrevisionView OrderMaterialPrevisionView {get; set; } 
            public ManOrderEmployeeExpensesPrevisionDialogView ManOrderEmployeeExpensesPrevisionDialogView {get; set; } 
            public CuDistChangeCustomerDialogView CuDistChangeCustomerDialogView {get; set; } 
    }
            
    public partial class MaintenanceOrderCollectionView : View
    {
        public MaintenanceOrderCollectionView(MaintenanceOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<MaintenanceOrderCollectionView,MaintenanceOrderEntityView>( this,Screen.MaintenanceOrderEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "f3928915-c631-48f7-a5cd-6571ab85c771",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<MaintenanceOrderCollectionView,MaintenanceOrderEntityView>( params_MainConsult,this,Screen.MaintenanceOrderEntityView);
 

        }
        public IRPSButton<MaintenanceOrderCollectionView,MaintenanceOrderEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<MaintenanceOrderCollectionView,MaintenanceOrderEntityView> MainConsult { get; set; } 
        public MaintenanceOrder Screen { get; set; }
        public MaintenanceOrderCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenanceOrderEntityView : View
    {
        public MaintenanceOrderEntityView(MaintenanceOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MaintenanceOrderEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceOrderEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceOrderEntityView,MaintenanceOrderCollectionView>( this,Screen.MaintenanceOrderCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceOrderEntityView,MaintenanceOrderCollectionView>( this,Screen.MaintenanceOrderCollectionView);
 
            MaintenanceOrderCode = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderEntityView>("2ab46aed-2a94-4a68-8e62-abe5f0353464","","",false, this);
 
            CodUserCreatedBy = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderEntityView>("b761c03d-51d1-4cc4-83ed-af382dbfb3c6","","",false, this);
 
            CreationDate = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderEntityView>("3d7ca8b4-0071-4a0b-86fa-707cb5c7f2e6","","",true, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderEntityView>("021faede-a6e3-48eb-b4a7-76b8d1eda289","","",false, this);
 
            IDMaintenanceComponent = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderEntityView>("a8d0f89a-bd41-4274-8985-5c4a9836a494","","",true, this);
 
            Serial_Number = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderEntityView>("63adf2bc-ff32-472a-bbe4-f7383bff04d5","","",false, this);
 
            UIIDCustomer = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderEntityView>("34f3edb0-f718-4477-9b2a-2ec84c8a32d0","","",false, this);
 
            UIGuaranteeExpiryDate = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderEntityView>("79c8d184-43f0-45c1-807a-391fea47278a","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderEntityView>("6f9f06fc-af88-41a9-854b-98bc47184423","","",false, this);
 
            ExecutionDate = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderEntityView>("c0ba13cc-1214-460d-8f3a-3e145293cf9c","","",true, this);
 
            ExecutionTime = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderEntityView>("6badc41f-2602-4361-8b1d-e312a88c2d15","","",true, this);
 
            ClosingDate = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderEntityView>("8f0e0316-2c3b-4e5d-9138-1679fc74647a","","",false, this);
 
            ClosingTime = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderEntityView>("2ebc73ac-e731-4abe-8b12-73728f7b4bc5","","",false, this);
 
            IDMaintenanceOrderStatus = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderEntityView>("181b5c4d-b436-45a4-8c11-6b2ac783305e","","",true, this);
 
            IDMaintenanceType = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderEntityView>("43e62a7c-3f01-46ce-94a9-eccf100723ad","","",true, this);
 
            DegreeOfRisk = RPSControlFactory.CreateRPSEnumComboBox<MaintenanceOrderEntityView>("7f56597c-211d-43c1-b7c9-16f7bcb92230","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderEntityView>("5479fff9-5b58-4f04-be55-5069557137e0","","",false, this);
 
            IDMaintenancePlan = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderEntityView>("ace3026e-ad0a-465f-931a-fdcd521a0e4a","","",false, this);
 
            UIeControlType = RPSControlFactory.CreateRPSEnumComboBox<MaintenanceOrderEntityView>("1404fe83-0efa-4753-a007-a55603ecd824","","",false, this);
 
            IDMaintenanceWarning = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderEntityView>("1e2ef08f-cf0b-4a87-9307-18bc0b134a3e","","",false, this);
 
            CalcAmountCostTheoricTotal = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceOrderEntityView>("b2e7441a-4c33-4572-bb9a-07b2261fcfef","","",false, this);
 
            CalcAmountCostRealTotal = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceOrderEntityView>("7724b846-c8d6-4210-b6da-3b099671d432","","",false, this);
 
            CalcAmountCostBillableTotal = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceOrderEntityView>("0ff6ae90-88e4-4356-ae7c-515a01f9fd20","","",false, this);
 
            CalcAmountSaleTotal = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceOrderEntityView>("bf8aad0f-cd7f-49cd-bce8-5cd9bf21eb50","","",false, this);
 
            ResponsibleType = RPSControlFactory.CreateRPSEnumComboBox<MaintenanceOrderEntityView>("0c70604a-8f77-488f-91d3-03aea58e6662","","",true, this);
 
            IDResponsibleQualify = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderEntityView>("2cacee1d-2f0b-4cad-aee9-0205da1b31c7","","",false, this);
 
            IDResponsibleEmployee = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderEntityView>("33d1f337-5f4d-46f7-925f-891eae7fe0ee","","",false, this);
 
            IDResponsibleSupplier = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderEntityView>("a670d8b5-8c54-4caf-bc76-5ba42edcf5eb","","",false, this);
 
            TypeOfAction = RPSControlFactory.CreateRPSEnumComboBox<MaintenanceOrderEntityView>("ad5be612-b7a5-41b4-99ea-b8068bc5c85b","","",true, this);
 
            Duration = RPSControlFactory.CreateRPSDurationTextBox<MaintenanceOrderEntityView>("7d17443c-1524-4edd-99aa-a31990b4fbd0","","",false, this);
 
            StopTime = RPSControlFactory.CreateRPSDurationTextBox<MaintenanceOrderEntityView>("a4b7e315-431d-475f-865b-25f7f6a8c4ab","","",true, this);
 
            IDMaintenanceContractSales = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderEntityView>("058c8149-16df-4060-b4da-fbe438bdc926","","",false, this);
 
            BillableForSales = RPSControlFactory.CreateRPSCheckBox<MaintenanceOrderEntityView>("2c74f647-427f-43cb-a5b0-cf6d399a9db1","","",true, this);
 
            IDMaintenanceContractPurchase = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderEntityView>("9a7b1ce2-2328-489f-a966-455326e85ead","","",false, this);
 
            BillableForPurchase = RPSControlFactory.CreateRPSCheckBox<MaintenanceOrderEntityView>("c030d1fd-423f-49f7-8870-9eef5b6dc8ba","","",true, this);
 
            PlanningManual = RPSControlFactory.CreateRPSCheckBox<MaintenanceOrderEntityView>("ea9e1fdd-c56d-4aa3-9ca3-07d50d37076f","","",true, this);
 
            Fixed = RPSControlFactory.CreateRPSCheckBox<MaintenanceOrderEntityView>("46bf0aa2-8869-4d90-aab3-c0066b706626","","",true, this);
 
            OccupancyType = RPSControlFactory.CreateRPSEnumComboBox<MaintenanceOrderEntityView>("e08bcbd0-b73a-46e9-b8d9-c4f9e6839203","","",true, this);
 
            OccupancyHours = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceOrderEntityView>("739029cf-1887-4507-9929-3b47c72887b7","","",true, this);
 
            OccupancyPercent = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceOrderEntityView>("e93794dc-1f0f-4b89-8712-bd1d18870581","","",true, this);
 
            Priority = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceOrderEntityView>("6c8df4ad-5363-4003-bd4b-71bf776acd38","","",true, this);
 
            OptimizationFeature = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderEntityView>("0f8b18d0-bd4c-4658-aca6-d05de227116f","","",false, this);
 
            UIOrderSales = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderEntityView>("748cfa81-ef8d-431c-8ecd-662fecfdebe8","","",false, this);
 
            UIDeliveryNoteSales = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderEntityView>("cc243f76-63cd-4db8-8517-b2974db02b3e","","",false, this);
 
            UIInvoiceSales = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderEntityView>("548cf6ec-8057-4c50-af6f-28cebd075a05","","",false, this);
 
            UIOrderPurchase = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderEntityView>("3491baae-5ce3-45eb-88e0-06d6528f9011","","",false, this);
 
            UIDeliveryNotePurchase = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderEntityView>("9f170a0e-d4c8-4328-9b13-26b8e24c1331","","",false, this);
 
            UIInvoicePurchase = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderEntityView>("92b394bc-1f41-4eba-8001-5cb41420654e","","",false, this);
 
            Observations = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderEntityView>("23a7820a-1718-4a28-918a-1ad0d27af248","","",false, this);
 
            Notes = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderEntityView>("e4366166-737e-47e3-9c12-6b1ac567dda6","","",false, this);
 
            PurchaseProposal = RPSControlFactory.CreateRPSOption<MaintenanceOrderEntityView>( "b08a5842-6c21-4690-90fc-b329190b663f","","",this);
 
            ManufacturingOrder = RPSControlFactory.CreateRPSOption<MaintenanceOrderEntityView>( "b6f1a349-d386-4209-a222-0f0f0f9ce8b1","","",this);
 
            ExecuteAddMaintenanceOrderMaterialsPrevisonButton = RPSControlFactory.CreateRPSButton<MaintenanceOrderEntityView>( "371c4dbf-02c6-4403-ab32-d73375dc41db","","",this);
 
            ExecuteMaintenanceProvisioningButton = RPSControlFactory.CreateRPSButton<MaintenanceOrderEntityView>( "d5653878-67c9-4bc1-a965-9528f459f571","","",this);
 
            MaintenanceOrderStaffPrevisionNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<MaintenanceOrderEntityView,MaintenanceOrderStaffPrevisionDialogView>("b43b2452-bbd3-4a44-bea1-a432893d79fd","","", this,Screen.MaintenanceOrderStaffPrevisionDialogView);
 
            MaintenanceOrderSubcontractPrevisionNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<MaintenanceOrderEntityView,MaintenanceOrderSubcontractPrevisionDialogView>("ee921125-5c96-472c-8b70-20f130674f00","","", this,Screen.MaintenanceOrderSubcontractPrevisionDialogView);
 
            MaintenanceOrderResourcePrevisionNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<MaintenanceOrderEntityView,MaintenanceOrderResourcePrevisionDialogView>("4a432a1d-38e0-440d-b23c-9dce280225cd","","", this,Screen.MaintenanceOrderResourcePrevisionDialogView);
 
            ManOrderEmployeeExpensesPrevisionNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<MaintenanceOrderEntityView,ManOrderEmployeeExpensesPrevisionDialogView>("6d25183e-a3fb-4b79-a044-64e84c705ed3","","", this,Screen.ManOrderEmployeeExpensesPrevisionDialogView);
 
            ExecuteGenerateMaintenanceWarningAssociatedButton = RPSControlFactory.CreateRPSButton<MaintenanceOrderEntityView>( "e8b67bd8-3abc-46e4-b169-6ac3b476c465","","",this);
 
            DeliveryNoteOfSalesCommandButton = RPSControlFactory.CreateRPSButton<MaintenanceOrderEntityView>( "7211a160-a106-4dba-8091-b4e5ea37acda","","",this);
 
            InvoiceOfSalesCommandButton = RPSControlFactory.CreateRPSButton<MaintenanceOrderEntityView>( "d1e71103-58d4-419c-a9d7-05d8325d3a28","","",this);
 
            MaintenaceOrderChangeStatusNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<MaintenanceOrderEntityView,MaintenaceOrderChangeStatusDialogView>("ae7b7c2d-789e-4b75-9865-a4187cf64559","","", this,Screen.MaintenaceOrderChangeStatusDialogView);
 
            MaintenanceOrderPrintOptionsNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<MaintenanceOrderEntityView,MaintenanceOrderPrintOptionsDialogView>("de30582a-2b55-42b4-a5c3-d7d160614952","","", this,Screen.MaintenanceOrderPrintOptionsDialogView);
 
            ReportCommandButton = RPSControlFactory.CreateRPSButton<MaintenanceOrderEntityView>( "0043d19a-3d60-4e69-aae1-f7e381c53cb5","","",this);
 
            CuDistChangeCustomerNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<MaintenanceOrderEntityView,CuDistChangeCustomerDialogView>("a3a6bfa0-a514-422e-8e5e-3e11ea337cad","","", this,Screen.CuDistChangeCustomerDialogView);
 
            CollectionInit params_MaintenanceOrderDefects = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="58480129-2b35-4a7f-ba35-a5f7928752bd",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceOrderDefects = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceOrderDefectsCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView>,MaintenanceOrderEntityView,MaintenanceOrderEmployeeView>( params_MaintenanceOrderDefects,this,Screen.MaintenanceOrderEmployeeView);
 
            CollectionInit params_OrderMaterialPrevisions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="fe95d778-1ff0-4916-9956-373e60c2825c",CSSSelectorGrid="",XPathGrid=""};
            OrderMaterialPrevisions = RPSControlFactory.RPSCreateCollectionWithGrid<OrderMaterialPrevisionsCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView>,MaintenanceOrderEntityView,MaintenanceOrderEmployeeView>( params_OrderMaterialPrevisions,this,Screen.MaintenanceOrderEmployeeView);
 
            CollectionInit params_MANMaintenanceOrderMaterials = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="385eaebf-b567-42ff-b8fd-94964afbe521",CSSSelectorGrid="",XPathGrid=""};
            MANMaintenanceOrderMaterials = RPSControlFactory.RPSCreateCollectionWithGrid<MANMaintenanceOrderMaterialsCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView>,MaintenanceOrderEntityView,MaintenanceOrderEmployeeView>( params_MANMaintenanceOrderMaterials,this,Screen.MaintenanceOrderEmployeeView);
 
            CollectionInit params_MaintenanceOrderEmployees = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="616b1073-6cde-42ed-9e25-9287ad408934",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceOrderEmployees = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceOrderEmployeesCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView>,MaintenanceOrderEntityView,MaintenanceOrderEmployeeView>( params_MaintenanceOrderEmployees,this,Screen.MaintenanceOrderEmployeeView);
 
            CollectionInit params_MaintenanceOrderSubcontracts = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="9e2964c1-deeb-4787-ad0f-45fa3326844e",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceOrderSubcontracts = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceOrderSubcontractsCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView>,MaintenanceOrderEntityView,MaintenanceOrderEmployeeView>( params_MaintenanceOrderSubcontracts,this,Screen.MaintenanceOrderEmployeeView);
 
            CollectionInit params_MaintenanceOrderResources = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8036f2b5-727c-42e9-a713-fea0bafc6a6e",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceOrderResources = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceOrderResourcesCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView>,MaintenanceOrderEntityView,MaintenanceOrderEmployeeView>( params_MaintenanceOrderResources,this,Screen.MaintenanceOrderEmployeeView);
 
            CollectionInit params_ManOrderEmployeeExpensess = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="88ba32bb-1452-4e19-9017-d627e899d539",CSSSelectorGrid="",XPathGrid=""};
            ManOrderEmployeeExpensess = RPSControlFactory.RPSCreateCollectionWithGrid<ManOrderEmployeeExpensessCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView>,MaintenanceOrderEntityView,MaintenanceOrderEmployeeView>( params_ManOrderEmployeeExpensess,this,Screen.MaintenanceOrderEmployeeView);
 
            CollectionInit params_MaintenanceOrderExpensess = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d71ab787-30fd-46eb-bc3d-39e9531d7de4",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceOrderExpensess = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceOrderExpensessCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView>,MaintenanceOrderEntityView,MaintenanceOrderEmployeeView>( params_MaintenanceOrderExpensess,this,Screen.MaintenanceOrderEmployeeView);
 
            CollectionInit params_MANMaintenanceOrderProcedures = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c68898e1-1c3d-43ff-acf1-ded51eb9e7b5",CSSSelectorGrid="",XPathGrid=""};
            MANMaintenanceOrderProcedures = RPSControlFactory.RPSCreateCollectionWithGrid<MANMaintenanceOrderProceduresCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView>,MaintenanceOrderEntityView,MaintenanceOrderEmployeeView>( params_MANMaintenanceOrderProcedures,this,Screen.MaintenanceOrderEmployeeView);
 
            CollectionInit params_MaintenanceOrderPredictives = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f5af1cd9-2301-4475-b17b-4fcfed722ff4",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceOrderPredictives = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceOrderPredictivesCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView>,MaintenanceOrderEntityView,MaintenanceOrderEmployeeView>( params_MaintenanceOrderPredictives,this,Screen.MaintenanceOrderEmployeeView);
 
            CollectionInit params_MaintenanceOrderAssociateOrders = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b8067366-3219-4372-902c-f05a56e798cd",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceOrderAssociateOrders = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceOrderAssociateOrdersCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView>,MaintenanceOrderEntityView,MaintenanceOrderEmployeeView>( params_MaintenanceOrderAssociateOrders,this,Screen.MaintenanceOrderEmployeeView);
 
            CollectionInit params_MaintenanceOrderRelations = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f9bb0e82-1666-413f-9dcf-102ed927942a",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceOrderRelations = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceOrderRelationsCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView>,MaintenanceOrderEntityView,MaintenanceOrderEmployeeView>( params_MaintenanceOrderRelations,this,Screen.MaintenanceOrderEmployeeView);
 
            CollectionInit params_MaintenanceAppointmentConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="420e1575-d829-414a-8fd0-1302a113ee60",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceAppointmentConsult = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceAppointmentConsultCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView>,MaintenanceOrderEntityView,MaintenanceOrderEmployeeView>( params_MaintenanceAppointmentConsult,this,Screen.MaintenanceOrderEmployeeView);
 
            CollectionInit params_ManOrderDimensions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b2c7126a-cf49-463a-b970-2c96671c7b9e",CSSSelectorGrid="",XPathGrid=""};
            ManOrderDimensions = RPSControlFactory.RPSCreateCollectionWithGrid<ManOrderDimensionsCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView>,MaintenanceOrderEntityView,MaintenanceOrderEmployeeView>( params_ManOrderDimensions,this,Screen.MaintenanceOrderEmployeeView);
 
            General = RPSControlFactory.CreateRPSSection<MaintenanceOrderEntityView>( "","ul li[rpsid='b4afdd47-00da-4749-9a3e-b463492e3d88']","",this);
 
            Description1 = RPSControlFactory.CreateRPSSection<MaintenanceOrderEntityView>( "","ul li[rpsid='981d01db-2868-42ce-b662-5a83a8839b67']","",this);
 
            Defect = RPSControlFactory.CreateRPSSection<MaintenanceOrderEntityView>( "","ul li[rpsid='919161a4-2bae-4a03-9c4d-e801a997c953']","",this);
 
            MaterialPrevision = RPSControlFactory.CreateRPSSection<MaintenanceOrderEntityView>( "","ul li[rpsid='3b40b3d8-1b64-4f78-836a-75d5f26f5e60']","",this);
 
            Material = RPSControlFactory.CreateRPSSection<MaintenanceOrderEntityView>( "","ul li[rpsid='3c913a33-e1ef-4c02-a656-d8dd48d9385b']","",this);
 
            Employee = RPSControlFactory.CreateRPSSection<MaintenanceOrderEntityView>( "","ul li[rpsid='f0f37c35-6345-423d-b181-a1ac17d4b870']","",this);
 
            Subcontract = RPSControlFactory.CreateRPSSection<MaintenanceOrderEntityView>( "","ul li[rpsid='ed80c941-ccbb-4d7d-a1c1-7916dfd50a8a']","",this);
 
            Resource = RPSControlFactory.CreateRPSSection<MaintenanceOrderEntityView>( "","ul li[rpsid='daab445d-3e72-4baa-a1dd-5103f66a016d']","",this);
 
            Travel = RPSControlFactory.CreateRPSSection<MaintenanceOrderEntityView>( "","ul li[rpsid='fa6589fc-35a1-4b41-a3d3-5e7d5004910f']","",this);
 
            OtherExpenses = RPSControlFactory.CreateRPSSection<MaintenanceOrderEntityView>( "","ul li[rpsid='7949f99d-3b69-43c5-85e6-c6ab7d76633c']","",this);
 
            Procedure = RPSControlFactory.CreateRPSSection<MaintenanceOrderEntityView>( "","ul li[rpsid='c6070df4-9a27-4d15-8d9c-86731f88d67d']","",this);
 
            PredictiveMeasurements = RPSControlFactory.CreateRPSSection<MaintenanceOrderEntityView>( "","ul li[rpsid='5063c439-e2b1-4d7a-8f63-17b33b391c99']","",this);
 
            Tickets = RPSControlFactory.CreateRPSSection<MaintenanceOrderEntityView>( "","ul li[rpsid='a227da3d-8b69-41be-9575-4968d5aec7a4']","",this);
 
            Relation = RPSControlFactory.CreateRPSSection<MaintenanceOrderEntityView>( "","ul li[rpsid='783edc45-6282-46b4-ad8f-8c2a2653dfa1']","",this);
 
            Appointments = RPSControlFactory.CreateRPSSection<MaintenanceOrderEntityView>( "","ul li[rpsid='c9720165-c186-4631-bcd9-fa6b37422dc7']","",this);
 
            Dimensions = RPSControlFactory.CreateRPSSection<MaintenanceOrderEntityView>( "","ul li[rpsid='b4361d6b-ee1a-4a18-be8f-e5925a5696d7']","",this);
 

        }
        public IRPSSaveButton<MaintenanceOrderEntityView> SaveButton { get; set; } 
        public IRPSButton<MaintenanceOrderEntityView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceOrderEntityView,MaintenanceOrderCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceOrderEntityView,MaintenanceOrderCollectionView> BackButton { get; set; } 
        public IRPSTextBox<MaintenanceOrderEntityView> MaintenanceOrderCode { get; set; } 
        public IRPSComboBox<MaintenanceOrderEntityView> CodUserCreatedBy { get; set; } 
        public IRPSTextBox<MaintenanceOrderEntityView> CreationDate { get; set; } 
        public IRPSComboBox<MaintenanceOrderEntityView> IDCustomer { get; set; } 
        public IRPSComboBox<MaintenanceOrderEntityView> IDMaintenanceComponent { get; set; } 
        public IRPSTextBox<MaintenanceOrderEntityView> Serial_Number { get; set; } 
        public IRPSComboBox<MaintenanceOrderEntityView> UIIDCustomer { get; set; } 
        public IRPSTextBox<MaintenanceOrderEntityView> UIGuaranteeExpiryDate { get; set; } 
        public IRPSComboBox<MaintenanceOrderEntityView> IDSite { get; set; } 
        public IRPSTextBox<MaintenanceOrderEntityView> ExecutionDate { get; set; } 
        public IRPSTextBox<MaintenanceOrderEntityView> ExecutionTime { get; set; } 
        public IRPSTextBox<MaintenanceOrderEntityView> ClosingDate { get; set; } 
        public IRPSTextBox<MaintenanceOrderEntityView> ClosingTime { get; set; } 
        public IRPSComboBox<MaintenanceOrderEntityView> IDMaintenanceOrderStatus { get; set; } 
        public IRPSComboBox<MaintenanceOrderEntityView> IDMaintenanceType { get; set; } 
        public IRPSComboBox<MaintenanceOrderEntityView> DegreeOfRisk { get; set; } 
        public IRPSTextBox<MaintenanceOrderEntityView> Description { get; set; } 
        public IRPSComboBox<MaintenanceOrderEntityView> IDMaintenancePlan { get; set; } 
        public IRPSComboBox<MaintenanceOrderEntityView> UIeControlType { get; set; } 
        public IRPSComboBox<MaintenanceOrderEntityView> IDMaintenanceWarning { get; set; } 
        public IRPSTextBox<MaintenanceOrderEntityView> CalcAmountCostTheoricTotal { get; set; } 
        public IRPSTextBox<MaintenanceOrderEntityView> CalcAmountCostRealTotal { get; set; } 
        public IRPSTextBox<MaintenanceOrderEntityView> CalcAmountCostBillableTotal { get; set; } 
        public IRPSTextBox<MaintenanceOrderEntityView> CalcAmountSaleTotal { get; set; } 
        public IRPSComboBox<MaintenanceOrderEntityView> ResponsibleType { get; set; } 
        public IRPSComboBox<MaintenanceOrderEntityView> IDResponsibleQualify { get; set; } 
        public IRPSComboBox<MaintenanceOrderEntityView> IDResponsibleEmployee { get; set; } 
        public IRPSComboBox<MaintenanceOrderEntityView> IDResponsibleSupplier { get; set; } 
        public IRPSComboBox<MaintenanceOrderEntityView> TypeOfAction { get; set; } 
        public IRPSDurationTextBox<MaintenanceOrderEntityView> Duration { get; set; } 
        public IRPSDurationTextBox<MaintenanceOrderEntityView> StopTime { get; set; } 
        public IRPSComboBox<MaintenanceOrderEntityView> IDMaintenanceContractSales { get; set; } 
        public IRPSCheckbox<MaintenanceOrderEntityView> BillableForSales { get; set; } 
        public IRPSComboBox<MaintenanceOrderEntityView> IDMaintenanceContractPurchase { get; set; } 
        public IRPSCheckbox<MaintenanceOrderEntityView> BillableForPurchase { get; set; } 
        public IRPSCheckbox<MaintenanceOrderEntityView> PlanningManual { get; set; } 
        public IRPSCheckbox<MaintenanceOrderEntityView> Fixed { get; set; } 
        public IRPSComboBox<MaintenanceOrderEntityView> OccupancyType { get; set; } 
        public IRPSTextBox<MaintenanceOrderEntityView> OccupancyHours { get; set; } 
        public IRPSTextBox<MaintenanceOrderEntityView> OccupancyPercent { get; set; } 
        public IRPSTextBox<MaintenanceOrderEntityView> Priority { get; set; } 
        public IRPSTextBox<MaintenanceOrderEntityView> OptimizationFeature { get; set; } 
        public IRPSComboBox<MaintenanceOrderEntityView> UIOrderSales { get; set; } 
        public IRPSComboBox<MaintenanceOrderEntityView> UIDeliveryNoteSales { get; set; } 
        public IRPSComboBox<MaintenanceOrderEntityView> UIInvoiceSales { get; set; } 
        public IRPSComboBox<MaintenanceOrderEntityView> UIOrderPurchase { get; set; } 
        public IRPSComboBox<MaintenanceOrderEntityView> UIDeliveryNotePurchase { get; set; } 
        public IRPSComboBox<MaintenanceOrderEntityView> UIInvoicePurchase { get; set; } 
        public IRPSTextBox<MaintenanceOrderEntityView> Observations { get; set; } 
        public IRPSTextBox<MaintenanceOrderEntityView> Notes { get; set; } 
        public IRPSOption<MaintenanceOrderEntityView> PurchaseProposal { get; set; } 
        public IRPSOption<MaintenanceOrderEntityView> ManufacturingOrder { get; set; } 
        public IRPSButton<MaintenanceOrderEntityView> ExecuteAddMaintenanceOrderMaterialsPrevisonButton { get; set; } 
        public IRPSButton<MaintenanceOrderEntityView> ExecuteMaintenanceProvisioningButton { get; set; } 
        public IRPSButton<MaintenanceOrderEntityView,MaintenanceOrderStaffPrevisionDialogView> MaintenanceOrderStaffPrevisionNavigationCommandButton { get; set; } 
        public IRPSButton<MaintenanceOrderEntityView,MaintenanceOrderSubcontractPrevisionDialogView> MaintenanceOrderSubcontractPrevisionNavigationCommandButton { get; set; } 
        public IRPSButton<MaintenanceOrderEntityView,MaintenanceOrderResourcePrevisionDialogView> MaintenanceOrderResourcePrevisionNavigationCommandButton { get; set; } 
        public IRPSButton<MaintenanceOrderEntityView,ManOrderEmployeeExpensesPrevisionDialogView> ManOrderEmployeeExpensesPrevisionNavigationCommandButton { get; set; } 
        public IRPSButton<MaintenanceOrderEntityView> ExecuteGenerateMaintenanceWarningAssociatedButton { get; set; } 
        public IRPSButton<MaintenanceOrderEntityView> DeliveryNoteOfSalesCommandButton { get; set; } 
        public IRPSButton<MaintenanceOrderEntityView> InvoiceOfSalesCommandButton { get; set; } 
        public IRPSButton<MaintenanceOrderEntityView,MaintenaceOrderChangeStatusDialogView> MaintenaceOrderChangeStatusNavigationCommandButton { get; set; } 
        public IRPSButton<MaintenanceOrderEntityView,MaintenanceOrderPrintOptionsDialogView> MaintenanceOrderPrintOptionsNavigationCommandButton { get; set; } 
        public IRPSButton<MaintenanceOrderEntityView> ReportCommandButton { get; set; } 
        public IRPSButton<MaintenanceOrderEntityView,CuDistChangeCustomerDialogView> CuDistChangeCustomerNavigationCommandButton { get; set; } 
        public MaintenanceOrderDefectsCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> MaintenanceOrderDefects { get; set; } 
        public OrderMaterialPrevisionsCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> OrderMaterialPrevisions { get; set; } 
        public MANMaintenanceOrderMaterialsCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> MANMaintenanceOrderMaterials { get; set; } 
        public MaintenanceOrderEmployeesCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> MaintenanceOrderEmployees { get; set; } 
        public MaintenanceOrderSubcontractsCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> MaintenanceOrderSubcontracts { get; set; } 
        public MaintenanceOrderResourcesCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> MaintenanceOrderResources { get; set; } 
        public ManOrderEmployeeExpensessCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> ManOrderEmployeeExpensess { get; set; } 
        public MaintenanceOrderExpensessCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> MaintenanceOrderExpensess { get; set; } 
        public MANMaintenanceOrderProceduresCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> MANMaintenanceOrderProcedures { get; set; } 
        public MaintenanceOrderPredictivesCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> MaintenanceOrderPredictives { get; set; } 
        public MaintenanceOrderAssociateOrdersCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> MaintenanceOrderAssociateOrders { get; set; } 
        public MaintenanceOrderRelationsCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> MaintenanceOrderRelations { get; set; } 
        public MaintenanceAppointmentConsultCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> MaintenanceAppointmentConsult { get; set; } 
        public ManOrderDimensionsCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> ManOrderDimensions { get; set; } 
        public IRPSSection<MaintenanceOrderEntityView> General { get; set; } 
        public IRPSSection<MaintenanceOrderEntityView> Description1 { get; set; } 
        public IRPSSection<MaintenanceOrderEntityView> Defect { get; set; } 
        public IRPSSection<MaintenanceOrderEntityView> MaterialPrevision { get; set; } 
        public IRPSSection<MaintenanceOrderEntityView> Material { get; set; } 
        public IRPSSection<MaintenanceOrderEntityView> Employee { get; set; } 
        public IRPSSection<MaintenanceOrderEntityView> Subcontract { get; set; } 
        public IRPSSection<MaintenanceOrderEntityView> Resource { get; set; } 
        public IRPSSection<MaintenanceOrderEntityView> Travel { get; set; } 
        public IRPSSection<MaintenanceOrderEntityView> OtherExpenses { get; set; } 
        public IRPSSection<MaintenanceOrderEntityView> Procedure { get; set; } 
        public IRPSSection<MaintenanceOrderEntityView> PredictiveMeasurements { get; set; } 
        public IRPSSection<MaintenanceOrderEntityView> Tickets { get; set; } 
        public IRPSSection<MaintenanceOrderEntityView> Relation { get; set; } 
        public IRPSSection<MaintenanceOrderEntityView> Appointments { get; set; } 
        public IRPSSection<MaintenanceOrderEntityView> Dimensions { get; set; } 
        public MaintenanceOrder Screen { get; set; }
        public MaintenanceOrderEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaintenanceOrderDefectsCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView>:RPSCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> where MaintenanceOrderEntityView : class, IView where MaintenanceOrderEmployeeView : class, IView
    {
        public  MaintenanceOrderDefectsGridView<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> GridView {get;set;}
    }
    public partial class MaintenanceOrderDefectsGridView <MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> :  RPSGridView<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> where MaintenanceOrderEntityView : class, IView where MaintenanceOrderEmployeeView : class, IView
    {
        public MaintenanceOrderDefectsGridView(MaintenanceOrderEntityView currentView,MaintenanceOrderEmployeeView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDMaintenanceDefect = RPSControlFactory.CreateRPSGridComboBox<MaintenanceOrderEntityView>("","#58480129-2b35-4a7f-ba35-a5f7928752bd .ag-row[role='row']@ROWINDEX [col-id='cIDMaintenanceDefect']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderEntityView>("","#58480129-2b35-4a7f-ba35-a5f7928752bd .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            IDMaintenanceComponent = RPSControlFactory.CreateRPSGridComboBox<MaintenanceOrderEntityView>("","#58480129-2b35-4a7f-ba35-a5f7928752bd .ag-row[role='row']@ROWINDEX [col-id='cIDMaintenanceComponent']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<MaintenanceOrderEntityView> IDMaintenanceDefect { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderEntityView> Description { get; set; } 
        public IRPSGridComboBox<MaintenanceOrderEntityView> IDMaintenanceComponent { get; set; } 
                     
    }
 
        public partial class OrderMaterialPrevisionsCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView>:RPSCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> where MaintenanceOrderEntityView : class, IView where MaintenanceOrderEmployeeView : class, IView
    {
        public  OrderMaterialPrevisionsGridView<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> GridView {get;set;}
    }
    public partial class OrderMaterialPrevisionsGridView <MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> :  RPSGridView<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> where MaintenanceOrderEntityView : class, IView where MaintenanceOrderEmployeeView : class, IView
    {
        public OrderMaterialPrevisionsGridView(MaintenanceOrderEntityView currentView,MaintenanceOrderEmployeeView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<MaintenanceOrderEntityView>("","#fe95d778-1ff0-4916-9956-373e60c2825c .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderEntityView>("","#fe95d778-1ff0-4916-9956-373e60c2825c .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            IDSite = RPSControlFactory.CreateRPSGridComboBox<MaintenanceOrderEntityView>("","#fe95d778-1ff0-4916-9956-373e60c2825c .ag-row[role='row']@ROWINDEX [col-id='cIDSite']","",false, this.CurrentView);
 
            IDWareHouse = RPSControlFactory.CreateRPSGridComboBox<MaintenanceOrderEntityView>("","#fe95d778-1ff0-4916-9956-373e60c2825c .ag-row[role='row']@ROWINDEX [col-id='cIDWareHouse']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenanceOrderEntityView>("","#fe95d778-1ff0-4916-9956-373e60c2825c .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            QuantityImputed = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenanceOrderEntityView>("","#fe95d778-1ff0-4916-9956-373e60c2825c .ag-row[role='row']@ROWINDEX [col-id='cQuantityImputed']","",true, this.CurrentView);
 
            PriceCost = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenanceOrderEntityView>("","#fe95d778-1ff0-4916-9956-373e60c2825c .ag-row[role='row']@ROWINDEX [col-id='cPriceCost']","",true, this.CurrentView);
 
            MakeMovement = RPSControlFactory.CreateRPSGridCheckBox<MaintenanceOrderEntityView>("","#fe95d778-1ff0-4916-9956-373e60c2825c .ag-row[role='row']@ROWINDEX [col-id='cMakeMovement']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<MaintenanceOrderEntityView> IDArticle { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderEntityView> Description { get; set; } 
        public IRPSGridComboBox<MaintenanceOrderEntityView> IDSite { get; set; } 
        public IRPSGridComboBox<MaintenanceOrderEntityView> IDWareHouse { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderEntityView> Quantity { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderEntityView> QuantityImputed { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderEntityView> PriceCost { get; set; } 
        public IRPSGridCheckbox<MaintenanceOrderEntityView> MakeMovement { get; set; } 
                     
    }
 
        public partial class MANMaintenanceOrderMaterialsCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView>:RPSCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> where MaintenanceOrderEntityView : class, IView where MaintenanceOrderEmployeeView : class, IView
    {
        public  MANMaintenanceOrderMaterialsGridView<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> GridView {get;set;}
    }
    public partial class MANMaintenanceOrderMaterialsGridView <MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> :  RPSGridView<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> where MaintenanceOrderEntityView : class, IView where MaintenanceOrderEmployeeView : class, IView
    {
        public MANMaintenanceOrderMaterialsGridView(MaintenanceOrderEntityView currentView,MaintenanceOrderEmployeeView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Date = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderEntityView>("","#385eaebf-b567-42ff-b8fd-94964afbe521 .ag-row[role='row']@ROWINDEX [col-id='cDate']","",true, this.CurrentView);
 
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<MaintenanceOrderEntityView>("","#385eaebf-b567-42ff-b8fd-94964afbe521 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            IDSite = RPSControlFactory.CreateRPSGridComboBox<MaintenanceOrderEntityView>("","#385eaebf-b567-42ff-b8fd-94964afbe521 .ag-row[role='row']@ROWINDEX [col-id='cIDSite']","",false, this.CurrentView);
 
            IDWarehouse = RPSControlFactory.CreateRPSGridComboBox<MaintenanceOrderEntityView>("","#385eaebf-b567-42ff-b8fd-94964afbe521 .ag-row[role='row']@ROWINDEX [col-id='cIDWarehouse']","",false, this.CurrentView);
 
            Series = RPSControlFactory.CreateRPSGridEnumComboBox<MaintenanceOrderEntityView>("","#385eaebf-b567-42ff-b8fd-94964afbe521 .ag-row[role='row']@ROWINDEX [col-id='cSeries']","",false, this.CurrentView);
 
            IDLocationWarehouse = RPSControlFactory.CreateRPSGridComboBox<MaintenanceOrderEntityView>("","#385eaebf-b567-42ff-b8fd-94964afbe521 .ag-row[role='row']@ROWINDEX [col-id='cIDLocationWarehouse']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenanceOrderEntityView>("","#385eaebf-b567-42ff-b8fd-94964afbe521 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            Comments = RPSControlFactory.CreateRPSGridMemoTextBox<MaintenanceOrderEntityView>("","#385eaebf-b567-42ff-b8fd-94964afbe521 .ag-row[role='row']@ROWINDEX [col-id='cComments']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MaintenanceOrderEntityView> Date { get; set; } 
        public IRPSGridComboBox<MaintenanceOrderEntityView> IDArticle { get; set; } 
        public IRPSGridComboBox<MaintenanceOrderEntityView> IDSite { get; set; } 
        public IRPSGridComboBox<MaintenanceOrderEntityView> IDWarehouse { get; set; } 
        public IRPSGridComboBox<MaintenanceOrderEntityView> Series { get; set; } 
        public IRPSGridComboBox<MaintenanceOrderEntityView> IDLocationWarehouse { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderEntityView> Quantity { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderEntityView> Comments { get; set; } 
                     
    }
 
        public partial class MaintenanceOrderEmployeesCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView>:RPSCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> where MaintenanceOrderEntityView : class, IView where MaintenanceOrderEmployeeView : class, IView
    {
        public  MaintenanceOrderEmployeesGridView<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> GridView {get;set;}
    }
    public partial class MaintenanceOrderEmployeesGridView <MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> :  RPSGridView<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> where MaintenanceOrderEntityView : class, IView where MaintenanceOrderEmployeeView : class, IView
    {
        public MaintenanceOrderEmployeesGridView(MaintenanceOrderEntityView currentView,MaintenanceOrderEmployeeView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDEmployee = RPSControlFactory.CreateRPSGridComboBox<MaintenanceOrderEntityView>("","#616b1073-6cde-42ed-9e25-9287ad408934 .ag-row[role='row']@ROWINDEX [col-id='cIDEmployee']","",true, this.CurrentView);
 
            IDQualify = RPSControlFactory.CreateRPSGridComboBox<MaintenanceOrderEntityView>("","#616b1073-6cde-42ed-9e25-9287ad408934 .ag-row[role='row']@ROWINDEX [col-id='cIDQualify']","",false, this.CurrentView);
 
            IDHourType = RPSControlFactory.CreateRPSGridComboBox<MaintenanceOrderEntityView>("","#616b1073-6cde-42ed-9e25-9287ad408934 .ag-row[role='row']@ROWINDEX [col-id='cIDHourType']","",true, this.CurrentView);
 
            InitialDate = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderEntityView>("","#616b1073-6cde-42ed-9e25-9287ad408934 .ag-row[role='row']@ROWINDEX [col-id='cInitialDate']","",false, this.CurrentView);
 
            FinalDate = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderEntityView>("","#616b1073-6cde-42ed-9e25-9287ad408934 .ag-row[role='row']@ROWINDEX [col-id='cFinalDate']","",false, this.CurrentView);
 
            Duration = RPSControlFactory.CreateRPSGridDurationTextBox<MaintenanceOrderEntityView>("","#616b1073-6cde-42ed-9e25-9287ad408934 .ag-row[role='row']@ROWINDEX [col-id='cDuration']","",true, this.CurrentView);
 
            Comments = RPSControlFactory.CreateRPSGridMemoTextBox<MaintenanceOrderEntityView>("","#616b1073-6cde-42ed-9e25-9287ad408934 .ag-row[role='row']@ROWINDEX [col-id='cComments']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<MaintenanceOrderEntityView> IDEmployee { get; set; } 
        public IRPSGridComboBox<MaintenanceOrderEntityView> IDQualify { get; set; } 
        public IRPSGridComboBox<MaintenanceOrderEntityView> IDHourType { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderEntityView> InitialDate { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderEntityView> FinalDate { get; set; } 
        public IRPSGridDurationTextBox<MaintenanceOrderEntityView> Duration { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderEntityView> Comments { get; set; } 
                     
    }
 
        public partial class MaintenanceOrderSubcontractsCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView>:RPSCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> where MaintenanceOrderEntityView : class, IView where MaintenanceOrderEmployeeView : class, IView
    {
        public  MaintenanceOrderSubcontractsGridView<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> GridView {get;set;}
    }
    public partial class MaintenanceOrderSubcontractsGridView <MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> :  RPSGridView<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> where MaintenanceOrderEntityView : class, IView where MaintenanceOrderEmployeeView : class, IView
    {
        public MaintenanceOrderSubcontractsGridView(MaintenanceOrderEntityView currentView,MaintenanceOrderEmployeeView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<MaintenanceOrderEntityView>("","#9e2964c1-deeb-4787-ad0f-45fa3326844e .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            IDSupplier = RPSControlFactory.CreateRPSGridComboBox<MaintenanceOrderEntityView>("","#9e2964c1-deeb-4787-ad0f-45fa3326844e .ag-row[role='row']@ROWINDEX [col-id='cIDSupplier']","",true, this.CurrentView);
 
            Date = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderEntityView>("","#9e2964c1-deeb-4787-ad0f-45fa3326844e .ag-row[role='row']@ROWINDEX [col-id='cDate']","",true, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenanceOrderEntityView>("","#9e2964c1-deeb-4787-ad0f-45fa3326844e .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            UnitCost = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenanceOrderEntityView>("","#9e2964c1-deeb-4787-ad0f-45fa3326844e .ag-row[role='row']@ROWINDEX [col-id='cUnitCost']","",false, this.CurrentView);
 
            Comments = RPSControlFactory.CreateRPSGridMemoTextBox<MaintenanceOrderEntityView>("","#9e2964c1-deeb-4787-ad0f-45fa3326844e .ag-row[role='row']@ROWINDEX [col-id='cComments']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<MaintenanceOrderEntityView> IDArticle { get; set; } 
        public IRPSGridComboBox<MaintenanceOrderEntityView> IDSupplier { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderEntityView> Date { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderEntityView> Quantity { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderEntityView> UnitCost { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderEntityView> Comments { get; set; } 
                     
    }
 
        public partial class MaintenanceOrderResourcesCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView>:RPSCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> where MaintenanceOrderEntityView : class, IView where MaintenanceOrderEmployeeView : class, IView
    {
        public  MaintenanceOrderResourcesGridView<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> GridView {get;set;}
    }
    public partial class MaintenanceOrderResourcesGridView <MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> :  RPSGridView<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> where MaintenanceOrderEntityView : class, IView where MaintenanceOrderEmployeeView : class, IView
    {
        public MaintenanceOrderResourcesGridView(MaintenanceOrderEntityView currentView,MaintenanceOrderEmployeeView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDMaintenanceResource = RPSControlFactory.CreateRPSGridComboBox<MaintenanceOrderEntityView>("","#8036f2b5-727c-42e9-a713-fea0bafc6a6e .ag-row[role='row']@ROWINDEX [col-id='cIDMaintenanceResource']","",true, this.CurrentView);
 
            Date = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderEntityView>("","#8036f2b5-727c-42e9-a713-fea0bafc6a6e .ag-row[role='row']@ROWINDEX [col-id='cDate']","",true, this.CurrentView);
 
            Duration = RPSControlFactory.CreateRPSGridDurationTextBox<MaintenanceOrderEntityView>("","#8036f2b5-727c-42e9-a713-fea0bafc6a6e .ag-row[role='row']@ROWINDEX [col-id='cDuration']","",false, this.CurrentView);
 
            UnitCost = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenanceOrderEntityView>("","#8036f2b5-727c-42e9-a713-fea0bafc6a6e .ag-row[role='row']@ROWINDEX [col-id='cUnitCost']","",true, this.CurrentView);
 
            Cost = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenanceOrderEntityView>("","#8036f2b5-727c-42e9-a713-fea0bafc6a6e .ag-row[role='row']@ROWINDEX [col-id='cCost']","",true, this.CurrentView);
 
            Comments = RPSControlFactory.CreateRPSGridMemoTextBox<MaintenanceOrderEntityView>("","#8036f2b5-727c-42e9-a713-fea0bafc6a6e .ag-row[role='row']@ROWINDEX [col-id='cComments']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<MaintenanceOrderEntityView> IDMaintenanceResource { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderEntityView> Date { get; set; } 
        public IRPSGridDurationTextBox<MaintenanceOrderEntityView> Duration { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderEntityView> UnitCost { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderEntityView> Cost { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderEntityView> Comments { get; set; } 
                     
    }
 
        public partial class ManOrderEmployeeExpensessCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView>:RPSCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> where MaintenanceOrderEntityView : class, IView where MaintenanceOrderEmployeeView : class, IView
    {
        public  ManOrderEmployeeExpensessGridView<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> GridView {get;set;}
    }
    public partial class ManOrderEmployeeExpensessGridView <MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> :  RPSGridView<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> where MaintenanceOrderEntityView : class, IView where MaintenanceOrderEmployeeView : class, IView
    {
        public ManOrderEmployeeExpensessGridView(MaintenanceOrderEntityView currentView,MaintenanceOrderEmployeeView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDEmployee = RPSControlFactory.CreateRPSGridComboBox<MaintenanceOrderEntityView>("","#88ba32bb-1452-4e19-9017-d627e899d539 .ag-row[role='row']@ROWINDEX [col-id='cIDEmployee']","",true, this.CurrentView);
 
            StartDate = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderEntityView>("","#88ba32bb-1452-4e19-9017-d627e899d539 .ag-row[role='row']@ROWINDEX [col-id='cStartDate']","",true, this.CurrentView);
 
            EndDate = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderEntityView>("","#88ba32bb-1452-4e19-9017-d627e899d539 .ag-row[role='row']@ROWINDEX [col-id='cEndDate']","",true, this.CurrentView);
 
            Destination = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderEntityView>("","#88ba32bb-1452-4e19-9017-d627e899d539 .ag-row[role='row']@ROWINDEX [col-id='cDestination']","",true, this.CurrentView);
 
            UITotal = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenanceOrderEntityView>("","#88ba32bb-1452-4e19-9017-d627e899d539 .ag-row[role='row']@ROWINDEX [col-id='cUITotal']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<MaintenanceOrderEntityView> IDEmployee { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderEntityView> StartDate { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderEntityView> EndDate { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderEntityView> Destination { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderEntityView> UITotal { get; set; } 
                     
    }
 
        public partial class MaintenanceOrderExpensessCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView>:RPSCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> where MaintenanceOrderEntityView : class, IView where MaintenanceOrderEmployeeView : class, IView
    {
        public  MaintenanceOrderExpensessGridView<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> GridView {get;set;}
    }
    public partial class MaintenanceOrderExpensessGridView <MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> :  RPSGridView<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> where MaintenanceOrderEntityView : class, IView where MaintenanceOrderEmployeeView : class, IView
    {
        public MaintenanceOrderExpensessGridView(MaintenanceOrderEntityView currentView,MaintenanceOrderEmployeeView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Invoice = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderEntityView>("","#d71ab787-30fd-46eb-bc3d-39e9531d7de4 .ag-row[role='row']@ROWINDEX [col-id='cInvoice']","",true, this.CurrentView);
 
            Date = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderEntityView>("","#d71ab787-30fd-46eb-bc3d-39e9531d7de4 .ag-row[role='row']@ROWINDEX [col-id='cDate']","",true, this.CurrentView);
 
            Concept = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderEntityView>("","#d71ab787-30fd-46eb-bc3d-39e9531d7de4 .ag-row[role='row']@ROWINDEX [col-id='cConcept']","",false, this.CurrentView);
 
            Cost = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenanceOrderEntityView>("","#d71ab787-30fd-46eb-bc3d-39e9531d7de4 .ag-row[role='row']@ROWINDEX [col-id='cCost']","",true, this.CurrentView);
 
            BillableForSales = RPSControlFactory.CreateRPSGridCheckBox<MaintenanceOrderEntityView>("","#d71ab787-30fd-46eb-bc3d-39e9531d7de4 .ag-row[role='row']@ROWINDEX [col-id='cBillableForSales']","",true, this.CurrentView);
 
            IsPosting = RPSControlFactory.CreateRPSGridCheckBox<MaintenanceOrderEntityView>("","#d71ab787-30fd-46eb-bc3d-39e9531d7de4 .ag-row[role='row']@ROWINDEX [col-id='cIsPosting']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<MaintenanceOrderEntityView> Invoice { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderEntityView> Date { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderEntityView> Concept { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderEntityView> Cost { get; set; } 
        public IRPSGridCheckbox<MaintenanceOrderEntityView> BillableForSales { get; set; } 
        public IRPSGridCheckbox<MaintenanceOrderEntityView> IsPosting { get; set; } 
                     
    }
 
        public partial class MANMaintenanceOrderProceduresCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView>:RPSCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> where MaintenanceOrderEntityView : class, IView where MaintenanceOrderEmployeeView : class, IView
    {
        public  MANMaintenanceOrderProceduresGridView<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> GridView {get;set;}
    }
    public partial class MANMaintenanceOrderProceduresGridView <MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> :  RPSGridView<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> where MaintenanceOrderEntityView : class, IView where MaintenanceOrderEmployeeView : class, IView
    {
        public MANMaintenanceOrderProceduresGridView(MaintenanceOrderEntityView currentView,MaintenanceOrderEmployeeView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDMaintenanceProcedure = RPSControlFactory.CreateRPSGridComboBox<MaintenanceOrderEntityView>("","#c68898e1-1c3d-43ff-acf1-ded51eb9e7b5 .ag-row[role='row']@ROWINDEX [col-id='cIDMaintenanceProcedure']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderEntityView>("","#c68898e1-1c3d-43ff-acf1-ded51eb9e7b5 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<MaintenanceOrderEntityView> IDMaintenanceProcedure { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderEntityView> Description { get; set; } 
                     
    }
 
        public partial class MaintenanceOrderPredictivesCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView>:RPSCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> where MaintenanceOrderEntityView : class, IView where MaintenanceOrderEmployeeView : class, IView
    {
        public  MaintenanceOrderPredictivesGridView<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> GridView {get;set;}
    }
    public partial class MaintenanceOrderPredictivesGridView <MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> :  RPSGridView<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> where MaintenanceOrderEntityView : class, IView where MaintenanceOrderEmployeeView : class, IView
    {
        public MaintenanceOrderPredictivesGridView(MaintenanceOrderEntityView currentView,MaintenanceOrderEmployeeView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ControlFeatureCode = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderEntityView>("","#f5af1cd9-2301-4475-b17b-4fcfed722ff4 .ag-row[role='row']@ROWINDEX [col-id='cControlFeatureCode']","",true, this.CurrentView);
 
            ControlFeatureDesc = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderEntityView>("","#f5af1cd9-2301-4475-b17b-4fcfed722ff4 .ag-row[role='row']@ROWINDEX [col-id='cControlFeatureDesc']","",false, this.CurrentView);
 
            ControlType = RPSControlFactory.CreateRPSGridEnumComboBox<MaintenanceOrderEntityView>("","#f5af1cd9-2301-4475-b17b-4fcfed722ff4 .ag-row[role='row']@ROWINDEX [col-id='cControlType']","",true, this.CurrentView);
 
            MinimumValue = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenanceOrderEntityView>("","#f5af1cd9-2301-4475-b17b-4fcfed722ff4 .ag-row[role='row']@ROWINDEX [col-id='cMinimumValue']","",true, this.CurrentView);
 
            MaximumValue = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenanceOrderEntityView>("","#f5af1cd9-2301-4475-b17b-4fcfed722ff4 .ag-row[role='row']@ROWINDEX [col-id='cMaximumValue']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<MaintenanceOrderEntityView> ControlFeatureCode { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderEntityView> ControlFeatureDesc { get; set; } 
        public IRPSGridComboBox<MaintenanceOrderEntityView> ControlType { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderEntityView> MinimumValue { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderEntityView> MaximumValue { get; set; } 
                     
    }
 
        public partial class MaintenanceOrderAssociateOrdersCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView>:RPSCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> where MaintenanceOrderEntityView : class, IView where MaintenanceOrderEmployeeView : class, IView
    {
        public  MaintenanceOrderAssociateOrdersGridView<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> GridView {get;set;}
    }
    public partial class MaintenanceOrderAssociateOrdersGridView <MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> :  RPSGridView<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> where MaintenanceOrderEntityView : class, IView where MaintenanceOrderEmployeeView : class, IView
    {
        public MaintenanceOrderAssociateOrdersGridView(MaintenanceOrderEntityView currentView,MaintenanceOrderEmployeeView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDAssociateWarning = RPSControlFactory.CreateRPSGridComboBox<MaintenanceOrderEntityView>("","#b8067366-3219-4372-902c-f05a56e798cd .ag-row[role='row']@ROWINDEX [col-id='cIDAssociateWarning']","",true, this.CurrentView);
 
            UIEntryDate = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderEntityView>("","#b8067366-3219-4372-902c-f05a56e798cd .ag-row[role='row']@ROWINDEX [col-id='cUIEntryDate']","",false, this.CurrentView);
 
            UIClosingDate = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderEntityView>("","#b8067366-3219-4372-902c-f05a56e798cd .ag-row[role='row']@ROWINDEX [col-id='cUIClosingDate']","",false, this.CurrentView);
 
            UIMaintenanceWarningType = RPSControlFactory.CreateRPSGridComboBox<MaintenanceOrderEntityView>("","#b8067366-3219-4372-902c-f05a56e798cd .ag-row[role='row']@ROWINDEX [col-id='cUIMaintenanceWarningType']","",false, this.CurrentView);
 
            UIMaintenanceWarningStatus = RPSControlFactory.CreateRPSGridComboBox<MaintenanceOrderEntityView>("","#b8067366-3219-4372-902c-f05a56e798cd .ag-row[role='row']@ROWINDEX [col-id='cUIMaintenanceWarningStatus']","",false, this.CurrentView);
 
            UIMaintenanceWarningPriority = RPSControlFactory.CreateRPSGridComboBox<MaintenanceOrderEntityView>("","#b8067366-3219-4372-902c-f05a56e798cd .ag-row[role='row']@ROWINDEX [col-id='cUIMaintenanceWarningPriority']","",false, this.CurrentView);
 
            UIMaintenanceWarningSeverity = RPSControlFactory.CreateRPSGridComboBox<MaintenanceOrderEntityView>("","#b8067366-3219-4372-902c-f05a56e798cd .ag-row[role='row']@ROWINDEX [col-id='cUIMaintenanceWarningSeverity']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<MaintenanceOrderEntityView> IDAssociateWarning { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderEntityView> UIEntryDate { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderEntityView> UIClosingDate { get; set; } 
        public IRPSGridComboBox<MaintenanceOrderEntityView> UIMaintenanceWarningType { get; set; } 
        public IRPSGridComboBox<MaintenanceOrderEntityView> UIMaintenanceWarningStatus { get; set; } 
        public IRPSGridComboBox<MaintenanceOrderEntityView> UIMaintenanceWarningPriority { get; set; } 
        public IRPSGridComboBox<MaintenanceOrderEntityView> UIMaintenanceWarningSeverity { get; set; } 
                     
    }
 
        public partial class MaintenanceOrderRelationsCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView>:RPSCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> where MaintenanceOrderEntityView : class, IView where MaintenanceOrderEmployeeView : class, IView
    {
        public  MaintenanceOrderRelationsGridView<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> GridView {get;set;}
    }
    public partial class MaintenanceOrderRelationsGridView <MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> :  RPSGridView<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> where MaintenanceOrderEntityView : class, IView where MaintenanceOrderEmployeeView : class, IView
    {
        public MaintenanceOrderRelationsGridView(MaintenanceOrderEntityView currentView,MaintenanceOrderEmployeeView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDMaintenanceOrderPredecessor = RPSControlFactory.CreateRPSGridComboBox<MaintenanceOrderEntityView>("","#f9bb0e82-1666-413f-9dcf-102ed927942a .ag-row[role='row']@ROWINDEX [col-id='cIDMaintenanceOrderPredecessor']","",true, this.CurrentView);
 
            RelationType = RPSControlFactory.CreateRPSGridEnumComboBox<MaintenanceOrderEntityView>("","#f9bb0e82-1666-413f-9dcf-102ed927942a .ag-row[role='row']@ROWINDEX [col-id='cRelationType']","",false, this.CurrentView);
 
            TimeLag = RPSControlFactory.CreateRPSGridDurationTextBox<MaintenanceOrderEntityView>("","#f9bb0e82-1666-413f-9dcf-102ed927942a .ag-row[role='row']@ROWINDEX [col-id='cTimeLag']","",true, this.CurrentView);
 
            Linked = RPSControlFactory.CreateRPSGridCheckBox<MaintenanceOrderEntityView>("","#f9bb0e82-1666-413f-9dcf-102ed927942a .ag-row[role='row']@ROWINDEX [col-id='cLinked']","",true, this.CurrentView);
 
            CalendarType = RPSControlFactory.CreateRPSGridEnumComboBox<MaintenanceOrderEntityView>("","#f9bb0e82-1666-413f-9dcf-102ed927942a .ag-row[role='row']@ROWINDEX [col-id='cCalendarType']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<MaintenanceOrderEntityView> IDMaintenanceOrderPredecessor { get; set; } 
        public IRPSGridComboBox<MaintenanceOrderEntityView> RelationType { get; set; } 
        public IRPSGridDurationTextBox<MaintenanceOrderEntityView> TimeLag { get; set; } 
        public IRPSGridCheckbox<MaintenanceOrderEntityView> Linked { get; set; } 
        public IRPSGridComboBox<MaintenanceOrderEntityView> CalendarType { get; set; } 
                     
    }
 
        public partial class MaintenanceAppointmentConsultCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView>:RPSCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> where MaintenanceOrderEntityView : class, IView where MaintenanceOrderEmployeeView : class, IView
    {
        public  MaintenanceAppointmentConsultGridView<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> GridView {get;set;}
    }
    public partial class MaintenanceAppointmentConsultGridView <MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> :  RPSGridView<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> where MaintenanceOrderEntityView : class, IView where MaintenanceOrderEmployeeView : class, IView
    {
        public MaintenanceAppointmentConsultGridView(MaintenanceOrderEntityView currentView,MaintenanceOrderEmployeeView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Appointment_AppointmentDate = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderEntityView>("","#420e1575-d829-414a-8fd0-1302a113ee60 .ag-row[role='row']@ROWINDEX [col-id='cAppointment_AppointmentDate']","",false, this.CurrentView);
 
            AppointmentEndHour = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderEntityView>("","#420e1575-d829-414a-8fd0-1302a113ee60 .ag-row[role='row']@ROWINDEX [col-id='cAppointmentEndHour']","",false, this.CurrentView);
 
            AppointmentStartHour = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderEntityView>("","#420e1575-d829-414a-8fd0-1302a113ee60 .ag-row[role='row']@ROWINDEX [col-id='cAppointmentStartHour']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MaintenanceOrderEntityView> Appointment_AppointmentDate { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderEntityView> AppointmentEndHour { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderEntityView> AppointmentStartHour { get; set; } 
                     
    }
 
        public partial class ManOrderDimensionsCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView>:RPSCollectionEditor<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> where MaintenanceOrderEntityView : class, IView where MaintenanceOrderEmployeeView : class, IView
    {
        public  ManOrderDimensionsGridView<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> GridView {get;set;}
    }
    public partial class ManOrderDimensionsGridView <MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> :  RPSGridView<MaintenanceOrderEntityView,MaintenanceOrderEmployeeView> where MaintenanceOrderEntityView : class, IView where MaintenanceOrderEmployeeView : class, IView
    {
        public ManOrderDimensionsGridView(MaintenanceOrderEntityView currentView,MaintenanceOrderEmployeeView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDDimension = RPSControlFactory.CreateRPSGridComboBox<MaintenanceOrderEntityView>("","#b2c7126a-cf49-463a-b970-2c96671c7b9e .ag-row[role='row']@ROWINDEX [col-id='cIDDimension']","",true, this.CurrentView);
 
            IDDimValue = RPSControlFactory.CreateRPSGridComboBox<MaintenanceOrderEntityView>("","#b2c7126a-cf49-463a-b970-2c96671c7b9e .ag-row[role='row']@ROWINDEX [col-id='cIDDimValue']","",false, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenanceOrderEntityView>("","#b2c7126a-cf49-463a-b970-2c96671c7b9e .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<MaintenanceOrderEntityView> IDDimension { get; set; } 
        public IRPSGridComboBox<MaintenanceOrderEntityView> IDDimValue { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderEntityView> Percentage { get; set; } 
                     
    }
 
    }
  
            
    public partial class MaintenanceOrderMaterialView : View
    {
        public MaintenanceOrderMaterialView(MaintenanceOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceOrderMaterialView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceOrderMaterialView,MaintenanceOrderEntityView>( this,Screen.MaintenanceOrderEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceOrderMaterialView,MaintenanceOrderEntityView>( this,Screen.MaintenanceOrderEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MaintenanceOrderMaterialView,MaintenanceOrderEntityView>( this,Screen.MaintenanceOrderEntityView);
 
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
 
            BillableForSales = RPSControlFactory.CreateRPSCheckBox<MaintenanceOrderMaterialView>("4c71f186-3835-4342-9cab-2bc79812d423","","",true, this);
 
            IsPosting = RPSControlFactory.CreateRPSCheckBox<MaintenanceOrderMaterialView>("3a807d5a-f298-45d2-a292-81ad7e519f41","","",false, this);
 
            ExpiryDate = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderMaterialView>("d2c3fe38-31c7-4e82-a73e-b352fb0367cf","","",false, this);
 
            IDDeliveryNote = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderMaterialView>("36d13bbe-40ac-4fbe-95f5-2bbb7276e426","","",false, this);
 
            IDManufacturingOrder = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderMaterialView>("cd69c636-97cf-4ba4-ae7e-66a4269bf72e","","",false, this);
 
            ExecuteAppendTechnicalDescriptionToComment = RPSControlFactory.CreateRPSButton<MaintenanceOrderMaterialView>( "34248728-f96b-4dd7-9572-9ccbd1c2f80b","","",this);
 
            Comments = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderMaterialView>("76aa1dc3-7b6f-44c0-9fb9-5aac8dcf8a09","","",false, this);
 
            GeneralData = RPSControlFactory.CreateRPSSection<MaintenanceOrderMaterialView>( "","ul li[rpsid='8a377ab8-5ac1-4138-bc2b-60d94bec3784']","",this);
 
            Comments1 = RPSControlFactory.CreateRPSSection<MaintenanceOrderMaterialView>( "","ul li[rpsid='a0100ec7-536e-498e-8236-8074cd7adb26']","",this);
 

        }
        public IRPSButton<MaintenanceOrderMaterialView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceOrderMaterialView,MaintenanceOrderEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceOrderMaterialView,MaintenanceOrderEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<MaintenanceOrderMaterialView,MaintenanceOrderEntityView> AcceptButton { get; set; } 
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
        public IRPSCheckbox<MaintenanceOrderMaterialView> BillableForSales { get; set; } 
        public IRPSCheckbox<MaintenanceOrderMaterialView> IsPosting { get; set; } 
        public IRPSTextBox<MaintenanceOrderMaterialView> ExpiryDate { get; set; } 
        public IRPSComboBox<MaintenanceOrderMaterialView> IDDeliveryNote { get; set; } 
        public IRPSComboBox<MaintenanceOrderMaterialView> IDManufacturingOrder { get; set; } 
        public IRPSButton<MaintenanceOrderMaterialView> ExecuteAppendTechnicalDescriptionToComment { get; set; } 
        public IRPSTextBox<MaintenanceOrderMaterialView> Comments { get; set; } 
        public IRPSSection<MaintenanceOrderMaterialView> GeneralData { get; set; } 
        public IRPSSection<MaintenanceOrderMaterialView> Comments1 { get; set; } 
        public MaintenanceOrder Screen { get; set; }
        public MaintenanceOrderMaterialView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenanceOrderDefectView : View
    {
        public MaintenanceOrderDefectView(MaintenanceOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceOrderDefectView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceOrderDefectView,MaintenanceOrderEntityView>( this,Screen.MaintenanceOrderEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceOrderDefectView,MaintenanceOrderEntityView>( this,Screen.MaintenanceOrderEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MaintenanceOrderDefectView,MaintenanceOrderEntityView>( this,Screen.MaintenanceOrderEntityView);
 
            IDMaintenanceDefect = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderDefectView>("b29db9b7-b32d-4092-8b97-f09a7d117885","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderDefectView>("c2e25919-25be-4263-80d5-100c1e7dfe5f","","",false, this);
 
            IDMaintenanceComponent = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderDefectView>("d4582f5e-1617-4d5a-b55b-3053bc1404c6","","",false, this);
 
            CollectionInit params_MaintenanceOrderCauses = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="16349beb-3149-4736-8e18-7ae1afcad97a",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceOrderCauses = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceOrderCausesCollectionEditor<MaintenanceOrderDefectView,MaintenanceOrderSolutionView>,MaintenanceOrderDefectView,MaintenanceOrderSolutionView>( params_MaintenanceOrderCauses,this,Screen.MaintenanceOrderSolutionView);
 
            CollectionInit params_MaintenanceOrderSolutions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7ac347b9-f1d1-458c-a273-54731c3f8af3",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceOrderSolutions = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceOrderSolutionsCollectionEditor<MaintenanceOrderDefectView,MaintenanceOrderSolutionView>,MaintenanceOrderDefectView,MaintenanceOrderSolutionView>( params_MaintenanceOrderSolutions,this,Screen.MaintenanceOrderSolutionView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<MaintenanceOrderDefectView>( "","ul li[rpsid='3c03cd97-4b79-4201-a926-fc6816709f07']","",this);
 

        }
        public IRPSButton<MaintenanceOrderDefectView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceOrderDefectView,MaintenanceOrderEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceOrderDefectView,MaintenanceOrderEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<MaintenanceOrderDefectView,MaintenanceOrderEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<MaintenanceOrderDefectView> IDMaintenanceDefect { get; set; } 
        public IRPSTextBox<MaintenanceOrderDefectView> Description { get; set; } 
        public IRPSComboBox<MaintenanceOrderDefectView> IDMaintenanceComponent { get; set; } 
        public MaintenanceOrderCausesCollectionEditor<MaintenanceOrderDefectView,MaintenanceOrderSolutionView> MaintenanceOrderCauses { get; set; } 
        public MaintenanceOrderSolutionsCollectionEditor<MaintenanceOrderDefectView,MaintenanceOrderSolutionView> MaintenanceOrderSolutions { get; set; } 
        public IRPSSection<MaintenanceOrderDefectView> GeneralData { get; set; } 
        public MaintenanceOrder Screen { get; set; }
        public MaintenanceOrderDefectView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaintenanceOrderCausesCollectionEditor<MaintenanceOrderDefectView,MaintenanceOrderSolutionView>:RPSCollectionEditor<MaintenanceOrderDefectView,MaintenanceOrderSolutionView> where MaintenanceOrderDefectView : class, IView where MaintenanceOrderSolutionView : class, IView
    {
        public  MaintenanceOrderCausesGridView<MaintenanceOrderDefectView,MaintenanceOrderSolutionView> GridView {get;set;}
    }
    public partial class MaintenanceOrderCausesGridView <MaintenanceOrderDefectView,MaintenanceOrderSolutionView> :  RPSGridView<MaintenanceOrderDefectView,MaintenanceOrderSolutionView> where MaintenanceOrderDefectView : class, IView where MaintenanceOrderSolutionView : class, IView
    {
        public MaintenanceOrderCausesGridView(MaintenanceOrderDefectView currentView,MaintenanceOrderSolutionView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDMaintenanceCause = RPSControlFactory.CreateRPSGridComboBox<MaintenanceOrderDefectView>("","#16349beb-3149-4736-8e18-7ae1afcad97a .ag-row[role='row']@ROWINDEX [col-id='cIDMaintenanceCause']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderDefectView>("","#16349beb-3149-4736-8e18-7ae1afcad97a .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<MaintenanceOrderDefectView> IDMaintenanceCause { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderDefectView> Description { get; set; } 
                     
    }
 
        public partial class MaintenanceOrderSolutionsCollectionEditor<MaintenanceOrderDefectView,MaintenanceOrderSolutionView>:RPSCollectionEditor<MaintenanceOrderDefectView,MaintenanceOrderSolutionView> where MaintenanceOrderDefectView : class, IView where MaintenanceOrderSolutionView : class, IView
    {
        public  MaintenanceOrderSolutionsGridView<MaintenanceOrderDefectView,MaintenanceOrderSolutionView> GridView {get;set;}
    }
    public partial class MaintenanceOrderSolutionsGridView <MaintenanceOrderDefectView,MaintenanceOrderSolutionView> :  RPSGridView<MaintenanceOrderDefectView,MaintenanceOrderSolutionView> where MaintenanceOrderDefectView : class, IView where MaintenanceOrderSolutionView : class, IView
    {
        public MaintenanceOrderSolutionsGridView(MaintenanceOrderDefectView currentView,MaintenanceOrderSolutionView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDMaintenanceSolution = RPSControlFactory.CreateRPSGridComboBox<MaintenanceOrderDefectView>("","#7ac347b9-f1d1-458c-a273-54731c3f8af3 .ag-row[role='row']@ROWINDEX [col-id='cIDMaintenanceSolution']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderDefectView>("","#7ac347b9-f1d1-458c-a273-54731c3f8af3 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<MaintenanceOrderDefectView> IDMaintenanceSolution { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderDefectView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class MaintenanceOrderSolutionView : View
    {
        public MaintenanceOrderSolutionView(MaintenanceOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceOrderSolutionView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceOrderSolutionView,MaintenanceOrderDefectView>( this,Screen.MaintenanceOrderDefectView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceOrderSolutionView,MaintenanceOrderDefectView>( this,Screen.MaintenanceOrderDefectView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MaintenanceOrderSolutionView,MaintenanceOrderDefectView>( this,Screen.MaintenanceOrderDefectView);
 
            IDMaintenanceSolution = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderSolutionView>("1dd277d1-f84c-43af-9d3d-615fd4a0fa24","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderSolutionView>("47b9a45c-7db0-472e-a03b-6b17447643d9","","",false, this);
 

        }
        public IRPSButton<MaintenanceOrderSolutionView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceOrderSolutionView,MaintenanceOrderDefectView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceOrderSolutionView,MaintenanceOrderDefectView> BackButton { get; set; } 
        public IRPSAcceptButton<MaintenanceOrderSolutionView,MaintenanceOrderDefectView> AcceptButton { get; set; } 
        public IRPSComboBox<MaintenanceOrderSolutionView> IDMaintenanceSolution { get; set; } 
        public IRPSTextBox<MaintenanceOrderSolutionView> Description { get; set; } 
        public MaintenanceOrder Screen { get; set; }
        public MaintenanceOrderSolutionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenanceOrderCauseView : View
    {
        public MaintenanceOrderCauseView(MaintenanceOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceOrderCauseView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceOrderCauseView,MaintenanceOrderDefectView>( this,Screen.MaintenanceOrderDefectView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceOrderCauseView,MaintenanceOrderDefectView>( this,Screen.MaintenanceOrderDefectView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MaintenanceOrderCauseView,MaintenanceOrderDefectView>( this,Screen.MaintenanceOrderDefectView);
 
            IDMaintenanceCause = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderCauseView>("4986f76f-e661-4232-b11a-2d375e531a40","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderCauseView>("5a279c9e-4d8d-4414-90c1-f35bd79f9093","","",false, this);
 

        }
        public IRPSButton<MaintenanceOrderCauseView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceOrderCauseView,MaintenanceOrderDefectView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceOrderCauseView,MaintenanceOrderDefectView> BackButton { get; set; } 
        public IRPSAcceptButton<MaintenanceOrderCauseView,MaintenanceOrderDefectView> AcceptButton { get; set; } 
        public IRPSComboBox<MaintenanceOrderCauseView> IDMaintenanceCause { get; set; } 
        public IRPSTextBox<MaintenanceOrderCauseView> Description { get; set; } 
        public MaintenanceOrder Screen { get; set; }
        public MaintenanceOrderCauseView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenanceOrderEmployeeView : View
    {
        public MaintenanceOrderEmployeeView(MaintenanceOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceOrderEmployeeView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceOrderEmployeeView,MaintenanceOrderEntityView>( this,Screen.MaintenanceOrderEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceOrderEmployeeView,MaintenanceOrderEntityView>( this,Screen.MaintenanceOrderEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MaintenanceOrderEmployeeView,MaintenanceOrderEntityView>( this,Screen.MaintenanceOrderEntityView);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderEmployeeView>("b611f601-9447-41bb-8058-140cdf6b610b","","",true, this);
 
            IDQualify = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderEmployeeView>("24b5e0ce-90dc-4144-95e8-0a521c473154","","",false, this);
 
            IDHourType = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderEmployeeView>("1f14aae9-6c8a-431d-ab6a-dcaca9fd290c","","",true, this);
 
            InitialDate = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderEmployeeView>("809f6025-5b52-491c-b391-d63508b74a74","","",false, this);
 
            FinalDate = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderEmployeeView>("8eb739b1-8ba0-4e29-985a-b3b1982d6509","","",false, this);
 
            InitialTime = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderEmployeeView>("23d63ecb-cdd7-4afa-9b33-3846e61876a5","","",false, this);
 
            FinalTime = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderEmployeeView>("bdb19c93-b946-4a22-ac98-c1763b7106f2","","",false, this);
 
            Duration = RPSControlFactory.CreateRPSDurationTextBox<MaintenanceOrderEmployeeView>("3560c9d0-fd97-4fe3-a89c-6e9a3bb5d791","","",true, this);
 
            UnitCost = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceOrderEmployeeView>("33977aa2-8a5e-411d-84ac-038f16f868a3","","",false, this);
 
            Cost = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceOrderEmployeeView>("11b059f5-a898-4bd7-a5a8-38117e6454c9","","",false, this);
 
            BillableForSales = RPSControlFactory.CreateRPSCheckBox<MaintenanceOrderEmployeeView>("c6f1885c-3151-4c82-9ac5-4abf0a35922d","","",true, this);
 
            IsPosting = RPSControlFactory.CreateRPSCheckBox<MaintenanceOrderEmployeeView>("4af1325b-12fa-4176-b315-4a519d677ea7","","",true, this);
 
            Comments = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderEmployeeView>("4ce68ec3-d1d0-4b8c-b3ec-8164213703aa","","",false, this);
 
            GeneralData = RPSControlFactory.CreateRPSSection<MaintenanceOrderEmployeeView>( "","ul li[rpsid='4d3bf9f1-c656-4f97-a0ed-0f2d9cf89bc2']","",this);
 
            Comments1 = RPSControlFactory.CreateRPSSection<MaintenanceOrderEmployeeView>( "","ul li[rpsid='0acada93-e2d6-48be-8388-11b17c5f024a']","",this);
 

        }
        public IRPSButton<MaintenanceOrderEmployeeView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceOrderEmployeeView,MaintenanceOrderEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceOrderEmployeeView,MaintenanceOrderEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<MaintenanceOrderEmployeeView,MaintenanceOrderEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<MaintenanceOrderEmployeeView> IDEmployee { get; set; } 
        public IRPSComboBox<MaintenanceOrderEmployeeView> IDQualify { get; set; } 
        public IRPSComboBox<MaintenanceOrderEmployeeView> IDHourType { get; set; } 
        public IRPSTextBox<MaintenanceOrderEmployeeView> InitialDate { get; set; } 
        public IRPSTextBox<MaintenanceOrderEmployeeView> FinalDate { get; set; } 
        public IRPSTextBox<MaintenanceOrderEmployeeView> InitialTime { get; set; } 
        public IRPSTextBox<MaintenanceOrderEmployeeView> FinalTime { get; set; } 
        public IRPSDurationTextBox<MaintenanceOrderEmployeeView> Duration { get; set; } 
        public IRPSTextBox<MaintenanceOrderEmployeeView> UnitCost { get; set; } 
        public IRPSTextBox<MaintenanceOrderEmployeeView> Cost { get; set; } 
        public IRPSCheckbox<MaintenanceOrderEmployeeView> BillableForSales { get; set; } 
        public IRPSCheckbox<MaintenanceOrderEmployeeView> IsPosting { get; set; } 
        public IRPSTextBox<MaintenanceOrderEmployeeView> Comments { get; set; } 
        public IRPSSection<MaintenanceOrderEmployeeView> GeneralData { get; set; } 
        public IRPSSection<MaintenanceOrderEmployeeView> Comments1 { get; set; } 
        public MaintenanceOrder Screen { get; set; }
        public MaintenanceOrderEmployeeView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenanceOrderSubcontractView : View
    {
        public MaintenanceOrderSubcontractView(MaintenanceOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceOrderSubcontractView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceOrderSubcontractView,MaintenanceOrderEntityView>( this,Screen.MaintenanceOrderEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceOrderSubcontractView,MaintenanceOrderEntityView>( this,Screen.MaintenanceOrderEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MaintenanceOrderSubcontractView,MaintenanceOrderEntityView>( this,Screen.MaintenanceOrderEntityView);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderSubcontractView>("f8769d45-be32-4516-b2a5-973d039dc359","","",true, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderSubcontractView>("adda2073-e965-4e1b-8bd4-96c0b6847a18","","",true, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderSubcontractView>("f1d5c816-4022-4b72-bfe7-5df7d01f48aa","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceOrderSubcontractView>("2b9066ec-8b92-4050-97c6-e7b511c7b7bd","","",true, this);
 
            UnitCost = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceOrderSubcontractView>("aa63d42d-376f-46ec-af9f-2caf38708be5","","",false, this);
 
            Cost = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceOrderSubcontractView>("7656df69-c811-4963-a09b-929823975dd4","","",false, this);
 
            BillableForSales = RPSControlFactory.CreateRPSCheckBox<MaintenanceOrderSubcontractView>("388a63b1-0138-4293-98da-bdee1ed3b95a","","",true, this);
 
            BillableForPurchase = RPSControlFactory.CreateRPSCheckBox<MaintenanceOrderSubcontractView>("07d879d4-9222-4d11-9fb5-fa34c0c06420","","",true, this);
 
            IsPosting = RPSControlFactory.CreateRPSCheckBox<MaintenanceOrderSubcontractView>("9d626ca1-05eb-453e-9910-cce8b6ea85bb","","",true, this);
 
            Comments = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderSubcontractView>("ab99669b-d570-4020-b2dd-345cc5e3bce1","","",false, this);
 
            GeneralData = RPSControlFactory.CreateRPSSection<MaintenanceOrderSubcontractView>( "","ul li[rpsid='6cf68d0f-f29f-49f0-ac42-7cbdca5fea76']","",this);
 
            Comments1 = RPSControlFactory.CreateRPSSection<MaintenanceOrderSubcontractView>( "","ul li[rpsid='bf095c42-fe0e-474f-86ce-fc4c5dedbefc']","",this);
 

        }
        public IRPSButton<MaintenanceOrderSubcontractView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceOrderSubcontractView,MaintenanceOrderEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceOrderSubcontractView,MaintenanceOrderEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<MaintenanceOrderSubcontractView,MaintenanceOrderEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<MaintenanceOrderSubcontractView> IDArticle { get; set; } 
        public IRPSComboBox<MaintenanceOrderSubcontractView> IDSupplier { get; set; } 
        public IRPSTextBox<MaintenanceOrderSubcontractView> Date { get; set; } 
        public IRPSTextBox<MaintenanceOrderSubcontractView> Quantity { get; set; } 
        public IRPSTextBox<MaintenanceOrderSubcontractView> UnitCost { get; set; } 
        public IRPSTextBox<MaintenanceOrderSubcontractView> Cost { get; set; } 
        public IRPSCheckbox<MaintenanceOrderSubcontractView> BillableForSales { get; set; } 
        public IRPSCheckbox<MaintenanceOrderSubcontractView> BillableForPurchase { get; set; } 
        public IRPSCheckbox<MaintenanceOrderSubcontractView> IsPosting { get; set; } 
        public IRPSTextBox<MaintenanceOrderSubcontractView> Comments { get; set; } 
        public IRPSSection<MaintenanceOrderSubcontractView> GeneralData { get; set; } 
        public IRPSSection<MaintenanceOrderSubcontractView> Comments1 { get; set; } 
        public MaintenanceOrder Screen { get; set; }
        public MaintenanceOrderSubcontractView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenanceOrderResourceView : View
    {
        public MaintenanceOrderResourceView(MaintenanceOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceOrderResourceView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceOrderResourceView,MaintenanceOrderEntityView>( this,Screen.MaintenanceOrderEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceOrderResourceView,MaintenanceOrderEntityView>( this,Screen.MaintenanceOrderEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MaintenanceOrderResourceView,MaintenanceOrderEntityView>( this,Screen.MaintenanceOrderEntityView);
 
            IDMaintenanceResource = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderResourceView>("dc0229e8-1e84-4987-92d8-f06667d59694","","",true, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderResourceView>("0ed9beac-40c4-423e-a828-7a07b2302954","","",true, this);
 
            Duration = RPSControlFactory.CreateRPSDurationTextBox<MaintenanceOrderResourceView>("f0b66951-ac21-4bb0-8448-474ca17e4f67","","",false, this);
 
            UnitCost = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceOrderResourceView>("ab1f230a-f888-4d85-b754-be9f34eff385","","",true, this);
 
            Cost = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceOrderResourceView>("2452d4f9-9f64-4a6a-abd9-9089e45bfa6c","","",true, this);
 
            BillableForSales = RPSControlFactory.CreateRPSCheckBox<MaintenanceOrderResourceView>("f9513e5f-2dfa-4f35-9dfb-e697c8725936","","",true, this);
 
            IsPosting = RPSControlFactory.CreateRPSCheckBox<MaintenanceOrderResourceView>("6bc6d39f-100e-4fd2-92de-7657b965f5a3","","",true, this);
 
            Comments = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderResourceView>("de2e6036-2ef1-475e-89d4-29d1dddf4ee7","","",false, this);
 
            GeneralData = RPSControlFactory.CreateRPSSection<MaintenanceOrderResourceView>( "","ul li[rpsid='3e026cd8-5388-45e3-a840-e5156fc0e096']","",this);
 
            Comments1 = RPSControlFactory.CreateRPSSection<MaintenanceOrderResourceView>( "","ul li[rpsid='a97e3b72-a85d-4c93-ae95-77d98f78013b']","",this);
 

        }
        public IRPSButton<MaintenanceOrderResourceView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceOrderResourceView,MaintenanceOrderEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceOrderResourceView,MaintenanceOrderEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<MaintenanceOrderResourceView,MaintenanceOrderEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<MaintenanceOrderResourceView> IDMaintenanceResource { get; set; } 
        public IRPSTextBox<MaintenanceOrderResourceView> Date { get; set; } 
        public IRPSDurationTextBox<MaintenanceOrderResourceView> Duration { get; set; } 
        public IRPSTextBox<MaintenanceOrderResourceView> UnitCost { get; set; } 
        public IRPSTextBox<MaintenanceOrderResourceView> Cost { get; set; } 
        public IRPSCheckbox<MaintenanceOrderResourceView> BillableForSales { get; set; } 
        public IRPSCheckbox<MaintenanceOrderResourceView> IsPosting { get; set; } 
        public IRPSTextBox<MaintenanceOrderResourceView> Comments { get; set; } 
        public IRPSSection<MaintenanceOrderResourceView> GeneralData { get; set; } 
        public IRPSSection<MaintenanceOrderResourceView> Comments1 { get; set; } 
        public MaintenanceOrder Screen { get; set; }
        public MaintenanceOrderResourceView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ManOrderEmployeeExpensesView : View
    {
        public ManOrderEmployeeExpensesView(MaintenanceOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ManOrderEmployeeExpensesView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ManOrderEmployeeExpensesView,MaintenanceOrderEntityView>( this,Screen.MaintenanceOrderEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ManOrderEmployeeExpensesView,MaintenanceOrderEntityView>( this,Screen.MaintenanceOrderEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ManOrderEmployeeExpensesView,MaintenanceOrderEntityView>( this,Screen.MaintenanceOrderEntityView);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<ManOrderEmployeeExpensesView>("3f5d6143-49e3-481f-83fa-5e1ee9ee817d","","",true, this);
 
            StartDate = RPSControlFactory.CreateRPSTextBox<ManOrderEmployeeExpensesView>("9332c1df-922f-4fec-aed9-ed22546279bb","","",true, this);
 
            EndDate = RPSControlFactory.CreateRPSTextBox<ManOrderEmployeeExpensesView>("512ade9b-4ec3-4274-be5f-0b7c6f9e4c11","","",true, this);
 
            Destination = RPSControlFactory.CreateRPSTextBox<ManOrderEmployeeExpensesView>("63598716-1d4e-4a83-9cb9-487bb4950b16","","",true, this);
 
            DietAmount = RPSControlFactory.CreateRPSFormattedTextBox<ManOrderEmployeeExpensesView>("16bd940a-0b73-4cac-abfe-903ae4ad110f","","",true, this);
 
            Kilometers = RPSControlFactory.CreateRPSFormattedTextBox<ManOrderEmployeeExpensesView>("f3ed657f-dfe5-49c5-b5ef-a4ab66ed6b85","","",true, this);
 
            KmAmount = RPSControlFactory.CreateRPSFormattedTextBox<ManOrderEmployeeExpensesView>("1f8182ca-87a5-4414-859d-2f7844d42d63","","",true, this);
 
            Tolls = RPSControlFactory.CreateRPSFormattedTextBox<ManOrderEmployeeExpensesView>("0099f57e-00fa-4a65-927b-b5fd7c03a3a3","","",true, this);
 
            Meals = RPSControlFactory.CreateRPSFormattedTextBox<ManOrderEmployeeExpensesView>("2e93082a-38ef-425d-bd6c-d83f929ab543","","",true, this);
 
            Transports = RPSControlFactory.CreateRPSFormattedTextBox<ManOrderEmployeeExpensesView>("64fe6faf-14fa-49be-b300-5e59320e2d98","","",true, this);
 
            Hotels = RPSControlFactory.CreateRPSFormattedTextBox<ManOrderEmployeeExpensesView>("b4073585-eeff-4151-898d-35e4dd72f5a9","","",true, this);
 
            BillableForSales = RPSControlFactory.CreateRPSCheckBox<ManOrderEmployeeExpensesView>("a4674297-50df-4b76-b962-5aafe2a4dad8","","",true, this);
 
            IsPosting = RPSControlFactory.CreateRPSCheckBox<ManOrderEmployeeExpensesView>("3343c7f4-71ed-463c-8344-90e46b4a53ef","","",true, this);
 
            UITotal = RPSControlFactory.CreateRPSFormattedTextBox<ManOrderEmployeeExpensesView>("9a620557-a6d2-452c-9a60-c36f5456e973","","",false, this);
 
            Comments = RPSControlFactory.CreateRPSTextBox<ManOrderEmployeeExpensesView>("36a0f045-3f3c-452a-9419-5463896a58e0","","",false, this);
 
            GeneralData = RPSControlFactory.CreateRPSSection<ManOrderEmployeeExpensesView>( "","ul li[rpsid='8893ed94-e4f7-4459-80bd-ea7473957f53']","",this);
 
            Comments1 = RPSControlFactory.CreateRPSSection<ManOrderEmployeeExpensesView>( "","ul li[rpsid='bf2df0c1-11eb-43e3-9a22-2a7a900e31da']","",this);
 

        }
        public IRPSButton<ManOrderEmployeeExpensesView> DeleteButton { get; set; } 
        public IRPSButton<ManOrderEmployeeExpensesView,MaintenanceOrderEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ManOrderEmployeeExpensesView,MaintenanceOrderEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ManOrderEmployeeExpensesView,MaintenanceOrderEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ManOrderEmployeeExpensesView> IDEmployee { get; set; } 
        public IRPSTextBox<ManOrderEmployeeExpensesView> StartDate { get; set; } 
        public IRPSTextBox<ManOrderEmployeeExpensesView> EndDate { get; set; } 
        public IRPSTextBox<ManOrderEmployeeExpensesView> Destination { get; set; } 
        public IRPSTextBox<ManOrderEmployeeExpensesView> DietAmount { get; set; } 
        public IRPSTextBox<ManOrderEmployeeExpensesView> Kilometers { get; set; } 
        public IRPSTextBox<ManOrderEmployeeExpensesView> KmAmount { get; set; } 
        public IRPSTextBox<ManOrderEmployeeExpensesView> Tolls { get; set; } 
        public IRPSTextBox<ManOrderEmployeeExpensesView> Meals { get; set; } 
        public IRPSTextBox<ManOrderEmployeeExpensesView> Transports { get; set; } 
        public IRPSTextBox<ManOrderEmployeeExpensesView> Hotels { get; set; } 
        public IRPSCheckbox<ManOrderEmployeeExpensesView> BillableForSales { get; set; } 
        public IRPSCheckbox<ManOrderEmployeeExpensesView> IsPosting { get; set; } 
        public IRPSTextBox<ManOrderEmployeeExpensesView> UITotal { get; set; } 
        public IRPSTextBox<ManOrderEmployeeExpensesView> Comments { get; set; } 
        public IRPSSection<ManOrderEmployeeExpensesView> GeneralData { get; set; } 
        public IRPSSection<ManOrderEmployeeExpensesView> Comments1 { get; set; } 
        public MaintenanceOrder Screen { get; set; }
        public ManOrderEmployeeExpensesView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenanceOrderExpensesView : View
    {
        public MaintenanceOrderExpensesView(MaintenanceOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceOrderExpensesView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceOrderExpensesView,MaintenanceOrderEntityView>( this,Screen.MaintenanceOrderEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceOrderExpensesView,MaintenanceOrderEntityView>( this,Screen.MaintenanceOrderEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MaintenanceOrderExpensesView,MaintenanceOrderEntityView>( this,Screen.MaintenanceOrderEntityView);
 
            Invoice = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderExpensesView>("0559a439-6b97-4714-9d30-5bf82f575637","","",true, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderExpensesView>("b70743d6-a1c8-4d1c-8b22-6f5a5c5fa5fc","","",true, this);
 
            Concept = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderExpensesView>("6bc908e8-cf52-4b59-8ed5-7430a61422e5","","",false, this);
 
            Cost = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceOrderExpensesView>("cf76f514-0d42-48ba-ad51-d4a073b5bd08","","",true, this);
 
            BillableForSales = RPSControlFactory.CreateRPSCheckBox<MaintenanceOrderExpensesView>("a4cdb4bd-2655-44c4-95c3-126a81d9bb60","","",true, this);
 
            IsPosting = RPSControlFactory.CreateRPSCheckBox<MaintenanceOrderExpensesView>("47c1a86e-3bb4-43a6-8f1e-224961dd301c","","",true, this);
 

        }
        public IRPSButton<MaintenanceOrderExpensesView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceOrderExpensesView,MaintenanceOrderEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceOrderExpensesView,MaintenanceOrderEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<MaintenanceOrderExpensesView,MaintenanceOrderEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<MaintenanceOrderExpensesView> Invoice { get; set; } 
        public IRPSTextBox<MaintenanceOrderExpensesView> Date { get; set; } 
        public IRPSTextBox<MaintenanceOrderExpensesView> Concept { get; set; } 
        public IRPSTextBox<MaintenanceOrderExpensesView> Cost { get; set; } 
        public IRPSCheckbox<MaintenanceOrderExpensesView> BillableForSales { get; set; } 
        public IRPSCheckbox<MaintenanceOrderExpensesView> IsPosting { get; set; } 
        public MaintenanceOrder Screen { get; set; }
        public MaintenanceOrderExpensesView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenanceOrderProcedureView : View
    {
        public MaintenanceOrderProcedureView(MaintenanceOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceOrderProcedureView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceOrderProcedureView,MaintenanceOrderEntityView>( this,Screen.MaintenanceOrderEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceOrderProcedureView,MaintenanceOrderEntityView>( this,Screen.MaintenanceOrderEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MaintenanceOrderProcedureView,MaintenanceOrderEntityView>( this,Screen.MaintenanceOrderEntityView);
 
            IDMaintenanceProcedure = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderProcedureView>("3ba17925-e229-41d6-8dd3-4d51e7be4a54","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderProcedureView>("fb4c8e9d-bfe0-4406-a0fd-8a783c51c03b","","",false, this);
 
            CollectionInit params_MaintenanceOrderProcTasks = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="529e1fee-cc4a-4dc6-a248-d6962d2a2a55",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceOrderProcTasks = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceOrderProcTasksCollectionEditor<MaintenanceOrderProcedureView,MaintenanceOrderProcTaskView>,MaintenanceOrderProcedureView,MaintenanceOrderProcTaskView>( params_MaintenanceOrderProcTasks,this,Screen.MaintenanceOrderProcTaskView);
 

        }
        public IRPSButton<MaintenanceOrderProcedureView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceOrderProcedureView,MaintenanceOrderEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceOrderProcedureView,MaintenanceOrderEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<MaintenanceOrderProcedureView,MaintenanceOrderEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<MaintenanceOrderProcedureView> IDMaintenanceProcedure { get; set; } 
        public IRPSTextBox<MaintenanceOrderProcedureView> Description { get; set; } 
        public MaintenanceOrderProcTasksCollectionEditor<MaintenanceOrderProcedureView,MaintenanceOrderProcTaskView> MaintenanceOrderProcTasks { get; set; } 
        public MaintenanceOrder Screen { get; set; }
        public MaintenanceOrderProcedureView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaintenanceOrderProcTasksCollectionEditor<MaintenanceOrderProcedureView,MaintenanceOrderProcTaskView>:RPSCollectionEditor<MaintenanceOrderProcedureView,MaintenanceOrderProcTaskView> where MaintenanceOrderProcedureView : class, IView where MaintenanceOrderProcTaskView : class, IView
    {
        public  MaintenanceOrderProcTasksGridView<MaintenanceOrderProcedureView,MaintenanceOrderProcTaskView> GridView {get;set;}
    }
    public partial class MaintenanceOrderProcTasksGridView <MaintenanceOrderProcedureView,MaintenanceOrderProcTaskView> :  RPSGridView<MaintenanceOrderProcedureView,MaintenanceOrderProcTaskView> where MaintenanceOrderProcedureView : class, IView where MaintenanceOrderProcTaskView : class, IView
    {
        public MaintenanceOrderProcTasksGridView(MaintenanceOrderProcedureView currentView,MaintenanceOrderProcTaskView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDMaintenanceProcTask = RPSControlFactory.CreateRPSGridComboBox<MaintenanceOrderProcedureView>("","#529e1fee-cc4a-4dc6-a248-d6962d2a2a55 .ag-row[role='row']@ROWINDEX [col-id='cIDMaintenanceProcTask']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderProcedureView>("","#529e1fee-cc4a-4dc6-a248-d6962d2a2a55 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Duration = RPSControlFactory.CreateRPSGridDurationTextBox<MaintenanceOrderProcedureView>("","#529e1fee-cc4a-4dc6-a248-d6962d2a2a55 .ag-row[role='row']@ROWINDEX [col-id='cDuration']","",false, this.CurrentView);
 
            TaskOption = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderProcedureView>("","#529e1fee-cc4a-4dc6-a248-d6962d2a2a55 .ag-row[role='row']@ROWINDEX [col-id='cTaskOption']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<MaintenanceOrderProcedureView> IDMaintenanceProcTask { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderProcedureView> Description { get; set; } 
        public IRPSGridDurationTextBox<MaintenanceOrderProcedureView> Duration { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderProcedureView> TaskOption { get; set; } 
                     
    }
 
    }
  
            
    public partial class MaintenanceOrderProcTaskView : View
    {
        public MaintenanceOrderProcTaskView(MaintenanceOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceOrderProcTaskView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceOrderProcTaskView,MaintenanceOrderProcedureView>( this,Screen.MaintenanceOrderProcedureView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceOrderProcTaskView,MaintenanceOrderProcedureView>( this,Screen.MaintenanceOrderProcedureView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MaintenanceOrderProcTaskView,MaintenanceOrderProcedureView>( this,Screen.MaintenanceOrderProcedureView);
 
            CodOrderProcTask = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderProcTaskView>("3d03d60b-9943-4c90-b70e-bd068ad49543","","",true, this);
 
            IDMaintenanceProcTask = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderProcTaskView>("45af4d19-37cd-4f98-9122-3a28062d5b42","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderProcTaskView>("bf4bd820-9a60-4692-b43c-71f9c7cbeefc","","",false, this);
 
            Duration = RPSControlFactory.CreateRPSDurationTextBox<MaintenanceOrderProcTaskView>("4d435695-64c0-4333-873e-a0c473ab585f","","",false, this);
 
            TaskOption = RPSControlFactory.CreateRPSEnumComboBox<MaintenanceOrderProcTaskView>("c7daacca-923e-4f65-ae04-8746338566bf","","",false, this);
 

        }
        public IRPSButton<MaintenanceOrderProcTaskView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceOrderProcTaskView,MaintenanceOrderProcedureView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceOrderProcTaskView,MaintenanceOrderProcedureView> BackButton { get; set; } 
        public IRPSAcceptButton<MaintenanceOrderProcTaskView,MaintenanceOrderProcedureView> AcceptButton { get; set; } 
        public IRPSTextBox<MaintenanceOrderProcTaskView> CodOrderProcTask { get; set; } 
        public IRPSComboBox<MaintenanceOrderProcTaskView> IDMaintenanceProcTask { get; set; } 
        public IRPSTextBox<MaintenanceOrderProcTaskView> Description { get; set; } 
        public IRPSDurationTextBox<MaintenanceOrderProcTaskView> Duration { get; set; } 
        public IRPSComboBox<MaintenanceOrderProcTaskView> TaskOption { get; set; } 
        public MaintenanceOrder Screen { get; set; }
        public MaintenanceOrderProcTaskView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenanceOrderAssociateWarningView : View
    {
        public MaintenanceOrderAssociateWarningView(MaintenanceOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceOrderAssociateWarningView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceOrderAssociateWarningView,MaintenanceOrderEntityView>( this,Screen.MaintenanceOrderEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceOrderAssociateWarningView,MaintenanceOrderEntityView>( this,Screen.MaintenanceOrderEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MaintenanceOrderAssociateWarningView,MaintenanceOrderEntityView>( this,Screen.MaintenanceOrderEntityView);
 
            IDAssociateWarning = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderAssociateWarningView>("7ebf0986-47b1-4340-a0a6-bc916c02d6cc","","",true, this);
 
            UIDescription = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderAssociateWarningView>("1b68eca2-d937-4275-9a77-df9ce8ce9f61","","",false, this);
 
            UIEntryDate = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderAssociateWarningView>("5b5ac2e1-b125-49df-b12c-cf166743a4b8","","",false, this);
 
            UIClosingDate = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderAssociateWarningView>("9ae1149e-49fe-4410-b8e1-2a2e0fd2665d","","",false, this);
 
            UIMaintenanceWarningType = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderAssociateWarningView>("00182450-79e9-4b55-ac79-0c988229cee1","","",false, this);
 
            UIMaintenanceWarningStatus = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderAssociateWarningView>("306f47ff-a9e5-42aa-a299-5a729dfd1554","","",false, this);
 
            UIMaintenanceWarningPriority = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderAssociateWarningView>("76ba07a4-363c-466e-b365-b3115fb17a19","","",false, this);
 
            UIMaintenanceWarningSeverity = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderAssociateWarningView>("83d522cc-05e5-4f5d-8d6a-f63d28da15f7","","",false, this);
 

        }
        public IRPSButton<MaintenanceOrderAssociateWarningView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceOrderAssociateWarningView,MaintenanceOrderEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceOrderAssociateWarningView,MaintenanceOrderEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<MaintenanceOrderAssociateWarningView,MaintenanceOrderEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<MaintenanceOrderAssociateWarningView> IDAssociateWarning { get; set; } 
        public IRPSTextBox<MaintenanceOrderAssociateWarningView> UIDescription { get; set; } 
        public IRPSTextBox<MaintenanceOrderAssociateWarningView> UIEntryDate { get; set; } 
        public IRPSTextBox<MaintenanceOrderAssociateWarningView> UIClosingDate { get; set; } 
        public IRPSComboBox<MaintenanceOrderAssociateWarningView> UIMaintenanceWarningType { get; set; } 
        public IRPSComboBox<MaintenanceOrderAssociateWarningView> UIMaintenanceWarningStatus { get; set; } 
        public IRPSComboBox<MaintenanceOrderAssociateWarningView> UIMaintenanceWarningPriority { get; set; } 
        public IRPSComboBox<MaintenanceOrderAssociateWarningView> UIMaintenanceWarningSeverity { get; set; } 
        public MaintenanceOrder Screen { get; set; }
        public MaintenanceOrderAssociateWarningView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenanceOrderRelationView : View
    {
        public MaintenanceOrderRelationView(MaintenanceOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceOrderRelationView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceOrderRelationView,MaintenanceOrderEntityView>( this,Screen.MaintenanceOrderEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceOrderRelationView,MaintenanceOrderEntityView>( this,Screen.MaintenanceOrderEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MaintenanceOrderRelationView,MaintenanceOrderEntityView>( this,Screen.MaintenanceOrderEntityView);
 
            IDMaintenanceOrderPredecessor = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderRelationView>("25339ff1-262e-4f8f-a3fa-764059ab96fb","","",true, this);
 
            RelationType = RPSControlFactory.CreateRPSEnumComboBox<MaintenanceOrderRelationView>("6b363ec1-0ceb-49f0-9c26-261ef480d64b","","",false, this);
 
            TimeLag = RPSControlFactory.CreateRPSDurationTextBox<MaintenanceOrderRelationView>("2fccb44b-9299-4751-941f-aa62fa88cb11","","",true, this);
 
            Linked = RPSControlFactory.CreateRPSCheckBox<MaintenanceOrderRelationView>("1c901d74-639b-4fa7-8698-edb61d0bc5ab","","",true, this);
 
            CalendarType = RPSControlFactory.CreateRPSEnumComboBox<MaintenanceOrderRelationView>("2510b6f5-1d20-4665-a4b6-1de09f309848","","",true, this);
 

        }
        public IRPSButton<MaintenanceOrderRelationView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceOrderRelationView,MaintenanceOrderEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceOrderRelationView,MaintenanceOrderEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<MaintenanceOrderRelationView,MaintenanceOrderEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<MaintenanceOrderRelationView> IDMaintenanceOrderPredecessor { get; set; } 
        public IRPSComboBox<MaintenanceOrderRelationView> RelationType { get; set; } 
        public IRPSDurationTextBox<MaintenanceOrderRelationView> TimeLag { get; set; } 
        public IRPSCheckbox<MaintenanceOrderRelationView> Linked { get; set; } 
        public IRPSComboBox<MaintenanceOrderRelationView> CalendarType { get; set; } 
        public MaintenanceOrder Screen { get; set; }
        public MaintenanceOrderRelationView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ManOrderDimensionView : View
    {
        public ManOrderDimensionView(MaintenanceOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ManOrderDimensionView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ManOrderDimensionView,MaintenanceOrderEntityView>( this,Screen.MaintenanceOrderEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ManOrderDimensionView,MaintenanceOrderEntityView>( this,Screen.MaintenanceOrderEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ManOrderDimensionView,MaintenanceOrderEntityView>( this,Screen.MaintenanceOrderEntityView);
 
            IDDimension = RPSControlFactory.CreateRPSComboBox<ManOrderDimensionView>("adcf29be-c105-40fe-b7e5-5cfdaf44f13c","","",true, this);
 
            IDDimValue = RPSControlFactory.CreateRPSComboBox<ManOrderDimensionView>("19786644-bbec-4c39-b8c2-b3bae0e2c47c","","",false, this);
 
            Percentage = RPSControlFactory.CreateRPSFormattedTextBox<ManOrderDimensionView>("fe72279f-0284-479b-bf48-f5b7bc5002d1","","",true, this);
 

        }
        public IRPSButton<ManOrderDimensionView> DeleteButton { get; set; } 
        public IRPSButton<ManOrderDimensionView,MaintenanceOrderEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ManOrderDimensionView,MaintenanceOrderEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ManOrderDimensionView,MaintenanceOrderEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ManOrderDimensionView> IDDimension { get; set; } 
        public IRPSComboBox<ManOrderDimensionView> IDDimValue { get; set; } 
        public IRPSTextBox<ManOrderDimensionView> Percentage { get; set; } 
        public MaintenanceOrder Screen { get; set; }
        public ManOrderDimensionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenanceOrderPredictiveView : View
    {
        public MaintenanceOrderPredictiveView(MaintenanceOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceOrderPredictiveView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceOrderPredictiveView,MaintenanceOrderEntityView>( this,Screen.MaintenanceOrderEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceOrderPredictiveView,MaintenanceOrderEntityView>( this,Screen.MaintenanceOrderEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MaintenanceOrderPredictiveView,MaintenanceOrderEntityView>( this,Screen.MaintenanceOrderEntityView);
 
            ControlFeatureCode = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderPredictiveView>("754c51e3-35cc-43db-a77b-05f51bd9d5bb","","",true, this);
 
            ControlFeatureDesc = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderPredictiveView>("02d8d370-b820-4b36-8ad8-5808287b4ba1","","",false, this);
 
            ControlType = RPSControlFactory.CreateRPSEnumComboBox<MaintenanceOrderPredictiveView>("ece24297-ebb3-4f07-970d-b58dccf67502","","",true, this);
 
            MinimumValue = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceOrderPredictiveView>("f11d3daf-b81f-4803-aadd-c047b1d613a3","","",true, this);
 
            MaximumValue = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceOrderPredictiveView>("51a7b53c-4f68-4309-80cb-56155c8f799c","","",true, this);
 
            Accuracy = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderPredictiveView>("89023ece-330b-4a9a-b5e9-e99845d2c395","","",false, this);
 
            Precision = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderPredictiveView>("19e512d1-9dc7-490d-ae8d-54ad91cd2f8d","","",false, this);
 
            IDControlMethod = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderPredictiveView>("9d8338d7-d7aa-4483-8dc5-51f2726018dd","","",false, this);
 
            IDTestMethod = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderPredictiveView>("8c9625ee-4c71-4f01-850d-8cb266383715","","",false, this);
 
            CollectionInit params_MaintenanceOrderPredictiveSamples = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f644ea43-f9ff-47ef-a407-b74f3498709c",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceOrderPredictiveSamples = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceOrderPredictiveSamplesCollectionEditor<MaintenanceOrderPredictiveView,MaintenanceOrderPredictiveSampleView>,MaintenanceOrderPredictiveView,MaintenanceOrderPredictiveSampleView>( params_MaintenanceOrderPredictiveSamples,this,Screen.MaintenanceOrderPredictiveSampleView);
 

        }
        public IRPSButton<MaintenanceOrderPredictiveView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceOrderPredictiveView,MaintenanceOrderEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceOrderPredictiveView,MaintenanceOrderEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<MaintenanceOrderPredictiveView,MaintenanceOrderEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<MaintenanceOrderPredictiveView> ControlFeatureCode { get; set; } 
        public IRPSTextBox<MaintenanceOrderPredictiveView> ControlFeatureDesc { get; set; } 
        public IRPSComboBox<MaintenanceOrderPredictiveView> ControlType { get; set; } 
        public IRPSTextBox<MaintenanceOrderPredictiveView> MinimumValue { get; set; } 
        public IRPSTextBox<MaintenanceOrderPredictiveView> MaximumValue { get; set; } 
        public IRPSTextBox<MaintenanceOrderPredictiveView> Accuracy { get; set; } 
        public IRPSTextBox<MaintenanceOrderPredictiveView> Precision { get; set; } 
        public IRPSComboBox<MaintenanceOrderPredictiveView> IDControlMethod { get; set; } 
        public IRPSComboBox<MaintenanceOrderPredictiveView> IDTestMethod { get; set; } 
        public MaintenanceOrderPredictiveSamplesCollectionEditor<MaintenanceOrderPredictiveView,MaintenanceOrderPredictiveSampleView> MaintenanceOrderPredictiveSamples { get; set; } 
        public MaintenanceOrder Screen { get; set; }
        public MaintenanceOrderPredictiveView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaintenanceOrderPredictiveSamplesCollectionEditor<MaintenanceOrderPredictiveView,MaintenanceOrderPredictiveSampleView>:RPSCollectionEditor<MaintenanceOrderPredictiveView,MaintenanceOrderPredictiveSampleView> where MaintenanceOrderPredictiveView : class, IView where MaintenanceOrderPredictiveSampleView : class, IView
    {
        public  MaintenanceOrderPredictiveSamplesGridView<MaintenanceOrderPredictiveView,MaintenanceOrderPredictiveSampleView> GridView {get;set;}
    }
    public partial class MaintenanceOrderPredictiveSamplesGridView <MaintenanceOrderPredictiveView,MaintenanceOrderPredictiveSampleView> :  RPSGridView<MaintenanceOrderPredictiveView,MaintenanceOrderPredictiveSampleView> where MaintenanceOrderPredictiveView : class, IView where MaintenanceOrderPredictiveSampleView : class, IView
    {
        public MaintenanceOrderPredictiveSamplesGridView(MaintenanceOrderPredictiveView currentView,MaintenanceOrderPredictiveSampleView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CaptureSequence = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenanceOrderPredictiveView>("","#f644ea43-f9ff-47ef-a407-b74f3498709c .ag-row[role='row']@ROWINDEX [col-id='cCaptureSequence']","",true, this.CurrentView);
 
            CaptureDate = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderPredictiveView>("","#f644ea43-f9ff-47ef-a407-b74f3498709c .ag-row[role='row']@ROWINDEX [col-id='cCaptureDate']","",false, this.CurrentView);
 
            CaptureTime = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderPredictiveView>("","#f644ea43-f9ff-47ef-a407-b74f3498709c .ag-row[role='row']@ROWINDEX [col-id='cCaptureTime']","",false, this.CurrentView);
 
            IDEmployee = RPSControlFactory.CreateRPSGridComboBox<MaintenanceOrderPredictiveView>("","#f644ea43-f9ff-47ef-a407-b74f3498709c .ag-row[role='row']@ROWINDEX [col-id='cIDEmployee']","",false, this.CurrentView);
 
            Value = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenanceOrderPredictiveView>("","#f644ea43-f9ff-47ef-a407-b74f3498709c .ag-row[role='row']@ROWINDEX [col-id='cValue']","",true, this.CurrentView);
 
            OKorNOK = RPSControlFactory.CreateRPSGridEnumComboBox<MaintenanceOrderPredictiveView>("","#f644ea43-f9ff-47ef-a407-b74f3498709c .ag-row[role='row']@ROWINDEX [col-id='cOKorNOK']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<MaintenanceOrderPredictiveView> CaptureSequence { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderPredictiveView> CaptureDate { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderPredictiveView> CaptureTime { get; set; } 
        public IRPSGridComboBox<MaintenanceOrderPredictiveView> IDEmployee { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderPredictiveView> Value { get; set; } 
        public IRPSGridComboBox<MaintenanceOrderPredictiveView> OKorNOK { get; set; } 
                     
    }
 
    }
  
            
    public partial class MaintenanceOrderPredictiveSampleView : View
    {
        public MaintenanceOrderPredictiveSampleView(MaintenanceOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceOrderPredictiveSampleView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceOrderPredictiveSampleView,MaintenanceOrderPredictiveView>( this,Screen.MaintenanceOrderPredictiveView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceOrderPredictiveSampleView,MaintenanceOrderPredictiveView>( this,Screen.MaintenanceOrderPredictiveView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MaintenanceOrderPredictiveSampleView,MaintenanceOrderPredictiveView>( this,Screen.MaintenanceOrderPredictiveView);
 
            CaptureSequence = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceOrderPredictiveSampleView>("b199c058-01c0-432e-bcae-56a43068251f","","",true, this);
 
            CaptureDate = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderPredictiveSampleView>("87defbff-2633-4bd8-b042-677e4b7d9a4e","","",false, this);
 
            CaptureTime = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderPredictiveSampleView>("a82c5fe5-3716-4007-8096-a6dbe910844a","","",false, this);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderPredictiveSampleView>("38d038e3-b491-4a97-b1b9-61c3282ea7bc","","",false, this);
 
            Value = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceOrderPredictiveSampleView>("8f709cb3-7735-4bf1-a0f5-e49b2ec15383","","",true, this);
 
            OKorNOK = RPSControlFactory.CreateRPSEnumComboBox<MaintenanceOrderPredictiveSampleView>("f2227cb4-b4bc-43d7-b79d-ae99980aa458","","",true, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderPredictiveSampleView>("3768dd36-dbf1-4e13-9c96-cd091ea673c0","","",false, this);
 
            GeneralData = RPSControlFactory.CreateRPSSection<MaintenanceOrderPredictiveSampleView>( "","ul li[rpsid='78fb0a75-d0f4-46d7-864f-0552ce796fdb']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<MaintenanceOrderPredictiveSampleView>( "","ul li[rpsid='392c7c8c-6f74-410b-8ef0-1572f2be94d3']","",this);
 

        }
        public IRPSButton<MaintenanceOrderPredictiveSampleView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceOrderPredictiveSampleView,MaintenanceOrderPredictiveView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceOrderPredictiveSampleView,MaintenanceOrderPredictiveView> BackButton { get; set; } 
        public IRPSAcceptButton<MaintenanceOrderPredictiveSampleView,MaintenanceOrderPredictiveView> AcceptButton { get; set; } 
        public IRPSTextBox<MaintenanceOrderPredictiveSampleView> CaptureSequence { get; set; } 
        public IRPSTextBox<MaintenanceOrderPredictiveSampleView> CaptureDate { get; set; } 
        public IRPSTextBox<MaintenanceOrderPredictiveSampleView> CaptureTime { get; set; } 
        public IRPSComboBox<MaintenanceOrderPredictiveSampleView> IDEmployee { get; set; } 
        public IRPSTextBox<MaintenanceOrderPredictiveSampleView> Value { get; set; } 
        public IRPSComboBox<MaintenanceOrderPredictiveSampleView> OKorNOK { get; set; } 
        public IRPSTextBox<MaintenanceOrderPredictiveSampleView> Comment { get; set; } 
        public IRPSSection<MaintenanceOrderPredictiveSampleView> GeneralData { get; set; } 
        public IRPSSection<MaintenanceOrderPredictiveSampleView> Comments { get; set; } 
        public MaintenanceOrder Screen { get; set; }
        public MaintenanceOrderPredictiveSampleView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenanceOrderResourcePrevisionDialogView : View
    {
        public MaintenanceOrderResourcePrevisionDialogView(MaintenanceOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_MaintenancePlanResourcesPrevision = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c187b250-b4d6-46b5-bafd-c5b635798da6",CSSSelectorGrid="",XPathGrid=""};
            MaintenancePlanResourcesPrevision = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenancePlanResourcesPrevisionCollectionEditor<MaintenanceOrderResourcePrevisionDialogView>,MaintenanceOrderResourcePrevisionDialogView>( params_MaintenancePlanResourcesPrevision,this);
 

        }
        public MaintenancePlanResourcesPrevisionCollectionEditor<MaintenanceOrderResourcePrevisionDialogView> MaintenancePlanResourcesPrevision { get; set; } 
        public MaintenanceOrder Screen { get; set; }
        public MaintenanceOrderResourcePrevisionDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaintenancePlanResourcesPrevisionCollectionEditor<MaintenanceOrderResourcePrevisionDialogView>:RPSCollectionEditor<MaintenanceOrderResourcePrevisionDialogView> where MaintenanceOrderResourcePrevisionDialogView : class, IView
    {
        public  MaintenancePlanResourcesPrevisionGridView<MaintenanceOrderResourcePrevisionDialogView> GridView {get;set;}
    }
    public partial class MaintenancePlanResourcesPrevisionGridView <MaintenanceOrderResourcePrevisionDialogView> :  RPSGridView<MaintenanceOrderResourcePrevisionDialogView> where MaintenanceOrderResourcePrevisionDialogView : class, IView
    {
        public MaintenancePlanResourcesPrevisionGridView(MaintenanceOrderResourcePrevisionDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MaintenancePlanResource_Comments = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderResourcePrevisionDialogView>("","#c187b250-b4d6-46b5-bafd-c5b635798da6 .ag-row[role='row']@ROWINDEX [col-id='cMaintenancePlanResource_Comments']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MaintenanceOrderResourcePrevisionDialogView> MaintenancePlanResource_Comments { get; set; } 
                     
    }
 
    }
  
            
    public partial class MaintenanceOrderSubcontractPrevisionDialogView : View
    {
        public MaintenanceOrderSubcontractPrevisionDialogView(MaintenanceOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_MaintenancePlanSubcontractsPrevision = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="65436be1-b851-4ad9-9aa5-0f84d74dd26a",CSSSelectorGrid="",XPathGrid=""};
            MaintenancePlanSubcontractsPrevision = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenancePlanSubcontractsPrevisionCollectionEditor<MaintenanceOrderSubcontractPrevisionDialogView>,MaintenanceOrderSubcontractPrevisionDialogView>( params_MaintenancePlanSubcontractsPrevision,this);
 

        }
        public MaintenancePlanSubcontractsPrevisionCollectionEditor<MaintenanceOrderSubcontractPrevisionDialogView> MaintenancePlanSubcontractsPrevision { get; set; } 
        public MaintenanceOrder Screen { get; set; }
        public MaintenanceOrderSubcontractPrevisionDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaintenancePlanSubcontractsPrevisionCollectionEditor<MaintenanceOrderSubcontractPrevisionDialogView>:RPSCollectionEditor<MaintenanceOrderSubcontractPrevisionDialogView> where MaintenanceOrderSubcontractPrevisionDialogView : class, IView
    {
        public  MaintenancePlanSubcontractsPrevisionGridView<MaintenanceOrderSubcontractPrevisionDialogView> GridView {get;set;}
    }
    public partial class MaintenancePlanSubcontractsPrevisionGridView <MaintenanceOrderSubcontractPrevisionDialogView> :  RPSGridView<MaintenanceOrderSubcontractPrevisionDialogView> where MaintenanceOrderSubcontractPrevisionDialogView : class, IView
    {
        public MaintenancePlanSubcontractsPrevisionGridView(MaintenanceOrderSubcontractPrevisionDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MaintenancePlanSubcontract_Comments = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderSubcontractPrevisionDialogView>("","#65436be1-b851-4ad9-9aa5-0f84d74dd26a .ag-row[role='row']@ROWINDEX [col-id='cMaintenancePlanSubcontract_Comments']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MaintenanceOrderSubcontractPrevisionDialogView> MaintenancePlanSubcontract_Comments { get; set; } 
                     
    }
 
    }
  
            
    public partial class MaintenanceOrderStaffPrevisionDialogView : View
    {
        public MaintenanceOrderStaffPrevisionDialogView(MaintenanceOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_MaintenancePlanStaffsPrevision = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="05311a41-21b6-4810-b458-38283b1c050e",CSSSelectorGrid="",XPathGrid=""};
            MaintenancePlanStaffsPrevision = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenancePlanStaffsPrevisionCollectionEditor<MaintenanceOrderStaffPrevisionDialogView>,MaintenanceOrderStaffPrevisionDialogView>( params_MaintenancePlanStaffsPrevision,this);
 

        }
        public MaintenancePlanStaffsPrevisionCollectionEditor<MaintenanceOrderStaffPrevisionDialogView> MaintenancePlanStaffsPrevision { get; set; } 
        public MaintenanceOrder Screen { get; set; }
        public MaintenanceOrderStaffPrevisionDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaintenancePlanStaffsPrevisionCollectionEditor<MaintenanceOrderStaffPrevisionDialogView>:RPSCollectionEditor<MaintenanceOrderStaffPrevisionDialogView> where MaintenanceOrderStaffPrevisionDialogView : class, IView
    {
        public  MaintenancePlanStaffsPrevisionGridView<MaintenanceOrderStaffPrevisionDialogView> GridView {get;set;}
    }
    public partial class MaintenancePlanStaffsPrevisionGridView <MaintenanceOrderStaffPrevisionDialogView> :  RPSGridView<MaintenanceOrderStaffPrevisionDialogView> where MaintenanceOrderStaffPrevisionDialogView : class, IView
    {
        public MaintenancePlanStaffsPrevisionGridView(MaintenanceOrderStaffPrevisionDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MaintenancePlanStaff_PeopleNumber = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenanceOrderStaffPrevisionDialogView>("","#05311a41-21b6-4810-b458-38283b1c050e .ag-row[role='row']@ROWINDEX [col-id='cMaintenancePlanStaff_PeopleNumber']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MaintenanceOrderStaffPrevisionDialogView> MaintenancePlanStaff_PeopleNumber { get; set; } 
                     
    }
 
    }
  
            
    public partial class MaintenaceOrderChangeStatusDialogView : View
    {
        public MaintenaceOrderChangeStatusDialogView(MaintenanceOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDMaintenanceOrderStatus = RPSControlFactory.CreateRPSComboBox<MaintenaceOrderChangeStatusDialogView>("03c9f6a5-5b28-41d3-a48c-7072ac46465e","","",true, this);
 
            IDMaintenanceOrderStatusDestination = RPSControlFactory.CreateRPSComboBox<MaintenaceOrderChangeStatusDialogView>("bb72c604-8248-46e1-80a2-fa1452d5331f","","",false, this);
 
            ClosingDate = RPSControlFactory.CreateRPSTextBox<MaintenaceOrderChangeStatusDialogView>("e00f518e-03e1-462c-b98e-502ac222aa6f","","",false, this);
 
            ClosingTime = RPSControlFactory.CreateRPSTextBox<MaintenaceOrderChangeStatusDialogView>("f443fa88-fd09-471e-9a74-d0ca72e1bf71","","",false, this);
 

        }
        public IRPSComboBox<MaintenaceOrderChangeStatusDialogView> IDMaintenanceOrderStatus { get; set; } 
        public IRPSComboBox<MaintenaceOrderChangeStatusDialogView> IDMaintenanceOrderStatusDestination { get; set; } 
        public IRPSTextBox<MaintenaceOrderChangeStatusDialogView> ClosingDate { get; set; } 
        public IRPSTextBox<MaintenaceOrderChangeStatusDialogView> ClosingTime { get; set; } 
        public MaintenanceOrder Screen { get; set; }
        public MaintenaceOrderChangeStatusDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenanceOrderPrintOptionsDialogView : View
    {
        public MaintenanceOrderPrintOptionsDialogView(MaintenanceOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CustomerLanguage = RPSControlFactory.CreateRPSOption<MaintenanceOrderPrintOptionsDialogView>( "fea345cb-e244-4c9e-891f-80e3cba4e38f","","",this);
 
            Language = RPSControlFactory.CreateRPSOption<MaintenanceOrderPrintOptionsDialogView>( "175d0ee8-df10-434a-b5fd-d77d7b1bd38d","","",this);
 
            Language1 = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderPrintOptionsDialogView>("e4383b9e-db34-458e-80da-944cfd0cc466","","",false, this);
 
            SpecificList = RPSControlFactory.CreateRPSCheckBox<MaintenanceOrderPrintOptionsDialogView>("8ab5a155-147c-4a2c-8865-9d765f1b69e6","","",false, this);
 
            CustomReport = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderPrintOptionsDialogView>("9abd2b4c-6d92-4397-8b33-b5b46652e552","","",false, this);
 

        }
        public IRPSOption<MaintenanceOrderPrintOptionsDialogView> CustomerLanguage { get; set; } 
        public IRPSOption<MaintenanceOrderPrintOptionsDialogView> Language { get; set; } 
        public IRPSComboBox<MaintenanceOrderPrintOptionsDialogView> Language1 { get; set; } 
        public IRPSCheckbox<MaintenanceOrderPrintOptionsDialogView> SpecificList { get; set; } 
        public IRPSComboBox<MaintenanceOrderPrintOptionsDialogView> CustomReport { get; set; } 
        public MaintenanceOrder Screen { get; set; }
        public MaintenanceOrderPrintOptionsDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OrderMaterialPrevisionView : View
    {
        public OrderMaterialPrevisionView(MaintenanceOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<OrderMaterialPrevisionView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<OrderMaterialPrevisionView,MaintenanceOrderEntityView>( this,Screen.MaintenanceOrderEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<OrderMaterialPrevisionView,MaintenanceOrderEntityView>( this,Screen.MaintenanceOrderEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<OrderMaterialPrevisionView,MaintenanceOrderEntityView>( this,Screen.MaintenanceOrderEntityView);
 
            PurchaseProposal = RPSControlFactory.CreateRPSOption<OrderMaterialPrevisionView>( "c499b483-6a7b-440e-a8b4-45887972886f","","",this);
 
            ManufacturingOrder = RPSControlFactory.CreateRPSOption<OrderMaterialPrevisionView>( "31230084-729d-47df-b175-3b2d8eff85f3","","",this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<OrderMaterialPrevisionView>("5607f536-fc02-4453-97a9-2ec3d569f620","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<OrderMaterialPrevisionView>("e8688b19-0845-4cdb-a13d-b2bf94e3cb88","","",false, this);
 
            PriceCost = RPSControlFactory.CreateRPSFormattedTextBox<OrderMaterialPrevisionView>("de98977d-c714-4141-8cf7-5a344df565ab","","",true, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<OrderMaterialPrevisionView>("90b31b86-c03d-48e4-8f7d-6f7efc4bbba6","","",false, this);
 
            IDWareHouse = RPSControlFactory.CreateRPSComboBox<OrderMaterialPrevisionView>("d4bfcc3f-31a3-46ea-b603-c12d6aa41b41","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<OrderMaterialPrevisionView>("0a6bb7d7-a044-414a-a8ec-432ab118608c","","",true, this);
 
            QuantityImputed = RPSControlFactory.CreateRPSFormattedTextBox<OrderMaterialPrevisionView>("0f13d3d2-dfd4-4311-a001-37a9aaf8d100","","",true, this);
 
            MakeMovement = RPSControlFactory.CreateRPSCheckBox<OrderMaterialPrevisionView>("e57cb5df-4f31-4738-9dd4-bf8434fdc850","","",true, this);
 
            MakeAutomaticOutput = RPSControlFactory.CreateRPSCheckBox<OrderMaterialPrevisionView>("a78592eb-a1c0-4ef1-a5a0-62bb3e679ca7","","",true, this);
 
            ImputationCostUpdated = RPSControlFactory.CreateRPSCheckBox<OrderMaterialPrevisionView>("21892ae4-7f22-408e-bfc6-5249d4316086","","",true, this);
 
            ImputationTotalQuantity = RPSControlFactory.CreateRPSCheckBox<OrderMaterialPrevisionView>("25b3b95d-8ea1-4a3d-b78b-38e8e2110af7","","",true, this);
 
            Completed = RPSControlFactory.CreateRPSCheckBox<OrderMaterialPrevisionView>("1fffb696-eeba-4e17-918c-936f391683f7","","",true, this);
 
            Comments = RPSControlFactory.CreateRPSTextBox<OrderMaterialPrevisionView>("d61fd478-fa15-411c-93df-85131c078556","","",false, this);
 
            ExecuteAddMaintenanceOrderMaterialPrevisionButton = RPSControlFactory.CreateRPSButton<OrderMaterialPrevisionView>( "890151ac-b0a7-4ebf-8341-dbb1534ef222","","",this);
 
            ExecuteMaintenanceProvisioningButton = RPSControlFactory.CreateRPSButton<OrderMaterialPrevisionView>( "6022dced-a6f2-43e4-8474-72e56ddac8de","","",this);
 

        }
        public IRPSButton<OrderMaterialPrevisionView> DeleteButton { get; set; } 
        public IRPSButton<OrderMaterialPrevisionView,MaintenanceOrderEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<OrderMaterialPrevisionView,MaintenanceOrderEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<OrderMaterialPrevisionView,MaintenanceOrderEntityView> AcceptButton { get; set; } 
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
        public IRPSButton<OrderMaterialPrevisionView> ExecuteMaintenanceProvisioningButton { get; set; } 
        public MaintenanceOrder Screen { get; set; }
        public OrderMaterialPrevisionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ManOrderEmployeeExpensesPrevisionDialogView : View
    {
        public ManOrderEmployeeExpensesPrevisionDialogView(MaintenanceOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_MaintenancePlanExpensesPrevision = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="90f64325-1418-4eac-b109-377967bcd451",CSSSelectorGrid="",XPathGrid=""};
            MaintenancePlanExpensesPrevision = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenancePlanExpensesPrevisionCollectionEditor<ManOrderEmployeeExpensesPrevisionDialogView>,ManOrderEmployeeExpensesPrevisionDialogView>( params_MaintenancePlanExpensesPrevision,this);
 

        }
        public MaintenancePlanExpensesPrevisionCollectionEditor<ManOrderEmployeeExpensesPrevisionDialogView> MaintenancePlanExpensesPrevision { get; set; } 
        public MaintenanceOrder Screen { get; set; }
        public ManOrderEmployeeExpensesPrevisionDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaintenancePlanExpensesPrevisionCollectionEditor<ManOrderEmployeeExpensesPrevisionDialogView>:RPSCollectionEditor<ManOrderEmployeeExpensesPrevisionDialogView> where ManOrderEmployeeExpensesPrevisionDialogView : class, IView
    {
        public  MaintenancePlanExpensesPrevisionGridView<ManOrderEmployeeExpensesPrevisionDialogView> GridView {get;set;}
    }
    public partial class MaintenancePlanExpensesPrevisionGridView <ManOrderEmployeeExpensesPrevisionDialogView> :  RPSGridView<ManOrderEmployeeExpensesPrevisionDialogView> where ManOrderEmployeeExpensesPrevisionDialogView : class, IView
    {
        public MaintenancePlanExpensesPrevisionGridView(ManOrderEmployeeExpensesPrevisionDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MaintenancePlanExpenses_Type = RPSControlFactory.CreateRPSGridTextBox<ManOrderEmployeeExpensesPrevisionDialogView>("","#90f64325-1418-4eac-b109-377967bcd451 .ag-row[role='row']@ROWINDEX [col-id='cMaintenancePlanExpenses_Type']","",false, this.CurrentView);
 
            MaintenancePlanExpenses_Description = RPSControlFactory.CreateRPSGridTextBox<ManOrderEmployeeExpensesPrevisionDialogView>("","#90f64325-1418-4eac-b109-377967bcd451 .ag-row[role='row']@ROWINDEX [col-id='cMaintenancePlanExpenses_Description']","",false, this.CurrentView);
 
            MaintenancePlanExpenses_Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<ManOrderEmployeeExpensesPrevisionDialogView>("","#90f64325-1418-4eac-b109-377967bcd451 .ag-row[role='row']@ROWINDEX [col-id='cMaintenancePlanExpenses_Quantity']","",false, this.CurrentView);
 
            Price = RPSControlFactory.CreateRPSGridFormattedTextBox<ManOrderEmployeeExpensesPrevisionDialogView>("","#90f64325-1418-4eac-b109-377967bcd451 .ag-row[role='row']@ROWINDEX [col-id='cPrice']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ManOrderEmployeeExpensesPrevisionDialogView> MaintenancePlanExpenses_Type { get; set; } 
        public IRPSGridTextBox<ManOrderEmployeeExpensesPrevisionDialogView> MaintenancePlanExpenses_Description { get; set; } 
        public IRPSGridTextBox<ManOrderEmployeeExpensesPrevisionDialogView> MaintenancePlanExpenses_Quantity { get; set; } 
        public IRPSGridTextBox<ManOrderEmployeeExpensesPrevisionDialogView> Price { get; set; } 
                     
    }
 
    }
  
            
    public partial class CuDistChangeCustomerDialogView : View
    {
        public CuDistChangeCustomerDialogView(MaintenanceOrder screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDCustomer = RPSControlFactory.CreateRPSComboBox<CuDistChangeCustomerDialogView>("fc4881e1-1fa5-4d31-8061-44894da07dea","","",false, this);
 

        }
        public IRPSComboBox<CuDistChangeCustomerDialogView> IDCustomer { get; set; } 
        public MaintenanceOrder Screen { get; set; }
        public CuDistChangeCustomerDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}