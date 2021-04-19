    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.InvoiceFromDeliveryNote
{
    //RPS VERSION 1.0.0.0
    public partial class InvoiceFromDeliveryNote:Screen
    {
        public InvoiceFromDeliveryNote():base()
        {
            this.URL = "purchase.invoicefromdeliverynote";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            InvoiceVMQueryView  = new InvoiceVMQueryView(this); 
            InvoiceVMEntityView  = new InvoiceVMEntityView(this); 
            DeliveryNoteChildDialogView  = new DeliveryNoteChildDialogView(this); 
            InvoiceLineView  = new InvoiceLineView(this); 
            InvoiceLineAnalyticView  = new InvoiceLineAnalyticView(this); 
            InvoiceLineTaxView  = new InvoiceLineTaxView(this); 
            InvoiceResumenDialogView  = new InvoiceResumenDialogView(this); 
            RecalculateCostChildDialogView  = new RecalculateCostChildDialogView(this); 
            RecalculateIntrastatChildDialogView  = new RecalculateIntrastatChildDialogView(this); 
            NewFromSalesDialogView  = new NewFromSalesDialogView(this); 
            AddNewLineDirectDialogView  = new AddNewLineDirectDialogView(this); 
            AnalyticChildDialogView  = new AnalyticChildDialogView(this); 
            InvoiceVMQueryView.InitializeControls(); 
            InvoiceVMEntityView.InitializeControls(); 
            DeliveryNoteChildDialogView.InitializeControls(); 
            InvoiceLineView.InitializeControls(); 
            InvoiceLineAnalyticView.InitializeControls(); 
            InvoiceLineTaxView.InitializeControls(); 
            InvoiceResumenDialogView.InitializeControls(); 
            RecalculateCostChildDialogView.InitializeControls(); 
            RecalculateIntrastatChildDialogView.InitializeControls(); 
            NewFromSalesDialogView.InitializeControls(); 
            AddNewLineDirectDialogView.InitializeControls(); 
            AnalyticChildDialogView.InitializeControls(); 
           
        }
      
            public InvoiceVMQueryView InvoiceVMQueryView {get; set; } 
            public InvoiceVMEntityView InvoiceVMEntityView {get; set; } 
            public DeliveryNoteChildDialogView DeliveryNoteChildDialogView {get; set; } 
            public InvoiceLineView InvoiceLineView {get; set; } 
            public InvoiceLineAnalyticView InvoiceLineAnalyticView {get; set; } 
            public InvoiceLineTaxView InvoiceLineTaxView {get; set; } 
            public InvoiceResumenDialogView InvoiceResumenDialogView {get; set; } 
            public RecalculateCostChildDialogView RecalculateCostChildDialogView {get; set; } 
            public RecalculateIntrastatChildDialogView RecalculateIntrastatChildDialogView {get; set; } 
            public NewFromSalesDialogView NewFromSalesDialogView {get; set; } 
            public AddNewLineDirectDialogView AddNewLineDirectDialogView {get; set; } 
            public AnalyticChildDialogView AnalyticChildDialogView {get; set; } 
    }
            
    public partial class InvoiceVMQueryView : View
    {
        public InvoiceVMQueryView(InvoiceFromDeliveryNote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<InvoiceVMQueryView,InvoiceVMEntityView>( this,Screen.InvoiceVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<InvoiceVMQueryView>( this);
 
            NewFromSalesNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<InvoiceVMQueryView,NewFromSalesDialogView>("2c39cebf-18a0-48b7-a183-cc981f63a65d","","", this,Screen.NewFromSalesDialogView);
 
            CollectionInit params_InvoiceTempConsult = new CollectionInit(){IDDescriptor = "4e2f7ded-7d63-4570-8ec4-f8b1a1a30c8e",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5c6e9ac9-2962-4e23-a82f-09cde2100390",CSSSelectorGrid="",XPathGrid=""};
            InvoiceTempConsult = RPSControlFactory.RPSCreateCollectionWithGrid<InvoiceTempConsultCollectionEditor<InvoiceVMQueryView,InvoiceVMEntityView>,InvoiceVMQueryView,InvoiceVMEntityView>( params_InvoiceTempConsult,this,Screen.InvoiceVMEntityView);
 

        }
        public IRPSButton<InvoiceVMQueryView,InvoiceVMEntityView> NewButton { get; set; } 
        public IRPSButton<InvoiceVMQueryView> ConsultButton { get; set; } 
        public IRPSButton<InvoiceVMQueryView,NewFromSalesDialogView> NewFromSalesNavigationCommandButton { get; set; } 
        public InvoiceTempConsultCollectionEditor<InvoiceVMQueryView,InvoiceVMEntityView> InvoiceTempConsult { get; set; } 
        public InvoiceFromDeliveryNote Screen { get; set; }
        public InvoiceVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class InvoiceTempConsultCollectionEditor<InvoiceVMQueryView,InvoiceVMEntityView>:RPSCollectionEditor<InvoiceVMQueryView,InvoiceVMEntityView> where InvoiceVMQueryView : class, IView where InvoiceVMEntityView : class, IView
    {
        public  InvoiceTempConsultGridView<InvoiceVMQueryView,InvoiceVMEntityView> GridView {get;set;}
    }
    public partial class InvoiceTempConsultGridView <InvoiceVMQueryView,InvoiceVMEntityView> :  RPSGridView<InvoiceVMQueryView,InvoiceVMEntityView> where InvoiceVMQueryView : class, IView where InvoiceVMEntityView : class, IView
    {
        public InvoiceTempConsultGridView(InvoiceVMQueryView currentView,InvoiceVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Invoice_CodInvoice = RPSControlFactory.CreateRPSGridTextBox<InvoiceVMQueryView>("","#5c6e9ac9-2962-4e23-a82f-09cde2100390 .ag-row[role='row']@ROWINDEX [col-id='cInvoice_CodInvoice']","",false, this.CurrentView);
 
            Invoice_InvoiceDate = RPSControlFactory.CreateRPSGridTextBox<InvoiceVMQueryView>("","#5c6e9ac9-2962-4e23-a82f-09cde2100390 .ag-row[role='row']@ROWINDEX [col-id='cInvoice_InvoiceDate']","",false, this.CurrentView);
 
            Invoice_DocumentType = RPSControlFactory.CreateRPSGridTextBox<InvoiceVMQueryView>("","#5c6e9ac9-2962-4e23-a82f-09cde2100390 .ag-row[role='row']@ROWINDEX [col-id='cInvoice_DocumentType']","",false, this.CurrentView);
 
            Invoice_AdvanceInvoice = RPSControlFactory.CreateRPSGridCheckBox<InvoiceVMQueryView>("","#5c6e9ac9-2962-4e23-a82f-09cde2100390 .ag-row[role='row']@ROWINDEX [col-id='cInvoice_AdvanceInvoice']","",false, this.CurrentView);
 
            VATBASE = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceVMQueryView>("","#5c6e9ac9-2962-4e23-a82f-09cde2100390 .ag-row[role='row']@ROWINDEX [col-id='cVATBASE']","",false, this.CurrentView);
 
            Invoice_VATAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceVMQueryView>("","#5c6e9ac9-2962-4e23-a82f-09cde2100390 .ag-row[role='row']@ROWINDEX [col-id='cInvoice_VATAmount']","",false, this.CurrentView);
 
            Invoice_TotalInvoice = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceVMQueryView>("","#5c6e9ac9-2962-4e23-a82f-09cde2100390 .ag-row[role='row']@ROWINDEX [col-id='cInvoice_TotalInvoice']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<InvoiceVMQueryView> Invoice_CodInvoice { get; set; } 
        public IRPSGridTextBox<InvoiceVMQueryView> Invoice_InvoiceDate { get; set; } 
        public IRPSGridTextBox<InvoiceVMQueryView> Invoice_DocumentType { get; set; } 
        public IRPSGridCheckbox<InvoiceVMQueryView> Invoice_AdvanceInvoice { get; set; } 
        public IRPSGridTextBox<InvoiceVMQueryView> VATBASE { get; set; } 
        public IRPSGridTextBox<InvoiceVMQueryView> Invoice_VATAmount { get; set; } 
        public IRPSGridTextBox<InvoiceVMQueryView> Invoice_TotalInvoice { get; set; } 
                     
    }
 
    }
  
            
    public partial class InvoiceVMEntityView : View
    {
        public InvoiceVMEntityView(InvoiceFromDeliveryNote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<InvoiceVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<InvoiceVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<InvoiceVMEntityView,InvoiceVMQueryView>( this,Screen.InvoiceVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<InvoiceVMEntityView,InvoiceVMQueryView>( this,Screen.InvoiceVMQueryView);
 
            UIAddDeliveryNote = RPSControlFactory.CreateRPSComboBox<InvoiceVMEntityView>("c335ded2-dfaf-49f9-b457-63b1cb216c13","","",false, this);
 
            AddNewLineDirectNavigationCommand = RPSControlFactory.CreateRPSButtonToView<InvoiceVMEntityView,AddNewLineDirectDialogView>("703946b8-023d-4b8c-b5c2-d79d3784d4b3","","", this,Screen.AddNewLineDirectDialogView);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<InvoiceVMEntityView>("eccbed9d-27c5-4c6d-a407-04361735bb0a","","",true, this);
 
            CodInvoice = RPSControlFactory.CreateRPSTextBox<InvoiceVMEntityView>("839ff24a-645d-4ba8-9069-bc51ad7c6df6","","",true, this);
 
            InvoiceDate = RPSControlFactory.CreateRPSTextBox<InvoiceVMEntityView>("d4344a93-28e3-45e7-bfcf-ef3a2f21bc8c","","",true, this);
 
            AccountingDate = RPSControlFactory.CreateRPSTextBox<InvoiceVMEntityView>("fe189c6a-96d0-4f79-b314-ee0be6cdcc09","","",true, this);
 
            DocumentType = RPSControlFactory.CreateRPSEnumComboBox<InvoiceVMEntityView>("a457ad46-4e45-48ed-b327-3daadad11058","","",true, this);
 
            CodFromInvoice = RPSControlFactory.CreateRPSEnumComboBox<InvoiceVMEntityView>("638adfac-51ab-4c4c-bb3b-d6d11db50525","","",false, this);
 
            IDContactAdministration = RPSControlFactory.CreateRPSComboBox<InvoiceVMEntityView>("20d6e972-288d-4917-9339-2cc34dc8bafd","","",false, this);
 
            UICodCompanySales = RPSControlFactory.CreateRPSTextBox<InvoiceVMEntityView>("604ad5d7-f93b-44ae-8674-652d11411e57","","",false, this);
 
            UICodInvoiceSales = RPSControlFactory.CreateRPSTextBox<InvoiceVMEntityView>("e15e6412-52ff-47cd-81ce-36cd10a0d2f8","","",false, this);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSComboBox<InvoiceVMEntityView>("fa322d77-1593-4859-af3a-63b24b4bdd35","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<InvoiceVMEntityView>("7c3eb510-22ac-4459-915e-8e5aa78babea","","",true, this);
 
            Change = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceVMEntityView>("de94fd86-9854-443a-b2f3-ffe1c42468ed","","",true, this);
 
            FixedChange = RPSControlFactory.CreateRPSCheckBox<InvoiceVMEntityView>("d460b56a-4694-4e95-a671-3694edadc35a","","",true, this);
 
            IDSupplierPayment = RPSControlFactory.CreateRPSComboBox<InvoiceVMEntityView>("92ae2dc8-301d-4c9e-b250-061b57f427d3","","",false, this);
 
            Transport = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceVMEntityView>("0ca94b0a-b385-4bc4-8514-144a984e66ba","","",true, this);
 
            IDVATType = RPSControlFactory.CreateRPSComboBox<InvoiceVMEntityView>("8235d27e-f1bc-4fe5-8bda-eac5414b5f12","","",true, this);
 
            IDSurchargeVATType = RPSControlFactory.CreateRPSComboBox<InvoiceVMEntityView>("78181624-dc82-4ea3-9fc3-9cd57b862de2","","",false, this);
 
            IDTaxGroup = RPSControlFactory.CreateRPSComboBox<InvoiceVMEntityView>("c681461d-2357-48c4-9ec3-83885167f68a","","",false, this);
 
            IDEUInvoice = RPSControlFactory.CreateRPSComboBox<InvoiceVMEntityView>("a1e08a8b-68b0-4dfb-91cd-79e840a4c140","","",false, this);
 
            IDSupplierBankAccount = RPSControlFactory.CreateRPSComboBox<InvoiceVMEntityView>("5c6ad5d4-27d4-4ecf-b1bc-41b4eec563d9","","",false, this);
 
            IDVoucherType = RPSControlFactory.CreateRPSComboBox<InvoiceVMEntityView>("f83d07cf-ca9c-480d-ba2b-4e243d9e3fd9","","",false, this);
 
            IDBankAccountCompany = RPSControlFactory.CreateRPSComboBox<InvoiceVMEntityView>("26c657e4-86a8-4816-b44f-ee8cbaf65f01","","",false, this);
 
            IDInvoicingType = RPSControlFactory.CreateRPSComboBox<InvoiceVMEntityView>("47af4e1d-5e89-42ef-a9cc-ee63062801c2","","",true, this);
 
            Discount1 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceVMEntityView>("1a11412c-07a4-4fad-876b-c007c47f29dc","","",true, this);
 
            Discount2 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceVMEntityView>("e20002fd-7685-43a4-8c98-f19cebeccff5","","",true, this);
 
            Discount3 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceVMEntityView>("fa7d6cd8-b5f4-47b9-b77b-f74cc8b6b17c","","",true, this);
 
            CashDiscount = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceVMEntityView>("d22b23fc-a5dc-455e-a256-faf7fa3a522d","","",true, this);
 
            FinancialSurcharge = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceVMEntityView>("725adf9d-20fa-4fd9-91ff-e454d0155a8a","","",true, this);
 
            RetentionPercent = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceVMEntityView>("d2727743-f11a-45db-8292-4f8e69824e58","","",true, this);
 
            RentingInvoice = RPSControlFactory.CreateRPSCheckBox<InvoiceVMEntityView>("2dc4208c-b37a-49b0-8b41-7827ec328a9f","","",false, this);
 
            IDFixedAsset = RPSControlFactory.CreateRPSComboBox<InvoiceVMEntityView>("e9b06ef8-2d33-4e2f-8217-dfdc6736d6bf","","",false, this);
 
            DUA = RPSControlFactory.CreateRPSCheckBox<InvoiceVMEntityView>("3d79c063-8532-4e88-bad5-9a50a49c590d","","",false, this);
 
            DUADate = RPSControlFactory.CreateRPSTextBox<InvoiceVMEntityView>("afee45a9-95f6-4c26-9326-9257a1cd9878","","",false, this);
 
            DUANumber = RPSControlFactory.CreateRPSTextBox<InvoiceVMEntityView>("15615aab-2e41-4010-ad10-54e297cd025c","","",false, this);
 
            DUAVATBase = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceVMEntityView>("1724667b-214f-4a24-92a6-4cda59ca7291","","",false, this);
 
            DUAIDVat = RPSControlFactory.CreateRPSComboBox<InvoiceVMEntityView>("d6f835bb-6dad-46c3-8de5-e542584cd64e","","",false, this);
 
            DUAIDAccount = RPSControlFactory.CreateRPSComboBox<InvoiceVMEntityView>("76dcc740-8581-41fd-8042-a2bd946a298b","","",false, this);
 
            CommentInvoice = RPSControlFactory.CreateRPSTextBox<InvoiceVMEntityView>("28a1f93d-0869-4442-9c33-935051fffb73","","",false, this);
 
            DeliveryNoteChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<InvoiceVMEntityView,DeliveryNoteChildDialogView>("a0b9ed4d-8f55-40c6-a17f-9e315438b3c1","","", this,Screen.DeliveryNoteChildDialogView);
 
            BeforeInvoiceResumenCommandButton = RPSControlFactory.CreateRPSButton<InvoiceVMEntityView>( "e33d3639-d744-43d4-b80e-3dca9cecca5e","","",this);
 
            RecalculateCostChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<InvoiceVMEntityView,RecalculateCostChildDialogView>("9bedaf4a-44e8-48c5-8276-0f6f40babec3","","", this,Screen.RecalculateCostChildDialogView);
 
            RecalculateIntrastatChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<InvoiceVMEntityView,RecalculateIntrastatChildDialogView>("c3d640e0-01ce-4c63-9a1a-03f82e76eb80","","", this,Screen.RecalculateIntrastatChildDialogView);
 
            ExecuteUpdateInvoiceTransportAmountButton = RPSControlFactory.CreateRPSButton<InvoiceVMEntityView>( "6a9a5921-4df0-4168-a9f3-5130972ea2fb","","",this);
 
            CollectionInit params_InvoiceLines = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3bca309f-43f5-45cd-808d-d744c9b74c2d",CSSSelectorGrid="",XPathGrid=""};
            InvoiceLines = RPSControlFactory.RPSCreateCollectionWithGrid<InvoiceLinesCollectionEditor<InvoiceVMEntityView,InvoiceLineView>,InvoiceVMEntityView,InvoiceLineView>( params_InvoiceLines,this,Screen.InvoiceLineView);
 
            LinesSection = RPSControlFactory.CreateRPSSection<InvoiceVMEntityView>( "","ul li[rpsid='fdce3d7f-342b-4bc3-9fab-fad486167bf9']","",this);
 
            BasicDataSection = RPSControlFactory.CreateRPSSection<InvoiceVMEntityView>( "","ul li[rpsid='a31d1166-dfff-496e-be09-b1dbeb92320b']","",this);
 
            CommentSection = RPSControlFactory.CreateRPSSection<InvoiceVMEntityView>( "","ul li[rpsid='b2c4c55d-c624-4078-853a-44d6d9218e16']","",this);
 

        }
        public IRPSSaveButton<InvoiceVMEntityView> SaveButton { get; set; } 
        public IRPSButton<InvoiceVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<InvoiceVMEntityView,InvoiceVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<InvoiceVMEntityView,InvoiceVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<InvoiceVMEntityView> UIAddDeliveryNote { get; set; } 
        public IRPSButton<InvoiceVMEntityView,AddNewLineDirectDialogView> AddNewLineDirectNavigationCommand { get; set; } 
        public IRPSComboBox<InvoiceVMEntityView> IDSupplier { get; set; } 
        public IRPSTextBox<InvoiceVMEntityView> CodInvoice { get; set; } 
        public IRPSTextBox<InvoiceVMEntityView> InvoiceDate { get; set; } 
        public IRPSTextBox<InvoiceVMEntityView> AccountingDate { get; set; } 
        public IRPSComboBox<InvoiceVMEntityView> DocumentType { get; set; } 
        public IRPSComboBox<InvoiceVMEntityView> CodFromInvoice { get; set; } 
        public IRPSComboBox<InvoiceVMEntityView> IDContactAdministration { get; set; } 
        public IRPSTextBox<InvoiceVMEntityView> UICodCompanySales { get; set; } 
        public IRPSTextBox<InvoiceVMEntityView> UICodInvoiceSales { get; set; } 
        public IRPSComboBox<InvoiceVMEntityView> IDPaymentMethod { get; set; } 
        public IRPSComboBox<InvoiceVMEntityView> IDCurrency { get; set; } 
        public IRPSTextBox<InvoiceVMEntityView> Change { get; set; } 
        public IRPSCheckbox<InvoiceVMEntityView> FixedChange { get; set; } 
        public IRPSComboBox<InvoiceVMEntityView> IDSupplierPayment { get; set; } 
        public IRPSTextBox<InvoiceVMEntityView> Transport { get; set; } 
        public IRPSComboBox<InvoiceVMEntityView> IDVATType { get; set; } 
        public IRPSComboBox<InvoiceVMEntityView> IDSurchargeVATType { get; set; } 
        public IRPSComboBox<InvoiceVMEntityView> IDTaxGroup { get; set; } 
        public IRPSComboBox<InvoiceVMEntityView> IDEUInvoice { get; set; } 
        public IRPSComboBox<InvoiceVMEntityView> IDSupplierBankAccount { get; set; } 
        public IRPSComboBox<InvoiceVMEntityView> IDVoucherType { get; set; } 
        public IRPSComboBox<InvoiceVMEntityView> IDBankAccountCompany { get; set; } 
        public IRPSComboBox<InvoiceVMEntityView> IDInvoicingType { get; set; } 
        public IRPSTextBox<InvoiceVMEntityView> Discount1 { get; set; } 
        public IRPSTextBox<InvoiceVMEntityView> Discount2 { get; set; } 
        public IRPSTextBox<InvoiceVMEntityView> Discount3 { get; set; } 
        public IRPSTextBox<InvoiceVMEntityView> CashDiscount { get; set; } 
        public IRPSTextBox<InvoiceVMEntityView> FinancialSurcharge { get; set; } 
        public IRPSTextBox<InvoiceVMEntityView> RetentionPercent { get; set; } 
        public IRPSCheckbox<InvoiceVMEntityView> RentingInvoice { get; set; } 
        public IRPSComboBox<InvoiceVMEntityView> IDFixedAsset { get; set; } 
        public IRPSCheckbox<InvoiceVMEntityView> DUA { get; set; } 
        public IRPSTextBox<InvoiceVMEntityView> DUADate { get; set; } 
        public IRPSTextBox<InvoiceVMEntityView> DUANumber { get; set; } 
        public IRPSTextBox<InvoiceVMEntityView> DUAVATBase { get; set; } 
        public IRPSComboBox<InvoiceVMEntityView> DUAIDVat { get; set; } 
        public IRPSComboBox<InvoiceVMEntityView> DUAIDAccount { get; set; } 
        public IRPSTextBox<InvoiceVMEntityView> CommentInvoice { get; set; } 
        public IRPSButton<InvoiceVMEntityView,DeliveryNoteChildDialogView> DeliveryNoteChildNavigationCommandButton { get; set; } 
        public IRPSButton<InvoiceVMEntityView> BeforeInvoiceResumenCommandButton { get; set; } 
        public IRPSButton<InvoiceVMEntityView,RecalculateCostChildDialogView> RecalculateCostChildNavigationCommandButton { get; set; } 
        public IRPSButton<InvoiceVMEntityView,RecalculateIntrastatChildDialogView> RecalculateIntrastatChildNavigationCommandButton { get; set; } 
        public IRPSButton<InvoiceVMEntityView> ExecuteUpdateInvoiceTransportAmountButton { get; set; } 
        public InvoiceLinesCollectionEditor<InvoiceVMEntityView,InvoiceLineView> InvoiceLines { get; set; } 
        public IRPSSection<InvoiceVMEntityView> LinesSection { get; set; } 
        public IRPSSection<InvoiceVMEntityView> BasicDataSection { get; set; } 
        public IRPSSection<InvoiceVMEntityView> CommentSection { get; set; } 
        public InvoiceFromDeliveryNote Screen { get; set; }
        public InvoiceVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class InvoiceLinesCollectionEditor<InvoiceVMEntityView,InvoiceLineView>:RPSCollectionEditor<InvoiceVMEntityView,InvoiceLineView> where InvoiceVMEntityView : class, IView where InvoiceLineView : class, IView
    {
        public  InvoiceLinesGridView<InvoiceVMEntityView,InvoiceLineView> GridView {get;set;}
    }
    public partial class InvoiceLinesGridView <InvoiceVMEntityView,InvoiceLineView> :  RPSGridView<InvoiceVMEntityView,InvoiceLineView> where InvoiceVMEntityView : class, IView where InvoiceLineView : class, IView
    {
        public InvoiceLinesGridView(InvoiceVMEntityView currentView,InvoiceLineView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            UIIDDeliveryNoteLine = RPSControlFactory.CreateRPSGridComboBox<InvoiceVMEntityView>("","#3bca309f-43f5-45cd-808d-d744c9b74c2d .ag-row[role='row']@ROWINDEX [col-id='cUIIDDeliveryNoteLine']","",false, this.CurrentView);
 
            Ordenation = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceVMEntityView>("","#3bca309f-43f5-45cd-808d-d744c9b74c2d .ag-row[role='row']@ROWINDEX [col-id='cOrdenation']","",true, this.CurrentView);
 
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<InvoiceVMEntityView>("","#3bca309f-43f5-45cd-808d-d744c9b74c2d .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<InvoiceVMEntityView>("","#3bca309f-43f5-45cd-808d-d744c9b74c2d .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceVMEntityView>("","#3bca309f-43f5-45cd-808d-d744c9b74c2d .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            Price = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceVMEntityView>("","#3bca309f-43f5-45cd-808d-d744c9b74c2d .ag-row[role='row']@ROWINDEX [col-id='cPrice']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceVMEntityView>("","#3bca309f-43f5-45cd-808d-d744c9b74c2d .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            DeliveryCost = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceVMEntityView>("","#3bca309f-43f5-45cd-808d-d744c9b74c2d .ag-row[role='row']@ROWINDEX [col-id='cDeliveryCost']","",true, this.CurrentView);
 
            ImportCost = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceVMEntityView>("","#3bca309f-43f5-45cd-808d-d744c9b74c2d .ag-row[role='row']@ROWINDEX [col-id='cImportCost']","",true, this.CurrentView);
 
            TariffCost = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceVMEntityView>("","#3bca309f-43f5-45cd-808d-d744c9b74c2d .ag-row[role='row']@ROWINDEX [col-id='cTariffCost']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<InvoiceVMEntityView> UIIDDeliveryNoteLine { get; set; } 
        public IRPSGridTextBox<InvoiceVMEntityView> Ordenation { get; set; } 
        public IRPSGridComboBox<InvoiceVMEntityView> IDArticle { get; set; } 
        public IRPSGridTextBox<InvoiceVMEntityView> Description { get; set; } 
        public IRPSGridTextBox<InvoiceVMEntityView> Quantity { get; set; } 
        public IRPSGridTextBox<InvoiceVMEntityView> Price { get; set; } 
        public IRPSGridTextBox<InvoiceVMEntityView> Amount { get; set; } 
        public IRPSGridTextBox<InvoiceVMEntityView> DeliveryCost { get; set; } 
        public IRPSGridTextBox<InvoiceVMEntityView> ImportCost { get; set; } 
        public IRPSGridTextBox<InvoiceVMEntityView> TariffCost { get; set; } 
                     
    }
 
    }
  
            
    public partial class DeliveryNoteChildDialogView : View
    {
        public DeliveryNoteChildDialogView(InvoiceFromDeliveryNote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UITotalBase = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteChildDialogView>("c1ef2768-eb17-4ccb-ad10-60130efd9691","","",false, this);
 
            UITotal = RPSControlFactory.CreateRPSFormattedTextBox<DeliveryNoteChildDialogView>("f6843ef2-9c43-4f48-b3b8-ba9c5efb125e","","",false, this);
 
            CollectionInit params_GetDeliveryNoteOrder = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="be1c8e73-2c91-4ad6-bad8-42a6aafc79f7",CSSSelectorGrid="",XPathGrid=""};
            GetDeliveryNoteOrder = RPSControlFactory.RPSCreateCollectionWithGrid<GetDeliveryNoteOrderCollectionEditor<DeliveryNoteChildDialogView>,DeliveryNoteChildDialogView>( params_GetDeliveryNoteOrder,this);
 

        }
        public IRPSTextBox<DeliveryNoteChildDialogView> UITotalBase { get; set; } 
        public IRPSTextBox<DeliveryNoteChildDialogView> UITotal { get; set; } 
        public GetDeliveryNoteOrderCollectionEditor<DeliveryNoteChildDialogView> GetDeliveryNoteOrder { get; set; } 
        public InvoiceFromDeliveryNote Screen { get; set; }
        public DeliveryNoteChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetDeliveryNoteOrderCollectionEditor<DeliveryNoteChildDialogView>:RPSCollectionEditor<DeliveryNoteChildDialogView> where DeliveryNoteChildDialogView : class, IView
    {
        public  GetDeliveryNoteOrderGridView<DeliveryNoteChildDialogView> GridView {get;set;}
    }
    public partial class GetDeliveryNoteOrderGridView <DeliveryNoteChildDialogView> :  RPSGridView<DeliveryNoteChildDialogView> where DeliveryNoteChildDialogView : class, IView
    {
        public GetDeliveryNoteOrderGridView(DeliveryNoteChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodDeliveryNote = RPSControlFactory.CreateRPSGridTextBox<DeliveryNoteChildDialogView>("","#be1c8e73-2c91-4ad6-bad8-42a6aafc79f7 .ag-row[role='row']@ROWINDEX [col-id='cCodDeliveryNote']","",false, this.CurrentView);
 
            CodOrder = RPSControlFactory.CreateRPSGridTextBox<DeliveryNoteChildDialogView>("","#be1c8e73-2c91-4ad6-bad8-42a6aafc79f7 .ag-row[role='row']@ROWINDEX [col-id='cCodOrder']","",false, this.CurrentView);
 
            DeliveryNoteDate = RPSControlFactory.CreateRPSGridTextBox<DeliveryNoteChildDialogView>("","#be1c8e73-2c91-4ad6-bad8-42a6aafc79f7 .ag-row[role='row']@ROWINDEX [col-id='cDeliveryNoteDate']","",false, this.CurrentView);
 
            Base = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteChildDialogView>("","#be1c8e73-2c91-4ad6-bad8-42a6aafc79f7 .ag-row[role='row']@ROWINDEX [col-id='cBase']","",false, this.CurrentView);
 
            Total = RPSControlFactory.CreateRPSGridFormattedTextBox<DeliveryNoteChildDialogView>("","#be1c8e73-2c91-4ad6-bad8-42a6aafc79f7 .ag-row[role='row']@ROWINDEX [col-id='cTotal']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<DeliveryNoteChildDialogView> CodDeliveryNote { get; set; } 
        public IRPSGridTextBox<DeliveryNoteChildDialogView> CodOrder { get; set; } 
        public IRPSGridTextBox<DeliveryNoteChildDialogView> DeliveryNoteDate { get; set; } 
        public IRPSGridTextBox<DeliveryNoteChildDialogView> Base { get; set; } 
        public IRPSGridTextBox<DeliveryNoteChildDialogView> Total { get; set; } 
                     
    }
 
    }
  
            
    public partial class InvoiceLineView : View
    {
        public InvoiceLineView(InvoiceFromDeliveryNote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<InvoiceLineView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<InvoiceLineView,InvoiceVMEntityView>( this,Screen.InvoiceVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<InvoiceLineView,InvoiceVMEntityView>( this,Screen.InvoiceVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<InvoiceLineView,InvoiceVMEntityView>( this,Screen.InvoiceVMEntityView);
 
            Ordenation = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("d81a6da0-43ab-44b0-a066-b125967b8fed","","",true, this);
 
            CodDeliveryNote = RPSControlFactory.CreateRPSTextBox<InvoiceLineView>("0314345d-2d62-425c-bec4-358f6b08f37a","","",false, this);
 
            CodOrder = RPSControlFactory.CreateRPSTextBox<InvoiceLineView>("d2b575ea-b4be-4fc0-b446-9881df90da95","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<InvoiceLineView>("2b696201-28f3-4b4e-914d-3b2c0023379b","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<InvoiceLineView>("5586bb4e-6b14-4986-9ad4-9cf71ac43abf","","",false, this);
 
            Series = RPSControlFactory.CreateRPSTextBox<InvoiceLineView>("6e57fd4d-a174-45c3-af7c-180e65c53fc9","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("8d669a2c-cebb-433f-ac45-c6dc73ed908a","","",true, this);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSComboBox<InvoiceLineView>("ff0c3fd1-d457-421d-a92e-371979215389","","",false, this);
 
            ConversionFactorQuantity = RPSControlFactory.CreateRPSTextBox<InvoiceLineView>("847f3811-ba30-41a5-b7a8-c6a79d8ea41d","","",false, this);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("317148d4-2af8-4bec-b1fd-e28ed994fec4","","",true, this);
 
            Dimension1 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("074e4ea3-7ce2-4802-9b14-b98b855b419e","","",true, this);
 
            Dimension2 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("edf02f22-8fbe-4f63-af0b-5849854f59f5","","",true, this);
 
            Dimension3 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("0ac44db6-ab74-4ebf-8892-7f7e3f792488","","",true, this);
 
            QuantityRejected = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("9c15c271-a198-4dca-a6f6-97d3928093ba","","",false, this);
 
            Price = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("8fa0e47e-919d-4f25-a755-dafeac5fea5d","","",true, this);
 
            VAT = RPSControlFactory.CreateRPSCheckBox<InvoiceLineView>("1f240acc-047e-40d1-b2e6-f7a0a17e5800","","",true, this);
 
            IDUnitPrice = RPSControlFactory.CreateRPSComboBox<InvoiceLineView>("abb40a85-b2cd-43ae-a46c-1ef4f53d9212","","",false, this);
 
            ConversionFactorPrice = RPSControlFactory.CreateRPSTextBox<InvoiceLineView>("d31dbef6-ac0d-4532-b088-1a5a40a3cf3f","","",false, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("6afc2e64-be2f-4529-8547-3a7a6d586858","","",true, this);
 
            AmountWithVAT = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("0f5d079c-a3be-43e1-8b4f-e22a62acc0a2","","",true, this);
 
            CostPercentage = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("78d046b2-96ca-4ba1-9c82-95eec2933a2a","","",false, this);
 
            DeliveryCost = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("a5ed0f5d-41d2-4bfb-acf6-3d98312002c5","","",true, this);
 
            ImportCost = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("8e30e041-682b-4c81-abd2-4954e1ed6f74","","",true, this);
 
            TariffCost = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("0ff25a75-2a45-4ebc-8086-2ed10705d5ef","","",true, this);
 
            PermissionsCost = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("13541dc2-b559-4282-b175-d356e0db876b","","",false, this);
 
            BankingCost = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("f18bf426-30a7-4aeb-b751-19485721ffc4","","",false, this);
 
            OthersCost = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("3ce3f1ed-59b9-4db2-8ef8-0c0f1e17acda","","",false, this);
 
            ExternalCost = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("77c04321-52d7-4bbb-a917-dd5df8ac9e4f","","",false, this);
 
            Discount1 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("8dc3529b-9f80-4b59-9b73-8301cdf5ae93","","",true, this);
 
            CascadeDiscount1 = RPSControlFactory.CreateRPSCheckBox<InvoiceLineView>("19994742-9e54-49e9-b6cd-eb04c509ec91","","",true, this);
 
            Discount2 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("a7fd42d7-ec5c-4f4a-b3b1-88d80260b674","","",true, this);
 
            CascadeDiscount2 = RPSControlFactory.CreateRPSCheckBox<InvoiceLineView>("8806ef4c-8486-4367-9b64-0f183bcd2d45","","",true, this);
 
            Discount3 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("195543e9-b17f-488a-b79a-8b72b71023de","","",true, this);
 
            CascadeDiscount3 = RPSControlFactory.CreateRPSCheckBox<InvoiceLineView>("39c05bf1-d7d0-4d3e-9d44-710244ea7da9","","",true, this);
 
            Discount4 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("64504d70-57df-4800-93ac-c11bcd457417","","",true, this);
 
            CascadeDiscount4 = RPSControlFactory.CreateRPSCheckBox<InvoiceLineView>("90deba88-c186-403e-b0bb-a15e7acba383","","",true, this);
 
            Discount5 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("f3090a23-1b2f-4536-9f16-4e78944a1702","","",true, this);
 
            CascadeDiscount5 = RPSControlFactory.CreateRPSCheckBox<InvoiceLineView>("2a5be61a-b276-439d-bc77-ab7cd71e33f8","","",true, this);
 
            AmountDiscount = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("0ea627bf-8063-4195-9c7d-538b9fe08724","","",true, this);
 
            PositionAmountDiscount = RPSControlFactory.CreateRPSEnumComboBox<InvoiceLineView>("6a088417-df38-4220-aa66-1fe4fbe643b5","","",true, this);
 
            IDVAT = RPSControlFactory.CreateRPSComboBox<InvoiceLineView>("8282ae6b-df27-471a-8e34-a368d919bd83","","",false, this);
 
            IDVATSurcharge = RPSControlFactory.CreateRPSComboBox<InvoiceLineView>("da24b7e4-b6d2-447b-9f4e-7731a5389073","","",false, this);
 
            PercentSurcharge = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("ae807c0b-ba8f-4005-9560-564f6027be2b","","",true, this);
 
            GenerateAutoInvoice = RPSControlFactory.CreateRPSCheckBox<InvoiceLineView>("4736f2cc-b897-441d-bb74-eb6ad5304b3a","","",true, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<InvoiceLineView>("c93290e0-5713-4cbf-8141-affa54449daf","","",false, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<InvoiceLineView>("ebe50917-4044-46e6-9a7a-6c26cc88864e","","",false, this);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<InvoiceLineView>("1adb2744-3998-4b34-bec3-415d994c5eed","","",false, this);
 
            IDReturnCause = RPSControlFactory.CreateRPSComboBox<InvoiceLineView>("0c613a7b-e3ba-4145-a25a-a39cab6898ac","","",false, this);
 
            IDAccount = RPSControlFactory.CreateRPSComboBox<InvoiceLineView>("74fbcab0-41ed-450d-8969-cab02f43f751","","",false, this);
 
            CostPercentage1 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("ea956850-830b-4f28-9c26-b36305c606b6","","",false, this);
 
            NumProm = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("a4fb6c41-9da0-4bfc-9dfe-64e739f0c095","","",false, this);
 
            Rappel = RPSControlFactory.CreateRPSCheckBox<InvoiceLineView>("b9a2799e-c3fe-40d2-88be-b2d5357e96c4","","",false, this);
 
            UIIDProject = RPSControlFactory.CreateRPSComboBox<InvoiceLineView>("71103d2e-c721-4ad7-bf32-99f26b7f7421","","",false, this);
 
            UIIDProjectTask = RPSControlFactory.CreateRPSComboBox<InvoiceLineView>("fd62e31e-31b6-4fe7-8b99-5bcd00b714ff","","",false, this);
 
            UIIDProjectMaterial = RPSControlFactory.CreateRPSComboBox<InvoiceLineView>("86c2a583-6aa2-419b-b443-b1d07a21be70","","",false, this);
 
            UIIDManufacturingOrder = RPSControlFactory.CreateRPSComboBox<InvoiceLineView>("eca5444b-4b73-481a-b522-9caa14b57be4","","",false, this);
 
            UIIDMOTask = RPSControlFactory.CreateRPSComboBox<InvoiceLineView>("cad6b485-3d8b-43fb-a716-44d8393641a5","","",false, this);
 
            UIIDMOMaterial = RPSControlFactory.CreateRPSComboBox<InvoiceLineView>("9ac75e29-8eba-481b-b83f-971c175f6a25","","",false, this);
 
            UIIDMaintenanceOrder = RPSControlFactory.CreateRPSComboBox<InvoiceLineView>("c01d39ef-f89d-415e-bb1d-c525010a024e","","",false, this);
 
            UIIDOrderMaterialPrevision = RPSControlFactory.CreateRPSComboBox<InvoiceLineView>("1aa3d1e7-dc58-4152-9b72-b422aba646b4","","",false, this);
 
            InvoiceLineGetDimensionCommandButton = RPSControlFactory.CreateRPSButton<InvoiceLineView>( "8998dfbb-c879-4f56-bfba-85ff2d1ef1d6","","",this);
 
            PriceBase = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("9898639a-abf4-4492-8635-58e060df3d50","","",false, this);
 
            UIConditionsPrice = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("85fef50f-78a1-4105-bdcd-bccd0381cb55","","",true, this);
 
            UIPriceWihoutConditionsBase = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("8ba97609-bee7-4a78-ac7e-2955041a365e","","",true, this);
 
            PriceWihoutConditions = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("986dbe9a-e861-4099-b6c3-4cb6b7214060","","",true, this);
 
            CommentInvoice = RPSControlFactory.CreateRPSTextBox<InvoiceLineView>("6d900b0f-1228-4a55-8a69-f617fedcef99","","",false, this);
 
            AnalyticChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<InvoiceLineView,AnalyticChildDialogView>("a2e3f2de-4768-4557-9791-603a4acfdcd2","","", this,Screen.AnalyticChildDialogView);
 
            CollectionInit params_InvoiceLineAnalytics = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="18a98a9a-33dd-4f1c-8afe-ab24b3f02f50",CSSSelectorGrid="",XPathGrid=""};
            InvoiceLineAnalytics = RPSControlFactory.RPSCreateCollectionWithGrid<InvoiceLineAnalyticsCollectionEditor<InvoiceLineView,InvoiceLineAnalyticView>,InvoiceLineView,InvoiceLineAnalyticView>( params_InvoiceLineAnalytics,this,Screen.InvoiceLineAnalyticView);
 
            CollectionInit params_InvoiceLineTaxs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1d3eb564-2d04-4793-bbf2-b954e576d2e4",CSSSelectorGrid="",XPathGrid=""};
            InvoiceLineTaxs = RPSControlFactory.RPSCreateCollectionWithGrid<InvoiceLineTaxsCollectionEditor<InvoiceLineView,InvoiceLineAnalyticView>,InvoiceLineView,InvoiceLineAnalyticView>( params_InvoiceLineTaxs,this,Screen.InvoiceLineAnalyticView);
 
            CollectionInit params_InvoiceLineConditionsAffect = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="43621403-dcf0-481f-91d0-c888a9c4c4eb",CSSSelectorGrid="",XPathGrid=""};
            InvoiceLineConditionsAffect = RPSControlFactory.RPSCreateCollectionWithGrid<InvoiceLineConditionsAffectCollectionEditor<InvoiceLineView,InvoiceLineAnalyticView>,InvoiceLineView,InvoiceLineAnalyticView>( params_InvoiceLineConditionsAffect,this,Screen.InvoiceLineAnalyticView);
 
            CollectionInit params_InvoiceLineConditionsNoAffect = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="74d32078-5a02-4d3c-a197-7d304b49a8b5",CSSSelectorGrid="",XPathGrid=""};
            InvoiceLineConditionsNoAffect = RPSControlFactory.RPSCreateCollectionWithGrid<InvoiceLineConditionsNoAffectCollectionEditor<InvoiceLineView,InvoiceLineAnalyticView>,InvoiceLineView,InvoiceLineAnalyticView>( params_InvoiceLineConditionsNoAffect,this,Screen.InvoiceLineAnalyticView);
 
            GeneralDataSection = RPSControlFactory.CreateRPSSection<InvoiceLineView>( "","ul li[rpsid='79d72880-739e-4291-9ce7-f65b2e94ac8c']","",this);
 
            AnalyticSection = RPSControlFactory.CreateRPSSection<InvoiceLineView>( "","ul li[rpsid='df04656a-06b4-47ed-927c-ff23c9238f77']","",this);
 
            TaxSection = RPSControlFactory.CreateRPSSection<InvoiceLineView>( "","ul li[rpsid='ee6aecb4-b4cf-4883-8dab-c2a15afc2afe']","",this);
 
            ConditionSectionAffect = RPSControlFactory.CreateRPSSection<InvoiceLineView>( "","ul li[rpsid='bdb69194-daeb-41ff-ae77-8e3c0ee74218']","",this);
 
            ConditionSectionNoAffect = RPSControlFactory.CreateRPSSection<InvoiceLineView>( "","ul li[rpsid='111ea91c-2646-4d22-a851-176c41f85637']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<InvoiceLineView>( "","ul li[rpsid='620ee05b-a4d8-4390-b9bc-3bf222e4b3c4']","",this);
 

        }
        public IRPSButton<InvoiceLineView> DeleteButton { get; set; } 
        public IRPSButton<InvoiceLineView,InvoiceVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<InvoiceLineView,InvoiceVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<InvoiceLineView,InvoiceVMEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<InvoiceLineView> Ordenation { get; set; } 
        public IRPSTextBox<InvoiceLineView> CodDeliveryNote { get; set; } 
        public IRPSTextBox<InvoiceLineView> CodOrder { get; set; } 
        public IRPSComboBox<InvoiceLineView> IDArticle { get; set; } 
        public IRPSTextBox<InvoiceLineView> Description { get; set; } 
        public IRPSTextBox<InvoiceLineView> Series { get; set; } 
        public IRPSTextBox<InvoiceLineView> Quantity { get; set; } 
        public IRPSComboBox<InvoiceLineView> IDUnitQuantity { get; set; } 
        public IRPSTextBox<InvoiceLineView> ConversionFactorQuantity { get; set; } 
        public IRPSTextBox<InvoiceLineView> QuantitySecondUnit { get; set; } 
        public IRPSTextBox<InvoiceLineView> Dimension1 { get; set; } 
        public IRPSTextBox<InvoiceLineView> Dimension2 { get; set; } 
        public IRPSTextBox<InvoiceLineView> Dimension3 { get; set; } 
        public IRPSTextBox<InvoiceLineView> QuantityRejected { get; set; } 
        public IRPSTextBox<InvoiceLineView> Price { get; set; } 
        public IRPSCheckbox<InvoiceLineView> VAT { get; set; } 
        public IRPSComboBox<InvoiceLineView> IDUnitPrice { get; set; } 
        public IRPSTextBox<InvoiceLineView> ConversionFactorPrice { get; set; } 
        public IRPSTextBox<InvoiceLineView> Amount { get; set; } 
        public IRPSTextBox<InvoiceLineView> AmountWithVAT { get; set; } 
        public IRPSTextBox<InvoiceLineView> CostPercentage { get; set; } 
        public IRPSTextBox<InvoiceLineView> DeliveryCost { get; set; } 
        public IRPSTextBox<InvoiceLineView> ImportCost { get; set; } 
        public IRPSTextBox<InvoiceLineView> TariffCost { get; set; } 
        public IRPSTextBox<InvoiceLineView> PermissionsCost { get; set; } 
        public IRPSTextBox<InvoiceLineView> BankingCost { get; set; } 
        public IRPSTextBox<InvoiceLineView> OthersCost { get; set; } 
        public IRPSTextBox<InvoiceLineView> ExternalCost { get; set; } 
        public IRPSTextBox<InvoiceLineView> Discount1 { get; set; } 
        public IRPSCheckbox<InvoiceLineView> CascadeDiscount1 { get; set; } 
        public IRPSTextBox<InvoiceLineView> Discount2 { get; set; } 
        public IRPSCheckbox<InvoiceLineView> CascadeDiscount2 { get; set; } 
        public IRPSTextBox<InvoiceLineView> Discount3 { get; set; } 
        public IRPSCheckbox<InvoiceLineView> CascadeDiscount3 { get; set; } 
        public IRPSTextBox<InvoiceLineView> Discount4 { get; set; } 
        public IRPSCheckbox<InvoiceLineView> CascadeDiscount4 { get; set; } 
        public IRPSTextBox<InvoiceLineView> Discount5 { get; set; } 
        public IRPSCheckbox<InvoiceLineView> CascadeDiscount5 { get; set; } 
        public IRPSTextBox<InvoiceLineView> AmountDiscount { get; set; } 
        public IRPSComboBox<InvoiceLineView> PositionAmountDiscount { get; set; } 
        public IRPSComboBox<InvoiceLineView> IDVAT { get; set; } 
        public IRPSComboBox<InvoiceLineView> IDVATSurcharge { get; set; } 
        public IRPSTextBox<InvoiceLineView> PercentSurcharge { get; set; } 
        public IRPSCheckbox<InvoiceLineView> GenerateAutoInvoice { get; set; } 
        public IRPSComboBox<InvoiceLineView> IDSite { get; set; } 
        public IRPSComboBox<InvoiceLineView> IDWarehouse { get; set; } 
        public IRPSComboBox<InvoiceLineView> IDDeliveryNoteType { get; set; } 
        public IRPSComboBox<InvoiceLineView> IDReturnCause { get; set; } 
        public IRPSComboBox<InvoiceLineView> IDAccount { get; set; } 
        public IRPSTextBox<InvoiceLineView> CostPercentage1 { get; set; } 
        public IRPSTextBox<InvoiceLineView> NumProm { get; set; } 
        public IRPSCheckbox<InvoiceLineView> Rappel { get; set; } 
        public IRPSComboBox<InvoiceLineView> UIIDProject { get; set; } 
        public IRPSComboBox<InvoiceLineView> UIIDProjectTask { get; set; } 
        public IRPSComboBox<InvoiceLineView> UIIDProjectMaterial { get; set; } 
        public IRPSComboBox<InvoiceLineView> UIIDManufacturingOrder { get; set; } 
        public IRPSComboBox<InvoiceLineView> UIIDMOTask { get; set; } 
        public IRPSComboBox<InvoiceLineView> UIIDMOMaterial { get; set; } 
        public IRPSComboBox<InvoiceLineView> UIIDMaintenanceOrder { get; set; } 
        public IRPSComboBox<InvoiceLineView> UIIDOrderMaterialPrevision { get; set; } 
        public IRPSButton<InvoiceLineView> InvoiceLineGetDimensionCommandButton { get; set; } 
        public IRPSTextBox<InvoiceLineView> PriceBase { get; set; } 
        public IRPSTextBox<InvoiceLineView> UIConditionsPrice { get; set; } 
        public IRPSTextBox<InvoiceLineView> UIPriceWihoutConditionsBase { get; set; } 
        public IRPSTextBox<InvoiceLineView> PriceWihoutConditions { get; set; } 
        public IRPSTextBox<InvoiceLineView> CommentInvoice { get; set; } 
        public IRPSButton<InvoiceLineView,AnalyticChildDialogView> AnalyticChildNavigationCommandButton { get; set; } 
        public InvoiceLineAnalyticsCollectionEditor<InvoiceLineView,InvoiceLineAnalyticView> InvoiceLineAnalytics { get; set; } 
        public InvoiceLineTaxsCollectionEditor<InvoiceLineView,InvoiceLineAnalyticView> InvoiceLineTaxs { get; set; } 
        public InvoiceLineConditionsAffectCollectionEditor<InvoiceLineView,InvoiceLineAnalyticView> InvoiceLineConditionsAffect { get; set; } 
        public InvoiceLineConditionsNoAffectCollectionEditor<InvoiceLineView,InvoiceLineAnalyticView> InvoiceLineConditionsNoAffect { get; set; } 
        public IRPSSection<InvoiceLineView> GeneralDataSection { get; set; } 
        public IRPSSection<InvoiceLineView> AnalyticSection { get; set; } 
        public IRPSSection<InvoiceLineView> TaxSection { get; set; } 
        public IRPSSection<InvoiceLineView> ConditionSectionAffect { get; set; } 
        public IRPSSection<InvoiceLineView> ConditionSectionNoAffect { get; set; } 
        public IRPSSection<InvoiceLineView> Comments { get; set; } 
        public InvoiceFromDeliveryNote Screen { get; set; }
        public InvoiceLineView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class InvoiceLineAnalyticsCollectionEditor<InvoiceLineView,InvoiceLineAnalyticView>:RPSCollectionEditor<InvoiceLineView,InvoiceLineAnalyticView> where InvoiceLineView : class, IView where InvoiceLineAnalyticView : class, IView
    {
        public  InvoiceLineAnalyticsGridView<InvoiceLineView,InvoiceLineAnalyticView> GridView {get;set;}
    }
    public partial class InvoiceLineAnalyticsGridView <InvoiceLineView,InvoiceLineAnalyticView> :  RPSGridView<InvoiceLineView,InvoiceLineAnalyticView> where InvoiceLineView : class, IView where InvoiceLineAnalyticView : class, IView
    {
        public InvoiceLineAnalyticsGridView(InvoiceLineView currentView,InvoiceLineAnalyticView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDDimension = RPSControlFactory.CreateRPSGridComboBox<InvoiceLineView>("","#18a98a9a-33dd-4f1c-8afe-ab24b3f02f50 .ag-row[role='row']@ROWINDEX [col-id='cIDDimension']","",true, this.CurrentView);
 
            IDDimValue = RPSControlFactory.CreateRPSGridComboBox<InvoiceLineView>("","#18a98a9a-33dd-4f1c-8afe-ab24b3f02f50 .ag-row[role='row']@ROWINDEX [col-id='cIDDimValue']","",true, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceLineView>("","#18a98a9a-33dd-4f1c-8afe-ab24b3f02f50 .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceLineView>("","#18a98a9a-33dd-4f1c-8afe-ab24b3f02f50 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<InvoiceLineView> IDDimension { get; set; } 
        public IRPSGridComboBox<InvoiceLineView> IDDimValue { get; set; } 
        public IRPSGridTextBox<InvoiceLineView> Percentage { get; set; } 
        public IRPSGridTextBox<InvoiceLineView> Amount { get; set; } 
                     
    }
 
        public partial class InvoiceLineTaxsCollectionEditor<InvoiceLineView,InvoiceLineAnalyticView>:RPSCollectionEditor<InvoiceLineView,InvoiceLineAnalyticView> where InvoiceLineView : class, IView where InvoiceLineAnalyticView : class, IView
    {
        public  InvoiceLineTaxsGridView<InvoiceLineView,InvoiceLineAnalyticView> GridView {get;set;}
    }
    public partial class InvoiceLineTaxsGridView <InvoiceLineView,InvoiceLineAnalyticView> :  RPSGridView<InvoiceLineView,InvoiceLineAnalyticView> where InvoiceLineView : class, IView where InvoiceLineAnalyticView : class, IView
    {
        public InvoiceLineTaxsGridView(InvoiceLineView currentView,InvoiceLineAnalyticView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDTaxValue = RPSControlFactory.CreateRPSGridComboBox<InvoiceLineView>("","#1d3eb564-2d04-4793-bbf2-b954e576d2e4 .ag-row[role='row']@ROWINDEX [col-id='cIDTaxValue']","",true, this.CurrentView);
 
            ApplicationType = RPSControlFactory.CreateRPSGridEnumComboBox<InvoiceLineView>("","#1d3eb564-2d04-4793-bbf2-b954e576d2e4 .ag-row[role='row']@ROWINDEX [col-id='cApplicationType']","",true, this.CurrentView);
 
            BaseType = RPSControlFactory.CreateRPSGridEnumComboBox<InvoiceLineView>("","#1d3eb564-2d04-4793-bbf2-b954e576d2e4 .ag-row[role='row']@ROWINDEX [col-id='cBaseType']","",true, this.CurrentView);
 
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<InvoiceLineView>("","#1d3eb564-2d04-4793-bbf2-b954e576d2e4 .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            Value = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceLineView>("","#1d3eb564-2d04-4793-bbf2-b954e576d2e4 .ag-row[role='row']@ROWINDEX [col-id='cValue']","",true, this.CurrentView);
 
            VAT = RPSControlFactory.CreateRPSGridCheckBox<InvoiceLineView>("","#1d3eb564-2d04-4793-bbf2-b954e576d2e4 .ag-row[role='row']@ROWINDEX [col-id='cVAT']","",true, this.CurrentView);
 
            PriceIncluded = RPSControlFactory.CreateRPSGridCheckBox<InvoiceLineView>("","#1d3eb564-2d04-4793-bbf2-b954e576d2e4 .ag-row[role='row']@ROWINDEX [col-id='cPriceIncluded']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<InvoiceLineView> IDTaxValue { get; set; } 
        public IRPSGridComboBox<InvoiceLineView> ApplicationType { get; set; } 
        public IRPSGridComboBox<InvoiceLineView> BaseType { get; set; } 
        public IRPSGridComboBox<InvoiceLineView> Type { get; set; } 
        public IRPSGridTextBox<InvoiceLineView> Value { get; set; } 
        public IRPSGridCheckbox<InvoiceLineView> VAT { get; set; } 
        public IRPSGridCheckbox<InvoiceLineView> PriceIncluded { get; set; } 
                     
    }
 
        public partial class InvoiceLineConditionsAffectCollectionEditor<InvoiceLineView,InvoiceLineAnalyticView>:RPSCollectionEditor<InvoiceLineView,InvoiceLineAnalyticView> where InvoiceLineView : class, IView where InvoiceLineAnalyticView : class, IView
    {
        public  InvoiceLineConditionsAffectGridView<InvoiceLineView,InvoiceLineAnalyticView> GridView {get;set;}
    }
    public partial class InvoiceLineConditionsAffectGridView <InvoiceLineView,InvoiceLineAnalyticView> :  RPSGridView<InvoiceLineView,InvoiceLineAnalyticView> where InvoiceLineView : class, IView where InvoiceLineAnalyticView : class, IView
    {
        public InvoiceLineConditionsAffectGridView(InvoiceLineView currentView,InvoiceLineAnalyticView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<InvoiceLineView>("","#43621403-dcf0-481f-91d0-c888a9c4c4eb .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            ConditionValueOriginal = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceLineView>("","#43621403-dcf0-481f-91d0-c888a9c4c4eb .ag-row[role='row']@ROWINDEX [col-id='cConditionValueOriginal']","",true, this.CurrentView);
 
            ConditionValue = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceLineView>("","#43621403-dcf0-481f-91d0-c888a9c4c4eb .ag-row[role='row']@ROWINDEX [col-id='cConditionValue']","",true, this.CurrentView);
 
            Base = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceLineView>("","#43621403-dcf0-481f-91d0-c888a9c4c4eb .ag-row[role='row']@ROWINDEX [col-id='cBase']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceLineView>("","#43621403-dcf0-481f-91d0-c888a9c4c4eb .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            ConditionType = RPSControlFactory.CreateRPSGridEnumComboBox<InvoiceLineView>("","#43621403-dcf0-481f-91d0-c888a9c4c4eb .ag-row[role='row']@ROWINDEX [col-id='cConditionType']","",true, this.CurrentView);
 
            BaseApply = RPSControlFactory.CreateRPSGridEnumComboBox<InvoiceLineView>("","#43621403-dcf0-481f-91d0-c888a9c4c4eb .ag-row[role='row']@ROWINDEX [col-id='cBaseApply']","",true, this.CurrentView);
 
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<InvoiceLineView>("","#43621403-dcf0-481f-91d0-c888a9c4c4eb .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",true, this.CurrentView);
 
            DateTo = RPSControlFactory.CreateRPSGridTextBox<InvoiceLineView>("","#43621403-dcf0-481f-91d0-c888a9c4c4eb .ag-row[role='row']@ROWINDEX [col-id='cDateTo']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<InvoiceLineView> Type { get; set; } 
        public IRPSGridTextBox<InvoiceLineView> ConditionValueOriginal { get; set; } 
        public IRPSGridTextBox<InvoiceLineView> ConditionValue { get; set; } 
        public IRPSGridTextBox<InvoiceLineView> Base { get; set; } 
        public IRPSGridTextBox<InvoiceLineView> Amount { get; set; } 
        public IRPSGridComboBox<InvoiceLineView> ConditionType { get; set; } 
        public IRPSGridComboBox<InvoiceLineView> BaseApply { get; set; } 
        public IRPSGridTextBox<InvoiceLineView> DateFrom { get; set; } 
        public IRPSGridTextBox<InvoiceLineView> DateTo { get; set; } 
                     
    }
 
        public partial class InvoiceLineConditionsNoAffectCollectionEditor<InvoiceLineView,InvoiceLineAnalyticView>:RPSCollectionEditor<InvoiceLineView,InvoiceLineAnalyticView> where InvoiceLineView : class, IView where InvoiceLineAnalyticView : class, IView
    {
        public  InvoiceLineConditionsNoAffectGridView<InvoiceLineView,InvoiceLineAnalyticView> GridView {get;set;}
    }
    public partial class InvoiceLineConditionsNoAffectGridView <InvoiceLineView,InvoiceLineAnalyticView> :  RPSGridView<InvoiceLineView,InvoiceLineAnalyticView> where InvoiceLineView : class, IView where InvoiceLineAnalyticView : class, IView
    {
        public InvoiceLineConditionsNoAffectGridView(InvoiceLineView currentView,InvoiceLineAnalyticView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<InvoiceLineView>("","#74d32078-5a02-4d3c-a197-7d304b49a8b5 .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            ConditionValueOriginal = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceLineView>("","#74d32078-5a02-4d3c-a197-7d304b49a8b5 .ag-row[role='row']@ROWINDEX [col-id='cConditionValueOriginal']","",true, this.CurrentView);
 
            ConditionValue = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceLineView>("","#74d32078-5a02-4d3c-a197-7d304b49a8b5 .ag-row[role='row']@ROWINDEX [col-id='cConditionValue']","",true, this.CurrentView);
 
            Base = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceLineView>("","#74d32078-5a02-4d3c-a197-7d304b49a8b5 .ag-row[role='row']@ROWINDEX [col-id='cBase']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceLineView>("","#74d32078-5a02-4d3c-a197-7d304b49a8b5 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            ConditionType = RPSControlFactory.CreateRPSGridEnumComboBox<InvoiceLineView>("","#74d32078-5a02-4d3c-a197-7d304b49a8b5 .ag-row[role='row']@ROWINDEX [col-id='cConditionType']","",true, this.CurrentView);
 
            BaseApply = RPSControlFactory.CreateRPSGridEnumComboBox<InvoiceLineView>("","#74d32078-5a02-4d3c-a197-7d304b49a8b5 .ag-row[role='row']@ROWINDEX [col-id='cBaseApply']","",true, this.CurrentView);
 
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<InvoiceLineView>("","#74d32078-5a02-4d3c-a197-7d304b49a8b5 .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",true, this.CurrentView);
 
            DateTo = RPSControlFactory.CreateRPSGridTextBox<InvoiceLineView>("","#74d32078-5a02-4d3c-a197-7d304b49a8b5 .ag-row[role='row']@ROWINDEX [col-id='cDateTo']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<InvoiceLineView> Type { get; set; } 
        public IRPSGridTextBox<InvoiceLineView> ConditionValueOriginal { get; set; } 
        public IRPSGridTextBox<InvoiceLineView> ConditionValue { get; set; } 
        public IRPSGridTextBox<InvoiceLineView> Base { get; set; } 
        public IRPSGridTextBox<InvoiceLineView> Amount { get; set; } 
        public IRPSGridComboBox<InvoiceLineView> ConditionType { get; set; } 
        public IRPSGridComboBox<InvoiceLineView> BaseApply { get; set; } 
        public IRPSGridTextBox<InvoiceLineView> DateFrom { get; set; } 
        public IRPSGridTextBox<InvoiceLineView> DateTo { get; set; } 
                     
    }
 
    }
  
            
    public partial class InvoiceLineAnalyticView : View
    {
        public InvoiceLineAnalyticView(InvoiceFromDeliveryNote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<InvoiceLineAnalyticView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<InvoiceLineAnalyticView,InvoiceLineView>( this,Screen.InvoiceLineView);
 
            BackButton = RPSControlFactory.RPSBackButton<InvoiceLineAnalyticView,InvoiceLineView>( this,Screen.InvoiceLineView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<InvoiceLineAnalyticView,InvoiceLineView>( this,Screen.InvoiceLineView);
 
            IDDimension = RPSControlFactory.CreateRPSComboBox<InvoiceLineAnalyticView>("cedca050-ed85-4c36-8493-e8870a0e8ffc","","",true, this);
 
            IDDimValue = RPSControlFactory.CreateRPSComboBox<InvoiceLineAnalyticView>("2cd5d8ef-17b0-4f16-a632-5b4fac05bff5","","",true, this);
 
            Percentage = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineAnalyticView>("37ca0404-bf35-4e0a-a16a-4cbcac3989e7","","",true, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineAnalyticView>("669698f5-1597-47c5-ad37-6ccd7fc5d635","","",true, this);
 

        }
        public IRPSButton<InvoiceLineAnalyticView> DeleteButton { get; set; } 
        public IRPSButton<InvoiceLineAnalyticView,InvoiceLineView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<InvoiceLineAnalyticView,InvoiceLineView> BackButton { get; set; } 
        public IRPSAcceptButton<InvoiceLineAnalyticView,InvoiceLineView> AcceptButton { get; set; } 
        public IRPSComboBox<InvoiceLineAnalyticView> IDDimension { get; set; } 
        public IRPSComboBox<InvoiceLineAnalyticView> IDDimValue { get; set; } 
        public IRPSTextBox<InvoiceLineAnalyticView> Percentage { get; set; } 
        public IRPSTextBox<InvoiceLineAnalyticView> Amount { get; set; } 
        public InvoiceFromDeliveryNote Screen { get; set; }
        public InvoiceLineAnalyticView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class InvoiceLineTaxView : View
    {
        public InvoiceLineTaxView(InvoiceFromDeliveryNote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<InvoiceLineTaxView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<InvoiceLineTaxView,InvoiceLineView>( this,Screen.InvoiceLineView);
 
            BackButton = RPSControlFactory.RPSBackButton<InvoiceLineTaxView,InvoiceLineView>( this,Screen.InvoiceLineView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<InvoiceLineTaxView,InvoiceLineView>( this,Screen.InvoiceLineView);
 
            IDTaxValue = RPSControlFactory.CreateRPSComboBox<InvoiceLineTaxView>("b0f2e74a-b0d2-43d8-a793-876f46ebe656","","",true, this);
 
            ApplicationType = RPSControlFactory.CreateRPSEnumComboBox<InvoiceLineTaxView>("38a878d8-fd4a-4b27-b7a0-cb3840674577","","",true, this);
 
            BaseType = RPSControlFactory.CreateRPSEnumComboBox<InvoiceLineTaxView>("8b757309-aad8-4c19-8cee-11431cceb727","","",true, this);
 
            Type = RPSControlFactory.CreateRPSEnumComboBox<InvoiceLineTaxView>("24f762c1-72a0-437a-b9d9-419524ff91a1","","",true, this);
 
            Value = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineTaxView>("cae66fe5-3092-457a-9f38-a357ef1304c2","","",true, this);
 
            PriceIncluded = RPSControlFactory.CreateRPSCheckBox<InvoiceLineTaxView>("b340a03d-65c8-4484-b6db-186998b5e8ec","","",true, this);
 
            VAT = RPSControlFactory.CreateRPSCheckBox<InvoiceLineTaxView>("49caa1a8-bf5d-4f97-87fb-7802284084f1","","",true, this);
 

        }
        public IRPSButton<InvoiceLineTaxView> DeleteButton { get; set; } 
        public IRPSButton<InvoiceLineTaxView,InvoiceLineView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<InvoiceLineTaxView,InvoiceLineView> BackButton { get; set; } 
        public IRPSAcceptButton<InvoiceLineTaxView,InvoiceLineView> AcceptButton { get; set; } 
        public IRPSComboBox<InvoiceLineTaxView> IDTaxValue { get; set; } 
        public IRPSComboBox<InvoiceLineTaxView> ApplicationType { get; set; } 
        public IRPSComboBox<InvoiceLineTaxView> BaseType { get; set; } 
        public IRPSComboBox<InvoiceLineTaxView> Type { get; set; } 
        public IRPSTextBox<InvoiceLineTaxView> Value { get; set; } 
        public IRPSCheckbox<InvoiceLineTaxView> PriceIncluded { get; set; } 
        public IRPSCheckbox<InvoiceLineTaxView> VAT { get; set; } 
        public InvoiceFromDeliveryNote Screen { get; set; }
        public InvoiceLineTaxView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class InvoiceResumenDialogView : View
    {
        public InvoiceResumenDialogView(InvoiceFromDeliveryNote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CompanyName = RPSControlFactory.CreateRPSTextBox<InvoiceResumenDialogView>("d68eddab-8b66-4556-924c-a80c4de4e518","","",false, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<InvoiceResumenDialogView>("2a92080f-fb79-4d5d-a1c0-2c7de3bb04e1","","",false, this);
 
            TotalCalc = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceResumenDialogView>("90f90fbd-02ae-47b5-8733-4b39f37b186f","","",false, this);
 
            bPrint = RPSControlFactory.CreateRPSCheckBox<InvoiceResumenDialogView>("87579ea2-bb8d-42ad-9c5c-4158cd741ad2","","",false, this);
 
            TotalInvoice = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceResumenDialogView>("cd869e1f-45cc-432d-b7b5-5de526b3fb44","","",false, this);
 
            TotalBase = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceResumenDialogView>("812e8c15-99b9-4df2-9a7a-6ab8fb2d836e","","",false, this);
 
            RetentionPercent = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceResumenDialogView>("6d3149a4-126e-4572-a380-85a998cd8415","","",false, this);
 
            VATAmount = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceResumenDialogView>("8f281102-7fa3-42be-b14e-3300921a797a","","",false, this);
 
            SurchargeAmount = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceResumenDialogView>("aa834a3e-be61-4f8c-b444-a1d27f903174","","",false, this);
 
            Retention = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceResumenDialogView>("f5b696a6-261d-4c3b-a015-72fc3a9c78a8","","",false, this);
 
            TotalTaxInvoice = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceResumenDialogView>("94a37c62-afa6-492b-b7d6-47213097fa49","","",false, this);
 
            FinancialSurchargeAmount = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceResumenDialogView>("c0471e32-f0e1-48a1-9cde-d6eb03e0cfd5","","",false, this);
 
            Transport = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceResumenDialogView>("69889e59-27c1-4cb6-b598-2baea433c90f","","",true, this);
 
            Discount1 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceResumenDialogView>("9d72ce9d-d016-4d22-9a2b-8cbc3e9dea7e","","",false, this);
 
            Discount2 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceResumenDialogView>("ec701126-46b1-45d0-95f2-d3041532a1b7","","",false, this);
 
            Discount3 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceResumenDialogView>("684896ba-c5bf-40b2-82ed-81a2f87bddb6","","",false, this);
 
            FinancialSurcharge = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceResumenDialogView>("538e8548-1959-44b4-ae92-92fc653f3a04","","",false, this);
 
            CashDiscount = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceResumenDialogView>("d063bb33-510b-48bc-a639-85043f3c5793","","",false, this);
 
            VATBase1 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceResumenDialogView>("e5cbab51-bdb3-40fc-be54-5ac7e7f701cd","","",false, this);
 
            VATBase2 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceResumenDialogView>("243a0d0d-4c0f-45a0-bc5c-43fb602f6a4e","","",false, this);
 
            VATBase3 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceResumenDialogView>("1fd8a4c8-cbeb-40d1-bdd8-61b0af6df999","","",false, this);
 
            VATBase4 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceResumenDialogView>("c89512f4-d0e2-4909-9849-fac450beb4f3","","",false, this);
 
            VATBase5 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceResumenDialogView>("f44aace2-febc-4ba5-be66-0d73b5ff15c1","","",false, this);
 
            VATBase6 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceResumenDialogView>("190e7147-df94-44b1-9a8b-99f58677753f","","",false, this);
 
            VATAmount1 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceResumenDialogView>("2e9f70da-c9c7-4e63-9035-0b3649e1e470","","",false, this);
 
            VATAmount2 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceResumenDialogView>("6b3660bf-e142-4d1d-8df6-72a6f09722df","","",false, this);
 
            VATAmount3 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceResumenDialogView>("ef6ae083-0f5c-42e4-bddf-0ba32b1f30c2","","",false, this);
 
            VATAmount4 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceResumenDialogView>("3f38e2ae-7e03-45dc-8d83-0b2178a681cb","","",false, this);
 
            VATAmount5 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceResumenDialogView>("0950209c-325f-46be-aef9-2e48def0b725","","",false, this);
 
            VATAmount6 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceResumenDialogView>("8bb4ffd7-01cf-4867-9db4-8c020494d4e3","","",false, this);
 
            SurchargeAmount1 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceResumenDialogView>("f8965da9-cce2-424d-996b-5eab2aa1b9c9","","",false, this);
 
            SurchargeAmount2 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceResumenDialogView>("3b74e67e-b922-469c-a274-0786df3323e6","","",false, this);
 
            SurchargeAmount3 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceResumenDialogView>("a413f695-4dbd-4184-9b55-d1128fb054a6","","",false, this);
 
            SurchargeAmount4 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceResumenDialogView>("7d1a475e-701f-41d1-9a5c-9247bcd2228c","","",false, this);
 
            SurchargeAmount5 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceResumenDialogView>("9fb45e3b-b251-44fe-8504-1a8e8fec9828","","",false, this);
 
            SurchargeAmount6 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceResumenDialogView>("ddc0cd29-7dde-474d-b0ee-a805df1c3a27","","",false, this);
 
            NotNotUpdateMovements = RPSControlFactory.CreateRPSCheckBox<InvoiceResumenDialogView>("a774fe2c-0d58-40eb-91e2-d061b55ee59e","","",false, this);
 
            TotalLinesDeliveyCompany = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceResumenDialogView>("a51d4809-ac6a-4d56-9fd2-e08872a6e843","","",false, this);
 
            TotalLinesInvoiceCompany = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceResumenDialogView>("e7662105-d796-40fc-9ffe-79c81fc42948","","",false, this);
 
            TotalLinesBalance = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceResumenDialogView>("085f5be7-9a11-4250-8a03-de389456f996","","",false, this);
 
            Optionscreen = RPSControlFactory.CreateRPSOption<InvoiceResumenDialogView>( "430805bf-c62b-49fe-81e5-878f79326970","","",this);
 
            OptionMail = RPSControlFactory.CreateRPSOption<InvoiceResumenDialogView>( "5bf91a9c-b5d9-46d1-b6d9-e71083a405ab","","",this);
 
            UIOptSupplier = RPSControlFactory.CreateRPSOption<InvoiceResumenDialogView>( "491cedba-737c-430d-8eea-a2ac5aea83b6","","",this);
 
            UIOptSelected = RPSControlFactory.CreateRPSOption<InvoiceResumenDialogView>( "711dbc25-4981-4bcc-b004-e27393fefc27","","",this);
 
            UIPrintOptionsIDLanguage = RPSControlFactory.CreateRPSComboBox<InvoiceResumenDialogView>("d85bd4c7-7853-4ce1-b089-f08f2d7d13a6","","",false, this);
 
            UIPrintSpecificReport = RPSControlFactory.CreateRPSCheckBox<InvoiceResumenDialogView>("85c5ece1-88bc-4594-8065-fda9dda74a4f","","",false, this);
 
            UICodInvoiceReport = RPSControlFactory.CreateRPSComboBox<InvoiceResumenDialogView>("0db9aaf2-fcbc-4773-b52a-44b720f3edf5","","",false, this);
 
            CollectionInit params_InvoicePayments = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="db3ee61b-8d1d-4abd-8d8c-247b25f42993",CSSSelectorGrid="",XPathGrid=""};
            InvoicePayments = RPSControlFactory.RPSCreateCollectionWithGrid<InvoicePaymentsCollectionEditor<InvoiceResumenDialogView>,InvoiceResumenDialogView>( params_InvoicePayments,this);
 
            CollectionInit params_GetACCTransactionsTempFromPurchase = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="215b5df7-0a94-406f-8dc6-be3968ccdc5a",CSSSelectorGrid="",XPathGrid=""};
            GetACCTransactionsTempFromPurchase = RPSControlFactory.RPSCreateCollectionWithGrid<GetACCTransactionsTempFromPurchaseCollectionEditor<InvoiceResumenDialogView>,InvoiceResumenDialogView>( params_GetACCTransactionsTempFromPurchase,this);
 
            CollectionInit params_GetACCTransactionsTempAnalyticFromPurchase = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="06568309-7da7-4567-8202-175b09d873d1",CSSSelectorGrid="",XPathGrid=""};
            GetACCTransactionsTempAnalyticFromPurchase = RPSControlFactory.RPSCreateCollectionWithGrid<GetACCTransactionsTempAnalyticFromPurchaseCollectionEditor<InvoiceResumenDialogView>,InvoiceResumenDialogView>( params_GetACCTransactionsTempAnalyticFromPurchase,this);
 
            Invoice = RPSControlFactory.CreateRPSSection<InvoiceResumenDialogView>( "","ul li[rpsid='2fcbb43f-e7ba-4961-a58b-89177df7aaf4']","",this);
 
            InvoicePayments1 = RPSControlFactory.CreateRPSSection<InvoiceResumenDialogView>( "","ul li[rpsid='ccfef39e-b6f7-4ffb-b8ed-2fc32cfc441e']","",this);
 
            SectionGeneralLedger = RPSControlFactory.CreateRPSSection<InvoiceResumenDialogView>( "","ul li[rpsid='1ed141a8-ffe5-4d31-837b-13e7ee16c026']","",this);
 
            SectionAnalytic = RPSControlFactory.CreateRPSSection<InvoiceResumenDialogView>( "","ul li[rpsid='ad769a2f-c5db-4d29-b0b7-ee9d89f5ced6']","",this);
 
            PrintOptions = RPSControlFactory.CreateRPSSection<InvoiceResumenDialogView>( "","ul li[rpsid='5c9c0536-9192-4c81-ba15-0f381dd02b5b']","",this);
 

        }
        public IRPSTextBox<InvoiceResumenDialogView> CompanyName { get; set; } 
        public IRPSTextBox<InvoiceResumenDialogView> VATNumber { get; set; } 
        public IRPSTextBox<InvoiceResumenDialogView> TotalCalc { get; set; } 
        public IRPSCheckbox<InvoiceResumenDialogView> bPrint { get; set; } 
        public IRPSTextBox<InvoiceResumenDialogView> TotalInvoice { get; set; } 
        public IRPSTextBox<InvoiceResumenDialogView> TotalBase { get; set; } 
        public IRPSTextBox<InvoiceResumenDialogView> RetentionPercent { get; set; } 
        public IRPSTextBox<InvoiceResumenDialogView> VATAmount { get; set; } 
        public IRPSTextBox<InvoiceResumenDialogView> SurchargeAmount { get; set; } 
        public IRPSTextBox<InvoiceResumenDialogView> Retention { get; set; } 
        public IRPSTextBox<InvoiceResumenDialogView> TotalTaxInvoice { get; set; } 
        public IRPSTextBox<InvoiceResumenDialogView> FinancialSurchargeAmount { get; set; } 
        public IRPSTextBox<InvoiceResumenDialogView> Transport { get; set; } 
        public IRPSTextBox<InvoiceResumenDialogView> Discount1 { get; set; } 
        public IRPSTextBox<InvoiceResumenDialogView> Discount2 { get; set; } 
        public IRPSTextBox<InvoiceResumenDialogView> Discount3 { get; set; } 
        public IRPSTextBox<InvoiceResumenDialogView> FinancialSurcharge { get; set; } 
        public IRPSTextBox<InvoiceResumenDialogView> CashDiscount { get; set; } 
        public IRPSTextBox<InvoiceResumenDialogView> VATBase1 { get; set; } 
        public IRPSTextBox<InvoiceResumenDialogView> VATBase2 { get; set; } 
        public IRPSTextBox<InvoiceResumenDialogView> VATBase3 { get; set; } 
        public IRPSTextBox<InvoiceResumenDialogView> VATBase4 { get; set; } 
        public IRPSTextBox<InvoiceResumenDialogView> VATBase5 { get; set; } 
        public IRPSTextBox<InvoiceResumenDialogView> VATBase6 { get; set; } 
        public IRPSTextBox<InvoiceResumenDialogView> VATAmount1 { get; set; } 
        public IRPSTextBox<InvoiceResumenDialogView> VATAmount2 { get; set; } 
        public IRPSTextBox<InvoiceResumenDialogView> VATAmount3 { get; set; } 
        public IRPSTextBox<InvoiceResumenDialogView> VATAmount4 { get; set; } 
        public IRPSTextBox<InvoiceResumenDialogView> VATAmount5 { get; set; } 
        public IRPSTextBox<InvoiceResumenDialogView> VATAmount6 { get; set; } 
        public IRPSTextBox<InvoiceResumenDialogView> SurchargeAmount1 { get; set; } 
        public IRPSTextBox<InvoiceResumenDialogView> SurchargeAmount2 { get; set; } 
        public IRPSTextBox<InvoiceResumenDialogView> SurchargeAmount3 { get; set; } 
        public IRPSTextBox<InvoiceResumenDialogView> SurchargeAmount4 { get; set; } 
        public IRPSTextBox<InvoiceResumenDialogView> SurchargeAmount5 { get; set; } 
        public IRPSTextBox<InvoiceResumenDialogView> SurchargeAmount6 { get; set; } 
        public IRPSCheckbox<InvoiceResumenDialogView> NotNotUpdateMovements { get; set; } 
        public IRPSTextBox<InvoiceResumenDialogView> TotalLinesDeliveyCompany { get; set; } 
        public IRPSTextBox<InvoiceResumenDialogView> TotalLinesInvoiceCompany { get; set; } 
        public IRPSTextBox<InvoiceResumenDialogView> TotalLinesBalance { get; set; } 
        public IRPSOption<InvoiceResumenDialogView> Optionscreen { get; set; } 
        public IRPSOption<InvoiceResumenDialogView> OptionMail { get; set; } 
        public IRPSOption<InvoiceResumenDialogView> UIOptSupplier { get; set; } 
        public IRPSOption<InvoiceResumenDialogView> UIOptSelected { get; set; } 
        public IRPSComboBox<InvoiceResumenDialogView> UIPrintOptionsIDLanguage { get; set; } 
        public IRPSCheckbox<InvoiceResumenDialogView> UIPrintSpecificReport { get; set; } 
        public IRPSComboBox<InvoiceResumenDialogView> UICodInvoiceReport { get; set; } 
        public InvoicePaymentsCollectionEditor<InvoiceResumenDialogView> InvoicePayments { get; set; } 
        public GetACCTransactionsTempFromPurchaseCollectionEditor<InvoiceResumenDialogView> GetACCTransactionsTempFromPurchase { get; set; } 
        public GetACCTransactionsTempAnalyticFromPurchaseCollectionEditor<InvoiceResumenDialogView> GetACCTransactionsTempAnalyticFromPurchase { get; set; } 
        public IRPSSection<InvoiceResumenDialogView> Invoice { get; set; } 
        public IRPSSection<InvoiceResumenDialogView> InvoicePayments1 { get; set; } 
        public IRPSSection<InvoiceResumenDialogView> SectionGeneralLedger { get; set; } 
        public IRPSSection<InvoiceResumenDialogView> SectionAnalytic { get; set; } 
        public IRPSSection<InvoiceResumenDialogView> PrintOptions { get; set; } 
        public InvoiceFromDeliveryNote Screen { get; set; }
        public InvoiceResumenDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class InvoicePaymentsCollectionEditor<InvoiceResumenDialogView>:RPSCollectionEditor<InvoiceResumenDialogView> where InvoiceResumenDialogView : class, IView
    {
        public  InvoicePaymentsGridView<InvoiceResumenDialogView> GridView {get;set;}
    }
    public partial class InvoicePaymentsGridView <InvoiceResumenDialogView> :  RPSGridView<InvoiceResumenDialogView> where InvoiceResumenDialogView : class, IView
    {
        public InvoicePaymentsGridView(InvoiceResumenDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDPaymentMethod = RPSControlFactory.CreateRPSGridComboBox<InvoiceResumenDialogView>("","#db3ee61b-8d1d-4abd-8d8c-247b25f42993 .ag-row[role='row']@ROWINDEX [col-id='cIDPaymentMethod']","",false, this.CurrentView);
 
            NumPayment = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceResumenDialogView>("","#db3ee61b-8d1d-4abd-8d8c-247b25f42993 .ag-row[role='row']@ROWINDEX [col-id='cNumPayment']","",true, this.CurrentView);
 
            Date = RPSControlFactory.CreateRPSGridTextBox<InvoiceResumenDialogView>("","#db3ee61b-8d1d-4abd-8d8c-247b25f42993 .ag-row[role='row']@ROWINDEX [col-id='cDate']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceResumenDialogView>("","#db3ee61b-8d1d-4abd-8d8c-247b25f42993 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            CDDate = RPSControlFactory.CreateRPSGridTextBox<InvoiceResumenDialogView>("","#db3ee61b-8d1d-4abd-8d8c-247b25f42993 .ag-row[role='row']@ROWINDEX [col-id='cCDDate']","",false, this.CurrentView);
 
            CDToleranceDate = RPSControlFactory.CreateRPSGridTextBox<InvoiceResumenDialogView>("","#db3ee61b-8d1d-4abd-8d8c-247b25f42993 .ag-row[role='row']@ROWINDEX [col-id='cCDToleranceDate']","",false, this.CurrentView);
 
            CDAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceResumenDialogView>("","#db3ee61b-8d1d-4abd-8d8c-247b25f42993 .ag-row[role='row']@ROWINDEX [col-id='cCDAmount']","",true, this.CurrentView);
 
            CDToleranceAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceResumenDialogView>("","#db3ee61b-8d1d-4abd-8d8c-247b25f42993 .ag-row[role='row']@ROWINDEX [col-id='cCDToleranceAmount']","",true, this.CurrentView);
 
            CDPercentage = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceResumenDialogView>("","#db3ee61b-8d1d-4abd-8d8c-247b25f42993 .ag-row[role='row']@ROWINDEX [col-id='cCDPercentage']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<InvoiceResumenDialogView> IDPaymentMethod { get; set; } 
        public IRPSGridTextBox<InvoiceResumenDialogView> NumPayment { get; set; } 
        public IRPSGridTextBox<InvoiceResumenDialogView> Date { get; set; } 
        public IRPSGridTextBox<InvoiceResumenDialogView> Amount { get; set; } 
        public IRPSGridTextBox<InvoiceResumenDialogView> CDDate { get; set; } 
        public IRPSGridTextBox<InvoiceResumenDialogView> CDToleranceDate { get; set; } 
        public IRPSGridTextBox<InvoiceResumenDialogView> CDAmount { get; set; } 
        public IRPSGridTextBox<InvoiceResumenDialogView> CDToleranceAmount { get; set; } 
        public IRPSGridTextBox<InvoiceResumenDialogView> CDPercentage { get; set; } 
                     
    }
 
        public partial class GetACCTransactionsTempFromPurchaseCollectionEditor<InvoiceResumenDialogView>:RPSCollectionEditor<InvoiceResumenDialogView> where InvoiceResumenDialogView : class, IView
    {
        public  GetACCTransactionsTempFromPurchaseGridView<InvoiceResumenDialogView> GridView {get;set;}
    }
    public partial class GetACCTransactionsTempFromPurchaseGridView <InvoiceResumenDialogView> :  RPSGridView<InvoiceResumenDialogView> where InvoiceResumenDialogView : class, IView
    {
        public GetACCTransactionsTempFromPurchaseGridView(InvoiceResumenDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            SignType = RPSControlFactory.CreateRPSGridTextBox<InvoiceResumenDialogView>("","#215b5df7-0a94-406f-8dc6-be3968ccdc5a .ag-row[role='row']@ROWINDEX [col-id='cSignType']","",false, this.CurrentView);
 
            Extension = RPSControlFactory.CreateRPSGridTextBox<InvoiceResumenDialogView>("","#215b5df7-0a94-406f-8dc6-be3968ccdc5a .ag-row[role='row']@ROWINDEX [col-id='cExtension']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<InvoiceResumenDialogView> SignType { get; set; } 
        public IRPSGridTextBox<InvoiceResumenDialogView> Extension { get; set; } 
                     
    }
 
        public partial class GetACCTransactionsTempAnalyticFromPurchaseCollectionEditor<InvoiceResumenDialogView>:RPSCollectionEditor<InvoiceResumenDialogView> where InvoiceResumenDialogView : class, IView
    {
        public  GetACCTransactionsTempAnalyticFromPurchaseGridView<InvoiceResumenDialogView> GridView {get;set;}
    }
    public partial class GetACCTransactionsTempAnalyticFromPurchaseGridView <InvoiceResumenDialogView> :  RPSGridView<InvoiceResumenDialogView> where InvoiceResumenDialogView : class, IView
    {
        public GetACCTransactionsTempAnalyticFromPurchaseGridView(InvoiceResumenDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {

        }
                     
    }
 
    }
  
            
    public partial class RecalculateCostChildDialogView : View
    {
        public RecalculateCostChildDialogView(InvoiceFromDeliveryNote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ChkDeliveryCost = RPSControlFactory.CreateRPSCheckBox<RecalculateCostChildDialogView>("f4e32204-16ac-4bb9-bdeb-dc4fdb2c77ff","","",false, this);
 
            Porcent = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "d3f5744a-2e52-4bcf-9816-96a1dc5d0ac6","","",this);
 
            Amount = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "05585c30-323f-463a-a7c3-2fd30fa77827","","",this);
 
            DeliveryCostQuantity = RPSControlFactory.CreateRPSFormattedTextBox<RecalculateCostChildDialogView>("b87e04ae-8dba-4eee-acf0-55c6e4513bdb","","",false, this);
 
            LineAmount = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "191db912-b2d3-4cad-bafe-24a88e64ebe7","","",this);
 
            Quantity = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "0fd5f0ee-618f-4d78-9f1f-3eb1c5fddee6","","",this);
 
            NetWeight = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "4eae9b24-5aa0-4ff6-87dd-c07ffbf8a605","","",this);
 
            GrossWeight = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "07cd4b4f-6ad3-486c-a9a5-d1a8ade2fff0","","",this);
 
            PositiveAmountPor = RPSControlFactory.CreateRPSCheckBox<RecalculateCostChildDialogView>("14f5fd0b-5052-4f65-8c2f-d0a56bf22ffa","","",false, this);
 
            OnlyArticlesPor = RPSControlFactory.CreateRPSCheckBox<RecalculateCostChildDialogView>("2d21e592-0e5a-4909-a48f-a6590aa82b3d","","",false, this);
 
            ChkImportCost = RPSControlFactory.CreateRPSCheckBox<RecalculateCostChildDialogView>("1c5dfc6c-d225-4129-ad1e-fce4c317f88c","","",false, this);
 
            Porcent1 = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "733189b5-7be4-4c9f-bc96-328b72b1640f","","",this);
 
            Amount1 = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "b88a29b6-dbbf-4ec2-b81f-748d3e0c0ac7","","",this);
 
            ImportCostQuantity = RPSControlFactory.CreateRPSFormattedTextBox<RecalculateCostChildDialogView>("a2c7a0b1-844e-405f-8a4c-889022e4e012","","",false, this);
 
            LineAmount1 = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "1d72da56-243a-4bec-acb3-0b99458a4b70","","",this);
 
            Quantity1 = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "9897343c-a4d4-4d67-8c89-91db3856496c","","",this);
 
            NetWeight1 = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "ec5dfbac-d01c-413a-aac2-64cf3339b06e","","",this);
 
            GrossWeight1 = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "4055ae83-253d-48e1-9c6f-6c15e46c9b8c","","",this);
 
            PositiveAmountImpor = RPSControlFactory.CreateRPSCheckBox<RecalculateCostChildDialogView>("942ecb70-8754-44c8-b7e6-ca109e344a15","","",false, this);
 
            OnlyArticlesImpor = RPSControlFactory.CreateRPSCheckBox<RecalculateCostChildDialogView>("d0ec98e1-245a-4d21-b101-20dafe8181df","","",false, this);
 
            ChkTariffCost = RPSControlFactory.CreateRPSCheckBox<RecalculateCostChildDialogView>("94f97770-335c-40e1-8adf-f2ef7770620c","","",false, this);
 
            Porcent2 = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "ec9aaa42-be31-48a5-b8cc-4bb5cff6584b","","",this);
 
            Amount2 = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "ec62ef2c-2d77-4b11-baf7-39016dce2738","","",this);
 
            TariffCostQuantity = RPSControlFactory.CreateRPSFormattedTextBox<RecalculateCostChildDialogView>("449aca06-ddf4-49bf-b784-c7df3da0d8bb","","",false, this);
 
            LineAmount2 = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "0deb2cb6-f6f7-46f1-8bbc-6bb4e0e33595","","",this);
 
            Quantity2 = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "14e4f4bd-7dba-4b63-91f4-5ecad6277326","","",this);
 
            NetWeight2 = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "de4d1e36-5ec7-46ad-a771-1794ea706b78","","",this);
 
            GrossWeight2 = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "7c5902fc-cdee-40f1-8d07-d084fc1e3784","","",this);
 
            PositiveAmountTarif = RPSControlFactory.CreateRPSCheckBox<RecalculateCostChildDialogView>("0e204504-1d91-4d30-9ff1-19beb7375edc","","",false, this);
 
            OnlyArticlesTarif = RPSControlFactory.CreateRPSCheckBox<RecalculateCostChildDialogView>("6f2f409d-d421-4558-88aa-8d341495d569","","",false, this);
 

        }
        public IRPSCheckbox<RecalculateCostChildDialogView> ChkDeliveryCost { get; set; } 
        public IRPSOption<RecalculateCostChildDialogView> Porcent { get; set; } 
        public IRPSOption<RecalculateCostChildDialogView> Amount { get; set; } 
        public IRPSTextBox<RecalculateCostChildDialogView> DeliveryCostQuantity { get; set; } 
        public IRPSOption<RecalculateCostChildDialogView> LineAmount { get; set; } 
        public IRPSOption<RecalculateCostChildDialogView> Quantity { get; set; } 
        public IRPSOption<RecalculateCostChildDialogView> NetWeight { get; set; } 
        public IRPSOption<RecalculateCostChildDialogView> GrossWeight { get; set; } 
        public IRPSCheckbox<RecalculateCostChildDialogView> PositiveAmountPor { get; set; } 
        public IRPSCheckbox<RecalculateCostChildDialogView> OnlyArticlesPor { get; set; } 
        public IRPSCheckbox<RecalculateCostChildDialogView> ChkImportCost { get; set; } 
        public IRPSOption<RecalculateCostChildDialogView> Porcent1 { get; set; } 
        public IRPSOption<RecalculateCostChildDialogView> Amount1 { get; set; } 
        public IRPSTextBox<RecalculateCostChildDialogView> ImportCostQuantity { get; set; } 
        public IRPSOption<RecalculateCostChildDialogView> LineAmount1 { get; set; } 
        public IRPSOption<RecalculateCostChildDialogView> Quantity1 { get; set; } 
        public IRPSOption<RecalculateCostChildDialogView> NetWeight1 { get; set; } 
        public IRPSOption<RecalculateCostChildDialogView> GrossWeight1 { get; set; } 
        public IRPSCheckbox<RecalculateCostChildDialogView> PositiveAmountImpor { get; set; } 
        public IRPSCheckbox<RecalculateCostChildDialogView> OnlyArticlesImpor { get; set; } 
        public IRPSCheckbox<RecalculateCostChildDialogView> ChkTariffCost { get; set; } 
        public IRPSOption<RecalculateCostChildDialogView> Porcent2 { get; set; } 
        public IRPSOption<RecalculateCostChildDialogView> Amount2 { get; set; } 
        public IRPSTextBox<RecalculateCostChildDialogView> TariffCostQuantity { get; set; } 
        public IRPSOption<RecalculateCostChildDialogView> LineAmount2 { get; set; } 
        public IRPSOption<RecalculateCostChildDialogView> Quantity2 { get; set; } 
        public IRPSOption<RecalculateCostChildDialogView> NetWeight2 { get; set; } 
        public IRPSOption<RecalculateCostChildDialogView> GrossWeight2 { get; set; } 
        public IRPSCheckbox<RecalculateCostChildDialogView> PositiveAmountTarif { get; set; } 
        public IRPSCheckbox<RecalculateCostChildDialogView> OnlyArticlesTarif { get; set; } 
        public InvoiceFromDeliveryNote Screen { get; set; }
        public RecalculateCostChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class RecalculateIntrastatChildDialogView : View
    {
        public RecalculateIntrastatChildDialogView(InvoiceFromDeliveryNote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<RecalculateIntrastatChildDialogView>("7f956b92-f03e-4b20-b644-d9bba1585f64","","",false, this);
 

        }
        public IRPSTextBox<RecalculateIntrastatChildDialogView> Amount { get; set; } 
        public InvoiceFromDeliveryNote Screen { get; set; }
        public RecalculateIntrastatChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NewFromSalesDialogView : View
    {
        public NewFromSalesDialogView(InvoiceFromDeliveryNote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CodCompanySales = RPSControlFactory.CreateRPSComboBox<NewFromSalesDialogView>("a476a07b-7fe0-4958-883b-0b8650ac50fd","","",false, this);
 
            IDInvoiceSL = RPSControlFactory.CreateRPSComboBox<NewFromSalesDialogView>("3a56c0f9-25a5-4cba-b1c7-1386f1714cf8","","",false, this);
 
            InvoiceDate = RPSControlFactory.CreateRPSTextBox<NewFromSalesDialogView>("d429a702-ef5e-402b-9565-7c41dd40a15f","","",false, this);
 

        }
        public IRPSComboBox<NewFromSalesDialogView> CodCompanySales { get; set; } 
        public IRPSComboBox<NewFromSalesDialogView> IDInvoiceSL { get; set; } 
        public IRPSTextBox<NewFromSalesDialogView> InvoiceDate { get; set; } 
        public InvoiceFromDeliveryNote Screen { get; set; }
        public NewFromSalesDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class AddNewLineDirectDialogView : View
    {
        public AddNewLineDirectDialogView(InvoiceFromDeliveryNote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSComboBox<AddNewLineDirectDialogView>("3ece0390-d3b1-4cf1-819f-1a19d2424dda","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<AddNewLineDirectDialogView>("925249b7-e3b0-41a7-b549-602bd8d382f4","","",true, this);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSComboBox<AddNewLineDirectDialogView>("ac9dd41f-8249-4150-91dc-7ef523485e8b","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<AddNewLineDirectDialogView>("95f40f5f-87ab-4d4b-aff8-acff6918bac3","","",false, this);
 
            OptionAutomatic = RPSControlFactory.CreateRPSOption<AddNewLineDirectDialogView>( "6edc416a-d1bd-458a-a040-5cdd6ee0edf7","","",this);
 
            Manual = RPSControlFactory.CreateRPSOption<AddNewLineDirectDialogView>( "da9d816d-e165-4981-8ae4-c5644930de92","","",this);
 
            Price = RPSControlFactory.CreateRPSFormattedTextBox<AddNewLineDirectDialogView>("e8246168-a951-47db-8325-f1053878d2b6","","",true, this);
 
            IDUnitPrice = RPSControlFactory.CreateRPSComboBox<AddNewLineDirectDialogView>("c1c6504e-3486-44b5-9f91-c4c7289d5291","","",false, this);
 

        }
        public IRPSComboBox<AddNewLineDirectDialogView> IDArticle { get; set; } 
        public IRPSTextBox<AddNewLineDirectDialogView> Quantity { get; set; } 
        public IRPSComboBox<AddNewLineDirectDialogView> IDUnitQuantity { get; set; } 
        public IRPSTextBox<AddNewLineDirectDialogView> Description { get; set; } 
        public IRPSOption<AddNewLineDirectDialogView> OptionAutomatic { get; set; } 
        public IRPSOption<AddNewLineDirectDialogView> Manual { get; set; } 
        public IRPSTextBox<AddNewLineDirectDialogView> Price { get; set; } 
        public IRPSComboBox<AddNewLineDirectDialogView> IDUnitPrice { get; set; } 
        public InvoiceFromDeliveryNote Screen { get; set; }
        public AddNewLineDirectDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class AnalyticChildDialogView : View
    {
        public AnalyticChildDialogView(InvoiceFromDeliveryNote screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDAccount = RPSControlFactory.CreateRPSComboBox<AnalyticChildDialogView>("ae727f07-af37-43f8-a4ee-2139ee431c39","","",false, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<AnalyticChildDialogView>("c25edd4c-6750-4123-aa87-304faa3a25bf","","",true, this);
 
            GetDimensionChildCommandButton = RPSControlFactory.CreateRPSButton<AnalyticChildDialogView>( "b02cd663-e8d8-4192-b5da-33e3f52a9209","","",this);
 
            CollectionInit params_InvoiceLineAnalytics = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b5454708-ceb3-42f1-83e2-d9e825770651",CSSSelectorGrid="",XPathGrid=""};
            InvoiceLineAnalytics = RPSControlFactory.RPSCreateCollectionWithGrid<InvoiceLineAnalyticsCollectionEditor<AnalyticChildDialogView>,AnalyticChildDialogView>( params_InvoiceLineAnalytics,this);
 

        }
        public IRPSComboBox<AnalyticChildDialogView> IDAccount { get; set; } 
        public IRPSTextBox<AnalyticChildDialogView> Amount { get; set; } 
        public IRPSButton<AnalyticChildDialogView> GetDimensionChildCommandButton { get; set; } 
        public InvoiceLineAnalyticsCollectionEditor<AnalyticChildDialogView> InvoiceLineAnalytics { get; set; } 
        public InvoiceFromDeliveryNote Screen { get; set; }
        public AnalyticChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class InvoiceLineAnalyticsCollectionEditor<AnalyticChildDialogView>:RPSCollectionEditor<AnalyticChildDialogView> where AnalyticChildDialogView : class, IView
    {
        public  InvoiceLineAnalyticsGridView<AnalyticChildDialogView> GridView {get;set;}
    }
    public partial class InvoiceLineAnalyticsGridView <AnalyticChildDialogView> :  RPSGridView<AnalyticChildDialogView> where AnalyticChildDialogView : class, IView
    {
        public InvoiceLineAnalyticsGridView(AnalyticChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDDimension = RPSControlFactory.CreateRPSGridComboBox<AnalyticChildDialogView>("","#b5454708-ceb3-42f1-83e2-d9e825770651 .ag-row[role='row']@ROWINDEX [col-id='cIDDimension']","",true, this.CurrentView);
 
            IDDimValue = RPSControlFactory.CreateRPSGridComboBox<AnalyticChildDialogView>("","#b5454708-ceb3-42f1-83e2-d9e825770651 .ag-row[role='row']@ROWINDEX [col-id='cIDDimValue']","",true, this.CurrentView);
 
            Percentage = RPSControlFactory.CreateRPSGridFormattedTextBox<AnalyticChildDialogView>("","#b5454708-ceb3-42f1-83e2-d9e825770651 .ag-row[role='row']@ROWINDEX [col-id='cPercentage']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<AnalyticChildDialogView>("","#b5454708-ceb3-42f1-83e2-d9e825770651 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<AnalyticChildDialogView> IDDimension { get; set; } 
        public IRPSGridComboBox<AnalyticChildDialogView> IDDimValue { get; set; } 
        public IRPSGridTextBox<AnalyticChildDialogView> Percentage { get; set; } 
        public IRPSGridTextBox<AnalyticChildDialogView> Amount { get; set; } 
                     
    }
 
    }
  
    

}