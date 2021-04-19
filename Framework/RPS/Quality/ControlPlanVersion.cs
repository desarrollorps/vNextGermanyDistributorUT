    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.ControlPlanVersion
{
    //RPS VERSION 1.0.0.0
    public partial class ControlPlanVersion:Screen
    {
        public ControlPlanVersion():base()
        {
            this.URL = "quality.controlplanversion";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ControlPlanVersionCollectionView  = new ControlPlanVersionCollectionView(this); 
            ControlPlanVersionEntityView  = new ControlPlanVersionEntityView(this); 
            ControlPlanTaskView  = new ControlPlanTaskView(this); 
            RejectControlPlanVersionDialogView  = new RejectControlPlanVersionDialogView(this); 
            RejectionHistoryDialogView  = new RejectionHistoryDialogView(this); 
            CopyFromOtherControlPlanDialogView  = new CopyFromOtherControlPlanDialogView(this); 
            PrintControlPlanVersionOptionsDialogView  = new PrintControlPlanVersionOptionsDialogView(this); 
            ControlPlanVersionCollectionView.InitializeControls(); 
            ControlPlanVersionEntityView.InitializeControls(); 
            ControlPlanTaskView.InitializeControls(); 
            RejectControlPlanVersionDialogView.InitializeControls(); 
            RejectionHistoryDialogView.InitializeControls(); 
            CopyFromOtherControlPlanDialogView.InitializeControls(); 
            PrintControlPlanVersionOptionsDialogView.InitializeControls(); 
           
        }
      
            public ControlPlanVersionCollectionView ControlPlanVersionCollectionView {get; set; } 
            public ControlPlanVersionEntityView ControlPlanVersionEntityView {get; set; } 
            public ControlPlanTaskView ControlPlanTaskView {get; set; } 
            public RejectControlPlanVersionDialogView RejectControlPlanVersionDialogView {get; set; } 
            public RejectionHistoryDialogView RejectionHistoryDialogView {get; set; } 
            public CopyFromOtherControlPlanDialogView CopyFromOtherControlPlanDialogView {get; set; } 
            public PrintControlPlanVersionOptionsDialogView PrintControlPlanVersionOptionsDialogView {get; set; } 
    }
            
    public partial class ControlPlanVersionCollectionView : View
    {
        public ControlPlanVersionCollectionView(ControlPlanVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ControlPlanVersionCollectionView,ControlPlanVersionEntityView>( this,Screen.ControlPlanVersionEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "e04207c5-4823-46aa-8c69-8915c520f255",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ControlPlanVersionCollectionView,ControlPlanVersionEntityView>( params_MainConsult,this,Screen.ControlPlanVersionEntityView);
 

        }
        public IRPSButton<ControlPlanVersionCollectionView,ControlPlanVersionEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ControlPlanVersionCollectionView,ControlPlanVersionEntityView> MainConsult { get; set; } 
        public ControlPlanVersion Screen { get; set; }
        public ControlPlanVersionCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ControlPlanVersionEntityView : View
    {
        public ControlPlanVersionEntityView(ControlPlanVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ControlPlanVersionEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ControlPlanVersionEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ControlPlanVersionEntityView,ControlPlanVersionCollectionView>( this,Screen.ControlPlanVersionCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ControlPlanVersionEntityView,ControlPlanVersionCollectionView>( this,Screen.ControlPlanVersionCollectionView);
 
            UIIDSite = RPSControlFactory.CreateRPSComboBox<ControlPlanVersionEntityView>("70e71c5c-cd32-4584-8e1e-4d7bf2f4bddf","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<ControlPlanVersionEntityView>("a43708ab-d43f-4263-8717-f726f7f0f718","","",true, this);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<ControlPlanVersionEntityView>("c3e32cc8-524d-4cf6-b4d3-9fe4bd4c4afc","","",false, this);
 
            IDStructureManufacturing = RPSControlFactory.CreateRPSComboBox<ControlPlanVersionEntityView>("7af2b75b-b99b-485a-98ec-bf08db75a53c","","",false, this);
 
            IDArticleVersion = RPSControlFactory.CreateRPSComboBox<ControlPlanVersionEntityView>("023c9936-b691-45dd-8b25-42a8cc1b8812","","",false, this);
 
            UIIDArticleVersionSample = RPSControlFactory.CreateRPSComboBox<ControlPlanVersionEntityView>("30e36770-043a-46de-8bc2-e5cdbd161178","","",false, this);
 
            Version = RPSControlFactory.CreateRPSTextBox<ControlPlanVersionEntityView>("1b366bbf-a361-411c-8e5a-8a03498d27b2","","",true, this);
 
            ControlPlanNumber = RPSControlFactory.CreateRPSTextBox<ControlPlanVersionEntityView>("132ea1dc-eadf-412d-b576-c2cfc764f885","","",true, this);
 
            ControlPlanType = RPSControlFactory.CreateRPSEnumComboBox<ControlPlanVersionEntityView>("79fb2c32-3767-4b10-b85f-929a427a3fd1","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ControlPlanVersionEntityView>("b7c6962d-18e5-475c-ac2f-19191a716d89","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<ControlPlanVersionEntityView>("ef82e11a-b9ea-4e6c-afce-c3aff1bffc3b","","",false, this);
 
            CustApproval = RPSControlFactory.CreateRPSTextBox<ControlPlanVersionEntityView>("900cf50c-94ce-4549-a333-35359fa69f44","","",false, this);
 
            CustQualityApproval = RPSControlFactory.CreateRPSTextBox<ControlPlanVersionEntityView>("a479019e-e8b1-47ea-9d23-c896916d7f68","","",false, this);
 
            OtherApproval = RPSControlFactory.CreateRPSTextBox<ControlPlanVersionEntityView>("14f90d9c-c53c-4088-8864-34f8468ec199","","",false, this);
 
            DoneDate = RPSControlFactory.CreateRPSTextBox<ControlPlanVersionEntityView>("d44dc196-7621-46af-af60-13ef1f932864","","",true, this);
 
            CodUserDoneBy = RPSControlFactory.CreateRPSComboBox<ControlPlanVersionEntityView>("bc631951-e549-4409-b9dc-7181f650854a","","",true, this);
 
            EndDate = RPSControlFactory.CreateRPSTextBox<ControlPlanVersionEntityView>("ca13f0b5-55cb-4bba-816e-54a5b1d35f0e","","",false, this);
 
            CodUserEnd = RPSControlFactory.CreateRPSComboBox<ControlPlanVersionEntityView>("12fadc52-b5df-4375-b826-455467066741","","",false, this);
 
            ApprovedDate = RPSControlFactory.CreateRPSTextBox<ControlPlanVersionEntityView>("a66bb288-5724-48f3-abc7-1fa380d2a9c8","","",false, this);
 
            CodUserApprovedBy = RPSControlFactory.CreateRPSComboBox<ControlPlanVersionEntityView>("7556d59c-75a0-48c0-8c30-09b745c580b1","","",false, this);
 
            UIPendingLabel = RPSControlFactory.CreateRPSTextBox<ControlPlanVersionEntityView>("bf1f0c1d-e03e-46e0-9d38-29ce36a56c62","","",false, this);
 
            PendingRevisionCause = RPSControlFactory.CreateRPSTextBox<ControlPlanVersionEntityView>("3336fb01-85cf-4598-a8c9-74af2291580b","","",false, this);
 
            RejectionUser = RPSControlFactory.CreateRPSComboBox<ControlPlanVersionEntityView>("7e112b1f-8601-47f3-81c7-70141ef1e0b4","","",false, this);
 
            RejectionDate = RPSControlFactory.CreateRPSTextBox<ControlPlanVersionEntityView>("bb089a4d-495a-44ca-9471-eaf65a09d2b5","","",false, this);
 
            RejectionReason = RPSControlFactory.CreateRPSTextBox<ControlPlanVersionEntityView>("aa363f2d-7dbb-4f37-af8b-81c4c160a8ef","","",false, this);
 
            UIIDRoute = RPSControlFactory.CreateRPSComboBox<ControlPlanVersionEntityView>("3494c7c5-6f30-4d7d-bb2e-61bcaadcedf6","","",false, this);
 
            PrintControlPlanVersionOptionsCommandButton = RPSControlFactory.CreateRPSButtonToView<ControlPlanVersionEntityView,PrintControlPlanVersionOptionsDialogView>("1ea466c0-f6d3-4b2c-8b0a-c046ae72bf3b","","", this,Screen.PrintControlPlanVersionOptionsDialogView);
 
            FinalizeCommandButton = RPSControlFactory.CreateRPSButton<ControlPlanVersionEntityView>( "367607b5-5270-4b9c-be61-8a158f2a7120","","",this);
 
            ApprovalCommandButton = RPSControlFactory.CreateRPSButton<ControlPlanVersionEntityView>( "58e137c6-f6a7-4175-880e-4bca7ffceaf6","","",this);
 
            RejectCommandButton = RPSControlFactory.CreateRPSButtonToView<ControlPlanVersionEntityView,RejectControlPlanVersionDialogView>("49489677-f4fe-4b35-9f97-3dbbfacd4d89","","", this,Screen.RejectControlPlanVersionDialogView);
 
            ReceiptCommandButton = RPSControlFactory.CreateRPSButton<ControlPlanVersionEntityView>( "ccf1c8fc-bbc1-42c1-88a0-459393f44ad0","","",this);
 
            ReviseCommandButton = RPSControlFactory.CreateRPSButton<ControlPlanVersionEntityView>( "774b4fe6-a334-49c3-b162-0951d16e0168","","",this);
 
            ShowRejectionsCommandButton = RPSControlFactory.CreateRPSButtonToView<ControlPlanVersionEntityView,RejectionHistoryDialogView>("1586e015-3ce5-483a-9d0b-563761fd0a58","","", this,Screen.RejectionHistoryDialogView);
 
            AddDataFromLatestVersionCommandButton = RPSControlFactory.CreateRPSButton<ControlPlanVersionEntityView>( "1e57b860-6f0a-47dc-a132-c114b8a0d9c5","","",this);
 
            CopyFromOtherControlPlanCommandButton = RPSControlFactory.CreateRPSButtonToView<ControlPlanVersionEntityView,CopyFromOtherControlPlanDialogView>("5667b03c-4a11-4bed-b89e-f8f5219a45b8","","", this,Screen.CopyFromOtherControlPlanDialogView);
 
            CollectionInit params_ControlPlanTasks = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="216f1bf8-3ccf-4bdf-a4e1-38aadb2b6aa8",CSSSelectorGrid="",XPathGrid=""};
            ControlPlanTasks = RPSControlFactory.RPSCreateCollectionWithGrid<ControlPlanTasksCollectionEditor<ControlPlanVersionEntityView,ControlPlanTaskView>,ControlPlanVersionEntityView,ControlPlanTaskView>( params_ControlPlanTasks,this,Screen.ControlPlanTaskView);
 
            CollectionInit params_MaterialsWithControlPlanVersion = new CollectionInit(){IDDescriptor = "414044ce-7900-4094-86d3-ac0891bbc84f",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="26662ab7-8dbe-48d4-bd57-d3b3fce86d71",CSSSelectorGrid="",XPathGrid=""};
            MaterialsWithControlPlanVersion = RPSControlFactory.RPSCreateCollectionWithGrid<MaterialsWithControlPlanVersionCollectionEditor<ControlPlanVersionEntityView,ControlPlanTaskView>,ControlPlanVersionEntityView,ControlPlanTaskView>( params_MaterialsWithControlPlanVersion,this,Screen.ControlPlanTaskView);
 
            ControlPlanTask = RPSControlFactory.CreateRPSSection<ControlPlanVersionEntityView>( "","ul li[rpsid='5c38919f-870b-4882-88b6-5c072ad4d119']","",this);
 
            MaterialsWithControlPlan = RPSControlFactory.CreateRPSSection<ControlPlanVersionEntityView>( "","ul li[rpsid='5f5e42e3-ea29-4ddf-9197-073a7ce5bef7']","",this);
 
            Structure = RPSControlFactory.CreateRPSSection<ControlPlanVersionEntityView>( "","ul li[rpsid='a924ac8b-9d43-4a0e-b58e-002c43c85333']","",this);
 

        }
        public IRPSSaveButton<ControlPlanVersionEntityView> SaveButton { get; set; } 
        public IRPSButton<ControlPlanVersionEntityView> DeleteButton { get; set; } 
        public IRPSButton<ControlPlanVersionEntityView,ControlPlanVersionCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ControlPlanVersionEntityView,ControlPlanVersionCollectionView> BackButton { get; set; } 
        public IRPSComboBox<ControlPlanVersionEntityView> UIIDSite { get; set; } 
        public IRPSComboBox<ControlPlanVersionEntityView> IDArticle { get; set; } 
        public IRPSComboBox<ControlPlanVersionEntityView> IDProject { get; set; } 
        public IRPSComboBox<ControlPlanVersionEntityView> IDStructureManufacturing { get; set; } 
        public IRPSComboBox<ControlPlanVersionEntityView> IDArticleVersion { get; set; } 
        public IRPSComboBox<ControlPlanVersionEntityView> UIIDArticleVersionSample { get; set; } 
        public IRPSTextBox<ControlPlanVersionEntityView> Version { get; set; } 
        public IRPSTextBox<ControlPlanVersionEntityView> ControlPlanNumber { get; set; } 
        public IRPSComboBox<ControlPlanVersionEntityView> ControlPlanType { get; set; } 
        public IRPSTextBox<ControlPlanVersionEntityView> Description { get; set; } 
        public IRPSComboBox<ControlPlanVersionEntityView> IDCustomer { get; set; } 
        public IRPSTextBox<ControlPlanVersionEntityView> CustApproval { get; set; } 
        public IRPSTextBox<ControlPlanVersionEntityView> CustQualityApproval { get; set; } 
        public IRPSTextBox<ControlPlanVersionEntityView> OtherApproval { get; set; } 
        public IRPSTextBox<ControlPlanVersionEntityView> DoneDate { get; set; } 
        public IRPSComboBox<ControlPlanVersionEntityView> CodUserDoneBy { get; set; } 
        public IRPSTextBox<ControlPlanVersionEntityView> EndDate { get; set; } 
        public IRPSComboBox<ControlPlanVersionEntityView> CodUserEnd { get; set; } 
        public IRPSTextBox<ControlPlanVersionEntityView> ApprovedDate { get; set; } 
        public IRPSComboBox<ControlPlanVersionEntityView> CodUserApprovedBy { get; set; } 
        public IRPSTextBox<ControlPlanVersionEntityView> UIPendingLabel { get; set; } 
        public IRPSTextBox<ControlPlanVersionEntityView> PendingRevisionCause { get; set; } 
        public IRPSComboBox<ControlPlanVersionEntityView> RejectionUser { get; set; } 
        public IRPSTextBox<ControlPlanVersionEntityView> RejectionDate { get; set; } 
        public IRPSTextBox<ControlPlanVersionEntityView> RejectionReason { get; set; } 
        public IRPSComboBox<ControlPlanVersionEntityView> UIIDRoute { get; set; } 
        public IRPSButton<ControlPlanVersionEntityView,PrintControlPlanVersionOptionsDialogView> PrintControlPlanVersionOptionsCommandButton { get; set; } 
        public IRPSButton<ControlPlanVersionEntityView> FinalizeCommandButton { get; set; } 
        public IRPSButton<ControlPlanVersionEntityView> ApprovalCommandButton { get; set; } 
        public IRPSButton<ControlPlanVersionEntityView,RejectControlPlanVersionDialogView> RejectCommandButton { get; set; } 
        public IRPSButton<ControlPlanVersionEntityView> ReceiptCommandButton { get; set; } 
        public IRPSButton<ControlPlanVersionEntityView> ReviseCommandButton { get; set; } 
        public IRPSButton<ControlPlanVersionEntityView,RejectionHistoryDialogView> ShowRejectionsCommandButton { get; set; } 
        public IRPSButton<ControlPlanVersionEntityView> AddDataFromLatestVersionCommandButton { get; set; } 
        public IRPSButton<ControlPlanVersionEntityView,CopyFromOtherControlPlanDialogView> CopyFromOtherControlPlanCommandButton { get; set; } 
        public ControlPlanTasksCollectionEditor<ControlPlanVersionEntityView,ControlPlanTaskView> ControlPlanTasks { get; set; } 
        public MaterialsWithControlPlanVersionCollectionEditor<ControlPlanVersionEntityView,ControlPlanTaskView> MaterialsWithControlPlanVersion { get; set; } 
        public IRPSSection<ControlPlanVersionEntityView> ControlPlanTask { get; set; } 
        public IRPSSection<ControlPlanVersionEntityView> MaterialsWithControlPlan { get; set; } 
        public IRPSSection<ControlPlanVersionEntityView> Structure { get; set; } 
        public ControlPlanVersion Screen { get; set; }
        public ControlPlanVersionEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ControlPlanTasksCollectionEditor<ControlPlanVersionEntityView,ControlPlanTaskView>:RPSCollectionEditor<ControlPlanVersionEntityView,ControlPlanTaskView> where ControlPlanVersionEntityView : class, IView where ControlPlanTaskView : class, IView
    {
        public  ControlPlanTasksGridView<ControlPlanVersionEntityView,ControlPlanTaskView> GridView {get;set;}
    }
    public partial class ControlPlanTasksGridView <ControlPlanVersionEntityView,ControlPlanTaskView> :  RPSGridView<ControlPlanVersionEntityView,ControlPlanTaskView> where ControlPlanVersionEntityView : class, IView where ControlPlanTaskView : class, IView
    {
        public ControlPlanTasksGridView(ControlPlanVersionEntityView currentView,ControlPlanTaskView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDTaskManufacturing = RPSControlFactory.CreateRPSGridComboBox<ControlPlanVersionEntityView>("","#216f1bf8-3ccf-4bdf-a4e1-38aadb2b6aa8 .ag-row[role='row']@ROWINDEX [col-id='cIDTaskManufacturing']","",false, this.CurrentView);
 
            IDTaskProject = RPSControlFactory.CreateRPSGridComboBox<ControlPlanVersionEntityView>("","#216f1bf8-3ccf-4bdf-a4e1-38aadb2b6aa8 .ag-row[role='row']@ROWINDEX [col-id='cIDTaskProject']","",false, this.CurrentView);
 
            IDControlPatternVersion = RPSControlFactory.CreateRPSGridComboBox<ControlPlanVersionEntityView>("","#216f1bf8-3ccf-4bdf-a4e1-38aadb2b6aa8 .ag-row[role='row']@ROWINDEX [col-id='cIDControlPatternVersion']","",false, this.CurrentView);
 
            IDMachineParameterVersion = RPSControlFactory.CreateRPSGridComboBox<ControlPlanVersionEntityView>("","#216f1bf8-3ccf-4bdf-a4e1-38aadb2b6aa8 .ag-row[role='row']@ROWINDEX [col-id='cIDMachineParameterVersion']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ControlPlanVersionEntityView> IDTaskManufacturing { get; set; } 
        public IRPSGridComboBox<ControlPlanVersionEntityView> IDTaskProject { get; set; } 
        public IRPSGridComboBox<ControlPlanVersionEntityView> IDControlPatternVersion { get; set; } 
        public IRPSGridComboBox<ControlPlanVersionEntityView> IDMachineParameterVersion { get; set; } 
                     
    }
 
        public partial class MaterialsWithControlPlanVersionCollectionEditor<ControlPlanVersionEntityView,ControlPlanTaskView>:RPSCollectionEditor<ControlPlanVersionEntityView,ControlPlanTaskView> where ControlPlanVersionEntityView : class, IView where ControlPlanTaskView : class, IView
    {
        public  MaterialsWithControlPlanVersionGridView<ControlPlanVersionEntityView,ControlPlanTaskView> GridView {get;set;}
    }
    public partial class MaterialsWithControlPlanVersionGridView <ControlPlanVersionEntityView,ControlPlanTaskView> :  RPSGridView<ControlPlanVersionEntityView,ControlPlanTaskView> where ControlPlanVersionEntityView : class, IView where ControlPlanTaskView : class, IView
    {
        public MaterialsWithControlPlanVersionGridView(ControlPlanVersionEntityView currentView,ControlPlanTaskView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            UIState = RPSControlFactory.CreateRPSGridTextBox<ControlPlanVersionEntityView>("","#26662ab7-8dbe-48d4-bd57-d3b3fce86d71 .ag-row[role='row']@ROWINDEX [col-id='cUIState']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ControlPlanVersionEntityView> UIState { get; set; } 
                     
    }
 
    }
  
            
    public partial class ControlPlanTaskView : View
    {
        public ControlPlanTaskView(ControlPlanVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ControlPlanTaskView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ControlPlanTaskView,ControlPlanVersionEntityView>( this,Screen.ControlPlanVersionEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ControlPlanTaskView,ControlPlanVersionEntityView>( this,Screen.ControlPlanVersionEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ControlPlanTaskView,ControlPlanVersionEntityView>( this,Screen.ControlPlanVersionEntityView);
 
            IDTaskManufacturing = RPSControlFactory.CreateRPSComboBox<ControlPlanTaskView>("c808e4a6-6348-4a82-9e5f-96df5b114193","","",false, this);
 
            IDTaskProject = RPSControlFactory.CreateRPSComboBox<ControlPlanTaskView>("52a008d0-6e24-4c2c-910b-c3e799e4b8f7","","",false, this);
 
            IDControlPatternVersion = RPSControlFactory.CreateRPSComboBox<ControlPlanTaskView>("87c06e23-6703-4f4e-a555-f1afdfbbcb9c","","",false, this);
 
            IDMachineParameterVersion = RPSControlFactory.CreateRPSComboBox<ControlPlanTaskView>("0f49e69b-3f66-4a16-989e-1021fc1e1923","","",false, this);
 

        }
        public IRPSButton<ControlPlanTaskView> DeleteButton { get; set; } 
        public IRPSButton<ControlPlanTaskView,ControlPlanVersionEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ControlPlanTaskView,ControlPlanVersionEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ControlPlanTaskView,ControlPlanVersionEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ControlPlanTaskView> IDTaskManufacturing { get; set; } 
        public IRPSComboBox<ControlPlanTaskView> IDTaskProject { get; set; } 
        public IRPSComboBox<ControlPlanTaskView> IDControlPatternVersion { get; set; } 
        public IRPSComboBox<ControlPlanTaskView> IDMachineParameterVersion { get; set; } 
        public ControlPlanVersion Screen { get; set; }
        public ControlPlanTaskView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class RejectControlPlanVersionDialogView : View
    {
        public RejectControlPlanVersionDialogView(ControlPlanVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            RejectionDate = RPSControlFactory.CreateRPSTextBox<RejectControlPlanVersionDialogView>("65c9e7c0-f61c-4b81-bd94-15ae4bdcd4c6","","",true, this);
 
            RejectionReason = RPSControlFactory.CreateRPSTextBox<RejectControlPlanVersionDialogView>("378b18d9-82ff-4098-9740-a19ca9d7ebfd","","",true, this);
 

        }
        public IRPSTextBox<RejectControlPlanVersionDialogView> RejectionDate { get; set; } 
        public IRPSTextBox<RejectControlPlanVersionDialogView> RejectionReason { get; set; } 
        public ControlPlanVersion Screen { get; set; }
        public RejectControlPlanVersionDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class RejectionHistoryDialogView : View
    {
        public RejectionHistoryDialogView(ControlPlanVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_GetDocumentRejections = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="23a59e1a-6ef9-48db-bca8-c6dbf54d8894",CSSSelectorGrid="",XPathGrid=""};
            GetDocumentRejections = RPSControlFactory.RPSCreateCollectionWithGrid<GetDocumentRejectionsCollectionEditor<RejectionHistoryDialogView>,RejectionHistoryDialogView>( params_GetDocumentRejections,this);
 

        }
        public GetDocumentRejectionsCollectionEditor<RejectionHistoryDialogView> GetDocumentRejections { get; set; } 
        public ControlPlanVersion Screen { get; set; }
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
            VersionStatusFlow_DoneDate = RPSControlFactory.CreateRPSGridTextBox<RejectionHistoryDialogView>("","#23a59e1a-6ef9-48db-bca8-c6dbf54d8894 .ag-row[role='row']@ROWINDEX [col-id='cVersionStatusFlow_DoneDate']","",false, this.CurrentView);
 
            VersionStatusFlow_RejectionReason = RPSControlFactory.CreateRPSGridMemoTextBox<RejectionHistoryDialogView>("","#23a59e1a-6ef9-48db-bca8-c6dbf54d8894 .ag-row[role='row']@ROWINDEX [col-id='cVersionStatusFlow_RejectionReason']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<RejectionHistoryDialogView> VersionStatusFlow_DoneDate { get; set; } 
        public IRPSGridTextBox<RejectionHistoryDialogView> VersionStatusFlow_RejectionReason { get; set; } 
                     
    }
 
    }
  
            
    public partial class CopyFromOtherControlPlanDialogView : View
    {
        public CopyFromOtherControlPlanDialogView(ControlPlanVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSComboBox<CopyFromOtherControlPlanDialogView>("43129b16-1640-43f0-87c7-258546d80884","","",false, this);
 
            IDStructure = RPSControlFactory.CreateRPSComboBox<CopyFromOtherControlPlanDialogView>("636116ae-d0ed-4bf1-8676-8dd71c97a9a2","","",false, this);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<CopyFromOtherControlPlanDialogView>("1f243789-74dc-47cf-9d55-41a0df799958","","",false, this);
 
            IDControlPlanVersion = RPSControlFactory.CreateRPSComboBox<CopyFromOtherControlPlanDialogView>("47e1ccda-5d46-4008-a701-5ba4576cc7fe","","",true, this);
 

        }
        public IRPSComboBox<CopyFromOtherControlPlanDialogView> IDArticle { get; set; } 
        public IRPSComboBox<CopyFromOtherControlPlanDialogView> IDStructure { get; set; } 
        public IRPSComboBox<CopyFromOtherControlPlanDialogView> IDProject { get; set; } 
        public IRPSComboBox<CopyFromOtherControlPlanDialogView> IDControlPlanVersion { get; set; } 
        public ControlPlanVersion Screen { get; set; }
        public CopyFromOtherControlPlanDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PrintControlPlanVersionOptionsDialogView : View
    {
        public PrintControlPlanVersionOptionsDialogView(ControlPlanVersion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDCustomerPrint = RPSControlFactory.CreateRPSComboBox<PrintControlPlanVersionOptionsDialogView>("ffc8dba9-6e87-4e54-be56-239d98a2e067","","",false, this);
 
            CodLanguagePrint = RPSControlFactory.CreateRPSComboBox<PrintControlPlanVersionOptionsDialogView>("a245d8a4-16a4-4ce9-9fb2-5ef6bda05ac7","","",false, this);
 
            IDRoutePrint = RPSControlFactory.CreateRPSComboBox<PrintControlPlanVersionOptionsDialogView>("23ff72db-0373-4f0b-8c5c-c01f9c643f7a","","",false, this);
 
            optControlPlanReportModel = RPSControlFactory.CreateRPSEnumComboBox<PrintControlPlanVersionOptionsDialogView>("ac60d9cf-b015-4ea5-87f2-2d61beddaa62","","",false, this);
 
            IDControlPlanCustomReport = RPSControlFactory.CreateRPSComboBox<PrintControlPlanVersionOptionsDialogView>("fbcdb6c6-e6bc-42d2-ac4c-5d7d0a03ac41","","",false, this);
 
            UIAddAttachment = RPSControlFactory.CreateRPSCheckBox<PrintControlPlanVersionOptionsDialogView>("d723d936-d6a3-41ab-9824-e524d0913802","","",false, this);
 
            PrintCommandButton = RPSControlFactory.CreateRPSButton<PrintControlPlanVersionOptionsDialogView>( "0a676fed-d476-453a-b205-0c7b9f661738","","",this);
 
            ControlPlanVersionReportByEMailCommandButton = RPSControlFactory.CreateRPSButton<PrintControlPlanVersionOptionsDialogView>( "574e1f00-53b8-4390-ab7d-6c2bd77f4a99","","",this);
 
            EmailClientCommandButton = RPSControlFactory.CreateRPSButton<PrintControlPlanVersionOptionsDialogView>( "28eb8222-761e-4d1e-95ce-fea6cb8f184e","","",this);
 

        }
        public IRPSComboBox<PrintControlPlanVersionOptionsDialogView> IDCustomerPrint { get; set; } 
        public IRPSComboBox<PrintControlPlanVersionOptionsDialogView> CodLanguagePrint { get; set; } 
        public IRPSComboBox<PrintControlPlanVersionOptionsDialogView> IDRoutePrint { get; set; } 
        public IRPSComboBox<PrintControlPlanVersionOptionsDialogView> optControlPlanReportModel { get; set; } 
        public IRPSComboBox<PrintControlPlanVersionOptionsDialogView> IDControlPlanCustomReport { get; set; } 
        public IRPSCheckbox<PrintControlPlanVersionOptionsDialogView> UIAddAttachment { get; set; } 
        public IRPSButton<PrintControlPlanVersionOptionsDialogView> PrintCommandButton { get; set; } 
        public IRPSButton<PrintControlPlanVersionOptionsDialogView> ControlPlanVersionReportByEMailCommandButton { get; set; } 
        public IRPSButton<PrintControlPlanVersionOptionsDialogView> EmailClientCommandButton { get; set; } 
        public ControlPlanVersion Screen { get; set; }
        public PrintControlPlanVersionOptionsDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}