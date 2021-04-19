    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.ManufacturingOrderEntryExit
{
    //RPS VERSION 1.0.0.0
    public partial class ManufacturingOrderEntryExit:Screen
    {
        public ManufacturingOrderEntryExit():base()
        {
            this.URL = "manufacturing.manufacturingorderentryexit";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ManufacturingOrderEntryExitView  = new ManufacturingOrderEntryExitView(this); 
            ManufacturingOrderEntryExitView.InitializeControls(); 
           
        }
      
            public ManufacturingOrderEntryExitView ManufacturingOrderEntryExitView {get; set; } 
    }
            
    public partial class ManufacturingOrderEntryExitView : View
    {
        public ManufacturingOrderEntryExitView(ManufacturingOrderEntryExit screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            StorageManufacturingOrder = RPSControlFactory.CreateRPSComboBox<ManufacturingOrderEntryExitView>("728ff865-661d-4f50-87eb-91e929476d62","","",false, this);
 
            StorageArticle = RPSControlFactory.CreateRPSComboBox<ManufacturingOrderEntryExitView>("37f0699c-2cae-4f33-a6f2-ae4be4a588b5","","",false, this);
 
            StorageQuantity = RPSControlFactory.CreateRPSFormattedTextBox<ManufacturingOrderEntryExitView>("cb171539-f4ba-460a-a0d6-e94219117fc8","","",false, this);
 
            EntryQuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<ManufacturingOrderEntryExitView>("0863f7f1-bef9-4f4a-810d-b9a0d1f6ec4f","","",false, this);
 
            EntryPrice = RPSControlFactory.CreateRPSFormattedTextBox<ManufacturingOrderEntryExitView>("e6725658-c141-498a-8fa0-d2fafceeca22","","",false, this);
 
            EntryExpiryDate = RPSControlFactory.CreateRPSTextBox<ManufacturingOrderEntryExitView>("9528f6e2-6f96-42b0-b505-20130e48215d","","",false, this);
 
            EntryWareHouse = RPSControlFactory.CreateRPSComboBox<ManufacturingOrderEntryExitView>("22d78ca9-52a6-476a-832b-73725e3a5c5f","","",false, this);
 
            SeriesEntryProduct = RPSControlFactory.CreateRPSEnumComboBox<ManufacturingOrderEntryExitView>("1e44aeda-6b62-4d97-8d7b-e512acc476a5","","",false, this);
 
            ExecuteAddMOSeriesReserve = RPSControlFactory.CreateRPSButton<ManufacturingOrderEntryExitView>( "bc7c847b-05d0-4186-90f6-16c69b1933bf","","",this);
 
            EntryLocationWarehouse = RPSControlFactory.CreateRPSComboBox<ManufacturingOrderEntryExitView>("5bc03184-8c4f-4715-81b7-a5e72d5e0681","","",false, this);
 
            AddCommandButton = RPSControlFactory.CreateRPSButton<ManufacturingOrderEntryExitView>( "9de7716c-ea3c-462b-95aa-e69b104d9095","","",this);
 
            DeleteCommandButton = RPSControlFactory.CreateRPSButton<ManufacturingOrderEntryExitView>( "3483cd15-622d-4c93-ac2e-bdfbfb873799","","",this);
 
            AssignSeriesCommandButton = RPSControlFactory.CreateRPSButton<ManufacturingOrderEntryExitView>( "cbc66931-3215-44fd-90b8-07e723458c8d","","",this);
 
            IDMOTask = RPSControlFactory.CreateRPSComboBox<ManufacturingOrderEntryExitView>("86528778-1eaf-4729-8285-04d7b4816b56","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<ManufacturingOrderEntryExitView>("39f39a2d-970c-4bc6-90bf-9405fb92dc72","","",false, this);
 
            ImputationDate = RPSControlFactory.CreateRPSTextBox<ManufacturingOrderEntryExitView>("842337e8-5fb3-429c-a188-c3ca3a51c71f","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<ManufacturingOrderEntryExitView>("75eb2aa6-b219-4ee1-b7af-7a013d088384","","",false, this);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<ManufacturingOrderEntryExitView>("a1e2f201-a97c-485d-aaf3-5c114e3b0e5c","","",false, this);
 
            CostPriceReal = RPSControlFactory.CreateRPSFormattedTextBox<ManufacturingOrderEntryExitView>("659dffe2-1b0e-43fa-af24-dd2ca6cbccde","","",false, this);
 
            CostAmountReal = RPSControlFactory.CreateRPSFormattedTextBox<ManufacturingOrderEntryExitView>("5931f91c-ae1c-4f63-bbcf-f014c7fba348","","",false, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<ManufacturingOrderEntryExitView>("c5c690fa-8d10-48c6-99d7-bd403d64936a","","",false, this);
 
            Series = RPSControlFactory.CreateRPSEnumComboBox<ManufacturingOrderEntryExitView>("99b6241c-0229-44a6-a227-047b827d3e41","","",false, this);
 
            IDLocationWarehouse = RPSControlFactory.CreateRPSComboBox<ManufacturingOrderEntryExitView>("0a4d08ba-8521-45f0-8233-09db0f12eef5","","",false, this);
 
            SeriesEntryProduct1 = RPSControlFactory.CreateRPSEnumComboBox<ManufacturingOrderEntryExitView>("4396286e-ea78-46ab-ae83-ca4b04db962f","","",false, this);
 
            ExpiryDate = RPSControlFactory.CreateRPSTextBox<ManufacturingOrderEntryExitView>("7a07c5b2-cc79-4a2d-9812-1577c2cc4c96","","",false, this);
 
            DocumentNumber = RPSControlFactory.CreateRPSTextBox<ManufacturingOrderEntryExitView>("9be87267-4763-4432-ba4a-12305c9af522","","",false, this);
 
            IDMOMaterial = RPSControlFactory.CreateRPSComboBox<ManufacturingOrderEntryExitView>("39b43442-88a0-4da2-acb9-22c300981c76","","",false, this);
 
            AcceptCommand = RPSControlFactory.CreateRPSButton<ManufacturingOrderEntryExitView>( "276ab214-9bb1-425e-ab16-5b3a0ea12111","","",this);
 
            CancelCommand = RPSControlFactory.CreateRPSButton<ManufacturingOrderEntryExitView>( "52be865c-6853-4581-abd2-70e1ad74b8ac","","",this);
 
            CollectionInit params_NewModelCollection = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="db2344f8-4fde-4958-ad59-7c0f35f7dcda",CSSSelectorGrid="",XPathGrid=""};
            NewModelCollection = RPSControlFactory.RPSCreateCollectionWithGrid<NewModelCollectionCollectionEditor<ManufacturingOrderEntryExitView>,ManufacturingOrderEntryExitView>( params_NewModelCollection,this);
 

        }
        public IRPSComboBox<ManufacturingOrderEntryExitView> StorageManufacturingOrder { get; set; } 
        public IRPSComboBox<ManufacturingOrderEntryExitView> StorageArticle { get; set; } 
        public IRPSTextBox<ManufacturingOrderEntryExitView> StorageQuantity { get; set; } 
        public IRPSTextBox<ManufacturingOrderEntryExitView> EntryQuantitySecondUnit { get; set; } 
        public IRPSTextBox<ManufacturingOrderEntryExitView> EntryPrice { get; set; } 
        public IRPSTextBox<ManufacturingOrderEntryExitView> EntryExpiryDate { get; set; } 
        public IRPSComboBox<ManufacturingOrderEntryExitView> EntryWareHouse { get; set; } 
        public IRPSComboBox<ManufacturingOrderEntryExitView> SeriesEntryProduct { get; set; } 
        public IRPSButton<ManufacturingOrderEntryExitView> ExecuteAddMOSeriesReserve { get; set; } 
        public IRPSComboBox<ManufacturingOrderEntryExitView> EntryLocationWarehouse { get; set; } 
        public IRPSButton<ManufacturingOrderEntryExitView> AddCommandButton { get; set; } 
        public IRPSButton<ManufacturingOrderEntryExitView> DeleteCommandButton { get; set; } 
        public IRPSButton<ManufacturingOrderEntryExitView> AssignSeriesCommandButton { get; set; } 
        public IRPSComboBox<ManufacturingOrderEntryExitView> IDMOTask { get; set; } 
        public IRPSComboBox<ManufacturingOrderEntryExitView> IDArticle { get; set; } 
        public IRPSTextBox<ManufacturingOrderEntryExitView> ImputationDate { get; set; } 
        public IRPSTextBox<ManufacturingOrderEntryExitView> Quantity { get; set; } 
        public IRPSTextBox<ManufacturingOrderEntryExitView> QuantitySecondUnit { get; set; } 
        public IRPSTextBox<ManufacturingOrderEntryExitView> CostPriceReal { get; set; } 
        public IRPSTextBox<ManufacturingOrderEntryExitView> CostAmountReal { get; set; } 
        public IRPSComboBox<ManufacturingOrderEntryExitView> IDWarehouse { get; set; } 
        public IRPSComboBox<ManufacturingOrderEntryExitView> Series { get; set; } 
        public IRPSComboBox<ManufacturingOrderEntryExitView> IDLocationWarehouse { get; set; } 
        public IRPSComboBox<ManufacturingOrderEntryExitView> SeriesEntryProduct1 { get; set; } 
        public IRPSTextBox<ManufacturingOrderEntryExitView> ExpiryDate { get; set; } 
        public IRPSTextBox<ManufacturingOrderEntryExitView> DocumentNumber { get; set; } 
        public IRPSComboBox<ManufacturingOrderEntryExitView> IDMOMaterial { get; set; } 
        public IRPSButton<ManufacturingOrderEntryExitView> AcceptCommand { get; set; } 
        public IRPSButton<ManufacturingOrderEntryExitView> CancelCommand { get; set; } 
        public NewModelCollectionCollectionEditor<ManufacturingOrderEntryExitView> NewModelCollection { get; set; } 
        public ManufacturingOrderEntryExit Screen { get; set; }
        public ManufacturingOrderEntryExitView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class NewModelCollectionCollectionEditor<ManufacturingOrderEntryExitView>:RPSCollectionEditor<ManufacturingOrderEntryExitView> where ManufacturingOrderEntryExitView : class, IView
    {
        public  NewModelCollectionGridView<ManufacturingOrderEntryExitView> GridView {get;set;}
    }
    public partial class NewModelCollectionGridView <ManufacturingOrderEntryExitView> :  RPSGridView<ManufacturingOrderEntryExitView> where ManufacturingOrderEntryExitView : class, IView
    {
        public NewModelCollectionGridView(ManufacturingOrderEntryExitView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Save = RPSControlFactory.CreateRPSGridCheckBox<ManufacturingOrderEntryExitView>("","#db2344f8-4fde-4958-ad59-7c0f35f7dcda .ag-row[role='row']@ROWINDEX [col-id='cSave']","",false, this.CurrentView);
 
            IDMOTask = RPSControlFactory.CreateRPSGridComboBox<ManufacturingOrderEntryExitView>("","#db2344f8-4fde-4958-ad59-7c0f35f7dcda .ag-row[role='row']@ROWINDEX [col-id='cIDMOTask']","",false, this.CurrentView);
 
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<ManufacturingOrderEntryExitView>("","#db2344f8-4fde-4958-ad59-7c0f35f7dcda .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",false, this.CurrentView);
 
            ImputationDate = RPSControlFactory.CreateRPSGridTextBox<ManufacturingOrderEntryExitView>("","#db2344f8-4fde-4958-ad59-7c0f35f7dcda .ag-row[role='row']@ROWINDEX [col-id='cImputationDate']","",false, this.CurrentView);
 
            QuantityOriginal = RPSControlFactory.CreateRPSGridFormattedTextBox<ManufacturingOrderEntryExitView>("","#db2344f8-4fde-4958-ad59-7c0f35f7dcda .ag-row[role='row']@ROWINDEX [col-id='cQuantityOriginal']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<ManufacturingOrderEntryExitView>("","#db2344f8-4fde-4958-ad59-7c0f35f7dcda .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSGridFormattedTextBox<ManufacturingOrderEntryExitView>("","#db2344f8-4fde-4958-ad59-7c0f35f7dcda .ag-row[role='row']@ROWINDEX [col-id='cQuantitySecondUnit']","",false, this.CurrentView);
 
            CostPriceReal = RPSControlFactory.CreateRPSGridFormattedTextBox<ManufacturingOrderEntryExitView>("","#db2344f8-4fde-4958-ad59-7c0f35f7dcda .ag-row[role='row']@ROWINDEX [col-id='cCostPriceReal']","",false, this.CurrentView);
 
            CostAmountReal = RPSControlFactory.CreateRPSGridFormattedTextBox<ManufacturingOrderEntryExitView>("","#db2344f8-4fde-4958-ad59-7c0f35f7dcda .ag-row[role='row']@ROWINDEX [col-id='cCostAmountReal']","",false, this.CurrentView);
 
            IDWarehouse = RPSControlFactory.CreateRPSGridComboBox<ManufacturingOrderEntryExitView>("","#db2344f8-4fde-4958-ad59-7c0f35f7dcda .ag-row[role='row']@ROWINDEX [col-id='cIDWarehouse']","",false, this.CurrentView);
 
            Series = RPSControlFactory.CreateRPSGridEnumComboBox<ManufacturingOrderEntryExitView>("","#db2344f8-4fde-4958-ad59-7c0f35f7dcda .ag-row[role='row']@ROWINDEX [col-id='cSeries']","",false, this.CurrentView);
 
            IDLocationWarehouse = RPSControlFactory.CreateRPSGridComboBox<ManufacturingOrderEntryExitView>("","#db2344f8-4fde-4958-ad59-7c0f35f7dcda .ag-row[role='row']@ROWINDEX [col-id='cIDLocationWarehouse']","",false, this.CurrentView);
 
            DocumentNumber = RPSControlFactory.CreateRPSGridTextBox<ManufacturingOrderEntryExitView>("","#db2344f8-4fde-4958-ad59-7c0f35f7dcda .ag-row[role='row']@ROWINDEX [col-id='cDocumentNumber']","",false, this.CurrentView);
 
            SeriesEntryProduct = RPSControlFactory.CreateRPSGridEnumComboBox<ManufacturingOrderEntryExitView>("","#db2344f8-4fde-4958-ad59-7c0f35f7dcda .ag-row[role='row']@ROWINDEX [col-id='cSeriesEntryProduct']","",false, this.CurrentView);
 
            IDMOMaterial = RPSControlFactory.CreateRPSGridComboBox<ManufacturingOrderEntryExitView>("","#db2344f8-4fde-4958-ad59-7c0f35f7dcda .ag-row[role='row']@ROWINDEX [col-id='cIDMOMaterial']","",false, this.CurrentView);
 

        }
        public IRPSGridCheckbox<ManufacturingOrderEntryExitView> Save { get; set; } 
        public IRPSGridComboBox<ManufacturingOrderEntryExitView> IDMOTask { get; set; } 
        public IRPSGridComboBox<ManufacturingOrderEntryExitView> IDArticle { get; set; } 
        public IRPSGridTextBox<ManufacturingOrderEntryExitView> ImputationDate { get; set; } 
        public IRPSGridTextBox<ManufacturingOrderEntryExitView> QuantityOriginal { get; set; } 
        public IRPSGridTextBox<ManufacturingOrderEntryExitView> Quantity { get; set; } 
        public IRPSGridTextBox<ManufacturingOrderEntryExitView> QuantitySecondUnit { get; set; } 
        public IRPSGridTextBox<ManufacturingOrderEntryExitView> CostPriceReal { get; set; } 
        public IRPSGridTextBox<ManufacturingOrderEntryExitView> CostAmountReal { get; set; } 
        public IRPSGridComboBox<ManufacturingOrderEntryExitView> IDWarehouse { get; set; } 
        public IRPSGridComboBox<ManufacturingOrderEntryExitView> Series { get; set; } 
        public IRPSGridComboBox<ManufacturingOrderEntryExitView> IDLocationWarehouse { get; set; } 
        public IRPSGridTextBox<ManufacturingOrderEntryExitView> DocumentNumber { get; set; } 
        public IRPSGridComboBox<ManufacturingOrderEntryExitView> SeriesEntryProduct { get; set; } 
        public IRPSGridComboBox<ManufacturingOrderEntryExitView> IDMOMaterial { get; set; } 
                     
    }
 
    }
  
    

}