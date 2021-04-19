    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.MaintenanceResource
{
    //RPS VERSION 1.0.0.0
    public partial class MaintenanceResource:Screen
    {
        public MaintenanceResource():base()
        {
            this.URL = "maintenance.maintenanceresource";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MaintenanceResourceCollectionView  = new MaintenanceResourceCollectionView(this); 
            MaintenanceResourceEntityView  = new MaintenanceResourceEntityView(this); 
            MaintenanceResourceCollectionView.InitializeControls(); 
            MaintenanceResourceEntityView.InitializeControls(); 
           
        }
      
            public MaintenanceResourceCollectionView MaintenanceResourceCollectionView {get; set; } 
            public MaintenanceResourceEntityView MaintenanceResourceEntityView {get; set; } 
    }
            
    public partial class MaintenanceResourceCollectionView : View
    {
        public MaintenanceResourceCollectionView(MaintenanceResource screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<MaintenanceResourceCollectionView,MaintenanceResourceEntityView>( this,Screen.MaintenanceResourceEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "585c0c08-3699-4bab-8e60-307d268f4612",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<MaintenanceResourceCollectionView,MaintenanceResourceEntityView>( params_MainConsult,this,Screen.MaintenanceResourceEntityView);
 

        }
        public IRPSButton<MaintenanceResourceCollectionView,MaintenanceResourceEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<MaintenanceResourceCollectionView,MaintenanceResourceEntityView> MainConsult { get; set; } 
        public MaintenanceResource Screen { get; set; }
        public MaintenanceResourceCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaintenanceResourceEntityView : View
    {
        public MaintenanceResourceEntityView(MaintenanceResource screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MaintenanceResourceEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceResourceEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceResourceEntityView,MaintenanceResourceCollectionView>( this,Screen.MaintenanceResourceCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceResourceEntityView,MaintenanceResourceCollectionView>( this,Screen.MaintenanceResourceCollectionView);
 
            Code = RPSControlFactory.CreateRPSTextBox<MaintenanceResourceEntityView>("1efff586-6716-4387-b7ba-39a43c395675","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MaintenanceResourceEntityView>("3f26c5ca-4e82-4dd9-9c4d-ca14d0b4e793","","",false, this);
 
            CostPrice = RPSControlFactory.CreateRPSFormattedTextBox<MaintenanceResourceEntityView>("4c853155-6678-44fe-9f3d-475e8f1c6b07","","",true, this);
 
            IDMaintenanceResourceType = RPSControlFactory.CreateRPSComboBox<MaintenanceResourceEntityView>("a344a0a5-d9b3-4810-aae4-9e284af90bdb","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<MaintenanceResourceEntityView>("f0bcdaf8-7c3f-4e36-bd64-ddec16171b77","","",false, this);
 
            CPRElementType = RPSControlFactory.CreateRPSEnumComboBox<MaintenanceResourceEntityView>("4733f51d-2da4-4d15-9383-84705f084dd3","","",true, this);
 
            CPRElementMachine = RPSControlFactory.CreateRPSComboBox<MaintenanceResourceEntityView>("b26213da-a2a9-4701-944a-cb16a21f8233","","",false, this);
 
            CPRElementTool = RPSControlFactory.CreateRPSComboBox<MaintenanceResourceEntityView>("38f08772-143a-4ade-8da1-0e267233e5cb","","",false, this);
 

        }
        public IRPSSaveButton<MaintenanceResourceEntityView> SaveButton { get; set; } 
        public IRPSButton<MaintenanceResourceEntityView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceResourceEntityView,MaintenanceResourceCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceResourceEntityView,MaintenanceResourceCollectionView> BackButton { get; set; } 
        public IRPSTextBox<MaintenanceResourceEntityView> Code { get; set; } 
        public IRPSTextBox<MaintenanceResourceEntityView> Description { get; set; } 
        public IRPSTextBox<MaintenanceResourceEntityView> CostPrice { get; set; } 
        public IRPSComboBox<MaintenanceResourceEntityView> IDMaintenanceResourceType { get; set; } 
        public IRPSComboBox<MaintenanceResourceEntityView> IDSite { get; set; } 
        public IRPSComboBox<MaintenanceResourceEntityView> CPRElementType { get; set; } 
        public IRPSComboBox<MaintenanceResourceEntityView> CPRElementMachine { get; set; } 
        public IRPSComboBox<MaintenanceResourceEntityView> CPRElementTool { get; set; } 
        public MaintenanceResource Screen { get; set; }
        public MaintenanceResourceEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}