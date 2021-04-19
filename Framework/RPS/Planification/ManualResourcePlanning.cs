    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Planification.ManualResourcePlanning
{
    //RPS VERSION 1.0.0.0
    public partial class ManualResourcePlanning:Screen
    {
        public ManualResourcePlanning():base()
        {
            this.URL = "planification.manualresourceplanning";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ManualResourcePlanningView  = new ManualResourcePlanningView(this); 
            ChangePlannedResourceToNewResourceDV  = new ChangePlannedResourceToNewResourceDV(this); 
            ManualResourcePlanningView.InitializeControls(); 
            ChangePlannedResourceToNewResourceDV.InitializeControls(); 
           
        }
      
            public ManualResourcePlanningView ManualResourcePlanningView {get; set; } 
            public ChangePlannedResourceToNewResourceDV ChangePlannedResourceToNewResourceDV {get; set; } 
    }
            
    public partial class ManualResourcePlanningView : View
    {
        public ManualResourcePlanningView(ManualResourcePlanning screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<ManualResourcePlanningView>("6e9e4a16-51ef-4137-8d7d-6e0e2c0b5b25","","",false, this);
 
            FromDate = RPSControlFactory.CreateRPSTextBox<ManualResourcePlanningView>("3defa2f7-438d-4eb9-b334-ff286e1ed9b2","","",false, this);
 
            PlanningTime = RPSControlFactory.CreateRPSTextBox<ManualResourcePlanningView>("b0732d25-9adc-42d7-b50d-f7335fa0f039","","",false, this);
 
            OPTResources = RPSControlFactory.CreateRPSEnumComboBox<ManualResourcePlanningView>("cf5f49cd-a0ce-4363-8d70-dc9b7aa23acb","","",false, this);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<ManualResourcePlanningView>("c1d7e3c6-d968-4df2-b003-e272153cde99","","",false, this);
 
            IDMachine = RPSControlFactory.CreateRPSComboBox<ManualResourcePlanningView>("6da1fb3b-b177-4ba2-b1b4-0054f348fc8c","","",false, this);
 
            IDTool = RPSControlFactory.CreateRPSComboBox<ManualResourcePlanningView>("5bd3d700-549b-4bc8-99cb-9014b9aaebfb","","",false, this);
 
            IDQualify = RPSControlFactory.CreateRPSComboBox<ManualResourcePlanningView>("0add7e14-8997-493b-980b-9308c96252d9","","",false, this);
 
            IDMachineGroup = RPSControlFactory.CreateRPSComboBox<ManualResourcePlanningView>("a9bd5849-5f21-4f53-879a-716a020559a1","","",false, this);
 
            GetGrids = RPSControlFactory.CreateRPSButton<ManualResourcePlanningView>( "51ca0783-84d3-4eff-9b81-29771a3c2651","","",this);
 
            ChangePlannedResourceToNewResource = RPSControlFactory.CreateRPSButtonToView<ManualResourcePlanningView,ChangePlannedResourceToNewResourceDV>("62e6e8ed-9f94-4a64-89e1-e733308f0649","","", this,Screen.ChangePlannedResourceToNewResourceDV);
 
            RePlanify = RPSControlFactory.CreateRPSButton<ManualResourcePlanningView>( "a10858cb-477f-4af5-94f8-42b725e717b8","","",this);
 
            AddToRes = RPSControlFactory.CreateRPSButton<ManualResourcePlanningView>( "f80258d9-ac27-4c2a-8814-84357f1fa078","","",this);
 
            DelFromRes = RPSControlFactory.CreateRPSButton<ManualResourcePlanningView>( "be96143d-35f1-4135-8c1a-948ee90ef146","","",this);
 
            ApplyOrder = RPSControlFactory.CreateRPSButton<ManualResourcePlanningView>( "365afe97-811a-4493-a3ec-00242f77c293","","",this);
 
            SaveButton = RPSControlFactory.CreateRPSButton<ManualResourcePlanningView>( "20418e9f-4706-4fc9-9fed-0e11ce520c61","","",this);
 
            CollectionInit params_GetAvailableTasksForResource = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="bfd38ee2-c53b-4d2b-9c64-3fcbb4b61b4b",CSSSelectorGrid="",XPathGrid=""};
            GetAvailableTasksForResource = RPSControlFactory.RPSCreateCollectionWithGrid<GetAvailableTasksForResourceCollectionEditor<ManualResourcePlanningView,ChangePlannedResourceToNewResourceDV>,ManualResourcePlanningView,ChangePlannedResourceToNewResourceDV>( params_GetAvailableTasksForResource,this,Screen.ChangePlannedResourceToNewResourceDV);
 
            CollectionInit params_PlannedTasksFromResourceCollection = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7692a024-9ddf-4bdf-8b3d-b8b5c611fec6",CSSSelectorGrid="",XPathGrid=""};
            PlannedTasksFromResourceCollection = RPSControlFactory.RPSCreateCollectionWithGrid<PlannedTasksFromResourceCollectionCollectionEditor<ManualResourcePlanningView,ChangePlannedResourceToNewResourceDV>,ManualResourcePlanningView,ChangePlannedResourceToNewResourceDV>( params_PlannedTasksFromResourceCollection,this,Screen.ChangePlannedResourceToNewResourceDV);
 

        }
        public IRPSComboBox<ManualResourcePlanningView> Site { get; set; } 
        public IRPSTextBox<ManualResourcePlanningView> FromDate { get; set; } 
        public IRPSTextBox<ManualResourcePlanningView> PlanningTime { get; set; } 
        public IRPSComboBox<ManualResourcePlanningView> OPTResources { get; set; } 
        public IRPSComboBox<ManualResourcePlanningView> IDEmployee { get; set; } 
        public IRPSComboBox<ManualResourcePlanningView> IDMachine { get; set; } 
        public IRPSComboBox<ManualResourcePlanningView> IDTool { get; set; } 
        public IRPSComboBox<ManualResourcePlanningView> IDQualify { get; set; } 
        public IRPSComboBox<ManualResourcePlanningView> IDMachineGroup { get; set; } 
        public IRPSButton<ManualResourcePlanningView> GetGrids { get; set; } 
        public IRPSButton<ManualResourcePlanningView,ChangePlannedResourceToNewResourceDV> ChangePlannedResourceToNewResource { get; set; } 
        public IRPSButton<ManualResourcePlanningView> RePlanify { get; set; } 
        public IRPSButton<ManualResourcePlanningView> AddToRes { get; set; } 
        public IRPSButton<ManualResourcePlanningView> DelFromRes { get; set; } 
        public IRPSButton<ManualResourcePlanningView> ApplyOrder { get; set; } 
        public IRPSButton<ManualResourcePlanningView> SaveButton { get; set; } 
        public GetAvailableTasksForResourceCollectionEditor<ManualResourcePlanningView,ChangePlannedResourceToNewResourceDV> GetAvailableTasksForResource { get; set; } 
        public PlannedTasksFromResourceCollectionCollectionEditor<ManualResourcePlanningView,ChangePlannedResourceToNewResourceDV> PlannedTasksFromResourceCollection { get; set; } 
        public ManualResourcePlanning Screen { get; set; }
        public ManualResourcePlanningView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetAvailableTasksForResourceCollectionEditor<ManualResourcePlanningView,ChangePlannedResourceToNewResourceDV>:RPSCollectionEditor<ManualResourcePlanningView,ChangePlannedResourceToNewResourceDV> where ManualResourcePlanningView : class, IView where ChangePlannedResourceToNewResourceDV : class, IView
    {
        public  GetAvailableTasksForResourceGridView<ManualResourcePlanningView,ChangePlannedResourceToNewResourceDV> GridView {get;set;}
    }
    public partial class GetAvailableTasksForResourceGridView <ManualResourcePlanningView,ChangePlannedResourceToNewResourceDV> :  RPSGridView<ManualResourcePlanningView,ChangePlannedResourceToNewResourceDV> where ManualResourcePlanningView : class, IView where ChangePlannedResourceToNewResourceDV : class, IView
    {
        public GetAvailableTasksForResourceGridView(ManualResourcePlanningView currentView,ChangePlannedResourceToNewResourceDV newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            EntityType = RPSControlFactory.CreateRPSGridTextBox<ManualResourcePlanningView>("","#bfd38ee2-c53b-4d2b-9c64-3fcbb4b61b4b .ag-row[role='row']@ROWINDEX [col-id='cEntityType']","",false, this.CurrentView);
 
            DeliveryDate = RPSControlFactory.CreateRPSGridTextBox<ManualResourcePlanningView>("","#bfd38ee2-c53b-4d2b-9c64-3fcbb4b61b4b .ag-row[role='row']@ROWINDEX [col-id='cDeliveryDate']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<ManualResourcePlanningView>("","#bfd38ee2-c53b-4d2b-9c64-3fcbb4b61b4b .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            Duration = RPSControlFactory.CreateRPSGridFormattedTextBox<ManualResourcePlanningView>("","#bfd38ee2-c53b-4d2b-9c64-3fcbb4b61b4b .ag-row[role='row']@ROWINDEX [col-id='cDuration']","",false, this.CurrentView);
 
            Priority = RPSControlFactory.CreateRPSGridFormattedTextBox<ManualResourcePlanningView>("","#bfd38ee2-c53b-4d2b-9c64-3fcbb4b61b4b .ag-row[role='row']@ROWINDEX [col-id='cPriority']","",false, this.CurrentView);
 
            InternalCode = RPSControlFactory.CreateRPSGridTextBox<ManualResourcePlanningView>("","#bfd38ee2-c53b-4d2b-9c64-3fcbb4b61b4b .ag-row[role='row']@ROWINDEX [col-id='cInternalCode']","",false, this.CurrentView);
 
            Qualification = RPSControlFactory.CreateRPSGridTextBox<ManualResourcePlanningView>("","#bfd38ee2-c53b-4d2b-9c64-3fcbb4b61b4b .ag-row[role='row']@ROWINDEX [col-id='cQualification']","",false, this.CurrentView);
 
            Situation = RPSControlFactory.CreateRPSGridTextBox<ManualResourcePlanningView>("","#bfd38ee2-c53b-4d2b-9c64-3fcbb4b61b4b .ag-row[role='row']@ROWINDEX [col-id='cSituation']","",false, this.CurrentView);
 
            LowestPredecessorStartDate = RPSControlFactory.CreateRPSGridTextBox<ManualResourcePlanningView>("","#bfd38ee2-c53b-4d2b-9c64-3fcbb4b61b4b .ag-row[role='row']@ROWINDEX [col-id='cLowestPredecessorStartDate']","",false, this.CurrentView);
 
            HighestPredecessorEndDate = RPSControlFactory.CreateRPSGridTextBox<ManualResourcePlanningView>("","#bfd38ee2-c53b-4d2b-9c64-3fcbb4b61b4b .ag-row[role='row']@ROWINDEX [col-id='cHighestPredecessorEndDate']","",false, this.CurrentView);
 
            TaskOptimizationFeature = RPSControlFactory.CreateRPSGridTextBox<ManualResourcePlanningView>("","#bfd38ee2-c53b-4d2b-9c64-3fcbb4b61b4b .ag-row[role='row']@ROWINDEX [col-id='cTaskOptimizationFeature']","",false, this.CurrentView);
 
            GroupingNumber = RPSControlFactory.CreateRPSGridTextBox<ManualResourcePlanningView>("","#bfd38ee2-c53b-4d2b-9c64-3fcbb4b61b4b .ag-row[role='row']@ROWINDEX [col-id='cGroupingNumber']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ManualResourcePlanningView> EntityType { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningView> DeliveryDate { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningView> Quantity { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningView> Duration { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningView> Priority { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningView> InternalCode { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningView> Qualification { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningView> Situation { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningView> LowestPredecessorStartDate { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningView> HighestPredecessorEndDate { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningView> TaskOptimizationFeature { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningView> GroupingNumber { get; set; } 
                     
    }
 
        public partial class PlannedTasksFromResourceCollectionCollectionEditor<ManualResourcePlanningView,ChangePlannedResourceToNewResourceDV>:RPSCollectionEditor<ManualResourcePlanningView,ChangePlannedResourceToNewResourceDV> where ManualResourcePlanningView : class, IView where ChangePlannedResourceToNewResourceDV : class, IView
    {
        public  PlannedTasksFromResourceCollectionGridView<ManualResourcePlanningView,ChangePlannedResourceToNewResourceDV> GridView {get;set;}
    }
    public partial class PlannedTasksFromResourceCollectionGridView <ManualResourcePlanningView,ChangePlannedResourceToNewResourceDV> :  RPSGridView<ManualResourcePlanningView,ChangePlannedResourceToNewResourceDV> where ManualResourcePlanningView : class, IView where ChangePlannedResourceToNewResourceDV : class, IView
    {
        public PlannedTasksFromResourceCollectionGridView(ManualResourcePlanningView currentView,ChangePlannedResourceToNewResourceDV newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NextOrder = RPSControlFactory.CreateRPSGridFormattedTextBox<ManualResourcePlanningView>("","#7692a024-9ddf-4bdf-8b3d-b8b5c611fec6 .ag-row[role='row']@ROWINDEX [col-id='cNextOrder']","",false, this.CurrentView);
 
            IsFixed = RPSControlFactory.CreateRPSGridCheckBox<ManualResourcePlanningView>("","#7692a024-9ddf-4bdf-8b3d-b8b5c611fec6 .ag-row[role='row']@ROWINDEX [col-id='cIsFixed']","",false, this.CurrentView);
 
            StartDate = RPSControlFactory.CreateRPSGridTextBox<ManualResourcePlanningView>("","#7692a024-9ddf-4bdf-8b3d-b8b5c611fec6 .ag-row[role='row']@ROWINDEX [col-id='cStartDate']","",false, this.CurrentView);
 
            FinalDate = RPSControlFactory.CreateRPSGridTextBox<ManualResourcePlanningView>("","#7692a024-9ddf-4bdf-8b3d-b8b5c611fec6 .ag-row[role='row']@ROWINDEX [col-id='cFinalDate']","",false, this.CurrentView);
 
            Dedication = RPSControlFactory.CreateRPSGridFormattedTextBox<ManualResourcePlanningView>("","#7692a024-9ddf-4bdf-8b3d-b8b5c611fec6 .ag-row[role='row']@ROWINDEX [col-id='cDedication']","",false, this.CurrentView);
 
            Priority = RPSControlFactory.CreateRPSGridFormattedTextBox<ManualResourcePlanningView>("","#7692a024-9ddf-4bdf-8b3d-b8b5c611fec6 .ag-row[role='row']@ROWINDEX [col-id='cPriority']","",false, this.CurrentView);
 
            InternalCode = RPSControlFactory.CreateRPSGridTextBox<ManualResourcePlanningView>("","#7692a024-9ddf-4bdf-8b3d-b8b5c611fec6 .ag-row[role='row']@ROWINDEX [col-id='cInternalCode']","",false, this.CurrentView);
 
            Duration = RPSControlFactory.CreateRPSGridFormattedTextBox<ManualResourcePlanningView>("","#7692a024-9ddf-4bdf-8b3d-b8b5c611fec6 .ag-row[role='row']@ROWINDEX [col-id='cDuration']","",false, this.CurrentView);
 
            DeliveryDate = RPSControlFactory.CreateRPSGridTextBox<ManualResourcePlanningView>("","#7692a024-9ddf-4bdf-8b3d-b8b5c611fec6 .ag-row[role='row']@ROWINDEX [col-id='cDeliveryDate']","",false, this.CurrentView);
 
            Qualify = RPSControlFactory.CreateRPSGridTextBox<ManualResourcePlanningView>("","#7692a024-9ddf-4bdf-8b3d-b8b5c611fec6 .ag-row[role='row']@ROWINDEX [col-id='cQualify']","",false, this.CurrentView);
 
            Situation = RPSControlFactory.CreateRPSGridTextBox<ManualResourcePlanningView>("","#7692a024-9ddf-4bdf-8b3d-b8b5c611fec6 .ag-row[role='row']@ROWINDEX [col-id='cSituation']","",false, this.CurrentView);
 
            LowestPredecessorStartDate = RPSControlFactory.CreateRPSGridTextBox<ManualResourcePlanningView>("","#7692a024-9ddf-4bdf-8b3d-b8b5c611fec6 .ag-row[role='row']@ROWINDEX [col-id='cLowestPredecessorStartDate']","",false, this.CurrentView);
 
            HighestPredecessorEndDate = RPSControlFactory.CreateRPSGridTextBox<ManualResourcePlanningView>("","#7692a024-9ddf-4bdf-8b3d-b8b5c611fec6 .ag-row[role='row']@ROWINDEX [col-id='cHighestPredecessorEndDate']","",false, this.CurrentView);
 
            TaskOptimizationFeature = RPSControlFactory.CreateRPSGridTextBox<ManualResourcePlanningView>("","#7692a024-9ddf-4bdf-8b3d-b8b5c611fec6 .ag-row[role='row']@ROWINDEX [col-id='cTaskOptimizationFeature']","",false, this.CurrentView);
 
            GroupingNumber = RPSControlFactory.CreateRPSGridTextBox<ManualResourcePlanningView>("","#7692a024-9ddf-4bdf-8b3d-b8b5c611fec6 .ag-row[role='row']@ROWINDEX [col-id='cGroupingNumber']","",false, this.CurrentView);
 
            EntityQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<ManualResourcePlanningView>("","#7692a024-9ddf-4bdf-8b3d-b8b5c611fec6 .ag-row[role='row']@ROWINDEX [col-id='cEntityQuantity']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ManualResourcePlanningView> NextOrder { get; set; } 
        public IRPSGridCheckbox<ManualResourcePlanningView> IsFixed { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningView> StartDate { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningView> FinalDate { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningView> Dedication { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningView> Priority { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningView> InternalCode { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningView> Duration { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningView> DeliveryDate { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningView> Qualify { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningView> Situation { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningView> LowestPredecessorStartDate { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningView> HighestPredecessorEndDate { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningView> TaskOptimizationFeature { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningView> GroupingNumber { get; set; } 
        public IRPSGridTextBox<ManualResourcePlanningView> EntityQuantity { get; set; } 
                     
    }
 
    }
  
            
    public partial class ChangePlannedResourceToNewResourceDV : View
    {
        public ChangePlannedResourceToNewResourceDV(ManualResourcePlanning screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            FromResource = RPSControlFactory.CreateRPSTextBox<ChangePlannedResourceToNewResourceDV>("1d362315-5ec9-48c5-b840-30c05ce6748f","","",false, this);
 
            ToResource = RPSControlFactory.CreateRPSEnumComboBox<ChangePlannedResourceToNewResourceDV>("7bb31d74-da27-4001-a220-0ba3682b60b6","","",false, this);
 
            ApplyChangesButton = RPSControlFactory.CreateRPSButton<ChangePlannedResourceToNewResourceDV>( "f02e6aa3-5fc8-4660-9945-d0eba4004180","","",this);
 

        }
        public IRPSTextBox<ChangePlannedResourceToNewResourceDV> FromResource { get; set; } 
        public IRPSComboBox<ChangePlannedResourceToNewResourceDV> ToResource { get; set; } 
        public IRPSButton<ChangePlannedResourceToNewResourceDV> ApplyChangesButton { get; set; } 
        public ManualResourcePlanning Screen { get; set; }
        public ChangePlannedResourceToNewResourceDV Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}