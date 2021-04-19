    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.MaintenanceContract
{
    //RPS VERSION 1.0.0.0
    public partial class MaintenanceContract:Screen
    {
        public MaintenanceContract():base()
        {
            this.URL = "maintenance.maintenancecontract";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MaintenanceContractCollectionView  = new MaintenanceContractCollectionView(this); 
            MaintenanceContractEntityView  = new MaintenanceContractEntityView(this); 
            MaintenanceContractContentView  = new MaintenanceContractContentView(this); 
            MaintenanceContractBillingPeriodView  = new MaintenanceContractBillingPeriodView(this); 
            MaintenanceContractContentPlanResourcesCalculationsDialogView  = new MaintenanceContractContentPlanResourcesCalculationsDialogView(this); 
            MaintenanceContractContentAssistancePlanView  = new MaintenanceContractContentAssistancePlanView(this); 
            PrintMaintenanceContractChildDialogView  = new PrintMaintenanceContractChildDialogView(this); 
            MaintenanceContractCollectionView.InitializeControls(); 
            MaintenanceContractEntityView.InitializeControls(); 
            MaintenanceContractContentView.InitializeControls(); 
            MaintenanceContractBillingPeriodView.InitializeControls(); 
            MaintenanceContractContentPlanResourcesCalculationsDialogView.InitializeControls(); 
            MaintenanceContractContentAssistancePlanView.InitializeControls(); 
            PrintMaintenanceContractChildDialogView.InitializeControls(); 
           
        }
      
            public MaintenanceContractCollectionView MaintenanceContractCollectionView {get; set; } 
            public MaintenanceContractEntityView MaintenanceContractEntityView {get; set; } 
            public MaintenanceContractContentView MaintenanceContractContentView {get; set; } 
            public MaintenanceContractBillingPeriodView MaintenanceContractBillingPeriodView {get; set; } 
            public MaintenanceContractContentPlanResourcesCalculationsDialogView MaintenanceContractContentPlanResourcesCalculationsDialogView {get; set; } 
            public MaintenanceContractContentAssistancePlanView MaintenanceContractContentAssistancePlanView {get; set; } 
            public PrintMaintenanceContractChildDialogView PrintMaintenanceContractChildDialogView {get; set; } 
    }
            
    public partial class MaintenanceContractCollectionView : View
    {
        public MaintenanceContractCollectionView(MaintenanceContract screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<MaintenanceContractCollectionView,MaintenanceContractEntityView>( this,Screen.MaintenanceContractEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "c4b97ef6-a3fb-4691-bc2d-3ad2b5a435eb",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<MaintenanceContractCollectionView,MaintenanceContractEntityView>( params_MainConsult,this,Screen.MaintenanceContractEntityView);
 

        }
        public IRPSButton<MaintenanceContractCollectionView,MaintenanceContractEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<MaintenanceContractCollectionView,MaintenanceContractEntityView> MainConsult { get; set; } 
        public MaintenanceContract Screen { get; set; }
        public MaintenanceContractCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenanceContractEntityView : View
    {
        public MaintenanceContractEntityView(MaintenanceContract screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MaintenanceContractEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceContractEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceContractEntityView,MaintenanceContractCollectionView>( this,Screen.MaintenanceContractCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceContractEntityView,MaintenanceContractCollectionView>( this,Screen.MaintenanceContractCollectionView);
 
            MaintenanceContractCode = RPSControlFactory.CreateRPSTextBox<MaintenanceContractEntityView>("2b193f1c-9122-401f-84ca-1e75ea56613e","","",false, this);
 
            MaintenanceContractType = RPSControlFactory.CreateRPSEnumComboBox<MaintenanceContractEntityView>("2d1d0b3e-5653-4a92-8bd4-b77d4a3d4d7e","","",true, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<MaintenanceContractEntityView>("517d6248-6abd-476d-8cf8-3b84193813c5","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<MaintenanceContractEntityView>("f91e6b3d-8d76-43bd-ba62-4e194970e856","","",false, this);
 
            IDSupplierContact = RPSControlFactory.CreateRPSComboBox<MaintenanceContractEntityView>("255cc5f9-e254-4f41-8f60-ccef8df93a09","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<MaintenanceContractEntityView>("30e7e7ee-2eeb-4b50-a05e-e3ce1906f90a","","",false, this);
 
            IDCustomerContact = RPSControlFactory.CreateRPSComboBox<MaintenanceContractEntityView>("68f50a78-aa17-4d8b-9a1d-a3065c9663e3","","",false, this);
 
            UIIDPaymentmethodSales = RPSControlFactory.CreateRPSComboBox<MaintenanceContractEntityView>("2e8c33c3-d3c0-4036-8ebd-fb60d4e5fb03","","",false, this);
 
            UIIDPaymentmethodPurchase = RPSControlFactory.CreateRPSComboBox<MaintenanceContractEntityView>("ef3a9480-9f67-44e4-9c60-b123b16470a9","","",false, this);
 
            BillingPeriods = RPSControlFactory.CreateRPSEnumComboBox<MaintenanceContractEntityView>("a8e583b3-29b6-4a92-9165-9fef48b4f548","","",true, this);
 
            UIIDInvoicingTypeSales = RPSControlFactory.CreateRPSComboBox<MaintenanceContractEntityView>("9d55981e-6876-4c17-938e-150bcc72e9f9","","",false, this);
 
            UIIDInvoicingTypePurchase = RPSControlFactory.CreateRPSComboBox<MaintenanceContractEntityView>("79a87d7b-4c9e-4c0d-938a-ee0788a808b1","","",false, this);
 
            LastInvoiceDate = RPSControlFactory.CreateRPSTextBox<MaintenanceContractEntityView>("04d8a86a-7ec3-4ee5-92b5-e0482fd03bc9","","",false, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceContractEntityView>("a8c940fa-7b9e-4ef8-9460-010fcac05746","","",false, this);
 
            FormalizationDate = RPSControlFactory.CreateRPSTextBox<MaintenanceContractEntityView>("2ea374a1-9b2b-41f7-a803-7a4e6e2f5341","","",true, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<MaintenanceContractEntityView>("f3cd0785-b9c9-4411-a4e6-219f1d269b68","","",true, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<MaintenanceContractEntityView>("a66284a4-b9e3-4bee-a3fa-84c5f79580f5","","",true, this);
 
            AutomaticRenovation = RPSControlFactory.CreateRPSCheckBox<MaintenanceContractEntityView>("d51cbd8c-f8b3-4bde-abe4-35db08b53d64","","",true, this);
 
            Canceled = RPSControlFactory.CreateRPSCheckBox<MaintenanceContractEntityView>("6c93bbcc-6c69-4d0e-85e0-78b20088ec7a","","",true, this);
 
            CancellationDate = RPSControlFactory.CreateRPSTextBox<MaintenanceContractEntityView>("0ac2ea70-1d0c-4b77-95c1-3010a9ed1729","","",false, this);
 
            CoverageExtensionText = RPSControlFactory.CreateRPSTextBox<MaintenanceContractEntityView>("b826b695-62c3-45b5-b8f4-c12e7ecd4cf3","","",false, this);
 
            ConditionExtensionText = RPSControlFactory.CreateRPSTextBox<MaintenanceContractEntityView>("c967a97f-66fa-4268-9d85-34ad6f5571af","","",false, this);
 
            PrintMaintenanceContractChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<MaintenanceContractEntityView,PrintMaintenanceContractChildDialogView>("e14e3288-bdb7-461d-bdeb-67b718736529","","", this,Screen.PrintMaintenanceContractChildDialogView);
 
            CollectionInit params_MaintenanceContractContents = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c6c04204-43a8-4428-87a0-b93449c9be66",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceContractContents = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceContractContentsCollectionEditor<MaintenanceContractEntityView,MaintenanceContractContentView>,MaintenanceContractEntityView,MaintenanceContractContentView>( params_MaintenanceContractContents,this,Screen.MaintenanceContractContentView);
 
            CollectionInit params_MaintenanceContractBillingPeriods = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="97646109-fc49-404c-9a2c-cd18b3ea9bed",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceContractBillingPeriods = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceContractBillingPeriodsCollectionEditor<MaintenanceContractEntityView,MaintenanceContractContentView>,MaintenanceContractEntityView,MaintenanceContractContentView>( params_MaintenanceContractBillingPeriods,this,Screen.MaintenanceContractContentView);
 
            General = RPSControlFactory.CreateRPSSection<MaintenanceContractEntityView>( "","ul li[rpsid='aae5fe8c-9124-4b90-9540-3b788de9039c']","",this);
 
            Content = RPSControlFactory.CreateRPSSection<MaintenanceContractEntityView>( "","ul li[rpsid='5130e17b-cc16-4233-ab5b-2b77da782858']","",this);
 
            Billing = RPSControlFactory.CreateRPSSection<MaintenanceContractEntityView>( "","ul li[rpsid='89b2417d-c262-4e8f-a1ff-17b7cdf7530c']","",this);
 

        }
        public IRPSSaveButton<MaintenanceContractEntityView> SaveButton { get; set; } 
        public IRPSButton<MaintenanceContractEntityView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceContractEntityView,MaintenanceContractCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceContractEntityView,MaintenanceContractCollectionView> BackButton { get; set; } 
        public IRPSTextBox<MaintenanceContractEntityView> MaintenanceContractCode { get; set; } 
        public IRPSComboBox<MaintenanceContractEntityView> MaintenanceContractType { get; set; } 
        public IRPSComboBox<MaintenanceContractEntityView> IDSite { get; set; } 
        public IRPSComboBox<MaintenanceContractEntityView> IDSupplier { get; set; } 
        public IRPSComboBox<MaintenanceContractEntityView> IDSupplierContact { get; set; } 
        public IRPSComboBox<MaintenanceContractEntityView> IDCustomer { get; set; } 
        public IRPSComboBox<MaintenanceContractEntityView> IDCustomerContact { get; set; } 
        public IRPSComboBox<MaintenanceContractEntityView> UIIDPaymentmethodSales { get; set; } 
        public IRPSComboBox<MaintenanceContractEntityView> UIIDPaymentmethodPurchase { get; set; } 
        public IRPSComboBox<MaintenanceContractEntityView> BillingPeriods { get; set; } 
        public IRPSComboBox<MaintenanceContractEntityView> UIIDInvoicingTypeSales { get; set; } 
        public IRPSComboBox<MaintenanceContractEntityView> UIIDInvoicingTypePurchase { get; set; } 
        public IRPSTextBox<MaintenanceContractEntityView> LastInvoiceDate { get; set; } 
        public IRPSTextBox<MaintenanceContractEntityView> Amount { get; set; } 
        public IRPSTextBox<MaintenanceContractEntityView> FormalizationDate { get; set; } 
        public IRPSTextBox<MaintenanceContractEntityView> DateFrom { get; set; } 
        public IRPSTextBox<MaintenanceContractEntityView> DateTo { get; set; } 
        public IRPSCheckbox<MaintenanceContractEntityView> AutomaticRenovation { get; set; } 
        public IRPSCheckbox<MaintenanceContractEntityView> Canceled { get; set; } 
        public IRPSTextBox<MaintenanceContractEntityView> CancellationDate { get; set; } 
        public IRPSTextBox<MaintenanceContractEntityView> CoverageExtensionText { get; set; } 
        public IRPSTextBox<MaintenanceContractEntityView> ConditionExtensionText { get; set; } 
        public IRPSButton<MaintenanceContractEntityView,PrintMaintenanceContractChildDialogView> PrintMaintenanceContractChildNavigationCommandButton { get; set; } 
        public MaintenanceContractContentsCollectionEditor<MaintenanceContractEntityView,MaintenanceContractContentView> MaintenanceContractContents { get; set; } 
        public MaintenanceContractBillingPeriodsCollectionEditor<MaintenanceContractEntityView,MaintenanceContractContentView> MaintenanceContractBillingPeriods { get; set; } 
        public IRPSSection<MaintenanceContractEntityView> General { get; set; } 
        public IRPSSection<MaintenanceContractEntityView> Content { get; set; } 
        public IRPSSection<MaintenanceContractEntityView> Billing { get; set; } 
        public MaintenanceContract Screen { get; set; }
        public MaintenanceContractEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaintenanceContractContentsCollectionEditor<MaintenanceContractEntityView,MaintenanceContractContentView>:RPSCollectionEditor<MaintenanceContractEntityView,MaintenanceContractContentView> where MaintenanceContractEntityView : class, IView where MaintenanceContractContentView : class, IView
    {
        public  MaintenanceContractContentsGridView<MaintenanceContractEntityView,MaintenanceContractContentView> GridView {get;set;}
    }
    public partial class MaintenanceContractContentsGridView <MaintenanceContractEntityView,MaintenanceContractContentView> :  RPSGridView<MaintenanceContractEntityView,MaintenanceContractContentView> where MaintenanceContractEntityView : class, IView where MaintenanceContractContentView : class, IView
    {
        public MaintenanceContractContentsGridView(MaintenanceContractEntityView currentView,MaintenanceContractContentView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDMaintenanceComponent = RPSControlFactory.CreateRPSGridComboBox<MaintenanceContractEntityView>("","#c6c04204-43a8-4428-87a0-b93449c9be66 .ag-row[role='row']@ROWINDEX [col-id='cIDMaintenanceComponent']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<MaintenanceContractEntityView> IDMaintenanceComponent { get; set; } 
                     
    }
 
        public partial class MaintenanceContractBillingPeriodsCollectionEditor<MaintenanceContractEntityView,MaintenanceContractContentView>:RPSCollectionEditor<MaintenanceContractEntityView,MaintenanceContractContentView> where MaintenanceContractEntityView : class, IView where MaintenanceContractContentView : class, IView
    {
        public  MaintenanceContractBillingPeriodsGridView<MaintenanceContractEntityView,MaintenanceContractContentView> GridView {get;set;}
    }
    public partial class MaintenanceContractBillingPeriodsGridView <MaintenanceContractEntityView,MaintenanceContractContentView> :  RPSGridView<MaintenanceContractEntityView,MaintenanceContractContentView> where MaintenanceContractEntityView : class, IView where MaintenanceContractContentView : class, IView
    {
        public MaintenanceContractBillingPeriodsGridView(MaintenanceContractEntityView currentView,MaintenanceContractContentView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DateIniPeriod = RPSControlFactory.CreateRPSGridTextBox<MaintenanceContractEntityView>("","#97646109-fc49-404c-9a2c-cd18b3ea9bed .ag-row[role='row']@ROWINDEX [col-id='cDateIniPeriod']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<MaintenanceContractEntityView> DateIniPeriod { get; set; } 
                     
    }
 
    }
  
            
    public partial class MaintenanceContractContentView : View
    {
        public MaintenanceContractContentView(MaintenanceContract screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceContractContentView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceContractContentView,MaintenanceContractEntityView>( this,Screen.MaintenanceContractEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceContractContentView,MaintenanceContractEntityView>( this,Screen.MaintenanceContractEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MaintenanceContractContentView,MaintenanceContractEntityView>( this,Screen.MaintenanceContractEntityView);
 
            IDMaintenanceComponent = RPSControlFactory.CreateRPSComboBox<MaintenanceContractContentView>("f6ff3a31-509e-442f-87ae-462366691667","","",true, this);
 
            CodGuarantee = RPSControlFactory.CreateRPSTextBox<MaintenanceContractContentView>("39e1ee9c-83f3-4d7e-bce4-88049a959507","","",false, this);
 
            GuaranteeExpiration = RPSControlFactory.CreateRPSTextBox<MaintenanceContractContentView>("b5f9ef88-25ca-4f80-bfe5-f0986d059036","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceContractContentView>("1296e107-184f-4e4a-b4df-b329df84b0b3","","",true, this);
 
            Price = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceContractContentView>("875da8a7-399f-4970-b076-cd476ba61d58","","",true, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceContractContentView>("ada2e3f7-c141-4268-9911-3726ddb89d4c","","",true, this);
 
            ApplyDiscounts = RPSControlFactory.CreateRPSCheckBox<MaintenanceContractContentView>("c6fea4ac-1d66-4eb3-8189-493dc3f14d00","","",true, this);
 
            PreventiveMaintenance = RPSControlFactory.CreateRPSEnumComboBox<MaintenanceContractContentView>("dd1ff2bb-5074-4ce7-a1b1-c9c058f60b6c","","",true, this);
 
            PDiscountWithCascade = RPSControlFactory.CreateRPSCheckBox<MaintenanceContractContentView>("9c46fdd2-7f9c-43bb-b699-c89c20a6b963","","",true, this);
 
            PMaterialsPercent = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceContractContentView>("b92a54f9-6d3b-4edc-9b7b-265b5bdaccb8","","",true, this);
 
            PLaborPercent = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceContractContentView>("63e75221-19f1-4adc-8649-138f8a3f3d60","","",true, this);
 
            PResourcesPercent = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceContractContentView>("616b36dc-e98b-479e-80d7-4631b2d98aa4","","",true, this);
 
            PDietsPercent = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceContractContentView>("f1cf6e77-9772-45b1-9c39-4ed99e8965bb","","",true, this);
 
            PExpensesPercent = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceContractContentView>("b3b533fa-5c71-49ef-8951-997cd28d9527","","",true, this);
 
            CorrectiveMaintenance = RPSControlFactory.CreateRPSEnumComboBox<MaintenanceContractContentView>("d0d66ccb-91e2-4358-a9af-3aabb09a9383","","",true, this);
 
            CDiscountWithCascade = RPSControlFactory.CreateRPSCheckBox<MaintenanceContractContentView>("3b2e52d5-beaf-4828-942b-d84a78a867aa","","",true, this);
 
            MaterialsPercent = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceContractContentView>("abc720b4-e881-4fcd-aa6e-3e68c8b583e4","","",true, this);
 
            LaborPercent = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceContractContentView>("dc16d5d4-fa0b-4ef1-be14-4e01e4aefd0a","","",true, this);
 
            ResourcesPercent = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceContractContentView>("1dfd7119-1e7a-4008-9e77-8fd431dd2266","","",true, this);
 
            DietsPercent = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceContractContentView>("1e5b488e-367b-49eb-9af0-dfd458a14690","","",true, this);
 
            ExpensesPercent = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceContractContentView>("8ac286d6-851f-4159-97fa-c6ba82fc0b2a","","",true, this);
 
            LimitOfInterventions = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceContractContentView>("737cc73e-3fca-4bbf-a534-0231bd14cad7","","",false, this);
 
            CurrentInterventions = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceContractContentView>("62d5e5c3-1848-40b8-a321-0a8d2dad5262","","",false, this);
 
            ResponseTimeStoppedComponent = RPSControlFactory.CreateRPSDurationTextBox<MaintenanceContractContentView>("4e0ab8e6-5c1f-40e1-84ff-3d9a63cacb36","","",false, this);
 
            ResponseTimeNonStoppedComponent = RPSControlFactory.CreateRPSDurationTextBox<MaintenanceContractContentView>("da5d558f-934f-413d-8b1c-979de02103fe","","",false, this);
 
            PlanResourcesCalculationsCommandButton = RPSControlFactory.CreateRPSButton<MaintenanceContractContentView>( "8e0a2569-1fd7-4142-936d-81be4d639fb7","","",this);
 
            CollectionInit params_MaintenanceContractAssistancePlans = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="aec05a27-efaf-4d9e-8e09-cfd385a7b5fc",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceContractAssistancePlans = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceContractAssistancePlansCollectionEditor<MaintenanceContractContentView,MaintenanceContractContentAssistancePlanView>,MaintenanceContractContentView,MaintenanceContractContentAssistancePlanView>( params_MaintenanceContractAssistancePlans,this,Screen.MaintenanceContractContentAssistancePlanView);
 
            General = RPSControlFactory.CreateRPSSection<MaintenanceContractContentView>( "","ul li[rpsid='21f65b93-ae18-42fe-becf-31e6ffef5758']","",this);
 
            ProgrammedMaintenance = RPSControlFactory.CreateRPSSection<MaintenanceContractContentView>( "","ul li[rpsid='5e2f8671-7a96-4c93-8daa-3c3df982d46f']","",this);
 

        }
        public IRPSButton<MaintenanceContractContentView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceContractContentView,MaintenanceContractEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceContractContentView,MaintenanceContractEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<MaintenanceContractContentView,MaintenanceContractEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<MaintenanceContractContentView> IDMaintenanceComponent { get; set; } 
        public IRPSTextBox<MaintenanceContractContentView> CodGuarantee { get; set; } 
        public IRPSTextBox<MaintenanceContractContentView> GuaranteeExpiration { get; set; } 
        public IRPSTextBox<MaintenanceContractContentView> Quantity { get; set; } 
        public IRPSTextBox<MaintenanceContractContentView> Price { get; set; } 
        public IRPSTextBox<MaintenanceContractContentView> Amount { get; set; } 
        public IRPSCheckbox<MaintenanceContractContentView> ApplyDiscounts { get; set; } 
        public IRPSComboBox<MaintenanceContractContentView> PreventiveMaintenance { get; set; } 
        public IRPSCheckbox<MaintenanceContractContentView> PDiscountWithCascade { get; set; } 
        public IRPSTextBox<MaintenanceContractContentView> PMaterialsPercent { get; set; } 
        public IRPSTextBox<MaintenanceContractContentView> PLaborPercent { get; set; } 
        public IRPSTextBox<MaintenanceContractContentView> PResourcesPercent { get; set; } 
        public IRPSTextBox<MaintenanceContractContentView> PDietsPercent { get; set; } 
        public IRPSTextBox<MaintenanceContractContentView> PExpensesPercent { get; set; } 
        public IRPSComboBox<MaintenanceContractContentView> CorrectiveMaintenance { get; set; } 
        public IRPSCheckbox<MaintenanceContractContentView> CDiscountWithCascade { get; set; } 
        public IRPSTextBox<MaintenanceContractContentView> MaterialsPercent { get; set; } 
        public IRPSTextBox<MaintenanceContractContentView> LaborPercent { get; set; } 
        public IRPSTextBox<MaintenanceContractContentView> ResourcesPercent { get; set; } 
        public IRPSTextBox<MaintenanceContractContentView> DietsPercent { get; set; } 
        public IRPSTextBox<MaintenanceContractContentView> ExpensesPercent { get; set; } 
        public IRPSTextBox<MaintenanceContractContentView> LimitOfInterventions { get; set; } 
        public IRPSTextBox<MaintenanceContractContentView> CurrentInterventions { get; set; } 
        public IRPSDurationTextBox<MaintenanceContractContentView> ResponseTimeStoppedComponent { get; set; } 
        public IRPSDurationTextBox<MaintenanceContractContentView> ResponseTimeNonStoppedComponent { get; set; } 
        public IRPSButton<MaintenanceContractContentView> PlanResourcesCalculationsCommandButton { get; set; } 
        public MaintenanceContractAssistancePlansCollectionEditor<MaintenanceContractContentView,MaintenanceContractContentAssistancePlanView> MaintenanceContractAssistancePlans { get; set; } 
        public IRPSSection<MaintenanceContractContentView> General { get; set; } 
        public IRPSSection<MaintenanceContractContentView> ProgrammedMaintenance { get; set; } 
        public MaintenanceContract Screen { get; set; }
        public MaintenanceContractContentView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaintenanceContractAssistancePlansCollectionEditor<MaintenanceContractContentView,MaintenanceContractContentAssistancePlanView>:RPSCollectionEditor<MaintenanceContractContentView,MaintenanceContractContentAssistancePlanView> where MaintenanceContractContentView : class, IView where MaintenanceContractContentAssistancePlanView : class, IView
    {
        public  MaintenanceContractAssistancePlansGridView<MaintenanceContractContentView,MaintenanceContractContentAssistancePlanView> GridView {get;set;}
    }
    public partial class MaintenanceContractAssistancePlansGridView <MaintenanceContractContentView,MaintenanceContractContentAssistancePlanView> :  RPSGridView<MaintenanceContractContentView,MaintenanceContractContentAssistancePlanView> where MaintenanceContractContentView : class, IView where MaintenanceContractContentAssistancePlanView : class, IView
    {
        public MaintenanceContractAssistancePlansGridView(MaintenanceContractContentView currentView,MaintenanceContractContentAssistancePlanView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDMaintenancePlan = RPSControlFactory.CreateRPSGridComboBox<MaintenanceContractContentView>("","#aec05a27-efaf-4d9e-8e09-cfd385a7b5fc .ag-row[role='row']@ROWINDEX [col-id='cIDMaintenancePlan']","",true, this.CurrentView);
 
            Comments = RPSControlFactory.CreateRPSGridMemoTextBox<MaintenanceContractContentView>("","#aec05a27-efaf-4d9e-8e09-cfd385a7b5fc .ag-row[role='row']@ROWINDEX [col-id='cComments']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<MaintenanceContractContentView> IDMaintenancePlan { get; set; } 
        public IRPSGridTextBox<MaintenanceContractContentView> Comments { get; set; } 
                     
    }
 
    }
  
            
    public partial class MaintenanceContractBillingPeriodView : View
    {
        public MaintenanceContractBillingPeriodView(MaintenanceContract screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceContractBillingPeriodView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceContractBillingPeriodView,MaintenanceContractEntityView>( this,Screen.MaintenanceContractEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceContractBillingPeriodView,MaintenanceContractEntityView>( this,Screen.MaintenanceContractEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MaintenanceContractBillingPeriodView,MaintenanceContractEntityView>( this,Screen.MaintenanceContractEntityView);
 
            DateIniPeriod = RPSControlFactory.CreateRPSTextBox<MaintenanceContractBillingPeriodView>("18d0f2dc-4059-4b5f-ba9e-66f8cc50d58c","","",true, this);
 

        }
        public IRPSButton<MaintenanceContractBillingPeriodView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceContractBillingPeriodView,MaintenanceContractEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceContractBillingPeriodView,MaintenanceContractEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<MaintenanceContractBillingPeriodView,MaintenanceContractEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<MaintenanceContractBillingPeriodView> DateIniPeriod { get; set; } 
        public MaintenanceContract Screen { get; set; }
        public MaintenanceContractBillingPeriodView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenanceContractContentPlanResourcesCalculationsDialogView : View
    {
        public MaintenanceContractContentPlanResourcesCalculationsDialogView(MaintenanceContract screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UITotalAmount = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceContractContentPlanResourcesCalculationsDialogView>("cc2ed0ed-18aa-408c-8a1f-170e785febb8","","",false, this);
 
            AcceptCommand = RPSControlFactory.CreateRPSButton<MaintenanceContractContentPlanResourcesCalculationsDialogView>( "59388d1a-4676-4c7a-b152-4e4b2e38d006","","",this);
 
            RecalculateCosts = RPSControlFactory.CreateRPSButton<MaintenanceContractContentPlanResourcesCalculationsDialogView>( "b982e742-9e75-49b3-830a-4cf8674fb9a4","","",this);
 
            UpdatePlanContractPrices = RPSControlFactory.CreateRPSButton<MaintenanceContractContentPlanResourcesCalculationsDialogView>( "9aea4b62-a3f8-4458-b414-d230186edb57","","",this);
 
            CollectionInit params_MaintenancePlanResourcesForContractCalculations = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="9743111b-acdd-409f-ba57-f6d83ef4625d",CSSSelectorGrid="",XPathGrid=""};
            MaintenancePlanResourcesForContractCalculations = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenancePlanResourcesForContractCalculationsCollectionEditor<MaintenanceContractContentPlanResourcesCalculationsDialogView>,MaintenanceContractContentPlanResourcesCalculationsDialogView>( params_MaintenancePlanResourcesForContractCalculations,this);
 

        }
        public IRPSTextBox<MaintenanceContractContentPlanResourcesCalculationsDialogView> UITotalAmount { get; set; } 
        public IRPSButton<MaintenanceContractContentPlanResourcesCalculationsDialogView> AcceptCommand { get; set; } 
        public IRPSButton<MaintenanceContractContentPlanResourcesCalculationsDialogView> RecalculateCosts { get; set; } 
        public IRPSButton<MaintenanceContractContentPlanResourcesCalculationsDialogView> UpdatePlanContractPrices { get; set; } 
        public MaintenancePlanResourcesForContractCalculationsCollectionEditor<MaintenanceContractContentPlanResourcesCalculationsDialogView> MaintenancePlanResourcesForContractCalculations { get; set; } 
        public MaintenanceContract Screen { get; set; }
        public MaintenanceContractContentPlanResourcesCalculationsDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaintenancePlanResourcesForContractCalculationsCollectionEditor<MaintenanceContractContentPlanResourcesCalculationsDialogView>:RPSCollectionEditor<MaintenanceContractContentPlanResourcesCalculationsDialogView> where MaintenanceContractContentPlanResourcesCalculationsDialogView : class, IView
    {
        public  MaintenancePlanResourcesForContractCalculationsGridView<MaintenanceContractContentPlanResourcesCalculationsDialogView> GridView {get;set;}
    }
    public partial class MaintenancePlanResourcesForContractCalculationsGridView <MaintenanceContractContentPlanResourcesCalculationsDialogView> :  RPSGridView<MaintenanceContractContentPlanResourcesCalculationsDialogView> where MaintenanceContractContentPlanResourcesCalculationsDialogView : class, IView
    {
        public MaintenancePlanResourcesForContractCalculationsGridView(MaintenanceContractContentPlanResourcesCalculationsDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MaintenancePlanCode = RPSControlFactory.CreateRPSGridTextBox<MaintenanceContractContentPlanResourcesCalculationsDialogView>("","#9743111b-acdd-409f-ba57-f6d83ef4625d .ag-row[role='row']@ROWINDEX [col-id='cMaintenancePlanCode']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenanceContractContentPlanResourcesCalculationsDialogView>("","#9743111b-acdd-409f-ba57-f6d83ef4625d .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            NumberOfVisits = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenanceContractContentPlanResourcesCalculationsDialogView>("","#9743111b-acdd-409f-ba57-f6d83ef4625d .ag-row[role='row']@ROWINDEX [col-id='cNumberOfVisits']","",false, this.CurrentView);
 
            CostPrice = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenanceContractContentPlanResourcesCalculationsDialogView>("","#9743111b-acdd-409f-ba57-f6d83ef4625d .ag-row[role='row']@ROWINDEX [col-id='cCostPrice']","",false, this.CurrentView);
 
            Margin = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenanceContractContentPlanResourcesCalculationsDialogView>("","#9743111b-acdd-409f-ba57-f6d83ef4625d .ag-row[role='row']@ROWINDEX [col-id='cMargin']","",false, this.CurrentView);
 
            SalePrice = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenanceContractContentPlanResourcesCalculationsDialogView>("","#9743111b-acdd-409f-ba57-f6d83ef4625d .ag-row[role='row']@ROWINDEX [col-id='cSalePrice']","",false, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenanceContractContentPlanResourcesCalculationsDialogView>("","#9743111b-acdd-409f-ba57-f6d83ef4625d .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MaintenanceContractContentPlanResourcesCalculationsDialogView> MaintenancePlanCode { get; set; } 
        public IRPSGridTextBox<MaintenanceContractContentPlanResourcesCalculationsDialogView> Quantity { get; set; } 
        public IRPSGridTextBox<MaintenanceContractContentPlanResourcesCalculationsDialogView> NumberOfVisits { get; set; } 
        public IRPSGridTextBox<MaintenanceContractContentPlanResourcesCalculationsDialogView> CostPrice { get; set; } 
        public IRPSGridTextBox<MaintenanceContractContentPlanResourcesCalculationsDialogView> Margin { get; set; } 
        public IRPSGridTextBox<MaintenanceContractContentPlanResourcesCalculationsDialogView> SalePrice { get; set; } 
        public IRPSGridTextBox<MaintenanceContractContentPlanResourcesCalculationsDialogView> Amount { get; set; } 
                     
    }
 
    }
  
            
    public partial class MaintenanceContractContentAssistancePlanView : View
    {
        public MaintenanceContractContentAssistancePlanView(MaintenanceContract screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceContractContentAssistancePlanView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceContractContentAssistancePlanView,MaintenanceContractContentView>( this,Screen.MaintenanceContractContentView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceContractContentAssistancePlanView,MaintenanceContractContentView>( this,Screen.MaintenanceContractContentView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MaintenanceContractContentAssistancePlanView,MaintenanceContractContentView>( this,Screen.MaintenanceContractContentView);
 
            IDMaintenancePlan = RPSControlFactory.CreateRPSComboBox<MaintenanceContractContentAssistancePlanView>("4a451b66-1e5a-4569-ac16-6f3061ba82df","","",true, this);
 
            Comments = RPSControlFactory.CreateRPSTextBox<MaintenanceContractContentAssistancePlanView>("aaef11c6-99a0-4f14-abdb-c59fdc89d8a1","","",false, this);
 

        }
        public IRPSButton<MaintenanceContractContentAssistancePlanView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceContractContentAssistancePlanView,MaintenanceContractContentView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceContractContentAssistancePlanView,MaintenanceContractContentView> BackButton { get; set; } 
        public IRPSAcceptButton<MaintenanceContractContentAssistancePlanView,MaintenanceContractContentView> AcceptButton { get; set; } 
        public IRPSComboBox<MaintenanceContractContentAssistancePlanView> IDMaintenancePlan { get; set; } 
        public IRPSTextBox<MaintenanceContractContentAssistancePlanView> Comments { get; set; } 
        public MaintenanceContract Screen { get; set; }
        public MaintenanceContractContentAssistancePlanView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PrintMaintenanceContractChildDialogView : View
    {
        public PrintMaintenanceContractChildDialogView(MaintenanceContract screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDLanguage = RPSControlFactory.CreateRPSComboBox<PrintMaintenanceContractChildDialogView>("2d269804-9df1-4036-86f6-05a3e1739e83","","",false, this);
 
            IDCustomReport = RPSControlFactory.CreateRPSComboBox<PrintMaintenanceContractChildDialogView>("70e50538-3731-4c77-9373-a51ecb369db1","","",false, this);
 
            NumberOfCopies = RPSControlFactory.CreateRPSFormattedTextBox<PrintMaintenanceContractChildDialogView>("dfe7d08e-5c2c-4551-a720-dc1bcb073790","","",false, this);
 
            PrintMaintenanceContractReportCommandButton = RPSControlFactory.CreateRPSButton<PrintMaintenanceContractChildDialogView>( "812e0913-c7f8-4d08-a6d3-9d72de72a892","","",this);
 
            ExecuteSendMaintenanceContractByEmailButton = RPSControlFactory.CreateRPSButton<PrintMaintenanceContractChildDialogView>( "f1884530-2dc3-42c1-adae-84dcd7b0e548","","",this);
 
            SendMaintenanceContractToThirdReportCommandButton = RPSControlFactory.CreateRPSButton<PrintMaintenanceContractChildDialogView>( "869fcc9e-f152-4038-be3f-67a6d58c424c","","",this);
 

        }
        public IRPSComboBox<PrintMaintenanceContractChildDialogView> IDLanguage { get; set; } 
        public IRPSComboBox<PrintMaintenanceContractChildDialogView> IDCustomReport { get; set; } 
        public IRPSTextBox<PrintMaintenanceContractChildDialogView> NumberOfCopies { get; set; } 
        public IRPSButton<PrintMaintenanceContractChildDialogView> PrintMaintenanceContractReportCommandButton { get; set; } 
        public IRPSButton<PrintMaintenanceContractChildDialogView> ExecuteSendMaintenanceContractByEmailButton { get; set; } 
        public IRPSButton<PrintMaintenanceContractChildDialogView> SendMaintenanceContractToThirdReportCommandButton { get; set; } 
        public MaintenanceContract Screen { get; set; }
        public PrintMaintenanceContractChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}