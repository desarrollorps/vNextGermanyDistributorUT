    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.TaxModel.SIIPurchaseInvoice
{
    //RPS VERSION 1.0.0.0
    public partial class SIIPurchaseInvoice:Screen
    {
        public SIIPurchaseInvoice():base()
        {
            this.URL = "taxmodel.siipurchaseinvoice";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            TaxPurchaseInvoiceVMQueryView  = new TaxPurchaseInvoiceVMQueryView(this); 
            TaxPurchaseInvoiceVMEntityView  = new TaxPurchaseInvoiceVMEntityView(this); 
            SIIPurchaseInvoiceSendDialogView  = new SIIPurchaseInvoiceSendDialogView(this); 
            TaxPurchaseInvoiceVMQueryView.InitializeControls(); 
            TaxPurchaseInvoiceVMEntityView.InitializeControls(); 
            SIIPurchaseInvoiceSendDialogView.InitializeControls(); 
           
        }
      
            public TaxPurchaseInvoiceVMQueryView TaxPurchaseInvoiceVMQueryView {get; set; } 
            public TaxPurchaseInvoiceVMEntityView TaxPurchaseInvoiceVMEntityView {get; set; } 
            public SIIPurchaseInvoiceSendDialogView SIIPurchaseInvoiceSendDialogView {get; set; } 
    }
            
    public partial class TaxPurchaseInvoiceVMQueryView : View
    {
        public TaxPurchaseInvoiceVMQueryView(SIIPurchaseInvoice screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<TaxPurchaseInvoiceVMQueryView,TaxPurchaseInvoiceVMEntityView>( this,Screen.TaxPurchaseInvoiceVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<TaxPurchaseInvoiceVMQueryView>( this);
 
            DeclarationYear = RPSControlFactory.CreateRPSFormattedTextBox<TaxPurchaseInvoiceVMQueryView>("9c83d4e5-3480-4d9a-9407-4661128191d1","","",false, this);
 
            eMonth = RPSControlFactory.CreateRPSEnumComboBox<TaxPurchaseInvoiceVMQueryView>("a1f68560-7f41-49d5-97cd-348104c36983","","",false, this);
 
            AccountingDateFrom = RPSControlFactory.CreateRPSTextBox<TaxPurchaseInvoiceVMQueryView>("d5e71dfd-3568-42e2-aaae-c8a2c5aa3b06","","",false, this);
 
            AccountingDateTo = RPSControlFactory.CreateRPSTextBox<TaxPurchaseInvoiceVMQueryView>("055c81cf-70d8-4425-a843-156ee7dbccdf","","",false, this);
 
            InvoiceDateFrom = RPSControlFactory.CreateRPSTextBox<TaxPurchaseInvoiceVMQueryView>("1451fa03-503f-441f-8a1d-ac323951368d","","",false, this);
 
            InvoiceDateTo = RPSControlFactory.CreateRPSTextBox<TaxPurchaseInvoiceVMQueryView>("cfde2e51-e9ae-4527-a3c0-e38732573ec7","","",false, this);
 
            RegistrationDateFrom = RPSControlFactory.CreateRPSTextBox<TaxPurchaseInvoiceVMQueryView>("6a1296a4-b5db-4d56-adbb-fa33c3de751b","","",false, this);
 
            RegistrationDateTo = RPSControlFactory.CreateRPSTextBox<TaxPurchaseInvoiceVMQueryView>("4fc06ce1-af4b-42b2-a0ff-8af215e48755","","",false, this);
 
            FrozenInvoices = RPSControlFactory.CreateRPSCheckBox<TaxPurchaseInvoiceVMQueryView>("70f6cac5-a6fa-4c7f-ae85-9541359c3c7f","","",false, this);
 
            Sent = RPSControlFactory.CreateRPSCheckBox<TaxPurchaseInvoiceVMQueryView>("77fecdc8-d214-4650-b1ec-e83cdc11f43f","","",false, this);
 
            PendingCorrection = RPSControlFactory.CreateRPSCheckBox<TaxPurchaseInvoiceVMQueryView>("0bf5b416-4d0e-428e-ad7f-36f450ef3ee0","","",false, this);
 
            ToBeCreated = RPSControlFactory.CreateRPSCheckBox<TaxPurchaseInvoiceVMQueryView>("185004d9-2bb3-46c4-8a0d-5790e49454e6","","",false, this);
 
            ToBeChanged = RPSControlFactory.CreateRPSCheckBox<TaxPurchaseInvoiceVMQueryView>("abaabd53-6d42-4959-87aa-3f62722433f9","","",false, this);
 
            ToBeDeleted = RPSControlFactory.CreateRPSCheckBox<TaxPurchaseInvoiceVMQueryView>("6183d92d-0342-44f1-afdc-168db6699cb6","","",false, this);
 
            NoSend = RPSControlFactory.CreateRPSCheckBox<TaxPurchaseInvoiceVMQueryView>("f86c3234-ab7a-4b63-9bac-74d129e542c4","","",false, this);
 
            Deleted = RPSControlFactory.CreateRPSCheckBox<TaxPurchaseInvoiceVMQueryView>("75afb827-9080-4fbf-87c1-4a7f44829062","","",false, this);
 
            SIILoadDataBeforeCommandButton = RPSControlFactory.CreateRPSButton<TaxPurchaseInvoiceVMQueryView>( "f63e2cee-ecee-4f3c-9e74-70bf6db65324","","",this);
 
            SIIPurchaseInvoiceSendNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<TaxPurchaseInvoiceVMQueryView,SIIPurchaseInvoiceSendDialogView>("3b45ff83-4a8f-4f73-801a-6aaf95869f95","","", this,Screen.SIIPurchaseInvoiceSendDialogView);
 
            IncludePurchaseInvoiceCommandButton = RPSControlFactory.CreateRPSButton<TaxPurchaseInvoiceVMQueryView>( "e55da214-a504-4824-b7eb-43138ea53d7c","","",this);
 
            ExcludePurchaseInvoiceCommandButton = RPSControlFactory.CreateRPSButton<TaxPurchaseInvoiceVMQueryView>( "d3e70bf2-35c5-42dd-890f-6636341da97e","","",this);
 
            SendOKPurchaseInvoiceCommandButton = RPSControlFactory.CreateRPSButton<TaxPurchaseInvoiceVMQueryView>( "19b7b15d-5ec8-4a21-9195-6b9d482f67bd","","",this);
 
            DeleteOKPurchaseInvoiceCommandButton = RPSControlFactory.CreateRPSButton<TaxPurchaseInvoiceVMQueryView>( "b01f154d-cfbf-4a52-a81c-ad9d5f95d23a","","",this);
 
            ReplacePurchaseInvoiceCommandButton = RPSControlFactory.CreateRPSButton<TaxPurchaseInvoiceVMQueryView>( "3c93a8b3-cc0e-4a6e-94f6-ac01156de397","","",this);
 
            ChangeDeclarationPeriodCommandButton = RPSControlFactory.CreateRPSButton<TaxPurchaseInvoiceVMQueryView>( "6aced86d-a2be-4370-8e70-2e0a775136f1","","",this);
 
            DeleteInvoiceCommandButton = RPSControlFactory.CreateRPSButton<TaxPurchaseInvoiceVMQueryView>( "f789832f-5ea4-4216-888e-5fc2c67d78ff","","",this);
 
            FreezeListTaxPurchaseInvoicesCommandButton = RPSControlFactory.CreateRPSButton<TaxPurchaseInvoiceVMQueryView>( "807a9e28-e55e-4e74-9fe2-39982751c95e","","",this);
 
            CollectionInit params_SIIPurchaseInvoice = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c39d0a6e-2dc7-41f2-9795-16a37a75a5ac",CSSSelectorGrid="",XPathGrid=""};
            SIIPurchaseInvoice = RPSControlFactory.RPSCreateCollectionWithGrid<SIIPurchaseInvoiceCollectionEditor<TaxPurchaseInvoiceVMQueryView,TaxPurchaseInvoiceVMEntityView>,TaxPurchaseInvoiceVMQueryView,TaxPurchaseInvoiceVMEntityView>( params_SIIPurchaseInvoice,this,Screen.TaxPurchaseInvoiceVMEntityView);
 

        }
        public IRPSButton<TaxPurchaseInvoiceVMQueryView,TaxPurchaseInvoiceVMEntityView> NewButton { get; set; } 
        public IRPSButton<TaxPurchaseInvoiceVMQueryView> ConsultButton { get; set; } 
        public IRPSTextBox<TaxPurchaseInvoiceVMQueryView> DeclarationYear { get; set; } 
        public IRPSComboBox<TaxPurchaseInvoiceVMQueryView> eMonth { get; set; } 
        public IRPSTextBox<TaxPurchaseInvoiceVMQueryView> AccountingDateFrom { get; set; } 
        public IRPSTextBox<TaxPurchaseInvoiceVMQueryView> AccountingDateTo { get; set; } 
        public IRPSTextBox<TaxPurchaseInvoiceVMQueryView> InvoiceDateFrom { get; set; } 
        public IRPSTextBox<TaxPurchaseInvoiceVMQueryView> InvoiceDateTo { get; set; } 
        public IRPSTextBox<TaxPurchaseInvoiceVMQueryView> RegistrationDateFrom { get; set; } 
        public IRPSTextBox<TaxPurchaseInvoiceVMQueryView> RegistrationDateTo { get; set; } 
        public IRPSCheckbox<TaxPurchaseInvoiceVMQueryView> FrozenInvoices { get; set; } 
        public IRPSCheckbox<TaxPurchaseInvoiceVMQueryView> Sent { get; set; } 
        public IRPSCheckbox<TaxPurchaseInvoiceVMQueryView> PendingCorrection { get; set; } 
        public IRPSCheckbox<TaxPurchaseInvoiceVMQueryView> ToBeCreated { get; set; } 
        public IRPSCheckbox<TaxPurchaseInvoiceVMQueryView> ToBeChanged { get; set; } 
        public IRPSCheckbox<TaxPurchaseInvoiceVMQueryView> ToBeDeleted { get; set; } 
        public IRPSCheckbox<TaxPurchaseInvoiceVMQueryView> NoSend { get; set; } 
        public IRPSCheckbox<TaxPurchaseInvoiceVMQueryView> Deleted { get; set; } 
        public IRPSButton<TaxPurchaseInvoiceVMQueryView> SIILoadDataBeforeCommandButton { get; set; } 
        public IRPSButton<TaxPurchaseInvoiceVMQueryView,SIIPurchaseInvoiceSendDialogView> SIIPurchaseInvoiceSendNavigationCommandButton { get; set; } 
        public IRPSButton<TaxPurchaseInvoiceVMQueryView> IncludePurchaseInvoiceCommandButton { get; set; } 
        public IRPSButton<TaxPurchaseInvoiceVMQueryView> ExcludePurchaseInvoiceCommandButton { get; set; } 
        public IRPSButton<TaxPurchaseInvoiceVMQueryView> SendOKPurchaseInvoiceCommandButton { get; set; } 
        public IRPSButton<TaxPurchaseInvoiceVMQueryView> DeleteOKPurchaseInvoiceCommandButton { get; set; } 
        public IRPSButton<TaxPurchaseInvoiceVMQueryView> ReplacePurchaseInvoiceCommandButton { get; set; } 
        public IRPSButton<TaxPurchaseInvoiceVMQueryView> ChangeDeclarationPeriodCommandButton { get; set; } 
        public IRPSButton<TaxPurchaseInvoiceVMQueryView> DeleteInvoiceCommandButton { get; set; } 
        public IRPSButton<TaxPurchaseInvoiceVMQueryView> FreezeListTaxPurchaseInvoicesCommandButton { get; set; } 
        public SIIPurchaseInvoiceCollectionEditor<TaxPurchaseInvoiceVMQueryView,TaxPurchaseInvoiceVMEntityView> SIIPurchaseInvoice { get; set; } 
        public SIIPurchaseInvoice Screen { get; set; }
        public TaxPurchaseInvoiceVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SIIPurchaseInvoiceCollectionEditor<TaxPurchaseInvoiceVMQueryView,TaxPurchaseInvoiceVMEntityView>:RPSCollectionEditor<TaxPurchaseInvoiceVMQueryView,TaxPurchaseInvoiceVMEntityView> where TaxPurchaseInvoiceVMQueryView : class, IView where TaxPurchaseInvoiceVMEntityView : class, IView
    {
        public  SIIPurchaseInvoiceGridView<TaxPurchaseInvoiceVMQueryView,TaxPurchaseInvoiceVMEntityView> GridView {get;set;}
    }
    public partial class SIIPurchaseInvoiceGridView <TaxPurchaseInvoiceVMQueryView,TaxPurchaseInvoiceVMEntityView> :  RPSGridView<TaxPurchaseInvoiceVMQueryView,TaxPurchaseInvoiceVMEntityView> where TaxPurchaseInvoiceVMQueryView : class, IView where TaxPurchaseInvoiceVMEntityView : class, IView
    {
        public SIIPurchaseInvoiceGridView(TaxPurchaseInvoiceVMQueryView currentView,TaxPurchaseInvoiceVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            TaxPurchaseInvoice_CodInvoice = RPSControlFactory.CreateRPSGridTextBox<TaxPurchaseInvoiceVMQueryView>("","#c39d0a6e-2dc7-41f2-9795-16a37a75a5ac .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchaseInvoice_CodInvoice']","",false, this.CurrentView);
 
            TaxPurchaseInvoice_InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<TaxPurchaseInvoiceVMQueryView>("","#c39d0a6e-2dc7-41f2-9795-16a37a75a5ac .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchaseInvoice_InvoiceDate']","",false, this.CurrentView);
 
            TaxPurchaseInvoice_ActionStatus = RPSControlFactory.CreateRPSGridTextBox<TaxPurchaseInvoiceVMQueryView>("","#c39d0a6e-2dc7-41f2-9795-16a37a75a5ac .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchaseInvoice_ActionStatus']","",false, this.CurrentView);
 
            TaxPurchaseInvoice_SupplierVATNumber = RPSControlFactory.CreateRPSGridTextBox<TaxPurchaseInvoiceVMQueryView>("","#c39d0a6e-2dc7-41f2-9795-16a37a75a5ac .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchaseInvoice_SupplierVATNumber']","",false, this.CurrentView);
 
            TaxPurchaseInvoice_CountryFrom = RPSControlFactory.CreateRPSGridTextBox<TaxPurchaseInvoiceVMQueryView>("","#c39d0a6e-2dc7-41f2-9795-16a37a75a5ac .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchaseInvoice_CountryFrom']","",false, this.CurrentView);
 
            TaxPurchaseInvoice_SupplierName = RPSControlFactory.CreateRPSGridTextBox<TaxPurchaseInvoiceVMQueryView>("","#c39d0a6e-2dc7-41f2-9795-16a37a75a5ac .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchaseInvoice_SupplierName']","",false, this.CurrentView);
 
            TaxPurchaseInvoice_AccountingDate = RPSControlFactory.CreateRPSGridTextBox<TaxPurchaseInvoiceVMQueryView>("","#c39d0a6e-2dc7-41f2-9795-16a37a75a5ac .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchaseInvoice_AccountingDate']","",false, this.CurrentView);
 
            TaxPurchaseInvoice_RegistrationDate = RPSControlFactory.CreateRPSGridTextBox<TaxPurchaseInvoiceVMQueryView>("","#c39d0a6e-2dc7-41f2-9795-16a37a75a5ac .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchaseInvoice_RegistrationDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<TaxPurchaseInvoiceVMQueryView> TaxPurchaseInvoice_CodInvoice { get; set; } 
        public IRPSGridTextBox<TaxPurchaseInvoiceVMQueryView> TaxPurchaseInvoice_InvoiceDate { get; set; } 
        public IRPSGridTextBox<TaxPurchaseInvoiceVMQueryView> TaxPurchaseInvoice_ActionStatus { get; set; } 
        public IRPSGridTextBox<TaxPurchaseInvoiceVMQueryView> TaxPurchaseInvoice_SupplierVATNumber { get; set; } 
        public IRPSGridTextBox<TaxPurchaseInvoiceVMQueryView> TaxPurchaseInvoice_CountryFrom { get; set; } 
        public IRPSGridTextBox<TaxPurchaseInvoiceVMQueryView> TaxPurchaseInvoice_SupplierName { get; set; } 
        public IRPSGridTextBox<TaxPurchaseInvoiceVMQueryView> TaxPurchaseInvoice_AccountingDate { get; set; } 
        public IRPSGridTextBox<TaxPurchaseInvoiceVMQueryView> TaxPurchaseInvoice_RegistrationDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class TaxPurchaseInvoiceVMEntityView : View
    {
        public TaxPurchaseInvoiceVMEntityView(SIIPurchaseInvoice screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<TaxPurchaseInvoiceVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<TaxPurchaseInvoiceVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<TaxPurchaseInvoiceVMEntityView,TaxPurchaseInvoiceVMQueryView>( this,Screen.TaxPurchaseInvoiceVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<TaxPurchaseInvoiceVMEntityView,TaxPurchaseInvoiceVMQueryView>( this,Screen.TaxPurchaseInvoiceVMQueryView);
 
            CodInvoice = RPSControlFactory.CreateRPSTextBox<TaxPurchaseInvoiceVMEntityView>("44c6f6a8-13fe-4a02-8568-46d45de389b9","","",true, this);
 
            InvoiceDate = RPSControlFactory.CreateRPSTextBox<TaxPurchaseInvoiceVMEntityView>("ca3ee5e7-24d3-401b-8af0-901dafe20322","","",true, this);
 
            RegistrationDate = RPSControlFactory.CreateRPSTextBox<TaxPurchaseInvoiceVMEntityView>("f453d6c8-9ee9-4328-82dc-2783f0a0ae06","","",true, this);
 
            OperationDate = RPSControlFactory.CreateRPSTextBox<TaxPurchaseInvoiceVMEntityView>("143ad30c-4b2d-418a-b986-8c508e9c2f1a","","",false, this);
 
            DeclarationYear = RPSControlFactory.CreateRPSFormattedTextBox<TaxPurchaseInvoiceVMEntityView>("f4f88e01-ad8d-43b4-8fae-ba361133ef56","","",true, this);
 
            DeclarationMonth = RPSControlFactory.CreateRPSEnumComboBox<TaxPurchaseInvoiceVMEntityView>("17b09ffa-4bc9-483d-90e7-0917d28ca430","","",true, this);
 
            SupplierName = RPSControlFactory.CreateRPSTextBox<TaxPurchaseInvoiceVMEntityView>("7346553f-5e96-4bd3-aaa9-94165740d547","","",true, this);
 
            SupplierCountry = RPSControlFactory.CreateRPSTextBox<TaxPurchaseInvoiceVMEntityView>("bbb08b8b-86b1-4310-af88-367efe9ba1a4","","",true, this);
 
            SupplierVATNumber = RPSControlFactory.CreateRPSTextBox<TaxPurchaseInvoiceVMEntityView>("0e51c725-c426-4c82-90c3-eb2386224ce1","","",false, this);
 
            ActionStatus = RPSControlFactory.CreateRPSEnumComboBox<TaxPurchaseInvoiceVMEntityView>("27a2db44-a3c0-473d-bea1-f6f4463b6232","","",true, this);
 
            LastModifiedTime = RPSControlFactory.CreateRPSTextBox<TaxPurchaseInvoiceVMEntityView>("84afd3f2-0f27-4a9d-952b-1315f4872aa8","","",false, this);
 
            SentTime = RPSControlFactory.CreateRPSTextBox<TaxPurchaseInvoiceVMEntityView>("73c9491c-0881-4a1d-b37b-b7988b315db9","","",false, this);
 
            Frozen = RPSControlFactory.CreateRPSCheckBox<TaxPurchaseInvoiceVMEntityView>("075f9b4f-f2ed-4c64-8e47-dad6d80dc178","","",true, this);
 
            CreatedStatus = RPSControlFactory.CreateRPSEnumComboBox<TaxPurchaseInvoiceVMEntityView>("42590ef8-b101-4e64-9c60-b2ef14569e69","","",true, this);
 
            ChangedStatus = RPSControlFactory.CreateRPSEnumComboBox<TaxPurchaseInvoiceVMEntityView>("50887d41-f6f8-4102-83ca-e5404730fda6","","",true, this);
 
            DeletedStatus = RPSControlFactory.CreateRPSEnumComboBox<TaxPurchaseInvoiceVMEntityView>("7a9590c6-ff25-4cbc-8d94-6d237cd88bc2","","",true, this);
 
            Deletion = RPSControlFactory.CreateRPSEnumComboBox<TaxPurchaseInvoiceVMEntityView>("df3f666e-c8e6-489f-9a72-328718a170be","","",true, this);
 
            ErrorInfo = RPSControlFactory.CreateRPSTextBox<TaxPurchaseInvoiceVMEntityView>("fc173c94-73b5-42ba-972e-21d0a3532ca7","","",false, this);
 
            OperationType = RPSControlFactory.CreateRPSTextBox<TaxPurchaseInvoiceVMEntityView>("ccc04e32-69a4-43ee-9796-322eea8cd666","","",false, this);
 
            IsDUA = RPSControlFactory.CreateRPSCheckBox<TaxPurchaseInvoiceVMEntityView>("3cf03732-ec0b-4a5b-b18d-0de3247a8415","","",true, this);
 
            IsATicket = RPSControlFactory.CreateRPSCheckBox<TaxPurchaseInvoiceVMEntityView>("2f0ca14c-f282-4bce-bf76-43f71b653314","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<TaxPurchaseInvoiceVMEntityView>("a8d78b7a-77a3-44d8-99f7-3facc3752ad2","","",true, this);
 
            IDACCTransactions = RPSControlFactory.CreateRPSComboBox<TaxPurchaseInvoiceVMEntityView>("0f1f9156-84b2-4c34-83d6-6f71d0886474","","",true, this);
 
            AccountingDate = RPSControlFactory.CreateRPSTextBox<TaxPurchaseInvoiceVMEntityView>("1f682338-ab33-4916-94db-97216b40d918","","",true, this);
 
            CountryFrom = RPSControlFactory.CreateRPSTextBox<TaxPurchaseInvoiceVMEntityView>("91c74244-c566-4f5c-9e20-b6907fcaec7b","","",true, this);
 
            CountryTo = RPSControlFactory.CreateRPSTextBox<TaxPurchaseInvoiceVMEntityView>("0942328e-9fb2-4560-a6b4-20aa70f7c9bf","","",true, this);
 
            VoucherType = RPSControlFactory.CreateRPSComboBox<TaxPurchaseInvoiceVMEntityView>("e57e62b5-6028-4f86-b405-348e7b4b8464","","",false, this);
 
            IsAmendment = RPSControlFactory.CreateRPSCheckBox<TaxPurchaseInvoiceVMEntityView>("b86a9d5b-4e44-46a9-b861-20dc978304e0","","",true, this);
 
            FromCodInvoice = RPSControlFactory.CreateRPSTextBox<TaxPurchaseInvoiceVMEntityView>("a02f95bc-e321-49f4-bdfd-31d6291f8887","","",false, this);
 
            FromInvoiceDate = RPSControlFactory.CreateRPSTextBox<TaxPurchaseInvoiceVMEntityView>("e2af41b6-5cc9-42ec-9f0d-00c155465e20","","",false, this);
 
            AmendmentType = RPSControlFactory.CreateRPSEnumComboBox<TaxPurchaseInvoiceVMEntityView>("9f22fa87-3900-4b88-89bd-a8e1fc92ce51","","",true, this);
 
            AutoInvoice = RPSControlFactory.CreateRPSCheckBox<TaxPurchaseInvoiceVMEntityView>("bedc530f-2167-4520-9eaf-c9cab41ddb05","","",true, this);
 
            CodEUInvoice = RPSControlFactory.CreateRPSTextBox<TaxPurchaseInvoiceVMEntityView>("0629eb69-c568-4a29-80c0-8925d049bd21","","",false, this);
 
            AutoInvoiceType = RPSControlFactory.CreateRPSEnumComboBox<TaxPurchaseInvoiceVMEntityView>("0f83482c-2384-49e0-a1ec-1d91b47b4467","","",true, this);
 
            DeductionLater = RPSControlFactory.CreateRPSCheckBox<TaxPurchaseInvoiceVMEntityView>("3232f02e-d0bf-45a3-bb77-c7194e2d67d1","","",false, this);
 
            DeductionYear = RPSControlFactory.CreateRPSFormattedTextBox<TaxPurchaseInvoiceVMEntityView>("6b8776e8-ab75-43b8-8f71-74da3f495256","","",false, this);
 
            DeductionMonth = RPSControlFactory.CreateRPSEnumComboBox<TaxPurchaseInvoiceVMEntityView>("45c79829-2e22-4596-8cbc-446a2fd57eb6","","",false, this);
 
            TotalBase = RPSControlFactory.CreateRPSFormattedTextBox<TaxPurchaseInvoiceVMEntityView>("9649bf97-9c66-49f1-b804-95712cd90197","","",true, this);
 
            TotalAmount = RPSControlFactory.CreateRPSFormattedTextBox<TaxPurchaseInvoiceVMEntityView>("cc2f3312-5e35-4023-9579-fa416b1beb0d","","",true, this);
 
            Total = RPSControlFactory.CreateRPSFormattedTextBox<TaxPurchaseInvoiceVMEntityView>("c676ee21-c463-4804-9437-085cc58dd9ec","","",true, this);
 
            TotalDedBase = RPSControlFactory.CreateRPSFormattedTextBox<TaxPurchaseInvoiceVMEntityView>("1b587d36-e934-4c12-a9dc-d17a5dc56121","","",true, this);
 
            TotalDedAmount = RPSControlFactory.CreateRPSFormattedTextBox<TaxPurchaseInvoiceVMEntityView>("d0edb200-021a-49dc-9b68-a3303c4b977b","","",true, this);
 
            IDACCTransactionsDetail = RPSControlFactory.CreateRPSComboBox<TaxPurchaseInvoiceVMEntityView>("a05eb2a7-9bff-4216-9d78-8eb622bdf39b","","",true, this);
 
            IDVAT = RPSControlFactory.CreateRPSComboBox<TaxPurchaseInvoiceVMEntityView>("87c43673-4e35-4dcf-a514-77a85a63a2da","","",false, this);
 
            Exclude = RPSControlFactory.CreateRPSCheckBox<TaxPurchaseInvoiceVMEntityView>("ab0718a0-5243-4299-bf0e-152cbba3060d","","",true, this);
 
            IsPending = RPSControlFactory.CreateRPSCheckBox<TaxPurchaseInvoiceVMEntityView>("8e051e3f-bdff-456a-a2d2-1fec42a8912b","","",true, this);
 
            IsSurchage = RPSControlFactory.CreateRPSCheckBox<TaxPurchaseInvoiceVMEntityView>("0f7d17c4-98e2-4fb8-9feb-6759a4506f12","","",true, this);
 
            VATBase = RPSControlFactory.CreateRPSFormattedTextBox<TaxPurchaseInvoiceVMEntityView>("86729a16-239a-4e63-9428-95d76cf3fe0c","","",true, this);
 
            VATPercentage = RPSControlFactory.CreateRPSFormattedTextBox<TaxPurchaseInvoiceVMEntityView>("ed08350d-c9eb-498b-b448-246e44aec51b","","",true, this);
 
            VATAmountTotal = RPSControlFactory.CreateRPSFormattedTextBox<TaxPurchaseInvoiceVMEntityView>("73c9c0d0-46ca-44f1-b605-65574842ec9b","","",true, this);
 
            SurchagePercentage = RPSControlFactory.CreateRPSFormattedTextBox<TaxPurchaseInvoiceVMEntityView>("9eeea1a0-7627-4c17-8eab-aa2c4f9620ec","","",true, this);
 
            SurchageAmount = RPSControlFactory.CreateRPSFormattedTextBox<TaxPurchaseInvoiceVMEntityView>("dab57274-80f0-423c-83ac-b1157dc6f145","","",true, this);
 
            PercentDeductible = RPSControlFactory.CreateRPSFormattedTextBox<TaxPurchaseInvoiceVMEntityView>("648b5d3f-0161-48e5-8af0-c6c15f29d55b","","",true, this);
 
            VATAmount = RPSControlFactory.CreateRPSFormattedTextBox<TaxPurchaseInvoiceVMEntityView>("eeb38d10-6b81-49eb-a80c-64600d97d856","","",true, this);
 
            ExcludedFromRC = RPSControlFactory.CreateRPSCheckBox<TaxPurchaseInvoiceVMEntityView>("eba9579c-d5c2-4975-a264-32fe4446e362","","",true, this);
 
            IsReverse = RPSControlFactory.CreateRPSCheckBox<TaxPurchaseInvoiceVMEntityView>("858890ee-dcfa-4065-849f-9afaffb28800","","",true, this);
 
            Usage303 = RPSControlFactory.CreateRPSEnumComboBox<TaxPurchaseInvoiceVMEntityView>("82347a8c-4ac3-4c0f-8877-e359dee1e3c2","","",true, this);
 
            IncludeCommandButton = RPSControlFactory.CreateRPSButton<TaxPurchaseInvoiceVMEntityView>( "edba38c3-cd4e-4386-88dc-f5e014e73647","","",this);
 
            ExcludeCommandButton = RPSControlFactory.CreateRPSButton<TaxPurchaseInvoiceVMEntityView>( "dabaaa6a-c3ce-4bd6-bb31-48dbc7a5f9e0","","",this);
 
            SentType = RPSControlFactory.CreateRPSTextBox<TaxPurchaseInvoiceVMEntityView>("4e1e8907-980d-4232-b56a-8550085803f0","","",false, this);
 
            SentKeys = RPSControlFactory.CreateRPSTextBox<TaxPurchaseInvoiceVMEntityView>("aa63c4cb-b4ba-4ac1-ac35-eb7e3bc11443","","",false, this);
 
            SentVAT = RPSControlFactory.CreateRPSTextBox<TaxPurchaseInvoiceVMEntityView>("13083225-e988-48cd-8311-e05cb0f5c8f4","","",false, this);
 
            SentText = RPSControlFactory.CreateRPSTextBox<TaxPurchaseInvoiceVMEntityView>("7669497f-b114-4403-ad53-f4130fa325ee","","",false, this);
 
            RefreshInvoiceCommandButton = RPSControlFactory.CreateRPSButton<TaxPurchaseInvoiceVMEntityView>( "e2197feb-ea34-482d-99ca-1f090fd7067e","","",this);
 
            SendOneCommandButton = RPSControlFactory.CreateRPSButton<TaxPurchaseInvoiceVMEntityView>( "002d3434-d50e-4c15-b97b-b621f67ba266","","",this);
 
            IncludePurchaseInvoiceCommandButton = RPSControlFactory.CreateRPSButton<TaxPurchaseInvoiceVMEntityView>( "557df1de-7f1e-4e7c-9440-e1cb6470ee73","","",this);
 
            ExcludePurchaseInvoiceCommandButton = RPSControlFactory.CreateRPSButton<TaxPurchaseInvoiceVMEntityView>( "e1ded08f-a2fd-401d-8a04-1d2502d97c28","","",this);
 
            SendOKPurchaseInvoiceCommandButton = RPSControlFactory.CreateRPSButton<TaxPurchaseInvoiceVMEntityView>( "020afe5b-0344-4d59-bc18-1aaaec481a40","","",this);
 
            DeleteOKPurchaseInvoiceCommandButton = RPSControlFactory.CreateRPSButton<TaxPurchaseInvoiceVMEntityView>( "bb3f22bc-8850-4d32-9dcb-9f4b1229a074","","",this);
 
            ReplacePurchaseInvoiceCommandButton = RPSControlFactory.CreateRPSButton<TaxPurchaseInvoiceVMEntityView>( "d209c385-1832-4e11-ac5e-b220d2a49810","","",this);
 
            FreezeTaxPurchaseInvoiceCommandButton = RPSControlFactory.CreateRPSButton<TaxPurchaseInvoiceVMEntityView>( "a0323547-a967-4e70-9769-b126a636c70a","","",this);
 
            CollectionInit params_TaxPurchaseVATs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="49007fe9-9b26-42f7-afc6-14e6d593bf63",CSSSelectorGrid="",XPathGrid=""};
            TaxPurchaseVATs = RPSControlFactory.RPSCreateCollectionWithGrid<TaxPurchaseVATsCollectionEditor<TaxPurchaseInvoiceVMEntityView>,TaxPurchaseInvoiceVMEntityView>( params_TaxPurchaseVATs,this);
 
            CollectionInit params_SIIPurchasePaymentByID = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="82764f0e-a565-4f82-93f0-359ed5fcb764",CSSSelectorGrid="",XPathGrid=""};
            SIIPurchasePaymentByID = RPSControlFactory.RPSCreateCollectionWithGrid<SIIPurchasePaymentByIDCollectionEditor<TaxPurchaseInvoiceVMEntityView>,TaxPurchaseInvoiceVMEntityView>( params_SIIPurchasePaymentByID,this);
 
            GeneralSection = RPSControlFactory.CreateRPSSection<TaxPurchaseInvoiceVMEntityView>( "","ul li[rpsid='6bf30e2d-d71c-42f5-8cb1-8026b034ba1e']","",this);
 
            SectionDatosAdicionales = RPSControlFactory.CreateRPSSection<TaxPurchaseInvoiceVMEntityView>( "","ul li[rpsid='1891bab3-bf2e-441d-8c3c-86948e2a91d1']","",this);
 
            TaxSection = RPSControlFactory.CreateRPSSection<TaxPurchaseInvoiceVMEntityView>( "","ul li[rpsid='ee9432b5-33e4-40ca-ac5e-21be7355b930']","",this);
 
            PurchasePaymentsSection = RPSControlFactory.CreateRPSSection<TaxPurchaseInvoiceVMEntityView>( "","ul li[rpsid='4e2d7886-b2ee-41f0-a961-e3d941b5ec21']","",this);
 
            SentDataSection = RPSControlFactory.CreateRPSSection<TaxPurchaseInvoiceVMEntityView>( "","ul li[rpsid='0b848c42-d701-4410-9317-940b29ef190d']","",this);
 

        }
        public IRPSSaveButton<TaxPurchaseInvoiceVMEntityView> SaveButton { get; set; } 
        public IRPSButton<TaxPurchaseInvoiceVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<TaxPurchaseInvoiceVMEntityView,TaxPurchaseInvoiceVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<TaxPurchaseInvoiceVMEntityView,TaxPurchaseInvoiceVMQueryView> BackButton { get; set; } 
        public IRPSTextBox<TaxPurchaseInvoiceVMEntityView> CodInvoice { get; set; } 
        public IRPSTextBox<TaxPurchaseInvoiceVMEntityView> InvoiceDate { get; set; } 
        public IRPSTextBox<TaxPurchaseInvoiceVMEntityView> RegistrationDate { get; set; } 
        public IRPSTextBox<TaxPurchaseInvoiceVMEntityView> OperationDate { get; set; } 
        public IRPSTextBox<TaxPurchaseInvoiceVMEntityView> DeclarationYear { get; set; } 
        public IRPSComboBox<TaxPurchaseInvoiceVMEntityView> DeclarationMonth { get; set; } 
        public IRPSTextBox<TaxPurchaseInvoiceVMEntityView> SupplierName { get; set; } 
        public IRPSTextBox<TaxPurchaseInvoiceVMEntityView> SupplierCountry { get; set; } 
        public IRPSTextBox<TaxPurchaseInvoiceVMEntityView> SupplierVATNumber { get; set; } 
        public IRPSComboBox<TaxPurchaseInvoiceVMEntityView> ActionStatus { get; set; } 
        public IRPSTextBox<TaxPurchaseInvoiceVMEntityView> LastModifiedTime { get; set; } 
        public IRPSTextBox<TaxPurchaseInvoiceVMEntityView> SentTime { get; set; } 
        public IRPSCheckbox<TaxPurchaseInvoiceVMEntityView> Frozen { get; set; } 
        public IRPSComboBox<TaxPurchaseInvoiceVMEntityView> CreatedStatus { get; set; } 
        public IRPSComboBox<TaxPurchaseInvoiceVMEntityView> ChangedStatus { get; set; } 
        public IRPSComboBox<TaxPurchaseInvoiceVMEntityView> DeletedStatus { get; set; } 
        public IRPSComboBox<TaxPurchaseInvoiceVMEntityView> Deletion { get; set; } 
        public IRPSTextBox<TaxPurchaseInvoiceVMEntityView> ErrorInfo { get; set; } 
        public IRPSTextBox<TaxPurchaseInvoiceVMEntityView> OperationType { get; set; } 
        public IRPSCheckbox<TaxPurchaseInvoiceVMEntityView> IsDUA { get; set; } 
        public IRPSCheckbox<TaxPurchaseInvoiceVMEntityView> IsATicket { get; set; } 
        public IRPSTextBox<TaxPurchaseInvoiceVMEntityView> Description { get; set; } 
        public IRPSComboBox<TaxPurchaseInvoiceVMEntityView> IDACCTransactions { get; set; } 
        public IRPSTextBox<TaxPurchaseInvoiceVMEntityView> AccountingDate { get; set; } 
        public IRPSTextBox<TaxPurchaseInvoiceVMEntityView> CountryFrom { get; set; } 
        public IRPSTextBox<TaxPurchaseInvoiceVMEntityView> CountryTo { get; set; } 
        public IRPSComboBox<TaxPurchaseInvoiceVMEntityView> VoucherType { get; set; } 
        public IRPSCheckbox<TaxPurchaseInvoiceVMEntityView> IsAmendment { get; set; } 
        public IRPSTextBox<TaxPurchaseInvoiceVMEntityView> FromCodInvoice { get; set; } 
        public IRPSTextBox<TaxPurchaseInvoiceVMEntityView> FromInvoiceDate { get; set; } 
        public IRPSComboBox<TaxPurchaseInvoiceVMEntityView> AmendmentType { get; set; } 
        public IRPSCheckbox<TaxPurchaseInvoiceVMEntityView> AutoInvoice { get; set; } 
        public IRPSTextBox<TaxPurchaseInvoiceVMEntityView> CodEUInvoice { get; set; } 
        public IRPSComboBox<TaxPurchaseInvoiceVMEntityView> AutoInvoiceType { get; set; } 
        public IRPSCheckbox<TaxPurchaseInvoiceVMEntityView> DeductionLater { get; set; } 
        public IRPSTextBox<TaxPurchaseInvoiceVMEntityView> DeductionYear { get; set; } 
        public IRPSComboBox<TaxPurchaseInvoiceVMEntityView> DeductionMonth { get; set; } 
        public IRPSTextBox<TaxPurchaseInvoiceVMEntityView> TotalBase { get; set; } 
        public IRPSTextBox<TaxPurchaseInvoiceVMEntityView> TotalAmount { get; set; } 
        public IRPSTextBox<TaxPurchaseInvoiceVMEntityView> Total { get; set; } 
        public IRPSTextBox<TaxPurchaseInvoiceVMEntityView> TotalDedBase { get; set; } 
        public IRPSTextBox<TaxPurchaseInvoiceVMEntityView> TotalDedAmount { get; set; } 
        public IRPSComboBox<TaxPurchaseInvoiceVMEntityView> IDACCTransactionsDetail { get; set; } 
        public IRPSComboBox<TaxPurchaseInvoiceVMEntityView> IDVAT { get; set; } 
        public IRPSCheckbox<TaxPurchaseInvoiceVMEntityView> Exclude { get; set; } 
        public IRPSCheckbox<TaxPurchaseInvoiceVMEntityView> IsPending { get; set; } 
        public IRPSCheckbox<TaxPurchaseInvoiceVMEntityView> IsSurchage { get; set; } 
        public IRPSTextBox<TaxPurchaseInvoiceVMEntityView> VATBase { get; set; } 
        public IRPSTextBox<TaxPurchaseInvoiceVMEntityView> VATPercentage { get; set; } 
        public IRPSTextBox<TaxPurchaseInvoiceVMEntityView> VATAmountTotal { get; set; } 
        public IRPSTextBox<TaxPurchaseInvoiceVMEntityView> SurchagePercentage { get; set; } 
        public IRPSTextBox<TaxPurchaseInvoiceVMEntityView> SurchageAmount { get; set; } 
        public IRPSTextBox<TaxPurchaseInvoiceVMEntityView> PercentDeductible { get; set; } 
        public IRPSTextBox<TaxPurchaseInvoiceVMEntityView> VATAmount { get; set; } 
        public IRPSCheckbox<TaxPurchaseInvoiceVMEntityView> ExcludedFromRC { get; set; } 
        public IRPSCheckbox<TaxPurchaseInvoiceVMEntityView> IsReverse { get; set; } 
        public IRPSComboBox<TaxPurchaseInvoiceVMEntityView> Usage303 { get; set; } 
        public IRPSButton<TaxPurchaseInvoiceVMEntityView> IncludeCommandButton { get; set; } 
        public IRPSButton<TaxPurchaseInvoiceVMEntityView> ExcludeCommandButton { get; set; } 
        public IRPSTextBox<TaxPurchaseInvoiceVMEntityView> SentType { get; set; } 
        public IRPSTextBox<TaxPurchaseInvoiceVMEntityView> SentKeys { get; set; } 
        public IRPSTextBox<TaxPurchaseInvoiceVMEntityView> SentVAT { get; set; } 
        public IRPSTextBox<TaxPurchaseInvoiceVMEntityView> SentText { get; set; } 
        public IRPSButton<TaxPurchaseInvoiceVMEntityView> RefreshInvoiceCommandButton { get; set; } 
        public IRPSButton<TaxPurchaseInvoiceVMEntityView> SendOneCommandButton { get; set; } 
        public IRPSButton<TaxPurchaseInvoiceVMEntityView> IncludePurchaseInvoiceCommandButton { get; set; } 
        public IRPSButton<TaxPurchaseInvoiceVMEntityView> ExcludePurchaseInvoiceCommandButton { get; set; } 
        public IRPSButton<TaxPurchaseInvoiceVMEntityView> SendOKPurchaseInvoiceCommandButton { get; set; } 
        public IRPSButton<TaxPurchaseInvoiceVMEntityView> DeleteOKPurchaseInvoiceCommandButton { get; set; } 
        public IRPSButton<TaxPurchaseInvoiceVMEntityView> ReplacePurchaseInvoiceCommandButton { get; set; } 
        public IRPSButton<TaxPurchaseInvoiceVMEntityView> FreezeTaxPurchaseInvoiceCommandButton { get; set; } 
        public TaxPurchaseVATsCollectionEditor<TaxPurchaseInvoiceVMEntityView> TaxPurchaseVATs { get; set; } 
        public SIIPurchasePaymentByIDCollectionEditor<TaxPurchaseInvoiceVMEntityView> SIIPurchasePaymentByID { get; set; } 
        public IRPSSection<TaxPurchaseInvoiceVMEntityView> GeneralSection { get; set; } 
        public IRPSSection<TaxPurchaseInvoiceVMEntityView> SectionDatosAdicionales { get; set; } 
        public IRPSSection<TaxPurchaseInvoiceVMEntityView> TaxSection { get; set; } 
        public IRPSSection<TaxPurchaseInvoiceVMEntityView> PurchasePaymentsSection { get; set; } 
        public IRPSSection<TaxPurchaseInvoiceVMEntityView> SentDataSection { get; set; } 
        public SIIPurchaseInvoice Screen { get; set; }
        public TaxPurchaseInvoiceVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class TaxPurchaseVATsCollectionEditor<TaxPurchaseInvoiceVMEntityView>:RPSCollectionEditor<TaxPurchaseInvoiceVMEntityView> where TaxPurchaseInvoiceVMEntityView : class, IView
    {
        public  TaxPurchaseVATsGridView<TaxPurchaseInvoiceVMEntityView> GridView {get;set;}
    }
    public partial class TaxPurchaseVATsGridView <TaxPurchaseInvoiceVMEntityView> :  RPSGridView<TaxPurchaseInvoiceVMEntityView> where TaxPurchaseInvoiceVMEntityView : class, IView
    {
        public TaxPurchaseVATsGridView(TaxPurchaseInvoiceVMEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Exclude = RPSControlFactory.CreateRPSGridCheckBox<TaxPurchaseInvoiceVMEntityView>("","#49007fe9-9b26-42f7-afc6-14e6d593bf63 .ag-row[role='row']@ROWINDEX [col-id='cExclude']","",true, this.CurrentView);
 
            IsPending = RPSControlFactory.CreateRPSGridCheckBox<TaxPurchaseInvoiceVMEntityView>("","#49007fe9-9b26-42f7-afc6-14e6d593bf63 .ag-row[role='row']@ROWINDEX [col-id='cIsPending']","",true, this.CurrentView);
 
            ExcludedFromRC = RPSControlFactory.CreateRPSGridCheckBox<TaxPurchaseInvoiceVMEntityView>("","#49007fe9-9b26-42f7-afc6-14e6d593bf63 .ag-row[role='row']@ROWINDEX [col-id='cExcludedFromRC']","",true, this.CurrentView);
 
            IsReverse = RPSControlFactory.CreateRPSGridCheckBox<TaxPurchaseInvoiceVMEntityView>("","#49007fe9-9b26-42f7-afc6-14e6d593bf63 .ag-row[role='row']@ROWINDEX [col-id='cIsReverse']","",true, this.CurrentView);
 
            IsSurchage = RPSControlFactory.CreateRPSGridCheckBox<TaxPurchaseInvoiceVMEntityView>("","#49007fe9-9b26-42f7-afc6-14e6d593bf63 .ag-row[role='row']@ROWINDEX [col-id='cIsSurchage']","",true, this.CurrentView);
 
            VATBase = RPSControlFactory.CreateRPSGridFormattedTextBox<TaxPurchaseInvoiceVMEntityView>("","#49007fe9-9b26-42f7-afc6-14e6d593bf63 .ag-row[role='row']@ROWINDEX [col-id='cVATBase']","",true, this.CurrentView);
 
            VATPercentage = RPSControlFactory.CreateRPSGridFormattedTextBox<TaxPurchaseInvoiceVMEntityView>("","#49007fe9-9b26-42f7-afc6-14e6d593bf63 .ag-row[role='row']@ROWINDEX [col-id='cVATPercentage']","",true, this.CurrentView);
 
            PercentDeductible = RPSControlFactory.CreateRPSGridFormattedTextBox<TaxPurchaseInvoiceVMEntityView>("","#49007fe9-9b26-42f7-afc6-14e6d593bf63 .ag-row[role='row']@ROWINDEX [col-id='cPercentDeductible']","",true, this.CurrentView);
 
            VATAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<TaxPurchaseInvoiceVMEntityView>("","#49007fe9-9b26-42f7-afc6-14e6d593bf63 .ag-row[role='row']@ROWINDEX [col-id='cVATAmount']","",true, this.CurrentView);
 
            Usage303 = RPSControlFactory.CreateRPSGridEnumComboBox<TaxPurchaseInvoiceVMEntityView>("","#49007fe9-9b26-42f7-afc6-14e6d593bf63 .ag-row[role='row']@ROWINDEX [col-id='cUsage303']","",true, this.CurrentView);
 

        }
        public IRPSGridCheckbox<TaxPurchaseInvoiceVMEntityView> Exclude { get; set; } 
        public IRPSGridCheckbox<TaxPurchaseInvoiceVMEntityView> IsPending { get; set; } 
        public IRPSGridCheckbox<TaxPurchaseInvoiceVMEntityView> ExcludedFromRC { get; set; } 
        public IRPSGridCheckbox<TaxPurchaseInvoiceVMEntityView> IsReverse { get; set; } 
        public IRPSGridCheckbox<TaxPurchaseInvoiceVMEntityView> IsSurchage { get; set; } 
        public IRPSGridTextBox<TaxPurchaseInvoiceVMEntityView> VATBase { get; set; } 
        public IRPSGridTextBox<TaxPurchaseInvoiceVMEntityView> VATPercentage { get; set; } 
        public IRPSGridTextBox<TaxPurchaseInvoiceVMEntityView> PercentDeductible { get; set; } 
        public IRPSGridTextBox<TaxPurchaseInvoiceVMEntityView> VATAmount { get; set; } 
        public IRPSGridComboBox<TaxPurchaseInvoiceVMEntityView> Usage303 { get; set; } 
                     
    }
 
        public partial class SIIPurchasePaymentByIDCollectionEditor<TaxPurchaseInvoiceVMEntityView>:RPSCollectionEditor<TaxPurchaseInvoiceVMEntityView> where TaxPurchaseInvoiceVMEntityView : class, IView
    {
        public  SIIPurchasePaymentByIDGridView<TaxPurchaseInvoiceVMEntityView> GridView {get;set;}
    }
    public partial class SIIPurchasePaymentByIDGridView <TaxPurchaseInvoiceVMEntityView> :  RPSGridView<TaxPurchaseInvoiceVMEntityView> where TaxPurchaseInvoiceVMEntityView : class, IView
    {
        public SIIPurchasePaymentByIDGridView(TaxPurchaseInvoiceVMEntityView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDACCTransactions = RPSControlFactory.CreateRPSGridComboBox<TaxPurchaseInvoiceVMEntityView>("","#82764f0e-a565-4f82-93f0-359ed5fcb764 .ag-row[role='row']@ROWINDEX [col-id='cIDACCTransactions']","",false, this.CurrentView);
 
            TaxPurchasePayment_AccountingDate = RPSControlFactory.CreateRPSGridTextBox<TaxPurchaseInvoiceVMEntityView>("","#82764f0e-a565-4f82-93f0-359ed5fcb764 .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchasePayment_AccountingDate']","",false, this.CurrentView);
 
            TaxPurchasePayment_PaidType = RPSControlFactory.CreateRPSGridTextBox<TaxPurchaseInvoiceVMEntityView>("","#82764f0e-a565-4f82-93f0-359ed5fcb764 .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchasePayment_PaidType']","",false, this.CurrentView);
 
            TaxPurchasePayment_PaidExtension = RPSControlFactory.CreateRPSGridTextBox<TaxPurchaseInvoiceVMEntityView>("","#82764f0e-a565-4f82-93f0-359ed5fcb764 .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchasePayment_PaidExtension']","",false, this.CurrentView);
 
            TaxPurchasePayment_SentTime = RPSControlFactory.CreateRPSGridTextBox<TaxPurchaseInvoiceVMEntityView>("","#82764f0e-a565-4f82-93f0-359ed5fcb764 .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchasePayment_SentTime']","",false, this.CurrentView);
 
            TaxPurchasePayment_SentStatus = RPSControlFactory.CreateRPSGridTextBox<TaxPurchaseInvoiceVMEntityView>("","#82764f0e-a565-4f82-93f0-359ed5fcb764 .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchasePayment_SentStatus']","",false, this.CurrentView);
 
            TaxPurchasePayment_ErrorInfo = RPSControlFactory.CreateRPSGridMemoTextBox<TaxPurchaseInvoiceVMEntityView>("","#82764f0e-a565-4f82-93f0-359ed5fcb764 .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchasePayment_ErrorInfo']","",false, this.CurrentView);
 
            TaxPurchasePayment_Deletion = RPSControlFactory.CreateRPSGridTextBox<TaxPurchaseInvoiceVMEntityView>("","#82764f0e-a565-4f82-93f0-359ed5fcb764 .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchasePayment_Deletion']","",false, this.CurrentView);
 
            TaxPurchasePayment_ActionStatus = RPSControlFactory.CreateRPSGridTextBox<TaxPurchaseInvoiceVMEntityView>("","#82764f0e-a565-4f82-93f0-359ed5fcb764 .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchasePayment_ActionStatus']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<TaxPurchaseInvoiceVMEntityView> IDACCTransactions { get; set; } 
        public IRPSGridTextBox<TaxPurchaseInvoiceVMEntityView> TaxPurchasePayment_AccountingDate { get; set; } 
        public IRPSGridTextBox<TaxPurchaseInvoiceVMEntityView> TaxPurchasePayment_PaidType { get; set; } 
        public IRPSGridTextBox<TaxPurchaseInvoiceVMEntityView> TaxPurchasePayment_PaidExtension { get; set; } 
        public IRPSGridTextBox<TaxPurchaseInvoiceVMEntityView> TaxPurchasePayment_SentTime { get; set; } 
        public IRPSGridTextBox<TaxPurchaseInvoiceVMEntityView> TaxPurchasePayment_SentStatus { get; set; } 
        public IRPSGridTextBox<TaxPurchaseInvoiceVMEntityView> TaxPurchasePayment_ErrorInfo { get; set; } 
        public IRPSGridTextBox<TaxPurchaseInvoiceVMEntityView> TaxPurchasePayment_Deletion { get; set; } 
        public IRPSGridTextBox<TaxPurchaseInvoiceVMEntityView> TaxPurchasePayment_ActionStatus { get; set; } 
                     
    }
 
    }
  
            
    public partial class SIIPurchaseInvoiceSendDialogView : View
    {
        public SIIPurchaseInvoiceSendDialogView(SIIPurchaseInvoice screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SelectedCreated = RPSControlFactory.CreateRPSTextBox<SIIPurchaseInvoiceSendDialogView>("84232bd3-71a7-4cbc-8bf9-ac56c1b73934","","",false, this);
 
            SelectedChanged = RPSControlFactory.CreateRPSTextBox<SIIPurchaseInvoiceSendDialogView>("2d6a1c99-f5dd-4921-8e23-52254028095e","","",false, this);
 
            SelectedDeleted = RPSControlFactory.CreateRPSTextBox<SIIPurchaseInvoiceSendDialogView>("8215a16b-084a-4c78-a956-2089f9e7625f","","",false, this);
 
            SendCommandButton = RPSControlFactory.CreateRPSButton<SIIPurchaseInvoiceSendDialogView>( "3c057b25-ab29-4120-b0b3-26c0c8d367c6","","",this);
 
            CollectionInit params_SIIPurchaseInvoiceToBeCreated = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="83a189be-e10d-4bf1-b127-751442fa5eac",CSSSelectorGrid="",XPathGrid=""};
            SIIPurchaseInvoiceToBeCreated = RPSControlFactory.RPSCreateCollectionWithGrid<SIIPurchaseInvoiceToBeCreatedCollectionEditor<SIIPurchaseInvoiceSendDialogView>,SIIPurchaseInvoiceSendDialogView>( params_SIIPurchaseInvoiceToBeCreated,this);
 
            CollectionInit params_SIIPurchaseInvoiceToBeChanged = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8d7cfe6b-c84c-4d66-b715-2bf69ec7bca3",CSSSelectorGrid="",XPathGrid=""};
            SIIPurchaseInvoiceToBeChanged = RPSControlFactory.RPSCreateCollectionWithGrid<SIIPurchaseInvoiceToBeChangedCollectionEditor<SIIPurchaseInvoiceSendDialogView>,SIIPurchaseInvoiceSendDialogView>( params_SIIPurchaseInvoiceToBeChanged,this);
 
            CollectionInit params_SIIPurchaseInvoiceToBeDeleted = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ebbfe1bd-7e70-462d-bd03-2ecff9405b31",CSSSelectorGrid="",XPathGrid=""};
            SIIPurchaseInvoiceToBeDeleted = RPSControlFactory.RPSCreateCollectionWithGrid<SIIPurchaseInvoiceToBeDeletedCollectionEditor<SIIPurchaseInvoiceSendDialogView>,SIIPurchaseInvoiceSendDialogView>( params_SIIPurchaseInvoiceToBeDeleted,this);
 
            ToBeCreated = RPSControlFactory.CreateRPSSection<SIIPurchaseInvoiceSendDialogView>( "","ul li[rpsid='b076e4e4-6f8a-4b53-b519-852735ee2fbf']","",this);
 
            ToBeChanged = RPSControlFactory.CreateRPSSection<SIIPurchaseInvoiceSendDialogView>( "","ul li[rpsid='c96eacb8-54b6-42b3-a4ca-b84f10bc523a']","",this);
 
            ToBeDeleted = RPSControlFactory.CreateRPSSection<SIIPurchaseInvoiceSendDialogView>( "","ul li[rpsid='92f20a60-6aa2-4add-891f-7b1aca557b7b']","",this);
 

        }
        public IRPSTextBox<SIIPurchaseInvoiceSendDialogView> SelectedCreated { get; set; } 
        public IRPSTextBox<SIIPurchaseInvoiceSendDialogView> SelectedChanged { get; set; } 
        public IRPSTextBox<SIIPurchaseInvoiceSendDialogView> SelectedDeleted { get; set; } 
        public IRPSButton<SIIPurchaseInvoiceSendDialogView> SendCommandButton { get; set; } 
        public SIIPurchaseInvoiceToBeCreatedCollectionEditor<SIIPurchaseInvoiceSendDialogView> SIIPurchaseInvoiceToBeCreated { get; set; } 
        public SIIPurchaseInvoiceToBeChangedCollectionEditor<SIIPurchaseInvoiceSendDialogView> SIIPurchaseInvoiceToBeChanged { get; set; } 
        public SIIPurchaseInvoiceToBeDeletedCollectionEditor<SIIPurchaseInvoiceSendDialogView> SIIPurchaseInvoiceToBeDeleted { get; set; } 
        public IRPSSection<SIIPurchaseInvoiceSendDialogView> ToBeCreated { get; set; } 
        public IRPSSection<SIIPurchaseInvoiceSendDialogView> ToBeChanged { get; set; } 
        public IRPSSection<SIIPurchaseInvoiceSendDialogView> ToBeDeleted { get; set; } 
        public SIIPurchaseInvoice Screen { get; set; }
        public SIIPurchaseInvoiceSendDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SIIPurchaseInvoiceToBeCreatedCollectionEditor<SIIPurchaseInvoiceSendDialogView>:RPSCollectionEditor<SIIPurchaseInvoiceSendDialogView> where SIIPurchaseInvoiceSendDialogView : class, IView
    {
        public  SIIPurchaseInvoiceToBeCreatedGridView<SIIPurchaseInvoiceSendDialogView> GridView {get;set;}
    }
    public partial class SIIPurchaseInvoiceToBeCreatedGridView <SIIPurchaseInvoiceSendDialogView> :  RPSGridView<SIIPurchaseInvoiceSendDialogView> where SIIPurchaseInvoiceSendDialogView : class, IView
    {
        public SIIPurchaseInvoiceToBeCreatedGridView(SIIPurchaseInvoiceSendDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            TaxPurchaseInvoice_CodInvoice = RPSControlFactory.CreateRPSGridTextBox<SIIPurchaseInvoiceSendDialogView>("","#83a189be-e10d-4bf1-b127-751442fa5eac .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchaseInvoice_CodInvoice']","",false, this.CurrentView);
 
            TaxPurchaseInvoice_InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<SIIPurchaseInvoiceSendDialogView>("","#83a189be-e10d-4bf1-b127-751442fa5eac .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchaseInvoice_InvoiceDate']","",false, this.CurrentView);
 
            TaxPurchaseInvoice_SupplierVATNumber = RPSControlFactory.CreateRPSGridTextBox<SIIPurchaseInvoiceSendDialogView>("","#83a189be-e10d-4bf1-b127-751442fa5eac .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchaseInvoice_SupplierVATNumber']","",false, this.CurrentView);
 
            TaxPurchaseInvoice_CountryFrom = RPSControlFactory.CreateRPSGridTextBox<SIIPurchaseInvoiceSendDialogView>("","#83a189be-e10d-4bf1-b127-751442fa5eac .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchaseInvoice_CountryFrom']","",false, this.CurrentView);
 
            TaxPurchaseInvoice_SupplierName = RPSControlFactory.CreateRPSGridTextBox<SIIPurchaseInvoiceSendDialogView>("","#83a189be-e10d-4bf1-b127-751442fa5eac .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchaseInvoice_SupplierName']","",false, this.CurrentView);
 
            TaxPurchaseInvoice_AccountingDate = RPSControlFactory.CreateRPSGridTextBox<SIIPurchaseInvoiceSendDialogView>("","#83a189be-e10d-4bf1-b127-751442fa5eac .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchaseInvoice_AccountingDate']","",false, this.CurrentView);
 
            TaxPurchaseInvoice_RegistrationDate = RPSControlFactory.CreateRPSGridTextBox<SIIPurchaseInvoiceSendDialogView>("","#83a189be-e10d-4bf1-b127-751442fa5eac .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchaseInvoice_RegistrationDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SIIPurchaseInvoiceSendDialogView> TaxPurchaseInvoice_CodInvoice { get; set; } 
        public IRPSGridTextBox<SIIPurchaseInvoiceSendDialogView> TaxPurchaseInvoice_InvoiceDate { get; set; } 
        public IRPSGridTextBox<SIIPurchaseInvoiceSendDialogView> TaxPurchaseInvoice_SupplierVATNumber { get; set; } 
        public IRPSGridTextBox<SIIPurchaseInvoiceSendDialogView> TaxPurchaseInvoice_CountryFrom { get; set; } 
        public IRPSGridTextBox<SIIPurchaseInvoiceSendDialogView> TaxPurchaseInvoice_SupplierName { get; set; } 
        public IRPSGridTextBox<SIIPurchaseInvoiceSendDialogView> TaxPurchaseInvoice_AccountingDate { get; set; } 
        public IRPSGridTextBox<SIIPurchaseInvoiceSendDialogView> TaxPurchaseInvoice_RegistrationDate { get; set; } 
                     
    }
 
        public partial class SIIPurchaseInvoiceToBeChangedCollectionEditor<SIIPurchaseInvoiceSendDialogView>:RPSCollectionEditor<SIIPurchaseInvoiceSendDialogView> where SIIPurchaseInvoiceSendDialogView : class, IView
    {
        public  SIIPurchaseInvoiceToBeChangedGridView<SIIPurchaseInvoiceSendDialogView> GridView {get;set;}
    }
    public partial class SIIPurchaseInvoiceToBeChangedGridView <SIIPurchaseInvoiceSendDialogView> :  RPSGridView<SIIPurchaseInvoiceSendDialogView> where SIIPurchaseInvoiceSendDialogView : class, IView
    {
        public SIIPurchaseInvoiceToBeChangedGridView(SIIPurchaseInvoiceSendDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            TaxPurchaseInvoice_CodInvoice = RPSControlFactory.CreateRPSGridTextBox<SIIPurchaseInvoiceSendDialogView>("","#8d7cfe6b-c84c-4d66-b715-2bf69ec7bca3 .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchaseInvoice_CodInvoice']","",false, this.CurrentView);
 
            TaxPurchaseInvoice_InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<SIIPurchaseInvoiceSendDialogView>("","#8d7cfe6b-c84c-4d66-b715-2bf69ec7bca3 .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchaseInvoice_InvoiceDate']","",false, this.CurrentView);
 
            TaxPurchaseInvoice_SupplierVATNumber = RPSControlFactory.CreateRPSGridTextBox<SIIPurchaseInvoiceSendDialogView>("","#8d7cfe6b-c84c-4d66-b715-2bf69ec7bca3 .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchaseInvoice_SupplierVATNumber']","",false, this.CurrentView);
 
            TaxPurchaseInvoice_CountryFrom = RPSControlFactory.CreateRPSGridTextBox<SIIPurchaseInvoiceSendDialogView>("","#8d7cfe6b-c84c-4d66-b715-2bf69ec7bca3 .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchaseInvoice_CountryFrom']","",false, this.CurrentView);
 
            TaxPurchaseInvoice_SupplierName = RPSControlFactory.CreateRPSGridTextBox<SIIPurchaseInvoiceSendDialogView>("","#8d7cfe6b-c84c-4d66-b715-2bf69ec7bca3 .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchaseInvoice_SupplierName']","",false, this.CurrentView);
 
            TaxPurchaseInvoice_AccountingDate = RPSControlFactory.CreateRPSGridTextBox<SIIPurchaseInvoiceSendDialogView>("","#8d7cfe6b-c84c-4d66-b715-2bf69ec7bca3 .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchaseInvoice_AccountingDate']","",false, this.CurrentView);
 
            TaxPurchaseInvoice_RegistrationDate = RPSControlFactory.CreateRPSGridTextBox<SIIPurchaseInvoiceSendDialogView>("","#8d7cfe6b-c84c-4d66-b715-2bf69ec7bca3 .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchaseInvoice_RegistrationDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SIIPurchaseInvoiceSendDialogView> TaxPurchaseInvoice_CodInvoice { get; set; } 
        public IRPSGridTextBox<SIIPurchaseInvoiceSendDialogView> TaxPurchaseInvoice_InvoiceDate { get; set; } 
        public IRPSGridTextBox<SIIPurchaseInvoiceSendDialogView> TaxPurchaseInvoice_SupplierVATNumber { get; set; } 
        public IRPSGridTextBox<SIIPurchaseInvoiceSendDialogView> TaxPurchaseInvoice_CountryFrom { get; set; } 
        public IRPSGridTextBox<SIIPurchaseInvoiceSendDialogView> TaxPurchaseInvoice_SupplierName { get; set; } 
        public IRPSGridTextBox<SIIPurchaseInvoiceSendDialogView> TaxPurchaseInvoice_AccountingDate { get; set; } 
        public IRPSGridTextBox<SIIPurchaseInvoiceSendDialogView> TaxPurchaseInvoice_RegistrationDate { get; set; } 
                     
    }
 
        public partial class SIIPurchaseInvoiceToBeDeletedCollectionEditor<SIIPurchaseInvoiceSendDialogView>:RPSCollectionEditor<SIIPurchaseInvoiceSendDialogView> where SIIPurchaseInvoiceSendDialogView : class, IView
    {
        public  SIIPurchaseInvoiceToBeDeletedGridView<SIIPurchaseInvoiceSendDialogView> GridView {get;set;}
    }
    public partial class SIIPurchaseInvoiceToBeDeletedGridView <SIIPurchaseInvoiceSendDialogView> :  RPSGridView<SIIPurchaseInvoiceSendDialogView> where SIIPurchaseInvoiceSendDialogView : class, IView
    {
        public SIIPurchaseInvoiceToBeDeletedGridView(SIIPurchaseInvoiceSendDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            TaxPurchaseInvoice_CodInvoice = RPSControlFactory.CreateRPSGridTextBox<SIIPurchaseInvoiceSendDialogView>("","#ebbfe1bd-7e70-462d-bd03-2ecff9405b31 .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchaseInvoice_CodInvoice']","",false, this.CurrentView);
 
            TaxPurchaseInvoice_InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<SIIPurchaseInvoiceSendDialogView>("","#ebbfe1bd-7e70-462d-bd03-2ecff9405b31 .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchaseInvoice_InvoiceDate']","",false, this.CurrentView);
 
            TaxPurchaseInvoice_SupplierVATNumber = RPSControlFactory.CreateRPSGridTextBox<SIIPurchaseInvoiceSendDialogView>("","#ebbfe1bd-7e70-462d-bd03-2ecff9405b31 .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchaseInvoice_SupplierVATNumber']","",false, this.CurrentView);
 
            TaxPurchaseInvoice_CountryFrom = RPSControlFactory.CreateRPSGridTextBox<SIIPurchaseInvoiceSendDialogView>("","#ebbfe1bd-7e70-462d-bd03-2ecff9405b31 .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchaseInvoice_CountryFrom']","",false, this.CurrentView);
 
            TaxPurchaseInvoice_SupplierName = RPSControlFactory.CreateRPSGridTextBox<SIIPurchaseInvoiceSendDialogView>("","#ebbfe1bd-7e70-462d-bd03-2ecff9405b31 .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchaseInvoice_SupplierName']","",false, this.CurrentView);
 
            TaxPurchaseInvoice_AccountingDate = RPSControlFactory.CreateRPSGridTextBox<SIIPurchaseInvoiceSendDialogView>("","#ebbfe1bd-7e70-462d-bd03-2ecff9405b31 .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchaseInvoice_AccountingDate']","",false, this.CurrentView);
 
            TaxPurchaseInvoice_RegistrationDate = RPSControlFactory.CreateRPSGridTextBox<SIIPurchaseInvoiceSendDialogView>("","#ebbfe1bd-7e70-462d-bd03-2ecff9405b31 .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchaseInvoice_RegistrationDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SIIPurchaseInvoiceSendDialogView> TaxPurchaseInvoice_CodInvoice { get; set; } 
        public IRPSGridTextBox<SIIPurchaseInvoiceSendDialogView> TaxPurchaseInvoice_InvoiceDate { get; set; } 
        public IRPSGridTextBox<SIIPurchaseInvoiceSendDialogView> TaxPurchaseInvoice_SupplierVATNumber { get; set; } 
        public IRPSGridTextBox<SIIPurchaseInvoiceSendDialogView> TaxPurchaseInvoice_CountryFrom { get; set; } 
        public IRPSGridTextBox<SIIPurchaseInvoiceSendDialogView> TaxPurchaseInvoice_SupplierName { get; set; } 
        public IRPSGridTextBox<SIIPurchaseInvoiceSendDialogView> TaxPurchaseInvoice_AccountingDate { get; set; } 
        public IRPSGridTextBox<SIIPurchaseInvoiceSendDialogView> TaxPurchaseInvoice_RegistrationDate { get; set; } 
                     
    }
 
    }
  
    

}