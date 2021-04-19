    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Warehouse.ListInventaryGroupDate
{
    //RPS VERSION 1.0.0.0
    public partial class ListInventaryGroupDate:Screen
    {
        public ListInventaryGroupDate():base()
        {
            this.URL = "warehouse.listinventarygroupdate";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ListInventaryGroupDateQueryView  = new ListInventaryGroupDateQueryView(this); 
            InventoryDatasGroupPrintDialogView  = new InventoryDatasGroupPrintDialogView(this); 
            ListInventaryGroupDateQueryView.InitializeControls(); 
            InventoryDatasGroupPrintDialogView.InitializeControls(); 
           
        }
      
            public ListInventaryGroupDateQueryView ListInventaryGroupDateQueryView {get; set; } 
            public InventoryDatasGroupPrintDialogView InventoryDatasGroupPrintDialogView {get; set; } 
    }
            
    public partial class ListInventaryGroupDateQueryView : View
    {
        public ListInventaryGroupDateQueryView(ListInventaryGroupDate screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DateTo = RPSControlFactory.CreateRPSTextBox<ListInventaryGroupDateQueryView>("3b685158-201e-4e41-bf4a-905927afd61f","","",true, this);
 
            SavedInventory = RPSControlFactory.CreateRPSCheckBox<ListInventaryGroupDateQueryView>("d630ae7f-8f39-411e-a409-f5579b135deb","","",false, this);
 
            Inventary = RPSControlFactory.CreateRPSComboBox<ListInventaryGroupDateQueryView>("19a9280d-5467-4d34-9bdf-265910f31374","","",false, this);
 
            GroupProductLine = RPSControlFactory.CreateRPSCheckBox<ListInventaryGroupDateQueryView>("af42a132-a034-4aec-8667-f2e73a7da46b","","",false, this);
 
            GroupProductFamily = RPSControlFactory.CreateRPSCheckBox<ListInventaryGroupDateQueryView>("9cc5144d-5bd5-4604-9294-0650c127872c","","",false, this);
 
            GroupProductSubFamily = RPSControlFactory.CreateRPSCheckBox<ListInventaryGroupDateQueryView>("4b489991-21f8-419d-884c-a03845954df7","","",false, this);
 
            GroupArticle = RPSControlFactory.CreateRPSCheckBox<ListInventaryGroupDateQueryView>("974ccacd-527f-4b88-86a4-a628389d6fa6","","",false, this);
 
            GroupSite = RPSControlFactory.CreateRPSCheckBox<ListInventaryGroupDateQueryView>("bd60a7d7-06fc-44d0-bae4-2891314d7890","","",false, this);
 
            GroupWarehouse = RPSControlFactory.CreateRPSCheckBox<ListInventaryGroupDateQueryView>("bc346414-176b-4b69-bd41-526979ff34ce","","",false, this);
 
            GroupSerie = RPSControlFactory.CreateRPSCheckBox<ListInventaryGroupDateQueryView>("5079a5e0-cf2d-4977-9a97-e72d719c3800","","",false, this);
 
            GroupLocation = RPSControlFactory.CreateRPSCheckBox<ListInventaryGroupDateQueryView>("9ade94a6-22f9-4eed-be96-6bba7a6f305d","","",false, this);
 
            ProductLine = RPSControlFactory.CreateRPSCollectionComboBox<ListInventaryGroupDateQueryView>("1e41aae3-96a1-4e49-8437-9f34a728526b","","",false, this);
 
            ProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<ListInventaryGroupDateQueryView>("6a1d2105-3b7e-4dac-a8d2-93c8a3b9fc5e","","",false, this);
 
            ProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<ListInventaryGroupDateQueryView>("40feac13-c875-4cde-a233-0fa814d06dc4","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<ListInventaryGroupDateQueryView>("fe97ee6a-69d6-4b42-aad9-18f69ac912f0","","",false, this);
 
            Site = RPSControlFactory.CreateRPSCollectionComboBox<ListInventaryGroupDateQueryView>("271e72be-d371-4687-9ff2-bc9e5d9fb0f2","","",false, this);
 
            WareHouse = RPSControlFactory.CreateRPSCollectionComboBox<ListInventaryGroupDateQueryView>("5ed336de-0e91-460b-9d45-ddf7e432c4aa","","",false, this);
 
            WarehouseSeries = RPSControlFactory.CreateRPSEnumComboBox<ListInventaryGroupDateQueryView>("634c4a58-a4b3-4c3f-b4f0-6ea4d75292a4","","",false, this);
 
            LocationWarehouse = RPSControlFactory.CreateRPSCollectionComboBox<ListInventaryGroupDateQueryView>("9a3fbc42-6706-434b-b30d-d84d4644edf0","","",false, this);
 
            Valorated = RPSControlFactory.CreateRPSCheckBox<ListInventaryGroupDateQueryView>("b64f1159-deaf-45da-bb18-b8b495181bdb","","",false, this);
 
            WithOutNegativeStock = RPSControlFactory.CreateRPSCheckBox<ListInventaryGroupDateQueryView>("ac5195fd-11ce-42c9-955e-1f8f98bdcea1","","",false, this);
 
            IncludeNotAvailableWarehouse = RPSControlFactory.CreateRPSCheckBox<ListInventaryGroupDateQueryView>("dcee43ef-2587-4ce1-bb3e-c4199c326262","","",false, this);
 
            DiscardDepositWarehouse = RPSControlFactory.CreateRPSCheckBox<ListInventaryGroupDateQueryView>("98655fd4-9196-408a-9b47-448ea9948ab2","","",false, this);
 
            Prices = RPSControlFactory.CreateRPSOption<ListInventaryGroupDateQueryView>( "abb886a9-7bed-4cdb-aa18-00b5f767222b","","",this);
 
            Purchase = RPSControlFactory.CreateRPSOption<ListInventaryGroupDateQueryView>( "2ef877a3-b66f-4e40-b079-f28975f29aaa","","",this);
 
            Manufacture = RPSControlFactory.CreateRPSOption<ListInventaryGroupDateQueryView>( "e7ff89d8-2e7a-4ee6-ba88-210bc6218a3b","","",this);
 
            Average = RPSControlFactory.CreateRPSOption<ListInventaryGroupDateQueryView>( "2d6866a9-7a97-4593-9af9-7e28eb93f748","","",this);
 
            Standard = RPSControlFactory.CreateRPSOption<ListInventaryGroupDateQueryView>( "d38ba3d4-154d-4b63-8bc4-b66bb98939af","","",this);
 
            Article1 = RPSControlFactory.CreateRPSOption<ListInventaryGroupDateQueryView>( "8e60a82d-44e0-42a6-99eb-1fc8073cc76a","","",this);
 
            Site1 = RPSControlFactory.CreateRPSOption<ListInventaryGroupDateQueryView>( "61fe5344-cc79-47f8-abe2-54b1436467c8","","",this);
 
            Warehouse = RPSControlFactory.CreateRPSOption<ListInventaryGroupDateQueryView>( "526f35ef-5b36-48d3-8235-5a61f5138c14","","",this);
 
            Series = RPSControlFactory.CreateRPSOption<ListInventaryGroupDateQueryView>( "a1f52089-44df-4635-906e-b62c7dc39f23","","",this);
 
            Total = RPSControlFactory.CreateRPSFormattedTextBox<ListInventaryGroupDateQueryView>("72735cdc-6dd0-42cf-9687-f059e67b29b6","","",false, this);
 
            InventoryDatasGroupPrintNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ListInventaryGroupDateQueryView,InventoryDatasGroupPrintDialogView>("1caa12de-b30b-4f7e-9400-f41c0d3ed438","","", this,Screen.InventoryDatasGroupPrintDialogView);
 

        }
        public IRPSTextBox<ListInventaryGroupDateQueryView> DateTo { get; set; } 
        public IRPSCheckbox<ListInventaryGroupDateQueryView> SavedInventory { get; set; } 
        public IRPSComboBox<ListInventaryGroupDateQueryView> Inventary { get; set; } 
        public IRPSCheckbox<ListInventaryGroupDateQueryView> GroupProductLine { get; set; } 
        public IRPSCheckbox<ListInventaryGroupDateQueryView> GroupProductFamily { get; set; } 
        public IRPSCheckbox<ListInventaryGroupDateQueryView> GroupProductSubFamily { get; set; } 
        public IRPSCheckbox<ListInventaryGroupDateQueryView> GroupArticle { get; set; } 
        public IRPSCheckbox<ListInventaryGroupDateQueryView> GroupSite { get; set; } 
        public IRPSCheckbox<ListInventaryGroupDateQueryView> GroupWarehouse { get; set; } 
        public IRPSCheckbox<ListInventaryGroupDateQueryView> GroupSerie { get; set; } 
        public IRPSCheckbox<ListInventaryGroupDateQueryView> GroupLocation { get; set; } 
        public IRPSCollectionComboBox<ListInventaryGroupDateQueryView> ProductLine { get; set; } 
        public IRPSCollectionComboBox<ListInventaryGroupDateQueryView> ProductFamily { get; set; } 
        public IRPSCollectionComboBox<ListInventaryGroupDateQueryView> ProductSubFamily { get; set; } 
        public IRPSCollectionComboBox<ListInventaryGroupDateQueryView> Article { get; set; } 
        public IRPSCollectionComboBox<ListInventaryGroupDateQueryView> Site { get; set; } 
        public IRPSCollectionComboBox<ListInventaryGroupDateQueryView> WareHouse { get; set; } 
        public IRPSComboBox<ListInventaryGroupDateQueryView> WarehouseSeries { get; set; } 
        public IRPSCollectionComboBox<ListInventaryGroupDateQueryView> LocationWarehouse { get; set; } 
        public IRPSCheckbox<ListInventaryGroupDateQueryView> Valorated { get; set; } 
        public IRPSCheckbox<ListInventaryGroupDateQueryView> WithOutNegativeStock { get; set; } 
        public IRPSCheckbox<ListInventaryGroupDateQueryView> IncludeNotAvailableWarehouse { get; set; } 
        public IRPSCheckbox<ListInventaryGroupDateQueryView> DiscardDepositWarehouse { get; set; } 
        public IRPSOption<ListInventaryGroupDateQueryView> Prices { get; set; } 
        public IRPSOption<ListInventaryGroupDateQueryView> Purchase { get; set; } 
        public IRPSOption<ListInventaryGroupDateQueryView> Manufacture { get; set; } 
        public IRPSOption<ListInventaryGroupDateQueryView> Average { get; set; } 
        public IRPSOption<ListInventaryGroupDateQueryView> Standard { get; set; } 
        public IRPSOption<ListInventaryGroupDateQueryView> Article1 { get; set; } 
        public IRPSOption<ListInventaryGroupDateQueryView> Site1 { get; set; } 
        public IRPSOption<ListInventaryGroupDateQueryView> Warehouse { get; set; } 
        public IRPSOption<ListInventaryGroupDateQueryView> Series { get; set; } 
        public IRPSTextBox<ListInventaryGroupDateQueryView> Total { get; set; } 
        public IRPSButton<ListInventaryGroupDateQueryView,InventoryDatasGroupPrintDialogView> InventoryDatasGroupPrintNavigationCommandButton { get; set; } 
        public ListInventaryGroupDate Screen { get; set; }
        public ListInventaryGroupDateQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class InventoryDatasGroupPrintDialogView : View
    {
        public InventoryDatasGroupPrintDialogView(ListInventaryGroupDate screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIOptGrouped = RPSControlFactory.CreateRPSOption<InventoryDatasGroupPrintDialogView>( "877d4a1a-042a-429d-aa60-9b9629c0a496","","",this);
 
            UIOptDetailed = RPSControlFactory.CreateRPSOption<InventoryDatasGroupPrintDialogView>( "82e5ca6c-876b-4fb6-aa69-a388c6704b0b","","",this);
 

        }
        public IRPSOption<InventoryDatasGroupPrintDialogView> UIOptGrouped { get; set; } 
        public IRPSOption<InventoryDatasGroupPrintDialogView> UIOptDetailed { get; set; } 
        public ListInventaryGroupDate Screen { get; set; }
        public InventoryDatasGroupPrintDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}