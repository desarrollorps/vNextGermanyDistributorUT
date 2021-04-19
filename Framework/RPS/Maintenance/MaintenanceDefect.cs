    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.MaintenanceDefect
{
    //RPS VERSION 1.0.0.0
    public partial class MaintenanceDefect:Screen
    {
        public MaintenanceDefect():base()
        {
            this.URL = "maintenance.maintenancedefect";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MaintenanceDefectCollectionView  = new MaintenanceDefectCollectionView(this); 
            MaintenanceDefectEntityView  = new MaintenanceDefectEntityView(this); 
            MaintenanceDefectCollectionView.InitializeControls(); 
            MaintenanceDefectEntityView.InitializeControls(); 
           
        }
      
            public MaintenanceDefectCollectionView MaintenanceDefectCollectionView {get; set; } 
            public MaintenanceDefectEntityView MaintenanceDefectEntityView {get; set; } 
    }
            
    public partial class MaintenanceDefectCollectionView : View
    {
        public MaintenanceDefectCollectionView(MaintenanceDefect screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<MaintenanceDefectCollectionView,MaintenanceDefectEntityView>( this,Screen.MaintenanceDefectEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "89328165-0a8d-4a92-bb68-78bd5d04b2d1",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<MaintenanceDefectCollectionView,MaintenanceDefectEntityView>( params_MainConsult,this,Screen.MaintenanceDefectEntityView);
 

        }
        public IRPSButton<MaintenanceDefectCollectionView,MaintenanceDefectEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<MaintenanceDefectCollectionView,MaintenanceDefectEntityView> MainConsult { get; set; } 
        public MaintenanceDefect Screen { get; set; }
        public MaintenanceDefectCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenanceDefectEntityView : View
    {
        public MaintenanceDefectEntityView(MaintenanceDefect screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MaintenanceDefectEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceDefectEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceDefectEntityView,MaintenanceDefectCollectionView>( this,Screen.MaintenanceDefectCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceDefectEntityView,MaintenanceDefectCollectionView>( this,Screen.MaintenanceDefectCollectionView);
 
            CodDefect = RPSControlFactory.CreateRPSTextBox<MaintenanceDefectEntityView>("771da037-1bb9-4268-8da3-01cc75aee970","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MaintenanceDefectEntityView>("78da3541-02c6-488d-9e68-ceeed89c0f85","","",false, this);
 
            IDMaintenanceDefectType = RPSControlFactory.CreateRPSComboBox<MaintenanceDefectEntityView>("71350832-1750-4865-8d4f-f857266fc72e","","",false, this);
 

        }
        public IRPSSaveButton<MaintenanceDefectEntityView> SaveButton { get; set; } 
        public IRPSButton<MaintenanceDefectEntityView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceDefectEntityView,MaintenanceDefectCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceDefectEntityView,MaintenanceDefectCollectionView> BackButton { get; set; } 
        public IRPSTextBox<MaintenanceDefectEntityView> CodDefect { get; set; } 
        public IRPSTextBox<MaintenanceDefectEntityView> Description { get; set; } 
        public IRPSComboBox<MaintenanceDefectEntityView> IDMaintenanceDefectType { get; set; } 
        public MaintenanceDefect Screen { get; set; }
        public MaintenanceDefectEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}