    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Warehouse.Locations
{
    //RPS VERSION 1.0.0.0
    public partial class Locations:Screen
    {
        public Locations():base()
        {
            this.URL = "warehouse.locations";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            LocationsQueryView  = new LocationsQueryView(this); 
            ArticlesDataChildDialogView  = new ArticlesDataChildDialogView(this); 
            LocationsQueryView.InitializeControls(); 
            ArticlesDataChildDialogView.InitializeControls(); 
           
        }
      
            public LocationsQueryView LocationsQueryView {get; set; } 
            public ArticlesDataChildDialogView ArticlesDataChildDialogView {get; set; } 
    }
            
    public partial class LocationsQueryView : View
    {
        public LocationsQueryView(Locations screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            LocationsWithStock = RPSControlFactory.CreateRPSOption<LocationsQueryView>( "37333283-aeb6-4a53-9593-f3d2fba9f376","","",this);
 
            LocationsWithoutStock = RPSControlFactory.CreateRPSOption<LocationsQueryView>( "133b96e8-2010-4383-9a58-01c12b0db855","","",this);
 
            ProductLine = RPSControlFactory.CreateRPSCollectionComboBox<LocationsQueryView>("43f362cc-9912-4623-b888-b4165c000b3a","","",false, this);
 
            Site = RPSControlFactory.CreateRPSCollectionComboBox<LocationsQueryView>("10691130-69f2-495e-a4d1-51e87b617ecb","","",false, this);
 
            ProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<LocationsQueryView>("e01cd346-a60f-4704-80cc-7489f546b20b","","",false, this);
 
            WareHouse = RPSControlFactory.CreateRPSCollectionComboBox<LocationsQueryView>("39a08cb8-f619-4454-a5d1-9cd90f33176b","","",false, this);
 
            ProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<LocationsQueryView>("58235a6a-bc64-4478-888e-7d3a1958b619","","",false, this);
 
            LocationWarehouse = RPSControlFactory.CreateRPSCollectionComboBox<LocationsQueryView>("b2ecdba9-87ee-45cc-83b7-e7be5adafec6","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<LocationsQueryView>("c9c34750-ba28-4d5a-b051-a5252f6346f2","","",false, this);
 
            CollectionInit params_LocationsQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="84c53235-d32a-44cd-af17-fd49c79de141",CSSSelectorGrid="",XPathGrid=""};
            LocationsQuery = RPSControlFactory.RPSCreateCollectionWithGrid<LocationsQueryCollectionEditor<LocationsQueryView>,LocationsQueryView>( params_LocationsQuery,this);
 

        }
        public IRPSOption<LocationsQueryView> LocationsWithStock { get; set; } 
        public IRPSOption<LocationsQueryView> LocationsWithoutStock { get; set; } 
        public IRPSCollectionComboBox<LocationsQueryView> ProductLine { get; set; } 
        public IRPSCollectionComboBox<LocationsQueryView> Site { get; set; } 
        public IRPSCollectionComboBox<LocationsQueryView> ProductFamily { get; set; } 
        public IRPSCollectionComboBox<LocationsQueryView> WareHouse { get; set; } 
        public IRPSCollectionComboBox<LocationsQueryView> ProductSubFamily { get; set; } 
        public IRPSCollectionComboBox<LocationsQueryView> LocationWarehouse { get; set; } 
        public IRPSCollectionComboBox<LocationsQueryView> Article { get; set; } 
        public LocationsQueryCollectionEditor<LocationsQueryView> LocationsQuery { get; set; } 
        public Locations Screen { get; set; }
        public LocationsQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class LocationsQueryCollectionEditor<LocationsQueryView>:RPSCollectionEditor<LocationsQueryView> where LocationsQueryView : class, IView
    {
        public  LocationsQueryGridView<LocationsQueryView> GridView {get;set;}
    }
    public partial class LocationsQueryGridView <LocationsQueryView> :  RPSGridView<LocationsQueryView> where LocationsQueryView : class, IView
    {
        public LocationsQueryGridView(LocationsQueryView currentView)
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
  
            
    public partial class ArticlesDataChildDialogView : View
    {
        public ArticlesDataChildDialogView(Locations screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_LocationsData = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3c8584be-7aaa-4738-abb5-97ba23c12f05",CSSSelectorGrid="",XPathGrid=""};
            LocationsData = RPSControlFactory.RPSCreateCollectionWithGrid<LocationsDataCollectionEditor<ArticlesDataChildDialogView>,ArticlesDataChildDialogView>( params_LocationsData,this);
 

        }
        public LocationsDataCollectionEditor<ArticlesDataChildDialogView> LocationsData { get; set; } 
        public Locations Screen { get; set; }
        public ArticlesDataChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class LocationsDataCollectionEditor<ArticlesDataChildDialogView>:RPSCollectionEditor<ArticlesDataChildDialogView> where ArticlesDataChildDialogView : class, IView
    {
        public  LocationsDataGridView<ArticlesDataChildDialogView> GridView {get;set;}
    }
    public partial class LocationsDataGridView <ArticlesDataChildDialogView> :  RPSGridView<ArticlesDataChildDialogView> where ArticlesDataChildDialogView : class, IView
    {
        public LocationsDataGridView(ArticlesDataChildDialogView currentView)
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