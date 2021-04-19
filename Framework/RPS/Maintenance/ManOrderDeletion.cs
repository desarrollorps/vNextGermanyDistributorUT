    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.ManOrderDeletion
{
    //RPS VERSION 1.0.0.0
    public partial class ManOrderDeletion:Screen
    {
        public ManOrderDeletion():base()
        {
            this.URL = "maintenance.manorderdeletion";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ManOrderDeletionQueryView  = new ManOrderDeletionQueryView(this); 
            DeleteConfirmDialogDialogView  = new DeleteConfirmDialogDialogView(this); 
            ManOrderDeletionQueryView.InitializeControls(); 
            DeleteConfirmDialogDialogView.InitializeControls(); 
           
        }
      
            public ManOrderDeletionQueryView ManOrderDeletionQueryView {get; set; } 
            public DeleteConfirmDialogDialogView DeleteConfirmDialogDialogView {get; set; } 
    }
            
    public partial class ManOrderDeletionQueryView : View
    {
        public ManOrderDeletionQueryView(ManOrderDeletion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<ManOrderDeletionQueryView>("8d559176-3736-4dc8-b457-a698c645b907","","",false, this);
 
            MaintenanceOrder = RPSControlFactory.CreateRPSCollectionComboBox<ManOrderDeletionQueryView>("3f245832-cdb9-41f7-8d55-616250c33edf","","",false, this);
 
            MaintenancePlan = RPSControlFactory.CreateRPSCollectionComboBox<ManOrderDeletionQueryView>("e2ab18b3-2a81-44d6-a80f-ee158df6ee12","","",false, this);
 
            MaintenancePlanControl = RPSControlFactory.CreateRPSCollectionComboBox<ManOrderDeletionQueryView>("b687bca2-f78c-4802-8a7c-0e50239b7581","","",false, this);
 
            MaintenanceOrderDeleteCommandButton = RPSControlFactory.CreateRPSButton<ManOrderDeletionQueryView>( "9a875088-d556-4bb9-ab56-672ff19e2cdf","","",this);
 
            CollectionInit params_MaintenanceOrderForDelete = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="90d83366-83db-49df-9e4f-96755bef39f6",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceOrderForDelete = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceOrderForDeleteCollectionEditor<ManOrderDeletionQueryView,DeleteConfirmDialogDialogView>,ManOrderDeletionQueryView,DeleteConfirmDialogDialogView>( params_MaintenanceOrderForDelete,this,Screen.DeleteConfirmDialogDialogView);
 

        }
        public IRPSComboBox<ManOrderDeletionQueryView> Site { get; set; } 
        public IRPSCollectionComboBox<ManOrderDeletionQueryView> MaintenanceOrder { get; set; } 
        public IRPSCollectionComboBox<ManOrderDeletionQueryView> MaintenancePlan { get; set; } 
        public IRPSCollectionComboBox<ManOrderDeletionQueryView> MaintenancePlanControl { get; set; } 
        public IRPSButton<ManOrderDeletionQueryView> MaintenanceOrderDeleteCommandButton { get; set; } 
        public MaintenanceOrderForDeleteCollectionEditor<ManOrderDeletionQueryView,DeleteConfirmDialogDialogView> MaintenanceOrderForDelete { get; set; } 
        public ManOrderDeletion Screen { get; set; }
        public ManOrderDeletionQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaintenanceOrderForDeleteCollectionEditor<ManOrderDeletionQueryView,DeleteConfirmDialogDialogView>:RPSCollectionEditor<ManOrderDeletionQueryView,DeleteConfirmDialogDialogView> where ManOrderDeletionQueryView : class, IView where DeleteConfirmDialogDialogView : class, IView
    {
        public  MaintenanceOrderForDeleteGridView<ManOrderDeletionQueryView,DeleteConfirmDialogDialogView> GridView {get;set;}
    }
    public partial class MaintenanceOrderForDeleteGridView <ManOrderDeletionQueryView,DeleteConfirmDialogDialogView> :  RPSGridView<ManOrderDeletionQueryView,DeleteConfirmDialogDialogView> where ManOrderDeletionQueryView : class, IView where DeleteConfirmDialogDialogView : class, IView
    {
        public MaintenanceOrderForDeleteGridView(ManOrderDeletionQueryView currentView,DeleteConfirmDialogDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MaintenanceOrder_ExecutionDate = RPSControlFactory.CreateRPSGridTextBox<ManOrderDeletionQueryView>("","#90d83366-83db-49df-9e4f-96755bef39f6 .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceOrder_ExecutionDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ManOrderDeletionQueryView> MaintenanceOrder_ExecutionDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class DeleteConfirmDialogDialogView : View
    {
        public DeleteConfirmDialogDialogView(ManOrderDeletion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Msg = RPSControlFactory.CreateRPSTextBox<DeleteConfirmDialogDialogView>("5ce84efe-3d7f-4761-8acf-f307c121ead8","","",false, this);
 

        }
        public IRPSTextBox<DeleteConfirmDialogDialogView> Msg { get; set; } 
        public ManOrderDeletion Screen { get; set; }
        public DeleteConfirmDialogDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}