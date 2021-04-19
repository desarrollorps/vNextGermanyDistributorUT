    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.MaintenanceSolution
{
    //RPS VERSION 1.0.0.0
    public partial class MaintenanceSolution:Screen
    {
        public MaintenanceSolution():base()
        {
            this.URL = "maintenance.maintenancesolution";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MaintenanceSolutionCollectionView  = new MaintenanceSolutionCollectionView(this); 
            MaintenanceSolutionEntityView  = new MaintenanceSolutionEntityView(this); 
            MaintenanceSolutionCollectionView.InitializeControls(); 
            MaintenanceSolutionEntityView.InitializeControls(); 
           
        }
      
            public MaintenanceSolutionCollectionView MaintenanceSolutionCollectionView {get; set; } 
            public MaintenanceSolutionEntityView MaintenanceSolutionEntityView {get; set; } 
    }
            
    public partial class MaintenanceSolutionCollectionView : View
    {
        public MaintenanceSolutionCollectionView(MaintenanceSolution screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<MaintenanceSolutionCollectionView,MaintenanceSolutionEntityView>( this,Screen.MaintenanceSolutionEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "6eba7105-2f52-4f18-8cb0-c5a0b7d9d604",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<MaintenanceSolutionCollectionView,MaintenanceSolutionEntityView>( params_MainConsult,this,Screen.MaintenanceSolutionEntityView);
 

        }
        public IRPSButton<MaintenanceSolutionCollectionView,MaintenanceSolutionEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<MaintenanceSolutionCollectionView,MaintenanceSolutionEntityView> MainConsult { get; set; } 
        public MaintenanceSolution Screen { get; set; }
        public MaintenanceSolutionCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenanceSolutionEntityView : View
    {
        public MaintenanceSolutionEntityView(MaintenanceSolution screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MaintenanceSolutionEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceSolutionEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceSolutionEntityView,MaintenanceSolutionCollectionView>( this,Screen.MaintenanceSolutionCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceSolutionEntityView,MaintenanceSolutionCollectionView>( this,Screen.MaintenanceSolutionCollectionView);
 
            CodSolution = RPSControlFactory.CreateRPSTextBox<MaintenanceSolutionEntityView>("1f741b13-752e-4a15-9d34-41b614e1a568","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MaintenanceSolutionEntityView>("def0abb7-aff9-4f7d-9836-b09d85297090","","",false, this);
 
            IDMaintenanceSolutionType = RPSControlFactory.CreateRPSComboBox<MaintenanceSolutionEntityView>("a9723d69-2e43-44dc-bc16-a87a2007aa3e","","",false, this);
 

        }
        public IRPSSaveButton<MaintenanceSolutionEntityView> SaveButton { get; set; } 
        public IRPSButton<MaintenanceSolutionEntityView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceSolutionEntityView,MaintenanceSolutionCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceSolutionEntityView,MaintenanceSolutionCollectionView> BackButton { get; set; } 
        public IRPSTextBox<MaintenanceSolutionEntityView> CodSolution { get; set; } 
        public IRPSTextBox<MaintenanceSolutionEntityView> Description { get; set; } 
        public IRPSComboBox<MaintenanceSolutionEntityView> IDMaintenanceSolutionType { get; set; } 
        public MaintenanceSolution Screen { get; set; }
        public MaintenanceSolutionEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}