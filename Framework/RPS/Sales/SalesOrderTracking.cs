    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.SalesOrderTracking
{
    //RPS VERSION 1.0.0.0
    public partial class SalesOrderTracking:Screen
    {
        public SalesOrderTracking():base()
        {
            this.URL = "sales.salesordertracking";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SalesOrderTrackingView  = new SalesOrderTrackingView(this); 
            SalesOrderTrackingView.InitializeControls(); 
           
        }
      
            public SalesOrderTrackingView SalesOrderTrackingView {get; set; } 
    }
            
    public partial class SalesOrderTrackingView : View
    {
        public SalesOrderTrackingView(SalesOrderTracking screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SelectedSalesOrders = RPSControlFactory.CreateRPSCollectionComboBox<SalesOrderTrackingView>("878e6865-39da-4af8-8416-3b776ac07535","","",false, this);
 
            SelectedCustomers = RPSControlFactory.CreateRPSCollectionComboBox<SalesOrderTrackingView>("1f2fd041-727f-4568-95bc-8cfcba2d9b1f","","",false, this);
 
            SalesOrderDateFrom = RPSControlFactory.CreateRPSTextBox<SalesOrderTrackingView>("ed12059f-18c0-4ca1-a3d0-66b8ce49fe2c","","",false, this);
 
            SalesOrderDateTo = RPSControlFactory.CreateRPSTextBox<SalesOrderTrackingView>("9b071eb8-23d8-4882-9557-2ff275c9b8ce","","",false, this);
 
            SalesOrderDeliveryDateFrom = RPSControlFactory.CreateRPSTextBox<SalesOrderTrackingView>("8204dfd2-b50a-4039-a195-689b5bc54e4a","","",false, this);
 
            SalesOrderDeliveryDateTo = RPSControlFactory.CreateRPSTextBox<SalesOrderTrackingView>("39e47e41-d303-4d79-956d-1e561cbe9938","","",false, this);
 
            SelectedShippingAgents = RPSControlFactory.CreateRPSCollectionComboBox<SalesOrderTrackingView>("ac097212-4c1b-49c5-94b5-c02c7f008b3d","","",false, this);
 
            SelectedCustomerOrderNumber = RPSControlFactory.CreateRPSTextBox<SalesOrderTrackingView>("83ca0306-4824-4443-9208-3889e956c4df","","",false, this);
 
            CriticalDelay = RPSControlFactory.CreateRPSCheckBox<SalesOrderTrackingView>("0bbc8ab1-2728-414b-a465-475695677108","","",false, this);
 
            DelayDelivery = RPSControlFactory.CreateRPSCheckBox<SalesOrderTrackingView>("dd9a4229-0769-44c5-9381-496e337a9808","","",false, this);
 
            DelayDeliveryValue = RPSControlFactory.CreateRPSFormattedTextBox<SalesOrderTrackingView>("f3395930-4f63-4ae8-8457-47930cd2086e","","",false, this);
 
            DelayOrigin = RPSControlFactory.CreateRPSCheckBox<SalesOrderTrackingView>("765e5ed4-b0f2-4905-8c0f-983b82716a2e","","",false, this);
 
            DelayOriginValue = RPSControlFactory.CreateRPSFormattedTextBox<SalesOrderTrackingView>("d0571c99-fb97-4a26-8fbc-80afe47e7b9b","","",false, this);
 
            DelayDeliveryOrigin = RPSControlFactory.CreateRPSCheckBox<SalesOrderTrackingView>("6c03dfbf-1ed9-40c9-b9b3-c044209694b7","","",false, this);
 
            DelayDeliveryOriginValue = RPSControlFactory.CreateRPSFormattedTextBox<SalesOrderTrackingView>("e89a259c-c5f8-43cb-87d4-09e0e10fcb2c","","",false, this);
 
            SelectedProductLines = RPSControlFactory.CreateRPSCollectionComboBox<SalesOrderTrackingView>("0d8d888a-ae0b-4619-a455-d68fe1a21589","","",false, this);
 
            SelectedProductFamilies = RPSControlFactory.CreateRPSCollectionComboBox<SalesOrderTrackingView>("e5cfd296-9a82-4213-b9a8-9ab6369d404c","","",false, this);
 
            SelectedProductSubFamilies = RPSControlFactory.CreateRPSCollectionComboBox<SalesOrderTrackingView>("ba3b6a93-f7c1-4d7c-a9f5-7d0c98ef797d","","",false, this);
 
            SelectedArticles = RPSControlFactory.CreateRPSCollectionComboBox<SalesOrderTrackingView>("0393f66c-b99d-4555-8dc3-1a4fc094e053","","",false, this);
 
            CustomerReference = RPSControlFactory.CreateRPSEnumComboBox<SalesOrderTrackingView>("7f873833-86db-4669-9200-39d4a37d47a1","","",false, this);
 
            ExcludedArticles = RPSControlFactory.CreateRPSCheckBox<SalesOrderTrackingView>("11d8aa51-74d8-47c1-93f5-1e5e1f6f8795","","",false, this);
 
            SalesQuotesSelected = RPSControlFactory.CreateRPSCollectionComboBox<SalesOrderTrackingView>("9f50e388-b5e8-4827-9280-38bdc3526d24","","",false, this);
 
            ProjectsSelected = RPSControlFactory.CreateRPSCollectionComboBox<SalesOrderTrackingView>("f53660f1-39be-42a2-80a0-3a5fbfe91e06","","",false, this);
 
            MOsSelected = RPSControlFactory.CreateRPSCollectionComboBox<SalesOrderTrackingView>("7a25dbe1-eac6-4167-a996-de5f4a482e78","","",false, this);
 
            InternalCodeSelected = RPSControlFactory.CreateRPSTextBox<SalesOrderTrackingView>("7bf35711-bff9-4d22-bfd8-7d299f2843ae","","",false, this);
 
            MaintenanceOrdersSelected = RPSControlFactory.CreateRPSCollectionComboBox<SalesOrderTrackingView>("1cc15104-c180-4590-a998-76571ed21282","","",false, this);
 
            LinesDelayed = RPSControlFactory.CreateRPSCheckBox<SalesOrderTrackingView>("cfeed2a3-1c7d-419f-965a-2bf86a6b6207","","",false, this);
 
            ExecuteSalesOrderTrackingConsultationPrecalc = RPSControlFactory.CreateRPSButton<SalesOrderTrackingView>( "60e0ba9a-895d-40e8-987d-559e431b7c01","","",this);
 
            PrintReportCommand = RPSControlFactory.CreateRPSButton<SalesOrderTrackingView>( "32201184-c02f-4c89-bf7e-8cc25a378f74","","",this);
 
            DelayDelivery1 = RPSControlFactory.CreateRPSFormattedTextBox<SalesOrderTrackingView>("92bc2000-8fd8-47f2-9bd3-b3f51b117f65","","",false, this);
 
            DelayOrigin1 = RPSControlFactory.CreateRPSFormattedTextBox<SalesOrderTrackingView>("4499e3cb-af4d-4657-84c6-850a748e2bca","","",false, this);
 
            Delay = RPSControlFactory.CreateRPSFormattedTextBox<SalesOrderTrackingView>("1192ef8e-51a9-49ca-bc0e-94e1933da428","","",false, this);
 
            CustomerOrderNumber = RPSControlFactory.CreateRPSTextBox<SalesOrderTrackingView>("b747683c-6e78-4fbc-927a-285c8b76ed11","","",false, this);
 
            Blocked = RPSControlFactory.CreateRPSCheckBox<SalesOrderTrackingView>("f6c28967-52cd-4131-8604-aea676a26b5d","","",false, this);
 
            Priority = RPSControlFactory.CreateRPSFormattedTextBox<SalesOrderTrackingView>("ee150c48-fd28-42e8-8c27-52996f1f02fb","","",false, this);
 
            InternalCode = RPSControlFactory.CreateRPSTextBox<SalesOrderTrackingView>("54ac8c04-98fc-4b89-973b-d873036a38bc","","",false, this);
 
            ReferenceCustomer = RPSControlFactory.CreateRPSTextBox<SalesOrderTrackingView>("38facb30-3de3-47c6-8776-01977d2b935f","","",false, this);
 
            OrderDate = RPSControlFactory.CreateRPSTextBox<SalesOrderTrackingView>("44aeb1c0-1ade-4ba0-9e3e-006148707ee6","","",false, this);
 
            SendDate = RPSControlFactory.CreateRPSTextBox<SalesOrderTrackingView>("a181f710-0853-4229-86cb-0766fee69156","","",false, this);
 
            RequestedDeliveryDate = RPSControlFactory.CreateRPSTextBox<SalesOrderTrackingView>("56e6908b-ecbd-4971-bccf-446350bb138a","","",false, this);
 
            StockAtWarehouse = RPSControlFactory.CreateRPSFormattedTextBox<SalesOrderTrackingView>("d6fb04c6-008c-4739-93b0-f1300f0aec9e","","",false, this);
 
            StockAtSite = RPSControlFactory.CreateRPSFormattedTextBox<SalesOrderTrackingView>("2f877bc1-45bc-4be2-bb7e-f31e506e59c9","","",false, this);
 
            GlobalStock = RPSControlFactory.CreateRPSFormattedTextBox<SalesOrderTrackingView>("72ec5525-ca53-410b-9d11-2bb75ffc5812","","",false, this);
 
            CollectionInit params_CuDistSalesOrderTrackingConsultationCustom = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="32b7f55a-7872-4f1d-a946-8e8fef6c5495",CSSSelectorGrid="",XPathGrid=""};
            CuDistSalesOrderTrackingConsultationCustom = RPSControlFactory.RPSCreateCollectionWithGrid<CuDistSalesOrderTrackingConsultationCustomCollectionEditor<SalesOrderTrackingView>,SalesOrderTrackingView>( params_CuDistSalesOrderTrackingConsultationCustom,this);
 
            CollectionInit params_SalesOrderTrackingConsultationManufacturingOrderGrid = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="47a678ce-47c1-4c8f-8d3f-35baf192e362",CSSSelectorGrid="",XPathGrid=""};
            SalesOrderTrackingConsultationManufacturingOrderGrid = RPSControlFactory.RPSCreateCollectionWithGrid<SalesOrderTrackingConsultationManufacturingOrderGridCollectionEditor<SalesOrderTrackingView>,SalesOrderTrackingView>( params_SalesOrderTrackingConsultationManufacturingOrderGrid,this);
 
            CollectionInit params_SalesOrderTrackingConsultationPurchaseOrderGrid = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8c923964-bf08-4087-aa7b-83f2ff6e7ffb",CSSSelectorGrid="",XPathGrid=""};
            SalesOrderTrackingConsultationPurchaseOrderGrid = RPSControlFactory.RPSCreateCollectionWithGrid<SalesOrderTrackingConsultationPurchaseOrderGridCollectionEditor<SalesOrderTrackingView>,SalesOrderTrackingView>( params_SalesOrderTrackingConsultationPurchaseOrderGrid,this);
 
            Section = RPSControlFactory.CreateRPSSection<SalesOrderTrackingView>( "","ul li[rpsid='50baf1ed-0f19-4831-a1e6-2305a7601267']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<SalesOrderTrackingView>( "","ul li[rpsid='edd21827-2e87-442a-8791-067ab288e216']","",this);
 
            Section2 = RPSControlFactory.CreateRPSSection<SalesOrderTrackingView>( "","ul li[rpsid='2783b828-fd07-448e-8812-8d79c6b3b875']","",this);
 

        }
        public IRPSCollectionComboBox<SalesOrderTrackingView> SelectedSalesOrders { get; set; } 
        public IRPSCollectionComboBox<SalesOrderTrackingView> SelectedCustomers { get; set; } 
        public IRPSTextBox<SalesOrderTrackingView> SalesOrderDateFrom { get; set; } 
        public IRPSTextBox<SalesOrderTrackingView> SalesOrderDateTo { get; set; } 
        public IRPSTextBox<SalesOrderTrackingView> SalesOrderDeliveryDateFrom { get; set; } 
        public IRPSTextBox<SalesOrderTrackingView> SalesOrderDeliveryDateTo { get; set; } 
        public IRPSCollectionComboBox<SalesOrderTrackingView> SelectedShippingAgents { get; set; } 
        public IRPSTextBox<SalesOrderTrackingView> SelectedCustomerOrderNumber { get; set; } 
        public IRPSCheckbox<SalesOrderTrackingView> CriticalDelay { get; set; } 
        public IRPSCheckbox<SalesOrderTrackingView> DelayDelivery { get; set; } 
        public IRPSTextBox<SalesOrderTrackingView> DelayDeliveryValue { get; set; } 
        public IRPSCheckbox<SalesOrderTrackingView> DelayOrigin { get; set; } 
        public IRPSTextBox<SalesOrderTrackingView> DelayOriginValue { get; set; } 
        public IRPSCheckbox<SalesOrderTrackingView> DelayDeliveryOrigin { get; set; } 
        public IRPSTextBox<SalesOrderTrackingView> DelayDeliveryOriginValue { get; set; } 
        public IRPSCollectionComboBox<SalesOrderTrackingView> SelectedProductLines { get; set; } 
        public IRPSCollectionComboBox<SalesOrderTrackingView> SelectedProductFamilies { get; set; } 
        public IRPSCollectionComboBox<SalesOrderTrackingView> SelectedProductSubFamilies { get; set; } 
        public IRPSCollectionComboBox<SalesOrderTrackingView> SelectedArticles { get; set; } 
        public IRPSComboBox<SalesOrderTrackingView> CustomerReference { get; set; } 
        public IRPSCheckbox<SalesOrderTrackingView> ExcludedArticles { get; set; } 
        public IRPSCollectionComboBox<SalesOrderTrackingView> SalesQuotesSelected { get; set; } 
        public IRPSCollectionComboBox<SalesOrderTrackingView> ProjectsSelected { get; set; } 
        public IRPSCollectionComboBox<SalesOrderTrackingView> MOsSelected { get; set; } 
        public IRPSTextBox<SalesOrderTrackingView> InternalCodeSelected { get; set; } 
        public IRPSCollectionComboBox<SalesOrderTrackingView> MaintenanceOrdersSelected { get; set; } 
        public IRPSCheckbox<SalesOrderTrackingView> LinesDelayed { get; set; } 
        public IRPSButton<SalesOrderTrackingView> ExecuteSalesOrderTrackingConsultationPrecalc { get; set; } 
        public IRPSButton<SalesOrderTrackingView> PrintReportCommand { get; set; } 
        public IRPSTextBox<SalesOrderTrackingView> DelayDelivery1 { get; set; } 
        public IRPSTextBox<SalesOrderTrackingView> DelayOrigin1 { get; set; } 
        public IRPSTextBox<SalesOrderTrackingView> Delay { get; set; } 
        public IRPSTextBox<SalesOrderTrackingView> CustomerOrderNumber { get; set; } 
        public IRPSCheckbox<SalesOrderTrackingView> Blocked { get; set; } 
        public IRPSTextBox<SalesOrderTrackingView> Priority { get; set; } 
        public IRPSTextBox<SalesOrderTrackingView> InternalCode { get; set; } 
        public IRPSTextBox<SalesOrderTrackingView> ReferenceCustomer { get; set; } 
        public IRPSTextBox<SalesOrderTrackingView> OrderDate { get; set; } 
        public IRPSTextBox<SalesOrderTrackingView> SendDate { get; set; } 
        public IRPSTextBox<SalesOrderTrackingView> RequestedDeliveryDate { get; set; } 
        public IRPSTextBox<SalesOrderTrackingView> StockAtWarehouse { get; set; } 
        public IRPSTextBox<SalesOrderTrackingView> StockAtSite { get; set; } 
        public IRPSTextBox<SalesOrderTrackingView> GlobalStock { get; set; } 
        public CuDistSalesOrderTrackingConsultationCustomCollectionEditor<SalesOrderTrackingView> CuDistSalesOrderTrackingConsultationCustom { get; set; } 
        public SalesOrderTrackingConsultationManufacturingOrderGridCollectionEditor<SalesOrderTrackingView> SalesOrderTrackingConsultationManufacturingOrderGrid { get; set; } 
        public SalesOrderTrackingConsultationPurchaseOrderGridCollectionEditor<SalesOrderTrackingView> SalesOrderTrackingConsultationPurchaseOrderGrid { get; set; } 
        public IRPSSection<SalesOrderTrackingView> Section { get; set; } 
        public IRPSSection<SalesOrderTrackingView> Section1 { get; set; } 
        public IRPSSection<SalesOrderTrackingView> Section2 { get; set; } 
        public SalesOrderTracking Screen { get; set; }
        public SalesOrderTrackingView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CuDistSalesOrderTrackingConsultationCustomCollectionEditor<SalesOrderTrackingView>:RPSCollectionEditor<SalesOrderTrackingView> where SalesOrderTrackingView : class, IView
    {
        public  CuDistSalesOrderTrackingConsultationCustomGridView<SalesOrderTrackingView> GridView {get;set;}
    }
    public partial class CuDistSalesOrderTrackingConsultationCustomGridView <SalesOrderTrackingView> :  RPSGridView<SalesOrderTrackingView> where SalesOrderTrackingView : class, IView
    {
        public CuDistSalesOrderTrackingConsultationCustomGridView(SalesOrderTrackingView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            SendDateForResultGrid = RPSControlFactory.CreateRPSGridTextBox<SalesOrderTrackingView>("","#32b7f55a-7872-4f1d-a946-8e8fef6c5495 .ag-row[role='row']@ROWINDEX [col-id='cSendDateForResultGrid']","",false, this.CurrentView);
 
            DelayDeliveryForResultGrid = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesOrderTrackingView>("","#32b7f55a-7872-4f1d-a946-8e8fef6c5495 .ag-row[role='row']@ROWINDEX [col-id='cDelayDeliveryForResultGrid']","",false, this.CurrentView);
 
            DelayOriginForResultGrid = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesOrderTrackingView>("","#32b7f55a-7872-4f1d-a946-8e8fef6c5495 .ag-row[role='row']@ROWINDEX [col-id='cDelayOriginForResultGrid']","",false, this.CurrentView);
 
            DelayForResultGrid = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesOrderTrackingView>("","#32b7f55a-7872-4f1d-a946-8e8fef6c5495 .ag-row[role='row']@ROWINDEX [col-id='cDelayForResultGrid']","",false, this.CurrentView);
 
            BlockedMRP = RPSControlFactory.CreateRPSGridCheckBox<SalesOrderTrackingView>("","#32b7f55a-7872-4f1d-a946-8e8fef6c5495 .ag-row[role='row']@ROWINDEX [col-id='cBlockedMRP']","",false, this.CurrentView);
 
            DiffStartPlannedDate = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesOrderTrackingView>("","#32b7f55a-7872-4f1d-a946-8e8fef6c5495 .ag-row[role='row']@ROWINDEX [col-id='cDiffStartPlannedDate']","",false, this.CurrentView);
 
            DiffTodayPlanStartDate = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesOrderTrackingView>("","#32b7f55a-7872-4f1d-a946-8e8fef6c5495 .ag-row[role='row']@ROWINDEX [col-id='cDiffTodayPlanStartDate']","",false, this.CurrentView);
 
            CodProductLine = RPSControlFactory.CreateRPSGridTextBox<SalesOrderTrackingView>("","#32b7f55a-7872-4f1d-a946-8e8fef6c5495 .ag-row[role='row']@ROWINDEX [col-id='cCodProductLine']","",false, this.CurrentView);
 
            DescProductLine = RPSControlFactory.CreateRPSGridTextBox<SalesOrderTrackingView>("","#32b7f55a-7872-4f1d-a946-8e8fef6c5495 .ag-row[role='row']@ROWINDEX [col-id='cDescProductLine']","",false, this.CurrentView);
 
            CodProductFamily = RPSControlFactory.CreateRPSGridTextBox<SalesOrderTrackingView>("","#32b7f55a-7872-4f1d-a946-8e8fef6c5495 .ag-row[role='row']@ROWINDEX [col-id='cCodProductFamily']","",false, this.CurrentView);
 
            DescProductFamily = RPSControlFactory.CreateRPSGridTextBox<SalesOrderTrackingView>("","#32b7f55a-7872-4f1d-a946-8e8fef6c5495 .ag-row[role='row']@ROWINDEX [col-id='cDescProductFamily']","",false, this.CurrentView);
 
            CodProductSubFamily = RPSControlFactory.CreateRPSGridTextBox<SalesOrderTrackingView>("","#32b7f55a-7872-4f1d-a946-8e8fef6c5495 .ag-row[role='row']@ROWINDEX [col-id='cCodProductSubFamily']","",false, this.CurrentView);
 
            DescProductSubFamily = RPSControlFactory.CreateRPSGridTextBox<SalesOrderTrackingView>("","#32b7f55a-7872-4f1d-a946-8e8fef6c5495 .ag-row[role='row']@ROWINDEX [col-id='cDescProductSubFamily']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SalesOrderTrackingView> SendDateForResultGrid { get; set; } 
        public IRPSGridTextBox<SalesOrderTrackingView> DelayDeliveryForResultGrid { get; set; } 
        public IRPSGridTextBox<SalesOrderTrackingView> DelayOriginForResultGrid { get; set; } 
        public IRPSGridTextBox<SalesOrderTrackingView> DelayForResultGrid { get; set; } 
        public IRPSGridCheckbox<SalesOrderTrackingView> BlockedMRP { get; set; } 
        public IRPSGridTextBox<SalesOrderTrackingView> DiffStartPlannedDate { get; set; } 
        public IRPSGridTextBox<SalesOrderTrackingView> DiffTodayPlanStartDate { get; set; } 
        public IRPSGridTextBox<SalesOrderTrackingView> CodProductLine { get; set; } 
        public IRPSGridTextBox<SalesOrderTrackingView> DescProductLine { get; set; } 
        public IRPSGridTextBox<SalesOrderTrackingView> CodProductFamily { get; set; } 
        public IRPSGridTextBox<SalesOrderTrackingView> DescProductFamily { get; set; } 
        public IRPSGridTextBox<SalesOrderTrackingView> CodProductSubFamily { get; set; } 
        public IRPSGridTextBox<SalesOrderTrackingView> DescProductSubFamily { get; set; } 
                     
    }
 
        public partial class SalesOrderTrackingConsultationManufacturingOrderGridCollectionEditor<SalesOrderTrackingView>:RPSCollectionEditor<SalesOrderTrackingView> where SalesOrderTrackingView : class, IView
    {
        public  SalesOrderTrackingConsultationManufacturingOrderGridGridView<SalesOrderTrackingView> GridView {get;set;}
    }
    public partial class SalesOrderTrackingConsultationManufacturingOrderGridGridView <SalesOrderTrackingView> :  RPSGridView<SalesOrderTrackingView> where SalesOrderTrackingView : class, IView
    {
        public SalesOrderTrackingConsultationManufacturingOrderGridGridView(SalesOrderTrackingView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            EndDate = RPSControlFactory.CreateRPSGridTextBox<SalesOrderTrackingView>("","#47a678ce-47c1-4c8f-8d3f-35baf192e362 .ag-row[role='row']@ROWINDEX [col-id='cEndDate']","",false, this.CurrentView);
 
            Ordenation = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesOrderTrackingView>("","#47a678ce-47c1-4c8f-8d3f-35baf192e362 .ag-row[role='row']@ROWINDEX [col-id='cOrdenation']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SalesOrderTrackingView> EndDate { get; set; } 
        public IRPSGridTextBox<SalesOrderTrackingView> Ordenation { get; set; } 
                     
    }
 
        public partial class SalesOrderTrackingConsultationPurchaseOrderGridCollectionEditor<SalesOrderTrackingView>:RPSCollectionEditor<SalesOrderTrackingView> where SalesOrderTrackingView : class, IView
    {
        public  SalesOrderTrackingConsultationPurchaseOrderGridGridView<SalesOrderTrackingView> GridView {get;set;}
    }
    public partial class SalesOrderTrackingConsultationPurchaseOrderGridGridView <SalesOrderTrackingView> :  RPSGridView<SalesOrderTrackingView> where SalesOrderTrackingView : class, IView
    {
        public SalesOrderTrackingConsultationPurchaseOrderGridGridView(SalesOrderTrackingView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            PurchaseOrdenation = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesOrderTrackingView>("","#8c923964-bf08-4087-aa7b-83f2ff6e7ffb .ag-row[role='row']@ROWINDEX [col-id='cPurchaseOrdenation']","",false, this.CurrentView);
 
            OrderDate = RPSControlFactory.CreateRPSGridTextBox<SalesOrderTrackingView>("","#8c923964-bf08-4087-aa7b-83f2ff6e7ffb .ag-row[role='row']@ROWINDEX [col-id='cOrderDate']","",false, this.CurrentView);
 
            ReceptionDate = RPSControlFactory.CreateRPSGridTextBox<SalesOrderTrackingView>("","#8c923964-bf08-4087-aa7b-83f2ff6e7ffb .ag-row[role='row']@ROWINDEX [col-id='cReceptionDate']","",false, this.CurrentView);
 
            RequestedReceptionDate = RPSControlFactory.CreateRPSGridTextBox<SalesOrderTrackingView>("","#8c923964-bf08-4087-aa7b-83f2ff6e7ffb .ag-row[role='row']@ROWINDEX [col-id='cRequestedReceptionDate']","",false, this.CurrentView);
 
            SalesOrdenation = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesOrderTrackingView>("","#8c923964-bf08-4087-aa7b-83f2ff6e7ffb .ag-row[role='row']@ROWINDEX [col-id='cSalesOrdenation']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SalesOrderTrackingView> PurchaseOrdenation { get; set; } 
        public IRPSGridTextBox<SalesOrderTrackingView> OrderDate { get; set; } 
        public IRPSGridTextBox<SalesOrderTrackingView> ReceptionDate { get; set; } 
        public IRPSGridTextBox<SalesOrderTrackingView> RequestedReceptionDate { get; set; } 
        public IRPSGridTextBox<SalesOrderTrackingView> SalesOrdenation { get; set; } 
                     
    }
 
    }
  
    

}