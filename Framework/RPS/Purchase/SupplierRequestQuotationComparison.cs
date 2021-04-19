    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.SupplierRequestQuotationComparison
{
    //RPS VERSION 1.0.0.0
    public partial class SupplierRequestQuotationComparison:Screen
    {
        public SupplierRequestQuotationComparison():base()
        {
            this.URL = "purchase.supplierrequestquotationcomparison";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SupplierRequestQuotationComparisonQueryView  = new SupplierRequestQuotationComparisonQueryView(this); 
            ChangeReceivedStatusAceptedChildDialogView  = new ChangeReceivedStatusAceptedChildDialogView(this); 
            SupplierRequestQuotationGroupSearchDialogView  = new SupplierRequestQuotationGroupSearchDialogView(this); 
            SupplierRequestQuotationComparisonQueryView.InitializeControls(); 
            ChangeReceivedStatusAceptedChildDialogView.InitializeControls(); 
            SupplierRequestQuotationGroupSearchDialogView.InitializeControls(); 
           
        }
      
            public SupplierRequestQuotationComparisonQueryView SupplierRequestQuotationComparisonQueryView {get; set; } 
            public ChangeReceivedStatusAceptedChildDialogView ChangeReceivedStatusAceptedChildDialogView {get; set; } 
            public SupplierRequestQuotationGroupSearchDialogView SupplierRequestQuotationGroupSearchDialogView {get; set; } 
    }
            
    public partial class SupplierRequestQuotationComparisonQueryView : View
    {
        public SupplierRequestQuotationComparisonQueryView(SupplierRequestQuotationComparison screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDPurchaseProposal = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationComparisonQueryView>("c28671d6-cc58-46e6-88ec-9cd4ce37b382","","",false, this);
 
            Group = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationComparisonQueryView>("507f3ff9-69ff-44cc-b017-a8581ba6afb5","","",false, this);
 
            SupplierRequestQuotationGroupSearchNavigationCommand = RPSControlFactory.CreateRPSButtonToView<SupplierRequestQuotationComparisonQueryView,SupplierRequestQuotationGroupSearchDialogView>("adbad4c6-3a04-48f4-b53b-9fcdf60504ce","","", this,Screen.SupplierRequestQuotationGroupSearchDialogView);
 
            IDOrder = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationComparisonQueryView>("7aa1adbe-1679-4e1c-88ba-b3a091ff8e92","","",false, this);
 
            IDProductLine = RPSControlFactory.CreateRPSCollectionComboBox<SupplierRequestQuotationComparisonQueryView>("c2bf394f-e167-4992-8d66-79498ccd7a0d","","",false, this);
 
            IDProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<SupplierRequestQuotationComparisonQueryView>("95c6e13d-0ebb-4e77-b6ca-ed530231d516","","",false, this);
 
            IDProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<SupplierRequestQuotationComparisonQueryView>("2f7fb72a-1025-4613-89d5-39e369eea216","","",false, this);
 
            IDArticleList = RPSControlFactory.CreateRPSCollectionComboBox<SupplierRequestQuotationComparisonQueryView>("552a92f2-e7e0-469e-86b6-074c09354faa","","",false, this);
 
            ReferenceSupplier = RPSControlFactory.CreateRPSEnumComboBox<SupplierRequestQuotationComparisonQueryView>("3faa4349-26ed-4872-a081-685216094b24","","",false, this);
 
            ManufacturingOrder = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationComparisonQueryView>("9d924444-a4f9-4c94-a5a2-a2df8f42b8fb","","",false, this);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationComparisonQueryView>("09028613-72e7-474c-932e-1afcfa2332b0","","",false, this);
 
            IDOrderSL = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationComparisonQueryView>("4fe0f188-3870-48a9-96f1-c99d909c6f71","","",false, this);
 
            IDMaintenanceOrder = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationComparisonQueryView>("52a6e7af-ef30-4957-bf57-b2b182ad5c88","","",false, this);
 
            IDArticleStructure = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationComparisonQueryView>("0f7c3367-1015-4a75-a4df-84114b6c6f0f","","",false, this);
 
            InternalCode = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationComparisonQueryView>("b74c70a4-e9ce-4ff1-ae9d-ba0a9cb57f40","","",false, this);
 
            OnlyExternalTask = RPSControlFactory.CreateRPSCheckBox<SupplierRequestQuotationComparisonQueryView>("02a0bdc0-7afd-4c5e-8219-2e3561886a1f","","",false, this);
 
            IDQuotationSL = RPSControlFactory.CreateRPSComboBox<SupplierRequestQuotationComparisonQueryView>("07d3e6dc-310e-46c2-89b2-01ca2a67a8cb","","",false, this);
 
            SupplierRequestQuotation_SupplierRFQDate = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationComparisonQueryView>("befd9579-9af5-4df4-befb-321663bf9ae6","","",false, this);
 
            SupplierRequestQuotation_SupplierRFQGroup = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationComparisonQueryView>("4c301d86-62d9-4b8d-b656-bd3673d728a2","","",false, this);
 
            SupplierRequestQuotationLine_ReferenceSupplier = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationComparisonQueryView>("a023d430-cbf8-4f38-b33e-dd9c876c117c","","",false, this);
 
            SupplierRequestQuotationLine_Description = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationComparisonQueryView>("8d9abf20-e215-422a-82fc-3e9cfc266d54","","",false, this);
 
            SupplierRequestQuotationLine_ReceptionDate = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationComparisonQueryView>("a5faaa19-b280-429d-9f40-d1576ab51c2a","","",false, this);
 
            SupplierRequestQuotationLine_ReceptionDemandDate = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationComparisonQueryView>("dd075b2a-f182-4abd-aa2b-96a953930d68","","",false, this);
 
            SupplierRequestQuotationLine_ReceivedStatus = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationComparisonQueryView>("9cd8b9fd-2287-46ca-bd2d-cfe59af398d0","","",false, this);
 
            SupplierRequestQuotationLine_PercentVAT = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationComparisonQueryView>("8627d8af-af98-41d7-ba62-ddf044518557","","",false, this);
 
            SupplierRequestQuotationLine_PercentSurcharge = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationComparisonQueryView>("22451498-a1c7-4f00-94d4-c3aaf9355a12","","",false, this);
 
            SupplierRequestQuotationLine_ReceivedDate = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationComparisonQueryView>("3f9acc92-da3b-4ffd-a1a2-43e85cb6714e","","",false, this);
 
            SupplierRequestQuotationLine_AcceptedDate = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationComparisonQueryView>("329e01cd-7980-47a8-8262-780d279ba472","","",false, this);
 
            ExternalTask = RPSControlFactory.CreateRPSCheckBox<SupplierRequestQuotationComparisonQueryView>("fe93b610-a279-4308-86ed-82f94d4465ca","","",false, this);
 
            SupplierRequestQuotationLine_PurchaseLot = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationComparisonQueryView>("bc522ca9-6998-4f28-afc6-1ef7941f06bc","","",false, this);
 
            SupplierRequestQuotationLine_MinimumLot = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationComparisonQueryView>("f8ce261a-e032-4523-8fa4-39af32f0a1ab","","",false, this);
 
            SupplierRequestQuotationLine_DeliveryDays = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationComparisonQueryView>("2b943ce0-0dd5-4c03-9b81-a988664da735","","",false, this);
 
            SupplierRequestQuotationLine_InternalCode = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationComparisonQueryView>("88df7de5-577a-40fe-8190-870c973e4c7f","","",false, this);
 
            SupplierRequestQuotationLine_Discount1 = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationComparisonQueryView>("6e27110b-28a5-426c-a526-f892b06dcfbd","","",false, this);
 
            SupplierRequestQuotationLine_CascadeDiscount1 = RPSControlFactory.CreateRPSCheckBox<SupplierRequestQuotationComparisonQueryView>("a02a691a-a258-4859-af24-bceea42b67ab","","",false, this);
 
            SupplierRequestQuotationLine_Discount2 = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationComparisonQueryView>("511058d5-a1c2-4cb7-9030-f2d26c32102a","","",false, this);
 
            SupplierRequestQuotationLine_CascadeDiscount2 = RPSControlFactory.CreateRPSCheckBox<SupplierRequestQuotationComparisonQueryView>("5bd0dde3-1883-4728-ad43-ed5246267fdb","","",false, this);
 
            SupplierRequestQuotationLine_Discount3 = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationComparisonQueryView>("f23fafac-9249-41a2-8628-42dcc12600db","","",false, this);
 
            SupplierRequestQuotationLine_CascadeDiscount3 = RPSControlFactory.CreateRPSCheckBox<SupplierRequestQuotationComparisonQueryView>("4d7989ce-166c-4aaa-9261-750d1a170693","","",false, this);
 
            SupplierRequestQuotationLine_Discount4 = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationComparisonQueryView>("af0c38e9-b5ff-4380-965b-3b1091eb41b2","","",false, this);
 
            SupplierRequestQuotationLine_CascadeDiscount4 = RPSControlFactory.CreateRPSCheckBox<SupplierRequestQuotationComparisonQueryView>("d7a5fe25-5ebf-44a4-9214-dc280bc574a5","","",false, this);
 
            SupplierRequestQuotationLine_Discount5 = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationComparisonQueryView>("74bd75d5-2754-4ac9-b9d5-5ebfffcd9325","","",false, this);
 
            SupplierRequestQuotationLine_CascadeDiscount5 = RPSControlFactory.CreateRPSCheckBox<SupplierRequestQuotationComparisonQueryView>("df9d91a5-1959-4e0c-911b-94b8aa0cfa4a","","",false, this);
 
            SupplierRequestQuotationLine_AmountDiscount = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationComparisonQueryView>("55d72058-810a-4438-a12e-247e8085e100","","",false, this);
 
            SupplierRequestQuotationLine_PositionAmountDiscount = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationComparisonQueryView>("38c49c50-56dd-4d27-84bd-9ad7d6eced55","","",false, this);
 
            SupplierRequestQuotation_Discount1 = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationComparisonQueryView>("2f8ea8f0-1e30-411a-bc67-61fd1a3dc5e2","","",false, this);
 
            SupplierRequestQuotation_Discount2 = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationComparisonQueryView>("e99bcd28-71e6-42f0-89de-39b866d285e1","","",false, this);
 
            SupplierRequestQuotation_Discount3 = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationComparisonQueryView>("3839da35-927e-46ea-bfd0-f9f0c05ef0eb","","",false, this);
 
            SupplierRequestQuotation_CashDiscount = RPSControlFactory.CreateRPSFormattedTextBox<SupplierRequestQuotationComparisonQueryView>("fcfad95f-b14b-4dc3-97e3-415efa08d2b7","","",false, this);
 
            Matchcode = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationComparisonQueryView>("0b79605e-2f01-4e79-beab-21289a970fcd","","",false, this);
 
            ChangeReceivedStatusAceptedChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<SupplierRequestQuotationComparisonQueryView,ChangeReceivedStatusAceptedChildDialogView>("d9324eb7-6ad8-4256-ad83-e5dab23d81b1","","", this,Screen.ChangeReceivedStatusAceptedChildDialogView);
 
            RejectOfferLineCommandButton = RPSControlFactory.CreateRPSButton<SupplierRequestQuotationComparisonQueryView>( "816c60e0-6275-4a5e-9ca0-0d68ab8885ab","","",this);
 
            CollectionInit params_SupplierRequestQuotationLineComparisonConsult = new CollectionInit(){IDDescriptor = "af58dcc6-d3fd-4c81-bc69-375a5593d021",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="bb8251a5-f7d1-4101-824c-6007473ed1f0",CSSSelectorGrid="",XPathGrid=""};
            SupplierRequestQuotationLineComparisonConsult = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierRequestQuotationLineComparisonConsultCollectionEditor<SupplierRequestQuotationComparisonQueryView,ChangeReceivedStatusAceptedChildDialogView>,SupplierRequestQuotationComparisonQueryView,ChangeReceivedStatusAceptedChildDialogView>( params_SupplierRequestQuotationLineComparisonConsult,this,Screen.ChangeReceivedStatusAceptedChildDialogView);
 

        }
        public IRPSComboBox<SupplierRequestQuotationComparisonQueryView> IDPurchaseProposal { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationComparisonQueryView> Group { get; set; } 
        public IRPSButton<SupplierRequestQuotationComparisonQueryView,SupplierRequestQuotationGroupSearchDialogView> SupplierRequestQuotationGroupSearchNavigationCommand { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationComparisonQueryView> IDOrder { get; set; } 
        public IRPSCollectionComboBox<SupplierRequestQuotationComparisonQueryView> IDProductLine { get; set; } 
        public IRPSCollectionComboBox<SupplierRequestQuotationComparisonQueryView> IDProductFamily { get; set; } 
        public IRPSCollectionComboBox<SupplierRequestQuotationComparisonQueryView> IDProductSubFamily { get; set; } 
        public IRPSCollectionComboBox<SupplierRequestQuotationComparisonQueryView> IDArticleList { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationComparisonQueryView> ReferenceSupplier { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationComparisonQueryView> ManufacturingOrder { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationComparisonQueryView> IDProject { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationComparisonQueryView> IDOrderSL { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationComparisonQueryView> IDMaintenanceOrder { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationComparisonQueryView> IDArticleStructure { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationComparisonQueryView> InternalCode { get; set; } 
        public IRPSCheckbox<SupplierRequestQuotationComparisonQueryView> OnlyExternalTask { get; set; } 
        public IRPSComboBox<SupplierRequestQuotationComparisonQueryView> IDQuotationSL { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationComparisonQueryView> SupplierRequestQuotation_SupplierRFQDate { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationComparisonQueryView> SupplierRequestQuotation_SupplierRFQGroup { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationComparisonQueryView> SupplierRequestQuotationLine_ReferenceSupplier { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationComparisonQueryView> SupplierRequestQuotationLine_Description { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationComparisonQueryView> SupplierRequestQuotationLine_ReceptionDate { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationComparisonQueryView> SupplierRequestQuotationLine_ReceptionDemandDate { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationComparisonQueryView> SupplierRequestQuotationLine_ReceivedStatus { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationComparisonQueryView> SupplierRequestQuotationLine_PercentVAT { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationComparisonQueryView> SupplierRequestQuotationLine_PercentSurcharge { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationComparisonQueryView> SupplierRequestQuotationLine_ReceivedDate { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationComparisonQueryView> SupplierRequestQuotationLine_AcceptedDate { get; set; } 
        public IRPSCheckbox<SupplierRequestQuotationComparisonQueryView> ExternalTask { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationComparisonQueryView> SupplierRequestQuotationLine_PurchaseLot { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationComparisonQueryView> SupplierRequestQuotationLine_MinimumLot { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationComparisonQueryView> SupplierRequestQuotationLine_DeliveryDays { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationComparisonQueryView> SupplierRequestQuotationLine_InternalCode { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationComparisonQueryView> SupplierRequestQuotationLine_Discount1 { get; set; } 
        public IRPSCheckbox<SupplierRequestQuotationComparisonQueryView> SupplierRequestQuotationLine_CascadeDiscount1 { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationComparisonQueryView> SupplierRequestQuotationLine_Discount2 { get; set; } 
        public IRPSCheckbox<SupplierRequestQuotationComparisonQueryView> SupplierRequestQuotationLine_CascadeDiscount2 { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationComparisonQueryView> SupplierRequestQuotationLine_Discount3 { get; set; } 
        public IRPSCheckbox<SupplierRequestQuotationComparisonQueryView> SupplierRequestQuotationLine_CascadeDiscount3 { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationComparisonQueryView> SupplierRequestQuotationLine_Discount4 { get; set; } 
        public IRPSCheckbox<SupplierRequestQuotationComparisonQueryView> SupplierRequestQuotationLine_CascadeDiscount4 { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationComparisonQueryView> SupplierRequestQuotationLine_Discount5 { get; set; } 
        public IRPSCheckbox<SupplierRequestQuotationComparisonQueryView> SupplierRequestQuotationLine_CascadeDiscount5 { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationComparisonQueryView> SupplierRequestQuotationLine_AmountDiscount { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationComparisonQueryView> SupplierRequestQuotationLine_PositionAmountDiscount { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationComparisonQueryView> SupplierRequestQuotation_Discount1 { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationComparisonQueryView> SupplierRequestQuotation_Discount2 { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationComparisonQueryView> SupplierRequestQuotation_Discount3 { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationComparisonQueryView> SupplierRequestQuotation_CashDiscount { get; set; } 
        public IRPSTextBox<SupplierRequestQuotationComparisonQueryView> Matchcode { get; set; } 
        public IRPSButton<SupplierRequestQuotationComparisonQueryView,ChangeReceivedStatusAceptedChildDialogView> ChangeReceivedStatusAceptedChildNavigationCommandButton { get; set; } 
        public IRPSButton<SupplierRequestQuotationComparisonQueryView> RejectOfferLineCommandButton { get; set; } 
        public SupplierRequestQuotationLineComparisonConsultCollectionEditor<SupplierRequestQuotationComparisonQueryView,ChangeReceivedStatusAceptedChildDialogView> SupplierRequestQuotationLineComparisonConsult { get; set; } 
        public SupplierRequestQuotationComparison Screen { get; set; }
        public SupplierRequestQuotationComparisonQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SupplierRequestQuotationLineComparisonConsultCollectionEditor<SupplierRequestQuotationComparisonQueryView,ChangeReceivedStatusAceptedChildDialogView>:RPSCollectionEditor<SupplierRequestQuotationComparisonQueryView,ChangeReceivedStatusAceptedChildDialogView> where SupplierRequestQuotationComparisonQueryView : class, IView where ChangeReceivedStatusAceptedChildDialogView : class, IView
    {
        public  SupplierRequestQuotationLineComparisonConsultGridView<SupplierRequestQuotationComparisonQueryView,ChangeReceivedStatusAceptedChildDialogView> GridView {get;set;}
    }
    public partial class SupplierRequestQuotationLineComparisonConsultGridView <SupplierRequestQuotationComparisonQueryView,ChangeReceivedStatusAceptedChildDialogView> :  RPSGridView<SupplierRequestQuotationComparisonQueryView,ChangeReceivedStatusAceptedChildDialogView> where SupplierRequestQuotationComparisonQueryView : class, IView where ChangeReceivedStatusAceptedChildDialogView : class, IView
    {
        public SupplierRequestQuotationLineComparisonConsultGridView(SupplierRequestQuotationComparisonQueryView currentView,ChangeReceivedStatusAceptedChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            SupplierRequestQuotationLine_ReceptionDate = RPSControlFactory.CreateRPSGridTextBox<SupplierRequestQuotationComparisonQueryView>("","#bb8251a5-f7d1-4101-824c-6007473ed1f0 .ag-row[role='row']@ROWINDEX [col-id='cSupplierRequestQuotationLine_ReceptionDate']","",false, this.CurrentView);
 
            SupplierRequestQuotationLine_ReceivedStatus = RPSControlFactory.CreateRPSGridTextBox<SupplierRequestQuotationComparisonQueryView>("","#bb8251a5-f7d1-4101-824c-6007473ed1f0 .ag-row[role='row']@ROWINDEX [col-id='cSupplierRequestQuotationLine_ReceivedStatus']","",false, this.CurrentView);
 
            Matchcode = RPSControlFactory.CreateRPSGridTextBox<SupplierRequestQuotationComparisonQueryView>("","#bb8251a5-f7d1-4101-824c-6007473ed1f0 .ag-row[role='row']@ROWINDEX [col-id='cMatchcode']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SupplierRequestQuotationComparisonQueryView> SupplierRequestQuotationLine_ReceptionDate { get; set; } 
        public IRPSGridTextBox<SupplierRequestQuotationComparisonQueryView> SupplierRequestQuotationLine_ReceivedStatus { get; set; } 
        public IRPSGridTextBox<SupplierRequestQuotationComparisonQueryView> Matchcode { get; set; } 
                     
    }
 
    }
  
            
    public partial class ChangeReceivedStatusAceptedChildDialogView : View
    {
        public ChangeReceivedStatusAceptedChildDialogView(SupplierRequestQuotationComparison screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            bUpdateSupplier = RPSControlFactory.CreateRPSCheckBox<ChangeReceivedStatusAceptedChildDialogView>("a7b1a3fb-1220-4f35-9540-57629bc61326","","",false, this);
 
            bUpdatecost = RPSControlFactory.CreateRPSCheckBox<ChangeReceivedStatusAceptedChildDialogView>("44ee2b84-c913-4885-b555-40c38db7ec85","","",false, this);
 
            bUpdatePrices = RPSControlFactory.CreateRPSCheckBox<ChangeReceivedStatusAceptedChildDialogView>("abb0ef84-7d72-402b-b85d-1c0bdabe4e37","","",false, this);
 
            bQuantity = RPSControlFactory.CreateRPSCheckBox<ChangeReceivedStatusAceptedChildDialogView>("da0c0694-7fff-4d73-ad3b-8a896cb84c88","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<ChangeReceivedStatusAceptedChildDialogView>("7d16bd01-7576-4763-8929-e97b8b43055e","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<ChangeReceivedStatusAceptedChildDialogView>("47acea35-c7a3-4a63-9ffe-8edb96fe1c72","","",false, this);
 
            Allot = RPSControlFactory.CreateRPSCheckBox<ChangeReceivedStatusAceptedChildDialogView>("a2201778-9e1f-4b67-8537-7fac8efd50e3","","",false, this);
 

        }
        public IRPSCheckbox<ChangeReceivedStatusAceptedChildDialogView> bUpdateSupplier { get; set; } 
        public IRPSCheckbox<ChangeReceivedStatusAceptedChildDialogView> bUpdatecost { get; set; } 
        public IRPSCheckbox<ChangeReceivedStatusAceptedChildDialogView> bUpdatePrices { get; set; } 
        public IRPSCheckbox<ChangeReceivedStatusAceptedChildDialogView> bQuantity { get; set; } 
        public IRPSTextBox<ChangeReceivedStatusAceptedChildDialogView> DateFrom { get; set; } 
        public IRPSTextBox<ChangeReceivedStatusAceptedChildDialogView> DateTo { get; set; } 
        public IRPSCheckbox<ChangeReceivedStatusAceptedChildDialogView> Allot { get; set; } 
        public SupplierRequestQuotationComparison Screen { get; set; }
        public ChangeReceivedStatusAceptedChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SupplierRequestQuotationGroupSearchDialogView : View
    {
        public SupplierRequestQuotationGroupSearchDialogView(SupplierRequestQuotationComparison screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SelectedDateFromFilter = RPSControlFactory.CreateRPSTextBox<SupplierRequestQuotationGroupSearchDialogView>("0b356fa4-c6b4-417b-a8a8-ab6383c1a89f","","",false, this);
 
            ExecuteSupplierRequestQuotationGroupInquire = RPSControlFactory.CreateRPSButton<SupplierRequestQuotationGroupSearchDialogView>( "ae9f2f0f-ba99-4144-ac44-16c151855f66","","",this);
 
            CollectionInit params_SupplierRequestQuotationGroupInquire = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="51e98898-3d87-46e4-bb4a-bca7db3b3f83",CSSSelectorGrid="",XPathGrid=""};
            SupplierRequestQuotationGroupInquire = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierRequestQuotationGroupInquireCollectionEditor<SupplierRequestQuotationGroupSearchDialogView>,SupplierRequestQuotationGroupSearchDialogView>( params_SupplierRequestQuotationGroupInquire,this);
 

        }
        public IRPSTextBox<SupplierRequestQuotationGroupSearchDialogView> SelectedDateFromFilter { get; set; } 
        public IRPSButton<SupplierRequestQuotationGroupSearchDialogView> ExecuteSupplierRequestQuotationGroupInquire { get; set; } 
        public SupplierRequestQuotationGroupInquireCollectionEditor<SupplierRequestQuotationGroupSearchDialogView> SupplierRequestQuotationGroupInquire { get; set; } 
        public SupplierRequestQuotationComparison Screen { get; set; }
        public SupplierRequestQuotationGroupSearchDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SupplierRequestQuotationGroupInquireCollectionEditor<SupplierRequestQuotationGroupSearchDialogView>:RPSCollectionEditor<SupplierRequestQuotationGroupSearchDialogView> where SupplierRequestQuotationGroupSearchDialogView : class, IView
    {
        public  SupplierRequestQuotationGroupInquireGridView<SupplierRequestQuotationGroupSearchDialogView> GridView {get;set;}
    }
    public partial class SupplierRequestQuotationGroupInquireGridView <SupplierRequestQuotationGroupSearchDialogView> :  RPSGridView<SupplierRequestQuotationGroupSearchDialogView> where SupplierRequestQuotationGroupSearchDialogView : class, IView
    {
        public SupplierRequestQuotationGroupInquireGridView(SupplierRequestQuotationGroupSearchDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            SupplierRequestQuotation_SupplierRFQGroup = RPSControlFactory.CreateRPSGridTextBox<SupplierRequestQuotationGroupSearchDialogView>("","#51e98898-3d87-46e4-bb4a-bca7db3b3f83 .ag-row[role='row']@ROWINDEX [col-id='cSupplierRFQGroup']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SupplierRequestQuotationGroupSearchDialogView> SupplierRequestQuotation_SupplierRFQGroup { get; set; } 
                     
    }
 
    }
  
    

}