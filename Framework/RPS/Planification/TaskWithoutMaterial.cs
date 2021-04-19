    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Planification.TaskWithoutMaterial
{
    //RPS VERSION 1.0.0.0
    public partial class TaskWithoutMaterial:Screen
    {
        public TaskWithoutMaterial():base()
        {
            this.URL = "planification.taskwithoutmaterial";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            TaskWithoutMaterialQueryView  = new TaskWithoutMaterialQueryView(this); 
            TaskWMOrderReserveDialogView  = new TaskWMOrderReserveDialogView(this); 
            TaskWithoutMaterialOriginOrderReserveDialogView  = new TaskWithoutMaterialOriginOrderReserveDialogView(this); 
            TaskWithoutMaterialQueryView.InitializeControls(); 
            TaskWMOrderReserveDialogView.InitializeControls(); 
            TaskWithoutMaterialOriginOrderReserveDialogView.InitializeControls(); 
           
        }
      
            public TaskWithoutMaterialQueryView TaskWithoutMaterialQueryView {get; set; } 
            public TaskWMOrderReserveDialogView TaskWMOrderReserveDialogView {get; set; } 
            public TaskWithoutMaterialOriginOrderReserveDialogView TaskWithoutMaterialOriginOrderReserveDialogView {get; set; } 
    }
            
    public partial class TaskWithoutMaterialQueryView : View
    {
        public TaskWithoutMaterialQueryView(TaskWithoutMaterial screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<TaskWithoutMaterialQueryView>("a79cbe11-4324-4252-a9be-975459d27930","","",true, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<TaskWithoutMaterialQueryView>("cbd73d25-1277-48e5-9c05-3c1c10c2e178","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<TaskWithoutMaterialQueryView>("03d99022-fad9-404d-b5d9-1eff6c88cad1","","",false, this);
 
            WithoutStock = RPSControlFactory.CreateRPSOption<TaskWithoutMaterialQueryView>( "e9f6f0bb-dc64-4203-8999-3c133a7667f6","","",this);
 
            All = RPSControlFactory.CreateRPSOption<TaskWithoutMaterialQueryView>( "8339a538-b380-4e4c-8e87-33549d2633f1","","",this);
 
            CheckManufacturingOrder = RPSControlFactory.CreateRPSCheckBox<TaskWithoutMaterialQueryView>("4d56cee8-1c9e-432a-9c99-fe7c0e005eb6","","",false, this);
 
            CheckProject = RPSControlFactory.CreateRPSCheckBox<TaskWithoutMaterialQueryView>("f264dfbd-ca49-4518-85d4-b11af708172b","","",false, this);
 
            CheckMaintenanceOrder = RPSControlFactory.CreateRPSCheckBox<TaskWithoutMaterialQueryView>("7346cbee-2307-4401-9ec3-f7e7a297daf8","","",false, this);
 
            ManufacturingOrderSituation = RPSControlFactory.CreateRPSCollectionComboBox<TaskWithoutMaterialQueryView>("8e677379-6d3c-4489-8cdf-01e7ef0d114e","","",false, this);
 
            LinkNavigationCommandToAvailabilityButton = RPSControlFactory.CreateRPSButton<TaskWithoutMaterialQueryView>( "2934df51-96f0-44d1-8c24-082dd645699b","","",this);
 
            CollectionInit params_TaskWithoutMaterial = new CollectionInit(){IDDescriptor = "86fd4f75-b26b-4a77-b6d0-c1db3c57a731",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c9dff64d-029d-4305-836b-65332bf4fe12",CSSSelectorGrid="",XPathGrid=""};
            TaskWithoutMaterial = RPSControlFactory.RPSCreateCollectionWithGrid<TaskWithoutMaterialCollectionEditor<TaskWithoutMaterialQueryView>,TaskWithoutMaterialQueryView>( params_TaskWithoutMaterial,this);
 
            CollectionInit params_TaskWithoutMaterialOrigin = new CollectionInit(){IDDescriptor = "86fd4f75-b26b-4a77-b6d0-c1db3c57a731",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5636bdea-a736-44f0-b8c0-8f895f8de320",CSSSelectorGrid="",XPathGrid=""};
            TaskWithoutMaterialOrigin = RPSControlFactory.RPSCreateCollectionWithGrid<TaskWithoutMaterialOriginCollectionEditor<TaskWithoutMaterialQueryView>,TaskWithoutMaterialQueryView>( params_TaskWithoutMaterialOrigin,this);
 

        }
        public IRPSComboBox<TaskWithoutMaterialQueryView> Site { get; set; } 
        public IRPSTextBox<TaskWithoutMaterialQueryView> DateFrom { get; set; } 
        public IRPSTextBox<TaskWithoutMaterialQueryView> DateTo { get; set; } 
        public IRPSOption<TaskWithoutMaterialQueryView> WithoutStock { get; set; } 
        public IRPSOption<TaskWithoutMaterialQueryView> All { get; set; } 
        public IRPSCheckbox<TaskWithoutMaterialQueryView> CheckManufacturingOrder { get; set; } 
        public IRPSCheckbox<TaskWithoutMaterialQueryView> CheckProject { get; set; } 
        public IRPSCheckbox<TaskWithoutMaterialQueryView> CheckMaintenanceOrder { get; set; } 
        public IRPSCollectionComboBox<TaskWithoutMaterialQueryView> ManufacturingOrderSituation { get; set; } 
        public IRPSButton<TaskWithoutMaterialQueryView> LinkNavigationCommandToAvailabilityButton { get; set; } 
        public TaskWithoutMaterialCollectionEditor<TaskWithoutMaterialQueryView> TaskWithoutMaterial { get; set; } 
        public TaskWithoutMaterialOriginCollectionEditor<TaskWithoutMaterialQueryView> TaskWithoutMaterialOrigin { get; set; } 
        public TaskWithoutMaterial Screen { get; set; }
        public TaskWithoutMaterialQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class TaskWithoutMaterialCollectionEditor<TaskWithoutMaterialQueryView>:RPSCollectionEditor<TaskWithoutMaterialQueryView> where TaskWithoutMaterialQueryView : class, IView
    {
        public  TaskWithoutMaterialGridView<TaskWithoutMaterialQueryView> GridView {get;set;}
    }
    public partial class TaskWithoutMaterialGridView <TaskWithoutMaterialQueryView> :  RPSGridView<TaskWithoutMaterialQueryView> where TaskWithoutMaterialQueryView : class, IView
    {
        public TaskWithoutMaterialGridView(TaskWithoutMaterialQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            NeededQuantityInPeriod = RPSControlFactory.CreateRPSGridFormattedTextBox<TaskWithoutMaterialQueryView>("","#c9dff64d-029d-4305-836b-65332bf4fe12 .ag-row[role='row']@ROWINDEX [col-id='cNeededQuantityInPeriod']","",false, this.CurrentView);
 
            Stock = RPSControlFactory.CreateRPSGridFormattedTextBox<TaskWithoutMaterialQueryView>("","#c9dff64d-029d-4305-836b-65332bf4fe12 .ag-row[role='row']@ROWINDEX [col-id='cStock']","",false, this.CurrentView);
 
            OrderQuantityToDate = RPSControlFactory.CreateRPSGridFormattedTextBox<TaskWithoutMaterialQueryView>("","#c9dff64d-029d-4305-836b-65332bf4fe12 .ag-row[role='row']@ROWINDEX [col-id='cOrderQuantityToDate']","",false, this.CurrentView);
 
            ReserveQuantityToDate = RPSControlFactory.CreateRPSGridFormattedTextBox<TaskWithoutMaterialQueryView>("","#c9dff64d-029d-4305-836b-65332bf4fe12 .ag-row[role='row']@ROWINDEX [col-id='cReserveQuantityToDate']","",false, this.CurrentView);
 
            AvailableQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<TaskWithoutMaterialQueryView>("","#c9dff64d-029d-4305-836b-65332bf4fe12 .ag-row[role='row']@ROWINDEX [col-id='cAvailableQuantity']","",false, this.CurrentView);
 
            OrderReserveCommand = RPSControlFactory.CreateRPSGridButton<TaskWithoutMaterialQueryView>( "","#c9dff64d-029d-4305-836b-65332bf4fe12 .ag-row[role='row']@ROWINDEX [col-id='cOrderReserveCommand']","",this.CurrentView);
 

        }
        public IRPSGridTextBox<TaskWithoutMaterialQueryView> NeededQuantityInPeriod { get; set; } 
        public IRPSGridTextBox<TaskWithoutMaterialQueryView> Stock { get; set; } 
        public IRPSGridTextBox<TaskWithoutMaterialQueryView> OrderQuantityToDate { get; set; } 
        public IRPSGridTextBox<TaskWithoutMaterialQueryView> ReserveQuantityToDate { get; set; } 
        public IRPSGridTextBox<TaskWithoutMaterialQueryView> AvailableQuantity { get; set; } 
        public IRPSGridButton<TaskWithoutMaterialQueryView> OrderReserveCommand { get; set; } 
                     
    }
 
        public partial class TaskWithoutMaterialOriginCollectionEditor<TaskWithoutMaterialQueryView>:RPSCollectionEditor<TaskWithoutMaterialQueryView> where TaskWithoutMaterialQueryView : class, IView
    {
        public  TaskWithoutMaterialOriginGridView<TaskWithoutMaterialQueryView> GridView {get;set;}
    }
    public partial class TaskWithoutMaterialOriginGridView <TaskWithoutMaterialQueryView> :  RPSGridView<TaskWithoutMaterialQueryView> where TaskWithoutMaterialQueryView : class, IView
    {
        public TaskWithoutMaterialOriginGridView(TaskWithoutMaterialQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            StartDate = RPSControlFactory.CreateRPSGridTextBox<TaskWithoutMaterialQueryView>("","#5636bdea-a736-44f0-b8c0-8f895f8de320 .ag-row[role='row']@ROWINDEX [col-id='cStartDate']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<TaskWithoutMaterialQueryView>("","#5636bdea-a736-44f0-b8c0-8f895f8de320 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            OrderQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<TaskWithoutMaterialQueryView>("","#5636bdea-a736-44f0-b8c0-8f895f8de320 .ag-row[role='row']@ROWINDEX [col-id='cOrderQuantity']","",false, this.CurrentView);
 
            OtherReserves = RPSControlFactory.CreateRPSGridFormattedTextBox<TaskWithoutMaterialQueryView>("","#5636bdea-a736-44f0-b8c0-8f895f8de320 .ag-row[role='row']@ROWINDEX [col-id='cOtherReserves']","",false, this.CurrentView);
 
            OrderReserveCommand = RPSControlFactory.CreateRPSGridButton<TaskWithoutMaterialQueryView>( "","#5636bdea-a736-44f0-b8c0-8f895f8de320 .ag-row[role='row']@ROWINDEX [col-id='cOrderReserveCommand']","",this.CurrentView);
 

        }
        public IRPSGridTextBox<TaskWithoutMaterialQueryView> StartDate { get; set; } 
        public IRPSGridTextBox<TaskWithoutMaterialQueryView> Quantity { get; set; } 
        public IRPSGridTextBox<TaskWithoutMaterialQueryView> OrderQuantity { get; set; } 
        public IRPSGridTextBox<TaskWithoutMaterialQueryView> OtherReserves { get; set; } 
        public IRPSGridButton<TaskWithoutMaterialQueryView> OrderReserveCommand { get; set; } 
                     
    }
 
    }
  
            
    public partial class TaskWMOrderReserveDialogView : View
    {
        public TaskWMOrderReserveDialogView(TaskWithoutMaterial screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ParentCommand = RPSControlFactory.CreateRPSButton<TaskWMOrderReserveDialogView>( "48ba2efe-72c3-4a70-a38f-0d0213bc219c","","",this);
 
            CollectionInit params_TaskWithoutMaterialOrderReserves = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="e525c3a3-0513-4fda-9488-146c1b3da90d",CSSSelectorGrid="",XPathGrid=""};
            TaskWithoutMaterialOrderReserves = RPSControlFactory.RPSCreateCollectionWithGrid<TaskWithoutMaterialOrderReservesCollectionEditor<TaskWMOrderReserveDialogView>,TaskWMOrderReserveDialogView>( params_TaskWithoutMaterialOrderReserves,this);
 

        }
        public IRPSButton<TaskWMOrderReserveDialogView> ParentCommand { get; set; } 
        public TaskWithoutMaterialOrderReservesCollectionEditor<TaskWMOrderReserveDialogView> TaskWithoutMaterialOrderReserves { get; set; } 
        public TaskWithoutMaterial Screen { get; set; }
        public TaskWMOrderReserveDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class TaskWithoutMaterialOrderReservesCollectionEditor<TaskWMOrderReserveDialogView>:RPSCollectionEditor<TaskWMOrderReserveDialogView> where TaskWMOrderReserveDialogView : class, IView
    {
        public  TaskWithoutMaterialOrderReservesGridView<TaskWMOrderReserveDialogView> GridView {get;set;}
    }
    public partial class TaskWithoutMaterialOrderReservesGridView <TaskWMOrderReserveDialogView> :  RPSGridView<TaskWMOrderReserveDialogView> where TaskWMOrderReserveDialogView : class, IView
    {
        public TaskWithoutMaterialOrderReservesGridView(TaskWMOrderReserveDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Type = RPSControlFactory.CreateRPSGridTextBox<TaskWMOrderReserveDialogView>("","#e525c3a3-0513-4fda-9488-146c1b3da90d .ag-row[role='row']@ROWINDEX [col-id='cType']","",false, this.CurrentView);
 
            OrderDate = RPSControlFactory.CreateRPSGridTextBox<TaskWMOrderReserveDialogView>("","#e525c3a3-0513-4fda-9488-146c1b3da90d .ag-row[role='row']@ROWINDEX [col-id='cOrderDate']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<TaskWMOrderReserveDialogView>("","#e525c3a3-0513-4fda-9488-146c1b3da90d .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<TaskWMOrderReserveDialogView> Type { get; set; } 
        public IRPSGridTextBox<TaskWMOrderReserveDialogView> OrderDate { get; set; } 
        public IRPSGridTextBox<TaskWMOrderReserveDialogView> Quantity { get; set; } 
                     
    }
 
    }
  
            
    public partial class TaskWithoutMaterialOriginOrderReserveDialogView : View
    {
        public TaskWithoutMaterialOriginOrderReserveDialogView(TaskWithoutMaterial screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ParentCommand = RPSControlFactory.CreateRPSButton<TaskWithoutMaterialOriginOrderReserveDialogView>( "743bd5a5-f55f-4eb6-ac5b-1a8b29be1e25","","",this);
 
            CollectionInit params_TaskWithoutMaterialOriginOrderReserves = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8e5f1644-0d5d-43c5-aee9-cbf71564511e",CSSSelectorGrid="",XPathGrid=""};
            TaskWithoutMaterialOriginOrderReserves = RPSControlFactory.RPSCreateCollectionWithGrid<TaskWithoutMaterialOriginOrderReservesCollectionEditor<TaskWithoutMaterialOriginOrderReserveDialogView,TaskWMOrderReserveDialogView>,TaskWithoutMaterialOriginOrderReserveDialogView,TaskWMOrderReserveDialogView>( params_TaskWithoutMaterialOriginOrderReserves,this,Screen.TaskWMOrderReserveDialogView);
 

        }
        public IRPSButton<TaskWithoutMaterialOriginOrderReserveDialogView> ParentCommand { get; set; } 
        public TaskWithoutMaterialOriginOrderReservesCollectionEditor<TaskWithoutMaterialOriginOrderReserveDialogView,TaskWMOrderReserveDialogView> TaskWithoutMaterialOriginOrderReserves { get; set; } 
        public TaskWithoutMaterial Screen { get; set; }
        public TaskWithoutMaterialOriginOrderReserveDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class TaskWithoutMaterialOriginOrderReservesCollectionEditor<TaskWithoutMaterialOriginOrderReserveDialogView,TaskWMOrderReserveDialogView>:RPSCollectionEditor<TaskWithoutMaterialOriginOrderReserveDialogView,TaskWMOrderReserveDialogView> where TaskWithoutMaterialOriginOrderReserveDialogView : class, IView where TaskWMOrderReserveDialogView : class, IView
    {
        public  TaskWithoutMaterialOriginOrderReservesGridView<TaskWithoutMaterialOriginOrderReserveDialogView,TaskWMOrderReserveDialogView> GridView {get;set;}
    }
    public partial class TaskWithoutMaterialOriginOrderReservesGridView <TaskWithoutMaterialOriginOrderReserveDialogView,TaskWMOrderReserveDialogView> :  RPSGridView<TaskWithoutMaterialOriginOrderReserveDialogView,TaskWMOrderReserveDialogView> where TaskWithoutMaterialOriginOrderReserveDialogView : class, IView where TaskWMOrderReserveDialogView : class, IView
    {
        public TaskWithoutMaterialOriginOrderReservesGridView(TaskWithoutMaterialOriginOrderReserveDialogView currentView,TaskWMOrderReserveDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Type = RPSControlFactory.CreateRPSGridTextBox<TaskWithoutMaterialOriginOrderReserveDialogView>("","#8e5f1644-0d5d-43c5-aee9-cbf71564511e .ag-row[role='row']@ROWINDEX [col-id='cType']","",false, this.CurrentView);
 
            OrderDate = RPSControlFactory.CreateRPSGridTextBox<TaskWithoutMaterialOriginOrderReserveDialogView>("","#8e5f1644-0d5d-43c5-aee9-cbf71564511e .ag-row[role='row']@ROWINDEX [col-id='cOrderDate']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<TaskWithoutMaterialOriginOrderReserveDialogView>("","#8e5f1644-0d5d-43c5-aee9-cbf71564511e .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<TaskWithoutMaterialOriginOrderReserveDialogView> Type { get; set; } 
        public IRPSGridTextBox<TaskWithoutMaterialOriginOrderReserveDialogView> OrderDate { get; set; } 
        public IRPSGridTextBox<TaskWithoutMaterialOriginOrderReserveDialogView> Quantity { get; set; } 
                     
    }
 
    }
  
    

}