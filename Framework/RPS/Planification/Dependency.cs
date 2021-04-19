    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Planification.Dependency
{
    //RPS VERSION 1.0.0.0
    public partial class Dependency:Screen
    {
        public Dependency():base()
        {
            this.URL = "planification.dependency";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            DependencyVMCollectionView  = new DependencyVMCollectionView(this); 
            DependencyVMEntityView  = new DependencyVMEntityView(this); 
            DependencyVMCollectionView.InitializeControls(); 
            DependencyVMEntityView.InitializeControls(); 
           
        }
      
            public DependencyVMCollectionView DependencyVMCollectionView {get; set; } 
            public DependencyVMEntityView DependencyVMEntityView {get; set; } 
    }
            
    public partial class DependencyVMCollectionView : View
    {
        public DependencyVMCollectionView(Dependency screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Site = RPSControlFactory.CreateRPSComboBox<DependencyVMCollectionView>("caad3a88-23cd-4548-bd7c-2675016ba6a8","","",false, this);
 
            CheckManufacturingOrder = RPSControlFactory.CreateRPSCheckBox<DependencyVMCollectionView>("3f7a0bf2-29a4-416c-889e-c5e4b3e84682","","",false, this);
 
            CheckPurchaseProposal = RPSControlFactory.CreateRPSCheckBox<DependencyVMCollectionView>("eeb32647-d812-4f02-9f8d-623418d65925","","",false, this);
 
            CheckPurchaseOrderLine = RPSControlFactory.CreateRPSCheckBox<DependencyVMCollectionView>("ac62f9f1-2cf8-41cb-9642-1389fa727fbd","","",false, this);
 
            CheckManufacturingOrderMaterial = RPSControlFactory.CreateRPSCheckBox<DependencyVMCollectionView>("771ad3d9-919a-42ef-b65d-c30cb8f48562","","",false, this);
 
            CheckProjectMaterial = RPSControlFactory.CreateRPSCheckBox<DependencyVMCollectionView>("2f1221c4-87ac-4699-a345-f351a23eb937","","",false, this);
 
            CheckMaintenanceOrderMaterial = RPSControlFactory.CreateRPSCheckBox<DependencyVMCollectionView>("55fa42f7-17c1-4316-bc63-17692a6ced2b","","",false, this);
 
            CollectionInit params_DependencyQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="37e6481e-30a6-4894-a91a-e6b0c111e0ef",CSSSelectorGrid="",XPathGrid=""};
            DependencyQuery = RPSControlFactory.RPSCreateCollectionWithGrid<DependencyQueryCollectionEditor<DependencyVMCollectionView,DependencyVMEntityView>,DependencyVMCollectionView,DependencyVMEntityView>( params_DependencyQuery,this,Screen.DependencyVMEntityView);
 

        }
        public IRPSComboBox<DependencyVMCollectionView> Site { get; set; } 
        public IRPSCheckbox<DependencyVMCollectionView> CheckManufacturingOrder { get; set; } 
        public IRPSCheckbox<DependencyVMCollectionView> CheckPurchaseProposal { get; set; } 
        public IRPSCheckbox<DependencyVMCollectionView> CheckPurchaseOrderLine { get; set; } 
        public IRPSCheckbox<DependencyVMCollectionView> CheckManufacturingOrderMaterial { get; set; } 
        public IRPSCheckbox<DependencyVMCollectionView> CheckProjectMaterial { get; set; } 
        public IRPSCheckbox<DependencyVMCollectionView> CheckMaintenanceOrderMaterial { get; set; } 
        public DependencyQueryCollectionEditor<DependencyVMCollectionView,DependencyVMEntityView> DependencyQuery { get; set; } 
        public Dependency Screen { get; set; }
        public DependencyVMCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class DependencyQueryCollectionEditor<DependencyVMCollectionView,DependencyVMEntityView>:RPSCollectionEditor<DependencyVMCollectionView,DependencyVMEntityView> where DependencyVMCollectionView : class, IView where DependencyVMEntityView : class, IView
    {
        public  DependencyQueryGridView<DependencyVMCollectionView,DependencyVMEntityView> GridView {get;set;}
    }
    public partial class DependencyQueryGridView <DependencyVMCollectionView,DependencyVMEntityView> :  RPSGridView<DependencyVMCollectionView,DependencyVMEntityView> where DependencyVMCollectionView : class, IView where DependencyVMEntityView : class, IView
    {
        public DependencyQueryGridView(DependencyVMCollectionView currentView,DependencyVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            MainType = RPSControlFactory.CreateRPSGridEnumComboBox<DependencyVMCollectionView>("","#37e6481e-30a6-4894-a91a-e6b0c111e0ef .ag-row[role='row']@ROWINDEX [col-id='cMainType']","",true, this.CurrentView);
 
            Main = RPSControlFactory.CreateRPSGridComboBox<DependencyVMCollectionView>("","#37e6481e-30a6-4894-a91a-e6b0c111e0ef .ag-row[role='row']@ROWINDEX [col-id='cMain']","",false, this.CurrentView);
 
            SecondaryType = RPSControlFactory.CreateRPSGridEnumComboBox<DependencyVMCollectionView>("","#37e6481e-30a6-4894-a91a-e6b0c111e0ef .ag-row[role='row']@ROWINDEX [col-id='cSecondaryType']","",true, this.CurrentView);
 
            SecondaryEntity = RPSControlFactory.CreateRPSGridComboBox<DependencyVMCollectionView>("","#37e6481e-30a6-4894-a91a-e6b0c111e0ef .ag-row[role='row']@ROWINDEX [col-id='cSecondaryEntity']","",false, this.CurrentView);
 
            Secondary = RPSControlFactory.CreateRPSGridComboBox<DependencyVMCollectionView>("","#37e6481e-30a6-4894-a91a-e6b0c111e0ef .ag-row[role='row']@ROWINDEX [col-id='cSecondary']","",false, this.CurrentView);
 
            IDArticle = RPSControlFactory.CreateRPSGridComboBox<DependencyVMCollectionView>("","#37e6481e-30a6-4894-a91a-e6b0c111e0ef .ag-row[role='row']@ROWINDEX [col-id='cIDArticle']","",true, this.CurrentView);
 

        }
        public IRPSGridComboBox<DependencyVMCollectionView> MainType { get; set; } 
        public IRPSGridComboBox<DependencyVMCollectionView> Main { get; set; } 
        public IRPSGridComboBox<DependencyVMCollectionView> SecondaryType { get; set; } 
        public IRPSGridComboBox<DependencyVMCollectionView> SecondaryEntity { get; set; } 
        public IRPSGridComboBox<DependencyVMCollectionView> Secondary { get; set; } 
        public IRPSGridComboBox<DependencyVMCollectionView> IDArticle { get; set; } 
                     
    }
 
    }
  
            
    public partial class DependencyVMEntityView : View
    {
        public DependencyVMEntityView(Dependency screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<DependencyVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<DependencyVMEntityView,DependencyVMCollectionView>( this,Screen.DependencyVMCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<DependencyVMEntityView,DependencyVMCollectionView>( this,Screen.DependencyVMCollectionView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<DependencyVMEntityView,DependencyVMCollectionView>( this,Screen.DependencyVMCollectionView);
 
            MainType = RPSControlFactory.CreateRPSEnumComboBox<DependencyVMEntityView>("2d408dd5-9539-4804-8b98-4cac99cb38d1","","",true, this);
 
            IDMainManufacturingOrder = RPSControlFactory.CreateRPSComboBox<DependencyVMEntityView>("21445198-6268-4645-83da-608a0d795c62","","",false, this);
 
            IDMainPurchaseProposal = RPSControlFactory.CreateRPSComboBox<DependencyVMEntityView>("80c01d23-81e4-4f8f-a22d-b787ada02f29","","",false, this);
 
            Order = RPSControlFactory.CreateRPSComboBox<DependencyVMEntityView>("8544c4f1-5d14-45e8-a038-02896024b8b1","","",false, this);
 
            IDMainPurchaseOrderLine = RPSControlFactory.CreateRPSComboBox<DependencyVMEntityView>("06645abc-5b16-47e5-a938-741ebb7b2ee4","","",false, this);
 
            SecondaryType = RPSControlFactory.CreateRPSEnumComboBox<DependencyVMEntityView>("549f9016-9b32-4f2a-9aa3-1567cbb17ff2","","",true, this);
 
            ManufacturingOrder = RPSControlFactory.CreateRPSComboBox<DependencyVMEntityView>("cd216b5f-1d85-45dd-b600-b0ee92a52500","","",false, this);
 
            IDSecondaryManufacturingOrderMaterial = RPSControlFactory.CreateRPSComboBox<DependencyVMEntityView>("a5d90721-e61a-4fa7-b80b-3e72c7a1c5e4","","",false, this);
 
            Project = RPSControlFactory.CreateRPSComboBox<DependencyVMEntityView>("ffa6e363-a26f-4762-a190-cdaaa902f22f","","",false, this);
 
            IDSecondaryProjectMaterial = RPSControlFactory.CreateRPSComboBox<DependencyVMEntityView>("6388005a-2e52-4418-81dd-072932445358","","",false, this);
 
            MaintenanceOrder = RPSControlFactory.CreateRPSComboBox<DependencyVMEntityView>("d9987018-f375-4c10-8d5d-fa528df4c187","","",false, this);
 
            IDSecondaryMaintenanceMaterial = RPSControlFactory.CreateRPSComboBox<DependencyVMEntityView>("8eae01d4-6975-4a6c-b9b3-d17eedf6370b","","",false, this);
 

        }
        public IRPSButton<DependencyVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<DependencyVMEntityView,DependencyVMCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<DependencyVMEntityView,DependencyVMCollectionView> BackButton { get; set; } 
        public IRPSAcceptButton<DependencyVMEntityView,DependencyVMCollectionView> AcceptButton { get; set; } 
        public IRPSComboBox<DependencyVMEntityView> MainType { get; set; } 
        public IRPSComboBox<DependencyVMEntityView> IDMainManufacturingOrder { get; set; } 
        public IRPSComboBox<DependencyVMEntityView> IDMainPurchaseProposal { get; set; } 
        public IRPSComboBox<DependencyVMEntityView> Order { get; set; } 
        public IRPSComboBox<DependencyVMEntityView> IDMainPurchaseOrderLine { get; set; } 
        public IRPSComboBox<DependencyVMEntityView> SecondaryType { get; set; } 
        public IRPSComboBox<DependencyVMEntityView> ManufacturingOrder { get; set; } 
        public IRPSComboBox<DependencyVMEntityView> IDSecondaryManufacturingOrderMaterial { get; set; } 
        public IRPSComboBox<DependencyVMEntityView> Project { get; set; } 
        public IRPSComboBox<DependencyVMEntityView> IDSecondaryProjectMaterial { get; set; } 
        public IRPSComboBox<DependencyVMEntityView> MaintenanceOrder { get; set; } 
        public IRPSComboBox<DependencyVMEntityView> IDSecondaryMaintenanceMaterial { get; set; } 
        public Dependency Screen { get; set; }
        public DependencyVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}