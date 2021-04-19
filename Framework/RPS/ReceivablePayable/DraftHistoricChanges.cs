    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.ReceivablePayable.DraftHistoricChanges
{
    //RPS VERSION 1.0.0.0
    public partial class DraftHistoricChanges:Screen
    {
        public DraftHistoricChanges():base()
        {
            this.URL = "receivablepayable.drafthistoricchanges";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            RPTransactionsChangeVMQueryView  = new RPTransactionsChangeVMQueryView(this); 
            RPTransactionsChangeVMEntityView  = new RPTransactionsChangeVMEntityView(this); 
            RPTransactionsChangeVMQueryView.InitializeControls(); 
            RPTransactionsChangeVMEntityView.InitializeControls(); 
           
        }
      
            public RPTransactionsChangeVMQueryView RPTransactionsChangeVMQueryView {get; set; } 
            public RPTransactionsChangeVMEntityView RPTransactionsChangeVMEntityView {get; set; } 
    }
            
    public partial class RPTransactionsChangeVMQueryView : View
    {
        public RPTransactionsChangeVMQueryView(DraftHistoricChanges screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<RPTransactionsChangeVMQueryView,RPTransactionsChangeVMEntityView>( this,Screen.RPTransactionsChangeVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<RPTransactionsChangeVMQueryView>( this);
 
            CheckCustomer = RPSControlFactory.CreateRPSCheckBox<RPTransactionsChangeVMQueryView>("08caa098-c2ed-4e8e-9e0b-cfd8d448a1e9","","",false, this);
 
            CheckSupplier = RPSControlFactory.CreateRPSCheckBox<RPTransactionsChangeVMQueryView>("7a8f2adc-b97c-449e-9b8f-275139eda871","","",false, this);
 
            DateFromChange = RPSControlFactory.CreateRPSTextBox<RPTransactionsChangeVMQueryView>("381abc51-ad48-4da0-a00f-3947b9435c1f","","",false, this);
 
            DateToChange = RPSControlFactory.CreateRPSTextBox<RPTransactionsChangeVMQueryView>("264689b9-c712-4106-872f-d22650523dc9","","",false, this);
 
            Customer = RPSControlFactory.CreateRPSCollectionComboBox<RPTransactionsChangeVMQueryView>("66b339e6-47a1-454f-9a7b-86be890b25e4","","",false, this);
 
            Supplier = RPSControlFactory.CreateRPSCollectionComboBox<RPTransactionsChangeVMQueryView>("4786be42-87d1-4a58-9af2-2d6e2752d915","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<RPTransactionsChangeVMQueryView>("bcd71292-cad4-485c-ad53-971fa125f30d","","",false, this);
 
            IDPaymentStatusFrom = RPSControlFactory.CreateRPSComboBox<RPTransactionsChangeVMQueryView>("6656b6d3-4de3-4f2b-98e7-ba9de5f61bec","","",false, this);
 
            IDPaymentStatusTo = RPSControlFactory.CreateRPSComboBox<RPTransactionsChangeVMQueryView>("60da7500-5129-4f69-8600-a36a62281280","","",false, this);
 
            IDPaymentTypeFrom = RPSControlFactory.CreateRPSComboBox<RPTransactionsChangeVMQueryView>("4b3b6e2a-79aa-4b38-ac81-b965fe8dd19e","","",false, this);
 
            IDPaymentTypeTo = RPSControlFactory.CreateRPSComboBox<RPTransactionsChangeVMQueryView>("0c37d72a-fb15-4ca6-af6d-5bf6277eac18","","",false, this);
 
            CodInvoice = RPSControlFactory.CreateRPSTextBox<RPTransactionsChangeVMQueryView>("cba8a980-e4a5-4d22-a3cf-b0a5835b109f","","",false, this);
 
            DateFromInvoice = RPSControlFactory.CreateRPSTextBox<RPTransactionsChangeVMQueryView>("763ca425-73f6-456c-aaf7-691f7ce63bc9","","",false, this);
 
            DateToInvoice = RPSControlFactory.CreateRPSTextBox<RPTransactionsChangeVMQueryView>("e3212dd8-75b7-4b8e-aab4-e2c29290abf1","","",false, this);
 
            DateFromDue = RPSControlFactory.CreateRPSTextBox<RPTransactionsChangeVMQueryView>("5e33c14f-0205-453d-ab1c-8d8526ca007f","","",false, this);
 
            DateToDue = RPSControlFactory.CreateRPSTextBox<RPTransactionsChangeVMQueryView>("4a3b44bd-2c8d-41ec-949d-8ae956ea9e3c","","",false, this);
 
            ExecuteDeleteRPTranasactionsChangeButton = RPSControlFactory.CreateRPSButton<RPTransactionsChangeVMQueryView>( "e203154b-6da6-46be-9319-6626de32cea0","","",this);
 
            CollectionInit params_RPTransactionsChangeQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="21838e0d-ead2-42b5-8161-0e288b6b4fb5",CSSSelectorGrid="",XPathGrid=""};
            RPTransactionsChangeQuery = RPSControlFactory.RPSCreateCollectionWithGrid<RPTransactionsChangeQueryCollectionEditor<RPTransactionsChangeVMQueryView,RPTransactionsChangeVMEntityView>,RPTransactionsChangeVMQueryView,RPTransactionsChangeVMEntityView>( params_RPTransactionsChangeQuery,this,Screen.RPTransactionsChangeVMEntityView);
 

        }
        public IRPSButton<RPTransactionsChangeVMQueryView,RPTransactionsChangeVMEntityView> NewButton { get; set; } 
        public IRPSButton<RPTransactionsChangeVMQueryView> ConsultButton { get; set; } 
        public IRPSCheckbox<RPTransactionsChangeVMQueryView> CheckCustomer { get; set; } 
        public IRPSCheckbox<RPTransactionsChangeVMQueryView> CheckSupplier { get; set; } 
        public IRPSTextBox<RPTransactionsChangeVMQueryView> DateFromChange { get; set; } 
        public IRPSTextBox<RPTransactionsChangeVMQueryView> DateToChange { get; set; } 
        public IRPSCollectionComboBox<RPTransactionsChangeVMQueryView> Customer { get; set; } 
        public IRPSCollectionComboBox<RPTransactionsChangeVMQueryView> Supplier { get; set; } 
        public IRPSComboBox<RPTransactionsChangeVMQueryView> IDCurrency { get; set; } 
        public IRPSComboBox<RPTransactionsChangeVMQueryView> IDPaymentStatusFrom { get; set; } 
        public IRPSComboBox<RPTransactionsChangeVMQueryView> IDPaymentStatusTo { get; set; } 
        public IRPSComboBox<RPTransactionsChangeVMQueryView> IDPaymentTypeFrom { get; set; } 
        public IRPSComboBox<RPTransactionsChangeVMQueryView> IDPaymentTypeTo { get; set; } 
        public IRPSTextBox<RPTransactionsChangeVMQueryView> CodInvoice { get; set; } 
        public IRPSTextBox<RPTransactionsChangeVMQueryView> DateFromInvoice { get; set; } 
        public IRPSTextBox<RPTransactionsChangeVMQueryView> DateToInvoice { get; set; } 
        public IRPSTextBox<RPTransactionsChangeVMQueryView> DateFromDue { get; set; } 
        public IRPSTextBox<RPTransactionsChangeVMQueryView> DateToDue { get; set; } 
        public IRPSButton<RPTransactionsChangeVMQueryView> ExecuteDeleteRPTranasactionsChangeButton { get; set; } 
        public RPTransactionsChangeQueryCollectionEditor<RPTransactionsChangeVMQueryView,RPTransactionsChangeVMEntityView> RPTransactionsChangeQuery { get; set; } 
        public DraftHistoricChanges Screen { get; set; }
        public RPTransactionsChangeVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class RPTransactionsChangeQueryCollectionEditor<RPTransactionsChangeVMQueryView,RPTransactionsChangeVMEntityView>:RPSCollectionEditor<RPTransactionsChangeVMQueryView,RPTransactionsChangeVMEntityView> where RPTransactionsChangeVMQueryView : class, IView where RPTransactionsChangeVMEntityView : class, IView
    {
        public  RPTransactionsChangeQueryGridView<RPTransactionsChangeVMQueryView,RPTransactionsChangeVMEntityView> GridView {get;set;}
    }
    public partial class RPTransactionsChangeQueryGridView <RPTransactionsChangeVMQueryView,RPTransactionsChangeVMEntityView> :  RPSGridView<RPTransactionsChangeVMQueryView,RPTransactionsChangeVMEntityView> where RPTransactionsChangeVMQueryView : class, IView where RPTransactionsChangeVMEntityView : class, IView
    {
        public RPTransactionsChangeQueryGridView(RPTransactionsChangeVMQueryView currentView,RPTransactionsChangeVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            RPTransactionsChange_Operation = RPSControlFactory.CreateRPSGridTextBox<RPTransactionsChangeVMQueryView>("","#21838e0d-ead2-42b5-8161-0e288b6b4fb5 .ag-row[role='row']@ROWINDEX [col-id='cRPTransactionsChange_Operation']","",false, this.CurrentView);
 
            RPTransactionsChange_ChangeDate = RPSControlFactory.CreateRPSGridTextBox<RPTransactionsChangeVMQueryView>("","#21838e0d-ead2-42b5-8161-0e288b6b4fb5 .ag-row[role='row']@ROWINDEX [col-id='cRPTransactionsChange_ChangeDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<RPTransactionsChangeVMQueryView> RPTransactionsChange_Operation { get; set; } 
        public IRPSGridTextBox<RPTransactionsChangeVMQueryView> RPTransactionsChange_ChangeDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class RPTransactionsChangeVMEntityView : View
    {
        public RPTransactionsChangeVMEntityView(DraftHistoricChanges screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<RPTransactionsChangeVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<RPTransactionsChangeVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<RPTransactionsChangeVMEntityView,RPTransactionsChangeVMQueryView>( this,Screen.RPTransactionsChangeVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<RPTransactionsChangeVMEntityView,RPTransactionsChangeVMQueryView>( this,Screen.RPTransactionsChangeVMQueryView);
 
            Operation = RPSControlFactory.CreateRPSEnumComboBox<RPTransactionsChangeVMEntityView>("3a0e12e7-77c1-4bb0-b88d-514c0699889c","","",true, this);
 
            ChangeDate = RPSControlFactory.CreateRPSTextBox<RPTransactionsChangeVMEntityView>("76bc78e1-7fae-47d0-9843-aa16934f010c","","",true, this);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<RPTransactionsChangeVMEntityView>("981faafe-f240-448d-aa06-ed19b66db3ec","","",true, this);
 
            IDPaymentTypeFrom = RPSControlFactory.CreateRPSComboBox<RPTransactionsChangeVMEntityView>("03000e5d-421e-48c6-b5d4-4221b186a62d","","",true, this);
 
            IDPaymentStatusFrom = RPSControlFactory.CreateRPSComboBox<RPTransactionsChangeVMEntityView>("ff8a557b-fedb-4df0-a8d1-4fecaa4627d3","","",true, this);
 
            IDPaymentTypeTo = RPSControlFactory.CreateRPSComboBox<RPTransactionsChangeVMEntityView>("31a60f6e-968e-480c-a833-57638a69220c","","",true, this);
 
            IDPaymentStatusTo = RPSControlFactory.CreateRPSComboBox<RPTransactionsChangeVMEntityView>("35b6ddd3-96f0-4f6e-93e6-23876b364741","","",true, this);
 
            IDRPTransactions = RPSControlFactory.CreateRPSComboBox<RPTransactionsChangeVMEntityView>("a83b163a-f64a-49bc-b455-7f678aa34c33","","",true, this);
 
            CustomerSupplier = RPSControlFactory.CreateRPSEnumComboBox<RPTransactionsChangeVMEntityView>("8052ddf9-50b4-4a67-9b8a-65d6a8036aa3","","",true, this);
 
            Invoice = RPSControlFactory.CreateRPSComboBox<RPTransactionsChangeVMEntityView>("5f0a287c-9077-4104-8b70-62bb757d3659","","",false, this);
 
            InvoiceSL = RPSControlFactory.CreateRPSComboBox<RPTransactionsChangeVMEntityView>("a909f068-ec2d-4ceb-8e16-3fac69a37326","","",false, this);
 
            CodInvoice = RPSControlFactory.CreateRPSTextBox<RPTransactionsChangeVMEntityView>("39d01d34-3e51-4f69-aa37-a435b32082c4","","",true, this);
 
            DraftNumber = RPSControlFactory.CreateRPSFormattedTextBox<RPTransactionsChangeVMEntityView>("69e4d37e-24f2-423c-9754-399fdbf9398a","","",true, this);
 
            InvoiceDate = RPSControlFactory.CreateRPSTextBox<RPTransactionsChangeVMEntityView>("b331c921-ea39-4cb4-86b7-3555d7ebe1dd","","",true, this);
 
            DueDate = RPSControlFactory.CreateRPSTextBox<RPTransactionsChangeVMEntityView>("10a38553-dc7f-4ef1-bf19-3906ff5d2332","","",true, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<RPTransactionsChangeVMEntityView>("3e047bb7-b1a4-4d4b-bd04-1cab8aa28a89","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<RPTransactionsChangeVMEntityView>("2ad48627-2f28-48d9-bbaf-cd14253a49b3","","",false, this);
 
            IDCustomerMiscellaneous = RPSControlFactory.CreateRPSComboBox<RPTransactionsChangeVMEntityView>("c6cb46d3-42e7-4c2e-93b4-7e0627c7b3bb","","",false, this);
 
            IDSupplierMiscellaneous = RPSControlFactory.CreateRPSComboBox<RPTransactionsChangeVMEntityView>("cc3b6f8d-9ec5-41c2-899c-a935e09703ef","","",false, this);
 
            AmountNominal = RPSControlFactory.CreateRPSFormattedTextBox<RPTransactionsChangeVMEntityView>("8a0b4c37-e57d-4dea-9949-79b79a3cf62b","","",true, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<RPTransactionsChangeVMEntityView>("34ee8e2a-c940-4e15-b496-784225a8091f","","",true, this);
 
            AmountNominalCurrency = RPSControlFactory.CreateRPSFormattedTextBox<RPTransactionsChangeVMEntityView>("a5ce5719-43d8-4df4-bd3b-e3d3a7fe6e60","","",true, this);
 
            Change = RPSControlFactory.CreateRPSFormattedTextBox<RPTransactionsChangeVMEntityView>("54d14230-a71a-4027-83da-eb9e4a0ab58a","","",true, this);
 
            FixedChange = RPSControlFactory.CreateRPSCheckBox<RPTransactionsChangeVMEntityView>("7448f51d-76b7-4906-9d47-541d51c46d7f","","",true, this);
 
            CDDueDate = RPSControlFactory.CreateRPSTextBox<RPTransactionsChangeVMEntityView>("53144d65-8342-4370-b128-7430e3c5193b","","",false, this);
 
            CDAmount = RPSControlFactory.CreateRPSFormattedTextBox<RPTransactionsChangeVMEntityView>("7927b781-5976-453b-ac42-e6d12bb1f0e4","","",true, this);
 
            CDToleranceDueDate = RPSControlFactory.CreateRPSTextBox<RPTransactionsChangeVMEntityView>("576457de-f146-4d58-a382-887a3d374fa1","","",false, this);
 
            CDToleranceAmount = RPSControlFactory.CreateRPSFormattedTextBox<RPTransactionsChangeVMEntityView>("db2c5853-02d5-47d9-bd4e-0c86fa398c3b","","",true, this);
 
            CDUsed = RPSControlFactory.CreateRPSFormattedTextBox<RPTransactionsChangeVMEntityView>("f4fa3d9e-411b-4384-bd23-9575b977cf63","","",true, this);
 

        }
        public IRPSSaveButton<RPTransactionsChangeVMEntityView> SaveButton { get; set; } 
        public IRPSButton<RPTransactionsChangeVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<RPTransactionsChangeVMEntityView,RPTransactionsChangeVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<RPTransactionsChangeVMEntityView,RPTransactionsChangeVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<RPTransactionsChangeVMEntityView> Operation { get; set; } 
        public IRPSTextBox<RPTransactionsChangeVMEntityView> ChangeDate { get; set; } 
        public IRPSComboBox<RPTransactionsChangeVMEntityView> CodUser { get; set; } 
        public IRPSComboBox<RPTransactionsChangeVMEntityView> IDPaymentTypeFrom { get; set; } 
        public IRPSComboBox<RPTransactionsChangeVMEntityView> IDPaymentStatusFrom { get; set; } 
        public IRPSComboBox<RPTransactionsChangeVMEntityView> IDPaymentTypeTo { get; set; } 
        public IRPSComboBox<RPTransactionsChangeVMEntityView> IDPaymentStatusTo { get; set; } 
        public IRPSComboBox<RPTransactionsChangeVMEntityView> IDRPTransactions { get; set; } 
        public IRPSComboBox<RPTransactionsChangeVMEntityView> CustomerSupplier { get; set; } 
        public IRPSComboBox<RPTransactionsChangeVMEntityView> Invoice { get; set; } 
        public IRPSComboBox<RPTransactionsChangeVMEntityView> InvoiceSL { get; set; } 
        public IRPSTextBox<RPTransactionsChangeVMEntityView> CodInvoice { get; set; } 
        public IRPSTextBox<RPTransactionsChangeVMEntityView> DraftNumber { get; set; } 
        public IRPSTextBox<RPTransactionsChangeVMEntityView> InvoiceDate { get; set; } 
        public IRPSTextBox<RPTransactionsChangeVMEntityView> DueDate { get; set; } 
        public IRPSComboBox<RPTransactionsChangeVMEntityView> IDSupplier { get; set; } 
        public IRPSComboBox<RPTransactionsChangeVMEntityView> IDCustomer { get; set; } 
        public IRPSComboBox<RPTransactionsChangeVMEntityView> IDCustomerMiscellaneous { get; set; } 
        public IRPSComboBox<RPTransactionsChangeVMEntityView> IDSupplierMiscellaneous { get; set; } 
        public IRPSTextBox<RPTransactionsChangeVMEntityView> AmountNominal { get; set; } 
        public IRPSComboBox<RPTransactionsChangeVMEntityView> IDCurrency { get; set; } 
        public IRPSTextBox<RPTransactionsChangeVMEntityView> AmountNominalCurrency { get; set; } 
        public IRPSTextBox<RPTransactionsChangeVMEntityView> Change { get; set; } 
        public IRPSCheckbox<RPTransactionsChangeVMEntityView> FixedChange { get; set; } 
        public IRPSTextBox<RPTransactionsChangeVMEntityView> CDDueDate { get; set; } 
        public IRPSTextBox<RPTransactionsChangeVMEntityView> CDAmount { get; set; } 
        public IRPSTextBox<RPTransactionsChangeVMEntityView> CDToleranceDueDate { get; set; } 
        public IRPSTextBox<RPTransactionsChangeVMEntityView> CDToleranceAmount { get; set; } 
        public IRPSTextBox<RPTransactionsChangeVMEntityView> CDUsed { get; set; } 
        public DraftHistoricChanges Screen { get; set; }
        public RPTransactionsChangeVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}