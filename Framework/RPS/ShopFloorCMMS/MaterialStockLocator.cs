    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.ShopFloorCMMS.MaterialStockLocator
{
    //RPS VERSION 1.0.0.0
    public partial class MaterialStockLocator:Screen
    {
        public MaterialStockLocator():base()
        {
            this.URL = "shopfloorcmms.materialstocklocator";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            MaterialStockLocatorQueryView  = new MaterialStockLocatorQueryView(this); 
            MaterialStockLocatorQueryView.InitializeControls(); 
           
        }
      
            public MaterialStockLocatorQueryView MaterialStockLocatorQueryView {get; set; } 
    }
            
    public partial class MaterialStockLocatorQueryView : View
    {
        public MaterialStockLocatorQueryView(MaterialStockLocator screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            IDArticle = RPSControlFactory.CreateRPSComboBox<MaterialStockLocatorQueryView>("47c49cdf-2c85-42f5-adfc-161bf9d790fa","","",false, this);
 
            Series = RPSControlFactory.CreateRPSEnumComboBox<MaterialStockLocatorQueryView>("6cda7eb0-69bd-4684-b465-000273b87d72","","",false, this);
 
            IDLocationWarehouse = RPSControlFactory.CreateRPSComboBox<MaterialStockLocatorQueryView>("99150607-f3f9-4019-bcff-60d7531252b0","","",false, this);
 
            SelectMaintenanceWorkerNavigationCommandButton = RPSControlFactory.CreateRPSButton<MaterialStockLocatorQueryView>( "2c0e3639-4759-4ce4-86f2-02c85f474a6f","","",this);
 
            TicketRequestNavigationCommandButton = RPSControlFactory.CreateRPSButton<MaterialStockLocatorQueryView>( "c43f966d-dd7a-4127-bed3-ef7d2ca5e8be","","",this);
 
            WorkOrdersFollowUpNavigationCommandButton = RPSControlFactory.CreateRPSButton<MaterialStockLocatorQueryView>( "4d949d1a-499e-4cde-b5ee-887606aad9c5","","",this);
 
            MOHistoricNavigationCommandButton = RPSControlFactory.CreateRPSButton<MaterialStockLocatorQueryView>( "eee89ec2-3260-4fe3-aad9-3783718a0a5a","","",this);
 
            ShopfloorDocumentationNavigationCommandButton = RPSControlFactory.CreateRPSButton<MaterialStockLocatorQueryView>( "5a9ac95c-28cf-4ced-9e23-aa6b24c4e950","","",this);
 
            CollectionInit params_MaterialStockLocator = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="820650b3-d823-414e-ae84-76894a885421",CSSSelectorGrid="",XPathGrid=""};
            MaterialStockLocator = RPSControlFactory.RPSCreateCollectionWithGrid<MaterialStockLocatorCollectionEditor<MaterialStockLocatorQueryView>,MaterialStockLocatorQueryView>( params_MaterialStockLocator,this);
 

        }
        public IRPSComboBox<MaterialStockLocatorQueryView> IDArticle { get; set; } 
        public IRPSComboBox<MaterialStockLocatorQueryView> Series { get; set; } 
        public IRPSComboBox<MaterialStockLocatorQueryView> IDLocationWarehouse { get; set; } 
        public IRPSButton<MaterialStockLocatorQueryView> SelectMaintenanceWorkerNavigationCommandButton { get; set; } 
        public IRPSButton<MaterialStockLocatorQueryView> TicketRequestNavigationCommandButton { get; set; } 
        public IRPSButton<MaterialStockLocatorQueryView> WorkOrdersFollowUpNavigationCommandButton { get; set; } 
        public IRPSButton<MaterialStockLocatorQueryView> MOHistoricNavigationCommandButton { get; set; } 
        public IRPSButton<MaterialStockLocatorQueryView> ShopfloorDocumentationNavigationCommandButton { get; set; } 
        public MaterialStockLocatorCollectionEditor<MaterialStockLocatorQueryView> MaterialStockLocator { get; set; } 
        public MaterialStockLocator Screen { get; set; }
        public MaterialStockLocatorQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class MaterialStockLocatorCollectionEditor<MaterialStockLocatorQueryView>:RPSCollectionEditor<MaterialStockLocatorQueryView> where MaterialStockLocatorQueryView : class, IView
    {
        public  MaterialStockLocatorGridView<MaterialStockLocatorQueryView> GridView {get;set;}
    }
    public partial class MaterialStockLocatorGridView <MaterialStockLocatorQueryView> :  RPSGridView<MaterialStockLocatorQueryView> where MaterialStockLocatorQueryView : class, IView
    {
        public MaterialStockLocatorGridView(MaterialStockLocatorQueryView currentView)
        {
            this.WebDriver = currentView.WebDriver;          
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            Stock_Series = RPSControlFactory.CreateRPSGridTextBox<MaterialStockLocatorQueryView>("","#820650b3-d823-414e-ae84-76894a885421 .ag-row[role='row']@ROWINDEX [col-id='cStock_Series']","",false, this.CurrentView);
 

        }
        public IRPSGridTextBox<MaterialStockLocatorQueryView> Stock_Series { get; set; } 
                     
    }
 
    }
  
    

}