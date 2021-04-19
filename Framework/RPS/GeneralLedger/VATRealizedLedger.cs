    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.GeneralLedger.VATRealizedLedger
{
    //RPS VERSION 1.0.0.0
    public partial class VATRealizedLedger:Screen
    {
        public VATRealizedLedger():base()
        {
            this.URL = "generalledger.vatrealizedledger";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            VATRealizedLedgerView  = new VATRealizedLedgerView(this); 
            PrintChildDialogView  = new PrintChildDialogView(this); 
            VATRealizedLedgerView.InitializeControls(); 
            PrintChildDialogView.InitializeControls(); 
           
        }
      
            public VATRealizedLedgerView VATRealizedLedgerView {get; set; } 
            public PrintChildDialogView PrintChildDialogView {get; set; } 
    }
            
    public partial class VATRealizedLedgerView : View
    {
        public VATRealizedLedgerView(VATRealizedLedger screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Sales = RPSControlFactory.CreateRPSOption<VATRealizedLedgerView>( "adc3920f-c6cd-4192-8731-9e41438d079a","","",this);
 
            Purchases = RPSControlFactory.CreateRPSOption<VATRealizedLedgerView>( "61dec7ec-ba74-41fb-b5ae-02105cf14a92","","",this);
 
            AccountingDateFrom = RPSControlFactory.CreateRPSTextBox<VATRealizedLedgerView>("8911fc18-c2d3-474c-bb77-f1b1c8ee58a8","","",false, this);
 
            AccountingDateTo = RPSControlFactory.CreateRPSTextBox<VATRealizedLedgerView>("0509c31f-2c17-4293-869d-5f3a203e42d4","","",false, this);
 
            bNullified = RPSControlFactory.CreateRPSCheckBox<VATRealizedLedgerView>("e59c4020-e9c6-4863-a288-0a742eff733f","","",false, this);
 
            bnvoices = RPSControlFactory.CreateRPSCheckBox<VATRealizedLedgerView>("58335223-9cdb-4b1e-9bcf-bd52ec7288f9","","",false, this);
 
            bCreditNotes = RPSControlFactory.CreateRPSCheckBox<VATRealizedLedgerView>("270ae573-3345-40fb-bfa2-26140fe00c9a","","",false, this);
 
            bDebitNotes = RPSControlFactory.CreateRPSCheckBox<VATRealizedLedgerView>("82fd8d5b-6fd8-48b0-bddb-b5e21a8ec118","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<VATRealizedLedgerView>("f488c6c9-8b12-4125-8686-1e987072850b","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<VATRealizedLedgerView>("bc693062-661e-4714-b22c-0d4c3c174234","","",false, this);
 
            IDVATs = RPSControlFactory.CreateRPSCollectionComboBox<VATRealizedLedgerView>("c3242144-45d3-464b-9b61-7b690d44730a","","",false, this);
 
            AcceptCommand = RPSControlFactory.CreateRPSButton<VATRealizedLedgerView>( "0c1a7663-af98-4334-878e-f7ea5635f7dc","","",this);
 
            VATAPARRegNo = RPSControlFactory.CreateRPSFormattedTextBox<VATRealizedLedgerView>("5cf881f7-1363-40a2-b95a-09a2467d4f1b","","",false, this);
 
            VATAPAPRegNo = RPSControlFactory.CreateRPSFormattedTextBox<VATRealizedLedgerView>("dfd7112a-abe6-419b-a7e2-d28ba2d506c2","","",false, this);
 
            SequenceNumber = RPSControlFactory.CreateRPSFormattedTextBox<VATRealizedLedgerView>("f9d26720-19b7-46e1-8e9c-1d1df6ea1575","","",false, this);
 
            InvoiceDate = RPSControlFactory.CreateRPSTextBox<VATRealizedLedgerView>("64842a6d-c408-4c60-bd97-4c82434477f8","","",false, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<VATRealizedLedgerView>("e1d8a3f6-f739-4632-80fd-e03764d2ccee","","",false, this);
 
            CompanyName = RPSControlFactory.CreateRPSTextBox<VATRealizedLedgerView>("fcb58e0b-a121-4b29-9be1-89efbcc57456","","",false, this);
 
            VATNumber1 = RPSControlFactory.CreateRPSTextBox<VATRealizedLedgerView>("cada0497-21e0-4da2-b352-9a2769596c37","","",false, this);
 
            CompanyName1 = RPSControlFactory.CreateRPSTextBox<VATRealizedLedgerView>("9a3c81e5-8315-412b-aa0e-b45fc0790ec9","","",false, this);
 
            RCVATNumber = RPSControlFactory.CreateRPSTextBox<VATRealizedLedgerView>("141d3d24-d1a0-46b4-9123-bcc73323f6cc","","",false, this);
 
            RCCompanyName = RPSControlFactory.CreateRPSTextBox<VATRealizedLedgerView>("f00f2129-8771-47e8-8ab9-2d3426303a2c","","",false, this);
 
            Nullified = RPSControlFactory.CreateRPSCheckBox<VATRealizedLedgerView>("17160dab-b9c8-47a2-8d72-d7a67eaef88e","","",false, this);
 
            ePaidType = RPSControlFactory.CreateRPSEnumComboBox<VATRealizedLedgerView>("ee75bd73-7cb3-44aa-8cf3-65f5e12ab741","","",false, this);
 
            PaidExtension = RPSControlFactory.CreateRPSTextBox<VATRealizedLedgerView>("1b610ba4-e63b-4571-b2c1-d389a65fab61","","",false, this);
 
            DeliveryNote = RPSControlFactory.CreateRPSTextBox<VATRealizedLedgerView>("fceecbd1-f474-492a-8f2e-dd785b755826","","",false, this);
 
            DeliveryNoteDate = RPSControlFactory.CreateRPSTextBox<VATRealizedLedgerView>("c341bf80-1ff8-40e2-acc3-4dd57f4b205e","","",false, this);
 
            PrintChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<VATRealizedLedgerView,PrintChildDialogView>("815c22a1-36af-4e08-a5aa-e1fdcd6c63dd","","", this,Screen.PrintChildDialogView);
 
            CollectionInit params_GetLedgerInvoicesFromStorageKey = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8c0d8462-683f-4dee-81d7-a0fea907cca4",CSSSelectorGrid="",XPathGrid=""};
            GetLedgerInvoicesFromStorageKey = RPSControlFactory.RPSCreateCollectionWithGrid<GetLedgerInvoicesFromStorageKeyCollectionEditor<VATRealizedLedgerView,PrintChildDialogView>,VATRealizedLedgerView,PrintChildDialogView>( params_GetLedgerInvoicesFromStorageKey,this,Screen.PrintChildDialogView);
 
            CollectionInit params_GetLedgerVATsFromStorageKey = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="844fa11d-3161-4ac5-9914-cf14606e0cbf",CSSSelectorGrid="",XPathGrid=""};
            GetLedgerVATsFromStorageKey = RPSControlFactory.RPSCreateCollectionWithGrid<GetLedgerVATsFromStorageKeyCollectionEditor<VATRealizedLedgerView,PrintChildDialogView>,VATRealizedLedgerView,PrintChildDialogView>( params_GetLedgerVATsFromStorageKey,this,Screen.PrintChildDialogView);
 
            CollectionInit params_GetLedgerVoucherTypesFromStorageKey = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b652cab0-158f-47f8-b110-f9e9a2ed5e71",CSSSelectorGrid="",XPathGrid=""};
            GetLedgerVoucherTypesFromStorageKey = RPSControlFactory.RPSCreateCollectionWithGrid<GetLedgerVoucherTypesFromStorageKeyCollectionEditor<VATRealizedLedgerView,PrintChildDialogView>,VATRealizedLedgerView,PrintChildDialogView>( params_GetLedgerVoucherTypesFromStorageKey,this,Screen.PrintChildDialogView);
 
            SectionInvoices = RPSControlFactory.CreateRPSSection<VATRealizedLedgerView>( "","ul li[rpsid='f23c5463-23aa-4fda-a83e-227a991b8a1e']","",this);
 
            SectionVats = RPSControlFactory.CreateRPSSection<VATRealizedLedgerView>( "","ul li[rpsid='c7a20645-737f-4889-bd60-0f4c444ee5a3']","",this);
 
            SectionVoucherTypes = RPSControlFactory.CreateRPSSection<VATRealizedLedgerView>( "","ul li[rpsid='30e47868-da86-4a5f-aaeb-e0c312609bb9']","",this);
 

        }
        public IRPSOption<VATRealizedLedgerView> Sales { get; set; } 
        public IRPSOption<VATRealizedLedgerView> Purchases { get; set; } 
        public IRPSTextBox<VATRealizedLedgerView> AccountingDateFrom { get; set; } 
        public IRPSTextBox<VATRealizedLedgerView> AccountingDateTo { get; set; } 
        public IRPSCheckbox<VATRealizedLedgerView> bNullified { get; set; } 
        public IRPSCheckbox<VATRealizedLedgerView> bnvoices { get; set; } 
        public IRPSCheckbox<VATRealizedLedgerView> bCreditNotes { get; set; } 
        public IRPSCheckbox<VATRealizedLedgerView> bDebitNotes { get; set; } 
        public IRPSComboBox<VATRealizedLedgerView> IDCustomer { get; set; } 
        public IRPSComboBox<VATRealizedLedgerView> IDSupplier { get; set; } 
        public IRPSCollectionComboBox<VATRealizedLedgerView> IDVATs { get; set; } 
        public IRPSButton<VATRealizedLedgerView> AcceptCommand { get; set; } 
        public IRPSTextBox<VATRealizedLedgerView> VATAPARRegNo { get; set; } 
        public IRPSTextBox<VATRealizedLedgerView> VATAPAPRegNo { get; set; } 
        public IRPSTextBox<VATRealizedLedgerView> SequenceNumber { get; set; } 
        public IRPSTextBox<VATRealizedLedgerView> InvoiceDate { get; set; } 
        public IRPSTextBox<VATRealizedLedgerView> VATNumber { get; set; } 
        public IRPSTextBox<VATRealizedLedgerView> CompanyName { get; set; } 
        public IRPSTextBox<VATRealizedLedgerView> VATNumber1 { get; set; } 
        public IRPSTextBox<VATRealizedLedgerView> CompanyName1 { get; set; } 
        public IRPSTextBox<VATRealizedLedgerView> RCVATNumber { get; set; } 
        public IRPSTextBox<VATRealizedLedgerView> RCCompanyName { get; set; } 
        public IRPSCheckbox<VATRealizedLedgerView> Nullified { get; set; } 
        public IRPSComboBox<VATRealizedLedgerView> ePaidType { get; set; } 
        public IRPSTextBox<VATRealizedLedgerView> PaidExtension { get; set; } 
        public IRPSTextBox<VATRealizedLedgerView> DeliveryNote { get; set; } 
        public IRPSTextBox<VATRealizedLedgerView> DeliveryNoteDate { get; set; } 
        public IRPSButton<VATRealizedLedgerView,PrintChildDialogView> PrintChildNavigationCommandButton { get; set; } 
        public GetLedgerInvoicesFromStorageKeyCollectionEditor<VATRealizedLedgerView,PrintChildDialogView> GetLedgerInvoicesFromStorageKey { get; set; } 
        public GetLedgerVATsFromStorageKeyCollectionEditor<VATRealizedLedgerView,PrintChildDialogView> GetLedgerVATsFromStorageKey { get; set; } 
        public GetLedgerVoucherTypesFromStorageKeyCollectionEditor<VATRealizedLedgerView,PrintChildDialogView> GetLedgerVoucherTypesFromStorageKey { get; set; } 
        public IRPSSection<VATRealizedLedgerView> SectionInvoices { get; set; } 
        public IRPSSection<VATRealizedLedgerView> SectionVats { get; set; } 
        public IRPSSection<VATRealizedLedgerView> SectionVoucherTypes { get; set; } 
        public VATRealizedLedger Screen { get; set; }
        public VATRealizedLedgerView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetLedgerInvoicesFromStorageKeyCollectionEditor<VATRealizedLedgerView,PrintChildDialogView>:RPSCollectionEditor<VATRealizedLedgerView,PrintChildDialogView> where VATRealizedLedgerView : class, IView where PrintChildDialogView : class, IView
    {
        public  GetLedgerInvoicesFromStorageKeyGridView<VATRealizedLedgerView,PrintChildDialogView> GridView {get;set;}
    }
    public partial class GetLedgerInvoicesFromStorageKeyGridView <VATRealizedLedgerView,PrintChildDialogView> :  RPSGridView<VATRealizedLedgerView,PrintChildDialogView> where VATRealizedLedgerView : class, IView where PrintChildDialogView : class, IView
    {
        public GetLedgerInvoicesFromStorageKeyGridView(VATRealizedLedgerView currentView,PrintChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            VATAPARRegNo = RPSControlFactory.CreateRPSGridFormattedTextBox<VATRealizedLedgerView>("","#8c0d8462-683f-4dee-81d7-a0fea907cca4 .ag-row[role='row']@ROWINDEX [col-id='cVATAPARRegNo']","",false, this.CurrentView);
 
            VATAPAPRegNo = RPSControlFactory.CreateRPSGridFormattedTextBox<VATRealizedLedgerView>("","#8c0d8462-683f-4dee-81d7-a0fea907cca4 .ag-row[role='row']@ROWINDEX [col-id='cVATAPAPRegNo']","",false, this.CurrentView);
 
            SequenceNumber = RPSControlFactory.CreateRPSGridFormattedTextBox<VATRealizedLedgerView>("","#8c0d8462-683f-4dee-81d7-a0fea907cca4 .ag-row[role='row']@ROWINDEX [col-id='cSequenceNumber']","",false, this.CurrentView);
 
            InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<VATRealizedLedgerView>("","#8c0d8462-683f-4dee-81d7-a0fea907cca4 .ag-row[role='row']@ROWINDEX [col-id='cInvoiceDate']","",false, this.CurrentView);
 
            CompanyName = RPSControlFactory.CreateRPSGridTextBox<VATRealizedLedgerView>("","#8c0d8462-683f-4dee-81d7-a0fea907cca4 .ag-row[role='row']@ROWINDEX [col-id='cCompanyName']","",false, this.CurrentView);
 
            VATNumber = RPSControlFactory.CreateRPSGridTextBox<VATRealizedLedgerView>("","#8c0d8462-683f-4dee-81d7-a0fea907cca4 .ag-row[role='row']@ROWINDEX [col-id='cVATNumber']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<VATRealizedLedgerView> VATAPARRegNo { get; set; } 
        public IRPSGridTextBox<VATRealizedLedgerView> VATAPAPRegNo { get; set; } 
        public IRPSGridTextBox<VATRealizedLedgerView> SequenceNumber { get; set; } 
        public IRPSGridTextBox<VATRealizedLedgerView> InvoiceDate { get; set; } 
        public IRPSGridTextBox<VATRealizedLedgerView> CompanyName { get; set; } 
        public IRPSGridTextBox<VATRealizedLedgerView> VATNumber { get; set; } 
                     
    }
 
        public partial class GetLedgerVATsFromStorageKeyCollectionEditor<VATRealizedLedgerView,PrintChildDialogView>:RPSCollectionEditor<VATRealizedLedgerView,PrintChildDialogView> where VATRealizedLedgerView : class, IView where PrintChildDialogView : class, IView
    {
        public  GetLedgerVATsFromStorageKeyGridView<VATRealizedLedgerView,PrintChildDialogView> GridView {get;set;}
    }
    public partial class GetLedgerVATsFromStorageKeyGridView <VATRealizedLedgerView,PrintChildDialogView> :  RPSGridView<VATRealizedLedgerView,PrintChildDialogView> where VATRealizedLedgerView : class, IView where PrintChildDialogView : class, IView
    {
        public GetLedgerVATsFromStorageKeyGridView(VATRealizedLedgerView currentView,PrintChildDialogView newView)
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
 
        public partial class GetLedgerVoucherTypesFromStorageKeyCollectionEditor<VATRealizedLedgerView,PrintChildDialogView>:RPSCollectionEditor<VATRealizedLedgerView,PrintChildDialogView> where VATRealizedLedgerView : class, IView where PrintChildDialogView : class, IView
    {
        public  GetLedgerVoucherTypesFromStorageKeyGridView<VATRealizedLedgerView,PrintChildDialogView> GridView {get;set;}
    }
    public partial class GetLedgerVoucherTypesFromStorageKeyGridView <VATRealizedLedgerView,PrintChildDialogView> :  RPSGridView<VATRealizedLedgerView,PrintChildDialogView> where VATRealizedLedgerView : class, IView where PrintChildDialogView : class, IView
    {
        public GetLedgerVoucherTypesFromStorageKeyGridView(VATRealizedLedgerView currentView,PrintChildDialogView newView)
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
        public PrintChildDialogView(VATRealizedLedger screen) : base()
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
        public VATRealizedLedger Screen { get; set; }
        public PrintChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}