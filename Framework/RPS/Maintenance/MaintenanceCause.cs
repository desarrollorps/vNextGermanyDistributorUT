    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.MaintenanceCause
{
    //RPS VERSION 1.0.0.0
    public partial class MaintenanceCause:Screen
    {
        public MaintenanceCause():base()
        {
            this.URL = "maintenance.maintenancecause";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MaintenanceCauseCollectionView  = new MaintenanceCauseCollectionView(this); 
            MaintenanceCauseEntityView  = new MaintenanceCauseEntityView(this); 
            MaintenanceCauseCollectionView.InitializeControls(); 
            MaintenanceCauseEntityView.InitializeControls(); 
           
        }
      
            public MaintenanceCauseCollectionView MaintenanceCauseCollectionView {get; set; } 
            public MaintenanceCauseEntityView MaintenanceCauseEntityView {get; set; } 
    }
            
    public partial class MaintenanceCauseCollectionView : View
    {
        public MaintenanceCauseCollectionView(MaintenanceCause screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<MaintenanceCauseCollectionView,MaintenanceCauseEntityView>( this,Screen.MaintenanceCauseEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "7ed4eb49-56b9-490a-95e8-dc9c103dc450",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<MaintenanceCauseCollectionView,MaintenanceCauseEntityView>( params_MainConsult,this,Screen.MaintenanceCauseEntityView);
 

        }
        public IRPSButton<MaintenanceCauseCollectionView,MaintenanceCauseEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<MaintenanceCauseCollectionView,MaintenanceCauseEntityView> MainConsult { get; set; } 
        public MaintenanceCause Screen { get; set; }
        public MaintenanceCauseCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenanceCauseEntityView : View
    {
        public MaintenanceCauseEntityView(MaintenanceCause screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MaintenanceCauseEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceCauseEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceCauseEntityView,MaintenanceCauseCollectionView>( this,Screen.MaintenanceCauseCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceCauseEntityView,MaintenanceCauseCollectionView>( this,Screen.MaintenanceCauseCollectionView);
 
            CodCause = RPSControlFactory.CreateRPSTextBox<MaintenanceCauseEntityView>("24d98968-8d87-4a60-a7b1-f91f247a40c8","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MaintenanceCauseEntityView>("dcd734ab-14c7-419c-8562-f3a2ca7ac4b8","","",false, this);
 
            IDMaintenanceCauseType = RPSControlFactory.CreateRPSComboBox<MaintenanceCauseEntityView>("ba438fc4-5f91-4b83-81a8-8ae822f40864","","",false, this);
 

        }
        public IRPSSaveButton<MaintenanceCauseEntityView> SaveButton { get; set; } 
        public IRPSButton<MaintenanceCauseEntityView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceCauseEntityView,MaintenanceCauseCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceCauseEntityView,MaintenanceCauseCollectionView> BackButton { get; set; } 
        public IRPSTextBox<MaintenanceCauseEntityView> CodCause { get; set; } 
        public IRPSTextBox<MaintenanceCauseEntityView> Description { get; set; } 
        public IRPSComboBox<MaintenanceCauseEntityView> IDMaintenanceCauseType { get; set; } 
        public MaintenanceCause Screen { get; set; }
        public MaintenanceCauseEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}