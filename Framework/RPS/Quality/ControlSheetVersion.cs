    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.ControlSheetVersion
{
    //RPS VERSION 1.0.0.0
    public partial class ControlSheetVersion:Screen
    {
        public ControlSheetVersion():base()
        {
            this.URL = "quality.controlsheetversion";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ControlSheetVersionCollectionView  = new ControlSheetVersionCollectionView(this); 
            ControlSheetVersionEntityView  = new ControlSheetVersionEntityView(this); 
            ControlSheetCharacView  = new ControlSheetCharacView(this); 
            ControlSheetValueView  = new ControlSheetValueView(this); 
            ControlSheetCharacByLangView  = new ControlSheetCharacByLangView(this); 
            ControlSheetInspectionView  = new ControlSheetInspectionView(this); 
            ControlSheetResidueView  = new ControlSheetResidueView(this); 
            ControlSheetResidueControlView  = new ControlSheetResidueControlView(this); 
            ControlSheetResidueValueView  = new ControlSheetResidueValueView(this); 
            RejectControlSheetVersionDialogView  = new RejectControlSheetVersionDialogView(this); 
            RejectionHistoryDialogView  = new RejectionHistoryDialogView(this); 
            SelectTaskTreeDialogView  = new SelectTaskTreeDialogView(this); 
            CopyFromOtherSheetDialogView  = new CopyFromOtherSheetDialogView(this); 
            CopyFromOtherReceptionSheetDialogView  = new CopyFromOtherReceptionSheetDialogView(this); 
            CopyFromOtherFinalSheetDialogView  = new CopyFromOtherFinalSheetDialogView(this); 
            CreateNewNonConformityDialogView  = new CreateNewNonConformityDialogView(this); 
            PrintReportOptionsDialogView  = new PrintReportOptionsDialogView(this); 
            ControlSheetFinalImportCharacsView  = new ControlSheetFinalImportCharacsView(this); 
            ControlSheetVersionByLangView  = new ControlSheetVersionByLangView(this); 
            FinalizeReceptionInspectionDialogView  = new FinalizeReceptionInspectionDialogView(this); 
            ControlSheetVersionCollectionView.InitializeControls(); 
            ControlSheetVersionEntityView.InitializeControls(); 
            ControlSheetCharacView.InitializeControls(); 
            ControlSheetValueView.InitializeControls(); 
            ControlSheetCharacByLangView.InitializeControls(); 
            ControlSheetInspectionView.InitializeControls(); 
            ControlSheetResidueView.InitializeControls(); 
            ControlSheetResidueControlView.InitializeControls(); 
            ControlSheetResidueValueView.InitializeControls(); 
            RejectControlSheetVersionDialogView.InitializeControls(); 
            RejectionHistoryDialogView.InitializeControls(); 
            SelectTaskTreeDialogView.InitializeControls(); 
            CopyFromOtherSheetDialogView.InitializeControls(); 
            CopyFromOtherReceptionSheetDialogView.InitializeControls(); 
            CopyFromOtherFinalSheetDialogView.InitializeControls(); 
            CreateNewNonConformityDialogView.InitializeControls(); 
            PrintReportOptionsDialogView.InitializeControls(); 
            ControlSheetFinalImportCharacsView.InitializeControls(); 
            ControlSheetVersionByLangView.InitializeControls(); 
            FinalizeReceptionInspectionDialogView.InitializeControls(); 
           
        }
      
            public ControlSheetVersionCollectionView ControlSheetVersionCollectionView {get; set; } 
            public ControlSheetVersionEntityView ControlSheetVersionEntityView {get; set; } 
            public ControlSheetCharacView ControlSheetCharacView {get; set; } 
            public ControlSheetValueView ControlSheetValueView {get; set; } 
            public ControlSheetCharacByLangView ControlSheetCharacByLangView {get; set; } 
            public ControlSheetInspectionView ControlSheetInspectionView {get; set; } 
            public ControlSheetResidueView ControlSheetResidueView {get; set; } 
            public ControlSheetResidueControlView ControlSheetResidueControlView {get; set; } 
            public ControlSheetResidueValueView ControlSheetResidueValueView {get; set; } 
            public RejectControlSheetVersionDialogView RejectControlSheetVersionDialogView {get; set; } 
            public RejectionHistoryDialogView RejectionHistoryDialogView {get; set; } 
            public SelectTaskTreeDialogView SelectTaskTreeDialogView {get; set; } 
            public CopyFromOtherSheetDialogView CopyFromOtherSheetDialogView {get; set; } 
            public CopyFromOtherReceptionSheetDialogView CopyFromOtherReceptionSheetDialogView {get; set; } 
            public CopyFromOtherFinalSheetDialogView CopyFromOtherFinalSheetDialogView {get; set; } 
            public CreateNewNonConformityDialogView CreateNewNonConformityDialogView {get; set; } 
            public PrintReportOptionsDialogView PrintReportOptionsDialogView {get; set; } 
            public ControlSheetFinalImportCharacsView ControlSheetFinalImportCharacsView {get; set; } 
            public ControlSheetVersionByLangView ControlSheetVersionByLangView {get; set; } 
            public FinalizeReceptionInspectionDialogView FinalizeReceptionInspectionDialogView {get; set; } 
    }
            
    public partial class ControlSheetVersionCollectionView : View
    {
        public ControlSheetVersionCollectionView(ControlSheetVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ControlSheetVersionCollectionView,ControlSheetVersionEntityView>( this,Screen.ControlSheetVersionEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "5324a55f-524a-4192-a37c-d124ee971036",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ControlSheetVersionCollectionView,ControlSheetVersionEntityView>( params_MainConsult,this,Screen.ControlSheetVersionEntityView);
 

        }
        public IRPSButton<ControlSheetVersionCollectionView,ControlSheetVersionEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ControlSheetVersionCollectionView,ControlSheetVersionEntityView> MainConsult { get; set; } 
        public ControlSheetVersion Screen { get; set; }
        public ControlSheetVersionCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ControlSheetVersionEntityView : View
    {
        public ControlSheetVersionEntityView(ControlSheetVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ControlSheetVersionEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ControlSheetVersionEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ControlSheetVersionEntityView,ControlSheetVersionCollectionView>( this,Screen.ControlSheetVersionCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ControlSheetVersionEntityView,ControlSheetVersionCollectionView>( this,Screen.ControlSheetVersionCollectionView);
 
            UIIDSite = RPSControlFactory.CreateRPSComboBox<ControlSheetVersionEntityView>("2092b8d1-c6b7-4598-8144-4418b4ee500a","","",false, this);
 
            ManufacturingOrder = RPSControlFactory.CreateRPSOption<ControlSheetVersionEntityView>( "b8334c48-b273-4575-8fc7-9e881273d636","","",this);
 
            Project = RPSControlFactory.CreateRPSOption<ControlSheetVersionEntityView>( "3ae612d3-82b6-425c-84d2-8b710d126580","","",this);
 
            IDManufacturingOrder = RPSControlFactory.CreateRPSComboBox<ControlSheetVersionEntityView>("94958ca1-4fe0-4d9b-aafa-857e58f94e68","","",false, this);
 
            IDMOTask = RPSControlFactory.CreateRPSComboBox<ControlSheetVersionEntityView>("f24507df-1bfc-4e8e-90b9-80cc7cf91b6d","","",false, this);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<ControlSheetVersionEntityView>("9e88e9f6-6b7e-4a5c-ad61-3f963589e822","","",false, this);
 
            IDProTask = RPSControlFactory.CreateRPSComboBox<ControlSheetVersionEntityView>("dc81067d-a06e-49ca-aaad-8f5ee7938b41","","",false, this);
 
            SelectTaskTreeCommand = RPSControlFactory.CreateRPSButtonToView<ControlSheetVersionEntityView,SelectTaskTreeDialogView>("0f2a1d85-203a-43f5-8446-ecb2c3893c55","","", this,Screen.SelectTaskTreeDialogView);
 
            UIIDSite1 = RPSControlFactory.CreateRPSComboBox<ControlSheetVersionEntityView>("78b9c5d9-7681-4840-bec9-ae58ee3b1f7d","","",false, this);
 
            IDDeliveryNote = RPSControlFactory.CreateRPSComboBox<ControlSheetVersionEntityView>("81ffdccf-465b-4508-9246-7b2602345a7d","","",false, this);
 
            GroupBySerie = RPSControlFactory.CreateRPSCheckBox<ControlSheetVersionEntityView>("8a2bf7d4-4630-4d95-8daf-bfd7c451c284","","",true, this);
 
            IDDeliveryNoteLine = RPSControlFactory.CreateRPSComboBox<ControlSheetVersionEntityView>("48d395d9-db80-4248-aab9-43ba703e3e48","","",false, this);
 
            IDOrderLine = RPSControlFactory.CreateRPSComboBox<ControlSheetVersionEntityView>("725e93a6-6655-430a-b634-41a09e96184b","","",false, this);
 
            UIIDSite2 = RPSControlFactory.CreateRPSComboBox<ControlSheetVersionEntityView>("27d0b255-4eb3-4719-8382-b4f3531ad0ca","","",false, this);
 
            GroupBySerie1 = RPSControlFactory.CreateRPSCheckBox<ControlSheetVersionEntityView>("bb62f9ff-bc55-4095-893a-b24cd00d8191","","",true, this);
 
            IDDeliveryNoteSL = RPSControlFactory.CreateRPSComboBox<ControlSheetVersionEntityView>("7fffbc9e-e7e7-4117-a240-3a293270e70d","","",false, this);
 
            IDDeliveryNoteLineSL = RPSControlFactory.CreateRPSComboBox<ControlSheetVersionEntityView>("06721ba1-d3c3-47b1-8c13-1ca2f352c248","","",false, this);
 
            IDOrderSL = RPSControlFactory.CreateRPSComboBox<ControlSheetVersionEntityView>("3dc0be84-f845-448b-aef6-070fc423fd64","","",false, this);
 
            IDOrderLineSL = RPSControlFactory.CreateRPSComboBox<ControlSheetVersionEntityView>("012b5f60-5a11-41c5-8514-c75f0c82caa0","","",false, this);
 
            Series = RPSControlFactory.CreateRPSTextBox<ControlSheetVersionEntityView>("8c70dc20-fa31-492d-9ce8-5d354613c8cf","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<ControlSheetVersionEntityView>("86aa4507-d811-423b-aa40-3620f2436bed","","",true, this);
 
            IDArticleVersion = RPSControlFactory.CreateRPSComboBox<ControlSheetVersionEntityView>("fb312de6-5997-416c-862d-bd87005c742a","","",false, this);
 
            UIIDArticleVersionSample = RPSControlFactory.CreateRPSComboBox<ControlSheetVersionEntityView>("eeb17331-e13a-4075-bcfb-06e14620d26e","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<ControlSheetVersionEntityView>("c5e8dc5a-1a5e-4f65-b36b-c907a86e1318","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<ControlSheetVersionEntityView>("7bf768b4-9596-40ce-85ee-d51b62cf74b8","","",false, this);
 
            GroupBySerie2 = RPSControlFactory.CreateRPSCheckBox<ControlSheetVersionEntityView>("cdd7639a-f7ae-4f3c-bef7-0d9a05e9d4a5","","",true, this);
 
            IDControlSheetSource = RPSControlFactory.CreateRPSEnumComboBox<ControlSheetVersionEntityView>("a4928692-2e31-4056-af6f-9aaaf792aee3","","",true, this);
 
            IDControlSheetElement = RPSControlFactory.CreateRPSEnumComboBox<ControlSheetVersionEntityView>("814f67bf-7212-435f-ba19-35415e14b63d","","",true, this);
 
            GroupBySerie3 = RPSControlFactory.CreateRPSCheckBox<ControlSheetVersionEntityView>("ff469402-b0e6-4a8e-b548-2a9adc13177f","","",true, this);
 
            IDDeliveryNoteSource = RPSControlFactory.CreateRPSEnumComboBox<ControlSheetVersionEntityView>("6512409a-f346-4717-8c80-ea49a1369796","","",true, this);
 
            IDDeliveryNoteLineElement = RPSControlFactory.CreateRPSEnumComboBox<ControlSheetVersionEntityView>("437b0f44-8f68-4b7f-b241-6a18c65e4057","","",true, this);
 
            IDOrderSource = RPSControlFactory.CreateRPSEnumComboBox<ControlSheetVersionEntityView>("6164b3b4-2eb3-4ada-a5ad-2198e1960dc5","","",true, this);
 
            IDOrderLineElement = RPSControlFactory.CreateRPSEnumComboBox<ControlSheetVersionEntityView>("e2619dfe-f96c-4027-913e-d86124999dbe","","",true, this);
 
            Version = RPSControlFactory.CreateRPSTextBox<ControlSheetVersionEntityView>("fb087356-d874-4992-a760-dd67fb47b1da","","",true, this);
 
            ControlSheetNumber = RPSControlFactory.CreateRPSTextBox<ControlSheetVersionEntityView>("4760cfd1-6fda-4c84-8124-ab9f6c7e265c","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ControlSheetVersionEntityView>("3e221c96-c232-4824-9900-a0b75bb8199d","","",false, this);
 
            DoneDate = RPSControlFactory.CreateRPSTextBox<ControlSheetVersionEntityView>("d5d8aac3-ec7a-450e-9cfc-025d444cba2b","","",true, this);
 
            CodUserDoneBy = RPSControlFactory.CreateRPSComboBox<ControlSheetVersionEntityView>("98470110-1a6c-48a0-a832-0a59a8a936e2","","",true, this);
 
            EndDate = RPSControlFactory.CreateRPSTextBox<ControlSheetVersionEntityView>("6baa358d-34c4-438c-8d66-866e2419115d","","",false, this);
 
            CodUserEnd = RPSControlFactory.CreateRPSComboBox<ControlSheetVersionEntityView>("29a85520-6d94-4fb4-81f3-a3d9698e904e","","",false, this);
 
            ApprovedDate = RPSControlFactory.CreateRPSTextBox<ControlSheetVersionEntityView>("0adcfb6c-e320-4c49-94d6-f2b62917473b","","",false, this);
 
            CodUserApprovedBy = RPSControlFactory.CreateRPSComboBox<ControlSheetVersionEntityView>("6ac3e223-49ff-4652-a2c8-ac8e8780791e","","",false, this);
 
            UIPendingLabel = RPSControlFactory.CreateRPSTextBox<ControlSheetVersionEntityView>("a1a6a1b0-ce44-4974-9c5c-d4062f4a6972","","",false, this);
 
            PendingRevisionCause = RPSControlFactory.CreateRPSTextBox<ControlSheetVersionEntityView>("01fbe769-c2b7-46b0-8d37-1feb9e2d2d18","","",false, this);
 
            RejectionUser = RPSControlFactory.CreateRPSComboBox<ControlSheetVersionEntityView>("906ef92f-225b-427a-ae98-2389b7b30bb4","","",false, this);
 
            RejectionDate = RPSControlFactory.CreateRPSTextBox<ControlSheetVersionEntityView>("abb8f6e2-e878-437a-8810-9c65c481986f","","",false, this);
 
            RejectionReason = RPSControlFactory.CreateRPSTextBox<ControlSheetVersionEntityView>("01c7275f-14a2-4454-8720-ce895d42fe58","","",false, this);
 
            ExcludeForEvaluation = RPSControlFactory.CreateRPSCheckBox<ControlSheetVersionEntityView>("068053eb-85f1-44c9-98f5-297088185317","","",false, this);
 
            IDDemeritDelivery = RPSControlFactory.CreateRPSComboBox<ControlSheetVersionEntityView>("7124cfb8-f6f7-41a0-b004-417b357bb469","","",false, this);
 
            IDDemeritService = RPSControlFactory.CreateRPSComboBox<ControlSheetVersionEntityView>("3b7ddaf7-9cb4-4251-8a85-45d1939b463b","","",false, this);
 
            InspectAll = RPSControlFactory.CreateRPSButton<ControlSheetVersionEntityView>( "eed0f8f0-fb68-4b3d-88bc-72a82d215148","","",this);
 
            IDEmployeeToInspectAll = RPSControlFactory.CreateRPSComboBox<ControlSheetVersionEntityView>("e37cc5a5-3917-4fa5-920b-3edfbf62f244","","",false, this);
 
            Notes = RPSControlFactory.CreateRPSTextBox<ControlSheetVersionEntityView>("bbf062e9-40d9-40fe-b686-7e8c27f620da","","",false, this);
 
            PrintReportOptionsCommandButton = RPSControlFactory.CreateRPSButtonToView<ControlSheetVersionEntityView,PrintReportOptionsDialogView>("f4488020-7df9-4502-bb0f-f9e43cd755ab","","", this,Screen.PrintReportOptionsDialogView);
 
            FinalizeCommandButton = RPSControlFactory.CreateRPSButton<ControlSheetVersionEntityView>( "0d669705-282c-4e42-b04a-43d106323d7a","","",this);
 
            ApprovalCommandButton = RPSControlFactory.CreateRPSButton<ControlSheetVersionEntityView>( "0b0c9221-9175-4718-8399-95fb12fd4074","","",this);
 
            RejectCommandButton = RPSControlFactory.CreateRPSButtonToView<ControlSheetVersionEntityView,RejectControlSheetVersionDialogView>("0708af04-79c6-4b7a-bbd2-8d61df7498f6","","", this,Screen.RejectControlSheetVersionDialogView);
 
            ReceiptCommandButton = RPSControlFactory.CreateRPSButton<ControlSheetVersionEntityView>( "ff5a375f-574a-4911-8575-0e570b927b0b","","",this);
 
            ReviseCommandButton = RPSControlFactory.CreateRPSButton<ControlSheetVersionEntityView>( "b53b35c9-a7cb-40a2-890a-067979007519","","",this);
 
            ShowRejectionsCommandButton = RPSControlFactory.CreateRPSButtonToView<ControlSheetVersionEntityView,RejectionHistoryDialogView>("5f061826-8428-4e9d-9ed4-4c20d5fec595","","", this,Screen.RejectionHistoryDialogView);
 
            CopyFromOtherProductionSheetCommandButton = RPSControlFactory.CreateRPSButtonToView<ControlSheetVersionEntityView,CopyFromOtherSheetDialogView>("694800f0-e183-4644-9327-a613131d6ff6","","", this,Screen.CopyFromOtherSheetDialogView);
 
            CopyFromOtherReceptionSheetCommandButton = RPSControlFactory.CreateRPSButtonToView<ControlSheetVersionEntityView,CopyFromOtherReceptionSheetDialogView>("dc308d79-b59c-41ae-b2cb-f6470c7dfea9","","", this,Screen.CopyFromOtherReceptionSheetDialogView);
 
            CopyFromOtherFinalSheetCommandButton = RPSControlFactory.CreateRPSButtonToView<ControlSheetVersionEntityView,CopyFromOtherFinalSheetDialogView>("9318bf53-c72f-4e3d-b03d-5425ea32f8c0","","", this,Screen.CopyFromOtherFinalSheetDialogView);
 
            CreateNewNonConformityCommandButton = RPSControlFactory.CreateRPSButtonToView<ControlSheetVersionEntityView,CreateNewNonConformityDialogView>("7d4718af-8d64-4ba7-bb9a-e3ca4d425d02","","", this,Screen.CreateNewNonConformityDialogView);
 
            ControlSheetFinalImportCharacsCommandButton = RPSControlFactory.CreateRPSButtonToView<ControlSheetVersionEntityView,ControlSheetFinalImportCharacsView>("a7163591-dd86-4de7-aa9d-c1e2a1b2fc0f","","", this,Screen.ControlSheetFinalImportCharacsView);
 
            CollectionInit params_ControlSheetCharacs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="e59df35f-337b-4347-bd88-4b4a2bc142e1",CSSSelectorGrid="",XPathGrid=""};
            ControlSheetCharacs = RPSControlFactory.RPSCreateCollectionWithGrid<ControlSheetCharacsCollectionEditor<ControlSheetVersionEntityView,ControlSheetCharacView>,ControlSheetVersionEntityView,ControlSheetCharacView>( params_ControlSheetCharacs,this,Screen.ControlSheetCharacView);
 
            CollectionInit params_GetCriticalPointsForControlPatternsVersion = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="e9039de3-8257-4a8b-8971-4fde8820f637",CSSSelectorGrid="",XPathGrid=""};
            GetCriticalPointsForControlPatternsVersion = RPSControlFactory.RPSCreateCollectionWithGrid<GetCriticalPointsForControlPatternsVersionCollectionEditor<ControlSheetVersionEntityView,ControlSheetCharacView>,ControlSheetVersionEntityView,ControlSheetCharacView>( params_GetCriticalPointsForControlPatternsVersion,this,Screen.ControlSheetCharacView);
 
            CollectionInit params_MaterialsWithControlSheetsVersion = new CollectionInit(){IDDescriptor = "d870048d-ed3c-4a21-8662-0359563a8473",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8ac46590-4b7b-4e16-a9cf-a76469026425",CSSSelectorGrid="",XPathGrid=""};
            MaterialsWithControlSheetsVersion = RPSControlFactory.RPSCreateCollectionWithGrid<MaterialsWithControlSheetsVersionCollectionEditor<ControlSheetVersionEntityView,ControlSheetCharacView>,ControlSheetVersionEntityView,ControlSheetCharacView>( params_MaterialsWithControlSheetsVersion,this,Screen.ControlSheetCharacView);
 
            CollectionInit params_ControlSheetInspections = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="9fd17b82-2c5d-45e9-85d0-1ab948800f34",CSSSelectorGrid="",XPathGrid=""};
            ControlSheetInspections = RPSControlFactory.RPSCreateCollectionWithGrid<ControlSheetInspectionsCollectionEditor<ControlSheetVersionEntityView,ControlSheetCharacView>,ControlSheetVersionEntityView,ControlSheetCharacView>( params_ControlSheetInspections,this,Screen.ControlSheetCharacView);
 
            CollectionInit params_ControlSheetResidues = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="fe53bf8a-95e4-4100-b5de-8e3fd29fd172",CSSSelectorGrid="",XPathGrid=""};
            ControlSheetResidues = RPSControlFactory.RPSCreateCollectionWithGrid<ControlSheetResiduesCollectionEditor<ControlSheetVersionEntityView,ControlSheetCharacView>,ControlSheetVersionEntityView,ControlSheetCharacView>( params_ControlSheetResidues,this,Screen.ControlSheetCharacView);
 
            CollectionInit params_ControlSheetVersionByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="44fe7ff9-356a-4332-8ba4-fc4b4b46a073",CSSSelectorGrid="",XPathGrid=""};
            ControlSheetVersionByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<ControlSheetVersionByLangsCollectionEditor<ControlSheetVersionEntityView,ControlSheetCharacView>,ControlSheetVersionEntityView,ControlSheetCharacView>( params_ControlSheetVersionByLangs,this,Screen.ControlSheetCharacView);
 
            CharacteristicToControl = RPSControlFactory.CreateRPSSection<ControlSheetVersionEntityView>( "","ul li[rpsid='a442ef5a-3042-4ecb-baa9-be84a705131d']","",this);
 
            Dangers = RPSControlFactory.CreateRPSSection<ControlSheetVersionEntityView>( "","ul li[rpsid='56df5f0a-fd86-4cfb-8e1b-aab86317003d']","",this);
 
            MaterialsWithSheet = RPSControlFactory.CreateRPSSection<ControlSheetVersionEntityView>( "","ul li[rpsid='fb96b13e-9bb3-46b6-a30a-498696ee13a8']","",this);
 
            Structure = RPSControlFactory.CreateRPSSection<ControlSheetVersionEntityView>( "","ul li[rpsid='f811c81c-24a8-4a9e-acee-76bf74a09494']","",this);
 
            InspectionResults = RPSControlFactory.CreateRPSSection<ControlSheetVersionEntityView>( "","ul li[rpsid='b08dbcf3-1e84-4546-8046-620533c4d8aa']","",this);
 
            ResiduesControl = RPSControlFactory.CreateRPSSection<ControlSheetVersionEntityView>( "","ul li[rpsid='3b348ec2-9c4e-436c-b95d-8ccb8fa3f0e3']","",this);
 
            ControlSheetVersionByLangs1 = RPSControlFactory.CreateRPSSection<ControlSheetVersionEntityView>( "","ul li[rpsid='262dadde-4eeb-4553-b47f-b847dcb0d1d4']","",this);
 
            Notes1 = RPSControlFactory.CreateRPSSection<ControlSheetVersionEntityView>( "","ul li[rpsid='15c88839-3960-40f7-b2be-37884c1ae6f1']","",this);
 

        }
        public IRPSSaveButton<ControlSheetVersionEntityView> SaveButton { get; set; } 
        public IRPSButton<ControlSheetVersionEntityView> DeleteButton { get; set; } 
        public IRPSButton<ControlSheetVersionEntityView,ControlSheetVersionCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ControlSheetVersionEntityView,ControlSheetVersionCollectionView> BackButton { get; set; } 
        public IRPSComboBox<ControlSheetVersionEntityView> UIIDSite { get; set; } 
        public IRPSOption<ControlSheetVersionEntityView> ManufacturingOrder { get; set; } 
        public IRPSOption<ControlSheetVersionEntityView> Project { get; set; } 
        public IRPSComboBox<ControlSheetVersionEntityView> IDManufacturingOrder { get; set; } 
        public IRPSComboBox<ControlSheetVersionEntityView> IDMOTask { get; set; } 
        public IRPSComboBox<ControlSheetVersionEntityView> IDProject { get; set; } 
        public IRPSComboBox<ControlSheetVersionEntityView> IDProTask { get; set; } 
        public IRPSButton<ControlSheetVersionEntityView,SelectTaskTreeDialogView> SelectTaskTreeCommand { get; set; } 
        public IRPSComboBox<ControlSheetVersionEntityView> UIIDSite1 { get; set; } 
        public IRPSComboBox<ControlSheetVersionEntityView> IDDeliveryNote { get; set; } 
        public IRPSCheckbox<ControlSheetVersionEntityView> GroupBySerie { get; set; } 
        public IRPSComboBox<ControlSheetVersionEntityView> IDDeliveryNoteLine { get; set; } 
        public IRPSComboBox<ControlSheetVersionEntityView> IDOrderLine { get; set; } 
        public IRPSComboBox<ControlSheetVersionEntityView> UIIDSite2 { get; set; } 
        public IRPSCheckbox<ControlSheetVersionEntityView> GroupBySerie1 { get; set; } 
        public IRPSComboBox<ControlSheetVersionEntityView> IDDeliveryNoteSL { get; set; } 
        public IRPSComboBox<ControlSheetVersionEntityView> IDDeliveryNoteLineSL { get; set; } 
        public IRPSComboBox<ControlSheetVersionEntityView> IDOrderSL { get; set; } 
        public IRPSComboBox<ControlSheetVersionEntityView> IDOrderLineSL { get; set; } 
        public IRPSTextBox<ControlSheetVersionEntityView> Series { get; set; } 
        public IRPSComboBox<ControlSheetVersionEntityView> IDArticle { get; set; } 
        public IRPSComboBox<ControlSheetVersionEntityView> IDArticleVersion { get; set; } 
        public IRPSComboBox<ControlSheetVersionEntityView> UIIDArticleVersionSample { get; set; } 
        public IRPSComboBox<ControlSheetVersionEntityView> IDCustomer { get; set; } 
        public IRPSComboBox<ControlSheetVersionEntityView> IDSupplier { get; set; } 
        public IRPSCheckbox<ControlSheetVersionEntityView> GroupBySerie2 { get; set; } 
        public IRPSComboBox<ControlSheetVersionEntityView> IDControlSheetSource { get; set; } 
        public IRPSComboBox<ControlSheetVersionEntityView> IDControlSheetElement { get; set; } 
        public IRPSCheckbox<ControlSheetVersionEntityView> GroupBySerie3 { get; set; } 
        public IRPSComboBox<ControlSheetVersionEntityView> IDDeliveryNoteSource { get; set; } 
        public IRPSComboBox<ControlSheetVersionEntityView> IDDeliveryNoteLineElement { get; set; } 
        public IRPSComboBox<ControlSheetVersionEntityView> IDOrderSource { get; set; } 
        public IRPSComboBox<ControlSheetVersionEntityView> IDOrderLineElement { get; set; } 
        public IRPSTextBox<ControlSheetVersionEntityView> Version { get; set; } 
        public IRPSTextBox<ControlSheetVersionEntityView> ControlSheetNumber { get; set; } 
        public IRPSTextBox<ControlSheetVersionEntityView> Description { get; set; } 
        public IRPSTextBox<ControlSheetVersionEntityView> DoneDate { get; set; } 
        public IRPSComboBox<ControlSheetVersionEntityView> CodUserDoneBy { get; set; } 
        public IRPSTextBox<ControlSheetVersionEntityView> EndDate { get; set; } 
        public IRPSComboBox<ControlSheetVersionEntityView> CodUserEnd { get; set; } 
        public IRPSTextBox<ControlSheetVersionEntityView> ApprovedDate { get; set; } 
        public IRPSComboBox<ControlSheetVersionEntityView> CodUserApprovedBy { get; set; } 
        public IRPSTextBox<ControlSheetVersionEntityView> UIPendingLabel { get; set; } 
        public IRPSTextBox<ControlSheetVersionEntityView> PendingRevisionCause { get; set; } 
        public IRPSComboBox<ControlSheetVersionEntityView> RejectionUser { get; set; } 
        public IRPSTextBox<ControlSheetVersionEntityView> RejectionDate { get; set; } 
        public IRPSTextBox<ControlSheetVersionEntityView> RejectionReason { get; set; } 
        public IRPSCheckbox<ControlSheetVersionEntityView> ExcludeForEvaluation { get; set; } 
        public IRPSComboBox<ControlSheetVersionEntityView> IDDemeritDelivery { get; set; } 
        public IRPSComboBox<ControlSheetVersionEntityView> IDDemeritService { get; set; } 
        public IRPSButton<ControlSheetVersionEntityView> InspectAll { get; set; } 
        public IRPSComboBox<ControlSheetVersionEntityView> IDEmployeeToInspectAll { get; set; } 
        public IRPSTextBox<ControlSheetVersionEntityView> Notes { get; set; } 
        public IRPSButton<ControlSheetVersionEntityView,PrintReportOptionsDialogView> PrintReportOptionsCommandButton { get; set; } 
        public IRPSButton<ControlSheetVersionEntityView> FinalizeCommandButton { get; set; } 
        public IRPSButton<ControlSheetVersionEntityView> ApprovalCommandButton { get; set; } 
        public IRPSButton<ControlSheetVersionEntityView,RejectControlSheetVersionDialogView> RejectCommandButton { get; set; } 
        public IRPSButton<ControlSheetVersionEntityView> ReceiptCommandButton { get; set; } 
        public IRPSButton<ControlSheetVersionEntityView> ReviseCommandButton { get; set; } 
        public IRPSButton<ControlSheetVersionEntityView,RejectionHistoryDialogView> ShowRejectionsCommandButton { get; set; } 
        public IRPSButton<ControlSheetVersionEntityView,CopyFromOtherSheetDialogView> CopyFromOtherProductionSheetCommandButton { get; set; } 
        public IRPSButton<ControlSheetVersionEntityView,CopyFromOtherReceptionSheetDialogView> CopyFromOtherReceptionSheetCommandButton { get; set; } 
        public IRPSButton<ControlSheetVersionEntityView,CopyFromOtherFinalSheetDialogView> CopyFromOtherFinalSheetCommandButton { get; set; } 
        public IRPSButton<ControlSheetVersionEntityView,CreateNewNonConformityDialogView> CreateNewNonConformityCommandButton { get; set; } 
        public IRPSButton<ControlSheetVersionEntityView,ControlSheetFinalImportCharacsView> ControlSheetFinalImportCharacsCommandButton { get; set; } 
        public ControlSheetCharacsCollectionEditor<ControlSheetVersionEntityView,ControlSheetCharacView> ControlSheetCharacs { get; set; } 
        public GetCriticalPointsForControlPatternsVersionCollectionEditor<ControlSheetVersionEntityView,ControlSheetCharacView> GetCriticalPointsForControlPatternsVersion { get; set; } 
        public MaterialsWithControlSheetsVersionCollectionEditor<ControlSheetVersionEntityView,ControlSheetCharacView> MaterialsWithControlSheetsVersion { get; set; } 
        public ControlSheetInspectionsCollectionEditor<ControlSheetVersionEntityView,ControlSheetCharacView> ControlSheetInspections { get; set; } 
        public ControlSheetResiduesCollectionEditor<ControlSheetVersionEntityView,ControlSheetCharacView> ControlSheetResidues { get; set; } 
        public ControlSheetVersionByLangsCollectionEditor<ControlSheetVersionEntityView,ControlSheetCharacView> ControlSheetVersionByLangs { get; set; } 
        public IRPSSection<ControlSheetVersionEntityView> CharacteristicToControl { get; set; } 
        public IRPSSection<ControlSheetVersionEntityView> Dangers { get; set; } 
        public IRPSSection<ControlSheetVersionEntityView> MaterialsWithSheet { get; set; } 
        public IRPSSection<ControlSheetVersionEntityView> Structure { get; set; } 
        public IRPSSection<ControlSheetVersionEntityView> InspectionResults { get; set; } 
        public IRPSSection<ControlSheetVersionEntityView> ResiduesControl { get; set; } 
        public IRPSSection<ControlSheetVersionEntityView> ControlSheetVersionByLangs1 { get; set; } 
        public IRPSSection<ControlSheetVersionEntityView> Notes1 { get; set; } 
        public ControlSheetVersion Screen { get; set; }
        public ControlSheetVersionEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ControlSheetCharacsCollectionEditor<ControlSheetVersionEntityView,ControlSheetCharacView>:RPSCollectionEditor<ControlSheetVersionEntityView,ControlSheetCharacView> where ControlSheetVersionEntityView : class, IView where ControlSheetCharacView : class, IView
    {
        public  ControlSheetCharacsGridView<ControlSheetVersionEntityView,ControlSheetCharacView> GridView {get;set;}
    }
    public partial class ControlSheetCharacsGridView <ControlSheetVersionEntityView,ControlSheetCharacView> :  RPSGridView<ControlSheetVersionEntityView,ControlSheetCharacView> where ControlSheetVersionEntityView : class, IView where ControlSheetCharacView : class, IView
    {
        public ControlSheetCharacsGridView(ControlSheetVersionEntityView currentView,ControlSheetCharacView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NumCharacteristic = RPSControlFactory.CreateRPSGridFormattedTextBox<ControlSheetVersionEntityView>("","#e59df35f-337b-4347-bd88-4b4a2bc142e1 .ag-row[role='row']@ROWINDEX [col-id='cNumCharacteristic']","",true, this.CurrentView);
 
            IDCharacteristic = RPSControlFactory.CreateRPSGridComboBox<ControlSheetVersionEntityView>("","#e59df35f-337b-4347-bd88-4b4a2bc142e1 .ag-row[role='row']@ROWINDEX [col-id='cIDCharacteristic']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ControlSheetVersionEntityView>("","#e59df35f-337b-4347-bd88-4b4a2bc142e1 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            IDCharacteristicType = RPSControlFactory.CreateRPSGridComboBox<ControlSheetVersionEntityView>("","#e59df35f-337b-4347-bd88-4b4a2bc142e1 .ag-row[role='row']@ROWINDEX [col-id='cIDCharacteristicType']","",false, this.CurrentView);
 
            ControlType = RPSControlFactory.CreateRPSGridEnumComboBox<ControlSheetVersionEntityView>("","#e59df35f-337b-4347-bd88-4b4a2bc142e1 .ag-row[role='row']@ROWINDEX [col-id='cControlType']","",false, this.CurrentView);
 
            ResultNumber = RPSControlFactory.CreateRPSGridFormattedTextBox<ControlSheetVersionEntityView>("","#e59df35f-337b-4347-bd88-4b4a2bc142e1 .ag-row[role='row']@ROWINDEX [col-id='cResultNumber']","",true, this.CurrentView);
 
            ValuesOutOfTolerance = RPSControlFactory.CreateRPSGridFormattedTextBox<ControlSheetVersionEntityView>("","#e59df35f-337b-4347-bd88-4b4a2bc142e1 .ag-row[role='row']@ROWINDEX [col-id='cValuesOutOfTolerance']","",false, this.CurrentView);
 
            ViewCertificate = RPSControlFactory.CreateRPSGridCheckBox<ControlSheetVersionEntityView>("","#e59df35f-337b-4347-bd88-4b4a2bc142e1 .ag-row[role='row']@ROWINDEX [col-id='cViewCertificate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ControlSheetVersionEntityView> NumCharacteristic { get; set; } 
        public IRPSGridComboBox<ControlSheetVersionEntityView> IDCharacteristic { get; set; } 
        public IRPSGridTextBox<ControlSheetVersionEntityView> Description { get; set; } 
        public IRPSGridComboBox<ControlSheetVersionEntityView> IDCharacteristicType { get; set; } 
        public IRPSGridComboBox<ControlSheetVersionEntityView> ControlType { get; set; } 
        public IRPSGridTextBox<ControlSheetVersionEntityView> ResultNumber { get; set; } 
        public IRPSGridTextBox<ControlSheetVersionEntityView> ValuesOutOfTolerance { get; set; } 
        public IRPSGridCheckbox<ControlSheetVersionEntityView> ViewCertificate { get; set; } 
                     
    }
 
        public partial class GetCriticalPointsForControlPatternsVersionCollectionEditor<ControlSheetVersionEntityView,ControlSheetCharacView>:RPSCollectionEditor<ControlSheetVersionEntityView,ControlSheetCharacView> where ControlSheetVersionEntityView : class, IView where ControlSheetCharacView : class, IView
    {
        public  GetCriticalPointsForControlPatternsVersionGridView<ControlSheetVersionEntityView,ControlSheetCharacView> GridView {get;set;}
    }
    public partial class GetCriticalPointsForControlPatternsVersionGridView <ControlSheetVersionEntityView,ControlSheetCharacView> :  RPSGridView<ControlSheetVersionEntityView,ControlSheetCharacView> where ControlSheetVersionEntityView : class, IView where ControlSheetCharacView : class, IView
    {
        public GetCriticalPointsForControlPatternsVersionGridView(ControlSheetVersionEntityView currentView,ControlSheetCharacView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Class = RPSControlFactory.CreateRPSGridTextBox<ControlSheetVersionEntityView>("","#e9039de3-8257-4a8b-8971-4fde8820f637 .ag-row[role='row']@ROWINDEX [col-id='cClass']","",false, this.CurrentView);
 
            Requirement = RPSControlFactory.CreateRPSGridTextBox<ControlSheetVersionEntityView>("","#e9039de3-8257-4a8b-8971-4fde8820f637 .ag-row[role='row']@ROWINDEX [col-id='cRequirement']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ControlSheetVersionEntityView> Class { get; set; } 
        public IRPSGridTextBox<ControlSheetVersionEntityView> Requirement { get; set; } 
                     
    }
 
        public partial class MaterialsWithControlSheetsVersionCollectionEditor<ControlSheetVersionEntityView,ControlSheetCharacView>:RPSCollectionEditor<ControlSheetVersionEntityView,ControlSheetCharacView> where ControlSheetVersionEntityView : class, IView where ControlSheetCharacView : class, IView
    {
        public  MaterialsWithControlSheetsVersionGridView<ControlSheetVersionEntityView,ControlSheetCharacView> GridView {get;set;}
    }
    public partial class MaterialsWithControlSheetsVersionGridView <ControlSheetVersionEntityView,ControlSheetCharacView> :  RPSGridView<ControlSheetVersionEntityView,ControlSheetCharacView> where ControlSheetVersionEntityView : class, IView where ControlSheetCharacView : class, IView
    {
        public MaterialsWithControlSheetsVersionGridView(ControlSheetVersionEntityView currentView,ControlSheetCharacView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            eVersionType = RPSControlFactory.CreateRPSGridEnumComboBox<ControlSheetVersionEntityView>("","#8ac46590-4b7b-4e16-a9cf-a76469026425 .ag-row[role='row']@ROWINDEX [col-id='ceVersionType']","",false, this.CurrentView);
 
            UIState = RPSControlFactory.CreateRPSGridTextBox<ControlSheetVersionEntityView>("","#8ac46590-4b7b-4e16-a9cf-a76469026425 .ag-row[role='row']@ROWINDEX [col-id='cUIState']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ControlSheetVersionEntityView> eVersionType { get; set; } 
        public IRPSGridTextBox<ControlSheetVersionEntityView> UIState { get; set; } 
                     
    }
 
        public partial class ControlSheetInspectionsCollectionEditor<ControlSheetVersionEntityView,ControlSheetCharacView>:RPSCollectionEditor<ControlSheetVersionEntityView,ControlSheetCharacView> where ControlSheetVersionEntityView : class, IView where ControlSheetCharacView : class, IView
    {
        public  ControlSheetInspectionsGridView<ControlSheetVersionEntityView,ControlSheetCharacView> GridView {get;set;}
    }
    public partial class ControlSheetInspectionsGridView <ControlSheetVersionEntityView,ControlSheetCharacView> :  RPSGridView<ControlSheetVersionEntityView,ControlSheetCharacView> where ControlSheetVersionEntityView : class, IView where ControlSheetCharacView : class, IView
    {
        public ControlSheetInspectionsGridView(ControlSheetVersionEntityView currentView,ControlSheetCharacView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NumInspection = RPSControlFactory.CreateRPSGridFormattedTextBox<ControlSheetVersionEntityView>("","#9fd17b82-2c5d-45e9-85d0-1ab948800f34 .ag-row[role='row']@ROWINDEX [col-id='cNumInspection']","",true, this.CurrentView);
 
            IDDeliveryNoteLine = RPSControlFactory.CreateRPSGridComboBox<ControlSheetVersionEntityView>("","#9fd17b82-2c5d-45e9-85d0-1ab948800f34 .ag-row[role='row']@ROWINDEX [col-id='cIDDeliveryNoteLine']","",false, this.CurrentView);
 
            IDControlSheetQuantityElement = RPSControlFactory.CreateRPSGridTextBox<ControlSheetVersionEntityView>("","#9fd17b82-2c5d-45e9-85d0-1ab948800f34 .ag-row[role='row']@ROWINDEX [col-id='cIDControlSheetQuantityElement']","",true, this.CurrentView);
 
            Serie = RPSControlFactory.CreateRPSGridEnumComboBox<ControlSheetVersionEntityView>("","#9fd17b82-2c5d-45e9-85d0-1ab948800f34 .ag-row[role='row']@ROWINDEX [col-id='cSerie']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<ControlSheetVersionEntityView>("","#9fd17b82-2c5d-45e9-85d0-1ab948800f34 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            QuantityRejected = RPSControlFactory.CreateRPSGridFormattedTextBox<ControlSheetVersionEntityView>("","#9fd17b82-2c5d-45e9-85d0-1ab948800f34 .ag-row[role='row']@ROWINDEX [col-id='cQuantityRejected']","",false, this.CurrentView);
 
            QuantitySecondUnitRejected = RPSControlFactory.CreateRPSGridFormattedTextBox<ControlSheetVersionEntityView>("","#9fd17b82-2c5d-45e9-85d0-1ab948800f34 .ag-row[role='row']@ROWINDEX [col-id='cQuantitySecondUnitRejected']","",false, this.CurrentView);
 
            FinalizeReceptionInspectionNavigationCommand = RPSControlFactory.CreateRPSGridButtonToView<ControlSheetVersionEntityView,FinalizeReceptionInspectionDialogView>("","#9fd17b82-2c5d-45e9-85d0-1ab948800f34 .ag-row[role='row']@ROWINDEX [col-id='cFinalizeReceptionInspectionNavigationCommand']","", this.CurrentView,this.CurrentView.Screen.GetViewInstance<FinalizeReceptionInspectionDialogView>());
 
            Inspected = RPSControlFactory.CreateRPSGridCheckBox<ControlSheetVersionEntityView>("","#9fd17b82-2c5d-45e9-85d0-1ab948800f34 .ag-row[role='row']@ROWINDEX [col-id='cInspected']","",false, this.CurrentView);
 
            InspectedBy = RPSControlFactory.CreateRPSGridComboBox<ControlSheetVersionEntityView>("","#9fd17b82-2c5d-45e9-85d0-1ab948800f34 .ag-row[role='row']@ROWINDEX [col-id='cInspectedBy']","",false, this.CurrentView);
 
            InspectedDate = RPSControlFactory.CreateRPSGridTextBox<ControlSheetVersionEntityView>("","#9fd17b82-2c5d-45e9-85d0-1ab948800f34 .ag-row[role='row']@ROWINDEX [col-id='cInspectedDate']","",false, this.CurrentView);
 
            IDLocationWarehouse = RPSControlFactory.CreateRPSGridComboBox<ControlSheetVersionEntityView>("","#9fd17b82-2c5d-45e9-85d0-1ab948800f34 .ag-row[role='row']@ROWINDEX [col-id='cIDLocationWarehouse']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ControlSheetVersionEntityView> NumInspection { get; set; } 
        public IRPSGridComboBox<ControlSheetVersionEntityView> IDDeliveryNoteLine { get; set; } 
        public IRPSGridTextBox<ControlSheetVersionEntityView> IDControlSheetQuantityElement { get; set; } 
        public IRPSGridComboBox<ControlSheetVersionEntityView> Serie { get; set; } 
        public IRPSGridTextBox<ControlSheetVersionEntityView> Quantity { get; set; } 
        public IRPSGridTextBox<ControlSheetVersionEntityView> QuantityRejected { get; set; } 
        public IRPSGridTextBox<ControlSheetVersionEntityView> QuantitySecondUnitRejected { get; set; } 
        public IRPSGridButton<ControlSheetVersionEntityView,FinalizeReceptionInspectionDialogView> FinalizeReceptionInspectionNavigationCommand { get; set; } 
        public IRPSGridCheckbox<ControlSheetVersionEntityView> Inspected { get; set; } 
        public IRPSGridComboBox<ControlSheetVersionEntityView> InspectedBy { get; set; } 
        public IRPSGridTextBox<ControlSheetVersionEntityView> InspectedDate { get; set; } 
        public IRPSGridComboBox<ControlSheetVersionEntityView> IDLocationWarehouse { get; set; } 
                     
    }
 
        public partial class ControlSheetResiduesCollectionEditor<ControlSheetVersionEntityView,ControlSheetCharacView>:RPSCollectionEditor<ControlSheetVersionEntityView,ControlSheetCharacView> where ControlSheetVersionEntityView : class, IView where ControlSheetCharacView : class, IView
    {
        public  ControlSheetResiduesGridView<ControlSheetVersionEntityView,ControlSheetCharacView> GridView {get;set;}
    }
    public partial class ControlSheetResiduesGridView <ControlSheetVersionEntityView,ControlSheetCharacView> :  RPSGridView<ControlSheetVersionEntityView,ControlSheetCharacView> where ControlSheetVersionEntityView : class, IView where ControlSheetCharacView : class, IView
    {
        public ControlSheetResiduesGridView(ControlSheetVersionEntityView currentView,ControlSheetCharacView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<ControlSheetVersionEntityView>("","#fe53bf8a-95e4-4100-b5de-8e3fd29fd172 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            Observation = RPSControlFactory.CreateRPSGridMemoTextBox<ControlSheetVersionEntityView>("","#fe53bf8a-95e4-4100-b5de-8e3fd29fd172 .ag-row[role='row']@ROWINDEX [col-id='cObservation']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ControlSheetVersionEntityView> IDArticle { get; set; } 
        public IRPSGridTextBox<ControlSheetVersionEntityView> Observation { get; set; } 
                     
    }
 
        public partial class ControlSheetVersionByLangsCollectionEditor<ControlSheetVersionEntityView,ControlSheetCharacView>:RPSCollectionEditor<ControlSheetVersionEntityView,ControlSheetCharacView> where ControlSheetVersionEntityView : class, IView where ControlSheetCharacView : class, IView
    {
        public  ControlSheetVersionByLangsGridView<ControlSheetVersionEntityView,ControlSheetCharacView> GridView {get;set;}
    }
    public partial class ControlSheetVersionByLangsGridView <ControlSheetVersionEntityView,ControlSheetCharacView> :  RPSGridView<ControlSheetVersionEntityView,ControlSheetCharacView> where ControlSheetVersionEntityView : class, IView where ControlSheetCharacView : class, IView
    {
        public ControlSheetVersionByLangsGridView(ControlSheetVersionEntityView currentView,ControlSheetCharacView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<ControlSheetVersionEntityView>("","#44fe7ff9-356a-4332-8ba4-fc4b4b46a073 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ControlSheetVersionEntityView>("","#44fe7ff9-356a-4332-8ba4-fc4b4b46a073 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Notes = RPSControlFactory.CreateRPSGridMemoTextBox<ControlSheetVersionEntityView>("","#44fe7ff9-356a-4332-8ba4-fc4b4b46a073 .ag-row[role='row']@ROWINDEX [col-id='cNotes']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ControlSheetVersionEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<ControlSheetVersionEntityView> Description { get; set; } 
        public IRPSGridTextBox<ControlSheetVersionEntityView> Notes { get; set; } 
                     
    }
 
    }
  
            
    public partial class ControlSheetCharacView : View
    {
        public ControlSheetCharacView(ControlSheetVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ControlSheetCharacView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ControlSheetCharacView,ControlSheetVersionEntityView>( this,Screen.ControlSheetVersionEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ControlSheetCharacView,ControlSheetVersionEntityView>( this,Screen.ControlSheetVersionEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ControlSheetCharacView,ControlSheetVersionEntityView>( this,Screen.ControlSheetVersionEntityView);
 
            NumCharacteristic = RPSControlFactory.CreateRPSFormattedTextBox<ControlSheetCharacView>("76ec083d-a2b3-4e63-9959-2a2d5fe8ba5b","","",true, this);
 
            IDCharacteristic = RPSControlFactory.CreateRPSComboBox<ControlSheetCharacView>("be65b691-b690-407c-b3be-6b26b06027b4","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ControlSheetCharacView>("feb702c0-8dd5-4c40-a7b3-a81f215f3c5c","","",false, this);
 
            IDCharacteristicType = RPSControlFactory.CreateRPSComboBox<ControlSheetCharacView>("4d64a3d6-574c-4e90-9d19-ca29996f4b57","","",false, this);
 
            IDCharacteristicClass = RPSControlFactory.CreateRPSComboBox<ControlSheetCharacView>("ab0594ec-4940-4270-8d23-45e8a1a0c5e8","","",false, this);
 
            ViewCertificate = RPSControlFactory.CreateRPSCheckBox<ControlSheetCharacView>("77b1cb67-8602-4883-ad3b-8593b33a8860","","",false, this);
 
            ControlType = RPSControlFactory.CreateRPSEnumComboBox<ControlSheetCharacView>("c51ce510-609c-46a1-938f-32a707b4e2e8","","",false, this);
 
            Nominal = RPSControlFactory.CreateRPSFormattedTextBox<ControlSheetCharacView>("2cdc4837-3c8b-414a-9867-77233622b507","","",false, this);
 
            Min = RPSControlFactory.CreateRPSFormattedTextBox<ControlSheetCharacView>("d7e311a6-c7c4-451d-ae40-188b64293dda","","",false, this);
 
            Max = RPSControlFactory.CreateRPSFormattedTextBox<ControlSheetCharacView>("e79bf6a1-ddfd-4bfa-8484-8dec5aef76a9","","",false, this);
 
            ResultMin = RPSControlFactory.CreateRPSFormattedTextBox<ControlSheetCharacView>("83adb9fa-0520-4c32-927c-1513b37d74fe","","",true, this);
 
            ResultMax = RPSControlFactory.CreateRPSFormattedTextBox<ControlSheetCharacView>("828bda32-f6ac-4cfd-a0c0-29ca7ea7e212","","",true, this);
 
            ResultAverage = RPSControlFactory.CreateRPSFormattedTextBox<ControlSheetCharacView>("ad16aa6f-ba33-43c1-9eb7-fd88267decbf","","",true, this);
 
            ResultOK = RPSControlFactory.CreateRPSCheckBox<ControlSheetCharacView>("af57a619-f9bb-48ff-a7cc-cc651bba930b","","",true, this);
 
            ResultNOK = RPSControlFactory.CreateRPSCheckBox<ControlSheetCharacView>("f7f4c0f8-e8dd-4e79-b575-ab1a1b930e73","","",true, this);
 
            ResultNumber = RPSControlFactory.CreateRPSFormattedTextBox<ControlSheetCharacView>("93e1ba60-4ab1-44aa-973b-ddb326276e30","","",true, this);
 
            ValuesOutOfTolerance = RPSControlFactory.CreateRPSFormattedTextBox<ControlSheetCharacView>("b51a82c6-55a2-41cb-aa85-a17bd824d1dd","","",false, this);
 
            IDToleranceSpecification = RPSControlFactory.CreateRPSComboBox<ControlSheetCharacView>("1ae4c433-05d5-4623-9e98-042f716e4632","","",false, this);
 
            ToleranceSpecification = RPSControlFactory.CreateRPSTextBox<ControlSheetCharacView>("599cea51-9e3a-46b6-b56a-aa5ea770f4ff","","",false, this);
 
            IDMeasureTechnique = RPSControlFactory.CreateRPSComboBox<ControlSheetCharacView>("d0b5c5cc-e254-4c59-a1df-b06526fdb593","","",false, this);
 
            MeasureTechnique = RPSControlFactory.CreateRPSTextBox<ControlSheetCharacView>("6ecab214-5c34-4173-93b6-c6c3b572f398","","",false, this);
 
            IDSampleSize = RPSControlFactory.CreateRPSComboBox<ControlSheetCharacView>("0876b139-6948-4a93-93d5-8f9e3b0e6375","","",false, this);
 
            SampleSize = RPSControlFactory.CreateRPSTextBox<ControlSheetCharacView>("09d4aac9-a814-4c62-9bd1-217da7dfaf54","","",false, this);
 
            IDSampleFrequency = RPSControlFactory.CreateRPSComboBox<ControlSheetCharacView>("f6d6746e-b944-4ff7-9fc4-a6c319cbac70","","",false, this);
 
            SampleFrecuency = RPSControlFactory.CreateRPSTextBox<ControlSheetCharacView>("046d2d74-d5d8-4c37-b60c-84cc115dd83b","","",false, this);
 
            IDControlMethod = RPSControlFactory.CreateRPSComboBox<ControlSheetCharacView>("643472f9-07e0-47f6-984f-f792437e2330","","",false, this);
 
            ControlMethod = RPSControlFactory.CreateRPSTextBox<ControlSheetCharacView>("48680e15-4e21-4e66-8aa8-e3c90b585962","","",false, this);
 
            IDReactionPlan = RPSControlFactory.CreateRPSComboBox<ControlSheetCharacView>("4eff7fc4-612f-4c4f-8d40-8f99598c70fa","","",false, this);
 
            ReactionPlan = RPSControlFactory.CreateRPSTextBox<ControlSheetCharacView>("87cbe320-a31b-4ebb-8da6-6eee4e088367","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<ControlSheetCharacView>("33ca9bf4-82c2-45b2-9a83-c387442a981d","","",false, this);
 
            AQIsRequired = RPSControlFactory.CreateRPSCheckBox<ControlSheetCharacView>("7ada18a0-76f0-42e4-b74e-c03b97402e76","","",true, this);
 
            AQDrawingPosition = RPSControlFactory.CreateRPSTextBox<ControlSheetCharacView>("ccd7f6f1-ea59-474f-968f-d5a8ed1add0d","","",false, this);
 
            AQInspectedBy = RPSControlFactory.CreateRPSEnumComboBox<ControlSheetCharacView>("2e5edf3b-491e-41e7-a7f4-97d5cc0179b5","","",true, this);
 
            AQIDMeasuringInstrument = RPSControlFactory.CreateRPSComboBox<ControlSheetCharacView>("769572aa-51ce-4ffc-b01b-f9fc60498569","","",false, this);
 
            AQSamplesNumber = RPSControlFactory.CreateRPSFormattedTextBox<ControlSheetCharacView>("65ad7a89-e1e2-4fce-b2dc-2e45e4837466","","",true, this);
 
            AQFrequency = RPSControlFactory.CreateRPSFormattedTextBox<ControlSheetCharacView>("8398b8ac-a657-4184-aa02-d74e52928e62","","",true, this);
 
            AQIDFrequencyUnit = RPSControlFactory.CreateRPSComboBox<ControlSheetCharacView>("52808318-86e5-42a3-bea3-b26452bc701e","","",false, this);
 
            AQIDFrequencyType = RPSControlFactory.CreateRPSComboBox<ControlSheetCharacView>("957131b7-bebb-4b33-9c2f-4c4d16c0899c","","",false, this);
 
            AQRBase = RPSControlFactory.CreateRPSFormattedTextBox<ControlSheetCharacView>("1ab3db10-d937-49bd-b3c8-57cdd75d2bff","","",true, this);
 
            AQIsCountable = RPSControlFactory.CreateRPSCheckBox<ControlSheetCharacView>("c3aaf6fd-a02d-4cf9-b5fd-8e0917e76521","","",true, this);
 
            AQControlType = RPSControlFactory.CreateRPSEnumComboBox<ControlSheetCharacView>("84626f43-edba-4cd8-b137-f45fdf3294f8","","",true, this);
 
            AQToleranceType = RPSControlFactory.CreateRPSEnumComboBox<ControlSheetCharacView>("103d0879-0bb6-4467-b63d-313459091e5b","","",true, this);
 
            Nominal1 = RPSControlFactory.CreateRPSFormattedTextBox<ControlSheetCharacView>("5a5d6336-2671-43d4-be19-f5947a7ec2dc","","",false, this);
 
            Max1 = RPSControlFactory.CreateRPSFormattedTextBox<ControlSheetCharacView>("fb55ba8d-c59b-425b-a252-3bf62f6d46d3","","",false, this);
 
            Min1 = RPSControlFactory.CreateRPSFormattedTextBox<ControlSheetCharacView>("f50454c7-8d3d-40da-9faf-31cf39933824","","",false, this);
 
            AQLCType = RPSControlFactory.CreateRPSEnumComboBox<ControlSheetCharacView>("4182058e-328c-4585-b412-88ee6dab52be","","",true, this);
 
            AQLCMS = RPSControlFactory.CreateRPSFormattedTextBox<ControlSheetCharacView>("f41e5c13-3760-452a-9ab8-55e14b14ee63","","",true, this);
 
            AQLCMI = RPSControlFactory.CreateRPSFormattedTextBox<ControlSheetCharacView>("904c22e9-2b58-4d82-8588-f57deae234e9","","",true, this);
 
            AQLCRS = RPSControlFactory.CreateRPSFormattedTextBox<ControlSheetCharacView>("72f29001-681a-4dae-ade4-6959099cc6a2","","",true, this);
 
            AQLCRI = RPSControlFactory.CreateRPSFormattedTextBox<ControlSheetCharacView>("18b4117c-7254-4c8c-8ac9-cc00a8f31087","","",true, this);
 
            AQMeasureUnit = RPSControlFactory.CreateRPSTextBox<ControlSheetCharacView>("64d0053f-c122-412b-90db-387ac1292355","","",false, this);
 
            AQOperatorNotes = RPSControlFactory.CreateRPSTextBox<ControlSheetCharacView>("b62134fc-2a39-421f-aae0-2cb066c508c1","","",false, this);
 
            AQInspectorNotes = RPSControlFactory.CreateRPSTextBox<ControlSheetCharacView>("fd1c5491-feec-44d5-b494-2db36f566d83","","",false, this);
 
            CollectionInit params_ControlSheetValues = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6cae1fb9-386b-4d57-8665-e9703a182298",CSSSelectorGrid="",XPathGrid=""};
            ControlSheetValues = RPSControlFactory.RPSCreateCollectionWithGrid<ControlSheetValuesCollectionEditor<ControlSheetCharacView,ControlSheetValueView>,ControlSheetCharacView,ControlSheetValueView>( params_ControlSheetValues,this,Screen.ControlSheetValueView);
 
            CollectionInit params_ControlSheetCharacByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a96465b6-c0ce-4278-9b6f-416dbc432a65",CSSSelectorGrid="",XPathGrid=""};
            ControlSheetCharacByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<ControlSheetCharacByLangsCollectionEditor<ControlSheetCharacView,ControlSheetValueView>,ControlSheetCharacView,ControlSheetValueView>( params_ControlSheetCharacByLangs,this,Screen.ControlSheetValueView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<ControlSheetCharacView>( "","ul li[rpsid='4a156a28-f8a0-4c8d-a0ea-15a4296306bd']","",this);
 
            CharacteristicByLangs = RPSControlFactory.CreateRPSSection<ControlSheetCharacView>( "","ul li[rpsid='305065dc-21e8-4dc2-8dc8-b181605c357e']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<ControlSheetCharacView>( "","ul li[rpsid='4c585305-bcc5-4045-8e62-820662c5546b']","",this);
 
            AutoQ = RPSControlFactory.CreateRPSSection<ControlSheetCharacView>( "","ul li[rpsid='43e66a13-88ae-4843-b97c-9e080437480e']","",this);
 

        }
        public IRPSButton<ControlSheetCharacView> DeleteButton { get; set; } 
        public IRPSButton<ControlSheetCharacView,ControlSheetVersionEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ControlSheetCharacView,ControlSheetVersionEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ControlSheetCharacView,ControlSheetVersionEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> NumCharacteristic { get; set; } 
        public IRPSComboBox<ControlSheetCharacView> IDCharacteristic { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> Description { get; set; } 
        public IRPSComboBox<ControlSheetCharacView> IDCharacteristicType { get; set; } 
        public IRPSComboBox<ControlSheetCharacView> IDCharacteristicClass { get; set; } 
        public IRPSCheckbox<ControlSheetCharacView> ViewCertificate { get; set; } 
        public IRPSComboBox<ControlSheetCharacView> ControlType { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> Nominal { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> Min { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> Max { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> ResultMin { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> ResultMax { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> ResultAverage { get; set; } 
        public IRPSCheckbox<ControlSheetCharacView> ResultOK { get; set; } 
        public IRPSCheckbox<ControlSheetCharacView> ResultNOK { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> ResultNumber { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> ValuesOutOfTolerance { get; set; } 
        public IRPSComboBox<ControlSheetCharacView> IDToleranceSpecification { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> ToleranceSpecification { get; set; } 
        public IRPSComboBox<ControlSheetCharacView> IDMeasureTechnique { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> MeasureTechnique { get; set; } 
        public IRPSComboBox<ControlSheetCharacView> IDSampleSize { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> SampleSize { get; set; } 
        public IRPSComboBox<ControlSheetCharacView> IDSampleFrequency { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> SampleFrecuency { get; set; } 
        public IRPSComboBox<ControlSheetCharacView> IDControlMethod { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> ControlMethod { get; set; } 
        public IRPSComboBox<ControlSheetCharacView> IDReactionPlan { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> ReactionPlan { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> Comment { get; set; } 
        public IRPSCheckbox<ControlSheetCharacView> AQIsRequired { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> AQDrawingPosition { get; set; } 
        public IRPSComboBox<ControlSheetCharacView> AQInspectedBy { get; set; } 
        public IRPSComboBox<ControlSheetCharacView> AQIDMeasuringInstrument { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> AQSamplesNumber { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> AQFrequency { get; set; } 
        public IRPSComboBox<ControlSheetCharacView> AQIDFrequencyUnit { get; set; } 
        public IRPSComboBox<ControlSheetCharacView> AQIDFrequencyType { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> AQRBase { get; set; } 
        public IRPSCheckbox<ControlSheetCharacView> AQIsCountable { get; set; } 
        public IRPSComboBox<ControlSheetCharacView> AQControlType { get; set; } 
        public IRPSComboBox<ControlSheetCharacView> AQToleranceType { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> Nominal1 { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> Max1 { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> Min1 { get; set; } 
        public IRPSComboBox<ControlSheetCharacView> AQLCType { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> AQLCMS { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> AQLCMI { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> AQLCRS { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> AQLCRI { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> AQMeasureUnit { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> AQOperatorNotes { get; set; } 
        public IRPSTextBox<ControlSheetCharacView> AQInspectorNotes { get; set; } 
        public ControlSheetValuesCollectionEditor<ControlSheetCharacView,ControlSheetValueView> ControlSheetValues { get; set; } 
        public ControlSheetCharacByLangsCollectionEditor<ControlSheetCharacView,ControlSheetValueView> ControlSheetCharacByLangs { get; set; } 
        public IRPSSection<ControlSheetCharacView> GeneralData { get; set; } 
        public IRPSSection<ControlSheetCharacView> CharacteristicByLangs { get; set; } 
        public IRPSSection<ControlSheetCharacView> Comments { get; set; } 
        public IRPSSection<ControlSheetCharacView> AutoQ { get; set; } 
        public ControlSheetVersion Screen { get; set; }
        public ControlSheetCharacView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ControlSheetValuesCollectionEditor<ControlSheetCharacView,ControlSheetValueView>:RPSCollectionEditor<ControlSheetCharacView,ControlSheetValueView> where ControlSheetCharacView : class, IView where ControlSheetValueView : class, IView
    {
        public  ControlSheetValuesGridView<ControlSheetCharacView,ControlSheetValueView> GridView {get;set;}
    }
    public partial class ControlSheetValuesGridView <ControlSheetCharacView,ControlSheetValueView> :  RPSGridView<ControlSheetCharacView,ControlSheetValueView> where ControlSheetCharacView : class, IView where ControlSheetValueView : class, IView
    {
        public ControlSheetValuesGridView(ControlSheetCharacView currentView,ControlSheetValueView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            SampleNumber = RPSControlFactory.CreateRPSGridFormattedTextBox<ControlSheetCharacView>("","#6cae1fb9-386b-4d57-8665-e9703a182298 .ag-row[role='row']@ROWINDEX [col-id='cSampleNumber']","",true, this.CurrentView);
 
            SampleDate = RPSControlFactory.CreateRPSGridTextBox<ControlSheetCharacView>("","#6cae1fb9-386b-4d57-8665-e9703a182298 .ag-row[role='row']@ROWINDEX [col-id='cSampleDate']","",true, this.CurrentView);
 
            SampleTime = RPSControlFactory.CreateRPSGridTextBox<ControlSheetCharacView>("","#6cae1fb9-386b-4d57-8665-e9703a182298 .ag-row[role='row']@ROWINDEX [col-id='cSampleTime']","",false, this.CurrentView);
 
            IDEmployee = RPSControlFactory.CreateRPSGridComboBox<ControlSheetCharacView>("","#6cae1fb9-386b-4d57-8665-e9703a182298 .ag-row[role='row']@ROWINDEX [col-id='cIDEmployee']","",false, this.CurrentView);
 
            Series = RPSControlFactory.CreateRPSGridEnumComboBox<ControlSheetCharacView>("","#6cae1fb9-386b-4d57-8665-e9703a182298 .ag-row[role='row']@ROWINDEX [col-id='cSeries']","",false, this.CurrentView);
 
            Value = RPSControlFactory.CreateRPSGridFormattedTextBox<ControlSheetCharacView>("","#6cae1fb9-386b-4d57-8665-e9703a182298 .ag-row[role='row']@ROWINDEX [col-id='cValue']","",false, this.CurrentView);
 
            OKorNOK = RPSControlFactory.CreateRPSGridEnumComboBox<ControlSheetCharacView>("","#6cae1fb9-386b-4d57-8665-e9703a182298 .ag-row[role='row']@ROWINDEX [col-id='cOKorNOK']","",false, this.CurrentView);
 
            Text = RPSControlFactory.CreateRPSGridTextBox<ControlSheetCharacView>("","#6cae1fb9-386b-4d57-8665-e9703a182298 .ag-row[role='row']@ROWINDEX [col-id='cText']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ControlSheetCharacView> SampleNumber { get; set; } 
        public IRPSGridTextBox<ControlSheetCharacView> SampleDate { get; set; } 
        public IRPSGridTextBox<ControlSheetCharacView> SampleTime { get; set; } 
        public IRPSGridComboBox<ControlSheetCharacView> IDEmployee { get; set; } 
        public IRPSGridComboBox<ControlSheetCharacView> Series { get; set; } 
        public IRPSGridTextBox<ControlSheetCharacView> Value { get; set; } 
        public IRPSGridComboBox<ControlSheetCharacView> OKorNOK { get; set; } 
        public IRPSGridTextBox<ControlSheetCharacView> Text { get; set; } 
                     
    }
 
        public partial class ControlSheetCharacByLangsCollectionEditor<ControlSheetCharacView,ControlSheetValueView>:RPSCollectionEditor<ControlSheetCharacView,ControlSheetValueView> where ControlSheetCharacView : class, IView where ControlSheetValueView : class, IView
    {
        public  ControlSheetCharacByLangsGridView<ControlSheetCharacView,ControlSheetValueView> GridView {get;set;}
    }
    public partial class ControlSheetCharacByLangsGridView <ControlSheetCharacView,ControlSheetValueView> :  RPSGridView<ControlSheetCharacView,ControlSheetValueView> where ControlSheetCharacView : class, IView where ControlSheetValueView : class, IView
    {
        public ControlSheetCharacByLangsGridView(ControlSheetCharacView currentView,ControlSheetValueView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<ControlSheetCharacView>("","#a96465b6-c0ce-4278-9b6f-416dbc432a65 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ControlSheetCharacView>("","#a96465b6-c0ce-4278-9b6f-416dbc432a65 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ControlSheetCharacView> CodLanguage { get; set; } 
        public IRPSGridTextBox<ControlSheetCharacView> Description { get; set; } 
                     
    }
 
    }
  
            
    public partial class ControlSheetValueView : View
    {
        public ControlSheetValueView(ControlSheetVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ControlSheetValueView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ControlSheetValueView,ControlSheetCharacView>( this,Screen.ControlSheetCharacView);
 
            BackButton = RPSControlFactory.RPSBackButton<ControlSheetValueView,ControlSheetCharacView>( this,Screen.ControlSheetCharacView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ControlSheetValueView,ControlSheetCharacView>( this,Screen.ControlSheetCharacView);
 
            SampleNumber = RPSControlFactory.CreateRPSFormattedTextBox<ControlSheetValueView>("4a4de9ea-6026-402c-b2d2-54540dc09647","","",true, this);
 
            SampleDate = RPSControlFactory.CreateRPSTextBox<ControlSheetValueView>("329684dd-9b57-4d43-bf84-2adf60c7f1d9","","",true, this);
 
            SampleTime = RPSControlFactory.CreateRPSTextBox<ControlSheetValueView>("f6774dd9-d170-4984-81ef-84a0169d441a","","",false, this);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<ControlSheetValueView>("b5622815-9c06-45c3-89cd-82fc49d08842","","",false, this);
 
            Series = RPSControlFactory.CreateRPSEnumComboBox<ControlSheetValueView>("0e262e1e-5a53-4be5-afdb-525ea133516d","","",false, this);
 
            Value = RPSControlFactory.CreateRPSFormattedTextBox<ControlSheetValueView>("e29cf335-c527-4caa-a17e-5cb4000add6f","","",false, this);
 
            OKorNOK = RPSControlFactory.CreateRPSEnumComboBox<ControlSheetValueView>("b6fdd4b2-0fae-41c0-b30c-9dbc86799ba3","","",false, this);
 
            Text = RPSControlFactory.CreateRPSTextBox<ControlSheetValueView>("435db955-c43a-43e9-86a8-05e7f8d5a10c","","",false, this);
 
            Notes = RPSControlFactory.CreateRPSTextBox<ControlSheetValueView>("74514d5f-b343-4c35-9b19-288af32f12e7","","",false, this);
 

        }
        public IRPSButton<ControlSheetValueView> DeleteButton { get; set; } 
        public IRPSButton<ControlSheetValueView,ControlSheetCharacView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ControlSheetValueView,ControlSheetCharacView> BackButton { get; set; } 
        public IRPSAcceptButton<ControlSheetValueView,ControlSheetCharacView> AcceptButton { get; set; } 
        public IRPSTextBox<ControlSheetValueView> SampleNumber { get; set; } 
        public IRPSTextBox<ControlSheetValueView> SampleDate { get; set; } 
        public IRPSTextBox<ControlSheetValueView> SampleTime { get; set; } 
        public IRPSComboBox<ControlSheetValueView> IDEmployee { get; set; } 
        public IRPSComboBox<ControlSheetValueView> Series { get; set; } 
        public IRPSTextBox<ControlSheetValueView> Value { get; set; } 
        public IRPSComboBox<ControlSheetValueView> OKorNOK { get; set; } 
        public IRPSTextBox<ControlSheetValueView> Text { get; set; } 
        public IRPSTextBox<ControlSheetValueView> Notes { get; set; } 
        public ControlSheetVersion Screen { get; set; }
        public ControlSheetValueView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ControlSheetCharacByLangView : View
    {
        public ControlSheetCharacByLangView(ControlSheetVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ControlSheetCharacByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ControlSheetCharacByLangView,ControlSheetCharacView>( this,Screen.ControlSheetCharacView);
 
            BackButton = RPSControlFactory.RPSBackButton<ControlSheetCharacByLangView,ControlSheetCharacView>( this,Screen.ControlSheetCharacView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ControlSheetCharacByLangView,ControlSheetCharacView>( this,Screen.ControlSheetCharacView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<ControlSheetCharacByLangView>("95464977-e622-4132-bc48-3d29e2a2772d","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ControlSheetCharacByLangView>("b4c617c0-f71c-4f5b-b262-e731ff139573","","",false, this);
 
            ToleranceSpecification = RPSControlFactory.CreateRPSTextBox<ControlSheetCharacByLangView>("676c72e1-0450-4b92-90ec-f1bef7a2634d","","",false, this);
 
            MeasureTechnique = RPSControlFactory.CreateRPSTextBox<ControlSheetCharacByLangView>("d0343208-8a70-4227-b61b-461509577d53","","",false, this);
 
            SampleSize = RPSControlFactory.CreateRPSTextBox<ControlSheetCharacByLangView>("ab33e535-fd8d-42ac-8c29-aa95d70ae29a","","",false, this);
 
            SampleFrequency = RPSControlFactory.CreateRPSTextBox<ControlSheetCharacByLangView>("9fb9d026-b857-4730-8b0b-4f05d0ab2edc","","",false, this);
 
            ControlMethod = RPSControlFactory.CreateRPSTextBox<ControlSheetCharacByLangView>("9c3a04dd-3978-45bb-a61a-04d054839fb5","","",false, this);
 
            ReactionPlan = RPSControlFactory.CreateRPSTextBox<ControlSheetCharacByLangView>("ea556c95-7d8b-48f3-b597-d2de8ef71a79","","",false, this);
 

        }
        public IRPSButton<ControlSheetCharacByLangView> DeleteButton { get; set; } 
        public IRPSButton<ControlSheetCharacByLangView,ControlSheetCharacView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ControlSheetCharacByLangView,ControlSheetCharacView> BackButton { get; set; } 
        public IRPSAcceptButton<ControlSheetCharacByLangView,ControlSheetCharacView> AcceptButton { get; set; } 
        public IRPSComboBox<ControlSheetCharacByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<ControlSheetCharacByLangView> Description { get; set; } 
        public IRPSTextBox<ControlSheetCharacByLangView> ToleranceSpecification { get; set; } 
        public IRPSTextBox<ControlSheetCharacByLangView> MeasureTechnique { get; set; } 
        public IRPSTextBox<ControlSheetCharacByLangView> SampleSize { get; set; } 
        public IRPSTextBox<ControlSheetCharacByLangView> SampleFrequency { get; set; } 
        public IRPSTextBox<ControlSheetCharacByLangView> ControlMethod { get; set; } 
        public IRPSTextBox<ControlSheetCharacByLangView> ReactionPlan { get; set; } 
        public ControlSheetVersion Screen { get; set; }
        public ControlSheetCharacByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ControlSheetInspectionView : View
    {
        public ControlSheetInspectionView(ControlSheetVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ControlSheetInspectionView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ControlSheetInspectionView,ControlSheetVersionEntityView>( this,Screen.ControlSheetVersionEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ControlSheetInspectionView,ControlSheetVersionEntityView>( this,Screen.ControlSheetVersionEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ControlSheetInspectionView,ControlSheetVersionEntityView>( this,Screen.ControlSheetVersionEntityView);
 
            NumInspection = RPSControlFactory.CreateRPSFormattedTextBox<ControlSheetInspectionView>("bef4b0cc-46d1-45d5-a4c8-2da96443fbb5","","",true, this);
 
            IDDeliveryNoteLine = RPSControlFactory.CreateRPSComboBox<ControlSheetInspectionView>("87669e0d-f144-4cb1-8ca8-ea01662cc00a","","",false, this);
 
            IDControlSheetQuantityElement = RPSControlFactory.CreateRPSTextBox<ControlSheetInspectionView>("48e9e395-2468-4830-88c2-74f06eaa9a68","","",true, this);
 
            Serie = RPSControlFactory.CreateRPSEnumComboBox<ControlSheetInspectionView>("885f8451-11d3-4625-a4d2-db13798d0ed8","","",false, this);
 
            IDLocationWarehouse = RPSControlFactory.CreateRPSComboBox<ControlSheetInspectionView>("5f1c7e15-b332-45b3-b7d7-347e31796d60","","",false, this);
 
            PotencyValue = RPSControlFactory.CreateRPSFormattedTextBox<ControlSheetInspectionView>("35301969-9c70-4eb4-8d99-342dc23da9fc","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<ControlSheetInspectionView>("5395fbd9-72f6-4c2a-ad03-d9d862f1c21b","","",false, this);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<ControlSheetInspectionView>("8e4b98f5-49fa-4857-8ea6-5ef508b05ff2","","",false, this);
 
            QuantityRejectedOL = RPSControlFactory.CreateRPSFormattedTextBox<ControlSheetInspectionView>("f6747ae9-8472-403e-a766-93ecaa4f2d72","","",false, this);
 
            QuantitySecondUnitRejectedOL = RPSControlFactory.CreateRPSFormattedTextBox<ControlSheetInspectionView>("361f457f-db9b-4f10-9785-4f5760cf5776","","",false, this);
 
            QuantityRejected = RPSControlFactory.CreateRPSFormattedTextBox<ControlSheetInspectionView>("f3c9fc0e-5c74-4f3f-855b-a75498e265f1","","",false, this);
 
            QuantitySecondUnitRejected = RPSControlFactory.CreateRPSFormattedTextBox<ControlSheetInspectionView>("41489dc7-2899-489b-b773-cf7dc76e765f","","",false, this);
 
            Inspected = RPSControlFactory.CreateRPSCheckBox<ControlSheetInspectionView>("3e2c6ee7-a095-44fd-874e-9753b8903a95","","",false, this);
 
            InspectedDate = RPSControlFactory.CreateRPSTextBox<ControlSheetInspectionView>("31eedeb6-0e45-4468-94a5-75ddc9e9b565","","",false, this);
 
            InspectedBy = RPSControlFactory.CreateRPSComboBox<ControlSheetInspectionView>("c2c4af4a-0fd3-44e4-9a32-186c84dccbdb","","",false, this);
 
            FinalizeReceptionInspectionNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ControlSheetInspectionView,FinalizeReceptionInspectionDialogView>("b98093e0-60d6-477a-bc9a-13dd3343f158","","", this,Screen.FinalizeReceptionInspectionDialogView);
 

        }
        public IRPSButton<ControlSheetInspectionView> DeleteButton { get; set; } 
        public IRPSButton<ControlSheetInspectionView,ControlSheetVersionEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ControlSheetInspectionView,ControlSheetVersionEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ControlSheetInspectionView,ControlSheetVersionEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<ControlSheetInspectionView> NumInspection { get; set; } 
        public IRPSComboBox<ControlSheetInspectionView> IDDeliveryNoteLine { get; set; } 
        public IRPSTextBox<ControlSheetInspectionView> IDControlSheetQuantityElement { get; set; } 
        public IRPSComboBox<ControlSheetInspectionView> Serie { get; set; } 
        public IRPSComboBox<ControlSheetInspectionView> IDLocationWarehouse { get; set; } 
        public IRPSTextBox<ControlSheetInspectionView> PotencyValue { get; set; } 
        public IRPSTextBox<ControlSheetInspectionView> Quantity { get; set; } 
        public IRPSTextBox<ControlSheetInspectionView> QuantitySecondUnit { get; set; } 
        public IRPSTextBox<ControlSheetInspectionView> QuantityRejectedOL { get; set; } 
        public IRPSTextBox<ControlSheetInspectionView> QuantitySecondUnitRejectedOL { get; set; } 
        public IRPSTextBox<ControlSheetInspectionView> QuantityRejected { get; set; } 
        public IRPSTextBox<ControlSheetInspectionView> QuantitySecondUnitRejected { get; set; } 
        public IRPSCheckbox<ControlSheetInspectionView> Inspected { get; set; } 
        public IRPSTextBox<ControlSheetInspectionView> InspectedDate { get; set; } 
        public IRPSComboBox<ControlSheetInspectionView> InspectedBy { get; set; } 
        public IRPSButton<ControlSheetInspectionView,FinalizeReceptionInspectionDialogView> FinalizeReceptionInspectionNavigationCommandButton { get; set; } 
        public ControlSheetVersion Screen { get; set; }
        public ControlSheetInspectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ControlSheetResidueView : View
    {
        public ControlSheetResidueView(ControlSheetVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ControlSheetResidueView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ControlSheetResidueView,ControlSheetVersionEntityView>( this,Screen.ControlSheetVersionEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ControlSheetResidueView,ControlSheetVersionEntityView>( this,Screen.ControlSheetVersionEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ControlSheetResidueView,ControlSheetVersionEntityView>( this,Screen.ControlSheetVersionEntityView);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<ControlSheetResidueView>("d3b6506c-7e25-4898-96f6-5301a6907298","","",true, this);
 
            Observation = RPSControlFactory.CreateRPSTextBox<ControlSheetResidueView>("d77be2b4-85ba-49a8-9557-dd6a1b0bdb5f","","",false, this);
 
            CollectionInit params_ControlSheetResidueControls = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="11ed5149-11bb-4ac9-a471-f5110dde8478",CSSSelectorGrid="",XPathGrid=""};
            ControlSheetResidueControls = RPSControlFactory.RPSCreateCollectionWithGrid<ControlSheetResidueControlsCollectionEditor<ControlSheetResidueView,ControlSheetResidueControlView>,ControlSheetResidueView,ControlSheetResidueControlView>( params_ControlSheetResidueControls,this,Screen.ControlSheetResidueControlView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<ControlSheetResidueView>( "","ul li[rpsid='f43ceeac-b47e-4489-a686-51d2e36d5fc1']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<ControlSheetResidueView>( "","ul li[rpsid='8aca9799-110b-4dbc-ae0d-f458a0aed4bb']","",this);
 

        }
        public IRPSButton<ControlSheetResidueView> DeleteButton { get; set; } 
        public IRPSButton<ControlSheetResidueView,ControlSheetVersionEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ControlSheetResidueView,ControlSheetVersionEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ControlSheetResidueView,ControlSheetVersionEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ControlSheetResidueView> IDArticle { get; set; } 
        public IRPSTextBox<ControlSheetResidueView> Observation { get; set; } 
        public ControlSheetResidueControlsCollectionEditor<ControlSheetResidueView,ControlSheetResidueControlView> ControlSheetResidueControls { get; set; } 
        public IRPSSection<ControlSheetResidueView> GeneralData { get; set; } 
        public IRPSSection<ControlSheetResidueView> Comments { get; set; } 
        public ControlSheetVersion Screen { get; set; }
        public ControlSheetResidueView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ControlSheetResidueControlsCollectionEditor<ControlSheetResidueView,ControlSheetResidueControlView>:RPSCollectionEditor<ControlSheetResidueView,ControlSheetResidueControlView> where ControlSheetResidueView : class, IView where ControlSheetResidueControlView : class, IView
    {
        public  ControlSheetResidueControlsGridView<ControlSheetResidueView,ControlSheetResidueControlView> GridView {get;set;}
    }
    public partial class ControlSheetResidueControlsGridView <ControlSheetResidueView,ControlSheetResidueControlView> :  RPSGridView<ControlSheetResidueView,ControlSheetResidueControlView> where ControlSheetResidueView : class, IView where ControlSheetResidueControlView : class, IView
    {
        public ControlSheetResidueControlsGridView(ControlSheetResidueView currentView,ControlSheetResidueControlView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NumActivity = RPSControlFactory.CreateRPSGridFormattedTextBox<ControlSheetResidueView>("","#11ed5149-11bb-4ac9-a471-f5110dde8478 .ag-row[role='row']@ROWINDEX [col-id='cNumActivity']","",true, this.CurrentView);
 
            Activity = RPSControlFactory.CreateRPSGridTextBox<ControlSheetResidueView>("","#11ed5149-11bb-4ac9-a471-f5110dde8478 .ag-row[role='row']@ROWINDEX [col-id='cActivity']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<ControlSheetResidueView>("","#11ed5149-11bb-4ac9-a471-f5110dde8478 .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            IDResponsibleSelector = RPSControlFactory.CreateRPSGridComboBox<ControlSheetResidueView>("","#11ed5149-11bb-4ac9-a471-f5110dde8478 .ag-row[role='row']@ROWINDEX [col-id='cIDResponsibleSelector']","",false, this.CurrentView);
 
            Observation = RPSControlFactory.CreateRPSGridMemoTextBox<ControlSheetResidueView>("","#11ed5149-11bb-4ac9-a471-f5110dde8478 .ag-row[role='row']@ROWINDEX [col-id='cObservation']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ControlSheetResidueView> NumActivity { get; set; } 
        public IRPSGridTextBox<ControlSheetResidueView> Activity { get; set; } 
        public IRPSGridComboBox<ControlSheetResidueView> Type { get; set; } 
        public IRPSGridComboBox<ControlSheetResidueView> IDResponsibleSelector { get; set; } 
        public IRPSGridTextBox<ControlSheetResidueView> Observation { get; set; } 
                     
    }
 
    }
  
            
    public partial class ControlSheetResidueControlView : View
    {
        public ControlSheetResidueControlView(ControlSheetVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ControlSheetResidueControlView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ControlSheetResidueControlView,ControlSheetResidueView>( this,Screen.ControlSheetResidueView);
 
            BackButton = RPSControlFactory.RPSBackButton<ControlSheetResidueControlView,ControlSheetResidueView>( this,Screen.ControlSheetResidueView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ControlSheetResidueControlView,ControlSheetResidueView>( this,Screen.ControlSheetResidueView);
 
            NumActivity = RPSControlFactory.CreateRPSFormattedTextBox<ControlSheetResidueControlView>("3af8b2db-d1cb-4055-926e-cf9df6fe8d4a","","",true, this);
 
            Activity = RPSControlFactory.CreateRPSTextBox<ControlSheetResidueControlView>("bf88d313-42d4-48c3-98d7-4f4648f16c77","","",true, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<ControlSheetResidueControlView>("75d667a4-e473-47e9-9e52-d85984741ec7","","",true, this);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<ControlSheetResidueControlView>("d77f7db1-a7fb-4193-931f-a7bd407f7f33","","",false, this);
 
            IDQualify = RPSControlFactory.CreateRPSComboBox<ControlSheetResidueControlView>("e60d2fac-1f17-4614-88d6-6ae16b602966","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<ControlSheetResidueControlView>("3860fb1a-1d64-4d57-a13a-f06aa45f4a0d","","",false, this);
 
            Observation = RPSControlFactory.CreateRPSTextBox<ControlSheetResidueControlView>("254b5a6b-e470-4336-ab65-c26a7f3022a0","","",false, this);
 
            CollectionInit params_ControlSheetResidueValues = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6afaa9da-3aa8-4455-8210-f7ba3ed7c01d",CSSSelectorGrid="",XPathGrid=""};
            ControlSheetResidueValues = RPSControlFactory.RPSCreateCollectionWithGrid<ControlSheetResidueValuesCollectionEditor<ControlSheetResidueControlView,ControlSheetResidueValueView>,ControlSheetResidueControlView,ControlSheetResidueValueView>( params_ControlSheetResidueValues,this,Screen.ControlSheetResidueValueView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<ControlSheetResidueControlView>( "","ul li[rpsid='80da88a0-0499-428e-b70b-a2b767d9e915']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<ControlSheetResidueControlView>( "","ul li[rpsid='8a1ae7c4-0104-4659-bddc-38660dcc90ce']","",this);
 

        }
        public IRPSButton<ControlSheetResidueControlView> DeleteButton { get; set; } 
        public IRPSButton<ControlSheetResidueControlView,ControlSheetResidueView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ControlSheetResidueControlView,ControlSheetResidueView> BackButton { get; set; } 
        public IRPSAcceptButton<ControlSheetResidueControlView,ControlSheetResidueView> AcceptButton { get; set; } 
        public IRPSTextBox<ControlSheetResidueControlView> NumActivity { get; set; } 
        public IRPSTextBox<ControlSheetResidueControlView> Activity { get; set; } 
        public IRPSComboBox<ControlSheetResidueControlView> Type { get; set; } 
        public IRPSComboBox<ControlSheetResidueControlView> IDEmployee { get; set; } 
        public IRPSComboBox<ControlSheetResidueControlView> IDQualify { get; set; } 
        public IRPSComboBox<ControlSheetResidueControlView> IDSupplier { get; set; } 
        public IRPSTextBox<ControlSheetResidueControlView> Observation { get; set; } 
        public ControlSheetResidueValuesCollectionEditor<ControlSheetResidueControlView,ControlSheetResidueValueView> ControlSheetResidueValues { get; set; } 
        public IRPSSection<ControlSheetResidueControlView> GeneralData { get; set; } 
        public IRPSSection<ControlSheetResidueControlView> Comments { get; set; } 
        public ControlSheetVersion Screen { get; set; }
        public ControlSheetResidueControlView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ControlSheetResidueValuesCollectionEditor<ControlSheetResidueControlView,ControlSheetResidueValueView>:RPSCollectionEditor<ControlSheetResidueControlView,ControlSheetResidueValueView> where ControlSheetResidueControlView : class, IView where ControlSheetResidueValueView : class, IView
    {
        public  ControlSheetResidueValuesGridView<ControlSheetResidueControlView,ControlSheetResidueValueView> GridView {get;set;}
    }
    public partial class ControlSheetResidueValuesGridView <ControlSheetResidueControlView,ControlSheetResidueValueView> :  RPSGridView<ControlSheetResidueControlView,ControlSheetResidueValueView> where ControlSheetResidueControlView : class, IView where ControlSheetResidueValueView : class, IView
    {
        public ControlSheetResidueValuesGridView(ControlSheetResidueControlView currentView,ControlSheetResidueValueView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            SampleNumber = RPSControlFactory.CreateRPSGridFormattedTextBox<ControlSheetResidueControlView>("","#6afaa9da-3aa8-4455-8210-f7ba3ed7c01d .ag-row[role='row']@ROWINDEX [col-id='cSampleNumber']","",true, this.CurrentView);
 
            SampleDate = RPSControlFactory.CreateRPSGridTextBox<ControlSheetResidueControlView>("","#6afaa9da-3aa8-4455-8210-f7ba3ed7c01d .ag-row[role='row']@ROWINDEX [col-id='cSampleDate']","",true, this.CurrentView);
 
            SampleTime = RPSControlFactory.CreateRPSGridTextBox<ControlSheetResidueControlView>("","#6afaa9da-3aa8-4455-8210-f7ba3ed7c01d .ag-row[role='row']@ROWINDEX [col-id='cSampleTime']","",true, this.CurrentView);
 
            ResponsibleDescription = RPSControlFactory.CreateRPSGridTextBox<ControlSheetResidueControlView>("","#6afaa9da-3aa8-4455-8210-f7ba3ed7c01d .ag-row[role='row']@ROWINDEX [col-id='cResponsibleDescription']","",false, this.CurrentView);
 
            Responsible = RPSControlFactory.CreateRPSGridComboBox<ControlSheetResidueControlView>("","#6afaa9da-3aa8-4455-8210-f7ba3ed7c01d .ag-row[role='row']@ROWINDEX [col-id='cResponsible']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<ControlSheetResidueControlView>("","#6afaa9da-3aa8-4455-8210-f7ba3ed7c01d .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSGridComboBox<ControlSheetResidueControlView>("","#6afaa9da-3aa8-4455-8210-f7ba3ed7c01d .ag-row[role='row']@ROWINDEX [col-id='cIDUnitQuantity']","",true, this.CurrentView);
 
            Volume = RPSControlFactory.CreateRPSGridTextBox<ControlSheetResidueControlView>("","#6afaa9da-3aa8-4455-8210-f7ba3ed7c01d .ag-row[role='row']@ROWINDEX [col-id='cVolume']","",true, this.CurrentView);
 
            ContainersNumber = RPSControlFactory.CreateRPSGridFormattedTextBox<ControlSheetResidueControlView>("","#6afaa9da-3aa8-4455-8210-f7ba3ed7c01d .ag-row[role='row']@ROWINDEX [col-id='cContainersNumber']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<ControlSheetResidueControlView> SampleNumber { get; set; } 
        public IRPSGridTextBox<ControlSheetResidueControlView> SampleDate { get; set; } 
        public IRPSGridTextBox<ControlSheetResidueControlView> SampleTime { get; set; } 
        public IRPSGridTextBox<ControlSheetResidueControlView> ResponsibleDescription { get; set; } 
        public IRPSGridComboBox<ControlSheetResidueControlView> Responsible { get; set; } 
        public IRPSGridTextBox<ControlSheetResidueControlView> Quantity { get; set; } 
        public IRPSGridComboBox<ControlSheetResidueControlView> IDUnitQuantity { get; set; } 
        public IRPSGridTextBox<ControlSheetResidueControlView> Volume { get; set; } 
        public IRPSGridTextBox<ControlSheetResidueControlView> ContainersNumber { get; set; } 
                     
    }
 
    }
  
            
    public partial class ControlSheetResidueValueView : View
    {
        public ControlSheetResidueValueView(ControlSheetVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ControlSheetResidueValueView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ControlSheetResidueValueView,ControlSheetResidueControlView>( this,Screen.ControlSheetResidueControlView);
 
            BackButton = RPSControlFactory.RPSBackButton<ControlSheetResidueValueView,ControlSheetResidueControlView>( this,Screen.ControlSheetResidueControlView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ControlSheetResidueValueView,ControlSheetResidueControlView>( this,Screen.ControlSheetResidueControlView);
 
            SampleNumber = RPSControlFactory.CreateRPSFormattedTextBox<ControlSheetResidueValueView>("bbd8c271-eccb-4583-9793-3b20feef15d4","","",true, this);
 
            SampleDate = RPSControlFactory.CreateRPSTextBox<ControlSheetResidueValueView>("ba8d775b-7a03-44bf-b264-a1795f8d0660","","",true, this);
 
            SampleTime = RPSControlFactory.CreateRPSTextBox<ControlSheetResidueValueView>("b6f13c60-520d-46c0-83c1-82055d8918ad","","",true, this);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<ControlSheetResidueValueView>("6eeae6fa-6f51-4ec1-8601-c8db3946a1c1","","",false, this);
 
            IDQualify = RPSControlFactory.CreateRPSComboBox<ControlSheetResidueValueView>("02a94aae-f3e5-4a96-afd8-ecc006d41725","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<ControlSheetResidueValueView>("29fc1248-b50b-4560-9d0d-bcda2d8da698","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<ControlSheetResidueValueView>("893f834d-cb4d-4c57-a32f-544f6832cc6e","","",true, this);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSComboBox<ControlSheetResidueValueView>("4089a7d7-d258-4112-a927-d8802541edb0","","",true, this);
 
            Volume = RPSControlFactory.CreateRPSTextBox<ControlSheetResidueValueView>("af8714cc-833b-4d69-a08e-7e70efb9f30b","","",true, this);
 
            ContainersNumber = RPSControlFactory.CreateRPSFormattedTextBox<ControlSheetResidueValueView>("c0e36da1-78d8-4854-9b73-496c991623fe","","",true, this);
 
            Notes = RPSControlFactory.CreateRPSTextBox<ControlSheetResidueValueView>("8b54f74e-dc37-4b6d-bf82-8cdec7f17656","","",false, this);
 

        }
        public IRPSButton<ControlSheetResidueValueView> DeleteButton { get; set; } 
        public IRPSButton<ControlSheetResidueValueView,ControlSheetResidueControlView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ControlSheetResidueValueView,ControlSheetResidueControlView> BackButton { get; set; } 
        public IRPSAcceptButton<ControlSheetResidueValueView,ControlSheetResidueControlView> AcceptButton { get; set; } 
        public IRPSTextBox<ControlSheetResidueValueView> SampleNumber { get; set; } 
        public IRPSTextBox<ControlSheetResidueValueView> SampleDate { get; set; } 
        public IRPSTextBox<ControlSheetResidueValueView> SampleTime { get; set; } 
        public IRPSComboBox<ControlSheetResidueValueView> IDEmployee { get; set; } 
        public IRPSComboBox<ControlSheetResidueValueView> IDQualify { get; set; } 
        public IRPSComboBox<ControlSheetResidueValueView> IDSupplier { get; set; } 
        public IRPSTextBox<ControlSheetResidueValueView> Quantity { get; set; } 
        public IRPSComboBox<ControlSheetResidueValueView> IDUnitQuantity { get; set; } 
        public IRPSTextBox<ControlSheetResidueValueView> Volume { get; set; } 
        public IRPSTextBox<ControlSheetResidueValueView> ContainersNumber { get; set; } 
        public IRPSTextBox<ControlSheetResidueValueView> Notes { get; set; } 
        public ControlSheetVersion Screen { get; set; }
        public ControlSheetResidueValueView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class RejectControlSheetVersionDialogView : View
    {
        public RejectControlSheetVersionDialogView(ControlSheetVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            RejectionDate = RPSControlFactory.CreateRPSTextBox<RejectControlSheetVersionDialogView>("65c9e7c0-f61c-4b81-bd94-15ae4bdcd4c6","","",true, this);
 
            RejectionReason = RPSControlFactory.CreateRPSTextBox<RejectControlSheetVersionDialogView>("378b18d9-82ff-4098-9740-a19ca9d7ebfd","","",true, this);
 

        }
        public IRPSTextBox<RejectControlSheetVersionDialogView> RejectionDate { get; set; } 
        public IRPSTextBox<RejectControlSheetVersionDialogView> RejectionReason { get; set; } 
        public ControlSheetVersion Screen { get; set; }
        public RejectControlSheetVersionDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class RejectionHistoryDialogView : View
    {
        public RejectionHistoryDialogView(ControlSheetVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_GetDocumentRejections = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3f656f45-1313-4073-bcc9-06926bf72f0a",CSSSelectorGrid="",XPathGrid=""};
            GetDocumentRejections = RPSControlFactory.RPSCreateCollectionWithGrid<GetDocumentRejectionsCollectionEditor<RejectionHistoryDialogView>,RejectionHistoryDialogView>( params_GetDocumentRejections,this);
 

        }
        public GetDocumentRejectionsCollectionEditor<RejectionHistoryDialogView> GetDocumentRejections { get; set; } 
        public ControlSheetVersion Screen { get; set; }
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
            VersionStatusFlow_DoneDate = RPSControlFactory.CreateRPSGridTextBox<RejectionHistoryDialogView>("","#3f656f45-1313-4073-bcc9-06926bf72f0a .ag-row[role='row']@ROWINDEX [col-id='cVersionStatusFlow_DoneDate']","",false, this.CurrentView);
 
            VersionStatusFlow_RejectionReason = RPSControlFactory.CreateRPSGridMemoTextBox<RejectionHistoryDialogView>("","#3f656f45-1313-4073-bcc9-06926bf72f0a .ag-row[role='row']@ROWINDEX [col-id='cVersionStatusFlow_RejectionReason']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<RejectionHistoryDialogView> VersionStatusFlow_DoneDate { get; set; } 
        public IRPSGridTextBox<RejectionHistoryDialogView> VersionStatusFlow_RejectionReason { get; set; } 
                     
    }
 
    }
  
            
    public partial class SelectTaskTreeDialogView : View
    {
        public SelectTaskTreeDialogView(ControlSheetVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public ControlSheetVersion Screen { get; set; }
        public SelectTaskTreeDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CopyFromOtherSheetDialogView : View
    {
        public CopyFromOtherSheetDialogView(ControlSheetVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDManufacturingOrder = RPSControlFactory.CreateRPSComboBox<CopyFromOtherSheetDialogView>("b276ebaa-be20-415d-bd7f-4f88e80a4294","","",false, this);
 
            IDMOTask = RPSControlFactory.CreateRPSComboBox<CopyFromOtherSheetDialogView>("c7a0d955-efd9-4d49-95ba-2e5c8db1397e","","",false, this);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<CopyFromOtherSheetDialogView>("510e0889-e426-43d1-893f-2738a099f8f7","","",false, this);
 
            IDProTask = RPSControlFactory.CreateRPSComboBox<CopyFromOtherSheetDialogView>("ddcb360a-0178-4e87-8404-eb2a1aadbcd5","","",false, this);
 
            IDControlSheetVersionProduction = RPSControlFactory.CreateRPSComboBox<CopyFromOtherSheetDialogView>("92b4d972-2f54-45df-8141-ba6119f7f51f","","",true, this);
 
            CopySampleValues = RPSControlFactory.CreateRPSCheckBox<CopyFromOtherSheetDialogView>("3135e5bf-3358-4eb1-acdd-4260ded9e19d","","",false, this);
 
            All = RPSControlFactory.CreateRPSOption<CopyFromOtherSheetDialogView>( "95f38070-f4ce-4d78-8505-0676aacf4d8f","","",this);
 
            Selection = RPSControlFactory.CreateRPSOption<CopyFromOtherSheetDialogView>( "978b44ab-0a2b-463d-b975-35859fc1fd5c","","",this);
 
            CollectionInit params_SeriesRegisteredInControlSheetValues = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ec089311-9ddd-4031-9e5f-af6068e8234d",CSSSelectorGrid="",XPathGrid=""};
            SeriesRegisteredInControlSheetValues = RPSControlFactory.RPSCreateCollectionWithGrid<SeriesRegisteredInControlSheetValuesCollectionEditor<CopyFromOtherSheetDialogView>,CopyFromOtherSheetDialogView>( params_SeriesRegisteredInControlSheetValues,this);
 

        }
        public IRPSComboBox<CopyFromOtherSheetDialogView> IDManufacturingOrder { get; set; } 
        public IRPSComboBox<CopyFromOtherSheetDialogView> IDMOTask { get; set; } 
        public IRPSComboBox<CopyFromOtherSheetDialogView> IDProject { get; set; } 
        public IRPSComboBox<CopyFromOtherSheetDialogView> IDProTask { get; set; } 
        public IRPSComboBox<CopyFromOtherSheetDialogView> IDControlSheetVersionProduction { get; set; } 
        public IRPSCheckbox<CopyFromOtherSheetDialogView> CopySampleValues { get; set; } 
        public IRPSOption<CopyFromOtherSheetDialogView> All { get; set; } 
        public IRPSOption<CopyFromOtherSheetDialogView> Selection { get; set; } 
        public SeriesRegisteredInControlSheetValuesCollectionEditor<CopyFromOtherSheetDialogView> SeriesRegisteredInControlSheetValues { get; set; } 
        public ControlSheetVersion Screen { get; set; }
        public CopyFromOtherSheetDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SeriesRegisteredInControlSheetValuesCollectionEditor<CopyFromOtherSheetDialogView>:RPSCollectionEditor<CopyFromOtherSheetDialogView> where CopyFromOtherSheetDialogView : class, IView
    {
        public  SeriesRegisteredInControlSheetValuesGridView<CopyFromOtherSheetDialogView> GridView {get;set;}
    }
    public partial class SeriesRegisteredInControlSheetValuesGridView <CopyFromOtherSheetDialogView> :  RPSGridView<CopyFromOtherSheetDialogView> where CopyFromOtherSheetDialogView : class, IView
    {
        public SeriesRegisteredInControlSheetValuesGridView(CopyFromOtherSheetDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Series = RPSControlFactory.CreateRPSGridTextBox<CopyFromOtherSheetDialogView>("","#ec089311-9ddd-4031-9e5f-af6068e8234d .ag-row[role='row']@ROWINDEX [col-id='cSeries']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CopyFromOtherSheetDialogView> Series { get; set; } 
                     
    }
 
    }
  
            
    public partial class CopyFromOtherReceptionSheetDialogView : View
    {
        public CopyFromOtherReceptionSheetDialogView(ControlSheetVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDDeliveryNote = RPSControlFactory.CreateRPSComboBox<CopyFromOtherReceptionSheetDialogView>("1dc285dd-9641-4d5a-bbf0-5747142036d5","","",false, this);
 
            GroupBySerie = RPSControlFactory.CreateRPSCheckBox<CopyFromOtherReceptionSheetDialogView>("e0916c74-2415-49f3-944f-7dbaf7fcafc8","","",false, this);
 
            IDDeliveryNoteLine = RPSControlFactory.CreateRPSComboBox<CopyFromOtherReceptionSheetDialogView>("2d4d2efd-3961-47af-b6b8-e5614c8cde89","","",false, this);
 
            IDOrderLine = RPSControlFactory.CreateRPSComboBox<CopyFromOtherReceptionSheetDialogView>("b7ec93d2-ca52-4cb5-a94b-781337466bf9","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<CopyFromOtherReceptionSheetDialogView>("9fd572ff-417e-43ab-a186-5688d4a35867","","",true, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<CopyFromOtherReceptionSheetDialogView>("1fa359ad-e4e3-4fc9-af4d-ea455004a073","","",false, this);
 
            IDControlSheetSource = RPSControlFactory.CreateRPSEnumComboBox<CopyFromOtherReceptionSheetDialogView>("49f084f5-b2c9-4cee-ae84-87124550841f","","",true, this);
 
            IDControlSheetElement = RPSControlFactory.CreateRPSEnumComboBox<CopyFromOtherReceptionSheetDialogView>("aea82b17-a59b-44b4-834b-29f89bb3d1a4","","",true, this);
 
            IDControlSheetVersionReception = RPSControlFactory.CreateRPSComboBox<CopyFromOtherReceptionSheetDialogView>("2b6771a3-b318-4437-95ca-73bc832e859d","","",false, this);
 
            IDControlSheetVersionReceptionManual = RPSControlFactory.CreateRPSComboBox<CopyFromOtherReceptionSheetDialogView>("ab805e2c-833f-4278-b3fa-5ebd8df757b5","","",false, this);
 
            CopySampleValues = RPSControlFactory.CreateRPSCheckBox<CopyFromOtherReceptionSheetDialogView>("bf15b247-253d-4697-a55e-3d6611916aae","","",false, this);
 
            All = RPSControlFactory.CreateRPSOption<CopyFromOtherReceptionSheetDialogView>( "ca2a2c5a-8ab0-4444-a6ea-fcdb99048bc1","","",this);
 
            Selection = RPSControlFactory.CreateRPSOption<CopyFromOtherReceptionSheetDialogView>( "9fcc02c3-6086-4471-8ea0-ddb44f252210","","",this);
 
            CollectionInit params_SeriesRegisteredInControlSheetReceptionValues = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d392d578-47dd-4af4-a018-888298a6e331",CSSSelectorGrid="",XPathGrid=""};
            SeriesRegisteredInControlSheetReceptionValues = RPSControlFactory.RPSCreateCollectionWithGrid<SeriesRegisteredInControlSheetReceptionValuesCollectionEditor<CopyFromOtherReceptionSheetDialogView>,CopyFromOtherReceptionSheetDialogView>( params_SeriesRegisteredInControlSheetReceptionValues,this);
 

        }
        public IRPSComboBox<CopyFromOtherReceptionSheetDialogView> IDDeliveryNote { get; set; } 
        public IRPSCheckbox<CopyFromOtherReceptionSheetDialogView> GroupBySerie { get; set; } 
        public IRPSComboBox<CopyFromOtherReceptionSheetDialogView> IDDeliveryNoteLine { get; set; } 
        public IRPSComboBox<CopyFromOtherReceptionSheetDialogView> IDOrderLine { get; set; } 
        public IRPSComboBox<CopyFromOtherReceptionSheetDialogView> IDArticle { get; set; } 
        public IRPSComboBox<CopyFromOtherReceptionSheetDialogView> IDSupplier { get; set; } 
        public IRPSComboBox<CopyFromOtherReceptionSheetDialogView> IDControlSheetSource { get; set; } 
        public IRPSComboBox<CopyFromOtherReceptionSheetDialogView> IDControlSheetElement { get; set; } 
        public IRPSComboBox<CopyFromOtherReceptionSheetDialogView> IDControlSheetVersionReception { get; set; } 
        public IRPSComboBox<CopyFromOtherReceptionSheetDialogView> IDControlSheetVersionReceptionManual { get; set; } 
        public IRPSCheckbox<CopyFromOtherReceptionSheetDialogView> CopySampleValues { get; set; } 
        public IRPSOption<CopyFromOtherReceptionSheetDialogView> All { get; set; } 
        public IRPSOption<CopyFromOtherReceptionSheetDialogView> Selection { get; set; } 
        public SeriesRegisteredInControlSheetReceptionValuesCollectionEditor<CopyFromOtherReceptionSheetDialogView> SeriesRegisteredInControlSheetReceptionValues { get; set; } 
        public ControlSheetVersion Screen { get; set; }
        public CopyFromOtherReceptionSheetDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SeriesRegisteredInControlSheetReceptionValuesCollectionEditor<CopyFromOtherReceptionSheetDialogView>:RPSCollectionEditor<CopyFromOtherReceptionSheetDialogView> where CopyFromOtherReceptionSheetDialogView : class, IView
    {
        public  SeriesRegisteredInControlSheetReceptionValuesGridView<CopyFromOtherReceptionSheetDialogView> GridView {get;set;}
    }
    public partial class SeriesRegisteredInControlSheetReceptionValuesGridView <CopyFromOtherReceptionSheetDialogView> :  RPSGridView<CopyFromOtherReceptionSheetDialogView> where CopyFromOtherReceptionSheetDialogView : class, IView
    {
        public SeriesRegisteredInControlSheetReceptionValuesGridView(CopyFromOtherReceptionSheetDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Series = RPSControlFactory.CreateRPSGridTextBox<CopyFromOtherReceptionSheetDialogView>("","#d392d578-47dd-4af4-a018-888298a6e331 .ag-row[role='row']@ROWINDEX [col-id='cSeries']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CopyFromOtherReceptionSheetDialogView> Series { get; set; } 
                     
    }
 
    }
  
            
    public partial class CopyFromOtherFinalSheetDialogView : View
    {
        public CopyFromOtherFinalSheetDialogView(ControlSheetVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            GroupBySerie = RPSControlFactory.CreateRPSCheckBox<CopyFromOtherFinalSheetDialogView>("6420622f-fffd-4ada-8820-bedd577a344f","","",false, this);
 
            IDDeliveryNoteSL = RPSControlFactory.CreateRPSComboBox<CopyFromOtherFinalSheetDialogView>("e2d3d946-1317-4997-a1f1-35a693b26635","","",false, this);
 
            IDOrderSL = RPSControlFactory.CreateRPSComboBox<CopyFromOtherFinalSheetDialogView>("187231b5-216a-4e48-8d70-5a30b1fc9ead","","",false, this);
 
            IDDeliveryNoteLineSL = RPSControlFactory.CreateRPSComboBox<CopyFromOtherFinalSheetDialogView>("d8e9a2dc-e676-44c1-93a8-531035b224d3","","",false, this);
 
            IDOrderLineSL = RPSControlFactory.CreateRPSComboBox<CopyFromOtherFinalSheetDialogView>("930dc341-7c7c-4b88-be43-78c46c56e743","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<CopyFromOtherFinalSheetDialogView>("b7b764a4-b388-4b37-b594-e258601da08d","","",true, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<CopyFromOtherFinalSheetDialogView>("68e7f737-ca7e-43cf-b733-9a3f950ef74b","","",false, this);
 
            IDControlSheetSource = RPSControlFactory.CreateRPSEnumComboBox<CopyFromOtherFinalSheetDialogView>("2766b8d8-c844-49f0-91e3-2ee2ab3e7f00","","",true, this);
 
            IDControlSheetElement = RPSControlFactory.CreateRPSEnumComboBox<CopyFromOtherFinalSheetDialogView>("86ceaaf6-effa-4366-9a2e-92deacfa69ef","","",true, this);
 
            IDControlSheetVersionFinal = RPSControlFactory.CreateRPSComboBox<CopyFromOtherFinalSheetDialogView>("e2700bfc-2380-4f15-8a77-1a674b85575c","","",false, this);
 
            IDControlSheetVersionFinalManual = RPSControlFactory.CreateRPSComboBox<CopyFromOtherFinalSheetDialogView>("dffe33e7-881c-4d8c-b669-afd0608adbd9","","",false, this);
 
            CopySampleValues = RPSControlFactory.CreateRPSCheckBox<CopyFromOtherFinalSheetDialogView>("04922242-f817-4515-88ac-9097e4ce2e83","","",false, this);
 
            All = RPSControlFactory.CreateRPSOption<CopyFromOtherFinalSheetDialogView>( "3f1f82e6-f82c-450b-b598-81687c7d3e1f","","",this);
 
            Selection = RPSControlFactory.CreateRPSOption<CopyFromOtherFinalSheetDialogView>( "f6dc97db-daea-49b5-b682-69c1d677aad2","","",this);
 
            CollectionInit params_SeriesRegisteredInControlFinalValues = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1188d7e8-51fa-4642-bdb2-f6090d8cbdb8",CSSSelectorGrid="",XPathGrid=""};
            SeriesRegisteredInControlFinalValues = RPSControlFactory.RPSCreateCollectionWithGrid<SeriesRegisteredInControlFinalValuesCollectionEditor<CopyFromOtherFinalSheetDialogView>,CopyFromOtherFinalSheetDialogView>( params_SeriesRegisteredInControlFinalValues,this);
 

        }
        public IRPSCheckbox<CopyFromOtherFinalSheetDialogView> GroupBySerie { get; set; } 
        public IRPSComboBox<CopyFromOtherFinalSheetDialogView> IDDeliveryNoteSL { get; set; } 
        public IRPSComboBox<CopyFromOtherFinalSheetDialogView> IDOrderSL { get; set; } 
        public IRPSComboBox<CopyFromOtherFinalSheetDialogView> IDDeliveryNoteLineSL { get; set; } 
        public IRPSComboBox<CopyFromOtherFinalSheetDialogView> IDOrderLineSL { get; set; } 
        public IRPSComboBox<CopyFromOtherFinalSheetDialogView> IDArticle { get; set; } 
        public IRPSComboBox<CopyFromOtherFinalSheetDialogView> IDCustomer { get; set; } 
        public IRPSComboBox<CopyFromOtherFinalSheetDialogView> IDControlSheetSource { get; set; } 
        public IRPSComboBox<CopyFromOtherFinalSheetDialogView> IDControlSheetElement { get; set; } 
        public IRPSComboBox<CopyFromOtherFinalSheetDialogView> IDControlSheetVersionFinal { get; set; } 
        public IRPSComboBox<CopyFromOtherFinalSheetDialogView> IDControlSheetVersionFinalManual { get; set; } 
        public IRPSCheckbox<CopyFromOtherFinalSheetDialogView> CopySampleValues { get; set; } 
        public IRPSOption<CopyFromOtherFinalSheetDialogView> All { get; set; } 
        public IRPSOption<CopyFromOtherFinalSheetDialogView> Selection { get; set; } 
        public SeriesRegisteredInControlFinalValuesCollectionEditor<CopyFromOtherFinalSheetDialogView> SeriesRegisteredInControlFinalValues { get; set; } 
        public ControlSheetVersion Screen { get; set; }
        public CopyFromOtherFinalSheetDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SeriesRegisteredInControlFinalValuesCollectionEditor<CopyFromOtherFinalSheetDialogView>:RPSCollectionEditor<CopyFromOtherFinalSheetDialogView> where CopyFromOtherFinalSheetDialogView : class, IView
    {
        public  SeriesRegisteredInControlFinalValuesGridView<CopyFromOtherFinalSheetDialogView> GridView {get;set;}
    }
    public partial class SeriesRegisteredInControlFinalValuesGridView <CopyFromOtherFinalSheetDialogView> :  RPSGridView<CopyFromOtherFinalSheetDialogView> where CopyFromOtherFinalSheetDialogView : class, IView
    {
        public SeriesRegisteredInControlFinalValuesGridView(CopyFromOtherFinalSheetDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Series = RPSControlFactory.CreateRPSGridTextBox<CopyFromOtherFinalSheetDialogView>("","#1188d7e8-51fa-4642-bdb2-f6090d8cbdb8 .ag-row[role='row']@ROWINDEX [col-id='cSeries']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CopyFromOtherFinalSheetDialogView> Series { get; set; } 
                     
    }
 
    }
  
            
    public partial class CreateNewNonConformityDialogView : View
    {
        public CreateNewNonConformityDialogView(ControlSheetVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NCCode = RPSControlFactory.CreateRPSTextBox<CreateNewNonConformityDialogView>("18fc4f67-6240-43d2-a9ad-5185fb6806ed","","",true, this);
 
            NCCreatedBy = RPSControlFactory.CreateRPSComboBox<CreateNewNonConformityDialogView>("696244fb-a805-4465-87ac-ee90275d677e","","",true, this);
 
            NCSource = RPSControlFactory.CreateRPSComboBox<CreateNewNonConformityDialogView>("76742bb5-9d6c-4d01-8921-ac81f9e6f5bd","","",true, this);
 
            NCSeverity = RPSControlFactory.CreateRPSEnumComboBox<CreateNewNonConformityDialogView>("4122814e-30bf-4de8-83a1-a7bd3f0fa6e9","","",true, this);
 
            NCDescription = RPSControlFactory.CreateRPSTextBox<CreateNewNonConformityDialogView>("71e81db4-b962-459e-889f-0c576b08950b","","",false, this);
 

        }
        public IRPSTextBox<CreateNewNonConformityDialogView> NCCode { get; set; } 
        public IRPSComboBox<CreateNewNonConformityDialogView> NCCreatedBy { get; set; } 
        public IRPSComboBox<CreateNewNonConformityDialogView> NCSource { get; set; } 
        public IRPSComboBox<CreateNewNonConformityDialogView> NCSeverity { get; set; } 
        public IRPSTextBox<CreateNewNonConformityDialogView> NCDescription { get; set; } 
        public ControlSheetVersion Screen { get; set; }
        public CreateNewNonConformityDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PrintReportOptionsDialogView : View
    {
        public PrintReportOptionsDialogView(ControlSheetVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDProductionCustomReport = RPSControlFactory.CreateRPSComboBox<PrintReportOptionsDialogView>("ba8bb500-8b4f-4d4c-8036-53c2e398adec","","",false, this);
 
            IDReceptionCustomReport = RPSControlFactory.CreateRPSComboBox<PrintReportOptionsDialogView>("18021b85-b26b-4d1c-b1c0-ef2734bb041e","","",false, this);
 
            IDFinalCustomReport = RPSControlFactory.CreateRPSComboBox<PrintReportOptionsDialogView>("86c9ff9e-41d0-47ff-918e-03f7a5f5ee4c","","",false, this);
 
            IncludeAttachments = RPSControlFactory.CreateRPSCheckBox<PrintReportOptionsDialogView>("d781ae06-7512-40a5-9302-a3a11aab6ae6","","",false, this);
 

        }
        public IRPSComboBox<PrintReportOptionsDialogView> IDProductionCustomReport { get; set; } 
        public IRPSComboBox<PrintReportOptionsDialogView> IDReceptionCustomReport { get; set; } 
        public IRPSComboBox<PrintReportOptionsDialogView> IDFinalCustomReport { get; set; } 
        public IRPSCheckbox<PrintReportOptionsDialogView> IncludeAttachments { get; set; } 
        public ControlSheetVersion Screen { get; set; }
        public PrintReportOptionsDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ControlSheetFinalImportCharacsView : View
    {
        public ControlSheetFinalImportCharacsView(ControlSheetVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ManufacturingSheet = RPSControlFactory.CreateRPSOption<ControlSheetFinalImportCharacsView>( "078a1824-208b-46b2-88b0-6fc046916e70","","",this);
 
            ReceptionSheet = RPSControlFactory.CreateRPSOption<ControlSheetFinalImportCharacsView>( "43e04918-21a5-4feb-a81d-1e15a6b3c176","","",this);
 
            IDMOTask = RPSControlFactory.CreateRPSComboBox<ControlSheetFinalImportCharacsView>("c25999c1-7d69-4d4d-bf8e-d1d7153e1b02","","",false, this);
 
            All = RPSControlFactory.CreateRPSOption<ControlSheetFinalImportCharacsView>( "c132f6a1-c10b-4345-8237-1f54d0afd856","","",this);
 
            Selection = RPSControlFactory.CreateRPSOption<ControlSheetFinalImportCharacsView>( "5facd195-3b6c-4732-a865-9f30e3ef8060","","",this);
 
            CollectionInit params_GetCharacsOfControlSheetForMOTask = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="bed7c534-08f9-474c-ae71-07926fc5a9d4",CSSSelectorGrid="",XPathGrid=""};
            GetCharacsOfControlSheetForMOTask = RPSControlFactory.RPSCreateCollectionWithGrid<GetCharacsOfControlSheetForMOTaskCollectionEditor<ControlSheetFinalImportCharacsView>,ControlSheetFinalImportCharacsView>( params_GetCharacsOfControlSheetForMOTask,this);
 
            CollectionInit params_GetCharacsOfControlSheetReceptionForSeries = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="024b1cfb-3c94-4fef-9129-e9a50698c9e0",CSSSelectorGrid="",XPathGrid=""};
            GetCharacsOfControlSheetReceptionForSeries = RPSControlFactory.RPSCreateCollectionWithGrid<GetCharacsOfControlSheetReceptionForSeriesCollectionEditor<ControlSheetFinalImportCharacsView>,ControlSheetFinalImportCharacsView>( params_GetCharacsOfControlSheetReceptionForSeries,this);
 
            CollectionInit params_SeriesRegisteredInControlSheetValues = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="cbe03a7a-99f2-4a84-b64c-50378d897ddc",CSSSelectorGrid="",XPathGrid=""};
            SeriesRegisteredInControlSheetValues = RPSControlFactory.RPSCreateCollectionWithGrid<SeriesRegisteredInControlSheetValuesCollectionEditor<ControlSheetFinalImportCharacsView>,ControlSheetFinalImportCharacsView>( params_SeriesRegisteredInControlSheetValues,this);
 

        }
        public IRPSOption<ControlSheetFinalImportCharacsView> ManufacturingSheet { get; set; } 
        public IRPSOption<ControlSheetFinalImportCharacsView> ReceptionSheet { get; set; } 
        public IRPSComboBox<ControlSheetFinalImportCharacsView> IDMOTask { get; set; } 
        public IRPSOption<ControlSheetFinalImportCharacsView> All { get; set; } 
        public IRPSOption<ControlSheetFinalImportCharacsView> Selection { get; set; } 
        public GetCharacsOfControlSheetForMOTaskCollectionEditor<ControlSheetFinalImportCharacsView> GetCharacsOfControlSheetForMOTask { get; set; } 
        public GetCharacsOfControlSheetReceptionForSeriesCollectionEditor<ControlSheetFinalImportCharacsView> GetCharacsOfControlSheetReceptionForSeries { get; set; } 
        public SeriesRegisteredInControlSheetValuesCollectionEditor<ControlSheetFinalImportCharacsView> SeriesRegisteredInControlSheetValues { get; set; } 
        public ControlSheetVersion Screen { get; set; }
        public ControlSheetFinalImportCharacsView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetCharacsOfControlSheetForMOTaskCollectionEditor<ControlSheetFinalImportCharacsView>:RPSCollectionEditor<ControlSheetFinalImportCharacsView> where ControlSheetFinalImportCharacsView : class, IView
    {
        public  GetCharacsOfControlSheetForMOTaskGridView<ControlSheetFinalImportCharacsView> GridView {get;set;}
    }
    public partial class GetCharacsOfControlSheetForMOTaskGridView <ControlSheetFinalImportCharacsView> :  RPSGridView<ControlSheetFinalImportCharacsView> where ControlSheetFinalImportCharacsView : class, IView
    {
        public GetCharacsOfControlSheetForMOTaskGridView(ControlSheetFinalImportCharacsView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ControlSheetCharac_ControlType = RPSControlFactory.CreateRPSGridTextBox<ControlSheetFinalImportCharacsView>("","#bed7c534-08f9-474c-ae71-07926fc5a9d4 .ag-row[role='row']@ROWINDEX [col-id='cControlSheetCharac_ControlType']","",false, this.CurrentView);
 
            ControlSheetCharac_Nominal = RPSControlFactory.CreateRPSGridFormattedTextBox<ControlSheetFinalImportCharacsView>("","#bed7c534-08f9-474c-ae71-07926fc5a9d4 .ag-row[role='row']@ROWINDEX [col-id='cControlSheetCharac_Nominal']","",false, this.CurrentView);
 
            ControlSheetCharac_Max = RPSControlFactory.CreateRPSGridFormattedTextBox<ControlSheetFinalImportCharacsView>("","#bed7c534-08f9-474c-ae71-07926fc5a9d4 .ag-row[role='row']@ROWINDEX [col-id='cControlSheetCharac_Max']","",false, this.CurrentView);
 
            ControlSheetCharac_Min = RPSControlFactory.CreateRPSGridFormattedTextBox<ControlSheetFinalImportCharacsView>("","#bed7c534-08f9-474c-ae71-07926fc5a9d4 .ag-row[role='row']@ROWINDEX [col-id='cControlSheetCharac_Min']","",false, this.CurrentView);
 
            ControlSheetCharac_ViewCertificate = RPSControlFactory.CreateRPSGridCheckBox<ControlSheetFinalImportCharacsView>("","#bed7c534-08f9-474c-ae71-07926fc5a9d4 .ag-row[role='row']@ROWINDEX [col-id='cControlSheetCharac_ViewCertificate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ControlSheetFinalImportCharacsView> ControlSheetCharac_ControlType { get; set; } 
        public IRPSGridTextBox<ControlSheetFinalImportCharacsView> ControlSheetCharac_Nominal { get; set; } 
        public IRPSGridTextBox<ControlSheetFinalImportCharacsView> ControlSheetCharac_Max { get; set; } 
        public IRPSGridTextBox<ControlSheetFinalImportCharacsView> ControlSheetCharac_Min { get; set; } 
        public IRPSGridCheckbox<ControlSheetFinalImportCharacsView> ControlSheetCharac_ViewCertificate { get; set; } 
                     
    }
 
        public partial class GetCharacsOfControlSheetReceptionForSeriesCollectionEditor<ControlSheetFinalImportCharacsView>:RPSCollectionEditor<ControlSheetFinalImportCharacsView> where ControlSheetFinalImportCharacsView : class, IView
    {
        public  GetCharacsOfControlSheetReceptionForSeriesGridView<ControlSheetFinalImportCharacsView> GridView {get;set;}
    }
    public partial class GetCharacsOfControlSheetReceptionForSeriesGridView <ControlSheetFinalImportCharacsView> :  RPSGridView<ControlSheetFinalImportCharacsView> where ControlSheetFinalImportCharacsView : class, IView
    {
        public GetCharacsOfControlSheetReceptionForSeriesGridView(ControlSheetFinalImportCharacsView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ControlSheetCharac_ControlType = RPSControlFactory.CreateRPSGridTextBox<ControlSheetFinalImportCharacsView>("","#024b1cfb-3c94-4fef-9129-e9a50698c9e0 .ag-row[role='row']@ROWINDEX [col-id='cControlSheetCharac_ControlType']","",false, this.CurrentView);
 
            ControlSheetCharac_Nominal = RPSControlFactory.CreateRPSGridFormattedTextBox<ControlSheetFinalImportCharacsView>("","#024b1cfb-3c94-4fef-9129-e9a50698c9e0 .ag-row[role='row']@ROWINDEX [col-id='cControlSheetCharac_Nominal']","",false, this.CurrentView);
 
            ControlSheetCharac_Max = RPSControlFactory.CreateRPSGridFormattedTextBox<ControlSheetFinalImportCharacsView>("","#024b1cfb-3c94-4fef-9129-e9a50698c9e0 .ag-row[role='row']@ROWINDEX [col-id='cControlSheetCharac_Max']","",false, this.CurrentView);
 
            ControlSheetCharac_Min = RPSControlFactory.CreateRPSGridFormattedTextBox<ControlSheetFinalImportCharacsView>("","#024b1cfb-3c94-4fef-9129-e9a50698c9e0 .ag-row[role='row']@ROWINDEX [col-id='cControlSheetCharac_Min']","",false, this.CurrentView);
 
            ControlSheetCharac_ViewCertificate = RPSControlFactory.CreateRPSGridCheckBox<ControlSheetFinalImportCharacsView>("","#024b1cfb-3c94-4fef-9129-e9a50698c9e0 .ag-row[role='row']@ROWINDEX [col-id='cControlSheetCharac_ViewCertificate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ControlSheetFinalImportCharacsView> ControlSheetCharac_ControlType { get; set; } 
        public IRPSGridTextBox<ControlSheetFinalImportCharacsView> ControlSheetCharac_Nominal { get; set; } 
        public IRPSGridTextBox<ControlSheetFinalImportCharacsView> ControlSheetCharac_Max { get; set; } 
        public IRPSGridTextBox<ControlSheetFinalImportCharacsView> ControlSheetCharac_Min { get; set; } 
        public IRPSGridCheckbox<ControlSheetFinalImportCharacsView> ControlSheetCharac_ViewCertificate { get; set; } 
                     
    }
 
        public partial class SeriesRegisteredInControlSheetValuesCollectionEditor<ControlSheetFinalImportCharacsView>:RPSCollectionEditor<ControlSheetFinalImportCharacsView> where ControlSheetFinalImportCharacsView : class, IView
    {
        public  SeriesRegisteredInControlSheetValuesGridView<ControlSheetFinalImportCharacsView> GridView {get;set;}
    }
    public partial class SeriesRegisteredInControlSheetValuesGridView <ControlSheetFinalImportCharacsView> :  RPSGridView<ControlSheetFinalImportCharacsView> where ControlSheetFinalImportCharacsView : class, IView
    {
        public SeriesRegisteredInControlSheetValuesGridView(ControlSheetFinalImportCharacsView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Series = RPSControlFactory.CreateRPSGridTextBox<ControlSheetFinalImportCharacsView>("","#cbe03a7a-99f2-4a84-b64c-50378d897ddc .ag-row[role='row']@ROWINDEX [col-id='cSeries']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ControlSheetFinalImportCharacsView> Series { get; set; } 
                     
    }
 
    }
  
            
    public partial class ControlSheetVersionByLangView : View
    {
        public ControlSheetVersionByLangView(ControlSheetVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ControlSheetVersionByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ControlSheetVersionByLangView,ControlSheetVersionEntityView>( this,Screen.ControlSheetVersionEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ControlSheetVersionByLangView,ControlSheetVersionEntityView>( this,Screen.ControlSheetVersionEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ControlSheetVersionByLangView,ControlSheetVersionEntityView>( this,Screen.ControlSheetVersionEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<ControlSheetVersionByLangView>("33bcebbb-45e1-4a92-bb8e-9026629e13b1","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ControlSheetVersionByLangView>("8ca9202e-b98c-4e70-a7a8-c2e66057416e","","",false, this);
 
            Notes = RPSControlFactory.CreateRPSTextBox<ControlSheetVersionByLangView>("f896095e-4ad6-4ea0-91c2-f569809a60ba","","",false, this);
 

        }
        public IRPSButton<ControlSheetVersionByLangView> DeleteButton { get; set; } 
        public IRPSButton<ControlSheetVersionByLangView,ControlSheetVersionEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ControlSheetVersionByLangView,ControlSheetVersionEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ControlSheetVersionByLangView,ControlSheetVersionEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ControlSheetVersionByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<ControlSheetVersionByLangView> Description { get; set; } 
        public IRPSTextBox<ControlSheetVersionByLangView> Notes { get; set; } 
        public ControlSheetVersion Screen { get; set; }
        public ControlSheetVersionByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FinalizeReceptionInspectionDialogView : View
    {
        public FinalizeReceptionInspectionDialogView(ControlSheetVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Inspected = RPSControlFactory.CreateRPSCheckBox<FinalizeReceptionInspectionDialogView>("9418df4c-fe31-4de3-b5b4-ba406d4c2c57","","",true, this);
 
            InspectedBy = RPSControlFactory.CreateRPSComboBox<FinalizeReceptionInspectionDialogView>("30d69ff0-145c-47a2-86d6-f73e9d11863b","","",true, this);
 
            InspectedDate = RPSControlFactory.CreateRPSTextBox<FinalizeReceptionInspectionDialogView>("9b9daf03-41ad-45c6-98c3-1c9598eb87d9","","",true, this);
 
            DNLineQuantity = RPSControlFactory.CreateRPSFormattedTextBox<FinalizeReceptionInspectionDialogView>("2b928855-bb70-4c05-a6e1-5c507df0ed52","","",false, this);
 
            DNLineQuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<FinalizeReceptionInspectionDialogView>("a09d9545-a6a5-4825-8e11-83bc61f0c8e0","","",false, this);
 
            QuantityRejected = RPSControlFactory.CreateRPSFormattedTextBox<FinalizeReceptionInspectionDialogView>("dda772e1-d1c2-4a53-b531-97012589ab2d","","",false, this);
 
            QuantitySecondUnitRejected = RPSControlFactory.CreateRPSFormattedTextBox<FinalizeReceptionInspectionDialogView>("a7d81cdb-793f-4a1b-85d5-519df6762233","","",false, this);
 
            PotencyValue = RPSControlFactory.CreateRPSFormattedTextBox<FinalizeReceptionInspectionDialogView>("27eb5043-d029-41a9-9949-24c8e280a364","","",false, this);
 
            IDSiteSource = RPSControlFactory.CreateRPSComboBox<FinalizeReceptionInspectionDialogView>("aef20357-b1df-4c4b-a7e1-8745a6bbfe84","","",false, this);
 
            IDWareHouseSource = RPSControlFactory.CreateRPSComboBox<FinalizeReceptionInspectionDialogView>("566dffa7-1a35-4856-b802-b99b0b840c24","","",false, this);
 
            IDLocationWarehouseSource = RPSControlFactory.CreateRPSComboBox<FinalizeReceptionInspectionDialogView>("3e835440-8c38-4dcb-9600-0728357e593f","","",false, this);
 
            TransferQuantityAcceptation = RPSControlFactory.CreateRPSCheckBox<FinalizeReceptionInspectionDialogView>("0a35a6a7-318f-447d-bf2a-6bc86f68a34c","","",false, this);
 
            IDSiteAcceptation = RPSControlFactory.CreateRPSComboBox<FinalizeReceptionInspectionDialogView>("456b3020-90b2-4ae4-b502-d1ab8801313f","","",false, this);
 
            IDWareHouseAcceptation = RPSControlFactory.CreateRPSComboBox<FinalizeReceptionInspectionDialogView>("f30cd385-f256-48ab-b22a-36bdd7445769","","",false, this);
 
            IDLocationWarehouseAcceptation = RPSControlFactory.CreateRPSComboBox<FinalizeReceptionInspectionDialogView>("3422eacd-6246-4c1d-8a41-3bc842f7d0a4","","",false, this);
 
            TransferQuantityRejected = RPSControlFactory.CreateRPSCheckBox<FinalizeReceptionInspectionDialogView>("2f354afe-4fee-4b88-bee6-0442307db4a0","","",false, this);
 
            IDSiteRejection = RPSControlFactory.CreateRPSComboBox<FinalizeReceptionInspectionDialogView>("b7711e86-92a0-4e7e-91e1-a7e96616f4b5","","",false, this);
 
            IDWareHouseRejection = RPSControlFactory.CreateRPSComboBox<FinalizeReceptionInspectionDialogView>("f4118a56-032e-4f0e-86aa-48c6943103b3","","",false, this);
 
            IDLocationWarehouseRejection = RPSControlFactory.CreateRPSComboBox<FinalizeReceptionInspectionDialogView>("743f8e78-74aa-4450-90f1-ce3e2d1f4e1a","","",false, this);
 

        }
        public IRPSCheckbox<FinalizeReceptionInspectionDialogView> Inspected { get; set; } 
        public IRPSComboBox<FinalizeReceptionInspectionDialogView> InspectedBy { get; set; } 
        public IRPSTextBox<FinalizeReceptionInspectionDialogView> InspectedDate { get; set; } 
        public IRPSTextBox<FinalizeReceptionInspectionDialogView> DNLineQuantity { get; set; } 
        public IRPSTextBox<FinalizeReceptionInspectionDialogView> DNLineQuantitySecondUnit { get; set; } 
        public IRPSTextBox<FinalizeReceptionInspectionDialogView> QuantityRejected { get; set; } 
        public IRPSTextBox<FinalizeReceptionInspectionDialogView> QuantitySecondUnitRejected { get; set; } 
        public IRPSTextBox<FinalizeReceptionInspectionDialogView> PotencyValue { get; set; } 
        public IRPSComboBox<FinalizeReceptionInspectionDialogView> IDSiteSource { get; set; } 
        public IRPSComboBox<FinalizeReceptionInspectionDialogView> IDWareHouseSource { get; set; } 
        public IRPSComboBox<FinalizeReceptionInspectionDialogView> IDLocationWarehouseSource { get; set; } 
        public IRPSCheckbox<FinalizeReceptionInspectionDialogView> TransferQuantityAcceptation { get; set; } 
        public IRPSComboBox<FinalizeReceptionInspectionDialogView> IDSiteAcceptation { get; set; } 
        public IRPSComboBox<FinalizeReceptionInspectionDialogView> IDWareHouseAcceptation { get; set; } 
        public IRPSComboBox<FinalizeReceptionInspectionDialogView> IDLocationWarehouseAcceptation { get; set; } 
        public IRPSCheckbox<FinalizeReceptionInspectionDialogView> TransferQuantityRejected { get; set; } 
        public IRPSComboBox<FinalizeReceptionInspectionDialogView> IDSiteRejection { get; set; } 
        public IRPSComboBox<FinalizeReceptionInspectionDialogView> IDWareHouseRejection { get; set; } 
        public IRPSComboBox<FinalizeReceptionInspectionDialogView> IDLocationWarehouseRejection { get; set; } 
        public ControlSheetVersion Screen { get; set; }
        public FinalizeReceptionInspectionDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}