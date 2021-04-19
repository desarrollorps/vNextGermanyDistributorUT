    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Warehouse.DispersedWarehouses
{
    //RPS VERSION 1.0.0.0
    public partial class DispersedWarehouses:Screen
    {
        public DispersedWarehouses():base()
        {
            this.URL = "warehouse.dispersedwarehouses";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DispersedWarehousesQueryView  = new DispersedWarehousesQueryView(this); 
            AddSeriesChildDialogView  = new AddSeriesChildDialogView(this); 
            AddSeriesLocationChildDialogView  = new AddSeriesLocationChildDialogView(this); 
            MovementTypeChildDialogView  = new MovementTypeChildDialogView(this); 
            AddLocationChildDialogView  = new AddLocationChildDialogView(this); 
            DispersedWarehousesQueryView.InitializeControls(); 
            AddSeriesChildDialogView.InitializeControls(); 
            AddSeriesLocationChildDialogView.InitializeControls(); 
            MovementTypeChildDialogView.InitializeControls(); 
            AddLocationChildDialogView.InitializeControls(); 
           
        }
      
            public DispersedWarehousesQueryView DispersedWarehousesQueryView {get; set; } 
            public AddSeriesChildDialogView AddSeriesChildDialogView {get; set; } 
            public AddSeriesLocationChildDialogView AddSeriesLocationChildDialogView {get; set; } 
            public MovementTypeChildDialogView MovementTypeChildDialogView {get; set; } 
            public AddLocationChildDialogView AddLocationChildDialogView {get; set; } 
    }
            
    public partial class DispersedWarehousesQueryView : View
    {
        public DispersedWarehousesQueryView(DispersedWarehouses screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ProductLine = RPSControlFactory.CreateRPSCollectionComboBox<DispersedWarehousesQueryView>("e375c3da-7484-4382-a796-ac454272876f","","",false, this);
 
            ProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<DispersedWarehousesQueryView>("c7be934f-0b99-4f23-904a-e4b55098634e","","",false, this);
 
            ProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<DispersedWarehousesQueryView>("25711668-7659-4c6f-a957-943a2309f419","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<DispersedWarehousesQueryView>("da2d4e2f-e100-465c-abff-2fcef4acfcaf","","",false, this);
 
            IDSiteOriginal = RPSControlFactory.CreateRPSComboBox<DispersedWarehousesQueryView>("06d71a9c-7911-4ac5-8da9-5f31fe6c439a","","",false, this);
 
            IDWareHouseOriginal = RPSControlFactory.CreateRPSComboBox<DispersedWarehousesQueryView>("2ffea425-d693-40e7-831b-3bed7a46e98b","","",false, this);
 
            IDSiteDes = RPSControlFactory.CreateRPSComboBox<DispersedWarehousesQueryView>("4c340d49-379e-4a62-aa67-df0c503d7e06","","",false, this);
 
            IDWareHouseDesList = RPSControlFactory.CreateRPSCollectionComboBox<DispersedWarehousesQueryView>("72790767-1a1a-47b2-b1f0-789628b8ca09","","",false, this);
 
            OnlyArticlesToTransfer = RPSControlFactory.CreateRPSCheckBox<DispersedWarehousesQueryView>("5e82c984-7bff-4d87-9792-e3e22cf12422","","",false, this);
 
            MinimunStock = RPSControlFactory.CreateRPSOption<DispersedWarehousesQueryView>( "cbae2c11-ea6b-4b23-b61f-a515c7899efa","","",this);
 
            TotalStock = RPSControlFactory.CreateRPSOption<DispersedWarehousesQueryView>( "904cd2c5-150d-4acb-8315-9ad7d90a329c","","",this);
 
            MovementTypeChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DispersedWarehousesQueryView,MovementTypeChildDialogView>("8472b2fc-01bd-4eae-ad2d-ad33bb87c112","","", this,Screen.MovementTypeChildDialogView);
 
            CollectionInit params_DispersedWarehouses = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1a063f50-7fa0-410a-8dbc-41678596a31c",CSSSelectorGrid="",XPathGrid=""};
            DispersedWarehouses = RPSControlFactory.RPSCreateCollectionWithGrid<DispersedWarehousesCollectionEditor<DispersedWarehousesQueryView,AddSeriesChildDialogView>,DispersedWarehousesQueryView,AddSeriesChildDialogView>( params_DispersedWarehouses,this,Screen.AddSeriesChildDialogView);
 

        }
        public IRPSCollectionComboBox<DispersedWarehousesQueryView> ProductLine { get; set; } 
        public IRPSCollectionComboBox<DispersedWarehousesQueryView> ProductSubFamily { get; set; } 
        public IRPSCollectionComboBox<DispersedWarehousesQueryView> ProductFamily { get; set; } 
        public IRPSComboBox<DispersedWarehousesQueryView> IDArticle { get; set; } 
        public IRPSComboBox<DispersedWarehousesQueryView> IDSiteOriginal { get; set; } 
        public IRPSComboBox<DispersedWarehousesQueryView> IDWareHouseOriginal { get; set; } 
        public IRPSComboBox<DispersedWarehousesQueryView> IDSiteDes { get; set; } 
        public IRPSCollectionComboBox<DispersedWarehousesQueryView> IDWareHouseDesList { get; set; } 
        public IRPSCheckbox<DispersedWarehousesQueryView> OnlyArticlesToTransfer { get; set; } 
        public IRPSOption<DispersedWarehousesQueryView> MinimunStock { get; set; } 
        public IRPSOption<DispersedWarehousesQueryView> TotalStock { get; set; } 
        public IRPSButton<DispersedWarehousesQueryView,MovementTypeChildDialogView> MovementTypeChildNavigationCommandButton { get; set; } 
        public DispersedWarehousesCollectionEditor<DispersedWarehousesQueryView,AddSeriesChildDialogView> DispersedWarehouses { get; set; } 
        public DispersedWarehouses Screen { get; set; }
        public DispersedWarehousesQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DispersedWarehousesCollectionEditor<DispersedWarehousesQueryView,AddSeriesChildDialogView>:RPSCollectionEditor<DispersedWarehousesQueryView,AddSeriesChildDialogView> where DispersedWarehousesQueryView : class, IView where AddSeriesChildDialogView : class, IView
    {
        public  DispersedWarehousesGridView<DispersedWarehousesQueryView,AddSeriesChildDialogView> GridView {get;set;}
    }
    public partial class DispersedWarehousesGridView <DispersedWarehousesQueryView,AddSeriesChildDialogView> :  RPSGridView<DispersedWarehousesQueryView,AddSeriesChildDialogView> where DispersedWarehousesQueryView : class, IView where AddSeriesChildDialogView : class, IView
    {
        public DispersedWarehousesGridView(DispersedWarehousesQueryView currentView,AddSeriesChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            StockSecondUnit = RPSControlFactory.CreateRPSGridFormattedTextBox<DispersedWarehousesQueryView>("","#1a063f50-7fa0-410a-8dbc-41678596a31c .ag-row[role='row']@ROWINDEX [col-id='cStockSecondUnit']","",false, this.CurrentView);
 
            AvailableDisp = RPSControlFactory.CreateRPSGridFormattedTextBox<DispersedWarehousesQueryView>("","#1a063f50-7fa0-410a-8dbc-41678596a31c .ag-row[role='row']@ROWINDEX [col-id='cAvailableDisp']","",false, this.CurrentView);
 
            Realice = RPSControlFactory.CreateRPSGridCheckBox<DispersedWarehousesQueryView>("","#1a063f50-7fa0-410a-8dbc-41678596a31c .ag-row[role='row']@ROWINDEX [col-id='cRealice']","",false, this.CurrentView);
 
            AvailableDisp2unit = RPSControlFactory.CreateRPSGridFormattedTextBox<DispersedWarehousesQueryView>("","#1a063f50-7fa0-410a-8dbc-41678596a31c .ag-row[role='row']@ROWINDEX [col-id='cAvailableDisp2unit']","",false, this.CurrentView);
 
            Comment = RPSControlFactory.CreateRPSGridTextBox<DispersedWarehousesQueryView>("","#1a063f50-7fa0-410a-8dbc-41678596a31c .ag-row[role='row']@ROWINDEX [col-id='cComment']","",false, this.CurrentView);
 
            IDLocationWarehouse = RPSControlFactory.CreateRPSGridComboBox<DispersedWarehousesQueryView>("","#1a063f50-7fa0-410a-8dbc-41678596a31c .ag-row[role='row']@ROWINDEX [col-id='cIDLocationWarehouse']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<DispersedWarehousesQueryView> StockSecondUnit { get; set; } 
        public IRPSGridTextBox<DispersedWarehousesQueryView> AvailableDisp { get; set; } 
        public IRPSGridCheckbox<DispersedWarehousesQueryView> Realice { get; set; } 
        public IRPSGridTextBox<DispersedWarehousesQueryView> AvailableDisp2unit { get; set; } 
        public IRPSGridTextBox<DispersedWarehousesQueryView> Comment { get; set; } 
        public IRPSGridComboBox<DispersedWarehousesQueryView> IDLocationWarehouse { get; set; } 
                     
    }
 
    }
  
            
    public partial class AddSeriesChildDialogView : View
    {
        public AddSeriesChildDialogView(DispersedWarehouses screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDWareHouseDestino = RPSControlFactory.CreateRPSComboBox<AddSeriesChildDialogView>("e9a9627a-8dd9-48ff-a326-006da1e350ec","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<AddSeriesChildDialogView>("9342a63c-366b-48ac-8c9f-7580fe6f5339","","",false, this);
 
            CollectionInit params_SeriesDataItemlCollection = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5f333cb5-4d9f-4e84-89b5-de4be0fd913e",CSSSelectorGrid="",XPathGrid=""};
            SeriesDataItemlCollection = RPSControlFactory.RPSCreateCollectionWithGrid<SeriesDataItemlCollectionCollectionEditor<AddSeriesChildDialogView>,AddSeriesChildDialogView>( params_SeriesDataItemlCollection,this);
 

        }
        public IRPSComboBox<AddSeriesChildDialogView> IDWareHouseDestino { get; set; } 
        public IRPSTextBox<AddSeriesChildDialogView> Quantity { get; set; } 
        public SeriesDataItemlCollectionCollectionEditor<AddSeriesChildDialogView> SeriesDataItemlCollection { get; set; } 
        public DispersedWarehouses Screen { get; set; }
        public AddSeriesChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SeriesDataItemlCollectionCollectionEditor<AddSeriesChildDialogView>:RPSCollectionEditor<AddSeriesChildDialogView> where AddSeriesChildDialogView : class, IView
    {
        public  SeriesDataItemlCollectionGridView<AddSeriesChildDialogView> GridView {get;set;}
    }
    public partial class SeriesDataItemlCollectionGridView <AddSeriesChildDialogView> :  RPSGridView<AddSeriesChildDialogView> where AddSeriesChildDialogView : class, IView
    {
        public SeriesDataItemlCollectionGridView(AddSeriesChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Series = RPSControlFactory.CreateRPSGridEnumComboBox<AddSeriesChildDialogView>("","#5f333cb5-4d9f-4e84-89b5-de4be0fd913e .ag-row[role='row']@ROWINDEX [col-id='cSeries']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<AddSeriesChildDialogView>("","#5f333cb5-4d9f-4e84-89b5-de4be0fd913e .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSGridFormattedTextBox<AddSeriesChildDialogView>("","#5f333cb5-4d9f-4e84-89b5-de4be0fd913e .ag-row[role='row']@ROWINDEX [col-id='cQuantitySecondUnit']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<AddSeriesChildDialogView> Series { get; set; } 
        public IRPSGridTextBox<AddSeriesChildDialogView> Quantity { get; set; } 
        public IRPSGridTextBox<AddSeriesChildDialogView> QuantitySecondUnit { get; set; } 
                     
    }
 
    }
  
            
    public partial class AddSeriesLocationChildDialogView : View
    {
        public AddSeriesLocationChildDialogView(DispersedWarehouses screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDWareHouseDestino = RPSControlFactory.CreateRPSComboBox<AddSeriesLocationChildDialogView>("f12f7287-2936-4a00-8455-9b0426dc9033","","",false, this);
 
            LocationWarehouse = RPSControlFactory.CreateRPSComboBox<AddSeriesLocationChildDialogView>("a94ad389-25b8-4e44-a3c2-02ce606dadbe","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<AddSeriesLocationChildDialogView>("a75f3f98-eb9f-43e3-8fb0-5994908a0be5","","",false, this);
 
            CollectionInit params_SeriesLocationDataItemlCollection = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="fca079ce-8b72-4fbf-9c9b-210e111c3186",CSSSelectorGrid="",XPathGrid=""};
            SeriesLocationDataItemlCollection = RPSControlFactory.RPSCreateCollectionWithGrid<SeriesLocationDataItemlCollectionCollectionEditor<AddSeriesLocationChildDialogView>,AddSeriesLocationChildDialogView>( params_SeriesLocationDataItemlCollection,this);
 

        }
        public IRPSComboBox<AddSeriesLocationChildDialogView> IDWareHouseDestino { get; set; } 
        public IRPSComboBox<AddSeriesLocationChildDialogView> LocationWarehouse { get; set; } 
        public IRPSTextBox<AddSeriesLocationChildDialogView> Quantity { get; set; } 
        public SeriesLocationDataItemlCollectionCollectionEditor<AddSeriesLocationChildDialogView> SeriesLocationDataItemlCollection { get; set; } 
        public DispersedWarehouses Screen { get; set; }
        public AddSeriesLocationChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class SeriesLocationDataItemlCollectionCollectionEditor<AddSeriesLocationChildDialogView>:RPSCollectionEditor<AddSeriesLocationChildDialogView> where AddSeriesLocationChildDialogView : class, IView
    {
        public  SeriesLocationDataItemlCollectionGridView<AddSeriesLocationChildDialogView> GridView {get;set;}
    }
    public partial class SeriesLocationDataItemlCollectionGridView <AddSeriesLocationChildDialogView> :  RPSGridView<AddSeriesLocationChildDialogView> where AddSeriesLocationChildDialogView : class, IView
    {
        public SeriesLocationDataItemlCollectionGridView(AddSeriesLocationChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Series = RPSControlFactory.CreateRPSGridEnumComboBox<AddSeriesLocationChildDialogView>("","#fca079ce-8b72-4fbf-9c9b-210e111c3186 .ag-row[role='row']@ROWINDEX [col-id='cSeries']","",false, this.CurrentView);
 
            IDLocationWarehouseOrigen = RPSControlFactory.CreateRPSGridComboBox<AddSeriesLocationChildDialogView>("","#fca079ce-8b72-4fbf-9c9b-210e111c3186 .ag-row[role='row']@ROWINDEX [col-id='cIDLocationWarehouseOrigen']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<AddSeriesLocationChildDialogView>("","#fca079ce-8b72-4fbf-9c9b-210e111c3186 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            IDLocationWarehouseDestino = RPSControlFactory.CreateRPSGridComboBox<AddSeriesLocationChildDialogView>("","#fca079ce-8b72-4fbf-9c9b-210e111c3186 .ag-row[role='row']@ROWINDEX [col-id='cIDLocationWarehouseDestino']","",false, this.CurrentView);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSGridFormattedTextBox<AddSeriesLocationChildDialogView>("","#fca079ce-8b72-4fbf-9c9b-210e111c3186 .ag-row[role='row']@ROWINDEX [col-id='cQuantitySecondUnit']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<AddSeriesLocationChildDialogView> Series { get; set; } 
        public IRPSGridComboBox<AddSeriesLocationChildDialogView> IDLocationWarehouseOrigen { get; set; } 
        public IRPSGridTextBox<AddSeriesLocationChildDialogView> Quantity { get; set; } 
        public IRPSGridComboBox<AddSeriesLocationChildDialogView> IDLocationWarehouseDestino { get; set; } 
        public IRPSGridTextBox<AddSeriesLocationChildDialogView> QuantitySecondUnit { get; set; } 
                     
    }
 
    }
  
            
    public partial class MovementTypeChildDialogView : View
    {
        public MovementTypeChildDialogView(DispersedWarehouses screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDMovementType = RPSControlFactory.CreateRPSComboBox<MovementTypeChildDialogView>("eb6900dd-03f8-49b6-b8ab-a0cce36688b1","","",true, this);
 
            MovementDate = RPSControlFactory.CreateRPSTextBox<MovementTypeChildDialogView>("d9765865-f3ca-400a-a542-0d6294523eb8","","",true, this);
 
            Comment = RPSControlFactory.CreateRPSTextBox<MovementTypeChildDialogView>("6c4fc1b2-da0a-489b-a886-386eae062eb9","","",false, this);
 

        }
        public IRPSComboBox<MovementTypeChildDialogView> IDMovementType { get; set; } 
        public IRPSTextBox<MovementTypeChildDialogView> MovementDate { get; set; } 
        public IRPSTextBox<MovementTypeChildDialogView> Comment { get; set; } 
        public DispersedWarehouses Screen { get; set; }
        public MovementTypeChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class AddLocationChildDialogView : View
    {
        public AddLocationChildDialogView(DispersedWarehouses screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDWareHouseDestino = RPSControlFactory.CreateRPSComboBox<AddLocationChildDialogView>("bc615504-d4cf-420c-9b26-02f1f10ff2c9","","",false, this);
 
            LocationWarehouse = RPSControlFactory.CreateRPSComboBox<AddLocationChildDialogView>("46e7c93a-6072-4e31-bdc7-64277577ab78","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<AddLocationChildDialogView>("f6f9ffb8-490f-4898-ba0d-e7670fc2a81c","","",false, this);
 
            CollectionInit params_LocationDataItemlCollection = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="03a7019c-d997-4474-beec-0ff7fef1c5a4",CSSSelectorGrid="",XPathGrid=""};
            LocationDataItemlCollection = RPSControlFactory.RPSCreateCollectionWithGrid<LocationDataItemlCollectionCollectionEditor<AddLocationChildDialogView>,AddLocationChildDialogView>( params_LocationDataItemlCollection,this);
 

        }
        public IRPSComboBox<AddLocationChildDialogView> IDWareHouseDestino { get; set; } 
        public IRPSComboBox<AddLocationChildDialogView> LocationWarehouse { get; set; } 
        public IRPSTextBox<AddLocationChildDialogView> Quantity { get; set; } 
        public LocationDataItemlCollectionCollectionEditor<AddLocationChildDialogView> LocationDataItemlCollection { get; set; } 
        public DispersedWarehouses Screen { get; set; }
        public AddLocationChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class LocationDataItemlCollectionCollectionEditor<AddLocationChildDialogView>:RPSCollectionEditor<AddLocationChildDialogView> where AddLocationChildDialogView : class, IView
    {
        public  LocationDataItemlCollectionGridView<AddLocationChildDialogView> GridView {get;set;}
    }
    public partial class LocationDataItemlCollectionGridView <AddLocationChildDialogView> :  RPSGridView<AddLocationChildDialogView> where AddLocationChildDialogView : class, IView
    {
        public LocationDataItemlCollectionGridView(AddLocationChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDLocationWarehouseOrigen = RPSControlFactory.CreateRPSGridComboBox<AddLocationChildDialogView>("","#03a7019c-d997-4474-beec-0ff7fef1c5a4 .ag-row[role='row']@ROWINDEX [col-id='cIDLocationWarehouseOrigen']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<AddLocationChildDialogView>("","#03a7019c-d997-4474-beec-0ff7fef1c5a4 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            IDLocationWarehouseDestino = RPSControlFactory.CreateRPSGridComboBox<AddLocationChildDialogView>("","#03a7019c-d997-4474-beec-0ff7fef1c5a4 .ag-row[role='row']@ROWINDEX [col-id='cIDLocationWarehouseDestino']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<AddLocationChildDialogView> IDLocationWarehouseOrigen { get; set; } 
        public IRPSGridTextBox<AddLocationChildDialogView> Quantity { get; set; } 
        public IRPSGridComboBox<AddLocationChildDialogView> IDLocationWarehouseDestino { get; set; } 
                     
    }
 
    }
  
    

}