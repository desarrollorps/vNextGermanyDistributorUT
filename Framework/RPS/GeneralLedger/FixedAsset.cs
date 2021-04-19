    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.FixedAsset
{
    //RPS VERSION 1.0.0.0
    public partial class FixedAsset:Screen
    {
        public FixedAsset():base()
        {
            this.URL = "generalledger.fixedasset";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            FixedAssetCollectionView  = new FixedAssetCollectionView(this); 
            FixedAssetEntityView  = new FixedAssetEntityView(this); 
            FAValueView  = new FAValueView(this); 
            FADepPlanView  = new FADepPlanView(this); 
            FAPurchaseView  = new FAPurchaseView(this); 
            FAFixedAssetDimensionView  = new FAFixedAssetDimensionView(this); 
            DateDisposeDialogView  = new DateDisposeDialogView(this); 
            FAValueCalculateDepreciationPlanChildDialogView  = new FAValueCalculateDepreciationPlanChildDialogView(this); 
            FADepreciationGenerateChildDialogView  = new FADepreciationGenerateChildDialogView(this); 
            FAValueDepreciationGenerateChildDialogView  = new FAValueDepreciationGenerateChildDialogView(this); 
            FACalculateDepreciationPlanChildDialogView  = new FACalculateDepreciationPlanChildDialogView(this); 
            FixedAssetCollectionView.InitializeControls(); 
            FixedAssetEntityView.InitializeControls(); 
            FAValueView.InitializeControls(); 
            FADepPlanView.InitializeControls(); 
            FAPurchaseView.InitializeControls(); 
            FAFixedAssetDimensionView.InitializeControls(); 
            DateDisposeDialogView.InitializeControls(); 
            FAValueCalculateDepreciationPlanChildDialogView.InitializeControls(); 
            FADepreciationGenerateChildDialogView.InitializeControls(); 
            FAValueDepreciationGenerateChildDialogView.InitializeControls(); 
            FACalculateDepreciationPlanChildDialogView.InitializeControls(); 
           
        }
      
            public FixedAssetCollectionView FixedAssetCollectionView {get; set; } 
            public FixedAssetEntityView FixedAssetEntityView {get; set; } 
            public FAValueView FAValueView {get; set; } 
            public FADepPlanView FADepPlanView {get; set; } 
            public FAPurchaseView FAPurchaseView {get; set; } 
            public FAFixedAssetDimensionView FAFixedAssetDimensionView {get; set; } 
            public DateDisposeDialogView DateDisposeDialogView {get; set; } 
            public FAValueCalculateDepreciationPlanChildDialogView FAValueCalculateDepreciationPlanChildDialogView {get; set; } 
            public FADepreciationGenerateChildDialogView FADepreciationGenerateChildDialogView {get; set; } 
            public FAValueDepreciationGenerateChildDialogView FAValueDepreciationGenerateChildDialogView {get; set; } 
            public FACalculateDepreciationPlanChildDialogView FACalculateDepreciationPlanChildDialogView {get; set; } 
    }
            
    public partial class FixedAssetCollectionView : View
    {
        public FixedAssetCollectionView(FixedAsset screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<FixedAssetCollectionView,FixedAssetEntityView>( this,Screen.FixedAssetEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "9d30931f-5651-4edf-8fdc-dd6db08de87b",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<FixedAssetCollectionView,FixedAssetEntityView>( params_MainConsult,this,Screen.FixedAssetEntityView);
 

        }
        public IRPSButton<FixedAssetCollectionView,FixedAssetEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<FixedAssetCollectionView,FixedAssetEntityView> MainConsult { get; set; } 
        public FixedAsset Screen { get; set; }
        public FixedAssetCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FixedAssetEntityView : View
    {
        public FixedAssetEntityView(FixedAsset screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<FixedAssetEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<FixedAssetEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FixedAssetEntityView,FixedAssetCollectionView>( this,Screen.FixedAssetCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<FixedAssetEntityView,FixedAssetCollectionView>( this,Screen.FixedAssetCollectionView);
 
            CodFA = RPSControlFactory.CreateRPSTextBox<FixedAssetEntityView>("f9b4babe-61fd-415c-8199-9621b5ac40c8","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<FixedAssetEntityView>("dea1682f-da21-4bef-b726-909a88df06ec","","",false, this);
 
            IDFAMain = RPSControlFactory.CreateRPSComboBox<FixedAssetEntityView>("79045e9b-cb98-434e-aec5-1cfd2a08b061","","",false, this);
 
            FAAcquisitionDate = RPSControlFactory.CreateRPSTextBox<FixedAssetEntityView>("dd7a4a2b-02d4-44f1-b2a8-2ece3cef82af","","",true, this);
 
            FADepreciationStartDate = RPSControlFactory.CreateRPSTextBox<FixedAssetEntityView>("bd99fb65-ce41-4b92-8821-8def3ea0692c","","",true, this);
 
            FAStatus = RPSControlFactory.CreateRPSEnumComboBox<FixedAssetEntityView>("70d0e805-4cbe-4502-806b-78db06522a7c","","",true, this);
 
            FAPurchaseAmount = RPSControlFactory.CreateRPSFormattedTextBox<FixedAssetEntityView>("388b2220-814a-4838-b775-ec8ce91b71d7","","",true, this);
 
            FADepInitialAmount = RPSControlFactory.CreateRPSFormattedTextBox<FixedAssetEntityView>("63656b77-3ae3-414f-926f-6cdd7e649330","","",true, this);
 
            FAResidualAmount = RPSControlFactory.CreateRPSFormattedTextBox<FixedAssetEntityView>("bf48498a-42b3-4798-bc5b-d2b1e8c74cea","","",true, this);
 
            FADisposeDate = RPSControlFactory.CreateRPSTextBox<FixedAssetEntityView>("92520b98-353a-49a6-bea4-98f8035c9f84","","",false, this);
 
            IDFADepreciationType = RPSControlFactory.CreateRPSComboBox<FixedAssetEntityView>("1f35187d-e9b6-4c19-9f2c-b52a8910a413","","",false, this);
 
            DepreciationMethod = RPSControlFactory.CreateRPSEnumComboBox<FixedAssetEntityView>("a64d8e07-ba4e-495e-b4e5-6aae9aa0f26b","","",false, this);
 
            DepreciationPeriods = RPSControlFactory.CreateRPSEnumComboBox<FixedAssetEntityView>("e801db6f-9dad-409f-888e-45c0cd4a9056","","",false, this);
 
            DepreciationPercentage = RPSControlFactory.CreateRPSFormattedTextBox<FixedAssetEntityView>("44a39544-e4c6-4fd2-b754-7a3ee805af5a","","",false, this);
 
            DepreciationYears = RPSControlFactory.CreateRPSFormattedTextBox<FixedAssetEntityView>("a4eb0aaa-4452-46e9-bdf9-c10cef1e8dd8","","",false, this);
 
            FADepPeriodFixAmount = RPSControlFactory.CreateRPSFormattedTextBox<FixedAssetEntityView>("f7b3c409-dcec-474a-89ab-c9a8e15abf7b","","",false, this);
 
            AmountPostedDepreciation = RPSControlFactory.CreateRPSFormattedTextBox<FixedAssetEntityView>("b1706e3f-1176-455a-aae5-f22f2f9d7777","","",false, this);
 
            LastPostedDepreciation = RPSControlFactory.CreateRPSTextBox<FixedAssetEntityView>("b948a6b1-934f-4540-97a3-3792c61a36cd","","",false, this);
 
            DisposeAmount = RPSControlFactory.CreateRPSFormattedTextBox<FixedAssetEntityView>("ce4266e7-b1b2-439b-9343-c164e77be024","","",false, this);
 
            LinkToFAValuesCommand = RPSControlFactory.CreateRPSButton<FixedAssetEntityView>( "59779d48-2b4f-4e8c-b76d-980c6e736e6a","","",this);
 
            FAGroup = RPSControlFactory.CreateRPSTextBox<FixedAssetEntityView>("d84e80d6-be0b-4ca4-a6d9-303a1503e877","","",false, this);
 
            FALocation1 = RPSControlFactory.CreateRPSTextBox<FixedAssetEntityView>("f5642fa5-f168-49d2-8e40-be5a1c9f1723","","",false, this);
 
            FALocation2 = RPSControlFactory.CreateRPSTextBox<FixedAssetEntityView>("0bfb9140-a46a-4784-8ec5-5764b9945192","","",false, this);
 
            FALocation3 = RPSControlFactory.CreateRPSTextBox<FixedAssetEntityView>("25211ade-7edf-4dea-a670-9306750f521e","","",false, this);
 
            FABrand = RPSControlFactory.CreateRPSTextBox<FixedAssetEntityView>("8c368303-654f-4029-a0f3-aa815a4e647f","","",false, this);
 
            FAModel = RPSControlFactory.CreateRPSTextBox<FixedAssetEntityView>("1f8cd0c6-376b-4643-a4b4-837acb2227ba","","",false, this);
 
            FAType = RPSControlFactory.CreateRPSTextBox<FixedAssetEntityView>("6dbce3ab-c7e2-4480-bd0f-998f555e970c","","",false, this);
 
            FAChassisNumber = RPSControlFactory.CreateRPSTextBox<FixedAssetEntityView>("97d3157c-e7ae-416e-9560-3a46d36ab9b6","","",false, this);
 
            FARegistrationNumber = RPSControlFactory.CreateRPSTextBox<FixedAssetEntityView>("aedbbbaa-946b-4f19-82a4-b140550301dd","","",false, this);
 
            FAEngineNumber = RPSControlFactory.CreateRPSTextBox<FixedAssetEntityView>("d7894b50-4fc3-4dc3-bad2-ff107e8c05f5","","",false, this);
 
            IDAccInvestment = RPSControlFactory.CreateRPSComboBox<FixedAssetEntityView>("c2b66d87-2942-4d5c-b00a-31d229b69c6b","","",false, this);
 
            IDAccCumulative = RPSControlFactory.CreateRPSComboBox<FixedAssetEntityView>("8c95f18e-be6e-42e3-882b-622ff15d9502","","",false, this);
 
            IDAccExpense = RPSControlFactory.CreateRPSComboBox<FixedAssetEntityView>("e058729a-ab72-4645-8490-f3990b3450f5","","",false, this);
 
            IDAccDispose = RPSControlFactory.CreateRPSComboBox<FixedAssetEntityView>("a012bf12-8761-4b91-a19d-d393154616e3","","",false, this);
 
            ShowFAPreliminariesButton = RPSControlFactory.CreateRPSButton<FixedAssetEntityView>( "5336497b-1626-43d4-9598-917b0ef29059","","",this);
 
            IsRealEstate = RPSControlFactory.CreateRPSCheckBox<FixedAssetEntityView>("dab818e4-92de-460a-97b2-f0d880f37663","","",true, this);
 
            Situation = RPSControlFactory.CreateRPSEnumComboBox<FixedAssetEntityView>("16eec92e-d633-4131-a251-596d89b8432f","","",true, this);
 
            CadastralReference = RPSControlFactory.CreateRPSTextBox<FixedAssetEntityView>("e0e4e144-ee09-4783-8f5d-3f465c1a7e66","","",false, this);
 
            HighwayType = RPSControlFactory.CreateRPSTextBox<FixedAssetEntityView>("215dcefa-b061-4535-abc1-b8729a24669f","","",false, this);
 
            PublicHighwayName = RPSControlFactory.CreateRPSTextBox<FixedAssetEntityView>("d01a39e0-c5eb-4524-b526-0dd97a069cee","","",false, this);
 
            NumberingType = RPSControlFactory.CreateRPSTextBox<FixedAssetEntityView>("8e87f5a8-8e0a-4fe7-8e34-3c0f4f9cc3e1","","",false, this);
 
            KMNumber = RPSControlFactory.CreateRPSTextBox<FixedAssetEntityView>("2afa2efd-c977-4abc-bd54-65f37fc53dde","","",false, this);
 
            Type = RPSControlFactory.CreateRPSTextBox<FixedAssetEntityView>("9cce6bbc-4618-41d0-b276-e829e3e5019c","","",false, this);
 
            Block = RPSControlFactory.CreateRPSTextBox<FixedAssetEntityView>("5bbe5c3e-7d6d-4fc7-9090-58602758aa10","","",false, this);
 
            Number = RPSControlFactory.CreateRPSTextBox<FixedAssetEntityView>("40d09174-00d7-4e77-a4e2-1a9ef8046f12","","",false, this);
 
            Stairs = RPSControlFactory.CreateRPSTextBox<FixedAssetEntityView>("04975563-3e07-4c1d-a3e1-fed962729344","","",false, this);
 
            Floor = RPSControlFactory.CreateRPSTextBox<FixedAssetEntityView>("ad4e03ea-9981-47a3-9439-4afc8ba8d9ea","","",false, this);
 
            Door = RPSControlFactory.CreateRPSTextBox<FixedAssetEntityView>("f8353684-64a7-4236-8556-852aeda332eb","","",false, this);
 
            Complement = RPSControlFactory.CreateRPSTextBox<FixedAssetEntityView>("89066ce8-8289-4a5a-918a-a98447cfdf3c","","",false, this);
 
            Town = RPSControlFactory.CreateRPSTextBox<FixedAssetEntityView>("8eda1771-655a-4155-bb19-0256ea146961","","",false, this);
 
            City = RPSControlFactory.CreateRPSTextBox<FixedAssetEntityView>("6cd5dde0-31b6-40b3-a9b6-a7dc3d0bfd1e","","",false, this);
 
            CityCode = RPSControlFactory.CreateRPSTextBox<FixedAssetEntityView>("0234b11e-d92b-4d45-9d61-18c343cd34f1","","",false, this);
 
            CountyCode = RPSControlFactory.CreateRPSTextBox<FixedAssetEntityView>("b11b0585-f252-47ab-977e-e7f681a3a023","","",false, this);
 
            ZipCode = RPSControlFactory.CreateRPSTextBox<FixedAssetEntityView>("ba0460ed-7a27-4652-a058-c38c2c37e028","","",false, this);
 
            CalculateCommandButton = RPSControlFactory.CreateRPSButton<FixedAssetEntityView>( "c6709a29-e308-4f09-8b8b-64dbf305af8b","","",this);
 
            FADepreciationGenerateChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<FixedAssetEntityView,FADepreciationGenerateChildDialogView>("37b8fb4c-f35f-4035-a435-0b4bb7fb6c21","","", this,Screen.FADepreciationGenerateChildDialogView);
 
            DateDisposeNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<FixedAssetEntityView,DateDisposeDialogView>("502b02ca-d4fb-4ab5-b09c-73f5cf3420fd","","", this,Screen.DateDisposeDialogView);
 
            ChangePurchaseAmountCommandButton = RPSControlFactory.CreateRPSButton<FixedAssetEntityView>( "c70cc478-548d-43df-a01e-05e2b069fd20","","",this);
 
            PrintCommandButton = RPSControlFactory.CreateRPSButton<FixedAssetEntityView>( "a802ba34-f656-46fa-926b-c5691d67ffff","","",this);
 
            CollectionInit params_FAValues = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="47c4a7af-e3d4-4d04-a022-0bd26a0c8ecb",CSSSelectorGrid="",XPathGrid=""};
            FAValues = RPSControlFactory.RPSCreateCollectionWithGrid<FAValuesCollectionEditor<FixedAssetEntityView,FAValueView>,FixedAssetEntityView,FAValueView>( params_FAValues,this,Screen.FAValueView);
 
            CollectionInit params_GetOnlyOneDepreciationPlan = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1c86c2cd-7336-498d-a44c-da6752ff9b8a",CSSSelectorGrid="",XPathGrid=""};
            GetOnlyOneDepreciationPlan = RPSControlFactory.RPSCreateCollectionWithGrid<GetOnlyOneDepreciationPlanCollectionEditor<FixedAssetEntityView,FAValueView>,FixedAssetEntityView,FAValueView>( params_GetOnlyOneDepreciationPlan,this,Screen.FAValueView);
 
            CollectionInit params_FAPurchases = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="fec0e5d6-16f8-4747-a481-019340b062dc",CSSSelectorGrid="",XPathGrid=""};
            FAPurchases = RPSControlFactory.RPSCreateCollectionWithGrid<FAPurchasesCollectionEditor<FixedAssetEntityView,FAValueView>,FixedAssetEntityView,FAValueView>( params_FAPurchases,this,Screen.FAValueView);
 
            CollectionInit params_FAFixedAssetDimensions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="51b4e932-cb3c-4e4f-a261-062e5ada5226",CSSSelectorGrid="",XPathGrid=""};
            FAFixedAssetDimensions = RPSControlFactory.RPSCreateCollectionWithGrid<FAFixedAssetDimensionsCollectionEditor<FixedAssetEntityView,FAValueView>,FixedAssetEntityView,FAValueView>( params_FAFixedAssetDimensions,this,Screen.FAValueView);
 
            CollectionInit params_CuDistFAChangePurchaseAmounts = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c52ad1e8-ddbb-404e-b0e7-39033af8b67d",CSSSelectorGrid="",XPathGrid=""};
            CuDistFAChangePurchaseAmounts = RPSControlFactory.RPSCreateCollectionWithGrid<CuDistFAChangePurchaseAmountsCollectionEditor<FixedAssetEntityView,FAValueView>,FixedAssetEntityView,FAValueView>( params_CuDistFAChangePurchaseAmounts,this,Screen.FAValueView);
 
            General = RPSControlFactory.CreateRPSSection<FixedAssetEntityView>( "","ul li[rpsid='9922fbaf-7212-4f6a-b830-43ab15f8e3ee']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<FixedAssetEntityView>( "","ul li[rpsid='65212bb3-b957-4d10-bae9-6b91f9725fca']","",this);
 
            Section = RPSControlFactory.CreateRPSSection<FixedAssetEntityView>( "","ul li[rpsid='d434e49e-31f0-440e-95ab-23d1797b6415']","",this);
 
            Purchase = RPSControlFactory.CreateRPSSection<FixedAssetEntityView>( "","ul li[rpsid='79edfe4d-59b3-4708-b6ef-ca9f35ea20b1']","",this);
 
            Analytic = RPSControlFactory.CreateRPSSection<FixedAssetEntityView>( "","ul li[rpsid='c9e89dbe-0e86-4462-bbf0-0857ca082066']","",this);
 
            RealState = RPSControlFactory.CreateRPSSection<FixedAssetEntityView>( "","ul li[rpsid='c79a841a-f693-4ecb-b72c-4e8cf4c643ee']","",this);
 
            ChangeAmount = RPSControlFactory.CreateRPSSection<FixedAssetEntityView>( "","ul li[rpsid='05bf6506-42dd-4e8c-aba9-acfc0e62aa65']","",this);
 

        }
        public IRPSSaveButton<FixedAssetEntityView> SaveButton { get; set; } 
        public IRPSButton<FixedAssetEntityView> DeleteButton { get; set; } 
        public IRPSButton<FixedAssetEntityView,FixedAssetCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FixedAssetEntityView,FixedAssetCollectionView> BackButton { get; set; } 
        public IRPSTextBox<FixedAssetEntityView> CodFA { get; set; } 
        public IRPSTextBox<FixedAssetEntityView> Description { get; set; } 
        public IRPSComboBox<FixedAssetEntityView> IDFAMain { get; set; } 
        public IRPSTextBox<FixedAssetEntityView> FAAcquisitionDate { get; set; } 
        public IRPSTextBox<FixedAssetEntityView> FADepreciationStartDate { get; set; } 
        public IRPSComboBox<FixedAssetEntityView> FAStatus { get; set; } 
        public IRPSTextBox<FixedAssetEntityView> FAPurchaseAmount { get; set; } 
        public IRPSTextBox<FixedAssetEntityView> FADepInitialAmount { get; set; } 
        public IRPSTextBox<FixedAssetEntityView> FAResidualAmount { get; set; } 
        public IRPSTextBox<FixedAssetEntityView> FADisposeDate { get; set; } 
        public IRPSComboBox<FixedAssetEntityView> IDFADepreciationType { get; set; } 
        public IRPSComboBox<FixedAssetEntityView> DepreciationMethod { get; set; } 
        public IRPSComboBox<FixedAssetEntityView> DepreciationPeriods { get; set; } 
        public IRPSTextBox<FixedAssetEntityView> DepreciationPercentage { get; set; } 
        public IRPSTextBox<FixedAssetEntityView> DepreciationYears { get; set; } 
        public IRPSTextBox<FixedAssetEntityView> FADepPeriodFixAmount { get; set; } 
        public IRPSTextBox<FixedAssetEntityView> AmountPostedDepreciation { get; set; } 
        public IRPSTextBox<FixedAssetEntityView> LastPostedDepreciation { get; set; } 
        public IRPSTextBox<FixedAssetEntityView> DisposeAmount { get; set; } 
        public IRPSButton<FixedAssetEntityView> LinkToFAValuesCommand { get; set; } 
        public IRPSTextBox<FixedAssetEntityView> FAGroup { get; set; } 
        public IRPSTextBox<FixedAssetEntityView> FALocation1 { get; set; } 
        public IRPSTextBox<FixedAssetEntityView> FALocation2 { get; set; } 
        public IRPSTextBox<FixedAssetEntityView> FALocation3 { get; set; } 
        public IRPSTextBox<FixedAssetEntityView> FABrand { get; set; } 
        public IRPSTextBox<FixedAssetEntityView> FAModel { get; set; } 
        public IRPSTextBox<FixedAssetEntityView> FAType { get; set; } 
        public IRPSTextBox<FixedAssetEntityView> FAChassisNumber { get; set; } 
        public IRPSTextBox<FixedAssetEntityView> FARegistrationNumber { get; set; } 
        public IRPSTextBox<FixedAssetEntityView> FAEngineNumber { get; set; } 
        public IRPSComboBox<FixedAssetEntityView> IDAccInvestment { get; set; } 
        public IRPSComboBox<FixedAssetEntityView> IDAccCumulative { get; set; } 
        public IRPSComboBox<FixedAssetEntityView> IDAccExpense { get; set; } 
        public IRPSComboBox<FixedAssetEntityView> IDAccDispose { get; set; } 
        public IRPSButton<FixedAssetEntityView> ShowFAPreliminariesButton { get; set; } 
        public IRPSCheckbox<FixedAssetEntityView> IsRealEstate { get; set; } 
        public IRPSComboBox<FixedAssetEntityView> Situation { get; set; } 
        public IRPSTextBox<FixedAssetEntityView> CadastralReference { get; set; } 
        public IRPSTextBox<FixedAssetEntityView> HighwayType { get; set; } 
        public IRPSTextBox<FixedAssetEntityView> PublicHighwayName { get; set; } 
        public IRPSTextBox<FixedAssetEntityView> NumberingType { get; set; } 
        public IRPSTextBox<FixedAssetEntityView> KMNumber { get; set; } 
        public IRPSTextBox<FixedAssetEntityView> Type { get; set; } 
        public IRPSTextBox<FixedAssetEntityView> Block { get; set; } 
        public IRPSTextBox<FixedAssetEntityView> Number { get; set; } 
        public IRPSTextBox<FixedAssetEntityView> Stairs { get; set; } 
        public IRPSTextBox<FixedAssetEntityView> Floor { get; set; } 
        public IRPSTextBox<FixedAssetEntityView> Door { get; set; } 
        public IRPSTextBox<FixedAssetEntityView> Complement { get; set; } 
        public IRPSTextBox<FixedAssetEntityView> Town { get; set; } 
        public IRPSTextBox<FixedAssetEntityView> City { get; set; } 
        public IRPSTextBox<FixedAssetEntityView> CityCode { get; set; } 
        public IRPSTextBox<FixedAssetEntityView> CountyCode { get; set; } 
        public IRPSTextBox<FixedAssetEntityView> ZipCode { get; set; } 
        public IRPSButton<FixedAssetEntityView> CalculateCommandButton { get; set; } 
        public IRPSButton<FixedAssetEntityView,FADepreciationGenerateChildDialogView> FADepreciationGenerateChildNavigationCommandButton { get; set; } 
        public IRPSButton<FixedAssetEntityView,DateDisposeDialogView> DateDisposeNavigationCommandButton { get; set; } 
        public IRPSButton<FixedAssetEntityView> ChangePurchaseAmountCommandButton { get; set; } 
        public IRPSButton<FixedAssetEntityView> PrintCommandButton { get; set; } 
        public FAValuesCollectionEditor<FixedAssetEntityView,FAValueView> FAValues { get; set; } 
        public GetOnlyOneDepreciationPlanCollectionEditor<FixedAssetEntityView,FAValueView> GetOnlyOneDepreciationPlan { get; set; } 
        public FAPurchasesCollectionEditor<FixedAssetEntityView,FAValueView> FAPurchases { get; set; } 
        public FAFixedAssetDimensionsCollectionEditor<FixedAssetEntityView,FAValueView> FAFixedAssetDimensions { get; set; } 
        public CuDistFAChangePurchaseAmountsCollectionEditor<FixedAssetEntityView,FAValueView> CuDistFAChangePurchaseAmounts { get; set; } 
        public IRPSSection<FixedAssetEntityView> General { get; set; } 
        public IRPSSection<FixedAssetEntityView> Section1 { get; set; } 
        public IRPSSection<FixedAssetEntityView> Section { get; set; } 
        public IRPSSection<FixedAssetEntityView> Purchase { get; set; } 
        public IRPSSection<FixedAssetEntityView> Analytic { get; set; } 
        public IRPSSection<FixedAssetEntityView> RealState { get; set; } 
        public IRPSSection<FixedAssetEntityView> ChangeAmount { get; set; } 
        public FixedAsset Screen { get; set; }
        public FixedAssetEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class FAValuesCollectionEditor<FixedAssetEntityView,FAValueView>:RPSCollectionEditor<FixedAssetEntityView,FAValueView> where FixedAssetEntityView : class, IView where FAValueView : class, IView
    {
        public  FAValuesGridView<FixedAssetEntityView,FAValueView> GridView {get;set;}
    }
    public partial class FAValuesGridView <FixedAssetEntityView,FAValueView> :  RPSGridView<FixedAssetEntityView,FAValueView> where FixedAssetEntityView : class, IView where FAValueView : class, IView
    {
        public FAValuesGridView(FixedAssetEntityView currentView,FAValueView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDFADepreciationType = RPSControlFactory.CreateRPSGridComboBox<FixedAssetEntityView>("","#47c4a7af-e3d4-4d04-a022-0bd26a0c8ecb .ag-row[role='row']@ROWINDEX [col-id='cIDFADepreciationType']","",true, this.CurrentView);
 
            DepreciationMethod = RPSControlFactory.CreateRPSGridEnumComboBox<FixedAssetEntityView>("","#47c4a7af-e3d4-4d04-a022-0bd26a0c8ecb .ag-row[role='row']@ROWINDEX [col-id='cDepreciationMethod']","",true, this.CurrentView);
 
            DepreciationPeriods = RPSControlFactory.CreateRPSGridEnumComboBox<FixedAssetEntityView>("","#47c4a7af-e3d4-4d04-a022-0bd26a0c8ecb .ag-row[role='row']@ROWINDEX [col-id='cDepreciationPeriods']","",true, this.CurrentView);
 
            DepreciationPercentage = RPSControlFactory.CreateRPSGridFormattedTextBox<FixedAssetEntityView>("","#47c4a7af-e3d4-4d04-a022-0bd26a0c8ecb .ag-row[role='row']@ROWINDEX [col-id='cDepreciationPercentage']","",true, this.CurrentView);
 
            DepreciationYears = RPSControlFactory.CreateRPSGridFormattedTextBox<FixedAssetEntityView>("","#47c4a7af-e3d4-4d04-a022-0bd26a0c8ecb .ag-row[role='row']@ROWINDEX [col-id='cDepreciationYears']","",true, this.CurrentView);
 
            AmountPostedDepreciation = RPSControlFactory.CreateRPSGridFormattedTextBox<FixedAssetEntityView>("","#47c4a7af-e3d4-4d04-a022-0bd26a0c8ecb .ag-row[role='row']@ROWINDEX [col-id='cAmountPostedDepreciation']","",false, this.CurrentView);
 
            LastPostedDepreciation = RPSControlFactory.CreateRPSGridTextBox<FixedAssetEntityView>("","#47c4a7af-e3d4-4d04-a022-0bd26a0c8ecb .ag-row[role='row']@ROWINDEX [col-id='cLastPostedDepreciation']","",false, this.CurrentView);
 
            DepPlansCount = RPSControlFactory.CreateRPSGridFormattedTextBox<FixedAssetEntityView>("","#47c4a7af-e3d4-4d04-a022-0bd26a0c8ecb .ag-row[role='row']@ROWINDEX [col-id='cDepPlansCount']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<FixedAssetEntityView> IDFADepreciationType { get; set; } 
        public IRPSGridComboBox<FixedAssetEntityView> DepreciationMethod { get; set; } 
        public IRPSGridComboBox<FixedAssetEntityView> DepreciationPeriods { get; set; } 
        public IRPSGridTextBox<FixedAssetEntityView> DepreciationPercentage { get; set; } 
        public IRPSGridTextBox<FixedAssetEntityView> DepreciationYears { get; set; } 
        public IRPSGridTextBox<FixedAssetEntityView> AmountPostedDepreciation { get; set; } 
        public IRPSGridTextBox<FixedAssetEntityView> LastPostedDepreciation { get; set; } 
        public IRPSGridTextBox<FixedAssetEntityView> DepPlansCount { get; set; } 
                     
    }
 
        public partial class GetOnlyOneDepreciationPlanCollectionEditor<FixedAssetEntityView,FAValueView>:RPSCollectionEditor<FixedAssetEntityView,FAValueView> where FixedAssetEntityView : class, IView where FAValueView : class, IView
    {
        public  GetOnlyOneDepreciationPlanGridView<FixedAssetEntityView,FAValueView> GridView {get;set;}
    }
    public partial class GetOnlyOneDepreciationPlanGridView <FixedAssetEntityView,FAValueView> :  RPSGridView<FixedAssetEntityView,FAValueView> where FixedAssetEntityView : class, IView where FAValueView : class, IView
    {
        public GetOnlyOneDepreciationPlanGridView(FixedAssetEntityView currentView,FAValueView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            FADepPlan_DepreciationDate = RPSControlFactory.CreateRPSGridTextBox<FixedAssetEntityView>("","#1c86c2cd-7336-498d-a44c-da6752ff9b8a .ag-row[role='row']@ROWINDEX [col-id='cFADepPlan_DepreciationDate']","",false, this.CurrentView);
 
            FADepPlan_PeriodDepAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<FixedAssetEntityView>("","#1c86c2cd-7336-498d-a44c-da6752ff9b8a .ag-row[role='row']@ROWINDEX [col-id='cFADepPlan_PeriodDepAmount']","",false, this.CurrentView);
 
            DepStatus = RPSControlFactory.CreateRPSGridEnumComboBox<FixedAssetEntityView>("","#1c86c2cd-7336-498d-a44c-da6752ff9b8a .ag-row[role='row']@ROWINDEX [col-id='cDepStatus']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<FixedAssetEntityView> FADepPlan_DepreciationDate { get; set; } 
        public IRPSGridTextBox<FixedAssetEntityView> FADepPlan_PeriodDepAmount { get; set; } 
        public IRPSGridComboBox<FixedAssetEntityView> DepStatus { get; set; } 
                     
    }
 
        public partial class FAPurchasesCollectionEditor<FixedAssetEntityView,FAValueView>:RPSCollectionEditor<FixedAssetEntityView,FAValueView> where FixedAssetEntityView : class, IView where FAValueView : class, IView
    {
        public  FAPurchasesGridView<FixedAssetEntityView,FAValueView> GridView {get;set;}
    }
    public partial class FAPurchasesGridView <FixedAssetEntityView,FAValueView> :  RPSGridView<FixedAssetEntityView,FAValueView> where FixedAssetEntityView : class, IView where FAValueView : class, IView
    {
        public FAPurchasesGridView(FixedAssetEntityView currentView,FAValueView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NumLine = RPSControlFactory.CreateRPSGridFormattedTextBox<FixedAssetEntityView>("","#fec0e5d6-16f8-4747-a481-019340b062dc .ag-row[role='row']@ROWINDEX [col-id='cNumLine']","",true, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<FixedAssetEntityView>("","#fec0e5d6-16f8-4747-a481-019340b062dc .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",true, this.CurrentView);
 
            IDSupplier = RPSControlFactory.CreateRPSGridComboBox<FixedAssetEntityView>("","#fec0e5d6-16f8-4747-a481-019340b062dc .ag-row[role='row']@ROWINDEX [col-id='cIDSupplier']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<FixedAssetEntityView>("","#fec0e5d6-16f8-4747-a481-019340b062dc .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<FixedAssetEntityView>("","#fec0e5d6-16f8-4747-a481-019340b062dc .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<FixedAssetEntityView>("","#fec0e5d6-16f8-4747-a481-019340b062dc .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<FixedAssetEntityView> NumLine { get; set; } 
        public IRPSGridTextBox<FixedAssetEntityView> InvoiceDate { get; set; } 
        public IRPSGridComboBox<FixedAssetEntityView> IDSupplier { get; set; } 
        public IRPSGridTextBox<FixedAssetEntityView> Amount { get; set; } 
        public IRPSGridTextBox<FixedAssetEntityView> Description { get; set; } 
        public IRPSGridComboBox<FixedAssetEntityView> IDArticle { get; set; } 
                     
    }
 
        public partial class FAFixedAssetDimensionsCollectionEditor<FixedAssetEntityView,FAValueView>:RPSCollectionEditor<FixedAssetEntityView,FAValueView> where FixedAssetEntityView : class, IView where FAValueView : class, IView
    {
        public  FAFixedAssetDimensionsGridView<FixedAssetEntityView,FAValueView> GridView {get;set;}
    }
    public partial class FAFixedAssetDimensionsGridView <FixedAssetEntityView,FAValueView> :  RPSGridView<FixedAssetEntityView,FAValueView> where FixedAssetEntityView : class, IView where FAValueView : class, IView
    {
        public FAFixedAssetDimensionsGridView(FixedAssetEntityView currentView,FAValueView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            FAAccount = RPSControlFactory.CreateRPSGridEnumComboBox<FixedAssetEntityView>("","#51b4e932-cb3c-4e4f-a261-062e5ada5226 .ag-row[role='row']@ROWINDEX [col-id='cFAAccount']","",true, this.CurrentView);
 
            IDDimension = RPSControlFactory.CreateRPSGridComboBox<FixedAssetEntityView>("","#51b4e932-cb3c-4e4f-a261-062e5ada5226 .ag-row[role='row']@ROWINDEX [col-id='cIDDimension']","",true, this.CurrentView);
 
            IDDimValue = RPSControlFactory.CreateRPSGridComboBox<FixedAssetEntityView>("","#51b4e932-cb3c-4e4f-a261-062e5ada5226 .ag-row[role='row']@ROWINDEX [col-id='cIDDimValue']","",true, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<FixedAssetEntityView>("","#51b4e932-cb3c-4e4f-a261-062e5ada5226 .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<FixedAssetEntityView> FAAccount { get; set; } 
        public IRPSGridComboBox<FixedAssetEntityView> IDDimension { get; set; } 
        public IRPSGridComboBox<FixedAssetEntityView> IDDimValue { get; set; } 
        public IRPSGridTextBox<FixedAssetEntityView> Percentage { get; set; } 
                     
    }
 
        public partial class CuDistFAChangePurchaseAmountsCollectionEditor<FixedAssetEntityView,FAValueView>:RPSCollectionEditor<FixedAssetEntityView,FAValueView> where FixedAssetEntityView : class, IView where FAValueView : class, IView
    {
        public  CuDistFAChangePurchaseAmountsGridView<FixedAssetEntityView,FAValueView> GridView {get;set;}
    }
    public partial class CuDistFAChangePurchaseAmountsGridView <FixedAssetEntityView,FAValueView> :  RPSGridView<FixedAssetEntityView,FAValueView> where FixedAssetEntityView : class, IView where FAValueView : class, IView
    {
        public CuDistFAChangePurchaseAmountsGridView(FixedAssetEntityView currentView,FAValueView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Date = RPSControlFactory.CreateRPSGridTextBox<FixedAssetEntityView>("","#c52ad1e8-ddbb-404e-b0e7-39033af8b67d .ag-row[role='row']@ROWINDEX [col-id='cDate']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<FixedAssetEntityView>("","#c52ad1e8-ddbb-404e-b0e7-39033af8b67d .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            CodInvoice = RPSControlFactory.CreateRPSGridTextBox<FixedAssetEntityView>("","#c52ad1e8-ddbb-404e-b0e7-39033af8b67d .ag-row[role='row']@ROWINDEX [col-id='cCodInvoice']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<FixedAssetEntityView>("","#c52ad1e8-ddbb-404e-b0e7-39033af8b67d .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 
            IDSupplier = RPSControlFactory.CreateRPSGridComboBox<FixedAssetEntityView>("","#c52ad1e8-ddbb-404e-b0e7-39033af8b67d .ag-row[role='row']@ROWINDEX [col-id='cIDSupplier']","",false, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<FixedAssetEntityView>("","#c52ad1e8-ddbb-404e-b0e7-39033af8b67d .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            Comment = RPSControlFactory.CreateRPSGridMemoTextBox<FixedAssetEntityView>("","#c52ad1e8-ddbb-404e-b0e7-39033af8b67d .ag-row[role='row']@ROWINDEX [col-id='cComment']","",false, this.CurrentView);
 
            Status = RPSControlFactory.CreateRPSGridEnumComboBox<FixedAssetEntityView>("","#c52ad1e8-ddbb-404e-b0e7-39033af8b67d .ag-row[role='row']@ROWINDEX [col-id='cStatus']","",true, this.CurrentView);
 
            PreviousPurchasePrice = RPSControlFactory.CreateRPSGridFormattedTextBox<FixedAssetEntityView>("","#c52ad1e8-ddbb-404e-b0e7-39033af8b67d .ag-row[role='row']@ROWINDEX [col-id='cPreviousPurchasePrice1']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<FixedAssetEntityView> Date { get; set; } 
        public IRPSGridComboBox<FixedAssetEntityView> Type { get; set; } 
        public IRPSGridTextBox<FixedAssetEntityView> CodInvoice { get; set; } 
        public IRPSGridTextBox<FixedAssetEntityView> InvoiceDate { get; set; } 
        public IRPSGridComboBox<FixedAssetEntityView> IDSupplier { get; set; } 
        public IRPSGridTextBox<FixedAssetEntityView> Amount { get; set; } 
        public IRPSGridTextBox<FixedAssetEntityView> Comment { get; set; } 
        public IRPSGridComboBox<FixedAssetEntityView> Status { get; set; } 
        public IRPSGridTextBox<FixedAssetEntityView> PreviousPurchasePrice { get; set; } 
                     
    }
 
    }
  
            
    public partial class FAValueView : View
    {
        public FAValueView(FixedAsset screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<FAValueView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FAValueView,FixedAssetEntityView>( this,Screen.FixedAssetEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<FAValueView,FixedAssetEntityView>( this,Screen.FixedAssetEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<FAValueView,FixedAssetEntityView>( this,Screen.FixedAssetEntityView);
 
            IDFADepreciationType = RPSControlFactory.CreateRPSComboBox<FAValueView>("e7c9b04f-2126-4a79-89a0-b38ecc171f1c","","",true, this);
 
            DepreciationMethod = RPSControlFactory.CreateRPSEnumComboBox<FAValueView>("ea679f5a-da51-49fb-9d66-4083f15c7da6","","",true, this);
 
            DepreciationPeriods = RPSControlFactory.CreateRPSEnumComboBox<FAValueView>("280db170-f734-497e-9f1b-c45bf8aab4f8","","",true, this);
 
            DepreciationPercentage = RPSControlFactory.CreateRPSFormattedTextBox<FAValueView>("9bb0687a-e40d-42d8-a377-50013e0fb934","","",true, this);
 
            DepreciationYears = RPSControlFactory.CreateRPSFormattedTextBox<FAValueView>("c50da0bd-e9d4-4036-8f52-77f671496ca9","","",true, this);
 
            FADepPeriodFixAmount = RPSControlFactory.CreateRPSFormattedTextBox<FAValueView>("d9ddd23b-8ce9-435d-9289-4a4215b05561","","",true, this);
 
            AmountPostedDepreciation = RPSControlFactory.CreateRPSFormattedTextBox<FAValueView>("53de2978-9c6f-4936-a6fd-859f19669428","","",false, this);
 
            LastPostedDepreciation = RPSControlFactory.CreateRPSTextBox<FAValueView>("ef168d88-0e47-40f5-a419-4eda2c2d6e23","","",false, this);
 
            DisposeAmount = RPSControlFactory.CreateRPSFormattedTextBox<FAValueView>("2fd36967-8840-40ba-ad14-c40d8b1cb374","","",true, this);
 
            CalculateCommandButton = RPSControlFactory.CreateRPSButton<FAValueView>( "3882ae21-3b67-4c4e-8438-f2b816a6b0fc","","",this);
 
            FAValueDepreciationGenerateChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<FAValueView,FAValueDepreciationGenerateChildDialogView>("509988cf-f5b7-40eb-867f-03d288db3448","","", this,Screen.FAValueDepreciationGenerateChildDialogView);
 
            CollectionInit params_FADepPlans = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="05fe7e6e-1091-4007-b51f-82a8aaebbc0b",CSSSelectorGrid="",XPathGrid=""};
            FADepPlans = RPSControlFactory.RPSCreateCollectionWithGrid<FADepPlansCollectionEditor<FAValueView,FADepPlanView>,FAValueView,FADepPlanView>( params_FADepPlans,this,Screen.FADepPlanView);
 

        }
        public IRPSButton<FAValueView> DeleteButton { get; set; } 
        public IRPSButton<FAValueView,FixedAssetEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FAValueView,FixedAssetEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<FAValueView,FixedAssetEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<FAValueView> IDFADepreciationType { get; set; } 
        public IRPSComboBox<FAValueView> DepreciationMethod { get; set; } 
        public IRPSComboBox<FAValueView> DepreciationPeriods { get; set; } 
        public IRPSTextBox<FAValueView> DepreciationPercentage { get; set; } 
        public IRPSTextBox<FAValueView> DepreciationYears { get; set; } 
        public IRPSTextBox<FAValueView> FADepPeriodFixAmount { get; set; } 
        public IRPSTextBox<FAValueView> AmountPostedDepreciation { get; set; } 
        public IRPSTextBox<FAValueView> LastPostedDepreciation { get; set; } 
        public IRPSTextBox<FAValueView> DisposeAmount { get; set; } 
        public IRPSButton<FAValueView> CalculateCommandButton { get; set; } 
        public IRPSButton<FAValueView,FAValueDepreciationGenerateChildDialogView> FAValueDepreciationGenerateChildNavigationCommandButton { get; set; } 
        public FADepPlansCollectionEditor<FAValueView,FADepPlanView> FADepPlans { get; set; } 
        public FixedAsset Screen { get; set; }
        public FAValueView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class FADepPlansCollectionEditor<FAValueView,FADepPlanView>:RPSCollectionEditor<FAValueView,FADepPlanView> where FAValueView : class, IView where FADepPlanView : class, IView
    {
        public  FADepPlansGridView<FAValueView,FADepPlanView> GridView {get;set;}
    }
    public partial class FADepPlansGridView <FAValueView,FADepPlanView> :  RPSGridView<FAValueView,FADepPlanView> where FAValueView : class, IView where FADepPlanView : class, IView
    {
        public FADepPlansGridView(FAValueView currentView,FADepPlanView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DepreciationDate = RPSControlFactory.CreateRPSGridTextBox<FAValueView>("","#05fe7e6e-1091-4007-b51f-82a8aaebbc0b .ag-row[role='row']@ROWINDEX [col-id='cDepreciationDate']","",true, this.CurrentView);
 
            PeriodDepAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<FAValueView>("","#05fe7e6e-1091-4007-b51f-82a8aaebbc0b .ag-row[role='row']@ROWINDEX [col-id='cPeriodDepAmount']","",true, this.CurrentView);
 
            DepStatus = RPSControlFactory.CreateRPSGridEnumComboBox<FAValueView>("","#05fe7e6e-1091-4007-b51f-82a8aaebbc0b .ag-row[role='row']@ROWINDEX [col-id='cDepStatus']","",true, this.CurrentView);
 
            OutstandingAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<FAValueView>("","#05fe7e6e-1091-4007-b51f-82a8aaebbc0b .ag-row[role='row']@ROWINDEX [col-id='cOutstandingAmount']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<FAValueView> DepreciationDate { get; set; } 
        public IRPSGridTextBox<FAValueView> PeriodDepAmount { get; set; } 
        public IRPSGridComboBox<FAValueView> DepStatus { get; set; } 
        public IRPSGridTextBox<FAValueView> OutstandingAmount { get; set; } 
                     
    }
 
    }
  
            
    public partial class FADepPlanView : View
    {
        public FADepPlanView(FixedAsset screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<FADepPlanView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FADepPlanView,FAValueView>( this,Screen.FAValueView);
 
            BackButton = RPSControlFactory.RPSBackButton<FADepPlanView,FAValueView>( this,Screen.FAValueView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<FADepPlanView,FAValueView>( this,Screen.FAValueView);
 
            DepreciationDate = RPSControlFactory.CreateRPSTextBox<FADepPlanView>("86398c2f-fab3-4e93-9c1c-2fc63af255d7","","",true, this);
 
            PeriodDepAmount = RPSControlFactory.CreateRPSFormattedTextBox<FADepPlanView>("9ae30f02-c749-402a-8ead-1eb05e749931","","",true, this);
 
            DepStatus = RPSControlFactory.CreateRPSEnumComboBox<FADepPlanView>("8f70e5cd-6859-4618-a8d3-3d73f3e2b33a","","",true, this);
 
            OutstandingAmount = RPSControlFactory.CreateRPSFormattedTextBox<FADepPlanView>("88fc782f-8ef9-4ba3-b6ce-d8b4b2b070cf","","",false, this);
 

        }
        public IRPSButton<FADepPlanView> DeleteButton { get; set; } 
        public IRPSButton<FADepPlanView,FAValueView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FADepPlanView,FAValueView> BackButton { get; set; } 
        public IRPSAcceptButton<FADepPlanView,FAValueView> AcceptButton { get; set; } 
        public IRPSTextBox<FADepPlanView> DepreciationDate { get; set; } 
        public IRPSTextBox<FADepPlanView> PeriodDepAmount { get; set; } 
        public IRPSComboBox<FADepPlanView> DepStatus { get; set; } 
        public IRPSTextBox<FADepPlanView> OutstandingAmount { get; set; } 
        public FixedAsset Screen { get; set; }
        public FADepPlanView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FAPurchaseView : View
    {
        public FAPurchaseView(FixedAsset screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<FAPurchaseView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FAPurchaseView,FixedAssetEntityView>( this,Screen.FixedAssetEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<FAPurchaseView,FixedAssetEntityView>( this,Screen.FixedAssetEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<FAPurchaseView,FixedAssetEntityView>( this,Screen.FixedAssetEntityView);
 
            IDInvoice = RPSControlFactory.CreateRPSComboBox<FAPurchaseView>("83b381a1-80a2-4c7b-b232-3fb3d8c89e34","","",false, this);
 
            CodInvoice = RPSControlFactory.CreateRPSTextBox<FAPurchaseView>("175b71d6-9e99-407d-9118-707e1a392f34","","",true, this);
 
            InvoiceDate = RPSControlFactory.CreateRPSTextBox<FAPurchaseView>("e9fae3e7-0512-4cac-a4d8-732ce5ecb40b","","",true, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<FAPurchaseView>("24fc3ab3-85c0-4aba-8f8e-f6940dd6c609","","",true, this);
 
            NumLine = RPSControlFactory.CreateRPSFormattedTextBox<FAPurchaseView>("8956dacd-52ed-4844-8d5c-9954df7cd4f5","","",true, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<FAPurchaseView>("09f85954-6b39-4ec3-91d1-76bcbc3b8f1d","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<FAPurchaseView>("0eb618bf-daed-4ec9-af34-efa7f1103b43","","",false, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<FAPurchaseView>("4d2d0294-7c50-454d-a8e9-936fe245f123","","",false, this);
 

        }
        public IRPSButton<FAPurchaseView> DeleteButton { get; set; } 
        public IRPSButton<FAPurchaseView,FixedAssetEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FAPurchaseView,FixedAssetEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<FAPurchaseView,FixedAssetEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<FAPurchaseView> IDInvoice { get; set; } 
        public IRPSTextBox<FAPurchaseView> CodInvoice { get; set; } 
        public IRPSTextBox<FAPurchaseView> InvoiceDate { get; set; } 
        public IRPSComboBox<FAPurchaseView> IDSupplier { get; set; } 
        public IRPSTextBox<FAPurchaseView> NumLine { get; set; } 
        public IRPSComboBox<FAPurchaseView> IDArticle { get; set; } 
        public IRPSTextBox<FAPurchaseView> Description { get; set; } 
        public IRPSTextBox<FAPurchaseView> Amount { get; set; } 
        public FixedAsset Screen { get; set; }
        public FAPurchaseView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FAFixedAssetDimensionView : View
    {
        public FAFixedAssetDimensionView(FixedAsset screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<FAFixedAssetDimensionView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FAFixedAssetDimensionView,FixedAssetEntityView>( this,Screen.FixedAssetEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<FAFixedAssetDimensionView,FixedAssetEntityView>( this,Screen.FixedAssetEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<FAFixedAssetDimensionView,FixedAssetEntityView>( this,Screen.FixedAssetEntityView);
 
            FAAccount = RPSControlFactory.CreateRPSEnumComboBox<FAFixedAssetDimensionView>("f0014859-17eb-443a-b2bb-a78d8edeb089","","",true, this);
 
            IDAccInvestment = RPSControlFactory.CreateRPSComboBox<FAFixedAssetDimensionView>("a278b770-aa9d-47b3-b208-4df54f95b0f8","","",false, this);
 
            IDAccCumulative = RPSControlFactory.CreateRPSComboBox<FAFixedAssetDimensionView>("5e3abf2e-fab1-4994-8959-5ddf543c3fad","","",false, this);
 
            IDAccExpense = RPSControlFactory.CreateRPSComboBox<FAFixedAssetDimensionView>("4c1ea50c-b118-439f-8c21-3a2333771aa6","","",false, this);
 
            IDAccDispose = RPSControlFactory.CreateRPSComboBox<FAFixedAssetDimensionView>("09d492e1-ffe8-442b-a154-d678a26b88dd","","",false, this);
 
            IDDimension = RPSControlFactory.CreateRPSComboBox<FAFixedAssetDimensionView>("c8da6515-f162-4453-a4d9-5fac2d3c0ca6","","",true, this);
 
            IDDimValue = RPSControlFactory.CreateRPSComboBox<FAFixedAssetDimensionView>("647e59ee-a93e-4a55-a938-012f0c6d244a","","",true, this);
 
            Percentage = RPSControlFactory.CreateRPSFormattedTextBox<FAFixedAssetDimensionView>("c2fd92b9-e0dd-4271-9928-329c40c440f6","","",true, this);
 

        }
        public IRPSButton<FAFixedAssetDimensionView> DeleteButton { get; set; } 
        public IRPSButton<FAFixedAssetDimensionView,FixedAssetEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FAFixedAssetDimensionView,FixedAssetEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<FAFixedAssetDimensionView,FixedAssetEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<FAFixedAssetDimensionView> FAAccount { get; set; } 
        public IRPSComboBox<FAFixedAssetDimensionView> IDAccInvestment { get; set; } 
        public IRPSComboBox<FAFixedAssetDimensionView> IDAccCumulative { get; set; } 
        public IRPSComboBox<FAFixedAssetDimensionView> IDAccExpense { get; set; } 
        public IRPSComboBox<FAFixedAssetDimensionView> IDAccDispose { get; set; } 
        public IRPSComboBox<FAFixedAssetDimensionView> IDDimension { get; set; } 
        public IRPSComboBox<FAFixedAssetDimensionView> IDDimValue { get; set; } 
        public IRPSTextBox<FAFixedAssetDimensionView> Percentage { get; set; } 
        public FixedAsset Screen { get; set; }
        public FAFixedAssetDimensionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DateDisposeDialogView : View
    {
        public DateDisposeDialogView(FixedAsset screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DateDispose = RPSControlFactory.CreateRPSTextBox<DateDisposeDialogView>("0e2e7d87-09c0-4c9a-bb9b-a6395135662c","","",false, this);
 

        }
        public IRPSTextBox<DateDisposeDialogView> DateDispose { get; set; } 
        public FixedAsset Screen { get; set; }
        public DateDisposeDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FAValueCalculateDepreciationPlanChildDialogView : View
    {
        public FAValueCalculateDepreciationPlanChildDialogView(FixedAsset screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CheckDepreciatedPeriods = RPSControlFactory.CreateRPSCheckBox<FAValueCalculateDepreciationPlanChildDialogView>("5c06c4bd-f1cf-455c-9df7-dfcca9370016","","",false, this);
 

        }
        public IRPSCheckbox<FAValueCalculateDepreciationPlanChildDialogView> CheckDepreciatedPeriods { get; set; } 
        public FixedAsset Screen { get; set; }
        public FAValueCalculateDepreciationPlanChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FADepreciationGenerateChildDialogView : View
    {
        public FADepreciationGenerateChildDialogView(FixedAsset screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DateFrom = RPSControlFactory.CreateRPSTextBox<FADepreciationGenerateChildDialogView>("20f70179-0fc7-4bb6-965f-f10df21e07eb","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<FADepreciationGenerateChildDialogView>("963a134a-60e2-4647-827c-cd7c713f2b01","","",false, this);
 
            CheckGenerateDepreciation = RPSControlFactory.CreateRPSCheckBox<FADepreciationGenerateChildDialogView>("47c60cc4-3ff6-4588-8262-2a1fa4939eea","","",false, this);
 
            CheckGenerateAccountingEntries = RPSControlFactory.CreateRPSCheckBox<FADepreciationGenerateChildDialogView>("cf4a2c59-e944-42c5-8599-2db04cb00dae","","",false, this);
 
            AccountingDate = RPSControlFactory.CreateRPSTextBox<FADepreciationGenerateChildDialogView>("db64c1f5-4209-444e-aa11-3757b531cf15","","",false, this);
 

        }
        public IRPSTextBox<FADepreciationGenerateChildDialogView> DateFrom { get; set; } 
        public IRPSTextBox<FADepreciationGenerateChildDialogView> DateTo { get; set; } 
        public IRPSCheckbox<FADepreciationGenerateChildDialogView> CheckGenerateDepreciation { get; set; } 
        public IRPSCheckbox<FADepreciationGenerateChildDialogView> CheckGenerateAccountingEntries { get; set; } 
        public IRPSTextBox<FADepreciationGenerateChildDialogView> AccountingDate { get; set; } 
        public FixedAsset Screen { get; set; }
        public FADepreciationGenerateChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FAValueDepreciationGenerateChildDialogView : View
    {
        public FAValueDepreciationGenerateChildDialogView(FixedAsset screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DateFrom = RPSControlFactory.CreateRPSTextBox<FAValueDepreciationGenerateChildDialogView>("62280fd8-e10d-413a-abe8-8133842d3753","","",true, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<FAValueDepreciationGenerateChildDialogView>("f8560de2-63c5-4c4f-ae81-4b72c6545370","","",true, this);
 
            CheckGenerateDepreciation = RPSControlFactory.CreateRPSCheckBox<FAValueDepreciationGenerateChildDialogView>("58b6cd3e-2dad-41aa-a75e-52db8a68d182","","",false, this);
 
            CheckGenerateAccountingEntries = RPSControlFactory.CreateRPSCheckBox<FAValueDepreciationGenerateChildDialogView>("4dc106b6-6948-4a72-acf5-8db11c21ec72","","",false, this);
 
            AccountingDate = RPSControlFactory.CreateRPSTextBox<FAValueDepreciationGenerateChildDialogView>("47ad05d5-319a-4b72-a0a5-91a21a118921","","",false, this);
 

        }
        public IRPSTextBox<FAValueDepreciationGenerateChildDialogView> DateFrom { get; set; } 
        public IRPSTextBox<FAValueDepreciationGenerateChildDialogView> DateTo { get; set; } 
        public IRPSCheckbox<FAValueDepreciationGenerateChildDialogView> CheckGenerateDepreciation { get; set; } 
        public IRPSCheckbox<FAValueDepreciationGenerateChildDialogView> CheckGenerateAccountingEntries { get; set; } 
        public IRPSTextBox<FAValueDepreciationGenerateChildDialogView> AccountingDate { get; set; } 
        public FixedAsset Screen { get; set; }
        public FAValueDepreciationGenerateChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FACalculateDepreciationPlanChildDialogView : View
    {
        public FACalculateDepreciationPlanChildDialogView(FixedAsset screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CheckDepreciatedPeriods = RPSControlFactory.CreateRPSCheckBox<FACalculateDepreciationPlanChildDialogView>("668dfe6c-9995-47fd-928f-7a76ec2d77dc","","",false, this);
 

        }
        public IRPSCheckbox<FACalculateDepreciationPlanChildDialogView> CheckDepreciatedPeriods { get; set; } 
        public FixedAsset Screen { get; set; }
        public FACalculateDepreciationPlanChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}