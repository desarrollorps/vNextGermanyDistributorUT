    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.MaintenanceWarningType
{
    //RPS VERSION 1.0.0.0
    public partial class MaintenanceWarningType:Screen
    {
        public MaintenanceWarningType():base()
        {
            this.URL = "maintenance.maintenancewarningtype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MaintenanceWarningTypeCollectionView  = new MaintenanceWarningTypeCollectionView(this); 
            MaintenanceWarningTypeEntityView  = new MaintenanceWarningTypeEntityView(this); 
            MaintenanceWarningTypeCollectionView.InitializeControls(); 
            MaintenanceWarningTypeEntityView.InitializeControls(); 
           
        }
      
            public MaintenanceWarningTypeCollectionView MaintenanceWarningTypeCollectionView {get; set; } 
            public MaintenanceWarningTypeEntityView MaintenanceWarningTypeEntityView {get; set; } 
    }
            
    public partial class MaintenanceWarningTypeCollectionView : View
    {
        public MaintenanceWarningTypeCollectionView(MaintenanceWarningType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<MaintenanceWarningTypeCollectionView,MaintenanceWarningTypeEntityView>( this,Screen.MaintenanceWarningTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "1ea5c4fd-d070-4871-903a-f8933397e45a",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<MaintenanceWarningTypeCollectionView,MaintenanceWarningTypeEntityView>( params_MainConsult,this,Screen.MaintenanceWarningTypeEntityView);
 

        }
        public IRPSButton<MaintenanceWarningTypeCollectionView,MaintenanceWarningTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<MaintenanceWarningTypeCollectionView,MaintenanceWarningTypeEntityView> MainConsult { get; set; } 
        public MaintenanceWarningType Screen { get; set; }
        public MaintenanceWarningTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenanceWarningTypeEntityView : View
    {
        public MaintenanceWarningTypeEntityView(MaintenanceWarningType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MaintenanceWarningTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceWarningTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceWarningTypeEntityView,MaintenanceWarningTypeCollectionView>( this,Screen.MaintenanceWarningTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceWarningTypeEntityView,MaintenanceWarningTypeCollectionView>( this,Screen.MaintenanceWarningTypeCollectionView);
 
            CodMaintenanceWarningType = RPSControlFactory.CreateRPSTextBox<MaintenanceWarningTypeEntityView>("726c52eb-27d2-4bb7-bbbc-a27e1923c0f3","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MaintenanceWarningTypeEntityView>("084fda61-b812-42e9-9a02-b31a57c7cd4f","","",false, this);
 

        }
        public IRPSSaveButton<MaintenanceWarningTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<MaintenanceWarningTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceWarningTypeEntityView,MaintenanceWarningTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceWarningTypeEntityView,MaintenanceWarningTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<MaintenanceWarningTypeEntityView> CodMaintenanceWarningType { get; set; } 
        public IRPSTextBox<MaintenanceWarningTypeEntityView> Description { get; set; } 
        public MaintenanceWarningType Screen { get; set; }
        public MaintenanceWarningTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}