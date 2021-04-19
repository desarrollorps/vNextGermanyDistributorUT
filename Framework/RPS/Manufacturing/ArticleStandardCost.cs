    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.ArticleStandardCost
{
    //RPS VERSION 1.0.0.0
    public partial class ArticleStandardCost:Screen
    {
        public ArticleStandardCost():base()
        {
            this.URL = "manufacturing.articlestandardcost";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ArticleStandardCostVMQueryView  = new ArticleStandardCostVMQueryView(this); 
            ArticleStandardCostVMEntityView  = new ArticleStandardCostVMEntityView(this); 
            RecalculateCostActionDialogView  = new RecalculateCostActionDialogView(this); 
            ArticleStandardCostMachineDetailView  = new ArticleStandardCostMachineDetailView(this); 
            ArticleStandardCostEmployeeDetailView  = new ArticleStandardCostEmployeeDetailView(this); 
            ArticleStandardCostVMQueryView.InitializeControls(); 
            ArticleStandardCostVMEntityView.InitializeControls(); 
            RecalculateCostActionDialogView.InitializeControls(); 
            ArticleStandardCostMachineDetailView.InitializeControls(); 
            ArticleStandardCostEmployeeDetailView.InitializeControls(); 
           
        }
      
            public ArticleStandardCostVMQueryView ArticleStandardCostVMQueryView {get; set; } 
            public ArticleStandardCostVMEntityView ArticleStandardCostVMEntityView {get; set; } 
            public RecalculateCostActionDialogView RecalculateCostActionDialogView {get; set; } 
            public ArticleStandardCostMachineDetailView ArticleStandardCostMachineDetailView {get; set; } 
            public ArticleStandardCostEmployeeDetailView ArticleStandardCostEmployeeDetailView {get; set; } 
    }
            
    public partial class ArticleStandardCostVMQueryView : View
    {
        public ArticleStandardCostVMQueryView(ArticleStandardCost screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ArticleStandardCostVMQueryView,ArticleStandardCostVMEntityView>( this,Screen.ArticleStandardCostVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<ArticleStandardCostVMQueryView>( this);
 
            Article = RPSControlFactory.CreateRPSComboBox<ArticleStandardCostVMQueryView>("dd6bce7e-98f1-4335-aebd-99778639aae5","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<ArticleStandardCostVMQueryView>("e828c5ca-8feb-4245-9c9f-3571b67f4357","","",false, this);
 
            CollectionInit params_ArticleStandardCost = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6b042d5d-318a-4906-8f40-d5b845a66601",CSSSelectorGrid="",XPathGrid=""};
            ArticleStandardCost = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleStandardCostCollectionEditor<ArticleStandardCostVMQueryView,ArticleStandardCostVMEntityView>,ArticleStandardCostVMQueryView,ArticleStandardCostVMEntityView>( params_ArticleStandardCost,this,Screen.ArticleStandardCostVMEntityView);
 

        }
        public IRPSButton<ArticleStandardCostVMQueryView,ArticleStandardCostVMEntityView> NewButton { get; set; } 
        public IRPSButton<ArticleStandardCostVMQueryView> ConsultButton { get; set; } 
        public IRPSComboBox<ArticleStandardCostVMQueryView> Article { get; set; } 
        public IRPSTextBox<ArticleStandardCostVMQueryView> DateFrom { get; set; } 
        public ArticleStandardCostCollectionEditor<ArticleStandardCostVMQueryView,ArticleStandardCostVMEntityView> ArticleStandardCost { get; set; } 
        public ArticleStandardCost Screen { get; set; }
        public ArticleStandardCostVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ArticleStandardCostCollectionEditor<ArticleStandardCostVMQueryView,ArticleStandardCostVMEntityView>:RPSCollectionEditor<ArticleStandardCostVMQueryView,ArticleStandardCostVMEntityView> where ArticleStandardCostVMQueryView : class, IView where ArticleStandardCostVMEntityView : class, IView
    {
        public  ArticleStandardCostGridView<ArticleStandardCostVMQueryView,ArticleStandardCostVMEntityView> GridView {get;set;}
    }
    public partial class ArticleStandardCostGridView <ArticleStandardCostVMQueryView,ArticleStandardCostVMEntityView> :  RPSGridView<ArticleStandardCostVMQueryView,ArticleStandardCostVMEntityView> where ArticleStandardCostVMQueryView : class, IView where ArticleStandardCostVMEntityView : class, IView
    {
        public ArticleStandardCostGridView(ArticleStandardCostVMQueryView currentView,ArticleStandardCostVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ACTIVE_STRUCTURE = RPSControlFactory.CreateRPSGridCheckBox<ArticleStandardCostVMQueryView>("","#6b042d5d-318a-4906-8f40-d5b845a66601 .ag-row[role='row']@ROWINDEX [col-id='cACTIVE_STRUCTURE']","",false, this.CurrentView);
 
            ACTIVE_STRUCTURE_DATE = RPSControlFactory.CreateRPSGridTextBox<ArticleStandardCostVMQueryView>("","#6b042d5d-318a-4906-8f40-d5b845a66601 .ag-row[role='row']@ROWINDEX [col-id='cACTIVE_STRUCTURE_DATE']","",false, this.CurrentView);
 
            ArticleStandardCost_Version = RPSControlFactory.CreateRPSGridTextBox<ArticleStandardCostVMQueryView>("","#6b042d5d-318a-4906-8f40-d5b845a66601 .ag-row[role='row']@ROWINDEX [col-id='cArticleStandardCost_Version']","",false, this.CurrentView);
 
            ArticleStandardCost_DateFrom = RPSControlFactory.CreateRPSGridTextBox<ArticleStandardCostVMQueryView>("","#6b042d5d-318a-4906-8f40-d5b845a66601 .ag-row[role='row']@ROWINDEX [col-id='cArticleStandardCost_DateFrom']","",false, this.CurrentView);
 
            TOTAL_STANDARD = RPSControlFactory.CreateRPSGridFormattedTextBox<ArticleStandardCostVMQueryView>("","#6b042d5d-318a-4906-8f40-d5b845a66601 .ag-row[role='row']@ROWINDEX [col-id='cTOTAL_STANDARD']","",false, this.CurrentView);
 
            TOTAL_LAST = RPSControlFactory.CreateRPSGridFormattedTextBox<ArticleStandardCostVMQueryView>("","#6b042d5d-318a-4906-8f40-d5b845a66601 .ag-row[role='row']@ROWINDEX [col-id='cTOTAL_LAST']","",false, this.CurrentView);
 

        }
        public IRPSGridCheckbox<ArticleStandardCostVMQueryView> ACTIVE_STRUCTURE { get; set; } 
        public IRPSGridTextBox<ArticleStandardCostVMQueryView> ACTIVE_STRUCTURE_DATE { get; set; } 
        public IRPSGridTextBox<ArticleStandardCostVMQueryView> ArticleStandardCost_Version { get; set; } 
        public IRPSGridTextBox<ArticleStandardCostVMQueryView> ArticleStandardCost_DateFrom { get; set; } 
        public IRPSGridTextBox<ArticleStandardCostVMQueryView> TOTAL_STANDARD { get; set; } 
        public IRPSGridTextBox<ArticleStandardCostVMQueryView> TOTAL_LAST { get; set; } 
                     
    }
 
    }
  
            
    public partial class ArticleStandardCostVMEntityView : View
    {
        public ArticleStandardCostVMEntityView(ArticleStandardCost screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ArticleStandardCostVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ArticleStandardCostVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ArticleStandardCostVMEntityView,ArticleStandardCostVMQueryView>( this,Screen.ArticleStandardCostVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<ArticleStandardCostVMEntityView,ArticleStandardCostVMQueryView>( this,Screen.ArticleStandardCostVMQueryView);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<ArticleStandardCostVMEntityView>("e9a570e1-ef61-4870-b064-8560f2f99a54","","",true, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<ArticleStandardCostVMEntityView>("dbc75b86-613c-4eec-bd5a-39f22cdd3e79","","",true, this);
 
            IDRoute = RPSControlFactory.CreateRPSComboBox<ArticleStandardCostVMEntityView>("1c7dac0e-4c35-4937-8389-74ca8b1af47e","","",false, this);
 
            Version = RPSControlFactory.CreateRPSEnumComboBox<ArticleStandardCostVMEntityView>("4f7f4a36-0f41-4645-9a59-144976e23826","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<ArticleStandardCostVMEntityView>("72d6270e-4f0f-4452-8711-4cb3d5f5e089","","",true, this);
 
            StandardMaterialCost = RPSControlFactory.CreateRPSFormattedTextBox<ArticleStandardCostVMEntityView>("75dc3d5d-55f9-4c7d-a027-6ca78a2be249","","",true, this);
 
            StandardEmployeeCost = RPSControlFactory.CreateRPSFormattedTextBox<ArticleStandardCostVMEntityView>("d55c31e7-f14d-4133-a575-423d4a097a76","","",true, this);
 
            StandardMachineCost = RPSControlFactory.CreateRPSFormattedTextBox<ArticleStandardCostVMEntityView>("f476ce9f-b8da-4d2c-bca0-31ef77e94e90","","",true, this);
 
            StandardToolCost = RPSControlFactory.CreateRPSFormattedTextBox<ArticleStandardCostVMEntityView>("1496008c-77b0-4d73-aa07-b118062475d6","","",true, this);
 
            StandardExternalWork = RPSControlFactory.CreateRPSFormattedTextBox<ArticleStandardCostVMEntityView>("5506901f-4f4c-47d1-9148-faeb21764fb6","","",true, this);
 
            StandardOtherCost = RPSControlFactory.CreateRPSFormattedTextBox<ArticleStandardCostVMEntityView>("99a32702-0177-4a28-a946-6929054d7daf","","",true, this);
 
            StandardVariableCost = RPSControlFactory.CreateRPSFormattedTextBox<ArticleStandardCostVMEntityView>("e153904b-990a-466f-8ae1-291cec92dcff","","",true, this);
 
            TotalStandar1 = RPSControlFactory.CreateRPSFormattedTextBox<ArticleStandardCostVMEntityView>("1c1226fd-d7af-425e-911a-15ca81d9e668","","",false, this);
 
            LastMaterialCost = RPSControlFactory.CreateRPSFormattedTextBox<ArticleStandardCostVMEntityView>("05bb85dc-f192-4850-b8ab-a605c7225090","","",true, this);
 
            LastEmployeeCost = RPSControlFactory.CreateRPSFormattedTextBox<ArticleStandardCostVMEntityView>("146db5f5-c27f-4c44-841c-2b47ebc40b85","","",true, this);
 
            LastMachineCost = RPSControlFactory.CreateRPSFormattedTextBox<ArticleStandardCostVMEntityView>("43020532-f31d-4580-a23a-828858f411e1","","",true, this);
 
            LastToolCost = RPSControlFactory.CreateRPSFormattedTextBox<ArticleStandardCostVMEntityView>("6c8cce3e-1efa-42e0-82d9-31af251a0f63","","",true, this);
 
            LastExternalWork = RPSControlFactory.CreateRPSFormattedTextBox<ArticleStandardCostVMEntityView>("95c21fde-ecbf-4062-9d9d-f1f2bb993c88","","",true, this);
 
            LastOtherCost = RPSControlFactory.CreateRPSFormattedTextBox<ArticleStandardCostVMEntityView>("b849e3cf-75cf-4b79-9060-b17c58b9edb1","","",true, this);
 
            LastVariableCost = RPSControlFactory.CreateRPSFormattedTextBox<ArticleStandardCostVMEntityView>("2c9416a1-d0ac-4aa7-a2f1-dbed380b86b2","","",true, this);
 
            TotalLast1 = RPSControlFactory.CreateRPSFormattedTextBox<ArticleStandardCostVMEntityView>("bff46832-5876-46a9-8b98-3d3dce022f5d","","",false, this);
 
            ReportCommandButton = RPSControlFactory.CreateRPSButton<ArticleStandardCostVMEntityView>( "a7bbdd8a-e398-4eb1-a92a-79bd10f1afb1","","",this);
 
            RecalculateCostActionNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ArticleStandardCostVMEntityView,RecalculateCostActionDialogView>("90c5631f-cc16-4b69-8c89-23572bf4dc03","","", this,Screen.RecalculateCostActionDialogView);
 
            CollectionInit params_ArticleStandardCostEmployeeDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="625a021d-97a9-4b8d-a2a2-223df8b53ec4",CSSSelectorGrid="",XPathGrid=""};
            ArticleStandardCostEmployeeDetails = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleStandardCostEmployeeDetailsCollectionEditor<ArticleStandardCostVMEntityView,ArticleStandardCostMachineDetailView>,ArticleStandardCostVMEntityView,ArticleStandardCostMachineDetailView>( params_ArticleStandardCostEmployeeDetails,this,Screen.ArticleStandardCostMachineDetailView);
 
            CollectionInit params_ArticleStandardCostMachineDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="9d13a828-d505-40a8-88e3-c59b201e4f02",CSSSelectorGrid="",XPathGrid=""};
            ArticleStandardCostMachineDetails = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleStandardCostMachineDetailsCollectionEditor<ArticleStandardCostVMEntityView,ArticleStandardCostMachineDetailView>,ArticleStandardCostVMEntityView,ArticleStandardCostMachineDetailView>( params_ArticleStandardCostMachineDetails,this,Screen.ArticleStandardCostMachineDetailView);
 
            SectionCostEmployeeDetail = RPSControlFactory.CreateRPSSection<ArticleStandardCostVMEntityView>( "","ul li[rpsid='8dcd9867-c340-4a0d-b3ad-3ad5957bae43']","",this);
 
            SectionCostMachineDetail = RPSControlFactory.CreateRPSSection<ArticleStandardCostVMEntityView>( "","ul li[rpsid='dcc1dd25-1a7a-412f-9f8f-c9dcf709a7d4']","",this);
 

        }
        public IRPSSaveButton<ArticleStandardCostVMEntityView> SaveButton { get; set; } 
        public IRPSButton<ArticleStandardCostVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<ArticleStandardCostVMEntityView,ArticleStandardCostVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleStandardCostVMEntityView,ArticleStandardCostVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<ArticleStandardCostVMEntityView> IDSite { get; set; } 
        public IRPSComboBox<ArticleStandardCostVMEntityView> IDArticle { get; set; } 
        public IRPSComboBox<ArticleStandardCostVMEntityView> IDRoute { get; set; } 
        public IRPSComboBox<ArticleStandardCostVMEntityView> Version { get; set; } 
        public IRPSTextBox<ArticleStandardCostVMEntityView> DateFrom { get; set; } 
        public IRPSTextBox<ArticleStandardCostVMEntityView> StandardMaterialCost { get; set; } 
        public IRPSTextBox<ArticleStandardCostVMEntityView> StandardEmployeeCost { get; set; } 
        public IRPSTextBox<ArticleStandardCostVMEntityView> StandardMachineCost { get; set; } 
        public IRPSTextBox<ArticleStandardCostVMEntityView> StandardToolCost { get; set; } 
        public IRPSTextBox<ArticleStandardCostVMEntityView> StandardExternalWork { get; set; } 
        public IRPSTextBox<ArticleStandardCostVMEntityView> StandardOtherCost { get; set; } 
        public IRPSTextBox<ArticleStandardCostVMEntityView> StandardVariableCost { get; set; } 
        public IRPSTextBox<ArticleStandardCostVMEntityView> TotalStandar1 { get; set; } 
        public IRPSTextBox<ArticleStandardCostVMEntityView> LastMaterialCost { get; set; } 
        public IRPSTextBox<ArticleStandardCostVMEntityView> LastEmployeeCost { get; set; } 
        public IRPSTextBox<ArticleStandardCostVMEntityView> LastMachineCost { get; set; } 
        public IRPSTextBox<ArticleStandardCostVMEntityView> LastToolCost { get; set; } 
        public IRPSTextBox<ArticleStandardCostVMEntityView> LastExternalWork { get; set; } 
        public IRPSTextBox<ArticleStandardCostVMEntityView> LastOtherCost { get; set; } 
        public IRPSTextBox<ArticleStandardCostVMEntityView> LastVariableCost { get; set; } 
        public IRPSTextBox<ArticleStandardCostVMEntityView> TotalLast1 { get; set; } 
        public IRPSButton<ArticleStandardCostVMEntityView> ReportCommandButton { get; set; } 
        public IRPSButton<ArticleStandardCostVMEntityView,RecalculateCostActionDialogView> RecalculateCostActionNavigationCommandButton { get; set; } 
        public ArticleStandardCostEmployeeDetailsCollectionEditor<ArticleStandardCostVMEntityView,ArticleStandardCostMachineDetailView> ArticleStandardCostEmployeeDetails { get; set; } 
        public ArticleStandardCostMachineDetailsCollectionEditor<ArticleStandardCostVMEntityView,ArticleStandardCostMachineDetailView> ArticleStandardCostMachineDetails { get; set; } 
        public IRPSSection<ArticleStandardCostVMEntityView> SectionCostEmployeeDetail { get; set; } 
        public IRPSSection<ArticleStandardCostVMEntityView> SectionCostMachineDetail { get; set; } 
        public ArticleStandardCost Screen { get; set; }
        public ArticleStandardCostVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ArticleStandardCostEmployeeDetailsCollectionEditor<ArticleStandardCostVMEntityView,ArticleStandardCostMachineDetailView>:RPSCollectionEditor<ArticleStandardCostVMEntityView,ArticleStandardCostMachineDetailView> where ArticleStandardCostVMEntityView : class, IView where ArticleStandardCostMachineDetailView : class, IView
    {
        public  ArticleStandardCostEmployeeDetailsGridView<ArticleStandardCostVMEntityView,ArticleStandardCostMachineDetailView> GridView {get;set;}
    }
    public partial class ArticleStandardCostEmployeeDetailsGridView <ArticleStandardCostVMEntityView,ArticleStandardCostMachineDetailView> :  RPSGridView<ArticleStandardCostVMEntityView,ArticleStandardCostMachineDetailView> where ArticleStandardCostVMEntityView : class, IView where ArticleStandardCostMachineDetailView : class, IView
    {
        public ArticleStandardCostEmployeeDetailsGridView(ArticleStandardCostVMEntityView currentView,ArticleStandardCostMachineDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDCostDetailType = RPSControlFactory.CreateRPSGridComboBox<ArticleStandardCostVMEntityView>("","#625a021d-97a9-4b8d-a2a2-223df8b53ec4 .ag-row[role='row']@ROWINDEX [col-id='cIDCostDetailType']","",true, this.CurrentView);
 
            StandardCost = RPSControlFactory.CreateRPSGridFormattedTextBox<ArticleStandardCostVMEntityView>("","#625a021d-97a9-4b8d-a2a2-223df8b53ec4 .ag-row[role='row']@ROWINDEX [col-id='cStandardCost']","",true, this.CurrentView);
 
            LastCost = RPSControlFactory.CreateRPSGridFormattedTextBox<ArticleStandardCostVMEntityView>("","#625a021d-97a9-4b8d-a2a2-223df8b53ec4 .ag-row[role='row']@ROWINDEX [col-id='cLastCost']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<ArticleStandardCostVMEntityView> IDCostDetailType { get; set; } 
        public IRPSGridTextBox<ArticleStandardCostVMEntityView> StandardCost { get; set; } 
        public IRPSGridTextBox<ArticleStandardCostVMEntityView> LastCost { get; set; } 
                     
    }
 
        public partial class ArticleStandardCostMachineDetailsCollectionEditor<ArticleStandardCostVMEntityView,ArticleStandardCostMachineDetailView>:RPSCollectionEditor<ArticleStandardCostVMEntityView,ArticleStandardCostMachineDetailView> where ArticleStandardCostVMEntityView : class, IView where ArticleStandardCostMachineDetailView : class, IView
    {
        public  ArticleStandardCostMachineDetailsGridView<ArticleStandardCostVMEntityView,ArticleStandardCostMachineDetailView> GridView {get;set;}
    }
    public partial class ArticleStandardCostMachineDetailsGridView <ArticleStandardCostVMEntityView,ArticleStandardCostMachineDetailView> :  RPSGridView<ArticleStandardCostVMEntityView,ArticleStandardCostMachineDetailView> where ArticleStandardCostVMEntityView : class, IView where ArticleStandardCostMachineDetailView : class, IView
    {
        public ArticleStandardCostMachineDetailsGridView(ArticleStandardCostVMEntityView currentView,ArticleStandardCostMachineDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDCostDetailType = RPSControlFactory.CreateRPSGridComboBox<ArticleStandardCostVMEntityView>("","#9d13a828-d505-40a8-88e3-c59b201e4f02 .ag-row[role='row']@ROWINDEX [col-id='cIDCostDetailType']","",true, this.CurrentView);
 
            StandardCost = RPSControlFactory.CreateRPSGridFormattedTextBox<ArticleStandardCostVMEntityView>("","#9d13a828-d505-40a8-88e3-c59b201e4f02 .ag-row[role='row']@ROWINDEX [col-id='cStandardCost']","",true, this.CurrentView);
 
            LastCost = RPSControlFactory.CreateRPSGridFormattedTextBox<ArticleStandardCostVMEntityView>("","#9d13a828-d505-40a8-88e3-c59b201e4f02 .ag-row[role='row']@ROWINDEX [col-id='cLastCost']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<ArticleStandardCostVMEntityView> IDCostDetailType { get; set; } 
        public IRPSGridTextBox<ArticleStandardCostVMEntityView> StandardCost { get; set; } 
        public IRPSGridTextBox<ArticleStandardCostVMEntityView> LastCost { get; set; } 
                     
    }
 
    }
  
            
    public partial class RecalculateCostActionDialogView : View
    {
        public RecalculateCostActionDialogView(ArticleStandardCost screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ckUpdateStandardCost = RPSControlFactory.CreateRPSCheckBox<RecalculateCostActionDialogView>("95b263f7-8fd2-4ad8-b203-b232ef1f2318","","",false, this);
 
            ckPurchaseType = RPSControlFactory.CreateRPSCheckBox<RecalculateCostActionDialogView>("b03dc3d1-1599-4cc9-9d0c-901066986a08","","",false, this);
 
            ckUpdatePriceArticle = RPSControlFactory.CreateRPSCheckBox<RecalculateCostActionDialogView>("09b71099-aa1d-4a08-845a-911c514354e0","","",false, this);
 
            ckUpdateProjectMaterialTheoricCost = RPSControlFactory.CreateRPSCheckBox<RecalculateCostActionDialogView>("a16034c4-fe7e-4698-a8b5-b46f8cd98bdf","","",false, this);
 
            ckSaveCostToDate = RPSControlFactory.CreateRPSCheckBox<RecalculateCostActionDialogView>("693c646e-c142-45ab-b3c2-777e82a5b3ee","","",false, this);
 
            ckSimulation = RPSControlFactory.CreateRPSCheckBox<RecalculateCostActionDialogView>("6941c762-8578-47b1-80ef-c9e87ae398a4","","",false, this);
 
            ckPropagateRoutes = RPSControlFactory.CreateRPSCheckBox<RecalculateCostActionDialogView>("55469fbe-1004-4eb4-bee2-debfbd0aeded","","",false, this);
 

        }
        public IRPSCheckbox<RecalculateCostActionDialogView> ckUpdateStandardCost { get; set; } 
        public IRPSCheckbox<RecalculateCostActionDialogView> ckPurchaseType { get; set; } 
        public IRPSCheckbox<RecalculateCostActionDialogView> ckUpdatePriceArticle { get; set; } 
        public IRPSCheckbox<RecalculateCostActionDialogView> ckUpdateProjectMaterialTheoricCost { get; set; } 
        public IRPSCheckbox<RecalculateCostActionDialogView> ckSaveCostToDate { get; set; } 
        public IRPSCheckbox<RecalculateCostActionDialogView> ckSimulation { get; set; } 
        public IRPSCheckbox<RecalculateCostActionDialogView> ckPropagateRoutes { get; set; } 
        public ArticleStandardCost Screen { get; set; }
        public RecalculateCostActionDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ArticleStandardCostMachineDetailView : View
    {
        public ArticleStandardCostMachineDetailView(ArticleStandardCost screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ArticleStandardCostMachineDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ArticleStandardCostMachineDetailView,ArticleStandardCostVMEntityView>( this,Screen.ArticleStandardCostVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ArticleStandardCostMachineDetailView,ArticleStandardCostVMEntityView>( this,Screen.ArticleStandardCostVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ArticleStandardCostMachineDetailView,ArticleStandardCostVMEntityView>( this,Screen.ArticleStandardCostVMEntityView);
 
            IDCostDetailType = RPSControlFactory.CreateRPSComboBox<ArticleStandardCostMachineDetailView>("d96e403c-4ee9-4784-bacc-0b9182030817","","",true, this);
 
            StandardCost = RPSControlFactory.CreateRPSFormattedTextBox<ArticleStandardCostMachineDetailView>("9bdc2ca7-f60c-4b71-bc04-9e25d391ae4a","","",true, this);
 
            LastCost = RPSControlFactory.CreateRPSFormattedTextBox<ArticleStandardCostMachineDetailView>("e5fd6dc6-0dfa-4db0-b315-72a37c930de9","","",true, this);
 

        }
        public IRPSButton<ArticleStandardCostMachineDetailView> DeleteButton { get; set; } 
        public IRPSButton<ArticleStandardCostMachineDetailView,ArticleStandardCostVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleStandardCostMachineDetailView,ArticleStandardCostVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ArticleStandardCostMachineDetailView,ArticleStandardCostVMEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ArticleStandardCostMachineDetailView> IDCostDetailType { get; set; } 
        public IRPSTextBox<ArticleStandardCostMachineDetailView> StandardCost { get; set; } 
        public IRPSTextBox<ArticleStandardCostMachineDetailView> LastCost { get; set; } 
        public ArticleStandardCost Screen { get; set; }
        public ArticleStandardCostMachineDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ArticleStandardCostEmployeeDetailView : View
    {
        public ArticleStandardCostEmployeeDetailView(ArticleStandardCost screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ArticleStandardCostEmployeeDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ArticleStandardCostEmployeeDetailView,ArticleStandardCostVMEntityView>( this,Screen.ArticleStandardCostVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ArticleStandardCostEmployeeDetailView,ArticleStandardCostVMEntityView>( this,Screen.ArticleStandardCostVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ArticleStandardCostEmployeeDetailView,ArticleStandardCostVMEntityView>( this,Screen.ArticleStandardCostVMEntityView);
 
            IDCostDetailType = RPSControlFactory.CreateRPSComboBox<ArticleStandardCostEmployeeDetailView>("3b316537-70f9-4ba9-aa59-432855f31261","","",true, this);
 
            StandardCost = RPSControlFactory.CreateRPSFormattedTextBox<ArticleStandardCostEmployeeDetailView>("01504e3f-d1fb-418d-83f7-809d6c84abb9","","",true, this);
 
            LastCost = RPSControlFactory.CreateRPSFormattedTextBox<ArticleStandardCostEmployeeDetailView>("9eaa86b1-694c-4176-aa84-bda639957c45","","",true, this);
 

        }
        public IRPSButton<ArticleStandardCostEmployeeDetailView> DeleteButton { get; set; } 
        public IRPSButton<ArticleStandardCostEmployeeDetailView,ArticleStandardCostVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ArticleStandardCostEmployeeDetailView,ArticleStandardCostVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ArticleStandardCostEmployeeDetailView,ArticleStandardCostVMEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<ArticleStandardCostEmployeeDetailView> IDCostDetailType { get; set; } 
        public IRPSTextBox<ArticleStandardCostEmployeeDetailView> StandardCost { get; set; } 
        public IRPSTextBox<ArticleStandardCostEmployeeDetailView> LastCost { get; set; } 
        public ArticleStandardCost Screen { get; set; }
        public ArticleStandardCostEmployeeDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}