    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.PurchaseProposal
{
    //RPS VERSION 1.0.0.0
    public partial class PurchaseProposal:Screen
    {
        public PurchaseProposal():base()
        {
            this.URL = "purchase.purchaseproposal";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            PurchaseProposalCollectionView  = new PurchaseProposalCollectionView(this); 
            PurchaseProposalEntityView  = new PurchaseProposalEntityView(this); 
            SuppliersPurchasesChildDialogView  = new SuppliersPurchasesChildDialogView(this); 
            AssignSupplierChildDialogView  = new AssignSupplierChildDialogView(this); 
            ProMaterialsChildDialogView  = new ProMaterialsChildDialogView(this); 
            MOMaterialsChildDialogView  = new MOMaterialsChildDialogView(this); 
            OrderGenerateChildDialogView  = new OrderGenerateChildDialogView(this); 
            QuotationGenerateChildDialogView  = new QuotationGenerateChildDialogView(this); 
            UpdateSupplierChildDialogView  = new UpdateSupplierChildDialogView(this); 
            PurchaseProposalCollectionView.InitializeControls(); 
            PurchaseProposalEntityView.InitializeControls(); 
            SuppliersPurchasesChildDialogView.InitializeControls(); 
            AssignSupplierChildDialogView.InitializeControls(); 
            ProMaterialsChildDialogView.InitializeControls(); 
            MOMaterialsChildDialogView.InitializeControls(); 
            OrderGenerateChildDialogView.InitializeControls(); 
            QuotationGenerateChildDialogView.InitializeControls(); 
            UpdateSupplierChildDialogView.InitializeControls(); 
           
        }
      
            public PurchaseProposalCollectionView PurchaseProposalCollectionView {get; set; } 
            public PurchaseProposalEntityView PurchaseProposalEntityView {get; set; } 
            public SuppliersPurchasesChildDialogView SuppliersPurchasesChildDialogView {get; set; } 
            public AssignSupplierChildDialogView AssignSupplierChildDialogView {get; set; } 
            public ProMaterialsChildDialogView ProMaterialsChildDialogView {get; set; } 
            public MOMaterialsChildDialogView MOMaterialsChildDialogView {get; set; } 
            public OrderGenerateChildDialogView OrderGenerateChildDialogView {get; set; } 
            public QuotationGenerateChildDialogView QuotationGenerateChildDialogView {get; set; } 
            public UpdateSupplierChildDialogView UpdateSupplierChildDialogView {get; set; } 
    }
            
    public partial class PurchaseProposalCollectionView : View
    {
        public PurchaseProposalCollectionView(PurchaseProposal screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<PurchaseProposalCollectionView,PurchaseProposalEntityView>( this,Screen.PurchaseProposalEntityView);
 
            PurchaseProposalValidatedCommandButton = RPSControlFactory.CreateRPSButton<PurchaseProposalCollectionView>( "11419228-d1ac-4521-890a-937b07f8cdde","","",this);
 
            PurchaseProposalDeletedCommandButton = RPSControlFactory.CreateRPSButton<PurchaseProposalCollectionView>( "ee07dbd9-34b9-4eab-bec0-c59b9a7bf336","","",this);
 
            OrderGenerateChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<PurchaseProposalCollectionView,OrderGenerateChildDialogView>("13c6e22e-7fa4-4bc2-b314-27102db31202","","", this,Screen.OrderGenerateChildDialogView);
 
            QuotationGenerateChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<PurchaseProposalCollectionView,QuotationGenerateChildDialogView>("c6a204c2-76b6-44a4-bbf1-124e41e8cf8a","","", this,Screen.QuotationGenerateChildDialogView);
 
            UpdateSupplierChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<PurchaseProposalCollectionView,UpdateSupplierChildDialogView>("57fb21e9-b8df-4814-aa21-2ee439a76c48","","", this,Screen.UpdateSupplierChildDialogView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "256ab152-d63c-4492-90f0-8c3bef73f5ba",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<PurchaseProposalCollectionView,PurchaseProposalEntityView>( params_MainConsult,this,Screen.PurchaseProposalEntityView);
 

        }
        public IRPSButton<PurchaseProposalCollectionView,PurchaseProposalEntityView> NewButton { get; set; } 
        public IRPSButton<PurchaseProposalCollectionView> PurchaseProposalValidatedCommandButton { get; set; } 
        public IRPSButton<PurchaseProposalCollectionView> PurchaseProposalDeletedCommandButton { get; set; } 
        public IRPSButton<PurchaseProposalCollectionView,OrderGenerateChildDialogView> OrderGenerateChildNavigationCommandButton { get; set; } 
        public IRPSButton<PurchaseProposalCollectionView,QuotationGenerateChildDialogView> QuotationGenerateChildNavigationCommandButton { get; set; } 
        public IRPSButton<PurchaseProposalCollectionView,UpdateSupplierChildDialogView> UpdateSupplierChildNavigationCommandButton { get; set; } 
        public IRPSCollectionEditor<PurchaseProposalCollectionView,PurchaseProposalEntityView> MainConsult { get; set; } 
        public PurchaseProposal Screen { get; set; }
        public PurchaseProposalCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PurchaseProposalEntityView : View
    {
        public PurchaseProposalEntityView(PurchaseProposal screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<PurchaseProposalEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<PurchaseProposalEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<PurchaseProposalEntityView,PurchaseProposalCollectionView>( this,Screen.PurchaseProposalCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<PurchaseProposalEntityView,PurchaseProposalCollectionView>( this,Screen.PurchaseProposalCollectionView);
 
            CodPurchaseProposal = RPSControlFactory.CreateRPSTextBox<PurchaseProposalEntityView>("1dba8765-a45e-48dd-9390-2070f39800d0","","",true, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<PurchaseProposalEntityView>("5d3feff5-fbce-4415-9f89-5909917de2fa","","",true, this);
 
            ReferenceSupplier = RPSControlFactory.CreateRPSEnumComboBox<PurchaseProposalEntityView>("f78070b2-81eb-49bf-90cd-c2d95460d0e5","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<PurchaseProposalEntityView>("2ad99d62-a409-40ab-914d-db888e849f86","","",true, this);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSComboBox<PurchaseProposalEntityView>("923a2a98-c627-410a-a9d3-690faa683be4","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<PurchaseProposalEntityView>("712d2341-8dc0-4339-8ef2-36b1c4e2195b","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<PurchaseProposalEntityView>("063024b0-2bce-4c6f-aa68-f9789b132507","","",false, this);
 
            PurchaseManager = RPSControlFactory.CreateRPSComboBox<PurchaseProposalEntityView>("5170b04d-8962-41cb-9ba6-3a3fb4ef2c30","","",false, this);
 
            ProposalDate = RPSControlFactory.CreateRPSTextBox<PurchaseProposalEntityView>("b6294764-4c40-4b99-a516-0e4758f3d39c","","",true, this);
 
            ReceptionDate = RPSControlFactory.CreateRPSTextBox<PurchaseProposalEntityView>("8352d7e3-9288-4baf-beba-06b43189bad0","","",true, this);
 
            ReceptionDemandDate = RPSControlFactory.CreateRPSTextBox<PurchaseProposalEntityView>("b8669941-a28d-4aab-93a9-6c4dad0fb811","","",true, this);
 
            ProposalFrom = RPSControlFactory.CreateRPSEnumComboBox<PurchaseProposalEntityView>("58bf679d-87b1-4b15-89b4-9ecc1696b633","","",true, this);
 
            UIPurchaseLot = RPSControlFactory.CreateRPSFormattedTextBox<PurchaseProposalEntityView>("644ae11d-a141-409c-b284-0c7c1af83bd1","","",false, this);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<PurchaseProposalEntityView>("f049a397-02ba-484e-bd13-99f422264b3c","","",false, this);
 
            Status = RPSControlFactory.CreateRPSEnumComboBox<PurchaseProposalEntityView>("8519f7ea-a5bc-43d7-85b7-7810b655bdf7","","",true, this);
 
            StatusOffer = RPSControlFactory.CreateRPSEnumComboBox<PurchaseProposalEntityView>("8fd52517-19c0-4833-84a6-da9b23dd7e45","","",true, this);
 
            InternalCode = RPSControlFactory.CreateRPSTextBox<PurchaseProposalEntityView>("b83921de-1e24-4806-b946-6dad08b781bd","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<PurchaseProposalEntityView>("8d4b3cfd-f27b-4f7d-8568-5fe3e9e0c024","","",false, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<PurchaseProposalEntityView>("d3fb291f-64c6-414a-a5f4-ffbda7d4665a","","",false, this);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<PurchaseProposalEntityView>("1e831e94-cae8-465d-852c-32ce458326e6","","",false, this);
 
            IDProTask = RPSControlFactory.CreateRPSComboBox<PurchaseProposalEntityView>("7a2e09f9-a66e-44c3-af93-1dd29fc69199","","",false, this);
 
            IDProMaterial = RPSControlFactory.CreateRPSComboBox<PurchaseProposalEntityView>("3f460f9e-2399-45e7-8a11-3fd115ab24e8","","",false, this);
 
            UIProTaskGroup = RPSControlFactory.CreateRPSTextBox<PurchaseProposalEntityView>("26847c93-5ed3-411f-a0d1-10496fd42dd9","","",false, this);
 
            UIProTaskOptimizationFeature = RPSControlFactory.CreateRPSTextBox<PurchaseProposalEntityView>("b938c721-cacd-44d4-9f12-b0ad18ad7d7a","","",false, this);
 
            IDManufacturingOrder = RPSControlFactory.CreateRPSComboBox<PurchaseProposalEntityView>("f0e0b7b2-3f65-4c71-8777-afeaf3cd158f","","",false, this);
 
            IDMOTask = RPSControlFactory.CreateRPSComboBox<PurchaseProposalEntityView>("9ea33a24-a08b-477d-8a2d-f8f33d612c32","","",false, this);
 
            IDMOMaterial = RPSControlFactory.CreateRPSComboBox<PurchaseProposalEntityView>("ed924d6b-9c90-43c4-8567-eb9153b321d9","","",false, this);
 
            ProcessQuantity = RPSControlFactory.CreateRPSFormattedTextBox<PurchaseProposalEntityView>("4230bf79-2617-45a3-b759-4ab2efc219e8","","",false, this);
 
            StructureQuantity = RPSControlFactory.CreateRPSFormattedTextBox<PurchaseProposalEntityView>("d2b7c5e6-e5f8-4a2b-919e-c0e97ae00bb3","","",false, this);
 
            UIMOTaskGroup = RPSControlFactory.CreateRPSTextBox<PurchaseProposalEntityView>("8854b4dd-9107-430d-99fd-795b450f18fa","","",false, this);
 
            UIMOTaskOptimizationFeature = RPSControlFactory.CreateRPSTextBox<PurchaseProposalEntityView>("8b604db1-2d8d-46af-a94e-9dc891b5cc93","","",false, this);
 
            IDMaintenanceOrder = RPSControlFactory.CreateRPSComboBox<PurchaseProposalEntityView>("a3958df8-9757-46fb-9201-d712db849908","","",false, this);
 
            IDOrderMaterialPrevision = RPSControlFactory.CreateRPSComboBox<PurchaseProposalEntityView>("8f0b92aa-07c1-4898-aa2e-0352cd1a3867","","",false, this);
 
            IDArticleStructure = RPSControlFactory.CreateRPSComboBox<PurchaseProposalEntityView>("8c0db206-c7a5-4d7d-a9a6-9e1775c2f7e7","","",false, this);
 
            UIExternalTask = RPSControlFactory.CreateRPSCheckBox<PurchaseProposalEntityView>("9e692c35-e6f5-4db4-b390-b394ba1b91e7","","",false, this);
 
            UIIDOrderSL = RPSControlFactory.CreateRPSComboBox<PurchaseProposalEntityView>("771ae2a5-6eb6-49ee-a9fb-78f5736b3380","","",false, this);
 
            IDOrderLineSales = RPSControlFactory.CreateRPSComboBox<PurchaseProposalEntityView>("afaca457-69f6-448f-8e16-04d054f7bf73","","",false, this);
 
            ExecutePurchaseProposalCommentAddArticleTechnicalDescription = RPSControlFactory.CreateRPSButton<PurchaseProposalEntityView>( "389ab33d-acd7-461d-9562-47cc7ca5eb9e","","",this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<PurchaseProposalEntityView>("13f7220d-2c42-4326-b540-3fb839ddce42","","",false, this);
 
            Matchcode = RPSControlFactory.CreateRPSTextBox<PurchaseProposalEntityView>("2d7dea8d-d40d-4d22-8578-025aae8d5e84","","",false, this);
 
            AssignSupplierChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<PurchaseProposalEntityView,AssignSupplierChildDialogView>("9c1dc8a4-3313-4eed-9e20-c29244aa4183","","", this,Screen.AssignSupplierChildDialogView);
 
            SuppliersPurchasesChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<PurchaseProposalEntityView,SuppliersPurchasesChildDialogView>("95749203-2ce5-41cc-a4f6-c9c76ae089b0","","", this,Screen.SuppliersPurchasesChildDialogView);
 
            ExecuteValidateButton = RPSControlFactory.CreateRPSButton<PurchaseProposalEntityView>( "5aa3ae39-1874-4f5a-9dfb-54b2e1926395","","",this);
 
            ExecuteRejectButton = RPSControlFactory.CreateRPSButton<PurchaseProposalEntityView>( "f6012537-62e2-4426-af11-f23efd96b547","","",this);
 
            MaterialCommandButton = RPSControlFactory.CreateRPSButton<PurchaseProposalEntityView>( "74507727-572b-40ec-bae0-b1172f938b42","","",this);
 
            GeneralDataSection = RPSControlFactory.CreateRPSSection<PurchaseProposalEntityView>( "","ul li[rpsid='5165224a-4e77-44c5-a796-d2dc2c2e9996']","",this);
 
            CommentsSection = RPSControlFactory.CreateRPSSection<PurchaseProposalEntityView>( "","ul li[rpsid='6ee280e6-2a50-4432-8da4-ce7829eba9fd']","",this);
 
            DPS = RPSControlFactory.CreateRPSSection<PurchaseProposalEntityView>( "","ul li[rpsid='6fd35b40-8d82-48fa-bb63-59737eaf756a']","",this);
 

        }
        public IRPSSaveButton<PurchaseProposalEntityView> SaveButton { get; set; } 
        public IRPSButton<PurchaseProposalEntityView> DeleteButton { get; set; } 
        public IRPSButton<PurchaseProposalEntityView,PurchaseProposalCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<PurchaseProposalEntityView,PurchaseProposalCollectionView> BackButton { get; set; } 
        public IRPSTextBox<PurchaseProposalEntityView> CodPurchaseProposal { get; set; } 
        public IRPSComboBox<PurchaseProposalEntityView> IDArticle { get; set; } 
        public IRPSComboBox<PurchaseProposalEntityView> ReferenceSupplier { get; set; } 
        public IRPSTextBox<PurchaseProposalEntityView> Quantity { get; set; } 
        public IRPSComboBox<PurchaseProposalEntityView> IDUnitQuantity { get; set; } 
        public IRPSTextBox<PurchaseProposalEntityView> Description { get; set; } 
        public IRPSComboBox<PurchaseProposalEntityView> IDSupplier { get; set; } 
        public IRPSComboBox<PurchaseProposalEntityView> PurchaseManager { get; set; } 
        public IRPSTextBox<PurchaseProposalEntityView> ProposalDate { get; set; } 
        public IRPSTextBox<PurchaseProposalEntityView> ReceptionDate { get; set; } 
        public IRPSTextBox<PurchaseProposalEntityView> ReceptionDemandDate { get; set; } 
        public IRPSComboBox<PurchaseProposalEntityView> ProposalFrom { get; set; } 
        public IRPSTextBox<PurchaseProposalEntityView> UIPurchaseLot { get; set; } 
        public IRPSComboBox<PurchaseProposalEntityView> IDEmployee { get; set; } 
        public IRPSComboBox<PurchaseProposalEntityView> Status { get; set; } 
        public IRPSComboBox<PurchaseProposalEntityView> StatusOffer { get; set; } 
        public IRPSTextBox<PurchaseProposalEntityView> InternalCode { get; set; } 
        public IRPSComboBox<PurchaseProposalEntityView> IDSite { get; set; } 
        public IRPSComboBox<PurchaseProposalEntityView> IDWarehouse { get; set; } 
        public IRPSComboBox<PurchaseProposalEntityView> IDProject { get; set; } 
        public IRPSComboBox<PurchaseProposalEntityView> IDProTask { get; set; } 
        public IRPSComboBox<PurchaseProposalEntityView> IDProMaterial { get; set; } 
        public IRPSTextBox<PurchaseProposalEntityView> UIProTaskGroup { get; set; } 
        public IRPSTextBox<PurchaseProposalEntityView> UIProTaskOptimizationFeature { get; set; } 
        public IRPSComboBox<PurchaseProposalEntityView> IDManufacturingOrder { get; set; } 
        public IRPSComboBox<PurchaseProposalEntityView> IDMOTask { get; set; } 
        public IRPSComboBox<PurchaseProposalEntityView> IDMOMaterial { get; set; } 
        public IRPSTextBox<PurchaseProposalEntityView> ProcessQuantity { get; set; } 
        public IRPSTextBox<PurchaseProposalEntityView> StructureQuantity { get; set; } 
        public IRPSTextBox<PurchaseProposalEntityView> UIMOTaskGroup { get; set; } 
        public IRPSTextBox<PurchaseProposalEntityView> UIMOTaskOptimizationFeature { get; set; } 
        public IRPSComboBox<PurchaseProposalEntityView> IDMaintenanceOrder { get; set; } 
        public IRPSComboBox<PurchaseProposalEntityView> IDOrderMaterialPrevision { get; set; } 
        public IRPSComboBox<PurchaseProposalEntityView> IDArticleStructure { get; set; } 
        public IRPSCheckbox<PurchaseProposalEntityView> UIExternalTask { get; set; } 
        public IRPSComboBox<PurchaseProposalEntityView> UIIDOrderSL { get; set; } 
        public IRPSComboBox<PurchaseProposalEntityView> IDOrderLineSales { get; set; } 
        public IRPSButton<PurchaseProposalEntityView> ExecutePurchaseProposalCommentAddArticleTechnicalDescription { get; set; } 
        public IRPSTextBox<PurchaseProposalEntityView> Comment { get; set; } 
        public IRPSTextBox<PurchaseProposalEntityView> Matchcode { get; set; } 
        public IRPSButton<PurchaseProposalEntityView,AssignSupplierChildDialogView> AssignSupplierChildNavigationCommandButton { get; set; } 
        public IRPSButton<PurchaseProposalEntityView,SuppliersPurchasesChildDialogView> SuppliersPurchasesChildNavigationCommandButton { get; set; } 
        public IRPSButton<PurchaseProposalEntityView> ExecuteValidateButton { get; set; } 
        public IRPSButton<PurchaseProposalEntityView> ExecuteRejectButton { get; set; } 
        public IRPSButton<PurchaseProposalEntityView> MaterialCommandButton { get; set; } 
        public IRPSSection<PurchaseProposalEntityView> GeneralDataSection { get; set; } 
        public IRPSSection<PurchaseProposalEntityView> CommentsSection { get; set; } 
        public IRPSSection<PurchaseProposalEntityView> DPS { get; set; } 
        public PurchaseProposal Screen { get; set; }
        public PurchaseProposalEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SuppliersPurchasesChildDialogView : View
    {
        public SuppliersPurchasesChildDialogView(PurchaseProposal screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSComboBox<SuppliersPurchasesChildDialogView>("17d6afb6-7b71-483a-a147-d1fbbf17c841","","",true, this);
 
            CollectionInit params_GetPurchasesLastDate = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="bd63dda5-6db2-4751-8d2c-da1c72191d67",CSSSelectorGrid="",XPathGrid=""};
            GetPurchasesLastDate = RPSControlFactory.RPSCreateCollectionWithGrid<GetPurchasesLastDateCollectionEditor<SuppliersPurchasesChildDialogView>,SuppliersPurchasesChildDialogView>( params_GetPurchasesLastDate,this);
 
            CollectionInit params_GetRelatedFrameworkContracts = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d6bc9195-9723-47e9-bd11-8c8180f7fa1c",CSSSelectorGrid="",XPathGrid=""};
            GetRelatedFrameworkContracts = RPSControlFactory.RPSCreateCollectionWithGrid<GetRelatedFrameworkContractsCollectionEditor<SuppliersPurchasesChildDialogView>,SuppliersPurchasesChildDialogView>( params_GetRelatedFrameworkContracts,this);
 
            Section = RPSControlFactory.CreateRPSSection<SuppliersPurchasesChildDialogView>( "","ul li[rpsid='c4617e11-a02a-4d77-a21a-84ab4d4e1094']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<SuppliersPurchasesChildDialogView>( "","ul li[rpsid='245c0285-a3b6-41c4-bfb1-fb13506cb044']","",this);
 

        }
        public IRPSComboBox<SuppliersPurchasesChildDialogView> IDArticle { get; set; } 
        public GetPurchasesLastDateCollectionEditor<SuppliersPurchasesChildDialogView> GetPurchasesLastDate { get; set; } 
        public GetRelatedFrameworkContractsCollectionEditor<SuppliersPurchasesChildDialogView> GetRelatedFrameworkContracts { get; set; } 
        public IRPSSection<SuppliersPurchasesChildDialogView> Section { get; set; } 
        public IRPSSection<SuppliersPurchasesChildDialogView> Section1 { get; set; } 
        public PurchaseProposal Screen { get; set; }
        public SuppliersPurchasesChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetPurchasesLastDateCollectionEditor<SuppliersPurchasesChildDialogView>:RPSCollectionEditor<SuppliersPurchasesChildDialogView> where SuppliersPurchasesChildDialogView : class, IView
    {
        public  GetPurchasesLastDateGridView<SuppliersPurchasesChildDialogView> GridView {get;set;}
    }
    public partial class GetPurchasesLastDateGridView <SuppliersPurchasesChildDialogView> :  RPSGridView<SuppliersPurchasesChildDialogView> where SuppliersPurchasesChildDialogView : class, IView
    {
        public GetPurchasesLastDateGridView(SuppliersPurchasesChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            bDefault = RPSControlFactory.CreateRPSGridCheckBox<SuppliersPurchasesChildDialogView>("","#bd63dda5-6db2-4751-8d2c-da1c72191d67 .ag-row[role='row']@ROWINDEX [col-id='cbDefault']","",false, this.CurrentView);
 
            bGroup = RPSControlFactory.CreateRPSGridCheckBox<SuppliersPurchasesChildDialogView>("","#bd63dda5-6db2-4751-8d2c-da1c72191d67 .ag-row[role='row']@ROWINDEX [col-id='cbGroup']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<SuppliersPurchasesChildDialogView>("","#bd63dda5-6db2-4751-8d2c-da1c72191d67 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            LastDate = RPSControlFactory.CreateRPSGridTextBox<SuppliersPurchasesChildDialogView>("","#bd63dda5-6db2-4751-8d2c-da1c72191d67 .ag-row[role='row']@ROWINDEX [col-id='cLastDate']","",false, this.CurrentView);
 
            Price = RPSControlFactory.CreateRPSGridFormattedTextBox<SuppliersPurchasesChildDialogView>("","#bd63dda5-6db2-4751-8d2c-da1c72191d67 .ag-row[role='row']@ROWINDEX [col-id='cPrice']","",false, this.CurrentView);
 
            ReferenceSupplier = RPSControlFactory.CreateRPSGridTextBox<SuppliersPurchasesChildDialogView>("","#bd63dda5-6db2-4751-8d2c-da1c72191d67 .ag-row[role='row']@ROWINDEX [col-id='cReferenceSupplier']","",false, this.CurrentView);
 
            PriceActual = RPSControlFactory.CreateRPSGridFormattedTextBox<SuppliersPurchasesChildDialogView>("","#bd63dda5-6db2-4751-8d2c-da1c72191d67 .ag-row[role='row']@ROWINDEX [col-id='cPriceActual']","",false, this.CurrentView);
 

        }
        public IRPSGridCheckbox<SuppliersPurchasesChildDialogView> bDefault { get; set; } 
        public IRPSGridCheckbox<SuppliersPurchasesChildDialogView> bGroup { get; set; } 
        public IRPSGridTextBox<SuppliersPurchasesChildDialogView> Quantity { get; set; } 
        public IRPSGridTextBox<SuppliersPurchasesChildDialogView> LastDate { get; set; } 
        public IRPSGridTextBox<SuppliersPurchasesChildDialogView> Price { get; set; } 
        public IRPSGridTextBox<SuppliersPurchasesChildDialogView> ReferenceSupplier { get; set; } 
        public IRPSGridTextBox<SuppliersPurchasesChildDialogView> PriceActual { get; set; } 
                     
    }
 
        public partial class GetRelatedFrameworkContractsCollectionEditor<SuppliersPurchasesChildDialogView>:RPSCollectionEditor<SuppliersPurchasesChildDialogView> where SuppliersPurchasesChildDialogView : class, IView
    {
        public  GetRelatedFrameworkContractsGridView<SuppliersPurchasesChildDialogView> GridView {get;set;}
    }
    public partial class GetRelatedFrameworkContractsGridView <SuppliersPurchasesChildDialogView> :  RPSGridView<SuppliersPurchasesChildDialogView> where SuppliersPurchasesChildDialogView : class, IView
    {
        public GetRelatedFrameworkContractsGridView(SuppliersPurchasesChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            FrameworkContractDateFrom = RPSControlFactory.CreateRPSGridTextBox<SuppliersPurchasesChildDialogView>("","#d6bc9195-9723-47e9-bd11-8c8180f7fa1c .ag-row[role='row']@ROWINDEX [col-id='cFrameworkContractDateFrom']","",false, this.CurrentView);
 
            FrameworkContractDateTo = RPSControlFactory.CreateRPSGridTextBox<SuppliersPurchasesChildDialogView>("","#d6bc9195-9723-47e9-bd11-8c8180f7fa1c .ag-row[role='row']@ROWINDEX [col-id='cFrameworkContractDateTo']","",false, this.CurrentView);
 
            ReferenceSupplier = RPSControlFactory.CreateRPSGridTextBox<SuppliersPurchasesChildDialogView>("","#d6bc9195-9723-47e9-bd11-8c8180f7fa1c .ag-row[role='row']@ROWINDEX [col-id='cReferenceSupplier']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SuppliersPurchasesChildDialogView> FrameworkContractDateFrom { get; set; } 
        public IRPSGridTextBox<SuppliersPurchasesChildDialogView> FrameworkContractDateTo { get; set; } 
        public IRPSGridTextBox<SuppliersPurchasesChildDialogView> ReferenceSupplier { get; set; } 
                     
    }
 
    }
  
            
    public partial class AssignSupplierChildDialogView : View
    {
        public AssignSupplierChildDialogView(PurchaseProposal screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDSupplier = RPSControlFactory.CreateRPSComboBox<AssignSupplierChildDialogView>("85d3546b-8424-48b5-864c-1677f6be3cc5","","",false, this);
 
            IDSupplierWithGroup = RPSControlFactory.CreateRPSComboBox<AssignSupplierChildDialogView>("5076bfd6-c837-4ffa-bb7e-c18810a29022","","",false, this);
 

        }
        public IRPSComboBox<AssignSupplierChildDialogView> IDSupplier { get; set; } 
        public IRPSComboBox<AssignSupplierChildDialogView> IDSupplierWithGroup { get; set; } 
        public PurchaseProposal Screen { get; set; }
        public AssignSupplierChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ProMaterialsChildDialogView : View
    {
        public ProMaterialsChildDialogView(PurchaseProposal screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_GetProposalProMaterialsExternalTask = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="75f33840-3ca6-4fde-a875-fd076e9ebbd4",CSSSelectorGrid="",XPathGrid=""};
            GetProposalProMaterialsExternalTask = RPSControlFactory.RPSCreateCollectionWithGrid<GetProposalProMaterialsExternalTaskCollectionEditor<ProMaterialsChildDialogView>,ProMaterialsChildDialogView>( params_GetProposalProMaterialsExternalTask,this);
 

        }
        public GetProposalProMaterialsExternalTaskCollectionEditor<ProMaterialsChildDialogView> GetProposalProMaterialsExternalTask { get; set; } 
        public PurchaseProposal Screen { get; set; }
        public ProMaterialsChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetProposalProMaterialsExternalTaskCollectionEditor<ProMaterialsChildDialogView>:RPSCollectionEditor<ProMaterialsChildDialogView> where ProMaterialsChildDialogView : class, IView
    {
        public  GetProposalProMaterialsExternalTaskGridView<ProMaterialsChildDialogView> GridView {get;set;}
    }
    public partial class GetProposalProMaterialsExternalTaskGridView <ProMaterialsChildDialogView> :  RPSGridView<ProMaterialsChildDialogView> where ProMaterialsChildDialogView : class, IView
    {
        public GetProposalProMaterialsExternalTaskGridView(ProMaterialsChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<ProMaterialsChildDialogView>("","#75f33840-3ca6-4fde-a875-fd076e9ebbd4 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            Stock = RPSControlFactory.CreateRPSGridFormattedTextBox<ProMaterialsChildDialogView>("","#75f33840-3ca6-4fde-a875-fd076e9ebbd4 .ag-row[role='row']@ROWINDEX [col-id='cStock']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ProMaterialsChildDialogView> Quantity { get; set; } 
        public IRPSGridTextBox<ProMaterialsChildDialogView> Stock { get; set; } 
                     
    }
 
    }
  
            
    public partial class MOMaterialsChildDialogView : View
    {
        public MOMaterialsChildDialogView(PurchaseProposal screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_GetProposalMOMaterialsExternalTask = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b4dd51c3-b3e4-487c-b237-bd98de27cd2c",CSSSelectorGrid="",XPathGrid=""};
            GetProposalMOMaterialsExternalTask = RPSControlFactory.RPSCreateCollectionWithGrid<GetProposalMOMaterialsExternalTaskCollectionEditor<MOMaterialsChildDialogView>,MOMaterialsChildDialogView>( params_GetProposalMOMaterialsExternalTask,this);
 

        }
        public GetProposalMOMaterialsExternalTaskCollectionEditor<MOMaterialsChildDialogView> GetProposalMOMaterialsExternalTask { get; set; } 
        public PurchaseProposal Screen { get; set; }
        public MOMaterialsChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetProposalMOMaterialsExternalTaskCollectionEditor<MOMaterialsChildDialogView>:RPSCollectionEditor<MOMaterialsChildDialogView> where MOMaterialsChildDialogView : class, IView
    {
        public  GetProposalMOMaterialsExternalTaskGridView<MOMaterialsChildDialogView> GridView {get;set;}
    }
    public partial class GetProposalMOMaterialsExternalTaskGridView <MOMaterialsChildDialogView> :  RPSGridView<MOMaterialsChildDialogView> where MOMaterialsChildDialogView : class, IView
    {
        public GetProposalMOMaterialsExternalTaskGridView(MOMaterialsChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<MOMaterialsChildDialogView>("","#b4dd51c3-b3e4-487c-b237-bd98de27cd2c .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            Stock = RPSControlFactory.CreateRPSGridFormattedTextBox<MOMaterialsChildDialogView>("","#b4dd51c3-b3e4-487c-b237-bd98de27cd2c .ag-row[role='row']@ROWINDEX [col-id='cStock']","",false, this.CurrentView);
 
            QuantityProcess = RPSControlFactory.CreateRPSGridFormattedTextBox<MOMaterialsChildDialogView>("","#b4dd51c3-b3e4-487c-b237-bd98de27cd2c .ag-row[role='row']@ROWINDEX [col-id='cQuantityProcess']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MOMaterialsChildDialogView> Quantity { get; set; } 
        public IRPSGridTextBox<MOMaterialsChildDialogView> Stock { get; set; } 
        public IRPSGridTextBox<MOMaterialsChildDialogView> QuantityProcess { get; set; } 
                     
    }
 
    }
  
            
    public partial class OrderGenerateChildDialogView : View
    {
        public OrderGenerateChildDialogView(PurchaseProposal screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Single = RPSControlFactory.CreateRPSOption<OrderGenerateChildDialogView>( "83b827b9-1439-4408-afcb-8c2f67a019a7","","",this);
 
            Break = RPSControlFactory.CreateRPSOption<OrderGenerateChildDialogView>( "99f96fb7-ea1e-47d3-a4ec-98a36bbbe058","","",this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<OrderGenerateChildDialogView>("b4abfc72-d33f-428d-b8db-191d41f00f1a","","",false, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<OrderGenerateChildDialogView>("2d55f300-0edf-45b4-b3c8-40ff52ed61a4","","",false, this);
 
            NewCode = RPSControlFactory.CreateRPSTextBox<OrderGenerateChildDialogView>("426c19e8-c390-49a0-83e7-91d88ad07455","","",false, this);
 

        }
        public IRPSOption<OrderGenerateChildDialogView> Single { get; set; } 
        public IRPSOption<OrderGenerateChildDialogView> Break { get; set; } 
        public IRPSComboBox<OrderGenerateChildDialogView> IDSupplier { get; set; } 
        public IRPSTextBox<OrderGenerateChildDialogView> Date { get; set; } 
        public IRPSTextBox<OrderGenerateChildDialogView> NewCode { get; set; } 
        public PurchaseProposal Screen { get; set; }
        public OrderGenerateChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class QuotationGenerateChildDialogView : View
    {
        public QuotationGenerateChildDialogView(PurchaseProposal screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Single = RPSControlFactory.CreateRPSOption<QuotationGenerateChildDialogView>( "637ee06f-ed9d-4399-a8fc-b7833da0c49a","","",this);
 
            Break = RPSControlFactory.CreateRPSOption<QuotationGenerateChildDialogView>( "60f4d91c-584d-4bbc-9124-a9ed8366356a","","",this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<QuotationGenerateChildDialogView>("68ddd422-09ef-45e9-9234-003531dfaf8a","","",false, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<QuotationGenerateChildDialogView>("82407625-c99a-4754-8955-18f0499d90b6","","",false, this);
 
            NewCode = RPSControlFactory.CreateRPSTextBox<QuotationGenerateChildDialogView>("6310837a-d8d9-47fa-9eb2-8c1ea5b959fb","","",false, this);
 

        }
        public IRPSOption<QuotationGenerateChildDialogView> Single { get; set; } 
        public IRPSOption<QuotationGenerateChildDialogView> Break { get; set; } 
        public IRPSComboBox<QuotationGenerateChildDialogView> IDSupplier { get; set; } 
        public IRPSTextBox<QuotationGenerateChildDialogView> Date { get; set; } 
        public IRPSTextBox<QuotationGenerateChildDialogView> NewCode { get; set; } 
        public PurchaseProposal Screen { get; set; }
        public QuotationGenerateChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class UpdateSupplierChildDialogView : View
    {
        public UpdateSupplierChildDialogView(PurchaseProposal screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDSupplier = RPSControlFactory.CreateRPSComboBox<UpdateSupplierChildDialogView>("498f1249-4103-4997-8e6c-6e46137ec956","","",false, this);
 

        }
        public IRPSComboBox<UpdateSupplierChildDialogView> IDSupplier { get; set; } 
        public PurchaseProposal Screen { get; set; }
        public UpdateSupplierChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}