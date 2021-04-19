    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.MaterialAllocation
{
    //RPS VERSION 1.0.0.0
    public partial class MaterialAllocation:Screen
    {
        public MaterialAllocation():base()
        {
            this.URL = "manufacturing.materialallocation";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MaterialAllocationQueryView  = new MaterialAllocationQueryView(this); 
            WizardChildDialogView  = new WizardChildDialogView(this); 
            MaterialAllocationReservesView  = new MaterialAllocationReservesView(this); 
            StockReserveView  = new StockReserveView(this); 
            MaterialAllocationQueryView.InitializeControls(); 
            WizardChildDialogView.InitializeControls(); 
            MaterialAllocationReservesView.InitializeControls(); 
            StockReserveView.InitializeControls(); 
           
        }
      
            public MaterialAllocationQueryView MaterialAllocationQueryView {get; set; } 
            public WizardChildDialogView WizardChildDialogView {get; set; } 
            public MaterialAllocationReservesView MaterialAllocationReservesView {get; set; } 
            public StockReserveView StockReserveView {get; set; } 
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
            IDSite = RPSControlFactory.CreateRPSComboBox<MaterialAllocationQueryView>("fd5e3b00-39e5-44cf-b0ec-802259d80a93","","",false, this);
 
            IDStructureType = RPSControlFactory.CreateRPSCollectionComboBox<MaterialAllocationQueryView>("d1264593-f677-4143-a492-2171501d44fe","","",false, this);
 
            IDManufacturingOrder = RPSControlFactory.CreateRPSCollectionComboBox<MaterialAllocationQueryView>("c8cf4b36-1334-494a-8454-93f3050e54dc","","",false, this);
 
            Article = RPSControlFactory.CreateRPSCollectionComboBox<MaterialAllocationQueryView>("b74c985e-ff75-498a-a798-ddff39827763","","",false, this);
 
            All = RPSControlFactory.CreateRPSOption<MaterialAllocationQueryView>( "b01a6d1a-44b1-4c84-a73c-2881ae0911bf","","",this);
 
            WithAllocation = RPSControlFactory.CreateRPSOption<MaterialAllocationQueryView>( "cbf301ad-e8c3-42d4-bb75-f7acdfdb14c8","","",this);
 
            WithoutAllocations = RPSControlFactory.CreateRPSOption<MaterialAllocationQueryView>( "83639579-5f69-4234-93a5-ce21130c9b0f","","",this);
 
            GenerateCommandButton = RPSControlFactory.CreateRPSButton<MaterialAllocationQueryView>( "5c2888e1-6e3d-424a-b906-96c7f8f465c0","","",this);
 
            DeleteCommandButton = RPSControlFactory.CreateRPSButton<MaterialAllocationQueryView>( "48387e8e-aa91-4a37-b8b1-e61924ec70eb","","",this);
 
            CollectionInit params_MOMaterialConsultFromAllocation = new CollectionInit(){IDDescriptor = "a2b24f66-5705-43de-9154-4b9a3bdcc865",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6f07888f-c3cd-44de-9355-cc66e75e0759",CSSSelectorGrid="",XPathGrid=""};
            MOMaterialConsultFromAllocation = RPSControlFactory.RPSCreateCollectionWithGrid<MOMaterialConsultFromAllocationCollectionEditor<MaterialAllocationQueryView,WizardChildDialogView>,MaterialAllocationQueryView,WizardChildDialogView>( params_MOMaterialConsultFromAllocation,this,Screen.WizardChildDialogView);
 

        }
        public IRPSComboBox<MaterialAllocationQueryView> IDSite { get; set; } 
        public IRPSCollectionComboBox<MaterialAllocationQueryView> IDStructureType { get; set; } 
        public IRPSCollectionComboBox<MaterialAllocationQueryView> IDManufacturingOrder { get; set; } 
        public IRPSCollectionComboBox<MaterialAllocationQueryView> Article { get; set; } 
        public IRPSOption<MaterialAllocationQueryView> All { get; set; } 
        public IRPSOption<MaterialAllocationQueryView> WithAllocation { get; set; } 
        public IRPSOption<MaterialAllocationQueryView> WithoutAllocations { get; set; } 
        public IRPSButton<MaterialAllocationQueryView> GenerateCommandButton { get; set; } 
        public IRPSButton<MaterialAllocationQueryView> DeleteCommandButton { get; set; } 
        public MOMaterialConsultFromAllocationCollectionEditor<MaterialAllocationQueryView,WizardChildDialogView> MOMaterialConsultFromAllocation { get; set; } 
        public MaterialAllocation Screen { get; set; }
        public MaterialAllocationQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MOMaterialConsultFromAllocationCollectionEditor<MaterialAllocationQueryView,WizardChildDialogView>:RPSCollectionEditor<MaterialAllocationQueryView,WizardChildDialogView> where MaterialAllocationQueryView : class, IView where WizardChildDialogView : class, IView
    {
        public  MOMaterialConsultFromAllocationGridView<MaterialAllocationQueryView,WizardChildDialogView> GridView {get;set;}
    }
    public partial class MOMaterialConsultFromAllocationGridView <MaterialAllocationQueryView,WizardChildDialogView> :  RPSGridView<MaterialAllocationQueryView,WizardChildDialogView> where MaterialAllocationQueryView : class, IView where WizardChildDialogView : class, IView
    {
        public MOMaterialConsultFromAllocationGridView(MaterialAllocationQueryView currentView,WizardChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MOTask_PlannedStartDate = RPSControlFactory.CreateRPSGridTextBox<MaterialAllocationQueryView>("","#6f07888f-c3cd-44de-9355-cc66e75e0759 .ag-row[role='row']@ROWINDEX [col-id='cMOTask_PlannedStartDate']","",false, this.CurrentView);
 
            MOTask_PlannedEndDate = RPSControlFactory.CreateRPSGridTextBox<MaterialAllocationQueryView>("","#6f07888f-c3cd-44de-9355-cc66e75e0759 .ag-row[role='row']@ROWINDEX [col-id='cMOTask_PlannedEndDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MaterialAllocationQueryView> MOTask_PlannedStartDate { get; set; } 
        public IRPSGridTextBox<MaterialAllocationQueryView> MOTask_PlannedEndDate { get; set; } 
                     
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
            IDSite = RPSControlFactory.CreateRPSComboBox<WizardChildDialogView>("079b97c3-8f18-451a-b74c-69ce2cee8c3a","","",false, this);
 
            IDManufacturingOrder = RPSControlFactory.CreateRPSCollectionComboBox<WizardChildDialogView>("7cedb4da-380c-4c99-a43d-b6de4c9c3e71","","",false, this);
 
            IDStructureType = RPSControlFactory.CreateRPSCollectionComboBox<WizardChildDialogView>("0f5211b4-e777-4640-84c2-1afddb6d714a","","",false, this);
 
            PreviousSelection = RPSControlFactory.CreateRPSCheckBox<WizardChildDialogView>("0c4b4f68-9389-4534-937a-9873efd8ba38","","",false, this);
 
            CollectionInit params_ManufacturingOrderForAssignmentMaterial = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7592b034-4698-41b5-8a60-5ebbf8d74179",CSSSelectorGrid="",XPathGrid=""};
            ManufacturingOrderForAssignmentMaterial = RPSControlFactory.RPSCreateCollectionWithGrid<ManufacturingOrderForAssignmentMaterialCollectionEditor<WizardChildDialogView>,WizardChildDialogView>( params_ManufacturingOrderForAssignmentMaterial,this);
 

        }
        public IRPSComboBox<WizardChildDialogView> IDSite { get; set; } 
        public IRPSCollectionComboBox<WizardChildDialogView> IDManufacturingOrder { get; set; } 
        public IRPSCollectionComboBox<WizardChildDialogView> IDStructureType { get; set; } 
        public IRPSCheckbox<WizardChildDialogView> PreviousSelection { get; set; } 
        public ManufacturingOrderForAssignmentMaterialCollectionEditor<WizardChildDialogView> ManufacturingOrderForAssignmentMaterial { get; set; } 
        public MaterialAllocation Screen { get; set; }
        public WizardChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ManufacturingOrderForAssignmentMaterialCollectionEditor<WizardChildDialogView>:RPSCollectionEditor<WizardChildDialogView> where WizardChildDialogView : class, IView
    {
        public  ManufacturingOrderForAssignmentMaterialGridView<WizardChildDialogView> GridView {get;set;}
    }
    public partial class ManufacturingOrderForAssignmentMaterialGridView <WizardChildDialogView> :  RPSGridView<WizardChildDialogView> where WizardChildDialogView : class, IView
    {
        public ManufacturingOrderForAssignmentMaterialGridView(WizardChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ManufacturingOrder_CodManufacturingOrder = RPSControlFactory.CreateRPSGridTextBox<WizardChildDialogView>("","#7592b034-4698-41b5-8a60-5ebbf8d74179 .ag-row[role='row']@ROWINDEX [col-id='cManufacturingOrder_CodManufacturingOrder']","",false, this.CurrentView);
 
            ManufacturingOrder_Description = RPSControlFactory.CreateRPSGridTextBox<WizardChildDialogView>("","#7592b034-4698-41b5-8a60-5ebbf8d74179 .ag-row[role='row']@ROWINDEX [col-id='cManufacturingOrder_Description']","",false, this.CurrentView);
 
            ManufacturingOrder_AcceptedDate = RPSControlFactory.CreateRPSGridTextBox<WizardChildDialogView>("","#7592b034-4698-41b5-8a60-5ebbf8d74179 .ag-row[role='row']@ROWINDEX [col-id='cManufacturingOrder_AcceptedDate']","",false, this.CurrentView);
 
            ManufacturingOrder_PlannedStartDate = RPSControlFactory.CreateRPSGridTextBox<WizardChildDialogView>("","#7592b034-4698-41b5-8a60-5ebbf8d74179 .ag-row[role='row']@ROWINDEX [col-id='cManufacturingOrder_PlannedStartDate']","",false, this.CurrentView);
 
            ManufacturingOrder_PlannedEndDate = RPSControlFactory.CreateRPSGridTextBox<WizardChildDialogView>("","#7592b034-4698-41b5-8a60-5ebbf8d74179 .ag-row[role='row']@ROWINDEX [col-id='cManufacturingOrder_PlannedEndDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<WizardChildDialogView> ManufacturingOrder_CodManufacturingOrder { get; set; } 
        public IRPSGridTextBox<WizardChildDialogView> ManufacturingOrder_Description { get; set; } 
        public IRPSGridTextBox<WizardChildDialogView> ManufacturingOrder_AcceptedDate { get; set; } 
        public IRPSGridTextBox<WizardChildDialogView> ManufacturingOrder_PlannedStartDate { get; set; } 
        public IRPSGridTextBox<WizardChildDialogView> ManufacturingOrder_PlannedEndDate { get; set; } 
                     
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
            IDArticle = RPSControlFactory.CreateRPSComboBox<MaterialAllocationReservesView>("75fee0f1-206e-41d8-90b1-5b0be30b930b","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<MaterialAllocationReservesView>("bef906b1-07f9-4c40-a5ac-907d5638ff8e","","",false, this);
 
            PendingQuantity = RPSControlFactory.CreateRPSFormattedTextBox<MaterialAllocationReservesView>("6141a822-f221-41b1-b6f4-64527e096c28","","",false, this);
 
            AssignedQuantity = RPSControlFactory.CreateRPSFormattedTextBox<MaterialAllocationReservesView>("409d927b-b7d9-4c23-9696-ca4fe30e7b6b","","",false, this);
 
            LinkNavigationCommandButton = RPSControlFactory.CreateRPSButton<MaterialAllocationReservesView>( "37fa30ff-b5a9-4c34-9fb5-ef3b1a5123a0","","",this);
 
            SaveQuantityCommandButton = RPSControlFactory.CreateRPSButton<MaterialAllocationReservesView>( "bd7f281f-c883-4b1c-a93c-870ec42000dc","","",this);
 
            CollectionInit params_StockReserveForAllocation = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7d5b61ce-4ae5-4ef9-bb8a-ad5adeb5757e",CSSSelectorGrid="",XPathGrid=""};
            StockReserveForAllocation = RPSControlFactory.RPSCreateCollectionWithGrid<StockReserveForAllocationCollectionEditor<MaterialAllocationReservesView>,MaterialAllocationReservesView>( params_StockReserveForAllocation,this);
 

        }
        public IRPSComboBox<MaterialAllocationReservesView> IDArticle { get; set; } 
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
            DeleteStockReserveCommand = RPSControlFactory.CreateRPSGridButton<MaterialAllocationReservesView>( "","#7d5b61ce-4ae5-4ef9-bb8a-ad5adeb5757e .ag-row[role='row']@ROWINDEX [col-id='cDeleteStockReserveCommand']","",this.CurrentView);
 
            Stock_Series = RPSControlFactory.CreateRPSGridTextBox<MaterialAllocationReservesView>("","#7d5b61ce-4ae5-4ef9-bb8a-ad5adeb5757e .ag-row[role='row']@ROWINDEX [col-id='cStock_Series']","",false, this.CurrentView);
 

        }
        public IRPSGridButton<MaterialAllocationReservesView> DeleteStockReserveCommand { get; set; } 
        public IRPSGridTextBox<MaterialAllocationReservesView> Stock_Series { get; set; } 
                     
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
  
    

}