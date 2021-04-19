    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.MaintenanceComponentType
{
    //RPS VERSION 1.0.0.0
    public partial class MaintenanceComponentType:Screen
    {
        public MaintenanceComponentType():base()
        {
            this.URL = "maintenance.maintenancecomponenttype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MaintenanceComponentTypeCollectionView  = new MaintenanceComponentTypeCollectionView(this); 
            MaintenanceComponentTypeEntityView  = new MaintenanceComponentTypeEntityView(this); 
            MaintenanceComponentTypeCollectionView.InitializeControls(); 
            MaintenanceComponentTypeEntityView.InitializeControls(); 
           
        }
      
            public MaintenanceComponentTypeCollectionView MaintenanceComponentTypeCollectionView {get; set; } 
            public MaintenanceComponentTypeEntityView MaintenanceComponentTypeEntityView {get; set; } 
    }
            
    public partial class MaintenanceComponentTypeCollectionView : View
    {
        public MaintenanceComponentTypeCollectionView(MaintenanceComponentType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<MaintenanceComponentTypeCollectionView,MaintenanceComponentTypeEntityView>( this,Screen.MaintenanceComponentTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "b24e39e5-4aba-4dc7-8931-0a204a2dc8e2",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<MaintenanceComponentTypeCollectionView,MaintenanceComponentTypeEntityView>( params_MainConsult,this,Screen.MaintenanceComponentTypeEntityView);
 

        }
        public IRPSButton<MaintenanceComponentTypeCollectionView,MaintenanceComponentTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<MaintenanceComponentTypeCollectionView,MaintenanceComponentTypeEntityView> MainConsult { get; set; } 
        public MaintenanceComponentType Screen { get; set; }
        public MaintenanceComponentTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenanceComponentTypeEntityView : View
    {
        public MaintenanceComponentTypeEntityView(MaintenanceComponentType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MaintenanceComponentTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceComponentTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceComponentTypeEntityView,MaintenanceComponentTypeCollectionView>( this,Screen.MaintenanceComponentTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceComponentTypeEntityView,MaintenanceComponentTypeCollectionView>( this,Screen.MaintenanceComponentTypeCollectionView);
 
            CodMaintenanceComponentType = RPSControlFactory.CreateRPSTextBox<MaintenanceComponentTypeEntityView>("a78869d8-866d-476d-a6b6-742c3ff4f464","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MaintenanceComponentTypeEntityView>("dec006de-5b48-4901-a389-caabd353d1d3","","",false, this);
 

        }
        public IRPSSaveButton<MaintenanceComponentTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<MaintenanceComponentTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceComponentTypeEntityView,MaintenanceComponentTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceComponentTypeEntityView,MaintenanceComponentTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<MaintenanceComponentTypeEntityView> CodMaintenanceComponentType { get; set; } 
        public IRPSTextBox<MaintenanceComponentTypeEntityView> Description { get; set; } 
        public MaintenanceComponentType Screen { get; set; }
        public MaintenanceComponentTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}