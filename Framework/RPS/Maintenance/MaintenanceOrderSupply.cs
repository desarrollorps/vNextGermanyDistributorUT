    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.MaintenanceOrderSupply
{
    //RPS VERSION 1.0.0.0
    public partial class MaintenanceOrderSupply:Screen
    {
        public MaintenanceOrderSupply():base()
        {
            this.URL = "maintenance.maintenanceordersupply";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MaintenanceOrderSupplyQueryView  = new MaintenanceOrderSupplyQueryView(this); 
            MaintenanceOrderSupplyQueryView.InitializeControls(); 
           
        }
      
            public MaintenanceOrderSupplyQueryView MaintenanceOrderSupplyQueryView {get; set; } 
    }
            
    public partial class MaintenanceOrderSupplyQueryView : View
    {
        public MaintenanceOrderSupplyQueryView(MaintenanceOrderSupply screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDMaintenanceOrder = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderSupplyQueryView>("1aabd2e5-5349-4bcb-894a-892e8eb1d97f","","",false, this);
 
            IDMaintenanceComponent = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderSupplyQueryView>("c59aaadd-2808-4ca7-ad96-22af873f69c2","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderSupplyQueryView>("77277228-dd67-41ba-ad31-c410aa9b2a97","","",false, this);
 
            SerialNumber = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderSupplyQueryView>("a5269d11-653f-45d7-8b03-e146da5afa1b","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<MaintenanceOrderSupplyQueryView>("b7e37a47-1e2c-4157-9efe-da7898748436","","",false, this);
 
            UILstProductLine = RPSControlFactory.CreateRPSCollectionComboBox<MaintenanceOrderSupplyQueryView>("4f7dcdc3-c124-4fed-b643-c55264ec8850","","",false, this);
 
            UILstProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<MaintenanceOrderSupplyQueryView>("5d03e529-b551-4cda-a4c2-f13a98a857c3","","",false, this);
 
            UILstProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<MaintenanceOrderSupplyQueryView>("82764843-3eac-4182-b4b1-b8b595dafcf5","","",false, this);
 
            All = RPSControlFactory.CreateRPSOption<MaintenanceOrderSupplyQueryView>( "478f66d1-3210-4df4-9751-07d33ff811da","","",this);
 
            PendingImputate = RPSControlFactory.CreateRPSOption<MaintenanceOrderSupplyQueryView>( "17e7e561-7e76-4dd2-b39c-f981e8db155c","","",this);
 
            PendingProvisioning = RPSControlFactory.CreateRPSOption<MaintenanceOrderSupplyQueryView>( "c2b76327-c9b9-445c-9eba-d2c7cb2dde74","","",this);
 
            Purchase = RPSControlFactory.CreateRPSOption<MaintenanceOrderSupplyQueryView>( "afcdbe80-704f-4169-96ee-83b3bbb84907","","",this);
 
            Manufacturing = RPSControlFactory.CreateRPSOption<MaintenanceOrderSupplyQueryView>( "3126a59e-a014-4e20-985d-d8b4b56c58c3","","",this);
 
            LaunchMO = RPSControlFactory.CreateRPSCheckBox<MaintenanceOrderSupplyQueryView>("2a64a0a3-8598-4607-981d-f5106241f478","","",false, this);
 
            StartDate = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderSupplyQueryView>("7406baaf-fbde-43b7-9c60-26b095bfb7a2","","",false, this);
 
            ArticleType = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderSupplyQueryView>("a1401fb6-631f-4b32-bc64-37081940570a","","",false, this);
 
            ProjectProvisionType = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderSupplyQueryView>("86dce025-0ca1-4df2-924c-03bcaed4817e","","",false, this);
 
            SupplySituation = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderSupplyQueryView>("7ffab1e2-9ca9-4bd0-b34a-c0caae192739","","",false, this);
 
            QuantityToSupplyment = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceOrderSupplyQueryView>("d17edf1b-cf3b-4e61-baee-466416ac5ab9","","",false, this);
 
            Suffix = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderSupplyQueryView>("66c57a16-b244-4cf4-bd85-28dc85a3888d","","",false, this);
 
            GenerateSupplysCommandButton = RPSControlFactory.CreateRPSButton<MaintenanceOrderSupplyQueryView>( "693eba06-9e49-4f69-9ea9-fb081509fa91","","",this);
 
            MaterialStockReserveAutomaticCommandButton = RPSControlFactory.CreateRPSButton<MaintenanceOrderSupplyQueryView>( "72000490-b6fd-4541-8462-7bb074d512c9","","",this);
 
            CollectionInit params_MaintenanceOrderSupplysConsult = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="2a19ce74-ac7c-4978-b5cd-71771cfc5eaa",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceOrderSupplysConsult = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceOrderSupplysConsultCollectionEditor<MaintenanceOrderSupplyQueryView>,MaintenanceOrderSupplyQueryView>( params_MaintenanceOrderSupplysConsult,this);
 

        }
        public IRPSComboBox<MaintenanceOrderSupplyQueryView> IDMaintenanceOrder { get; set; } 
        public IRPSComboBox<MaintenanceOrderSupplyQueryView> IDMaintenanceComponent { get; set; } 
        public IRPSComboBox<MaintenanceOrderSupplyQueryView> IDCustomer { get; set; } 
        public IRPSTextBox<MaintenanceOrderSupplyQueryView> SerialNumber { get; set; } 
        public IRPSComboBox<MaintenanceOrderSupplyQueryView> IDArticle { get; set; } 
        public IRPSCollectionComboBox<MaintenanceOrderSupplyQueryView> UILstProductLine { get; set; } 
        public IRPSCollectionComboBox<MaintenanceOrderSupplyQueryView> UILstProductFamily { get; set; } 
        public IRPSCollectionComboBox<MaintenanceOrderSupplyQueryView> UILstProductSubFamily { get; set; } 
        public IRPSOption<MaintenanceOrderSupplyQueryView> All { get; set; } 
        public IRPSOption<MaintenanceOrderSupplyQueryView> PendingImputate { get; set; } 
        public IRPSOption<MaintenanceOrderSupplyQueryView> PendingProvisioning { get; set; } 
        public IRPSOption<MaintenanceOrderSupplyQueryView> Purchase { get; set; } 
        public IRPSOption<MaintenanceOrderSupplyQueryView> Manufacturing { get; set; } 
        public IRPSCheckbox<MaintenanceOrderSupplyQueryView> LaunchMO { get; set; } 
        public IRPSTextBox<MaintenanceOrderSupplyQueryView> StartDate { get; set; } 
        public IRPSTextBox<MaintenanceOrderSupplyQueryView> ArticleType { get; set; } 
        public IRPSTextBox<MaintenanceOrderSupplyQueryView> ProjectProvisionType { get; set; } 
        public IRPSTextBox<MaintenanceOrderSupplyQueryView> SupplySituation { get; set; } 
        public IRPSTextBox<MaintenanceOrderSupplyQueryView> QuantityToSupplyment { get; set; } 
        public IRPSTextBox<MaintenanceOrderSupplyQueryView> Suffix { get; set; } 
        public IRPSButton<MaintenanceOrderSupplyQueryView> GenerateSupplysCommandButton { get; set; } 
        public IRPSButton<MaintenanceOrderSupplyQueryView> MaterialStockReserveAutomaticCommandButton { get; set; } 
        public MaintenanceOrderSupplysConsultCollectionEditor<MaintenanceOrderSupplyQueryView> MaintenanceOrderSupplysConsult { get; set; } 
        public MaintenanceOrderSupply Screen { get; set; }
        public MaintenanceOrderSupplyQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaintenanceOrderSupplysConsultCollectionEditor<MaintenanceOrderSupplyQueryView>:RPSCollectionEditor<MaintenanceOrderSupplyQueryView> where MaintenanceOrderSupplyQueryView : class, IView
    {
        public  MaintenanceOrderSupplysConsultGridView<MaintenanceOrderSupplyQueryView> GridView {get;set;}
    }
    public partial class MaintenanceOrderSupplysConsultGridView <MaintenanceOrderSupplyQueryView> :  RPSGridView<MaintenanceOrderSupplyQueryView> where MaintenanceOrderSupplyQueryView : class, IView
    {
        public MaintenanceOrderSupplysConsultGridView(MaintenanceOrderSupplyQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            SupplySituation = RPSControlFactory.CreateRPSGridTextBox<MaintenanceOrderSupplyQueryView>("","#2a19ce74-ac7c-4978-b5cd-71771cfc5eaa .ag-row[role='row']@ROWINDEX [col-id='cSupplySituation']","",false, this.CurrentView);
 
            QuantityToSupplyment = RPSControlFactory.CreateRPSGridFormattedTextBox<MaintenanceOrderSupplyQueryView>("","#2a19ce74-ac7c-4978-b5cd-71771cfc5eaa .ag-row[role='row']@ROWINDEX [col-id='cQuantityToSupplyment']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MaintenanceOrderSupplyQueryView> SupplySituation { get; set; } 
        public IRPSGridTextBox<MaintenanceOrderSupplyQueryView> QuantityToSupplyment { get; set; } 
                     
    }
 
    }
  
    

}