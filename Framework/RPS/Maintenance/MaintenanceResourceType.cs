    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.MaintenanceResourceType
{
    //RPS VERSION 1.0.0.0
    public partial class MaintenanceResourceType:Screen
    {
        public MaintenanceResourceType():base()
        {
            this.URL = "maintenance.maintenanceresourcetype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MaintenanceResourceTypeCollectionView  = new MaintenanceResourceTypeCollectionView(this); 
            MaintenanceResourceTypeEntityView  = new MaintenanceResourceTypeEntityView(this); 
            MaintenanceResourceTypeCollectionView.InitializeControls(); 
            MaintenanceResourceTypeEntityView.InitializeControls(); 
           
        }
      
            public MaintenanceResourceTypeCollectionView MaintenanceResourceTypeCollectionView {get; set; } 
            public MaintenanceResourceTypeEntityView MaintenanceResourceTypeEntityView {get; set; } 
    }
            
    public partial class MaintenanceResourceTypeCollectionView : View
    {
        public MaintenanceResourceTypeCollectionView(MaintenanceResourceType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<MaintenanceResourceTypeCollectionView,MaintenanceResourceTypeEntityView>( this,Screen.MaintenanceResourceTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "4ee502e4-8d70-4f48-9963-7ea9acb2afa0",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<MaintenanceResourceTypeCollectionView,MaintenanceResourceTypeEntityView>( params_MainConsult,this,Screen.MaintenanceResourceTypeEntityView);
 

        }
        public IRPSButton<MaintenanceResourceTypeCollectionView,MaintenanceResourceTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<MaintenanceResourceTypeCollectionView,MaintenanceResourceTypeEntityView> MainConsult { get; set; } 
        public MaintenanceResourceType Screen { get; set; }
        public MaintenanceResourceTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenanceResourceTypeEntityView : View
    {
        public MaintenanceResourceTypeEntityView(MaintenanceResourceType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MaintenanceResourceTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceResourceTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceResourceTypeEntityView,MaintenanceResourceTypeCollectionView>( this,Screen.MaintenanceResourceTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceResourceTypeEntityView,MaintenanceResourceTypeCollectionView>( this,Screen.MaintenanceResourceTypeCollectionView);
 
            CodResourceType = RPSControlFactory.CreateRPSTextBox<MaintenanceResourceTypeEntityView>("d77f42c3-6bc4-400d-baba-d1e8cc6e7e9b","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MaintenanceResourceTypeEntityView>("2354d400-a170-4ed4-9644-904396db0bb8","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<MaintenanceResourceTypeEntityView>("e8907468-4052-4d73-8908-fe5cf55e0bf7","","",false, this);
 

        }
        public IRPSSaveButton<MaintenanceResourceTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<MaintenanceResourceTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceResourceTypeEntityView,MaintenanceResourceTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceResourceTypeEntityView,MaintenanceResourceTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<MaintenanceResourceTypeEntityView> CodResourceType { get; set; } 
        public IRPSTextBox<MaintenanceResourceTypeEntityView> Description { get; set; } 
        public IRPSComboBox<MaintenanceResourceTypeEntityView> IDArticle { get; set; } 
        public MaintenanceResourceType Screen { get; set; }
        public MaintenanceResourceTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}