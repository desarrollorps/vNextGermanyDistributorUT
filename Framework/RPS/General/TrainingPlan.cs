    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.General.TrainingPlan
{
    //RPS VERSION 1.0.0.0
    public partial class TrainingPlan:Screen
    {
        public TrainingPlan():base()
        {
            this.URL = "general.trainingplan";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            TrainingPlanCollectionView  = new TrainingPlanCollectionView(this); 
            TrainingPlanEntityView  = new TrainingPlanEntityView(this); 
            TrainingPlanEmployeeView  = new TrainingPlanEmployeeView(this); 
            TrainingPlanCollectionView.InitializeControls(); 
            TrainingPlanEntityView.InitializeControls(); 
            TrainingPlanEmployeeView.InitializeControls(); 
           
        }
      
            public TrainingPlanCollectionView TrainingPlanCollectionView {get; set; } 
            public TrainingPlanEntityView TrainingPlanEntityView {get; set; } 
            public TrainingPlanEmployeeView TrainingPlanEmployeeView {get; set; } 
    }
            
    public partial class TrainingPlanCollectionView : View
    {
        public TrainingPlanCollectionView(TrainingPlan screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<TrainingPlanCollectionView,TrainingPlanEntityView>( this,Screen.TrainingPlanEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "d6d045b8-8cca-4db5-bb71-6aa3efba8569",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<TrainingPlanCollectionView,TrainingPlanEntityView>( params_MainConsult,this,Screen.TrainingPlanEntityView);
 

        }
        public IRPSButton<TrainingPlanCollectionView,TrainingPlanEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<TrainingPlanCollectionView,TrainingPlanEntityView> MainConsult { get; set; } 
        public TrainingPlan Screen { get; set; }
        public TrainingPlanCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class TrainingPlanEntityView : View
    {
        public TrainingPlanEntityView(TrainingPlan screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<TrainingPlanEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<TrainingPlanEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<TrainingPlanEntityView,TrainingPlanCollectionView>( this,Screen.TrainingPlanCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<TrainingPlanEntityView,TrainingPlanCollectionView>( this,Screen.TrainingPlanCollectionView);
 
            IDTraining = RPSControlFactory.CreateRPSComboBox<TrainingPlanEntityView>("7eec7d16-78fc-4f54-96da-b81c689d6c99","","",true, this);
 
            DatePlanned = RPSControlFactory.CreateRPSTextBox<TrainingPlanEntityView>("cbe942f0-bec5-4e31-adb3-2cbb0a2ae296","","",false, this);
 
            RequestedBy = RPSControlFactory.CreateRPSTextBox<TrainingPlanEntityView>("ec4aa1a8-0496-4dbc-936e-54c985153788","","",false, this);
 
            IDGeneralEvaluation = RPSControlFactory.CreateRPSComboBox<TrainingPlanEntityView>("6196a4b9-ba8b-4314-b290-b1197ce38610","","",false, this);
 
            TrainingType = RPSControlFactory.CreateRPSEnumComboBox<TrainingPlanEntityView>("3b23d3c7-0b61-43c3-a8f9-b57bf2c6dd1b","","",true, this);
 
            DateReal = RPSControlFactory.CreateRPSTextBox<TrainingPlanEntityView>("6b03de1f-f465-43eb-9490-ddfa4e55cb40","","",false, this);
 
            GivenBy = RPSControlFactory.CreateRPSTextBox<TrainingPlanEntityView>("1f79b8c8-e281-4c22-8319-91da24257759","","",false, this);
 
            CollectionInit params_TrainingPlanEmployees = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="279de6ab-ab27-46ea-b3fb-5255a16c7c1f",CSSSelectorGrid="",XPathGrid=""};
            TrainingPlanEmployees = RPSControlFactory.RPSCreateCollectionWithGrid<TrainingPlanEmployeesCollectionEditor<TrainingPlanEntityView,TrainingPlanEmployeeView>,TrainingPlanEntityView,TrainingPlanEmployeeView>( params_TrainingPlanEmployees,this,Screen.TrainingPlanEmployeeView);
 

        }
        public IRPSSaveButton<TrainingPlanEntityView> SaveButton { get; set; } 
        public IRPSButton<TrainingPlanEntityView> DeleteButton { get; set; } 
        public IRPSButton<TrainingPlanEntityView,TrainingPlanCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<TrainingPlanEntityView,TrainingPlanCollectionView> BackButton { get; set; } 
        public IRPSComboBox<TrainingPlanEntityView> IDTraining { get; set; } 
        public IRPSTextBox<TrainingPlanEntityView> DatePlanned { get; set; } 
        public IRPSTextBox<TrainingPlanEntityView> RequestedBy { get; set; } 
        public IRPSComboBox<TrainingPlanEntityView> IDGeneralEvaluation { get; set; } 
        public IRPSComboBox<TrainingPlanEntityView> TrainingType { get; set; } 
        public IRPSTextBox<TrainingPlanEntityView> DateReal { get; set; } 
        public IRPSTextBox<TrainingPlanEntityView> GivenBy { get; set; } 
        public TrainingPlanEmployeesCollectionEditor<TrainingPlanEntityView,TrainingPlanEmployeeView> TrainingPlanEmployees { get; set; } 
        public TrainingPlan Screen { get; set; }
        public TrainingPlanEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class TrainingPlanEmployeesCollectionEditor<TrainingPlanEntityView,TrainingPlanEmployeeView>:RPSCollectionEditor<TrainingPlanEntityView,TrainingPlanEmployeeView> where TrainingPlanEntityView : class, IView where TrainingPlanEmployeeView : class, IView
    {
        public  TrainingPlanEmployeesGridView<TrainingPlanEntityView,TrainingPlanEmployeeView> GridView {get;set;}
    }
    public partial class TrainingPlanEmployeesGridView <TrainingPlanEntityView,TrainingPlanEmployeeView> :  RPSGridView<TrainingPlanEntityView,TrainingPlanEmployeeView> where TrainingPlanEntityView : class, IView where TrainingPlanEmployeeView : class, IView
    {
        public TrainingPlanEmployeesGridView(TrainingPlanEntityView currentView,TrainingPlanEmployeeView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDEmployee = RPSControlFactory.CreateRPSGridComboBox<TrainingPlanEntityView>("","#279de6ab-ab27-46ea-b3fb-5255a16c7c1f .ag-row[role='row']@ROWINDEX [col-id='cIDEmployee']","",true, this.CurrentView);
 
            IDTrainingEvaluationEmployee = RPSControlFactory.CreateRPSGridComboBox<TrainingPlanEntityView>("","#279de6ab-ab27-46ea-b3fb-5255a16c7c1f .ag-row[role='row']@ROWINDEX [col-id='cIDTrainingEvaluationEmployee']","",false, this.CurrentView);
 
            IDTrainingEvaluationCompany = RPSControlFactory.CreateRPSGridComboBox<TrainingPlanEntityView>("","#279de6ab-ab27-46ea-b3fb-5255a16c7c1f .ag-row[role='row']@ROWINDEX [col-id='cIDTrainingEvaluationCompany']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<TrainingPlanEntityView> IDEmployee { get; set; } 
        public IRPSGridComboBox<TrainingPlanEntityView> IDTrainingEvaluationEmployee { get; set; } 
        public IRPSGridComboBox<TrainingPlanEntityView> IDTrainingEvaluationCompany { get; set; } 
                     
    }
 
    }
  
            
    public partial class TrainingPlanEmployeeView : View
    {
        public TrainingPlanEmployeeView(TrainingPlan screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<TrainingPlanEmployeeView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<TrainingPlanEmployeeView,TrainingPlanEntityView>( this,Screen.TrainingPlanEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<TrainingPlanEmployeeView,TrainingPlanEntityView>( this,Screen.TrainingPlanEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<TrainingPlanEmployeeView,TrainingPlanEntityView>( this,Screen.TrainingPlanEntityView);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<TrainingPlanEmployeeView>("0092c85f-d663-4677-9e2a-7e5bd40695e9","","",true, this);
 
            IDTrainingEvaluationEmployee = RPSControlFactory.CreateRPSComboBox<TrainingPlanEmployeeView>("d584b56d-b74e-4741-89b5-8325553151dd","","",false, this);
 
            IDTrainingEvaluationCompany = RPSControlFactory.CreateRPSComboBox<TrainingPlanEmployeeView>("1e77524a-ec96-4ce7-8e52-7283c1c67bee","","",false, this);
 

        }
        public IRPSButton<TrainingPlanEmployeeView> DeleteButton { get; set; } 
        public IRPSButton<TrainingPlanEmployeeView,TrainingPlanEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<TrainingPlanEmployeeView,TrainingPlanEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<TrainingPlanEmployeeView,TrainingPlanEntityView> AcceptButton { get; set; } 
        public IRPSComboBox<TrainingPlanEmployeeView> IDEmployee { get; set; } 
        public IRPSComboBox<TrainingPlanEmployeeView> IDTrainingEvaluationEmployee { get; set; } 
        public IRPSComboBox<TrainingPlanEmployeeView> IDTrainingEvaluationCompany { get; set; } 
        public TrainingPlan Screen { get; set; }
        public TrainingPlanEmployeeView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}