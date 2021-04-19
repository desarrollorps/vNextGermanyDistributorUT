    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.ShopFloorCMMS.TicketRequest
{
    //RPS VERSION 1.0.0.0
    public partial class TicketRequest:Screen
    {
        public TicketRequest():base()
        {
            this.URL = "shopfloorcmms.ticketrequest";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MaintenanceWarningVMQueryView  = new MaintenanceWarningVMQueryView(this); 
            MaintenanceWarningVMEntityView  = new MaintenanceWarningVMEntityView(this); 
            NewWorkOrderDialogView  = new NewWorkOrderDialogView(this); 
            StatusLegendDialogView  = new StatusLegendDialogView(this); 
            MaintenanceWarningVMQueryView.InitializeControls(); 
            MaintenanceWarningVMEntityView.InitializeControls(); 
            NewWorkOrderDialogView.InitializeControls(); 
            StatusLegendDialogView.InitializeControls(); 
           
        }
      
            public MaintenanceWarningVMQueryView MaintenanceWarningVMQueryView {get; set; } 
            public MaintenanceWarningVMEntityView MaintenanceWarningVMEntityView {get; set; } 
            public NewWorkOrderDialogView NewWorkOrderDialogView {get; set; } 
            public StatusLegendDialogView StatusLegendDialogView {get; set; } 
    }
            
    public partial class MaintenanceWarningVMQueryView : View
    {
        public MaintenanceWarningVMQueryView(TicketRequest screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<MaintenanceWarningVMQueryView,MaintenanceWarningVMEntityView>( this,Screen.MaintenanceWarningVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<MaintenanceWarningVMQueryView>( this);
 
            OnlyPending = RPSControlFactory.CreateRPSCheckBox<MaintenanceWarningVMQueryView>("05a3c35d-233f-4cc1-a174-33d7c2ce3e50","","",false, this);
 
            IDMaintenanceWarningStatus = RPSControlFactory.CreateRPSCollectionComboBox<MaintenanceWarningVMQueryView>("d59106c7-4453-4754-99e1-13dd23531a23","","",false, this);
 
            IDEmployeeReportedBy = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningVMQueryView>("04cb5f04-f0f4-4f15-ac1e-dd6bade528da","","",false, this);
 
            IDTerminal = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningVMQueryView>("7fc6543c-d3a1-44bb-898e-a03edd129f4d","","",false, this);
 
            IDMaintenanceComponent = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningVMQueryView>("80078afa-5b46-4e2c-8983-a4626e50c095","","",false, this);
 
            SelectEmployeeMessage = RPSControlFactory.CreateRPSTextBox<MaintenanceWarningVMQueryView>("5fca0108-bd33-44ed-b967-db76dd7c1288","","",false, this);
 
            SelectMaintenanceWorkerNavigationCommandButton = RPSControlFactory.CreateRPSButton<MaintenanceWarningVMQueryView>( "cc8c01da-bbfb-41a5-b400-01d9419fff20","","",this);
 
            WOFollowupNavigationCommandButton = RPSControlFactory.CreateRPSButton<MaintenanceWarningVMQueryView>( "291978cd-7ad7-48d7-aa04-7c6e17526e3c","","",this);
 
            MOHistoricNavigationCommandButton = RPSControlFactory.CreateRPSButton<MaintenanceWarningVMQueryView>( "af4f68be-084d-4416-b3ee-1577711c3779","","",this);
 
            MaterialStockLocatorNavigationCommandButton = RPSControlFactory.CreateRPSButton<MaintenanceWarningVMQueryView>( "a2dd4f3d-fd6f-4d16-904b-9089dd48312f","","",this);
 
            ShopfloorDocumentationNavigationCommandButton = RPSControlFactory.CreateRPSButton<MaintenanceWarningVMQueryView>( "678df1ea-5be6-453c-b323-02b3a696cf58","","",this);
 
            CollectionInit params_MaintenanceWarningShopfloorCMMS = new CollectionInit(){IDDescriptor = "5a311388-077d-489a-8a45-0c338fa04fb1",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="aef21e6b-cbf5-409e-9e49-8285bdd9adc6",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceWarningShopfloorCMMS = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceWarningShopfloorCMMSCollectionEditor<MaintenanceWarningVMQueryView,MaintenanceWarningVMEntityView>,MaintenanceWarningVMQueryView,MaintenanceWarningVMEntityView>( params_MaintenanceWarningShopfloorCMMS,this,Screen.MaintenanceWarningVMEntityView);
 

        }
        public IRPSButton<MaintenanceWarningVMQueryView,MaintenanceWarningVMEntityView> NewButton { get; set; } 
        public IRPSButton<MaintenanceWarningVMQueryView> ConsultButton { get; set; } 
        public IRPSCheckbox<MaintenanceWarningVMQueryView> OnlyPending { get; set; } 
        public IRPSCollectionComboBox<MaintenanceWarningVMQueryView> IDMaintenanceWarningStatus { get; set; } 
        public IRPSComboBox<MaintenanceWarningVMQueryView> IDEmployeeReportedBy { get; set; } 
        public IRPSComboBox<MaintenanceWarningVMQueryView> IDTerminal { get; set; } 
        public IRPSComboBox<MaintenanceWarningVMQueryView> IDMaintenanceComponent { get; set; } 
        public IRPSTextBox<MaintenanceWarningVMQueryView> SelectEmployeeMessage { get; set; } 
        public IRPSButton<MaintenanceWarningVMQueryView> SelectMaintenanceWorkerNavigationCommandButton { get; set; } 
        public IRPSButton<MaintenanceWarningVMQueryView> WOFollowupNavigationCommandButton { get; set; } 
        public IRPSButton<MaintenanceWarningVMQueryView> MOHistoricNavigationCommandButton { get; set; } 
        public IRPSButton<MaintenanceWarningVMQueryView> MaterialStockLocatorNavigationCommandButton { get; set; } 
        public IRPSButton<MaintenanceWarningVMQueryView> ShopfloorDocumentationNavigationCommandButton { get; set; } 
        public MaintenanceWarningShopfloorCMMSCollectionEditor<MaintenanceWarningVMQueryView,MaintenanceWarningVMEntityView> MaintenanceWarningShopfloorCMMS { get; set; } 
        public TicketRequest Screen { get; set; }
        public MaintenanceWarningVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaintenanceWarningShopfloorCMMSCollectionEditor<MaintenanceWarningVMQueryView,MaintenanceWarningVMEntityView>:RPSCollectionEditor<MaintenanceWarningVMQueryView,MaintenanceWarningVMEntityView> where MaintenanceWarningVMQueryView : class, IView where MaintenanceWarningVMEntityView : class, IView
    {
        public  MaintenanceWarningShopfloorCMMSGridView<MaintenanceWarningVMQueryView,MaintenanceWarningVMEntityView> GridView {get;set;}
    }
    public partial class MaintenanceWarningShopfloorCMMSGridView <MaintenanceWarningVMQueryView,MaintenanceWarningVMEntityView> :  RPSGridView<MaintenanceWarningVMQueryView,MaintenanceWarningVMEntityView> where MaintenanceWarningVMQueryView : class, IView where MaintenanceWarningVMEntityView : class, IView
    {
        public MaintenanceWarningShopfloorCMMSGridView(MaintenanceWarningVMQueryView currentView,MaintenanceWarningVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MaintenanceWarning_EntryDate = RPSControlFactory.CreateRPSGridTextBox<MaintenanceWarningVMQueryView>("","#aef21e6b-cbf5-409e-9e49-8285bdd9adc6 .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceWarning_EntryDate']","",false, this.CurrentView);
 
            MaintenanceWarning_ClosingDate = RPSControlFactory.CreateRPSGridTextBox<MaintenanceWarningVMQueryView>("","#aef21e6b-cbf5-409e-9e49-8285bdd9adc6 .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceWarning_ClosingDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MaintenanceWarningVMQueryView> MaintenanceWarning_EntryDate { get; set; } 
        public IRPSGridTextBox<MaintenanceWarningVMQueryView> MaintenanceWarning_ClosingDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class MaintenanceWarningVMEntityView : View
    {
        public MaintenanceWarningVMEntityView(TicketRequest screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MaintenanceWarningVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<MaintenanceWarningVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MaintenanceWarningVMEntityView,MaintenanceWarningVMQueryView>( this,Screen.MaintenanceWarningVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<MaintenanceWarningVMEntityView,MaintenanceWarningVMQueryView>( this,Screen.MaintenanceWarningVMQueryView);
 
            CodMaintenanceWarning = RPSControlFactory.CreateRPSTextBox<MaintenanceWarningVMEntityView>("763d8d86-f85d-4bce-8edb-6553de5051ae","","",false, this);
 
            IDTerminal = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningVMEntityView>("85377e59-0482-4e3f-be56-4a0efe2ad6e4","","",false, this);
 
            IDMaintenanceComponent = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningVMEntityView>("b9c6c450-df49-4bd3-930c-f46d370f2744","","",true, this);
 
            IDEmployeeReportedBy = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningVMEntityView>("04278109-6e48-4122-92be-c6714d8036bc","","",false, this);
 
            IDMaintenanceWarningType = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningVMEntityView>("ef83c49c-a97a-4689-8aac-d6015e2cf086","","",false, this);
 
            IDMaintenanceWarningStatus = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningVMEntityView>("57629a5b-f696-4213-a181-b4a1cbbf5324","","",true, this);
 
            IDMaintenanceWarningSeverity = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningVMEntityView>("e2978407-fa61-444b-9643-7a69b4729ef7","","",true, this);
 
            IDMaintenanceWarningPriority = RPSControlFactory.CreateRPSComboBox<MaintenanceWarningVMEntityView>("e440c357-0122-4e70-8d1c-8a463993dfb5","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MaintenanceWarningVMEntityView>("52ae85de-afa4-4991-b3b9-92a13debeb51","","",false, this);
 
            StatusLegendNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<MaintenanceWarningVMEntityView,StatusLegendDialogView>("0f477f3e-db36-4d20-a06c-7ceddbc90a7f","","", this,Screen.StatusLegendDialogView);
 
            NewWorkOrderNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<MaintenanceWarningVMEntityView,NewWorkOrderDialogView>("e8e2247f-4754-4db6-b2c4-e5aee6c80f8f","","", this,Screen.NewWorkOrderDialogView);
 
            SelectMaintenanceWorkerNavigationCommandButton = RPSControlFactory.CreateRPSButton<MaintenanceWarningVMEntityView>( "67786eb7-fe43-4ef4-9f7e-f80c029a565f","","",this);
 
            MOFollowNavigationCommandButton = RPSControlFactory.CreateRPSButton<MaintenanceWarningVMEntityView>( "65921943-f5a9-4284-afe3-26db1d5f6af2","","",this);
 
            MOHistoricNavigationCommandButton = RPSControlFactory.CreateRPSButton<MaintenanceWarningVMEntityView>( "10382743-9c0e-42d0-9b41-574789387243","","",this);
 
            MaterialStockLocatorNavigationCommandButton = RPSControlFactory.CreateRPSButton<MaintenanceWarningVMEntityView>( "cb19302c-e654-4610-904a-b0fb9599f685","","",this);
 
            ShopfloorDocumentationNavigationCommandButton = RPSControlFactory.CreateRPSButton<MaintenanceWarningVMEntityView>( "8030a126-61c4-41fd-a2b2-3d154f1fa9ab","","",this);
 
            CollectionInit params_MaintenanceOrderOpenForShopfloorCMMS = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="25f30bec-347c-4c49-a0e9-9fe2a63e3884",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceOrderOpenForShopfloorCMMS = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceOrderOpenForShopfloorCMMSCollectionEditor<MaintenanceWarningVMEntityView,NewWorkOrderDialogView>,MaintenanceWarningVMEntityView,NewWorkOrderDialogView>( params_MaintenanceOrderOpenForShopfloorCMMS,this,Screen.NewWorkOrderDialogView);
 

        }
        public IRPSSaveButton<MaintenanceWarningVMEntityView> SaveButton { get; set; } 
        public IRPSButton<MaintenanceWarningVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<MaintenanceWarningVMEntityView,MaintenanceWarningVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MaintenanceWarningVMEntityView,MaintenanceWarningVMQueryView> BackButton { get; set; } 
        public IRPSTextBox<MaintenanceWarningVMEntityView> CodMaintenanceWarning { get; set; } 
        public IRPSComboBox<MaintenanceWarningVMEntityView> IDTerminal { get; set; } 
        public IRPSComboBox<MaintenanceWarningVMEntityView> IDMaintenanceComponent { get; set; } 
        public IRPSComboBox<MaintenanceWarningVMEntityView> IDEmployeeReportedBy { get; set; } 
        public IRPSComboBox<MaintenanceWarningVMEntityView> IDMaintenanceWarningType { get; set; } 
        public IRPSComboBox<MaintenanceWarningVMEntityView> IDMaintenanceWarningStatus { get; set; } 
        public IRPSComboBox<MaintenanceWarningVMEntityView> IDMaintenanceWarningSeverity { get; set; } 
        public IRPSComboBox<MaintenanceWarningVMEntityView> IDMaintenanceWarningPriority { get; set; } 
        public IRPSTextBox<MaintenanceWarningVMEntityView> Description { get; set; } 
        public IRPSButton<MaintenanceWarningVMEntityView,StatusLegendDialogView> StatusLegendNavigationCommandButton { get; set; } 
        public IRPSButton<MaintenanceWarningVMEntityView,NewWorkOrderDialogView> NewWorkOrderNavigationCommandButton { get; set; } 
        public IRPSButton<MaintenanceWarningVMEntityView> SelectMaintenanceWorkerNavigationCommandButton { get; set; } 
        public IRPSButton<MaintenanceWarningVMEntityView> MOFollowNavigationCommandButton { get; set; } 
        public IRPSButton<MaintenanceWarningVMEntityView> MOHistoricNavigationCommandButton { get; set; } 
        public IRPSButton<MaintenanceWarningVMEntityView> MaterialStockLocatorNavigationCommandButton { get; set; } 
        public IRPSButton<MaintenanceWarningVMEntityView> ShopfloorDocumentationNavigationCommandButton { get; set; } 
        public MaintenanceOrderOpenForShopfloorCMMSCollectionEditor<MaintenanceWarningVMEntityView,NewWorkOrderDialogView> MaintenanceOrderOpenForShopfloorCMMS { get; set; } 
        public TicketRequest Screen { get; set; }
        public MaintenanceWarningVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaintenanceOrderOpenForShopfloorCMMSCollectionEditor<MaintenanceWarningVMEntityView,NewWorkOrderDialogView>:RPSCollectionEditor<MaintenanceWarningVMEntityView,NewWorkOrderDialogView> where MaintenanceWarningVMEntityView : class, IView where NewWorkOrderDialogView : class, IView
    {
        public  MaintenanceOrderOpenForShopfloorCMMSGridView<MaintenanceWarningVMEntityView,NewWorkOrderDialogView> GridView {get;set;}
    }
    public partial class MaintenanceOrderOpenForShopfloorCMMSGridView <MaintenanceWarningVMEntityView,NewWorkOrderDialogView> :  RPSGridView<MaintenanceWarningVMEntityView,NewWorkOrderDialogView> where MaintenanceWarningVMEntityView : class, IView where NewWorkOrderDialogView : class, IView
    {
        public MaintenanceOrderOpenForShopfloorCMMSGridView(MaintenanceWarningVMEntityView currentView,NewWorkOrderDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MaintenanceOrder_Description = RPSControlFactory.CreateRPSGridMemoTextBox<MaintenanceWarningVMEntityView>("","#25f30bec-347c-4c49-a0e9-9fe2a63e3884 .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceOrder_Description']","",false, this.CurrentView);
 
            MaintenanceOrder_CreationDate = RPSControlFactory.CreateRPSGridTextBox<MaintenanceWarningVMEntityView>("","#25f30bec-347c-4c49-a0e9-9fe2a63e3884 .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceOrder_CreationDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MaintenanceWarningVMEntityView> MaintenanceOrder_Description { get; set; } 
        public IRPSGridTextBox<MaintenanceWarningVMEntityView> MaintenanceOrder_CreationDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class NewWorkOrderDialogView : View
    {
        public NewWorkOrderDialogView(TicketRequest screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIDlgOrderExecutionDate = RPSControlFactory.CreateRPSTextBox<NewWorkOrderDialogView>("16471ee5-4552-4fbd-abd8-260b7db17dae","","",true, this);
 
            UIDlgOrderExecutionTime = RPSControlFactory.CreateRPSTextBox<NewWorkOrderDialogView>("153409d4-1410-4f15-9084-3b9c5ac0e3c7","","",false, this);
 
            UIDlgOrderDurationTime = RPSControlFactory.CreateRPSDurationTextBox<NewWorkOrderDialogView>("5c102b81-9359-4162-800b-f6e6f92d681a","","",true, this);
 
            UIDlgOrderMaintenanceType = RPSControlFactory.CreateRPSComboBox<NewWorkOrderDialogView>("6942b4a5-ff2e-46e7-96ad-ae9208be3456","","",true, this);
 
            UIDlgOrderResponsibleType = RPSControlFactory.CreateRPSEnumComboBox<NewWorkOrderDialogView>("5a376f43-d5b1-4fb9-b3b7-80cc9b32bad0","","",false, this);
 
            UIDlgOrderQualify = RPSControlFactory.CreateRPSComboBox<NewWorkOrderDialogView>("d7f42255-f713-496f-9ad9-9753994165aa","","",true, this);
 
            UIDlgOrderMaintenanceType1 = RPSControlFactory.CreateRPSComboBox<NewWorkOrderDialogView>("332cda6d-b010-4f37-9bb3-57199ee6c28a","","",true, this);
 
            UIDlgOrderResponsibleType1 = RPSControlFactory.CreateRPSEnumComboBox<NewWorkOrderDialogView>("e227fa21-8948-4cb7-9156-4cb2664ba016","","",false, this);
 
            UIDlgOrderEmployee = RPSControlFactory.CreateRPSComboBox<NewWorkOrderDialogView>("1493be64-966e-4b64-9083-221d9ad0a3f7","","",true, this);
 
            UIDlgOrderMaintenanceType2 = RPSControlFactory.CreateRPSComboBox<NewWorkOrderDialogView>("f4957911-3308-4199-9eff-94e1e5bb154a","","",true, this);
 
            UIDlgOrderResponsibleType2 = RPSControlFactory.CreateRPSEnumComboBox<NewWorkOrderDialogView>("811db794-b7d4-4130-97e3-f7a09569f8bd","","",false, this);
 
            UIDlgOrderSupplier = RPSControlFactory.CreateRPSComboBox<NewWorkOrderDialogView>("8ec45547-81b0-43c0-a10f-14d272761774","","",true, this);
 
            OTDescription = RPSControlFactory.CreateRPSTextBox<NewWorkOrderDialogView>("30c3fb2c-1a93-4602-8095-05642f80e290","","",false, this);
 

        }
        public IRPSTextBox<NewWorkOrderDialogView> UIDlgOrderExecutionDate { get; set; } 
        public IRPSTextBox<NewWorkOrderDialogView> UIDlgOrderExecutionTime { get; set; } 
        public IRPSDurationTextBox<NewWorkOrderDialogView> UIDlgOrderDurationTime { get; set; } 
        public IRPSComboBox<NewWorkOrderDialogView> UIDlgOrderMaintenanceType { get; set; } 
        public IRPSComboBox<NewWorkOrderDialogView> UIDlgOrderResponsibleType { get; set; } 
        public IRPSComboBox<NewWorkOrderDialogView> UIDlgOrderQualify { get; set; } 
        public IRPSComboBox<NewWorkOrderDialogView> UIDlgOrderMaintenanceType1 { get; set; } 
        public IRPSComboBox<NewWorkOrderDialogView> UIDlgOrderResponsibleType1 { get; set; } 
        public IRPSComboBox<NewWorkOrderDialogView> UIDlgOrderEmployee { get; set; } 
        public IRPSComboBox<NewWorkOrderDialogView> UIDlgOrderMaintenanceType2 { get; set; } 
        public IRPSComboBox<NewWorkOrderDialogView> UIDlgOrderResponsibleType2 { get; set; } 
        public IRPSComboBox<NewWorkOrderDialogView> UIDlgOrderSupplier { get; set; } 
        public IRPSTextBox<NewWorkOrderDialogView> OTDescription { get; set; } 
        public TicketRequest Screen { get; set; }
        public NewWorkOrderDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class StatusLegendDialogView : View
    {
        public StatusLegendDialogView(TicketRequest screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_MaintenanceOrderStatusShopfloorCMMS = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c8b8c7d5-c74e-493b-b135-c6aea0c590d2",CSSSelectorGrid="",XPathGrid=""};
            MaintenanceOrderStatusShopfloorCMMS = RPSControlFactory.RPSCreateCollectionWithGrid<MaintenanceOrderStatusShopfloorCMMSCollectionEditor<StatusLegendDialogView>,StatusLegendDialogView>( params_MaintenanceOrderStatusShopfloorCMMS,this);
 

        }
        public MaintenanceOrderStatusShopfloorCMMSCollectionEditor<StatusLegendDialogView> MaintenanceOrderStatusShopfloorCMMS { get; set; } 
        public TicketRequest Screen { get; set; }
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
            MaintenanceOrderStatus_CodStatus = RPSControlFactory.CreateRPSGridTextBox<StatusLegendDialogView>("","#c8b8c7d5-c74e-493b-b135-c6aea0c590d2 .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceOrderStatus_CodStatus']","",false, this.CurrentView);
 
            MaintenanceOrderStatus_Description = RPSControlFactory.CreateRPSGridTextBox<StatusLegendDialogView>("","#c8b8c7d5-c74e-493b-b135-c6aea0c590d2 .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceOrderStatus_Description']","",false, this.CurrentView);
 
            MaintenanceOrderStatus_ShowInShopfloorCMMS = RPSControlFactory.CreateRPSGridCheckBox<StatusLegendDialogView>("","#c8b8c7d5-c74e-493b-b135-c6aea0c590d2 .ag-row[role='row']@ROWINDEX [col-id='cMaintenanceOrderStatus_ShowInShopfloorCMMS']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<StatusLegendDialogView> MaintenanceOrderStatus_CodStatus { get; set; } 
        public IRPSGridTextBox<StatusLegendDialogView> MaintenanceOrderStatus_Description { get; set; } 
        public IRPSGridCheckbox<StatusLegendDialogView> MaintenanceOrderStatus_ShowInShopfloorCMMS { get; set; } 
                     
    }
 
    }
  
    

}