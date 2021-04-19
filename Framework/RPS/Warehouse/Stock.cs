    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Warehouse.Stock
{
    //RPS VERSION 1.0.0.0
    public partial class Stock:Screen
    {
        public Stock():base()
        {
            this.URL = "warehouse.stock";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            StockQueryView  = new StockQueryView(this); 
            StockQueryView.InitializeControls(); 
           
        }
      
            public StockQueryView StockQueryView {get; set; } 
    }
            
    public partial class StockQueryView : View
    {
        public StockQueryView(Stock screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Article = RPSControlFactory.CreateRPSComboBox<StockQueryView>("c9b4b572-6011-497e-a060-0a1282af80e0","","",false, this);
 
            MeasureUnit = RPSControlFactory.CreateRPSComboBox<StockQueryView>("3b5a3c68-8d9c-4874-8335-8baa672a3895","","",false, this);
 
            Measure2Unit = RPSControlFactory.CreateRPSComboBox<StockQueryView>("7e6297da-2249-45d1-8603-5a6b8c87afad","","",false, this);
 
            Company = RPSControlFactory.CreateRPSComboBox<StockQueryView>("b90012fe-b890-45f0-a0bc-48e431db77e7","","",false, this);
 
            TotalStock = RPSControlFactory.CreateRPSFormattedTextBox<StockQueryView>("f61a0afc-e0ec-4c95-85dc-a50afa6cbe85","","",false, this);
 
            TotalReserve = RPSControlFactory.CreateRPSFormattedTextBox<StockQueryView>("2c1b2cb0-65b6-494f-848f-d6339073abeb","","",false, this);
 
            TotalNetStock = RPSControlFactory.CreateRPSFormattedTextBox<StockQueryView>("37bb8478-cc20-4547-881c-7fc3c1d19482","","",false, this);
 
            TotalStock2Unit = RPSControlFactory.CreateRPSFormattedTextBox<StockQueryView>("f84e7921-0e57-471a-8927-565d0967737a","","",false, this);
 
            TotalReserve2Unit = RPSControlFactory.CreateRPSFormattedTextBox<StockQueryView>("f99aaef3-c88d-47f4-a3f3-a36d074dff5c","","",false, this);
 
            TotalNetStock2Unit = RPSControlFactory.CreateRPSFormattedTextBox<StockQueryView>("08ecf006-9a29-458c-9952-3d60bc5b7ac2","","",false, this);
 
            WarehouseStock = RPSControlFactory.CreateRPSFormattedTextBox<StockQueryView>("a2e2390e-3647-46c1-9a9d-3fcc9f0e799f","","",false, this);
 
            WarehouseReserve = RPSControlFactory.CreateRPSFormattedTextBox<StockQueryView>("a28ac53e-8777-4eea-b8b9-58a18b57bfc3","","",false, this);
 
            AvailableNetStock = RPSControlFactory.CreateRPSFormattedTextBox<StockQueryView>("013711d1-ccbb-445b-9973-b9ae7790d725","","",false, this);
 
            WarehouseStock2Unit = RPSControlFactory.CreateRPSFormattedTextBox<StockQueryView>("093b4c14-ea12-42d9-8297-014ea472aa60","","",false, this);
 
            WarehouseReserve2Unit = RPSControlFactory.CreateRPSFormattedTextBox<StockQueryView>("67d788af-bcb6-412b-8dd4-f63456f67670","","",false, this);
 
            AvailableNetStock2Unit = RPSControlFactory.CreateRPSFormattedTextBox<StockQueryView>("a8cdf30c-eab6-498d-833d-6b28556fa271","","",false, this);
 
            MRPWarehouseStock = RPSControlFactory.CreateRPSFormattedTextBox<StockQueryView>("32d2dc2b-bbfd-4067-8e34-02e81cf1d0f9","","",false, this);
 
            MRPWarehouseReserve = RPSControlFactory.CreateRPSFormattedTextBox<StockQueryView>("18f320c3-c209-4ecc-922d-3b1532ec94b1","","",false, this);
 
            MRPAvailableNetStock = RPSControlFactory.CreateRPSFormattedTextBox<StockQueryView>("8f22dfad-507c-4f58-9f23-4c674208a49a","","",false, this);
 
            MRPWarehouseStock2Unit = RPSControlFactory.CreateRPSFormattedTextBox<StockQueryView>("2c067f89-0061-41f3-b288-3b163ab311bb","","",false, this);
 
            MRPWarehouseReserve2Unit = RPSControlFactory.CreateRPSFormattedTextBox<StockQueryView>("dd74b1e3-71e7-433f-a261-c2ef917bdf23","","",false, this);
 
            MRPAvailableNetStock2Unit = RPSControlFactory.CreateRPSFormattedTextBox<StockQueryView>("eb4d9c66-7306-426f-9e9f-17b8a8d63b71","","",false, this);
 
            Stock = RPSControlFactory.CreateRPSFormattedTextBox<StockQueryView>("0d434e9f-8435-49f3-9a37-2b71e8b455f8","","",false, this);
 
            Reserve = RPSControlFactory.CreateRPSFormattedTextBox<StockQueryView>("de336dce-ac10-49ae-9d0b-642574b89ba5","","",false, this);
 
            NetStock = RPSControlFactory.CreateRPSFormattedTextBox<StockQueryView>("2e965ee0-9ccf-4bd3-acf2-e00bce5d63c4","","",false, this);
 
            AvailableWarehouse = RPSControlFactory.CreateRPSCheckBox<StockQueryView>("de6e80a0-2489-4f70-9256-ac0c1fec308a","","",false, this);
 
            AvailableWarehouseMRP = RPSControlFactory.CreateRPSCheckBox<StockQueryView>("35511a08-5126-4895-b482-90131acacc96","","",false, this);
 
            Deposit = RPSControlFactory.CreateRPSCheckBox<StockQueryView>("2d74b1d9-63c4-4e44-af56-0f18da0911b8","","",false, this);
 
            MovementType = RPSControlFactory.CreateRPSComboBox<StockQueryView>("c1bc1074-ccd2-490e-a90c-ef7a2c4e4cf2","","",false, this);
 
            Stock1 = RPSControlFactory.CreateRPSFormattedTextBox<StockQueryView>("83f0f278-d0d6-4e7b-be5b-d4e9b007cdc2","","",false, this);
 
            Stock2Unit = RPSControlFactory.CreateRPSFormattedTextBox<StockQueryView>("1296a6fd-1466-4659-8c6a-7f2b6036af6a","","",false, this);
 
            MovementDate = RPSControlFactory.CreateRPSTextBox<StockQueryView>("99840b74-1e15-446c-8f1c-2406b4cec9f2","","",false, this);
 
            Reserve1 = RPSControlFactory.CreateRPSFormattedTextBox<StockQueryView>("113b33d9-f60c-4c25-9941-32fcc1113469","","",false, this);
 
            Reserve2Unit = RPSControlFactory.CreateRPSFormattedTextBox<StockQueryView>("1127bca0-077d-4a56-b9d2-9c0e3e2cbec5","","",false, this);
 
            Site1 = RPSControlFactory.CreateRPSComboBox<StockQueryView>("a5e6b88a-562f-40f0-9ef6-ec77f3ea9317","","",false, this);
 
            NetStock1 = RPSControlFactory.CreateRPSFormattedTextBox<StockQueryView>("6c8373d0-8576-473c-b5a7-50665a8b480f","","",false, this);
 
            NetStock2Unit = RPSControlFactory.CreateRPSFormattedTextBox<StockQueryView>("4d42e224-03d9-4f0f-97fd-0b0caeeb82fa","","",false, this);
 
            WareHouse = RPSControlFactory.CreateRPSComboBox<StockQueryView>("91c9e605-ccfc-4634-b2a3-bb6e128bd907","","",false, this);
 
            SupplierRef = RPSControlFactory.CreateRPSTextBox<StockQueryView>("86b5c5c2-e92b-431b-b0fe-58e2700c52e9","","",false, this);
 
            Potency = RPSControlFactory.CreateRPSFormattedTextBox<StockQueryView>("7a52d8cd-2a9c-4817-99e9-8d6d8c2046c2","","",false, this);
 
            LocationWarehouse = RPSControlFactory.CreateRPSComboBox<StockQueryView>("339e84ee-134e-46f8-a692-4c2ef6a70649","","",false, this);
 
            LastInventory = RPSControlFactory.CreateRPSTextBox<StockQueryView>("6e0829d8-36cc-4afa-92db-c246160e4849","","",false, this);
 
            AvailableWarehouse1 = RPSControlFactory.CreateRPSCheckBox<StockQueryView>("77e63421-98b1-4de8-8aa0-83a99311576b","","",false, this);
 
            Relocate = RPSControlFactory.CreateRPSButton<StockQueryView>( "da70ae9f-b4b8-4f1f-b810-3767e6cf7870","","",this);
 
            Stock11 = RPSControlFactory.CreateRPSFormattedTextBox<StockQueryView>("07ec1453-ae67-4579-92ae-f13fde45a7bc","","",false, this);
 
            LastMovement = RPSControlFactory.CreateRPSTextBox<StockQueryView>("ea07a7e7-bffe-4b10-9549-d24860752fdd","","",false, this);
 
            AvailableWarehouseMRP1 = RPSControlFactory.CreateRPSCheckBox<StockQueryView>("fcda9e99-4cf4-4e5b-bc9b-7d3a79987652","","",false, this);
 
            Stock2ndUnit = RPSControlFactory.CreateRPSFormattedTextBox<StockQueryView>("2cee7c22-47d0-43f9-ac21-b1f44c111676","","",false, this);
 
            LastEntry = RPSControlFactory.CreateRPSTextBox<StockQueryView>("a20a726b-446f-4587-91fd-b6401f2b6b34","","",false, this);
 
            Deposit1 = RPSControlFactory.CreateRPSCheckBox<StockQueryView>("63e11fc6-cd0c-417a-8bee-68d4baa50658","","",false, this);
 
            ExecuteRelocateStock = RPSControlFactory.CreateRPSButton<StockQueryView>( "d25c1da5-2af9-40c2-a0c8-4698d04d2e45","","",this);
 

        }
        public IRPSComboBox<StockQueryView> Article { get; set; } 
        public IRPSComboBox<StockQueryView> MeasureUnit { get; set; } 
        public IRPSComboBox<StockQueryView> Measure2Unit { get; set; } 
        public IRPSComboBox<StockQueryView> Company { get; set; } 
        public IRPSTextBox<StockQueryView> TotalStock { get; set; } 
        public IRPSTextBox<StockQueryView> TotalReserve { get; set; } 
        public IRPSTextBox<StockQueryView> TotalNetStock { get; set; } 
        public IRPSTextBox<StockQueryView> TotalStock2Unit { get; set; } 
        public IRPSTextBox<StockQueryView> TotalReserve2Unit { get; set; } 
        public IRPSTextBox<StockQueryView> TotalNetStock2Unit { get; set; } 
        public IRPSTextBox<StockQueryView> WarehouseStock { get; set; } 
        public IRPSTextBox<StockQueryView> WarehouseReserve { get; set; } 
        public IRPSTextBox<StockQueryView> AvailableNetStock { get; set; } 
        public IRPSTextBox<StockQueryView> WarehouseStock2Unit { get; set; } 
        public IRPSTextBox<StockQueryView> WarehouseReserve2Unit { get; set; } 
        public IRPSTextBox<StockQueryView> AvailableNetStock2Unit { get; set; } 
        public IRPSTextBox<StockQueryView> MRPWarehouseStock { get; set; } 
        public IRPSTextBox<StockQueryView> MRPWarehouseReserve { get; set; } 
        public IRPSTextBox<StockQueryView> MRPAvailableNetStock { get; set; } 
        public IRPSTextBox<StockQueryView> MRPWarehouseStock2Unit { get; set; } 
        public IRPSTextBox<StockQueryView> MRPWarehouseReserve2Unit { get; set; } 
        public IRPSTextBox<StockQueryView> MRPAvailableNetStock2Unit { get; set; } 
        public IRPSTextBox<StockQueryView> Stock { get; set; } 
        public IRPSTextBox<StockQueryView> Reserve { get; set; } 
        public IRPSTextBox<StockQueryView> NetStock { get; set; } 
        public IRPSCheckbox<StockQueryView> AvailableWarehouse { get; set; } 
        public IRPSCheckbox<StockQueryView> AvailableWarehouseMRP { get; set; } 
        public IRPSCheckbox<StockQueryView> Deposit { get; set; } 
        public IRPSComboBox<StockQueryView> MovementType { get; set; } 
        public IRPSTextBox<StockQueryView> Stock1 { get; set; } 
        public IRPSTextBox<StockQueryView> Stock2Unit { get; set; } 
        public IRPSTextBox<StockQueryView> MovementDate { get; set; } 
        public IRPSTextBox<StockQueryView> Reserve1 { get; set; } 
        public IRPSTextBox<StockQueryView> Reserve2Unit { get; set; } 
        public IRPSComboBox<StockQueryView> Site1 { get; set; } 
        public IRPSTextBox<StockQueryView> NetStock1 { get; set; } 
        public IRPSTextBox<StockQueryView> NetStock2Unit { get; set; } 
        public IRPSComboBox<StockQueryView> WareHouse { get; set; } 
        public IRPSTextBox<StockQueryView> SupplierRef { get; set; } 
        public IRPSTextBox<StockQueryView> Potency { get; set; } 
        public IRPSComboBox<StockQueryView> LocationWarehouse { get; set; } 
        public IRPSTextBox<StockQueryView> LastInventory { get; set; } 
        public IRPSCheckbox<StockQueryView> AvailableWarehouse1 { get; set; } 
        public IRPSButton<StockQueryView> Relocate { get; set; } 
        public IRPSTextBox<StockQueryView> Stock11 { get; set; } 
        public IRPSTextBox<StockQueryView> LastMovement { get; set; } 
        public IRPSCheckbox<StockQueryView> AvailableWarehouseMRP1 { get; set; } 
        public IRPSTextBox<StockQueryView> Stock2ndUnit { get; set; } 
        public IRPSTextBox<StockQueryView> LastEntry { get; set; } 
        public IRPSCheckbox<StockQueryView> Deposit1 { get; set; } 
        public IRPSButton<StockQueryView> ExecuteRelocateStock { get; set; } 
        public Stock Screen { get; set; }
        public StockQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}