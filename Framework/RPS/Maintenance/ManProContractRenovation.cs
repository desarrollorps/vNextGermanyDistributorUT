    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Maintenance.ManProContractRenovation
{
    //RPS VERSION 1.0.0.0
    public partial class ManProContractRenovation:Screen
    {
        public ManProContractRenovation():base()
        {
            this.URL = "maintenance.manprocontractrenovation";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ManProContractRenovationQueryView  = new ManProContractRenovationQueryView(this); 
            ManProContractRenovationQueryView.InitializeControls(); 
           
        }
      
            public ManProContractRenovationQueryView ManProContractRenovationQueryView {get; set; } 
    }
            
    public partial class ManProContractRenovationQueryView : View
    {
        public ManProContractRenovationQueryView(ManProContractRenovation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<ManProContractRenovationQueryView>("666fc827-68c0-479d-90f0-1a6ba9d8acce","","",false, this);
 
            MaintenanceContract = RPSControlFactory.CreateRPSCollectionComboBox<ManProContractRenovationQueryView>("9264b87a-ec6e-484a-a367-427e2ecaa293","","",false, this);
 
            RefreshContract = RPSControlFactory.CreateRPSOption<ManProContractRenovationQueryView>( "77b8f9cc-b0f3-4a28-aa75-6227b3e45709","","",this);
 
            CreateContract = RPSControlFactory.CreateRPSOption<ManProContractRenovationQueryView>( "4f25e03b-4ada-422e-b458-6bcd8bf10ccb","","",this);
 
            PriceIncrement = RPSControlFactory.CreateRPSFormattedTextBox<ManProContractRenovationQueryView>("1970be1c-2bc3-4f59-a3bb-c2b5c2692e5d","","",false, this);
 
            ExecuteRenovationButton = RPSControlFactory.CreateRPSButton<ManProContractRenovationQueryView>( "91b995d8-90b0-45f3-9acb-69c9c9b51764","","",this);
 
            CollectionInit params_MaintenanceRenovationContract = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8dabd8c0-8683-40bf-ba75-8e1766f19b2c",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceRenovationContract = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceRenovationContractCollectionEditor<ManProContractRenovationQueryView>,ManProContractRenovationQueryView>( params_MaintenanceRenovationContract,this);
 

        }
        public IRPSComboBox<ManProContractRenovationQueryView> Site { get; set; } 
        public IRPSCollectionComboBox<ManProContractRenovationQueryView> MaintenanceContract { get; set; } 
        public IRPSOption<ManProContractRenovationQueryView> RefreshContract { get; set; } 
        public IRPSOption<ManProContractRenovationQueryView> CreateContract { get; set; } 
        public IRPSTextBox<ManProContractRenovationQueryView> PriceIncrement { get; set; } 
        public IRPSButton<ManProContractRenovationQueryView> ExecuteRenovationButton { get; set; } 
        public MaintenanceRenovationContractCollectionEditor<ManProContractRenovationQueryView> MaintenanceRenovationContract { get; set; } 
        public ManProContractRenovation Screen { get; set; }
        public ManProContractRenovationQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaintenanceRenovationContractCollectionEditor<ManProContractRenovationQueryView>:RPSCollectionEditor<ManProContractRenovationQueryView> where ManProContractRenovationQueryView : class, IView
    {
        public  MaintenanceRenovationContractGridView<ManProContractRenovationQueryView> GridView {get;set;}
    }
    public partial class MaintenanceRenovationContractGridView <ManProContractRenovationQueryView> :  RPSGridView<ManProContractRenovationQueryView> where ManProContractRenovationQueryView : class, IView
    {
        public MaintenanceRenovationContractGridView(ManProContractRenovationQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MaintenanceContract_FormalizationDate = RPSControlFactory.CreateRPSGridTextBox<ManProContractRenovationQueryView>("","#8dabd8c0-8683-40bf-ba75-8e1766f19b2c .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceContract_FormalizationDate']","",false, this.CurrentView);
 
            MaintenanceContract_DateFrom = RPSControlFactory.CreateRPSGridTextBox<ManProContractRenovationQueryView>("","#8dabd8c0-8683-40bf-ba75-8e1766f19b2c .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceContract_DateFrom']","",false, this.CurrentView);
 
            MaintenanceContract_DateTo = RPSControlFactory.CreateRPSGridTextBox<ManProContractRenovationQueryView>("","#8dabd8c0-8683-40bf-ba75-8e1766f19b2c .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceContract_DateTo']","",false, this.CurrentView);
 
            CreateContract = RPSControlFactory.CreateRPSGridCheckBox<ManProContractRenovationQueryView>("","#8dabd8c0-8683-40bf-ba75-8e1766f19b2c .ag-row[role='row']@ROWINDEX [col-id='cCreateContract']","",false, this.CurrentView);
 
            Increment = RPSControlFactory.CreateRPSGridFormattedTextBox<ManProContractRenovationQueryView>("","#8dabd8c0-8683-40bf-ba75-8e1766f19b2c .ag-row[role='row']@ROWINDEX [col-id='cIncrement']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ManProContractRenovationQueryView> MaintenanceContract_FormalizationDate { get; set; } 
        public IRPSGridTextBox<ManProContractRenovationQueryView> MaintenanceContract_DateFrom { get; set; } 
        public IRPSGridTextBox<ManProContractRenovationQueryView> MaintenanceContract_DateTo { get; set; } 
        public IRPSGridCheckbox<ManProContractRenovationQueryView> CreateContract { get; set; } 
        public IRPSGridTextBox<ManProContractRenovationQueryView> Increment { get; set; } 
                     
    }
 
    }
  
    

}