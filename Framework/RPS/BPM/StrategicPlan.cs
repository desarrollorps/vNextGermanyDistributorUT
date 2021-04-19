    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.BPM.StrategicPlan
{
    //RPS VERSION 1.0.0.0
    public partial class StrategicPlan:Screen
    {
        public StrategicPlan():base()
        {
            this.URL = "bpm.strategicplan";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            StrategicPlanCollectionView  = new StrategicPlanCollectionView(this); 
            StrategicPlanEntityView  = new StrategicPlanEntityView(this); 
            StrategicGoalView  = new StrategicGoalView(this); 
            InitiativeView  = new InitiativeView(this); 
            GoalIndicatorView  = new GoalIndicatorView(this); 
            StrategicPlanCollectionView.InitializeControls(); 
            StrategicPlanEntityView.InitializeControls(); 
            StrategicGoalView.InitializeControls(); 
            InitiativeView.InitializeControls(); 
            GoalIndicatorView.InitializeControls(); 
           
        }
      
            public StrategicPlanCollectionView StrategicPlanCollectionView {get; set; } 
            public StrategicPlanEntityView StrategicPlanEntityView {get; set; } 
            public StrategicGoalView StrategicGoalView {get; set; } 
            public InitiativeView InitiativeView {get; set; } 
            public GoalIndicatorView GoalIndicatorView {get; set; } 
    }
            
    public partial class StrategicPlanCollectionView : View
    {
        public StrategicPlanCollectionView(StrategicPlan screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<StrategicPlanCollectionView,StrategicPlanEntityView>( this,Screen.StrategicPlanEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "5204d7d7-97a6-4452-baac-cad87a4d84c3",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<StrategicPlanCollectionView,StrategicPlanEntityView>( params_MainConsult,this,Screen.StrategicPlanEntityView);
 

        }
        public IRPSButton<StrategicPlanCollectionView,StrategicPlanEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<StrategicPlanCollectionView,StrategicPlanEntityView> MainConsult { get; set; } 
        public StrategicPlan Screen { get; set; }
        public StrategicPlanCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class StrategicPlanEntityView : View
    {
        public StrategicPlanEntityView(StrategicPlan screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<StrategicPlanEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<StrategicPlanEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<StrategicPlanEntityView,StrategicPlanCollectionView>( this,Screen.StrategicPlanCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<StrategicPlanEntityView,StrategicPlanCollectionView>( this,Screen.StrategicPlanCollectionView);
 
            Description = RPSControlFactory.CreateRPSTextBox<StrategicPlanEntityView>("bf36c2e2-2521-4472-a0bb-fc3ec8db25e6","","",true, this);
 
            OperativeSince = RPSControlFactory.CreateRPSTextBox<StrategicPlanEntityView>("9a1edbf2-7f35-4e05-8073-f7dba797455e","","",true, this);
 
            OperativeUntil = RPSControlFactory.CreateRPSTextBox<StrategicPlanEntityView>("2c7e9b3e-eb71-4007-bf73-c4ee38ae42cf","","",true, this);
 
            Reflection = RPSControlFactory.CreateRPSTextBox<StrategicPlanEntityView>("f79307e5-7af2-4094-9b98-bd724789fdcd","","",false, this);
 
            ExecuteDuplicateStrategicPlanButton = RPSControlFactory.CreateRPSButton<StrategicPlanEntityView>( "3236bbd9-f935-4b1c-b8b7-28e969dfb741","","",this);
 
            CollectionInit params_StrategicGoals = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="e7e31603-fa86-47dd-8ddc-43bcb0815944",CSSSelectorGrid="",XPathGrid=""};
            StrategicGoals = RPSControlFactory.RPSCreateCollectionWithGrid<StrategicGoalsCollectionEditor<StrategicPlanEntityView,StrategicGoalView>,StrategicPlanEntityView,StrategicGoalView>( params_StrategicGoals,this,Screen.StrategicGoalView);
 
            CollectionInit params_GetStrategicIndicatorPeriod = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0e3063c2-4422-4874-9c3b-28ba51757492",CSSSelectorGrid="",XPathGrid=""};
            GetStrategicIndicatorPeriod = RPSControlFactory.RPSCreateCollectionWithGrid<GetStrategicIndicatorPeriodCollectionEditor<StrategicPlanEntityView,StrategicGoalView>,StrategicPlanEntityView,StrategicGoalView>( params_GetStrategicIndicatorPeriod,this,Screen.StrategicGoalView);
 
            ObjetiveSection = RPSControlFactory.CreateRPSSection<StrategicPlanEntityView>( "","ul li[rpsid='c708ad19-a449-4a34-9340-4660931c17d1']","",this);
 
            IndicatorsSection = RPSControlFactory.CreateRPSSection<StrategicPlanEntityView>( "","ul li[rpsid='d285649f-aa80-4d54-ad8f-08668c7a8100']","",this);
 
            ReflectionSection = RPSControlFactory.CreateRPSSection<StrategicPlanEntityView>( "","ul li[rpsid='d9e780a1-30f3-4b18-b2f0-78b99e041e56']","",this);
 

        }
        public IRPSSaveButton<StrategicPlanEntityView> SaveButton { get; set; } 
        public IRPSButton<StrategicPlanEntityView> DeleteButton { get; set; } 
        public IRPSButton<StrategicPlanEntityView,StrategicPlanCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<StrategicPlanEntityView,StrategicPlanCollectionView> BackButton { get; set; } 
        public IRPSTextBox<StrategicPlanEntityView> Description { get; set; } 
        public IRPSTextBox<StrategicPlanEntityView> OperativeSince { get; set; } 
        public IRPSTextBox<StrategicPlanEntityView> OperativeUntil { get; set; } 
        public IRPSTextBox<StrategicPlanEntityView> Reflection { get; set; } 
        public IRPSButton<StrategicPlanEntityView> ExecuteDuplicateStrategicPlanButton { get; set; } 
        public StrategicGoalsCollectionEditor<StrategicPlanEntityView,StrategicGoalView> StrategicGoals { get; set; } 
        public GetStrategicIndicatorPeriodCollectionEditor<StrategicPlanEntityView,StrategicGoalView> GetStrategicIndicatorPeriod { get; set; } 
        public IRPSSection<StrategicPlanEntityView> ObjetiveSection { get; set; } 
        public IRPSSection<StrategicPlanEntityView> IndicatorsSection { get; set; } 
        public IRPSSection<StrategicPlanEntityView> ReflectionSection { get; set; } 
        public StrategicPlan Screen { get; set; }
        public StrategicPlanEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class StrategicGoalsCollectionEditor<StrategicPlanEntityView,StrategicGoalView>:RPSCollectionEditor<StrategicPlanEntityView,StrategicGoalView> where StrategicPlanEntityView : class, IView where StrategicGoalView : class, IView
    {
        public  StrategicGoalsGridView<StrategicPlanEntityView,StrategicGoalView> GridView {get;set;}
    }
    public partial class StrategicGoalsGridView <StrategicPlanEntityView,StrategicGoalView> :  RPSGridView<StrategicPlanEntityView,StrategicGoalView> where StrategicPlanEntityView : class, IView where StrategicGoalView : class, IView
    {
        public StrategicGoalsGridView(StrategicPlanEntityView currentView,StrategicGoalView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Perspective = RPSControlFactory.CreateRPSGridEnumComboBox<StrategicPlanEntityView>("","#e7e31603-fa86-47dd-8ddc-43bcb0815944 .ag-row[role='row']@ROWINDEX [col-id='cPerspective']","",true, this.CurrentView);
 
            CodStrategicGoal = RPSControlFactory.CreateRPSGridTextBox<StrategicPlanEntityView>("","#e7e31603-fa86-47dd-8ddc-43bcb0815944 .ag-row[role='row']@ROWINDEX [col-id='cCodStrategicGoal']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<StrategicPlanEntityView>("","#e7e31603-fa86-47dd-8ddc-43bcb0815944 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            TargetValue = RPSControlFactory.CreateRPSGridFormattedTextBox<StrategicPlanEntityView>("","#e7e31603-fa86-47dd-8ddc-43bcb0815944 .ag-row[role='row']@ROWINDEX [col-id='cTargetValue']","",true, this.CurrentView);
 
            LimitValue = RPSControlFactory.CreateRPSGridFormattedTextBox<StrategicPlanEntityView>("","#e7e31603-fa86-47dd-8ddc-43bcb0815944 .ag-row[role='row']@ROWINDEX [col-id='cLimitValue']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<StrategicPlanEntityView> Perspective { get; set; } 
        public IRPSGridTextBox<StrategicPlanEntityView> CodStrategicGoal { get; set; } 
        public IRPSGridTextBox<StrategicPlanEntityView> Description { get; set; } 
        public IRPSGridTextBox<StrategicPlanEntityView> TargetValue { get; set; } 
        public IRPSGridTextBox<StrategicPlanEntityView> LimitValue { get; set; } 
                     
    }
 
        public partial class GetStrategicIndicatorPeriodCollectionEditor<StrategicPlanEntityView,StrategicGoalView>:RPSCollectionEditor<StrategicPlanEntityView,StrategicGoalView> where StrategicPlanEntityView : class, IView where StrategicGoalView : class, IView
    {
        public  GetStrategicIndicatorPeriodGridView<StrategicPlanEntityView,StrategicGoalView> GridView {get;set;}
    }
    public partial class GetStrategicIndicatorPeriodGridView <StrategicPlanEntityView,StrategicGoalView> :  RPSGridView<StrategicPlanEntityView,StrategicGoalView> where StrategicPlanEntityView : class, IView where StrategicGoalView : class, IView
    {
        public GetStrategicIndicatorPeriodGridView(StrategicPlanEntityView currentView,StrategicGoalView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            StrategicIndicatorPeriod_TargetValue = RPSControlFactory.CreateRPSGridFormattedTextBox<StrategicPlanEntityView>("","#0e3063c2-4422-4874-9c3b-28ba51757492 .ag-row[role='row']@ROWINDEX [col-id='cStrategicIndicatorPeriod_TargetValue']","",false, this.CurrentView);
 
            StrategicIndicatorPeriod_LimitValue = RPSControlFactory.CreateRPSGridFormattedTextBox<StrategicPlanEntityView>("","#0e3063c2-4422-4874-9c3b-28ba51757492 .ag-row[role='row']@ROWINDEX [col-id='cStrategicIndicatorPeriod_LimitValue']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<StrategicPlanEntityView> StrategicIndicatorPeriod_TargetValue { get; set; } 
        public IRPSGridTextBox<StrategicPlanEntityView> StrategicIndicatorPeriod_LimitValue { get; set; } 
                     
    }
 
    }
  
            
    public partial class StrategicGoalView : View
    {
        public StrategicGoalView(StrategicPlan screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<StrategicGoalView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<StrategicGoalView,StrategicPlanEntityView>( this,Screen.StrategicPlanEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<StrategicGoalView,StrategicPlanEntityView>( this,Screen.StrategicPlanEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<StrategicGoalView,StrategicPlanEntityView>( this,Screen.StrategicPlanEntityView);
 
            CodStrategicGoal = RPSControlFactory.CreateRPSTextBox<StrategicGoalView>("d61bde4e-07f8-4308-8330-4f01ee1a5565","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<StrategicGoalView>("9c5d5c1e-5ef5-4d7d-9f02-e8f68604a29a","","",false, this);
 
            Perspective = RPSControlFactory.CreateRPSEnumComboBox<StrategicGoalView>("4afbb69e-bdc0-4b52-8a6e-fc071cdbe4a6","","",true, this);
 
            UserResponsible = RPSControlFactory.CreateRPSComboBox<StrategicGoalView>("0fbffdf4-bfa8-4718-86fc-63dd09271402","","",true, this);
 
            TargetValue = RPSControlFactory.CreateRPSFormattedTextBox<StrategicGoalView>("80fc2fde-1afc-49e7-9174-5556361e73a9","","",true, this);
 
            LimitValue = RPSControlFactory.CreateRPSFormattedTextBox<StrategicGoalView>("0b752b67-a261-434b-a686-d64a86794b2d","","",true, this);
 
            IDAggregationMatrix = RPSControlFactory.CreateRPSComboBox<StrategicGoalView>("0c7ce8b5-83f4-4dba-8c5e-5f1be73f5b69","","",false, this);
 
            Details = RPSControlFactory.CreateRPSTextBox<StrategicGoalView>("720fc093-acc9-4b5c-a4a3-ae94508638cb","","",false, this);
 
            CollectionInit params_GoalIndicators = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="189823a8-4678-4e80-9f39-3cb792d5ae8d",CSSSelectorGrid="",XPathGrid=""};
            GoalIndicators = RPSControlFactory.RPSCreateCollectionWithGrid<GoalIndicatorsCollectionEditor<StrategicGoalView,InitiativeView>,StrategicGoalView,InitiativeView>( params_GoalIndicators,this,Screen.InitiativeView);
 
            CollectionInit params_Initiatives = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1f64d3ca-8748-406a-aea6-8f46e33c3449",CSSSelectorGrid="",XPathGrid=""};
            Initiatives = RPSControlFactory.RPSCreateCollectionWithGrid<InitiativesCollectionEditor<StrategicGoalView,InitiativeView>,StrategicGoalView,InitiativeView>( params_Initiatives,this,Screen.InitiativeView);
 
            GeneralDataSection = RPSControlFactory.CreateRPSSection<StrategicGoalView>( "","ul li[rpsid='92486d48-9f65-4551-bb6f-8a660d62fd58']","",this);
 
            GoalIndicatorsSection = RPSControlFactory.CreateRPSSection<StrategicGoalView>( "","ul li[rpsid='7a52c13e-0587-456f-b78e-25548773b0e0']","",this);
 
            InitiativesSection = RPSControlFactory.CreateRPSSection<StrategicGoalView>( "","ul li[rpsid='ffccc834-842a-4db4-86d2-65479793cb67']","",this);
 

        }
        public IRPSButton<StrategicGoalView> DeleteButton { get; set; } 
        public IRPSButton<StrategicGoalView,StrategicPlanEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<StrategicGoalView,StrategicPlanEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<StrategicGoalView,StrategicPlanEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<StrategicGoalView> CodStrategicGoal { get; set; } 
        public IRPSTextBox<StrategicGoalView> Description { get; set; } 
        public IRPSComboBox<StrategicGoalView> Perspective { get; set; } 
        public IRPSComboBox<StrategicGoalView> UserResponsible { get; set; } 
        public IRPSTextBox<StrategicGoalView> TargetValue { get; set; } 
        public IRPSTextBox<StrategicGoalView> LimitValue { get; set; } 
        public IRPSComboBox<StrategicGoalView> IDAggregationMatrix { get; set; } 
        public IRPSTextBox<StrategicGoalView> Details { get; set; } 
        public GoalIndicatorsCollectionEditor<StrategicGoalView,InitiativeView> GoalIndicators { get; set; } 
        public InitiativesCollectionEditor<StrategicGoalView,InitiativeView> Initiatives { get; set; } 
        public IRPSSection<StrategicGoalView> GeneralDataSection { get; set; } 
        public IRPSSection<StrategicGoalView> GoalIndicatorsSection { get; set; } 
        public IRPSSection<StrategicGoalView> InitiativesSection { get; set; } 
        public StrategicPlan Screen { get; set; }
        public StrategicGoalView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class GoalIndicatorsCollectionEditor<StrategicGoalView,InitiativeView>:RPSCollectionEditor<StrategicGoalView,InitiativeView> where StrategicGoalView : class, IView where InitiativeView : class, IView
    {
        public  GoalIndicatorsGridView<StrategicGoalView,InitiativeView> GridView {get;set;}
    }
    public partial class GoalIndicatorsGridView <StrategicGoalView,InitiativeView> :  RPSGridView<StrategicGoalView,InitiativeView> where StrategicGoalView : class, IView where InitiativeView : class, IView
    {
        public GoalIndicatorsGridView(StrategicGoalView currentView,InitiativeView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDStrategicIndicator = RPSControlFactory.CreateRPSGridComboBox<StrategicGoalView>("","#189823a8-4678-4e80-9f39-3cb792d5ae8d .ag-row[role='row']@ROWINDEX [col-id='cIDStrategicIndicator']","",false, this.CurrentView);
 
            Weight = RPSControlFactory.CreateRPSGridEnumComboBox<StrategicGoalView>("","#189823a8-4678-4e80-9f39-3cb792d5ae8d .ag-row[role='row']@ROWINDEX [col-id='cWeight']","",true, this.CurrentView);
 
            TargetValue = RPSControlFactory.CreateRPSGridFormattedTextBox<StrategicGoalView>("","#189823a8-4678-4e80-9f39-3cb792d5ae8d .ag-row[role='row']@ROWINDEX [col-id='cTargetValue']","",false, this.CurrentView);
 
            LimitValue = RPSControlFactory.CreateRPSGridFormattedTextBox<StrategicGoalView>("","#189823a8-4678-4e80-9f39-3cb792d5ae8d .ag-row[role='row']@ROWINDEX [col-id='cLimitValue']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<StrategicGoalView> IDStrategicIndicator { get; set; } 
        public IRPSGridComboBox<StrategicGoalView> Weight { get; set; } 
        public IRPSGridTextBox<StrategicGoalView> TargetValue { get; set; } 
        public IRPSGridTextBox<StrategicGoalView> LimitValue { get; set; } 
                     
    }
 
        public partial class InitiativesCollectionEditor<StrategicGoalView,InitiativeView>:RPSCollectionEditor<StrategicGoalView,InitiativeView> where StrategicGoalView : class, IView where InitiativeView : class, IView
    {
        public  InitiativesGridView<StrategicGoalView,InitiativeView> GridView {get;set;}
    }
    public partial class InitiativesGridView <StrategicGoalView,InitiativeView> :  RPSGridView<StrategicGoalView,InitiativeView> where StrategicGoalView : class, IView where InitiativeView : class, IView
    {
        public InitiativesGridView(StrategicGoalView currentView,InitiativeView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodInitiative = RPSControlFactory.CreateRPSGridTextBox<StrategicGoalView>("","#1f64d3ca-8748-406a-aea6-8f46e33c3449 .ag-row[role='row']@ROWINDEX [col-id='cCodInitiative']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<StrategicGoalView>("","#1f64d3ca-8748-406a-aea6-8f46e33c3449 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            StartDate = RPSControlFactory.CreateRPSGridTextBox<StrategicGoalView>("","#1f64d3ca-8748-406a-aea6-8f46e33c3449 .ag-row[role='row']@ROWINDEX [col-id='cStartDate']","",true, this.CurrentView);
 
            EndDate = RPSControlFactory.CreateRPSGridTextBox<StrategicGoalView>("","#1f64d3ca-8748-406a-aea6-8f46e33c3449 .ag-row[role='row']@ROWINDEX [col-id='cEndDate']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<StrategicGoalView> CodInitiative { get; set; } 
        public IRPSGridTextBox<StrategicGoalView> Description { get; set; } 
        public IRPSGridTextBox<StrategicGoalView> StartDate { get; set; } 
        public IRPSGridTextBox<StrategicGoalView> EndDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class InitiativeView : View
    {
        public InitiativeView(StrategicPlan screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<InitiativeView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<InitiativeView,StrategicGoalView>( this,Screen.StrategicGoalView);
 
            BackButton = RPSControlFactory.RPSBackButton<InitiativeView,StrategicGoalView>( this,Screen.StrategicGoalView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<InitiativeView,StrategicGoalView>( this,Screen.StrategicGoalView);
 
            IDStrategicGoal = RPSControlFactory.CreateRPSComboBox<InitiativeView>("b0700d29-5f0b-4452-a419-9626ea01446a","","",true, this);
 
            CodInitiative = RPSControlFactory.CreateRPSTextBox<InitiativeView>("886bb444-789a-4acf-a6f6-c23079ab6cd2","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<InitiativeView>("938d24cc-2243-4275-8f27-778381c410e9","","",false, this);
 
            StartDate = RPSControlFactory.CreateRPSTextBox<InitiativeView>("76fa98f6-d15e-48aa-a3be-6b0d38eedf80","","",true, this);
 
            EndDate = RPSControlFactory.CreateRPSTextBox<InitiativeView>("dcb221bb-d6f3-4330-9804-ed7584cddfe4","","",true, this);
 
            Responsible = RPSControlFactory.CreateRPSComboBox<InitiativeView>("8ef04baf-06a3-45ef-a388-f054fd04c1b3","","",false, this);
 
            Details = RPSControlFactory.CreateRPSTextBox<InitiativeView>("6f476c56-09b2-4530-9c88-cf0b5e4ce80c","","",false, this);
 
            Rating = RPSControlFactory.CreateRPSEnumComboBox<InitiativeView>("50d3b80d-ff2f-45e4-bfc7-e0a7b5523429","","",true, this);
 
            RatingDetails = RPSControlFactory.CreateRPSTextBox<InitiativeView>("0fd5f25c-c824-49ea-9d11-ab87302536dd","","",false, this);
 
            BasicDataSection = RPSControlFactory.CreateRPSSection<InitiativeView>( "","ul li[rpsid='db2df6b9-63ae-4721-8ec6-a84a4e37e6ac']","",this);
 
            DetailsSection = RPSControlFactory.CreateRPSSection<InitiativeView>( "","ul li[rpsid='738b2374-8ffc-493f-9292-c61c8bb847a2']","",this);
 
            Section2 = RPSControlFactory.CreateRPSSection<InitiativeView>( "","ul li[rpsid='d5af2b23-47f0-4443-a6f3-4d7684531b17']","",this);
 

        }
        public IRPSButton<InitiativeView> DeleteButton { get; set; } 
        public IRPSButton<InitiativeView,StrategicGoalView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<InitiativeView,StrategicGoalView> BackButton { get; set; } 
        public IRPSAcceptButton<InitiativeView,StrategicGoalView> AcceptButton { get; set; } 
        public IRPSComboBox<InitiativeView> IDStrategicGoal { get; set; } 
        public IRPSTextBox<InitiativeView> CodInitiative { get; set; } 
        public IRPSTextBox<InitiativeView> Description { get; set; } 
        public IRPSTextBox<InitiativeView> StartDate { get; set; } 
        public IRPSTextBox<InitiativeView> EndDate { get; set; } 
        public IRPSComboBox<InitiativeView> Responsible { get; set; } 
        public IRPSTextBox<InitiativeView> Details { get; set; } 
        public IRPSComboBox<InitiativeView> Rating { get; set; } 
        public IRPSTextBox<InitiativeView> RatingDetails { get; set; } 
        public IRPSSection<InitiativeView> BasicDataSection { get; set; } 
        public IRPSSection<InitiativeView> DetailsSection { get; set; } 
        public IRPSSection<InitiativeView> Section2 { get; set; } 
        public StrategicPlan Screen { get; set; }
        public InitiativeView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class GoalIndicatorView : View
    {
        public GoalIndicatorView(StrategicPlan screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<GoalIndicatorView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<GoalIndicatorView,StrategicGoalView>( this,Screen.StrategicGoalView);
 
            BackButton = RPSControlFactory.RPSBackButton<GoalIndicatorView,StrategicGoalView>( this,Screen.StrategicGoalView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<GoalIndicatorView,StrategicGoalView>( this,Screen.StrategicGoalView);
 
            IDStrategicPlan = RPSControlFactory.CreateRPSComboBox<GoalIndicatorView>("865ec8f0-580b-40c1-8e3a-c10d9059ca67","","",false, this);
 
            IDStrategicGoal = RPSControlFactory.CreateRPSComboBox<GoalIndicatorView>("f0ba36a2-0e42-4556-b6e6-05c5eb24a4c5","","",true, this);
 
            IDStrategicIndicator = RPSControlFactory.CreateRPSComboBox<GoalIndicatorView>("a5d0e733-b6fa-4d55-beb9-9dc4be6711ec","","",false, this);
 
            Weight = RPSControlFactory.CreateRPSEnumComboBox<GoalIndicatorView>("696b87bc-0572-46a2-8a7e-80ded3a70a04","","",true, this);
 
            TargetValue = RPSControlFactory.CreateRPSFormattedTextBox<GoalIndicatorView>("8cca762a-434e-4606-9841-00ebfbe7b44b","","",false, this);
 
            LimitValue = RPSControlFactory.CreateRPSFormattedTextBox<GoalIndicatorView>("34998db5-424a-4003-8f91-f82e164913d6","","",false, this);
 
            Implication = RPSControlFactory.CreateRPSTextBox<GoalIndicatorView>("0d992180-c759-4e9a-8c62-84e50093ff27","","",false, this);
 

        }
        public IRPSButton<GoalIndicatorView> DeleteButton { get; set; } 
        public IRPSButton<GoalIndicatorView,StrategicGoalView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<GoalIndicatorView,StrategicGoalView> BackButton { get; set; } 
        public IRPSAcceptButton<GoalIndicatorView,StrategicGoalView> AcceptButton { get; set; } 
        public IRPSComboBox<GoalIndicatorView> IDStrategicPlan { get; set; } 
        public IRPSComboBox<GoalIndicatorView> IDStrategicGoal { get; set; } 
        public IRPSComboBox<GoalIndicatorView> IDStrategicIndicator { get; set; } 
        public IRPSComboBox<GoalIndicatorView> Weight { get; set; } 
        public IRPSTextBox<GoalIndicatorView> TargetValue { get; set; } 
        public IRPSTextBox<GoalIndicatorView> LimitValue { get; set; } 
        public IRPSTextBox<GoalIndicatorView> Implication { get; set; } 
        public StrategicPlan Screen { get; set; }
        public GoalIndicatorView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}