    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.PriceListProcess
{
    //RPS VERSION 1.0.0.0
    public partial class PriceListProcess:Screen
    {
        public PriceListProcess():base()
        {
            this.URL = "sales.pricelistprocess";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            PriceListProcessView  = new PriceListProcessView(this); 
            PriceListSLView  = new PriceListSLView(this); 
            PriceListProcessView.InitializeControls(); 
            PriceListSLView.InitializeControls(); 
           
        }
      
            public PriceListProcessView PriceListProcessView {get; set; } 
            public PriceListSLView PriceListSLView {get; set; } 
    }
            
    public partial class PriceListProcessView : View
    {
        public PriceListProcessView(PriceListProcess screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewPriceList = RPSControlFactory.CreateRPSOption<PriceListProcessView>( "29ac50c7-e221-4203-b9ca-cb4faa797ba3","","",this);
 
            AddPriceListDetails = RPSControlFactory.CreateRPSOption<PriceListProcessView>( "5603c2f9-c394-4a10-92b2-29b63893a584","","",this);
 
            ModifyPriceList = RPSControlFactory.CreateRPSOption<PriceListProcessView>( "111320ad-ab05-48f2-865b-b370a443dd6b","","",this);
 
            EnlargeDates = RPSControlFactory.CreateRPSOption<PriceListProcessView>( "5f53b128-0480-4d8b-9c03-cc386b9d1e79","","",this);
 
            CostPrices = RPSControlFactory.CreateRPSOption<PriceListProcessView>( "fdf1ca0e-7cc0-4c95-b218-0f85f4580411","","",this);
 
            AveragePrice = RPSControlFactory.CreateRPSOption<PriceListProcessView>( "6255a32a-b43f-4e8a-b674-06ff1b764f29","","",this);
 
            ManufacturingPrice = RPSControlFactory.CreateRPSOption<PriceListProcessView>( "efba8640-79f3-463e-a11a-4f53e117bb24","","",this);
 
            PurchasePrice = RPSControlFactory.CreateRPSOption<PriceListProcessView>( "a28edfff-ba1c-489b-87eb-95ab66eca434","","",this);
 
            StandardPrice = RPSControlFactory.CreateRPSOption<PriceListProcessView>( "9ca12d85-f03e-4b78-bb3c-f0a94a4e76e9","","",this);
 
            SupplierArticlePrices = RPSControlFactory.CreateRPSOption<PriceListProcessView>( "0b378795-1e26-44d8-aca7-afc7adc1152b","","",this);
 
            OtherPriceList = RPSControlFactory.CreateRPSOption<PriceListProcessView>( "9592ad9e-73a2-40d7-a6e7-e73298e939c8","","",this);
 
            IDOriginPriceList = RPSControlFactory.CreateRPSComboBox<PriceListProcessView>("412ee985-1457-46fc-83be-9492a0402739","","",false, this);
 
            Supplier = RPSControlFactory.CreateRPSComboBox<PriceListProcessView>("f046ec5b-e0c7-449b-bd27-e6bff988ba68","","",false, this);
 
            Select = RPSControlFactory.CreateRPSOption<PriceListProcessView>( "6d67f384-5615-4b73-8ac8-16f739ac6a22","","",this);
 
            OriginDateFrom = RPSControlFactory.CreateRPSTextBox<PriceListProcessView>("97c1aa9c-97c5-4c03-95d0-306386754276","","",false, this);
 
            OriginDateTo = RPSControlFactory.CreateRPSTextBox<PriceListProcessView>("4e1f72ff-6ddf-4baf-9212-1bd2de10386c","","",false, this);
 
            validity = RPSControlFactory.CreateRPSOption<PriceListProcessView>( "593d6a27-e436-4c54-90a0-dd99364793f1","","",this);
 
            Originvalidity = RPSControlFactory.CreateRPSTextBox<PriceListProcessView>("34003e0d-775c-4779-ae9b-277d4277eb2c","","",false, this);
 
            ProductLines = RPSControlFactory.CreateRPSCollectionComboBox<PriceListProcessView>("1853cb2d-bb39-4602-9153-359b434f0e68","","",false, this);
 
            ProductFamilies = RPSControlFactory.CreateRPSCollectionComboBox<PriceListProcessView>("ec54e751-8c40-41a2-ac28-f00da11bf64f","","",false, this);
 
            ProductSubFamilies = RPSControlFactory.CreateRPSCollectionComboBox<PriceListProcessView>("a23fbd1a-862b-4ebd-ba58-e2b0baf3522f","","",false, this);
 
            Articles = RPSControlFactory.CreateRPSCollectionComboBox<PriceListProcessView>("c327d948-e914-4a04-b5a6-e32fe43f081e","","",false, this);
 
            NewPriceListCode = RPSControlFactory.CreateRPSTextBox<PriceListProcessView>("1bec669d-b9a3-4a88-98d4-211c75a5a5ff","","",false, this);
 
            NewPriceListDescription = RPSControlFactory.CreateRPSTextBox<PriceListProcessView>("68f1ea38-5066-4b0a-852e-e2f00b2f8ccc","","",false, this);
 
            NewPriceListWithVat = RPSControlFactory.CreateRPSCheckBox<PriceListProcessView>("d669779a-92ef-4934-8011-ddba702b6b18","","",false, this);
 
            IDTargetPriceList = RPSControlFactory.CreateRPSComboBox<PriceListProcessView>("390f5c34-c04a-4551-be54-790e37c21962","","",false, this);
 
            NewPricesDateFrom = RPSControlFactory.CreateRPSTextBox<PriceListProcessView>("bdc80d71-dd26-48b4-b725-86e30e7f50d6","","",false, this);
 
            NewPricesDateTo = RPSControlFactory.CreateRPSTextBox<PriceListProcessView>("ad176cf2-22c4-4553-b27e-dc219a4355e2","","",false, this);
 
            Percentage = RPSControlFactory.CreateRPSOption<PriceListProcessView>( "ac09cc72-c20f-40fb-95b9-759c6953af7d","","",this);
 
            Amount = RPSControlFactory.CreateRPSOption<PriceListProcessView>( "c71a387f-bccb-446e-b7d2-51fa2d652832","","",this);
 
            Price = RPSControlFactory.CreateRPSFormattedTextBox<PriceListProcessView>("b7f5ac5a-b16b-44e6-bf25-30dd50e134f5","","",false, this);
 
            PricePercentage = RPSControlFactory.CreateRPSFormattedTextBox<PriceListProcessView>("ee213190-8ee7-410f-aaba-9034629e9225","","",false, this);
 
            None = RPSControlFactory.CreateRPSOption<PriceListProcessView>( "f6344d26-6c0e-4d4c-9ba0-f4c1cd85b3c9","","",this);
 
            _0 = RPSControlFactory.CreateRPSOption<PriceListProcessView>( "918071c1-1664-4462-9e83-5159333e439e","","",this);
 
            _1 = RPSControlFactory.CreateRPSOption<PriceListProcessView>( "cd90d4ce-761b-4cc0-b14e-5cd08016ef27","","",this);
 
            _2 = RPSControlFactory.CreateRPSOption<PriceListProcessView>( "9033e7c8-c8a4-445e-a8a8-2b6d4daa5401","","",this);
 
            _3 = RPSControlFactory.CreateRPSOption<PriceListProcessView>( "f93a4afb-1951-485d-b943-866427d85775","","",this);
 
            _4 = RPSControlFactory.CreateRPSOption<PriceListProcessView>( "e85b55d5-2034-4aa0-97d2-cf61d68855d3","","",this);
 
            _5 = RPSControlFactory.CreateRPSOption<PriceListProcessView>( "ba6d5179-0286-4cb4-8d94-85a2541b2dcf","","",this);
 
            UIEnlargeDate = RPSControlFactory.CreateRPSTextBox<PriceListProcessView>("5528d9a0-c60c-4161-a6d3-78d9652943ba","","",false, this);
 

        }
        public IRPSOption<PriceListProcessView> NewPriceList { get; set; } 
        public IRPSOption<PriceListProcessView> AddPriceListDetails { get; set; } 
        public IRPSOption<PriceListProcessView> ModifyPriceList { get; set; } 
        public IRPSOption<PriceListProcessView> EnlargeDates { get; set; } 
        public IRPSOption<PriceListProcessView> CostPrices { get; set; } 
        public IRPSOption<PriceListProcessView> AveragePrice { get; set; } 
        public IRPSOption<PriceListProcessView> ManufacturingPrice { get; set; } 
        public IRPSOption<PriceListProcessView> PurchasePrice { get; set; } 
        public IRPSOption<PriceListProcessView> StandardPrice { get; set; } 
        public IRPSOption<PriceListProcessView> SupplierArticlePrices { get; set; } 
        public IRPSOption<PriceListProcessView> OtherPriceList { get; set; } 
        public IRPSComboBox<PriceListProcessView> IDOriginPriceList { get; set; } 
        public IRPSComboBox<PriceListProcessView> Supplier { get; set; } 
        public IRPSOption<PriceListProcessView> Select { get; set; } 
        public IRPSTextBox<PriceListProcessView> OriginDateFrom { get; set; } 
        public IRPSTextBox<PriceListProcessView> OriginDateTo { get; set; } 
        public IRPSOption<PriceListProcessView> validity { get; set; } 
        public IRPSTextBox<PriceListProcessView> Originvalidity { get; set; } 
        public IRPSCollectionComboBox<PriceListProcessView> ProductLines { get; set; } 
        public IRPSCollectionComboBox<PriceListProcessView> ProductFamilies { get; set; } 
        public IRPSCollectionComboBox<PriceListProcessView> ProductSubFamilies { get; set; } 
        public IRPSCollectionComboBox<PriceListProcessView> Articles { get; set; } 
        public IRPSTextBox<PriceListProcessView> NewPriceListCode { get; set; } 
        public IRPSTextBox<PriceListProcessView> NewPriceListDescription { get; set; } 
        public IRPSCheckbox<PriceListProcessView> NewPriceListWithVat { get; set; } 
        public IRPSComboBox<PriceListProcessView> IDTargetPriceList { get; set; } 
        public IRPSTextBox<PriceListProcessView> NewPricesDateFrom { get; set; } 
        public IRPSTextBox<PriceListProcessView> NewPricesDateTo { get; set; } 
        public IRPSOption<PriceListProcessView> Percentage { get; set; } 
        public IRPSOption<PriceListProcessView> Amount { get; set; } 
        public IRPSTextBox<PriceListProcessView> Price { get; set; } 
        public IRPSTextBox<PriceListProcessView> PricePercentage { get; set; } 
        public IRPSOption<PriceListProcessView> None { get; set; } 
        public IRPSOption<PriceListProcessView> _0 { get; set; } 
        public IRPSOption<PriceListProcessView> _1 { get; set; } 
        public IRPSOption<PriceListProcessView> _2 { get; set; } 
        public IRPSOption<PriceListProcessView> _3 { get; set; } 
        public IRPSOption<PriceListProcessView> _4 { get; set; } 
        public IRPSOption<PriceListProcessView> _5 { get; set; } 
        public IRPSTextBox<PriceListProcessView> UIEnlargeDate { get; set; } 
        public PriceListProcess Screen { get; set; }
        public PriceListProcessView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PriceListSLView : View
    {
        public PriceListSLView(PriceListProcess screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<PriceListSLView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<PriceListSLView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<PriceListSLView,PriceListProcessView>( this,Screen.PriceListProcessView);
 
            BackButton = RPSControlFactory.RPSBackButton<PriceListSLView,PriceListProcessView>( this,Screen.PriceListProcessView);
 
            CollectionInit params_PriceListDetailSLs = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="2932c7e6-abd5-4fb5-bcc7-e7b281405a0e",CSSSelectorGrid="",XPathGrid=""};
            PriceListDetailSLs = RPSControlFactory.RPSCreateCollectionWithGrid<PriceListDetailSLsCollectionEditor<PriceListSLView>,PriceListSLView>( params_PriceListDetailSLs,this);
 

        }
        public IRPSSaveButton<PriceListSLView> SaveButton { get; set; } 
        public IRPSButton<PriceListSLView> DeleteButton { get; set; } 
        public IRPSButton<PriceListSLView,PriceListProcessView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<PriceListSLView,PriceListProcessView> BackButton { get; set; } 
        public PriceListDetailSLsCollectionEditor<PriceListSLView> PriceListDetailSLs { get; set; } 
        public PriceListProcess Screen { get; set; }
        public PriceListSLView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class PriceListDetailSLsCollectionEditor<PriceListSLView>:RPSCollectionEditor<PriceListSLView> where PriceListSLView : class, IView
    {
        public  PriceListDetailSLsGridView<PriceListSLView> GridView {get;set;}
    }
    public partial class PriceListDetailSLsGridView <PriceListSLView> :  RPSGridView<PriceListSLView> where PriceListSLView : class, IView
    {
        public PriceListDetailSLsGridView(PriceListSLView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<PriceListSLView>("","#2932c7e6-abd5-4fb5-bcc7-e7b281405a0e .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<PriceListSLView>("","#2932c7e6-abd5-4fb5-bcc7-e7b281405a0e .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",true, this.CurrentView);
 
            DateTo = RPSControlFactory.CreateRPSGridTextBox<PriceListSLView>("","#2932c7e6-abd5-4fb5-bcc7-e7b281405a0e .ag-row[role='row']@ROWINDEX [col-id='cDateTo']","",true, this.CurrentView);
 
            QuantityFrom = RPSControlFactory.CreateRPSGridFormattedTextBox<PriceListSLView>("","#2932c7e6-abd5-4fb5-bcc7-e7b281405a0e .ag-row[role='row']@ROWINDEX [col-id='cQuantityFrom']","",true, this.CurrentView);
 
            IDUnitQuantity = RPSControlFactory.CreateRPSGridComboBox<PriceListSLView>("","#2932c7e6-abd5-4fb5-bcc7-e7b281405a0e .ag-row[role='row']@ROWINDEX [col-id='cIDUnitQuantity']","",true, this.CurrentView);
 
            Price = RPSControlFactory.CreateRPSGridFormattedTextBox<PriceListSLView>("","#2932c7e6-abd5-4fb5-bcc7-e7b281405a0e .ag-row[role='row']@ROWINDEX [col-id='cPrice']","",true, this.CurrentView);
 
            IDUnitPrice = RPSControlFactory.CreateRPSGridComboBox<PriceListSLView>("","#2932c7e6-abd5-4fb5-bcc7-e7b281405a0e .ag-row[role='row']@ROWINDEX [col-id='cIDUnitPrice']","",true, this.CurrentView);
 
            Offer = RPSControlFactory.CreateRPSGridCheckBox<PriceListSLView>("","#2932c7e6-abd5-4fb5-bcc7-e7b281405a0e .ag-row[role='row']@ROWINDEX [col-id='cOffer']","",true, this.CurrentView);
 
            ApplyConditionsAffectDocument = RPSControlFactory.CreateRPSGridCheckBox<PriceListSLView>("","#2932c7e6-abd5-4fb5-bcc7-e7b281405a0e .ag-row[role='row']@ROWINDEX [col-id='cApplyConditionsAffectDocument']","",true, this.CurrentView);
 
            ApplyConditionsNotAffectDocument = RPSControlFactory.CreateRPSGridCheckBox<PriceListSLView>("","#2932c7e6-abd5-4fb5-bcc7-e7b281405a0e .ag-row[role='row']@ROWINDEX [col-id='cApplyConditionsNotAffectDocument']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<PriceListSLView> IDArticle { get; set; } 
        public IRPSGridTextBox<PriceListSLView> DateFrom { get; set; } 
        public IRPSGridTextBox<PriceListSLView> DateTo { get; set; } 
        public IRPSGridTextBox<PriceListSLView> QuantityFrom { get; set; } 
        public IRPSGridComboBox<PriceListSLView> IDUnitQuantity { get; set; } 
        public IRPSGridTextBox<PriceListSLView> Price { get; set; } 
        public IRPSGridComboBox<PriceListSLView> IDUnitPrice { get; set; } 
        public IRPSGridCheckbox<PriceListSLView> Offer { get; set; } 
        public IRPSGridCheckbox<PriceListSLView> ApplyConditionsAffectDocument { get; set; } 
        public IRPSGridCheckbox<PriceListSLView> ApplyConditionsNotAffectDocument { get; set; } 
                     
    }
 
    }
  
    

}