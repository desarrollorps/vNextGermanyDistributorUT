    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.TaxModel.SIIPurchasePayment
{
    //RPS VERSION 1.0.0.0
    public partial class SIIPurchasePayment:Screen
    {
        public SIIPurchasePayment():base()
        {
            this.URL = "taxmodel.siipurchasepayment";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SIIPurchasePaymentQueryView  = new SIIPurchasePaymentQueryView(this); 
            SIIPurchasePaymentSendDialogView  = new SIIPurchasePaymentSendDialogView(this); 
            SIIPurchasePaymentQueryView.InitializeControls(); 
            SIIPurchasePaymentSendDialogView.InitializeControls(); 
           
        }
      
            public SIIPurchasePaymentQueryView SIIPurchasePaymentQueryView {get; set; } 
            public SIIPurchasePaymentSendDialogView SIIPurchasePaymentSendDialogView {get; set; } 
    }
            
    public partial class SIIPurchasePaymentQueryView : View
    {
        public SIIPurchasePaymentQueryView(SIIPurchasePayment screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            InvoiceDateFrom = RPSControlFactory.CreateRPSTextBox<SIIPurchasePaymentQueryView>("1451fa03-503f-441f-8a1d-ac323951368d","","",false, this);
 
            InvoiceDateTo = RPSControlFactory.CreateRPSTextBox<SIIPurchasePaymentQueryView>("cfde2e51-e9ae-4527-a3c0-e38732573ec7","","",false, this);
 
            AccountingDateFrom = RPSControlFactory.CreateRPSTextBox<SIIPurchasePaymentQueryView>("d5e71dfd-3568-42e2-aaae-c8a2c5aa3b06","","",false, this);
 
            AccountingDateTo = RPSControlFactory.CreateRPSTextBox<SIIPurchasePaymentQueryView>("055c81cf-70d8-4425-a843-156ee7dbccdf","","",false, this);
 
            Sent = RPSControlFactory.CreateRPSCheckBox<SIIPurchasePaymentQueryView>("77fecdc8-d214-4650-b1ec-e83cdc11f43f","","",false, this);
 
            PendingCorrection = RPSControlFactory.CreateRPSCheckBox<SIIPurchasePaymentQueryView>("0bf5b416-4d0e-428e-ad7f-36f450ef3ee0","","",false, this);
 
            ToBeCreated = RPSControlFactory.CreateRPSCheckBox<SIIPurchasePaymentQueryView>("185004d9-2bb3-46c4-8a0d-5790e49454e6","","",false, this);
 
            ToBeChanged = RPSControlFactory.CreateRPSCheckBox<SIIPurchasePaymentQueryView>("abaabd53-6d42-4959-87aa-3f62722433f9","","",false, this);
 
            ToBeDeleted = RPSControlFactory.CreateRPSCheckBox<SIIPurchasePaymentQueryView>("6183d92d-0342-44f1-afdc-168db6699cb6","","",false, this);
 
            NoSend = RPSControlFactory.CreateRPSCheckBox<SIIPurchasePaymentQueryView>("f86c3234-ab7a-4b63-9bac-74d129e542c4","","",false, this);
 
            Deleted = RPSControlFactory.CreateRPSCheckBox<SIIPurchasePaymentQueryView>("75afb827-9080-4fbf-87c1-4a7f44829062","","",false, this);
 
            SIILoadDataCommandButton = RPSControlFactory.CreateRPSButton<SIIPurchasePaymentQueryView>( "db245042-9226-471d-91cf-784115957d2f","","",this);
 
            LinkNavigationCommandButton = RPSControlFactory.CreateRPSButton<SIIPurchasePaymentQueryView>( "c37f272b-ffaf-4238-83e4-875d5873c74d","","",this);
 
            IncludePurchaseCommandButton = RPSControlFactory.CreateRPSButton<SIIPurchasePaymentQueryView>( "23caeb41-7dc4-4b57-b37a-c0b957757f53","","",this);
 
            ExcludePurchaseCommandButton = RPSControlFactory.CreateRPSButton<SIIPurchasePaymentQueryView>( "2bd86e07-5ecb-4724-8e7a-23f4153ec85f","","",this);
 
            CollectionInit params_SIIPurchasePayment = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3577f644-1117-423f-b929-dccc2d9e41be",CSSSelectorGrid="",XPathGrid=""};
            SIIPurchasePayment = RPSControlFactory.RPSCreateCollectionWithGrid<SIIPurchasePaymentCollectionEditor<SIIPurchasePaymentQueryView,SIIPurchasePaymentSendDialogView>,SIIPurchasePaymentQueryView,SIIPurchasePaymentSendDialogView>( params_SIIPurchasePayment,this,Screen.SIIPurchasePaymentSendDialogView);
 

        }
        public IRPSTextBox<SIIPurchasePaymentQueryView> InvoiceDateFrom { get; set; } 
        public IRPSTextBox<SIIPurchasePaymentQueryView> InvoiceDateTo { get; set; } 
        public IRPSTextBox<SIIPurchasePaymentQueryView> AccountingDateFrom { get; set; } 
        public IRPSTextBox<SIIPurchasePaymentQueryView> AccountingDateTo { get; set; } 
        public IRPSCheckbox<SIIPurchasePaymentQueryView> Sent { get; set; } 
        public IRPSCheckbox<SIIPurchasePaymentQueryView> PendingCorrection { get; set; } 
        public IRPSCheckbox<SIIPurchasePaymentQueryView> ToBeCreated { get; set; } 
        public IRPSCheckbox<SIIPurchasePaymentQueryView> ToBeChanged { get; set; } 
        public IRPSCheckbox<SIIPurchasePaymentQueryView> ToBeDeleted { get; set; } 
        public IRPSCheckbox<SIIPurchasePaymentQueryView> NoSend { get; set; } 
        public IRPSCheckbox<SIIPurchasePaymentQueryView> Deleted { get; set; } 
        public IRPSButton<SIIPurchasePaymentQueryView> SIILoadDataCommandButton { get; set; } 
        public IRPSButton<SIIPurchasePaymentQueryView> LinkNavigationCommandButton { get; set; } 
        public IRPSButton<SIIPurchasePaymentQueryView> IncludePurchaseCommandButton { get; set; } 
        public IRPSButton<SIIPurchasePaymentQueryView> ExcludePurchaseCommandButton { get; set; } 
        public SIIPurchasePaymentCollectionEditor<SIIPurchasePaymentQueryView,SIIPurchasePaymentSendDialogView> SIIPurchasePayment { get; set; } 
        public SIIPurchasePayment Screen { get; set; }
        public SIIPurchasePaymentQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SIIPurchasePaymentCollectionEditor<SIIPurchasePaymentQueryView,SIIPurchasePaymentSendDialogView>:RPSCollectionEditor<SIIPurchasePaymentQueryView,SIIPurchasePaymentSendDialogView> where SIIPurchasePaymentQueryView : class, IView where SIIPurchasePaymentSendDialogView : class, IView
    {
        public  SIIPurchasePaymentGridView<SIIPurchasePaymentQueryView,SIIPurchasePaymentSendDialogView> GridView {get;set;}
    }
    public partial class SIIPurchasePaymentGridView <SIIPurchasePaymentQueryView,SIIPurchasePaymentSendDialogView> :  RPSGridView<SIIPurchasePaymentQueryView,SIIPurchasePaymentSendDialogView> where SIIPurchasePaymentQueryView : class, IView where SIIPurchasePaymentSendDialogView : class, IView
    {
        public SIIPurchasePaymentGridView(SIIPurchasePaymentQueryView currentView,SIIPurchasePaymentSendDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodInvoice = RPSControlFactory.CreateRPSGridTextBox<SIIPurchasePaymentQueryView>("","#3577f644-1117-423f-b929-dccc2d9e41be .ag-row[role='row']@ROWINDEX [col-id='cCodInvoice']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<SIIPurchasePaymentQueryView>("","#3577f644-1117-423f-b929-dccc2d9e41be .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 
            SupplierName = RPSControlFactory.CreateRPSGridTextBox<SIIPurchasePaymentQueryView>("","#3577f644-1117-423f-b929-dccc2d9e41be .ag-row[role='row']@ROWINDEX [col-id='cSupplierName']","",false, this.CurrentView);
 
            TaxPurchasePayment_AccountingDate = RPSControlFactory.CreateRPSGridTextBox<SIIPurchasePaymentQueryView>("","#3577f644-1117-423f-b929-dccc2d9e41be .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchasePayment_AccountingDate']","",false, this.CurrentView);
 
            TaxPurchasePayment_PaidType = RPSControlFactory.CreateRPSGridTextBox<SIIPurchasePaymentQueryView>("","#3577f644-1117-423f-b929-dccc2d9e41be .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchasePayment_PaidType']","",false, this.CurrentView);
 
            TaxPurchasePayment_PaidExtension = RPSControlFactory.CreateRPSGridTextBox<SIIPurchasePaymentQueryView>("","#3577f644-1117-423f-b929-dccc2d9e41be .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchasePayment_PaidExtension']","",false, this.CurrentView);
 
            TaxPurchasePayment_SentTime = RPSControlFactory.CreateRPSGridTextBox<SIIPurchasePaymentQueryView>("","#3577f644-1117-423f-b929-dccc2d9e41be .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchasePayment_SentTime']","",false, this.CurrentView);
 
            TaxPurchasePayment_SentStatus = RPSControlFactory.CreateRPSGridTextBox<SIIPurchasePaymentQueryView>("","#3577f644-1117-423f-b929-dccc2d9e41be .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchasePayment_SentStatus']","",false, this.CurrentView);
 
            TaxPurchasePayment_ErrorInfo = RPSControlFactory.CreateRPSGridMemoTextBox<SIIPurchasePaymentQueryView>("","#3577f644-1117-423f-b929-dccc2d9e41be .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchasePayment_ErrorInfo']","",false, this.CurrentView);
 
            TaxPurchasePayment_Deletion = RPSControlFactory.CreateRPSGridTextBox<SIIPurchasePaymentQueryView>("","#3577f644-1117-423f-b929-dccc2d9e41be .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchasePayment_Deletion']","",false, this.CurrentView);
 
            TaxPurchasePayment_ActionStatus = RPSControlFactory.CreateRPSGridTextBox<SIIPurchasePaymentQueryView>("","#3577f644-1117-423f-b929-dccc2d9e41be .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchasePayment_ActionStatus']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SIIPurchasePaymentQueryView> CodInvoice { get; set; } 
        public IRPSGridTextBox<SIIPurchasePaymentQueryView> InvoiceDate { get; set; } 
        public IRPSGridTextBox<SIIPurchasePaymentQueryView> SupplierName { get; set; } 
        public IRPSGridTextBox<SIIPurchasePaymentQueryView> TaxPurchasePayment_AccountingDate { get; set; } 
        public IRPSGridTextBox<SIIPurchasePaymentQueryView> TaxPurchasePayment_PaidType { get; set; } 
        public IRPSGridTextBox<SIIPurchasePaymentQueryView> TaxPurchasePayment_PaidExtension { get; set; } 
        public IRPSGridTextBox<SIIPurchasePaymentQueryView> TaxPurchasePayment_SentTime { get; set; } 
        public IRPSGridTextBox<SIIPurchasePaymentQueryView> TaxPurchasePayment_SentStatus { get; set; } 
        public IRPSGridTextBox<SIIPurchasePaymentQueryView> TaxPurchasePayment_ErrorInfo { get; set; } 
        public IRPSGridTextBox<SIIPurchasePaymentQueryView> TaxPurchasePayment_Deletion { get; set; } 
        public IRPSGridTextBox<SIIPurchasePaymentQueryView> TaxPurchasePayment_ActionStatus { get; set; } 
                     
    }
 
    }
  
            
    public partial class SIIPurchasePaymentSendDialogView : View
    {
        public SIIPurchasePaymentSendDialogView(SIIPurchasePayment screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SelectedCreated = RPSControlFactory.CreateRPSTextBox<SIIPurchasePaymentSendDialogView>("97b7eab1-9fa4-48ef-9d63-db11c4d32837","","",false, this);
 
            SelectedChanged = RPSControlFactory.CreateRPSTextBox<SIIPurchasePaymentSendDialogView>("070659fd-76b0-4c48-9cb9-3aa5d742c866","","",false, this);
 
            SelectedDeleted = RPSControlFactory.CreateRPSTextBox<SIIPurchasePaymentSendDialogView>("27f680e0-a11b-4481-b249-c39d83cb4262","","",false, this);
 
            SendCommandButton = RPSControlFactory.CreateRPSButton<SIIPurchasePaymentSendDialogView>( "8735e498-4d02-4dfe-a689-78db13431614","","",this);
 
            CollectionInit params_SIIPurchasePaymentToBeCreated = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d7d95324-32fc-44f9-92a2-1205eb504943",CSSSelectorGrid="",XPathGrid=""};
            SIIPurchasePaymentToBeCreated = RPSControlFactory.RPSCreateCollectionWithGrid<SIIPurchasePaymentToBeCreatedCollectionEditor<SIIPurchasePaymentSendDialogView>,SIIPurchasePaymentSendDialogView>( params_SIIPurchasePaymentToBeCreated,this);
 
            CollectionInit params_SIIPurchasePaymentToBeChanged = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b3a3acf9-d8a1-49b6-88be-e7815362c75e",CSSSelectorGrid="",XPathGrid=""};
            SIIPurchasePaymentToBeChanged = RPSControlFactory.RPSCreateCollectionWithGrid<SIIPurchasePaymentToBeChangedCollectionEditor<SIIPurchasePaymentSendDialogView>,SIIPurchasePaymentSendDialogView>( params_SIIPurchasePaymentToBeChanged,this);
 
            CollectionInit params_SIIPurchasePaymentToBeDeleted = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="42c9dd90-3bfc-463e-a158-2d80efc68300",CSSSelectorGrid="",XPathGrid=""};
            SIIPurchasePaymentToBeDeleted = RPSControlFactory.RPSCreateCollectionWithGrid<SIIPurchasePaymentToBeDeletedCollectionEditor<SIIPurchasePaymentSendDialogView>,SIIPurchasePaymentSendDialogView>( params_SIIPurchasePaymentToBeDeleted,this);
 
            ToBeCreated = RPSControlFactory.CreateRPSSection<SIIPurchasePaymentSendDialogView>( "","ul li[rpsid='607a2913-1e37-48c0-b4c6-b2fe8e86e707']","",this);
 
            ToBeChanged = RPSControlFactory.CreateRPSSection<SIIPurchasePaymentSendDialogView>( "","ul li[rpsid='a474820f-ba3f-49bc-94a4-a66982d60640']","",this);
 
            ToBeDeleted = RPSControlFactory.CreateRPSSection<SIIPurchasePaymentSendDialogView>( "","ul li[rpsid='8ca7e2ce-d67a-427a-bce3-633866fad1ef']","",this);
 

        }
        public IRPSTextBox<SIIPurchasePaymentSendDialogView> SelectedCreated { get; set; } 
        public IRPSTextBox<SIIPurchasePaymentSendDialogView> SelectedChanged { get; set; } 
        public IRPSTextBox<SIIPurchasePaymentSendDialogView> SelectedDeleted { get; set; } 
        public IRPSButton<SIIPurchasePaymentSendDialogView> SendCommandButton { get; set; } 
        public SIIPurchasePaymentToBeCreatedCollectionEditor<SIIPurchasePaymentSendDialogView> SIIPurchasePaymentToBeCreated { get; set; } 
        public SIIPurchasePaymentToBeChangedCollectionEditor<SIIPurchasePaymentSendDialogView> SIIPurchasePaymentToBeChanged { get; set; } 
        public SIIPurchasePaymentToBeDeletedCollectionEditor<SIIPurchasePaymentSendDialogView> SIIPurchasePaymentToBeDeleted { get; set; } 
        public IRPSSection<SIIPurchasePaymentSendDialogView> ToBeCreated { get; set; } 
        public IRPSSection<SIIPurchasePaymentSendDialogView> ToBeChanged { get; set; } 
        public IRPSSection<SIIPurchasePaymentSendDialogView> ToBeDeleted { get; set; } 
        public SIIPurchasePayment Screen { get; set; }
        public SIIPurchasePaymentSendDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SIIPurchasePaymentToBeCreatedCollectionEditor<SIIPurchasePaymentSendDialogView>:RPSCollectionEditor<SIIPurchasePaymentSendDialogView> where SIIPurchasePaymentSendDialogView : class, IView
    {
        public  SIIPurchasePaymentToBeCreatedGridView<SIIPurchasePaymentSendDialogView> GridView {get;set;}
    }
    public partial class SIIPurchasePaymentToBeCreatedGridView <SIIPurchasePaymentSendDialogView> :  RPSGridView<SIIPurchasePaymentSendDialogView> where SIIPurchasePaymentSendDialogView : class, IView
    {
        public SIIPurchasePaymentToBeCreatedGridView(SIIPurchasePaymentSendDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodInvoice = RPSControlFactory.CreateRPSGridTextBox<SIIPurchasePaymentSendDialogView>("","#d7d95324-32fc-44f9-92a2-1205eb504943 .ag-row[role='row']@ROWINDEX [col-id='cCodInvoice']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<SIIPurchasePaymentSendDialogView>("","#d7d95324-32fc-44f9-92a2-1205eb504943 .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 
            SupplierName = RPSControlFactory.CreateRPSGridTextBox<SIIPurchasePaymentSendDialogView>("","#d7d95324-32fc-44f9-92a2-1205eb504943 .ag-row[role='row']@ROWINDEX [col-id='cSupplierName']","",false, this.CurrentView);
 
            TaxPurchasePayment_AccountingDate = RPSControlFactory.CreateRPSGridTextBox<SIIPurchasePaymentSendDialogView>("","#d7d95324-32fc-44f9-92a2-1205eb504943 .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchasePayment_AccountingDate']","",false, this.CurrentView);
 
            TaxPurchasePayment_PaidType = RPSControlFactory.CreateRPSGridTextBox<SIIPurchasePaymentSendDialogView>("","#d7d95324-32fc-44f9-92a2-1205eb504943 .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchasePayment_PaidType']","",false, this.CurrentView);
 
            TaxPurchasePayment_PaidExtension = RPSControlFactory.CreateRPSGridTextBox<SIIPurchasePaymentSendDialogView>("","#d7d95324-32fc-44f9-92a2-1205eb504943 .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchasePayment_PaidExtension']","",false, this.CurrentView);
 
            TaxPurchasePayment_SentTime = RPSControlFactory.CreateRPSGridTextBox<SIIPurchasePaymentSendDialogView>("","#d7d95324-32fc-44f9-92a2-1205eb504943 .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchasePayment_SentTime']","",false, this.CurrentView);
 
            TaxPurchasePayment_SentStatus = RPSControlFactory.CreateRPSGridTextBox<SIIPurchasePaymentSendDialogView>("","#d7d95324-32fc-44f9-92a2-1205eb504943 .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchasePayment_SentStatus']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SIIPurchasePaymentSendDialogView> CodInvoice { get; set; } 
        public IRPSGridTextBox<SIIPurchasePaymentSendDialogView> InvoiceDate { get; set; } 
        public IRPSGridTextBox<SIIPurchasePaymentSendDialogView> SupplierName { get; set; } 
        public IRPSGridTextBox<SIIPurchasePaymentSendDialogView> TaxPurchasePayment_AccountingDate { get; set; } 
        public IRPSGridTextBox<SIIPurchasePaymentSendDialogView> TaxPurchasePayment_PaidType { get; set; } 
        public IRPSGridTextBox<SIIPurchasePaymentSendDialogView> TaxPurchasePayment_PaidExtension { get; set; } 
        public IRPSGridTextBox<SIIPurchasePaymentSendDialogView> TaxPurchasePayment_SentTime { get; set; } 
        public IRPSGridTextBox<SIIPurchasePaymentSendDialogView> TaxPurchasePayment_SentStatus { get; set; } 
                     
    }
 
        public partial class SIIPurchasePaymentToBeChangedCollectionEditor<SIIPurchasePaymentSendDialogView>:RPSCollectionEditor<SIIPurchasePaymentSendDialogView> where SIIPurchasePaymentSendDialogView : class, IView
    {
        public  SIIPurchasePaymentToBeChangedGridView<SIIPurchasePaymentSendDialogView> GridView {get;set;}
    }
    public partial class SIIPurchasePaymentToBeChangedGridView <SIIPurchasePaymentSendDialogView> :  RPSGridView<SIIPurchasePaymentSendDialogView> where SIIPurchasePaymentSendDialogView : class, IView
    {
        public SIIPurchasePaymentToBeChangedGridView(SIIPurchasePaymentSendDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodInvoice = RPSControlFactory.CreateRPSGridTextBox<SIIPurchasePaymentSendDialogView>("","#b3a3acf9-d8a1-49b6-88be-e7815362c75e .ag-row[role='row']@ROWINDEX [col-id='cCodInvoice']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<SIIPurchasePaymentSendDialogView>("","#b3a3acf9-d8a1-49b6-88be-e7815362c75e .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 
            SupplierName = RPSControlFactory.CreateRPSGridTextBox<SIIPurchasePaymentSendDialogView>("","#b3a3acf9-d8a1-49b6-88be-e7815362c75e .ag-row[role='row']@ROWINDEX [col-id='cSupplierName']","",false, this.CurrentView);
 
            TaxPurchasePayment_AccountingDate = RPSControlFactory.CreateRPSGridTextBox<SIIPurchasePaymentSendDialogView>("","#b3a3acf9-d8a1-49b6-88be-e7815362c75e .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchasePayment_AccountingDate']","",false, this.CurrentView);
 
            TaxPurchasePayment_PaidType = RPSControlFactory.CreateRPSGridTextBox<SIIPurchasePaymentSendDialogView>("","#b3a3acf9-d8a1-49b6-88be-e7815362c75e .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchasePayment_PaidType']","",false, this.CurrentView);
 
            TaxPurchasePayment_PaidExtension = RPSControlFactory.CreateRPSGridTextBox<SIIPurchasePaymentSendDialogView>("","#b3a3acf9-d8a1-49b6-88be-e7815362c75e .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchasePayment_PaidExtension']","",false, this.CurrentView);
 
            TaxPurchasePayment_SentTime = RPSControlFactory.CreateRPSGridTextBox<SIIPurchasePaymentSendDialogView>("","#b3a3acf9-d8a1-49b6-88be-e7815362c75e .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchasePayment_SentTime']","",false, this.CurrentView);
 
            TaxPurchasePayment_SentStatus = RPSControlFactory.CreateRPSGridTextBox<SIIPurchasePaymentSendDialogView>("","#b3a3acf9-d8a1-49b6-88be-e7815362c75e .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchasePayment_SentStatus']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SIIPurchasePaymentSendDialogView> CodInvoice { get; set; } 
        public IRPSGridTextBox<SIIPurchasePaymentSendDialogView> InvoiceDate { get; set; } 
        public IRPSGridTextBox<SIIPurchasePaymentSendDialogView> SupplierName { get; set; } 
        public IRPSGridTextBox<SIIPurchasePaymentSendDialogView> TaxPurchasePayment_AccountingDate { get; set; } 
        public IRPSGridTextBox<SIIPurchasePaymentSendDialogView> TaxPurchasePayment_PaidType { get; set; } 
        public IRPSGridTextBox<SIIPurchasePaymentSendDialogView> TaxPurchasePayment_PaidExtension { get; set; } 
        public IRPSGridTextBox<SIIPurchasePaymentSendDialogView> TaxPurchasePayment_SentTime { get; set; } 
        public IRPSGridTextBox<SIIPurchasePaymentSendDialogView> TaxPurchasePayment_SentStatus { get; set; } 
                     
    }
 
        public partial class SIIPurchasePaymentToBeDeletedCollectionEditor<SIIPurchasePaymentSendDialogView>:RPSCollectionEditor<SIIPurchasePaymentSendDialogView> where SIIPurchasePaymentSendDialogView : class, IView
    {
        public  SIIPurchasePaymentToBeDeletedGridView<SIIPurchasePaymentSendDialogView> GridView {get;set;}
    }
    public partial class SIIPurchasePaymentToBeDeletedGridView <SIIPurchasePaymentSendDialogView> :  RPSGridView<SIIPurchasePaymentSendDialogView> where SIIPurchasePaymentSendDialogView : class, IView
    {
        public SIIPurchasePaymentToBeDeletedGridView(SIIPurchasePaymentSendDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodInvoice = RPSControlFactory.CreateRPSGridTextBox<SIIPurchasePaymentSendDialogView>("","#42c9dd90-3bfc-463e-a158-2d80efc68300 .ag-row[role='row']@ROWINDEX [col-id='cCodInvoice']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<SIIPurchasePaymentSendDialogView>("","#42c9dd90-3bfc-463e-a158-2d80efc68300 .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 
            SupplierName = RPSControlFactory.CreateRPSGridTextBox<SIIPurchasePaymentSendDialogView>("","#42c9dd90-3bfc-463e-a158-2d80efc68300 .ag-row[role='row']@ROWINDEX [col-id='cSupplierName']","",false, this.CurrentView);
 
            TaxPurchasePayment_AccountingDate = RPSControlFactory.CreateRPSGridTextBox<SIIPurchasePaymentSendDialogView>("","#42c9dd90-3bfc-463e-a158-2d80efc68300 .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchasePayment_AccountingDate']","",false, this.CurrentView);
 
            TaxPurchasePayment_PaidType = RPSControlFactory.CreateRPSGridTextBox<SIIPurchasePaymentSendDialogView>("","#42c9dd90-3bfc-463e-a158-2d80efc68300 .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchasePayment_PaidType']","",false, this.CurrentView);
 
            TaxPurchasePayment_PaidExtension = RPSControlFactory.CreateRPSGridTextBox<SIIPurchasePaymentSendDialogView>("","#42c9dd90-3bfc-463e-a158-2d80efc68300 .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchasePayment_PaidExtension']","",false, this.CurrentView);
 
            TaxPurchasePayment_SentTime = RPSControlFactory.CreateRPSGridTextBox<SIIPurchasePaymentSendDialogView>("","#42c9dd90-3bfc-463e-a158-2d80efc68300 .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchasePayment_SentTime']","",false, this.CurrentView);
 
            TaxPurchasePayment_SentStatus = RPSControlFactory.CreateRPSGridTextBox<SIIPurchasePaymentSendDialogView>("","#42c9dd90-3bfc-463e-a158-2d80efc68300 .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchasePayment_SentStatus']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SIIPurchasePaymentSendDialogView> CodInvoice { get; set; } 
        public IRPSGridTextBox<SIIPurchasePaymentSendDialogView> InvoiceDate { get; set; } 
        public IRPSGridTextBox<SIIPurchasePaymentSendDialogView> SupplierName { get; set; } 
        public IRPSGridTextBox<SIIPurchasePaymentSendDialogView> TaxPurchasePayment_AccountingDate { get; set; } 
        public IRPSGridTextBox<SIIPurchasePaymentSendDialogView> TaxPurchasePayment_PaidType { get; set; } 
        public IRPSGridTextBox<SIIPurchasePaymentSendDialogView> TaxPurchasePayment_PaidExtension { get; set; } 
        public IRPSGridTextBox<SIIPurchasePaymentSendDialogView> TaxPurchasePayment_SentTime { get; set; } 
        public IRPSGridTextBox<SIIPurchasePaymentSendDialogView> TaxPurchasePayment_SentStatus { get; set; } 
                     
    }
 
    }
  
    

}