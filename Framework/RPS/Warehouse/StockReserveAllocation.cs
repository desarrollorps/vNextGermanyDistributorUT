    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Warehouse.StockReserveAllocation
{
    //RPS VERSION 1.0.0.0
    public partial class StockReserveAllocation:Screen
    {
        public StockReserveAllocation():base()
        {
            this.URL = "warehouse.stockreserveallocation";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            StockReserveVMQueryView  = new StockReserveVMQueryView(this); 
            StockReserveVMEntityView  = new StockReserveVMEntityView(this); 
            StockReserveVMQueryView.InitializeControls(); 
            StockReserveVMEntityView.InitializeControls(); 
           
        }
      
            public StockReserveVMQueryView StockReserveVMQueryView {get; set; } 
            public StockReserveVMEntityView StockReserveVMEntityView {get; set; } 
    }
            
    public partial class StockReserveVMQueryView : View
    {
        public StockReserveVMQueryView(StockReserveAllocation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<StockReserveVMQueryView,StockReserveVMEntityView>( this,Screen.StockReserveVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<StockReserveVMQueryView>( this);
 
            ProductLine = RPSControlFactory.CreateRPSCollectionComboBox<StockReserveVMQueryView>("9bdba369-55d3-4171-964c-50598451f30b","","",false, this);
 
            Site1 = RPSControlFactory.CreateRPSCollectionComboBox<StockReserveVMQueryView>("c2925955-2629-40e7-91ac-c568bf53273f","","",false, this);
 
            ProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<StockReserveVMQueryView>("d515e9d9-c27b-4567-b969-589d2f958475","","",false, this);
 
            UILstWareHouse = RPSControlFactory.CreateRPSCollectionComboBox<StockReserveVMQueryView>("86729398-b24d-4e67-a3cb-01c2dfc34769","","",false, this);
 
            ProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<StockReserveVMQueryView>("20f48ad9-6010-4669-a29e-ed382eae09d4","","",false, this);
 
            UILstOrderSL = RPSControlFactory.CreateRPSCollectionComboBox<StockReserveVMQueryView>("804b19df-e5a3-428d-9bef-0c125f1c7531","","",false, this);
 
            UILstMaintenanceOrder = RPSControlFactory.CreateRPSCollectionComboBox<StockReserveVMQueryView>("7beb7eeb-b52f-4761-b333-df3b51e6a8cc","","",false, this);
 
            UILstManufacturingOrder = RPSControlFactory.CreateRPSCollectionComboBox<StockReserveVMQueryView>("fec387c8-0002-49e7-a52e-7b22fad5a3bc","","",false, this);
 
            UILstProject = RPSControlFactory.CreateRPSCollectionComboBox<StockReserveVMQueryView>("4ac9b113-69cd-445c-a950-bdd73717fd43","","",false, this);
 
            UILstArticle = RPSControlFactory.CreateRPSCollectionComboBox<StockReserveVMQueryView>("71ccbb74-6b4f-4328-8ae6-268b7fb21a71","","",false, this);
 
            UIWarehouse = RPSControlFactory.CreateRPSCheckBox<StockReserveVMQueryView>("81917d49-deb0-428e-ac1a-08f307453396","","",false, this);
 
            UISales = RPSControlFactory.CreateRPSCheckBox<StockReserveVMQueryView>("f1f6c6ee-5d7f-48ef-bf99-c5bdf82b2280","","",false, this);
 
            UIMaintenance = RPSControlFactory.CreateRPSCheckBox<StockReserveVMQueryView>("954f74fb-6974-4af1-ab54-a88a937f0df9","","",false, this);
 
            UIProject = RPSControlFactory.CreateRPSCheckBox<StockReserveVMQueryView>("c40ac9c5-6dc1-401f-87b3-9d54971a27db","","",false, this);
 
            UIManufacturing = RPSControlFactory.CreateRPSCheckBox<StockReserveVMQueryView>("2e92537f-566b-4d1e-8bee-8b61bc5eb4b4","","",false, this);
 
            CollectionInit params_StockReserveAllocation = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d56d911c-40c8-4260-a308-86ae1c552c2b",CSSSelectorGrid="",XPathGrid=""};
            StockReserveAllocation = RPSControlFactory.RPSCreateCollectionWithGrid<StockReserveAllocationCollectionEditor<StockReserveVMQueryView,StockReserveVMEntityView>,StockReserveVMQueryView,StockReserveVMEntityView>( params_StockReserveAllocation,this,Screen.StockReserveVMEntityView);
 

        }
        public IRPSButton<StockReserveVMQueryView,StockReserveVMEntityView> NewButton { get; set; } 
        public IRPSButton<StockReserveVMQueryView> ConsultButton { get; set; } 
        public IRPSCollectionComboBox<StockReserveVMQueryView> ProductLine { get; set; } 
        public IRPSCollectionComboBox<StockReserveVMQueryView> Site1 { get; set; } 
        public IRPSCollectionComboBox<StockReserveVMQueryView> ProductFamily { get; set; } 
        public IRPSCollectionComboBox<StockReserveVMQueryView> UILstWareHouse { get; set; } 
        public IRPSCollectionComboBox<StockReserveVMQueryView> ProductSubFamily { get; set; } 
        public IRPSCollectionComboBox<StockReserveVMQueryView> UILstOrderSL { get; set; } 
        public IRPSCollectionComboBox<StockReserveVMQueryView> UILstMaintenanceOrder { get; set; } 
        public IRPSCollectionComboBox<StockReserveVMQueryView> UILstManufacturingOrder { get; set; } 
        public IRPSCollectionComboBox<StockReserveVMQueryView> UILstProject { get; set; } 
        public IRPSCollectionComboBox<StockReserveVMQueryView> UILstArticle { get; set; } 
        public IRPSCheckbox<StockReserveVMQueryView> UIWarehouse { get; set; } 
        public IRPSCheckbox<StockReserveVMQueryView> UISales { get; set; } 
        public IRPSCheckbox<StockReserveVMQueryView> UIMaintenance { get; set; } 
        public IRPSCheckbox<StockReserveVMQueryView> UIProject { get; set; } 
        public IRPSCheckbox<StockReserveVMQueryView> UIManufacturing { get; set; } 
        public StockReserveAllocationCollectionEditor<StockReserveVMQueryView,StockReserveVMEntityView> StockReserveAllocation { get; set; } 
        public StockReserveAllocation Screen { get; set; }
        public StockReserveVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class StockReserveAllocationCollectionEditor<StockReserveVMQueryView,StockReserveVMEntityView>:RPSCollectionEditor<StockReserveVMQueryView,StockReserveVMEntityView> where StockReserveVMQueryView : class, IView where StockReserveVMEntityView : class, IView
    {
        public  StockReserveAllocationGridView<StockReserveVMQueryView,StockReserveVMEntityView> GridView {get;set;}
    }
    public partial class StockReserveAllocationGridView <StockReserveVMQueryView,StockReserveVMEntityView> :  RPSGridView<StockReserveVMQueryView,StockReserveVMEntityView> where StockReserveVMQueryView : class, IView where StockReserveVMEntityView : class, IView
    {
        public StockReserveAllocationGridView(StockReserveVMQueryView currentView,StockReserveVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Series = RPSControlFactory.CreateRPSGridTextBox<StockReserveVMQueryView>("","#d56d911c-40c8-4260-a308-86ae1c552c2b .ag-row[role='row']@ROWINDEX [col-id='cSeries']","",false, this.CurrentView);
 
            ItemType = RPSControlFactory.CreateRPSGridTextBox<StockReserveVMQueryView>("","#d56d911c-40c8-4260-a308-86ae1c552c2b .ag-row[role='row']@ROWINDEX [col-id='cItemType']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<StockReserveVMQueryView>("","#d56d911c-40c8-4260-a308-86ae1c552c2b .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<StockReserveVMQueryView> Series { get; set; } 
        public IRPSGridTextBox<StockReserveVMQueryView> ItemType { get; set; } 
        public IRPSGridTextBox<StockReserveVMQueryView> Quantity { get; set; } 
                     
    }
 
    }
  
            
    public partial class StockReserveVMEntityView : View
    {
        public StockReserveVMEntityView(StockReserveAllocation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<StockReserveVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<StockReserveVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<StockReserveVMEntityView,StockReserveVMQueryView>( this,Screen.StockReserveVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<StockReserveVMEntityView,StockReserveVMQueryView>( this,Screen.StockReserveVMQueryView);
 
            UIArticle = RPSControlFactory.CreateRPSComboBox<StockReserveVMEntityView>("93ce8408-62e5-454d-b761-40126569a6cf","","",false, this);
 
            UISite = RPSControlFactory.CreateRPSComboBox<StockReserveVMEntityView>("6020bdb3-6d06-4f11-b294-7bc985243e25","","",false, this);
 
            UIWareHouse = RPSControlFactory.CreateRPSComboBox<StockReserveVMEntityView>("90525d59-d8be-42ec-a2e9-023a5d249072","","",false, this);
 
            UISeries = RPSControlFactory.CreateRPSEnumComboBox<StockReserveVMEntityView>("0021aff7-122e-43ea-a8e0-2fb759306c81","","",false, this);
 
            UILocationWarehouse = RPSControlFactory.CreateRPSComboBox<StockReserveVMEntityView>("89cf8dfe-49b0-4d35-9fe7-992bea5ef7c9","","",false, this);
 
            ItemType = RPSControlFactory.CreateRPSEnumComboBox<StockReserveVMEntityView>("9f2f163e-5384-4279-ade3-73c4198fb874","","",true, this);
 
            UIOrderSL = RPSControlFactory.CreateRPSComboBox<StockReserveVMEntityView>("95fc380d-ae22-4ea3-9c62-c11b19d524c8","","",false, this);
 
            IDItemSales_Orders = RPSControlFactory.CreateRPSComboBox<StockReserveVMEntityView>("7a1c31b0-4e71-406a-a573-48b6b51d50aa","","",false, this);
 
            UIProject = RPSControlFactory.CreateRPSComboBox<StockReserveVMEntityView>("819a4dca-46ef-4921-a61d-d0754a7bb456","","",false, this);
 
            IDItemProject = RPSControlFactory.CreateRPSComboBox<StockReserveVMEntityView>("ab811a24-7dff-430c-9101-9c893734cc88","","",false, this);
 
            UIMaintenanceOrder = RPSControlFactory.CreateRPSComboBox<StockReserveVMEntityView>("ab3c1d6f-50a3-4f5d-86c4-e70378f8f9b0","","",false, this);
 
            IDItemMaintenanceOrder = RPSControlFactory.CreateRPSComboBox<StockReserveVMEntityView>("1a7a0c98-7a03-45e2-9869-35bc54263030","","",false, this);
 
            UIManufacturingOrder = RPSControlFactory.CreateRPSComboBox<StockReserveVMEntityView>("3a12f3dc-466c-41d7-8266-638df6ea975d","","",false, this);
 
            IDItemManufacturing = RPSControlFactory.CreateRPSComboBox<StockReserveVMEntityView>("0baf5e3e-2167-4af6-835c-934c9cfb44aa","","",false, this);
 
            UICustomer = RPSControlFactory.CreateRPSComboBox<StockReserveVMEntityView>("dea58a67-2224-4833-bbfe-2315429f106a","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<StockReserveVMEntityView>("abc80467-92c6-4553-8a41-df1c407dc221","","",true, this);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<StockReserveVMEntityView>("92673324-8ca3-46ca-8976-330e12c6f3cb","","",true, this);
 
            StockNavigationCommandButton = RPSControlFactory.CreateRPSButton<StockReserveVMEntityView>( "aa985eb3-cccc-4cc2-bd42-bbab1f8ab73e","","",this);
 

        }
        public IRPSSaveButton<StockReserveVMEntityView> SaveButton { get; set; } 
        public IRPSButton<StockReserveVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<StockReserveVMEntityView,StockReserveVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<StockReserveVMEntityView,StockReserveVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<StockReserveVMEntityView> UIArticle { get; set; } 
        public IRPSComboBox<StockReserveVMEntityView> UISite { get; set; } 
        public IRPSComboBox<StockReserveVMEntityView> UIWareHouse { get; set; } 
        public IRPSComboBox<StockReserveVMEntityView> UISeries { get; set; } 
        public IRPSComboBox<StockReserveVMEntityView> UILocationWarehouse { get; set; } 
        public IRPSComboBox<StockReserveVMEntityView> ItemType { get; set; } 
        public IRPSComboBox<StockReserveVMEntityView> UIOrderSL { get; set; } 
        public IRPSComboBox<StockReserveVMEntityView> IDItemSales_Orders { get; set; } 
        public IRPSComboBox<StockReserveVMEntityView> UIProject { get; set; } 
        public IRPSComboBox<StockReserveVMEntityView> IDItemProject { get; set; } 
        public IRPSComboBox<StockReserveVMEntityView> UIMaintenanceOrder { get; set; } 
        public IRPSComboBox<StockReserveVMEntityView> IDItemMaintenanceOrder { get; set; } 
        public IRPSComboBox<StockReserveVMEntityView> UIManufacturingOrder { get; set; } 
        public IRPSComboBox<StockReserveVMEntityView> IDItemManufacturing { get; set; } 
        public IRPSComboBox<StockReserveVMEntityView> UICustomer { get; set; } 
        public IRPSTextBox<StockReserveVMEntityView> Quantity { get; set; } 
        public IRPSTextBox<StockReserveVMEntityView> QuantitySecondUnit { get; set; } 
        public IRPSButton<StockReserveVMEntityView> StockNavigationCommandButton { get; set; } 
        public StockReserveAllocation Screen { get; set; }
        public StockReserveVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}