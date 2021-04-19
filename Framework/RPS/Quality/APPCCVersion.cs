    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.APPCCVersion
{
    //RPS VERSION 1.0.0.0
    public partial class APPCCVersion:Screen
    {
        public APPCCVersion():base()
        {
            this.URL = "quality.appccversion";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            APPCCVersionCollectionView  = new APPCCVersionCollectionView(this); 
            APPCCVersionEntityView  = new APPCCVersionEntityView(this); 
            APPCCTaskView  = new APPCCTaskView(this); 
            APPCCTaskDangerView  = new APPCCTaskDangerView(this); 
            APPCCControlView  = new APPCCControlView(this); 
            APPCCCauseView  = new APPCCCauseView(this); 
            PrintOptionsDialogView  = new PrintOptionsDialogView(this); 
            RejectAPPCCVersionDialogView  = new RejectAPPCCVersionDialogView(this); 
            RejectionHistoryDialogView  = new RejectionHistoryDialogView(this); 
            CopyFromOtherAPPCCDialogView  = new CopyFromOtherAPPCCDialogView(this); 
            APPCCDangerByLangView  = new APPCCDangerByLangView(this); 
            APPCCControlByLangView  = new APPCCControlByLangView(this); 
            APPCCCauseByLangView  = new APPCCCauseByLangView(this); 
            APPCCTaskByLangView  = new APPCCTaskByLangView(this); 
            APPCCVersionCollectionView.InitializeControls(); 
            APPCCVersionEntityView.InitializeControls(); 
            APPCCTaskView.InitializeControls(); 
            APPCCTaskDangerView.InitializeControls(); 
            APPCCControlView.InitializeControls(); 
            APPCCCauseView.InitializeControls(); 
            PrintOptionsDialogView.InitializeControls(); 
            RejectAPPCCVersionDialogView.InitializeControls(); 
            RejectionHistoryDialogView.InitializeControls(); 
            CopyFromOtherAPPCCDialogView.InitializeControls(); 
            APPCCDangerByLangView.InitializeControls(); 
            APPCCControlByLangView.InitializeControls(); 
            APPCCCauseByLangView.InitializeControls(); 
            APPCCTaskByLangView.InitializeControls(); 
           
        }
      
            public APPCCVersionCollectionView APPCCVersionCollectionView {get; set; } 
            public APPCCVersionEntityView APPCCVersionEntityView {get; set; } 
            public APPCCTaskView APPCCTaskView {get; set; } 
            public APPCCTaskDangerView APPCCTaskDangerView {get; set; } 
            public APPCCControlView APPCCControlView {get; set; } 
            public APPCCCauseView APPCCCauseView {get; set; } 
            public PrintOptionsDialogView PrintOptionsDialogView {get; set; } 
            public RejectAPPCCVersionDialogView RejectAPPCCVersionDialogView {get; set; } 
            public RejectionHistoryDialogView RejectionHistoryDialogView {get; set; } 
            public CopyFromOtherAPPCCDialogView CopyFromOtherAPPCCDialogView {get; set; } 
            public APPCCDangerByLangView APPCCDangerByLangView {get; set; } 
            public APPCCControlByLangView APPCCControlByLangView {get; set; } 
            public APPCCCauseByLangView APPCCCauseByLangView {get; set; } 
            public APPCCTaskByLangView APPCCTaskByLangView {get; set; } 
    }
            
    public partial class APPCCVersionCollectionView : View
    {
        public APPCCVersionCollectionView(APPCCVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<APPCCVersionCollectionView,APPCCVersionEntityView>( this,Screen.APPCCVersionEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "e225c6b5-92f8-4d76-a0d3-9e29275ad073",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<APPCCVersionCollectionView,APPCCVersionEntityView>( params_MainConsult,this,Screen.APPCCVersionEntityView);
 

        }
        public IRPSButton<APPCCVersionCollectionView,APPCCVersionEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<APPCCVersionCollectionView,APPCCVersionEntityView> MainConsult { get; set; } 
        public APPCCVersion Screen { get; set; }
        public APPCCVersionCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class APPCCVersionEntityView : View
    {
        public APPCCVersionEntityView(APPCCVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<APPCCVersionEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<APPCCVersionEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<APPCCVersionEntityView,APPCCVersionCollectionView>( this,Screen.APPCCVersionCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<APPCCVersionEntityView,APPCCVersionCollectionView>( this,Screen.APPCCVersionCollectionView);
 
            UIIDSite = RPSControlFactory.CreateRPSComboBox<APPCCVersionEntityView>("93ac128c-9c5a-401c-a473-e9675e0ef8ab","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<APPCCVersionEntityView>("de47a0c6-620b-43fc-8c31-29f240625784","","",true, this);
 
            IDStructureManufacturing = RPSControlFactory.CreateRPSComboBox<APPCCVersionEntityView>("bbe5454b-724b-48ab-9264-6e58c256c4d3","","",false, this);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<APPCCVersionEntityView>("090d228f-937d-4d0b-8278-5baecbe7f12d","","",false, this);
 
            IDArticleVersion = RPSControlFactory.CreateRPSComboBox<APPCCVersionEntityView>("1e68d25e-c7bb-4901-bb00-141ff40ceb6e","","",false, this);
 
            UIIDArticleVersionSample = RPSControlFactory.CreateRPSComboBox<APPCCVersionEntityView>("03cc758d-78bf-4980-80f3-44afbf42696b","","",false, this);
 
            Version = RPSControlFactory.CreateRPSTextBox<APPCCVersionEntityView>("0fbdb9ad-281a-454f-bced-02b8a1e31b88","","",true, this);
 
            APPCCNumber = RPSControlFactory.CreateRPSTextBox<APPCCVersionEntityView>("8443302d-440c-4391-a9a6-7b56763c26cc","","",true, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<APPCCVersionEntityView>("99c0de29-8e83-4927-9857-4ce22b93c130","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<APPCCVersionEntityView>("a19254f9-e71d-4ded-aee6-76293f5c9145","","",false, this);
 
            DoneDate = RPSControlFactory.CreateRPSTextBox<APPCCVersionEntityView>("a41e7d5c-0c5f-4b62-8779-65c87f42d5f7","","",true, this);
 
            CodUserDoneBy = RPSControlFactory.CreateRPSComboBox<APPCCVersionEntityView>("57040f64-1f0a-4f98-ab1d-5a65573a3518","","",true, this);
 
            EndDate = RPSControlFactory.CreateRPSTextBox<APPCCVersionEntityView>("f113a6f3-ecd0-4eb2-b34a-45c08e74c70d","","",false, this);
 
            CodUserEnd = RPSControlFactory.CreateRPSComboBox<APPCCVersionEntityView>("7c64bf89-d612-469a-a328-9c5adc1afb63","","",false, this);
 
            ApprovedDate = RPSControlFactory.CreateRPSTextBox<APPCCVersionEntityView>("4ffbd9f9-5a4d-4929-987b-a146a228877a","","",false, this);
 
            CodUserApprovedBy = RPSControlFactory.CreateRPSComboBox<APPCCVersionEntityView>("63ace441-94bf-4008-a430-17b080a4f8ce","","",false, this);
 
            UIPendingLabel = RPSControlFactory.CreateRPSTextBox<APPCCVersionEntityView>("bf1f0c1d-e03e-46e0-9d38-29ce36a56c62","","",false, this);
 
            PendingRevisionCause = RPSControlFactory.CreateRPSTextBox<APPCCVersionEntityView>("3336fb01-85cf-4598-a8c9-74af2291580b","","",false, this);
 
            RejectionUser = RPSControlFactory.CreateRPSComboBox<APPCCVersionEntityView>("7e112b1f-8601-47f3-81c7-70141ef1e0b4","","",false, this);
 
            RejectionDate = RPSControlFactory.CreateRPSTextBox<APPCCVersionEntityView>("bb089a4d-495a-44ca-9471-eaf65a09d2b5","","",false, this);
 
            RejectionReason = RPSControlFactory.CreateRPSTextBox<APPCCVersionEntityView>("aa363f2d-7dbb-4f37-af8b-81c4c160a8ef","","",false, this);
 
            UIIDRoute = RPSControlFactory.CreateRPSComboBox<APPCCVersionEntityView>("3494c7c5-6f30-4d7d-bb2e-61bcaadcedf6","","",false, this);
 
            IDManufacturingTask = RPSControlFactory.CreateRPSComboBox<APPCCVersionEntityView>("af432cdb-6b94-4f5e-9b38-4a0e55da782e","","",false, this);
 
            IDProjectTask = RPSControlFactory.CreateRPSComboBox<APPCCVersionEntityView>("d1f1b77e-3ad3-4a44-bd94-583265ba927e","","",false, this);
 
            ExecutePrintAPPCCVersionButton = RPSControlFactory.CreateRPSButtonToView<APPCCVersionEntityView,PrintOptionsDialogView>("212523ff-d3ac-42aa-b9ab-a432de26cbf0","","", this,Screen.PrintOptionsDialogView);
 
            FinalizeCommandButton = RPSControlFactory.CreateRPSButton<APPCCVersionEntityView>( "93541759-a86b-4878-afa5-84afe0ddb6a7","","",this);
 
            ApprovalCommandButton = RPSControlFactory.CreateRPSButton<APPCCVersionEntityView>( "9f761474-2a31-4b21-b7a3-8cdeed10c5ce","","",this);
 
            RejectCommandButton = RPSControlFactory.CreateRPSButtonToView<APPCCVersionEntityView,RejectAPPCCVersionDialogView>("e0e92f26-09e9-47b5-87a6-6bb5d3b0c560","","", this,Screen.RejectAPPCCVersionDialogView);
 
            ReceiptCommandButton = RPSControlFactory.CreateRPSButton<APPCCVersionEntityView>( "4ccefa5b-0e90-4c57-bb06-59e942dcb51b","","",this);
 
            ReviseCommandButton = RPSControlFactory.CreateRPSButton<APPCCVersionEntityView>( "80557efd-0145-4ac9-a04a-65aa5e0e790c","","",this);
 
            ShowRejectionsCommandButton = RPSControlFactory.CreateRPSButtonToView<APPCCVersionEntityView,RejectionHistoryDialogView>("c8ce469f-c4a8-49d3-9ecf-619174b57232","","", this,Screen.RejectionHistoryDialogView);
 
            CopyFromOtherAPPCCCommandButton = RPSControlFactory.CreateRPSButtonToView<APPCCVersionEntityView,CopyFromOtherAPPCCDialogView>("0f1167af-d0d0-404f-b3ea-c8b460318cc5","","", this,Screen.CopyFromOtherAPPCCDialogView);
 
            CollectionInit params_APPCCTasks = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6e898cdd-a06f-4961-a037-ed6b7bd22484",CSSSelectorGrid="",XPathGrid=""};
            APPCCTasks = RPSControlFactory.RPSCreateCollectionWithGrid<APPCCTasksCollectionEditor<APPCCVersionEntityView,APPCCTaskByLangView>,APPCCVersionEntityView,APPCCTaskByLangView>( params_APPCCTasks,this,Screen.APPCCTaskByLangView);
 
            CollectionInit params_MaterialsWithAPPCCVersion = new CollectionInit(){IDDescriptor = "d4340837-642e-4241-a273-e28eeb1c9886",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="eb299470-5a74-4277-a9a9-8171683264f5",CSSSelectorGrid="",XPathGrid=""};
            MaterialsWithAPPCCVersion = RPSControlFactory.RPSCreateCollectionWithGrid<MaterialsWithAPPCCVersionCollectionEditor<APPCCVersionEntityView,APPCCTaskByLangView>,APPCCVersionEntityView,APPCCTaskByLangView>( params_MaterialsWithAPPCCVersion,this,Screen.APPCCTaskByLangView);
 
            CollectionInit params_APPCCTaskByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d9bd4641-457c-4cea-bed3-769116377e40",CSSSelectorGrid="",XPathGrid=""};
            APPCCTaskByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<APPCCTaskByLangsCollectionEditor<APPCCVersionEntityView,APPCCTaskByLangView>,APPCCVersionEntityView,APPCCTaskByLangView>( params_APPCCTaskByLangs,this,Screen.APPCCTaskByLangView);
 
            APPCCTask = RPSControlFactory.CreateRPSSection<APPCCVersionEntityView>( "","ul li[rpsid='f2909814-aa73-42c1-b62d-bb261e6d729e']","",this);
 
            MaterialsWithAPPCC = RPSControlFactory.CreateRPSSection<APPCCVersionEntityView>( "","ul li[rpsid='a5a23c9e-d2fd-4b21-941a-7fb037cf8e6b']","",this);
 
            Structure = RPSControlFactory.CreateRPSSection<APPCCVersionEntityView>( "","ul li[rpsid='5c1b9608-1bcf-467d-85ab-8a7d31bbd4d9']","",this);
 
            TasksByLangs = RPSControlFactory.CreateRPSSection<APPCCVersionEntityView>( "","ul li[rpsid='e84226aa-ab48-4cea-9680-b3783b06053b']","",this);
 

        }
        public IRPSSaveButton<APPCCVersionEntityView> SaveButton { get; set; } 
        public IRPSButton<APPCCVersionEntityView> DeleteButton { get; set; } 
        public IRPSButton<APPCCVersionEntityView,APPCCVersionCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<APPCCVersionEntityView,APPCCVersionCollectionView> BackButton { get; set; } 
        public IRPSComboBox<APPCCVersionEntityView> UIIDSite { get; set; } 
        public IRPSComboBox<APPCCVersionEntityView> IDArticle { get; set; } 
        public IRPSComboBox<APPCCVersionEntityView> IDStructureManufacturing { get; set; } 
        public IRPSComboBox<APPCCVersionEntityView> IDProject { get; set; } 
        public IRPSComboBox<APPCCVersionEntityView> IDArticleVersion { get; set; } 
        public IRPSComboBox<APPCCVersionEntityView> UIIDArticleVersionSample { get; set; } 
        public IRPSTextBox<APPCCVersionEntityView> Version { get; set; } 
        public IRPSTextBox<APPCCVersionEntityView> APPCCNumber { get; set; } 
        public IRPSComboBox<APPCCVersionEntityView> IDCustomer { get; set; } 
        public IRPSTextBox<APPCCVersionEntityView> Description { get; set; } 
        public IRPSTextBox<APPCCVersionEntityView> DoneDate { get; set; } 
        public IRPSComboBox<APPCCVersionEntityView> CodUserDoneBy { get; set; } 
        public IRPSTextBox<APPCCVersionEntityView> EndDate { get; set; } 
        public IRPSComboBox<APPCCVersionEntityView> CodUserEnd { get; set; } 
        public IRPSTextBox<APPCCVersionEntityView> ApprovedDate { get; set; } 
        public IRPSComboBox<APPCCVersionEntityView> CodUserApprovedBy { get; set; } 
        public IRPSTextBox<APPCCVersionEntityView> UIPendingLabel { get; set; } 
        public IRPSTextBox<APPCCVersionEntityView> PendingRevisionCause { get; set; } 
        public IRPSComboBox<APPCCVersionEntityView> RejectionUser { get; set; } 
        public IRPSTextBox<APPCCVersionEntityView> RejectionDate { get; set; } 
        public IRPSTextBox<APPCCVersionEntityView> RejectionReason { get; set; } 
        public IRPSComboBox<APPCCVersionEntityView> UIIDRoute { get; set; } 
        public IRPSComboBox<APPCCVersionEntityView> IDManufacturingTask { get; set; } 
        public IRPSComboBox<APPCCVersionEntityView> IDProjectTask { get; set; } 
        public IRPSButton<APPCCVersionEntityView,PrintOptionsDialogView> ExecutePrintAPPCCVersionButton { get; set; } 
        public IRPSButton<APPCCVersionEntityView> FinalizeCommandButton { get; set; } 
        public IRPSButton<APPCCVersionEntityView> ApprovalCommandButton { get; set; } 
        public IRPSButton<APPCCVersionEntityView,RejectAPPCCVersionDialogView> RejectCommandButton { get; set; } 
        public IRPSButton<APPCCVersionEntityView> ReceiptCommandButton { get; set; } 
        public IRPSButton<APPCCVersionEntityView> ReviseCommandButton { get; set; } 
        public IRPSButton<APPCCVersionEntityView,RejectionHistoryDialogView> ShowRejectionsCommandButton { get; set; } 
        public IRPSButton<APPCCVersionEntityView,CopyFromOtherAPPCCDialogView> CopyFromOtherAPPCCCommandButton { get; set; } 
        public APPCCTasksCollectionEditor<APPCCVersionEntityView,APPCCTaskByLangView> APPCCTasks { get; set; } 
        public MaterialsWithAPPCCVersionCollectionEditor<APPCCVersionEntityView,APPCCTaskByLangView> MaterialsWithAPPCCVersion { get; set; } 
        public APPCCTaskByLangsCollectionEditor<APPCCVersionEntityView,APPCCTaskByLangView> APPCCTaskByLangs { get; set; } 
        public IRPSSection<APPCCVersionEntityView> APPCCTask { get; set; } 
        public IRPSSection<APPCCVersionEntityView> MaterialsWithAPPCC { get; set; } 
        public IRPSSection<APPCCVersionEntityView> Structure { get; set; } 
        public IRPSSection<APPCCVersionEntityView> TasksByLangs { get; set; } 
        public APPCCVersion Screen { get; set; }
        public APPCCVersionEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class APPCCTasksCollectionEditor<APPCCVersionEntityView,APPCCTaskByLangView>:RPSCollectionEditor<APPCCVersionEntityView,APPCCTaskByLangView> where APPCCVersionEntityView : class, IView where APPCCTaskByLangView : class, IView
    {
        public  APPCCTasksGridView<APPCCVersionEntityView,APPCCTaskByLangView> GridView {get;set;}
    }
    public partial class APPCCTasksGridView <APPCCVersionEntityView,APPCCTaskByLangView> :  RPSGridView<APPCCVersionEntityView,APPCCTaskByLangView> where APPCCVersionEntityView : class, IView where APPCCTaskByLangView : class, IView
    {
        public APPCCTasksGridView(APPCCVersionEntityView currentView,APPCCTaskByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDManufacturingTask = RPSControlFactory.CreateRPSGridComboBox<APPCCVersionEntityView>("","#6e898cdd-a06f-4961-a037-ed6b7bd22484 .ag-row[role='row']@ROWINDEX [col-id='cIDManufacturingTask']","",false, this.CurrentView);
 
            IDProjectTask = RPSControlFactory.CreateRPSGridComboBox<APPCCVersionEntityView>("","#6e898cdd-a06f-4961-a037-ed6b7bd22484 .ag-row[role='row']@ROWINDEX [col-id='cIDProjectTask']","",false, this.CurrentView);
 
            PotentialDangersCount = RPSControlFactory.CreateRPSGridFormattedTextBox<APPCCVersionEntityView>("","#6e898cdd-a06f-4961-a037-ed6b7bd22484 .ag-row[role='row']@ROWINDEX [col-id='cPotentialDangersCount']","",false, this.CurrentView);
 
            PotentialDangersSatisfactory = RPSControlFactory.CreateRPSGridFormattedTextBox<APPCCVersionEntityView>("","#6e898cdd-a06f-4961-a037-ed6b7bd22484 .ag-row[role='row']@ROWINDEX [col-id='cPotentialDangersSatisfactory']","",false, this.CurrentView);
 
            PotentialDangersMedium = RPSControlFactory.CreateRPSGridFormattedTextBox<APPCCVersionEntityView>("","#6e898cdd-a06f-4961-a037-ed6b7bd22484 .ag-row[role='row']@ROWINDEX [col-id='cPotentialDangersMedium']","",false, this.CurrentView);
 
            PotentialDangersBad = RPSControlFactory.CreateRPSGridFormattedTextBox<APPCCVersionEntityView>("","#6e898cdd-a06f-4961-a037-ed6b7bd22484 .ag-row[role='row']@ROWINDEX [col-id='cPotentialDangersBad']","",false, this.CurrentView);
 
            PotentialDangersCritical = RPSControlFactory.CreateRPSGridFormattedTextBox<APPCCVersionEntityView>("","#6e898cdd-a06f-4961-a037-ed6b7bd22484 .ag-row[role='row']@ROWINDEX [col-id='cPotentialDangersCritical']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<APPCCVersionEntityView> IDManufacturingTask { get; set; } 
        public IRPSGridComboBox<APPCCVersionEntityView> IDProjectTask { get; set; } 
        public IRPSGridTextBox<APPCCVersionEntityView> PotentialDangersCount { get; set; } 
        public IRPSGridTextBox<APPCCVersionEntityView> PotentialDangersSatisfactory { get; set; } 
        public IRPSGridTextBox<APPCCVersionEntityView> PotentialDangersMedium { get; set; } 
        public IRPSGridTextBox<APPCCVersionEntityView> PotentialDangersBad { get; set; } 
        public IRPSGridTextBox<APPCCVersionEntityView> PotentialDangersCritical { get; set; } 
                     
    }
 
        public partial class MaterialsWithAPPCCVersionCollectionEditor<APPCCVersionEntityView,APPCCTaskByLangView>:RPSCollectionEditor<APPCCVersionEntityView,APPCCTaskByLangView> where APPCCVersionEntityView : class, IView where APPCCTaskByLangView : class, IView
    {
        public  MaterialsWithAPPCCVersionGridView<APPCCVersionEntityView,APPCCTaskByLangView> GridView {get;set;}
    }
    public partial class MaterialsWithAPPCCVersionGridView <APPCCVersionEntityView,APPCCTaskByLangView> :  RPSGridView<APPCCVersionEntityView,APPCCTaskByLangView> where APPCCVersionEntityView : class, IView where APPCCTaskByLangView : class, IView
    {
        public MaterialsWithAPPCCVersionGridView(APPCCVersionEntityView currentView,APPCCTaskByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            UIState = RPSControlFactory.CreateRPSGridTextBox<APPCCVersionEntityView>("","#eb299470-5a74-4277-a9a9-8171683264f5 .ag-row[role='row']@ROWINDEX [col-id='cUIState']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<APPCCVersionEntityView> UIState { get; set; } 
                     
    }
 
        public partial class APPCCTaskByLangsCollectionEditor<APPCCVersionEntityView,APPCCTaskByLangView>:RPSCollectionEditor<APPCCVersionEntityView,APPCCTaskByLangView> where APPCCVersionEntityView : class, IView where APPCCTaskByLangView : class, IView
    {
        public  APPCCTaskByLangsGridView<APPCCVersionEntityView,APPCCTaskByLangView> GridView {get;set;}
    }
    public partial class APPCCTaskByLangsGridView <APPCCVersionEntityView,APPCCTaskByLangView> :  RPSGridView<APPCCVersionEntityView,APPCCTaskByLangView> where APPCCVersionEntityView : class, IView where APPCCTaskByLangView : class, IView
    {
        public APPCCTaskByLangsGridView(APPCCVersionEntityView currentView,APPCCTaskByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<APPCCVersionEntityView>("","#d9bd4641-457c-4cea-bed3-769116377e40 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<APPCCVersionEntityView>("","#d9bd4641-457c-4cea-bed3-769116377e40 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<APPCCVersionEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<APPCCVersionEntityView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class APPCCTaskView : View
    {
        public APPCCTaskView(APPCCVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDMaunfacturingTask = RPSControlFactory.CreateRPSComboBox<APPCCTaskView>("7661582f-6566-44d7-8050-ecddd611f38d","","",false, this);
 
            IDProjectTask = RPSControlFactory.CreateRPSComboBox<APPCCTaskView>("f71b8a69-63bf-4a6e-9c33-dd870b0766f8","","",false, this);
 
            CollectionInit params_APPCCDangers = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1c2820bb-8c2f-480a-a788-b184e1889cd7",CSSSelectorGrid="",XPathGrid=""};
            APPCCDangers = RPSControlFactory.RPSCreateCollectionWithGrid<APPCCDangersCollectionEditor<APPCCTaskView,APPCCTaskDangerView>,APPCCTaskView,APPCCTaskDangerView>( params_APPCCDangers,this,Screen.APPCCTaskDangerView);
 
            Dangers = RPSControlFactory.CreateRPSSection<APPCCTaskView>( "","ul li[rpsid='50567d58-c519-459d-ba53-d689d2150c1d']","",this);
 

        }
        public IRPSComboBox<APPCCTaskView> IDMaunfacturingTask { get; set; } 
        public IRPSComboBox<APPCCTaskView> IDProjectTask { get; set; } 
        public APPCCDangersCollectionEditor<APPCCTaskView,APPCCTaskDangerView> APPCCDangers { get; set; } 
        public IRPSSection<APPCCTaskView> Dangers { get; set; } 
        public APPCCVersion Screen { get; set; }
        public APPCCTaskView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class APPCCDangersCollectionEditor<APPCCTaskView,APPCCTaskDangerView>:RPSCollectionEditor<APPCCTaskView,APPCCTaskDangerView> where APPCCTaskView : class, IView where APPCCTaskDangerView : class, IView
    {
        public  APPCCDangersGridView<APPCCTaskView,APPCCTaskDangerView> GridView {get;set;}
    }
    public partial class APPCCDangersGridView <APPCCTaskView,APPCCTaskDangerView> :  RPSGridView<APPCCTaskView,APPCCTaskDangerView> where APPCCTaskView : class, IView where APPCCTaskDangerView : class, IView
    {
        public APPCCDangersGridView(APPCCTaskView currentView,APPCCTaskDangerView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NumDanger = RPSControlFactory.CreateRPSGridFormattedTextBox<APPCCTaskView>("","#1c2820bb-8c2f-480a-a788-b184e1889cd7 .ag-row[role='row']@ROWINDEX [col-id='cNumDanger']","",true, this.CurrentView);
 
            IDPotentialDanger = RPSControlFactory.CreateRPSGridComboBox<APPCCTaskView>("","#1c2820bb-8c2f-480a-a788-b184e1889cd7 .ag-row[role='row']@ROWINDEX [col-id='cIDPotentialDanger']","",false, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<APPCCTaskView>("","#1c2820bb-8c2f-480a-a788-b184e1889cd7 .ag-row[role='row']@ROWINDEX [col-id='cType']","",false, this.CurrentView);
 
            Occurrence = RPSControlFactory.CreateRPSGridEnumComboBox<APPCCTaskView>("","#1c2820bb-8c2f-480a-a788-b184e1889cd7 .ag-row[role='row']@ROWINDEX [col-id='cOccurrence']","",true, this.CurrentView);
 
            Severity = RPSControlFactory.CreateRPSGridEnumComboBox<APPCCTaskView>("","#1c2820bb-8c2f-480a-a788-b184e1889cd7 .ag-row[role='row']@ROWINDEX [col-id='cSeverity']","",true, this.CurrentView);
 
            Detection = RPSControlFactory.CreateRPSGridEnumComboBox<APPCCTaskView>("","#1c2820bb-8c2f-480a-a788-b184e1889cd7 .ag-row[role='row']@ROWINDEX [col-id='cDetection']","",true, this.CurrentView);
 
            Punctuation = RPSControlFactory.CreateRPSGridEnumComboBox<APPCCTaskView>("","#1c2820bb-8c2f-480a-a788-b184e1889cd7 .ag-row[role='row']@ROWINDEX [col-id='cPunctuation']","",true, this.CurrentView);
 
            ForceControl = RPSControlFactory.CreateRPSGridCheckBox<APPCCTaskView>("","#1c2820bb-8c2f-480a-a788-b184e1889cd7 .ag-row[role='row']@ROWINDEX [col-id='cForceControl']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<APPCCTaskView> NumDanger { get; set; } 
        public IRPSGridComboBox<APPCCTaskView> IDPotentialDanger { get; set; } 
        public IRPSGridComboBox<APPCCTaskView> Type { get; set; } 
        public IRPSGridComboBox<APPCCTaskView> Occurrence { get; set; } 
        public IRPSGridComboBox<APPCCTaskView> Severity { get; set; } 
        public IRPSGridComboBox<APPCCTaskView> Detection { get; set; } 
        public IRPSGridComboBox<APPCCTaskView> Punctuation { get; set; } 
        public IRPSGridCheckbox<APPCCTaskView> ForceControl { get; set; } 
                     
    }
 
    }
  
            
    public partial class APPCCTaskDangerView : View
    {
        public APPCCTaskDangerView(APPCCVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<APPCCTaskDangerView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<APPCCTaskDangerView,APPCCTaskView>( this,Screen.APPCCTaskView);
 
            BackButton = RPSControlFactory.RPSBackButton<APPCCTaskDangerView,APPCCTaskView>( this,Screen.APPCCTaskView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<APPCCTaskDangerView,APPCCTaskView>( this,Screen.APPCCTaskView);
 
            NumDanger = RPSControlFactory.CreateRPSFormattedTextBox<APPCCTaskDangerView>("f033d99b-3eed-430a-861e-dd578bcc8ddb","","",true, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<APPCCTaskDangerView>("4e3fb4f1-4a6c-48b2-9f5d-93b5f447399e","","",false, this);
 
            IDPotentialDanger = RPSControlFactory.CreateRPSComboBox<APPCCTaskDangerView>("d3429272-bd68-42d7-a9a4-6c0f5c273909","","",false, this);
 
            DangerDescription = RPSControlFactory.CreateRPSTextBox<APPCCTaskDangerView>("72705ab6-f882-49d3-a415-3c1c149ec7e0","","",false, this);
 
            Occurrence = RPSControlFactory.CreateRPSEnumComboBox<APPCCTaskDangerView>("3f0c865a-8603-4d2b-9ffa-84c6603afe59","","",true, this);
 
            Severity = RPSControlFactory.CreateRPSEnumComboBox<APPCCTaskDangerView>("b0b2c2d3-99c6-4d9f-989c-b24d62e26a5a","","",true, this);
 
            Detection = RPSControlFactory.CreateRPSEnumComboBox<APPCCTaskDangerView>("55a07b64-584a-4f8d-9762-e36f781976b4","","",true, this);
 
            Punctuation = RPSControlFactory.CreateRPSEnumComboBox<APPCCTaskDangerView>("8b621659-e89a-4291-9f87-474a5206f0f3","","",true, this);
 
            ForceControl = RPSControlFactory.CreateRPSCheckBox<APPCCTaskDangerView>("dc5a241a-aca2-42ad-8c0c-8e73aa8767a8","","",true, this);
 
            Question1 = RPSControlFactory.CreateRPSEnumComboBox<APPCCTaskDangerView>("75b6a574-1feb-4e19-afb9-e5da3f2d2626","","",true, this);
 
            Question2 = RPSControlFactory.CreateRPSEnumComboBox<APPCCTaskDangerView>("005d5cab-b90f-4154-a10b-7a67eb78cf31","","",true, this);
 
            Question3 = RPSControlFactory.CreateRPSEnumComboBox<APPCCTaskDangerView>("790e9268-2fc6-44f3-8c58-272594101111","","",true, this);
 
            Question4 = RPSControlFactory.CreateRPSEnumComboBox<APPCCTaskDangerView>("0879bce9-5676-4882-bc9f-98c8e1e28200","","",true, this);
 
            PointCriticalControl = RPSControlFactory.CreateRPSEnumComboBox<APPCCTaskDangerView>("e552a4df-575f-4298-a4e4-fa19007e9a70","","",true, this);
 
            CollectionInit params_APPCCControls = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0527854a-53d9-4ac3-bc78-89b81ada01a7",CSSSelectorGrid="",XPathGrid=""};
            APPCCControls = RPSControlFactory.RPSCreateCollectionWithGrid<APPCCControlsCollectionEditor<APPCCTaskDangerView,APPCCDangerByLangView>,APPCCTaskDangerView,APPCCDangerByLangView>( params_APPCCControls,this,Screen.APPCCDangerByLangView);
 
            CollectionInit params_APPCCCauses = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="2e5ab434-b3fe-4391-be93-dbc4b6dc60cf",CSSSelectorGrid="",XPathGrid=""};
            APPCCCauses = RPSControlFactory.RPSCreateCollectionWithGrid<APPCCCausesCollectionEditor<APPCCTaskDangerView,APPCCDangerByLangView>,APPCCTaskDangerView,APPCCDangerByLangView>( params_APPCCCauses,this,Screen.APPCCDangerByLangView);
 
            CollectionInit params_APPCCDangerByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="eb23b96e-49f5-4e5e-b7d3-4286a2621ba2",CSSSelectorGrid="",XPathGrid=""};
            APPCCDangerByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<APPCCDangerByLangsCollectionEditor<APPCCTaskDangerView,APPCCDangerByLangView>,APPCCTaskDangerView,APPCCDangerByLangView>( params_APPCCDangerByLangs,this,Screen.APPCCDangerByLangView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<APPCCTaskDangerView>( "","ul li[rpsid='b1ed344d-a0b8-4b0e-b4c3-ce69b80f1292']","",this);
 
            Controls = RPSControlFactory.CreateRPSSection<APPCCTaskDangerView>( "","ul li[rpsid='784bc3a3-ebf6-4af5-b3c6-f0cced5be0e5']","",this);
 
            Causes = RPSControlFactory.CreateRPSSection<APPCCTaskDangerView>( "","ul li[rpsid='b3676311-ab50-4884-8fb9-91219af2bddf']","",this);
 
            DangerByLangs = RPSControlFactory.CreateRPSSection<APPCCTaskDangerView>( "","ul li[rpsid='edb620e3-d162-4e36-87b1-9245f6e61517']","",this);
 

        }
        public IRPSButton<APPCCTaskDangerView> DeleteButton { get; set; } 
        public IRPSButton<APPCCTaskDangerView,APPCCTaskView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<APPCCTaskDangerView,APPCCTaskView> BackButton { get; set; } 
        public IRPSAcceptButton<APPCCTaskDangerView,APPCCTaskView> AcceptButton { get; set; } 
        public IRPSTextBox<APPCCTaskDangerView> NumDanger { get; set; } 
        public IRPSComboBox<APPCCTaskDangerView> Type { get; set; } 
        public IRPSComboBox<APPCCTaskDangerView> IDPotentialDanger { get; set; } 
        public IRPSTextBox<APPCCTaskDangerView> DangerDescription { get; set; } 
        public IRPSComboBox<APPCCTaskDangerView> Occurrence { get; set; } 
        public IRPSComboBox<APPCCTaskDangerView> Severity { get; set; } 
        public IRPSComboBox<APPCCTaskDangerView> Detection { get; set; } 
        public IRPSComboBox<APPCCTaskDangerView> Punctuation { get; set; } 
        public IRPSCheckbox<APPCCTaskDangerView> ForceControl { get; set; } 
        public IRPSComboBox<APPCCTaskDangerView> Question1 { get; set; } 
        public IRPSComboBox<APPCCTaskDangerView> Question2 { get; set; } 
        public IRPSComboBox<APPCCTaskDangerView> Question3 { get; set; } 
        public IRPSComboBox<APPCCTaskDangerView> Question4 { get; set; } 
        public IRPSComboBox<APPCCTaskDangerView> PointCriticalControl { get; set; } 
        public APPCCControlsCollectionEditor<APPCCTaskDangerView,APPCCDangerByLangView> APPCCControls { get; set; } 
        public APPCCCausesCollectionEditor<APPCCTaskDangerView,APPCCDangerByLangView> APPCCCauses { get; set; } 
        public APPCCDangerByLangsCollectionEditor<APPCCTaskDangerView,APPCCDangerByLangView> APPCCDangerByLangs { get; set; } 
        public IRPSSection<APPCCTaskDangerView> GeneralData { get; set; } 
        public IRPSSection<APPCCTaskDangerView> Controls { get; set; } 
        public IRPSSection<APPCCTaskDangerView> Causes { get; set; } 
        public IRPSSection<APPCCTaskDangerView> DangerByLangs { get; set; } 
        public APPCCVersion Screen { get; set; }
        public APPCCTaskDangerView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class APPCCControlsCollectionEditor<APPCCTaskDangerView,APPCCDangerByLangView>:RPSCollectionEditor<APPCCTaskDangerView,APPCCDangerByLangView> where APPCCTaskDangerView : class, IView where APPCCDangerByLangView : class, IView
    {
        public  APPCCControlsGridView<APPCCTaskDangerView,APPCCDangerByLangView> GridView {get;set;}
    }
    public partial class APPCCControlsGridView <APPCCTaskDangerView,APPCCDangerByLangView> :  RPSGridView<APPCCTaskDangerView,APPCCDangerByLangView> where APPCCTaskDangerView : class, IView where APPCCDangerByLangView : class, IView
    {
        public APPCCControlsGridView(APPCCTaskDangerView currentView,APPCCDangerByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NumControl = RPSControlFactory.CreateRPSGridFormattedTextBox<APPCCTaskDangerView>("","#0527854a-53d9-4ac3-bc78-89b81ada01a7 .ag-row[role='row']@ROWINDEX [col-id='cNumControl']","",true, this.CurrentView);
 
            IDPotentialDangerControl = RPSControlFactory.CreateRPSGridComboBox<APPCCTaskDangerView>("","#0527854a-53d9-4ac3-bc78-89b81ada01a7 .ag-row[role='row']@ROWINDEX [col-id='cIDPotentialDangerControl']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<APPCCTaskDangerView>("","#0527854a-53d9-4ac3-bc78-89b81ada01a7 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<APPCCTaskDangerView> NumControl { get; set; } 
        public IRPSGridComboBox<APPCCTaskDangerView> IDPotentialDangerControl { get; set; } 
        public IRPSGridTextBox<APPCCTaskDangerView> Description { get; set; } 
                     
    }
 
        public partial class APPCCCausesCollectionEditor<APPCCTaskDangerView,APPCCDangerByLangView>:RPSCollectionEditor<APPCCTaskDangerView,APPCCDangerByLangView> where APPCCTaskDangerView : class, IView where APPCCDangerByLangView : class, IView
    {
        public  APPCCCausesGridView<APPCCTaskDangerView,APPCCDangerByLangView> GridView {get;set;}
    }
    public partial class APPCCCausesGridView <APPCCTaskDangerView,APPCCDangerByLangView> :  RPSGridView<APPCCTaskDangerView,APPCCDangerByLangView> where APPCCTaskDangerView : class, IView where APPCCDangerByLangView : class, IView
    {
        public APPCCCausesGridView(APPCCTaskDangerView currentView,APPCCDangerByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NumCause = RPSControlFactory.CreateRPSGridFormattedTextBox<APPCCTaskDangerView>("","#2e5ab434-b3fe-4391-be93-dbc4b6dc60cf .ag-row[role='row']@ROWINDEX [col-id='cNumCause']","",true, this.CurrentView);
 
            IDPotentialDangerCause = RPSControlFactory.CreateRPSGridComboBox<APPCCTaskDangerView>("","#2e5ab434-b3fe-4391-be93-dbc4b6dc60cf .ag-row[role='row']@ROWINDEX [col-id='cIDPotentialDangerCause']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<APPCCTaskDangerView>("","#2e5ab434-b3fe-4391-be93-dbc4b6dc60cf .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<APPCCTaskDangerView> NumCause { get; set; } 
        public IRPSGridComboBox<APPCCTaskDangerView> IDPotentialDangerCause { get; set; } 
        public IRPSGridTextBox<APPCCTaskDangerView> Description { get; set; } 
                     
    }
 
        public partial class APPCCDangerByLangsCollectionEditor<APPCCTaskDangerView,APPCCDangerByLangView>:RPSCollectionEditor<APPCCTaskDangerView,APPCCDangerByLangView> where APPCCTaskDangerView : class, IView where APPCCDangerByLangView : class, IView
    {
        public  APPCCDangerByLangsGridView<APPCCTaskDangerView,APPCCDangerByLangView> GridView {get;set;}
    }
    public partial class APPCCDangerByLangsGridView <APPCCTaskDangerView,APPCCDangerByLangView> :  RPSGridView<APPCCTaskDangerView,APPCCDangerByLangView> where APPCCTaskDangerView : class, IView where APPCCDangerByLangView : class, IView
    {
        public APPCCDangerByLangsGridView(APPCCTaskDangerView currentView,APPCCDangerByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<APPCCTaskDangerView>("","#eb23b96e-49f5-4e5e-b7d3-4286a2621ba2 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            DangerDescription = RPSControlFactory.CreateRPSGridTextBox<APPCCTaskDangerView>("","#eb23b96e-49f5-4e5e-b7d3-4286a2621ba2 .ag-row[role='row']@ROWINDEX [col-id='cDangerDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<APPCCTaskDangerView> CodLanguage { get; set; } 
        public IRPSGridTextBox<APPCCTaskDangerView> DangerDescription { get; set; } 
                     
    }
 
    }
  
            
    public partial class APPCCControlView : View
    {
        public APPCCControlView(APPCCVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<APPCCControlView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<APPCCControlView,APPCCTaskDangerView>( this,Screen.APPCCTaskDangerView);
 
            BackButton = RPSControlFactory.RPSBackButton<APPCCControlView,APPCCTaskDangerView>( this,Screen.APPCCTaskDangerView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<APPCCControlView,APPCCTaskDangerView>( this,Screen.APPCCTaskDangerView);
 
            NumControl = RPSControlFactory.CreateRPSFormattedTextBox<APPCCControlView>("6832cb88-674d-4858-a07b-1441fa0f42f8","","",true, this);
 
            IDPotentialDangerControl = RPSControlFactory.CreateRPSComboBox<APPCCControlView>("90f1c8ec-febb-4795-81b5-39d81effccae","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<APPCCControlView>("ed3cb3f9-6bac-4a3a-a3de-43dcb88987d3","","",false, this);
 
            CollectionInit params_APPCCControlByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1ec7e0d4-a7f9-4550-894c-109982b96479",CSSSelectorGrid="",XPathGrid=""};
            APPCCControlByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<APPCCControlByLangsCollectionEditor<APPCCControlView,APPCCControlByLangView>,APPCCControlView,APPCCControlByLangView>( params_APPCCControlByLangs,this,Screen.APPCCControlByLangView);
 

        }
        public IRPSButton<APPCCControlView> DeleteButton { get; set; } 
        public IRPSButton<APPCCControlView,APPCCTaskDangerView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<APPCCControlView,APPCCTaskDangerView> BackButton { get; set; } 
        public IRPSAcceptButton<APPCCControlView,APPCCTaskDangerView> AcceptButton { get; set; } 
        public IRPSTextBox<APPCCControlView> NumControl { get; set; } 
        public IRPSComboBox<APPCCControlView> IDPotentialDangerControl { get; set; } 
        public IRPSTextBox<APPCCControlView> Description { get; set; } 
        public APPCCControlByLangsCollectionEditor<APPCCControlView,APPCCControlByLangView> APPCCControlByLangs { get; set; } 
        public APPCCVersion Screen { get; set; }
        public APPCCControlView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class APPCCControlByLangsCollectionEditor<APPCCControlView,APPCCControlByLangView>:RPSCollectionEditor<APPCCControlView,APPCCControlByLangView> where APPCCControlView : class, IView where APPCCControlByLangView : class, IView
    {
        public  APPCCControlByLangsGridView<APPCCControlView,APPCCControlByLangView> GridView {get;set;}
    }
    public partial class APPCCControlByLangsGridView <APPCCControlView,APPCCControlByLangView> :  RPSGridView<APPCCControlView,APPCCControlByLangView> where APPCCControlView : class, IView where APPCCControlByLangView : class, IView
    {
        public APPCCControlByLangsGridView(APPCCControlView currentView,APPCCControlByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<APPCCControlView>("","#1ec7e0d4-a7f9-4550-894c-109982b96479 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<APPCCControlView>("","#1ec7e0d4-a7f9-4550-894c-109982b96479 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<APPCCControlView> CodLanguage { get; set; } 
        public IRPSGridTextBox<APPCCControlView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class APPCCCauseView : View
    {
        public APPCCCauseView(APPCCVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<APPCCCauseView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<APPCCCauseView,APPCCTaskDangerView>( this,Screen.APPCCTaskDangerView);
 
            BackButton = RPSControlFactory.RPSBackButton<APPCCCauseView,APPCCTaskDangerView>( this,Screen.APPCCTaskDangerView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<APPCCCauseView,APPCCTaskDangerView>( this,Screen.APPCCTaskDangerView);
 
            NumCause = RPSControlFactory.CreateRPSFormattedTextBox<APPCCCauseView>("fc1f32b1-7259-4ced-bc19-f2778e54f6fa","","",true, this);
 
            IDPotentialDangerCause = RPSControlFactory.CreateRPSComboBox<APPCCCauseView>("8d1a8e71-dc30-4738-8455-750d3b661554","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<APPCCCauseView>("b6725db6-4ec1-4da1-a955-319b49e1eb99","","",false, this);
 
            CollectionInit params_APPCCCauseByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5307d8e9-515b-4d8c-b4cf-57f35b05f5be",CSSSelectorGrid="",XPathGrid=""};
            APPCCCauseByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<APPCCCauseByLangsCollectionEditor<APPCCCauseView,APPCCCauseByLangView>,APPCCCauseView,APPCCCauseByLangView>( params_APPCCCauseByLangs,this,Screen.APPCCCauseByLangView);
 

        }
        public IRPSButton<APPCCCauseView> DeleteButton { get; set; } 
        public IRPSButton<APPCCCauseView,APPCCTaskDangerView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<APPCCCauseView,APPCCTaskDangerView> BackButton { get; set; } 
        public IRPSAcceptButton<APPCCCauseView,APPCCTaskDangerView> AcceptButton { get; set; } 
        public IRPSTextBox<APPCCCauseView> NumCause { get; set; } 
        public IRPSComboBox<APPCCCauseView> IDPotentialDangerCause { get; set; } 
        public IRPSTextBox<APPCCCauseView> Description { get; set; } 
        public APPCCCauseByLangsCollectionEditor<APPCCCauseView,APPCCCauseByLangView> APPCCCauseByLangs { get; set; } 
        public APPCCVersion Screen { get; set; }
        public APPCCCauseView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class APPCCCauseByLangsCollectionEditor<APPCCCauseView,APPCCCauseByLangView>:RPSCollectionEditor<APPCCCauseView,APPCCCauseByLangView> where APPCCCauseView : class, IView where APPCCCauseByLangView : class, IView
    {
        public  APPCCCauseByLangsGridView<APPCCCauseView,APPCCCauseByLangView> GridView {get;set;}
    }
    public partial class APPCCCauseByLangsGridView <APPCCCauseView,APPCCCauseByLangView> :  RPSGridView<APPCCCauseView,APPCCCauseByLangView> where APPCCCauseView : class, IView where APPCCCauseByLangView : class, IView
    {
        public APPCCCauseByLangsGridView(APPCCCauseView currentView,APPCCCauseByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<APPCCCauseView>("","#5307d8e9-515b-4d8c-b4cf-57f35b05f5be .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<APPCCCauseView>("","#5307d8e9-515b-4d8c-b4cf-57f35b05f5be .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<APPCCCauseView> CodLanguage { get; set; } 
        public IRPSGridTextBox<APPCCCauseView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class PrintOptionsDialogView : View
    {
        public PrintOptionsDialogView(APPCCVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDCustomerToPrint = RPSControlFactory.CreateRPSComboBox<PrintOptionsDialogView>("bc9d7c1a-e130-4762-8ee3-d2109c553850","","",false, this);
 
            CodLanguagePrint = RPSControlFactory.CreateRPSComboBox<PrintOptionsDialogView>("5ecea377-d1c0-4bb9-8f07-b15bce57779e","","",false, this);
 
            IDRouteToPrint = RPSControlFactory.CreateRPSComboBox<PrintOptionsDialogView>("05c5f034-4a64-463a-b4ac-b8037d61dec6","","",false, this);
 
            APPCCStandard = RPSControlFactory.CreateRPSOption<PrintOptionsDialogView>( "dd86cec2-ce4a-4daa-bd10-3f3c5a9a857b","","",this);
 
            CustomAPPCCReport = RPSControlFactory.CreateRPSOption<PrintOptionsDialogView>( "44267a5f-047a-4023-935d-1a626a0cb329","","",this);
 
            IDAPPCCCustomReport = RPSControlFactory.CreateRPSComboBox<PrintOptionsDialogView>("14963908-3ff1-450b-afc1-3420d83595c6","","",false, this);
 
            AddAttachments = RPSControlFactory.CreateRPSCheckBox<PrintOptionsDialogView>("98613581-9860-4137-b7af-73bd4fd0c837","","",false, this);
 
            OpenAPPCCReportCommandButton = RPSControlFactory.CreateRPSButton<PrintOptionsDialogView>( "7ad27295-b49f-4b25-8a63-a1e59ea8cf15","","",this);
 
            ExecuteAPPCCVersionReportByEMailButton = RPSControlFactory.CreateRPSButton<PrintOptionsDialogView>( "4bfa10a5-30f2-432a-a60c-da24fbe44468","","",this);
 
            APPCCReportByClientEmailCommandButton = RPSControlFactory.CreateRPSButton<PrintOptionsDialogView>( "f473a3b9-9d3c-4747-a3ac-ae82ad796d44","","",this);
 

        }
        public IRPSComboBox<PrintOptionsDialogView> IDCustomerToPrint { get; set; } 
        public IRPSComboBox<PrintOptionsDialogView> CodLanguagePrint { get; set; } 
        public IRPSComboBox<PrintOptionsDialogView> IDRouteToPrint { get; set; } 
        public IRPSOption<PrintOptionsDialogView> APPCCStandard { get; set; } 
        public IRPSOption<PrintOptionsDialogView> CustomAPPCCReport { get; set; } 
        public IRPSComboBox<PrintOptionsDialogView> IDAPPCCCustomReport { get; set; } 
        public IRPSCheckbox<PrintOptionsDialogView> AddAttachments { get; set; } 
        public IRPSButton<PrintOptionsDialogView> OpenAPPCCReportCommandButton { get; set; } 
        public IRPSButton<PrintOptionsDialogView> ExecuteAPPCCVersionReportByEMailButton { get; set; } 
        public IRPSButton<PrintOptionsDialogView> APPCCReportByClientEmailCommandButton { get; set; } 
        public APPCCVersion Screen { get; set; }
        public PrintOptionsDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class RejectAPPCCVersionDialogView : View
    {
        public RejectAPPCCVersionDialogView(APPCCVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            RejectionDate = RPSControlFactory.CreateRPSTextBox<RejectAPPCCVersionDialogView>("65c9e7c0-f61c-4b81-bd94-15ae4bdcd4c6","","",true, this);
 
            RejectionReason = RPSControlFactory.CreateRPSTextBox<RejectAPPCCVersionDialogView>("378b18d9-82ff-4098-9740-a19ca9d7ebfd","","",true, this);
 

        }
        public IRPSTextBox<RejectAPPCCVersionDialogView> RejectionDate { get; set; } 
        public IRPSTextBox<RejectAPPCCVersionDialogView> RejectionReason { get; set; } 
        public APPCCVersion Screen { get; set; }
        public RejectAPPCCVersionDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class RejectionHistoryDialogView : View
    {
        public RejectionHistoryDialogView(APPCCVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_GetDocumentRejections = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="9c574c0e-f405-406b-882e-1c96b19b475f",CSSSelectorGrid="",XPathGrid=""};
            GetDocumentRejections = RPSControlFactory.RPSCreateCollectionWithGrid<GetDocumentRejectionsCollectionEditor<RejectionHistoryDialogView>,RejectionHistoryDialogView>( params_GetDocumentRejections,this);
 

        }
        public GetDocumentRejectionsCollectionEditor<RejectionHistoryDialogView> GetDocumentRejections { get; set; } 
        public APPCCVersion Screen { get; set; }
        public RejectionHistoryDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetDocumentRejectionsCollectionEditor<RejectionHistoryDialogView>:RPSCollectionEditor<RejectionHistoryDialogView> where RejectionHistoryDialogView : class, IView
    {
        public  GetDocumentRejectionsGridView<RejectionHistoryDialogView> GridView {get;set;}
    }
    public partial class GetDocumentRejectionsGridView <RejectionHistoryDialogView> :  RPSGridView<RejectionHistoryDialogView> where RejectionHistoryDialogView : class, IView
    {
        public GetDocumentRejectionsGridView(RejectionHistoryDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            VersionStatusFlow_DoneDate = RPSControlFactory.CreateRPSGridTextBox<RejectionHistoryDialogView>("","#9c574c0e-f405-406b-882e-1c96b19b475f .ag-row[role='row']@ROWINDEX [col-id='cVersionStatusFlow_DoneDate']","",false, this.CurrentView);
 
            VersionStatusFlow_RejectionReason = RPSControlFactory.CreateRPSGridMemoTextBox<RejectionHistoryDialogView>("","#9c574c0e-f405-406b-882e-1c96b19b475f .ag-row[role='row']@ROWINDEX [col-id='cVersionStatusFlow_RejectionReason']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<RejectionHistoryDialogView> VersionStatusFlow_DoneDate { get; set; } 
        public IRPSGridTextBox<RejectionHistoryDialogView> VersionStatusFlow_RejectionReason { get; set; } 
                     
    }
 
    }
  
            
    public partial class CopyFromOtherAPPCCDialogView : View
    {
        public CopyFromOtherAPPCCDialogView(APPCCVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSComboBox<CopyFromOtherAPPCCDialogView>("43129b16-1640-43f0-87c7-258546d80884","","",false, this);
 
            IDStructure = RPSControlFactory.CreateRPSComboBox<CopyFromOtherAPPCCDialogView>("636116ae-d0ed-4bf1-8676-8dd71c97a9a2","","",false, this);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<CopyFromOtherAPPCCDialogView>("1f243789-74dc-47cf-9d55-41a0df799958","","",false, this);
 
            IDAPPCCVersion = RPSControlFactory.CreateRPSComboBox<CopyFromOtherAPPCCDialogView>("3e65440c-3297-4b27-971d-988aaa08cd42","","",false, this);
 

        }
        public IRPSComboBox<CopyFromOtherAPPCCDialogView> IDArticle { get; set; } 
        public IRPSComboBox<CopyFromOtherAPPCCDialogView> IDStructure { get; set; } 
        public IRPSComboBox<CopyFromOtherAPPCCDialogView> IDProject { get; set; } 
        public IRPSComboBox<CopyFromOtherAPPCCDialogView> IDAPPCCVersion { get; set; } 
        public APPCCVersion Screen { get; set; }
        public CopyFromOtherAPPCCDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class APPCCDangerByLangView : View
    {
        public APPCCDangerByLangView(APPCCVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<APPCCDangerByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<APPCCDangerByLangView,APPCCTaskDangerView>( this,Screen.APPCCTaskDangerView);
 
            BackButton = RPSControlFactory.RPSBackButton<APPCCDangerByLangView,APPCCTaskDangerView>( this,Screen.APPCCTaskDangerView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<APPCCDangerByLangView,APPCCTaskDangerView>( this,Screen.APPCCTaskDangerView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<APPCCDangerByLangView>("5ca84d50-e486-4ec9-a584-9a488724fdd4","","",true, this);
 
            DangerDescription = RPSControlFactory.CreateRPSTextBox<APPCCDangerByLangView>("078682cb-4097-481e-afcf-d2d18a66b98c","","",false, this);
 

        }
        public IRPSButton<APPCCDangerByLangView> DeleteButton { get; set; } 
        public IRPSButton<APPCCDangerByLangView,APPCCTaskDangerView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<APPCCDangerByLangView,APPCCTaskDangerView> BackButton { get; set; } 
        public IRPSAcceptButton<APPCCDangerByLangView,APPCCTaskDangerView> AcceptButton { get; set; } 
        public IRPSComboBox<APPCCDangerByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<APPCCDangerByLangView> DangerDescription { get; set; } 
        public APPCCVersion Screen { get; set; }
        public APPCCDangerByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class APPCCControlByLangView : View
    {
        public APPCCControlByLangView(APPCCVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<APPCCControlByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<APPCCControlByLangView,APPCCControlView>( this,Screen.APPCCControlView);
 
            BackButton = RPSControlFactory.RPSBackButton<APPCCControlByLangView,APPCCControlView>( this,Screen.APPCCControlView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<APPCCControlByLangView,APPCCControlView>( this,Screen.APPCCControlView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<APPCCControlByLangView>("02cfc326-991d-41fe-906b-304f1f72f4d1","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<APPCCControlByLangView>("f2c67e0e-cd54-4ba6-8718-23eb23c74def","","",false, this);
 

        }
        public IRPSButton<APPCCControlByLangView> DeleteButton { get; set; } 
        public IRPSButton<APPCCControlByLangView,APPCCControlView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<APPCCControlByLangView,APPCCControlView> BackButton { get; set; } 
        public IRPSAcceptButton<APPCCControlByLangView,APPCCControlView> AcceptButton { get; set; } 
        public IRPSComboBox<APPCCControlByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<APPCCControlByLangView> Description { get; set; } 
        public APPCCVersion Screen { get; set; }
        public APPCCControlByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class APPCCCauseByLangView : View
    {
        public APPCCCauseByLangView(APPCCVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<APPCCCauseByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<APPCCCauseByLangView,APPCCCauseView>( this,Screen.APPCCCauseView);
 
            BackButton = RPSControlFactory.RPSBackButton<APPCCCauseByLangView,APPCCCauseView>( this,Screen.APPCCCauseView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<APPCCCauseByLangView,APPCCCauseView>( this,Screen.APPCCCauseView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<APPCCCauseByLangView>("439f2f20-86fb-4de7-9be6-c58ecc81f9e6","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<APPCCCauseByLangView>("acbcda98-d8d9-45d4-8955-73738055b6dc","","",false, this);
 

        }
        public IRPSButton<APPCCCauseByLangView> DeleteButton { get; set; } 
        public IRPSButton<APPCCCauseByLangView,APPCCCauseView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<APPCCCauseByLangView,APPCCCauseView> BackButton { get; set; } 
        public IRPSAcceptButton<APPCCCauseByLangView,APPCCCauseView> AcceptButton { get; set; } 
        public IRPSComboBox<APPCCCauseByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<APPCCCauseByLangView> Description { get; set; } 
        public APPCCVersion Screen { get; set; }
        public APPCCCauseByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class APPCCTaskByLangView : View
    {
        public APPCCTaskByLangView(APPCCVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<APPCCTaskByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<APPCCTaskByLangView,APPCCVersionEntityView>( this,Screen.APPCCVersionEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<APPCCTaskByLangView,APPCCVersionEntityView>( this,Screen.APPCCVersionEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<APPCCTaskByLangView,APPCCVersionEntityView>( this,Screen.APPCCVersionEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<APPCCTaskByLangView>("f49da0ae-adc1-4e15-a84a-21ed1c98a3a8","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<APPCCTaskByLangView>("cf953f1f-db83-498c-aa49-9593ce48d7a4","","",false, this);
 

        }
        public IRPSButton<APPCCTaskByLangView> DeleteButton { get; set; } 
        public IRPSButton<APPCCTaskByLangView,APPCCVersionEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<APPCCTaskByLangView,APPCCVersionEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<APPCCTaskByLangView,APPCCVersionEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<APPCCTaskByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<APPCCTaskByLangView> Description { get; set; } 
        public APPCCVersion Screen { get; set; }
        public APPCCTaskByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}