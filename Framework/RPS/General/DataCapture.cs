    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.DataCapture
{
    //RPS VERSION 1.0.0.0
    public partial class DataCapture:Screen
    {
        public DataCapture():base()
        {
            this.URL = "general.datacapture";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DataCaptureView  = new DataCaptureView(this); 
            InitiatedTasksDV  = new InitiatedTasksDV(this); 
            OutputMaterialsDV  = new OutputMaterialsDV(this); 
            TasksDV  = new TasksDV(this); 
            MOTaskMaterialDialogView  = new MOTaskMaterialDialogView(this); 
            ProjectTaskMaterialDV  = new ProjectTaskMaterialDV(this); 
            PlannedTasksDV  = new PlannedTasksDV(this); 
            DocsNotesDV  = new DocsNotesDV(this); 
            LabelsDV  = new LabelsDV(this); 
            NotesDV  = new NotesDV(this); 
            DocsDV  = new DocsDV(this); 
            RejectionCauseDV  = new RejectionCauseDV(this); 
            MultiImputationDV  = new MultiImputationDV(this); 
            TaskGroupDV  = new TaskGroupDV(this); 
            CheckListDV  = new CheckListDV(this); 
            DataCaptureView.InitializeControls(); 
            InitiatedTasksDV.InitializeControls(); 
            OutputMaterialsDV.InitializeControls(); 
            TasksDV.InitializeControls(); 
            MOTaskMaterialDialogView.InitializeControls(); 
            ProjectTaskMaterialDV.InitializeControls(); 
            PlannedTasksDV.InitializeControls(); 
            DocsNotesDV.InitializeControls(); 
            LabelsDV.InitializeControls(); 
            NotesDV.InitializeControls(); 
            DocsDV.InitializeControls(); 
            RejectionCauseDV.InitializeControls(); 
            MultiImputationDV.InitializeControls(); 
            TaskGroupDV.InitializeControls(); 
            CheckListDV.InitializeControls(); 
           
        }
      
            public DataCaptureView DataCaptureView {get; set; } 
            public InitiatedTasksDV InitiatedTasksDV {get; set; } 
            public OutputMaterialsDV OutputMaterialsDV {get; set; } 
            public TasksDV TasksDV {get; set; } 
            public MOTaskMaterialDialogView MOTaskMaterialDialogView {get; set; } 
            public ProjectTaskMaterialDV ProjectTaskMaterialDV {get; set; } 
            public PlannedTasksDV PlannedTasksDV {get; set; } 
            public DocsNotesDV DocsNotesDV {get; set; } 
            public LabelsDV LabelsDV {get; set; } 
            public NotesDV NotesDV {get; set; } 
            public DocsDV DocsDV {get; set; } 
            public RejectionCauseDV RejectionCauseDV {get; set; } 
            public MultiImputationDV MultiImputationDV {get; set; } 
            public TaskGroupDV TaskGroupDV {get; set; } 
            public CheckListDV CheckListDV {get; set; } 
    }
            
    public partial class DataCaptureView : View
    {
        public DataCaptureView(DataCapture screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            OutputMaterialsComm = RPSControlFactory.CreateRPSButton<DataCaptureView>( "a241fffe-396f-459a-9ddc-01536482004a","","",this);
 
            NewProjectWarningComm = RPSControlFactory.CreateRPSButton<DataCaptureView>( "c5fa6d02-0263-4526-a942-61bc8c2ae798","","",this);
 
            NewMaintenanceWarningComm = RPSControlFactory.CreateRPSButton<DataCaptureView>( "e5b3f94e-f50f-4da4-992c-e1bc1a4bc612","","",this);
 
            TicketRequestComm = RPSControlFactory.CreateRPSButton<DataCaptureView>( "160a48d7-d6cb-499c-9229-1e6ed0a41d5d","","",this);
 
            DocsNotesComm = RPSControlFactory.CreateRPSButton<DataCaptureView>( "f0cd76f1-300c-433b-9811-ad004be48428","","",this);
 
            LabelsComm = RPSControlFactory.CreateRPSButton<DataCaptureView>( "77d9b536-c590-41d8-9e84-82d3a0b9bfc9","","",this);
 
            MultiImputationComm = RPSControlFactory.CreateRPSButtonToView<DataCaptureView,MultiImputationDV>("ec0f65ce-66d4-4481-bdb9-e1e77e7127db","","", this,Screen.MultiImputationDV);
 
            CodEmployee = RPSControlFactory.CreateRPSComboBox<DataCaptureView>("4e9c2337-ccce-4606-a822-36606350ba2e","","",false, this);
 
            CheckInCommand = RPSControlFactory.CreateRPSButton<DataCaptureView>( "b7fd1a18-1f98-4047-ba8b-b1e3ebefd0bf","","",this);
 
            CheckOutCommand = RPSControlFactory.CreateRPSButton<DataCaptureView>( "c27033c4-b22e-4a25-8bb7-a008d137ad5f","","",this);
 
            StartComm = RPSControlFactory.CreateRPSButton<DataCaptureView>( "4a127b11-823f-4b9e-8313-8c444116d673","","",this);
 
            EndComm = RPSControlFactory.CreateRPSButton<DataCaptureView>( "79556cb6-ff09-4215-a245-29f4f3eae047","","",this);
 
            BarCode = RPSControlFactory.CreateRPSTextBox<DataCaptureView>("924046ea-18d8-4f60-97f7-7ce50347bb5c","","",false, this);
 
            CodMachine = RPSControlFactory.CreateRPSComboBox<DataCaptureView>("cc4aef6e-b345-494d-885b-9911c463252b","","",false, this);
 
            CodEmployee1 = RPSControlFactory.CreateRPSComboBox<DataCaptureView>("37b8c86f-5ad0-42d9-9442-bbd1fe33edd4","","",false, this);
 
            CodMOandProjects = RPSControlFactory.CreateRPSEnumComboBox<DataCaptureView>("e0647c08-c2ec-4dc7-a0f2-db2777b201fa","","",false, this);
 
            CodMOandProjectsTasks = RPSControlFactory.CreateRPSEnumComboBox<DataCaptureView>("4b601d5f-a01a-43f2-857c-547a3e599e19","","",false, this);
 
            QualityStatusComm = RPSControlFactory.CreateRPSButton<DataCaptureView>( "124d1e49-0d98-4ba2-9387-f30838cca961","","",this);
 
            CodMultiticket = RPSControlFactory.CreateRPSTextBox<DataCaptureView>("100999a2-87e5-4e71-af5d-155e3e0ce84d","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<DataCaptureView>("dc40f803-9313-4739-8914-93b1eed292b8","","",false, this);
 
            PreparationTime = RPSControlFactory.CreateRPSCheckBox<DataCaptureView>("0adf1ff6-2c6a-4064-be2b-944003372c0c","","",false, this);
 
            Unproductive = RPSControlFactory.CreateRPSCheckBox<DataCaptureView>("7fd90fc3-8172-4a2a-a09b-323c91ed2648","","",false, this);
 
            UnproductiveType = RPSControlFactory.CreateRPSComboBox<DataCaptureView>("41677427-6720-4165-8912-37b238635761","","",false, this);
 
            ManufacturedQuantity = RPSControlFactory.CreateRPSFormattedTextBox<DataCaptureView>("a20bbbca-3461-49db-bf14-e1229b7dd629","","",false, this);
 
            PercentProgress = RPSControlFactory.CreateRPSFormattedTextBox<DataCaptureView>("51dbbc86-8267-4772-bec9-3ae59855f220","","",false, this);
 
            FinishedTask = RPSControlFactory.CreateRPSCheckBox<DataCaptureView>("b6568636-19a6-40a3-ae2c-36cc07351289","","",false, this);
 
            StartDate = RPSControlFactory.CreateRPSTextBox<DataCaptureView>("9b87d032-cd35-4f88-a5c9-21a0a0551c3b","","",false, this);
 
            StartHour = RPSControlFactory.CreateRPSTextBox<DataCaptureView>("05d2018c-488c-4f65-a03d-88c684051f9a","","",false, this);
 
            InvestedTime = RPSControlFactory.CreateRPSTextBox<DataCaptureView>("1db19249-38a6-43af-ad5c-14c9da1f316c","","",false, this);
 
            CodHourType = RPSControlFactory.CreateRPSComboBox<DataCaptureView>("3cb09dc8-cdc2-45d9-a953-0f85750a03b8","","",false, this);
 
            RejectedQuantity = RPSControlFactory.CreateRPSFormattedTextBox<DataCaptureView>("8480309e-2cc3-4d0f-a724-b829b4ecc268","","",false, this);
 
            CodRejectionCause = RPSControlFactory.CreateRPSComboBox<DataCaptureView>("d9d1b74b-ac00-432a-8908-badb9bb634db","","",false, this);
 
            MoreRejectionCausesComm = RPSControlFactory.CreateRPSButton<DataCaptureView>( "f91f02d3-982e-4e73-afbd-1bd0d025252f","","",this);
 
            ConfirmComm = RPSControlFactory.CreateRPSButton<DataCaptureView>( "75d92227-9cef-4791-840a-5fe375227543","","",this);
 
            CancelComm = RPSControlFactory.CreateRPSButton<DataCaptureView>( "a4dc665a-9288-444e-89fa-42427e4e080d","","",this);
 
            TasksComm = RPSControlFactory.CreateRPSButton<DataCaptureView>( "91564f2f-1780-4caa-9887-271133f29767","","",this);
 
            PlannedTasksComm = RPSControlFactory.CreateRPSButton<DataCaptureView>( "69b816eb-7e6a-486a-9a16-e14f33804727","","",this);
 
            InitiatedTasksComm = RPSControlFactory.CreateRPSButton<DataCaptureView>( "7d843336-48a0-4872-af3d-96bc763b092c","","",this);
 

        }
        public IRPSButton<DataCaptureView> OutputMaterialsComm { get; set; } 
        public IRPSButton<DataCaptureView> NewProjectWarningComm { get; set; } 
        public IRPSButton<DataCaptureView> NewMaintenanceWarningComm { get; set; } 
        public IRPSButton<DataCaptureView> TicketRequestComm { get; set; } 
        public IRPSButton<DataCaptureView> DocsNotesComm { get; set; } 
        public IRPSButton<DataCaptureView> LabelsComm { get; set; } 
        public IRPSButton<DataCaptureView,MultiImputationDV> MultiImputationComm { get; set; } 
        public IRPSComboBox<DataCaptureView> CodEmployee { get; set; } 
        public IRPSButton<DataCaptureView> CheckInCommand { get; set; } 
        public IRPSButton<DataCaptureView> CheckOutCommand { get; set; } 
        public IRPSButton<DataCaptureView> StartComm { get; set; } 
        public IRPSButton<DataCaptureView> EndComm { get; set; } 
        public IRPSTextBox<DataCaptureView> BarCode { get; set; } 
        public IRPSComboBox<DataCaptureView> CodMachine { get; set; } 
        public IRPSComboBox<DataCaptureView> CodEmployee1 { get; set; } 
        public IRPSComboBox<DataCaptureView> CodMOandProjects { get; set; } 
        public IRPSComboBox<DataCaptureView> CodMOandProjectsTasks { get; set; } 
        public IRPSButton<DataCaptureView> QualityStatusComm { get; set; } 
        public IRPSTextBox<DataCaptureView> CodMultiticket { get; set; } 
        public IRPSTextBox<DataCaptureView> Description { get; set; } 
        public IRPSCheckbox<DataCaptureView> PreparationTime { get; set; } 
        public IRPSCheckbox<DataCaptureView> Unproductive { get; set; } 
        public IRPSComboBox<DataCaptureView> UnproductiveType { get; set; } 
        public IRPSTextBox<DataCaptureView> ManufacturedQuantity { get; set; } 
        public IRPSTextBox<DataCaptureView> PercentProgress { get; set; } 
        public IRPSCheckbox<DataCaptureView> FinishedTask { get; set; } 
        public IRPSTextBox<DataCaptureView> StartDate { get; set; } 
        public IRPSTextBox<DataCaptureView> StartHour { get; set; } 
        public IRPSTextBox<DataCaptureView> InvestedTime { get; set; } 
        public IRPSComboBox<DataCaptureView> CodHourType { get; set; } 
        public IRPSTextBox<DataCaptureView> RejectedQuantity { get; set; } 
        public IRPSComboBox<DataCaptureView> CodRejectionCause { get; set; } 
        public IRPSButton<DataCaptureView> MoreRejectionCausesComm { get; set; } 
        public IRPSButton<DataCaptureView> ConfirmComm { get; set; } 
        public IRPSButton<DataCaptureView> CancelComm { get; set; } 
        public IRPSButton<DataCaptureView> TasksComm { get; set; } 
        public IRPSButton<DataCaptureView> PlannedTasksComm { get; set; } 
        public IRPSButton<DataCaptureView> InitiatedTasksComm { get; set; } 
        public DataCapture Screen { get; set; }
        public DataCaptureView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class InitiatedTasksDV : View
    {
        public InitiatedTasksDV(DataCapture screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_GetInitiatedTasks = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b318ac3c-0b0d-4f77-b952-196c0b25aed1",CSSSelectorGrid="",XPathGrid=""};
            GetInitiatedTasks = RPSControlFactory.RPSCreateCollectionWithGrid<GetInitiatedTasksCollectionEditor<InitiatedTasksDV>,InitiatedTasksDV>( params_GetInitiatedTasks,this);
 

        }
        public GetInitiatedTasksCollectionEditor<InitiatedTasksDV> GetInitiatedTasks { get; set; } 
        public DataCapture Screen { get; set; }
        public InitiatedTasksDV Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetInitiatedTasksCollectionEditor<InitiatedTasksDV>:RPSCollectionEditor<InitiatedTasksDV> where InitiatedTasksDV : class, IView
    {
        public  GetInitiatedTasksGridView<InitiatedTasksDV> GridView {get;set;}
    }
    public partial class GetInitiatedTasksGridView <InitiatedTasksDV> :  RPSGridView<InitiatedTasksDV> where InitiatedTasksDV : class, IView
    {
        public GetInitiatedTasksGridView(InitiatedTasksDV currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Entity = RPSControlFactory.CreateRPSGridTextBox<InitiatedTasksDV>("","#b318ac3c-0b0d-4f77-b952-196c0b25aed1 .ag-row[role='row']@ROWINDEX [col-id='cEntity']","",false, this.CurrentView);
 
            EntityDesc = RPSControlFactory.CreateRPSGridTextBox<InitiatedTasksDV>("","#b318ac3c-0b0d-4f77-b952-196c0b25aed1 .ag-row[role='row']@ROWINDEX [col-id='cEntityDesc']","",false, this.CurrentView);
 
            EntityTask = RPSControlFactory.CreateRPSGridTextBox<InitiatedTasksDV>("","#b318ac3c-0b0d-4f77-b952-196c0b25aed1 .ag-row[role='row']@ROWINDEX [col-id='cEntityTask']","",false, this.CurrentView);
 
            EntityTaskDesc = RPSControlFactory.CreateRPSGridTextBox<InitiatedTasksDV>("","#b318ac3c-0b0d-4f77-b952-196c0b25aed1 .ag-row[role='row']@ROWINDEX [col-id='cEntityTaskDesc']","",false, this.CurrentView);
 
            Machine = RPSControlFactory.CreateRPSGridTextBox<InitiatedTasksDV>("","#b318ac3c-0b0d-4f77-b952-196c0b25aed1 .ag-row[role='row']@ROWINDEX [col-id='cMachine']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<InitiatedTasksDV>("","#b318ac3c-0b0d-4f77-b952-196c0b25aed1 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            InitialDate = RPSControlFactory.CreateRPSGridTextBox<InitiatedTasksDV>("","#b318ac3c-0b0d-4f77-b952-196c0b25aed1 .ag-row[role='row']@ROWINDEX [col-id='cInitialDate']","",false, this.CurrentView);
 
            InitialHour = RPSControlFactory.CreateRPSGridTextBox<InitiatedTasksDV>("","#b318ac3c-0b0d-4f77-b952-196c0b25aed1 .ag-row[role='row']@ROWINDEX [col-id='cInitialHour']","",false, this.CurrentView);
 
            InvestedTime = RPSControlFactory.CreateRPSGridTextBox<InitiatedTasksDV>("","#b318ac3c-0b0d-4f77-b952-196c0b25aed1 .ag-row[role='row']@ROWINDEX [col-id='cInvestedTime']","",false, this.CurrentView);
 
            Unproductive = RPSControlFactory.CreateRPSGridCheckBox<InitiatedTasksDV>("","#b318ac3c-0b0d-4f77-b952-196c0b25aed1 .ag-row[role='row']@ROWINDEX [col-id='cUnproductive']","",false, this.CurrentView);
 
            Preparation = RPSControlFactory.CreateRPSGridCheckBox<InitiatedTasksDV>("","#b318ac3c-0b0d-4f77-b952-196c0b25aed1 .ag-row[role='row']@ROWINDEX [col-id='cPreparation']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<InitiatedTasksDV> Entity { get; set; } 
        public IRPSGridTextBox<InitiatedTasksDV> EntityDesc { get; set; } 
        public IRPSGridTextBox<InitiatedTasksDV> EntityTask { get; set; } 
        public IRPSGridTextBox<InitiatedTasksDV> EntityTaskDesc { get; set; } 
        public IRPSGridTextBox<InitiatedTasksDV> Machine { get; set; } 
        public IRPSGridTextBox<InitiatedTasksDV> Description { get; set; } 
        public IRPSGridTextBox<InitiatedTasksDV> InitialDate { get; set; } 
        public IRPSGridTextBox<InitiatedTasksDV> InitialHour { get; set; } 
        public IRPSGridTextBox<InitiatedTasksDV> InvestedTime { get; set; } 
        public IRPSGridCheckbox<InitiatedTasksDV> Unproductive { get; set; } 
        public IRPSGridCheckbox<InitiatedTasksDV> Preparation { get; set; } 
                     
    }
 
    }
  
            
    public partial class OutputMaterialsDV : View
    {
        public OutputMaterialsDV(DataCapture screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CodMOandProjects = RPSControlFactory.CreateRPSEnumComboBox<OutputMaterialsDV>("836ebfbf-a30e-4a98-8d0a-a1e96df0c6eb","","",false, this);
 
            CodMOandProjectsTasks = RPSControlFactory.CreateRPSEnumComboBox<OutputMaterialsDV>("3da90287-3dee-4884-9443-34f2a008e242","","",false, this);
 
            ProjectMaterial = RPSControlFactory.CreateRPSCollectionComboBox<OutputMaterialsDV>("234a7296-cd70-4155-a579-aa1d6004668f","","",false, this);
 
            MOMaterial = RPSControlFactory.CreateRPSCollectionComboBox<OutputMaterialsDV>("82d74ff5-d370-4712-8132-b5d6322f9a6d","","",false, this);
 
            ConfirmComm = RPSControlFactory.CreateRPSButton<OutputMaterialsDV>( "586566db-e157-424b-813d-eb96a4f66497","","",this);
 
            CancelComm = RPSControlFactory.CreateRPSButton<OutputMaterialsDV>( "66584fe1-16be-4a11-b065-df7696a1af1e","","",this);
 
            AddToMaterialsGridButton = RPSControlFactory.CreateRPSButton<OutputMaterialsDV>( "84791f7a-a92f-4951-951d-8b9bac4ab3cd","","",this);
 
            CollectionInit params_OutputMaterialsCollection = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a4eb7935-94be-4eb1-be57-33a19d1fb2e4",CSSSelectorGrid="",XPathGrid=""};
            OutputMaterialsCollection = RPSControlFactory.RPSCreateCollectionWithGrid<OutputMaterialsCollectionCollectionEditor<OutputMaterialsDV,InitiatedTasksDV>,OutputMaterialsDV,InitiatedTasksDV>( params_OutputMaterialsCollection,this,Screen.InitiatedTasksDV);
 

        }
        public IRPSComboBox<OutputMaterialsDV> CodMOandProjects { get; set; } 
        public IRPSComboBox<OutputMaterialsDV> CodMOandProjectsTasks { get; set; } 
        public IRPSCollectionComboBox<OutputMaterialsDV> ProjectMaterial { get; set; } 
        public IRPSCollectionComboBox<OutputMaterialsDV> MOMaterial { get; set; } 
        public IRPSButton<OutputMaterialsDV> ConfirmComm { get; set; } 
        public IRPSButton<OutputMaterialsDV> CancelComm { get; set; } 
        public IRPSButton<OutputMaterialsDV> AddToMaterialsGridButton { get; set; } 
        public OutputMaterialsCollectionCollectionEditor<OutputMaterialsDV,InitiatedTasksDV> OutputMaterialsCollection { get; set; } 
        public DataCapture Screen { get; set; }
        public OutputMaterialsDV Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class OutputMaterialsCollectionCollectionEditor<OutputMaterialsDV,InitiatedTasksDV>:RPSCollectionEditor<OutputMaterialsDV,InitiatedTasksDV> where OutputMaterialsDV : class, IView where InitiatedTasksDV : class, IView
    {
        public  OutputMaterialsCollectionGridView<OutputMaterialsDV,InitiatedTasksDV> GridView {get;set;}
    }
    public partial class OutputMaterialsCollectionGridView <OutputMaterialsDV,InitiatedTasksDV> :  RPSGridView<OutputMaterialsDV,InitiatedTasksDV> where OutputMaterialsDV : class, IView where InitiatedTasksDV : class, IView
    {
        public OutputMaterialsCollectionGridView(OutputMaterialsDV currentView,InitiatedTasksDV newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<OutputMaterialsDV>("","#a4eb7935-94be-4eb1-be57-33a19d1fb2e4 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",false, this.CurrentView);
 
            IDWarehouse = RPSControlFactory.CreateRPSGridComboBox<OutputMaterialsDV>("","#a4eb7935-94be-4eb1-be57-33a19d1fb2e4 .ag-row[role='row']@ROWINDEX [col-id='cIDWarehouse']","",false, this.CurrentView);
 
            Series = RPSControlFactory.CreateRPSGridEnumComboBox<OutputMaterialsDV>("","#a4eb7935-94be-4eb1-be57-33a19d1fb2e4 .ag-row[role='row']@ROWINDEX [col-id='cSeries']","",false, this.CurrentView);
 
            IDLocationWarehouse = RPSControlFactory.CreateRPSGridComboBox<OutputMaterialsDV>("","#a4eb7935-94be-4eb1-be57-33a19d1fb2e4 .ag-row[role='row']@ROWINDEX [col-id='cIDLocationWarehouse']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<OutputMaterialsDV>("","#a4eb7935-94be-4eb1-be57-33a19d1fb2e4 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            SecondUnitQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<OutputMaterialsDV>("","#a4eb7935-94be-4eb1-be57-33a19d1fb2e4 .ag-row[role='row']@ROWINDEX [col-id='cSecondUnitQuantity']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<OutputMaterialsDV> IDArticle { get; set; } 
        public IRPSGridComboBox<OutputMaterialsDV> IDWarehouse { get; set; } 
        public IRPSGridComboBox<OutputMaterialsDV> Series { get; set; } 
        public IRPSGridComboBox<OutputMaterialsDV> IDLocationWarehouse { get; set; } 
        public IRPSGridTextBox<OutputMaterialsDV> Quantity { get; set; } 
        public IRPSGridTextBox<OutputMaterialsDV> SecondUnitQuantity { get; set; } 
                     
    }
 
    }
  
            
    public partial class TasksDV : View
    {
        public TasksDV(DataCapture screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_MOTask = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ad3677db-c33f-421a-9d3e-5d0649850af2",CSSSelectorGrid="",XPathGrid=""};
            MOTask = RPSControlFactory.RPSCreateCollectionWithGrid<MOTaskCollectionEditor<TasksDV,MOTaskMaterialDialogView>,TasksDV,MOTaskMaterialDialogView>( params_MOTask,this,Screen.MOTaskMaterialDialogView);
 
            CollectionInit params_ProjectTasks = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="2e1cee91-00b1-4fe4-a42f-514a2ad837cd",CSSSelectorGrid="",XPathGrid=""};
            ProjectTasks = RPSControlFactory.RPSCreateCollectionWithGrid<ProjectTasksCollectionEditor<TasksDV,MOTaskMaterialDialogView>,TasksDV,MOTaskMaterialDialogView>( params_ProjectTasks,this,Screen.MOTaskMaterialDialogView);
 
            MO = RPSControlFactory.CreateRPSSection<TasksDV>( "","ul li[rpsid='57401d17-4d68-47ac-8a4d-20903e2779bb']","",this);
 
            PRO = RPSControlFactory.CreateRPSSection<TasksDV>( "","ul li[rpsid='42481a13-67a0-4a0c-856e-9309663768fe']","",this);
 

        }
        public MOTaskCollectionEditor<TasksDV,MOTaskMaterialDialogView> MOTask { get; set; } 
        public ProjectTasksCollectionEditor<TasksDV,MOTaskMaterialDialogView> ProjectTasks { get; set; } 
        public IRPSSection<TasksDV> MO { get; set; } 
        public IRPSSection<TasksDV> PRO { get; set; } 
        public DataCapture Screen { get; set; }
        public TasksDV Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MOTaskCollectionEditor<TasksDV,MOTaskMaterialDialogView>:RPSCollectionEditor<TasksDV,MOTaskMaterialDialogView> where TasksDV : class, IView where MOTaskMaterialDialogView : class, IView
    {
        public  MOTaskGridView<TasksDV,MOTaskMaterialDialogView> GridView {get;set;}
    }
    public partial class MOTaskGridView <TasksDV,MOTaskMaterialDialogView> :  RPSGridView<TasksDV,MOTaskMaterialDialogView> where TasksDV : class, IView where MOTaskMaterialDialogView : class, IView
    {
        public MOTaskGridView(TasksDV currentView,MOTaskMaterialDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MOTask_CodMOTask = RPSControlFactory.CreateRPSGridTextBox<TasksDV>("","#ad3677db-c33f-421a-9d3e-5d0649850af2 .ag-row[role='row']@ROWINDEX [col-id='cMOTask_CodMOTask']","",false, this.CurrentView);
 
            MOTask_Description = RPSControlFactory.CreateRPSGridTextBox<TasksDV>("","#ad3677db-c33f-421a-9d3e-5d0649850af2 .ag-row[role='row']@ROWINDEX [col-id='cMOTask_Description']","",false, this.CurrentView);
 
            MOTask_PercentProgress = RPSControlFactory.CreateRPSGridFormattedTextBox<TasksDV>("","#ad3677db-c33f-421a-9d3e-5d0649850af2 .ag-row[role='row']@ROWINDEX [col-id='cMOTask_PercentProgress']","",false, this.CurrentView);
 
            QuantityAllowedToProcess = RPSControlFactory.CreateRPSGridFormattedTextBox<TasksDV>("","#ad3677db-c33f-421a-9d3e-5d0649850af2 .ag-row[role='row']@ROWINDEX [col-id='cQuantityAllowedToProcess']","",false, this.CurrentView);
 
            MOTask_Priority = RPSControlFactory.CreateRPSGridFormattedTextBox<TasksDV>("","#ad3677db-c33f-421a-9d3e-5d0649850af2 .ag-row[role='row']@ROWINDEX [col-id='cMOTask_Priority']","",false, this.CurrentView);
 
            MOTask_PlannedStartDate = RPSControlFactory.CreateRPSGridTextBox<TasksDV>("","#ad3677db-c33f-421a-9d3e-5d0649850af2 .ag-row[role='row']@ROWINDEX [col-id='cMOTask_PlannedStartDate']","",false, this.CurrentView);
 
            MOTask_OptimizationFeature = RPSControlFactory.CreateRPSGridTextBox<TasksDV>("","#ad3677db-c33f-421a-9d3e-5d0649850af2 .ag-row[role='row']@ROWINDEX [col-id='cMOTask_OptimizationFeature']","",false, this.CurrentView);
 
            ManufacturedQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<TasksDV>("","#ad3677db-c33f-421a-9d3e-5d0649850af2 .ag-row[role='row']@ROWINDEX [col-id='cManufacturedQuantity']","",false, this.CurrentView);
 
            ManufacturingOrder_InternalCode = RPSControlFactory.CreateRPSGridTextBox<TasksDV>("","#ad3677db-c33f-421a-9d3e-5d0649850af2 .ag-row[role='row']@ROWINDEX [col-id='cManufacturingOrder_InternalCode']","",false, this.CurrentView);
 
            NavigateToMaterials = RPSControlFactory.CreateRPSGridButton<TasksDV>( "","#ad3677db-c33f-421a-9d3e-5d0649850af2 .ag-row[role='row']@ROWINDEX [col-id='cNavigateToMaterials']","",this.CurrentView);
 

        }
        public IRPSGridTextBox<TasksDV> MOTask_CodMOTask { get; set; } 
        public IRPSGridTextBox<TasksDV> MOTask_Description { get; set; } 
        public IRPSGridTextBox<TasksDV> MOTask_PercentProgress { get; set; } 
        public IRPSGridTextBox<TasksDV> QuantityAllowedToProcess { get; set; } 
        public IRPSGridTextBox<TasksDV> MOTask_Priority { get; set; } 
        public IRPSGridTextBox<TasksDV> MOTask_PlannedStartDate { get; set; } 
        public IRPSGridTextBox<TasksDV> MOTask_OptimizationFeature { get; set; } 
        public IRPSGridTextBox<TasksDV> ManufacturedQuantity { get; set; } 
        public IRPSGridTextBox<TasksDV> ManufacturingOrder_InternalCode { get; set; } 
        public IRPSGridButton<TasksDV> NavigateToMaterials { get; set; } 
                     
    }
 
        public partial class ProjectTasksCollectionEditor<TasksDV,MOTaskMaterialDialogView>:RPSCollectionEditor<TasksDV,MOTaskMaterialDialogView> where TasksDV : class, IView where MOTaskMaterialDialogView : class, IView
    {
        public  ProjectTasksGridView<TasksDV,MOTaskMaterialDialogView> GridView {get;set;}
    }
    public partial class ProjectTasksGridView <TasksDV,MOTaskMaterialDialogView> :  RPSGridView<TasksDV,MOTaskMaterialDialogView> where TasksDV : class, IView where MOTaskMaterialDialogView : class, IView
    {
        public ProjectTasksGridView(TasksDV currentView,MOTaskMaterialDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ProjectTask_PercentProgress = RPSControlFactory.CreateRPSGridFormattedTextBox<TasksDV>("","#2e1cee91-00b1-4fe4-a42f-514a2ad837cd .ag-row[role='row']@ROWINDEX [col-id='cProjectTask_PercentProgress']","",false, this.CurrentView);
 
            NavigateToMaterials = RPSControlFactory.CreateRPSGridButton<TasksDV>( "","#2e1cee91-00b1-4fe4-a42f-514a2ad837cd .ag-row[role='row']@ROWINDEX [col-id='cNavigateToMaterials']","",this.CurrentView);
 

        }
        public IRPSGridTextBox<TasksDV> ProjectTask_PercentProgress { get; set; } 
        public IRPSGridButton<TasksDV> NavigateToMaterials { get; set; } 
                     
    }
 
    }
  
            
    public partial class MOTaskMaterialDialogView : View
    {
        public MOTaskMaterialDialogView(DataCapture screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_MOTaskMaterials = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="16ec09cd-eb55-4fc4-bf66-3fa9c0a7a7f3",CSSSelectorGrid="",XPathGrid=""};
            MOTaskMaterials = RPSControlFactory.RPSCreateCollectionWithGrid<MOTaskMaterialsCollectionEditor<MOTaskMaterialDialogView>,MOTaskMaterialDialogView>( params_MOTaskMaterials,this);
 

        }
        public MOTaskMaterialsCollectionEditor<MOTaskMaterialDialogView> MOTaskMaterials { get; set; } 
        public DataCapture Screen { get; set; }
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
            TheoricQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<MOTaskMaterialDialogView>("","#16ec09cd-eb55-4fc4-bf66-3fa9c0a7a7f3 .ag-row[role='row']@ROWINDEX [col-id='cTheoricQuantity']","",false, this.CurrentView);
 
            PendingQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<MOTaskMaterialDialogView>("","#16ec09cd-eb55-4fc4-bf66-3fa9c0a7a7f3 .ag-row[role='row']@ROWINDEX [col-id='cPendingQuantity']","",false, this.CurrentView);
 
            ProcessTheoricQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<MOTaskMaterialDialogView>("","#16ec09cd-eb55-4fc4-bf66-3fa9c0a7a7f3 .ag-row[role='row']@ROWINDEX [col-id='cProcessTheoricQuantity']","",false, this.CurrentView);
 
            NecessaryQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<MOTaskMaterialDialogView>("","#16ec09cd-eb55-4fc4-bf66-3fa9c0a7a7f3 .ag-row[role='row']@ROWINDEX [col-id='cNecessaryQuantity']","",false, this.CurrentView);
 
            AvailableStock = RPSControlFactory.CreateRPSGridFormattedTextBox<MOTaskMaterialDialogView>("","#16ec09cd-eb55-4fc4-bf66-3fa9c0a7a7f3 .ag-row[role='row']@ROWINDEX [col-id='cAvailableStock']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MOTaskMaterialDialogView> TheoricQuantity { get; set; } 
        public IRPSGridTextBox<MOTaskMaterialDialogView> PendingQuantity { get; set; } 
        public IRPSGridTextBox<MOTaskMaterialDialogView> ProcessTheoricQuantity { get; set; } 
        public IRPSGridTextBox<MOTaskMaterialDialogView> NecessaryQuantity { get; set; } 
        public IRPSGridTextBox<MOTaskMaterialDialogView> AvailableStock { get; set; } 
                     
    }
 
    }
  
            
    public partial class ProjectTaskMaterialDV : View
    {
        public ProjectTaskMaterialDV(DataCapture screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_ProjectTaskMaterial = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="49a4df22-4ffe-484e-98d9-f7208b26d0a4",CSSSelectorGrid="",XPathGrid=""};
            ProjectTaskMaterial = RPSControlFactory.RPSCreateCollectionWithGrid<ProjectTaskMaterialCollectionEditor<ProjectTaskMaterialDV>,ProjectTaskMaterialDV>( params_ProjectTaskMaterial,this);
 

        }
        public ProjectTaskMaterialCollectionEditor<ProjectTaskMaterialDV> ProjectTaskMaterial { get; set; } 
        public DataCapture Screen { get; set; }
        public ProjectTaskMaterialDV Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ProjectTaskMaterialCollectionEditor<ProjectTaskMaterialDV>:RPSCollectionEditor<ProjectTaskMaterialDV> where ProjectTaskMaterialDV : class, IView
    {
        public  ProjectTaskMaterialGridView<ProjectTaskMaterialDV> GridView {get;set;}
    }
    public partial class ProjectTaskMaterialGridView <ProjectTaskMaterialDV> :  RPSGridView<ProjectTaskMaterialDV> where ProjectTaskMaterialDV : class, IView
    {
        public ProjectTaskMaterialGridView(ProjectTaskMaterialDV currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            TeoricQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectTaskMaterialDV>("","#49a4df22-4ffe-484e-98d9-f7208b26d0a4 .ag-row[role='row']@ROWINDEX [col-id='cTeoricQuantity']","",false, this.CurrentView);
 
            PendingQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectTaskMaterialDV>("","#49a4df22-4ffe-484e-98d9-f7208b26d0a4 .ag-row[role='row']@ROWINDEX [col-id='cPendingQuantity']","",false, this.CurrentView);
 
            AvailableStock = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectTaskMaterialDV>("","#49a4df22-4ffe-484e-98d9-f7208b26d0a4 .ag-row[role='row']@ROWINDEX [col-id='cAvailableStock']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ProjectTaskMaterialDV> TeoricQuantity { get; set; } 
        public IRPSGridTextBox<ProjectTaskMaterialDV> PendingQuantity { get; set; } 
        public IRPSGridTextBox<ProjectTaskMaterialDV> AvailableStock { get; set; } 
                     
    }
 
    }
  
            
    public partial class PlannedTasksDV : View
    {
        public PlannedTasksDV(DataCapture screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_GetMOandProjectsPlannedTasks = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="4b16f652-0dc8-497e-b65e-1fa0b8564db8",CSSSelectorGrid="",XPathGrid=""};
            GetMOandProjectsPlannedTasks = RPSControlFactory.RPSCreateCollectionWithGrid<GetMOandProjectsPlannedTasksCollectionEditor<PlannedTasksDV>,PlannedTasksDV>( params_GetMOandProjectsPlannedTasks,this);
 

        }
        public GetMOandProjectsPlannedTasksCollectionEditor<PlannedTasksDV> GetMOandProjectsPlannedTasks { get; set; } 
        public DataCapture Screen { get; set; }
        public PlannedTasksDV Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetMOandProjectsPlannedTasksCollectionEditor<PlannedTasksDV>:RPSCollectionEditor<PlannedTasksDV> where PlannedTasksDV : class, IView
    {
        public  GetMOandProjectsPlannedTasksGridView<PlannedTasksDV> GridView {get;set;}
    }
    public partial class GetMOandProjectsPlannedTasksGridView <PlannedTasksDV> :  RPSGridView<PlannedTasksDV> where PlannedTasksDV : class, IView
    {
        public GetMOandProjectsPlannedTasksGridView(PlannedTasksDV currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Type = RPSControlFactory.CreateRPSGridTextBox<PlannedTasksDV>("","#4b16f652-0dc8-497e-b65e-1fa0b8564db8 .ag-row[role='row']@ROWINDEX [col-id='cType']","",false, this.CurrentView);
 
            Entity = RPSControlFactory.CreateRPSGridTextBox<PlannedTasksDV>("","#4b16f652-0dc8-497e-b65e-1fa0b8564db8 .ag-row[role='row']@ROWINDEX [col-id='cEntity']","",false, this.CurrentView);
 
            EntityDescription = RPSControlFactory.CreateRPSGridTextBox<PlannedTasksDV>("","#4b16f652-0dc8-497e-b65e-1fa0b8564db8 .ag-row[role='row']@ROWINDEX [col-id='cEntityDescription']","",false, this.CurrentView);
 
            EntityTask = RPSControlFactory.CreateRPSGridTextBox<PlannedTasksDV>("","#4b16f652-0dc8-497e-b65e-1fa0b8564db8 .ag-row[role='row']@ROWINDEX [col-id='cEntityTask']","",false, this.CurrentView);
 
            EntityTaskDescription = RPSControlFactory.CreateRPSGridTextBox<PlannedTasksDV>("","#4b16f652-0dc8-497e-b65e-1fa0b8564db8 .ag-row[role='row']@ROWINDEX [col-id='cEntityTaskDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<PlannedTasksDV> Type { get; set; } 
        public IRPSGridTextBox<PlannedTasksDV> Entity { get; set; } 
        public IRPSGridTextBox<PlannedTasksDV> EntityDescription { get; set; } 
        public IRPSGridTextBox<PlannedTasksDV> EntityTask { get; set; } 
        public IRPSGridTextBox<PlannedTasksDV> EntityTaskDescription { get; set; } 
                     
    }
 
    }
  
            
    public partial class DocsNotesDV : View
    {
        public DocsNotesDV(DataCapture screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CodMOandProjects = RPSControlFactory.CreateRPSEnumComboBox<DocsNotesDV>("649cbc43-5cce-4e82-be82-b0e07f72cd3f","","",false, this);
 
            CodMOandProjectsTasks = RPSControlFactory.CreateRPSEnumComboBox<DocsNotesDV>("4ce350f3-7f3e-492d-b9b1-2d22c23a701c","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSEnumComboBox<DocsNotesDV>("332f757c-98ab-42f3-a912-86ee5ede1b04","","",false, this);
 
            NotesComm = RPSControlFactory.CreateRPSButtonToView<DocsNotesDV,NotesDV>("0ef9c1f2-9475-4e0e-b0d5-707f5c291508","","", this,Screen.NotesDV);
 
            DocsComm = RPSControlFactory.CreateRPSButtonToView<DocsNotesDV,DocsDV>("5c26eaca-4fd8-4f6d-9feb-82165f372ece","","", this,Screen.DocsDV);
 

        }
        public IRPSComboBox<DocsNotesDV> CodMOandProjects { get; set; } 
        public IRPSComboBox<DocsNotesDV> CodMOandProjectsTasks { get; set; } 
        public IRPSComboBox<DocsNotesDV> IDArticle { get; set; } 
        public IRPSButton<DocsNotesDV,NotesDV> NotesComm { get; set; } 
        public IRPSButton<DocsNotesDV,DocsDV> DocsComm { get; set; } 
        public DataCapture Screen { get; set; }
        public DocsNotesDV Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class LabelsDV : View
    {
        public LabelsDV(DataCapture screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ManufacturingOrder = RPSControlFactory.CreateRPSComboBox<LabelsDV>("94d21790-0b8b-49f4-b1a1-4eb98acea10b","","",false, this);
 
            MOTask = RPSControlFactory.CreateRPSComboBox<LabelsDV>("a8afa3cd-88b6-4212-aecc-ec4204d7f42d","","",false, this);
 
            Labels = RPSControlFactory.CreateRPSFormattedTextBox<LabelsDV>("e6d4e8af-bb9c-4a5a-8512-aa8adc29d335","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<LabelsDV>("9b0b24ca-f747-4b9a-afd5-96938b2304e9","","",false, this);
 

        }
        public IRPSComboBox<LabelsDV> ManufacturingOrder { get; set; } 
        public IRPSComboBox<LabelsDV> MOTask { get; set; } 
        public IRPSTextBox<LabelsDV> Labels { get; set; } 
        public IRPSTextBox<LabelsDV> Quantity { get; set; } 
        public DataCapture Screen { get; set; }
        public LabelsDV Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NotesDV : View
    {
        public NotesDV(DataCapture screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            MOPROJNotes = RPSControlFactory.CreateRPSTextBox<NotesDV>("bb6d3c44-d76e-4073-8615-a5be08e574a2","","",false, this);
 
            MOPROJTaskNotes = RPSControlFactory.CreateRPSTextBox<NotesDV>("4b7f06f2-32c8-4108-8b07-753c237dfd19","","",false, this);
 
            ArticleNotes = RPSControlFactory.CreateRPSTextBox<NotesDV>("e6869c56-9bef-44b4-bf7e-e26f23b15d91","","",false, this);
 

        }
        public IRPSTextBox<NotesDV> MOPROJNotes { get; set; } 
        public IRPSTextBox<NotesDV> MOPROJTaskNotes { get; set; } 
        public IRPSTextBox<NotesDV> ArticleNotes { get; set; } 
        public DataCapture Screen { get; set; }
        public NotesDV Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DocsDV : View
    {
        public DocsDV(DataCapture screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public DataCapture Screen { get; set; }
        public DocsDV Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class RejectionCauseDV : View
    {
        public RejectionCauseDV(DataCapture screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_RejectionCausesCollection = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="96485862-62ad-46a5-a65a-8d0660df13e3",CSSSelectorGrid="",XPathGrid=""};
            RejectionCausesCollection = RPSControlFactory.RPSCreateCollectionWithGrid<RejectionCausesCollectionCollectionEditor<RejectionCauseDV>,RejectionCauseDV>( params_RejectionCausesCollection,this);
 

        }
        public RejectionCausesCollectionCollectionEditor<RejectionCauseDV> RejectionCausesCollection { get; set; } 
        public DataCapture Screen { get; set; }
        public RejectionCauseDV Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class RejectionCausesCollectionCollectionEditor<RejectionCauseDV>:RPSCollectionEditor<RejectionCauseDV> where RejectionCauseDV : class, IView
    {
        public  RejectionCausesCollectionGridView<RejectionCauseDV> GridView {get;set;}
    }
    public partial class RejectionCausesCollectionGridView <RejectionCauseDV> :  RPSGridView<RejectionCauseDV> where RejectionCauseDV : class, IView
    {
        public RejectionCausesCollectionGridView(RejectionCauseDV currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDRejectionCause = RPSControlFactory.CreateRPSGridComboBox<RejectionCauseDV>("","#96485862-62ad-46a5-a65a-8d0660df13e3 .ag-row[role='row']@ROWINDEX [col-id='cIDRejectionCause']","",false, this.CurrentView);
 
            RejectedQty = RPSControlFactory.CreateRPSGridFormattedTextBox<RejectionCauseDV>("","#96485862-62ad-46a5-a65a-8d0660df13e3 .ag-row[role='row']@ROWINDEX [col-id='cRejectedQty']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<RejectionCauseDV> IDRejectionCause { get; set; } 
        public IRPSGridTextBox<RejectionCauseDV> RejectedQty { get; set; } 
                     
    }
 
    }
  
            
    public partial class MultiImputationDV : View
    {
        public MultiImputationDV(DataCapture screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CodMachine = RPSControlFactory.CreateRPSComboBox<MultiImputationDV>("6a946ba9-cf9d-44ce-bfc7-7df74f644ea5","","",false, this);
 
            CodMultiticket = RPSControlFactory.CreateRPSTextBox<MultiImputationDV>("d03aa287-ae8d-4d09-a14d-dcb574e4ee39","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<MultiImputationDV>("665e6cb4-0b83-4a4e-a5b3-aa5b3861961d","","",false, this);
 
            SaveCommButton = RPSControlFactory.CreateRPSButton<MultiImputationDV>( "1ab0fac7-3791-4c92-85b2-557075fbae42","","",this);
 
            EndMultiTicketCommButton = RPSControlFactory.CreateRPSButton<MultiImputationDV>( "c60e42f4-82f1-48f0-be91-a7d664a6b331","","",this);
 
            TaskGroupCommButton = RPSControlFactory.CreateRPSButtonToView<MultiImputationDV,TaskGroupDV>("47f2d5e7-e144-4082-b623-f1f3b9011013","","", this,Screen.TaskGroupDV);
 
            CollectionInit params_TasksCollection = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="00f26e25-0300-4a4e-829d-4501647c8290",CSSSelectorGrid="",XPathGrid=""};
            TasksCollection = RPSControlFactory.RPSCreateCollectionWithGrid<TasksCollectionCollectionEditor<MultiImputationDV,TaskGroupDV>,MultiImputationDV,TaskGroupDV>( params_TasksCollection,this,Screen.TaskGroupDV);
 

        }
        public IRPSComboBox<MultiImputationDV> CodMachine { get; set; } 
        public IRPSTextBox<MultiImputationDV> CodMultiticket { get; set; } 
        public IRPSTextBox<MultiImputationDV> Description { get; set; } 
        public IRPSButton<MultiImputationDV> SaveCommButton { get; set; } 
        public IRPSButton<MultiImputationDV> EndMultiTicketCommButton { get; set; } 
        public IRPSButton<MultiImputationDV,TaskGroupDV> TaskGroupCommButton { get; set; } 
        public TasksCollectionCollectionEditor<MultiImputationDV,TaskGroupDV> TasksCollection { get; set; } 
        public DataCapture Screen { get; set; }
        public MultiImputationDV Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class TasksCollectionCollectionEditor<MultiImputationDV,TaskGroupDV>:RPSCollectionEditor<MultiImputationDV,TaskGroupDV> where MultiImputationDV : class, IView where TaskGroupDV : class, IView
    {
        public  TasksCollectionGridView<MultiImputationDV,TaskGroupDV> GridView {get;set;}
    }
    public partial class TasksCollectionGridView <MultiImputationDV,TaskGroupDV> :  RPSGridView<MultiImputationDV,TaskGroupDV> where MultiImputationDV : class, IView where TaskGroupDV : class, IView
    {
        public TasksCollectionGridView(MultiImputationDV currentView,TaskGroupDV newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodManufacturingOrder = RPSControlFactory.CreateRPSGridComboBox<MultiImputationDV>("","#00f26e25-0300-4a4e-829d-4501647c8290 .ag-row[role='row']@ROWINDEX [col-id='cManufacturingOrder']","",false, this.CurrentView);
 
            CodMOTask = RPSControlFactory.CreateRPSGridComboBox<MultiImputationDV>("","#00f26e25-0300-4a4e-829d-4501647c8290 .ag-row[role='row']@ROWINDEX [col-id='cMOTask']","",false, this.CurrentView);
 
            ManufacturedQty = RPSControlFactory.CreateRPSGridFormattedTextBox<MultiImputationDV>("","#00f26e25-0300-4a4e-829d-4501647c8290 .ag-row[role='row']@ROWINDEX [col-id='cManufacturedQty']","",false, this.CurrentView);
 
            RejectedQty = RPSControlFactory.CreateRPSGridFormattedTextBox<MultiImputationDV>("","#00f26e25-0300-4a4e-829d-4501647c8290 .ag-row[role='row']@ROWINDEX [col-id='cRejectedQty']","",false, this.CurrentView);
 
            RejectionCause = RPSControlFactory.CreateRPSGridEnumComboBox<MultiImputationDV>("","#00f26e25-0300-4a4e-829d-4501647c8290 .ag-row[role='row']@ROWINDEX [col-id='cRejectionCause']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<MultiImputationDV> CodManufacturingOrder { get; set; } 
        public IRPSGridComboBox<MultiImputationDV> CodMOTask { get; set; } 
        public IRPSGridTextBox<MultiImputationDV> ManufacturedQty { get; set; } 
        public IRPSGridTextBox<MultiImputationDV> RejectedQty { get; set; } 
        public IRPSGridComboBox<MultiImputationDV> RejectionCause { get; set; } 
                     
    }
 
    }
  
            
    public partial class TaskGroupDV : View
    {
        public TaskGroupDV(DataCapture screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            TaskGroupNumber = RPSControlFactory.CreateRPSEnumComboBox<TaskGroupDV>("ccb96d2b-279b-4f80-875f-833ac6b37e08","","",false, this);
 
            AddToMultiImputationTaskCommButton = RPSControlFactory.CreateRPSButton<TaskGroupDV>( "d65fdc87-07d6-4196-9a2e-a89de57a0498","","",this);
 
            CollectionInit params_GetTasksInGroupingNumber = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="c3b0380b-6b12-411c-a6c0-5d40ea8b3237",CSSSelectorGrid="",XPathGrid=""};
            GetTasksInGroupingNumber = RPSControlFactory.RPSCreateCollectionWithGrid<GetTasksInGroupingNumberCollectionEditor<TaskGroupDV>,TaskGroupDV>( params_GetTasksInGroupingNumber,this);
 

        }
        public IRPSComboBox<TaskGroupDV> TaskGroupNumber { get; set; } 
        public IRPSButton<TaskGroupDV> AddToMultiImputationTaskCommButton { get; set; } 
        public GetTasksInGroupingNumberCollectionEditor<TaskGroupDV> GetTasksInGroupingNumber { get; set; } 
        public DataCapture Screen { get; set; }
        public TaskGroupDV Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetTasksInGroupingNumberCollectionEditor<TaskGroupDV>:RPSCollectionEditor<TaskGroupDV> where TaskGroupDV : class, IView
    {
        public  GetTasksInGroupingNumberGridView<TaskGroupDV> GridView {get;set;}
    }
    public partial class GetTasksInGroupingNumberGridView <TaskGroupDV> :  RPSGridView<TaskGroupDV> where TaskGroupDV : class, IView
    {
        public GetTasksInGroupingNumberGridView(TaskGroupDV currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ManufacturingOrder = RPSControlFactory.CreateRPSGridTextBox<TaskGroupDV>("","#c3b0380b-6b12-411c-a6c0-5d40ea8b3237 .ag-row[role='row']@ROWINDEX [col-id='cManufacturingOrder']","",false, this.CurrentView);
 
            MODescription = RPSControlFactory.CreateRPSGridTextBox<TaskGroupDV>("","#c3b0380b-6b12-411c-a6c0-5d40ea8b3237 .ag-row[role='row']@ROWINDEX [col-id='cMODescription']","",false, this.CurrentView);
 
            MOTask = RPSControlFactory.CreateRPSGridTextBox<TaskGroupDV>("","#c3b0380b-6b12-411c-a6c0-5d40ea8b3237 .ag-row[role='row']@ROWINDEX [col-id='cMOTask']","",false, this.CurrentView);
 
            MOTaskDescription = RPSControlFactory.CreateRPSGridTextBox<TaskGroupDV>("","#c3b0380b-6b12-411c-a6c0-5d40ea8b3237 .ag-row[role='row']@ROWINDEX [col-id='cMOTaskDescription']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<TaskGroupDV> ManufacturingOrder { get; set; } 
        public IRPSGridTextBox<TaskGroupDV> MODescription { get; set; } 
        public IRPSGridTextBox<TaskGroupDV> MOTask { get; set; } 
        public IRPSGridTextBox<TaskGroupDV> MOTaskDescription { get; set; } 
                     
    }
 
    }
  
            
    public partial class CheckListDV : View
    {
        public CheckListDV(DataCapture screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            PostponeChecklist = RPSControlFactory.CreateRPSCheckBox<CheckListDV>("4429fae5-0dd8-4901-8147-64bb4758d35d","","",false, this);
 
            CollectionInit params_GetTaskCheckList = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="495d5fc0-737f-46d1-bb31-92b295ad404c",CSSSelectorGrid="",XPathGrid=""};
            GetTaskCheckList = RPSControlFactory.RPSCreateCollectionWithGrid<GetTaskCheckListCollectionEditor<CheckListDV>,CheckListDV>( params_GetTaskCheckList,this);
 

        }
        public IRPSCheckbox<CheckListDV> PostponeChecklist { get; set; } 
        public GetTaskCheckListCollectionEditor<CheckListDV> GetTaskCheckList { get; set; } 
        public DataCapture Screen { get; set; }
        public CheckListDV Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GetTaskCheckListCollectionEditor<CheckListDV>:RPSCollectionEditor<CheckListDV> where CheckListDV : class, IView
    {
        public  GetTaskCheckListGridView<CheckListDV> GridView {get;set;}
    }
    public partial class GetTaskCheckListGridView <CheckListDV> :  RPSGridView<CheckListDV> where CheckListDV : class, IView
    {
        public GetTaskCheckListGridView(CheckListDV currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CustomQuestion = RPSControlFactory.CreateRPSGridTextBox<CheckListDV>("","#495d5fc0-737f-46d1-bb31-92b295ad404c .ag-row[role='row']@ROWINDEX [col-id='cCustomQuestion']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CheckListDV> CustomQuestion { get; set; } 
                     
    }
 
    }
  
    

}