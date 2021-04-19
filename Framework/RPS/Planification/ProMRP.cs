    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Planification.ProMRP
{
    //RPS VERSION 1.0.0.0
    public partial class ProMRP:Screen
    {
        public ProMRP():base()
        {
            this.URL = "planification.promrp";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ProMRPView  = new ProMRPView(this); 
            ImportToXMLDialogView  = new ImportToXMLDialogView(this); 
            GeneratedMOTaskView  = new GeneratedMOTaskView(this); 
            GeneratedMOMaterialView  = new GeneratedMOMaterialView(this); 
            MRPLogDialogView  = new MRPLogDialogView(this); 
            ProMRPPrintViewModelDialogView  = new ProMRPPrintViewModelDialogView(this); 
            ProMRPBloquedArticlesDialogView  = new ProMRPBloquedArticlesDialogView(this); 
            ProMRPRegenerativeDeleteDialogView  = new ProMRPRegenerativeDeleteDialogView(this); 
            MOPurchaseProposalsLinkedDialogView  = new MOPurchaseProposalsLinkedDialogView(this); 
            ProMRPView.InitializeControls(); 
            ImportToXMLDialogView.InitializeControls(); 
            GeneratedMOTaskView.InitializeControls(); 
            GeneratedMOMaterialView.InitializeControls(); 
            MRPLogDialogView.InitializeControls(); 
            ProMRPPrintViewModelDialogView.InitializeControls(); 
            ProMRPBloquedArticlesDialogView.InitializeControls(); 
            ProMRPRegenerativeDeleteDialogView.InitializeControls(); 
            MOPurchaseProposalsLinkedDialogView.InitializeControls(); 
           
        }
      
            public ProMRPView ProMRPView {get; set; } 
            public ImportToXMLDialogView ImportToXMLDialogView {get; set; } 
            public GeneratedMOTaskView GeneratedMOTaskView {get; set; } 
            public GeneratedMOMaterialView GeneratedMOMaterialView {get; set; } 
            public MRPLogDialogView MRPLogDialogView {get; set; } 
            public ProMRPPrintViewModelDialogView ProMRPPrintViewModelDialogView {get; set; } 
            public ProMRPBloquedArticlesDialogView ProMRPBloquedArticlesDialogView {get; set; } 
            public ProMRPRegenerativeDeleteDialogView ProMRPRegenerativeDeleteDialogView {get; set; } 
            public MOPurchaseProposalsLinkedDialogView MOPurchaseProposalsLinkedDialogView {get; set; } 
    }
            
    public partial class ProMRPView : View
    {
        public ProMRPView(ProMRP screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UISite = RPSControlFactory.CreateRPSComboBox<ProMRPView>("ffd0c939-a2d4-4edc-8be7-7367a0f44f7e","","",true, this);
 
            UIStartDate = RPSControlFactory.CreateRPSTextBox<ProMRPView>("edf76c5d-721a-45b5-a81d-c426e06a0e98","","",false, this);
 
            UIEndDate = RPSControlFactory.CreateRPSTextBox<ProMRPView>("a04ac271-3588-42f3-97ec-3ce9f2632495","","",false, this);
 
            UIParamScene = RPSControlFactory.CreateRPSComboBox<ProMRPView>("b6f7cf2f-3536-4bc0-abb5-755e850db96c","","",false, this);
 
            UIArticles = RPSControlFactory.CreateRPSOption<ProMRPView>( "8fe59a8e-e450-44cc-9629-d69f35fea32c","","",this);
 
            UIPreselectedArticles = RPSControlFactory.CreateRPSOption<ProMRPView>( "a85abd16-abad-4bbe-8245-41cf4b128cea","","",this);
 
            UIManufacturingPrevisions = RPSControlFactory.CreateRPSOption<ProMRPView>( "a2c906b4-30ef-4e13-bb31-ce73341b1c82","","",this);
 
            UIOrderSales = RPSControlFactory.CreateRPSOption<ProMRPView>( "b949592f-b154-49a1-8ffa-9bf61032ae7e","","",this);
 
            UIProjects = RPSControlFactory.CreateRPSOption<ProMRPView>( "ab7b2b56-2449-425a-a26e-ced9670dbded","","",this);
 
            UILstArticle = RPSControlFactory.CreateRPSCollectionComboBox<ProMRPView>("ce83fe9c-c180-4624-964e-71ba84695754","","",false, this);
 
            UILstManufacturingPrevision = RPSControlFactory.CreateRPSCollectionComboBox<ProMRPView>("319b8223-34d4-4683-92ce-4815930f73fa","","",false, this);
 
            UILstProject = RPSControlFactory.CreateRPSCollectionComboBox<ProMRPView>("350733f3-5fc1-4c97-aa4d-226e57855c2a","","",false, this);
 
            UILstMRPArticleSelection = RPSControlFactory.CreateRPSCollectionComboBox<ProMRPView>("1a99ed6e-f6bc-4499-9fb9-6508223b4b86","","",false, this);
 
            UILstOrderSL = RPSControlFactory.CreateRPSCollectionComboBox<ProMRPView>("79fa94b9-e7da-4367-9454-529ac1b42cac","","",false, this);
 
            UIParamNotPurchaseArticle = RPSControlFactory.CreateRPSCheckBox<ProMRPView>("5cd90427-985d-4ce8-8b6c-7f515b5b60d8","","",false, this);
 
            UIParamNotArticlesOthers = RPSControlFactory.CreateRPSCheckBox<ProMRPView>("58a9c503-2b60-4489-9cd0-192265dae8b8","","",false, this);
 
            UIParamHandleArticlesWithoutStockControl = RPSControlFactory.CreateRPSCheckBox<ProMRPView>("8d06ab92-e739-4c32-a9c9-d31331929e60","","",false, this);
 
            eArticlesType34Treatment = RPSControlFactory.CreateRPSEnumComboBox<ProMRPView>("275da5ca-9291-49e0-aca3-9ca8f5cc7785","","",false, this);
 
            UIParamRoute = RPSControlFactory.CreateRPSComboBox<ProMRPView>("0fb5cbdf-443e-4346-b965-c2bda3922e12","","",false, this);
 
            UIParamPropagateRoute = RPSControlFactory.CreateRPSCheckBox<ProMRPView>("f9bcf9fa-a6e6-442d-81a7-f2cd495a1bd5","","",false, this);
 
            UIParamUseMainPath = RPSControlFactory.CreateRPSCheckBox<ProMRPView>("4c815804-3743-45b4-ba0e-dc742a9b2ba5","","",false, this);
 
            UIParamLaunchLot = RPSControlFactory.CreateRPSCheckBox<ProMRPView>("1607ca98-50ee-4ed3-9b0f-28e3f0d4353d","","",false, this);
 
            UIParamNotOverStock = RPSControlFactory.CreateRPSCheckBox<ProMRPView>("f5b2d631-aa3c-4a97-a46d-e59247b1514f","","",false, this);
 
            UIParamNotStock = RPSControlFactory.CreateRPSCheckBox<ProMRPView>("be711eda-eade-42ba-b23e-d52e04a2b241","","",false, this);
 
            UIParamNotNegativeStock = RPSControlFactory.CreateRPSCheckBox<ProMRPView>("f2e73242-4bfb-432c-89ce-1b20b54ccb71","","",false, this);
 
            UIParamNotMinimumAvailability = RPSControlFactory.CreateRPSCheckBox<ProMRPView>("b10326f1-c11e-4b0c-a9ef-aaf3a614e9c7","","",false, this);
 
            UIUseMO = RPSControlFactory.CreateRPSCheckBox<ProMRPView>("d4387774-a198-4081-ada8-74b79f068609","","",false, this);
 
            UIUsePurchase = RPSControlFactory.CreateRPSCheckBox<ProMRPView>("8f29c989-b6c9-4787-8b17-c68138d220c3","","",false, this);
 
            UIUseSales = RPSControlFactory.CreateRPSCheckBox<ProMRPView>("72a74096-4c2d-4736-8761-ec7c65452980","","",false, this);
 
            UIUseManPrevision = RPSControlFactory.CreateRPSCheckBox<ProMRPView>("e5f03641-8210-4d11-990d-29afcc8b5198","","",false, this);
 
            UIUseMaintenance = RPSControlFactory.CreateRPSCheckBox<ProMRPView>("cb42ecfd-1a09-40e2-968a-df30066ebfe1","","",false, this);
 
            UIUseProjectMaterials = RPSControlFactory.CreateRPSCheckBox<ProMRPView>("5ffe9907-90d3-4f10-974e-3665f732491d","","",false, this);
 
            UIUseSalPrevision = RPSControlFactory.CreateRPSCheckBox<ProMRPView>("e331f2ad-4359-4a5b-877b-910cca267ff4","","",false, this);
 
            UIUseConsumePrevision = RPSControlFactory.CreateRPSCheckBox<ProMRPView>("67c860de-365b-4f04-bfd4-46eb55b2217b","","",false, this);
 
            UIPrevisionDateFrom = RPSControlFactory.CreateRPSTextBox<ProMRPView>("d005c5f5-6463-40d1-aac2-060175d55e28","","",false, this);
 
            UIPrevisionDateTo = RPSControlFactory.CreateRPSTextBox<ProMRPView>("463de32d-9770-4d6b-9151-6672395e971b","","",false, this);
 
            UIUseDelPlanPurchase = RPSControlFactory.CreateRPSCheckBox<ProMRPView>("8a91540c-67ad-4198-ae2b-92827b890385","","",false, this);
 
            UIUseDelPlanSales = RPSControlFactory.CreateRPSCheckBox<ProMRPView>("a698dfee-7597-49b5-b743-13a567833db3","","",false, this);
 
            UIParamRegenerative = RPSControlFactory.CreateRPSCheckBox<ProMRPView>("3e1af922-4694-4ad0-b95d-7f903808fc27","","",false, this);
 
            UIParamExecuteByLevels = RPSControlFactory.CreateRPSCheckBox<ProMRPView>("55369c76-2f7b-41c4-b0f6-dbe998811437","","",false, this);
 
            UIParamUseDependencies = RPSControlFactory.CreateRPSCheckBox<ProMRPView>("49f4d784-1be0-4dc3-840f-8d2c76f04eaf","","",false, this);
 
            UIOptAdjustToDeliveryDate = RPSControlFactory.CreateRPSOption<ProMRPView>( "b685d183-2f9d-4da7-bfc7-85e8a5c9c9c9","","",this);
 
            UIOptAdjustToInitialDateByLevel = RPSControlFactory.CreateRPSOption<ProMRPView>( "7aacf450-1725-4cfb-90d4-09cd10e0b243","","",this);
 
            UIOptNotPlanify = RPSControlFactory.CreateRPSOption<ProMRPView>( "f2525644-fa82-4ffa-bd39-13df68651ed9","","",this);
 
            UIParamPlanningStartDate = RPSControlFactory.CreateRPSTextBox<ProMRPView>("f89adda8-db1b-452d-8676-2fa2945dfff5","","",false, this);
 
            UIParamPlanningDirection = RPSControlFactory.CreateRPSCheckBox<ProMRPView>("ec94435f-dfee-4124-bf38-e59c7d4ec9a4","","",false, this);
 
            UILog = RPSControlFactory.CreateRPSCheckBox<ProMRPView>("89ea6329-6ccb-4869-b664-16b70d40fd45","","",false, this);
 
            UILogLaunched = RPSControlFactory.CreateRPSCheckBox<ProMRPView>("14e09c92-6d66-4f9d-bf12-d66ae6b06c75","","",false, this);
 
            UILogNotLaunched = RPSControlFactory.CreateRPSCheckBox<ProMRPView>("46e40743-c2d2-4b5c-b4e3-1efe42f15d78","","",false, this);
 
            UILogDetailed = RPSControlFactory.CreateRPSCheckBox<ProMRPView>("70f95616-6a51-479d-a624-9f69e2906f35","","",false, this);
 
            GenerateMRPCommand = RPSControlFactory.CreateRPSButton<ProMRPView>( "da041085-840b-4b78-8aa6-ee33ca0f0785","","",this);
 
            GenerateLevelMRPCommand = RPSControlFactory.CreateRPSButton<ProMRPView>( "71dc163a-48cb-4fb8-8504-55a1a11dca26","","",this);
 
            GenerateMaxLevelMRPCommand = RPSControlFactory.CreateRPSButton<ProMRPView>( "e4b4b4c9-14d7-448a-ba9b-7a544394cb94","","",this);
 
            UICurrentLevel = RPSControlFactory.CreateRPSFormattedTextBox<ProMRPView>("54db5871-b807-49d6-95af-6a028ef590f9","","",false, this);
 
            SaveMRPResultsCommandButton = RPSControlFactory.CreateRPSButton<ProMRPView>( "2a33661e-d760-4a6c-b0e5-69a2708e9734","","",this);
 
            ImportToXMLNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ProMRPView,ImportToXMLDialogView>("dfc1ceda-5a98-4fe7-a2a7-e5a230ac124e","","", this,Screen.ImportToXMLDialogView);
 
            ExportToXMLCommandButton = RPSControlFactory.CreateRPSButton<ProMRPView>( "c5cffecf-bb6e-4a5e-87f6-43b7bc9e6f80","","",this);
 
            MRPLogNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ProMRPView,MRPLogDialogView>("d802da20-b80a-4b1f-af74-7812de09b504","","", this,Screen.MRPLogDialogView);
 
            ExecuteResetScreenDefaultValuesButton = RPSControlFactory.CreateRPSButton<ProMRPView>( "003017fd-b28f-42a0-8b4b-822aeb6ad326","","",this);
 
            ExecuteSaveScreenDefaultValuesButton = RPSControlFactory.CreateRPSButton<ProMRPView>( "290013d5-02c7-4f77-bd1a-a21a66328d2c","","",this);
 
            ProMRPPrintViewModelNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ProMRPView,ProMRPPrintViewModelDialogView>("fa81a8f2-6eb8-41ed-9452-c6fc078ccf52","","", this,Screen.ProMRPPrintViewModelDialogView);
 
            CollectionInit params_GetGeneratedMRPMOData = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="975913ea-ba8c-475b-9ebb-4787c27f865c",CSSSelectorGrid="",XPathGrid=""};
            GetGeneratedMRPMOData = RPSControlFactory.RPSCreateCollectionWithGrid<GetGeneratedMRPMODataCollectionEditor<ProMRPView,ImportToXMLDialogView>,ProMRPView,ImportToXMLDialogView>( params_GetGeneratedMRPMOData,this,Screen.ImportToXMLDialogView);
 
            CollectionInit params_GetGeneratedMRPPurchaseProposalData = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="cc4c7d3d-712c-4db8-a0fb-2a53aafc755b",CSSSelectorGrid="",XPathGrid=""};
            GetGeneratedMRPPurchaseProposalData = RPSControlFactory.RPSCreateCollectionWithGrid<GetGeneratedMRPPurchaseProposalDataCollectionEditor<ProMRPView,ImportToXMLDialogView>,ProMRPView,ImportToXMLDialogView>( params_GetGeneratedMRPPurchaseProposalData,this,Screen.ImportToXMLDialogView);
 
            Section = RPSControlFactory.CreateRPSSection<ProMRPView>( "","ul li[rpsid='d9442145-1c36-452e-922c-07d3d1c6570e']","",this);
 
            ManufacturingOrders = RPSControlFactory.CreateRPSSection<ProMRPView>( "","ul li[rpsid='ee7cc134-a642-4e31-8bf6-a591bd0912f6']","",this);
 
            PurchaseProposals = RPSControlFactory.CreateRPSSection<ProMRPView>( "","ul li[rpsid='69a342d1-e771-4a6c-a55b-0684f22b2745']","",this);
 

        }
        public IRPSComboBox<ProMRPView> UISite { get; set; } 
        public IRPSTextBox<ProMRPView> UIStartDate { get; set; } 
        public IRPSTextBox<ProMRPView> UIEndDate { get; set; } 
        public IRPSComboBox<ProMRPView> UIParamScene { get; set; } 
        public IRPSOption<ProMRPView> UIArticles { get; set; } 
        public IRPSOption<ProMRPView> UIPreselectedArticles { get; set; } 
        public IRPSOption<ProMRPView> UIManufacturingPrevisions { get; set; } 
        public IRPSOption<ProMRPView> UIOrderSales { get; set; } 
        public IRPSOption<ProMRPView> UIProjects { get; set; } 
        public IRPSCollectionComboBox<ProMRPView> UILstArticle { get; set; } 
        public IRPSCollectionComboBox<ProMRPView> UILstManufacturingPrevision { get; set; } 
        public IRPSCollectionComboBox<ProMRPView> UILstProject { get; set; } 
        public IRPSCollectionComboBox<ProMRPView> UILstMRPArticleSelection { get; set; } 
        public IRPSCollectionComboBox<ProMRPView> UILstOrderSL { get; set; } 
        public IRPSCheckbox<ProMRPView> UIParamNotPurchaseArticle { get; set; } 
        public IRPSCheckbox<ProMRPView> UIParamNotArticlesOthers { get; set; } 
        public IRPSCheckbox<ProMRPView> UIParamHandleArticlesWithoutStockControl { get; set; } 
        public IRPSComboBox<ProMRPView> eArticlesType34Treatment { get; set; } 
        public IRPSComboBox<ProMRPView> UIParamRoute { get; set; } 
        public IRPSCheckbox<ProMRPView> UIParamPropagateRoute { get; set; } 
        public IRPSCheckbox<ProMRPView> UIParamUseMainPath { get; set; } 
        public IRPSCheckbox<ProMRPView> UIParamLaunchLot { get; set; } 
        public IRPSCheckbox<ProMRPView> UIParamNotOverStock { get; set; } 
        public IRPSCheckbox<ProMRPView> UIParamNotStock { get; set; } 
        public IRPSCheckbox<ProMRPView> UIParamNotNegativeStock { get; set; } 
        public IRPSCheckbox<ProMRPView> UIParamNotMinimumAvailability { get; set; } 
        public IRPSCheckbox<ProMRPView> UIUseMO { get; set; } 
        public IRPSCheckbox<ProMRPView> UIUsePurchase { get; set; } 
        public IRPSCheckbox<ProMRPView> UIUseSales { get; set; } 
        public IRPSCheckbox<ProMRPView> UIUseManPrevision { get; set; } 
        public IRPSCheckbox<ProMRPView> UIUseMaintenance { get; set; } 
        public IRPSCheckbox<ProMRPView> UIUseProjectMaterials { get; set; } 
        public IRPSCheckbox<ProMRPView> UIUseSalPrevision { get; set; } 
        public IRPSCheckbox<ProMRPView> UIUseConsumePrevision { get; set; } 
        public IRPSTextBox<ProMRPView> UIPrevisionDateFrom { get; set; } 
        public IRPSTextBox<ProMRPView> UIPrevisionDateTo { get; set; } 
        public IRPSCheckbox<ProMRPView> UIUseDelPlanPurchase { get; set; } 
        public IRPSCheckbox<ProMRPView> UIUseDelPlanSales { get; set; } 
        public IRPSCheckbox<ProMRPView> UIParamRegenerative { get; set; } 
        public IRPSCheckbox<ProMRPView> UIParamExecuteByLevels { get; set; } 
        public IRPSCheckbox<ProMRPView> UIParamUseDependencies { get; set; } 
        public IRPSOption<ProMRPView> UIOptAdjustToDeliveryDate { get; set; } 
        public IRPSOption<ProMRPView> UIOptAdjustToInitialDateByLevel { get; set; } 
        public IRPSOption<ProMRPView> UIOptNotPlanify { get; set; } 
        public IRPSTextBox<ProMRPView> UIParamPlanningStartDate { get; set; } 
        public IRPSCheckbox<ProMRPView> UIParamPlanningDirection { get; set; } 
        public IRPSCheckbox<ProMRPView> UILog { get; set; } 
        public IRPSCheckbox<ProMRPView> UILogLaunched { get; set; } 
        public IRPSCheckbox<ProMRPView> UILogNotLaunched { get; set; } 
        public IRPSCheckbox<ProMRPView> UILogDetailed { get; set; } 
        public IRPSButton<ProMRPView> GenerateMRPCommand { get; set; } 
        public IRPSButton<ProMRPView> GenerateLevelMRPCommand { get; set; } 
        public IRPSButton<ProMRPView> GenerateMaxLevelMRPCommand { get; set; } 
        public IRPSTextBox<ProMRPView> UICurrentLevel { get; set; } 
        public IRPSButton<ProMRPView> SaveMRPResultsCommandButton { get; set; } 
        public IRPSButton<ProMRPView,ImportToXMLDialogView> ImportToXMLNavigationCommandButton { get; set; } 
        public IRPSButton<ProMRPView> ExportToXMLCommandButton { get; set; } 
        public IRPSButton<ProMRPView,MRPLogDialogView> MRPLogNavigationCommandButton { get; set; } 
        public IRPSButton<ProMRPView> ExecuteResetScreenDefaultValuesButton { get; set; } 
        public IRPSButton<ProMRPView> ExecuteSaveScreenDefaultValuesButton { get; set; } 
        public IRPSButton<ProMRPView,ProMRPPrintViewModelDialogView> ProMRPPrintViewModelNavigationCommandButton { get; set; } 
        public GetGeneratedMRPMODataCollectionEditor<ProMRPView,ImportToXMLDialogView> GetGeneratedMRPMOData { get; set; } 
        public GetGeneratedMRPPurchaseProposalDataCollectionEditor<ProMRPView,ImportToXMLDialogView> GetGeneratedMRPPurchaseProposalData { get; set; } 
        public IRPSSection<ProMRPView> Section { get; set; } 
        public IRPSSection<ProMRPView> ManufacturingOrders { get; set; } 
        public IRPSSection<ProMRPView> PurchaseProposals { get; set; } 
        public ProMRP Screen { get; set; }
        public ProMRPView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetGeneratedMRPMODataCollectionEditor<ProMRPView,ImportToXMLDialogView>:RPSCollectionEditor<ProMRPView,ImportToXMLDialogView> where ProMRPView : class, IView where ImportToXMLDialogView : class, IView
    {
        public  GetGeneratedMRPMODataGridView<ProMRPView,ImportToXMLDialogView> GridView {get;set;}
    }
    public partial class GetGeneratedMRPMODataGridView <ProMRPView,ImportToXMLDialogView> :  RPSGridView<ProMRPView,ImportToXMLDialogView> where ProMRPView : class, IView where ImportToXMLDialogView : class, IView
    {
        public GetGeneratedMRPMODataGridView(ProMRPView currentView,ImportToXMLDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Level = RPSControlFactory.CreateRPSGridFormattedTextBox<ProMRPView>("","#975913ea-ba8c-475b-9ebb-4787c27f865c .ag-row[role='row']@ROWINDEX [col-id='cLevel']","",false, this.CurrentView);
 
            PlannedStartDate = RPSControlFactory.CreateRPSGridTextBox<ProMRPView>("","#975913ea-ba8c-475b-9ebb-4787c27f865c .ag-row[role='row']@ROWINDEX [col-id='cPlannedStartDate']","",false, this.CurrentView);
 
            PlannedEndDate = RPSControlFactory.CreateRPSGridTextBox<ProMRPView>("","#975913ea-ba8c-475b-9ebb-4787c27f865c .ag-row[role='row']@ROWINDEX [col-id='cPlannedEndDate']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<ProMRPView>("","#975913ea-ba8c-475b-9ebb-4787c27f865c .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            MeasureUnit = RPSControlFactory.CreateRPSGridTextBox<ProMRPView>("","#975913ea-ba8c-475b-9ebb-4787c27f865c .ag-row[role='row']@ROWINDEX [col-id='cMeasureUnit']","",false, this.CurrentView);
 
            InternalCode = RPSControlFactory.CreateRPSGridTextBox<ProMRPView>("","#975913ea-ba8c-475b-9ebb-4787c27f865c .ag-row[role='row']@ROWINDEX [col-id='cInternalCode']","",false, this.CurrentView);
 
            AvailabilityLinkNavigationCommand = RPSControlFactory.CreateRPSGridButton<ProMRPView>( "","#975913ea-ba8c-475b-9ebb-4787c27f865c .ag-row[role='row']@ROWINDEX [col-id='cAvailabilityLinkNavigationCommand']","",this.CurrentView);
 
            StockInOtherSites = RPSControlFactory.CreateRPSGridFormattedTextBox<ProMRPView>("","#975913ea-ba8c-475b-9ebb-4787c27f865c .ag-row[role='row']@ROWINDEX [col-id='cStockInOtherSites']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ProMRPView> Level { get; set; } 
        public IRPSGridTextBox<ProMRPView> PlannedStartDate { get; set; } 
        public IRPSGridTextBox<ProMRPView> PlannedEndDate { get; set; } 
        public IRPSGridTextBox<ProMRPView> Quantity { get; set; } 
        public IRPSGridTextBox<ProMRPView> MeasureUnit { get; set; } 
        public IRPSGridTextBox<ProMRPView> InternalCode { get; set; } 
        public IRPSGridButton<ProMRPView> AvailabilityLinkNavigationCommand { get; set; } 
        public IRPSGridTextBox<ProMRPView> StockInOtherSites { get; set; } 
                     
    }
 
        public partial class GetGeneratedMRPPurchaseProposalDataCollectionEditor<ProMRPView,ImportToXMLDialogView>:RPSCollectionEditor<ProMRPView,ImportToXMLDialogView> where ProMRPView : class, IView where ImportToXMLDialogView : class, IView
    {
        public  GetGeneratedMRPPurchaseProposalDataGridView<ProMRPView,ImportToXMLDialogView> GridView {get;set;}
    }
    public partial class GetGeneratedMRPPurchaseProposalDataGridView <ProMRPView,ImportToXMLDialogView> :  RPSGridView<ProMRPView,ImportToXMLDialogView> where ProMRPView : class, IView where ImportToXMLDialogView : class, IView
    {
        public GetGeneratedMRPPurchaseProposalDataGridView(ProMRPView currentView,ImportToXMLDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Level = RPSControlFactory.CreateRPSGridFormattedTextBox<ProMRPView>("","#cc4c7d3d-712c-4db8-a0fb-2a53aafc755b .ag-row[role='row']@ROWINDEX [col-id='cLevel']","",false, this.CurrentView);
 
            ReceptionDate = RPSControlFactory.CreateRPSGridTextBox<ProMRPView>("","#cc4c7d3d-712c-4db8-a0fb-2a53aafc755b .ag-row[role='row']@ROWINDEX [col-id='cReceptionDate']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<ProMRPView>("","#cc4c7d3d-712c-4db8-a0fb-2a53aafc755b .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            MeasureUnit = RPSControlFactory.CreateRPSGridTextBox<ProMRPView>("","#cc4c7d3d-712c-4db8-a0fb-2a53aafc755b .ag-row[role='row']@ROWINDEX [col-id='cMeasureUnit']","",false, this.CurrentView);
 
            InternalCode = RPSControlFactory.CreateRPSGridTextBox<ProMRPView>("","#cc4c7d3d-712c-4db8-a0fb-2a53aafc755b .ag-row[role='row']@ROWINDEX [col-id='cInternalCode']","",false, this.CurrentView);
 
            LinkNavigationCommand = RPSControlFactory.CreateRPSGridButton<ProMRPView>( "","#cc4c7d3d-712c-4db8-a0fb-2a53aafc755b .ag-row[role='row']@ROWINDEX [col-id='cAvailabilityLinkNavigationCommand']","",this.CurrentView);
 
            StockInOtherSites = RPSControlFactory.CreateRPSGridFormattedTextBox<ProMRPView>("","#cc4c7d3d-712c-4db8-a0fb-2a53aafc755b .ag-row[role='row']@ROWINDEX [col-id='cStockInOtherSites']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ProMRPView> Level { get; set; } 
        public IRPSGridTextBox<ProMRPView> ReceptionDate { get; set; } 
        public IRPSGridTextBox<ProMRPView> Quantity { get; set; } 
        public IRPSGridTextBox<ProMRPView> MeasureUnit { get; set; } 
        public IRPSGridTextBox<ProMRPView> InternalCode { get; set; } 
        public IRPSGridButton<ProMRPView> LinkNavigationCommand { get; set; } 
        public IRPSGridTextBox<ProMRPView> StockInOtherSites { get; set; } 
                     
    }
 
    }
  
            
    public partial class ImportToXMLDialogView : View
    {
        public ImportToXMLDialogView(ProMRP screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public ProMRP Screen { get; set; }
        public ImportToXMLDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class GeneratedMOTaskView : View
    {
        public GeneratedMOTaskView(ProMRP screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_GetGeneratedMRPMODataTask = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7adab14b-e1a2-46f1-a4e1-06ab5b155f1b",CSSSelectorGrid="",XPathGrid=""};
            GetGeneratedMRPMODataTask = RPSControlFactory.RPSCreateCollectionWithGrid<GetGeneratedMRPMODataTaskCollectionEditor<GeneratedMOTaskView>,GeneratedMOTaskView>( params_GetGeneratedMRPMODataTask,this);
 

        }
        public GetGeneratedMRPMODataTaskCollectionEditor<GeneratedMOTaskView> GetGeneratedMRPMODataTask { get; set; } 
        public ProMRP Screen { get; set; }
        public GeneratedMOTaskView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetGeneratedMRPMODataTaskCollectionEditor<GeneratedMOTaskView>:RPSCollectionEditor<GeneratedMOTaskView> where GeneratedMOTaskView : class, IView
    {
        public  GetGeneratedMRPMODataTaskGridView<GeneratedMOTaskView> GridView {get;set;}
    }
    public partial class GetGeneratedMRPMODataTaskGridView <GeneratedMOTaskView> :  RPSGridView<GeneratedMOTaskView> where GeneratedMOTaskView : class, IView
    {
        public GetGeneratedMRPMODataTaskGridView(GeneratedMOTaskView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MOTaskDescription = RPSControlFactory.CreateRPSGridTextBox<GeneratedMOTaskView>("","#7adab14b-e1a2-46f1-a4e1-06ab5b155f1b .ag-row[role='row']@ROWINDEX [col-id='cMOTaskDescription']","",false, this.CurrentView);
 
            Time = RPSControlFactory.CreateRPSGridFormattedTextBox<GeneratedMOTaskView>("","#7adab14b-e1a2-46f1-a4e1-06ab5b155f1b .ag-row[role='row']@ROWINDEX [col-id='cTime']","",false, this.CurrentView);
 
            PlannedStartDate = RPSControlFactory.CreateRPSGridTextBox<GeneratedMOTaskView>("","#7adab14b-e1a2-46f1-a4e1-06ab5b155f1b .ag-row[role='row']@ROWINDEX [col-id='cPlannedStartDate']","",false, this.CurrentView);
 
            PlannedEndDate = RPSControlFactory.CreateRPSGridTextBox<GeneratedMOTaskView>("","#7adab14b-e1a2-46f1-a4e1-06ab5b155f1b .ag-row[role='row']@ROWINDEX [col-id='cPlannedEndDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<GeneratedMOTaskView> MOTaskDescription { get; set; } 
        public IRPSGridTextBox<GeneratedMOTaskView> Time { get; set; } 
        public IRPSGridTextBox<GeneratedMOTaskView> PlannedStartDate { get; set; } 
        public IRPSGridTextBox<GeneratedMOTaskView> PlannedEndDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class GeneratedMOMaterialView : View
    {
        public GeneratedMOMaterialView(ProMRP screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_GetGeneratedMRPMODataMaterial = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="91e76e16-5a05-4a80-8013-6357e2e1546d",CSSSelectorGrid="",XPathGrid=""};
            GetGeneratedMRPMODataMaterial = RPSControlFactory.RPSCreateCollectionWithGrid<GetGeneratedMRPMODataMaterialCollectionEditor<GeneratedMOMaterialView>,GeneratedMOMaterialView>( params_GetGeneratedMRPMODataMaterial,this);
 

        }
        public GetGeneratedMRPMODataMaterialCollectionEditor<GeneratedMOMaterialView> GetGeneratedMRPMODataMaterial { get; set; } 
        public ProMRP Screen { get; set; }
        public GeneratedMOMaterialView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetGeneratedMRPMODataMaterialCollectionEditor<GeneratedMOMaterialView>:RPSCollectionEditor<GeneratedMOMaterialView> where GeneratedMOMaterialView : class, IView
    {
        public  GetGeneratedMRPMODataMaterialGridView<GeneratedMOMaterialView> GridView {get;set;}
    }
    public partial class GetGeneratedMRPMODataMaterialGridView <GeneratedMOMaterialView> :  RPSGridView<GeneratedMOMaterialView> where GeneratedMOMaterialView : class, IView
    {
        public GetGeneratedMRPMODataMaterialGridView(GeneratedMOMaterialView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MOMaterialDescription = RPSControlFactory.CreateRPSGridTextBox<GeneratedMOMaterialView>("","#91e76e16-5a05-4a80-8013-6357e2e1546d .ag-row[role='row']@ROWINDEX [col-id='cMOMaterialDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<GeneratedMOMaterialView> MOMaterialDescription { get; set; } 
                     
    }
 
    }
  
            
    public partial class MRPLogDialogView : View
    {
        public MRPLogDialogView(ProMRP screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_GetMRPLog = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="20935ce8-0335-4f52-8563-1e005361f8ca",CSSSelectorGrid="",XPathGrid=""};
            GetMRPLog = RPSControlFactory.RPSCreateCollectionWithGrid<GetMRPLogCollectionEditor<MRPLogDialogView>,MRPLogDialogView>( params_GetMRPLog,this);
 
            CollectionInit params_GetMRPLogDetail = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7576137f-7380-4fcf-ade0-ba3d82cd43b2",CSSSelectorGrid="",XPathGrid=""};
            GetMRPLogDetail = RPSControlFactory.RPSCreateCollectionWithGrid<GetMRPLogDetailCollectionEditor<MRPLogDialogView>,MRPLogDialogView>( params_GetMRPLogDetail,this);
 

        }
        public GetMRPLogCollectionEditor<MRPLogDialogView> GetMRPLog { get; set; } 
        public GetMRPLogDetailCollectionEditor<MRPLogDialogView> GetMRPLogDetail { get; set; } 
        public ProMRP Screen { get; set; }
        public MRPLogDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetMRPLogCollectionEditor<MRPLogDialogView>:RPSCollectionEditor<MRPLogDialogView> where MRPLogDialogView : class, IView
    {
        public  GetMRPLogGridView<MRPLogDialogView> GridView {get;set;}
    }
    public partial class GetMRPLogGridView <MRPLogDialogView> :  RPSGridView<MRPLogDialogView> where MRPLogDialogView : class, IView
    {
        public GetMRPLogGridView(MRPLogDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Level = RPSControlFactory.CreateRPSGridFormattedTextBox<MRPLogDialogView>("","#20935ce8-0335-4f52-8563-1e005361f8ca .ag-row[role='row']@ROWINDEX [col-id='cLevel']","",false, this.CurrentView);
 
            MinimumStock = RPSControlFactory.CreateRPSGridFormattedTextBox<MRPLogDialogView>("","#20935ce8-0335-4f52-8563-1e005361f8ca .ag-row[role='row']@ROWINDEX [col-id='cMinimumStock']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MRPLogDialogView> Level { get; set; } 
        public IRPSGridTextBox<MRPLogDialogView> MinimumStock { get; set; } 
                     
    }
 
        public partial class GetMRPLogDetailCollectionEditor<MRPLogDialogView>:RPSCollectionEditor<MRPLogDialogView> where MRPLogDialogView : class, IView
    {
        public  GetMRPLogDetailGridView<MRPLogDialogView> GridView {get;set;}
    }
    public partial class GetMRPLogDetailGridView <MRPLogDialogView> :  RPSGridView<MRPLogDialogView> where MRPLogDialogView : class, IView
    {
        public GetMRPLogDetailGridView(MRPLogDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Description = RPSControlFactory.CreateRPSGridTextBox<MRPLogDialogView>("","#7576137f-7380-4fcf-ade0-ba3d82cd43b2 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Date = RPSControlFactory.CreateRPSGridTextBox<MRPLogDialogView>("","#7576137f-7380-4fcf-ade0-ba3d82cd43b2 .ag-row[role='row']@ROWINDEX [col-id='cDate']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<MRPLogDialogView>("","#7576137f-7380-4fcf-ade0-ba3d82cd43b2 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            Stock = RPSControlFactory.CreateRPSGridFormattedTextBox<MRPLogDialogView>("","#7576137f-7380-4fcf-ade0-ba3d82cd43b2 .ag-row[role='row']@ROWINDEX [col-id='cStock']","",false, this.CurrentView);
 
            Orders = RPSControlFactory.CreateRPSGridFormattedTextBox<MRPLogDialogView>("","#7576137f-7380-4fcf-ade0-ba3d82cd43b2 .ag-row[role='row']@ROWINDEX [col-id='cOrders']","",false, this.CurrentView);
 
            Reserves = RPSControlFactory.CreateRPSGridFormattedTextBox<MRPLogDialogView>("","#7576137f-7380-4fcf-ade0-ba3d82cd43b2 .ag-row[role='row']@ROWINDEX [col-id='cReserves']","",false, this.CurrentView);
 
            Launched = RPSControlFactory.CreateRPSGridFormattedTextBox<MRPLogDialogView>("","#7576137f-7380-4fcf-ade0-ba3d82cd43b2 .ag-row[role='row']@ROWINDEX [col-id='cLaunched']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MRPLogDialogView> Description { get; set; } 
        public IRPSGridTextBox<MRPLogDialogView> Date { get; set; } 
        public IRPSGridTextBox<MRPLogDialogView> Quantity { get; set; } 
        public IRPSGridTextBox<MRPLogDialogView> Stock { get; set; } 
        public IRPSGridTextBox<MRPLogDialogView> Orders { get; set; } 
        public IRPSGridTextBox<MRPLogDialogView> Reserves { get; set; } 
        public IRPSGridTextBox<MRPLogDialogView> Launched { get; set; } 
                     
    }
 
    }
  
            
    public partial class ProMRPPrintViewModelDialogView : View
    {
        public ProMRPPrintViewModelDialogView(ProMRP screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            PrintManufacturingOrder = RPSControlFactory.CreateRPSCheckBox<ProMRPPrintViewModelDialogView>("3014fd3d-e412-4150-a603-8bfbab5a3f38","","",false, this);
 
            PrintPurchaseProposal = RPSControlFactory.CreateRPSCheckBox<ProMRPPrintViewModelDialogView>("5bab4edf-c3ba-4da5-9246-f62e98561352","","",false, this);
 
            PrintOverStockArticles = RPSControlFactory.CreateRPSCheckBox<ProMRPPrintViewModelDialogView>("a4e7854a-f865-478f-884b-ddd0db7a3149","","",false, this);
 
            PrintLog = RPSControlFactory.CreateRPSCheckBox<ProMRPPrintViewModelDialogView>("c012dbba-806d-483d-9c39-e14a99843d55","","",false, this);
 

        }
        public IRPSCheckbox<ProMRPPrintViewModelDialogView> PrintManufacturingOrder { get; set; } 
        public IRPSCheckbox<ProMRPPrintViewModelDialogView> PrintPurchaseProposal { get; set; } 
        public IRPSCheckbox<ProMRPPrintViewModelDialogView> PrintOverStockArticles { get; set; } 
        public IRPSCheckbox<ProMRPPrintViewModelDialogView> PrintLog { get; set; } 
        public ProMRP Screen { get; set; }
        public ProMRPPrintViewModelDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ProMRPBloquedArticlesDialogView : View
    {
        public ProMRPBloquedArticlesDialogView(ProMRP screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_GetMRPBloquedArticles = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4ace3a5c-5bbf-4964-a614-6d20ef2875e9",CSSSelectorGrid="",XPathGrid=""};
            GetMRPBloquedArticles = RPSControlFactory.RPSCreateCollectionWithGrid<GetMRPBloquedArticlesCollectionEditor<ProMRPBloquedArticlesDialogView>,ProMRPBloquedArticlesDialogView>( params_GetMRPBloquedArticles,this);
 

        }
        public GetMRPBloquedArticlesCollectionEditor<ProMRPBloquedArticlesDialogView> GetMRPBloquedArticles { get; set; } 
        public ProMRP Screen { get; set; }
        public ProMRPBloquedArticlesDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetMRPBloquedArticlesCollectionEditor<ProMRPBloquedArticlesDialogView>:RPSCollectionEditor<ProMRPBloquedArticlesDialogView> where ProMRPBloquedArticlesDialogView : class, IView
    {
        public  GetMRPBloquedArticlesGridView<ProMRPBloquedArticlesDialogView> GridView {get;set;}
    }
    public partial class GetMRPBloquedArticlesGridView <ProMRPBloquedArticlesDialogView> :  RPSGridView<ProMRPBloquedArticlesDialogView> where ProMRPBloquedArticlesDialogView : class, IView
    {
        public GetMRPBloquedArticlesGridView(ProMRPBloquedArticlesDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            BlockedPurchase = RPSControlFactory.CreateRPSGridCheckBox<ProMRPBloquedArticlesDialogView>("","#4ace3a5c-5bbf-4964-a614-6d20ef2875e9 .ag-row[role='row']@ROWINDEX [col-id='cBlockedPurchase']","",false, this.CurrentView);
 
            BlockedManufacturing = RPSControlFactory.CreateRPSGridCheckBox<ProMRPBloquedArticlesDialogView>("","#4ace3a5c-5bbf-4964-a614-6d20ef2875e9 .ag-row[role='row']@ROWINDEX [col-id='cBlockedManufacturing']","",false, this.CurrentView);
 

        }
        public IRPSGridCheckbox<ProMRPBloquedArticlesDialogView> BlockedPurchase { get; set; } 
        public IRPSGridCheckbox<ProMRPBloquedArticlesDialogView> BlockedManufacturing { get; set; } 
                     
    }
 
    }
  
            
    public partial class ProMRPRegenerativeDeleteDialogView : View
    {
        public ProMRPRegenerativeDeleteDialogView(ProMRP screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_GetMRPRegenerativeDelete = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="16928e0e-7738-4c39-bb3a-d26922827ced",CSSSelectorGrid="",XPathGrid=""};
            GetMRPRegenerativeDelete = RPSControlFactory.RPSCreateCollectionWithGrid<GetMRPRegenerativeDeleteCollectionEditor<ProMRPRegenerativeDeleteDialogView>,ProMRPRegenerativeDeleteDialogView>( params_GetMRPRegenerativeDelete,this);
 

        }
        public GetMRPRegenerativeDeleteCollectionEditor<ProMRPRegenerativeDeleteDialogView> GetMRPRegenerativeDelete { get; set; } 
        public ProMRP Screen { get; set; }
        public ProMRPRegenerativeDeleteDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetMRPRegenerativeDeleteCollectionEditor<ProMRPRegenerativeDeleteDialogView>:RPSCollectionEditor<ProMRPRegenerativeDeleteDialogView> where ProMRPRegenerativeDeleteDialogView : class, IView
    {
        public  GetMRPRegenerativeDeleteGridView<ProMRPRegenerativeDeleteDialogView> GridView {get;set;}
    }
    public partial class GetMRPRegenerativeDeleteGridView <ProMRPRegenerativeDeleteDialogView> :  RPSGridView<ProMRPRegenerativeDeleteDialogView> where ProMRPRegenerativeDeleteDialogView : class, IView
    {
        public GetMRPRegenerativeDeleteGridView(ProMRPRegenerativeDeleteDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Type = RPSControlFactory.CreateRPSGridTextBox<ProMRPRegenerativeDeleteDialogView>("","#16928e0e-7738-4c39-bb3a-d26922827ced .ag-row[role='row']@ROWINDEX [col-id='cType']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ProMRPRegenerativeDeleteDialogView>("","#16928e0e-7738-4c39-bb3a-d26922827ced .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<ProMRPRegenerativeDeleteDialogView>("","#16928e0e-7738-4c39-bb3a-d26922827ced .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            ReceptionDate = RPSControlFactory.CreateRPSGridTextBox<ProMRPRegenerativeDeleteDialogView>("","#16928e0e-7738-4c39-bb3a-d26922827ced .ag-row[role='row']@ROWINDEX [col-id='cReceptionDate']","",false, this.CurrentView);
 
            ErrorMessage = RPSControlFactory.CreateRPSGridMemoTextBox<ProMRPRegenerativeDeleteDialogView>("","#16928e0e-7738-4c39-bb3a-d26922827ced .ag-row[role='row']@ROWINDEX [col-id='cErrorMessage']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ProMRPRegenerativeDeleteDialogView> Type { get; set; } 
        public IRPSGridTextBox<ProMRPRegenerativeDeleteDialogView> Description { get; set; } 
        public IRPSGridTextBox<ProMRPRegenerativeDeleteDialogView> Quantity { get; set; } 
        public IRPSGridTextBox<ProMRPRegenerativeDeleteDialogView> ReceptionDate { get; set; } 
        public IRPSGridTextBox<ProMRPRegenerativeDeleteDialogView> ErrorMessage { get; set; } 
                     
    }
 
    }
  
            
    public partial class MOPurchaseProposalsLinkedDialogView : View
    {
        public MOPurchaseProposalsLinkedDialogView(ProMRP screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeselectMO = RPSControlFactory.CreateRPSOption<MOPurchaseProposalsLinkedDialogView>( "65553e72-367a-47f9-9574-9dbef1437e97","","",this);
 
            UnLinkProposalFromTheMO = RPSControlFactory.CreateRPSOption<MOPurchaseProposalsLinkedDialogView>( "73977ba1-4374-4389-862c-ece76a49b44a","","",this);
 
            DontAskAgain = RPSControlFactory.CreateRPSCheckBox<MOPurchaseProposalsLinkedDialogView>("ef6023de-0fba-4b98-9041-7785549e367a","","",false, this);
 

        }
        public IRPSOption<MOPurchaseProposalsLinkedDialogView> DeselectMO { get; set; } 
        public IRPSOption<MOPurchaseProposalsLinkedDialogView> UnLinkProposalFromTheMO { get; set; } 
        public IRPSCheckbox<MOPurchaseProposalsLinkedDialogView> DontAskAgain { get; set; } 
        public ProMRP Screen { get; set; }
        public MOPurchaseProposalsLinkedDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}