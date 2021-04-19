    
using RPSSeleniumProperties;
using RPSSeleniumProperties.Interactables;
using RPSSeleniumProperties.Interfaces;
using RPSSeleniumProperties.Interfaces.Interactables;
using RPSSeleniumProperties.viewmodels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace SeleniumGeneratedClasses.Framework.RPS.Services.Project.CostComponent
{
    //RPS VERSION 1.0.0.0
    public partial class CostComponent:Screen
    {
        public CostComponent():base()
        {
            this.URL = "project.costcomponent";
            InitViews();
           
           
        }       
        protected void InitViews()
        {
            CostComponentCollectionView  = new CostComponentCollectionView(this); 
            CostComponentEntityView  = new CostComponentEntityView(this); 
            CostComponentCostView  = new CostComponentCostView(this); 
            CostComponentCollectionView.InitializeControls(); 
            CostComponentEntityView.InitializeControls(); 
            CostComponentCostView.InitializeControls(); 
           
        }
      
            public CostComponentCollectionView CostComponentCollectionView {get; set; } 
            public CostComponentEntityView CostComponentEntityView {get; set; } 
            public CostComponentCostView CostComponentCostView {get; set; } 
    }
            
    public partial class CostComponentCollectionView : View
    {
        public CostComponentCollectionView(CostComponent screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            NewButton = RPSControlFactory.RPSNewButton<CostComponentCollectionView,CostComponentEntityView>( this,Screen.CostComponentEntityView);
 
            CollectionInit params_MainConsult = new CollectionInit(){IDDescriptor = "3998c2b6-332e-4f36-92ee-c88ea692a1f0",CSSSelectorDescriptor = "",XPathDescriptor = ""};
            MainConsult = RPSControlFactory.RPSCreateCollection<CostComponentCollectionView,CostComponentEntityView>( params_MainConsult,this,Screen.CostComponentEntityView);
 

        }
        public IRPSButton<CostComponentCollectionView,CostComponentEntityView> NewButton { get; set; } 
        public IRPSCollectionEditor<CostComponentCollectionView,CostComponentEntityView> MainConsult { get; set; } 
        public CostComponent Screen { get; set; }
        public CostComponentCollectionView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
            
    public partial class CostComponentEntityView : View
    {
        public CostComponentEntityView(CostComponent screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            SaveButton = RPSControlFactory.RPSSaveButton<CostComponentEntityView>( this);
 
            DeleteButton = RPSControlFactory.RPSDeleteButton<CostComponentEntityView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CostComponentEntityView,CostComponentCollectionView>( this,Screen.CostComponentCollectionView);
 
            BackButton = RPSControlFactory.RPSBackButton<CostComponentEntityView,CostComponentCollectionView>( this,Screen.CostComponentCollectionView);
 
            CodCostComponent = RPSControlFactory.CreateRPSTextBox<CostComponentEntityView>("65acb170-e92d-4e44-8d03-13ef374c55a9","","",true, this);
 
            Description = RPSControlFactory.CreateRPSTextBox<CostComponentEntityView>("8ffd2903-ce3d-41aa-ad26-bd6251a5224b","","",false, this);
 
            Abreviature = RPSControlFactory.CreateRPSTextBox<CostComponentEntityView>("c8620f0f-226b-4c28-ad48-0855e0da413c","","",false, this);
 
            CollectionInit params_PROCostComponentCosts = new CollectionInit(){IDDescriptor = "",CSSSelectorDescriptor = "",XPathDescriptor = "",IDGrid="6d3f19c2-aeac-457c-bd9b-67cca7dd1760",CSSSelectorGrid="",XPathGrid=""};
            PROCostComponentCosts = RPSControlFactory.RPSCreateCollectionWithGrid<PROCostComponentCostsCollectionEditor<CostComponentEntityView,CostComponentCostView>,CostComponentEntityView,CostComponentCostView>( params_PROCostComponentCosts,this,Screen.CostComponentCostView);
 

        }
        public IRPSSaveButton<CostComponentEntityView> SaveButton { get; set; } 
        public IRPSButton<CostComponentEntityView> DeleteButton { get; set; } 
        public IRPSButton<CostComponentEntityView,CostComponentCollectionView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CostComponentEntityView,CostComponentCollectionView> BackButton { get; set; } 
        public IRPSTextBox<CostComponentEntityView> CodCostComponent { get; set; } 
        public IRPSTextBox<CostComponentEntityView> Description { get; set; } 
        public IRPSTextBox<CostComponentEntityView> Abreviature { get; set; } 
        public PROCostComponentCostsCollectionEditor<CostComponentEntityView,CostComponentCostView> PROCostComponentCosts { get; set; } 
        public CostComponent Screen { get; set; }
        public CostComponentEntityView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
        public partial class PROCostComponentCostsCollectionEditor<CostComponentEntityView,CostComponentCostView>:RPSCollectionEditor<CostComponentEntityView,CostComponentCostView> where CostComponentEntityView : class, IView where CostComponentCostView : class, IView
    {
        public  PROCostComponentCostsGridView<CostComponentEntityView,CostComponentCostView> GridView {get;set;}
    }
    public partial class PROCostComponentCostsGridView <CostComponentEntityView,CostComponentCostView> :  RPSGridView<CostComponentEntityView,CostComponentCostView> where CostComponentEntityView : class, IView where CostComponentCostView : class, IView
    {
        public PROCostComponentCostsGridView(CostComponentEntityView currentView,CostComponentCostView newView)
        {
            this.WebDriver = currentView.WebDriver;
            this.NewView = newView;
            this.CurrentView = currentView;
            InitializeControls();
        }

        public void InitializeControls()
        {
            DateFrom = RPSControlFactory.CreateRPSGridTextBox<CostComponentEntityView>("","#6d3f19c2-aeac-457c-bd9b-67cca7dd1760 .ag-row[role='row']@ROWINDEX [col-id='cDateFrom']","",true, this.CurrentView);
 
            CostPrice = RPSControlFactory.CreateRPSGridFormattedTextBox<CostComponentEntityView>("","#6d3f19c2-aeac-457c-bd9b-67cca7dd1760 .ag-row[role='row']@ROWINDEX [col-id='cCostPrice']","",true, this.CurrentView);
 

        }
        public IRPSGridTextBox<CostComponentEntityView> DateFrom { get; set; } 
        public IRPSGridTextBox<CostComponentEntityView> CostPrice { get; set; } 
                     
    }
 
    }
  
            
    public partial class CostComponentCostView : View
    {
        public CostComponentCostView(CostComponent screen) : base()
        {
            this.WebDriver = screen.WebDriver;
            this.Screen = screen;
           
        }

        public void InitializeControls()
        {
            DeleteButton = RPSControlFactory.RPSDeleteButton<CostComponentCostView>( this);
 
            ConfirmDeleteButton = RPSControlFactory.RPSConfirmDeleteButton<CostComponentCostView,CostComponentEntityView>( this,Screen.CostComponentEntityView);
 
            BackButton = RPSControlFactory.RPSBackButton<CostComponentCostView,CostComponentEntityView>( this,Screen.CostComponentEntityView);
 
            AcceptButton = RPSControlFactory.RPSAcceptButton<CostComponentCostView,CostComponentEntityView>( this,Screen.CostComponentEntityView);
 
            DateFrom = RPSControlFactory.CreateRPSTextBox<CostComponentCostView>("16ff6474-f39d-4fd9-b3e5-64486c9fd34c","","",true, this);
 
            CostPrice = RPSControlFactory.CreateRPSFormattedTextBox<CostComponentCostView>("6ff4036d-ee34-4f90-bae6-1f35070b8493","","",true, this);
 

        }
        public IRPSButton<CostComponentCostView> DeleteButton { get; set; } 
        public IRPSButton<CostComponentCostView,CostComponentEntityView> ConfirmDeleteButton { get; set; } 
        public IRPSButton<CostComponentCostView,CostComponentEntityView> BackButton { get; set; } 
        public IRPSAcceptButton<CostComponentCostView,CostComponentEntityView> AcceptButton { get; set; } 
        public IRPSTextBox<CostComponentCostView> DateFrom { get; set; } 
        public IRPSTextBox<CostComponentCostView> CostPrice { get; set; } 
        public CostComponent Screen { get; set; }
        public CostComponentCostView Wait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return this;
        }
      
    
    }
  
    

}