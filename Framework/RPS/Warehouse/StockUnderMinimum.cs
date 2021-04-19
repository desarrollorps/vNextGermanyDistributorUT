    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Warehouse.StockUnderMinimum
{
    //RPS VERSION 1.0.0.0
    public partial class StockUnderMinimum:Screen
    {
        public StockUnderMinimum():base()
        {
            this.URL = "warehouse.stockunderminimum";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            StockUnderMinimumQueryView  = new StockUnderMinimumQueryView(this); 
            StockUnderMinimumQueryView.InitializeControls(); 
           
        }
      
            public StockUnderMinimumQueryView StockUnderMinimumQueryView {get; set; } 
    }
            
    public partial class StockUnderMinimumQueryView : View
    {
        public StockUnderMinimumQueryView(StockUnderMinimum screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Article = RPSControlFactory.CreateRPSOption<StockUnderMinimumQueryView>( "990fcbb9-3ac5-4be2-871d-4e842086ba08","","",this);
 
            Site = RPSControlFactory.CreateRPSOption<StockUnderMinimumQueryView>( "a2490662-08d0-4437-a674-97787cb4d774","","",this);
 
            Warehouse = RPSControlFactory.CreateRPSOption<StockUnderMinimumQueryView>( "353a82b4-da22-475b-86cf-6759c44e1ac4","","",this);
 
            ProductLine = RPSControlFactory.CreateRPSCollectionComboBox<StockUnderMinimumQueryView>("7fedbc3f-2424-48c9-bc24-e4b329d3277c","","",false, this);
 
            ProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<StockUnderMinimumQueryView>("284caef8-350a-4aaf-8ce4-f2baaf426246","","",false, this);
 
            ProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<StockUnderMinimumQueryView>("92636e66-5d84-4978-9e1c-552b044b7470","","",false, this);
 
            Article1 = RPSControlFactory.CreateRPSCollectionComboBox<StockUnderMinimumQueryView>("7e47ceb7-fa80-4fc6-b33c-d156fdf29e01","","",false, this);
 
            Site1 = RPSControlFactory.CreateRPSCollectionComboBox<StockUnderMinimumQueryView>("60407643-cc75-47c6-a4b7-026fa2976e46","","",false, this);
 
            WareHouse = RPSControlFactory.CreateRPSCollectionComboBox<StockUnderMinimumQueryView>("87695eeb-8910-415c-ad04-a44528d304b5","","",false, this);
 
            Supplier = RPSControlFactory.CreateRPSCollectionComboBox<StockUnderMinimumQueryView>("e2b862ae-a04d-4b22-92b0-bb97f4017ebd","","",false, this);
 
            IncludeWithPurchasePending = RPSControlFactory.CreateRPSCheckBox<StockUnderMinimumQueryView>("d0190d3d-ce86-42b2-b0ef-b8520b9f102e","","",false, this);
 
            OnlyStockUnderMinimum = RPSControlFactory.CreateRPSCheckBox<StockUnderMinimumQueryView>("b82519ee-2685-4867-98c0-74bb89cc2613","","",false, this);
 
            IncludeArticleWithoutStockParameter = RPSControlFactory.CreateRPSCheckBox<StockUnderMinimumQueryView>("bcb98639-a927-4a31-8ffe-4be74cab7823","","",false, this);
 
            PointOrder = RPSControlFactory.CreateRPSOption<StockUnderMinimumQueryView>( "4ce567d0-f555-44e2-9a71-8dfcb4708932","","",this);
 
            PointStock = RPSControlFactory.CreateRPSOption<StockUnderMinimumQueryView>( "5f41fbd4-5a16-4148-8350-1e9570276e08","","",this);
 
            BtnCreateSupplyFromUnderMinimumButton = RPSControlFactory.CreateRPSButton<StockUnderMinimumQueryView>( "c0a55fa8-94d9-4cee-9a0b-ade62b610912","","",this);
 
            CollectionInit params_StockUnderMinimum = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="89d2dc84-a046-40cd-854f-7952fc29feeb",CSSSelectorGrid="",XPathGrid=""};
            StockUnderMinimum = RPSControlFactory.RPSCreateCollectionWithGrid<StockUnderMinimumCollectionEditor<StockUnderMinimumQueryView>,StockUnderMinimumQueryView>( params_StockUnderMinimum,this);
 

        }
        public IRPSOption<StockUnderMinimumQueryView> Article { get; set; } 
        public IRPSOption<StockUnderMinimumQueryView> Site { get; set; } 
        public IRPSOption<StockUnderMinimumQueryView> Warehouse { get; set; } 
        public IRPSCollectionComboBox<StockUnderMinimumQueryView> ProductLine { get; set; } 
        public IRPSCollectionComboBox<StockUnderMinimumQueryView> ProductFamily { get; set; } 
        public IRPSCollectionComboBox<StockUnderMinimumQueryView> ProductSubFamily { get; set; } 
        public IRPSCollectionComboBox<StockUnderMinimumQueryView> Article1 { get; set; } 
        public IRPSCollectionComboBox<StockUnderMinimumQueryView> Site1 { get; set; } 
        public IRPSCollectionComboBox<StockUnderMinimumQueryView> WareHouse { get; set; } 
        public IRPSCollectionComboBox<StockUnderMinimumQueryView> Supplier { get; set; } 
        public IRPSCheckbox<StockUnderMinimumQueryView> IncludeWithPurchasePending { get; set; } 
        public IRPSCheckbox<StockUnderMinimumQueryView> OnlyStockUnderMinimum { get; set; } 
        public IRPSCheckbox<StockUnderMinimumQueryView> IncludeArticleWithoutStockParameter { get; set; } 
        public IRPSOption<StockUnderMinimumQueryView> PointOrder { get; set; } 
        public IRPSOption<StockUnderMinimumQueryView> PointStock { get; set; } 
        public IRPSButton<StockUnderMinimumQueryView> BtnCreateSupplyFromUnderMinimumButton { get; set; } 
        public StockUnderMinimumCollectionEditor<StockUnderMinimumQueryView> StockUnderMinimum { get; set; } 
        public StockUnderMinimum Screen { get; set; }
        public StockUnderMinimumQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class StockUnderMinimumCollectionEditor<StockUnderMinimumQueryView>:RPSCollectionEditor<StockUnderMinimumQueryView> where StockUnderMinimumQueryView : class, IView
    {
        public  StockUnderMinimumGridView<StockUnderMinimumQueryView> GridView {get;set;}
    }
    public partial class StockUnderMinimumGridView <StockUnderMinimumQueryView> :  RPSGridView<StockUnderMinimumQueryView> where StockUnderMinimumQueryView : class, IView
    {
        public StockUnderMinimumGridView(StockUnderMinimumQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            StockSecondUnit = RPSControlFactory.CreateRPSGridFormattedTextBox<StockUnderMinimumQueryView>("","#89d2dc84-a046-40cd-854f-7952fc29feeb .ag-row[role='row']@ROWINDEX [col-id='cStockSecondUnit']","",false, this.CurrentView);
 
            PointOrder = RPSControlFactory.CreateRPSGridFormattedTextBox<StockUnderMinimumQueryView>("","#89d2dc84-a046-40cd-854f-7952fc29feeb .ag-row[role='row']@ROWINDEX [col-id='cPointOrder']","",false, this.CurrentView);
 
            StockMin = RPSControlFactory.CreateRPSGridFormattedTextBox<StockUnderMinimumQueryView>("","#89d2dc84-a046-40cd-854f-7952fc29feeb .ag-row[role='row']@ROWINDEX [col-id='cStockMin']","",false, this.CurrentView);
 
            ProposalQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<StockUnderMinimumQueryView>("","#89d2dc84-a046-40cd-854f-7952fc29feeb .ag-row[role='row']@ROWINDEX [col-id='cProposalQuantity']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<StockUnderMinimumQueryView> StockSecondUnit { get; set; } 
        public IRPSGridTextBox<StockUnderMinimumQueryView> PointOrder { get; set; } 
        public IRPSGridTextBox<StockUnderMinimumQueryView> StockMin { get; set; } 
        public IRPSGridTextBox<StockUnderMinimumQueryView> ProposalQuantity { get; set; } 
                     
    }
 
    }
  
    

}