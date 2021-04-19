    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.PreviousDateBalances
{
    //RPS VERSION 1.0.0.0
    public partial class PreviousDateBalances:Screen
    {
        public PreviousDateBalances():base()
        {
            this.URL = "generalledger.previousdatebalances";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            PreviousDateBalancesQueryView  = new PreviousDateBalancesQueryView(this); 
            PreviousDateBalancesQueryView.InitializeControls(); 
           
        }
      
            public PreviousDateBalancesQueryView PreviousDateBalancesQueryView {get; set; } 
    }
            
    public partial class PreviousDateBalancesQueryView : View
    {
        public PreviousDateBalancesQueryView(PreviousDateBalances screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            bCustomers = RPSControlFactory.CreateRPSCheckBox<PreviousDateBalancesQueryView>("0df12e08-47c8-45c8-8327-13f44f4dec19","","",false, this);
 
            bSuppliers = RPSControlFactory.CreateRPSCheckBox<PreviousDateBalancesQueryView>("b60adc23-2810-4ba3-99f1-290d546fe8a6","","",false, this);
 
            IDCustomers = RPSControlFactory.CreateRPSCollectionComboBox<PreviousDateBalancesQueryView>("55ed5eab-833d-4f1b-a0b6-28a0c507efbb","","",false, this);
 
            IDSuppliers = RPSControlFactory.CreateRPSCollectionComboBox<PreviousDateBalancesQueryView>("6cceea6e-0742-4344-a454-01006b981154","","",false, this);
 
            ReportDate = RPSControlFactory.CreateRPSTextBox<PreviousDateBalancesQueryView>("4abee76a-a3f3-4173-8e54-e26e733567a8","","",false, this);
 
            OnlyPendingInvoices = RPSControlFactory.CreateRPSCheckBox<PreviousDateBalancesQueryView>("2b94663f-0db9-4c8e-acd4-02629a995b55","","",false, this);
 
            OnlyActiveThirds = RPSControlFactory.CreateRPSCheckBox<PreviousDateBalancesQueryView>("e5d04278-0480-4313-8828-82fe89268d0f","","",false, this);
 
            ActiveThirdsFromDate = RPSControlFactory.CreateRPSTextBox<PreviousDateBalancesQueryView>("aadb3a4b-7eb7-4f85-9598-d5ba82ffa1da","","",false, this);
 
            Type = RPSControlFactory.CreateRPSTextBox<PreviousDateBalancesQueryView>("50dccc91-c18a-4d89-9646-5f444e999fe9","","",false, this);
 
            InvoiceDate = RPSControlFactory.CreateRPSTextBox<PreviousDateBalancesQueryView>("0d84ffef-1fad-4f39-a0d3-99d902f9a1ee","","",false, this);
 
            Type1 = RPSControlFactory.CreateRPSTextBox<PreviousDateBalancesQueryView>("e86e2288-e2bc-4afd-8dd2-a23519eff6e2","","",false, this);
 
            InvoiceDate1 = RPSControlFactory.CreateRPSTextBox<PreviousDateBalancesQueryView>("b51ce6b5-5509-4c65-8479-e7b325c4bae7","","",false, this);
 
            CollectionInit params_GetInvoiceDetailACC = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="65496a69-6e97-4d91-9d1b-5f8ff25ffdaa",CSSSelectorGrid="",XPathGrid=""};
            GetInvoiceDetailACC = RPSControlFactory.RPSCreateCollectionWithGrid<GetInvoiceDetailACCCollectionEditor<PreviousDateBalancesQueryView>,PreviousDateBalancesQueryView>( params_GetInvoiceDetailACC,this);
 
            CollectionInit params_GetInvoiceDetailARP = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a5426ffc-c53a-48ba-a687-4ab32be4983f",CSSSelectorGrid="",XPathGrid=""};
            GetInvoiceDetailARP = RPSControlFactory.RPSCreateCollectionWithGrid<GetInvoiceDetailARPCollectionEditor<PreviousDateBalancesQueryView>,PreviousDateBalancesQueryView>( params_GetInvoiceDetailARP,this);
 
            SectionVouchers = RPSControlFactory.CreateRPSSection<PreviousDateBalancesQueryView>( "","ul li[rpsid='136d27b7-7540-4062-a05c-f7db4f907b05']","",this);
 
            SectionDrafts = RPSControlFactory.CreateRPSSection<PreviousDateBalancesQueryView>( "","ul li[rpsid='efe16de0-9912-40e8-8c9a-8cf0b121115d']","",this);
 

        }
        public IRPSCheckbox<PreviousDateBalancesQueryView> bCustomers { get; set; } 
        public IRPSCheckbox<PreviousDateBalancesQueryView> bSuppliers { get; set; } 
        public IRPSCollectionComboBox<PreviousDateBalancesQueryView> IDCustomers { get; set; } 
        public IRPSCollectionComboBox<PreviousDateBalancesQueryView> IDSuppliers { get; set; } 
        public IRPSTextBox<PreviousDateBalancesQueryView> ReportDate { get; set; } 
        public IRPSCheckbox<PreviousDateBalancesQueryView> OnlyPendingInvoices { get; set; } 
        public IRPSCheckbox<PreviousDateBalancesQueryView> OnlyActiveThirds { get; set; } 
        public IRPSTextBox<PreviousDateBalancesQueryView> ActiveThirdsFromDate { get; set; } 
        public IRPSTextBox<PreviousDateBalancesQueryView> Type { get; set; } 
        public IRPSTextBox<PreviousDateBalancesQueryView> InvoiceDate { get; set; } 
        public IRPSTextBox<PreviousDateBalancesQueryView> Type1 { get; set; } 
        public IRPSTextBox<PreviousDateBalancesQueryView> InvoiceDate1 { get; set; } 
        public GetInvoiceDetailACCCollectionEditor<PreviousDateBalancesQueryView> GetInvoiceDetailACC { get; set; } 
        public GetInvoiceDetailARPCollectionEditor<PreviousDateBalancesQueryView> GetInvoiceDetailARP { get; set; } 
        public IRPSSection<PreviousDateBalancesQueryView> SectionVouchers { get; set; } 
        public IRPSSection<PreviousDateBalancesQueryView> SectionDrafts { get; set; } 
        public PreviousDateBalances Screen { get; set; }
        public PreviousDateBalancesQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetInvoiceDetailACCCollectionEditor<PreviousDateBalancesQueryView>:RPSCollectionEditor<PreviousDateBalancesQueryView> where PreviousDateBalancesQueryView : class, IView
    {
        public  GetInvoiceDetailACCGridView<PreviousDateBalancesQueryView> GridView {get;set;}
    }
    public partial class GetInvoiceDetailACCGridView <PreviousDateBalancesQueryView> :  RPSGridView<PreviousDateBalancesQueryView> where PreviousDateBalancesQueryView : class, IView
    {
        public GetInvoiceDetailACCGridView(PreviousDateBalancesQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            VoucherNumber = RPSControlFactory.CreateRPSGridFormattedTextBox<PreviousDateBalancesQueryView>("","#65496a69-6e97-4d91-9d1b-5f8ff25ffdaa .ag-row[role='row']@ROWINDEX [col-id='cVoucherNumber']","",false, this.CurrentView);
 
            AccountingDate = RPSControlFactory.CreateRPSGridTextBox<PreviousDateBalancesQueryView>("","#65496a69-6e97-4d91-9d1b-5f8ff25ffdaa .ag-row[role='row']@ROWINDEX [col-id='cAccountingDate']","",false, this.CurrentView);
 
            Extension = RPSControlFactory.CreateRPSGridTextBox<PreviousDateBalancesQueryView>("","#65496a69-6e97-4d91-9d1b-5f8ff25ffdaa .ag-row[role='row']@ROWINDEX [col-id='cExtension']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<PreviousDateBalancesQueryView> VoucherNumber { get; set; } 
        public IRPSGridTextBox<PreviousDateBalancesQueryView> AccountingDate { get; set; } 
        public IRPSGridTextBox<PreviousDateBalancesQueryView> Extension { get; set; } 
                     
    }
 
        public partial class GetInvoiceDetailARPCollectionEditor<PreviousDateBalancesQueryView>:RPSCollectionEditor<PreviousDateBalancesQueryView> where PreviousDateBalancesQueryView : class, IView
    {
        public  GetInvoiceDetailARPGridView<PreviousDateBalancesQueryView> GridView {get;set;}
    }
    public partial class GetInvoiceDetailARPGridView <PreviousDateBalancesQueryView> :  RPSGridView<PreviousDateBalancesQueryView> where PreviousDateBalancesQueryView : class, IView
    {
        public GetInvoiceDetailARPGridView(PreviousDateBalancesQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DueDate = RPSControlFactory.CreateRPSGridTextBox<PreviousDateBalancesQueryView>("","#a5426ffc-c53a-48ba-a687-4ab32be4983f .ag-row[role='row']@ROWINDEX [col-id='cDueDate']","",false, this.CurrentView);
 
            PaymentDate = RPSControlFactory.CreateRPSGridTextBox<PreviousDateBalancesQueryView>("","#a5426ffc-c53a-48ba-a687-4ab32be4983f .ag-row[role='row']@ROWINDEX [col-id='cPaymentDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<PreviousDateBalancesQueryView> DueDate { get; set; } 
        public IRPSGridTextBox<PreviousDateBalancesQueryView> PaymentDate { get; set; } 
                     
    }
 
    }
  
    

}