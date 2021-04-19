    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.MaintenanceProcedure
{
    //RPS VERSION 1.0.0.0
    public partial class MaintenanceProcedure:Screen
    {
        public MaintenanceProcedure():base()
        {
            this.URL = "maintenance.maintenanceprocedure";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MaintenanceProcedureCollectionView  = new MaintenanceProcedureCollectionView(this); 
            MaintenanceProcedureEntityView  = new MaintenanceProcedureEntityView(this); 
            MaintenanceProcTaskView  = new MaintenanceProcTaskView(this); 
            MaintenanceTaskOptionView  = new MaintenanceTaskOptionView(this); 
            MaintenanceProcedureCollectionView.InitializeControls(); 
            MaintenanceProcedureEntityView.InitializeControls(); 
            MaintenanceProcTaskView.InitializeControls(); 
            MaintenanceTaskOptionView.InitializeControls(); 
           
        }
      
            public MaintenanceProcedureCollectionView MaintenanceProcedureCollectionView {get; set; } 
            public MaintenanceProcedureEntityView MaintenanceProcedureEntityView {get; set; } 
            public MaintenanceProcTaskView MaintenanceProcTaskView {get; set; } 
            public MaintenanceTaskOptionView MaintenanceTaskOptionView {get; set; } 
    }
            
    public partial class MaintenanceProcedureCollectionView : View
    {
        public MaintenanceProcedureCollectionView(MaintenanceProcedure screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<MaintenanceProcedureCollectionView,MaintenanceProcedureEntityView>( this,Screen.MaintenanceProcedureEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "f039d948-0949-43f0-a3b6-a7e879edfea2",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<MaintenanceProcedureCollectionView,MaintenanceProcedureEntityView>( params_MainConsult,this,Screen.MaintenanceProcedureEntityView);
 

        }
        public IRPSButton<MaintenanceProcedureCollectionView,MaintenanceProcedureEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<MaintenanceProcedureCollectionView,MaintenanceProcedureEntityView> MainConsult { get; set; } 
        public MaintenanceProcedure Screen { get; set; }
        public MaintenanceProcedureCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenanceProcedureEntityView : View
    {
        public MaintenanceProcedureEntityView(MaintenanceProcedure screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MaintenanceProcedureEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceProcedureEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceProcedureEntityView,MaintenanceProcedureCollectionView>( this,Screen.MaintenanceProcedureCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceProcedureEntityView,MaintenanceProcedureCollectionView>( this,Screen.MaintenanceProcedureCollectionView);
 
            CodProcedure = RPSControlFactory.CreateRPSTextBox<MaintenanceProcedureEntityView>("a12313a6-763a-4690-beb4-206842f604b2","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MaintenanceProcedureEntityView>("1462f11a-3ce8-497f-a7ab-7d656f6530d4","","",false, this);
 
            IDMaintenanceType = RPSControlFactory.CreateRPSComboBox<MaintenanceProcedureEntityView>("5d92a2e8-e78c-4967-bdba-fb68478f920b","","",false, this);
 
            Status = RPSControlFactory.CreateRPSEnumComboBox<MaintenanceProcedureEntityView>("63867735-8e82-4da6-b06a-4220de6ca7df","","",true, this);
 
            CollectionInit params_MANMaintenanceProcTasks = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="bc66f228-5548-4db9-8e26-c993ea2d5326",CSSSelectorGrid="",XPathGrid=""};
            MANMaintenanceProcTasks = RPSControlFactory.RPSCreateCollectionWithGrid<MANMaintenanceProcTasksCollectionEditor<MaintenanceProcedureEntityView,MaintenanceProcTaskView>,MaintenanceProcedureEntityView,MaintenanceProcTaskView>( params_MANMaintenanceProcTasks,this,Screen.MaintenanceProcTaskView);
 
            Task = RPSControlFactory.CreateRPSSection<MaintenanceProcedureEntityView>( "","ul li[rpsid='2984b065-d3c3-484d-976d-81eaa5c68e00']","",this);
 

        }
        public IRPSSaveButton<MaintenanceProcedureEntityView> SaveButton { get; set; } 
        public IRPSButton<MaintenanceProcedureEntityView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceProcedureEntityView,MaintenanceProcedureCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceProcedureEntityView,MaintenanceProcedureCollectionView> BackButton { get; set; } 
        public IRPSTextBox<MaintenanceProcedureEntityView> CodProcedure { get; set; } 
        public IRPSTextBox<MaintenanceProcedureEntityView> Description { get; set; } 
        public IRPSComboBox<MaintenanceProcedureEntityView> IDMaintenanceType { get; set; } 
        public IRPSComboBox<MaintenanceProcedureEntityView> Status { get; set; } 
        public MANMaintenanceProcTasksCollectionEditor<MaintenanceProcedureEntityView,MaintenanceProcTaskView> MANMaintenanceProcTasks { get; set; } 
        public IRPSSection<MaintenanceProcedureEntityView> Task { get; set; } 
        public MaintenanceProcedure Screen { get; set; }
        public MaintenanceProcedureEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MANMaintenanceProcTasksCollectionEditor<MaintenanceProcedureEntityView,MaintenanceProcTaskView>:RPSCollectionEditor<MaintenanceProcedureEntityView,MaintenanceProcTaskView> where MaintenanceProcedureEntityView : class, IView where MaintenanceProcTaskView : class, IView
    {
        public  MANMaintenanceProcTasksGridView<MaintenanceProcedureEntityView,MaintenanceProcTaskView> GridView {get;set;}
    }
    public partial class MANMaintenanceProcTasksGridView <MaintenanceProcedureEntityView,MaintenanceProcTaskView> :  RPSGridView<MaintenanceProcedureEntityView,MaintenanceProcTaskView> where MaintenanceProcedureEntityView : class, IView where MaintenanceProcTaskView : class, IView
    {
        public MANMaintenanceProcTasksGridView(MaintenanceProcedureEntityView currentView,MaintenanceProcTaskView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodTask = RPSControlFactory.CreateRPSGridTextBox<MaintenanceProcedureEntityView>("","#bc66f228-5548-4db9-8e26-c993ea2d5326 .ag-row[role='row']@ROWINDEX [col-id='cCodTask']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<MaintenanceProcedureEntityView>("","#bc66f228-5548-4db9-8e26-c993ea2d5326 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            Duration = RPSControlFactory.CreateRPSGridDurationTextBox<MaintenanceProcedureEntityView>("","#bc66f228-5548-4db9-8e26-c993ea2d5326 .ag-row[role='row']@ROWINDEX [col-id='cDuration']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MaintenanceProcedureEntityView> CodTask { get; set; } 
        public IRPSGridTextBox<MaintenanceProcedureEntityView> Description { get; set; } 
        public IRPSGridDurationTextBox<MaintenanceProcedureEntityView> Duration { get; set; } 
                     
    }
 
    }
  
            
    public partial class MaintenanceProcTaskView : View
    {
        public MaintenanceProcTaskView(MaintenanceProcedure screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceProcTaskView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceProcTaskView,MaintenanceProcedureEntityView>( this,Screen.MaintenanceProcedureEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceProcTaskView,MaintenanceProcedureEntityView>( this,Screen.MaintenanceProcedureEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MaintenanceProcTaskView,MaintenanceProcedureEntityView>( this,Screen.MaintenanceProcedureEntityView);
 
            CodTask = RPSControlFactory.CreateRPSTextBox<MaintenanceProcTaskView>("5efc6b6a-138b-43fd-afc4-bc894e216086","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MaintenanceProcTaskView>("c40afa35-3fa1-4cbf-8adc-c69bc260b41a","","",false, this);
 
            Duration = RPSControlFactory.CreateRPSDurationTextBox<MaintenanceProcTaskView>("e2bd1ec2-6a29-48bb-a5aa-3a2923f6deb0","","",false, this);
 
            CollectionInit params_MANMaintenanceTaskOptions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0bd84d34-ddbf-4dee-84ff-42f773f44246",CSSSelectorGrid="",XPathGrid=""};
            MANMaintenanceTaskOptions = RPSControlFactory.RPSCreateCollectionWithGrid<MANMaintenanceTaskOptionsCollectionEditor<MaintenanceProcTaskView,MaintenanceTaskOptionView>,MaintenanceProcTaskView,MaintenanceTaskOptionView>( params_MANMaintenanceTaskOptions,this,Screen.MaintenanceTaskOptionView);
 
            TaskOption = RPSControlFactory.CreateRPSSection<MaintenanceProcTaskView>( "","ul li[rpsid='c847521c-7c1e-4988-ad47-4155f29cb857']","",this);
 

        }
        public IRPSButton<MaintenanceProcTaskView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceProcTaskView,MaintenanceProcedureEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceProcTaskView,MaintenanceProcedureEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<MaintenanceProcTaskView,MaintenanceProcedureEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<MaintenanceProcTaskView> CodTask { get; set; } 
        public IRPSTextBox<MaintenanceProcTaskView> Description { get; set; } 
        public IRPSDurationTextBox<MaintenanceProcTaskView> Duration { get; set; } 
        public MANMaintenanceTaskOptionsCollectionEditor<MaintenanceProcTaskView,MaintenanceTaskOptionView> MANMaintenanceTaskOptions { get; set; } 
        public IRPSSection<MaintenanceProcTaskView> TaskOption { get; set; } 
        public MaintenanceProcedure Screen { get; set; }
        public MaintenanceProcTaskView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MANMaintenanceTaskOptionsCollectionEditor<MaintenanceProcTaskView,MaintenanceTaskOptionView>:RPSCollectionEditor<MaintenanceProcTaskView,MaintenanceTaskOptionView> where MaintenanceProcTaskView : class, IView where MaintenanceTaskOptionView : class, IView
    {
        public  MANMaintenanceTaskOptionsGridView<MaintenanceProcTaskView,MaintenanceTaskOptionView> GridView {get;set;}
    }
    public partial class MANMaintenanceTaskOptionsGridView <MaintenanceProcTaskView,MaintenanceTaskOptionView> :  RPSGridView<MaintenanceProcTaskView,MaintenanceTaskOptionView> where MaintenanceProcTaskView : class, IView where MaintenanceTaskOptionView : class, IView
    {
        public MANMaintenanceTaskOptionsGridView(MaintenanceProcTaskView currentView,MaintenanceTaskOptionView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            TaskOption = RPSControlFactory.CreateRPSGridTextBox<MaintenanceProcTaskView>("","#0bd84d34-ddbf-4dee-84ff-42f773f44246 .ag-row[role='row']@ROWINDEX [col-id='cTaskOption']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<MaintenanceProcTaskView> TaskOption { get; set; } 
                     
    }
 
    }
  
            
    public partial class MaintenanceTaskOptionView : View
    {
        public MaintenanceTaskOptionView(MaintenanceProcedure screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceTaskOptionView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceTaskOptionView,MaintenanceProcTaskView>( this,Screen.MaintenanceProcTaskView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceTaskOptionView,MaintenanceProcTaskView>( this,Screen.MaintenanceProcTaskView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<MaintenanceTaskOptionView,MaintenanceProcTaskView>( this,Screen.MaintenanceProcTaskView);
 
            TaskOption = RPSControlFactory.CreateRPSTextBox<MaintenanceTaskOptionView>("34b47eb0-5130-4e55-9ee9-0ffd8bcdc455","","",true, this);
 

        }
        public IRPSButton<MaintenanceTaskOptionView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceTaskOptionView,MaintenanceProcTaskView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceTaskOptionView,MaintenanceProcTaskView> BackButton { get; set; } 
        public IRPSAcceptButton<MaintenanceTaskOptionView,MaintenanceProcTaskView> AcceptButton { get; set; } 
        public IRPSTextBox<MaintenanceTaskOptionView> TaskOption { get; set; } 
        public MaintenanceProcedure Screen { get; set; }
        public MaintenanceTaskOptionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}