    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.VoucherTemplate
{
    //RPS VERSION 1.0.0.0
    public partial class VoucherTemplate:Screen
    {
        public VoucherTemplate():base()
        {
            this.URL = "generalledger.vouchertemplate";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            VoucherTemplateCollectionView  = new VoucherTemplateCollectionView(this); 
            VoucherTemplateEntityView  = new VoucherTemplateEntityView(this); 
            VoucherTemplateDetailView  = new VoucherTemplateDetailView(this); 
            AmountFormulaChildDialogView  = new AmountFormulaChildDialogView(this); 
            ConceptoFormulaChildDialogView  = new ConceptoFormulaChildDialogView(this); 
            ExtensionChildDialogView  = new ExtensionChildDialogView(this); 
            BankAccountCompanyChildDialogView  = new BankAccountCompanyChildDialogView(this); 
            VATChildDialogView  = new VATChildDialogView(this); 
            TAXValueChildDialogView  = new TAXValueChildDialogView(this); 
            CustomerChildDialogView  = new CustomerChildDialogView(this); 
            SupplierChildDialogView  = new SupplierChildDialogView(this); 
            AccountChildDialogView  = new AccountChildDialogView(this); 
            CopyVoucherTemplateChildDialogView  = new CopyVoucherTemplateChildDialogView(this); 
            VoucherTemplateAnalyticView  = new VoucherTemplateAnalyticView(this); 
            OtherCustomerChildDialogView  = new OtherCustomerChildDialogView(this); 
            OtherSupplierChildDialogView  = new OtherSupplierChildDialogView(this); 
            FixedAssetChildDialogView  = new FixedAssetChildDialogView(this); 
            VoucherTemplateCollectionView.InitializeControls(); 
            VoucherTemplateEntityView.InitializeControls(); 
            VoucherTemplateDetailView.InitializeControls(); 
            AmountFormulaChildDialogView.InitializeControls(); 
            ConceptoFormulaChildDialogView.InitializeControls(); 
            ExtensionChildDialogView.InitializeControls(); 
            BankAccountCompanyChildDialogView.InitializeControls(); 
            VATChildDialogView.InitializeControls(); 
            TAXValueChildDialogView.InitializeControls(); 
            CustomerChildDialogView.InitializeControls(); 
            SupplierChildDialogView.InitializeControls(); 
            AccountChildDialogView.InitializeControls(); 
            CopyVoucherTemplateChildDialogView.InitializeControls(); 
            VoucherTemplateAnalyticView.InitializeControls(); 
            OtherCustomerChildDialogView.InitializeControls(); 
            OtherSupplierChildDialogView.InitializeControls(); 
            FixedAssetChildDialogView.InitializeControls(); 
           
        }
      
            public VoucherTemplateCollectionView VoucherTemplateCollectionView {get; set; } 
            public VoucherTemplateEntityView VoucherTemplateEntityView {get; set; } 
            public VoucherTemplateDetailView VoucherTemplateDetailView {get; set; } 
            public AmountFormulaChildDialogView AmountFormulaChildDialogView {get; set; } 
            public ConceptoFormulaChildDialogView ConceptoFormulaChildDialogView {get; set; } 
            public ExtensionChildDialogView ExtensionChildDialogView {get; set; } 
            public BankAccountCompanyChildDialogView BankAccountCompanyChildDialogView {get; set; } 
            public VATChildDialogView VATChildDialogView {get; set; } 
            public TAXValueChildDialogView TAXValueChildDialogView {get; set; } 
            public CustomerChildDialogView CustomerChildDialogView {get; set; } 
            public SupplierChildDialogView SupplierChildDialogView {get; set; } 
            public AccountChildDialogView AccountChildDialogView {get; set; } 
            public CopyVoucherTemplateChildDialogView CopyVoucherTemplateChildDialogView {get; set; } 
            public VoucherTemplateAnalyticView VoucherTemplateAnalyticView {get; set; } 
            public OtherCustomerChildDialogView OtherCustomerChildDialogView {get; set; } 
            public OtherSupplierChildDialogView OtherSupplierChildDialogView {get; set; } 
            public FixedAssetChildDialogView FixedAssetChildDialogView {get; set; } 
    }
            
    public partial class VoucherTemplateCollectionView : View
    {
        public VoucherTemplateCollectionView(VoucherTemplate screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<VoucherTemplateCollectionView,VoucherTemplateEntityView>( this,Screen.VoucherTemplateEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "0bd88d99-2000-4d3f-9884-42c9d045adb0",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<VoucherTemplateCollectionView,VoucherTemplateEntityView>( params_MainConsult,this,Screen.VoucherTemplateEntityView);
 

        }
        public IRPSButton<VoucherTemplateCollectionView,VoucherTemplateEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<VoucherTemplateCollectionView,VoucherTemplateEntityView> MainConsult { get; set; } 
        public VoucherTemplate Screen { get; set; }
        public VoucherTemplateCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class VoucherTemplateEntityView : View
    {
        public VoucherTemplateEntityView(VoucherTemplate screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<VoucherTemplateEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<VoucherTemplateEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<VoucherTemplateEntityView,VoucherTemplateCollectionView>( this,Screen.VoucherTemplateCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<VoucherTemplateEntityView,VoucherTemplateCollectionView>( this,Screen.VoucherTemplateCollectionView);
 
            CodVoucherTemplate = RPSControlFactory.CreateRPSTextBox<VoucherTemplateEntityView>("00c5809e-3834-447f-bb1b-759af76308d2","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<VoucherTemplateEntityView>("4bf3a960-b7fc-46a0-886d-ee1f5821d21c","","",false, this);
 
            IDVoucherType = RPSControlFactory.CreateRPSComboBox<VoucherTemplateEntityView>("cfc528d2-2a81-4def-8da8-6ef7aab36b71","","",true, this);
 
            IDVoucherSeriesBook = RPSControlFactory.CreateRPSComboBox<VoucherTemplateEntityView>("6c5521dd-332a-40e1-847f-1e0ad444d349","","",true, this);
 
            AccountingDateFormula = RPSControlFactory.CreateRPSEnumComboBox<VoucherTemplateEntityView>("f6e33373-9f06-4fcc-8764-962de017888c","","",true, this);
 
            CustomerFormula = RPSControlFactory.CreateRPSTextBox<VoucherTemplateEntityView>("48244047-ef7e-453e-85cb-2884766b81f3","","",false, this);
 
            OtherCustomerChildNavigationCommand = RPSControlFactory.CreateRPSButtonToView<VoucherTemplateEntityView,OtherCustomerChildDialogView>("60f6074b-72be-4e7b-8548-d00a0fe2a013","","", this,Screen.OtherCustomerChildDialogView);
 
            SupplierFormula = RPSControlFactory.CreateRPSTextBox<VoucherTemplateEntityView>("09d16ba1-9781-4a1f-a702-f305c63c0ec5","","",false, this);
 
            OtherSupplierChildNavigationCommand = RPSControlFactory.CreateRPSButtonToView<VoucherTemplateEntityView,OtherSupplierChildDialogView>("4a2af412-2a76-47e5-9e38-0d6906a3b2e6","","", this,Screen.OtherSupplierChildDialogView);
 
            InvoiceDateFormula = RPSControlFactory.CreateRPSEnumComboBox<VoucherTemplateEntityView>("f5a0ff88-978e-4b23-ba2c-e2aa265fe29f","","",false, this);
 
            CodInvoice = RPSControlFactory.CreateRPSTextBox<VoucherTemplateEntityView>("0aa9ee1e-77b1-4ac6-8dcc-7da3a849045e","","",false, this);
 
            DeliveryNoteDateFormula = RPSControlFactory.CreateRPSEnumComboBox<VoucherTemplateEntityView>("c12740af-9a4f-458d-8ba4-edd5410a3e97","","",false, this);
 
            CodDeliveryNote = RPSControlFactory.CreateRPSTextBox<VoucherTemplateEntityView>("d20dfc23-63e2-4b92-b6dd-278c14460d22","","",false, this);
 
            Renting = RPSControlFactory.CreateRPSCheckBox<VoucherTemplateEntityView>("a041c4c0-13eb-4100-8553-684c0fce4006","","",true, this);
 
            FixedAssetChildNavigationCommand = RPSControlFactory.CreateRPSButtonToView<VoucherTemplateEntityView,FixedAssetChildDialogView>("f171ece3-2516-4574-ab1c-6d163b098b06","","", this,Screen.FixedAssetChildDialogView);
 
            IDEUInvoice = RPSControlFactory.CreateRPSComboBox<VoucherTemplateEntityView>("045a2fb0-2420-4f0f-9cd7-252983cfe921","","",false, this);
 
            CopyVoucherTemplateChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<VoucherTemplateEntityView,CopyVoucherTemplateChildDialogView>("7d012755-49f3-4329-acce-88071ec0a3be","","", this,Screen.CopyVoucherTemplateChildDialogView);
 
            CollectionInit params_VoucherTemplateDetails = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="40e9832a-7bac-42db-a882-33d0cf270057",CSSSelectorGrid="",XPathGrid=""};
            VoucherTemplateDetails = RPSControlFactory.RPSCreateCollectionWithGrid<VoucherTemplateDetailsCollectionEditor<VoucherTemplateEntityView,VoucherTemplateDetailView>,VoucherTemplateEntityView,VoucherTemplateDetailView>( params_VoucherTemplateDetails,this,Screen.VoucherTemplateDetailView);
 
            SectionGeneral = RPSControlFactory.CreateRPSSection<VoucherTemplateEntityView>( "","ul li[rpsid='0ec304ad-8112-4a7a-9916-5ccacbe924ef']","",this);
 
            SectionDetails = RPSControlFactory.CreateRPSSection<VoucherTemplateEntityView>( "","ul li[rpsid='ce3f0292-8c09-4f78-ae4a-8d2c8714eddb']","",this);
 

        }
        public IRPSSaveButton<VoucherTemplateEntityView> SaveButton { get; set; } 
        public IRPSButton<VoucherTemplateEntityView> DeleteButton { get; set; } 
        public IRPSButton<VoucherTemplateEntityView,VoucherTemplateCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<VoucherTemplateEntityView,VoucherTemplateCollectionView> BackButton { get; set; } 
        public IRPSTextBox<VoucherTemplateEntityView> CodVoucherTemplate { get; set; } 
        public IRPSTextBox<VoucherTemplateEntityView> Description { get; set; } 
        public IRPSComboBox<VoucherTemplateEntityView> IDVoucherType { get; set; } 
        public IRPSComboBox<VoucherTemplateEntityView> IDVoucherSeriesBook { get; set; } 
        public IRPSComboBox<VoucherTemplateEntityView> AccountingDateFormula { get; set; } 
        public IRPSTextBox<VoucherTemplateEntityView> CustomerFormula { get; set; } 
        public IRPSButton<VoucherTemplateEntityView,OtherCustomerChildDialogView> OtherCustomerChildNavigationCommand { get; set; } 
        public IRPSTextBox<VoucherTemplateEntityView> SupplierFormula { get; set; } 
        public IRPSButton<VoucherTemplateEntityView,OtherSupplierChildDialogView> OtherSupplierChildNavigationCommand { get; set; } 
        public IRPSComboBox<VoucherTemplateEntityView> InvoiceDateFormula { get; set; } 
        public IRPSTextBox<VoucherTemplateEntityView> CodInvoice { get; set; } 
        public IRPSComboBox<VoucherTemplateEntityView> DeliveryNoteDateFormula { get; set; } 
        public IRPSTextBox<VoucherTemplateEntityView> CodDeliveryNote { get; set; } 
        public IRPSCheckbox<VoucherTemplateEntityView> Renting { get; set; } 
        public IRPSButton<VoucherTemplateEntityView,FixedAssetChildDialogView> FixedAssetChildNavigationCommand { get; set; } 
        public IRPSComboBox<VoucherTemplateEntityView> IDEUInvoice { get; set; } 
        public IRPSButton<VoucherTemplateEntityView,CopyVoucherTemplateChildDialogView> CopyVoucherTemplateChildNavigationCommandButton { get; set; } 
        public VoucherTemplateDetailsCollectionEditor<VoucherTemplateEntityView,VoucherTemplateDetailView> VoucherTemplateDetails { get; set; } 
        public IRPSSection<VoucherTemplateEntityView> SectionGeneral { get; set; } 
        public IRPSSection<VoucherTemplateEntityView> SectionDetails { get; set; } 
        public VoucherTemplate Screen { get; set; }
        public VoucherTemplateEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class VoucherTemplateDetailsCollectionEditor<VoucherTemplateEntityView,VoucherTemplateDetailView>:RPSCollectionEditor<VoucherTemplateEntityView,VoucherTemplateDetailView> where VoucherTemplateEntityView : class, IView where VoucherTemplateDetailView : class, IView
    {
        public  VoucherTemplateDetailsGridView<VoucherTemplateEntityView,VoucherTemplateDetailView> GridView {get;set;}
    }
    public partial class VoucherTemplateDetailsGridView <VoucherTemplateEntityView,VoucherTemplateDetailView> :  RPSGridView<VoucherTemplateEntityView,VoucherTemplateDetailView> where VoucherTemplateEntityView : class, IView where VoucherTemplateDetailView : class, IView
    {
        public VoucherTemplateDetailsGridView(VoucherTemplateEntityView currentView,VoucherTemplateDetailView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            VoucherTemplateNumberLine = RPSControlFactory.CreateRPSGridFormattedTextBox<VoucherTemplateEntityView>("","#40e9832a-7bac-42db-a882-33d0cf270057 .ag-row[role='row']@ROWINDEX [col-id='cVoucherTemplateNumberLine']","",true, this.CurrentView);
 
            MovementType = RPSControlFactory.CreateRPSGridEnumComboBox<VoucherTemplateEntityView>("","#40e9832a-7bac-42db-a882-33d0cf270057 .ag-row[role='row']@ROWINDEX [col-id='cMovementType']","",true, this.CurrentView);
 
            SignType = RPSControlFactory.CreateRPSGridEnumComboBox<VoucherTemplateEntityView>("","#40e9832a-7bac-42db-a882-33d0cf270057 .ag-row[role='row']@ROWINDEX [col-id='cSignType']","",true, this.CurrentView);
 
            AmountFormula = RPSControlFactory.CreateRPSGridTextBox<VoucherTemplateEntityView>("","#40e9832a-7bac-42db-a882-33d0cf270057 .ag-row[role='row']@ROWINDEX [col-id='cAmountFormula']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<VoucherTemplateEntityView> VoucherTemplateNumberLine { get; set; } 
        public IRPSGridComboBox<VoucherTemplateEntityView> MovementType { get; set; } 
        public IRPSGridComboBox<VoucherTemplateEntityView> SignType { get; set; } 
        public IRPSGridTextBox<VoucherTemplateEntityView> AmountFormula { get; set; } 
                     
    }
 
    }
  
            
    public partial class VoucherTemplateDetailView : View
    {
        public VoucherTemplateDetailView(VoucherTemplate screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<VoucherTemplateDetailView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<VoucherTemplateDetailView,VoucherTemplateEntityView>( this,Screen.VoucherTemplateEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<VoucherTemplateDetailView,VoucherTemplateEntityView>( this,Screen.VoucherTemplateEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<VoucherTemplateDetailView,VoucherTemplateEntityView>( this,Screen.VoucherTemplateEntityView);
 
            VoucherTemplateNumberLine = RPSControlFactory.CreateRPSFormattedTextBox<VoucherTemplateDetailView>("96090fa1-6978-4c65-9403-b3b173361aa7","","",true, this);
 
            MovementType = RPSControlFactory.CreateRPSEnumComboBox<VoucherTemplateDetailView>("2a9896e3-0392-421a-a585-bf57d0bf4e85","","",true, this);
 
            PostingFormula = RPSControlFactory.CreateRPSTextBox<VoucherTemplateDetailView>("a31f97ec-9bc7-482a-b9de-36dcff8b516c","","",false, this);
 
            SupplierChildNavigationCommand = RPSControlFactory.CreateRPSButtonToView<VoucherTemplateDetailView,SupplierChildDialogView>("281d72ac-f43c-47b7-b55f-071768cf5eb6","","", this,Screen.SupplierChildDialogView);
 
            CustomerChildNavigationCommand = RPSControlFactory.CreateRPSButtonToView<VoucherTemplateDetailView,CustomerChildDialogView>("64d0e58b-0256-4abd-80a1-d2d757a62f95","","", this,Screen.CustomerChildDialogView);
 
            BankAccountCompanyChildNavigationCommand = RPSControlFactory.CreateRPSButtonToView<VoucherTemplateDetailView,BankAccountCompanyChildDialogView>("19254616-8a42-46a9-8a57-a71a25e4bd97","","", this,Screen.BankAccountCompanyChildDialogView);
 
            VATChildNavigationCommand = RPSControlFactory.CreateRPSButtonToView<VoucherTemplateDetailView,VATChildDialogView>("4597cf8e-b5c2-4b6a-a3ae-2066ea9733a0","","", this,Screen.VATChildDialogView);
 
            TAXValueChildNavigationCommand = RPSControlFactory.CreateRPSButtonToView<VoucherTemplateDetailView,TAXValueChildDialogView>("b9a2e8b5-348b-4de7-b5f7-31689e160636","","", this,Screen.TAXValueChildDialogView);
 
            AccountFormula = RPSControlFactory.CreateRPSTextBox<VoucherTemplateDetailView>("b3d3b49d-c890-4341-9e00-8245507c7c66","","",false, this);
 
            AccountChildNavigationCommand = RPSControlFactory.CreateRPSButtonToView<VoucherTemplateDetailView,AccountChildDialogView>("a0eaea8c-ab67-4bdb-ab6b-c7cd20a1a913","","", this,Screen.AccountChildDialogView);
 
            SignType = RPSControlFactory.CreateRPSEnumComboBox<VoucherTemplateDetailView>("5cdc0199-1a8d-4dac-9785-bbec61310535","","",true, this);
 
            AmountFormula = RPSControlFactory.CreateRPSTextBox<VoucherTemplateDetailView>("5cbe5c6d-f494-4cd2-861c-08a1b9ab95ff","","",true, this);
 
            AmountFormulaChildNavigationCommand = RPSControlFactory.CreateRPSButtonToView<VoucherTemplateDetailView,AmountFormulaChildDialogView>("db43be68-7372-423f-94cd-d711e7294a2f","","", this,Screen.AmountFormulaChildDialogView);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<VoucherTemplateDetailView>("a35701ef-3793-4052-b85b-4aac1035fcfa","","",true, this);
 
            AccConceptFormula = RPSControlFactory.CreateRPSTextBox<VoucherTemplateDetailView>("2e901e62-7c0e-40b8-992c-23b1c792c6c2","","",false, this);
 
            ConceptoFormulaChildNavigationCommand = RPSControlFactory.CreateRPSButtonToView<VoucherTemplateDetailView,ConceptoFormulaChildDialogView>("63bac42c-c3b9-4e9c-852b-bca0bd77c7c0","","", this,Screen.ConceptoFormulaChildDialogView);
 
            ExtensionFormula = RPSControlFactory.CreateRPSTextBox<VoucherTemplateDetailView>("4ed4e935-62fe-46ac-86be-202f2df35c3f","","",false, this);
 
            ExtensionChildNavigationCommand = RPSControlFactory.CreateRPSButtonToView<VoucherTemplateDetailView,ExtensionChildDialogView>("9184e33a-bb53-49e2-847b-f207dbd23aaa","","", this,Screen.ExtensionChildDialogView);
 
            CodCompanyCON = RPSControlFactory.CreateRPSEnumComboBox<VoucherTemplateDetailView>("d55f6a9b-7946-41c9-8dde-3db7a69a9ef0","","",false, this);
 
            CodCompanyGR = RPSControlFactory.CreateRPSEnumComboBox<VoucherTemplateDetailView>("cb8260ad-3b11-489d-9001-c8072e14f5b3","","",false, this);
 
            CollectionInit params_VoucherTemplateAnalytics = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ae68cd32-4ecd-40ec-abbb-91d4d28caa6c",CSSSelectorGrid="",XPathGrid=""};
            VoucherTemplateAnalytics = RPSControlFactory.RPSCreateCollectionWithGrid<VoucherTemplateAnalyticsCollectionEditor<VoucherTemplateDetailView,VoucherTemplateAnalyticView>,VoucherTemplateDetailView,VoucherTemplateAnalyticView>( params_VoucherTemplateAnalytics,this,Screen.VoucherTemplateAnalyticView);
 
            SectionGeneral = RPSControlFactory.CreateRPSSection<VoucherTemplateDetailView>( "","ul li[rpsid='37607d39-c6b8-471e-b0f2-a7c8601a457b']","",this);
 
            SectionAnalytic = RPSControlFactory.CreateRPSSection<VoucherTemplateDetailView>( "","ul li[rpsid='8f3323d8-72bd-445f-82bd-dec42615b59c']","",this);
 

        }
        public IRPSButton<VoucherTemplateDetailView> DeleteButton { get; set; } 
        public IRPSButton<VoucherTemplateDetailView,VoucherTemplateEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<VoucherTemplateDetailView,VoucherTemplateEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<VoucherTemplateDetailView,VoucherTemplateEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<VoucherTemplateDetailView> VoucherTemplateNumberLine { get; set; } 
        public IRPSComboBox<VoucherTemplateDetailView> MovementType { get; set; } 
        public IRPSTextBox<VoucherTemplateDetailView> PostingFormula { get; set; } 
        public IRPSButton<VoucherTemplateDetailView,SupplierChildDialogView> SupplierChildNavigationCommand { get; set; } 
        public IRPSButton<VoucherTemplateDetailView,CustomerChildDialogView> CustomerChildNavigationCommand { get; set; } 
        public IRPSButton<VoucherTemplateDetailView,BankAccountCompanyChildDialogView> BankAccountCompanyChildNavigationCommand { get; set; } 
        public IRPSButton<VoucherTemplateDetailView,VATChildDialogView> VATChildNavigationCommand { get; set; } 
        public IRPSButton<VoucherTemplateDetailView,TAXValueChildDialogView> TAXValueChildNavigationCommand { get; set; } 
        public IRPSTextBox<VoucherTemplateDetailView> AccountFormula { get; set; } 
        public IRPSButton<VoucherTemplateDetailView,AccountChildDialogView> AccountChildNavigationCommand { get; set; } 
        public IRPSComboBox<VoucherTemplateDetailView> SignType { get; set; } 
        public IRPSTextBox<VoucherTemplateDetailView> AmountFormula { get; set; } 
        public IRPSButton<VoucherTemplateDetailView,AmountFormulaChildDialogView> AmountFormulaChildNavigationCommand { get; set; } 
        public IRPSComboBox<VoucherTemplateDetailView> IDCurrency { get; set; } 
        public IRPSTextBox<VoucherTemplateDetailView> AccConceptFormula { get; set; } 
        public IRPSButton<VoucherTemplateDetailView,ConceptoFormulaChildDialogView> ConceptoFormulaChildNavigationCommand { get; set; } 
        public IRPSTextBox<VoucherTemplateDetailView> ExtensionFormula { get; set; } 
        public IRPSButton<VoucherTemplateDetailView,ExtensionChildDialogView> ExtensionChildNavigationCommand { get; set; } 
        public IRPSComboBox<VoucherTemplateDetailView> CodCompanyCON { get; set; } 
        public IRPSComboBox<VoucherTemplateDetailView> CodCompanyGR { get; set; } 
        public VoucherTemplateAnalyticsCollectionEditor<VoucherTemplateDetailView,VoucherTemplateAnalyticView> VoucherTemplateAnalytics { get; set; } 
        public IRPSSection<VoucherTemplateDetailView> SectionGeneral { get; set; } 
        public IRPSSection<VoucherTemplateDetailView> SectionAnalytic { get; set; } 
        public VoucherTemplate Screen { get; set; }
        public VoucherTemplateDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class VoucherTemplateAnalyticsCollectionEditor<VoucherTemplateDetailView,VoucherTemplateAnalyticView>:RPSCollectionEditor<VoucherTemplateDetailView,VoucherTemplateAnalyticView> where VoucherTemplateDetailView : class, IView where VoucherTemplateAnalyticView : class, IView
    {
        public  VoucherTemplateAnalyticsGridView<VoucherTemplateDetailView,VoucherTemplateAnalyticView> GridView {get;set;}
    }
    public partial class VoucherTemplateAnalyticsGridView <VoucherTemplateDetailView,VoucherTemplateAnalyticView> :  RPSGridView<VoucherTemplateDetailView,VoucherTemplateAnalyticView> where VoucherTemplateDetailView : class, IView where VoucherTemplateAnalyticView : class, IView
    {
        public VoucherTemplateAnalyticsGridView(VoucherTemplateDetailView currentView,VoucherTemplateAnalyticView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDDimension = RPSControlFactory.CreateRPSGridComboBox<VoucherTemplateDetailView>("","#ae68cd32-4ecd-40ec-abbb-91d4d28caa6c .ag-row[role='row']@ROWINDEX [col-id='cIDDimension']","",true, this.CurrentView);
 
            IDDimValue = RPSControlFactory.CreateRPSGridComboBox<VoucherTemplateDetailView>("","#ae68cd32-4ecd-40ec-abbb-91d4d28caa6c .ag-row[role='row']@ROWINDEX [col-id='cIDDimValue']","",true, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<VoucherTemplateDetailView>("","#ae68cd32-4ecd-40ec-abbb-91d4d28caa6c .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<VoucherTemplateDetailView> IDDimension { get; set; } 
        public IRPSGridComboBox<VoucherTemplateDetailView> IDDimValue { get; set; } 
        public IRPSGridTextBox<VoucherTemplateDetailView> Percentage { get; set; } 
                     
    }
 
    }
  
            
    public partial class AmountFormulaChildDialogView : View
    {
        public AmountFormulaChildDialogView(VoucherTemplate screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Manual = RPSControlFactory.CreateRPSOption<AmountFormulaChildDialogView>( "2f9d01f4-7739-4e75-b723-c3c08ef91385","","",this);
 
            Formula = RPSControlFactory.CreateRPSOption<AmountFormulaChildDialogView>( "259d46d3-e7fd-413c-9ff8-3075dd53a523","","",this);
 
            AmountFormulaAux = RPSControlFactory.CreateRPSTextBox<AmountFormulaChildDialogView>("b2c53632-3091-4830-a9a3-adadfbd2c825","","",false, this);
 
            AddCommandOperator = RPSControlFactory.CreateRPSButton<AmountFormulaChildDialogView>( "80d4c32d-0208-436b-aa0e-d690427fa671","","",this);
 
            SubtractCommandOperator = RPSControlFactory.CreateRPSButton<AmountFormulaChildDialogView>( "c5416833-b624-4819-b4c8-06000a37dcd0","","",this);
 
            MultiplyCommandOperator = RPSControlFactory.CreateRPSButton<AmountFormulaChildDialogView>( "879b37e2-d577-4aa9-917d-8b2100a271ae","","",this);
 
            DivideCommandOperator = RPSControlFactory.CreateRPSButton<AmountFormulaChildDialogView>( "c478cdd3-a539-44f5-8778-2837cf13e9b4","","",this);
 
            OpenCommandOperator = RPSControlFactory.CreateRPSButton<AmountFormulaChildDialogView>( "1e0f6b66-c02a-4eb8-927a-060d5e9c617d","","",this);
 
            CloseCommandOperator = RPSControlFactory.CreateRPSButton<AmountFormulaChildDialogView>( "8d9babb7-86fc-421e-940c-0f0f3ce71373","","",this);
 
            NumLine = RPSControlFactory.CreateRPSFormattedTextBox<AmountFormulaChildDialogView>("3853b468-ee27-4798-8a87-e12a55fbf10a","","",false, this);
 
            AddCommand = RPSControlFactory.CreateRPSButton<AmountFormulaChildDialogView>( "40359e4e-2182-4da4-9af6-e5885a4265c7","","",this);
 

        }
        public IRPSOption<AmountFormulaChildDialogView> Manual { get; set; } 
        public IRPSOption<AmountFormulaChildDialogView> Formula { get; set; } 
        public IRPSTextBox<AmountFormulaChildDialogView> AmountFormulaAux { get; set; } 
        public IRPSButton<AmountFormulaChildDialogView> AddCommandOperator { get; set; } 
        public IRPSButton<AmountFormulaChildDialogView> SubtractCommandOperator { get; set; } 
        public IRPSButton<AmountFormulaChildDialogView> MultiplyCommandOperator { get; set; } 
        public IRPSButton<AmountFormulaChildDialogView> DivideCommandOperator { get; set; } 
        public IRPSButton<AmountFormulaChildDialogView> OpenCommandOperator { get; set; } 
        public IRPSButton<AmountFormulaChildDialogView> CloseCommandOperator { get; set; } 
        public IRPSTextBox<AmountFormulaChildDialogView> NumLine { get; set; } 
        public IRPSButton<AmountFormulaChildDialogView> AddCommand { get; set; } 
        public VoucherTemplate Screen { get; set; }
        public AmountFormulaChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ConceptoFormulaChildDialogView : View
    {
        public ConceptoFormulaChildDialogView(VoucherTemplate screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Manual = RPSControlFactory.CreateRPSOption<ConceptoFormulaChildDialogView>( "be86321a-07fe-4d07-b186-9f0931c909b5","","",this);
 
            OneConcept = RPSControlFactory.CreateRPSOption<ConceptoFormulaChildDialogView>( "6ce54430-5a8f-4491-b437-5310c2139f2f","","",this);
 
            IDAccConcept = RPSControlFactory.CreateRPSComboBox<ConceptoFormulaChildDialogView>("ff9b88ad-392d-484d-b6d7-67e3c57b90ca","","",false, this);
 
            ConceptLine = RPSControlFactory.CreateRPSOption<ConceptoFormulaChildDialogView>( "6a5bea6b-e406-468b-b9b5-451493e66df8","","",this);
 
            NumLine = RPSControlFactory.CreateRPSFormattedTextBox<ConceptoFormulaChildDialogView>("ca6b5fdd-8a60-4343-8a76-0621343c541e","","",false, this);
 

        }
        public IRPSOption<ConceptoFormulaChildDialogView> Manual { get; set; } 
        public IRPSOption<ConceptoFormulaChildDialogView> OneConcept { get; set; } 
        public IRPSComboBox<ConceptoFormulaChildDialogView> IDAccConcept { get; set; } 
        public IRPSOption<ConceptoFormulaChildDialogView> ConceptLine { get; set; } 
        public IRPSTextBox<ConceptoFormulaChildDialogView> NumLine { get; set; } 
        public VoucherTemplate Screen { get; set; }
        public ConceptoFormulaChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ExtensionChildDialogView : View
    {
        public ExtensionChildDialogView(VoucherTemplate screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Manual = RPSControlFactory.CreateRPSOption<ExtensionChildDialogView>( "820bbd05-30b8-4a79-b0da-098d06f0a862","","",this);
 
            TextFixed = RPSControlFactory.CreateRPSOption<ExtensionChildDialogView>( "2e93fa84-c31c-401f-8235-5414e29f983e","","",this);
 
            Text_Fixed = RPSControlFactory.CreateRPSTextBox<ExtensionChildDialogView>("abb54d11-a223-4a88-8419-6c0d8deb69b7","","",false, this);
 
            ExtensionLine = RPSControlFactory.CreateRPSOption<ExtensionChildDialogView>( "57cbe33d-99ca-499e-b0bd-a097bd138082","","",this);
 
            NumLine = RPSControlFactory.CreateRPSFormattedTextBox<ExtensionChildDialogView>("93ca49ae-35ce-4a3b-acb3-8cbcd7c257d4","","",false, this);
 

        }
        public IRPSOption<ExtensionChildDialogView> Manual { get; set; } 
        public IRPSOption<ExtensionChildDialogView> TextFixed { get; set; } 
        public IRPSTextBox<ExtensionChildDialogView> Text_Fixed { get; set; } 
        public IRPSOption<ExtensionChildDialogView> ExtensionLine { get; set; } 
        public IRPSTextBox<ExtensionChildDialogView> NumLine { get; set; } 
        public VoucherTemplate Screen { get; set; }
        public ExtensionChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class BankAccountCompanyChildDialogView : View
    {
        public BankAccountCompanyChildDialogView(VoucherTemplate screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Manual = RPSControlFactory.CreateRPSOption<BankAccountCompanyChildDialogView>( "151d8cbf-0547-41c7-b726-3e1d4fd740f8","","",this);
 
            One = RPSControlFactory.CreateRPSOption<BankAccountCompanyChildDialogView>( "a8c89ecd-9555-42a0-a894-9c7619afb5f8","","",this);
 
            IDBankAccountCompany = RPSControlFactory.CreateRPSComboBox<BankAccountCompanyChildDialogView>("1abc05a9-6d76-4945-8038-e78a20887601","","",false, this);
 

        }
        public IRPSOption<BankAccountCompanyChildDialogView> Manual { get; set; } 
        public IRPSOption<BankAccountCompanyChildDialogView> One { get; set; } 
        public IRPSComboBox<BankAccountCompanyChildDialogView> IDBankAccountCompany { get; set; } 
        public VoucherTemplate Screen { get; set; }
        public BankAccountCompanyChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class VATChildDialogView : View
    {
        public VATChildDialogView(VoucherTemplate screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Manual = RPSControlFactory.CreateRPSOption<VATChildDialogView>( "84969958-666d-4d2d-898a-99e321183a65","","",this);
 
            One = RPSControlFactory.CreateRPSOption<VATChildDialogView>( "aaf79205-89b4-45a4-bc9c-a9ba87ce26eb","","",this);
 
            IDVAT = RPSControlFactory.CreateRPSComboBox<VATChildDialogView>("641d2e15-f68d-4bb5-b93c-bfa2abdaf751","","",false, this);
 

        }
        public IRPSOption<VATChildDialogView> Manual { get; set; } 
        public IRPSOption<VATChildDialogView> One { get; set; } 
        public IRPSComboBox<VATChildDialogView> IDVAT { get; set; } 
        public VoucherTemplate Screen { get; set; }
        public VATChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class TAXValueChildDialogView : View
    {
        public TAXValueChildDialogView(VoucherTemplate screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Manual = RPSControlFactory.CreateRPSOption<TAXValueChildDialogView>( "384741fd-fd38-45a2-b9e6-906cb6e7e887","","",this);
 
            One = RPSControlFactory.CreateRPSOption<TAXValueChildDialogView>( "7f8446fd-b28a-4ba4-bbf9-6afe988c4376","","",this);
 
            IDTaxValue = RPSControlFactory.CreateRPSComboBox<TAXValueChildDialogView>("570d73d5-27c1-4ab9-a96d-2a04e50b4ca5","","",false, this);
 

        }
        public IRPSOption<TAXValueChildDialogView> Manual { get; set; } 
        public IRPSOption<TAXValueChildDialogView> One { get; set; } 
        public IRPSComboBox<TAXValueChildDialogView> IDTaxValue { get; set; } 
        public VoucherTemplate Screen { get; set; }
        public TAXValueChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CustomerChildDialogView : View
    {
        public CustomerChildDialogView(VoucherTemplate screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Manual = RPSControlFactory.CreateRPSOption<CustomerChildDialogView>( "433320d4-6238-4c74-81a3-0022ec001c86","","",this);
 
            One = RPSControlFactory.CreateRPSOption<CustomerChildDialogView>( "374cc509-e9da-4360-8180-70533096f298","","",this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<CustomerChildDialogView>("7d25c542-6c4f-4c74-858e-5ec769a800cd","","",false, this);
 
            Manual1 = RPSControlFactory.CreateRPSOption<CustomerChildDialogView>( "69bf1d0b-069b-46a0-bf4a-2a006d99589c","","",this);
 
            One1 = RPSControlFactory.CreateRPSOption<CustomerChildDialogView>( "ac568a11-28e4-4e9f-b1df-66802ebf5de1","","",this);
 
            IDCustomerMiscellaneousSL = RPSControlFactory.CreateRPSComboBox<CustomerChildDialogView>("2c58ca91-41a3-44d9-81ba-41f02f7ddb76","","",false, this);
 

        }
        public IRPSOption<CustomerChildDialogView> Manual { get; set; } 
        public IRPSOption<CustomerChildDialogView> One { get; set; } 
        public IRPSComboBox<CustomerChildDialogView> IDCustomer { get; set; } 
        public IRPSOption<CustomerChildDialogView> Manual1 { get; set; } 
        public IRPSOption<CustomerChildDialogView> One1 { get; set; } 
        public IRPSComboBox<CustomerChildDialogView> IDCustomerMiscellaneousSL { get; set; } 
        public VoucherTemplate Screen { get; set; }
        public CustomerChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SupplierChildDialogView : View
    {
        public SupplierChildDialogView(VoucherTemplate screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Manual = RPSControlFactory.CreateRPSOption<SupplierChildDialogView>( "1b5af2f9-cc22-4f70-80a1-ca6f05ca1352","","",this);
 
            One = RPSControlFactory.CreateRPSOption<SupplierChildDialogView>( "720e6aa0-da69-43bd-8d77-a403fb84170b","","",this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<SupplierChildDialogView>("3905c5dc-7bff-4a04-a88d-00baff324088","","",false, this);
 
            Manual1 = RPSControlFactory.CreateRPSOption<SupplierChildDialogView>( "4480b30d-0475-4a74-af2b-783688109dc2","","",this);
 
            One1 = RPSControlFactory.CreateRPSOption<SupplierChildDialogView>( "7d5f80e6-9c2b-4d1d-9e56-a69d55be8922","","",this);
 
            IDSupplierMiscellaneous = RPSControlFactory.CreateRPSComboBox<SupplierChildDialogView>("e17ed791-1c6c-4fba-a2ff-ee1f5eea1743","","",false, this);
 

        }
        public IRPSOption<SupplierChildDialogView> Manual { get; set; } 
        public IRPSOption<SupplierChildDialogView> One { get; set; } 
        public IRPSComboBox<SupplierChildDialogView> IDSupplier { get; set; } 
        public IRPSOption<SupplierChildDialogView> Manual1 { get; set; } 
        public IRPSOption<SupplierChildDialogView> One1 { get; set; } 
        public IRPSComboBox<SupplierChildDialogView> IDSupplierMiscellaneous { get; set; } 
        public VoucherTemplate Screen { get; set; }
        public SupplierChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class AccountChildDialogView : View
    {
        public AccountChildDialogView(VoucherTemplate screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Manual = RPSControlFactory.CreateRPSOption<AccountChildDialogView>( "290ca1cc-6bdc-4a61-887d-70c4f2c0493b","","",this);
 
            One = RPSControlFactory.CreateRPSOption<AccountChildDialogView>( "2c46a7f4-cfe4-4d99-9a0f-5c3afcf299ef","","",this);
 
            IDAccount = RPSControlFactory.CreateRPSComboBox<AccountChildDialogView>("482922ce-98ce-4bf7-8ded-0a223138d129","","",false, this);
 

        }
        public IRPSOption<AccountChildDialogView> Manual { get; set; } 
        public IRPSOption<AccountChildDialogView> One { get; set; } 
        public IRPSComboBox<AccountChildDialogView> IDAccount { get; set; } 
        public VoucherTemplate Screen { get; set; }
        public AccountChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CopyVoucherTemplateChildDialogView : View
    {
        public CopyVoucherTemplateChildDialogView(VoucherTemplate screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Code = RPSControlFactory.CreateRPSTextBox<CopyVoucherTemplateChildDialogView>("6b6cbba3-4fda-4d90-bf2f-d3d3948da03a","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CopyVoucherTemplateChildDialogView>("605b11f3-333c-4368-8f2d-c4ff64311eea","","",true, this);
 

        }
        public IRPSTextBox<CopyVoucherTemplateChildDialogView> Code { get; set; } 
        public IRPSTextBox<CopyVoucherTemplateChildDialogView> Description { get; set; } 
        public VoucherTemplate Screen { get; set; }
        public CopyVoucherTemplateChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class VoucherTemplateAnalyticView : View
    {
        public VoucherTemplateAnalyticView(VoucherTemplate screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<VoucherTemplateAnalyticView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<VoucherTemplateAnalyticView,VoucherTemplateDetailView>( this,Screen.VoucherTemplateDetailView);
 
            BackButton = RPSControlFactory.RPSBackButton<VoucherTemplateAnalyticView,VoucherTemplateDetailView>( this,Screen.VoucherTemplateDetailView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<VoucherTemplateAnalyticView,VoucherTemplateDetailView>( this,Screen.VoucherTemplateDetailView);
 
            IDDimension = RPSControlFactory.CreateRPSComboBox<VoucherTemplateAnalyticView>("bce7eb18-9e5b-4c36-a434-0379e51314c0","","",true, this);
 
            IDDimValue = RPSControlFactory.CreateRPSComboBox<VoucherTemplateAnalyticView>("5a7bca22-c1eb-4d6a-9f30-d4567392bb5f","","",true, this);
 
            Percentage = RPSControlFactory.CreateRPSFormattedTextBox<VoucherTemplateAnalyticView>("8fa21396-806f-4b20-9989-84deb9b87bdf","","",true, this);
 

        }
        public IRPSButton<VoucherTemplateAnalyticView> DeleteButton { get; set; } 
        public IRPSButton<VoucherTemplateAnalyticView,VoucherTemplateDetailView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<VoucherTemplateAnalyticView,VoucherTemplateDetailView> BackButton { get; set; } 
        public IRPSAcceptButton<VoucherTemplateAnalyticView,VoucherTemplateDetailView> AcceptButton { get; set; } 
        public IRPSComboBox<VoucherTemplateAnalyticView> IDDimension { get; set; } 
        public IRPSComboBox<VoucherTemplateAnalyticView> IDDimValue { get; set; } 
        public IRPSTextBox<VoucherTemplateAnalyticView> Percentage { get; set; } 
        public VoucherTemplate Screen { get; set; }
        public VoucherTemplateAnalyticView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OtherCustomerChildDialogView : View
    {
        public OtherCustomerChildDialogView(VoucherTemplate screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Manual = RPSControlFactory.CreateRPSOption<OtherCustomerChildDialogView>( "545e4767-145f-46f9-8baa-1771ddb1e81c","","",this);
 
            One = RPSControlFactory.CreateRPSOption<OtherCustomerChildDialogView>( "0453164d-3aad-48f8-a5f9-c39f81272cc4","","",this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<OtherCustomerChildDialogView>("8d6322d2-b588-4dc8-9655-77c22252aaf3","","",false, this);
 
            Manual1 = RPSControlFactory.CreateRPSOption<OtherCustomerChildDialogView>( "93d709e5-95db-4e2a-afd8-95f1d49595fe","","",this);
 
            One1 = RPSControlFactory.CreateRPSOption<OtherCustomerChildDialogView>( "28bd89c6-7c31-4096-9435-75e9643316f8","","",this);
 
            IDCustomerMiscellaneousSL = RPSControlFactory.CreateRPSComboBox<OtherCustomerChildDialogView>("e19c355d-8245-48b8-b900-0e4373908bb1","","",false, this);
 

        }
        public IRPSOption<OtherCustomerChildDialogView> Manual { get; set; } 
        public IRPSOption<OtherCustomerChildDialogView> One { get; set; } 
        public IRPSComboBox<OtherCustomerChildDialogView> IDCustomer { get; set; } 
        public IRPSOption<OtherCustomerChildDialogView> Manual1 { get; set; } 
        public IRPSOption<OtherCustomerChildDialogView> One1 { get; set; } 
        public IRPSComboBox<OtherCustomerChildDialogView> IDCustomerMiscellaneousSL { get; set; } 
        public VoucherTemplate Screen { get; set; }
        public OtherCustomerChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class OtherSupplierChildDialogView : View
    {
        public OtherSupplierChildDialogView(VoucherTemplate screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Manual = RPSControlFactory.CreateRPSOption<OtherSupplierChildDialogView>( "e4e065e1-95ff-4afd-98c7-ecaedcd0998c","","",this);
 
            One = RPSControlFactory.CreateRPSOption<OtherSupplierChildDialogView>( "a590a497-d5a6-4c4d-a539-b94d256dd00a","","",this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<OtherSupplierChildDialogView>("c61ead3e-3caf-4d08-a6ac-e0ff8781ae2a","","",false, this);
 
            Manual1 = RPSControlFactory.CreateRPSOption<OtherSupplierChildDialogView>( "f5b2eb7d-2b69-4176-95a8-67baa7d6f804","","",this);
 
            One1 = RPSControlFactory.CreateRPSOption<OtherSupplierChildDialogView>( "a580980d-aa3b-4008-b28e-f7d3b9c7eef7","","",this);
 
            IDSupplierMiscellaneous = RPSControlFactory.CreateRPSComboBox<OtherSupplierChildDialogView>("995516ab-d5bc-4829-9db8-c7d7f6275473","","",false, this);
 

        }
        public IRPSOption<OtherSupplierChildDialogView> Manual { get; set; } 
        public IRPSOption<OtherSupplierChildDialogView> One { get; set; } 
        public IRPSComboBox<OtherSupplierChildDialogView> IDSupplier { get; set; } 
        public IRPSOption<OtherSupplierChildDialogView> Manual1 { get; set; } 
        public IRPSOption<OtherSupplierChildDialogView> One1 { get; set; } 
        public IRPSComboBox<OtherSupplierChildDialogView> IDSupplierMiscellaneous { get; set; } 
        public VoucherTemplate Screen { get; set; }
        public OtherSupplierChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FixedAssetChildDialogView : View
    {
        public FixedAssetChildDialogView(VoucherTemplate screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Manual = RPSControlFactory.CreateRPSOption<FixedAssetChildDialogView>( "8974c2e7-854b-4e39-afd6-b7ee6659dfc6","","",this);
 
            One = RPSControlFactory.CreateRPSOption<FixedAssetChildDialogView>( "45893afa-9822-4f99-8f20-ea00fb36246c","","",this);
 
            IDFixedAsset = RPSControlFactory.CreateRPSComboBox<FixedAssetChildDialogView>("cb5caa50-77db-41b1-87af-320963e0db54","","",false, this);
 

        }
        public IRPSOption<FixedAssetChildDialogView> Manual { get; set; } 
        public IRPSOption<FixedAssetChildDialogView> One { get; set; } 
        public IRPSComboBox<FixedAssetChildDialogView> IDFixedAsset { get; set; } 
        public VoucherTemplate Screen { get; set; }
        public FixedAssetChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}