    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Warehouse.WarehouseSeries
{
    //RPS VERSION 1.0.0.0
    public partial class WarehouseSeries:Screen
    {
        public WarehouseSeries():base()
        {
            this.URL = "warehouse.warehouseseries";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            WarehouseSeriesVMQueryView  = new WarehouseSeriesVMQueryView(this); 
            WarehouseSeriesVMEntityView  = new WarehouseSeriesVMEntityView(this); 
            WarehouseSeriesVMQueryView.InitializeControls(); 
            WarehouseSeriesVMEntityView.InitializeControls(); 
           
        }
      
            public WarehouseSeriesVMQueryView WarehouseSeriesVMQueryView {get; set; } 
            public WarehouseSeriesVMEntityView WarehouseSeriesVMEntityView {get; set; } 
    }
            
    public partial class WarehouseSeriesVMQueryView : View
    {
        public WarehouseSeriesVMQueryView(WarehouseSeries screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<WarehouseSeriesVMQueryView,WarehouseSeriesVMEntityView>( this,Screen.WarehouseSeriesVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<WarehouseSeriesVMQueryView>( this);
 
            ProductLine = RPSControlFactory.CreateRPSCollectionComboBox<WarehouseSeriesVMQueryView>("0b6409a6-f250-4125-a79d-3736a2767eb7","","",false, this);
 
            ProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<WarehouseSeriesVMQueryView>("8702d983-65a8-4f7d-8222-25cc82c79475","","",false, this);
 
            ProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<WarehouseSeriesVMQueryView>("77e6f49e-7ce7-400c-99df-08e614d10088","","",false, this);
 
            iArticle = RPSControlFactory.CreateRPSCollectionComboBox<WarehouseSeriesVMQueryView>("cfd260da-2245-4174-945a-d98c5c161d18","","",false, this);
 
            Site = RPSControlFactory.CreateRPSCollectionComboBox<WarehouseSeriesVMQueryView>("fee82055-a273-4a71-90ce-e4edd0877a98","","",false, this);
 
            WareHouse = RPSControlFactory.CreateRPSCollectionComboBox<WarehouseSeriesVMQueryView>("985b5dd3-8210-49d9-89b3-16451edf847b","","",false, this);
 
            Series = RPSControlFactory.CreateRPSEnumComboBox<WarehouseSeriesVMQueryView>("031a72bf-d864-4bc9-9dfd-dbe89811231c","","",false, this);
 
            iStatusLot = RPSControlFactory.CreateRPSCollectionComboBox<WarehouseSeriesVMQueryView>("b20f1584-7f00-4d17-8d51-294b622aadc9","","",false, this);
 
            iniEntryDate = RPSControlFactory.CreateRPSTextBox<WarehouseSeriesVMQueryView>("ba543652-01cf-42fe-bd1b-7251d8b9f827","","",false, this);
 
            iniMovDate = RPSControlFactory.CreateRPSTextBox<WarehouseSeriesVMQueryView>("75820e12-1f93-4578-bc61-7a1ff728c4c2","","",false, this);
 
            endEntryDate = RPSControlFactory.CreateRPSTextBox<WarehouseSeriesVMQueryView>("b693e063-cbc0-4945-89ea-f0dc857c8abf","","",false, this);
 
            endMovDate = RPSControlFactory.CreateRPSTextBox<WarehouseSeriesVMQueryView>("cc839dd8-8403-4606-b497-8b73478de991","","",false, this);
 
            CollectionInit params_ArticleWarehouseSeriesQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="eb9c46a0-928a-4a6b-9005-8de28249a3fe",CSSSelectorGrid="",XPathGrid=""};
            ArticleWarehouseSeriesQuery = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleWarehouseSeriesQueryCollectionEditor<WarehouseSeriesVMQueryView,WarehouseSeriesVMEntityView>,WarehouseSeriesVMQueryView,WarehouseSeriesVMEntityView>( params_ArticleWarehouseSeriesQuery,this,Screen.WarehouseSeriesVMEntityView);
 

        }
        public IRPSButton<WarehouseSeriesVMQueryView,WarehouseSeriesVMEntityView> NewButton { get; set; } 
        public IRPSButton<WarehouseSeriesVMQueryView> ConsultButton { get; set; } 
        public IRPSCollectionComboBox<WarehouseSeriesVMQueryView> ProductLine { get; set; } 
        public IRPSCollectionComboBox<WarehouseSeriesVMQueryView> ProductFamily { get; set; } 
        public IRPSCollectionComboBox<WarehouseSeriesVMQueryView> ProductSubFamily { get; set; } 
        public IRPSCollectionComboBox<WarehouseSeriesVMQueryView> iArticle { get; set; } 
        public IRPSCollectionComboBox<WarehouseSeriesVMQueryView> Site { get; set; } 
        public IRPSCollectionComboBox<WarehouseSeriesVMQueryView> WareHouse { get; set; } 
        public IRPSComboBox<WarehouseSeriesVMQueryView> Series { get; set; } 
        public IRPSCollectionComboBox<WarehouseSeriesVMQueryView> iStatusLot { get; set; } 
        public IRPSTextBox<WarehouseSeriesVMQueryView> iniEntryDate { get; set; } 
        public IRPSTextBox<WarehouseSeriesVMQueryView> iniMovDate { get; set; } 
        public IRPSTextBox<WarehouseSeriesVMQueryView> endEntryDate { get; set; } 
        public IRPSTextBox<WarehouseSeriesVMQueryView> endMovDate { get; set; } 
        public ArticleWarehouseSeriesQueryCollectionEditor<WarehouseSeriesVMQueryView,WarehouseSeriesVMEntityView> ArticleWarehouseSeriesQuery { get; set; } 
        public WarehouseSeries Screen { get; set; }
        public WarehouseSeriesVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ArticleWarehouseSeriesQueryCollectionEditor<WarehouseSeriesVMQueryView,WarehouseSeriesVMEntityView>:RPSCollectionEditor<WarehouseSeriesVMQueryView,WarehouseSeriesVMEntityView> where WarehouseSeriesVMQueryView : class, IView where WarehouseSeriesVMEntityView : class, IView
    {
        public  ArticleWarehouseSeriesQueryGridView<WarehouseSeriesVMQueryView,WarehouseSeriesVMEntityView> GridView {get;set;}
    }
    public partial class ArticleWarehouseSeriesQueryGridView <WarehouseSeriesVMQueryView,WarehouseSeriesVMEntityView> :  RPSGridView<WarehouseSeriesVMQueryView,WarehouseSeriesVMEntityView> where WarehouseSeriesVMQueryView : class, IView where WarehouseSeriesVMEntityView : class, IView
    {
        public ArticleWarehouseSeriesQueryGridView(WarehouseSeriesVMQueryView currentView,WarehouseSeriesVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            WarehouseSeries_Series = RPSControlFactory.CreateRPSGridTextBox<WarehouseSeriesVMQueryView>("","#eb9c46a0-928a-4a6b-9005-8de28249a3fe .ag-row[role='row']@ROWINDEX [col-id='cWarehouseSeries_Series']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<WarehouseSeriesVMQueryView> WarehouseSeries_Series { get; set; } 
                     
    }
 
    }
  
            
    public partial class WarehouseSeriesVMEntityView : View
    {
        public WarehouseSeriesVMEntityView(WarehouseSeries screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<WarehouseSeriesVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<WarehouseSeriesVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<WarehouseSeriesVMEntityView,WarehouseSeriesVMQueryView>( this,Screen.WarehouseSeriesVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<WarehouseSeriesVMEntityView,WarehouseSeriesVMQueryView>( this,Screen.WarehouseSeriesVMQueryView);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<WarehouseSeriesVMEntityView>("8463a102-844e-4ee2-a3fb-c4dd325d7e54","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<WarehouseSeriesVMEntityView>("7d808637-83e5-4de2-8d79-3ed76e46a908","","",true, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<WarehouseSeriesVMEntityView>("c4f3345f-6b77-43b1-b7e9-9b16d1503fdc","","",true, this);
 
            Series = RPSControlFactory.CreateRPSTextBox<WarehouseSeriesVMEntityView>("d8044c3b-900d-447d-91ef-1881277becae","","",true, this);
 
            IDStatusLot = RPSControlFactory.CreateRPSComboBox<WarehouseSeriesVMEntityView>("283d87cd-cdaa-4cb9-9628-7543e9ea971f","","",false, this);
 
            ExpiryDate = RPSControlFactory.CreateRPSTextBox<WarehouseSeriesVMEntityView>("eb0e414e-7b16-4547-abbd-ec5161c0da5f","","",false, this);
 
            LastMovementDate = RPSControlFactory.CreateRPSTextBox<WarehouseSeriesVMEntityView>("762f9943-afef-4566-b7b5-8de7329d8778","","",true, this);
 
            LastEntryDate = RPSControlFactory.CreateRPSTextBox<WarehouseSeriesVMEntityView>("bff871e3-b220-464e-875c-e2abfa1e8452","","",true, this);
 
            PurchasePrice = RPSControlFactory.CreateRPSFormattedTextBox<WarehouseSeriesVMEntityView>("760d0eb3-5a10-45ea-a34f-9d1226d707b8","","",true, this);
 
            PurchaseDate = RPSControlFactory.CreateRPSTextBox<WarehouseSeriesVMEntityView>("8eb50b3d-42fd-4cde-a18b-ae0102158581","","",false, this);
 
            AveragePrice = RPSControlFactory.CreateRPSFormattedTextBox<WarehouseSeriesVMEntityView>("57401f4f-dedf-41d2-b166-cc09945d1027","","",true, this);
 
            ManufacturePrice = RPSControlFactory.CreateRPSFormattedTextBox<WarehouseSeriesVMEntityView>("91ceff8f-f07d-4b3c-8239-6fa227dcc297","","",true, this);
 
            ManufactureDate = RPSControlFactory.CreateRPSTextBox<WarehouseSeriesVMEntityView>("dc321d26-e55a-447d-a266-3cba904fd947","","",false, this);
 
            ReferenceSupplier = RPSControlFactory.CreateRPSTextBox<WarehouseSeriesVMEntityView>("2496d29b-17b4-4804-8831-8bd2e3e5395c","","",false, this);
 
            IDArticleContainer = RPSControlFactory.CreateRPSComboBox<WarehouseSeriesVMEntityView>("6ecef826-497d-4720-b194-93e4134658aa","","",false, this);
 
            AverageSecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<WarehouseSeriesVMEntityView>("8569e90f-d3dc-4a79-b3a3-f40c4096102e","","",true, this);
 
            PotencyValue = RPSControlFactory.CreateRPSFormattedTextBox<WarehouseSeriesVMEntityView>("244cf460-e5ba-42e4-85ba-a9f872634361","","",true, this);
 
            SalesPrice = RPSControlFactory.CreateRPSFormattedTextBox<WarehouseSeriesVMEntityView>("c4728e70-e3db-4550-b2cd-35a2e7392394","","",true, this);
 
            IDUnitPrice = RPSControlFactory.CreateRPSComboBox<WarehouseSeriesVMEntityView>("3979c4ca-c310-4e0e-8b78-8f5f611a45dc","","",false, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<WarehouseSeriesVMEntityView>("6001fa40-1454-4bba-95e0-47c13343ec5b","","",false, this);
 
            Section = RPSControlFactory.CreateRPSSection<WarehouseSeriesVMEntityView>( "","ul li[rpsid='a115689c-aa5f-40ae-beb0-7056036a53eb']","",this);
 
            Section1 = RPSControlFactory.CreateRPSSection<WarehouseSeriesVMEntityView>( "","ul li[rpsid='28d9ae5e-c86d-4a80-bf67-057968b32b75']","",this);
 

        }
        public IRPSSaveButton<WarehouseSeriesVMEntityView> SaveButton { get; set; } 
        public IRPSButton<WarehouseSeriesVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<WarehouseSeriesVMEntityView,WarehouseSeriesVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<WarehouseSeriesVMEntityView,WarehouseSeriesVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<WarehouseSeriesVMEntityView> IDArticle { get; set; } 
        public IRPSComboBox<WarehouseSeriesVMEntityView> IDSite { get; set; } 
        public IRPSComboBox<WarehouseSeriesVMEntityView> IDWarehouse { get; set; } 
        public IRPSTextBox<WarehouseSeriesVMEntityView> Series { get; set; } 
        public IRPSComboBox<WarehouseSeriesVMEntityView> IDStatusLot { get; set; } 
        public IRPSTextBox<WarehouseSeriesVMEntityView> ExpiryDate { get; set; } 
        public IRPSTextBox<WarehouseSeriesVMEntityView> LastMovementDate { get; set; } 
        public IRPSTextBox<WarehouseSeriesVMEntityView> LastEntryDate { get; set; } 
        public IRPSTextBox<WarehouseSeriesVMEntityView> PurchasePrice { get; set; } 
        public IRPSTextBox<WarehouseSeriesVMEntityView> PurchaseDate { get; set; } 
        public IRPSTextBox<WarehouseSeriesVMEntityView> AveragePrice { get; set; } 
        public IRPSTextBox<WarehouseSeriesVMEntityView> ManufacturePrice { get; set; } 
        public IRPSTextBox<WarehouseSeriesVMEntityView> ManufactureDate { get; set; } 
        public IRPSTextBox<WarehouseSeriesVMEntityView> ReferenceSupplier { get; set; } 
        public IRPSComboBox<WarehouseSeriesVMEntityView> IDArticleContainer { get; set; } 
        public IRPSTextBox<WarehouseSeriesVMEntityView> AverageSecondUnit { get; set; } 
        public IRPSTextBox<WarehouseSeriesVMEntityView> PotencyValue { get; set; } 
        public IRPSTextBox<WarehouseSeriesVMEntityView> SalesPrice { get; set; } 
        public IRPSComboBox<WarehouseSeriesVMEntityView> IDUnitPrice { get; set; } 
        public IRPSTextBox<WarehouseSeriesVMEntityView> Comment { get; set; } 
        public IRPSSection<WarehouseSeriesVMEntityView> Section { get; set; } 
        public IRPSSection<WarehouseSeriesVMEntityView> Section1 { get; set; } 
        public WarehouseSeries Screen { get; set; }
        public WarehouseSeriesVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}