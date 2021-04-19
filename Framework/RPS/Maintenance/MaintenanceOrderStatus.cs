    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.MaintenanceOrderStatus
{
    //RPS VERSION 1.0.0.0
    public partial class MaintenanceOrderStatus:Screen
    {
        public MaintenanceOrderStatus():base()
        {
            this.URL = "maintenance.maintenanceorderstatus";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MaintenanceOrderStatusCollectionView  = new MaintenanceOrderStatusCollectionView(this); 
            MaintenanceOrderStatusEntityView  = new MaintenanceOrderStatusEntityView(this); 
            MaintenanceOrderStatusCollectionView.InitializeControls(); 
            MaintenanceOrderStatusEntityView.InitializeControls(); 
           
        }
      
            public MaintenanceOrderStatusCollectionView MaintenanceOrderStatusCollectionView {get; set; } 
            public MaintenanceOrderStatusEntityView MaintenanceOrderStatusEntityView {get; set; } 
    }
            
    public partial class MaintenanceOrderStatusCollectionView : View
    {
        public MaintenanceOrderStatusCollectionView(MaintenanceOrderStatus screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<MaintenanceOrderStatusCollectionView,MaintenanceOrderStatusEntityView>( this,Screen.MaintenanceOrderStatusEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "0b4eacec-0bd1-486b-a651-a373e8893fab",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<MaintenanceOrderStatusCollectionView,MaintenanceOrderStatusEntityView>( params_MainConsult,this,Screen.MaintenanceOrderStatusEntityView);
 

        }
        public IRPSButton<MaintenanceOrderStatusCollectionView,MaintenanceOrderStatusEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<MaintenanceOrderStatusCollectionView,MaintenanceOrderStatusEntityView> MainConsult { get; set; } 
        public MaintenanceOrderStatus Screen { get; set; }
        public MaintenanceOrderStatusCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenanceOrderStatusEntityView : View
    {
        public MaintenanceOrderStatusEntityView(MaintenanceOrderStatus screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MaintenanceOrderStatusEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceOrderStatusEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceOrderStatusEntityView,MaintenanceOrderStatusCollectionView>( this,Screen.MaintenanceOrderStatusCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceOrderStatusEntityView,MaintenanceOrderStatusCollectionView>( this,Screen.MaintenanceOrderStatusCollectionView);
 
            CodStatus = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderStatusEntityView>("1271ccab-fe6a-4d13-bc83-1753dd484e7f","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MaintenanceOrderStatusEntityView>("58e2c598-6054-469d-9638-4da2c4fd42f9","","",false, this);
 
            ShowInShopfloorCMMS = RPSControlFactory.CreateRPSCheckBox<MaintenanceOrderStatusEntityView>("d2b6b568-6a97-42b9-bbc2-9a3df7bd1b68","","",true, this);
 
            Color = RPSControlFactory.CreateRPSColorEditor<MaintenanceOrderStatusEntityView>( "5b872bfe-1ac4-4adf-bffe-f8c8c9a3f71a","","",this);
 

        }
        public IRPSSaveButton<MaintenanceOrderStatusEntityView> SaveButton { get; set; } 
        public IRPSButton<MaintenanceOrderStatusEntityView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceOrderStatusEntityView,MaintenanceOrderStatusCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceOrderStatusEntityView,MaintenanceOrderStatusCollectionView> BackButton { get; set; } 
        public IRPSTextBox<MaintenanceOrderStatusEntityView> CodStatus { get; set; } 
        public IRPSTextBox<MaintenanceOrderStatusEntityView> Description { get; set; } 
        public IRPSCheckbox<MaintenanceOrderStatusEntityView> ShowInShopfloorCMMS { get; set; } 
        public IRPSColorEditor<MaintenanceOrderStatusEntityView> Color { get; set; } 
        public MaintenanceOrderStatus Screen { get; set; }
        public MaintenanceOrderStatusEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}