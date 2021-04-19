    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.SalesLedger
{
    //RPS VERSION 1.0.0.0
    public partial class SalesLedger:Screen
    {
        public SalesLedger():base()
        {
            this.URL = "generalledger.salesledger";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SalesLedgerView  = new SalesLedgerView(this); 
            PrintChildDialogView  = new PrintChildDialogView(this); 
            SalesLedgerView.InitializeControls(); 
            PrintChildDialogView.InitializeControls(); 
           
        }
      
            public SalesLedgerView SalesLedgerView {get; set; } 
            public PrintChildDialogView PrintChildDialogView {get; set; } 
    }
            
    public partial class SalesLedgerView : View
    {
        public SalesLedgerView(SalesLedger screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            AccountingDateFrom = RPSControlFactory.CreateRPSTextBox<SalesLedgerView>("8911fc18-c2d3-474c-bb77-f1b1c8ee58a8","","",false, this);
 
            AccountingDateTo = RPSControlFactory.CreateRPSTextBox<SalesLedgerView>("0509c31f-2c17-4293-869d-5f3a203e42d4","","",false, this);
 
            bNullified = RPSControlFactory.CreateRPSCheckBox<SalesLedgerView>("e59c4020-e9c6-4863-a288-0a742eff733f","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<SalesLedgerView>("8aee4c56-7f45-4a7e-a31c-29eb411a4e43","","",false, this);
 
            IDVoucherTypes = RPSControlFactory.CreateRPSCollectionComboBox<SalesLedgerView>("88dbedf1-37bb-4907-b600-09b1f607234f","","",false, this);
 
            IDVATs = RPSControlFactory.CreateRPSCollectionComboBox<SalesLedgerView>("dc86d48f-5f1b-4b56-8848-7f89d0daf241","","",false, this);
 
            bnvoices = RPSControlFactory.CreateRPSCheckBox<SalesLedgerView>("58335223-9cdb-4b1e-9bcf-bd52ec7288f9","","",false, this);
 
            bCreditNotes = RPSControlFactory.CreateRPSCheckBox<SalesLedgerView>("270ae573-3345-40fb-bfa2-26140fe00c9a","","",false, this);
 
            bDebitNotes = RPSControlFactory.CreateRPSCheckBox<SalesLedgerView>("82fd8d5b-6fd8-48b0-bddb-b5e21a8ec118","","",false, this);
 
            bAutoInvoices = RPSControlFactory.CreateRPSCheckBox<SalesLedgerView>("67c771a7-5a91-4ceb-b934-985a162f2bfe","","",false, this);
 
            AcceptCommand = RPSControlFactory.CreateRPSButton<SalesLedgerView>( "0c1a7663-af98-4334-878e-f7ea5635f7dc","","",this);
 
            VATAPARRegNo = RPSControlFactory.CreateRPSFormattedTextBox<SalesLedgerView>("dd0adb04-5b5a-4557-94f2-cf1b3b550bdc","","",false, this);
 
            SequenceNumber = RPSControlFactory.CreateRPSFormattedTextBox<SalesLedgerView>("eeb8664a-cf8d-4e1f-b315-03d4a59fed0a","","",false, this);
 
            InvoiceDate = RPSControlFactory.CreateRPSTextBox<SalesLedgerView>("ba006b2b-f509-4644-8fdf-67608230e639","","",false, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<SalesLedgerView>("7af863a0-4188-4bbb-afab-1cf8e1c56390","","",false, this);
 
            CompanyName = RPSControlFactory.CreateRPSTextBox<SalesLedgerView>("11896cbc-e05f-4601-bc47-b73dc176c7a2","","",false, this);
 
            RCVATNumber = RPSControlFactory.CreateRPSTextBox<SalesLedgerView>("1fef0ca2-fd6d-4d75-a597-467ddb4074d1","","",false, this);
 
            RCCompanyName = RPSControlFactory.CreateRPSTextBox<SalesLedgerView>("b4c59446-2509-440c-b87b-67aedfc60ddf","","",false, this);
 
            Nullified = RPSControlFactory.CreateRPSCheckBox<SalesLedgerView>("e04c5d85-e4d2-4c43-89ad-f5e99a2fa8ae","","",false, this);
 
            DeliveryNote = RPSControlFactory.CreateRPSTextBox<SalesLedgerView>("aa79d965-847f-4440-9fb9-6ac06eecf5c3","","",false, this);
 
            DeliveryNoteDate = RPSControlFactory.CreateRPSTextBox<SalesLedgerView>("09ada171-141d-4afd-8355-51b1f02ec16a","","",false, this);
 
            PrintChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<SalesLedgerView,PrintChildDialogView>("341cdb97-adb0-4316-82db-0c7aceed5790","","", this,Screen.PrintChildDialogView);
 
            CollectionInit params_GetLedgerInvoicesFromStorageKey = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="fb5add7c-01ff-4f44-a1ef-d97af7c5bb5c",CSSSelectorGrid="",XPathGrid=""};
            GetLedgerInvoicesFromStorageKey = RPSControlFactory.RPSCreateCollectionWithGrid<GetLedgerInvoicesFromStorageKeyCollectionEditor<SalesLedgerView,PrintChildDialogView>,SalesLedgerView,PrintChildDialogView>( params_GetLedgerInvoicesFromStorageKey,this,Screen.PrintChildDialogView);
 
            CollectionInit params_GetLedgerVATsFromStorageKey = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c7945fd6-4d03-4dd3-96e0-d16db052d3e6",CSSSelectorGrid="",XPathGrid=""};
            GetLedgerVATsFromStorageKey = RPSControlFactory.RPSCreateCollectionWithGrid<GetLedgerVATsFromStorageKeyCollectionEditor<SalesLedgerView,PrintChildDialogView>,SalesLedgerView,PrintChildDialogView>( params_GetLedgerVATsFromStorageKey,this,Screen.PrintChildDialogView);
 
            CollectionInit params_GetLedgerVoucherTypesFromStorageKey = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3ee02125-abe3-46a4-b811-c0913e5e3794",CSSSelectorGrid="",XPathGrid=""};
            GetLedgerVoucherTypesFromStorageKey = RPSControlFactory.RPSCreateCollectionWithGrid<GetLedgerVoucherTypesFromStorageKeyCollectionEditor<SalesLedgerView,PrintChildDialogView>,SalesLedgerView,PrintChildDialogView>( params_GetLedgerVoucherTypesFromStorageKey,this,Screen.PrintChildDialogView);
 
            SectionInvoices = RPSControlFactory.CreateRPSSection<SalesLedgerView>( "","ul li[rpsid='fef4eb31-8df2-4410-975a-fe0c8532b7a4']","",this);
 
            SectionVats = RPSControlFactory.CreateRPSSection<SalesLedgerView>( "","ul li[rpsid='9f8bf86e-ed36-4965-a833-acb6a35a46a3']","",this);
 
            SectionVoucherTypes = RPSControlFactory.CreateRPSSection<SalesLedgerView>( "","ul li[rpsid='f7dbdd29-b8a8-450d-8394-634fc9a4d808']","",this);
 

        }
        public IRPSTextBox<SalesLedgerView> AccountingDateFrom { get; set; } 
        public IRPSTextBox<SalesLedgerView> AccountingDateTo { get; set; } 
        public IRPSCheckbox<SalesLedgerView> bNullified { get; set; } 
        public IRPSComboBox<SalesLedgerView> IDCustomer { get; set; } 
        public IRPSCollectionComboBox<SalesLedgerView> IDVoucherTypes { get; set; } 
        public IRPSCollectionComboBox<SalesLedgerView> IDVATs { get; set; } 
        public IRPSCheckbox<SalesLedgerView> bnvoices { get; set; } 
        public IRPSCheckbox<SalesLedgerView> bCreditNotes { get; set; } 
        public IRPSCheckbox<SalesLedgerView> bDebitNotes { get; set; } 
        public IRPSCheckbox<SalesLedgerView> bAutoInvoices { get; set; } 
        public IRPSButton<SalesLedgerView> AcceptCommand { get; set; } 
        public IRPSTextBox<SalesLedgerView> VATAPARRegNo { get; set; } 
        public IRPSTextBox<SalesLedgerView> SequenceNumber { get; set; } 
        public IRPSTextBox<SalesLedgerView> InvoiceDate { get; set; } 
        public IRPSTextBox<SalesLedgerView> VATNumber { get; set; } 
        public IRPSTextBox<SalesLedgerView> CompanyName { get; set; } 
        public IRPSTextBox<SalesLedgerView> RCVATNumber { get; set; } 
        public IRPSTextBox<SalesLedgerView> RCCompanyName { get; set; } 
        public IRPSCheckbox<SalesLedgerView> Nullified { get; set; } 
        public IRPSTextBox<SalesLedgerView> DeliveryNote { get; set; } 
        public IRPSTextBox<SalesLedgerView> DeliveryNoteDate { get; set; } 
        public IRPSButton<SalesLedgerView,PrintChildDialogView> PrintChildNavigationCommandButton { get; set; } 
        public GetLedgerInvoicesFromStorageKeyCollectionEditor<SalesLedgerView,PrintChildDialogView> GetLedgerInvoicesFromStorageKey { get; set; } 
        public GetLedgerVATsFromStorageKeyCollectionEditor<SalesLedgerView,PrintChildDialogView> GetLedgerVATsFromStorageKey { get; set; } 
        public GetLedgerVoucherTypesFromStorageKeyCollectionEditor<SalesLedgerView,PrintChildDialogView> GetLedgerVoucherTypesFromStorageKey { get; set; } 
        public IRPSSection<SalesLedgerView> SectionInvoices { get; set; } 
        public IRPSSection<SalesLedgerView> SectionVats { get; set; } 
        public IRPSSection<SalesLedgerView> SectionVoucherTypes { get; set; } 
        public SalesLedger Screen { get; set; }
        public SalesLedgerView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetLedgerInvoicesFromStorageKeyCollectionEditor<SalesLedgerView,PrintChildDialogView>:RPSCollectionEditor<SalesLedgerView,PrintChildDialogView> where SalesLedgerView : class, IView where PrintChildDialogView : class, IView
    {
        public  GetLedgerInvoicesFromStorageKeyGridView<SalesLedgerView,PrintChildDialogView> GridView {get;set;}
    }
    public partial class GetLedgerInvoicesFromStorageKeyGridView <SalesLedgerView,PrintChildDialogView> :  RPSGridView<SalesLedgerView,PrintChildDialogView> where SalesLedgerView : class, IView where PrintChildDialogView : class, IView
    {
        public GetLedgerInvoicesFromStorageKeyGridView(SalesLedgerView currentView,PrintChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            VATAPARRegNo = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesLedgerView>("","#fb5add7c-01ff-4f44-a1ef-d97af7c5bb5c .ag-row[role='row']@ROWINDEX [col-id='cVATAPARRegNo']","",false, this.CurrentView);
 
            SequenceNumber = RPSControlFactory.CreateRPSGridFormattedTextBox<SalesLedgerView>("","#fb5add7c-01ff-4f44-a1ef-d97af7c5bb5c .ag-row[role='row']@ROWINDEX [col-id='cSequenceNumber']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<SalesLedgerView>("","#fb5add7c-01ff-4f44-a1ef-d97af7c5bb5c .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 
            CompanyName = RPSControlFactory.CreateRPSGridTextBox<SalesLedgerView>("","#fb5add7c-01ff-4f44-a1ef-d97af7c5bb5c .ag-row[role='row']@ROWINDEX [col-id='cCompanyName']","",false, this.CurrentView);
 
            VATNumber = RPSControlFactory.CreateRPSGridTextBox<SalesLedgerView>("","#fb5add7c-01ff-4f44-a1ef-d97af7c5bb5c .ag-row[role='row']@ROWINDEX [col-id='cVATNumber']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SalesLedgerView> VATAPARRegNo { get; set; } 
        public IRPSGridTextBox<SalesLedgerView> SequenceNumber { get; set; } 
        public IRPSGridTextBox<SalesLedgerView> InvoiceDate { get; set; } 
        public IRPSGridTextBox<SalesLedgerView> CompanyName { get; set; } 
        public IRPSGridTextBox<SalesLedgerView> VATNumber { get; set; } 
                     
    }
 
        public partial class GetLedgerVATsFromStorageKeyCollectionEditor<SalesLedgerView,PrintChildDialogView>:RPSCollectionEditor<SalesLedgerView,PrintChildDialogView> where SalesLedgerView : class, IView where PrintChildDialogView : class, IView
    {
        public  GetLedgerVATsFromStorageKeyGridView<SalesLedgerView,PrintChildDialogView> GridView {get;set;}
    }
    public partial class GetLedgerVATsFromStorageKeyGridView <SalesLedgerView,PrintChildDialogView> :  RPSGridView<SalesLedgerView,PrintChildDialogView> where SalesLedgerView : class, IView where PrintChildDialogView : class, IView
    {
        public GetLedgerVATsFromStorageKeyGridView(SalesLedgerView currentView,PrintChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {

        }
                     
    }
 
        public partial class GetLedgerVoucherTypesFromStorageKeyCollectionEditor<SalesLedgerView,PrintChildDialogView>:RPSCollectionEditor<SalesLedgerView,PrintChildDialogView> where SalesLedgerView : class, IView where PrintChildDialogView : class, IView
    {
        public  GetLedgerVoucherTypesFromStorageKeyGridView<SalesLedgerView,PrintChildDialogView> GridView {get;set;}
    }
    public partial class GetLedgerVoucherTypesFromStorageKeyGridView <SalesLedgerView,PrintChildDialogView> :  RPSGridView<SalesLedgerView,PrintChildDialogView> where SalesLedgerView : class, IView where PrintChildDialogView : class, IView
    {
        public GetLedgerVoucherTypesFromStorageKeyGridView(SalesLedgerView currentView,PrintChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {

        }
                     
    }
 
    }
  
            
    public partial class PrintChildDialogView : View
    {
        public PrintChildDialogView(SalesLedger screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DateReport = RPSControlFactory.CreateRPSTextBox<PrintChildDialogView>("081c1f0a-a7ea-49a6-83ab-250d690d6268","","",false, this);
 
            bInvoices = RPSControlFactory.CreateRPSCheckBox<PrintChildDialogView>("82a52dd6-989d-47f2-9ec9-42a96aac599f","","",false, this);
 
            bVat = RPSControlFactory.CreateRPSCheckBox<PrintChildDialogView>("a74d5b3d-052d-4b98-a301-5369bd63e432","","",false, this);
 
            bVoucher = RPSControlFactory.CreateRPSCheckBox<PrintChildDialogView>("590c7879-6031-4723-86c4-f3d7e4e62867","","",false, this);
 

        }
        public IRPSTextBox<PrintChildDialogView> DateReport { get; set; } 
        public IRPSCheckbox<PrintChildDialogView> bInvoices { get; set; } 
        public IRPSCheckbox<PrintChildDialogView> bVat { get; set; } 
        public IRPSCheckbox<PrintChildDialogView> bVoucher { get; set; } 
        public SalesLedger Screen { get; set; }
        public PrintChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}