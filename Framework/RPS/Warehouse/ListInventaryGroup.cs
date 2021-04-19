    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Warehouse.ListInventaryGroup
{
    //RPS VERSION 1.0.0.0
    public partial class ListInventaryGroup:Screen
    {
        public ListInventaryGroup():base()
        {
            this.URL = "warehouse.listinventarygroup";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ListInventaryGroupQueryView  = new ListInventaryGroupQueryView(this); 
            InventoryDatasGroupPrintDialogView  = new InventoryDatasGroupPrintDialogView(this); 
            ListInventaryGroupQueryView.InitializeControls(); 
            InventoryDatasGroupPrintDialogView.InitializeControls(); 
           
        }
      
            public ListInventaryGroupQueryView ListInventaryGroupQueryView {get; set; } 
            public InventoryDatasGroupPrintDialogView InventoryDatasGroupPrintDialogView {get; set; } 
    }
            
    public partial class ListInventaryGroupQueryView : View
    {
        public ListInventaryGroupQueryView(ListInventaryGroup screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            GroupProductLine = RPSControlFactory.CreateRPSCheckBox<ListInventaryGroupQueryView>("af42a132-a034-4aec-8667-f2e73a7da46b","","",false, this);
 
            GroupProductFamily = RPSControlFactory.CreateRPSCheckBox<ListInventaryGroupQueryView>("9cc5144d-5bd5-4604-9294-0650c127872c","","",false, this);
 
            GroupProductSubFamily = RPSControlFactory.CreateRPSCheckBox<ListInventaryGroupQueryView>("4b489991-21f8-419d-884c-a03845954df7","","",false, this);
 
            GroupArticle = RPSControlFactory.CreateRPSCheckBox<ListInventaryGroupQueryView>("974ccacd-527f-4b88-86a4-a628389d6fa6","","",false, this);
 
            GroupSite = RPSControlFactory.CreateRPSCheckBox<ListInventaryGroupQueryView>("bd60a7d7-06fc-44d0-bae4-2891314d7890","","",false, this);
 
            GroupWarehouse = RPSControlFactory.CreateRPSCheckBox<ListInventaryGroupQueryView>("bc346414-176b-4b69-bd41-526979ff34ce","","",false, this);
 
            GroupSerie = RPSControlFactory.CreateRPSCheckBox<ListInventaryGroupQueryView>("5079a5e0-cf2d-4977-9a97-e72d719c3800","","",false, this);
 
            GroupLocation = RPSControlFactory.CreateRPSCheckBox<ListInventaryGroupQueryView>("9ade94a6-22f9-4eed-be96-6bba7a6f305d","","",false, this);
 
            ProductLine = RPSControlFactory.CreateRPSCollectionComboBox<ListInventaryGroupQueryView>("1e41aae3-96a1-4e49-8437-9f34a728526b","","",false, this);
 
            ProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<ListInventaryGroupQueryView>("6a1d2105-3b7e-4dac-a8d2-93c8a3b9fc5e","","",false, this);
 
            ProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<ListInventaryGroupQueryView>("40feac13-c875-4cde-a233-0fa814d06dc4","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<ListInventaryGroupQueryView>("fe97ee6a-69d6-4b42-aad9-18f69ac912f0","","",false, this);
 
            Site = RPSControlFactory.CreateRPSCollectionComboBox<ListInventaryGroupQueryView>("271e72be-d371-4687-9ff2-bc9e5d9fb0f2","","",false, this);
 
            WareHouse = RPSControlFactory.CreateRPSCollectionComboBox<ListInventaryGroupQueryView>("5ed336de-0e91-460b-9d45-ddf7e432c4aa","","",false, this);
 
            WarehouseSeries = RPSControlFactory.CreateRPSEnumComboBox<ListInventaryGroupQueryView>("d4025c16-e2ea-4a0d-a180-1ab6ce2f0387","","",false, this);
 
            LocationWarehouse = RPSControlFactory.CreateRPSCollectionComboBox<ListInventaryGroupQueryView>("e2bf6653-f464-4629-bc09-41a8b9cb9ecb","","",false, this);
 
            Valorated = RPSControlFactory.CreateRPSCheckBox<ListInventaryGroupQueryView>("b64f1159-deaf-45da-bb18-b8b495181bdb","","",false, this);
 
            WithOutNegativeStock = RPSControlFactory.CreateRPSCheckBox<ListInventaryGroupQueryView>("ac5195fd-11ce-42c9-955e-1f8f98bdcea1","","",false, this);
 
            IncludeNotAvailableWarehouse = RPSControlFactory.CreateRPSCheckBox<ListInventaryGroupQueryView>("dcee43ef-2587-4ce1-bb3e-c4199c326262","","",false, this);
 
            DiscardDepositWarehouse = RPSControlFactory.CreateRPSCheckBox<ListInventaryGroupQueryView>("98655fd4-9196-408a-9b47-448ea9948ab2","","",false, this);
 
            Prices = RPSControlFactory.CreateRPSOption<ListInventaryGroupQueryView>( "abb886a9-7bed-4cdb-aa18-00b5f767222b","","",this);
 
            Purchase = RPSControlFactory.CreateRPSOption<ListInventaryGroupQueryView>( "2ef877a3-b66f-4e40-b079-f28975f29aaa","","",this);
 
            Manufacture = RPSControlFactory.CreateRPSOption<ListInventaryGroupQueryView>( "e7ff89d8-2e7a-4ee6-ba88-210bc6218a3b","","",this);
 
            Average = RPSControlFactory.CreateRPSOption<ListInventaryGroupQueryView>( "2d6866a9-7a97-4593-9af9-7e28eb93f748","","",this);
 
            Standard = RPSControlFactory.CreateRPSOption<ListInventaryGroupQueryView>( "d38ba3d4-154d-4b63-8bc4-b66bb98939af","","",this);
 
            Article1 = RPSControlFactory.CreateRPSOption<ListInventaryGroupQueryView>( "8e60a82d-44e0-42a6-99eb-1fc8073cc76a","","",this);
 
            Site1 = RPSControlFactory.CreateRPSOption<ListInventaryGroupQueryView>( "61fe5344-cc79-47f8-abe2-54b1436467c8","","",this);
 
            Warehouse = RPSControlFactory.CreateRPSOption<ListInventaryGroupQueryView>( "526f35ef-5b36-48d3-8235-5a61f5138c14","","",this);
 
            Series = RPSControlFactory.CreateRPSOption<ListInventaryGroupQueryView>( "a1f52089-44df-4635-906e-b62c7dc39f23","","",this);
 
            Total = RPSControlFactory.CreateRPSFormattedTextBox<ListInventaryGroupQueryView>("72735cdc-6dd0-42cf-9687-f059e67b29b6","","",false, this);
 
            InventoryDatasGroupPrintNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ListInventaryGroupQueryView,InventoryDatasGroupPrintDialogView>("e4331c8e-f043-40d6-8d3a-8a1eb9edeaee","","", this,Screen.InventoryDatasGroupPrintDialogView);
 

        }
        public IRPSCheckbox<ListInventaryGroupQueryView> GroupProductLine { get; set; } 
        public IRPSCheckbox<ListInventaryGroupQueryView> GroupProductFamily { get; set; } 
        public IRPSCheckbox<ListInventaryGroupQueryView> GroupProductSubFamily { get; set; } 
        public IRPSCheckbox<ListInventaryGroupQueryView> GroupArticle { get; set; } 
        public IRPSCheckbox<ListInventaryGroupQueryView> GroupSite { get; set; } 
        public IRPSCheckbox<ListInventaryGroupQueryView> GroupWarehouse { get; set; } 
        public IRPSCheckbox<ListInventaryGroupQueryView> GroupSerie { get; set; } 
        public IRPSCheckbox<ListInventaryGroupQueryView> GroupLocation { get; set; } 
        public IRPSCollectionComboBox<ListInventaryGroupQueryView> ProductLine { get; set; } 
        public IRPSCollectionComboBox<ListInventaryGroupQueryView> ProductFamily { get; set; } 
        public IRPSCollectionComboBox<ListInventaryGroupQueryView> ProductSubFamily { get; set; } 
        public IRPSCollectionComboBox<ListInventaryGroupQueryView> Article { get; set; } 
        public IRPSCollectionComboBox<ListInventaryGroupQueryView> Site { get; set; } 
        public IRPSCollectionComboBox<ListInventaryGroupQueryView> WareHouse { get; set; } 
        public IRPSComboBox<ListInventaryGroupQueryView> WarehouseSeries { get; set; } 
        public IRPSCollectionComboBox<ListInventaryGroupQueryView> LocationWarehouse { get; set; } 
        public IRPSCheckbox<ListInventaryGroupQueryView> Valorated { get; set; } 
        public IRPSCheckbox<ListInventaryGroupQueryView> WithOutNegativeStock { get; set; } 
        public IRPSCheckbox<ListInventaryGroupQueryView> IncludeNotAvailableWarehouse { get; set; } 
        public IRPSCheckbox<ListInventaryGroupQueryView> DiscardDepositWarehouse { get; set; } 
        public IRPSOption<ListInventaryGroupQueryView> Prices { get; set; } 
        public IRPSOption<ListInventaryGroupQueryView> Purchase { get; set; } 
        public IRPSOption<ListInventaryGroupQueryView> Manufacture { get; set; } 
        public IRPSOption<ListInventaryGroupQueryView> Average { get; set; } 
        public IRPSOption<ListInventaryGroupQueryView> Standard { get; set; } 
        public IRPSOption<ListInventaryGroupQueryView> Article1 { get; set; } 
        public IRPSOption<ListInventaryGroupQueryView> Site1 { get; set; } 
        public IRPSOption<ListInventaryGroupQueryView> Warehouse { get; set; } 
        public IRPSOption<ListInventaryGroupQueryView> Series { get; set; } 
        public IRPSTextBox<ListInventaryGroupQueryView> Total { get; set; } 
        public IRPSButton<ListInventaryGroupQueryView,InventoryDatasGroupPrintDialogView> InventoryDatasGroupPrintNavigationCommandButton { get; set; } 
        public ListInventaryGroup Screen { get; set; }
        public ListInventaryGroupQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class InventoryDatasGroupPrintDialogView : View
    {
        public InventoryDatasGroupPrintDialogView(ListInventaryGroup screen) : base()
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
        public ListInventaryGroup Screen { get; set; }
        public InventoryDatasGroupPrintDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}