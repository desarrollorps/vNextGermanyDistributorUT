    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.TaxModel.SIIPurchaseLedger
{
    //RPS VERSION 1.0.0.0
    public partial class SIIPurchaseLedger:Screen
    {
        public SIIPurchaseLedger():base()
        {
            this.URL = "taxmodel.siipurchaseledger";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SIIPurchaseLedgerQueryView  = new SIIPurchaseLedgerQueryView(this); 
            SIIPurchaseLedgerQueryView.InitializeControls(); 
           
        }
      
            public SIIPurchaseLedgerQueryView SIIPurchaseLedgerQueryView {get; set; } 
    }
            
    public partial class SIIPurchaseLedgerQueryView : View
    {
        public SIIPurchaseLedgerQueryView(SIIPurchaseLedger screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeclarationYear = RPSControlFactory.CreateRPSFormattedTextBox<SIIPurchaseLedgerQueryView>("7cc0e5f1-026a-4eb9-92e7-f50a2ff86776","","",false, this);
 
            eMonth = RPSControlFactory.CreateRPSEnumComboBox<SIIPurchaseLedgerQueryView>("3ac00a0b-b65d-4d6a-913c-8c99c4229718","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<SIIPurchaseLedgerQueryView>("f8b0c1ae-2760-498a-8fac-69dbe566793f","","",false, this);
 
            IDVoucherTypes = RPSControlFactory.CreateRPSCollectionComboBox<SIIPurchaseLedgerQueryView>("895be118-9044-4459-a680-4a7cbc5417ee","","",false, this);
 
            IDVATs = RPSControlFactory.CreateRPSCollectionComboBox<SIIPurchaseLedgerQueryView>("e9715398-4362-48ab-994f-d913aaefc57f","","",false, this);
 
            Sent = RPSControlFactory.CreateRPSCheckBox<SIIPurchaseLedgerQueryView>("3f427ddb-4c52-4be4-aa94-bc9b870cc947","","",false, this);
 
            PendingCorrection = RPSControlFactory.CreateRPSCheckBox<SIIPurchaseLedgerQueryView>("4d93fcf3-2493-43ab-a58f-5159c24aa3df","","",false, this);
 
            ToBeCreated = RPSControlFactory.CreateRPSCheckBox<SIIPurchaseLedgerQueryView>("00686542-d7e7-46a7-8819-bcf31cc89734","","",false, this);
 
            ToBeChanged = RPSControlFactory.CreateRPSCheckBox<SIIPurchaseLedgerQueryView>("5c038bdf-74f2-4a53-8b62-f27bcb13884c","","",false, this);
 
            ToBeDeleted = RPSControlFactory.CreateRPSCheckBox<SIIPurchaseLedgerQueryView>("ab35d71b-f026-4935-a43d-b79ebb679e3c","","",false, this);
 
            NoSend = RPSControlFactory.CreateRPSCheckBox<SIIPurchaseLedgerQueryView>("a1a86ecf-8197-4f2d-834a-e8b1186d51c3","","",false, this);
 
            Deleted = RPSControlFactory.CreateRPSCheckBox<SIIPurchaseLedgerQueryView>("57d0e3c4-bfa3-426d-bce4-1ac6f5eb06a2","","",false, this);
 
            TaxPurchaseInvoice_CodInvoice = RPSControlFactory.CreateRPSTextBox<SIIPurchaseLedgerQueryView>("b94bd7db-0bfb-4b0a-a22a-45e7f9474bff","","",false, this);
 
            TaxPurchaseInvoice_InvoiceDate = RPSControlFactory.CreateRPSTextBox<SIIPurchaseLedgerQueryView>("ab16c3c5-2e6a-4249-a521-244abc3a2658","","",false, this);
 
            TaxPurchaseInvoice_RegistrationDate = RPSControlFactory.CreateRPSTextBox<SIIPurchaseLedgerQueryView>("d68f43c9-ed86-47b9-86de-51579ae0ad28","","",false, this);
 
            TaxPurchaseInvoice_ActionStatus = RPSControlFactory.CreateRPSTextBox<SIIPurchaseLedgerQueryView>("1ff0ad2c-e327-4a83-bd31-02e18cebfd4e","","",false, this);
 
            TaxPurchaseInvoice_SentType = RPSControlFactory.CreateRPSTextBox<SIIPurchaseLedgerQueryView>("206cd9ac-e8d2-4c9d-a25e-5810d49cf299","","",false, this);
 
            TaxPurchaseInvoice_SentKeys = RPSControlFactory.CreateRPSTextBox<SIIPurchaseLedgerQueryView>("21b34696-3605-4574-8128-4606c7de5b0f","","",false, this);
 
            TaxPurchaseInvoice_IsATicket = RPSControlFactory.CreateRPSCheckBox<SIIPurchaseLedgerQueryView>("e33132b7-ce82-47d0-9ce2-0df85eb66563","","",false, this);
 
            TaxPurchaseInvoice_IsDUA = RPSControlFactory.CreateRPSCheckBox<SIIPurchaseLedgerQueryView>("76129d00-2109-49d2-8147-3df761aacadc","","",false, this);
 
            TaxPurchaseInvoice_AutoInvoice = RPSControlFactory.CreateRPSCheckBox<SIIPurchaseLedgerQueryView>("bbdfbd80-3984-4b00-9ddb-cb0f5f5dd274","","",false, this);
 
            TaxPurchaseInvoice_DeclarationYear = RPSControlFactory.CreateRPSFormattedTextBox<SIIPurchaseLedgerQueryView>("05181146-d92a-462c-966a-6b4828fc81dd","","",false, this);
 
            TaxPurchaseInvoice_DeclarationMonth = RPSControlFactory.CreateRPSTextBox<SIIPurchaseLedgerQueryView>("d834f7ff-1780-4651-8540-a63a85e60322","","",false, this);
 
            TaxPurchaseInvoice_DeductionLater = RPSControlFactory.CreateRPSCheckBox<SIIPurchaseLedgerQueryView>("5a9d2c2e-785b-457b-923f-d64eff7c9abb","","",false, this);
 
            TaxPurchaseInvoice_DeductionYear = RPSControlFactory.CreateRPSFormattedTextBox<SIIPurchaseLedgerQueryView>("9aa91b6d-624d-4db9-ab73-f74df3d3080a","","",false, this);
 
            TaxPurchaseInvoice_DeductionMonth = RPSControlFactory.CreateRPSTextBox<SIIPurchaseLedgerQueryView>("e0f233fd-72a2-4925-a5f2-d098174387e3","","",false, this);
 
            VatNumber = RPSControlFactory.CreateRPSTextBox<SIIPurchaseLedgerQueryView>("4c757ff9-671e-47f1-ba59-cff82947c797","","",false, this);
 
            TaxPurchaseInvoice_SupplierName = RPSControlFactory.CreateRPSTextBox<SIIPurchaseLedgerQueryView>("8b8d3dc3-b203-4dc5-b705-602c2dded98c","","",false, this);
 
            ACCTransactions_VATAPRegisterNumber = RPSControlFactory.CreateRPSFormattedTextBox<SIIPurchaseLedgerQueryView>("660f9538-b1a0-4415-9030-43fdab751816","","",false, this);
 
            TaxPurchaseVAT_Usage303 = RPSControlFactory.CreateRPSTextBox<SIIPurchaseLedgerQueryView>("3cf2e1cc-3ad8-4a5d-9262-787f790cb5ca","","",false, this);
 
            TaxPurchaseVAT_Exclude = RPSControlFactory.CreateRPSCheckBox<SIIPurchaseLedgerQueryView>("c9e20c26-6a45-4269-bf0d-c83736e68a3c","","",false, this);
 
            TaxPurchaseVAT_IsPending = RPSControlFactory.CreateRPSCheckBox<SIIPurchaseLedgerQueryView>("897f48c2-cca0-43c0-8724-3698d5e41fc5","","",false, this);
 
            TaxPurchaseVAT_IsSurchage = RPSControlFactory.CreateRPSCheckBox<SIIPurchaseLedgerQueryView>("91d5e2f4-b43e-4182-956c-40cc753a2d02","","",false, this);
 
            TaxPurchaseInvoice_AutoInvoiceType = RPSControlFactory.CreateRPSTextBox<SIIPurchaseLedgerQueryView>("870ff3c6-d41c-4aa1-a308-bdedb451b43f","","",false, this);
 
            TaxPurchaseVAT_ExcludedFromRC = RPSControlFactory.CreateRPSCheckBox<SIIPurchaseLedgerQueryView>("dae9a7f5-81b2-4825-b827-91e1cbb2b274","","",false, this);
 
            TaxPurchaseVAT_IsReverse = RPSControlFactory.CreateRPSCheckBox<SIIPurchaseLedgerQueryView>("db302e12-d2fe-40f4-b801-41988b8ced6f","","",false, this);
 
            ACCTransactions_CodDeliveryNote = RPSControlFactory.CreateRPSTextBox<SIIPurchaseLedgerQueryView>("c2a961ba-2a06-4682-a99b-a7ede927ad3f","","",false, this);
 
            ACCTransactions_DeliveryNoteDate = RPSControlFactory.CreateRPSTextBox<SIIPurchaseLedgerQueryView>("364aa947-00f5-49fb-8ba9-1a05ee7b0536","","",false, this);
 
            TaxPurchaseInvoice_OperationDate = RPSControlFactory.CreateRPSTextBox<SIIPurchaseLedgerQueryView>("5d092c90-f419-4c7b-aaac-8cf3d7dff13a","","",false, this);
 
            TaxPurchaseInvoice_IsAmendment = RPSControlFactory.CreateRPSCheckBox<SIIPurchaseLedgerQueryView>("f5c4be08-cdcc-45dd-8bd7-2af30f552bc1","","",false, this);
 
            TaxPurchaseInvoice_FromCodInvoice = RPSControlFactory.CreateRPSTextBox<SIIPurchaseLedgerQueryView>("746a67d2-dc2b-4c22-8f88-8b8a559c2f03","","",false, this);
 
            TaxPurchaseInvoice_FromInvoiceDate = RPSControlFactory.CreateRPSTextBox<SIIPurchaseLedgerQueryView>("43cc20a8-4eba-440e-b243-e4f34de72f9c","","",false, this);
 
            TaxPurchaseInvoice_AmendmentType = RPSControlFactory.CreateRPSTextBox<SIIPurchaseLedgerQueryView>("5f5e7228-0cbd-4dde-91f6-2ea4127753da","","",false, this);
 
            CollectionInit params_SIIPurchaseLedger = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5c7d21d4-15ae-4543-831d-a9cb16044c2c",CSSSelectorGrid="",XPathGrid=""};
            SIIPurchaseLedger = RPSControlFactory.RPSCreateCollectionWithGrid<SIIPurchaseLedgerCollectionEditor<SIIPurchaseLedgerQueryView>,SIIPurchaseLedgerQueryView>( params_SIIPurchaseLedger,this);
 

        }
        public IRPSTextBox<SIIPurchaseLedgerQueryView> DeclarationYear { get; set; } 
        public IRPSComboBox<SIIPurchaseLedgerQueryView> eMonth { get; set; } 
        public IRPSComboBox<SIIPurchaseLedgerQueryView> IDSupplier { get; set; } 
        public IRPSCollectionComboBox<SIIPurchaseLedgerQueryView> IDVoucherTypes { get; set; } 
        public IRPSCollectionComboBox<SIIPurchaseLedgerQueryView> IDVATs { get; set; } 
        public IRPSCheckbox<SIIPurchaseLedgerQueryView> Sent { get; set; } 
        public IRPSCheckbox<SIIPurchaseLedgerQueryView> PendingCorrection { get; set; } 
        public IRPSCheckbox<SIIPurchaseLedgerQueryView> ToBeCreated { get; set; } 
        public IRPSCheckbox<SIIPurchaseLedgerQueryView> ToBeChanged { get; set; } 
        public IRPSCheckbox<SIIPurchaseLedgerQueryView> ToBeDeleted { get; set; } 
        public IRPSCheckbox<SIIPurchaseLedgerQueryView> NoSend { get; set; } 
        public IRPSCheckbox<SIIPurchaseLedgerQueryView> Deleted { get; set; } 
        public IRPSTextBox<SIIPurchaseLedgerQueryView> TaxPurchaseInvoice_CodInvoice { get; set; } 
        public IRPSTextBox<SIIPurchaseLedgerQueryView> TaxPurchaseInvoice_InvoiceDate { get; set; } 
        public IRPSTextBox<SIIPurchaseLedgerQueryView> TaxPurchaseInvoice_RegistrationDate { get; set; } 
        public IRPSTextBox<SIIPurchaseLedgerQueryView> TaxPurchaseInvoice_ActionStatus { get; set; } 
        public IRPSTextBox<SIIPurchaseLedgerQueryView> TaxPurchaseInvoice_SentType { get; set; } 
        public IRPSTextBox<SIIPurchaseLedgerQueryView> TaxPurchaseInvoice_SentKeys { get; set; } 
        public IRPSCheckbox<SIIPurchaseLedgerQueryView> TaxPurchaseInvoice_IsATicket { get; set; } 
        public IRPSCheckbox<SIIPurchaseLedgerQueryView> TaxPurchaseInvoice_IsDUA { get; set; } 
        public IRPSCheckbox<SIIPurchaseLedgerQueryView> TaxPurchaseInvoice_AutoInvoice { get; set; } 
        public IRPSTextBox<SIIPurchaseLedgerQueryView> TaxPurchaseInvoice_DeclarationYear { get; set; } 
        public IRPSTextBox<SIIPurchaseLedgerQueryView> TaxPurchaseInvoice_DeclarationMonth { get; set; } 
        public IRPSCheckbox<SIIPurchaseLedgerQueryView> TaxPurchaseInvoice_DeductionLater { get; set; } 
        public IRPSTextBox<SIIPurchaseLedgerQueryView> TaxPurchaseInvoice_DeductionYear { get; set; } 
        public IRPSTextBox<SIIPurchaseLedgerQueryView> TaxPurchaseInvoice_DeductionMonth { get; set; } 
        public IRPSTextBox<SIIPurchaseLedgerQueryView> VatNumber { get; set; } 
        public IRPSTextBox<SIIPurchaseLedgerQueryView> TaxPurchaseInvoice_SupplierName { get; set; } 
        public IRPSTextBox<SIIPurchaseLedgerQueryView> ACCTransactions_VATAPRegisterNumber { get; set; } 
        public IRPSTextBox<SIIPurchaseLedgerQueryView> TaxPurchaseVAT_Usage303 { get; set; } 
        public IRPSCheckbox<SIIPurchaseLedgerQueryView> TaxPurchaseVAT_Exclude { get; set; } 
        public IRPSCheckbox<SIIPurchaseLedgerQueryView> TaxPurchaseVAT_IsPending { get; set; } 
        public IRPSCheckbox<SIIPurchaseLedgerQueryView> TaxPurchaseVAT_IsSurchage { get; set; } 
        public IRPSTextBox<SIIPurchaseLedgerQueryView> TaxPurchaseInvoice_AutoInvoiceType { get; set; } 
        public IRPSCheckbox<SIIPurchaseLedgerQueryView> TaxPurchaseVAT_ExcludedFromRC { get; set; } 
        public IRPSCheckbox<SIIPurchaseLedgerQueryView> TaxPurchaseVAT_IsReverse { get; set; } 
        public IRPSTextBox<SIIPurchaseLedgerQueryView> ACCTransactions_CodDeliveryNote { get; set; } 
        public IRPSTextBox<SIIPurchaseLedgerQueryView> ACCTransactions_DeliveryNoteDate { get; set; } 
        public IRPSTextBox<SIIPurchaseLedgerQueryView> TaxPurchaseInvoice_OperationDate { get; set; } 
        public IRPSCheckbox<SIIPurchaseLedgerQueryView> TaxPurchaseInvoice_IsAmendment { get; set; } 
        public IRPSTextBox<SIIPurchaseLedgerQueryView> TaxPurchaseInvoice_FromCodInvoice { get; set; } 
        public IRPSTextBox<SIIPurchaseLedgerQueryView> TaxPurchaseInvoice_FromInvoiceDate { get; set; } 
        public IRPSTextBox<SIIPurchaseLedgerQueryView> TaxPurchaseInvoice_AmendmentType { get; set; } 
        public SIIPurchaseLedgerCollectionEditor<SIIPurchaseLedgerQueryView> SIIPurchaseLedger { get; set; } 
        public SIIPurchaseLedger Screen { get; set; }
        public SIIPurchaseLedgerQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SIIPurchaseLedgerCollectionEditor<SIIPurchaseLedgerQueryView>:RPSCollectionEditor<SIIPurchaseLedgerQueryView> where SIIPurchaseLedgerQueryView : class, IView
    {
        public  SIIPurchaseLedgerGridView<SIIPurchaseLedgerQueryView> GridView {get;set;}
    }
    public partial class SIIPurchaseLedgerGridView <SIIPurchaseLedgerQueryView> :  RPSGridView<SIIPurchaseLedgerQueryView> where SIIPurchaseLedgerQueryView : class, IView
    {
        public SIIPurchaseLedgerGridView(SIIPurchaseLedgerQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            TaxPurchaseInvoice_DeclarationYear = RPSControlFactory.CreateRPSGridFormattedTextBox<SIIPurchaseLedgerQueryView>("","#5c7d21d4-15ae-4543-831d-a9cb16044c2c .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchaseInvoice_DeclarationYear']","",false, this.CurrentView);
 
            TaxPurchaseInvoice_DeclarationMonth = RPSControlFactory.CreateRPSGridTextBox<SIIPurchaseLedgerQueryView>("","#5c7d21d4-15ae-4543-831d-a9cb16044c2c .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchaseInvoice_DeclarationMonth']","",false, this.CurrentView);
 
            ACCTransactions_VATAPRegisterNumber = RPSControlFactory.CreateRPSGridFormattedTextBox<SIIPurchaseLedgerQueryView>("","#5c7d21d4-15ae-4543-831d-a9cb16044c2c .ag-row[role='row']@ROWINDEX [col-id='cACCTransactions_VATAPRegisterNumber']","",false, this.CurrentView);
 
            TaxPurchaseInvoice_CodInvoice = RPSControlFactory.CreateRPSGridTextBox<SIIPurchaseLedgerQueryView>("","#5c7d21d4-15ae-4543-831d-a9cb16044c2c .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchaseInvoice_CodInvoice']","",false, this.CurrentView);
 
            TaxPurchaseInvoice_InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<SIIPurchaseLedgerQueryView>("","#5c7d21d4-15ae-4543-831d-a9cb16044c2c .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchaseInvoice_InvoiceDate']","",false, this.CurrentView);
 
            TaxPurchaseInvoice_SupplierName = RPSControlFactory.CreateRPSGridTextBox<SIIPurchaseLedgerQueryView>("","#5c7d21d4-15ae-4543-831d-a9cb16044c2c .ag-row[role='row']@ROWINDEX [col-id='cTaxPurchaseInvoice_SupplierName']","",false, this.CurrentView);
 
            VatNumber = RPSControlFactory.CreateRPSGridTextBox<SIIPurchaseLedgerQueryView>("","#5c7d21d4-15ae-4543-831d-a9cb16044c2c .ag-row[role='row']@ROWINDEX [col-id='cVatNumber']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SIIPurchaseLedgerQueryView> TaxPurchaseInvoice_DeclarationYear { get; set; } 
        public IRPSGridTextBox<SIIPurchaseLedgerQueryView> TaxPurchaseInvoice_DeclarationMonth { get; set; } 
        public IRPSGridTextBox<SIIPurchaseLedgerQueryView> ACCTransactions_VATAPRegisterNumber { get; set; } 
        public IRPSGridTextBox<SIIPurchaseLedgerQueryView> TaxPurchaseInvoice_CodInvoice { get; set; } 
        public IRPSGridTextBox<SIIPurchaseLedgerQueryView> TaxPurchaseInvoice_InvoiceDate { get; set; } 
        public IRPSGridTextBox<SIIPurchaseLedgerQueryView> TaxPurchaseInvoice_SupplierName { get; set; } 
        public IRPSGridTextBox<SIIPurchaseLedgerQueryView> VatNumber { get; set; } 
                     
    }
 
    }
  
    

}