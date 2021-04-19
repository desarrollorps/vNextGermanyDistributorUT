    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Purchase.ExternalTaskData
{
    //RPS VERSION 1.0.0.0
    public partial class ExternalTaskData:Screen
    {
        public ExternalTaskData():base()
        {
            this.URL = "purchase.externaltaskdata";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ExternalTaskDataView  = new ExternalTaskDataView(this); 
            DataForTransferDeliveryNoteDialogView  = new DataForTransferDeliveryNoteDialogView(this); 
            DataForTransferMovementsDialogView  = new DataForTransferMovementsDialogView(this); 
            TransferMovementsForExternalTaskDialogView  = new TransferMovementsForExternalTaskDialogView(this); 
            DataFroTransferPurchaseDeliveryNoteChildDialogView  = new DataFroTransferPurchaseDeliveryNoteChildDialogView(this); 
            ExternalTaskDataView.InitializeControls(); 
            DataForTransferDeliveryNoteDialogView.InitializeControls(); 
            DataForTransferMovementsDialogView.InitializeControls(); 
            TransferMovementsForExternalTaskDialogView.InitializeControls(); 
            DataFroTransferPurchaseDeliveryNoteChildDialogView.InitializeControls(); 
           
        }
      
            public ExternalTaskDataView ExternalTaskDataView {get; set; } 
            public DataForTransferDeliveryNoteDialogView DataForTransferDeliveryNoteDialogView {get; set; } 
            public DataForTransferMovementsDialogView DataForTransferMovementsDialogView {get; set; } 
            public TransferMovementsForExternalTaskDialogView TransferMovementsForExternalTaskDialogView {get; set; } 
            public DataFroTransferPurchaseDeliveryNoteChildDialogView DataFroTransferPurchaseDeliveryNoteChildDialogView {get; set; } 
    }
            
    public partial class ExternalTaskDataView : View
    {
        public ExternalTaskDataView(ExternalTaskData screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDOriginManufacturingOrder = RPSControlFactory.CreateRPSComboBox<ExternalTaskDataView>("95eb33f3-4215-4e7c-8ddd-e60215d127d1","","",false, this);
 
            IDOriginProject = RPSControlFactory.CreateRPSComboBox<ExternalTaskDataView>("82c827dd-5f68-4265-b343-273f69b0a73f","","",false, this);
 
            IDOriginMOTask = RPSControlFactory.CreateRPSComboBox<ExternalTaskDataView>("2a02dde3-b89a-44d6-9d67-ba647c1188a8","","",false, this);
 
            IDOriginProjectTask = RPSControlFactory.CreateRPSComboBox<ExternalTaskDataView>("ea372021-1ef7-490c-8c82-2cdf23f17b52","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<ExternalTaskDataView>("83fa2952-5f73-489e-9d67-62c0dd3da4a1","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<ExternalTaskDataView>("fdbbe9db-8c20-4019-a867-7dee4e3676b4","","",false, this);
 
            IDWareHouse = RPSControlFactory.CreateRPSComboBox<ExternalTaskDataView>("952b9ed0-9576-4510-94db-ea350a02dae2","","",false, this);
 
            TotalTaskQuantity = RPSControlFactory.CreateRPSFormattedTextBox<ExternalTaskDataView>("3764482e-23e8-48d3-94c2-f142ccb07d1b","","",false, this);
 
            ProcesableQuantity = RPSControlFactory.CreateRPSFormattedTextBox<ExternalTaskDataView>("1aeeae9a-1a35-4a84-93fb-228e0e7baeaa","","",false, this);
 
            ImputableQuantity = RPSControlFactory.CreateRPSFormattedTextBox<ExternalTaskDataView>("2fc52889-5222-42a2-90f3-e7fbbbe05cf3","","",false, this);
 
            Group = RPSControlFactory.CreateRPSTextBox<ExternalTaskDataView>("7ba74ffa-60f8-49e6-8f9c-4eaa89ffdc48","","",false, this);
 
            ReturnedTransferQuantity = RPSControlFactory.CreateRPSFormattedTextBox<ExternalTaskDataView>("df0ae5c4-6be8-49c0-a70d-7719bad93bb1","","",false, this);
 
            PendingPurchaseQuantity = RPSControlFactory.CreateRPSFormattedTextBox<ExternalTaskDataView>("7dad150e-b1e1-4685-8abf-62f3883072b6","","",false, this);
 
            OptimizationFeature = RPSControlFactory.CreateRPSTextBox<ExternalTaskDataView>("dd1ef179-fb14-4e42-bfda-b7e9028bc7c8","","",false, this);
 
            DataForTransferDeliveryNoteNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ExternalTaskDataView,DataForTransferDeliveryNoteDialogView>("c51cd368-1f72-45db-91b2-2da2be6a4751","","", this,Screen.DataForTransferDeliveryNoteDialogView);
 
            DataForTransferMovementsNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ExternalTaskDataView,DataForTransferMovementsDialogView>("97f6a453-756c-493d-8e3e-3c4ccd1c966b","","", this,Screen.DataForTransferMovementsDialogView);
 
            DataFroTransferPurchaseDeliveryNoteChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ExternalTaskDataView,DataFroTransferPurchaseDeliveryNoteChildDialogView>("6d9a36e5-cf41-4f2e-bbd4-3e3f58355fc9","","", this,Screen.DataFroTransferPurchaseDeliveryNoteChildDialogView);
 
            EditableTransferableQuantity = RPSControlFactory.CreateRPSFormattedTextBox<ExternalTaskDataView>("99e66e1d-fe13-409d-a4bc-e796ebebe65d","","",false, this);
 
            FinalizeExternalMaterialDeliveryButton = RPSControlFactory.CreateRPSButton<ExternalTaskDataView>( "05327c0c-986d-4cb2-8b84-bdad1c648889","","",this);
 
            CollectionInit params_ExternalTaskDataMaterialData = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="78207317-c406-4a0c-ae62-846605369749",CSSSelectorGrid="",XPathGrid=""};
            ExternalTaskDataMaterialData = RPSControlFactory.RPSCreateCollectionWithGrid<ExternalTaskDataMaterialDataCollectionEditor<ExternalTaskDataView,DataForTransferDeliveryNoteDialogView>,ExternalTaskDataView,DataForTransferDeliveryNoteDialogView>( params_ExternalTaskDataMaterialData,this,Screen.DataForTransferDeliveryNoteDialogView);
 
            CollectionInit params_ExternalTaskDataPurchaseOrderLineData = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7bed0878-c529-434d-9d58-c18f7211e1cc",CSSSelectorGrid="",XPathGrid=""};
            ExternalTaskDataPurchaseOrderLineData = RPSControlFactory.RPSCreateCollectionWithGrid<ExternalTaskDataPurchaseOrderLineDataCollectionEditor<ExternalTaskDataView,DataForTransferDeliveryNoteDialogView>,ExternalTaskDataView,DataForTransferDeliveryNoteDialogView>( params_ExternalTaskDataPurchaseOrderLineData,this,Screen.DataForTransferDeliveryNoteDialogView);
 
            MaterialGrid = RPSControlFactory.CreateRPSSection<ExternalTaskDataView>( "","ul li[rpsid='88bdf5e0-46d5-4410-bb4f-68b5752c9b78']","",this);
 
            PurchaseOrderGrid = RPSControlFactory.CreateRPSSection<ExternalTaskDataView>( "","ul li[rpsid='c0d50039-7b65-43aa-ac01-b338f123eed8']","",this);
 

        }
        public IRPSComboBox<ExternalTaskDataView> IDOriginManufacturingOrder { get; set; } 
        public IRPSComboBox<ExternalTaskDataView> IDOriginProject { get; set; } 
        public IRPSComboBox<ExternalTaskDataView> IDOriginMOTask { get; set; } 
        public IRPSComboBox<ExternalTaskDataView> IDOriginProjectTask { get; set; } 
        public IRPSComboBox<ExternalTaskDataView> IDSupplier { get; set; } 
        public IRPSComboBox<ExternalTaskDataView> IDSite { get; set; } 
        public IRPSComboBox<ExternalTaskDataView> IDWareHouse { get; set; } 
        public IRPSTextBox<ExternalTaskDataView> TotalTaskQuantity { get; set; } 
        public IRPSTextBox<ExternalTaskDataView> ProcesableQuantity { get; set; } 
        public IRPSTextBox<ExternalTaskDataView> ImputableQuantity { get; set; } 
        public IRPSTextBox<ExternalTaskDataView> Group { get; set; } 
        public IRPSTextBox<ExternalTaskDataView> ReturnedTransferQuantity { get; set; } 
        public IRPSTextBox<ExternalTaskDataView> PendingPurchaseQuantity { get; set; } 
        public IRPSTextBox<ExternalTaskDataView> OptimizationFeature { get; set; } 
        public IRPSButton<ExternalTaskDataView,DataForTransferDeliveryNoteDialogView> DataForTransferDeliveryNoteNavigationCommandButton { get; set; } 
        public IRPSButton<ExternalTaskDataView,DataForTransferMovementsDialogView> DataForTransferMovementsNavigationCommandButton { get; set; } 
        public IRPSButton<ExternalTaskDataView,DataFroTransferPurchaseDeliveryNoteChildDialogView> DataFroTransferPurchaseDeliveryNoteChildNavigationCommandButton { get; set; } 
        public IRPSTextBox<ExternalTaskDataView> EditableTransferableQuantity { get; set; } 
        public IRPSButton<ExternalTaskDataView> FinalizeExternalMaterialDeliveryButton { get; set; } 
        public ExternalTaskDataMaterialDataCollectionEditor<ExternalTaskDataView,DataForTransferDeliveryNoteDialogView> ExternalTaskDataMaterialData { get; set; } 
        public ExternalTaskDataPurchaseOrderLineDataCollectionEditor<ExternalTaskDataView,DataForTransferDeliveryNoteDialogView> ExternalTaskDataPurchaseOrderLineData { get; set; } 
        public IRPSSection<ExternalTaskDataView> MaterialGrid { get; set; } 
        public IRPSSection<ExternalTaskDataView> PurchaseOrderGrid { get; set; } 
        public ExternalTaskData Screen { get; set; }
        public ExternalTaskDataView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ExternalTaskDataMaterialDataCollectionEditor<ExternalTaskDataView,DataForTransferDeliveryNoteDialogView>:RPSCollectionEditor<ExternalTaskDataView,DataForTransferDeliveryNoteDialogView> where ExternalTaskDataView : class, IView where DataForTransferDeliveryNoteDialogView : class, IView
    {
        public  ExternalTaskDataMaterialDataGridView<ExternalTaskDataView,DataForTransferDeliveryNoteDialogView> GridView {get;set;}
    }
    public partial class ExternalTaskDataMaterialDataGridView <ExternalTaskDataView,DataForTransferDeliveryNoteDialogView> :  RPSGridView<ExternalTaskDataView,DataForTransferDeliveryNoteDialogView> where ExternalTaskDataView : class, IView where DataForTransferDeliveryNoteDialogView : class, IView
    {
        public ExternalTaskDataMaterialDataGridView(ExternalTaskDataView currentView,DataForTransferDeliveryNoteDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            EditableTransferableQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<ExternalTaskDataView>("","#78207317-c406-4a0c-ae62-846605369749 .ag-row[role='row']@ROWINDEX [col-id='cEditableTransferableQuantity']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ExternalTaskDataView> EditableTransferableQuantity { get; set; } 
                     
    }
 
        public partial class ExternalTaskDataPurchaseOrderLineDataCollectionEditor<ExternalTaskDataView,DataForTransferDeliveryNoteDialogView>:RPSCollectionEditor<ExternalTaskDataView,DataForTransferDeliveryNoteDialogView> where ExternalTaskDataView : class, IView where DataForTransferDeliveryNoteDialogView : class, IView
    {
        public  ExternalTaskDataPurchaseOrderLineDataGridView<ExternalTaskDataView,DataForTransferDeliveryNoteDialogView> GridView {get;set;}
    }
    public partial class ExternalTaskDataPurchaseOrderLineDataGridView <ExternalTaskDataView,DataForTransferDeliveryNoteDialogView> :  RPSGridView<ExternalTaskDataView,DataForTransferDeliveryNoteDialogView> where ExternalTaskDataView : class, IView where DataForTransferDeliveryNoteDialogView : class, IView
    {
        public ExternalTaskDataPurchaseOrderLineDataGridView(ExternalTaskDataView currentView,DataForTransferDeliveryNoteDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            OrderLineNumber = RPSControlFactory.CreateRPSGridFormattedTextBox<ExternalTaskDataView>("","#7bed0878-c529-434d-9d58-c18f7211e1cc .ag-row[role='row']@ROWINDEX [col-id='cOrderLineNumber']","",false, this.CurrentView);
 
            FinalizedMaterialDelivery = RPSControlFactory.CreateRPSGridCheckBox<ExternalTaskDataView>("","#7bed0878-c529-434d-9d58-c18f7211e1cc .ag-row[role='row']@ROWINDEX [col-id='cFinalizedMaterialDelivery']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ExternalTaskDataView> OrderLineNumber { get; set; } 
        public IRPSGridCheckbox<ExternalTaskDataView> FinalizedMaterialDelivery { get; set; } 
                     
    }
 
    }
  
            
    public partial class DataForTransferDeliveryNoteDialogView : View
    {
        public DataForTransferDeliveryNoteDialogView(ExternalTaskData screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDCustomer = RPSControlFactory.CreateRPSComboBox<DataForTransferDeliveryNoteDialogView>("e4befd26-4a7f-44a7-b607-bd4084eee96f","","",false, this);
 
            IDDeliveryNoteTypeSL = RPSControlFactory.CreateRPSComboBox<DataForTransferDeliveryNoteDialogView>("94687b7e-f977-4bef-af73-e2e9503bb4ef","","",false, this);
 
            DeliveryNoteDate = RPSControlFactory.CreateRPSTextBox<DataForTransferDeliveryNoteDialogView>("386b405d-3f84-4c3f-a3d6-b3c3cb77f733","","",false, this);
 

        }
        public IRPSComboBox<DataForTransferDeliveryNoteDialogView> IDCustomer { get; set; } 
        public IRPSComboBox<DataForTransferDeliveryNoteDialogView> IDDeliveryNoteTypeSL { get; set; } 
        public IRPSTextBox<DataForTransferDeliveryNoteDialogView> DeliveryNoteDate { get; set; } 
        public ExternalTaskData Screen { get; set; }
        public DataForTransferDeliveryNoteDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DataForTransferMovementsDialogView : View
    {
        public DataForTransferMovementsDialogView(ExternalTaskData screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDMovementType = RPSControlFactory.CreateRPSComboBox<DataForTransferMovementsDialogView>("92909be5-0b37-45ae-a2f2-1c25e6482ffa","","",false, this);
 
            TransferDate = RPSControlFactory.CreateRPSTextBox<DataForTransferMovementsDialogView>("5ac7d09e-9541-4a47-a152-023dd79d6bf9","","",false, this);
 

        }
        public IRPSComboBox<DataForTransferMovementsDialogView> IDMovementType { get; set; } 
        public IRPSTextBox<DataForTransferMovementsDialogView> TransferDate { get; set; } 
        public ExternalTaskData Screen { get; set; }
        public DataForTransferMovementsDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class TransferMovementsForExternalTaskDialogView : View
    {
        public TransferMovementsForExternalTaskDialogView(ExternalTaskData screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            AddNewMovementCommandButton = RPSControlFactory.CreateRPSButton<TransferMovementsForExternalTaskDialogView>( "84b65f14-3ab3-4c13-b0db-5e3c0329ad3c","","",this);
 
            SaveCommandButton = RPSControlFactory.CreateRPSButton<TransferMovementsForExternalTaskDialogView>( "e3f1723f-d34d-4094-92f2-b8cc1c356141","","",this);
 
            CollectionInit params_TransferMovements = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="58bd6faa-65e0-41e5-820f-070a33280898",CSSSelectorGrid="",XPathGrid=""};
            TransferMovements = RPSControlFactory.RPSCreateCollectionWithGrid<TransferMovementsCollectionEditor<TransferMovementsForExternalTaskDialogView>,TransferMovementsForExternalTaskDialogView>( params_TransferMovements,this);
 

        }
        public IRPSButton<TransferMovementsForExternalTaskDialogView> AddNewMovementCommandButton { get; set; } 
        public IRPSButton<TransferMovementsForExternalTaskDialogView> SaveCommandButton { get; set; } 
        public TransferMovementsCollectionEditor<TransferMovementsForExternalTaskDialogView> TransferMovements { get; set; } 
        public ExternalTaskData Screen { get; set; }
        public TransferMovementsForExternalTaskDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class TransferMovementsCollectionEditor<TransferMovementsForExternalTaskDialogView>:RPSCollectionEditor<TransferMovementsForExternalTaskDialogView> where TransferMovementsForExternalTaskDialogView : class, IView
    {
        public  TransferMovementsGridView<TransferMovementsForExternalTaskDialogView> GridView {get;set;}
    }
    public partial class TransferMovementsGridView <TransferMovementsForExternalTaskDialogView> :  RPSGridView<TransferMovementsForExternalTaskDialogView> where TransferMovementsForExternalTaskDialogView : class, IView
    {
        public TransferMovementsGridView(TransferMovementsForExternalTaskDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            RemoveCommand = RPSControlFactory.CreateRPSGridButton<TransferMovementsForExternalTaskDialogView>( "","#58bd6faa-65e0-41e5-820f-070a33280898 .ag-row[role='row']@ROWINDEX [col-id='cRemoveCommand']","",this.CurrentView);
 
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<TransferMovementsForExternalTaskDialogView>("","#58bd6faa-65e0-41e5-820f-070a33280898 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",false, this.CurrentView);
 
            IDSite = RPSControlFactory.CreateRPSGridComboBox<TransferMovementsForExternalTaskDialogView>("","#58bd6faa-65e0-41e5-820f-070a33280898 .ag-row[role='row']@ROWINDEX [col-id='cIDSite']","",false, this.CurrentView);
 
            IDWareHouse = RPSControlFactory.CreateRPSGridComboBox<TransferMovementsForExternalTaskDialogView>("","#58bd6faa-65e0-41e5-820f-070a33280898 .ag-row[role='row']@ROWINDEX [col-id='cIDWareHouse']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<TransferMovementsForExternalTaskDialogView>("","#58bd6faa-65e0-41e5-820f-070a33280898 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            Series = RPSControlFactory.CreateRPSGridEnumComboBox<TransferMovementsForExternalTaskDialogView>("","#58bd6faa-65e0-41e5-820f-070a33280898 .ag-row[role='row']@ROWINDEX [col-id='cSeries']","",false, this.CurrentView);
 
            IDLocationWarehouse = RPSControlFactory.CreateRPSGridComboBox<TransferMovementsForExternalTaskDialogView>("","#58bd6faa-65e0-41e5-820f-070a33280898 .ag-row[role='row']@ROWINDEX [col-id='cIDLocationWarehouse']","",false, this.CurrentView);
 
            QuantiySecondUnit = RPSControlFactory.CreateRPSGridFormattedTextBox<TransferMovementsForExternalTaskDialogView>("","#58bd6faa-65e0-41e5-820f-070a33280898 .ag-row[role='row']@ROWINDEX [col-id='cQuantitySecondUnit']","",false, this.CurrentView);
 
            IDSiteTransfer = RPSControlFactory.CreateRPSGridComboBox<TransferMovementsForExternalTaskDialogView>("","#58bd6faa-65e0-41e5-820f-070a33280898 .ag-row[role='row']@ROWINDEX [col-id='cIDSiteTransfer']","",false, this.CurrentView);
 
            IDWareHouseTransfer = RPSControlFactory.CreateRPSGridComboBox<TransferMovementsForExternalTaskDialogView>("","#58bd6faa-65e0-41e5-820f-070a33280898 .ag-row[role='row']@ROWINDEX [col-id='cIDWareHouseTransfer']","",false, this.CurrentView);
 
            IDLocationWarehouseTransfer = RPSControlFactory.CreateRPSGridComboBox<TransferMovementsForExternalTaskDialogView>("","#58bd6faa-65e0-41e5-820f-070a33280898 .ag-row[role='row']@ROWINDEX [col-id='cIDLocationWarehouseTransfer']","",false, this.CurrentView);
 

        }
        public IRPSGridButton<TransferMovementsForExternalTaskDialogView> RemoveCommand { get; set; } 
        public IRPSGridComboBox<TransferMovementsForExternalTaskDialogView> IDArticle { get; set; } 
        public IRPSGridComboBox<TransferMovementsForExternalTaskDialogView> IDSite { get; set; } 
        public IRPSGridComboBox<TransferMovementsForExternalTaskDialogView> IDWareHouse { get; set; } 
        public IRPSGridTextBox<TransferMovementsForExternalTaskDialogView> Quantity { get; set; } 
        public IRPSGridComboBox<TransferMovementsForExternalTaskDialogView> Series { get; set; } 
        public IRPSGridComboBox<TransferMovementsForExternalTaskDialogView> IDLocationWarehouse { get; set; } 
        public IRPSGridTextBox<TransferMovementsForExternalTaskDialogView> QuantiySecondUnit { get; set; } 
        public IRPSGridComboBox<TransferMovementsForExternalTaskDialogView> IDSiteTransfer { get; set; } 
        public IRPSGridComboBox<TransferMovementsForExternalTaskDialogView> IDWareHouseTransfer { get; set; } 
        public IRPSGridComboBox<TransferMovementsForExternalTaskDialogView> IDLocationWarehouseTransfer { get; set; } 
                     
    }
 
    }
  
            
    public partial class DataFroTransferPurchaseDeliveryNoteChildDialogView : View
    {
        public DataFroTransferPurchaseDeliveryNoteChildDialogView(ExternalTaskData screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDDeliveryNoteType = RPSControlFactory.CreateRPSComboBox<DataFroTransferPurchaseDeliveryNoteChildDialogView>("c31530ca-71ed-409b-8fff-f17f18c2d563","","",false, this);
 
            DeliveryNoteDate = RPSControlFactory.CreateRPSTextBox<DataFroTransferPurchaseDeliveryNoteChildDialogView>("c1bbe6db-cd6a-470b-bd78-39fb9de03e50","","",false, this);
 

        }
        public IRPSComboBox<DataFroTransferPurchaseDeliveryNoteChildDialogView> IDDeliveryNoteType { get; set; } 
        public IRPSTextBox<DataFroTransferPurchaseDeliveryNoteChildDialogView> DeliveryNoteDate { get; set; } 
        public ExternalTaskData Screen { get; set; }
        public DataFroTransferPurchaseDeliveryNoteChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}