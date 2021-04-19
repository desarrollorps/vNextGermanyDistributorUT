    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.CustomerClassificationSL
{
    //RPS VERSION 1.0.0.0
    public partial class CustomerClassificationSL:Screen
    {
        public CustomerClassificationSL():base()
        {
            this.URL = "sales.customerclassificationsl";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CustomerClassificationSLCollectionView  = new CustomerClassificationSLCollectionView(this); 
            CustomerClassificationSLEntityView  = new CustomerClassificationSLEntityView(this); 
            CustomerClassificationDetailSLView  = new CustomerClassificationDetailSLView(this); 
            CustomerClassificationSLCollectionView.InitializeControls(); 
            CustomerClassificationSLEntityView.InitializeControls(); 
            CustomerClassificationDetailSLView.InitializeControls(); 
           
        }
      
            public CustomerClassificationSLCollectionView CustomerClassificationSLCollectionView {get; set; } 
            public CustomerClassificationSLEntityView CustomerClassificationSLEntityView {get; set; } 
            public CustomerClassificationDetailSLView CustomerClassificationDetailSLView {get; set; } 
    }
            
    public partial class CustomerClassificationSLCollectionView : View
    {
        public CustomerClassificationSLCollectionView(CustomerClassificationSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CustomerClassificationSLCollectionView,CustomerClassificationSLEntityView>( this,Screen.CustomerClassificationSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "76c7465a-d1ab-49aa-b29c-a4e184e2381a",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CustomerClassificationSLCollectionView,CustomerClassificationSLEntityView>( params_MainConsult,this,Screen.CustomerClassificationSLEntityView);
 

        }
        public IRPSButton<CustomerClassificationSLCollectionView,CustomerClassificationSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CustomerClassificationSLCollectionView,CustomerClassificationSLEntityView> MainConsult { get; set; } 
        public CustomerClassificationSL Screen { get; set; }
        public CustomerClassificationSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CustomerClassificationSLEntityView : View
    {
        public CustomerClassificationSLEntityView(CustomerClassificationSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CustomerClassificationSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CustomerClassificationSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CustomerClassificationSLEntityView,CustomerClassificationSLCollectionView>( this,Screen.CustomerClassificationSLCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CustomerClassificationSLEntityView,CustomerClassificationSLCollectionView>( this,Screen.CustomerClassificationSLCollectionView);
 
            CodCustomerClassification = RPSControlFactory.CreateRPSTextBox<CustomerClassificationSLEntityView>("0ecd12e6-63ba-441b-8fca-acda4f97b451","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CustomerClassificationSLEntityView>("fe46badd-205e-414e-a340-2f09485cf4d9","","",false, this);
 
            CodLanguage = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("c895262c-3ac0-43a4-bbb9-eaf9b03aee9f","","",false, this);
 
            CodCountry = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("4055a011-ae5a-4661-89d3-82c954ad3eb9","","",false, this);
 
            IDBusinessUnitDetail = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("6b7ad613-9be7-4b8e-b566-038285f34e8a","","",false, this);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("9f5d60e0-ae43-47f5-9527-9e3ae15e42c4","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("bb4eba61-8f98-4a6a-b98f-55bbeebb43c9","","",false, this);
 
            IDVATType = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("d5080ebd-8cad-40f7-8930-b72e449465a0","","",false, this);
 
            IDTaxGroup = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("fd19ecfa-3054-400d-99ee-b73b386b991d","","",false, this);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("2ab68caf-171f-4ad4-ac1a-a0389079923b","","",false, this);
 
            IDDeliveryNoteTypeGroup = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("db3ff3eb-34a2-4c04-951b-6f79b2d68db6","","",false, this);
 
            IDInvoiceTypeGroup = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("367cc74b-d04b-44ae-9802-a269a2ef316f","","",false, this);
 
            CodTransportMethod = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("25eb5c1a-065b-4bdd-b9c0-4ad649f55ae6","","",false, this);
 
            CodDeliveryTerm = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("254dab95-459e-41fd-9199-7208c73321bc","","",false, this);
 
            IDCustomerCommissionGroup = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("9d82127a-140e-486f-8ba1-17423fbdbb5e","","",false, this);
 
            IDThirdAccType = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("d04bb011-4473-463e-b3a2-dabcda3c74f0","","",false, this);
 
            IDVoucherType = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("423910ed-047b-4fb4-a9df-00d7361b2815","","",false, this);
 
            IDPriceList = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("7c21b8f2-fe5b-484e-9575-9800d25b291c","","",false, this);
 
            IDDiscountGroup = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("e6d296b9-05dc-403e-b763-26e29feb94c4","","",false, this);
 
            IDCommercialConditionGroup = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("804112aa-ec5f-4133-a4bc-1e219b1456ad","","",false, this);
 
            ConditionsAffectDocument = RPSControlFactory.CreateRPSCheckBox<CustomerClassificationSLEntityView>("1a45c67b-98d1-4b62-95b7-815b09cfff0f","","",true, this);
 
            ConditionsNotAffectDocument = RPSControlFactory.CreateRPSCheckBox<CustomerClassificationSLEntityView>("8aa03c71-eeef-48ae-84db-0b7f5f2d53f1","","",true, this);
 
            IDCodingSerieSalesQuote = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("6b83067e-14d0-48cb-926e-2959073bc47e","","",false, this);
 
            IDCodingSerieOrder = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("635966f0-ab59-45ec-aa76-e36c6e5ec3a2","","",false, this);
 
            IDCodingSerieDeliveryNote = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("afcceb4a-81c9-431b-a5a8-4783850b5392","","",false, this);
 
            IDCodingSerieDeliveryNoteB = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("9003b35c-ff8e-4c73-a415-017b2fe02bfd","","",false, this);
 
            IDCodingSerieInvoice = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("9ba3776c-f940-4d51-8ca8-17d81121e664","","",false, this);
 
            IDCodingSerieInvoiceB = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("dbe429ee-19f6-4cb1-81cb-017183190500","","",false, this);
 
            IDCodingSerieCreditInvoice = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("33341d01-7347-4158-a732-dfd1a82f6d36","","",false, this);
 
            IDCodingSerieCreditInvoiceB = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("6b46a00d-55ef-4eff-8e41-c9aa7ee266bc","","",false, this);
 
            IDCodingSerieAdvanceInvoice = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("302f4004-a3bc-41ce-b458-afacde8368f9","","",false, this);
 
            IDCodingSerieAdvanceInvoiceB = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("58ef44fe-4575-4a98-9b87-646a07b609ae","","",false, this);
 
            IDCodingSerieDebitNote = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("c70fa2d0-8fbe-47bf-bc9a-185fbb3b97a8","","",false, this);
 
            IDCodingSerieDebitNoteB = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("7736b46a-01f9-40df-af20-41216887bd8a","","",false, this);
 
            IDCodingSerieCustomer = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("7cbfd03b-605d-4089-8358-2729ab3c8c7f","","",false, this);
 
            IDCodingSeriePotentialCustomer = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("ba30d0e9-3473-418f-b7fd-e94f884b0082","","",false, this);
 
            IDCodingSerieFrameworkContract = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("99313fdd-aedb-4ed5-ab37-563a7292303b","","",false, this);
 
            IDTextLineOfferPre = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("8d0991ca-5fbb-43e6-b61d-66942cf7b8cb","","",false, this);
 
            IDTextLineFContractPre = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("6962a77f-a5ad-450d-85e4-214c3367b623","","",false, this);
 
            IDTextLineOrderPre = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("9d2cba01-627f-43a9-9588-b2ecb32de132","","",false, this);
 
            IDTextLineDNotePre = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("63a14b47-f8b3-4722-992e-dc2e5f07c9e9","","",false, this);
 
            IDTextLineInvoicePre = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("3895dc3f-c6ce-4a93-81fa-84a4d7c598e2","","",false, this);
 
            IDTextLineCreditPre = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("b9b61106-6a78-43ef-823c-8bd150d6a739","","",false, this);
 
            IDTextLineAdvancePre = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("bac01b38-d259-4e27-8104-981a6fe8e803","","",false, this);
 
            IDTextLineOfferPost = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("9b282795-d8e4-49aa-b5cb-ab51c7b261fb","","",false, this);
 
            IDTextLineFContractPost = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("fabd3572-1ede-4b61-bf3a-fca5b4fd4b5e","","",false, this);
 
            IDTextLineOrderPost = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("f9c249d0-7a01-417d-b4f2-cef6b2c9e4f7","","",false, this);
 
            IDTextLineDNotePost = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("72a85696-60dd-496c-b72f-ce7a100afb1f","","",false, this);
 
            IDTextLineInvoicePost = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("6992f83c-287e-4e45-94ef-7353040b5c35","","",false, this);
 
            IDTextLineCreditPost = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("e2ed55c7-76b5-4703-89b0-20db63dab5af","","",false, this);
 
            IDTextLineAdvancePost = RPSControlFactory.CreateRPSComboBox<CustomerClassificationSLEntityView>("b1c5242d-b150-453f-8595-b0a45d2208c1","","",false, this);
 
            CollectionInit params_CustomerClassificationDetailSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4dc8e762-fb42-4eae-b7cb-a77d24289da1",CSSSelectorGrid="",XPathGrid=""};
            CustomerClassificationDetailSLs = RPSControlFactory.RPSCreateCollectionWithGrid<CustomerClassificationDetailSLsCollectionEditor<CustomerClassificationSLEntityView,CustomerClassificationDetailSLView>,CustomerClassificationSLEntityView,CustomerClassificationDetailSLView>( params_CustomerClassificationDetailSLs,this,Screen.CustomerClassificationDetailSLView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<CustomerClassificationSLEntityView>( "","ul li[rpsid='73fe3ae1-9ae9-404e-8cc4-03624e16ca37']","",this);
 
            SubsidiaryCompanies = RPSControlFactory.CreateRPSSection<CustomerClassificationSLEntityView>( "","ul li[rpsid='7630d911-3572-4da7-95ef-b4f584b66451']","",this);
 
            Texts = RPSControlFactory.CreateRPSSection<CustomerClassificationSLEntityView>( "","ul li[rpsid='89757a46-de5e-47b5-9f38-1268d0d030f7']","",this);
 

        }
        public IRPSSaveButton<CustomerClassificationSLEntityView> SaveButton { get; set; } 
        public IRPSButton<CustomerClassificationSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<CustomerClassificationSLEntityView,CustomerClassificationSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerClassificationSLEntityView,CustomerClassificationSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CustomerClassificationSLEntityView> CodCustomerClassification { get; set; } 
        public IRPSTextBox<CustomerClassificationSLEntityView> Description { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> CodLanguage { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> CodCountry { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> IDBusinessUnitDetail { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> IDPaymentMethod { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> IDCurrency { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> IDVATType { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> IDTaxGroup { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> IDDeliveryNoteType { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> IDDeliveryNoteTypeGroup { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> IDInvoiceTypeGroup { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> CodTransportMethod { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> CodDeliveryTerm { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> IDCustomerCommissionGroup { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> IDThirdAccType { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> IDVoucherType { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> IDPriceList { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> IDDiscountGroup { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> IDCommercialConditionGroup { get; set; } 
        public IRPSCheckbox<CustomerClassificationSLEntityView> ConditionsAffectDocument { get; set; } 
        public IRPSCheckbox<CustomerClassificationSLEntityView> ConditionsNotAffectDocument { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> IDCodingSerieSalesQuote { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> IDCodingSerieOrder { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> IDCodingSerieDeliveryNote { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> IDCodingSerieDeliveryNoteB { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> IDCodingSerieInvoice { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> IDCodingSerieInvoiceB { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> IDCodingSerieCreditInvoice { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> IDCodingSerieCreditInvoiceB { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> IDCodingSerieAdvanceInvoice { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> IDCodingSerieAdvanceInvoiceB { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> IDCodingSerieDebitNote { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> IDCodingSerieDebitNoteB { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> IDCodingSerieCustomer { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> IDCodingSeriePotentialCustomer { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> IDCodingSerieFrameworkContract { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> IDTextLineOfferPre { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> IDTextLineFContractPre { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> IDTextLineOrderPre { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> IDTextLineDNotePre { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> IDTextLineInvoicePre { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> IDTextLineCreditPre { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> IDTextLineAdvancePre { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> IDTextLineOfferPost { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> IDTextLineFContractPost { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> IDTextLineOrderPost { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> IDTextLineDNotePost { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> IDTextLineInvoicePost { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> IDTextLineCreditPost { get; set; } 
        public IRPSComboBox<CustomerClassificationSLEntityView> IDTextLineAdvancePost { get; set; } 
        public CustomerClassificationDetailSLsCollectionEditor<CustomerClassificationSLEntityView,CustomerClassificationDetailSLView> CustomerClassificationDetailSLs { get; set; } 
        public IRPSSection<CustomerClassificationSLEntityView> GeneralData { get; set; } 
        public IRPSSection<CustomerClassificationSLEntityView> SubsidiaryCompanies { get; set; } 
        public IRPSSection<CustomerClassificationSLEntityView> Texts { get; set; } 
        public CustomerClassificationSL Screen { get; set; }
        public CustomerClassificationSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CustomerClassificationDetailSLsCollectionEditor<CustomerClassificationSLEntityView,CustomerClassificationDetailSLView>:RPSCollectionEditor<CustomerClassificationSLEntityView,CustomerClassificationDetailSLView> where CustomerClassificationSLEntityView : class, IView where CustomerClassificationDetailSLView : class, IView
    {
        public  CustomerClassificationDetailSLsGridView<CustomerClassificationSLEntityView,CustomerClassificationDetailSLView> GridView {get;set;}
    }
    public partial class CustomerClassificationDetailSLsGridView <CustomerClassificationSLEntityView,CustomerClassificationDetailSLView> :  RPSGridView<CustomerClassificationSLEntityView,CustomerClassificationDetailSLView> where CustomerClassificationSLEntityView : class, IView where CustomerClassificationDetailSLView : class, IView
    {
        public CustomerClassificationDetailSLsGridView(CustomerClassificationSLEntityView currentView,CustomerClassificationDetailSLView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodCompany = RPSControlFactory.CreateRPSGridComboBox<CustomerClassificationSLEntityView>("","#4dc8e762-fb42-4eae-b7cb-a77d24289da1 .ag-row[role='row']@ROWINDEX [col-id='cCodCompany']","",true, this.CurrentView);
 
            IDCurrency = RPSControlFactory.CreateRPSGridComboBox<CustomerClassificationSLEntityView>("","#4dc8e762-fb42-4eae-b7cb-a77d24289da1 .ag-row[role='row']@ROWINDEX [col-id='cIDCurrency']","",false, this.CurrentView);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSGridComboBox<CustomerClassificationSLEntityView>("","#4dc8e762-fb42-4eae-b7cb-a77d24289da1 .ag-row[role='row']@ROWINDEX [col-id='cIDPaymentMethod']","",false, this.CurrentView);
 
            IDVATType = RPSControlFactory.CreateRPSGridComboBox<CustomerClassificationSLEntityView>("","#4dc8e762-fb42-4eae-b7cb-a77d24289da1 .ag-row[role='row']@ROWINDEX [col-id='cIDVATType']","",false, this.CurrentView);
 
            IDPriceList = RPSControlFactory.CreateRPSGridComboBox<CustomerClassificationSLEntityView>("","#4dc8e762-fb42-4eae-b7cb-a77d24289da1 .ag-row[role='row']@ROWINDEX [col-id='cIDPriceList']","",false, this.CurrentView);
 
            IDBusinessUnit = RPSControlFactory.CreateRPSGridComboBox<CustomerClassificationSLEntityView>("","#4dc8e762-fb42-4eae-b7cb-a77d24289da1 .ag-row[role='row']@ROWINDEX [col-id='cIDBusinessUnit']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<CustomerClassificationSLEntityView> CodCompany { get; set; } 
        public IRPSGridComboBox<CustomerClassificationSLEntityView> IDCurrency { get; set; } 
        public IRPSGridComboBox<CustomerClassificationSLEntityView> IDPaymentMethod { get; set; } 
        public IRPSGridComboBox<CustomerClassificationSLEntityView> IDVATType { get; set; } 
        public IRPSGridComboBox<CustomerClassificationSLEntityView> IDPriceList { get; set; } 
        public IRPSGridComboBox<CustomerClassificationSLEntityView> IDBusinessUnit { get; set; } 
                     
    }
 
    }
  
            
    public partial class CustomerClassificationDetailSLView : View
    {
        public CustomerClassificationDetailSLView(CustomerClassificationSL screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CustomerClassificationDetailSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CustomerClassificationDetailSLView,CustomerClassificationSLEntityView>( this,Screen.CustomerClassificationSLEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<CustomerClassificationDetailSLView,CustomerClassificationSLEntityView>( this,Screen.CustomerClassificationSLEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CustomerClassificationDetailSLView,CustomerClassificationSLEntityView>( this,Screen.CustomerClassificationSLEntityView);
 
            CodCompany = RPSControlFactory.CreateRPSComboBox<CustomerClassificationDetailSLView>("9233fdc1-55ea-40c3-ba50-709d7991ec0a","","",true, this);
 
            IDVATType = RPSControlFactory.CreateRPSComboBox<CustomerClassificationDetailSLView>("775b6048-21bf-4847-bf76-f83a4228613e","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<CustomerClassificationDetailSLView>("2f65b416-88f1-4d7f-ae44-c2fce15f1afb","","",false, this);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSComboBox<CustomerClassificationDetailSLView>("804dbc07-42f8-4b48-bad8-adc1f30d9f7e","","",false, this);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<CustomerClassificationDetailSLView>("1628f408-ca13-4984-a3ee-1d6242393b50","","",false, this);
 
            IDTaxGroup = RPSControlFactory.CreateRPSComboBox<CustomerClassificationDetailSLView>("7e731a83-4b0e-4c4c-8d11-bbfac33407b1","","",false, this);
 
            IDBusinessUnit = RPSControlFactory.CreateRPSComboBox<CustomerClassificationDetailSLView>("ac90aa3b-ceb6-42fe-af1d-01b6ee8515a9","","",false, this);
 
            IDCodingSerieSalesQuote = RPSControlFactory.CreateRPSComboBox<CustomerClassificationDetailSLView>("79005f89-1f11-4405-b3d6-de894f63d306","","",false, this);
 
            IDCodingSerieOrder = RPSControlFactory.CreateRPSComboBox<CustomerClassificationDetailSLView>("4866a203-f4b8-4cae-b45a-92abe929fd02","","",false, this);
 
            IDCodingSerieDeliveryNote = RPSControlFactory.CreateRPSComboBox<CustomerClassificationDetailSLView>("db3f28f2-2746-468b-9249-8b97dd3c5f8f","","",false, this);
 
            IDCodingSerieDeliveryNoteB = RPSControlFactory.CreateRPSComboBox<CustomerClassificationDetailSLView>("cb6ab3ae-0d8f-4028-9342-ad4ec4acb8d3","","",false, this);
 
            IDCodingSerieInvoice = RPSControlFactory.CreateRPSComboBox<CustomerClassificationDetailSLView>("d9becae8-ef7f-402b-8b37-41d5c005ad61","","",false, this);
 
            IDCodingSerieInvoiceB = RPSControlFactory.CreateRPSComboBox<CustomerClassificationDetailSLView>("3598f294-f42e-4972-a389-76200acf6149","","",false, this);
 
            IDCodingSerieCreditInvoice = RPSControlFactory.CreateRPSComboBox<CustomerClassificationDetailSLView>("660eeb79-39e3-4ef7-b0e6-a3e3c245f609","","",false, this);
 
            IDCodingSerieCreditInvoiceB = RPSControlFactory.CreateRPSComboBox<CustomerClassificationDetailSLView>("de9d0e6a-6402-45a0-894f-53eecd60e593","","",false, this);
 
            IDCodingSerieAdvanceInvoice = RPSControlFactory.CreateRPSComboBox<CustomerClassificationDetailSLView>("8be005f2-74aa-4edb-8bd8-644562f99542","","",false, this);
 
            IDCodingSerieAdvanceInvoiceB = RPSControlFactory.CreateRPSComboBox<CustomerClassificationDetailSLView>("77ba3904-5a34-4ff5-8038-2b547d41030c","","",false, this);
 
            IDCodingSerieDebitNote = RPSControlFactory.CreateRPSComboBox<CustomerClassificationDetailSLView>("bce27e23-c495-47ab-9d9f-087394e58c19","","",false, this);
 
            IDCodingSerieDebitNoteB = RPSControlFactory.CreateRPSComboBox<CustomerClassificationDetailSLView>("006c016d-a276-4053-9fac-a4bea08a40a7","","",false, this);
 
            IDCodingSerieCustomer = RPSControlFactory.CreateRPSComboBox<CustomerClassificationDetailSLView>("eaa5ea3f-93df-446d-9660-619e207fa15d","","",false, this);
 
            IDCodingSeriePotentialCustomer = RPSControlFactory.CreateRPSComboBox<CustomerClassificationDetailSLView>("b3108dd9-8f2a-4d2b-80ef-5c572f06bbff","","",false, this);
 
            IDCommercialConditionGroup = RPSControlFactory.CreateRPSComboBox<CustomerClassificationDetailSLView>("4634b1d0-f371-4b37-b49c-1d45f6d02438","","",false, this);
 
            IDPriceList = RPSControlFactory.CreateRPSComboBox<CustomerClassificationDetailSLView>("9b1405f7-27bf-43e7-9406-baf09725bae8","","",false, this);
 
            IDDiscountGroup = RPSControlFactory.CreateRPSComboBox<CustomerClassificationDetailSLView>("7cf97d0d-4060-4055-9ab7-fca84f1357b0","","",false, this);
 
            IDCustomerCommissionGroup = RPSControlFactory.CreateRPSComboBox<CustomerClassificationDetailSLView>("e0ee4535-bf95-4587-9d1d-daf9f2aed122","","",false, this);
 
            IDThirdAccType = RPSControlFactory.CreateRPSComboBox<CustomerClassificationDetailSLView>("3ca7f73a-279f-49fe-beaa-2d459e1fcde6","","",false, this);
 
            IDVoucherType = RPSControlFactory.CreateRPSComboBox<CustomerClassificationDetailSLView>("9d15b38f-5ea2-4b73-a25d-4b47f3845296","","",false, this);
 
            IDTextLineOfferPre = RPSControlFactory.CreateRPSComboBox<CustomerClassificationDetailSLView>("6090918f-b61b-4450-bdc9-4ffda23871ba","","",false, this);
 
            IDTextLineFContractPre = RPSControlFactory.CreateRPSComboBox<CustomerClassificationDetailSLView>("96c415e9-0562-4484-96e9-ea394ae0d0c5","","",false, this);
 
            IDTextLineOrderPre = RPSControlFactory.CreateRPSComboBox<CustomerClassificationDetailSLView>("2c33b4b8-237a-4edd-ad3d-afdfcb34256f","","",false, this);
 
            IDTextLineDNotePre = RPSControlFactory.CreateRPSComboBox<CustomerClassificationDetailSLView>("70c2ba2c-bec3-4fb5-bbeb-1c0c3ef049fb","","",false, this);
 
            IDTextLineInvoicePre = RPSControlFactory.CreateRPSComboBox<CustomerClassificationDetailSLView>("2be49a9f-a933-4926-8867-5e5297c2ad05","","",false, this);
 
            IDTextLineAdvancePre = RPSControlFactory.CreateRPSComboBox<CustomerClassificationDetailSLView>("29b40e38-b14d-4916-ace5-5433695486c1","","",false, this);
 
            IDTextLineOfferPost = RPSControlFactory.CreateRPSComboBox<CustomerClassificationDetailSLView>("f8552839-c079-4a87-9d15-4575d7800d90","","",false, this);
 
            IDTextLineFContractPost = RPSControlFactory.CreateRPSComboBox<CustomerClassificationDetailSLView>("bd156305-04c5-41db-b5d2-b37eae74ff9c","","",false, this);
 
            IDTextLineOrderPost = RPSControlFactory.CreateRPSComboBox<CustomerClassificationDetailSLView>("c03d6e74-3e7d-4edd-a01a-359587724404","","",false, this);
 
            IDTextLineDNotePost = RPSControlFactory.CreateRPSComboBox<CustomerClassificationDetailSLView>("b839b980-caba-466d-9424-3e119e3af553","","",false, this);
 
            IDTextLineInvoicePost = RPSControlFactory.CreateRPSComboBox<CustomerClassificationDetailSLView>("a5e5b5c4-06e3-48c6-92e3-1e939c62b77d","","",false, this);
 
            IDTextLineAdvancePost = RPSControlFactory.CreateRPSComboBox<CustomerClassificationDetailSLView>("477740ce-f523-4c69-a45f-141ec4d0bde7","","",false, this);
 

        }
        public IRPSButton<CustomerClassificationDetailSLView> DeleteButton { get; set; } 
        public IRPSButton<CustomerClassificationDetailSLView,CustomerClassificationSLEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CustomerClassificationDetailSLView,CustomerClassificationSLEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CustomerClassificationDetailSLView,CustomerClassificationSLEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<CustomerClassificationDetailSLView> CodCompany { get; set; } 
        public IRPSComboBox<CustomerClassificationDetailSLView> IDVATType { get; set; } 
        public IRPSComboBox<CustomerClassificationDetailSLView> IDCurrency { get; set; } 
        public IRPSComboBox<CustomerClassificationDetailSLView> IDPaymentMethod { get; set; } 
        public IRPSComboBox<CustomerClassificationDetailSLView> IDDeliveryNoteType { get; set; } 
        public IRPSComboBox<CustomerClassificationDetailSLView> IDTaxGroup { get; set; } 
        public IRPSComboBox<CustomerClassificationDetailSLView> IDBusinessUnit { get; set; } 
        public IRPSComboBox<CustomerClassificationDetailSLView> IDCodingSerieSalesQuote { get; set; } 
        public IRPSComboBox<CustomerClassificationDetailSLView> IDCodingSerieOrder { get; set; } 
        public IRPSComboBox<CustomerClassificationDetailSLView> IDCodingSerieDeliveryNote { get; set; } 
        public IRPSComboBox<CustomerClassificationDetailSLView> IDCodingSerieDeliveryNoteB { get; set; } 
        public IRPSComboBox<CustomerClassificationDetailSLView> IDCodingSerieInvoice { get; set; } 
        public IRPSComboBox<CustomerClassificationDetailSLView> IDCodingSerieInvoiceB { get; set; } 
        public IRPSComboBox<CustomerClassificationDetailSLView> IDCodingSerieCreditInvoice { get; set; } 
        public IRPSComboBox<CustomerClassificationDetailSLView> IDCodingSerieCreditInvoiceB { get; set; } 
        public IRPSComboBox<CustomerClassificationDetailSLView> IDCodingSerieAdvanceInvoice { get; set; } 
        public IRPSComboBox<CustomerClassificationDetailSLView> IDCodingSerieAdvanceInvoiceB { get; set; } 
        public IRPSComboBox<CustomerClassificationDetailSLView> IDCodingSerieDebitNote { get; set; } 
        public IRPSComboBox<CustomerClassificationDetailSLView> IDCodingSerieDebitNoteB { get; set; } 
        public IRPSComboBox<CustomerClassificationDetailSLView> IDCodingSerieCustomer { get; set; } 
        public IRPSComboBox<CustomerClassificationDetailSLView> IDCodingSeriePotentialCustomer { get; set; } 
        public IRPSComboBox<CustomerClassificationDetailSLView> IDCommercialConditionGroup { get; set; } 
        public IRPSComboBox<CustomerClassificationDetailSLView> IDPriceList { get; set; } 
        public IRPSComboBox<CustomerClassificationDetailSLView> IDDiscountGroup { get; set; } 
        public IRPSComboBox<CustomerClassificationDetailSLView> IDCustomerCommissionGroup { get; set; } 
        public IRPSComboBox<CustomerClassificationDetailSLView> IDThirdAccType { get; set; } 
        public IRPSComboBox<CustomerClassificationDetailSLView> IDVoucherType { get; set; } 
        public IRPSComboBox<CustomerClassificationDetailSLView> IDTextLineOfferPre { get; set; } 
        public IRPSComboBox<CustomerClassificationDetailSLView> IDTextLineFContractPre { get; set; } 
        public IRPSComboBox<CustomerClassificationDetailSLView> IDTextLineOrderPre { get; set; } 
        public IRPSComboBox<CustomerClassificationDetailSLView> IDTextLineDNotePre { get; set; } 
        public IRPSComboBox<CustomerClassificationDetailSLView> IDTextLineInvoicePre { get; set; } 
        public IRPSComboBox<CustomerClassificationDetailSLView> IDTextLineAdvancePre { get; set; } 
        public IRPSComboBox<CustomerClassificationDetailSLView> IDTextLineOfferPost { get; set; } 
        public IRPSComboBox<CustomerClassificationDetailSLView> IDTextLineFContractPost { get; set; } 
        public IRPSComboBox<CustomerClassificationDetailSLView> IDTextLineOrderPost { get; set; } 
        public IRPSComboBox<CustomerClassificationDetailSLView> IDTextLineDNotePost { get; set; } 
        public IRPSComboBox<CustomerClassificationDetailSLView> IDTextLineInvoicePost { get; set; } 
        public IRPSComboBox<CustomerClassificationDetailSLView> IDTextLineAdvancePost { get; set; } 
        public CustomerClassificationSL Screen { get; set; }
        public CustomerClassificationDetailSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}