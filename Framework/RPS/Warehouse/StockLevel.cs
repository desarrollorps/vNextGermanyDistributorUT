    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Warehouse.StockLevel
{
    //RPS VERSION 1.0.0.0
    public partial class StockLevel:Screen
    {
        public StockLevel():base()
        {
            this.URL = "warehouse.stocklevel";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            StockLevelQueryView  = new StockLevelQueryView(this); 
            StockLevelQueryView.InitializeControls(); 
           
        }
      
            public StockLevelQueryView StockLevelQueryView {get; set; } 
    }
            
    public partial class StockLevelQueryView : View
    {
        public StockLevelQueryView(StockLevel screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ProductLine = RPSControlFactory.CreateRPSCollectionComboBox<StockLevelQueryView>("6c0d1da7-26a7-41a7-acef-3d442ef0fdd0","","",false, this);
 
            ProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<StockLevelQueryView>("42cc7f2e-f7db-4591-aea5-327bac2aa68d","","",false, this);
 
            ProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<StockLevelQueryView>("cb36090b-d744-4ecd-a389-99df78aa7bef","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<StockLevelQueryView>("2630c35b-d8e4-4588-ab7d-d174f87bd0c3","","",false, this);
 
            Site = RPSControlFactory.CreateRPSCollectionComboBox<StockLevelQueryView>("3679ee5c-006b-4c5b-a31b-2f9798179a09","","",false, this);
 
            WareHouse = RPSControlFactory.CreateRPSCollectionComboBox<StockLevelQueryView>("f4e89ed7-954c-4d6b-a4a6-c8e2f208a4b1","","",false, this);
 
            StockAll = RPSControlFactory.CreateRPSOption<StockLevelQueryView>( "8cca1565-8984-4f08-9b9d-86feb0c76e9b","","",this);
 
            StockLessThanStockMin = RPSControlFactory.CreateRPSOption<StockLevelQueryView>( "f20305a7-d109-4c77-9cf5-d3aa6ca5ed97","","",this);
 
            StockGreatherThanStockMax = RPSControlFactory.CreateRPSOption<StockLevelQueryView>( "35424709-e0f1-4028-8da9-211bf73cff1b","","",this);
 
            StockLesserOrGreater = RPSControlFactory.CreateRPSOption<StockLevelQueryView>( "e11ea87b-dd4e-4f55-9e92-b4612a4bb6d1","","",this);
 
            CollectionInit params_StockLevel = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="2ff3724b-0fb4-42a8-89c1-ee77dc393037",CSSSelectorGrid="",XPathGrid=""};
            StockLevel = RPSControlFactory.RPSCreateCollectionWithGrid<StockLevelCollectionEditor<StockLevelQueryView>,StockLevelQueryView>( params_StockLevel,this);
 

        }
        public IRPSCollectionComboBox<StockLevelQueryView> ProductLine { get; set; } 
        public IRPSCollectionComboBox<StockLevelQueryView> ProductFamily { get; set; } 
        public IRPSCollectionComboBox<StockLevelQueryView> ProductSubFamily { get; set; } 
        public IRPSCollectionComboBox<StockLevelQueryView> Article { get; set; } 
        public IRPSCollectionComboBox<StockLevelQueryView> Site { get; set; } 
        public IRPSCollectionComboBox<StockLevelQueryView> WareHouse { get; set; } 
        public IRPSOption<StockLevelQueryView> StockAll { get; set; } 
        public IRPSOption<StockLevelQueryView> StockLessThanStockMin { get; set; } 
        public IRPSOption<StockLevelQueryView> StockGreatherThanStockMax { get; set; } 
        public IRPSOption<StockLevelQueryView> StockLesserOrGreater { get; set; } 
        public StockLevelCollectionEditor<StockLevelQueryView> StockLevel { get; set; } 
        public StockLevel Screen { get; set; }
        public StockLevelQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class StockLevelCollectionEditor<StockLevelQueryView>:RPSCollectionEditor<StockLevelQueryView> where StockLevelQueryView : class, IView
    {
        public  StockLevelGridView<StockLevelQueryView> GridView {get;set;}
    }
    public partial class StockLevelGridView <StockLevelQueryView> :  RPSGridView<StockLevelQueryView> where StockLevelQueryView : class, IView
    {
        public StockLevelGridView(StockLevelQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {

        }
                     
    }
 
    }
  
    

}