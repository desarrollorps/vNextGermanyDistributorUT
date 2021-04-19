    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.ManOrderMaterialAllocation
{
    //RPS VERSION 1.0.0.0
    public partial class ManOrderMaterialAllocation:Screen
    {
        public ManOrderMaterialAllocation():base()
        {
            this.URL = "maintenance.manordermaterialallocation";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ManOrderMaterialAllocationQueryView  = new ManOrderMaterialAllocationQueryView(this); 
            WizardChildDialogView  = new WizardChildDialogView(this); 
            MaterialAllocationReservesView  = new MaterialAllocationReservesView(this); 
            StockReserveView  = new StockReserveView(this); 
            ManOrderMaterialAllocationQueryView.InitializeControls(); 
            WizardChildDialogView.InitializeControls(); 
            MaterialAllocationReservesView.InitializeControls(); 
            StockReserveView.InitializeControls(); 
           
        }
      
            public ManOrderMaterialAllocationQueryView ManOrderMaterialAllocationQueryView {get; set; } 
            public WizardChildDialogView WizardChildDialogView {get; set; } 
            public MaterialAllocationReservesView MaterialAllocationReservesView {get; set; } 
            public StockReserveView StockReserveView {get; set; } 
    }
            
    public partial class ManOrderMaterialAllocationQueryView : View
    {
        public ManOrderMaterialAllocationQueryView(ManOrderMaterialAllocation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIIDSite = RPSControlFactory.CreateRPSComboBox<ManOrderMaterialAllocationQueryView>("88c873a8-a0b8-47c8-b0d0-2ea5796bedeb","","",false, this);
 
            MaintenanceType = RPSControlFactory.CreateRPSCollectionComboBox<ManOrderMaterialAllocationQueryView>("5141b2b3-7e2f-4a8c-8fbb-3ff620405c1e","","",false, this);
 
            UIIDMaintenanceOrder = RPSControlFactory.CreateRPSCollectionComboBox<ManOrderMaterialAllocationQueryView>("fcbf7dec-901a-4c21-b3da-7bf671d7f6ae","","",false, this);
 
            Articles = RPSControlFactory.CreateRPSCollectionComboBox<ManOrderMaterialAllocationQueryView>("14d283dd-aefa-4f1c-be69-32237fd726f5","","",false, this);
 
            All = RPSControlFactory.CreateRPSOption<ManOrderMaterialAllocationQueryView>( "771e0fc5-653f-4520-b850-f4f57a7d5d09","","",this);
 
            WithAllocation = RPSControlFactory.CreateRPSOption<ManOrderMaterialAllocationQueryView>( "75500aaa-2e5b-4973-9918-ffb8466e887e","","",this);
 
            WithoutAllocations = RPSControlFactory.CreateRPSOption<ManOrderMaterialAllocationQueryView>( "bbf397cd-6125-4996-a4e3-2c22ef7ae6ea","","",this);
 
            GenerateCommandButton = RPSControlFactory.CreateRPSButton<ManOrderMaterialAllocationQueryView>( "cb7e86a1-a9d4-4342-90cd-e2ca244bad2a","","",this);
 
            DeleteCommandButton = RPSControlFactory.CreateRPSButton<ManOrderMaterialAllocationQueryView>( "513eb9de-9677-49d9-9ceb-c0689733b7b3","","",this);
 
            CollectionInit params_MaintenanceMaterialForAllocation = new CollectionInit(){IDDescriptor = "81a31e6e-b06e-4a71-80d7-13b1e02196ea",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="56962d6b-cdef-48d5-af5e-076eee229d22",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceMaterialForAllocation = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceMaterialForAllocationCollectionEditor<ManOrderMaterialAllocationQueryView,WizardChildDialogView>,ManOrderMaterialAllocationQueryView,WizardChildDialogView>( params_MaintenanceMaterialForAllocation,this,Screen.WizardChildDialogView);
 

        }
        public IRPSComboBox<ManOrderMaterialAllocationQueryView> UIIDSite { get; set; } 
        public IRPSCollectionComboBox<ManOrderMaterialAllocationQueryView> MaintenanceType { get; set; } 
        public IRPSCollectionComboBox<ManOrderMaterialAllocationQueryView> UIIDMaintenanceOrder { get; set; } 
        public IRPSCollectionComboBox<ManOrderMaterialAllocationQueryView> Articles { get; set; } 
        public IRPSOption<ManOrderMaterialAllocationQueryView> All { get; set; } 
        public IRPSOption<ManOrderMaterialAllocationQueryView> WithAllocation { get; set; } 
        public IRPSOption<ManOrderMaterialAllocationQueryView> WithoutAllocations { get; set; } 
        public IRPSButton<ManOrderMaterialAllocationQueryView> GenerateCommandButton { get; set; } 
        public IRPSButton<ManOrderMaterialAllocationQueryView> DeleteCommandButton { get; set; } 
        public MaintenanceMaterialForAllocationCollectionEditor<ManOrderMaterialAllocationQueryView,WizardChildDialogView> MaintenanceMaterialForAllocation { get; set; } 
        public ManOrderMaterialAllocation Screen { get; set; }
        public ManOrderMaterialAllocationQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaintenanceMaterialForAllocationCollectionEditor<ManOrderMaterialAllocationQueryView,WizardChildDialogView>:RPSCollectionEditor<ManOrderMaterialAllocationQueryView,WizardChildDialogView> where ManOrderMaterialAllocationQueryView : class, IView where WizardChildDialogView : class, IView
    {
        public  MaintenanceMaterialForAllocationGridView<ManOrderMaterialAllocationQueryView,WizardChildDialogView> GridView {get;set;}
    }
    public partial class MaintenanceMaterialForAllocationGridView <ManOrderMaterialAllocationQueryView,WizardChildDialogView> :  RPSGridView<ManOrderMaterialAllocationQueryView,WizardChildDialogView> where ManOrderMaterialAllocationQueryView : class, IView where WizardChildDialogView : class, IView
    {
        public MaintenanceMaterialForAllocationGridView(ManOrderMaterialAllocationQueryView currentView,WizardChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MaintenanceOrder_ExecutionDate = RPSControlFactory.CreateRPSGridTextBox<ManOrderMaterialAllocationQueryView>("","#56962d6b-cdef-48d5-af5e-076eee229d22 .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceOrder_ExecutionDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ManOrderMaterialAllocationQueryView> MaintenanceOrder_ExecutionDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class WizardChildDialogView : View
    {
        public WizardChildDialogView(ManOrderMaterialAllocation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDSite = RPSControlFactory.CreateRPSComboBox<WizardChildDialogView>("c87312d9-d80f-49a9-96bd-5d49dd77fa5c","","",false, this);
 
            UIIDMaintenanceOrder = RPSControlFactory.CreateRPSCollectionComboBox<WizardChildDialogView>("cbda5f55-77e4-4ac2-900b-b22fd7c206b5","","",false, this);
 
            MaintenanceType = RPSControlFactory.CreateRPSCollectionComboBox<WizardChildDialogView>("9fdd2c88-cec3-48d0-adcd-5381d939aaac","","",false, this);
 
            PreviousSelection = RPSControlFactory.CreateRPSCheckBox<WizardChildDialogView>("d7af52bc-430f-4437-9ff7-6fed224e06e2","","",false, this);
 
            CollectionInit params_MaintenanceOrderForAssignmentMaterial = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0ee3fa2d-cf2a-44fe-bd12-4c965eb76a48",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceOrderForAssignmentMaterial = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceOrderForAssignmentMaterialCollectionEditor<WizardChildDialogView>,WizardChildDialogView>( params_MaintenanceOrderForAssignmentMaterial,this);
 

        }
        public IRPSComboBox<WizardChildDialogView> IDSite { get; set; } 
        public IRPSCollectionComboBox<WizardChildDialogView> UIIDMaintenanceOrder { get; set; } 
        public IRPSCollectionComboBox<WizardChildDialogView> MaintenanceType { get; set; } 
        public IRPSCheckbox<WizardChildDialogView> PreviousSelection { get; set; } 
        public MaintenanceOrderForAssignmentMaterialCollectionEditor<WizardChildDialogView> MaintenanceOrderForAssignmentMaterial { get; set; } 
        public ManOrderMaterialAllocation Screen { get; set; }
        public WizardChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaintenanceOrderForAssignmentMaterialCollectionEditor<WizardChildDialogView>:RPSCollectionEditor<WizardChildDialogView> where WizardChildDialogView : class, IView
    {
        public  MaintenanceOrderForAssignmentMaterialGridView<WizardChildDialogView> GridView {get;set;}
    }
    public partial class MaintenanceOrderForAssignmentMaterialGridView <WizardChildDialogView> :  RPSGridView<WizardChildDialogView> where WizardChildDialogView : class, IView
    {
        public MaintenanceOrderForAssignmentMaterialGridView(WizardChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MaintenanceOrder_MaintenanceOrderCode = RPSControlFactory.CreateRPSGridTextBox<WizardChildDialogView>("","#0ee3fa2d-cf2a-44fe-bd12-4c965eb76a48 .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceOrder_MaintenanceOrderCode']","",false, this.CurrentView);
 
            MaintenanceOrder_Description = RPSControlFactory.CreateRPSGridMemoTextBox<WizardChildDialogView>("","#0ee3fa2d-cf2a-44fe-bd12-4c965eb76a48 .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceOrder_Description']","",false, this.CurrentView);
 
            MaintenanceOrder_CreationDate = RPSControlFactory.CreateRPSGridTextBox<WizardChildDialogView>("","#0ee3fa2d-cf2a-44fe-bd12-4c965eb76a48 .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceOrder_CreationDate']","",false, this.CurrentView);
 
            MaintenanceOrder_ExecutionDate = RPSControlFactory.CreateRPSGridTextBox<WizardChildDialogView>("","#0ee3fa2d-cf2a-44fe-bd12-4c965eb76a48 .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceOrder_ExecutionDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<WizardChildDialogView> MaintenanceOrder_MaintenanceOrderCode { get; set; } 
        public IRPSGridTextBox<WizardChildDialogView> MaintenanceOrder_Description { get; set; } 
        public IRPSGridTextBox<WizardChildDialogView> MaintenanceOrder_CreationDate { get; set; } 
        public IRPSGridTextBox<WizardChildDialogView> MaintenanceOrder_ExecutionDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class MaterialAllocationReservesView : View
    {
        public MaterialAllocationReservesView(ManOrderMaterialAllocation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Article = RPSControlFactory.CreateRPSComboBox<MaterialAllocationReservesView>("01b15063-1478-48ba-8dff-cb83d7bcc67b","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<MaterialAllocationReservesView>("a2c64336-e3c9-4268-8767-3d63e2cc5da2","","",false, this);
 
            PendingQuantity = RPSControlFactory.CreateRPSFormattedTextBox<MaterialAllocationReservesView>("85aa8024-5b66-4c85-b2cd-c9be10de3d56","","",false, this);
 
            AssignedQuantity = RPSControlFactory.CreateRPSFormattedTextBox<MaterialAllocationReservesView>("4c703fbb-6078-4cd8-bad6-9fe930580c1a","","",false, this);
 
            LinkNavigationCommandButton = RPSControlFactory.CreateRPSButton<MaterialAllocationReservesView>( "ed686992-0acf-4ff2-89f0-69ec7a3d7667","","",this);
 
            SaveQuantityCommandButton = RPSControlFactory.CreateRPSButton<MaterialAllocationReservesView>( "463ab16e-b997-4e3a-ae18-51e1531247ab","","",this);
 
            CollectionInit params_StockReserveForAllocation = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3401a611-a9cc-4773-9323-ec76fb03bae6",CSSSelectorGrid="",XPathGrid=""};
            StockReserveForAllocation = RPSControlFactory.RPSCreateCollectionWithGrid<StockReserveForAllocationCollectionEditor<MaterialAllocationReservesView>,MaterialAllocationReservesView>( params_StockReserveForAllocation,this);
 

        }
        public IRPSComboBox<MaterialAllocationReservesView> Article { get; set; } 
        public IRPSTextBox<MaterialAllocationReservesView> Quantity { get; set; } 
        public IRPSTextBox<MaterialAllocationReservesView> PendingQuantity { get; set; } 
        public IRPSTextBox<MaterialAllocationReservesView> AssignedQuantity { get; set; } 
        public IRPSButton<MaterialAllocationReservesView> LinkNavigationCommandButton { get; set; } 
        public IRPSButton<MaterialAllocationReservesView> SaveQuantityCommandButton { get; set; } 
        public StockReserveForAllocationCollectionEditor<MaterialAllocationReservesView> StockReserveForAllocation { get; set; } 
        public ManOrderMaterialAllocation Screen { get; set; }
        public MaterialAllocationReservesView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class StockReserveForAllocationCollectionEditor<MaterialAllocationReservesView>:RPSCollectionEditor<MaterialAllocationReservesView> where MaterialAllocationReservesView : class, IView
    {
        public  StockReserveForAllocationGridView<MaterialAllocationReservesView> GridView {get;set;}
    }
    public partial class StockReserveForAllocationGridView <MaterialAllocationReservesView> :  RPSGridView<MaterialAllocationReservesView> where MaterialAllocationReservesView : class, IView
    {
        public StockReserveForAllocationGridView(MaterialAllocationReservesView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeleteStockReserveCommand = RPSControlFactory.CreateRPSGridButton<MaterialAllocationReservesView>( "","#3401a611-a9cc-4773-9323-ec76fb03bae6 .ag-row[role='row']@ROWINDEX [col-id='cDeleteStockReserveCommand']","",this.CurrentView);
 
            Stock_Series = RPSControlFactory.CreateRPSGridTextBox<MaterialAllocationReservesView>("","#3401a611-a9cc-4773-9323-ec76fb03bae6 .ag-row[role='row']@ROWINDEX [col-id='cStock_Series']","",false, this.CurrentView);
 

        }
        public IRPSGridButton<MaterialAllocationReservesView> DeleteStockReserveCommand { get; set; } 
        public IRPSGridTextBox<MaterialAllocationReservesView> Stock_Series { get; set; } 
                     
    }
 
    }
  
            
    public partial class StockReserveView : View
    {
        public StockReserveView(ManOrderMaterialAllocation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<StockReserveView>( this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<StockReserveView>("8e06fb31-3b4c-44e4-9cea-9485092f4963","","",false, this);
 
            UIIDSite = RPSControlFactory.CreateRPSComboBox<StockReserveView>("f594b370-5de3-4c1d-9355-351d0e5046fb","","",true, this);
 
            UIIDWareHouse = RPSControlFactory.CreateRPSComboBox<StockReserveView>("d21302d7-311b-42bd-be90-96f88bb68831","","",true, this);
 
            UISeries = RPSControlFactory.CreateRPSEnumComboBox<StockReserveView>("dbef694b-8e04-4cf3-b419-1ea8a6122566","","",false, this);
 
            UIIDLocationWarehouse = RPSControlFactory.CreateRPSComboBox<StockReserveView>("c6f00534-5e6a-408b-97fa-3e67196d9a5e","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<StockReserveView>("1d1a3ffe-4446-4ffb-9815-1763c52ea2a1","","",true, this);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<StockReserveView>("1e5093f1-44d9-4261-a4f1-83df1dc35307","","",true, this);
 

        }
        public IRPSSaveButton<StockReserveView> SaveButton { get; set; } 
        public IRPSComboBox<StockReserveView> IDArticle { get; set; } 
        public IRPSComboBox<StockReserveView> UIIDSite { get; set; } 
        public IRPSComboBox<StockReserveView> UIIDWareHouse { get; set; } 
        public IRPSComboBox<StockReserveView> UISeries { get; set; } 
        public IRPSComboBox<StockReserveView> UIIDLocationWarehouse { get; set; } 
        public IRPSTextBox<StockReserveView> Quantity { get; set; } 
        public IRPSTextBox<StockReserveView> QuantitySecondUnit { get; set; } 
        public ManOrderMaterialAllocation Screen { get; set; }
        public StockReserveView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}