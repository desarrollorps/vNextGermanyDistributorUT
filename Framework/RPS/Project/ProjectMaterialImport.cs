    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.ProjectMaterialImport
{
    //RPS VERSION 1.0.0.0
    public partial class ProjectMaterialImport:Screen
    {
        public ProjectMaterialImport():base()
        {
            this.URL = "project.projectmaterialimport";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ProjectMaterialImportView  = new ProjectMaterialImportView(this); 
            ProjectTaskView  = new ProjectTaskView(this); 
            ProjectMaterialView  = new ProjectMaterialView(this); 
            ImportMaterialsDialogView  = new ImportMaterialsDialogView(this); 
            FileUploadChildDialogView  = new FileUploadChildDialogView(this); 
            CreateArticlesDialogView  = new CreateArticlesDialogView(this); 
            ProjectMaterialImportView.InitializeControls(); 
            ProjectTaskView.InitializeControls(); 
            ProjectMaterialView.InitializeControls(); 
            ImportMaterialsDialogView.InitializeControls(); 
            FileUploadChildDialogView.InitializeControls(); 
            CreateArticlesDialogView.InitializeControls(); 
           
        }
      
            public ProjectMaterialImportView ProjectMaterialImportView {get; set; } 
            public ProjectTaskView ProjectTaskView {get; set; } 
            public ProjectMaterialView ProjectMaterialView {get; set; } 
            public ImportMaterialsDialogView ImportMaterialsDialogView {get; set; } 
            public FileUploadChildDialogView FileUploadChildDialogView {get; set; } 
            public CreateArticlesDialogView CreateArticlesDialogView {get; set; } 
    }
            
    public partial class ProjectMaterialImportView : View
    {
        public ProjectMaterialImportView(ProjectMaterialImport screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Project = RPSControlFactory.CreateRPSComboBox<ProjectMaterialImportView>("00bc8165-f0e0-4a6c-b93d-d2e7fcd33c83","","",true, this);
 
            ProjectTask = RPSControlFactory.CreateRPSComboBox<ProjectMaterialImportView>("213d8f7a-999b-4e69-88f4-3435bbf8a411","","",true, this);
 
            ProjectTaskNavigationCommand = RPSControlFactory.CreateRPSButtonToView<ProjectMaterialImportView,ProjectTaskView>("a64f867f-0edc-49e4-a76b-8d42c2d43bf4","","", this,Screen.ProjectTaskView);
 

        }
        public IRPSComboBox<ProjectMaterialImportView> Project { get; set; } 
        public IRPSComboBox<ProjectMaterialImportView> ProjectTask { get; set; } 
        public IRPSButton<ProjectMaterialImportView,ProjectTaskView> ProjectTaskNavigationCommand { get; set; } 
        public ProjectMaterialImport Screen { get; set; }
        public ProjectMaterialImportView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ProjectTaskView : View
    {
        public ProjectTaskView(ProjectMaterialImport screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<ProjectTaskView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<ProjectTaskView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ProjectTaskView,ProjectMaterialImportView>( this,Screen.ProjectMaterialImportView);
 
            BackButton = RPSControlFactory.RPSBackButton<ProjectTaskView,ProjectMaterialImportView>( this,Screen.ProjectMaterialImportView);
 
            ImportMaterialsNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ProjectTaskView,ImportMaterialsDialogView>("dba7821e-35ad-4a09-ab0a-b54f7527ac7f","","", this,Screen.ImportMaterialsDialogView);
 
            CollectionInit params_PROProjectMaterials = new CollectionInit(){IDDescriptor = "3ee640b4-a464-4e76-abf7-8aba7c0df670",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="b1673693-b9c2-45f9-b850-918f8ed91382",CSSSelectorGrid="",XPathGrid=""};
            PROProjectMaterials = RPSControlFactory.RPSCreateCollectionWithGrid<PROProjectMaterialsCollectionEditor<ProjectTaskView,ProjectMaterialView>,ProjectTaskView,ProjectMaterialView>( params_PROProjectMaterials,this,Screen.ProjectMaterialView);
 

        }
        public IRPSSaveButton<ProjectTaskView> SaveButton { get; set; } 
        public IRPSButton<ProjectTaskView> DeleteButton { get; set; } 
        public IRPSButton<ProjectTaskView,ProjectMaterialImportView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ProjectTaskView,ProjectMaterialImportView> BackButton { get; set; } 
        public IRPSButton<ProjectTaskView,ImportMaterialsDialogView> ImportMaterialsNavigationCommandButton { get; set; } 
        public PROProjectMaterialsCollectionEditor<ProjectTaskView,ProjectMaterialView> PROProjectMaterials { get; set; } 
        public ProjectMaterialImport Screen { get; set; }
        public ProjectTaskView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class PROProjectMaterialsCollectionEditor<ProjectTaskView,ProjectMaterialView>:RPSCollectionEditor<ProjectTaskView,ProjectMaterialView> where ProjectTaskView : class, IView where ProjectMaterialView : class, IView
    {
        public  PROProjectMaterialsGridView<ProjectTaskView,ProjectMaterialView> GridView {get;set;}
    }
    public partial class PROProjectMaterialsGridView <ProjectTaskView,ProjectMaterialView> :  RPSGridView<ProjectTaskView,ProjectMaterialView> where ProjectTaskView : class, IView where ProjectMaterialView : class, IView
    {
        public PROProjectMaterialsGridView(ProjectTaskView currentView,ProjectMaterialView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CodMaterial = RPSControlFactory.CreateRPSGridTextBox<ProjectTaskView>("","#b1673693-b9c2-45f9-b850-918f8ed91382 .ag-row[role='row']@ROWINDEX [col-id='cCodMaterial']","",true, this.CurrentView);
 
            Description = RPSControlFactory.CreateRPSGridTextBox<ProjectTaskView>("","#b1673693-b9c2-45f9-b850-918f8ed91382 .ag-row[role='row']@ROWINDEX [col-id='cDescription']","",false, this.CurrentView);
 
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<ProjectTaskView>("","#b1673693-b9c2-45f9-b850-918f8ed91382 .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 
            IDArticleParent = RPSControlFactory.CreateRPSGridComboBox<ProjectTaskView>("","#b1673693-b9c2-45f9-b850-918f8ed91382 .ag-row[role='row']@ROWINDEX [col-id='cIDArticleParent']","",false, this.CurrentView);
 
            Quantity = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectTaskView>("","#b1673693-b9c2-45f9-b850-918f8ed91382 .ag-row[role='row']@ROWINDEX [col-id='cQuantity']","",true, this.CurrentView);
 
            PriceCostTheoric = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectTaskView>("","#b1673693-b9c2-45f9-b850-918f8ed91382 .ag-row[role='row']@ROWINDEX [col-id='cPriceCostTheoric']","",true, this.CurrentView);
 
            BudgetPrice = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectTaskView>("","#b1673693-b9c2-45f9-b850-918f8ed91382 .ag-row[role='row']@ROWINDEX [col-id='cBudgetPrice']","",true, this.CurrentView);
 
            PriceSaleTheoric = RPSControlFactory.CreateRPSGridFormattedTextBox<ProjectTaskView>("","#b1673693-b9c2-45f9-b850-918f8ed91382 .ag-row[role='row']@ROWINDEX [col-id='cPriceSaleTheoric']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<ProjectTaskView> CodMaterial { get; set; } 
        public IRPSGridTextBox<ProjectTaskView> Description { get; set; } 
        public IRPSGridComboBox<ProjectTaskView> IDArticle { get; set; } 
        public IRPSGridComboBox<ProjectTaskView> IDArticleParent { get; set; } 
        public IRPSGridTextBox<ProjectTaskView> Quantity { get; set; } 
        public IRPSGridTextBox<ProjectTaskView> PriceCostTheoric { get; set; } 
        public IRPSGridTextBox<ProjectTaskView> BudgetPrice { get; set; } 
        public IRPSGridTextBox<ProjectTaskView> PriceSaleTheoric { get; set; } 
                     
    }
 
    }
  
            
    public partial class ProjectMaterialView : View
    {
        public ProjectMaterialView(ProjectMaterialImport screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<ProjectMaterialView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<ProjectMaterialView,ProjectTaskView>( this,Screen.ProjectTaskView);
 
            BackButton = RPSControlFactory.RPSBackButton<ProjectMaterialView,ProjectTaskView>( this,Screen.ProjectTaskView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<ProjectMaterialView,ProjectTaskView>( this,Screen.ProjectTaskView);
 
            CodMaterial = RPSControlFactory.CreateRPSTextBox<ProjectMaterialView>("966dfb33-9902-43aa-a2a1-93c4e7a32190","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<ProjectMaterialView>("7669eae5-ed18-4a5d-8a98-f658bca6be10","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<ProjectMaterialView>("31d67f13-ebaa-4d2b-b95c-5d5548c0b9ae","","",true, this);
 
            IDArticleParent = RPSControlFactory.CreateRPSComboBox<ProjectMaterialView>("9a296470-2ee5-417e-ab9b-018a3ad12b48","","",false, this);
 
            SupplySituation = RPSControlFactory.CreateRPSEnumComboBox<ProjectMaterialView>("3cea5fdc-698d-4fee-99b3-4e6e2d9f46f6","","",true, this);
 
            Status = RPSControlFactory.CreateRPSEnumComboBox<ProjectMaterialView>("fc0d02cd-9c85-4930-b0e6-d2b4ed725bb0","","",true, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<ProjectMaterialView>("8f347419-ca21-48db-bc04-bd888a893281","","",true, this);
 
            QuantityElements = RPSControlFactory.CreateRPSFormattedTextBox<ProjectMaterialView>("9f0dfca0-d586-4e52-a679-98e0fdb35eaf","","",true, this);
 
            AdvanceDays = RPSControlFactory.CreateRPSFormattedTextBox<ProjectMaterialView>("218088c4-ab80-4822-b02e-fe94109a0728","","",true, this);
 
            MakeMovement = RPSControlFactory.CreateRPSCheckBox<ProjectMaterialView>("2f6d2299-bb59-47c9-b84b-130e8e9dbf9a","","",true, this);
 
            ImputationTotalQuantity = RPSControlFactory.CreateRPSCheckBox<ProjectMaterialView>("ecf2a186-f14d-4d7f-8111-6ed7e4d9f58f","","",true, this);
 
            Critical = RPSControlFactory.CreateRPSCheckBox<ProjectMaterialView>("5f0d009e-c717-42fe-afd0-b19ab9aa035d","","",true, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<ProjectMaterialView>("e2d90d89-ee7a-4967-b789-2714713f943e","","",false, this);
 
            IDWareHouse = RPSControlFactory.CreateRPSComboBox<ProjectMaterialView>("9801b062-3849-4db4-9839-7186b52b7bc2","","",false, this);
 
            MakeAutomaticOutput = RPSControlFactory.CreateRPSCheckBox<ProjectMaterialView>("bf070195-6ae3-487f-b00e-c3e38c6c95bc","","",true, this);
 
            BlockedBudget = RPSControlFactory.CreateRPSCheckBox<ProjectMaterialView>("f9e13fb5-68a4-4027-8a91-ad9e60f51072","","",true, this);
 
            ImputationCostUpdated = RPSControlFactory.CreateRPSCheckBox<ProjectMaterialView>("cad99402-5da0-4a77-bddb-ffe7569f9601","","",true, this);
 
            BlockedQuantityReference = RPSControlFactory.CreateRPSCheckBox<ProjectMaterialView>("d0f22e07-af79-4e6e-a913-cde04c8f3c2b","","",true, this);
 
            PriceCostTheoric = RPSControlFactory.CreateRPSFormattedTextBox<ProjectMaterialView>("152e7b84-f572-404a-ad30-6a08304e5e10","","",true, this);
 
            TypeProfit = RPSControlFactory.CreateRPSEnumComboBox<ProjectMaterialView>("802b7b3f-d3e6-4850-952b-cd2b391a71e1","","",true, this);
 
            PercentProfit = RPSControlFactory.CreateRPSFormattedTextBox<ProjectMaterialView>("dcc3546e-b7d6-4474-bc7c-6a8f66d1cdca","","",true, this);
 
            PriceSaleTheoric = RPSControlFactory.CreateRPSFormattedTextBox<ProjectMaterialView>("84eafe6b-af91-4e26-95c8-21c7254cbf16","","",true, this);
 
            IDBudgetCategory = RPSControlFactory.CreateRPSComboBox<ProjectMaterialView>("dbe476fd-01e2-42fa-892a-df8601df29bf","","",false, this);
 
            Notes = RPSControlFactory.CreateRPSTextBox<ProjectMaterialView>("9dc53d33-b511-4762-adce-b13cbc982b03","","",false, this);
 
            BudgetQuantity = RPSControlFactory.CreateRPSFormattedTextBox<ProjectMaterialView>("3f72824f-1a1a-49a2-9a88-e54a36c1294d","","",true, this);
 
            BudgetPrice = RPSControlFactory.CreateRPSFormattedTextBox<ProjectMaterialView>("53182e93-03af-4ddc-8324-2ce46de77e7a","","",true, this);
 
            BudgetAmount = RPSControlFactory.CreateRPSFormattedTextBox<ProjectMaterialView>("f28cde9a-5b4c-413b-a2a5-ae9455ad61ff","","",true, this);
 
            GeneralSection = RPSControlFactory.CreateRPSSection<ProjectMaterialView>( "","ul li[rpsid='d777153c-376f-4f30-96a8-5e12934b98d7']","",this);
 

        }
        public IRPSButton<ProjectMaterialView> DeleteButton { get; set; } 
        public IRPSButton<ProjectMaterialView,ProjectTaskView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<ProjectMaterialView,ProjectTaskView> BackButton { get; set; } 
        public IRPSAcceptButton<ProjectMaterialView,ProjectTaskView> AcceptButton { get; set; } 
        public IRPSTextBox<ProjectMaterialView> CodMaterial { get; set; } 
        public IRPSTextBox<ProjectMaterialView> Description { get; set; } 
        public IRPSComboBox<ProjectMaterialView> IDArticle { get; set; } 
        public IRPSComboBox<ProjectMaterialView> IDArticleParent { get; set; } 
        public IRPSComboBox<ProjectMaterialView> SupplySituation { get; set; } 
        public IRPSComboBox<ProjectMaterialView> Status { get; set; } 
        public IRPSTextBox<ProjectMaterialView> Quantity { get; set; } 
        public IRPSTextBox<ProjectMaterialView> QuantityElements { get; set; } 
        public IRPSTextBox<ProjectMaterialView> AdvanceDays { get; set; } 
        public IRPSCheckbox<ProjectMaterialView> MakeMovement { get; set; } 
        public IRPSCheckbox<ProjectMaterialView> ImputationTotalQuantity { get; set; } 
        public IRPSCheckbox<ProjectMaterialView> Critical { get; set; } 
        public IRPSComboBox<ProjectMaterialView> IDSite { get; set; } 
        public IRPSComboBox<ProjectMaterialView> IDWareHouse { get; set; } 
        public IRPSCheckbox<ProjectMaterialView> MakeAutomaticOutput { get; set; } 
        public IRPSCheckbox<ProjectMaterialView> BlockedBudget { get; set; } 
        public IRPSCheckbox<ProjectMaterialView> ImputationCostUpdated { get; set; } 
        public IRPSCheckbox<ProjectMaterialView> BlockedQuantityReference { get; set; } 
        public IRPSTextBox<ProjectMaterialView> PriceCostTheoric { get; set; } 
        public IRPSComboBox<ProjectMaterialView> TypeProfit { get; set; } 
        public IRPSTextBox<ProjectMaterialView> PercentProfit { get; set; } 
        public IRPSTextBox<ProjectMaterialView> PriceSaleTheoric { get; set; } 
        public IRPSComboBox<ProjectMaterialView> IDBudgetCategory { get; set; } 
        public IRPSTextBox<ProjectMaterialView> Notes { get; set; } 
        public IRPSTextBox<ProjectMaterialView> BudgetQuantity { get; set; } 
        public IRPSTextBox<ProjectMaterialView> BudgetPrice { get; set; } 
        public IRPSTextBox<ProjectMaterialView> BudgetAmount { get; set; } 
        public IRPSSection<ProjectMaterialView> GeneralSection { get; set; } 
        public ProjectMaterialImport Screen { get; set; }
        public ProjectMaterialView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class ImportMaterialsDialogView : View
    {
        public ImportMaterialsDialogView(ProjectMaterialImport screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDProject = RPSControlFactory.CreateRPSComboBox<ImportMaterialsDialogView>("bb642858-883b-4551-bc14-d117c0188963","","",false, this);
 
            IDProTask = RPSControlFactory.CreateRPSComboBox<ImportMaterialsDialogView>("2cd05970-826b-47e4-ae10-cdbda5c64dda","","",false, this);
 
            FileUploadChildNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ImportMaterialsDialogView,FileUploadChildDialogView>("5ff9ae7f-da3e-440f-9e0b-a2a9833cb5f1","","", this,Screen.FileUploadChildDialogView);
 
            CreateArticlesNavigationCommandButton = RPSControlFactory.CreateRPSButtonToView<ImportMaterialsDialogView,CreateArticlesDialogView>("dda44845-5ebc-42e1-b7d1-9bda1df670ab","","", this,Screen.CreateArticlesDialogView);
 

        }
        public IRPSComboBox<ImportMaterialsDialogView> IDProject { get; set; } 
        public IRPSComboBox<ImportMaterialsDialogView> IDProTask { get; set; } 
        public IRPSButton<ImportMaterialsDialogView,FileUploadChildDialogView> FileUploadChildNavigationCommandButton { get; set; } 
        public IRPSButton<ImportMaterialsDialogView,CreateArticlesDialogView> CreateArticlesNavigationCommandButton { get; set; } 
        public ProjectMaterialImport Screen { get; set; }
        public ImportMaterialsDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class FileUploadChildDialogView : View
    {
        public FileUploadChildDialogView(ProjectMaterialImport screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {

        }
        public ProjectMaterialImport Screen { get; set; }
        public FileUploadChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CreateArticlesDialogView : View
    {
        public CreateArticlesDialogView(ProjectMaterialImport screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            UIProductLine = RPSControlFactory.CreateRPSComboBox<CreateArticlesDialogView>("13d5bede-0465-4710-a716-9656dc83d83d","","",false, this);
 
            UIProductFamily = RPSControlFactory.CreateRPSComboBox<CreateArticlesDialogView>("50cb34e2-f087-4faa-b675-7fed266f8555","","",false, this);
 
            UIProductSubFamily = RPSControlFactory.CreateRPSComboBox<CreateArticlesDialogView>("1e883dba-5b55-4c4b-98cd-a759cadb153d","","",false, this);
 

        }
        public IRPSComboBox<CreateArticlesDialogView> UIProductLine { get; set; } 
        public IRPSComboBox<CreateArticlesDialogView> UIProductFamily { get; set; } 
        public IRPSComboBox<CreateArticlesDialogView> UIProductSubFamily { get; set; } 
        public ProjectMaterialImport Screen { get; set; }
        public CreateArticlesDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}