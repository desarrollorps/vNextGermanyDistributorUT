    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.FeasibilityVersion
{
    //RPS VERSION 1.0.0.0
    public partial class FeasibilityVersion:Screen
    {
        public FeasibilityVersion():base()
        {
            this.URL = "quality.feasibilityversion";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            FeasibilityVersionCollectionView  = new FeasibilityVersionCollectionView(this); 
            FeasibilityVersionEntityView  = new FeasibilityVersionEntityView(this); 
            FeasibilityResultView  = new FeasibilityResultView(this); 
            FeasibilityVersionByLangView  = new FeasibilityVersionByLangView(this); 
            FeasibilityResultByLangView  = new FeasibilityResultByLangView(this); 
            RejectFeasibilityVersionDialogView  = new RejectFeasibilityVersionDialogView(this); 
            CopyFeasibilityFromOtherFeasibilityDialogView  = new CopyFeasibilityFromOtherFeasibilityDialogView(this); 
            PrintOptionsDialogView  = new PrintOptionsDialogView(this); 
            RejectionHistoryDialogView  = new RejectionHistoryDialogView(this); 
            FeasibilityVersionCollectionView.InitializeControls(); 
            FeasibilityVersionEntityView.InitializeControls(); 
            FeasibilityResultView.InitializeControls(); 
            FeasibilityVersionByLangView.InitializeControls(); 
            FeasibilityResultByLangView.InitializeControls(); 
            RejectFeasibilityVersionDialogView.InitializeControls(); 
            CopyFeasibilityFromOtherFeasibilityDialogView.InitializeControls(); 
            PrintOptionsDialogView.InitializeControls(); 
            RejectionHistoryDialogView.InitializeControls(); 
           
        }
      
            public FeasibilityVersionCollectionView FeasibilityVersionCollectionView {get; set; } 
            public FeasibilityVersionEntityView FeasibilityVersionEntityView {get; set; } 
            public FeasibilityResultView FeasibilityResultView {get; set; } 
            public FeasibilityVersionByLangView FeasibilityVersionByLangView {get; set; } 
            public FeasibilityResultByLangView FeasibilityResultByLangView {get; set; } 
            public RejectFeasibilityVersionDialogView RejectFeasibilityVersionDialogView {get; set; } 
            public CopyFeasibilityFromOtherFeasibilityDialogView CopyFeasibilityFromOtherFeasibilityDialogView {get; set; } 
            public PrintOptionsDialogView PrintOptionsDialogView {get; set; } 
            public RejectionHistoryDialogView RejectionHistoryDialogView {get; set; } 
    }
            
    public partial class FeasibilityVersionCollectionView : View
    {
        public FeasibilityVersionCollectionView(FeasibilityVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<FeasibilityVersionCollectionView,FeasibilityVersionEntityView>( this,Screen.FeasibilityVersionEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "e2b066cc-d20e-4930-83e3-a715560cb6f7",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<FeasibilityVersionCollectionView,FeasibilityVersionEntityView>( params_MainConsult,this,Screen.FeasibilityVersionEntityView);
 

        }
        public IRPSButton<FeasibilityVersionCollectionView,FeasibilityVersionEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<FeasibilityVersionCollectionView,FeasibilityVersionEntityView> MainConsult { get; set; } 
        public FeasibilityVersion Screen { get; set; }
        public FeasibilityVersionCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FeasibilityVersionEntityView : View
    {
        public FeasibilityVersionEntityView(FeasibilityVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<FeasibilityVersionEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<FeasibilityVersionEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FeasibilityVersionEntityView,FeasibilityVersionCollectionView>( this,Screen.FeasibilityVersionCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<FeasibilityVersionEntityView,FeasibilityVersionCollectionView>( this,Screen.FeasibilityVersionCollectionView);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<FeasibilityVersionEntityView>("2cad069f-98c5-44a3-a189-cc9ad18ac07b","","",true, this);
 
            IDArticleVersion = RPSControlFactory.CreateRPSComboBox<FeasibilityVersionEntityView>("2a8a9fa9-7b31-4c29-9e71-4547d7561ba8","","",false, this);
 
            UIIDArticleVersionSample = RPSControlFactory.CreateRPSComboBox<FeasibilityVersionEntityView>("27798880-37be-4013-b366-3077f0592dc5","","",false, this);
 
            FinalResult = RPSControlFactory.CreateRPSEnumComboBox<FeasibilityVersionEntityView>("3cfc4536-0c78-480a-a1ff-f6a56b11b973","","",false, this);
 
            Version = RPSControlFactory.CreateRPSTextBox<FeasibilityVersionEntityView>("1170d26d-7226-464d-afa4-8998442411e3","","",true, this);
 
            FasibilityNumber = RPSControlFactory.CreateRPSTextBox<FeasibilityVersionEntityView>("f50cb16f-9390-413d-80e5-7f69fae15d70","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<FeasibilityVersionEntityView>("54954b6b-ea72-4649-9645-a3c922d192a6","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<FeasibilityVersionEntityView>("5ebae5b6-e388-4218-a06d-e2bcfbec9b3b","","",false, this);
 
            IDOffer = RPSControlFactory.CreateRPSComboBox<FeasibilityVersionEntityView>("645bddb5-5988-46cd-8fb2-7980061448aa","","",false, this);
 
            OfferCode = RPSControlFactory.CreateRPSTextBox<FeasibilityVersionEntityView>("808501c4-ee98-42c7-b088-887fdebe35eb","","",false, this);
 
            OfferDate = RPSControlFactory.CreateRPSTextBox<FeasibilityVersionEntityView>("31097d39-60d0-43d8-816b-5a4e2ac6a742","","",false, this);
 
            DoneDate = RPSControlFactory.CreateRPSTextBox<FeasibilityVersionEntityView>("7f7bf884-486d-4f1e-b28e-afe1b51689fa","","",true, this);
 
            CodUserDoneBy = RPSControlFactory.CreateRPSComboBox<FeasibilityVersionEntityView>("583ba61a-eb72-46a6-a870-a9424212c072","","",true, this);
 
            EndDate = RPSControlFactory.CreateRPSTextBox<FeasibilityVersionEntityView>("a53bd356-c81e-4a8f-8a75-81a92da8406c","","",false, this);
 
            CodUserEnd = RPSControlFactory.CreateRPSComboBox<FeasibilityVersionEntityView>("5a3dc705-85f9-49c8-aff5-56e5e7bc814f","","",false, this);
 
            ApprovedDate = RPSControlFactory.CreateRPSTextBox<FeasibilityVersionEntityView>("0b7250fb-f38f-4b8e-8194-e994e6eb807b","","",false, this);
 
            CodUserApprovedBy = RPSControlFactory.CreateRPSComboBox<FeasibilityVersionEntityView>("f6c7721d-1d49-46d8-a8b7-02f4f4bcf724","","",false, this);
 
            UIPendingLabel = RPSControlFactory.CreateRPSTextBox<FeasibilityVersionEntityView>("ba4e7d10-ea1e-4824-b5b7-654d0ae0cb4f","","",false, this);
 
            PendingRevisionCause = RPSControlFactory.CreateRPSTextBox<FeasibilityVersionEntityView>("85dc1311-4439-47d2-9d27-e927b1990200","","",false, this);
 
            RejectionUser = RPSControlFactory.CreateRPSComboBox<FeasibilityVersionEntityView>("bba300ba-00ef-4cdc-8274-6d72a34ccfa7","","",false, this);
 
            RejectionDate = RPSControlFactory.CreateRPSTextBox<FeasibilityVersionEntityView>("674154b1-e820-4af6-b099-ae825affa3ad","","",false, this);
 
            RejectionReason = RPSControlFactory.CreateRPSTextBox<FeasibilityVersionEntityView>("0da9bf17-e92b-4406-a5f9-171788efdb11","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<FeasibilityVersionEntityView>("1d4d7dfb-50a2-4708-95ce-9112d52885d8","","",false, this);
 
            PrintOptionsNavigationCommandButton = RPSControlFactory.CreateRPSButton<FeasibilityVersionEntityView>( "6cd91408-22e6-4fbf-86b4-aff23d942cce","","",this);
 
            FinalizeCommandButton = RPSControlFactory.CreateRPSButton<FeasibilityVersionEntityView>( "32e8b30c-4f2d-441f-bc66-5a775e869467","","",this);
 
            ApprovalCommandButton = RPSControlFactory.CreateRPSButton<FeasibilityVersionEntityView>( "ce11f331-63bb-45d1-bf2d-d807c41f263f","","",this);
 
            RejectFeasibilityVersionCommandButton = RPSControlFactory.CreateRPSButtonToView<FeasibilityVersionEntityView,RejectFeasibilityVersionDialogView>("17c3af78-b4e1-4da4-bb94-912306a6c719","","", this,Screen.RejectFeasibilityVersionDialogView);
 
            ReceiptCommandButton = RPSControlFactory.CreateRPSButton<FeasibilityVersionEntityView>( "2b07e8b2-9ac6-4747-85e3-6ee99b4b5ed6","","",this);
 
            ReviseCommandButton = RPSControlFactory.CreateRPSButton<FeasibilityVersionEntityView>( "380886fb-dc6b-430f-9e7b-4f9dc6cc01d4","","",this);
 
            ShowRejectionsCommandButton = RPSControlFactory.CreateRPSButtonToView<FeasibilityVersionEntityView,RejectionHistoryDialogView>("b6265cde-9f8c-42d5-8698-791387d9122a","","", this,Screen.RejectionHistoryDialogView);
 
            InsertMasterQuestionsCommandButton = RPSControlFactory.CreateRPSButton<FeasibilityVersionEntityView>( "9043dfe3-f865-439d-a197-286a3333f256","","",this);
 
            CopyFeasibilityCommandButton = RPSControlFactory.CreateRPSButtonToView<FeasibilityVersionEntityView,CopyFeasibilityFromOtherFeasibilityDialogView>("0aec200f-b878-4202-aac0-8d17aaee238b","","", this,Screen.CopyFeasibilityFromOtherFeasibilityDialogView);
 
            CollectionInit params_FeasibilityResults = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c416fcf6-568c-46d4-bfe1-a0c57f27b7b9",CSSSelectorGrid="",XPathGrid=""};
            FeasibilityResults = RPSControlFactory.RPSCreateCollectionWithGrid<FeasibilityResultsCollectionEditor<FeasibilityVersionEntityView,FeasibilityResultView>,FeasibilityVersionEntityView,FeasibilityResultView>( params_FeasibilityResults,this,Screen.FeasibilityResultView);
 
            CollectionInit params_FeasibilityVersionByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="e42a6b8e-bbbd-4464-8188-ef97678b2b42",CSSSelectorGrid="",XPathGrid=""};
            FeasibilityVersionByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<FeasibilityVersionByLangsCollectionEditor<FeasibilityVersionEntityView,FeasibilityResultView>,FeasibilityVersionEntityView,FeasibilityResultView>( params_FeasibilityVersionByLangs,this,Screen.FeasibilityResultView);
 
            Results = RPSControlFactory.CreateRPSSection<FeasibilityVersionEntityView>( "","ul li[rpsid='655ddadc-082d-4e48-822f-d89e12c96f15']","",this);
 
            FeasibilityVersionByLangs1 = RPSControlFactory.CreateRPSSection<FeasibilityVersionEntityView>( "","ul li[rpsid='39fdccfa-0246-4cb2-938c-5c93d2acd682']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<FeasibilityVersionEntityView>( "","ul li[rpsid='54bc76a8-07fb-46af-b087-aab661d08d0d']","",this);
 

        }
        public IRPSSaveButton<FeasibilityVersionEntityView> SaveButton { get; set; } 
        public IRPSButton<FeasibilityVersionEntityView> DeleteButton { get; set; } 
        public IRPSButton<FeasibilityVersionEntityView,FeasibilityVersionCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FeasibilityVersionEntityView,FeasibilityVersionCollectionView> BackButton { get; set; } 
        public IRPSComboBox<FeasibilityVersionEntityView> IDArticle { get; set; } 
        public IRPSComboBox<FeasibilityVersionEntityView> IDArticleVersion { get; set; } 
        public IRPSComboBox<FeasibilityVersionEntityView> UIIDArticleVersionSample { get; set; } 
        public IRPSComboBox<FeasibilityVersionEntityView> FinalResult { get; set; } 
        public IRPSTextBox<FeasibilityVersionEntityView> Version { get; set; } 
        public IRPSTextBox<FeasibilityVersionEntityView> FasibilityNumber { get; set; } 
        public IRPSTextBox<FeasibilityVersionEntityView> Description { get; set; } 
        public IRPSComboBox<FeasibilityVersionEntityView> IDCustomer { get; set; } 
        public IRPSComboBox<FeasibilityVersionEntityView> IDOffer { get; set; } 
        public IRPSTextBox<FeasibilityVersionEntityView> OfferCode { get; set; } 
        public IRPSTextBox<FeasibilityVersionEntityView> OfferDate { get; set; } 
        public IRPSTextBox<FeasibilityVersionEntityView> DoneDate { get; set; } 
        public IRPSComboBox<FeasibilityVersionEntityView> CodUserDoneBy { get; set; } 
        public IRPSTextBox<FeasibilityVersionEntityView> EndDate { get; set; } 
        public IRPSComboBox<FeasibilityVersionEntityView> CodUserEnd { get; set; } 
        public IRPSTextBox<FeasibilityVersionEntityView> ApprovedDate { get; set; } 
        public IRPSComboBox<FeasibilityVersionEntityView> CodUserApprovedBy { get; set; } 
        public IRPSTextBox<FeasibilityVersionEntityView> UIPendingLabel { get; set; } 
        public IRPSTextBox<FeasibilityVersionEntityView> PendingRevisionCause { get; set; } 
        public IRPSComboBox<FeasibilityVersionEntityView> RejectionUser { get; set; } 
        public IRPSTextBox<FeasibilityVersionEntityView> RejectionDate { get; set; } 
        public IRPSTextBox<FeasibilityVersionEntityView> RejectionReason { get; set; } 
        public IRPSTextBox<FeasibilityVersionEntityView> Comment { get; set; } 
        public IRPSButton<FeasibilityVersionEntityView> PrintOptionsNavigationCommandButton { get; set; } 
        public IRPSButton<FeasibilityVersionEntityView> FinalizeCommandButton { get; set; } 
        public IRPSButton<FeasibilityVersionEntityView> ApprovalCommandButton { get; set; } 
        public IRPSButton<FeasibilityVersionEntityView,RejectFeasibilityVersionDialogView> RejectFeasibilityVersionCommandButton { get; set; } 
        public IRPSButton<FeasibilityVersionEntityView> ReceiptCommandButton { get; set; } 
        public IRPSButton<FeasibilityVersionEntityView> ReviseCommandButton { get; set; } 
        public IRPSButton<FeasibilityVersionEntityView,RejectionHistoryDialogView> ShowRejectionsCommandButton { get; set; } 
        public IRPSButton<FeasibilityVersionEntityView> InsertMasterQuestionsCommandButton { get; set; } 
        public IRPSButton<FeasibilityVersionEntityView,CopyFeasibilityFromOtherFeasibilityDialogView> CopyFeasibilityCommandButton { get; set; } 
        public FeasibilityResultsCollectionEditor<FeasibilityVersionEntityView,FeasibilityResultView> FeasibilityResults { get; set; } 
        public FeasibilityVersionByLangsCollectionEditor<FeasibilityVersionEntityView,FeasibilityResultView> FeasibilityVersionByLangs { get; set; } 
        public IRPSSection<FeasibilityVersionEntityView> Results { get; set; } 
        public IRPSSection<FeasibilityVersionEntityView> FeasibilityVersionByLangs1 { get; set; } 
        public IRPSSection<FeasibilityVersionEntityView> Comments { get; set; } 
        public FeasibilityVersion Screen { get; set; }
        public FeasibilityVersionEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class FeasibilityResultsCollectionEditor<FeasibilityVersionEntityView,FeasibilityResultView>:RPSCollectionEditor<FeasibilityVersionEntityView,FeasibilityResultView> where FeasibilityVersionEntityView : class, IView where FeasibilityResultView : class, IView
    {
        public  FeasibilityResultsGridView<FeasibilityVersionEntityView,FeasibilityResultView> GridView {get;set;}
    }
    public partial class FeasibilityResultsGridView <FeasibilityVersionEntityView,FeasibilityResultView> :  RPSGridView<FeasibilityVersionEntityView,FeasibilityResultView> where FeasibilityVersionEntityView : class, IView where FeasibilityResultView : class, IView
    {
        public FeasibilityResultsGridView(FeasibilityVersionEntityView currentView,FeasibilityResultView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NumQuestion = RPSControlFactory.CreateRPSGridFormattedTextBox<FeasibilityVersionEntityView>("","#c416fcf6-568c-46d4-bfe1-a0c57f27b7b9 .ag-row[role='row']@ROWINDEX [col-id='cNumQuestion']","",true, this.CurrentView);
 
            Question = RPSControlFactory.CreateRPSGridEnumComboBox<FeasibilityVersionEntityView>("","#c416fcf6-568c-46d4-bfe1-a0c57f27b7b9 .ag-row[role='row']@ROWINDEX [col-id='cQuestion']","",false, this.CurrentView);
 
            Result = RPSControlFactory.CreateRPSGridEnumComboBox<FeasibilityVersionEntityView>("","#c416fcf6-568c-46d4-bfe1-a0c57f27b7b9 .ag-row[role='row']@ROWINDEX [col-id='cResult']","",true, this.CurrentView);
 
            Notes = RPSControlFactory.CreateRPSGridMemoTextBox<FeasibilityVersionEntityView>("","#c416fcf6-568c-46d4-bfe1-a0c57f27b7b9 .ag-row[role='row']@ROWINDEX [col-id='cNotes']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<FeasibilityVersionEntityView> NumQuestion { get; set; } 
        public IRPSGridComboBox<FeasibilityVersionEntityView> Question { get; set; } 
        public IRPSGridComboBox<FeasibilityVersionEntityView> Result { get; set; } 
        public IRPSGridTextBox<FeasibilityVersionEntityView> Notes { get; set; } 
                     
    }
 
        public partial class FeasibilityVersionByLangsCollectionEditor<FeasibilityVersionEntityView,FeasibilityResultView>:RPSCollectionEditor<FeasibilityVersionEntityView,FeasibilityResultView> where FeasibilityVersionEntityView : class, IView where FeasibilityResultView : class, IView
    {
        public  FeasibilityVersionByLangsGridView<FeasibilityVersionEntityView,FeasibilityResultView> GridView {get;set;}
    }
    public partial class FeasibilityVersionByLangsGridView <FeasibilityVersionEntityView,FeasibilityResultView> :  RPSGridView<FeasibilityVersionEntityView,FeasibilityResultView> where FeasibilityVersionEntityView : class, IView where FeasibilityResultView : class, IView
    {
        public FeasibilityVersionByLangsGridView(FeasibilityVersionEntityView currentView,FeasibilityResultView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<FeasibilityVersionEntityView>("","#e42a6b8e-bbbd-4464-8188-ef97678b2b42 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<FeasibilityVersionEntityView>("","#e42a6b8e-bbbd-4464-8188-ef97678b2b42 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Comment = RPSControlFactory.CreateRPSGridMemoTextBox<FeasibilityVersionEntityView>("","#e42a6b8e-bbbd-4464-8188-ef97678b2b42 .ag-row[role='row']@ROWINDEX [col-id='cComment']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<FeasibilityVersionEntityView> CodLanguage { get; set; } 
        public IRPSGridTextBox<FeasibilityVersionEntityView> Description { get; set; } 
        public IRPSGridTextBox<FeasibilityVersionEntityView> Comment { get; set; } 
                     
    }
 
    }
  
            
    public partial class FeasibilityResultView : View
    {
        public FeasibilityResultView(FeasibilityVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<FeasibilityResultView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FeasibilityResultView,FeasibilityVersionEntityView>( this,Screen.FeasibilityVersionEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<FeasibilityResultView,FeasibilityVersionEntityView>( this,Screen.FeasibilityVersionEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<FeasibilityResultView,FeasibilityVersionEntityView>( this,Screen.FeasibilityVersionEntityView);
 
            NumQuestion = RPSControlFactory.CreateRPSFormattedTextBox<FeasibilityResultView>("15caadd3-0882-44e7-b472-4672aaf8ea71","","",true, this);
 
            Question = RPSControlFactory.CreateRPSEnumComboBox<FeasibilityResultView>("418256d5-f4df-4776-beb2-2e9a0a0b754b","","",false, this);
 
            Result = RPSControlFactory.CreateRPSEnumComboBox<FeasibilityResultView>("09ea6eb5-3c04-4fbd-ba00-26c8d6dced14","","",true, this);
 
            Notes = RPSControlFactory.CreateRPSTextBox<FeasibilityResultView>("17d3271a-96db-4a27-a165-8bffcc01a3bc","","",false, this);
 
            CollectionInit params_FeasibilityResultByLangs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c55501d4-4f47-45ef-8968-19de40797b65",CSSSelectorGrid="",XPathGrid=""};
            FeasibilityResultByLangs = RPSControlFactory.RPSCreateCollectionWithGrid<FeasibilityResultByLangsCollectionEditor<FeasibilityResultView,FeasibilityResultByLangView>,FeasibilityResultView,FeasibilityResultByLangView>( params_FeasibilityResultByLangs,this,Screen.FeasibilityResultByLangView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<FeasibilityResultView>( "","ul li[rpsid='53fee37e-3468-4bf6-ba79-8029b1c50e70']","",this);
 
            Section = RPSControlFactory.CreateRPSSection<FeasibilityResultView>( "","ul li[rpsid='bfd7f03e-b93e-4e5d-858c-c045bfb7b001']","",this);
 

        }
        public IRPSButton<FeasibilityResultView> DeleteButton { get; set; } 
        public IRPSButton<FeasibilityResultView,FeasibilityVersionEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FeasibilityResultView,FeasibilityVersionEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<FeasibilityResultView,FeasibilityVersionEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<FeasibilityResultView> NumQuestion { get; set; } 
        public IRPSComboBox<FeasibilityResultView> Question { get; set; } 
        public IRPSComboBox<FeasibilityResultView> Result { get; set; } 
        public IRPSTextBox<FeasibilityResultView> Notes { get; set; } 
        public FeasibilityResultByLangsCollectionEditor<FeasibilityResultView,FeasibilityResultByLangView> FeasibilityResultByLangs { get; set; } 
        public IRPSSection<FeasibilityResultView> GeneralData { get; set; } 
        public IRPSSection<FeasibilityResultView> Section { get; set; } 
        public FeasibilityVersion Screen { get; set; }
        public FeasibilityResultView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class FeasibilityResultByLangsCollectionEditor<FeasibilityResultView,FeasibilityResultByLangView>:RPSCollectionEditor<FeasibilityResultView,FeasibilityResultByLangView> where FeasibilityResultView : class, IView where FeasibilityResultByLangView : class, IView
    {
        public  FeasibilityResultByLangsGridView<FeasibilityResultView,FeasibilityResultByLangView> GridView {get;set;}
    }
    public partial class FeasibilityResultByLangsGridView <FeasibilityResultView,FeasibilityResultByLangView> :  RPSGridView<FeasibilityResultView,FeasibilityResultByLangView> where FeasibilityResultView : class, IView where FeasibilityResultByLangView : class, IView
    {
        public FeasibilityResultByLangsGridView(FeasibilityResultView currentView,FeasibilityResultByLangView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodLanguage = RPSControlFactory.CreateRPSGridComboBox<FeasibilityResultView>("","#c55501d4-4f47-45ef-8968-19de40797b65 .ag-row[role='row']@ROWINDEX [col-id='cCodLanguage']","",true, this.CurrentView);
 
            Question = RPSControlFactory.CreateRPSGridTextBox<FeasibilityResultView>("","#c55501d4-4f47-45ef-8968-19de40797b65 .ag-row[role='row']@ROWINDEX [col-id='cQuestion']","",false, this.CurrentView);
 
            Notes = RPSControlFactory.CreateRPSGridMemoTextBox<FeasibilityResultView>("","#c55501d4-4f47-45ef-8968-19de40797b65 .ag-row[role='row']@ROWINDEX [col-id='cNotes']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<FeasibilityResultView> CodLanguage { get; set; } 
        public IRPSGridTextBox<FeasibilityResultView> Question { get; set; } 
        public IRPSGridTextBox<FeasibilityResultView> Notes { get; set; } 
                     
    }
 
    }
  
            
    public partial class FeasibilityVersionByLangView : View
    {
        public FeasibilityVersionByLangView(FeasibilityVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<FeasibilityVersionByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FeasibilityVersionByLangView,FeasibilityVersionEntityView>( this,Screen.FeasibilityVersionEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<FeasibilityVersionByLangView,FeasibilityVersionEntityView>( this,Screen.FeasibilityVersionEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<FeasibilityVersionByLangView,FeasibilityVersionEntityView>( this,Screen.FeasibilityVersionEntityView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<FeasibilityVersionByLangView>("35837120-a9d0-4f59-aa3f-beb8d1ef40d3","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<FeasibilityVersionByLangView>("9489606c-f964-492a-aed9-751ff58c54e9","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<FeasibilityVersionByLangView>("ce81da6a-66f5-49c6-986b-9cadf93585e3","","",false, this);
 

        }
        public IRPSButton<FeasibilityVersionByLangView> DeleteButton { get; set; } 
        public IRPSButton<FeasibilityVersionByLangView,FeasibilityVersionEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FeasibilityVersionByLangView,FeasibilityVersionEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<FeasibilityVersionByLangView,FeasibilityVersionEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<FeasibilityVersionByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<FeasibilityVersionByLangView> Description { get; set; } 
        public IRPSTextBox<FeasibilityVersionByLangView> Comment { get; set; } 
        public FeasibilityVersion Screen { get; set; }
        public FeasibilityVersionByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FeasibilityResultByLangView : View
    {
        public FeasibilityResultByLangView(FeasibilityVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<FeasibilityResultByLangView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FeasibilityResultByLangView,FeasibilityResultView>( this,Screen.FeasibilityResultView);
 
            BackButton = RPSControlFactory.RPSBackButton<FeasibilityResultByLangView,FeasibilityResultView>( this,Screen.FeasibilityResultView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<FeasibilityResultByLangView,FeasibilityResultView>( this,Screen.FeasibilityResultView);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<FeasibilityResultByLangView>("51f98192-3ef9-4250-9d18-9f0828e148a4","","",true, this);
 
            Question = RPSControlFactory.CreateRPSTextBox<FeasibilityResultByLangView>("0ce26634-f201-4a80-859a-2d751a15cb98","","",false, this);
 
            Notes = RPSControlFactory.CreateRPSTextBox<FeasibilityResultByLangView>("3d335264-dc20-4f2d-a6a2-f56c137cac96","","",false, this);
 

        }
        public IRPSButton<FeasibilityResultByLangView> DeleteButton { get; set; } 
        public IRPSButton<FeasibilityResultByLangView,FeasibilityResultView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FeasibilityResultByLangView,FeasibilityResultView> BackButton { get; set; } 
        public IRPSAcceptButton<FeasibilityResultByLangView,FeasibilityResultView> AcceptButton { get; set; } 
        public IRPSComboBox<FeasibilityResultByLangView> CodLanguage { get; set; } 
        public IRPSTextBox<FeasibilityResultByLangView> Question { get; set; } 
        public IRPSTextBox<FeasibilityResultByLangView> Notes { get; set; } 
        public FeasibilityVersion Screen { get; set; }
        public FeasibilityResultByLangView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class RejectFeasibilityVersionDialogView : View
    {
        public RejectFeasibilityVersionDialogView(FeasibilityVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            RejectionDate = RPSControlFactory.CreateRPSTextBox<RejectFeasibilityVersionDialogView>("65c9e7c0-f61c-4b81-bd94-15ae4bdcd4c6","","",true, this);
 
            RejectionReason = RPSControlFactory.CreateRPSTextBox<RejectFeasibilityVersionDialogView>("378b18d9-82ff-4098-9740-a19ca9d7ebfd","","",true, this);
 

        }
        public IRPSTextBox<RejectFeasibilityVersionDialogView> RejectionDate { get; set; } 
        public IRPSTextBox<RejectFeasibilityVersionDialogView> RejectionReason { get; set; } 
        public FeasibilityVersion Screen { get; set; }
        public RejectFeasibilityVersionDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CopyFeasibilityFromOtherFeasibilityDialogView : View
    {
        public CopyFeasibilityFromOtherFeasibilityDialogView(FeasibilityVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSComboBox<CopyFeasibilityFromOtherFeasibilityDialogView>("8c9b3f6a-9f36-4cae-bf73-78c6e894ca5c","","",false, this);
 
            IDFeasibilityVersionSource = RPSControlFactory.CreateRPSComboBox<CopyFeasibilityFromOtherFeasibilityDialogView>("c6b209da-39ac-42cf-a6bd-fc7c9c4b8121","","",false, this);
 

        }
        public IRPSComboBox<CopyFeasibilityFromOtherFeasibilityDialogView> IDArticle { get; set; } 
        public IRPSComboBox<CopyFeasibilityFromOtherFeasibilityDialogView> IDFeasibilityVersionSource { get; set; } 
        public FeasibilityVersion Screen { get; set; }
        public CopyFeasibilityFromOtherFeasibilityDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PrintOptionsDialogView : View
    {
        public PrintOptionsDialogView(FeasibilityVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDCustomerToPrint = RPSControlFactory.CreateRPSComboBox<PrintOptionsDialogView>("40ae561a-7c22-4a18-8747-d583afe3c334","","",false, this);
 
            CodLanguagePrint = RPSControlFactory.CreateRPSComboBox<PrintOptionsDialogView>("f8b7b5e6-0c5a-47c0-88f3-f8e1e94ea537","","",false, this);
 
            FeasibilityStandard = RPSControlFactory.CreateRPSOption<PrintOptionsDialogView>( "f073104a-b9cb-48a6-9db5-4b95c23b2dc6","","",this);
 
            CustomFeasibilityReport = RPSControlFactory.CreateRPSOption<PrintOptionsDialogView>( "944d4cbe-149a-4856-b052-98eda9603b51","","",this);
 
            IDFeasibilityCustomReport = RPSControlFactory.CreateRPSComboBox<PrintOptionsDialogView>("b18b1627-d799-45b1-a726-4e86ab9c52da","","",false, this);
 
            UIAddAttachments = RPSControlFactory.CreateRPSCheckBox<PrintOptionsDialogView>("85845dbc-76b5-4531-be9a-3ce8463a3884","","",false, this);
 
            PrintFeasibilityVersionReportCommandButton = RPSControlFactory.CreateRPSButton<PrintOptionsDialogView>( "a320d5dc-6b3f-480e-be1e-3034924c7722","","",this);
 
            FeasibilityVersionReportByEMailCommandButton = RPSControlFactory.CreateRPSButton<PrintOptionsDialogView>( "540f5b3b-f6f3-43bf-863e-a4186d9b5c07","","",this);
 
            FeasibilityVersionReportByClientEmailCommandButton = RPSControlFactory.CreateRPSButton<PrintOptionsDialogView>( "4bab634e-a647-40a2-9553-ed4af125c4a1","","",this);
 

        }
        public IRPSComboBox<PrintOptionsDialogView> IDCustomerToPrint { get; set; } 
        public IRPSComboBox<PrintOptionsDialogView> CodLanguagePrint { get; set; } 
        public IRPSOption<PrintOptionsDialogView> FeasibilityStandard { get; set; } 
        public IRPSOption<PrintOptionsDialogView> CustomFeasibilityReport { get; set; } 
        public IRPSComboBox<PrintOptionsDialogView> IDFeasibilityCustomReport { get; set; } 
        public IRPSCheckbox<PrintOptionsDialogView> UIAddAttachments { get; set; } 
        public IRPSButton<PrintOptionsDialogView> PrintFeasibilityVersionReportCommandButton { get; set; } 
        public IRPSButton<PrintOptionsDialogView> FeasibilityVersionReportByEMailCommandButton { get; set; } 
        public IRPSButton<PrintOptionsDialogView> FeasibilityVersionReportByClientEmailCommandButton { get; set; } 
        public FeasibilityVersion Screen { get; set; }
        public PrintOptionsDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class RejectionHistoryDialogView : View
    {
        public RejectionHistoryDialogView(FeasibilityVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_GetDocumentRejections = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="65116756-e46a-4c2e-8dd8-b22f7f7314b0",CSSSelectorGrid="",XPathGrid=""};
            GetDocumentRejections = RPSControlFactory.RPSCreateCollectionWithGrid<GetDocumentRejectionsCollectionEditor<RejectionHistoryDialogView>,RejectionHistoryDialogView>( params_GetDocumentRejections,this);
 

        }
        public GetDocumentRejectionsCollectionEditor<RejectionHistoryDialogView> GetDocumentRejections { get; set; } 
        public FeasibilityVersion Screen { get; set; }
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
            VersionStatusFlow_DoneDate = RPSControlFactory.CreateRPSGridTextBox<RejectionHistoryDialogView>("","#65116756-e46a-4c2e-8dd8-b22f7f7314b0 .ag-row[role='row']@ROWINDEX [col-id='cVersionStatusFlow_DoneDate']","",false, this.CurrentView);
 
            VersionStatusFlow_RejectionReason = RPSControlFactory.CreateRPSGridMemoTextBox<RejectionHistoryDialogView>("","#65116756-e46a-4c2e-8dd8-b22f7f7314b0 .ag-row[role='row']@ROWINDEX [col-id='cVersionStatusFlow_RejectionReason']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<RejectionHistoryDialogView> VersionStatusFlow_DoneDate { get; set; } 
        public IRPSGridTextBox<RejectionHistoryDialogView> VersionStatusFlow_RejectionReason { get; set; } 
                     
    }
 
    }
  
    

}