    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.MaintenanceCauseType
{
    //RPS VERSION 1.0.0.0
    public partial class MaintenanceCauseType:Screen
    {
        public MaintenanceCauseType():base()
        {
            this.URL = "maintenance.maintenancecausetype";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MaintenanceCauseTypeCollectionView  = new MaintenanceCauseTypeCollectionView(this); 
            MaintenanceCauseTypeEntityView  = new MaintenanceCauseTypeEntityView(this); 
            MaintenanceCauseTypeCollectionView.InitializeControls(); 
            MaintenanceCauseTypeEntityView.InitializeControls(); 
           
        }
      
            public MaintenanceCauseTypeCollectionView MaintenanceCauseTypeCollectionView {get; set; } 
            public MaintenanceCauseTypeEntityView MaintenanceCauseTypeEntityView {get; set; } 
    }
            
    public partial class MaintenanceCauseTypeCollectionView : View
    {
        public MaintenanceCauseTypeCollectionView(MaintenanceCauseType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<MaintenanceCauseTypeCollectionView,MaintenanceCauseTypeEntityView>( this,Screen.MaintenanceCauseTypeEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "d2dc80dc-3935-4a9a-8444-aadd3a439df4",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<MaintenanceCauseTypeCollectionView,MaintenanceCauseTypeEntityView>( params_MainConsult,this,Screen.MaintenanceCauseTypeEntityView);
 

        }
        public IRPSButton<MaintenanceCauseTypeCollectionView,MaintenanceCauseTypeEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<MaintenanceCauseTypeCollectionView,MaintenanceCauseTypeEntityView> MainConsult { get; set; } 
        public MaintenanceCauseType Screen { get; set; }
        public MaintenanceCauseTypeCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenanceCauseTypeEntityView : View
    {
        public MaintenanceCauseTypeEntityView(MaintenanceCauseType screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MaintenanceCauseTypeEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceCauseTypeEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceCauseTypeEntityView,MaintenanceCauseTypeCollectionView>( this,Screen.MaintenanceCauseTypeCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceCauseTypeEntityView,MaintenanceCauseTypeCollectionView>( this,Screen.MaintenanceCauseTypeCollectionView);
 
            CodCauseType = RPSControlFactory.CreateRPSTextBox<MaintenanceCauseTypeEntityView>("e7491105-b0fa-4656-ab66-47cfd11a3211","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MaintenanceCauseTypeEntityView>("68288ec8-c726-4f17-9aa3-a957d13c032f","","",false, this);
 

        }
        public IRPSSaveButton<MaintenanceCauseTypeEntityView> SaveButton { get; set; } 
        public IRPSButton<MaintenanceCauseTypeEntityView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceCauseTypeEntityView,MaintenanceCauseTypeCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceCauseTypeEntityView,MaintenanceCauseTypeCollectionView> BackButton { get; set; } 
        public IRPSTextBox<MaintenanceCauseTypeEntityView> CodCauseType { get; set; } 
        public IRPSTextBox<MaintenanceCauseTypeEntityView> Description { get; set; } 
        public MaintenanceCauseType Screen { get; set; }
        public MaintenanceCauseTypeEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}