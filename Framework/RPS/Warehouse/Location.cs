    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Warehouse.Location
{
    //RPS VERSION 1.0.0.0
    public partial class Location:Screen
    {
        public Location():base()
        {
            this.URL = "warehouse.location";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            LocationWarehouseVMQueryView  = new LocationWarehouseVMQueryView(this); 
            LocationWarehouseVMEntityView  = new LocationWarehouseVMEntityView(this); 
            LocationWarehouseVMQueryView.InitializeControls(); 
            LocationWarehouseVMEntityView.InitializeControls(); 
           
        }
      
            public LocationWarehouseVMQueryView LocationWarehouseVMQueryView {get; set; } 
            public LocationWarehouseVMEntityView LocationWarehouseVMEntityView {get; set; } 
    }
            
    public partial class LocationWarehouseVMQueryView : View
    {
        public LocationWarehouseVMQueryView(Location screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<LocationWarehouseVMQueryView,LocationWarehouseVMEntityView>( this,Screen.LocationWarehouseVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<LocationWarehouseVMQueryView>( this);
 
            UISite = RPSControlFactory.CreateRPSComboBox<LocationWarehouseVMQueryView>("c87a9a3e-33fd-4c30-af20-2a1d1e7cfb6c","","",false, this);
 
            UIWareHouse = RPSControlFactory.CreateRPSComboBox<LocationWarehouseVMQueryView>("b6b7dc92-fcdb-4f21-9b4d-84c7106ce8fb","","",false, this);
 
            CollectionInit params_LocationWarehouseView = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="21f30a53-08ee-4974-9544-7bd09703915c",CSSSelectorGrid="",XPathGrid=""};
            LocationWarehouseView = RPSControlFactory.RPSCreateCollectionWithGrid<LocationWarehouseViewCollectionEditor<LocationWarehouseVMQueryView,LocationWarehouseVMEntityView>,LocationWarehouseVMQueryView,LocationWarehouseVMEntityView>( params_LocationWarehouseView,this,Screen.LocationWarehouseVMEntityView);
 

        }
        public IRPSButton<LocationWarehouseVMQueryView,LocationWarehouseVMEntityView> NewButton { get; set; } 
        public IRPSButton<LocationWarehouseVMQueryView> ConsultButton { get; set; } 
        public IRPSComboBox<LocationWarehouseVMQueryView> UISite { get; set; } 
        public IRPSComboBox<LocationWarehouseVMQueryView> UIWareHouse { get; set; } 
        public LocationWarehouseViewCollectionEditor<LocationWarehouseVMQueryView,LocationWarehouseVMEntityView> LocationWarehouseView { get; set; } 
        public Location Screen { get; set; }
        public LocationWarehouseVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class LocationWarehouseViewCollectionEditor<LocationWarehouseVMQueryView,LocationWarehouseVMEntityView>:RPSCollectionEditor<LocationWarehouseVMQueryView,LocationWarehouseVMEntityView> where LocationWarehouseVMQueryView : class, IView where LocationWarehouseVMEntityView : class, IView
    {
        public  LocationWarehouseViewGridView<LocationWarehouseVMQueryView,LocationWarehouseVMEntityView> GridView {get;set;}
    }
    public partial class LocationWarehouseViewGridView <LocationWarehouseVMQueryView,LocationWarehouseVMEntityView> :  RPSGridView<LocationWarehouseVMQueryView,LocationWarehouseVMEntityView> where LocationWarehouseVMQueryView : class, IView where LocationWarehouseVMEntityView : class, IView
    {
        public LocationWarehouseViewGridView(LocationWarehouseVMQueryView currentView,LocationWarehouseVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            LocationWarehouse_CodLocationWarehouse = RPSControlFactory.CreateRPSGridTextBox<LocationWarehouseVMQueryView>("","#21f30a53-08ee-4974-9544-7bd09703915c .ag-row[role='row']@ROWINDEX [col-id='cLocationWarehouse_CodLocationWarehouse']","",false, this.CurrentView);
 
            LocationWarehouse_Description = RPSControlFactory.CreateRPSGridTextBox<LocationWarehouseVMQueryView>("","#21f30a53-08ee-4974-9544-7bd09703915c .ag-row[role='row']@ROWINDEX [col-id='cLocationWarehouse_Description']","",false, this.CurrentView);
 
            LocationWarehouse_DefaultEntry = RPSControlFactory.CreateRPSGridCheckBox<LocationWarehouseVMQueryView>("","#21f30a53-08ee-4974-9544-7bd09703915c .ag-row[role='row']@ROWINDEX [col-id='cLocationWarehouse_DefaultEntry']","",false, this.CurrentView);
 
            LocationWarehouse_DefaultOutput = RPSControlFactory.CreateRPSGridCheckBox<LocationWarehouseVMQueryView>("","#21f30a53-08ee-4974-9544-7bd09703915c .ag-row[role='row']@ROWINDEX [col-id='cLocationWarehouse_DefaultOutput']","",false, this.CurrentView);
 
            LocationWarehouse_Blocked = RPSControlFactory.CreateRPSGridCheckBox<LocationWarehouseVMQueryView>("","#21f30a53-08ee-4974-9544-7bd09703915c .ag-row[role='row']@ROWINDEX [col-id='cLocationWarehouse_Blocked']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<LocationWarehouseVMQueryView> LocationWarehouse_CodLocationWarehouse { get; set; } 
        public IRPSGridTextBox<LocationWarehouseVMQueryView> LocationWarehouse_Description { get; set; } 
        public IRPSGridCheckbox<LocationWarehouseVMQueryView> LocationWarehouse_DefaultEntry { get; set; } 
        public IRPSGridCheckbox<LocationWarehouseVMQueryView> LocationWarehouse_DefaultOutput { get; set; } 
        public IRPSGridCheckbox<LocationWarehouseVMQueryView> LocationWarehouse_Blocked { get; set; } 
                     
    }
 
    }
  
            
    public partial class LocationWarehouseVMEntityView : View
    {
        public LocationWarehouseVMEntityView(Location screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<LocationWarehouseVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<LocationWarehouseVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<LocationWarehouseVMEntityView,LocationWarehouseVMQueryView>( this,Screen.LocationWarehouseVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<LocationWarehouseVMEntityView,LocationWarehouseVMQueryView>( this,Screen.LocationWarehouseVMQueryView);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<LocationWarehouseVMEntityView>("b236cba4-92b6-417b-ae73-9f30c784432e","","",true, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<LocationWarehouseVMEntityView>("78f0bc4e-a08d-4d26-b7e3-3822e39bc741","","",true, this);
 
            CodLocationWarehouse = RPSControlFactory.CreateRPSTextBox<LocationWarehouseVMEntityView>("f7af587d-6e38-4237-90e1-f4e8551c52b6","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<LocationWarehouseVMEntityView>("6159edb9-2654-49cf-894d-58e288454690","","",false, this);
 
            DefaultEntry = RPSControlFactory.CreateRPSCheckBox<LocationWarehouseVMEntityView>("fa5c8b32-43c0-4097-95ca-6031be34d87b","","",true, this);
 
            DefaultOutput = RPSControlFactory.CreateRPSCheckBox<LocationWarehouseVMEntityView>("263ca314-9b8a-4fe1-ae86-a62ae4b860fa","","",true, this);
 
            Blocked = RPSControlFactory.CreateRPSCheckBox<LocationWarehouseVMEntityView>("700347d6-fcbe-45ce-be5e-208b2329e05d","","",true, this);
 

        }
        public IRPSSaveButton<LocationWarehouseVMEntityView> SaveButton { get; set; } 
        public IRPSButton<LocationWarehouseVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<LocationWarehouseVMEntityView,LocationWarehouseVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<LocationWarehouseVMEntityView,LocationWarehouseVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<LocationWarehouseVMEntityView> IDSite { get; set; } 
        public IRPSComboBox<LocationWarehouseVMEntityView> IDWarehouse { get; set; } 
        public IRPSTextBox<LocationWarehouseVMEntityView> CodLocationWarehouse { get; set; } 
        public IRPSTextBox<LocationWarehouseVMEntityView> Description { get; set; } 
        public IRPSCheckbox<LocationWarehouseVMEntityView> DefaultEntry { get; set; } 
        public IRPSCheckbox<LocationWarehouseVMEntityView> DefaultOutput { get; set; } 
        public IRPSCheckbox<LocationWarehouseVMEntityView> Blocked { get; set; } 
        public Location Screen { get; set; }
        public LocationWarehouseVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}