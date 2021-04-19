    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.MaintenanceSolutionType
{
    //RPS VERSION 1.0.0.0
    public partial class MaintenanceSolutionType:Screen
    {
        public MaintenanceSolutionType():base()
        {
            this.URL = "maintenance.maintenancesolutiontype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MaintenanceSolutionTypeCollectionView  = new MaintenanceSolutionTypeCollectionView(this); 
            MaintenanceSolutionTypeEntityView  = new MaintenanceSolutionTypeEntityView(this); 
            MaintenanceSolutionTypeCollectionView.InitializeControls(); 
            MaintenanceSolutionTypeEntityView.InitializeControls(); 
           
        }
      
            public MaintenanceSolutionTypeCollectionView MaintenanceSolutionTypeCollectionView {get; set; } 
            public MaintenanceSolutionTypeEntityView MaintenanceSolutionTypeEntityView {get; set; } 
    }
            
    public partial class MaintenanceSolutionTypeCollectionView : View
    {
        public MaintenanceSolutionTypeCollectionView(MaintenanceSolutionType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<MaintenanceSolutionTypeCollectionView,MaintenanceSolutionTypeEntityView>( this,Screen.MaintenanceSolutionTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "bb0dda33-0786-4108-8a4c-99a19ca557f8",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<MaintenanceSolutionTypeCollectionView,MaintenanceSolutionTypeEntityView>( params_MainConsult,this,Screen.MaintenanceSolutionTypeEntityView);
 

        }
        public IRPSButton<MaintenanceSolutionTypeCollectionView,MaintenanceSolutionTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<MaintenanceSolutionTypeCollectionView,MaintenanceSolutionTypeEntityView> MainConsult { get; set; } 
        public MaintenanceSolutionType Screen { get; set; }
        public MaintenanceSolutionTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenanceSolutionTypeEntityView : View
    {
        public MaintenanceSolutionTypeEntityView(MaintenanceSolutionType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MaintenanceSolutionTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceSolutionTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceSolutionTypeEntityView,MaintenanceSolutionTypeCollectionView>( this,Screen.MaintenanceSolutionTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceSolutionTypeEntityView,MaintenanceSolutionTypeCollectionView>( this,Screen.MaintenanceSolutionTypeCollectionView);
 
            CodMaintenanceSolutionType = RPSControlFactory.CreateRPSTextBox<MaintenanceSolutionTypeEntityView>("ae53bd09-d121-471f-b500-42e62076e60b","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MaintenanceSolutionTypeEntityView>("9d408074-40d3-42cb-99f4-050a9c266b79","","",false, this);
 

        }
        public IRPSSaveButton<MaintenanceSolutionTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<MaintenanceSolutionTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceSolutionTypeEntityView,MaintenanceSolutionTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceSolutionTypeEntityView,MaintenanceSolutionTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<MaintenanceSolutionTypeEntityView> CodMaintenanceSolutionType { get; set; } 
        public IRPSTextBox<MaintenanceSolutionTypeEntityView> Description { get; set; } 
        public MaintenanceSolutionType Screen { get; set; }
        public MaintenanceSolutionTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}