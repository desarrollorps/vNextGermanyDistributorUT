    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.InvoiceChargingIntrastat
{
    //RPS VERSION 1.0.0.0
    public partial class InvoiceChargingIntrastat:Screen
    {
        public InvoiceChargingIntrastat():base()
        {
            this.URL = "purchase.invoicechargingintrastat";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            InvoiceCollectionView  = new InvoiceCollectionView(this); 
            InvoiceEntityView  = new InvoiceEntityView(this); 
            RecalculateIntrastatCostChildDialogView  = new RecalculateIntrastatCostChildDialogView(this); 
            InvoiceCollectionView.InitializeControls(); 
            InvoiceEntityView.InitializeControls(); 
            RecalculateIntrastatCostChildDialogView.InitializeControls(); 
           
        }
      
            public InvoiceCollectionView InvoiceCollectionView {get; set; } 
            public InvoiceEntityView InvoiceEntityView {get; set; } 
            public RecalculateIntrastatCostChildDialogView RecalculateIntrastatCostChildDialogView {get; set; } 
    }
            
    public partial class InvoiceCollectionView : View
    {
        public InvoiceCollectionView(InvoiceChargingIntrastat screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<InvoiceCollectionView,InvoiceEntityView>( this,Screen.InvoiceEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "38e14271-9575-420a-9b3b-d063ff44b4e2",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<InvoiceCollectionView,InvoiceEntityView>( params_MainConsult,this,Screen.InvoiceEntityView);
 

        }
        public IRPSButton<InvoiceCollectionView,InvoiceEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<InvoiceCollectionView,InvoiceEntityView> MainConsult { get; set; } 
        public InvoiceChargingIntrastat Screen { get; set; }
        public InvoiceCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class InvoiceEntityView : View
    {
        public InvoiceEntityView(InvoiceChargingIntrastat screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<InvoiceEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<InvoiceEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<InvoiceEntityView,InvoiceCollectionView>( this,Screen.InvoiceCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<InvoiceEntityView,InvoiceCollectionView>( this,Screen.InvoiceCollectionView);
 
            CodInvoice1 = RPSControlFactory.CreateRPSTextBox<InvoiceEntityView>("7016e869-e1a7-4d40-b180-fe918eec9975","","",true, this);
 
            IDContactAdministration1 = RPSControlFactory.CreateRPSComboBox<InvoiceEntityView>("ad0e9832-a261-4994-a377-598b9f400302","","",false, this);
 
            VATNumber1 = RPSControlFactory.CreateRPSTextBox<InvoiceEntityView>("c2aba83e-2ae9-42b0-b963-9abdc22fc334","","",false, this);
 
            IDSupplier1 = RPSControlFactory.CreateRPSComboBox<InvoiceEntityView>("bf72e710-d2e6-4f25-8ddc-23b8151170a9","","",true, this);
 
            InvoiceDate = RPSControlFactory.CreateRPSTextBox<InvoiceEntityView>("3b51d5da-eeb1-4e67-97b2-18d2626a04a3","","",true, this);
 
            DocumentType = RPSControlFactory.CreateRPSEnumComboBox<InvoiceEntityView>("33c42d05-ed3b-49dd-996c-fdf0ee34e235","","",true, this);
 
            CodFromInvoice = RPSControlFactory.CreateRPSTextBox<InvoiceEntityView>("2626c1c8-55d3-428e-b1ac-46ca50215316","","",false, this);
 
            AdvanceInvoice = RPSControlFactory.CreateRPSCheckBox<InvoiceEntityView>("e91d5c21-fb00-4f4a-9c1f-360a7288fec5","","",true, this);
 
            AccountingDate = RPSControlFactory.CreateRPSTextBox<InvoiceEntityView>("c0997982-2aff-4266-a7d0-7593fbb68c64","","",false, this);
 
            UIJournalNumber = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("e35e18b6-c70a-4429-aae8-9c4d2ca54cea","","",false, this);
 
            VATAPRegisterNumber = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("fe04d4e8-03e7-4da9-bfd4-8a0f43cb2a9f","","",true, this);
 
            UICodCompanySales = RPSControlFactory.CreateRPSTextBox<InvoiceEntityView>("604ad5d7-f93b-44ae-8674-652d11411e57","","",false, this);
 
            UICodInvoiceSales = RPSControlFactory.CreateRPSTextBox<InvoiceEntityView>("e15e6412-52ff-47cd-81ce-36cd10a0d2f8","","",false, this);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSComboBox<InvoiceEntityView>("e33fe9b3-7a93-4a26-9420-7c25f20f7fce","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<InvoiceEntityView>("1585940e-13ca-4008-b93c-33a56f6ba2e4","","",true, this);
 
            Change = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("30e299fb-3f41-44f8-a421-9d466dedb96b","","",true, this);
 
            FixedChange = RPSControlFactory.CreateRPSCheckBox<InvoiceEntityView>("0e881716-8b56-4bf9-963c-288d1862f160","","",true, this);
 
            IDBusinessUnit = RPSControlFactory.CreateRPSComboBox<InvoiceEntityView>("9f7726bb-8823-4919-9287-4f5e4f66ce90","","",false, this);
 
            IDVATType = RPSControlFactory.CreateRPSComboBox<InvoiceEntityView>("334e3624-10db-47bf-9a20-3b0401fc5fe9","","",true, this);
 
            IDSurchargeVATType = RPSControlFactory.CreateRPSComboBox<InvoiceEntityView>("027b2fa2-4992-4074-b302-12f1d938306d","","",false, this);
 
            IDTaxGroup = RPSControlFactory.CreateRPSComboBox<InvoiceEntityView>("1955f1fe-6042-4d48-9679-c02d8f04ba45","","",false, this);
 
            IDSupplierBankAccount = RPSControlFactory.CreateRPSComboBox<InvoiceEntityView>("6b9cfc9d-ee2d-44fc-a1ac-6cc7948c4c03","","",false, this);
 
            IDVoucherType = RPSControlFactory.CreateRPSComboBox<InvoiceEntityView>("87eed9f8-9162-48e8-b9f0-22d699cfc167","","",false, this);
 
            IDBankAccountCompany = RPSControlFactory.CreateRPSComboBox<InvoiceEntityView>("183b7062-539f-4bac-bf83-ed5aba329882","","",false, this);
 
            IDInvoicingType = RPSControlFactory.CreateRPSComboBox<InvoiceEntityView>("5d62ae3b-efb5-48f3-9097-f90575368964","","",true, this);
 
            IDInvoicingPoint = RPSControlFactory.CreateRPSTextBox<InvoiceEntityView>("32ee5530-a261-486c-aed3-55e91d3fca72","","",false, this);
 
            Discount1 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("c06d33a4-7500-4b4b-be2f-02b56d2a0186","","",true, this);
 
            Discount2 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("7fd98f53-59cc-462c-bd32-c02c691f9501","","",true, this);
 
            Discount3 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("79117945-dbcd-475e-9e1c-396d58b45b5e","","",true, this);
 
            CashDiscount = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("cd4540d8-c0e3-41b6-9667-5f61a7260073","","",true, this);
 
            FinancialSurcharge = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("97d799dd-5729-41e3-a023-ee7a12d9f447","","",true, this);
 
            RetentionPercent = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceEntityView>("2423afb3-3e05-4792-a9cd-d20b8d3e8bfb","","",true, this);
 
            IDMaintenanceOrder = RPSControlFactory.CreateRPSComboBox<InvoiceEntityView>("2f63bfab-1cf0-45c7-b99b-4453282f0632","","",false, this);
 
            UICodMaintenanceContract = RPSControlFactory.CreateRPSTextBox<InvoiceEntityView>("a51bcdfb-e276-4565-9183-f7f45b960e6b","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<InvoiceEntityView>("d1dab270-b64f-4aec-83ef-e367ff5aad09","","",false, this);
 
            RecalculateIntrastatCostChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<InvoiceEntityView,RecalculateIntrastatCostChildDialogView>("60e9a760-2ee3-4974-97ab-5d3b58db61ca","","", this,Screen.RecalculateIntrastatCostChildDialogView);
 
            CollectionInit params_InvoiceLines = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="dc1a1489-b4ff-47a3-bf45-2e23cc6983e4",CSSSelectorGrid="",XPathGrid=""};
            InvoiceLines = RPSControlFactory.RPSCreateCollectionWithGrid<InvoiceLinesCollectionEditor<InvoiceEntityView,RecalculateIntrastatCostChildDialogView>,InvoiceEntityView,RecalculateIntrastatCostChildDialogView>( params_InvoiceLines,this,Screen.RecalculateIntrastatCostChildDialogView);
 
            LinesSection = RPSControlFactory.CreateRPSSection<InvoiceEntityView>( "","ul li[rpsid='510cc874-8ff0-49a6-9251-83d38bbfc332']","",this);
 
            DatosBásicos = RPSControlFactory.CreateRPSSection<InvoiceEntityView>( "","ul li[rpsid='d2ed10f8-c023-457b-8535-e313c03ed947']","",this);
 
            CommentSection = RPSControlFactory.CreateRPSSection<InvoiceEntityView>( "","ul li[rpsid='8773af5c-539a-4c78-981d-d6c3a90b55f8']","",this);
 

        }
        public IRPSSaveButton<InvoiceEntityView> SaveButton { get; set; } 
        public IRPSButton<InvoiceEntityView> DeleteButton { get; set; } 
        public IRPSButton<InvoiceEntityView,InvoiceCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<InvoiceEntityView,InvoiceCollectionView> BackButton { get; set; } 
        public IRPSTextBox<InvoiceEntityView> CodInvoice1 { get; set; } 
        public IRPSComboBox<InvoiceEntityView> IDContactAdministration1 { get; set; } 
        public IRPSTextBox<InvoiceEntityView> VATNumber1 { get; set; } 
        public IRPSComboBox<InvoiceEntityView> IDSupplier1 { get; set; } 
        public IRPSTextBox<InvoiceEntityView> InvoiceDate { get; set; } 
        public IRPSComboBox<InvoiceEntityView> DocumentType { get; set; } 
        public IRPSTextBox<InvoiceEntityView> CodFromInvoice { get; set; } 
        public IRPSCheckbox<InvoiceEntityView> AdvanceInvoice { get; set; } 
        public IRPSTextBox<InvoiceEntityView> AccountingDate { get; set; } 
        public IRPSTextBox<InvoiceEntityView> UIJournalNumber { get; set; } 
        public IRPSTextBox<InvoiceEntityView> VATAPRegisterNumber { get; set; } 
        public IRPSTextBox<InvoiceEntityView> UICodCompanySales { get; set; } 
        public IRPSTextBox<InvoiceEntityView> UICodInvoiceSales { get; set; } 
        public IRPSComboBox<InvoiceEntityView> IDPaymentMethod { get; set; } 
        public IRPSComboBox<InvoiceEntityView> IDCurrency { get; set; } 
        public IRPSTextBox<InvoiceEntityView> Change { get; set; } 
        public IRPSCheckbox<InvoiceEntityView> FixedChange { get; set; } 
        public IRPSComboBox<InvoiceEntityView> IDBusinessUnit { get; set; } 
        public IRPSComboBox<InvoiceEntityView> IDVATType { get; set; } 
        public IRPSComboBox<InvoiceEntityView> IDSurchargeVATType { get; set; } 
        public IRPSComboBox<InvoiceEntityView> IDTaxGroup { get; set; } 
        public IRPSComboBox<InvoiceEntityView> IDSupplierBankAccount { get; set; } 
        public IRPSComboBox<InvoiceEntityView> IDVoucherType { get; set; } 
        public IRPSComboBox<InvoiceEntityView> IDBankAccountCompany { get; set; } 
        public IRPSComboBox<InvoiceEntityView> IDInvoicingType { get; set; } 
        public IRPSTextBox<InvoiceEntityView> IDInvoicingPoint { get; set; } 
        public IRPSTextBox<InvoiceEntityView> Discount1 { get; set; } 
        public IRPSTextBox<InvoiceEntityView> Discount2 { get; set; } 
        public IRPSTextBox<InvoiceEntityView> Discount3 { get; set; } 
        public IRPSTextBox<InvoiceEntityView> CashDiscount { get; set; } 
        public IRPSTextBox<InvoiceEntityView> FinancialSurcharge { get; set; } 
        public IRPSTextBox<InvoiceEntityView> RetentionPercent { get; set; } 
        public IRPSComboBox<InvoiceEntityView> IDMaintenanceOrder { get; set; } 
        public IRPSTextBox<InvoiceEntityView> UICodMaintenanceContract { get; set; } 
        public IRPSTextBox<InvoiceEntityView> Comment { get; set; } 
        public IRPSButton<InvoiceEntityView,RecalculateIntrastatCostChildDialogView> RecalculateIntrastatCostChildNavigationCommandButton { get; set; } 
        public InvoiceLinesCollectionEditor<InvoiceEntityView,RecalculateIntrastatCostChildDialogView> InvoiceLines { get; set; } 
        public IRPSSection<InvoiceEntityView> LinesSection { get; set; } 
        public IRPSSection<InvoiceEntityView> DatosBásicos { get; set; } 
        public IRPSSection<InvoiceEntityView> CommentSection { get; set; } 
        public InvoiceChargingIntrastat Screen { get; set; }
        public InvoiceEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class InvoiceLinesCollectionEditor<InvoiceEntityView,RecalculateIntrastatCostChildDialogView>:RPSCollectionEditor<InvoiceEntityView,RecalculateIntrastatCostChildDialogView> where InvoiceEntityView : class, IView where RecalculateIntrastatCostChildDialogView : class, IView
    {
        public  InvoiceLinesGridView<InvoiceEntityView,RecalculateIntrastatCostChildDialogView> GridView {get;set;}
    }
    public partial class InvoiceLinesGridView <InvoiceEntityView,RecalculateIntrastatCostChildDialogView> :  RPSGridView<InvoiceEntityView,RecalculateIntrastatCostChildDialogView> where InvoiceEntityView : class, IView where RecalculateIntrastatCostChildDialogView : class, IView
    {
        public InvoiceLinesGridView(InvoiceEntityView currentView,RecalculateIntrastatCostChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodDeliveryNote = RPSControlFactory.CreateRPSGridTextBox<InvoiceEntityView>("","#dc1a1489-b4ff-47a3-bf45-2e23cc6983e4 .ag-row[role='row']@ROWINDEX [col-id='cCodDeliveryNote']","",false, this.CurrentView);
 
            CodOrder = RPSControlFactory.CreateRPSGridTextBox<InvoiceEntityView>("","#dc1a1489-b4ff-47a3-bf45-2e23cc6983e4 .ag-row[role='row']@ROWINDEX [col-id='cCodOrder']","",false, this.CurrentView);
 
            Ordenation = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceEntityView>("","#dc1a1489-b4ff-47a3-bf45-2e23cc6983e4 .ag-row[role='row']@ROWINDEX [col-id='cOrdenation']","",true, this.CurrentView);
 
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<InvoiceEntityView>("","#dc1a1489-b4ff-47a3-bf45-2e23cc6983e4 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceEntityView>("","#dc1a1489-b4ff-47a3-bf45-2e23cc6983e4 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceEntityView>("","#dc1a1489-b4ff-47a3-bf45-2e23cc6983e4 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            BaseIntrastat = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceEntityView>("","#dc1a1489-b4ff-47a3-bf45-2e23cc6983e4 .ag-row[role='row']@ROWINDEX [col-id='cBaseIntrastat']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<InvoiceEntityView> CodDeliveryNote { get; set; } 
        public IRPSGridTextBox<InvoiceEntityView> CodOrder { get; set; } 
        public IRPSGridTextBox<InvoiceEntityView> Ordenation { get; set; } 
        public IRPSGridComboBox<InvoiceEntityView> IDArticle { get; set; } 
        public IRPSGridTextBox<InvoiceEntityView> Quantity { get; set; } 
        public IRPSGridTextBox<InvoiceEntityView> Amount { get; set; } 
        public IRPSGridTextBox<InvoiceEntityView> BaseIntrastat { get; set; } 
                     
    }
 
    }
  
            
    public partial class RecalculateIntrastatCostChildDialogView : View
    {
        public RecalculateIntrastatCostChildDialogView(InvoiceChargingIntrastat screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CodDeliveryNoteTerm = RPSControlFactory.CreateRPSTextBox<RecalculateIntrastatCostChildDialogView>("061e7464-0ff5-4fd4-83c7-87919cd14610","","",false, this);
 
            Porcent = RPSControlFactory.CreateRPSFormattedTextBox<RecalculateIntrastatCostChildDialogView>("00f449ff-954f-497a-9ed3-fafab8dfc588","","",false, this);
 
            IntrastatCost = RPSControlFactory.CreateRPSFormattedTextBox<RecalculateIntrastatCostChildDialogView>("01b930f1-5d38-43b2-9ba8-2600f2884583","","",false, this);
 

        }
        public IRPSTextBox<RecalculateIntrastatCostChildDialogView> CodDeliveryNoteTerm { get; set; } 
        public IRPSTextBox<RecalculateIntrastatCostChildDialogView> Porcent { get; set; } 
        public IRPSTextBox<RecalculateIntrastatCostChildDialogView> IntrastatCost { get; set; } 
        public InvoiceChargingIntrastat Screen { get; set; }
        public RecalculateIntrastatCostChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}