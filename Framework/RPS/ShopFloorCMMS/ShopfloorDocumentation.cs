    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.ShopFloorCMMS.ShopfloorDocumentation
{
    //RPS VERSION 1.0.0.0
    public partial class ShopfloorDocumentation:Screen
    {
        public ShopfloorDocumentation():base()
        {
            this.URL = "shopfloorcmms.shopfloordocumentation";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ShopfloorDocumentationQueryView  = new ShopfloorDocumentationQueryView(this); 
            DocumentationMOView  = new DocumentationMOView(this); 
            StatusLegendDialogView  = new StatusLegendDialogView(this); 
            ShopfloorDocumentationQueryView.InitializeControls(); 
            DocumentationMOView.InitializeControls(); 
            StatusLegendDialogView.InitializeControls(); 
           
        }
      
            public ShopfloorDocumentationQueryView ShopfloorDocumentationQueryView {get; set; } 
            public DocumentationMOView DocumentationMOView {get; set; } 
            public StatusLegendDialogView StatusLegendDialogView {get; set; } 
    }
            
    public partial class ShopfloorDocumentationQueryView : View
    {
        public ShopfloorDocumentationQueryView(ShopfloorDocumentation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDTerminal = RPSControlFactory.CreateRPSComboBox<ShopfloorDocumentationQueryView>("56e9f7e7-050f-4a07-b288-8b6a584908e9","","",false, this);
 
            IDMaintenanceComponent = RPSControlFactory.CreateRPSComboBox<ShopfloorDocumentationQueryView>("38edd4f5-8cdd-42f0-ab37-4782eabf00f5","","",false, this);
 
            SerialNumber = RPSControlFactory.CreateRPSTextBox<ShopfloorDocumentationQueryView>("00230c8e-a0fd-4f45-bc58-3f6f96ceebbd","","",false, this);
 
            OnlyActives = RPSControlFactory.CreateRPSCheckBox<ShopfloorDocumentationQueryView>("c20a6761-b4e3-4ae4-a7d4-c46248c97d48","","",false, this);
 
            StatusLegendNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ShopfloorDocumentationQueryView,StatusLegendDialogView>("70babdf0-19fa-4c29-8e3a-27b4af13df8c","","", this,Screen.StatusLegendDialogView);
 
            SelectMaintenanceWorkerNavigationCommandButton = RPSControlFactory.CreateRPSButton<ShopfloorDocumentationQueryView>( "b4c14d8c-e1b3-43d8-afd7-a8f16f5c9b3b","","",this);
 
            TicketRequestNavigationCommandButton = RPSControlFactory.CreateRPSButton<ShopfloorDocumentationQueryView>( "b2c85f71-9e46-44b1-9ac2-56acb8fda908","","",this);
 
            WorkOrdersFollowUpNavigationCommandButton = RPSControlFactory.CreateRPSButton<ShopfloorDocumentationQueryView>( "8b1361d4-c85b-496a-b4fc-97a89a1c3730","","",this);
 
            MOHistoricNavigationCommandButton = RPSControlFactory.CreateRPSButton<ShopfloorDocumentationQueryView>( "c4eb203a-23ce-48ae-8633-118c95bfc54f","","",this);
 
            MaterialStockLocatorNavigationCommandButton = RPSControlFactory.CreateRPSButton<ShopfloorDocumentationQueryView>( "6fb39a69-4804-49ef-ae1d-c756fdd623ff","","",this);
 

        }
        public IRPSComboBox<ShopfloorDocumentationQueryView> IDTerminal { get; set; } 
        public IRPSComboBox<ShopfloorDocumentationQueryView> IDMaintenanceComponent { get; set; } 
        public IRPSTextBox<ShopfloorDocumentationQueryView> SerialNumber { get; set; } 
        public IRPSCheckbox<ShopfloorDocumentationQueryView> OnlyActives { get; set; } 
        public IRPSButton<ShopfloorDocumentationQueryView,StatusLegendDialogView> StatusLegendNavigationCommandButton { get; set; } 
        public IRPSButton<ShopfloorDocumentationQueryView> SelectMaintenanceWorkerNavigationCommandButton { get; set; } 
        public IRPSButton<ShopfloorDocumentationQueryView> TicketRequestNavigationCommandButton { get; set; } 
        public IRPSButton<ShopfloorDocumentationQueryView> WorkOrdersFollowUpNavigationCommandButton { get; set; } 
        public IRPSButton<ShopfloorDocumentationQueryView> MOHistoricNavigationCommandButton { get; set; } 
        public IRPSButton<ShopfloorDocumentationQueryView> MaterialStockLocatorNavigationCommandButton { get; set; } 
        public ShopfloorDocumentation Screen { get; set; }
        public ShopfloorDocumentationQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DocumentationMOView : View
    {
        public DocumentationMOView(ShopfloorDocumentation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ShowComponentAttachmentsButton = RPSControlFactory.CreateRPSButton<DocumentationMOView>( "5156819b-b19b-435f-9a6f-935c14fce6a3","","",this);
 
            CollectionInit params_MaintenanceOrderForDocumentationMO = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6ba73208-fbb7-4c40-b372-37162b950322",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceOrderForDocumentationMO = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceOrderForDocumentationMOCollectionEditor<DocumentationMOView>,DocumentationMOView>( params_MaintenanceOrderForDocumentationMO,this);
 
            MaintenanceOrder = RPSControlFactory.CreateRPSSection<DocumentationMOView>( "","ul li[rpsid='c10edea9-96fb-4959-a4fd-db10004fc346']","",this);
 

        }
        public IRPSButton<DocumentationMOView> ShowComponentAttachmentsButton { get; set; } 
        public MaintenanceOrderForDocumentationMOCollectionEditor<DocumentationMOView> MaintenanceOrderForDocumentationMO { get; set; } 
        public IRPSSection<DocumentationMOView> MaintenanceOrder { get; set; } 
        public ShopfloorDocumentation Screen { get; set; }
        public DocumentationMOView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaintenanceOrderForDocumentationMOCollectionEditor<DocumentationMOView>:RPSCollectionEditor<DocumentationMOView> where DocumentationMOView : class, IView
    {
        public  MaintenanceOrderForDocumentationMOGridView<DocumentationMOView> GridView {get;set;}
    }
    public partial class MaintenanceOrderForDocumentationMOGridView <DocumentationMOView> :  RPSGridView<DocumentationMOView> where DocumentationMOView : class, IView
    {
        public MaintenanceOrderForDocumentationMOGridView(DocumentationMOView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ShowMOAttachments = RPSControlFactory.CreateRPSGridButton<DocumentationMOView>( "","#6ba73208-fbb7-4c40-b372-37162b950322 .ag-row[role='row']@ROWINDEX [col-id='cShowMOAttachments']","",this.CurrentView);
 
            MaintenanceOrder_CreationDate = RPSControlFactory.CreateRPSGridTextBox<DocumentationMOView>("","#6ba73208-fbb7-4c40-b372-37162b950322 .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceOrder_CreationDate']","",false, this.CurrentView);
 

        }
        public IRPSGridButton<DocumentationMOView> ShowMOAttachments { get; set; } 
        public IRPSGridTextBox<DocumentationMOView> MaintenanceOrder_CreationDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class StatusLegendDialogView : View
    {
        public StatusLegendDialogView(ShopfloorDocumentation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_MaintenanceOrderStatusShopfloorCMMS = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3725af06-5720-4ff4-acd0-a0820e38d5b5",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceOrderStatusShopfloorCMMS = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceOrderStatusShopfloorCMMSCollectionEditor<StatusLegendDialogView>,StatusLegendDialogView>( params_MaintenanceOrderStatusShopfloorCMMS,this);
 

        }
        public MaintenanceOrderStatusShopfloorCMMSCollectionEditor<StatusLegendDialogView> MaintenanceOrderStatusShopfloorCMMS { get; set; } 
        public ShopfloorDocumentation Screen { get; set; }
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
            MaintenanceOrderStatus_CodStatus = RPSControlFactory.CreateRPSGridTextBox<StatusLegendDialogView>("","#3725af06-5720-4ff4-acd0-a0820e38d5b5 .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceOrderStatus_CodStatus']","",false, this.CurrentView);
 
            MaintenanceOrderStatus_Description = RPSControlFactory.CreateRPSGridTextBox<StatusLegendDialogView>("","#3725af06-5720-4ff4-acd0-a0820e38d5b5 .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceOrderStatus_Description']","",false, this.CurrentView);
 
            MaintenanceOrderStatus_ShowInShopfloorCMMS = RPSControlFactory.CreateRPSGridCheckBox<StatusLegendDialogView>("","#3725af06-5720-4ff4-acd0-a0820e38d5b5 .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceOrderStatus_ShowInShopfloorCMMS']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<StatusLegendDialogView> MaintenanceOrderStatus_CodStatus { get; set; } 
        public IRPSGridTextBox<StatusLegendDialogView> MaintenanceOrderStatus_Description { get; set; } 
        public IRPSGridCheckbox<StatusLegendDialogView> MaintenanceOrderStatus_ShowInShopfloorCMMS { get; set; } 
                     
    }
 
    }
  
    

}