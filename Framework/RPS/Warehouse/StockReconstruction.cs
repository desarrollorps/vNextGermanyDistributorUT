    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Warehouse.StockReconstruction
{
    //RPS VERSION 1.0.0.0
    public partial class StockReconstruction:Screen
    {
        public StockReconstruction():base()
        {
            this.URL = "warehouse.stockreconstruction";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            StockReconstructionView  = new StockReconstructionView(this); 
            StockReconstructionView.InitializeControls(); 
           
        }
      
            public StockReconstructionView StockReconstructionView {get; set; } 
    }
            
    public partial class StockReconstructionView : View
    {
        public StockReconstructionView(StockReconstruction screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Article = RPSControlFactory.CreateRPSCollectionComboBox<StockReconstructionView>("6ca6e444-0ae2-4ed1-aece-21dbbb0a0ac1","","",false, this);
 
            Site = RPSControlFactory.CreateRPSCollectionComboBox<StockReconstructionView>("fd39864e-1562-4e09-ac43-6f6f73cc2f50","","",false, this);
 
            WareHouse = RPSControlFactory.CreateRPSCollectionComboBox<StockReconstructionView>("ce41995a-4ff1-4738-bc81-883dfb0d2da7","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<StockReconstructionView>("bb183c3d-18a7-47ed-9607-f16335e9f874","","",true, this);
 
            AcceptCommand = RPSControlFactory.CreateRPSButton<StockReconstructionView>( "d15cb061-ed67-4be9-995d-9b4a3fb378f4","","",this);
 
            CollectionInit params_StockReconstructionQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b1bb61ef-c986-4fd0-8bc9-cfac0a31eedd",CSSSelectorGrid="",XPathGrid=""};
            StockReconstructionQuery = RPSControlFactory.RPSCreateCollectionWithGrid<StockReconstructionQueryCollectionEditor<StockReconstructionView>,StockReconstructionView>( params_StockReconstructionQuery,this);
 

        }
        public IRPSCollectionComboBox<StockReconstructionView> Article { get; set; } 
        public IRPSCollectionComboBox<StockReconstructionView> Site { get; set; } 
        public IRPSCollectionComboBox<StockReconstructionView> WareHouse { get; set; } 
        public IRPSTextBox<StockReconstructionView> DateFrom { get; set; } 
        public IRPSButton<StockReconstructionView> AcceptCommand { get; set; } 
        public StockReconstructionQueryCollectionEditor<StockReconstructionView> StockReconstructionQuery { get; set; } 
        public StockReconstruction Screen { get; set; }
        public StockReconstructionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class StockReconstructionQueryCollectionEditor<StockReconstructionView>:RPSCollectionEditor<StockReconstructionView> where StockReconstructionView : class, IView
    {
        public  StockReconstructionQueryGridView<StockReconstructionView> GridView {get;set;}
    }
    public partial class StockReconstructionQueryGridView <StockReconstructionView> :  RPSGridView<StockReconstructionView> where StockReconstructionView : class, IView
    {
        public StockReconstructionQueryGridView(StockReconstructionView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Serie = RPSControlFactory.CreateRPSGridTextBox<StockReconstructionView>("","#b1bb61ef-c986-4fd0-8bc9-cfac0a31eedd .ag-row[role='row']@ROWINDEX [col-id='cSerie']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<StockReconstructionView> Serie { get; set; } 
                     
    }
 
    }
  
    

}