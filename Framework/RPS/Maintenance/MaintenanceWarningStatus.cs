    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.MaintenanceWarningStatus
{
    //RPS VERSION 1.0.0.0
    public partial class MaintenanceWarningStatus:Screen
    {
        public MaintenanceWarningStatus():base()
        {
            this.URL = "maintenance.maintenancewarningstatus";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MaintenanceWarningStatusCollectionView  = new MaintenanceWarningStatusCollectionView(this); 
            MaintenanceWarningStatusEntityView  = new MaintenanceWarningStatusEntityView(this); 
            MaintenanceWarningStatusCollectionView.InitializeControls(); 
            MaintenanceWarningStatusEntityView.InitializeControls(); 
           
        }
      
            public MaintenanceWarningStatusCollectionView MaintenanceWarningStatusCollectionView {get; set; } 
            public MaintenanceWarningStatusEntityView MaintenanceWarningStatusEntityView {get; set; } 
    }
            
    public partial class MaintenanceWarningStatusCollectionView : View
    {
        public MaintenanceWarningStatusCollectionView(MaintenanceWarningStatus screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<MaintenanceWarningStatusCollectionView,MaintenanceWarningStatusEntityView>( this,Screen.MaintenanceWarningStatusEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "b001b356-fcd4-4bc1-b3a7-9e3db43a2390",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<MaintenanceWarningStatusCollectionView,MaintenanceWarningStatusEntityView>( params_MainConsult,this,Screen.MaintenanceWarningStatusEntityView);
 

        }
        public IRPSButton<MaintenanceWarningStatusCollectionView,MaintenanceWarningStatusEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<MaintenanceWarningStatusCollectionView,MaintenanceWarningStatusEntityView> MainConsult { get; set; } 
        public MaintenanceWarningStatus Screen { get; set; }
        public MaintenanceWarningStatusCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenanceWarningStatusEntityView : View
    {
        public MaintenanceWarningStatusEntityView(MaintenanceWarningStatus screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MaintenanceWarningStatusEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceWarningStatusEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceWarningStatusEntityView,MaintenanceWarningStatusCollectionView>( this,Screen.MaintenanceWarningStatusCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceWarningStatusEntityView,MaintenanceWarningStatusCollectionView>( this,Screen.MaintenanceWarningStatusCollectionView);
 
            CodMaintenanceWarningStatus = RPSControlFactory.CreateRPSTextBox<MaintenanceWarningStatusEntityView>("a157305f-3bc1-45c9-986f-0ce73f1fced3","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MaintenanceWarningStatusEntityView>("0716a5bc-75e7-418f-a4e3-50e6d562f0b5","","",false, this);
 

        }
        public IRPSSaveButton<MaintenanceWarningStatusEntityView> SaveButton { get; set; } 
        public IRPSButton<MaintenanceWarningStatusEntityView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceWarningStatusEntityView,MaintenanceWarningStatusCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceWarningStatusEntityView,MaintenanceWarningStatusCollectionView> BackButton { get; set; } 
        public IRPSTextBox<MaintenanceWarningStatusEntityView> CodMaintenanceWarningStatus { get; set; } 
        public IRPSTextBox<MaintenanceWarningStatusEntityView> Description { get; set; } 
        public MaintenanceWarningStatus Screen { get; set; }
        public MaintenanceWarningStatusEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}