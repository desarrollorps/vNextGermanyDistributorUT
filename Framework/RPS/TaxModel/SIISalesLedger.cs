    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.TaxModel.SIISalesLedger
{
    //RPS VERSION 1.0.0.0
    public partial class SIISalesLedger:Screen
    {
        public SIISalesLedger():base()
        {
            this.URL = "taxmodel.siisalesledger";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SIISalesLedgerQueryView  = new SIISalesLedgerQueryView(this); 
            SIISalesLedgerQueryView.InitializeControls(); 
           
        }
      
            public SIISalesLedgerQueryView SIISalesLedgerQueryView {get; set; } 
    }
            
    public partial class SIISalesLedgerQueryView : View
    {
        public SIISalesLedgerQueryView(SIISalesLedger screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeclarationYear = RPSControlFactory.CreateRPSFormattedTextBox<SIISalesLedgerQueryView>("7cc0e5f1-026a-4eb9-92e7-f50a2ff86776","","",false, this);
 
            eMonth = RPSControlFactory.CreateRPSEnumComboBox<SIISalesLedgerQueryView>("3ac00a0b-b65d-4d6a-913c-8c99c4229718","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<SIISalesLedgerQueryView>("06ee13eb-b3b2-4778-afea-7d8cffe0b4dd","","",false, this);
 
            IDVoucherTypes = RPSControlFactory.CreateRPSCollectionComboBox<SIISalesLedgerQueryView>("1333e0d5-be94-4d2a-96da-39aa74f5b9e4","","",false, this);
 
            IDVATs = RPSControlFactory.CreateRPSCollectionComboBox<SIISalesLedgerQueryView>("29ef8c8d-f3d7-4fb3-b674-dd292442a352","","",false, this);
 
            Sent = RPSControlFactory.CreateRPSCheckBox<SIISalesLedgerQueryView>("325b3f23-9686-4624-ae52-fd3e0dd12b33","","",false, this);
 
            PendingCorrection = RPSControlFactory.CreateRPSCheckBox<SIISalesLedgerQueryView>("17dc2b9a-9f05-41c4-b8a6-5f43f459d9a8","","",false, this);
 
            ToBeCreated = RPSControlFactory.CreateRPSCheckBox<SIISalesLedgerQueryView>("8558e87e-5f74-4dbb-a064-8a5305737651","","",false, this);
 
            ToBeChanged = RPSControlFactory.CreateRPSCheckBox<SIISalesLedgerQueryView>("38914335-9266-4e0a-93a5-13340d04e5fb","","",false, this);
 
            ToBeDeleted = RPSControlFactory.CreateRPSCheckBox<SIISalesLedgerQueryView>("3bae87fb-4938-4c13-aa58-e7073d9eb86c","","",false, this);
 
            NoSend = RPSControlFactory.CreateRPSCheckBox<SIISalesLedgerQueryView>("fce5b555-be20-4eb4-b06f-76a6a35a5a50","","",false, this);
 
            Deleted = RPSControlFactory.CreateRPSCheckBox<SIISalesLedgerQueryView>("be4ab0da-521c-4ef6-bcec-74068a883e31","","",false, this);
 
            CodInvoice = RPSControlFactory.CreateRPSTextBox<SIISalesLedgerQueryView>("b6942114-a116-42d1-89fa-809500f9cefd","","",false, this);
 
            TaxSalesInvoice_InvoiceDate = RPSControlFactory.CreateRPSTextBox<SIISalesLedgerQueryView>("7bbda1fe-604f-4889-9cca-c271b3acefb7","","",false, this);
 
            TaxSalesInvoice_ActionStatus = RPSControlFactory.CreateRPSTextBox<SIISalesLedgerQueryView>("64a16a7f-4474-4fa3-bc57-eeeba43e8b52","","",false, this);
 
            TaxSalesInvoice_SentType = RPSControlFactory.CreateRPSTextBox<SIISalesLedgerQueryView>("1f4a1fbc-d770-433a-b9db-b656759a91fa","","",false, this);
 
            TaxSalesInvoice_SentKeys = RPSControlFactory.CreateRPSTextBox<SIISalesLedgerQueryView>("83743b52-e777-477a-91ab-cb8f159a4ee3","","",false, this);
 
            TaxSalesInvoice_SentInvoiceTo = RPSControlFactory.CreateRPSTextBox<SIISalesLedgerQueryView>("6717c273-0345-4fdd-80ea-4b0c27cee360","","",false, this);
 
            TaxSalesInvoice_IsATicket = RPSControlFactory.CreateRPSCheckBox<SIISalesLedgerQueryView>("61f0a25a-285d-434b-bffa-4e7b29fea10f","","",false, this);
 
            TaxSalesInvoice_IsAutoInvoice = RPSControlFactory.CreateRPSCheckBox<SIISalesLedgerQueryView>("21669266-c331-4783-be66-743c24aa1afc","","",false, this);
 
            TaxSalesInvoice_DeclarationYear = RPSControlFactory.CreateRPSFormattedTextBox<SIISalesLedgerQueryView>("61698c46-0c08-4553-9907-317063c51bd2","","",false, this);
 
            TaxSalesInvoice_DeclarationMonth = RPSControlFactory.CreateRPSTextBox<SIISalesLedgerQueryView>("88847e06-d2e8-432b-a427-0d7f707d3ac8","","",false, this);
 
            VatNumber = RPSControlFactory.CreateRPSTextBox<SIISalesLedgerQueryView>("f31ce2fa-72f4-423a-8a05-6be90eaab228","","",false, this);
 
            TaxSalesInvoice_CustomerName = RPSControlFactory.CreateRPSTextBox<SIISalesLedgerQueryView>("d05d22ff-4c00-4917-ad63-1d7a44d8ef21","","",false, this);
 
            ACCTransactions_VATARRegisterNumber = RPSControlFactory.CreateRPSFormattedTextBox<SIISalesLedgerQueryView>("6875d1e6-661e-4029-a404-fea9d90327f4","","",false, this);
 
            TaxSalesVAT_Usage303 = RPSControlFactory.CreateRPSTextBox<SIISalesLedgerQueryView>("4883053f-d5c9-4c84-8814-0ed691631de1","","",false, this);
 
            TaxSalesVAT_Exclude = RPSControlFactory.CreateRPSCheckBox<SIISalesLedgerQueryView>("b747d943-8e8f-434a-86a4-875aa39ba748","","",false, this);
 
            TaxSalesVAT_IsPending = RPSControlFactory.CreateRPSCheckBox<SIISalesLedgerQueryView>("996ca76f-4989-45d3-857e-01dde63b3fc0","","",false, this);
 
            TaxSalesVAT_IsSurchage = RPSControlFactory.CreateRPSCheckBox<SIISalesLedgerQueryView>("f1c7b3b3-acab-45c0-9330-d7d316116fe7","","",false, this);
 
            TaxSalesVAT_GoodsServices = RPSControlFactory.CreateRPSTextBox<SIISalesLedgerQueryView>("51ca452e-b5ea-4b2e-a5a3-ad23b950d097","","",false, this);
 
            TaxSalesVAT_VATType = RPSControlFactory.CreateRPSTextBox<SIISalesLedgerQueryView>("d3b25cfb-5d6b-444c-84eb-46469a0ca1a1","","",false, this);
 
            TaxSalesVAT_NotDeductible = RPSControlFactory.CreateRPSCheckBox<SIISalesLedgerQueryView>("887e311c-5ee8-4a20-b364-cc31eb13ea60","","",false, this);
 
            ACCTransactions_CodDeliveryNote = RPSControlFactory.CreateRPSTextBox<SIISalesLedgerQueryView>("d00ccd46-2482-4b80-b1bb-c4ce5ae89c19","","",false, this);
 
            ACCTransactions_DeliveryNoteDate = RPSControlFactory.CreateRPSTextBox<SIISalesLedgerQueryView>("bd51821d-59b9-4544-8b7c-a57788495e5a","","",false, this);
 
            TaxSalesInvoice_OperationDate = RPSControlFactory.CreateRPSTextBox<SIISalesLedgerQueryView>("81a2f366-6411-4c7f-938d-a5b09157d0f0","","",false, this);
 
            TaxSalesInvoice_IsAmendment = RPSControlFactory.CreateRPSCheckBox<SIISalesLedgerQueryView>("80ac11cb-b951-4c33-802f-40aec8712ddf","","",false, this);
 
            TaxSalesInvoice_FromCodInvoice = RPSControlFactory.CreateRPSTextBox<SIISalesLedgerQueryView>("ff6cbb47-56fd-4e7e-99e1-7e7981ed1964","","",false, this);
 
            TaxSalesInvoice_FromInvoiceDate = RPSControlFactory.CreateRPSTextBox<SIISalesLedgerQueryView>("9ff9d83e-3c6a-4e6b-9a60-7248d5c16740","","",false, this);
 
            TaxSalesInvoice_AmendmentType = RPSControlFactory.CreateRPSTextBox<SIISalesLedgerQueryView>("c2753bfd-3f46-4d57-a95e-1af7338c5994","","",false, this);
 
            CollectionInit params_SIISalesLedger = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="81268ab7-f1ae-4379-b11b-7d87be96caae",CSSSelectorGrid="",XPathGrid=""};
            SIISalesLedger = RPSControlFactory.RPSCreateCollectionWithGrid<SIISalesLedgerCollectionEditor<SIISalesLedgerQueryView>,SIISalesLedgerQueryView>( params_SIISalesLedger,this);
 

        }
        public IRPSTextBox<SIISalesLedgerQueryView> DeclarationYear { get; set; } 
        public IRPSComboBox<SIISalesLedgerQueryView> eMonth { get; set; } 
        public IRPSComboBox<SIISalesLedgerQueryView> IDCustomer { get; set; } 
        public IRPSCollectionComboBox<SIISalesLedgerQueryView> IDVoucherTypes { get; set; } 
        public IRPSCollectionComboBox<SIISalesLedgerQueryView> IDVATs { get; set; } 
        public IRPSCheckbox<SIISalesLedgerQueryView> Sent { get; set; } 
        public IRPSCheckbox<SIISalesLedgerQueryView> PendingCorrection { get; set; } 
        public IRPSCheckbox<SIISalesLedgerQueryView> ToBeCreated { get; set; } 
        public IRPSCheckbox<SIISalesLedgerQueryView> ToBeChanged { get; set; } 
        public IRPSCheckbox<SIISalesLedgerQueryView> ToBeDeleted { get; set; } 
        public IRPSCheckbox<SIISalesLedgerQueryView> NoSend { get; set; } 
        public IRPSCheckbox<SIISalesLedgerQueryView> Deleted { get; set; } 
        public IRPSTextBox<SIISalesLedgerQueryView> CodInvoice { get; set; } 
        public IRPSTextBox<SIISalesLedgerQueryView> TaxSalesInvoice_InvoiceDate { get; set; } 
        public IRPSTextBox<SIISalesLedgerQueryView> TaxSalesInvoice_ActionStatus { get; set; } 
        public IRPSTextBox<SIISalesLedgerQueryView> TaxSalesInvoice_SentType { get; set; } 
        public IRPSTextBox<SIISalesLedgerQueryView> TaxSalesInvoice_SentKeys { get; set; } 
        public IRPSTextBox<SIISalesLedgerQueryView> TaxSalesInvoice_SentInvoiceTo { get; set; } 
        public IRPSCheckbox<SIISalesLedgerQueryView> TaxSalesInvoice_IsATicket { get; set; } 
        public IRPSCheckbox<SIISalesLedgerQueryView> TaxSalesInvoice_IsAutoInvoice { get; set; } 
        public IRPSTextBox<SIISalesLedgerQueryView> TaxSalesInvoice_DeclarationYear { get; set; } 
        public IRPSTextBox<SIISalesLedgerQueryView> TaxSalesInvoice_DeclarationMonth { get; set; } 
        public IRPSTextBox<SIISalesLedgerQueryView> VatNumber { get; set; } 
        public IRPSTextBox<SIISalesLedgerQueryView> TaxSalesInvoice_CustomerName { get; set; } 
        public IRPSTextBox<SIISalesLedgerQueryView> ACCTransactions_VATARRegisterNumber { get; set; } 
        public IRPSTextBox<SIISalesLedgerQueryView> TaxSalesVAT_Usage303 { get; set; } 
        public IRPSCheckbox<SIISalesLedgerQueryView> TaxSalesVAT_Exclude { get; set; } 
        public IRPSCheckbox<SIISalesLedgerQueryView> TaxSalesVAT_IsPending { get; set; } 
        public IRPSCheckbox<SIISalesLedgerQueryView> TaxSalesVAT_IsSurchage { get; set; } 
        public IRPSTextBox<SIISalesLedgerQueryView> TaxSalesVAT_GoodsServices { get; set; } 
        public IRPSTextBox<SIISalesLedgerQueryView> TaxSalesVAT_VATType { get; set; } 
        public IRPSCheckbox<SIISalesLedgerQueryView> TaxSalesVAT_NotDeductible { get; set; } 
        public IRPSTextBox<SIISalesLedgerQueryView> ACCTransactions_CodDeliveryNote { get; set; } 
        public IRPSTextBox<SIISalesLedgerQueryView> ACCTransactions_DeliveryNoteDate { get; set; } 
        public IRPSTextBox<SIISalesLedgerQueryView> TaxSalesInvoice_OperationDate { get; set; } 
        public IRPSCheckbox<SIISalesLedgerQueryView> TaxSalesInvoice_IsAmendment { get; set; } 
        public IRPSTextBox<SIISalesLedgerQueryView> TaxSalesInvoice_FromCodInvoice { get; set; } 
        public IRPSTextBox<SIISalesLedgerQueryView> TaxSalesInvoice_FromInvoiceDate { get; set; } 
        public IRPSTextBox<SIISalesLedgerQueryView> TaxSalesInvoice_AmendmentType { get; set; } 
        public SIISalesLedgerCollectionEditor<SIISalesLedgerQueryView> SIISalesLedger { get; set; } 
        public SIISalesLedger Screen { get; set; }
        public SIISalesLedgerQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SIISalesLedgerCollectionEditor<SIISalesLedgerQueryView>:RPSCollectionEditor<SIISalesLedgerQueryView> where SIISalesLedgerQueryView : class, IView
    {
        public  SIISalesLedgerGridView<SIISalesLedgerQueryView> GridView {get;set;}
    }
    public partial class SIISalesLedgerGridView <SIISalesLedgerQueryView> :  RPSGridView<SIISalesLedgerQueryView> where SIISalesLedgerQueryView : class, IView
    {
        public SIISalesLedgerGridView(SIISalesLedgerQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            TaxSalesInvoice_DeclarationYear = RPSControlFactory.CreateRPSGridFormattedTextBox<SIISalesLedgerQueryView>("","#81268ab7-f1ae-4379-b11b-7d87be96caae .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesInvoice_DeclarationYear']","",false, this.CurrentView);
 
            TaxSalesInvoice_DeclarationMonth = RPSControlFactory.CreateRPSGridTextBox<SIISalesLedgerQueryView>("","#81268ab7-f1ae-4379-b11b-7d87be96caae .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesInvoice_DeclarationMonth']","",false, this.CurrentView);
 
            ACCTransactions_VATARRegisterNumber = RPSControlFactory.CreateRPSGridFormattedTextBox<SIISalesLedgerQueryView>("","#81268ab7-f1ae-4379-b11b-7d87be96caae .ag-row[role='row']@ROWINDEX [col-id='cACCTransactions_VATARRegisterNumber']","",false, this.CurrentView);
 
            CodInvoice = RPSControlFactory.CreateRPSGridTextBox<SIISalesLedgerQueryView>("","#81268ab7-f1ae-4379-b11b-7d87be96caae .ag-row[role='row']@ROWINDEX [col-id='cCodInvoice']","",false, this.CurrentView);
 
            TaxSalesInvoice_InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<SIISalesLedgerQueryView>("","#81268ab7-f1ae-4379-b11b-7d87be96caae .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesInvoice_InvoiceDate']","",false, this.CurrentView);
 
            TaxSalesInvoice_CustomerName = RPSControlFactory.CreateRPSGridTextBox<SIISalesLedgerQueryView>("","#81268ab7-f1ae-4379-b11b-7d87be96caae .ag-row[role='row']@ROWINDEX [col-id='cTaxSalesInvoice_CustomerName']","",false, this.CurrentView);
 
            VatNumber = RPSControlFactory.CreateRPSGridTextBox<SIISalesLedgerQueryView>("","#81268ab7-f1ae-4379-b11b-7d87be96caae .ag-row[role='row']@ROWINDEX [col-id='cVatNumber']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SIISalesLedgerQueryView> TaxSalesInvoice_DeclarationYear { get; set; } 
        public IRPSGridTextBox<SIISalesLedgerQueryView> TaxSalesInvoice_DeclarationMonth { get; set; } 
        public IRPSGridTextBox<SIISalesLedgerQueryView> ACCTransactions_VATARRegisterNumber { get; set; } 
        public IRPSGridTextBox<SIISalesLedgerQueryView> CodInvoice { get; set; } 
        public IRPSGridTextBox<SIISalesLedgerQueryView> TaxSalesInvoice_InvoiceDate { get; set; } 
        public IRPSGridTextBox<SIISalesLedgerQueryView> TaxSalesInvoice_CustomerName { get; set; } 
        public IRPSGridTextBox<SIISalesLedgerQueryView> VatNumber { get; set; } 
                     
    }
 
    }
  
    

}