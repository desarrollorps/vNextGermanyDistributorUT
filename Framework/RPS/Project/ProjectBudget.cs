    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.ProjectBudget
{
    //RPS VERSION 1.0.0.0
    public partial class ProjectBudget:Screen
    {
        public ProjectBudget():base()
        {
            this.URL = "project.projectbudget";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ProjectBudgetView  = new ProjectBudgetView(this); 
            ProjectView  = new ProjectView(this); 
            ProjectTaskDialogView  = new ProjectTaskDialogView(this); 
            ImportTaskDialogView  = new ImportTaskDialogView(this); 
            ProjectBudgetView.InitializeControls(); 
            ProjectView.InitializeControls(); 
            ProjectTaskDialogView.InitializeControls(); 
            ImportTaskDialogView.InitializeControls(); 
           
        }
      
            public ProjectBudgetView ProjectBudgetView {get; set; } 
            public ProjectView ProjectView {get; set; } 
            public ProjectTaskDialogView ProjectTaskDialogView {get; set; } 
            public ImportTaskDialogView ImportTaskDialogView {get; set; } 
    }
            
    public partial class ProjectBudgetView : View
    {
        public ProjectBudgetView(ProjectBudget screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDProject = RPSControlFactory.CreateRPSComboBox<ProjectBudgetView>("123f18e3-5444-4b17-9a8b-c3ed0dd293d8","","",false, this);
 
            ShowEmptyRows = RPSControlFactory.CreateRPSCheckBox<ProjectBudgetView>("0f4a3926-8d52-4821-8a66-16cd60ed1879","","",false, this);
 
            ShowEmptyColumns = RPSControlFactory.CreateRPSCheckBox<ProjectBudgetView>("d80b1d1d-1f0c-4f25-9546-631dcd757777","","",false, this);
 
            ShowCategoryHigherLevels = RPSControlFactory.CreateRPSCheckBox<ProjectBudgetView>("1712ac41-f9e3-4061-bce1-f44116f352df","","",false, this);
 

        }
        public IRPSComboBox<ProjectBudgetView> IDProject { get; set; } 
        public IRPSCheckbox<ProjectBudgetView> ShowEmptyRows { get; set; } 
        public IRPSCheckbox<ProjectBudgetView> ShowEmptyColumns { get; set; } 
        public IRPSCheckbox<ProjectBudgetView> ShowCategoryHigherLevels { get; set; } 
        public ProjectBudget Screen { get; set; }
        public ProjectBudgetView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ProjectView : View
    {
        public ProjectView(ProjectBudget screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ProjectView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ProjectView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ProjectView,ProjectBudgetView>( this,Screen.ProjectBudgetView);
 
            BackButton = RPSControlFactory.RPSBackButton<ProjectView,ProjectBudgetView>( this,Screen.ProjectBudgetView);
 
            ShowEmptyRows = RPSControlFactory.CreateRPSCheckBox<ProjectView>("208acd7e-739f-4c2c-9401-4640af683601","","",false, this);
 
            ShowEmptyColumns = RPSControlFactory.CreateRPSCheckBox<ProjectView>("8529417b-aed7-4f6e-bd5b-6ad2c49b4ac3","","",false, this);
 
            ShowCategoryHigherLevels = RPSControlFactory.CreateRPSCheckBox<ProjectView>("1bd7bde8-d2e8-4ce8-a283-6003f23a02e5","","",false, this);
 
            EditCommand = RPSControlFactory.CreateRPSButton<ProjectView>( "81bb088c-bc9a-48fb-9004-0d035bbb8d3f","","",this);
 
            RefreshCommand = RPSControlFactory.CreateRPSButton<ProjectView>( "66496bed-dc7e-4aca-a3a0-780e6425d0b9","","",this);
 
            ImportTaskNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ProjectView,ImportTaskDialogView>("90c02aec-190c-4ba9-b0e9-174b74a3a45b","","", this,Screen.ImportTaskDialogView);
 

        }
        public IRPSSaveButton<ProjectView> SaveButton { get; set; } 
        public IRPSButton<ProjectView> DeleteButton { get; set; } 
        public IRPSButton<ProjectView,ProjectBudgetView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ProjectView,ProjectBudgetView> BackButton { get; set; } 
        public IRPSCheckbox<ProjectView> ShowEmptyRows { get; set; } 
        public IRPSCheckbox<ProjectView> ShowEmptyColumns { get; set; } 
        public IRPSCheckbox<ProjectView> ShowCategoryHigherLevels { get; set; } 
        public IRPSButton<ProjectView> EditCommand { get; set; } 
        public IRPSButton<ProjectView> RefreshCommand { get; set; } 
        public IRPSButton<ProjectView,ImportTaskDialogView> ImportTaskNavigationCommandButton { get; set; } 
        public ProjectBudget Screen { get; set; }
        public ProjectView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ProjectTaskDialogView : View
    {
        public ProjectTaskDialogView(ProjectBudget screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            ManualBudgetAmount = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskDialogView>("12ad22e5-3c2a-429f-be54-5348814e8a1a","","",false, this);
 
            ResourcesBudgetAmount = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskDialogView>("f4a45451-d455-40c6-8aff-7756777c1a4a","","",false, this);
 
            MaterialsBudgetAmount = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskDialogView>("5fd5fba7-817d-40b8-bf9e-4332825b432f","","",false, this);
 
            CostComponentsBudgetAmount = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskDialogView>("8771e6b7-e1d6-4d01-99a8-d9cddee24a29","","",false, this);
 
            TotalBudgetAmount = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskDialogView>("8829c997-b9b9-4ed3-9274-0a6aaa5142da","","",false, this);
 
            TotalAmountBudgetCategories = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskDialogView>("d1b32a4e-583c-47ad-8849-bf1b79157e23","","",false, this);
 
            TotalAmountBudgetResources = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskDialogView>("94a0652c-fa80-4495-9f4d-7f3a1f2b3f76","","",false, this);
 
            IDArticleExternal = RPSControlFactory.CreateRPSComboBox<ProjectTaskDialogView>("fbbe0a53-d4b5-45ab-b136-d4c68cc2addb","","",false, this);
 
            IDBudgetCategory = RPSControlFactory.CreateRPSComboBox<ProjectTaskDialogView>("481b24e1-722c-43ee-bb31-29431beece19","","",false, this);
 
            BudgetQuantity = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskDialogView>("c5ffff42-fab1-4a16-a3db-ffcdaeb5c080","","",true, this);
 
            BudgetPrice = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskDialogView>("a479630d-286e-4218-a0d2-dc86271d5eee","","",true, this);
 
            BudgetAmount = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskDialogView>("e7ff9e7f-89a1-4f22-a885-6fe1c8d7ad18","","",true, this);
 
            TotalAmountBudgetMaterials = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskDialogView>("c6b8595e-1843-47dd-80ce-a72317664dab","","",false, this);
 
            TotalAmountBudgetCostComponents = RPSControlFactory.CreateRPSFormattedTextBox<ProjectTaskDialogView>("55000984-8e94-4bd0-8071-80932a2e45bd","","",false, this);
 
            CollectionInit params_ProjectTaskCategorys = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="260c3abe-b547-499b-9652-40d997a3ef53",CSSSelectorGrid="",XPathGrid=""};
            ProjectTaskCategorys = RPSControlFactory.RPSCreateCollectionWithGrid<ProjectTaskCategorysCollectionEditor<ProjectTaskDialogView>,ProjectTaskDialogView>( params_ProjectTaskCategorys,this);
 
            CollectionInit params_ProjectTaskResources = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="8f59eeef-18a6-49fa-bfdf-eaa0e60c2ade",CSSSelectorGrid="",XPathGrid=""};
            ProjectTaskResources = RPSControlFactory.RPSCreateCollectionWithGrid<ProjectTaskResourcesCollectionEditor<ProjectTaskDialogView>,ProjectTaskDialogView>( params_ProjectTaskResources,this);
 
            CollectionInit params_PROProjectMaterials = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="a7c6a3a0-bf7d-48a5-853f-4cb880a8a046",CSSSelectorGrid="",XPathGrid=""};
            PROProjectMaterials = RPSControlFactory.RPSCreateCollectionWithGrid<PROProjectMaterialsCollectionEditor<ProjectTaskDialogView>,ProjectTaskDialogView>( params_PROProjectMaterials,this);
 
            CollectionInit params_ProjectTaskCostComponents = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="075c231f-9a3e-4bbc-af17-5e1fc1142060",CSSSelectorGrid="",XPathGrid=""};
            ProjectTaskCostComponents = RPSControlFactory.RPSCreateCollectionWithGrid<ProjectTaskCostComponentsCollectionEditor<ProjectTaskDialogView>,ProjectTaskDialogView>( params_ProjectTaskCostComponents,this);
 
            GeneralData = RPSControlFactory.CreateRPSSection<ProjectTaskDialogView>( "","ul li[rpsid='4ae3a67e-7748-41f5-95ea-a161d5068f11']","",this);
 
            ProjectTaskCategories = RPSControlFactory.CreateRPSSection<ProjectTaskDialogView>( "","ul li[rpsid='31c8a70c-c885-466c-a35e-c09baa418463']","",this);
 
            Resources = RPSControlFactory.CreateRPSSection<ProjectTaskDialogView>( "","ul li[rpsid='62949972-4e35-4da5-80db-6d5e92c9f271']","",this);
 
            Materials = RPSControlFactory.CreateRPSSection<ProjectTaskDialogView>( "","ul li[rpsid='1c170602-6284-440f-a1a6-6711cf2f7fe7']","",this);
 
            CostComponents = RPSControlFactory.CreateRPSSection<ProjectTaskDialogView>( "","ul li[rpsid='bc54c7b0-de65-4d73-bb2d-ae9b93813c9a']","",this);
 

        }
        public IRPSTextBox<ProjectTaskDialogView> ManualBudgetAmount { get; set; } 
        public IRPSTextBox<ProjectTaskDialogView> ResourcesBudgetAmount { get; set; } 
        public IRPSTextBox<ProjectTaskDialogView> MaterialsBudgetAmount { get; set; } 
        public IRPSTextBox<ProjectTaskDialogView> CostComponentsBudgetAmount { get; set; } 
        public IRPSTextBox<ProjectTaskDialogView> TotalBudgetAmount { get; set; } 
        public IRPSTextBox<ProjectTaskDialogView> TotalAmountBudgetCategories { get; set; } 
        public IRPSTextBox<ProjectTaskDialogView> TotalAmountBudgetResources { get; set; } 
        public IRPSComboBox<ProjectTaskDialogView> IDArticleExternal { get; set; } 
        public IRPSComboBox<ProjectTaskDialogView> IDBudgetCategory { get; set; } 
        public IRPSTextBox<ProjectTaskDialogView> BudgetQuantity { get; set; } 
        public IRPSTextBox<ProjectTaskDialogView> BudgetPrice { get; set; } 
        public IRPSTextBox<ProjectTaskDialogView> BudgetAmount { get; set; } 
        public IRPSTextBox<ProjectTaskDialogView> TotalAmountBudgetMaterials { get; set; } 
        public IRPSTextBox<ProjectTaskDialogView> TotalAmountBudgetCostComponents { get; set; } 
        public ProjectTaskCategorysCollectionEditor<ProjectTaskDialogView> ProjectTaskCategorys { get; set; } 
        public ProjectTaskResourcesCollectionEditor<ProjectTaskDialogView> ProjectTaskResources { get; set; } 
        public PROProjectMaterialsCollectionEditor<ProjectTaskDialogView> PROProjectMaterials { get; set; } 
        public ProjectTaskCostComponentsCollectionEditor<ProjectTaskDialogView> ProjectTaskCostComponents { get; set; } 
        public IRPSSection<ProjectTaskDialogView> GeneralData { get; set; } 
        public IRPSSection<ProjectTaskDialogView> ProjectTaskCategories { get; set; } 
        public IRPSSection<ProjectTaskDialogView> Resources { get; set; } 
        public IRPSSection<ProjectTaskDialogView> Materials { get; set; } 
        public IRPSSection<ProjectTaskDialogView> CostComponents { get; set; } 
        public ProjectBudget Screen { get; set; }
        public ProjectTaskDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ProjectTaskCategorysCollectionEditor<ProjectTaskDialogView>:RPSCollectionEditor<ProjectTaskDialogView> where ProjectTaskDialogView : class, IView
    {
        public  ProjectTaskCategorysGridView<ProjectTaskDialogView> GridView {get;set;}
    }
    public partial class ProjectTaskCategorysGridView <ProjectTaskDialogView> :  RPSGridView<ProjectTaskDialogView> where ProjectTaskDialogView : class, IView
    {
        public ProjectTaskCategorysGridView(ProjectTaskDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDBudgetCategory = RPSControlFactory.CreateRPSGridComboBox<ProjectTaskDialogView>("","#260c3abe-b547-499b-9652-40d997a3ef53 .ag-row[role='row']@ROWINDEX [col-id='cIDBudgetCategory']","",true, this.CurrentView);
 
            BudgetAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectTaskDialogView>("","#260c3abe-b547-499b-9652-40d997a3ef53 .ag-row[role='row']@ROWINDEX [col-id='cBudgetAmount']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<ProjectTaskDialogView> IDBudgetCategory { get; set; } 
        public IRPSGridTextBox<ProjectTaskDialogView> BudgetAmount { get; set; } 
                     
    }
 
        public partial class ProjectTaskResourcesCollectionEditor<ProjectTaskDialogView>:RPSCollectionEditor<ProjectTaskDialogView> where ProjectTaskDialogView : class, IView
    {
        public  ProjectTaskResourcesGridView<ProjectTaskDialogView> GridView {get;set;}
    }
    public partial class ProjectTaskResourcesGridView <ProjectTaskDialogView> :  RPSGridView<ProjectTaskDialogView> where ProjectTaskDialogView : class, IView
    {
        public ProjectTaskResourcesGridView(ProjectTaskDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ResourceType = RPSControlFactory.CreateRPSGridEnumComboBox<ProjectTaskDialogView>("","#8f59eeef-18a6-49fa-bfdf-eaa0e60c2ade .ag-row[role='row']@ROWINDEX [col-id='cResourceType']","",false, this.CurrentView);
 
            IDResource = RPSControlFactory.CreateRPSGridComboBox<ProjectTaskDialogView>("","#8f59eeef-18a6-49fa-bfdf-eaa0e60c2ade .ag-row[role='row']@ROWINDEX [col-id='cIDResource']","",false, this.CurrentView);
 
            IDResourceGroup = RPSControlFactory.CreateRPSGridComboBox<ProjectTaskDialogView>("","#8f59eeef-18a6-49fa-bfdf-eaa0e60c2ade .ag-row[role='row']@ROWINDEX [col-id='cIDResourceGroup']","",false, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ProjectTaskDialogView>("","#8f59eeef-18a6-49fa-bfdf-eaa0e60c2ade .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            IDBudgetCategory = RPSControlFactory.CreateRPSGridComboBox<ProjectTaskDialogView>("","#8f59eeef-18a6-49fa-bfdf-eaa0e60c2ade .ag-row[role='row']@ROWINDEX [col-id='cIDBudgetCategory']","",false, this.CurrentView);
 
            BudgetQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectTaskDialogView>("","#8f59eeef-18a6-49fa-bfdf-eaa0e60c2ade .ag-row[role='row']@ROWINDEX [col-id='cBudgetQuantity']","",true, this.CurrentView);
 
            BudgetPrice = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectTaskDialogView>("","#8f59eeef-18a6-49fa-bfdf-eaa0e60c2ade .ag-row[role='row']@ROWINDEX [col-id='cBudgetPrice']","",true, this.CurrentView);
 
            BudgetAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectTaskDialogView>("","#8f59eeef-18a6-49fa-bfdf-eaa0e60c2ade .ag-row[role='row']@ROWINDEX [col-id='cBudgetAmount']","",true, this.CurrentView);
 
            CodResource = RPSControlFactory.CreateRPSGridTextBox<ProjectTaskDialogView>("","#8f59eeef-18a6-49fa-bfdf-eaa0e60c2ade .ag-row[role='row']@ROWINDEX [col-id='cCodResource']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<ProjectTaskDialogView> ResourceType { get; set; } 
        public IRPSGridComboBox<ProjectTaskDialogView> IDResource { get; set; } 
        public IRPSGridComboBox<ProjectTaskDialogView> IDResourceGroup { get; set; } 
        public IRPSGridTextBox<ProjectTaskDialogView> Description { get; set; } 
        public IRPSGridComboBox<ProjectTaskDialogView> IDBudgetCategory { get; set; } 
        public IRPSGridTextBox<ProjectTaskDialogView> BudgetQuantity { get; set; } 
        public IRPSGridTextBox<ProjectTaskDialogView> BudgetPrice { get; set; } 
        public IRPSGridTextBox<ProjectTaskDialogView> BudgetAmount { get; set; } 
        public IRPSGridTextBox<ProjectTaskDialogView> CodResource { get; set; } 
                     
    }
 
        public partial class PROProjectMaterialsCollectionEditor<ProjectTaskDialogView>:RPSCollectionEditor<ProjectTaskDialogView> where ProjectTaskDialogView : class, IView
    {
        public  PROProjectMaterialsGridView<ProjectTaskDialogView> GridView {get;set;}
    }
    public partial class PROProjectMaterialsGridView <ProjectTaskDialogView> :  RPSGridView<ProjectTaskDialogView> where ProjectTaskDialogView : class, IView
    {
        public PROProjectMaterialsGridView(ProjectTaskDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<ProjectTaskDialogView>("","#a7c6a3a0-bf7d-48a5-853f-4cb880a8a046 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ProjectTaskDialogView>("","#a7c6a3a0-bf7d-48a5-853f-4cb880a8a046 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            IDBudgetCategory = RPSControlFactory.CreateRPSGridComboBox<ProjectTaskDialogView>("","#a7c6a3a0-bf7d-48a5-853f-4cb880a8a046 .ag-row[role='row']@ROWINDEX [col-id='cIDBudgetCategory']","",false, this.CurrentView);
 
            BudgetQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectTaskDialogView>("","#a7c6a3a0-bf7d-48a5-853f-4cb880a8a046 .ag-row[role='row']@ROWINDEX [col-id='cBudgetQuantity']","",true, this.CurrentView);
 
            BudgetPrice = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectTaskDialogView>("","#a7c6a3a0-bf7d-48a5-853f-4cb880a8a046 .ag-row[role='row']@ROWINDEX [col-id='cBudgetPrice']","",true, this.CurrentView);
 
            BudgetAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectTaskDialogView>("","#a7c6a3a0-bf7d-48a5-853f-4cb880a8a046 .ag-row[role='row']@ROWINDEX [col-id='cBudgetAmount']","",true, this.CurrentView);
 
            CodMaterial = RPSControlFactory.CreateRPSGridTextBox<ProjectTaskDialogView>("","#a7c6a3a0-bf7d-48a5-853f-4cb880a8a046 .ag-row[role='row']@ROWINDEX [col-id='cCodMaterial']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<ProjectTaskDialogView> IDArticle { get; set; } 
        public IRPSGridTextBox<ProjectTaskDialogView> Description { get; set; } 
        public IRPSGridComboBox<ProjectTaskDialogView> IDBudgetCategory { get; set; } 
        public IRPSGridTextBox<ProjectTaskDialogView> BudgetQuantity { get; set; } 
        public IRPSGridTextBox<ProjectTaskDialogView> BudgetPrice { get; set; } 
        public IRPSGridTextBox<ProjectTaskDialogView> BudgetAmount { get; set; } 
        public IRPSGridTextBox<ProjectTaskDialogView> CodMaterial { get; set; } 
                     
    }
 
        public partial class ProjectTaskCostComponentsCollectionEditor<ProjectTaskDialogView>:RPSCollectionEditor<ProjectTaskDialogView> where ProjectTaskDialogView : class, IView
    {
        public  ProjectTaskCostComponentsGridView<ProjectTaskDialogView> GridView {get;set;}
    }
    public partial class ProjectTaskCostComponentsGridView <ProjectTaskDialogView> :  RPSGridView<ProjectTaskDialogView> where ProjectTaskDialogView : class, IView
    {
        public ProjectTaskCostComponentsGridView(ProjectTaskDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            IDCostComponent = RPSControlFactory.CreateRPSGridComboBox<ProjectTaskDialogView>("","#075c231f-9a3e-4bbc-af17-5e1fc1142060 .ag-row[role='row']@ROWINDEX [col-id='cIDCostComponent']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ProjectTaskDialogView>("","#075c231f-9a3e-4bbc-af17-5e1fc1142060 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            IDBudgetCategory = RPSControlFactory.CreateRPSGridComboBox<ProjectTaskDialogView>("","#075c231f-9a3e-4bbc-af17-5e1fc1142060 .ag-row[role='row']@ROWINDEX [col-id='cIDBudgetCategory']","",false, this.CurrentView);
 
            BudgetQuantity = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectTaskDialogView>("","#075c231f-9a3e-4bbc-af17-5e1fc1142060 .ag-row[role='row']@ROWINDEX [col-id='cBudgetQuantity']","",true, this.CurrentView);
 
            BudgetPrice = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectTaskDialogView>("","#075c231f-9a3e-4bbc-af17-5e1fc1142060 .ag-row[role='row']@ROWINDEX [col-id='cBudgetPrice']","",true, this.CurrentView);
 
            BudgetAmount = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectTaskDialogView>("","#075c231f-9a3e-4bbc-af17-5e1fc1142060 .ag-row[role='row']@ROWINDEX [col-id='cBudgetAmount']","",true, this.CurrentView);
 
            CodCostComponent = RPSControlFactory.CreateRPSGridTextBox<ProjectTaskDialogView>("","#075c231f-9a3e-4bbc-af17-5e1fc1142060 .ag-row[role='row']@ROWINDEX [col-id='cCodCostComponent']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<ProjectTaskDialogView> IDCostComponent { get; set; } 
        public IRPSGridTextBox<ProjectTaskDialogView> Description { get; set; } 
        public IRPSGridComboBox<ProjectTaskDialogView> IDBudgetCategory { get; set; } 
        public IRPSGridTextBox<ProjectTaskDialogView> BudgetQuantity { get; set; } 
        public IRPSGridTextBox<ProjectTaskDialogView> BudgetPrice { get; set; } 
        public IRPSGridTextBox<ProjectTaskDialogView> BudgetAmount { get; set; } 
        public IRPSGridTextBox<ProjectTaskDialogView> CodCostComponent { get; set; } 
                     
    }
 
    }
  
            
    public partial class ImportTaskDialogView : View
    {
        public ImportTaskDialogView(ProjectBudget screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDProjectSource = RPSControlFactory.CreateRPSComboBox<ImportTaskDialogView>("e515d2af-6cd4-4b31-b984-2b0d037f2c0f","","",false, this);
 
            IDProjectTaskSource = RPSControlFactory.CreateRPSComboBox<ImportTaskDialogView>("aa3a0a8f-b6a0-4a5c-a377-f27b9df21112","","",false, this);
 
            OptionForward = RPSControlFactory.CreateRPSOption<ImportTaskDialogView>( "7a1d9312-c7b9-4b0e-a413-1e29b39403b1","","",this);
 
            OptionAdjustToEnd = RPSControlFactory.CreateRPSOption<ImportTaskDialogView>( "19df8bdd-a15a-48aa-b1b4-7c0f4e571057","","",this);
 
            PlannedDate = RPSControlFactory.CreateRPSTextBox<ImportTaskDialogView>("0e330493-0a58-416a-bbd5-a3b703d5e522","","",false, this);
 
            DuplicateTest = RPSControlFactory.CreateRPSCheckBox<ImportTaskDialogView>("cfd670cb-394d-49a8-b50b-3b4b9e66bb0f","","",false, this);
 
            DuplicateDocuments = RPSControlFactory.CreateRPSCheckBox<ImportTaskDialogView>("69a9852a-2db4-4fb7-8fbe-c8f3dfc48ef5","","",false, this);
 
            DuplicateResources = RPSControlFactory.CreateRPSCheckBox<ImportTaskDialogView>("2065c905-96c2-4ad7-8f24-befe5bd5c88e","","",false, this);
 
            ResourceAssignTimeReal = RPSControlFactory.CreateRPSCheckBox<ImportTaskDialogView>("a9d008a7-110a-4845-9ed2-f439d45d6c1b","","",false, this);
 
            TheoricCostRes = RPSControlFactory.CreateRPSEnumComboBox<ImportTaskDialogView>("895966a1-bd39-476f-ba2e-7893360a46c1","","",false, this);
 
            SalesCostRes = RPSControlFactory.CreateRPSEnumComboBox<ImportTaskDialogView>("b40b0ac8-5c72-42c7-ad1e-5a26c30a9ca3","","",false, this);
 
            BudgetRes = RPSControlFactory.CreateRPSEnumComboBox<ImportTaskDialogView>("3176a340-d584-43f8-ba69-8597f1ff5ab8","","",false, this);
 
            GroupBudgetRes = RPSControlFactory.CreateRPSEnumComboBox<ImportTaskDialogView>("75e6f761-ec54-4863-ba08-0ad3ba0dc1fe","","",false, this);
 
            DuplicateMaterials = RPSControlFactory.CreateRPSCheckBox<ImportTaskDialogView>("7f1dc751-aec2-4bc1-91fd-9a0e3c72c319","","",false, this);
 
            MaterialAssignMaterialQuantityReal = RPSControlFactory.CreateRPSCheckBox<ImportTaskDialogView>("2681411c-9d37-4fb7-8edd-327a9c0094ee","","",false, this);
 
            TheoricCostMats = RPSControlFactory.CreateRPSEnumComboBox<ImportTaskDialogView>("8cb3c0b6-1ac0-4d01-a7d5-f460bcbd1b99","","",false, this);
 
            SalesCostMats = RPSControlFactory.CreateRPSEnumComboBox<ImportTaskDialogView>("792c0bd3-2c24-4723-8991-d857d4a6a0b3","","",false, this);
 
            BudgetMats = RPSControlFactory.CreateRPSEnumComboBox<ImportTaskDialogView>("36f22117-e5b1-474d-bfc3-7a706ee8f222","","",false, this);
 
            GroupBudgetMats = RPSControlFactory.CreateRPSEnumComboBox<ImportTaskDialogView>("6bc413e6-17cf-4525-b4c6-ab1063d81060","","",false, this);
 
            DuplicateComponentsCost = RPSControlFactory.CreateRPSCheckBox<ImportTaskDialogView>("d9401d0c-b0ac-40c9-8234-55ad44c38802","","",false, this);
 
            ComponentCostAssignCostQuantityReal = RPSControlFactory.CreateRPSCheckBox<ImportTaskDialogView>("dbfb2ae3-c51d-4d2d-9a7b-ba568ffdfc86","","",false, this);
 
            TheoricCostCompCost = RPSControlFactory.CreateRPSEnumComboBox<ImportTaskDialogView>("983b6c8d-22a4-45dd-a009-24ef4071a2fd","","",false, this);
 
            SalesCostCompCost = RPSControlFactory.CreateRPSEnumComboBox<ImportTaskDialogView>("4e545df9-2f10-4345-b7f0-e55a219adca5","","",false, this);
 
            BudgetCompCost = RPSControlFactory.CreateRPSEnumComboBox<ImportTaskDialogView>("8cd35c1d-e83e-4b74-af53-6987239d89a1","","",false, this);
 
            GroupBudgetCompCost = RPSControlFactory.CreateRPSEnumComboBox<ImportTaskDialogView>("27bc3967-f8f3-47d1-add5-983329564350","","",false, this);
 

        }
        public IRPSComboBox<ImportTaskDialogView> IDProjectSource { get; set; } 
        public IRPSComboBox<ImportTaskDialogView> IDProjectTaskSource { get; set; } 
        public IRPSOption<ImportTaskDialogView> OptionForward { get; set; } 
        public IRPSOption<ImportTaskDialogView> OptionAdjustToEnd { get; set; } 
        public IRPSTextBox<ImportTaskDialogView> PlannedDate { get; set; } 
        public IRPSCheckbox<ImportTaskDialogView> DuplicateTest { get; set; } 
        public IRPSCheckbox<ImportTaskDialogView> DuplicateDocuments { get; set; } 
        public IRPSCheckbox<ImportTaskDialogView> DuplicateResources { get; set; } 
        public IRPSCheckbox<ImportTaskDialogView> ResourceAssignTimeReal { get; set; } 
        public IRPSComboBox<ImportTaskDialogView> TheoricCostRes { get; set; } 
        public IRPSComboBox<ImportTaskDialogView> SalesCostRes { get; set; } 
        public IRPSComboBox<ImportTaskDialogView> BudgetRes { get; set; } 
        public IRPSComboBox<ImportTaskDialogView> GroupBudgetRes { get; set; } 
        public IRPSCheckbox<ImportTaskDialogView> DuplicateMaterials { get; set; } 
        public IRPSCheckbox<ImportTaskDialogView> MaterialAssignMaterialQuantityReal { get; set; } 
        public IRPSComboBox<ImportTaskDialogView> TheoricCostMats { get; set; } 
        public IRPSComboBox<ImportTaskDialogView> SalesCostMats { get; set; } 
        public IRPSComboBox<ImportTaskDialogView> BudgetMats { get; set; } 
        public IRPSComboBox<ImportTaskDialogView> GroupBudgetMats { get; set; } 
        public IRPSCheckbox<ImportTaskDialogView> DuplicateComponentsCost { get; set; } 
        public IRPSCheckbox<ImportTaskDialogView> ComponentCostAssignCostQuantityReal { get; set; } 
        public IRPSComboBox<ImportTaskDialogView> TheoricCostCompCost { get; set; } 
        public IRPSComboBox<ImportTaskDialogView> SalesCostCompCost { get; set; } 
        public IRPSComboBox<ImportTaskDialogView> BudgetCompCost { get; set; } 
        public IRPSComboBox<ImportTaskDialogView> GroupBudgetCompCost { get; set; } 
        public ProjectBudget Screen { get; set; }
        public ImportTaskDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}