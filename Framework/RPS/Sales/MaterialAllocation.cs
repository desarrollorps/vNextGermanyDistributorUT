    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Sales.MaterialAllocation
{
    //RPS VERSION 1.0.0.0
    public partial class MaterialAllocation:Screen
    {
        public MaterialAllocation():base()
        {
            this.URL = "sales.materialallocation";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MaterialAllocationQueryView  = new MaterialAllocationQueryView(this); 
            WizardChildDialogView  = new WizardChildDialogView(this); 
            StockReserveView  = new StockReserveView(this); 
            MaterialAllocationReservesView  = new MaterialAllocationReservesView(this); 
            MaterialAllocationQueryView.InitializeControls(); 
            WizardChildDialogView.InitializeControls(); 
            StockReserveView.InitializeControls(); 
            MaterialAllocationReservesView.InitializeControls(); 
           
        }
      
            public MaterialAllocationQueryView MaterialAllocationQueryView {get; set; } 
            public WizardChildDialogView WizardChildDialogView {get; set; } 
            public StockReserveView StockReserveView {get; set; } 
            public MaterialAllocationReservesView MaterialAllocationReservesView {get; set; } 
    }
            
    public partial class MaterialAllocationQueryView : View
    {
        public MaterialAllocationQueryView(MaterialAllocation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            iniOrderDate = RPSControlFactory.CreateRPSTextBox<MaterialAllocationQueryView>("11bb70a1-180b-4649-b946-1dc85f9a6d8f","","",false, this);
 
            endOrderDate = RPSControlFactory.CreateRPSTextBox<MaterialAllocationQueryView>("07446cdf-261f-4d1f-9cc2-2c82ad56f5fe","","",false, this);
 
            iniReceptionDate = RPSControlFactory.CreateRPSTextBox<MaterialAllocationQueryView>("c72f577c-0123-4f39-b7f0-17787be05cc8","","",false, this);
 
            endReceptionDate = RPSControlFactory.CreateRPSTextBox<MaterialAllocationQueryView>("793d1164-534c-405d-b7e2-0c8ce547ad4c","","",false, this);
 
            OrderSL = RPSControlFactory.CreateRPSCollectionComboBox<MaterialAllocationQueryView>("1cd113bf-79fe-48c5-b1b6-1eeaf70a8fb2","","",false, this);
 
            Customer = RPSControlFactory.CreateRPSCollectionComboBox<MaterialAllocationQueryView>("86b51655-3f40-4095-82f3-a5ce69addc68","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<MaterialAllocationQueryView>("e58c163b-2d2b-43fa-9497-c368ad6b018b","","",false, this);
 
            All = RPSControlFactory.CreateRPSOption<MaterialAllocationQueryView>( "71c4a5fa-cb32-4d54-b736-196effeff313","","",this);
 
            WithoutAllocations = RPSControlFactory.CreateRPSOption<MaterialAllocationQueryView>( "439400db-9345-431f-9d36-93d1816a1c8a","","",this);
 
            WithAllocation = RPSControlFactory.CreateRPSOption<MaterialAllocationQueryView>( "8982bdac-01a4-455b-b094-4fe394e11a07","","",this);
 
            GenerateCommandButton = RPSControlFactory.CreateRPSButton<MaterialAllocationQueryView>( "1a432bef-c63d-4939-8201-9225ceb88890","","",this);
 
            DeleteCommandButton = RPSControlFactory.CreateRPSButton<MaterialAllocationQueryView>( "695f5672-64fc-4b29-bf4a-98556b583b48","","",this);
 
            CollectionInit params_MaterialAllocation = new CollectionInit(){IDDescriptor = "e99258ae-20d2-46a8-9403-dfddb35e25be",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="fb21cb94-d4de-44de-a603-ffe9e81332d3",CSSSelectorGrid="",XPathGrid=""};
            MaterialAllocation = RPSControlFactory.RPSCreateCollectionWithGrid<MaterialAllocationCollectionEditor<MaterialAllocationQueryView,WizardChildDialogView>,MaterialAllocationQueryView,WizardChildDialogView>( params_MaterialAllocation,this,Screen.WizardChildDialogView);
 

        }
        public IRPSTextBox<MaterialAllocationQueryView> iniOrderDate { get; set; } 
        public IRPSTextBox<MaterialAllocationQueryView> endOrderDate { get; set; } 
        public IRPSTextBox<MaterialAllocationQueryView> iniReceptionDate { get; set; } 
        public IRPSTextBox<MaterialAllocationQueryView> endReceptionDate { get; set; } 
        public IRPSCollectionComboBox<MaterialAllocationQueryView> OrderSL { get; set; } 
        public IRPSCollectionComboBox<MaterialAllocationQueryView> Customer { get; set; } 
        public IRPSCollectionComboBox<MaterialAllocationQueryView> Article { get; set; } 
        public IRPSOption<MaterialAllocationQueryView> All { get; set; } 
        public IRPSOption<MaterialAllocationQueryView> WithoutAllocations { get; set; } 
        public IRPSOption<MaterialAllocationQueryView> WithAllocation { get; set; } 
        public IRPSButton<MaterialAllocationQueryView> GenerateCommandButton { get; set; } 
        public IRPSButton<MaterialAllocationQueryView> DeleteCommandButton { get; set; } 
        public MaterialAllocationCollectionEditor<MaterialAllocationQueryView,WizardChildDialogView> MaterialAllocation { get; set; } 
        public MaterialAllocation Screen { get; set; }
        public MaterialAllocationQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaterialAllocationCollectionEditor<MaterialAllocationQueryView,WizardChildDialogView>:RPSCollectionEditor<MaterialAllocationQueryView,WizardChildDialogView> where MaterialAllocationQueryView : class, IView where WizardChildDialogView : class, IView
    {
        public  MaterialAllocationGridView<MaterialAllocationQueryView,WizardChildDialogView> GridView {get;set;}
    }
    public partial class MaterialAllocationGridView <MaterialAllocationQueryView,WizardChildDialogView> :  RPSGridView<MaterialAllocationQueryView,WizardChildDialogView> where MaterialAllocationQueryView : class, IView where WizardChildDialogView : class, IView
    {
        public MaterialAllocationGridView(MaterialAllocationQueryView currentView,WizardChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            OrderSL_OrderDate = RPSControlFactory.CreateRPSGridTextBox<MaterialAllocationQueryView>("","#fb21cb94-d4de-44de-a603-ffe9e81332d3 .ag-row[role='row']@ROWINDEX [col-id='cOrderSL_OrderDate']","",false, this.CurrentView);
 
            OrderLineSL_ReceptionDate = RPSControlFactory.CreateRPSGridTextBox<MaterialAllocationQueryView>("","#fb21cb94-d4de-44de-a603-ffe9e81332d3 .ag-row[role='row']@ROWINDEX [col-id='cOrderLineSL_ReceptionDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MaterialAllocationQueryView> OrderSL_OrderDate { get; set; } 
        public IRPSGridTextBox<MaterialAllocationQueryView> OrderLineSL_ReceptionDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class WizardChildDialogView : View
    {
        public WizardChildDialogView(MaterialAllocation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            iniOrderDate = RPSControlFactory.CreateRPSTextBox<WizardChildDialogView>("8038aaae-80cd-4a79-a0b2-de2a41f05aa0","","",false, this);
 
            endOrderDate = RPSControlFactory.CreateRPSTextBox<WizardChildDialogView>("dfe2b253-f8fa-4517-90a0-30f11b1ce5dd","","",false, this);
 
            iniReceptionDate = RPSControlFactory.CreateRPSTextBox<WizardChildDialogView>("4480a7fd-baa0-497f-96e0-551932378e2d","","",false, this);
 
            endReceptionDate = RPSControlFactory.CreateRPSTextBox<WizardChildDialogView>("54e2b682-bc3b-4cec-a6d6-6fdb49bb1cf0","","",false, this);
 
            OrderSL = RPSControlFactory.CreateRPSCollectionComboBox<WizardChildDialogView>("b04feb58-81a5-4205-b88e-13c07da6179f","","",false, this);
 
            Customer = RPSControlFactory.CreateRPSCollectionComboBox<WizardChildDialogView>("a135fcbe-1f0b-4ae3-93fa-bf0da377dcd0","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<WizardChildDialogView>("929af1b1-c3d4-47c5-9a0d-9e9e842427fd","","",false, this);
 
            PreviousSelection = RPSControlFactory.CreateRPSCheckBox<WizardChildDialogView>("72715b67-7688-41e9-b88b-45886d8dc9cb","","",false, this);
 
            CollectionInit params_MaterialAllocationSelectPrevious = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1e8e963d-f696-4cc3-821e-a3b54f11abf2",CSSSelectorGrid="",XPathGrid=""};
            MaterialAllocationSelectPrevious = RPSControlFactory.RPSCreateCollectionWithGrid<MaterialAllocationSelectPreviousCollectionEditor<WizardChildDialogView>,WizardChildDialogView>( params_MaterialAllocationSelectPrevious,this);
 

        }
        public IRPSTextBox<WizardChildDialogView> iniOrderDate { get; set; } 
        public IRPSTextBox<WizardChildDialogView> endOrderDate { get; set; } 
        public IRPSTextBox<WizardChildDialogView> iniReceptionDate { get; set; } 
        public IRPSTextBox<WizardChildDialogView> endReceptionDate { get; set; } 
        public IRPSCollectionComboBox<WizardChildDialogView> OrderSL { get; set; } 
        public IRPSCollectionComboBox<WizardChildDialogView> Customer { get; set; } 
        public IRPSCollectionComboBox<WizardChildDialogView> Article { get; set; } 
        public IRPSCheckbox<WizardChildDialogView> PreviousSelection { get; set; } 
        public MaterialAllocationSelectPreviousCollectionEditor<WizardChildDialogView> MaterialAllocationSelectPrevious { get; set; } 
        public MaterialAllocation Screen { get; set; }
        public WizardChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaterialAllocationSelectPreviousCollectionEditor<WizardChildDialogView>:RPSCollectionEditor<WizardChildDialogView> where WizardChildDialogView : class, IView
    {
        public  MaterialAllocationSelectPreviousGridView<WizardChildDialogView> GridView {get;set;}
    }
    public partial class MaterialAllocationSelectPreviousGridView <WizardChildDialogView> :  RPSGridView<WizardChildDialogView> where WizardChildDialogView : class, IView
    {
        public MaterialAllocationSelectPreviousGridView(WizardChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            OrderSL_OrderDate = RPSControlFactory.CreateRPSGridTextBox<WizardChildDialogView>("","#1e8e963d-f696-4cc3-821e-a3b54f11abf2 .ag-row[role='row']@ROWINDEX [col-id='cOrderSL_OrderDate']","",false, this.CurrentView);
 
            OrderSL_ReceptionDate = RPSControlFactory.CreateRPSGridTextBox<WizardChildDialogView>("","#1e8e963d-f696-4cc3-821e-a3b54f11abf2 .ag-row[role='row']@ROWINDEX [col-id='cOrderSL_ReceptionDate']","",false, this.CurrentView);
 
            OrderSL_OrderNumberCustomer = RPSControlFactory.CreateRPSGridTextBox<WizardChildDialogView>("","#1e8e963d-f696-4cc3-821e-a3b54f11abf2 .ag-row[role='row']@ROWINDEX [col-id='cOrderSL_OrderNumberCustomer']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<WizardChildDialogView> OrderSL_OrderDate { get; set; } 
        public IRPSGridTextBox<WizardChildDialogView> OrderSL_ReceptionDate { get; set; } 
        public IRPSGridTextBox<WizardChildDialogView> OrderSL_OrderNumberCustomer { get; set; } 
                     
    }
 
    }
  
            
    public partial class StockReserveView : View
    {
        public StockReserveView(MaterialAllocation screen) : base()
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
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<StockReserveView>("2bc6fe99-536c-4a39-a1be-91200972f61c","","",true, this);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<StockReserveView>("465ce9d9-9701-4612-bb51-a78c71b425f5","","",true, this);
 

        }
        public IRPSSaveButton<StockReserveView> SaveButton { get; set; } 
        public IRPSComboBox<StockReserveView> IDArticle { get; set; } 
        public IRPSComboBox<StockReserveView> UIIDSite { get; set; } 
        public IRPSComboBox<StockReserveView> UIIDWareHouse { get; set; } 
        public IRPSComboBox<StockReserveView> UISeries { get; set; } 
        public IRPSComboBox<StockReserveView> UIIDLocationWarehouse { get; set; } 
        public IRPSTextBox<StockReserveView> Quantity { get; set; } 
        public IRPSTextBox<StockReserveView> QuantitySecondUnit { get; set; } 
        public MaterialAllocation Screen { get; set; }
        public StockReserveView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaterialAllocationReservesView : View
    {
        public MaterialAllocationReservesView(MaterialAllocation screen) : base()
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
 
            CollectionInit params_StockReserveForAllocation = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d4640820-e376-4301-9e64-66f5a3be8864",CSSSelectorGrid="",XPathGrid=""};
            StockReserveForAllocation = RPSControlFactory.RPSCreateCollectionWithGrid<StockReserveForAllocationCollectionEditor<MaterialAllocationReservesView>,MaterialAllocationReservesView>( params_StockReserveForAllocation,this);
 

        }
        public IRPSComboBox<MaterialAllocationReservesView> Article { get; set; } 
        public IRPSTextBox<MaterialAllocationReservesView> Quantity { get; set; } 
        public IRPSTextBox<MaterialAllocationReservesView> PendingQuantity { get; set; } 
        public IRPSTextBox<MaterialAllocationReservesView> AssignedQuantity { get; set; } 
        public IRPSButton<MaterialAllocationReservesView> LinkNavigationCommandButton { get; set; } 
        public IRPSButton<MaterialAllocationReservesView> SaveQuantityCommandButton { get; set; } 
        public StockReserveForAllocationCollectionEditor<MaterialAllocationReservesView> StockReserveForAllocation { get; set; } 
        public MaterialAllocation Screen { get; set; }
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
            DeleteStockReserveCommand = RPSControlFactory.CreateRPSGridButton<MaterialAllocationReservesView>( "","#d4640820-e376-4301-9e64-66f5a3be8864 .ag-row[role='row']@ROWINDEX [col-id='cDeleteStockReserveCommand']","",this.CurrentView);
 
            Stock_Series = RPSControlFactory.CreateRPSGridTextBox<MaterialAllocationReservesView>("","#d4640820-e376-4301-9e64-66f5a3be8864 .ag-row[role='row']@ROWINDEX [col-id='cStock_Series']","",false, this.CurrentView);
 

        }
        public IRPSGridButton<MaterialAllocationReservesView> DeleteStockReserveCommand { get; set; } 
        public IRPSGridTextBox<MaterialAllocationReservesView> Stock_Series { get; set; } 
                     
    }
 
    }
  
    

}