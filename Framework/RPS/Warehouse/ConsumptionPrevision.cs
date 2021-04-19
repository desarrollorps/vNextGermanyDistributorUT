    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Warehouse.ConsumptionPrevision
{
    //RPS VERSION 1.0.0.0
    public partial class ConsumptionPrevision:Screen
    {
        public ConsumptionPrevision():base()
        {
            this.URL = "warehouse.consumptionprevision";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ConsumptionPrevisionQueryView  = new ConsumptionPrevisionQueryView(this); 
            ConsumptionPrevisionQueryView.InitializeControls(); 
           
        }
      
            public ConsumptionPrevisionQueryView ConsumptionPrevisionQueryView {get; set; } 
    }
            
    public partial class ConsumptionPrevisionQueryView : View
    {
        public ConsumptionPrevisionQueryView(ConsumptionPrevision screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Article = RPSControlFactory.CreateRPSOption<ConsumptionPrevisionQueryView>( "c0543c49-23a1-4388-b48b-4b4c8b0e6aa1","","",this);
 
            Site = RPSControlFactory.CreateRPSOption<ConsumptionPrevisionQueryView>( "07fbc232-7a77-495c-bb12-e6d3fbfce57f","","",this);
 
            Warehouse = RPSControlFactory.CreateRPSOption<ConsumptionPrevisionQueryView>( "5bcaf0dd-5cb5-4e7d-83bb-093cfee6e2ed","","",this);
 
            ProductLine = RPSControlFactory.CreateRPSCollectionComboBox<ConsumptionPrevisionQueryView>("bcfb9be1-d7d5-4981-b03c-223920da110a","","",false, this);
 
            ProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<ConsumptionPrevisionQueryView>("adc9ae23-2e4d-4f03-b008-57814114ffb7","","",false, this);
 
            ProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<ConsumptionPrevisionQueryView>("23de4393-b4c7-4c94-9460-2df96fb8ae17","","",false, this);
 
            Article1 = RPSControlFactory.CreateRPSCollectionComboBox<ConsumptionPrevisionQueryView>("1c621ba2-17d0-4aed-be49-b4182ecab9ca","","",false, this);
 
            Site1 = RPSControlFactory.CreateRPSCollectionComboBox<ConsumptionPrevisionQueryView>("cc3800f8-bae7-44a0-b73f-9b283d864a22","","",false, this);
 
            WareHouse = RPSControlFactory.CreateRPSCollectionComboBox<ConsumptionPrevisionQueryView>("25556166-af43-4e44-9912-49a83e872d13","","",false, this);
 
            bPurchase = RPSControlFactory.CreateRPSCheckBox<ConsumptionPrevisionQueryView>("61b09ee6-5f9c-4bf7-9ac7-3684164f8d10","","",false, this);
 
            bManufacturing = RPSControlFactory.CreateRPSCheckBox<ConsumptionPrevisionQueryView>("a4840b04-b31c-4f5f-8454-ae02101cb0cf","","",false, this);
 
            bPurManu = RPSControlFactory.CreateRPSCheckBox<ConsumptionPrevisionQueryView>("56e11663-ef4a-406a-bc11-9b68fa126df7","","",false, this);
 
            bOthers = RPSControlFactory.CreateRPSCheckBox<ConsumptionPrevisionQueryView>("061ccaaa-ade7-4bd1-9b5c-8f97085c81a0","","",false, this);
 
            CalculatedDate = RPSControlFactory.CreateRPSTextBox<ConsumptionPrevisionQueryView>("deabeb2b-c517-4c7c-8ecd-b5089b5c7ed1","","",false, this);
 
            UpdateStocksButton = RPSControlFactory.CreateRPSButton<ConsumptionPrevisionQueryView>( "7e916023-b8b9-4259-bc8b-c960b4b6c9dc","","",this);
 
            UpdateConsumeButton = RPSControlFactory.CreateRPSButton<ConsumptionPrevisionQueryView>( "14d8ee48-72cb-4132-80b6-58e593f495cb","","",this);
 
            CollectionInit params_ConsumptionPrevision = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="22155b14-bc17-4823-9d95-57ebb37bf8ed",CSSSelectorGrid="",XPathGrid=""};
            ConsumptionPrevision = RPSControlFactory.RPSCreateCollectionWithGrid<ConsumptionPrevisionCollectionEditor<ConsumptionPrevisionQueryView>,ConsumptionPrevisionQueryView>( params_ConsumptionPrevision,this);
 

        }
        public IRPSOption<ConsumptionPrevisionQueryView> Article { get; set; } 
        public IRPSOption<ConsumptionPrevisionQueryView> Site { get; set; } 
        public IRPSOption<ConsumptionPrevisionQueryView> Warehouse { get; set; } 
        public IRPSCollectionComboBox<ConsumptionPrevisionQueryView> ProductLine { get; set; } 
        public IRPSCollectionComboBox<ConsumptionPrevisionQueryView> ProductFamily { get; set; } 
        public IRPSCollectionComboBox<ConsumptionPrevisionQueryView> ProductSubFamily { get; set; } 
        public IRPSCollectionComboBox<ConsumptionPrevisionQueryView> Article1 { get; set; } 
        public IRPSCollectionComboBox<ConsumptionPrevisionQueryView> Site1 { get; set; } 
        public IRPSCollectionComboBox<ConsumptionPrevisionQueryView> WareHouse { get; set; } 
        public IRPSCheckbox<ConsumptionPrevisionQueryView> bPurchase { get; set; } 
        public IRPSCheckbox<ConsumptionPrevisionQueryView> bManufacturing { get; set; } 
        public IRPSCheckbox<ConsumptionPrevisionQueryView> bPurManu { get; set; } 
        public IRPSCheckbox<ConsumptionPrevisionQueryView> bOthers { get; set; } 
        public IRPSTextBox<ConsumptionPrevisionQueryView> CalculatedDate { get; set; } 
        public IRPSButton<ConsumptionPrevisionQueryView> UpdateStocksButton { get; set; } 
        public IRPSButton<ConsumptionPrevisionQueryView> UpdateConsumeButton { get; set; } 
        public ConsumptionPrevisionCollectionEditor<ConsumptionPrevisionQueryView> ConsumptionPrevision { get; set; } 
        public ConsumptionPrevision Screen { get; set; }
        public ConsumptionPrevisionQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ConsumptionPrevisionCollectionEditor<ConsumptionPrevisionQueryView>:RPSCollectionEditor<ConsumptionPrevisionQueryView> where ConsumptionPrevisionQueryView : class, IView
    {
        public  ConsumptionPrevisionGridView<ConsumptionPrevisionQueryView> GridView {get;set;}
    }
    public partial class ConsumptionPrevisionGridView <ConsumptionPrevisionQueryView> :  RPSGridView<ConsumptionPrevisionQueryView> where ConsumptionPrevisionQueryView : class, IView
    {
        public ConsumptionPrevisionGridView(ConsumptionPrevisionQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ConsumePrevision = RPSControlFactory.CreateRPSGridFormattedTextBox<ConsumptionPrevisionQueryView>("","#22155b14-bc17-4823-9d95-57ebb37bf8ed .ag-row[role='row']@ROWINDEX [col-id='cConsumePrevision']","",false, this.CurrentView);
 
            ConsumePrevisionCalculated = RPSControlFactory.CreateRPSGridFormattedTextBox<ConsumptionPrevisionQueryView>("","#22155b14-bc17-4823-9d95-57ebb37bf8ed .ag-row[role='row']@ROWINDEX [col-id='cConsumePrevisionCalculated']","",false, this.CurrentView);
 
            StockMin = RPSControlFactory.CreateRPSGridFormattedTextBox<ConsumptionPrevisionQueryView>("","#22155b14-bc17-4823-9d95-57ebb37bf8ed .ag-row[role='row']@ROWINDEX [col-id='cStockMin']","",false, this.CurrentView);
 
            StockMinCalculated = RPSControlFactory.CreateRPSGridFormattedTextBox<ConsumptionPrevisionQueryView>("","#22155b14-bc17-4823-9d95-57ebb37bf8ed .ag-row[role='row']@ROWINDEX [col-id='cStockMinCalculated']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ConsumptionPrevisionQueryView> ConsumePrevision { get; set; } 
        public IRPSGridTextBox<ConsumptionPrevisionQueryView> ConsumePrevisionCalculated { get; set; } 
        public IRPSGridTextBox<ConsumptionPrevisionQueryView> StockMin { get; set; } 
        public IRPSGridTextBox<ConsumptionPrevisionQueryView> StockMinCalculated { get; set; } 
                     
    }
 
    }
  
    

}