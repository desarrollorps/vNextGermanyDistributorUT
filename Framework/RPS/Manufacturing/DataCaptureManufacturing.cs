    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Manufacturing.DataCaptureManufacturing
{
    //RPS VERSION 1.0.0.0
    public partial class DataCaptureManufacturing:Screen
    {
        public DataCaptureManufacturing():base()
        {
            this.URL = "manufacturing.datacapturemanufacturing";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DataCaptureManufacturingView  = new DataCaptureManufacturingView(this); 
            PrintLabelsDialogView  = new PrintLabelsDialogView(this); 
            UsualTaskDialogView  = new UsualTaskDialogView(this); 
            MOTaskMaterialDialogView  = new MOTaskMaterialDialogView(this); 
            PlannedTasksDialogView  = new PlannedTasksDialogView(this); 
            MultiImputationView  = new MultiImputationView(this); 
            MultiImputationGroupedTaskDialogView  = new MultiImputationGroupedTaskDialogView(this); 
            DataCaptureManufacturingView.InitializeControls(); 
            PrintLabelsDialogView.InitializeControls(); 
            UsualTaskDialogView.InitializeControls(); 
            MOTaskMaterialDialogView.InitializeControls(); 
            PlannedTasksDialogView.InitializeControls(); 
            MultiImputationView.InitializeControls(); 
            MultiImputationGroupedTaskDialogView.InitializeControls(); 
           
        }
      
            public DataCaptureManufacturingView DataCaptureManufacturingView {get; set; } 
            public PrintLabelsDialogView PrintLabelsDialogView {get; set; } 
            public UsualTaskDialogView UsualTaskDialogView {get; set; } 
            public MOTaskMaterialDialogView MOTaskMaterialDialogView {get; set; } 
            public PlannedTasksDialogView PlannedTasksDialogView {get; set; } 
            public MultiImputationView MultiImputationView {get; set; } 
            public MultiImputationGroupedTaskDialogView MultiImputationGroupedTaskDialogView {get; set; } 
    }
            
    public partial class DataCaptureManufacturingView : View
    {
        public DataCaptureManufacturingView(DataCaptureManufacturing screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Machine = RPSControlFactory.CreateRPSComboBox<DataCaptureManufacturingView>("25f85376-31fc-4d33-ba64-f94413a436dd","","",false, this);
 
            CheckMachineImputation = RPSControlFactory.CreateRPSCheckBox<DataCaptureManufacturingView>("c18fb3ba-644f-47df-85a9-a5575b793cb5","","",false, this);
 
            ConsultDate = RPSControlFactory.CreateRPSTextBox<DataCaptureManufacturingView>("c5093518-f23e-46d7-95e7-13fecc32c705","","",false, this);
 
            ConsultTime = RPSControlFactory.CreateRPSTextBox<DataCaptureManufacturingView>("682653b3-971f-44fa-8dd5-e2f18b49619a","","",false, this);
 
            Employee = RPSControlFactory.CreateRPSComboBox<DataCaptureManufacturingView>("f4dee18e-68c1-403e-ad01-c408f5491bf0","","",false, this);
 
            UsualTaskNavigationCommand = RPSControlFactory.CreateRPSButton<DataCaptureManufacturingView>( "6fe20c2b-03e7-4c76-a43e-5963abb8e0b9","","",this);
 
            PlannedTasksNavigationCommand = RPSControlFactory.CreateRPSButtonToView<DataCaptureManufacturingView,PlannedTasksDialogView>("cd00c0ba-3831-4ac2-9c9a-9ec9d9016b6b","","", this,Screen.PlannedTasksDialogView);
 
            CheckInCommand = RPSControlFactory.CreateRPSButton<DataCaptureManufacturingView>( "e7c10c1b-88da-478c-b870-b0aa142898eb","","",this);
 
            CheckOutCommand = RPSControlFactory.CreateRPSButton<DataCaptureManufacturingView>( "dca5b8ab-cddc-4f63-b18b-45c41b13a502","","",this);
 
            ManufacturingOrder = RPSControlFactory.CreateRPSComboBox<DataCaptureManufacturingView>("9905a1b9-f6c4-40e2-a8de-c652a480d0f3","","",false, this);
 
            MOTask = RPSControlFactory.CreateRPSComboBox<DataCaptureManufacturingView>("b1dfe8ab-ba41-4706-a197-6204c557f955","","",false, this);
 
            WorkSheetNumber = RPSControlFactory.CreateRPSTextBox<DataCaptureManufacturingView>("26165bbf-6c45-48a3-afb3-d30949ff498b","","",false, this);
 
            ExecuteDataCaptureStart = RPSControlFactory.CreateRPSButton<DataCaptureManufacturingView>( "2d027680-86f4-406d-b851-6fdbc4e5470a","","",this);
 
            Description = RPSControlFactory.CreateRPSTextBox<DataCaptureManufacturingView>("55dcfe35-3b03-4144-a362-0a4b5e56e4a0","","",false, this);
 
            StartDate = RPSControlFactory.CreateRPSTextBox<DataCaptureManufacturingView>("f8151420-6258-43dc-9022-ec5f2a84ba55","","",false, this);
 
            StartHour = RPSControlFactory.CreateRPSTextBox<DataCaptureManufacturingView>("e0661794-1622-48ff-9c14-afb8e6488f43","","",false, this);
 
            ExecuteDataCaptureStop = RPSControlFactory.CreateRPSButton<DataCaptureManufacturingView>( "c3832913-a85b-44cd-8931-97ffdef5e6b4","","",this);
 
            EndHour = RPSControlFactory.CreateRPSTextBox<DataCaptureManufacturingView>("5e888703-3023-4fd6-83dc-e2c8d3e4b666","","",false, this);
 
            ImputationTime = RPSControlFactory.CreateRPSTextBox<DataCaptureManufacturingView>("3c971927-f411-4aad-b5a5-06d0c33099a4","","",false, this);
 
            ImpTime = RPSControlFactory.CreateRPSTextBox<DataCaptureManufacturingView>("cd238f0d-0454-4ecf-b425-64a7648501a4","","",false, this);
 
            ManufacturedQuantity = RPSControlFactory.CreateRPSFormattedTextBox<DataCaptureManufacturingView>("ffcffb1e-3c91-424f-801a-cb9745f761e2","","",false, this);
 
            RejectedQuantity = RPSControlFactory.CreateRPSFormattedTextBox<DataCaptureManufacturingView>("341e77b0-c262-4c73-82d3-1ded842429f9","","",false, this);
 
            RejectionCause = RPSControlFactory.CreateRPSComboBox<DataCaptureManufacturingView>("0919bf34-9251-42da-a04d-50b32523096d","","",false, this);
 
            CheckUnproductive = RPSControlFactory.CreateRPSCheckBox<DataCaptureManufacturingView>("824faac8-3959-48e2-85f5-054d33dd002b","","",false, this);
 
            UnproductiveType = RPSControlFactory.CreateRPSComboBox<DataCaptureManufacturingView>("9c2b59c7-67a5-4de4-9636-0c13c3cfb3a6","","",false, this);
 
            HourType = RPSControlFactory.CreateRPSComboBox<DataCaptureManufacturingView>("71482cc0-deb2-4b92-a5df-8564fff7e17c","","",true, this);
 
            CheckFinishedTask = RPSControlFactory.CreateRPSCheckBox<DataCaptureManufacturingView>("57ff97a6-939b-4b5d-8c52-7a12b39732ff","","",false, this);
 
            PreparationTime = RPSControlFactory.CreateRPSCheckBox<DataCaptureManufacturingView>("afa00761-6c21-4d4e-ac9d-8a3da17e2295","","",false, this);
 
            OnlyPendingQuantity = RPSControlFactory.CreateRPSCheckBox<DataCaptureManufacturingView>("54f87c28-662b-45ed-a518-e960b0a75dc3","","",false, this);
 
            ExecuteDataCaptureEnd = RPSControlFactory.CreateRPSButton<DataCaptureManufacturingView>( "ef602756-a214-450d-9bc8-d5ea4ebeaec3","","",this);
 
            NavigationToImputationButton = RPSControlFactory.CreateRPSButton<DataCaptureManufacturingView>( "3d5d346e-7ca0-4d22-8221-15871180e7d3","","",this);
 
            ShowArticleAttachmentsButton = RPSControlFactory.CreateRPSButton<DataCaptureManufacturingView>( "9f90cab0-8826-4bb4-ab44-36217d69b84a","","",this);
 
            ShowManufacturingOrderAttachmentsButton = RPSControlFactory.CreateRPSButton<DataCaptureManufacturingView>( "aa672c83-16a3-4cba-9adf-70a3c4ecda7e","","",this);
 
            ShowMOTaskAttachmentsButton = RPSControlFactory.CreateRPSButton<DataCaptureManufacturingView>( "b2b9ef7e-778e-4ff7-be95-7de27bd27db7","","",this);
 
            PrintLabelsNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<DataCaptureManufacturingView,PrintLabelsDialogView>("2fc3fa11-d2b8-4691-8c8a-7510ccceb503","","", this,Screen.PrintLabelsDialogView);
 
            NavigationToMaintenanceWarningButton = RPSControlFactory.CreateRPSButton<DataCaptureManufacturingView>( "d09d7d1d-4466-4f4f-a73d-7833f6da5078","","",this);
 
            ShowMONotesCommandButton = RPSControlFactory.CreateRPSButton<DataCaptureManufacturingView>( "9ee7dd09-99a0-4c23-acf2-7ad13874f66e","","",this);
 
            ShowMOTaskNotesCommandButton = RPSControlFactory.CreateRPSButton<DataCaptureManufacturingView>( "888450d3-92c6-4150-ab15-5a131a70eeb4","","",this);
 

        }
        public IRPSComboBox<DataCaptureManufacturingView> Machine { get; set; } 
        public IRPSCheckbox<DataCaptureManufacturingView> CheckMachineImputation { get; set; } 
        public IRPSTextBox<DataCaptureManufacturingView> ConsultDate { get; set; } 
        public IRPSTextBox<DataCaptureManufacturingView> ConsultTime { get; set; } 
        public IRPSComboBox<DataCaptureManufacturingView> Employee { get; set; } 
        public IRPSButton<DataCaptureManufacturingView> UsualTaskNavigationCommand { get; set; } 
        public IRPSButton<DataCaptureManufacturingView,PlannedTasksDialogView> PlannedTasksNavigationCommand { get; set; } 
        public IRPSButton<DataCaptureManufacturingView> CheckInCommand { get; set; } 
        public IRPSButton<DataCaptureManufacturingView> CheckOutCommand { get; set; } 
        public IRPSComboBox<DataCaptureManufacturingView> ManufacturingOrder { get; set; } 
        public IRPSComboBox<DataCaptureManufacturingView> MOTask { get; set; } 
        public IRPSTextBox<DataCaptureManufacturingView> WorkSheetNumber { get; set; } 
        public IRPSButton<DataCaptureManufacturingView> ExecuteDataCaptureStart { get; set; } 
        public IRPSTextBox<DataCaptureManufacturingView> Description { get; set; } 
        public IRPSTextBox<DataCaptureManufacturingView> StartDate { get; set; } 
        public IRPSTextBox<DataCaptureManufacturingView> StartHour { get; set; } 
        public IRPSButton<DataCaptureManufacturingView> ExecuteDataCaptureStop { get; set; } 
        public IRPSTextBox<DataCaptureManufacturingView> EndHour { get; set; } 
        public IRPSTextBox<DataCaptureManufacturingView> ImputationTime { get; set; } 
        public IRPSTextBox<DataCaptureManufacturingView> ImpTime { get; set; } 
        public IRPSTextBox<DataCaptureManufacturingView> ManufacturedQuantity { get; set; } 
        public IRPSTextBox<DataCaptureManufacturingView> RejectedQuantity { get; set; } 
        public IRPSComboBox<DataCaptureManufacturingView> RejectionCause { get; set; } 
        public IRPSCheckbox<DataCaptureManufacturingView> CheckUnproductive { get; set; } 
        public IRPSComboBox<DataCaptureManufacturingView> UnproductiveType { get; set; } 
        public IRPSComboBox<DataCaptureManufacturingView> HourType { get; set; } 
        public IRPSCheckbox<DataCaptureManufacturingView> CheckFinishedTask { get; set; } 
        public IRPSCheckbox<DataCaptureManufacturingView> PreparationTime { get; set; } 
        public IRPSCheckbox<DataCaptureManufacturingView> OnlyPendingQuantity { get; set; } 
        public IRPSButton<DataCaptureManufacturingView> ExecuteDataCaptureEnd { get; set; } 
        public IRPSButton<DataCaptureManufacturingView> NavigationToImputationButton { get; set; } 
        public IRPSButton<DataCaptureManufacturingView> ShowArticleAttachmentsButton { get; set; } 
        public IRPSButton<DataCaptureManufacturingView> ShowManufacturingOrderAttachmentsButton { get; set; } 
        public IRPSButton<DataCaptureManufacturingView> ShowMOTaskAttachmentsButton { get; set; } 
        public IRPSButton<DataCaptureManufacturingView,PrintLabelsDialogView> PrintLabelsNavigationCommandButton { get; set; } 
        public IRPSButton<DataCaptureManufacturingView> NavigationToMaintenanceWarningButton { get; set; } 
        public IRPSButton<DataCaptureManufacturingView> ShowMONotesCommandButton { get; set; } 
        public IRPSButton<DataCaptureManufacturingView> ShowMOTaskNotesCommandButton { get; set; } 
        public DataCaptureManufacturing Screen { get; set; }
        public DataCaptureManufacturingView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class PrintLabelsDialogView : View
    {
        public PrintLabelsDialogView(DataCaptureManufacturing screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ManufacturingOrder = RPSControlFactory.CreateRPSComboBox<PrintLabelsDialogView>("d9d2b071-b35b-4aca-b569-e299444b05d9","","",false, this);
 
            MOTask = RPSControlFactory.CreateRPSComboBox<PrintLabelsDialogView>("d96b741b-1f2f-488e-85e3-f4add612b3e5","","",false, this);
 
            Labels = RPSControlFactory.CreateRPSFormattedTextBox<PrintLabelsDialogView>("0fd11cb3-3e0f-4d30-9455-124e0098d78b","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<PrintLabelsDialogView>("7eade6ce-4a6c-40c8-96d8-f677a096687a","","",false, this);
 
            OkCommand = RPSControlFactory.CreateRPSButton<PrintLabelsDialogView>( "4d1a2d32-5931-451c-a733-9bc576226738","","",this);
 
            CancelCommand = RPSControlFactory.CreateRPSButton<PrintLabelsDialogView>( "d66c864c-6e5d-460f-b76b-c3a3cf2a3901","","",this);
 

        }
        public IRPSComboBox<PrintLabelsDialogView> ManufacturingOrder { get; set; } 
        public IRPSComboBox<PrintLabelsDialogView> MOTask { get; set; } 
        public IRPSTextBox<PrintLabelsDialogView> Labels { get; set; } 
        public IRPSTextBox<PrintLabelsDialogView> Quantity { get; set; } 
        public IRPSButton<PrintLabelsDialogView> OkCommand { get; set; } 
        public IRPSButton<PrintLabelsDialogView> CancelCommand { get; set; } 
        public DataCaptureManufacturing Screen { get; set; }
        public PrintLabelsDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class UsualTaskDialogView : View
    {
        public UsualTaskDialogView(DataCaptureManufacturing screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            OkCommand = RPSControlFactory.CreateRPSButton<UsualTaskDialogView>( "2b715309-4950-458d-a021-2f502db7d87e","","",this);
 
            CloseCommand = RPSControlFactory.CreateRPSButton<UsualTaskDialogView>( "b343e86c-930c-440e-b174-e8f7162d5991","","",this);
 
            CollectionInit params_GetUsualTask = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a13eb042-3aef-4c7d-afb4-3d94ca8f3a7c",CSSSelectorGrid="",XPathGrid=""};
            GetUsualTask = RPSControlFactory.RPSCreateCollectionWithGrid<GetUsualTaskCollectionEditor<UsualTaskDialogView,PrintLabelsDialogView>,UsualTaskDialogView,PrintLabelsDialogView>( params_GetUsualTask,this,Screen.PrintLabelsDialogView);
 

        }
        public IRPSButton<UsualTaskDialogView> OkCommand { get; set; } 
        public IRPSButton<UsualTaskDialogView> CloseCommand { get; set; } 
        public GetUsualTaskCollectionEditor<UsualTaskDialogView,PrintLabelsDialogView> GetUsualTask { get; set; } 
        public DataCaptureManufacturing Screen { get; set; }
        public UsualTaskDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetUsualTaskCollectionEditor<UsualTaskDialogView,PrintLabelsDialogView>:RPSCollectionEditor<UsualTaskDialogView,PrintLabelsDialogView> where UsualTaskDialogView : class, IView where PrintLabelsDialogView : class, IView
    {
        public  GetUsualTaskGridView<UsualTaskDialogView,PrintLabelsDialogView> GridView {get;set;}
    }
    public partial class GetUsualTaskGridView <UsualTaskDialogView,PrintLabelsDialogView> :  RPSGridView<UsualTaskDialogView,PrintLabelsDialogView> where UsualTaskDialogView : class, IView where PrintLabelsDialogView : class, IView
    {
        public GetUsualTaskGridView(UsualTaskDialogView currentView,PrintLabelsDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MOTask_CodMOTask = RPSControlFactory.CreateRPSGridTextBox<UsualTaskDialogView>("","#a13eb042-3aef-4c7d-afb4-3d94ca8f3a7c .ag-row[role='row']@ROWINDEX [col-id='cMOTask_CodMOTask']","",false, this.CurrentView);
 
            MOTask_Description = RPSControlFactory.CreateRPSGridTextBox<UsualTaskDialogView>("","#a13eb042-3aef-4c7d-afb4-3d94ca8f3a7c .ag-row[role='row']@ROWINDEX [col-id='cMOTask_Description']","",false, this.CurrentView);
 
            MOTask_PercentProgress = RPSControlFactory.CreateRPSGridFormattedTextBox<UsualTaskDialogView>("","#a13eb042-3aef-4c7d-afb4-3d94ca8f3a7c .ag-row[role='row']@ROWINDEX [col-id='cMOTask_PercentProgress']","",false, this.CurrentView);
 
            QuantityAllowedToProcess = RPSControlFactory.CreateRPSGridFormattedTextBox<UsualTaskDialogView>("","#a13eb042-3aef-4c7d-afb4-3d94ca8f3a7c .ag-row[role='row']@ROWINDEX [col-id='cQuantityAllowedToProcess']","",false, this.CurrentView);
 
            MOTask_Priority = RPSControlFactory.CreateRPSGridFormattedTextBox<UsualTaskDialogView>("","#a13eb042-3aef-4c7d-afb4-3d94ca8f3a7c .ag-row[role='row']@ROWINDEX [col-id='cMOTask_Priority']","",false, this.CurrentView);
 
            MOTask_PlannedStartDate = RPSControlFactory.CreateRPSGridTextBox<UsualTaskDialogView>("","#a13eb042-3aef-4c7d-afb4-3d94ca8f3a7c .ag-row[role='row']@ROWINDEX [col-id='cMOTask_PlannedStartDate']","",false, this.CurrentView);
 
            MOTask_OptimizationFeature = RPSControlFactory.CreateRPSGridTextBox<UsualTaskDialogView>("","#a13eb042-3aef-4c7d-afb4-3d94ca8f3a7c .ag-row[role='row']@ROWINDEX [col-id='cMOTask_OptimizationFeature']","",false, this.CurrentView);
 
            ManufacturedQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<UsualTaskDialogView>("","#a13eb042-3aef-4c7d-afb4-3d94ca8f3a7c .ag-row[role='row']@ROWINDEX [col-id='cManufacturedQuantity']","",false, this.CurrentView);
 
            UsualTaskSTR = RPSControlFactory.CreateRPSGridComboBox<UsualTaskDialogView>("","#a13eb042-3aef-4c7d-afb4-3d94ca8f3a7c .ag-row[role='row']@ROWINDEX [col-id='cUsualTaskSTR']","",false, this.CurrentView);
 
            NavigateToMaterialsCommand = RPSControlFactory.CreateRPSGridButton<UsualTaskDialogView>( "","#a13eb042-3aef-4c7d-afb4-3d94ca8f3a7c .ag-row[role='row']@ROWINDEX [col-id='cNavigateToMaterials']","",this.CurrentView);
 

        }
        public IRPSGridTextBox<UsualTaskDialogView> MOTask_CodMOTask { get; set; } 
        public IRPSGridTextBox<UsualTaskDialogView> MOTask_Description { get; set; } 
        public IRPSGridTextBox<UsualTaskDialogView> MOTask_PercentProgress { get; set; } 
        public IRPSGridTextBox<UsualTaskDialogView> QuantityAllowedToProcess { get; set; } 
        public IRPSGridTextBox<UsualTaskDialogView> MOTask_Priority { get; set; } 
        public IRPSGridTextBox<UsualTaskDialogView> MOTask_PlannedStartDate { get; set; } 
        public IRPSGridTextBox<UsualTaskDialogView> MOTask_OptimizationFeature { get; set; } 
        public IRPSGridTextBox<UsualTaskDialogView> ManufacturedQuantity { get; set; } 
        public IRPSGridComboBox<UsualTaskDialogView> UsualTaskSTR { get; set; } 
        public IRPSGridButton<UsualTaskDialogView> NavigateToMaterialsCommand { get; set; } 
                     
    }
 
    }
  
            
    public partial class MOTaskMaterialDialogView : View
    {
        public MOTaskMaterialDialogView(DataCaptureManufacturing screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_MOTaskMaterials = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="677cbe5a-bb6f-47a7-8127-0efeeb846900",CSSSelectorGrid="",XPathGrid=""};
            MOTaskMaterials = RPSControlFactory.RPSCreateCollectionWithGrid<MOTaskMaterialsCollectionEditor<MOTaskMaterialDialogView>,MOTaskMaterialDialogView>( params_MOTaskMaterials,this);
 

        }
        public MOTaskMaterialsCollectionEditor<MOTaskMaterialDialogView> MOTaskMaterials { get; set; } 
        public DataCaptureManufacturing Screen { get; set; }
        public MOTaskMaterialDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MOTaskMaterialsCollectionEditor<MOTaskMaterialDialogView>:RPSCollectionEditor<MOTaskMaterialDialogView> where MOTaskMaterialDialogView : class, IView
    {
        public  MOTaskMaterialsGridView<MOTaskMaterialDialogView> GridView {get;set;}
    }
    public partial class MOTaskMaterialsGridView <MOTaskMaterialDialogView> :  RPSGridView<MOTaskMaterialDialogView> where MOTaskMaterialDialogView : class, IView
    {
        public MOTaskMaterialsGridView(MOTaskMaterialDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            TheoricQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<MOTaskMaterialDialogView>("","#677cbe5a-bb6f-47a7-8127-0efeeb846900 .ag-row[role='row']@ROWINDEX [col-id='cTheoricQuantity']","",false, this.CurrentView);
 
            PendingQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<MOTaskMaterialDialogView>("","#677cbe5a-bb6f-47a7-8127-0efeeb846900 .ag-row[role='row']@ROWINDEX [col-id='cPendingQuantity']","",false, this.CurrentView);
 
            ProcessTheoricQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<MOTaskMaterialDialogView>("","#677cbe5a-bb6f-47a7-8127-0efeeb846900 .ag-row[role='row']@ROWINDEX [col-id='cProcessTheoricQuantity']","",false, this.CurrentView);
 
            NecessaryQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<MOTaskMaterialDialogView>("","#677cbe5a-bb6f-47a7-8127-0efeeb846900 .ag-row[role='row']@ROWINDEX [col-id='cNecessaryQuantity']","",false, this.CurrentView);
 
            AvailableStock = RPSControlFactory.CreateRPSGridFormattedTextBox<MOTaskMaterialDialogView>("","#677cbe5a-bb6f-47a7-8127-0efeeb846900 .ag-row[role='row']@ROWINDEX [col-id='cAvailableStock']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MOTaskMaterialDialogView> TheoricQuantity { get; set; } 
        public IRPSGridTextBox<MOTaskMaterialDialogView> PendingQuantity { get; set; } 
        public IRPSGridTextBox<MOTaskMaterialDialogView> ProcessTheoricQuantity { get; set; } 
        public IRPSGridTextBox<MOTaskMaterialDialogView> NecessaryQuantity { get; set; } 
        public IRPSGridTextBox<MOTaskMaterialDialogView> AvailableStock { get; set; } 
                     
    }
 
    }
  
            
    public partial class PlannedTasksDialogView : View
    {
        public PlannedTasksDialogView(DataCaptureManufacturing screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_GetDataCapturePlannedTasks = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="18f418c6-7919-4d41-8c45-88dabc18df91",CSSSelectorGrid="",XPathGrid=""};
            GetDataCapturePlannedTasks = RPSControlFactory.RPSCreateCollectionWithGrid<GetDataCapturePlannedTasksCollectionEditor<PlannedTasksDialogView>,PlannedTasksDialogView>( params_GetDataCapturePlannedTasks,this);
 

        }
        public GetDataCapturePlannedTasksCollectionEditor<PlannedTasksDialogView> GetDataCapturePlannedTasks { get; set; } 
        public DataCaptureManufacturing Screen { get; set; }
        public PlannedTasksDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetDataCapturePlannedTasksCollectionEditor<PlannedTasksDialogView>:RPSCollectionEditor<PlannedTasksDialogView> where PlannedTasksDialogView : class, IView
    {
        public  GetDataCapturePlannedTasksGridView<PlannedTasksDialogView> GridView {get;set;}
    }
    public partial class GetDataCapturePlannedTasksGridView <PlannedTasksDialogView> :  RPSGridView<PlannedTasksDialogView> where PlannedTasksDialogView : class, IView
    {
        public GetDataCapturePlannedTasksGridView(PlannedTasksDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {

        }
                     
    }
 
    }
  
            
    public partial class MultiImputationView : View
    {
        public MultiImputationView(DataCaptureManufacturing screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<MultiImputationView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<MultiImputationView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<MultiImputationView,UsualTaskDialogView>( this,Screen.UsualTaskDialogView);
 
            BackButton = RPSControlFactory.RPSBackButton<MultiImputationView,UsualTaskDialogView>( this,Screen.UsualTaskDialogView);
 
            CodWork = RPSControlFactory.CreateRPSTextBox<MultiImputationView>("dc3750a1-a7ce-4579-ae9a-50711bf8adc1","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MultiImputationView>("194effc6-1625-4e5a-a5b0-1e8513bfbf04","","",false, this);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<MultiImputationView>("4c4c61cc-af0e-48d4-8bcb-70cd8cd1ec61","","",false, this);
 
            StartHour = RPSControlFactory.CreateRPSTextBox<MultiImputationView>("bc14d204-6399-41e4-8a8f-10f09114443b","","",false, this);
 
            EndHour = RPSControlFactory.CreateRPSTextBox<MultiImputationView>("1445c953-0cc1-4d68-a145-c19d5f4bd864","","",false, this);
 
            ExecuteStartEmployeeMultiImputationButton = RPSControlFactory.CreateRPSButton<MultiImputationView>( "bb9b1246-7df5-47d4-842c-2db81c9747f9","","",this);
 
            ExecuteStopEmployeeMultiImputationButton = RPSControlFactory.CreateRPSButton<MultiImputationView>( "5a478490-f370-4532-9a42-1c05b13c74b0","","",this);
 
            ExecuteCloseMultiImputationButton = RPSControlFactory.CreateRPSButton<MultiImputationView>( "0ce8713e-8d2f-4609-bcb1-3c8dd609a1bc","","",this);
 
            ExecuteEndMultiImputationButton = RPSControlFactory.CreateRPSButton<MultiImputationView>( "122e0f9a-7412-4f4e-ac95-6ad905d208df","","",this);
 
            MultiImputationGroupedTaskNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<MultiImputationView,MultiImputationGroupedTaskDialogView>("f87a76cc-cd14-49e0-be13-50b5716de407","","", this,Screen.MultiImputationGroupedTaskDialogView);
 
            CollectionInit params_MultiImputationTasks = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="54ebd7c7-3b0f-421e-9ae4-7a18de60e25c",CSSSelectorGrid="",XPathGrid=""};
            MultiImputationTasks = RPSControlFactory.RPSCreateCollectionWithGrid<MultiImputationTasksCollectionEditor<MultiImputationView,MultiImputationGroupedTaskDialogView>,MultiImputationView,MultiImputationGroupedTaskDialogView>( params_MultiImputationTasks,this,Screen.MultiImputationGroupedTaskDialogView);
 

        }
        public IRPSSaveButton<MultiImputationView> SaveButton { get; set; } 
        public IRPSButton<MultiImputationView> DeleteButton { get; set; } 
        public IRPSButton<MultiImputationView,UsualTaskDialogView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<MultiImputationView,UsualTaskDialogView> BackButton { get; set; } 
        public IRPSTextBox<MultiImputationView> CodWork { get; set; } 
        public IRPSTextBox<MultiImputationView> Description { get; set; } 
        public IRPSComboBox<MultiImputationView> IDEmployee { get; set; } 
        public IRPSTextBox<MultiImputationView> StartHour { get; set; } 
        public IRPSTextBox<MultiImputationView> EndHour { get; set; } 
        public IRPSButton<MultiImputationView> ExecuteStartEmployeeMultiImputationButton { get; set; } 
        public IRPSButton<MultiImputationView> ExecuteStopEmployeeMultiImputationButton { get; set; } 
        public IRPSButton<MultiImputationView> ExecuteCloseMultiImputationButton { get; set; } 
        public IRPSButton<MultiImputationView> ExecuteEndMultiImputationButton { get; set; } 
        public IRPSButton<MultiImputationView,MultiImputationGroupedTaskDialogView> MultiImputationGroupedTaskNavigationCommandButton { get; set; } 
        public MultiImputationTasksCollectionEditor<MultiImputationView,MultiImputationGroupedTaskDialogView> MultiImputationTasks { get; set; } 
        public DataCaptureManufacturing Screen { get; set; }
        public MultiImputationView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MultiImputationTasksCollectionEditor<MultiImputationView,MultiImputationGroupedTaskDialogView>:RPSCollectionEditor<MultiImputationView,MultiImputationGroupedTaskDialogView> where MultiImputationView : class, IView where MultiImputationGroupedTaskDialogView : class, IView
    {
        public  MultiImputationTasksGridView<MultiImputationView,MultiImputationGroupedTaskDialogView> GridView {get;set;}
    }
    public partial class MultiImputationTasksGridView <MultiImputationView,MultiImputationGroupedTaskDialogView> :  RPSGridView<MultiImputationView,MultiImputationGroupedTaskDialogView> where MultiImputationView : class, IView where MultiImputationGroupedTaskDialogView : class, IView
    {
        public MultiImputationTasksGridView(MultiImputationView currentView,MultiImputationGroupedTaskDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDManufacturingOrder = RPSControlFactory.CreateRPSGridComboBox<MultiImputationView>("","#54ebd7c7-3b0f-421e-9ae4-7a18de60e25c .ag-row[role='row']@ROWINDEX [col-id='cIDManufacturingOrder']","",true, this.CurrentView);
 
            IDMOTask = RPSControlFactory.CreateRPSGridComboBox<MultiImputationView>("","#54ebd7c7-3b0f-421e-9ae4-7a18de60e25c .ag-row[role='row']@ROWINDEX [col-id='cIDMOTask']","",true, this.CurrentView);
 
            WorkSheetNumber = RPSControlFactory.CreateRPSGridTextBox<MultiImputationView>("","#54ebd7c7-3b0f-421e-9ae4-7a18de60e25c .ag-row[role='row']@ROWINDEX [col-id='cWorkSheetNumber']","",false, this.CurrentView);
 
            ManufacturedQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<MultiImputationView>("","#54ebd7c7-3b0f-421e-9ae4-7a18de60e25c .ag-row[role='row']@ROWINDEX [col-id='cManufacturedQuantity']","",true, this.CurrentView);
 
            RejectedQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<MultiImputationView>("","#54ebd7c7-3b0f-421e-9ae4-7a18de60e25c .ag-row[role='row']@ROWINDEX [col-id='cRejectedQuantity']","",true, this.CurrentView);
 
            IDRejectionCause = RPSControlFactory.CreateRPSGridComboBox<MultiImputationView>("","#54ebd7c7-3b0f-421e-9ae4-7a18de60e25c .ag-row[role='row']@ROWINDEX [col-id='cIDRejectionCause']","",false, this.CurrentView);
 
            IDSite = RPSControlFactory.CreateRPSGridComboBox<MultiImputationView>("","#54ebd7c7-3b0f-421e-9ae4-7a18de60e25c .ag-row[role='row']@ROWINDEX [col-id='cIDSite']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<MultiImputationView> IDManufacturingOrder { get; set; } 
        public IRPSGridComboBox<MultiImputationView> IDMOTask { get; set; } 
        public IRPSGridTextBox<MultiImputationView> WorkSheetNumber { get; set; } 
        public IRPSGridTextBox<MultiImputationView> ManufacturedQuantity { get; set; } 
        public IRPSGridTextBox<MultiImputationView> RejectedQuantity { get; set; } 
        public IRPSGridComboBox<MultiImputationView> IDRejectionCause { get; set; } 
        public IRPSGridComboBox<MultiImputationView> IDSite { get; set; } 
                     
    }
 
    }
  
            
    public partial class MultiImputationGroupedTaskDialogView : View
    {
        public MultiImputationGroupedTaskDialogView(DataCaptureManufacturing screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UMOITaskGroup = RPSControlFactory.CreateRPSEnumComboBox<MultiImputationGroupedTaskDialogView>("4a3829cd-7031-4757-88eb-b0f1d7604c3e","","",false, this);
 
            CollectionInit params_MultiImputationTasksByGroup = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="e632ea24-8da0-4e13-ae72-28cdb99cc6b8",CSSSelectorGrid="",XPathGrid=""};
            MultiImputationTasksByGroup = RPSControlFactory.RPSCreateCollectionWithGrid<MultiImputationTasksByGroupCollectionEditor<MultiImputationGroupedTaskDialogView>,MultiImputationGroupedTaskDialogView>( params_MultiImputationTasksByGroup,this);
 

        }
        public IRPSComboBox<MultiImputationGroupedTaskDialogView> UMOITaskGroup { get; set; } 
        public MultiImputationTasksByGroupCollectionEditor<MultiImputationGroupedTaskDialogView> MultiImputationTasksByGroup { get; set; } 
        public DataCaptureManufacturing Screen { get; set; }
        public MultiImputationGroupedTaskDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MultiImputationTasksByGroupCollectionEditor<MultiImputationGroupedTaskDialogView>:RPSCollectionEditor<MultiImputationGroupedTaskDialogView> where MultiImputationGroupedTaskDialogView : class, IView
    {
        public  MultiImputationTasksByGroupGridView<MultiImputationGroupedTaskDialogView> GridView {get;set;}
    }
    public partial class MultiImputationTasksByGroupGridView <MultiImputationGroupedTaskDialogView> :  RPSGridView<MultiImputationGroupedTaskDialogView> where MultiImputationGroupedTaskDialogView : class, IView
    {
        public MultiImputationTasksByGroupGridView(MultiImputationGroupedTaskDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {

        }
                     
    }
 
    }
  
    

}