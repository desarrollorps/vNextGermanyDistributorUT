    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.CuDistListOfProjectTasks
{
    //RPS VERSION 1.0.0.0
    public partial class CuDistListOfProjectTasks:Screen
    {
        public CuDistListOfProjectTasks():base()
        {
            this.URL = "project.cudistlistofprojecttasks";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CuDistProjectTaskListViewVMQueryView  = new CuDistProjectTaskListViewVMQueryView(this); 
            CuDistProjectTaskListViewVMEntityView  = new CuDistProjectTaskListViewVMEntityView(this); 
            CuDistProjectTaskListViewVMQueryView.InitializeControls(); 
            CuDistProjectTaskListViewVMEntityView.InitializeControls(); 
           
        }
      
            public CuDistProjectTaskListViewVMQueryView CuDistProjectTaskListViewVMQueryView {get; set; } 
            public CuDistProjectTaskListViewVMEntityView CuDistProjectTaskListViewVMEntityView {get; set; } 
    }
            
    public partial class CuDistProjectTaskListViewVMQueryView : View
    {
        public CuDistProjectTaskListViewVMQueryView(CuDistListOfProjectTasks screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CuDistProjectTaskListViewVMQueryView,CuDistProjectTaskListViewVMEntityView>( this,Screen.CuDistProjectTaskListViewVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<CuDistProjectTaskListViewVMQueryView>( this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<CuDistProjectTaskListViewVMQueryView>("7ce8e6be-3792-4145-bdd2-f2f8cf61d35a","","",false, this);
 
            OnlyOpenTasks = RPSControlFactory.CreateRPSCheckBox<CuDistProjectTaskListViewVMQueryView>("96b97ff6-19ea-480c-b9c4-0903d50b8992","","",false, this);
 
            CodProject = RPSControlFactory.CreateRPSCollectionComboBox<CuDistProjectTaskListViewVMQueryView>("1daa9244-1292-48d6-9371-f30c55f55535","","",false, this);
 
            IDSituation = RPSControlFactory.CreateRPSComboBox<CuDistProjectTaskListViewVMQueryView>("c5aee236-4858-43c5-88f6-a3cb8153f1e9","","",false, this);
 
            IDProjectType = RPSControlFactory.CreateRPSComboBox<CuDistProjectTaskListViewVMQueryView>("03ecd9c5-9b92-479b-8937-f03b541b7f37","","",false, this);
 
            NoEmployeeTasks = RPSControlFactory.CreateRPSCheckBox<CuDistProjectTaskListViewVMQueryView>("bc145a77-278f-4658-935f-c4be96ee7f9f","","",false, this);
 
            IDUsualTask = RPSControlFactory.CreateRPSComboBox<CuDistProjectTaskListViewVMQueryView>("c437a6e0-829c-4163-abcd-828822449771","","",false, this);
 
            IDEmployeeTechnical = RPSControlFactory.CreateRPSComboBox<CuDistProjectTaskListViewVMQueryView>("4e224452-b125-42c7-af7c-64c7c37613e1","","",false, this);
 
            IDEmployeeCommercial = RPSControlFactory.CreateRPSComboBox<CuDistProjectTaskListViewVMQueryView>("fcca31eb-9bf0-42de-a117-1d1d6aaf43b8","","",false, this);
 
            OnlyWithMaterial = RPSControlFactory.CreateRPSCheckBox<CuDistProjectTaskListViewVMQueryView>("301a2977-60ec-49b2-914a-49eb116a353d","","",false, this);
 
            AddNewResEmployeeCommandButton = RPSControlFactory.CreateRPSButton<CuDistProjectTaskListViewVMQueryView>( "9bec195b-e579-4113-b32e-3ed8c16cfa7c","","",this);
 
            ChangeEmployeeQualificationCommandButton = RPSControlFactory.CreateRPSButton<CuDistProjectTaskListViewVMQueryView>( "3911f48b-972c-4560-a719-ccea6ede3f17","","",this);
 
            CollectionInit params_CuDistListOfTasksQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a2b4a955-5dc1-4244-8e69-3109cfa08cee",CSSSelectorGrid="",XPathGrid=""};
            CuDistListOfTasksQuery = RPSControlFactory.RPSCreateCollectionWithGrid<CuDistListOfTasksQueryCollectionEditor<CuDistProjectTaskListViewVMQueryView,CuDistProjectTaskListViewVMEntityView>,CuDistProjectTaskListViewVMQueryView,CuDistProjectTaskListViewVMEntityView>( params_CuDistListOfTasksQuery,this,Screen.CuDistProjectTaskListViewVMEntityView);
 

        }
        public IRPSButton<CuDistProjectTaskListViewVMQueryView,CuDistProjectTaskListViewVMEntityView> NewButton { get; set; } 
        public IRPSButton<CuDistProjectTaskListViewVMQueryView> ConsultButton { get; set; } 
        public IRPSComboBox<CuDistProjectTaskListViewVMQueryView> IDSite { get; set; } 
        public IRPSCheckbox<CuDistProjectTaskListViewVMQueryView> OnlyOpenTasks { get; set; } 
        public IRPSCollectionComboBox<CuDistProjectTaskListViewVMQueryView> CodProject { get; set; } 
        public IRPSComboBox<CuDistProjectTaskListViewVMQueryView> IDSituation { get; set; } 
        public IRPSComboBox<CuDistProjectTaskListViewVMQueryView> IDProjectType { get; set; } 
        public IRPSCheckbox<CuDistProjectTaskListViewVMQueryView> NoEmployeeTasks { get; set; } 
        public IRPSComboBox<CuDistProjectTaskListViewVMQueryView> IDUsualTask { get; set; } 
        public IRPSComboBox<CuDistProjectTaskListViewVMQueryView> IDEmployeeTechnical { get; set; } 
        public IRPSComboBox<CuDistProjectTaskListViewVMQueryView> IDEmployeeCommercial { get; set; } 
        public IRPSCheckbox<CuDistProjectTaskListViewVMQueryView> OnlyWithMaterial { get; set; } 
        public IRPSButton<CuDistProjectTaskListViewVMQueryView> AddNewResEmployeeCommandButton { get; set; } 
        public IRPSButton<CuDistProjectTaskListViewVMQueryView> ChangeEmployeeQualificationCommandButton { get; set; } 
        public CuDistListOfTasksQueryCollectionEditor<CuDistProjectTaskListViewVMQueryView,CuDistProjectTaskListViewVMEntityView> CuDistListOfTasksQuery { get; set; } 
        public CuDistListOfProjectTasks Screen { get; set; }
        public CuDistProjectTaskListViewVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CuDistListOfTasksQueryCollectionEditor<CuDistProjectTaskListViewVMQueryView,CuDistProjectTaskListViewVMEntityView>:RPSCollectionEditor<CuDistProjectTaskListViewVMQueryView,CuDistProjectTaskListViewVMEntityView> where CuDistProjectTaskListViewVMQueryView : class, IView where CuDistProjectTaskListViewVMEntityView : class, IView
    {
        public  CuDistListOfTasksQueryGridView<CuDistProjectTaskListViewVMQueryView,CuDistProjectTaskListViewVMEntityView> GridView {get;set;}
    }
    public partial class CuDistListOfTasksQueryGridView <CuDistProjectTaskListViewVMQueryView,CuDistProjectTaskListViewVMEntityView> :  RPSGridView<CuDistProjectTaskListViewVMQueryView,CuDistProjectTaskListViewVMEntityView> where CuDistProjectTaskListViewVMQueryView : class, IView where CuDistProjectTaskListViewVMEntityView : class, IView
    {
        public CuDistListOfTasksQueryGridView(CuDistProjectTaskListViewVMQueryView currentView,CuDistProjectTaskListViewVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CuDistProjectTaskListView_CodProject = RPSControlFactory.CreateRPSGridTextBox<CuDistProjectTaskListViewVMQueryView>("","#a2b4a955-5dc1-4244-8e69-3109cfa08cee .ag-row[role='row']@ROWINDEX [col-id='cCuDistProjectTaskListView_CodProject']","",false, this.CurrentView);
 
            CuDistProjectTaskListView_DescProject = RPSControlFactory.CreateRPSGridTextBox<CuDistProjectTaskListViewVMQueryView>("","#a2b4a955-5dc1-4244-8e69-3109cfa08cee .ag-row[role='row']@ROWINDEX [col-id='cCuDistProjectTaskListView_DescProject']","",false, this.CurrentView);
 
            CuDistProjectTaskListView_Version = RPSControlFactory.CreateRPSGridTextBox<CuDistProjectTaskListViewVMQueryView>("","#a2b4a955-5dc1-4244-8e69-3109cfa08cee .ag-row[role='row']@ROWINDEX [col-id='cCuDistProjectTaskListView_Version']","",false, this.CurrentView);
 
            CuDistProjectTaskListView_CodPROTask = RPSControlFactory.CreateRPSGridTextBox<CuDistProjectTaskListViewVMQueryView>("","#a2b4a955-5dc1-4244-8e69-3109cfa08cee .ag-row[role='row']@ROWINDEX [col-id='cCuDistProjectTaskListView_CodPROTask']","",false, this.CurrentView);
 
            CuDistProjectTaskListView_DescProTask = RPSControlFactory.CreateRPSGridTextBox<CuDistProjectTaskListViewVMQueryView>("","#a2b4a955-5dc1-4244-8e69-3109cfa08cee .ag-row[role='row']@ROWINDEX [col-id='cCuDistProjectTaskListView_DescProTask']","",false, this.CurrentView);
 
            CuDistProjectTaskListView_PercentProgress = RPSControlFactory.CreateRPSGridFormattedTextBox<CuDistProjectTaskListViewVMQueryView>("","#a2b4a955-5dc1-4244-8e69-3109cfa08cee .ag-row[role='row']@ROWINDEX [col-id='cCuDistProjectTaskListView_PercentProgress']","",false, this.CurrentView);
 
            CuDistProjectTaskListView_PlannedStartDate = RPSControlFactory.CreateRPSGridTextBox<CuDistProjectTaskListViewVMQueryView>("","#a2b4a955-5dc1-4244-8e69-3109cfa08cee .ag-row[role='row']@ROWINDEX [col-id='cCuDistProjectTaskListView_PlannedStartDate']","",false, this.CurrentView);
 
            CuDistProjectTaskListView_PlannedEndDate = RPSControlFactory.CreateRPSGridTextBox<CuDistProjectTaskListViewVMQueryView>("","#a2b4a955-5dc1-4244-8e69-3109cfa08cee .ag-row[role='row']@ROWINDEX [col-id='cCuDistProjectTaskListView_PlannedEndDate']","",false, this.CurrentView);
 
            EstimatedHour = RPSControlFactory.CreateRPSGridFormattedTextBox<CuDistProjectTaskListViewVMQueryView>("","#a2b4a955-5dc1-4244-8e69-3109cfa08cee .ag-row[role='row']@ROWINDEX [col-id='cEstimatedHour']","",false, this.CurrentView);
 
            RealHour = RPSControlFactory.CreateRPSGridFormattedTextBox<CuDistProjectTaskListViewVMQueryView>("","#a2b4a955-5dc1-4244-8e69-3109cfa08cee .ag-row[role='row']@ROWINDEX [col-id='cRealHour']","",false, this.CurrentView);
 
            DiffStartDate = RPSControlFactory.CreateRPSGridFormattedTextBox<CuDistProjectTaskListViewVMQueryView>("","#a2b4a955-5dc1-4244-8e69-3109cfa08cee .ag-row[role='row']@ROWINDEX [col-id='cDiffStartDate']","",false, this.CurrentView);
 
            DiffEndDate = RPSControlFactory.CreateRPSGridFormattedTextBox<CuDistProjectTaskListViewVMQueryView>("","#a2b4a955-5dc1-4244-8e69-3109cfa08cee .ag-row[role='row']@ROWINDEX [col-id='cDiffEndDate']","",false, this.CurrentView);
 
            CuDistProjectTaskListView_CodPROUsualTask = RPSControlFactory.CreateRPSGridTextBox<CuDistProjectTaskListViewVMQueryView>("","#a2b4a955-5dc1-4244-8e69-3109cfa08cee .ag-row[role='row']@ROWINDEX [col-id='cCuDistProjectTaskListView_CodPROUsualTask']","",false, this.CurrentView);
 
            CuDistProjectTaskListView_DescriptionEmployee = RPSControlFactory.CreateRPSGridTextBox<CuDistProjectTaskListViewVMQueryView>("","#a2b4a955-5dc1-4244-8e69-3109cfa08cee .ag-row[role='row']@ROWINDEX [col-id='cCuDistProjectTaskListView_DescriptionEmployee']","",false, this.CurrentView);
 
            CuDistProjectTaskListView_DescriptionQualification = RPSControlFactory.CreateRPSGridTextBox<CuDistProjectTaskListViewVMQueryView>("","#a2b4a955-5dc1-4244-8e69-3109cfa08cee .ag-row[role='row']@ROWINDEX [col-id='cCuDistProjectTaskListView_DescriptionQualification']","",false, this.CurrentView);
 
            CuDistProjectTaskListView_Blocked = RPSControlFactory.CreateRPSGridCheckBox<CuDistProjectTaskListViewVMQueryView>("","#a2b4a955-5dc1-4244-8e69-3109cfa08cee .ag-row[role='row']@ROWINDEX [col-id='cCuDistProjectTaskListView_Blocked']","",false, this.CurrentView);
 
            CuDistProjectTaskListView_BlockedMaterial = RPSControlFactory.CreateRPSGridCheckBox<CuDistProjectTaskListViewVMQueryView>("","#a2b4a955-5dc1-4244-8e69-3109cfa08cee .ag-row[role='row']@ROWINDEX [col-id='cCuDistProjectTaskListView_BlockedMaterial']","",false, this.CurrentView);
 
            CuDistProjectTaskListView_BlockedCost = RPSControlFactory.CreateRPSGridCheckBox<CuDistProjectTaskListViewVMQueryView>("","#a2b4a955-5dc1-4244-8e69-3109cfa08cee .ag-row[role='row']@ROWINDEX [col-id='cCuDistProjectTaskListView_BlockedCost']","",false, this.CurrentView);
 
            CuDistProjectTaskListView_BlockedTime = RPSControlFactory.CreateRPSGridCheckBox<CuDistProjectTaskListViewVMQueryView>("","#a2b4a955-5dc1-4244-8e69-3109cfa08cee .ag-row[role='row']@ROWINDEX [col-id='cCuDistProjectTaskListView_BlockedTime']","",false, this.CurrentView);
 
            CuDistProjectTaskListView_Canceled = RPSControlFactory.CreateRPSGridCheckBox<CuDistProjectTaskListViewVMQueryView>("","#a2b4a955-5dc1-4244-8e69-3109cfa08cee .ag-row[role='row']@ROWINDEX [col-id='cCuDistProjectTaskListView_Canceled']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<CuDistProjectTaskListViewVMQueryView> CuDistProjectTaskListView_CodProject { get; set; } 
        public IRPSGridTextBox<CuDistProjectTaskListViewVMQueryView> CuDistProjectTaskListView_DescProject { get; set; } 
        public IRPSGridTextBox<CuDistProjectTaskListViewVMQueryView> CuDistProjectTaskListView_Version { get; set; } 
        public IRPSGridTextBox<CuDistProjectTaskListViewVMQueryView> CuDistProjectTaskListView_CodPROTask { get; set; } 
        public IRPSGridTextBox<CuDistProjectTaskListViewVMQueryView> CuDistProjectTaskListView_DescProTask { get; set; } 
        public IRPSGridTextBox<CuDistProjectTaskListViewVMQueryView> CuDistProjectTaskListView_PercentProgress { get; set; } 
        public IRPSGridTextBox<CuDistProjectTaskListViewVMQueryView> CuDistProjectTaskListView_PlannedStartDate { get; set; } 
        public IRPSGridTextBox<CuDistProjectTaskListViewVMQueryView> CuDistProjectTaskListView_PlannedEndDate { get; set; } 
        public IRPSGridTextBox<CuDistProjectTaskListViewVMQueryView> EstimatedHour { get; set; } 
        public IRPSGridTextBox<CuDistProjectTaskListViewVMQueryView> RealHour { get; set; } 
        public IRPSGridTextBox<CuDistProjectTaskListViewVMQueryView> DiffStartDate { get; set; } 
        public IRPSGridTextBox<CuDistProjectTaskListViewVMQueryView> DiffEndDate { get; set; } 
        public IRPSGridTextBox<CuDistProjectTaskListViewVMQueryView> CuDistProjectTaskListView_CodPROUsualTask { get; set; } 
        public IRPSGridTextBox<CuDistProjectTaskListViewVMQueryView> CuDistProjectTaskListView_DescriptionEmployee { get; set; } 
        public IRPSGridTextBox<CuDistProjectTaskListViewVMQueryView> CuDistProjectTaskListView_DescriptionQualification { get; set; } 
        public IRPSGridCheckbox<CuDistProjectTaskListViewVMQueryView> CuDistProjectTaskListView_Blocked { get; set; } 
        public IRPSGridCheckbox<CuDistProjectTaskListViewVMQueryView> CuDistProjectTaskListView_BlockedMaterial { get; set; } 
        public IRPSGridCheckbox<CuDistProjectTaskListViewVMQueryView> CuDistProjectTaskListView_BlockedCost { get; set; } 
        public IRPSGridCheckbox<CuDistProjectTaskListViewVMQueryView> CuDistProjectTaskListView_BlockedTime { get; set; } 
        public IRPSGridCheckbox<CuDistProjectTaskListViewVMQueryView> CuDistProjectTaskListView_Canceled { get; set; } 
                     
    }
 
    }
  
            
    public partial class CuDistProjectTaskListViewVMEntityView : View
    {
        public CuDistProjectTaskListViewVMEntityView(CuDistListOfProjectTasks screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CuDistProjectTaskListViewVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CuDistProjectTaskListViewVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CuDistProjectTaskListViewVMEntityView,CuDistProjectTaskListViewVMQueryView>( this,Screen.CuDistProjectTaskListViewVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<CuDistProjectTaskListViewVMEntityView,CuDistProjectTaskListViewVMQueryView>( this,Screen.CuDistProjectTaskListViewVMQueryView);
 

        }
        public IRPSSaveButton<CuDistProjectTaskListViewVMEntityView> SaveButton { get; set; } 
        public IRPSButton<CuDistProjectTaskListViewVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<CuDistProjectTaskListViewVMEntityView,CuDistProjectTaskListViewVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CuDistProjectTaskListViewVMEntityView,CuDistProjectTaskListViewVMQueryView> BackButton { get; set; } 
        public CuDistListOfProjectTasks Screen { get; set; }
        public CuDistProjectTaskListViewVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}