    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Warehouse.ArticleWithoutMovement
{
    //RPS VERSION 1.0.0.0
    public partial class ArticleWithoutMovement:Screen
    {
        public ArticleWithoutMovement():base()
        {
            this.URL = "warehouse.articlewithoutmovement";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ArticleWithoutMovementQueryView  = new ArticleWithoutMovementQueryView(this); 
            ArticleWithoutMovementQueryView.InitializeControls(); 
           
        }
      
            public ArticleWithoutMovementQueryView ArticleWithoutMovementQueryView {get; set; } 
    }
            
    public partial class ArticleWithoutMovementQueryView : View
    {
        public ArticleWithoutMovementQueryView(ArticleWithoutMovement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ProductLine = RPSControlFactory.CreateRPSCollectionComboBox<ArticleWithoutMovementQueryView>("321e5e9c-495e-4751-8293-d3c63dfad23a","","",false, this);
 
            ProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<ArticleWithoutMovementQueryView>("0bd5b644-39ca-46d5-9963-02253cddf155","","",false, this);
 
            ProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<ArticleWithoutMovementQueryView>("88797008-f878-4adc-b4a8-1eb7417d6db6","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<ArticleWithoutMovementQueryView>("74cf48d3-9edd-4dcd-a303-6559aae72e25","","",false, this);
 
            Site = RPSControlFactory.CreateRPSCollectionComboBox<ArticleWithoutMovementQueryView>("4be2e50a-f713-41c0-895a-faa66823ae8a","","",false, this);
 
            WareHouse = RPSControlFactory.CreateRPSCollectionComboBox<ArticleWithoutMovementQueryView>("65196a5d-591a-4085-a0c3-2e43c6a003a5","","",false, this);
 
            WarehouseSeries = RPSControlFactory.CreateRPSEnumComboBox<ArticleWithoutMovementQueryView>("fd21545a-9c29-4630-80ad-552a70f4dda2","","",false, this);
 
            Article1 = RPSControlFactory.CreateRPSOption<ArticleWithoutMovementQueryView>( "762471f0-1bbd-4c13-add0-aeabdc91713e","","",this);
 
            Article_Site = RPSControlFactory.CreateRPSOption<ArticleWithoutMovementQueryView>( "ed9c14ec-2cd9-44e2-9f70-00089ec46d9a","","",this);
 
            Warehouse_Article = RPSControlFactory.CreateRPSOption<ArticleWithoutMovementQueryView>( "94cde595-1b3c-427c-82d7-fb843d49b74f","","",this);
 
            Warehouse_Article_Series = RPSControlFactory.CreateRPSOption<ArticleWithoutMovementQueryView>( "08a6c436-5445-4d9c-b9ea-cb20d02e07d3","","",this);
 
            bInput = RPSControlFactory.CreateRPSCheckBox<ArticleWithoutMovementQueryView>("464d6bfc-4b56-4917-a99d-11541354d3e4","","",false, this);
 
            bOutput = RPSControlFactory.CreateRPSCheckBox<ArticleWithoutMovementQueryView>("1d971809-f039-4451-bbf9-9f8907f68dbd","","",false, this);
 
            bTransfer = RPSControlFactory.CreateRPSCheckBox<ArticleWithoutMovementQueryView>("38c57edf-8cbc-4f07-8fc8-01e99833388a","","",false, this);
 
            bCost = RPSControlFactory.CreateRPSCheckBox<ArticleWithoutMovementQueryView>("8d048620-ebc9-44e9-8691-07d9a8ed100a","","",false, this);
 
            bInventory = RPSControlFactory.CreateRPSCheckBox<ArticleWithoutMovementQueryView>("75ef7ba2-b301-4d67-b93a-dc080d710154","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<ArticleWithoutMovementQueryView>("5da069e3-4679-436e-b405-9e754429a94d","","",true, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<ArticleWithoutMovementQueryView>("d4773cea-5d49-4e4f-8d55-cb3e9c0b8c61","","",false, this);
 
            CollectionInit params_ArticleWithoutMovement = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a81107ba-c026-4057-8d41-77fb9bd68764",CSSSelectorGrid="",XPathGrid=""};
            ArticleWithoutMovement = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleWithoutMovementCollectionEditor<ArticleWithoutMovementQueryView>,ArticleWithoutMovementQueryView>( params_ArticleWithoutMovement,this);
 
            CollectionInit params_ArticleWithoutMovement1 = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="037be323-3a69-44b4-bd57-7b918072f8e6",CSSSelectorGrid="",XPathGrid=""};
            ArticleWithoutMovement1 = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleWithoutMovementCollectionEditor<ArticleWithoutMovementQueryView>,ArticleWithoutMovementQueryView>( params_ArticleWithoutMovement1,this);
 
            CollectionInit params_ArticleWithoutMovement2 = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8f712763-8ebb-4713-89cf-a79d296f27b1",CSSSelectorGrid="",XPathGrid=""};
            ArticleWithoutMovement2 = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleWithoutMovementCollectionEditor<ArticleWithoutMovementQueryView>,ArticleWithoutMovementQueryView>( params_ArticleWithoutMovement2,this);
 
            CollectionInit params_ArticleWithoutMovement3 = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f502c090-1e67-4af9-a81d-0534d811c1b1",CSSSelectorGrid="",XPathGrid=""};
            ArticleWithoutMovement3 = RPSControlFactory.RPSCreateCollectionWithGrid<ArticleWithoutMovementCollectionEditor<ArticleWithoutMovementQueryView>,ArticleWithoutMovementQueryView>( params_ArticleWithoutMovement3,this);
 

        }
        public IRPSCollectionComboBox<ArticleWithoutMovementQueryView> ProductLine { get; set; } 
        public IRPSCollectionComboBox<ArticleWithoutMovementQueryView> ProductFamily { get; set; } 
        public IRPSCollectionComboBox<ArticleWithoutMovementQueryView> ProductSubFamily { get; set; } 
        public IRPSCollectionComboBox<ArticleWithoutMovementQueryView> Article { get; set; } 
        public IRPSCollectionComboBox<ArticleWithoutMovementQueryView> Site { get; set; } 
        public IRPSCollectionComboBox<ArticleWithoutMovementQueryView> WareHouse { get; set; } 
        public IRPSComboBox<ArticleWithoutMovementQueryView> WarehouseSeries { get; set; } 
        public IRPSOption<ArticleWithoutMovementQueryView> Article1 { get; set; } 
        public IRPSOption<ArticleWithoutMovementQueryView> Article_Site { get; set; } 
        public IRPSOption<ArticleWithoutMovementQueryView> Warehouse_Article { get; set; } 
        public IRPSOption<ArticleWithoutMovementQueryView> Warehouse_Article_Series { get; set; } 
        public IRPSCheckbox<ArticleWithoutMovementQueryView> bInput { get; set; } 
        public IRPSCheckbox<ArticleWithoutMovementQueryView> bOutput { get; set; } 
        public IRPSCheckbox<ArticleWithoutMovementQueryView> bTransfer { get; set; } 
        public IRPSCheckbox<ArticleWithoutMovementQueryView> bCost { get; set; } 
        public IRPSCheckbox<ArticleWithoutMovementQueryView> bInventory { get; set; } 
        public IRPSTextBox<ArticleWithoutMovementQueryView> DateFrom { get; set; } 
        public IRPSTextBox<ArticleWithoutMovementQueryView> DateTo { get; set; } 
        public ArticleWithoutMovementCollectionEditor<ArticleWithoutMovementQueryView> ArticleWithoutMovement { get; set; } 
        public ArticleWithoutMovementCollectionEditor<ArticleWithoutMovementQueryView> ArticleWithoutMovement1 { get; set; } 
        public ArticleWithoutMovementCollectionEditor<ArticleWithoutMovementQueryView> ArticleWithoutMovement2 { get; set; } 
        public ArticleWithoutMovementCollectionEditor<ArticleWithoutMovementQueryView> ArticleWithoutMovement3 { get; set; } 
        public ArticleWithoutMovement Screen { get; set; }
        public ArticleWithoutMovementQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ArticleWithoutMovementCollectionEditor<ArticleWithoutMovementQueryView>:RPSCollectionEditor<ArticleWithoutMovementQueryView> where ArticleWithoutMovementQueryView : class, IView
    {
        public  ArticleWithoutMovementGridView<ArticleWithoutMovementQueryView> GridView {get;set;}
    }
    public partial class ArticleWithoutMovementGridView <ArticleWithoutMovementQueryView> :  RPSGridView<ArticleWithoutMovementQueryView> where ArticleWithoutMovementQueryView : class, IView
    {
        public ArticleWithoutMovementGridView(ArticleWithoutMovementQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            LastMovementDate = RPSControlFactory.CreateRPSGridTextBox<ArticleWithoutMovementQueryView>("","#a81107ba-c026-4057-8d41-77fb9bd68764 .ag-row[role='row']@ROWINDEX [col-id='cLastMovementDate']","",false, this.CurrentView);
 
            Stock = RPSControlFactory.CreateRPSGridFormattedTextBox<ArticleWithoutMovementQueryView>("","#a81107ba-c026-4057-8d41-77fb9bd68764 .ag-row[role='row']@ROWINDEX [col-id='cStock']","",false, this.CurrentView);
 
            StockSecondUnit = RPSControlFactory.CreateRPSGridFormattedTextBox<ArticleWithoutMovementQueryView>("","#a81107ba-c026-4057-8d41-77fb9bd68764 .ag-row[role='row']@ROWINDEX [col-id='cStockSecondUnit']","",false, this.CurrentView);
 
            Price = RPSControlFactory.CreateRPSGridFormattedTextBox<ArticleWithoutMovementQueryView>("","#a81107ba-c026-4057-8d41-77fb9bd68764 .ag-row[role='row']@ROWINDEX [col-id='cPrice']","",false, this.CurrentView);
 
            Amount = RPSControlFactory.CreateRPSGridFormattedTextBox<ArticleWithoutMovementQueryView>("","#a81107ba-c026-4057-8d41-77fb9bd68764 .ag-row[role='row']@ROWINDEX [col-id='cAmount']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ArticleWithoutMovementQueryView> LastMovementDate { get; set; } 
        public IRPSGridTextBox<ArticleWithoutMovementQueryView> Stock { get; set; } 
        public IRPSGridTextBox<ArticleWithoutMovementQueryView> StockSecondUnit { get; set; } 
        public IRPSGridTextBox<ArticleWithoutMovementQueryView> Price { get; set; } 
        public IRPSGridTextBox<ArticleWithoutMovementQueryView> Amount { get; set; } 
                     
    }
 
    }
  
    

}