    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.MaintenanceWarningSeverity
{
    //RPS VERSION 1.0.0.0
    public partial class MaintenanceWarningSeverity:Screen
    {
        public MaintenanceWarningSeverity():base()
        {
            this.URL = "maintenance.maintenancewarningseverity";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MaintenanceWarningSeverityCollectionView  = new MaintenanceWarningSeverityCollectionView(this); 
            MaintenanceWarningSeverityEntityView  = new MaintenanceWarningSeverityEntityView(this); 
            MaintenanceWarningSeverityCollectionView.InitializeControls(); 
            MaintenanceWarningSeverityEntityView.InitializeControls(); 
           
        }
      
            public MaintenanceWarningSeverityCollectionView MaintenanceWarningSeverityCollectionView {get; set; } 
            public MaintenanceWarningSeverityEntityView MaintenanceWarningSeverityEntityView {get; set; } 
    }
            
    public partial class MaintenanceWarningSeverityCollectionView : View
    {
        public MaintenanceWarningSeverityCollectionView(MaintenanceWarningSeverity screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<MaintenanceWarningSeverityCollectionView,MaintenanceWarningSeverityEntityView>( this,Screen.MaintenanceWarningSeverityEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "a67a79ad-eca5-4168-a924-480035f57ebd",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<MaintenanceWarningSeverityCollectionView,MaintenanceWarningSeverityEntityView>( params_MainConsult,this,Screen.MaintenanceWarningSeverityEntityView);
 

        }
        public IRPSButton<MaintenanceWarningSeverityCollectionView,MaintenanceWarningSeverityEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<MaintenanceWarningSeverityCollectionView,MaintenanceWarningSeverityEntityView> MainConsult { get; set; } 
        public MaintenanceWarningSeverity Screen { get; set; }
        public MaintenanceWarningSeverityCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenanceWarningSeverityEntityView : View
    {
        public MaintenanceWarningSeverityEntityView(MaintenanceWarningSeverity screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MaintenanceWarningSeverityEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceWarningSeverityEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceWarningSeverityEntityView,MaintenanceWarningSeverityCollectionView>( this,Screen.MaintenanceWarningSeverityCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceWarningSeverityEntityView,MaintenanceWarningSeverityCollectionView>( this,Screen.MaintenanceWarningSeverityCollectionView);
 
            CodMaintenanceWarningSeverity = RPSControlFactory.CreateRPSTextBox<MaintenanceWarningSeverityEntityView>("41c96761-e16c-46f2-8319-d27ffb5930a2","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MaintenanceWarningSeverityEntityView>("2000755b-5b93-46d7-b6c2-f7763f97cd47","","",false, this);
 

        }
        public IRPSSaveButton<MaintenanceWarningSeverityEntityView> SaveButton { get; set; } 
        public IRPSButton<MaintenanceWarningSeverityEntityView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceWarningSeverityEntityView,MaintenanceWarningSeverityCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceWarningSeverityEntityView,MaintenanceWarningSeverityCollectionView> BackButton { get; set; } 
        public IRPSTextBox<MaintenanceWarningSeverityEntityView> CodMaintenanceWarningSeverity { get; set; } 
        public IRPSTextBox<MaintenanceWarningSeverityEntityView> Description { get; set; } 
        public MaintenanceWarningSeverity Screen { get; set; }
        public MaintenanceWarningSeverityEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}