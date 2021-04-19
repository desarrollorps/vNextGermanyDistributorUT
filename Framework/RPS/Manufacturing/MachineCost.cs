    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.MachineCost
{
    //RPS VERSION 1.0.0.0
    public partial class MachineCost:Screen
    {
        public MachineCost():base()
        {
            this.URL = "manufacturing.machinecost";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MachineCostCollectionView  = new MachineCostCollectionView(this); 
            MachineCostEntityView  = new MachineCostEntityView(this); 
            MachineCostDetailView  = new MachineCostDetailView(this); 
            MachineCostCollectionView.InitializeControls(); 
            MachineCostEntityView.InitializeControls(); 
            MachineCostDetailView.InitializeControls(); 
           
        }
      
            public MachineCostCollectionView MachineCostCollectionView {get; set; } 
            public MachineCostEntityView MachineCostEntityView {get; set; } 
            public MachineCostDetailView MachineCostDetailView {get; set; } 
    }
            
    public partial class MachineCostCollectionView : View
    {
        public MachineCostCollectionView(MachineCost screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<MachineCostCollectionView,MachineCostEntityView>( this,Screen.MachineCostEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "3559a6b0-bdc8-460e-a7df-543b90d65747",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<MachineCostCollectionView,MachineCostEntityView>( params_MainConsult,this,Screen.MachineCostEntityView);
 

        }
        public IRPSButton<MachineCostCollectionView,MachineCostEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<MachineCostCollectionView,MachineCostEntityView> MainConsult { get; set; } 
        public MachineCost Screen { get; set; }
        public MachineCostCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MachineCostEntityView : View
    {
        public MachineCostEntityView(MachineCost screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MachineCostEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<MachineCostEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MachineCostEntityView,MachineCostCollectionView>( this,Screen.MachineCostCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<MachineCostEntityView,MachineCostCollectionView>( this,Screen.MachineCostCollectionView);
 
            IDMachine = RPSControlFactory.CreateRPSComboBox<MachineCostEntityView>("cfb92d26-b96f-4f32-88f9-a408be470415","","",true, this);
 
            IDHourType = RPSControlFactory.CreateRPSComboBox<MachineCostEntityView>("761c3e73-527d-4742-884a-940d45f56c63","","",true, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<MachineCostEntityView>("cb9a0ffe-0175-4757-8cb7-121b7b6ac8ba","","",true, this);
 
            CostPrice = RPSControlFactory.CreateRPSFormattedTextBox<MachineCostEntityView>("10f7bf0b-8730-4e9c-90ef-6cd285e15c53","","",true, this);
 
            LinkNavigationCommand = RPSControlFactory.CreateRPSButton<MachineCostEntityView>( "e32ffc3b-5c28-403c-969c-9e83a2d6d04a","","",this);
 
            CollectionInit params_MachineCostDetail = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5b6283e2-c57d-4660-a14b-57b97743609d",CSSSelectorGrid="",XPathGrid=""};
            MachineCostDetail = RPSControlFactory.RPSCreateCollectionWithGrid<MachineCostDetailCollectionEditor<MachineCostEntityView>,MachineCostEntityView>( params_MachineCostDetail,this);
 

        }
        public IRPSSaveButton<MachineCostEntityView> SaveButton { get; set; } 
        public IRPSButton<MachineCostEntityView> DeleteButton { get; set; } 
        public IRPSButton<MachineCostEntityView,MachineCostCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MachineCostEntityView,MachineCostCollectionView> BackButton { get; set; } 
        public IRPSComboBox<MachineCostEntityView> IDMachine { get; set; } 
        public IRPSComboBox<MachineCostEntityView> IDHourType { get; set; } 
        public IRPSTextBox<MachineCostEntityView> DateFrom { get; set; } 
        public IRPSTextBox<MachineCostEntityView> CostPrice { get; set; } 
        public IRPSButton<MachineCostEntityView> LinkNavigationCommand { get; set; } 
        public MachineCostDetailCollectionEditor<MachineCostEntityView> MachineCostDetail { get; set; } 
        public MachineCost Screen { get; set; }
        public MachineCostEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MachineCostDetailCollectionEditor<MachineCostEntityView>:RPSCollectionEditor<MachineCostEntityView> where MachineCostEntityView : class, IView
    {
        public  MachineCostDetailGridView<MachineCostEntityView> GridView {get;set;}
    }
    public partial class MachineCostDetailGridView <MachineCostEntityView> :  RPSGridView<MachineCostEntityView> where MachineCostEntityView : class, IView
    {
        public MachineCostDetailGridView(MachineCostEntityView currentView)
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
  
            
    public partial class MachineCostDetailView : View
    {
        public MachineCostDetailView(MachineCost screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MachineCostDetailView>( this);
 
            IDCostDetailType = RPSControlFactory.CreateRPSComboBox<MachineCostDetailView>("da6208ca-c90d-4bdb-b238-a6b40226d140","","",false, this);
 
            CostPrice = RPSControlFactory.CreateRPSFormattedTextBox<MachineCostDetailView>("5ea3a34a-3eff-4dfc-a068-4b31d5987e76","","",false, this);
 

        }
        public IRPSSaveButton<MachineCostDetailView> SaveButton { get; set; } 
        public IRPSComboBox<MachineCostDetailView> IDCostDetailType { get; set; } 
        public IRPSTextBox<MachineCostDetailView> CostPrice { get; set; } 
        public MachineCost Screen { get; set; }
        public MachineCostDetailView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}