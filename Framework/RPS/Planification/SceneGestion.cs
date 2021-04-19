    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Planification.SceneGestion
{
    //RPS VERSION 1.0.0.0
    public partial class SceneGestion:Screen
    {
        public SceneGestion():base()
        {
            this.URL = "planification.scenegestion";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            SceneGestionView  = new SceneGestionView(this); 
            GenerateManufacturingOrderDialogView  = new GenerateManufacturingOrderDialogView(this); 
            GeneratePurchaseProposalDialogView  = new GeneratePurchaseProposalDialogView(this); 
            SceneGestionView.InitializeControls(); 
            GenerateManufacturingOrderDialogView.InitializeControls(); 
            GeneratePurchaseProposalDialogView.InitializeControls(); 
           
        }
      
            public SceneGestionView SceneGestionView {get; set; } 
            public GenerateManufacturingOrderDialogView GenerateManufacturingOrderDialogView {get; set; } 
            public GeneratePurchaseProposalDialogView GeneratePurchaseProposalDialogView {get; set; } 
    }
            
    public partial class SceneGestionView : View
    {
        public SceneGestionView(SceneGestion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIScene = RPSControlFactory.CreateRPSComboBox<SceneGestionView>("04c08ad8-a5f0-47b2-8214-2e1684ed9640","","",false, this);
 
            UIOptGetDataFromReal = RPSControlFactory.CreateRPSOption<SceneGestionView>( "f5e92974-66bd-4122-bbc1-ffbccec8f1b1","","",this);
 
            UIOptKeepData = RPSControlFactory.CreateRPSOption<SceneGestionView>( "9a7be667-b843-4b17-b947-3fc5639d7e9e","","",this);
 
            UIOptDeleteData = RPSControlFactory.CreateRPSOption<SceneGestionView>( "2507a946-7567-4870-926f-937147dc0a90","","",this);
 
            UIOptDeleteSceneData = RPSControlFactory.CreateRPSOption<SceneGestionView>( "a90be334-9320-4734-ba38-fbba88e001cb","","",this);
 
            UIIncludeSceneDeleting = RPSControlFactory.CreateRPSCheckBox<SceneGestionView>("371cff54-ce60-450b-a14e-1ad75330dfa7","","",false, this);
 
            UIOptCopySceneDataToReal = RPSControlFactory.CreateRPSOption<SceneGestionView>( "08aff71b-4e64-47f9-b416-d36658f56297","","",this);
 
            UIOptCopyDataOtherScene = RPSControlFactory.CreateRPSOption<SceneGestionView>( "ad828996-90e7-44e6-826a-5609d622a151","","",this);
 
            UISceneDestination = RPSControlFactory.CreateRPSComboBox<SceneGestionView>("76983a99-e5d9-4c79-b715-199f9c946949","","",false, this);
 
            UIOptAll = RPSControlFactory.CreateRPSOption<SceneGestionView>( "25cfea1a-21b9-4edf-9cd4-ec2b76922589","","",this);
 
            UIOptSelection = RPSControlFactory.CreateRPSOption<SceneGestionView>( "efa762de-08e8-40ee-8843-39d97f980f52","","",this);
 
            UICalendars = RPSControlFactory.CreateRPSCheckBox<SceneGestionView>("89774988-c521-4827-a638-46fbc5076ee5","","",false, this);
 
            UIProjects = RPSControlFactory.CreateRPSCheckBox<SceneGestionView>("30e7a415-77f8-4dbe-8a2e-a809acdf17dc","","",false, this);
 
            UIManufacturingPrevisions = RPSControlFactory.CreateRPSCheckBox<SceneGestionView>("eb584cd3-d396-4695-a7ba-c82ef43c43c5","","",false, this);
 
            UIResourcePlanning = RPSControlFactory.CreateRPSCheckBox<SceneGestionView>("8750b273-f2de-4ba6-a67d-f045d010c664","","",false, this);
 
            UIResources = RPSControlFactory.CreateRPSCheckBox<SceneGestionView>("18e5407f-bfe2-433a-a0f8-8bc9346c6e1f","","",false, this);
 
            UIManufacturingOrders = RPSControlFactory.CreateRPSCheckBox<SceneGestionView>("f02cf50c-8ad5-4c30-a9c6-5304a8679e69","","",false, this);
 
            UISalesPrevisions = RPSControlFactory.CreateRPSCheckBox<SceneGestionView>("b28cdfee-3a76-4bbd-a2c4-b638b980f53f","","",false, this);
 
            UIDependencies = RPSControlFactory.CreateRPSCheckBox<SceneGestionView>("a59c0337-fe54-4e50-b1a8-0198fea36edc","","",false, this);
 
            UIMaintenanceOrders = RPSControlFactory.CreateRPSCheckBox<SceneGestionView>("702296ce-512c-4c6a-9070-9e373083fc5f","","",false, this);
 
            UIPurchaseProposals = RPSControlFactory.CreateRPSCheckBox<SceneGestionView>("b88362cf-9676-4cb8-8358-1243b604f0eb","","",false, this);
 
            UIResourceStops = RPSControlFactory.CreateRPSCheckBox<SceneGestionView>("2b2b10f0-e7f4-4658-a528-38fb7e6b57c6","","",false, this);
 
            ConsultCommand = RPSControlFactory.CreateRPSButton<SceneGestionView>( "f60cbb55-af4f-4db0-9998-270d1a8c4611","","",this);
 
            DeleteSceneGestionManufacturingOrderCommandButton = RPSControlFactory.CreateRPSButton<SceneGestionView>( "872ba33c-d378-4d9b-8b3b-54ab20bf6628","","",this);
 
            GenerateManufacturingOrderNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<SceneGestionView,GenerateManufacturingOrderDialogView>("4b975fda-e251-4ea6-98f6-d19335b89003","","", this,Screen.GenerateManufacturingOrderDialogView);
 
            DeleteSceneGestionPurchaseProposalCommandButton = RPSControlFactory.CreateRPSButton<SceneGestionView>( "5c92a74d-126c-4c52-9d42-613eacd69e91","","",this);
 
            GeneratePurchaseProposalNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<SceneGestionView,GeneratePurchaseProposalDialogView>("b5e1279a-ba5b-43af-8147-760cdef6a7fd","","", this,Screen.GeneratePurchaseProposalDialogView);
 
            DeleteSceneGestionProjectCommandButton = RPSControlFactory.CreateRPSButton<SceneGestionView>( "1d0bfc98-9c1b-464e-8a86-fd970a0deb26","","",this);
 
            DeleteSceneGestionMaintenanceOrderCommandButton = RPSControlFactory.CreateRPSButton<SceneGestionView>( "37217276-01eb-4067-8331-4fe8d4c91082","","",this);
 
            SaveCommandButton = RPSControlFactory.CreateRPSButton<SceneGestionView>( "90851ac9-18f0-40d4-8752-fc941a7afc51","","",this);
 
            GenerateDataCommandButton = RPSControlFactory.CreateRPSButton<SceneGestionView>( "5b187233-1e41-42dd-8d15-af134f00bc6f","","",this);
 
            CollectionInit params_GetSceneGestionManufacturingOrderData = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="7c59d3ed-7310-413d-932c-040d4ce229ca",CSSSelectorGrid="",XPathGrid=""};
            GetSceneGestionManufacturingOrderData = RPSControlFactory.RPSCreateCollectionWithGrid<GetSceneGestionManufacturingOrderDataCollectionEditor<SceneGestionView,GenerateManufacturingOrderDialogView>,SceneGestionView,GenerateManufacturingOrderDialogView>( params_GetSceneGestionManufacturingOrderData,this,Screen.GenerateManufacturingOrderDialogView);
 
            CollectionInit params_GetSceneGestionPurchaseProposalData = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="3a99b6c9-d4fe-43e0-ac5c-3447a8c7773f",CSSSelectorGrid="",XPathGrid=""};
            GetSceneGestionPurchaseProposalData = RPSControlFactory.RPSCreateCollectionWithGrid<GetSceneGestionPurchaseProposalDataCollectionEditor<SceneGestionView,GenerateManufacturingOrderDialogView>,SceneGestionView,GenerateManufacturingOrderDialogView>( params_GetSceneGestionPurchaseProposalData,this,Screen.GenerateManufacturingOrderDialogView);
 
            CollectionInit params_GetSceneGestionProjectData = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="e5dd2b60-c5c4-47b9-a6e2-eaf24c1dac8a",CSSSelectorGrid="",XPathGrid=""};
            GetSceneGestionProjectData = RPSControlFactory.RPSCreateCollectionWithGrid<GetSceneGestionProjectDataCollectionEditor<SceneGestionView,GenerateManufacturingOrderDialogView>,SceneGestionView,GenerateManufacturingOrderDialogView>( params_GetSceneGestionProjectData,this,Screen.GenerateManufacturingOrderDialogView);
 
            CollectionInit params_GetSceneGestionMaintenanceOrderData = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8bb505b8-fb7b-40e8-a172-7e4ba853cb7d",CSSSelectorGrid="",XPathGrid=""};
            GetSceneGestionMaintenanceOrderData = RPSControlFactory.RPSCreateCollectionWithGrid<GetSceneGestionMaintenanceOrderDataCollectionEditor<SceneGestionView,GenerateManufacturingOrderDialogView>,SceneGestionView,GenerateManufacturingOrderDialogView>( params_GetSceneGestionMaintenanceOrderData,this,Screen.GenerateManufacturingOrderDialogView);
 
            CollectionInit params_GetSceneGestionResourceData = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c2a81a5f-b377-49f9-a9d4-ee1df08939d7",CSSSelectorGrid="",XPathGrid=""};
            GetSceneGestionResourceData = RPSControlFactory.RPSCreateCollectionWithGrid<GetSceneGestionResourceDataCollectionEditor<SceneGestionView,GenerateManufacturingOrderDialogView>,SceneGestionView,GenerateManufacturingOrderDialogView>( params_GetSceneGestionResourceData,this,Screen.GenerateManufacturingOrderDialogView);
 
            ManufacturingOrder = RPSControlFactory.CreateRPSSection<SceneGestionView>( "","ul li[rpsid='2e6799ca-696c-4a7e-8b3b-6c5b65abb3b9']","",this);
 
            PurchaseProposal = RPSControlFactory.CreateRPSSection<SceneGestionView>( "","ul li[rpsid='7bc4e69a-fa7b-4af7-ad09-28d49a3d5afc']","",this);
 
            Project = RPSControlFactory.CreateRPSSection<SceneGestionView>( "","ul li[rpsid='b487bea0-b8e2-458b-ada6-94c2798c4627']","",this);
 
            MaintenanceOrder = RPSControlFactory.CreateRPSSection<SceneGestionView>( "","ul li[rpsid='2738942b-1ddc-494d-b2d4-3e0fdf915772']","",this);
 
            Resources = RPSControlFactory.CreateRPSSection<SceneGestionView>( "","ul li[rpsid='249a5741-3c68-460b-8dc8-1717e9b5fed7']","",this);
 

        }
        public IRPSComboBox<SceneGestionView> UIScene { get; set; } 
        public IRPSOption<SceneGestionView> UIOptGetDataFromReal { get; set; } 
        public IRPSOption<SceneGestionView> UIOptKeepData { get; set; } 
        public IRPSOption<SceneGestionView> UIOptDeleteData { get; set; } 
        public IRPSOption<SceneGestionView> UIOptDeleteSceneData { get; set; } 
        public IRPSCheckbox<SceneGestionView> UIIncludeSceneDeleting { get; set; } 
        public IRPSOption<SceneGestionView> UIOptCopySceneDataToReal { get; set; } 
        public IRPSOption<SceneGestionView> UIOptCopyDataOtherScene { get; set; } 
        public IRPSComboBox<SceneGestionView> UISceneDestination { get; set; } 
        public IRPSOption<SceneGestionView> UIOptAll { get; set; } 
        public IRPSOption<SceneGestionView> UIOptSelection { get; set; } 
        public IRPSCheckbox<SceneGestionView> UICalendars { get; set; } 
        public IRPSCheckbox<SceneGestionView> UIProjects { get; set; } 
        public IRPSCheckbox<SceneGestionView> UIManufacturingPrevisions { get; set; } 
        public IRPSCheckbox<SceneGestionView> UIResourcePlanning { get; set; } 
        public IRPSCheckbox<SceneGestionView> UIResources { get; set; } 
        public IRPSCheckbox<SceneGestionView> UIManufacturingOrders { get; set; } 
        public IRPSCheckbox<SceneGestionView> UISalesPrevisions { get; set; } 
        public IRPSCheckbox<SceneGestionView> UIDependencies { get; set; } 
        public IRPSCheckbox<SceneGestionView> UIMaintenanceOrders { get; set; } 
        public IRPSCheckbox<SceneGestionView> UIPurchaseProposals { get; set; } 
        public IRPSCheckbox<SceneGestionView> UIResourceStops { get; set; } 
        public IRPSButton<SceneGestionView> ConsultCommand { get; set; } 
        public IRPSButton<SceneGestionView> DeleteSceneGestionManufacturingOrderCommandButton { get; set; } 
        public IRPSButton<SceneGestionView,GenerateManufacturingOrderDialogView> GenerateManufacturingOrderNavigationCommandButton { get; set; } 
        public IRPSButton<SceneGestionView> DeleteSceneGestionPurchaseProposalCommandButton { get; set; } 
        public IRPSButton<SceneGestionView,GeneratePurchaseProposalDialogView> GeneratePurchaseProposalNavigationCommandButton { get; set; } 
        public IRPSButton<SceneGestionView> DeleteSceneGestionProjectCommandButton { get; set; } 
        public IRPSButton<SceneGestionView> DeleteSceneGestionMaintenanceOrderCommandButton { get; set; } 
        public IRPSButton<SceneGestionView> SaveCommandButton { get; set; } 
        public IRPSButton<SceneGestionView> GenerateDataCommandButton { get; set; } 
        public GetSceneGestionManufacturingOrderDataCollectionEditor<SceneGestionView,GenerateManufacturingOrderDialogView> GetSceneGestionManufacturingOrderData { get; set; } 
        public GetSceneGestionPurchaseProposalDataCollectionEditor<SceneGestionView,GenerateManufacturingOrderDialogView> GetSceneGestionPurchaseProposalData { get; set; } 
        public GetSceneGestionProjectDataCollectionEditor<SceneGestionView,GenerateManufacturingOrderDialogView> GetSceneGestionProjectData { get; set; } 
        public GetSceneGestionMaintenanceOrderDataCollectionEditor<SceneGestionView,GenerateManufacturingOrderDialogView> GetSceneGestionMaintenanceOrderData { get; set; } 
        public GetSceneGestionResourceDataCollectionEditor<SceneGestionView,GenerateManufacturingOrderDialogView> GetSceneGestionResourceData { get; set; } 
        public IRPSSection<SceneGestionView> ManufacturingOrder { get; set; } 
        public IRPSSection<SceneGestionView> PurchaseProposal { get; set; } 
        public IRPSSection<SceneGestionView> Project { get; set; } 
        public IRPSSection<SceneGestionView> MaintenanceOrder { get; set; } 
        public IRPSSection<SceneGestionView> Resources { get; set; } 
        public SceneGestion Screen { get; set; }
        public SceneGestionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetSceneGestionManufacturingOrderDataCollectionEditor<SceneGestionView,GenerateManufacturingOrderDialogView>:RPSCollectionEditor<SceneGestionView,GenerateManufacturingOrderDialogView> where SceneGestionView : class, IView where GenerateManufacturingOrderDialogView : class, IView
    {
        public  GetSceneGestionManufacturingOrderDataGridView<SceneGestionView,GenerateManufacturingOrderDialogView> GridView {get;set;}
    }
    public partial class GetSceneGestionManufacturingOrderDataGridView <SceneGestionView,GenerateManufacturingOrderDialogView> :  RPSGridView<SceneGestionView,GenerateManufacturingOrderDialogView> where SceneGestionView : class, IView where GenerateManufacturingOrderDialogView : class, IView
    {
        public GetSceneGestionManufacturingOrderDataGridView(SceneGestionView currentView,GenerateManufacturingOrderDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            PassToReal = RPSControlFactory.CreateRPSGridCheckBox<SceneGestionView>("","#7c59d3ed-7310-413d-932c-040d4ce229ca .ag-row[role='row']@ROWINDEX [col-id='cPassToReal']","",false, this.CurrentView);
 
            SCManufacturingOrder_Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<SceneGestionView>("","#7c59d3ed-7310-413d-932c-040d4ce229ca .ag-row[role='row']@ROWINDEX [col-id='cSCManufacturingOrder_Quantity']","",false, this.CurrentView);
 
            SCManufacturingOrder_PlannedEndDate = RPSControlFactory.CreateRPSGridTextBox<SceneGestionView>("","#7c59d3ed-7310-413d-932c-040d4ce229ca .ag-row[role='row']@ROWINDEX [col-id='cSCManufacturingOrder_PlannedEndDate']","",false, this.CurrentView);
 
            CreatedInReal = RPSControlFactory.CreateRPSGridCheckBox<SceneGestionView>("","#7c59d3ed-7310-413d-932c-040d4ce229ca .ag-row[role='row']@ROWINDEX [col-id='cCreatedInReal']","",false, this.CurrentView);
 
            DeletedInScene = RPSControlFactory.CreateRPSGridCheckBox<SceneGestionView>("","#7c59d3ed-7310-413d-932c-040d4ce229ca .ag-row[role='row']@ROWINDEX [col-id='cDeletedInScene']","",false, this.CurrentView);
 

        }
        public IRPSGridCheckbox<SceneGestionView> PassToReal { get; set; } 
        public IRPSGridTextBox<SceneGestionView> SCManufacturingOrder_Quantity { get; set; } 
        public IRPSGridTextBox<SceneGestionView> SCManufacturingOrder_PlannedEndDate { get; set; } 
        public IRPSGridCheckbox<SceneGestionView> CreatedInReal { get; set; } 
        public IRPSGridCheckbox<SceneGestionView> DeletedInScene { get; set; } 
                     
    }
 
        public partial class GetSceneGestionPurchaseProposalDataCollectionEditor<SceneGestionView,GenerateManufacturingOrderDialogView>:RPSCollectionEditor<SceneGestionView,GenerateManufacturingOrderDialogView> where SceneGestionView : class, IView where GenerateManufacturingOrderDialogView : class, IView
    {
        public  GetSceneGestionPurchaseProposalDataGridView<SceneGestionView,GenerateManufacturingOrderDialogView> GridView {get;set;}
    }
    public partial class GetSceneGestionPurchaseProposalDataGridView <SceneGestionView,GenerateManufacturingOrderDialogView> :  RPSGridView<SceneGestionView,GenerateManufacturingOrderDialogView> where SceneGestionView : class, IView where GenerateManufacturingOrderDialogView : class, IView
    {
        public GetSceneGestionPurchaseProposalDataGridView(SceneGestionView currentView,GenerateManufacturingOrderDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            PassToReal = RPSControlFactory.CreateRPSGridCheckBox<SceneGestionView>("","#3a99b6c9-d4fe-43e0-ac5c-3447a8c7773f .ag-row[role='row']@ROWINDEX [col-id='cPassToReal']","",false, this.CurrentView);
 
            SCPurchaseProposal_Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<SceneGestionView>("","#3a99b6c9-d4fe-43e0-ac5c-3447a8c7773f .ag-row[role='row']@ROWINDEX [col-id='cSCPurchaseProposal_Quantity']","",false, this.CurrentView);
 
            SCPurchaseProposal_ReceptionDate = RPSControlFactory.CreateRPSGridTextBox<SceneGestionView>("","#3a99b6c9-d4fe-43e0-ac5c-3447a8c7773f .ag-row[role='row']@ROWINDEX [col-id='cSCPurchaseProposal_ReceptionDate']","",false, this.CurrentView);
 
            CreatedInReal = RPSControlFactory.CreateRPSGridCheckBox<SceneGestionView>("","#3a99b6c9-d4fe-43e0-ac5c-3447a8c7773f .ag-row[role='row']@ROWINDEX [col-id='cCreatedInReal']","",false, this.CurrentView);
 
            DeletedInScene = RPSControlFactory.CreateRPSGridCheckBox<SceneGestionView>("","#3a99b6c9-d4fe-43e0-ac5c-3447a8c7773f .ag-row[role='row']@ROWINDEX [col-id='cDeletedInScene']","",false, this.CurrentView);
 

        }
        public IRPSGridCheckbox<SceneGestionView> PassToReal { get; set; } 
        public IRPSGridTextBox<SceneGestionView> SCPurchaseProposal_Quantity { get; set; } 
        public IRPSGridTextBox<SceneGestionView> SCPurchaseProposal_ReceptionDate { get; set; } 
        public IRPSGridCheckbox<SceneGestionView> CreatedInReal { get; set; } 
        public IRPSGridCheckbox<SceneGestionView> DeletedInScene { get; set; } 
                     
    }
 
        public partial class GetSceneGestionProjectDataCollectionEditor<SceneGestionView,GenerateManufacturingOrderDialogView>:RPSCollectionEditor<SceneGestionView,GenerateManufacturingOrderDialogView> where SceneGestionView : class, IView where GenerateManufacturingOrderDialogView : class, IView
    {
        public  GetSceneGestionProjectDataGridView<SceneGestionView,GenerateManufacturingOrderDialogView> GridView {get;set;}
    }
    public partial class GetSceneGestionProjectDataGridView <SceneGestionView,GenerateManufacturingOrderDialogView> :  RPSGridView<SceneGestionView,GenerateManufacturingOrderDialogView> where SceneGestionView : class, IView where GenerateManufacturingOrderDialogView : class, IView
    {
        public GetSceneGestionProjectDataGridView(SceneGestionView currentView,GenerateManufacturingOrderDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            PassToReal = RPSControlFactory.CreateRPSGridCheckBox<SceneGestionView>("","#e5dd2b60-c5c4-47b9-a6e2-eaf24c1dac8a .ag-row[role='row']@ROWINDEX [col-id='cPassToReal']","",false, this.CurrentView);
 
            SCProject_PlannedEndDate = RPSControlFactory.CreateRPSGridTextBox<SceneGestionView>("","#e5dd2b60-c5c4-47b9-a6e2-eaf24c1dac8a .ag-row[role='row']@ROWINDEX [col-id='cSCProject_PlannedEndDate']","",false, this.CurrentView);
 

        }
        public IRPSGridCheckbox<SceneGestionView> PassToReal { get; set; } 
        public IRPSGridTextBox<SceneGestionView> SCProject_PlannedEndDate { get; set; } 
                     
    }
 
        public partial class GetSceneGestionMaintenanceOrderDataCollectionEditor<SceneGestionView,GenerateManufacturingOrderDialogView>:RPSCollectionEditor<SceneGestionView,GenerateManufacturingOrderDialogView> where SceneGestionView : class, IView where GenerateManufacturingOrderDialogView : class, IView
    {
        public  GetSceneGestionMaintenanceOrderDataGridView<SceneGestionView,GenerateManufacturingOrderDialogView> GridView {get;set;}
    }
    public partial class GetSceneGestionMaintenanceOrderDataGridView <SceneGestionView,GenerateManufacturingOrderDialogView> :  RPSGridView<SceneGestionView,GenerateManufacturingOrderDialogView> where SceneGestionView : class, IView where GenerateManufacturingOrderDialogView : class, IView
    {
        public GetSceneGestionMaintenanceOrderDataGridView(SceneGestionView currentView,GenerateManufacturingOrderDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            PassToReal = RPSControlFactory.CreateRPSGridCheckBox<SceneGestionView>("","#8bb505b8-fb7b-40e8-a172-7e4ba853cb7d .ag-row[role='row']@ROWINDEX [col-id='cPassToReal']","",false, this.CurrentView);
 
            SCMaintenanceOrder_ExecutionDate = RPSControlFactory.CreateRPSGridTextBox<SceneGestionView>("","#8bb505b8-fb7b-40e8-a172-7e4ba853cb7d .ag-row[role='row']@ROWINDEX [col-id='cSCMaintenanceOrder_ExecutionDate']","",false, this.CurrentView);
 

        }
        public IRPSGridCheckbox<SceneGestionView> PassToReal { get; set; } 
        public IRPSGridTextBox<SceneGestionView> SCMaintenanceOrder_ExecutionDate { get; set; } 
                     
    }
 
        public partial class GetSceneGestionResourceDataCollectionEditor<SceneGestionView,GenerateManufacturingOrderDialogView>:RPSCollectionEditor<SceneGestionView,GenerateManufacturingOrderDialogView> where SceneGestionView : class, IView where GenerateManufacturingOrderDialogView : class, IView
    {
        public  GetSceneGestionResourceDataGridView<SceneGestionView,GenerateManufacturingOrderDialogView> GridView {get;set;}
    }
    public partial class GetSceneGestionResourceDataGridView <SceneGestionView,GenerateManufacturingOrderDialogView> :  RPSGridView<SceneGestionView,GenerateManufacturingOrderDialogView> where SceneGestionView : class, IView where GenerateManufacturingOrderDialogView : class, IView
    {
        public GetSceneGestionResourceDataGridView(SceneGestionView currentView,GenerateManufacturingOrderDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            TypeDescription = RPSControlFactory.CreateRPSGridTextBox<SceneGestionView>("","#c2a81a5f-b377-49f9-a9d4-ee1df08939d7 .ag-row[role='row']@ROWINDEX [col-id='cTypeDescription']","",false, this.CurrentView);
 
            IDSCCalendar = RPSControlFactory.CreateRPSGridComboBox<SceneGestionView>("","#c2a81a5f-b377-49f9-a9d4-ee1df08939d7 .ag-row[role='row']@ROWINDEX [col-id='cIDSCCalendar']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<SceneGestionView> TypeDescription { get; set; } 
        public IRPSGridComboBox<SceneGestionView> IDSCCalendar { get; set; } 
                     
    }
 
    }
  
            
    public partial class GenerateManufacturingOrderDialogView : View
    {
        public GenerateManufacturingOrderDialogView(SceneGestion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UISite = RPSControlFactory.CreateRPSComboBox<GenerateManufacturingOrderDialogView>("eb27dc63-20c9-4956-9156-11daaf640afa","","",false, this);
 
            UIArticle = RPSControlFactory.CreateRPSComboBox<GenerateManufacturingOrderDialogView>("5a3c8140-3772-4a77-86c3-2a51a80a78cd","","",false, this);
 
            UIRoute = RPSControlFactory.CreateRPSComboBox<GenerateManufacturingOrderDialogView>("a6756ba8-fa45-49dd-8796-d80d2513b6e8","","",false, this);
 
            UIQuantitiy = RPSControlFactory.CreateRPSFormattedTextBox<GenerateManufacturingOrderDialogView>("562c641d-0c14-4648-998a-c84d567aa8bd","","",false, this);
 
            UIInternalCode = RPSControlFactory.CreateRPSTextBox<GenerateManufacturingOrderDialogView>("27b497ad-2bc5-449e-b041-6c35dfe2aefb","","",false, this);
 
            UIOptAsSoonAsPossible = RPSControlFactory.CreateRPSOption<GenerateManufacturingOrderDialogView>( "e8bf0214-b6dc-4f9d-b202-a605602d36a8","","",this);
 
            UIOptAdjustToDate = RPSControlFactory.CreateRPSOption<GenerateManufacturingOrderDialogView>( "d3069a1f-e2e2-47fa-8ac5-70a621b68023","","",this);
 
            UIInitialDate = RPSControlFactory.CreateRPSTextBox<GenerateManufacturingOrderDialogView>("6985896e-c7d9-4f73-9b8c-31687b3ffb57","","",false, this);
 

        }
        public IRPSComboBox<GenerateManufacturingOrderDialogView> UISite { get; set; } 
        public IRPSComboBox<GenerateManufacturingOrderDialogView> UIArticle { get; set; } 
        public IRPSComboBox<GenerateManufacturingOrderDialogView> UIRoute { get; set; } 
        public IRPSTextBox<GenerateManufacturingOrderDialogView> UIQuantitiy { get; set; } 
        public IRPSTextBox<GenerateManufacturingOrderDialogView> UIInternalCode { get; set; } 
        public IRPSOption<GenerateManufacturingOrderDialogView> UIOptAsSoonAsPossible { get; set; } 
        public IRPSOption<GenerateManufacturingOrderDialogView> UIOptAdjustToDate { get; set; } 
        public IRPSTextBox<GenerateManufacturingOrderDialogView> UIInitialDate { get; set; } 
        public SceneGestion Screen { get; set; }
        public GenerateManufacturingOrderDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class GeneratePurchaseProposalDialogView : View
    {
        public GeneratePurchaseProposalDialogView(SceneGestion screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UISite = RPSControlFactory.CreateRPSComboBox<GeneratePurchaseProposalDialogView>("836ac2e3-becc-466e-9252-fdb9923fafe7","","",false, this);
 
            UIArticle = RPSControlFactory.CreateRPSComboBox<GeneratePurchaseProposalDialogView>("36727725-ca44-4a0f-b04b-b79b2c6edde0","","",false, this);
 
            UIQuantitiy = RPSControlFactory.CreateRPSFormattedTextBox<GeneratePurchaseProposalDialogView>("132c1b37-7a45-40dd-9852-e3ba07009854","","",false, this);
 
            UIInternalCode = RPSControlFactory.CreateRPSTextBox<GeneratePurchaseProposalDialogView>("1f8b570c-e47b-4410-8745-b935bc0889c5","","",false, this);
 
            UIDeliveryDate = RPSControlFactory.CreateRPSTextBox<GeneratePurchaseProposalDialogView>("ac202b71-0b11-4aa9-ab40-88f7b1c637bc","","",false, this);
 

        }
        public IRPSComboBox<GeneratePurchaseProposalDialogView> UISite { get; set; } 
        public IRPSComboBox<GeneratePurchaseProposalDialogView> UIArticle { get; set; } 
        public IRPSTextBox<GeneratePurchaseProposalDialogView> UIQuantitiy { get; set; } 
        public IRPSTextBox<GeneratePurchaseProposalDialogView> UIInternalCode { get; set; } 
        public IRPSTextBox<GeneratePurchaseProposalDialogView> UIDeliveryDate { get; set; } 
        public SceneGestion Screen { get; set; }
        public GeneratePurchaseProposalDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}