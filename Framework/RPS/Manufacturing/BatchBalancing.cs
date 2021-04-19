    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.BatchBalancing
{
    //RPS VERSION 1.0.0.0
    public partial class BatchBalancing:Screen
    {
        public BatchBalancing():base()
        {
            this.URL = "manufacturing.batchbalancing";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            BatchBalancingQueryView  = new BatchBalancingQueryView(this); 
            BatchBalancingAsignmentChildDialogView  = new BatchBalancingAsignmentChildDialogView(this); 
            BatchBalancingQueryView.InitializeControls(); 
            BatchBalancingAsignmentChildDialogView.InitializeControls(); 
           
        }
      
            public BatchBalancingQueryView BatchBalancingQueryView {get; set; } 
            public BatchBalancingAsignmentChildDialogView BatchBalancingAsignmentChildDialogView {get; set; } 
    }
            
    public partial class BatchBalancingQueryView : View
    {
        public BatchBalancingQueryView(BatchBalancing screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<BatchBalancingQueryView>("cca280d6-2541-4721-9452-30be94ed0177","","",false, this);
 
            ManufacturingOrder = RPSControlFactory.CreateRPSComboBox<BatchBalancingQueryView>("2d632b9d-58d9-447f-97be-e2490e304bf9","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<BatchBalancingQueryView>("dfdb388a-f3c2-4635-a4ec-d0e2e18a224d","","",false, this);
 
            ExecuteImputationMaterialMOButton = RPSControlFactory.CreateRPSButton<BatchBalancingQueryView>( "c8c8bfc4-e0ea-4560-b06f-b187cd2cd32b","","",this);
 
            ExecuteAllocationMOMaterialButton = RPSControlFactory.CreateRPSButton<BatchBalancingQueryView>( "513daafb-b6d2-4bb4-99b6-d74dbb587890","","",this);
 
            DeleteSelectedItemsButton = RPSControlFactory.CreateRPSButton<BatchBalancingQueryView>( "1593b569-7ea6-4339-a91e-aa73d2daf3c0","","",this);
 
            ExecuteImputationMaterialMOFromManufacturingOrderButton = RPSControlFactory.CreateRPSButton<BatchBalancingQueryView>( "37d93b75-3bea-4cfa-ae7c-b2e2c95b6758","","",this);
 
            NewCommandButton = RPSControlFactory.CreateRPSButton<BatchBalancingQueryView>( "28814a48-0de4-4ecc-91ef-a9cbfae368fc","","",this);
 
            ExecuteAllocationMOButton = RPSControlFactory.CreateRPSButton<BatchBalancingQueryView>( "f11f6f01-d679-4bf3-b6ee-5dcabf75ef17","","",this);
 
            DeleteAllItemsButton = RPSControlFactory.CreateRPSButton<BatchBalancingQueryView>( "f4babd92-49a5-4779-8b55-ef5d8ec8c611","","",this);
 
            CollectionInit params_BatchBalancing = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="302667c9-6167-41b7-a05f-e44c585f0448",CSSSelectorGrid="",XPathGrid=""};
            BatchBalancing = RPSControlFactory.RPSCreateCollectionWithGrid<BatchBalancingCollectionEditor<BatchBalancingQueryView>,BatchBalancingQueryView>( params_BatchBalancing,this);
 

        }
        public IRPSComboBox<BatchBalancingQueryView> Site { get; set; } 
        public IRPSComboBox<BatchBalancingQueryView> ManufacturingOrder { get; set; } 
        public IRPSTextBox<BatchBalancingQueryView> Quantity { get; set; } 
        public IRPSButton<BatchBalancingQueryView> ExecuteImputationMaterialMOButton { get; set; } 
        public IRPSButton<BatchBalancingQueryView> ExecuteAllocationMOMaterialButton { get; set; } 
        public IRPSButton<BatchBalancingQueryView> DeleteSelectedItemsButton { get; set; } 
        public IRPSButton<BatchBalancingQueryView> ExecuteImputationMaterialMOFromManufacturingOrderButton { get; set; } 
        public IRPSButton<BatchBalancingQueryView> NewCommandButton { get; set; } 
        public IRPSButton<BatchBalancingQueryView> ExecuteAllocationMOButton { get; set; } 
        public IRPSButton<BatchBalancingQueryView> DeleteAllItemsButton { get; set; } 
        public BatchBalancingCollectionEditor<BatchBalancingQueryView> BatchBalancing { get; set; } 
        public BatchBalancing Screen { get; set; }
        public BatchBalancingQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class BatchBalancingCollectionEditor<BatchBalancingQueryView>:RPSCollectionEditor<BatchBalancingQueryView> where BatchBalancingQueryView : class, IView
    {
        public  BatchBalancingGridView<BatchBalancingQueryView> GridView {get;set;}
    }
    public partial class BatchBalancingGridView <BatchBalancingQueryView> :  RPSGridView<BatchBalancingQueryView> where BatchBalancingQueryView : class, IView
    {
        public BatchBalancingGridView(BatchBalancingQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            eMaterialType = RPSControlFactory.CreateRPSGridEnumComboBox<BatchBalancingQueryView>("","#302667c9-6167-41b7-a05f-e44c585f0448 .ag-row[role='row']@ROWINDEX [col-id='ceMaterialType']","",false, this.CurrentView);
 
            Serie = RPSControlFactory.CreateRPSGridTextBox<BatchBalancingQueryView>("","#302667c9-6167-41b7-a05f-e44c585f0448 .ag-row[role='row']@ROWINDEX [col-id='cSerie']","",false, this.CurrentView);
 
            SeriesEntryProduct = RPSControlFactory.CreateRPSGridEnumComboBox<BatchBalancingQueryView>("","#302667c9-6167-41b7-a05f-e44c585f0448 .ag-row[role='row']@ROWINDEX [col-id='cSeriesEntryProduct']","",false, this.CurrentView);
 
            LinkNavigationCommand = RPSControlFactory.CreateRPSGridButton<BatchBalancingQueryView>( "","#302667c9-6167-41b7-a05f-e44c585f0448 .ag-row[role='row']@ROWINDEX [col-id='cLinkNavigationCommand']","",this.CurrentView);
 

        }
        public IRPSGridComboBox<BatchBalancingQueryView> eMaterialType { get; set; } 
        public IRPSGridTextBox<BatchBalancingQueryView> Serie { get; set; } 
        public IRPSGridComboBox<BatchBalancingQueryView> SeriesEntryProduct { get; set; } 
        public IRPSGridButton<BatchBalancingQueryView> LinkNavigationCommand { get; set; } 
                     
    }
 
    }
  
            
    public partial class BatchBalancingAsignmentChildDialogView : View
    {
        public BatchBalancingAsignmentChildDialogView(BatchBalancing screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Article = RPSControlFactory.CreateRPSComboBox<BatchBalancingAsignmentChildDialogView>("092bcc56-6881-43fe-93e2-be542b442de9","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<BatchBalancingAsignmentChildDialogView>("075302b5-1b3f-487c-9fa1-cf158dd3339b","","",false, this);
 
            PendingActiveQuantity = RPSControlFactory.CreateRPSFormattedTextBox<BatchBalancingAsignmentChildDialogView>("803353bd-e10d-49c1-9f52-4469f4e15269","","",false, this);
 
            Site = RPSControlFactory.CreateRPSComboBox<BatchBalancingAsignmentChildDialogView>("480dd052-6f1b-4201-99a0-dbac7063db45","","",false, this);
 
            ExecuteLoadSeries = RPSControlFactory.CreateRPSButton<BatchBalancingAsignmentChildDialogView>( "aae3586f-5db3-4e46-b33e-f636afad7e71","","",this);
 
            OKCommand = RPSControlFactory.CreateRPSButton<BatchBalancingAsignmentChildDialogView>( "f719e48b-b75f-480d-9cf9-9d6bdad3a9b0","","",this);
 
            LinkNavigationCommand = RPSControlFactory.CreateRPSButton<BatchBalancingAsignmentChildDialogView>( "d589380a-d3e8-40e2-a515-3ee3873352ca","","",this);
 
            CollectionInit params_LoadSeries = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c5913e0e-70ce-4c1e-9272-fef1042ef77c",CSSSelectorGrid="",XPathGrid=""};
            LoadSeries = RPSControlFactory.RPSCreateCollectionWithGrid<LoadSeriesCollectionEditor<BatchBalancingAsignmentChildDialogView>,BatchBalancingAsignmentChildDialogView>( params_LoadSeries,this);
 

        }
        public IRPSComboBox<BatchBalancingAsignmentChildDialogView> Article { get; set; } 
        public IRPSTextBox<BatchBalancingAsignmentChildDialogView> Quantity { get; set; } 
        public IRPSTextBox<BatchBalancingAsignmentChildDialogView> PendingActiveQuantity { get; set; } 
        public IRPSComboBox<BatchBalancingAsignmentChildDialogView> Site { get; set; } 
        public IRPSButton<BatchBalancingAsignmentChildDialogView> ExecuteLoadSeries { get; set; } 
        public IRPSButton<BatchBalancingAsignmentChildDialogView> OKCommand { get; set; } 
        public IRPSButton<BatchBalancingAsignmentChildDialogView> LinkNavigationCommand { get; set; } 
        public LoadSeriesCollectionEditor<BatchBalancingAsignmentChildDialogView> LoadSeries { get; set; } 
        public BatchBalancing Screen { get; set; }
        public BatchBalancingAsignmentChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class LoadSeriesCollectionEditor<BatchBalancingAsignmentChildDialogView>:RPSCollectionEditor<BatchBalancingAsignmentChildDialogView> where BatchBalancingAsignmentChildDialogView : class, IView
    {
        public  LoadSeriesGridView<BatchBalancingAsignmentChildDialogView> GridView {get;set;}
    }
    public partial class LoadSeriesGridView <BatchBalancingAsignmentChildDialogView> :  RPSGridView<BatchBalancingAsignmentChildDialogView> where BatchBalancingAsignmentChildDialogView : class, IView
    {
        public LoadSeriesGridView(BatchBalancingAsignmentChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Series = RPSControlFactory.CreateRPSGridTextBox<BatchBalancingAsignmentChildDialogView>("","#c5913e0e-70ce-4c1e-9272-fef1042ef77c .ag-row[role='row']@ROWINDEX [col-id='cSeries']","",false, this.CurrentView);
 
            QuantityReserved = RPSControlFactory.CreateRPSGridFormattedTextBox<BatchBalancingAsignmentChildDialogView>("","#c5913e0e-70ce-4c1e-9272-fef1042ef77c .ag-row[role='row']@ROWINDEX [col-id='cQuantityReserved']","",false, this.CurrentView);
 
            ReservedActiveQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<BatchBalancingAsignmentChildDialogView>("","#c5913e0e-70ce-4c1e-9272-fef1042ef77c .ag-row[role='row']@ROWINDEX [col-id='cReservedActiveQuantity']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<BatchBalancingAsignmentChildDialogView> Series { get; set; } 
        public IRPSGridTextBox<BatchBalancingAsignmentChildDialogView> QuantityReserved { get; set; } 
        public IRPSGridTextBox<BatchBalancingAsignmentChildDialogView> ReservedActiveQuantity { get; set; } 
                     
    }
 
    }
  
    

}