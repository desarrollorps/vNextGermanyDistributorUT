    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.ShopFloorCMMS.MOHistoric
{
    //RPS VERSION 1.0.0.0
    public partial class MOHistoric:Screen
    {
        public MOHistoric():base()
        {
            this.URL = "shopfloorcmms.mohistoric";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MOHistoricQueryView  = new MOHistoricQueryView(this); 
            StatusLegendDialogView  = new StatusLegendDialogView(this); 
            MOHistoricQueryView.InitializeControls(); 
            StatusLegendDialogView.InitializeControls(); 
           
        }
      
            public MOHistoricQueryView MOHistoricQueryView {get; set; } 
            public StatusLegendDialogView StatusLegendDialogView {get; set; } 
    }
            
    public partial class MOHistoricQueryView : View
    {
        public MOHistoricQueryView(MOHistoric screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CreationDateFrom = RPSControlFactory.CreateRPSTextBox<MOHistoricQueryView>("5a411673-2878-4f06-831c-de3e78743bbd","","",false, this);
 
            CreationDateTo = RPSControlFactory.CreateRPSTextBox<MOHistoricQueryView>("4d5c176b-3512-410c-a55a-dd8a48f2e4a4","","",false, this);
 
            MaintenanceOrderStatusList = RPSControlFactory.CreateRPSCollectionComboBox<MOHistoricQueryView>("8629a10d-c519-4d11-aa7f-5e2d4ac9fd33","","",false, this);
 
            IDTerminal = RPSControlFactory.CreateRPSComboBox<MOHistoricQueryView>("e977e39c-077f-4e53-93d9-7d237d3b17e5","","",false, this);
 
            IDMaintenanceComponent = RPSControlFactory.CreateRPSComboBox<MOHistoricQueryView>("d5f49326-a4f2-4b8a-95d0-4569eab6b4ef","","",false, this);
 
            StatusLegendNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<MOHistoricQueryView,StatusLegendDialogView>("90549efd-0c43-4d10-a051-0d156bfe310f","","", this,Screen.StatusLegendDialogView);
 
            SelectMaintenanceWorkerNavigationCommandButton = RPSControlFactory.CreateRPSButton<MOHistoricQueryView>( "2c6e1c55-0e5d-4425-9f4f-6f7e4963a56a","","",this);
 
            TicketRequestNavigationCommandButton = RPSControlFactory.CreateRPSButton<MOHistoricQueryView>( "128c4a21-2266-448d-9500-cad110c5dd0a","","",this);
 
            MOFollowUpNavigationCommandButton = RPSControlFactory.CreateRPSButton<MOHistoricQueryView>( "bfb47328-8273-468c-958a-4e3300643493","","",this);
 
            MaterialStockLocatorNavigationCommandButton = RPSControlFactory.CreateRPSButton<MOHistoricQueryView>( "d720dbda-7301-4476-852a-16d75b455154","","",this);
 
            ShopfloorDocumentationNavigationCommandButton = RPSControlFactory.CreateRPSButton<MOHistoricQueryView>( "04ae53b5-a85d-4887-a419-97ad73e9c495","","",this);
 
            CollectionInit params_MaintenanceOrderHistoricForShopfloorCMMS = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a7f210c2-a8f0-460a-bed1-6356a36daf4b",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceOrderHistoricForShopfloorCMMS = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceOrderHistoricForShopfloorCMMSCollectionEditor<MOHistoricQueryView,StatusLegendDialogView>,MOHistoricQueryView,StatusLegendDialogView>( params_MaintenanceOrderHistoricForShopfloorCMMS,this,Screen.StatusLegendDialogView);
 

        }
        public IRPSTextBox<MOHistoricQueryView> CreationDateFrom { get; set; } 
        public IRPSTextBox<MOHistoricQueryView> CreationDateTo { get; set; } 
        public IRPSCollectionComboBox<MOHistoricQueryView> MaintenanceOrderStatusList { get; set; } 
        public IRPSComboBox<MOHistoricQueryView> IDTerminal { get; set; } 
        public IRPSComboBox<MOHistoricQueryView> IDMaintenanceComponent { get; set; } 
        public IRPSButton<MOHistoricQueryView,StatusLegendDialogView> StatusLegendNavigationCommandButton { get; set; } 
        public IRPSButton<MOHistoricQueryView> SelectMaintenanceWorkerNavigationCommandButton { get; set; } 
        public IRPSButton<MOHistoricQueryView> TicketRequestNavigationCommandButton { get; set; } 
        public IRPSButton<MOHistoricQueryView> MOFollowUpNavigationCommandButton { get; set; } 
        public IRPSButton<MOHistoricQueryView> MaterialStockLocatorNavigationCommandButton { get; set; } 
        public IRPSButton<MOHistoricQueryView> ShopfloorDocumentationNavigationCommandButton { get; set; } 
        public MaintenanceOrderHistoricForShopfloorCMMSCollectionEditor<MOHistoricQueryView,StatusLegendDialogView> MaintenanceOrderHistoricForShopfloorCMMS { get; set; } 
        public MOHistoric Screen { get; set; }
        public MOHistoricQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaintenanceOrderHistoricForShopfloorCMMSCollectionEditor<MOHistoricQueryView,StatusLegendDialogView>:RPSCollectionEditor<MOHistoricQueryView,StatusLegendDialogView> where MOHistoricQueryView : class, IView where StatusLegendDialogView : class, IView
    {
        public  MaintenanceOrderHistoricForShopfloorCMMSGridView<MOHistoricQueryView,StatusLegendDialogView> GridView {get;set;}
    }
    public partial class MaintenanceOrderHistoricForShopfloorCMMSGridView <MOHistoricQueryView,StatusLegendDialogView> :  RPSGridView<MOHistoricQueryView,StatusLegendDialogView> where MOHistoricQueryView : class, IView where StatusLegendDialogView : class, IView
    {
        public MaintenanceOrderHistoricForShopfloorCMMSGridView(MOHistoricQueryView currentView,StatusLegendDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MaintenanceOrder_CreationDate = RPSControlFactory.CreateRPSGridTextBox<MOHistoricQueryView>("","#a7f210c2-a8f0-460a-bed1-6356a36daf4b .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceOrder_CreationDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MOHistoricQueryView> MaintenanceOrder_CreationDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class StatusLegendDialogView : View
    {
        public StatusLegendDialogView(MOHistoric screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_MaintenanceOrderStatusShopfloorCMMS = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b0005e0f-9144-43f8-b870-2b4bf4f8fa63",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceOrderStatusShopfloorCMMS = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceOrderStatusShopfloorCMMSCollectionEditor<StatusLegendDialogView>,StatusLegendDialogView>( params_MaintenanceOrderStatusShopfloorCMMS,this);
 

        }
        public MaintenanceOrderStatusShopfloorCMMSCollectionEditor<StatusLegendDialogView> MaintenanceOrderStatusShopfloorCMMS { get; set; } 
        public MOHistoric Screen { get; set; }
        public StatusLegendDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaintenanceOrderStatusShopfloorCMMSCollectionEditor<StatusLegendDialogView>:RPSCollectionEditor<StatusLegendDialogView> where StatusLegendDialogView : class, IView
    {
        public  MaintenanceOrderStatusShopfloorCMMSGridView<StatusLegendDialogView> GridView {get;set;}
    }
    public partial class MaintenanceOrderStatusShopfloorCMMSGridView <StatusLegendDialogView> :  RPSGridView<StatusLegendDialogView> where StatusLegendDialogView : class, IView
    {
        public MaintenanceOrderStatusShopfloorCMMSGridView(StatusLegendDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MaintenanceOrderStatus_CodStatus = RPSControlFactory.CreateRPSGridTextBox<StatusLegendDialogView>("","#b0005e0f-9144-43f8-b870-2b4bf4f8fa63 .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceOrderStatus_CodStatus']","",false, this.CurrentView);
 
            MaintenanceOrderStatus_Description = RPSControlFactory.CreateRPSGridTextBox<StatusLegendDialogView>("","#b0005e0f-9144-43f8-b870-2b4bf4f8fa63 .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceOrderStatus_Description']","",false, this.CurrentView);
 
            MaintenanceOrderStatus_ShowInShopfloorCMMS = RPSControlFactory.CreateRPSGridCheckBox<StatusLegendDialogView>("","#b0005e0f-9144-43f8-b870-2b4bf4f8fa63 .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceOrderStatus_ShowInShopfloorCMMS']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<StatusLegendDialogView> MaintenanceOrderStatus_CodStatus { get; set; } 
        public IRPSGridTextBox<StatusLegendDialogView> MaintenanceOrderStatus_Description { get; set; } 
        public IRPSGridCheckbox<StatusLegendDialogView> MaintenanceOrderStatus_ShowInShopfloorCMMS { get; set; } 
                     
    }
 
    }
  
    

}