    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Warehouse.PhysicalInventory
{
    //RPS VERSION 1.0.0.0
    public partial class PhysicalInventory:Screen
    {
        public PhysicalInventory():base()
        {
            this.URL = "warehouse.physicalinventory";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            PhysicalInventoryView  = new PhysicalInventoryView(this); 
            PhysicalInventoryView.InitializeControls(); 
           
        }
      
            public PhysicalInventoryView PhysicalInventoryView {get; set; } 
    }
            
    public partial class PhysicalInventoryView : View
    {
        public PhysicalInventoryView(PhysicalInventory screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ProductLine = RPSControlFactory.CreateRPSCollectionComboBox<PhysicalInventoryView>("eb406b93-f37b-4482-9840-7b1bcebbfe61","","",false, this);
 
            Site = RPSControlFactory.CreateRPSCollectionComboBox<PhysicalInventoryView>("7ac00a0d-4d30-4a72-9fda-fd27fb544612","","",false, this);
 
            LastInventoryDate = RPSControlFactory.CreateRPSTextBox<PhysicalInventoryView>("1b4a367a-4d28-4627-8401-fcc26b1fdcaf","","",false, this);
 
            ProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<PhysicalInventoryView>("8b268937-bdb1-43bc-8655-8aae1a71efc4","","",false, this);
 
            WareHouse = RPSControlFactory.CreateRPSCollectionComboBox<PhysicalInventoryView>("de393cab-f28b-4ca7-980e-2458a4f729ee","","",false, this);
 
            WarehouseSeries = RPSControlFactory.CreateRPSEnumComboBox<PhysicalInventoryView>("bac10681-94a7-4484-a34f-f00b5513186f","","",false, this);
 
            ProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<PhysicalInventoryView>("32ed9aa2-6aae-4df6-a4e5-8739cd3fce79","","",false, this);
 
            LocationWarehouse = RPSControlFactory.CreateRPSCollectionComboBox<PhysicalInventoryView>("6a944c70-d65d-474f-8a43-98a0cedc28c3","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<PhysicalInventoryView>("9113e2d3-5b57-49a8-8c59-624b43a1bab4","","",false, this);
 
            ReportCommand = RPSControlFactory.CreateRPSButton<PhysicalInventoryView>( "dc0a9df3-ded3-4771-95c2-2444405f9003","","",this);
 

        }
        public IRPSCollectionComboBox<PhysicalInventoryView> ProductLine { get; set; } 
        public IRPSCollectionComboBox<PhysicalInventoryView> Site { get; set; } 
        public IRPSTextBox<PhysicalInventoryView> LastInventoryDate { get; set; } 
        public IRPSCollectionComboBox<PhysicalInventoryView> ProductFamily { get; set; } 
        public IRPSCollectionComboBox<PhysicalInventoryView> WareHouse { get; set; } 
        public IRPSComboBox<PhysicalInventoryView> WarehouseSeries { get; set; } 
        public IRPSCollectionComboBox<PhysicalInventoryView> ProductSubFamily { get; set; } 
        public IRPSCollectionComboBox<PhysicalInventoryView> LocationWarehouse { get; set; } 
        public IRPSCollectionComboBox<PhysicalInventoryView> Article { get; set; } 
        public IRPSButton<PhysicalInventoryView> ReportCommand { get; set; } 
        public PhysicalInventory Screen { get; set; }
        public PhysicalInventoryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}