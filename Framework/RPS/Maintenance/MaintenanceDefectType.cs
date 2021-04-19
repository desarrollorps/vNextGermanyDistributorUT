    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.MaintenanceDefectType
{
    //RPS VERSION 1.0.0.0
    public partial class MaintenanceDefectType:Screen
    {
        public MaintenanceDefectType():base()
        {
            this.URL = "maintenance.maintenancedefecttype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MaintenanceDefectTypeCollectionView  = new MaintenanceDefectTypeCollectionView(this); 
            MaintenanceDefectTypeEntityView  = new MaintenanceDefectTypeEntityView(this); 
            MaintenanceDefectTypeCollectionView.InitializeControls(); 
            MaintenanceDefectTypeEntityView.InitializeControls(); 
           
        }
      
            public MaintenanceDefectTypeCollectionView MaintenanceDefectTypeCollectionView {get; set; } 
            public MaintenanceDefectTypeEntityView MaintenanceDefectTypeEntityView {get; set; } 
    }
            
    public partial class MaintenanceDefectTypeCollectionView : View
    {
        public MaintenanceDefectTypeCollectionView(MaintenanceDefectType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<MaintenanceDefectTypeCollectionView,MaintenanceDefectTypeEntityView>( this,Screen.MaintenanceDefectTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "1a1621b3-86cf-4639-aea4-1537fd9af0c5",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<MaintenanceDefectTypeCollectionView,MaintenanceDefectTypeEntityView>( params_MainConsult,this,Screen.MaintenanceDefectTypeEntityView);
 

        }
        public IRPSButton<MaintenanceDefectTypeCollectionView,MaintenanceDefectTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<MaintenanceDefectTypeCollectionView,MaintenanceDefectTypeEntityView> MainConsult { get; set; } 
        public MaintenanceDefectType Screen { get; set; }
        public MaintenanceDefectTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenanceDefectTypeEntityView : View
    {
        public MaintenanceDefectTypeEntityView(MaintenanceDefectType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MaintenanceDefectTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceDefectTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceDefectTypeEntityView,MaintenanceDefectTypeCollectionView>( this,Screen.MaintenanceDefectTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceDefectTypeEntityView,MaintenanceDefectTypeCollectionView>( this,Screen.MaintenanceDefectTypeCollectionView);
 
            CodDefectType = RPSControlFactory.CreateRPSTextBox<MaintenanceDefectTypeEntityView>("f39f4218-675e-4b41-9359-7ea6d89353db","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MaintenanceDefectTypeEntityView>("79e59450-c98d-440c-8e11-e926b20d53cf","","",false, this);
 

        }
        public IRPSSaveButton<MaintenanceDefectTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<MaintenanceDefectTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceDefectTypeEntityView,MaintenanceDefectTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceDefectTypeEntityView,MaintenanceDefectTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<MaintenanceDefectTypeEntityView> CodDefectType { get; set; } 
        public IRPSTextBox<MaintenanceDefectTypeEntityView> Description { get; set; } 
        public MaintenanceDefectType Screen { get; set; }
        public MaintenanceDefectTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}