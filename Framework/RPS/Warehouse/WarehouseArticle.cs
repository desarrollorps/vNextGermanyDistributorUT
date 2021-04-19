    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Warehouse.WarehouseArticle
{
    //RPS VERSION 1.0.0.0
    public partial class WarehouseArticle:Screen
    {
        public WarehouseArticle():base()
        {
            this.URL = "warehouse.warehousearticle";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            WarehouseArticleVMQueryView  = new WarehouseArticleVMQueryView(this); 
            WarehouseArticleVMEntityView  = new WarehouseArticleVMEntityView(this); 
            WarehouseArticleVMQueryView.InitializeControls(); 
            WarehouseArticleVMEntityView.InitializeControls(); 
           
        }
      
            public WarehouseArticleVMQueryView WarehouseArticleVMQueryView {get; set; } 
            public WarehouseArticleVMEntityView WarehouseArticleVMEntityView {get; set; } 
    }
            
    public partial class WarehouseArticleVMQueryView : View
    {
        public WarehouseArticleVMQueryView(WarehouseArticle screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<WarehouseArticleVMQueryView,WarehouseArticleVMEntityView>( this,Screen.WarehouseArticleVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<WarehouseArticleVMQueryView>( this);
 
            Site = RPSControlFactory.CreateRPSCollectionComboBox<WarehouseArticleVMQueryView>("09debc33-e216-43f3-8dac-30f174454144","","",false, this);
 
            WareHouse = RPSControlFactory.CreateRPSCollectionComboBox<WarehouseArticleVMQueryView>("30b5573c-cb1d-4ae6-81b4-fb7f1276d1fb","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<WarehouseArticleVMQueryView>("2ad6e8a9-4326-486e-8f8b-13ef281d94d4","","",false, this);
 
            CollectionInit params_WarehouseArticleQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6e93a732-b824-4b06-a100-2387909bd6ee",CSSSelectorGrid="",XPathGrid=""};
            WarehouseArticleQuery = RPSControlFactory.RPSCreateCollectionWithGrid<WarehouseArticleQueryCollectionEditor<WarehouseArticleVMQueryView,WarehouseArticleVMEntityView>,WarehouseArticleVMQueryView,WarehouseArticleVMEntityView>( params_WarehouseArticleQuery,this,Screen.WarehouseArticleVMEntityView);
 

        }
        public IRPSButton<WarehouseArticleVMQueryView,WarehouseArticleVMEntityView> NewButton { get; set; } 
        public IRPSButton<WarehouseArticleVMQueryView> ConsultButton { get; set; } 
        public IRPSCollectionComboBox<WarehouseArticleVMQueryView> Site { get; set; } 
        public IRPSCollectionComboBox<WarehouseArticleVMQueryView> WareHouse { get; set; } 
        public IRPSCollectionComboBox<WarehouseArticleVMQueryView> Article { get; set; } 
        public WarehouseArticleQueryCollectionEditor<WarehouseArticleVMQueryView,WarehouseArticleVMEntityView> WarehouseArticleQuery { get; set; } 
        public WarehouseArticle Screen { get; set; }
        public WarehouseArticleVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class WarehouseArticleQueryCollectionEditor<WarehouseArticleVMQueryView,WarehouseArticleVMEntityView>:RPSCollectionEditor<WarehouseArticleVMQueryView,WarehouseArticleVMEntityView> where WarehouseArticleVMQueryView : class, IView where WarehouseArticleVMEntityView : class, IView
    {
        public  WarehouseArticleQueryGridView<WarehouseArticleVMQueryView,WarehouseArticleVMEntityView> GridView {get;set;}
    }
    public partial class WarehouseArticleQueryGridView <WarehouseArticleVMQueryView,WarehouseArticleVMEntityView> :  RPSGridView<WarehouseArticleVMQueryView,WarehouseArticleVMEntityView> where WarehouseArticleVMQueryView : class, IView where WarehouseArticleVMEntityView : class, IView
    {
        public WarehouseArticleQueryGridView(WarehouseArticleVMQueryView currentView,WarehouseArticleVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            WarehouseArticle_StockMin = RPSControlFactory.CreateRPSGridFormattedTextBox<WarehouseArticleVMQueryView>("","#6e93a732-b824-4b06-a100-2387909bd6ee .ag-row[role='row']@ROWINDEX [col-id='cWarehouseArticle_StockMin']","",false, this.CurrentView);
 
            WarehouseArticle_PointOrder = RPSControlFactory.CreateRPSGridFormattedTextBox<WarehouseArticleVMQueryView>("","#6e93a732-b824-4b06-a100-2387909bd6ee .ag-row[role='row']@ROWINDEX [col-id='cWarehouseArticle_PointOrder']","",false, this.CurrentView);
 
            WarehouseArticle_PurchasePrice = RPSControlFactory.CreateRPSGridFormattedTextBox<WarehouseArticleVMQueryView>("","#6e93a732-b824-4b06-a100-2387909bd6ee .ag-row[role='row']@ROWINDEX [col-id='cWarehouseArticle_PurchasePrice']","",false, this.CurrentView);
 
            WarehouseArticle_AveragePrice = RPSControlFactory.CreateRPSGridFormattedTextBox<WarehouseArticleVMQueryView>("","#6e93a732-b824-4b06-a100-2387909bd6ee .ag-row[role='row']@ROWINDEX [col-id='cWarehouseArticle_AveragePrice']","",false, this.CurrentView);
 
            WarehouseArticle_ManufacturePrice = RPSControlFactory.CreateRPSGridFormattedTextBox<WarehouseArticleVMQueryView>("","#6e93a732-b824-4b06-a100-2387909bd6ee .ag-row[role='row']@ROWINDEX [col-id='cWarehouseArticle_ManufacturePrice']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<WarehouseArticleVMQueryView> WarehouseArticle_StockMin { get; set; } 
        public IRPSGridTextBox<WarehouseArticleVMQueryView> WarehouseArticle_PointOrder { get; set; } 
        public IRPSGridTextBox<WarehouseArticleVMQueryView> WarehouseArticle_PurchasePrice { get; set; } 
        public IRPSGridTextBox<WarehouseArticleVMQueryView> WarehouseArticle_AveragePrice { get; set; } 
        public IRPSGridTextBox<WarehouseArticleVMQueryView> WarehouseArticle_ManufacturePrice { get; set; } 
                     
    }
 
    }
  
            
    public partial class WarehouseArticleVMEntityView : View
    {
        public WarehouseArticleVMEntityView(WarehouseArticle screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<WarehouseArticleVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<WarehouseArticleVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<WarehouseArticleVMEntityView,WarehouseArticleVMQueryView>( this,Screen.WarehouseArticleVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<WarehouseArticleVMEntityView,WarehouseArticleVMQueryView>( this,Screen.WarehouseArticleVMQueryView);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<WarehouseArticleVMEntityView>("b1597ba1-fb3d-477f-bcfe-6e71f1b56402","","",true, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<WarehouseArticleVMEntityView>("dc8b7763-2731-4588-baa3-29e1b89fe6c2","","",true, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<WarehouseArticleVMEntityView>("29762890-e774-411c-b493-faf245c69cea","","",true, this);
 
            StockMin = RPSControlFactory.CreateRPSFormattedTextBox<WarehouseArticleVMEntityView>("8bbd0465-29af-456b-a548-4a5691f919eb","","",true, this);
 
            PointOrder = RPSControlFactory.CreateRPSFormattedTextBox<WarehouseArticleVMEntityView>("f0f6665e-cd2a-4d54-92a3-973d250588b9","","",true, this);
 
            ConsumePrevision = RPSControlFactory.CreateRPSFormattedTextBox<WarehouseArticleVMEntityView>("347da66f-2b15-418c-acb2-618bf932cd8b","","",true, this);
 
            RotationIndex = RPSControlFactory.CreateRPSFormattedTextBox<WarehouseArticleVMEntityView>("7bd6867c-bc97-4c54-b414-874e7fcefe02","","",true, this);
 
            StockMax = RPSControlFactory.CreateRPSFormattedTextBox<WarehouseArticleVMEntityView>("466c61fb-9cd6-472e-ba9d-055fb2452d95","","",true, this);
 
            PurchasePrice = RPSControlFactory.CreateRPSFormattedTextBox<WarehouseArticleVMEntityView>("1a4b9241-6826-4212-93fe-91a494d1a566","","",true, this);
 
            PurchaseDate = RPSControlFactory.CreateRPSTextBox<WarehouseArticleVMEntityView>("3f445533-d264-4418-a5c1-a0eab9e63907","","",false, this);
 
            AveragePrice = RPSControlFactory.CreateRPSFormattedTextBox<WarehouseArticleVMEntityView>("1bc10815-6b9f-4f70-a9b5-8aa69a0d3f66","","",true, this);
 
            ManufacturePrice = RPSControlFactory.CreateRPSFormattedTextBox<WarehouseArticleVMEntityView>("26fb7064-14ab-4c55-bcfd-7aeefa57aaaf","","",true, this);
 
            ManufactureDate = RPSControlFactory.CreateRPSTextBox<WarehouseArticleVMEntityView>("4c6c4b4b-952e-4e9c-ad4f-3ec6b2e4d38f","","",false, this);
 

        }
        public IRPSSaveButton<WarehouseArticleVMEntityView> SaveButton { get; set; } 
        public IRPSButton<WarehouseArticleVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<WarehouseArticleVMEntityView,WarehouseArticleVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<WarehouseArticleVMEntityView,WarehouseArticleVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<WarehouseArticleVMEntityView> IDArticle { get; set; } 
        public IRPSComboBox<WarehouseArticleVMEntityView> IDSite { get; set; } 
        public IRPSComboBox<WarehouseArticleVMEntityView> IDWarehouse { get; set; } 
        public IRPSTextBox<WarehouseArticleVMEntityView> StockMin { get; set; } 
        public IRPSTextBox<WarehouseArticleVMEntityView> PointOrder { get; set; } 
        public IRPSTextBox<WarehouseArticleVMEntityView> ConsumePrevision { get; set; } 
        public IRPSTextBox<WarehouseArticleVMEntityView> RotationIndex { get; set; } 
        public IRPSTextBox<WarehouseArticleVMEntityView> StockMax { get; set; } 
        public IRPSTextBox<WarehouseArticleVMEntityView> PurchasePrice { get; set; } 
        public IRPSTextBox<WarehouseArticleVMEntityView> PurchaseDate { get; set; } 
        public IRPSTextBox<WarehouseArticleVMEntityView> AveragePrice { get; set; } 
        public IRPSTextBox<WarehouseArticleVMEntityView> ManufacturePrice { get; set; } 
        public IRPSTextBox<WarehouseArticleVMEntityView> ManufactureDate { get; set; } 
        public WarehouseArticle Screen { get; set; }
        public WarehouseArticleVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}