    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Warehouse.ResupplyListing
{
    //RPS VERSION 1.0.0.0
    public partial class ResupplyListing:Screen
    {
        public ResupplyListing():base()
        {
            this.URL = "warehouse.resupplylisting";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            ResupplyListingView  = new ResupplyListingView(this); 
            ResupplyListingView.InitializeControls(); 
           
        }
      
            public ResupplyListingView ResupplyListingView {get; set; } 
    }
            
    public partial class ResupplyListingView : View
    {
        public ResupplyListingView(ResupplyListing screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            Article = RPSControlFactory.CreateRPSOption<ResupplyListingView>( "f42c489f-2753-4465-8c12-f50b0de4a4ce","","",this);
 
            Planta = RPSControlFactory.CreateRPSOption<ResupplyListingView>( "219ebec3-2d81-4147-91c4-bfb670ee582b","","",this);
 
            Almacen = RPSControlFactory.CreateRPSOption<ResupplyListingView>( "00f7a9e3-c85c-4a76-b8b8-744b19da8b37","","",this);
 
            ProductLine = RPSControlFactory.CreateRPSCollectionComboBox<ResupplyListingView>("b122dc18-bb01-40e0-8897-1684d59f3729","","",false, this);
 
            ProductFamily = RPSControlFactory.CreateRPSCollectionComboBox<ResupplyListingView>("270b2666-ebf8-4be6-8b08-05e34ede7613","","",false, this);
 
            ProductSubFamily = RPSControlFactory.CreateRPSCollectionComboBox<ResupplyListingView>("ba3517bc-ddf8-4bd3-bafe-5efd235a00f0","","",false, this);
 
            Article1 = RPSControlFactory.CreateRPSCollectionComboBox<ResupplyListingView>("f7dc8296-0656-47b4-bcce-f35701a06898","","",false, this);
 
            Site = RPSControlFactory.CreateRPSCollectionComboBox<ResupplyListingView>("c1e29ae3-de17-424f-a2db-469cc7f2e89b","","",false, this);
 
            WareHouse = RPSControlFactory.CreateRPSCollectionComboBox<ResupplyListingView>("d954d0f1-75a9-4241-81db-6176e857e1f9","","",false, this);
 
            Supplier = RPSControlFactory.CreateRPSComboBox<ResupplyListingView>("fdf19db7-98f5-4ed6-a89b-357b8f769871","","",false, this);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<ResupplyListingView>("14db7cd7-315c-4686-a854-dd428e769a50","","",false, this);
 
            Fixed = RPSControlFactory.CreateRPSOption<ResupplyListingView>( "e929f677-a1ff-4f41-acbe-d9c8f5935737","","",this);
 
            ArticleTime = RPSControlFactory.CreateRPSOption<ResupplyListingView>( "78506049-f166-4a30-b89e-92d8f88f19da","","",this);
 
            DateTo = RPSControlFactory.CreateRPSTextBox<ResupplyListingView>("6dfa4e20-388b-4b5c-a455-5f96198d4936","","",false, this);
 
            bCoverMinimumStock = RPSControlFactory.CreateRPSCheckBox<ResupplyListingView>("913fe3df-1c72-4446-b168-32ba3de78a97","","",false, this);
 
            bDiscardWithoutExistenceControl = RPSControlFactory.CreateRPSCheckBox<ResupplyListingView>("15619541-8be5-4778-9e4d-e9db29ac43f3","","",false, this);
 
            bDontUsenegativeStock = RPSControlFactory.CreateRPSCheckBox<ResupplyListingView>("00e87965-8651-46ff-b956-65a037337f59","","",false, this);
 
            DiscardArticlesBlockedForPurchase = RPSControlFactory.CreateRPSCheckBox<ResupplyListingView>("dd87cd8d-4307-48ab-84f2-20e52c1ee777","","",false, this);
 
            bOnlyPurchaseArticles = RPSControlFactory.CreateRPSCheckBox<ResupplyListingView>("4d987578-2a59-4af2-9fe4-692bd8ab009f","","",false, this);
 
            bOnlyProposalsHigherThanZero = RPSControlFactory.CreateRPSCheckBox<ResupplyListingView>("d84cb0e5-974d-433a-8d05-d6559b29d5c7","","",false, this);
 
            bPurchase = RPSControlFactory.CreateRPSCheckBox<ResupplyListingView>("96404b19-4032-4fdc-be43-13ddc9595b70","","",false, this);
 
            bConsumePrevisions = RPSControlFactory.CreateRPSCheckBox<ResupplyListingView>("6ca7641f-3d1d-4fed-a652-58659eb5612b","","",false, this);
 
            bSales = RPSControlFactory.CreateRPSCheckBox<ResupplyListingView>("ebdca40f-ebee-4898-931b-4b27f3eee002","","",false, this);
 
            bSalesPrevisions = RPSControlFactory.CreateRPSCheckBox<ResupplyListingView>("06beaf0a-f7c8-4570-82ab-20ffe2018890","","",false, this);
 
            bManufacturingOrder = RPSControlFactory.CreateRPSCheckBox<ResupplyListingView>("474585b3-662a-41ed-bcd2-8e8e51dcaafe","","",false, this);
 
            bManufacturingPrevisions = RPSControlFactory.CreateRPSCheckBox<ResupplyListingView>("01b621af-489b-44d3-9e4c-af205f2e16af","","",false, this);
 
            bProyects = RPSControlFactory.CreateRPSCheckBox<ResupplyListingView>("de747811-cfe4-43ee-b02e-92318171b765","","",false, this);
 
            bIndustrialMaintenance = RPSControlFactory.CreateRPSCheckBox<ResupplyListingView>("50e615c4-98a8-4bad-b162-18933446d82e","","",false, this);
 
            bDeliveryPlanPurchase = RPSControlFactory.CreateRPSCheckBox<ResupplyListingView>("1b56ae2e-3a44-4e0f-90e5-7900c97e16b7","","",false, this);
 
            bDeliveryPlanSales = RPSControlFactory.CreateRPSCheckBox<ResupplyListingView>("8114ca40-866a-4ca6-bbbb-514eaaafa493","","",false, this);
 
            ExecuteQuery = RPSControlFactory.CreateRPSButton<ResupplyListingView>( "11b3266b-a9bb-4be3-8612-14d83cd41987","","",this);
 
            Proposal = RPSControlFactory.CreateRPSFormattedTextBox<ResupplyListingView>("3df522dc-35f0-4900-aab3-292056f0ce97","","",false, this);
 
            Proposal1 = RPSControlFactory.CreateRPSFormattedTextBox<ResupplyListingView>("8724ae33-43a1-4d43-b928-fd6a846d42ed","","",false, this);
 
            Proposal2 = RPSControlFactory.CreateRPSFormattedTextBox<ResupplyListingView>("bd545830-309a-4e18-a327-3187bce03a9b","","",false, this);
 
            GenerateProposalsCommandButton = RPSControlFactory.CreateRPSButton<ResupplyListingView>( "4dad024b-d260-4ce3-83c4-7efeed9758d1","","",this);
 
            CollectionInit params_ResupplyListing = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6560eec0-d213-4f39-926b-e8882373f1e0",CSSSelectorGrid="",XPathGrid=""};
            ResupplyListing = RPSControlFactory.RPSCreateCollectionWithGrid<ResupplyListingCollectionEditor<ResupplyListingView>,ResupplyListingView>( params_ResupplyListing,this);
 
            CollectionInit params_ResupplyChildren = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="86a53cd2-6910-4ddd-9665-7bcacdd95614",CSSSelectorGrid="",XPathGrid=""};
            ResupplyChildren = RPSControlFactory.RPSCreateCollectionWithGrid<ResupplyChildrenCollectionEditor<ResupplyListingView>,ResupplyListingView>( params_ResupplyChildren,this);
 
            CollectionInit params_ResupplyListingSite = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="0f84345c-a6bd-4a59-bfb0-61ccadc05447",CSSSelectorGrid="",XPathGrid=""};
            ResupplyListingSite = RPSControlFactory.RPSCreateCollectionWithGrid<ResupplyListingSiteCollectionEditor<ResupplyListingView>,ResupplyListingView>( params_ResupplyListingSite,this);
 
            CollectionInit params_ResupplyChildren1 = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="380a8a3f-1e7e-43ae-a7fa-0fe9ccc29233",CSSSelectorGrid="",XPathGrid=""};
            ResupplyChildren1 = RPSControlFactory.RPSCreateCollectionWithGrid<ResupplyChildrenCollectionEditor<ResupplyListingView>,ResupplyListingView>( params_ResupplyChildren1,this);
 
            CollectionInit params_ResupplyListingWarehouse = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="d7f799a2-e921-4d4a-938a-18eafa180c94",CSSSelectorGrid="",XPathGrid=""};
            ResupplyListingWarehouse = RPSControlFactory.RPSCreateCollectionWithGrid<ResupplyListingWarehouseCollectionEditor<ResupplyListingView>,ResupplyListingView>( params_ResupplyListingWarehouse,this);
 
            CollectionInit params_ResupplyChildren2 = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6525d55f-d4d8-4baf-980e-023e3b7e4329",CSSSelectorGrid="",XPathGrid=""};
            ResupplyChildren2 = RPSControlFactory.RPSCreateCollectionWithGrid<ResupplyChildrenCollectionEditor<ResupplyListingView>,ResupplyListingView>( params_ResupplyChildren2,this);
 

        }
        public IRPSOption<ResupplyListingView> Article { get; set; } 
        public IRPSOption<ResupplyListingView> Planta { get; set; } 
        public IRPSOption<ResupplyListingView> Almacen { get; set; } 
        public IRPSCollectionComboBox<ResupplyListingView> ProductLine { get; set; } 
        public IRPSCollectionComboBox<ResupplyListingView> ProductFamily { get; set; } 
        public IRPSCollectionComboBox<ResupplyListingView> ProductSubFamily { get; set; } 
        public IRPSCollectionComboBox<ResupplyListingView> Article1 { get; set; } 
        public IRPSCollectionComboBox<ResupplyListingView> Site { get; set; } 
        public IRPSCollectionComboBox<ResupplyListingView> WareHouse { get; set; } 
        public IRPSComboBox<ResupplyListingView> Supplier { get; set; } 
        public IRPSTextBox<ResupplyListingView> DateFrom { get; set; } 
        public IRPSOption<ResupplyListingView> Fixed { get; set; } 
        public IRPSOption<ResupplyListingView> ArticleTime { get; set; } 
        public IRPSTextBox<ResupplyListingView> DateTo { get; set; } 
        public IRPSCheckbox<ResupplyListingView> bCoverMinimumStock { get; set; } 
        public IRPSCheckbox<ResupplyListingView> bDiscardWithoutExistenceControl { get; set; } 
        public IRPSCheckbox<ResupplyListingView> bDontUsenegativeStock { get; set; } 
        public IRPSCheckbox<ResupplyListingView> DiscardArticlesBlockedForPurchase { get; set; } 
        public IRPSCheckbox<ResupplyListingView> bOnlyPurchaseArticles { get; set; } 
        public IRPSCheckbox<ResupplyListingView> bOnlyProposalsHigherThanZero { get; set; } 
        public IRPSCheckbox<ResupplyListingView> bPurchase { get; set; } 
        public IRPSCheckbox<ResupplyListingView> bConsumePrevisions { get; set; } 
        public IRPSCheckbox<ResupplyListingView> bSales { get; set; } 
        public IRPSCheckbox<ResupplyListingView> bSalesPrevisions { get; set; } 
        public IRPSCheckbox<ResupplyListingView> bManufacturingOrder { get; set; } 
        public IRPSCheckbox<ResupplyListingView> bManufacturingPrevisions { get; set; } 
        public IRPSCheckbox<ResupplyListingView> bProyects { get; set; } 
        public IRPSCheckbox<ResupplyListingView> bIndustrialMaintenance { get; set; } 
        public IRPSCheckbox<ResupplyListingView> bDeliveryPlanPurchase { get; set; } 
        public IRPSCheckbox<ResupplyListingView> bDeliveryPlanSales { get; set; } 
        public IRPSButton<ResupplyListingView> ExecuteQuery { get; set; } 
        public IRPSTextBox<ResupplyListingView> Proposal { get; set; } 
        public IRPSTextBox<ResupplyListingView> Proposal1 { get; set; } 
        public IRPSTextBox<ResupplyListingView> Proposal2 { get; set; } 
        public IRPSButton<ResupplyListingView> GenerateProposalsCommandButton { get; set; } 
        public ResupplyListingCollectionEditor<ResupplyListingView> ResupplyListing { get; set; } 
        public ResupplyChildrenCollectionEditor<ResupplyListingView> ResupplyChildren { get; set; } 
        public ResupplyListingSiteCollectionEditor<ResupplyListingView> ResupplyListingSite { get; set; } 
        public ResupplyChildrenCollectionEditor<ResupplyListingView> ResupplyChildren1 { get; set; } 
        public ResupplyListingWarehouseCollectionEditor<ResupplyListingView> ResupplyListingWarehouse { get; set; } 
        public ResupplyChildrenCollectionEditor<ResupplyListingView> ResupplyChildren2 { get; set; } 
        public ResupplyListing Screen { get; set; }
        public ResupplyListingView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class ResupplyListingCollectionEditor<ResupplyListingView>:RPSCollectionEditor<ResupplyListingView> where ResupplyListingView : class, IView
    {
        public  ResupplyListingGridView<ResupplyListingView> GridView {get;set;}
    }
    public partial class ResupplyListingGridView <ResupplyListingView> :  RPSGridView<ResupplyListingView> where ResupplyListingView : class, IView
    {
        public ResupplyListingGridView(ResupplyListingView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Proposal = RPSControlFactory.CreateRPSGridFormattedTextBox<ResupplyListingView>("","#6560eec0-d213-4f39-926b-e8882373f1e0 .ag-row[role='row']@ROWINDEX [col-id='cProposal']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ResupplyListingView> Proposal { get; set; } 
                     
    }
 
        public partial class ResupplyChildrenCollectionEditor<ResupplyListingView>:RPSCollectionEditor<ResupplyListingView> where ResupplyListingView : class, IView
    {
        public  ResupplyChildrenGridView<ResupplyListingView> GridView {get;set;}
    }
    public partial class ResupplyChildrenGridView <ResupplyListingView> :  RPSGridView<ResupplyListingView> where ResupplyListingView : class, IView
    {
        public ResupplyChildrenGridView(ResupplyListingView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Type = RPSControlFactory.CreateRPSGridTextBox<ResupplyListingView>("","#86a53cd2-6910-4ddd-9665-7bcacdd95614 .ag-row[role='row']@ROWINDEX [col-id='cType']","",false, this.CurrentView);
 
            Date = RPSControlFactory.CreateRPSGridTextBox<ResupplyListingView>("","#86a53cd2-6910-4ddd-9665-7bcacdd95614 .ag-row[role='row']@ROWINDEX [col-id='cDate']","",false, this.CurrentView);
 
            InternalCode = RPSControlFactory.CreateRPSGridTextBox<ResupplyListingView>("","#86a53cd2-6910-4ddd-9665-7bcacdd95614 .ag-row[role='row']@ROWINDEX [col-id='cInternalCode']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ResupplyListingView> Type { get; set; } 
        public IRPSGridTextBox<ResupplyListingView> Date { get; set; } 
        public IRPSGridTextBox<ResupplyListingView> InternalCode { get; set; } 
                     
    }
 
        public partial class ResupplyListingSiteCollectionEditor<ResupplyListingView>:RPSCollectionEditor<ResupplyListingView> where ResupplyListingView : class, IView
    {
        public  ResupplyListingSiteGridView<ResupplyListingView> GridView {get;set;}
    }
    public partial class ResupplyListingSiteGridView <ResupplyListingView> :  RPSGridView<ResupplyListingView> where ResupplyListingView : class, IView
    {
        public ResupplyListingSiteGridView(ResupplyListingView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Proposal = RPSControlFactory.CreateRPSGridFormattedTextBox<ResupplyListingView>("","#0f84345c-a6bd-4a59-bfb0-61ccadc05447 .ag-row[role='row']@ROWINDEX [col-id='cProposal']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ResupplyListingView> Proposal { get; set; } 
                     
    }
 
        public partial class ResupplyListingWarehouseCollectionEditor<ResupplyListingView>:RPSCollectionEditor<ResupplyListingView> where ResupplyListingView : class, IView
    {
        public  ResupplyListingWarehouseGridView<ResupplyListingView> GridView {get;set;}
    }
    public partial class ResupplyListingWarehouseGridView <ResupplyListingView> :  RPSGridView<ResupplyListingView> where ResupplyListingView : class, IView
    {
        public ResupplyListingWarehouseGridView(ResupplyListingView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Proposal = RPSControlFactory.CreateRPSGridFormattedTextBox<ResupplyListingView>("","#d7f799a2-e921-4d4a-938a-18eafa180c94 .ag-row[role='row']@ROWINDEX [col-id='cProposal']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<ResupplyListingView> Proposal { get; set; } 
                     
    }
 
    }
  
    

}