    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.ProProMaterialAllocation
{
    //RPS VERSION 1.0.0.0
    public partial class ProProMaterialAllocation:Screen
    {
        public ProProMaterialAllocation():base()
        {
            this.URL = "project.propromaterialallocation";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ProProMaterialAllocationQueryView  = new ProProMaterialAllocationQueryView(this); 
            WizardChildDialogView  = new WizardChildDialogView(this); 
            StockReserveView  = new StockReserveView(this); 
            MaterialAllocationReservesView  = new MaterialAllocationReservesView(this); 
            ProProMaterialAllocationQueryView.InitializeControls(); 
            WizardChildDialogView.InitializeControls(); 
            StockReserveView.InitializeControls(); 
            MaterialAllocationReservesView.InitializeControls(); 
           
        }
      
            public ProProMaterialAllocationQueryView ProProMaterialAllocationQueryView {get; set; } 
            public WizardChildDialogView WizardChildDialogView {get; set; } 
            public StockReserveView StockReserveView {get; set; } 
            public MaterialAllocationReservesView MaterialAllocationReservesView {get; set; } 
    }
            
    public partial class ProProMaterialAllocationQueryView : View
    {
        public ProProMaterialAllocationQueryView(ProProMaterialAllocation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDSite = RPSControlFactory.CreateRPSComboBox<ProProMaterialAllocationQueryView>("9cbe8e17-ac82-445d-95dd-5008707786ee","","",false, this);
 
            IDProjectType = RPSControlFactory.CreateRPSCollectionComboBox<ProProMaterialAllocationQueryView>("241bee3d-00ca-4538-ae97-5abb1e684ce1","","",false, this);
 
            IDProject = RPSControlFactory.CreateRPSCollectionComboBox<ProProMaterialAllocationQueryView>("9dce5a27-8f13-4a67-a6fd-a3138b32c942","","",false, this);
 
            IDArticle = RPSControlFactory.CreateRPSCollectionComboBox<ProProMaterialAllocationQueryView>("927f6bd4-0a50-4fa5-a899-7166755aa760","","",false, this);
 
            All = RPSControlFactory.CreateRPSOption<ProProMaterialAllocationQueryView>( "1b975c1e-2077-4084-9086-7874ff6fedba","","",this);
 
            WithAllocation = RPSControlFactory.CreateRPSOption<ProProMaterialAllocationQueryView>( "83098e83-ec0d-4b95-8c94-0da79c8d5fee","","",this);
 
            WithoutAllocations = RPSControlFactory.CreateRPSOption<ProProMaterialAllocationQueryView>( "4f580b69-4f2a-4f27-b8ab-cb10ed478882","","",this);
 
            GenerateCommandButton = RPSControlFactory.CreateRPSButton<ProProMaterialAllocationQueryView>( "5b7f80ac-fc55-4a40-ac6d-89b0c976ddd3","","",this);
 
            DeleteCommandButton = RPSControlFactory.CreateRPSButton<ProProMaterialAllocationQueryView>( "bf129aef-83d6-48bb-9b0e-b93ec9276542","","",this);
 
            CollectionInit params_ProjectMaterialConsult = new CollectionInit(){IDDescriptor = "1061b202-c20e-42fc-ac0f-c6ce10bbce19",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="faf6c315-caa8-4067-a2a8-962fc9dc120e",CSSSelectorGrid="",XPathGrid=""};
            ProjectMaterialConsult = RPSControlFactory.RPSCreateCollectionWithGrid<ProjectMaterialConsultCollectionEditor<ProProMaterialAllocationQueryView,WizardChildDialogView>,ProProMaterialAllocationQueryView,WizardChildDialogView>( params_ProjectMaterialConsult,this,Screen.WizardChildDialogView);
 

        }
        public IRPSComboBox<ProProMaterialAllocationQueryView> IDSite { get; set; } 
        public IRPSCollectionComboBox<ProProMaterialAllocationQueryView> IDProjectType { get; set; } 
        public IRPSCollectionComboBox<ProProMaterialAllocationQueryView> IDProject { get; set; } 
        public IRPSCollectionComboBox<ProProMaterialAllocationQueryView> IDArticle { get; set; } 
        public IRPSOption<ProProMaterialAllocationQueryView> All { get; set; } 
        public IRPSOption<ProProMaterialAllocationQueryView> WithAllocation { get; set; } 
        public IRPSOption<ProProMaterialAllocationQueryView> WithoutAllocations { get; set; } 
        public IRPSButton<ProProMaterialAllocationQueryView> GenerateCommandButton { get; set; } 
        public IRPSButton<ProProMaterialAllocationQueryView> DeleteCommandButton { get; set; } 
        public ProjectMaterialConsultCollectionEditor<ProProMaterialAllocationQueryView,WizardChildDialogView> ProjectMaterialConsult { get; set; } 
        public ProProMaterialAllocation Screen { get; set; }
        public ProProMaterialAllocationQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ProjectMaterialConsultCollectionEditor<ProProMaterialAllocationQueryView,WizardChildDialogView>:RPSCollectionEditor<ProProMaterialAllocationQueryView,WizardChildDialogView> where ProProMaterialAllocationQueryView : class, IView where WizardChildDialogView : class, IView
    {
        public  ProjectMaterialConsultGridView<ProProMaterialAllocationQueryView,WizardChildDialogView> GridView {get;set;}
    }
    public partial class ProjectMaterialConsultGridView <ProProMaterialAllocationQueryView,WizardChildDialogView> :  RPSGridView<ProProMaterialAllocationQueryView,WizardChildDialogView> where ProProMaterialAllocationQueryView : class, IView where WizardChildDialogView : class, IView
    {
        public ProjectMaterialConsultGridView(ProProMaterialAllocationQueryView currentView,WizardChildDialogView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            ProjectTask_PlannedStartDate = RPSControlFactory.CreateRPSGridTextBox<ProProMaterialAllocationQueryView>("","#faf6c315-caa8-4067-a2a8-962fc9dc120e .ag-row[role='row']@ROWINDEX [col-id='cProjectTask_PlannedStartDate']","",false, this.CurrentView);
 
            ProjectTask_PlannedEndDate = RPSControlFactory.CreateRPSGridTextBox<ProProMaterialAllocationQueryView>("","#faf6c315-caa8-4067-a2a8-962fc9dc120e .ag-row[role='row']@ROWINDEX [col-id='cProjectTask_PlannedEndDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ProProMaterialAllocationQueryView> ProjectTask_PlannedStartDate { get; set; } 
        public IRPSGridTextBox<ProProMaterialAllocationQueryView> ProjectTask_PlannedEndDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class WizardChildDialogView : View
    {
        public WizardChildDialogView(ProProMaterialAllocation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDSite = RPSControlFactory.CreateRPSComboBox<WizardChildDialogView>("c87312d9-d80f-49a9-96bd-5d49dd77fa5c","","",false, this);
 
            IDProject = RPSControlFactory.CreateRPSCollectionComboBox<WizardChildDialogView>("22da8744-71c6-4d94-a8c9-d2d9c8e9ca4e","","",false, this);
 
            IDProjectType = RPSControlFactory.CreateRPSCollectionComboBox<WizardChildDialogView>("d95130a9-415e-42f7-919e-96ecfdeefbe1","","",false, this);
 
            PreviousSelection = RPSControlFactory.CreateRPSCheckBox<WizardChildDialogView>("d7af52bc-430f-4437-9ff7-6fed224e06e2","","",false, this);
 
            CollectionInit params_ProjectForAssignmentMaterial = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="58d3a867-726c-4fdb-b9db-156b959c424c",CSSSelectorGrid="",XPathGrid=""};
            ProjectForAssignmentMaterial = RPSControlFactory.RPSCreateCollectionWithGrid<ProjectForAssignmentMaterialCollectionEditor<WizardChildDialogView>,WizardChildDialogView>( params_ProjectForAssignmentMaterial,this);
 

        }
        public IRPSComboBox<WizardChildDialogView> IDSite { get; set; } 
        public IRPSCollectionComboBox<WizardChildDialogView> IDProject { get; set; } 
        public IRPSCollectionComboBox<WizardChildDialogView> IDProjectType { get; set; } 
        public IRPSCheckbox<WizardChildDialogView> PreviousSelection { get; set; } 
        public ProjectForAssignmentMaterialCollectionEditor<WizardChildDialogView> ProjectForAssignmentMaterial { get; set; } 
        public ProProMaterialAllocation Screen { get; set; }
        public WizardChildDialogView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ProjectForAssignmentMaterialCollectionEditor<WizardChildDialogView>:RPSCollectionEditor<WizardChildDialogView> where WizardChildDialogView : class, IView
    {
        public  ProjectForAssignmentMaterialGridView<WizardChildDialogView> GridView {get;set;}
    }
    public partial class ProjectForAssignmentMaterialGridView <WizardChildDialogView> :  RPSGridView<WizardChildDialogView> where WizardChildDialogView : class, IView
    {
        public ProjectForAssignmentMaterialGridView(WizardChildDialogView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Project_CodProject = RPSControlFactory.CreateRPSGridTextBox<WizardChildDialogView>("","#58d3a867-726c-4fdb-b9db-156b959c424c .ag-row[role='row']@ROWINDEX [col-id='cProject_CodProject']","",false, this.CurrentView);
 
            Project_Description = RPSControlFactory.CreateRPSGridTextBox<WizardChildDialogView>("","#58d3a867-726c-4fdb-b9db-156b959c424c .ag-row[role='row']@ROWINDEX [col-id='cProject_Description']","",false, this.CurrentView);
 
            Project_Version = RPSControlFactory.CreateRPSGridTextBox<WizardChildDialogView>("","#58d3a867-726c-4fdb-b9db-156b959c424c .ag-row[role='row']@ROWINDEX [col-id='cProject_Version']","",false, this.CurrentView);
 
            Project_AcceptedDate = RPSControlFactory.CreateRPSGridTextBox<WizardChildDialogView>("","#58d3a867-726c-4fdb-b9db-156b959c424c .ag-row[role='row']@ROWINDEX [col-id='cProject_AcceptedDate']","",false, this.CurrentView);
 
            Project_PlannedStartDate = RPSControlFactory.CreateRPSGridTextBox<WizardChildDialogView>("","#58d3a867-726c-4fdb-b9db-156b959c424c .ag-row[role='row']@ROWINDEX [col-id='cProject_PlannedStartDate']","",false, this.CurrentView);
 
            Project_PlannedEndDate = RPSControlFactory.CreateRPSGridTextBox<WizardChildDialogView>("","#58d3a867-726c-4fdb-b9db-156b959c424c .ag-row[role='row']@ROWINDEX [col-id='cProject_PlannedEndDate']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<WizardChildDialogView> Project_CodProject { get; set; } 
        public IRPSGridTextBox<WizardChildDialogView> Project_Description { get; set; } 
        public IRPSGridTextBox<WizardChildDialogView> Project_Version { get; set; } 
        public IRPSGridTextBox<WizardChildDialogView> Project_AcceptedDate { get; set; } 
        public IRPSGridTextBox<WizardChildDialogView> Project_PlannedStartDate { get; set; } 
        public IRPSGridTextBox<WizardChildDialogView> Project_PlannedEndDate { get; set; } 
                     
    }
 
    }
  
            
    public partial class StockReserveView : View
    {
        public StockReserveView(ProProMaterialAllocation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<StockReserveView>( this);
 
            IDArticle = RPSControlFactory.CreateRPSComboBox<StockReserveView>("8e06fb31-3b4c-44e4-9cea-9485092f4963","","",false, this);
 
            UIIDSite = RPSControlFactory.CreateRPSComboBox<StockReserveView>("f594b370-5de3-4c1d-9355-351d0e5046fb","","",true, this);
 
            UIIDWareHouse = RPSControlFactory.CreateRPSComboBox<StockReserveView>("d21302d7-311b-42bd-be90-96f88bb68831","","",true, this);
 
            UISeries = RPSControlFactory.CreateRPSEnumComboBox<StockReserveView>("dbef694b-8e04-4cf3-b419-1ea8a6122566","","",false, this);
 
            UIIDLocationWarehouse = RPSControlFactory.CreateRPSComboBox<StockReserveView>("c6f00534-5e6a-408b-97fa-3e67196d9a5e","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<StockReserveView>("2bc6fe99-536c-4a39-a1be-91200972f61c","","",true, this);
 
            QuantitySecondUnit = RPSControlFactory.CreateRPSFormattedTextBox<StockReserveView>("465ce9d9-9701-4612-bb51-a78c71b425f5","","",true, this);
 

        }
        public IRPSSaveButton<StockReserveView> SaveButton { get; set; } 
        public IRPSComboBox<StockReserveView> IDArticle { get; set; } 
        public IRPSComboBox<StockReserveView> UIIDSite { get; set; } 
        public IRPSComboBox<StockReserveView> UIIDWareHouse { get; set; } 
        public IRPSComboBox<StockReserveView> UISeries { get; set; } 
        public IRPSComboBox<StockReserveView> UIIDLocationWarehouse { get; set; } 
        public IRPSTextBox<StockReserveView> Quantity { get; set; } 
        public IRPSTextBox<StockReserveView> QuantitySecondUnit { get; set; } 
        public ProProMaterialAllocation Screen { get; set; }
        public StockReserveView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class MaterialAllocationReservesView : View
    {
        public MaterialAllocationReservesView(ProProMaterialAllocation screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Article = RPSControlFactory.CreateRPSComboBox<MaterialAllocationReservesView>("01b15063-1478-48ba-8dff-cb83d7bcc67b","","",false, this);
 
            Quantity = RPSControlFactory.CreateRPSFormattedTextBox<MaterialAllocationReservesView>("a2c64336-e3c9-4268-8767-3d63e2cc5da2","","",false, this);
 
            PendingQuantity = RPSControlFactory.CreateRPSFormattedTextBox<MaterialAllocationReservesView>("85aa8024-5b66-4c85-b2cd-c9be10de3d56","","",false, this);
 
            AssignedQuantity = RPSControlFactory.CreateRPSFormattedTextBox<MaterialAllocationReservesView>("4c703fbb-6078-4cd8-bad6-9fe930580c1a","","",false, this);
 
            LinkNavigationCommandButton = RPSControlFactory.CreateRPSButton<MaterialAllocationReservesView>( "ed686992-0acf-4ff2-89f0-69ec7a3d7667","","",this);
 
            SaveQuantityCommandButton = RPSControlFactory.CreateRPSButton<MaterialAllocationReservesView>( "463ab16e-b997-4e3a-ae18-51e1531247ab","","",this);
 
            CollectionInit params_StockReserveForAllocation = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="048dd200-6832-414b-bf01-a87cc3a3f31d",CSSSelectorGrid="",XPathGrid=""};
            StockReserveForAllocation = RPSControlFactory.RPSCreateCollectionWithGrid<StockReserveForAllocationCollectionEditor<MaterialAllocationReservesView>,MaterialAllocationReservesView>( params_StockReserveForAllocation,this);
 

        }
        public IRPSComboBox<MaterialAllocationReservesView> Article { get; set; } 
        public IRPSTextBox<MaterialAllocationReservesView> Quantity { get; set; } 
        public IRPSTextBox<MaterialAllocationReservesView> PendingQuantity { get; set; } 
        public IRPSTextBox<MaterialAllocationReservesView> AssignedQuantity { get; set; } 
        public IRPSButton<MaterialAllocationReservesView> LinkNavigationCommandButton { get; set; } 
        public IRPSButton<MaterialAllocationReservesView> SaveQuantityCommandButton { get; set; } 
        public StockReserveForAllocationCollectionEditor<MaterialAllocationReservesView> StockReserveForAllocation { get; set; } 
        public ProProMaterialAllocation Screen { get; set; }
        public MaterialAllocationReservesView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class StockReserveForAllocationCollectionEditor<MaterialAllocationReservesView>:RPSCollectionEditor<MaterialAllocationReservesView> where MaterialAllocationReservesView : class, IView
    {
        public  StockReserveForAllocationGridView<MaterialAllocationReservesView> GridView {get;set;}
    }
    public partial class StockReserveForAllocationGridView <MaterialAllocationReservesView> :  RPSGridView<MaterialAllocationReservesView> where MaterialAllocationReservesView : class, IView
    {
        public StockReserveForAllocationGridView(MaterialAllocationReservesView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DeleteStockReserveCommand = RPSControlFactory.CreateRPSGridButton<MaterialAllocationReservesView>( "","#048dd200-6832-414b-bf01-a87cc3a3f31d .ag-row[role='row']@ROWINDEX [col-id='cDeleteStockReserveCommand']","",this.CurrentView);
 
            Stock_Series = RPSControlFactory.CreateRPSGridTextBox<MaterialAllocationReservesView>("","#048dd200-6832-414b-bf01-a87cc3a3f31d .ag-row[role='row']@ROWINDEX [col-id='cStock_Series']","",false, this.CurrentView);
 

        }
        public IRPSGridButton<MaterialAllocationReservesView> DeleteStockReserveCommand { get; set; } 
        public IRPSGridTextBox<MaterialAllocationReservesView> Stock_Series { get; set; } 
                     
    }
 
    }
  
    

}