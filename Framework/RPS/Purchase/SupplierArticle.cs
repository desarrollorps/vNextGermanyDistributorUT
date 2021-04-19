    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.SupplierArticle
{
    //RPS VERSION 1.0.0.0
    public partial class SupplierArticle:Screen
    {
        public SupplierArticle():base()
        {
            this.URL = "purchase.supplierarticle";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SupplierArticleVMQueryView  = new SupplierArticleVMQueryView(this); 
            SupplierArticleVMEntityView  = new SupplierArticleVMEntityView(this); 
            SupplierArticlePriceView  = new SupplierArticlePriceView(this); 
            SupplierArticleDeliveryView  = new SupplierArticleDeliveryView(this); 
            SupplierArticleVMQueryView.InitializeControls(); 
            SupplierArticleVMEntityView.InitializeControls(); 
            SupplierArticlePriceView.InitializeControls(); 
            SupplierArticleDeliveryView.InitializeControls(); 
           
        }
      
            public SupplierArticleVMQueryView SupplierArticleVMQueryView {get; set; } 
            public SupplierArticleVMEntityView SupplierArticleVMEntityView {get; set; } 
            public SupplierArticlePriceView SupplierArticlePriceView {get; set; } 
            public SupplierArticleDeliveryView SupplierArticleDeliveryView {get; set; } 
    }
            
    public partial class SupplierArticleVMQueryView : View
    {
        public SupplierArticleVMQueryView(SupplierArticle screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<SupplierArticleVMQueryView,SupplierArticleVMEntityView>( this,Screen.SupplierArticleVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<SupplierArticleVMQueryView>( this);
 
            UIActiveDate = RPSControlFactory.CreateRPSTextBox<SupplierArticleVMQueryView>("a3a163a3-bb9c-49b8-966c-df6d535d7369","","",false, this);
 
            Supplier = RPSControlFactory.CreateRPSOption<SupplierArticleVMQueryView>( "07a14465-fd18-4cb2-81de-ae4d4b98b6ea","","",this);
 
            Supplier1 = RPSControlFactory.CreateRPSComboBox<SupplierArticleVMQueryView>("22cfa8f0-471a-41df-88e1-a06c57e172ee","","",false, this);
 
            ArticleGroup = RPSControlFactory.CreateRPSCollectionComboBox<SupplierArticleVMQueryView>("84390d39-1fb5-4d5c-906c-9254dce8c4a6","","",false, this);
 
            Article = RPSControlFactory.CreateRPSOption<SupplierArticleVMQueryView>( "0311c906-8ddd-4d7b-b2b4-b625ecf0f8fe","","",this);
 
            Article1 = RPSControlFactory.CreateRPSComboBox<SupplierArticleVMQueryView>("724e713a-bd55-469c-aa95-e7487692e64b","","",false, this);
 
            SupplierGroup = RPSControlFactory.CreateRPSCollectionComboBox<SupplierArticleVMQueryView>("a243ed1b-55ca-4361-b61f-0178dc0230e4","","",false, this);
 
            CollectionInit params_SupplierArticleQuery = new CollectionInit(){IDDescriptor = "bf283a70-c880-431b-8177-693c0688ef79",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5dc254a0-4b8b-40e7-9886-20cef1916864",CSSSelectorGrid="",XPathGrid=""};
            SupplierArticleQuery = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierArticleQueryCollectionEditor<SupplierArticleVMQueryView,SupplierArticleVMEntityView>,SupplierArticleVMQueryView,SupplierArticleVMEntityView>( params_SupplierArticleQuery,this,Screen.SupplierArticleVMEntityView);
 

        }
        public IRPSButton<SupplierArticleVMQueryView,SupplierArticleVMEntityView> NewButton { get; set; } 
        public IRPSButton<SupplierArticleVMQueryView> ConsultButton { get; set; } 
        public IRPSTextBox<SupplierArticleVMQueryView> UIActiveDate { get; set; } 
        public IRPSOption<SupplierArticleVMQueryView> Supplier { get; set; } 
        public IRPSComboBox<SupplierArticleVMQueryView> Supplier1 { get; set; } 
        public IRPSCollectionComboBox<SupplierArticleVMQueryView> ArticleGroup { get; set; } 
        public IRPSOption<SupplierArticleVMQueryView> Article { get; set; } 
        public IRPSComboBox<SupplierArticleVMQueryView> Article1 { get; set; } 
        public IRPSCollectionComboBox<SupplierArticleVMQueryView> SupplierGroup { get; set; } 
        public SupplierArticleQueryCollectionEditor<SupplierArticleVMQueryView,SupplierArticleVMEntityView> SupplierArticleQuery { get; set; } 
        public SupplierArticle Screen { get; set; }
        public SupplierArticleVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SupplierArticleQueryCollectionEditor<SupplierArticleVMQueryView,SupplierArticleVMEntityView>:RPSCollectionEditor<SupplierArticleVMQueryView,SupplierArticleVMEntityView> where SupplierArticleVMQueryView : class, IView where SupplierArticleVMEntityView : class, IView
    {
        public  SupplierArticleQueryGridView<SupplierArticleVMQueryView,SupplierArticleVMEntityView> GridView {get;set;}
    }
    public partial class SupplierArticleQueryGridView <SupplierArticleVMQueryView,SupplierArticleVMEntityView> :  RPSGridView<SupplierArticleVMQueryView,SupplierArticleVMEntityView> where SupplierArticleVMQueryView : class, IView where SupplierArticleVMEntityView : class, IView
    {
        public SupplierArticleQueryGridView(SupplierArticleVMQueryView currentView,SupplierArticleVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            SupplierArticle_ReferenceSupplier = RPSControlFactory.CreateRPSGridTextBox<SupplierArticleVMQueryView>("","#5dc254a0-4b8b-40e7-9886-20cef1916864 .ag-row[role='row']@ROWINDEX [col-id='cSupplierArticle_ReferenceSupplier']","",false, this.CurrentView);
 
            SupplierArticle_DescriptionSupplier = RPSControlFactory.CreateRPSGridTextBox<SupplierArticleVMQueryView>("","#5dc254a0-4b8b-40e7-9886-20cef1916864 .ag-row[role='row']@ROWINDEX [col-id='cSupplierArticle_DescriptionSupplier']","",false, this.CurrentView);
 
            SupplierArticle_Blocked = RPSControlFactory.CreateRPSGridCheckBox<SupplierArticleVMQueryView>("","#5dc254a0-4b8b-40e7-9886-20cef1916864 .ag-row[role='row']@ROWINDEX [col-id='cSupplierArticle_Blocked']","",false, this.CurrentView);
 
            SupplierArticle_PurchaseKit = RPSControlFactory.CreateRPSGridCheckBox<SupplierArticleVMQueryView>("","#5dc254a0-4b8b-40e7-9886-20cef1916864 .ag-row[role='row']@ROWINDEX [col-id='cSupplierArticle_PurchaseKit']","",false, this.CurrentView);
 
            SupplierArticle_VAT = RPSControlFactory.CreateRPSGridCheckBox<SupplierArticleVMQueryView>("","#5dc254a0-4b8b-40e7-9886-20cef1916864 .ag-row[role='row']@ROWINDEX [col-id='cSupplierArticle_VAT']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SupplierArticleVMQueryView> SupplierArticle_ReferenceSupplier { get; set; } 
        public IRPSGridTextBox<SupplierArticleVMQueryView> SupplierArticle_DescriptionSupplier { get; set; } 
        public IRPSGridCheckbox<SupplierArticleVMQueryView> SupplierArticle_Blocked { get; set; } 
        public IRPSGridCheckbox<SupplierArticleVMQueryView> SupplierArticle_PurchaseKit { get; set; } 
        public IRPSGridCheckbox<SupplierArticleVMQueryView> SupplierArticle_VAT { get; set; } 
                     
    }
 
    }
  
            
    public partial class SupplierArticleVMEntityView : View
    {
        public SupplierArticleVMEntityView(SupplierArticle screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<SupplierArticleVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierArticleVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierArticleVMEntityView,SupplierArticleVMQueryView>( this,Screen.SupplierArticleVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierArticleVMEntityView,SupplierArticleVMQueryView>( this,Screen.SupplierArticleVMQueryView);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<SupplierArticleVMEntityView>("bccc1863-10ea-46bf-91f4-4cd15ba69b89","","",true, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<SupplierArticleVMEntityView>("71d26cc7-3c34-4552-9544-6fa9ab417754","","",true, this);
 
            Blocked = RPSControlFactory.CreateRPSCheckBox<SupplierArticleVMEntityView>("ff228a88-8f7c-46e6-9f8f-d2f433a465c4","","",true, this);
 
            PurchaseKit = RPSControlFactory.CreateRPSCheckBox<SupplierArticleVMEntityView>("9aa2b6e0-f86d-4662-87d2-d4bcbbc342e7","","",true, this);
 
            VAT = RPSControlFactory.CreateRPSCheckBox<SupplierArticleVMEntityView>("d8badfeb-6eb5-432b-a91f-c77dac3a5327","","",true, this);
 
            DescriptionSupplier = RPSControlFactory.CreateRPSTextBox<SupplierArticleVMEntityView>("52206267-88cb-48f1-a9cc-adaa045f807a","","",false, this);
 
            ReferenceSupplier = RPSControlFactory.CreateRPSTextBox<SupplierArticleVMEntityView>("f09007aa-4c8b-4e66-aa5d-e911da02d402","","",false, this);
 
            IDCurrency = RPSControlFactory.CreateRPSComboBox<SupplierArticleVMEntityView>("7d1342c5-c000-42dd-822d-dc774cd13e20","","",true, this);
 
            Default = RPSControlFactory.CreateRPSCheckBox<SupplierArticleVMEntityView>("4f697568-3b55-404c-a9cc-1fb8596c3c3a","","",true, this);
 
            IDArticleStructure = RPSControlFactory.CreateRPSComboBox<SupplierArticleVMEntityView>("eeca31d6-74c8-4469-8246-f8aa090c81fd","","",false, this);
 
            Ean13 = RPSControlFactory.CreateRPSTextBox<SupplierArticleVMEntityView>("2e1259c4-c610-4767-9b35-8cec828164b1","","",false, this);
 
            IDArticleContainer = RPSControlFactory.CreateRPSComboBox<SupplierArticleVMEntityView>("61e45dd0-7786-4b15-8784-2da3add4a9fc","","",false, this);
 
            TechnicalDescription = RPSControlFactory.CreateRPSTextBox<SupplierArticleVMEntityView>("9aa3ebf0-a179-41f5-8255-c17855c06440","","",false, this);
 
            DuplicateCommandButton = RPSControlFactory.CreateRPSButton<SupplierArticleVMEntityView>( "f76f5e33-2d5c-4beb-80dc-851383c75bd2","","",this);
 
            CollectionInit params_SupplierArticlePrices = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="e6d1e724-4ec4-4e85-8330-879723b7ec7d",CSSSelectorGrid="",XPathGrid=""};
            SupplierArticlePrices = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierArticlePricesCollectionEditor<SupplierArticleVMEntityView,SupplierArticleDeliveryView>,SupplierArticleVMEntityView,SupplierArticleDeliveryView>( params_SupplierArticlePrices,this,Screen.SupplierArticleDeliveryView);
 
            CollectionInit params_SupplierArticleDeliverys = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="22ac5ef3-aed2-41a0-b766-8e8438ca2500",CSSSelectorGrid="",XPathGrid=""};
            SupplierArticleDeliverys = RPSControlFactory.RPSCreateCollectionWithGrid<SupplierArticleDeliverysCollectionEditor<SupplierArticleVMEntityView,SupplierArticleDeliveryView>,SupplierArticleVMEntityView,SupplierArticleDeliveryView>( params_SupplierArticleDeliverys,this,Screen.SupplierArticleDeliveryView);
 
            GeneralData = RPSControlFactory.CreateRPSSection<SupplierArticleVMEntityView>( "","ul li[rpsid='2cb777ea-2142-484e-a7a9-67b9aa1ba1d8']","",this);
 
            SupplierArticleDelivery = RPSControlFactory.CreateRPSSection<SupplierArticleVMEntityView>( "","ul li[rpsid='68874a7d-dc7d-47c0-a07b-281a8a49f0d4']","",this);
 
            TechnicalDescription1 = RPSControlFactory.CreateRPSSection<SupplierArticleVMEntityView>( "","ul li[rpsid='0325d6d4-f85b-4e1b-96ef-170edcaaa635']","",this);
 

        }
        public IRPSSaveButton<SupplierArticleVMEntityView> SaveButton { get; set; } 
        public IRPSButton<SupplierArticleVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<SupplierArticleVMEntityView,SupplierArticleVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierArticleVMEntityView,SupplierArticleVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<SupplierArticleVMEntityView> IDArticle { get; set; } 
        public IRPSComboBox<SupplierArticleVMEntityView> IDSupplier { get; set; } 
        public IRPSCheckbox<SupplierArticleVMEntityView> Blocked { get; set; } 
        public IRPSCheckbox<SupplierArticleVMEntityView> PurchaseKit { get; set; } 
        public IRPSCheckbox<SupplierArticleVMEntityView> VAT { get; set; } 
        public IRPSTextBox<SupplierArticleVMEntityView> DescriptionSupplier { get; set; } 
        public IRPSTextBox<SupplierArticleVMEntityView> ReferenceSupplier { get; set; } 
        public IRPSComboBox<SupplierArticleVMEntityView> IDCurrency { get; set; } 
        public IRPSCheckbox<SupplierArticleVMEntityView> Default { get; set; } 
        public IRPSComboBox<SupplierArticleVMEntityView> IDArticleStructure { get; set; } 
        public IRPSTextBox<SupplierArticleVMEntityView> Ean13 { get; set; } 
        public IRPSComboBox<SupplierArticleVMEntityView> IDArticleContainer { get; set; } 
        public IRPSTextBox<SupplierArticleVMEntityView> TechnicalDescription { get; set; } 
        public IRPSButton<SupplierArticleVMEntityView> DuplicateCommandButton { get; set; } 
        public SupplierArticlePricesCollectionEditor<SupplierArticleVMEntityView,SupplierArticleDeliveryView> SupplierArticlePrices { get; set; } 
        public SupplierArticleDeliverysCollectionEditor<SupplierArticleVMEntityView,SupplierArticleDeliveryView> SupplierArticleDeliverys { get; set; } 
        public IRPSSection<SupplierArticleVMEntityView> GeneralData { get; set; } 
        public IRPSSection<SupplierArticleVMEntityView> SupplierArticleDelivery { get; set; } 
        public IRPSSection<SupplierArticleVMEntityView> TechnicalDescription1 { get; set; } 
        public SupplierArticle Screen { get; set; }
        public SupplierArticleVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SupplierArticlePricesCollectionEditor<SupplierArticleVMEntityView,SupplierArticleDeliveryView>:RPSCollectionEditor<SupplierArticleVMEntityView,SupplierArticleDeliveryView> where SupplierArticleVMEntityView : class, IView where SupplierArticleDeliveryView : class, IView
    {
        public  SupplierArticlePricesGridView<SupplierArticleVMEntityView,SupplierArticleDeliveryView> GridView {get;set;}
    }
    public partial class SupplierArticlePricesGridView <SupplierArticleVMEntityView,SupplierArticleDeliveryView> :  RPSGridView<SupplierArticleVMEntityView,SupplierArticleDeliveryView> where SupplierArticleVMEntityView : class, IView where SupplierArticleDeliveryView : class, IView
    {
        public SupplierArticlePricesGridView(SupplierArticleVMEntityView currentView,SupplierArticleDeliveryView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<SupplierArticleVMEntityView>("","#e6d1e724-4ec4-4e85-8330-879723b7ec7d .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",true, this.CurrentView);
 
            DateTo = RPSControlFactory.CreateRPSGridTextBox<SupplierArticleVMEntityView>("","#e6d1e724-4ec4-4e85-8330-879723b7ec7d .ag-row[role='row']@ROWINDEX [col-id='cDateTo']","",true, this.CurrentView);
 
            QuantityFrom = RPSControlFactory.CreateRPSGridFormattedTextBox<SupplierArticleVMEntityView>("","#e6d1e724-4ec4-4e85-8330-879723b7ec7d .ag-row[role='row']@ROWINDEX [col-id='cQuantityFrom']","",true, this.CurrentView);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSGridComboBox<SupplierArticleVMEntityView>("","#e6d1e724-4ec4-4e85-8330-879723b7ec7d .ag-row[role='row']@ROWINDEX [col-id='cIDUnitQuantity']","",true, this.CurrentView);
 
            Price = RPSControlFactory.CreateRPSGridFormattedTextBox<SupplierArticleVMEntityView>("","#e6d1e724-4ec4-4e85-8330-879723b7ec7d .ag-row[role='row']@ROWINDEX [col-id='cPrice']","",true, this.CurrentView);
 
            NetPrice = RPSControlFactory.CreateRPSGridFormattedTextBox<SupplierArticleVMEntityView>("","#e6d1e724-4ec4-4e85-8330-879723b7ec7d .ag-row[role='row']@ROWINDEX [col-id='cNetPrice']","",false, this.CurrentView);
 
            IDUnitPrice = RPSControlFactory.CreateRPSGridComboBox<SupplierArticleVMEntityView>("","#e6d1e724-4ec4-4e85-8330-879723b7ec7d .ag-row[role='row']@ROWINDEX [col-id='cIDUnitPrice']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<SupplierArticleVMEntityView> DateFrom { get; set; } 
        public IRPSGridTextBox<SupplierArticleVMEntityView> DateTo { get; set; } 
        public IRPSGridTextBox<SupplierArticleVMEntityView> QuantityFrom { get; set; } 
        public IRPSGridComboBox<SupplierArticleVMEntityView> IDUnitQuantity { get; set; } 
        public IRPSGridTextBox<SupplierArticleVMEntityView> Price { get; set; } 
        public IRPSGridTextBox<SupplierArticleVMEntityView> NetPrice { get; set; } 
        public IRPSGridComboBox<SupplierArticleVMEntityView> IDUnitPrice { get; set; } 
                     
    }
 
        public partial class SupplierArticleDeliverysCollectionEditor<SupplierArticleVMEntityView,SupplierArticleDeliveryView>:RPSCollectionEditor<SupplierArticleVMEntityView,SupplierArticleDeliveryView> where SupplierArticleVMEntityView : class, IView where SupplierArticleDeliveryView : class, IView
    {
        public  SupplierArticleDeliverysGridView<SupplierArticleVMEntityView,SupplierArticleDeliveryView> GridView {get;set;}
    }
    public partial class SupplierArticleDeliverysGridView <SupplierArticleVMEntityView,SupplierArticleDeliveryView> :  RPSGridView<SupplierArticleVMEntityView,SupplierArticleDeliveryView> where SupplierArticleVMEntityView : class, IView where SupplierArticleDeliveryView : class, IView
    {
        public SupplierArticleDeliverysGridView(SupplierArticleVMEntityView currentView,SupplierArticleDeliveryView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDUnitQuantity = RPSControlFactory.CreateRPSGridComboBox<SupplierArticleVMEntityView>("","#22ac5ef3-aed2-41a0-b766-8e8438ca2500 .ag-row[role='row']@ROWINDEX [col-id='cIDUnitQuantity']","",true, this.CurrentView);
 
            QuantityFrom = RPSControlFactory.CreateRPSGridFormattedTextBox<SupplierArticleVMEntityView>("","#22ac5ef3-aed2-41a0-b766-8e8438ca2500 .ag-row[role='row']@ROWINDEX [col-id='cQuantityFrom']","",true, this.CurrentView);
 
            DeliveryDays = RPSControlFactory.CreateRPSGridFormattedTextBox<SupplierArticleVMEntityView>("","#22ac5ef3-aed2-41a0-b766-8e8438ca2500 .ag-row[role='row']@ROWINDEX [col-id='cDeliveryDays']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<SupplierArticleVMEntityView> IDUnitQuantity { get; set; } 
        public IRPSGridTextBox<SupplierArticleVMEntityView> QuantityFrom { get; set; } 
        public IRPSGridTextBox<SupplierArticleVMEntityView> DeliveryDays { get; set; } 
                     
    }
 
    }
  
            
    public partial class SupplierArticlePriceView : View
    {
        public SupplierArticlePriceView(SupplierArticle screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierArticlePriceView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierArticlePriceView,SupplierArticleVMEntityView>( this,Screen.SupplierArticleVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierArticlePriceView,SupplierArticleVMEntityView>( this,Screen.SupplierArticleVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SupplierArticlePriceView,SupplierArticleVMEntityView>( this,Screen.SupplierArticleVMEntityView);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<SupplierArticlePriceView>("724e43a5-10cd-43a7-af13-dcad419e50f5","","",true, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<SupplierArticlePriceView>("2ab76758-81d2-4070-8688-fdeaf4f59f15","","",true, this);
 
            QuantityFrom = RPSControlFactory.CreateRPSFormattedTextBox<SupplierArticlePriceView>("feddc1ab-337f-410a-874d-5ef4cac4ddc0","","",true, this);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSComboBox<SupplierArticlePriceView>("6102f6fb-c5dd-47bd-b0f0-ba654c35ba3b","","",true, this);
 
            Price = RPSControlFactory.CreateRPSFormattedTextBox<SupplierArticlePriceView>("e0b92dd6-4cdf-45dc-9cdb-361c8bcc7a99","","",true, this);
 
            IDUnitPrice = RPSControlFactory.CreateRPSComboBox<SupplierArticlePriceView>("adfa615e-3d27-4c32-b780-88d6bd891a28","","",true, this);
 
            PurchaseLot = RPSControlFactory.CreateRPSFormattedTextBox<SupplierArticlePriceView>("8ec94736-af17-4425-bc23-6f264a0eb7ba","","",true, this);
 
            MinimumLot = RPSControlFactory.CreateRPSFormattedTextBox<SupplierArticlePriceView>("2b05b11f-a56e-41b8-b7cb-fc641576c538","","",true, this);
 
            NetPrice = RPSControlFactory.CreateRPSFormattedTextBox<SupplierArticlePriceView>("a267792d-539a-4c68-8fbf-182042152619","","",false, this);
 
            CodSupplierRFQ = RPSControlFactory.CreateRPSTextBox<SupplierArticlePriceView>("89098eed-f73d-47d7-8378-0876db542fd0","","",false, this);
 
            Offer = RPSControlFactory.CreateRPSCheckBox<SupplierArticlePriceView>("38df738c-c10f-45bf-8e21-7ac8afebeab1","","",true, this);
 
            Discount1 = RPSControlFactory.CreateRPSFormattedTextBox<SupplierArticlePriceView>("7a13f452-da2a-4009-afba-4e64095f6c71","","",true, this);
 
            CascadeDiscount1 = RPSControlFactory.CreateRPSCheckBox<SupplierArticlePriceView>("f4743d22-9168-48c5-ad8c-ada64445a5e3","","",true, this);
 
            Discount2 = RPSControlFactory.CreateRPSFormattedTextBox<SupplierArticlePriceView>("27bbff4e-63ac-42f2-ac9e-971ff06feea3","","",true, this);
 
            CascadeDiscount2 = RPSControlFactory.CreateRPSCheckBox<SupplierArticlePriceView>("3b8b75c1-162f-4d01-85cc-4210ed1eddf1","","",true, this);
 
            Discount3 = RPSControlFactory.CreateRPSFormattedTextBox<SupplierArticlePriceView>("e92e86d9-71e6-46c3-ad4f-dacc73f1ffb9","","",true, this);
 
            CascadeDiscount3 = RPSControlFactory.CreateRPSCheckBox<SupplierArticlePriceView>("01c31871-b3de-44e8-b60b-6d5c1d4fe71e","","",true, this);
 
            Discount4 = RPSControlFactory.CreateRPSFormattedTextBox<SupplierArticlePriceView>("5e48a617-f3bf-4f74-abc7-2962be11916d","","",true, this);
 
            CascadeDiscount4 = RPSControlFactory.CreateRPSCheckBox<SupplierArticlePriceView>("145668cc-f962-4c2c-aa3a-f2a0923158e6","","",true, this);
 
            Discount5 = RPSControlFactory.CreateRPSFormattedTextBox<SupplierArticlePriceView>("1901608b-8ad2-43f7-8495-0ce23698c3b2","","",true, this);
 
            CascadeDiscount5 = RPSControlFactory.CreateRPSCheckBox<SupplierArticlePriceView>("92c9623c-8852-49eb-aabe-a9bce9ca10b6","","",true, this);
 
            AmountDiscount = RPSControlFactory.CreateRPSFormattedTextBox<SupplierArticlePriceView>("890b8746-c035-4a4f-9b0e-44d06a5dae83","","",true, this);
 
            PositionAmountDiscount = RPSControlFactory.CreateRPSEnumComboBox<SupplierArticlePriceView>("f5150fd4-a002-4e00-bb93-cd2743805605","","",true, this);
 
            ApplyConditionsAffectDocument = RPSControlFactory.CreateRPSCheckBox<SupplierArticlePriceView>("16c68ceb-c5f8-4595-8964-8801de41bd47","","",true, this);
 
            ApplyConditionsNotAffectDocument = RPSControlFactory.CreateRPSCheckBox<SupplierArticlePriceView>("238b1264-3f07-4428-8ffc-9169dcbf88fc","","",true, this);
 

        }
        public IRPSButton<SupplierArticlePriceView> DeleteButton { get; set; } 
        public IRPSButton<SupplierArticlePriceView,SupplierArticleVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierArticlePriceView,SupplierArticleVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<SupplierArticlePriceView,SupplierArticleVMEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<SupplierArticlePriceView> DateFrom { get; set; } 
        public IRPSTextBox<SupplierArticlePriceView> DateTo { get; set; } 
        public IRPSTextBox<SupplierArticlePriceView> QuantityFrom { get; set; } 
        public IRPSComboBox<SupplierArticlePriceView> IDUnitQuantity { get; set; } 
        public IRPSTextBox<SupplierArticlePriceView> Price { get; set; } 
        public IRPSComboBox<SupplierArticlePriceView> IDUnitPrice { get; set; } 
        public IRPSTextBox<SupplierArticlePriceView> PurchaseLot { get; set; } 
        public IRPSTextBox<SupplierArticlePriceView> MinimumLot { get; set; } 
        public IRPSTextBox<SupplierArticlePriceView> NetPrice { get; set; } 
        public IRPSTextBox<SupplierArticlePriceView> CodSupplierRFQ { get; set; } 
        public IRPSCheckbox<SupplierArticlePriceView> Offer { get; set; } 
        public IRPSTextBox<SupplierArticlePriceView> Discount1 { get; set; } 
        public IRPSCheckbox<SupplierArticlePriceView> CascadeDiscount1 { get; set; } 
        public IRPSTextBox<SupplierArticlePriceView> Discount2 { get; set; } 
        public IRPSCheckbox<SupplierArticlePriceView> CascadeDiscount2 { get; set; } 
        public IRPSTextBox<SupplierArticlePriceView> Discount3 { get; set; } 
        public IRPSCheckbox<SupplierArticlePriceView> CascadeDiscount3 { get; set; } 
        public IRPSTextBox<SupplierArticlePriceView> Discount4 { get; set; } 
        public IRPSCheckbox<SupplierArticlePriceView> CascadeDiscount4 { get; set; } 
        public IRPSTextBox<SupplierArticlePriceView> Discount5 { get; set; } 
        public IRPSCheckbox<SupplierArticlePriceView> CascadeDiscount5 { get; set; } 
        public IRPSTextBox<SupplierArticlePriceView> AmountDiscount { get; set; } 
        public IRPSComboBox<SupplierArticlePriceView> PositionAmountDiscount { get; set; } 
        public IRPSCheckbox<SupplierArticlePriceView> ApplyConditionsAffectDocument { get; set; } 
        public IRPSCheckbox<SupplierArticlePriceView> ApplyConditionsNotAffectDocument { get; set; } 
        public SupplierArticle Screen { get; set; }
        public SupplierArticlePriceView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class SupplierArticleDeliveryView : View
    {
        public SupplierArticleDeliveryView(SupplierArticle screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<SupplierArticleDeliveryView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<SupplierArticleDeliveryView,SupplierArticleVMEntityView>( this,Screen.SupplierArticleVMEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<SupplierArticleDeliveryView,SupplierArticleVMEntityView>( this,Screen.SupplierArticleVMEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<SupplierArticleDeliveryView,SupplierArticleVMEntityView>( this,Screen.SupplierArticleVMEntityView);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSComboBox<SupplierArticleDeliveryView>("64c95c98-e512-4b45-8aef-091c6f9ec5d4","","",true, this);
 
            QuantityFrom = RPSControlFactory.CreateRPSFormattedTextBox<SupplierArticleDeliveryView>("ab183bbc-e9ab-4f5e-9da6-26057330e9b3","","",true, this);
 
            DeliveryDays = RPSControlFactory.CreateRPSFormattedTextBox<SupplierArticleDeliveryView>("0611791f-14eb-443e-86d2-b32bca58e5b6","","",true, this);
 

        }
        public IRPSButton<SupplierArticleDeliveryView> DeleteButton { get; set; } 
        public IRPSButton<SupplierArticleDeliveryView,SupplierArticleVMEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<SupplierArticleDeliveryView,SupplierArticleVMEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<SupplierArticleDeliveryView,SupplierArticleVMEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<SupplierArticleDeliveryView> IDUnitQuantity { get; set; } 
        public IRPSTextBox<SupplierArticleDeliveryView> QuantityFrom { get; set; } 
        public IRPSTextBox<SupplierArticleDeliveryView> DeliveryDays { get; set; } 
        public SupplierArticle Screen { get; set; }
        public SupplierArticleDeliveryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}