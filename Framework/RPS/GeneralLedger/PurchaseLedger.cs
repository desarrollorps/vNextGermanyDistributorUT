    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.PurchaseLedger
{
    //RPS VERSION 1.0.0.0
    public partial class PurchaseLedger:Screen
    {
        public PurchaseLedger():base()
        {
            this.URL = "generalledger.purchaseledger";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            PurchaseLedgerView  = new PurchaseLedgerView(this); 
            PrintChildDialogView  = new PrintChildDialogView(this); 
            PurchaseLedgerView.InitializeControls(); 
            PrintChildDialogView.InitializeControls(); 
           
        }
      
            public PurchaseLedgerView PurchaseLedgerView {get; set; } 
            public PrintChildDialogView PrintChildDialogView {get; set; } 
    }
            
    public partial class PurchaseLedgerView : View
    {
        public PurchaseLedgerView(PurchaseLedger screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            AccountingDateFrom = RPSControlFactory.CreateRPSTextBox<PurchaseLedgerView>("8911fc18-c2d3-474c-bb77-f1b1c8ee58a8","","",false, this);
 
            AccountingDateTo = RPSControlFactory.CreateRPSTextBox<PurchaseLedgerView>("0509c31f-2c17-4293-869d-5f3a203e42d4","","",false, this);
 
            bNullified = RPSControlFactory.CreateRPSCheckBox<PurchaseLedgerView>("e59c4020-e9c6-4863-a288-0a742eff733f","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<PurchaseLedgerView>("05fb7634-b0d5-470a-9a1a-421e1d68809b","","",false, this);
 
            IDVoucherTypes = RPSControlFactory.CreateRPSCollectionComboBox<PurchaseLedgerView>("88dbedf1-37bb-4907-b600-09b1f607234f","","",false, this);
 
            IDVATs = RPSControlFactory.CreateRPSCollectionComboBox<PurchaseLedgerView>("8b35f0ba-a3cf-4c40-8483-f74c82ab3237","","",false, this);
 
            bnvoices = RPSControlFactory.CreateRPSCheckBox<PurchaseLedgerView>("58335223-9cdb-4b1e-9bcf-bd52ec7288f9","","",false, this);
 
            bCreditNotes = RPSControlFactory.CreateRPSCheckBox<PurchaseLedgerView>("270ae573-3345-40fb-bfa2-26140fe00c9a","","",false, this);
 
            bDebitNotes = RPSControlFactory.CreateRPSCheckBox<PurchaseLedgerView>("82fd8d5b-6fd8-48b0-bddb-b5e21a8ec118","","",false, this);
 
            AcceptCommand = RPSControlFactory.CreateRPSButton<PurchaseLedgerView>( "0c1a7663-af98-4334-878e-f7ea5635f7dc","","",this);
 
            VATAPAPRegNo = RPSControlFactory.CreateRPSFormattedTextBox<PurchaseLedgerView>("85086fb0-d5fb-4d93-9dfe-f92a1ddfc222","","",false, this);
 
            SequenceNumber = RPSControlFactory.CreateRPSFormattedTextBox<PurchaseLedgerView>("16e28273-34a0-43fe-afc5-7f15e74b3272","","",false, this);
 
            InvoiceDate = RPSControlFactory.CreateRPSTextBox<PurchaseLedgerView>("1d076246-f7d0-42dd-8bb9-2b8cf6ff4424","","",false, this);
 
            DUAGroup = RPSControlFactory.CreateRPSTextBox<PurchaseLedgerView>("16c567e4-aff5-406d-9bcf-9e872ca2b3c3","","",false, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<PurchaseLedgerView>("c76f49df-342d-408c-8674-b46950a822ad","","",false, this);
 
            CompanyName = RPSControlFactory.CreateRPSTextBox<PurchaseLedgerView>("a75d5461-d051-4d18-b98a-00432b19c8bb","","",false, this);
 
            RCVATNumber = RPSControlFactory.CreateRPSTextBox<PurchaseLedgerView>("141d3d24-d1a0-46b4-9123-bcc73323f6cc","","",false, this);
 
            RCCompanyName = RPSControlFactory.CreateRPSTextBox<PurchaseLedgerView>("f00f2129-8771-47e8-8ab9-2d3426303a2c","","",false, this);
 
            Nullified = RPSControlFactory.CreateRPSCheckBox<PurchaseLedgerView>("d0f7ccbc-f551-4046-b835-c67e171309ea","","",false, this);
 
            DeliveryNote = RPSControlFactory.CreateRPSTextBox<PurchaseLedgerView>("53767cf4-22ab-417a-825b-e913e176f50a","","",false, this);
 
            DeliveryNoteDate = RPSControlFactory.CreateRPSTextBox<PurchaseLedgerView>("dd6e6c50-e331-454f-b7e5-c12add99ca12","","",false, this);
 
            PrintChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<PurchaseLedgerView,PrintChildDialogView>("4569b05a-ad74-46d5-8d8f-303e32e7e5d1","","", this,Screen.PrintChildDialogView);
 
            CollectionInit params_GetLedgerInvoicesFromStorageKey = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a2c5ef3c-917c-47a9-8ecd-8af4771d68ee",CSSSelectorGrid="",XPathGrid=""};
            GetLedgerInvoicesFromStorageKey = RPSControlFactory.RPSCreateCollectionWithGrid<GetLedgerInvoicesFromStorageKeyCollectionEditor<PurchaseLedgerView,PrintChildDialogView>,PurchaseLedgerView,PrintChildDialogView>( params_GetLedgerInvoicesFromStorageKey,this,Screen.PrintChildDialogView);
 
            CollectionInit params_GetLedgerVATsFromStorageKey = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0fddf2a1-f087-4370-a220-e0e63d4d7e48",CSSSelectorGrid="",XPathGrid=""};
            GetLedgerVATsFromStorageKey = RPSControlFactory.RPSCreateCollectionWithGrid<GetLedgerVATsFromStorageKeyCollectionEditor<PurchaseLedgerView,PrintChildDialogView>,PurchaseLedgerView,PrintChildDialogView>( params_GetLedgerVATsFromStorageKey,this,Screen.PrintChildDialogView);
 
            CollectionInit params_GetLedgerVoucherTypesFromStorageKey = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d9000242-6348-4b1c-b475-0f556c8048a9",CSSSelectorGrid="",XPathGrid=""};
            GetLedgerVoucherTypesFromStorageKey = RPSControlFactory.RPSCreateCollectionWithGrid<GetLedgerVoucherTypesFromStorageKeyCollectionEditor<PurchaseLedgerView,PrintChildDialogView>,PurchaseLedgerView,PrintChildDialogView>( params_GetLedgerVoucherTypesFromStorageKey,this,Screen.PrintChildDialogView);
 
            SectionInvoices = RPSControlFactory.CreateRPSSection<PurchaseLedgerView>( "","ul li[rpsid='e887a885-8d04-466c-9418-39ab5327cc1d']","",this);
 
            SectionVats = RPSControlFactory.CreateRPSSection<PurchaseLedgerView>( "","ul li[rpsid='8d2b8fb5-2009-4ec9-b4ff-69da31b32bf3']","",this);
 
            SectionVoucherTypes = RPSControlFactory.CreateRPSSection<PurchaseLedgerView>( "","ul li[rpsid='83889324-2f37-4b04-8718-4abe6f80d5f9']","",this);
 

        }
        public IRPSTextBox<PurchaseLedgerView> AccountingDateFrom { get; set; } 
        public IRPSTextBox<PurchaseLedgerView> AccountingDateTo { get; set; } 
        public IRPSCheckbox<PurchaseLedgerView> bNullified { get; set; } 
        public IRPSComboBox<PurchaseLedgerView> IDSupplier { get; set; } 
        public IRPSCollectionComboBox<PurchaseLedgerView> IDVoucherTypes { get; set; } 
        public IRPSCollectionComboBox<PurchaseLedgerView> IDVATs { get; set; } 
        public IRPSCheckbox<PurchaseLedgerView> bnvoices { get; set; } 
        public IRPSCheckbox<PurchaseLedgerView> bCreditNotes { get; set; } 
        public IRPSCheckbox<PurchaseLedgerView> bDebitNotes { get; set; } 
        public IRPSButton<PurchaseLedgerView> AcceptCommand { get; set; } 
        public IRPSTextBox<PurchaseLedgerView> VATAPAPRegNo { get; set; } 
        public IRPSTextBox<PurchaseLedgerView> SequenceNumber { get; set; } 
        public IRPSTextBox<PurchaseLedgerView> InvoiceDate { get; set; } 
        public IRPSTextBox<PurchaseLedgerView> DUAGroup { get; set; } 
        public IRPSTextBox<PurchaseLedgerView> VATNumber { get; set; } 
        public IRPSTextBox<PurchaseLedgerView> CompanyName { get; set; } 
        public IRPSTextBox<PurchaseLedgerView> RCVATNumber { get; set; } 
        public IRPSTextBox<PurchaseLedgerView> RCCompanyName { get; set; } 
        public IRPSCheckbox<PurchaseLedgerView> Nullified { get; set; } 
        public IRPSTextBox<PurchaseLedgerView> DeliveryNote { get; set; } 
        public IRPSTextBox<PurchaseLedgerView> DeliveryNoteDate { get; set; } 
        public IRPSButton<PurchaseLedgerView,PrintChildDialogView> PrintChildNavigationCommandButton { get; set; } 
        public GetLedgerInvoicesFromStorageKeyCollectionEditor<PurchaseLedgerView,PrintChildDialogView> GetLedgerInvoicesFromStorageKey { get; set; } 
        public GetLedgerVATsFromStorageKeyCollectionEditor<PurchaseLedgerView,PrintChildDialogView> GetLedgerVATsFromStorageKey { get; set; } 
        public GetLedgerVoucherTypesFromStorageKeyCollectionEditor<PurchaseLedgerView,PrintChildDialogView> GetLedgerVoucherTypesFromStorageKey { get; set; } 
        public IRPSSection<PurchaseLedgerView> SectionInvoices { get; set; } 
        public IRPSSection<PurchaseLedgerView> SectionVats { get; set; } 
        public IRPSSection<PurchaseLedgerView> SectionVoucherTypes { get; set; } 
        public PurchaseLedger Screen { get; set; }
        public PurchaseLedgerView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetLedgerInvoicesFromStorageKeyCollectionEditor<PurchaseLedgerView,PrintChildDialogView>:RPSCollectionEditor<PurchaseLedgerView,PrintChildDialogView> where PurchaseLedgerView : class, IView where PrintChildDialogView : class, IView
    {
        public  GetLedgerInvoicesFromStorageKeyGridView<PurchaseLedgerView,PrintChildDialogView> GridView {get;set;}
    }
    public partial class GetLedgerInvoicesFromStorageKeyGridView <PurchaseLedgerView,PrintChildDialogView> :  RPSGridView<PurchaseLedgerView,PrintChildDialogView> where PurchaseLedgerView : class, IView where PrintChildDialogView : class, IView
    {
        public GetLedgerInvoicesFromStorageKeyGridView(PurchaseLedgerView currentView,PrintChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            VATAPARRegNo = RPSControlFactory.CreateRPSGridFormattedTextBox<PurchaseLedgerView>("","#a2c5ef3c-917c-47a9-8ecd-8af4771d68ee .ag-row[role='row']@ROWINDEX [col-id='cVATAPAPRegNo']","",false, this.CurrentView);
 
            SequenceNumber = RPSControlFactory.CreateRPSGridFormattedTextBox<PurchaseLedgerView>("","#a2c5ef3c-917c-47a9-8ecd-8af4771d68ee .ag-row[role='row']@ROWINDEX [col-id='cSequenceNumber']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<PurchaseLedgerView>("","#a2c5ef3c-917c-47a9-8ecd-8af4771d68ee .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 
            CompanyName = RPSControlFactory.CreateRPSGridTextBox<PurchaseLedgerView>("","#a2c5ef3c-917c-47a9-8ecd-8af4771d68ee .ag-row[role='row']@ROWINDEX [col-id='cCompanyName']","",false, this.CurrentView);
 
            VATNumber = RPSControlFactory.CreateRPSGridTextBox<PurchaseLedgerView>("","#a2c5ef3c-917c-47a9-8ecd-8af4771d68ee .ag-row[role='row']@ROWINDEX [col-id='cVATNumber']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<PurchaseLedgerView> VATAPARRegNo { get; set; } 
        public IRPSGridTextBox<PurchaseLedgerView> SequenceNumber { get; set; } 
        public IRPSGridTextBox<PurchaseLedgerView> InvoiceDate { get; set; } 
        public IRPSGridTextBox<PurchaseLedgerView> CompanyName { get; set; } 
        public IRPSGridTextBox<PurchaseLedgerView> VATNumber { get; set; } 
                     
    }
 
        public partial class GetLedgerVATsFromStorageKeyCollectionEditor<PurchaseLedgerView,PrintChildDialogView>:RPSCollectionEditor<PurchaseLedgerView,PrintChildDialogView> where PurchaseLedgerView : class, IView where PrintChildDialogView : class, IView
    {
        public  GetLedgerVATsFromStorageKeyGridView<PurchaseLedgerView,PrintChildDialogView> GridView {get;set;}
    }
    public partial class GetLedgerVATsFromStorageKeyGridView <PurchaseLedgerView,PrintChildDialogView> :  RPSGridView<PurchaseLedgerView,PrintChildDialogView> where PurchaseLedgerView : class, IView where PrintChildDialogView : class, IView
    {
        public GetLedgerVATsFromStorageKeyGridView(PurchaseLedgerView currentView,PrintChildDialogView newView)
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
 
        public partial class GetLedgerVoucherTypesFromStorageKeyCollectionEditor<PurchaseLedgerView,PrintChildDialogView>:RPSCollectionEditor<PurchaseLedgerView,PrintChildDialogView> where PurchaseLedgerView : class, IView where PrintChildDialogView : class, IView
    {
        public  GetLedgerVoucherTypesFromStorageKeyGridView<PurchaseLedgerView,PrintChildDialogView> GridView {get;set;}
    }
    public partial class GetLedgerVoucherTypesFromStorageKeyGridView <PurchaseLedgerView,PrintChildDialogView> :  RPSGridView<PurchaseLedgerView,PrintChildDialogView> where PurchaseLedgerView : class, IView where PrintChildDialogView : class, IView
    {
        public GetLedgerVoucherTypesFromStorageKeyGridView(PurchaseLedgerView currentView,PrintChildDialogView newView)
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
        public PrintChildDialogView(PurchaseLedger screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DateReport = RPSControlFactory.CreateRPSTextBox<PrintChildDialogView>("d465bc62-ec3a-4fee-b834-cbc027598c04","","",false, this);
 
            bInvoices = RPSControlFactory.CreateRPSCheckBox<PrintChildDialogView>("82a52dd6-989d-47f2-9ec9-42a96aac599f","","",false, this);
 
            bVat = RPSControlFactory.CreateRPSCheckBox<PrintChildDialogView>("a74d5b3d-052d-4b98-a301-5369bd63e432","","",false, this);
 
            bVoucher = RPSControlFactory.CreateRPSCheckBox<PrintChildDialogView>("590c7879-6031-4723-86c4-f3d7e4e62867","","",false, this);
 

        }
        public IRPSTextBox<PrintChildDialogView> DateReport { get; set; } 
        public IRPSCheckbox<PrintChildDialogView> bInvoices { get; set; } 
        public IRPSCheckbox<PrintChildDialogView> bVat { get; set; } 
        public IRPSCheckbox<PrintChildDialogView> bVoucher { get; set; } 
        public PurchaseLedger Screen { get; set; }
        public PrintChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}