    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.DataCaptureProject
{
    //RPS VERSION 1.0.0.0
    public partial class DataCaptureProject:Screen
    {
        public DataCaptureProject():base()
        {
            this.URL = "project.datacaptureproject";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DataCaptureProjectView  = new DataCaptureProjectView(this); 
            DataCaptureProjectTaskDialogView  = new DataCaptureProjectTaskDialogView(this); 
            DataCaptureProjectTaskPlannedDialogView  = new DataCaptureProjectTaskPlannedDialogView(this); 
            DataCaptureProjectMaterialsDialogView  = new DataCaptureProjectMaterialsDialogView(this); 
            DataCaptureProjectView.InitializeControls(); 
            DataCaptureProjectTaskDialogView.InitializeControls(); 
            DataCaptureProjectTaskPlannedDialogView.InitializeControls(); 
            DataCaptureProjectMaterialsDialogView.InitializeControls(); 
           
        }
      
            public DataCaptureProjectView DataCaptureProjectView {get; set; } 
            public DataCaptureProjectTaskDialogView DataCaptureProjectTaskDialogView {get; set; } 
            public DataCaptureProjectTaskPlannedDialogView DataCaptureProjectTaskPlannedDialogView {get; set; } 
            public DataCaptureProjectMaterialsDialogView DataCaptureProjectMaterialsDialogView {get; set; } 
    }
            
    public partial class DataCaptureProjectView : View
    {
        public DataCaptureProjectView(DataCaptureProject screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ConsultDate = RPSControlFactory.CreateRPSTextBox<DataCaptureProjectView>("13066a8f-2dc5-4a85-9a24-1f4d3e95fcf0","","",false, this);
 
            ConsultTime = RPSControlFactory.CreateRPSTextBox<DataCaptureProjectView>("bddca947-001a-47ce-8ddc-a98ce3fb6d80","","",false, this);
 
            CheckInCommand = RPSControlFactory.CreateRPSButton<DataCaptureProjectView>( "e7c10c1b-88da-478c-b870-b0aa142898eb","","",this);
 
            CheckOutCommand = RPSControlFactory.CreateRPSButton<DataCaptureProjectView>( "dca5b8ab-cddc-4f63-b18b-45c41b13a502","","",this);
 
            Employee = RPSControlFactory.CreateRPSComboBox<DataCaptureProjectView>("8cb69743-d31d-4a90-8bcb-df95df3ccbb4","","",false, this);
 
            DataCaptureProjectTaskNavigationCommand = RPSControlFactory.CreateRPSButtonToView<DataCaptureProjectView,DataCaptureProjectTaskDialogView>("02f16e58-c110-4556-94af-dfee06aa8076","","", this,Screen.DataCaptureProjectTaskDialogView);
 
            Project = RPSControlFactory.CreateRPSComboBox<DataCaptureProjectView>("15ec59ce-a681-42b9-bdff-0956cd2be9d3","","",false, this);
 
            ProjectTask = RPSControlFactory.CreateRPSComboBox<DataCaptureProjectView>("cbc61162-5abc-4ce1-ab95-edb059617fa4","","",false, this);
 
            DataCaptureProjectTaskPlannedNavigationCommand = RPSControlFactory.CreateRPSButtonToView<DataCaptureProjectView,DataCaptureProjectTaskPlannedDialogView>("77c45d0d-1b88-49a0-98d9-c13b08843728","","", this,Screen.DataCaptureProjectTaskPlannedDialogView);
 
            Machine = RPSControlFactory.CreateRPSComboBox<DataCaptureProjectView>("b9d21346-070f-4226-8165-5012f216dc33","","",false, this);
 
            CheckMachineImputation = RPSControlFactory.CreateRPSCheckBox<DataCaptureProjectView>("f9895625-57ae-4bc8-9bb0-a01f55e0e524","","",false, this);
 
            ExecuteDataCaptureStart = RPSControlFactory.CreateRPSButton<DataCaptureProjectView>( "832b6603-a227-4a79-adf6-1c34a02e8699","","",this);
 
            Description = RPSControlFactory.CreateRPSTextBox<DataCaptureProjectView>("b81ad596-c7bd-45b9-87f9-b7d7b18f53fc","","",false, this);
 
            StartDate = RPSControlFactory.CreateRPSTextBox<DataCaptureProjectView>("d485674e-e451-4192-bc42-5e5b5c36ea59","","",false, this);
 
            StartHour = RPSControlFactory.CreateRPSTextBox<DataCaptureProjectView>("02f4e915-aba3-4c9b-8f77-bb25461507ac","","",false, this);
 
            ExecuteDataCaptureStop = RPSControlFactory.CreateRPSButton<DataCaptureProjectView>( "5309b33e-2bcd-4f68-b7ea-1eb135496268","","",this);
 
            StartDate1 = RPSControlFactory.CreateRPSTextBox<DataCaptureProjectView>("1975176f-8d7d-4735-9ef5-32c63c49a9f9","","",false, this);
 
            StartHour1 = RPSControlFactory.CreateRPSTextBox<DataCaptureProjectView>("6daa23cf-d3e7-430c-9c48-f9a59276c2bb","","",false, this);
 
            EndHour = RPSControlFactory.CreateRPSTextBox<DataCaptureProjectView>("b61c5855-e2fb-427f-802f-998807f1fa5d","","",false, this);
 
            ImputationTime = RPSControlFactory.CreateRPSTextBox<DataCaptureProjectView>("4fc80b97-d444-42be-8610-12ad1602b9aa","","",false, this);
 
            ImpTime = RPSControlFactory.CreateRPSTextBox<DataCaptureProjectView>("3e665469-c4f3-46a0-92ca-ef13de3e90e2","","",false, this);
 
            EstimatedTime = RPSControlFactory.CreateRPSFormattedTextBox<DataCaptureProjectView>("33fee349-806e-436e-a1ba-1bdc5ad88762","","",false, this);
 
            Progress = RPSControlFactory.CreateRPSFormattedTextBox<DataCaptureProjectView>("35dfe807-cd23-47b3-a365-f34f9ca963a3","","",false, this);
 
            HourType = RPSControlFactory.CreateRPSComboBox<DataCaptureProjectView>("962ceeeb-3525-4fef-a832-0ed7e2811a9b","","",false, this);
 
            PreparedTime = RPSControlFactory.CreateRPSCheckBox<DataCaptureProjectView>("f70b788e-f48f-455f-b6f1-29ca59ba09b9","","",false, this);
 
            Unproductive = RPSControlFactory.CreateRPSCheckBox<DataCaptureProjectView>("507b98d4-8ab6-4a37-a78b-eba97de366f1","","",false, this);
 
            UnproductiveType = RPSControlFactory.CreateRPSComboBox<DataCaptureProjectView>("bfb5dd6a-8c81-491b-9ca3-3e75902ae99c","","",false, this);
 
            ExecuteDataCaptureEnd = RPSControlFactory.CreateRPSButton<DataCaptureProjectView>( "27a80c6f-7af5-42c2-8876-ee69409aa258","","",this);
 
            NavigationToAutomaticExitCommButton = RPSControlFactory.CreateRPSButton<DataCaptureProjectView>( "3e7777fd-d6cb-4faa-aa9e-cc1a9086db65","","",this);
 
            NavigationToImputationMaterialCommButton = RPSControlFactory.CreateRPSButton<DataCaptureProjectView>( "7b2b2f43-f7c8-4bb4-a8b3-46ffeeb2cca2","","",this);
 
            ProjectDocumentationCommandButton = RPSControlFactory.CreateRPSButton<DataCaptureProjectView>( "65f6e89b-d668-4e6d-b17b-670c39bc4225","","",this);
 
            ProjectTaskDocumentationCommandButton = RPSControlFactory.CreateRPSButton<DataCaptureProjectView>( "ea3acc72-3821-4aad-acc2-8adadfbe0122","","",this);
 
            NavigationToWarningCommButton = RPSControlFactory.CreateRPSButton<DataCaptureProjectView>( "5f4ab4e9-b628-4ea0-b8ee-ac257b026955","","",this);
 

        }
        public IRPSTextBox<DataCaptureProjectView> ConsultDate { get; set; } 
        public IRPSTextBox<DataCaptureProjectView> ConsultTime { get; set; } 
        public IRPSButton<DataCaptureProjectView> CheckInCommand { get; set; } 
        public IRPSButton<DataCaptureProjectView> CheckOutCommand { get; set; } 
        public IRPSComboBox<DataCaptureProjectView> Employee { get; set; } 
        public IRPSButton<DataCaptureProjectView,DataCaptureProjectTaskDialogView> DataCaptureProjectTaskNavigationCommand { get; set; } 
        public IRPSComboBox<DataCaptureProjectView> Project { get; set; } 
        public IRPSComboBox<DataCaptureProjectView> ProjectTask { get; set; } 
        public IRPSButton<DataCaptureProjectView,DataCaptureProjectTaskPlannedDialogView> DataCaptureProjectTaskPlannedNavigationCommand { get; set; } 
        public IRPSComboBox<DataCaptureProjectView> Machine { get; set; } 
        public IRPSCheckbox<DataCaptureProjectView> CheckMachineImputation { get; set; } 
        public IRPSButton<DataCaptureProjectView> ExecuteDataCaptureStart { get; set; } 
        public IRPSTextBox<DataCaptureProjectView> Description { get; set; } 
        public IRPSTextBox<DataCaptureProjectView> StartDate { get; set; } 
        public IRPSTextBox<DataCaptureProjectView> StartHour { get; set; } 
        public IRPSButton<DataCaptureProjectView> ExecuteDataCaptureStop { get; set; } 
        public IRPSTextBox<DataCaptureProjectView> StartDate1 { get; set; } 
        public IRPSTextBox<DataCaptureProjectView> StartHour1 { get; set; } 
        public IRPSTextBox<DataCaptureProjectView> EndHour { get; set; } 
        public IRPSTextBox<DataCaptureProjectView> ImputationTime { get; set; } 
        public IRPSTextBox<DataCaptureProjectView> ImpTime { get; set; } 
        public IRPSTextBox<DataCaptureProjectView> EstimatedTime { get; set; } 
        public IRPSTextBox<DataCaptureProjectView> Progress { get; set; } 
        public IRPSComboBox<DataCaptureProjectView> HourType { get; set; } 
        public IRPSCheckbox<DataCaptureProjectView> PreparedTime { get; set; } 
        public IRPSCheckbox<DataCaptureProjectView> Unproductive { get; set; } 
        public IRPSComboBox<DataCaptureProjectView> UnproductiveType { get; set; } 
        public IRPSButton<DataCaptureProjectView> ExecuteDataCaptureEnd { get; set; } 
        public IRPSButton<DataCaptureProjectView> NavigationToAutomaticExitCommButton { get; set; } 
        public IRPSButton<DataCaptureProjectView> NavigationToImputationMaterialCommButton { get; set; } 
        public IRPSButton<DataCaptureProjectView> ProjectDocumentationCommandButton { get; set; } 
        public IRPSButton<DataCaptureProjectView> ProjectTaskDocumentationCommandButton { get; set; } 
        public IRPSButton<DataCaptureProjectView> NavigationToWarningCommButton { get; set; } 
        public DataCaptureProject Screen { get; set; }
        public DataCaptureProjectView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class DataCaptureProjectTaskDialogView : View
    {
        public DataCaptureProjectTaskDialogView(DataCaptureProject screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_DataCaptureTasks = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="741e4b68-e4ae-4cd9-a366-f828a82164f1",CSSSelectorGrid="",XPathGrid=""};
            DataCaptureTasks = RPSControlFactory.RPSCreateCollectionWithGrid<DataCaptureTasksCollectionEditor<DataCaptureProjectTaskDialogView,DataCaptureProjectMaterialsDialogView>,DataCaptureProjectTaskDialogView,DataCaptureProjectMaterialsDialogView>( params_DataCaptureTasks,this,Screen.DataCaptureProjectMaterialsDialogView);
 

        }
        public DataCaptureTasksCollectionEditor<DataCaptureProjectTaskDialogView,DataCaptureProjectMaterialsDialogView> DataCaptureTasks { get; set; } 
        public DataCaptureProject Screen { get; set; }
        public DataCaptureProjectTaskDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DataCaptureTasksCollectionEditor<DataCaptureProjectTaskDialogView,DataCaptureProjectMaterialsDialogView>:RPSCollectionEditor<DataCaptureProjectTaskDialogView,DataCaptureProjectMaterialsDialogView> where DataCaptureProjectTaskDialogView : class, IView where DataCaptureProjectMaterialsDialogView : class, IView
    {
        public  DataCaptureTasksGridView<DataCaptureProjectTaskDialogView,DataCaptureProjectMaterialsDialogView> GridView {get;set;}
    }
    public partial class DataCaptureTasksGridView <DataCaptureProjectTaskDialogView,DataCaptureProjectMaterialsDialogView> :  RPSGridView<DataCaptureProjectTaskDialogView,DataCaptureProjectMaterialsDialogView> where DataCaptureProjectTaskDialogView : class, IView where DataCaptureProjectMaterialsDialogView : class, IView
    {
        public DataCaptureTasksGridView(DataCaptureProjectTaskDialogView currentView,DataCaptureProjectMaterialsDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ProjectTask_PercentProgress = RPSControlFactory.CreateRPSGridFormattedTextBox<DataCaptureProjectTaskDialogView>("","#741e4b68-e4ae-4cd9-a366-f828a82164f1 .ag-row[role='row']@ROWINDEX [col-id='cProjectTask_PercentProgress']","",false, this.CurrentView);
 
            NavigateToMaterialsCommand = RPSControlFactory.CreateRPSGridButton<DataCaptureProjectTaskDialogView>( "","#741e4b68-e4ae-4cd9-a366-f828a82164f1 .ag-row[role='row']@ROWINDEX [col-id='cNavigateToMaterials']","",this.CurrentView);
 

        }
        public IRPSGridTextBox<DataCaptureProjectTaskDialogView> ProjectTask_PercentProgress { get; set; } 
        public IRPSGridButton<DataCaptureProjectTaskDialogView> NavigateToMaterialsCommand { get; set; } 
                     
    }
 
    }
  
            
    public partial class DataCaptureProjectTaskPlannedDialogView : View
    {
        public DataCaptureProjectTaskPlannedDialogView(DataCaptureProject screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_DataCaptureTasksPlannified = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d3532666-d178-4b03-8cac-389acc789fc8",CSSSelectorGrid="",XPathGrid=""};
            DataCaptureTasksPlannified = RPSControlFactory.RPSCreateCollectionWithGrid<DataCaptureTasksPlannifiedCollectionEditor<DataCaptureProjectTaskPlannedDialogView>,DataCaptureProjectTaskPlannedDialogView>( params_DataCaptureTasksPlannified,this);
 

        }
        public DataCaptureTasksPlannifiedCollectionEditor<DataCaptureProjectTaskPlannedDialogView> DataCaptureTasksPlannified { get; set; } 
        public DataCaptureProject Screen { get; set; }
        public DataCaptureProjectTaskPlannedDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DataCaptureTasksPlannifiedCollectionEditor<DataCaptureProjectTaskPlannedDialogView>:RPSCollectionEditor<DataCaptureProjectTaskPlannedDialogView> where DataCaptureProjectTaskPlannedDialogView : class, IView
    {
        public  DataCaptureTasksPlannifiedGridView<DataCaptureProjectTaskPlannedDialogView> GridView {get;set;}
    }
    public partial class DataCaptureTasksPlannifiedGridView <DataCaptureProjectTaskPlannedDialogView> :  RPSGridView<DataCaptureProjectTaskPlannedDialogView> where DataCaptureProjectTaskPlannedDialogView : class, IView
    {
        public DataCaptureTasksPlannifiedGridView(DataCaptureProjectTaskPlannedDialogView currentView)
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
  
            
    public partial class DataCaptureProjectMaterialsDialogView : View
    {
        public DataCaptureProjectMaterialsDialogView(DataCaptureProject screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            CollectionInit params_DataCaptureMaterials = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="ea50f468-bf70-4105-a37d-4919eb3f6aa1",CSSSelectorGrid="",XPathGrid=""};
            DataCaptureMaterials = RPSControlFactory.RPSCreateCollectionWithGrid<DataCaptureMaterialsCollectionEditor<DataCaptureProjectMaterialsDialogView>,DataCaptureProjectMaterialsDialogView>( params_DataCaptureMaterials,this);
 

        }
        public DataCaptureMaterialsCollectionEditor<DataCaptureProjectMaterialsDialogView> DataCaptureMaterials { get; set; } 
        public DataCaptureProject Screen { get; set; }
        public DataCaptureProjectMaterialsDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DataCaptureMaterialsCollectionEditor<DataCaptureProjectMaterialsDialogView>:RPSCollectionEditor<DataCaptureProjectMaterialsDialogView> where DataCaptureProjectMaterialsDialogView : class, IView
    {
        public  DataCaptureMaterialsGridView<DataCaptureProjectMaterialsDialogView> GridView {get;set;}
    }
    public partial class DataCaptureMaterialsGridView <DataCaptureProjectMaterialsDialogView> :  RPSGridView<DataCaptureProjectMaterialsDialogView> where DataCaptureProjectMaterialsDialogView : class, IView
    {
        public DataCaptureMaterialsGridView(DataCaptureProjectMaterialsDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            TeoricQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<DataCaptureProjectMaterialsDialogView>("","#ea50f468-bf70-4105-a37d-4919eb3f6aa1 .ag-row[role='row']@ROWINDEX [col-id='cTeoricQuantity']","",false, this.CurrentView);
 
            PendingQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<DataCaptureProjectMaterialsDialogView>("","#ea50f468-bf70-4105-a37d-4919eb3f6aa1 .ag-row[role='row']@ROWINDEX [col-id='cPendingQuantity']","",false, this.CurrentView);
 
            Availability = RPSControlFactory.CreateRPSGridFormattedTextBox<DataCaptureProjectMaterialsDialogView>("","#ea50f468-bf70-4105-a37d-4919eb3f6aa1 .ag-row[role='row']@ROWINDEX [col-id='cAvailableStock']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<DataCaptureProjectMaterialsDialogView> TeoricQuantity { get; set; } 
        public IRPSGridTextBox<DataCaptureProjectMaterialsDialogView> PendingQuantity { get; set; } 
        public IRPSGridTextBox<DataCaptureProjectMaterialsDialogView> Availability { get; set; } 
                     
    }
 
    }
  
    

}