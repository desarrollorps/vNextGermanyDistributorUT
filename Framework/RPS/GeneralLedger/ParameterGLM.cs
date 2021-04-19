    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.ParameterGLM
{
    //RPS VERSION 1.0.0.0
    public partial class ParameterGLM:Screen
    {
        public ParameterGLM():base()
        {
            this.URL = "generalledger.parameterglm";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ParameterGLMEntityView  = new ParameterGLMEntityView(this); 
            ParamFinancialDocView  = new ParamFinancialDocView(this); 
            SearchTypeView  = new SearchTypeView(this); 
            UserRestrictedView  = new UserRestrictedView(this); 
            EUInvoiceView  = new EUInvoiceView(this); 
            ParameterGLMEntityView.InitializeControls(); 
            ParamFinancialDocView.InitializeControls(); 
            SearchTypeView.InitializeControls(); 
            UserRestrictedView.InitializeControls(); 
            EUInvoiceView.InitializeControls(); 
           
        }
      
            public ParameterGLMEntityView ParameterGLMEntityView {get; set; } 
            public ParamFinancialDocView ParamFinancialDocView {get; set; } 
            public SearchTypeView SearchTypeView {get; set; } 
            public UserRestrictedView UserRestrictedView {get; set; } 
            public EUInvoiceView EUInvoiceView {get; set; } 
    }
            
    public partial class ParameterGLMEntityView : View
    {
        public ParameterGLMEntityView(ParameterGLM screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            AccLength = RPSControlFactory.CreateRPSFormattedTextBox<ParameterGLMEntityView>("5341adc4-ede6-474a-84ec-59b053ada423","","",false, this);
 
            AllowModifyVoucher = RPSControlFactory.CreateRPSCheckBox<ParameterGLMEntityView>("fed6351e-98c2-48d0-bb04-532a18ae3f4d","","",false, this);
 
            AllowDeleteVoucher = RPSControlFactory.CreateRPSCheckBox<ParameterGLMEntityView>("42606751-b080-466d-92a4-6f1f5b44f865","","",true, this);
 
            NegativeAmount = RPSControlFactory.CreateRPSCheckBox<ParameterGLMEntityView>("fe0e6c85-d3d7-4a63-8756-a182100dddca","","",true, this);
 
            CheckInvoiceDate = RPSControlFactory.CreateRPSCheckBox<ParameterGLMEntityView>("2ee785b7-5ba6-423e-abdb-0e56cb45eb12","","",true, this);
 
            CheckDeliveryDate = RPSControlFactory.CreateRPSCheckBox<ParameterGLMEntityView>("2dc026fb-e86b-4a54-a888-5f53c85e117f","","",true, this);
 
            IDFADepTypeFiscal = RPSControlFactory.CreateRPSComboBox<ParameterGLMEntityView>("d8c27989-07e3-4c93-a3c7-5362422ead3a","","",false, this);
 
            IDDimensionBusiness = RPSControlFactory.CreateRPSComboBox<ParameterGLMEntityView>("840baaa2-6d32-4fe7-a0ee-dc293e89997b","","",false, this);
 
            IDDimensionThird = RPSControlFactory.CreateRPSComboBox<ParameterGLMEntityView>("577f674e-c259-47a4-8eab-91453284ebcd","","",false, this);
 
            IDDimensionProject = RPSControlFactory.CreateRPSComboBox<ParameterGLMEntityView>("56fe81ee-cef4-426e-bdc7-2fb9425d8d0e","","",false, this);
 
            IDThirdAccTypeAP = RPSControlFactory.CreateRPSComboBox<ParameterGLMEntityView>("b7ebb7d8-4c23-4759-bc42-a790df301328","","",true, this);
 
            IDThirdAccTypeAR = RPSControlFactory.CreateRPSComboBox<ParameterGLMEntityView>("a0074381-7388-4308-a85b-c893d9173408","","",true, this);
 
            IDArticleAccType = RPSControlFactory.CreateRPSComboBox<ParameterGLMEntityView>("0c48f98c-383f-4756-a6e0-773400140583","","",true, this);
 
            IDVoucherTypeSupplier = RPSControlFactory.CreateRPSComboBox<ParameterGLMEntityView>("98b51f31-fbd7-4c60-994b-9fc717c97f8a","","",true, this);
 
            IDVoucherTypeCustomer = RPSControlFactory.CreateRPSComboBox<ParameterGLMEntityView>("82feb0bd-cf0f-4a36-aa36-07ea49e04bb9","","",true, this);
 
            IDVoucherTypeFA = RPSControlFactory.CreateRPSComboBox<ParameterGLMEntityView>("99603731-0fd2-4220-bfc9-48446ca34991","","",false, this);
 
            IDVoucherTypeSignLeasing = RPSControlFactory.CreateRPSComboBox<ParameterGLMEntityView>("45ebcafc-c6e0-40fe-9fad-e805f35bf776","","",false, this);
 
            IDVoucherTypeTRAExp = RPSControlFactory.CreateRPSComboBox<ParameterGLMEntityView>("35fcf8db-4012-4e81-b52e-c1fde7699762","","",false, this);
 
            IDVoucherTypeTRAPay = RPSControlFactory.CreateRPSComboBox<ParameterGLMEntityView>("ddd3d054-dab4-4b57-8f00-168ce40ab26a","","",false, this);
 
            IDAccConceptPurchase = RPSControlFactory.CreateRPSComboBox<ParameterGLMEntityView>("f3afd226-40c2-4f04-a7fc-867c6f529f23","","",false, this);
 
            IDAccConceptSales = RPSControlFactory.CreateRPSComboBox<ParameterGLMEntityView>("074e78b4-7028-44e6-b374-18db240faeef","","",false, this);
 
            IDAccConceptFA = RPSControlFactory.CreateRPSComboBox<ParameterGLMEntityView>("c157a325-cbf8-4ca0-ac66-cb97ca4773d4","","",false, this);
 
            IDAccConceptLeasing = RPSControlFactory.CreateRPSComboBox<ParameterGLMEntityView>("22184a2f-c092-4c54-82fd-f72c826e6dfe","","",false, this);
 
            IDAccConceptARP = RPSControlFactory.CreateRPSComboBox<ParameterGLMEntityView>("b67ed9f2-343e-4320-95bb-63a54857b477","","",false, this);
 
            IDAccConceptTRAExp = RPSControlFactory.CreateRPSComboBox<ParameterGLMEntityView>("6d455306-032f-468f-a27e-60a93259a45f","","",false, this);
 
            IDAccConceptTRAPay = RPSControlFactory.CreateRPSComboBox<ParameterGLMEntityView>("897f0c2e-f4f9-4228-a511-f4647f5b3d92","","",false, this);
 
            IDVoucherSeriesBookPurchase = RPSControlFactory.CreateRPSComboBox<ParameterGLMEntityView>("afa3bdba-2443-4bdd-b15a-c30760d1976b","","",false, this);
 
            IDVoucherSeriesBookSales = RPSControlFactory.CreateRPSComboBox<ParameterGLMEntityView>("317e4f36-ce05-47ad-a635-db8af81ba111","","",false, this);
 
            IDVoucherSeriesBookFA = RPSControlFactory.CreateRPSComboBox<ParameterGLMEntityView>("3658373a-c74b-4c7a-a7d3-935e94253395","","",false, this);
 
            IDVoucherSeriesBookLeasing = RPSControlFactory.CreateRPSComboBox<ParameterGLMEntityView>("90bd0b2e-60a9-41bb-b6f1-7eae4a781149","","",false, this);
 
            IDVoucherSeriesBookRP = RPSControlFactory.CreateRPSComboBox<ParameterGLMEntityView>("6ad7f358-5a83-4668-8fcc-c4f47ffb80a2","","",false, this);
 
            IDVoucherSeriesBookWarehouse = RPSControlFactory.CreateRPSComboBox<ParameterGLMEntityView>("34ce7933-3535-4121-bac2-d369c599233c","","",false, this);
 
            IDVoucherSeriesBookTRAExp = RPSControlFactory.CreateRPSComboBox<ParameterGLMEntityView>("933797eb-6783-4dd8-8003-a3df3ea23597","","",false, this);
 
            IDVoucherSeriesBookTRAPay = RPSControlFactory.CreateRPSComboBox<ParameterGLMEntityView>("162f7452-d924-4956-b259-f8ce7c3b0603","","",false, this);
 
            DirectPurchase = RPSControlFactory.CreateRPSCheckBox<ParameterGLMEntityView>("6b277ecc-089d-4137-bd4d-7efc66fa6e9f","","",true, this);
 
            DirectSales = RPSControlFactory.CreateRPSCheckBox<ParameterGLMEntityView>("d20ef917-5314-47c4-9290-07b60842a2b7","","",true, this);
 
            DirectFA = RPSControlFactory.CreateRPSCheckBox<ParameterGLMEntityView>("7f592a9e-2bad-4f78-9e65-0a67a3034df2","","",true, this);
 
            DirectLeasing = RPSControlFactory.CreateRPSCheckBox<ParameterGLMEntityView>("db62538f-8094-4212-b416-f2f0f26a4aac","","",true, this);
 
            DirectRP = RPSControlFactory.CreateRPSCheckBox<ParameterGLMEntityView>("822d4181-3e02-457e-a573-b29cab095363","","",true, this);
 
            DirectWarehouse = RPSControlFactory.CreateRPSCheckBox<ParameterGLMEntityView>("56c63b5c-b464-4d26-b9fc-dfdf30d4fb3c","","",true, this);
 
            DirectTRA = RPSControlFactory.CreateRPSCheckBox<ParameterGLMEntityView>("87eccd28-3804-4e9b-a91d-aef8b98c0687","","",true, this);
 
            PurTransferGLInvZero = RPSControlFactory.CreateRPSCheckBox<ParameterGLMEntityView>("5c936e63-5d18-4442-a169-fc9db1dc75d4","","",true, this);
 
            PostDiscountPurchase = RPSControlFactory.CreateRPSEnumComboBox<ParameterGLMEntityView>("c88a1694-1383-4054-bbcf-cfe496bcd8cc","","",true, this);
 
            PostDiscountLinePurchase = RPSControlFactory.CreateRPSCheckBox<ParameterGLMEntityView>("f1fa1a4f-952d-46fc-9834-2da78775661f","","",true, this);
 
            AccRetentionPurchase = RPSControlFactory.CreateRPSEnumComboBox<ParameterGLMEntityView>("406da003-a578-4133-af5a-a7b94501546e","","",true, this);
 
            FacTransferGLInvZero = RPSControlFactory.CreateRPSCheckBox<ParameterGLMEntityView>("e30ac543-e32e-41b9-b5a9-c7c95be91c7c","","",true, this);
 
            PostDiscountSales = RPSControlFactory.CreateRPSEnumComboBox<ParameterGLMEntityView>("66df448a-788c-4c45-9876-b0dcd3c26888","","",true, this);
 
            PostDiscountLineSales = RPSControlFactory.CreateRPSCheckBox<ParameterGLMEntityView>("eb9b94d3-0f45-4117-a877-6ec7ac2ce622","","",true, this);
 
            AccRetentionSales = RPSControlFactory.CreateRPSEnumComboBox<ParameterGLMEntityView>("9baec711-ea10-48ea-86e7-c211bd5557bf","","",true, this);
 
            GroupAtClosing = RPSControlFactory.CreateRPSCheckBox<ParameterGLMEntityView>("8f065f5d-0f07-4aa0-bc02-91a145246fcb","","",true, this);
 
            IDIntAccProjectEmployee = RPSControlFactory.CreateRPSComboBox<ParameterGLMEntityView>("28451c4c-9c7e-43d3-8315-642c74bb8d96","","",false, this);
 
            IDIntAccProjectMachine = RPSControlFactory.CreateRPSComboBox<ParameterGLMEntityView>("65becd3b-a82a-4f94-96f2-f0221c96b3dd","","",false, this);
 
            IDIntAccProjectTool = RPSControlFactory.CreateRPSComboBox<ParameterGLMEntityView>("fc63bbd2-8521-4bc1-b815-63493b40a234","","",false, this);
 
            IDIntAccProjectCost = RPSControlFactory.CreateRPSComboBox<ParameterGLMEntityView>("3e9342b0-66db-4f1e-9472-d07f781d34d7","","",false, this);
 
            IDIntAccProjectService = RPSControlFactory.CreateRPSComboBox<ParameterGLMEntityView>("10a3558f-4a0b-4de9-857b-7241c0786256","","",false, this);
 
            IDIntAccProjectMatWithoutMov = RPSControlFactory.CreateRPSComboBox<ParameterGLMEntityView>("81c6d52f-46f8-417a-9a94-8a43cb4e6dce","","",false, this);
 
            IDIntAccProjectClosed = RPSControlFactory.CreateRPSComboBox<ParameterGLMEntityView>("34c5fc5d-55a4-4b7d-925c-db30b86499ce","","",false, this);
 
            IDIntAccManufacEmployee = RPSControlFactory.CreateRPSComboBox<ParameterGLMEntityView>("013c727f-18c4-467a-a4cb-30ae6ca3a0b3","","",false, this);
 
            IDIntAccManufacMachine = RPSControlFactory.CreateRPSComboBox<ParameterGLMEntityView>("d22ef04f-871d-4233-99ee-239a1d940f63","","",false, this);
 
            IDIntAccManufacTool = RPSControlFactory.CreateRPSComboBox<ParameterGLMEntityView>("b61db13f-b028-4346-8126-9ed9be186201","","",false, this);
 
            IDIntAccManufacCost = RPSControlFactory.CreateRPSComboBox<ParameterGLMEntityView>("b361cb35-d0df-43c4-8dfe-f855eacf4227","","",false, this);
 
            IDIntAccManufacService = RPSControlFactory.CreateRPSComboBox<ParameterGLMEntityView>("3a767ed7-95e4-4164-be37-606de3bc1b4e","","",false, this);
 
            IDIntAccManufacMatWithoutMov = RPSControlFactory.CreateRPSComboBox<ParameterGLMEntityView>("b6eda033-7952-45c7-b844-65a2d42ae8af","","",false, this);
 
            MainEconActCode1 = RPSControlFactory.CreateRPSTextBox<ParameterGLMEntityView>("e940be64-a33a-4da1-96b7-200eabb67297","","",false, this);
 
            Class1 = RPSControlFactory.CreateRPSTextBox<ParameterGLMEntityView>("1d4e9e73-e96a-46e0-a98d-e30f689402ff","","",false, this);
 
            MainEconActCode2 = RPSControlFactory.CreateRPSTextBox<ParameterGLMEntityView>("70c0b133-254c-4e0c-92b1-dc41525f9ee2","","",false, this);
 
            Class2 = RPSControlFactory.CreateRPSTextBox<ParameterGLMEntityView>("cc50afcf-a01c-4af9-859c-7cce785f4ae0","","",false, this);
 
            TaxOffice = RPSControlFactory.CreateRPSTextBox<ParameterGLMEntityView>("2aa956a2-20d4-40e9-aa7d-8422af98c48b","","",false, this);
 
            TaxAdministration = RPSControlFactory.CreateRPSTextBox<ParameterGLMEntityView>("ed11b7e7-f845-4fad-a20c-59884fa6db74","","",false, this);
 
            CollectionInit params_SearchTypes = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="79c56168-211f-43fe-8caa-beab52232d15",CSSSelectorGrid="",XPathGrid=""};
            SearchTypes = RPSControlFactory.RPSCreateCollectionWithGrid<SearchTypesCollectionEditor<ParameterGLMEntityView,SearchTypeView>,ParameterGLMEntityView,SearchTypeView>( params_SearchTypes,this,Screen.SearchTypeView);
 
            CollectionInit params_UserRestricteds = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6c7d540f-f60a-4427-9a6c-305056a48618",CSSSelectorGrid="",XPathGrid=""};
            UserRestricteds = RPSControlFactory.RPSCreateCollectionWithGrid<UserRestrictedsCollectionEditor<ParameterGLMEntityView,SearchTypeView>,ParameterGLMEntityView,SearchTypeView>( params_UserRestricteds,this,Screen.SearchTypeView);
 
            CollectionInit params_EUInvoices = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6647f2d6-048a-47cc-adac-cdfd9014bdfc",CSSSelectorGrid="",XPathGrid=""};
            EUInvoices = RPSControlFactory.RPSCreateCollectionWithGrid<EUInvoicesCollectionEditor<ParameterGLMEntityView,SearchTypeView>,ParameterGLMEntityView,SearchTypeView>( params_EUInvoices,this,Screen.SearchTypeView);
 
            CollectionInit params_ParamFinancialDocs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6b01b7ec-88f5-41e7-ab15-0c96aa1625e3",CSSSelectorGrid="",XPathGrid=""};
            ParamFinancialDocs = RPSControlFactory.RPSCreateCollectionWithGrid<ParamFinancialDocsCollectionEditor<ParameterGLMEntityView,SearchTypeView>,ParameterGLMEntityView,SearchTypeView>( params_ParamFinancialDocs,this,Screen.SearchTypeView);
 
            Financiero = RPSControlFactory.CreateRPSSection<ParameterGLMEntityView>( "","ul li[rpsid='b4050696-0ca7-461e-a718-5c80971e2d63']","",this);
 
            Integration = RPSControlFactory.CreateRPSSection<ParameterGLMEntityView>( "","ul li[rpsid='1578bfcb-4cc0-4566-a67d-a0417ccb8734']","",this);
 
            Taxes = RPSControlFactory.CreateRPSSection<ParameterGLMEntityView>( "","ul li[rpsid='b8ad3a03-6750-47b9-bae1-eb65d675fbb5']","",this);
 
            Busqueda = RPSControlFactory.CreateRPSSection<ParameterGLMEntityView>( "","ul li[rpsid='3b1b9b37-7a5e-4209-9081-d0c011c2c7ff']","",this);
 
            Usuarios = RPSControlFactory.CreateRPSSection<ParameterGLMEntityView>( "","ul li[rpsid='9ff93539-945e-47bc-b1eb-ffecbb826398']","",this);
 
            AutoFactura = RPSControlFactory.CreateRPSSection<ParameterGLMEntityView>( "","ul li[rpsid='47c7ee1d-3ce0-455d-a62e-32bed7e31f78']","",this);
 
            DocFinanciero = RPSControlFactory.CreateRPSSection<ParameterGLMEntityView>( "","ul li[rpsid='152ffa76-1246-4010-98a1-c16eab71f9da']","",this);
 

        }
        public IRPSTextBox<ParameterGLMEntityView> AccLength { get; set; } 
        public IRPSCheckbox<ParameterGLMEntityView> AllowModifyVoucher { get; set; } 
        public IRPSCheckbox<ParameterGLMEntityView> AllowDeleteVoucher { get; set; } 
        public IRPSCheckbox<ParameterGLMEntityView> NegativeAmount { get; set; } 
        public IRPSCheckbox<ParameterGLMEntityView> CheckInvoiceDate { get; set; } 
        public IRPSCheckbox<ParameterGLMEntityView> CheckDeliveryDate { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> IDFADepTypeFiscal { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> IDDimensionBusiness { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> IDDimensionThird { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> IDDimensionProject { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> IDThirdAccTypeAP { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> IDThirdAccTypeAR { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> IDArticleAccType { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> IDVoucherTypeSupplier { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> IDVoucherTypeCustomer { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> IDVoucherTypeFA { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> IDVoucherTypeSignLeasing { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> IDVoucherTypeTRAExp { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> IDVoucherTypeTRAPay { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> IDAccConceptPurchase { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> IDAccConceptSales { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> IDAccConceptFA { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> IDAccConceptLeasing { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> IDAccConceptARP { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> IDAccConceptTRAExp { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> IDAccConceptTRAPay { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> IDVoucherSeriesBookPurchase { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> IDVoucherSeriesBookSales { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> IDVoucherSeriesBookFA { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> IDVoucherSeriesBookLeasing { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> IDVoucherSeriesBookRP { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> IDVoucherSeriesBookWarehouse { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> IDVoucherSeriesBookTRAExp { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> IDVoucherSeriesBookTRAPay { get; set; } 
        public IRPSCheckbox<ParameterGLMEntityView> DirectPurchase { get; set; } 
        public IRPSCheckbox<ParameterGLMEntityView> DirectSales { get; set; } 
        public IRPSCheckbox<ParameterGLMEntityView> DirectFA { get; set; } 
        public IRPSCheckbox<ParameterGLMEntityView> DirectLeasing { get; set; } 
        public IRPSCheckbox<ParameterGLMEntityView> DirectRP { get; set; } 
        public IRPSCheckbox<ParameterGLMEntityView> DirectWarehouse { get; set; } 
        public IRPSCheckbox<ParameterGLMEntityView> DirectTRA { get; set; } 
        public IRPSCheckbox<ParameterGLMEntityView> PurTransferGLInvZero { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> PostDiscountPurchase { get; set; } 
        public IRPSCheckbox<ParameterGLMEntityView> PostDiscountLinePurchase { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> AccRetentionPurchase { get; set; } 
        public IRPSCheckbox<ParameterGLMEntityView> FacTransferGLInvZero { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> PostDiscountSales { get; set; } 
        public IRPSCheckbox<ParameterGLMEntityView> PostDiscountLineSales { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> AccRetentionSales { get; set; } 
        public IRPSCheckbox<ParameterGLMEntityView> GroupAtClosing { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> IDIntAccProjectEmployee { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> IDIntAccProjectMachine { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> IDIntAccProjectTool { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> IDIntAccProjectCost { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> IDIntAccProjectService { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> IDIntAccProjectMatWithoutMov { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> IDIntAccProjectClosed { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> IDIntAccManufacEmployee { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> IDIntAccManufacMachine { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> IDIntAccManufacTool { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> IDIntAccManufacCost { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> IDIntAccManufacService { get; set; } 
        public IRPSComboBox<ParameterGLMEntityView> IDIntAccManufacMatWithoutMov { get; set; } 
        public IRPSTextBox<ParameterGLMEntityView> MainEconActCode1 { get; set; } 
        public IRPSTextBox<ParameterGLMEntityView> Class1 { get; set; } 
        public IRPSTextBox<ParameterGLMEntityView> MainEconActCode2 { get; set; } 
        public IRPSTextBox<ParameterGLMEntityView> Class2 { get; set; } 
        public IRPSTextBox<ParameterGLMEntityView> TaxOffice { get; set; } 
        public IRPSTextBox<ParameterGLMEntityView> TaxAdministration { get; set; } 
        public SearchTypesCollectionEditor<ParameterGLMEntityView,SearchTypeView> SearchTypes { get; set; } 
        public UserRestrictedsCollectionEditor<ParameterGLMEntityView,SearchTypeView> UserRestricteds { get; set; } 
        public EUInvoicesCollectionEditor<ParameterGLMEntityView,SearchTypeView> EUInvoices { get; set; } 
        public ParamFinancialDocsCollectionEditor<ParameterGLMEntityView,SearchTypeView> ParamFinancialDocs { get; set; } 
        public IRPSSection<ParameterGLMEntityView> Financiero { get; set; } 
        public IRPSSection<ParameterGLMEntityView> Integration { get; set; } 
        public IRPSSection<ParameterGLMEntityView> Taxes { get; set; } 
        public IRPSSection<ParameterGLMEntityView> Busqueda { get; set; } 
        public IRPSSection<ParameterGLMEntityView> Usuarios { get; set; } 
        public IRPSSection<ParameterGLMEntityView> AutoFactura { get; set; } 
        public IRPSSection<ParameterGLMEntityView> DocFinanciero { get; set; } 
        public ParameterGLM Screen { get; set; }
        public ParameterGLMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SearchTypesCollectionEditor<ParameterGLMEntityView,SearchTypeView>:RPSCollectionEditor<ParameterGLMEntityView,SearchTypeView> where ParameterGLMEntityView : class, IView where SearchTypeView : class, IView
    {
        public  SearchTypesGridView<ParameterGLMEntityView,SearchTypeView> GridView {get;set;}
    }
    public partial class SearchTypesGridView <ParameterGLMEntityView,SearchTypeView> :  RPSGridView<ParameterGLMEntityView,SearchTypeView> where ParameterGLMEntityView : class, IView where SearchTypeView : class, IView
    {
        public SearchTypesGridView(ParameterGLMEntityView currentView,SearchTypeView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodSearchType = RPSControlFactory.CreateRPSGridFormattedTextBox<ParameterGLMEntityView>("","#79c56168-211f-43fe-8caa-beab52232d15 .ag-row[role='row']@ROWINDEX [col-id='cCodSearchType']","",true, this.CurrentView);
 
            VoucherType = RPSControlFactory.CreateRPSGridCheckBox<ParameterGLMEntityView>("","#79c56168-211f-43fe-8caa-beab52232d15 .ag-row[role='row']@ROWINDEX [col-id='cVoucherType']","",true, this.CurrentView);
 
            ThirdAccType = RPSControlFactory.CreateRPSGridCheckBox<ParameterGLMEntityView>("","#79c56168-211f-43fe-8caa-beab52232d15 .ag-row[role='row']@ROWINDEX [col-id='cThirdAccType']","",true, this.CurrentView);
 
            ArticleAccType = RPSControlFactory.CreateRPSGridCheckBox<ParameterGLMEntityView>("","#79c56168-211f-43fe-8caa-beab52232d15 .ag-row[role='row']@ROWINDEX [col-id='cArticleAccType']","",true, this.CurrentView);
 
            Site = RPSControlFactory.CreateRPSGridCheckBox<ParameterGLMEntityView>("","#79c56168-211f-43fe-8caa-beab52232d15 .ag-row[role='row']@ROWINDEX [col-id='cSite']","",true, this.CurrentView);
 
            Warehouse = RPSControlFactory.CreateRPSGridCheckBox<ParameterGLMEntityView>("","#79c56168-211f-43fe-8caa-beab52232d15 .ag-row[role='row']@ROWINDEX [col-id='cWarehouse']","",true, this.CurrentView);
 
            IntegrationAccounting = RPSControlFactory.CreateRPSGridCheckBox<ParameterGLMEntityView>("","#79c56168-211f-43fe-8caa-beab52232d15 .ag-row[role='row']@ROWINDEX [col-id='cIntegrationAccounting']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<ParameterGLMEntityView> CodSearchType { get; set; } 
        public IRPSGridCheckbox<ParameterGLMEntityView> VoucherType { get; set; } 
        public IRPSGridCheckbox<ParameterGLMEntityView> ThirdAccType { get; set; } 
        public IRPSGridCheckbox<ParameterGLMEntityView> ArticleAccType { get; set; } 
        public IRPSGridCheckbox<ParameterGLMEntityView> Site { get; set; } 
        public IRPSGridCheckbox<ParameterGLMEntityView> Warehouse { get; set; } 
        public IRPSGridCheckbox<ParameterGLMEntityView> IntegrationAccounting { get; set; } 
                     
    }
 
        public partial class UserRestrictedsCollectionEditor<ParameterGLMEntityView,SearchTypeView>:RPSCollectionEditor<ParameterGLMEntityView,SearchTypeView> where ParameterGLMEntityView : class, IView where SearchTypeView : class, IView
    {
        public  UserRestrictedsGridView<ParameterGLMEntityView,SearchTypeView> GridView {get;set;}
    }
    public partial class UserRestrictedsGridView <ParameterGLMEntityView,SearchTypeView> :  RPSGridView<ParameterGLMEntityView,SearchTypeView> where ParameterGLMEntityView : class, IView where SearchTypeView : class, IView
    {
        public UserRestrictedsGridView(ParameterGLMEntityView currentView,SearchTypeView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodUser = RPSControlFactory.CreateRPSGridComboBox<ParameterGLMEntityView>("","#6c7d540f-f60a-4427-9a6c-305056a48618 .ag-row[role='row']@ROWINDEX [col-id='cCodUser']","",true, this.CurrentView);
 
            Insert = RPSControlFactory.CreateRPSGridCheckBox<ParameterGLMEntityView>("","#6c7d540f-f60a-4427-9a6c-305056a48618 .ag-row[role='row']@ROWINDEX [col-id='cInsert']","",true, this.CurrentView);
 
            Update = RPSControlFactory.CreateRPSGridCheckBox<ParameterGLMEntityView>("","#6c7d540f-f60a-4427-9a6c-305056a48618 .ag-row[role='row']@ROWINDEX [col-id='cUpdate']","",true, this.CurrentView);
 
            Delete = RPSControlFactory.CreateRPSGridCheckBox<ParameterGLMEntityView>("","#6c7d540f-f60a-4427-9a6c-305056a48618 .ag-row[role='row']@ROWINDEX [col-id='cDelete']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<ParameterGLMEntityView> CodUser { get; set; } 
        public IRPSGridCheckbox<ParameterGLMEntityView> Insert { get; set; } 
        public IRPSGridCheckbox<ParameterGLMEntityView> Update { get; set; } 
        public IRPSGridCheckbox<ParameterGLMEntityView> Delete { get; set; } 
                     
    }
 
        public partial class EUInvoicesCollectionEditor<ParameterGLMEntityView,SearchTypeView>:RPSCollectionEditor<ParameterGLMEntityView,SearchTypeView> where ParameterGLMEntityView : class, IView where SearchTypeView : class, IView
    {
        public  EUInvoicesGridView<ParameterGLMEntityView,SearchTypeView> GridView {get;set;}
    }
    public partial class EUInvoicesGridView <ParameterGLMEntityView,SearchTypeView> :  RPSGridView<ParameterGLMEntityView,SearchTypeView> where ParameterGLMEntityView : class, IView where SearchTypeView : class, IView
    {
        public EUInvoicesGridView(ParameterGLMEntityView currentView,SearchTypeView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodEUInvoice = RPSControlFactory.CreateRPSGridTextBox<ParameterGLMEntityView>("","#6647f2d6-048a-47cc-adac-cdfd9014bdfc .ag-row[role='row']@ROWINDEX [col-id='cCodEUInvoice']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ParameterGLMEntityView>("","#6647f2d6-048a-47cc-adac-cdfd9014bdfc .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            GoodsService = RPSControlFactory.CreateRPSGridEnumComboBox<ParameterGLMEntityView>("","#6647f2d6-048a-47cc-adac-cdfd9014bdfc .ag-row[role='row']@ROWINDEX [col-id='cGoodsService']","",true, this.CurrentView);
 
            Default = RPSControlFactory.CreateRPSGridCheckBox<ParameterGLMEntityView>("","#6647f2d6-048a-47cc-adac-cdfd9014bdfc .ag-row[role='row']@ROWINDEX [col-id='cDefault']","",true, this.CurrentView);
 
            IDCodingSeriesAutoInvoice = RPSControlFactory.CreateRPSGridComboBox<ParameterGLMEntityView>("","#6647f2d6-048a-47cc-adac-cdfd9014bdfc .ag-row[role='row']@ROWINDEX [col-id='cIDCodingSeriesAutoInvoice']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<ParameterGLMEntityView> CodEUInvoice { get; set; } 
        public IRPSGridTextBox<ParameterGLMEntityView> Description { get; set; } 
        public IRPSGridComboBox<ParameterGLMEntityView> GoodsService { get; set; } 
        public IRPSGridCheckbox<ParameterGLMEntityView> Default { get; set; } 
        public IRPSGridComboBox<ParameterGLMEntityView> IDCodingSeriesAutoInvoice { get; set; } 
                     
    }
 
        public partial class ParamFinancialDocsCollectionEditor<ParameterGLMEntityView,SearchTypeView>:RPSCollectionEditor<ParameterGLMEntityView,SearchTypeView> where ParameterGLMEntityView : class, IView where SearchTypeView : class, IView
    {
        public  ParamFinancialDocsGridView<ParameterGLMEntityView,SearchTypeView> GridView {get;set;}
    }
    public partial class ParamFinancialDocsGridView <ParameterGLMEntityView,SearchTypeView> :  RPSGridView<ParameterGLMEntityView,SearchTypeView> where ParameterGLMEntityView : class, IView where SearchTypeView : class, IView
    {
        public ParamFinancialDocsGridView(ParameterGLMEntityView currentView,SearchTypeView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodFinancialDoc = RPSControlFactory.CreateRPSGridTextBox<ParameterGLMEntityView>("","#6b01b7ec-88f5-41e7-ab15-0c96aa1625e3 .ag-row[role='row']@ROWINDEX [col-id='cCodFinancialDoc']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ParameterGLMEntityView>("","#6b01b7ec-88f5-41e7-ab15-0c96aa1625e3 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Document = RPSControlFactory.CreateRPSGridTextBox<ParameterGLMEntityView>("","#6b01b7ec-88f5-41e7-ab15-0c96aa1625e3 .ag-row[role='row']@ROWINDEX [col-id='cDocument']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<ParameterGLMEntityView> CodFinancialDoc { get; set; } 
        public IRPSGridTextBox<ParameterGLMEntityView> Description { get; set; } 
        public IRPSGridTextBox<ParameterGLMEntityView> Document { get; set; } 
                     
    }
 
    }
  
            
    public partial class ParamFinancialDocView : View
    {
        public ParamFinancialDocView(ParameterGLM screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ParamFinancialDocView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ParamFinancialDocView,ParameterGLMEntityView>( this,Screen.ParameterGLMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ParamFinancialDocView,ParameterGLMEntityView>( this,Screen.ParameterGLMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ParamFinancialDocView,ParameterGLMEntityView>( this,Screen.ParameterGLMEntityView);
 
            CodFinancialDoc = RPSControlFactory.CreateRPSTextBox<ParamFinancialDocView>("b6e65269-5a22-4227-a4b7-74fc1c112c54","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ParamFinancialDocView>("0323bf70-cfbf-4ecc-a14a-062e1ace047a","","",false, this);
 
            Document = RPSControlFactory.CreateRPSTextBox<ParamFinancialDocView>("d6695615-9621-48bf-a425-df7c6b393265","","",true, this);
 

        }
        public IRPSButton<ParamFinancialDocView> DeleteButton { get; set; } 
        public IRPSButton<ParamFinancialDocView,ParameterGLMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ParamFinancialDocView,ParameterGLMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ParamFinancialDocView,ParameterGLMEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<ParamFinancialDocView> CodFinancialDoc { get; set; } 
        public IRPSTextBox<ParamFinancialDocView> Description { get; set; } 
        public IRPSTextBox<ParamFinancialDocView> Document { get; set; } 
        public ParameterGLM Screen { get; set; }
        public ParamFinancialDocView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SearchTypeView : View
    {
        public SearchTypeView(ParameterGLM screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SearchTypeView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SearchTypeView,ParameterGLMEntityView>( this,Screen.ParameterGLMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<SearchTypeView,ParameterGLMEntityView>( this,Screen.ParameterGLMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SearchTypeView,ParameterGLMEntityView>( this,Screen.ParameterGLMEntityView);
 
            CodSearchType = RPSControlFactory.CreateRPSFormattedTextBox<SearchTypeView>("5ab88918-6b0d-4cca-b571-b4cf86ace425","","",true, this);
 
            VoucherType = RPSControlFactory.CreateRPSCheckBox<SearchTypeView>("b3831cc8-beb5-423a-9a47-73b5a1e21336","","",true, this);
 
            ThirdAccType = RPSControlFactory.CreateRPSCheckBox<SearchTypeView>("9d116359-ffc5-4d3d-9869-12251cabc6a2","","",true, this);
 
            ArticleAccType = RPSControlFactory.CreateRPSCheckBox<SearchTypeView>("0255098f-5728-4f26-9d9d-f3cabe1e7492","","",true, this);
 
            Site = RPSControlFactory.CreateRPSCheckBox<SearchTypeView>("ceb42a7e-8904-4ee0-9992-2726489aae0f","","",true, this);
 
            Warehouse = RPSControlFactory.CreateRPSCheckBox<SearchTypeView>("da3e6ebe-851a-4b2e-a339-a3193bf7ed85","","",true, this);
 
            IntegrationAccounting = RPSControlFactory.CreateRPSCheckBox<SearchTypeView>("84f3a59a-9c23-41de-8aee-edb46db26a6e","","",true, this);
 

        }
        public IRPSButton<SearchTypeView> DeleteButton { get; set; } 
        public IRPSButton<SearchTypeView,ParameterGLMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SearchTypeView,ParameterGLMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<SearchTypeView,ParameterGLMEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<SearchTypeView> CodSearchType { get; set; } 
        public IRPSCheckbox<SearchTypeView> VoucherType { get; set; } 
        public IRPSCheckbox<SearchTypeView> ThirdAccType { get; set; } 
        public IRPSCheckbox<SearchTypeView> ArticleAccType { get; set; } 
        public IRPSCheckbox<SearchTypeView> Site { get; set; } 
        public IRPSCheckbox<SearchTypeView> Warehouse { get; set; } 
        public IRPSCheckbox<SearchTypeView> IntegrationAccounting { get; set; } 
        public ParameterGLM Screen { get; set; }
        public SearchTypeView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class UserRestrictedView : View
    {
        public UserRestrictedView(ParameterGLM screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<UserRestrictedView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<UserRestrictedView,ParameterGLMEntityView>( this,Screen.ParameterGLMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<UserRestrictedView,ParameterGLMEntityView>( this,Screen.ParameterGLMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<UserRestrictedView,ParameterGLMEntityView>( this,Screen.ParameterGLMEntityView);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<UserRestrictedView>("004b20d5-f1c4-4358-a66c-1a19ccdf5263","","",true, this);
 
            Insert = RPSControlFactory.CreateRPSCheckBox<UserRestrictedView>("c24d3c17-b830-4114-903c-813269a0f0af","","",true, this);
 
            Update = RPSControlFactory.CreateRPSCheckBox<UserRestrictedView>("801e7aa3-dd3c-4e50-be51-b8c255da7747","","",true, this);
 
            Delete = RPSControlFactory.CreateRPSCheckBox<UserRestrictedView>("ed33e457-1f69-49cf-bc16-0b7085bc20f4","","",true, this);
 

        }
        public IRPSButton<UserRestrictedView> DeleteButton { get; set; } 
        public IRPSButton<UserRestrictedView,ParameterGLMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<UserRestrictedView,ParameterGLMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<UserRestrictedView,ParameterGLMEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<UserRestrictedView> CodUser { get; set; } 
        public IRPSCheckbox<UserRestrictedView> Insert { get; set; } 
        public IRPSCheckbox<UserRestrictedView> Update { get; set; } 
        public IRPSCheckbox<UserRestrictedView> Delete { get; set; } 
        public ParameterGLM Screen { get; set; }
        public UserRestrictedView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class EUInvoiceView : View
    {
        public EUInvoiceView(ParameterGLM screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<EUInvoiceView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<EUInvoiceView,ParameterGLMEntityView>( this,Screen.ParameterGLMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<EUInvoiceView,ParameterGLMEntityView>( this,Screen.ParameterGLMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<EUInvoiceView,ParameterGLMEntityView>( this,Screen.ParameterGLMEntityView);
 
            CodEUInvoice = RPSControlFactory.CreateRPSTextBox<EUInvoiceView>("88d2a9c4-c080-46ff-bf2e-adff9173e429","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<EUInvoiceView>("43a9bb83-36b7-4d5d-b65d-4bb1afb57a6f","","",false, this);
 
            GoodsService = RPSControlFactory.CreateRPSEnumComboBox<EUInvoiceView>("2268c061-aee0-4f7c-b365-680f4cdf42a6","","",true, this);
 
            Default = RPSControlFactory.CreateRPSCheckBox<EUInvoiceView>("d2719aa8-fcf2-4c9d-aa38-21f1e40ceb40","","",true, this);
 
            IDCodingSeriesAutoInvoice = RPSControlFactory.CreateRPSComboBox<EUInvoiceView>("9add5abc-3e4d-4ab8-b099-602ceed40a50","","",true, this);
 
            IDSupplierAutoInvoice = RPSControlFactory.CreateRPSComboBox<EUInvoiceView>("5fa915be-c9cb-46ad-b66c-461bc4cde4cb","","",false, this);
 
            IDVoucherTypeEUPurchase = RPSControlFactory.CreateRPSComboBox<EUInvoiceView>("68098668-489b-4591-a472-2a1eed887834","","",false, this);
 
            IDCustomerAutoInvoice = RPSControlFactory.CreateRPSComboBox<EUInvoiceView>("9ba91aee-e6f2-49e9-ac4b-eb654b1e02af","","",false, this);
 
            IDVoucherTypeEUSales = RPSControlFactory.CreateRPSComboBox<EUInvoiceView>("ac88c4b3-03b2-46d5-bd6e-ec3514cabe26","","",false, this);
 
            IDVATTypeT = RPSControlFactory.CreateRPSComboBox<EUInvoiceView>("f8809a68-8554-4af0-9c63-b99589e45a34","","",false, this);
 

        }
        public IRPSButton<EUInvoiceView> DeleteButton { get; set; } 
        public IRPSButton<EUInvoiceView,ParameterGLMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<EUInvoiceView,ParameterGLMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<EUInvoiceView,ParameterGLMEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<EUInvoiceView> CodEUInvoice { get; set; } 
        public IRPSTextBox<EUInvoiceView> Description { get; set; } 
        public IRPSComboBox<EUInvoiceView> GoodsService { get; set; } 
        public IRPSCheckbox<EUInvoiceView> Default { get; set; } 
        public IRPSComboBox<EUInvoiceView> IDCodingSeriesAutoInvoice { get; set; } 
        public IRPSComboBox<EUInvoiceView> IDSupplierAutoInvoice { get; set; } 
        public IRPSComboBox<EUInvoiceView> IDVoucherTypeEUPurchase { get; set; } 
        public IRPSComboBox<EUInvoiceView> IDCustomerAutoInvoice { get; set; } 
        public IRPSComboBox<EUInvoiceView> IDVoucherTypeEUSales { get; set; } 
        public IRPSComboBox<EUInvoiceView> IDVATTypeT { get; set; } 
        public ParameterGLM Screen { get; set; }
        public EUInvoiceView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}