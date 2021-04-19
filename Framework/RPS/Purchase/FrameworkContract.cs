    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.FrameworkContract
{
    //RPS VERSION 1.0.0.0
    public partial class FrameworkContract:Screen
    {
        public FrameworkContract():base()
        {
            this.URL = "purchase.frameworkcontract";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            FrameworkContractCollectionView  = new FrameworkContractCollectionView(this); 
            FrameworkContractEntityView  = new FrameworkContractEntityView(this); 
            FrameworkContractLineView  = new FrameworkContractLineView(this); 
            FrameworkContractCopyChildDialogView  = new FrameworkContractCopyChildDialogView(this); 
            FrameworkContractChangeSupplierDialogView  = new FrameworkContractChangeSupplierDialogView(this); 
            FrameworkContractPrintDialogView  = new FrameworkContractPrintDialogView(this); 
            FrameworkContractCollectionView.InitializeControls(); 
            FrameworkContractEntityView.InitializeControls(); 
            FrameworkContractLineView.InitializeControls(); 
            FrameworkContractCopyChildDialogView.InitializeControls(); 
            FrameworkContractChangeSupplierDialogView.InitializeControls(); 
            FrameworkContractPrintDialogView.InitializeControls(); 
           
        }
      
            public FrameworkContractCollectionView FrameworkContractCollectionView {get; set; } 
            public FrameworkContractEntityView FrameworkContractEntityView {get; set; } 
            public FrameworkContractLineView FrameworkContractLineView {get; set; } 
            public FrameworkContractCopyChildDialogView FrameworkContractCopyChildDialogView {get; set; } 
            public FrameworkContractChangeSupplierDialogView FrameworkContractChangeSupplierDialogView {get; set; } 
            public FrameworkContractPrintDialogView FrameworkContractPrintDialogView {get; set; } 
    }
            
    public partial class FrameworkContractCollectionView : View
    {
        public FrameworkContractCollectionView(FrameworkContract screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<FrameworkContractCollectionView,FrameworkContractEntityView>( this,Screen.FrameworkContractEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "161519d4-535c-4eda-bc01-342b5a160d1e",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<FrameworkContractCollectionView,FrameworkContractEntityView>( params_MainConsult,this,Screen.FrameworkContractEntityView);
 

        }
        public IRPSButton<FrameworkContractCollectionView,FrameworkContractEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<FrameworkContractCollectionView,FrameworkContractEntityView> MainConsult { get; set; } 
        public FrameworkContract Screen { get; set; }
        public FrameworkContractCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FrameworkContractEntityView : View
    {
        public FrameworkContractEntityView(FrameworkContract screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<FrameworkContractEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<FrameworkContractEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FrameworkContractEntityView,FrameworkContractCollectionView>( this,Screen.FrameworkContractCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<FrameworkContractEntityView,FrameworkContractCollectionView>( this,Screen.FrameworkContractCollectionView);
 
            CodFrameworkContract = RPSControlFactory.CreateRPSTextBox<FrameworkContractEntityView>("810c48b0-1804-4e74-b43a-5ee85c35cae9","","",true, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<FrameworkContractEntityView>("64d2e839-20f9-4f65-a073-7f73e2a90cf2","","",false, this);
 
            IDSupplierContact = RPSControlFactory.CreateRPSComboBox<FrameworkContractEntityView>("4e00de40-4d76-4c03-9908-6b8057543561","","",false, this);
 
            IDFrameworkContractStatus = RPSControlFactory.CreateRPSComboBox<FrameworkContractEntityView>("c008d272-ba77-4ca3-b31e-de6e4425cc5b","","",true, this);
 
            FrameworkContractDate = RPSControlFactory.CreateRPSTextBox<FrameworkContractEntityView>("be7f41cd-a6fd-4017-8547-270be919a3cc","","",true, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<FrameworkContractEntityView>("6b6157ab-b1e1-4fcc-9f07-bd25c773daff","","",true, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<FrameworkContractEntityView>("f8eb53ae-ef5b-42cc-8b78-1d40b0896f48","","",true, this);
 
            LimitedQuantity = RPSControlFactory.CreateRPSCheckBox<FrameworkContractEntityView>("a7034987-11b6-4119-ab92-675cb6b09393","","",true, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<FrameworkContractEntityView>("d59f8ca2-72ed-406f-8e0b-40a8fa3bb374","","",true, this);
 
            IDPaymentMethod = RPSControlFactory.CreateRPSComboBox<FrameworkContractEntityView>("622d4441-e2e5-46c5-8bd2-d213e400f3f6","","",false, this);
 
            IDBusinessUnit = RPSControlFactory.CreateRPSComboBox<FrameworkContractEntityView>("006856cd-b936-4420-aac8-b2ef4a7228ab","","",false, this);
 
            IDDeliveryAddress = RPSControlFactory.CreateRPSComboBox<FrameworkContractEntityView>("0ba62a98-028c-4d40-a75d-7640f3a080e1","","",false, this);
 
            IDVATType = RPSControlFactory.CreateRPSComboBox<FrameworkContractEntityView>("e60d1ebc-87cc-43a0-b8f9-f5b579c7f221","","",true, this);
 
            IDSurchargeVATType = RPSControlFactory.CreateRPSComboBox<FrameworkContractEntityView>("9f53953b-c7e0-4beb-a1cf-1c50f3c7707b","","",false, this);
 
            IDSupplierRequestQuotation = RPSControlFactory.CreateRPSComboBox<FrameworkContractEntityView>("5a454722-f4d7-4275-becf-5b1f9796ab68","","",false, this);
 
            IDSupplierOrderAddress = RPSControlFactory.CreateRPSComboBox<FrameworkContractEntityView>("3d2270c4-382e-418d-a42a-388747c153d9","","",false, this);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<FrameworkContractEntityView>("9bfc44af-e13c-43fa-b024-c757a1c73193","","",false, this);
 
            TotalFrameworkContract = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractEntityView>("f9c56014-d8ca-4ee0-b017-2dfc1c7d7876","","",false, this);
 
            VATAmount = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractEntityView>("e9898d08-94ef-45e5-b65f-69bb7349cfa4","","",false, this);
 
            VATBaseAmount = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractEntityView>("cf1b6ea8-4b64-441b-bbf6-08496a11f90c","","",false, this);
 
            TotalLinesAmount = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractEntityView>("029056b1-37d2-4673-a045-929575ed998c","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<FrameworkContractEntityView>("44d6ef2c-706b-4def-a26c-804f9ad05483","","",false, this);
 
            CommentsSend = RPSControlFactory.CreateRPSTextBox<FrameworkContractEntityView>("b1f52b3c-d049-45db-8aa2-77c9927df905","","",false, this);
 
            PreTextIDTextLine = RPSControlFactory.CreateRPSComboBox<FrameworkContractEntityView>("a1816001-0c83-4366-a757-72c24bdda17e","","",false, this);
 
            PreText = RPSControlFactory.CreateRPSTextBox<FrameworkContractEntityView>("c547a7c7-01c3-45d5-8aee-619e94f616d4","","",false, this);
 
            PostTextIDTextLine = RPSControlFactory.CreateRPSComboBox<FrameworkContractEntityView>("4dcf6b16-744c-4e11-ba9a-f42fdd418c5a","","",false, this);
 
            PostText = RPSControlFactory.CreateRPSTextBox<FrameworkContractEntityView>("6a1ae3f6-1b18-4dbb-b07a-d78cbe5517f1","","",false, this);
 
            FrameworkContractPrintNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<FrameworkContractEntityView,FrameworkContractPrintDialogView>("aec1a1ed-447f-4aac-b5d3-e5417527de54","","", this,Screen.FrameworkContractPrintDialogView);
 
            FrameworkContractCopyChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<FrameworkContractEntityView,FrameworkContractCopyChildDialogView>("5a9e223a-47f7-4a43-890f-56b7491e46e4","","", this,Screen.FrameworkContractCopyChildDialogView);
 
            FrameworkContractChangeSupplierNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<FrameworkContractEntityView,FrameworkContractChangeSupplierDialogView>("1e33f2bd-f1cb-4322-8f7b-d57c5ef0789d","","", this,Screen.FrameworkContractChangeSupplierDialogView);
 
            TotalsUpdateButton = RPSControlFactory.CreateRPSButton<FrameworkContractEntityView>( "858f1b67-6192-4101-b195-27bad19ed9bc","","",this);
 
            CollectionInit params_FrameworkContractLines = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="bac3bd31-1932-4f69-8af0-51bd86f65e7b",CSSSelectorGrid="",XPathGrid=""};
            FrameworkContractLines = RPSControlFactory.RPSCreateCollectionWithGrid<FrameworkContractLinesCollectionEditor<FrameworkContractEntityView,FrameworkContractLineView>,FrameworkContractEntityView,FrameworkContractLineView>( params_FrameworkContractLines,this,Screen.FrameworkContractLineView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<FrameworkContractEntityView>( "","ul li[rpsid='0035d9ef-2fd0-4030-a8e9-42f6b3d81eca']","",this);
 
            Lines = RPSControlFactory.CreateRPSSection<FrameworkContractEntityView>( "","ul li[rpsid='002f4199-4f80-4e6e-81a4-46bd41657346']","",this);
 
            Comments = RPSControlFactory.CreateRPSSection<FrameworkContractEntityView>( "","ul li[rpsid='519e87fd-c8d7-424c-ab2b-446a28383d63']","",this);
 
            TextLine = RPSControlFactory.CreateRPSSection<FrameworkContractEntityView>( "","ul li[rpsid='dcf5cd20-55bf-4a0f-9e7b-0151976ff61e']","",this);
 

        }
        public IRPSSaveButton<FrameworkContractEntityView> SaveButton { get; set; } 
        public IRPSButton<FrameworkContractEntityView> DeleteButton { get; set; } 
        public IRPSButton<FrameworkContractEntityView,FrameworkContractCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FrameworkContractEntityView,FrameworkContractCollectionView> BackButton { get; set; } 
        public IRPSTextBox<FrameworkContractEntityView> CodFrameworkContract { get; set; } 
        public IRPSComboBox<FrameworkContractEntityView> IDSupplier { get; set; } 
        public IRPSComboBox<FrameworkContractEntityView> IDSupplierContact { get; set; } 
        public IRPSComboBox<FrameworkContractEntityView> IDFrameworkContractStatus { get; set; } 
        public IRPSTextBox<FrameworkContractEntityView> FrameworkContractDate { get; set; } 
        public IRPSTextBox<FrameworkContractEntityView> DateFrom { get; set; } 
        public IRPSTextBox<FrameworkContractEntityView> DateTo { get; set; } 
        public IRPSCheckbox<FrameworkContractEntityView> LimitedQuantity { get; set; } 
        public IRPSComboBox<FrameworkContractEntityView> IDCurrency { get; set; } 
        public IRPSComboBox<FrameworkContractEntityView> IDPaymentMethod { get; set; } 
        public IRPSComboBox<FrameworkContractEntityView> IDBusinessUnit { get; set; } 
        public IRPSComboBox<FrameworkContractEntityView> IDDeliveryAddress { get; set; } 
        public IRPSComboBox<FrameworkContractEntityView> IDVATType { get; set; } 
        public IRPSComboBox<FrameworkContractEntityView> IDSurchargeVATType { get; set; } 
        public IRPSComboBox<FrameworkContractEntityView> IDSupplierRequestQuotation { get; set; } 
        public IRPSComboBox<FrameworkContractEntityView> IDSupplierOrderAddress { get; set; } 
        public IRPSComboBox<FrameworkContractEntityView> IDEmployee { get; set; } 
        public IRPSTextBox<FrameworkContractEntityView> TotalFrameworkContract { get; set; } 
        public IRPSTextBox<FrameworkContractEntityView> VATAmount { get; set; } 
        public IRPSTextBox<FrameworkContractEntityView> VATBaseAmount { get; set; } 
        public IRPSTextBox<FrameworkContractEntityView> TotalLinesAmount { get; set; } 
        public IRPSTextBox<FrameworkContractEntityView> Comment { get; set; } 
        public IRPSTextBox<FrameworkContractEntityView> CommentsSend { get; set; } 
        public IRPSComboBox<FrameworkContractEntityView> PreTextIDTextLine { get; set; } 
        public IRPSTextBox<FrameworkContractEntityView> PreText { get; set; } 
        public IRPSComboBox<FrameworkContractEntityView> PostTextIDTextLine { get; set; } 
        public IRPSTextBox<FrameworkContractEntityView> PostText { get; set; } 
        public IRPSButton<FrameworkContractEntityView,FrameworkContractPrintDialogView> FrameworkContractPrintNavigationCommandButton { get; set; } 
        public IRPSButton<FrameworkContractEntityView,FrameworkContractCopyChildDialogView> FrameworkContractCopyChildNavigationCommandButton { get; set; } 
        public IRPSButton<FrameworkContractEntityView,FrameworkContractChangeSupplierDialogView> FrameworkContractChangeSupplierNavigationCommandButton { get; set; } 
        public IRPSButton<FrameworkContractEntityView> TotalsUpdateButton { get; set; } 
        public FrameworkContractLinesCollectionEditor<FrameworkContractEntityView,FrameworkContractLineView> FrameworkContractLines { get; set; } 
        public IRPSSection<FrameworkContractEntityView> GeneralData { get; set; } 
        public IRPSSection<FrameworkContractEntityView> Lines { get; set; } 
        public IRPSSection<FrameworkContractEntityView> Comments { get; set; } 
        public IRPSSection<FrameworkContractEntityView> TextLine { get; set; } 
        public FrameworkContract Screen { get; set; }
        public FrameworkContractEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class FrameworkContractLinesCollectionEditor<FrameworkContractEntityView,FrameworkContractLineView>:RPSCollectionEditor<FrameworkContractEntityView,FrameworkContractLineView> where FrameworkContractEntityView : class, IView where FrameworkContractLineView : class, IView
    {
        public  FrameworkContractLinesGridView<FrameworkContractEntityView,FrameworkContractLineView> GridView {get;set;}
    }
    public partial class FrameworkContractLinesGridView <FrameworkContractEntityView,FrameworkContractLineView> :  RPSGridView<FrameworkContractEntityView,FrameworkContractLineView> where FrameworkContractEntityView : class, IView where FrameworkContractLineView : class, IView
    {
        public FrameworkContractLinesGridView(FrameworkContractEntityView currentView,FrameworkContractLineView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Ordenation = RPSControlFactory.CreateRPSGridFormattedTextBox<FrameworkContractEntityView>("","#bac3bd31-1932-4f69-8af0-51bd86f65e7b .ag-row[role='row']@ROWINDEX [col-id='cOrdenation']","",true, this.CurrentView);
 
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<FrameworkContractEntityView>("","#bac3bd31-1932-4f69-8af0-51bd86f65e7b .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<FrameworkContractEntityView>("","#bac3bd31-1932-4f69-8af0-51bd86f65e7b .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<FrameworkContractEntityView>("","#bac3bd31-1932-4f69-8af0-51bd86f65e7b .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            OrderQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<FrameworkContractEntityView>("","#bac3bd31-1932-4f69-8af0-51bd86f65e7b .ag-row[role='row']@ROWINDEX [col-id='cOrderQuantity']","",true, this.CurrentView);
 
            Price = RPSControlFactory.CreateRPSGridFormattedTextBox<FrameworkContractEntityView>("","#bac3bd31-1932-4f69-8af0-51bd86f65e7b .ag-row[role='row']@ROWINDEX [col-id='cPrice']","",true, this.CurrentView);
 
            PercentVAT = RPSControlFactory.CreateRPSGridFormattedTextBox<FrameworkContractEntityView>("","#bac3bd31-1932-4f69-8af0-51bd86f65e7b .ag-row[role='row']@ROWINDEX [col-id='cPercentVAT']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<FrameworkContractEntityView>("","#bac3bd31-1932-4f69-8af0-51bd86f65e7b .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            AmountWithVAT = RPSControlFactory.CreateRPSGridFormattedTextBox<FrameworkContractEntityView>("","#bac3bd31-1932-4f69-8af0-51bd86f65e7b .ag-row[role='row']@ROWINDEX [col-id='cAmountWithVAT']","",true, this.CurrentView);
 
            IDSite = RPSControlFactory.CreateRPSGridComboBox<FrameworkContractEntityView>("","#bac3bd31-1932-4f69-8af0-51bd86f65e7b .ag-row[role='row']@ROWINDEX [col-id='cIDSite']","",false, this.CurrentView);
 
            IDWarehouse = RPSControlFactory.CreateRPSGridComboBox<FrameworkContractEntityView>("","#bac3bd31-1932-4f69-8af0-51bd86f65e7b .ag-row[role='row']@ROWINDEX [col-id='cIDWarehouse']","",false, this.CurrentView);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSGridComboBox<FrameworkContractEntityView>("","#bac3bd31-1932-4f69-8af0-51bd86f65e7b .ag-row[role='row']@ROWINDEX [col-id='cIDDeliveryNoteType']","",false, this.CurrentView);
 
            OpenQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<FrameworkContractEntityView>("","#bac3bd31-1932-4f69-8af0-51bd86f65e7b .ag-row[role='row']@ROWINDEX [col-id='cOpenQuantity']","",true, this.CurrentView);
 
            NumberOfPurchaseOrdersOpen = RPSControlFactory.CreateRPSGridFormattedTextBox<FrameworkContractEntityView>("","#bac3bd31-1932-4f69-8af0-51bd86f65e7b .ag-row[role='row']@ROWINDEX [col-id='cNumberOfPurchaseOrdersOpen']","",true, this.CurrentView);
 
            IDArticleStructure = RPSControlFactory.CreateRPSGridComboBox<FrameworkContractEntityView>("","#bac3bd31-1932-4f69-8af0-51bd86f65e7b .ag-row[role='row']@ROWINDEX [col-id='cIDArticleStructure']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<FrameworkContractEntityView> Ordenation { get; set; } 
        public IRPSGridComboBox<FrameworkContractEntityView> IDArticle { get; set; } 
        public IRPSGridTextBox<FrameworkContractEntityView> Description { get; set; } 
        public IRPSGridTextBox<FrameworkContractEntityView> Quantity { get; set; } 
        public IRPSGridTextBox<FrameworkContractEntityView> OrderQuantity { get; set; } 
        public IRPSGridTextBox<FrameworkContractEntityView> Price { get; set; } 
        public IRPSGridTextBox<FrameworkContractEntityView> PercentVAT { get; set; } 
        public IRPSGridTextBox<FrameworkContractEntityView> Amount { get; set; } 
        public IRPSGridTextBox<FrameworkContractEntityView> AmountWithVAT { get; set; } 
        public IRPSGridComboBox<FrameworkContractEntityView> IDSite { get; set; } 
        public IRPSGridComboBox<FrameworkContractEntityView> IDWarehouse { get; set; } 
        public IRPSGridComboBox<FrameworkContractEntityView> IDDeliveryNoteType { get; set; } 
        public IRPSGridTextBox<FrameworkContractEntityView> OpenQuantity { get; set; } 
        public IRPSGridTextBox<FrameworkContractEntityView> NumberOfPurchaseOrdersOpen { get; set; } 
        public IRPSGridComboBox<FrameworkContractEntityView> IDArticleStructure { get; set; } 
                     
    }
 
    }
  
            
    public partial class FrameworkContractLineView : View
    {
        public FrameworkContractLineView(FrameworkContract screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<FrameworkContractLineView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<FrameworkContractLineView,FrameworkContractEntityView>( this,Screen.FrameworkContractEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<FrameworkContractLineView,FrameworkContractEntityView>( this,Screen.FrameworkContractEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<FrameworkContractLineView,FrameworkContractEntityView>( this,Screen.FrameworkContractEntityView);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<FrameworkContractLineView>("42034c29-425d-4d25-adf4-6336d907114a","","",true, this);
 
            ReferenceSupplier = RPSControlFactory.CreateRPSEnumComboBox<FrameworkContractLineView>("971d1473-dc87-4820-99eb-8a0e3efbf275","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractLineView>("0b7d28e2-3407-4e66-a27c-c8c21d572ae3","","",true, this);
 
            Price = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractLineView>("ced1becd-b611-4fbf-ae3e-8528d5c9ac4c","","",true, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractLineView>("704292d4-dce0-4c1a-98a7-fc6025a29735","","",true, this);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSComboBox<FrameworkContractLineView>("f874265d-7f3d-489d-a2f6-20774bc84e42","","",true, this);
 
            IDUnitPrice = RPSControlFactory.CreateRPSComboBox<FrameworkContractLineView>("bd184bcb-a105-4618-9b0b-83a13fb010de","","",true, this);
 
            ConversionFactorPrice = RPSControlFactory.CreateRPSTextBox<FrameworkContractLineView>("42cb2d61-a79d-417c-9a54-624e6eff5a65","","",true, this);
 
            VAT = RPSControlFactory.CreateRPSCheckBox<FrameworkContractLineView>("85217ebe-24d4-4a69-8cc8-55228e894084","","",true, this);
 
            AmountWithVAT = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractLineView>("0cf4e7f3-e344-478d-8234-9a736eba1b9b","","",true, this);
 
            IDArticleStructure = RPSControlFactory.CreateRPSComboBox<FrameworkContractLineView>("b1af8b0d-9ed8-4402-b6da-6000ebf0c10a","","",false, this);
 
            Discount1 = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractLineView>("ba37d7d2-8684-40c4-8254-46393b63e48e","","",true, this);
 
            CascadeDiscount1 = RPSControlFactory.CreateRPSCheckBox<FrameworkContractLineView>("aa89f873-c162-4a4a-89aa-3a49de305c51","","",true, this);
 
            Discount2 = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractLineView>("8018f3ac-cd91-4c3a-b2ce-92f7b2e0e1e9","","",true, this);
 
            CascadeDiscount2 = RPSControlFactory.CreateRPSCheckBox<FrameworkContractLineView>("c2833576-f05d-4fd9-aebe-1d36f403ae2d","","",true, this);
 
            Discount3 = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractLineView>("c4f659f3-fd90-40fb-8fb8-f88adc28562d","","",true, this);
 
            CascadeDiscount3 = RPSControlFactory.CreateRPSCheckBox<FrameworkContractLineView>("0f7a718d-eb21-4da6-b4c7-2d5807b8525e","","",true, this);
 
            Discount4 = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractLineView>("8338f7e3-e514-4492-ab4b-15f2ebe76eed","","",true, this);
 
            CascadeDiscount4 = RPSControlFactory.CreateRPSCheckBox<FrameworkContractLineView>("4debd4c3-23e3-4ebf-a829-f015a684fbd5","","",true, this);
 
            Discount5 = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractLineView>("a9a52ba1-1ada-450b-8227-f68f675508a6","","",true, this);
 
            CascadeDiscount5 = RPSControlFactory.CreateRPSCheckBox<FrameworkContractLineView>("30423f31-0f29-4316-b6bc-bb21ffc78c57","","",true, this);
 
            PositionAmountDiscount = RPSControlFactory.CreateRPSEnumComboBox<FrameworkContractLineView>("c5084240-6252-4d41-89c1-ceccc396be90","","",true, this);
 
            AmountDiscount = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractLineView>("da20f9af-92e6-47ae-ae30-077620d171fc","","",true, this);
 
            IDVAT = RPSControlFactory.CreateRPSComboBox<FrameworkContractLineView>("1dea0d49-489c-495f-96e8-325472d3d205","","",true, this);
 
            PercentVAT = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractLineView>("f2892f99-3fa8-4990-83e3-78fb69ebd5f6","","",true, this);
 
            VAT1 = RPSControlFactory.CreateRPSCheckBox<FrameworkContractLineView>("380f5f79-0a66-44e9-bf2c-a672a0eed202","","",true, this);
 
            IDVATSurcharge = RPSControlFactory.CreateRPSComboBox<FrameworkContractLineView>("68f89c5f-76ad-4c32-8165-2c1ca19c5bac","","",false, this);
 
            PercentSurcharge = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractLineView>("b194cd78-f474-4dd8-a39a-8b24c0d03bd8","","",true, this);
 
            OrderQuantity = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractLineView>("87e490d0-5705-4d88-ab78-0cacafd85a16","","",true, this);
 
            PurchaseLot = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractLineView>("f933056c-07d4-4bda-8612-81deb1e4e686","","",true, this);
 
            MinimumLot = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractLineView>("bf8f94a7-d9e0-48a9-bc1f-b6962ee770b4","","",true, this);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractLineView>("46f4da8b-36f0-4f32-92e6-ecdaf8af5fed","","",true, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<FrameworkContractLineView>("4680a566-cf04-43ca-acc5-2248c9de5652","","",false, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<FrameworkContractLineView>("b8ef9fad-432d-40ce-8eba-613d320254dc","","",false, this);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<FrameworkContractLineView>("43bd26b0-6743-4f18-9154-de7c9dfe6d59","","",false, this);
 
            OpenQuantity = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractLineView>("c81596a3-6e09-4990-971b-f8a6d1254e98","","",true, this);
 
            NumberOfPurchaseOrdersOpen = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractLineView>("b12cca07-3306-402d-aa5d-e01031b14277","","",true, this);
 
            PriceBase = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractLineView>("d552e207-eb13-48bb-8599-6609beedf9ee","","",true, this);
 
            UIconditionPrice = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractLineView>("929bb151-96f2-40ae-99a1-25e748e211e7","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<FrameworkContractLineView>("6db5f7f6-fef3-4e66-a647-27d8b2e9504f","","",false, this);
 
            CollectionInit params_FrameworkCLineConditions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8ebad077-314e-4848-be29-fc5057b62198",CSSSelectorGrid="",XPathGrid=""};
            FrameworkCLineConditions = RPSControlFactory.RPSCreateCollectionWithGrid<FrameworkCLineConditionsCollectionEditor<FrameworkContractLineView>,FrameworkContractLineView>( params_FrameworkCLineConditions,this);
 
            GeneralData = RPSControlFactory.CreateRPSSection<FrameworkContractLineView>( "","ul li[rpsid='fef14a30-6a94-4c2f-bec4-baa9c5e51de3']","",this);
 
            SpecialConditionSection = RPSControlFactory.CreateRPSSection<FrameworkContractLineView>( "","ul li[rpsid='ca4821b3-8e3d-4a8a-87f9-8106cbb3323d']","",this);
 
            Comment1 = RPSControlFactory.CreateRPSSection<FrameworkContractLineView>( "","ul li[rpsid='47fa13ad-fccd-45c3-93bf-57b72743d979']","",this);
 

        }
        public IRPSButton<FrameworkContractLineView> DeleteButton { get; set; } 
        public IRPSButton<FrameworkContractLineView,FrameworkContractEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<FrameworkContractLineView,FrameworkContractEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<FrameworkContractLineView,FrameworkContractEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<FrameworkContractLineView> IDArticle { get; set; } 
        public IRPSComboBox<FrameworkContractLineView> ReferenceSupplier { get; set; } 
        public IRPSTextBox<FrameworkContractLineView> Quantity { get; set; } 
        public IRPSTextBox<FrameworkContractLineView> Price { get; set; } 
        public IRPSTextBox<FrameworkContractLineView> Amount { get; set; } 
        public IRPSComboBox<FrameworkContractLineView> IDUnitQuantity { get; set; } 
        public IRPSComboBox<FrameworkContractLineView> IDUnitPrice { get; set; } 
        public IRPSTextBox<FrameworkContractLineView> ConversionFactorPrice { get; set; } 
        public IRPSCheckbox<FrameworkContractLineView> VAT { get; set; } 
        public IRPSTextBox<FrameworkContractLineView> AmountWithVAT { get; set; } 
        public IRPSComboBox<FrameworkContractLineView> IDArticleStructure { get; set; } 
        public IRPSTextBox<FrameworkContractLineView> Discount1 { get; set; } 
        public IRPSCheckbox<FrameworkContractLineView> CascadeDiscount1 { get; set; } 
        public IRPSTextBox<FrameworkContractLineView> Discount2 { get; set; } 
        public IRPSCheckbox<FrameworkContractLineView> CascadeDiscount2 { get; set; } 
        public IRPSTextBox<FrameworkContractLineView> Discount3 { get; set; } 
        public IRPSCheckbox<FrameworkContractLineView> CascadeDiscount3 { get; set; } 
        public IRPSTextBox<FrameworkContractLineView> Discount4 { get; set; } 
        public IRPSCheckbox<FrameworkContractLineView> CascadeDiscount4 { get; set; } 
        public IRPSTextBox<FrameworkContractLineView> Discount5 { get; set; } 
        public IRPSCheckbox<FrameworkContractLineView> CascadeDiscount5 { get; set; } 
        public IRPSComboBox<FrameworkContractLineView> PositionAmountDiscount { get; set; } 
        public IRPSTextBox<FrameworkContractLineView> AmountDiscount { get; set; } 
        public IRPSComboBox<FrameworkContractLineView> IDVAT { get; set; } 
        public IRPSTextBox<FrameworkContractLineView> PercentVAT { get; set; } 
        public IRPSCheckbox<FrameworkContractLineView> VAT1 { get; set; } 
        public IRPSComboBox<FrameworkContractLineView> IDVATSurcharge { get; set; } 
        public IRPSTextBox<FrameworkContractLineView> PercentSurcharge { get; set; } 
        public IRPSTextBox<FrameworkContractLineView> OrderQuantity { get; set; } 
        public IRPSTextBox<FrameworkContractLineView> PurchaseLot { get; set; } 
        public IRPSTextBox<FrameworkContractLineView> MinimumLot { get; set; } 
        public IRPSTextBox<FrameworkContractLineView> QuantitySecondUnit { get; set; } 
        public IRPSComboBox<FrameworkContractLineView> IDSite { get; set; } 
        public IRPSComboBox<FrameworkContractLineView> IDWarehouse { get; set; } 
        public IRPSComboBox<FrameworkContractLineView> IDDeliveryNoteType { get; set; } 
        public IRPSTextBox<FrameworkContractLineView> OpenQuantity { get; set; } 
        public IRPSTextBox<FrameworkContractLineView> NumberOfPurchaseOrdersOpen { get; set; } 
        public IRPSTextBox<FrameworkContractLineView> PriceBase { get; set; } 
        public IRPSTextBox<FrameworkContractLineView> UIconditionPrice { get; set; } 
        public IRPSTextBox<FrameworkContractLineView> Comment { get; set; } 
        public FrameworkCLineConditionsCollectionEditor<FrameworkContractLineView> FrameworkCLineConditions { get; set; } 
        public IRPSSection<FrameworkContractLineView> GeneralData { get; set; } 
        public IRPSSection<FrameworkContractLineView> SpecialConditionSection { get; set; } 
        public IRPSSection<FrameworkContractLineView> Comment1 { get; set; } 
        public FrameworkContract Screen { get; set; }
        public FrameworkContractLineView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class FrameworkCLineConditionsCollectionEditor<FrameworkContractLineView>:RPSCollectionEditor<FrameworkContractLineView> where FrameworkContractLineView : class, IView
    {
        public  FrameworkCLineConditionsGridView<FrameworkContractLineView> GridView {get;set;}
    }
    public partial class FrameworkCLineConditionsGridView <FrameworkContractLineView> :  RPSGridView<FrameworkContractLineView> where FrameworkContractLineView : class, IView
    {
        public FrameworkCLineConditionsGridView(FrameworkContractLineView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Type = RPSControlFactory.CreateRPSGridEnumComboBox<FrameworkContractLineView>("","#8ebad077-314e-4848-be29-fc5057b62198 .ag-row[role='row']@ROWINDEX [col-id='cType']","",true, this.CurrentView);
 
            ConditionValueOriginal = RPSControlFactory.CreateRPSGridFormattedTextBox<FrameworkContractLineView>("","#8ebad077-314e-4848-be29-fc5057b62198 .ag-row[role='row']@ROWINDEX [col-id='cConditionValueOriginal']","",true, this.CurrentView);
 
            ConditionValue = RPSControlFactory.CreateRPSGridFormattedTextBox<FrameworkContractLineView>("","#8ebad077-314e-4848-be29-fc5057b62198 .ag-row[role='row']@ROWINDEX [col-id='cConditionValue']","",true, this.CurrentView);
 
            Base = RPSControlFactory.CreateRPSGridFormattedTextBox<FrameworkContractLineView>("","#8ebad077-314e-4848-be29-fc5057b62198 .ag-row[role='row']@ROWINDEX [col-id='cBase']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<FrameworkContractLineView>("","#8ebad077-314e-4848-be29-fc5057b62198 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            ConditionType = RPSControlFactory.CreateRPSGridEnumComboBox<FrameworkContractLineView>("","#8ebad077-314e-4848-be29-fc5057b62198 .ag-row[role='row']@ROWINDEX [col-id='cConditionType']","",true, this.CurrentView);
 
            BaseApply = RPSControlFactory.CreateRPSGridEnumComboBox<FrameworkContractLineView>("","#8ebad077-314e-4848-be29-fc5057b62198 .ag-row[role='row']@ROWINDEX [col-id='cBaseApply']","",true, this.CurrentView);
 
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<FrameworkContractLineView>("","#8ebad077-314e-4848-be29-fc5057b62198 .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",true, this.CurrentView);
 
            DateTo = RPSControlFactory.CreateRPSGridTextBox<FrameworkContractLineView>("","#8ebad077-314e-4848-be29-fc5057b62198 .ag-row[role='row']@ROWINDEX [col-id='cDateTo']","",true, this.CurrentView);
 
            AffectsPrice = RPSControlFactory.CreateRPSGridCheckBox<FrameworkContractLineView>("","#8ebad077-314e-4848-be29-fc5057b62198 .ag-row[role='row']@ROWINDEX [col-id='cAffectsPrice']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<FrameworkContractLineView> Type { get; set; } 
        public IRPSGridTextBox<FrameworkContractLineView> ConditionValueOriginal { get; set; } 
        public IRPSGridTextBox<FrameworkContractLineView> ConditionValue { get; set; } 
        public IRPSGridTextBox<FrameworkContractLineView> Base { get; set; } 
        public IRPSGridTextBox<FrameworkContractLineView> Amount { get; set; } 
        public IRPSGridComboBox<FrameworkContractLineView> ConditionType { get; set; } 
        public IRPSGridComboBox<FrameworkContractLineView> BaseApply { get; set; } 
        public IRPSGridTextBox<FrameworkContractLineView> DateFrom { get; set; } 
        public IRPSGridTextBox<FrameworkContractLineView> DateTo { get; set; } 
        public IRPSGridCheckbox<FrameworkContractLineView> AffectsPrice { get; set; } 
                     
    }
 
    }
  
            
    public partial class FrameworkContractCopyChildDialogView : View
    {
        public FrameworkContractCopyChildDialogView(FrameworkContract screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDSelectedOriginFrameworkContract = RPSControlFactory.CreateRPSComboBox<FrameworkContractCopyChildDialogView>("01bbbf89-2502-4f81-a5ca-09004652ec4f","","",false, this);
 
            UINewCodFrameworkContract = RPSControlFactory.CreateRPSTextBox<FrameworkContractCopyChildDialogView>("604d717f-4e2c-4193-a0b5-49c1692019e4","","",false, this);
 
            IDSelectedSupplier = RPSControlFactory.CreateRPSComboBox<FrameworkContractCopyChildDialogView>("fec710b4-b904-4068-b0d0-b816dcc40434","","",true, this);
 
            SelectedDate = RPSControlFactory.CreateRPSTextBox<FrameworkContractCopyChildDialogView>("cca71dcc-ce37-4e79-a74c-0da5048121be","","",true, this);
 
            SelectedDateFrom = RPSControlFactory.CreateRPSTextBox<FrameworkContractCopyChildDialogView>("8037bcf8-5598-4864-ae6a-1bd21948511d","","",true, this);
 
            SelectedDateTo = RPSControlFactory.CreateRPSTextBox<FrameworkContractCopyChildDialogView>("946a6bad-6bf3-4c1d-8833-a5c940982ba6","","",true, this);
 
            SelectedHeaderRecalc = RPSControlFactory.CreateRPSCheckBox<FrameworkContractCopyChildDialogView>("d97fe7de-a593-4b0e-a36d-497bba3771dc","","",false, this);
 
            SelectedLinesRecalc = RPSControlFactory.CreateRPSCheckBox<FrameworkContractCopyChildDialogView>("30c9b03c-2786-4b2e-86e9-023e2d3b7140","","",false, this);
 
            CopyDocuments = RPSControlFactory.CreateRPSCheckBox<FrameworkContractCopyChildDialogView>("8cabf85b-e9b9-4a85-9f1f-ffe5c5b4c542","","",false, this);
 

        }
        public IRPSComboBox<FrameworkContractCopyChildDialogView> IDSelectedOriginFrameworkContract { get; set; } 
        public IRPSTextBox<FrameworkContractCopyChildDialogView> UINewCodFrameworkContract { get; set; } 
        public IRPSComboBox<FrameworkContractCopyChildDialogView> IDSelectedSupplier { get; set; } 
        public IRPSTextBox<FrameworkContractCopyChildDialogView> SelectedDate { get; set; } 
        public IRPSTextBox<FrameworkContractCopyChildDialogView> SelectedDateFrom { get; set; } 
        public IRPSTextBox<FrameworkContractCopyChildDialogView> SelectedDateTo { get; set; } 
        public IRPSCheckbox<FrameworkContractCopyChildDialogView> SelectedHeaderRecalc { get; set; } 
        public IRPSCheckbox<FrameworkContractCopyChildDialogView> SelectedLinesRecalc { get; set; } 
        public IRPSCheckbox<FrameworkContractCopyChildDialogView> CopyDocuments { get; set; } 
        public FrameworkContract Screen { get; set; }
        public FrameworkContractCopyChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FrameworkContractChangeSupplierDialogView : View
    {
        public FrameworkContractChangeSupplierDialogView(FrameworkContract screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDSupplier = RPSControlFactory.CreateRPSComboBox<FrameworkContractChangeSupplierDialogView>("8a2e5297-3854-40be-9e67-a6eaca582358","","",false, this);
 
            CurrentSupplierVATNumber = RPSControlFactory.CreateRPSTextBox<FrameworkContractChangeSupplierDialogView>("77e86804-ca17-416e-b173-549c488d97da","","",false, this);
 
            IDSelectedSupplier = RPSControlFactory.CreateRPSComboBox<FrameworkContractChangeSupplierDialogView>("a6c6b6bb-985c-4c10-93b0-f3b1c3584d9f","","",false, this);
 
            SelectedHeaderRecalc = RPSControlFactory.CreateRPSCheckBox<FrameworkContractChangeSupplierDialogView>("e0211a6d-bd1d-4ee4-b3b3-a4a0a930f3db","","",false, this);
 
            VATNumber = RPSControlFactory.CreateRPSTextBox<FrameworkContractChangeSupplierDialogView>("b63fdff7-e1bf-430d-88cb-e4b7fe4a98b0","","",false, this);
 

        }
        public IRPSComboBox<FrameworkContractChangeSupplierDialogView> IDSupplier { get; set; } 
        public IRPSTextBox<FrameworkContractChangeSupplierDialogView> CurrentSupplierVATNumber { get; set; } 
        public IRPSComboBox<FrameworkContractChangeSupplierDialogView> IDSelectedSupplier { get; set; } 
        public IRPSCheckbox<FrameworkContractChangeSupplierDialogView> SelectedHeaderRecalc { get; set; } 
        public IRPSTextBox<FrameworkContractChangeSupplierDialogView> VATNumber { get; set; } 
        public FrameworkContract Screen { get; set; }
        public FrameworkContractChangeSupplierDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FrameworkContractPrintDialogView : View
    {
        public FrameworkContractPrintDialogView(FrameworkContract screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SupplierLanguage = RPSControlFactory.CreateRPSOption<FrameworkContractPrintDialogView>( "93a3b69d-99b4-49c4-bf4a-f95ac203af5a","","",this);
 
            SelectedLanguage = RPSControlFactory.CreateRPSOption<FrameworkContractPrintDialogView>( "3b99e97c-6694-4af0-89ed-fe70b0061c7a","","",this);
 
            UIPrintOptionsIDLanguage = RPSControlFactory.CreateRPSComboBox<FrameworkContractPrintDialogView>("c671bf91-608c-46cf-8c79-22159ab805d6","","",false, this);
 
            SupplierCopy = RPSControlFactory.CreateRPSOption<FrameworkContractPrintDialogView>( "3884df1c-5049-4602-9808-afa9d25c478f","","",this);
 
            SelectedCopy = RPSControlFactory.CreateRPSOption<FrameworkContractPrintDialogView>( "5a549762-2aaf-4f7e-ab3f-2294e3248e89","","",this);
 
            UINumberOfCopies = RPSControlFactory.CreateRPSFormattedTextBox<FrameworkContractPrintDialogView>("0cdfeb27-c7cd-421a-867e-eafcb2581fb2","","",false, this);
 
            UIPrintSpecificReport = RPSControlFactory.CreateRPSCheckBox<FrameworkContractPrintDialogView>("c20e1889-adf0-4d27-a4b8-f1c528316e17","","",false, this);
 
            UIDCustomReport = RPSControlFactory.CreateRPSComboBox<FrameworkContractPrintDialogView>("27c12172-fe73-4aac-a655-04ec16cc4c9a","","",false, this);
 
            PrintFrameworkContractCommandButton = RPSControlFactory.CreateRPSButton<FrameworkContractPrintDialogView>( "ade9f498-3e6d-49fe-8ec1-44926062ca46","","",this);
 
            SendFrameworContractByEmailCommandButton = RPSControlFactory.CreateRPSButton<FrameworkContractPrintDialogView>( "dcb5d8c1-4728-4950-8e8f-7ee06047f3b2","","",this);
 
            SendFrameworkContractToCustomerEmailCommandButton = RPSControlFactory.CreateRPSButton<FrameworkContractPrintDialogView>( "0d1ccdba-99a9-4f82-b47b-481f833a9f27","","",this);
 

        }
        public IRPSOption<FrameworkContractPrintDialogView> SupplierLanguage { get; set; } 
        public IRPSOption<FrameworkContractPrintDialogView> SelectedLanguage { get; set; } 
        public IRPSComboBox<FrameworkContractPrintDialogView> UIPrintOptionsIDLanguage { get; set; } 
        public IRPSOption<FrameworkContractPrintDialogView> SupplierCopy { get; set; } 
        public IRPSOption<FrameworkContractPrintDialogView> SelectedCopy { get; set; } 
        public IRPSTextBox<FrameworkContractPrintDialogView> UINumberOfCopies { get; set; } 
        public IRPSCheckbox<FrameworkContractPrintDialogView> UIPrintSpecificReport { get; set; } 
        public IRPSComboBox<FrameworkContractPrintDialogView> UIDCustomReport { get; set; } 
        public IRPSButton<FrameworkContractPrintDialogView> PrintFrameworkContractCommandButton { get; set; } 
        public IRPSButton<FrameworkContractPrintDialogView> SendFrameworContractByEmailCommandButton { get; set; } 
        public IRPSButton<FrameworkContractPrintDialogView> SendFrameworkContractToCustomerEmailCommandButton { get; set; } 
        public FrameworkContract Screen { get; set; }
        public FrameworkContractPrintDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}