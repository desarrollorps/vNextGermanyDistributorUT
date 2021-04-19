    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.TaxModel.SIISalesPayment
{
    //RPS VERSION 1.0.0.0
    public partial class SIISalesPayment:Screen
    {
        public SIISalesPayment():base()
        {
            this.URL = "taxmodel.siisalespayment";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SIISalesPaymentQueryView  = new SIISalesPaymentQueryView(this); 
            SIISalesPaymentSendDialogView  = new SIISalesPaymentSendDialogView(this); 
            SIISalesPaymentQueryView.InitializeControls(); 
            SIISalesPaymentSendDialogView.InitializeControls(); 
           
        }
      
            public SIISalesPaymentQueryView SIISalesPaymentQueryView {get; set; } 
            public SIISalesPaymentSendDialogView SIISalesPaymentSendDialogView {get; set; } 
    }
            
    public partial class SIISalesPaymentQueryView : View
    {
        public SIISalesPaymentQueryView(SIISalesPayment screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            AccountingDateFrom = RPSControlFactory.CreateRPSTextBox<SIISalesPaymentQueryView>("d5e71dfd-3568-42e2-aaae-c8a2c5aa3b06","","",false, this);
 
            AccountingDateTo = RPSControlFactory.CreateRPSTextBox<SIISalesPaymentQueryView>("055c81cf-70d8-4425-a843-156ee7dbccdf","","",false, this);
 
            InvoiceDateFrom = RPSControlFactory.CreateRPSTextBox<SIISalesPaymentQueryView>("1451fa03-503f-441f-8a1d-ac323951368d","","",false, this);
 
            InvoiceDateTo = RPSControlFactory.CreateRPSTextBox<SIISalesPaymentQueryView>("cfde2e51-e9ae-4527-a3c0-e38732573ec7","","",false, this);
 
            Sent = RPSControlFactory.CreateRPSCheckBox<SIISalesPaymentQueryView>("77fecdc8-d214-4650-b1ec-e83cdc11f43f","","",false, this);
 
            PendingCorrection = RPSControlFactory.CreateRPSCheckBox<SIISalesPaymentQueryView>("0bf5b416-4d0e-428e-ad7f-36f450ef3ee0","","",false, this);
 
            ToBeCreated = RPSControlFactory.CreateRPSCheckBox<SIISalesPaymentQueryView>("185004d9-2bb3-46c4-8a0d-5790e49454e6","","",false, this);
 
            ToBeChanged = RPSControlFactory.CreateRPSCheckBox<SIISalesPaymentQueryView>("abaabd53-6d42-4959-87aa-3f62722433f9","","",false, this);
 
            ToBeDeleted = RPSControlFactory.CreateRPSCheckBox<SIISalesPaymentQueryView>("6183d92d-0342-44f1-afdc-168db6699cb6","","",false, this);
 
            NoSend = RPSControlFactory.CreateRPSCheckBox<SIISalesPaymentQueryView>("f86c3234-ab7a-4b63-9bac-74d129e542c4","","",false, this);
 
            Deleted = RPSControlFactory.CreateRPSCheckBox<SIISalesPaymentQueryView>("75afb827-9080-4fbf-87c1-4a7f44829062","","",false, this);
 
            SIILoadDataCommandButton = RPSControlFactory.CreateRPSButton<SIISalesPaymentQueryView>( "e53f7a24-5c56-4496-8cf5-fc319eb7e9ac","","",this);
 
            LinkNavigationCommandButton = RPSControlFactory.CreateRPSButton<SIISalesPaymentQueryView>( "ac044215-0398-495a-8331-afc9c9c92256","","",this);
 
            IncludeSalesInvoiceCommandButton = RPSControlFactory.CreateRPSButton<SIISalesPaymentQueryView>( "d9e14ec9-3877-43cb-b323-aecb43029bd5","","",this);
 
            ExcludeSalesInvoiceCommandButton = RPSControlFactory.CreateRPSButton<SIISalesPaymentQueryView>( "afe4595a-24ae-4b74-ba42-59d4467c9347","","",this);
 
            CollectionInit params_SIISalesPayment = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="80c8c30f-d3cf-4902-9a0b-8ea4a063f83d",CSSSelectorGrid="",XPathGrid=""};
            SIISalesPayment = RPSControlFactory.RPSCreateCollectionWithGrid<SIISalesPaymentCollectionEditor<SIISalesPaymentQueryView,SIISalesPaymentSendDialogView>,SIISalesPaymentQueryView,SIISalesPaymentSendDialogView>( params_SIISalesPayment,this,Screen.SIISalesPaymentSendDialogView);
 

        }
        public IRPSTextBox<SIISalesPaymentQueryView> AccountingDateFrom { get; set; } 
        public IRPSTextBox<SIISalesPaymentQueryView> AccountingDateTo { get; set; } 
        public IRPSTextBox<SIISalesPaymentQueryView> InvoiceDateFrom { get; set; } 
        public IRPSTextBox<SIISalesPaymentQueryView> InvoiceDateTo { get; set; } 
        public IRPSCheckbox<SIISalesPaymentQueryView> Sent { get; set; } 
        public IRPSCheckbox<SIISalesPaymentQueryView> PendingCorrection { get; set; } 
        public IRPSCheckbox<SIISalesPaymentQueryView> ToBeCreated { get; set; } 
        public IRPSCheckbox<SIISalesPaymentQueryView> ToBeChanged { get; set; } 
        public IRPSCheckbox<SIISalesPaymentQueryView> ToBeDeleted { get; set; } 
        public IRPSCheckbox<SIISalesPaymentQueryView> NoSend { get; set; } 
        public IRPSCheckbox<SIISalesPaymentQueryView> Deleted { get; set; } 
        public IRPSButton<SIISalesPaymentQueryView> SIILoadDataCommandButton { get; set; } 
        public IRPSButton<SIISalesPaymentQueryView> LinkNavigationCommandButton { get; set; } 
        public IRPSButton<SIISalesPaymentQueryView> IncludeSalesInvoiceCommandButton { get; set; } 
        public IRPSButton<SIISalesPaymentQueryView> ExcludeSalesInvoiceCommandButton { get; set; } 
        public SIISalesPaymentCollectionEditor<SIISalesPaymentQueryView,SIISalesPaymentSendDialogView> SIISalesPayment { get; set; } 
        public SIISalesPayment Screen { get; set; }
        public SIISalesPaymentQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SIISalesPaymentCollectionEditor<SIISalesPaymentQueryView,SIISalesPaymentSendDialogView>:RPSCollectionEditor<SIISalesPaymentQueryView,SIISalesPaymentSendDialogView> where SIISalesPaymentQueryView : class, IView where SIISalesPaymentSendDialogView : class, IView
    {
        public  SIISalesPaymentGridView<SIISalesPaymentQueryView,SIISalesPaymentSendDialogView> GridView {get;set;}
    }
    public partial class SIISalesPaymentGridView <SIISalesPaymentQueryView,SIISalesPaymentSendDialogView> :  RPSGridView<SIISalesPaymentQueryView,SIISalesPaymentSendDialogView> where SIISalesPaymentQueryView : class, IView where SIISalesPaymentSendDialogView : class, IView
    {
        public SIISalesPaymentGridView(SIISalesPaymentQueryView currentView,SIISalesPaymentSendDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodInvoice = RPSControlFactory.CreateRPSGridTextBox<SIISalesPaymentQueryView>("","#80c8c30f-d3cf-4902-9a0b-8ea4a063f83d .ag-row[role='row']@ROWINDEX [col-id='cCodInvoice']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<SIISalesPaymentQueryView>("","#80c8c30f-d3cf-4902-9a0b-8ea4a063f83d .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 
            CustomerName = RPSControlFactory.CreateRPSGridTextBox<SIISalesPaymentQueryView>("","#80c8c30f-d3cf-4902-9a0b-8ea4a063f83d .ag-row[role='row']@ROWINDEX [col-id='cCustomerName']","",false, this.CurrentView);
 
            TaxSalesPayment_AccountingDate = RPSControlFactory.CreateRPSGridTextBox<SIISalesPaymentQueryView>("","#80c8c30f-d3cf-4902-9a0b-8ea4a063f83d .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesPayment_AccountingDate']","",false, this.CurrentView);
 
            TaxSalesPayment_PaidType = RPSControlFactory.CreateRPSGridTextBox<SIISalesPaymentQueryView>("","#80c8c30f-d3cf-4902-9a0b-8ea4a063f83d .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesPayment_PaidType']","",false, this.CurrentView);
 
            TaxSalesPayment_PaidExtension = RPSControlFactory.CreateRPSGridTextBox<SIISalesPaymentQueryView>("","#80c8c30f-d3cf-4902-9a0b-8ea4a063f83d .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesPayment_PaidExtension']","",false, this.CurrentView);
 
            TaxSalesPayment_SentTime = RPSControlFactory.CreateRPSGridTextBox<SIISalesPaymentQueryView>("","#80c8c30f-d3cf-4902-9a0b-8ea4a063f83d .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesPayment_SentTime']","",false, this.CurrentView);
 
            TaxSalesPayment_SentStatus = RPSControlFactory.CreateRPSGridTextBox<SIISalesPaymentQueryView>("","#80c8c30f-d3cf-4902-9a0b-8ea4a063f83d .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesPayment_SentStatus']","",false, this.CurrentView);
 
            TaxSalesPayment_ErrorInfo = RPSControlFactory.CreateRPSGridMemoTextBox<SIISalesPaymentQueryView>("","#80c8c30f-d3cf-4902-9a0b-8ea4a063f83d .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesPayment_ErrorInfo']","",false, this.CurrentView);
 
            TaxSalesPayment_Deletion = RPSControlFactory.CreateRPSGridTextBox<SIISalesPaymentQueryView>("","#80c8c30f-d3cf-4902-9a0b-8ea4a063f83d .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesPayment_Deletion']","",false, this.CurrentView);
 
            TaxSalesPayment_ActionStatus = RPSControlFactory.CreateRPSGridTextBox<SIISalesPaymentQueryView>("","#80c8c30f-d3cf-4902-9a0b-8ea4a063f83d .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesPayment_ActionStatus']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SIISalesPaymentQueryView> CodInvoice { get; set; } 
        public IRPSGridTextBox<SIISalesPaymentQueryView> InvoiceDate { get; set; } 
        public IRPSGridTextBox<SIISalesPaymentQueryView> CustomerName { get; set; } 
        public IRPSGridTextBox<SIISalesPaymentQueryView> TaxSalesPayment_AccountingDate { get; set; } 
        public IRPSGridTextBox<SIISalesPaymentQueryView> TaxSalesPayment_PaidType { get; set; } 
        public IRPSGridTextBox<SIISalesPaymentQueryView> TaxSalesPayment_PaidExtension { get; set; } 
        public IRPSGridTextBox<SIISalesPaymentQueryView> TaxSalesPayment_SentTime { get; set; } 
        public IRPSGridTextBox<SIISalesPaymentQueryView> TaxSalesPayment_SentStatus { get; set; } 
        public IRPSGridTextBox<SIISalesPaymentQueryView> TaxSalesPayment_ErrorInfo { get; set; } 
        public IRPSGridTextBox<SIISalesPaymentQueryView> TaxSalesPayment_Deletion { get; set; } 
        public IRPSGridTextBox<SIISalesPaymentQueryView> TaxSalesPayment_ActionStatus { get; set; } 
                     
    }
 
    }
  
            
    public partial class SIISalesPaymentSendDialogView : View
    {
        public SIISalesPaymentSendDialogView(SIISalesPayment screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SelectedCreated = RPSControlFactory.CreateRPSTextBox<SIISalesPaymentSendDialogView>("911d9f68-5d79-4caa-b68a-5e3f0b9593d3","","",false, this);
 
            SelectedChanged = RPSControlFactory.CreateRPSTextBox<SIISalesPaymentSendDialogView>("daccd975-eab8-4ffd-aa09-ebfc8e8d33d8","","",false, this);
 
            SelectedDeleted = RPSControlFactory.CreateRPSTextBox<SIISalesPaymentSendDialogView>("3d6c303f-f284-4aa3-8b1e-8e6358358b12","","",false, this);
 
            SendCommandButton = RPSControlFactory.CreateRPSButton<SIISalesPaymentSendDialogView>( "0833f611-aaf7-47f2-ad2d-ba1cff30f150","","",this);
 
            CollectionInit params_SIISalesPaymentToBeCreated = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="32fd02d1-6c56-4eb8-9edc-d61e4c7e45bb",CSSSelectorGrid="",XPathGrid=""};
            SIISalesPaymentToBeCreated = RPSControlFactory.RPSCreateCollectionWithGrid<SIISalesPaymentToBeCreatedCollectionEditor<SIISalesPaymentSendDialogView>,SIISalesPaymentSendDialogView>( params_SIISalesPaymentToBeCreated,this);
 
            CollectionInit params_SIISalesPaymentToBeChanged = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="991b0a3e-daf5-4b2c-a4ca-85763ed7c3d2",CSSSelectorGrid="",XPathGrid=""};
            SIISalesPaymentToBeChanged = RPSControlFactory.RPSCreateCollectionWithGrid<SIISalesPaymentToBeChangedCollectionEditor<SIISalesPaymentSendDialogView>,SIISalesPaymentSendDialogView>( params_SIISalesPaymentToBeChanged,this);
 
            CollectionInit params_SIISalesPaymentToBeDeleted = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7a3c521a-2d2b-4712-a88f-8c91bc08e43c",CSSSelectorGrid="",XPathGrid=""};
            SIISalesPaymentToBeDeleted = RPSControlFactory.RPSCreateCollectionWithGrid<SIISalesPaymentToBeDeletedCollectionEditor<SIISalesPaymentSendDialogView>,SIISalesPaymentSendDialogView>( params_SIISalesPaymentToBeDeleted,this);
 
            ToBeCreated = RPSControlFactory.CreateRPSSection<SIISalesPaymentSendDialogView>( "","ul li[rpsid='b076e4e4-6f8a-4b53-b519-852735ee2fbf']","",this);
 
            ToBeChanged = RPSControlFactory.CreateRPSSection<SIISalesPaymentSendDialogView>( "","ul li[rpsid='c96eacb8-54b6-42b3-a4ca-b84f10bc523a']","",this);
 
            ToBeDeleted = RPSControlFactory.CreateRPSSection<SIISalesPaymentSendDialogView>( "","ul li[rpsid='92f20a60-6aa2-4add-891f-7b1aca557b7b']","",this);
 

        }
        public IRPSTextBox<SIISalesPaymentSendDialogView> SelectedCreated { get; set; } 
        public IRPSTextBox<SIISalesPaymentSendDialogView> SelectedChanged { get; set; } 
        public IRPSTextBox<SIISalesPaymentSendDialogView> SelectedDeleted { get; set; } 
        public IRPSButton<SIISalesPaymentSendDialogView> SendCommandButton { get; set; } 
        public SIISalesPaymentToBeCreatedCollectionEditor<SIISalesPaymentSendDialogView> SIISalesPaymentToBeCreated { get; set; } 
        public SIISalesPaymentToBeChangedCollectionEditor<SIISalesPaymentSendDialogView> SIISalesPaymentToBeChanged { get; set; } 
        public SIISalesPaymentToBeDeletedCollectionEditor<SIISalesPaymentSendDialogView> SIISalesPaymentToBeDeleted { get; set; } 
        public IRPSSection<SIISalesPaymentSendDialogView> ToBeCreated { get; set; } 
        public IRPSSection<SIISalesPaymentSendDialogView> ToBeChanged { get; set; } 
        public IRPSSection<SIISalesPaymentSendDialogView> ToBeDeleted { get; set; } 
        public SIISalesPayment Screen { get; set; }
        public SIISalesPaymentSendDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SIISalesPaymentToBeCreatedCollectionEditor<SIISalesPaymentSendDialogView>:RPSCollectionEditor<SIISalesPaymentSendDialogView> where SIISalesPaymentSendDialogView : class, IView
    {
        public  SIISalesPaymentToBeCreatedGridView<SIISalesPaymentSendDialogView> GridView {get;set;}
    }
    public partial class SIISalesPaymentToBeCreatedGridView <SIISalesPaymentSendDialogView> :  RPSGridView<SIISalesPaymentSendDialogView> where SIISalesPaymentSendDialogView : class, IView
    {
        public SIISalesPaymentToBeCreatedGridView(SIISalesPaymentSendDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodInvoice = RPSControlFactory.CreateRPSGridTextBox<SIISalesPaymentSendDialogView>("","#32fd02d1-6c56-4eb8-9edc-d61e4c7e45bb .ag-row[role='row']@ROWINDEX [col-id='cCodInvoice']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<SIISalesPaymentSendDialogView>("","#32fd02d1-6c56-4eb8-9edc-d61e4c7e45bb .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 
            CustomerName = RPSControlFactory.CreateRPSGridTextBox<SIISalesPaymentSendDialogView>("","#32fd02d1-6c56-4eb8-9edc-d61e4c7e45bb .ag-row[role='row']@ROWINDEX [col-id='cCustomerName']","",false, this.CurrentView);
 
            TaxSalesPayment_AccountingDate = RPSControlFactory.CreateRPSGridTextBox<SIISalesPaymentSendDialogView>("","#32fd02d1-6c56-4eb8-9edc-d61e4c7e45bb .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesPayment_AccountingDate']","",false, this.CurrentView);
 
            TaxSalesPayment_PaidType = RPSControlFactory.CreateRPSGridTextBox<SIISalesPaymentSendDialogView>("","#32fd02d1-6c56-4eb8-9edc-d61e4c7e45bb .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesPayment_PaidType']","",false, this.CurrentView);
 
            TaxSalesPayment_PaidExtension = RPSControlFactory.CreateRPSGridTextBox<SIISalesPaymentSendDialogView>("","#32fd02d1-6c56-4eb8-9edc-d61e4c7e45bb .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesPayment_PaidExtension']","",false, this.CurrentView);
 
            TaxSalesPayment_SentTime = RPSControlFactory.CreateRPSGridTextBox<SIISalesPaymentSendDialogView>("","#32fd02d1-6c56-4eb8-9edc-d61e4c7e45bb .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesPayment_SentTime']","",false, this.CurrentView);
 
            TaxSalesPayment_SentStatus = RPSControlFactory.CreateRPSGridTextBox<SIISalesPaymentSendDialogView>("","#32fd02d1-6c56-4eb8-9edc-d61e4c7e45bb .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesPayment_SentStatus']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SIISalesPaymentSendDialogView> CodInvoice { get; set; } 
        public IRPSGridTextBox<SIISalesPaymentSendDialogView> InvoiceDate { get; set; } 
        public IRPSGridTextBox<SIISalesPaymentSendDialogView> CustomerName { get; set; } 
        public IRPSGridTextBox<SIISalesPaymentSendDialogView> TaxSalesPayment_AccountingDate { get; set; } 
        public IRPSGridTextBox<SIISalesPaymentSendDialogView> TaxSalesPayment_PaidType { get; set; } 
        public IRPSGridTextBox<SIISalesPaymentSendDialogView> TaxSalesPayment_PaidExtension { get; set; } 
        public IRPSGridTextBox<SIISalesPaymentSendDialogView> TaxSalesPayment_SentTime { get; set; } 
        public IRPSGridTextBox<SIISalesPaymentSendDialogView> TaxSalesPayment_SentStatus { get; set; } 
                     
    }
 
        public partial class SIISalesPaymentToBeChangedCollectionEditor<SIISalesPaymentSendDialogView>:RPSCollectionEditor<SIISalesPaymentSendDialogView> where SIISalesPaymentSendDialogView : class, IView
    {
        public  SIISalesPaymentToBeChangedGridView<SIISalesPaymentSendDialogView> GridView {get;set;}
    }
    public partial class SIISalesPaymentToBeChangedGridView <SIISalesPaymentSendDialogView> :  RPSGridView<SIISalesPaymentSendDialogView> where SIISalesPaymentSendDialogView : class, IView
    {
        public SIISalesPaymentToBeChangedGridView(SIISalesPaymentSendDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodInvoice = RPSControlFactory.CreateRPSGridTextBox<SIISalesPaymentSendDialogView>("","#991b0a3e-daf5-4b2c-a4ca-85763ed7c3d2 .ag-row[role='row']@ROWINDEX [col-id='cCodInvoice']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<SIISalesPaymentSendDialogView>("","#991b0a3e-daf5-4b2c-a4ca-85763ed7c3d2 .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 
            CustomerName = RPSControlFactory.CreateRPSGridTextBox<SIISalesPaymentSendDialogView>("","#991b0a3e-daf5-4b2c-a4ca-85763ed7c3d2 .ag-row[role='row']@ROWINDEX [col-id='cCustomerName']","",false, this.CurrentView);
 
            TaxSalesPayment_AccountingDate = RPSControlFactory.CreateRPSGridTextBox<SIISalesPaymentSendDialogView>("","#991b0a3e-daf5-4b2c-a4ca-85763ed7c3d2 .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesPayment_AccountingDate']","",false, this.CurrentView);
 
            TaxSalesPayment_PaidType = RPSControlFactory.CreateRPSGridTextBox<SIISalesPaymentSendDialogView>("","#991b0a3e-daf5-4b2c-a4ca-85763ed7c3d2 .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesPayment_PaidType']","",false, this.CurrentView);
 
            TaxSalesPayment_PaidExtension = RPSControlFactory.CreateRPSGridTextBox<SIISalesPaymentSendDialogView>("","#991b0a3e-daf5-4b2c-a4ca-85763ed7c3d2 .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesPayment_PaidExtension']","",false, this.CurrentView);
 
            TaxSalesPayment_SentTime = RPSControlFactory.CreateRPSGridTextBox<SIISalesPaymentSendDialogView>("","#991b0a3e-daf5-4b2c-a4ca-85763ed7c3d2 .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesPayment_SentTime']","",false, this.CurrentView);
 
            TaxSalesPayment_SentStatus = RPSControlFactory.CreateRPSGridTextBox<SIISalesPaymentSendDialogView>("","#991b0a3e-daf5-4b2c-a4ca-85763ed7c3d2 .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesPayment_SentStatus']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SIISalesPaymentSendDialogView> CodInvoice { get; set; } 
        public IRPSGridTextBox<SIISalesPaymentSendDialogView> InvoiceDate { get; set; } 
        public IRPSGridTextBox<SIISalesPaymentSendDialogView> CustomerName { get; set; } 
        public IRPSGridTextBox<SIISalesPaymentSendDialogView> TaxSalesPayment_AccountingDate { get; set; } 
        public IRPSGridTextBox<SIISalesPaymentSendDialogView> TaxSalesPayment_PaidType { get; set; } 
        public IRPSGridTextBox<SIISalesPaymentSendDialogView> TaxSalesPayment_PaidExtension { get; set; } 
        public IRPSGridTextBox<SIISalesPaymentSendDialogView> TaxSalesPayment_SentTime { get; set; } 
        public IRPSGridTextBox<SIISalesPaymentSendDialogView> TaxSalesPayment_SentStatus { get; set; } 
                     
    }
 
        public partial class SIISalesPaymentToBeDeletedCollectionEditor<SIISalesPaymentSendDialogView>:RPSCollectionEditor<SIISalesPaymentSendDialogView> where SIISalesPaymentSendDialogView : class, IView
    {
        public  SIISalesPaymentToBeDeletedGridView<SIISalesPaymentSendDialogView> GridView {get;set;}
    }
    public partial class SIISalesPaymentToBeDeletedGridView <SIISalesPaymentSendDialogView> :  RPSGridView<SIISalesPaymentSendDialogView> where SIISalesPaymentSendDialogView : class, IView
    {
        public SIISalesPaymentToBeDeletedGridView(SIISalesPaymentSendDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodInvoice = RPSControlFactory.CreateRPSGridTextBox<SIISalesPaymentSendDialogView>("","#7a3c521a-2d2b-4712-a88f-8c91bc08e43c .ag-row[role='row']@ROWINDEX [col-id='cCodInvoice']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<SIISalesPaymentSendDialogView>("","#7a3c521a-2d2b-4712-a88f-8c91bc08e43c .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 
            CustomerName = RPSControlFactory.CreateRPSGridTextBox<SIISalesPaymentSendDialogView>("","#7a3c521a-2d2b-4712-a88f-8c91bc08e43c .ag-row[role='row']@ROWINDEX [col-id='cCustomerName']","",false, this.CurrentView);
 
            TaxSalesPayment_AccountingDate = RPSControlFactory.CreateRPSGridTextBox<SIISalesPaymentSendDialogView>("","#7a3c521a-2d2b-4712-a88f-8c91bc08e43c .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesPayment_AccountingDate']","",false, this.CurrentView);
 
            TaxSalesPayment_PaidType = RPSControlFactory.CreateRPSGridTextBox<SIISalesPaymentSendDialogView>("","#7a3c521a-2d2b-4712-a88f-8c91bc08e43c .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesPayment_PaidType']","",false, this.CurrentView);
 
            TaxSalesPayment_PaidExtension = RPSControlFactory.CreateRPSGridTextBox<SIISalesPaymentSendDialogView>("","#7a3c521a-2d2b-4712-a88f-8c91bc08e43c .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesPayment_PaidExtension']","",false, this.CurrentView);
 
            TaxSalesPayment_SentTime = RPSControlFactory.CreateRPSGridTextBox<SIISalesPaymentSendDialogView>("","#7a3c521a-2d2b-4712-a88f-8c91bc08e43c .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesPayment_SentTime']","",false, this.CurrentView);
 
            TaxSalesPayment_SentStatus = RPSControlFactory.CreateRPSGridTextBox<SIISalesPaymentSendDialogView>("","#7a3c521a-2d2b-4712-a88f-8c91bc08e43c .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesPayment_SentStatus']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SIISalesPaymentSendDialogView> CodInvoice { get; set; } 
        public IRPSGridTextBox<SIISalesPaymentSendDialogView> InvoiceDate { get; set; } 
        public IRPSGridTextBox<SIISalesPaymentSendDialogView> CustomerName { get; set; } 
        public IRPSGridTextBox<SIISalesPaymentSendDialogView> TaxSalesPayment_AccountingDate { get; set; } 
        public IRPSGridTextBox<SIISalesPaymentSendDialogView> TaxSalesPayment_PaidType { get; set; } 
        public IRPSGridTextBox<SIISalesPaymentSendDialogView> TaxSalesPayment_PaidExtension { get; set; } 
        public IRPSGridTextBox<SIISalesPaymentSendDialogView> TaxSalesPayment_SentTime { get; set; } 
        public IRPSGridTextBox<SIISalesPaymentSendDialogView> TaxSalesPayment_SentStatus { get; set; } 
                     
    }
 
    }
  
    

}