    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Warehouse.CuDistUserWare
{
    //RPS VERSION 1.0.0.0
    public partial class CuDistUserWare:Screen
    {
        public CuDistUserWare():base()
        {
            this.URL = "warehouse.cudistuserware";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CuDistUserWHVMQueryView  = new CuDistUserWHVMQueryView(this); 
            CuDistUserWHVMEntityView  = new CuDistUserWHVMEntityView(this); 
            CuDistUserWHVMQueryView.InitializeControls(); 
            CuDistUserWHVMEntityView.InitializeControls(); 
           
        }
      
            public CuDistUserWHVMQueryView CuDistUserWHVMQueryView {get; set; } 
            public CuDistUserWHVMEntityView CuDistUserWHVMEntityView {get; set; } 
    }
            
    public partial class CuDistUserWHVMQueryView : View
    {
        public CuDistUserWHVMQueryView(CuDistUserWare screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CuDistUserWHVMQueryView,CuDistUserWHVMEntityView>( this,Screen.CuDistUserWHVMEntityView);
 
            ConsultButton = RPSControlFactory.RPSConsultButton<CuDistUserWHVMQueryView>( this);
 
            IDSiteFilter = RPSControlFactory.CreateRPSComboBox<CuDistUserWHVMQueryView>("73299bfb-1bab-4f2d-a8c6-686a3c1f655f","","",false, this);
 
            IDWarehouseFilter = RPSControlFactory.CreateRPSComboBox<CuDistUserWHVMQueryView>("ee75a96a-c08c-4a36-a1f8-1a7d5244cd80","","",false, this);
 
            NewEntityCommandButton = RPSControlFactory.CreateRPSButton<CuDistUserWHVMQueryView>( "e1451e08-2e32-4066-b7b8-d01698dbc27d","","",this);
 
            CollectionInit params_CuDistUserWareQuery = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="5194e4dc-2423-4720-af4e-98c3333247fb",CSSSelectorGrid="",XPathGrid=""};
            CuDistUserWareQuery = RPSControlFactory.RPSCreateCollectionWithGrid<CuDistUserWareQueryCollectionEditor<CuDistUserWHVMQueryView,CuDistUserWHVMEntityView>,CuDistUserWHVMQueryView,CuDistUserWHVMEntityView>( params_CuDistUserWareQuery,this,Screen.CuDistUserWHVMEntityView);
 

        }
        public IRPSButton<CuDistUserWHVMQueryView,CuDistUserWHVMEntityView> NewButton { get; set; } 
        public IRPSButton<CuDistUserWHVMQueryView> ConsultButton { get; set; } 
        public IRPSComboBox<CuDistUserWHVMQueryView> IDSiteFilter { get; set; } 
        public IRPSComboBox<CuDistUserWHVMQueryView> IDWarehouseFilter { get; set; } 
        public IRPSButton<CuDistUserWHVMQueryView> NewEntityCommandButton { get; set; } 
        public CuDistUserWareQueryCollectionEditor<CuDistUserWHVMQueryView,CuDistUserWHVMEntityView> CuDistUserWareQuery { get; set; } 
        public CuDistUserWare Screen { get; set; }
        public CuDistUserWHVMQueryView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class CuDistUserWareQueryCollectionEditor<CuDistUserWHVMQueryView,CuDistUserWHVMEntityView>:RPSCollectionEditor<CuDistUserWHVMQueryView,CuDistUserWHVMEntityView> where CuDistUserWHVMQueryView : class, IView where CuDistUserWHVMEntityView : class, IView
    {
        public  CuDistUserWareQueryGridView<CuDistUserWHVMQueryView,CuDistUserWHVMEntityView> GridView {get;set;}
    }
    public partial class CuDistUserWareQueryGridView <CuDistUserWHVMQueryView,CuDistUserWHVMEntityView> :  RPSGridView<CuDistUserWHVMQueryView,CuDistUserWHVMEntityView> where CuDistUserWHVMQueryView : class, IView where CuDistUserWHVMEntityView : class, IView
    {
        public CuDistUserWareQueryGridView(CuDistUserWHVMQueryView currentView,CuDistUserWHVMEntityView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            CuDistUserWH_CodUser = RPSControlFactory.CreateRPSGridComboBox<CuDistUserWHVMQueryView>("","#5194e4dc-2423-4720-af4e-98c3333247fb .ag-row[role='row']@ROWINDEX [col-id='cCuDistUserWH_CodUser']","",false, this.CurrentView);
 

        }
        public IRPSGridComboBox<CuDistUserWHVMQueryView> CuDistUserWH_CodUser { get; set; } 
                     
    }
 
    }
  
            
    public partial class CuDistUserWHVMEntityView : View
    {
        public CuDistUserWHVMEntityView(CuDistUserWare screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CuDistUserWHVMEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CuDistUserWHVMEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CuDistUserWHVMEntityView,CuDistUserWHVMQueryView>( this,Screen.CuDistUserWHVMQueryView);
 
            BackButton = RPSControlFactory.RPSBackButton<CuDistUserWHVMEntityView,CuDistUserWHVMQueryView>( this,Screen.CuDistUserWHVMQueryView);
 
            CodUser = RPSControlFactory.CreateRPSComboBox<CuDistUserWHVMEntityView>("8fd68ba1-4ab6-4466-8c4e-163bda520531","","",true, this);
 
            IDSite = RPSControlFactory.CreateRPSComboBox<CuDistUserWHVMEntityView>("dd58e6e0-629d-4eb4-9b3c-fe615312b356","","",true, this);
 
            IDWarehouse = RPSControlFactory.CreateRPSComboBox<CuDistUserWHVMEntityView>("b1a55b17-01f8-4be1-969a-0cecee099d6a","","",true, this);
 

        }
        public IRPSSaveButton<CuDistUserWHVMEntityView> SaveButton { get; set; } 
        public IRPSButton<CuDistUserWHVMEntityView> DeleteButton { get; set; } 
        public IRPSButton<CuDistUserWHVMEntityView,CuDistUserWHVMQueryView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CuDistUserWHVMEntityView,CuDistUserWHVMQueryView> BackButton { get; set; } 
        public IRPSComboBox<CuDistUserWHVMEntityView> CodUser { get; set; } 
        public IRPSComboBox<CuDistUserWHVMEntityView> IDSite { get; set; } 
        public IRPSComboBox<CuDistUserWHVMEntityView> IDWarehouse { get; set; } 
        public CuDistUserWare Screen { get; set; }
        public CuDistUserWHVMEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}