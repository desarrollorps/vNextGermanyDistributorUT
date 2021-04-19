    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.MaintenanceWarningPriority
{
    //RPS VERSION 1.0.0.0
    public partial class MaintenanceWarningPriority:Screen
    {
        public MaintenanceWarningPriority():base()
        {
            this.URL = "maintenance.maintenancewarningpriority";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MaintenanceWarningPriorityCollectionView  = new MaintenanceWarningPriorityCollectionView(this); 
            MaintenanceWarningPriorityEntityView  = new MaintenanceWarningPriorityEntityView(this); 
            MaintenanceWarningPriorityCollectionView.InitializeControls(); 
            MaintenanceWarningPriorityEntityView.InitializeControls(); 
           
        }
      
            public MaintenanceWarningPriorityCollectionView MaintenanceWarningPriorityCollectionView {get; set; } 
            public MaintenanceWarningPriorityEntityView MaintenanceWarningPriorityEntityView {get; set; } 
    }
            
    public partial class MaintenanceWarningPriorityCollectionView : View
    {
        public MaintenanceWarningPriorityCollectionView(MaintenanceWarningPriority screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<MaintenanceWarningPriorityCollectionView,MaintenanceWarningPriorityEntityView>( this,Screen.MaintenanceWarningPriorityEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "c4b44945-783a-44ff-9156-7fde55fd00ec",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<MaintenanceWarningPriorityCollectionView,MaintenanceWarningPriorityEntityView>( params_MainConsult,this,Screen.MaintenanceWarningPriorityEntityView);
 

        }
        public IRPSButton<MaintenanceWarningPriorityCollectionView,MaintenanceWarningPriorityEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<MaintenanceWarningPriorityCollectionView,MaintenanceWarningPriorityEntityView> MainConsult { get; set; } 
        public MaintenanceWarningPriority Screen { get; set; }
        public MaintenanceWarningPriorityCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenanceWarningPriorityEntityView : View
    {
        public MaintenanceWarningPriorityEntityView(MaintenanceWarningPriority screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MaintenanceWarningPriorityEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceWarningPriorityEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceWarningPriorityEntityView,MaintenanceWarningPriorityCollectionView>( this,Screen.MaintenanceWarningPriorityCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceWarningPriorityEntityView,MaintenanceWarningPriorityCollectionView>( this,Screen.MaintenanceWarningPriorityCollectionView);
 
            NumMaintenanceWarningPriority = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceWarningPriorityEntityView>("808d4375-bf67-4444-8abb-a0e023567072","","",true, this);
 
            Descriptiion = RPSControlFactory.CreateRPSTextBox<MaintenanceWarningPriorityEntityView>("5baef591-4820-4727-bbd8-9feb7fb4317a","","",false, this);
 

        }
        public IRPSSaveButton<MaintenanceWarningPriorityEntityView> SaveButton { get; set; } 
        public IRPSButton<MaintenanceWarningPriorityEntityView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceWarningPriorityEntityView,MaintenanceWarningPriorityCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceWarningPriorityEntityView,MaintenanceWarningPriorityCollectionView> BackButton { get; set; } 
        public IRPSTextBox<MaintenanceWarningPriorityEntityView> NumMaintenanceWarningPriority { get; set; } 
        public IRPSTextBox<MaintenanceWarningPriorityEntityView> Descriptiion { get; set; } 
        public MaintenanceWarningPriority Screen { get; set; }
        public MaintenanceWarningPriorityEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}