    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.InvoiceSLChargingIntrastat
{
    //RPS VERSION 1.0.0.0
    public partial class InvoiceSLChargingIntrastat:Screen
    {
        public InvoiceSLChargingIntrastat():base()
        {
            this.URL = "sales.invoiceslchargingintrastat";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            InvoiceSLCollectionView  = new InvoiceSLCollectionView(this); 
            InvoiceSLEntityView  = new InvoiceSLEntityView(this); 
            RecalculateIntrastatCostChildDialogView  = new RecalculateIntrastatCostChildDialogView(this); 
            InvoiceSLCollectionView.InitializeControls(); 
            InvoiceSLEntityView.InitializeControls(); 
            RecalculateIntrastatCostChildDialogView.InitializeControls(); 
           
        }
      
            public InvoiceSLCollectionView InvoiceSLCollectionView {get; set; } 
            public InvoiceSLEntityView InvoiceSLEntityView {get; set; } 
            public RecalculateIntrastatCostChildDialogView RecalculateIntrastatCostChildDialogView {get; set; } 
    }
            
    public partial class InvoiceSLCollectionView : View
    {
        public InvoiceSLCollectionView(InvoiceSLChargingIntrastat screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<InvoiceSLCollectionView,InvoiceSLEntityView>( this,Screen.InvoiceSLEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "b9fa2090-ad6a-4dd1-bb5c-07e3a2b91025",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<InvoiceSLCollectionView,InvoiceSLEntityView>( params_MainConsult,this,Screen.InvoiceSLEntityView);
 

        }
        public IRPSButton<InvoiceSLCollectionView,InvoiceSLEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<InvoiceSLCollectionView,InvoiceSLEntityView> MainConsult { get; set; } 
        public InvoiceSLChargingIntrastat Screen { get; set; }
        public InvoiceSLCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class InvoiceSLEntityView : View
    {
        public InvoiceSLEntityView(InvoiceSLChargingIntrastat screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<InvoiceSLEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<InvoiceSLEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<InvoiceSLEntityView,InvoiceSLCollectionView>( this,Screen.InvoiceSLCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<InvoiceSLEntityView,InvoiceSLCollectionView>( this,Screen.InvoiceSLCollectionView);
 
            CodInvoice = RPSControlFactory.CreateRPSTextBox<InvoiceSLEntityView>("6b9c704d-8566-477c-af4d-e020a63d5791","","",true, this);
 
            IDContactAdministration = RPSControlFactory.CreateRPSComboBox<InvoiceSLEntityView>("88c6e0ba-9673-4df4-907f-06b840cc3466","","",false, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<InvoiceSLEntityView>("818e85a2-2d39-4205-8cd3-f8d0bb10dacf","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<InvoiceSLEntityView>("2fe651ee-fae7-4ff9-8467-8ab454479768","","",true, this);
 
            InvoiceDate = RPSControlFactory.CreateRPSTextBox<InvoiceSLEntityView>("a5f4fc66-db57-4966-80ff-b44580c0d1e6","","",true, this);
 
            DocumentType = RPSControlFactory.CreateRPSEnumComboBox<InvoiceSLEntityView>("291ae5f8-5bfb-497b-9724-dca38cb5b62d","","",false, this);
 
            CodFromInvoice = RPSControlFactory.CreateRPSTextBox<InvoiceSLEntityView>("e862731c-950c-47ce-9adf-a678725ed7e6","","",false, this);
 
            AdvanceInvoice = RPSControlFactory.CreateRPSCheckBox<InvoiceSLEntityView>("3168d380-eae3-4534-a988-85fbb9378e0f","","",true, this);
 
            AccountingDate = RPSControlFactory.CreateRPSTextBox<InvoiceSLEntityView>("5b0efa41-2284-4151-a84e-290122d2a9df","","",false, this);
 
            UIJournalNumber = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("356a44d2-0c9e-4010-8312-0b7df5907ebf","","",false, this);
 
            UICodCompanySales = RPSControlFactory.CreateRPSTextBox<InvoiceSLEntityView>("604ad5d7-f93b-44ae-8674-652d11411e57","","",false, this);
 
            UICodInvoiceSales = RPSControlFactory.CreateRPSTextBox<InvoiceSLEntityView>("e15e6412-52ff-47cd-81ce-36cd10a0d2f8","","",false, this);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSComboBox<InvoiceSLEntityView>("034a64b4-c8ba-4ca9-a978-b807f45facee","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<InvoiceSLEntityView>("947c991b-e83b-4469-8bb3-991db3572e84","","",true, this);
 
            Change = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("e3e30770-ec45-40b2-a185-e59a44d2f157","","",true, this);
 
            FixedChange = RPSControlFactory.CreateRPSCheckBox<InvoiceSLEntityView>("fbbf6c82-96c0-4a9b-9d2c-2d46dd8cf6fb","","",true, this);
 
            IDBusinessUnit = RPSControlFactory.CreateRPSComboBox<InvoiceSLEntityView>("cde2ccf4-cb48-4b4d-b134-b5a53cb7ebca","","",false, this);
 
            IDVATType = RPSControlFactory.CreateRPSComboBox<InvoiceSLEntityView>("bbac7cca-6fd8-49a9-9635-1ac4904314e2","","",true, this);
 
            IDSurchargeVATType = RPSControlFactory.CreateRPSComboBox<InvoiceSLEntityView>("a5a3ed8b-c749-4ec6-8c73-9b6220432f1e","","",false, this);
 
            IDTaxGroup = RPSControlFactory.CreateRPSComboBox<InvoiceSLEntityView>("835d6099-fd03-4a81-964f-ffab87b43ad9","","",false, this);
 
            IDCustomerBankAccount = RPSControlFactory.CreateRPSComboBox<InvoiceSLEntityView>("588083c2-1c65-426a-8afd-ef7d822b3cce","","",false, this);
 
            IDVoucherType = RPSControlFactory.CreateRPSComboBox<InvoiceSLEntityView>("733c9f6b-76b1-44a3-bb29-5919009dcda3","","",false, this);
 
            IDBankAccountCompany = RPSControlFactory.CreateRPSComboBox<InvoiceSLEntityView>("2516696c-3c48-4834-9637-4edacf110f52","","",false, this);
 
            IDInvoicingType = RPSControlFactory.CreateRPSComboBox<InvoiceSLEntityView>("f4c0ae30-20ce-4014-8ce2-30a7241712e2","","",true, this);
 
            Discount1 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("8304ba23-59c8-4b2f-883f-74302e8c1280","","",true, this);
 
            Discount2 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("09d3e0e3-710a-4346-9323-7c6650f85633","","",true, this);
 
            Discount3 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("0704a706-60f1-4889-9008-3d1afe973dfb","","",true, this);
 
            CashDiscount = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("0cdaa6ed-610e-41af-b0db-db2d2db3f5e8","","",true, this);
 
            FinancialSurcharge = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("0eb44b01-aa68-46d8-b46f-408facf26cf8","","",true, this);
 
            RetentionPercent = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceSLEntityView>("d47030e0-1806-41f7-a8d3-d2711797619e","","",true, this);
 
            IDMaintenanceOrder = RPSControlFactory.CreateRPSComboBox<InvoiceSLEntityView>("bde9eb4e-9974-4d9e-9c32-7596146becf1","","",false, this);
 
            UICodMaintenanceContract = RPSControlFactory.CreateRPSTextBox<InvoiceSLEntityView>("a51bcdfb-e276-4565-9183-f7f45b960e6b","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<InvoiceSLEntityView>("1f7e39bb-457a-47a5-b065-9d44a010b9f6","","",false, this);
 
            RecalculateIntrastatCostChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<InvoiceSLEntityView,RecalculateIntrastatCostChildDialogView>("2277d792-7bac-4a6f-b4c8-6d6f7fad8ecc","","", this,Screen.RecalculateIntrastatCostChildDialogView);
 
            CollectionInit params_InvoiceLineSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="03267ae2-b4ba-43a0-8600-fa89952e5631",CSSSelectorGrid="",XPathGrid=""};
            InvoiceLineSLs = RPSControlFactory.RPSCreateCollectionWithGrid<InvoiceLineSLsCollectionEditor<InvoiceSLEntityView,RecalculateIntrastatCostChildDialogView>,InvoiceSLEntityView,RecalculateIntrastatCostChildDialogView>( params_InvoiceLineSLs,this,Screen.RecalculateIntrastatCostChildDialogView);
 
            LinesSection = RPSControlFactory.CreateRPSSection<InvoiceSLEntityView>( "","ul li[rpsid='510cc874-8ff0-49a6-9251-83d38bbfc332']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<InvoiceSLEntityView>( "","ul li[rpsid='d2ed10f8-c023-457b-8535-e313c03ed947']","",this);
 
            CommentSection = RPSControlFactory.CreateRPSSection<InvoiceSLEntityView>( "","ul li[rpsid='8773af5c-539a-4c78-981d-d6c3a90b55f8']","",this);
 

        }
        public IRPSSaveButton<InvoiceSLEntityView> SaveButton { get; set; } 
        public IRPSButton<InvoiceSLEntityView> DeleteButton { get; set; } 
        public IRPSButton<InvoiceSLEntityView,InvoiceSLCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<InvoiceSLEntityView,InvoiceSLCollectionView> BackButton { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> CodInvoice { get; set; } 
        public IRPSComboBox<InvoiceSLEntityView> IDContactAdministration { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> VATNumber { get; set; } 
        public IRPSComboBox<InvoiceSLEntityView> IDCustomer { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> InvoiceDate { get; set; } 
        public IRPSComboBox<InvoiceSLEntityView> DocumentType { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> CodFromInvoice { get; set; } 
        public IRPSCheckbox<InvoiceSLEntityView> AdvanceInvoice { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> AccountingDate { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> UIJournalNumber { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> UICodCompanySales { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> UICodInvoiceSales { get; set; } 
        public IRPSComboBox<InvoiceSLEntityView> IDPaymentMethod { get; set; } 
        public IRPSComboBox<InvoiceSLEntityView> IDCurrency { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> Change { get; set; } 
        public IRPSCheckbox<InvoiceSLEntityView> FixedChange { get; set; } 
        public IRPSComboBox<InvoiceSLEntityView> IDBusinessUnit { get; set; } 
        public IRPSComboBox<InvoiceSLEntityView> IDVATType { get; set; } 
        public IRPSComboBox<InvoiceSLEntityView> IDSurchargeVATType { get; set; } 
        public IRPSComboBox<InvoiceSLEntityView> IDTaxGroup { get; set; } 
        public IRPSComboBox<InvoiceSLEntityView> IDCustomerBankAccount { get; set; } 
        public IRPSComboBox<InvoiceSLEntityView> IDVoucherType { get; set; } 
        public IRPSComboBox<InvoiceSLEntityView> IDBankAccountCompany { get; set; } 
        public IRPSComboBox<InvoiceSLEntityView> IDInvoicingType { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> Discount1 { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> Discount2 { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> Discount3 { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> CashDiscount { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> FinancialSurcharge { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> RetentionPercent { get; set; } 
        public IRPSComboBox<InvoiceSLEntityView> IDMaintenanceOrder { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> UICodMaintenanceContract { get; set; } 
        public IRPSTextBox<InvoiceSLEntityView> Comment { get; set; } 
        public IRPSButton<InvoiceSLEntityView,RecalculateIntrastatCostChildDialogView> RecalculateIntrastatCostChildNavigationCommandButton { get; set; } 
        public InvoiceLineSLsCollectionEditor<InvoiceSLEntityView,RecalculateIntrastatCostChildDialogView> InvoiceLineSLs { get; set; } 
        public IRPSSection<InvoiceSLEntityView> LinesSection { get; set; } 
        public IRPSSection<InvoiceSLEntityView> Section1 { get; set; } 
        public IRPSSection<InvoiceSLEntityView> CommentSection { get; set; } 
        public InvoiceSLChargingIntrastat Screen { get; set; }
        public InvoiceSLEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class InvoiceLineSLsCollectionEditor<InvoiceSLEntityView,RecalculateIntrastatCostChildDialogView>:RPSCollectionEditor<InvoiceSLEntityView,RecalculateIntrastatCostChildDialogView> where InvoiceSLEntityView : class, IView where RecalculateIntrastatCostChildDialogView : class, IView
    {
        public  InvoiceLineSLsGridView<InvoiceSLEntityView,RecalculateIntrastatCostChildDialogView> GridView {get;set;}
    }
    public partial class InvoiceLineSLsGridView <InvoiceSLEntityView,RecalculateIntrastatCostChildDialogView> :  RPSGridView<InvoiceSLEntityView,RecalculateIntrastatCostChildDialogView> where InvoiceSLEntityView : class, IView where RecalculateIntrastatCostChildDialogView : class, IView
    {
        public InvoiceLineSLsGridView(InvoiceSLEntityView currentView,RecalculateIntrastatCostChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodDeliveryNote = RPSControlFactory.CreateRPSGridTextBox<InvoiceSLEntityView>("","#03267ae2-b4ba-43a0-8600-fa89952e5631 .ag-row[role='row']@ROWINDEX [col-id='cCodDeliveryNote']","",false, this.CurrentView);
 
            CodOrder = RPSControlFactory.CreateRPSGridTextBox<InvoiceSLEntityView>("","#03267ae2-b4ba-43a0-8600-fa89952e5631 .ag-row[role='row']@ROWINDEX [col-id='cCodOrder']","",false, this.CurrentView);
 
            Ordenation = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceSLEntityView>("","#03267ae2-b4ba-43a0-8600-fa89952e5631 .ag-row[role='row']@ROWINDEX [col-id='cOrdenation']","",true, this.CurrentView);
 
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<InvoiceSLEntityView>("","#03267ae2-b4ba-43a0-8600-fa89952e5631 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceSLEntityView>("","#03267ae2-b4ba-43a0-8600-fa89952e5631 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceSLEntityView>("","#03267ae2-b4ba-43a0-8600-fa89952e5631 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            BaseIntrastat = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceSLEntityView>("","#03267ae2-b4ba-43a0-8600-fa89952e5631 .ag-row[role='row']@ROWINDEX [col-id='cBaseIntrastat']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<InvoiceSLEntityView> CodDeliveryNote { get; set; } 
        public IRPSGridTextBox<InvoiceSLEntityView> CodOrder { get; set; } 
        public IRPSGridTextBox<InvoiceSLEntityView> Ordenation { get; set; } 
        public IRPSGridComboBox<InvoiceSLEntityView> IDArticle { get; set; } 
        public IRPSGridTextBox<InvoiceSLEntityView> Quantity { get; set; } 
        public IRPSGridTextBox<InvoiceSLEntityView> Amount { get; set; } 
        public IRPSGridTextBox<InvoiceSLEntityView> BaseIntrastat { get; set; } 
                     
    }
 
    }
  
            
    public partial class RecalculateIntrastatCostChildDialogView : View
    {
        public RecalculateIntrastatCostChildDialogView(InvoiceSLChargingIntrastat screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CodDeliveryNoteTerm = RPSControlFactory.CreateRPSTextBox<RecalculateIntrastatCostChildDialogView>("5abd2cb8-2d35-4079-8ff3-a6ff5693a7f5","","",false, this);
 
            Porcent = RPSControlFactory.CreateRPSFormattedTextBox<RecalculateIntrastatCostChildDialogView>("cb472e99-8295-45a5-ac1f-0db416bbafc6","","",false, this);
 
            IntrastatCost = RPSControlFactory.CreateRPSFormattedTextBox<RecalculateIntrastatCostChildDialogView>("df913528-6edf-451b-b496-973cd35f8d6f","","",false, this);
 

        }
        public IRPSTextBox<RecalculateIntrastatCostChildDialogView> CodDeliveryNoteTerm { get; set; } 
        public IRPSTextBox<RecalculateIntrastatCostChildDialogView> Porcent { get; set; } 
        public IRPSTextBox<RecalculateIntrastatCostChildDialogView> IntrastatCost { get; set; } 
        public InvoiceSLChargingIntrastat Screen { get; set; }
        public RecalculateIntrastatCostChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}