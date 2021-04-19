    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.FMEAVersion
{
    //RPS VERSION 1.0.0.0
    public partial class FMEAVersion:Screen
    {
        public FMEAVersion():base()
        {
            this.URL = "quality.fmeaversion";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            FMEAVersionCollectionView  = new FMEAVersionCollectionView(this); 
            FMEAVersionEntityView  = new FMEAVersionEntityView(this); 
            FMEATaskView  = new FMEATaskView(this); 
            FMEAFailureModeView  = new FMEAFailureModeView(this); 
            FMEAEffectView  = new FMEAEffectView(this); 
            FMEACauseView  = new FMEACauseView(this); 
            FMEAEffectByLangView  = new FMEAEffectByLangView(this); 
            FMEACauseByLangView  = new FMEACauseByLangView(this); 
            FMEAFailureModeByLangView  = new FMEAFailureModeByLangView(this); 
            FMEACoreTeamView  = new FMEACoreTeamView(this); 
            FMEADailyActivityView  = new FMEADailyActivityView(this); 
            FMEABalanceView  = new FMEABalanceView(this); 
            RejectFMEAVersionDialogView  = new RejectFMEAVersionDialogView(this); 
            CopyFromOtherFMEADialogView  = new CopyFromOtherFMEADialogView(this); 
            PrintFMEAVersionOptionsDialogView  = new PrintFMEAVersionOptionsDialogView(this); 
            RejectionHistoryDialogView  = new RejectionHistoryDialogView(this); 
            FMEATaskByLangView  = new FMEATaskByLangView(this); 
            FMEAVersionCollectionView.InitializeControls(); 
            FMEAVersionEntityView.InitializeControls(); 
            FMEATaskView.InitializeControls(); 
            FMEAFailureModeView.InitializeControls(); 
            FMEAEffectView.InitializeControls(); 
            FMEACauseView.InitializeControls(); 
            FMEAEffectByLangView.InitializeControls(); 
            FMEACauseByLangView.InitializeControls(); 
            FMEAFailureModeByLangView.InitializeControls(); 
            FMEACoreTeamView.InitializeControls(); 
            FMEADailyActivityView.InitializeControls(); 
            FMEABalanceView.InitializeControls(); 
            RejectFMEAVersionDialogView.InitializeControls(); 
            CopyFromOtherFMEADialogView.InitializeControls(); 
            PrintFMEAVersionOptionsDialogView.InitializeControls(); 
            RejectionHistoryDialogView.InitializeControls(); 
            FMEATaskByLangView.InitializeControls(); 
           
        }
      
            public FMEAVersionCollectionView FMEAVersionCollectionView {get; set; } 
            public FMEAVersionEntityView FMEAVersionEntityView {get; set; } 
            public FMEATaskView FMEATaskView {get; set; } 
            public FMEAFailureModeView FMEAFailureModeView {get; set; } 
            public FMEAEffectView FMEAEffectView {get; set; } 
            public FMEACauseView FMEACauseView {get; set; } 
            public FMEAEffectByLangView FMEAEffectByLangView {get; set; } 
            public FMEACauseByLangView FMEACauseByLangView {get; set; } 
            public FMEAFailureModeByLangView FMEAFailureModeByLangView {get; set; } 
            public FMEACoreTeamView FMEACoreTeamView {get; set; } 
            public FMEADailyActivityView FMEADailyActivityView {get; set; } 
            public FMEABalanceView FMEABalanceView {get; set; } 
            public RejectFMEAVersionDialogView RejectFMEAVersionDialogView {get; set; } 
            public CopyFromOtherFMEADialogView CopyFromOtherFMEADialogView {get; set; } 
            public PrintFMEAVersionOptionsDialogView PrintFMEAVersionOptionsDialogView {get; set; } 
            public RejectionHistoryDialogView RejectionHistoryDialogView {get; set; } 
            public FMEATaskByLangView FMEATaskByLangView {get; set; } 
    }
            
    public partial class FMEAVersionCollectionView : View
    {
        public FMEAVersionCollectionView(FMEAVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<FMEAVersionCollectionView,FMEAVersionEntityView>( this,Screen.FMEAVersionEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "47126025-6f1d-4a45-92a7-f44ae3bec25d",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<FMEAVersionCollectionView,FMEAVersionEntityView>( params_MainConsult,this,Screen.FMEAVersionEntityView);
 

        }
        public IRPSButton<FMEAVersionCollectionView,FMEAVersionEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<FMEAVersionCollectionView,FMEAVersionEntityView> MainConsult { get; set; } 
        public FMEAVersion Screen { get; set; }
        public FMEAVersionCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FMEAVersionEntityView : View
    {
        public FMEAVersionEntityView(FMEAVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<FMEAVersionEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<FMEAVersionEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FMEAVersionEntityView,FMEAVersionCollectionView>( this,Screen.FMEAVersionCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<FMEAVersionEntityView,FMEAVersionCollectionView>( this,Screen.FMEAVersionCollectionView);
 
            UIIDSite = RPSControlFactory.CreateRPSComboBox<FMEAVersionEntityView>("93ac128c-9c5a-401c-a473-e9675e0ef8ab","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<FMEAVersionEntityView>("de47a0c6-620b-43fc-8c31-29f240625784","","",true, this);
 
            IDStructureManufacturing = RPSControlFactory.CreateRPSComboBox<FMEAVersionEntityView>("bbe5454b-724b-48ab-9264-6e58c256c4d3","","",false, this);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<FMEAVersionEntityView>("090d228f-937d-4d0b-8278-5baecbe7f12d","","",false, this);
 
            IDArticleVersion = RPSControlFactory.CreateRPSComboBox<FMEAVersionEntityView>("1e68d25e-c7bb-4901-bb00-141ff40ceb6e","","",false, this);
 
            UIIDArticleVersionSample = RPSControlFactory.CreateRPSComboBox<FMEAVersionEntityView>("03cc758d-78bf-4980-80f3-44afbf42696b","","",false, this);
 
            Version = RPSControlFactory.CreateRPSTextBox<FMEAVersionEntityView>("a341567f-5cf8-40c4-a56e-d2b5b784eefe","","",true, this);
 
            FMEANumber = RPSControlFactory.CreateRPSTextBox<FMEAVersionEntityView>("efa21514-0c0d-424f-9d46-72396791750b","","",true, this);
 
            FMEAType = RPSControlFactory.CreateRPSEnumComboBox<FMEAVersionEntityView>("c238c003-91ff-42d5-98c1-933e61568311","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<FMEAVersionEntityView>("b8e915fb-b6f1-48c8-b5d9-7583c5f42887","","",false, this);
 
            DoneDate = RPSControlFactory.CreateRPSTextBox<FMEAVersionEntityView>("c1431506-0dee-44a8-8b74-447958ae651e","","",true, this);
 
            CodUserDoneBy = RPSControlFactory.CreateRPSComboBox<FMEAVersionEntityView>("bb7c004f-7404-4093-af45-2a7f23e70c21","","",true, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<FMEAVersionEntityView>("7c613adc-5ec8-4763-aafd-7a73dcdb5d13","","",false, this);
 
            CustLevelAndDate = RPSControlFactory.CreateRPSTextBox<FMEAVersionEntityView>("8dc12c52-27fb-4b6b-a821-d436b30df386","","",false, this);
 
            EndDate = RPSControlFactory.CreateRPSTextBox<FMEAVersionEntityView>("7dfc3aab-77a2-4f17-b671-a2f6c69afc2a","","",false, this);
 
            CodUserEnd = RPSControlFactory.CreateRPSComboBox<FMEAVersionEntityView>("8c8155a6-8b6a-4231-a3b0-5cbf86a38285","","",false, this);
 
            ApprovedDate = RPSControlFactory.CreateRPSTextBox<FMEAVersionEntityView>("cfcb90ec-e97d-40a2-87ba-20c5d053b519","","",false, this);
 
            CodUserApprovedBy = RPSControlFactory.CreateRPSComboBox<FMEAVersionEntityView>("04acf253-066f-40e8-9902-25b9742b9400","","",false, this);
 
            RPNMax = RPSControlFactory.CreateRPSFormattedTextBox<FMEAVersionEntityView>("6b0a052f-80d9-43e6-ae7a-5379b36441e8","","",false, this);
 
            UIPendingLabel = RPSControlFactory.CreateRPSTextBox<FMEAVersionEntityView>("bf1f0c1d-e03e-46e0-9d38-29ce36a56c62","","",false, this);
 
            PendingRevisionCause = RPSControlFactory.CreateRPSTextBox<FMEAVersionEntityView>("3336fb01-85cf-4598-a8c9-74af2291580b","","",false, this);
 
            RejectionUser = RPSControlFactory.CreateRPSComboBox<FMEAVersionEntityView>("7e112b1f-8601-47f3-81c7-70141ef1e0b4","","",false, this);
 
            RejectionDate = RPSControlFactory.CreateRPSTextBox<FMEAVersionEntityView>("bb089a4d-495a-44ca-9471-eaf65a09d2b5","","",false, this);
 
            RejectionReason = RPSControlFactory.CreateRPSTextBox<FMEAVersionEntityView>("aa363f2d-7dbb-4f37-af8b-81c4c160a8ef","","",false, this);
 
            CauseWeighting = RPSControlFactory.CreateRPSEnumComboBox<FMEAVersionEntityView>("e91a8fa1-7dc6-47fd-94e6-35fd890f957b","","",false, this);
 
            UIIDRoute = RPSControlFactory.CreateRPSComboBox<FMEAVersionEntityView>("3494c7c5-6f30-4d7d-bb2e-61bcaadcedf6","","",false, this);
 
            PrintOptionsCommandButton = RPSControlFactory.CreateRPSButtonToView<FMEAVersionEntityView,PrintFMEAVersionOptionsDialogView>("ab8203c8-8fb9-498e-ada8-d4d12fcef08e","","", this,Screen.PrintFMEAVersionOptionsDialogView);
 
            FinalizeCommandButton = RPSControlFactory.CreateRPSButton<FMEAVersionEntityView>( "32e8b30c-4f2d-441f-bc66-5a775e869467","","",this);
 
            ApprovalCommandButton = RPSControlFactory.CreateRPSButton<FMEAVersionEntityView>( "ce11f331-63bb-45d1-bf2d-d807c41f263f","","",this);
 
            RejectCommandButton = RPSControlFactory.CreateRPSButtonToView<FMEAVersionEntityView,RejectFMEAVersionDialogView>("0ad73932-94a7-4b29-b78a-af4d5c83216b","","", this,Screen.RejectFMEAVersionDialogView);
 
            ReceiptCommandButton = RPSControlFactory.CreateRPSButton<FMEAVersionEntityView>( "2b07e8b2-9ac6-4747-85e3-6ee99b4b5ed6","","",this);
 
            ReviseCommandButton = RPSControlFactory.CreateRPSButton<FMEAVersionEntityView>( "380886fb-dc6b-430f-9e7b-4f9dc6cc01d4","","",this);
 
            ShowRejectionsCommandButton = RPSControlFactory.CreateRPSButtonToView<FMEAVersionEntityView,RejectionHistoryDialogView>("b6265cde-9f8c-42d5-8698-791387d9122a","","", this,Screen.RejectionHistoryDialogView);
 
            ImportDataFromUsualTasksCommandButton = RPSControlFactory.CreateRPSButton<FMEAVersionEntityView>( "62bb1f21-ad53-414f-a4ef-5de7a20496d2","","",this);
 
            CopyFromOtherFMEACommandButton = RPSControlFactory.CreateRPSButtonToView<FMEAVersionEntityView,CopyFromOtherFMEADialogView>("0bd2e9a2-f4ac-451d-a7d0-f75ccf516b56","","", this,Screen.CopyFromOtherFMEADialogView);
 
            CollectionInit params_FMEATasks = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7993b144-773d-4d42-8ff5-1c85bdf467c1",CSSSelectorGrid="",XPathGrid=""};
            FMEATasks = RPSControlFactory.RPSCreateCollectionWithGrid<FMEATasksCollectionEditor<FMEAVersionEntityView,FMEATaskView>,FMEAVersionEntityView,FMEATaskView>( params_FMEATasks,this,Screen.FMEATaskView);
 
            CollectionInit params_MaterialsWithFMEAVersion = new CollectionInit(){IDDescriptor = "80d4959c-e1f9-45a8-9e30-f8005c6d1244",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="05030dac-f544-4345-9ce9-293b3ddf6b52",CSSSelectorGrid="",XPathGrid=""};
            MaterialsWithFMEAVersion = RPSControlFactory.RPSCreateCollectionWithGrid<MaterialsWithFMEAVersionCollectionEditor<FMEAVersionEntityView,FMEATaskView>,FMEAVersionEntityView,FMEATaskView>( params_MaterialsWithFMEAVersion,this,Screen.FMEATaskView);
 
            CollectionInit params_FMEACoreTeams = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="2abd33e0-534b-4897-9c4b-0cb6ee772f85",CSSSelectorGrid="",XPathGrid=""};
            FMEACoreTeams = RPSControlFactory.RPSCreateCollectionWithGrid<FMEACoreTeamsCollectionEditor<FMEAVersionEntityView,FMEATaskView>,FMEAVersionEntityView,FMEATaskView>( params_FMEACoreTeams,this,Screen.FMEATaskView);
 
            CollectionInit params_FMEADailyActivitys = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="41dd78f7-82e5-49aa-a185-4133baccc88d",CSSSelectorGrid="",XPathGrid=""};
            FMEADailyActivitys = RPSControlFactory.RPSCreateCollectionWithGrid<FMEADailyActivitysCollectionEditor<FMEAVersionEntityView,FMEATaskView>,FMEAVersionEntityView,FMEATaskView>( params_FMEADailyActivitys,this,Screen.FMEATaskView);
 
            CollectionInit params_FMEABalances = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f21cb44e-a23f-4945-ad4f-29bc3444400c",CSSSelectorGrid="",XPathGrid=""};
            FMEABalances = RPSControlFactory.RPSCreateCollectionWithGrid<FMEABalancesCollectionEditor<FMEAVersionEntityView,FMEATaskView>,FMEAVersionEntityView,FMEATaskView>( params_FMEABalances,this,Screen.FMEATaskView);
 
            FMEATask = RPSControlFactory.CreateRPSSection<FMEAVersionEntityView>( "","ul li[rpsid='9c25c668-6ed2-4909-8e53-faaeba0c38c3']","",this);
 
            MaterialsWithFMEA = RPSControlFactory.CreateRPSSection<FMEAVersionEntityView>( "","ul li[rpsid='7df3e0a4-9146-41ca-a707-7c4a587ab908']","",this);
 
            Structure = RPSControlFactory.CreateRPSSection<FMEAVersionEntityView>( "","ul li[rpsid='a924ac8b-9d43-4a0e-b58e-002c43c85333']","",this);
 
            CoreTeams = RPSControlFactory.CreateRPSSection<FMEAVersionEntityView>( "","ul li[rpsid='9724d9f0-36a7-49b3-8736-76b47f5ac331']","",this);
 
            DailyActivities = RPSControlFactory.CreateRPSSection<FMEAVersionEntityView>( "","ul li[rpsid='cc68af55-93b5-4e85-add5-2fd4a992e924']","",this);
 
            Balance = RPSControlFactory.CreateRPSSection<FMEAVersionEntityView>( "","ul li[rpsid='6e5ae48f-a83b-466f-a88e-69e480924ff9']","",this);
 

        }
        public IRPSSaveButton<FMEAVersionEntityView> SaveButton { get; set; } 
        public IRPSButton<FMEAVersionEntityView> DeleteButton { get; set; } 
        public IRPSButton<FMEAVersionEntityView,FMEAVersionCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FMEAVersionEntityView,FMEAVersionCollectionView> BackButton { get; set; } 
        public IRPSComboBox<FMEAVersionEntityView> UIIDSite { get; set; } 
        public IRPSComboBox<FMEAVersionEntityView> IDArticle { get; set; } 
        public IRPSComboBox<FMEAVersionEntityView> IDStructureManufacturing { get; set; } 
        public IRPSComboBox<FMEAVersionEntityView> IDProject { get; set; } 
        public IRPSComboBox<FMEAVersionEntityView> IDArticleVersion { get; set; } 
        public IRPSComboBox<FMEAVersionEntityView> UIIDArticleVersionSample { get; set; } 
        public IRPSTextBox<FMEAVersionEntityView> Version { get; set; } 
        public IRPSTextBox<FMEAVersionEntityView> FMEANumber { get; set; } 
        public IRPSComboBox<FMEAVersionEntityView> FMEAType { get; set; } 
        public IRPSTextBox<FMEAVersionEntityView> Description { get; set; } 
        public IRPSTextBox<FMEAVersionEntityView> DoneDate { get; set; } 
        public IRPSComboBox<FMEAVersionEntityView> CodUserDoneBy { get; set; } 
        public IRPSComboBox<FMEAVersionEntityView> IDCustomer { get; set; } 
        public IRPSTextBox<FMEAVersionEntityView> CustLevelAndDate { get; set; } 
        public IRPSTextBox<FMEAVersionEntityView> EndDate { get; set; } 
        public IRPSComboBox<FMEAVersionEntityView> CodUserEnd { get; set; } 
        public IRPSTextBox<FMEAVersionEntityView> ApprovedDate { get; set; } 
        public IRPSComboBox<FMEAVersionEntityView> CodUserApprovedBy { get; set; } 
        public IRPSTextBox<FMEAVersionEntityView> RPNMax { get; set; } 
        public IRPSTextBox<FMEAVersionEntityView> UIPendingLabel { get; set; } 
        public IRPSTextBox<FMEAVersionEntityView> PendingRevisionCause { get; set; } 
        public IRPSComboBox<FMEAVersionEntityView> RejectionUser { get; set; } 
        public IRPSTextBox<FMEAVersionEntityView> RejectionDate { get; set; } 
        public IRPSTextBox<FMEAVersionEntityView> RejectionReason { get; set; } 
        public IRPSComboBox<FMEAVersionEntityView> CauseWeighting { get; set; } 
        public IRPSComboBox<FMEAVersionEntityView> UIIDRoute { get; set; } 
        public IRPSButton<FMEAVersionEntityView,PrintFMEAVersionOptionsDialogView> PrintOptionsCommandButton { get; set; } 
        public IRPSButton<FMEAVersionEntityView> FinalizeCommandButton { get; set; } 
        public IRPSButton<FMEAVersionEntityView> ApprovalCommandButton { get; set; } 
        public IRPSButton<FMEAVersionEntityView,RejectFMEAVersionDialogView> RejectCommandButton { get; set; } 
        public IRPSButton<FMEAVersionEntityView> ReceiptCommandButton { get; set; } 
        public IRPSButton<FMEAVersionEntityView> ReviseCommandButton { get; set; } 
        public IRPSButton<FMEAVersionEntityView,RejectionHistoryDialogView> ShowRejectionsCommandButton { get; set; } 
        public IRPSButton<FMEAVersionEntityView> ImportDataFromUsualTasksCommandButton { get; set; } 
        public IRPSButton<FMEAVersionEntityView,CopyFromOtherFMEADialogView> CopyFromOtherFMEACommandButton { get; set; } 
        public FMEATasksCollectionEditor<FMEAVersionEntityView,FMEATaskView> FMEATasks { get; set; } 
        public MaterialsWithFMEAVersionCollectionEditor<FMEAVersionEntityView,FMEATaskView> MaterialsWithFMEAVersion { get; set; } 
        public FMEACoreTeamsCollectionEditor<FMEAVersionEntityView,FMEATaskView> FMEACoreTeams { get; set; } 
        public FMEADailyActivitysCollectionEditor<FMEAVersionEntityView,FMEATaskView> FMEADailyActivitys { get; set; } 
        public FMEABalancesCollectionEditor<FMEAVersionEntityView,FMEATaskView> FMEABalances { get; set; } 
        public IRPSSection<FMEAVersionEntityView> FMEATask { get; set; } 
        public IRPSSection<FMEAVersionEntityView> MaterialsWithFMEA { get; set; } 
        public IRPSSection<FMEAVersionEntityView> Structure { get; set; } 
        public IRPSSection<FMEAVersionEntityView> CoreTeams { get; set; } 
        public IRPSSection<FMEAVersionEntityView> DailyActivities { get; set; } 
        public IRPSSection<FMEAVersionEntityView> Balance { get; set; } 
        public FMEAVersion Screen { get; set; }
        public FMEAVersionEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class FMEATasksCollectionEditor<FMEAVersionEntityView,FMEATaskView>:RPSCollectionEditor<FMEAVersionEntityView,FMEATaskView> where FMEAVersionEntityView : class, IView where FMEATaskView : class, IView
    {
        public  FMEATasksGridView<FMEAVersionEntityView,FMEATaskView> GridView {get;set;}
    }
    public partial class FMEATasksGridView <FMEAVersionEntityView,FMEATaskView> :  RPSGridView<FMEAVersionEntityView,FMEATaskView> where FMEAVersionEntityView : class, IView where FMEATaskView : class, IView
    {
        public FMEATasksGridView(FMEAVersionEntityView currentView,FMEATaskView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDTaskManufacturing = RPSControlFactory.CreateRPSGridComboBox<FMEAVersionEntityView>("","#7993b144-773d-4d42-8ff5-1c85bdf467c1 .ag-row[role='row']@ROWINDEX [col-id='cIDTaskManufacturing']","",false, this.CurrentView);
 
            IDTaskProject = RPSControlFactory.CreateRPSGridComboBox<FMEAVersionEntityView>("","#7993b144-773d-4d42-8ff5-1c85bdf467c1 .ag-row[role='row']@ROWINDEX [col-id='cIDTaskProject']","",false, this.CurrentView);
 
            FailureModesCount = RPSControlFactory.CreateRPSGridFormattedTextBox<FMEAVersionEntityView>("","#7993b144-773d-4d42-8ff5-1c85bdf467c1 .ag-row[role='row']@ROWINDEX [col-id='cFailureModesCount']","",false, this.CurrentView);
 
            CausesCount = RPSControlFactory.CreateRPSGridFormattedTextBox<FMEAVersionEntityView>("","#7993b144-773d-4d42-8ff5-1c85bdf467c1 .ag-row[role='row']@ROWINDEX [col-id='cCausesCount']","",false, this.CurrentView);
 
            CausesOverRPNMaxCount = RPSControlFactory.CreateRPSGridFormattedTextBox<FMEAVersionEntityView>("","#7993b144-773d-4d42-8ff5-1c85bdf467c1 .ag-row[role='row']@ROWINDEX [col-id='cCausesOverRPNMaxCount']","",false, this.CurrentView);
 
            CausesWithHighAP = RPSControlFactory.CreateRPSGridFormattedTextBox<FMEAVersionEntityView>("","#7993b144-773d-4d42-8ff5-1c85bdf467c1 .ag-row[role='row']@ROWINDEX [col-id='cCausesWithHighAP']","",false, this.CurrentView);
 
            CausesWithMediumAP = RPSControlFactory.CreateRPSGridFormattedTextBox<FMEAVersionEntityView>("","#7993b144-773d-4d42-8ff5-1c85bdf467c1 .ag-row[role='row']@ROWINDEX [col-id='cCausesWithMediumAP']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<FMEAVersionEntityView> IDTaskManufacturing { get; set; } 
        public IRPSGridComboBox<FMEAVersionEntityView> IDTaskProject { get; set; } 
        public IRPSGridTextBox<FMEAVersionEntityView> FailureModesCount { get; set; } 
        public IRPSGridTextBox<FMEAVersionEntityView> CausesCount { get; set; } 
        public IRPSGridTextBox<FMEAVersionEntityView> CausesOverRPNMaxCount { get; set; } 
        public IRPSGridTextBox<FMEAVersionEntityView> CausesWithHighAP { get; set; } 
        public IRPSGridTextBox<FMEAVersionEntityView> CausesWithMediumAP { get; set; } 
                     
    }
 
        public partial class MaterialsWithFMEAVersionCollectionEditor<FMEAVersionEntityView,FMEATaskView>:RPSCollectionEditor<FMEAVersionEntityView,FMEATaskView> where FMEAVersionEntityView : class, IView where FMEATaskView : class, IView
    {
        public  MaterialsWithFMEAVersionGridView<FMEAVersionEntityView,FMEATaskView> GridView {get;set;}
    }
    public partial class MaterialsWithFMEAVersionGridView <FMEAVersionEntityView,FMEATaskView> :  RPSGridView<FMEAVersionEntityView,FMEATaskView> where FMEAVersionEntityView : class, IView where FMEATaskView : class, IView
    {
        public MaterialsWithFMEAVersionGridView(FMEAVersionEntityView currentView,FMEATaskView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            UIState = RPSControlFactory.CreateRPSGridTextBox<FMEAVersionEntityView>("","#05030dac-f544-4345-9ce9-293b3ddf6b52 .ag-row[role='row']@ROWINDEX [col-id='cUIState']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<FMEAVersionEntityView> UIState { get; set; } 
                     
    }
 
        public partial class FMEACoreTeamsCollectionEditor<FMEAVersionEntityView,FMEATaskView>:RPSCollectionEditor<FMEAVersionEntityView,FMEATaskView> where FMEAVersionEntityView : class, IView where FMEATaskView : class, IView
    {
        public  FMEACoreTeamsGridView<FMEAVersionEntityView,FMEATaskView> GridView {get;set;}
    }
    public partial class FMEACoreTeamsGridView <FMEAVersionEntityView,FMEATaskView> :  RPSGridView<FMEAVersionEntityView,FMEATaskView> where FMEAVersionEntityView : class, IView where FMEATaskView : class, IView
    {
        public FMEACoreTeamsGridView(FMEAVersionEntityView currentView,FMEATaskView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NumParticipant = RPSControlFactory.CreateRPSGridFormattedTextBox<FMEAVersionEntityView>("","#2abd33e0-534b-4897-9c4b-0cb6ee772f85 .ag-row[role='row']@ROWINDEX [col-id='cNumParticipant']","",true, this.CurrentView);
 
            Name = RPSControlFactory.CreateRPSGridTextBox<FMEAVersionEntityView>("","#2abd33e0-534b-4897-9c4b-0cb6ee772f85 .ag-row[role='row']@ROWINDEX [col-id='cName']","",false, this.CurrentView);
 
            Section = RPSControlFactory.CreateRPSGridTextBox<FMEAVersionEntityView>("","#2abd33e0-534b-4897-9c4b-0cb6ee772f85 .ag-row[role='row']@ROWINDEX [col-id='cSection']","",false, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<FMEAVersionEntityView>("","#2abd33e0-534b-4897-9c4b-0cb6ee772f85 .ag-row[role='row']@ROWINDEX [col-id='cType']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<FMEAVersionEntityView> NumParticipant { get; set; } 
        public IRPSGridTextBox<FMEAVersionEntityView> Name { get; set; } 
        public IRPSGridTextBox<FMEAVersionEntityView> Section { get; set; } 
        public IRPSGridComboBox<FMEAVersionEntityView> Type { get; set; } 
                     
    }
 
        public partial class FMEADailyActivitysCollectionEditor<FMEAVersionEntityView,FMEATaskView>:RPSCollectionEditor<FMEAVersionEntityView,FMEATaskView> where FMEAVersionEntityView : class, IView where FMEATaskView : class, IView
    {
        public  FMEADailyActivitysGridView<FMEAVersionEntityView,FMEATaskView> GridView {get;set;}
    }
    public partial class FMEADailyActivitysGridView <FMEAVersionEntityView,FMEATaskView> :  RPSGridView<FMEAVersionEntityView,FMEATaskView> where FMEAVersionEntityView : class, IView where FMEATaskView : class, IView
    {
        public FMEADailyActivitysGridView(FMEAVersionEntityView currentView,FMEATaskView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NumActivity = RPSControlFactory.CreateRPSGridFormattedTextBox<FMEAVersionEntityView>("","#41dd78f7-82e5-49aa-a185-4133baccc88d .ag-row[role='row']@ROWINDEX [col-id='cNumActivity']","",true, this.CurrentView);
 
            Date = RPSControlFactory.CreateRPSGridTextBox<FMEAVersionEntityView>("","#41dd78f7-82e5-49aa-a185-4133baccc88d .ag-row[role='row']@ROWINDEX [col-id='cDate']","",true, this.CurrentView);
 
            Activity = RPSControlFactory.CreateRPSGridTextBox<FMEAVersionEntityView>("","#41dd78f7-82e5-49aa-a185-4133baccc88d .ag-row[role='row']@ROWINDEX [col-id='cActivity']","",false, this.CurrentView);
 
            Comments = RPSControlFactory.CreateRPSGridMemoTextBox<FMEAVersionEntityView>("","#41dd78f7-82e5-49aa-a185-4133baccc88d .ag-row[role='row']@ROWINDEX [col-id='cComments']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<FMEAVersionEntityView> NumActivity { get; set; } 
        public IRPSGridTextBox<FMEAVersionEntityView> Date { get; set; } 
        public IRPSGridTextBox<FMEAVersionEntityView> Activity { get; set; } 
        public IRPSGridTextBox<FMEAVersionEntityView> Comments { get; set; } 
                     
    }
 
        public partial class FMEABalancesCollectionEditor<FMEAVersionEntityView,FMEATaskView>:RPSCollectionEditor<FMEAVersionEntityView,FMEATaskView> where FMEAVersionEntityView : class, IView where FMEATaskView : class, IView
    {
        public  FMEABalancesGridView<FMEAVersionEntityView,FMEATaskView> GridView {get;set;}
    }
    public partial class FMEABalancesGridView <FMEAVersionEntityView,FMEATaskView> :  RPSGridView<FMEAVersionEntityView,FMEATaskView> where FMEAVersionEntityView : class, IView where FMEATaskView : class, IView
    {
        public FMEABalancesGridView(FMEAVersionEntityView currentView,FMEATaskView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NumBalance = RPSControlFactory.CreateRPSGridFormattedTextBox<FMEAVersionEntityView>("","#f21cb44e-a23f-4945-ad4f-29bc3444400c .ag-row[role='row']@ROWINDEX [col-id='cNumBalance']","",true, this.CurrentView);
 
            Date = RPSControlFactory.CreateRPSGridTextBox<FMEAVersionEntityView>("","#f21cb44e-a23f-4945-ad4f-29bc3444400c .ag-row[role='row']@ROWINDEX [col-id='cDate']","",true, this.CurrentView);
 
            TotalNumCauses = RPSControlFactory.CreateRPSGridFormattedTextBox<FMEAVersionEntityView>("","#f21cb44e-a23f-4945-ad4f-29bc3444400c .ag-row[role='row']@ROWINDEX [col-id='cTotalNumCauses']","",true, this.CurrentView);
 
            CausesOverMaxRPN = RPSControlFactory.CreateRPSGridFormattedTextBox<FMEAVersionEntityView>("","#f21cb44e-a23f-4945-ad4f-29bc3444400c .ag-row[role='row']@ROWINDEX [col-id='cCausesOverMaxRPN']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<FMEAVersionEntityView> NumBalance { get; set; } 
        public IRPSGridTextBox<FMEAVersionEntityView> Date { get; set; } 
        public IRPSGridTextBox<FMEAVersionEntityView> TotalNumCauses { get; set; } 
        public IRPSGridTextBox<FMEAVersionEntityView> CausesOverMaxRPN { get; set; } 
                     
    }
 
    }
  
            
    public partial class FMEATaskView : View
    {
        public FMEATaskView(FMEAVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<FMEATaskView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FMEATaskView,FMEAVersionEntityView>( this,Screen.FMEAVersionEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<FMEATaskView,FMEAVersionEntityView>( this,Screen.FMEAVersionEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<FMEATaskView,FMEAVersionEntityView>( this,Screen.FMEAVersionEntityView);
 
            IDTaskProject = RPSControlFactory.CreateRPSComboBox<FMEATaskView>("52a008d0-6e24-4c2c-910b-c3e799e4b8f7","","",false, this);
 
            IDTaskManufacturing = RPSControlFactory.CreateRPSComboBox<FMEATaskView>("c808e4a6-6348-4a82-9e5f-96df5b114193","","",false, this);
 
            RPNMax = RPSControlFactory.CreateRPSFormattedTextBox<FMEATaskView>("78324197-f264-45ed-8819-f6e338671e3d","","",false, this);
 
            CollectionInit params_FMEAFailureModes = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f8a819d7-104f-4aea-afd2-54256d925869",CSSSelectorGrid="",XPathGrid=""};
            FMEAFailureModes = RPSControlFactory.RPSCreateCollectionWithGrid<FMEAFailureModesCollectionEditor<FMEATaskView,FMEATaskByLangView>,FMEATaskView,FMEATaskByLangView>( params_FMEAFailureModes,this,Screen.FMEATaskByLangView);
 
            CollectionInit params_FMEATaskByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="67bc20fb-defc-4b57-99f0-db3b332b4718",CSSSelectorGrid="",XPathGrid=""};
            FMEATaskByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<FMEATaskByLangsCollectionEditor<FMEATaskView,FMEATaskByLangView>,FMEATaskView,FMEATaskByLangView>( params_FMEATaskByLangs,this,Screen.FMEATaskByLangView);
 
            FailureModes = RPSControlFactory.CreateRPSSection<FMEATaskView>( "","ul li[rpsid='1717b179-1e3e-4165-99da-c23e2884573a']","",this);
 
            TasksByLang = RPSControlFactory.CreateRPSSection<FMEATaskView>( "","ul li[rpsid='320dd08c-6f38-45b4-bc1a-4ef5ed41e1e0']","",this);
 

        }
        public IRPSButton<FMEATaskView> DeleteButton { get; set; } 
        public IRPSButton<FMEATaskView,FMEAVersionEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FMEATaskView,FMEAVersionEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<FMEATaskView,FMEAVersionEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<FMEATaskView> IDTaskProject { get; set; } 
        public IRPSComboBox<FMEATaskView> IDTaskManufacturing { get; set; } 
        public IRPSTextBox<FMEATaskView> RPNMax { get; set; } 
        public FMEAFailureModesCollectionEditor<FMEATaskView,FMEATaskByLangView> FMEAFailureModes { get; set; } 
        public FMEATaskByLangsCollectionEditor<FMEATaskView,FMEATaskByLangView> FMEATaskByLangs { get; set; } 
        public IRPSSection<FMEATaskView> FailureModes { get; set; } 
        public IRPSSection<FMEATaskView> TasksByLang { get; set; } 
        public FMEAVersion Screen { get; set; }
        public FMEATaskView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class FMEAFailureModesCollectionEditor<FMEATaskView,FMEATaskByLangView>:RPSCollectionEditor<FMEATaskView,FMEATaskByLangView> where FMEATaskView : class, IView where FMEATaskByLangView : class, IView
    {
        public  FMEAFailureModesGridView<FMEATaskView,FMEATaskByLangView> GridView {get;set;}
    }
    public partial class FMEAFailureModesGridView <FMEATaskView,FMEATaskByLangView> :  RPSGridView<FMEATaskView,FMEATaskByLangView> where FMEATaskView : class, IView where FMEATaskByLangView : class, IView
    {
        public FMEAFailureModesGridView(FMEATaskView currentView,FMEATaskByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NumFailure = RPSControlFactory.CreateRPSGridFormattedTextBox<FMEATaskView>("","#f8a819d7-104f-4aea-afd2-54256d925869 .ag-row[role='row']@ROWINDEX [col-id='cNumFailure']","",true, this.CurrentView);
 
            IDFailureMode = RPSControlFactory.CreateRPSGridComboBox<FMEATaskView>("","#f8a819d7-104f-4aea-afd2-54256d925869 .ag-row[role='row']@ROWINDEX [col-id='cIDFailureMode']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<FMEATaskView>("","#f8a819d7-104f-4aea-afd2-54256d925869 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Critic = RPSControlFactory.CreateRPSGridCheckBox<FMEATaskView>("","#f8a819d7-104f-4aea-afd2-54256d925869 .ag-row[role='row']@ROWINDEX [col-id='cCritic']","",true, this.CurrentView);
 
            IDRequirement = RPSControlFactory.CreateRPSGridComboBox<FMEATaskView>("","#f8a819d7-104f-4aea-afd2-54256d925869 .ag-row[role='row']@ROWINDEX [col-id='cIDRequirement']","",false, this.CurrentView);
 
            RequirementDescription = RPSControlFactory.CreateRPSGridTextBox<FMEATaskView>("","#f8a819d7-104f-4aea-afd2-54256d925869 .ag-row[role='row']@ROWINDEX [col-id='cRequirementDescription']","",false, this.CurrentView);
 
            CausesCount = RPSControlFactory.CreateRPSGridFormattedTextBox<FMEATaskView>("","#f8a819d7-104f-4aea-afd2-54256d925869 .ag-row[role='row']@ROWINDEX [col-id='cCausesCount']","",false, this.CurrentView);
 
            CausesOverRPNMaxCount = RPSControlFactory.CreateRPSGridFormattedTextBox<FMEATaskView>("","#f8a819d7-104f-4aea-afd2-54256d925869 .ag-row[role='row']@ROWINDEX [col-id='cCausesOverRPNMaxCount']","",false, this.CurrentView);
 
            CausesWithHighAP = RPSControlFactory.CreateRPSGridFormattedTextBox<FMEATaskView>("","#f8a819d7-104f-4aea-afd2-54256d925869 .ag-row[role='row']@ROWINDEX [col-id='cCausesWithHighAP']","",false, this.CurrentView);
 
            CausesWithMediumAP = RPSControlFactory.CreateRPSGridFormattedTextBox<FMEATaskView>("","#f8a819d7-104f-4aea-afd2-54256d925869 .ag-row[role='row']@ROWINDEX [col-id='cCausesWithMediumAP']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<FMEATaskView> NumFailure { get; set; } 
        public IRPSGridComboBox<FMEATaskView> IDFailureMode { get; set; } 
        public IRPSGridTextBox<FMEATaskView> Description { get; set; } 
        public IRPSGridCheckbox<FMEATaskView> Critic { get; set; } 
        public IRPSGridComboBox<FMEATaskView> IDRequirement { get; set; } 
        public IRPSGridTextBox<FMEATaskView> RequirementDescription { get; set; } 
        public IRPSGridTextBox<FMEATaskView> CausesCount { get; set; } 
        public IRPSGridTextBox<FMEATaskView> CausesOverRPNMaxCount { get; set; } 
        public IRPSGridTextBox<FMEATaskView> CausesWithHighAP { get; set; } 
        public IRPSGridTextBox<FMEATaskView> CausesWithMediumAP { get; set; } 
                     
    }
 
        public partial class FMEATaskByLangsCollectionEditor<FMEATaskView,FMEATaskByLangView>:RPSCollectionEditor<FMEATaskView,FMEATaskByLangView> where FMEATaskView : class, IView where FMEATaskByLangView : class, IView
    {
        public  FMEATaskByLangsGridView<FMEATaskView,FMEATaskByLangView> GridView {get;set;}
    }
    public partial class FMEATaskByLangsGridView <FMEATaskView,FMEATaskByLangView> :  RPSGridView<FMEATaskView,FMEATaskByLangView> where FMEATaskView : class, IView where FMEATaskByLangView : class, IView
    {
        public FMEATaskByLangsGridView(FMEATaskView currentView,FMEATaskByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<FMEATaskView>("","#67bc20fb-defc-4b57-99f0-db3b332b4718 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<FMEATaskView>("","#67bc20fb-defc-4b57-99f0-db3b332b4718 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<FMEATaskView> CodLanguage { get; set; } 
        public IRPSGridTextBox<FMEATaskView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class FMEAFailureModeView : View
    {
        public FMEAFailureModeView(FMEAVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<FMEAFailureModeView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FMEAFailureModeView,FMEATaskView>( this,Screen.FMEATaskView);
 
            BackButton = RPSControlFactory.RPSBackButton<FMEAFailureModeView,FMEATaskView>( this,Screen.FMEATaskView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<FMEAFailureModeView,FMEATaskView>( this,Screen.FMEATaskView);
 
            NumFailure = RPSControlFactory.CreateRPSFormattedTextBox<FMEAFailureModeView>("0b42866a-e591-46a6-9678-a32a68df7c56","","",true, this);
 
            IDFailureMode = RPSControlFactory.CreateRPSComboBox<FMEAFailureModeView>("70780b5a-a977-4020-bfef-89a18a4779b7","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<FMEAFailureModeView>("b4b0903c-9815-4b74-b6aa-6ff93d1b9c26","","",false, this);
 
            Critic = RPSControlFactory.CreateRPSCheckBox<FMEAFailureModeView>("0e56a4f9-c9a0-4f05-a80d-a134c6d459b7","","",true, this);
 
            IDRequirement = RPSControlFactory.CreateRPSComboBox<FMEAFailureModeView>("a3a3c53b-0b29-4914-b6c5-30c4604590ce","","",false, this);
 
            RequirementDescription = RPSControlFactory.CreateRPSTextBox<FMEAFailureModeView>("7586e496-2f6e-4581-a566-86e949f8a460","","",false, this);
 
            SeverityMax = RPSControlFactory.CreateRPSFormattedTextBox<FMEAFailureModeView>("2ba4eed3-9964-4d7f-a477-5388c4835014","","",false, this);
 
            RPNMax = RPSControlFactory.CreateRPSFormattedTextBox<FMEAFailureModeView>("2a24a843-8767-4162-8581-22e808ae2212","","",false, this);
 
            CollectionInit params_FMEAEffects = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="9b89b998-0e31-44c8-9398-f27a4bf58f07",CSSSelectorGrid="",XPathGrid=""};
            FMEAEffects = RPSControlFactory.RPSCreateCollectionWithGrid<FMEAEffectsCollectionEditor<FMEAFailureModeView,FMEAFailureModeByLangView>,FMEAFailureModeView,FMEAFailureModeByLangView>( params_FMEAEffects,this,Screen.FMEAFailureModeByLangView);
 
            CollectionInit params_FMEACauses = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f5ccb399-1fee-4d9e-9b80-324958ca09ec",CSSSelectorGrid="",XPathGrid=""};
            FMEACauses = RPSControlFactory.RPSCreateCollectionWithGrid<FMEACausesCollectionEditor<FMEAFailureModeView,FMEAFailureModeByLangView>,FMEAFailureModeView,FMEAFailureModeByLangView>( params_FMEACauses,this,Screen.FMEAFailureModeByLangView);
 
            CollectionInit params_FMEAFailureModeByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="17ab8362-b440-4a6e-ad8e-afa36a729cd1",CSSSelectorGrid="",XPathGrid=""};
            FMEAFailureModeByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<FMEAFailureModeByLangsCollectionEditor<FMEAFailureModeView,FMEAFailureModeByLangView>,FMEAFailureModeView,FMEAFailureModeByLangView>( params_FMEAFailureModeByLangs,this,Screen.FMEAFailureModeByLangView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<FMEAFailureModeView>( "","ul li[rpsid='5b6201ba-8f31-4af3-a224-500f8e30e09b']","",this);
 
            FailureModesByLang = RPSControlFactory.CreateRPSSection<FMEAFailureModeView>( "","ul li[rpsid='803f5bce-0e2a-4bb2-8ac7-981b1dea8d50']","",this);
 

        }
        public IRPSButton<FMEAFailureModeView> DeleteButton { get; set; } 
        public IRPSButton<FMEAFailureModeView,FMEATaskView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FMEAFailureModeView,FMEATaskView> BackButton { get; set; } 
        public IRPSAcceptButton<FMEAFailureModeView,FMEATaskView> AcceptButton { get; set; } 
        public IRPSTextBox<FMEAFailureModeView> NumFailure { get; set; } 
        public IRPSComboBox<FMEAFailureModeView> IDFailureMode { get; set; } 
        public IRPSTextBox<FMEAFailureModeView> Description { get; set; } 
        public IRPSCheckbox<FMEAFailureModeView> Critic { get; set; } 
        public IRPSComboBox<FMEAFailureModeView> IDRequirement { get; set; } 
        public IRPSTextBox<FMEAFailureModeView> RequirementDescription { get; set; } 
        public IRPSTextBox<FMEAFailureModeView> SeverityMax { get; set; } 
        public IRPSTextBox<FMEAFailureModeView> RPNMax { get; set; } 
        public FMEAEffectsCollectionEditor<FMEAFailureModeView,FMEAFailureModeByLangView> FMEAEffects { get; set; } 
        public FMEACausesCollectionEditor<FMEAFailureModeView,FMEAFailureModeByLangView> FMEACauses { get; set; } 
        public FMEAFailureModeByLangsCollectionEditor<FMEAFailureModeView,FMEAFailureModeByLangView> FMEAFailureModeByLangs { get; set; } 
        public IRPSSection<FMEAFailureModeView> GeneralData { get; set; } 
        public IRPSSection<FMEAFailureModeView> FailureModesByLang { get; set; } 
        public FMEAVersion Screen { get; set; }
        public FMEAFailureModeView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class FMEAEffectsCollectionEditor<FMEAFailureModeView,FMEAFailureModeByLangView>:RPSCollectionEditor<FMEAFailureModeView,FMEAFailureModeByLangView> where FMEAFailureModeView : class, IView where FMEAFailureModeByLangView : class, IView
    {
        public  FMEAEffectsGridView<FMEAFailureModeView,FMEAFailureModeByLangView> GridView {get;set;}
    }
    public partial class FMEAEffectsGridView <FMEAFailureModeView,FMEAFailureModeByLangView> :  RPSGridView<FMEAFailureModeView,FMEAFailureModeByLangView> where FMEAFailureModeView : class, IView where FMEAFailureModeByLangView : class, IView
    {
        public FMEAEffectsGridView(FMEAFailureModeView currentView,FMEAFailureModeByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NumEffect = RPSControlFactory.CreateRPSGridFormattedTextBox<FMEAFailureModeView>("","#9b89b998-0e31-44c8-9398-f27a4bf58f07 .ag-row[role='row']@ROWINDEX [col-id='cNumEffect']","",true, this.CurrentView);
 
            IDEffect = RPSControlFactory.CreateRPSGridComboBox<FMEAFailureModeView>("","#9b89b998-0e31-44c8-9398-f27a4bf58f07 .ag-row[role='row']@ROWINDEX [col-id='cIDEffect']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<FMEAFailureModeView>("","#9b89b998-0e31-44c8-9398-f27a4bf58f07 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            SeverityStringValue = RPSControlFactory.CreateRPSGridEnumComboBox<FMEAFailureModeView>("","#9b89b998-0e31-44c8-9398-f27a4bf58f07 .ag-row[role='row']@ROWINDEX [col-id='cSeverityStringValue']","",false, this.CurrentView);
 
            Class = RPSControlFactory.CreateRPSGridComboBox<FMEAFailureModeView>("","#9b89b998-0e31-44c8-9398-f27a4bf58f07 .ag-row[role='row']@ROWINDEX [col-id='cClass']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<FMEAFailureModeView> NumEffect { get; set; } 
        public IRPSGridComboBox<FMEAFailureModeView> IDEffect { get; set; } 
        public IRPSGridTextBox<FMEAFailureModeView> Description { get; set; } 
        public IRPSGridComboBox<FMEAFailureModeView> SeverityStringValue { get; set; } 
        public IRPSGridComboBox<FMEAFailureModeView> Class { get; set; } 
                     
    }
 
        public partial class FMEACausesCollectionEditor<FMEAFailureModeView,FMEAFailureModeByLangView>:RPSCollectionEditor<FMEAFailureModeView,FMEAFailureModeByLangView> where FMEAFailureModeView : class, IView where FMEAFailureModeByLangView : class, IView
    {
        public  FMEACausesGridView<FMEAFailureModeView,FMEAFailureModeByLangView> GridView {get;set;}
    }
    public partial class FMEACausesGridView <FMEAFailureModeView,FMEAFailureModeByLangView> :  RPSGridView<FMEAFailureModeView,FMEAFailureModeByLangView> where FMEAFailureModeView : class, IView where FMEAFailureModeByLangView : class, IView
    {
        public FMEACausesGridView(FMEAFailureModeView currentView,FMEAFailureModeByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NumCause = RPSControlFactory.CreateRPSGridFormattedTextBox<FMEAFailureModeView>("","#f5ccb399-1fee-4d9e-9b80-324958ca09ec .ag-row[role='row']@ROWINDEX [col-id='cNumCause']","",true, this.CurrentView);
 
            IDCause = RPSControlFactory.CreateRPSGridComboBox<FMEAFailureModeView>("","#f5ccb399-1fee-4d9e-9b80-324958ca09ec .ag-row[role='row']@ROWINDEX [col-id='cIDCause']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<FMEAFailureModeView>("","#f5ccb399-1fee-4d9e-9b80-324958ca09ec .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            OccurrenceStringValue = RPSControlFactory.CreateRPSGridEnumComboBox<FMEAFailureModeView>("","#f5ccb399-1fee-4d9e-9b80-324958ca09ec .ag-row[role='row']@ROWINDEX [col-id='cOccurrenceStringValue']","",false, this.CurrentView);
 
            DetectionStringValue = RPSControlFactory.CreateRPSGridEnumComboBox<FMEAFailureModeView>("","#f5ccb399-1fee-4d9e-9b80-324958ca09ec .ag-row[role='row']@ROWINDEX [col-id='cDetectionStringValue']","",false, this.CurrentView);
 
            RPN = RPSControlFactory.CreateRPSGridFormattedTextBox<FMEAFailureModeView>("","#f5ccb399-1fee-4d9e-9b80-324958ca09ec .ag-row[role='row']@ROWINDEX [col-id='cRPN']","",false, this.CurrentView);
 
            ActionPriorityLevel = RPSControlFactory.CreateRPSGridEnumComboBox<FMEAFailureModeView>("","#f5ccb399-1fee-4d9e-9b80-324958ca09ec .ag-row[role='row']@ROWINDEX [col-id='cActionPriorityLevel']","",true, this.CurrentView);
 
            RPNNew = RPSControlFactory.CreateRPSGridFormattedTextBox<FMEAFailureModeView>("","#f5ccb399-1fee-4d9e-9b80-324958ca09ec .ag-row[role='row']@ROWINDEX [col-id='cRPNNew']","",false, this.CurrentView);
 
            APriorityNew = RPSControlFactory.CreateRPSGridEnumComboBox<FMEAFailureModeView>("","#f5ccb399-1fee-4d9e-9b80-324958ca09ec .ag-row[role='row']@ROWINDEX [col-id='cAPriorityNew']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<FMEAFailureModeView> NumCause { get; set; } 
        public IRPSGridComboBox<FMEAFailureModeView> IDCause { get; set; } 
        public IRPSGridTextBox<FMEAFailureModeView> Description { get; set; } 
        public IRPSGridComboBox<FMEAFailureModeView> OccurrenceStringValue { get; set; } 
        public IRPSGridComboBox<FMEAFailureModeView> DetectionStringValue { get; set; } 
        public IRPSGridTextBox<FMEAFailureModeView> RPN { get; set; } 
        public IRPSGridComboBox<FMEAFailureModeView> ActionPriorityLevel { get; set; } 
        public IRPSGridTextBox<FMEAFailureModeView> RPNNew { get; set; } 
        public IRPSGridComboBox<FMEAFailureModeView> APriorityNew { get; set; } 
                     
    }
 
        public partial class FMEAFailureModeByLangsCollectionEditor<FMEAFailureModeView,FMEAFailureModeByLangView>:RPSCollectionEditor<FMEAFailureModeView,FMEAFailureModeByLangView> where FMEAFailureModeView : class, IView where FMEAFailureModeByLangView : class, IView
    {
        public  FMEAFailureModeByLangsGridView<FMEAFailureModeView,FMEAFailureModeByLangView> GridView {get;set;}
    }
    public partial class FMEAFailureModeByLangsGridView <FMEAFailureModeView,FMEAFailureModeByLangView> :  RPSGridView<FMEAFailureModeView,FMEAFailureModeByLangView> where FMEAFailureModeView : class, IView where FMEAFailureModeByLangView : class, IView
    {
        public FMEAFailureModeByLangsGridView(FMEAFailureModeView currentView,FMEAFailureModeByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<FMEAFailureModeView>("","#17ab8362-b440-4a6e-ad8e-afa36a729cd1 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<FMEAFailureModeView>("","#17ab8362-b440-4a6e-ad8e-afa36a729cd1 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            RequirementDescription = RPSControlFactory.CreateRPSGridTextBox<FMEAFailureModeView>("","#17ab8362-b440-4a6e-ad8e-afa36a729cd1 .ag-row[role='row']@ROWINDEX [col-id='cRequirementDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<FMEAFailureModeView> CodLanguage { get; set; } 
        public IRPSGridTextBox<FMEAFailureModeView> Description { get; set; } 
        public IRPSGridTextBox<FMEAFailureModeView> RequirementDescription { get; set; } 
                     
    }
 
    }
  
            
    public partial class FMEAEffectView : View
    {
        public FMEAEffectView(FMEAVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<FMEAEffectView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FMEAEffectView,FMEAFailureModeView>( this,Screen.FMEAFailureModeView);
 
            BackButton = RPSControlFactory.RPSBackButton<FMEAEffectView,FMEAFailureModeView>( this,Screen.FMEAFailureModeView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<FMEAEffectView,FMEAFailureModeView>( this,Screen.FMEAFailureModeView);
 
            NumEffect = RPSControlFactory.CreateRPSFormattedTextBox<FMEAEffectView>("94fc094f-91a4-478b-ba16-a9985ee6a57d","","",true, this);
 
            IDEffect = RPSControlFactory.CreateRPSComboBox<FMEAEffectView>("4a7a93df-7167-4df3-a016-b277402ae270","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<FMEAEffectView>("90821fdb-08cf-4bbe-aaeb-a521c437decf","","",false, this);
 
            SeverityStringValue = RPSControlFactory.CreateRPSEnumComboBox<FMEAEffectView>("67e97311-2a0b-4a2f-90c9-550a05e462cd","","",false, this);
 
            Class = RPSControlFactory.CreateRPSComboBox<FMEAEffectView>("1f60d3d7-08f5-4bb2-82de-4dfd8ba6b914","","",false, this);
 
            CollectionInit params_FMEAEffectByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c258042a-7f49-4997-bdf8-bcf4de1f2676",CSSSelectorGrid="",XPathGrid=""};
            FMEAEffectByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<FMEAEffectByLangsCollectionEditor<FMEAEffectView,FMEAEffectByLangView>,FMEAEffectView,FMEAEffectByLangView>( params_FMEAEffectByLangs,this,Screen.FMEAEffectByLangView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<FMEAEffectView>( "","ul li[rpsid='d607b0c0-87ac-4770-9868-bcd0c424ede0']","",this);
 
            EffectsByLang = RPSControlFactory.CreateRPSSection<FMEAEffectView>( "","ul li[rpsid='cddd411d-58a6-449c-bedc-5250d58f2895']","",this);
 

        }
        public IRPSButton<FMEAEffectView> DeleteButton { get; set; } 
        public IRPSButton<FMEAEffectView,FMEAFailureModeView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FMEAEffectView,FMEAFailureModeView> BackButton { get; set; } 
        public IRPSAcceptButton<FMEAEffectView,FMEAFailureModeView> AcceptButton { get; set; } 
        public IRPSTextBox<FMEAEffectView> NumEffect { get; set; } 
        public IRPSComboBox<FMEAEffectView> IDEffect { get; set; } 
        public IRPSTextBox<FMEAEffectView> Description { get; set; } 
        public IRPSComboBox<FMEAEffectView> SeverityStringValue { get; set; } 
        public IRPSComboBox<FMEAEffectView> Class { get; set; } 
        public FMEAEffectByLangsCollectionEditor<FMEAEffectView,FMEAEffectByLangView> FMEAEffectByLangs { get; set; } 
        public IRPSSection<FMEAEffectView> GeneralData { get; set; } 
        public IRPSSection<FMEAEffectView> EffectsByLang { get; set; } 
        public FMEAVersion Screen { get; set; }
        public FMEAEffectView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class FMEAEffectByLangsCollectionEditor<FMEAEffectView,FMEAEffectByLangView>:RPSCollectionEditor<FMEAEffectView,FMEAEffectByLangView> where FMEAEffectView : class, IView where FMEAEffectByLangView : class, IView
    {
        public  FMEAEffectByLangsGridView<FMEAEffectView,FMEAEffectByLangView> GridView {get;set;}
    }
    public partial class FMEAEffectByLangsGridView <FMEAEffectView,FMEAEffectByLangView> :  RPSGridView<FMEAEffectView,FMEAEffectByLangView> where FMEAEffectView : class, IView where FMEAEffectByLangView : class, IView
    {
        public FMEAEffectByLangsGridView(FMEAEffectView currentView,FMEAEffectByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<FMEAEffectView>("","#c258042a-7f49-4997-bdf8-bcf4de1f2676 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<FMEAEffectView>("","#c258042a-7f49-4997-bdf8-bcf4de1f2676 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<FMEAEffectView> CodLanguage { get; set; } 
        public IRPSGridTextBox<FMEAEffectView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class FMEACauseView : View
    {
        public FMEACauseView(FMEAVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<FMEACauseView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FMEACauseView,FMEAFailureModeView>( this,Screen.FMEAFailureModeView);
 
            BackButton = RPSControlFactory.RPSBackButton<FMEACauseView,FMEAFailureModeView>( this,Screen.FMEAFailureModeView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<FMEACauseView,FMEAFailureModeView>( this,Screen.FMEAFailureModeView);
 
            NumCause = RPSControlFactory.CreateRPSFormattedTextBox<FMEACauseView>("21ed1e98-5c54-4fc7-8145-bb881aed782d","","",true, this);
 
            IDCause = RPSControlFactory.CreateRPSComboBox<FMEACauseView>("87a7e35e-70cb-4e3c-8052-eae9d7838777","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<FMEACauseView>("1c496044-d1cb-41cf-bdfe-0ada3518f3c0","","",false, this);
 
            OccurrenceStringValue = RPSControlFactory.CreateRPSEnumComboBox<FMEACauseView>("d4bde0ed-63f6-45d4-a084-f1ffd60a96ea","","",false, this);
 
            DetectionStringValue = RPSControlFactory.CreateRPSEnumComboBox<FMEACauseView>("10ed7113-3e01-4d09-ad51-246ac8d2c1ea","","",false, this);
 
            RPN = RPSControlFactory.CreateRPSFormattedTextBox<FMEACauseView>("703bdac3-02a8-4321-94a9-40aa4a5df189","","",false, this);
 
            OccurrenceStringValue1 = RPSControlFactory.CreateRPSEnumComboBox<FMEACauseView>("a72de93d-d7ce-4334-9ef1-c8d086f2e959","","",false, this);
 
            SeverityVsOccurrence = RPSControlFactory.CreateRPSEnumComboBox<FMEACauseView>("9d13ca6c-951c-4885-8288-16a14df112ef","","",true, this);
 
            DetectionStringValue1 = RPSControlFactory.CreateRPSEnumComboBox<FMEACauseView>("aabbac6b-9d62-4afd-b117-2020595ffe0e","","",false, this);
 
            SeverityVsDetection = RPSControlFactory.CreateRPSEnumComboBox<FMEACauseView>("2a1c0a1b-facc-429d-b3bb-ef714176705b","","",true, this);
 
            ActionPriorityLevel = RPSControlFactory.CreateRPSEnumComboBox<FMEACauseView>("e79cd51a-5aa3-4723-af54-6b3b0f44333f","","",true, this);
 
            IDVerify = RPSControlFactory.CreateRPSComboBox<FMEACauseView>("612292cb-88df-4ce0-a552-d24f0ab2417f","","",false, this);
 
            VerifyAndControl = RPSControlFactory.CreateRPSTextBox<FMEACauseView>("41375496-004d-4101-a720-c6da4efebf62","","",false, this);
 
            IDVerify_DET = RPSControlFactory.CreateRPSComboBox<FMEACauseView>("0c7fa311-c128-4ef7-88ec-2e0ba2302977","","",false, this);
 
            VerifyAndControl_DET = RPSControlFactory.CreateRPSTextBox<FMEACauseView>("43e7d73a-796e-45b9-b776-5932ca81ecc6","","",false, this);
 
            IDRecAction = RPSControlFactory.CreateRPSComboBox<FMEACauseView>("b78ef019-cfab-419f-9c1d-34a818379206","","",false, this);
 
            RecomendedAction = RPSControlFactory.CreateRPSTextBox<FMEACauseView>("6e0e01f1-8663-47cf-a97d-a44beda4bab0","","",false, this);
 
            IDResponsible = RPSControlFactory.CreateRPSComboBox<FMEACauseView>("863ad3a4-8b89-4370-9325-9e2c3abad682","","",false, this);
 
            Responsible = RPSControlFactory.CreateRPSTextBox<FMEACauseView>("e77aff08-84d8-49c7-9812-0dd719d8672f","","",false, this);
 
            TargetDate = RPSControlFactory.CreateRPSTextBox<FMEACauseView>("9fd35866-4b3a-45d2-8c46-f8a2fd06bec6","","",false, this);
 
            IDActionTaken = RPSControlFactory.CreateRPSComboBox<FMEACauseView>("63442ff8-446e-48a4-94f5-821f958498e6","","",false, this);
 
            ActionTaken = RPSControlFactory.CreateRPSTextBox<FMEACauseView>("9c4eabee-4e03-4bf4-acfa-8f549e73e833","","",false, this);
 
            EndDate = RPSControlFactory.CreateRPSTextBox<FMEACauseView>("f8d0623b-af46-49db-afbc-3def0cc2eb93","","",false, this);
 
            SeverityNewStringValue = RPSControlFactory.CreateRPSEnumComboBox<FMEACauseView>("7584d498-630c-4ed6-866c-6fce031e25de","","",false, this);
 
            OccurrenceNewStringValue = RPSControlFactory.CreateRPSEnumComboBox<FMEACauseView>("a41168da-1c44-4ee3-9a5e-0a43c2fbac49","","",false, this);
 
            DetectionNewStringValue = RPSControlFactory.CreateRPSEnumComboBox<FMEACauseView>("37de6aa4-ca63-4f6a-b28b-94f65ff6b39a","","",false, this);
 
            RPNNew = RPSControlFactory.CreateRPSFormattedTextBox<FMEACauseView>("78dc7b3e-4fac-4da8-a3e6-b54ce1d1b833","","",false, this);
 
            SeverityNewStringValue1 = RPSControlFactory.CreateRPSEnumComboBox<FMEACauseView>("f6bb4050-c48e-46d0-922a-a8bd6fbcf136","","",false, this);
 
            OccurrenceNewStringValue1 = RPSControlFactory.CreateRPSEnumComboBox<FMEACauseView>("6af88a72-eacd-4b5f-9940-4f87fafea09c","","",false, this);
 
            SvOccurrenceNew = RPSControlFactory.CreateRPSEnumComboBox<FMEACauseView>("6879db8c-3cf1-47c0-a1aa-5bcf8773151b","","",true, this);
 
            DetectionNewStringValue1 = RPSControlFactory.CreateRPSEnumComboBox<FMEACauseView>("767855d7-9e74-4045-8df5-d310e62fd53a","","",false, this);
 
            SvDetectionNew = RPSControlFactory.CreateRPSEnumComboBox<FMEACauseView>("74782988-ff94-4ca9-a362-038272af7cf5","","",true, this);
 
            APriorityNew = RPSControlFactory.CreateRPSEnumComboBox<FMEACauseView>("8e47584c-7a42-4fd2-800d-7765c73e9b01","","",true, this);
 
            CollectionInit params_FMEACauseByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c1a4cae4-4fad-47ae-889a-7cbc348b0668",CSSSelectorGrid="",XPathGrid=""};
            FMEACauseByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<FMEACauseByLangsCollectionEditor<FMEACauseView,FMEACauseByLangView>,FMEACauseView,FMEACauseByLangView>( params_FMEACauseByLangs,this,Screen.FMEACauseByLangView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<FMEACauseView>( "","ul li[rpsid='a9b9733f-e642-4038-a38d-0fa40b04efc6']","",this);
 
            CausesByLang = RPSControlFactory.CreateRPSSection<FMEACauseView>( "","ul li[rpsid='e7c985da-cc60-4292-858b-69aae1e7a7bb']","",this);
 

        }
        public IRPSButton<FMEACauseView> DeleteButton { get; set; } 
        public IRPSButton<FMEACauseView,FMEAFailureModeView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FMEACauseView,FMEAFailureModeView> BackButton { get; set; } 
        public IRPSAcceptButton<FMEACauseView,FMEAFailureModeView> AcceptButton { get; set; } 
        public IRPSTextBox<FMEACauseView> NumCause { get; set; } 
        public IRPSComboBox<FMEACauseView> IDCause { get; set; } 
        public IRPSTextBox<FMEACauseView> Description { get; set; } 
        public IRPSComboBox<FMEACauseView> OccurrenceStringValue { get; set; } 
        public IRPSComboBox<FMEACauseView> DetectionStringValue { get; set; } 
        public IRPSTextBox<FMEACauseView> RPN { get; set; } 
        public IRPSComboBox<FMEACauseView> OccurrenceStringValue1 { get; set; } 
        public IRPSComboBox<FMEACauseView> SeverityVsOccurrence { get; set; } 
        public IRPSComboBox<FMEACauseView> DetectionStringValue1 { get; set; } 
        public IRPSComboBox<FMEACauseView> SeverityVsDetection { get; set; } 
        public IRPSComboBox<FMEACauseView> ActionPriorityLevel { get; set; } 
        public IRPSComboBox<FMEACauseView> IDVerify { get; set; } 
        public IRPSTextBox<FMEACauseView> VerifyAndControl { get; set; } 
        public IRPSComboBox<FMEACauseView> IDVerify_DET { get; set; } 
        public IRPSTextBox<FMEACauseView> VerifyAndControl_DET { get; set; } 
        public IRPSComboBox<FMEACauseView> IDRecAction { get; set; } 
        public IRPSTextBox<FMEACauseView> RecomendedAction { get; set; } 
        public IRPSComboBox<FMEACauseView> IDResponsible { get; set; } 
        public IRPSTextBox<FMEACauseView> Responsible { get; set; } 
        public IRPSTextBox<FMEACauseView> TargetDate { get; set; } 
        public IRPSComboBox<FMEACauseView> IDActionTaken { get; set; } 
        public IRPSTextBox<FMEACauseView> ActionTaken { get; set; } 
        public IRPSTextBox<FMEACauseView> EndDate { get; set; } 
        public IRPSComboBox<FMEACauseView> SeverityNewStringValue { get; set; } 
        public IRPSComboBox<FMEACauseView> OccurrenceNewStringValue { get; set; } 
        public IRPSComboBox<FMEACauseView> DetectionNewStringValue { get; set; } 
        public IRPSTextBox<FMEACauseView> RPNNew { get; set; } 
        public IRPSComboBox<FMEACauseView> SeverityNewStringValue1 { get; set; } 
        public IRPSComboBox<FMEACauseView> OccurrenceNewStringValue1 { get; set; } 
        public IRPSComboBox<FMEACauseView> SvOccurrenceNew { get; set; } 
        public IRPSComboBox<FMEACauseView> DetectionNewStringValue1 { get; set; } 
        public IRPSComboBox<FMEACauseView> SvDetectionNew { get; set; } 
        public IRPSComboBox<FMEACauseView> APriorityNew { get; set; } 
        public FMEACauseByLangsCollectionEditor<FMEACauseView,FMEACauseByLangView> FMEACauseByLangs { get; set; } 
        public IRPSSection<FMEACauseView> GeneralData { get; set; } 
        public IRPSSection<FMEACauseView> CausesByLang { get; set; } 
        public FMEAVersion Screen { get; set; }
        public FMEACauseView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class FMEACauseByLangsCollectionEditor<FMEACauseView,FMEACauseByLangView>:RPSCollectionEditor<FMEACauseView,FMEACauseByLangView> where FMEACauseView : class, IView where FMEACauseByLangView : class, IView
    {
        public  FMEACauseByLangsGridView<FMEACauseView,FMEACauseByLangView> GridView {get;set;}
    }
    public partial class FMEACauseByLangsGridView <FMEACauseView,FMEACauseByLangView> :  RPSGridView<FMEACauseView,FMEACauseByLangView> where FMEACauseView : class, IView where FMEACauseByLangView : class, IView
    {
        public FMEACauseByLangsGridView(FMEACauseView currentView,FMEACauseByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<FMEACauseView>("","#c1a4cae4-4fad-47ae-889a-7cbc348b0668 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<FMEACauseView>("","#c1a4cae4-4fad-47ae-889a-7cbc348b0668 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            VerifyAndControl = RPSControlFactory.CreateRPSGridTextBox<FMEACauseView>("","#c1a4cae4-4fad-47ae-889a-7cbc348b0668 .ag-row[role='row']@ROWINDEX [col-id='cVerifyAndControl']","",false, this.CurrentView);
 
            RecomendedAction = RPSControlFactory.CreateRPSGridTextBox<FMEACauseView>("","#c1a4cae4-4fad-47ae-889a-7cbc348b0668 .ag-row[role='row']@ROWINDEX [col-id='cRecomendedAction']","",false, this.CurrentView);
 
            ActionTaken = RPSControlFactory.CreateRPSGridTextBox<FMEACauseView>("","#c1a4cae4-4fad-47ae-889a-7cbc348b0668 .ag-row[role='row']@ROWINDEX [col-id='cActionTaken']","",false, this.CurrentView);
 
            VerifyAndControl_DET = RPSControlFactory.CreateRPSGridTextBox<FMEACauseView>("","#c1a4cae4-4fad-47ae-889a-7cbc348b0668 .ag-row[role='row']@ROWINDEX [col-id='cVerifyAndControl_DET']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<FMEACauseView> CodLanguage { get; set; } 
        public IRPSGridTextBox<FMEACauseView> Description { get; set; } 
        public IRPSGridTextBox<FMEACauseView> VerifyAndControl { get; set; } 
        public IRPSGridTextBox<FMEACauseView> RecomendedAction { get; set; } 
        public IRPSGridTextBox<FMEACauseView> ActionTaken { get; set; } 
        public IRPSGridTextBox<FMEACauseView> VerifyAndControl_DET { get; set; } 
                     
    }
 
    }
  
            
    public partial class FMEAEffectByLangView : View
    {
        public FMEAEffectByLangView(FMEAVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<FMEAEffectByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FMEAEffectByLangView,FMEAEffectView>( this,Screen.FMEAEffectView);
 
            BackButton = RPSControlFactory.RPSBackButton<FMEAEffectByLangView,FMEAEffectView>( this,Screen.FMEAEffectView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<FMEAEffectByLangView,FMEAEffectView>( this,Screen.FMEAEffectView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<FMEAEffectByLangView>("e553409f-6fd6-4aa7-adf9-1b2d427ace30","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<FMEAEffectByLangView>("ffcf4679-f272-4d19-a8dc-123a21ec9740","","",false, this);
 

        }
        public IRPSButton<FMEAEffectByLangView> DeleteButton { get; set; } 
        public IRPSButton<FMEAEffectByLangView,FMEAEffectView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FMEAEffectByLangView,FMEAEffectView> BackButton { get; set; } 
        public IRPSAcceptButton<FMEAEffectByLangView,FMEAEffectView> AcceptButton { get; set; } 
        public IRPSComboBox<FMEAEffectByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<FMEAEffectByLangView> Description { get; set; } 
        public FMEAVersion Screen { get; set; }
        public FMEAEffectByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FMEACauseByLangView : View
    {
        public FMEACauseByLangView(FMEAVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<FMEACauseByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FMEACauseByLangView,FMEACauseView>( this,Screen.FMEACauseView);
 
            BackButton = RPSControlFactory.RPSBackButton<FMEACauseByLangView,FMEACauseView>( this,Screen.FMEACauseView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<FMEACauseByLangView,FMEACauseView>( this,Screen.FMEACauseView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<FMEACauseByLangView>("ee1de3ea-c226-4bbf-a59e-de3c18046284","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<FMEACauseByLangView>("bf5fa7eb-2b82-49df-a7d9-25fa3d7a8a5f","","",false, this);
 
            VerifyAndControl = RPSControlFactory.CreateRPSTextBox<FMEACauseByLangView>("d53e760e-5815-432e-b004-d29b3d9a7461","","",false, this);
 
            RecomendedAction = RPSControlFactory.CreateRPSTextBox<FMEACauseByLangView>("d0a99dda-cb23-422c-b2f5-9967133b5fee","","",false, this);
 
            ActionTaken = RPSControlFactory.CreateRPSTextBox<FMEACauseByLangView>("270fc2f4-8ec7-4959-b856-b3210958b6a5","","",false, this);
 
            VerifyAndControl_DET = RPSControlFactory.CreateRPSTextBox<FMEACauseByLangView>("bdee1d8b-8a15-41c6-97f2-49f3ebdb1940","","",false, this);
 

        }
        public IRPSButton<FMEACauseByLangView> DeleteButton { get; set; } 
        public IRPSButton<FMEACauseByLangView,FMEACauseView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FMEACauseByLangView,FMEACauseView> BackButton { get; set; } 
        public IRPSAcceptButton<FMEACauseByLangView,FMEACauseView> AcceptButton { get; set; } 
        public IRPSComboBox<FMEACauseByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<FMEACauseByLangView> Description { get; set; } 
        public IRPSTextBox<FMEACauseByLangView> VerifyAndControl { get; set; } 
        public IRPSTextBox<FMEACauseByLangView> RecomendedAction { get; set; } 
        public IRPSTextBox<FMEACauseByLangView> ActionTaken { get; set; } 
        public IRPSTextBox<FMEACauseByLangView> VerifyAndControl_DET { get; set; } 
        public FMEAVersion Screen { get; set; }
        public FMEACauseByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FMEAFailureModeByLangView : View
    {
        public FMEAFailureModeByLangView(FMEAVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<FMEAFailureModeByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FMEAFailureModeByLangView,FMEAFailureModeView>( this,Screen.FMEAFailureModeView);
 
            BackButton = RPSControlFactory.RPSBackButton<FMEAFailureModeByLangView,FMEAFailureModeView>( this,Screen.FMEAFailureModeView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<FMEAFailureModeByLangView,FMEAFailureModeView>( this,Screen.FMEAFailureModeView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<FMEAFailureModeByLangView>("ccbcf91f-ab90-4c68-b5c9-c083a34adaf2","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<FMEAFailureModeByLangView>("c91e54cc-7d71-499e-98df-1768da8127d6","","",false, this);
 
            RequirementDescription = RPSControlFactory.CreateRPSTextBox<FMEAFailureModeByLangView>("31bd7de4-c0a6-4d5d-84df-f104291ec761","","",false, this);
 

        }
        public IRPSButton<FMEAFailureModeByLangView> DeleteButton { get; set; } 
        public IRPSButton<FMEAFailureModeByLangView,FMEAFailureModeView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FMEAFailureModeByLangView,FMEAFailureModeView> BackButton { get; set; } 
        public IRPSAcceptButton<FMEAFailureModeByLangView,FMEAFailureModeView> AcceptButton { get; set; } 
        public IRPSComboBox<FMEAFailureModeByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<FMEAFailureModeByLangView> Description { get; set; } 
        public IRPSTextBox<FMEAFailureModeByLangView> RequirementDescription { get; set; } 
        public FMEAVersion Screen { get; set; }
        public FMEAFailureModeByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FMEACoreTeamView : View
    {
        public FMEACoreTeamView(FMEAVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<FMEACoreTeamView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FMEACoreTeamView,FMEAVersionEntityView>( this,Screen.FMEAVersionEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<FMEACoreTeamView,FMEAVersionEntityView>( this,Screen.FMEAVersionEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<FMEACoreTeamView,FMEAVersionEntityView>( this,Screen.FMEAVersionEntityView);
 
            NumParticipant = RPSControlFactory.CreateRPSFormattedTextBox<FMEACoreTeamView>("e7d62b61-8bc9-4eb1-a23c-3a93bf641148","","",true, this);
 
            Name = RPSControlFactory.CreateRPSTextBox<FMEACoreTeamView>("3f936f37-b6ec-48bc-9792-04146ce33ac9","","",false, this);
 
            Section = RPSControlFactory.CreateRPSTextBox<FMEACoreTeamView>("417c2cca-101e-4c19-bb55-c74442e1a9d7","","",false, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<FMEACoreTeamView>("4c8ac018-7aa1-4e8e-be6e-20f556a78c83","","",false, this);
 

        }
        public IRPSButton<FMEACoreTeamView> DeleteButton { get; set; } 
        public IRPSButton<FMEACoreTeamView,FMEAVersionEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FMEACoreTeamView,FMEAVersionEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<FMEACoreTeamView,FMEAVersionEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<FMEACoreTeamView> NumParticipant { get; set; } 
        public IRPSTextBox<FMEACoreTeamView> Name { get; set; } 
        public IRPSTextBox<FMEACoreTeamView> Section { get; set; } 
        public IRPSComboBox<FMEACoreTeamView> Type { get; set; } 
        public FMEAVersion Screen { get; set; }
        public FMEACoreTeamView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FMEADailyActivityView : View
    {
        public FMEADailyActivityView(FMEAVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<FMEADailyActivityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FMEADailyActivityView,FMEAVersionEntityView>( this,Screen.FMEAVersionEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<FMEADailyActivityView,FMEAVersionEntityView>( this,Screen.FMEAVersionEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<FMEADailyActivityView,FMEAVersionEntityView>( this,Screen.FMEAVersionEntityView);
 
            NumActivity = RPSControlFactory.CreateRPSFormattedTextBox<FMEADailyActivityView>("c98917b3-24b9-4451-be2c-a1704b8aa467","","",true, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<FMEADailyActivityView>("8143b0a1-aa34-4890-a060-a895b6394dfc","","",true, this);
 
            Activity = RPSControlFactory.CreateRPSTextBox<FMEADailyActivityView>("7b870c92-ebd1-4a42-8642-57f4582eb647","","",false, this);
 
            Comments = RPSControlFactory.CreateRPSTextBox<FMEADailyActivityView>("8b2e351d-10ae-4c8a-b9f8-59861f52ca13","","",false, this);
 

        }
        public IRPSButton<FMEADailyActivityView> DeleteButton { get; set; } 
        public IRPSButton<FMEADailyActivityView,FMEAVersionEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FMEADailyActivityView,FMEAVersionEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<FMEADailyActivityView,FMEAVersionEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<FMEADailyActivityView> NumActivity { get; set; } 
        public IRPSTextBox<FMEADailyActivityView> Date { get; set; } 
        public IRPSTextBox<FMEADailyActivityView> Activity { get; set; } 
        public IRPSTextBox<FMEADailyActivityView> Comments { get; set; } 
        public FMEAVersion Screen { get; set; }
        public FMEADailyActivityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FMEABalanceView : View
    {
        public FMEABalanceView(FMEAVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<FMEABalanceView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FMEABalanceView,FMEAVersionEntityView>( this,Screen.FMEAVersionEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<FMEABalanceView,FMEAVersionEntityView>( this,Screen.FMEAVersionEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<FMEABalanceView,FMEAVersionEntityView>( this,Screen.FMEAVersionEntityView);
 
            NumBalance = RPSControlFactory.CreateRPSFormattedTextBox<FMEABalanceView>("a43d587e-34c3-4cb7-8ec2-ebdf52cc6eef","","",true, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<FMEABalanceView>("fdc88377-5fd9-48be-97e1-825aeaf90afc","","",true, this);
 
            TotalNumCauses = RPSControlFactory.CreateRPSFormattedTextBox<FMEABalanceView>("564e8a53-77d3-4c27-8510-b77acda68812","","",true, this);
 
            CausesOverMaxRPN = RPSControlFactory.CreateRPSFormattedTextBox<FMEABalanceView>("6e3c9a9c-72e1-4d46-99d4-f6219294a998","","",true, this);
 

        }
        public IRPSButton<FMEABalanceView> DeleteButton { get; set; } 
        public IRPSButton<FMEABalanceView,FMEAVersionEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FMEABalanceView,FMEAVersionEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<FMEABalanceView,FMEAVersionEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<FMEABalanceView> NumBalance { get; set; } 
        public IRPSTextBox<FMEABalanceView> Date { get; set; } 
        public IRPSTextBox<FMEABalanceView> TotalNumCauses { get; set; } 
        public IRPSTextBox<FMEABalanceView> CausesOverMaxRPN { get; set; } 
        public FMEAVersion Screen { get; set; }
        public FMEABalanceView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class RejectFMEAVersionDialogView : View
    {
        public RejectFMEAVersionDialogView(FMEAVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            RejectionDate = RPSControlFactory.CreateRPSTextBox<RejectFMEAVersionDialogView>("65c9e7c0-f61c-4b81-bd94-15ae4bdcd4c6","","",true, this);
 
            RejectionReason = RPSControlFactory.CreateRPSTextBox<RejectFMEAVersionDialogView>("378b18d9-82ff-4098-9740-a19ca9d7ebfd","","",true, this);
 

        }
        public IRPSTextBox<RejectFMEAVersionDialogView> RejectionDate { get; set; } 
        public IRPSTextBox<RejectFMEAVersionDialogView> RejectionReason { get; set; } 
        public FMEAVersion Screen { get; set; }
        public RejectFMEAVersionDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CopyFromOtherFMEADialogView : View
    {
        public CopyFromOtherFMEADialogView(FMEAVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSComboBox<CopyFromOtherFMEADialogView>("43129b16-1640-43f0-87c7-258546d80884","","",false, this);
 
            IDStructure = RPSControlFactory.CreateRPSComboBox<CopyFromOtherFMEADialogView>("636116ae-d0ed-4bf1-8676-8dd71c97a9a2","","",false, this);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<CopyFromOtherFMEADialogView>("1f243789-74dc-47cf-9d55-41a0df799958","","",false, this);
 
            IDFMEAVersion = RPSControlFactory.CreateRPSComboBox<CopyFromOtherFMEADialogView>("e693015c-2ce6-47c9-b156-fac85f2c01d3","","",false, this);
 

        }
        public IRPSComboBox<CopyFromOtherFMEADialogView> IDArticle { get; set; } 
        public IRPSComboBox<CopyFromOtherFMEADialogView> IDStructure { get; set; } 
        public IRPSComboBox<CopyFromOtherFMEADialogView> IDProject { get; set; } 
        public IRPSComboBox<CopyFromOtherFMEADialogView> IDFMEAVersion { get; set; } 
        public FMEAVersion Screen { get; set; }
        public CopyFromOtherFMEADialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PrintFMEAVersionOptionsDialogView : View
    {
        public PrintFMEAVersionOptionsDialogView(FMEAVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDCustomerPrint = RPSControlFactory.CreateRPSComboBox<PrintFMEAVersionOptionsDialogView>("40ae561a-7c22-4a18-8747-d583afe3c334","","",false, this);
 
            CodLanguagePrint = RPSControlFactory.CreateRPSComboBox<PrintFMEAVersionOptionsDialogView>("f8b7b5e6-0c5a-47c0-88f3-f8e1e94ea537","","",false, this);
 
            IDRoutePrint = RPSControlFactory.CreateRPSComboBox<PrintFMEAVersionOptionsDialogView>("478e4693-d05f-4e2b-927c-52947dee58ed","","",true, this);
 
            PrintFMEA = RPSControlFactory.CreateRPSCheckBox<PrintFMEAVersionOptionsDialogView>("b7b49135-fcda-46ed-a100-541e29dfbfba","","",false, this);
 
            FMEAStandard = RPSControlFactory.CreateRPSOption<PrintFMEAVersionOptionsDialogView>( "04d1bd12-62f6-4d10-8af5-800c943f2e7b","","",this);
 
            FMEAStructureComplete = RPSControlFactory.CreateRPSOption<PrintFMEAVersionOptionsDialogView>( "3fbe33ac-a908-44b5-b5a4-01491af06c1a","","",this);
 
            FMEACustomReport = RPSControlFactory.CreateRPSOption<PrintFMEAVersionOptionsDialogView>( "d20f4003-2c41-4b78-ae16-a4076f6d18df","","",this);
 
            IDFMEACustomReport = RPSControlFactory.CreateRPSComboBox<PrintFMEAVersionOptionsDialogView>("357d41fd-3d88-4a28-8ec1-66e5e0bea149","","",false, this);
 
            PrintSynthesis = RPSControlFactory.CreateRPSCheckBox<PrintFMEAVersionOptionsDialogView>("775ddbdb-faf2-43e7-9ca0-9adb2e91269f","","",false, this);
 
            FMEASynthesisStandard = RPSControlFactory.CreateRPSOption<PrintFMEAVersionOptionsDialogView>( "f073104a-b9cb-48a6-9db5-4b95c23b2dc6","","",this);
 
            CustomFMEASynthesisReport = RPSControlFactory.CreateRPSOption<PrintFMEAVersionOptionsDialogView>( "944d4cbe-149a-4856-b052-98eda9603b51","","",this);
 
            IDFMEASynthesisCustomReport = RPSControlFactory.CreateRPSComboBox<PrintFMEAVersionOptionsDialogView>("b18b1627-d799-45b1-a726-4e86ab9c52da","","",false, this);
 
            IncludeAttachments = RPSControlFactory.CreateRPSCheckBox<PrintFMEAVersionOptionsDialogView>("e4545aad-5953-4e5d-8670-1ac5780766db","","",false, this);
 
            PrintSelectedDocumentsCommandButton = RPSControlFactory.CreateRPSButton<PrintFMEAVersionOptionsDialogView>( "429235b7-d37d-42d8-820b-771ab0868462","","",this);
 
            EmailSelectedDocumentsCommandButton = RPSControlFactory.CreateRPSButton<PrintFMEAVersionOptionsDialogView>( "360c0d10-a88f-4c9a-b625-ed71835f5d39","","",this);
 
            ReportByClientEmailCommandButton = RPSControlFactory.CreateRPSButton<PrintFMEAVersionOptionsDialogView>( "055949d3-fb4f-49d0-8ecd-915ac5e24e7a","","",this);
 

        }
        public IRPSComboBox<PrintFMEAVersionOptionsDialogView> IDCustomerPrint { get; set; } 
        public IRPSComboBox<PrintFMEAVersionOptionsDialogView> CodLanguagePrint { get; set; } 
        public IRPSComboBox<PrintFMEAVersionOptionsDialogView> IDRoutePrint { get; set; } 
        public IRPSCheckbox<PrintFMEAVersionOptionsDialogView> PrintFMEA { get; set; } 
        public IRPSOption<PrintFMEAVersionOptionsDialogView> FMEAStandard { get; set; } 
        public IRPSOption<PrintFMEAVersionOptionsDialogView> FMEAStructureComplete { get; set; } 
        public IRPSOption<PrintFMEAVersionOptionsDialogView> FMEACustomReport { get; set; } 
        public IRPSComboBox<PrintFMEAVersionOptionsDialogView> IDFMEACustomReport { get; set; } 
        public IRPSCheckbox<PrintFMEAVersionOptionsDialogView> PrintSynthesis { get; set; } 
        public IRPSOption<PrintFMEAVersionOptionsDialogView> FMEASynthesisStandard { get; set; } 
        public IRPSOption<PrintFMEAVersionOptionsDialogView> CustomFMEASynthesisReport { get; set; } 
        public IRPSComboBox<PrintFMEAVersionOptionsDialogView> IDFMEASynthesisCustomReport { get; set; } 
        public IRPSCheckbox<PrintFMEAVersionOptionsDialogView> IncludeAttachments { get; set; } 
        public IRPSButton<PrintFMEAVersionOptionsDialogView> PrintSelectedDocumentsCommandButton { get; set; } 
        public IRPSButton<PrintFMEAVersionOptionsDialogView> EmailSelectedDocumentsCommandButton { get; set; } 
        public IRPSButton<PrintFMEAVersionOptionsDialogView> ReportByClientEmailCommandButton { get; set; } 
        public FMEAVersion Screen { get; set; }
        public PrintFMEAVersionOptionsDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class RejectionHistoryDialogView : View
    {
        public RejectionHistoryDialogView(FMEAVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_GetDocumentRejections = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ee0dafa3-d709-4d59-8ee2-d91a631d1fbe",CSSSelectorGrid="",XPathGrid=""};
            GetDocumentRejections = RPSControlFactory.RPSCreateCollectionWithGrid<GetDocumentRejectionsCollectionEditor<RejectionHistoryDialogView>,RejectionHistoryDialogView>( params_GetDocumentRejections,this);
 

        }
        public GetDocumentRejectionsCollectionEditor<RejectionHistoryDialogView> GetDocumentRejections { get; set; } 
        public FMEAVersion Screen { get; set; }
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
            VersionStatusFlow_DoneDate = RPSControlFactory.CreateRPSGridTextBox<RejectionHistoryDialogView>("","#ee0dafa3-d709-4d59-8ee2-d91a631d1fbe .ag-row[role='row']@ROWINDEX [col-id='cVersionStatusFlow_DoneDate']","",false, this.CurrentView);
 
            VersionStatusFlow_RejectionReason = RPSControlFactory.CreateRPSGridMemoTextBox<RejectionHistoryDialogView>("","#ee0dafa3-d709-4d59-8ee2-d91a631d1fbe .ag-row[role='row']@ROWINDEX [col-id='cVersionStatusFlow_RejectionReason']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<RejectionHistoryDialogView> VersionStatusFlow_DoneDate { get; set; } 
        public IRPSGridTextBox<RejectionHistoryDialogView> VersionStatusFlow_RejectionReason { get; set; } 
                     
    }
 
    }
  
            
    public partial class FMEATaskByLangView : View
    {
        public FMEATaskByLangView(FMEAVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<FMEATaskByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FMEATaskByLangView,FMEATaskView>( this,Screen.FMEATaskView);
 
            BackButton = RPSControlFactory.RPSBackButton<FMEATaskByLangView,FMEATaskView>( this,Screen.FMEATaskView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<FMEATaskByLangView,FMEATaskView>( this,Screen.FMEATaskView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<FMEATaskByLangView>("597bc55d-5ba5-4741-b3dd-438b68674aa5","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<FMEATaskByLangView>("8fa63392-a46a-48c6-9591-4b20207d0796","","",false, this);
 

        }
        public IRPSButton<FMEATaskByLangView> DeleteButton { get; set; } 
        public IRPSButton<FMEATaskByLangView,FMEATaskView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FMEATaskByLangView,FMEATaskView> BackButton { get; set; } 
        public IRPSAcceptButton<FMEATaskByLangView,FMEATaskView> AcceptButton { get; set; } 
        public IRPSComboBox<FMEATaskByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<FMEATaskByLangView> Description { get; set; } 
        public FMEAVersion Screen { get; set; }
        public FMEATaskByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}