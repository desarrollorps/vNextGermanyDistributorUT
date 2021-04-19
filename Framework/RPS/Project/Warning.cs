    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.Warning
{
    //RPS VERSION 1.0.0.0
    public partial class Warning:Screen
    {
        public Warning():base()
        {
            this.URL = "project.warning";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            WarningCollectionView  = new WarningCollectionView(this); 
            WarningEntityView  = new WarningEntityView(this); 
            WarningSolutionView  = new WarningSolutionView(this); 
            ChangeSituationDialogView  = new ChangeSituationDialogView(this); 
            NewCodWarningDialogView  = new NewCodWarningDialogView(this); 
            CreateWarningDialogView  = new CreateWarningDialogView(this); 
            CreateWarningMaterialDialogView  = new CreateWarningMaterialDialogView(this); 
            CreateWarningCostDialogView  = new CreateWarningCostDialogView(this); 
            NewWarningChildDialogView  = new NewWarningChildDialogView(this); 
            CuDistCreateTimePostingPopUpDialogView  = new CuDistCreateTimePostingPopUpDialogView(this); 
            WarningCollectionView.InitializeControls(); 
            WarningEntityView.InitializeControls(); 
            WarningSolutionView.InitializeControls(); 
            ChangeSituationDialogView.InitializeControls(); 
            NewCodWarningDialogView.InitializeControls(); 
            CreateWarningDialogView.InitializeControls(); 
            CreateWarningMaterialDialogView.InitializeControls(); 
            CreateWarningCostDialogView.InitializeControls(); 
            NewWarningChildDialogView.InitializeControls(); 
            CuDistCreateTimePostingPopUpDialogView.InitializeControls(); 
           
        }
      
            public WarningCollectionView WarningCollectionView {get; set; } 
            public WarningEntityView WarningEntityView {get; set; } 
            public WarningSolutionView WarningSolutionView {get; set; } 
            public ChangeSituationDialogView ChangeSituationDialogView {get; set; } 
            public NewCodWarningDialogView NewCodWarningDialogView {get; set; } 
            public CreateWarningDialogView CreateWarningDialogView {get; set; } 
            public CreateWarningMaterialDialogView CreateWarningMaterialDialogView {get; set; } 
            public CreateWarningCostDialogView CreateWarningCostDialogView {get; set; } 
            public NewWarningChildDialogView NewWarningChildDialogView {get; set; } 
            public CuDistCreateTimePostingPopUpDialogView CuDistCreateTimePostingPopUpDialogView {get; set; } 
    }
            
    public partial class WarningCollectionView : View
    {
        public WarningCollectionView(Warning screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<WarningCollectionView,WarningEntityView>( this,Screen.WarningEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "ea245b49-2762-466e-80f4-eb6b4e4b703f",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<WarningCollectionView,WarningEntityView>( params_MainConsult,this,Screen.WarningEntityView);
 

        }
        public IRPSButton<WarningCollectionView,WarningEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<WarningCollectionView,WarningEntityView> MainConsult { get; set; } 
        public Warning Screen { get; set; }
        public WarningCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class WarningEntityView : View
    {
        public WarningEntityView(Warning screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<WarningEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<WarningEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<WarningEntityView,WarningCollectionView>( this,Screen.WarningCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<WarningEntityView,WarningCollectionView>( this,Screen.WarningCollectionView);
 
            CodWarning = RPSControlFactory.CreateRPSTextBox<WarningEntityView>("9263b800-1f8e-41cc-9669-831a12f712e6","","",true, this);
 
            IDProject = RPSControlFactory.CreateRPSComboBox<WarningEntityView>("60901731-eb5d-4413-8ba4-f57a9a4b296e","","",true, this);
 
            IDPROTask = RPSControlFactory.CreateRPSComboBox<WarningEntityView>("d60a7837-a660-4cbc-b98a-2144523e41f0","","",true, this);
 
            IDEmployeeReportedBy = RPSControlFactory.CreateRPSComboBox<WarningEntityView>("7cdee084-bebe-453a-94db-c1cd72f197ee","","",true, this);
 
            IDEmployeeAssignedTo = RPSControlFactory.CreateRPSComboBox<WarningEntityView>("2fd76b0f-328d-427f-8ef9-bd484fc4559f","","",false, this);
 
            IDEmployeeManager = RPSControlFactory.CreateRPSComboBox<WarningEntityView>("7e3d8ce9-e6ae-477c-b29d-aae9ac317074","","",true, this);
 
            PlannedDate = RPSControlFactory.CreateRPSTextBox<WarningEntityView>("cdaa7a2b-7161-426c-9b9d-063568bff22b","","",false, this);
 
            EntryDate = RPSControlFactory.CreateRPSTextBox<WarningEntityView>("255b22a4-5dd8-46e9-87bc-a390ba08d3d7","","",true, this);
 
            EntryTime = RPSControlFactory.CreateRPSTextBox<WarningEntityView>("2f941a7e-dd7e-4cd3-85a0-469c5d9ace1a","","",true, this);
 
            ClosingDate = RPSControlFactory.CreateRPSTextBox<WarningEntityView>("f9f843b9-fae8-4867-93b5-5242ab7cb338","","",false, this);
 
            ClosingTime = RPSControlFactory.CreateRPSTextBox<WarningEntityView>("4ad97e2b-3103-42aa-b16c-6c90f01051af","","",false, this);
 
            IDPROSituationWarning = RPSControlFactory.CreateRPSComboBox<WarningEntityView>("56d23563-98e2-4fa7-a3a0-c8d0466cfd30","","",true, this);
 
            IDPROWarningType = RPSControlFactory.CreateRPSComboBox<WarningEntityView>("31e74b9c-4c1e-4f93-967a-92f78de6fbde","","",true, this);
 
            IDPROWarningPriority = RPSControlFactory.CreateRPSComboBox<WarningEntityView>("c491528d-8c28-4b74-ac27-fc0207231555","","",true, this);
 
            IDPROWarningSeverity = RPSControlFactory.CreateRPSComboBox<WarningEntityView>("8e5a051e-c120-4969-9374-6f4c476a57af","","",true, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<WarningEntityView>("64a30058-748f-4c45-b5a2-0c78b72787a3","","",false, this);
 
            IDTest = RPSControlFactory.CreateRPSComboBox<WarningEntityView>("597d6926-500e-4444-a245-16176209ab10","","",false, this);
 
            NumHours = RPSControlFactory.CreateRPSFormattedTextBox<WarningEntityView>("f63214cc-df4d-49a4-92f0-3b09f5ca2f1a","","",false, this);
 
            AmountCost = RPSControlFactory.CreateRPSFormattedTextBox<WarningEntityView>("3a43b058-4c0c-4704-9224-4409767a31ed","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<WarningEntityView>("4a5fdeee-e26c-4869-9f49-ba236dec91b0","","",false, this);
 
            Solution = RPSControlFactory.CreateRPSTextBox<WarningEntityView>("6eae0aac-2e70-46be-adad-d25950d2c874","","",false, this);
 
            NewWarningChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<WarningEntityView,NewWarningChildDialogView>("0a09145f-c199-41c7-950f-0b94c90219cb","","", this,Screen.NewWarningChildDialogView);
 
            LinkChangeSituationCommandButton = RPSControlFactory.CreateRPSButtonToView<WarningEntityView,ChangeSituationDialogView>("8694b74b-1e04-4806-be6f-04c7b510e90b","","", this,Screen.ChangeSituationDialogView);
 
            ReportCommandButton = RPSControlFactory.CreateRPSButton<WarningEntityView>( "39c5a6fc-6a18-44bf-b842-a1806f8cca57","","",this);
 
            CreateWarningNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<WarningEntityView,CreateWarningDialogView>("51f9f6aa-0148-481c-af27-6c6e4f9c5b28","","", this,Screen.CreateWarningDialogView);
 
            CuDistCreateTimePostingPopUpNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<WarningEntityView,CuDistCreateTimePostingPopUpDialogView>("c3784475-a8c2-4ab4-acc3-6cef9d11c86e","","", this,Screen.CuDistCreateTimePostingPopUpDialogView);
 
            CreateWarningMaterialNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<WarningEntityView,CreateWarningMaterialDialogView>("7a9affd3-8553-47c1-bbbb-660d656759d7","","", this,Screen.CreateWarningMaterialDialogView);
 
            CreateWarningCostNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<WarningEntityView,CreateWarningCostDialogView>("e9ac3117-cadb-4710-8727-e2a0a8656e97","","", this,Screen.CreateWarningCostDialogView);
 
            CollectionInit params_WarningSolutions = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="36eedf3b-3e1d-4580-a9a3-b13897437626",CSSSelectorGrid="",XPathGrid=""};
            WarningSolutions = RPSControlFactory.RPSCreateCollectionWithGrid<WarningSolutionsCollectionEditor<WarningEntityView,WarningSolutionView>,WarningEntityView,WarningSolutionView>( params_WarningSolutions,this,Screen.WarningSolutionView);
 
            CollectionInit params_ImputationsWithinWarning = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="808cfc2d-007e-48d5-afd1-5a200bfaafa4",CSSSelectorGrid="",XPathGrid=""};
            ImputationsWithinWarning = RPSControlFactory.RPSCreateCollectionWithGrid<ImputationsWithinWarningCollectionEditor<WarningEntityView,WarningSolutionView>,WarningEntityView,WarningSolutionView>( params_ImputationsWithinWarning,this,Screen.WarningSolutionView);
 
            General = RPSControlFactory.CreateRPSSection<WarningEntityView>( "","ul li[rpsid='428b3929-169d-4f1f-900c-1650d6039d6d']","",this);
 
            Section = RPSControlFactory.CreateRPSSection<WarningEntityView>( "","ul li[rpsid='c3fdd55d-11eb-4550-9f95-78b24657eda7']","",this);
 
            Solutions = RPSControlFactory.CreateRPSSection<WarningEntityView>( "","ul li[rpsid='1966aaa4-4c9e-49b6-b2e6-f7569ae93462']","",this);
 
            Imputation = RPSControlFactory.CreateRPSSection<WarningEntityView>( "","ul li[rpsid='b2c62e99-763b-45f5-af2c-d30acb22da5e']","",this);
 

        }
        public IRPSSaveButton<WarningEntityView> SaveButton { get; set; } 
        public IRPSButton<WarningEntityView> DeleteButton { get; set; } 
        public IRPSButton<WarningEntityView,WarningCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<WarningEntityView,WarningCollectionView> BackButton { get; set; } 
        public IRPSTextBox<WarningEntityView> CodWarning { get; set; } 
        public IRPSComboBox<WarningEntityView> IDProject { get; set; } 
        public IRPSComboBox<WarningEntityView> IDPROTask { get; set; } 
        public IRPSComboBox<WarningEntityView> IDEmployeeReportedBy { get; set; } 
        public IRPSComboBox<WarningEntityView> IDEmployeeAssignedTo { get; set; } 
        public IRPSComboBox<WarningEntityView> IDEmployeeManager { get; set; } 
        public IRPSTextBox<WarningEntityView> PlannedDate { get; set; } 
        public IRPSTextBox<WarningEntityView> EntryDate { get; set; } 
        public IRPSTextBox<WarningEntityView> EntryTime { get; set; } 
        public IRPSTextBox<WarningEntityView> ClosingDate { get; set; } 
        public IRPSTextBox<WarningEntityView> ClosingTime { get; set; } 
        public IRPSComboBox<WarningEntityView> IDPROSituationWarning { get; set; } 
        public IRPSComboBox<WarningEntityView> IDPROWarningType { get; set; } 
        public IRPSComboBox<WarningEntityView> IDPROWarningPriority { get; set; } 
        public IRPSComboBox<WarningEntityView> IDPROWarningSeverity { get; set; } 
        public IRPSComboBox<WarningEntityView> IDArticle { get; set; } 
        public IRPSComboBox<WarningEntityView> IDTest { get; set; } 
        public IRPSTextBox<WarningEntityView> NumHours { get; set; } 
        public IRPSTextBox<WarningEntityView> AmountCost { get; set; } 
        public IRPSTextBox<WarningEntityView> Description { get; set; } 
        public IRPSTextBox<WarningEntityView> Solution { get; set; } 
        public IRPSButton<WarningEntityView,NewWarningChildDialogView> NewWarningChildNavigationCommandButton { get; set; } 
        public IRPSButton<WarningEntityView,ChangeSituationDialogView> LinkChangeSituationCommandButton { get; set; } 
        public IRPSButton<WarningEntityView> ReportCommandButton { get; set; } 
        public IRPSButton<WarningEntityView,CreateWarningDialogView> CreateWarningNavigationCommandButton { get; set; } 
        public IRPSButton<WarningEntityView,CuDistCreateTimePostingPopUpDialogView> CuDistCreateTimePostingPopUpNavigationCommandButton { get; set; } 
        public IRPSButton<WarningEntityView,CreateWarningMaterialDialogView> CreateWarningMaterialNavigationCommandButton { get; set; } 
        public IRPSButton<WarningEntityView,CreateWarningCostDialogView> CreateWarningCostNavigationCommandButton { get; set; } 
        public WarningSolutionsCollectionEditor<WarningEntityView,WarningSolutionView> WarningSolutions { get; set; } 
        public ImputationsWithinWarningCollectionEditor<WarningEntityView,WarningSolutionView> ImputationsWithinWarning { get; set; } 
        public IRPSSection<WarningEntityView> General { get; set; } 
        public IRPSSection<WarningEntityView> Section { get; set; } 
        public IRPSSection<WarningEntityView> Solutions { get; set; } 
        public IRPSSection<WarningEntityView> Imputation { get; set; } 
        public Warning Screen { get; set; }
        public WarningEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class WarningSolutionsCollectionEditor<WarningEntityView,WarningSolutionView>:RPSCollectionEditor<WarningEntityView,WarningSolutionView> where WarningEntityView : class, IView where WarningSolutionView : class, IView
    {
        public  WarningSolutionsGridView<WarningEntityView,WarningSolutionView> GridView {get;set;}
    }
    public partial class WarningSolutionsGridView <WarningEntityView,WarningSolutionView> :  RPSGridView<WarningEntityView,WarningSolutionView> where WarningEntityView : class, IView where WarningSolutionView : class, IView
    {
        public WarningSolutionsGridView(WarningEntityView currentView,WarningSolutionView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Numline = RPSControlFactory.CreateRPSGridFormattedTextBox<WarningEntityView>("","#36eedf3b-3e1d-4580-a9a3-b13897437626 .ag-row[role='row']@ROWINDEX [col-id='cNumline']","",true, this.CurrentView);
 
            IDPROSolutionType = RPSControlFactory.CreateRPSGridComboBox<WarningEntityView>("","#36eedf3b-3e1d-4580-a9a3-b13897437626 .ag-row[role='row']@ROWINDEX [col-id='cIDPROSolutionType']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridMemoTextBox<WarningEntityView>("","#36eedf3b-3e1d-4580-a9a3-b13897437626 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            EntryDate = RPSControlFactory.CreateRPSGridTextBox<WarningEntityView>("","#36eedf3b-3e1d-4580-a9a3-b13897437626 .ag-row[role='row']@ROWINDEX [col-id='cEntryDate']","",true, this.CurrentView);
 
            EntryTime = RPSControlFactory.CreateRPSGridTextBox<WarningEntityView>("","#36eedf3b-3e1d-4580-a9a3-b13897437626 .ag-row[role='row']@ROWINDEX [col-id='cEntryTime']","",true, this.CurrentView);
 
            IDEmployee = RPSControlFactory.CreateRPSGridComboBox<WarningEntityView>("","#36eedf3b-3e1d-4580-a9a3-b13897437626 .ag-row[role='row']@ROWINDEX [col-id='cIDEmployee']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<WarningEntityView> Numline { get; set; } 
        public IRPSGridComboBox<WarningEntityView> IDPROSolutionType { get; set; } 
        public IRPSGridTextBox<WarningEntityView> Description { get; set; } 
        public IRPSGridTextBox<WarningEntityView> EntryDate { get; set; } 
        public IRPSGridTextBox<WarningEntityView> EntryTime { get; set; } 
        public IRPSGridComboBox<WarningEntityView> IDEmployee { get; set; } 
                     
    }
 
        public partial class ImputationsWithinWarningCollectionEditor<WarningEntityView,WarningSolutionView>:RPSCollectionEditor<WarningEntityView,WarningSolutionView> where WarningEntityView : class, IView where WarningSolutionView : class, IView
    {
        public  ImputationsWithinWarningGridView<WarningEntityView,WarningSolutionView> GridView {get;set;}
    }
    public partial class ImputationsWithinWarningGridView <WarningEntityView,WarningSolutionView> :  RPSGridView<WarningEntityView,WarningSolutionView> where WarningEntityView : class, IView where WarningSolutionView : class, IView
    {
        public ImputationsWithinWarningGridView(WarningEntityView currentView,WarningSolutionView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ImputationDate = RPSControlFactory.CreateRPSGridTextBox<WarningEntityView>("","#808cfc2d-007e-48d5-afd1-5a200bfaafa4 .ag-row[role='row']@ROWINDEX [col-id='cImputationDate']","",false, this.CurrentView);
 
            ResourceType = RPSControlFactory.CreateRPSGridTextBox<WarningEntityView>("","#808cfc2d-007e-48d5-afd1-5a200bfaafa4 .ag-row[role='row']@ROWINDEX [col-id='cResourceType']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<WarningEntityView>("","#808cfc2d-007e-48d5-afd1-5a200bfaafa4 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",false, this.CurrentView);
 
            CostAmountReal = RPSControlFactory.CreateRPSGridFormattedTextBox<WarningEntityView>("","#808cfc2d-007e-48d5-afd1-5a200bfaafa4 .ag-row[role='row']@ROWINDEX [col-id='cCostAmountReal']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<WarningEntityView> ImputationDate { get; set; } 
        public IRPSGridTextBox<WarningEntityView> ResourceType { get; set; } 
        public IRPSGridTextBox<WarningEntityView> Quantity { get; set; } 
        public IRPSGridTextBox<WarningEntityView> CostAmountReal { get; set; } 
                     
    }
 
    }
  
            
    public partial class WarningSolutionView : View
    {
        public WarningSolutionView(Warning screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<WarningSolutionView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<WarningSolutionView,WarningEntityView>( this,Screen.WarningEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<WarningSolutionView,WarningEntityView>( this,Screen.WarningEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<WarningSolutionView,WarningEntityView>( this,Screen.WarningEntityView);
 
            Numline = RPSControlFactory.CreateRPSFormattedTextBox<WarningSolutionView>("d618d874-b96f-4a78-ad25-adb97ee64b75","","",true, this);
 
            IDPROSolutionType = RPSControlFactory.CreateRPSComboBox<WarningSolutionView>("d0ec3710-cabe-463e-a80a-c0a21b451f47","","",true, this);
 
            IDEmployee = RPSControlFactory.CreateRPSComboBox<WarningSolutionView>("ef13ac10-856a-46c5-9df0-ecaa0519ea9c","","",true, this);
 
            EntryDate = RPSControlFactory.CreateRPSTextBox<WarningSolutionView>("d291ef12-552a-4ff3-87e9-54fe1de5c73f","","",true, this);
 
            EntryTime = RPSControlFactory.CreateRPSTextBox<WarningSolutionView>("caa26254-1ace-4ecd-a242-a258c3151c37","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<WarningSolutionView>("ea789786-546c-49da-9a6c-c9fba7c643b9","","",false, this);
 

        }
        public IRPSButton<WarningSolutionView> DeleteButton { get; set; } 
        public IRPSButton<WarningSolutionView,WarningEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<WarningSolutionView,WarningEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<WarningSolutionView,WarningEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<WarningSolutionView> Numline { get; set; } 
        public IRPSComboBox<WarningSolutionView> IDPROSolutionType { get; set; } 
        public IRPSComboBox<WarningSolutionView> IDEmployee { get; set; } 
        public IRPSTextBox<WarningSolutionView> EntryDate { get; set; } 
        public IRPSTextBox<WarningSolutionView> EntryTime { get; set; } 
        public IRPSTextBox<WarningSolutionView> Description { get; set; } 
        public Warning Screen { get; set; }
        public WarningSolutionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ChangeSituationDialogView : View
    {
        public ChangeSituationDialogView(Warning screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDPROSituationWarning = RPSControlFactory.CreateRPSComboBox<ChangeSituationDialogView>("af2ed5d0-f316-48ed-b7f3-f78c0b2e8129","","",false, this);
 
            NewSituationWarning = RPSControlFactory.CreateRPSComboBox<ChangeSituationDialogView>("5041ace6-95b3-4acd-800b-e80bd2700971","","",false, this);
 

        }
        public IRPSComboBox<ChangeSituationDialogView> IDPROSituationWarning { get; set; } 
        public IRPSComboBox<ChangeSituationDialogView> NewSituationWarning { get; set; } 
        public Warning Screen { get; set; }
        public ChangeSituationDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NewCodWarningDialogView : View
    {
        public NewCodWarningDialogView(Warning screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewCodWarning = RPSControlFactory.CreateRPSTextBox<NewCodWarningDialogView>("b0f1f4bd-7483-463e-8620-ae412408d1b7","","",false, this);
 

        }
        public IRPSTextBox<NewCodWarningDialogView> NewCodWarning { get; set; } 
        public Warning Screen { get; set; }
        public NewCodWarningDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CreateWarningDialogView : View
    {
        public CreateWarningDialogView(Warning screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIEmployee = RPSControlFactory.CreateRPSComboBox<CreateWarningDialogView>("a5fe1ea5-3412-4296-ad6b-f708f13d1b0d","","",false, this);
 
            UIImputationDate = RPSControlFactory.CreateRPSTextBox<CreateWarningDialogView>("fad4f306-7536-4863-bea3-e69690481833","","",false, this);
 
            UIDuration = RPSControlFactory.CreateRPSFormattedTextBox<CreateWarningDialogView>("c2d31fdb-aa77-433f-9b9c-983e26dfef0e","","",false, this);
 
            UIDescription = RPSControlFactory.CreateRPSTextBox<CreateWarningDialogView>("61f306c5-7c9b-4d6d-9233-e5f0e3736aa1","","",false, this);
 
            OKCommand = RPSControlFactory.CreateRPSButton<CreateWarningDialogView>( "abeee2fb-754a-4953-b6de-1bc800ef988e","","",this);
 
            CancelCommand = RPSControlFactory.CreateRPSButton<CreateWarningDialogView>( "1e1622f4-4032-47c7-8543-2373778c03f6","","",this);
 

        }
        public IRPSComboBox<CreateWarningDialogView> UIEmployee { get; set; } 
        public IRPSTextBox<CreateWarningDialogView> UIImputationDate { get; set; } 
        public IRPSTextBox<CreateWarningDialogView> UIDuration { get; set; } 
        public IRPSTextBox<CreateWarningDialogView> UIDescription { get; set; } 
        public IRPSButton<CreateWarningDialogView> OKCommand { get; set; } 
        public IRPSButton<CreateWarningDialogView> CancelCommand { get; set; } 
        public Warning Screen { get; set; }
        public CreateWarningDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CreateWarningMaterialDialogView : View
    {
        public CreateWarningMaterialDialogView(Warning screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSComboBox<CreateWarningMaterialDialogView>("a2bb6568-7480-4eaf-b201-5bb4b63c5100","","",false, this);
 
            ImputationDate = RPSControlFactory.CreateRPSTextBox<CreateWarningMaterialDialogView>("31808be8-366b-4fe5-b470-5cc2e9a41ad1","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<CreateWarningMaterialDialogView>("84d2033e-63bf-4a6e-b07a-7247d4225193","","",false, this);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<CreateWarningMaterialDialogView>("2b9c0a52-bbf5-44b3-b0a6-0a164dfb00d2","","",false, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<CreateWarningMaterialDialogView>("8867c44d-c398-4230-8ab6-b996c956f5f6","","",false, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<CreateWarningMaterialDialogView>("bf536038-f674-4217-8cb5-9206988030f6","","",false, this);
 
            Series = RPSControlFactory.CreateRPSEnumComboBox<CreateWarningMaterialDialogView>("c2329882-2121-4c57-847c-cd7f41657964","","",false, this);
 
            IDLocationWarehouse = RPSControlFactory.CreateRPSComboBox<CreateWarningMaterialDialogView>("39cca0f0-8130-4b8c-a16b-71ec3cdf73e9","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CreateWarningMaterialDialogView>("51f48f23-87fb-4634-89d6-6f794a0acf0b","","",false, this);
 
            OKCommand = RPSControlFactory.CreateRPSButton<CreateWarningMaterialDialogView>( "7325ca9d-a2d3-4fa0-853d-d49f8cb57249","","",this);
 
            CancelCommand = RPSControlFactory.CreateRPSButton<CreateWarningMaterialDialogView>( "fcc0b00a-af4c-410e-99fd-dbba279b3803","","",this);
 

        }
        public IRPSComboBox<CreateWarningMaterialDialogView> IDArticle { get; set; } 
        public IRPSTextBox<CreateWarningMaterialDialogView> ImputationDate { get; set; } 
        public IRPSTextBox<CreateWarningMaterialDialogView> Quantity { get; set; } 
        public IRPSTextBox<CreateWarningMaterialDialogView> QuantitySecondUnit { get; set; } 
        public IRPSComboBox<CreateWarningMaterialDialogView> IDSite { get; set; } 
        public IRPSComboBox<CreateWarningMaterialDialogView> IDWarehouse { get; set; } 
        public IRPSComboBox<CreateWarningMaterialDialogView> Series { get; set; } 
        public IRPSComboBox<CreateWarningMaterialDialogView> IDLocationWarehouse { get; set; } 
        public IRPSTextBox<CreateWarningMaterialDialogView> Description { get; set; } 
        public IRPSButton<CreateWarningMaterialDialogView> OKCommand { get; set; } 
        public IRPSButton<CreateWarningMaterialDialogView> CancelCommand { get; set; } 
        public Warning Screen { get; set; }
        public CreateWarningMaterialDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CreateWarningCostDialogView : View
    {
        public CreateWarningCostDialogView(Warning screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDEmployee = RPSControlFactory.CreateRPSComboBox<CreateWarningCostDialogView>("b3869628-dc0b-4dbd-8c25-b8af5addc55a","","",false, this);
 
            ImputationDate = RPSControlFactory.CreateRPSTextBox<CreateWarningCostDialogView>("4166111e-5899-4bbe-b092-04e7645a3980","","",false, this);
 
            IDCostComponent = RPSControlFactory.CreateRPSComboBox<CreateWarningCostDialogView>("0c516aec-6a15-4ffd-97e5-a31e6a983244","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<CreateWarningCostDialogView>("35d18c1f-7995-4fd7-9090-e048d7eff703","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CreateWarningCostDialogView>("32eef655-b072-445e-8654-27e6eb35e741","","",false, this);
 
            OKCommand = RPSControlFactory.CreateRPSButton<CreateWarningCostDialogView>( "82602f77-79c5-4e90-bbd6-4d9343726e25","","",this);
 
            CancelCommand = RPSControlFactory.CreateRPSButton<CreateWarningCostDialogView>( "332f8079-75af-4af4-8723-2a81cf8c3aa0","","",this);
 

        }
        public IRPSComboBox<CreateWarningCostDialogView> IDEmployee { get; set; } 
        public IRPSTextBox<CreateWarningCostDialogView> ImputationDate { get; set; } 
        public IRPSComboBox<CreateWarningCostDialogView> IDCostComponent { get; set; } 
        public IRPSTextBox<CreateWarningCostDialogView> Quantity { get; set; } 
        public IRPSTextBox<CreateWarningCostDialogView> Description { get; set; } 
        public IRPSButton<CreateWarningCostDialogView> OKCommand { get; set; } 
        public IRPSButton<CreateWarningCostDialogView> CancelCommand { get; set; } 
        public Warning Screen { get; set; }
        public CreateWarningCostDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class NewWarningChildDialogView : View
    {
        public NewWarningChildDialogView(Warning screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewCodWarning = RPSControlFactory.CreateRPSTextBox<NewWarningChildDialogView>("5503db94-84d0-4dc6-9cab-e49245fcbe27","","",false, this);
 
            IDEmployeeAssignedTo = RPSControlFactory.CreateRPSComboBox<NewWarningChildDialogView>("de8e27e2-2d89-4d20-8717-21f221937831","","",false, this);
 
            CopyDocuments = RPSControlFactory.CreateRPSCheckBox<NewWarningChildDialogView>("ca503570-ee77-462b-9b21-9a85572a629b","","",false, this);
 

        }
        public IRPSTextBox<NewWarningChildDialogView> NewCodWarning { get; set; } 
        public IRPSComboBox<NewWarningChildDialogView> IDEmployeeAssignedTo { get; set; } 
        public IRPSCheckbox<NewWarningChildDialogView> CopyDocuments { get; set; } 
        public Warning Screen { get; set; }
        public NewWarningChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CuDistCreateTimePostingPopUpDialogView : View
    {
        public CuDistCreateTimePostingPopUpDialogView(Warning screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            EstimatedTime = RPSControlFactory.CreateRPSFormattedTextBox<CuDistCreateTimePostingPopUpDialogView>("e5edda6d-2e65-4492-abab-735a3e5f3ed0","","",false, this);
 
            ImputatedTime = RPSControlFactory.CreateRPSFormattedTextBox<CuDistCreateTimePostingPopUpDialogView>("e704829a-2f39-4fa5-8c87-8372844e6579","","",false, this);
 
            TaskPercProgress = RPSControlFactory.CreateRPSFormattedTextBox<CuDistCreateTimePostingPopUpDialogView>("9e0b9c2c-a433-4069-93ea-df2d1207b0ed","","",false, this);
 
            Date = RPSControlFactory.CreateRPSTextBox<CuDistCreateTimePostingPopUpDialogView>("4ee54b81-e7f8-4cf3-814a-8192465b98af","","",false, this);
 
            PercProgress = RPSControlFactory.CreateRPSFormattedTextBox<CuDistCreateTimePostingPopUpDialogView>("281016b8-40cb-4362-8733-9e7980e8100e","","",false, this);
 
            Time = RPSControlFactory.CreateRPSFormattedTextBox<CuDistCreateTimePostingPopUpDialogView>("685bf167-e88b-4628-bfd6-e297a4e593a8","","",false, this);
 
            IsUnproductive = RPSControlFactory.CreateRPSCheckBox<CuDistCreateTimePostingPopUpDialogView>("3a3125ff-96f5-41aa-a025-73d420a20979","","",false, this);
 
            IDUnproductiveType = RPSControlFactory.CreateRPSComboBox<CuDistCreateTimePostingPopUpDialogView>("b9a853e3-6e03-4502-940c-86676730c27a","","",false, this);
 
            IDHourType = RPSControlFactory.CreateRPSComboBox<CuDistCreateTimePostingPopUpDialogView>("5590bf4a-c6e9-46b9-b6de-125b6fc1ff41","","",false, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CuDistCreateTimePostingPopUpDialogView>("dfb83a16-0a34-458e-8478-09011d16b49e","","",false, this);
 
            CreateNewImputationCommand = RPSControlFactory.CreateRPSButton<CuDistCreateTimePostingPopUpDialogView>( "38e72d34-d6f3-4956-9f73-6c2dffd7549c","","",this);
 
            CloseCommand = RPSControlFactory.CreateRPSButton<CuDistCreateTimePostingPopUpDialogView>( "5cf61578-8a43-492f-90d2-06deb44234e6","","",this);
 

        }
        public IRPSTextBox<CuDistCreateTimePostingPopUpDialogView> EstimatedTime { get; set; } 
        public IRPSTextBox<CuDistCreateTimePostingPopUpDialogView> ImputatedTime { get; set; } 
        public IRPSTextBox<CuDistCreateTimePostingPopUpDialogView> TaskPercProgress { get; set; } 
        public IRPSTextBox<CuDistCreateTimePostingPopUpDialogView> Date { get; set; } 
        public IRPSTextBox<CuDistCreateTimePostingPopUpDialogView> PercProgress { get; set; } 
        public IRPSTextBox<CuDistCreateTimePostingPopUpDialogView> Time { get; set; } 
        public IRPSCheckbox<CuDistCreateTimePostingPopUpDialogView> IsUnproductive { get; set; } 
        public IRPSComboBox<CuDistCreateTimePostingPopUpDialogView> IDUnproductiveType { get; set; } 
        public IRPSComboBox<CuDistCreateTimePostingPopUpDialogView> IDHourType { get; set; } 
        public IRPSTextBox<CuDistCreateTimePostingPopUpDialogView> Description { get; set; } 
        public IRPSButton<CuDistCreateTimePostingPopUpDialogView> CreateNewImputationCommand { get; set; } 
        public IRPSButton<CuDistCreateTimePostingPopUpDialogView> CloseCommand { get; set; } 
        public Warning Screen { get; set; }
        public CuDistCreateTimePostingPopUpDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}