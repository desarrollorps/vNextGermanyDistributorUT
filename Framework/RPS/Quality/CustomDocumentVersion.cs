    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.CustomDocumentVersion
{
    //RPS VERSION 1.0.0.0
    public partial class CustomDocumentVersion:Screen
    {
        public CustomDocumentVersion():base()
        {
            this.URL = "quality.customdocumentversion";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CustomDocumentVersionCollectionView  = new CustomDocumentVersionCollectionView(this); 
            CustomDocumentVersionEntityView  = new CustomDocumentVersionEntityView(this); 
            RejectCustomDocumentVersionDialogView  = new RejectCustomDocumentVersionDialogView(this); 
            RejectionsHistoryDialogView  = new RejectionsHistoryDialogView(this); 
            CopyCustomDocumentFromOtherDialogView  = new CopyCustomDocumentFromOtherDialogView(this); 
            CustomDocumentVersionCollectionView.InitializeControls(); 
            CustomDocumentVersionEntityView.InitializeControls(); 
            RejectCustomDocumentVersionDialogView.InitializeControls(); 
            RejectionsHistoryDialogView.InitializeControls(); 
            CopyCustomDocumentFromOtherDialogView.InitializeControls(); 
           
        }
      
            public CustomDocumentVersionCollectionView CustomDocumentVersionCollectionView {get; set; } 
            public CustomDocumentVersionEntityView CustomDocumentVersionEntityView {get; set; } 
            public RejectCustomDocumentVersionDialogView RejectCustomDocumentVersionDialogView {get; set; } 
            public RejectionsHistoryDialogView RejectionsHistoryDialogView {get; set; } 
            public CopyCustomDocumentFromOtherDialogView CopyCustomDocumentFromOtherDialogView {get; set; } 
    }
            
    public partial class CustomDocumentVersionCollectionView : View
    {
        public CustomDocumentVersionCollectionView(CustomDocumentVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CustomDocumentVersionCollectionView,CustomDocumentVersionEntityView>( this,Screen.CustomDocumentVersionEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "2ef60dac-31d0-4c3c-8318-00466ed3b440",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CustomDocumentVersionCollectionView,CustomDocumentVersionEntityView>( params_MainConsult,this,Screen.CustomDocumentVersionEntityView);
 

        }
        public IRPSButton<CustomDocumentVersionCollectionView,CustomDocumentVersionEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CustomDocumentVersionCollectionView,CustomDocumentVersionEntityView> MainConsult { get; set; } 
        public CustomDocumentVersion Screen { get; set; }
        public CustomDocumentVersionCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CustomDocumentVersionEntityView : View
    {
        public CustomDocumentVersionEntityView(CustomDocumentVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CustomDocumentVersionEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CustomDocumentVersionEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CustomDocumentVersionEntityView,CustomDocumentVersionCollectionView>( this,Screen.CustomDocumentVersionCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CustomDocumentVersionEntityView,CustomDocumentVersionCollectionView>( this,Screen.CustomDocumentVersionCollectionView);
 
            IDQualityDocumentType = RPSControlFactory.CreateRPSComboBox<CustomDocumentVersionEntityView>("7c9d548c-8cef-46bf-85e6-d004c8ff85ab","","",true, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<CustomDocumentVersionEntityView>("d34392e5-11c4-459d-b377-769671c3727b","","",true, this);
 
            IDArticleVersion = RPSControlFactory.CreateRPSComboBox<CustomDocumentVersionEntityView>("19f8684c-8010-4ba3-84c5-f1b25adcb216","","",false, this);
 
            UIIDArticleVersionSample = RPSControlFactory.CreateRPSComboBox<CustomDocumentVersionEntityView>("39663b1b-b626-4168-a1f6-673df06d3b1d","","",false, this);
 
            Version = RPSControlFactory.CreateRPSTextBox<CustomDocumentVersionEntityView>("d341ff33-b474-4e0a-8ada-3469b705edb2","","",true, this);
 
            DocumentNumber = RPSControlFactory.CreateRPSTextBox<CustomDocumentVersionEntityView>("52550a17-f829-4d13-8b65-200142f13163","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CustomDocumentVersionEntityView>("745f6141-c69c-46b4-8464-21feaf3cea19","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<CustomDocumentVersionEntityView>("017d24a9-2f78-4dbf-a7cd-77cd833ee98d","","",false, this);
 
            DocumentTitle = RPSControlFactory.CreateRPSTextBox<CustomDocumentVersionEntityView>("60b34713-c6a3-4828-9097-cd73d77fe4cf","","",false, this);
 
            DoneDate = RPSControlFactory.CreateRPSTextBox<CustomDocumentVersionEntityView>("d7db80eb-2a4c-4751-ab6d-1052b9258809","","",true, this);
 
            CodUserDoneBy = RPSControlFactory.CreateRPSComboBox<CustomDocumentVersionEntityView>("51f44748-b128-47e6-9870-e9945d7a1e44","","",true, this);
 
            EndDate = RPSControlFactory.CreateRPSTextBox<CustomDocumentVersionEntityView>("76c57a96-d303-4e35-99c2-0f810acc4d18","","",false, this);
 
            CodUserEnd = RPSControlFactory.CreateRPSComboBox<CustomDocumentVersionEntityView>("14f9d8f2-b22f-4e4d-bc19-2ed6c45653b4","","",false, this);
 
            ApprovedDate = RPSControlFactory.CreateRPSTextBox<CustomDocumentVersionEntityView>("46ed11eb-a882-4b23-a725-95e3ccffc15d","","",false, this);
 
            CodUserApprovedBy = RPSControlFactory.CreateRPSComboBox<CustomDocumentVersionEntityView>("76b35f7c-5d42-4842-a163-96de6ddae670","","",false, this);
 
            UIPendingLabel = RPSControlFactory.CreateRPSTextBox<CustomDocumentVersionEntityView>("1234c9f0-8aba-4137-bb1f-dfd65ff9358a","","",false, this);
 
            PendingRevisionCause = RPSControlFactory.CreateRPSTextBox<CustomDocumentVersionEntityView>("8de96cd6-f26f-4f24-ad31-c0446281002e","","",false, this);
 
            RejectionUser = RPSControlFactory.CreateRPSComboBox<CustomDocumentVersionEntityView>("8de58bcf-56b5-4a41-a268-20b6a49d8cce","","",false, this);
 
            RejectionDate = RPSControlFactory.CreateRPSTextBox<CustomDocumentVersionEntityView>("c730a7e9-97ff-4eb9-92bd-b0b238760a9f","","",false, this);
 
            RejectionReason = RPSControlFactory.CreateRPSTextBox<CustomDocumentVersionEntityView>("746cf863-b7af-4365-9877-64f688d20cbe","","",false, this);
 
            Comments = RPSControlFactory.CreateRPSTextBox<CustomDocumentVersionEntityView>("9e546699-f945-4d45-affe-38b7104a2e6a","","",false, this);
 
            FinalizeCommandButton = RPSControlFactory.CreateRPSButton<CustomDocumentVersionEntityView>( "f07bbd92-388c-4a3f-83e5-4b11f4a99245","","",this);
 
            ApprovalCommandButton = RPSControlFactory.CreateRPSButton<CustomDocumentVersionEntityView>( "38018a93-2bd4-429e-a966-2683b234a1df","","",this);
 
            RejectCustomDocumentVersionCommandButton = RPSControlFactory.CreateRPSButtonToView<CustomDocumentVersionEntityView,RejectCustomDocumentVersionDialogView>("2ce79863-fd26-4f7a-b27a-bf8024ba071e","","", this,Screen.RejectCustomDocumentVersionDialogView);
 
            ReceiptCommandButton = RPSControlFactory.CreateRPSButton<CustomDocumentVersionEntityView>( "5c75b3f3-f994-40aa-8c40-b3791f0f4487","","",this);
 
            ReviseCommandButton = RPSControlFactory.CreateRPSButton<CustomDocumentVersionEntityView>( "b9b5bfe6-2a95-4bc6-9f15-398daeae4248","","",this);
 
            ShowRejectionsCommandButton = RPSControlFactory.CreateRPSButtonToView<CustomDocumentVersionEntityView,RejectionsHistoryDialogView>("690c02ec-f955-47ab-9a23-c381674b01ba","","", this,Screen.RejectionsHistoryDialogView);
 
            CopyCustomDocumentFromOtherCommandButton = RPSControlFactory.CreateRPSButtonToView<CustomDocumentVersionEntityView,CopyCustomDocumentFromOtherDialogView>("3ef28871-8dcb-456b-83a8-01020c93a9f3","","", this,Screen.CopyCustomDocumentFromOtherDialogView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<CustomDocumentVersionEntityView>( "","ul li[rpsid='e58147fb-400b-4a32-bca0-9c5c34625618']","",this);
 
            Comments1 = RPSControlFactory.CreateRPSSection<CustomDocumentVersionEntityView>( "","ul li[rpsid='d7480acc-32df-4f60-a908-8e82007d54aa']","",this);
 

        }
        public IRPSSaveButton<CustomDocumentVersionEntityView> SaveButton { get; set; } 
        public IRPSButton<CustomDocumentVersionEntityView> DeleteButton { get; set; } 
        public IRPSButton<CustomDocumentVersionEntityView,CustomDocumentVersionCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomDocumentVersionEntityView,CustomDocumentVersionCollectionView> BackButton { get; set; } 
        public IRPSComboBox<CustomDocumentVersionEntityView> IDQualityDocumentType { get; set; } 
        public IRPSComboBox<CustomDocumentVersionEntityView> IDArticle { get; set; } 
        public IRPSComboBox<CustomDocumentVersionEntityView> IDArticleVersion { get; set; } 
        public IRPSComboBox<CustomDocumentVersionEntityView> UIIDArticleVersionSample { get; set; } 
        public IRPSTextBox<CustomDocumentVersionEntityView> Version { get; set; } 
        public IRPSTextBox<CustomDocumentVersionEntityView> DocumentNumber { get; set; } 
        public IRPSTextBox<CustomDocumentVersionEntityView> Description { get; set; } 
        public IRPSComboBox<CustomDocumentVersionEntityView> IDCustomer { get; set; } 
        public IRPSTextBox<CustomDocumentVersionEntityView> DocumentTitle { get; set; } 
        public IRPSTextBox<CustomDocumentVersionEntityView> DoneDate { get; set; } 
        public IRPSComboBox<CustomDocumentVersionEntityView> CodUserDoneBy { get; set; } 
        public IRPSTextBox<CustomDocumentVersionEntityView> EndDate { get; set; } 
        public IRPSComboBox<CustomDocumentVersionEntityView> CodUserEnd { get; set; } 
        public IRPSTextBox<CustomDocumentVersionEntityView> ApprovedDate { get; set; } 
        public IRPSComboBox<CustomDocumentVersionEntityView> CodUserApprovedBy { get; set; } 
        public IRPSTextBox<CustomDocumentVersionEntityView> UIPendingLabel { get; set; } 
        public IRPSTextBox<CustomDocumentVersionEntityView> PendingRevisionCause { get; set; } 
        public IRPSComboBox<CustomDocumentVersionEntityView> RejectionUser { get; set; } 
        public IRPSTextBox<CustomDocumentVersionEntityView> RejectionDate { get; set; } 
        public IRPSTextBox<CustomDocumentVersionEntityView> RejectionReason { get; set; } 
        public IRPSTextBox<CustomDocumentVersionEntityView> Comments { get; set; } 
        public IRPSButton<CustomDocumentVersionEntityView> FinalizeCommandButton { get; set; } 
        public IRPSButton<CustomDocumentVersionEntityView> ApprovalCommandButton { get; set; } 
        public IRPSButton<CustomDocumentVersionEntityView,RejectCustomDocumentVersionDialogView> RejectCustomDocumentVersionCommandButton { get; set; } 
        public IRPSButton<CustomDocumentVersionEntityView> ReceiptCommandButton { get; set; } 
        public IRPSButton<CustomDocumentVersionEntityView> ReviseCommandButton { get; set; } 
        public IRPSButton<CustomDocumentVersionEntityView,RejectionsHistoryDialogView> ShowRejectionsCommandButton { get; set; } 
        public IRPSButton<CustomDocumentVersionEntityView,CopyCustomDocumentFromOtherDialogView> CopyCustomDocumentFromOtherCommandButton { get; set; } 
        public IRPSSection<CustomDocumentVersionEntityView> GeneralData { get; set; } 
        public IRPSSection<CustomDocumentVersionEntityView> Comments1 { get; set; } 
        public CustomDocumentVersion Screen { get; set; }
        public CustomDocumentVersionEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class RejectCustomDocumentVersionDialogView : View
    {
        public RejectCustomDocumentVersionDialogView(CustomDocumentVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            RejectionDate = RPSControlFactory.CreateRPSTextBox<RejectCustomDocumentVersionDialogView>("65c9e7c0-f61c-4b81-bd94-15ae4bdcd4c6","","",true, this);
 
            RejectionReason = RPSControlFactory.CreateRPSTextBox<RejectCustomDocumentVersionDialogView>("378b18d9-82ff-4098-9740-a19ca9d7ebfd","","",true, this);
 

        }
        public IRPSTextBox<RejectCustomDocumentVersionDialogView> RejectionDate { get; set; } 
        public IRPSTextBox<RejectCustomDocumentVersionDialogView> RejectionReason { get; set; } 
        public CustomDocumentVersion Screen { get; set; }
        public RejectCustomDocumentVersionDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class RejectionsHistoryDialogView : View
    {
        public RejectionsHistoryDialogView(CustomDocumentVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_GetDocumentRejections = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="badcf472-8b1a-4c8a-a89f-5d3499df132c",CSSSelectorGrid="",XPathGrid=""};
            GetDocumentRejections = RPSControlFactory.RPSCreateCollectionWithGrid<GetDocumentRejectionsCollectionEditor<RejectionsHistoryDialogView>,RejectionsHistoryDialogView>( params_GetDocumentRejections,this);
 

        }
        public GetDocumentRejectionsCollectionEditor<RejectionsHistoryDialogView> GetDocumentRejections { get; set; } 
        public CustomDocumentVersion Screen { get; set; }
        public RejectionsHistoryDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetDocumentRejectionsCollectionEditor<RejectionsHistoryDialogView>:RPSCollectionEditor<RejectionsHistoryDialogView> where RejectionsHistoryDialogView : class, IView
    {
        public  GetDocumentRejectionsGridView<RejectionsHistoryDialogView> GridView {get;set;}
    }
    public partial class GetDocumentRejectionsGridView <RejectionsHistoryDialogView> :  RPSGridView<RejectionsHistoryDialogView> where RejectionsHistoryDialogView : class, IView
    {
        public GetDocumentRejectionsGridView(RejectionsHistoryDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            VersionStatusFlow_DoneDate = RPSControlFactory.CreateRPSGridTextBox<RejectionsHistoryDialogView>("","#badcf472-8b1a-4c8a-a89f-5d3499df132c .ag-row[role='row']@ROWINDEX [col-id='cVersionStatusFlow_DoneDate']","",false, this.CurrentView);
 
            VersionStatusFlow_RejectionReason = RPSControlFactory.CreateRPSGridMemoTextBox<RejectionsHistoryDialogView>("","#badcf472-8b1a-4c8a-a89f-5d3499df132c .ag-row[role='row']@ROWINDEX [col-id='cVersionStatusFlow_RejectionReason']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<RejectionsHistoryDialogView> VersionStatusFlow_DoneDate { get; set; } 
        public IRPSGridTextBox<RejectionsHistoryDialogView> VersionStatusFlow_RejectionReason { get; set; } 
                     
    }
 
    }
  
            
    public partial class CopyCustomDocumentFromOtherDialogView : View
    {
        public CopyCustomDocumentFromOtherDialogView(CustomDocumentVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSComboBox<CopyCustomDocumentFromOtherDialogView>("59d75b42-46f5-4dfc-bb21-b13eefa7818d","","",false, this);
 
            IDCustomDocumentVersionSource = RPSControlFactory.CreateRPSComboBox<CopyCustomDocumentFromOtherDialogView>("58758c35-acff-4929-b642-aafb262b06ad","","",false, this);
 

        }
        public IRPSComboBox<CopyCustomDocumentFromOtherDialogView> IDArticle { get; set; } 
        public IRPSComboBox<CopyCustomDocumentFromOtherDialogView> IDCustomDocumentVersionSource { get; set; } 
        public CustomDocumentVersion Screen { get; set; }
        public CopyCustomDocumentFromOtherDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}