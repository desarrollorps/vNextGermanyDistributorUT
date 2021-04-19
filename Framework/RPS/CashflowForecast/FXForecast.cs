    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.CashflowForecast.FXForecast
{
    //RPS VERSION 1.0.0.0
    public partial class FXForecast:Screen
    {
        public FXForecast():base()
        {
            this.URL = "cashflowforecast.fxforecast";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            FXForecastCollectionView  = new FXForecastCollectionView(this); 
            FXForecastEntityView  = new FXForecastEntityView(this); 
            FXForecastCopyChildDialogView  = new FXForecastCopyChildDialogView(this); 
            FXForecastCollectionView.InitializeControls(); 
            FXForecastEntityView.InitializeControls(); 
            FXForecastCopyChildDialogView.InitializeControls(); 
           
        }
      
            public FXForecastCollectionView FXForecastCollectionView {get; set; } 
            public FXForecastEntityView FXForecastEntityView {get; set; } 
            public FXForecastCopyChildDialogView FXForecastCopyChildDialogView {get; set; } 
    }
            
    public partial class FXForecastCollectionView : View
    {
        public FXForecastCollectionView(FXForecast screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<FXForecastCollectionView,FXForecastEntityView>( this,Screen.FXForecastEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "d737d6e0-5ee9-4e0b-b223-8d06629b0bf3",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<FXForecastCollectionView,FXForecastEntityView>( params_MainConsult,this,Screen.FXForecastEntityView);
 

        }
        public IRPSButton<FXForecastCollectionView,FXForecastEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<FXForecastCollectionView,FXForecastEntityView> MainConsult { get; set; } 
        public FXForecast Screen { get; set; }
        public FXForecastCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FXForecastEntityView : View
    {
        public FXForecastEntityView(FXForecast screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<FXForecastEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<FXForecastEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FXForecastEntityView,FXForecastCollectionView>( this,Screen.FXForecastCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<FXForecastEntityView,FXForecastCollectionView>( this,Screen.FXForecastCollectionView);
 
            CodFXForecast = RPSControlFactory.CreateRPSTextBox<FXForecastEntityView>("26dac23b-9629-4ee0-952b-5f8e9ca04deb","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<FXForecastEntityView>("219470bc-8ede-47d8-ba5a-5d731e1a4842","","",false, this);
 
            LastDataDate = RPSControlFactory.CreateRPSTextBox<FXForecastEntityView>("bc9e94e6-e21c-4853-a033-730e0dc99f00","","",false, this);
 
            UseAccountDeposit = RPSControlFactory.CreateRPSCheckBox<FXForecastEntityView>("f0527efb-5f26-4a96-a351-865199539904","","",true, this);
 
            AllAcountDeposit = RPSControlFactory.CreateRPSCheckBox<FXForecastEntityView>("735b2dea-6a7b-4d48-8325-db8f986c413f","","",false, this);
 
            UseARPCustomer = RPSControlFactory.CreateRPSCheckBox<FXForecastEntityView>("323a2c18-5fa9-461c-8a71-84337f5afdb2","","",true, this);
 
            CodConceptARPCustomer = RPSControlFactory.CreateRPSComboBox<FXForecastEntityView>("74cacb55-9fad-47e0-8c73-e434cc681374","","",false, this);
 
            UseARPSupplier = RPSControlFactory.CreateRPSCheckBox<FXForecastEntityView>("be6a36b1-0a3f-4e0f-8ea2-2ba1c7222354","","",true, this);
 
            CodConceptARPSupplier = RPSControlFactory.CreateRPSComboBox<FXForecastEntityView>("e97efda0-0513-48b5-8f33-c34e3c820164","","",false, this);
 
            UseGLMLeasing = RPSControlFactory.CreateRPSCheckBox<FXForecastEntityView>("ac12143e-a6e2-44ae-a294-35c04b964a16","","",true, this);
 
            CodConceptGLMLeasing = RPSControlFactory.CreateRPSComboBox<FXForecastEntityView>("da1024c6-1062-4728-9341-a5c626ba0e4c","","",false, this);
 
            UseSALQuotes = RPSControlFactory.CreateRPSCheckBox<FXForecastEntityView>("b17a26e1-a18b-40ad-a509-a7b32fc2acb1","","",true, this);
 
            CodConceptSALQuotes = RPSControlFactory.CreateRPSComboBox<FXForecastEntityView>("03e81414-7fa6-4748-ad3d-a502a56bd401","","",false, this);
 
            MinPercentageSALQuotes = RPSControlFactory.CreateRPSFormattedTextBox<FXForecastEntityView>("0d46709d-6523-4032-9d99-3da52de2f2da","","",true, this);
 
            UsePROSALQuoteSelected = RPSControlFactory.CreateRPSCheckBox<FXForecastEntityView>("b5c2dce9-68d7-4ea7-981c-e410b326e59c","","",true, this);
 
            UseSALOrders = RPSControlFactory.CreateRPSCheckBox<FXForecastEntityView>("702e450d-ebeb-43f3-b3c0-f9cc0a102645","","",true, this);
 
            CodConceptSALOrders = RPSControlFactory.CreateRPSComboBox<FXForecastEntityView>("41c7777d-15f7-42c7-a2b5-5a32624a7a53","","",false, this);
 
            UseMANContractCustomer = RPSControlFactory.CreateRPSCheckBox<FXForecastEntityView>("c9fb1b62-242e-4d10-83c1-732af4e8f9cd","","",true, this);
 
            CodConceptMANContractCustomer = RPSControlFactory.CreateRPSComboBox<FXForecastEntityView>("659f4215-63fb-46d2-8b86-96c34d1a8db6","","",false, this);
 
            UseSALDeliveryNotes = RPSControlFactory.CreateRPSCheckBox<FXForecastEntityView>("3bd5679c-83c7-46ae-9877-3c1f56989fb2","","",true, this);
 
            CodConceptSALDeliveryNotes = RPSControlFactory.CreateRPSComboBox<FXForecastEntityView>("55471994-0ab3-447d-9e36-d0148c75af7f","","",false, this);
 
            UsePURProposals = RPSControlFactory.CreateRPSCheckBox<FXForecastEntityView>("6feaf495-a88a-45c7-a284-043064e7d603","","",true, this);
 
            CodConceptPURProposals = RPSControlFactory.CreateRPSComboBox<FXForecastEntityView>("df7e0ed1-4e5d-4ec3-ad1e-af98fac8f966","","",false, this);
 
            UsePURUnvalidatedProposals = RPSControlFactory.CreateRPSCheckBox<FXForecastEntityView>("5102a1ae-e97c-4c58-8113-078645bfb92a","","",true, this);
 
            UsePUROrders = RPSControlFactory.CreateRPSCheckBox<FXForecastEntityView>("5a958a0a-c0c2-4b98-8697-116357ba84fe","","",true, this);
 
            CodConceptPUROrders = RPSControlFactory.CreateRPSComboBox<FXForecastEntityView>("b213b0ee-9651-4f83-b3fa-6b0f8b15ac29","","",false, this);
 
            UseMANContractSupplier = RPSControlFactory.CreateRPSCheckBox<FXForecastEntityView>("d9ea85c2-e0b7-4384-a942-8fc77e3b743e","","",true, this);
 
            CodConceptMANContractSupplier = RPSControlFactory.CreateRPSComboBox<FXForecastEntityView>("27882fe4-0b91-462e-a285-1e46334629f6","","",false, this);
 
            UsePURDeliveryNotes = RPSControlFactory.CreateRPSCheckBox<FXForecastEntityView>("56dc1189-d7bd-4849-8b21-2250d8a6f7b1","","",true, this);
 
            CodConceptPURDeliveryNotes = RPSControlFactory.CreateRPSComboBox<FXForecastEntityView>("c66c2322-f196-4c86-a872-521252473d83","","",false, this);
 
            UsePROProjects = RPSControlFactory.CreateRPSCheckBox<FXForecastEntityView>("2b4c5614-7b9e-48fd-b450-045ad6dc6027","","",true, this);
 
            CodConceptPROProjects = RPSControlFactory.CreateRPSComboBox<FXForecastEntityView>("ea625537-9cd3-408b-8549-b63c59d6aea0","","",false, this);
 
            UsePROFinalProjects = RPSControlFactory.CreateRPSCheckBox<FXForecastEntityView>("4a8647dd-7825-42f6-8c37-f6096516c1c0","","",true, this);
 
            PROTypeCost = RPSControlFactory.CreateRPSEnumComboBox<FXForecastEntityView>("79656e8f-2afb-4473-9359-a2006196a07e","","",true, this);
 
            UsePROCostComponents = RPSControlFactory.CreateRPSCheckBox<FXForecastEntityView>("545824f3-eb1c-485d-af08-a38176e0f4fa","","",true, this);
 
            UsePROProvisionTypeStock = RPSControlFactory.CreateRPSCheckBox<FXForecastEntityView>("e48fb535-fcdb-433f-aeeb-6f040b0f6621","","",false, this);
 
            UsePACSalesPrevisions = RPSControlFactory.CreateRPSCheckBox<FXForecastEntityView>("5498d0b4-da7a-4de6-be2b-dc1ccacdf09a","","",true, this);
 
            CodConceptPACSalesPrevision = RPSControlFactory.CreateRPSComboBox<FXForecastEntityView>("b5557dce-b7a5-4cc7-a13a-2bcde04fd5a7","","",false, this);
 
            IDScene = RPSControlFactory.CreateRPSComboBox<FXForecastEntityView>("8e13757e-9ada-42a1-9582-3ea9c1c88222","","",false, this);
 
            IDPriceList = RPSControlFactory.CreateRPSComboBox<FXForecastEntityView>("5c37dec5-12bf-48e5-a323-bd53782ffa1b","","",false, this);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSComboBox<FXForecastEntityView>("104b6ef5-2e01-46ca-95c1-a88388496e5b","","",false, this);
 
            IDPaymentMethodSL = RPSControlFactory.CreateRPSComboBox<FXForecastEntityView>("159a40dd-4452-4792-8c19-f26c24617476","","",false, this);
 
            TaxPercentagePUR = RPSControlFactory.CreateRPSFormattedTextBox<FXForecastEntityView>("9e2ec738-cc21-40b4-a4be-461a187d4129","","",true, this);
 
            TaxPercentageSAL = RPSControlFactory.CreateRPSFormattedTextBox<FXForecastEntityView>("da53024e-d86f-4cbe-921f-f35ea358c01d","","",true, this);
 
            AvgInvoiceDaysPUR = RPSControlFactory.CreateRPSFormattedTextBox<FXForecastEntityView>("36da3778-a242-45c6-87ef-e5fd9fac883e","","",true, this);
 
            AvgInvoiceDaysSAL = RPSControlFactory.CreateRPSFormattedTextBox<FXForecastEntityView>("532452c8-5704-468b-a112-98964ac9a4ab","","",true, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<FXForecastEntityView>("0dd43d35-26a6-474b-b565-6120f1696fd6","","",false, this);
 
            ExecuteComputeFXForecastButton = RPSControlFactory.CreateRPSButton<FXForecastEntityView>( "70e78484-df93-49de-bd71-97c94e248735","","",this);
 
            FXForecastCopyChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<FXForecastEntityView,FXForecastCopyChildDialogView>("979f08d4-b375-41e6-908d-faac4cf07fa9","","", this,Screen.FXForecastCopyChildDialogView);
 
            CollectionInit params_FXForecastIncludes = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6caa9f97-b550-4cd1-aaa9-362f39f486ed",CSSSelectorGrid="",XPathGrid=""};
            FXForecastIncludes = RPSControlFactory.RPSCreateCollectionWithGrid<FXForecastIncludesCollectionEditor<FXForecastEntityView,FXForecastCopyChildDialogView>,FXForecastEntityView,FXForecastCopyChildDialogView>( params_FXForecastIncludes,this,Screen.FXForecastCopyChildDialogView);
 
            CollectionInit params_FXForecastExcludes = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8eabb1dd-1fbc-4110-ba7e-9f255a6fa557",CSSSelectorGrid="",XPathGrid=""};
            FXForecastExcludes = RPSControlFactory.RPSCreateCollectionWithGrid<FXForecastExcludesCollectionEditor<FXForecastEntityView,FXForecastCopyChildDialogView>,FXForecastEntityView,FXForecastCopyChildDialogView>( params_FXForecastExcludes,this,Screen.FXForecastCopyChildDialogView);
 
            CollectionInit params_FXForecastAccounts = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="eb4065f2-c5f5-4f39-b95b-40d8b401f0bf",CSSSelectorGrid="",XPathGrid=""};
            FXForecastAccounts = RPSControlFactory.RPSCreateCollectionWithGrid<FXForecastAccountsCollectionEditor<FXForecastEntityView,FXForecastCopyChildDialogView>,FXForecastEntityView,FXForecastCopyChildDialogView>( params_FXForecastAccounts,this,Screen.FXForecastCopyChildDialogView);
 
            SectionGeneralData = RPSControlFactory.CreateRPSSection<FXForecastEntityView>( "","ul li[rpsid='f77b96b6-3691-46ea-b6ca-efefe215165f']","",this);
 
            SectionConfiguration = RPSControlFactory.CreateRPSSection<FXForecastEntityView>( "","ul li[rpsid='8caf0592-cba4-4669-a0f3-b73e530aee29']","",this);
 
            SectionIEManual = RPSControlFactory.CreateRPSSection<FXForecastEntityView>( "","ul li[rpsid='72598521-a2f1-489e-9190-fbf3cdb72450']","",this);
 
            SectionAccountDeposit = RPSControlFactory.CreateRPSSection<FXForecastEntityView>( "","ul li[rpsid='1f162858-471d-41a8-9b52-195c40352c11']","",this);
 
            SectionComment = RPSControlFactory.CreateRPSSection<FXForecastEntityView>( "","ul li[rpsid='7b7853c9-b342-49c2-a189-ed547af080d4']","",this);
 

        }
        public IRPSSaveButton<FXForecastEntityView> SaveButton { get; set; } 
        public IRPSButton<FXForecastEntityView> DeleteButton { get; set; } 
        public IRPSButton<FXForecastEntityView,FXForecastCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FXForecastEntityView,FXForecastCollectionView> BackButton { get; set; } 
        public IRPSTextBox<FXForecastEntityView> CodFXForecast { get; set; } 
        public IRPSTextBox<FXForecastEntityView> Description { get; set; } 
        public IRPSTextBox<FXForecastEntityView> LastDataDate { get; set; } 
        public IRPSCheckbox<FXForecastEntityView> UseAccountDeposit { get; set; } 
        public IRPSCheckbox<FXForecastEntityView> AllAcountDeposit { get; set; } 
        public IRPSCheckbox<FXForecastEntityView> UseARPCustomer { get; set; } 
        public IRPSComboBox<FXForecastEntityView> CodConceptARPCustomer { get; set; } 
        public IRPSCheckbox<FXForecastEntityView> UseARPSupplier { get; set; } 
        public IRPSComboBox<FXForecastEntityView> CodConceptARPSupplier { get; set; } 
        public IRPSCheckbox<FXForecastEntityView> UseGLMLeasing { get; set; } 
        public IRPSComboBox<FXForecastEntityView> CodConceptGLMLeasing { get; set; } 
        public IRPSCheckbox<FXForecastEntityView> UseSALQuotes { get; set; } 
        public IRPSComboBox<FXForecastEntityView> CodConceptSALQuotes { get; set; } 
        public IRPSTextBox<FXForecastEntityView> MinPercentageSALQuotes { get; set; } 
        public IRPSCheckbox<FXForecastEntityView> UsePROSALQuoteSelected { get; set; } 
        public IRPSCheckbox<FXForecastEntityView> UseSALOrders { get; set; } 
        public IRPSComboBox<FXForecastEntityView> CodConceptSALOrders { get; set; } 
        public IRPSCheckbox<FXForecastEntityView> UseMANContractCustomer { get; set; } 
        public IRPSComboBox<FXForecastEntityView> CodConceptMANContractCustomer { get; set; } 
        public IRPSCheckbox<FXForecastEntityView> UseSALDeliveryNotes { get; set; } 
        public IRPSComboBox<FXForecastEntityView> CodConceptSALDeliveryNotes { get; set; } 
        public IRPSCheckbox<FXForecastEntityView> UsePURProposals { get; set; } 
        public IRPSComboBox<FXForecastEntityView> CodConceptPURProposals { get; set; } 
        public IRPSCheckbox<FXForecastEntityView> UsePURUnvalidatedProposals { get; set; } 
        public IRPSCheckbox<FXForecastEntityView> UsePUROrders { get; set; } 
        public IRPSComboBox<FXForecastEntityView> CodConceptPUROrders { get; set; } 
        public IRPSCheckbox<FXForecastEntityView> UseMANContractSupplier { get; set; } 
        public IRPSComboBox<FXForecastEntityView> CodConceptMANContractSupplier { get; set; } 
        public IRPSCheckbox<FXForecastEntityView> UsePURDeliveryNotes { get; set; } 
        public IRPSComboBox<FXForecastEntityView> CodConceptPURDeliveryNotes { get; set; } 
        public IRPSCheckbox<FXForecastEntityView> UsePROProjects { get; set; } 
        public IRPSComboBox<FXForecastEntityView> CodConceptPROProjects { get; set; } 
        public IRPSCheckbox<FXForecastEntityView> UsePROFinalProjects { get; set; } 
        public IRPSComboBox<FXForecastEntityView> PROTypeCost { get; set; } 
        public IRPSCheckbox<FXForecastEntityView> UsePROCostComponents { get; set; } 
        public IRPSCheckbox<FXForecastEntityView> UsePROProvisionTypeStock { get; set; } 
        public IRPSCheckbox<FXForecastEntityView> UsePACSalesPrevisions { get; set; } 
        public IRPSComboBox<FXForecastEntityView> CodConceptPACSalesPrevision { get; set; } 
        public IRPSComboBox<FXForecastEntityView> IDScene { get; set; } 
        public IRPSComboBox<FXForecastEntityView> IDPriceList { get; set; } 
        public IRPSComboBox<FXForecastEntityView> IDPaymentMethod { get; set; } 
        public IRPSComboBox<FXForecastEntityView> IDPaymentMethodSL { get; set; } 
        public IRPSTextBox<FXForecastEntityView> TaxPercentagePUR { get; set; } 
        public IRPSTextBox<FXForecastEntityView> TaxPercentageSAL { get; set; } 
        public IRPSTextBox<FXForecastEntityView> AvgInvoiceDaysPUR { get; set; } 
        public IRPSTextBox<FXForecastEntityView> AvgInvoiceDaysSAL { get; set; } 
        public IRPSTextBox<FXForecastEntityView> Comment { get; set; } 
        public IRPSButton<FXForecastEntityView> ExecuteComputeFXForecastButton { get; set; } 
        public IRPSButton<FXForecastEntityView,FXForecastCopyChildDialogView> FXForecastCopyChildNavigationCommandButton { get; set; } 
        public FXForecastIncludesCollectionEditor<FXForecastEntityView,FXForecastCopyChildDialogView> FXForecastIncludes { get; set; } 
        public FXForecastExcludesCollectionEditor<FXForecastEntityView,FXForecastCopyChildDialogView> FXForecastExcludes { get; set; } 
        public FXForecastAccountsCollectionEditor<FXForecastEntityView,FXForecastCopyChildDialogView> FXForecastAccounts { get; set; } 
        public IRPSSection<FXForecastEntityView> SectionGeneralData { get; set; } 
        public IRPSSection<FXForecastEntityView> SectionConfiguration { get; set; } 
        public IRPSSection<FXForecastEntityView> SectionIEManual { get; set; } 
        public IRPSSection<FXForecastEntityView> SectionAccountDeposit { get; set; } 
        public IRPSSection<FXForecastEntityView> SectionComment { get; set; } 
        public FXForecast Screen { get; set; }
        public FXForecastEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class FXForecastIncludesCollectionEditor<FXForecastEntityView,FXForecastCopyChildDialogView>:RPSCollectionEditor<FXForecastEntityView,FXForecastCopyChildDialogView> where FXForecastEntityView : class, IView where FXForecastCopyChildDialogView : class, IView
    {
        public  FXForecastIncludesGridView<FXForecastEntityView,FXForecastCopyChildDialogView> GridView {get;set;}
    }
    public partial class FXForecastIncludesGridView <FXForecastEntityView,FXForecastCopyChildDialogView> :  RPSGridView<FXForecastEntityView,FXForecastCopyChildDialogView> where FXForecastEntityView : class, IView where FXForecastCopyChildDialogView : class, IView
    {
        public FXForecastIncludesGridView(FXForecastEntityView currentView,FXForecastCopyChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDFXIEManual = RPSControlFactory.CreateRPSGridComboBox<FXForecastEntityView>("","#6caa9f97-b550-4cd1-aaa9-362f39f486ed .ag-row[role='row']@ROWINDEX [col-id='cIDFXIEManual']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<FXForecastEntityView> IDFXIEManual { get; set; } 
                     
    }
 
        public partial class FXForecastExcludesCollectionEditor<FXForecastEntityView,FXForecastCopyChildDialogView>:RPSCollectionEditor<FXForecastEntityView,FXForecastCopyChildDialogView> where FXForecastEntityView : class, IView where FXForecastCopyChildDialogView : class, IView
    {
        public  FXForecastExcludesGridView<FXForecastEntityView,FXForecastCopyChildDialogView> GridView {get;set;}
    }
    public partial class FXForecastExcludesGridView <FXForecastEntityView,FXForecastCopyChildDialogView> :  RPSGridView<FXForecastEntityView,FXForecastCopyChildDialogView> where FXForecastEntityView : class, IView where FXForecastCopyChildDialogView : class, IView
    {
        public FXForecastExcludesGridView(FXForecastEntityView currentView,FXForecastCopyChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDFXIEManual = RPSControlFactory.CreateRPSGridComboBox<FXForecastEntityView>("","#8eabb1dd-1fbc-4110-ba7e-9f255a6fa557 .ag-row[role='row']@ROWINDEX [col-id='cIDFXIEManual']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<FXForecastEntityView> IDFXIEManual { get; set; } 
                     
    }
 
        public partial class FXForecastAccountsCollectionEditor<FXForecastEntityView,FXForecastCopyChildDialogView>:RPSCollectionEditor<FXForecastEntityView,FXForecastCopyChildDialogView> where FXForecastEntityView : class, IView where FXForecastCopyChildDialogView : class, IView
    {
        public  FXForecastAccountsGridView<FXForecastEntityView,FXForecastCopyChildDialogView> GridView {get;set;}
    }
    public partial class FXForecastAccountsGridView <FXForecastEntityView,FXForecastCopyChildDialogView> :  RPSGridView<FXForecastEntityView,FXForecastCopyChildDialogView> where FXForecastEntityView : class, IView where FXForecastCopyChildDialogView : class, IView
    {
        public FXForecastAccountsGridView(FXForecastEntityView currentView,FXForecastCopyChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDAccount = RPSControlFactory.CreateRPSGridComboBox<FXForecastEntityView>("","#eb4065f2-c5f5-4f39-b95b-40d8b401f0bf .ag-row[role='row']@ROWINDEX [col-id='cIDAccount']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<FXForecastEntityView> IDAccount { get; set; } 
                     
    }
 
    }
  
            
    public partial class FXForecastCopyChildDialogView : View
    {
        public FXForecastCopyChildDialogView(FXForecast screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewCodFXForecast = RPSControlFactory.CreateRPSTextBox<FXForecastCopyChildDialogView>("f642d340-5b09-474a-ab8b-3f64ed8e740b","","",false, this);
 
            NewDescription = RPSControlFactory.CreateRPSTextBox<FXForecastCopyChildDialogView>("c8445785-2b08-46a3-86b6-57334348de82","","",false, this);
 

        }
        public IRPSTextBox<FXForecastCopyChildDialogView> NewCodFXForecast { get; set; } 
        public IRPSTextBox<FXForecastCopyChildDialogView> NewDescription { get; set; } 
        public FXForecast Screen { get; set; }
        public FXForecastCopyChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}