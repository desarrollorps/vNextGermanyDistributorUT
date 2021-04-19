    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.SalesCRM.QuotationSL
{
    //RPS VERSION 1.0.0.0
    public partial class QuotationSL:Screen
    {
        public QuotationSL():base()
        {
            this.URL = "salescrm.quotationsl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            QuotationSLCollectionView  = new QuotationSLCollectionView(this); 
            QuotationSLEntityView  = new QuotationSLEntityView(this); 
            QuotationMaterialSLView  = new QuotationMaterialSLView(this); 
            QuotationTaskSLView  = new QuotationTaskSLView(this); 
            QuotationResourceSLView  = new QuotationResourceSLView(this); 
            QuotationOtherCostSLView  = new QuotationOtherCostSLView(this); 
            QuotationOverChargeSLView  = new QuotationOverChargeSLView(this); 
            QuotationCopyDialogView  = new QuotationCopyDialogView(this); 
            QuotationCreateArticleDialogView  = new QuotationCreateArticleDialogView(this); 
            QuotationCreateStructureDialogView  = new QuotationCreateStructureDialogView(this); 
            QuotationRelatedSalesQuotesDialogView  = new QuotationRelatedSalesQuotesDialogView(this); 
            QuotationFromStructureDialogView  = new QuotationFromStructureDialogView(this); 
            QuotationFeatureSLView  = new QuotationFeatureSLView(this); 
            QuotationAddUsualTaskDialogView  = new QuotationAddUsualTaskDialogView(this); 
            NewChildDialogView  = new NewChildDialogView(this); 
            NewFromOpportunityDialogView  = new NewFromOpportunityDialogView(this); 
            QuotationMaterialLotSLView  = new QuotationMaterialLotSLView(this); 
            QuotationMaterialLotChildDialogView  = new QuotationMaterialLotChildDialogView(this); 
            QuotationTaskLotChildDialogView  = new QuotationTaskLotChildDialogView(this); 
            QuotationTaskLotSLView  = new QuotationTaskLotSLView(this); 
            QuotationResourceLotChildDialogView  = new QuotationResourceLotChildDialogView(this); 
            QuotationResourceLotSLView  = new QuotationResourceLotSLView(this); 
            NewSupplierRQChildDialogView  = new NewSupplierRQChildDialogView(this); 
            NewSupplierRQFromTaskChildDialogView  = new NewSupplierRQFromTaskChildDialogView(this); 
            CuDistDetailOfMaterialsPopUpDialogView  = new CuDistDetailOfMaterialsPopUpDialogView(this); 
            QuotationSLCollectionView.InitializeControls(); 
            QuotationSLEntityView.InitializeControls(); 
            QuotationMaterialSLView.InitializeControls(); 
            QuotationTaskSLView.InitializeControls(); 
            QuotationResourceSLView.InitializeControls(); 
            QuotationOtherCostSLView.InitializeControls(); 
            QuotationOverChargeSLView.InitializeControls(); 
            QuotationCopyDialogView.InitializeControls(); 
            QuotationCreateArticleDialogView.InitializeControls(); 
            QuotationCreateStructureDialogView.InitializeControls(); 
            QuotationRelatedSalesQuotesDialogView.InitializeControls(); 
            QuotationFromStructureDialogView.InitializeControls(); 
            QuotationFeatureSLView.InitializeControls(); 
            QuotationAddUsualTaskDialogView.InitializeControls(); 
            NewChildDialogView.InitializeControls(); 
            NewFromOpportunityDialogView.InitializeControls(); 
            QuotationMaterialLotSLView.InitializeControls(); 
            QuotationMaterialLotChildDialogView.InitializeControls(); 
            QuotationTaskLotChildDialogView.InitializeControls(); 
            QuotationTaskLotSLView.InitializeControls(); 
            QuotationResourceLotChildDialogView.InitializeControls(); 
            QuotationResourceLotSLView.InitializeControls(); 
            NewSupplierRQChildDialogView.InitializeControls(); 
            NewSupplierRQFromTaskChildDialogView.InitializeControls(); 
            CuDistDetailOfMaterialsPopUpDialogView.InitializeControls(); 
           
        }
      
            public QuotationSLCollectionView QuotationSLCollectionView {get; set; } 
            public QuotationSLEntityView QuotationSLEntityView {get; set; } 
            public QuotationMaterialSLView QuotationMaterialSLView {get; set; } 
            public QuotationTaskSLView QuotationTaskSLView {get; set; } 
            public QuotationResourceSLView QuotationResourceSLView {get; set; } 
            public QuotationOtherCostSLView QuotationOtherCostSLView {get; set; } 
            public QuotationOverChargeSLView QuotationOverChargeSLView {get; set; } 
            public QuotationCopyDialogView QuotationCopyDialogView {get; set; } 
            public QuotationCreateArticleDialogView QuotationCreateArticleDialogView {get; set; } 
            public QuotationCreateStructureDialogView QuotationCreateStructureDialogView {get; set; } 
            public QuotationRelatedSalesQuotesDialogView QuotationRelatedSalesQuotesDialogView {get; set; } 
            public QuotationFromStructureDialogView QuotationFromStructureDialogView {get; set; } 
            public QuotationFeatureSLView QuotationFeatureSLView {get; set; } 
            public QuotationAddUsualTaskDialogView QuotationAddUsualTaskDialogView {get; set; } 
            public NewChildDialogView NewChildDialogView {get; set; } 
            public NewFromOpportunityDialogView NewFromOpportunityDialogView {get; set; } 
            public QuotationMaterialLotSLView QuotationMaterialLotSLView {get; set; } 
            public QuotationMaterialLotChildDialogView QuotationMaterialLotChildDialogView {get; set; } 
            public QuotationTaskLotChildDialogView QuotationTaskLotChildDialogView {get; set; } 
            public QuotationTaskLotSLView QuotationTaskLotSLView {get; set; } 
            public QuotationResourceLotChildDialogView QuotationResourceLotChildDialogView {get; set; } 
            public QuotationResourceLotSLView QuotationResourceLotSLView {get; set; } 
            public NewSupplierRQChildDialogView NewSupplierRQChildDialogView {get; set; } 
            public NewSupplierRQFromTaskChildDialogView NewSupplierRQFromTaskChildDialogView {get; set; } 
            public CuDistDetailOfMaterialsPopUpDialogView CuDistDetailOfMaterialsPopUpDialogView {get; set; } 
    }
            
    public partial class QuotationSLCollectionView : View
    {
        public QuotationSLCollectionView(QuotationSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<QuotationSLCollectionView,QuotationSLEntityView>( this,Screen.QuotationSLEntityView);
 
            NewChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<QuotationSLCollectionView,NewChildDialogView>("57df47bc-e78c-4251-a804-5ac0476c7c90","","", this,Screen.NewChildDialogView);
 
            QuotationFromStructureNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<QuotationSLCollectionView,QuotationFromStructureDialogView>("cfb6a9ee-3b44-4ed4-b085-a61e055a24a6","","", this,Screen.QuotationFromStructureDialogView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "2871548d-c26c-4162-a54e-8766c6fa1c6b",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<QuotationSLCollectionView,QuotationSLEntityView>( params_MainConsult,this,Screen.QuotationSLEntityView);
 

        }
        public IRPSButton<QuotationSLCollectionView,QuotationSLEntityView> NewButton { get; set; } 
        public IRPSButton<QuotationSLCollectionView,NewChildDialogView> NewChildNavigationCommandButton { get; set; } 
        public IRPSButton<QuotationSLCollectionView,QuotationFromStructureDialogView> QuotationFromStructureNavigationCommandButton { get; set; } 
        public IRPSCollectionEditor<QuotationSLCollectionView,QuotationSLEntityView> MainConsult { get; set; } 
        public QuotationSL Screen { get; set; }
        public QuotationSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class QuotationSLEntityView : View
    {
        public QuotationSLEntityView(QuotationSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<QuotationSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<QuotationSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<QuotationSLEntityView,QuotationSLCollectionView>( this,Screen.QuotationSLCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<QuotationSLEntityView,QuotationSLCollectionView>( this,Screen.QuotationSLCollectionView);
 
            CodQuotation = RPSControlFactory.CreateRPSTextBox<QuotationSLEntityView>("6798782c-c031-4b8b-9c40-afea306dc411","","",true, this);
 
            QuotationDate = RPSControlFactory.CreateRPSTextBox<QuotationSLEntityView>("4a5d23fb-d209-4b85-969a-c185da556da3","","",true, this);
 
            ArticleGenerate = RPSControlFactory.CreateRPSCheckBox<QuotationSLEntityView>("dd5e5c99-9a94-4774-a757-fc9a7095b268","","",true, this);
 
            StructureGenerate = RPSControlFactory.CreateRPSCheckBox<QuotationSLEntityView>("666fcb64-5734-4cd7-8377-659178a2d05b","","",true, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<QuotationSLEntityView>("24907108-415f-4cd4-a65a-6b0a4fde6189","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<QuotationSLEntityView>("a7eefff1-ebcb-4da2-8deb-cdf3efb813cd","","",false, this);
 
            IDArticleOld = RPSControlFactory.CreateRPSComboBox<QuotationSLEntityView>("26ab5877-d483-4941-b37d-a75e070434ca","","",false, this);
 
            IDOportunity = RPSControlFactory.CreateRPSComboBox<QuotationSLEntityView>("88721abe-0922-4175-94c6-bcd2fd86536a","","",false, this);
 
            PlanNumber = RPSControlFactory.CreateRPSTextBox<QuotationSLEntityView>("f0759dfd-3bba-4088-ae01-41cc1b52ec34","","",false, this);
 
            ReferenceCustomer = RPSControlFactory.CreateRPSTextBox<QuotationSLEntityView>("b1462342-835e-4bea-aebe-cc7c7f1a391b","","",false, this);
 
            Customer = RPSControlFactory.CreateRPSOption<QuotationSLEntityView>( "95561d76-cec7-42b3-a6b7-93b05ed3664c","","",this);
 
            PotentialCustomer = RPSControlFactory.CreateRPSOption<QuotationSLEntityView>( "1199c75b-9c3d-4c2a-91b6-a58752ab03de","","",this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<QuotationSLEntityView>("3cbd73e7-8cbb-479e-9e94-7a7ad8fe013c","","",false, this);
 
            IDPotentialCustomer = RPSControlFactory.CreateRPSComboBox<QuotationSLEntityView>("6f44daea-b91f-4de4-a6cc-4044c3f007a9","","",false, this);
 
            IDCustomerMiscellaneous = RPSControlFactory.CreateRPSComboBox<QuotationSLEntityView>("98ceb642-6884-45ad-8cb4-eba482e14bc1","","",false, this);
 
            TotalMaterialCost = RPSControlFactory.CreateRPSFormattedTextBox<QuotationSLEntityView>("801331b5-15c4-4283-8131-1360b5d6113c","","",false, this);
 
            TotalMaterialOverCost = RPSControlFactory.CreateRPSFormattedTextBox<QuotationSLEntityView>("604b1be8-05a0-4e9a-9d22-5533252da1fd","","",false, this);
 
            TotalResourceCost = RPSControlFactory.CreateRPSFormattedTextBox<QuotationSLEntityView>("8b1af0f5-2b74-4515-85dc-66416637364c","","",false, this);
 
            TotalResourceOverCost = RPSControlFactory.CreateRPSFormattedTextBox<QuotationSLEntityView>("af13ac7f-7989-4c6a-bfca-3ce87a225a11","","",false, this);
 
            TotalOtherCost = RPSControlFactory.CreateRPSFormattedTextBox<QuotationSLEntityView>("d6995c6e-dcee-44bc-a131-2185af47f82e","","",false, this);
 
            TotalOtherOverCost = RPSControlFactory.CreateRPSFormattedTextBox<QuotationSLEntityView>("95df346e-279b-4ad0-9aae-68d1a0ce4666","","",false, this);
 
            GeneralOverCost = RPSControlFactory.CreateRPSFormattedTextBox<QuotationSLEntityView>("ccd38f53-cb43-45a1-b40a-687bb314c9ac","","",false, this);
 
            TotalCost = RPSControlFactory.CreateRPSFormattedTextBox<QuotationSLEntityView>("ea6785fd-e32b-40ac-9d53-a28e7c091977","","",false, this);
 
            TotalSalesPrice = RPSControlFactory.CreateRPSFormattedTextBox<QuotationSLEntityView>("78c6efac-7dfb-4bd1-8f38-b9e0d9dad729","","",false, this);
 
            NewSupplierRQChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<QuotationSLEntityView,NewSupplierRQChildDialogView>("1de0e73f-c8ee-40c3-b32c-3e17775aa064","","", this,Screen.NewSupplierRQChildDialogView);
 
            NewSupplierRQFromTaskChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<QuotationSLEntityView,NewSupplierRQFromTaskChildDialogView>("f6578d61-fdef-41f3-a18e-3d4a6b55e3ca","","", this,Screen.NewSupplierRQFromTaskChildDialogView);
 
            Comment = RPSControlFactory.CreateRPSTextBox<QuotationSLEntityView>("d1127905-e2f1-4a22-87be-5f1c6c4ef5f5","","",false, this);
 
            TechnicalDescription = RPSControlFactory.CreateRPSTextBox<QuotationSLEntityView>("5536fc71-bd98-4467-9bd6-4e1725e55d7b","","",false, this);
 
            QuotationCopyNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<QuotationSLEntityView,QuotationCopyDialogView>("a74da30a-581e-42aa-b09c-78976752b279","","", this,Screen.QuotationCopyDialogView);
 
            ExecuteRecalculateCostsButton = RPSControlFactory.CreateRPSButton<QuotationSLEntityView>( "2875cf96-086b-4670-af0e-c4ac6345e93c","","",this);
 
            QuotationCreateArticleGenericButton = RPSControlFactory.CreateRPSButton<QuotationSLEntityView>( "686b6284-6a61-460b-b0a1-6bd2416e95b0","","",this);
 
            QuotationCreateStructureBeforeCommandButton = RPSControlFactory.CreateRPSButton<QuotationSLEntityView>( "bb6f524e-9ec3-4181-8d1b-2eabb097772a","","",this);
 
            QuotationRelatedSalesQuotesNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<QuotationSLEntityView,QuotationRelatedSalesQuotesDialogView>("07db7c02-eb50-42d8-9ee2-8b2e935cd32f","","", this,Screen.QuotationRelatedSalesQuotesDialogView);
 
            LinkNavigationCommandButton = RPSControlFactory.CreateRPSButton<QuotationSLEntityView>( "132ac526-a03f-4fbd-9067-75856be43e46","","",this);
 
            QuotationAddUsualTaskNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<QuotationSLEntityView,QuotationAddUsualTaskDialogView>("a2852f3b-6e64-472e-8a25-8b8a3fbd222d","","", this,Screen.QuotationAddUsualTaskDialogView);
 
            CuDistDetailOfMaterialsPopUpNavigationCommandButton = RPSControlFactory.CreateRPSButton<QuotationSLEntityView>( "d29659d4-82f2-4850-8cf7-a48309fef0ed","","",this);
 
            ExecuteInsertQuotationLotsButton = RPSControlFactory.CreateRPSButton<QuotationSLEntityView>( "ce84e80b-e3b0-4870-8191-29c7b26b66b7","","",this);
 
            CollectionInit params_QuotationLotDefaultSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="243a3af8-92d6-4d97-b566-820ae88d3b4b",CSSSelectorGrid="",XPathGrid=""};
            QuotationLotDefaultSLs = RPSControlFactory.RPSCreateCollectionWithGrid<QuotationLotDefaultSLsCollectionEditor<QuotationSLEntityView,QuotationTaskSLView>,QuotationSLEntityView,QuotationTaskSLView>( params_QuotationLotDefaultSLs,this,Screen.QuotationTaskSLView);
 
            CollectionInit params_QuotationLotSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="60793fe9-33d5-4f9f-8241-4432d7465d21",CSSSelectorGrid="",XPathGrid=""};
            QuotationLotSLs = RPSControlFactory.RPSCreateCollectionWithGrid<QuotationLotSLsCollectionEditor<QuotationSLEntityView,QuotationTaskSLView>,QuotationSLEntityView,QuotationTaskSLView>( params_QuotationLotSLs,this,Screen.QuotationTaskSLView);
 
            CollectionInit params_QuotationMaterialSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c6ac5986-d700-4330-a39b-e21fed9903e2",CSSSelectorGrid="",XPathGrid=""};
            QuotationMaterialSLs = RPSControlFactory.RPSCreateCollectionWithGrid<QuotationMaterialSLsCollectionEditor<QuotationSLEntityView,QuotationTaskSLView>,QuotationSLEntityView,QuotationTaskSLView>( params_QuotationMaterialSLs,this,Screen.QuotationTaskSLView);
 
            CollectionInit params_QuotationTaskSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4e91132c-0a62-4503-9cab-e3f9980eb4d0",CSSSelectorGrid="",XPathGrid=""};
            QuotationTaskSLs = RPSControlFactory.RPSCreateCollectionWithGrid<QuotationTaskSLsCollectionEditor<QuotationSLEntityView,QuotationTaskSLView>,QuotationSLEntityView,QuotationTaskSLView>( params_QuotationTaskSLs,this,Screen.QuotationTaskSLView);
 
            CollectionInit params_QuotationResourceSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="66fdd10a-00db-4fdc-a9cc-632e927ed9a2",CSSSelectorGrid="",XPathGrid=""};
            QuotationResourceSLs = RPSControlFactory.RPSCreateCollectionWithGrid<QuotationResourceSLsCollectionEditor<QuotationSLEntityView,QuotationTaskSLView>,QuotationSLEntityView,QuotationTaskSLView>( params_QuotationResourceSLs,this,Screen.QuotationTaskSLView);
 
            CollectionInit params_QuotationOtherCostSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4448ab1c-0769-44bf-b0da-06c51677b08f",CSSSelectorGrid="",XPathGrid=""};
            QuotationOtherCostSLs = RPSControlFactory.RPSCreateCollectionWithGrid<QuotationOtherCostSLsCollectionEditor<QuotationSLEntityView,QuotationTaskSLView>,QuotationSLEntityView,QuotationTaskSLView>( params_QuotationOtherCostSLs,this,Screen.QuotationTaskSLView);
 
            CollectionInit params_QuotationOverChargeSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d40c41b1-0f3d-44dd-9816-f042bb3a1eba",CSSSelectorGrid="",XPathGrid=""};
            QuotationOverChargeSLs = RPSControlFactory.RPSCreateCollectionWithGrid<QuotationOverChargeSLsCollectionEditor<QuotationSLEntityView,QuotationTaskSLView>,QuotationSLEntityView,QuotationTaskSLView>( params_QuotationOverChargeSLs,this,Screen.QuotationTaskSLView);
 
            CollectionInit params_QuotationFeatures = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="16f5b6b8-5f70-494e-a028-456a18f01ab4",CSSSelectorGrid="",XPathGrid=""};
            QuotationFeatures = RPSControlFactory.RPSCreateCollectionWithGrid<QuotationFeaturesCollectionEditor<QuotationSLEntityView,QuotationTaskSLView>,QuotationSLEntityView,QuotationTaskSLView>( params_QuotationFeatures,this,Screen.QuotationTaskSLView);
 
            Material = RPSControlFactory.CreateRPSSection<QuotationSLEntityView>( "","ul li[rpsid='91de07ec-a25a-4fb5-8d29-273344c544e9']","",this);
 
            Task = RPSControlFactory.CreateRPSSection<QuotationSLEntityView>( "","ul li[rpsid='e39d426d-4992-4053-8df2-752a15705ac4']","",this);
 
            Resources = RPSControlFactory.CreateRPSSection<QuotationSLEntityView>( "","ul li[rpsid='8db927d4-091b-42d5-981d-2e97daef361a']","",this);
 
            OtherCosts = RPSControlFactory.CreateRPSSection<QuotationSLEntityView>( "","ul li[rpsid='26397f01-daaf-4305-9c88-df7a248f2371']","",this);
 
            OverCosts = RPSControlFactory.CreateRPSSection<QuotationSLEntityView>( "","ul li[rpsid='03420ca2-5367-489d-af70-9974df5a743e']","",this);
 
            Features = RPSControlFactory.CreateRPSSection<QuotationSLEntityView>( "","ul li[rpsid='4b4911e5-c98c-44a1-9da3-7b484a4f3a73']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<QuotationSLEntityView>( "","ul li[rpsid='7872b2cf-c162-4595-ad94-f3205cc80330']","",this);
 
            TechnicalDescription1 = RPSControlFactory.CreateRPSSection<QuotationSLEntityView>( "","ul li[rpsid='f4aa336e-7368-47c3-8dfe-ada81291234b']","",this);
 

        }
        public IRPSSaveButton<QuotationSLEntityView> SaveButton { get; set; } 
        public IRPSButton<QuotationSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<QuotationSLEntityView,QuotationSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<QuotationSLEntityView,QuotationSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<QuotationSLEntityView> CodQuotation { get; set; } 
        public IRPSTextBox<QuotationSLEntityView> QuotationDate { get; set; } 
        public IRPSCheckbox<QuotationSLEntityView> ArticleGenerate { get; set; } 
        public IRPSCheckbox<QuotationSLEntityView> StructureGenerate { get; set; } 
        public IRPSComboBox<QuotationSLEntityView> IDArticle { get; set; } 
        public IRPSTextBox<QuotationSLEntityView> Description { get; set; } 
        public IRPSComboBox<QuotationSLEntityView> IDArticleOld { get; set; } 
        public IRPSComboBox<QuotationSLEntityView> IDOportunity { get; set; } 
        public IRPSTextBox<QuotationSLEntityView> PlanNumber { get; set; } 
        public IRPSTextBox<QuotationSLEntityView> ReferenceCustomer { get; set; } 
        public IRPSOption<QuotationSLEntityView> Customer { get; set; } 
        public IRPSOption<QuotationSLEntityView> PotentialCustomer { get; set; } 
        public IRPSComboBox<QuotationSLEntityView> IDCustomer { get; set; } 
        public IRPSComboBox<QuotationSLEntityView> IDPotentialCustomer { get; set; } 
        public IRPSComboBox<QuotationSLEntityView> IDCustomerMiscellaneous { get; set; } 
        public IRPSTextBox<QuotationSLEntityView> TotalMaterialCost { get; set; } 
        public IRPSTextBox<QuotationSLEntityView> TotalMaterialOverCost { get; set; } 
        public IRPSTextBox<QuotationSLEntityView> TotalResourceCost { get; set; } 
        public IRPSTextBox<QuotationSLEntityView> TotalResourceOverCost { get; set; } 
        public IRPSTextBox<QuotationSLEntityView> TotalOtherCost { get; set; } 
        public IRPSTextBox<QuotationSLEntityView> TotalOtherOverCost { get; set; } 
        public IRPSTextBox<QuotationSLEntityView> GeneralOverCost { get; set; } 
        public IRPSTextBox<QuotationSLEntityView> TotalCost { get; set; } 
        public IRPSTextBox<QuotationSLEntityView> TotalSalesPrice { get; set; } 
        public IRPSButton<QuotationSLEntityView,NewSupplierRQChildDialogView> NewSupplierRQChildNavigationCommandButton { get; set; } 
        public IRPSButton<QuotationSLEntityView,NewSupplierRQFromTaskChildDialogView> NewSupplierRQFromTaskChildNavigationCommandButton { get; set; } 
        public IRPSTextBox<QuotationSLEntityView> Comment { get; set; } 
        public IRPSTextBox<QuotationSLEntityView> TechnicalDescription { get; set; } 
        public IRPSButton<QuotationSLEntityView,QuotationCopyDialogView> QuotationCopyNavigationCommandButton { get; set; } 
        public IRPSButton<QuotationSLEntityView> ExecuteRecalculateCostsButton { get; set; } 
        public IRPSButton<QuotationSLEntityView> QuotationCreateArticleGenericButton { get; set; } 
        public IRPSButton<QuotationSLEntityView> QuotationCreateStructureBeforeCommandButton { get; set; } 
        public IRPSButton<QuotationSLEntityView,QuotationRelatedSalesQuotesDialogView> QuotationRelatedSalesQuotesNavigationCommandButton { get; set; } 
        public IRPSButton<QuotationSLEntityView> LinkNavigationCommandButton { get; set; } 
        public IRPSButton<QuotationSLEntityView,QuotationAddUsualTaskDialogView> QuotationAddUsualTaskNavigationCommandButton { get; set; } 
        public IRPSButton<QuotationSLEntityView> CuDistDetailOfMaterialsPopUpNavigationCommandButton { get; set; } 
        public IRPSButton<QuotationSLEntityView> ExecuteInsertQuotationLotsButton { get; set; } 
        public QuotationLotDefaultSLsCollectionEditor<QuotationSLEntityView,QuotationTaskSLView> QuotationLotDefaultSLs { get; set; } 
        public QuotationLotSLsCollectionEditor<QuotationSLEntityView,QuotationTaskSLView> QuotationLotSLs { get; set; } 
        public QuotationMaterialSLsCollectionEditor<QuotationSLEntityView,QuotationTaskSLView> QuotationMaterialSLs { get; set; } 
        public QuotationTaskSLsCollectionEditor<QuotationSLEntityView,QuotationTaskSLView> QuotationTaskSLs { get; set; } 
        public QuotationResourceSLsCollectionEditor<QuotationSLEntityView,QuotationTaskSLView> QuotationResourceSLs { get; set; } 
        public QuotationOtherCostSLsCollectionEditor<QuotationSLEntityView,QuotationTaskSLView> QuotationOtherCostSLs { get; set; } 
        public QuotationOverChargeSLsCollectionEditor<QuotationSLEntityView,QuotationTaskSLView> QuotationOverChargeSLs { get; set; } 
        public QuotationFeaturesCollectionEditor<QuotationSLEntityView,QuotationTaskSLView> QuotationFeatures { get; set; } 
        public IRPSSection<QuotationSLEntityView> Material { get; set; } 
        public IRPSSection<QuotationSLEntityView> Task { get; set; } 
        public IRPSSection<QuotationSLEntityView> Resources { get; set; } 
        public IRPSSection<QuotationSLEntityView> OtherCosts { get; set; } 
        public IRPSSection<QuotationSLEntityView> OverCosts { get; set; } 
        public IRPSSection<QuotationSLEntityView> Features { get; set; } 
        public IRPSSection<QuotationSLEntityView> Comments { get; set; } 
        public IRPSSection<QuotationSLEntityView> TechnicalDescription1 { get; set; } 
        public QuotationSL Screen { get; set; }
        public QuotationSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class QuotationLotDefaultSLsCollectionEditor<QuotationSLEntityView,QuotationTaskSLView>:RPSCollectionEditor<QuotationSLEntityView,QuotationTaskSLView> where QuotationSLEntityView : class, IView where QuotationTaskSLView : class, IView
    {
        public  QuotationLotDefaultSLsGridView<QuotationSLEntityView,QuotationTaskSLView> GridView {get;set;}
    }
    public partial class QuotationLotDefaultSLsGridView <QuotationSLEntityView,QuotationTaskSLView> :  RPSGridView<QuotationSLEntityView,QuotationTaskSLView> where QuotationSLEntityView : class, IView where QuotationTaskSLView : class, IView
    {
        public QuotationLotDefaultSLsGridView(QuotationSLEntityView currentView,QuotationTaskSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationSLEntityView>("","#243a3af8-92d6-4d97-b566-820ae88d3b4b .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<QuotationSLEntityView> Quantity { get; set; } 
                     
    }
 
        public partial class QuotationLotSLsCollectionEditor<QuotationSLEntityView,QuotationTaskSLView>:RPSCollectionEditor<QuotationSLEntityView,QuotationTaskSLView> where QuotationSLEntityView : class, IView where QuotationTaskSLView : class, IView
    {
        public  QuotationLotSLsGridView<QuotationSLEntityView,QuotationTaskSLView> GridView {get;set;}
    }
    public partial class QuotationLotSLsGridView <QuotationSLEntityView,QuotationTaskSLView> :  RPSGridView<QuotationSLEntityView,QuotationTaskSLView> where QuotationSLEntityView : class, IView where QuotationTaskSLView : class, IView
    {
        public QuotationLotSLsGridView(QuotationSLEntityView currentView,QuotationTaskSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationSLEntityView>("","#60793fe9-33d5-4f9f-8241-4432d7465d21 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            SalesPrice = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationSLEntityView>("","#60793fe9-33d5-4f9f-8241-4432d7465d21 .ag-row[role='row']@ROWINDEX [col-id='cSalesPrice']","",true, this.CurrentView);
 
            PricePerUnit = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationSLEntityView>("","#60793fe9-33d5-4f9f-8241-4432d7465d21 .ag-row[role='row']@ROWINDEX [col-id='cPricePerUnit']","",false, this.CurrentView);
 
            Cost = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationSLEntityView>("","#60793fe9-33d5-4f9f-8241-4432d7465d21 .ag-row[role='row']@ROWINDEX [col-id='cCost']","",true, this.CurrentView);
 
            CostPerUnit = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationSLEntityView>("","#60793fe9-33d5-4f9f-8241-4432d7465d21 .ag-row[role='row']@ROWINDEX [col-id='cCostPerUnit']","",false, this.CurrentView);
 
            CostMaterials = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationSLEntityView>("","#60793fe9-33d5-4f9f-8241-4432d7465d21 .ag-row[role='row']@ROWINDEX [col-id='cCostMaterials']","",true, this.CurrentView);
 
            MaterialCostPerUnit = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationSLEntityView>("","#60793fe9-33d5-4f9f-8241-4432d7465d21 .ag-row[role='row']@ROWINDEX [col-id='cMaterialCostPerUnit']","",false, this.CurrentView);
 
            CostResources = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationSLEntityView>("","#60793fe9-33d5-4f9f-8241-4432d7465d21 .ag-row[role='row']@ROWINDEX [col-id='cCostResources']","",true, this.CurrentView);
 
            ResourceCostPerUnit = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationSLEntityView>("","#60793fe9-33d5-4f9f-8241-4432d7465d21 .ag-row[role='row']@ROWINDEX [col-id='cResourceCostPerUnit']","",false, this.CurrentView);
 
            CostOtherCosts = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationSLEntityView>("","#60793fe9-33d5-4f9f-8241-4432d7465d21 .ag-row[role='row']@ROWINDEX [col-id='cCostOtherCosts']","",true, this.CurrentView);
 
            OtherCostsPerUnit = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationSLEntityView>("","#60793fe9-33d5-4f9f-8241-4432d7465d21 .ag-row[role='row']@ROWINDEX [col-id='cOtherCostsPerUnit']","",false, this.CurrentView);
 
            Overcharges = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationSLEntityView>("","#60793fe9-33d5-4f9f-8241-4432d7465d21 .ag-row[role='row']@ROWINDEX [col-id='cOvercharges']","",false, this.CurrentView);
 
            OverchargesPerUnit = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationSLEntityView>("","#60793fe9-33d5-4f9f-8241-4432d7465d21 .ag-row[role='row']@ROWINDEX [col-id='cOverchargesPerUnit']","",false, this.CurrentView);
 
            Manual = RPSControlFactory.CreateRPSGridCheckBox<QuotationSLEntityView>("","#60793fe9-33d5-4f9f-8241-4432d7465d21 .ag-row[role='row']@ROWINDEX [col-id='cManual']","",true, this.CurrentView);
 
            ManuallyPrice = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationSLEntityView>("","#60793fe9-33d5-4f9f-8241-4432d7465d21 .ag-row[role='row']@ROWINDEX [col-id='cManuallyPrice']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<QuotationSLEntityView> Quantity { get; set; } 
        public IRPSGridTextBox<QuotationSLEntityView> SalesPrice { get; set; } 
        public IRPSGridTextBox<QuotationSLEntityView> PricePerUnit { get; set; } 
        public IRPSGridTextBox<QuotationSLEntityView> Cost { get; set; } 
        public IRPSGridTextBox<QuotationSLEntityView> CostPerUnit { get; set; } 
        public IRPSGridTextBox<QuotationSLEntityView> CostMaterials { get; set; } 
        public IRPSGridTextBox<QuotationSLEntityView> MaterialCostPerUnit { get; set; } 
        public IRPSGridTextBox<QuotationSLEntityView> CostResources { get; set; } 
        public IRPSGridTextBox<QuotationSLEntityView> ResourceCostPerUnit { get; set; } 
        public IRPSGridTextBox<QuotationSLEntityView> CostOtherCosts { get; set; } 
        public IRPSGridTextBox<QuotationSLEntityView> OtherCostsPerUnit { get; set; } 
        public IRPSGridTextBox<QuotationSLEntityView> Overcharges { get; set; } 
        public IRPSGridTextBox<QuotationSLEntityView> OverchargesPerUnit { get; set; } 
        public IRPSGridCheckbox<QuotationSLEntityView> Manual { get; set; } 
        public IRPSGridTextBox<QuotationSLEntityView> ManuallyPrice { get; set; } 
                     
    }
 
        public partial class QuotationMaterialSLsCollectionEditor<QuotationSLEntityView,QuotationTaskSLView>:RPSCollectionEditor<QuotationSLEntityView,QuotationTaskSLView> where QuotationSLEntityView : class, IView where QuotationTaskSLView : class, IView
    {
        public  QuotationMaterialSLsGridView<QuotationSLEntityView,QuotationTaskSLView> GridView {get;set;}
    }
    public partial class QuotationMaterialSLsGridView <QuotationSLEntityView,QuotationTaskSLView> :  RPSGridView<QuotationSLEntityView,QuotationTaskSLView> where QuotationSLEntityView : class, IView where QuotationTaskSLView : class, IView
    {
        public QuotationMaterialSLsGridView(QuotationSLEntityView currentView,QuotationTaskSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Order = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationSLEntityView>("","#c6ac5986-d700-4330-a39b-e21fed9903e2 .ag-row[role='row']@ROWINDEX [col-id='cOrder']","",true, this.CurrentView);
 
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<QuotationSLEntityView>("","#c6ac5986-d700-4330-a39b-e21fed9903e2 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",false, this.CurrentView);
 
            IDQuotationAssembly = RPSControlFactory.CreateRPSGridComboBox<QuotationSLEntityView>("","#c6ac5986-d700-4330-a39b-e21fed9903e2 .ag-row[role='row']@ROWINDEX [col-id='cIDQuotationAssembly']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationSLEntityView>("","#c6ac5986-d700-4330-a39b-e21fed9903e2 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            Notes = RPSControlFactory.CreateRPSGridMemoTextBox<QuotationSLEntityView>("","#c6ac5986-d700-4330-a39b-e21fed9903e2 .ag-row[role='row']@ROWINDEX [col-id='cNotes']","",false, this.CurrentView);
 
            NumCuts = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationSLEntityView>("","#c6ac5986-d700-4330-a39b-e21fed9903e2 .ag-row[role='row']@ROWINDEX [col-id='cNumCuts']","",true, this.CurrentView);
 
            CostPrice = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationSLEntityView>("","#c6ac5986-d700-4330-a39b-e21fed9903e2 .ag-row[role='row']@ROWINDEX [col-id='cCostPrice']","",true, this.CurrentView);
 
            CostAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationSLEntityView>("","#c6ac5986-d700-4330-a39b-e21fed9903e2 .ag-row[role='row']@ROWINDEX [col-id='cCostAmount']","",true, this.CurrentView);
 
            IDSupplierRequestQuotationLine = RPSControlFactory.CreateRPSGridComboBox<QuotationSLEntityView>("","#c6ac5986-d700-4330-a39b-e21fed9903e2 .ag-row[role='row']@ROWINDEX [col-id='cIDSupplierRequestQuotationLine']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<QuotationSLEntityView> Order { get; set; } 
        public IRPSGridComboBox<QuotationSLEntityView> IDArticle { get; set; } 
        public IRPSGridComboBox<QuotationSLEntityView> IDQuotationAssembly { get; set; } 
        public IRPSGridTextBox<QuotationSLEntityView> Quantity { get; set; } 
        public IRPSGridTextBox<QuotationSLEntityView> Notes { get; set; } 
        public IRPSGridTextBox<QuotationSLEntityView> NumCuts { get; set; } 
        public IRPSGridTextBox<QuotationSLEntityView> CostPrice { get; set; } 
        public IRPSGridTextBox<QuotationSLEntityView> CostAmount { get; set; } 
        public IRPSGridComboBox<QuotationSLEntityView> IDSupplierRequestQuotationLine { get; set; } 
                     
    }
 
        public partial class QuotationTaskSLsCollectionEditor<QuotationSLEntityView,QuotationTaskSLView>:RPSCollectionEditor<QuotationSLEntityView,QuotationTaskSLView> where QuotationSLEntityView : class, IView where QuotationTaskSLView : class, IView
    {
        public  QuotationTaskSLsGridView<QuotationSLEntityView,QuotationTaskSLView> GridView {get;set;}
    }
    public partial class QuotationTaskSLsGridView <QuotationSLEntityView,QuotationTaskSLView> :  RPSGridView<QuotationSLEntityView,QuotationTaskSLView> where QuotationSLEntityView : class, IView where QuotationTaskSLView : class, IView
    {
        public QuotationTaskSLsGridView(QuotationSLEntityView currentView,QuotationTaskSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Description = RPSControlFactory.CreateRPSGridTextBox<QuotationSLEntityView>("","#4e91132c-0a62-4503-9cab-e3f9980eb4d0 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            IDArticleExternal = RPSControlFactory.CreateRPSGridComboBox<QuotationSLEntityView>("","#4e91132c-0a62-4503-9cab-e3f9980eb4d0 .ag-row[role='row']@ROWINDEX [col-id='cIDArticleExternal']","",false, this.CurrentView);
 
            IDSupplier = RPSControlFactory.CreateRPSGridComboBox<QuotationSLEntityView>("","#4e91132c-0a62-4503-9cab-e3f9980eb4d0 .ag-row[role='row']@ROWINDEX [col-id='cIDSupplier']","",false, this.CurrentView);
 
            External = RPSControlFactory.CreateRPSGridCheckBox<QuotationSLEntityView>("","#4e91132c-0a62-4503-9cab-e3f9980eb4d0 .ag-row[role='row']@ROWINDEX [col-id='cExternal']","",true, this.CurrentView);
 
            CostPrice = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationSLEntityView>("","#4e91132c-0a62-4503-9cab-e3f9980eb4d0 .ag-row[role='row']@ROWINDEX [col-id='cCostPrice']","",true, this.CurrentView);
 
            CostAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationSLEntityView>("","#4e91132c-0a62-4503-9cab-e3f9980eb4d0 .ag-row[role='row']@ROWINDEX [col-id='cCostAmount']","",true, this.CurrentView);
 
            IDUsualTask = RPSControlFactory.CreateRPSGridComboBox<QuotationSLEntityView>("","#4e91132c-0a62-4503-9cab-e3f9980eb4d0 .ag-row[role='row']@ROWINDEX [col-id='cIDUsualTask']","",false, this.CurrentView);
 
            PreparationTime = RPSControlFactory.CreateRPSGridDurationTextBox<QuotationSLEntityView>("","#4e91132c-0a62-4503-9cab-e3f9980eb4d0 .ag-row[role='row']@ROWINDEX [col-id='cPreparationTime']","",true, this.CurrentView);
 
            ExecutionTime = RPSControlFactory.CreateRPSGridDurationTextBox<QuotationSLEntityView>("","#4e91132c-0a62-4503-9cab-e3f9980eb4d0 .ag-row[role='row']@ROWINDEX [col-id='cExecutionTime']","",true, this.CurrentView);
 
            ExecutionLot = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationSLEntityView>("","#4e91132c-0a62-4503-9cab-e3f9980eb4d0 .ag-row[role='row']@ROWINDEX [col-id='cExecutionLot']","",true, this.CurrentView);
 
            MaterialExit = RPSControlFactory.CreateRPSGridCheckBox<QuotationSLEntityView>("","#4e91132c-0a62-4503-9cab-e3f9980eb4d0 .ag-row[role='row']@ROWINDEX [col-id='cMaterialExit']","",true, this.CurrentView);
 
            ProductEntry = RPSControlFactory.CreateRPSGridCheckBox<QuotationSLEntityView>("","#4e91132c-0a62-4503-9cab-e3f9980eb4d0 .ag-row[role='row']@ROWINDEX [col-id='cProductEntry']","",true, this.CurrentView);
 
            Notes = RPSControlFactory.CreateRPSGridMemoTextBox<QuotationSLEntityView>("","#4e91132c-0a62-4503-9cab-e3f9980eb4d0 .ag-row[role='row']@ROWINDEX [col-id='cNotes']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<QuotationSLEntityView> Description { get; set; } 
        public IRPSGridComboBox<QuotationSLEntityView> IDArticleExternal { get; set; } 
        public IRPSGridComboBox<QuotationSLEntityView> IDSupplier { get; set; } 
        public IRPSGridCheckbox<QuotationSLEntityView> External { get; set; } 
        public IRPSGridTextBox<QuotationSLEntityView> CostPrice { get; set; } 
        public IRPSGridTextBox<QuotationSLEntityView> CostAmount { get; set; } 
        public IRPSGridComboBox<QuotationSLEntityView> IDUsualTask { get; set; } 
        public IRPSGridDurationTextBox<QuotationSLEntityView> PreparationTime { get; set; } 
        public IRPSGridDurationTextBox<QuotationSLEntityView> ExecutionTime { get; set; } 
        public IRPSGridTextBox<QuotationSLEntityView> ExecutionLot { get; set; } 
        public IRPSGridCheckbox<QuotationSLEntityView> MaterialExit { get; set; } 
        public IRPSGridCheckbox<QuotationSLEntityView> ProductEntry { get; set; } 
        public IRPSGridTextBox<QuotationSLEntityView> Notes { get; set; } 
                     
    }
 
        public partial class QuotationResourceSLsCollectionEditor<QuotationSLEntityView,QuotationTaskSLView>:RPSCollectionEditor<QuotationSLEntityView,QuotationTaskSLView> where QuotationSLEntityView : class, IView where QuotationTaskSLView : class, IView
    {
        public  QuotationResourceSLsGridView<QuotationSLEntityView,QuotationTaskSLView> GridView {get;set;}
    }
    public partial class QuotationResourceSLsGridView <QuotationSLEntityView,QuotationTaskSLView> :  RPSGridView<QuotationSLEntityView,QuotationTaskSLView> where QuotationSLEntityView : class, IView where QuotationTaskSLView : class, IView
    {
        public QuotationResourceSLsGridView(QuotationSLEntityView currentView,QuotationTaskSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<QuotationSLEntityView>("","#66fdd10a-00db-4fdc-a9cc-632e927ed9a2 .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            IDItemSelector = RPSControlFactory.CreateRPSGridComboBox<QuotationSLEntityView>("","#66fdd10a-00db-4fdc-a9cc-632e927ed9a2 .ag-row[role='row']@ROWINDEX [col-id='cIDItemSelector']","",false, this.CurrentView);
 
            Planify = RPSControlFactory.CreateRPSGridCheckBox<QuotationSLEntityView>("","#66fdd10a-00db-4fdc-a9cc-632e927ed9a2 .ag-row[role='row']@ROWINDEX [col-id='cPlanify']","",true, this.CurrentView);
 
            Duration = RPSControlFactory.CreateRPSGridDurationTextBox<QuotationSLEntityView>("","#66fdd10a-00db-4fdc-a9cc-632e927ed9a2 .ag-row[role='row']@ROWINDEX [col-id='cDuration']","",true, this.CurrentView);
 
            DedicationPercent = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationSLEntityView>("","#66fdd10a-00db-4fdc-a9cc-632e927ed9a2 .ag-row[role='row']@ROWINDEX [col-id='cDedicationPercent']","",true, this.CurrentView);
 
            CostPrice = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationSLEntityView>("","#66fdd10a-00db-4fdc-a9cc-632e927ed9a2 .ag-row[role='row']@ROWINDEX [col-id='cCostPrice']","",true, this.CurrentView);
 
            CostAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationSLEntityView>("","#66fdd10a-00db-4fdc-a9cc-632e927ed9a2 .ag-row[role='row']@ROWINDEX [col-id='cCostAmount']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<QuotationSLEntityView> Type { get; set; } 
        public IRPSGridComboBox<QuotationSLEntityView> IDItemSelector { get; set; } 
        public IRPSGridCheckbox<QuotationSLEntityView> Planify { get; set; } 
        public IRPSGridDurationTextBox<QuotationSLEntityView> Duration { get; set; } 
        public IRPSGridTextBox<QuotationSLEntityView> DedicationPercent { get; set; } 
        public IRPSGridTextBox<QuotationSLEntityView> CostPrice { get; set; } 
        public IRPSGridTextBox<QuotationSLEntityView> CostAmount { get; set; } 
                     
    }
 
        public partial class QuotationOtherCostSLsCollectionEditor<QuotationSLEntityView,QuotationTaskSLView>:RPSCollectionEditor<QuotationSLEntityView,QuotationTaskSLView> where QuotationSLEntityView : class, IView where QuotationTaskSLView : class, IView
    {
        public  QuotationOtherCostSLsGridView<QuotationSLEntityView,QuotationTaskSLView> GridView {get;set;}
    }
    public partial class QuotationOtherCostSLsGridView <QuotationSLEntityView,QuotationTaskSLView> :  RPSGridView<QuotationSLEntityView,QuotationTaskSLView> where QuotationSLEntityView : class, IView where QuotationTaskSLView : class, IView
    {
        public QuotationOtherCostSLsGridView(QuotationSLEntityView currentView,QuotationTaskSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDCostComponent = RPSControlFactory.CreateRPSGridComboBox<QuotationSLEntityView>("","#4448ab1c-0769-44bf-b0da-06c51677b08f .ag-row[role='row']@ROWINDEX [col-id='cIDCostComponent']","",true, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationSLEntityView>("","#4448ab1c-0769-44bf-b0da-06c51677b08f .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            CostPrice = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationSLEntityView>("","#4448ab1c-0769-44bf-b0da-06c51677b08f .ag-row[role='row']@ROWINDEX [col-id='cCostPrice']","",true, this.CurrentView);
 
            CostAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationSLEntityView>("","#4448ab1c-0769-44bf-b0da-06c51677b08f .ag-row[role='row']@ROWINDEX [col-id='cCostAmount']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<QuotationSLEntityView> IDCostComponent { get; set; } 
        public IRPSGridTextBox<QuotationSLEntityView> Quantity { get; set; } 
        public IRPSGridTextBox<QuotationSLEntityView> CostPrice { get; set; } 
        public IRPSGridTextBox<QuotationSLEntityView> CostAmount { get; set; } 
                     
    }
 
        public partial class QuotationOverChargeSLsCollectionEditor<QuotationSLEntityView,QuotationTaskSLView>:RPSCollectionEditor<QuotationSLEntityView,QuotationTaskSLView> where QuotationSLEntityView : class, IView where QuotationTaskSLView : class, IView
    {
        public  QuotationOverChargeSLsGridView<QuotationSLEntityView,QuotationTaskSLView> GridView {get;set;}
    }
    public partial class QuotationOverChargeSLsGridView <QuotationSLEntityView,QuotationTaskSLView> :  RPSGridView<QuotationSLEntityView,QuotationTaskSLView> where QuotationSLEntityView : class, IView where QuotationTaskSLView : class, IView
    {
        public QuotationOverChargeSLsGridView(QuotationSLEntityView currentView,QuotationTaskSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationSLEntityView>("","#d40c41b1-0f3d-44dd-9816-f042bb3a1eba .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<QuotationSLEntityView>("","#d40c41b1-0f3d-44dd-9816-f042bb3a1eba .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Apply = RPSControlFactory.CreateRPSGridEnumComboBox<QuotationSLEntityView>("","#d40c41b1-0f3d-44dd-9816-f042bb3a1eba .ag-row[role='row']@ROWINDEX [col-id='cApply']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<QuotationSLEntityView>("","#d40c41b1-0f3d-44dd-9816-f042bb3a1eba .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            CostAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationSLEntityView>("","#d40c41b1-0f3d-44dd-9816-f042bb3a1eba .ag-row[role='row']@ROWINDEX [col-id='cCostAmount']","",true, this.CurrentView);
 
            Base = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationSLEntityView>("","#d40c41b1-0f3d-44dd-9816-f042bb3a1eba .ag-row[role='row']@ROWINDEX [col-id='cBase']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<QuotationSLEntityView> Quantity { get; set; } 
        public IRPSGridTextBox<QuotationSLEntityView> Description { get; set; } 
        public IRPSGridComboBox<QuotationSLEntityView> Apply { get; set; } 
        public IRPSGridComboBox<QuotationSLEntityView> Type { get; set; } 
        public IRPSGridTextBox<QuotationSLEntityView> CostAmount { get; set; } 
        public IRPSGridTextBox<QuotationSLEntityView> Base { get; set; } 
                     
    }
 
        public partial class QuotationFeaturesCollectionEditor<QuotationSLEntityView,QuotationTaskSLView>:RPSCollectionEditor<QuotationSLEntityView,QuotationTaskSLView> where QuotationSLEntityView : class, IView where QuotationTaskSLView : class, IView
    {
        public  QuotationFeaturesGridView<QuotationSLEntityView,QuotationTaskSLView> GridView {get;set;}
    }
    public partial class QuotationFeaturesGridView <QuotationSLEntityView,QuotationTaskSLView> :  RPSGridView<QuotationSLEntityView,QuotationTaskSLView> where QuotationSLEntityView : class, IView where QuotationTaskSLView : class, IView
    {
        public QuotationFeaturesGridView(QuotationSLEntityView currentView,QuotationTaskSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticleLabel = RPSControlFactory.CreateRPSGridComboBox<QuotationSLEntityView>("","#16f5b6b8-5f70-494e-a028-456a18f01ab4 .ag-row[role='row']@ROWINDEX [col-id='cIDArticleLabel']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<QuotationSLEntityView> IDArticleLabel { get; set; } 
                     
    }
 
    }
  
            
    public partial class QuotationMaterialSLView : View
    {
        public QuotationMaterialSLView(QuotationSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<QuotationMaterialSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<QuotationMaterialSLView,QuotationSLEntityView>( this,Screen.QuotationSLEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<QuotationMaterialSLView,QuotationSLEntityView>( this,Screen.QuotationSLEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<QuotationMaterialSLView,QuotationSLEntityView>( this,Screen.QuotationSLEntityView);
 
            Order = RPSControlFactory.CreateRPSFormattedTextBox<QuotationMaterialSLView>("0ab10878-147f-4229-bbd4-3e078ef17ee5","","",true, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<QuotationMaterialSLView>("b939584e-a23d-4625-a643-06686cf09b09","","",false, this);
 
            IDQuotationAssembly = RPSControlFactory.CreateRPSComboBox<QuotationMaterialSLView>("955e84b8-033c-454b-98bb-00dfbed2ffc3","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<QuotationMaterialSLView>("f3c94e99-e0c8-4c2a-bf6d-b280382bfdc2","","",true, this);
 
            QuantityType = RPSControlFactory.CreateRPSEnumComboBox<QuotationMaterialSLView>("e37dd4ad-55b7-42e0-9eb5-5677ae492bb1","","",true, this);
 
            ContentLot = RPSControlFactory.CreateRPSFormattedTextBox<QuotationMaterialSLView>("b0aaaf31-10ef-4f05-9dae-7b33454244eb","","",true, this);
 
            CostPrice = RPSControlFactory.CreateRPSFormattedTextBox<QuotationMaterialSLView>("8cd4b8cc-60fd-4985-b2aa-c9c2b3d45c5a","","",true, this);
 
            CostAmount = RPSControlFactory.CreateRPSFormattedTextBox<QuotationMaterialSLView>("79ef0dab-8c84-49c7-a580-e2c61c193701","","",true, this);
 
            NumCuts = RPSControlFactory.CreateRPSFormattedTextBox<QuotationMaterialSLView>("5bf9d64a-9a3b-4813-8c54-5b6f30da9249","","",true, this);
 
            IDSupplierRequestQuotationLine = RPSControlFactory.CreateRPSComboBox<QuotationMaterialSLView>("82248029-a4b5-4ffa-8eef-8157590425a6","","",false, this);
 
            Notes = RPSControlFactory.CreateRPSTextBox<QuotationMaterialSLView>("84a7a4d0-e64f-4e8a-8861-97bbf75367cd","","",false, this);
 
            QuotationMaterialLotChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<QuotationMaterialSLView,QuotationMaterialLotChildDialogView>("f845802c-456c-44fd-9df0-aab6a18b8c9d","","", this,Screen.QuotationMaterialLotChildDialogView);
 
            CollectionInit params_QuotationMaterialLotSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f3be6406-0097-461c-b2e5-a173490dc9fe",CSSSelectorGrid="",XPathGrid=""};
            QuotationMaterialLotSLs = RPSControlFactory.RPSCreateCollectionWithGrid<QuotationMaterialLotSLsCollectionEditor<QuotationMaterialSLView,QuotationMaterialLotSLView>,QuotationMaterialSLView,QuotationMaterialLotSLView>( params_QuotationMaterialLotSLs,this,Screen.QuotationMaterialLotSLView);
 
            SectionGeneral = RPSControlFactory.CreateRPSSection<QuotationMaterialSLView>( "","ul li[rpsid='bce86e3f-8966-4408-8f77-81cabd27d17b']","",this);
 
            SectionQuotationMaterialLosts = RPSControlFactory.CreateRPSSection<QuotationMaterialSLView>( "","ul li[rpsid='5a838be8-d47b-47ab-b208-0f5862db1954']","",this);
 

        }
        public IRPSButton<QuotationMaterialSLView> DeleteButton { get; set; } 
        public IRPSButton<QuotationMaterialSLView,QuotationSLEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<QuotationMaterialSLView,QuotationSLEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<QuotationMaterialSLView,QuotationSLEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<QuotationMaterialSLView> Order { get; set; } 
        public IRPSComboBox<QuotationMaterialSLView> IDArticle { get; set; } 
        public IRPSComboBox<QuotationMaterialSLView> IDQuotationAssembly { get; set; } 
        public IRPSTextBox<QuotationMaterialSLView> Quantity { get; set; } 
        public IRPSComboBox<QuotationMaterialSLView> QuantityType { get; set; } 
        public IRPSTextBox<QuotationMaterialSLView> ContentLot { get; set; } 
        public IRPSTextBox<QuotationMaterialSLView> CostPrice { get; set; } 
        public IRPSTextBox<QuotationMaterialSLView> CostAmount { get; set; } 
        public IRPSTextBox<QuotationMaterialSLView> NumCuts { get; set; } 
        public IRPSComboBox<QuotationMaterialSLView> IDSupplierRequestQuotationLine { get; set; } 
        public IRPSTextBox<QuotationMaterialSLView> Notes { get; set; } 
        public IRPSButton<QuotationMaterialSLView,QuotationMaterialLotChildDialogView> QuotationMaterialLotChildNavigationCommandButton { get; set; } 
        public QuotationMaterialLotSLsCollectionEditor<QuotationMaterialSLView,QuotationMaterialLotSLView> QuotationMaterialLotSLs { get; set; } 
        public IRPSSection<QuotationMaterialSLView> SectionGeneral { get; set; } 
        public IRPSSection<QuotationMaterialSLView> SectionQuotationMaterialLosts { get; set; } 
        public QuotationSL Screen { get; set; }
        public QuotationMaterialSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class QuotationMaterialLotSLsCollectionEditor<QuotationMaterialSLView,QuotationMaterialLotSLView>:RPSCollectionEditor<QuotationMaterialSLView,QuotationMaterialLotSLView> where QuotationMaterialSLView : class, IView where QuotationMaterialLotSLView : class, IView
    {
        public  QuotationMaterialLotSLsGridView<QuotationMaterialSLView,QuotationMaterialLotSLView> GridView {get;set;}
    }
    public partial class QuotationMaterialLotSLsGridView <QuotationMaterialSLView,QuotationMaterialLotSLView> :  RPSGridView<QuotationMaterialSLView,QuotationMaterialLotSLView> where QuotationMaterialSLView : class, IView where QuotationMaterialLotSLView : class, IView
    {
        public QuotationMaterialLotSLsGridView(QuotationMaterialSLView currentView,QuotationMaterialLotSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationMaterialSLView>("","#f3be6406-0097-461c-b2e5-a173490dc9fe .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            QuantityMaterial = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationMaterialSLView>("","#f3be6406-0097-461c-b2e5-a173490dc9fe .ag-row[role='row']@ROWINDEX [col-id='cQuantityMaterial']","",true, this.CurrentView);
 
            CostPrice = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationMaterialSLView>("","#f3be6406-0097-461c-b2e5-a173490dc9fe .ag-row[role='row']@ROWINDEX [col-id='cCostPrice']","",true, this.CurrentView);
 
            CostAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationMaterialSLView>("","#f3be6406-0097-461c-b2e5-a173490dc9fe .ag-row[role='row']@ROWINDEX [col-id='cCostAmount']","",true, this.CurrentView);
 
            IDSupplierRequestQuotationLine = RPSControlFactory.CreateRPSGridComboBox<QuotationMaterialSLView>("","#f3be6406-0097-461c-b2e5-a173490dc9fe .ag-row[role='row']@ROWINDEX [col-id='cIDSupplierRequestQuotationLine']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<QuotationMaterialSLView> Quantity { get; set; } 
        public IRPSGridTextBox<QuotationMaterialSLView> QuantityMaterial { get; set; } 
        public IRPSGridTextBox<QuotationMaterialSLView> CostPrice { get; set; } 
        public IRPSGridTextBox<QuotationMaterialSLView> CostAmount { get; set; } 
        public IRPSGridComboBox<QuotationMaterialSLView> IDSupplierRequestQuotationLine { get; set; } 
                     
    }
 
    }
  
            
    public partial class QuotationTaskSLView : View
    {
        public QuotationTaskSLView(QuotationSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<QuotationTaskSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<QuotationTaskSLView,QuotationSLEntityView>( this,Screen.QuotationSLEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<QuotationTaskSLView,QuotationSLEntityView>( this,Screen.QuotationSLEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<QuotationTaskSLView,QuotationSLEntityView>( this,Screen.QuotationSLEntityView);
 
            Order = RPSControlFactory.CreateRPSFormattedTextBox<QuotationTaskSLView>("30c3a2f3-d2b8-453f-98a1-eaeb31da863b","","",true, this);
 
            IDArticleExternal = RPSControlFactory.CreateRPSComboBox<QuotationTaskSLView>("faaf8784-e01f-465a-af37-d8fe6d2e312e","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<QuotationTaskSLView>("c500d87a-a5c8-4bf7-86de-b08d53531f56","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<QuotationTaskSLView>("79e391f0-8cbb-4937-8328-e7b8d95a1ae8","","",false, this);
 
            ExecutionTime = RPSControlFactory.CreateRPSDurationTextBox<QuotationTaskSLView>("ad9b5786-8b95-4324-8d10-6ac87bb67803","","",true, this);
 
            PreparationTime = RPSControlFactory.CreateRPSDurationTextBox<QuotationTaskSLView>("dbccaef5-176b-451a-9e47-9cf047ef3697","","",true, this);
 
            RepetitionTime = RPSControlFactory.CreateRPSDurationTextBox<QuotationTaskSLView>("24de1dbb-2168-4dd3-b736-290551016bee","","",true, this);
 
            RepetitionLot = RPSControlFactory.CreateRPSFormattedTextBox<QuotationTaskSLView>("2b2ed92b-15ae-4922-adf0-9f273d02f233","","",true, this);
 
            ExecutionLot = RPSControlFactory.CreateRPSFormattedTextBox<QuotationTaskSLView>("2808a673-eb56-47c3-9cff-dbbbc072ad64","","",true, this);
 
            External = RPSControlFactory.CreateRPSCheckBox<QuotationTaskSLView>("e8220f01-657a-4f80-889c-ca679ab6c4cb","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<QuotationTaskSLView>("f937bcf6-ffd9-4a7a-ae12-70cd85491c42","","",true, this);
 
            CostPrice = RPSControlFactory.CreateRPSFormattedTextBox<QuotationTaskSLView>("455c32e6-573e-4538-b44c-3fba49954a0f","","",true, this);
 
            CostAmount = RPSControlFactory.CreateRPSFormattedTextBox<QuotationTaskSLView>("6fb6089f-44e7-48a6-b066-30b53c31d254","","",true, this);
 
            IDUsualTask = RPSControlFactory.CreateRPSComboBox<QuotationTaskSLView>("6fb970b5-6bd5-4894-87f7-f6f284d93d21","","",false, this);
 
            MaterialExit = RPSControlFactory.CreateRPSCheckBox<QuotationTaskSLView>("72123cbf-812f-4c3f-95eb-4bf44d1359ec","","",true, this);
 
            ProductEntry = RPSControlFactory.CreateRPSCheckBox<QuotationTaskSLView>("934bab6d-4437-4785-898e-068502284720","","",true, this);
 
            IDSupplierRequestQuotationLine = RPSControlFactory.CreateRPSComboBox<QuotationTaskSLView>("c2c357fd-2743-4ab4-8c23-f3b7d650afe5","","",false, this);
 
            Notes = RPSControlFactory.CreateRPSTextBox<QuotationTaskSLView>("18149472-3095-4aae-bf2d-ec81d247691c","","",false, this);
 
            QuotationTaskLotChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<QuotationTaskSLView,QuotationTaskLotChildDialogView>("3c11a12a-0231-4f15-9d5b-77df84190a90","","", this,Screen.QuotationTaskLotChildDialogView);
 
            CollectionInit params_QuotationTaskLotSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3301f2f6-f464-4900-b405-2e12c42d86e1",CSSSelectorGrid="",XPathGrid=""};
            QuotationTaskLotSLs = RPSControlFactory.RPSCreateCollectionWithGrid<QuotationTaskLotSLsCollectionEditor<QuotationTaskSLView,QuotationTaskLotSLView>,QuotationTaskSLView,QuotationTaskLotSLView>( params_QuotationTaskLotSLs,this,Screen.QuotationTaskLotSLView);
 
            SectionGeneral = RPSControlFactory.CreateRPSSection<QuotationTaskSLView>( "","ul li[rpsid='7e9b2751-a06c-4791-8f4b-44e235d9912d']","",this);
 
            SectionQuotationTaskLot = RPSControlFactory.CreateRPSSection<QuotationTaskSLView>( "","ul li[rpsid='3a7369bf-7d52-4ea8-ba7d-fea2e4fe0a23']","",this);
 

        }
        public IRPSButton<QuotationTaskSLView> DeleteButton { get; set; } 
        public IRPSButton<QuotationTaskSLView,QuotationSLEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<QuotationTaskSLView,QuotationSLEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<QuotationTaskSLView,QuotationSLEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<QuotationTaskSLView> Order { get; set; } 
        public IRPSComboBox<QuotationTaskSLView> IDArticleExternal { get; set; } 
        public IRPSComboBox<QuotationTaskSLView> IDSupplier { get; set; } 
        public IRPSTextBox<QuotationTaskSLView> Description { get; set; } 
        public IRPSDurationTextBox<QuotationTaskSLView> ExecutionTime { get; set; } 
        public IRPSDurationTextBox<QuotationTaskSLView> PreparationTime { get; set; } 
        public IRPSDurationTextBox<QuotationTaskSLView> RepetitionTime { get; set; } 
        public IRPSTextBox<QuotationTaskSLView> RepetitionLot { get; set; } 
        public IRPSTextBox<QuotationTaskSLView> ExecutionLot { get; set; } 
        public IRPSCheckbox<QuotationTaskSLView> External { get; set; } 
        public IRPSTextBox<QuotationTaskSLView> Quantity { get; set; } 
        public IRPSTextBox<QuotationTaskSLView> CostPrice { get; set; } 
        public IRPSTextBox<QuotationTaskSLView> CostAmount { get; set; } 
        public IRPSComboBox<QuotationTaskSLView> IDUsualTask { get; set; } 
        public IRPSCheckbox<QuotationTaskSLView> MaterialExit { get; set; } 
        public IRPSCheckbox<QuotationTaskSLView> ProductEntry { get; set; } 
        public IRPSComboBox<QuotationTaskSLView> IDSupplierRequestQuotationLine { get; set; } 
        public IRPSTextBox<QuotationTaskSLView> Notes { get; set; } 
        public IRPSButton<QuotationTaskSLView,QuotationTaskLotChildDialogView> QuotationTaskLotChildNavigationCommandButton { get; set; } 
        public QuotationTaskLotSLsCollectionEditor<QuotationTaskSLView,QuotationTaskLotSLView> QuotationTaskLotSLs { get; set; } 
        public IRPSSection<QuotationTaskSLView> SectionGeneral { get; set; } 
        public IRPSSection<QuotationTaskSLView> SectionQuotationTaskLot { get; set; } 
        public QuotationSL Screen { get; set; }
        public QuotationTaskSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class QuotationTaskLotSLsCollectionEditor<QuotationTaskSLView,QuotationTaskLotSLView>:RPSCollectionEditor<QuotationTaskSLView,QuotationTaskLotSLView> where QuotationTaskSLView : class, IView where QuotationTaskLotSLView : class, IView
    {
        public  QuotationTaskLotSLsGridView<QuotationTaskSLView,QuotationTaskLotSLView> GridView {get;set;}
    }
    public partial class QuotationTaskLotSLsGridView <QuotationTaskSLView,QuotationTaskLotSLView> :  RPSGridView<QuotationTaskSLView,QuotationTaskLotSLView> where QuotationTaskSLView : class, IView where QuotationTaskLotSLView : class, IView
    {
        public QuotationTaskLotSLsGridView(QuotationTaskSLView currentView,QuotationTaskLotSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationTaskSLView>("","#3301f2f6-f464-4900-b405-2e12c42d86e1 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            PreparationTime = RPSControlFactory.CreateRPSGridDurationTextBox<QuotationTaskSLView>("","#3301f2f6-f464-4900-b405-2e12c42d86e1 .ag-row[role='row']@ROWINDEX [col-id='cPreparationTime']","",true, this.CurrentView);
 
            ExecutionTime = RPSControlFactory.CreateRPSGridDurationTextBox<QuotationTaskSLView>("","#3301f2f6-f464-4900-b405-2e12c42d86e1 .ag-row[role='row']@ROWINDEX [col-id='cExecutionTime']","",true, this.CurrentView);
 
            QuantityExternalTask = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationTaskSLView>("","#3301f2f6-f464-4900-b405-2e12c42d86e1 .ag-row[role='row']@ROWINDEX [col-id='cQuantityExternalTask']","",true, this.CurrentView);
 
            CostPrice = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationTaskSLView>("","#3301f2f6-f464-4900-b405-2e12c42d86e1 .ag-row[role='row']@ROWINDEX [col-id='cCostPrice']","",true, this.CurrentView);
 
            CostAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationTaskSLView>("","#3301f2f6-f464-4900-b405-2e12c42d86e1 .ag-row[role='row']@ROWINDEX [col-id='cCostAmount']","",true, this.CurrentView);
 
            IDSupplierRequestQuotationLine = RPSControlFactory.CreateRPSGridComboBox<QuotationTaskSLView>("","#3301f2f6-f464-4900-b405-2e12c42d86e1 .ag-row[role='row']@ROWINDEX [col-id='cIDSupplierRequestQuotationLine']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<QuotationTaskSLView> Quantity { get; set; } 
        public IRPSGridDurationTextBox<QuotationTaskSLView> PreparationTime { get; set; } 
        public IRPSGridDurationTextBox<QuotationTaskSLView> ExecutionTime { get; set; } 
        public IRPSGridTextBox<QuotationTaskSLView> QuantityExternalTask { get; set; } 
        public IRPSGridTextBox<QuotationTaskSLView> CostPrice { get; set; } 
        public IRPSGridTextBox<QuotationTaskSLView> CostAmount { get; set; } 
        public IRPSGridComboBox<QuotationTaskSLView> IDSupplierRequestQuotationLine { get; set; } 
                     
    }
 
    }
  
            
    public partial class QuotationResourceSLView : View
    {
        public QuotationResourceSLView(QuotationSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<QuotationResourceSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<QuotationResourceSLView,QuotationSLEntityView>( this,Screen.QuotationSLEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<QuotationResourceSLView,QuotationSLEntityView>( this,Screen.QuotationSLEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<QuotationResourceSLView,QuotationSLEntityView>( this,Screen.QuotationSLEntityView);
 
            Order = RPSControlFactory.CreateRPSFormattedTextBox<QuotationResourceSLView>("f56952ff-3bd4-44fa-a464-22cc7941c776","","",true, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<QuotationResourceSLView>("365c3f48-3ebb-48fb-968a-456385f769c4","","",true, this);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<QuotationResourceSLView>("07378ae5-7b4e-40c7-a7e7-9dc87156bc1d","","",false, this);
 
            IDQualify = RPSControlFactory.CreateRPSComboBox<QuotationResourceSLView>("4222ab5c-672a-49cd-8a17-6195520fd3d8","","",false, this);
 
            IDMachine = RPSControlFactory.CreateRPSComboBox<QuotationResourceSLView>("479a6f50-5cdd-472e-b200-c8ffff79c85e","","",false, this);
 
            IDMachineGroup = RPSControlFactory.CreateRPSComboBox<QuotationResourceSLView>("74474789-bbd1-46a9-9466-ec3780893121","","",false, this);
 
            IDTool = RPSControlFactory.CreateRPSComboBox<QuotationResourceSLView>("0634486b-4fd6-41cb-9cb0-cfe22aa7438e","","",false, this);
 
            Planify = RPSControlFactory.CreateRPSCheckBox<QuotationResourceSLView>("f766c24e-d64f-4d2e-ab00-ff790ca919ad","","",true, this);
 
            Duration = RPSControlFactory.CreateRPSDurationTextBox<QuotationResourceSLView>("874b1f17-d960-4023-8563-e730ed3d71fc","","",true, this);
 
            DedicationPercent = RPSControlFactory.CreateRPSFormattedTextBox<QuotationResourceSLView>("8394cece-add2-43fd-a1f5-90d95fc6146b","","",true, this);
 
            CostPrice = RPSControlFactory.CreateRPSFormattedTextBox<QuotationResourceSLView>("95abdd1a-7aeb-4f67-b831-b7fb3f887fbc","","",true, this);
 
            CostAmount = RPSControlFactory.CreateRPSFormattedTextBox<QuotationResourceSLView>("eae68efe-923b-48d0-925f-941958f9fac6","","",true, this);
 
            QuotationResourceLotChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<QuotationResourceSLView,QuotationResourceLotChildDialogView>("982a7fea-2252-430a-a8bb-ba746fc70f9a","","", this,Screen.QuotationResourceLotChildDialogView);
 
            CollectionInit params_QuotationResourceLotSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ecd090d6-eafd-480b-93d5-a1659bf49ca3",CSSSelectorGrid="",XPathGrid=""};
            QuotationResourceLotSLs = RPSControlFactory.RPSCreateCollectionWithGrid<QuotationResourceLotSLsCollectionEditor<QuotationResourceSLView,QuotationResourceLotSLView>,QuotationResourceSLView,QuotationResourceLotSLView>( params_QuotationResourceLotSLs,this,Screen.QuotationResourceLotSLView);
 
            SectionGeneral = RPSControlFactory.CreateRPSSection<QuotationResourceSLView>( "","ul li[rpsid='03f2e7b2-ddee-4b79-8d94-6815cd6121e2']","",this);
 
            SectionQuotationResourcesLot = RPSControlFactory.CreateRPSSection<QuotationResourceSLView>( "","ul li[rpsid='b126788f-c09a-41ea-a503-dedf9017730e']","",this);
 

        }
        public IRPSButton<QuotationResourceSLView> DeleteButton { get; set; } 
        public IRPSButton<QuotationResourceSLView,QuotationSLEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<QuotationResourceSLView,QuotationSLEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<QuotationResourceSLView,QuotationSLEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<QuotationResourceSLView> Order { get; set; } 
        public IRPSComboBox<QuotationResourceSLView> Type { get; set; } 
        public IRPSComboBox<QuotationResourceSLView> IDEmployee { get; set; } 
        public IRPSComboBox<QuotationResourceSLView> IDQualify { get; set; } 
        public IRPSComboBox<QuotationResourceSLView> IDMachine { get; set; } 
        public IRPSComboBox<QuotationResourceSLView> IDMachineGroup { get; set; } 
        public IRPSComboBox<QuotationResourceSLView> IDTool { get; set; } 
        public IRPSCheckbox<QuotationResourceSLView> Planify { get; set; } 
        public IRPSDurationTextBox<QuotationResourceSLView> Duration { get; set; } 
        public IRPSTextBox<QuotationResourceSLView> DedicationPercent { get; set; } 
        public IRPSTextBox<QuotationResourceSLView> CostPrice { get; set; } 
        public IRPSTextBox<QuotationResourceSLView> CostAmount { get; set; } 
        public IRPSButton<QuotationResourceSLView,QuotationResourceLotChildDialogView> QuotationResourceLotChildNavigationCommandButton { get; set; } 
        public QuotationResourceLotSLsCollectionEditor<QuotationResourceSLView,QuotationResourceLotSLView> QuotationResourceLotSLs { get; set; } 
        public IRPSSection<QuotationResourceSLView> SectionGeneral { get; set; } 
        public IRPSSection<QuotationResourceSLView> SectionQuotationResourcesLot { get; set; } 
        public QuotationSL Screen { get; set; }
        public QuotationResourceSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class QuotationResourceLotSLsCollectionEditor<QuotationResourceSLView,QuotationResourceLotSLView>:RPSCollectionEditor<QuotationResourceSLView,QuotationResourceLotSLView> where QuotationResourceSLView : class, IView where QuotationResourceLotSLView : class, IView
    {
        public  QuotationResourceLotSLsGridView<QuotationResourceSLView,QuotationResourceLotSLView> GridView {get;set;}
    }
    public partial class QuotationResourceLotSLsGridView <QuotationResourceSLView,QuotationResourceLotSLView> :  RPSGridView<QuotationResourceSLView,QuotationResourceLotSLView> where QuotationResourceSLView : class, IView where QuotationResourceLotSLView : class, IView
    {
        public QuotationResourceLotSLsGridView(QuotationResourceSLView currentView,QuotationResourceLotSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationResourceSLView>("","#ecd090d6-eafd-480b-93d5-a1659bf49ca3 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            Duration = RPSControlFactory.CreateRPSGridDurationTextBox<QuotationResourceSLView>("","#ecd090d6-eafd-480b-93d5-a1659bf49ca3 .ag-row[role='row']@ROWINDEX [col-id='cDuration']","",true, this.CurrentView);
 
            DedicationPercent = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationResourceSLView>("","#ecd090d6-eafd-480b-93d5-a1659bf49ca3 .ag-row[role='row']@ROWINDEX [col-id='cDedicationPercent']","",true, this.CurrentView);
 
            CostAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationResourceSLView>("","#ecd090d6-eafd-480b-93d5-a1659bf49ca3 .ag-row[role='row']@ROWINDEX [col-id='cCostAmount']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<QuotationResourceSLView> Quantity { get; set; } 
        public IRPSGridDurationTextBox<QuotationResourceSLView> Duration { get; set; } 
        public IRPSGridTextBox<QuotationResourceSLView> DedicationPercent { get; set; } 
        public IRPSGridTextBox<QuotationResourceSLView> CostAmount { get; set; } 
                     
    }
 
    }
  
            
    public partial class QuotationOtherCostSLView : View
    {
        public QuotationOtherCostSLView(QuotationSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<QuotationOtherCostSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<QuotationOtherCostSLView,QuotationSLEntityView>( this,Screen.QuotationSLEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<QuotationOtherCostSLView,QuotationSLEntityView>( this,Screen.QuotationSLEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<QuotationOtherCostSLView,QuotationSLEntityView>( this,Screen.QuotationSLEntityView);
 
            Order = RPSControlFactory.CreateRPSFormattedTextBox<QuotationOtherCostSLView>("bef9be47-e050-444c-9d4f-16fdd0fa3899","","",true, this);
 
            IDCostComponent = RPSControlFactory.CreateRPSComboBox<QuotationOtherCostSLView>("b8a6b914-4be7-48cb-bc1f-cac1fdd36400","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<QuotationOtherCostSLView>("d96df423-0ad0-45e2-9945-6b4a5b5b17eb","","",true, this);
 
            CostPrice = RPSControlFactory.CreateRPSFormattedTextBox<QuotationOtherCostSLView>("cc399a88-162f-425d-be14-2ccda47b7ccf","","",true, this);
 
            CostAmount = RPSControlFactory.CreateRPSFormattedTextBox<QuotationOtherCostSLView>("327a875c-ba73-43d4-9a5f-fd9235e8ddac","","",true, this);
 

        }
        public IRPSButton<QuotationOtherCostSLView> DeleteButton { get; set; } 
        public IRPSButton<QuotationOtherCostSLView,QuotationSLEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<QuotationOtherCostSLView,QuotationSLEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<QuotationOtherCostSLView,QuotationSLEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<QuotationOtherCostSLView> Order { get; set; } 
        public IRPSComboBox<QuotationOtherCostSLView> IDCostComponent { get; set; } 
        public IRPSTextBox<QuotationOtherCostSLView> Quantity { get; set; } 
        public IRPSTextBox<QuotationOtherCostSLView> CostPrice { get; set; } 
        public IRPSTextBox<QuotationOtherCostSLView> CostAmount { get; set; } 
        public QuotationSL Screen { get; set; }
        public QuotationOtherCostSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class QuotationOverChargeSLView : View
    {
        public QuotationOverChargeSLView(QuotationSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<QuotationOverChargeSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<QuotationOverChargeSLView,QuotationSLEntityView>( this,Screen.QuotationSLEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<QuotationOverChargeSLView,QuotationSLEntityView>( this,Screen.QuotationSLEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<QuotationOverChargeSLView,QuotationSLEntityView>( this,Screen.QuotationSLEntityView);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<QuotationOverChargeSLView>("7dcd0a43-f0e6-4430-8add-28c601d6a862","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<QuotationOverChargeSLView>("3cfca904-99fc-4a01-8025-fbffcbe8774b","","",false, this);
 
            Apply = RPSControlFactory.CreateRPSEnumComboBox<QuotationOverChargeSLView>("fcb51f97-7d21-49c0-a406-5383c83e3b3a","","",true, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<QuotationOverChargeSLView>("c065753f-b90b-492e-b366-5e9c4a9935a7","","",true, this);
 
            Cascade = RPSControlFactory.CreateRPSCheckBox<QuotationOverChargeSLView>("37d119d3-e21f-4f90-87c4-6cecd9c8e691","","",true, this);
 
            Value = RPSControlFactory.CreateRPSFormattedTextBox<QuotationOverChargeSLView>("ed2cdb1d-8416-49d8-91e1-a4f9dcfc8d41","","",true, this);
 
            Proportional = RPSControlFactory.CreateRPSCheckBox<QuotationOverChargeSLView>("bcd7a6bb-84f7-41f9-bb8d-19dc2700298e","","",true, this);
 
            Base = RPSControlFactory.CreateRPSFormattedTextBox<QuotationOverChargeSLView>("cbf8acf1-4317-42d3-b094-de06a7aa992a","","",true, this);
 
            CostAmount = RPSControlFactory.CreateRPSFormattedTextBox<QuotationOverChargeSLView>("b830b6e2-27f6-4dbd-888e-fa7203aaff69","","",true, this);
 

        }
        public IRPSButton<QuotationOverChargeSLView> DeleteButton { get; set; } 
        public IRPSButton<QuotationOverChargeSLView,QuotationSLEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<QuotationOverChargeSLView,QuotationSLEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<QuotationOverChargeSLView,QuotationSLEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<QuotationOverChargeSLView> Quantity { get; set; } 
        public IRPSTextBox<QuotationOverChargeSLView> Description { get; set; } 
        public IRPSComboBox<QuotationOverChargeSLView> Apply { get; set; } 
        public IRPSComboBox<QuotationOverChargeSLView> Type { get; set; } 
        public IRPSCheckbox<QuotationOverChargeSLView> Cascade { get; set; } 
        public IRPSTextBox<QuotationOverChargeSLView> Value { get; set; } 
        public IRPSCheckbox<QuotationOverChargeSLView> Proportional { get; set; } 
        public IRPSTextBox<QuotationOverChargeSLView> Base { get; set; } 
        public IRPSTextBox<QuotationOverChargeSLView> CostAmount { get; set; } 
        public QuotationSL Screen { get; set; }
        public QuotationOverChargeSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class QuotationCopyDialogView : View
    {
        public QuotationCopyDialogView(QuotationSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDQuotation = RPSControlFactory.CreateRPSComboBox<QuotationCopyDialogView>("da92d34d-86ee-4f8a-9a2c-cc1a4f8d1aff","","",false, this);
 
            CodQuotation = RPSControlFactory.CreateRPSTextBox<QuotationCopyDialogView>("5d4a9442-feaa-4fdb-ba44-907820baef90","","",false, this);
 
            SelectedDate = RPSControlFactory.CreateRPSTextBox<QuotationCopyDialogView>("afe9b63f-ca72-4924-8d51-c45ced006ef8","","",false, this);
 
            CopyDocuments = RPSControlFactory.CreateRPSCheckBox<QuotationCopyDialogView>("48916afb-465c-45c7-9a96-509da35883d0","","",false, this);
 

        }
        public IRPSComboBox<QuotationCopyDialogView> IDQuotation { get; set; } 
        public IRPSTextBox<QuotationCopyDialogView> CodQuotation { get; set; } 
        public IRPSTextBox<QuotationCopyDialogView> SelectedDate { get; set; } 
        public IRPSCheckbox<QuotationCopyDialogView> CopyDocuments { get; set; } 
        public QuotationSL Screen { get; set; }
        public QuotationCopyDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class QuotationCreateArticleDialogView : View
    {
        public QuotationCreateArticleDialogView(QuotationSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            OptionNewArticle = RPSControlFactory.CreateRPSOption<QuotationCreateArticleDialogView>( "08bdbc8b-dfe9-496a-9de3-5203ada37ff9","","",this);
 
            CodArticle = RPSControlFactory.CreateRPSTextBox<QuotationCreateArticleDialogView>("f8eb390e-c054-4373-91a1-09f435df3b8c","","",false, this);
 
            OptionSameArticle = RPSControlFactory.CreateRPSOption<QuotationCreateArticleDialogView>( "26f2f1c2-671b-4525-87ee-ffdd8f157819","","",this);
 

        }
        public IRPSOption<QuotationCreateArticleDialogView> OptionNewArticle { get; set; } 
        public IRPSTextBox<QuotationCreateArticleDialogView> CodArticle { get; set; } 
        public IRPSOption<QuotationCreateArticleDialogView> OptionSameArticle { get; set; } 
        public QuotationSL Screen { get; set; }
        public QuotationCreateArticleDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class QuotationCreateStructureDialogView : View
    {
        public QuotationCreateStructureDialogView(QuotationSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDSite = RPSControlFactory.CreateRPSComboBox<QuotationCreateStructureDialogView>("1bc185eb-9689-47b8-b54d-1736f38efd4d","","",false, this);
 
            LotString = RPSControlFactory.CreateRPSEnumComboBox<QuotationCreateStructureDialogView>("c175dba7-65a6-41f2-aa7f-b15cfb3a05c0","","",false, this);
 
            CreateNew = RPSControlFactory.CreateRPSOption<QuotationCreateStructureDialogView>( "e979a520-e735-4ac9-96cc-f72dab93eba0","","",this);
 
            Version = RPSControlFactory.CreateRPSTextBox<QuotationCreateStructureDialogView>("be8e1f2b-c9f0-4bd3-b88e-427d0ec71a60","","",false, this);
 
            Update = RPSControlFactory.CreateRPSOption<QuotationCreateStructureDialogView>( "4314b5e8-ec00-4c3e-bd5d-7ca87cc949d5","","",this);
 
            VersionUpdate = RPSControlFactory.CreateRPSEnumComboBox<QuotationCreateStructureDialogView>("f5c32a27-6597-47d1-9efc-3f5d33521ca6","","",false, this);
 

        }
        public IRPSComboBox<QuotationCreateStructureDialogView> IDSite { get; set; } 
        public IRPSComboBox<QuotationCreateStructureDialogView> LotString { get; set; } 
        public IRPSOption<QuotationCreateStructureDialogView> CreateNew { get; set; } 
        public IRPSTextBox<QuotationCreateStructureDialogView> Version { get; set; } 
        public IRPSOption<QuotationCreateStructureDialogView> Update { get; set; } 
        public IRPSComboBox<QuotationCreateStructureDialogView> VersionUpdate { get; set; } 
        public QuotationSL Screen { get; set; }
        public QuotationCreateStructureDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class QuotationRelatedSalesQuotesDialogView : View
    {
        public QuotationRelatedSalesQuotesDialogView(QuotationSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_QuotationRelatedSalesQuotes = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1cabc609-e172-4438-b0e2-2d5e2dd8cfe5",CSSSelectorGrid="",XPathGrid=""};
            QuotationRelatedSalesQuotes = RPSControlFactory.RPSCreateCollectionWithGrid<QuotationRelatedSalesQuotesCollectionEditor<QuotationRelatedSalesQuotesDialogView>,QuotationRelatedSalesQuotesDialogView>( params_QuotationRelatedSalesQuotes,this);
 

        }
        public QuotationRelatedSalesQuotesCollectionEditor<QuotationRelatedSalesQuotesDialogView> QuotationRelatedSalesQuotes { get; set; } 
        public QuotationSL Screen { get; set; }
        public QuotationRelatedSalesQuotesDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class QuotationRelatedSalesQuotesCollectionEditor<QuotationRelatedSalesQuotesDialogView>:RPSCollectionEditor<QuotationRelatedSalesQuotesDialogView> where QuotationRelatedSalesQuotesDialogView : class, IView
    {
        public  QuotationRelatedSalesQuotesGridView<QuotationRelatedSalesQuotesDialogView> GridView {get;set;}
    }
    public partial class QuotationRelatedSalesQuotesGridView <QuotationRelatedSalesQuotesDialogView> :  RPSGridView<QuotationRelatedSalesQuotesDialogView> where QuotationRelatedSalesQuotesDialogView : class, IView
    {
        public QuotationRelatedSalesQuotesGridView(QuotationRelatedSalesQuotesDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            SalesQuoteLineSL_Ordenation = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationRelatedSalesQuotesDialogView>("","#1cabc609-e172-4438-b0e2-2d5e2dd8cfe5 .ag-row[role='row']@ROWINDEX [col-id='cSalesQuoteLineSL_Ordenation']","",false, this.CurrentView);
 
            SalesQuoteSL_SalesQuoteDate = RPSControlFactory.CreateRPSGridTextBox<QuotationRelatedSalesQuotesDialogView>("","#1cabc609-e172-4438-b0e2-2d5e2dd8cfe5 .ag-row[role='row']@ROWINDEX [col-id='cSalesQuoteSL_SalesQuoteDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<QuotationRelatedSalesQuotesDialogView> SalesQuoteLineSL_Ordenation { get; set; } 
        public IRPSGridTextBox<QuotationRelatedSalesQuotesDialogView> SalesQuoteSL_SalesQuoteDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class QuotationFromStructureDialogView : View
    {
        public QuotationFromStructureDialogView(QuotationSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Code = RPSControlFactory.CreateRPSTextBox<QuotationFromStructureDialogView>("7dfd04c5-404c-4914-b2b7-11877a2ccabf","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<QuotationFromStructureDialogView>("1defceaa-67fa-41c7-b04b-a909b6fc1bae","","",true, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<QuotationFromStructureDialogView>("23ea534d-ad6e-4408-a3e9-1792648a060f","","",true, this);
 
            Version = RPSControlFactory.CreateRPSEnumComboBox<QuotationFromStructureDialogView>("09fdfd34-3d8a-4326-9762-218817c02189","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<QuotationFromStructureDialogView>("555c8322-2b0d-431a-9301-b3fee44a9e6d","","",true, this);
 

        }
        public IRPSTextBox<QuotationFromStructureDialogView> Code { get; set; } 
        public IRPSComboBox<QuotationFromStructureDialogView> IDArticle { get; set; } 
        public IRPSComboBox<QuotationFromStructureDialogView> IDSite { get; set; } 
        public IRPSComboBox<QuotationFromStructureDialogView> Version { get; set; } 
        public IRPSTextBox<QuotationFromStructureDialogView> Quantity { get; set; } 
        public QuotationSL Screen { get; set; }
        public QuotationFromStructureDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class QuotationFeatureSLView : View
    {
        public QuotationFeatureSLView(QuotationSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<QuotationFeatureSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<QuotationFeatureSLView,QuotationSLEntityView>( this,Screen.QuotationSLEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<QuotationFeatureSLView,QuotationSLEntityView>( this,Screen.QuotationSLEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<QuotationFeatureSLView,QuotationSLEntityView>( this,Screen.QuotationSLEntityView);
 
            IDArticleLabel = RPSControlFactory.CreateRPSComboBox<QuotationFeatureSLView>("8eab0d38-6590-4c1b-aa16-d6b25cef4626","","",false, this);
 

        }
        public IRPSButton<QuotationFeatureSLView> DeleteButton { get; set; } 
        public IRPSButton<QuotationFeatureSLView,QuotationSLEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<QuotationFeatureSLView,QuotationSLEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<QuotationFeatureSLView,QuotationSLEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<QuotationFeatureSLView> IDArticleLabel { get; set; } 
        public QuotationSL Screen { get; set; }
        public QuotationFeatureSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class QuotationAddUsualTaskDialogView : View
    {
        public QuotationAddUsualTaskDialogView(QuotationSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UsualTaskSTR = RPSControlFactory.CreateRPSComboBox<QuotationAddUsualTaskDialogView>("628c972f-98e5-4968-aea6-661fb691eb6a","","",false, this);
 

        }
        public IRPSComboBox<QuotationAddUsualTaskDialogView> UsualTaskSTR { get; set; } 
        public QuotationSL Screen { get; set; }
        public QuotationAddUsualTaskDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NewChildDialogView : View
    {
        public NewChildDialogView(QuotationSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<NewChildDialogView>("3148fb47-4a9d-40cd-97b6-9d0bab1d85ce","","",true, this);
 

        }
        public IRPSTextBox<NewChildDialogView> Quantity { get; set; } 
        public QuotationSL Screen { get; set; }
        public NewChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NewFromOpportunityDialogView : View
    {
        public NewFromOpportunityDialogView(QuotationSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Oportunity = RPSControlFactory.CreateRPSOption<NewFromOpportunityDialogView>( "e18a66cd-0a29-4b5f-868e-2dc2799adf36","","",this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<NewFromOpportunityDialogView>("82d537be-5dd7-42db-bd83-88a7fa8a9d7e","","",true, this);
 
            OportunityStructure = RPSControlFactory.CreateRPSOption<NewFromOpportunityDialogView>( "e1a4fb04-b406-4897-b555-c833b1338ce5","","",this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<NewFromOpportunityDialogView>("9d0656c7-60fb-46be-bb56-35b464362c60","","",true, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<NewFromOpportunityDialogView>("2e38ffac-684f-4760-a731-6308a3db5628","","",true, this);
 
            Version = RPSControlFactory.CreateRPSEnumComboBox<NewFromOpportunityDialogView>("884b88fc-c2b1-4b43-b60c-4ab6bc8227e2","","",true, this);
 
            Quantity2 = RPSControlFactory.CreateRPSFormattedTextBox<NewFromOpportunityDialogView>("6d1f37f1-89f6-4e50-bdaf-80af21eb1f3e","","",true, this);
 

        }
        public IRPSOption<NewFromOpportunityDialogView> Oportunity { get; set; } 
        public IRPSTextBox<NewFromOpportunityDialogView> Quantity { get; set; } 
        public IRPSOption<NewFromOpportunityDialogView> OportunityStructure { get; set; } 
        public IRPSComboBox<NewFromOpportunityDialogView> IDArticle { get; set; } 
        public IRPSComboBox<NewFromOpportunityDialogView> IDSite { get; set; } 
        public IRPSComboBox<NewFromOpportunityDialogView> Version { get; set; } 
        public IRPSTextBox<NewFromOpportunityDialogView> Quantity2 { get; set; } 
        public QuotationSL Screen { get; set; }
        public NewFromOpportunityDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class QuotationMaterialLotSLView : View
    {
        public QuotationMaterialLotSLView(QuotationSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<QuotationMaterialLotSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<QuotationMaterialLotSLView,QuotationMaterialSLView>( this,Screen.QuotationMaterialSLView);
 
            BackButton = RPSControlFactory.RPSBackButton<QuotationMaterialLotSLView,QuotationMaterialSLView>( this,Screen.QuotationMaterialSLView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<QuotationMaterialLotSLView,QuotationMaterialSLView>( this,Screen.QuotationMaterialSLView);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<QuotationMaterialLotSLView>("defad9d7-8359-46a2-b0da-02ae98b012eb","","",true, this);
 
            QuantityMaterial = RPSControlFactory.CreateRPSFormattedTextBox<QuotationMaterialLotSLView>("68a5f9df-1802-4380-8f46-bcbf145ea861","","",true, this);
 
            CostPrice = RPSControlFactory.CreateRPSFormattedTextBox<QuotationMaterialLotSLView>("08190e00-08c3-41ec-aa41-b01de9526495","","",true, this);
 
            CostAmount = RPSControlFactory.CreateRPSFormattedTextBox<QuotationMaterialLotSLView>("c98f9cf2-5962-4e9e-81ba-e6f4cc56a5fd","","",true, this);
 

        }
        public IRPSButton<QuotationMaterialLotSLView> DeleteButton { get; set; } 
        public IRPSButton<QuotationMaterialLotSLView,QuotationMaterialSLView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<QuotationMaterialLotSLView,QuotationMaterialSLView> BackButton { get; set; } 
        public IRPSAcceptButton<QuotationMaterialLotSLView,QuotationMaterialSLView> AcceptButton { get; set; } 
        public IRPSTextBox<QuotationMaterialLotSLView> Quantity { get; set; } 
        public IRPSTextBox<QuotationMaterialLotSLView> QuantityMaterial { get; set; } 
        public IRPSTextBox<QuotationMaterialLotSLView> CostPrice { get; set; } 
        public IRPSTextBox<QuotationMaterialLotSLView> CostAmount { get; set; } 
        public QuotationSL Screen { get; set; }
        public QuotationMaterialLotSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class QuotationMaterialLotChildDialogView : View
    {
        public QuotationMaterialLotChildDialogView(QuotationSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSComboBox<QuotationMaterialLotChildDialogView>("8c852ef1-765d-4fd9-b620-0661c9b1366c","","",false, this);
 
            IDQuotationAssembly = RPSControlFactory.CreateRPSComboBox<QuotationMaterialLotChildDialogView>("b96ccedb-5355-4009-8b37-b335b49a9327","","",false, this);
 
            CollectionInit params_QuotationMaterialLotSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b1e7478c-acb3-4d05-acc0-1e8e8b200937",CSSSelectorGrid="",XPathGrid=""};
            QuotationMaterialLotSLs = RPSControlFactory.RPSCreateCollectionWithGrid<QuotationMaterialLotSLsCollectionEditor<QuotationMaterialLotChildDialogView>,QuotationMaterialLotChildDialogView>( params_QuotationMaterialLotSLs,this);
 

        }
        public IRPSComboBox<QuotationMaterialLotChildDialogView> IDArticle { get; set; } 
        public IRPSComboBox<QuotationMaterialLotChildDialogView> IDQuotationAssembly { get; set; } 
        public QuotationMaterialLotSLsCollectionEditor<QuotationMaterialLotChildDialogView> QuotationMaterialLotSLs { get; set; } 
        public QuotationSL Screen { get; set; }
        public QuotationMaterialLotChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class QuotationMaterialLotSLsCollectionEditor<QuotationMaterialLotChildDialogView>:RPSCollectionEditor<QuotationMaterialLotChildDialogView> where QuotationMaterialLotChildDialogView : class, IView
    {
        public  QuotationMaterialLotSLsGridView1<QuotationMaterialLotChildDialogView> GridView1 {get;set;}
    }
    public partial class QuotationMaterialLotSLsGridView1 <QuotationMaterialLotChildDialogView> :  RPSGridView<QuotationMaterialLotChildDialogView> where QuotationMaterialLotChildDialogView : class, IView
    {
        public QuotationMaterialLotSLsGridView1(QuotationMaterialLotChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationMaterialLotChildDialogView>("","#b1e7478c-acb3-4d05-acc0-1e8e8b200937 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            QuantityMaterial = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationMaterialLotChildDialogView>("","#b1e7478c-acb3-4d05-acc0-1e8e8b200937 .ag-row[role='row']@ROWINDEX [col-id='cQuantityMaterial']","",true, this.CurrentView);
 
            CostPrice = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationMaterialLotChildDialogView>("","#b1e7478c-acb3-4d05-acc0-1e8e8b200937 .ag-row[role='row']@ROWINDEX [col-id='cCostPrice']","",true, this.CurrentView);
 
            CostAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationMaterialLotChildDialogView>("","#b1e7478c-acb3-4d05-acc0-1e8e8b200937 .ag-row[role='row']@ROWINDEX [col-id='cCostAmount']","",true, this.CurrentView);
 
            IDSupplierRequestQuotationLine = RPSControlFactory.CreateRPSGridComboBox<QuotationMaterialLotChildDialogView>("","#b1e7478c-acb3-4d05-acc0-1e8e8b200937 .ag-row[role='row']@ROWINDEX [col-id='cIDSupplierRequestQuotationLine']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<QuotationMaterialLotChildDialogView> Quantity { get; set; } 
        public IRPSGridTextBox<QuotationMaterialLotChildDialogView> QuantityMaterial { get; set; } 
        public IRPSGridTextBox<QuotationMaterialLotChildDialogView> CostPrice { get; set; } 
        public IRPSGridTextBox<QuotationMaterialLotChildDialogView> CostAmount { get; set; } 
        public IRPSGridComboBox<QuotationMaterialLotChildDialogView> IDSupplierRequestQuotationLine { get; set; } 
                     
    }
 
    }
  
            
    public partial class QuotationTaskLotChildDialogView : View
    {
        public QuotationTaskLotChildDialogView(QuotationSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Description = RPSControlFactory.CreateRPSTextBox<QuotationTaskLotChildDialogView>("b15d9547-6ba9-4af5-9ab7-0234af1c13ec","","",false, this);
 
            CollectionInit params_QuotationTaskLotSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="58d0a6f2-ce71-4fc1-91dd-0e69ac9eabfb",CSSSelectorGrid="",XPathGrid=""};
            QuotationTaskLotSLs = RPSControlFactory.RPSCreateCollectionWithGrid<QuotationTaskLotSLsCollectionEditor<QuotationTaskLotChildDialogView>,QuotationTaskLotChildDialogView>( params_QuotationTaskLotSLs,this);
 

        }
        public IRPSTextBox<QuotationTaskLotChildDialogView> Description { get; set; } 
        public QuotationTaskLotSLsCollectionEditor<QuotationTaskLotChildDialogView> QuotationTaskLotSLs { get; set; } 
        public QuotationSL Screen { get; set; }
        public QuotationTaskLotChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class QuotationTaskLotSLsCollectionEditor<QuotationTaskLotChildDialogView>:RPSCollectionEditor<QuotationTaskLotChildDialogView> where QuotationTaskLotChildDialogView : class, IView
    {
        public  QuotationTaskLotSLsGridView1<QuotationTaskLotChildDialogView> GridView1 {get;set;}
    }
    public partial class QuotationTaskLotSLsGridView1 <QuotationTaskLotChildDialogView> :  RPSGridView<QuotationTaskLotChildDialogView> where QuotationTaskLotChildDialogView : class, IView
    {
        public QuotationTaskLotSLsGridView1(QuotationTaskLotChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationTaskLotChildDialogView>("","#58d0a6f2-ce71-4fc1-91dd-0e69ac9eabfb .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            PreparationTime = RPSControlFactory.CreateRPSGridDurationTextBox<QuotationTaskLotChildDialogView>("","#58d0a6f2-ce71-4fc1-91dd-0e69ac9eabfb .ag-row[role='row']@ROWINDEX [col-id='cPreparationTime']","",true, this.CurrentView);
 
            ExecutionTime = RPSControlFactory.CreateRPSGridDurationTextBox<QuotationTaskLotChildDialogView>("","#58d0a6f2-ce71-4fc1-91dd-0e69ac9eabfb .ag-row[role='row']@ROWINDEX [col-id='cExecutionTime']","",true, this.CurrentView);
 
            QuantityExternalTask = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationTaskLotChildDialogView>("","#58d0a6f2-ce71-4fc1-91dd-0e69ac9eabfb .ag-row[role='row']@ROWINDEX [col-id='cQuantityExternalTask']","",true, this.CurrentView);
 
            CostPrice = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationTaskLotChildDialogView>("","#58d0a6f2-ce71-4fc1-91dd-0e69ac9eabfb .ag-row[role='row']@ROWINDEX [col-id='cCostPrice']","",true, this.CurrentView);
 
            CostAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationTaskLotChildDialogView>("","#58d0a6f2-ce71-4fc1-91dd-0e69ac9eabfb .ag-row[role='row']@ROWINDEX [col-id='cCostAmount']","",true, this.CurrentView);
 
            IDSupplierRequestQuotationLine = RPSControlFactory.CreateRPSGridComboBox<QuotationTaskLotChildDialogView>("","#58d0a6f2-ce71-4fc1-91dd-0e69ac9eabfb .ag-row[role='row']@ROWINDEX [col-id='cIDSupplierRequestQuotationLine']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<QuotationTaskLotChildDialogView> Quantity { get; set; } 
        public IRPSGridDurationTextBox<QuotationTaskLotChildDialogView> PreparationTime { get; set; } 
        public IRPSGridDurationTextBox<QuotationTaskLotChildDialogView> ExecutionTime { get; set; } 
        public IRPSGridTextBox<QuotationTaskLotChildDialogView> QuantityExternalTask { get; set; } 
        public IRPSGridTextBox<QuotationTaskLotChildDialogView> CostPrice { get; set; } 
        public IRPSGridTextBox<QuotationTaskLotChildDialogView> CostAmount { get; set; } 
        public IRPSGridComboBox<QuotationTaskLotChildDialogView> IDSupplierRequestQuotationLine { get; set; } 
                     
    }
 
    }
  
            
    public partial class QuotationTaskLotSLView : View
    {
        public QuotationTaskLotSLView(QuotationSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<QuotationTaskLotSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<QuotationTaskLotSLView,QuotationTaskSLView>( this,Screen.QuotationTaskSLView);
 
            BackButton = RPSControlFactory.RPSBackButton<QuotationTaskLotSLView,QuotationTaskSLView>( this,Screen.QuotationTaskSLView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<QuotationTaskLotSLView,QuotationTaskSLView>( this,Screen.QuotationTaskSLView);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<QuotationTaskLotSLView>("17441a18-23b6-4389-8a46-9259bea0e41b","","",true, this);
 
            ExecutionTime = RPSControlFactory.CreateRPSDurationTextBox<QuotationTaskLotSLView>("849ca638-d430-4872-a0db-2b6003bb50e7","","",true, this);
 
            PreparationTime = RPSControlFactory.CreateRPSDurationTextBox<QuotationTaskLotSLView>("8fe8c402-117d-40e5-9c45-4db177f14b1e","","",true, this);
 
            QuantityExternalTask = RPSControlFactory.CreateRPSFormattedTextBox<QuotationTaskLotSLView>("e1d32782-85cf-4354-8c6b-dd8c64f385b1","","",true, this);
 
            CostPrice = RPSControlFactory.CreateRPSFormattedTextBox<QuotationTaskLotSLView>("494f21c2-2f89-423c-b53e-b8509bfd7961","","",true, this);
 
            CostAmount = RPSControlFactory.CreateRPSFormattedTextBox<QuotationTaskLotSLView>("5491bfdb-40de-48ea-b26e-f787d23e1496","","",true, this);
 
            IDSupplierRequestQuotationLine = RPSControlFactory.CreateRPSComboBox<QuotationTaskLotSLView>("50c744c4-a58f-4207-b77b-4915a116b9e4","","",false, this);
 

        }
        public IRPSButton<QuotationTaskLotSLView> DeleteButton { get; set; } 
        public IRPSButton<QuotationTaskLotSLView,QuotationTaskSLView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<QuotationTaskLotSLView,QuotationTaskSLView> BackButton { get; set; } 
        public IRPSAcceptButton<QuotationTaskLotSLView,QuotationTaskSLView> AcceptButton { get; set; } 
        public IRPSTextBox<QuotationTaskLotSLView> Quantity { get; set; } 
        public IRPSDurationTextBox<QuotationTaskLotSLView> ExecutionTime { get; set; } 
        public IRPSDurationTextBox<QuotationTaskLotSLView> PreparationTime { get; set; } 
        public IRPSTextBox<QuotationTaskLotSLView> QuantityExternalTask { get; set; } 
        public IRPSTextBox<QuotationTaskLotSLView> CostPrice { get; set; } 
        public IRPSTextBox<QuotationTaskLotSLView> CostAmount { get; set; } 
        public IRPSComboBox<QuotationTaskLotSLView> IDSupplierRequestQuotationLine { get; set; } 
        public QuotationSL Screen { get; set; }
        public QuotationTaskLotSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class QuotationResourceLotChildDialogView : View
    {
        public QuotationResourceLotChildDialogView(QuotationSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDEmployee = RPSControlFactory.CreateRPSComboBox<QuotationResourceLotChildDialogView>("2fb6d64f-ef2a-4876-a1a9-30957d6feeb7","","",false, this);
 
            IDMachine = RPSControlFactory.CreateRPSComboBox<QuotationResourceLotChildDialogView>("6a9b3045-827e-44b0-9b8a-e0440821eb0a","","",false, this);
 
            IDTool = RPSControlFactory.CreateRPSComboBox<QuotationResourceLotChildDialogView>("b50ed3c6-a0a5-46d4-a79d-57056ce405e9","","",false, this);
 
            CollectionInit params_QuotationResourceLotSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ae49fc20-37fd-4165-b9f9-f70a6785e8c8",CSSSelectorGrid="",XPathGrid=""};
            QuotationResourceLotSLs = RPSControlFactory.RPSCreateCollectionWithGrid<QuotationResourceLotSLsCollectionEditor<QuotationResourceLotChildDialogView>,QuotationResourceLotChildDialogView>( params_QuotationResourceLotSLs,this);
 

        }
        public IRPSComboBox<QuotationResourceLotChildDialogView> IDEmployee { get; set; } 
        public IRPSComboBox<QuotationResourceLotChildDialogView> IDMachine { get; set; } 
        public IRPSComboBox<QuotationResourceLotChildDialogView> IDTool { get; set; } 
        public QuotationResourceLotSLsCollectionEditor<QuotationResourceLotChildDialogView> QuotationResourceLotSLs { get; set; } 
        public QuotationSL Screen { get; set; }
        public QuotationResourceLotChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class QuotationResourceLotSLsCollectionEditor<QuotationResourceLotChildDialogView>:RPSCollectionEditor<QuotationResourceLotChildDialogView> where QuotationResourceLotChildDialogView : class, IView
    {
        public  QuotationResourceLotSLsGridView<QuotationResourceLotChildDialogView> GridView {get;set;}
    }
    public partial class QuotationResourceLotSLsGridView <QuotationResourceLotChildDialogView> :  RPSGridView<QuotationResourceLotChildDialogView> where QuotationResourceLotChildDialogView : class, IView
    {
        public QuotationResourceLotSLsGridView(QuotationResourceLotChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationResourceLotChildDialogView>("","#ae49fc20-37fd-4165-b9f9-f70a6785e8c8 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            Duration = RPSControlFactory.CreateRPSGridDurationTextBox<QuotationResourceLotChildDialogView>("","#ae49fc20-37fd-4165-b9f9-f70a6785e8c8 .ag-row[role='row']@ROWINDEX [col-id='cDuration']","",true, this.CurrentView);
 
            DedicationPercent = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationResourceLotChildDialogView>("","#ae49fc20-37fd-4165-b9f9-f70a6785e8c8 .ag-row[role='row']@ROWINDEX [col-id='cDedicationPercent']","",true, this.CurrentView);
 
            CostAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<QuotationResourceLotChildDialogView>("","#ae49fc20-37fd-4165-b9f9-f70a6785e8c8 .ag-row[role='row']@ROWINDEX [col-id='cCostAmount']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<QuotationResourceLotChildDialogView> Quantity { get; set; } 
        public IRPSGridDurationTextBox<QuotationResourceLotChildDialogView> Duration { get; set; } 
        public IRPSGridTextBox<QuotationResourceLotChildDialogView> DedicationPercent { get; set; } 
        public IRPSGridTextBox<QuotationResourceLotChildDialogView> CostAmount { get; set; } 
                     
    }
 
    }
  
            
    public partial class QuotationResourceLotSLView : View
    {
        public QuotationResourceLotSLView(QuotationSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<QuotationResourceLotSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<QuotationResourceLotSLView,QuotationResourceSLView>( this,Screen.QuotationResourceSLView);
 
            BackButton = RPSControlFactory.RPSBackButton<QuotationResourceLotSLView,QuotationResourceSLView>( this,Screen.QuotationResourceSLView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<QuotationResourceLotSLView,QuotationResourceSLView>( this,Screen.QuotationResourceSLView);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<QuotationResourceLotSLView>("d1f6c096-e088-4c81-9750-a07e2547c4eb","","",true, this);
 
            Duration = RPSControlFactory.CreateRPSDurationTextBox<QuotationResourceLotSLView>("3bfac1b2-0124-4a51-bd2d-2971551e5936","","",true, this);
 
            DedicationPercent = RPSControlFactory.CreateRPSFormattedTextBox<QuotationResourceLotSLView>("5c0bd1ac-7278-4fdd-8ec9-c9942613df8f","","",true, this);
 
            CostAmount = RPSControlFactory.CreateRPSFormattedTextBox<QuotationResourceLotSLView>("ace86a7f-e22f-4b7e-9895-71abe69e00d6","","",true, this);
 

        }
        public IRPSButton<QuotationResourceLotSLView> DeleteButton { get; set; } 
        public IRPSButton<QuotationResourceLotSLView,QuotationResourceSLView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<QuotationResourceLotSLView,QuotationResourceSLView> BackButton { get; set; } 
        public IRPSAcceptButton<QuotationResourceLotSLView,QuotationResourceSLView> AcceptButton { get; set; } 
        public IRPSTextBox<QuotationResourceLotSLView> Quantity { get; set; } 
        public IRPSDurationTextBox<QuotationResourceLotSLView> Duration { get; set; } 
        public IRPSTextBox<QuotationResourceLotSLView> DedicationPercent { get; set; } 
        public IRPSTextBox<QuotationResourceLotSLView> CostAmount { get; set; } 
        public QuotationSL Screen { get; set; }
        public QuotationResourceLotSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NewSupplierRQChildDialogView : View
    {
        public NewSupplierRQChildDialogView(QuotationSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Single = RPSControlFactory.CreateRPSOption<NewSupplierRQChildDialogView>( "637ee06f-ed9d-4399-a8fc-b7833da0c49a","","",this);
 
            Break = RPSControlFactory.CreateRPSOption<NewSupplierRQChildDialogView>( "60f4d91c-584d-4bbc-9124-a9ed8366356a","","",this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<NewSupplierRQChildDialogView>("68ddd422-09ef-45e9-9234-003531dfaf8a","","",false, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<NewSupplierRQChildDialogView>("82407625-c99a-4754-8955-18f0499d90b6","","",false, this);
 
            AllLots = RPSControlFactory.CreateRPSCheckBox<NewSupplierRQChildDialogView>("2b6eb4a4-e52a-4198-92f0-d541c242c053","","",false, this);
 
            NewCode = RPSControlFactory.CreateRPSTextBox<NewSupplierRQChildDialogView>("6310837a-d8d9-47fa-9eb2-8c1ea5b959fb","","",false, this);
 

        }
        public IRPSOption<NewSupplierRQChildDialogView> Single { get; set; } 
        public IRPSOption<NewSupplierRQChildDialogView> Break { get; set; } 
        public IRPSComboBox<NewSupplierRQChildDialogView> IDSupplier { get; set; } 
        public IRPSTextBox<NewSupplierRQChildDialogView> Date { get; set; } 
        public IRPSCheckbox<NewSupplierRQChildDialogView> AllLots { get; set; } 
        public IRPSTextBox<NewSupplierRQChildDialogView> NewCode { get; set; } 
        public QuotationSL Screen { get; set; }
        public NewSupplierRQChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NewSupplierRQFromTaskChildDialogView : View
    {
        public NewSupplierRQFromTaskChildDialogView(QuotationSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Single = RPSControlFactory.CreateRPSOption<NewSupplierRQFromTaskChildDialogView>( "a4e157e4-2753-4b0c-bc03-7429e97743e4","","",this);
 
            Break = RPSControlFactory.CreateRPSOption<NewSupplierRQFromTaskChildDialogView>( "cfe3a63f-59d0-4552-adc3-efee7be6a328","","",this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<NewSupplierRQFromTaskChildDialogView>("591a3785-e4b8-419a-bacb-d33162f98e3e","","",false, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<NewSupplierRQFromTaskChildDialogView>("a88257e2-76fe-463f-adf6-ad3e1accda56","","",false, this);
 
            AllLots = RPSControlFactory.CreateRPSCheckBox<NewSupplierRQFromTaskChildDialogView>("a49e2adf-bff3-4079-8988-0a78c95f2e0c","","",false, this);
 
            NewCode = RPSControlFactory.CreateRPSTextBox<NewSupplierRQFromTaskChildDialogView>("ac3b9778-daf2-4124-af72-60345707b7f8","","",false, this);
 

        }
        public IRPSOption<NewSupplierRQFromTaskChildDialogView> Single { get; set; } 
        public IRPSOption<NewSupplierRQFromTaskChildDialogView> Break { get; set; } 
        public IRPSComboBox<NewSupplierRQFromTaskChildDialogView> IDSupplier { get; set; } 
        public IRPSTextBox<NewSupplierRQFromTaskChildDialogView> Date { get; set; } 
        public IRPSCheckbox<NewSupplierRQFromTaskChildDialogView> AllLots { get; set; } 
        public IRPSTextBox<NewSupplierRQFromTaskChildDialogView> NewCode { get; set; } 
        public QuotationSL Screen { get; set; }
        public NewSupplierRQFromTaskChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CuDistDetailOfMaterialsPopUpDialogView : View
    {
        public CuDistDetailOfMaterialsPopUpDialogView(QuotationSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NumCuts = RPSControlFactory.CreateRPSFormattedTextBox<CuDistDetailOfMaterialsPopUpDialogView>("c833d60e-823b-46bf-8ab7-f95412d71f9a","","",true, this);
 
            NumParts = RPSControlFactory.CreateRPSFormattedTextBox<CuDistDetailOfMaterialsPopUpDialogView>("5e9896c4-82cb-40d9-b3fe-96858678afd6","","",true, this);
 
            Formula = RPSControlFactory.CreateRPSTextBox<CuDistDetailOfMaterialsPopUpDialogView>("9209a239-07d2-4cbf-81ca-0d0e2ed14dd4","","",false, this);
 
            QuantityCalculated = RPSControlFactory.CreateRPSFormattedTextBox<CuDistDetailOfMaterialsPopUpDialogView>("83fefff4-0f1e-4aac-b498-3cb69c9f6c0f","","",true, this);
 
            SearchMaterialsCommand = RPSControlFactory.CreateRPSButton<CuDistDetailOfMaterialsPopUpDialogView>( "8d4bd94f-e854-4673-b57e-de6ff8a180dc","","",this);
 
            CalculateQuantityCommand = RPSControlFactory.CreateRPSButton<CuDistDetailOfMaterialsPopUpDialogView>( "cc52f5d6-34e0-4eb7-8ed0-b7496f900010","","",this);
 
            InsertMaterialCommand = RPSControlFactory.CreateRPSButton<CuDistDetailOfMaterialsPopUpDialogView>( "936b547e-a846-439f-a64b-4070e21de7eb","","",this);
 
            CloseCommand = RPSControlFactory.CreateRPSButton<CuDistDetailOfMaterialsPopUpDialogView>( "7705b9ac-0899-4958-92e1-0c094d1e473d","","",this);
 
            CollectionInit params_CuDistArticleLabelWithCostCalculationLookup = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="309e2109-5490-496c-ab40-b0280b130079",CSSSelectorGrid="",XPathGrid=""};
            CuDistArticleLabelWithCostCalculationLookup = RPSControlFactory.RPSCreateCollectionWithGrid<CuDistArticleLabelWithCostCalculationLookupCollectionEditor<CuDistDetailOfMaterialsPopUpDialogView>,CuDistDetailOfMaterialsPopUpDialogView>( params_CuDistArticleLabelWithCostCalculationLookup,this);
 
            CollectionInit params_CuDistFeatureArticleValueModelCollection = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a3973c88-5732-471b-b664-f10f55cb9cf2",CSSSelectorGrid="",XPathGrid=""};
            CuDistFeatureArticleValueModelCollection = RPSControlFactory.RPSCreateCollectionWithGrid<CuDistFeatureArticleValueModelCollectionCollectionEditor<CuDistDetailOfMaterialsPopUpDialogView>,CuDistDetailOfMaterialsPopUpDialogView>( params_CuDistFeatureArticleValueModelCollection,this);
 

        }
        public IRPSTextBox<CuDistDetailOfMaterialsPopUpDialogView> NumCuts { get; set; } 
        public IRPSTextBox<CuDistDetailOfMaterialsPopUpDialogView> NumParts { get; set; } 
        public IRPSTextBox<CuDistDetailOfMaterialsPopUpDialogView> Formula { get; set; } 
        public IRPSTextBox<CuDistDetailOfMaterialsPopUpDialogView> QuantityCalculated { get; set; } 
        public IRPSButton<CuDistDetailOfMaterialsPopUpDialogView> SearchMaterialsCommand { get; set; } 
        public IRPSButton<CuDistDetailOfMaterialsPopUpDialogView> CalculateQuantityCommand { get; set; } 
        public IRPSButton<CuDistDetailOfMaterialsPopUpDialogView> InsertMaterialCommand { get; set; } 
        public IRPSButton<CuDistDetailOfMaterialsPopUpDialogView> CloseCommand { get; set; } 
        public CuDistArticleLabelWithCostCalculationLookupCollectionEditor<CuDistDetailOfMaterialsPopUpDialogView> CuDistArticleLabelWithCostCalculationLookup { get; set; } 
        public CuDistFeatureArticleValueModelCollectionCollectionEditor<CuDistDetailOfMaterialsPopUpDialogView> CuDistFeatureArticleValueModelCollection { get; set; } 
        public QuotationSL Screen { get; set; }
        public CuDistDetailOfMaterialsPopUpDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CuDistArticleLabelWithCostCalculationLookupCollectionEditor<CuDistDetailOfMaterialsPopUpDialogView>:RPSCollectionEditor<CuDistDetailOfMaterialsPopUpDialogView> where CuDistDetailOfMaterialsPopUpDialogView : class, IView
    {
        public  CuDistArticleLabelWithCostCalculationLookupGridView<CuDistDetailOfMaterialsPopUpDialogView> GridView {get;set;}
    }
    public partial class CuDistArticleLabelWithCostCalculationLookupGridView <CuDistDetailOfMaterialsPopUpDialogView> :  RPSGridView<CuDistDetailOfMaterialsPopUpDialogView> where CuDistDetailOfMaterialsPopUpDialogView : class, IView
    {
        public CuDistArticleLabelWithCostCalculationLookupGridView(CuDistDetailOfMaterialsPopUpDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ArticleLabel_Description = RPSControlFactory.CreateRPSGridTextBox<CuDistDetailOfMaterialsPopUpDialogView>("","#309e2109-5490-496c-ab40-b0280b130079 .ag-row[role='row']@ROWINDEX [col-id='cArticleLabel_Description']","",false, this.CurrentView);
 
            ValueInteger = RPSControlFactory.CreateRPSGridFormattedTextBox<CuDistDetailOfMaterialsPopUpDialogView>("","#309e2109-5490-496c-ab40-b0280b130079 .ag-row[role='row']@ROWINDEX [col-id='cValueInteger']","",true, this.CurrentView);
 
            ValueDecimal = RPSControlFactory.CreateRPSGridFormattedTextBox<CuDistDetailOfMaterialsPopUpDialogView>("","#309e2109-5490-496c-ab40-b0280b130079 .ag-row[role='row']@ROWINDEX [col-id='cValueDecimal']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<CuDistDetailOfMaterialsPopUpDialogView> ArticleLabel_Description { get; set; } 
        public IRPSGridTextBox<CuDistDetailOfMaterialsPopUpDialogView> ValueInteger { get; set; } 
        public IRPSGridTextBox<CuDistDetailOfMaterialsPopUpDialogView> ValueDecimal { get; set; } 
                     
    }
 
        public partial class CuDistFeatureArticleValueModelCollectionCollectionEditor<CuDistDetailOfMaterialsPopUpDialogView>:RPSCollectionEditor<CuDistDetailOfMaterialsPopUpDialogView> where CuDistDetailOfMaterialsPopUpDialogView : class, IView
    {
        public  CuDistFeatureArticleValueModelCollectionGridView<CuDistDetailOfMaterialsPopUpDialogView> GridView {get;set;}
    }
    public partial class CuDistFeatureArticleValueModelCollectionGridView <CuDistDetailOfMaterialsPopUpDialogView> :  RPSGridView<CuDistDetailOfMaterialsPopUpDialogView> where CuDistDetailOfMaterialsPopUpDialogView : class, IView
    {
        public CuDistFeatureArticleValueModelCollectionGridView(CuDistDetailOfMaterialsPopUpDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Description = RPSControlFactory.CreateRPSGridTextBox<CuDistDetailOfMaterialsPopUpDialogView>("","#a3973c88-5732-471b-b664-f10f55cb9cf2 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            ValueInteger = RPSControlFactory.CreateRPSGridFormattedTextBox<CuDistDetailOfMaterialsPopUpDialogView>("","#a3973c88-5732-471b-b664-f10f55cb9cf2 .ag-row[role='row']@ROWINDEX [col-id='cValueInteger']","",true, this.CurrentView);
 
            ValueDecimal = RPSControlFactory.CreateRPSGridFormattedTextBox<CuDistDetailOfMaterialsPopUpDialogView>("","#a3973c88-5732-471b-b664-f10f55cb9cf2 .ag-row[role='row']@ROWINDEX [col-id='cValueDecimal']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<CuDistDetailOfMaterialsPopUpDialogView> Description { get; set; } 
        public IRPSGridTextBox<CuDistDetailOfMaterialsPopUpDialogView> ValueInteger { get; set; } 
        public IRPSGridTextBox<CuDistDetailOfMaterialsPopUpDialogView> ValueDecimal { get; set; } 
                     
    }
 
    }
  
    

}