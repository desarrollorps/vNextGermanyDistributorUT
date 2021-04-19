    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.PurchaseOrderTracking
{
    //RPS VERSION 1.0.0.0
    public partial class PurchaseOrderTracking:Screen
    {
        public PurchaseOrderTracking():base()
        {
            this.URL = "purchase.purchaseordertracking";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            PurchaseOrderTrackingQueryView  = new PurchaseOrderTrackingQueryView(this); 
            PurchaseOrderTrackingConsultationResultByEmailDialogView  = new PurchaseOrderTrackingConsultationResultByEmailDialogView(this); 
            PurchaseOrderTrackingConsultationResultByReportDialogView  = new PurchaseOrderTrackingConsultationResultByReportDialogView(this); 
            PurchaseOrderTrackingMaterialDeliveriesView  = new PurchaseOrderTrackingMaterialDeliveriesView(this); 
            PurchaseOrderTrackingMaterialDeliveriesGenerateTransferDNoteParametersDialogView  = new PurchaseOrderTrackingMaterialDeliveriesGenerateTransferDNoteParametersDialogView(this); 
            PurchaseOrderTrackingMaterialDeliveriesGenerateTransferMovementsParametersDialogView  = new PurchaseOrderTrackingMaterialDeliveriesGenerateTransferMovementsParametersDialogView(this); 
            TransferMovementsForExternalTaskDialogView  = new TransferMovementsForExternalTaskDialogView(this); 
            PurchaseOrderTrackingMaterialDeliveriesGenerateTransferPurchaseDNoteParametersDialogView  = new PurchaseOrderTrackingMaterialDeliveriesGenerateTransferPurchaseDNoteParametersDialogView(this); 
            PurchaseOrderTrackingQueryView.InitializeControls(); 
            PurchaseOrderTrackingConsultationResultByEmailDialogView.InitializeControls(); 
            PurchaseOrderTrackingConsultationResultByReportDialogView.InitializeControls(); 
            PurchaseOrderTrackingMaterialDeliveriesView.InitializeControls(); 
            PurchaseOrderTrackingMaterialDeliveriesGenerateTransferDNoteParametersDialogView.InitializeControls(); 
            PurchaseOrderTrackingMaterialDeliveriesGenerateTransferMovementsParametersDialogView.InitializeControls(); 
            TransferMovementsForExternalTaskDialogView.InitializeControls(); 
            PurchaseOrderTrackingMaterialDeliveriesGenerateTransferPurchaseDNoteParametersDialogView.InitializeControls(); 
           
        }
      
            public PurchaseOrderTrackingQueryView PurchaseOrderTrackingQueryView {get; set; } 
            public PurchaseOrderTrackingConsultationResultByEmailDialogView PurchaseOrderTrackingConsultationResultByEmailDialogView {get; set; } 
            public PurchaseOrderTrackingConsultationResultByReportDialogView PurchaseOrderTrackingConsultationResultByReportDialogView {get; set; } 
            public PurchaseOrderTrackingMaterialDeliveriesView PurchaseOrderTrackingMaterialDeliveriesView {get; set; } 
            public PurchaseOrderTrackingMaterialDeliveriesGenerateTransferDNoteParametersDialogView PurchaseOrderTrackingMaterialDeliveriesGenerateTransferDNoteParametersDialogView {get; set; } 
            public PurchaseOrderTrackingMaterialDeliveriesGenerateTransferMovementsParametersDialogView PurchaseOrderTrackingMaterialDeliveriesGenerateTransferMovementsParametersDialogView {get; set; } 
            public TransferMovementsForExternalTaskDialogView TransferMovementsForExternalTaskDialogView {get; set; } 
            public PurchaseOrderTrackingMaterialDeliveriesGenerateTransferPurchaseDNoteParametersDialogView PurchaseOrderTrackingMaterialDeliveriesGenerateTransferPurchaseDNoteParametersDialogView {get; set; } 
    }
            
    public partial class PurchaseOrderTrackingQueryView : View
    {
        public PurchaseOrderTrackingQueryView(PurchaseOrderTracking screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SelectedPurchaseOrders = RPSControlFactory.CreateRPSCollectionComboBox<PurchaseOrderTrackingQueryView>("514ecb49-6be0-433a-974a-3d6222604394","","",false, this);
 
            PurchaseOrderDateFrom = RPSControlFactory.CreateRPSTextBox<PurchaseOrderTrackingQueryView>("25eee31f-86c0-49ae-b4a5-6d435f4b8301","","",false, this);
 
            PurchaseOrderDateTo = RPSControlFactory.CreateRPSTextBox<PurchaseOrderTrackingQueryView>("7470dfa7-c69a-4850-a3f3-e4f28270e090","","",false, this);
 
            PurchaseOrderReceptionDateFrom = RPSControlFactory.CreateRPSTextBox<PurchaseOrderTrackingQueryView>("df2261a9-99d5-4132-90fd-a8d68e4d3448","","",false, this);
 
            PurchaseOrderReceptionDateTo = RPSControlFactory.CreateRPSTextBox<PurchaseOrderTrackingQueryView>("ea51d27b-93e7-4b30-b8b8-a4e5f941e686","","",false, this);
 
            SelectedSuppliers = RPSControlFactory.CreateRPSCollectionComboBox<PurchaseOrderTrackingQueryView>("8b6d0000-21cc-441d-abd1-afa5097687e4","","",false, this);
 
            SelectedSuppliersGroups = RPSControlFactory.CreateRPSCollectionComboBox<PurchaseOrderTrackingQueryView>("623ec550-f2b4-4ea1-a63f-34b5bacd940a","","",false, this);
 
            SelectedSupplierOrder = RPSControlFactory.CreateRPSTextBox<PurchaseOrderTrackingQueryView>("b2b0c83f-7687-4727-9bcf-b329ed355335","","",false, this);
 
            OnlyExternalTasks = RPSControlFactory.CreateRPSCheckBox<PurchaseOrderTrackingQueryView>("8a2dbe05-734f-4709-9a98-0d6f4acfa7c3","","",false, this);
 
            All = RPSControlFactory.CreateRPSOption<PurchaseOrderTrackingQueryView>( "9097d4c1-7700-4846-9963-a124577b688f","","",this);
 
            PendingSupplierMaterialDelivery = RPSControlFactory.CreateRPSOption<PurchaseOrderTrackingQueryView>( "89d62ed1-806b-4d3c-91be-579637874a70","","",this);
 
            FinalizedSupplierMaterialDelivery = RPSControlFactory.CreateRPSOption<PurchaseOrderTrackingQueryView>( "84d0f948-c43a-4e18-8da1-ac3319f4321e","","",this);
 
            UIOnlyCritical = RPSControlFactory.CreateRPSCheckBox<PurchaseOrderTrackingQueryView>("e897b9c5-9c07-4257-9437-faca4ef5b65f","","",false, this);
 
            UIDelayReceptionGreaterThan = RPSControlFactory.CreateRPSCheckBox<PurchaseOrderTrackingQueryView>("a2f37945-aca2-4a11-9130-b22f7a584e3e","","",false, this);
 
            UIDelayReception = RPSControlFactory.CreateRPSFormattedTextBox<PurchaseOrderTrackingQueryView>("3090d728-a9e5-4ad6-b8ab-403744b37639","","",false, this);
 
            UIDelayOriginGreaterThan = RPSControlFactory.CreateRPSCheckBox<PurchaseOrderTrackingQueryView>("a04ae3db-ea2d-4f34-af2f-b3bed9453825","","",false, this);
 
            UIDelayOrigin = RPSControlFactory.CreateRPSFormattedTextBox<PurchaseOrderTrackingQueryView>("11055458-d904-45a9-84e0-d7dad94c38a9","","",false, this);
 
            UIDelayReceptionOriginGreterthan = RPSControlFactory.CreateRPSCheckBox<PurchaseOrderTrackingQueryView>("cdd47814-1258-454b-aad6-c45af370d8e9","","",false, this);
 
            UIDelayReeptionOrigin = RPSControlFactory.CreateRPSFormattedTextBox<PurchaseOrderTrackingQueryView>("9c037ac0-1e6f-44d0-b386-00870dd576d6","","",false, this);
 
            SelectedProductLines = RPSControlFactory.CreateRPSCollectionComboBox<PurchaseOrderTrackingQueryView>("976b0b5d-35a6-46c0-9135-fcdf8649addb","","",false, this);
 
            SelectedProductFamilies = RPSControlFactory.CreateRPSCollectionComboBox<PurchaseOrderTrackingQueryView>("f64a5674-fb17-4550-8cbf-7e0f9e914a33","","",false, this);
 
            SelectedProductSubFamilies = RPSControlFactory.CreateRPSCollectionComboBox<PurchaseOrderTrackingQueryView>("1e89c08c-790f-4316-83ab-ba5aa86bbdc5","","",false, this);
 
            SelectedArticles = RPSControlFactory.CreateRPSCollectionComboBox<PurchaseOrderTrackingQueryView>("0075fa5f-25a2-463a-9b32-4eb2ed3882c0","","",false, this);
 
            IDSupplierReference = RPSControlFactory.CreateRPSEnumComboBox<PurchaseOrderTrackingQueryView>("5e3d9340-0636-4268-81d1-665e37247461","","",false, this);
 
            MOsSelected = RPSControlFactory.CreateRPSCollectionComboBox<PurchaseOrderTrackingQueryView>("ad5f7033-37f2-4d61-9544-a4cfa24fa8fc","","",false, this);
 
            ProjectsSelected = RPSControlFactory.CreateRPSCollectionComboBox<PurchaseOrderTrackingQueryView>("68020825-dc0f-40ba-ab45-a6ce28ee5c1a","","",false, this);
 
            SalesOrdersSelected = RPSControlFactory.CreateRPSCollectionComboBox<PurchaseOrderTrackingQueryView>("f98de1c1-d601-4ea9-8a92-8c48ea92e71b","","",false, this);
 
            InternalCodeSelected = RPSControlFactory.CreateRPSTextBox<PurchaseOrderTrackingQueryView>("bcc20d92-5c3f-420c-b764-deb96b159280","","",false, this);
 
            ArticleStructuresSelected = RPSControlFactory.CreateRPSCollectionComboBox<PurchaseOrderTrackingQueryView>("5523ccfd-09e9-4729-ba60-faabf72d055a","","",false, this);
 
            MaintenanceOrdersSelected = RPSControlFactory.CreateRPSCollectionComboBox<PurchaseOrderTrackingQueryView>("633d1384-67a6-4ec7-abc2-da7cb5741540","","",false, this);
 
            Order_OrderNumberSupplier = RPSControlFactory.CreateRPSTextBox<PurchaseOrderTrackingQueryView>("876d2600-e992-4067-bfc5-f5493c23df92","","",false, this);
 
            Order_OrderDate = RPSControlFactory.CreateRPSTextBox<PurchaseOrderTrackingQueryView>("cb0b6172-66ca-42a3-87f4-44132bbcc219","","",false, this);
 
            OrderLine_ReceptionDate = RPSControlFactory.CreateRPSTextBox<PurchaseOrderTrackingQueryView>("de8b23bd-a45a-4650-9f9e-2d1ad101acf1","","",false, this);
 
            OrderLine_ReceptionDemandDate = RPSControlFactory.CreateRPSTextBox<PurchaseOrderTrackingQueryView>("f435b491-8281-48be-9555-a70505466b12","","",false, this);
 
            SupplierDetail_Blocked = RPSControlFactory.CreateRPSCheckBox<PurchaseOrderTrackingQueryView>("4714c52e-1567-43cf-b9a4-9c0822fbd02d","","",false, this);
 
            DaysForReception = RPSControlFactory.CreateRPSFormattedTextBox<PurchaseOrderTrackingQueryView>("9de46a12-420f-45e8-8708-bd16ee1c34b0","","",false, this);
 
            DaysForOrigin = RPSControlFactory.CreateRPSFormattedTextBox<PurchaseOrderTrackingQueryView>("18cc68b7-b7c7-43f0-9657-478808adf7f3","","",false, this);
 
            Delay = RPSControlFactory.CreateRPSFormattedTextBox<PurchaseOrderTrackingQueryView>("1017f86e-e19f-44fa-9c54-947a19d7b0cc","","",false, this);
 
            Order_Status = RPSControlFactory.CreateRPSFormattedTextBox<PurchaseOrderTrackingQueryView>("95191bcf-aef0-48e4-a12b-5450238ba18d","","",false, this);
 
            Order_LastPrintDate = RPSControlFactory.CreateRPSTextBox<PurchaseOrderTrackingQueryView>("31c2ef05-b980-4b8c-bdd7-108322052c77","","",false, this);
 
            OrderLine_ExternalMaterialsDelivered = RPSControlFactory.CreateRPSCheckBox<PurchaseOrderTrackingQueryView>("0d6caf2f-c6d4-4492-85b7-833d1fe56c56","","",false, this);
 
            OrderLine_Description = RPSControlFactory.CreateRPSTextBox<PurchaseOrderTrackingQueryView>("cfd24278-5843-4a6e-8cad-0fdc09f72015","","",false, this);
 
            OrderLine_InternalCode = RPSControlFactory.CreateRPSTextBox<PurchaseOrderTrackingQueryView>("56ef79ef-b5e8-45cb-8aeb-6d83a49611d7","","",false, this);
 
            OrderLine_ReferenceSupplier = RPSControlFactory.CreateRPSTextBox<PurchaseOrderTrackingQueryView>("1bef8a58-1c0f-4da8-853e-52f350bcc09d","","",false, this);
 
            MOTask_PlannedStartDate = RPSControlFactory.CreateRPSTextBox<PurchaseOrderTrackingQueryView>("73432f01-f56f-4419-8319-cad98cc2a6e6","","",false, this);
 
            MOTask_PlannedEndDate = RPSControlFactory.CreateRPSTextBox<PurchaseOrderTrackingQueryView>("7e59e1d6-d828-4c5f-9372-1472bd5bae0f","","",false, this);
 
            MOTask_Group = RPSControlFactory.CreateRPSTextBox<PurchaseOrderTrackingQueryView>("78c34488-87f8-4b80-8465-588b5d2617c5","","",false, this);
 
            MOTask_OptimizationFeature = RPSControlFactory.CreateRPSTextBox<PurchaseOrderTrackingQueryView>("8c47ca47-fcac-4379-a2ad-07f18a387b36","","",false, this);
 
            ProjectTask_PlannedStartDate = RPSControlFactory.CreateRPSTextBox<PurchaseOrderTrackingQueryView>("7c516a8e-d10c-4a50-923d-5ec8b5567146","","",false, this);
 
            ProjectTask_PlannedEndDate = RPSControlFactory.CreateRPSTextBox<PurchaseOrderTrackingQueryView>("528353d8-8781-48c7-bd6c-fb423c34ec3d","","",false, this);
 
            ProjectTask_Group = RPSControlFactory.CreateRPSTextBox<PurchaseOrderTrackingQueryView>("58b0f65b-cdf9-49c3-84ff-eedb3cc68e96","","",false, this);
 
            ProjectTask_OptimizationFeature = RPSControlFactory.CreateRPSTextBox<PurchaseOrderTrackingQueryView>("fa5e0e71-8477-45b5-aa1f-356762bd883a","","",false, this);
 
            OrderLineSL_ReceptionDate = RPSControlFactory.CreateRPSTextBox<PurchaseOrderTrackingQueryView>("c38dd67a-e3ea-4f67-aedc-8ae554be59e5","","",false, this);
 
            MaintenanceOrder_ExecutionDate = RPSControlFactory.CreateRPSTextBox<PurchaseOrderTrackingQueryView>("45177bb1-b8c2-440f-b090-c1489bad5d6b","","",false, this);
 
            MatchCode = RPSControlFactory.CreateRPSTextBox<PurchaseOrderTrackingQueryView>("880530ba-1dd9-4dd6-a137-75675bd6211d","","",false, this);
 
            PurchaseOrderTrackingConsultationResultByEmailNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<PurchaseOrderTrackingQueryView,PurchaseOrderTrackingConsultationResultByEmailDialogView>("bbf91f50-3a0b-4477-9105-d74595ca0165","","", this,Screen.PurchaseOrderTrackingConsultationResultByEmailDialogView);
 
            PurchaseOrderTrackingConsultationResultByReportNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<PurchaseOrderTrackingQueryView,PurchaseOrderTrackingConsultationResultByReportDialogView>("55c302dd-db93-40b9-9cc8-f0ae7cf02a72","","", this,Screen.PurchaseOrderTrackingConsultationResultByReportDialogView);
 
            PurchaseOrderTrackingMaterialDeliveriesNavigationCommandButton = RPSControlFactory.CreateRPSButton<PurchaseOrderTrackingQueryView>( "7a952628-8d96-4fa0-a8f2-06cf5c42a575","","",this);
 
            PurchaseOrderTrackingFinalizeExternalMaterialDeliveryCommandButton = RPSControlFactory.CreateRPSButton<PurchaseOrderTrackingQueryView>( "aa434a55-3a0f-4a7b-b1f5-266a296a5e35","","",this);
 
            CollectionInit params_PurchaseOrderTrackingConsultation = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="bc35d09e-037d-4665-94f1-dba1b3da7ce2",CSSSelectorGrid="",XPathGrid=""};
            PurchaseOrderTrackingConsultation = RPSControlFactory.RPSCreateCollectionWithGrid<PurchaseOrderTrackingConsultationCollectionEditor<PurchaseOrderTrackingQueryView,PurchaseOrderTrackingConsultationResultByEmailDialogView>,PurchaseOrderTrackingQueryView,PurchaseOrderTrackingConsultationResultByEmailDialogView>( params_PurchaseOrderTrackingConsultation,this,Screen.PurchaseOrderTrackingConsultationResultByEmailDialogView);
 

        }
        public IRPSCollectionComboBox<PurchaseOrderTrackingQueryView> SelectedPurchaseOrders { get; set; } 
        public IRPSTextBox<PurchaseOrderTrackingQueryView> PurchaseOrderDateFrom { get; set; } 
        public IRPSTextBox<PurchaseOrderTrackingQueryView> PurchaseOrderDateTo { get; set; } 
        public IRPSTextBox<PurchaseOrderTrackingQueryView> PurchaseOrderReceptionDateFrom { get; set; } 
        public IRPSTextBox<PurchaseOrderTrackingQueryView> PurchaseOrderReceptionDateTo { get; set; } 
        public IRPSCollectionComboBox<PurchaseOrderTrackingQueryView> SelectedSuppliers { get; set; } 
        public IRPSCollectionComboBox<PurchaseOrderTrackingQueryView> SelectedSuppliersGroups { get; set; } 
        public IRPSTextBox<PurchaseOrderTrackingQueryView> SelectedSupplierOrder { get; set; } 
        public IRPSCheckbox<PurchaseOrderTrackingQueryView> OnlyExternalTasks { get; set; } 
        public IRPSOption<PurchaseOrderTrackingQueryView> All { get; set; } 
        public IRPSOption<PurchaseOrderTrackingQueryView> PendingSupplierMaterialDelivery { get; set; } 
        public IRPSOption<PurchaseOrderTrackingQueryView> FinalizedSupplierMaterialDelivery { get; set; } 
        public IRPSCheckbox<PurchaseOrderTrackingQueryView> UIOnlyCritical { get; set; } 
        public IRPSCheckbox<PurchaseOrderTrackingQueryView> UIDelayReceptionGreaterThan { get; set; } 
        public IRPSTextBox<PurchaseOrderTrackingQueryView> UIDelayReception { get; set; } 
        public IRPSCheckbox<PurchaseOrderTrackingQueryView> UIDelayOriginGreaterThan { get; set; } 
        public IRPSTextBox<PurchaseOrderTrackingQueryView> UIDelayOrigin { get; set; } 
        public IRPSCheckbox<PurchaseOrderTrackingQueryView> UIDelayReceptionOriginGreterthan { get; set; } 
        public IRPSTextBox<PurchaseOrderTrackingQueryView> UIDelayReeptionOrigin { get; set; } 
        public IRPSCollectionComboBox<PurchaseOrderTrackingQueryView> SelectedProductLines { get; set; } 
        public IRPSCollectionComboBox<PurchaseOrderTrackingQueryView> SelectedProductFamilies { get; set; } 
        public IRPSCollectionComboBox<PurchaseOrderTrackingQueryView> SelectedProductSubFamilies { get; set; } 
        public IRPSCollectionComboBox<PurchaseOrderTrackingQueryView> SelectedArticles { get; set; } 
        public IRPSComboBox<PurchaseOrderTrackingQueryView> IDSupplierReference { get; set; } 
        public IRPSCollectionComboBox<PurchaseOrderTrackingQueryView> MOsSelected { get; set; } 
        public IRPSCollectionComboBox<PurchaseOrderTrackingQueryView> ProjectsSelected { get; set; } 
        public IRPSCollectionComboBox<PurchaseOrderTrackingQueryView> SalesOrdersSelected { get; set; } 
        public IRPSTextBox<PurchaseOrderTrackingQueryView> InternalCodeSelected { get; set; } 
        public IRPSCollectionComboBox<PurchaseOrderTrackingQueryView> ArticleStructuresSelected { get; set; } 
        public IRPSCollectionComboBox<PurchaseOrderTrackingQueryView> MaintenanceOrdersSelected { get; set; } 
        public IRPSTextBox<PurchaseOrderTrackingQueryView> Order_OrderNumberSupplier { get; set; } 
        public IRPSTextBox<PurchaseOrderTrackingQueryView> Order_OrderDate { get; set; } 
        public IRPSTextBox<PurchaseOrderTrackingQueryView> OrderLine_ReceptionDate { get; set; } 
        public IRPSTextBox<PurchaseOrderTrackingQueryView> OrderLine_ReceptionDemandDate { get; set; } 
        public IRPSCheckbox<PurchaseOrderTrackingQueryView> SupplierDetail_Blocked { get; set; } 
        public IRPSTextBox<PurchaseOrderTrackingQueryView> DaysForReception { get; set; } 
        public IRPSTextBox<PurchaseOrderTrackingQueryView> DaysForOrigin { get; set; } 
        public IRPSTextBox<PurchaseOrderTrackingQueryView> Delay { get; set; } 
        public IRPSTextBox<PurchaseOrderTrackingQueryView> Order_Status { get; set; } 
        public IRPSTextBox<PurchaseOrderTrackingQueryView> Order_LastPrintDate { get; set; } 
        public IRPSCheckbox<PurchaseOrderTrackingQueryView> OrderLine_ExternalMaterialsDelivered { get; set; } 
        public IRPSTextBox<PurchaseOrderTrackingQueryView> OrderLine_Description { get; set; } 
        public IRPSTextBox<PurchaseOrderTrackingQueryView> OrderLine_InternalCode { get; set; } 
        public IRPSTextBox<PurchaseOrderTrackingQueryView> OrderLine_ReferenceSupplier { get; set; } 
        public IRPSTextBox<PurchaseOrderTrackingQueryView> MOTask_PlannedStartDate { get; set; } 
        public IRPSTextBox<PurchaseOrderTrackingQueryView> MOTask_PlannedEndDate { get; set; } 
        public IRPSTextBox<PurchaseOrderTrackingQueryView> MOTask_Group { get; set; } 
        public IRPSTextBox<PurchaseOrderTrackingQueryView> MOTask_OptimizationFeature { get; set; } 
        public IRPSTextBox<PurchaseOrderTrackingQueryView> ProjectTask_PlannedStartDate { get; set; } 
        public IRPSTextBox<PurchaseOrderTrackingQueryView> ProjectTask_PlannedEndDate { get; set; } 
        public IRPSTextBox<PurchaseOrderTrackingQueryView> ProjectTask_Group { get; set; } 
        public IRPSTextBox<PurchaseOrderTrackingQueryView> ProjectTask_OptimizationFeature { get; set; } 
        public IRPSTextBox<PurchaseOrderTrackingQueryView> OrderLineSL_ReceptionDate { get; set; } 
        public IRPSTextBox<PurchaseOrderTrackingQueryView> MaintenanceOrder_ExecutionDate { get; set; } 
        public IRPSTextBox<PurchaseOrderTrackingQueryView> MatchCode { get; set; } 
        public IRPSButton<PurchaseOrderTrackingQueryView,PurchaseOrderTrackingConsultationResultByEmailDialogView> PurchaseOrderTrackingConsultationResultByEmailNavigationCommandButton { get; set; } 
        public IRPSButton<PurchaseOrderTrackingQueryView,PurchaseOrderTrackingConsultationResultByReportDialogView> PurchaseOrderTrackingConsultationResultByReportNavigationCommandButton { get; set; } 
        public IRPSButton<PurchaseOrderTrackingQueryView> PurchaseOrderTrackingMaterialDeliveriesNavigationCommandButton { get; set; } 
        public IRPSButton<PurchaseOrderTrackingQueryView> PurchaseOrderTrackingFinalizeExternalMaterialDeliveryCommandButton { get; set; } 
        public PurchaseOrderTrackingConsultationCollectionEditor<PurchaseOrderTrackingQueryView,PurchaseOrderTrackingConsultationResultByEmailDialogView> PurchaseOrderTrackingConsultation { get; set; } 
        public PurchaseOrderTracking Screen { get; set; }
        public PurchaseOrderTrackingQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class PurchaseOrderTrackingConsultationCollectionEditor<PurchaseOrderTrackingQueryView,PurchaseOrderTrackingConsultationResultByEmailDialogView>:RPSCollectionEditor<PurchaseOrderTrackingQueryView,PurchaseOrderTrackingConsultationResultByEmailDialogView> where PurchaseOrderTrackingQueryView : class, IView where PurchaseOrderTrackingConsultationResultByEmailDialogView : class, IView
    {
        public  PurchaseOrderTrackingConsultationGridView<PurchaseOrderTrackingQueryView,PurchaseOrderTrackingConsultationResultByEmailDialogView> GridView {get;set;}
    }
    public partial class PurchaseOrderTrackingConsultationGridView <PurchaseOrderTrackingQueryView,PurchaseOrderTrackingConsultationResultByEmailDialogView> :  RPSGridView<PurchaseOrderTrackingQueryView,PurchaseOrderTrackingConsultationResultByEmailDialogView> where PurchaseOrderTrackingQueryView : class, IView where PurchaseOrderTrackingConsultationResultByEmailDialogView : class, IView
    {
        public PurchaseOrderTrackingConsultationGridView(PurchaseOrderTrackingQueryView currentView,PurchaseOrderTrackingConsultationResultByEmailDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            OrderLine_ReceptionDateForResultGrid = RPSControlFactory.CreateRPSGridTextBox<PurchaseOrderTrackingQueryView>("","#bc35d09e-037d-4665-94f1-dba1b3da7ce2 .ag-row[role='row']@ROWINDEX [col-id='cOrderLine_ReceptionDateForResultGrid']","",false, this.CurrentView);
 
            DaysForReceptionForResultGrid = RPSControlFactory.CreateRPSGridFormattedTextBox<PurchaseOrderTrackingQueryView>("","#bc35d09e-037d-4665-94f1-dba1b3da7ce2 .ag-row[role='row']@ROWINDEX [col-id='cDaysForReceptionForResultGrid']","",false, this.CurrentView);
 
            DaysForOriginForResultGrid = RPSControlFactory.CreateRPSGridFormattedTextBox<PurchaseOrderTrackingQueryView>("","#bc35d09e-037d-4665-94f1-dba1b3da7ce2 .ag-row[role='row']@ROWINDEX [col-id='cDaysForOriginForResultGrid']","",false, this.CurrentView);
 
            MatchCode = RPSControlFactory.CreateRPSGridTextBox<PurchaseOrderTrackingQueryView>("","#bc35d09e-037d-4665-94f1-dba1b3da7ce2 .ag-row[role='row']@ROWINDEX [col-id='cMatchCode']","",false, this.CurrentView);
 
            OrderLine_DeliveryDate = RPSControlFactory.CreateRPSGridTextBox<PurchaseOrderTrackingQueryView>("","#bc35d09e-037d-4665-94f1-dba1b3da7ce2 .ag-row[role='row']@ROWINDEX [col-id='cOrderLine_DeliveryDate']","",false, this.CurrentView);
 
            OrderLine_IsDelivered = RPSControlFactory.CreateRPSGridCheckBox<PurchaseOrderTrackingQueryView>("","#bc35d09e-037d-4665-94f1-dba1b3da7ce2 .ag-row[role='row']@ROWINDEX [col-id='cOrderLine_IsDelivered']","",false, this.CurrentView);
 
            DelayForResultGrid = RPSControlFactory.CreateRPSGridFormattedTextBox<PurchaseOrderTrackingQueryView>("","#bc35d09e-037d-4665-94f1-dba1b3da7ce2 .ag-row[role='row']@ROWINDEX [col-id='cDelayForResultGrid']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<PurchaseOrderTrackingQueryView> OrderLine_ReceptionDateForResultGrid { get; set; } 
        public IRPSGridTextBox<PurchaseOrderTrackingQueryView> DaysForReceptionForResultGrid { get; set; } 
        public IRPSGridTextBox<PurchaseOrderTrackingQueryView> DaysForOriginForResultGrid { get; set; } 
        public IRPSGridTextBox<PurchaseOrderTrackingQueryView> MatchCode { get; set; } 
        public IRPSGridTextBox<PurchaseOrderTrackingQueryView> OrderLine_DeliveryDate { get; set; } 
        public IRPSGridCheckbox<PurchaseOrderTrackingQueryView> OrderLine_IsDelivered { get; set; } 
        public IRPSGridTextBox<PurchaseOrderTrackingQueryView> DelayForResultGrid { get; set; } 
                     
    }
 
    }
  
            
    public partial class PurchaseOrderTrackingConsultationResultByEmailDialogView : View
    {
        public PurchaseOrderTrackingConsultationResultByEmailDialogView(PurchaseOrderTracking screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            OpPendingLines = RPSControlFactory.CreateRPSOption<PurchaseOrderTrackingConsultationResultByEmailDialogView>( "7ff891c2-22c1-4e96-b865-3a73643c132f","","",this);
 
            OpPendingDelayedLines = RPSControlFactory.CreateRPSOption<PurchaseOrderTrackingConsultationResultByEmailDialogView>( "69755f0e-72c8-4c00-989c-ab503d3d7a84","","",this);
 
            UICustomReportOrder = RPSControlFactory.CreateRPSComboBox<PurchaseOrderTrackingConsultationResultByEmailDialogView>("2b1827da-d4c2-400b-a341-a7da25b654df","","",false, this);
 
            bClaim = RPSControlFactory.CreateRPSCheckBox<PurchaseOrderTrackingConsultationResultByEmailDialogView>("651ec9b4-8912-45b6-a0f2-2de47d996a30","","",false, this);
 
            ArticleDocuments = RPSControlFactory.CreateRPSCheckBox<PurchaseOrderTrackingConsultationResultByEmailDialogView>("802a3b0e-375b-4f35-8a4d-af570cf71ca0","","",false, this);
 
            OrderDocuments = RPSControlFactory.CreateRPSCheckBox<PurchaseOrderTrackingConsultationResultByEmailDialogView>("fcae34c9-50cf-4eb6-8615-c911ad57faa7","","",false, this);
 
            All = RPSControlFactory.CreateRPSOption<PurchaseOrderTrackingConsultationResultByEmailDialogView>( "8ef77009-7607-48bd-817d-009b0acf3f74","","",this);
 
            ByDocType = RPSControlFactory.CreateRPSOption<PurchaseOrderTrackingConsultationResultByEmailDialogView>( "0be12a23-262e-4f45-ac61-441fbc8a8278","","",this);
 
            All1 = RPSControlFactory.CreateRPSOption<PurchaseOrderTrackingConsultationResultByEmailDialogView>( "b81d8572-c59e-42aa-a8da-ad9ef32da2b1","","",this);
 
            ByDocType1 = RPSControlFactory.CreateRPSOption<PurchaseOrderTrackingConsultationResultByEmailDialogView>( "87a4450c-8259-4540-8ff0-d52be82f98ae","","",this);
 

        }
        public IRPSOption<PurchaseOrderTrackingConsultationResultByEmailDialogView> OpPendingLines { get; set; } 
        public IRPSOption<PurchaseOrderTrackingConsultationResultByEmailDialogView> OpPendingDelayedLines { get; set; } 
        public IRPSComboBox<PurchaseOrderTrackingConsultationResultByEmailDialogView> UICustomReportOrder { get; set; } 
        public IRPSCheckbox<PurchaseOrderTrackingConsultationResultByEmailDialogView> bClaim { get; set; } 
        public IRPSCheckbox<PurchaseOrderTrackingConsultationResultByEmailDialogView> ArticleDocuments { get; set; } 
        public IRPSCheckbox<PurchaseOrderTrackingConsultationResultByEmailDialogView> OrderDocuments { get; set; } 
        public IRPSOption<PurchaseOrderTrackingConsultationResultByEmailDialogView> All { get; set; } 
        public IRPSOption<PurchaseOrderTrackingConsultationResultByEmailDialogView> ByDocType { get; set; } 
        public IRPSOption<PurchaseOrderTrackingConsultationResultByEmailDialogView> All1 { get; set; } 
        public IRPSOption<PurchaseOrderTrackingConsultationResultByEmailDialogView> ByDocType1 { get; set; } 
        public PurchaseOrderTracking Screen { get; set; }
        public PurchaseOrderTrackingConsultationResultByEmailDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PurchaseOrderTrackingConsultationResultByReportDialogView : View
    {
        public PurchaseOrderTrackingConsultationResultByReportDialogView(PurchaseOrderTracking screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            OpPendingLines = RPSControlFactory.CreateRPSOption<PurchaseOrderTrackingConsultationResultByReportDialogView>( "f3a2569d-1402-4813-a0be-ee356e652f88","","",this);
 
            OpPendingDelayedLines = RPSControlFactory.CreateRPSOption<PurchaseOrderTrackingConsultationResultByReportDialogView>( "1c2b80fb-1849-40dc-8629-b76c0a7ce17b","","",this);
 
            UICustomReportOrder = RPSControlFactory.CreateRPSComboBox<PurchaseOrderTrackingConsultationResultByReportDialogView>("b7d6cec6-0209-4c57-bac0-0d724c78cd49","","",false, this);
 
            bClaim = RPSControlFactory.CreateRPSCheckBox<PurchaseOrderTrackingConsultationResultByReportDialogView>("90d34ca6-5cf3-442c-bf17-3b0ed1b7c6cd","","",false, this);
 

        }
        public IRPSOption<PurchaseOrderTrackingConsultationResultByReportDialogView> OpPendingLines { get; set; } 
        public IRPSOption<PurchaseOrderTrackingConsultationResultByReportDialogView> OpPendingDelayedLines { get; set; } 
        public IRPSComboBox<PurchaseOrderTrackingConsultationResultByReportDialogView> UICustomReportOrder { get; set; } 
        public IRPSCheckbox<PurchaseOrderTrackingConsultationResultByReportDialogView> bClaim { get; set; } 
        public PurchaseOrderTracking Screen { get; set; }
        public PurchaseOrderTrackingConsultationResultByReportDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PurchaseOrderTrackingMaterialDeliveriesView : View
    {
        public PurchaseOrderTrackingMaterialDeliveriesView(PurchaseOrderTracking screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SupplierSelectedForMaterialDeliveries = RPSControlFactory.CreateRPSComboBox<PurchaseOrderTrackingMaterialDeliveriesView>("bdefacbf-eb7b-40f9-82f1-92a5ca0f9eda","","",false, this);
 
            PurchaseOrderTrackingMaterialDeliveriesGenerateTransferDNoteParametersNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<PurchaseOrderTrackingMaterialDeliveriesView,PurchaseOrderTrackingMaterialDeliveriesGenerateTransferDNoteParametersDialogView>("aa586528-8338-49da-a591-8a9634b56202","","", this,Screen.PurchaseOrderTrackingMaterialDeliveriesGenerateTransferDNoteParametersDialogView);
 
            PurchaseOrderTrackingMaterialDeliveriesGenerateTransferMovementsParametersNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<PurchaseOrderTrackingMaterialDeliveriesView,PurchaseOrderTrackingMaterialDeliveriesGenerateTransferMovementsParametersDialogView>("096ac6e5-6aad-47ca-a1ba-b7cb63ad80b0","","", this,Screen.PurchaseOrderTrackingMaterialDeliveriesGenerateTransferMovementsParametersDialogView);
 
            PurchaseOrderTrackingMaterialDeliveriesGenerateTransferPurchaseDNoteParametersNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<PurchaseOrderTrackingMaterialDeliveriesView,PurchaseOrderTrackingMaterialDeliveriesGenerateTransferPurchaseDNoteParametersDialogView>("c506a5e7-e537-4619-8df6-7280af3e3bfb","","", this,Screen.PurchaseOrderTrackingMaterialDeliveriesGenerateTransferPurchaseDNoteParametersDialogView);
 
            SupplierSelectedForMaterialDeliveries1 = RPSControlFactory.CreateRPSComboBox<PurchaseOrderTrackingMaterialDeliveriesView>("b0ce8690-9c26-4186-9a28-b43b64277be9","","",false, this);
 
            CollectionInit params_PurchaseOrderTrackingMaterialDeliveries = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="97f58a61-f37e-4bd0-a212-95b04158746b",CSSSelectorGrid="",XPathGrid=""};
            PurchaseOrderTrackingMaterialDeliveries = RPSControlFactory.RPSCreateCollectionWithGrid<PurchaseOrderTrackingMaterialDeliveriesCollectionEditor<PurchaseOrderTrackingMaterialDeliveriesView,PurchaseOrderTrackingMaterialDeliveriesGenerateTransferDNoteParametersDialogView>,PurchaseOrderTrackingMaterialDeliveriesView,PurchaseOrderTrackingMaterialDeliveriesGenerateTransferDNoteParametersDialogView>( params_PurchaseOrderTrackingMaterialDeliveries,this,Screen.PurchaseOrderTrackingMaterialDeliveriesGenerateTransferDNoteParametersDialogView);
 

        }
        public IRPSComboBox<PurchaseOrderTrackingMaterialDeliveriesView> SupplierSelectedForMaterialDeliveries { get; set; } 
        public IRPSButton<PurchaseOrderTrackingMaterialDeliveriesView,PurchaseOrderTrackingMaterialDeliveriesGenerateTransferDNoteParametersDialogView> PurchaseOrderTrackingMaterialDeliveriesGenerateTransferDNoteParametersNavigationCommandButton { get; set; } 
        public IRPSButton<PurchaseOrderTrackingMaterialDeliveriesView,PurchaseOrderTrackingMaterialDeliveriesGenerateTransferMovementsParametersDialogView> PurchaseOrderTrackingMaterialDeliveriesGenerateTransferMovementsParametersNavigationCommandButton { get; set; } 
        public IRPSButton<PurchaseOrderTrackingMaterialDeliveriesView,PurchaseOrderTrackingMaterialDeliveriesGenerateTransferPurchaseDNoteParametersDialogView> PurchaseOrderTrackingMaterialDeliveriesGenerateTransferPurchaseDNoteParametersNavigationCommandButton { get; set; } 
        public IRPSComboBox<PurchaseOrderTrackingMaterialDeliveriesView> SupplierSelectedForMaterialDeliveries1 { get; set; } 
        public PurchaseOrderTrackingMaterialDeliveriesCollectionEditor<PurchaseOrderTrackingMaterialDeliveriesView,PurchaseOrderTrackingMaterialDeliveriesGenerateTransferDNoteParametersDialogView> PurchaseOrderTrackingMaterialDeliveries { get; set; } 
        public PurchaseOrderTracking Screen { get; set; }
        public PurchaseOrderTrackingMaterialDeliveriesView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class PurchaseOrderTrackingMaterialDeliveriesCollectionEditor<PurchaseOrderTrackingMaterialDeliveriesView,PurchaseOrderTrackingMaterialDeliveriesGenerateTransferDNoteParametersDialogView>:RPSCollectionEditor<PurchaseOrderTrackingMaterialDeliveriesView,PurchaseOrderTrackingMaterialDeliveriesGenerateTransferDNoteParametersDialogView> where PurchaseOrderTrackingMaterialDeliveriesView : class, IView where PurchaseOrderTrackingMaterialDeliveriesGenerateTransferDNoteParametersDialogView : class, IView
    {
        public  PurchaseOrderTrackingMaterialDeliveriesGridView<PurchaseOrderTrackingMaterialDeliveriesView,PurchaseOrderTrackingMaterialDeliveriesGenerateTransferDNoteParametersDialogView> GridView {get;set;}
    }
    public partial class PurchaseOrderTrackingMaterialDeliveriesGridView <PurchaseOrderTrackingMaterialDeliveriesView,PurchaseOrderTrackingMaterialDeliveriesGenerateTransferDNoteParametersDialogView> :  RPSGridView<PurchaseOrderTrackingMaterialDeliveriesView,PurchaseOrderTrackingMaterialDeliveriesGenerateTransferDNoteParametersDialogView> where PurchaseOrderTrackingMaterialDeliveriesView : class, IView where PurchaseOrderTrackingMaterialDeliveriesGenerateTransferDNoteParametersDialogView : class, IView
    {
        public PurchaseOrderTrackingMaterialDeliveriesGridView(PurchaseOrderTrackingMaterialDeliveriesView currentView,PurchaseOrderTrackingMaterialDeliveriesGenerateTransferDNoteParametersDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            EditableTransferQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<PurchaseOrderTrackingMaterialDeliveriesView>("","#97f58a61-f37e-4bd0-a212-95b04158746b .ag-row[role='row']@ROWINDEX [col-id='cEditableTransferQuantity']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<PurchaseOrderTrackingMaterialDeliveriesView> EditableTransferQuantity { get; set; } 
                     
    }
 
    }
  
            
    public partial class PurchaseOrderTrackingMaterialDeliveriesGenerateTransferDNoteParametersDialogView : View
    {
        public PurchaseOrderTrackingMaterialDeliveriesGenerateTransferDNoteParametersDialogView(PurchaseOrderTracking screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDSelectedCustomer = RPSControlFactory.CreateRPSComboBox<PurchaseOrderTrackingMaterialDeliveriesGenerateTransferDNoteParametersDialogView>("7d0cebd3-0cbf-4ab8-a6ad-dfef09bbe757","","",true, this);
 
            IDSelectedDeliveryNoteTypeSL = RPSControlFactory.CreateRPSComboBox<PurchaseOrderTrackingMaterialDeliveriesGenerateTransferDNoteParametersDialogView>("b4de8f4d-9cd0-4458-80a8-1c8b354cb640","","",true, this);
 
            SelectedDate = RPSControlFactory.CreateRPSTextBox<PurchaseOrderTrackingMaterialDeliveriesGenerateTransferDNoteParametersDialogView>("03d81bc1-03ef-4a10-a43b-766b8cf6ee12","","",true, this);
 

        }
        public IRPSComboBox<PurchaseOrderTrackingMaterialDeliveriesGenerateTransferDNoteParametersDialogView> IDSelectedCustomer { get; set; } 
        public IRPSComboBox<PurchaseOrderTrackingMaterialDeliveriesGenerateTransferDNoteParametersDialogView> IDSelectedDeliveryNoteTypeSL { get; set; } 
        public IRPSTextBox<PurchaseOrderTrackingMaterialDeliveriesGenerateTransferDNoteParametersDialogView> SelectedDate { get; set; } 
        public PurchaseOrderTracking Screen { get; set; }
        public PurchaseOrderTrackingMaterialDeliveriesGenerateTransferDNoteParametersDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PurchaseOrderTrackingMaterialDeliveriesGenerateTransferMovementsParametersDialogView : View
    {
        public PurchaseOrderTrackingMaterialDeliveriesGenerateTransferMovementsParametersDialogView(PurchaseOrderTracking screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDSelectedMovementType = RPSControlFactory.CreateRPSComboBox<PurchaseOrderTrackingMaterialDeliveriesGenerateTransferMovementsParametersDialogView>("e0750775-f81a-420e-b004-d3c0b1379a39","","",true, this);
 
            SelectedDate = RPSControlFactory.CreateRPSTextBox<PurchaseOrderTrackingMaterialDeliveriesGenerateTransferMovementsParametersDialogView>("c1adbb1d-58a2-438f-8bc3-7aa9f9331dcc","","",true, this);
 

        }
        public IRPSComboBox<PurchaseOrderTrackingMaterialDeliveriesGenerateTransferMovementsParametersDialogView> IDSelectedMovementType { get; set; } 
        public IRPSTextBox<PurchaseOrderTrackingMaterialDeliveriesGenerateTransferMovementsParametersDialogView> SelectedDate { get; set; } 
        public PurchaseOrderTracking Screen { get; set; }
        public PurchaseOrderTrackingMaterialDeliveriesGenerateTransferMovementsParametersDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class TransferMovementsForExternalTaskDialogView : View
    {
        public TransferMovementsForExternalTaskDialogView(PurchaseOrderTracking screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            AddNewMovementCommandButton = RPSControlFactory.CreateRPSButton<TransferMovementsForExternalTaskDialogView>( "68a86490-c2e5-4d6a-857a-06ef43389447","","",this);
 
            SaveCommandButton = RPSControlFactory.CreateRPSButton<TransferMovementsForExternalTaskDialogView>( "0f561616-852e-4aab-833c-45e4d90917e2","","",this);
 
            CollectionInit params_TransferMovements = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d69eb731-4e8f-426c-9146-11f6310d6d9f",CSSSelectorGrid="",XPathGrid=""};
            TransferMovements = RPSControlFactory.RPSCreateCollectionWithGrid<TransferMovementsCollectionEditor<TransferMovementsForExternalTaskDialogView>,TransferMovementsForExternalTaskDialogView>( params_TransferMovements,this);
 

        }
        public IRPSButton<TransferMovementsForExternalTaskDialogView> AddNewMovementCommandButton { get; set; } 
        public IRPSButton<TransferMovementsForExternalTaskDialogView> SaveCommandButton { get; set; } 
        public TransferMovementsCollectionEditor<TransferMovementsForExternalTaskDialogView> TransferMovements { get; set; } 
        public PurchaseOrderTracking Screen { get; set; }
        public TransferMovementsForExternalTaskDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class TransferMovementsCollectionEditor<TransferMovementsForExternalTaskDialogView>:RPSCollectionEditor<TransferMovementsForExternalTaskDialogView> where TransferMovementsForExternalTaskDialogView : class, IView
    {
        public  TransferMovementsGridView<TransferMovementsForExternalTaskDialogView> GridView {get;set;}
    }
    public partial class TransferMovementsGridView <TransferMovementsForExternalTaskDialogView> :  RPSGridView<TransferMovementsForExternalTaskDialogView> where TransferMovementsForExternalTaskDialogView : class, IView
    {
        public TransferMovementsGridView(TransferMovementsForExternalTaskDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            RemoveCommand = RPSControlFactory.CreateRPSGridButton<TransferMovementsForExternalTaskDialogView>( "","#d69eb731-4e8f-426c-9146-11f6310d6d9f .ag-row[role='row']@ROWINDEX [col-id='cRemoveCommand']","",this.CurrentView);
 
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<TransferMovementsForExternalTaskDialogView>("","#d69eb731-4e8f-426c-9146-11f6310d6d9f .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",false, this.CurrentView);
 
            IDSite = RPSControlFactory.CreateRPSGridComboBox<TransferMovementsForExternalTaskDialogView>("","#d69eb731-4e8f-426c-9146-11f6310d6d9f .ag-row[role='row']@ROWINDEX [col-id='cIDSite']","",false, this.CurrentView);
 
            IDWareHouse = RPSControlFactory.CreateRPSGridComboBox<TransferMovementsForExternalTaskDialogView>("","#d69eb731-4e8f-426c-9146-11f6310d6d9f .ag-row[role='row']@ROWINDEX [col-id='cIDWareHouse']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<TransferMovementsForExternalTaskDialogView>("","#d69eb731-4e8f-426c-9146-11f6310d6d9f .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            Series = RPSControlFactory.CreateRPSGridEnumComboBox<TransferMovementsForExternalTaskDialogView>("","#d69eb731-4e8f-426c-9146-11f6310d6d9f .ag-row[role='row']@ROWINDEX [col-id='cSeries']","",false, this.CurrentView);
 
            IDLocationWarehouse = RPSControlFactory.CreateRPSGridComboBox<TransferMovementsForExternalTaskDialogView>("","#d69eb731-4e8f-426c-9146-11f6310d6d9f .ag-row[role='row']@ROWINDEX [col-id='cIDLocationWarehouse']","",false, this.CurrentView);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSGridFormattedTextBox<TransferMovementsForExternalTaskDialogView>("","#d69eb731-4e8f-426c-9146-11f6310d6d9f .ag-row[role='row']@ROWINDEX [col-id='cQuantitySecondUnit']","",false, this.CurrentView);
 
            IDSiteTransfer = RPSControlFactory.CreateRPSGridComboBox<TransferMovementsForExternalTaskDialogView>("","#d69eb731-4e8f-426c-9146-11f6310d6d9f .ag-row[role='row']@ROWINDEX [col-id='cIDSiteTransfer']","",false, this.CurrentView);
 
            IDWareHouseTransfer = RPSControlFactory.CreateRPSGridComboBox<TransferMovementsForExternalTaskDialogView>("","#d69eb731-4e8f-426c-9146-11f6310d6d9f .ag-row[role='row']@ROWINDEX [col-id='cIDWareHouseTransfer']","",false, this.CurrentView);
 
            IDLocationWarehouseTransfer = RPSControlFactory.CreateRPSGridComboBox<TransferMovementsForExternalTaskDialogView>("","#d69eb731-4e8f-426c-9146-11f6310d6d9f .ag-row[role='row']@ROWINDEX [col-id='cIDLocationWarehouseTransfer']","",false, this.CurrentView);
 

        }
        public IRPSGridButton<TransferMovementsForExternalTaskDialogView> RemoveCommand { get; set; } 
        public IRPSGridComboBox<TransferMovementsForExternalTaskDialogView> IDArticle { get; set; } 
        public IRPSGridComboBox<TransferMovementsForExternalTaskDialogView> IDSite { get; set; } 
        public IRPSGridComboBox<TransferMovementsForExternalTaskDialogView> IDWareHouse { get; set; } 
        public IRPSGridTextBox<TransferMovementsForExternalTaskDialogView> Quantity { get; set; } 
        public IRPSGridComboBox<TransferMovementsForExternalTaskDialogView> Series { get; set; } 
        public IRPSGridComboBox<TransferMovementsForExternalTaskDialogView> IDLocationWarehouse { get; set; } 
        public IRPSGridTextBox<TransferMovementsForExternalTaskDialogView> QuantitySecondUnit { get; set; } 
        public IRPSGridComboBox<TransferMovementsForExternalTaskDialogView> IDSiteTransfer { get; set; } 
        public IRPSGridComboBox<TransferMovementsForExternalTaskDialogView> IDWareHouseTransfer { get; set; } 
        public IRPSGridComboBox<TransferMovementsForExternalTaskDialogView> IDLocationWarehouseTransfer { get; set; } 
                     
    }
 
    }
  
            
    public partial class PurchaseOrderTrackingMaterialDeliveriesGenerateTransferPurchaseDNoteParametersDialogView : View
    {
        public PurchaseOrderTrackingMaterialDeliveriesGenerateTransferPurchaseDNoteParametersDialogView(PurchaseOrderTracking screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<PurchaseOrderTrackingMaterialDeliveriesGenerateTransferPurchaseDNoteParametersDialogView>("a2b1143f-7cd4-416d-ba94-1f8ef43b8b04","","",false, this);
 
            SelectedDate = RPSControlFactory.CreateRPSTextBox<PurchaseOrderTrackingMaterialDeliveriesGenerateTransferPurchaseDNoteParametersDialogView>("0625cabb-4927-4941-87b3-1ae35a3b4232","","",true, this);
 

        }
        public IRPSComboBox<PurchaseOrderTrackingMaterialDeliveriesGenerateTransferPurchaseDNoteParametersDialogView> IDDeliveryNoteType { get; set; } 
        public IRPSTextBox<PurchaseOrderTrackingMaterialDeliveriesGenerateTransferPurchaseDNoteParametersDialogView> SelectedDate { get; set; } 
        public PurchaseOrderTracking Screen { get; set; }
        public PurchaseOrderTrackingMaterialDeliveriesGenerateTransferPurchaseDNoteParametersDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}