    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.ControlPatternVersion
{
    //RPS VERSION 1.0.0.0
    public partial class ControlPatternVersion:Screen
    {
        public ControlPatternVersion():base()
        {
            this.URL = "quality.controlpatternversion";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ControlPatternVersionCollectionView  = new ControlPatternVersionCollectionView(this); 
            CharacteristicOfControlVersionEntityView  = new CharacteristicOfControlVersionEntityView(this); 
            CharacteristicOfControlView  = new CharacteristicOfControlView(this); 
            CharacteristicOfControlVersionByLangView  = new CharacteristicOfControlVersionByLangView(this); 
            CharacteristicOfControlByLangView  = new CharacteristicOfControlByLangView(this); 
            RejectCharacteristicOfControlVersionDialogView  = new RejectCharacteristicOfControlVersionDialogView(this); 
            RejectionHistoryDialogView  = new RejectionHistoryDialogView(this); 
            CopyFromOtherPatternDialogView  = new CopyFromOtherPatternDialogView(this); 
            PrintReportOptionsDialogView  = new PrintReportOptionsDialogView(this); 
            SelectTaskTreeDialogView  = new SelectTaskTreeDialogView(this); 
            ControlPatternVersionCollectionView.InitializeControls(); 
            CharacteristicOfControlVersionEntityView.InitializeControls(); 
            CharacteristicOfControlView.InitializeControls(); 
            CharacteristicOfControlVersionByLangView.InitializeControls(); 
            CharacteristicOfControlByLangView.InitializeControls(); 
            RejectCharacteristicOfControlVersionDialogView.InitializeControls(); 
            RejectionHistoryDialogView.InitializeControls(); 
            CopyFromOtherPatternDialogView.InitializeControls(); 
            PrintReportOptionsDialogView.InitializeControls(); 
            SelectTaskTreeDialogView.InitializeControls(); 
           
        }
      
            public ControlPatternVersionCollectionView ControlPatternVersionCollectionView {get; set; } 
            public CharacteristicOfControlVersionEntityView CharacteristicOfControlVersionEntityView {get; set; } 
            public CharacteristicOfControlView CharacteristicOfControlView {get; set; } 
            public CharacteristicOfControlVersionByLangView CharacteristicOfControlVersionByLangView {get; set; } 
            public CharacteristicOfControlByLangView CharacteristicOfControlByLangView {get; set; } 
            public RejectCharacteristicOfControlVersionDialogView RejectCharacteristicOfControlVersionDialogView {get; set; } 
            public RejectionHistoryDialogView RejectionHistoryDialogView {get; set; } 
            public CopyFromOtherPatternDialogView CopyFromOtherPatternDialogView {get; set; } 
            public PrintReportOptionsDialogView PrintReportOptionsDialogView {get; set; } 
            public SelectTaskTreeDialogView SelectTaskTreeDialogView {get; set; } 
    }
            
    public partial class ControlPatternVersionCollectionView : View
    {
        public ControlPatternVersionCollectionView(ControlPatternVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ControlPatternVersionCollectionView,CharacteristicOfControlVersionEntityView>( this,Screen.CharacteristicOfControlVersionEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "08416ab6-3a52-4747-890a-d003102ce340",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ControlPatternVersionCollectionView,CharacteristicOfControlVersionEntityView>( params_MainConsult,this,Screen.CharacteristicOfControlVersionEntityView);
 

        }
        public IRPSButton<ControlPatternVersionCollectionView,CharacteristicOfControlVersionEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ControlPatternVersionCollectionView,CharacteristicOfControlVersionEntityView> MainConsult { get; set; } 
        public ControlPatternVersion Screen { get; set; }
        public ControlPatternVersionCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CharacteristicOfControlVersionEntityView : View
    {
        public CharacteristicOfControlVersionEntityView(ControlPatternVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CharacteristicOfControlVersionEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CharacteristicOfControlVersionEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CharacteristicOfControlVersionEntityView,ControlPatternVersionCollectionView>( this,Screen.ControlPatternVersionCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CharacteristicOfControlVersionEntityView,ControlPatternVersionCollectionView>( this,Screen.ControlPatternVersionCollectionView);
 
            UIIDSite = RPSControlFactory.CreateRPSComboBox<CharacteristicOfControlVersionEntityView>("93ac128c-9c5a-401c-a473-e9675e0ef8ab","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<CharacteristicOfControlVersionEntityView>("de47a0c6-620b-43fc-8c31-29f240625784","","",true, this);
 
            IDArticleVersion = RPSControlFactory.CreateRPSComboBox<CharacteristicOfControlVersionEntityView>("1e68d25e-c7bb-4901-bb00-141ff40ceb6e","","",false, this);
 
            UIIDArticleVersionSample = RPSControlFactory.CreateRPSComboBox<CharacteristicOfControlVersionEntityView>("bc811bab-4962-42e3-828b-f5e8fc76779e","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<CharacteristicOfControlVersionEntityView>("8b53436e-3db9-42f5-a034-b0c1bc373349","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<CharacteristicOfControlVersionEntityView>("d4697f1e-eca9-45cd-aa1a-ed85c10f3635","","",false, this);
 
            UIIDSite1 = RPSControlFactory.CreateRPSComboBox<CharacteristicOfControlVersionEntityView>("88b5cafc-c66d-48b8-9c0b-66079a0b25ea","","",false, this);
 
            IDArticle1 = RPSControlFactory.CreateRPSComboBox<CharacteristicOfControlVersionEntityView>("0eb188ff-f6f8-46d3-a377-7fa7062b006d","","",true, this);
 
            IDStructureManufacturing = RPSControlFactory.CreateRPSComboBox<CharacteristicOfControlVersionEntityView>("bbe5454b-724b-48ab-9264-6e58c256c4d3","","",false, this);
 
            IDTaskManufacturing = RPSControlFactory.CreateRPSComboBox<CharacteristicOfControlVersionEntityView>("17a21e50-1b92-4836-96d9-b6a206839910","","",false, this);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<CharacteristicOfControlVersionEntityView>("090d228f-937d-4d0b-8278-5baecbe7f12d","","",false, this);
 
            IDTaskProject = RPSControlFactory.CreateRPSComboBox<CharacteristicOfControlVersionEntityView>("78433b3c-0a16-4bf1-a933-071f6cb47ddc","","",false, this);
 
            SelectTaskTreeCommand = RPSControlFactory.CreateRPSButtonToView<CharacteristicOfControlVersionEntityView,SelectTaskTreeDialogView>("801c7d36-0f28-4d5e-9cdd-c87a9bb9306d","","", this,Screen.SelectTaskTreeDialogView);
 
            IDArticleVersion1 = RPSControlFactory.CreateRPSComboBox<CharacteristicOfControlVersionEntityView>("e24be09c-88ff-4bcd-ab1f-27d5a24f560e","","",false, this);
 
            UIIDArticleVersionSample1 = RPSControlFactory.CreateRPSComboBox<CharacteristicOfControlVersionEntityView>("9cd3e017-9f9a-429b-b863-e9a3f5875b8a","","",false, this);
 
            IDCustomer1 = RPSControlFactory.CreateRPSComboBox<CharacteristicOfControlVersionEntityView>("da329bb3-08d5-4e5e-99e8-9d0136eca122","","",false, this);
 
            Version = RPSControlFactory.CreateRPSTextBox<CharacteristicOfControlVersionEntityView>("18ed18f1-cde5-40c4-b2d4-a3fe1b4f7708","","",true, this);
 
            DocumentNumber = RPSControlFactory.CreateRPSTextBox<CharacteristicOfControlVersionEntityView>("e7d4a893-bd90-4ea7-9abb-305cb39a78d5","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CharacteristicOfControlVersionEntityView>("d3925a2d-aa69-4309-9b4e-0d699633da60","","",false, this);
 
            GroupBySerie = RPSControlFactory.CreateRPSCheckBox<CharacteristicOfControlVersionEntityView>("2023785f-58a3-42b9-9809-a6e7c9f66526","","",false, this);
 
            DoneDate = RPSControlFactory.CreateRPSTextBox<CharacteristicOfControlVersionEntityView>("f3e7b138-ca69-4c0f-9eb4-707f993cd1b7","","",true, this);
 
            CodUserDoneBy = RPSControlFactory.CreateRPSComboBox<CharacteristicOfControlVersionEntityView>("6c544edb-0ec8-48e3-88ec-661520874402","","",true, this);
 
            EndDate = RPSControlFactory.CreateRPSTextBox<CharacteristicOfControlVersionEntityView>("237e7807-0bf2-4eaf-9ec1-fc2c92b00580","","",false, this);
 
            CodUserEnd = RPSControlFactory.CreateRPSComboBox<CharacteristicOfControlVersionEntityView>("2794a624-4c23-4fad-ad98-99ab6c9cc23f","","",false, this);
 
            ApprovedDate = RPSControlFactory.CreateRPSTextBox<CharacteristicOfControlVersionEntityView>("8307091f-e680-4b20-9cc0-7f5731f073f6","","",false, this);
 
            CodUserApprovedBy = RPSControlFactory.CreateRPSComboBox<CharacteristicOfControlVersionEntityView>("65ea2626-490c-433e-a36c-4dadcb88ff1f","","",false, this);
 
            UIPendingLabel = RPSControlFactory.CreateRPSTextBox<CharacteristicOfControlVersionEntityView>("a1a6a1b0-ce44-4974-9c5c-d4062f4a6972","","",false, this);
 
            PendingRevisionCause = RPSControlFactory.CreateRPSTextBox<CharacteristicOfControlVersionEntityView>("01fbe769-c2b7-46b0-8d37-1feb9e2d2d18","","",false, this);
 
            RejectionUser = RPSControlFactory.CreateRPSComboBox<CharacteristicOfControlVersionEntityView>("906ef92f-225b-427a-ae98-2389b7b30bb4","","",false, this);
 
            RejectionDate = RPSControlFactory.CreateRPSTextBox<CharacteristicOfControlVersionEntityView>("abb8f6e2-e878-437a-8810-9c65c481986f","","",false, this);
 
            RejectionReason = RPSControlFactory.CreateRPSTextBox<CharacteristicOfControlVersionEntityView>("01c7275f-14a2-4454-8720-ce895d42fe58","","",false, this);
 
            UIIDRoute = RPSControlFactory.CreateRPSComboBox<CharacteristicOfControlVersionEntityView>("07c016e3-1581-445d-8b8d-e1d015ca6d3e","","",false, this);
 
            Notes = RPSControlFactory.CreateRPSTextBox<CharacteristicOfControlVersionEntityView>("17fb701b-a269-45a5-831f-4e13c0e33f8d","","",false, this);
 
            PrintReportOptionsCommandButton = RPSControlFactory.CreateRPSButtonToView<CharacteristicOfControlVersionEntityView,PrintReportOptionsDialogView>("7d11b2f3-900b-4253-acf8-1e8b1d76aed7","","", this,Screen.PrintReportOptionsDialogView);
 
            FinalizeCommandButton = RPSControlFactory.CreateRPSButton<CharacteristicOfControlVersionEntityView>( "72be435c-5371-41ac-8162-f549c7780f64","","",this);
 
            ApprovalCommandButton = RPSControlFactory.CreateRPSButton<CharacteristicOfControlVersionEntityView>( "dd083004-a2e9-4bf6-b4f5-7ee2f1efd72d","","",this);
 
            RejectCommandButton = RPSControlFactory.CreateRPSButtonToView<CharacteristicOfControlVersionEntityView,RejectCharacteristicOfControlVersionDialogView>("cc1f7bf7-27cf-46ac-804a-6593b6027518","","", this,Screen.RejectCharacteristicOfControlVersionDialogView);
 
            ReceiptCommandButton = RPSControlFactory.CreateRPSButton<CharacteristicOfControlVersionEntityView>( "c5a1c67c-c085-48e7-947f-6b5f288ce17a","","",this);
 
            ReviseCommandButton = RPSControlFactory.CreateRPSButton<CharacteristicOfControlVersionEntityView>( "b82393f4-b9c4-43a2-8364-07b6868d6402","","",this);
 
            ShowRejectionsCommandButton = RPSControlFactory.CreateRPSButtonToView<CharacteristicOfControlVersionEntityView,RejectionHistoryDialogView>("3f1d182e-fcde-457b-9440-1a0019c026ec","","", this,Screen.RejectionHistoryDialogView);
 
            ExecuteImportDataFromFamilyButton = RPSControlFactory.CreateRPSButton<CharacteristicOfControlVersionEntityView>( "9b971728-2872-4212-9f1f-ff2212f129e9","","",this);
 
            ExecuteImportDataFromUsualTaskButton = RPSControlFactory.CreateRPSButton<CharacteristicOfControlVersionEntityView>( "158ab7f2-93fb-4e1a-a072-ece146b34864","","",this);
 
            CopyFromOtherPatternCommandButton = RPSControlFactory.CreateRPSButtonToView<CharacteristicOfControlVersionEntityView,CopyFromOtherPatternDialogView>("79882f05-43d6-4278-b146-b16a360f47c6","","", this,Screen.CopyFromOtherPatternDialogView);
 
            CollectionInit params_CharacteristicOfControls = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a7cfc159-ec43-4ff0-a11e-1c287856d78f",CSSSelectorGrid="",XPathGrid=""};
            CharacteristicOfControls = RPSControlFactory.RPSCreateCollectionWithGrid<CharacteristicOfControlsCollectionEditor<CharacteristicOfControlVersionEntityView,CharacteristicOfControlView>,CharacteristicOfControlVersionEntityView,CharacteristicOfControlView>( params_CharacteristicOfControls,this,Screen.CharacteristicOfControlView);
 
            CollectionInit params_GetCriticalPointsForControlPatternsVersion = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="58a7833a-589e-484c-b97c-5428ebc7fdf7",CSSSelectorGrid="",XPathGrid=""};
            GetCriticalPointsForControlPatternsVersion = RPSControlFactory.RPSCreateCollectionWithGrid<GetCriticalPointsForControlPatternsVersionCollectionEditor<CharacteristicOfControlVersionEntityView,CharacteristicOfControlView>,CharacteristicOfControlVersionEntityView,CharacteristicOfControlView>( params_GetCriticalPointsForControlPatternsVersion,this,Screen.CharacteristicOfControlView);
 
            CollectionInit params_MaterialsWithControlPatternsVersion = new CollectionInit(){IDDescriptor = "10da7ec7-a866-4321-9446-6fb26d4af275",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c4a9e9a8-39a2-4997-ad84-635842409e02",CSSSelectorGrid="",XPathGrid=""};
            MaterialsWithControlPatternsVersion = RPSControlFactory.RPSCreateCollectionWithGrid<MaterialsWithControlPatternsVersionCollectionEditor<CharacteristicOfControlVersionEntityView,CharacteristicOfControlView>,CharacteristicOfControlVersionEntityView,CharacteristicOfControlView>( params_MaterialsWithControlPatternsVersion,this,Screen.CharacteristicOfControlView);
 
            CollectionInit params_CharacteristicOfControlVersionByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="30cb1aa9-6e33-4eb0-9bec-7d0963f22fd5",CSSSelectorGrid="",XPathGrid=""};
            CharacteristicOfControlVersionByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<CharacteristicOfControlVersionByLangsCollectionEditor<CharacteristicOfControlVersionEntityView,CharacteristicOfControlView>,CharacteristicOfControlVersionEntityView,CharacteristicOfControlView>( params_CharacteristicOfControlVersionByLangs,this,Screen.CharacteristicOfControlView);
 
            CharacteristicsToControl = RPSControlFactory.CreateRPSSection<CharacteristicOfControlVersionEntityView>( "","ul li[rpsid='6b92666f-df3c-46d5-97ae-eb2fa0575b57']","",this);
 
            Dangers = RPSControlFactory.CreateRPSSection<CharacteristicOfControlVersionEntityView>( "","ul li[rpsid='be7e8c52-e42f-4d3b-9b3f-2293a29faf55']","",this);
 
            MaterialsWithPattern = RPSControlFactory.CreateRPSSection<CharacteristicOfControlVersionEntityView>( "","ul li[rpsid='9de97966-dd84-4e21-a184-a478c27049c8']","",this);
 
            Structure = RPSControlFactory.CreateRPSSection<CharacteristicOfControlVersionEntityView>( "","ul li[rpsid='0577ee9f-5aaf-4f1a-ad99-60752da61d09']","",this);
 
            ControlVersionByLangs = RPSControlFactory.CreateRPSSection<CharacteristicOfControlVersionEntityView>( "","ul li[rpsid='d9901f2b-4e65-4d4f-bc21-38161526b869']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<CharacteristicOfControlVersionEntityView>( "","ul li[rpsid='e7414f25-2ec2-4cbf-93f4-5725dc2bb556']","",this);
 

        }
        public IRPSSaveButton<CharacteristicOfControlVersionEntityView> SaveButton { get; set; } 
        public IRPSButton<CharacteristicOfControlVersionEntityView> DeleteButton { get; set; } 
        public IRPSButton<CharacteristicOfControlVersionEntityView,ControlPatternVersionCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CharacteristicOfControlVersionEntityView,ControlPatternVersionCollectionView> BackButton { get; set; } 
        public IRPSComboBox<CharacteristicOfControlVersionEntityView> UIIDSite { get; set; } 
        public IRPSComboBox<CharacteristicOfControlVersionEntityView> IDArticle { get; set; } 
        public IRPSComboBox<CharacteristicOfControlVersionEntityView> IDArticleVersion { get; set; } 
        public IRPSComboBox<CharacteristicOfControlVersionEntityView> UIIDArticleVersionSample { get; set; } 
        public IRPSComboBox<CharacteristicOfControlVersionEntityView> IDCustomer { get; set; } 
        public IRPSComboBox<CharacteristicOfControlVersionEntityView> IDSupplier { get; set; } 
        public IRPSComboBox<CharacteristicOfControlVersionEntityView> UIIDSite1 { get; set; } 
        public IRPSComboBox<CharacteristicOfControlVersionEntityView> IDArticle1 { get; set; } 
        public IRPSComboBox<CharacteristicOfControlVersionEntityView> IDStructureManufacturing { get; set; } 
        public IRPSComboBox<CharacteristicOfControlVersionEntityView> IDTaskManufacturing { get; set; } 
        public IRPSComboBox<CharacteristicOfControlVersionEntityView> IDProject { get; set; } 
        public IRPSComboBox<CharacteristicOfControlVersionEntityView> IDTaskProject { get; set; } 
        public IRPSButton<CharacteristicOfControlVersionEntityView,SelectTaskTreeDialogView> SelectTaskTreeCommand { get; set; } 
        public IRPSComboBox<CharacteristicOfControlVersionEntityView> IDArticleVersion1 { get; set; } 
        public IRPSComboBox<CharacteristicOfControlVersionEntityView> UIIDArticleVersionSample1 { get; set; } 
        public IRPSComboBox<CharacteristicOfControlVersionEntityView> IDCustomer1 { get; set; } 
        public IRPSTextBox<CharacteristicOfControlVersionEntityView> Version { get; set; } 
        public IRPSTextBox<CharacteristicOfControlVersionEntityView> DocumentNumber { get; set; } 
        public IRPSTextBox<CharacteristicOfControlVersionEntityView> Description { get; set; } 
        public IRPSCheckbox<CharacteristicOfControlVersionEntityView> GroupBySerie { get; set; } 
        public IRPSTextBox<CharacteristicOfControlVersionEntityView> DoneDate { get; set; } 
        public IRPSComboBox<CharacteristicOfControlVersionEntityView> CodUserDoneBy { get; set; } 
        public IRPSTextBox<CharacteristicOfControlVersionEntityView> EndDate { get; set; } 
        public IRPSComboBox<CharacteristicOfControlVersionEntityView> CodUserEnd { get; set; } 
        public IRPSTextBox<CharacteristicOfControlVersionEntityView> ApprovedDate { get; set; } 
        public IRPSComboBox<CharacteristicOfControlVersionEntityView> CodUserApprovedBy { get; set; } 
        public IRPSTextBox<CharacteristicOfControlVersionEntityView> UIPendingLabel { get; set; } 
        public IRPSTextBox<CharacteristicOfControlVersionEntityView> PendingRevisionCause { get; set; } 
        public IRPSComboBox<CharacteristicOfControlVersionEntityView> RejectionUser { get; set; } 
        public IRPSTextBox<CharacteristicOfControlVersionEntityView> RejectionDate { get; set; } 
        public IRPSTextBox<CharacteristicOfControlVersionEntityView> RejectionReason { get; set; } 
        public IRPSComboBox<CharacteristicOfControlVersionEntityView> UIIDRoute { get; set; } 
        public IRPSTextBox<CharacteristicOfControlVersionEntityView> Notes { get; set; } 
        public IRPSButton<CharacteristicOfControlVersionEntityView,PrintReportOptionsDialogView> PrintReportOptionsCommandButton { get; set; } 
        public IRPSButton<CharacteristicOfControlVersionEntityView> FinalizeCommandButton { get; set; } 
        public IRPSButton<CharacteristicOfControlVersionEntityView> ApprovalCommandButton { get; set; } 
        public IRPSButton<CharacteristicOfControlVersionEntityView,RejectCharacteristicOfControlVersionDialogView> RejectCommandButton { get; set; } 
        public IRPSButton<CharacteristicOfControlVersionEntityView> ReceiptCommandButton { get; set; } 
        public IRPSButton<CharacteristicOfControlVersionEntityView> ReviseCommandButton { get; set; } 
        public IRPSButton<CharacteristicOfControlVersionEntityView,RejectionHistoryDialogView> ShowRejectionsCommandButton { get; set; } 
        public IRPSButton<CharacteristicOfControlVersionEntityView> ExecuteImportDataFromFamilyButton { get; set; } 
        public IRPSButton<CharacteristicOfControlVersionEntityView> ExecuteImportDataFromUsualTaskButton { get; set; } 
        public IRPSButton<CharacteristicOfControlVersionEntityView,CopyFromOtherPatternDialogView> CopyFromOtherPatternCommandButton { get; set; } 
        public CharacteristicOfControlsCollectionEditor<CharacteristicOfControlVersionEntityView,CharacteristicOfControlView> CharacteristicOfControls { get; set; } 
        public GetCriticalPointsForControlPatternsVersionCollectionEditor<CharacteristicOfControlVersionEntityView,CharacteristicOfControlView> GetCriticalPointsForControlPatternsVersion { get; set; } 
        public MaterialsWithControlPatternsVersionCollectionEditor<CharacteristicOfControlVersionEntityView,CharacteristicOfControlView> MaterialsWithControlPatternsVersion { get; set; } 
        public CharacteristicOfControlVersionByLangsCollectionEditor<CharacteristicOfControlVersionEntityView,CharacteristicOfControlView> CharacteristicOfControlVersionByLangs { get; set; } 
        public IRPSSection<CharacteristicOfControlVersionEntityView> CharacteristicsToControl { get; set; } 
        public IRPSSection<CharacteristicOfControlVersionEntityView> Dangers { get; set; } 
        public IRPSSection<CharacteristicOfControlVersionEntityView> MaterialsWithPattern { get; set; } 
        public IRPSSection<CharacteristicOfControlVersionEntityView> Structure { get; set; } 
        public IRPSSection<CharacteristicOfControlVersionEntityView> ControlVersionByLangs { get; set; } 
        public IRPSSection<CharacteristicOfControlVersionEntityView> Comments { get; set; } 
        public ControlPatternVersion Screen { get; set; }
        public CharacteristicOfControlVersionEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CharacteristicOfControlsCollectionEditor<CharacteristicOfControlVersionEntityView,CharacteristicOfControlView>:RPSCollectionEditor<CharacteristicOfControlVersionEntityView,CharacteristicOfControlView> where CharacteristicOfControlVersionEntityView : class, IView where CharacteristicOfControlView : class, IView
    {
        public  CharacteristicOfControlsGridView<CharacteristicOfControlVersionEntityView,CharacteristicOfControlView> GridView {get;set;}
    }
    public partial class CharacteristicOfControlsGridView <CharacteristicOfControlVersionEntityView,CharacteristicOfControlView> :  RPSGridView<CharacteristicOfControlVersionEntityView,CharacteristicOfControlView> where CharacteristicOfControlVersionEntityView : class, IView where CharacteristicOfControlView : class, IView
    {
        public CharacteristicOfControlsGridView(CharacteristicOfControlVersionEntityView currentView,CharacteristicOfControlView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NumCharacteristic = RPSControlFactory.CreateRPSGridFormattedTextBox<CharacteristicOfControlVersionEntityView>("","#a7cfc159-ec43-4ff0-a11e-1c287856d78f .ag-row[role='row']@ROWINDEX [col-id='cNumCharacteristic']","",true, this.CurrentView);
 
            IDCharacteristic = RPSControlFactory.CreateRPSGridComboBox<CharacteristicOfControlVersionEntityView>("","#a7cfc159-ec43-4ff0-a11e-1c287856d78f .ag-row[role='row']@ROWINDEX [col-id='cIDCharacteristic']","",false, this.CurrentView);
 
            IDCharacteristicProcess = RPSControlFactory.CreateRPSGridComboBox<CharacteristicOfControlVersionEntityView>("","#a7cfc159-ec43-4ff0-a11e-1c287856d78f .ag-row[role='row']@ROWINDEX [col-id='cIDCharacteristicProcess']","",false, this.CurrentView);
 
            IDCharacteristicProduct = RPSControlFactory.CreateRPSGridComboBox<CharacteristicOfControlVersionEntityView>("","#a7cfc159-ec43-4ff0-a11e-1c287856d78f .ag-row[role='row']@ROWINDEX [col-id='cIDCharacteristicProduct']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<CharacteristicOfControlVersionEntityView>("","#a7cfc159-ec43-4ff0-a11e-1c287856d78f .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            IDCharacteristicType = RPSControlFactory.CreateRPSGridComboBox<CharacteristicOfControlVersionEntityView>("","#a7cfc159-ec43-4ff0-a11e-1c287856d78f .ag-row[role='row']@ROWINDEX [col-id='cIDCharacteristicType']","",false, this.CurrentView);
 
            ControlType = RPSControlFactory.CreateRPSGridEnumComboBox<CharacteristicOfControlVersionEntityView>("","#a7cfc159-ec43-4ff0-a11e-1c287856d78f .ag-row[role='row']@ROWINDEX [col-id='cControlType']","",false, this.CurrentView);
 
            ViewControlPlan = RPSControlFactory.CreateRPSGridCheckBox<CharacteristicOfControlVersionEntityView>("","#a7cfc159-ec43-4ff0-a11e-1c287856d78f .ag-row[role='row']@ROWINDEX [col-id='cViewControlPlan']","",false, this.CurrentView);
 
            ViewControlPattern = RPSControlFactory.CreateRPSGridCheckBox<CharacteristicOfControlVersionEntityView>("","#a7cfc159-ec43-4ff0-a11e-1c287856d78f .ag-row[role='row']@ROWINDEX [col-id='cViewControlPattern']","",false, this.CurrentView);
 
            ViewMachineParameter = RPSControlFactory.CreateRPSGridCheckBox<CharacteristicOfControlVersionEntityView>("","#a7cfc159-ec43-4ff0-a11e-1c287856d78f .ag-row[role='row']@ROWINDEX [col-id='cViewMachineParameter']","",false, this.CurrentView);
 
            ViewControlSheet = RPSControlFactory.CreateRPSGridCheckBox<CharacteristicOfControlVersionEntityView>("","#a7cfc159-ec43-4ff0-a11e-1c287856d78f .ag-row[role='row']@ROWINDEX [col-id='cViewControlSheet']","",false, this.CurrentView);
 
            ViewCertificate = RPSControlFactory.CreateRPSGridCheckBox<CharacteristicOfControlVersionEntityView>("","#a7cfc159-ec43-4ff0-a11e-1c287856d78f .ag-row[role='row']@ROWINDEX [col-id='cViewCertificate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CharacteristicOfControlVersionEntityView> NumCharacteristic { get; set; } 
        public IRPSGridComboBox<CharacteristicOfControlVersionEntityView> IDCharacteristic { get; set; } 
        public IRPSGridComboBox<CharacteristicOfControlVersionEntityView> IDCharacteristicProcess { get; set; } 
        public IRPSGridComboBox<CharacteristicOfControlVersionEntityView> IDCharacteristicProduct { get; set; } 
        public IRPSGridTextBox<CharacteristicOfControlVersionEntityView> Description { get; set; } 
        public IRPSGridComboBox<CharacteristicOfControlVersionEntityView> IDCharacteristicType { get; set; } 
        public IRPSGridComboBox<CharacteristicOfControlVersionEntityView> ControlType { get; set; } 
        public IRPSGridCheckbox<CharacteristicOfControlVersionEntityView> ViewControlPlan { get; set; } 
        public IRPSGridCheckbox<CharacteristicOfControlVersionEntityView> ViewControlPattern { get; set; } 
        public IRPSGridCheckbox<CharacteristicOfControlVersionEntityView> ViewMachineParameter { get; set; } 
        public IRPSGridCheckbox<CharacteristicOfControlVersionEntityView> ViewControlSheet { get; set; } 
        public IRPSGridCheckbox<CharacteristicOfControlVersionEntityView> ViewCertificate { get; set; } 
                     
    }
 
        public partial class GetCriticalPointsForControlPatternsVersionCollectionEditor<CharacteristicOfControlVersionEntityView,CharacteristicOfControlView>:RPSCollectionEditor<CharacteristicOfControlVersionEntityView,CharacteristicOfControlView> where CharacteristicOfControlVersionEntityView : class, IView where CharacteristicOfControlView : class, IView
    {
        public  GetCriticalPointsForControlPatternsVersionGridView<CharacteristicOfControlVersionEntityView,CharacteristicOfControlView> GridView {get;set;}
    }
    public partial class GetCriticalPointsForControlPatternsVersionGridView <CharacteristicOfControlVersionEntityView,CharacteristicOfControlView> :  RPSGridView<CharacteristicOfControlVersionEntityView,CharacteristicOfControlView> where CharacteristicOfControlVersionEntityView : class, IView where CharacteristicOfControlView : class, IView
    {
        public GetCriticalPointsForControlPatternsVersionGridView(CharacteristicOfControlVersionEntityView currentView,CharacteristicOfControlView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Class = RPSControlFactory.CreateRPSGridTextBox<CharacteristicOfControlVersionEntityView>("","#58a7833a-589e-484c-b97c-5428ebc7fdf7 .ag-row[role='row']@ROWINDEX [col-id='cClass']","",false, this.CurrentView);
 
            Requirement = RPSControlFactory.CreateRPSGridTextBox<CharacteristicOfControlVersionEntityView>("","#58a7833a-589e-484c-b97c-5428ebc7fdf7 .ag-row[role='row']@ROWINDEX [col-id='cRequirement']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CharacteristicOfControlVersionEntityView> Class { get; set; } 
        public IRPSGridTextBox<CharacteristicOfControlVersionEntityView> Requirement { get; set; } 
                     
    }
 
        public partial class MaterialsWithControlPatternsVersionCollectionEditor<CharacteristicOfControlVersionEntityView,CharacteristicOfControlView>:RPSCollectionEditor<CharacteristicOfControlVersionEntityView,CharacteristicOfControlView> where CharacteristicOfControlVersionEntityView : class, IView where CharacteristicOfControlView : class, IView
    {
        public  MaterialsWithControlPatternsVersionGridView<CharacteristicOfControlVersionEntityView,CharacteristicOfControlView> GridView {get;set;}
    }
    public partial class MaterialsWithControlPatternsVersionGridView <CharacteristicOfControlVersionEntityView,CharacteristicOfControlView> :  RPSGridView<CharacteristicOfControlVersionEntityView,CharacteristicOfControlView> where CharacteristicOfControlVersionEntityView : class, IView where CharacteristicOfControlView : class, IView
    {
        public MaterialsWithControlPatternsVersionGridView(CharacteristicOfControlVersionEntityView currentView,CharacteristicOfControlView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            eVersionType = RPSControlFactory.CreateRPSGridEnumComboBox<CharacteristicOfControlVersionEntityView>("","#c4a9e9a8-39a2-4997-ad84-635842409e02 .ag-row[role='row']@ROWINDEX [col-id='ceVersionType']","",false, this.CurrentView);
 
            UIState = RPSControlFactory.CreateRPSGridTextBox<CharacteristicOfControlVersionEntityView>("","#c4a9e9a8-39a2-4997-ad84-635842409e02 .ag-row[role='row']@ROWINDEX [col-id='cUIState']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<CharacteristicOfControlVersionEntityView> eVersionType { get; set; } 
        public IRPSGridTextBox<CharacteristicOfControlVersionEntityView> UIState { get; set; } 
                     
    }
 
        public partial class CharacteristicOfControlVersionByLangsCollectionEditor<CharacteristicOfControlVersionEntityView,CharacteristicOfControlView>:RPSCollectionEditor<CharacteristicOfControlVersionEntityView,CharacteristicOfControlView> where CharacteristicOfControlVersionEntityView : class, IView where CharacteristicOfControlView : class, IView
    {
        public  CharacteristicOfControlVersionByLangsGridView<CharacteristicOfControlVersionEntityView,CharacteristicOfControlView> GridView {get;set;}
    }
    public partial class CharacteristicOfControlVersionByLangsGridView <CharacteristicOfControlVersionEntityView,CharacteristicOfControlView> :  RPSGridView<CharacteristicOfControlVersionEntityView,CharacteristicOfControlView> where CharacteristicOfControlVersionEntityView : class, IView where CharacteristicOfControlView : class, IView
    {
        public CharacteristicOfControlVersionByLangsGridView(CharacteristicOfControlVersionEntityView currentView,CharacteristicOfControlView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<CharacteristicOfControlVersionEntityView>("","#30cb1aa9-6e33-4eb0-9bec-7d0963f22fd5 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            TaskDescription = RPSControlFactory.CreateRPSGridTextBox<CharacteristicOfControlVersionEntityView>("","#30cb1aa9-6e33-4eb0-9bec-7d0963f22fd5 .ag-row[role='row']@ROWINDEX [col-id='cTaskDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<CharacteristicOfControlVersionEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<CharacteristicOfControlVersionEntityView> TaskDescription { get; set; } 
                     
    }
 
    }
  
            
    public partial class CharacteristicOfControlView : View
    {
        public CharacteristicOfControlView(ControlPatternVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CharacteristicOfControlView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CharacteristicOfControlView,CharacteristicOfControlVersionEntityView>( this,Screen.CharacteristicOfControlVersionEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<CharacteristicOfControlView,CharacteristicOfControlVersionEntityView>( this,Screen.CharacteristicOfControlVersionEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CharacteristicOfControlView,CharacteristicOfControlVersionEntityView>( this,Screen.CharacteristicOfControlVersionEntityView);
 
            NumCharacteristic = RPSControlFactory.CreateRPSFormattedTextBox<CharacteristicOfControlView>("00f16a6b-49c5-4c1d-a202-34411618c97b","","",true, this);
 
            IDCharacteristic = RPSControlFactory.CreateRPSComboBox<CharacteristicOfControlView>("0486248d-fdf7-41da-899d-0b8cda1567d3","","",false, this);
 
            IDCharacteristicProduct = RPSControlFactory.CreateRPSComboBox<CharacteristicOfControlView>("e573f828-324a-46d9-b67e-89aa68638771","","",false, this);
 
            IDCharacteristicProcess = RPSControlFactory.CreateRPSComboBox<CharacteristicOfControlView>("25130b84-4f38-4526-adf8-1457e6fd8d34","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CharacteristicOfControlView>("3da817fd-0f94-46b8-9ebb-c0269eaf3980","","",false, this);
 
            IDCharacteristicType = RPSControlFactory.CreateRPSComboBox<CharacteristicOfControlView>("2b1d2a09-cde1-4689-b11c-ec71ddd81829","","",false, this);
 
            IDCharacteristicClass = RPSControlFactory.CreateRPSComboBox<CharacteristicOfControlView>("d05537a0-e871-4c67-a8af-0aa994538dec","","",false, this);
 
            ControlType = RPSControlFactory.CreateRPSEnumComboBox<CharacteristicOfControlView>("c7b0a8c4-b07d-4cb1-b851-951a9d6a1041","","",false, this);
 
            Nominal = RPSControlFactory.CreateRPSFormattedTextBox<CharacteristicOfControlView>("e4f29c90-39b9-48ab-9e3f-5fdeca0f8035","","",false, this);
 
            Min = RPSControlFactory.CreateRPSFormattedTextBox<CharacteristicOfControlView>("7fb5e477-9df3-4f6e-a9ef-d5377066e255","","",false, this);
 
            Max = RPSControlFactory.CreateRPSFormattedTextBox<CharacteristicOfControlView>("54f85a34-2429-4c13-9995-987cf5cdfa26","","",false, this);
 
            InspectBy = RPSControlFactory.CreateRPSTextBox<CharacteristicOfControlView>("70cd5c7e-5ebc-4467-8c65-3d67bcbf4e78","","",false, this);
 
            IDToleranceSpecification = RPSControlFactory.CreateRPSComboBox<CharacteristicOfControlView>("762ce28f-c5e3-4fd4-b28b-fbabdb1200f6","","",false, this);
 
            ToleranceSpecification = RPSControlFactory.CreateRPSTextBox<CharacteristicOfControlView>("ddbbac62-9049-46ae-b4c9-a6658325ffff","","",false, this);
 
            IDMeasureTechnique = RPSControlFactory.CreateRPSComboBox<CharacteristicOfControlView>("553057e6-01e2-4814-a020-dfff6649b52a","","",false, this);
 
            MeasureTechnique = RPSControlFactory.CreateRPSTextBox<CharacteristicOfControlView>("5400cebf-7ec4-4464-a1c8-a794652be5d9","","",false, this);
 
            IDSampleSize = RPSControlFactory.CreateRPSComboBox<CharacteristicOfControlView>("babe5f26-478b-4cbf-a438-6e8008ffc476","","",false, this);
 
            SampleSize = RPSControlFactory.CreateRPSTextBox<CharacteristicOfControlView>("c53aa28a-20f6-45b1-8d2c-174a02bf3f2e","","",false, this);
 
            IDSampleFrequency = RPSControlFactory.CreateRPSComboBox<CharacteristicOfControlView>("db3621e4-a45b-4c9e-aca5-ab0e313b66ba","","",false, this);
 
            SampleFrecuency = RPSControlFactory.CreateRPSTextBox<CharacteristicOfControlView>("606632d6-fbe4-4d16-a539-937c91131fe9","","",false, this);
 
            IDControlMethod = RPSControlFactory.CreateRPSComboBox<CharacteristicOfControlView>("ddd0f100-7e26-4b65-ab74-7b9f978e2d96","","",false, this);
 
            ControlMethod = RPSControlFactory.CreateRPSTextBox<CharacteristicOfControlView>("9ff06d24-9c06-4610-8682-3495b1cf403e","","",false, this);
 
            IDReactionPlan = RPSControlFactory.CreateRPSComboBox<CharacteristicOfControlView>("4c3c6849-3636-417f-87ad-673fa22b743c","","",false, this);
 
            ReactionPlan = RPSControlFactory.CreateRPSTextBox<CharacteristicOfControlView>("625c11b4-3cc6-4abf-b07c-a18c24f9eccc","","",false, this);
 
            ViewControlPlan = RPSControlFactory.CreateRPSCheckBox<CharacteristicOfControlView>("5493ffe2-a8e5-4968-8478-69ab97829538","","",false, this);
 
            ViewControlPattern = RPSControlFactory.CreateRPSCheckBox<CharacteristicOfControlView>("fb4c8569-8d11-4da1-9658-79f27b1d8824","","",false, this);
 
            ViewMachineParameter = RPSControlFactory.CreateRPSCheckBox<CharacteristicOfControlView>("ab26e8e9-d447-49d7-9e97-2dd35bbf6ffe","","",false, this);
 
            ViewControlSheet = RPSControlFactory.CreateRPSCheckBox<CharacteristicOfControlView>("1dd10d9a-b7d0-4e02-8899-0ad6fad65f29","","",false, this);
 
            ViewCertificate = RPSControlFactory.CreateRPSCheckBox<CharacteristicOfControlView>("6a1dd1aa-48ea-4ba0-acdd-3e63cb0d033f","","",false, this);
 
            AQIsRequired = RPSControlFactory.CreateRPSCheckBox<CharacteristicOfControlView>("fb675a03-c7dd-46da-b91c-5aeeec3f6a0d","","",true, this);
 
            AQDrawingPosition = RPSControlFactory.CreateRPSTextBox<CharacteristicOfControlView>("b5872d31-220e-4df8-b70d-ca0e17847c32","","",false, this);
 
            AQInspectedBy = RPSControlFactory.CreateRPSEnumComboBox<CharacteristicOfControlView>("413e4213-a71e-4132-bff3-06aca91b4b70","","",true, this);
 
            AQIDMeasuringInstrument = RPSControlFactory.CreateRPSComboBox<CharacteristicOfControlView>("8785a8cf-ce02-481a-8629-5f3f94974fb2","","",false, this);
 
            AQSamplesNumber = RPSControlFactory.CreateRPSFormattedTextBox<CharacteristicOfControlView>("cd91912f-615b-4de6-a04f-83ad250604e3","","",true, this);
 
            AQFrequency = RPSControlFactory.CreateRPSFormattedTextBox<CharacteristicOfControlView>("fb905e45-23e5-497d-8521-9c7b0ac9b4c9","","",true, this);
 
            AQIDFrequencyUnit = RPSControlFactory.CreateRPSComboBox<CharacteristicOfControlView>("45d898f9-d479-4215-901e-18b7c9bd3968","","",false, this);
 
            AQIDFrequencyType = RPSControlFactory.CreateRPSComboBox<CharacteristicOfControlView>("2ce3f1c9-f211-4b1c-bad5-e0e7769f2d0a","","",false, this);
 
            AQRBase = RPSControlFactory.CreateRPSFormattedTextBox<CharacteristicOfControlView>("0a1f9840-6115-4264-8582-b3196e4d03ef","","",true, this);
 
            AQIsCountable = RPSControlFactory.CreateRPSCheckBox<CharacteristicOfControlView>("86c50dc1-edf1-420b-a909-9fe68bd9889f","","",true, this);
 
            AQControlType = RPSControlFactory.CreateRPSEnumComboBox<CharacteristicOfControlView>("9dad43ba-2847-4e65-914d-72374b8b4840","","",true, this);
 
            AQToleranceType = RPSControlFactory.CreateRPSEnumComboBox<CharacteristicOfControlView>("9c31e7c3-99b7-4ea7-9f82-d8c124772d2d","","",true, this);
 
            Nominal1 = RPSControlFactory.CreateRPSFormattedTextBox<CharacteristicOfControlView>("e896e598-a94b-454b-a0d2-01a3cddcae18","","",false, this);
 
            Max1 = RPSControlFactory.CreateRPSFormattedTextBox<CharacteristicOfControlView>("fd0a0e5c-6b56-4a45-a9c9-1ce9bca21fd3","","",false, this);
 
            Min1 = RPSControlFactory.CreateRPSFormattedTextBox<CharacteristicOfControlView>("79696668-25d7-428c-acd2-3886528850ac","","",false, this);
 
            AQLCType = RPSControlFactory.CreateRPSEnumComboBox<CharacteristicOfControlView>("6ff6d8b7-7428-456e-a7af-d26a53754387","","",true, this);
 
            AQLCMS = RPSControlFactory.CreateRPSFormattedTextBox<CharacteristicOfControlView>("fcadaf11-25fa-41a3-9571-e7a3adb793b1","","",true, this);
 
            AQLCMI = RPSControlFactory.CreateRPSFormattedTextBox<CharacteristicOfControlView>("02f9a4fc-134f-4d44-af28-5106f0f84d6c","","",true, this);
 
            AQLCRS = RPSControlFactory.CreateRPSFormattedTextBox<CharacteristicOfControlView>("f05e11a9-b7d0-4260-9266-8281cb466505","","",true, this);
 
            AQLCRI = RPSControlFactory.CreateRPSFormattedTextBox<CharacteristicOfControlView>("87c86b99-b624-4c0f-9c09-8d16f0c9d335","","",true, this);
 
            AQMeasureUnit = RPSControlFactory.CreateRPSTextBox<CharacteristicOfControlView>("ee7c6ff6-1179-482b-889a-82b7c8a3935b","","",false, this);
 
            AQOperatorNotes = RPSControlFactory.CreateRPSTextBox<CharacteristicOfControlView>("68c61118-5337-48c4-b110-bd3baa1173ba","","",false, this);
 
            AQInspectorNotes = RPSControlFactory.CreateRPSTextBox<CharacteristicOfControlView>("56237213-89ab-46dc-9b6a-827759a385b2","","",false, this);
 
            CollectionInit params_CharacteristicOfControlByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="2ae1e26d-64f3-4239-b4ca-a8afefc723e4",CSSSelectorGrid="",XPathGrid=""};
            CharacteristicOfControlByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<CharacteristicOfControlByLangsCollectionEditor<CharacteristicOfControlView,CharacteristicOfControlByLangView>,CharacteristicOfControlView,CharacteristicOfControlByLangView>( params_CharacteristicOfControlByLangs,this,Screen.CharacteristicOfControlByLangView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<CharacteristicOfControlView>( "","ul li[rpsid='ce5d4d37-ac8f-4281-a839-999f4cf398a9']","",this);
 
            CharacteristicByLangs = RPSControlFactory.CreateRPSSection<CharacteristicOfControlView>( "","ul li[rpsid='e55938bb-50ef-40f7-b721-ae04ad88bb51']","",this);
 
            AutoQ = RPSControlFactory.CreateRPSSection<CharacteristicOfControlView>( "","ul li[rpsid='25be35d5-6f5a-4eed-b1c0-89e20a1cc162']","",this);
 

        }
        public IRPSButton<CharacteristicOfControlView> DeleteButton { get; set; } 
        public IRPSButton<CharacteristicOfControlView,CharacteristicOfControlVersionEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CharacteristicOfControlView,CharacteristicOfControlVersionEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CharacteristicOfControlView,CharacteristicOfControlVersionEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<CharacteristicOfControlView> NumCharacteristic { get; set; } 
        public IRPSComboBox<CharacteristicOfControlView> IDCharacteristic { get; set; } 
        public IRPSComboBox<CharacteristicOfControlView> IDCharacteristicProduct { get; set; } 
        public IRPSComboBox<CharacteristicOfControlView> IDCharacteristicProcess { get; set; } 
        public IRPSTextBox<CharacteristicOfControlView> Description { get; set; } 
        public IRPSComboBox<CharacteristicOfControlView> IDCharacteristicType { get; set; } 
        public IRPSComboBox<CharacteristicOfControlView> IDCharacteristicClass { get; set; } 
        public IRPSComboBox<CharacteristicOfControlView> ControlType { get; set; } 
        public IRPSTextBox<CharacteristicOfControlView> Nominal { get; set; } 
        public IRPSTextBox<CharacteristicOfControlView> Min { get; set; } 
        public IRPSTextBox<CharacteristicOfControlView> Max { get; set; } 
        public IRPSTextBox<CharacteristicOfControlView> InspectBy { get; set; } 
        public IRPSComboBox<CharacteristicOfControlView> IDToleranceSpecification { get; set; } 
        public IRPSTextBox<CharacteristicOfControlView> ToleranceSpecification { get; set; } 
        public IRPSComboBox<CharacteristicOfControlView> IDMeasureTechnique { get; set; } 
        public IRPSTextBox<CharacteristicOfControlView> MeasureTechnique { get; set; } 
        public IRPSComboBox<CharacteristicOfControlView> IDSampleSize { get; set; } 
        public IRPSTextBox<CharacteristicOfControlView> SampleSize { get; set; } 
        public IRPSComboBox<CharacteristicOfControlView> IDSampleFrequency { get; set; } 
        public IRPSTextBox<CharacteristicOfControlView> SampleFrecuency { get; set; } 
        public IRPSComboBox<CharacteristicOfControlView> IDControlMethod { get; set; } 
        public IRPSTextBox<CharacteristicOfControlView> ControlMethod { get; set; } 
        public IRPSComboBox<CharacteristicOfControlView> IDReactionPlan { get; set; } 
        public IRPSTextBox<CharacteristicOfControlView> ReactionPlan { get; set; } 
        public IRPSCheckbox<CharacteristicOfControlView> ViewControlPlan { get; set; } 
        public IRPSCheckbox<CharacteristicOfControlView> ViewControlPattern { get; set; } 
        public IRPSCheckbox<CharacteristicOfControlView> ViewMachineParameter { get; set; } 
        public IRPSCheckbox<CharacteristicOfControlView> ViewControlSheet { get; set; } 
        public IRPSCheckbox<CharacteristicOfControlView> ViewCertificate { get; set; } 
        public IRPSCheckbox<CharacteristicOfControlView> AQIsRequired { get; set; } 
        public IRPSTextBox<CharacteristicOfControlView> AQDrawingPosition { get; set; } 
        public IRPSComboBox<CharacteristicOfControlView> AQInspectedBy { get; set; } 
        public IRPSComboBox<CharacteristicOfControlView> AQIDMeasuringInstrument { get; set; } 
        public IRPSTextBox<CharacteristicOfControlView> AQSamplesNumber { get; set; } 
        public IRPSTextBox<CharacteristicOfControlView> AQFrequency { get; set; } 
        public IRPSComboBox<CharacteristicOfControlView> AQIDFrequencyUnit { get; set; } 
        public IRPSComboBox<CharacteristicOfControlView> AQIDFrequencyType { get; set; } 
        public IRPSTextBox<CharacteristicOfControlView> AQRBase { get; set; } 
        public IRPSCheckbox<CharacteristicOfControlView> AQIsCountable { get; set; } 
        public IRPSComboBox<CharacteristicOfControlView> AQControlType { get; set; } 
        public IRPSComboBox<CharacteristicOfControlView> AQToleranceType { get; set; } 
        public IRPSTextBox<CharacteristicOfControlView> Nominal1 { get; set; } 
        public IRPSTextBox<CharacteristicOfControlView> Max1 { get; set; } 
        public IRPSTextBox<CharacteristicOfControlView> Min1 { get; set; } 
        public IRPSComboBox<CharacteristicOfControlView> AQLCType { get; set; } 
        public IRPSTextBox<CharacteristicOfControlView> AQLCMS { get; set; } 
        public IRPSTextBox<CharacteristicOfControlView> AQLCMI { get; set; } 
        public IRPSTextBox<CharacteristicOfControlView> AQLCRS { get; set; } 
        public IRPSTextBox<CharacteristicOfControlView> AQLCRI { get; set; } 
        public IRPSTextBox<CharacteristicOfControlView> AQMeasureUnit { get; set; } 
        public IRPSTextBox<CharacteristicOfControlView> AQOperatorNotes { get; set; } 
        public IRPSTextBox<CharacteristicOfControlView> AQInspectorNotes { get; set; } 
        public CharacteristicOfControlByLangsCollectionEditor<CharacteristicOfControlView,CharacteristicOfControlByLangView> CharacteristicOfControlByLangs { get; set; } 
        public IRPSSection<CharacteristicOfControlView> GeneralData { get; set; } 
        public IRPSSection<CharacteristicOfControlView> CharacteristicByLangs { get; set; } 
        public IRPSSection<CharacteristicOfControlView> AutoQ { get; set; } 
        public ControlPatternVersion Screen { get; set; }
        public CharacteristicOfControlView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CharacteristicOfControlByLangsCollectionEditor<CharacteristicOfControlView,CharacteristicOfControlByLangView>:RPSCollectionEditor<CharacteristicOfControlView,CharacteristicOfControlByLangView> where CharacteristicOfControlView : class, IView where CharacteristicOfControlByLangView : class, IView
    {
        public  CharacteristicOfControlByLangsGridView<CharacteristicOfControlView,CharacteristicOfControlByLangView> GridView {get;set;}
    }
    public partial class CharacteristicOfControlByLangsGridView <CharacteristicOfControlView,CharacteristicOfControlByLangView> :  RPSGridView<CharacteristicOfControlView,CharacteristicOfControlByLangView> where CharacteristicOfControlView : class, IView where CharacteristicOfControlByLangView : class, IView
    {
        public CharacteristicOfControlByLangsGridView(CharacteristicOfControlView currentView,CharacteristicOfControlByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<CharacteristicOfControlView>("","#2ae1e26d-64f3-4239-b4ca-a8afefc723e4 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<CharacteristicOfControlView>("","#2ae1e26d-64f3-4239-b4ca-a8afefc723e4 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<CharacteristicOfControlView> CodLanguage { get; set; } 
        public IRPSGridTextBox<CharacteristicOfControlView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class CharacteristicOfControlVersionByLangView : View
    {
        public CharacteristicOfControlVersionByLangView(ControlPatternVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CharacteristicOfControlVersionByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CharacteristicOfControlVersionByLangView,CharacteristicOfControlVersionEntityView>( this,Screen.CharacteristicOfControlVersionEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<CharacteristicOfControlVersionByLangView,CharacteristicOfControlVersionEntityView>( this,Screen.CharacteristicOfControlVersionEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CharacteristicOfControlVersionByLangView,CharacteristicOfControlVersionEntityView>( this,Screen.CharacteristicOfControlVersionEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<CharacteristicOfControlVersionByLangView>("efa95039-b36a-4c6b-a9bd-a4f51d37d6e1","","",true, this);
 
            TaskDescription = RPSControlFactory.CreateRPSTextBox<CharacteristicOfControlVersionByLangView>("47fa27cb-2475-47e3-9c06-8f3c654d4e34","","",false, this);
 

        }
        public IRPSButton<CharacteristicOfControlVersionByLangView> DeleteButton { get; set; } 
        public IRPSButton<CharacteristicOfControlVersionByLangView,CharacteristicOfControlVersionEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CharacteristicOfControlVersionByLangView,CharacteristicOfControlVersionEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CharacteristicOfControlVersionByLangView,CharacteristicOfControlVersionEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<CharacteristicOfControlVersionByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<CharacteristicOfControlVersionByLangView> TaskDescription { get; set; } 
        public ControlPatternVersion Screen { get; set; }
        public CharacteristicOfControlVersionByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CharacteristicOfControlByLangView : View
    {
        public CharacteristicOfControlByLangView(ControlPatternVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CharacteristicOfControlByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CharacteristicOfControlByLangView,CharacteristicOfControlView>( this,Screen.CharacteristicOfControlView);
 
            BackButton = RPSControlFactory.RPSBackButton<CharacteristicOfControlByLangView,CharacteristicOfControlView>( this,Screen.CharacteristicOfControlView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CharacteristicOfControlByLangView,CharacteristicOfControlView>( this,Screen.CharacteristicOfControlView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<CharacteristicOfControlByLangView>("8dc30800-4691-4602-b85b-a288e557061f","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CharacteristicOfControlByLangView>("c907ff04-b8ae-4a54-9927-33a1a85f170f","","",false, this);
 
            ToleranceSpecification = RPSControlFactory.CreateRPSTextBox<CharacteristicOfControlByLangView>("38dfcd42-f9be-4d5b-9daa-9f810a06a358","","",false, this);
 
            MeasureTechnique = RPSControlFactory.CreateRPSTextBox<CharacteristicOfControlByLangView>("947965be-1d6f-4d11-827e-8082037562bd","","",false, this);
 
            SampleSize = RPSControlFactory.CreateRPSTextBox<CharacteristicOfControlByLangView>("2fea836a-4888-45a6-a608-ce31c322f98d","","",false, this);
 
            SampleFrecuency = RPSControlFactory.CreateRPSTextBox<CharacteristicOfControlByLangView>("7daec892-8669-4e38-be86-463507087b27","","",false, this);
 
            ControlMethod = RPSControlFactory.CreateRPSTextBox<CharacteristicOfControlByLangView>("7c8afd95-7988-463d-8fef-c02f8af02121","","",false, this);
 
            ReactionPlan = RPSControlFactory.CreateRPSTextBox<CharacteristicOfControlByLangView>("760be388-470a-4785-9b61-6c5a3c31373f","","",false, this);
 

        }
        public IRPSButton<CharacteristicOfControlByLangView> DeleteButton { get; set; } 
        public IRPSButton<CharacteristicOfControlByLangView,CharacteristicOfControlView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CharacteristicOfControlByLangView,CharacteristicOfControlView> BackButton { get; set; } 
        public IRPSAcceptButton<CharacteristicOfControlByLangView,CharacteristicOfControlView> AcceptButton { get; set; } 
        public IRPSComboBox<CharacteristicOfControlByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<CharacteristicOfControlByLangView> Description { get; set; } 
        public IRPSTextBox<CharacteristicOfControlByLangView> ToleranceSpecification { get; set; } 
        public IRPSTextBox<CharacteristicOfControlByLangView> MeasureTechnique { get; set; } 
        public IRPSTextBox<CharacteristicOfControlByLangView> SampleSize { get; set; } 
        public IRPSTextBox<CharacteristicOfControlByLangView> SampleFrecuency { get; set; } 
        public IRPSTextBox<CharacteristicOfControlByLangView> ControlMethod { get; set; } 
        public IRPSTextBox<CharacteristicOfControlByLangView> ReactionPlan { get; set; } 
        public ControlPatternVersion Screen { get; set; }
        public CharacteristicOfControlByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class RejectCharacteristicOfControlVersionDialogView : View
    {
        public RejectCharacteristicOfControlVersionDialogView(ControlPatternVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            RejectionDate = RPSControlFactory.CreateRPSTextBox<RejectCharacteristicOfControlVersionDialogView>("65c9e7c0-f61c-4b81-bd94-15ae4bdcd4c6","","",true, this);
 
            RejectionReason = RPSControlFactory.CreateRPSTextBox<RejectCharacteristicOfControlVersionDialogView>("378b18d9-82ff-4098-9740-a19ca9d7ebfd","","",true, this);
 

        }
        public IRPSTextBox<RejectCharacteristicOfControlVersionDialogView> RejectionDate { get; set; } 
        public IRPSTextBox<RejectCharacteristicOfControlVersionDialogView> RejectionReason { get; set; } 
        public ControlPatternVersion Screen { get; set; }
        public RejectCharacteristicOfControlVersionDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class RejectionHistoryDialogView : View
    {
        public RejectionHistoryDialogView(ControlPatternVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_GetDocumentRejections = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="87cce202-7eee-490b-9de9-b8e83692a8d4",CSSSelectorGrid="",XPathGrid=""};
            GetDocumentRejections = RPSControlFactory.RPSCreateCollectionWithGrid<GetDocumentRejectionsCollectionEditor<RejectionHistoryDialogView>,RejectionHistoryDialogView>( params_GetDocumentRejections,this);
 

        }
        public GetDocumentRejectionsCollectionEditor<RejectionHistoryDialogView> GetDocumentRejections { get; set; } 
        public ControlPatternVersion Screen { get; set; }
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
            VersionStatusFlow_DoneDate = RPSControlFactory.CreateRPSGridTextBox<RejectionHistoryDialogView>("","#87cce202-7eee-490b-9de9-b8e83692a8d4 .ag-row[role='row']@ROWINDEX [col-id='cVersionStatusFlow_DoneDate']","",false, this.CurrentView);
 
            VersionStatusFlow_RejectionReason = RPSControlFactory.CreateRPSGridMemoTextBox<RejectionHistoryDialogView>("","#87cce202-7eee-490b-9de9-b8e83692a8d4 .ag-row[role='row']@ROWINDEX [col-id='cVersionStatusFlow_RejectionReason']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<RejectionHistoryDialogView> VersionStatusFlow_DoneDate { get; set; } 
        public IRPSGridTextBox<RejectionHistoryDialogView> VersionStatusFlow_RejectionReason { get; set; } 
                     
    }
 
    }
  
            
    public partial class CopyFromOtherPatternDialogView : View
    {
        public CopyFromOtherPatternDialogView(ControlPatternVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSComboBox<CopyFromOtherPatternDialogView>("39aa2b32-bf9c-455c-b068-2a7b3c194ea8","","",false, this);
 
            IDStructure = RPSControlFactory.CreateRPSComboBox<CopyFromOtherPatternDialogView>("f7cbf156-0b96-441c-ba0a-8c9b38e3fa52","","",false, this);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<CopyFromOtherPatternDialogView>("b3b57701-10a3-43a4-ba5a-6571b0afd453","","",false, this);
 
            IDTaskManufacturing = RPSControlFactory.CreateRPSComboBox<CopyFromOtherPatternDialogView>("530d8787-9a9e-4caf-826a-9352a670eb35","","",false, this);
 
            IDTaskProject = RPSControlFactory.CreateRPSComboBox<CopyFromOtherPatternDialogView>("4fd12615-210a-4811-8630-fb18aacefa14","","",false, this);
 
            IDControlPatternVersion = RPSControlFactory.CreateRPSComboBox<CopyFromOtherPatternDialogView>("2b8a8a95-11ef-4673-b4d3-becd0e28ca48","","",true, this);
 
            IDMachinePatternVersion = RPSControlFactory.CreateRPSComboBox<CopyFromOtherPatternDialogView>("c1e4081c-50f6-4adc-a1e7-94f3af93b048","","",true, this);
 
            IDReceptionPatternVersion = RPSControlFactory.CreateRPSComboBox<CopyFromOtherPatternDialogView>("dcaeafef-f02a-4fc9-b4dc-fae65ccaf85b","","",true, this);
 
            IDFinalPatternVersion = RPSControlFactory.CreateRPSComboBox<CopyFromOtherPatternDialogView>("c68cf088-15e4-475d-8797-92dddfcfb4d4","","",true, this);
 

        }
        public IRPSComboBox<CopyFromOtherPatternDialogView> IDArticle { get; set; } 
        public IRPSComboBox<CopyFromOtherPatternDialogView> IDStructure { get; set; } 
        public IRPSComboBox<CopyFromOtherPatternDialogView> IDProject { get; set; } 
        public IRPSComboBox<CopyFromOtherPatternDialogView> IDTaskManufacturing { get; set; } 
        public IRPSComboBox<CopyFromOtherPatternDialogView> IDTaskProject { get; set; } 
        public IRPSComboBox<CopyFromOtherPatternDialogView> IDControlPatternVersion { get; set; } 
        public IRPSComboBox<CopyFromOtherPatternDialogView> IDMachinePatternVersion { get; set; } 
        public IRPSComboBox<CopyFromOtherPatternDialogView> IDReceptionPatternVersion { get; set; } 
        public IRPSComboBox<CopyFromOtherPatternDialogView> IDFinalPatternVersion { get; set; } 
        public ControlPatternVersion Screen { get; set; }
        public CopyFromOtherPatternDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PrintReportOptionsDialogView : View
    {
        public PrintReportOptionsDialogView(ControlPatternVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDControlPatternCustomReport = RPSControlFactory.CreateRPSComboBox<PrintReportOptionsDialogView>("2d26b13a-9478-49fc-aaec-a619546a701b","","",false, this);
 
            IDMachinePatternCustomReport = RPSControlFactory.CreateRPSComboBox<PrintReportOptionsDialogView>("c6be91a1-fcd5-44c9-a49f-517a4224a512","","",false, this);
 
            IDReceptionPatternCustomReport = RPSControlFactory.CreateRPSComboBox<PrintReportOptionsDialogView>("09daf261-7ad4-4811-af42-f9c7b13ea74c","","",false, this);
 
            IDFinalPatternCustomReport = RPSControlFactory.CreateRPSComboBox<PrintReportOptionsDialogView>("9ea5f38c-81e2-4447-b9e5-0b3068f68a58","","",false, this);
 
            IncludeAttachments = RPSControlFactory.CreateRPSCheckBox<PrintReportOptionsDialogView>("5d421860-f9a3-4b36-9e20-90cb89b74273","","",false, this);
 

        }
        public IRPSComboBox<PrintReportOptionsDialogView> IDControlPatternCustomReport { get; set; } 
        public IRPSComboBox<PrintReportOptionsDialogView> IDMachinePatternCustomReport { get; set; } 
        public IRPSComboBox<PrintReportOptionsDialogView> IDReceptionPatternCustomReport { get; set; } 
        public IRPSComboBox<PrintReportOptionsDialogView> IDFinalPatternCustomReport { get; set; } 
        public IRPSCheckbox<PrintReportOptionsDialogView> IncludeAttachments { get; set; } 
        public ControlPatternVersion Screen { get; set; }
        public PrintReportOptionsDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SelectTaskTreeDialogView : View
    {
        public SelectTaskTreeDialogView(ControlPatternVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public ControlPatternVersion Screen { get; set; }
        public SelectTaskTreeDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}