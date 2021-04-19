    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.BPM.ProcessImprovement
{
    //RPS VERSION 1.0.0.0
    public partial class ProcessImprovement:Screen
    {
        public ProcessImprovement():base()
        {
            this.URL = "bpm.processimprovement";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ProcessImprovementAreaCollectionView  = new ProcessImprovementAreaCollectionView(this); 
            ProcessImprovementAreaEntityView  = new ProcessImprovementAreaEntityView(this); 
            ProcessImprovementActionView  = new ProcessImprovementActionView(this); 
            ProcessImprovementAreaCollectionView.InitializeControls(); 
            ProcessImprovementAreaEntityView.InitializeControls(); 
            ProcessImprovementActionView.InitializeControls(); 
           
        }
      
            public ProcessImprovementAreaCollectionView ProcessImprovementAreaCollectionView {get; set; } 
            public ProcessImprovementAreaEntityView ProcessImprovementAreaEntityView {get; set; } 
            public ProcessImprovementActionView ProcessImprovementActionView {get; set; } 
    }
            
    public partial class ProcessImprovementAreaCollectionView : View
    {
        public ProcessImprovementAreaCollectionView(ProcessImprovement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<ProcessImprovementAreaCollectionView,ProcessImprovementAreaEntityView>( this,Screen.ProcessImprovementAreaEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "b78ded44-88e4-4d1d-82cd-7e602401f433",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<ProcessImprovementAreaCollectionView,ProcessImprovementAreaEntityView>( params_MainConsult,this,Screen.ProcessImprovementAreaEntityView);
 

        }
        public IRPSButton<ProcessImprovementAreaCollectionView,ProcessImprovementAreaEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<ProcessImprovementAreaCollectionView,ProcessImprovementAreaEntityView> MainConsult { get; set; } 
        public ProcessImprovement Screen { get; set; }
        public ProcessImprovementAreaCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ProcessImprovementAreaEntityView : View
    {
        public ProcessImprovementAreaEntityView(ProcessImprovement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ProcessImprovementAreaEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ProcessImprovementAreaEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ProcessImprovementAreaEntityView,ProcessImprovementAreaCollectionView>( this,Screen.ProcessImprovementAreaCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<ProcessImprovementAreaEntityView,ProcessImprovementAreaCollectionView>( this,Screen.ProcessImprovementAreaCollectionView);
 
            Description = RPSControlFactory.CreateRPSTextBox<ProcessImprovementAreaEntityView>("947a68ff-31c1-432b-b68e-508af70fc157","","",true, this);
 
            IDProcess = RPSControlFactory.CreateRPSComboBox<ProcessImprovementAreaEntityView>("6e489f31-cea2-4574-a3c7-efaf541fa4ca","","",true, this);
 
            Details = RPSControlFactory.CreateRPSTextBox<ProcessImprovementAreaEntityView>("cc7d5b6f-0386-4334-b869-9d6c44acc8b8","","",false, this);
 
            Priority = RPSControlFactory.CreateRPSEnumComboBox<ProcessImprovementAreaEntityView>("9137e4c8-4614-4e71-9d65-42adfc652202","","",true, this);
 
            Started = RPSControlFactory.CreateRPSCheckBox<ProcessImprovementAreaEntityView>("2969604a-bd4a-4287-901f-42378e363cb7","","",true, this);
 
            Finished = RPSControlFactory.CreateRPSCheckBox<ProcessImprovementAreaEntityView>("b66c210e-9e29-479f-b729-c28dd78d6b27","","",true, this);
 
            Comments = RPSControlFactory.CreateRPSTextBox<ProcessImprovementAreaEntityView>("0ce73b2e-53a4-44ef-9a2c-4442d7eeec2e","","",false, this);
 
            CollectionInit params_ProcessImprovementActions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d2e4ae98-4d02-43ba-867f-b73cb5019364",CSSSelectorGrid="",XPathGrid=""};
            ProcessImprovementActions = RPSControlFactory.RPSCreateCollectionWithGrid<ProcessImprovementActionsCollectionEditor<ProcessImprovementAreaEntityView,ProcessImprovementActionView>,ProcessImprovementAreaEntityView,ProcessImprovementActionView>( params_ProcessImprovementActions,this,Screen.ProcessImprovementActionView);
 
            General = RPSControlFactory.CreateRPSSection<ProcessImprovementAreaEntityView>( "","ul li[rpsid='effd5767-3c2e-41d2-9bc2-a0f80eb11580']","",this);
 
            Comments1 = RPSControlFactory.CreateRPSSection<ProcessImprovementAreaEntityView>( "","ul li[rpsid='c990c2f2-af70-4ea3-b6de-ec8d23b2f046']","",this);
 

        }
        public IRPSSaveButton<ProcessImprovementAreaEntityView> SaveButton { get; set; } 
        public IRPSButton<ProcessImprovementAreaEntityView> DeleteButton { get; set; } 
        public IRPSButton<ProcessImprovementAreaEntityView,ProcessImprovementAreaCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ProcessImprovementAreaEntityView,ProcessImprovementAreaCollectionView> BackButton { get; set; } 
        public IRPSTextBox<ProcessImprovementAreaEntityView> Description { get; set; } 
        public IRPSComboBox<ProcessImprovementAreaEntityView> IDProcess { get; set; } 
        public IRPSTextBox<ProcessImprovementAreaEntityView> Details { get; set; } 
        public IRPSComboBox<ProcessImprovementAreaEntityView> Priority { get; set; } 
        public IRPSCheckbox<ProcessImprovementAreaEntityView> Started { get; set; } 
        public IRPSCheckbox<ProcessImprovementAreaEntityView> Finished { get; set; } 
        public IRPSTextBox<ProcessImprovementAreaEntityView> Comments { get; set; } 
        public ProcessImprovementActionsCollectionEditor<ProcessImprovementAreaEntityView,ProcessImprovementActionView> ProcessImprovementActions { get; set; } 
        public IRPSSection<ProcessImprovementAreaEntityView> General { get; set; } 
        public IRPSSection<ProcessImprovementAreaEntityView> Comments1 { get; set; } 
        public ProcessImprovement Screen { get; set; }
        public ProcessImprovementAreaEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ProcessImprovementActionsCollectionEditor<ProcessImprovementAreaEntityView,ProcessImprovementActionView>:RPSCollectionEditor<ProcessImprovementAreaEntityView,ProcessImprovementActionView> where ProcessImprovementAreaEntityView : class, IView where ProcessImprovementActionView : class, IView
    {
        public  ProcessImprovementActionsGridView<ProcessImprovementAreaEntityView,ProcessImprovementActionView> GridView {get;set;}
    }
    public partial class ProcessImprovementActionsGridView <ProcessImprovementAreaEntityView,ProcessImprovementActionView> :  RPSGridView<ProcessImprovementAreaEntityView,ProcessImprovementActionView> where ProcessImprovementAreaEntityView : class, IView where ProcessImprovementActionView : class, IView
    {
        public ProcessImprovementActionsGridView(ProcessImprovementAreaEntityView currentView,ProcessImprovementActionView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodAction = RPSControlFactory.CreateRPSGridTextBox<ProcessImprovementAreaEntityView>("","#d2e4ae98-4d02-43ba-867f-b73cb5019364 .ag-row[role='row']@ROWINDEX [col-id='cCodAction']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ProcessImprovementAreaEntityView>("","#d2e4ae98-4d02-43ba-867f-b73cb5019364 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",true, this.CurrentView);
 
            Status = RPSControlFactory.CreateRPSGridEnumComboBox<ProcessImprovementAreaEntityView>("","#d2e4ae98-4d02-43ba-867f-b73cb5019364 .ag-row[role='row']@ROWINDEX [col-id='cStatus']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<ProcessImprovementAreaEntityView> CodAction { get; set; } 
        public IRPSGridTextBox<ProcessImprovementAreaEntityView> Description { get; set; } 
        public IRPSGridComboBox<ProcessImprovementAreaEntityView> Status { get; set; } 
                     
    }
 
    }
  
            
    public partial class ProcessImprovementActionView : View
    {
        public ProcessImprovementActionView(ProcessImprovement screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ProcessImprovementActionView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ProcessImprovementActionView,ProcessImprovementAreaEntityView>( this,Screen.ProcessImprovementAreaEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<ProcessImprovementActionView,ProcessImprovementAreaEntityView>( this,Screen.ProcessImprovementAreaEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ProcessImprovementActionView,ProcessImprovementAreaEntityView>( this,Screen.ProcessImprovementAreaEntityView);
 
            CodAction = RPSControlFactory.CreateRPSTextBox<ProcessImprovementActionView>("219ed407-ddbe-4daf-8d7b-9b85acb3fadd","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ProcessImprovementActionView>("e341fc11-5723-4add-acdb-5c4747b55571","","",true, this);
 
            Status = RPSControlFactory.CreateRPSEnumComboBox<ProcessImprovementActionView>("1bd9fcd2-3caf-413b-a7e9-4db0d43dd82d","","",true, this);
 
            PlannedStartDate = RPSControlFactory.CreateRPSTextBox<ProcessImprovementActionView>("96c964f3-f4e4-4f01-a613-3eb62d095656","","",false, this);
 
            PlannedEndDate = RPSControlFactory.CreateRPSTextBox<ProcessImprovementActionView>("565b289e-57ad-436b-a162-9c0fe0524089","","",false, this);
 
            StartDate = RPSControlFactory.CreateRPSTextBox<ProcessImprovementActionView>("f4a72f72-0b30-4d4c-a605-ecd4fd4dd318","","",false, this);
 
            EndDate = RPSControlFactory.CreateRPSTextBox<ProcessImprovementActionView>("9e40b22c-1c73-4c7c-bbb1-36b3af4c41c4","","",false, this);
 
            IDUser = RPSControlFactory.CreateRPSComboBox<ProcessImprovementActionView>("3126e62e-2afb-4f3f-a5c4-ad7d4ca02833","","",false, this);
 
            Source = RPSControlFactory.CreateRPSTextBox<ProcessImprovementActionView>("e0c9ebc4-8350-445b-a185-b340ec879a42","","",false, this);
 
            Proposal = RPSControlFactory.CreateRPSTextBox<ProcessImprovementActionView>("dfe17123-0dc2-447b-aaa9-c5c021a867ee","","",false, this);
 
            DeploymentPlan = RPSControlFactory.CreateRPSTextBox<ProcessImprovementActionView>("e1ef355b-2483-4e24-bd12-e2109d798a06","","",false, this);
 
            AllocatedResources = RPSControlFactory.CreateRPSTextBox<ProcessImprovementActionView>("1dbcb7c9-bec6-4c29-aac6-b1644432f29e","","",false, this);
 
            SupportAreas = RPSControlFactory.CreateRPSTextBox<ProcessImprovementActionView>("aae7cb4d-25aa-4f65-ab9a-037cfc2a98c1","","",false, this);
 
            Objectives = RPSControlFactory.CreateRPSTextBox<ProcessImprovementActionView>("7799cab5-efb6-499e-b53b-6258303f94ce","","",false, this);
 
            Goals = RPSControlFactory.CreateRPSTextBox<ProcessImprovementActionView>("015dd99d-731b-43bb-9432-4399d814e914","","",false, this);
 
            CostBenefitAnalysis = RPSControlFactory.CreateRPSTextBox<ProcessImprovementActionView>("d7988bda-64e8-4338-af7d-8c3bc9836662","","",false, this);
 
            Rating = RPSControlFactory.CreateRPSEnumComboBox<ProcessImprovementActionView>("d526d500-615f-4dd7-a36e-83266d6cbb86","","",true, this);
 
            Details = RPSControlFactory.CreateRPSTextBox<ProcessImprovementActionView>("e2abf143-14bd-4279-b420-7cf1ae475fda","","",false, this);
 
            CollectionInit params_ImprovementActionTrackings = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="1faae149-7929-458e-8c10-d373840444d3",CSSSelectorGrid="",XPathGrid=""};
            ImprovementActionTrackings = RPSControlFactory.RPSCreateCollectionWithGrid<ImprovementActionTrackingsCollectionEditor<ProcessImprovementActionView>,ProcessImprovementActionView>( params_ImprovementActionTrackings,this);
 
            General = RPSControlFactory.CreateRPSSection<ProcessImprovementActionView>( "","ul li[rpsid='bedd8847-f9ca-443e-bb5c-0adca5107c90']","",this);
 
            Deployment = RPSControlFactory.CreateRPSSection<ProcessImprovementActionView>( "","ul li[rpsid='84d41648-a50e-4b5d-b63c-fd564529c5c6']","",this);
 
            TrackingModel = RPSControlFactory.CreateRPSSection<ProcessImprovementActionView>( "","ul li[rpsid='46167d41-c4d0-4a5b-acee-df69f220806d']","",this);
 
            Analysis = RPSControlFactory.CreateRPSSection<ProcessImprovementActionView>( "","ul li[rpsid='98903923-3adc-4b7b-9dbe-3c2a9cecdd5a']","",this);
 
            Rating1 = RPSControlFactory.CreateRPSSection<ProcessImprovementActionView>( "","ul li[rpsid='a508a3ee-b34d-4d88-b0d8-24c79a204bcf']","",this);
 
            Tracking = RPSControlFactory.CreateRPSSection<ProcessImprovementActionView>( "","ul li[rpsid='28fbcd5c-bb55-4d77-9ed6-41eb55d674b9']","",this);
 

        }
        public IRPSButton<ProcessImprovementActionView> DeleteButton { get; set; } 
        public IRPSButton<ProcessImprovementActionView,ProcessImprovementAreaEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ProcessImprovementActionView,ProcessImprovementAreaEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<ProcessImprovementActionView,ProcessImprovementAreaEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<ProcessImprovementActionView> CodAction { get; set; } 
        public IRPSTextBox<ProcessImprovementActionView> Description { get; set; } 
        public IRPSComboBox<ProcessImprovementActionView> Status { get; set; } 
        public IRPSTextBox<ProcessImprovementActionView> PlannedStartDate { get; set; } 
        public IRPSTextBox<ProcessImprovementActionView> PlannedEndDate { get; set; } 
        public IRPSTextBox<ProcessImprovementActionView> StartDate { get; set; } 
        public IRPSTextBox<ProcessImprovementActionView> EndDate { get; set; } 
        public IRPSComboBox<ProcessImprovementActionView> IDUser { get; set; } 
        public IRPSTextBox<ProcessImprovementActionView> Source { get; set; } 
        public IRPSTextBox<ProcessImprovementActionView> Proposal { get; set; } 
        public IRPSTextBox<ProcessImprovementActionView> DeploymentPlan { get; set; } 
        public IRPSTextBox<ProcessImprovementActionView> AllocatedResources { get; set; } 
        public IRPSTextBox<ProcessImprovementActionView> SupportAreas { get; set; } 
        public IRPSTextBox<ProcessImprovementActionView> Objectives { get; set; } 
        public IRPSTextBox<ProcessImprovementActionView> Goals { get; set; } 
        public IRPSTextBox<ProcessImprovementActionView> CostBenefitAnalysis { get; set; } 
        public IRPSComboBox<ProcessImprovementActionView> Rating { get; set; } 
        public IRPSTextBox<ProcessImprovementActionView> Details { get; set; } 
        public ImprovementActionTrackingsCollectionEditor<ProcessImprovementActionView> ImprovementActionTrackings { get; set; } 
        public IRPSSection<ProcessImprovementActionView> General { get; set; } 
        public IRPSSection<ProcessImprovementActionView> Deployment { get; set; } 
        public IRPSSection<ProcessImprovementActionView> TrackingModel { get; set; } 
        public IRPSSection<ProcessImprovementActionView> Analysis { get; set; } 
        public IRPSSection<ProcessImprovementActionView> Rating1 { get; set; } 
        public IRPSSection<ProcessImprovementActionView> Tracking { get; set; } 
        public ProcessImprovement Screen { get; set; }
        public ProcessImprovementActionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ImprovementActionTrackingsCollectionEditor<ProcessImprovementActionView>:RPSCollectionEditor<ProcessImprovementActionView> where ProcessImprovementActionView : class, IView
    {
        public  ImprovementActionTrackingsGridView<ProcessImprovementActionView> GridView {get;set;}
    }
    public partial class ImprovementActionTrackingsGridView <ProcessImprovementActionView> :  RPSGridView<ProcessImprovementActionView> where ProcessImprovementActionView : class, IView
    {
        public ImprovementActionTrackingsGridView(ProcessImprovementActionView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDTrackingCode = RPSControlFactory.CreateRPSGridComboBox<ProcessImprovementActionView>("","#1faae149-7929-458e-8c10-d373840444d3 .ag-row[role='row']@ROWINDEX [col-id='cIDTrackingCode']","",true, this.CurrentView);
 
            Date = RPSControlFactory.CreateRPSGridTextBox<ProcessImprovementActionView>("","#1faae149-7929-458e-8c10-d373840444d3 .ag-row[role='row']@ROWINDEX [col-id='cDate']","",true, this.CurrentView);
 
            CreatedBy = RPSControlFactory.CreateRPSGridComboBox<ProcessImprovementActionView>("","#1faae149-7929-458e-8c10-d373840444d3 .ag-row[role='row']@ROWINDEX [col-id='cCreatedBy']","",true, this.CurrentView);
 
            Details = RPSControlFactory.CreateRPSGridMemoTextBox<ProcessImprovementActionView>("","#1faae149-7929-458e-8c10-d373840444d3 .ag-row[role='row']@ROWINDEX [col-id='cDetails']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ProcessImprovementActionView> IDTrackingCode { get; set; } 
        public IRPSGridTextBox<ProcessImprovementActionView> Date { get; set; } 
        public IRPSGridComboBox<ProcessImprovementActionView> CreatedBy { get; set; } 
        public IRPSGridTextBox<ProcessImprovementActionView> Details { get; set; } 
                     
    }
 
    }
  
    

}