    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.InvoiceExpenseAllocation
{
    //RPS VERSION 1.0.0.0
    public partial class InvoiceExpenseAllocation:Screen
    {
        public InvoiceExpenseAllocation():base()
        {
            this.URL = "purchase.invoiceexpenseallocation";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            InvoiceCollectionView  = new InvoiceCollectionView(this); 
            InvoiceEntityView  = new InvoiceEntityView(this); 
            InvoiceLineView  = new InvoiceLineView(this); 
            RecalculateCostChildDialogView  = new RecalculateCostChildDialogView(this); 
            InvoiceCollectionView.InitializeControls(); 
            InvoiceEntityView.InitializeControls(); 
            InvoiceLineView.InitializeControls(); 
            RecalculateCostChildDialogView.InitializeControls(); 
           
        }
      
            public InvoiceCollectionView InvoiceCollectionView {get; set; } 
            public InvoiceEntityView InvoiceEntityView {get; set; } 
            public InvoiceLineView InvoiceLineView {get; set; } 
            public RecalculateCostChildDialogView RecalculateCostChildDialogView {get; set; } 
    }
            
    public partial class InvoiceCollectionView : View
    {
        public InvoiceCollectionView(InvoiceExpenseAllocation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<InvoiceCollectionView,InvoiceEntityView>( this,Screen.InvoiceEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "f6666f19-72f9-4eb4-8f11-9d5cc82f4998",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<InvoiceCollectionView,InvoiceEntityView>( params_MainConsult,this,Screen.InvoiceEntityView);
 

        }
        public IRPSButton<InvoiceCollectionView,InvoiceEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<InvoiceCollectionView,InvoiceEntityView> MainConsult { get; set; } 
        public InvoiceExpenseAllocation Screen { get; set; }
        public InvoiceCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class InvoiceEntityView : View
    {
        public InvoiceEntityView(InvoiceExpenseAllocation screen) : base()
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
 
            RecalculateCostChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<InvoiceEntityView,RecalculateCostChildDialogView>("92c911a7-914c-4a02-9f30-4e3da8156d2d","","", this,Screen.RecalculateCostChildDialogView);
 
            CollectionInit params_InvoiceLines = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="dce630d2-1981-4caf-951c-47f109e398b0",CSSSelectorGrid="",XPathGrid=""};
            InvoiceLines = RPSControlFactory.RPSCreateCollectionWithGrid<InvoiceLinesCollectionEditor<InvoiceEntityView,InvoiceLineView>,InvoiceEntityView,InvoiceLineView>( params_InvoiceLines,this,Screen.InvoiceLineView);
 

        }
        public IRPSSaveButton<InvoiceEntityView> SaveButton { get; set; } 
        public IRPSButton<InvoiceEntityView> DeleteButton { get; set; } 
        public IRPSButton<InvoiceEntityView,InvoiceCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<InvoiceEntityView,InvoiceCollectionView> BackButton { get; set; } 
        public IRPSButton<InvoiceEntityView,RecalculateCostChildDialogView> RecalculateCostChildNavigationCommandButton { get; set; } 
        public InvoiceLinesCollectionEditor<InvoiceEntityView,InvoiceLineView> InvoiceLines { get; set; } 
        public InvoiceExpenseAllocation Screen { get; set; }
        public InvoiceEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class InvoiceLinesCollectionEditor<InvoiceEntityView,InvoiceLineView>:RPSCollectionEditor<InvoiceEntityView,InvoiceLineView> where InvoiceEntityView : class, IView where InvoiceLineView : class, IView
    {
        public  InvoiceLinesGridView<InvoiceEntityView,InvoiceLineView> GridView {get;set;}
    }
    public partial class InvoiceLinesGridView <InvoiceEntityView,InvoiceLineView> :  RPSGridView<InvoiceEntityView,InvoiceLineView> where InvoiceEntityView : class, IView where InvoiceLineView : class, IView
    {
        public InvoiceLinesGridView(InvoiceEntityView currentView,InvoiceLineView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodDeliveryNote = RPSControlFactory.CreateRPSGridTextBox<InvoiceEntityView>("","#dce630d2-1981-4caf-951c-47f109e398b0 .ag-row[role='row']@ROWINDEX [col-id='cCodDeliveryNote']","",false, this.CurrentView);
 
            CodOrder = RPSControlFactory.CreateRPSGridTextBox<InvoiceEntityView>("","#dce630d2-1981-4caf-951c-47f109e398b0 .ag-row[role='row']@ROWINDEX [col-id='cCodOrder']","",false, this.CurrentView);
 
            Ordenation = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceEntityView>("","#dce630d2-1981-4caf-951c-47f109e398b0 .ag-row[role='row']@ROWINDEX [col-id='cOrdenation']","",true, this.CurrentView);
 
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<InvoiceEntityView>("","#dce630d2-1981-4caf-951c-47f109e398b0 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceEntityView>("","#dce630d2-1981-4caf-951c-47f109e398b0 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceEntityView>("","#dce630d2-1981-4caf-951c-47f109e398b0 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",true, this.CurrentView);
 
            DeliveryCost = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceEntityView>("","#dce630d2-1981-4caf-951c-47f109e398b0 .ag-row[role='row']@ROWINDEX [col-id='cDeliveryCost']","",true, this.CurrentView);
 
            ImportCost = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceEntityView>("","#dce630d2-1981-4caf-951c-47f109e398b0 .ag-row[role='row']@ROWINDEX [col-id='cImportCost']","",true, this.CurrentView);
 
            TariffCost = RPSControlFactory.CreateRPSGridFormattedTextBox<InvoiceEntityView>("","#dce630d2-1981-4caf-951c-47f109e398b0 .ag-row[role='row']@ROWINDEX [col-id='cTariffCost']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<InvoiceEntityView> CodDeliveryNote { get; set; } 
        public IRPSGridTextBox<InvoiceEntityView> CodOrder { get; set; } 
        public IRPSGridTextBox<InvoiceEntityView> Ordenation { get; set; } 
        public IRPSGridComboBox<InvoiceEntityView> IDArticle { get; set; } 
        public IRPSGridTextBox<InvoiceEntityView> Quantity { get; set; } 
        public IRPSGridTextBox<InvoiceEntityView> Amount { get; set; } 
        public IRPSGridTextBox<InvoiceEntityView> DeliveryCost { get; set; } 
        public IRPSGridTextBox<InvoiceEntityView> ImportCost { get; set; } 
        public IRPSGridTextBox<InvoiceEntityView> TariffCost { get; set; } 
                     
    }
 
    }
  
            
    public partial class InvoiceLineView : View
    {
        public InvoiceLineView(InvoiceExpenseAllocation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<InvoiceLineView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<InvoiceLineView,InvoiceEntityView>( this,Screen.InvoiceEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<InvoiceLineView,InvoiceEntityView>( this,Screen.InvoiceEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<InvoiceLineView,InvoiceEntityView>( this,Screen.InvoiceEntityView);
 
            Ordenation = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("d81a6da0-43ab-44b0-a066-b125967b8fed","","",true, this);
 
            CodDeliveryNote = RPSControlFactory.CreateRPSTextBox<InvoiceLineView>("0314345d-2d62-425c-bec4-358f6b08f37a","","",false, this);
 
            CodOrder = RPSControlFactory.CreateRPSTextBox<InvoiceLineView>("d2b575ea-b4be-4fc0-b446-9881df90da95","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<InvoiceLineView>("2b696201-28f3-4b4e-914d-3b2c0023379b","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<InvoiceLineView>("5586bb4e-6b14-4986-9ad4-9cf71ac43abf","","",false, this);
 
            Series = RPSControlFactory.CreateRPSTextBox<InvoiceLineView>("6e57fd4d-a174-45c3-af7c-180e65c53fc9","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("5832cd7c-ab00-43d8-9d2f-d4165d716943","","",true, this);
 
            ConversionFactorQuantity = RPSControlFactory.CreateRPSTextBox<InvoiceLineView>("847f3811-ba30-41a5-b7a8-c6a79d8ea41d","","",false, this);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("8808e88b-7fe4-407b-8137-6d90672e29d6","","",true, this);
 
            Dimension1 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("074e4ea3-7ce2-4802-9b14-b98b855b419e","","",true, this);
 
            Dimension2 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("edf02f22-8fbe-4f63-af0b-5849854f59f5","","",true, this);
 
            Dimension3 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("0ac44db6-ab74-4ebf-8892-7f7e3f792488","","",true, this);
 
            Price = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("4711d943-e998-46b1-b845-20d5ad7affbd","","",true, this);
 
            VAT = RPSControlFactory.CreateRPSCheckBox<InvoiceLineView>("1f240acc-047e-40d1-b2e6-f7a0a17e5800","","",true, this);
 
            ConversionFactorPrice = RPSControlFactory.CreateRPSTextBox<InvoiceLineView>("d31dbef6-ac0d-4532-b088-1a5a40a3cf3f","","",false, this);
 
            Amount = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("1226cd68-bb89-43f0-a740-af20b8bddaa9","","",true, this);
 
            AmountWithVAT = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("fb8d7145-2336-40a1-a5a0-65416ca004b7","","",true, this);
 
            CostPercentage = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("78d046b2-96ca-4ba1-9c82-95eec2933a2a","","",false, this);
 
            DeliveryCost = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("3b018d9a-61b5-4dbe-ae31-a636b882eb54","","",true, this);
 
            ImportCost = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("bd15d833-347d-4699-8c8a-1aff25390043","","",true, this);
 
            TariffCost = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("1f95b82b-7fbf-41af-aa86-22a4bd58c846","","",true, this);
 
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
 
            IDSite = RPSControlFactory.CreateRPSComboBox<InvoiceLineView>("c93290e0-5713-4cbf-8141-affa54449daf","","",false, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<InvoiceLineView>("ebe50917-4044-46e6-9a7a-6c26cc88864e","","",false, this);
 
            IDDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<InvoiceLineView>("1adb2744-3998-4b34-bec3-415d994c5eed","","",false, this);
 
            IDReturnCause = RPSControlFactory.CreateRPSComboBox<InvoiceLineView>("0c613a7b-e3ba-4145-a25a-a39cab6898ac","","",false, this);
 
            IDAccount = RPSControlFactory.CreateRPSComboBox<InvoiceLineView>("74fbcab0-41ed-450d-8969-cab02f43f751","","",false, this);
 
            CostPercentage1 = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("ea956850-830b-4f28-9c26-b36305c606b6","","",false, this);
 
            NumProm = RPSControlFactory.CreateRPSFormattedTextBox<InvoiceLineView>("a4fb6c41-9da0-4bfc-9dfe-64e739f0c095","","",false, this);
 
            Rappel = RPSControlFactory.CreateRPSCheckBox<InvoiceLineView>("b9a2799e-c3fe-40d2-88be-b2d5357e96c4","","",false, this);
 

        }
        public IRPSButton<InvoiceLineView> DeleteButton { get; set; } 
        public IRPSButton<InvoiceLineView,InvoiceEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<InvoiceLineView,InvoiceEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<InvoiceLineView,InvoiceEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<InvoiceLineView> Ordenation { get; set; } 
        public IRPSTextBox<InvoiceLineView> CodDeliveryNote { get; set; } 
        public IRPSTextBox<InvoiceLineView> CodOrder { get; set; } 
        public IRPSComboBox<InvoiceLineView> IDArticle { get; set; } 
        public IRPSTextBox<InvoiceLineView> Description { get; set; } 
        public IRPSTextBox<InvoiceLineView> Series { get; set; } 
        public IRPSTextBox<InvoiceLineView> Quantity { get; set; } 
        public IRPSTextBox<InvoiceLineView> ConversionFactorQuantity { get; set; } 
        public IRPSTextBox<InvoiceLineView> QuantitySecondUnit { get; set; } 
        public IRPSTextBox<InvoiceLineView> Dimension1 { get; set; } 
        public IRPSTextBox<InvoiceLineView> Dimension2 { get; set; } 
        public IRPSTextBox<InvoiceLineView> Dimension3 { get; set; } 
        public IRPSTextBox<InvoiceLineView> Price { get; set; } 
        public IRPSCheckbox<InvoiceLineView> VAT { get; set; } 
        public IRPSTextBox<InvoiceLineView> ConversionFactorPrice { get; set; } 
        public IRPSTextBox<InvoiceLineView> Amount { get; set; } 
        public IRPSTextBox<InvoiceLineView> AmountWithVAT { get; set; } 
        public IRPSTextBox<InvoiceLineView> CostPercentage { get; set; } 
        public IRPSTextBox<InvoiceLineView> DeliveryCost { get; set; } 
        public IRPSTextBox<InvoiceLineView> ImportCost { get; set; } 
        public IRPSTextBox<InvoiceLineView> TariffCost { get; set; } 
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
        public IRPSComboBox<InvoiceLineView> IDSite { get; set; } 
        public IRPSComboBox<InvoiceLineView> IDWarehouse { get; set; } 
        public IRPSComboBox<InvoiceLineView> IDDeliveryNoteType { get; set; } 
        public IRPSComboBox<InvoiceLineView> IDReturnCause { get; set; } 
        public IRPSComboBox<InvoiceLineView> IDAccount { get; set; } 
        public IRPSTextBox<InvoiceLineView> CostPercentage1 { get; set; } 
        public IRPSTextBox<InvoiceLineView> NumProm { get; set; } 
        public IRPSCheckbox<InvoiceLineView> Rappel { get; set; } 
        public InvoiceExpenseAllocation Screen { get; set; }
        public InvoiceLineView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class RecalculateCostChildDialogView : View
    {
        public RecalculateCostChildDialogView(InvoiceExpenseAllocation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ChkDeliveryCost = RPSControlFactory.CreateRPSCheckBox<RecalculateCostChildDialogView>("f4e32204-16ac-4bb9-bdeb-dc4fdb2c77ff","","",false, this);
 
            Porcent = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "d3f5744a-2e52-4bcf-9816-96a1dc5d0ac6","","",this);
 
            Amount = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "05585c30-323f-463a-a7c3-2fd30fa77827","","",this);
 
            DeliveryCostQuantity = RPSControlFactory.CreateRPSFormattedTextBox<RecalculateCostChildDialogView>("bcd56ee6-2c4d-4af2-9f3d-fbfe14740edf","","",false, this);
 
            LineAmount = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "191db912-b2d3-4cad-bafe-24a88e64ebe7","","",this);
 
            Quantity = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "0fd5f0ee-618f-4d78-9f1f-3eb1c5fddee6","","",this);
 
            NetWeight = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "4eae9b24-5aa0-4ff6-87dd-c07ffbf8a605","","",this);
 
            GrossWeight = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "07cd4b4f-6ad3-486c-a9a5-d1a8ade2fff0","","",this);
 
            PositiveAmountPor = RPSControlFactory.CreateRPSCheckBox<RecalculateCostChildDialogView>("14f5fd0b-5052-4f65-8c2f-d0a56bf22ffa","","",false, this);
 
            OnlyArticlesPor = RPSControlFactory.CreateRPSCheckBox<RecalculateCostChildDialogView>("2d21e592-0e5a-4909-a48f-a6590aa82b3d","","",false, this);
 
            ChkImportCost = RPSControlFactory.CreateRPSCheckBox<RecalculateCostChildDialogView>("1c5dfc6c-d225-4129-ad1e-fce4c317f88c","","",false, this);
 
            Porcent1 = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "733189b5-7be4-4c9f-bc96-328b72b1640f","","",this);
 
            Amount1 = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "b88a29b6-dbbf-4ec2-b81f-748d3e0c0ac7","","",this);
 
            ImportCostQuantity = RPSControlFactory.CreateRPSFormattedTextBox<RecalculateCostChildDialogView>("7d879283-ce35-45eb-8577-3f1616e77617","","",false, this);
 
            LineAmount1 = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "1d72da56-243a-4bec-acb3-0b99458a4b70","","",this);
 
            Quantity1 = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "9897343c-a4d4-4d67-8c89-91db3856496c","","",this);
 
            NetWeight1 = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "ec5dfbac-d01c-413a-aac2-64cf3339b06e","","",this);
 
            GrossWeight1 = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "4055ae83-253d-48e1-9c6f-6c15e46c9b8c","","",this);
 
            PositiveAmountImpor = RPSControlFactory.CreateRPSCheckBox<RecalculateCostChildDialogView>("942ecb70-8754-44c8-b7e6-ca109e344a15","","",false, this);
 
            OnlyArticlesImpor = RPSControlFactory.CreateRPSCheckBox<RecalculateCostChildDialogView>("d0ec98e1-245a-4d21-b101-20dafe8181df","","",false, this);
 
            ChkTariffCost = RPSControlFactory.CreateRPSCheckBox<RecalculateCostChildDialogView>("94f97770-335c-40e1-8adf-f2ef7770620c","","",false, this);
 
            Porcent2 = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "ec9aaa42-be31-48a5-b8cc-4bb5cff6584b","","",this);
 
            Amount2 = RPSControlFactory.CreateRPSOption<RecalculateCostChildDialogView>( "ec62ef2c-2d77-4b11-baf7-39016dce2738","","",this);
 
            TariffCostQuantity = RPSControlFactory.CreateRPSFormattedTextBox<RecalculateCostChildDialogView>("001e9c6e-8cb1-4477-be29-838c76360684","","",false, this);
 
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
        public InvoiceExpenseAllocation Screen { get; set; }
        public RecalculateCostChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}