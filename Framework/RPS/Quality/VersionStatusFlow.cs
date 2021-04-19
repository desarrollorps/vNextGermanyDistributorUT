    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Quality.VersionStatusFlow
{
    //RPS VERSION 1.0.0.0
    public partial class VersionStatusFlow:Screen
    {
        public VersionStatusFlow():base()
        {
            this.URL = "quality.versionstatusflow";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            VersionStatusFlowView  = new VersionStatusFlowView(this); 
            UserPasswordValidationDialogView  = new UserPasswordValidationDialogView(this); 
            ReassignActionUserDialogView  = new ReassignActionUserDialogView(this); 
            VersionStatusFlowView.InitializeControls(); 
            UserPasswordValidationDialogView.InitializeControls(); 
            ReassignActionUserDialogView.InitializeControls(); 
           
        }
      
            public VersionStatusFlowView VersionStatusFlowView {get; set; } 
            public UserPasswordValidationDialogView UserPasswordValidationDialogView {get; set; } 
            public ReassignActionUserDialogView ReassignActionUserDialogView {get; set; } 
    }
            
    public partial class VersionStatusFlowView : View
    {
        public VersionStatusFlowView(VersionStatusFlow screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CodUser = RPSControlFactory.CreateRPSComboBox<VersionStatusFlowView>("016009f2-5f2a-4c9d-b01f-1121a2127517","","",false, this);
 
            CodRole = RPSControlFactory.CreateRPSComboBox<VersionStatusFlowView>("a380f174-f821-429f-9c3a-3223b3888fb1","","",false, this);
 
            IDArticles = RPSControlFactory.CreateRPSCollectionComboBox<VersionStatusFlowView>("dafc8b03-1f49-4ee2-aa9f-c94ec3812aba","","",false, this);
 
            IDCustomer = RPSControlFactory.CreateRPSComboBox<VersionStatusFlowView>("e44adee6-6d51-4ea9-8c2c-678cce7c948c","","",false, this);
 
            IDSupplier = RPSControlFactory.CreateRPSComboBox<VersionStatusFlowView>("05020ad9-aa50-4cf9-b024-dd15bff019a3","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<VersionStatusFlowView>("7dc078e4-89ce-498b-8075-d035ed6a4a7b","","",false, this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<VersionStatusFlowView>("2dcd9855-f920-42d3-9bec-dc11fdbc9b74","","",false, this);
 
            IDQualityDocumentType = RPSControlFactory.CreateRPSComboBox<VersionStatusFlowView>("f6dab4f0-cbfb-4794-99d5-f02878926c32","","",false, this);
 
            IDStructure = RPSControlFactory.CreateRPSComboBox<VersionStatusFlowView>("5c5c1d55-614e-4395-8251-bc2d56c8fbac","","",false, this);
 
            IDTask = RPSControlFactory.CreateRPSComboBox<VersionStatusFlowView>("a895bd62-1015-4d43-bfc6-cba246217f3a","","",false, this);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<VersionStatusFlowView>("01b12f98-2ad8-4e9e-9c2e-6965ae364a1a","","",false, this);
 
            IDProjectTask = RPSControlFactory.CreateRPSComboBox<VersionStatusFlowView>("53e783e7-ea5c-48fa-a528-1752c6cd6c7f","","",false, this);
 
            IDManufacturingOrder = RPSControlFactory.CreateRPSComboBox<VersionStatusFlowView>("c5307c6b-5f6f-4777-8c8b-4b45114b051f","","",false, this);
 
            IDMOTask = RPSControlFactory.CreateRPSComboBox<VersionStatusFlowView>("eaa0ab12-eac6-4638-8de9-127952230773","","",false, this);
 
            IDDeliveryNote = RPSControlFactory.CreateRPSComboBox<VersionStatusFlowView>("572f5514-e4fe-4099-8465-15db8aee5108","","",false, this);
 
            IDDeliveryNoteSL = RPSControlFactory.CreateRPSComboBox<VersionStatusFlowView>("5ac775c5-f454-4d11-b4b8-eececf8f8a09","","",false, this);
 
            IDOrderSL = RPSControlFactory.CreateRPSComboBox<VersionStatusFlowView>("9b1f0ee7-c4c9-4211-b82a-dbff1e1930cf","","",false, this);
 
            ShowPending = RPSControlFactory.CreateRPSCheckBox<VersionStatusFlowView>("32ed0e5e-e5b6-49e8-85ee-8ae48939cd35","","",false, this);
 
            ShowRealizedActions = RPSControlFactory.CreateRPSCheckBox<VersionStatusFlowView>("7d13e7fe-423d-43ab-a6f3-22f1f7c5a60e","","",false, this);
 
            ShowProvisional = RPSControlFactory.CreateRPSCheckBox<VersionStatusFlowView>("aa22283f-acd6-4cb0-967e-5193cf7a9138","","",false, this);
 
            ShowRejections = RPSControlFactory.CreateRPSCheckBox<VersionStatusFlowView>("089949ac-f35f-4eb3-9009-1191a6beec91","","",false, this);
 
            Approve = RPSControlFactory.CreateRPSCheckBox<VersionStatusFlowView>("dbbb54f7-b78c-4cd4-a423-c251d9941b0e","","",false, this);
 
            Revise = RPSControlFactory.CreateRPSCheckBox<VersionStatusFlowView>("203f4e0f-727a-4a26-ab57-711410bfb795","","",false, this);
 
            Receipt = RPSControlFactory.CreateRPSCheckBox<VersionStatusFlowView>("b5f71683-e643-4898-b715-d921c23bc339","","",false, this);
 
            ExecuteGetVersionStatusFlow = RPSControlFactory.CreateRPSButton<VersionStatusFlowView>( "ead498ec-6b1c-4096-9869-f80951d59ea0","","",this);
 
            ExecuteRealizeActions = RPSControlFactory.CreateRPSButton<VersionStatusFlowView>( "e131538e-696d-4a1c-8c03-e34530abaf99","","",this);
 
            ReassignActionUserNavigationCommand = RPSControlFactory.CreateRPSButtonToView<VersionStatusFlowView,ReassignActionUserDialogView>("e6438349-f4bc-463f-aba2-a9dc3347f7ff","","", this,Screen.ReassignActionUserDialogView);
 
            ActionType = RPSControlFactory.CreateRPSTextBox<VersionStatusFlowView>("a5c5c8b3-5d65-4704-9c01-0fb13417078a","","",false, this);
 
            ActionOrder = RPSControlFactory.CreateRPSFormattedTextBox<VersionStatusFlowView>("66be6a5e-bccc-4283-a6d1-98d37b141680","","",false, this);
 
            DoneDate = RPSControlFactory.CreateRPSTextBox<VersionStatusFlowView>("dfca4c30-8e4d-4259-a0e1-f38916e6db38","","",false, this);
 
            RejectionReason = RPSControlFactory.CreateRPSTextBox<VersionStatusFlowView>("7c56ca08-1596-405a-bdd9-0bdb31559237","","",false, this);
 
            CollectionInit params_GetVersionStatusFlow = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="f351b921-4ae5-4f12-9ed6-9cd59b4718b5",CSSSelectorGrid="",XPathGrid=""};
            GetVersionStatusFlow = RPSControlFactory.RPSCreateCollectionWithGrid<GetVersionStatusFlowCollectionEditor<VersionStatusFlowView,UserPasswordValidationDialogView>,VersionStatusFlowView,UserPasswordValidationDialogView>( params_GetVersionStatusFlow,this,Screen.UserPasswordValidationDialogView);
 

        }
        public IRPSComboBox<VersionStatusFlowView> CodUser { get; set; } 
        public IRPSComboBox<VersionStatusFlowView> CodRole { get; set; } 
        public IRPSCollectionComboBox<VersionStatusFlowView> IDArticles { get; set; } 
        public IRPSComboBox<VersionStatusFlowView> IDCustomer { get; set; } 
        public IRPSComboBox<VersionStatusFlowView> IDSupplier { get; set; } 
        public IRPSTextBox<VersionStatusFlowView> DateFrom { get; set; } 
        public IRPSTextBox<VersionStatusFlowView> DateTo { get; set; } 
        public IRPSComboBox<VersionStatusFlowView> IDQualityDocumentType { get; set; } 
        public IRPSComboBox<VersionStatusFlowView> IDStructure { get; set; } 
        public IRPSComboBox<VersionStatusFlowView> IDTask { get; set; } 
        public IRPSComboBox<VersionStatusFlowView> IDProject { get; set; } 
        public IRPSComboBox<VersionStatusFlowView> IDProjectTask { get; set; } 
        public IRPSComboBox<VersionStatusFlowView> IDManufacturingOrder { get; set; } 
        public IRPSComboBox<VersionStatusFlowView> IDMOTask { get; set; } 
        public IRPSComboBox<VersionStatusFlowView> IDDeliveryNote { get; set; } 
        public IRPSComboBox<VersionStatusFlowView> IDDeliveryNoteSL { get; set; } 
        public IRPSComboBox<VersionStatusFlowView> IDOrderSL { get; set; } 
        public IRPSCheckbox<VersionStatusFlowView> ShowPending { get; set; } 
        public IRPSCheckbox<VersionStatusFlowView> ShowRealizedActions { get; set; } 
        public IRPSCheckbox<VersionStatusFlowView> ShowProvisional { get; set; } 
        public IRPSCheckbox<VersionStatusFlowView> ShowRejections { get; set; } 
        public IRPSCheckbox<VersionStatusFlowView> Approve { get; set; } 
        public IRPSCheckbox<VersionStatusFlowView> Revise { get; set; } 
        public IRPSCheckbox<VersionStatusFlowView> Receipt { get; set; } 
        public IRPSButton<VersionStatusFlowView> ExecuteGetVersionStatusFlow { get; set; } 
        public IRPSButton<VersionStatusFlowView> ExecuteRealizeActions { get; set; } 
        public IRPSButton<VersionStatusFlowView,ReassignActionUserDialogView> ReassignActionUserNavigationCommand { get; set; } 
        public IRPSTextBox<VersionStatusFlowView> ActionType { get; set; } 
        public IRPSTextBox<VersionStatusFlowView> ActionOrder { get; set; } 
        public IRPSTextBox<VersionStatusFlowView> DoneDate { get; set; } 
        public IRPSTextBox<VersionStatusFlowView> RejectionReason { get; set; } 
        public GetVersionStatusFlowCollectionEditor<VersionStatusFlowView,UserPasswordValidationDialogView> GetVersionStatusFlow { get; set; } 
        public VersionStatusFlow Screen { get; set; }
        public VersionStatusFlowView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetVersionStatusFlowCollectionEditor<VersionStatusFlowView,UserPasswordValidationDialogView>:RPSCollectionEditor<VersionStatusFlowView,UserPasswordValidationDialogView> where VersionStatusFlowView : class, IView where UserPasswordValidationDialogView : class, IView
    {
        public  GetVersionStatusFlowGridView<VersionStatusFlowView,UserPasswordValidationDialogView> GridView {get;set;}
    }
    public partial class GetVersionStatusFlowGridView <VersionStatusFlowView,UserPasswordValidationDialogView> :  RPSGridView<VersionStatusFlowView,UserPasswordValidationDialogView> where VersionStatusFlowView : class, IView where UserPasswordValidationDialogView : class, IView
    {
        public GetVersionStatusFlowGridView(VersionStatusFlowView currentView,UserPasswordValidationDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ActionType = RPSControlFactory.CreateRPSGridTextBox<VersionStatusFlowView>("","#f351b921-4ae5-4f12-9ed6-9cd59b4718b5 .ag-row[role='row']@ROWINDEX [col-id='cActionType']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<VersionStatusFlowView> ActionType { get; set; } 
                     
    }
 
    }
  
            
    public partial class UserPasswordValidationDialogView : View
    {
        public UserPasswordValidationDialogView(VersionStatusFlow screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Password = RPSControlFactory.CreateRPSTextBox<UserPasswordValidationDialogView>("6de2e864-2fe9-47c9-876c-6dbed60f298a","","",true, this);
 
            ExecuteCheckUserPassword = RPSControlFactory.CreateRPSButton<UserPasswordValidationDialogView>( "34d66900-c36f-4ff3-9433-64c56913b7c9","","",this);
 

        }
        public IRPSTextBox<UserPasswordValidationDialogView> Password { get; set; } 
        public IRPSButton<UserPasswordValidationDialogView> ExecuteCheckUserPassword { get; set; } 
        public VersionStatusFlow Screen { get; set; }
        public UserPasswordValidationDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ReassignActionUserDialogView : View
    {
        public ReassignActionUserDialogView(VersionStatusFlow screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            User = RPSControlFactory.CreateRPSComboBox<ReassignActionUserDialogView>("de8cda2f-0e5f-49f5-8360-aa861bdf1678","","",true, this);
 

        }
        public IRPSComboBox<ReassignActionUserDialogView> User { get; set; } 
        public VersionStatusFlow Screen { get; set; }
        public ReassignActionUserDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}